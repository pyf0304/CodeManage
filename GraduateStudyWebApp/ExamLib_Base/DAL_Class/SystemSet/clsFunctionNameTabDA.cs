
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFunctionNameTabDA
 表名:FunctionNameTab(01120204)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:18:41
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统设置(SystemSet)
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
 /// 函数名表(FunctionNameTab)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsFunctionNameTabDA : clsCommBase4DA
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
 return clsFunctionNameTabEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsFunctionNameTabEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsFunctionNameTabEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsFunctionNameTabEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsFunctionNameTabEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strFunctionId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strFunctionId)
{
strFunctionId = strFunctionId.Replace("'", "''");
if (strFunctionId.Length > 4)
{
throw new Exception("(errid:Data000001)在表:FunctionNameTab中,检查关键字,长度不正确!(clsFunctionNameTabDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strFunctionId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:FunctionNameTab中,关键字不能为空 或 null!(clsFunctionNameTabDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strFunctionId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsFunctionNameTabDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsFunctionNameTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionNameTabDA.GetSpecSQLObj();
strSQL = "Select * from FunctionNameTab where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_FunctionNameTab(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsFunctionNameTabDA: GetDataTable_FunctionNameTab)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionNameTabDA.GetSpecSQLObj();
strSQL = "Select * from FunctionNameTab where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsFunctionNameTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionNameTabDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsFunctionNameTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionNameTabDA.GetSpecSQLObj();
strSQL = "Select * from FunctionNameTab where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsFunctionNameTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionNameTabDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsFunctionNameTabDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionNameTabDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from FunctionNameTab where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from FunctionNameTab where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsFunctionNameTabDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionNameTabDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from FunctionNameTab where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsFunctionNameTabDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionNameTabDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} FunctionNameTab.* from FunctionNameTab Left Join {1} on {2} where {3} and FunctionNameTab.FunctionId not in (Select top {5} FunctionNameTab.FunctionId from FunctionNameTab Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from FunctionNameTab where {1} and FunctionId not in (Select top {2} FunctionId from FunctionNameTab where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from FunctionNameTab where {1} and FunctionId not in (Select top {3} FunctionId from FunctionNameTab where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsFunctionNameTabDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionNameTabDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} FunctionNameTab.* from FunctionNameTab Left Join {1} on {2} where {3} and FunctionNameTab.FunctionId not in (Select top {5} FunctionNameTab.FunctionId from FunctionNameTab Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from FunctionNameTab where {1} and FunctionId not in (Select top {2} FunctionId from FunctionNameTab where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from FunctionNameTab where {1} and FunctionId not in (Select top {3} FunctionId from FunctionNameTab where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsFunctionNameTabEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsFunctionNameTabDA:GetObjLst)", objException.Message));
}
List<clsFunctionNameTabEN> arrObjLst = new List<clsFunctionNameTabEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionNameTabDA.GetSpecSQLObj();
strSQL = "Select * from FunctionNameTab where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunctionNameTabEN objFunctionNameTabEN = new clsFunctionNameTabEN();
try
{
objFunctionNameTabEN.FunctionId = objRow[conFunctionNameTab.FunctionId].ToString().Trim(); //功能Id
objFunctionNameTabEN.FunctionName = objRow[conFunctionNameTab.FunctionName].ToString().Trim(); //函数名
objFunctionNameTabEN.FunctionNameCH = objRow[conFunctionNameTab.FunctionNameCH] == DBNull.Value ? null : objRow[conFunctionNameTab.FunctionNameCH].ToString().Trim(); //功能中文名
objFunctionNameTabEN.ModuleName = objRow[conFunctionNameTab.ModuleName] == DBNull.Value ? null : objRow[conFunctionNameTab.ModuleName].ToString().Trim(); //模块名
objFunctionNameTabEN.IsStudent = TransNullToBool(objRow[conFunctionNameTab.IsStudent].ToString().Trim()); //是否学生
objFunctionNameTabEN.IsTeacher = TransNullToBool(objRow[conFunctionNameTab.IsTeacher].ToString().Trim()); //是否教师
objFunctionNameTabEN.IsQuestion = TransNullToBool(objRow[conFunctionNameTab.IsQuestion].ToString().Trim()); //是否题目
objFunctionNameTabEN.ConstName = objRow[conFunctionNameTab.ConstName] == DBNull.Value ? null : objRow[conFunctionNameTab.ConstName].ToString().Trim(); //常量名
objFunctionNameTabEN.PagePath = objRow[conFunctionNameTab.PagePath] == DBNull.Value ? null : objRow[conFunctionNameTab.PagePath].ToString().Trim(); //页面路径
objFunctionNameTabEN.PageName = objRow[conFunctionNameTab.PageName] == DBNull.Value ? null : objRow[conFunctionNameTab.PageName].ToString().Trim(); //页面名称
objFunctionNameTabEN.OrderNum = objRow[conFunctionNameTab.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFunctionNameTab.OrderNum].ToString().Trim()); //序号
objFunctionNameTabEN.UpdDate = objRow[conFunctionNameTab.UpdDate] == DBNull.Value ? null : objRow[conFunctionNameTab.UpdDate].ToString().Trim(); //修改日期
objFunctionNameTabEN.UpdUser = objRow[conFunctionNameTab.UpdUser] == DBNull.Value ? null : objRow[conFunctionNameTab.UpdUser].ToString().Trim(); //修改人
objFunctionNameTabEN.Memo = objRow[conFunctionNameTab.Memo] == DBNull.Value ? null : objRow[conFunctionNameTab.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsFunctionNameTabDA: GetObjLst)", objException.Message));
}
objFunctionNameTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objFunctionNameTabEN);
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
public List<clsFunctionNameTabEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsFunctionNameTabDA:GetObjLstByTabName)", objException.Message));
}
List<clsFunctionNameTabEN> arrObjLst = new List<clsFunctionNameTabEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionNameTabDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunctionNameTabEN objFunctionNameTabEN = new clsFunctionNameTabEN();
try
{
objFunctionNameTabEN.FunctionId = objRow[conFunctionNameTab.FunctionId].ToString().Trim(); //功能Id
objFunctionNameTabEN.FunctionName = objRow[conFunctionNameTab.FunctionName].ToString().Trim(); //函数名
objFunctionNameTabEN.FunctionNameCH = objRow[conFunctionNameTab.FunctionNameCH] == DBNull.Value ? null : objRow[conFunctionNameTab.FunctionNameCH].ToString().Trim(); //功能中文名
objFunctionNameTabEN.ModuleName = objRow[conFunctionNameTab.ModuleName] == DBNull.Value ? null : objRow[conFunctionNameTab.ModuleName].ToString().Trim(); //模块名
objFunctionNameTabEN.IsStudent = TransNullToBool(objRow[conFunctionNameTab.IsStudent].ToString().Trim()); //是否学生
objFunctionNameTabEN.IsTeacher = TransNullToBool(objRow[conFunctionNameTab.IsTeacher].ToString().Trim()); //是否教师
objFunctionNameTabEN.IsQuestion = TransNullToBool(objRow[conFunctionNameTab.IsQuestion].ToString().Trim()); //是否题目
objFunctionNameTabEN.ConstName = objRow[conFunctionNameTab.ConstName] == DBNull.Value ? null : objRow[conFunctionNameTab.ConstName].ToString().Trim(); //常量名
objFunctionNameTabEN.PagePath = objRow[conFunctionNameTab.PagePath] == DBNull.Value ? null : objRow[conFunctionNameTab.PagePath].ToString().Trim(); //页面路径
objFunctionNameTabEN.PageName = objRow[conFunctionNameTab.PageName] == DBNull.Value ? null : objRow[conFunctionNameTab.PageName].ToString().Trim(); //页面名称
objFunctionNameTabEN.OrderNum = objRow[conFunctionNameTab.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFunctionNameTab.OrderNum].ToString().Trim()); //序号
objFunctionNameTabEN.UpdDate = objRow[conFunctionNameTab.UpdDate] == DBNull.Value ? null : objRow[conFunctionNameTab.UpdDate].ToString().Trim(); //修改日期
objFunctionNameTabEN.UpdUser = objRow[conFunctionNameTab.UpdUser] == DBNull.Value ? null : objRow[conFunctionNameTab.UpdUser].ToString().Trim(); //修改人
objFunctionNameTabEN.Memo = objRow[conFunctionNameTab.Memo] == DBNull.Value ? null : objRow[conFunctionNameTab.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsFunctionNameTabDA: GetObjLst)", objException.Message));
}
objFunctionNameTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objFunctionNameTabEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objFunctionNameTabEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetFunctionNameTab(ref clsFunctionNameTabEN objFunctionNameTabEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionNameTabDA.GetSpecSQLObj();
strSQL = "Select * from FunctionNameTab where FunctionId = " + "'"+ objFunctionNameTabEN.FunctionId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objFunctionNameTabEN.FunctionId = objDT.Rows[0][conFunctionNameTab.FunctionId].ToString().Trim(); //功能Id(字段类型:char,字段长度:4,是否可空:True)
 objFunctionNameTabEN.FunctionName = objDT.Rows[0][conFunctionNameTab.FunctionName].ToString().Trim(); //函数名(字段类型:varchar,字段长度:100,是否可空:True)
 objFunctionNameTabEN.FunctionNameCH = objDT.Rows[0][conFunctionNameTab.FunctionNameCH].ToString().Trim(); //功能中文名(字段类型:varchar,字段长度:255,是否可空:True)
 objFunctionNameTabEN.ModuleName = objDT.Rows[0][conFunctionNameTab.ModuleName].ToString().Trim(); //模块名(字段类型:varchar,字段长度:255,是否可空:True)
 objFunctionNameTabEN.IsStudent = TransNullToBool(objDT.Rows[0][conFunctionNameTab.IsStudent].ToString().Trim()); //是否学生(字段类型:bit,字段长度:1,是否可空:True)
 objFunctionNameTabEN.IsTeacher = TransNullToBool(objDT.Rows[0][conFunctionNameTab.IsTeacher].ToString().Trim()); //是否教师(字段类型:bit,字段长度:1,是否可空:True)
 objFunctionNameTabEN.IsQuestion = TransNullToBool(objDT.Rows[0][conFunctionNameTab.IsQuestion].ToString().Trim()); //是否题目(字段类型:bit,字段长度:1,是否可空:True)
 objFunctionNameTabEN.ConstName = objDT.Rows[0][conFunctionNameTab.ConstName].ToString().Trim(); //常量名(字段类型:varchar,字段长度:255,是否可空:True)
 objFunctionNameTabEN.PagePath = objDT.Rows[0][conFunctionNameTab.PagePath].ToString().Trim(); //页面路径(字段类型:varchar,字段长度:50,是否可空:True)
 objFunctionNameTabEN.PageName = objDT.Rows[0][conFunctionNameTab.PageName].ToString().Trim(); //页面名称(字段类型:varchar,字段长度:100,是否可空:True)
 objFunctionNameTabEN.OrderNum = TransNullToInt(objDT.Rows[0][conFunctionNameTab.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objFunctionNameTabEN.UpdDate = objDT.Rows[0][conFunctionNameTab.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objFunctionNameTabEN.UpdUser = objDT.Rows[0][conFunctionNameTab.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objFunctionNameTabEN.Memo = objDT.Rows[0][conFunctionNameTab.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsFunctionNameTabDA: GetFunctionNameTab)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strFunctionId">表关键字</param>
 /// <returns>表对象</returns>
public clsFunctionNameTabEN GetObjByFunctionId(string strFunctionId)
{
CheckPrimaryKey(strFunctionId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionNameTabDA.GetSpecSQLObj();
strSQL = "Select * from FunctionNameTab where FunctionId = " + "'"+ strFunctionId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsFunctionNameTabEN objFunctionNameTabEN = new clsFunctionNameTabEN();
try
{
 objFunctionNameTabEN.FunctionId = objRow[conFunctionNameTab.FunctionId].ToString().Trim(); //功能Id(字段类型:char,字段长度:4,是否可空:True)
 objFunctionNameTabEN.FunctionName = objRow[conFunctionNameTab.FunctionName].ToString().Trim(); //函数名(字段类型:varchar,字段长度:100,是否可空:True)
 objFunctionNameTabEN.FunctionNameCH = objRow[conFunctionNameTab.FunctionNameCH] == DBNull.Value ? null : objRow[conFunctionNameTab.FunctionNameCH].ToString().Trim(); //功能中文名(字段类型:varchar,字段长度:255,是否可空:True)
 objFunctionNameTabEN.ModuleName = objRow[conFunctionNameTab.ModuleName] == DBNull.Value ? null : objRow[conFunctionNameTab.ModuleName].ToString().Trim(); //模块名(字段类型:varchar,字段长度:255,是否可空:True)
 objFunctionNameTabEN.IsStudent = clsEntityBase2.TransNullToBool_S(objRow[conFunctionNameTab.IsStudent].ToString().Trim()); //是否学生(字段类型:bit,字段长度:1,是否可空:True)
 objFunctionNameTabEN.IsTeacher = clsEntityBase2.TransNullToBool_S(objRow[conFunctionNameTab.IsTeacher].ToString().Trim()); //是否教师(字段类型:bit,字段长度:1,是否可空:True)
 objFunctionNameTabEN.IsQuestion = clsEntityBase2.TransNullToBool_S(objRow[conFunctionNameTab.IsQuestion].ToString().Trim()); //是否题目(字段类型:bit,字段长度:1,是否可空:True)
 objFunctionNameTabEN.ConstName = objRow[conFunctionNameTab.ConstName] == DBNull.Value ? null : objRow[conFunctionNameTab.ConstName].ToString().Trim(); //常量名(字段类型:varchar,字段长度:255,是否可空:True)
 objFunctionNameTabEN.PagePath = objRow[conFunctionNameTab.PagePath] == DBNull.Value ? null : objRow[conFunctionNameTab.PagePath].ToString().Trim(); //页面路径(字段类型:varchar,字段长度:50,是否可空:True)
 objFunctionNameTabEN.PageName = objRow[conFunctionNameTab.PageName] == DBNull.Value ? null : objRow[conFunctionNameTab.PageName].ToString().Trim(); //页面名称(字段类型:varchar,字段长度:100,是否可空:True)
 objFunctionNameTabEN.OrderNum = objRow[conFunctionNameTab.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFunctionNameTab.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objFunctionNameTabEN.UpdDate = objRow[conFunctionNameTab.UpdDate] == DBNull.Value ? null : objRow[conFunctionNameTab.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objFunctionNameTabEN.UpdUser = objRow[conFunctionNameTab.UpdUser] == DBNull.Value ? null : objRow[conFunctionNameTab.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objFunctionNameTabEN.Memo = objRow[conFunctionNameTab.Memo] == DBNull.Value ? null : objRow[conFunctionNameTab.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsFunctionNameTabDA: GetObjByFunctionId)", objException.Message));
}
return objFunctionNameTabEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsFunctionNameTabEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsFunctionNameTabDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionNameTabDA.GetSpecSQLObj();
strSQL = "Select * from FunctionNameTab where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsFunctionNameTabEN objFunctionNameTabEN = new clsFunctionNameTabEN()
{
FunctionId = objRow[conFunctionNameTab.FunctionId].ToString().Trim(), //功能Id
FunctionName = objRow[conFunctionNameTab.FunctionName].ToString().Trim(), //函数名
FunctionNameCH = objRow[conFunctionNameTab.FunctionNameCH] == DBNull.Value ? null : objRow[conFunctionNameTab.FunctionNameCH].ToString().Trim(), //功能中文名
ModuleName = objRow[conFunctionNameTab.ModuleName] == DBNull.Value ? null : objRow[conFunctionNameTab.ModuleName].ToString().Trim(), //模块名
IsStudent = TransNullToBool(objRow[conFunctionNameTab.IsStudent].ToString().Trim()), //是否学生
IsTeacher = TransNullToBool(objRow[conFunctionNameTab.IsTeacher].ToString().Trim()), //是否教师
IsQuestion = TransNullToBool(objRow[conFunctionNameTab.IsQuestion].ToString().Trim()), //是否题目
ConstName = objRow[conFunctionNameTab.ConstName] == DBNull.Value ? null : objRow[conFunctionNameTab.ConstName].ToString().Trim(), //常量名
PagePath = objRow[conFunctionNameTab.PagePath] == DBNull.Value ? null : objRow[conFunctionNameTab.PagePath].ToString().Trim(), //页面路径
PageName = objRow[conFunctionNameTab.PageName] == DBNull.Value ? null : objRow[conFunctionNameTab.PageName].ToString().Trim(), //页面名称
OrderNum = objRow[conFunctionNameTab.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFunctionNameTab.OrderNum].ToString().Trim()), //序号
UpdDate = objRow[conFunctionNameTab.UpdDate] == DBNull.Value ? null : objRow[conFunctionNameTab.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conFunctionNameTab.UpdUser] == DBNull.Value ? null : objRow[conFunctionNameTab.UpdUser].ToString().Trim(), //修改人
Memo = objRow[conFunctionNameTab.Memo] == DBNull.Value ? null : objRow[conFunctionNameTab.Memo].ToString().Trim() //备注
};
objFunctionNameTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFunctionNameTabEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsFunctionNameTabDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsFunctionNameTabEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsFunctionNameTabEN objFunctionNameTabEN = new clsFunctionNameTabEN();
try
{
objFunctionNameTabEN.FunctionId = objRow[conFunctionNameTab.FunctionId].ToString().Trim(); //功能Id
objFunctionNameTabEN.FunctionName = objRow[conFunctionNameTab.FunctionName].ToString().Trim(); //函数名
objFunctionNameTabEN.FunctionNameCH = objRow[conFunctionNameTab.FunctionNameCH] == DBNull.Value ? null : objRow[conFunctionNameTab.FunctionNameCH].ToString().Trim(); //功能中文名
objFunctionNameTabEN.ModuleName = objRow[conFunctionNameTab.ModuleName] == DBNull.Value ? null : objRow[conFunctionNameTab.ModuleName].ToString().Trim(); //模块名
objFunctionNameTabEN.IsStudent = TransNullToBool(objRow[conFunctionNameTab.IsStudent].ToString().Trim()); //是否学生
objFunctionNameTabEN.IsTeacher = TransNullToBool(objRow[conFunctionNameTab.IsTeacher].ToString().Trim()); //是否教师
objFunctionNameTabEN.IsQuestion = TransNullToBool(objRow[conFunctionNameTab.IsQuestion].ToString().Trim()); //是否题目
objFunctionNameTabEN.ConstName = objRow[conFunctionNameTab.ConstName] == DBNull.Value ? null : objRow[conFunctionNameTab.ConstName].ToString().Trim(); //常量名
objFunctionNameTabEN.PagePath = objRow[conFunctionNameTab.PagePath] == DBNull.Value ? null : objRow[conFunctionNameTab.PagePath].ToString().Trim(); //页面路径
objFunctionNameTabEN.PageName = objRow[conFunctionNameTab.PageName] == DBNull.Value ? null : objRow[conFunctionNameTab.PageName].ToString().Trim(); //页面名称
objFunctionNameTabEN.OrderNum = objRow[conFunctionNameTab.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFunctionNameTab.OrderNum].ToString().Trim()); //序号
objFunctionNameTabEN.UpdDate = objRow[conFunctionNameTab.UpdDate] == DBNull.Value ? null : objRow[conFunctionNameTab.UpdDate].ToString().Trim(); //修改日期
objFunctionNameTabEN.UpdUser = objRow[conFunctionNameTab.UpdUser] == DBNull.Value ? null : objRow[conFunctionNameTab.UpdUser].ToString().Trim(); //修改人
objFunctionNameTabEN.Memo = objRow[conFunctionNameTab.Memo] == DBNull.Value ? null : objRow[conFunctionNameTab.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsFunctionNameTabDA: GetObjByDataRowFunctionNameTab)", objException.Message));
}
objFunctionNameTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFunctionNameTabEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsFunctionNameTabEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsFunctionNameTabEN objFunctionNameTabEN = new clsFunctionNameTabEN();
try
{
objFunctionNameTabEN.FunctionId = objRow[conFunctionNameTab.FunctionId].ToString().Trim(); //功能Id
objFunctionNameTabEN.FunctionName = objRow[conFunctionNameTab.FunctionName].ToString().Trim(); //函数名
objFunctionNameTabEN.FunctionNameCH = objRow[conFunctionNameTab.FunctionNameCH] == DBNull.Value ? null : objRow[conFunctionNameTab.FunctionNameCH].ToString().Trim(); //功能中文名
objFunctionNameTabEN.ModuleName = objRow[conFunctionNameTab.ModuleName] == DBNull.Value ? null : objRow[conFunctionNameTab.ModuleName].ToString().Trim(); //模块名
objFunctionNameTabEN.IsStudent = TransNullToBool(objRow[conFunctionNameTab.IsStudent].ToString().Trim()); //是否学生
objFunctionNameTabEN.IsTeacher = TransNullToBool(objRow[conFunctionNameTab.IsTeacher].ToString().Trim()); //是否教师
objFunctionNameTabEN.IsQuestion = TransNullToBool(objRow[conFunctionNameTab.IsQuestion].ToString().Trim()); //是否题目
objFunctionNameTabEN.ConstName = objRow[conFunctionNameTab.ConstName] == DBNull.Value ? null : objRow[conFunctionNameTab.ConstName].ToString().Trim(); //常量名
objFunctionNameTabEN.PagePath = objRow[conFunctionNameTab.PagePath] == DBNull.Value ? null : objRow[conFunctionNameTab.PagePath].ToString().Trim(); //页面路径
objFunctionNameTabEN.PageName = objRow[conFunctionNameTab.PageName] == DBNull.Value ? null : objRow[conFunctionNameTab.PageName].ToString().Trim(); //页面名称
objFunctionNameTabEN.OrderNum = objRow[conFunctionNameTab.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFunctionNameTab.OrderNum].ToString().Trim()); //序号
objFunctionNameTabEN.UpdDate = objRow[conFunctionNameTab.UpdDate] == DBNull.Value ? null : objRow[conFunctionNameTab.UpdDate].ToString().Trim(); //修改日期
objFunctionNameTabEN.UpdUser = objRow[conFunctionNameTab.UpdUser] == DBNull.Value ? null : objRow[conFunctionNameTab.UpdUser].ToString().Trim(); //修改人
objFunctionNameTabEN.Memo = objRow[conFunctionNameTab.Memo] == DBNull.Value ? null : objRow[conFunctionNameTab.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsFunctionNameTabDA: GetObjByDataRow)", objException.Message));
}
objFunctionNameTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFunctionNameTabEN;
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
objSQL = clsFunctionNameTabDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsFunctionNameTabEN._CurrTabName, conFunctionNameTab.FunctionId, 4, "");
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
objSQL = clsFunctionNameTabDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsFunctionNameTabEN._CurrTabName, conFunctionNameTab.FunctionId, 4, strPrefix);
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
 objSQL = clsFunctionNameTabDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select FunctionId from FunctionNameTab where " + strCondition;
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
 objSQL = clsFunctionNameTabDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select FunctionId from FunctionNameTab where " + strCondition;
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
 /// <param name = "strFunctionId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strFunctionId)
{
CheckPrimaryKey(strFunctionId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionNameTabDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("FunctionNameTab", "FunctionId = " + "'"+ strFunctionId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsFunctionNameTabDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionNameTabDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("FunctionNameTab", strCondition))
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
objSQL = clsFunctionNameTabDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("FunctionNameTab");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsFunctionNameTabEN objFunctionNameTabEN)
 {
 objFunctionNameTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFunctionNameTabEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFunctionNameTabEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionNameTabDA.GetSpecSQLObj();
strSQL = "Select * from FunctionNameTab where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "FunctionNameTab");
objRow = objDS.Tables["FunctionNameTab"].NewRow();
objRow[conFunctionNameTab.FunctionId] = objFunctionNameTabEN.FunctionId; //功能Id
objRow[conFunctionNameTab.FunctionName] = objFunctionNameTabEN.FunctionName; //函数名
 if (objFunctionNameTabEN.FunctionNameCH !=  "")
 {
objRow[conFunctionNameTab.FunctionNameCH] = objFunctionNameTabEN.FunctionNameCH; //功能中文名
 }
 if (objFunctionNameTabEN.ModuleName !=  "")
 {
objRow[conFunctionNameTab.ModuleName] = objFunctionNameTabEN.ModuleName; //模块名
 }
objRow[conFunctionNameTab.IsStudent] = objFunctionNameTabEN.IsStudent; //是否学生
objRow[conFunctionNameTab.IsTeacher] = objFunctionNameTabEN.IsTeacher; //是否教师
objRow[conFunctionNameTab.IsQuestion] = objFunctionNameTabEN.IsQuestion; //是否题目
 if (objFunctionNameTabEN.ConstName !=  "")
 {
objRow[conFunctionNameTab.ConstName] = objFunctionNameTabEN.ConstName; //常量名
 }
 if (objFunctionNameTabEN.PagePath !=  "")
 {
objRow[conFunctionNameTab.PagePath] = objFunctionNameTabEN.PagePath; //页面路径
 }
 if (objFunctionNameTabEN.PageName !=  "")
 {
objRow[conFunctionNameTab.PageName] = objFunctionNameTabEN.PageName; //页面名称
 }
objRow[conFunctionNameTab.OrderNum] = objFunctionNameTabEN.OrderNum; //序号
 if (objFunctionNameTabEN.UpdDate !=  "")
 {
objRow[conFunctionNameTab.UpdDate] = objFunctionNameTabEN.UpdDate; //修改日期
 }
 if (objFunctionNameTabEN.UpdUser !=  "")
 {
objRow[conFunctionNameTab.UpdUser] = objFunctionNameTabEN.UpdUser; //修改人
 }
 if (objFunctionNameTabEN.Memo !=  "")
 {
objRow[conFunctionNameTab.Memo] = objFunctionNameTabEN.Memo; //备注
 }
objDS.Tables[clsFunctionNameTabEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsFunctionNameTabEN._CurrTabName);
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
 /// <param name = "objFunctionNameTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsFunctionNameTabEN objFunctionNameTabEN)
{
 objFunctionNameTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFunctionNameTabEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFunctionNameTabEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objFunctionNameTabEN.FunctionId !=  null)
 {
 arrFieldListForInsert.Add(conFunctionNameTab.FunctionId);
 var strFunctionId = objFunctionNameTabEN.FunctionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionId + "'");
 }
 
 if (objFunctionNameTabEN.FunctionName !=  null)
 {
 arrFieldListForInsert.Add(conFunctionNameTab.FunctionName);
 var strFunctionName = objFunctionNameTabEN.FunctionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionName + "'");
 }
 
 if (objFunctionNameTabEN.FunctionNameCH !=  null)
 {
 arrFieldListForInsert.Add(conFunctionNameTab.FunctionNameCH);
 var strFunctionNameCH = objFunctionNameTabEN.FunctionNameCH.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionNameCH + "'");
 }
 
 if (objFunctionNameTabEN.ModuleName !=  null)
 {
 arrFieldListForInsert.Add(conFunctionNameTab.ModuleName);
 var strModuleName = objFunctionNameTabEN.ModuleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModuleName + "'");
 }
 
 arrFieldListForInsert.Add(conFunctionNameTab.IsStudent);
 arrValueListForInsert.Add("'" + (objFunctionNameTabEN.IsStudent  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conFunctionNameTab.IsTeacher);
 arrValueListForInsert.Add("'" + (objFunctionNameTabEN.IsTeacher  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conFunctionNameTab.IsQuestion);
 arrValueListForInsert.Add("'" + (objFunctionNameTabEN.IsQuestion  ==  false ? "0" : "1") + "'");
 
 if (objFunctionNameTabEN.ConstName !=  null)
 {
 arrFieldListForInsert.Add(conFunctionNameTab.ConstName);
 var strConstName = objFunctionNameTabEN.ConstName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConstName + "'");
 }
 
 if (objFunctionNameTabEN.PagePath !=  null)
 {
 arrFieldListForInsert.Add(conFunctionNameTab.PagePath);
 var strPagePath = objFunctionNameTabEN.PagePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPagePath + "'");
 }
 
 if (objFunctionNameTabEN.PageName !=  null)
 {
 arrFieldListForInsert.Add(conFunctionNameTab.PageName);
 var strPageName = objFunctionNameTabEN.PageName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPageName + "'");
 }
 
 if (objFunctionNameTabEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conFunctionNameTab.OrderNum);
 arrValueListForInsert.Add(objFunctionNameTabEN.OrderNum.ToString());
 }
 
 if (objFunctionNameTabEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conFunctionNameTab.UpdDate);
 var strUpdDate = objFunctionNameTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objFunctionNameTabEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conFunctionNameTab.UpdUser);
 var strUpdUser = objFunctionNameTabEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objFunctionNameTabEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFunctionNameTab.Memo);
 var strMemo = objFunctionNameTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FunctionNameTab");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionNameTabDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objFunctionNameTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsFunctionNameTabEN objFunctionNameTabEN)
{
 objFunctionNameTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFunctionNameTabEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFunctionNameTabEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objFunctionNameTabEN.FunctionId !=  null)
 {
 arrFieldListForInsert.Add(conFunctionNameTab.FunctionId);
 var strFunctionId = objFunctionNameTabEN.FunctionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionId + "'");
 }
 
 if (objFunctionNameTabEN.FunctionName !=  null)
 {
 arrFieldListForInsert.Add(conFunctionNameTab.FunctionName);
 var strFunctionName = objFunctionNameTabEN.FunctionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionName + "'");
 }
 
 if (objFunctionNameTabEN.FunctionNameCH !=  null)
 {
 arrFieldListForInsert.Add(conFunctionNameTab.FunctionNameCH);
 var strFunctionNameCH = objFunctionNameTabEN.FunctionNameCH.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionNameCH + "'");
 }
 
 if (objFunctionNameTabEN.ModuleName !=  null)
 {
 arrFieldListForInsert.Add(conFunctionNameTab.ModuleName);
 var strModuleName = objFunctionNameTabEN.ModuleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModuleName + "'");
 }
 
 arrFieldListForInsert.Add(conFunctionNameTab.IsStudent);
 arrValueListForInsert.Add("'" + (objFunctionNameTabEN.IsStudent  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conFunctionNameTab.IsTeacher);
 arrValueListForInsert.Add("'" + (objFunctionNameTabEN.IsTeacher  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conFunctionNameTab.IsQuestion);
 arrValueListForInsert.Add("'" + (objFunctionNameTabEN.IsQuestion  ==  false ? "0" : "1") + "'");
 
 if (objFunctionNameTabEN.ConstName !=  null)
 {
 arrFieldListForInsert.Add(conFunctionNameTab.ConstName);
 var strConstName = objFunctionNameTabEN.ConstName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConstName + "'");
 }
 
 if (objFunctionNameTabEN.PagePath !=  null)
 {
 arrFieldListForInsert.Add(conFunctionNameTab.PagePath);
 var strPagePath = objFunctionNameTabEN.PagePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPagePath + "'");
 }
 
 if (objFunctionNameTabEN.PageName !=  null)
 {
 arrFieldListForInsert.Add(conFunctionNameTab.PageName);
 var strPageName = objFunctionNameTabEN.PageName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPageName + "'");
 }
 
 if (objFunctionNameTabEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conFunctionNameTab.OrderNum);
 arrValueListForInsert.Add(objFunctionNameTabEN.OrderNum.ToString());
 }
 
 if (objFunctionNameTabEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conFunctionNameTab.UpdDate);
 var strUpdDate = objFunctionNameTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objFunctionNameTabEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conFunctionNameTab.UpdUser);
 var strUpdUser = objFunctionNameTabEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objFunctionNameTabEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFunctionNameTab.Memo);
 var strMemo = objFunctionNameTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FunctionNameTab");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionNameTabDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objFunctionNameTabEN.FunctionId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objFunctionNameTabEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsFunctionNameTabEN objFunctionNameTabEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objFunctionNameTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFunctionNameTabEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFunctionNameTabEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objFunctionNameTabEN.FunctionId !=  null)
 {
 arrFieldListForInsert.Add(conFunctionNameTab.FunctionId);
 var strFunctionId = objFunctionNameTabEN.FunctionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionId + "'");
 }
 
 if (objFunctionNameTabEN.FunctionName !=  null)
 {
 arrFieldListForInsert.Add(conFunctionNameTab.FunctionName);
 var strFunctionName = objFunctionNameTabEN.FunctionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionName + "'");
 }
 
 if (objFunctionNameTabEN.FunctionNameCH !=  null)
 {
 arrFieldListForInsert.Add(conFunctionNameTab.FunctionNameCH);
 var strFunctionNameCH = objFunctionNameTabEN.FunctionNameCH.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionNameCH + "'");
 }
 
 if (objFunctionNameTabEN.ModuleName !=  null)
 {
 arrFieldListForInsert.Add(conFunctionNameTab.ModuleName);
 var strModuleName = objFunctionNameTabEN.ModuleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModuleName + "'");
 }
 
 arrFieldListForInsert.Add(conFunctionNameTab.IsStudent);
 arrValueListForInsert.Add("'" + (objFunctionNameTabEN.IsStudent  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conFunctionNameTab.IsTeacher);
 arrValueListForInsert.Add("'" + (objFunctionNameTabEN.IsTeacher  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conFunctionNameTab.IsQuestion);
 arrValueListForInsert.Add("'" + (objFunctionNameTabEN.IsQuestion  ==  false ? "0" : "1") + "'");
 
 if (objFunctionNameTabEN.ConstName !=  null)
 {
 arrFieldListForInsert.Add(conFunctionNameTab.ConstName);
 var strConstName = objFunctionNameTabEN.ConstName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConstName + "'");
 }
 
 if (objFunctionNameTabEN.PagePath !=  null)
 {
 arrFieldListForInsert.Add(conFunctionNameTab.PagePath);
 var strPagePath = objFunctionNameTabEN.PagePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPagePath + "'");
 }
 
 if (objFunctionNameTabEN.PageName !=  null)
 {
 arrFieldListForInsert.Add(conFunctionNameTab.PageName);
 var strPageName = objFunctionNameTabEN.PageName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPageName + "'");
 }
 
 if (objFunctionNameTabEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conFunctionNameTab.OrderNum);
 arrValueListForInsert.Add(objFunctionNameTabEN.OrderNum.ToString());
 }
 
 if (objFunctionNameTabEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conFunctionNameTab.UpdDate);
 var strUpdDate = objFunctionNameTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objFunctionNameTabEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conFunctionNameTab.UpdUser);
 var strUpdUser = objFunctionNameTabEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objFunctionNameTabEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFunctionNameTab.Memo);
 var strMemo = objFunctionNameTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FunctionNameTab");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionNameTabDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objFunctionNameTabEN.FunctionId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objFunctionNameTabEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsFunctionNameTabEN objFunctionNameTabEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objFunctionNameTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFunctionNameTabEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFunctionNameTabEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objFunctionNameTabEN.FunctionId !=  null)
 {
 arrFieldListForInsert.Add(conFunctionNameTab.FunctionId);
 var strFunctionId = objFunctionNameTabEN.FunctionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionId + "'");
 }
 
 if (objFunctionNameTabEN.FunctionName !=  null)
 {
 arrFieldListForInsert.Add(conFunctionNameTab.FunctionName);
 var strFunctionName = objFunctionNameTabEN.FunctionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionName + "'");
 }
 
 if (objFunctionNameTabEN.FunctionNameCH !=  null)
 {
 arrFieldListForInsert.Add(conFunctionNameTab.FunctionNameCH);
 var strFunctionNameCH = objFunctionNameTabEN.FunctionNameCH.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionNameCH + "'");
 }
 
 if (objFunctionNameTabEN.ModuleName !=  null)
 {
 arrFieldListForInsert.Add(conFunctionNameTab.ModuleName);
 var strModuleName = objFunctionNameTabEN.ModuleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModuleName + "'");
 }
 
 arrFieldListForInsert.Add(conFunctionNameTab.IsStudent);
 arrValueListForInsert.Add("'" + (objFunctionNameTabEN.IsStudent  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conFunctionNameTab.IsTeacher);
 arrValueListForInsert.Add("'" + (objFunctionNameTabEN.IsTeacher  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conFunctionNameTab.IsQuestion);
 arrValueListForInsert.Add("'" + (objFunctionNameTabEN.IsQuestion  ==  false ? "0" : "1") + "'");
 
 if (objFunctionNameTabEN.ConstName !=  null)
 {
 arrFieldListForInsert.Add(conFunctionNameTab.ConstName);
 var strConstName = objFunctionNameTabEN.ConstName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConstName + "'");
 }
 
 if (objFunctionNameTabEN.PagePath !=  null)
 {
 arrFieldListForInsert.Add(conFunctionNameTab.PagePath);
 var strPagePath = objFunctionNameTabEN.PagePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPagePath + "'");
 }
 
 if (objFunctionNameTabEN.PageName !=  null)
 {
 arrFieldListForInsert.Add(conFunctionNameTab.PageName);
 var strPageName = objFunctionNameTabEN.PageName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPageName + "'");
 }
 
 if (objFunctionNameTabEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conFunctionNameTab.OrderNum);
 arrValueListForInsert.Add(objFunctionNameTabEN.OrderNum.ToString());
 }
 
 if (objFunctionNameTabEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conFunctionNameTab.UpdDate);
 var strUpdDate = objFunctionNameTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objFunctionNameTabEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conFunctionNameTab.UpdUser);
 var strUpdUser = objFunctionNameTabEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objFunctionNameTabEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFunctionNameTab.Memo);
 var strMemo = objFunctionNameTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FunctionNameTab");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionNameTabDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewFunctionNameTabs(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionNameTabDA.GetSpecSQLObj();
