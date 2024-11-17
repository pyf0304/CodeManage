
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUsersDA
 表名:Users(01160002)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 日期:2023/03/11 03:04:10
 生成者:pyf
 生成服务器IP:
 工程名称:简单工程样例(0116)
 CM工程:简单样例后端(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433SimplePrj
 PrjDataBaseId:0111
 模块中文名:基本信息(BaseInfo)
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
using SimplePrj.Entity;

namespace SimplePrj.DAL
{
 /// <summary>
 /// 用户管理(Users)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class clsUsersDA : clsCommBase4DA
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
 public override string _CurrTabName_S
 {
 get
 {
 return clsUsersEN._CurrTabName_S;
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
throw new Exception("请初始化用于记录日志的clsSysParaEN.objLog对象！");
}
if (clsSysParaEN.objErrorLog == null)
{
throw new Exception("请初始化用于记录错误日志的clsSysParaEN.objErrorLog对象！");
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
if (string.IsNullOrEmpty(clsUsersEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsUsersEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsUsersEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsUsersEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strUserId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strUserId)
{
strUserId = strUserId.Replace("'", "''");
if (strUserId.Length > 18)
{
throw new Exception("(errid:Data000001)在表:Users中,检查关键字,长度不正确!(clsUsersDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strUserId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:Users中,关键字不能为空 或 null!(clsUsersDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strUserId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsUsersDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsUsersDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsersDA.GetSpecSQLObj();
strSQL = "Select * from Users where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_Users(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsUsersDA: GetDataTable_Users)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsersDA.GetSpecSQLObj();
strSQL = "Select * from Users where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsUsersDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsersDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsUsersDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsersDA.GetSpecSQLObj();
strSQL = "Select * from Users where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsUsersDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsersDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsUsersDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsersDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from Users where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from Users where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsUsersDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsersDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from Users where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsUsersDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsersDA.GetSpecSQLObj();
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
throw new Exception(string.Format("在带有特殊排序分页查询中，strOrderBy:[{0}]应该有竖线(|)分隔的3部分组成,请检查!(in {1})",
strOrderBy, clsStackTrace.GetCurrClassFunction()));
}
string strTabName = arrPart[0];
string strNewOrderBy = arrPart[1];
string strOnCondition = arrPart[2];
strSQL = string.Format("Select Top {0} Users.* from Users Left Join {1} on {2} where {3} and Users.UserId not in (Select top {5} Users.UserId from Users Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from Users where {1} and UserId not in (Select top {2} UserId from Users where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from Users where {1} and UserId not in (Select top {3} UserId from Users where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsUsersDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsersDA.GetSpecSQLObj();
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
throw new Exception(string.Format("在带有特殊排序分页查询中，strOrderBy:[{0}]应该有竖线(|)分隔的3部分组成,请检查!(in {1})",
strOrderBy, clsStackTrace.GetCurrClassFunction()));
}
string strTabName = arrPart[0];
string strNewOrderBy = arrPart[1];
string strOnCondition = arrPart[2];
strSQL = string.Format("Select Top {0} Users.* from Users Left Join {1} on {2} where {3} and Users.UserId not in (Select top {5} Users.UserId from Users Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from Users where {1} and UserId not in (Select top {2} UserId from Users where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from Users where {1} and UserId not in (Select top {3} UserId from Users where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsUsersEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsUsersDA:GetObjLst)", objException.Message));
}
List<clsUsersEN> arrObjLst = new List<clsUsersEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsersDA.GetSpecSQLObj();
strSQL = "Select * from Users where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUsersEN objUsersEN = new clsUsersEN();
try
{
objUsersEN.UserId = objRow[conUsers.UserId].ToString().Trim(); //用户ID
objUsersEN.UserName = objRow[conUsers.UserName].ToString().Trim(); //用户名
objUsersEN.Password = objRow[conUsers.Password].ToString().Trim(); //密码
objUsersEN.DepartmentId = objRow[conUsers.DepartmentId].ToString().Trim(); //部门ID
objUsersEN.Email = objRow[conUsers.Email].ToString().Trim(); //Email
objUsersEN.IdentityID = objRow[conUsers.IdentityID].ToString().Trim(); //身份编号
objUsersEN.PhoneNumber = objRow[conUsers.PhoneNumber].ToString().Trim(); //手机
objUsersEN.UserStateId = objRow[conUsers.UserStateId].ToString().Trim(); //用户状态Id
objUsersEN.StuTeacherId = objRow[conUsers.StuTeacherId].ToString().Trim(); //学工号
objUsersEN.OrderNum = TransNullToInt(objRow[conUsers.OrderNum].ToString().Trim()); //排序
objUsersEN.UpdDate = objRow[conUsers.UpdDate].ToString().Trim(); //修改日期
objUsersEN.UpdUser = objRow[conUsers.UpdUser].ToString().Trim(); //修改用户
objUsersEN.Memo = objRow[conUsers.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsUsersDA: GetObjLst)", objException.Message));
}
objUsersEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objUsersEN);
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
public List<clsUsersEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsUsersDA:GetObjLstByTabName)", objException.Message));
}
List<clsUsersEN> arrObjLst = new List<clsUsersEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsersDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUsersEN objUsersEN = new clsUsersEN();
try
{
objUsersEN.UserId = objRow[conUsers.UserId].ToString().Trim(); //用户ID
objUsersEN.UserName = objRow[conUsers.UserName].ToString().Trim(); //用户名
objUsersEN.Password = objRow[conUsers.Password].ToString().Trim(); //密码
objUsersEN.DepartmentId = objRow[conUsers.DepartmentId].ToString().Trim(); //部门ID
objUsersEN.Email = objRow[conUsers.Email].ToString().Trim(); //Email
objUsersEN.IdentityID = objRow[conUsers.IdentityID].ToString().Trim(); //身份编号
objUsersEN.PhoneNumber = objRow[conUsers.PhoneNumber].ToString().Trim(); //手机
objUsersEN.UserStateId = objRow[conUsers.UserStateId].ToString().Trim(); //用户状态Id
objUsersEN.StuTeacherId = objRow[conUsers.StuTeacherId].ToString().Trim(); //学工号
objUsersEN.OrderNum = TransNullToInt(objRow[conUsers.OrderNum].ToString().Trim()); //排序
objUsersEN.UpdDate = objRow[conUsers.UpdDate].ToString().Trim(); //修改日期
objUsersEN.UpdUser = objRow[conUsers.UpdUser].ToString().Trim(); //修改用户
objUsersEN.Memo = objRow[conUsers.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsUsersDA: GetObjLst)", objException.Message));
}
objUsersEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objUsersEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objUsersEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetUsers(ref clsUsersEN objUsersEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsersDA.GetSpecSQLObj();
strSQL = "Select * from Users where UserId = " + "'"+ objUsersEN.UserId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objUsersEN.UserId = objDT.Rows[0][conUsers.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:False)
 objUsersEN.UserName = objDT.Rows[0][conUsers.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:False)
 objUsersEN.Password = objDT.Rows[0][conUsers.Password].ToString().Trim(); //密码(字段类型:varchar,字段长度:20,是否可空:False)
 objUsersEN.DepartmentId = objDT.Rows[0][conUsers.DepartmentId].ToString().Trim(); //部门ID(字段类型:varchar,字段长度:6,是否可空:True)
 objUsersEN.Email = objDT.Rows[0][conUsers.Email].ToString().Trim(); //Email(字段类型:varchar,字段长度:100,是否可空:True)
 objUsersEN.IdentityID = objDT.Rows[0][conUsers.IdentityID].ToString().Trim(); //身份编号(字段类型:char,字段长度:2,是否可空:False)
 objUsersEN.PhoneNumber = objDT.Rows[0][conUsers.PhoneNumber].ToString().Trim(); //手机(字段类型:varchar,字段长度:15,是否可空:True)
 objUsersEN.UserStateId = objDT.Rows[0][conUsers.UserStateId].ToString().Trim(); //用户状态Id(字段类型:char,字段长度:2,是否可空:False)
 objUsersEN.StuTeacherId = objDT.Rows[0][conUsers.StuTeacherId].ToString().Trim(); //学工号(字段类型:varchar,字段长度:20,是否可空:False)
 objUsersEN.OrderNum = TransNullToInt(objDT.Rows[0][conUsers.OrderNum].ToString().Trim()); //排序(字段类型:int,字段长度:4,是否可空:True)
 objUsersEN.UpdDate = objDT.Rows[0][conUsers.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objUsersEN.UpdUser = objDT.Rows[0][conUsers.UpdUser].ToString().Trim(); //修改用户(字段类型:varchar,字段长度:20,是否可空:True)
 objUsersEN.Memo = objDT.Rows[0][conUsers.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsUsersDA: GetUsers)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strUserId">表关键字</param>
 /// <returns>表对象</returns>
public clsUsersEN GetObjByUserId(string strUserId)
{
CheckPrimaryKey(strUserId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsersDA.GetSpecSQLObj();
strSQL = "Select * from Users where UserId = " + "'"+ strUserId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsUsersEN objUsersEN = new clsUsersEN();
try
{
 objUsersEN.UserId = objRow[conUsers.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:False)
 objUsersEN.UserName = objRow[conUsers.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:False)
 objUsersEN.Password = objRow[conUsers.Password] == DBNull.Value ? null : objRow[conUsers.Password].ToString().Trim(); //密码(字段类型:varchar,字段长度:20,是否可空:False)
 objUsersEN.DepartmentId = objRow[conUsers.DepartmentId] == DBNull.Value ? null : objRow[conUsers.DepartmentId].ToString().Trim(); //部门ID(字段类型:varchar,字段长度:6,是否可空:True)
 objUsersEN.Email = objRow[conUsers.Email] == DBNull.Value ? null : objRow[conUsers.Email].ToString().Trim(); //Email(字段类型:varchar,字段长度:100,是否可空:True)
 objUsersEN.IdentityID = objRow[conUsers.IdentityID] == DBNull.Value ? null : objRow[conUsers.IdentityID].ToString().Trim(); //身份编号(字段类型:char,字段长度:2,是否可空:False)
 objUsersEN.PhoneNumber = objRow[conUsers.PhoneNumber] == DBNull.Value ? null : objRow[conUsers.PhoneNumber].ToString().Trim(); //手机(字段类型:varchar,字段长度:15,是否可空:True)
 objUsersEN.UserStateId = objRow[conUsers.UserStateId] == DBNull.Value ? null : objRow[conUsers.UserStateId].ToString().Trim(); //用户状态Id(字段类型:char,字段长度:2,是否可空:False)
 objUsersEN.StuTeacherId = objRow[conUsers.StuTeacherId] == DBNull.Value ? null : objRow[conUsers.StuTeacherId].ToString().Trim(); //学工号(字段类型:varchar,字段长度:20,是否可空:False)
 objUsersEN.OrderNum = Int32.Parse(objRow[conUsers.OrderNum].ToString().Trim()); //排序(字段类型:int,字段长度:4,是否可空:True)
 objUsersEN.UpdDate = objRow[conUsers.UpdDate] == DBNull.Value ? null : objRow[conUsers.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objUsersEN.UpdUser = objRow[conUsers.UpdUser] == DBNull.Value ? null : objRow[conUsers.UpdUser].ToString().Trim(); //修改用户(字段类型:varchar,字段长度:20,是否可空:True)
 objUsersEN.Memo = objRow[conUsers.Memo] == DBNull.Value ? null : objRow[conUsers.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsUsersDA: GetObjByUserId)", objException.Message));
}
return objUsersEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsUsersEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsUsersDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsersDA.GetSpecSQLObj();
strSQL = "Select * from Users where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsUsersEN objUsersEN = new clsUsersEN()
{
UserId = objRow[conUsers.UserId].ToString().Trim(), //用户ID
UserName = objRow[conUsers.UserName].ToString().Trim(), //用户名
Password = objRow[conUsers.Password].ToString().Trim(), //密码
DepartmentId = objRow[conUsers.DepartmentId].ToString().Trim(), //部门ID
Email = objRow[conUsers.Email].ToString().Trim(), //Email
IdentityID = objRow[conUsers.IdentityID].ToString().Trim(), //身份编号
PhoneNumber = objRow[conUsers.PhoneNumber].ToString().Trim(), //手机
UserStateId = objRow[conUsers.UserStateId].ToString().Trim(), //用户状态Id
StuTeacherId = objRow[conUsers.StuTeacherId].ToString().Trim(), //学工号
OrderNum = TransNullToInt(objRow[conUsers.OrderNum].ToString().Trim()), //排序
UpdDate = objRow[conUsers.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conUsers.UpdUser].ToString().Trim(), //修改用户
Memo = objRow[conUsers.Memo].ToString().Trim() //备注
};
objUsersEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objUsersEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsUsersDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsUsersEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsUsersEN objUsersEN = new clsUsersEN();
try
{
objUsersEN.UserId = objRow[conUsers.UserId].ToString().Trim(); //用户ID
objUsersEN.UserName = objRow[conUsers.UserName].ToString().Trim(); //用户名
objUsersEN.Password = objRow[conUsers.Password].ToString().Trim(); //密码
objUsersEN.DepartmentId = objRow[conUsers.DepartmentId].ToString().Trim(); //部门ID
objUsersEN.Email = objRow[conUsers.Email].ToString().Trim(); //Email
objUsersEN.IdentityID = objRow[conUsers.IdentityID].ToString().Trim(); //身份编号
objUsersEN.PhoneNumber = objRow[conUsers.PhoneNumber].ToString().Trim(); //手机
objUsersEN.UserStateId = objRow[conUsers.UserStateId].ToString().Trim(); //用户状态Id
objUsersEN.StuTeacherId = objRow[conUsers.StuTeacherId].ToString().Trim(); //学工号
objUsersEN.OrderNum = TransNullToInt(objRow[conUsers.OrderNum].ToString().Trim()); //排序
objUsersEN.UpdDate = objRow[conUsers.UpdDate].ToString().Trim(); //修改日期
objUsersEN.UpdUser = objRow[conUsers.UpdUser].ToString().Trim(); //修改用户
objUsersEN.Memo = objRow[conUsers.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsUsersDA: GetObjByDataRowUsers)", objException.Message));
}
objUsersEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objUsersEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsUsersEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsUsersEN objUsersEN = new clsUsersEN();
try
{
objUsersEN.UserId = objRow[conUsers.UserId].ToString().Trim(); //用户ID
objUsersEN.UserName = objRow[conUsers.UserName].ToString().Trim(); //用户名
objUsersEN.Password = objRow[conUsers.Password].ToString().Trim(); //密码
objUsersEN.DepartmentId = objRow[conUsers.DepartmentId].ToString().Trim(); //部门ID
objUsersEN.Email = objRow[conUsers.Email].ToString().Trim(); //Email
objUsersEN.IdentityID = objRow[conUsers.IdentityID].ToString().Trim(); //身份编号
objUsersEN.PhoneNumber = objRow[conUsers.PhoneNumber].ToString().Trim(); //手机
objUsersEN.UserStateId = objRow[conUsers.UserStateId].ToString().Trim(); //用户状态Id
objUsersEN.StuTeacherId = objRow[conUsers.StuTeacherId].ToString().Trim(); //学工号
objUsersEN.OrderNum = TransNullToInt(objRow[conUsers.OrderNum].ToString().Trim()); //排序
objUsersEN.UpdDate = objRow[conUsers.UpdDate].ToString().Trim(); //修改日期
objUsersEN.UpdUser = objRow[conUsers.UpdUser].ToString().Trim(); //修改用户
objUsersEN.Memo = objRow[conUsers.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsUsersDA: GetObjByDataRow)", objException.Message));
}
objUsersEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objUsersEN;
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
objSQL = clsUsersDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsUsersEN._CurrTabName_S, conUsers.UserId, 18, "");
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
objSQL = clsUsersDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsUsersEN._CurrTabName_S, conUsers.UserId, 18, strPrefix);
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
 objSQL = clsUsersDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select UserId from Users where " + strCondition;
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
 objSQL = clsUsersDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select UserId from Users where " + strCondition;
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
 /// <param name = "strUserId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strUserId)
{
CheckPrimaryKey(strUserId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsersDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("Users", "UserId = " + "'"+ strUserId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsUsersDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsersDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("Users", strCondition))
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
objSQL = clsUsersDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("Users");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsUsersEN objUsersEN)
 {
 objUsersEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUsersEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUsersEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsersDA.GetSpecSQLObj();
strSQL = "Select * from Users where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "Users");
objRow = objDS.Tables["Users"].NewRow();
objRow[conUsers.UserId] = objUsersEN.UserId; //用户ID
objRow[conUsers.UserName] = objUsersEN.UserName; //用户名
 if (objUsersEN.Password !=  "")
 {
objRow[conUsers.Password] = objUsersEN.Password; //密码
 }
 if (objUsersEN.DepartmentId !=  "")
 {
objRow[conUsers.DepartmentId] = objUsersEN.DepartmentId; //部门ID
 }
 if (objUsersEN.Email !=  "")
 {
objRow[conUsers.Email] = objUsersEN.Email; //Email
 }
 if (objUsersEN.IdentityID !=  "")
 {
objRow[conUsers.IdentityID] = objUsersEN.IdentityID; //身份编号
 }
 if (objUsersEN.PhoneNumber !=  "")
 {
objRow[conUsers.PhoneNumber] = objUsersEN.PhoneNumber; //手机
 }
 if (objUsersEN.UserStateId !=  "")
 {
objRow[conUsers.UserStateId] = objUsersEN.UserStateId; //用户状态Id
 }
 if (objUsersEN.StuTeacherId !=  "")
 {
objRow[conUsers.StuTeacherId] = objUsersEN.StuTeacherId; //学工号
 }
objRow[conUsers.OrderNum] = objUsersEN.OrderNum; //排序
 if (objUsersEN.UpdDate !=  "")
 {
objRow[conUsers.UpdDate] = objUsersEN.UpdDate; //修改日期
 }
 if (objUsersEN.UpdUser !=  "")
 {
objRow[conUsers.UpdUser] = objUsersEN.UpdUser; //修改用户
 }
 if (objUsersEN.Memo !=  "")
 {
objRow[conUsers.Memo] = objUsersEN.Memo; //备注
 }
objDS.Tables[clsUsersEN._CurrTabName_S].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsUsersEN._CurrTabName_S);
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
 /// <param name = "objUsersEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsUsersEN objUsersEN)
{
 objUsersEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUsersEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUsersEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objUsersEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conUsers.UserId);
 objUsersEN.UserId = objUsersEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objUsersEN.UserId + "'");
 }
 
 if (objUsersEN.UserName !=  null)
 {
 arrFieldListForInsert.Add(conUsers.UserName);
 objUsersEN.UserName = objUsersEN.UserName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objUsersEN.UserName + "'");
 }
 
 if (objUsersEN.Password !=  null)
 {
 arrFieldListForInsert.Add(conUsers.Password);
 objUsersEN.Password = objUsersEN.Password.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objUsersEN.Password + "'");
 }
 
 if (objUsersEN.DepartmentId !=  null)
 {
 arrFieldListForInsert.Add(conUsers.DepartmentId);
 objUsersEN.DepartmentId = objUsersEN.DepartmentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objUsersEN.DepartmentId + "'");
 }
 
 if (objUsersEN.Email !=  null)
 {
 arrFieldListForInsert.Add(conUsers.Email);
 objUsersEN.Email = objUsersEN.Email.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objUsersEN.Email + "'");
 }
 
 if (objUsersEN.IdentityID !=  null)
 {
 arrFieldListForInsert.Add(conUsers.IdentityID);
 objUsersEN.IdentityID = objUsersEN.IdentityID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objUsersEN.IdentityID + "'");
 }
 
 if (objUsersEN.PhoneNumber !=  null)
 {
 arrFieldListForInsert.Add(conUsers.PhoneNumber);
 objUsersEN.PhoneNumber = objUsersEN.PhoneNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objUsersEN.PhoneNumber + "'");
 }
 
 if (objUsersEN.UserStateId !=  null)
 {
 arrFieldListForInsert.Add(conUsers.UserStateId);
 objUsersEN.UserStateId = objUsersEN.UserStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objUsersEN.UserStateId + "'");
 }
 
 if (objUsersEN.StuTeacherId !=  null)
 {
 arrFieldListForInsert.Add(conUsers.StuTeacherId);
 objUsersEN.StuTeacherId = objUsersEN.StuTeacherId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objUsersEN.StuTeacherId + "'");
 }
 
 arrFieldListForInsert.Add(conUsers.OrderNum);
 arrValueListForInsert.Add(objUsersEN.OrderNum.ToString());
 
 if (objUsersEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conUsers.UpdDate);
 objUsersEN.UpdDate = objUsersEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objUsersEN.UpdDate + "'");
 }
 
 if (objUsersEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conUsers.UpdUser);
 objUsersEN.UpdUser = objUsersEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objUsersEN.UpdUser + "'");
 }
 
 if (objUsersEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conUsers.Memo);
 objUsersEN.Memo = objUsersEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objUsersEN.Memo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Users");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsersDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objUsersEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsUsersEN objUsersEN)
{
 objUsersEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUsersEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUsersEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objUsersEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conUsers.UserId);
 objUsersEN.UserId = objUsersEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objUsersEN.UserId + "'");
 }
 
 if (objUsersEN.UserName !=  null)
 {
 arrFieldListForInsert.Add(conUsers.UserName);
 objUsersEN.UserName = objUsersEN.UserName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objUsersEN.UserName + "'");
 }
 
 if (objUsersEN.Password !=  null)
 {
 arrFieldListForInsert.Add(conUsers.Password);
 objUsersEN.Password = objUsersEN.Password.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objUsersEN.Password + "'");
 }
 
 if (objUsersEN.DepartmentId !=  null)
 {
 arrFieldListForInsert.Add(conUsers.DepartmentId);
 objUsersEN.DepartmentId = objUsersEN.DepartmentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objUsersEN.DepartmentId + "'");
 }
 
 if (objUsersEN.Email !=  null)
 {
 arrFieldListForInsert.Add(conUsers.Email);
 objUsersEN.Email = objUsersEN.Email.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objUsersEN.Email + "'");
 }
 
 if (objUsersEN.IdentityID !=  null)
 {
 arrFieldListForInsert.Add(conUsers.IdentityID);
 objUsersEN.IdentityID = objUsersEN.IdentityID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objUsersEN.IdentityID + "'");
 }
 
 if (objUsersEN.PhoneNumber !=  null)
 {
 arrFieldListForInsert.Add(conUsers.PhoneNumber);
 objUsersEN.PhoneNumber = objUsersEN.PhoneNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objUsersEN.PhoneNumber + "'");
 }
 
 if (objUsersEN.UserStateId !=  null)
 {
 arrFieldListForInsert.Add(conUsers.UserStateId);
 objUsersEN.UserStateId = objUsersEN.UserStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objUsersEN.UserStateId + "'");
 }
 
 if (objUsersEN.StuTeacherId !=  null)
 {
 arrFieldListForInsert.Add(conUsers.StuTeacherId);
 objUsersEN.StuTeacherId = objUsersEN.StuTeacherId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objUsersEN.StuTeacherId + "'");
 }
 
 arrFieldListForInsert.Add(conUsers.OrderNum);
 arrValueListForInsert.Add(objUsersEN.OrderNum.ToString());
 
 if (objUsersEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conUsers.UpdDate);
 objUsersEN.UpdDate = objUsersEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objUsersEN.UpdDate + "'");
 }
 
 if (objUsersEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conUsers.UpdUser);
 objUsersEN.UpdUser = objUsersEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objUsersEN.UpdUser + "'");
 }
 
 if (objUsersEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conUsers.Memo);
 objUsersEN.Memo = objUsersEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objUsersEN.Memo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Users");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsersDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objUsersEN.UserId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objUsersEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsUsersEN objUsersEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objUsersEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUsersEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUsersEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objUsersEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conUsers.UserId);
 objUsersEN.UserId = objUsersEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objUsersEN.UserId + "'");
 }
 
 if (objUsersEN.UserName !=  null)
 {
 arrFieldListForInsert.Add(conUsers.UserName);
 objUsersEN.UserName = objUsersEN.UserName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objUsersEN.UserName + "'");
 }
 
 if (objUsersEN.Password !=  null)
 {
 arrFieldListForInsert.Add(conUsers.Password);
 objUsersEN.Password = objUsersEN.Password.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objUsersEN.Password + "'");
 }
 
 if (objUsersEN.DepartmentId !=  null)
 {
 arrFieldListForInsert.Add(conUsers.DepartmentId);
 objUsersEN.DepartmentId = objUsersEN.DepartmentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objUsersEN.DepartmentId + "'");
 }
 
 if (objUsersEN.Email !=  null)
 {
 arrFieldListForInsert.Add(conUsers.Email);
 objUsersEN.Email = objUsersEN.Email.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objUsersEN.Email + "'");
 }
 
 if (objUsersEN.IdentityID !=  null)
 {
 arrFieldListForInsert.Add(conUsers.IdentityID);
 objUsersEN.IdentityID = objUsersEN.IdentityID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objUsersEN.IdentityID + "'");
 }
 
 if (objUsersEN.PhoneNumber !=  null)
 {
 arrFieldListForInsert.Add(conUsers.PhoneNumber);
 objUsersEN.PhoneNumber = objUsersEN.PhoneNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objUsersEN.PhoneNumber + "'");
 }
 
 if (objUsersEN.UserStateId !=  null)
 {
 arrFieldListForInsert.Add(conUsers.UserStateId);
 objUsersEN.UserStateId = objUsersEN.UserStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objUsersEN.UserStateId + "'");
 }
 
 if (objUsersEN.StuTeacherId !=  null)
 {
 arrFieldListForInsert.Add(conUsers.StuTeacherId);
 objUsersEN.StuTeacherId = objUsersEN.StuTeacherId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objUsersEN.StuTeacherId + "'");
 }
 
 arrFieldListForInsert.Add(conUsers.OrderNum);
 arrValueListForInsert.Add(objUsersEN.OrderNum.ToString());
 
 if (objUsersEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conUsers.UpdDate);
 objUsersEN.UpdDate = objUsersEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objUsersEN.UpdDate + "'");
 }
 
 if (objUsersEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conUsers.UpdUser);
 objUsersEN.UpdUser = objUsersEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objUsersEN.UpdUser + "'");
 }
 
 if (objUsersEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conUsers.Memo);
 objUsersEN.Memo = objUsersEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objUsersEN.Memo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Users");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsersDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objUsersEN.UserId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objUsersEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsUsersEN objUsersEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objUsersEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUsersEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUsersEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objUsersEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conUsers.UserId);
 objUsersEN.UserId = objUsersEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objUsersEN.UserId + "'");
 }
 
 if (objUsersEN.UserName !=  null)
 {
 arrFieldListForInsert.Add(conUsers.UserName);
 objUsersEN.UserName = objUsersEN.UserName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objUsersEN.UserName + "'");
 }
 
 if (objUsersEN.Password !=  null)
 {
 arrFieldListForInsert.Add(conUsers.Password);
 objUsersEN.Password = objUsersEN.Password.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objUsersEN.Password + "'");
 }
 
 if (objUsersEN.DepartmentId !=  null)
 {
 arrFieldListForInsert.Add(conUsers.DepartmentId);
 objUsersEN.DepartmentId = objUsersEN.DepartmentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objUsersEN.DepartmentId + "'");
 }
 
 if (objUsersEN.Email !=  null)
 {
 arrFieldListForInsert.Add(conUsers.Email);
 objUsersEN.Email = objUsersEN.Email.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objUsersEN.Email + "'");
 }
 
 if (objUsersEN.IdentityID !=  null)
 {
 arrFieldListForInsert.Add(conUsers.IdentityID);
 objUsersEN.IdentityID = objUsersEN.IdentityID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objUsersEN.IdentityID + "'");
 }
 
 if (objUsersEN.PhoneNumber !=  null)
 {
 arrFieldListForInsert.Add(conUsers.PhoneNumber);
 objUsersEN.PhoneNumber = objUsersEN.PhoneNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objUsersEN.PhoneNumber + "'");
 }
 
 if (objUsersEN.UserStateId !=  null)
 {
 arrFieldListForInsert.Add(conUsers.UserStateId);
 objUsersEN.UserStateId = objUsersEN.UserStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objUsersEN.UserStateId + "'");
 }
 
 if (objUsersEN.StuTeacherId !=  null)
 {
 arrFieldListForInsert.Add(conUsers.StuTeacherId);
 objUsersEN.StuTeacherId = objUsersEN.StuTeacherId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objUsersEN.StuTeacherId + "'");
 }
 
 arrFieldListForInsert.Add(conUsers.OrderNum);
 arrValueListForInsert.Add(objUsersEN.OrderNum.ToString());
 
 if (objUsersEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conUsers.UpdDate);
 objUsersEN.UpdDate = objUsersEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objUsersEN.UpdDate + "'");
 }
 
 if (objUsersEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conUsers.UpdUser);
 objUsersEN.UpdUser = objUsersEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objUsersEN.UpdUser + "'");
 }
 
 if (objUsersEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conUsers.Memo);
 objUsersEN.Memo = objUsersEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objUsersEN.Memo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Users");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsersDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewUserss(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsersDA.GetSpecSQLObj();
