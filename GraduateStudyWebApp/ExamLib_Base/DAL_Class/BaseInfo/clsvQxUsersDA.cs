
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxUsersDA
 表名:vQxUsers(01120564)
 * 版本:2024.05.05.1(服务器:WIN-SRV103-116)
 日期:2024/05/19 00:14:00
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:基本信息维护(BaseInfo)
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
 /// vQx用户(vQxUsers)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvQxUsersDA : clsCommBase4DA
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
 return clsvQxUsersEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvQxUsersEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQxUsersEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvQxUsersEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvQxUsersEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:vQxUsers中,检查关键字,长度不正确!(clsvQxUsersDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strUserId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vQxUsers中,关键字不能为空 或 null!(clsvQxUsersDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strUserId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvQxUsersDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvQxUsersDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsersDA.GetSpecSQLObj();
strSQL = "Select * from vQxUsers where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vQxUsers(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvQxUsersDA: GetDataTable_vQxUsers)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsersDA.GetSpecSQLObj();
strSQL = "Select * from vQxUsers where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvQxUsersDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsersDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvQxUsersDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsersDA.GetSpecSQLObj();
strSQL = "Select * from vQxUsers where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvQxUsersDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsersDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvQxUsersDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsersDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxUsers where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxUsers where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvQxUsersDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsersDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vQxUsers where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvQxUsersDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsersDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vQxUsers.* from vQxUsers Left Join {1} on {2} where {3} and vQxUsers.UserId not in (Select top {5} vQxUsers.UserId from vQxUsers Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxUsers where {1} and UserId not in (Select top {2} UserId from vQxUsers where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxUsers where {1} and UserId not in (Select top {3} UserId from vQxUsers where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvQxUsersDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsersDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vQxUsers.* from vQxUsers Left Join {1} on {2} where {3} and vQxUsers.UserId not in (Select top {5} vQxUsers.UserId from vQxUsers Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxUsers where {1} and UserId not in (Select top {2} UserId from vQxUsers where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxUsers where {1} and UserId not in (Select top {3} UserId from vQxUsers where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvQxUsersEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvQxUsersDA:GetObjLst)", objException.Message));
}
List<clsvQxUsersEN> arrObjLst = new List<clsvQxUsersEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsersDA.GetSpecSQLObj();
strSQL = "Select * from vQxUsers where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUsersEN objvQxUsersEN = new clsvQxUsersEN();
try
{
objvQxUsersEN.UserId = objRow[convQxUsers.UserId].ToString().Trim(); //用户ID
objvQxUsersEN.UserName = objRow[convQxUsers.UserName].ToString().Trim(); //用户名
objvQxUsersEN.UserStateId = objRow[convQxUsers.UserStateId].ToString().Trim(); //用户状态Id
objvQxUsersEN.Memo = objRow[convQxUsers.Memo] == DBNull.Value ? null : objRow[convQxUsers.Memo].ToString().Trim(); //备注
objvQxUsersEN.UserStateName = objRow[convQxUsers.UserStateName] == DBNull.Value ? null : objRow[convQxUsers.UserStateName].ToString().Trim(); //用户状态名
objvQxUsersEN.DepartmentId = objRow[convQxUsers.DepartmentId] == DBNull.Value ? null : objRow[convQxUsers.DepartmentId].ToString().Trim(); //部门Id
objvQxUsersEN.UpDepartmentId = objRow[convQxUsers.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers.UpDepartmentId].ToString().Trim(); //UpDepartmentId
objvQxUsersEN.DepartmentName = objRow[convQxUsers.DepartmentName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentName].ToString().Trim(); //部门名称
objvQxUsersEN.UpDepartmentName = objRow[convQxUsers.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers.UpDepartmentName].ToString().Trim(); //UpDepartmentName
objvQxUsersEN.DepartmentTypeName = objRow[convQxUsers.DepartmentTypeName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentTypeName].ToString().Trim(); //DepartmentTypeName
objvQxUsersEN.DepartmentTypeId = objRow[convQxUsers.DepartmentTypeId] == DBNull.Value ? null : objRow[convQxUsers.DepartmentTypeId].ToString().Trim(); //DepartmentTypeId
objvQxUsersEN.DepartmentAbbrName = objRow[convQxUsers.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentAbbrName].ToString().Trim(); //DepartmentAbbrName
objvQxUsersEN.UpdDate = objRow[convQxUsers.UpdDate] == DBNull.Value ? null : objRow[convQxUsers.UpdDate].ToString().Trim(); //修改日期
objvQxUsersEN.UpdUser = objRow[convQxUsers.UpdUser] == DBNull.Value ? null : objRow[convQxUsers.UpdUser].ToString().Trim(); //修改人
objvQxUsersEN.EffitiveBeginDate = objRow[convQxUsers.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objvQxUsersEN.EffitiveEndDate = objRow[convQxUsers.EffitiveEndDate].ToString().Trim(); //有效结束日期
objvQxUsersEN.StuTeacherId = objRow[convQxUsers.StuTeacherId].ToString().Trim(); //学工号
objvQxUsersEN.IdentityId = objRow[convQxUsers.IdentityId] == DBNull.Value ? null : objRow[convQxUsers.IdentityId].ToString().Trim(); //身份Id
objvQxUsersEN.Password = objRow[convQxUsers.Password] == DBNull.Value ? null : objRow[convQxUsers.Password].ToString().Trim(); //口令
objvQxUsersEN.IdentityDesc = objRow[convQxUsers.IdentityDesc] == DBNull.Value ? null : objRow[convQxUsers.IdentityDesc].ToString().Trim(); //身份描述
objvQxUsersEN.IsSynch = TransNullToBool(objRow[convQxUsers.IsSynch].ToString().Trim()); //是否同步
objvQxUsersEN.SynchDate = objRow[convQxUsers.SynchDate] == DBNull.Value ? null : objRow[convQxUsers.SynchDate].ToString().Trim(); //同步日期
objvQxUsersEN.OpenId = objRow[convQxUsers.OpenId] == DBNull.Value ? null : objRow[convQxUsers.OpenId].ToString().Trim(); //微信OpenId
objvQxUsersEN.CollegeName = objRow[convQxUsers.CollegeName] == DBNull.Value ? null : objRow[convQxUsers.CollegeName].ToString().Trim(); //学院名称
objvQxUsersEN.IdXzCollege = objRow[convQxUsers.IdXzCollege] == DBNull.Value ? null : objRow[convQxUsers.IdXzCollege].ToString().Trim(); //学院流水号
objvQxUsersEN.Email = objRow[convQxUsers.Email] == DBNull.Value ? null : objRow[convQxUsers.Email].ToString().Trim(); //电子邮箱
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvQxUsersDA: GetObjLst)", objException.Message));
}
objvQxUsersEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvQxUsersEN);
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
public List<clsvQxUsersEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvQxUsersDA:GetObjLstByTabName)", objException.Message));
}
List<clsvQxUsersEN> arrObjLst = new List<clsvQxUsersEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsersDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUsersEN objvQxUsersEN = new clsvQxUsersEN();
try
{
objvQxUsersEN.UserId = objRow[convQxUsers.UserId].ToString().Trim(); //用户ID
objvQxUsersEN.UserName = objRow[convQxUsers.UserName].ToString().Trim(); //用户名
objvQxUsersEN.UserStateId = objRow[convQxUsers.UserStateId].ToString().Trim(); //用户状态Id
objvQxUsersEN.Memo = objRow[convQxUsers.Memo] == DBNull.Value ? null : objRow[convQxUsers.Memo].ToString().Trim(); //备注
objvQxUsersEN.UserStateName = objRow[convQxUsers.UserStateName] == DBNull.Value ? null : objRow[convQxUsers.UserStateName].ToString().Trim(); //用户状态名
objvQxUsersEN.DepartmentId = objRow[convQxUsers.DepartmentId] == DBNull.Value ? null : objRow[convQxUsers.DepartmentId].ToString().Trim(); //部门Id
objvQxUsersEN.UpDepartmentId = objRow[convQxUsers.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers.UpDepartmentId].ToString().Trim(); //UpDepartmentId
objvQxUsersEN.DepartmentName = objRow[convQxUsers.DepartmentName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentName].ToString().Trim(); //部门名称
objvQxUsersEN.UpDepartmentName = objRow[convQxUsers.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers.UpDepartmentName].ToString().Trim(); //UpDepartmentName
objvQxUsersEN.DepartmentTypeName = objRow[convQxUsers.DepartmentTypeName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentTypeName].ToString().Trim(); //DepartmentTypeName
objvQxUsersEN.DepartmentTypeId = objRow[convQxUsers.DepartmentTypeId] == DBNull.Value ? null : objRow[convQxUsers.DepartmentTypeId].ToString().Trim(); //DepartmentTypeId
objvQxUsersEN.DepartmentAbbrName = objRow[convQxUsers.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentAbbrName].ToString().Trim(); //DepartmentAbbrName
objvQxUsersEN.UpdDate = objRow[convQxUsers.UpdDate] == DBNull.Value ? null : objRow[convQxUsers.UpdDate].ToString().Trim(); //修改日期
objvQxUsersEN.UpdUser = objRow[convQxUsers.UpdUser] == DBNull.Value ? null : objRow[convQxUsers.UpdUser].ToString().Trim(); //修改人
objvQxUsersEN.EffitiveBeginDate = objRow[convQxUsers.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objvQxUsersEN.EffitiveEndDate = objRow[convQxUsers.EffitiveEndDate].ToString().Trim(); //有效结束日期
objvQxUsersEN.StuTeacherId = objRow[convQxUsers.StuTeacherId].ToString().Trim(); //学工号
objvQxUsersEN.IdentityId = objRow[convQxUsers.IdentityId] == DBNull.Value ? null : objRow[convQxUsers.IdentityId].ToString().Trim(); //身份Id
objvQxUsersEN.Password = objRow[convQxUsers.Password] == DBNull.Value ? null : objRow[convQxUsers.Password].ToString().Trim(); //口令
objvQxUsersEN.IdentityDesc = objRow[convQxUsers.IdentityDesc] == DBNull.Value ? null : objRow[convQxUsers.IdentityDesc].ToString().Trim(); //身份描述
objvQxUsersEN.IsSynch = TransNullToBool(objRow[convQxUsers.IsSynch].ToString().Trim()); //是否同步
objvQxUsersEN.SynchDate = objRow[convQxUsers.SynchDate] == DBNull.Value ? null : objRow[convQxUsers.SynchDate].ToString().Trim(); //同步日期
objvQxUsersEN.OpenId = objRow[convQxUsers.OpenId] == DBNull.Value ? null : objRow[convQxUsers.OpenId].ToString().Trim(); //微信OpenId
objvQxUsersEN.CollegeName = objRow[convQxUsers.CollegeName] == DBNull.Value ? null : objRow[convQxUsers.CollegeName].ToString().Trim(); //学院名称
objvQxUsersEN.IdXzCollege = objRow[convQxUsers.IdXzCollege] == DBNull.Value ? null : objRow[convQxUsers.IdXzCollege].ToString().Trim(); //学院流水号
objvQxUsersEN.Email = objRow[convQxUsers.Email] == DBNull.Value ? null : objRow[convQxUsers.Email].ToString().Trim(); //电子邮箱
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvQxUsersDA: GetObjLst)", objException.Message));
}
objvQxUsersEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvQxUsersEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvQxUsers(ref clsvQxUsersEN objvQxUsersEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsersDA.GetSpecSQLObj();
strSQL = "Select * from vQxUsers where UserId = " + "'"+ objvQxUsersEN.UserId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvQxUsersEN.UserId = objDT.Rows[0][convQxUsers.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvQxUsersEN.UserName = objDT.Rows[0][convQxUsers.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvQxUsersEN.UserStateId = objDT.Rows[0][convQxUsers.UserStateId].ToString().Trim(); //用户状态Id(字段类型:char,字段长度:2,是否可空:True)
 objvQxUsersEN.Memo = objDT.Rows[0][convQxUsers.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvQxUsersEN.UserStateName = objDT.Rows[0][convQxUsers.UserStateName].ToString().Trim(); //用户状态名(字段类型:varchar,字段长度:20,是否可空:True)
 objvQxUsersEN.DepartmentId = objDT.Rows[0][convQxUsers.DepartmentId].ToString().Trim(); //部门Id(字段类型:varchar,字段长度:8,是否可空:True)
 objvQxUsersEN.UpDepartmentId = objDT.Rows[0][convQxUsers.UpDepartmentId].ToString().Trim(); //UpDepartmentId(字段类型:varchar,字段长度:6,是否可空:True)
 objvQxUsersEN.DepartmentName = objDT.Rows[0][convQxUsers.DepartmentName].ToString().Trim(); //部门名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvQxUsersEN.UpDepartmentName = objDT.Rows[0][convQxUsers.UpDepartmentName].ToString().Trim(); //UpDepartmentName(字段类型:varchar,字段长度:100,是否可空:True)
 objvQxUsersEN.DepartmentTypeName = objDT.Rows[0][convQxUsers.DepartmentTypeName].ToString().Trim(); //DepartmentTypeName(字段类型:varchar,字段长度:50,是否可空:True)
 objvQxUsersEN.DepartmentTypeId = objDT.Rows[0][convQxUsers.DepartmentTypeId].ToString().Trim(); //DepartmentTypeId(字段类型:char,字段长度:2,是否可空:True)
 objvQxUsersEN.DepartmentAbbrName = objDT.Rows[0][convQxUsers.DepartmentAbbrName].ToString().Trim(); //DepartmentAbbrName(字段类型:varchar,字段长度:12,是否可空:True)
 objvQxUsersEN.UpdDate = objDT.Rows[0][convQxUsers.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvQxUsersEN.UpdUser = objDT.Rows[0][convQxUsers.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvQxUsersEN.EffitiveBeginDate = objDT.Rows[0][convQxUsers.EffitiveBeginDate].ToString().Trim(); //有效开始日期(字段类型:varchar,字段长度:14,是否可空:False)
 objvQxUsersEN.EffitiveEndDate = objDT.Rows[0][convQxUsers.EffitiveEndDate].ToString().Trim(); //有效结束日期(字段类型:varchar,字段长度:14,是否可空:False)
 objvQxUsersEN.StuTeacherId = objDT.Rows[0][convQxUsers.StuTeacherId].ToString().Trim(); //学工号(字段类型:varchar,字段长度:20,是否可空:True)
 objvQxUsersEN.IdentityId = objDT.Rows[0][convQxUsers.IdentityId].ToString().Trim(); //身份Id(字段类型:char,字段长度:2,是否可空:False)
 objvQxUsersEN.Password = objDT.Rows[0][convQxUsers.Password].ToString().Trim(); //口令(字段类型:varchar,字段长度:20,是否可空:True)
 objvQxUsersEN.IdentityDesc = objDT.Rows[0][convQxUsers.IdentityDesc].ToString().Trim(); //身份描述(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUsersEN.IsSynch = TransNullToBool(objDT.Rows[0][convQxUsers.IsSynch].ToString().Trim()); //是否同步(字段类型:bit,字段长度:1,是否可空:False)
 objvQxUsersEN.SynchDate = objDT.Rows[0][convQxUsers.SynchDate].ToString().Trim(); //同步日期(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxUsersEN.OpenId = objDT.Rows[0][convQxUsers.OpenId].ToString().Trim(); //微信OpenId(字段类型:varchar,字段长度:50,是否可空:True)
 objvQxUsersEN.CollegeName = objDT.Rows[0][convQxUsers.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvQxUsersEN.IdXzCollege = objDT.Rows[0][convQxUsers.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvQxUsersEN.Email = objDT.Rows[0][convQxUsers.Email].ToString().Trim(); //电子邮箱(字段类型:varchar,字段长度:100,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvQxUsersDA: GetvQxUsers)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strUserId">表关键字</param>
 /// <returns>表对象</returns>
public clsvQxUsersEN GetObjByUserId(string strUserId)
{
CheckPrimaryKey(strUserId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsersDA.GetSpecSQLObj();
strSQL = "Select * from vQxUsers where UserId = " + "'"+ strUserId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvQxUsersEN objvQxUsersEN = new clsvQxUsersEN();
try
{
 objvQxUsersEN.UserId = objRow[convQxUsers.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvQxUsersEN.UserName = objRow[convQxUsers.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvQxUsersEN.UserStateId = objRow[convQxUsers.UserStateId].ToString().Trim(); //用户状态Id(字段类型:char,字段长度:2,是否可空:True)
 objvQxUsersEN.Memo = objRow[convQxUsers.Memo] == DBNull.Value ? null : objRow[convQxUsers.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvQxUsersEN.UserStateName = objRow[convQxUsers.UserStateName] == DBNull.Value ? null : objRow[convQxUsers.UserStateName].ToString().Trim(); //用户状态名(字段类型:varchar,字段长度:20,是否可空:True)
 objvQxUsersEN.DepartmentId = objRow[convQxUsers.DepartmentId] == DBNull.Value ? null : objRow[convQxUsers.DepartmentId].ToString().Trim(); //部门Id(字段类型:varchar,字段长度:8,是否可空:True)
 objvQxUsersEN.UpDepartmentId = objRow[convQxUsers.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers.UpDepartmentId].ToString().Trim(); //UpDepartmentId(字段类型:varchar,字段长度:6,是否可空:True)
 objvQxUsersEN.DepartmentName = objRow[convQxUsers.DepartmentName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentName].ToString().Trim(); //部门名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvQxUsersEN.UpDepartmentName = objRow[convQxUsers.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers.UpDepartmentName].ToString().Trim(); //UpDepartmentName(字段类型:varchar,字段长度:100,是否可空:True)
 objvQxUsersEN.DepartmentTypeName = objRow[convQxUsers.DepartmentTypeName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentTypeName].ToString().Trim(); //DepartmentTypeName(字段类型:varchar,字段长度:50,是否可空:True)
 objvQxUsersEN.DepartmentTypeId = objRow[convQxUsers.DepartmentTypeId] == DBNull.Value ? null : objRow[convQxUsers.DepartmentTypeId].ToString().Trim(); //DepartmentTypeId(字段类型:char,字段长度:2,是否可空:True)
 objvQxUsersEN.DepartmentAbbrName = objRow[convQxUsers.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentAbbrName].ToString().Trim(); //DepartmentAbbrName(字段类型:varchar,字段长度:12,是否可空:True)
 objvQxUsersEN.UpdDate = objRow[convQxUsers.UpdDate] == DBNull.Value ? null : objRow[convQxUsers.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvQxUsersEN.UpdUser = objRow[convQxUsers.UpdUser] == DBNull.Value ? null : objRow[convQxUsers.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvQxUsersEN.EffitiveBeginDate = objRow[convQxUsers.EffitiveBeginDate].ToString().Trim(); //有效开始日期(字段类型:varchar,字段长度:14,是否可空:False)
 objvQxUsersEN.EffitiveEndDate = objRow[convQxUsers.EffitiveEndDate].ToString().Trim(); //有效结束日期(字段类型:varchar,字段长度:14,是否可空:False)
 objvQxUsersEN.StuTeacherId = objRow[convQxUsers.StuTeacherId].ToString().Trim(); //学工号(字段类型:varchar,字段长度:20,是否可空:True)
 objvQxUsersEN.IdentityId = objRow[convQxUsers.IdentityId] == DBNull.Value ? null : objRow[convQxUsers.IdentityId].ToString().Trim(); //身份Id(字段类型:char,字段长度:2,是否可空:False)
 objvQxUsersEN.Password = objRow[convQxUsers.Password] == DBNull.Value ? null : objRow[convQxUsers.Password].ToString().Trim(); //口令(字段类型:varchar,字段长度:20,是否可空:True)
 objvQxUsersEN.IdentityDesc = objRow[convQxUsers.IdentityDesc] == DBNull.Value ? null : objRow[convQxUsers.IdentityDesc].ToString().Trim(); //身份描述(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUsersEN.IsSynch = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers.IsSynch].ToString().Trim()); //是否同步(字段类型:bit,字段长度:1,是否可空:False)
 objvQxUsersEN.SynchDate = objRow[convQxUsers.SynchDate] == DBNull.Value ? null : objRow[convQxUsers.SynchDate].ToString().Trim(); //同步日期(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxUsersEN.OpenId = objRow[convQxUsers.OpenId] == DBNull.Value ? null : objRow[convQxUsers.OpenId].ToString().Trim(); //微信OpenId(字段类型:varchar,字段长度:50,是否可空:True)
 objvQxUsersEN.CollegeName = objRow[convQxUsers.CollegeName] == DBNull.Value ? null : objRow[convQxUsers.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvQxUsersEN.IdXzCollege = objRow[convQxUsers.IdXzCollege] == DBNull.Value ? null : objRow[convQxUsers.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvQxUsersEN.Email = objRow[convQxUsers.Email] == DBNull.Value ? null : objRow[convQxUsers.Email].ToString().Trim(); //电子邮箱(字段类型:varchar,字段长度:100,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvQxUsersDA: GetObjByUserId)", objException.Message));
}
return objvQxUsersEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvQxUsersEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvQxUsersDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsersDA.GetSpecSQLObj();
strSQL = "Select * from vQxUsers where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvQxUsersEN objvQxUsersEN = new clsvQxUsersEN()
{
UserId = objRow[convQxUsers.UserId].ToString().Trim(), //用户ID
UserName = objRow[convQxUsers.UserName].ToString().Trim(), //用户名
UserStateId = objRow[convQxUsers.UserStateId].ToString().Trim(), //用户状态Id
Memo = objRow[convQxUsers.Memo] == DBNull.Value ? null : objRow[convQxUsers.Memo].ToString().Trim(), //备注
UserStateName = objRow[convQxUsers.UserStateName] == DBNull.Value ? null : objRow[convQxUsers.UserStateName].ToString().Trim(), //用户状态名
DepartmentId = objRow[convQxUsers.DepartmentId] == DBNull.Value ? null : objRow[convQxUsers.DepartmentId].ToString().Trim(), //部门Id
UpDepartmentId = objRow[convQxUsers.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers.UpDepartmentId].ToString().Trim(), //UpDepartmentId
DepartmentName = objRow[convQxUsers.DepartmentName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentName].ToString().Trim(), //部门名称
UpDepartmentName = objRow[convQxUsers.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers.UpDepartmentName].ToString().Trim(), //UpDepartmentName
DepartmentTypeName = objRow[convQxUsers.DepartmentTypeName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentTypeName].ToString().Trim(), //DepartmentTypeName
DepartmentTypeId = objRow[convQxUsers.DepartmentTypeId] == DBNull.Value ? null : objRow[convQxUsers.DepartmentTypeId].ToString().Trim(), //DepartmentTypeId
DepartmentAbbrName = objRow[convQxUsers.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentAbbrName].ToString().Trim(), //DepartmentAbbrName
UpdDate = objRow[convQxUsers.UpdDate] == DBNull.Value ? null : objRow[convQxUsers.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convQxUsers.UpdUser] == DBNull.Value ? null : objRow[convQxUsers.UpdUser].ToString().Trim(), //修改人
EffitiveBeginDate = objRow[convQxUsers.EffitiveBeginDate].ToString().Trim(), //有效开始日期
EffitiveEndDate = objRow[convQxUsers.EffitiveEndDate].ToString().Trim(), //有效结束日期
StuTeacherId = objRow[convQxUsers.StuTeacherId].ToString().Trim(), //学工号
IdentityId = objRow[convQxUsers.IdentityId] == DBNull.Value ? null : objRow[convQxUsers.IdentityId].ToString().Trim(), //身份Id
Password = objRow[convQxUsers.Password] == DBNull.Value ? null : objRow[convQxUsers.Password].ToString().Trim(), //口令
IdentityDesc = objRow[convQxUsers.IdentityDesc] == DBNull.Value ? null : objRow[convQxUsers.IdentityDesc].ToString().Trim(), //身份描述
IsSynch = TransNullToBool(objRow[convQxUsers.IsSynch].ToString().Trim()), //是否同步
SynchDate = objRow[convQxUsers.SynchDate] == DBNull.Value ? null : objRow[convQxUsers.SynchDate].ToString().Trim(), //同步日期
OpenId = objRow[convQxUsers.OpenId] == DBNull.Value ? null : objRow[convQxUsers.OpenId].ToString().Trim(), //微信OpenId
CollegeName = objRow[convQxUsers.CollegeName] == DBNull.Value ? null : objRow[convQxUsers.CollegeName].ToString().Trim(), //学院名称
IdXzCollege = objRow[convQxUsers.IdXzCollege] == DBNull.Value ? null : objRow[convQxUsers.IdXzCollege].ToString().Trim(), //学院流水号
Email = objRow[convQxUsers.Email] == DBNull.Value ? null : objRow[convQxUsers.Email].ToString().Trim() //电子邮箱
};
objvQxUsersEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxUsersEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvQxUsersDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvQxUsersEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvQxUsersEN objvQxUsersEN = new clsvQxUsersEN();
try
{
objvQxUsersEN.UserId = objRow[convQxUsers.UserId].ToString().Trim(); //用户ID
objvQxUsersEN.UserName = objRow[convQxUsers.UserName].ToString().Trim(); //用户名
objvQxUsersEN.UserStateId = objRow[convQxUsers.UserStateId].ToString().Trim(); //用户状态Id
objvQxUsersEN.Memo = objRow[convQxUsers.Memo] == DBNull.Value ? null : objRow[convQxUsers.Memo].ToString().Trim(); //备注
objvQxUsersEN.UserStateName = objRow[convQxUsers.UserStateName] == DBNull.Value ? null : objRow[convQxUsers.UserStateName].ToString().Trim(); //用户状态名
objvQxUsersEN.DepartmentId = objRow[convQxUsers.DepartmentId] == DBNull.Value ? null : objRow[convQxUsers.DepartmentId].ToString().Trim(); //部门Id
objvQxUsersEN.UpDepartmentId = objRow[convQxUsers.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers.UpDepartmentId].ToString().Trim(); //UpDepartmentId
objvQxUsersEN.DepartmentName = objRow[convQxUsers.DepartmentName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentName].ToString().Trim(); //部门名称
objvQxUsersEN.UpDepartmentName = objRow[convQxUsers.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers.UpDepartmentName].ToString().Trim(); //UpDepartmentName
objvQxUsersEN.DepartmentTypeName = objRow[convQxUsers.DepartmentTypeName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentTypeName].ToString().Trim(); //DepartmentTypeName
objvQxUsersEN.DepartmentTypeId = objRow[convQxUsers.DepartmentTypeId] == DBNull.Value ? null : objRow[convQxUsers.DepartmentTypeId].ToString().Trim(); //DepartmentTypeId
objvQxUsersEN.DepartmentAbbrName = objRow[convQxUsers.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentAbbrName].ToString().Trim(); //DepartmentAbbrName
objvQxUsersEN.UpdDate = objRow[convQxUsers.UpdDate] == DBNull.Value ? null : objRow[convQxUsers.UpdDate].ToString().Trim(); //修改日期
objvQxUsersEN.UpdUser = objRow[convQxUsers.UpdUser] == DBNull.Value ? null : objRow[convQxUsers.UpdUser].ToString().Trim(); //修改人
objvQxUsersEN.EffitiveBeginDate = objRow[convQxUsers.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objvQxUsersEN.EffitiveEndDate = objRow[convQxUsers.EffitiveEndDate].ToString().Trim(); //有效结束日期
objvQxUsersEN.StuTeacherId = objRow[convQxUsers.StuTeacherId].ToString().Trim(); //学工号
objvQxUsersEN.IdentityId = objRow[convQxUsers.IdentityId] == DBNull.Value ? null : objRow[convQxUsers.IdentityId].ToString().Trim(); //身份Id
objvQxUsersEN.Password = objRow[convQxUsers.Password] == DBNull.Value ? null : objRow[convQxUsers.Password].ToString().Trim(); //口令
objvQxUsersEN.IdentityDesc = objRow[convQxUsers.IdentityDesc] == DBNull.Value ? null : objRow[convQxUsers.IdentityDesc].ToString().Trim(); //身份描述
objvQxUsersEN.IsSynch = TransNullToBool(objRow[convQxUsers.IsSynch].ToString().Trim()); //是否同步
objvQxUsersEN.SynchDate = objRow[convQxUsers.SynchDate] == DBNull.Value ? null : objRow[convQxUsers.SynchDate].ToString().Trim(); //同步日期
objvQxUsersEN.OpenId = objRow[convQxUsers.OpenId] == DBNull.Value ? null : objRow[convQxUsers.OpenId].ToString().Trim(); //微信OpenId
objvQxUsersEN.CollegeName = objRow[convQxUsers.CollegeName] == DBNull.Value ? null : objRow[convQxUsers.CollegeName].ToString().Trim(); //学院名称
objvQxUsersEN.IdXzCollege = objRow[convQxUsers.IdXzCollege] == DBNull.Value ? null : objRow[convQxUsers.IdXzCollege].ToString().Trim(); //学院流水号
objvQxUsersEN.Email = objRow[convQxUsers.Email] == DBNull.Value ? null : objRow[convQxUsers.Email].ToString().Trim(); //电子邮箱
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvQxUsersDA: GetObjByDataRowvQxUsers)", objException.Message));
}
objvQxUsersEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxUsersEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvQxUsersEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvQxUsersEN objvQxUsersEN = new clsvQxUsersEN();
try
{
objvQxUsersEN.UserId = objRow[convQxUsers.UserId].ToString().Trim(); //用户ID
objvQxUsersEN.UserName = objRow[convQxUsers.UserName].ToString().Trim(); //用户名
objvQxUsersEN.UserStateId = objRow[convQxUsers.UserStateId].ToString().Trim(); //用户状态Id
objvQxUsersEN.Memo = objRow[convQxUsers.Memo] == DBNull.Value ? null : objRow[convQxUsers.Memo].ToString().Trim(); //备注
objvQxUsersEN.UserStateName = objRow[convQxUsers.UserStateName] == DBNull.Value ? null : objRow[convQxUsers.UserStateName].ToString().Trim(); //用户状态名
objvQxUsersEN.DepartmentId = objRow[convQxUsers.DepartmentId] == DBNull.Value ? null : objRow[convQxUsers.DepartmentId].ToString().Trim(); //部门Id
objvQxUsersEN.UpDepartmentId = objRow[convQxUsers.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers.UpDepartmentId].ToString().Trim(); //UpDepartmentId
objvQxUsersEN.DepartmentName = objRow[convQxUsers.DepartmentName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentName].ToString().Trim(); //部门名称
objvQxUsersEN.UpDepartmentName = objRow[convQxUsers.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers.UpDepartmentName].ToString().Trim(); //UpDepartmentName
objvQxUsersEN.DepartmentTypeName = objRow[convQxUsers.DepartmentTypeName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentTypeName].ToString().Trim(); //DepartmentTypeName
objvQxUsersEN.DepartmentTypeId = objRow[convQxUsers.DepartmentTypeId] == DBNull.Value ? null : objRow[convQxUsers.DepartmentTypeId].ToString().Trim(); //DepartmentTypeId
objvQxUsersEN.DepartmentAbbrName = objRow[convQxUsers.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentAbbrName].ToString().Trim(); //DepartmentAbbrName
objvQxUsersEN.UpdDate = objRow[convQxUsers.UpdDate] == DBNull.Value ? null : objRow[convQxUsers.UpdDate].ToString().Trim(); //修改日期
objvQxUsersEN.UpdUser = objRow[convQxUsers.UpdUser] == DBNull.Value ? null : objRow[convQxUsers.UpdUser].ToString().Trim(); //修改人
objvQxUsersEN.EffitiveBeginDate = objRow[convQxUsers.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objvQxUsersEN.EffitiveEndDate = objRow[convQxUsers.EffitiveEndDate].ToString().Trim(); //有效结束日期
objvQxUsersEN.StuTeacherId = objRow[convQxUsers.StuTeacherId].ToString().Trim(); //学工号
objvQxUsersEN.IdentityId = objRow[convQxUsers.IdentityId] == DBNull.Value ? null : objRow[convQxUsers.IdentityId].ToString().Trim(); //身份Id
objvQxUsersEN.Password = objRow[convQxUsers.Password] == DBNull.Value ? null : objRow[convQxUsers.Password].ToString().Trim(); //口令
objvQxUsersEN.IdentityDesc = objRow[convQxUsers.IdentityDesc] == DBNull.Value ? null : objRow[convQxUsers.IdentityDesc].ToString().Trim(); //身份描述
objvQxUsersEN.IsSynch = TransNullToBool(objRow[convQxUsers.IsSynch].ToString().Trim()); //是否同步
objvQxUsersEN.SynchDate = objRow[convQxUsers.SynchDate] == DBNull.Value ? null : objRow[convQxUsers.SynchDate].ToString().Trim(); //同步日期
objvQxUsersEN.OpenId = objRow[convQxUsers.OpenId] == DBNull.Value ? null : objRow[convQxUsers.OpenId].ToString().Trim(); //微信OpenId
objvQxUsersEN.CollegeName = objRow[convQxUsers.CollegeName] == DBNull.Value ? null : objRow[convQxUsers.CollegeName].ToString().Trim(); //学院名称
objvQxUsersEN.IdXzCollege = objRow[convQxUsers.IdXzCollege] == DBNull.Value ? null : objRow[convQxUsers.IdXzCollege].ToString().Trim(); //学院流水号
objvQxUsersEN.Email = objRow[convQxUsers.Email] == DBNull.Value ? null : objRow[convQxUsers.Email].ToString().Trim(); //电子邮箱
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvQxUsersDA: GetObjByDataRow)", objException.Message));
}
objvQxUsersEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxUsersEN;
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
objSQL = clsvQxUsersDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvQxUsersEN._CurrTabName, convQxUsers.UserId, 18, "");
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
objSQL = clsvQxUsersDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvQxUsersEN._CurrTabName, convQxUsers.UserId, 18, strPrefix);
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
 objSQL = clsvQxUsersDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select UserId from vQxUsers where " + strCondition;
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
 objSQL = clsvQxUsersDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select UserId from vQxUsers where " + strCondition;
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
 objSQL = clsvQxUsersDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vQxUsers", "UserId = " + "'"+ strUserId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvQxUsersDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUsersDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vQxUsers", strCondition))
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
objSQL = clsvQxUsersDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vQxUsers");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvQxUsersENS">源对象</param>
 /// <param name = "objvQxUsersENT">目标对象</param>
public void CopyTo(clsvQxUsersEN objvQxUsersENS, clsvQxUsersEN objvQxUsersENT)
{
objvQxUsersENT.UserId = objvQxUsersENS.UserId; //用户ID
objvQxUsersENT.UserName = objvQxUsersENS.UserName; //用户名
objvQxUsersENT.UserStateId = objvQxUsersENS.UserStateId; //用户状态Id
objvQxUsersENT.Memo = objvQxUsersENS.Memo; //备注
objvQxUsersENT.UserStateName = objvQxUsersENS.UserStateName; //用户状态名
objvQxUsersENT.DepartmentId = objvQxUsersENS.DepartmentId; //部门Id
objvQxUsersENT.UpDepartmentId = objvQxUsersENS.UpDepartmentId; //UpDepartmentId
objvQxUsersENT.DepartmentName = objvQxUsersENS.DepartmentName; //部门名称
objvQxUsersENT.UpDepartmentName = objvQxUsersENS.UpDepartmentName; //UpDepartmentName
objvQxUsersENT.DepartmentTypeName = objvQxUsersENS.DepartmentTypeName; //DepartmentTypeName
objvQxUsersENT.DepartmentTypeId = objvQxUsersENS.DepartmentTypeId; //DepartmentTypeId
objvQxUsersENT.DepartmentAbbrName = objvQxUsersENS.DepartmentAbbrName; //DepartmentAbbrName
objvQxUsersENT.UpdDate = objvQxUsersENS.UpdDate; //修改日期
objvQxUsersENT.UpdUser = objvQxUsersENS.UpdUser; //修改人
objvQxUsersENT.EffitiveBeginDate = objvQxUsersENS.EffitiveBeginDate; //有效开始日期
objvQxUsersENT.EffitiveEndDate = objvQxUsersENS.EffitiveEndDate; //有效结束日期
objvQxUsersENT.StuTeacherId = objvQxUsersENS.StuTeacherId; //学工号
objvQxUsersENT.IdentityId = objvQxUsersENS.IdentityId; //身份Id
objvQxUsersENT.Password = objvQxUsersENS.Password; //口令
objvQxUsersENT.IdentityDesc = objvQxUsersENS.IdentityDesc; //身份描述
objvQxUsersENT.IsSynch = objvQxUsersENS.IsSynch; //是否同步
objvQxUsersENT.SynchDate = objvQxUsersENS.SynchDate; //同步日期
objvQxUsersENT.OpenId = objvQxUsersENS.OpenId; //微信OpenId
objvQxUsersENT.CollegeName = objvQxUsersENS.CollegeName; //学院名称
objvQxUsersENT.IdXzCollege = objvQxUsersENS.IdXzCollege; //学院流水号
objvQxUsersENT.Email = objvQxUsersENS.Email; //电子邮箱
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvQxUsersEN objvQxUsersEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvQxUsersEN.UserId, 18, convQxUsers.UserId);
clsCheckSql.CheckFieldLen(objvQxUsersEN.UserName, 30, convQxUsers.UserName);
clsCheckSql.CheckFieldLen(objvQxUsersEN.UserStateId, 2, convQxUsers.UserStateId);
clsCheckSql.CheckFieldLen(objvQxUsersEN.Memo, 1000, convQxUsers.Memo);
clsCheckSql.CheckFieldLen(objvQxUsersEN.UserStateName, 20, convQxUsers.UserStateName);
clsCheckSql.CheckFieldLen(objvQxUsersEN.DepartmentId, 8, convQxUsers.DepartmentId);
clsCheckSql.CheckFieldLen(objvQxUsersEN.UpDepartmentId, 6, convQxUsers.UpDepartmentId);
clsCheckSql.CheckFieldLen(objvQxUsersEN.DepartmentName, 100, convQxUsers.DepartmentName);
clsCheckSql.CheckFieldLen(objvQxUsersEN.UpDepartmentName, 100, convQxUsers.UpDepartmentName);
clsCheckSql.CheckFieldLen(objvQxUsersEN.DepartmentTypeName, 50, convQxUsers.DepartmentTypeName);
clsCheckSql.CheckFieldLen(objvQxUsersEN.DepartmentTypeId, 2, convQxUsers.DepartmentTypeId);
clsCheckSql.CheckFieldLen(objvQxUsersEN.DepartmentAbbrName, 12, convQxUsers.DepartmentAbbrName);
clsCheckSql.CheckFieldLen(objvQxUsersEN.UpdDate, 20, convQxUsers.UpdDate);
clsCheckSql.CheckFieldLen(objvQxUsersEN.UpdUser, 20, convQxUsers.UpdUser);
clsCheckSql.CheckFieldLen(objvQxUsersEN.EffitiveBeginDate, 14, convQxUsers.EffitiveBeginDate);
clsCheckSql.CheckFieldLen(objvQxUsersEN.EffitiveEndDate, 14, convQxUsers.EffitiveEndDate);
clsCheckSql.CheckFieldLen(objvQxUsersEN.StuTeacherId, 20, convQxUsers.StuTeacherId);
clsCheckSql.CheckFieldLen(objvQxUsersEN.IdentityId, 2, convQxUsers.IdentityId);
clsCheckSql.CheckFieldLen(objvQxUsersEN.Password, 20, convQxUsers.Password);
clsCheckSql.CheckFieldLen(objvQxUsersEN.IdentityDesc, 20, convQxUsers.IdentityDesc);
clsCheckSql.CheckFieldLen(objvQxUsersEN.SynchDate, 30, convQxUsers.SynchDate);
clsCheckSql.CheckFieldLen(objvQxUsersEN.OpenId, 50, convQxUsers.OpenId);
clsCheckSql.CheckFieldLen(objvQxUsersEN.CollegeName, 100, convQxUsers.CollegeName);
clsCheckSql.CheckFieldLen(objvQxUsersEN.IdXzCollege, 4, convQxUsers.IdXzCollege);
clsCheckSql.CheckFieldLen(objvQxUsersEN.Email, 100, convQxUsers.Email);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvQxUsersEN.UserId, convQxUsers.UserId);
clsCheckSql.CheckSqlInjection4Field(objvQxUsersEN.UserName, convQxUsers.UserName);
clsCheckSql.CheckSqlInjection4Field(objvQxUsersEN.UserStateId, convQxUsers.UserStateId);
clsCheckSql.CheckSqlInjection4Field(objvQxUsersEN.Memo, convQxUsers.Memo);
clsCheckSql.CheckSqlInjection4Field(objvQxUsersEN.UserStateName, convQxUsers.UserStateName);
clsCheckSql.CheckSqlInjection4Field(objvQxUsersEN.DepartmentId, convQxUsers.DepartmentId);
clsCheckSql.CheckSqlInjection4Field(objvQxUsersEN.UpDepartmentId, convQxUsers.UpDepartmentId);
clsCheckSql.CheckSqlInjection4Field(objvQxUsersEN.DepartmentName, convQxUsers.DepartmentName);
clsCheckSql.CheckSqlInjection4Field(objvQxUsersEN.UpDepartmentName, convQxUsers.UpDepartmentName);
clsCheckSql.CheckSqlInjection4Field(objvQxUsersEN.DepartmentTypeName, convQxUsers.DepartmentTypeName);
clsCheckSql.CheckSqlInjection4Field(objvQxUsersEN.DepartmentTypeId, convQxUsers.DepartmentTypeId);
clsCheckSql.CheckSqlInjection4Field(objvQxUsersEN.DepartmentAbbrName, convQxUsers.DepartmentAbbrName);
clsCheckSql.CheckSqlInjection4Field(objvQxUsersEN.UpdDate, convQxUsers.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvQxUsersEN.UpdUser, convQxUsers.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvQxUsersEN.EffitiveBeginDate, convQxUsers.EffitiveBeginDate);
clsCheckSql.CheckSqlInjection4Field(objvQxUsersEN.EffitiveEndDate, convQxUsers.EffitiveEndDate);
clsCheckSql.CheckSqlInjection4Field(objvQxUsersEN.StuTeacherId, convQxUsers.StuTeacherId);
clsCheckSql.CheckSqlInjection4Field(objvQxUsersEN.IdentityId, convQxUsers.IdentityId);
clsCheckSql.CheckSqlInjection4Field(objvQxUsersEN.Password, convQxUsers.Password);
clsCheckSql.CheckSqlInjection4Field(objvQxUsersEN.IdentityDesc, convQxUsers.IdentityDesc);
clsCheckSql.CheckSqlInjection4Field(objvQxUsersEN.SynchDate, convQxUsers.SynchDate);
clsCheckSql.CheckSqlInjection4Field(objvQxUsersEN.OpenId, convQxUsers.OpenId);
clsCheckSql.CheckSqlInjection4Field(objvQxUsersEN.CollegeName, convQxUsers.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvQxUsersEN.IdXzCollege, convQxUsers.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvQxUsersEN.Email, convQxUsers.Email);
//检查外键字段长度
 objvQxUsersEN._IsCheckProperty = true;
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
 objSQL = clsvQxUsersDA.GetSpecSQLObj();
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
 objSQL = clsvQxUsersDA.GetSpecSQLObj();
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
 objSQL = clsvQxUsersDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvQxUsersEN._CurrTabName);
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
 objSQL = clsvQxUsersDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvQxUsersEN._CurrTabName, strCondition);
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
 objSQL = clsvQxUsersDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}