
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUserGroupDA
 表名:UserGroup(01120043)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:09:16
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:用户管理(UserManage)
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
 /// 用户组(UserGroup)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsUserGroupDA : clsCommBase4DA
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
 return clsUserGroupEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsUserGroupEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsUserGroupEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsUserGroupEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsUserGroupEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strGroupId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strGroupId)
{
strGroupId = strGroupId.Replace("'", "''");
if (strGroupId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:UserGroup中,检查关键字,长度不正确!(clsUserGroupDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strGroupId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:UserGroup中,关键字不能为空 或 null!(clsUserGroupDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strGroupId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsUserGroupDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsUserGroupDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserGroupDA.GetSpecSQLObj();
strSQL = "Select * from UserGroup where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_UserGroup(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsUserGroupDA: GetDataTable_UserGroup)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserGroupDA.GetSpecSQLObj();
strSQL = "Select * from UserGroup where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsUserGroupDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserGroupDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsUserGroupDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserGroupDA.GetSpecSQLObj();
strSQL = "Select * from UserGroup where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsUserGroupDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserGroupDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsUserGroupDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserGroupDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from UserGroup where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from UserGroup where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsUserGroupDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserGroupDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from UserGroup where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsUserGroupDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserGroupDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} UserGroup.* from UserGroup Left Join {1} on {2} where {3} and UserGroup.GroupId not in (Select top {5} UserGroup.GroupId from UserGroup Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from UserGroup where {1} and GroupId not in (Select top {2} GroupId from UserGroup where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from UserGroup where {1} and GroupId not in (Select top {3} GroupId from UserGroup where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsUserGroupDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserGroupDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} UserGroup.* from UserGroup Left Join {1} on {2} where {3} and UserGroup.GroupId not in (Select top {5} UserGroup.GroupId from UserGroup Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from UserGroup where {1} and GroupId not in (Select top {2} GroupId from UserGroup where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from UserGroup where {1} and GroupId not in (Select top {3} GroupId from UserGroup where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsUserGroupEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsUserGroupDA:GetObjLst)", objException.Message));
}
List<clsUserGroupEN> arrObjLst = new List<clsUserGroupEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserGroupDA.GetSpecSQLObj();
strSQL = "Select * from UserGroup where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserGroupEN objUserGroupEN = new clsUserGroupEN();
try
{
objUserGroupEN.GroupId = objRow[conUserGroup.GroupId].ToString().Trim(); //组Id
objUserGroupEN.GroupName = objRow[conUserGroup.GroupName].ToString().Trim(); //组名
objUserGroupEN.HomePage = objRow[conUserGroup.HomePage].ToString().Trim(); //HomePage
objUserGroupEN.Memo = objRow[conUserGroup.Memo] == DBNull.Value ? null : objRow[conUserGroup.Memo].ToString().Trim(); //备注
objUserGroupEN.GroupType = objRow[conUserGroup.GroupType] == DBNull.Value ? null : objRow[conUserGroup.GroupType].ToString().Trim(); //GroupType
objUserGroupEN.RoleID = objRow[conUserGroup.RoleID] == DBNull.Value ? null : objRow[conUserGroup.RoleID].ToString().Trim(); //RoleID
objUserGroupEN.UserId = objRow[conUserGroup.UserId] == DBNull.Value ? null : objRow[conUserGroup.UserId].ToString().Trim(); //用户ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsUserGroupDA: GetObjLst)", objException.Message));
}
objUserGroupEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objUserGroupEN);
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
public List<clsUserGroupEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsUserGroupDA:GetObjLstByTabName)", objException.Message));
}
List<clsUserGroupEN> arrObjLst = new List<clsUserGroupEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserGroupDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserGroupEN objUserGroupEN = new clsUserGroupEN();
try
{
objUserGroupEN.GroupId = objRow[conUserGroup.GroupId].ToString().Trim(); //组Id
objUserGroupEN.GroupName = objRow[conUserGroup.GroupName].ToString().Trim(); //组名
objUserGroupEN.HomePage = objRow[conUserGroup.HomePage].ToString().Trim(); //HomePage
objUserGroupEN.Memo = objRow[conUserGroup.Memo] == DBNull.Value ? null : objRow[conUserGroup.Memo].ToString().Trim(); //备注
objUserGroupEN.GroupType = objRow[conUserGroup.GroupType] == DBNull.Value ? null : objRow[conUserGroup.GroupType].ToString().Trim(); //GroupType
objUserGroupEN.RoleID = objRow[conUserGroup.RoleID] == DBNull.Value ? null : objRow[conUserGroup.RoleID].ToString().Trim(); //RoleID
objUserGroupEN.UserId = objRow[conUserGroup.UserId] == DBNull.Value ? null : objRow[conUserGroup.UserId].ToString().Trim(); //用户ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsUserGroupDA: GetObjLst)", objException.Message));
}
objUserGroupEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objUserGroupEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objUserGroupEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetUserGroup(ref clsUserGroupEN objUserGroupEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserGroupDA.GetSpecSQLObj();
strSQL = "Select * from UserGroup where GroupId = " + "'"+ objUserGroupEN.GroupId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objUserGroupEN.GroupId = objDT.Rows[0][conUserGroup.GroupId].ToString().Trim(); //组Id(字段类型:char,字段长度:8,是否可空:True)
 objUserGroupEN.GroupName = objDT.Rows[0][conUserGroup.GroupName].ToString().Trim(); //组名(字段类型:varchar,字段长度:40,是否可空:True)
 objUserGroupEN.HomePage = objDT.Rows[0][conUserGroup.HomePage].ToString().Trim(); //HomePage(字段类型:varchar,字段长度:100,是否可空:True)
 objUserGroupEN.Memo = objDT.Rows[0][conUserGroup.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objUserGroupEN.GroupType = objDT.Rows[0][conUserGroup.GroupType].ToString().Trim(); //GroupType(字段类型:char,字段长度:2,是否可空:True)
 objUserGroupEN.RoleID = objDT.Rows[0][conUserGroup.RoleID].ToString().Trim(); //RoleID(字段类型:varchar,字段长度:20,是否可空:True)
 objUserGroupEN.UserId = objDT.Rows[0][conUserGroup.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsUserGroupDA: GetUserGroup)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strGroupId">表关键字</param>
 /// <returns>表对象</returns>
public clsUserGroupEN GetObjByGroupId(string strGroupId)
{
CheckPrimaryKey(strGroupId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserGroupDA.GetSpecSQLObj();
strSQL = "Select * from UserGroup where GroupId = " + "'"+ strGroupId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsUserGroupEN objUserGroupEN = new clsUserGroupEN();
try
{
 objUserGroupEN.GroupId = objRow[conUserGroup.GroupId].ToString().Trim(); //组Id(字段类型:char,字段长度:8,是否可空:True)
 objUserGroupEN.GroupName = objRow[conUserGroup.GroupName].ToString().Trim(); //组名(字段类型:varchar,字段长度:40,是否可空:True)
 objUserGroupEN.HomePage = objRow[conUserGroup.HomePage].ToString().Trim(); //HomePage(字段类型:varchar,字段长度:100,是否可空:True)
 objUserGroupEN.Memo = objRow[conUserGroup.Memo] == DBNull.Value ? null : objRow[conUserGroup.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objUserGroupEN.GroupType = objRow[conUserGroup.GroupType] == DBNull.Value ? null : objRow[conUserGroup.GroupType].ToString().Trim(); //GroupType(字段类型:char,字段长度:2,是否可空:True)
 objUserGroupEN.RoleID = objRow[conUserGroup.RoleID] == DBNull.Value ? null : objRow[conUserGroup.RoleID].ToString().Trim(); //RoleID(字段类型:varchar,字段长度:20,是否可空:True)
 objUserGroupEN.UserId = objRow[conUserGroup.UserId] == DBNull.Value ? null : objRow[conUserGroup.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsUserGroupDA: GetObjByGroupId)", objException.Message));
}
return objUserGroupEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsUserGroupEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsUserGroupDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserGroupDA.GetSpecSQLObj();
strSQL = "Select * from UserGroup where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsUserGroupEN objUserGroupEN = new clsUserGroupEN()
{
GroupId = objRow[conUserGroup.GroupId].ToString().Trim(), //组Id
GroupName = objRow[conUserGroup.GroupName].ToString().Trim(), //组名
HomePage = objRow[conUserGroup.HomePage].ToString().Trim(), //HomePage
Memo = objRow[conUserGroup.Memo] == DBNull.Value ? null : objRow[conUserGroup.Memo].ToString().Trim(), //备注
GroupType = objRow[conUserGroup.GroupType] == DBNull.Value ? null : objRow[conUserGroup.GroupType].ToString().Trim(), //GroupType
RoleID = objRow[conUserGroup.RoleID] == DBNull.Value ? null : objRow[conUserGroup.RoleID].ToString().Trim(), //RoleID
UserId = objRow[conUserGroup.UserId] == DBNull.Value ? null : objRow[conUserGroup.UserId].ToString().Trim() //用户ID
};
objUserGroupEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objUserGroupEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsUserGroupDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsUserGroupEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsUserGroupEN objUserGroupEN = new clsUserGroupEN();
try
{
objUserGroupEN.GroupId = objRow[conUserGroup.GroupId].ToString().Trim(); //组Id
objUserGroupEN.GroupName = objRow[conUserGroup.GroupName].ToString().Trim(); //组名
objUserGroupEN.HomePage = objRow[conUserGroup.HomePage].ToString().Trim(); //HomePage
objUserGroupEN.Memo = objRow[conUserGroup.Memo] == DBNull.Value ? null : objRow[conUserGroup.Memo].ToString().Trim(); //备注
objUserGroupEN.GroupType = objRow[conUserGroup.GroupType] == DBNull.Value ? null : objRow[conUserGroup.GroupType].ToString().Trim(); //GroupType
objUserGroupEN.RoleID = objRow[conUserGroup.RoleID] == DBNull.Value ? null : objRow[conUserGroup.RoleID].ToString().Trim(); //RoleID
objUserGroupEN.UserId = objRow[conUserGroup.UserId] == DBNull.Value ? null : objRow[conUserGroup.UserId].ToString().Trim(); //用户ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsUserGroupDA: GetObjByDataRowUserGroup)", objException.Message));
}
objUserGroupEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objUserGroupEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsUserGroupEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsUserGroupEN objUserGroupEN = new clsUserGroupEN();
try
{
objUserGroupEN.GroupId = objRow[conUserGroup.GroupId].ToString().Trim(); //组Id
objUserGroupEN.GroupName = objRow[conUserGroup.GroupName].ToString().Trim(); //组名
objUserGroupEN.HomePage = objRow[conUserGroup.HomePage].ToString().Trim(); //HomePage
objUserGroupEN.Memo = objRow[conUserGroup.Memo] == DBNull.Value ? null : objRow[conUserGroup.Memo].ToString().Trim(); //备注
objUserGroupEN.GroupType = objRow[conUserGroup.GroupType] == DBNull.Value ? null : objRow[conUserGroup.GroupType].ToString().Trim(); //GroupType
objUserGroupEN.RoleID = objRow[conUserGroup.RoleID] == DBNull.Value ? null : objRow[conUserGroup.RoleID].ToString().Trim(); //RoleID
objUserGroupEN.UserId = objRow[conUserGroup.UserId] == DBNull.Value ? null : objRow[conUserGroup.UserId].ToString().Trim(); //用户ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsUserGroupDA: GetObjByDataRow)", objException.Message));
}
objUserGroupEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objUserGroupEN;
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
objSQL = clsUserGroupDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsUserGroupEN._CurrTabName, conUserGroup.GroupId, 8, "");
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
objSQL = clsUserGroupDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsUserGroupEN._CurrTabName, conUserGroup.GroupId, 8, strPrefix);
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
 objSQL = clsUserGroupDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select GroupId from UserGroup where " + strCondition;
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
 objSQL = clsUserGroupDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select GroupId from UserGroup where " + strCondition;
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
 /// <param name = "strGroupId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strGroupId)
{
CheckPrimaryKey(strGroupId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserGroupDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("UserGroup", "GroupId = " + "'"+ strGroupId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsUserGroupDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserGroupDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("UserGroup", strCondition))
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
objSQL = clsUserGroupDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("UserGroup");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsUserGroupEN objUserGroupEN)
 {
 if (objUserGroupEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUserGroupEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserGroupDA.GetSpecSQLObj();
strSQL = "Select * from UserGroup where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "UserGroup");
objRow = objDS.Tables["UserGroup"].NewRow();
objRow[conUserGroup.GroupId] = objUserGroupEN.GroupId; //组Id
objRow[conUserGroup.GroupName] = objUserGroupEN.GroupName; //组名
objRow[conUserGroup.HomePage] = objUserGroupEN.HomePage; //HomePage
 if (objUserGroupEN.Memo !=  "")
 {
objRow[conUserGroup.Memo] = objUserGroupEN.Memo; //备注
 }
 if (objUserGroupEN.GroupType !=  "")
 {
objRow[conUserGroup.GroupType] = objUserGroupEN.GroupType; //GroupType
 }
 if (objUserGroupEN.RoleID !=  "")
 {
objRow[conUserGroup.RoleID] = objUserGroupEN.RoleID; //RoleID
 }
 if (objUserGroupEN.UserId !=  "")
 {
objRow[conUserGroup.UserId] = objUserGroupEN.UserId; //用户ID
 }
objDS.Tables[clsUserGroupEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsUserGroupEN._CurrTabName);
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
 /// <param name = "objUserGroupEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsUserGroupEN objUserGroupEN)
{
 if (objUserGroupEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUserGroupEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objUserGroupEN.GroupId !=  null)
 {
 arrFieldListForInsert.Add(conUserGroup.GroupId);
 var strGroupId = objUserGroupEN.GroupId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupId + "'");
 }
 
 if (objUserGroupEN.GroupName !=  null)
 {
 arrFieldListForInsert.Add(conUserGroup.GroupName);
 var strGroupName = objUserGroupEN.GroupName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupName + "'");
 }
 
 if (objUserGroupEN.HomePage !=  null)
 {
 arrFieldListForInsert.Add(conUserGroup.HomePage);
 var strHomePage = objUserGroupEN.HomePage.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strHomePage + "'");
 }
 
 if (objUserGroupEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conUserGroup.Memo);
 var strMemo = objUserGroupEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objUserGroupEN.GroupType !=  null)
 {
 arrFieldListForInsert.Add(conUserGroup.GroupType);
 var strGroupType = objUserGroupEN.GroupType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupType + "'");
 }
 
 if (objUserGroupEN.RoleID !=  null)
 {
 arrFieldListForInsert.Add(conUserGroup.RoleID);
 var strRoleID = objUserGroupEN.RoleID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRoleID + "'");
 }
 
 if (objUserGroupEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conUserGroup.UserId);
 var strUserId = objUserGroupEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into UserGroup");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserGroupDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objUserGroupEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsUserGroupEN objUserGroupEN)
{
 if (objUserGroupEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUserGroupEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objUserGroupEN.GroupId !=  null)
 {
 arrFieldListForInsert.Add(conUserGroup.GroupId);
 var strGroupId = objUserGroupEN.GroupId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupId + "'");
 }
 
 if (objUserGroupEN.GroupName !=  null)
 {
 arrFieldListForInsert.Add(conUserGroup.GroupName);
 var strGroupName = objUserGroupEN.GroupName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupName + "'");
 }
 
 if (objUserGroupEN.HomePage !=  null)
 {
 arrFieldListForInsert.Add(conUserGroup.HomePage);
 var strHomePage = objUserGroupEN.HomePage.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strHomePage + "'");
 }
 
 if (objUserGroupEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conUserGroup.Memo);
 var strMemo = objUserGroupEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objUserGroupEN.GroupType !=  null)
 {
 arrFieldListForInsert.Add(conUserGroup.GroupType);
 var strGroupType = objUserGroupEN.GroupType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupType + "'");
 }
 
 if (objUserGroupEN.RoleID !=  null)
 {
 arrFieldListForInsert.Add(conUserGroup.RoleID);
 var strRoleID = objUserGroupEN.RoleID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRoleID + "'");
 }
 
 if (objUserGroupEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conUserGroup.UserId);
 var strUserId = objUserGroupEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into UserGroup");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserGroupDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objUserGroupEN.GroupId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objUserGroupEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsUserGroupEN objUserGroupEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objUserGroupEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUserGroupEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objUserGroupEN.GroupId !=  null)
 {
 arrFieldListForInsert.Add(conUserGroup.GroupId);
 var strGroupId = objUserGroupEN.GroupId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupId + "'");
 }
 
 if (objUserGroupEN.GroupName !=  null)
 {
 arrFieldListForInsert.Add(conUserGroup.GroupName);
 var strGroupName = objUserGroupEN.GroupName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupName + "'");
 }
 
 if (objUserGroupEN.HomePage !=  null)
 {
 arrFieldListForInsert.Add(conUserGroup.HomePage);
 var strHomePage = objUserGroupEN.HomePage.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strHomePage + "'");
 }
 
 if (objUserGroupEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conUserGroup.Memo);
 var strMemo = objUserGroupEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objUserGroupEN.GroupType !=  null)
 {
 arrFieldListForInsert.Add(conUserGroup.GroupType);
 var strGroupType = objUserGroupEN.GroupType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupType + "'");
 }
 
 if (objUserGroupEN.RoleID !=  null)
 {
 arrFieldListForInsert.Add(conUserGroup.RoleID);
 var strRoleID = objUserGroupEN.RoleID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRoleID + "'");
 }
 
 if (objUserGroupEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conUserGroup.UserId);
 var strUserId = objUserGroupEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into UserGroup");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserGroupDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objUserGroupEN.GroupId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objUserGroupEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsUserGroupEN objUserGroupEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objUserGroupEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUserGroupEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objUserGroupEN.GroupId !=  null)
 {
 arrFieldListForInsert.Add(conUserGroup.GroupId);
 var strGroupId = objUserGroupEN.GroupId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupId + "'");
 }
 
 if (objUserGroupEN.GroupName !=  null)
 {
 arrFieldListForInsert.Add(conUserGroup.GroupName);
 var strGroupName = objUserGroupEN.GroupName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupName + "'");
 }
 
 if (objUserGroupEN.HomePage !=  null)
 {
 arrFieldListForInsert.Add(conUserGroup.HomePage);
 var strHomePage = objUserGroupEN.HomePage.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strHomePage + "'");
 }
 
 if (objUserGroupEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conUserGroup.Memo);
 var strMemo = objUserGroupEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objUserGroupEN.GroupType !=  null)
 {
 arrFieldListForInsert.Add(conUserGroup.GroupType);
 var strGroupType = objUserGroupEN.GroupType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupType + "'");
 }
 
 if (objUserGroupEN.RoleID !=  null)
 {
 arrFieldListForInsert.Add(conUserGroup.RoleID);
 var strRoleID = objUserGroupEN.RoleID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRoleID + "'");
 }
 
 if (objUserGroupEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conUserGroup.UserId);
 var strUserId = objUserGroupEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into UserGroup");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserGroupDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewUserGroups(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserGroupDA.GetSpecSQLObj();
