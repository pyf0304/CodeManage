
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_TobeStudiedProblemDA
 表名:vzx_TobeStudiedProblem(01120840)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:14:22
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
 /// vzx_TobeStudiedProblem(vzx_TobeStudiedProblem)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvzx_TobeStudiedProblemDA : clsCommBase4DA
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
 return clsvzx_TobeStudiedProblemEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvzx_TobeStudiedProblemEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvzx_TobeStudiedProblemEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvzx_TobeStudiedProblemEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvzx_TobeStudiedProblemEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:vzx_TobeStudiedProblem中,检查关键字,长度不正确!(clsvzx_TobeStudiedProblemDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strProblemId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vzx_TobeStudiedProblem中,关键字不能为空 或 null!(clsvzx_TobeStudiedProblemDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strProblemId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvzx_TobeStudiedProblemDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvzx_TobeStudiedProblemDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TobeStudiedProblemDA.GetSpecSQLObj();
strSQL = "Select * from vzx_TobeStudiedProblem where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vzx_TobeStudiedProblem(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvzx_TobeStudiedProblemDA: GetDataTable_vzx_TobeStudiedProblem)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TobeStudiedProblemDA.GetSpecSQLObj();
strSQL = "Select * from vzx_TobeStudiedProblem where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvzx_TobeStudiedProblemDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TobeStudiedProblemDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvzx_TobeStudiedProblemDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TobeStudiedProblemDA.GetSpecSQLObj();
strSQL = "Select * from vzx_TobeStudiedProblem where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvzx_TobeStudiedProblemDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TobeStudiedProblemDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvzx_TobeStudiedProblemDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TobeStudiedProblemDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vzx_TobeStudiedProblem where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vzx_TobeStudiedProblem where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvzx_TobeStudiedProblemDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TobeStudiedProblemDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vzx_TobeStudiedProblem where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvzx_TobeStudiedProblemDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TobeStudiedProblemDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vzx_TobeStudiedProblem.* from vzx_TobeStudiedProblem Left Join {1} on {2} where {3} and vzx_TobeStudiedProblem.ProblemId not in (Select top {5} vzx_TobeStudiedProblem.ProblemId from vzx_TobeStudiedProblem Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vzx_TobeStudiedProblem where {1} and ProblemId not in (Select top {2} ProblemId from vzx_TobeStudiedProblem where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vzx_TobeStudiedProblem where {1} and ProblemId not in (Select top {3} ProblemId from vzx_TobeStudiedProblem where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvzx_TobeStudiedProblemDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TobeStudiedProblemDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vzx_TobeStudiedProblem.* from vzx_TobeStudiedProblem Left Join {1} on {2} where {3} and vzx_TobeStudiedProblem.ProblemId not in (Select top {5} vzx_TobeStudiedProblem.ProblemId from vzx_TobeStudiedProblem Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vzx_TobeStudiedProblem where {1} and ProblemId not in (Select top {2} ProblemId from vzx_TobeStudiedProblem where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vzx_TobeStudiedProblem where {1} and ProblemId not in (Select top {3} ProblemId from vzx_TobeStudiedProblem where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvzx_TobeStudiedProblemEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvzx_TobeStudiedProblemDA:GetObjLst)", objException.Message));
}
List<clsvzx_TobeStudiedProblemEN> arrObjLst = new List<clsvzx_TobeStudiedProblemEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TobeStudiedProblemDA.GetSpecSQLObj();
strSQL = "Select * from vzx_TobeStudiedProblem where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_TobeStudiedProblemEN objvzx_TobeStudiedProblemEN = new clsvzx_TobeStudiedProblemEN();
try
{
objvzx_TobeStudiedProblemEN.GroupTextId = objRow[convzx_TobeStudiedProblem.GroupTextId] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.GroupTextId].ToString().Trim(); //小组Id
objvzx_TobeStudiedProblemEN.GroupTextName = objRow[convzx_TobeStudiedProblem.GroupTextName] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.GroupTextName].ToString().Trim(); //小组名称
objvzx_TobeStudiedProblemEN.IdCurrEduCls = objRow[convzx_TobeStudiedProblem.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TobeStudiedProblemEN.zxShareId = objRow[convzx_TobeStudiedProblem.zxShareId] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.zxShareId].ToString().Trim(); //分享Id
objvzx_TobeStudiedProblemEN.Memo = objRow[convzx_TobeStudiedProblem.Memo] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.Memo].ToString().Trim(); //备注
objvzx_TobeStudiedProblemEN.Participant = objRow[convzx_TobeStudiedProblem.Participant] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.Participant].ToString().Trim(); //参与者
objvzx_TobeStudiedProblemEN.VersionCount = objRow[convzx_TobeStudiedProblem.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TobeStudiedProblem.VersionCount].ToString().Trim()); //版本统计
objvzx_TobeStudiedProblemEN.IsSubmit = TransNullToBool(objRow[convzx_TobeStudiedProblem.IsSubmit].ToString().Trim()); //是否提交
objvzx_TobeStudiedProblemEN.ProblemId = objRow[convzx_TobeStudiedProblem.ProblemId].ToString().Trim(); //问题Id
objvzx_TobeStudiedProblemEN.ProblemTitle = objRow[convzx_TobeStudiedProblem.ProblemTitle] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.ProblemTitle].ToString().Trim(); //问题标题
objvzx_TobeStudiedProblemEN.ProblemContent = objRow[convzx_TobeStudiedProblem.ProblemContent] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.ProblemContent].ToString().Trim(); //问题内容
objvzx_TobeStudiedProblemEN.ProblemDate = objRow[convzx_TobeStudiedProblem.ProblemDate] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.ProblemDate].ToString().Trim(); //问题日期
objvzx_TobeStudiedProblemEN.UpdDate = objRow[convzx_TobeStudiedProblem.UpdDate] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.UpdDate].ToString().Trim(); //修改日期
objvzx_TobeStudiedProblemEN.UpdUser = objRow[convzx_TobeStudiedProblem.UpdUser] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.UpdUser].ToString().Trim(); //修改人
objvzx_TobeStudiedProblemEN.Year = objRow[convzx_TobeStudiedProblem.Year] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.Year].ToString().Trim(); //年
objvzx_TobeStudiedProblemEN.Month = objRow[convzx_TobeStudiedProblem.Month] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.Month].ToString().Trim(); //月
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvzx_TobeStudiedProblemDA: GetObjLst)", objException.Message));
}
objvzx_TobeStudiedProblemEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvzx_TobeStudiedProblemEN);
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
public List<clsvzx_TobeStudiedProblemEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvzx_TobeStudiedProblemDA:GetObjLstByTabName)", objException.Message));
}
List<clsvzx_TobeStudiedProblemEN> arrObjLst = new List<clsvzx_TobeStudiedProblemEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TobeStudiedProblemDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_TobeStudiedProblemEN objvzx_TobeStudiedProblemEN = new clsvzx_TobeStudiedProblemEN();
try
{
objvzx_TobeStudiedProblemEN.GroupTextId = objRow[convzx_TobeStudiedProblem.GroupTextId] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.GroupTextId].ToString().Trim(); //小组Id
objvzx_TobeStudiedProblemEN.GroupTextName = objRow[convzx_TobeStudiedProblem.GroupTextName] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.GroupTextName].ToString().Trim(); //小组名称
objvzx_TobeStudiedProblemEN.IdCurrEduCls = objRow[convzx_TobeStudiedProblem.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TobeStudiedProblemEN.zxShareId = objRow[convzx_TobeStudiedProblem.zxShareId] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.zxShareId].ToString().Trim(); //分享Id
objvzx_TobeStudiedProblemEN.Memo = objRow[convzx_TobeStudiedProblem.Memo] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.Memo].ToString().Trim(); //备注
objvzx_TobeStudiedProblemEN.Participant = objRow[convzx_TobeStudiedProblem.Participant] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.Participant].ToString().Trim(); //参与者
objvzx_TobeStudiedProblemEN.VersionCount = objRow[convzx_TobeStudiedProblem.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TobeStudiedProblem.VersionCount].ToString().Trim()); //版本统计
objvzx_TobeStudiedProblemEN.IsSubmit = TransNullToBool(objRow[convzx_TobeStudiedProblem.IsSubmit].ToString().Trim()); //是否提交
objvzx_TobeStudiedProblemEN.ProblemId = objRow[convzx_TobeStudiedProblem.ProblemId].ToString().Trim(); //问题Id
objvzx_TobeStudiedProblemEN.ProblemTitle = objRow[convzx_TobeStudiedProblem.ProblemTitle] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.ProblemTitle].ToString().Trim(); //问题标题
objvzx_TobeStudiedProblemEN.ProblemContent = objRow[convzx_TobeStudiedProblem.ProblemContent] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.ProblemContent].ToString().Trim(); //问题内容
objvzx_TobeStudiedProblemEN.ProblemDate = objRow[convzx_TobeStudiedProblem.ProblemDate] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.ProblemDate].ToString().Trim(); //问题日期
objvzx_TobeStudiedProblemEN.UpdDate = objRow[convzx_TobeStudiedProblem.UpdDate] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.UpdDate].ToString().Trim(); //修改日期
objvzx_TobeStudiedProblemEN.UpdUser = objRow[convzx_TobeStudiedProblem.UpdUser] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.UpdUser].ToString().Trim(); //修改人
objvzx_TobeStudiedProblemEN.Year = objRow[convzx_TobeStudiedProblem.Year] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.Year].ToString().Trim(); //年
objvzx_TobeStudiedProblemEN.Month = objRow[convzx_TobeStudiedProblem.Month] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.Month].ToString().Trim(); //月
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvzx_TobeStudiedProblemDA: GetObjLst)", objException.Message));
}
objvzx_TobeStudiedProblemEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvzx_TobeStudiedProblemEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvzx_TobeStudiedProblemEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getvzx_TobeStudiedProblem(ref clsvzx_TobeStudiedProblemEN objvzx_TobeStudiedProblemEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TobeStudiedProblemDA.GetSpecSQLObj();
strSQL = "Select * from vzx_TobeStudiedProblem where ProblemId = " + "'"+ objvzx_TobeStudiedProblemEN.ProblemId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvzx_TobeStudiedProblemEN.GroupTextId = objDT.Rows[0][convzx_TobeStudiedProblem.GroupTextId].ToString().Trim(); //小组Id(字段类型:char,字段长度:8,是否可空:False)
 objvzx_TobeStudiedProblemEN.GroupTextName = objDT.Rows[0][convzx_TobeStudiedProblem.GroupTextName].ToString().Trim(); //小组名称(字段类型:varchar,字段长度:2000,是否可空:True)
 objvzx_TobeStudiedProblemEN.IdCurrEduCls = objDT.Rows[0][convzx_TobeStudiedProblem.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvzx_TobeStudiedProblemEN.zxShareId = objDT.Rows[0][convzx_TobeStudiedProblem.zxShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objvzx_TobeStudiedProblemEN.Memo = objDT.Rows[0][convzx_TobeStudiedProblem.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_TobeStudiedProblemEN.Participant = objDT.Rows[0][convzx_TobeStudiedProblem.Participant].ToString().Trim(); //参与者(字段类型:varchar,字段长度:500,是否可空:True)
 objvzx_TobeStudiedProblemEN.VersionCount = TransNullToInt(objDT.Rows[0][convzx_TobeStudiedProblem.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objvzx_TobeStudiedProblemEN.IsSubmit = TransNullToBool(objDT.Rows[0][convzx_TobeStudiedProblem.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvzx_TobeStudiedProblemEN.ProblemId = objDT.Rows[0][convzx_TobeStudiedProblem.ProblemId].ToString().Trim(); //问题Id(字段类型:char,字段长度:10,是否可空:False)
 objvzx_TobeStudiedProblemEN.ProblemTitle = objDT.Rows[0][convzx_TobeStudiedProblem.ProblemTitle].ToString().Trim(); //问题标题(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_TobeStudiedProblemEN.ProblemContent = objDT.Rows[0][convzx_TobeStudiedProblem.ProblemContent].ToString().Trim(); //问题内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvzx_TobeStudiedProblemEN.ProblemDate = objDT.Rows[0][convzx_TobeStudiedProblem.ProblemDate].ToString().Trim(); //问题日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_TobeStudiedProblemEN.UpdDate = objDT.Rows[0][convzx_TobeStudiedProblem.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_TobeStudiedProblemEN.UpdUser = objDT.Rows[0][convzx_TobeStudiedProblem.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_TobeStudiedProblemEN.Year = objDT.Rows[0][convzx_TobeStudiedProblem.Year].ToString().Trim(); //年(字段类型:char,字段长度:4,是否可空:True)
 objvzx_TobeStudiedProblemEN.Month = objDT.Rows[0][convzx_TobeStudiedProblem.Month].ToString().Trim(); //月(字段类型:char,字段长度:2,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvzx_TobeStudiedProblemDA: Getvzx_TobeStudiedProblem)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strProblemId">表关键字</param>
 /// <returns>表对象</returns>
public clsvzx_TobeStudiedProblemEN GetObjByProblemId(string strProblemId)
{
CheckPrimaryKey(strProblemId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TobeStudiedProblemDA.GetSpecSQLObj();
strSQL = "Select * from vzx_TobeStudiedProblem where ProblemId = " + "'"+ strProblemId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvzx_TobeStudiedProblemEN objvzx_TobeStudiedProblemEN = new clsvzx_TobeStudiedProblemEN();
try
{
 objvzx_TobeStudiedProblemEN.GroupTextId = objRow[convzx_TobeStudiedProblem.GroupTextId] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.GroupTextId].ToString().Trim(); //小组Id(字段类型:char,字段长度:8,是否可空:False)
 objvzx_TobeStudiedProblemEN.GroupTextName = objRow[convzx_TobeStudiedProblem.GroupTextName] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.GroupTextName].ToString().Trim(); //小组名称(字段类型:varchar,字段长度:2000,是否可空:True)
 objvzx_TobeStudiedProblemEN.IdCurrEduCls = objRow[convzx_TobeStudiedProblem.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvzx_TobeStudiedProblemEN.zxShareId = objRow[convzx_TobeStudiedProblem.zxShareId] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.zxShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objvzx_TobeStudiedProblemEN.Memo = objRow[convzx_TobeStudiedProblem.Memo] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_TobeStudiedProblemEN.Participant = objRow[convzx_TobeStudiedProblem.Participant] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.Participant].ToString().Trim(); //参与者(字段类型:varchar,字段长度:500,是否可空:True)
 objvzx_TobeStudiedProblemEN.VersionCount = objRow[convzx_TobeStudiedProblem.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TobeStudiedProblem.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objvzx_TobeStudiedProblemEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_TobeStudiedProblem.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvzx_TobeStudiedProblemEN.ProblemId = objRow[convzx_TobeStudiedProblem.ProblemId].ToString().Trim(); //问题Id(字段类型:char,字段长度:10,是否可空:False)
 objvzx_TobeStudiedProblemEN.ProblemTitle = objRow[convzx_TobeStudiedProblem.ProblemTitle] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.ProblemTitle].ToString().Trim(); //问题标题(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_TobeStudiedProblemEN.ProblemContent = objRow[convzx_TobeStudiedProblem.ProblemContent] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.ProblemContent].ToString().Trim(); //问题内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvzx_TobeStudiedProblemEN.ProblemDate = objRow[convzx_TobeStudiedProblem.ProblemDate] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.ProblemDate].ToString().Trim(); //问题日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_TobeStudiedProblemEN.UpdDate = objRow[convzx_TobeStudiedProblem.UpdDate] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_TobeStudiedProblemEN.UpdUser = objRow[convzx_TobeStudiedProblem.UpdUser] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_TobeStudiedProblemEN.Year = objRow[convzx_TobeStudiedProblem.Year] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.Year].ToString().Trim(); //年(字段类型:char,字段长度:4,是否可空:True)
 objvzx_TobeStudiedProblemEN.Month = objRow[convzx_TobeStudiedProblem.Month] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.Month].ToString().Trim(); //月(字段类型:char,字段长度:2,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvzx_TobeStudiedProblemDA: GetObjByProblemId)", objException.Message));
}
return objvzx_TobeStudiedProblemEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvzx_TobeStudiedProblemEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvzx_TobeStudiedProblemDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TobeStudiedProblemDA.GetSpecSQLObj();
strSQL = "Select * from vzx_TobeStudiedProblem where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvzx_TobeStudiedProblemEN objvzx_TobeStudiedProblemEN = new clsvzx_TobeStudiedProblemEN()
{
GroupTextId = objRow[convzx_TobeStudiedProblem.GroupTextId] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.GroupTextId].ToString().Trim(), //小组Id
GroupTextName = objRow[convzx_TobeStudiedProblem.GroupTextName] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.GroupTextName].ToString().Trim(), //小组名称
IdCurrEduCls = objRow[convzx_TobeStudiedProblem.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.IdCurrEduCls].ToString().Trim(), //教学班流水号
zxShareId = objRow[convzx_TobeStudiedProblem.zxShareId] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.zxShareId].ToString().Trim(), //分享Id
Memo = objRow[convzx_TobeStudiedProblem.Memo] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.Memo].ToString().Trim(), //备注
Participant = objRow[convzx_TobeStudiedProblem.Participant] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.Participant].ToString().Trim(), //参与者
VersionCount = objRow[convzx_TobeStudiedProblem.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TobeStudiedProblem.VersionCount].ToString().Trim()), //版本统计
IsSubmit = TransNullToBool(objRow[convzx_TobeStudiedProblem.IsSubmit].ToString().Trim()), //是否提交
ProblemId = objRow[convzx_TobeStudiedProblem.ProblemId].ToString().Trim(), //问题Id
ProblemTitle = objRow[convzx_TobeStudiedProblem.ProblemTitle] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.ProblemTitle].ToString().Trim(), //问题标题
ProblemContent = objRow[convzx_TobeStudiedProblem.ProblemContent] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.ProblemContent].ToString().Trim(), //问题内容
ProblemDate = objRow[convzx_TobeStudiedProblem.ProblemDate] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.ProblemDate].ToString().Trim(), //问题日期
UpdDate = objRow[convzx_TobeStudiedProblem.UpdDate] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convzx_TobeStudiedProblem.UpdUser] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.UpdUser].ToString().Trim(), //修改人
Year = objRow[convzx_TobeStudiedProblem.Year] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.Year].ToString().Trim(), //年
Month = objRow[convzx_TobeStudiedProblem.Month] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.Month].ToString().Trim() //月
};
objvzx_TobeStudiedProblemEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvzx_TobeStudiedProblemEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvzx_TobeStudiedProblemDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvzx_TobeStudiedProblemEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvzx_TobeStudiedProblemEN objvzx_TobeStudiedProblemEN = new clsvzx_TobeStudiedProblemEN();
try
{
objvzx_TobeStudiedProblemEN.GroupTextId = objRow[convzx_TobeStudiedProblem.GroupTextId] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.GroupTextId].ToString().Trim(); //小组Id
objvzx_TobeStudiedProblemEN.GroupTextName = objRow[convzx_TobeStudiedProblem.GroupTextName] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.GroupTextName].ToString().Trim(); //小组名称
objvzx_TobeStudiedProblemEN.IdCurrEduCls = objRow[convzx_TobeStudiedProblem.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TobeStudiedProblemEN.zxShareId = objRow[convzx_TobeStudiedProblem.zxShareId] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.zxShareId].ToString().Trim(); //分享Id
objvzx_TobeStudiedProblemEN.Memo = objRow[convzx_TobeStudiedProblem.Memo] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.Memo].ToString().Trim(); //备注
objvzx_TobeStudiedProblemEN.Participant = objRow[convzx_TobeStudiedProblem.Participant] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.Participant].ToString().Trim(); //参与者
objvzx_TobeStudiedProblemEN.VersionCount = objRow[convzx_TobeStudiedProblem.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TobeStudiedProblem.VersionCount].ToString().Trim()); //版本统计
objvzx_TobeStudiedProblemEN.IsSubmit = TransNullToBool(objRow[convzx_TobeStudiedProblem.IsSubmit].ToString().Trim()); //是否提交
objvzx_TobeStudiedProblemEN.ProblemId = objRow[convzx_TobeStudiedProblem.ProblemId].ToString().Trim(); //问题Id
objvzx_TobeStudiedProblemEN.ProblemTitle = objRow[convzx_TobeStudiedProblem.ProblemTitle] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.ProblemTitle].ToString().Trim(); //问题标题
objvzx_TobeStudiedProblemEN.ProblemContent = objRow[convzx_TobeStudiedProblem.ProblemContent] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.ProblemContent].ToString().Trim(); //问题内容
objvzx_TobeStudiedProblemEN.ProblemDate = objRow[convzx_TobeStudiedProblem.ProblemDate] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.ProblemDate].ToString().Trim(); //问题日期
objvzx_TobeStudiedProblemEN.UpdDate = objRow[convzx_TobeStudiedProblem.UpdDate] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.UpdDate].ToString().Trim(); //修改日期
objvzx_TobeStudiedProblemEN.UpdUser = objRow[convzx_TobeStudiedProblem.UpdUser] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.UpdUser].ToString().Trim(); //修改人
objvzx_TobeStudiedProblemEN.Year = objRow[convzx_TobeStudiedProblem.Year] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.Year].ToString().Trim(); //年
objvzx_TobeStudiedProblemEN.Month = objRow[convzx_TobeStudiedProblem.Month] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.Month].ToString().Trim(); //月
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvzx_TobeStudiedProblemDA: GetObjByDataRowvzx_TobeStudiedProblem)", objException.Message));
}
objvzx_TobeStudiedProblemEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvzx_TobeStudiedProblemEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvzx_TobeStudiedProblemEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvzx_TobeStudiedProblemEN objvzx_TobeStudiedProblemEN = new clsvzx_TobeStudiedProblemEN();
try
{
objvzx_TobeStudiedProblemEN.GroupTextId = objRow[convzx_TobeStudiedProblem.GroupTextId] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.GroupTextId].ToString().Trim(); //小组Id
objvzx_TobeStudiedProblemEN.GroupTextName = objRow[convzx_TobeStudiedProblem.GroupTextName] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.GroupTextName].ToString().Trim(); //小组名称
objvzx_TobeStudiedProblemEN.IdCurrEduCls = objRow[convzx_TobeStudiedProblem.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TobeStudiedProblemEN.zxShareId = objRow[convzx_TobeStudiedProblem.zxShareId] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.zxShareId].ToString().Trim(); //分享Id
objvzx_TobeStudiedProblemEN.Memo = objRow[convzx_TobeStudiedProblem.Memo] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.Memo].ToString().Trim(); //备注
objvzx_TobeStudiedProblemEN.Participant = objRow[convzx_TobeStudiedProblem.Participant] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.Participant].ToString().Trim(); //参与者
objvzx_TobeStudiedProblemEN.VersionCount = objRow[convzx_TobeStudiedProblem.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TobeStudiedProblem.VersionCount].ToString().Trim()); //版本统计
objvzx_TobeStudiedProblemEN.IsSubmit = TransNullToBool(objRow[convzx_TobeStudiedProblem.IsSubmit].ToString().Trim()); //是否提交
objvzx_TobeStudiedProblemEN.ProblemId = objRow[convzx_TobeStudiedProblem.ProblemId].ToString().Trim(); //问题Id
objvzx_TobeStudiedProblemEN.ProblemTitle = objRow[convzx_TobeStudiedProblem.ProblemTitle] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.ProblemTitle].ToString().Trim(); //问题标题
objvzx_TobeStudiedProblemEN.ProblemContent = objRow[convzx_TobeStudiedProblem.ProblemContent] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.ProblemContent].ToString().Trim(); //问题内容
objvzx_TobeStudiedProblemEN.ProblemDate = objRow[convzx_TobeStudiedProblem.ProblemDate] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.ProblemDate].ToString().Trim(); //问题日期
objvzx_TobeStudiedProblemEN.UpdDate = objRow[convzx_TobeStudiedProblem.UpdDate] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.UpdDate].ToString().Trim(); //修改日期
objvzx_TobeStudiedProblemEN.UpdUser = objRow[convzx_TobeStudiedProblem.UpdUser] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.UpdUser].ToString().Trim(); //修改人
objvzx_TobeStudiedProblemEN.Year = objRow[convzx_TobeStudiedProblem.Year] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.Year].ToString().Trim(); //年
objvzx_TobeStudiedProblemEN.Month = objRow[convzx_TobeStudiedProblem.Month] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.Month].ToString().Trim(); //月
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvzx_TobeStudiedProblemDA: GetObjByDataRow)", objException.Message));
}
objvzx_TobeStudiedProblemEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvzx_TobeStudiedProblemEN;
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
objSQL = clsvzx_TobeStudiedProblemDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvzx_TobeStudiedProblemEN._CurrTabName, convzx_TobeStudiedProblem.ProblemId, 10, "");
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
objSQL = clsvzx_TobeStudiedProblemDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvzx_TobeStudiedProblemEN._CurrTabName, convzx_TobeStudiedProblem.ProblemId, 10, strPrefix);
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
 objSQL = clsvzx_TobeStudiedProblemDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select ProblemId from vzx_TobeStudiedProblem where " + strCondition;
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
 objSQL = clsvzx_TobeStudiedProblemDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select ProblemId from vzx_TobeStudiedProblem where " + strCondition;
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
 objSQL = clsvzx_TobeStudiedProblemDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vzx_TobeStudiedProblem", "ProblemId = " + "'"+ strProblemId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvzx_TobeStudiedProblemDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TobeStudiedProblemDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vzx_TobeStudiedProblem", strCondition))
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
objSQL = clsvzx_TobeStudiedProblemDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vzx_TobeStudiedProblem");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvzx_TobeStudiedProblemENS">源对象</param>
 /// <param name = "objvzx_TobeStudiedProblemENT">目标对象</param>