strSQL = "Select * from Users where UserId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "Users");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strUserId = oRow[conUsers.UserId].ToString().Trim();
if (IsExist(strUserId))
{
 string strResult = "关键字变量值为:" + string.Format("UserId = {0}", strUserId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsUsersEN._CurrTabName_S ].NewRow();
objRow[conUsers.UserId] = oRow[conUsers.UserId].ToString().Trim(); //用户ID
objRow[conUsers.UserName] = oRow[conUsers.UserName].ToString().Trim(); //用户名
objRow[conUsers.Password] = oRow[conUsers.Password].ToString().Trim(); //密码
objRow[conUsers.DepartmentId] = oRow[conUsers.DepartmentId].ToString().Trim(); //部门ID
objRow[conUsers.Email] = oRow[conUsers.Email].ToString().Trim(); //Email
objRow[conUsers.IdentityID] = oRow[conUsers.IdentityID].ToString().Trim(); //身份编号
objRow[conUsers.PhoneNumber] = oRow[conUsers.PhoneNumber].ToString().Trim(); //手机
objRow[conUsers.UserStateId] = oRow[conUsers.UserStateId].ToString().Trim(); //用户状态Id
objRow[conUsers.StuTeacherId] = oRow[conUsers.StuTeacherId].ToString().Trim(); //学工号
objRow[conUsers.OrderNum] = oRow[conUsers.OrderNum].ToString().Trim(); //排序
objRow[conUsers.UpdDate] = oRow[conUsers.UpdDate].ToString().Trim(); //修改日期
objRow[conUsers.UpdUser] = oRow[conUsers.UpdUser].ToString().Trim(); //修改用户
objRow[conUsers.Memo] = oRow[conUsers.Memo].ToString().Trim(); //备注
 objDS.Tables[clsUsersEN._CurrTabName_S].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsUsersEN._CurrTabName_S);
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
 /// <param name = "objUsersEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsUsersEN objUsersEN)
{
 objUsersEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUsersEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUsersEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsersDA.GetSpecSQLObj();
strSQL = "Select * from Users where UserId = " + "'"+ objUsersEN.UserId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsUsersEN._CurrTabName_S);
if (objDS.Tables[clsUsersEN._CurrTabName_S].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:UserId = " + "'"+ objUsersEN.UserId+"'");
return false;
}
objRow = objDS.Tables[clsUsersEN._CurrTabName_S].Rows[0];
 if (objUsersEN.IsUpdated(conUsers.UserId))
 {
objRow[conUsers.UserId] = objUsersEN.UserId; //用户ID
 }
 if (objUsersEN.IsUpdated(conUsers.UserName))
 {
objRow[conUsers.UserName] = objUsersEN.UserName; //用户名
 }
 if (objUsersEN.IsUpdated(conUsers.Password))
 {
objRow[conUsers.Password] = objUsersEN.Password; //密码
 }
 if (objUsersEN.IsUpdated(conUsers.DepartmentId))
 {
objRow[conUsers.DepartmentId] = objUsersEN.DepartmentId; //部门ID
 }
 if (objUsersEN.IsUpdated(conUsers.Email))
 {
objRow[conUsers.Email] = objUsersEN.Email; //Email
 }
 if (objUsersEN.IsUpdated(conUsers.IdentityID))
 {
objRow[conUsers.IdentityID] = objUsersEN.IdentityID; //身份编号
 }
 if (objUsersEN.IsUpdated(conUsers.PhoneNumber))
 {
objRow[conUsers.PhoneNumber] = objUsersEN.PhoneNumber; //手机
 }
 if (objUsersEN.IsUpdated(conUsers.UserStateId))
 {
objRow[conUsers.UserStateId] = objUsersEN.UserStateId; //用户状态Id
 }
 if (objUsersEN.IsUpdated(conUsers.StuTeacherId))
 {
objRow[conUsers.StuTeacherId] = objUsersEN.StuTeacherId; //学工号
 }
 if (objUsersEN.IsUpdated(conUsers.OrderNum))
 {
objRow[conUsers.OrderNum] = objUsersEN.OrderNum; //排序
 }
 if (objUsersEN.IsUpdated(conUsers.UpdDate))
 {
objRow[conUsers.UpdDate] = objUsersEN.UpdDate; //修改日期
 }
 if (objUsersEN.IsUpdated(conUsers.UpdUser))
 {
objRow[conUsers.UpdUser] = objUsersEN.UpdUser; //修改用户
 }
 if (objUsersEN.IsUpdated(conUsers.Memo))
 {
objRow[conUsers.Memo] = objUsersEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsUsersEN._CurrTabName_S);
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
 /// <param name = "objUsersEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsUsersEN objUsersEN)
{
 objUsersEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUsersEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUsersEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsersDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update Users Set ");
 
 if (objUsersEN.IsUpdated(conUsers.UserName))
 {
 if (objUsersEN.UserName !=  null)
 {
 objUsersEN.UserName = objUsersEN.UserName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objUsersEN.UserName, conUsers.UserName); //用户名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUsers.UserName); //用户名
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.Password))
 {
 if (objUsersEN.Password !=  null)
 {
 objUsersEN.Password = objUsersEN.Password.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objUsersEN.Password, conUsers.Password); //密码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUsers.Password); //密码
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.DepartmentId))
 {
 if (objUsersEN.DepartmentId !=  null)
 {
 objUsersEN.DepartmentId = objUsersEN.DepartmentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objUsersEN.DepartmentId, conUsers.DepartmentId); //部门ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUsers.DepartmentId); //部门ID
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.Email))
 {
 if (objUsersEN.Email !=  null)
 {
 objUsersEN.Email = objUsersEN.Email.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objUsersEN.Email, conUsers.Email); //Email
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUsers.Email); //Email
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.IdentityID))
 {
 if (objUsersEN.IdentityID !=  null)
 {
 objUsersEN.IdentityID = objUsersEN.IdentityID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objUsersEN.IdentityID, conUsers.IdentityID); //身份编号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUsers.IdentityID); //身份编号
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.PhoneNumber))
 {
 if (objUsersEN.PhoneNumber !=  null)
 {
 objUsersEN.PhoneNumber = objUsersEN.PhoneNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objUsersEN.PhoneNumber, conUsers.PhoneNumber); //手机
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUsers.PhoneNumber); //手机
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.UserStateId))
 {
 if (objUsersEN.UserStateId !=  null)
 {
 objUsersEN.UserStateId = objUsersEN.UserStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objUsersEN.UserStateId, conUsers.UserStateId); //用户状态Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUsers.UserStateId); //用户状态Id
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.StuTeacherId))
 {
 if (objUsersEN.StuTeacherId !=  null)
 {
 objUsersEN.StuTeacherId = objUsersEN.StuTeacherId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objUsersEN.StuTeacherId, conUsers.StuTeacherId); //学工号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUsers.StuTeacherId); //学工号
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.OrderNum))
 {
 sbSQL.AppendFormat("{1} = {0},",objUsersEN.OrderNum, conUsers.OrderNum); //排序
 }
 
 if (objUsersEN.IsUpdated(conUsers.UpdDate))
 {
 if (objUsersEN.UpdDate !=  null)
 {
 objUsersEN.UpdDate = objUsersEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objUsersEN.UpdDate, conUsers.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUsers.UpdDate); //修改日期
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.UpdUser))
 {
 if (objUsersEN.UpdUser !=  null)
 {
 objUsersEN.UpdUser = objUsersEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objUsersEN.UpdUser, conUsers.UpdUser); //修改用户
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUsers.UpdUser); //修改用户
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.Memo))
 {
 if (objUsersEN.Memo !=  null)
 {
 objUsersEN.Memo = objUsersEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objUsersEN.Memo, conUsers.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUsers.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where UserId = '{0}'", objUsersEN.UserId); 
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
 /// <param name = "objUsersEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsUsersEN objUsersEN, string strCondition)
{
 objUsersEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUsersEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUsersEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsersDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update Users Set ");
 
 if (objUsersEN.IsUpdated(conUsers.UserName))
 {
 if (objUsersEN.UserName !=  null)
 {
 objUsersEN.UserName = objUsersEN.UserName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserName = '{0}',", objUsersEN.UserName); //用户名
 }
 else
 {
 sbSQL.Append(" UserName = null,"); //用户名
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.Password))
 {
 if (objUsersEN.Password !=  null)
 {
 objUsersEN.Password = objUsersEN.Password.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Password = '{0}',", objUsersEN.Password); //密码
 }
 else
 {
 sbSQL.Append(" Password = null,"); //密码
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.DepartmentId))
 {
 if (objUsersEN.DepartmentId !=  null)
 {
 objUsersEN.DepartmentId = objUsersEN.DepartmentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DepartmentId = '{0}',", objUsersEN.DepartmentId); //部门ID
 }
 else
 {
 sbSQL.Append(" DepartmentId = null,"); //部门ID
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.Email))
 {
 if (objUsersEN.Email !=  null)
 {
 objUsersEN.Email = objUsersEN.Email.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Email = '{0}',", objUsersEN.Email); //Email
 }
 else
 {
 sbSQL.Append(" Email = null,"); //Email
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.IdentityID))
 {
 if (objUsersEN.IdentityID !=  null)
 {
 objUsersEN.IdentityID = objUsersEN.IdentityID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdentityID = '{0}',", objUsersEN.IdentityID); //身份编号
 }
 else
 {
 sbSQL.Append(" IdentityID = null,"); //身份编号
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.PhoneNumber))
 {
 if (objUsersEN.PhoneNumber !=  null)
 {
 objUsersEN.PhoneNumber = objUsersEN.PhoneNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PhoneNumber = '{0}',", objUsersEN.PhoneNumber); //手机
 }
 else
 {
 sbSQL.Append(" PhoneNumber = null,"); //手机
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.UserStateId))
 {
 if (objUsersEN.UserStateId !=  null)
 {
 objUsersEN.UserStateId = objUsersEN.UserStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserStateId = '{0}',", objUsersEN.UserStateId); //用户状态Id
 }
 else
 {
 sbSQL.Append(" UserStateId = null,"); //用户状态Id
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.StuTeacherId))
 {
 if (objUsersEN.StuTeacherId !=  null)
 {
 objUsersEN.StuTeacherId = objUsersEN.StuTeacherId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StuTeacherId = '{0}',", objUsersEN.StuTeacherId); //学工号
 }
 else
 {
 sbSQL.Append(" StuTeacherId = null,"); //学工号
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.OrderNum))
 {
 sbSQL.AppendFormat(" OrderNum = {0},", objUsersEN.OrderNum); //排序
 }
 
 if (objUsersEN.IsUpdated(conUsers.UpdDate))
 {
 if (objUsersEN.UpdDate !=  null)
 {
 objUsersEN.UpdDate = objUsersEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", objUsersEN.UpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.UpdUser))
 {
 if (objUsersEN.UpdUser !=  null)
 {
 objUsersEN.UpdUser = objUsersEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", objUsersEN.UpdUser); //修改用户
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改用户
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.Memo))
 {
 if (objUsersEN.Memo !=  null)
 {
 objUsersEN.Memo = objUsersEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", objUsersEN.Memo); //备注
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
 /// <param name = "objUsersEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsUsersEN objUsersEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objUsersEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUsersEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUsersEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsersDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update Users Set ");
 
 if (objUsersEN.IsUpdated(conUsers.UserName))
 {
 if (objUsersEN.UserName !=  null)
 {
 objUsersEN.UserName = objUsersEN.UserName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserName = '{0}',", objUsersEN.UserName); //用户名
 }
 else
 {
 sbSQL.Append(" UserName = null,"); //用户名
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.Password))
 {
 if (objUsersEN.Password !=  null)
 {
 objUsersEN.Password = objUsersEN.Password.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Password = '{0}',", objUsersEN.Password); //密码
 }
 else
 {
 sbSQL.Append(" Password = null,"); //密码
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.DepartmentId))
 {
 if (objUsersEN.DepartmentId !=  null)
 {
 objUsersEN.DepartmentId = objUsersEN.DepartmentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DepartmentId = '{0}',", objUsersEN.DepartmentId); //部门ID
 }
 else
 {
 sbSQL.Append(" DepartmentId = null,"); //部门ID
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.Email))
 {
 if (objUsersEN.Email !=  null)
 {
 objUsersEN.Email = objUsersEN.Email.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Email = '{0}',", objUsersEN.Email); //Email
 }
 else
 {
 sbSQL.Append(" Email = null,"); //Email
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.IdentityID))
 {
 if (objUsersEN.IdentityID !=  null)
 {
 objUsersEN.IdentityID = objUsersEN.IdentityID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdentityID = '{0}',", objUsersEN.IdentityID); //身份编号
 }
 else
 {
 sbSQL.Append(" IdentityID = null,"); //身份编号
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.PhoneNumber))
 {
 if (objUsersEN.PhoneNumber !=  null)
 {
 objUsersEN.PhoneNumber = objUsersEN.PhoneNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PhoneNumber = '{0}',", objUsersEN.PhoneNumber); //手机
 }
 else
 {
 sbSQL.Append(" PhoneNumber = null,"); //手机
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.UserStateId))
 {
 if (objUsersEN.UserStateId !=  null)
 {
 objUsersEN.UserStateId = objUsersEN.UserStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserStateId = '{0}',", objUsersEN.UserStateId); //用户状态Id
 }
 else
 {
 sbSQL.Append(" UserStateId = null,"); //用户状态Id
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.StuTeacherId))
 {
 if (objUsersEN.StuTeacherId !=  null)
 {
 objUsersEN.StuTeacherId = objUsersEN.StuTeacherId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StuTeacherId = '{0}',", objUsersEN.StuTeacherId); //学工号
 }
 else
 {
 sbSQL.Append(" StuTeacherId = null,"); //学工号
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.OrderNum))
 {
 sbSQL.AppendFormat(" OrderNum = {0},", objUsersEN.OrderNum); //排序
 }
 
 if (objUsersEN.IsUpdated(conUsers.UpdDate))
 {
 if (objUsersEN.UpdDate !=  null)
 {
 objUsersEN.UpdDate = objUsersEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", objUsersEN.UpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.UpdUser))
 {
 if (objUsersEN.UpdUser !=  null)
 {
 objUsersEN.UpdUser = objUsersEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", objUsersEN.UpdUser); //修改用户
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改用户
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.Memo))
 {
 if (objUsersEN.Memo !=  null)
 {
 objUsersEN.Memo = objUsersEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", objUsersEN.Memo); //备注
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
 /// <param name = "objUsersEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsUsersEN objUsersEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objUsersEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUsersEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUsersEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsersDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update Users Set ");
 
 if (objUsersEN.IsUpdated(conUsers.UserName))
 {
 if (objUsersEN.UserName !=  null)
 {
 objUsersEN.UserName = objUsersEN.UserName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objUsersEN.UserName, conUsers.UserName); //用户名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUsers.UserName); //用户名
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.Password))
 {
 if (objUsersEN.Password !=  null)
 {
 objUsersEN.Password = objUsersEN.Password.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objUsersEN.Password, conUsers.Password); //密码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUsers.Password); //密码
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.DepartmentId))
 {
 if (objUsersEN.DepartmentId !=  null)
 {
 objUsersEN.DepartmentId = objUsersEN.DepartmentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objUsersEN.DepartmentId, conUsers.DepartmentId); //部门ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUsers.DepartmentId); //部门ID
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.Email))
 {
 if (objUsersEN.Email !=  null)
 {
 objUsersEN.Email = objUsersEN.Email.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objUsersEN.Email, conUsers.Email); //Email
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUsers.Email); //Email
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.IdentityID))
 {
 if (objUsersEN.IdentityID !=  null)
 {
 objUsersEN.IdentityID = objUsersEN.IdentityID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objUsersEN.IdentityID, conUsers.IdentityID); //身份编号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUsers.IdentityID); //身份编号
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.PhoneNumber))
 {
 if (objUsersEN.PhoneNumber !=  null)
 {
 objUsersEN.PhoneNumber = objUsersEN.PhoneNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objUsersEN.PhoneNumber, conUsers.PhoneNumber); //手机
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUsers.PhoneNumber); //手机
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.UserStateId))
 {
 if (objUsersEN.UserStateId !=  null)
 {
 objUsersEN.UserStateId = objUsersEN.UserStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objUsersEN.UserStateId, conUsers.UserStateId); //用户状态Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUsers.UserStateId); //用户状态Id
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.StuTeacherId))
 {
 if (objUsersEN.StuTeacherId !=  null)
 {
 objUsersEN.StuTeacherId = objUsersEN.StuTeacherId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objUsersEN.StuTeacherId, conUsers.StuTeacherId); //学工号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUsers.StuTeacherId); //学工号
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.OrderNum))
 {
 sbSQL.AppendFormat("{1} = {0},",objUsersEN.OrderNum, conUsers.OrderNum); //排序
 }
 
 if (objUsersEN.IsUpdated(conUsers.UpdDate))
 {
 if (objUsersEN.UpdDate !=  null)
 {
 objUsersEN.UpdDate = objUsersEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objUsersEN.UpdDate, conUsers.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUsers.UpdDate); //修改日期
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.UpdUser))
 {
 if (objUsersEN.UpdUser !=  null)
 {
 objUsersEN.UpdUser = objUsersEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objUsersEN.UpdUser, conUsers.UpdUser); //修改用户
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUsers.UpdUser); //修改用户
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.Memo))
 {
 if (objUsersEN.Memo !=  null)
 {
 objUsersEN.Memo = objUsersEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objUsersEN.Memo, conUsers.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUsers.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where UserId = '{0}'", objUsersEN.UserId); 
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
 /// <param name = "strUserId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strUserId) 
{
CheckPrimaryKey(strUserId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsersDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strUserId,
};
 objSQL.ExecSP("Users_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strUserId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strUserId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strUserId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsersDA.GetSpecSQLObj();
//删除Users本表中与当前对象有关的记录
strSQL = strSQL + "Delete from Users where UserId = " + "'"+ strUserId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelUsers(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsersDA.GetSpecSQLObj();
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
//删除Users本表中与当前对象有关的记录
strSQL = strSQL + "Delete from Users where UserId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strUserId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strUserId) 
{
CheckPrimaryKey(strUserId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsersDA.GetSpecSQLObj();
//删除Users本表中与当前对象有关的记录
strSQL = strSQL + "Delete from Users where UserId = " + "'"+ strUserId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelUsers(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsUsersDA: DelUsers)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsersDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from Users where " + strCondition ;
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
public bool DelUsersWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsUsersDA: DelUsersWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsersDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from Users where " + strCondition ;
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
 /// <param name = "objUsersENS">源对象</param>
 /// <param name = "objUsersENT">目标对象</param>
public void CopyTo(clsUsersEN objUsersENS, clsUsersEN objUsersENT)
{
objUsersENT.UserId = objUsersENS.UserId; //用户ID
objUsersENT.UserName = objUsersENS.UserName; //用户名
objUsersENT.Password = objUsersENS.Password; //密码
objUsersENT.DepartmentId = objUsersENS.DepartmentId; //部门ID
objUsersENT.Email = objUsersENS.Email; //Email
objUsersENT.IdentityID = objUsersENS.IdentityID; //身份编号
objUsersENT.PhoneNumber = objUsersENS.PhoneNumber; //手机
objUsersENT.UserStateId = objUsersENS.UserStateId; //用户状态Id
objUsersENT.StuTeacherId = objUsersENS.StuTeacherId; //学工号
objUsersENT.OrderNum = objUsersENS.OrderNum; //排序
objUsersENT.UpdDate = objUsersENS.UpdDate; //修改日期
objUsersENT.UpdUser = objUsersENS.UpdUser; //修改用户
objUsersENT.Memo = objUsersENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsUsersEN objUsersEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objUsersEN.UserName, conUsers.UserName);
clsCheckSql.CheckFieldNotNull(objUsersEN.OrderNum, conUsers.OrderNum);
//检查字段长度
clsCheckSql.CheckFieldLen(objUsersEN.UserId, 18, conUsers.UserId);
clsCheckSql.CheckFieldLen(objUsersEN.UserName, 30, conUsers.UserName);
clsCheckSql.CheckFieldLen(objUsersEN.Password, 20, conUsers.Password);
clsCheckSql.CheckFieldLen(objUsersEN.DepartmentId, 6, conUsers.DepartmentId);
clsCheckSql.CheckFieldLen(objUsersEN.Email, 100, conUsers.Email);
clsCheckSql.CheckFieldLen(objUsersEN.IdentityID, 2, conUsers.IdentityID);
clsCheckSql.CheckFieldLen(objUsersEN.PhoneNumber, 15, conUsers.PhoneNumber);
clsCheckSql.CheckFieldLen(objUsersEN.UserStateId, 2, conUsers.UserStateId);
clsCheckSql.CheckFieldLen(objUsersEN.StuTeacherId, 20, conUsers.StuTeacherId);
clsCheckSql.CheckFieldLen(objUsersEN.UpdDate, 20, conUsers.UpdDate);
clsCheckSql.CheckFieldLen(objUsersEN.UpdUser, 20, conUsers.UpdUser);
clsCheckSql.CheckFieldLen(objUsersEN.Memo, 1000, conUsers.Memo);
//检查字段外键固定长度
 objUsersEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsUsersEN objUsersEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objUsersEN.UserName, 30, conUsers.UserName);
clsCheckSql.CheckFieldLen(objUsersEN.Password, 20, conUsers.Password);
clsCheckSql.CheckFieldLen(objUsersEN.DepartmentId, 6, conUsers.DepartmentId);
clsCheckSql.CheckFieldLen(objUsersEN.Email, 100, conUsers.Email);
clsCheckSql.CheckFieldLen(objUsersEN.IdentityID, 2, conUsers.IdentityID);
clsCheckSql.CheckFieldLen(objUsersEN.PhoneNumber, 15, conUsers.PhoneNumber);
clsCheckSql.CheckFieldLen(objUsersEN.UserStateId, 2, conUsers.UserStateId);
clsCheckSql.CheckFieldLen(objUsersEN.StuTeacherId, 20, conUsers.StuTeacherId);
clsCheckSql.CheckFieldLen(objUsersEN.UpdDate, 20, conUsers.UpdDate);
clsCheckSql.CheckFieldLen(objUsersEN.UpdUser, 20, conUsers.UpdUser);
clsCheckSql.CheckFieldLen(objUsersEN.Memo, 1000, conUsers.Memo);
//检查外键字段长度
 objUsersEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsUsersEN objUsersEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objUsersEN.UserId, 18, conUsers.UserId);
clsCheckSql.CheckFieldLen(objUsersEN.UserName, 30, conUsers.UserName);
clsCheckSql.CheckFieldLen(objUsersEN.Password, 20, conUsers.Password);
clsCheckSql.CheckFieldLen(objUsersEN.DepartmentId, 6, conUsers.DepartmentId);
clsCheckSql.CheckFieldLen(objUsersEN.Email, 100, conUsers.Email);
clsCheckSql.CheckFieldLen(objUsersEN.IdentityID, 2, conUsers.IdentityID);
clsCheckSql.CheckFieldLen(objUsersEN.PhoneNumber, 15, conUsers.PhoneNumber);
clsCheckSql.CheckFieldLen(objUsersEN.UserStateId, 2, conUsers.UserStateId);
clsCheckSql.CheckFieldLen(objUsersEN.StuTeacherId, 20, conUsers.StuTeacherId);
clsCheckSql.CheckFieldLen(objUsersEN.UpdDate, 20, conUsers.UpdDate);
clsCheckSql.CheckFieldLen(objUsersEN.UpdUser, 20, conUsers.UpdUser);
clsCheckSql.CheckFieldLen(objUsersEN.Memo, 1000, conUsers.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objUsersEN.UserId, conUsers.UserId);
clsCheckSql.CheckSqlInjection4Field(objUsersEN.UserName, conUsers.UserName);
clsCheckSql.CheckSqlInjection4Field(objUsersEN.Password, conUsers.Password);
clsCheckSql.CheckSqlInjection4Field(objUsersEN.DepartmentId, conUsers.DepartmentId);
clsCheckSql.CheckSqlInjection4Field(objUsersEN.Email, conUsers.Email);
clsCheckSql.CheckSqlInjection4Field(objUsersEN.IdentityID, conUsers.IdentityID);
clsCheckSql.CheckSqlInjection4Field(objUsersEN.PhoneNumber, conUsers.PhoneNumber);
clsCheckSql.CheckSqlInjection4Field(objUsersEN.UserStateId, conUsers.UserStateId);
clsCheckSql.CheckSqlInjection4Field(objUsersEN.StuTeacherId, conUsers.StuTeacherId);
clsCheckSql.CheckSqlInjection4Field(objUsersEN.UpdDate, conUsers.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objUsersEN.UpdUser, conUsers.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objUsersEN.Memo, conUsers.Memo);
//检查外键字段长度
 objUsersEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetUserId()
{
//获取某学院所有专业信息
string strSQL = "select UserId, UserName from Users ";
 clsSpecSQLforSql mySql = clsUsersDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 检查唯一性(Uniqueness)--Users(用户管理), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.clsGeneCodeBase:GenCheckUniquenessV3)
 /// </summary>
 /// <param name = "strUserId">用户ID(主键)</param>
 /// <returns></returns>
public bool CheckUsersUniqueness(string strUserId )
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("UserId !=  '{0}'", strUserId);
if (IsExistCondRec(sbCondition.ToString())  ==  true)
{
return false;
}
else
{
return true;
}
}
 /// <summary>
 /// 检查唯一性(Uniqueness)--Users(用户管理), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.clsGeneCodeBase:GenCheckUniquenessV3)
 /// </summary>
 /// <returns></returns>
public bool CheckUsersUniqueness()
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
if (IsExistCondRec(sbCondition.ToString())  ==  true)
{
return false;
}
else
{
return true;
}
}

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--Users(用户管理),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objUsersEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr_AAAA(clsUsersEN objUsersEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
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
 objSQL = clsUsersDA.GetSpecSQLObj();
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
 objSQL = clsUsersDA.GetSpecSQLObj();
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
 objSQL = clsUsersDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsUsersEN._CurrTabName_S);
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
 objSQL = clsUsersDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsUsersEN._CurrTabName_S, strCondition);
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
 objSQL = clsUsersDA.GetSpecSQLObj();
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
 objSQL = clsUsersDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}