strSQL = "Select * from FunctionNameTab where FunctionId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "FunctionNameTab");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strFunctionId = oRow[conFunctionNameTab.FunctionId].ToString().Trim();
if (IsExist(strFunctionId))
{
 string strResult = "关键字变量值为:" + string.Format("FunctionId = {0}", strFunctionId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsFunctionNameTabEN._CurrTabName ].NewRow();
objRow[conFunctionNameTab.FunctionId] = oRow[conFunctionNameTab.FunctionId].ToString().Trim(); //功能Id
objRow[conFunctionNameTab.FunctionName] = oRow[conFunctionNameTab.FunctionName].ToString().Trim(); //函数名
objRow[conFunctionNameTab.FunctionNameCH] = oRow[conFunctionNameTab.FunctionNameCH].ToString().Trim(); //功能中文名
objRow[conFunctionNameTab.ModuleName] = oRow[conFunctionNameTab.ModuleName].ToString().Trim(); //模块名
objRow[conFunctionNameTab.IsStudent] = oRow[conFunctionNameTab.IsStudent].ToString().Trim(); //是否学生
objRow[conFunctionNameTab.IsTeacher] = oRow[conFunctionNameTab.IsTeacher].ToString().Trim(); //是否教师
objRow[conFunctionNameTab.IsQuestion] = oRow[conFunctionNameTab.IsQuestion].ToString().Trim(); //是否题目
objRow[conFunctionNameTab.ConstName] = oRow[conFunctionNameTab.ConstName].ToString().Trim(); //常量名
objRow[conFunctionNameTab.PagePath] = oRow[conFunctionNameTab.PagePath].ToString().Trim(); //页面路径
objRow[conFunctionNameTab.PageName] = oRow[conFunctionNameTab.PageName].ToString().Trim(); //页面名称
objRow[conFunctionNameTab.OrderNum] = oRow[conFunctionNameTab.OrderNum].ToString().Trim(); //序号
objRow[conFunctionNameTab.UpdDate] = oRow[conFunctionNameTab.UpdDate].ToString().Trim(); //修改日期
objRow[conFunctionNameTab.UpdUser] = oRow[conFunctionNameTab.UpdUser].ToString().Trim(); //修改人
objRow[conFunctionNameTab.Memo] = oRow[conFunctionNameTab.Memo].ToString().Trim(); //备注
 objDS.Tables[clsFunctionNameTabEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsFunctionNameTabEN._CurrTabName);
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
 /// <param name = "objFunctionNameTabEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsFunctionNameTabEN objFunctionNameTabEN)
{
 objFunctionNameTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFunctionNameTabEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFunctionNameTabEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionNameTabDA.GetSpecSQLObj();
strSQL = "Select * from FunctionNameTab where FunctionId = " + "'"+ objFunctionNameTabEN.FunctionId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsFunctionNameTabEN._CurrTabName);
if (objDS.Tables[clsFunctionNameTabEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:FunctionId = " + "'"+ objFunctionNameTabEN.FunctionId+"'");
return false;
}
objRow = objDS.Tables[clsFunctionNameTabEN._CurrTabName].Rows[0];
 if (objFunctionNameTabEN.IsUpdated(conFunctionNameTab.FunctionId))
 {
objRow[conFunctionNameTab.FunctionId] = objFunctionNameTabEN.FunctionId; //功能Id
 }
 if (objFunctionNameTabEN.IsUpdated(conFunctionNameTab.FunctionName))
 {
objRow[conFunctionNameTab.FunctionName] = objFunctionNameTabEN.FunctionName; //函数名
 }
 if (objFunctionNameTabEN.IsUpdated(conFunctionNameTab.FunctionNameCH))
 {
objRow[conFunctionNameTab.FunctionNameCH] = objFunctionNameTabEN.FunctionNameCH; //功能中文名
 }
 if (objFunctionNameTabEN.IsUpdated(conFunctionNameTab.ModuleName))
 {
objRow[conFunctionNameTab.ModuleName] = objFunctionNameTabEN.ModuleName; //模块名
 }
 if (objFunctionNameTabEN.IsUpdated(conFunctionNameTab.IsStudent))
 {
objRow[conFunctionNameTab.IsStudent] = objFunctionNameTabEN.IsStudent; //是否学生
 }
 if (objFunctionNameTabEN.IsUpdated(conFunctionNameTab.IsTeacher))
 {
objRow[conFunctionNameTab.IsTeacher] = objFunctionNameTabEN.IsTeacher; //是否教师
 }
 if (objFunctionNameTabEN.IsUpdated(conFunctionNameTab.IsQuestion))
 {
objRow[conFunctionNameTab.IsQuestion] = objFunctionNameTabEN.IsQuestion; //是否题目
 }
 if (objFunctionNameTabEN.IsUpdated(conFunctionNameTab.ConstName))
 {
objRow[conFunctionNameTab.ConstName] = objFunctionNameTabEN.ConstName; //常量名
 }
 if (objFunctionNameTabEN.IsUpdated(conFunctionNameTab.PagePath))
 {
objRow[conFunctionNameTab.PagePath] = objFunctionNameTabEN.PagePath; //页面路径
 }
 if (objFunctionNameTabEN.IsUpdated(conFunctionNameTab.PageName))
 {
objRow[conFunctionNameTab.PageName] = objFunctionNameTabEN.PageName; //页面名称
 }
 if (objFunctionNameTabEN.IsUpdated(conFunctionNameTab.OrderNum))
 {
objRow[conFunctionNameTab.OrderNum] = objFunctionNameTabEN.OrderNum; //序号
 }
 if (objFunctionNameTabEN.IsUpdated(conFunctionNameTab.UpdDate))
 {
objRow[conFunctionNameTab.UpdDate] = objFunctionNameTabEN.UpdDate; //修改日期
 }
 if (objFunctionNameTabEN.IsUpdated(conFunctionNameTab.UpdUser))
 {
objRow[conFunctionNameTab.UpdUser] = objFunctionNameTabEN.UpdUser; //修改人
 }
 if (objFunctionNameTabEN.IsUpdated(conFunctionNameTab.Memo))
 {
objRow[conFunctionNameTab.Memo] = objFunctionNameTabEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsFunctionNameTabEN._CurrTabName);
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
 /// <param name = "objFunctionNameTabEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsFunctionNameTabEN objFunctionNameTabEN)
{
 objFunctionNameTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFunctionNameTabEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFunctionNameTabEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionNameTabDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update FunctionNameTab Set ");
 
 if (objFunctionNameTabEN.IsUpdated(conFunctionNameTab.FunctionName))
 {
 if (objFunctionNameTabEN.FunctionName !=  null)
 {
 var strFunctionName = objFunctionNameTabEN.FunctionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFunctionName, conFunctionNameTab.FunctionName); //函数名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunctionNameTab.FunctionName); //函数名
 }
 }
 
 if (objFunctionNameTabEN.IsUpdated(conFunctionNameTab.FunctionNameCH))
 {
 if (objFunctionNameTabEN.FunctionNameCH !=  null)
 {
 var strFunctionNameCH = objFunctionNameTabEN.FunctionNameCH.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFunctionNameCH, conFunctionNameTab.FunctionNameCH); //功能中文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunctionNameTab.FunctionNameCH); //功能中文名
 }
 }
 
 if (objFunctionNameTabEN.IsUpdated(conFunctionNameTab.ModuleName))
 {
 if (objFunctionNameTabEN.ModuleName !=  null)
 {
 var strModuleName = objFunctionNameTabEN.ModuleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strModuleName, conFunctionNameTab.ModuleName); //模块名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunctionNameTab.ModuleName); //模块名
 }
 }
 
 if (objFunctionNameTabEN.IsUpdated(conFunctionNameTab.IsStudent))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objFunctionNameTabEN.IsStudent == true?"1":"0", conFunctionNameTab.IsStudent); //是否学生
 }
 
 if (objFunctionNameTabEN.IsUpdated(conFunctionNameTab.IsTeacher))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objFunctionNameTabEN.IsTeacher == true?"1":"0", conFunctionNameTab.IsTeacher); //是否教师
 }
 
 if (objFunctionNameTabEN.IsUpdated(conFunctionNameTab.IsQuestion))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objFunctionNameTabEN.IsQuestion == true?"1":"0", conFunctionNameTab.IsQuestion); //是否题目
 }
 
 if (objFunctionNameTabEN.IsUpdated(conFunctionNameTab.ConstName))
 {
 if (objFunctionNameTabEN.ConstName !=  null)
 {
 var strConstName = objFunctionNameTabEN.ConstName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strConstName, conFunctionNameTab.ConstName); //常量名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunctionNameTab.ConstName); //常量名
 }
 }
 
 if (objFunctionNameTabEN.IsUpdated(conFunctionNameTab.PagePath))
 {
 if (objFunctionNameTabEN.PagePath !=  null)
 {
 var strPagePath = objFunctionNameTabEN.PagePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPagePath, conFunctionNameTab.PagePath); //页面路径
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunctionNameTab.PagePath); //页面路径
 }
 }
 
 if (objFunctionNameTabEN.IsUpdated(conFunctionNameTab.PageName))
 {
 if (objFunctionNameTabEN.PageName !=  null)
 {
 var strPageName = objFunctionNameTabEN.PageName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPageName, conFunctionNameTab.PageName); //页面名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunctionNameTab.PageName); //页面名称
 }
 }
 
 if (objFunctionNameTabEN.IsUpdated(conFunctionNameTab.OrderNum))
 {
 if (objFunctionNameTabEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFunctionNameTabEN.OrderNum, conFunctionNameTab.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunctionNameTab.OrderNum); //序号
 }
 }
 
 if (objFunctionNameTabEN.IsUpdated(conFunctionNameTab.UpdDate))
 {
 if (objFunctionNameTabEN.UpdDate !=  null)
 {
 var strUpdDate = objFunctionNameTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conFunctionNameTab.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunctionNameTab.UpdDate); //修改日期
 }
 }
 
 if (objFunctionNameTabEN.IsUpdated(conFunctionNameTab.UpdUser))
 {
 if (objFunctionNameTabEN.UpdUser !=  null)
 {
 var strUpdUser = objFunctionNameTabEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conFunctionNameTab.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunctionNameTab.UpdUser); //修改人
 }
 }
 
 if (objFunctionNameTabEN.IsUpdated(conFunctionNameTab.Memo))
 {
 if (objFunctionNameTabEN.Memo !=  null)
 {
 var strMemo = objFunctionNameTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conFunctionNameTab.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunctionNameTab.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where FunctionId = '{0}'", objFunctionNameTabEN.FunctionId); 
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
 /// <param name = "objFunctionNameTabEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsFunctionNameTabEN objFunctionNameTabEN, string strCondition)
{
 objFunctionNameTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFunctionNameTabEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFunctionNameTabEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionNameTabDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update FunctionNameTab Set ");
 
 if (objFunctionNameTabEN.IsUpdated(conFunctionNameTab.FunctionName))
 {
 if (objFunctionNameTabEN.FunctionName !=  null)
 {
 var strFunctionName = objFunctionNameTabEN.FunctionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FunctionName = '{0}',", strFunctionName); //函数名
 }
 else
 {
 sbSQL.Append(" FunctionName = null,"); //函数名
 }
 }
 
 if (objFunctionNameTabEN.IsUpdated(conFunctionNameTab.FunctionNameCH))
 {
 if (objFunctionNameTabEN.FunctionNameCH !=  null)
 {
 var strFunctionNameCH = objFunctionNameTabEN.FunctionNameCH.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FunctionNameCH = '{0}',", strFunctionNameCH); //功能中文名
 }
 else
 {
 sbSQL.Append(" FunctionNameCH = null,"); //功能中文名
 }
 }
 
 if (objFunctionNameTabEN.IsUpdated(conFunctionNameTab.ModuleName))
 {
 if (objFunctionNameTabEN.ModuleName !=  null)
 {
 var strModuleName = objFunctionNameTabEN.ModuleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ModuleName = '{0}',", strModuleName); //模块名
 }
 else
 {
 sbSQL.Append(" ModuleName = null,"); //模块名
 }
 }
 
 if (objFunctionNameTabEN.IsUpdated(conFunctionNameTab.IsStudent))
 {
 sbSQL.AppendFormat(" IsStudent = '{0}',", objFunctionNameTabEN.IsStudent == true?"1":"0"); //是否学生
 }
 
 if (objFunctionNameTabEN.IsUpdated(conFunctionNameTab.IsTeacher))
 {
 sbSQL.AppendFormat(" IsTeacher = '{0}',", objFunctionNameTabEN.IsTeacher == true?"1":"0"); //是否教师
 }
 
 if (objFunctionNameTabEN.IsUpdated(conFunctionNameTab.IsQuestion))
 {
 sbSQL.AppendFormat(" IsQuestion = '{0}',", objFunctionNameTabEN.IsQuestion == true?"1":"0"); //是否题目
 }
 
 if (objFunctionNameTabEN.IsUpdated(conFunctionNameTab.ConstName))
 {
 if (objFunctionNameTabEN.ConstName !=  null)
 {
 var strConstName = objFunctionNameTabEN.ConstName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ConstName = '{0}',", strConstName); //常量名
 }
 else
 {
 sbSQL.Append(" ConstName = null,"); //常量名
 }
 }
 
 if (objFunctionNameTabEN.IsUpdated(conFunctionNameTab.PagePath))
 {
 if (objFunctionNameTabEN.PagePath !=  null)
 {
 var strPagePath = objFunctionNameTabEN.PagePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PagePath = '{0}',", strPagePath); //页面路径
 }
 else
 {
 sbSQL.Append(" PagePath = null,"); //页面路径
 }
 }
 
 if (objFunctionNameTabEN.IsUpdated(conFunctionNameTab.PageName))
 {
 if (objFunctionNameTabEN.PageName !=  null)
 {
 var strPageName = objFunctionNameTabEN.PageName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PageName = '{0}',", strPageName); //页面名称
 }
 else
 {
 sbSQL.Append(" PageName = null,"); //页面名称
 }
 }
 
 if (objFunctionNameTabEN.IsUpdated(conFunctionNameTab.OrderNum))
 {
 if (objFunctionNameTabEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFunctionNameTabEN.OrderNum, conFunctionNameTab.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunctionNameTab.OrderNum); //序号
 }
 }
 
 if (objFunctionNameTabEN.IsUpdated(conFunctionNameTab.UpdDate))
 {
 if (objFunctionNameTabEN.UpdDate !=  null)
 {
 var strUpdDate = objFunctionNameTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objFunctionNameTabEN.IsUpdated(conFunctionNameTab.UpdUser))
 {
 if (objFunctionNameTabEN.UpdUser !=  null)
 {
 var strUpdUser = objFunctionNameTabEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objFunctionNameTabEN.IsUpdated(conFunctionNameTab.Memo))
 {
 if (objFunctionNameTabEN.Memo !=  null)
 {
 var strMemo = objFunctionNameTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objFunctionNameTabEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsFunctionNameTabEN objFunctionNameTabEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objFunctionNameTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFunctionNameTabEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFunctionNameTabEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionNameTabDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update FunctionNameTab Set ");
 
 if (objFunctionNameTabEN.IsUpdated(conFunctionNameTab.FunctionName))
 {
 if (objFunctionNameTabEN.FunctionName !=  null)
 {
 var strFunctionName = objFunctionNameTabEN.FunctionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FunctionName = '{0}',", strFunctionName); //函数名
 }
 else
 {
 sbSQL.Append(" FunctionName = null,"); //函数名
 }
 }
 
 if (objFunctionNameTabEN.IsUpdated(conFunctionNameTab.FunctionNameCH))
 {
 if (objFunctionNameTabEN.FunctionNameCH !=  null)
 {
 var strFunctionNameCH = objFunctionNameTabEN.FunctionNameCH.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FunctionNameCH = '{0}',", strFunctionNameCH); //功能中文名
 }
 else
 {
 sbSQL.Append(" FunctionNameCH = null,"); //功能中文名
 }
 }
 
 if (objFunctionNameTabEN.IsUpdated(conFunctionNameTab.ModuleName))
 {
 if (objFunctionNameTabEN.ModuleName !=  null)
 {
 var strModuleName = objFunctionNameTabEN.ModuleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ModuleName = '{0}',", strModuleName); //模块名
 }
 else
 {
 sbSQL.Append(" ModuleName = null,"); //模块名
 }
 }
 
 if (objFunctionNameTabEN.IsUpdated(conFunctionNameTab.IsStudent))
 {
 sbSQL.AppendFormat(" IsStudent = '{0}',", objFunctionNameTabEN.IsStudent == true?"1":"0"); //是否学生
 }
 
 if (objFunctionNameTabEN.IsUpdated(conFunctionNameTab.IsTeacher))
 {
 sbSQL.AppendFormat(" IsTeacher = '{0}',", objFunctionNameTabEN.IsTeacher == true?"1":"0"); //是否教师
 }
 
 if (objFunctionNameTabEN.IsUpdated(conFunctionNameTab.IsQuestion))
 {
 sbSQL.AppendFormat(" IsQuestion = '{0}',", objFunctionNameTabEN.IsQuestion == true?"1":"0"); //是否题目
 }
 
 if (objFunctionNameTabEN.IsUpdated(conFunctionNameTab.ConstName))
 {
 if (objFunctionNameTabEN.ConstName !=  null)
 {
 var strConstName = objFunctionNameTabEN.ConstName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ConstName = '{0}',", strConstName); //常量名
 }
 else
 {
 sbSQL.Append(" ConstName = null,"); //常量名
 }
 }
 
 if (objFunctionNameTabEN.IsUpdated(conFunctionNameTab.PagePath))
 {
 if (objFunctionNameTabEN.PagePath !=  null)
 {
 var strPagePath = objFunctionNameTabEN.PagePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PagePath = '{0}',", strPagePath); //页面路径
 }
 else
 {
 sbSQL.Append(" PagePath = null,"); //页面路径
 }
 }
 
 if (objFunctionNameTabEN.IsUpdated(conFunctionNameTab.PageName))
 {
 if (objFunctionNameTabEN.PageName !=  null)
 {
 var strPageName = objFunctionNameTabEN.PageName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PageName = '{0}',", strPageName); //页面名称
 }
 else
 {
 sbSQL.Append(" PageName = null,"); //页面名称
 }
 }
 
 if (objFunctionNameTabEN.IsUpdated(conFunctionNameTab.OrderNum))
 {
 if (objFunctionNameTabEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFunctionNameTabEN.OrderNum, conFunctionNameTab.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunctionNameTab.OrderNum); //序号
 }
 }
 
 if (objFunctionNameTabEN.IsUpdated(conFunctionNameTab.UpdDate))
 {
 if (objFunctionNameTabEN.UpdDate !=  null)
 {
 var strUpdDate = objFunctionNameTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objFunctionNameTabEN.IsUpdated(conFunctionNameTab.UpdUser))
 {
 if (objFunctionNameTabEN.UpdUser !=  null)
 {
 var strUpdUser = objFunctionNameTabEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objFunctionNameTabEN.IsUpdated(conFunctionNameTab.Memo))
 {
 if (objFunctionNameTabEN.Memo !=  null)
 {
 var strMemo = objFunctionNameTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objFunctionNameTabEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsFunctionNameTabEN objFunctionNameTabEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objFunctionNameTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFunctionNameTabEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFunctionNameTabEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionNameTabDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update FunctionNameTab Set ");
 
 if (objFunctionNameTabEN.IsUpdated(conFunctionNameTab.FunctionName))
 {
 if (objFunctionNameTabEN.FunctionName !=  null)
 {
 var strFunctionName = objFunctionNameTabEN.FunctionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFunctionName, conFunctionNameTab.FunctionName); //函数名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunctionNameTab.FunctionName); //函数名
 }
 }
 
 if (objFunctionNameTabEN.IsUpdated(conFunctionNameTab.FunctionNameCH))
 {
 if (objFunctionNameTabEN.FunctionNameCH !=  null)
 {
 var strFunctionNameCH = objFunctionNameTabEN.FunctionNameCH.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFunctionNameCH, conFunctionNameTab.FunctionNameCH); //功能中文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunctionNameTab.FunctionNameCH); //功能中文名
 }
 }
 
 if (objFunctionNameTabEN.IsUpdated(conFunctionNameTab.ModuleName))
 {
 if (objFunctionNameTabEN.ModuleName !=  null)
 {
 var strModuleName = objFunctionNameTabEN.ModuleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strModuleName, conFunctionNameTab.ModuleName); //模块名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunctionNameTab.ModuleName); //模块名
 }
 }
 
 if (objFunctionNameTabEN.IsUpdated(conFunctionNameTab.IsStudent))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objFunctionNameTabEN.IsStudent == true?"1":"0", conFunctionNameTab.IsStudent); //是否学生
 }
 
 if (objFunctionNameTabEN.IsUpdated(conFunctionNameTab.IsTeacher))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objFunctionNameTabEN.IsTeacher == true?"1":"0", conFunctionNameTab.IsTeacher); //是否教师
 }
 
 if (objFunctionNameTabEN.IsUpdated(conFunctionNameTab.IsQuestion))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objFunctionNameTabEN.IsQuestion == true?"1":"0", conFunctionNameTab.IsQuestion); //是否题目
 }
 
 if (objFunctionNameTabEN.IsUpdated(conFunctionNameTab.ConstName))
 {
 if (objFunctionNameTabEN.ConstName !=  null)
 {
 var strConstName = objFunctionNameTabEN.ConstName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strConstName, conFunctionNameTab.ConstName); //常量名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunctionNameTab.ConstName); //常量名
 }
 }
 
 if (objFunctionNameTabEN.IsUpdated(conFunctionNameTab.PagePath))
 {
 if (objFunctionNameTabEN.PagePath !=  null)
 {
 var strPagePath = objFunctionNameTabEN.PagePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPagePath, conFunctionNameTab.PagePath); //页面路径
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunctionNameTab.PagePath); //页面路径
 }
 }
 
 if (objFunctionNameTabEN.IsUpdated(conFunctionNameTab.PageName))
 {
 if (objFunctionNameTabEN.PageName !=  null)
 {
 var strPageName = objFunctionNameTabEN.PageName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPageName, conFunctionNameTab.PageName); //页面名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunctionNameTab.PageName); //页面名称
 }
 }
 
 if (objFunctionNameTabEN.IsUpdated(conFunctionNameTab.OrderNum))
 {
 if (objFunctionNameTabEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFunctionNameTabEN.OrderNum, conFunctionNameTab.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunctionNameTab.OrderNum); //序号
 }
 }
 
 if (objFunctionNameTabEN.IsUpdated(conFunctionNameTab.UpdDate))
 {
 if (objFunctionNameTabEN.UpdDate !=  null)
 {
 var strUpdDate = objFunctionNameTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conFunctionNameTab.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunctionNameTab.UpdDate); //修改日期
 }
 }
 
 if (objFunctionNameTabEN.IsUpdated(conFunctionNameTab.UpdUser))
 {
 if (objFunctionNameTabEN.UpdUser !=  null)
 {
 var strUpdUser = objFunctionNameTabEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conFunctionNameTab.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunctionNameTab.UpdUser); //修改人
 }
 }
 
 if (objFunctionNameTabEN.IsUpdated(conFunctionNameTab.Memo))
 {
 if (objFunctionNameTabEN.Memo !=  null)
 {
 var strMemo = objFunctionNameTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conFunctionNameTab.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunctionNameTab.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where FunctionId = '{0}'", objFunctionNameTabEN.FunctionId); 
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
 /// <param name = "strFunctionId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strFunctionId) 
{
CheckPrimaryKey(strFunctionId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionNameTabDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strFunctionId,
};
 objSQL.ExecSP("FunctionNameTab_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strFunctionId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strFunctionId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strFunctionId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionNameTabDA.GetSpecSQLObj();
//删除FunctionNameTab本表中与当前对象有关的记录
strSQL = strSQL + "Delete from FunctionNameTab where FunctionId = " + "'"+ strFunctionId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelFunctionNameTab(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionNameTabDA.GetSpecSQLObj();
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
//删除FunctionNameTab本表中与当前对象有关的记录
strSQL = strSQL + "Delete from FunctionNameTab where FunctionId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strFunctionId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strFunctionId) 
{
CheckPrimaryKey(strFunctionId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionNameTabDA.GetSpecSQLObj();
//删除FunctionNameTab本表中与当前对象有关的记录
strSQL = strSQL + "Delete from FunctionNameTab where FunctionId = " + "'"+ strFunctionId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelFunctionNameTab(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsFunctionNameTabDA: DelFunctionNameTab)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionNameTabDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from FunctionNameTab where " + strCondition ;
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
public bool DelFunctionNameTabWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsFunctionNameTabDA: DelFunctionNameTabWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionNameTabDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from FunctionNameTab where " + strCondition ;
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
 /// <param name = "objFunctionNameTabENS">源对象</param>
 /// <param name = "objFunctionNameTabENT">目标对象</param>
public void CopyTo(clsFunctionNameTabEN objFunctionNameTabENS, clsFunctionNameTabEN objFunctionNameTabENT)
{
objFunctionNameTabENT.FunctionId = objFunctionNameTabENS.FunctionId; //功能Id
objFunctionNameTabENT.FunctionName = objFunctionNameTabENS.FunctionName; //函数名
objFunctionNameTabENT.FunctionNameCH = objFunctionNameTabENS.FunctionNameCH; //功能中文名
objFunctionNameTabENT.ModuleName = objFunctionNameTabENS.ModuleName; //模块名
objFunctionNameTabENT.IsStudent = objFunctionNameTabENS.IsStudent; //是否学生
objFunctionNameTabENT.IsTeacher = objFunctionNameTabENS.IsTeacher; //是否教师
objFunctionNameTabENT.IsQuestion = objFunctionNameTabENS.IsQuestion; //是否题目
objFunctionNameTabENT.ConstName = objFunctionNameTabENS.ConstName; //常量名
objFunctionNameTabENT.PagePath = objFunctionNameTabENS.PagePath; //页面路径
objFunctionNameTabENT.PageName = objFunctionNameTabENS.PageName; //页面名称
objFunctionNameTabENT.OrderNum = objFunctionNameTabENS.OrderNum; //序号
objFunctionNameTabENT.UpdDate = objFunctionNameTabENS.UpdDate; //修改日期
objFunctionNameTabENT.UpdUser = objFunctionNameTabENS.UpdUser; //修改人
objFunctionNameTabENT.Memo = objFunctionNameTabENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsFunctionNameTabEN objFunctionNameTabEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objFunctionNameTabEN.FunctionName, conFunctionNameTab.FunctionName);
//检查字段长度
clsCheckSql.CheckFieldLen(objFunctionNameTabEN.FunctionId, 4, conFunctionNameTab.FunctionId);
clsCheckSql.CheckFieldLen(objFunctionNameTabEN.FunctionName, 100, conFunctionNameTab.FunctionName);
clsCheckSql.CheckFieldLen(objFunctionNameTabEN.FunctionNameCH, 255, conFunctionNameTab.FunctionNameCH);
clsCheckSql.CheckFieldLen(objFunctionNameTabEN.ModuleName, 255, conFunctionNameTab.ModuleName);
clsCheckSql.CheckFieldLen(objFunctionNameTabEN.ConstName, 255, conFunctionNameTab.ConstName);
clsCheckSql.CheckFieldLen(objFunctionNameTabEN.PagePath, 50, conFunctionNameTab.PagePath);
clsCheckSql.CheckFieldLen(objFunctionNameTabEN.PageName, 100, conFunctionNameTab.PageName);
clsCheckSql.CheckFieldLen(objFunctionNameTabEN.UpdDate, 20, conFunctionNameTab.UpdDate);
clsCheckSql.CheckFieldLen(objFunctionNameTabEN.UpdUser, 20, conFunctionNameTab.UpdUser);
clsCheckSql.CheckFieldLen(objFunctionNameTabEN.Memo, 1000, conFunctionNameTab.Memo);
//检查字段外键固定长度
 objFunctionNameTabEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsFunctionNameTabEN objFunctionNameTabEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objFunctionNameTabEN.FunctionName, 100, conFunctionNameTab.FunctionName);
clsCheckSql.CheckFieldLen(objFunctionNameTabEN.FunctionNameCH, 255, conFunctionNameTab.FunctionNameCH);
clsCheckSql.CheckFieldLen(objFunctionNameTabEN.ModuleName, 255, conFunctionNameTab.ModuleName);
clsCheckSql.CheckFieldLen(objFunctionNameTabEN.ConstName, 255, conFunctionNameTab.ConstName);
clsCheckSql.CheckFieldLen(objFunctionNameTabEN.PagePath, 50, conFunctionNameTab.PagePath);
clsCheckSql.CheckFieldLen(objFunctionNameTabEN.PageName, 100, conFunctionNameTab.PageName);
clsCheckSql.CheckFieldLen(objFunctionNameTabEN.UpdDate, 20, conFunctionNameTab.UpdDate);
clsCheckSql.CheckFieldLen(objFunctionNameTabEN.UpdUser, 20, conFunctionNameTab.UpdUser);
clsCheckSql.CheckFieldLen(objFunctionNameTabEN.Memo, 1000, conFunctionNameTab.Memo);
//检查外键字段长度
 objFunctionNameTabEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsFunctionNameTabEN objFunctionNameTabEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objFunctionNameTabEN.FunctionId, 4, conFunctionNameTab.FunctionId);
clsCheckSql.CheckFieldLen(objFunctionNameTabEN.FunctionName, 100, conFunctionNameTab.FunctionName);
clsCheckSql.CheckFieldLen(objFunctionNameTabEN.FunctionNameCH, 255, conFunctionNameTab.FunctionNameCH);
clsCheckSql.CheckFieldLen(objFunctionNameTabEN.ModuleName, 255, conFunctionNameTab.ModuleName);
clsCheckSql.CheckFieldLen(objFunctionNameTabEN.ConstName, 255, conFunctionNameTab.ConstName);
clsCheckSql.CheckFieldLen(objFunctionNameTabEN.PagePath, 50, conFunctionNameTab.PagePath);
clsCheckSql.CheckFieldLen(objFunctionNameTabEN.PageName, 100, conFunctionNameTab.PageName);
clsCheckSql.CheckFieldLen(objFunctionNameTabEN.UpdDate, 20, conFunctionNameTab.UpdDate);
clsCheckSql.CheckFieldLen(objFunctionNameTabEN.UpdUser, 20, conFunctionNameTab.UpdUser);
clsCheckSql.CheckFieldLen(objFunctionNameTabEN.Memo, 1000, conFunctionNameTab.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objFunctionNameTabEN.FunctionId, conFunctionNameTab.FunctionId);
clsCheckSql.CheckSqlInjection4Field(objFunctionNameTabEN.FunctionName, conFunctionNameTab.FunctionName);
clsCheckSql.CheckSqlInjection4Field(objFunctionNameTabEN.FunctionNameCH, conFunctionNameTab.FunctionNameCH);
clsCheckSql.CheckSqlInjection4Field(objFunctionNameTabEN.ModuleName, conFunctionNameTab.ModuleName);
clsCheckSql.CheckSqlInjection4Field(objFunctionNameTabEN.ConstName, conFunctionNameTab.ConstName);
clsCheckSql.CheckSqlInjection4Field(objFunctionNameTabEN.PagePath, conFunctionNameTab.PagePath);
clsCheckSql.CheckSqlInjection4Field(objFunctionNameTabEN.PageName, conFunctionNameTab.PageName);
clsCheckSql.CheckSqlInjection4Field(objFunctionNameTabEN.UpdDate, conFunctionNameTab.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objFunctionNameTabEN.UpdUser, conFunctionNameTab.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objFunctionNameTabEN.Memo, conFunctionNameTab.Memo);
//检查外键字段长度
 objFunctionNameTabEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetFunctionId()
{
//获取某学院所有专业信息
string strSQL = "select FunctionId, FunctionName from FunctionNameTab ";
 clsSpecSQLforSql mySql = clsFunctionNameTabDA.GetSpecSQLObj();
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
 objSQL = clsFunctionNameTabDA.GetSpecSQLObj();
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
 objSQL = clsFunctionNameTabDA.GetSpecSQLObj();
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
 objSQL = clsFunctionNameTabDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsFunctionNameTabEN._CurrTabName);
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
 objSQL = clsFunctionNameTabDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsFunctionNameTabEN._CurrTabName, strCondition);
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
 objSQL = clsFunctionNameTabDA.GetSpecSQLObj();
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
 objSQL = clsFunctionNameTabDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}