public void CopyTo(clsvzx_TobeStudiedProblemEN objvzx_TobeStudiedProblemENS, clsvzx_TobeStudiedProblemEN objvzx_TobeStudiedProblemENT)
{
objvzx_TobeStudiedProblemENT.GroupTextId = objvzx_TobeStudiedProblemENS.GroupTextId; //小组Id
objvzx_TobeStudiedProblemENT.GroupTextName = objvzx_TobeStudiedProblemENS.GroupTextName; //小组名称
objvzx_TobeStudiedProblemENT.IdCurrEduCls = objvzx_TobeStudiedProblemENS.IdCurrEduCls; //教学班流水号
objvzx_TobeStudiedProblemENT.zxShareId = objvzx_TobeStudiedProblemENS.zxShareId; //分享Id
objvzx_TobeStudiedProblemENT.Memo = objvzx_TobeStudiedProblemENS.Memo; //备注
objvzx_TobeStudiedProblemENT.Participant = objvzx_TobeStudiedProblemENS.Participant; //参与者
objvzx_TobeStudiedProblemENT.VersionCount = objvzx_TobeStudiedProblemENS.VersionCount; //版本统计
objvzx_TobeStudiedProblemENT.IsSubmit = objvzx_TobeStudiedProblemENS.IsSubmit; //是否提交
objvzx_TobeStudiedProblemENT.ProblemId = objvzx_TobeStudiedProblemENS.ProblemId; //问题Id
objvzx_TobeStudiedProblemENT.ProblemTitle = objvzx_TobeStudiedProblemENS.ProblemTitle; //问题标题
objvzx_TobeStudiedProblemENT.ProblemContent = objvzx_TobeStudiedProblemENS.ProblemContent; //问题内容
objvzx_TobeStudiedProblemENT.ProblemDate = objvzx_TobeStudiedProblemENS.ProblemDate; //问题日期
objvzx_TobeStudiedProblemENT.UpdDate = objvzx_TobeStudiedProblemENS.UpdDate; //修改日期
objvzx_TobeStudiedProblemENT.UpdUser = objvzx_TobeStudiedProblemENS.UpdUser; //修改人
objvzx_TobeStudiedProblemENT.Year = objvzx_TobeStudiedProblemENS.Year; //年
objvzx_TobeStudiedProblemENT.Month = objvzx_TobeStudiedProblemENS.Month; //月
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvzx_TobeStudiedProblemEN objvzx_TobeStudiedProblemEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvzx_TobeStudiedProblemEN.GroupTextId, 8, convzx_TobeStudiedProblem.GroupTextId);
clsCheckSql.CheckFieldLen(objvzx_TobeStudiedProblemEN.GroupTextName, 2000, convzx_TobeStudiedProblem.GroupTextName);
clsCheckSql.CheckFieldLen(objvzx_TobeStudiedProblemEN.IdCurrEduCls, 8, convzx_TobeStudiedProblem.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objvzx_TobeStudiedProblemEN.zxShareId, 2, convzx_TobeStudiedProblem.zxShareId);
clsCheckSql.CheckFieldLen(objvzx_TobeStudiedProblemEN.Memo, 1000, convzx_TobeStudiedProblem.Memo);
clsCheckSql.CheckFieldLen(objvzx_TobeStudiedProblemEN.Participant, 500, convzx_TobeStudiedProblem.Participant);
clsCheckSql.CheckFieldLen(objvzx_TobeStudiedProblemEN.ProblemId, 10, convzx_TobeStudiedProblem.ProblemId);
clsCheckSql.CheckFieldLen(objvzx_TobeStudiedProblemEN.ProblemTitle, 1000, convzx_TobeStudiedProblem.ProblemTitle);
clsCheckSql.CheckFieldLen(objvzx_TobeStudiedProblemEN.ProblemDate, 20, convzx_TobeStudiedProblem.ProblemDate);
clsCheckSql.CheckFieldLen(objvzx_TobeStudiedProblemEN.UpdDate, 20, convzx_TobeStudiedProblem.UpdDate);
clsCheckSql.CheckFieldLen(objvzx_TobeStudiedProblemEN.UpdUser, 20, convzx_TobeStudiedProblem.UpdUser);
clsCheckSql.CheckFieldLen(objvzx_TobeStudiedProblemEN.Year, 4, convzx_TobeStudiedProblem.Year);
clsCheckSql.CheckFieldLen(objvzx_TobeStudiedProblemEN.Month, 2, convzx_TobeStudiedProblem.Month);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvzx_TobeStudiedProblemEN.GroupTextId, convzx_TobeStudiedProblem.GroupTextId);
clsCheckSql.CheckSqlInjection4Field(objvzx_TobeStudiedProblemEN.GroupTextName, convzx_TobeStudiedProblem.GroupTextName);
clsCheckSql.CheckSqlInjection4Field(objvzx_TobeStudiedProblemEN.IdCurrEduCls, convzx_TobeStudiedProblem.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objvzx_TobeStudiedProblemEN.zxShareId, convzx_TobeStudiedProblem.zxShareId);
clsCheckSql.CheckSqlInjection4Field(objvzx_TobeStudiedProblemEN.Memo, convzx_TobeStudiedProblem.Memo);
clsCheckSql.CheckSqlInjection4Field(objvzx_TobeStudiedProblemEN.Participant, convzx_TobeStudiedProblem.Participant);
clsCheckSql.CheckSqlInjection4Field(objvzx_TobeStudiedProblemEN.ProblemId, convzx_TobeStudiedProblem.ProblemId);
clsCheckSql.CheckSqlInjection4Field(objvzx_TobeStudiedProblemEN.ProblemTitle, convzx_TobeStudiedProblem.ProblemTitle);
clsCheckSql.CheckSqlInjection4Field(objvzx_TobeStudiedProblemEN.ProblemDate, convzx_TobeStudiedProblem.ProblemDate);
clsCheckSql.CheckSqlInjection4Field(objvzx_TobeStudiedProblemEN.UpdDate, convzx_TobeStudiedProblem.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvzx_TobeStudiedProblemEN.UpdUser, convzx_TobeStudiedProblem.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvzx_TobeStudiedProblemEN.Year, convzx_TobeStudiedProblem.Year);
clsCheckSql.CheckSqlInjection4Field(objvzx_TobeStudiedProblemEN.Month, convzx_TobeStudiedProblem.Month);
//检查外键字段长度
 objvzx_TobeStudiedProblemEN._IsCheckProperty = true;
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
 objSQL = clsvzx_TobeStudiedProblemDA.GetSpecSQLObj();
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
 objSQL = clsvzx_TobeStudiedProblemDA.GetSpecSQLObj();
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
 objSQL = clsvzx_TobeStudiedProblemDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvzx_TobeStudiedProblemEN._CurrTabName);
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
 objSQL = clsvzx_TobeStudiedProblemDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvzx_TobeStudiedProblemEN._CurrTabName, strCondition);
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
 objSQL = clsvzx_TobeStudiedProblemDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}