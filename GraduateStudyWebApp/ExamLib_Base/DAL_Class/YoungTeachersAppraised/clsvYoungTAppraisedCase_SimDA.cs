
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvYoungTAppraisedCase_SimDA
 表名:vYoungTAppraisedCase_Sim(01120521)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:51:26
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:青教评优(YoungTeachersAppraised)
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
 /// vYoungTAppraisedCase_Sim(vYoungTAppraisedCase_Sim)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvYoungTAppraisedCase_SimDA : clsCommBase4DA
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
 return clsvYoungTAppraisedCase_SimEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvYoungTAppraisedCase_SimEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvYoungTAppraisedCase_SimEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvYoungTAppraisedCase_SimEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvYoungTAppraisedCase_SimEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strIdYoungTAppraisedCase">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strIdYoungTAppraisedCase)
{
strIdYoungTAppraisedCase = strIdYoungTAppraisedCase.Replace("'", "''");
if (strIdYoungTAppraisedCase.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vYoungTAppraisedCase_Sim中,检查关键字,长度不正确!(clsvYoungTAppraisedCase_SimDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdYoungTAppraisedCase)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vYoungTAppraisedCase_Sim中,关键字不能为空 或 null!(clsvYoungTAppraisedCase_SimDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdYoungTAppraisedCase);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvYoungTAppraisedCase_SimDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvYoungTAppraisedCase_SimDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCase_SimDA.GetSpecSQLObj();
strSQL = "Select * from vYoungTAppraisedCase_Sim where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vYoungTAppraisedCase_Sim(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvYoungTAppraisedCase_SimDA: GetDataTable_vYoungTAppraisedCase_Sim)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCase_SimDA.GetSpecSQLObj();
strSQL = "Select * from vYoungTAppraisedCase_Sim where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvYoungTAppraisedCase_SimDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCase_SimDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvYoungTAppraisedCase_SimDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCase_SimDA.GetSpecSQLObj();
strSQL = "Select * from vYoungTAppraisedCase_Sim where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvYoungTAppraisedCase_SimDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCase_SimDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvYoungTAppraisedCase_SimDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCase_SimDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vYoungTAppraisedCase_Sim where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vYoungTAppraisedCase_Sim where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvYoungTAppraisedCase_SimDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCase_SimDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vYoungTAppraisedCase_Sim where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvYoungTAppraisedCase_SimDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCase_SimDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vYoungTAppraisedCase_Sim.* from vYoungTAppraisedCase_Sim Left Join {1} on {2} where {3} and vYoungTAppraisedCase_Sim.IdYoungTAppraisedCase not in (Select top {5} vYoungTAppraisedCase_Sim.IdYoungTAppraisedCase from vYoungTAppraisedCase_Sim Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vYoungTAppraisedCase_Sim where {1} and IdYoungTAppraisedCase not in (Select top {2} IdYoungTAppraisedCase from vYoungTAppraisedCase_Sim where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vYoungTAppraisedCase_Sim where {1} and IdYoungTAppraisedCase not in (Select top {3} IdYoungTAppraisedCase from vYoungTAppraisedCase_Sim where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvYoungTAppraisedCase_SimDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCase_SimDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vYoungTAppraisedCase_Sim.* from vYoungTAppraisedCase_Sim Left Join {1} on {2} where {3} and vYoungTAppraisedCase_Sim.IdYoungTAppraisedCase not in (Select top {5} vYoungTAppraisedCase_Sim.IdYoungTAppraisedCase from vYoungTAppraisedCase_Sim Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vYoungTAppraisedCase_Sim where {1} and IdYoungTAppraisedCase not in (Select top {2} IdYoungTAppraisedCase from vYoungTAppraisedCase_Sim where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vYoungTAppraisedCase_Sim where {1} and IdYoungTAppraisedCase not in (Select top {3} IdYoungTAppraisedCase from vYoungTAppraisedCase_Sim where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvYoungTAppraisedCase_SimEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvYoungTAppraisedCase_SimDA:GetObjLst)", objException.Message));
}
List<clsvYoungTAppraisedCase_SimEN> arrObjLst = new List<clsvYoungTAppraisedCase_SimEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCase_SimDA.GetSpecSQLObj();
strSQL = "Select * from vYoungTAppraisedCase_Sim where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvYoungTAppraisedCase_SimEN objvYoungTAppraisedCase_SimEN = new clsvYoungTAppraisedCase_SimEN();
try
{
objvYoungTAppraisedCase_SimEN.IdYoungTAppraisedCase = objRow[convYoungTAppraisedCase_Sim.IdYoungTAppraisedCase].ToString().Trim(); //青教评优案例流水号
objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseID = objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseID].ToString().Trim(); //青教评优案例ID
objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseName = objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseName].ToString().Trim(); //青教评优案例名称
objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseText = objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseText] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseText].ToString().Trim(); //案例文本内容
objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseDate = objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseDate].ToString().Trim(); //青教评优教学日期
objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseTime = objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTime] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTime].ToString().Trim(); //青教评优教学时间
objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseTheme = objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTheme] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTheme].ToString().Trim(); //青教评优案例主题词
objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseDateIn = objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseDateIn] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseDateIn].ToString().Trim(); //案例入库日期
objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseTimeIn = objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTimeIn] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTimeIn].ToString().Trim(); //案例入库时间
objvYoungTAppraisedCase_SimEN.IdStudyLevel = objRow[convYoungTAppraisedCase_Sim.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvYoungTAppraisedCase_SimEN.StudyLevelName = objRow[convYoungTAppraisedCase_Sim.StudyLevelName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.StudyLevelName].ToString().Trim(); //学段名称
objvYoungTAppraisedCase_SimEN.IdTeachingPlan = objRow[convYoungTAppraisedCase_Sim.IdTeachingPlan] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.IdTeachingPlan].ToString().Trim(); //教案流水号
objvYoungTAppraisedCase_SimEN.IdCaseType = objRow[convYoungTAppraisedCase_Sim.IdCaseType] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.IdCaseType].ToString().Trim(); //案例类型流水号
objvYoungTAppraisedCase_SimEN.IdDiscipline = objRow[convYoungTAppraisedCase_Sim.IdDiscipline].ToString().Trim(); //学科流水号
objvYoungTAppraisedCase_SimEN.DisciplineID = objRow[convYoungTAppraisedCase_Sim.DisciplineID] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.DisciplineID].ToString().Trim(); //学科ID
objvYoungTAppraisedCase_SimEN.DisciplineName = objRow[convYoungTAppraisedCase_Sim.DisciplineName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.DisciplineName].ToString().Trim(); //学科名称
objvYoungTAppraisedCase_SimEN.BrowseCount = objRow[convYoungTAppraisedCase_Sim.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convYoungTAppraisedCase_Sim.BrowseCount].ToString().Trim()); //浏览次数
objvYoungTAppraisedCase_SimEN.IdSenateGaugeVersion = objRow[convYoungTAppraisedCase_Sim.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvYoungTAppraisedCase_SimEN.senateGaugeVersionID = objRow[convYoungTAppraisedCase_Sim.senateGaugeVersionID] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvYoungTAppraisedCase_SimEN.senateGaugeVersionName = objRow[convYoungTAppraisedCase_Sim.senateGaugeVersionName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvYoungTAppraisedCase_SimEN.senateGaugeVersionTtlScore = objRow[convYoungTAppraisedCase_Sim.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convYoungTAppraisedCase_Sim.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvYoungTAppraisedCase_SimEN.VersionNo = objRow[convYoungTAppraisedCase_Sim.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convYoungTAppraisedCase_Sim.VersionNo].ToString().Trim()); //版本号
objvYoungTAppraisedCase_SimEN.IdTeachSkill = objRow[convYoungTAppraisedCase_Sim.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvYoungTAppraisedCase_SimEN.TeachSkillID = objRow[convYoungTAppraisedCase_Sim.TeachSkillID] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.TeachSkillID].ToString().Trim(); //教学技能ID
objvYoungTAppraisedCase_SimEN.SkillTypeName = objRow[convYoungTAppraisedCase_Sim.SkillTypeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.SkillTypeName].ToString().Trim(); //技能类型名称
objvYoungTAppraisedCase_SimEN.TeachSkillName = objRow[convYoungTAppraisedCase_Sim.TeachSkillName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.TeachSkillName].ToString().Trim(); //教学技能名称
objvYoungTAppraisedCase_SimEN.TeachSkillTheory = objRow[convYoungTAppraisedCase_Sim.TeachSkillTheory] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvYoungTAppraisedCase_SimEN.TeachSkillOperMethod = objRow[convYoungTAppraisedCase_Sim.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvYoungTAppraisedCase_SimEN.IdSkillType = objRow[convYoungTAppraisedCase_Sim.IdSkillType] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.IdSkillType].ToString().Trim(); //技能类型流水号
objvYoungTAppraisedCase_SimEN.SkillTypeID = objRow[convYoungTAppraisedCase_Sim.SkillTypeID] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.SkillTypeID].ToString().Trim(); //技能类型ID
objvYoungTAppraisedCase_SimEN.CaseLevelId = objRow[convYoungTAppraisedCase_Sim.CaseLevelId] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.CaseLevelId].ToString().Trim(); //课例等级Id
objvYoungTAppraisedCase_SimEN.DocFile = objRow[convYoungTAppraisedCase_Sim.DocFile] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.DocFile].ToString().Trim(); //生成的Word文件名
objvYoungTAppraisedCase_SimEN.IsNeedGeneWord = TransNullToBool(objRow[convYoungTAppraisedCase_Sim.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvYoungTAppraisedCase_SimEN.WordCreateDate = objRow[convYoungTAppraisedCase_Sim.WordCreateDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.WordCreateDate].ToString().Trim(); //Word生成日期
objvYoungTAppraisedCase_SimEN.IsVisible = TransNullToBool(objRow[convYoungTAppraisedCase_Sim.IsVisible].ToString().Trim()); //是否显示
objvYoungTAppraisedCase_SimEN.OwnerId = objRow[convYoungTAppraisedCase_Sim.OwnerId].ToString().Trim(); //拥有者Id
objvYoungTAppraisedCase_SimEN.TeacherID = objRow[convYoungTAppraisedCase_Sim.TeacherID] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.TeacherID].ToString().Trim(); //教师工号
objvYoungTAppraisedCase_SimEN.TeacherName = objRow[convYoungTAppraisedCase_Sim.TeacherName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.TeacherName].ToString().Trim(); //教师姓名
objvYoungTAppraisedCase_SimEN.IdXzCollege = objRow[convYoungTAppraisedCase_Sim.IdXzCollege] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.IdXzCollege].ToString().Trim(); //学院流水号
objvYoungTAppraisedCase_SimEN.CollegeName = objRow[convYoungTAppraisedCase_Sim.CollegeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.CollegeName].ToString().Trim(); //学院名称
objvYoungTAppraisedCase_SimEN.EntryDate = objRow[convYoungTAppraisedCase_Sim.EntryDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.EntryDate].ToString().Trim(); //进校日期
objvYoungTAppraisedCase_SimEN.CollegeID = objRow[convYoungTAppraisedCase_Sim.CollegeID] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.CollegeID].ToString().Trim(); //学院ID
objvYoungTAppraisedCase_SimEN.EntryYear = objRow[convYoungTAppraisedCase_Sim.EntryYear] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.EntryYear].ToString().Trim(); //EntryYear
objvYoungTAppraisedCase_SimEN.CollegeNameA = objRow[convYoungTAppraisedCase_Sim.CollegeNameA] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.CollegeNameA].ToString().Trim(); //学院名称简写
objvYoungTAppraisedCase_SimEN.IsDualVideo = TransNullToBool(objRow[convYoungTAppraisedCase_Sim.IsDualVideo].ToString().Trim()); //是否双视频
objvYoungTAppraisedCase_SimEN.IdYoungTAppraisedCaseType = objRow[convYoungTAppraisedCase_Sim.IdYoungTAppraisedCaseType] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.IdYoungTAppraisedCaseType].ToString().Trim(); //青教案例类型流水号
objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseTypeName = objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTypeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTypeName].ToString().Trim(); //青教案例类型名称
objvYoungTAppraisedCase_SimEN.UserTypeId = objRow[convYoungTAppraisedCase_Sim.UserTypeId] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.UserTypeId].ToString().Trim(); //用户类型Id
objvYoungTAppraisedCase_SimEN.UserTypeName = objRow[convYoungTAppraisedCase_Sim.UserTypeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.UserTypeName].ToString().Trim(); //用户类型名称
objvYoungTAppraisedCase_SimEN.RecommendedDegreeId = objRow[convYoungTAppraisedCase_Sim.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvYoungTAppraisedCase_SimEN.RecommendedDegreeName = objRow[convYoungTAppraisedCase_Sim.RecommendedDegreeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvYoungTAppraisedCase_SimEN.Memo = objRow[convYoungTAppraisedCase_Sim.Memo] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.Memo].ToString().Trim(); //备注
objvYoungTAppraisedCase_SimEN.IsUse = TransNullToBool(objRow[convYoungTAppraisedCase_Sim.IsUse].ToString().Trim()); //是否使用
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvYoungTAppraisedCase_SimDA: GetObjLst)", objException.Message));
}
objvYoungTAppraisedCase_SimEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvYoungTAppraisedCase_SimEN);
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
public List<clsvYoungTAppraisedCase_SimEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvYoungTAppraisedCase_SimDA:GetObjLstByTabName)", objException.Message));
}
List<clsvYoungTAppraisedCase_SimEN> arrObjLst = new List<clsvYoungTAppraisedCase_SimEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCase_SimDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvYoungTAppraisedCase_SimEN objvYoungTAppraisedCase_SimEN = new clsvYoungTAppraisedCase_SimEN();
try
{
objvYoungTAppraisedCase_SimEN.IdYoungTAppraisedCase = objRow[convYoungTAppraisedCase_Sim.IdYoungTAppraisedCase].ToString().Trim(); //青教评优案例流水号
objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseID = objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseID].ToString().Trim(); //青教评优案例ID
objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseName = objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseName].ToString().Trim(); //青教评优案例名称
objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseText = objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseText] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseText].ToString().Trim(); //案例文本内容
objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseDate = objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseDate].ToString().Trim(); //青教评优教学日期
objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseTime = objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTime] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTime].ToString().Trim(); //青教评优教学时间
objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseTheme = objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTheme] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTheme].ToString().Trim(); //青教评优案例主题词
objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseDateIn = objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseDateIn] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseDateIn].ToString().Trim(); //案例入库日期
objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseTimeIn = objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTimeIn] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTimeIn].ToString().Trim(); //案例入库时间
objvYoungTAppraisedCase_SimEN.IdStudyLevel = objRow[convYoungTAppraisedCase_Sim.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvYoungTAppraisedCase_SimEN.StudyLevelName = objRow[convYoungTAppraisedCase_Sim.StudyLevelName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.StudyLevelName].ToString().Trim(); //学段名称
objvYoungTAppraisedCase_SimEN.IdTeachingPlan = objRow[convYoungTAppraisedCase_Sim.IdTeachingPlan] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.IdTeachingPlan].ToString().Trim(); //教案流水号
objvYoungTAppraisedCase_SimEN.IdCaseType = objRow[convYoungTAppraisedCase_Sim.IdCaseType] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.IdCaseType].ToString().Trim(); //案例类型流水号
objvYoungTAppraisedCase_SimEN.IdDiscipline = objRow[convYoungTAppraisedCase_Sim.IdDiscipline].ToString().Trim(); //学科流水号
objvYoungTAppraisedCase_SimEN.DisciplineID = objRow[convYoungTAppraisedCase_Sim.DisciplineID] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.DisciplineID].ToString().Trim(); //学科ID
objvYoungTAppraisedCase_SimEN.DisciplineName = objRow[convYoungTAppraisedCase_Sim.DisciplineName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.DisciplineName].ToString().Trim(); //学科名称
objvYoungTAppraisedCase_SimEN.BrowseCount = objRow[convYoungTAppraisedCase_Sim.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convYoungTAppraisedCase_Sim.BrowseCount].ToString().Trim()); //浏览次数
objvYoungTAppraisedCase_SimEN.IdSenateGaugeVersion = objRow[convYoungTAppraisedCase_Sim.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvYoungTAppraisedCase_SimEN.senateGaugeVersionID = objRow[convYoungTAppraisedCase_Sim.senateGaugeVersionID] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvYoungTAppraisedCase_SimEN.senateGaugeVersionName = objRow[convYoungTAppraisedCase_Sim.senateGaugeVersionName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvYoungTAppraisedCase_SimEN.senateGaugeVersionTtlScore = objRow[convYoungTAppraisedCase_Sim.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convYoungTAppraisedCase_Sim.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvYoungTAppraisedCase_SimEN.VersionNo = objRow[convYoungTAppraisedCase_Sim.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convYoungTAppraisedCase_Sim.VersionNo].ToString().Trim()); //版本号
objvYoungTAppraisedCase_SimEN.IdTeachSkill = objRow[convYoungTAppraisedCase_Sim.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvYoungTAppraisedCase_SimEN.TeachSkillID = objRow[convYoungTAppraisedCase_Sim.TeachSkillID] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.TeachSkillID].ToString().Trim(); //教学技能ID
objvYoungTAppraisedCase_SimEN.SkillTypeName = objRow[convYoungTAppraisedCase_Sim.SkillTypeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.SkillTypeName].ToString().Trim(); //技能类型名称
objvYoungTAppraisedCase_SimEN.TeachSkillName = objRow[convYoungTAppraisedCase_Sim.TeachSkillName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.TeachSkillName].ToString().Trim(); //教学技能名称
objvYoungTAppraisedCase_SimEN.TeachSkillTheory = objRow[convYoungTAppraisedCase_Sim.TeachSkillTheory] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvYoungTAppraisedCase_SimEN.TeachSkillOperMethod = objRow[convYoungTAppraisedCase_Sim.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvYoungTAppraisedCase_SimEN.IdSkillType = objRow[convYoungTAppraisedCase_Sim.IdSkillType] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.IdSkillType].ToString().Trim(); //技能类型流水号
objvYoungTAppraisedCase_SimEN.SkillTypeID = objRow[convYoungTAppraisedCase_Sim.SkillTypeID] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.SkillTypeID].ToString().Trim(); //技能类型ID
objvYoungTAppraisedCase_SimEN.CaseLevelId = objRow[convYoungTAppraisedCase_Sim.CaseLevelId] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.CaseLevelId].ToString().Trim(); //课例等级Id
objvYoungTAppraisedCase_SimEN.DocFile = objRow[convYoungTAppraisedCase_Sim.DocFile] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.DocFile].ToString().Trim(); //生成的Word文件名
objvYoungTAppraisedCase_SimEN.IsNeedGeneWord = TransNullToBool(objRow[convYoungTAppraisedCase_Sim.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvYoungTAppraisedCase_SimEN.WordCreateDate = objRow[convYoungTAppraisedCase_Sim.WordCreateDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.WordCreateDate].ToString().Trim(); //Word生成日期
objvYoungTAppraisedCase_SimEN.IsVisible = TransNullToBool(objRow[convYoungTAppraisedCase_Sim.IsVisible].ToString().Trim()); //是否显示
objvYoungTAppraisedCase_SimEN.OwnerId = objRow[convYoungTAppraisedCase_Sim.OwnerId].ToString().Trim(); //拥有者Id
objvYoungTAppraisedCase_SimEN.TeacherID = objRow[convYoungTAppraisedCase_Sim.TeacherID] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.TeacherID].ToString().Trim(); //教师工号
objvYoungTAppraisedCase_SimEN.TeacherName = objRow[convYoungTAppraisedCase_Sim.TeacherName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.TeacherName].ToString().Trim(); //教师姓名
objvYoungTAppraisedCase_SimEN.IdXzCollege = objRow[convYoungTAppraisedCase_Sim.IdXzCollege] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.IdXzCollege].ToString().Trim(); //学院流水号
objvYoungTAppraisedCase_SimEN.CollegeName = objRow[convYoungTAppraisedCase_Sim.CollegeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.CollegeName].ToString().Trim(); //学院名称
objvYoungTAppraisedCase_SimEN.EntryDate = objRow[convYoungTAppraisedCase_Sim.EntryDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.EntryDate].ToString().Trim(); //进校日期
objvYoungTAppraisedCase_SimEN.CollegeID = objRow[convYoungTAppraisedCase_Sim.CollegeID] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.CollegeID].ToString().Trim(); //学院ID
objvYoungTAppraisedCase_SimEN.EntryYear = objRow[convYoungTAppraisedCase_Sim.EntryYear] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.EntryYear].ToString().Trim(); //EntryYear
objvYoungTAppraisedCase_SimEN.CollegeNameA = objRow[convYoungTAppraisedCase_Sim.CollegeNameA] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.CollegeNameA].ToString().Trim(); //学院名称简写
objvYoungTAppraisedCase_SimEN.IsDualVideo = TransNullToBool(objRow[convYoungTAppraisedCase_Sim.IsDualVideo].ToString().Trim()); //是否双视频
objvYoungTAppraisedCase_SimEN.IdYoungTAppraisedCaseType = objRow[convYoungTAppraisedCase_Sim.IdYoungTAppraisedCaseType] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.IdYoungTAppraisedCaseType].ToString().Trim(); //青教案例类型流水号
objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseTypeName = objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTypeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTypeName].ToString().Trim(); //青教案例类型名称
objvYoungTAppraisedCase_SimEN.UserTypeId = objRow[convYoungTAppraisedCase_Sim.UserTypeId] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.UserTypeId].ToString().Trim(); //用户类型Id
objvYoungTAppraisedCase_SimEN.UserTypeName = objRow[convYoungTAppraisedCase_Sim.UserTypeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.UserTypeName].ToString().Trim(); //用户类型名称
objvYoungTAppraisedCase_SimEN.RecommendedDegreeId = objRow[convYoungTAppraisedCase_Sim.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvYoungTAppraisedCase_SimEN.RecommendedDegreeName = objRow[convYoungTAppraisedCase_Sim.RecommendedDegreeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvYoungTAppraisedCase_SimEN.Memo = objRow[convYoungTAppraisedCase_Sim.Memo] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.Memo].ToString().Trim(); //备注
objvYoungTAppraisedCase_SimEN.IsUse = TransNullToBool(objRow[convYoungTAppraisedCase_Sim.IsUse].ToString().Trim()); //是否使用
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvYoungTAppraisedCase_SimDA: GetObjLst)", objException.Message));
}
objvYoungTAppraisedCase_SimEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvYoungTAppraisedCase_SimEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_SimEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvYoungTAppraisedCase_Sim(ref clsvYoungTAppraisedCase_SimEN objvYoungTAppraisedCase_SimEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCase_SimDA.GetSpecSQLObj();
strSQL = "Select * from vYoungTAppraisedCase_Sim where IdYoungTAppraisedCase = " + "'"+ objvYoungTAppraisedCase_SimEN.IdYoungTAppraisedCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvYoungTAppraisedCase_SimEN.IdYoungTAppraisedCase = objDT.Rows[0][convYoungTAppraisedCase_Sim.IdYoungTAppraisedCase].ToString().Trim(); //青教评优案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseID = objDT.Rows[0][convYoungTAppraisedCase_Sim.YoungTAppraisedCaseID].ToString().Trim(); //青教评优案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseName = objDT.Rows[0][convYoungTAppraisedCase_Sim.YoungTAppraisedCaseName].ToString().Trim(); //青教评优案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseText = objDT.Rows[0][convYoungTAppraisedCase_Sim.YoungTAppraisedCaseText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseDate = objDT.Rows[0][convYoungTAppraisedCase_Sim.YoungTAppraisedCaseDate].ToString().Trim(); //青教评优教学日期(字段类型:char,字段长度:8,是否可空:True)
 objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseTime = objDT.Rows[0][convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTime].ToString().Trim(); //青教评优教学时间(字段类型:char,字段长度:6,是否可空:True)
 objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseTheme = objDT.Rows[0][convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTheme].ToString().Trim(); //青教评优案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseDateIn = objDT.Rows[0][convYoungTAppraisedCase_Sim.YoungTAppraisedCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseTimeIn = objDT.Rows[0][convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvYoungTAppraisedCase_SimEN.IdStudyLevel = objDT.Rows[0][convYoungTAppraisedCase_Sim.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvYoungTAppraisedCase_SimEN.StudyLevelName = objDT.Rows[0][convYoungTAppraisedCase_Sim.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvYoungTAppraisedCase_SimEN.IdTeachingPlan = objDT.Rows[0][convYoungTAppraisedCase_Sim.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvYoungTAppraisedCase_SimEN.IdCaseType = objDT.Rows[0][convYoungTAppraisedCase_Sim.IdCaseType].ToString().Trim(); //案例类型流水号(字段类型:char,字段长度:4,是否可空:True)
 objvYoungTAppraisedCase_SimEN.IdDiscipline = objDT.Rows[0][convYoungTAppraisedCase_Sim.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvYoungTAppraisedCase_SimEN.DisciplineID = objDT.Rows[0][convYoungTAppraisedCase_Sim.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvYoungTAppraisedCase_SimEN.DisciplineName = objDT.Rows[0][convYoungTAppraisedCase_Sim.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvYoungTAppraisedCase_SimEN.BrowseCount = TransNullToInt(objDT.Rows[0][convYoungTAppraisedCase_Sim.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvYoungTAppraisedCase_SimEN.IdSenateGaugeVersion = objDT.Rows[0][convYoungTAppraisedCase_Sim.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvYoungTAppraisedCase_SimEN.senateGaugeVersionID = objDT.Rows[0][convYoungTAppraisedCase_Sim.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvYoungTAppraisedCase_SimEN.senateGaugeVersionName = objDT.Rows[0][convYoungTAppraisedCase_Sim.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvYoungTAppraisedCase_SimEN.senateGaugeVersionTtlScore = TransNullToFloat(objDT.Rows[0][convYoungTAppraisedCase_Sim.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvYoungTAppraisedCase_SimEN.VersionNo = TransNullToInt(objDT.Rows[0][convYoungTAppraisedCase_Sim.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvYoungTAppraisedCase_SimEN.IdTeachSkill = objDT.Rows[0][convYoungTAppraisedCase_Sim.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objvYoungTAppraisedCase_SimEN.TeachSkillID = objDT.Rows[0][convYoungTAppraisedCase_Sim.TeachSkillID].ToString().Trim(); //教学技能ID(字段类型:char,字段长度:8,是否可空:False)
 objvYoungTAppraisedCase_SimEN.SkillTypeName = objDT.Rows[0][convYoungTAppraisedCase_Sim.SkillTypeName].ToString().Trim(); //技能类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvYoungTAppraisedCase_SimEN.TeachSkillName = objDT.Rows[0][convYoungTAppraisedCase_Sim.TeachSkillName].ToString().Trim(); //教学技能名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvYoungTAppraisedCase_SimEN.TeachSkillTheory = objDT.Rows[0][convYoungTAppraisedCase_Sim.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvYoungTAppraisedCase_SimEN.TeachSkillOperMethod = objDT.Rows[0][convYoungTAppraisedCase_Sim.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法(字段类型:varchar,字段长度:2000,是否可空:True)
 objvYoungTAppraisedCase_SimEN.IdSkillType = objDT.Rows[0][convYoungTAppraisedCase_Sim.IdSkillType].ToString().Trim(); //技能类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvYoungTAppraisedCase_SimEN.SkillTypeID = objDT.Rows[0][convYoungTAppraisedCase_Sim.SkillTypeID].ToString().Trim(); //技能类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvYoungTAppraisedCase_SimEN.CaseLevelId = objDT.Rows[0][convYoungTAppraisedCase_Sim.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvYoungTAppraisedCase_SimEN.DocFile = objDT.Rows[0][convYoungTAppraisedCase_Sim.DocFile].ToString().Trim(); //生成的Word文件名(字段类型:varchar,字段长度:200,是否可空:True)
 objvYoungTAppraisedCase_SimEN.IsNeedGeneWord = TransNullToBool(objDT.Rows[0][convYoungTAppraisedCase_Sim.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word(字段类型:bit,字段长度:1,是否可空:True)
 objvYoungTAppraisedCase_SimEN.WordCreateDate = objDT.Rows[0][convYoungTAppraisedCase_Sim.WordCreateDate].ToString().Trim(); //Word生成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objvYoungTAppraisedCase_SimEN.IsVisible = TransNullToBool(objDT.Rows[0][convYoungTAppraisedCase_Sim.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvYoungTAppraisedCase_SimEN.OwnerId = objDT.Rows[0][convYoungTAppraisedCase_Sim.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvYoungTAppraisedCase_SimEN.TeacherID = objDT.Rows[0][convYoungTAppraisedCase_Sim.TeacherID].ToString().Trim(); //教师工号(字段类型:varchar,字段长度:12,是否可空:False)
 objvYoungTAppraisedCase_SimEN.TeacherName = objDT.Rows[0][convYoungTAppraisedCase_Sim.TeacherName].ToString().Trim(); //教师姓名(字段类型:varchar,字段长度:50,是否可空:False)
 objvYoungTAppraisedCase_SimEN.IdXzCollege = objDT.Rows[0][convYoungTAppraisedCase_Sim.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvYoungTAppraisedCase_SimEN.CollegeName = objDT.Rows[0][convYoungTAppraisedCase_Sim.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvYoungTAppraisedCase_SimEN.EntryDate = objDT.Rows[0][convYoungTAppraisedCase_Sim.EntryDate].ToString().Trim(); //进校日期(字段类型:char,字段长度:8,是否可空:True)
 objvYoungTAppraisedCase_SimEN.CollegeID = objDT.Rows[0][convYoungTAppraisedCase_Sim.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvYoungTAppraisedCase_SimEN.EntryYear = objDT.Rows[0][convYoungTAppraisedCase_Sim.EntryYear].ToString().Trim(); //EntryYear(字段类型:varchar,字段长度:8,是否可空:True)
 objvYoungTAppraisedCase_SimEN.CollegeNameA = objDT.Rows[0][convYoungTAppraisedCase_Sim.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvYoungTAppraisedCase_SimEN.IsDualVideo = TransNullToBool(objDT.Rows[0][convYoungTAppraisedCase_Sim.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvYoungTAppraisedCase_SimEN.IdYoungTAppraisedCaseType = objDT.Rows[0][convYoungTAppraisedCase_Sim.IdYoungTAppraisedCaseType].ToString().Trim(); //青教案例类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseTypeName = objDT.Rows[0][convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTypeName].ToString().Trim(); //青教案例类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvYoungTAppraisedCase_SimEN.UserTypeId = objDT.Rows[0][convYoungTAppraisedCase_Sim.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvYoungTAppraisedCase_SimEN.UserTypeName = objDT.Rows[0][convYoungTAppraisedCase_Sim.UserTypeName].ToString().Trim(); //用户类型名称(字段类型:varchar,字段长度:20,是否可空:True)
 objvYoungTAppraisedCase_SimEN.RecommendedDegreeId = objDT.Rows[0][convYoungTAppraisedCase_Sim.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvYoungTAppraisedCase_SimEN.RecommendedDegreeName = objDT.Rows[0][convYoungTAppraisedCase_Sim.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvYoungTAppraisedCase_SimEN.Memo = objDT.Rows[0][convYoungTAppraisedCase_Sim.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvYoungTAppraisedCase_SimEN.IsUse = TransNullToBool(objDT.Rows[0][convYoungTAppraisedCase_Sim.IsUse].ToString().Trim()); //是否使用(字段类型:bit,字段长度:1,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvYoungTAppraisedCase_SimDA: GetvYoungTAppraisedCase_Sim)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdYoungTAppraisedCase">表关键字</param>
 /// <returns>表对象</returns>
public clsvYoungTAppraisedCase_SimEN GetObjByIdYoungTAppraisedCase(string strIdYoungTAppraisedCase)
{
CheckPrimaryKey(strIdYoungTAppraisedCase);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCase_SimDA.GetSpecSQLObj();
strSQL = "Select * from vYoungTAppraisedCase_Sim where IdYoungTAppraisedCase = " + "'"+ strIdYoungTAppraisedCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvYoungTAppraisedCase_SimEN objvYoungTAppraisedCase_SimEN = new clsvYoungTAppraisedCase_SimEN();
try
{
 objvYoungTAppraisedCase_SimEN.IdYoungTAppraisedCase = objRow[convYoungTAppraisedCase_Sim.IdYoungTAppraisedCase].ToString().Trim(); //青教评优案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseID = objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseID].ToString().Trim(); //青教评优案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseName = objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseName].ToString().Trim(); //青教评优案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseText = objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseText] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseDate = objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseDate].ToString().Trim(); //青教评优教学日期(字段类型:char,字段长度:8,是否可空:True)
 objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseTime = objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTime] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTime].ToString().Trim(); //青教评优教学时间(字段类型:char,字段长度:6,是否可空:True)
 objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseTheme = objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTheme] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTheme].ToString().Trim(); //青教评优案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseDateIn = objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseDateIn] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseTimeIn = objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTimeIn] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvYoungTAppraisedCase_SimEN.IdStudyLevel = objRow[convYoungTAppraisedCase_Sim.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvYoungTAppraisedCase_SimEN.StudyLevelName = objRow[convYoungTAppraisedCase_Sim.StudyLevelName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvYoungTAppraisedCase_SimEN.IdTeachingPlan = objRow[convYoungTAppraisedCase_Sim.IdTeachingPlan] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvYoungTAppraisedCase_SimEN.IdCaseType = objRow[convYoungTAppraisedCase_Sim.IdCaseType] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.IdCaseType].ToString().Trim(); //案例类型流水号(字段类型:char,字段长度:4,是否可空:True)
 objvYoungTAppraisedCase_SimEN.IdDiscipline = objRow[convYoungTAppraisedCase_Sim.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvYoungTAppraisedCase_SimEN.DisciplineID = objRow[convYoungTAppraisedCase_Sim.DisciplineID] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvYoungTAppraisedCase_SimEN.DisciplineName = objRow[convYoungTAppraisedCase_Sim.DisciplineName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvYoungTAppraisedCase_SimEN.BrowseCount = objRow[convYoungTAppraisedCase_Sim.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convYoungTAppraisedCase_Sim.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvYoungTAppraisedCase_SimEN.IdSenateGaugeVersion = objRow[convYoungTAppraisedCase_Sim.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvYoungTAppraisedCase_SimEN.senateGaugeVersionID = objRow[convYoungTAppraisedCase_Sim.senateGaugeVersionID] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvYoungTAppraisedCase_SimEN.senateGaugeVersionName = objRow[convYoungTAppraisedCase_Sim.senateGaugeVersionName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvYoungTAppraisedCase_SimEN.senateGaugeVersionTtlScore = objRow[convYoungTAppraisedCase_Sim.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convYoungTAppraisedCase_Sim.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvYoungTAppraisedCase_SimEN.VersionNo = objRow[convYoungTAppraisedCase_Sim.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convYoungTAppraisedCase_Sim.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvYoungTAppraisedCase_SimEN.IdTeachSkill = objRow[convYoungTAppraisedCase_Sim.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objvYoungTAppraisedCase_SimEN.TeachSkillID = objRow[convYoungTAppraisedCase_Sim.TeachSkillID] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.TeachSkillID].ToString().Trim(); //教学技能ID(字段类型:char,字段长度:8,是否可空:False)
 objvYoungTAppraisedCase_SimEN.SkillTypeName = objRow[convYoungTAppraisedCase_Sim.SkillTypeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.SkillTypeName].ToString().Trim(); //技能类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvYoungTAppraisedCase_SimEN.TeachSkillName = objRow[convYoungTAppraisedCase_Sim.TeachSkillName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.TeachSkillName].ToString().Trim(); //教学技能名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvYoungTAppraisedCase_SimEN.TeachSkillTheory = objRow[convYoungTAppraisedCase_Sim.TeachSkillTheory] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvYoungTAppraisedCase_SimEN.TeachSkillOperMethod = objRow[convYoungTAppraisedCase_Sim.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法(字段类型:varchar,字段长度:2000,是否可空:True)
 objvYoungTAppraisedCase_SimEN.IdSkillType = objRow[convYoungTAppraisedCase_Sim.IdSkillType] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.IdSkillType].ToString().Trim(); //技能类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvYoungTAppraisedCase_SimEN.SkillTypeID = objRow[convYoungTAppraisedCase_Sim.SkillTypeID] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.SkillTypeID].ToString().Trim(); //技能类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvYoungTAppraisedCase_SimEN.CaseLevelId = objRow[convYoungTAppraisedCase_Sim.CaseLevelId] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvYoungTAppraisedCase_SimEN.DocFile = objRow[convYoungTAppraisedCase_Sim.DocFile] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.DocFile].ToString().Trim(); //生成的Word文件名(字段类型:varchar,字段长度:200,是否可空:True)
 objvYoungTAppraisedCase_SimEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convYoungTAppraisedCase_Sim.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word(字段类型:bit,字段长度:1,是否可空:True)
 objvYoungTAppraisedCase_SimEN.WordCreateDate = objRow[convYoungTAppraisedCase_Sim.WordCreateDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.WordCreateDate].ToString().Trim(); //Word生成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objvYoungTAppraisedCase_SimEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convYoungTAppraisedCase_Sim.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvYoungTAppraisedCase_SimEN.OwnerId = objRow[convYoungTAppraisedCase_Sim.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvYoungTAppraisedCase_SimEN.TeacherID = objRow[convYoungTAppraisedCase_Sim.TeacherID] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.TeacherID].ToString().Trim(); //教师工号(字段类型:varchar,字段长度:12,是否可空:False)
 objvYoungTAppraisedCase_SimEN.TeacherName = objRow[convYoungTAppraisedCase_Sim.TeacherName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.TeacherName].ToString().Trim(); //教师姓名(字段类型:varchar,字段长度:50,是否可空:False)
 objvYoungTAppraisedCase_SimEN.IdXzCollege = objRow[convYoungTAppraisedCase_Sim.IdXzCollege] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvYoungTAppraisedCase_SimEN.CollegeName = objRow[convYoungTAppraisedCase_Sim.CollegeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvYoungTAppraisedCase_SimEN.EntryDate = objRow[convYoungTAppraisedCase_Sim.EntryDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.EntryDate].ToString().Trim(); //进校日期(字段类型:char,字段长度:8,是否可空:True)
 objvYoungTAppraisedCase_SimEN.CollegeID = objRow[convYoungTAppraisedCase_Sim.CollegeID] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvYoungTAppraisedCase_SimEN.EntryYear = objRow[convYoungTAppraisedCase_Sim.EntryYear] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.EntryYear].ToString().Trim(); //EntryYear(字段类型:varchar,字段长度:8,是否可空:True)
 objvYoungTAppraisedCase_SimEN.CollegeNameA = objRow[convYoungTAppraisedCase_Sim.CollegeNameA] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvYoungTAppraisedCase_SimEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convYoungTAppraisedCase_Sim.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvYoungTAppraisedCase_SimEN.IdYoungTAppraisedCaseType = objRow[convYoungTAppraisedCase_Sim.IdYoungTAppraisedCaseType] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.IdYoungTAppraisedCaseType].ToString().Trim(); //青教案例类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseTypeName = objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTypeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTypeName].ToString().Trim(); //青教案例类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvYoungTAppraisedCase_SimEN.UserTypeId = objRow[convYoungTAppraisedCase_Sim.UserTypeId] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvYoungTAppraisedCase_SimEN.UserTypeName = objRow[convYoungTAppraisedCase_Sim.UserTypeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.UserTypeName].ToString().Trim(); //用户类型名称(字段类型:varchar,字段长度:20,是否可空:True)
 objvYoungTAppraisedCase_SimEN.RecommendedDegreeId = objRow[convYoungTAppraisedCase_Sim.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvYoungTAppraisedCase_SimEN.RecommendedDegreeName = objRow[convYoungTAppraisedCase_Sim.RecommendedDegreeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvYoungTAppraisedCase_SimEN.Memo = objRow[convYoungTAppraisedCase_Sim.Memo] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvYoungTAppraisedCase_SimEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convYoungTAppraisedCase_Sim.IsUse].ToString().Trim()); //是否使用(字段类型:bit,字段长度:1,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvYoungTAppraisedCase_SimDA: GetObjByIdYoungTAppraisedCase)", objException.Message));
}
return objvYoungTAppraisedCase_SimEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvYoungTAppraisedCase_SimEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvYoungTAppraisedCase_SimDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCase_SimDA.GetSpecSQLObj();
strSQL = "Select * from vYoungTAppraisedCase_Sim where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvYoungTAppraisedCase_SimEN objvYoungTAppraisedCase_SimEN = new clsvYoungTAppraisedCase_SimEN()
{
IdYoungTAppraisedCase = objRow[convYoungTAppraisedCase_Sim.IdYoungTAppraisedCase].ToString().Trim(), //青教评优案例流水号
YoungTAppraisedCaseID = objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseID].ToString().Trim(), //青教评优案例ID
YoungTAppraisedCaseName = objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseName].ToString().Trim(), //青教评优案例名称
YoungTAppraisedCaseText = objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseText] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseText].ToString().Trim(), //案例文本内容
YoungTAppraisedCaseDate = objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseDate].ToString().Trim(), //青教评优教学日期
YoungTAppraisedCaseTime = objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTime] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTime].ToString().Trim(), //青教评优教学时间
YoungTAppraisedCaseTheme = objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTheme] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTheme].ToString().Trim(), //青教评优案例主题词
YoungTAppraisedCaseDateIn = objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseDateIn] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseDateIn].ToString().Trim(), //案例入库日期
YoungTAppraisedCaseTimeIn = objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTimeIn] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTimeIn].ToString().Trim(), //案例入库时间
IdStudyLevel = objRow[convYoungTAppraisedCase_Sim.IdStudyLevel].ToString().Trim(), //id_StudyLevel
StudyLevelName = objRow[convYoungTAppraisedCase_Sim.StudyLevelName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.StudyLevelName].ToString().Trim(), //学段名称
IdTeachingPlan = objRow[convYoungTAppraisedCase_Sim.IdTeachingPlan] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.IdTeachingPlan].ToString().Trim(), //教案流水号
IdCaseType = objRow[convYoungTAppraisedCase_Sim.IdCaseType] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.IdCaseType].ToString().Trim(), //案例类型流水号
IdDiscipline = objRow[convYoungTAppraisedCase_Sim.IdDiscipline].ToString().Trim(), //学科流水号
DisciplineID = objRow[convYoungTAppraisedCase_Sim.DisciplineID] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.DisciplineID].ToString().Trim(), //学科ID
DisciplineName = objRow[convYoungTAppraisedCase_Sim.DisciplineName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.DisciplineName].ToString().Trim(), //学科名称
BrowseCount = objRow[convYoungTAppraisedCase_Sim.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convYoungTAppraisedCase_Sim.BrowseCount].ToString().Trim()), //浏览次数
IdSenateGaugeVersion = objRow[convYoungTAppraisedCase_Sim.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.IdSenateGaugeVersion].ToString().Trim(), //评价量表版本流水号
senateGaugeVersionID = objRow[convYoungTAppraisedCase_Sim.senateGaugeVersionID] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.senateGaugeVersionID].ToString().Trim(), //评价量表版本ID
senateGaugeVersionName = objRow[convYoungTAppraisedCase_Sim.senateGaugeVersionName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.senateGaugeVersionName].ToString().Trim(), //评价量表版本名称
senateGaugeVersionTtlScore = objRow[convYoungTAppraisedCase_Sim.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convYoungTAppraisedCase_Sim.senateGaugeVersionTtlScore].ToString().Trim()), //评价量表版本总分
VersionNo = objRow[convYoungTAppraisedCase_Sim.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convYoungTAppraisedCase_Sim.VersionNo].ToString().Trim()), //版本号
IdTeachSkill = objRow[convYoungTAppraisedCase_Sim.IdTeachSkill].ToString().Trim(), //教学技能流水号
TeachSkillID = objRow[convYoungTAppraisedCase_Sim.TeachSkillID] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.TeachSkillID].ToString().Trim(), //教学技能ID
SkillTypeName = objRow[convYoungTAppraisedCase_Sim.SkillTypeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.SkillTypeName].ToString().Trim(), //技能类型名称
TeachSkillName = objRow[convYoungTAppraisedCase_Sim.TeachSkillName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.TeachSkillName].ToString().Trim(), //教学技能名称
TeachSkillTheory = objRow[convYoungTAppraisedCase_Sim.TeachSkillTheory] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.TeachSkillTheory].ToString().Trim(), //教学技能理论阐述
TeachSkillOperMethod = objRow[convYoungTAppraisedCase_Sim.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.TeachSkillOperMethod].ToString().Trim(), //教学技能实践操作方法
IdSkillType = objRow[convYoungTAppraisedCase_Sim.IdSkillType] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.IdSkillType].ToString().Trim(), //技能类型流水号
SkillTypeID = objRow[convYoungTAppraisedCase_Sim.SkillTypeID] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.SkillTypeID].ToString().Trim(), //技能类型ID
CaseLevelId = objRow[convYoungTAppraisedCase_Sim.CaseLevelId] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.CaseLevelId].ToString().Trim(), //课例等级Id
DocFile = objRow[convYoungTAppraisedCase_Sim.DocFile] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.DocFile].ToString().Trim(), //生成的Word文件名
IsNeedGeneWord = TransNullToBool(objRow[convYoungTAppraisedCase_Sim.IsNeedGeneWord].ToString().Trim()), //是否需要生成Word
WordCreateDate = objRow[convYoungTAppraisedCase_Sim.WordCreateDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.WordCreateDate].ToString().Trim(), //Word生成日期
IsVisible = TransNullToBool(objRow[convYoungTAppraisedCase_Sim.IsVisible].ToString().Trim()), //是否显示
OwnerId = objRow[convYoungTAppraisedCase_Sim.OwnerId].ToString().Trim(), //拥有者Id
TeacherID = objRow[convYoungTAppraisedCase_Sim.TeacherID] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.TeacherID].ToString().Trim(), //教师工号
TeacherName = objRow[convYoungTAppraisedCase_Sim.TeacherName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.TeacherName].ToString().Trim(), //教师姓名
IdXzCollege = objRow[convYoungTAppraisedCase_Sim.IdXzCollege] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.IdXzCollege].ToString().Trim(), //学院流水号
CollegeName = objRow[convYoungTAppraisedCase_Sim.CollegeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.CollegeName].ToString().Trim(), //学院名称
EntryDate = objRow[convYoungTAppraisedCase_Sim.EntryDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.EntryDate].ToString().Trim(), //进校日期
CollegeID = objRow[convYoungTAppraisedCase_Sim.CollegeID] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.CollegeID].ToString().Trim(), //学院ID
EntryYear = objRow[convYoungTAppraisedCase_Sim.EntryYear] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.EntryYear].ToString().Trim(), //EntryYear
CollegeNameA = objRow[convYoungTAppraisedCase_Sim.CollegeNameA] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.CollegeNameA].ToString().Trim(), //学院名称简写
IsDualVideo = TransNullToBool(objRow[convYoungTAppraisedCase_Sim.IsDualVideo].ToString().Trim()), //是否双视频
IdYoungTAppraisedCaseType = objRow[convYoungTAppraisedCase_Sim.IdYoungTAppraisedCaseType] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.IdYoungTAppraisedCaseType].ToString().Trim(), //青教案例类型流水号
YoungTAppraisedCaseTypeName = objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTypeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTypeName].ToString().Trim(), //青教案例类型名称
UserTypeId = objRow[convYoungTAppraisedCase_Sim.UserTypeId] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.UserTypeId].ToString().Trim(), //用户类型Id
UserTypeName = objRow[convYoungTAppraisedCase_Sim.UserTypeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.UserTypeName].ToString().Trim(), //用户类型名称
RecommendedDegreeId = objRow[convYoungTAppraisedCase_Sim.RecommendedDegreeId].ToString().Trim(), //推荐度Id
RecommendedDegreeName = objRow[convYoungTAppraisedCase_Sim.RecommendedDegreeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.RecommendedDegreeName].ToString().Trim(), //推荐度名称
Memo = objRow[convYoungTAppraisedCase_Sim.Memo] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.Memo].ToString().Trim(), //备注
IsUse = TransNullToBool(objRow[convYoungTAppraisedCase_Sim.IsUse].ToString().Trim()) //是否使用
};
objvYoungTAppraisedCase_SimEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvYoungTAppraisedCase_SimEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvYoungTAppraisedCase_SimDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvYoungTAppraisedCase_SimEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvYoungTAppraisedCase_SimEN objvYoungTAppraisedCase_SimEN = new clsvYoungTAppraisedCase_SimEN();
try
{
objvYoungTAppraisedCase_SimEN.IdYoungTAppraisedCase = objRow[convYoungTAppraisedCase_Sim.IdYoungTAppraisedCase].ToString().Trim(); //青教评优案例流水号
objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseID = objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseID].ToString().Trim(); //青教评优案例ID
objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseName = objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseName].ToString().Trim(); //青教评优案例名称
objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseText = objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseText] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseText].ToString().Trim(); //案例文本内容
objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseDate = objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseDate].ToString().Trim(); //青教评优教学日期
objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseTime = objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTime] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTime].ToString().Trim(); //青教评优教学时间
objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseTheme = objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTheme] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTheme].ToString().Trim(); //青教评优案例主题词
objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseDateIn = objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseDateIn] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseDateIn].ToString().Trim(); //案例入库日期
objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseTimeIn = objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTimeIn] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTimeIn].ToString().Trim(); //案例入库时间
objvYoungTAppraisedCase_SimEN.IdStudyLevel = objRow[convYoungTAppraisedCase_Sim.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvYoungTAppraisedCase_SimEN.StudyLevelName = objRow[convYoungTAppraisedCase_Sim.StudyLevelName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.StudyLevelName].ToString().Trim(); //学段名称
objvYoungTAppraisedCase_SimEN.IdTeachingPlan = objRow[convYoungTAppraisedCase_Sim.IdTeachingPlan] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.IdTeachingPlan].ToString().Trim(); //教案流水号
objvYoungTAppraisedCase_SimEN.IdCaseType = objRow[convYoungTAppraisedCase_Sim.IdCaseType] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.IdCaseType].ToString().Trim(); //案例类型流水号
objvYoungTAppraisedCase_SimEN.IdDiscipline = objRow[convYoungTAppraisedCase_Sim.IdDiscipline].ToString().Trim(); //学科流水号
objvYoungTAppraisedCase_SimEN.DisciplineID = objRow[convYoungTAppraisedCase_Sim.DisciplineID] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.DisciplineID].ToString().Trim(); //学科ID
objvYoungTAppraisedCase_SimEN.DisciplineName = objRow[convYoungTAppraisedCase_Sim.DisciplineName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.DisciplineName].ToString().Trim(); //学科名称
objvYoungTAppraisedCase_SimEN.BrowseCount = objRow[convYoungTAppraisedCase_Sim.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convYoungTAppraisedCase_Sim.BrowseCount].ToString().Trim()); //浏览次数
objvYoungTAppraisedCase_SimEN.IdSenateGaugeVersion = objRow[convYoungTAppraisedCase_Sim.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvYoungTAppraisedCase_SimEN.senateGaugeVersionID = objRow[convYoungTAppraisedCase_Sim.senateGaugeVersionID] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvYoungTAppraisedCase_SimEN.senateGaugeVersionName = objRow[convYoungTAppraisedCase_Sim.senateGaugeVersionName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvYoungTAppraisedCase_SimEN.senateGaugeVersionTtlScore = objRow[convYoungTAppraisedCase_Sim.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convYoungTAppraisedCase_Sim.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvYoungTAppraisedCase_SimEN.VersionNo = objRow[convYoungTAppraisedCase_Sim.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convYoungTAppraisedCase_Sim.VersionNo].ToString().Trim()); //版本号
objvYoungTAppraisedCase_SimEN.IdTeachSkill = objRow[convYoungTAppraisedCase_Sim.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvYoungTAppraisedCase_SimEN.TeachSkillID = objRow[convYoungTAppraisedCase_Sim.TeachSkillID] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.TeachSkillID].ToString().Trim(); //教学技能ID
objvYoungTAppraisedCase_SimEN.SkillTypeName = objRow[convYoungTAppraisedCase_Sim.SkillTypeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.SkillTypeName].ToString().Trim(); //技能类型名称
objvYoungTAppraisedCase_SimEN.TeachSkillName = objRow[convYoungTAppraisedCase_Sim.TeachSkillName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.TeachSkillName].ToString().Trim(); //教学技能名称
objvYoungTAppraisedCase_SimEN.TeachSkillTheory = objRow[convYoungTAppraisedCase_Sim.TeachSkillTheory] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvYoungTAppraisedCase_SimEN.TeachSkillOperMethod = objRow[convYoungTAppraisedCase_Sim.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvYoungTAppraisedCase_SimEN.IdSkillType = objRow[convYoungTAppraisedCase_Sim.IdSkillType] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.IdSkillType].ToString().Trim(); //技能类型流水号
objvYoungTAppraisedCase_SimEN.SkillTypeID = objRow[convYoungTAppraisedCase_Sim.SkillTypeID] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.SkillTypeID].ToString().Trim(); //技能类型ID
objvYoungTAppraisedCase_SimEN.CaseLevelId = objRow[convYoungTAppraisedCase_Sim.CaseLevelId] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.CaseLevelId].ToString().Trim(); //课例等级Id
objvYoungTAppraisedCase_SimEN.DocFile = objRow[convYoungTAppraisedCase_Sim.DocFile] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.DocFile].ToString().Trim(); //生成的Word文件名
objvYoungTAppraisedCase_SimEN.IsNeedGeneWord = TransNullToBool(objRow[convYoungTAppraisedCase_Sim.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvYoungTAppraisedCase_SimEN.WordCreateDate = objRow[convYoungTAppraisedCase_Sim.WordCreateDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.WordCreateDate].ToString().Trim(); //Word生成日期
objvYoungTAppraisedCase_SimEN.IsVisible = TransNullToBool(objRow[convYoungTAppraisedCase_Sim.IsVisible].ToString().Trim()); //是否显示
objvYoungTAppraisedCase_SimEN.OwnerId = objRow[convYoungTAppraisedCase_Sim.OwnerId].ToString().Trim(); //拥有者Id
objvYoungTAppraisedCase_SimEN.TeacherID = objRow[convYoungTAppraisedCase_Sim.TeacherID] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.TeacherID].ToString().Trim(); //教师工号
objvYoungTAppraisedCase_SimEN.TeacherName = objRow[convYoungTAppraisedCase_Sim.TeacherName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.TeacherName].ToString().Trim(); //教师姓名
objvYoungTAppraisedCase_SimEN.IdXzCollege = objRow[convYoungTAppraisedCase_Sim.IdXzCollege] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.IdXzCollege].ToString().Trim(); //学院流水号
objvYoungTAppraisedCase_SimEN.CollegeName = objRow[convYoungTAppraisedCase_Sim.CollegeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.CollegeName].ToString().Trim(); //学院名称
objvYoungTAppraisedCase_SimEN.EntryDate = objRow[convYoungTAppraisedCase_Sim.EntryDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.EntryDate].ToString().Trim(); //进校日期
objvYoungTAppraisedCase_SimEN.CollegeID = objRow[convYoungTAppraisedCase_Sim.CollegeID] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.CollegeID].ToString().Trim(); //学院ID
objvYoungTAppraisedCase_SimEN.EntryYear = objRow[convYoungTAppraisedCase_Sim.EntryYear] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.EntryYear].ToString().Trim(); //EntryYear
objvYoungTAppraisedCase_SimEN.CollegeNameA = objRow[convYoungTAppraisedCase_Sim.CollegeNameA] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.CollegeNameA].ToString().Trim(); //学院名称简写
objvYoungTAppraisedCase_SimEN.IsDualVideo = TransNullToBool(objRow[convYoungTAppraisedCase_Sim.IsDualVideo].ToString().Trim()); //是否双视频
objvYoungTAppraisedCase_SimEN.IdYoungTAppraisedCaseType = objRow[convYoungTAppraisedCase_Sim.IdYoungTAppraisedCaseType] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.IdYoungTAppraisedCaseType].ToString().Trim(); //青教案例类型流水号
objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseTypeName = objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTypeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTypeName].ToString().Trim(); //青教案例类型名称
objvYoungTAppraisedCase_SimEN.UserTypeId = objRow[convYoungTAppraisedCase_Sim.UserTypeId] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.UserTypeId].ToString().Trim(); //用户类型Id
objvYoungTAppraisedCase_SimEN.UserTypeName = objRow[convYoungTAppraisedCase_Sim.UserTypeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.UserTypeName].ToString().Trim(); //用户类型名称
objvYoungTAppraisedCase_SimEN.RecommendedDegreeId = objRow[convYoungTAppraisedCase_Sim.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvYoungTAppraisedCase_SimEN.RecommendedDegreeName = objRow[convYoungTAppraisedCase_Sim.RecommendedDegreeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvYoungTAppraisedCase_SimEN.Memo = objRow[convYoungTAppraisedCase_Sim.Memo] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.Memo].ToString().Trim(); //备注
objvYoungTAppraisedCase_SimEN.IsUse = TransNullToBool(objRow[convYoungTAppraisedCase_Sim.IsUse].ToString().Trim()); //是否使用
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvYoungTAppraisedCase_SimDA: GetObjByDataRowvYoungTAppraisedCase_Sim)", objException.Message));
}
objvYoungTAppraisedCase_SimEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvYoungTAppraisedCase_SimEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvYoungTAppraisedCase_SimEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvYoungTAppraisedCase_SimEN objvYoungTAppraisedCase_SimEN = new clsvYoungTAppraisedCase_SimEN();
try
{
objvYoungTAppraisedCase_SimEN.IdYoungTAppraisedCase = objRow[convYoungTAppraisedCase_Sim.IdYoungTAppraisedCase].ToString().Trim(); //青教评优案例流水号
objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseID = objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseID].ToString().Trim(); //青教评优案例ID
objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseName = objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseName].ToString().Trim(); //青教评优案例名称
objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseText = objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseText] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseText].ToString().Trim(); //案例文本内容
objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseDate = objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseDate].ToString().Trim(); //青教评优教学日期
objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseTime = objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTime] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTime].ToString().Trim(); //青教评优教学时间
objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseTheme = objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTheme] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTheme].ToString().Trim(); //青教评优案例主题词
objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseDateIn = objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseDateIn] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseDateIn].ToString().Trim(); //案例入库日期
objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseTimeIn = objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTimeIn] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTimeIn].ToString().Trim(); //案例入库时间
objvYoungTAppraisedCase_SimEN.IdStudyLevel = objRow[convYoungTAppraisedCase_Sim.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvYoungTAppraisedCase_SimEN.StudyLevelName = objRow[convYoungTAppraisedCase_Sim.StudyLevelName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.StudyLevelName].ToString().Trim(); //学段名称
objvYoungTAppraisedCase_SimEN.IdTeachingPlan = objRow[convYoungTAppraisedCase_Sim.IdTeachingPlan] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.IdTeachingPlan].ToString().Trim(); //教案流水号
objvYoungTAppraisedCase_SimEN.IdCaseType = objRow[convYoungTAppraisedCase_Sim.IdCaseType] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.IdCaseType].ToString().Trim(); //案例类型流水号
objvYoungTAppraisedCase_SimEN.IdDiscipline = objRow[convYoungTAppraisedCase_Sim.IdDiscipline].ToString().Trim(); //学科流水号
objvYoungTAppraisedCase_SimEN.DisciplineID = objRow[convYoungTAppraisedCase_Sim.DisciplineID] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.DisciplineID].ToString().Trim(); //学科ID
objvYoungTAppraisedCase_SimEN.DisciplineName = objRow[convYoungTAppraisedCase_Sim.DisciplineName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.DisciplineName].ToString().Trim(); //学科名称
objvYoungTAppraisedCase_SimEN.BrowseCount = objRow[convYoungTAppraisedCase_Sim.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convYoungTAppraisedCase_Sim.BrowseCount].ToString().Trim()); //浏览次数
objvYoungTAppraisedCase_SimEN.IdSenateGaugeVersion = objRow[convYoungTAppraisedCase_Sim.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvYoungTAppraisedCase_SimEN.senateGaugeVersionID = objRow[convYoungTAppraisedCase_Sim.senateGaugeVersionID] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvYoungTAppraisedCase_SimEN.senateGaugeVersionName = objRow[convYoungTAppraisedCase_Sim.senateGaugeVersionName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvYoungTAppraisedCase_SimEN.senateGaugeVersionTtlScore = objRow[convYoungTAppraisedCase_Sim.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convYoungTAppraisedCase_Sim.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvYoungTAppraisedCase_SimEN.VersionNo = objRow[convYoungTAppraisedCase_Sim.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convYoungTAppraisedCase_Sim.VersionNo].ToString().Trim()); //版本号
objvYoungTAppraisedCase_SimEN.IdTeachSkill = objRow[convYoungTAppraisedCase_Sim.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvYoungTAppraisedCase_SimEN.TeachSkillID = objRow[convYoungTAppraisedCase_Sim.TeachSkillID] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.TeachSkillID].ToString().Trim(); //教学技能ID
objvYoungTAppraisedCase_SimEN.SkillTypeName = objRow[convYoungTAppraisedCase_Sim.SkillTypeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.SkillTypeName].ToString().Trim(); //技能类型名称
objvYoungTAppraisedCase_SimEN.TeachSkillName = objRow[convYoungTAppraisedCase_Sim.TeachSkillName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.TeachSkillName].ToString().Trim(); //教学技能名称
objvYoungTAppraisedCase_SimEN.TeachSkillTheory = objRow[convYoungTAppraisedCase_Sim.TeachSkillTheory] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvYoungTAppraisedCase_SimEN.TeachSkillOperMethod = objRow[convYoungTAppraisedCase_Sim.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvYoungTAppraisedCase_SimEN.IdSkillType = objRow[convYoungTAppraisedCase_Sim.IdSkillType] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.IdSkillType].ToString().Trim(); //技能类型流水号
objvYoungTAppraisedCase_SimEN.SkillTypeID = objRow[convYoungTAppraisedCase_Sim.SkillTypeID] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.SkillTypeID].ToString().Trim(); //技能类型ID
objvYoungTAppraisedCase_SimEN.CaseLevelId = objRow[convYoungTAppraisedCase_Sim.CaseLevelId] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.CaseLevelId].ToString().Trim(); //课例等级Id
objvYoungTAppraisedCase_SimEN.DocFile = objRow[convYoungTAppraisedCase_Sim.DocFile] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.DocFile].ToString().Trim(); //生成的Word文件名
objvYoungTAppraisedCase_SimEN.IsNeedGeneWord = TransNullToBool(objRow[convYoungTAppraisedCase_Sim.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvYoungTAppraisedCase_SimEN.WordCreateDate = objRow[convYoungTAppraisedCase_Sim.WordCreateDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.WordCreateDate].ToString().Trim(); //Word生成日期
objvYoungTAppraisedCase_SimEN.IsVisible = TransNullToBool(objRow[convYoungTAppraisedCase_Sim.IsVisible].ToString().Trim()); //是否显示
objvYoungTAppraisedCase_SimEN.OwnerId = objRow[convYoungTAppraisedCase_Sim.OwnerId].ToString().Trim(); //拥有者Id
objvYoungTAppraisedCase_SimEN.TeacherID = objRow[convYoungTAppraisedCase_Sim.TeacherID] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.TeacherID].ToString().Trim(); //教师工号
objvYoungTAppraisedCase_SimEN.TeacherName = objRow[convYoungTAppraisedCase_Sim.TeacherName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.TeacherName].ToString().Trim(); //教师姓名
objvYoungTAppraisedCase_SimEN.IdXzCollege = objRow[convYoungTAppraisedCase_Sim.IdXzCollege] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.IdXzCollege].ToString().Trim(); //学院流水号
objvYoungTAppraisedCase_SimEN.CollegeName = objRow[convYoungTAppraisedCase_Sim.CollegeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.CollegeName].ToString().Trim(); //学院名称
objvYoungTAppraisedCase_SimEN.EntryDate = objRow[convYoungTAppraisedCase_Sim.EntryDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.EntryDate].ToString().Trim(); //进校日期
objvYoungTAppraisedCase_SimEN.CollegeID = objRow[convYoungTAppraisedCase_Sim.CollegeID] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.CollegeID].ToString().Trim(); //学院ID
objvYoungTAppraisedCase_SimEN.EntryYear = objRow[convYoungTAppraisedCase_Sim.EntryYear] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.EntryYear].ToString().Trim(); //EntryYear
objvYoungTAppraisedCase_SimEN.CollegeNameA = objRow[convYoungTAppraisedCase_Sim.CollegeNameA] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.CollegeNameA].ToString().Trim(); //学院名称简写
objvYoungTAppraisedCase_SimEN.IsDualVideo = TransNullToBool(objRow[convYoungTAppraisedCase_Sim.IsDualVideo].ToString().Trim()); //是否双视频
objvYoungTAppraisedCase_SimEN.IdYoungTAppraisedCaseType = objRow[convYoungTAppraisedCase_Sim.IdYoungTAppraisedCaseType] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.IdYoungTAppraisedCaseType].ToString().Trim(); //青教案例类型流水号
objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseTypeName = objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTypeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTypeName].ToString().Trim(); //青教案例类型名称
objvYoungTAppraisedCase_SimEN.UserTypeId = objRow[convYoungTAppraisedCase_Sim.UserTypeId] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.UserTypeId].ToString().Trim(); //用户类型Id
objvYoungTAppraisedCase_SimEN.UserTypeName = objRow[convYoungTAppraisedCase_Sim.UserTypeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.UserTypeName].ToString().Trim(); //用户类型名称
objvYoungTAppraisedCase_SimEN.RecommendedDegreeId = objRow[convYoungTAppraisedCase_Sim.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvYoungTAppraisedCase_SimEN.RecommendedDegreeName = objRow[convYoungTAppraisedCase_Sim.RecommendedDegreeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvYoungTAppraisedCase_SimEN.Memo = objRow[convYoungTAppraisedCase_Sim.Memo] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Sim.Memo].ToString().Trim(); //备注
objvYoungTAppraisedCase_SimEN.IsUse = TransNullToBool(objRow[convYoungTAppraisedCase_Sim.IsUse].ToString().Trim()); //是否使用
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvYoungTAppraisedCase_SimDA: GetObjByDataRow)", objException.Message));
}
objvYoungTAppraisedCase_SimEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvYoungTAppraisedCase_SimEN;
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
objSQL = clsvYoungTAppraisedCase_SimDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvYoungTAppraisedCase_SimEN._CurrTabName, convYoungTAppraisedCase_Sim.IdYoungTAppraisedCase, 8, "");
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
objSQL = clsvYoungTAppraisedCase_SimDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvYoungTAppraisedCase_SimEN._CurrTabName, convYoungTAppraisedCase_Sim.IdYoungTAppraisedCase, 8, strPrefix);
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
 objSQL = clsvYoungTAppraisedCase_SimDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdYoungTAppraisedCase from vYoungTAppraisedCase_Sim where " + strCondition;
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
 objSQL = clsvYoungTAppraisedCase_SimDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdYoungTAppraisedCase from vYoungTAppraisedCase_Sim where " + strCondition;
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
 /// <param name = "strIdYoungTAppraisedCase">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strIdYoungTAppraisedCase)
{
CheckPrimaryKey(strIdYoungTAppraisedCase);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCase_SimDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vYoungTAppraisedCase_Sim", "IdYoungTAppraisedCase = " + "'"+ strIdYoungTAppraisedCase+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvYoungTAppraisedCase_SimDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCase_SimDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vYoungTAppraisedCase_Sim", strCondition))
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
objSQL = clsvYoungTAppraisedCase_SimDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vYoungTAppraisedCase_Sim");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_SimENS">源对象</param>
 /// <param name = "objvYoungTAppraisedCase_SimENT">目标对象</param>
public void CopyTo(clsvYoungTAppraisedCase_SimEN objvYoungTAppraisedCase_SimENS, clsvYoungTAppraisedCase_SimEN objvYoungTAppraisedCase_SimENT)
{
objvYoungTAppraisedCase_SimENT.IdYoungTAppraisedCase = objvYoungTAppraisedCase_SimENS.IdYoungTAppraisedCase; //青教评优案例流水号
objvYoungTAppraisedCase_SimENT.YoungTAppraisedCaseID = objvYoungTAppraisedCase_SimENS.YoungTAppraisedCaseID; //青教评优案例ID
objvYoungTAppraisedCase_SimENT.YoungTAppraisedCaseName = objvYoungTAppraisedCase_SimENS.YoungTAppraisedCaseName; //青教评优案例名称
objvYoungTAppraisedCase_SimENT.YoungTAppraisedCaseText = objvYoungTAppraisedCase_SimENS.YoungTAppraisedCaseText; //案例文本内容
objvYoungTAppraisedCase_SimENT.YoungTAppraisedCaseDate = objvYoungTAppraisedCase_SimENS.YoungTAppraisedCaseDate; //青教评优教学日期
objvYoungTAppraisedCase_SimENT.YoungTAppraisedCaseTime = objvYoungTAppraisedCase_SimENS.YoungTAppraisedCaseTime; //青教评优教学时间
objvYoungTAppraisedCase_SimENT.YoungTAppraisedCaseTheme = objvYoungTAppraisedCase_SimENS.YoungTAppraisedCaseTheme; //青教评优案例主题词
objvYoungTAppraisedCase_SimENT.YoungTAppraisedCaseDateIn = objvYoungTAppraisedCase_SimENS.YoungTAppraisedCaseDateIn; //案例入库日期
objvYoungTAppraisedCase_SimENT.YoungTAppraisedCaseTimeIn = objvYoungTAppraisedCase_SimENS.YoungTAppraisedCaseTimeIn; //案例入库时间
objvYoungTAppraisedCase_SimENT.IdStudyLevel = objvYoungTAppraisedCase_SimENS.IdStudyLevel; //id_StudyLevel
objvYoungTAppraisedCase_SimENT.StudyLevelName = objvYoungTAppraisedCase_SimENS.StudyLevelName; //学段名称
objvYoungTAppraisedCase_SimENT.IdTeachingPlan = objvYoungTAppraisedCase_SimENS.IdTeachingPlan; //教案流水号
objvYoungTAppraisedCase_SimENT.IdCaseType = objvYoungTAppraisedCase_SimENS.IdCaseType; //案例类型流水号
objvYoungTAppraisedCase_SimENT.IdDiscipline = objvYoungTAppraisedCase_SimENS.IdDiscipline; //学科流水号
objvYoungTAppraisedCase_SimENT.DisciplineID = objvYoungTAppraisedCase_SimENS.DisciplineID; //学科ID
objvYoungTAppraisedCase_SimENT.DisciplineName = objvYoungTAppraisedCase_SimENS.DisciplineName; //学科名称
objvYoungTAppraisedCase_SimENT.BrowseCount = objvYoungTAppraisedCase_SimENS.BrowseCount; //浏览次数
objvYoungTAppraisedCase_SimENT.IdSenateGaugeVersion = objvYoungTAppraisedCase_SimENS.IdSenateGaugeVersion; //评价量表版本流水号
objvYoungTAppraisedCase_SimENT.senateGaugeVersionID = objvYoungTAppraisedCase_SimENS.senateGaugeVersionID; //评价量表版本ID
objvYoungTAppraisedCase_SimENT.senateGaugeVersionName = objvYoungTAppraisedCase_SimENS.senateGaugeVersionName; //评价量表版本名称
objvYoungTAppraisedCase_SimENT.senateGaugeVersionTtlScore = objvYoungTAppraisedCase_SimENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvYoungTAppraisedCase_SimENT.VersionNo = objvYoungTAppraisedCase_SimENS.VersionNo; //版本号
objvYoungTAppraisedCase_SimENT.IdTeachSkill = objvYoungTAppraisedCase_SimENS.IdTeachSkill; //教学技能流水号
objvYoungTAppraisedCase_SimENT.TeachSkillID = objvYoungTAppraisedCase_SimENS.TeachSkillID; //教学技能ID
objvYoungTAppraisedCase_SimENT.SkillTypeName = objvYoungTAppraisedCase_SimENS.SkillTypeName; //技能类型名称
objvYoungTAppraisedCase_SimENT.TeachSkillName = objvYoungTAppraisedCase_SimENS.TeachSkillName; //教学技能名称
objvYoungTAppraisedCase_SimENT.TeachSkillTheory = objvYoungTAppraisedCase_SimENS.TeachSkillTheory; //教学技能理论阐述
objvYoungTAppraisedCase_SimENT.TeachSkillOperMethod = objvYoungTAppraisedCase_SimENS.TeachSkillOperMethod; //教学技能实践操作方法
objvYoungTAppraisedCase_SimENT.IdSkillType = objvYoungTAppraisedCase_SimENS.IdSkillType; //技能类型流水号
objvYoungTAppraisedCase_SimENT.SkillTypeID = objvYoungTAppraisedCase_SimENS.SkillTypeID; //技能类型ID
objvYoungTAppraisedCase_SimENT.CaseLevelId = objvYoungTAppraisedCase_SimENS.CaseLevelId; //课例等级Id
objvYoungTAppraisedCase_SimENT.DocFile = objvYoungTAppraisedCase_SimENS.DocFile; //生成的Word文件名
objvYoungTAppraisedCase_SimENT.IsNeedGeneWord = objvYoungTAppraisedCase_SimENS.IsNeedGeneWord; //是否需要生成Word
objvYoungTAppraisedCase_SimENT.WordCreateDate = objvYoungTAppraisedCase_SimENS.WordCreateDate; //Word生成日期
objvYoungTAppraisedCase_SimENT.IsVisible = objvYoungTAppraisedCase_SimENS.IsVisible; //是否显示
objvYoungTAppraisedCase_SimENT.OwnerId = objvYoungTAppraisedCase_SimENS.OwnerId; //拥有者Id
objvYoungTAppraisedCase_SimENT.TeacherID = objvYoungTAppraisedCase_SimENS.TeacherID; //教师工号
objvYoungTAppraisedCase_SimENT.TeacherName = objvYoungTAppraisedCase_SimENS.TeacherName; //教师姓名
objvYoungTAppraisedCase_SimENT.IdXzCollege = objvYoungTAppraisedCase_SimENS.IdXzCollege; //学院流水号
objvYoungTAppraisedCase_SimENT.CollegeName = objvYoungTAppraisedCase_SimENS.CollegeName; //学院名称
objvYoungTAppraisedCase_SimENT.EntryDate = objvYoungTAppraisedCase_SimENS.EntryDate; //进校日期
objvYoungTAppraisedCase_SimENT.CollegeID = objvYoungTAppraisedCase_SimENS.CollegeID; //学院ID
objvYoungTAppraisedCase_SimENT.EntryYear = objvYoungTAppraisedCase_SimENS.EntryYear; //EntryYear
objvYoungTAppraisedCase_SimENT.CollegeNameA = objvYoungTAppraisedCase_SimENS.CollegeNameA; //学院名称简写
objvYoungTAppraisedCase_SimENT.IsDualVideo = objvYoungTAppraisedCase_SimENS.IsDualVideo; //是否双视频
objvYoungTAppraisedCase_SimENT.IdYoungTAppraisedCaseType = objvYoungTAppraisedCase_SimENS.IdYoungTAppraisedCaseType; //青教案例类型流水号
objvYoungTAppraisedCase_SimENT.YoungTAppraisedCaseTypeName = objvYoungTAppraisedCase_SimENS.YoungTAppraisedCaseTypeName; //青教案例类型名称
objvYoungTAppraisedCase_SimENT.UserTypeId = objvYoungTAppraisedCase_SimENS.UserTypeId; //用户类型Id
objvYoungTAppraisedCase_SimENT.UserTypeName = objvYoungTAppraisedCase_SimENS.UserTypeName; //用户类型名称
objvYoungTAppraisedCase_SimENT.RecommendedDegreeId = objvYoungTAppraisedCase_SimENS.RecommendedDegreeId; //推荐度Id
objvYoungTAppraisedCase_SimENT.RecommendedDegreeName = objvYoungTAppraisedCase_SimENS.RecommendedDegreeName; //推荐度名称
objvYoungTAppraisedCase_SimENT.Memo = objvYoungTAppraisedCase_SimENS.Memo; //备注
objvYoungTAppraisedCase_SimENT.IsUse = objvYoungTAppraisedCase_SimENS.IsUse; //是否使用
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvYoungTAppraisedCase_SimEN objvYoungTAppraisedCase_SimEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_SimEN.IdYoungTAppraisedCase, 8, convYoungTAppraisedCase_Sim.IdYoungTAppraisedCase);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseID, 8, convYoungTAppraisedCase_Sim.YoungTAppraisedCaseID);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseName, 100, convYoungTAppraisedCase_Sim.YoungTAppraisedCaseName);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseText, 8000, convYoungTAppraisedCase_Sim.YoungTAppraisedCaseText);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseDate, 8, convYoungTAppraisedCase_Sim.YoungTAppraisedCaseDate);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseTime, 6, convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTime);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseTheme, 200, convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTheme);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseDateIn, 8, convYoungTAppraisedCase_Sim.YoungTAppraisedCaseDateIn);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseTimeIn, 6, convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTimeIn);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_SimEN.IdStudyLevel, 4, convYoungTAppraisedCase_Sim.IdStudyLevel);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_SimEN.StudyLevelName, 50, convYoungTAppraisedCase_Sim.StudyLevelName);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_SimEN.IdTeachingPlan, 8, convYoungTAppraisedCase_Sim.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_SimEN.IdCaseType, 4, convYoungTAppraisedCase_Sim.IdCaseType);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_SimEN.IdDiscipline, 4, convYoungTAppraisedCase_Sim.IdDiscipline);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_SimEN.DisciplineID, 4, convYoungTAppraisedCase_Sim.DisciplineID);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_SimEN.DisciplineName, 50, convYoungTAppraisedCase_Sim.DisciplineName);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_SimEN.IdSenateGaugeVersion, 4, convYoungTAppraisedCase_Sim.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_SimEN.senateGaugeVersionID, 4, convYoungTAppraisedCase_Sim.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_SimEN.senateGaugeVersionName, 200, convYoungTAppraisedCase_Sim.senateGaugeVersionName);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_SimEN.IdTeachSkill, 8, convYoungTAppraisedCase_Sim.IdTeachSkill);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_SimEN.TeachSkillID, 8, convYoungTAppraisedCase_Sim.TeachSkillID);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_SimEN.SkillTypeName, 50, convYoungTAppraisedCase_Sim.SkillTypeName);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_SimEN.TeachSkillName, 50, convYoungTAppraisedCase_Sim.TeachSkillName);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_SimEN.TeachSkillTheory, 8000, convYoungTAppraisedCase_Sim.TeachSkillTheory);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_SimEN.TeachSkillOperMethod, 2000, convYoungTAppraisedCase_Sim.TeachSkillOperMethod);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_SimEN.IdSkillType, 4, convYoungTAppraisedCase_Sim.IdSkillType);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_SimEN.SkillTypeID, 4, convYoungTAppraisedCase_Sim.SkillTypeID);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_SimEN.CaseLevelId, 2, convYoungTAppraisedCase_Sim.CaseLevelId);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_SimEN.DocFile, 200, convYoungTAppraisedCase_Sim.DocFile);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_SimEN.WordCreateDate, 14, convYoungTAppraisedCase_Sim.WordCreateDate);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_SimEN.OwnerId, 20, convYoungTAppraisedCase_Sim.OwnerId);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_SimEN.TeacherID, 12, convYoungTAppraisedCase_Sim.TeacherID);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_SimEN.TeacherName, 50, convYoungTAppraisedCase_Sim.TeacherName);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_SimEN.IdXzCollege, 4, convYoungTAppraisedCase_Sim.IdXzCollege);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_SimEN.CollegeName, 100, convYoungTAppraisedCase_Sim.CollegeName);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_SimEN.EntryDate, 8, convYoungTAppraisedCase_Sim.EntryDate);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_SimEN.CollegeID, 4, convYoungTAppraisedCase_Sim.CollegeID);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_SimEN.EntryYear, 8, convYoungTAppraisedCase_Sim.EntryYear);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_SimEN.CollegeNameA, 12, convYoungTAppraisedCase_Sim.CollegeNameA);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_SimEN.IdYoungTAppraisedCaseType, 4, convYoungTAppraisedCase_Sim.IdYoungTAppraisedCaseType);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseTypeName, 50, convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTypeName);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_SimEN.UserTypeId, 2, convYoungTAppraisedCase_Sim.UserTypeId);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_SimEN.UserTypeName, 20, convYoungTAppraisedCase_Sim.UserTypeName);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_SimEN.RecommendedDegreeId, 2, convYoungTAppraisedCase_Sim.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_SimEN.RecommendedDegreeName, 30, convYoungTAppraisedCase_Sim.RecommendedDegreeName);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_SimEN.Memo, 1000, convYoungTAppraisedCase_Sim.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_SimEN.IdYoungTAppraisedCase, convYoungTAppraisedCase_Sim.IdYoungTAppraisedCase);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseID, convYoungTAppraisedCase_Sim.YoungTAppraisedCaseID);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseName, convYoungTAppraisedCase_Sim.YoungTAppraisedCaseName);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseText, convYoungTAppraisedCase_Sim.YoungTAppraisedCaseText);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseDate, convYoungTAppraisedCase_Sim.YoungTAppraisedCaseDate);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseTime, convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTime);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseTheme, convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTheme);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseDateIn, convYoungTAppraisedCase_Sim.YoungTAppraisedCaseDateIn);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseTimeIn, convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTimeIn);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_SimEN.IdStudyLevel, convYoungTAppraisedCase_Sim.IdStudyLevel);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_SimEN.StudyLevelName, convYoungTAppraisedCase_Sim.StudyLevelName);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_SimEN.IdTeachingPlan, convYoungTAppraisedCase_Sim.IdTeachingPlan);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_SimEN.IdCaseType, convYoungTAppraisedCase_Sim.IdCaseType);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_SimEN.IdDiscipline, convYoungTAppraisedCase_Sim.IdDiscipline);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_SimEN.DisciplineID, convYoungTAppraisedCase_Sim.DisciplineID);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_SimEN.DisciplineName, convYoungTAppraisedCase_Sim.DisciplineName);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_SimEN.IdSenateGaugeVersion, convYoungTAppraisedCase_Sim.IdSenateGaugeVersion);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_SimEN.senateGaugeVersionID, convYoungTAppraisedCase_Sim.senateGaugeVersionID);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_SimEN.senateGaugeVersionName, convYoungTAppraisedCase_Sim.senateGaugeVersionName);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_SimEN.IdTeachSkill, convYoungTAppraisedCase_Sim.IdTeachSkill);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_SimEN.TeachSkillID, convYoungTAppraisedCase_Sim.TeachSkillID);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_SimEN.SkillTypeName, convYoungTAppraisedCase_Sim.SkillTypeName);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_SimEN.TeachSkillName, convYoungTAppraisedCase_Sim.TeachSkillName);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_SimEN.TeachSkillTheory, convYoungTAppraisedCase_Sim.TeachSkillTheory);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_SimEN.TeachSkillOperMethod, convYoungTAppraisedCase_Sim.TeachSkillOperMethod);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_SimEN.IdSkillType, convYoungTAppraisedCase_Sim.IdSkillType);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_SimEN.SkillTypeID, convYoungTAppraisedCase_Sim.SkillTypeID);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_SimEN.CaseLevelId, convYoungTAppraisedCase_Sim.CaseLevelId);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_SimEN.DocFile, convYoungTAppraisedCase_Sim.DocFile);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_SimEN.WordCreateDate, convYoungTAppraisedCase_Sim.WordCreateDate);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_SimEN.OwnerId, convYoungTAppraisedCase_Sim.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_SimEN.TeacherID, convYoungTAppraisedCase_Sim.TeacherID);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_SimEN.TeacherName, convYoungTAppraisedCase_Sim.TeacherName);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_SimEN.IdXzCollege, convYoungTAppraisedCase_Sim.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_SimEN.CollegeName, convYoungTAppraisedCase_Sim.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_SimEN.EntryDate, convYoungTAppraisedCase_Sim.EntryDate);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_SimEN.CollegeID, convYoungTAppraisedCase_Sim.CollegeID);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_SimEN.EntryYear, convYoungTAppraisedCase_Sim.EntryYear);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_SimEN.CollegeNameA, convYoungTAppraisedCase_Sim.CollegeNameA);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_SimEN.IdYoungTAppraisedCaseType, convYoungTAppraisedCase_Sim.IdYoungTAppraisedCaseType);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_SimEN.YoungTAppraisedCaseTypeName, convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_SimEN.UserTypeId, convYoungTAppraisedCase_Sim.UserTypeId);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_SimEN.UserTypeName, convYoungTAppraisedCase_Sim.UserTypeName);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_SimEN.RecommendedDegreeId, convYoungTAppraisedCase_Sim.RecommendedDegreeId);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_SimEN.RecommendedDegreeName, convYoungTAppraisedCase_Sim.RecommendedDegreeName);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_SimEN.Memo, convYoungTAppraisedCase_Sim.Memo);
//检查外键字段长度
 objvYoungTAppraisedCase_SimEN._IsCheckProperty = true;
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
 objSQL = clsvYoungTAppraisedCase_SimDA.GetSpecSQLObj();
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
 objSQL = clsvYoungTAppraisedCase_SimDA.GetSpecSQLObj();
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
 objSQL = clsvYoungTAppraisedCase_SimDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvYoungTAppraisedCase_SimEN._CurrTabName);
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
 objSQL = clsvYoungTAppraisedCase_SimDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvYoungTAppraisedCase_SimEN._CurrTabName, strCondition);
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
 objSQL = clsvYoungTAppraisedCase_SimDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}