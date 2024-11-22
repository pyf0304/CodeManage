
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvUsersDA
 表名:vUsers(01120027)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:21:15
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:用户管理(UserManage)
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
 /// v用户(vUsers)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvUsersDA : clsCommBase4DA
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
 return clsvUsersEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvUsersEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvUsersEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvUsersEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvUsersEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:vUsers中,检查关键字,长度不正确!(clsvUsersDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strUserId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vUsers中,关键字不能为空 或 null!(clsvUsersDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strUserId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvUsersDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvUsersDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUsersDA.GetSpecSQLObj();
strSQL = "Select * from vUsers where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vUsers(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvUsersDA: GetDataTable_vUsers)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUsersDA.GetSpecSQLObj();
strSQL = "Select * from vUsers where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvUsersDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUsersDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvUsersDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUsersDA.GetSpecSQLObj();
strSQL = "Select * from vUsers where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvUsersDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUsersDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvUsersDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUsersDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vUsers where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vUsers where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvUsersDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUsersDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vUsers where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvUsersDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUsersDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vUsers.* from vUsers Left Join {1} on {2} where {3} and vUsers.UserId not in (Select top {5} vUsers.UserId from vUsers Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vUsers where {1} and UserId not in (Select top {2} UserId from vUsers where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vUsers where {1} and UserId not in (Select top {3} UserId from vUsers where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvUsersDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUsersDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vUsers.* from vUsers Left Join {1} on {2} where {3} and vUsers.UserId not in (Select top {5} vUsers.UserId from vUsers Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vUsers where {1} and UserId not in (Select top {2} UserId from vUsers where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vUsers where {1} and UserId not in (Select top {3} UserId from vUsers where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvUsersEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvUsersDA:GetObjLst)", objException.Message));
}
List<clsvUsersEN> arrObjLst = new List<clsvUsersEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUsersDA.GetSpecSQLObj();
strSQL = "Select * from vUsers where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUsersEN objvUsersEN = new clsvUsersEN();
try
{
objvUsersEN.UserId = objRow[convUsers.UserId].ToString().Trim(); //用户ID
objvUsersEN.UserName = objRow[convUsers.UserName] == DBNull.Value ? null : objRow[convUsers.UserName].ToString().Trim(); //用户名
objvUsersEN.UserStateId = objRow[convUsers.UserStateId].ToString().Trim(); //用户状态Id
objvUsersEN.UserStateName = objRow[convUsers.UserStateName] == DBNull.Value ? null : objRow[convUsers.UserStateName].ToString().Trim(); //用户状态名
objvUsersEN.Password = objRow[convUsers.Password] == DBNull.Value ? null : objRow[convUsers.Password].ToString().Trim(); //口令
objvUsersEN.IsGpUser = TransNullToBool(objRow[convUsers.IsGpUser].ToString().Trim()); //是否Gp用户
objvUsersEN.BeginYearMonth = objRow[convUsers.BeginYearMonth] == DBNull.Value ? null : objRow[convUsers.BeginYearMonth].ToString().Trim(); //开始年月
objvUsersEN.EndYearMonth = objRow[convUsers.EndYearMonth] == DBNull.Value ? null : objRow[convUsers.EndYearMonth].ToString().Trim(); //结束年月
objvUsersEN.IdGradeBase = objRow[convUsers.IdGradeBase] == DBNull.Value ? null : objRow[convUsers.IdGradeBase].ToString().Trim(); //年级流水号
objvUsersEN.GradeBaseName = objRow[convUsers.GradeBaseName] == DBNull.Value ? null : objRow[convUsers.GradeBaseName].ToString().Trim(); //年级名称
objvUsersEN.IdXzCollege = objRow[convUsers.IdXzCollege] == DBNull.Value ? null : objRow[convUsers.IdXzCollege].ToString().Trim(); //学院流水号
objvUsersEN.CollegeId = objRow[convUsers.CollegeId] == DBNull.Value ? null : objRow[convUsers.CollegeId].ToString().Trim(); //学院ID
objvUsersEN.CollegeName = objRow[convUsers.CollegeName] == DBNull.Value ? null : objRow[convUsers.CollegeName].ToString().Trim(); //学院名称
objvUsersEN.CollegeNameA = objRow[convUsers.CollegeNameA] == DBNull.Value ? null : objRow[convUsers.CollegeNameA].ToString().Trim(); //学院名称简写
objvUsersEN.IdXzMajor = objRow[convUsers.IdXzMajor] == DBNull.Value ? null : objRow[convUsers.IdXzMajor].ToString().Trim(); //专业流水号
objvUsersEN.MajorName = objRow[convUsers.MajorName] == DBNull.Value ? null : objRow[convUsers.MajorName].ToString().Trim(); //专业名称
objvUsersEN.IsLeaved = TransNullToBool(objRow[convUsers.IsLeaved].ToString().Trim()); //是否离开
objvUsersEN.StuIdTeacherId = objRow[convUsers.StuIdTeacherId] == DBNull.Value ? null : objRow[convUsers.StuIdTeacherId].ToString().Trim(); //学工号
objvUsersEN.IdentityId = objRow[convUsers.IdentityId].ToString().Trim(); //身份Id
objvUsersEN.IdentityDesc = objRow[convUsers.IdentityDesc] == DBNull.Value ? null : objRow[convUsers.IdentityDesc].ToString().Trim(); //身份描述
objvUsersEN.AuditDate = objRow[convUsers.AuditDate] == DBNull.Value ? null : objRow[convUsers.AuditDate].ToString().Trim(); //AuditDate
objvUsersEN.AuditUser = objRow[convUsers.AuditUser] == DBNull.Value ? null : objRow[convUsers.AuditUser].ToString().Trim(); //AuditUser
objvUsersEN.IsAudit = TransNullToBool(objRow[convUsers.IsAudit].ToString().Trim()); //是否审核
objvUsersEN.IsRegister = TransNullToBool(objRow[convUsers.IsRegister].ToString().Trim()); //IsRegister
objvUsersEN.RegisterDate = objRow[convUsers.RegisterDate] == DBNull.Value ? null : objRow[convUsers.RegisterDate].ToString().Trim(); //RegisterDate
objvUsersEN.MobilePhone = objRow[convUsers.MobilePhone] == DBNull.Value ? null : objRow[convUsers.MobilePhone].ToString().Trim(); //手机
objvUsersEN.UpdDate = objRow[convUsers.UpdDate] == DBNull.Value ? null : objRow[convUsers.UpdDate].ToString().Trim(); //修改日期
objvUsersEN.UpdUser = objRow[convUsers.UpdUser] == DBNull.Value ? null : objRow[convUsers.UpdUser].ToString().Trim(); //修改人
objvUsersEN.Memo = objRow[convUsers.Memo] == DBNull.Value ? null : objRow[convUsers.Memo].ToString().Trim(); //备注
objvUsersEN.UserNameWithUserId = objRow[convUsers.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvUsersEN.OpenId = objRow[convUsers.OpenId] == DBNull.Value ? null : objRow[convUsers.OpenId].ToString().Trim(); //微信OpenId
objvUsersEN.AvatarsPicture = objRow[convUsers.AvatarsPicture] == DBNull.Value ? null : objRow[convUsers.AvatarsPicture].ToString().Trim(); //虚拟头像
objvUsersEN.Email = objRow[convUsers.Email] == DBNull.Value ? null : objRow[convUsers.Email].ToString().Trim(); //电子邮箱
objvUsersEN.PhoneNumber = objRow[convUsers.PhoneNumber] == DBNull.Value ? null : objRow[convUsers.PhoneNumber].ToString().Trim(); //电话
objvUsersEN.HeadPic = objRow[convUsers.HeadPic] == DBNull.Value ? null : objRow[convUsers.HeadPic].ToString().Trim(); //头像
objvUsersEN.IsGSuser = TransNullToBool(objRow[convUsers.IsGSuser].ToString().Trim()); //是否GS用户
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvUsersDA: GetObjLst)", objException.Message));
}
objvUsersEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvUsersEN);
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
public List<clsvUsersEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvUsersDA:GetObjLstByTabName)", objException.Message));
}
List<clsvUsersEN> arrObjLst = new List<clsvUsersEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUsersDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUsersEN objvUsersEN = new clsvUsersEN();
try
{
objvUsersEN.UserId = objRow[convUsers.UserId].ToString().Trim(); //用户ID
objvUsersEN.UserName = objRow[convUsers.UserName] == DBNull.Value ? null : objRow[convUsers.UserName].ToString().Trim(); //用户名
objvUsersEN.UserStateId = objRow[convUsers.UserStateId].ToString().Trim(); //用户状态Id
objvUsersEN.UserStateName = objRow[convUsers.UserStateName] == DBNull.Value ? null : objRow[convUsers.UserStateName].ToString().Trim(); //用户状态名
objvUsersEN.Password = objRow[convUsers.Password] == DBNull.Value ? null : objRow[convUsers.Password].ToString().Trim(); //口令
objvUsersEN.IsGpUser = TransNullToBool(objRow[convUsers.IsGpUser].ToString().Trim()); //是否Gp用户
objvUsersEN.BeginYearMonth = objRow[convUsers.BeginYearMonth] == DBNull.Value ? null : objRow[convUsers.BeginYearMonth].ToString().Trim(); //开始年月
objvUsersEN.EndYearMonth = objRow[convUsers.EndYearMonth] == DBNull.Value ? null : objRow[convUsers.EndYearMonth].ToString().Trim(); //结束年月
objvUsersEN.IdGradeBase = objRow[convUsers.IdGradeBase] == DBNull.Value ? null : objRow[convUsers.IdGradeBase].ToString().Trim(); //年级流水号
objvUsersEN.GradeBaseName = objRow[convUsers.GradeBaseName] == DBNull.Value ? null : objRow[convUsers.GradeBaseName].ToString().Trim(); //年级名称
objvUsersEN.IdXzCollege = objRow[convUsers.IdXzCollege] == DBNull.Value ? null : objRow[convUsers.IdXzCollege].ToString().Trim(); //学院流水号
objvUsersEN.CollegeId = objRow[convUsers.CollegeId] == DBNull.Value ? null : objRow[convUsers.CollegeId].ToString().Trim(); //学院ID
objvUsersEN.CollegeName = objRow[convUsers.CollegeName] == DBNull.Value ? null : objRow[convUsers.CollegeName].ToString().Trim(); //学院名称
objvUsersEN.CollegeNameA = objRow[convUsers.CollegeNameA] == DBNull.Value ? null : objRow[convUsers.CollegeNameA].ToString().Trim(); //学院名称简写
objvUsersEN.IdXzMajor = objRow[convUsers.IdXzMajor] == DBNull.Value ? null : objRow[convUsers.IdXzMajor].ToString().Trim(); //专业流水号
objvUsersEN.MajorName = objRow[convUsers.MajorName] == DBNull.Value ? null : objRow[convUsers.MajorName].ToString().Trim(); //专业名称
objvUsersEN.IsLeaved = TransNullToBool(objRow[convUsers.IsLeaved].ToString().Trim()); //是否离开
objvUsersEN.StuIdTeacherId = objRow[convUsers.StuIdTeacherId] == DBNull.Value ? null : objRow[convUsers.StuIdTeacherId].ToString().Trim(); //学工号
objvUsersEN.IdentityId = objRow[convUsers.IdentityId].ToString().Trim(); //身份Id
objvUsersEN.IdentityDesc = objRow[convUsers.IdentityDesc] == DBNull.Value ? null : objRow[convUsers.IdentityDesc].ToString().Trim(); //身份描述
objvUsersEN.AuditDate = objRow[convUsers.AuditDate] == DBNull.Value ? null : objRow[convUsers.AuditDate].ToString().Trim(); //AuditDate
objvUsersEN.AuditUser = objRow[convUsers.AuditUser] == DBNull.Value ? null : objRow[convUsers.AuditUser].ToString().Trim(); //AuditUser
objvUsersEN.IsAudit = TransNullToBool(objRow[convUsers.IsAudit].ToString().Trim()); //是否审核
objvUsersEN.IsRegister = TransNullToBool(objRow[convUsers.IsRegister].ToString().Trim()); //IsRegister
objvUsersEN.RegisterDate = objRow[convUsers.RegisterDate] == DBNull.Value ? null : objRow[convUsers.RegisterDate].ToString().Trim(); //RegisterDate
objvUsersEN.MobilePhone = objRow[convUsers.MobilePhone] == DBNull.Value ? null : objRow[convUsers.MobilePhone].ToString().Trim(); //手机
objvUsersEN.UpdDate = objRow[convUsers.UpdDate] == DBNull.Value ? null : objRow[convUsers.UpdDate].ToString().Trim(); //修改日期
objvUsersEN.UpdUser = objRow[convUsers.UpdUser] == DBNull.Value ? null : objRow[convUsers.UpdUser].ToString().Trim(); //修改人
objvUsersEN.Memo = objRow[convUsers.Memo] == DBNull.Value ? null : objRow[convUsers.Memo].ToString().Trim(); //备注
objvUsersEN.UserNameWithUserId = objRow[convUsers.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvUsersEN.OpenId = objRow[convUsers.OpenId] == DBNull.Value ? null : objRow[convUsers.OpenId].ToString().Trim(); //微信OpenId
objvUsersEN.AvatarsPicture = objRow[convUsers.AvatarsPicture] == DBNull.Value ? null : objRow[convUsers.AvatarsPicture].ToString().Trim(); //虚拟头像
objvUsersEN.Email = objRow[convUsers.Email] == DBNull.Value ? null : objRow[convUsers.Email].ToString().Trim(); //电子邮箱
objvUsersEN.PhoneNumber = objRow[convUsers.PhoneNumber] == DBNull.Value ? null : objRow[convUsers.PhoneNumber].ToString().Trim(); //电话
objvUsersEN.HeadPic = objRow[convUsers.HeadPic] == DBNull.Value ? null : objRow[convUsers.HeadPic].ToString().Trim(); //头像
objvUsersEN.IsGSuser = TransNullToBool(objRow[convUsers.IsGSuser].ToString().Trim()); //是否GS用户
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvUsersDA: GetObjLst)", objException.Message));
}
objvUsersEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvUsersEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvUsersEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvUsers(ref clsvUsersEN objvUsersEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUsersDA.GetSpecSQLObj();
strSQL = "Select * from vUsers where UserId = " + "'"+ objvUsersEN.UserId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvUsersEN.UserId = objDT.Rows[0][convUsers.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvUsersEN.UserName = objDT.Rows[0][convUsers.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvUsersEN.UserStateId = objDT.Rows[0][convUsers.UserStateId].ToString().Trim(); //用户状态Id(字段类型:char,字段长度:2,是否可空:True)
 objvUsersEN.UserStateName = objDT.Rows[0][convUsers.UserStateName].ToString().Trim(); //用户状态名(字段类型:varchar,字段长度:20,是否可空:True)
 objvUsersEN.Password = objDT.Rows[0][convUsers.Password].ToString().Trim(); //口令(字段类型:varchar,字段长度:20,是否可空:True)
 objvUsersEN.IsGpUser = TransNullToBool(objDT.Rows[0][convUsers.IsGpUser].ToString().Trim()); //是否Gp用户(字段类型:bit,字段长度:1,是否可空:True)
 objvUsersEN.BeginYearMonth = objDT.Rows[0][convUsers.BeginYearMonth].ToString().Trim(); //开始年月(字段类型:varchar,字段长度:8,是否可空:True)
 objvUsersEN.EndYearMonth = objDT.Rows[0][convUsers.EndYearMonth].ToString().Trim(); //结束年月(字段类型:varchar,字段长度:8,是否可空:True)
 objvUsersEN.IdGradeBase = objDT.Rows[0][convUsers.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objvUsersEN.GradeBaseName = objDT.Rows[0][convUsers.GradeBaseName].ToString().Trim(); //年级名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvUsersEN.IdXzCollege = objDT.Rows[0][convUsers.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvUsersEN.CollegeId = objDT.Rows[0][convUsers.CollegeId].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvUsersEN.CollegeName = objDT.Rows[0][convUsers.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvUsersEN.CollegeNameA = objDT.Rows[0][convUsers.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvUsersEN.IdXzMajor = objDT.Rows[0][convUsers.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvUsersEN.MajorName = objDT.Rows[0][convUsers.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvUsersEN.IsLeaved = TransNullToBool(objDT.Rows[0][convUsers.IsLeaved].ToString().Trim()); //是否离开(字段类型:bit,字段长度:1,是否可空:True)
 objvUsersEN.StuIdTeacherId = objDT.Rows[0][convUsers.StuIdTeacherId].ToString().Trim(); //学工号(字段类型:varchar,字段长度:20,是否可空:True)
 objvUsersEN.IdentityId = objDT.Rows[0][convUsers.IdentityId].ToString().Trim(); //身份Id(字段类型:char,字段长度:2,是否可空:False)
 objvUsersEN.IdentityDesc = objDT.Rows[0][convUsers.IdentityDesc].ToString().Trim(); //身份描述(字段类型:varchar,字段长度:20,是否可空:False)
 objvUsersEN.AuditDate = objDT.Rows[0][convUsers.AuditDate].ToString().Trim(); //AuditDate(字段类型:varchar,字段长度:14,是否可空:True)
 objvUsersEN.AuditUser = objDT.Rows[0][convUsers.AuditUser].ToString().Trim(); //AuditUser(字段类型:varchar,字段长度:18,是否可空:True)
 objvUsersEN.IsAudit = TransNullToBool(objDT.Rows[0][convUsers.IsAudit].ToString().Trim()); //是否审核(字段类型:bit,字段长度:1,是否可空:True)
 objvUsersEN.IsRegister = TransNullToBool(objDT.Rows[0][convUsers.IsRegister].ToString().Trim()); //IsRegister(字段类型:bit,字段长度:1,是否可空:True)
 objvUsersEN.RegisterDate = objDT.Rows[0][convUsers.RegisterDate].ToString().Trim(); //RegisterDate(字段类型:varchar,字段长度:14,是否可空:True)
 objvUsersEN.MobilePhone = objDT.Rows[0][convUsers.MobilePhone].ToString().Trim(); //手机(字段类型:varchar,字段长度:20,是否可空:True)
 objvUsersEN.UpdDate = objDT.Rows[0][convUsers.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvUsersEN.UpdUser = objDT.Rows[0][convUsers.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvUsersEN.Memo = objDT.Rows[0][convUsers.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvUsersEN.UserNameWithUserId = objDT.Rows[0][convUsers.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId(字段类型:varchar,字段长度:51,是否可空:False)
 objvUsersEN.OpenId = objDT.Rows[0][convUsers.OpenId].ToString().Trim(); //微信OpenId(字段类型:varchar,字段长度:50,是否可空:True)
 objvUsersEN.AvatarsPicture = objDT.Rows[0][convUsers.AvatarsPicture].ToString().Trim(); //虚拟头像(字段类型:varchar,字段长度:100,是否可空:True)
 objvUsersEN.Email = objDT.Rows[0][convUsers.Email].ToString().Trim(); //电子邮箱(字段类型:varchar,字段长度:100,是否可空:True)
 objvUsersEN.PhoneNumber = objDT.Rows[0][convUsers.PhoneNumber].ToString().Trim(); //电话(字段类型:varchar,字段长度:15,是否可空:True)
 objvUsersEN.HeadPic = objDT.Rows[0][convUsers.HeadPic].ToString().Trim(); //头像(字段类型:varchar,字段长度:500,是否可空:True)
 objvUsersEN.IsGSuser = TransNullToBool(objDT.Rows[0][convUsers.IsGSuser].ToString().Trim()); //是否GS用户(字段类型:bit,字段长度:1,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvUsersDA: GetvUsers)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strUserId">表关键字</param>
 /// <returns>表对象</returns>
public clsvUsersEN GetObjByUserId(string strUserId)
{
CheckPrimaryKey(strUserId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUsersDA.GetSpecSQLObj();
strSQL = "Select * from vUsers where UserId = " + "'"+ strUserId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvUsersEN objvUsersEN = new clsvUsersEN();
try
{
 objvUsersEN.UserId = objRow[convUsers.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvUsersEN.UserName = objRow[convUsers.UserName] == DBNull.Value ? null : objRow[convUsers.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvUsersEN.UserStateId = objRow[convUsers.UserStateId].ToString().Trim(); //用户状态Id(字段类型:char,字段长度:2,是否可空:True)
 objvUsersEN.UserStateName = objRow[convUsers.UserStateName] == DBNull.Value ? null : objRow[convUsers.UserStateName].ToString().Trim(); //用户状态名(字段类型:varchar,字段长度:20,是否可空:True)
 objvUsersEN.Password = objRow[convUsers.Password] == DBNull.Value ? null : objRow[convUsers.Password].ToString().Trim(); //口令(字段类型:varchar,字段长度:20,是否可空:True)
 objvUsersEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[convUsers.IsGpUser].ToString().Trim()); //是否Gp用户(字段类型:bit,字段长度:1,是否可空:True)
 objvUsersEN.BeginYearMonth = objRow[convUsers.BeginYearMonth] == DBNull.Value ? null : objRow[convUsers.BeginYearMonth].ToString().Trim(); //开始年月(字段类型:varchar,字段长度:8,是否可空:True)
 objvUsersEN.EndYearMonth = objRow[convUsers.EndYearMonth] == DBNull.Value ? null : objRow[convUsers.EndYearMonth].ToString().Trim(); //结束年月(字段类型:varchar,字段长度:8,是否可空:True)
 objvUsersEN.IdGradeBase = objRow[convUsers.IdGradeBase] == DBNull.Value ? null : objRow[convUsers.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objvUsersEN.GradeBaseName = objRow[convUsers.GradeBaseName] == DBNull.Value ? null : objRow[convUsers.GradeBaseName].ToString().Trim(); //年级名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvUsersEN.IdXzCollege = objRow[convUsers.IdXzCollege] == DBNull.Value ? null : objRow[convUsers.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvUsersEN.CollegeId = objRow[convUsers.CollegeId] == DBNull.Value ? null : objRow[convUsers.CollegeId].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvUsersEN.CollegeName = objRow[convUsers.CollegeName] == DBNull.Value ? null : objRow[convUsers.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvUsersEN.CollegeNameA = objRow[convUsers.CollegeNameA] == DBNull.Value ? null : objRow[convUsers.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvUsersEN.IdXzMajor = objRow[convUsers.IdXzMajor] == DBNull.Value ? null : objRow[convUsers.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvUsersEN.MajorName = objRow[convUsers.MajorName] == DBNull.Value ? null : objRow[convUsers.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvUsersEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[convUsers.IsLeaved].ToString().Trim()); //是否离开(字段类型:bit,字段长度:1,是否可空:True)
 objvUsersEN.StuIdTeacherId = objRow[convUsers.StuIdTeacherId] == DBNull.Value ? null : objRow[convUsers.StuIdTeacherId].ToString().Trim(); //学工号(字段类型:varchar,字段长度:20,是否可空:True)
 objvUsersEN.IdentityId = objRow[convUsers.IdentityId].ToString().Trim(); //身份Id(字段类型:char,字段长度:2,是否可空:False)
 objvUsersEN.IdentityDesc = objRow[convUsers.IdentityDesc] == DBNull.Value ? null : objRow[convUsers.IdentityDesc].ToString().Trim(); //身份描述(字段类型:varchar,字段长度:20,是否可空:False)
 objvUsersEN.AuditDate = objRow[convUsers.AuditDate] == DBNull.Value ? null : objRow[convUsers.AuditDate].ToString().Trim(); //AuditDate(字段类型:varchar,字段长度:14,是否可空:True)
 objvUsersEN.AuditUser = objRow[convUsers.AuditUser] == DBNull.Value ? null : objRow[convUsers.AuditUser].ToString().Trim(); //AuditUser(字段类型:varchar,字段长度:18,是否可空:True)
 objvUsersEN.IsAudit = clsEntityBase2.TransNullToBool_S(objRow[convUsers.IsAudit].ToString().Trim()); //是否审核(字段类型:bit,字段长度:1,是否可空:True)
 objvUsersEN.IsRegister = clsEntityBase2.TransNullToBool_S(objRow[convUsers.IsRegister].ToString().Trim()); //IsRegister(字段类型:bit,字段长度:1,是否可空:True)
 objvUsersEN.RegisterDate = objRow[convUsers.RegisterDate] == DBNull.Value ? null : objRow[convUsers.RegisterDate].ToString().Trim(); //RegisterDate(字段类型:varchar,字段长度:14,是否可空:True)
 objvUsersEN.MobilePhone = objRow[convUsers.MobilePhone] == DBNull.Value ? null : objRow[convUsers.MobilePhone].ToString().Trim(); //手机(字段类型:varchar,字段长度:20,是否可空:True)
 objvUsersEN.UpdDate = objRow[convUsers.UpdDate] == DBNull.Value ? null : objRow[convUsers.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvUsersEN.UpdUser = objRow[convUsers.UpdUser] == DBNull.Value ? null : objRow[convUsers.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvUsersEN.Memo = objRow[convUsers.Memo] == DBNull.Value ? null : objRow[convUsers.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvUsersEN.UserNameWithUserId = objRow[convUsers.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId(字段类型:varchar,字段长度:51,是否可空:False)
 objvUsersEN.OpenId = objRow[convUsers.OpenId] == DBNull.Value ? null : objRow[convUsers.OpenId].ToString().Trim(); //微信OpenId(字段类型:varchar,字段长度:50,是否可空:True)
 objvUsersEN.AvatarsPicture = objRow[convUsers.AvatarsPicture] == DBNull.Value ? null : objRow[convUsers.AvatarsPicture].ToString().Trim(); //虚拟头像(字段类型:varchar,字段长度:100,是否可空:True)
 objvUsersEN.Email = objRow[convUsers.Email] == DBNull.Value ? null : objRow[convUsers.Email].ToString().Trim(); //电子邮箱(字段类型:varchar,字段长度:100,是否可空:True)
 objvUsersEN.PhoneNumber = objRow[convUsers.PhoneNumber] == DBNull.Value ? null : objRow[convUsers.PhoneNumber].ToString().Trim(); //电话(字段类型:varchar,字段长度:15,是否可空:True)
 objvUsersEN.HeadPic = objRow[convUsers.HeadPic] == DBNull.Value ? null : objRow[convUsers.HeadPic].ToString().Trim(); //头像(字段类型:varchar,字段长度:500,是否可空:True)
 objvUsersEN.IsGSuser = clsEntityBase2.TransNullToBool_S(objRow[convUsers.IsGSuser].ToString().Trim()); //是否GS用户(字段类型:bit,字段长度:1,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvUsersDA: GetObjByUserId)", objException.Message));
}
return objvUsersEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvUsersEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvUsersDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUsersDA.GetSpecSQLObj();
strSQL = "Select * from vUsers where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvUsersEN objvUsersEN = new clsvUsersEN()
{
UserId = objRow[convUsers.UserId].ToString().Trim(), //用户ID
UserName = objRow[convUsers.UserName] == DBNull.Value ? null : objRow[convUsers.UserName].ToString().Trim(), //用户名
UserStateId = objRow[convUsers.UserStateId].ToString().Trim(), //用户状态Id
UserStateName = objRow[convUsers.UserStateName] == DBNull.Value ? null : objRow[convUsers.UserStateName].ToString().Trim(), //用户状态名
Password = objRow[convUsers.Password] == DBNull.Value ? null : objRow[convUsers.Password].ToString().Trim(), //口令
IsGpUser = TransNullToBool(objRow[convUsers.IsGpUser].ToString().Trim()), //是否Gp用户
BeginYearMonth = objRow[convUsers.BeginYearMonth] == DBNull.Value ? null : objRow[convUsers.BeginYearMonth].ToString().Trim(), //开始年月
EndYearMonth = objRow[convUsers.EndYearMonth] == DBNull.Value ? null : objRow[convUsers.EndYearMonth].ToString().Trim(), //结束年月
IdGradeBase = objRow[convUsers.IdGradeBase] == DBNull.Value ? null : objRow[convUsers.IdGradeBase].ToString().Trim(), //年级流水号
GradeBaseName = objRow[convUsers.GradeBaseName] == DBNull.Value ? null : objRow[convUsers.GradeBaseName].ToString().Trim(), //年级名称
IdXzCollege = objRow[convUsers.IdXzCollege] == DBNull.Value ? null : objRow[convUsers.IdXzCollege].ToString().Trim(), //学院流水号
CollegeId = objRow[convUsers.CollegeId] == DBNull.Value ? null : objRow[convUsers.CollegeId].ToString().Trim(), //学院ID
CollegeName = objRow[convUsers.CollegeName] == DBNull.Value ? null : objRow[convUsers.CollegeName].ToString().Trim(), //学院名称
CollegeNameA = objRow[convUsers.CollegeNameA] == DBNull.Value ? null : objRow[convUsers.CollegeNameA].ToString().Trim(), //学院名称简写
IdXzMajor = objRow[convUsers.IdXzMajor] == DBNull.Value ? null : objRow[convUsers.IdXzMajor].ToString().Trim(), //专业流水号
MajorName = objRow[convUsers.MajorName] == DBNull.Value ? null : objRow[convUsers.MajorName].ToString().Trim(), //专业名称
IsLeaved = TransNullToBool(objRow[convUsers.IsLeaved].ToString().Trim()), //是否离开
StuIdTeacherId = objRow[convUsers.StuIdTeacherId] == DBNull.Value ? null : objRow[convUsers.StuIdTeacherId].ToString().Trim(), //学工号
IdentityId = objRow[convUsers.IdentityId].ToString().Trim(), //身份Id
IdentityDesc = objRow[convUsers.IdentityDesc] == DBNull.Value ? null : objRow[convUsers.IdentityDesc].ToString().Trim(), //身份描述
AuditDate = objRow[convUsers.AuditDate] == DBNull.Value ? null : objRow[convUsers.AuditDate].ToString().Trim(), //AuditDate
AuditUser = objRow[convUsers.AuditUser] == DBNull.Value ? null : objRow[convUsers.AuditUser].ToString().Trim(), //AuditUser
IsAudit = TransNullToBool(objRow[convUsers.IsAudit].ToString().Trim()), //是否审核
IsRegister = TransNullToBool(objRow[convUsers.IsRegister].ToString().Trim()), //IsRegister
RegisterDate = objRow[convUsers.RegisterDate] == DBNull.Value ? null : objRow[convUsers.RegisterDate].ToString().Trim(), //RegisterDate
MobilePhone = objRow[convUsers.MobilePhone] == DBNull.Value ? null : objRow[convUsers.MobilePhone].ToString().Trim(), //手机
UpdDate = objRow[convUsers.UpdDate] == DBNull.Value ? null : objRow[convUsers.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convUsers.UpdUser] == DBNull.Value ? null : objRow[convUsers.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convUsers.Memo] == DBNull.Value ? null : objRow[convUsers.Memo].ToString().Trim(), //备注
UserNameWithUserId = objRow[convUsers.UserNameWithUserId].ToString().Trim(), //UserNameWithUserId
OpenId = objRow[convUsers.OpenId] == DBNull.Value ? null : objRow[convUsers.OpenId].ToString().Trim(), //微信OpenId
AvatarsPicture = objRow[convUsers.AvatarsPicture] == DBNull.Value ? null : objRow[convUsers.AvatarsPicture].ToString().Trim(), //虚拟头像
Email = objRow[convUsers.Email] == DBNull.Value ? null : objRow[convUsers.Email].ToString().Trim(), //电子邮箱
PhoneNumber = objRow[convUsers.PhoneNumber] == DBNull.Value ? null : objRow[convUsers.PhoneNumber].ToString().Trim(), //电话
HeadPic = objRow[convUsers.HeadPic] == DBNull.Value ? null : objRow[convUsers.HeadPic].ToString().Trim(), //头像
IsGSuser = TransNullToBool(objRow[convUsers.IsGSuser].ToString().Trim()) //是否GS用户
};
objvUsersEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvUsersEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvUsersDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvUsersEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvUsersEN objvUsersEN = new clsvUsersEN();
try
{
objvUsersEN.UserId = objRow[convUsers.UserId].ToString().Trim(); //用户ID
objvUsersEN.UserName = objRow[convUsers.UserName] == DBNull.Value ? null : objRow[convUsers.UserName].ToString().Trim(); //用户名
objvUsersEN.UserStateId = objRow[convUsers.UserStateId].ToString().Trim(); //用户状态Id
objvUsersEN.UserStateName = objRow[convUsers.UserStateName] == DBNull.Value ? null : objRow[convUsers.UserStateName].ToString().Trim(); //用户状态名
objvUsersEN.Password = objRow[convUsers.Password] == DBNull.Value ? null : objRow[convUsers.Password].ToString().Trim(); //口令
objvUsersEN.IsGpUser = TransNullToBool(objRow[convUsers.IsGpUser].ToString().Trim()); //是否Gp用户
objvUsersEN.BeginYearMonth = objRow[convUsers.BeginYearMonth] == DBNull.Value ? null : objRow[convUsers.BeginYearMonth].ToString().Trim(); //开始年月
objvUsersEN.EndYearMonth = objRow[convUsers.EndYearMonth] == DBNull.Value ? null : objRow[convUsers.EndYearMonth].ToString().Trim(); //结束年月
objvUsersEN.IdGradeBase = objRow[convUsers.IdGradeBase] == DBNull.Value ? null : objRow[convUsers.IdGradeBase].ToString().Trim(); //年级流水号
objvUsersEN.GradeBaseName = objRow[convUsers.GradeBaseName] == DBNull.Value ? null : objRow[convUsers.GradeBaseName].ToString().Trim(); //年级名称
objvUsersEN.IdXzCollege = objRow[convUsers.IdXzCollege] == DBNull.Value ? null : objRow[convUsers.IdXzCollege].ToString().Trim(); //学院流水号
objvUsersEN.CollegeId = objRow[convUsers.CollegeId] == DBNull.Value ? null : objRow[convUsers.CollegeId].ToString().Trim(); //学院ID
objvUsersEN.CollegeName = objRow[convUsers.CollegeName] == DBNull.Value ? null : objRow[convUsers.CollegeName].ToString().Trim(); //学院名称
objvUsersEN.CollegeNameA = objRow[convUsers.CollegeNameA] == DBNull.Value ? null : objRow[convUsers.CollegeNameA].ToString().Trim(); //学院名称简写
objvUsersEN.IdXzMajor = objRow[convUsers.IdXzMajor] == DBNull.Value ? null : objRow[convUsers.IdXzMajor].ToString().Trim(); //专业流水号
objvUsersEN.MajorName = objRow[convUsers.MajorName] == DBNull.Value ? null : objRow[convUsers.MajorName].ToString().Trim(); //专业名称
objvUsersEN.IsLeaved = TransNullToBool(objRow[convUsers.IsLeaved].ToString().Trim()); //是否离开
objvUsersEN.StuIdTeacherId = objRow[convUsers.StuIdTeacherId] == DBNull.Value ? null : objRow[convUsers.StuIdTeacherId].ToString().Trim(); //学工号
objvUsersEN.IdentityId = objRow[convUsers.IdentityId].ToString().Trim(); //身份Id
objvUsersEN.IdentityDesc = objRow[convUsers.IdentityDesc] == DBNull.Value ? null : objRow[convUsers.IdentityDesc].ToString().Trim(); //身份描述
objvUsersEN.AuditDate = objRow[convUsers.AuditDate] == DBNull.Value ? null : objRow[convUsers.AuditDate].ToString().Trim(); //AuditDate
objvUsersEN.AuditUser = objRow[convUsers.AuditUser] == DBNull.Value ? null : objRow[convUsers.AuditUser].ToString().Trim(); //AuditUser
objvUsersEN.IsAudit = TransNullToBool(objRow[convUsers.IsAudit].ToString().Trim()); //是否审核
objvUsersEN.IsRegister = TransNullToBool(objRow[convUsers.IsRegister].ToString().Trim()); //IsRegister
objvUsersEN.RegisterDate = objRow[convUsers.RegisterDate] == DBNull.Value ? null : objRow[convUsers.RegisterDate].ToString().Trim(); //RegisterDate
objvUsersEN.MobilePhone = objRow[convUsers.MobilePhone] == DBNull.Value ? null : objRow[convUsers.MobilePhone].ToString().Trim(); //手机
objvUsersEN.UpdDate = objRow[convUsers.UpdDate] == DBNull.Value ? null : objRow[convUsers.UpdDate].ToString().Trim(); //修改日期
objvUsersEN.UpdUser = objRow[convUsers.UpdUser] == DBNull.Value ? null : objRow[convUsers.UpdUser].ToString().Trim(); //修改人
objvUsersEN.Memo = objRow[convUsers.Memo] == DBNull.Value ? null : objRow[convUsers.Memo].ToString().Trim(); //备注
objvUsersEN.UserNameWithUserId = objRow[convUsers.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvUsersEN.OpenId = objRow[convUsers.OpenId] == DBNull.Value ? null : objRow[convUsers.OpenId].ToString().Trim(); //微信OpenId
objvUsersEN.AvatarsPicture = objRow[convUsers.AvatarsPicture] == DBNull.Value ? null : objRow[convUsers.AvatarsPicture].ToString().Trim(); //虚拟头像
objvUsersEN.Email = objRow[convUsers.Email] == DBNull.Value ? null : objRow[convUsers.Email].ToString().Trim(); //电子邮箱
objvUsersEN.PhoneNumber = objRow[convUsers.PhoneNumber] == DBNull.Value ? null : objRow[convUsers.PhoneNumber].ToString().Trim(); //电话
objvUsersEN.HeadPic = objRow[convUsers.HeadPic] == DBNull.Value ? null : objRow[convUsers.HeadPic].ToString().Trim(); //头像
objvUsersEN.IsGSuser = TransNullToBool(objRow[convUsers.IsGSuser].ToString().Trim()); //是否GS用户
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvUsersDA: GetObjByDataRowvUsers)", objException.Message));
}
objvUsersEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvUsersEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvUsersEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvUsersEN objvUsersEN = new clsvUsersEN();
try
{
objvUsersEN.UserId = objRow[convUsers.UserId].ToString().Trim(); //用户ID
objvUsersEN.UserName = objRow[convUsers.UserName] == DBNull.Value ? null : objRow[convUsers.UserName].ToString().Trim(); //用户名
objvUsersEN.UserStateId = objRow[convUsers.UserStateId].ToString().Trim(); //用户状态Id
objvUsersEN.UserStateName = objRow[convUsers.UserStateName] == DBNull.Value ? null : objRow[convUsers.UserStateName].ToString().Trim(); //用户状态名
objvUsersEN.Password = objRow[convUsers.Password] == DBNull.Value ? null : objRow[convUsers.Password].ToString().Trim(); //口令
objvUsersEN.IsGpUser = TransNullToBool(objRow[convUsers.IsGpUser].ToString().Trim()); //是否Gp用户
objvUsersEN.BeginYearMonth = objRow[convUsers.BeginYearMonth] == DBNull.Value ? null : objRow[convUsers.BeginYearMonth].ToString().Trim(); //开始年月
objvUsersEN.EndYearMonth = objRow[convUsers.EndYearMonth] == DBNull.Value ? null : objRow[convUsers.EndYearMonth].ToString().Trim(); //结束年月
objvUsersEN.IdGradeBase = objRow[convUsers.IdGradeBase] == DBNull.Value ? null : objRow[convUsers.IdGradeBase].ToString().Trim(); //年级流水号
objvUsersEN.GradeBaseName = objRow[convUsers.GradeBaseName] == DBNull.Value ? null : objRow[convUsers.GradeBaseName].ToString().Trim(); //年级名称
objvUsersEN.IdXzCollege = objRow[convUsers.IdXzCollege] == DBNull.Value ? null : objRow[convUsers.IdXzCollege].ToString().Trim(); //学院流水号
objvUsersEN.CollegeId = objRow[convUsers.CollegeId] == DBNull.Value ? null : objRow[convUsers.CollegeId].ToString().Trim(); //学院ID
objvUsersEN.CollegeName = objRow[convUsers.CollegeName] == DBNull.Value ? null : objRow[convUsers.CollegeName].ToString().Trim(); //学院名称
objvUsersEN.CollegeNameA = objRow[convUsers.CollegeNameA] == DBNull.Value ? null : objRow[convUsers.CollegeNameA].ToString().Trim(); //学院名称简写
objvUsersEN.IdXzMajor = objRow[convUsers.IdXzMajor] == DBNull.Value ? null : objRow[convUsers.IdXzMajor].ToString().Trim(); //专业流水号
objvUsersEN.MajorName = objRow[convUsers.MajorName] == DBNull.Value ? null : objRow[convUsers.MajorName].ToString().Trim(); //专业名称
objvUsersEN.IsLeaved = TransNullToBool(objRow[convUsers.IsLeaved].ToString().Trim()); //是否离开
objvUsersEN.StuIdTeacherId = objRow[convUsers.StuIdTeacherId] == DBNull.Value ? null : objRow[convUsers.StuIdTeacherId].ToString().Trim(); //学工号
objvUsersEN.IdentityId = objRow[convUsers.IdentityId].ToString().Trim(); //身份Id
objvUsersEN.IdentityDesc = objRow[convUsers.IdentityDesc] == DBNull.Value ? null : objRow[convUsers.IdentityDesc].ToString().Trim(); //身份描述
objvUsersEN.AuditDate = objRow[convUsers.AuditDate] == DBNull.Value ? null : objRow[convUsers.AuditDate].ToString().Trim(); //AuditDate
objvUsersEN.AuditUser = objRow[convUsers.AuditUser] == DBNull.Value ? null : objRow[convUsers.AuditUser].ToString().Trim(); //AuditUser
objvUsersEN.IsAudit = TransNullToBool(objRow[convUsers.IsAudit].ToString().Trim()); //是否审核
objvUsersEN.IsRegister = TransNullToBool(objRow[convUsers.IsRegister].ToString().Trim()); //IsRegister
objvUsersEN.RegisterDate = objRow[convUsers.RegisterDate] == DBNull.Value ? null : objRow[convUsers.RegisterDate].ToString().Trim(); //RegisterDate
objvUsersEN.MobilePhone = objRow[convUsers.MobilePhone] == DBNull.Value ? null : objRow[convUsers.MobilePhone].ToString().Trim(); //手机
objvUsersEN.UpdDate = objRow[convUsers.UpdDate] == DBNull.Value ? null : objRow[convUsers.UpdDate].ToString().Trim(); //修改日期
objvUsersEN.UpdUser = objRow[convUsers.UpdUser] == DBNull.Value ? null : objRow[convUsers.UpdUser].ToString().Trim(); //修改人
objvUsersEN.Memo = objRow[convUsers.Memo] == DBNull.Value ? null : objRow[convUsers.Memo].ToString().Trim(); //备注
objvUsersEN.UserNameWithUserId = objRow[convUsers.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvUsersEN.OpenId = objRow[convUsers.OpenId] == DBNull.Value ? null : objRow[convUsers.OpenId].ToString().Trim(); //微信OpenId
objvUsersEN.AvatarsPicture = objRow[convUsers.AvatarsPicture] == DBNull.Value ? null : objRow[convUsers.AvatarsPicture].ToString().Trim(); //虚拟头像
objvUsersEN.Email = objRow[convUsers.Email] == DBNull.Value ? null : objRow[convUsers.Email].ToString().Trim(); //电子邮箱
objvUsersEN.PhoneNumber = objRow[convUsers.PhoneNumber] == DBNull.Value ? null : objRow[convUsers.PhoneNumber].ToString().Trim(); //电话
objvUsersEN.HeadPic = objRow[convUsers.HeadPic] == DBNull.Value ? null : objRow[convUsers.HeadPic].ToString().Trim(); //头像
objvUsersEN.IsGSuser = TransNullToBool(objRow[convUsers.IsGSuser].ToString().Trim()); //是否GS用户
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvUsersDA: GetObjByDataRow)", objException.Message));
}
objvUsersEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvUsersEN;
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
objSQL = clsvUsersDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvUsersEN._CurrTabName, convUsers.UserId, 18, "");
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
objSQL = clsvUsersDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvUsersEN._CurrTabName, convUsers.UserId, 18, strPrefix);
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
 objSQL = clsvUsersDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select UserId from vUsers where " + strCondition;
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
 objSQL = clsvUsersDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select UserId from vUsers where " + strCondition;
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
 objSQL = clsvUsersDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vUsers", "UserId = " + "'"+ strUserId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvUsersDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUsersDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vUsers", strCondition))
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
objSQL = clsvUsersDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vUsers");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvUsersENS">源对象</param>
 /// <param name = "objvUsersENT">目标对象</param>
public void CopyTo(clsvUsersEN objvUsersENS, clsvUsersEN objvUsersENT)
{
objvUsersENT.UserId = objvUsersENS.UserId; //用户ID
objvUsersENT.UserName = objvUsersENS.UserName; //用户名
objvUsersENT.UserStateId = objvUsersENS.UserStateId; //用户状态Id
objvUsersENT.UserStateName = objvUsersENS.UserStateName; //用户状态名
objvUsersENT.Password = objvUsersENS.Password; //口令
objvUsersENT.IsGpUser = objvUsersENS.IsGpUser; //是否Gp用户
objvUsersENT.BeginYearMonth = objvUsersENS.BeginYearMonth; //开始年月
objvUsersENT.EndYearMonth = objvUsersENS.EndYearMonth; //结束年月
objvUsersENT.IdGradeBase = objvUsersENS.IdGradeBase; //年级流水号
objvUsersENT.GradeBaseName = objvUsersENS.GradeBaseName; //年级名称
objvUsersENT.IdXzCollege = objvUsersENS.IdXzCollege; //学院流水号
objvUsersENT.CollegeId = objvUsersENS.CollegeId; //学院ID
objvUsersENT.CollegeName = objvUsersENS.CollegeName; //学院名称
objvUsersENT.CollegeNameA = objvUsersENS.CollegeNameA; //学院名称简写
objvUsersENT.IdXzMajor = objvUsersENS.IdXzMajor; //专业流水号
objvUsersENT.MajorName = objvUsersENS.MajorName; //专业名称
objvUsersENT.IsLeaved = objvUsersENS.IsLeaved; //是否离开
objvUsersENT.StuIdTeacherId = objvUsersENS.StuIdTeacherId; //学工号
objvUsersENT.IdentityId = objvUsersENS.IdentityId; //身份Id
objvUsersENT.IdentityDesc = objvUsersENS.IdentityDesc; //身份描述
objvUsersENT.AuditDate = objvUsersENS.AuditDate; //AuditDate
objvUsersENT.AuditUser = objvUsersENS.AuditUser; //AuditUser
objvUsersENT.IsAudit = objvUsersENS.IsAudit; //是否审核
objvUsersENT.IsRegister = objvUsersENS.IsRegister; //IsRegister
objvUsersENT.RegisterDate = objvUsersENS.RegisterDate; //RegisterDate
objvUsersENT.MobilePhone = objvUsersENS.MobilePhone; //手机
objvUsersENT.UpdDate = objvUsersENS.UpdDate; //修改日期
objvUsersENT.UpdUser = objvUsersENS.UpdUser; //修改人
objvUsersENT.Memo = objvUsersENS.Memo; //备注
objvUsersENT.UserNameWithUserId = objvUsersENS.UserNameWithUserId; //UserNameWithUserId
objvUsersENT.OpenId = objvUsersENS.OpenId; //微信OpenId
objvUsersENT.AvatarsPicture = objvUsersENS.AvatarsPicture; //虚拟头像
objvUsersENT.Email = objvUsersENS.Email; //电子邮箱
objvUsersENT.PhoneNumber = objvUsersENS.PhoneNumber; //电话
objvUsersENT.HeadPic = objvUsersENS.HeadPic; //头像
objvUsersENT.IsGSuser = objvUsersENS.IsGSuser; //是否GS用户
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvUsersEN objvUsersEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvUsersEN.UserId, 18, convUsers.UserId);
clsCheckSql.CheckFieldLen(objvUsersEN.UserName, 30, convUsers.UserName);
clsCheckSql.CheckFieldLen(objvUsersEN.UserStateId, 2, convUsers.UserStateId);
clsCheckSql.CheckFieldLen(objvUsersEN.UserStateName, 20, convUsers.UserStateName);
clsCheckSql.CheckFieldLen(objvUsersEN.Password, 20, convUsers.Password);
clsCheckSql.CheckFieldLen(objvUsersEN.BeginYearMonth, 8, convUsers.BeginYearMonth);
clsCheckSql.CheckFieldLen(objvUsersEN.EndYearMonth, 8, convUsers.EndYearMonth);
clsCheckSql.CheckFieldLen(objvUsersEN.IdGradeBase, 4, convUsers.IdGradeBase);
clsCheckSql.CheckFieldLen(objvUsersEN.GradeBaseName, 50, convUsers.GradeBaseName);
clsCheckSql.CheckFieldLen(objvUsersEN.IdXzCollege, 4, convUsers.IdXzCollege);
clsCheckSql.CheckFieldLen(objvUsersEN.CollegeId, 4, convUsers.CollegeId);
clsCheckSql.CheckFieldLen(objvUsersEN.CollegeName, 100, convUsers.CollegeName);
clsCheckSql.CheckFieldLen(objvUsersEN.CollegeNameA, 12, convUsers.CollegeNameA);
clsCheckSql.CheckFieldLen(objvUsersEN.IdXzMajor, 8, convUsers.IdXzMajor);
clsCheckSql.CheckFieldLen(objvUsersEN.MajorName, 100, convUsers.MajorName);
clsCheckSql.CheckFieldLen(objvUsersEN.StuIdTeacherId, 20, convUsers.StuIdTeacherId);
clsCheckSql.CheckFieldLen(objvUsersEN.IdentityId, 2, convUsers.IdentityId);
clsCheckSql.CheckFieldLen(objvUsersEN.IdentityDesc, 20, convUsers.IdentityDesc);
clsCheckSql.CheckFieldLen(objvUsersEN.AuditDate, 14, convUsers.AuditDate);
clsCheckSql.CheckFieldLen(objvUsersEN.AuditUser, 18, convUsers.AuditUser);
clsCheckSql.CheckFieldLen(objvUsersEN.RegisterDate, 14, convUsers.RegisterDate);
clsCheckSql.CheckFieldLen(objvUsersEN.MobilePhone, 20, convUsers.MobilePhone);
clsCheckSql.CheckFieldLen(objvUsersEN.UpdDate, 20, convUsers.UpdDate);
clsCheckSql.CheckFieldLen(objvUsersEN.UpdUser, 20, convUsers.UpdUser);
clsCheckSql.CheckFieldLen(objvUsersEN.Memo, 1000, convUsers.Memo);
clsCheckSql.CheckFieldLen(objvUsersEN.UserNameWithUserId, 51, convUsers.UserNameWithUserId);
clsCheckSql.CheckFieldLen(objvUsersEN.OpenId, 50, convUsers.OpenId);
clsCheckSql.CheckFieldLen(objvUsersEN.AvatarsPicture, 100, convUsers.AvatarsPicture);
clsCheckSql.CheckFieldLen(objvUsersEN.Email, 100, convUsers.Email);
clsCheckSql.CheckFieldLen(objvUsersEN.PhoneNumber, 15, convUsers.PhoneNumber);
clsCheckSql.CheckFieldLen(objvUsersEN.HeadPic, 500, convUsers.HeadPic);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvUsersEN.UserId, convUsers.UserId);
clsCheckSql.CheckSqlInjection4Field(objvUsersEN.UserName, convUsers.UserName);
clsCheckSql.CheckSqlInjection4Field(objvUsersEN.UserStateId, convUsers.UserStateId);
clsCheckSql.CheckSqlInjection4Field(objvUsersEN.UserStateName, convUsers.UserStateName);
clsCheckSql.CheckSqlInjection4Field(objvUsersEN.Password, convUsers.Password);
clsCheckSql.CheckSqlInjection4Field(objvUsersEN.BeginYearMonth, convUsers.BeginYearMonth);
clsCheckSql.CheckSqlInjection4Field(objvUsersEN.EndYearMonth, convUsers.EndYearMonth);
clsCheckSql.CheckSqlInjection4Field(objvUsersEN.IdGradeBase, convUsers.IdGradeBase);
clsCheckSql.CheckSqlInjection4Field(objvUsersEN.GradeBaseName, convUsers.GradeBaseName);
clsCheckSql.CheckSqlInjection4Field(objvUsersEN.IdXzCollege, convUsers.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvUsersEN.CollegeId, convUsers.CollegeId);
clsCheckSql.CheckSqlInjection4Field(objvUsersEN.CollegeName, convUsers.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvUsersEN.CollegeNameA, convUsers.CollegeNameA);
clsCheckSql.CheckSqlInjection4Field(objvUsersEN.IdXzMajor, convUsers.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objvUsersEN.MajorName, convUsers.MajorName);
clsCheckSql.CheckSqlInjection4Field(objvUsersEN.StuIdTeacherId, convUsers.StuIdTeacherId);
clsCheckSql.CheckSqlInjection4Field(objvUsersEN.IdentityId, convUsers.IdentityId);
clsCheckSql.CheckSqlInjection4Field(objvUsersEN.IdentityDesc, convUsers.IdentityDesc);
clsCheckSql.CheckSqlInjection4Field(objvUsersEN.AuditDate, convUsers.AuditDate);
clsCheckSql.CheckSqlInjection4Field(objvUsersEN.AuditUser, convUsers.AuditUser);
clsCheckSql.CheckSqlInjection4Field(objvUsersEN.RegisterDate, convUsers.RegisterDate);
clsCheckSql.CheckSqlInjection4Field(objvUsersEN.MobilePhone, convUsers.MobilePhone);
clsCheckSql.CheckSqlInjection4Field(objvUsersEN.UpdDate, convUsers.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvUsersEN.UpdUser, convUsers.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvUsersEN.Memo, convUsers.Memo);
clsCheckSql.CheckSqlInjection4Field(objvUsersEN.UserNameWithUserId, convUsers.UserNameWithUserId);
clsCheckSql.CheckSqlInjection4Field(objvUsersEN.OpenId, convUsers.OpenId);
clsCheckSql.CheckSqlInjection4Field(objvUsersEN.AvatarsPicture, convUsers.AvatarsPicture);
clsCheckSql.CheckSqlInjection4Field(objvUsersEN.Email, convUsers.Email);
clsCheckSql.CheckSqlInjection4Field(objvUsersEN.PhoneNumber, convUsers.PhoneNumber);
clsCheckSql.CheckSqlInjection4Field(objvUsersEN.HeadPic, convUsers.HeadPic);
//检查外键字段长度
 objvUsersEN._IsCheckProperty = true;
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
 objSQL = clsvUsersDA.GetSpecSQLObj();
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
 objSQL = clsvUsersDA.GetSpecSQLObj();
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
 objSQL = clsvUsersDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvUsersEN._CurrTabName);
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
 objSQL = clsvUsersDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvUsersEN._CurrTabName, strCondition);
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
 objSQL = clsvUsersDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}