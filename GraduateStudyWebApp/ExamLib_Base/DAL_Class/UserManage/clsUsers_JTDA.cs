
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUsers_JTDA
 表名:Users_JT(01120227)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:18:48
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
 /// 用户表_交通(Users_JT)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsUsers_JTDA : clsCommBase4DA
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
 return clsUsers_JTEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsUsers_JTEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsUsers_JTEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsUsers_JTEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsUsers_JTEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:Users_JT中,检查关键字,长度不正确!(clsUsers_JTDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strUserId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:Users_JT中,关键字不能为空 或 null!(clsUsers_JTDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strUserId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsUsers_JTDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsUsers_JTDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsers_JTDA.GetSpecSQLObj();
strSQL = "Select * from Users_JT where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_Users_JT(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsUsers_JTDA: GetDataTable_Users_JT)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsers_JTDA.GetSpecSQLObj();
strSQL = "Select * from Users_JT where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsUsers_JTDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsers_JTDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsUsers_JTDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsers_JTDA.GetSpecSQLObj();
strSQL = "Select * from Users_JT where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsUsers_JTDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsers_JTDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsUsers_JTDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsers_JTDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from Users_JT where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from Users_JT where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsUsers_JTDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsers_JTDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from Users_JT where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsUsers_JTDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsers_JTDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} Users_JT.* from Users_JT Left Join {1} on {2} where {3} and Users_JT.UserId not in (Select top {5} Users_JT.UserId from Users_JT Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from Users_JT where {1} and UserId not in (Select top {2} UserId from Users_JT where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from Users_JT where {1} and UserId not in (Select top {3} UserId from Users_JT where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsUsers_JTDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsers_JTDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} Users_JT.* from Users_JT Left Join {1} on {2} where {3} and Users_JT.UserId not in (Select top {5} Users_JT.UserId from Users_JT Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from Users_JT where {1} and UserId not in (Select top {2} UserId from Users_JT where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from Users_JT where {1} and UserId not in (Select top {3} UserId from Users_JT where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsUsers_JTEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsUsers_JTDA:GetObjLst)", objException.Message));
}
List<clsUsers_JTEN> arrObjLst = new List<clsUsers_JTEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsers_JTDA.GetSpecSQLObj();
strSQL = "Select * from Users_JT where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUsers_JTEN objUsers_JTEN = new clsUsers_JTEN();
try
{
objUsers_JTEN.UserId = objRow[conUsers_JT.UserId].ToString().Trim(); //用户ID
objUsers_JTEN.SiteName = objRow[conUsers_JT.SiteName].ToString().Trim(); //工地名称
objUsers_JTEN.JobCategoryId = objRow[conUsers_JT.JobCategoryId].ToString().Trim(); //岗位类别Id
objUsers_JTEN.ManagedDepartmentId = objRow[conUsers_JT.ManagedDepartmentId].ToString().Trim(); //管理的部门Id
objUsers_JTEN.IDNumber = objRow[conUsers_JT.IDNumber] == DBNull.Value ? null : objRow[conUsers_JT.IDNumber].ToString().Trim(); //身份证号
objUsers_JTEN.UpdDate = objRow[conUsers_JT.UpdDate] == DBNull.Value ? null : objRow[conUsers_JT.UpdDate].ToString().Trim(); //修改日期
objUsers_JTEN.UpdUser = objRow[conUsers_JT.UpdUser] == DBNull.Value ? null : objRow[conUsers_JT.UpdUser].ToString().Trim(); //修改人
objUsers_JTEN.Memo = objRow[conUsers_JT.Memo] == DBNull.Value ? null : objRow[conUsers_JT.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsUsers_JTDA: GetObjLst)", objException.Message));
}
objUsers_JTEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objUsers_JTEN);
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
public List<clsUsers_JTEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsUsers_JTDA:GetObjLstByTabName)", objException.Message));
}
List<clsUsers_JTEN> arrObjLst = new List<clsUsers_JTEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsers_JTDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUsers_JTEN objUsers_JTEN = new clsUsers_JTEN();
try
{
objUsers_JTEN.UserId = objRow[conUsers_JT.UserId].ToString().Trim(); //用户ID
objUsers_JTEN.SiteName = objRow[conUsers_JT.SiteName].ToString().Trim(); //工地名称
objUsers_JTEN.JobCategoryId = objRow[conUsers_JT.JobCategoryId].ToString().Trim(); //岗位类别Id
objUsers_JTEN.ManagedDepartmentId = objRow[conUsers_JT.ManagedDepartmentId].ToString().Trim(); //管理的部门Id
objUsers_JTEN.IDNumber = objRow[conUsers_JT.IDNumber] == DBNull.Value ? null : objRow[conUsers_JT.IDNumber].ToString().Trim(); //身份证号
objUsers_JTEN.UpdDate = objRow[conUsers_JT.UpdDate] == DBNull.Value ? null : objRow[conUsers_JT.UpdDate].ToString().Trim(); //修改日期
objUsers_JTEN.UpdUser = objRow[conUsers_JT.UpdUser] == DBNull.Value ? null : objRow[conUsers_JT.UpdUser].ToString().Trim(); //修改人
objUsers_JTEN.Memo = objRow[conUsers_JT.Memo] == DBNull.Value ? null : objRow[conUsers_JT.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsUsers_JTDA: GetObjLst)", objException.Message));
}
objUsers_JTEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objUsers_JTEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objUsers_JTEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetUsers_JT(ref clsUsers_JTEN objUsers_JTEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsers_JTDA.GetSpecSQLObj();
strSQL = "Select * from Users_JT where UserId = " + "'"+ objUsers_JTEN.UserId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objUsers_JTEN.UserId = objDT.Rows[0][conUsers_JT.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objUsers_JTEN.SiteName = objDT.Rows[0][conUsers_JT.SiteName].ToString().Trim(); //工地名称(字段类型:varchar,字段长度:100,是否可空:False)
 objUsers_JTEN.JobCategoryId = objDT.Rows[0][conUsers_JT.JobCategoryId].ToString().Trim(); //岗位类别Id(字段类型:char,字段长度:2,是否可空:False)
 objUsers_JTEN.ManagedDepartmentId = objDT.Rows[0][conUsers_JT.ManagedDepartmentId].ToString().Trim(); //管理的部门Id(字段类型:char,字段长度:4,是否可空:False)
 objUsers_JTEN.IDNumber = objDT.Rows[0][conUsers_JT.IDNumber].ToString().Trim(); //身份证号(字段类型:varchar,字段长度:18,是否可空:True)
 objUsers_JTEN.UpdDate = objDT.Rows[0][conUsers_JT.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objUsers_JTEN.UpdUser = objDT.Rows[0][conUsers_JT.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objUsers_JTEN.Memo = objDT.Rows[0][conUsers_JT.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsUsers_JTDA: GetUsers_JT)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strUserId">表关键字</param>
 /// <returns>表对象</returns>
public clsUsers_JTEN GetObjByUserId(string strUserId)
{
CheckPrimaryKey(strUserId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsers_JTDA.GetSpecSQLObj();
strSQL = "Select * from Users_JT where UserId = " + "'"+ strUserId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsUsers_JTEN objUsers_JTEN = new clsUsers_JTEN();
try
{
 objUsers_JTEN.UserId = objRow[conUsers_JT.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objUsers_JTEN.SiteName = objRow[conUsers_JT.SiteName].ToString().Trim(); //工地名称(字段类型:varchar,字段长度:100,是否可空:False)
 objUsers_JTEN.JobCategoryId = objRow[conUsers_JT.JobCategoryId].ToString().Trim(); //岗位类别Id(字段类型:char,字段长度:2,是否可空:False)
 objUsers_JTEN.ManagedDepartmentId = objRow[conUsers_JT.ManagedDepartmentId].ToString().Trim(); //管理的部门Id(字段类型:char,字段长度:4,是否可空:False)
 objUsers_JTEN.IDNumber = objRow[conUsers_JT.IDNumber] == DBNull.Value ? null : objRow[conUsers_JT.IDNumber].ToString().Trim(); //身份证号(字段类型:varchar,字段长度:18,是否可空:True)
 objUsers_JTEN.UpdDate = objRow[conUsers_JT.UpdDate] == DBNull.Value ? null : objRow[conUsers_JT.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objUsers_JTEN.UpdUser = objRow[conUsers_JT.UpdUser] == DBNull.Value ? null : objRow[conUsers_JT.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objUsers_JTEN.Memo = objRow[conUsers_JT.Memo] == DBNull.Value ? null : objRow[conUsers_JT.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsUsers_JTDA: GetObjByUserId)", objException.Message));
}
return objUsers_JTEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsUsers_JTEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsUsers_JTDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsers_JTDA.GetSpecSQLObj();
strSQL = "Select * from Users_JT where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsUsers_JTEN objUsers_JTEN = new clsUsers_JTEN()
{
UserId = objRow[conUsers_JT.UserId].ToString().Trim(), //用户ID
SiteName = objRow[conUsers_JT.SiteName].ToString().Trim(), //工地名称
JobCategoryId = objRow[conUsers_JT.JobCategoryId].ToString().Trim(), //岗位类别Id
ManagedDepartmentId = objRow[conUsers_JT.ManagedDepartmentId].ToString().Trim(), //管理的部门Id
IDNumber = objRow[conUsers_JT.IDNumber] == DBNull.Value ? null : objRow[conUsers_JT.IDNumber].ToString().Trim(), //身份证号
UpdDate = objRow[conUsers_JT.UpdDate] == DBNull.Value ? null : objRow[conUsers_JT.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conUsers_JT.UpdUser] == DBNull.Value ? null : objRow[conUsers_JT.UpdUser].ToString().Trim(), //修改人
Memo = objRow[conUsers_JT.Memo] == DBNull.Value ? null : objRow[conUsers_JT.Memo].ToString().Trim() //备注
};
objUsers_JTEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objUsers_JTEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsUsers_JTDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsUsers_JTEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsUsers_JTEN objUsers_JTEN = new clsUsers_JTEN();
try
{
objUsers_JTEN.UserId = objRow[conUsers_JT.UserId].ToString().Trim(); //用户ID
objUsers_JTEN.SiteName = objRow[conUsers_JT.SiteName].ToString().Trim(); //工地名称
objUsers_JTEN.JobCategoryId = objRow[conUsers_JT.JobCategoryId].ToString().Trim(); //岗位类别Id
objUsers_JTEN.ManagedDepartmentId = objRow[conUsers_JT.ManagedDepartmentId].ToString().Trim(); //管理的部门Id
objUsers_JTEN.IDNumber = objRow[conUsers_JT.IDNumber] == DBNull.Value ? null : objRow[conUsers_JT.IDNumber].ToString().Trim(); //身份证号
objUsers_JTEN.UpdDate = objRow[conUsers_JT.UpdDate] == DBNull.Value ? null : objRow[conUsers_JT.UpdDate].ToString().Trim(); //修改日期
objUsers_JTEN.UpdUser = objRow[conUsers_JT.UpdUser] == DBNull.Value ? null : objRow[conUsers_JT.UpdUser].ToString().Trim(); //修改人
objUsers_JTEN.Memo = objRow[conUsers_JT.Memo] == DBNull.Value ? null : objRow[conUsers_JT.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsUsers_JTDA: GetObjByDataRowUsers_JT)", objException.Message));
}
objUsers_JTEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objUsers_JTEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsUsers_JTEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsUsers_JTEN objUsers_JTEN = new clsUsers_JTEN();
try
{
objUsers_JTEN.UserId = objRow[conUsers_JT.UserId].ToString().Trim(); //用户ID
objUsers_JTEN.SiteName = objRow[conUsers_JT.SiteName].ToString().Trim(); //工地名称
objUsers_JTEN.JobCategoryId = objRow[conUsers_JT.JobCategoryId].ToString().Trim(); //岗位类别Id
objUsers_JTEN.ManagedDepartmentId = objRow[conUsers_JT.ManagedDepartmentId].ToString().Trim(); //管理的部门Id
objUsers_JTEN.IDNumber = objRow[conUsers_JT.IDNumber] == DBNull.Value ? null : objRow[conUsers_JT.IDNumber].ToString().Trim(); //身份证号
objUsers_JTEN.UpdDate = objRow[conUsers_JT.UpdDate] == DBNull.Value ? null : objRow[conUsers_JT.UpdDate].ToString().Trim(); //修改日期
objUsers_JTEN.UpdUser = objRow[conUsers_JT.UpdUser] == DBNull.Value ? null : objRow[conUsers_JT.UpdUser].ToString().Trim(); //修改人
objUsers_JTEN.Memo = objRow[conUsers_JT.Memo] == DBNull.Value ? null : objRow[conUsers_JT.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsUsers_JTDA: GetObjByDataRow)", objException.Message));
}
objUsers_JTEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objUsers_JTEN;
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
objSQL = clsUsers_JTDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsUsers_JTEN._CurrTabName, conUsers_JT.UserId, 18, "");
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
objSQL = clsUsers_JTDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsUsers_JTEN._CurrTabName, conUsers_JT.UserId, 18, strPrefix);
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
 objSQL = clsUsers_JTDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select UserId from Users_JT where " + strCondition;
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
 objSQL = clsUsers_JTDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select UserId from Users_JT where " + strCondition;
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
 objSQL = clsUsers_JTDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("Users_JT", "UserId = " + "'"+ strUserId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsUsers_JTDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsers_JTDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("Users_JT", strCondition))
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
objSQL = clsUsers_JTDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("Users_JT");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsUsers_JTEN objUsers_JTEN)
 {
 objUsers_JTEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUsers_JTEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUsers_JTEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsers_JTDA.GetSpecSQLObj();
strSQL = "Select * from Users_JT where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "Users_JT");
objRow = objDS.Tables["Users_JT"].NewRow();
objRow[conUsers_JT.UserId] = objUsers_JTEN.UserId; //用户ID
objRow[conUsers_JT.SiteName] = objUsers_JTEN.SiteName; //工地名称
objRow[conUsers_JT.JobCategoryId] = objUsers_JTEN.JobCategoryId; //岗位类别Id
objRow[conUsers_JT.ManagedDepartmentId] = objUsers_JTEN.ManagedDepartmentId; //管理的部门Id
 if (objUsers_JTEN.IDNumber !=  "")
 {
objRow[conUsers_JT.IDNumber] = objUsers_JTEN.IDNumber; //身份证号
 }
 if (objUsers_JTEN.UpdDate !=  "")
 {
objRow[conUsers_JT.UpdDate] = objUsers_JTEN.UpdDate; //修改日期
 }
 if (objUsers_JTEN.UpdUser !=  "")
 {
objRow[conUsers_JT.UpdUser] = objUsers_JTEN.UpdUser; //修改人
 }
 if (objUsers_JTEN.Memo !=  "")
 {
objRow[conUsers_JT.Memo] = objUsers_JTEN.Memo; //备注
 }
objDS.Tables[clsUsers_JTEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsUsers_JTEN._CurrTabName);
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
 /// <param name = "objUsers_JTEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsUsers_JTEN objUsers_JTEN)
{
 objUsers_JTEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUsers_JTEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUsers_JTEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objUsers_JTEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conUsers_JT.UserId);
 var strUserId = objUsers_JTEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objUsers_JTEN.SiteName !=  null)
 {
 arrFieldListForInsert.Add(conUsers_JT.SiteName);
 var strSiteName = objUsers_JTEN.SiteName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSiteName + "'");
 }
 
 if (objUsers_JTEN.JobCategoryId !=  null)
 {
 arrFieldListForInsert.Add(conUsers_JT.JobCategoryId);
 var strJobCategoryId = objUsers_JTEN.JobCategoryId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strJobCategoryId + "'");
 }
 
 if (objUsers_JTEN.ManagedDepartmentId !=  null)
 {
 arrFieldListForInsert.Add(conUsers_JT.ManagedDepartmentId);
 var strManagedDepartmentId = objUsers_JTEN.ManagedDepartmentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strManagedDepartmentId + "'");
 }
 
 if (objUsers_JTEN.IDNumber !=  null)
 {
 arrFieldListForInsert.Add(conUsers_JT.IDNumber);
 var strIDNumber = objUsers_JTEN.IDNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIDNumber + "'");
 }
 
 if (objUsers_JTEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conUsers_JT.UpdDate);
 var strUpdDate = objUsers_JTEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objUsers_JTEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conUsers_JT.UpdUser);
 var strUpdUser = objUsers_JTEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objUsers_JTEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conUsers_JT.Memo);
 var strMemo = objUsers_JTEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Users_JT");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsers_JTDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objUsers_JTEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsUsers_JTEN objUsers_JTEN)
{
 objUsers_JTEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUsers_JTEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUsers_JTEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objUsers_JTEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conUsers_JT.UserId);
 var strUserId = objUsers_JTEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objUsers_JTEN.SiteName !=  null)
 {
 arrFieldListForInsert.Add(conUsers_JT.SiteName);
 var strSiteName = objUsers_JTEN.SiteName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSiteName + "'");
 }
 
 if (objUsers_JTEN.JobCategoryId !=  null)
 {
 arrFieldListForInsert.Add(conUsers_JT.JobCategoryId);
 var strJobCategoryId = objUsers_JTEN.JobCategoryId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strJobCategoryId + "'");
 }
 
 if (objUsers_JTEN.ManagedDepartmentId !=  null)
 {
 arrFieldListForInsert.Add(conUsers_JT.ManagedDepartmentId);
 var strManagedDepartmentId = objUsers_JTEN.ManagedDepartmentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strManagedDepartmentId + "'");
 }
 
 if (objUsers_JTEN.IDNumber !=  null)
 {
 arrFieldListForInsert.Add(conUsers_JT.IDNumber);
 var strIDNumber = objUsers_JTEN.IDNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIDNumber + "'");
 }
 
 if (objUsers_JTEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conUsers_JT.UpdDate);
 var strUpdDate = objUsers_JTEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objUsers_JTEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conUsers_JT.UpdUser);
 var strUpdUser = objUsers_JTEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objUsers_JTEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conUsers_JT.Memo);
 var strMemo = objUsers_JTEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Users_JT");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsers_JTDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objUsers_JTEN.UserId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objUsers_JTEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsUsers_JTEN objUsers_JTEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objUsers_JTEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUsers_JTEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUsers_JTEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objUsers_JTEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conUsers_JT.UserId);
 var strUserId = objUsers_JTEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objUsers_JTEN.SiteName !=  null)
 {
 arrFieldListForInsert.Add(conUsers_JT.SiteName);
 var strSiteName = objUsers_JTEN.SiteName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSiteName + "'");
 }
 
 if (objUsers_JTEN.JobCategoryId !=  null)
 {
 arrFieldListForInsert.Add(conUsers_JT.JobCategoryId);
 var strJobCategoryId = objUsers_JTEN.JobCategoryId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strJobCategoryId + "'");
 }
 
 if (objUsers_JTEN.ManagedDepartmentId !=  null)
 {
 arrFieldListForInsert.Add(conUsers_JT.ManagedDepartmentId);
 var strManagedDepartmentId = objUsers_JTEN.ManagedDepartmentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strManagedDepartmentId + "'");
 }
 
 if (objUsers_JTEN.IDNumber !=  null)
 {
 arrFieldListForInsert.Add(conUsers_JT.IDNumber);
 var strIDNumber = objUsers_JTEN.IDNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIDNumber + "'");
 }
 
 if (objUsers_JTEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conUsers_JT.UpdDate);
 var strUpdDate = objUsers_JTEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objUsers_JTEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conUsers_JT.UpdUser);
 var strUpdUser = objUsers_JTEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objUsers_JTEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conUsers_JT.Memo);
 var strMemo = objUsers_JTEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Users_JT");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsers_JTDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objUsers_JTEN.UserId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objUsers_JTEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsUsers_JTEN objUsers_JTEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objUsers_JTEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUsers_JTEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUsers_JTEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objUsers_JTEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conUsers_JT.UserId);
 var strUserId = objUsers_JTEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objUsers_JTEN.SiteName !=  null)
 {
 arrFieldListForInsert.Add(conUsers_JT.SiteName);
 var strSiteName = objUsers_JTEN.SiteName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSiteName + "'");
 }
 
 if (objUsers_JTEN.JobCategoryId !=  null)
 {
 arrFieldListForInsert.Add(conUsers_JT.JobCategoryId);
 var strJobCategoryId = objUsers_JTEN.JobCategoryId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strJobCategoryId + "'");
 }
 
 if (objUsers_JTEN.ManagedDepartmentId !=  null)
 {
 arrFieldListForInsert.Add(conUsers_JT.ManagedDepartmentId);
 var strManagedDepartmentId = objUsers_JTEN.ManagedDepartmentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strManagedDepartmentId + "'");
 }
 
 if (objUsers_JTEN.IDNumber !=  null)
 {
 arrFieldListForInsert.Add(conUsers_JT.IDNumber);
 var strIDNumber = objUsers_JTEN.IDNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIDNumber + "'");
 }
 
 if (objUsers_JTEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conUsers_JT.UpdDate);
 var strUpdDate = objUsers_JTEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objUsers_JTEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conUsers_JT.UpdUser);
 var strUpdUser = objUsers_JTEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objUsers_JTEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conUsers_JT.Memo);
 var strMemo = objUsers_JTEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Users_JT");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsers_JTDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewUsers_JTs(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsers_JTDA.GetSpecSQLObj();