strSQL = "Select * from UserGroup where GroupId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "UserGroup");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strGroupId = oRow[conUserGroup.GroupId].ToString().Trim();
if (IsExist(strGroupId))
{
 string strResult = "关键字变量值为:" + string.Format("GroupId = {0}", strGroupId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsUserGroupEN._CurrTabName ].NewRow();
objRow[conUserGroup.GroupId] = oRow[conUserGroup.GroupId].ToString().Trim(); //组Id
objRow[conUserGroup.GroupName] = oRow[conUserGroup.GroupName].ToString().Trim(); //组名
objRow[conUserGroup.HomePage] = oRow[conUserGroup.HomePage].ToString().Trim(); //HomePage
objRow[conUserGroup.Memo] = oRow[conUserGroup.Memo].ToString().Trim(); //备注
objRow[conUserGroup.GroupType] = oRow[conUserGroup.GroupType].ToString().Trim(); //GroupType
objRow[conUserGroup.RoleID] = oRow[conUserGroup.RoleID].ToString().Trim(); //RoleID
objRow[conUserGroup.UserId] = oRow[conUserGroup.UserId].ToString().Trim(); //用户ID
 objDS.Tables[clsUserGroupEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsUserGroupEN._CurrTabName);
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
 /// <param name = "objUserGroupEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsUserGroupEN objUserGroupEN)
{
 if (objUserGroupEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUserGroupEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserGroupDA.GetSpecSQLObj();
strSQL = "Select * from UserGroup where GroupId = " + "'"+ objUserGroupEN.GroupId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsUserGroupEN._CurrTabName);
if (objDS.Tables[clsUserGroupEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:GroupId = " + "'"+ objUserGroupEN.GroupId+"'");
return false;
}
objRow = objDS.Tables[clsUserGroupEN._CurrTabName].Rows[0];
 if (objUserGroupEN.IsUpdated(conUserGroup.GroupId))
 {
objRow[conUserGroup.GroupId] = objUserGroupEN.GroupId; //组Id
 }
 if (objUserGroupEN.IsUpdated(conUserGroup.GroupName))
 {
objRow[conUserGroup.GroupName] = objUserGroupEN.GroupName; //组名
 }
 if (objUserGroupEN.IsUpdated(conUserGroup.HomePage))
 {
objRow[conUserGroup.HomePage] = objUserGroupEN.HomePage; //HomePage
 }
 if (objUserGroupEN.IsUpdated(conUserGroup.Memo))
 {
objRow[conUserGroup.Memo] = objUserGroupEN.Memo; //备注
 }
 if (objUserGroupEN.IsUpdated(conUserGroup.GroupType))
 {
objRow[conUserGroup.GroupType] = objUserGroupEN.GroupType; //GroupType
 }
 if (objUserGroupEN.IsUpdated(conUserGroup.RoleID))
 {
objRow[conUserGroup.RoleID] = objUserGroupEN.RoleID; //RoleID
 }
 if (objUserGroupEN.IsUpdated(conUserGroup.UserId))
 {
objRow[conUserGroup.UserId] = objUserGroupEN.UserId; //用户ID
 }
try
{
objDA.Update(objDS, clsUserGroupEN._CurrTabName);
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
 /// <param name = "objUserGroupEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsUserGroupEN objUserGroupEN)
{
 if (objUserGroupEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUserGroupEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserGroupDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update UserGroup Set ");
 
 if (objUserGroupEN.IsUpdated(conUserGroup.GroupName))
 {
 if (objUserGroupEN.GroupName !=  null)
 {
 var strGroupName = objUserGroupEN.GroupName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGroupName, conUserGroup.GroupName); //组名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserGroup.GroupName); //组名
 }
 }
 
 if (objUserGroupEN.IsUpdated(conUserGroup.HomePage))
 {
 if (objUserGroupEN.HomePage !=  null)
 {
 var strHomePage = objUserGroupEN.HomePage.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strHomePage, conUserGroup.HomePage); //HomePage
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserGroup.HomePage); //HomePage
 }
 }
 
 if (objUserGroupEN.IsUpdated(conUserGroup.Memo))
 {
 if (objUserGroupEN.Memo !=  null)
 {
 var strMemo = objUserGroupEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conUserGroup.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserGroup.Memo); //备注
 }
 }
 
 if (objUserGroupEN.IsUpdated(conUserGroup.GroupType))
 {
 if (objUserGroupEN.GroupType !=  null)
 {
 var strGroupType = objUserGroupEN.GroupType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGroupType, conUserGroup.GroupType); //GroupType
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserGroup.GroupType); //GroupType
 }
 }
 
 if (objUserGroupEN.IsUpdated(conUserGroup.RoleID))
 {
 if (objUserGroupEN.RoleID !=  null)
 {
 var strRoleID = objUserGroupEN.RoleID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRoleID, conUserGroup.RoleID); //RoleID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserGroup.RoleID); //RoleID
 }
 }
 
 if (objUserGroupEN.IsUpdated(conUserGroup.UserId))
 {
 if (objUserGroupEN.UserId !=  null)
 {
 var strUserId = objUserGroupEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conUserGroup.UserId); //用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserGroup.UserId); //用户ID
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where GroupId = '{0}'", objUserGroupEN.GroupId); 
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
 /// <param name = "objUserGroupEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsUserGroupEN objUserGroupEN, string strCondition)
{
 if (objUserGroupEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUserGroupEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserGroupDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update UserGroup Set ");
 
 if (objUserGroupEN.IsUpdated(conUserGroup.GroupName))
 {
 if (objUserGroupEN.GroupName !=  null)
 {
 var strGroupName = objUserGroupEN.GroupName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GroupName = '{0}',", strGroupName); //组名
 }
 else
 {
 sbSQL.Append(" GroupName = null,"); //组名
 }
 }
 
 if (objUserGroupEN.IsUpdated(conUserGroup.HomePage))
 {
 if (objUserGroupEN.HomePage !=  null)
 {
 var strHomePage = objUserGroupEN.HomePage.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" HomePage = '{0}',", strHomePage); //HomePage
 }
 else
 {
 sbSQL.Append(" HomePage = null,"); //HomePage
 }
 }
 
 if (objUserGroupEN.IsUpdated(conUserGroup.Memo))
 {
 if (objUserGroupEN.Memo !=  null)
 {
 var strMemo = objUserGroupEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objUserGroupEN.IsUpdated(conUserGroup.GroupType))
 {
 if (objUserGroupEN.GroupType !=  null)
 {
 var strGroupType = objUserGroupEN.GroupType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GroupType = '{0}',", strGroupType); //GroupType
 }
 else
 {
 sbSQL.Append(" GroupType = null,"); //GroupType
 }
 }
 
 if (objUserGroupEN.IsUpdated(conUserGroup.RoleID))
 {
 if (objUserGroupEN.RoleID !=  null)
 {
 var strRoleID = objUserGroupEN.RoleID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RoleID = '{0}',", strRoleID); //RoleID
 }
 else
 {
 sbSQL.Append(" RoleID = null,"); //RoleID
 }
 }
 
 if (objUserGroupEN.IsUpdated(conUserGroup.UserId))
 {
 if (objUserGroupEN.UserId !=  null)
 {
 var strUserId = objUserGroupEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户ID
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户ID
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
 /// <param name = "objUserGroupEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsUserGroupEN objUserGroupEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objUserGroupEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUserGroupEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserGroupDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update UserGroup Set ");
 
 if (objUserGroupEN.IsUpdated(conUserGroup.GroupName))
 {
 if (objUserGroupEN.GroupName !=  null)
 {
 var strGroupName = objUserGroupEN.GroupName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GroupName = '{0}',", strGroupName); //组名
 }
 else
 {
 sbSQL.Append(" GroupName = null,"); //组名
 }
 }
 
 if (objUserGroupEN.IsUpdated(conUserGroup.HomePage))
 {
 if (objUserGroupEN.HomePage !=  null)
 {
 var strHomePage = objUserGroupEN.HomePage.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" HomePage = '{0}',", strHomePage); //HomePage
 }
 else
 {
 sbSQL.Append(" HomePage = null,"); //HomePage
 }
 }
 
 if (objUserGroupEN.IsUpdated(conUserGroup.Memo))
 {
 if (objUserGroupEN.Memo !=  null)
 {
 var strMemo = objUserGroupEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objUserGroupEN.IsUpdated(conUserGroup.GroupType))
 {
 if (objUserGroupEN.GroupType !=  null)
 {
 var strGroupType = objUserGroupEN.GroupType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GroupType = '{0}',", strGroupType); //GroupType
 }
 else
 {
 sbSQL.Append(" GroupType = null,"); //GroupType
 }
 }
 
 if (objUserGroupEN.IsUpdated(conUserGroup.RoleID))
 {
 if (objUserGroupEN.RoleID !=  null)
 {
 var strRoleID = objUserGroupEN.RoleID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RoleID = '{0}',", strRoleID); //RoleID
 }
 else
 {
 sbSQL.Append(" RoleID = null,"); //RoleID
 }
 }
 
 if (objUserGroupEN.IsUpdated(conUserGroup.UserId))
 {
 if (objUserGroupEN.UserId !=  null)
 {
 var strUserId = objUserGroupEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户ID
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户ID
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
 /// <param name = "objUserGroupEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsUserGroupEN objUserGroupEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objUserGroupEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUserGroupEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserGroupDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update UserGroup Set ");
 
 if (objUserGroupEN.IsUpdated(conUserGroup.GroupName))
 {
 if (objUserGroupEN.GroupName !=  null)
 {
 var strGroupName = objUserGroupEN.GroupName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGroupName, conUserGroup.GroupName); //组名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserGroup.GroupName); //组名
 }
 }
 
 if (objUserGroupEN.IsUpdated(conUserGroup.HomePage))
 {
 if (objUserGroupEN.HomePage !=  null)
 {
 var strHomePage = objUserGroupEN.HomePage.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strHomePage, conUserGroup.HomePage); //HomePage
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserGroup.HomePage); //HomePage
 }
 }
 
 if (objUserGroupEN.IsUpdated(conUserGroup.Memo))
 {
 if (objUserGroupEN.Memo !=  null)
 {
 var strMemo = objUserGroupEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conUserGroup.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserGroup.Memo); //备注
 }
 }
 
 if (objUserGroupEN.IsUpdated(conUserGroup.GroupType))
 {
 if (objUserGroupEN.GroupType !=  null)
 {
 var strGroupType = objUserGroupEN.GroupType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGroupType, conUserGroup.GroupType); //GroupType
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserGroup.GroupType); //GroupType
 }
 }
 
 if (objUserGroupEN.IsUpdated(conUserGroup.RoleID))
 {
 if (objUserGroupEN.RoleID !=  null)
 {
 var strRoleID = objUserGroupEN.RoleID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRoleID, conUserGroup.RoleID); //RoleID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserGroup.RoleID); //RoleID
 }
 }
 
 if (objUserGroupEN.IsUpdated(conUserGroup.UserId))
 {
 if (objUserGroupEN.UserId !=  null)
 {
 var strUserId = objUserGroupEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conUserGroup.UserId); //用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserGroup.UserId); //用户ID
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where GroupId = '{0}'", objUserGroupEN.GroupId); 
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
 /// <param name = "strGroupId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strGroupId) 
{
CheckPrimaryKey(strGroupId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserGroupDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strGroupId,
};
 objSQL.ExecSP("UserGroup_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strGroupId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strGroupId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strGroupId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserGroupDA.GetSpecSQLObj();
//删除UserGroup本表中与当前对象有关的记录
strSQL = strSQL + "Delete from UserGroup where GroupId = " + "'"+ strGroupId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelUserGroup(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserGroupDA.GetSpecSQLObj();
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
//删除UserGroup本表中与当前对象有关的记录
strSQL = strSQL + "Delete from UserGroup where GroupId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strGroupId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strGroupId) 
{
CheckPrimaryKey(strGroupId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserGroupDA.GetSpecSQLObj();
//删除UserGroup本表中与当前对象有关的记录
strSQL = strSQL + "Delete from UserGroup where GroupId = " + "'"+ strGroupId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelUserGroup(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsUserGroupDA: DelUserGroup)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserGroupDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from UserGroup where " + strCondition ;
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
public bool DelUserGroupWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsUserGroupDA: DelUserGroupWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserGroupDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from UserGroup where " + strCondition ;
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
 /// <param name = "objUserGroupENS">源对象</param>
 /// <param name = "objUserGroupENT">目标对象</param>
public void CopyTo(clsUserGroupEN objUserGroupENS, clsUserGroupEN objUserGroupENT)
{
objUserGroupENT.GroupId = objUserGroupENS.GroupId; //组Id
objUserGroupENT.GroupName = objUserGroupENS.GroupName; //组名
objUserGroupENT.HomePage = objUserGroupENS.HomePage; //HomePage
objUserGroupENT.Memo = objUserGroupENS.Memo; //备注
objUserGroupENT.GroupType = objUserGroupENS.GroupType; //GroupType
objUserGroupENT.RoleID = objUserGroupENS.RoleID; //RoleID
objUserGroupENT.UserId = objUserGroupENS.UserId; //用户ID
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsUserGroupEN objUserGroupEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objUserGroupEN.GroupName, conUserGroup.GroupName);
clsCheckSql.CheckFieldNotNull(objUserGroupEN.HomePage, conUserGroup.HomePage);
//检查字段长度
clsCheckSql.CheckFieldLen(objUserGroupEN.GroupId, 8, conUserGroup.GroupId);
clsCheckSql.CheckFieldLen(objUserGroupEN.GroupName, 40, conUserGroup.GroupName);
clsCheckSql.CheckFieldLen(objUserGroupEN.HomePage, 100, conUserGroup.HomePage);
clsCheckSql.CheckFieldLen(objUserGroupEN.Memo, 1000, conUserGroup.Memo);
clsCheckSql.CheckFieldLen(objUserGroupEN.GroupType, 2, conUserGroup.GroupType);
clsCheckSql.CheckFieldLen(objUserGroupEN.RoleID, 20, conUserGroup.RoleID);
clsCheckSql.CheckFieldLen(objUserGroupEN.UserId, 18, conUserGroup.UserId);
//检查字段外键固定长度
 objUserGroupEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsUserGroupEN objUserGroupEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objUserGroupEN.GroupName, 40, conUserGroup.GroupName);
clsCheckSql.CheckFieldLen(objUserGroupEN.HomePage, 100, conUserGroup.HomePage);
clsCheckSql.CheckFieldLen(objUserGroupEN.Memo, 1000, conUserGroup.Memo);
clsCheckSql.CheckFieldLen(objUserGroupEN.GroupType, 2, conUserGroup.GroupType);
clsCheckSql.CheckFieldLen(objUserGroupEN.RoleID, 20, conUserGroup.RoleID);
clsCheckSql.CheckFieldLen(objUserGroupEN.UserId, 18, conUserGroup.UserId);
//检查外键字段长度
 objUserGroupEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsUserGroupEN objUserGroupEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objUserGroupEN.GroupId, 8, conUserGroup.GroupId);
clsCheckSql.CheckFieldLen(objUserGroupEN.GroupName, 40, conUserGroup.GroupName);
clsCheckSql.CheckFieldLen(objUserGroupEN.HomePage, 100, conUserGroup.HomePage);
clsCheckSql.CheckFieldLen(objUserGroupEN.Memo, 1000, conUserGroup.Memo);
clsCheckSql.CheckFieldLen(objUserGroupEN.GroupType, 2, conUserGroup.GroupType);
clsCheckSql.CheckFieldLen(objUserGroupEN.RoleID, 20, conUserGroup.RoleID);
clsCheckSql.CheckFieldLen(objUserGroupEN.UserId, 18, conUserGroup.UserId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objUserGroupEN.GroupId, conUserGroup.GroupId);
clsCheckSql.CheckSqlInjection4Field(objUserGroupEN.GroupName, conUserGroup.GroupName);
clsCheckSql.CheckSqlInjection4Field(objUserGroupEN.HomePage, conUserGroup.HomePage);
clsCheckSql.CheckSqlInjection4Field(objUserGroupEN.Memo, conUserGroup.Memo);
clsCheckSql.CheckSqlInjection4Field(objUserGroupEN.GroupType, conUserGroup.GroupType);
clsCheckSql.CheckSqlInjection4Field(objUserGroupEN.RoleID, conUserGroup.RoleID);
clsCheckSql.CheckSqlInjection4Field(objUserGroupEN.UserId, conUserGroup.UserId);
//检查外键字段长度
 objUserGroupEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetGroupId()
{
//获取某学院所有专业信息
string strSQL = "select GroupId, GroupName from UserGroup ";
 clsSpecSQLforSql mySql = clsUserGroupDA.GetSpecSQLObj();
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
 objSQL = clsUserGroupDA.GetSpecSQLObj();
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
 objSQL = clsUserGroupDA.GetSpecSQLObj();
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
 objSQL = clsUserGroupDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsUserGroupEN._CurrTabName);
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
 objSQL = clsUserGroupDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsUserGroupEN._CurrTabName, strCondition);
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
 objSQL = clsUserGroupDA.GetSpecSQLObj();
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
 objSQL = clsUserGroupDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}