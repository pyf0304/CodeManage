
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMicroteachAppraiseDA
 表名:vMicroteachAppraise(01120265)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:47:15
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:微格教学评议(MicroTeachSenate)
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
 /// 微格案例评议信息表视图(vMicroteachAppraise)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvMicroteachAppraiseDA : clsCommBase4DA
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
 return clsvMicroteachAppraiseEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvMicroteachAppraiseEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvMicroteachAppraiseEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvMicroteachAppraiseEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvMicroteachAppraiseEN._ConnectString);
 }
 return objSQL;
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvMicroteachAppraiseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachAppraiseDA.GetSpecSQLObj();
strSQL = "Select * from vMicroteachAppraise where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vMicroteachAppraise(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvMicroteachAppraiseDA: GetDataTable_vMicroteachAppraise)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachAppraiseDA.GetSpecSQLObj();
strSQL = "Select * from vMicroteachAppraise where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvMicroteachAppraiseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachAppraiseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvMicroteachAppraiseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachAppraiseDA.GetSpecSQLObj();
strSQL = "Select * from vMicroteachAppraise where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvMicroteachAppraiseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachAppraiseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvMicroteachAppraiseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachAppraiseDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vMicroteachAppraise where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vMicroteachAppraise where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvMicroteachAppraiseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachAppraiseDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vMicroteachAppraise where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvMicroteachAppraiseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachAppraiseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vMicroteachAppraise.* from vMicroteachAppraise Left Join {1} on {2} where {3} and vMicroteachAppraise.IdMicroteachAppraise not in (Select top {5} vMicroteachAppraise.IdMicroteachAppraise from vMicroteachAppraise Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vMicroteachAppraise where {1} and IdMicroteachAppraise not in (Select top {2} IdMicroteachAppraise from vMicroteachAppraise where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vMicroteachAppraise where {1} and IdMicroteachAppraise not in (Select top {3} IdMicroteachAppraise from vMicroteachAppraise where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvMicroteachAppraiseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachAppraiseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vMicroteachAppraise.* from vMicroteachAppraise Left Join {1} on {2} where {3} and vMicroteachAppraise.IdMicroteachAppraise not in (Select top {5} vMicroteachAppraise.IdMicroteachAppraise from vMicroteachAppraise Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vMicroteachAppraise where {1} and IdMicroteachAppraise not in (Select top {2} IdMicroteachAppraise from vMicroteachAppraise where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vMicroteachAppraise where {1} and IdMicroteachAppraise not in (Select top {3} IdMicroteachAppraise from vMicroteachAppraise where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvMicroteachAppraiseEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvMicroteachAppraiseDA:GetObjLst)", objException.Message));
}
List<clsvMicroteachAppraiseEN> arrObjLst = new List<clsvMicroteachAppraiseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachAppraiseDA.GetSpecSQLObj();
strSQL = "Select * from vMicroteachAppraise where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachAppraiseEN objvMicroteachAppraiseEN = new clsvMicroteachAppraiseEN();
try
{
objvMicroteachAppraiseEN.IdMicroteachAppraise = TransNullToInt(objRow[convMicroteachAppraise.IdMicroteachAppraise].ToString().Trim()); //评议流水号
objvMicroteachAppraiseEN.FuncModuleId = objRow[convMicroteachAppraise.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachAppraiseEN.FuncModuleName = objRow[convMicroteachAppraise.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachAppraise.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachAppraiseEN.IdMicroteachCase = objRow[convMicroteachAppraise.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachAppraiseEN.MicroteachCaseID = objRow[convMicroteachAppraise.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachAppraiseEN.MicroteachCaseName = objRow[convMicroteachAppraise.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachAppraiseEN.IdAppraiseType = objRow[convMicroteachAppraise.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvMicroteachAppraiseEN.AppraiseTypeName = objRow[convMicroteachAppraise.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvMicroteachAppraiseEN.OwnerId = objRow[convMicroteachAppraise.OwnerId] == DBNull.Value ? null : objRow[convMicroteachAppraise.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachAppraiseEN.OwnerName = objRow[convMicroteachAppraise.OwnerName] == DBNull.Value ? null : objRow[convMicroteachAppraise.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachAppraiseEN.UserId = objRow[convMicroteachAppraise.UserId].ToString().Trim(); //用户ID
objvMicroteachAppraiseEN.UserName = objRow[convMicroteachAppraise.UserName] == DBNull.Value ? null : objRow[convMicroteachAppraise.UserName].ToString().Trim(); //用户名
objvMicroteachAppraiseEN.AppraiseTheme = objRow[convMicroteachAppraise.AppraiseTheme] == DBNull.Value ? null : objRow[convMicroteachAppraise.AppraiseTheme].ToString().Trim(); //评议主题
objvMicroteachAppraiseEN.AppraiseContent = objRow[convMicroteachAppraise.AppraiseContent] == DBNull.Value ? null : objRow[convMicroteachAppraise.AppraiseContent].ToString().Trim(); //评议内容
objvMicroteachAppraiseEN.AppraiseDate = objRow[convMicroteachAppraise.AppraiseDate] == DBNull.Value ? null : objRow[convMicroteachAppraise.AppraiseDate].ToString().Trim(); //评议日期
objvMicroteachAppraiseEN.AppraiseTime = objRow[convMicroteachAppraise.AppraiseTime] == DBNull.Value ? null : objRow[convMicroteachAppraise.AppraiseTime].ToString().Trim(); //评议时间
objvMicroteachAppraiseEN.ExcellentOne = objRow[convMicroteachAppraise.ExcellentOne] == DBNull.Value ? null : objRow[convMicroteachAppraise.ExcellentOne].ToString().Trim(); //优点1
objvMicroteachAppraiseEN.ExcellentTwo = objRow[convMicroteachAppraise.ExcellentTwo] == DBNull.Value ? null : objRow[convMicroteachAppraise.ExcellentTwo].ToString().Trim(); //优点2
objvMicroteachAppraiseEN.SuggestOne = objRow[convMicroteachAppraise.SuggestOne] == DBNull.Value ? null : objRow[convMicroteachAppraise.SuggestOne].ToString().Trim(); //建议1
objvMicroteachAppraiseEN.SuggestTwo = objRow[convMicroteachAppraise.SuggestTwo] == DBNull.Value ? null : objRow[convMicroteachAppraise.SuggestTwo].ToString().Trim(); //建议2
objvMicroteachAppraiseEN.MicroteachAppriseScore = objRow[convMicroteachAppraise.MicroteachAppriseScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convMicroteachAppraise.MicroteachAppriseScore].ToString().Trim()); //打分
objvMicroteachAppraiseEN.BrowseCount = objRow[convMicroteachAppraise.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachAppraise.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachAppraiseEN.CollegeID = objRow[convMicroteachAppraise.CollegeID] == DBNull.Value ? null : objRow[convMicroteachAppraise.CollegeID].ToString().Trim(); //学院ID
objvMicroteachAppraiseEN.CollegeName = objRow[convMicroteachAppraise.CollegeName] == DBNull.Value ? null : objRow[convMicroteachAppraise.CollegeName].ToString().Trim(); //学院名称
objvMicroteachAppraiseEN.VideoStopTime = objRow[convMicroteachAppraise.VideoStopTime] == DBNull.Value ? null : objRow[convMicroteachAppraise.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objvMicroteachAppraiseEN.IsElite = TransNullToBool(objRow[convMicroteachAppraise.IsElite].ToString().Trim()); //精华标志
objvMicroteachAppraiseEN.IsVisual = TransNullToBool(objRow[convMicroteachAppraise.IsVisual].ToString().Trim()); //隐藏标志
objvMicroteachAppraiseEN.MicroteachCaseDate = objRow[convMicroteachAppraise.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachAppraise.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachAppraiseEN.OwnerNameWithId = objRow[convMicroteachAppraise.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachAppraise.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMicroteachAppraiseEN.UserNameWithUserId = objRow[convMicroteachAppraise.UserNameWithUserId] == DBNull.Value ? null : objRow[convMicroteachAppraise.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvMicroteachAppraiseEN.BrowseCount4Case = objRow[convMicroteachAppraise.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachAppraise.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachAppraiseEN.IdXzCollege = objRow[convMicroteachAppraise.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachAppraise.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachAppraiseEN.CollegeNameA = objRow[convMicroteachAppraise.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachAppraise.CollegeNameA].ToString().Trim(); //学院名称简写
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvMicroteachAppraiseDA: GetObjLst)", objException.Message));
}
objvMicroteachAppraiseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvMicroteachAppraiseEN);
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
public List<clsvMicroteachAppraiseEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvMicroteachAppraiseDA:GetObjLstByTabName)", objException.Message));
}
List<clsvMicroteachAppraiseEN> arrObjLst = new List<clsvMicroteachAppraiseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachAppraiseDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachAppraiseEN objvMicroteachAppraiseEN = new clsvMicroteachAppraiseEN();
try
{
objvMicroteachAppraiseEN.IdMicroteachAppraise = TransNullToInt(objRow[convMicroteachAppraise.IdMicroteachAppraise].ToString().Trim()); //评议流水号
objvMicroteachAppraiseEN.FuncModuleId = objRow[convMicroteachAppraise.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachAppraiseEN.FuncModuleName = objRow[convMicroteachAppraise.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachAppraise.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachAppraiseEN.IdMicroteachCase = objRow[convMicroteachAppraise.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachAppraiseEN.MicroteachCaseID = objRow[convMicroteachAppraise.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachAppraiseEN.MicroteachCaseName = objRow[convMicroteachAppraise.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachAppraiseEN.IdAppraiseType = objRow[convMicroteachAppraise.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvMicroteachAppraiseEN.AppraiseTypeName = objRow[convMicroteachAppraise.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvMicroteachAppraiseEN.OwnerId = objRow[convMicroteachAppraise.OwnerId] == DBNull.Value ? null : objRow[convMicroteachAppraise.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachAppraiseEN.OwnerName = objRow[convMicroteachAppraise.OwnerName] == DBNull.Value ? null : objRow[convMicroteachAppraise.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachAppraiseEN.UserId = objRow[convMicroteachAppraise.UserId].ToString().Trim(); //用户ID
objvMicroteachAppraiseEN.UserName = objRow[convMicroteachAppraise.UserName] == DBNull.Value ? null : objRow[convMicroteachAppraise.UserName].ToString().Trim(); //用户名
objvMicroteachAppraiseEN.AppraiseTheme = objRow[convMicroteachAppraise.AppraiseTheme] == DBNull.Value ? null : objRow[convMicroteachAppraise.AppraiseTheme].ToString().Trim(); //评议主题
objvMicroteachAppraiseEN.AppraiseContent = objRow[convMicroteachAppraise.AppraiseContent] == DBNull.Value ? null : objRow[convMicroteachAppraise.AppraiseContent].ToString().Trim(); //评议内容
objvMicroteachAppraiseEN.AppraiseDate = objRow[convMicroteachAppraise.AppraiseDate] == DBNull.Value ? null : objRow[convMicroteachAppraise.AppraiseDate].ToString().Trim(); //评议日期
objvMicroteachAppraiseEN.AppraiseTime = objRow[convMicroteachAppraise.AppraiseTime] == DBNull.Value ? null : objRow[convMicroteachAppraise.AppraiseTime].ToString().Trim(); //评议时间
objvMicroteachAppraiseEN.ExcellentOne = objRow[convMicroteachAppraise.ExcellentOne] == DBNull.Value ? null : objRow[convMicroteachAppraise.ExcellentOne].ToString().Trim(); //优点1
objvMicroteachAppraiseEN.ExcellentTwo = objRow[convMicroteachAppraise.ExcellentTwo] == DBNull.Value ? null : objRow[convMicroteachAppraise.ExcellentTwo].ToString().Trim(); //优点2
objvMicroteachAppraiseEN.SuggestOne = objRow[convMicroteachAppraise.SuggestOne] == DBNull.Value ? null : objRow[convMicroteachAppraise.SuggestOne].ToString().Trim(); //建议1
objvMicroteachAppraiseEN.SuggestTwo = objRow[convMicroteachAppraise.SuggestTwo] == DBNull.Value ? null : objRow[convMicroteachAppraise.SuggestTwo].ToString().Trim(); //建议2
objvMicroteachAppraiseEN.MicroteachAppriseScore = objRow[convMicroteachAppraise.MicroteachAppriseScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convMicroteachAppraise.MicroteachAppriseScore].ToString().Trim()); //打分
objvMicroteachAppraiseEN.BrowseCount = objRow[convMicroteachAppraise.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachAppraise.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachAppraiseEN.CollegeID = objRow[convMicroteachAppraise.CollegeID] == DBNull.Value ? null : objRow[convMicroteachAppraise.CollegeID].ToString().Trim(); //学院ID
objvMicroteachAppraiseEN.CollegeName = objRow[convMicroteachAppraise.CollegeName] == DBNull.Value ? null : objRow[convMicroteachAppraise.CollegeName].ToString().Trim(); //学院名称
objvMicroteachAppraiseEN.VideoStopTime = objRow[convMicroteachAppraise.VideoStopTime] == DBNull.Value ? null : objRow[convMicroteachAppraise.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objvMicroteachAppraiseEN.IsElite = TransNullToBool(objRow[convMicroteachAppraise.IsElite].ToString().Trim()); //精华标志
objvMicroteachAppraiseEN.IsVisual = TransNullToBool(objRow[convMicroteachAppraise.IsVisual].ToString().Trim()); //隐藏标志
objvMicroteachAppraiseEN.MicroteachCaseDate = objRow[convMicroteachAppraise.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachAppraise.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachAppraiseEN.OwnerNameWithId = objRow[convMicroteachAppraise.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachAppraise.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMicroteachAppraiseEN.UserNameWithUserId = objRow[convMicroteachAppraise.UserNameWithUserId] == DBNull.Value ? null : objRow[convMicroteachAppraise.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvMicroteachAppraiseEN.BrowseCount4Case = objRow[convMicroteachAppraise.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachAppraise.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachAppraiseEN.IdXzCollege = objRow[convMicroteachAppraise.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachAppraise.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachAppraiseEN.CollegeNameA = objRow[convMicroteachAppraise.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachAppraise.CollegeNameA].ToString().Trim(); //学院名称简写
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvMicroteachAppraiseDA: GetObjLst)", objException.Message));
}
objvMicroteachAppraiseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvMicroteachAppraiseEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvMicroteachAppraiseEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvMicroteachAppraise(ref clsvMicroteachAppraiseEN objvMicroteachAppraiseEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachAppraiseDA.GetSpecSQLObj();
strSQL = "Select * from vMicroteachAppraise where IdMicroteachAppraise = " + ""+ objvMicroteachAppraiseEN.IdMicroteachAppraise+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvMicroteachAppraiseEN.IdMicroteachAppraise = TransNullToInt(objDT.Rows[0][convMicroteachAppraise.IdMicroteachAppraise].ToString().Trim()); //评议流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvMicroteachAppraiseEN.FuncModuleId = objDT.Rows[0][convMicroteachAppraise.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvMicroteachAppraiseEN.FuncModuleName = objDT.Rows[0][convMicroteachAppraise.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvMicroteachAppraiseEN.IdMicroteachCase = objDT.Rows[0][convMicroteachAppraise.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachAppraiseEN.MicroteachCaseID = objDT.Rows[0][convMicroteachAppraise.MicroteachCaseID].ToString().Trim(); //微格教学案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachAppraiseEN.MicroteachCaseName = objDT.Rows[0][convMicroteachAppraise.MicroteachCaseName].ToString().Trim(); //微格教学案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMicroteachAppraiseEN.IdAppraiseType = objDT.Rows[0][convMicroteachAppraise.IdAppraiseType].ToString().Trim(); //评议类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachAppraiseEN.AppraiseTypeName = objDT.Rows[0][convMicroteachAppraise.AppraiseTypeName].ToString().Trim(); //评议类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachAppraiseEN.OwnerId = objDT.Rows[0][convMicroteachAppraise.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvMicroteachAppraiseEN.OwnerName = objDT.Rows[0][convMicroteachAppraise.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvMicroteachAppraiseEN.UserId = objDT.Rows[0][convMicroteachAppraise.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvMicroteachAppraiseEN.UserName = objDT.Rows[0][convMicroteachAppraise.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvMicroteachAppraiseEN.AppraiseTheme = objDT.Rows[0][convMicroteachAppraise.AppraiseTheme].ToString().Trim(); //评议主题(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachAppraiseEN.AppraiseContent = objDT.Rows[0][convMicroteachAppraise.AppraiseContent].ToString().Trim(); //评议内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvMicroteachAppraiseEN.AppraiseDate = objDT.Rows[0][convMicroteachAppraise.AppraiseDate].ToString().Trim(); //评议日期(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachAppraiseEN.AppraiseTime = objDT.Rows[0][convMicroteachAppraise.AppraiseTime].ToString().Trim(); //评议时间(字段类型:char,字段长度:6,是否可空:True)
 objvMicroteachAppraiseEN.ExcellentOne = objDT.Rows[0][convMicroteachAppraise.ExcellentOne].ToString().Trim(); //优点1(字段类型:varchar,字段长度:1000,是否可空:True)
 objvMicroteachAppraiseEN.ExcellentTwo = objDT.Rows[0][convMicroteachAppraise.ExcellentTwo].ToString().Trim(); //优点2(字段类型:varchar,字段长度:1000,是否可空:True)
 objvMicroteachAppraiseEN.SuggestOne = objDT.Rows[0][convMicroteachAppraise.SuggestOne].ToString().Trim(); //建议1(字段类型:varchar,字段长度:1000,是否可空:True)
 objvMicroteachAppraiseEN.SuggestTwo = objDT.Rows[0][convMicroteachAppraise.SuggestTwo].ToString().Trim(); //建议2(字段类型:varchar,字段长度:1000,是否可空:True)
 objvMicroteachAppraiseEN.MicroteachAppriseScore = TransNullToFloat(objDT.Rows[0][convMicroteachAppraise.MicroteachAppriseScore].ToString().Trim()); //打分(字段类型:float,字段长度:8,是否可空:True)
 objvMicroteachAppraiseEN.BrowseCount = TransNullToInt(objDT.Rows[0][convMicroteachAppraise.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvMicroteachAppraiseEN.CollegeID = objDT.Rows[0][convMicroteachAppraise.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvMicroteachAppraiseEN.CollegeName = objDT.Rows[0][convMicroteachAppraise.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMicroteachAppraiseEN.VideoStopTime = objDT.Rows[0][convMicroteachAppraise.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间(字段类型:varchar,字段长度:48,是否可空:True)
 objvMicroteachAppraiseEN.IsElite = TransNullToBool(objDT.Rows[0][convMicroteachAppraise.IsElite].ToString().Trim()); //精华标志(字段类型:bit,字段长度:1,是否可空:False)
 objvMicroteachAppraiseEN.IsVisual = TransNullToBool(objDT.Rows[0][convMicroteachAppraise.IsVisual].ToString().Trim()); //隐藏标志(字段类型:bit,字段长度:1,是否可空:False)
 objvMicroteachAppraiseEN.MicroteachCaseDate = objDT.Rows[0][convMicroteachAppraise.MicroteachCaseDate].ToString().Trim(); //微格教学日期(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachAppraiseEN.OwnerNameWithId = objDT.Rows[0][convMicroteachAppraise.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
 objvMicroteachAppraiseEN.UserNameWithUserId = objDT.Rows[0][convMicroteachAppraise.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId(字段类型:varchar,字段长度:51,是否可空:False)
 objvMicroteachAppraiseEN.BrowseCount4Case = TransNullToInt(objDT.Rows[0][convMicroteachAppraise.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvMicroteachAppraiseEN.IdXzCollege = objDT.Rows[0][convMicroteachAppraise.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvMicroteachAppraiseEN.CollegeNameA = objDT.Rows[0][convMicroteachAppraise.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvMicroteachAppraiseDA: GetvMicroteachAppraise)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdMicroteachAppraise">表关键字</param>
 /// <returns>表对象</returns>
public clsvMicroteachAppraiseEN GetObjByIdMicroteachAppraise(long lngIdMicroteachAppraise)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachAppraiseDA.GetSpecSQLObj();
strSQL = "Select * from vMicroteachAppraise where IdMicroteachAppraise = " + ""+ lngIdMicroteachAppraise+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvMicroteachAppraiseEN objvMicroteachAppraiseEN = new clsvMicroteachAppraiseEN();
try
{
 objvMicroteachAppraiseEN.IdMicroteachAppraise = Int32.Parse(objRow[convMicroteachAppraise.IdMicroteachAppraise].ToString().Trim()); //评议流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvMicroteachAppraiseEN.FuncModuleId = objRow[convMicroteachAppraise.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvMicroteachAppraiseEN.FuncModuleName = objRow[convMicroteachAppraise.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachAppraise.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvMicroteachAppraiseEN.IdMicroteachCase = objRow[convMicroteachAppraise.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachAppraiseEN.MicroteachCaseID = objRow[convMicroteachAppraise.MicroteachCaseID].ToString().Trim(); //微格教学案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachAppraiseEN.MicroteachCaseName = objRow[convMicroteachAppraise.MicroteachCaseName].ToString().Trim(); //微格教学案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMicroteachAppraiseEN.IdAppraiseType = objRow[convMicroteachAppraise.IdAppraiseType].ToString().Trim(); //评议类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachAppraiseEN.AppraiseTypeName = objRow[convMicroteachAppraise.AppraiseTypeName].ToString().Trim(); //评议类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachAppraiseEN.OwnerId = objRow[convMicroteachAppraise.OwnerId] == DBNull.Value ? null : objRow[convMicroteachAppraise.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvMicroteachAppraiseEN.OwnerName = objRow[convMicroteachAppraise.OwnerName] == DBNull.Value ? null : objRow[convMicroteachAppraise.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvMicroteachAppraiseEN.UserId = objRow[convMicroteachAppraise.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvMicroteachAppraiseEN.UserName = objRow[convMicroteachAppraise.UserName] == DBNull.Value ? null : objRow[convMicroteachAppraise.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvMicroteachAppraiseEN.AppraiseTheme = objRow[convMicroteachAppraise.AppraiseTheme] == DBNull.Value ? null : objRow[convMicroteachAppraise.AppraiseTheme].ToString().Trim(); //评议主题(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachAppraiseEN.AppraiseContent = objRow[convMicroteachAppraise.AppraiseContent] == DBNull.Value ? null : objRow[convMicroteachAppraise.AppraiseContent].ToString().Trim(); //评议内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvMicroteachAppraiseEN.AppraiseDate = objRow[convMicroteachAppraise.AppraiseDate] == DBNull.Value ? null : objRow[convMicroteachAppraise.AppraiseDate].ToString().Trim(); //评议日期(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachAppraiseEN.AppraiseTime = objRow[convMicroteachAppraise.AppraiseTime] == DBNull.Value ? null : objRow[convMicroteachAppraise.AppraiseTime].ToString().Trim(); //评议时间(字段类型:char,字段长度:6,是否可空:True)
 objvMicroteachAppraiseEN.ExcellentOne = objRow[convMicroteachAppraise.ExcellentOne] == DBNull.Value ? null : objRow[convMicroteachAppraise.ExcellentOne].ToString().Trim(); //优点1(字段类型:varchar,字段长度:1000,是否可空:True)
 objvMicroteachAppraiseEN.ExcellentTwo = objRow[convMicroteachAppraise.ExcellentTwo] == DBNull.Value ? null : objRow[convMicroteachAppraise.ExcellentTwo].ToString().Trim(); //优点2(字段类型:varchar,字段长度:1000,是否可空:True)
 objvMicroteachAppraiseEN.SuggestOne = objRow[convMicroteachAppraise.SuggestOne] == DBNull.Value ? null : objRow[convMicroteachAppraise.SuggestOne].ToString().Trim(); //建议1(字段类型:varchar,字段长度:1000,是否可空:True)
 objvMicroteachAppraiseEN.SuggestTwo = objRow[convMicroteachAppraise.SuggestTwo] == DBNull.Value ? null : objRow[convMicroteachAppraise.SuggestTwo].ToString().Trim(); //建议2(字段类型:varchar,字段长度:1000,是否可空:True)
 objvMicroteachAppraiseEN.MicroteachAppriseScore = objRow[convMicroteachAppraise.MicroteachAppriseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachAppraise.MicroteachAppriseScore].ToString().Trim()); //打分(字段类型:float,字段长度:8,是否可空:True)
 objvMicroteachAppraiseEN.BrowseCount = objRow[convMicroteachAppraise.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachAppraise.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvMicroteachAppraiseEN.CollegeID = objRow[convMicroteachAppraise.CollegeID] == DBNull.Value ? null : objRow[convMicroteachAppraise.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvMicroteachAppraiseEN.CollegeName = objRow[convMicroteachAppraise.CollegeName] == DBNull.Value ? null : objRow[convMicroteachAppraise.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMicroteachAppraiseEN.VideoStopTime = objRow[convMicroteachAppraise.VideoStopTime] == DBNull.Value ? null : objRow[convMicroteachAppraise.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间(字段类型:varchar,字段长度:48,是否可空:True)
 objvMicroteachAppraiseEN.IsElite = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachAppraise.IsElite].ToString().Trim()); //精华标志(字段类型:bit,字段长度:1,是否可空:False)
 objvMicroteachAppraiseEN.IsVisual = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachAppraise.IsVisual].ToString().Trim()); //隐藏标志(字段类型:bit,字段长度:1,是否可空:False)
 objvMicroteachAppraiseEN.MicroteachCaseDate = objRow[convMicroteachAppraise.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachAppraise.MicroteachCaseDate].ToString().Trim(); //微格教学日期(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachAppraiseEN.OwnerNameWithId = objRow[convMicroteachAppraise.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachAppraise.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
 objvMicroteachAppraiseEN.UserNameWithUserId = objRow[convMicroteachAppraise.UserNameWithUserId] == DBNull.Value ? null : objRow[convMicroteachAppraise.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId(字段类型:varchar,字段长度:51,是否可空:False)
 objvMicroteachAppraiseEN.BrowseCount4Case = objRow[convMicroteachAppraise.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachAppraise.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvMicroteachAppraiseEN.IdXzCollege = objRow[convMicroteachAppraise.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachAppraise.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvMicroteachAppraiseEN.CollegeNameA = objRow[convMicroteachAppraise.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachAppraise.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvMicroteachAppraiseDA: GetObjByIdMicroteachAppraise)", objException.Message));
}
return objvMicroteachAppraiseEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvMicroteachAppraiseEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvMicroteachAppraiseDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachAppraiseDA.GetSpecSQLObj();
strSQL = "Select * from vMicroteachAppraise where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvMicroteachAppraiseEN objvMicroteachAppraiseEN = new clsvMicroteachAppraiseEN()
{
IdMicroteachAppraise = TransNullToInt(objRow[convMicroteachAppraise.IdMicroteachAppraise].ToString().Trim()), //评议流水号
FuncModuleId = objRow[convMicroteachAppraise.FuncModuleId].ToString().Trim(), //功能模块Id
FuncModuleName = objRow[convMicroteachAppraise.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachAppraise.FuncModuleName].ToString().Trim(), //功能模块名称
IdMicroteachCase = objRow[convMicroteachAppraise.IdMicroteachCase].ToString().Trim(), //微格教学案例流水号
MicroteachCaseID = objRow[convMicroteachAppraise.MicroteachCaseID].ToString().Trim(), //微格教学案例ID
MicroteachCaseName = objRow[convMicroteachAppraise.MicroteachCaseName].ToString().Trim(), //微格教学案例名称
IdAppraiseType = objRow[convMicroteachAppraise.IdAppraiseType].ToString().Trim(), //评议类型流水号
AppraiseTypeName = objRow[convMicroteachAppraise.AppraiseTypeName].ToString().Trim(), //评议类型名称
OwnerId = objRow[convMicroteachAppraise.OwnerId] == DBNull.Value ? null : objRow[convMicroteachAppraise.OwnerId].ToString().Trim(), //拥有者Id
OwnerName = objRow[convMicroteachAppraise.OwnerName] == DBNull.Value ? null : objRow[convMicroteachAppraise.OwnerName].ToString().Trim(), //拥有者姓名
UserId = objRow[convMicroteachAppraise.UserId].ToString().Trim(), //用户ID
UserName = objRow[convMicroteachAppraise.UserName] == DBNull.Value ? null : objRow[convMicroteachAppraise.UserName].ToString().Trim(), //用户名
AppraiseTheme = objRow[convMicroteachAppraise.AppraiseTheme] == DBNull.Value ? null : objRow[convMicroteachAppraise.AppraiseTheme].ToString().Trim(), //评议主题
AppraiseContent = objRow[convMicroteachAppraise.AppraiseContent] == DBNull.Value ? null : objRow[convMicroteachAppraise.AppraiseContent].ToString().Trim(), //评议内容
AppraiseDate = objRow[convMicroteachAppraise.AppraiseDate] == DBNull.Value ? null : objRow[convMicroteachAppraise.AppraiseDate].ToString().Trim(), //评议日期
AppraiseTime = objRow[convMicroteachAppraise.AppraiseTime] == DBNull.Value ? null : objRow[convMicroteachAppraise.AppraiseTime].ToString().Trim(), //评议时间
ExcellentOne = objRow[convMicroteachAppraise.ExcellentOne] == DBNull.Value ? null : objRow[convMicroteachAppraise.ExcellentOne].ToString().Trim(), //优点1
ExcellentTwo = objRow[convMicroteachAppraise.ExcellentTwo] == DBNull.Value ? null : objRow[convMicroteachAppraise.ExcellentTwo].ToString().Trim(), //优点2
SuggestOne = objRow[convMicroteachAppraise.SuggestOne] == DBNull.Value ? null : objRow[convMicroteachAppraise.SuggestOne].ToString().Trim(), //建议1
SuggestTwo = objRow[convMicroteachAppraise.SuggestTwo] == DBNull.Value ? null : objRow[convMicroteachAppraise.SuggestTwo].ToString().Trim(), //建议2
MicroteachAppriseScore = objRow[convMicroteachAppraise.MicroteachAppriseScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convMicroteachAppraise.MicroteachAppriseScore].ToString().Trim()), //打分
BrowseCount = objRow[convMicroteachAppraise.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachAppraise.BrowseCount].ToString().Trim()), //浏览次数
CollegeID = objRow[convMicroteachAppraise.CollegeID] == DBNull.Value ? null : objRow[convMicroteachAppraise.CollegeID].ToString().Trim(), //学院ID
CollegeName = objRow[convMicroteachAppraise.CollegeName] == DBNull.Value ? null : objRow[convMicroteachAppraise.CollegeName].ToString().Trim(), //学院名称
VideoStopTime = objRow[convMicroteachAppraise.VideoStopTime] == DBNull.Value ? null : objRow[convMicroteachAppraise.VideoStopTime].ToString().Trim(), //公开课案例视频暂停时间
IsElite = TransNullToBool(objRow[convMicroteachAppraise.IsElite].ToString().Trim()), //精华标志
IsVisual = TransNullToBool(objRow[convMicroteachAppraise.IsVisual].ToString().Trim()), //隐藏标志
MicroteachCaseDate = objRow[convMicroteachAppraise.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachAppraise.MicroteachCaseDate].ToString().Trim(), //微格教学日期
OwnerNameWithId = objRow[convMicroteachAppraise.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachAppraise.OwnerNameWithId].ToString().Trim(), //拥有者名称附Id
UserNameWithUserId = objRow[convMicroteachAppraise.UserNameWithUserId] == DBNull.Value ? null : objRow[convMicroteachAppraise.UserNameWithUserId].ToString().Trim(), //UserNameWithUserId
BrowseCount4Case = objRow[convMicroteachAppraise.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachAppraise.BrowseCount4Case].ToString().Trim()), //课例浏览次数
IdXzCollege = objRow[convMicroteachAppraise.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachAppraise.IdXzCollege].ToString().Trim(), //学院流水号
CollegeNameA = objRow[convMicroteachAppraise.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachAppraise.CollegeNameA].ToString().Trim() //学院名称简写
};
objvMicroteachAppraiseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvMicroteachAppraiseEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvMicroteachAppraiseDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvMicroteachAppraiseEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvMicroteachAppraiseEN objvMicroteachAppraiseEN = new clsvMicroteachAppraiseEN();
try
{
objvMicroteachAppraiseEN.IdMicroteachAppraise = TransNullToInt(objRow[convMicroteachAppraise.IdMicroteachAppraise].ToString().Trim()); //评议流水号
objvMicroteachAppraiseEN.FuncModuleId = objRow[convMicroteachAppraise.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachAppraiseEN.FuncModuleName = objRow[convMicroteachAppraise.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachAppraise.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachAppraiseEN.IdMicroteachCase = objRow[convMicroteachAppraise.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachAppraiseEN.MicroteachCaseID = objRow[convMicroteachAppraise.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachAppraiseEN.MicroteachCaseName = objRow[convMicroteachAppraise.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachAppraiseEN.IdAppraiseType = objRow[convMicroteachAppraise.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvMicroteachAppraiseEN.AppraiseTypeName = objRow[convMicroteachAppraise.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvMicroteachAppraiseEN.OwnerId = objRow[convMicroteachAppraise.OwnerId] == DBNull.Value ? null : objRow[convMicroteachAppraise.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachAppraiseEN.OwnerName = objRow[convMicroteachAppraise.OwnerName] == DBNull.Value ? null : objRow[convMicroteachAppraise.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachAppraiseEN.UserId = objRow[convMicroteachAppraise.UserId].ToString().Trim(); //用户ID
objvMicroteachAppraiseEN.UserName = objRow[convMicroteachAppraise.UserName] == DBNull.Value ? null : objRow[convMicroteachAppraise.UserName].ToString().Trim(); //用户名
objvMicroteachAppraiseEN.AppraiseTheme = objRow[convMicroteachAppraise.AppraiseTheme] == DBNull.Value ? null : objRow[convMicroteachAppraise.AppraiseTheme].ToString().Trim(); //评议主题
objvMicroteachAppraiseEN.AppraiseContent = objRow[convMicroteachAppraise.AppraiseContent] == DBNull.Value ? null : objRow[convMicroteachAppraise.AppraiseContent].ToString().Trim(); //评议内容
objvMicroteachAppraiseEN.AppraiseDate = objRow[convMicroteachAppraise.AppraiseDate] == DBNull.Value ? null : objRow[convMicroteachAppraise.AppraiseDate].ToString().Trim(); //评议日期
objvMicroteachAppraiseEN.AppraiseTime = objRow[convMicroteachAppraise.AppraiseTime] == DBNull.Value ? null : objRow[convMicroteachAppraise.AppraiseTime].ToString().Trim(); //评议时间
objvMicroteachAppraiseEN.ExcellentOne = objRow[convMicroteachAppraise.ExcellentOne] == DBNull.Value ? null : objRow[convMicroteachAppraise.ExcellentOne].ToString().Trim(); //优点1
objvMicroteachAppraiseEN.ExcellentTwo = objRow[convMicroteachAppraise.ExcellentTwo] == DBNull.Value ? null : objRow[convMicroteachAppraise.ExcellentTwo].ToString().Trim(); //优点2
objvMicroteachAppraiseEN.SuggestOne = objRow[convMicroteachAppraise.SuggestOne] == DBNull.Value ? null : objRow[convMicroteachAppraise.SuggestOne].ToString().Trim(); //建议1
objvMicroteachAppraiseEN.SuggestTwo = objRow[convMicroteachAppraise.SuggestTwo] == DBNull.Value ? null : objRow[convMicroteachAppraise.SuggestTwo].ToString().Trim(); //建议2
objvMicroteachAppraiseEN.MicroteachAppriseScore = objRow[convMicroteachAppraise.MicroteachAppriseScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convMicroteachAppraise.MicroteachAppriseScore].ToString().Trim()); //打分
objvMicroteachAppraiseEN.BrowseCount = objRow[convMicroteachAppraise.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachAppraise.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachAppraiseEN.CollegeID = objRow[convMicroteachAppraise.CollegeID] == DBNull.Value ? null : objRow[convMicroteachAppraise.CollegeID].ToString().Trim(); //学院ID
objvMicroteachAppraiseEN.CollegeName = objRow[convMicroteachAppraise.CollegeName] == DBNull.Value ? null : objRow[convMicroteachAppraise.CollegeName].ToString().Trim(); //学院名称
objvMicroteachAppraiseEN.VideoStopTime = objRow[convMicroteachAppraise.VideoStopTime] == DBNull.Value ? null : objRow[convMicroteachAppraise.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objvMicroteachAppraiseEN.IsElite = TransNullToBool(objRow[convMicroteachAppraise.IsElite].ToString().Trim()); //精华标志
objvMicroteachAppraiseEN.IsVisual = TransNullToBool(objRow[convMicroteachAppraise.IsVisual].ToString().Trim()); //隐藏标志
objvMicroteachAppraiseEN.MicroteachCaseDate = objRow[convMicroteachAppraise.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachAppraise.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachAppraiseEN.OwnerNameWithId = objRow[convMicroteachAppraise.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachAppraise.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMicroteachAppraiseEN.UserNameWithUserId = objRow[convMicroteachAppraise.UserNameWithUserId] == DBNull.Value ? null : objRow[convMicroteachAppraise.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvMicroteachAppraiseEN.BrowseCount4Case = objRow[convMicroteachAppraise.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachAppraise.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachAppraiseEN.IdXzCollege = objRow[convMicroteachAppraise.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachAppraise.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachAppraiseEN.CollegeNameA = objRow[convMicroteachAppraise.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachAppraise.CollegeNameA].ToString().Trim(); //学院名称简写
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvMicroteachAppraiseDA: GetObjByDataRowvMicroteachAppraise)", objException.Message));
}
objvMicroteachAppraiseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvMicroteachAppraiseEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvMicroteachAppraiseEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvMicroteachAppraiseEN objvMicroteachAppraiseEN = new clsvMicroteachAppraiseEN();
try
{
objvMicroteachAppraiseEN.IdMicroteachAppraise = TransNullToInt(objRow[convMicroteachAppraise.IdMicroteachAppraise].ToString().Trim()); //评议流水号
objvMicroteachAppraiseEN.FuncModuleId = objRow[convMicroteachAppraise.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachAppraiseEN.FuncModuleName = objRow[convMicroteachAppraise.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachAppraise.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachAppraiseEN.IdMicroteachCase = objRow[convMicroteachAppraise.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachAppraiseEN.MicroteachCaseID = objRow[convMicroteachAppraise.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachAppraiseEN.MicroteachCaseName = objRow[convMicroteachAppraise.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachAppraiseEN.IdAppraiseType = objRow[convMicroteachAppraise.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvMicroteachAppraiseEN.AppraiseTypeName = objRow[convMicroteachAppraise.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvMicroteachAppraiseEN.OwnerId = objRow[convMicroteachAppraise.OwnerId] == DBNull.Value ? null : objRow[convMicroteachAppraise.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachAppraiseEN.OwnerName = objRow[convMicroteachAppraise.OwnerName] == DBNull.Value ? null : objRow[convMicroteachAppraise.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachAppraiseEN.UserId = objRow[convMicroteachAppraise.UserId].ToString().Trim(); //用户ID
objvMicroteachAppraiseEN.UserName = objRow[convMicroteachAppraise.UserName] == DBNull.Value ? null : objRow[convMicroteachAppraise.UserName].ToString().Trim(); //用户名
objvMicroteachAppraiseEN.AppraiseTheme = objRow[convMicroteachAppraise.AppraiseTheme] == DBNull.Value ? null : objRow[convMicroteachAppraise.AppraiseTheme].ToString().Trim(); //评议主题
objvMicroteachAppraiseEN.AppraiseContent = objRow[convMicroteachAppraise.AppraiseContent] == DBNull.Value ? null : objRow[convMicroteachAppraise.AppraiseContent].ToString().Trim(); //评议内容
objvMicroteachAppraiseEN.AppraiseDate = objRow[convMicroteachAppraise.AppraiseDate] == DBNull.Value ? null : objRow[convMicroteachAppraise.AppraiseDate].ToString().Trim(); //评议日期
objvMicroteachAppraiseEN.AppraiseTime = objRow[convMicroteachAppraise.AppraiseTime] == DBNull.Value ? null : objRow[convMicroteachAppraise.AppraiseTime].ToString().Trim(); //评议时间
objvMicroteachAppraiseEN.ExcellentOne = objRow[convMicroteachAppraise.ExcellentOne] == DBNull.Value ? null : objRow[convMicroteachAppraise.ExcellentOne].ToString().Trim(); //优点1
objvMicroteachAppraiseEN.ExcellentTwo = objRow[convMicroteachAppraise.ExcellentTwo] == DBNull.Value ? null : objRow[convMicroteachAppraise.ExcellentTwo].ToString().Trim(); //优点2
objvMicroteachAppraiseEN.SuggestOne = objRow[convMicroteachAppraise.SuggestOne] == DBNull.Value ? null : objRow[convMicroteachAppraise.SuggestOne].ToString().Trim(); //建议1
objvMicroteachAppraiseEN.SuggestTwo = objRow[convMicroteachAppraise.SuggestTwo] == DBNull.Value ? null : objRow[convMicroteachAppraise.SuggestTwo].ToString().Trim(); //建议2
objvMicroteachAppraiseEN.MicroteachAppriseScore = objRow[convMicroteachAppraise.MicroteachAppriseScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convMicroteachAppraise.MicroteachAppriseScore].ToString().Trim()); //打分
objvMicroteachAppraiseEN.BrowseCount = objRow[convMicroteachAppraise.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachAppraise.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachAppraiseEN.CollegeID = objRow[convMicroteachAppraise.CollegeID] == DBNull.Value ? null : objRow[convMicroteachAppraise.CollegeID].ToString().Trim(); //学院ID
objvMicroteachAppraiseEN.CollegeName = objRow[convMicroteachAppraise.CollegeName] == DBNull.Value ? null : objRow[convMicroteachAppraise.CollegeName].ToString().Trim(); //学院名称
objvMicroteachAppraiseEN.VideoStopTime = objRow[convMicroteachAppraise.VideoStopTime] == DBNull.Value ? null : objRow[convMicroteachAppraise.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objvMicroteachAppraiseEN.IsElite = TransNullToBool(objRow[convMicroteachAppraise.IsElite].ToString().Trim()); //精华标志
objvMicroteachAppraiseEN.IsVisual = TransNullToBool(objRow[convMicroteachAppraise.IsVisual].ToString().Trim()); //隐藏标志
objvMicroteachAppraiseEN.MicroteachCaseDate = objRow[convMicroteachAppraise.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachAppraise.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachAppraiseEN.OwnerNameWithId = objRow[convMicroteachAppraise.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachAppraise.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMicroteachAppraiseEN.UserNameWithUserId = objRow[convMicroteachAppraise.UserNameWithUserId] == DBNull.Value ? null : objRow[convMicroteachAppraise.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvMicroteachAppraiseEN.BrowseCount4Case = objRow[convMicroteachAppraise.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachAppraise.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachAppraiseEN.IdXzCollege = objRow[convMicroteachAppraise.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachAppraise.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachAppraiseEN.CollegeNameA = objRow[convMicroteachAppraise.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachAppraise.CollegeNameA].ToString().Trim(); //学院名称简写
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvMicroteachAppraiseDA: GetObjByDataRow)", objException.Message));
}
objvMicroteachAppraiseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvMicroteachAppraiseEN;
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
objSQL = clsvMicroteachAppraiseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvMicroteachAppraiseEN._CurrTabName, convMicroteachAppraise.IdMicroteachAppraise, 8, "");
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
objSQL = clsvMicroteachAppraiseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvMicroteachAppraiseEN._CurrTabName, convMicroteachAppraise.IdMicroteachAppraise, 8, strPrefix);
return strMaxValue;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstID)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public long GetFirstID(string strCondition) 
{
string strSQL ;
 System.Data.DataTable objDT ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachAppraiseDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdMicroteachAppraise from vMicroteachAppraise where " + strCondition;
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
return 0;
}
strKeyValue = objDT.Rows[0][0].ToString();
return long.Parse(strKeyValue);
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
 objSQL = clsvMicroteachAppraiseDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdMicroteachAppraise from vMicroteachAppraise where " + strCondition;
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
 /// <param name = "lngIdMicroteachAppraise">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngIdMicroteachAppraise)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachAppraiseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vMicroteachAppraise", "IdMicroteachAppraise = " + ""+ lngIdMicroteachAppraise+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvMicroteachAppraiseDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachAppraiseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vMicroteachAppraise", strCondition))
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
objSQL = clsvMicroteachAppraiseDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vMicroteachAppraise");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvMicroteachAppraiseENS">源对象</param>
 /// <param name = "objvMicroteachAppraiseENT">目标对象</param>
public void CopyTo(clsvMicroteachAppraiseEN objvMicroteachAppraiseENS, clsvMicroteachAppraiseEN objvMicroteachAppraiseENT)
{
objvMicroteachAppraiseENT.IdMicroteachAppraise = objvMicroteachAppraiseENS.IdMicroteachAppraise; //评议流水号
objvMicroteachAppraiseENT.FuncModuleId = objvMicroteachAppraiseENS.FuncModuleId; //功能模块Id
objvMicroteachAppraiseENT.FuncModuleName = objvMicroteachAppraiseENS.FuncModuleName; //功能模块名称
objvMicroteachAppraiseENT.IdMicroteachCase = objvMicroteachAppraiseENS.IdMicroteachCase; //微格教学案例流水号
objvMicroteachAppraiseENT.MicroteachCaseID = objvMicroteachAppraiseENS.MicroteachCaseID; //微格教学案例ID
objvMicroteachAppraiseENT.MicroteachCaseName = objvMicroteachAppraiseENS.MicroteachCaseName; //微格教学案例名称
objvMicroteachAppraiseENT.IdAppraiseType = objvMicroteachAppraiseENS.IdAppraiseType; //评议类型流水号
objvMicroteachAppraiseENT.AppraiseTypeName = objvMicroteachAppraiseENS.AppraiseTypeName; //评议类型名称
objvMicroteachAppraiseENT.OwnerId = objvMicroteachAppraiseENS.OwnerId; //拥有者Id
objvMicroteachAppraiseENT.OwnerName = objvMicroteachAppraiseENS.OwnerName; //拥有者姓名
objvMicroteachAppraiseENT.UserId = objvMicroteachAppraiseENS.UserId; //用户ID
objvMicroteachAppraiseENT.UserName = objvMicroteachAppraiseENS.UserName; //用户名
objvMicroteachAppraiseENT.AppraiseTheme = objvMicroteachAppraiseENS.AppraiseTheme; //评议主题
objvMicroteachAppraiseENT.AppraiseContent = objvMicroteachAppraiseENS.AppraiseContent; //评议内容
objvMicroteachAppraiseENT.AppraiseDate = objvMicroteachAppraiseENS.AppraiseDate; //评议日期
objvMicroteachAppraiseENT.AppraiseTime = objvMicroteachAppraiseENS.AppraiseTime; //评议时间
objvMicroteachAppraiseENT.ExcellentOne = objvMicroteachAppraiseENS.ExcellentOne; //优点1
objvMicroteachAppraiseENT.ExcellentTwo = objvMicroteachAppraiseENS.ExcellentTwo; //优点2
objvMicroteachAppraiseENT.SuggestOne = objvMicroteachAppraiseENS.SuggestOne; //建议1
objvMicroteachAppraiseENT.SuggestTwo = objvMicroteachAppraiseENS.SuggestTwo; //建议2
objvMicroteachAppraiseENT.MicroteachAppriseScore = objvMicroteachAppraiseENS.MicroteachAppriseScore; //打分
objvMicroteachAppraiseENT.BrowseCount = objvMicroteachAppraiseENS.BrowseCount; //浏览次数
objvMicroteachAppraiseENT.CollegeID = objvMicroteachAppraiseENS.CollegeID; //学院ID
objvMicroteachAppraiseENT.CollegeName = objvMicroteachAppraiseENS.CollegeName; //学院名称
objvMicroteachAppraiseENT.VideoStopTime = objvMicroteachAppraiseENS.VideoStopTime; //公开课案例视频暂停时间
objvMicroteachAppraiseENT.IsElite = objvMicroteachAppraiseENS.IsElite; //精华标志
objvMicroteachAppraiseENT.IsVisual = objvMicroteachAppraiseENS.IsVisual; //隐藏标志
objvMicroteachAppraiseENT.MicroteachCaseDate = objvMicroteachAppraiseENS.MicroteachCaseDate; //微格教学日期
objvMicroteachAppraiseENT.OwnerNameWithId = objvMicroteachAppraiseENS.OwnerNameWithId; //拥有者名称附Id
objvMicroteachAppraiseENT.UserNameWithUserId = objvMicroteachAppraiseENS.UserNameWithUserId; //UserNameWithUserId
objvMicroteachAppraiseENT.BrowseCount4Case = objvMicroteachAppraiseENS.BrowseCount4Case; //课例浏览次数
objvMicroteachAppraiseENT.IdXzCollege = objvMicroteachAppraiseENS.IdXzCollege; //学院流水号
objvMicroteachAppraiseENT.CollegeNameA = objvMicroteachAppraiseENS.CollegeNameA; //学院名称简写
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvMicroteachAppraiseEN objvMicroteachAppraiseEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvMicroteachAppraiseEN.FuncModuleId, 4, convMicroteachAppraise.FuncModuleId);
clsCheckSql.CheckFieldLen(objvMicroteachAppraiseEN.FuncModuleName, 30, convMicroteachAppraise.FuncModuleName);
clsCheckSql.CheckFieldLen(objvMicroteachAppraiseEN.IdMicroteachCase, 8, convMicroteachAppraise.IdMicroteachCase);
clsCheckSql.CheckFieldLen(objvMicroteachAppraiseEN.MicroteachCaseID, 8, convMicroteachAppraise.MicroteachCaseID);
clsCheckSql.CheckFieldLen(objvMicroteachAppraiseEN.MicroteachCaseName, 100, convMicroteachAppraise.MicroteachCaseName);
clsCheckSql.CheckFieldLen(objvMicroteachAppraiseEN.IdAppraiseType, 4, convMicroteachAppraise.IdAppraiseType);
clsCheckSql.CheckFieldLen(objvMicroteachAppraiseEN.AppraiseTypeName, 50, convMicroteachAppraise.AppraiseTypeName);
clsCheckSql.CheckFieldLen(objvMicroteachAppraiseEN.OwnerId, 20, convMicroteachAppraise.OwnerId);
clsCheckSql.CheckFieldLen(objvMicroteachAppraiseEN.OwnerName, 30, convMicroteachAppraise.OwnerName);
clsCheckSql.CheckFieldLen(objvMicroteachAppraiseEN.UserId, 18, convMicroteachAppraise.UserId);
clsCheckSql.CheckFieldLen(objvMicroteachAppraiseEN.UserName, 30, convMicroteachAppraise.UserName);
clsCheckSql.CheckFieldLen(objvMicroteachAppraiseEN.AppraiseTheme, 200, convMicroteachAppraise.AppraiseTheme);
clsCheckSql.CheckFieldLen(objvMicroteachAppraiseEN.AppraiseContent, 2000, convMicroteachAppraise.AppraiseContent);
clsCheckSql.CheckFieldLen(objvMicroteachAppraiseEN.AppraiseDate, 8, convMicroteachAppraise.AppraiseDate);
clsCheckSql.CheckFieldLen(objvMicroteachAppraiseEN.AppraiseTime, 6, convMicroteachAppraise.AppraiseTime);
clsCheckSql.CheckFieldLen(objvMicroteachAppraiseEN.ExcellentOne, 1000, convMicroteachAppraise.ExcellentOne);
clsCheckSql.CheckFieldLen(objvMicroteachAppraiseEN.ExcellentTwo, 1000, convMicroteachAppraise.ExcellentTwo);
clsCheckSql.CheckFieldLen(objvMicroteachAppraiseEN.SuggestOne, 1000, convMicroteachAppraise.SuggestOne);
clsCheckSql.CheckFieldLen(objvMicroteachAppraiseEN.SuggestTwo, 1000, convMicroteachAppraise.SuggestTwo);
clsCheckSql.CheckFieldLen(objvMicroteachAppraiseEN.CollegeID, 4, convMicroteachAppraise.CollegeID);
clsCheckSql.CheckFieldLen(objvMicroteachAppraiseEN.CollegeName, 100, convMicroteachAppraise.CollegeName);
clsCheckSql.CheckFieldLen(objvMicroteachAppraiseEN.VideoStopTime, 48, convMicroteachAppraise.VideoStopTime);
clsCheckSql.CheckFieldLen(objvMicroteachAppraiseEN.MicroteachCaseDate, 8, convMicroteachAppraise.MicroteachCaseDate);
clsCheckSql.CheckFieldLen(objvMicroteachAppraiseEN.OwnerNameWithId, 51, convMicroteachAppraise.OwnerNameWithId);
clsCheckSql.CheckFieldLen(objvMicroteachAppraiseEN.UserNameWithUserId, 51, convMicroteachAppraise.UserNameWithUserId);
clsCheckSql.CheckFieldLen(objvMicroteachAppraiseEN.IdXzCollege, 4, convMicroteachAppraise.IdXzCollege);
clsCheckSql.CheckFieldLen(objvMicroteachAppraiseEN.CollegeNameA, 12, convMicroteachAppraise.CollegeNameA);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvMicroteachAppraiseEN.FuncModuleId, convMicroteachAppraise.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachAppraiseEN.FuncModuleName, convMicroteachAppraise.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachAppraiseEN.IdMicroteachCase, convMicroteachAppraise.IdMicroteachCase);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachAppraiseEN.MicroteachCaseID, convMicroteachAppraise.MicroteachCaseID);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachAppraiseEN.MicroteachCaseName, convMicroteachAppraise.MicroteachCaseName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachAppraiseEN.IdAppraiseType, convMicroteachAppraise.IdAppraiseType);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachAppraiseEN.AppraiseTypeName, convMicroteachAppraise.AppraiseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachAppraiseEN.OwnerId, convMicroteachAppraise.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachAppraiseEN.OwnerName, convMicroteachAppraise.OwnerName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachAppraiseEN.UserId, convMicroteachAppraise.UserId);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachAppraiseEN.UserName, convMicroteachAppraise.UserName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachAppraiseEN.AppraiseTheme, convMicroteachAppraise.AppraiseTheme);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachAppraiseEN.AppraiseContent, convMicroteachAppraise.AppraiseContent);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachAppraiseEN.AppraiseDate, convMicroteachAppraise.AppraiseDate);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachAppraiseEN.AppraiseTime, convMicroteachAppraise.AppraiseTime);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachAppraiseEN.ExcellentOne, convMicroteachAppraise.ExcellentOne);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachAppraiseEN.ExcellentTwo, convMicroteachAppraise.ExcellentTwo);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachAppraiseEN.SuggestOne, convMicroteachAppraise.SuggestOne);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachAppraiseEN.SuggestTwo, convMicroteachAppraise.SuggestTwo);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachAppraiseEN.CollegeID, convMicroteachAppraise.CollegeID);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachAppraiseEN.CollegeName, convMicroteachAppraise.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachAppraiseEN.VideoStopTime, convMicroteachAppraise.VideoStopTime);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachAppraiseEN.MicroteachCaseDate, convMicroteachAppraise.MicroteachCaseDate);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachAppraiseEN.OwnerNameWithId, convMicroteachAppraise.OwnerNameWithId);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachAppraiseEN.UserNameWithUserId, convMicroteachAppraise.UserNameWithUserId);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachAppraiseEN.IdXzCollege, convMicroteachAppraise.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachAppraiseEN.CollegeNameA, convMicroteachAppraise.CollegeNameA);
//检查外键字段长度
 objvMicroteachAppraiseEN._IsCheckProperty = true;
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
 objSQL = clsvMicroteachAppraiseDA.GetSpecSQLObj();
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
 objSQL = clsvMicroteachAppraiseDA.GetSpecSQLObj();
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
 objSQL = clsvMicroteachAppraiseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvMicroteachAppraiseEN._CurrTabName);
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
 objSQL = clsvMicroteachAppraiseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvMicroteachAppraiseEN._CurrTabName, strCondition);
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
 objSQL = clsvMicroteachAppraiseDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}