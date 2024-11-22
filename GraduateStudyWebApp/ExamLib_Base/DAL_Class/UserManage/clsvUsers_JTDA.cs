
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvUsers_JTDA
 表名:vUsers_JT(01120230)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:50:27
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
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
 /// v用户_JT(vUsers_JT)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvUsers_JTDA : clsCommBase4DA
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
 return clsvUsers_JTEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvUsers_JTEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvUsers_JTEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvUsers_JTEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvUsers_JTEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:vUsers_JT中,检查关键字,长度不正确!(clsvUsers_JTDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strUserId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vUsers_JT中,关键字不能为空 或 null!(clsvUsers_JTDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strUserId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvUsers_JTDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvUsers_JTDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUsers_JTDA.GetSpecSQLObj();
strSQL = "Select * from vUsers_JT where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vUsers_JT(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvUsers_JTDA: GetDataTable_vUsers_JT)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUsers_JTDA.GetSpecSQLObj();
strSQL = "Select * from vUsers_JT where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvUsers_JTDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUsers_JTDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvUsers_JTDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUsers_JTDA.GetSpecSQLObj();
strSQL = "Select * from vUsers_JT where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvUsers_JTDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUsers_JTDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvUsers_JTDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUsers_JTDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vUsers_JT where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vUsers_JT where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvUsers_JTDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUsers_JTDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vUsers_JT where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvUsers_JTDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUsers_JTDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vUsers_JT.* from vUsers_JT Left Join {1} on {2} where {3} and vUsers_JT.UserId not in (Select top {5} vUsers_JT.UserId from vUsers_JT Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vUsers_JT where {1} and UserId not in (Select top {2} UserId from vUsers_JT where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vUsers_JT where {1} and UserId not in (Select top {3} UserId from vUsers_JT where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvUsers_JTDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUsers_JTDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vUsers_JT.* from vUsers_JT Left Join {1} on {2} where {3} and vUsers_JT.UserId not in (Select top {5} vUsers_JT.UserId from vUsers_JT Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vUsers_JT where {1} and UserId not in (Select top {2} UserId from vUsers_JT where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vUsers_JT where {1} and UserId not in (Select top {3} UserId from vUsers_JT where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvUsers_JTEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvUsers_JTDA:GetObjLst)", objException.Message));
}
List<clsvUsers_JTEN> arrObjLst = new List<clsvUsers_JTEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUsers_JTDA.GetSpecSQLObj();
strSQL = "Select * from vUsers_JT where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUsers_JTEN objvUsers_JTEN = new clsvUsers_JTEN();
try
{
objvUsers_JTEN.UserId = objRow[convUsers_JT.UserId].ToString().Trim(); //用户ID
objvUsers_JTEN.UserName = objRow[convUsers_JT.UserName] == DBNull.Value ? null : objRow[convUsers_JT.UserName].ToString().Trim(); //用户名
objvUsers_JTEN.Password = objRow[convUsers_JT.Password] == DBNull.Value ? null : objRow[convUsers_JT.Password].ToString().Trim(); //Password
objvUsers_JTEN.PhoneNumber = objRow[convUsers_JT.PhoneNumber] == DBNull.Value ? null : objRow[convUsers_JT.PhoneNumber].ToString().Trim(); //PhoneNumber
objvUsers_JTEN.AuditDate = objRow[convUsers_JT.AuditDate] == DBNull.Value ? null : objRow[convUsers_JT.AuditDate].ToString().Trim(); //AuditDate
objvUsers_JTEN.AuditUser = objRow[convUsers_JT.AuditUser] == DBNull.Value ? null : objRow[convUsers_JT.AuditUser].ToString().Trim(); //AuditUser
objvUsers_JTEN.IsAudit = TransNullToBool(objRow[convUsers_JT.IsAudit].ToString().Trim()); //是否审核
objvUsers_JTEN.IsRegister = TransNullToBool(objRow[convUsers_JT.IsRegister].ToString().Trim()); //IsRegister
objvUsers_JTEN.RegisterDate = objRow[convUsers_JT.RegisterDate] == DBNull.Value ? null : objRow[convUsers_JT.RegisterDate].ToString().Trim(); //RegisterDate
objvUsers_JTEN.MobilePhone = objRow[convUsers_JT.MobilePhone] == DBNull.Value ? null : objRow[convUsers_JT.MobilePhone].ToString().Trim(); //手机
objvUsers_JTEN.SiteName = objRow[convUsers_JT.SiteName].ToString().Trim(); //工地名称
objvUsers_JTEN.JobCategoryId = objRow[convUsers_JT.JobCategoryId].ToString().Trim(); //岗位类别Id
objvUsers_JTEN.JobCategoryName = objRow[convUsers_JT.JobCategoryName].ToString().Trim(); //岗位类别名
objvUsers_JTEN.ManagedDepartmentId = objRow[convUsers_JT.ManagedDepartmentId].ToString().Trim(); //管理的部门Id
objvUsers_JTEN.ManagedDepartmentName = objRow[convUsers_JT.ManagedDepartmentName].ToString().Trim(); //管理的部门名
objvUsers_JTEN.IDNumber = objRow[convUsers_JT.IDNumber] == DBNull.Value ? null : objRow[convUsers_JT.IDNumber].ToString().Trim(); //身份证号
objvUsers_JTEN.UpdDate = objRow[convUsers_JT.UpdDate].ToString().Trim(); //修改日期
objvUsers_JTEN.UpdUser = objRow[convUsers_JT.UpdUser].ToString().Trim(); //修改人
objvUsers_JTEN.Memo = objRow[convUsers_JT.Memo] == DBNull.Value ? null : objRow[convUsers_JT.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvUsers_JTDA: GetObjLst)", objException.Message));
}
objvUsers_JTEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvUsers_JTEN);
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
public List<clsvUsers_JTEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvUsers_JTDA:GetObjLstByTabName)", objException.Message));
}
List<clsvUsers_JTEN> arrObjLst = new List<clsvUsers_JTEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUsers_JTDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUsers_JTEN objvUsers_JTEN = new clsvUsers_JTEN();
try
{
objvUsers_JTEN.UserId = objRow[convUsers_JT.UserId].ToString().Trim(); //用户ID
objvUsers_JTEN.UserName = objRow[convUsers_JT.UserName] == DBNull.Value ? null : objRow[convUsers_JT.UserName].ToString().Trim(); //用户名
objvUsers_JTEN.Password = objRow[convUsers_JT.Password] == DBNull.Value ? null : objRow[convUsers_JT.Password].ToString().Trim(); //Password
objvUsers_JTEN.PhoneNumber = objRow[convUsers_JT.PhoneNumber] == DBNull.Value ? null : objRow[convUsers_JT.PhoneNumber].ToString().Trim(); //PhoneNumber
objvUsers_JTEN.AuditDate = objRow[convUsers_JT.AuditDate] == DBNull.Value ? null : objRow[convUsers_JT.AuditDate].ToString().Trim(); //AuditDate
objvUsers_JTEN.AuditUser = objRow[convUsers_JT.AuditUser] == DBNull.Value ? null : objRow[convUsers_JT.AuditUser].ToString().Trim(); //AuditUser
objvUsers_JTEN.IsAudit = TransNullToBool(objRow[convUsers_JT.IsAudit].ToString().Trim()); //是否审核
objvUsers_JTEN.IsRegister = TransNullToBool(objRow[convUsers_JT.IsRegister].ToString().Trim()); //IsRegister
objvUsers_JTEN.RegisterDate = objRow[convUsers_JT.RegisterDate] == DBNull.Value ? null : objRow[convUsers_JT.RegisterDate].ToString().Trim(); //RegisterDate
objvUsers_JTEN.MobilePhone = objRow[convUsers_JT.MobilePhone] == DBNull.Value ? null : objRow[convUsers_JT.MobilePhone].ToString().Trim(); //手机
objvUsers_JTEN.SiteName = objRow[convUsers_JT.SiteName].ToString().Trim(); //工地名称
objvUsers_JTEN.JobCategoryId = objRow[convUsers_JT.JobCategoryId].ToString().Trim(); //岗位类别Id
objvUsers_JTEN.JobCategoryName = objRow[convUsers_JT.JobCategoryName].ToString().Trim(); //岗位类别名
objvUsers_JTEN.ManagedDepartmentId = objRow[convUsers_JT.ManagedDepartmentId].ToString().Trim(); //管理的部门Id
objvUsers_JTEN.ManagedDepartmentName = objRow[convUsers_JT.ManagedDepartmentName].ToString().Trim(); //管理的部门名
objvUsers_JTEN.IDNumber = objRow[convUsers_JT.IDNumber] == DBNull.Value ? null : objRow[convUsers_JT.IDNumber].ToString().Trim(); //身份证号
objvUsers_JTEN.UpdDate = objRow[convUsers_JT.UpdDate].ToString().Trim(); //修改日期
objvUsers_JTEN.UpdUser = objRow[convUsers_JT.UpdUser].ToString().Trim(); //修改人
objvUsers_JTEN.Memo = objRow[convUsers_JT.Memo] == DBNull.Value ? null : objRow[convUsers_JT.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvUsers_JTDA: GetObjLst)", objException.Message));
}
objvUsers_JTEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvUsers_JTEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvUsers_JTEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvUsers_JT(ref clsvUsers_JTEN objvUsers_JTEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUsers_JTDA.GetSpecSQLObj();
strSQL = "Select * from vUsers_JT where UserId = " + "'"+ objvUsers_JTEN.UserId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvUsers_JTEN.UserId = objDT.Rows[0][convUsers_JT.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvUsers_JTEN.UserName = objDT.Rows[0][convUsers_JT.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvUsers_JTEN.Password = objDT.Rows[0][convUsers_JT.Password].ToString().Trim(); //Password(字段类型:varchar,字段长度:20,是否可空:True)
 objvUsers_JTEN.PhoneNumber = objDT.Rows[0][convUsers_JT.PhoneNumber].ToString().Trim(); //PhoneNumber(字段类型:varchar,字段长度:15,是否可空:True)
 objvUsers_JTEN.AuditDate = objDT.Rows[0][convUsers_JT.AuditDate].ToString().Trim(); //AuditDate(字段类型:varchar,字段长度:14,是否可空:True)
 objvUsers_JTEN.AuditUser = objDT.Rows[0][convUsers_JT.AuditUser].ToString().Trim(); //AuditUser(字段类型:varchar,字段长度:18,是否可空:True)
 objvUsers_JTEN.IsAudit = TransNullToBool(objDT.Rows[0][convUsers_JT.IsAudit].ToString().Trim()); //是否审核(字段类型:bit,字段长度:1,是否可空:True)
 objvUsers_JTEN.IsRegister = TransNullToBool(objDT.Rows[0][convUsers_JT.IsRegister].ToString().Trim()); //IsRegister(字段类型:bit,字段长度:1,是否可空:True)
 objvUsers_JTEN.RegisterDate = objDT.Rows[0][convUsers_JT.RegisterDate].ToString().Trim(); //RegisterDate(字段类型:varchar,字段长度:14,是否可空:True)
 objvUsers_JTEN.MobilePhone = objDT.Rows[0][convUsers_JT.MobilePhone].ToString().Trim(); //手机(字段类型:varchar,字段长度:20,是否可空:True)
 objvUsers_JTEN.SiteName = objDT.Rows[0][convUsers_JT.SiteName].ToString().Trim(); //工地名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvUsers_JTEN.JobCategoryId = objDT.Rows[0][convUsers_JT.JobCategoryId].ToString().Trim(); //岗位类别Id(字段类型:char,字段长度:2,是否可空:False)
 objvUsers_JTEN.JobCategoryName = objDT.Rows[0][convUsers_JT.JobCategoryName].ToString().Trim(); //岗位类别名(字段类型:varchar,字段长度:50,是否可空:False)
 objvUsers_JTEN.ManagedDepartmentId = objDT.Rows[0][convUsers_JT.ManagedDepartmentId].ToString().Trim(); //管理的部门Id(字段类型:char,字段长度:4,是否可空:False)
 objvUsers_JTEN.ManagedDepartmentName = objDT.Rows[0][convUsers_JT.ManagedDepartmentName].ToString().Trim(); //管理的部门名(字段类型:varchar,字段长度:50,是否可空:False)
 objvUsers_JTEN.IDNumber = objDT.Rows[0][convUsers_JT.IDNumber].ToString().Trim(); //身份证号(字段类型:varchar,字段长度:18,是否可空:True)
 objvUsers_JTEN.UpdDate = objDT.Rows[0][convUsers_JT.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvUsers_JTEN.UpdUser = objDT.Rows[0][convUsers_JT.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvUsers_JTEN.Memo = objDT.Rows[0][convUsers_JT.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvUsers_JTDA: GetvUsers_JT)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strUserId">表关键字</param>
 /// <returns>表对象</returns>
public clsvUsers_JTEN GetObjByUserId(string strUserId)
{
CheckPrimaryKey(strUserId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUsers_JTDA.GetSpecSQLObj();
strSQL = "Select * from vUsers_JT where UserId = " + "'"+ strUserId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvUsers_JTEN objvUsers_JTEN = new clsvUsers_JTEN();
try
{
 objvUsers_JTEN.UserId = objRow[convUsers_JT.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvUsers_JTEN.UserName = objRow[convUsers_JT.UserName] == DBNull.Value ? null : objRow[convUsers_JT.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvUsers_JTEN.Password = objRow[convUsers_JT.Password] == DBNull.Value ? null : objRow[convUsers_JT.Password].ToString().Trim(); //Password(字段类型:varchar,字段长度:20,是否可空:True)
 objvUsers_JTEN.PhoneNumber = objRow[convUsers_JT.PhoneNumber] == DBNull.Value ? null : objRow[convUsers_JT.PhoneNumber].ToString().Trim(); //PhoneNumber(字段类型:varchar,字段长度:15,是否可空:True)
 objvUsers_JTEN.AuditDate = objRow[convUsers_JT.AuditDate] == DBNull.Value ? null : objRow[convUsers_JT.AuditDate].ToString().Trim(); //AuditDate(字段类型:varchar,字段长度:14,是否可空:True)
 objvUsers_JTEN.AuditUser = objRow[convUsers_JT.AuditUser] == DBNull.Value ? null : objRow[convUsers_JT.AuditUser].ToString().Trim(); //AuditUser(字段类型:varchar,字段长度:18,是否可空:True)
 objvUsers_JTEN.IsAudit = clsEntityBase2.TransNullToBool_S(objRow[convUsers_JT.IsAudit].ToString().Trim()); //是否审核(字段类型:bit,字段长度:1,是否可空:True)
 objvUsers_JTEN.IsRegister = clsEntityBase2.TransNullToBool_S(objRow[convUsers_JT.IsRegister].ToString().Trim()); //IsRegister(字段类型:bit,字段长度:1,是否可空:True)
 objvUsers_JTEN.RegisterDate = objRow[convUsers_JT.RegisterDate] == DBNull.Value ? null : objRow[convUsers_JT.RegisterDate].ToString().Trim(); //RegisterDate(字段类型:varchar,字段长度:14,是否可空:True)
 objvUsers_JTEN.MobilePhone = objRow[convUsers_JT.MobilePhone] == DBNull.Value ? null : objRow[convUsers_JT.MobilePhone].ToString().Trim(); //手机(字段类型:varchar,字段长度:20,是否可空:True)
 objvUsers_JTEN.SiteName = objRow[convUsers_JT.SiteName].ToString().Trim(); //工地名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvUsers_JTEN.JobCategoryId = objRow[convUsers_JT.JobCategoryId].ToString().Trim(); //岗位类别Id(字段类型:char,字段长度:2,是否可空:False)
 objvUsers_JTEN.JobCategoryName = objRow[convUsers_JT.JobCategoryName].ToString().Trim(); //岗位类别名(字段类型:varchar,字段长度:50,是否可空:False)
 objvUsers_JTEN.ManagedDepartmentId = objRow[convUsers_JT.ManagedDepartmentId].ToString().Trim(); //管理的部门Id(字段类型:char,字段长度:4,是否可空:False)
 objvUsers_JTEN.ManagedDepartmentName = objRow[convUsers_JT.ManagedDepartmentName].ToString().Trim(); //管理的部门名(字段类型:varchar,字段长度:50,是否可空:False)
 objvUsers_JTEN.IDNumber = objRow[convUsers_JT.IDNumber] == DBNull.Value ? null : objRow[convUsers_JT.IDNumber].ToString().Trim(); //身份证号(字段类型:varchar,字段长度:18,是否可空:True)
 objvUsers_JTEN.UpdDate = objRow[convUsers_JT.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvUsers_JTEN.UpdUser = objRow[convUsers_JT.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvUsers_JTEN.Memo = objRow[convUsers_JT.Memo] == DBNull.Value ? null : objRow[convUsers_JT.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvUsers_JTDA: GetObjByUserId)", objException.Message));
}
return objvUsers_JTEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvUsers_JTEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvUsers_JTDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUsers_JTDA.GetSpecSQLObj();
strSQL = "Select * from vUsers_JT where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvUsers_JTEN objvUsers_JTEN = new clsvUsers_JTEN()
{
UserId = objRow[convUsers_JT.UserId].ToString().Trim(), //用户ID
UserName = objRow[convUsers_JT.UserName] == DBNull.Value ? null : objRow[convUsers_JT.UserName].ToString().Trim(), //用户名
Password = objRow[convUsers_JT.Password] == DBNull.Value ? null : objRow[convUsers_JT.Password].ToString().Trim(), //Password
PhoneNumber = objRow[convUsers_JT.PhoneNumber] == DBNull.Value ? null : objRow[convUsers_JT.PhoneNumber].ToString().Trim(), //PhoneNumber
AuditDate = objRow[convUsers_JT.AuditDate] == DBNull.Value ? null : objRow[convUsers_JT.AuditDate].ToString().Trim(), //AuditDate
AuditUser = objRow[convUsers_JT.AuditUser] == DBNull.Value ? null : objRow[convUsers_JT.AuditUser].ToString().Trim(), //AuditUser
IsAudit = TransNullToBool(objRow[convUsers_JT.IsAudit].ToString().Trim()), //是否审核
IsRegister = TransNullToBool(objRow[convUsers_JT.IsRegister].ToString().Trim()), //IsRegister
RegisterDate = objRow[convUsers_JT.RegisterDate] == DBNull.Value ? null : objRow[convUsers_JT.RegisterDate].ToString().Trim(), //RegisterDate
MobilePhone = objRow[convUsers_JT.MobilePhone] == DBNull.Value ? null : objRow[convUsers_JT.MobilePhone].ToString().Trim(), //手机
SiteName = objRow[convUsers_JT.SiteName].ToString().Trim(), //工地名称
JobCategoryId = objRow[convUsers_JT.JobCategoryId].ToString().Trim(), //岗位类别Id
JobCategoryName = objRow[convUsers_JT.JobCategoryName].ToString().Trim(), //岗位类别名
ManagedDepartmentId = objRow[convUsers_JT.ManagedDepartmentId].ToString().Trim(), //管理的部门Id
ManagedDepartmentName = objRow[convUsers_JT.ManagedDepartmentName].ToString().Trim(), //管理的部门名
IDNumber = objRow[convUsers_JT.IDNumber] == DBNull.Value ? null : objRow[convUsers_JT.IDNumber].ToString().Trim(), //身份证号
UpdDate = objRow[convUsers_JT.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convUsers_JT.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convUsers_JT.Memo] == DBNull.Value ? null : objRow[convUsers_JT.Memo].ToString().Trim() //备注
};
objvUsers_JTEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvUsers_JTEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvUsers_JTDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvUsers_JTEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvUsers_JTEN objvUsers_JTEN = new clsvUsers_JTEN();
try
{
objvUsers_JTEN.UserId = objRow[convUsers_JT.UserId].ToString().Trim(); //用户ID
objvUsers_JTEN.UserName = objRow[convUsers_JT.UserName] == DBNull.Value ? null : objRow[convUsers_JT.UserName].ToString().Trim(); //用户名
objvUsers_JTEN.Password = objRow[convUsers_JT.Password] == DBNull.Value ? null : objRow[convUsers_JT.Password].ToString().Trim(); //Password
objvUsers_JTEN.PhoneNumber = objRow[convUsers_JT.PhoneNumber] == DBNull.Value ? null : objRow[convUsers_JT.PhoneNumber].ToString().Trim(); //PhoneNumber
objvUsers_JTEN.AuditDate = objRow[convUsers_JT.AuditDate] == DBNull.Value ? null : objRow[convUsers_JT.AuditDate].ToString().Trim(); //AuditDate
objvUsers_JTEN.AuditUser = objRow[convUsers_JT.AuditUser] == DBNull.Value ? null : objRow[convUsers_JT.AuditUser].ToString().Trim(); //AuditUser
objvUsers_JTEN.IsAudit = TransNullToBool(objRow[convUsers_JT.IsAudit].ToString().Trim()); //是否审核
objvUsers_JTEN.IsRegister = TransNullToBool(objRow[convUsers_JT.IsRegister].ToString().Trim()); //IsRegister
objvUsers_JTEN.RegisterDate = objRow[convUsers_JT.RegisterDate] == DBNull.Value ? null : objRow[convUsers_JT.RegisterDate].ToString().Trim(); //RegisterDate
objvUsers_JTEN.MobilePhone = objRow[convUsers_JT.MobilePhone] == DBNull.Value ? null : objRow[convUsers_JT.MobilePhone].ToString().Trim(); //手机
objvUsers_JTEN.SiteName = objRow[convUsers_JT.SiteName].ToString().Trim(); //工地名称
objvUsers_JTEN.JobCategoryId = objRow[convUsers_JT.JobCategoryId].ToString().Trim(); //岗位类别Id
objvUsers_JTEN.JobCategoryName = objRow[convUsers_JT.JobCategoryName].ToString().Trim(); //岗位类别名
objvUsers_JTEN.ManagedDepartmentId = objRow[convUsers_JT.ManagedDepartmentId].ToString().Trim(); //管理的部门Id
objvUsers_JTEN.ManagedDepartmentName = objRow[convUsers_JT.ManagedDepartmentName].ToString().Trim(); //管理的部门名
objvUsers_JTEN.IDNumber = objRow[convUsers_JT.IDNumber] == DBNull.Value ? null : objRow[convUsers_JT.IDNumber].ToString().Trim(); //身份证号
objvUsers_JTEN.UpdDate = objRow[convUsers_JT.UpdDate].ToString().Trim(); //修改日期
objvUsers_JTEN.UpdUser = objRow[convUsers_JT.UpdUser].ToString().Trim(); //修改人
objvUsers_JTEN.Memo = objRow[convUsers_JT.Memo] == DBNull.Value ? null : objRow[convUsers_JT.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvUsers_JTDA: GetObjByDataRowvUsers_JT)", objException.Message));
}
objvUsers_JTEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvUsers_JTEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvUsers_JTEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvUsers_JTEN objvUsers_JTEN = new clsvUsers_JTEN();
try
{
objvUsers_JTEN.UserId = objRow[convUsers_JT.UserId].ToString().Trim(); //用户ID
objvUsers_JTEN.UserName = objRow[convUsers_JT.UserName] == DBNull.Value ? null : objRow[convUsers_JT.UserName].ToString().Trim(); //用户名
objvUsers_JTEN.Password = objRow[convUsers_JT.Password] == DBNull.Value ? null : objRow[convUsers_JT.Password].ToString().Trim(); //Password
objvUsers_JTEN.PhoneNumber = objRow[convUsers_JT.PhoneNumber] == DBNull.Value ? null : objRow[convUsers_JT.PhoneNumber].ToString().Trim(); //PhoneNumber
objvUsers_JTEN.AuditDate = objRow[convUsers_JT.AuditDate] == DBNull.Value ? null : objRow[convUsers_JT.AuditDate].ToString().Trim(); //AuditDate
objvUsers_JTEN.AuditUser = objRow[convUsers_JT.AuditUser] == DBNull.Value ? null : objRow[convUsers_JT.AuditUser].ToString().Trim(); //AuditUser
objvUsers_JTEN.IsAudit = TransNullToBool(objRow[convUsers_JT.IsAudit].ToString().Trim()); //是否审核
objvUsers_JTEN.IsRegister = TransNullToBool(objRow[convUsers_JT.IsRegister].ToString().Trim()); //IsRegister
objvUsers_JTEN.RegisterDate = objRow[convUsers_JT.RegisterDate] == DBNull.Value ? null : objRow[convUsers_JT.RegisterDate].ToString().Trim(); //RegisterDate
objvUsers_JTEN.MobilePhone = objRow[convUsers_JT.MobilePhone] == DBNull.Value ? null : objRow[convUsers_JT.MobilePhone].ToString().Trim(); //手机
objvUsers_JTEN.SiteName = objRow[convUsers_JT.SiteName].ToString().Trim(); //工地名称
objvUsers_JTEN.JobCategoryId = objRow[convUsers_JT.JobCategoryId].ToString().Trim(); //岗位类别Id
objvUsers_JTEN.JobCategoryName = objRow[convUsers_JT.JobCategoryName].ToString().Trim(); //岗位类别名
objvUsers_JTEN.ManagedDepartmentId = objRow[convUsers_JT.ManagedDepartmentId].ToString().Trim(); //管理的部门Id
objvUsers_JTEN.ManagedDepartmentName = objRow[convUsers_JT.ManagedDepartmentName].ToString().Trim(); //管理的部门名
objvUsers_JTEN.IDNumber = objRow[convUsers_JT.IDNumber] == DBNull.Value ? null : objRow[convUsers_JT.IDNumber].ToString().Trim(); //身份证号
objvUsers_JTEN.UpdDate = objRow[convUsers_JT.UpdDate].ToString().Trim(); //修改日期
objvUsers_JTEN.UpdUser = objRow[convUsers_JT.UpdUser].ToString().Trim(); //修改人
objvUsers_JTEN.Memo = objRow[convUsers_JT.Memo] == DBNull.Value ? null : objRow[convUsers_JT.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvUsers_JTDA: GetObjByDataRow)", objException.Message));
}
objvUsers_JTEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvUsers_JTEN;
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
objSQL = clsvUsers_JTDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvUsers_JTEN._CurrTabName, convUsers_JT.UserId, 18, "");
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
objSQL = clsvUsers_JTDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvUsers_JTEN._CurrTabName, convUsers_JT.UserId, 18, strPrefix);
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
 objSQL = clsvUsers_JTDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select UserId from vUsers_JT where " + strCondition;
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
 objSQL = clsvUsers_JTDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select UserId from vUsers_JT where " + strCondition;
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
 objSQL = clsvUsers_JTDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vUsers_JT", "UserId = " + "'"+ strUserId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvUsers_JTDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUsers_JTDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vUsers_JT", strCondition))
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
objSQL = clsvUsers_JTDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vUsers_JT");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvUsers_JTENS">源对象</param>
 /// <param name = "objvUsers_JTENT">目标对象</param>
public void CopyTo(clsvUsers_JTEN objvUsers_JTENS, clsvUsers_JTEN objvUsers_JTENT)
{
objvUsers_JTENT.UserId = objvUsers_JTENS.UserId; //用户ID
objvUsers_JTENT.UserName = objvUsers_JTENS.UserName; //用户名
objvUsers_JTENT.Password = objvUsers_JTENS.Password; //Password
objvUsers_JTENT.PhoneNumber = objvUsers_JTENS.PhoneNumber; //PhoneNumber
objvUsers_JTENT.AuditDate = objvUsers_JTENS.AuditDate; //AuditDate
objvUsers_JTENT.AuditUser = objvUsers_JTENS.AuditUser; //AuditUser
objvUsers_JTENT.IsAudit = objvUsers_JTENS.IsAudit; //是否审核
objvUsers_JTENT.IsRegister = objvUsers_JTENS.IsRegister; //IsRegister
objvUsers_JTENT.RegisterDate = objvUsers_JTENS.RegisterDate; //RegisterDate
objvUsers_JTENT.MobilePhone = objvUsers_JTENS.MobilePhone; //手机
objvUsers_JTENT.SiteName = objvUsers_JTENS.SiteName; //工地名称
objvUsers_JTENT.JobCategoryId = objvUsers_JTENS.JobCategoryId; //岗位类别Id
objvUsers_JTENT.JobCategoryName = objvUsers_JTENS.JobCategoryName; //岗位类别名
objvUsers_JTENT.ManagedDepartmentId = objvUsers_JTENS.ManagedDepartmentId; //管理的部门Id
objvUsers_JTENT.ManagedDepartmentName = objvUsers_JTENS.ManagedDepartmentName; //管理的部门名
objvUsers_JTENT.IDNumber = objvUsers_JTENS.IDNumber; //身份证号
objvUsers_JTENT.UpdDate = objvUsers_JTENS.UpdDate; //修改日期
objvUsers_JTENT.UpdUser = objvUsers_JTENS.UpdUser; //修改人
objvUsers_JTENT.Memo = objvUsers_JTENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvUsers_JTEN objvUsers_JTEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvUsers_JTEN.UserId, 18, convUsers_JT.UserId);
clsCheckSql.CheckFieldLen(objvUsers_JTEN.UserName, 30, convUsers_JT.UserName);
clsCheckSql.CheckFieldLen(objvUsers_JTEN.Password, 20, convUsers_JT.Password);
clsCheckSql.CheckFieldLen(objvUsers_JTEN.PhoneNumber, 15, convUsers_JT.PhoneNumber);
clsCheckSql.CheckFieldLen(objvUsers_JTEN.AuditDate, 14, convUsers_JT.AuditDate);
clsCheckSql.CheckFieldLen(objvUsers_JTEN.AuditUser, 18, convUsers_JT.AuditUser);
clsCheckSql.CheckFieldLen(objvUsers_JTEN.RegisterDate, 14, convUsers_JT.RegisterDate);
clsCheckSql.CheckFieldLen(objvUsers_JTEN.MobilePhone, 20, convUsers_JT.MobilePhone);
clsCheckSql.CheckFieldLen(objvUsers_JTEN.SiteName, 100, convUsers_JT.SiteName);
clsCheckSql.CheckFieldLen(objvUsers_JTEN.JobCategoryId, 2, convUsers_JT.JobCategoryId);
clsCheckSql.CheckFieldLen(objvUsers_JTEN.JobCategoryName, 50, convUsers_JT.JobCategoryName);
clsCheckSql.CheckFieldLen(objvUsers_JTEN.ManagedDepartmentId, 4, convUsers_JT.ManagedDepartmentId);
clsCheckSql.CheckFieldLen(objvUsers_JTEN.ManagedDepartmentName, 50, convUsers_JT.ManagedDepartmentName);
clsCheckSql.CheckFieldLen(objvUsers_JTEN.IDNumber, 18, convUsers_JT.IDNumber);
clsCheckSql.CheckFieldLen(objvUsers_JTEN.UpdDate, 20, convUsers_JT.UpdDate);
clsCheckSql.CheckFieldLen(objvUsers_JTEN.UpdUser, 20, convUsers_JT.UpdUser);
clsCheckSql.CheckFieldLen(objvUsers_JTEN.Memo, 1000, convUsers_JT.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvUsers_JTEN.UserId, convUsers_JT.UserId);
clsCheckSql.CheckSqlInjection4Field(objvUsers_JTEN.UserName, convUsers_JT.UserName);
clsCheckSql.CheckSqlInjection4Field(objvUsers_JTEN.Password, convUsers_JT.Password);
clsCheckSql.CheckSqlInjection4Field(objvUsers_JTEN.PhoneNumber, convUsers_JT.PhoneNumber);
clsCheckSql.CheckSqlInjection4Field(objvUsers_JTEN.AuditDate, convUsers_JT.AuditDate);
clsCheckSql.CheckSqlInjection4Field(objvUsers_JTEN.AuditUser, convUsers_JT.AuditUser);
clsCheckSql.CheckSqlInjection4Field(objvUsers_JTEN.RegisterDate, convUsers_JT.RegisterDate);
clsCheckSql.CheckSqlInjection4Field(objvUsers_JTEN.MobilePhone, convUsers_JT.MobilePhone);
clsCheckSql.CheckSqlInjection4Field(objvUsers_JTEN.SiteName, convUsers_JT.SiteName);
clsCheckSql.CheckSqlInjection4Field(objvUsers_JTEN.JobCategoryId, convUsers_JT.JobCategoryId);
clsCheckSql.CheckSqlInjection4Field(objvUsers_JTEN.JobCategoryName, convUsers_JT.JobCategoryName);
clsCheckSql.CheckSqlInjection4Field(objvUsers_JTEN.ManagedDepartmentId, convUsers_JT.ManagedDepartmentId);
clsCheckSql.CheckSqlInjection4Field(objvUsers_JTEN.ManagedDepartmentName, convUsers_JT.ManagedDepartmentName);
clsCheckSql.CheckSqlInjection4Field(objvUsers_JTEN.IDNumber, convUsers_JT.IDNumber);
clsCheckSql.CheckSqlInjection4Field(objvUsers_JTEN.UpdDate, convUsers_JT.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvUsers_JTEN.UpdUser, convUsers_JT.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvUsers_JTEN.Memo, convUsers_JT.Memo);
//检查外键字段长度
 objvUsers_JTEN._IsCheckProperty = true;
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
 objSQL = clsvUsers_JTDA.GetSpecSQLObj();
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
 objSQL = clsvUsers_JTDA.GetSpecSQLObj();
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
 objSQL = clsvUsers_JTDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvUsers_JTEN._CurrTabName);
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
 objSQL = clsvUsers_JTDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvUsers_JTEN._CurrTabName, strCondition);
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
 objSQL = clsvUsers_JTDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}