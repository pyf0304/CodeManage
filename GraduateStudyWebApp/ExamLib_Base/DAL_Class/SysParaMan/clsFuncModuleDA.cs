
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFuncModuleDA
 表名:FuncModule(01120121)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:13:13
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统参数管理(SysParaMan)
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
 /// 功能模块(FuncModule)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsFuncModuleDA : clsCommBase4DA
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
 return clsFuncModuleEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsFuncModuleEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsFuncModuleEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsFuncModuleEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsFuncModuleEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strFuncModuleId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strFuncModuleId)
{
strFuncModuleId = strFuncModuleId.Replace("'", "''");
if (strFuncModuleId.Length > 4)
{
throw new Exception("(errid:Data000001)在表:FuncModule中,检查关键字,长度不正确!(clsFuncModuleDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strFuncModuleId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:FuncModule中,关键字不能为空 或 null!(clsFuncModuleDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strFuncModuleId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsFuncModuleDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsFuncModuleDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncModuleDA.GetSpecSQLObj();
strSQL = "Select * from FuncModule where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_FuncModule(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsFuncModuleDA: GetDataTable_FuncModule)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncModuleDA.GetSpecSQLObj();
strSQL = "Select * from FuncModule where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsFuncModuleDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncModuleDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsFuncModuleDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncModuleDA.GetSpecSQLObj();
strSQL = "Select * from FuncModule where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsFuncModuleDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncModuleDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsFuncModuleDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncModuleDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from FuncModule where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from FuncModule where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsFuncModuleDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncModuleDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from FuncModule where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsFuncModuleDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncModuleDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} FuncModule.* from FuncModule Left Join {1} on {2} where {3} and FuncModule.FuncModuleId not in (Select top {5} FuncModule.FuncModuleId from FuncModule Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from FuncModule where {1} and FuncModuleId not in (Select top {2} FuncModuleId from FuncModule where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from FuncModule where {1} and FuncModuleId not in (Select top {3} FuncModuleId from FuncModule where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsFuncModuleDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncModuleDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} FuncModule.* from FuncModule Left Join {1} on {2} where {3} and FuncModule.FuncModuleId not in (Select top {5} FuncModule.FuncModuleId from FuncModule Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from FuncModule where {1} and FuncModuleId not in (Select top {2} FuncModuleId from FuncModule where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from FuncModule where {1} and FuncModuleId not in (Select top {3} FuncModuleId from FuncModule where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsFuncModuleEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsFuncModuleDA:GetObjLst)", objException.Message));
}
List<clsFuncModuleEN> arrObjLst = new List<clsFuncModuleEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncModuleDA.GetSpecSQLObj();
strSQL = "Select * from FuncModule where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFuncModuleEN objFuncModuleEN = new clsFuncModuleEN();
try
{
objFuncModuleEN.FuncModuleId = objRow[conFuncModule.FuncModuleId].ToString().Trim(); //功能模块Id
objFuncModuleEN.FuncModuleName = objRow[conFuncModule.FuncModuleName].ToString().Trim(); //功能模块名称
objFuncModuleEN.FuncModuleNameSim = objRow[conFuncModule.FuncModuleNameSim] == DBNull.Value ? null : objRow[conFuncModule.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objFuncModuleEN.Memo = objRow[conFuncModule.Memo] == DBNull.Value ? null : objRow[conFuncModule.Memo].ToString().Trim(); //备注
objFuncModuleEN.UpdDate = objRow[conFuncModule.UpdDate] == DBNull.Value ? null : objRow[conFuncModule.UpdDate].ToString().Trim(); //修改日期
objFuncModuleEN.UpdUser = objRow[conFuncModule.UpdUser] == DBNull.Value ? null : objRow[conFuncModule.UpdUser].ToString().Trim(); //修改人
objFuncModuleEN.OrderNum = TransNullToInt(objRow[conFuncModule.OrderNum].ToString().Trim()); //序号
objFuncModuleEN.PrjId = objRow[conFuncModule.PrjId] == DBNull.Value ? null : objRow[conFuncModule.PrjId].ToString().Trim(); //PrjId
objFuncModuleEN.FuncModuleEnName = objRow[conFuncModule.FuncModuleEnName] == DBNull.Value ? null : objRow[conFuncModule.FuncModuleEnName].ToString().Trim(); //FuncModuleEnName
objFuncModuleEN.UseStateId = objRow[conFuncModule.UseStateId].ToString().Trim(); //UseStateId
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsFuncModuleDA: GetObjLst)", objException.Message));
}
objFuncModuleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objFuncModuleEN);
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
public List<clsFuncModuleEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsFuncModuleDA:GetObjLstByTabName)", objException.Message));
}
List<clsFuncModuleEN> arrObjLst = new List<clsFuncModuleEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncModuleDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFuncModuleEN objFuncModuleEN = new clsFuncModuleEN();
try
{
objFuncModuleEN.FuncModuleId = objRow[conFuncModule.FuncModuleId].ToString().Trim(); //功能模块Id
objFuncModuleEN.FuncModuleName = objRow[conFuncModule.FuncModuleName].ToString().Trim(); //功能模块名称
objFuncModuleEN.FuncModuleNameSim = objRow[conFuncModule.FuncModuleNameSim] == DBNull.Value ? null : objRow[conFuncModule.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objFuncModuleEN.Memo = objRow[conFuncModule.Memo] == DBNull.Value ? null : objRow[conFuncModule.Memo].ToString().Trim(); //备注
objFuncModuleEN.UpdDate = objRow[conFuncModule.UpdDate] == DBNull.Value ? null : objRow[conFuncModule.UpdDate].ToString().Trim(); //修改日期
objFuncModuleEN.UpdUser = objRow[conFuncModule.UpdUser] == DBNull.Value ? null : objRow[conFuncModule.UpdUser].ToString().Trim(); //修改人
objFuncModuleEN.OrderNum = TransNullToInt(objRow[conFuncModule.OrderNum].ToString().Trim()); //序号
objFuncModuleEN.PrjId = objRow[conFuncModule.PrjId] == DBNull.Value ? null : objRow[conFuncModule.PrjId].ToString().Trim(); //PrjId
objFuncModuleEN.FuncModuleEnName = objRow[conFuncModule.FuncModuleEnName] == DBNull.Value ? null : objRow[conFuncModule.FuncModuleEnName].ToString().Trim(); //FuncModuleEnName
objFuncModuleEN.UseStateId = objRow[conFuncModule.UseStateId].ToString().Trim(); //UseStateId
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsFuncModuleDA: GetObjLst)", objException.Message));
}
objFuncModuleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objFuncModuleEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objFuncModuleEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetFuncModule(ref clsFuncModuleEN objFuncModuleEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncModuleDA.GetSpecSQLObj();
strSQL = "Select * from FuncModule where FuncModuleId = " + "'"+ objFuncModuleEN.FuncModuleId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objFuncModuleEN.FuncModuleId = objDT.Rows[0][conFuncModule.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objFuncModuleEN.FuncModuleName = objDT.Rows[0][conFuncModule.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objFuncModuleEN.FuncModuleNameSim = objDT.Rows[0][conFuncModule.FuncModuleNameSim].ToString().Trim(); //功能模块简称(字段类型:varchar,字段长度:30,是否可空:True)
 objFuncModuleEN.Memo = objDT.Rows[0][conFuncModule.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objFuncModuleEN.UpdDate = objDT.Rows[0][conFuncModule.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objFuncModuleEN.UpdUser = objDT.Rows[0][conFuncModule.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objFuncModuleEN.OrderNum = TransNullToInt(objDT.Rows[0][conFuncModule.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objFuncModuleEN.PrjId = objDT.Rows[0][conFuncModule.PrjId].ToString().Trim(); //PrjId(字段类型:char,字段长度:4,是否可空:True)
 objFuncModuleEN.FuncModuleEnName = objDT.Rows[0][conFuncModule.FuncModuleEnName].ToString().Trim(); //FuncModuleEnName(字段类型:varchar,字段长度:30,是否可空:True)
 objFuncModuleEN.UseStateId = objDT.Rows[0][conFuncModule.UseStateId].ToString().Trim(); //UseStateId(字段类型:char,字段长度:4,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsFuncModuleDA: GetFuncModule)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strFuncModuleId">表关键字</param>
 /// <returns>表对象</returns>
public clsFuncModuleEN GetObjByFuncModuleId(string strFuncModuleId)
{
CheckPrimaryKey(strFuncModuleId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncModuleDA.GetSpecSQLObj();
strSQL = "Select * from FuncModule where FuncModuleId = " + "'"+ strFuncModuleId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsFuncModuleEN objFuncModuleEN = new clsFuncModuleEN();
try
{
 objFuncModuleEN.FuncModuleId = objRow[conFuncModule.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objFuncModuleEN.FuncModuleName = objRow[conFuncModule.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objFuncModuleEN.FuncModuleNameSim = objRow[conFuncModule.FuncModuleNameSim] == DBNull.Value ? null : objRow[conFuncModule.FuncModuleNameSim].ToString().Trim(); //功能模块简称(字段类型:varchar,字段长度:30,是否可空:True)
 objFuncModuleEN.Memo = objRow[conFuncModule.Memo] == DBNull.Value ? null : objRow[conFuncModule.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objFuncModuleEN.UpdDate = objRow[conFuncModule.UpdDate] == DBNull.Value ? null : objRow[conFuncModule.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objFuncModuleEN.UpdUser = objRow[conFuncModule.UpdUser] == DBNull.Value ? null : objRow[conFuncModule.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objFuncModuleEN.OrderNum = Int32.Parse(objRow[conFuncModule.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objFuncModuleEN.PrjId = objRow[conFuncModule.PrjId] == DBNull.Value ? null : objRow[conFuncModule.PrjId].ToString().Trim(); //PrjId(字段类型:char,字段长度:4,是否可空:True)
 objFuncModuleEN.FuncModuleEnName = objRow[conFuncModule.FuncModuleEnName] == DBNull.Value ? null : objRow[conFuncModule.FuncModuleEnName].ToString().Trim(); //FuncModuleEnName(字段类型:varchar,字段长度:30,是否可空:True)
 objFuncModuleEN.UseStateId = objRow[conFuncModule.UseStateId].ToString().Trim(); //UseStateId(字段类型:char,字段长度:4,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsFuncModuleDA: GetObjByFuncModuleId)", objException.Message));
}
return objFuncModuleEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsFuncModuleEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsFuncModuleDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncModuleDA.GetSpecSQLObj();
strSQL = "Select * from FuncModule where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsFuncModuleEN objFuncModuleEN = new clsFuncModuleEN()
{
FuncModuleId = objRow[conFuncModule.FuncModuleId].ToString().Trim(), //功能模块Id
FuncModuleName = objRow[conFuncModule.FuncModuleName].ToString().Trim(), //功能模块名称
FuncModuleNameSim = objRow[conFuncModule.FuncModuleNameSim] == DBNull.Value ? null : objRow[conFuncModule.FuncModuleNameSim].ToString().Trim(), //功能模块简称
Memo = objRow[conFuncModule.Memo] == DBNull.Value ? null : objRow[conFuncModule.Memo].ToString().Trim(), //备注
UpdDate = objRow[conFuncModule.UpdDate] == DBNull.Value ? null : objRow[conFuncModule.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conFuncModule.UpdUser] == DBNull.Value ? null : objRow[conFuncModule.UpdUser].ToString().Trim(), //修改人
OrderNum = TransNullToInt(objRow[conFuncModule.OrderNum].ToString().Trim()), //序号
PrjId = objRow[conFuncModule.PrjId] == DBNull.Value ? null : objRow[conFuncModule.PrjId].ToString().Trim(), //PrjId
FuncModuleEnName = objRow[conFuncModule.FuncModuleEnName] == DBNull.Value ? null : objRow[conFuncModule.FuncModuleEnName].ToString().Trim(), //FuncModuleEnName
UseStateId = objRow[conFuncModule.UseStateId].ToString().Trim() //UseStateId
};
objFuncModuleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFuncModuleEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsFuncModuleDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsFuncModuleEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsFuncModuleEN objFuncModuleEN = new clsFuncModuleEN();
try
{
objFuncModuleEN.FuncModuleId = objRow[conFuncModule.FuncModuleId].ToString().Trim(); //功能模块Id
objFuncModuleEN.FuncModuleName = objRow[conFuncModule.FuncModuleName].ToString().Trim(); //功能模块名称
objFuncModuleEN.FuncModuleNameSim = objRow[conFuncModule.FuncModuleNameSim] == DBNull.Value ? null : objRow[conFuncModule.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objFuncModuleEN.Memo = objRow[conFuncModule.Memo] == DBNull.Value ? null : objRow[conFuncModule.Memo].ToString().Trim(); //备注
objFuncModuleEN.UpdDate = objRow[conFuncModule.UpdDate] == DBNull.Value ? null : objRow[conFuncModule.UpdDate].ToString().Trim(); //修改日期
objFuncModuleEN.UpdUser = objRow[conFuncModule.UpdUser] == DBNull.Value ? null : objRow[conFuncModule.UpdUser].ToString().Trim(); //修改人
objFuncModuleEN.OrderNum = TransNullToInt(objRow[conFuncModule.OrderNum].ToString().Trim()); //序号
objFuncModuleEN.PrjId = objRow[conFuncModule.PrjId] == DBNull.Value ? null : objRow[conFuncModule.PrjId].ToString().Trim(); //PrjId
objFuncModuleEN.FuncModuleEnName = objRow[conFuncModule.FuncModuleEnName] == DBNull.Value ? null : objRow[conFuncModule.FuncModuleEnName].ToString().Trim(); //FuncModuleEnName
objFuncModuleEN.UseStateId = objRow[conFuncModule.UseStateId].ToString().Trim(); //UseStateId
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsFuncModuleDA: GetObjByDataRowFuncModule)", objException.Message));
}
objFuncModuleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFuncModuleEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsFuncModuleEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsFuncModuleEN objFuncModuleEN = new clsFuncModuleEN();
try
{
objFuncModuleEN.FuncModuleId = objRow[conFuncModule.FuncModuleId].ToString().Trim(); //功能模块Id
objFuncModuleEN.FuncModuleName = objRow[conFuncModule.FuncModuleName].ToString().Trim(); //功能模块名称
objFuncModuleEN.FuncModuleNameSim = objRow[conFuncModule.FuncModuleNameSim] == DBNull.Value ? null : objRow[conFuncModule.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objFuncModuleEN.Memo = objRow[conFuncModule.Memo] == DBNull.Value ? null : objRow[conFuncModule.Memo].ToString().Trim(); //备注
objFuncModuleEN.UpdDate = objRow[conFuncModule.UpdDate] == DBNull.Value ? null : objRow[conFuncModule.UpdDate].ToString().Trim(); //修改日期
objFuncModuleEN.UpdUser = objRow[conFuncModule.UpdUser] == DBNull.Value ? null : objRow[conFuncModule.UpdUser].ToString().Trim(); //修改人
objFuncModuleEN.OrderNum = TransNullToInt(objRow[conFuncModule.OrderNum].ToString().Trim()); //序号
objFuncModuleEN.PrjId = objRow[conFuncModule.PrjId] == DBNull.Value ? null : objRow[conFuncModule.PrjId].ToString().Trim(); //PrjId
objFuncModuleEN.FuncModuleEnName = objRow[conFuncModule.FuncModuleEnName] == DBNull.Value ? null : objRow[conFuncModule.FuncModuleEnName].ToString().Trim(); //FuncModuleEnName
objFuncModuleEN.UseStateId = objRow[conFuncModule.UseStateId].ToString().Trim(); //UseStateId
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsFuncModuleDA: GetObjByDataRow)", objException.Message));
}
objFuncModuleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFuncModuleEN;
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
objSQL = clsFuncModuleDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsFuncModuleEN._CurrTabName, conFuncModule.FuncModuleId, 4, "");
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
objSQL = clsFuncModuleDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsFuncModuleEN._CurrTabName, conFuncModule.FuncModuleId, 4, strPrefix);
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
 objSQL = clsFuncModuleDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select FuncModuleId from FuncModule where " + strCondition;
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
 objSQL = clsFuncModuleDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select FuncModuleId from FuncModule where " + strCondition;
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
 /// <param name = "strFuncModuleId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strFuncModuleId)
{
CheckPrimaryKey(strFuncModuleId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncModuleDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("FuncModule", "FuncModuleId = " + "'"+ strFuncModuleId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsFuncModuleDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncModuleDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("FuncModule", strCondition))
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
objSQL = clsFuncModuleDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("FuncModule");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsFuncModuleEN objFuncModuleEN)
 {
 objFuncModuleEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFuncModuleEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFuncModuleEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncModuleDA.GetSpecSQLObj();
strSQL = "Select * from FuncModule where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "FuncModule");
objRow = objDS.Tables["FuncModule"].NewRow();
objRow[conFuncModule.FuncModuleId] = objFuncModuleEN.FuncModuleId; //功能模块Id
objRow[conFuncModule.FuncModuleName] = objFuncModuleEN.FuncModuleName; //功能模块名称
 if (objFuncModuleEN.FuncModuleNameSim !=  "")
 {
objRow[conFuncModule.FuncModuleNameSim] = objFuncModuleEN.FuncModuleNameSim; //功能模块简称
 }
 if (objFuncModuleEN.Memo !=  "")
 {
objRow[conFuncModule.Memo] = objFuncModuleEN.Memo; //备注
 }
 if (objFuncModuleEN.UpdDate !=  "")
 {
objRow[conFuncModule.UpdDate] = objFuncModuleEN.UpdDate; //修改日期
 }
 if (objFuncModuleEN.UpdUser !=  "")
 {
objRow[conFuncModule.UpdUser] = objFuncModuleEN.UpdUser; //修改人
 }
objRow[conFuncModule.OrderNum] = objFuncModuleEN.OrderNum; //序号
 if (objFuncModuleEN.PrjId !=  "")
 {
objRow[conFuncModule.PrjId] = objFuncModuleEN.PrjId; //PrjId
 }
 if (objFuncModuleEN.FuncModuleEnName !=  "")
 {
objRow[conFuncModule.FuncModuleEnName] = objFuncModuleEN.FuncModuleEnName; //FuncModuleEnName
 }
objRow[conFuncModule.UseStateId] = objFuncModuleEN.UseStateId; //UseStateId
objDS.Tables[clsFuncModuleEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsFuncModuleEN._CurrTabName);
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
 /// <param name = "objFuncModuleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsFuncModuleEN objFuncModuleEN)
{
 objFuncModuleEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFuncModuleEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFuncModuleEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objFuncModuleEN.FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conFuncModule.FuncModuleId);
 var strFuncModuleId = objFuncModuleEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId + "'");
 }
 
 if (objFuncModuleEN.FuncModuleName !=  null)
 {
 arrFieldListForInsert.Add(conFuncModule.FuncModuleName);
 var strFuncModuleName = objFuncModuleEN.FuncModuleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleName + "'");
 }
 
 if (objFuncModuleEN.FuncModuleNameSim !=  null)
 {
 arrFieldListForInsert.Add(conFuncModule.FuncModuleNameSim);
 var strFuncModuleNameSim = objFuncModuleEN.FuncModuleNameSim.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleNameSim + "'");
 }
 
 if (objFuncModuleEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFuncModule.Memo);
 var strMemo = objFuncModuleEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objFuncModuleEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conFuncModule.UpdDate);
 var strUpdDate = objFuncModuleEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objFuncModuleEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conFuncModule.UpdUser);
 var strUpdUser = objFuncModuleEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 arrFieldListForInsert.Add(conFuncModule.OrderNum);
 arrValueListForInsert.Add(objFuncModuleEN.OrderNum.ToString());
 
 if (objFuncModuleEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conFuncModule.PrjId);
 var strPrjId = objFuncModuleEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objFuncModuleEN.FuncModuleEnName !=  null)
 {
 arrFieldListForInsert.Add(conFuncModule.FuncModuleEnName);
 var strFuncModuleEnName = objFuncModuleEN.FuncModuleEnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleEnName + "'");
 }
 
 if (objFuncModuleEN.UseStateId !=  null)
 {
 arrFieldListForInsert.Add(conFuncModule.UseStateId);
 var strUseStateId = objFuncModuleEN.UseStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUseStateId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FuncModule");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncModuleDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objFuncModuleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsFuncModuleEN objFuncModuleEN)
{
 objFuncModuleEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFuncModuleEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFuncModuleEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objFuncModuleEN.FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conFuncModule.FuncModuleId);
 var strFuncModuleId = objFuncModuleEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId + "'");
 }
 
 if (objFuncModuleEN.FuncModuleName !=  null)
 {
 arrFieldListForInsert.Add(conFuncModule.FuncModuleName);
 var strFuncModuleName = objFuncModuleEN.FuncModuleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleName + "'");
 }
 
 if (objFuncModuleEN.FuncModuleNameSim !=  null)
 {
 arrFieldListForInsert.Add(conFuncModule.FuncModuleNameSim);
 var strFuncModuleNameSim = objFuncModuleEN.FuncModuleNameSim.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleNameSim + "'");
 }
 
 if (objFuncModuleEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFuncModule.Memo);
 var strMemo = objFuncModuleEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objFuncModuleEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conFuncModule.UpdDate);
 var strUpdDate = objFuncModuleEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objFuncModuleEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conFuncModule.UpdUser);
 var strUpdUser = objFuncModuleEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 arrFieldListForInsert.Add(conFuncModule.OrderNum);
 arrValueListForInsert.Add(objFuncModuleEN.OrderNum.ToString());
 
 if (objFuncModuleEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conFuncModule.PrjId);
 var strPrjId = objFuncModuleEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objFuncModuleEN.FuncModuleEnName !=  null)
 {
 arrFieldListForInsert.Add(conFuncModule.FuncModuleEnName);
 var strFuncModuleEnName = objFuncModuleEN.FuncModuleEnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleEnName + "'");
 }
 
 if (objFuncModuleEN.UseStateId !=  null)
 {
 arrFieldListForInsert.Add(conFuncModule.UseStateId);
 var strUseStateId = objFuncModuleEN.UseStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUseStateId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FuncModule");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncModuleDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objFuncModuleEN.FuncModuleId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objFuncModuleEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsFuncModuleEN objFuncModuleEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objFuncModuleEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFuncModuleEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFuncModuleEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objFuncModuleEN.FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conFuncModule.FuncModuleId);
 var strFuncModuleId = objFuncModuleEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId + "'");
 }
 
 if (objFuncModuleEN.FuncModuleName !=  null)
 {
 arrFieldListForInsert.Add(conFuncModule.FuncModuleName);
 var strFuncModuleName = objFuncModuleEN.FuncModuleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleName + "'");
 }
 
 if (objFuncModuleEN.FuncModuleNameSim !=  null)
 {
 arrFieldListForInsert.Add(conFuncModule.FuncModuleNameSim);
 var strFuncModuleNameSim = objFuncModuleEN.FuncModuleNameSim.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleNameSim + "'");
 }
 
 if (objFuncModuleEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFuncModule.Memo);
 var strMemo = objFuncModuleEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objFuncModuleEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conFuncModule.UpdDate);
 var strUpdDate = objFuncModuleEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objFuncModuleEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conFuncModule.UpdUser);
 var strUpdUser = objFuncModuleEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 arrFieldListForInsert.Add(conFuncModule.OrderNum);
 arrValueListForInsert.Add(objFuncModuleEN.OrderNum.ToString());
 
 if (objFuncModuleEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conFuncModule.PrjId);
 var strPrjId = objFuncModuleEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objFuncModuleEN.FuncModuleEnName !=  null)
 {
 arrFieldListForInsert.Add(conFuncModule.FuncModuleEnName);
 var strFuncModuleEnName = objFuncModuleEN.FuncModuleEnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleEnName + "'");
 }
 
 if (objFuncModuleEN.UseStateId !=  null)
 {
 arrFieldListForInsert.Add(conFuncModule.UseStateId);
 var strUseStateId = objFuncModuleEN.UseStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUseStateId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FuncModule");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncModuleDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objFuncModuleEN.FuncModuleId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objFuncModuleEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsFuncModuleEN objFuncModuleEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objFuncModuleEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFuncModuleEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFuncModuleEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objFuncModuleEN.FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conFuncModule.FuncModuleId);
 var strFuncModuleId = objFuncModuleEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId + "'");
 }
 
 if (objFuncModuleEN.FuncModuleName !=  null)
 {
 arrFieldListForInsert.Add(conFuncModule.FuncModuleName);
 var strFuncModuleName = objFuncModuleEN.FuncModuleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleName + "'");
 }
 
 if (objFuncModuleEN.FuncModuleNameSim !=  null)
 {
 arrFieldListForInsert.Add(conFuncModule.FuncModuleNameSim);
 var strFuncModuleNameSim = objFuncModuleEN.FuncModuleNameSim.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleNameSim + "'");
 }
 
 if (objFuncModuleEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFuncModule.Memo);
 var strMemo = objFuncModuleEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objFuncModuleEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conFuncModule.UpdDate);
 var strUpdDate = objFuncModuleEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objFuncModuleEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conFuncModule.UpdUser);
 var strUpdUser = objFuncModuleEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 arrFieldListForInsert.Add(conFuncModule.OrderNum);
 arrValueListForInsert.Add(objFuncModuleEN.OrderNum.ToString());
 
 if (objFuncModuleEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conFuncModule.PrjId);
 var strPrjId = objFuncModuleEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objFuncModuleEN.FuncModuleEnName !=  null)
 {
 arrFieldListForInsert.Add(conFuncModule.FuncModuleEnName);
 var strFuncModuleEnName = objFuncModuleEN.FuncModuleEnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleEnName + "'");
 }
 
 if (objFuncModuleEN.UseStateId !=  null)
 {
 arrFieldListForInsert.Add(conFuncModule.UseStateId);
 var strUseStateId = objFuncModuleEN.UseStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUseStateId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FuncModule");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncModuleDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewFuncModules(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncModuleDA.GetSpecSQLObj();
strSQL = "Select * from FuncModule where FuncModuleId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "FuncModule");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strFuncModuleId = oRow[conFuncModule.FuncModuleId].ToString().Trim();
if (IsExist(strFuncModuleId))
{
 string strResult = "关键字变量值为:" + string.Format("FuncModuleId = {0}", strFuncModuleId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsFuncModuleEN._CurrTabName ].NewRow();
objRow[conFuncModule.FuncModuleId] = oRow[conFuncModule.FuncModuleId].ToString().Trim(); //功能模块Id
objRow[conFuncModule.FuncModuleName] = oRow[conFuncModule.FuncModuleName].ToString().Trim(); //功能模块名称
objRow[conFuncModule.FuncModuleNameSim] = oRow[conFuncModule.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objRow[conFuncModule.Memo] = oRow[conFuncModule.Memo].ToString().Trim(); //备注
objRow[conFuncModule.UpdDate] = oRow[conFuncModule.UpdDate].ToString().Trim(); //修改日期
objRow[conFuncModule.UpdUser] = oRow[conFuncModule.UpdUser].ToString().Trim(); //修改人
objRow[conFuncModule.OrderNum] = oRow[conFuncModule.OrderNum].ToString().Trim(); //序号
objRow[conFuncModule.PrjId] = oRow[conFuncModule.PrjId].ToString().Trim(); //PrjId
objRow[conFuncModule.FuncModuleEnName] = oRow[conFuncModule.FuncModuleEnName].ToString().Trim(); //FuncModuleEnName
objRow[conFuncModule.UseStateId] = oRow[conFuncModule.UseStateId].ToString().Trim(); //UseStateId
 objDS.Tables[clsFuncModuleEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsFuncModuleEN._CurrTabName);
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
 /// <param name = "objFuncModuleEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsFuncModuleEN objFuncModuleEN)
{
 objFuncModuleEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFuncModuleEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFuncModuleEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncModuleDA.GetSpecSQLObj();
strSQL = "Select * from FuncModule where FuncModuleId = " + "'"+ objFuncModuleEN.FuncModuleId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsFuncModuleEN._CurrTabName);
if (objDS.Tables[clsFuncModuleEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:FuncModuleId = " + "'"+ objFuncModuleEN.FuncModuleId+"'");
return false;
}
objRow = objDS.Tables[clsFuncModuleEN._CurrTabName].Rows[0];
 if (objFuncModuleEN.IsUpdated(conFuncModule.FuncModuleId))
 {
objRow[conFuncModule.FuncModuleId] = objFuncModuleEN.FuncModuleId; //功能模块Id
 }
 if (objFuncModuleEN.IsUpdated(conFuncModule.FuncModuleName))
 {
objRow[conFuncModule.FuncModuleName] = objFuncModuleEN.FuncModuleName; //功能模块名称
 }
 if (objFuncModuleEN.IsUpdated(conFuncModule.FuncModuleNameSim))
 {
objRow[conFuncModule.FuncModuleNameSim] = objFuncModuleEN.FuncModuleNameSim; //功能模块简称
 }
 if (objFuncModuleEN.IsUpdated(conFuncModule.Memo))
 {
objRow[conFuncModule.Memo] = objFuncModuleEN.Memo; //备注
 }
 if (objFuncModuleEN.IsUpdated(conFuncModule.UpdDate))
 {
objRow[conFuncModule.UpdDate] = objFuncModuleEN.UpdDate; //修改日期
 }
 if (objFuncModuleEN.IsUpdated(conFuncModule.UpdUser))
 {
objRow[conFuncModule.UpdUser] = objFuncModuleEN.UpdUser; //修改人
 }
 if (objFuncModuleEN.IsUpdated(conFuncModule.OrderNum))
 {
objRow[conFuncModule.OrderNum] = objFuncModuleEN.OrderNum; //序号
 }
 if (objFuncModuleEN.IsUpdated(conFuncModule.PrjId))
 {
objRow[conFuncModule.PrjId] = objFuncModuleEN.PrjId; //PrjId
 }
 if (objFuncModuleEN.IsUpdated(conFuncModule.FuncModuleEnName))
 {
objRow[conFuncModule.FuncModuleEnName] = objFuncModuleEN.FuncModuleEnName; //FuncModuleEnName
 }
 if (objFuncModuleEN.IsUpdated(conFuncModule.UseStateId))
 {
objRow[conFuncModule.UseStateId] = objFuncModuleEN.UseStateId; //UseStateId
 }
try
{
objDA.Update(objDS, clsFuncModuleEN._CurrTabName);
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
 /// <param name = "objFuncModuleEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsFuncModuleEN objFuncModuleEN)
{
 objFuncModuleEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFuncModuleEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFuncModuleEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncModuleDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update FuncModule Set ");
 
 if (objFuncModuleEN.IsUpdated(conFuncModule.FuncModuleName))
 {
 if (objFuncModuleEN.FuncModuleName !=  null)
 {
 var strFuncModuleName = objFuncModuleEN.FuncModuleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncModuleName, conFuncModule.FuncModuleName); //功能模块名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFuncModule.FuncModuleName); //功能模块名称
 }
 }
 
 if (objFuncModuleEN.IsUpdated(conFuncModule.FuncModuleNameSim))
 {
 if (objFuncModuleEN.FuncModuleNameSim !=  null)
 {
 var strFuncModuleNameSim = objFuncModuleEN.FuncModuleNameSim.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncModuleNameSim, conFuncModule.FuncModuleNameSim); //功能模块简称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFuncModule.FuncModuleNameSim); //功能模块简称
 }
 }
 
 if (objFuncModuleEN.IsUpdated(conFuncModule.Memo))
 {
 if (objFuncModuleEN.Memo !=  null)
 {
 var strMemo = objFuncModuleEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conFuncModule.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFuncModule.Memo); //备注
 }
 }
 
 if (objFuncModuleEN.IsUpdated(conFuncModule.UpdDate))
 {
 if (objFuncModuleEN.UpdDate !=  null)
 {
 var strUpdDate = objFuncModuleEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conFuncModule.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFuncModule.UpdDate); //修改日期
 }
 }
 
 if (objFuncModuleEN.IsUpdated(conFuncModule.UpdUser))
 {
 if (objFuncModuleEN.UpdUser !=  null)
 {
 var strUpdUser = objFuncModuleEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conFuncModule.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFuncModule.UpdUser); //修改人
 }
 }
 
 if (objFuncModuleEN.IsUpdated(conFuncModule.OrderNum))
 {
 sbSQL.AppendFormat("{1} = {0},",objFuncModuleEN.OrderNum, conFuncModule.OrderNum); //序号
 }
 
 if (objFuncModuleEN.IsUpdated(conFuncModule.PrjId))
 {
 if (objFuncModuleEN.PrjId !=  null)
 {
 var strPrjId = objFuncModuleEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conFuncModule.PrjId); //PrjId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFuncModule.PrjId); //PrjId
 }
 }
 
 if (objFuncModuleEN.IsUpdated(conFuncModule.FuncModuleEnName))
 {
 if (objFuncModuleEN.FuncModuleEnName !=  null)
 {
 var strFuncModuleEnName = objFuncModuleEN.FuncModuleEnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncModuleEnName, conFuncModule.FuncModuleEnName); //FuncModuleEnName
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFuncModule.FuncModuleEnName); //FuncModuleEnName
 }
 }
 
 if (objFuncModuleEN.IsUpdated(conFuncModule.UseStateId))
 {
 if (objFuncModuleEN.UseStateId !=  null)
 {
 var strUseStateId = objFuncModuleEN.UseStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUseStateId, conFuncModule.UseStateId); //UseStateId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFuncModule.UseStateId); //UseStateId
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where FuncModuleId = '{0}'", objFuncModuleEN.FuncModuleId); 
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
 /// <param name = "objFuncModuleEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsFuncModuleEN objFuncModuleEN, string strCondition)
{
 objFuncModuleEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFuncModuleEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFuncModuleEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncModuleDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update FuncModule Set ");
 
 if (objFuncModuleEN.IsUpdated(conFuncModule.FuncModuleName))
 {
 if (objFuncModuleEN.FuncModuleName !=  null)
 {
 var strFuncModuleName = objFuncModuleEN.FuncModuleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncModuleName = '{0}',", strFuncModuleName); //功能模块名称
 }
 else
 {
 sbSQL.Append(" FuncModuleName = null,"); //功能模块名称
 }
 }
 
 if (objFuncModuleEN.IsUpdated(conFuncModule.FuncModuleNameSim))
 {
 if (objFuncModuleEN.FuncModuleNameSim !=  null)
 {
 var strFuncModuleNameSim = objFuncModuleEN.FuncModuleNameSim.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncModuleNameSim = '{0}',", strFuncModuleNameSim); //功能模块简称
 }
 else
 {
 sbSQL.Append(" FuncModuleNameSim = null,"); //功能模块简称
 }
 }
 
 if (objFuncModuleEN.IsUpdated(conFuncModule.Memo))
 {
 if (objFuncModuleEN.Memo !=  null)
 {
 var strMemo = objFuncModuleEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objFuncModuleEN.IsUpdated(conFuncModule.UpdDate))
 {
 if (objFuncModuleEN.UpdDate !=  null)
 {
 var strUpdDate = objFuncModuleEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objFuncModuleEN.IsUpdated(conFuncModule.UpdUser))
 {
 if (objFuncModuleEN.UpdUser !=  null)
 {
 var strUpdUser = objFuncModuleEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objFuncModuleEN.IsUpdated(conFuncModule.OrderNum))
 {
 sbSQL.AppendFormat(" OrderNum = {0},", objFuncModuleEN.OrderNum); //序号
 }
 
 if (objFuncModuleEN.IsUpdated(conFuncModule.PrjId))
 {
 if (objFuncModuleEN.PrjId !=  null)
 {
 var strPrjId = objFuncModuleEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //PrjId
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //PrjId
 }
 }
 
 if (objFuncModuleEN.IsUpdated(conFuncModule.FuncModuleEnName))
 {
 if (objFuncModuleEN.FuncModuleEnName !=  null)
 {
 var strFuncModuleEnName = objFuncModuleEN.FuncModuleEnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncModuleEnName = '{0}',", strFuncModuleEnName); //FuncModuleEnName
 }
 else
 {
 sbSQL.Append(" FuncModuleEnName = null,"); //FuncModuleEnName
 }
 }
 
 if (objFuncModuleEN.IsUpdated(conFuncModule.UseStateId))
 {
 if (objFuncModuleEN.UseStateId !=  null)
 {
 var strUseStateId = objFuncModuleEN.UseStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UseStateId = '{0}',", strUseStateId); //UseStateId
 }
 else
 {
 sbSQL.Append(" UseStateId = null,"); //UseStateId
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
 /// <param name = "objFuncModuleEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsFuncModuleEN objFuncModuleEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objFuncModuleEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFuncModuleEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFuncModuleEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncModuleDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update FuncModule Set ");
 
 if (objFuncModuleEN.IsUpdated(conFuncModule.FuncModuleName))
 {
 if (objFuncModuleEN.FuncModuleName !=  null)
 {
 var strFuncModuleName = objFuncModuleEN.FuncModuleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncModuleName = '{0}',", strFuncModuleName); //功能模块名称
 }
 else
 {
 sbSQL.Append(" FuncModuleName = null,"); //功能模块名称
 }
 }
 
 if (objFuncModuleEN.IsUpdated(conFuncModule.FuncModuleNameSim))
 {
 if (objFuncModuleEN.FuncModuleNameSim !=  null)
 {
 var strFuncModuleNameSim = objFuncModuleEN.FuncModuleNameSim.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncModuleNameSim = '{0}',", strFuncModuleNameSim); //功能模块简称
 }
 else
 {
 sbSQL.Append(" FuncModuleNameSim = null,"); //功能模块简称
 }
 }
 
 if (objFuncModuleEN.IsUpdated(conFuncModule.Memo))
 {
 if (objFuncModuleEN.Memo !=  null)
 {
 var strMemo = objFuncModuleEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objFuncModuleEN.IsUpdated(conFuncModule.UpdDate))
 {
 if (objFuncModuleEN.UpdDate !=  null)
 {
 var strUpdDate = objFuncModuleEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objFuncModuleEN.IsUpdated(conFuncModule.UpdUser))
 {
 if (objFuncModuleEN.UpdUser !=  null)
 {
 var strUpdUser = objFuncModuleEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objFuncModuleEN.IsUpdated(conFuncModule.OrderNum))
 {
 sbSQL.AppendFormat(" OrderNum = {0},", objFuncModuleEN.OrderNum); //序号
 }
 
 if (objFuncModuleEN.IsUpdated(conFuncModule.PrjId))
 {
 if (objFuncModuleEN.PrjId !=  null)
 {
 var strPrjId = objFuncModuleEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //PrjId
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //PrjId
 }
 }
 
 if (objFuncModuleEN.IsUpdated(conFuncModule.FuncModuleEnName))
 {
 if (objFuncModuleEN.FuncModuleEnName !=  null)
 {
 var strFuncModuleEnName = objFuncModuleEN.FuncModuleEnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncModuleEnName = '{0}',", strFuncModuleEnName); //FuncModuleEnName
 }
 else
 {
 sbSQL.Append(" FuncModuleEnName = null,"); //FuncModuleEnName
 }
 }
 
 if (objFuncModuleEN.IsUpdated(conFuncModule.UseStateId))
 {
 if (objFuncModuleEN.UseStateId !=  null)
 {
 var strUseStateId = objFuncModuleEN.UseStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UseStateId = '{0}',", strUseStateId); //UseStateId
 }
 else
 {
 sbSQL.Append(" UseStateId = null,"); //UseStateId
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
 /// <param name = "objFuncModuleEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsFuncModuleEN objFuncModuleEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objFuncModuleEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFuncModuleEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFuncModuleEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncModuleDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update FuncModule Set ");
 
 if (objFuncModuleEN.IsUpdated(conFuncModule.FuncModuleName))
 {
 if (objFuncModuleEN.FuncModuleName !=  null)
 {
 var strFuncModuleName = objFuncModuleEN.FuncModuleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncModuleName, conFuncModule.FuncModuleName); //功能模块名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFuncModule.FuncModuleName); //功能模块名称
 }
 }
 
 if (objFuncModuleEN.IsUpdated(conFuncModule.FuncModuleNameSim))
 {
 if (objFuncModuleEN.FuncModuleNameSim !=  null)
 {
 var strFuncModuleNameSim = objFuncModuleEN.FuncModuleNameSim.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncModuleNameSim, conFuncModule.FuncModuleNameSim); //功能模块简称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFuncModule.FuncModuleNameSim); //功能模块简称
 }
 }
 
 if (objFuncModuleEN.IsUpdated(conFuncModule.Memo))
 {
 if (objFuncModuleEN.Memo !=  null)
 {
 var strMemo = objFuncModuleEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conFuncModule.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFuncModule.Memo); //备注
 }
 }
 
 if (objFuncModuleEN.IsUpdated(conFuncModule.UpdDate))
 {
 if (objFuncModuleEN.UpdDate !=  null)
 {
 var strUpdDate = objFuncModuleEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conFuncModule.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFuncModule.UpdDate); //修改日期
 }
 }
 
 if (objFuncModuleEN.IsUpdated(conFuncModule.UpdUser))
 {
 if (objFuncModuleEN.UpdUser !=  null)
 {
 var strUpdUser = objFuncModuleEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conFuncModule.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFuncModule.UpdUser); //修改人
 }
 }
 
 if (objFuncModuleEN.IsUpdated(conFuncModule.OrderNum))
 {
 sbSQL.AppendFormat("{1} = {0},",objFuncModuleEN.OrderNum, conFuncModule.OrderNum); //序号
 }
 
 if (objFuncModuleEN.IsUpdated(conFuncModule.PrjId))
 {
 if (objFuncModuleEN.PrjId !=  null)
 {
 var strPrjId = objFuncModuleEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conFuncModule.PrjId); //PrjId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFuncModule.PrjId); //PrjId
 }
 }
 
 if (objFuncModuleEN.IsUpdated(conFuncModule.FuncModuleEnName))
 {
 if (objFuncModuleEN.FuncModuleEnName !=  null)
 {
 var strFuncModuleEnName = objFuncModuleEN.FuncModuleEnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncModuleEnName, conFuncModule.FuncModuleEnName); //FuncModuleEnName
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFuncModule.FuncModuleEnName); //FuncModuleEnName
 }
 }
 
 if (objFuncModuleEN.IsUpdated(conFuncModule.UseStateId))
 {
 if (objFuncModuleEN.UseStateId !=  null)
 {
 var strUseStateId = objFuncModuleEN.UseStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUseStateId, conFuncModule.UseStateId); //UseStateId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFuncModule.UseStateId); //UseStateId
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where FuncModuleId = '{0}'", objFuncModuleEN.FuncModuleId); 
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
 /// <param name = "strFuncModuleId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strFuncModuleId) 
{
CheckPrimaryKey(strFuncModuleId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncModuleDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strFuncModuleId,
};
 objSQL.ExecSP("FuncModule_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strFuncModuleId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strFuncModuleId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strFuncModuleId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncModuleDA.GetSpecSQLObj();
//删除FuncModule本表中与当前对象有关的记录
strSQL = strSQL + "Delete from FuncModule where FuncModuleId = " + "'"+ strFuncModuleId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelFuncModule(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncModuleDA.GetSpecSQLObj();
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
//删除FuncModule本表中与当前对象有关的记录
strSQL = strSQL + "Delete from FuncModule where FuncModuleId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strFuncModuleId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strFuncModuleId) 
{
CheckPrimaryKey(strFuncModuleId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncModuleDA.GetSpecSQLObj();
//删除FuncModule本表中与当前对象有关的记录
strSQL = strSQL + "Delete from FuncModule where FuncModuleId = " + "'"+ strFuncModuleId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelFuncModule(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsFuncModuleDA: DelFuncModule)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncModuleDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from FuncModule where " + strCondition ;
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
public bool DelFuncModuleWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsFuncModuleDA: DelFuncModuleWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncModuleDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from FuncModule where " + strCondition ;
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
 /// <param name = "objFuncModuleENS">源对象</param>
 /// <param name = "objFuncModuleENT">目标对象</param>
public void CopyTo(clsFuncModuleEN objFuncModuleENS, clsFuncModuleEN objFuncModuleENT)
{
objFuncModuleENT.FuncModuleId = objFuncModuleENS.FuncModuleId; //功能模块Id
objFuncModuleENT.FuncModuleName = objFuncModuleENS.FuncModuleName; //功能模块名称
objFuncModuleENT.FuncModuleNameSim = objFuncModuleENS.FuncModuleNameSim; //功能模块简称
objFuncModuleENT.Memo = objFuncModuleENS.Memo; //备注
objFuncModuleENT.UpdDate = objFuncModuleENS.UpdDate; //修改日期
objFuncModuleENT.UpdUser = objFuncModuleENS.UpdUser; //修改人
objFuncModuleENT.OrderNum = objFuncModuleENS.OrderNum; //序号
objFuncModuleENT.PrjId = objFuncModuleENS.PrjId; //PrjId
objFuncModuleENT.FuncModuleEnName = objFuncModuleENS.FuncModuleEnName; //FuncModuleEnName
objFuncModuleENT.UseStateId = objFuncModuleENS.UseStateId; //UseStateId
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsFuncModuleEN objFuncModuleEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objFuncModuleEN.FuncModuleName, conFuncModule.FuncModuleName);
clsCheckSql.CheckFieldNotNull(objFuncModuleEN.OrderNum, conFuncModule.OrderNum);
clsCheckSql.CheckFieldNotNull(objFuncModuleEN.UseStateId, conFuncModule.UseStateId);
//检查字段长度
clsCheckSql.CheckFieldLen(objFuncModuleEN.FuncModuleId, 4, conFuncModule.FuncModuleId);
clsCheckSql.CheckFieldLen(objFuncModuleEN.FuncModuleName, 30, conFuncModule.FuncModuleName);
clsCheckSql.CheckFieldLen(objFuncModuleEN.FuncModuleNameSim, 30, conFuncModule.FuncModuleNameSim);
clsCheckSql.CheckFieldLen(objFuncModuleEN.Memo, 1000, conFuncModule.Memo);
clsCheckSql.CheckFieldLen(objFuncModuleEN.UpdDate, 20, conFuncModule.UpdDate);
clsCheckSql.CheckFieldLen(objFuncModuleEN.UpdUser, 20, conFuncModule.UpdUser);
clsCheckSql.CheckFieldLen(objFuncModuleEN.PrjId, 4, conFuncModule.PrjId);
clsCheckSql.CheckFieldLen(objFuncModuleEN.FuncModuleEnName, 30, conFuncModule.FuncModuleEnName);
clsCheckSql.CheckFieldLen(objFuncModuleEN.UseStateId, 4, conFuncModule.UseStateId);
//检查字段外键固定长度
 objFuncModuleEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsFuncModuleEN objFuncModuleEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objFuncModuleEN.FuncModuleName, 30, conFuncModule.FuncModuleName);
clsCheckSql.CheckFieldLen(objFuncModuleEN.FuncModuleNameSim, 30, conFuncModule.FuncModuleNameSim);
clsCheckSql.CheckFieldLen(objFuncModuleEN.Memo, 1000, conFuncModule.Memo);
clsCheckSql.CheckFieldLen(objFuncModuleEN.UpdDate, 20, conFuncModule.UpdDate);
clsCheckSql.CheckFieldLen(objFuncModuleEN.UpdUser, 20, conFuncModule.UpdUser);
clsCheckSql.CheckFieldLen(objFuncModuleEN.PrjId, 4, conFuncModule.PrjId);
clsCheckSql.CheckFieldLen(objFuncModuleEN.FuncModuleEnName, 30, conFuncModule.FuncModuleEnName);
clsCheckSql.CheckFieldLen(objFuncModuleEN.UseStateId, 4, conFuncModule.UseStateId);
//检查外键字段长度
 objFuncModuleEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsFuncModuleEN objFuncModuleEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objFuncModuleEN.FuncModuleId, 4, conFuncModule.FuncModuleId);
clsCheckSql.CheckFieldLen(objFuncModuleEN.FuncModuleName, 30, conFuncModule.FuncModuleName);
clsCheckSql.CheckFieldLen(objFuncModuleEN.FuncModuleNameSim, 30, conFuncModule.FuncModuleNameSim);
clsCheckSql.CheckFieldLen(objFuncModuleEN.Memo, 1000, conFuncModule.Memo);
clsCheckSql.CheckFieldLen(objFuncModuleEN.UpdDate, 20, conFuncModule.UpdDate);
clsCheckSql.CheckFieldLen(objFuncModuleEN.UpdUser, 20, conFuncModule.UpdUser);
clsCheckSql.CheckFieldLen(objFuncModuleEN.PrjId, 4, conFuncModule.PrjId);
clsCheckSql.CheckFieldLen(objFuncModuleEN.FuncModuleEnName, 30, conFuncModule.FuncModuleEnName);
clsCheckSql.CheckFieldLen(objFuncModuleEN.UseStateId, 4, conFuncModule.UseStateId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objFuncModuleEN.FuncModuleId, conFuncModule.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objFuncModuleEN.FuncModuleName, conFuncModule.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objFuncModuleEN.FuncModuleNameSim, conFuncModule.FuncModuleNameSim);
clsCheckSql.CheckSqlInjection4Field(objFuncModuleEN.Memo, conFuncModule.Memo);
clsCheckSql.CheckSqlInjection4Field(objFuncModuleEN.UpdDate, conFuncModule.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objFuncModuleEN.UpdUser, conFuncModule.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objFuncModuleEN.PrjId, conFuncModule.PrjId);
clsCheckSql.CheckSqlInjection4Field(objFuncModuleEN.FuncModuleEnName, conFuncModule.FuncModuleEnName);
clsCheckSql.CheckSqlInjection4Field(objFuncModuleEN.UseStateId, conFuncModule.UseStateId);
//检查外键字段长度
 objFuncModuleEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetFuncModuleId()
{
//获取某学院所有专业信息
string strSQL = "select FuncModuleId, FuncModuleName from FuncModule ";
 clsSpecSQLforSql mySql = clsFuncModuleDA.GetSpecSQLObj();
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
 objSQL = clsFuncModuleDA.GetSpecSQLObj();
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
 objSQL = clsFuncModuleDA.GetSpecSQLObj();
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
 objSQL = clsFuncModuleDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsFuncModuleEN._CurrTabName);
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
 objSQL = clsFuncModuleDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsFuncModuleEN._CurrTabName, strCondition);
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
 objSQL = clsFuncModuleDA.GetSpecSQLObj();
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
 objSQL = clsFuncModuleDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}