strSQL = "Select * from Users_JT where UserId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "Users_JT");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strUserId = oRow[conUsers_JT.UserId].ToString().Trim();
if (IsExist(strUserId))
{
 string strResult = "关键字变量值为:" + string.Format("UserId = {0}", strUserId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsUsers_JTEN._CurrTabName ].NewRow();
objRow[conUsers_JT.UserId] = oRow[conUsers_JT.UserId].ToString().Trim(); //用户ID
objRow[conUsers_JT.SiteName] = oRow[conUsers_JT.SiteName].ToString().Trim(); //工地名称
objRow[conUsers_JT.JobCategoryId] = oRow[conUsers_JT.JobCategoryId].ToString().Trim(); //岗位类别Id
objRow[conUsers_JT.ManagedDepartmentId] = oRow[conUsers_JT.ManagedDepartmentId].ToString().Trim(); //管理的部门Id
objRow[conUsers_JT.IDNumber] = oRow[conUsers_JT.IDNumber].ToString().Trim(); //身份证号
objRow[conUsers_JT.UpdDate] = oRow[conUsers_JT.UpdDate].ToString().Trim(); //修改日期
objRow[conUsers_JT.UpdUser] = oRow[conUsers_JT.UpdUser].ToString().Trim(); //修改人
objRow[conUsers_JT.Memo] = oRow[conUsers_JT.Memo].ToString().Trim(); //备注
 objDS.Tables[clsUsers_JTEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsUsers_JTEN._CurrTabName);
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
 /// <param name = "objUsers_JTEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsUsers_JTEN objUsers_JTEN)
{
 objUsers_JTEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUsers_JTEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUsers_JTEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsers_JTDA.GetSpecSQLObj();
strSQL = "Select * from Users_JT where UserId = " + "'"+ objUsers_JTEN.UserId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsUsers_JTEN._CurrTabName);
if (objDS.Tables[clsUsers_JTEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:UserId = " + "'"+ objUsers_JTEN.UserId+"'");
return false;
}
objRow = objDS.Tables[clsUsers_JTEN._CurrTabName].Rows[0];
 if (objUsers_JTEN.IsUpdated(conUsers_JT.UserId))
 {
objRow[conUsers_JT.UserId] = objUsers_JTEN.UserId; //用户ID
 }
 if (objUsers_JTEN.IsUpdated(conUsers_JT.SiteName))
 {
objRow[conUsers_JT.SiteName] = objUsers_JTEN.SiteName; //工地名称
 }
 if (objUsers_JTEN.IsUpdated(conUsers_JT.JobCategoryId))
 {
objRow[conUsers_JT.JobCategoryId] = objUsers_JTEN.JobCategoryId; //岗位类别Id
 }
 if (objUsers_JTEN.IsUpdated(conUsers_JT.ManagedDepartmentId))
 {
objRow[conUsers_JT.ManagedDepartmentId] = objUsers_JTEN.ManagedDepartmentId; //管理的部门Id
 }
 if (objUsers_JTEN.IsUpdated(conUsers_JT.IDNumber))
 {
objRow[conUsers_JT.IDNumber] = objUsers_JTEN.IDNumber; //身份证号
 }
 if (objUsers_JTEN.IsUpdated(conUsers_JT.UpdDate))
 {
objRow[conUsers_JT.UpdDate] = objUsers_JTEN.UpdDate; //修改日期
 }
 if (objUsers_JTEN.IsUpdated(conUsers_JT.UpdUser))
 {
objRow[conUsers_JT.UpdUser] = objUsers_JTEN.UpdUser; //修改人
 }
 if (objUsers_JTEN.IsUpdated(conUsers_JT.Memo))
 {
objRow[conUsers_JT.Memo] = objUsers_JTEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsUsers_JTEN._CurrTabName);
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
 /// <param name = "objUsers_JTEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsUsers_JTEN objUsers_JTEN)
{
 objUsers_JTEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUsers_JTEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUsers_JTEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsers_JTDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update Users_JT Set ");
 
 if (objUsers_JTEN.IsUpdated(conUsers_JT.SiteName))
 {
 if (objUsers_JTEN.SiteName !=  null)
 {
 var strSiteName = objUsers_JTEN.SiteName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSiteName, conUsers_JT.SiteName); //工地名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUsers_JT.SiteName); //工地名称
 }
 }
 
 if (objUsers_JTEN.IsUpdated(conUsers_JT.JobCategoryId))
 {
 if (objUsers_JTEN.JobCategoryId !=  null)
 {
 var strJobCategoryId = objUsers_JTEN.JobCategoryId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strJobCategoryId, conUsers_JT.JobCategoryId); //岗位类别Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUsers_JT.JobCategoryId); //岗位类别Id
 }
 }
 
 if (objUsers_JTEN.IsUpdated(conUsers_JT.ManagedDepartmentId))
 {
 if (objUsers_JTEN.ManagedDepartmentId !=  null)
 {
 var strManagedDepartmentId = objUsers_JTEN.ManagedDepartmentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strManagedDepartmentId, conUsers_JT.ManagedDepartmentId); //管理的部门Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUsers_JT.ManagedDepartmentId); //管理的部门Id
 }
 }
 
 if (objUsers_JTEN.IsUpdated(conUsers_JT.IDNumber))
 {
 if (objUsers_JTEN.IDNumber !=  null)
 {
 var strIDNumber = objUsers_JTEN.IDNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIDNumber, conUsers_JT.IDNumber); //身份证号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUsers_JT.IDNumber); //身份证号
 }
 }
 
 if (objUsers_JTEN.IsUpdated(conUsers_JT.UpdDate))
 {
 if (objUsers_JTEN.UpdDate !=  null)
 {
 var strUpdDate = objUsers_JTEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conUsers_JT.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUsers_JT.UpdDate); //修改日期
 }
 }
 
 if (objUsers_JTEN.IsUpdated(conUsers_JT.UpdUser))
 {
 if (objUsers_JTEN.UpdUser !=  null)
 {
 var strUpdUser = objUsers_JTEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conUsers_JT.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUsers_JT.UpdUser); //修改人
 }
 }
 
 if (objUsers_JTEN.IsUpdated(conUsers_JT.Memo))
 {
 if (objUsers_JTEN.Memo !=  null)
 {
 var strMemo = objUsers_JTEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conUsers_JT.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUsers_JT.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where UserId = '{0}'", objUsers_JTEN.UserId); 
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
 /// <param name = "objUsers_JTEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsUsers_JTEN objUsers_JTEN, string strCondition)
{
 objUsers_JTEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUsers_JTEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUsers_JTEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsers_JTDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update Users_JT Set ");
 
 if (objUsers_JTEN.IsUpdated(conUsers_JT.SiteName))
 {
 if (objUsers_JTEN.SiteName !=  null)
 {
 var strSiteName = objUsers_JTEN.SiteName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SiteName = '{0}',", strSiteName); //工地名称
 }
 else
 {
 sbSQL.Append(" SiteName = null,"); //工地名称
 }
 }
 
 if (objUsers_JTEN.IsUpdated(conUsers_JT.JobCategoryId))
 {
 if (objUsers_JTEN.JobCategoryId !=  null)
 {
 var strJobCategoryId = objUsers_JTEN.JobCategoryId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" JobCategoryId = '{0}',", strJobCategoryId); //岗位类别Id
 }
 else
 {
 sbSQL.Append(" JobCategoryId = null,"); //岗位类别Id
 }
 }
 
 if (objUsers_JTEN.IsUpdated(conUsers_JT.ManagedDepartmentId))
 {
 if (objUsers_JTEN.ManagedDepartmentId !=  null)
 {
 var strManagedDepartmentId = objUsers_JTEN.ManagedDepartmentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ManagedDepartmentId = '{0}',", strManagedDepartmentId); //管理的部门Id
 }
 else
 {
 sbSQL.Append(" ManagedDepartmentId = null,"); //管理的部门Id
 }
 }
 
 if (objUsers_JTEN.IsUpdated(conUsers_JT.IDNumber))
 {
 if (objUsers_JTEN.IDNumber !=  null)
 {
 var strIDNumber = objUsers_JTEN.IDNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IDNumber = '{0}',", strIDNumber); //身份证号
 }
 else
 {
 sbSQL.Append(" IDNumber = null,"); //身份证号
 }
 }
 
 if (objUsers_JTEN.IsUpdated(conUsers_JT.UpdDate))
 {
 if (objUsers_JTEN.UpdDate !=  null)
 {
 var strUpdDate = objUsers_JTEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objUsers_JTEN.IsUpdated(conUsers_JT.UpdUser))
 {
 if (objUsers_JTEN.UpdUser !=  null)
 {
 var strUpdUser = objUsers_JTEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objUsers_JTEN.IsUpdated(conUsers_JT.Memo))
 {
 if (objUsers_JTEN.Memo !=  null)
 {
 var strMemo = objUsers_JTEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objUsers_JTEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsUsers_JTEN objUsers_JTEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objUsers_JTEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUsers_JTEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUsers_JTEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsers_JTDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update Users_JT Set ");
 
 if (objUsers_JTEN.IsUpdated(conUsers_JT.SiteName))
 {
 if (objUsers_JTEN.SiteName !=  null)
 {
 var strSiteName = objUsers_JTEN.SiteName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SiteName = '{0}',", strSiteName); //工地名称
 }
 else
 {
 sbSQL.Append(" SiteName = null,"); //工地名称
 }
 }
 
 if (objUsers_JTEN.IsUpdated(conUsers_JT.JobCategoryId))
 {
 if (objUsers_JTEN.JobCategoryId !=  null)
 {
 var strJobCategoryId = objUsers_JTEN.JobCategoryId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" JobCategoryId = '{0}',", strJobCategoryId); //岗位类别Id
 }
 else
 {
 sbSQL.Append(" JobCategoryId = null,"); //岗位类别Id
 }
 }
 
 if (objUsers_JTEN.IsUpdated(conUsers_JT.ManagedDepartmentId))
 {
 if (objUsers_JTEN.ManagedDepartmentId !=  null)
 {
 var strManagedDepartmentId = objUsers_JTEN.ManagedDepartmentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ManagedDepartmentId = '{0}',", strManagedDepartmentId); //管理的部门Id
 }
 else
 {
 sbSQL.Append(" ManagedDepartmentId = null,"); //管理的部门Id
 }
 }
 
 if (objUsers_JTEN.IsUpdated(conUsers_JT.IDNumber))
 {
 if (objUsers_JTEN.IDNumber !=  null)
 {
 var strIDNumber = objUsers_JTEN.IDNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IDNumber = '{0}',", strIDNumber); //身份证号
 }
 else
 {
 sbSQL.Append(" IDNumber = null,"); //身份证号
 }
 }
 
 if (objUsers_JTEN.IsUpdated(conUsers_JT.UpdDate))
 {
 if (objUsers_JTEN.UpdDate !=  null)
 {
 var strUpdDate = objUsers_JTEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objUsers_JTEN.IsUpdated(conUsers_JT.UpdUser))
 {
 if (objUsers_JTEN.UpdUser !=  null)
 {
 var strUpdUser = objUsers_JTEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objUsers_JTEN.IsUpdated(conUsers_JT.Memo))
 {
 if (objUsers_JTEN.Memo !=  null)
 {
 var strMemo = objUsers_JTEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objUsers_JTEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsUsers_JTEN objUsers_JTEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objUsers_JTEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUsers_JTEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUsers_JTEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsers_JTDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update Users_JT Set ");
 
 if (objUsers_JTEN.IsUpdated(conUsers_JT.SiteName))
 {
 if (objUsers_JTEN.SiteName !=  null)
 {
 var strSiteName = objUsers_JTEN.SiteName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSiteName, conUsers_JT.SiteName); //工地名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUsers_JT.SiteName); //工地名称
 }
 }
 
 if (objUsers_JTEN.IsUpdated(conUsers_JT.JobCategoryId))
 {
 if (objUsers_JTEN.JobCategoryId !=  null)
 {
 var strJobCategoryId = objUsers_JTEN.JobCategoryId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strJobCategoryId, conUsers_JT.JobCategoryId); //岗位类别Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUsers_JT.JobCategoryId); //岗位类别Id
 }
 }
 
 if (objUsers_JTEN.IsUpdated(conUsers_JT.ManagedDepartmentId))
 {
 if (objUsers_JTEN.ManagedDepartmentId !=  null)
 {
 var strManagedDepartmentId = objUsers_JTEN.ManagedDepartmentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strManagedDepartmentId, conUsers_JT.ManagedDepartmentId); //管理的部门Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUsers_JT.ManagedDepartmentId); //管理的部门Id
 }
 }
 
 if (objUsers_JTEN.IsUpdated(conUsers_JT.IDNumber))
 {
 if (objUsers_JTEN.IDNumber !=  null)
 {
 var strIDNumber = objUsers_JTEN.IDNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIDNumber, conUsers_JT.IDNumber); //身份证号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUsers_JT.IDNumber); //身份证号
 }
 }
 
 if (objUsers_JTEN.IsUpdated(conUsers_JT.UpdDate))
 {
 if (objUsers_JTEN.UpdDate !=  null)
 {
 var strUpdDate = objUsers_JTEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conUsers_JT.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUsers_JT.UpdDate); //修改日期
 }
 }
 
 if (objUsers_JTEN.IsUpdated(conUsers_JT.UpdUser))
 {
 if (objUsers_JTEN.UpdUser !=  null)
 {
 var strUpdUser = objUsers_JTEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conUsers_JT.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUsers_JT.UpdUser); //修改人
 }
 }
 
 if (objUsers_JTEN.IsUpdated(conUsers_JT.Memo))
 {
 if (objUsers_JTEN.Memo !=  null)
 {
 var strMemo = objUsers_JTEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conUsers_JT.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUsers_JT.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where UserId = '{0}'", objUsers_JTEN.UserId); 
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
 objSQL = clsUsers_JTDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strUserId,
};
 objSQL.ExecSP("Users_JT_Delete", values);
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
 objSQL = clsUsers_JTDA.GetSpecSQLObj();
//删除Users_JT本表中与当前对象有关的记录
strSQL = strSQL + "Delete from Users_JT where UserId = " + "'"+ strUserId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelUsers_JT(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsers_JTDA.GetSpecSQLObj();
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
//删除Users_JT本表中与当前对象有关的记录
strSQL = strSQL + "Delete from Users_JT where UserId in (" + strKeyList + ")";
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
 objSQL = clsUsers_JTDA.GetSpecSQLObj();
//删除Users_JT本表中与当前对象有关的记录
strSQL = strSQL + "Delete from Users_JT where UserId = " + "'"+ strUserId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelUsers_JT(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsUsers_JTDA: DelUsers_JT)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsers_JTDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from Users_JT where " + strCondition ;
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
public bool DelUsers_JTWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsUsers_JTDA: DelUsers_JTWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsers_JTDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from Users_JT where " + strCondition ;
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
 /// <param name = "objUsers_JTENS">源对象</param>
 /// <param name = "objUsers_JTENT">目标对象</param>
public void CopyTo(clsUsers_JTEN objUsers_JTENS, clsUsers_JTEN objUsers_JTENT)
{
objUsers_JTENT.UserId = objUsers_JTENS.UserId; //用户ID
objUsers_JTENT.SiteName = objUsers_JTENS.SiteName; //工地名称
objUsers_JTENT.JobCategoryId = objUsers_JTENS.JobCategoryId; //岗位类别Id
objUsers_JTENT.ManagedDepartmentId = objUsers_JTENS.ManagedDepartmentId; //管理的部门Id
objUsers_JTENT.IDNumber = objUsers_JTENS.IDNumber; //身份证号
objUsers_JTENT.UpdDate = objUsers_JTENS.UpdDate; //修改日期
objUsers_JTENT.UpdUser = objUsers_JTENS.UpdUser; //修改人
objUsers_JTENT.Memo = objUsers_JTENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsUsers_JTEN objUsers_JTEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objUsers_JTEN.SiteName, conUsers_JT.SiteName);
clsCheckSql.CheckFieldNotNull(objUsers_JTEN.JobCategoryId, conUsers_JT.JobCategoryId);
clsCheckSql.CheckFieldNotNull(objUsers_JTEN.ManagedDepartmentId, conUsers_JT.ManagedDepartmentId);
//检查字段长度
clsCheckSql.CheckFieldLen(objUsers_JTEN.UserId, 18, conUsers_JT.UserId);
clsCheckSql.CheckFieldLen(objUsers_JTEN.SiteName, 100, conUsers_JT.SiteName);
clsCheckSql.CheckFieldLen(objUsers_JTEN.JobCategoryId, 2, conUsers_JT.JobCategoryId);
clsCheckSql.CheckFieldLen(objUsers_JTEN.ManagedDepartmentId, 4, conUsers_JT.ManagedDepartmentId);
clsCheckSql.CheckFieldLen(objUsers_JTEN.IDNumber, 18, conUsers_JT.IDNumber);
clsCheckSql.CheckFieldLen(objUsers_JTEN.UpdDate, 20, conUsers_JT.UpdDate);
clsCheckSql.CheckFieldLen(objUsers_JTEN.UpdUser, 20, conUsers_JT.UpdUser);
clsCheckSql.CheckFieldLen(objUsers_JTEN.Memo, 1000, conUsers_JT.Memo);
//检查字段外键固定长度
 objUsers_JTEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsUsers_JTEN objUsers_JTEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objUsers_JTEN.SiteName, 100, conUsers_JT.SiteName);
clsCheckSql.CheckFieldLen(objUsers_JTEN.JobCategoryId, 2, conUsers_JT.JobCategoryId);
clsCheckSql.CheckFieldLen(objUsers_JTEN.ManagedDepartmentId, 4, conUsers_JT.ManagedDepartmentId);
clsCheckSql.CheckFieldLen(objUsers_JTEN.IDNumber, 18, conUsers_JT.IDNumber);
clsCheckSql.CheckFieldLen(objUsers_JTEN.UpdDate, 20, conUsers_JT.UpdDate);
clsCheckSql.CheckFieldLen(objUsers_JTEN.UpdUser, 20, conUsers_JT.UpdUser);
clsCheckSql.CheckFieldLen(objUsers_JTEN.Memo, 1000, conUsers_JT.Memo);
//检查外键字段长度
 objUsers_JTEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsUsers_JTEN objUsers_JTEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objUsers_JTEN.UserId, 18, conUsers_JT.UserId);
clsCheckSql.CheckFieldLen(objUsers_JTEN.SiteName, 100, conUsers_JT.SiteName);
clsCheckSql.CheckFieldLen(objUsers_JTEN.JobCategoryId, 2, conUsers_JT.JobCategoryId);
clsCheckSql.CheckFieldLen(objUsers_JTEN.ManagedDepartmentId, 4, conUsers_JT.ManagedDepartmentId);
clsCheckSql.CheckFieldLen(objUsers_JTEN.IDNumber, 18, conUsers_JT.IDNumber);
clsCheckSql.CheckFieldLen(objUsers_JTEN.UpdDate, 20, conUsers_JT.UpdDate);
clsCheckSql.CheckFieldLen(objUsers_JTEN.UpdUser, 20, conUsers_JT.UpdUser);
clsCheckSql.CheckFieldLen(objUsers_JTEN.Memo, 1000, conUsers_JT.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objUsers_JTEN.UserId, conUsers_JT.UserId);
clsCheckSql.CheckSqlInjection4Field(objUsers_JTEN.SiteName, conUsers_JT.SiteName);
clsCheckSql.CheckSqlInjection4Field(objUsers_JTEN.JobCategoryId, conUsers_JT.JobCategoryId);
clsCheckSql.CheckSqlInjection4Field(objUsers_JTEN.ManagedDepartmentId, conUsers_JT.ManagedDepartmentId);
clsCheckSql.CheckSqlInjection4Field(objUsers_JTEN.IDNumber, conUsers_JT.IDNumber);
clsCheckSql.CheckSqlInjection4Field(objUsers_JTEN.UpdDate, conUsers_JT.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objUsers_JTEN.UpdUser, conUsers_JT.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objUsers_JTEN.Memo, conUsers_JT.Memo);
//检查外键字段长度
 objUsers_JTEN._IsCheckProperty = true;
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
 objSQL = clsUsers_JTDA.GetSpecSQLObj();
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
 objSQL = clsUsers_JTDA.GetSpecSQLObj();
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
 objSQL = clsUsers_JTDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsUsers_JTEN._CurrTabName);
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
 objSQL = clsUsers_JTDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsUsers_JTEN._CurrTabName, strCondition);
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
 objSQL = clsUsers_JTDA.GetSpecSQLObj();
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
 objSQL = clsUsers_JTDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}