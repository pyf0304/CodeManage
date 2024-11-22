
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvYoungTAppraisedCase_Resource_RelDA
 表名:vYoungTAppraisedCase_Resource_Rel(01120422)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:51:25
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
 /// vYoungTAppraisedCase_Resource_Rel(vYoungTAppraisedCase_Resource_Rel)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvYoungTAppraisedCase_Resource_RelDA : clsCommBase4DA
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
 return clsvYoungTAppraisedCase_Resource_RelEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvYoungTAppraisedCase_Resource_RelEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvYoungTAppraisedCase_Resource_RelEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvYoungTAppraisedCase_Resource_RelEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvYoungTAppraisedCase_Resource_RelEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvYoungTAppraisedCase_Resource_RelDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vYoungTAppraisedCase_Resource_Rel where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vYoungTAppraisedCase_Resource_Rel(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvYoungTAppraisedCase_Resource_RelDA: GetDataTable_vYoungTAppraisedCase_Resource_Rel)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vYoungTAppraisedCase_Resource_Rel where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvYoungTAppraisedCase_Resource_RelDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCase_Resource_RelDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvYoungTAppraisedCase_Resource_RelDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vYoungTAppraisedCase_Resource_Rel where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvYoungTAppraisedCase_Resource_RelDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCase_Resource_RelDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvYoungTAppraisedCase_Resource_RelDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCase_Resource_RelDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vYoungTAppraisedCase_Resource_Rel where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vYoungTAppraisedCase_Resource_Rel where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvYoungTAppraisedCase_Resource_RelDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCase_Resource_RelDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vYoungTAppraisedCase_Resource_Rel where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvYoungTAppraisedCase_Resource_RelDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCase_Resource_RelDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vYoungTAppraisedCase_Resource_Rel.* from vYoungTAppraisedCase_Resource_Rel Left Join {1} on {2} where {3} and vYoungTAppraisedCase_Resource_Rel.IdMicroteachCaseResourceRel not in (Select top {5} vYoungTAppraisedCase_Resource_Rel.IdMicroteachCaseResourceRel from vYoungTAppraisedCase_Resource_Rel Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vYoungTAppraisedCase_Resource_Rel where {1} and IdMicroteachCaseResourceRel not in (Select top {2} IdMicroteachCaseResourceRel from vYoungTAppraisedCase_Resource_Rel where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vYoungTAppraisedCase_Resource_Rel where {1} and IdMicroteachCaseResourceRel not in (Select top {3} IdMicroteachCaseResourceRel from vYoungTAppraisedCase_Resource_Rel where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvYoungTAppraisedCase_Resource_RelDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCase_Resource_RelDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vYoungTAppraisedCase_Resource_Rel.* from vYoungTAppraisedCase_Resource_Rel Left Join {1} on {2} where {3} and vYoungTAppraisedCase_Resource_Rel.IdMicroteachCaseResourceRel not in (Select top {5} vYoungTAppraisedCase_Resource_Rel.IdMicroteachCaseResourceRel from vYoungTAppraisedCase_Resource_Rel Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vYoungTAppraisedCase_Resource_Rel where {1} and IdMicroteachCaseResourceRel not in (Select top {2} IdMicroteachCaseResourceRel from vYoungTAppraisedCase_Resource_Rel where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vYoungTAppraisedCase_Resource_Rel where {1} and IdMicroteachCaseResourceRel not in (Select top {3} IdMicroteachCaseResourceRel from vYoungTAppraisedCase_Resource_Rel where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvYoungTAppraisedCase_Resource_RelEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvYoungTAppraisedCase_Resource_RelDA:GetObjLst)", objException.Message));
}
List<clsvYoungTAppraisedCase_Resource_RelEN> arrObjLst = new List<clsvYoungTAppraisedCase_Resource_RelEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vYoungTAppraisedCase_Resource_Rel where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN = new clsvYoungTAppraisedCase_Resource_RelEN();
try
{
objvYoungTAppraisedCase_Resource_RelEN.IdMicroteachCaseResourceRel = TransNullToInt(objRow[convYoungTAppraisedCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvYoungTAppraisedCase_Resource_RelEN.FuncModuleId = objRow[convYoungTAppraisedCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvYoungTAppraisedCase_Resource_RelEN.FuncModuleName = objRow[convYoungTAppraisedCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvYoungTAppraisedCase_Resource_RelEN.IdMicroteachCase = objRow[convYoungTAppraisedCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvYoungTAppraisedCase_Resource_RelEN.IdYoungTAppraisedCase = objRow[convYoungTAppraisedCase_Resource_Rel.IdYoungTAppraisedCase].ToString().Trim(); //青教评优案例流水号
objvYoungTAppraisedCase_Resource_RelEN.YoungTAppraisedCaseID = objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseID].ToString().Trim(); //青教评优案例ID
objvYoungTAppraisedCase_Resource_RelEN.YoungTAppraisedCaseName = objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseName].ToString().Trim(); //青教评优案例名称
objvYoungTAppraisedCase_Resource_RelEN.YoungTAppraisedCaseText = objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseText] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseText].ToString().Trim(); //案例文本内容
objvYoungTAppraisedCase_Resource_RelEN.YoungTAppraisedCaseDate = objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseDate].ToString().Trim(); //青教评优教学日期
objvYoungTAppraisedCase_Resource_RelEN.YoungTAppraisedCaseTime = objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTime] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTime].ToString().Trim(); //青教评优教学时间
objvYoungTAppraisedCase_Resource_RelEN.YoungTAppraisedCaseTheme = objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTheme] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTheme].ToString().Trim(); //青教评优案例主题词
objvYoungTAppraisedCase_Resource_RelEN.YoungTAppraisedCaseDateIn = objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseDateIn] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseDateIn].ToString().Trim(); //案例入库日期
objvYoungTAppraisedCase_Resource_RelEN.YoungTAppraisedCaseTimeIn = objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTimeIn] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTimeIn].ToString().Trim(); //案例入库时间
objvYoungTAppraisedCase_Resource_RelEN.IdStudyLevel = objRow[convYoungTAppraisedCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvYoungTAppraisedCase_Resource_RelEN.StudyLevelName = objRow[convYoungTAppraisedCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvYoungTAppraisedCase_Resource_RelEN.IdTeachingPlan = objRow[convYoungTAppraisedCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvYoungTAppraisedCase_Resource_RelEN.IdDiscipline = objRow[convYoungTAppraisedCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvYoungTAppraisedCase_Resource_RelEN.DisciplineID = objRow[convYoungTAppraisedCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID
objvYoungTAppraisedCase_Resource_RelEN.DisciplineName = objRow[convYoungTAppraisedCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvYoungTAppraisedCase_Resource_RelEN.senateGaugeVersionID = objRow[convYoungTAppraisedCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvYoungTAppraisedCase_Resource_RelEN.senateGaugeVersionName = objRow[convYoungTAppraisedCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvYoungTAppraisedCase_Resource_RelEN.senateGaugeVersionTtlScore = TransNullToFloat(objRow[convYoungTAppraisedCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvYoungTAppraisedCase_Resource_RelEN.VersionNo = objRow[convYoungTAppraisedCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convYoungTAppraisedCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvYoungTAppraisedCase_Resource_RelEN.IdTeachSkill = objRow[convYoungTAppraisedCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvYoungTAppraisedCase_Resource_RelEN.TeachSkillID = objRow[convYoungTAppraisedCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID
objvYoungTAppraisedCase_Resource_RelEN.SkillTypeName = objRow[convYoungTAppraisedCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称
objvYoungTAppraisedCase_Resource_RelEN.TeachSkillName = objRow[convYoungTAppraisedCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称
objvYoungTAppraisedCase_Resource_RelEN.IdSkillType = objRow[convYoungTAppraisedCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号
objvYoungTAppraisedCase_Resource_RelEN.CaseLevelId = objRow[convYoungTAppraisedCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvYoungTAppraisedCase_Resource_RelEN.OwnerId = objRow[convYoungTAppraisedCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvYoungTAppraisedCase_Resource_RelEN.TeacherID = objRow[convYoungTAppraisedCase_Resource_Rel.TeacherID].ToString().Trim(); //教师工号
objvYoungTAppraisedCase_Resource_RelEN.TeacherName = objRow[convYoungTAppraisedCase_Resource_Rel.TeacherName].ToString().Trim(); //教师姓名
objvYoungTAppraisedCase_Resource_RelEN.CollegeID = objRow[convYoungTAppraisedCase_Resource_Rel.CollegeID].ToString().Trim(); //学院ID
objvYoungTAppraisedCase_Resource_RelEN.CollegeName = objRow[convYoungTAppraisedCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvYoungTAppraisedCase_Resource_RelEN.IdXzCollege = objRow[convYoungTAppraisedCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvYoungTAppraisedCase_Resource_RelEN.EntryDate = objRow[convYoungTAppraisedCase_Resource_Rel.EntryDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.EntryDate].ToString().Trim(); //进校日期
objvYoungTAppraisedCase_Resource_RelEN.IsDualVideo = TransNullToBool(objRow[convYoungTAppraisedCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvYoungTAppraisedCase_Resource_RelEN.UserTypeId = objRow[convYoungTAppraisedCase_Resource_Rel.UserTypeId] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.UserTypeId].ToString().Trim(); //用户类型Id
objvYoungTAppraisedCase_Resource_RelEN.UserTypeName = objRow[convYoungTAppraisedCase_Resource_Rel.UserTypeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.UserTypeName].ToString().Trim(); //用户类型名称
objvYoungTAppraisedCase_Resource_RelEN.RecommendedDegreeId = objRow[convYoungTAppraisedCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvYoungTAppraisedCase_Resource_RelEN.RecommendedDegreeName = objRow[convYoungTAppraisedCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvYoungTAppraisedCase_Resource_RelEN.BrowseCount4Case = objRow[convYoungTAppraisedCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convYoungTAppraisedCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvYoungTAppraisedCase_Resource_RelEN.EntryYear = objRow[convYoungTAppraisedCase_Resource_Rel.EntryYear] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.EntryYear].ToString().Trim(); //EntryYear
objvYoungTAppraisedCase_Resource_RelEN.IdResource = objRow[convYoungTAppraisedCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvYoungTAppraisedCase_Resource_RelEN.ResourceID = objRow[convYoungTAppraisedCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvYoungTAppraisedCase_Resource_RelEN.IdFtpResource = objRow[convYoungTAppraisedCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvYoungTAppraisedCase_Resource_RelEN.IdFile = objRow[convYoungTAppraisedCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvYoungTAppraisedCase_Resource_RelEN.FileName = objRow[convYoungTAppraisedCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvYoungTAppraisedCase_Resource_RelEN.FileType = objRow[convYoungTAppraisedCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvYoungTAppraisedCase_Resource_RelEN.SaveDate = objRow[convYoungTAppraisedCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvYoungTAppraisedCase_Resource_RelEN.FileSize = objRow[convYoungTAppraisedCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvYoungTAppraisedCase_Resource_RelEN.SaveTime = objRow[convYoungTAppraisedCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvYoungTAppraisedCase_Resource_RelEN.FtpResourceID = objRow[convYoungTAppraisedCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvYoungTAppraisedCase_Resource_RelEN.FileOriginalName = objRow[convYoungTAppraisedCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvYoungTAppraisedCase_Resource_RelEN.FileDirName = objRow[convYoungTAppraisedCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvYoungTAppraisedCase_Resource_RelEN.FileRename = objRow[convYoungTAppraisedCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvYoungTAppraisedCase_Resource_RelEN.FileUpDate = objRow[convYoungTAppraisedCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvYoungTAppraisedCase_Resource_RelEN.FileUpTime = objRow[convYoungTAppraisedCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvYoungTAppraisedCase_Resource_RelEN.SaveMode = TransNullToBool(objRow[convYoungTAppraisedCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvYoungTAppraisedCase_Resource_RelEN.IdResourceType = objRow[convYoungTAppraisedCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvYoungTAppraisedCase_Resource_RelEN.ResourceTypeID = objRow[convYoungTAppraisedCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvYoungTAppraisedCase_Resource_RelEN.ResourceTypeName = objRow[convYoungTAppraisedCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvYoungTAppraisedCase_Resource_RelEN.ResourceOwner = objRow[convYoungTAppraisedCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvYoungTAppraisedCase_Resource_RelEN.ftpFileType = objRow[convYoungTAppraisedCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvYoungTAppraisedCase_Resource_RelEN.ftpFileSize = objRow[convYoungTAppraisedCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvYoungTAppraisedCase_Resource_RelEN.ftpResourceOwner = objRow[convYoungTAppraisedCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvYoungTAppraisedCase_Resource_RelEN.FileOriginName = objRow[convYoungTAppraisedCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvYoungTAppraisedCase_Resource_RelEN.IsExistFile = TransNullToBool(objRow[convYoungTAppraisedCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvYoungTAppraisedCase_Resource_RelEN.FileNewName = objRow[convYoungTAppraisedCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvYoungTAppraisedCase_Resource_RelEN.FileOldName = objRow[convYoungTAppraisedCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvYoungTAppraisedCase_Resource_RelEN.IsMain = TransNullToBool(objRow[convYoungTAppraisedCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvYoungTAppraisedCase_Resource_RelEN.IdUsingMode = objRow[convYoungTAppraisedCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvYoungTAppraisedCase_Resource_RelEN.IsVisible = TransNullToBool(objRow[convYoungTAppraisedCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvYoungTAppraisedCase_Resource_RelEN.IndexNO = objRow[convYoungTAppraisedCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convYoungTAppraisedCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvYoungTAppraisedCase_Resource_RelEN.BrowseCount = objRow[convYoungTAppraisedCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convYoungTAppraisedCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvYoungTAppraisedCase_Resource_RelEN.UpdDate = objRow[convYoungTAppraisedCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvYoungTAppraisedCase_Resource_RelEN.UpdUser = objRow[convYoungTAppraisedCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvYoungTAppraisedCase_Resource_RelEN.Memo = objRow[convYoungTAppraisedCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvYoungTAppraisedCase_Resource_RelDA: GetObjLst)", objException.Message));
}
objvYoungTAppraisedCase_Resource_RelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvYoungTAppraisedCase_Resource_RelEN);
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
public List<clsvYoungTAppraisedCase_Resource_RelEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvYoungTAppraisedCase_Resource_RelDA:GetObjLstByTabName)", objException.Message));
}
List<clsvYoungTAppraisedCase_Resource_RelEN> arrObjLst = new List<clsvYoungTAppraisedCase_Resource_RelEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCase_Resource_RelDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN = new clsvYoungTAppraisedCase_Resource_RelEN();
try
{
objvYoungTAppraisedCase_Resource_RelEN.IdMicroteachCaseResourceRel = TransNullToInt(objRow[convYoungTAppraisedCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvYoungTAppraisedCase_Resource_RelEN.FuncModuleId = objRow[convYoungTAppraisedCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvYoungTAppraisedCase_Resource_RelEN.FuncModuleName = objRow[convYoungTAppraisedCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvYoungTAppraisedCase_Resource_RelEN.IdMicroteachCase = objRow[convYoungTAppraisedCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvYoungTAppraisedCase_Resource_RelEN.IdYoungTAppraisedCase = objRow[convYoungTAppraisedCase_Resource_Rel.IdYoungTAppraisedCase].ToString().Trim(); //青教评优案例流水号
objvYoungTAppraisedCase_Resource_RelEN.YoungTAppraisedCaseID = objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseID].ToString().Trim(); //青教评优案例ID
objvYoungTAppraisedCase_Resource_RelEN.YoungTAppraisedCaseName = objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseName].ToString().Trim(); //青教评优案例名称
objvYoungTAppraisedCase_Resource_RelEN.YoungTAppraisedCaseText = objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseText] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseText].ToString().Trim(); //案例文本内容
objvYoungTAppraisedCase_Resource_RelEN.YoungTAppraisedCaseDate = objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseDate].ToString().Trim(); //青教评优教学日期
objvYoungTAppraisedCase_Resource_RelEN.YoungTAppraisedCaseTime = objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTime] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTime].ToString().Trim(); //青教评优教学时间
objvYoungTAppraisedCase_Resource_RelEN.YoungTAppraisedCaseTheme = objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTheme] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTheme].ToString().Trim(); //青教评优案例主题词
objvYoungTAppraisedCase_Resource_RelEN.YoungTAppraisedCaseDateIn = objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseDateIn] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseDateIn].ToString().Trim(); //案例入库日期
objvYoungTAppraisedCase_Resource_RelEN.YoungTAppraisedCaseTimeIn = objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTimeIn] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTimeIn].ToString().Trim(); //案例入库时间
objvYoungTAppraisedCase_Resource_RelEN.IdStudyLevel = objRow[convYoungTAppraisedCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvYoungTAppraisedCase_Resource_RelEN.StudyLevelName = objRow[convYoungTAppraisedCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvYoungTAppraisedCase_Resource_RelEN.IdTeachingPlan = objRow[convYoungTAppraisedCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvYoungTAppraisedCase_Resource_RelEN.IdDiscipline = objRow[convYoungTAppraisedCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvYoungTAppraisedCase_Resource_RelEN.DisciplineID = objRow[convYoungTAppraisedCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID
objvYoungTAppraisedCase_Resource_RelEN.DisciplineName = objRow[convYoungTAppraisedCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvYoungTAppraisedCase_Resource_RelEN.senateGaugeVersionID = objRow[convYoungTAppraisedCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvYoungTAppraisedCase_Resource_RelEN.senateGaugeVersionName = objRow[convYoungTAppraisedCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvYoungTAppraisedCase_Resource_RelEN.senateGaugeVersionTtlScore = TransNullToFloat(objRow[convYoungTAppraisedCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvYoungTAppraisedCase_Resource_RelEN.VersionNo = objRow[convYoungTAppraisedCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convYoungTAppraisedCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvYoungTAppraisedCase_Resource_RelEN.IdTeachSkill = objRow[convYoungTAppraisedCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvYoungTAppraisedCase_Resource_RelEN.TeachSkillID = objRow[convYoungTAppraisedCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID
objvYoungTAppraisedCase_Resource_RelEN.SkillTypeName = objRow[convYoungTAppraisedCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称
objvYoungTAppraisedCase_Resource_RelEN.TeachSkillName = objRow[convYoungTAppraisedCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称
objvYoungTAppraisedCase_Resource_RelEN.IdSkillType = objRow[convYoungTAppraisedCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号
objvYoungTAppraisedCase_Resource_RelEN.CaseLevelId = objRow[convYoungTAppraisedCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvYoungTAppraisedCase_Resource_RelEN.OwnerId = objRow[convYoungTAppraisedCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvYoungTAppraisedCase_Resource_RelEN.TeacherID = objRow[convYoungTAppraisedCase_Resource_Rel.TeacherID].ToString().Trim(); //教师工号
objvYoungTAppraisedCase_Resource_RelEN.TeacherName = objRow[convYoungTAppraisedCase_Resource_Rel.TeacherName].ToString().Trim(); //教师姓名
objvYoungTAppraisedCase_Resource_RelEN.CollegeID = objRow[convYoungTAppraisedCase_Resource_Rel.CollegeID].ToString().Trim(); //学院ID
objvYoungTAppraisedCase_Resource_RelEN.CollegeName = objRow[convYoungTAppraisedCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvYoungTAppraisedCase_Resource_RelEN.IdXzCollege = objRow[convYoungTAppraisedCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvYoungTAppraisedCase_Resource_RelEN.EntryDate = objRow[convYoungTAppraisedCase_Resource_Rel.EntryDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.EntryDate].ToString().Trim(); //进校日期
objvYoungTAppraisedCase_Resource_RelEN.IsDualVideo = TransNullToBool(objRow[convYoungTAppraisedCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvYoungTAppraisedCase_Resource_RelEN.UserTypeId = objRow[convYoungTAppraisedCase_Resource_Rel.UserTypeId] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.UserTypeId].ToString().Trim(); //用户类型Id
objvYoungTAppraisedCase_Resource_RelEN.UserTypeName = objRow[convYoungTAppraisedCase_Resource_Rel.UserTypeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.UserTypeName].ToString().Trim(); //用户类型名称
objvYoungTAppraisedCase_Resource_RelEN.RecommendedDegreeId = objRow[convYoungTAppraisedCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvYoungTAppraisedCase_Resource_RelEN.RecommendedDegreeName = objRow[convYoungTAppraisedCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvYoungTAppraisedCase_Resource_RelEN.BrowseCount4Case = objRow[convYoungTAppraisedCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convYoungTAppraisedCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvYoungTAppraisedCase_Resource_RelEN.EntryYear = objRow[convYoungTAppraisedCase_Resource_Rel.EntryYear] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.EntryYear].ToString().Trim(); //EntryYear
objvYoungTAppraisedCase_Resource_RelEN.IdResource = objRow[convYoungTAppraisedCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvYoungTAppraisedCase_Resource_RelEN.ResourceID = objRow[convYoungTAppraisedCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvYoungTAppraisedCase_Resource_RelEN.IdFtpResource = objRow[convYoungTAppraisedCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvYoungTAppraisedCase_Resource_RelEN.IdFile = objRow[convYoungTAppraisedCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvYoungTAppraisedCase_Resource_RelEN.FileName = objRow[convYoungTAppraisedCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvYoungTAppraisedCase_Resource_RelEN.FileType = objRow[convYoungTAppraisedCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvYoungTAppraisedCase_Resource_RelEN.SaveDate = objRow[convYoungTAppraisedCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvYoungTAppraisedCase_Resource_RelEN.FileSize = objRow[convYoungTAppraisedCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvYoungTAppraisedCase_Resource_RelEN.SaveTime = objRow[convYoungTAppraisedCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvYoungTAppraisedCase_Resource_RelEN.FtpResourceID = objRow[convYoungTAppraisedCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvYoungTAppraisedCase_Resource_RelEN.FileOriginalName = objRow[convYoungTAppraisedCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvYoungTAppraisedCase_Resource_RelEN.FileDirName = objRow[convYoungTAppraisedCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvYoungTAppraisedCase_Resource_RelEN.FileRename = objRow[convYoungTAppraisedCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvYoungTAppraisedCase_Resource_RelEN.FileUpDate = objRow[convYoungTAppraisedCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvYoungTAppraisedCase_Resource_RelEN.FileUpTime = objRow[convYoungTAppraisedCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvYoungTAppraisedCase_Resource_RelEN.SaveMode = TransNullToBool(objRow[convYoungTAppraisedCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvYoungTAppraisedCase_Resource_RelEN.IdResourceType = objRow[convYoungTAppraisedCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvYoungTAppraisedCase_Resource_RelEN.ResourceTypeID = objRow[convYoungTAppraisedCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvYoungTAppraisedCase_Resource_RelEN.ResourceTypeName = objRow[convYoungTAppraisedCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvYoungTAppraisedCase_Resource_RelEN.ResourceOwner = objRow[convYoungTAppraisedCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvYoungTAppraisedCase_Resource_RelEN.ftpFileType = objRow[convYoungTAppraisedCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvYoungTAppraisedCase_Resource_RelEN.ftpFileSize = objRow[convYoungTAppraisedCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvYoungTAppraisedCase_Resource_RelEN.ftpResourceOwner = objRow[convYoungTAppraisedCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvYoungTAppraisedCase_Resource_RelEN.FileOriginName = objRow[convYoungTAppraisedCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvYoungTAppraisedCase_Resource_RelEN.IsExistFile = TransNullToBool(objRow[convYoungTAppraisedCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvYoungTAppraisedCase_Resource_RelEN.FileNewName = objRow[convYoungTAppraisedCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvYoungTAppraisedCase_Resource_RelEN.FileOldName = objRow[convYoungTAppraisedCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvYoungTAppraisedCase_Resource_RelEN.IsMain = TransNullToBool(objRow[convYoungTAppraisedCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvYoungTAppraisedCase_Resource_RelEN.IdUsingMode = objRow[convYoungTAppraisedCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvYoungTAppraisedCase_Resource_RelEN.IsVisible = TransNullToBool(objRow[convYoungTAppraisedCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvYoungTAppraisedCase_Resource_RelEN.IndexNO = objRow[convYoungTAppraisedCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convYoungTAppraisedCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvYoungTAppraisedCase_Resource_RelEN.BrowseCount = objRow[convYoungTAppraisedCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convYoungTAppraisedCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvYoungTAppraisedCase_Resource_RelEN.UpdDate = objRow[convYoungTAppraisedCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvYoungTAppraisedCase_Resource_RelEN.UpdUser = objRow[convYoungTAppraisedCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvYoungTAppraisedCase_Resource_RelEN.Memo = objRow[convYoungTAppraisedCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvYoungTAppraisedCase_Resource_RelDA: GetObjLst)", objException.Message));
}
objvYoungTAppraisedCase_Resource_RelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvYoungTAppraisedCase_Resource_RelEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvYoungTAppraisedCase_Resource_Rel(ref clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vYoungTAppraisedCase_Resource_Rel where IdMicroteachCaseResourceRel = " + ""+ objvYoungTAppraisedCase_Resource_RelEN.IdMicroteachCaseResourceRel+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvYoungTAppraisedCase_Resource_RelEN.IdMicroteachCaseResourceRel = TransNullToInt(objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvYoungTAppraisedCase_Resource_RelEN.FuncModuleId = objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.FuncModuleName = objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvYoungTAppraisedCase_Resource_RelEN.IdMicroteachCase = objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvYoungTAppraisedCase_Resource_RelEN.IdYoungTAppraisedCase = objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.IdYoungTAppraisedCase].ToString().Trim(); //青教评优案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvYoungTAppraisedCase_Resource_RelEN.YoungTAppraisedCaseID = objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseID].ToString().Trim(); //青教评优案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvYoungTAppraisedCase_Resource_RelEN.YoungTAppraisedCaseName = objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseName].ToString().Trim(); //青教评优案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvYoungTAppraisedCase_Resource_RelEN.YoungTAppraisedCaseText = objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.YoungTAppraisedCaseDate = objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseDate].ToString().Trim(); //青教评优教学日期(字段类型:char,字段长度:8,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.YoungTAppraisedCaseTime = objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTime].ToString().Trim(); //青教评优教学时间(字段类型:char,字段长度:6,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.YoungTAppraisedCaseTheme = objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTheme].ToString().Trim(); //青教评优案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.YoungTAppraisedCaseDateIn = objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.YoungTAppraisedCaseTimeIn = objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.IdStudyLevel = objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.StudyLevelName = objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvYoungTAppraisedCase_Resource_RelEN.IdTeachingPlan = objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvYoungTAppraisedCase_Resource_RelEN.IdDiscipline = objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvYoungTAppraisedCase_Resource_RelEN.DisciplineID = objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvYoungTAppraisedCase_Resource_RelEN.DisciplineName = objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvYoungTAppraisedCase_Resource_RelEN.senateGaugeVersionID = objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvYoungTAppraisedCase_Resource_RelEN.senateGaugeVersionName = objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.senateGaugeVersionTtlScore = TransNullToFloat(objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvYoungTAppraisedCase_Resource_RelEN.VersionNo = TransNullToInt(objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.IdTeachSkill = objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objvYoungTAppraisedCase_Resource_RelEN.TeachSkillID = objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID(字段类型:char,字段长度:8,是否可空:False)
 objvYoungTAppraisedCase_Resource_RelEN.SkillTypeName = objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvYoungTAppraisedCase_Resource_RelEN.TeachSkillName = objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvYoungTAppraisedCase_Resource_RelEN.IdSkillType = objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvYoungTAppraisedCase_Resource_RelEN.CaseLevelId = objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.OwnerId = objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvYoungTAppraisedCase_Resource_RelEN.TeacherID = objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.TeacherID].ToString().Trim(); //教师工号(字段类型:varchar,字段长度:12,是否可空:False)
 objvYoungTAppraisedCase_Resource_RelEN.TeacherName = objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.TeacherName].ToString().Trim(); //教师姓名(字段类型:varchar,字段长度:50,是否可空:False)
 objvYoungTAppraisedCase_Resource_RelEN.CollegeID = objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvYoungTAppraisedCase_Resource_RelEN.CollegeName = objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvYoungTAppraisedCase_Resource_RelEN.IdXzCollege = objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.EntryDate = objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.EntryDate].ToString().Trim(); //进校日期(字段类型:char,字段长度:8,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.IsDualVideo = TransNullToBool(objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvYoungTAppraisedCase_Resource_RelEN.UserTypeId = objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.UserTypeName = objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.UserTypeName].ToString().Trim(); //用户类型名称(字段类型:varchar,字段长度:20,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.RecommendedDegreeId = objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvYoungTAppraisedCase_Resource_RelEN.RecommendedDegreeName = objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvYoungTAppraisedCase_Resource_RelEN.BrowseCount4Case = TransNullToInt(objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.EntryYear = objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.EntryYear].ToString().Trim(); //EntryYear(字段类型:varchar,字段长度:8,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.IdResource = objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objvYoungTAppraisedCase_Resource_RelEN.ResourceID = objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvYoungTAppraisedCase_Resource_RelEN.IdFtpResource = objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.IdFile = objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号(字段类型:char,字段长度:8,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.FileName = objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.FileType = objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.SaveDate = objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.FileSize = objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.SaveTime = objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.FtpResourceID = objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvYoungTAppraisedCase_Resource_RelEN.FileOriginalName = objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名(字段类型:varchar,字段长度:200,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.FileDirName = objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.FileRename = objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名(字段类型:varchar,字段长度:200,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.FileUpDate = objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.FileUpTime = objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.SaveMode = TransNullToBool(objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式(字段类型:bit,字段长度:1,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.IdResourceType = objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvYoungTAppraisedCase_Resource_RelEN.ResourceTypeID = objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvYoungTAppraisedCase_Resource_RelEN.ResourceTypeName = objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvYoungTAppraisedCase_Resource_RelEN.ResourceOwner = objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者(字段类型:varchar,字段长度:50,是否可空:False)
 objvYoungTAppraisedCase_Resource_RelEN.ftpFileType = objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.ftpFileSize = objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.ftpResourceOwner = objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者(字段类型:varchar,字段长度:50,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.FileOriginName = objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名(字段类型:varchar,字段长度:500,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.IsExistFile = TransNullToBool(objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.FileNewName = objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.FileOldName = objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.IsMain = TransNullToBool(objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源(字段类型:bit,字段长度:1,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.IdUsingMode = objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号(字段类型:char,字段长度:4,是否可空:False)
 objvYoungTAppraisedCase_Resource_RelEN.IsVisible = TransNullToBool(objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.IndexNO = TransNullToInt(objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.IndexNO].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.BrowseCount = TransNullToInt(objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.UpdDate = objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.UpdUser = objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.Memo = objDT.Rows[0][convYoungTAppraisedCase_Resource_Rel.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvYoungTAppraisedCase_Resource_RelDA: GetvYoungTAppraisedCase_Resource_Rel)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdMicroteachCaseResourceRel">表关键字</param>
 /// <returns>表对象</returns>
public clsvYoungTAppraisedCase_Resource_RelEN GetObjByIdMicroteachCaseResourceRel(long lngIdMicroteachCaseResourceRel)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vYoungTAppraisedCase_Resource_Rel where IdMicroteachCaseResourceRel = " + ""+ lngIdMicroteachCaseResourceRel+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN = new clsvYoungTAppraisedCase_Resource_RelEN();
try
{
 objvYoungTAppraisedCase_Resource_RelEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convYoungTAppraisedCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvYoungTAppraisedCase_Resource_RelEN.FuncModuleId = objRow[convYoungTAppraisedCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.FuncModuleName = objRow[convYoungTAppraisedCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvYoungTAppraisedCase_Resource_RelEN.IdMicroteachCase = objRow[convYoungTAppraisedCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvYoungTAppraisedCase_Resource_RelEN.IdYoungTAppraisedCase = objRow[convYoungTAppraisedCase_Resource_Rel.IdYoungTAppraisedCase].ToString().Trim(); //青教评优案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvYoungTAppraisedCase_Resource_RelEN.YoungTAppraisedCaseID = objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseID].ToString().Trim(); //青教评优案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvYoungTAppraisedCase_Resource_RelEN.YoungTAppraisedCaseName = objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseName].ToString().Trim(); //青教评优案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvYoungTAppraisedCase_Resource_RelEN.YoungTAppraisedCaseText = objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseText] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.YoungTAppraisedCaseDate = objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseDate].ToString().Trim(); //青教评优教学日期(字段类型:char,字段长度:8,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.YoungTAppraisedCaseTime = objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTime] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTime].ToString().Trim(); //青教评优教学时间(字段类型:char,字段长度:6,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.YoungTAppraisedCaseTheme = objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTheme] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTheme].ToString().Trim(); //青教评优案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.YoungTAppraisedCaseDateIn = objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseDateIn] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.YoungTAppraisedCaseTimeIn = objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTimeIn] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.IdStudyLevel = objRow[convYoungTAppraisedCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.StudyLevelName = objRow[convYoungTAppraisedCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvYoungTAppraisedCase_Resource_RelEN.IdTeachingPlan = objRow[convYoungTAppraisedCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvYoungTAppraisedCase_Resource_RelEN.IdDiscipline = objRow[convYoungTAppraisedCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvYoungTAppraisedCase_Resource_RelEN.DisciplineID = objRow[convYoungTAppraisedCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvYoungTAppraisedCase_Resource_RelEN.DisciplineName = objRow[convYoungTAppraisedCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvYoungTAppraisedCase_Resource_RelEN.senateGaugeVersionID = objRow[convYoungTAppraisedCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvYoungTAppraisedCase_Resource_RelEN.senateGaugeVersionName = objRow[convYoungTAppraisedCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convYoungTAppraisedCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvYoungTAppraisedCase_Resource_RelEN.VersionNo = objRow[convYoungTAppraisedCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convYoungTAppraisedCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.IdTeachSkill = objRow[convYoungTAppraisedCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objvYoungTAppraisedCase_Resource_RelEN.TeachSkillID = objRow[convYoungTAppraisedCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID(字段类型:char,字段长度:8,是否可空:False)
 objvYoungTAppraisedCase_Resource_RelEN.SkillTypeName = objRow[convYoungTAppraisedCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvYoungTAppraisedCase_Resource_RelEN.TeachSkillName = objRow[convYoungTAppraisedCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvYoungTAppraisedCase_Resource_RelEN.IdSkillType = objRow[convYoungTAppraisedCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvYoungTAppraisedCase_Resource_RelEN.CaseLevelId = objRow[convYoungTAppraisedCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.OwnerId = objRow[convYoungTAppraisedCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvYoungTAppraisedCase_Resource_RelEN.TeacherID = objRow[convYoungTAppraisedCase_Resource_Rel.TeacherID].ToString().Trim(); //教师工号(字段类型:varchar,字段长度:12,是否可空:False)
 objvYoungTAppraisedCase_Resource_RelEN.TeacherName = objRow[convYoungTAppraisedCase_Resource_Rel.TeacherName].ToString().Trim(); //教师姓名(字段类型:varchar,字段长度:50,是否可空:False)
 objvYoungTAppraisedCase_Resource_RelEN.CollegeID = objRow[convYoungTAppraisedCase_Resource_Rel.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvYoungTAppraisedCase_Resource_RelEN.CollegeName = objRow[convYoungTAppraisedCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvYoungTAppraisedCase_Resource_RelEN.IdXzCollege = objRow[convYoungTAppraisedCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.EntryDate = objRow[convYoungTAppraisedCase_Resource_Rel.EntryDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.EntryDate].ToString().Trim(); //进校日期(字段类型:char,字段长度:8,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convYoungTAppraisedCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvYoungTAppraisedCase_Resource_RelEN.UserTypeId = objRow[convYoungTAppraisedCase_Resource_Rel.UserTypeId] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.UserTypeName = objRow[convYoungTAppraisedCase_Resource_Rel.UserTypeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.UserTypeName].ToString().Trim(); //用户类型名称(字段类型:varchar,字段长度:20,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.RecommendedDegreeId = objRow[convYoungTAppraisedCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvYoungTAppraisedCase_Resource_RelEN.RecommendedDegreeName = objRow[convYoungTAppraisedCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvYoungTAppraisedCase_Resource_RelEN.BrowseCount4Case = objRow[convYoungTAppraisedCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convYoungTAppraisedCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.EntryYear = objRow[convYoungTAppraisedCase_Resource_Rel.EntryYear] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.EntryYear].ToString().Trim(); //EntryYear(字段类型:varchar,字段长度:8,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.IdResource = objRow[convYoungTAppraisedCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objvYoungTAppraisedCase_Resource_RelEN.ResourceID = objRow[convYoungTAppraisedCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvYoungTAppraisedCase_Resource_RelEN.IdFtpResource = objRow[convYoungTAppraisedCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.IdFile = objRow[convYoungTAppraisedCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号(字段类型:char,字段长度:8,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.FileName = objRow[convYoungTAppraisedCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.FileType = objRow[convYoungTAppraisedCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.SaveDate = objRow[convYoungTAppraisedCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.FileSize = objRow[convYoungTAppraisedCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.SaveTime = objRow[convYoungTAppraisedCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.FtpResourceID = objRow[convYoungTAppraisedCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvYoungTAppraisedCase_Resource_RelEN.FileOriginalName = objRow[convYoungTAppraisedCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名(字段类型:varchar,字段长度:200,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.FileDirName = objRow[convYoungTAppraisedCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.FileRename = objRow[convYoungTAppraisedCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名(字段类型:varchar,字段长度:200,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.FileUpDate = objRow[convYoungTAppraisedCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.FileUpTime = objRow[convYoungTAppraisedCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convYoungTAppraisedCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式(字段类型:bit,字段长度:1,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.IdResourceType = objRow[convYoungTAppraisedCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvYoungTAppraisedCase_Resource_RelEN.ResourceTypeID = objRow[convYoungTAppraisedCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvYoungTAppraisedCase_Resource_RelEN.ResourceTypeName = objRow[convYoungTAppraisedCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvYoungTAppraisedCase_Resource_RelEN.ResourceOwner = objRow[convYoungTAppraisedCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者(字段类型:varchar,字段长度:50,是否可空:False)
 objvYoungTAppraisedCase_Resource_RelEN.ftpFileType = objRow[convYoungTAppraisedCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.ftpFileSize = objRow[convYoungTAppraisedCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.ftpResourceOwner = objRow[convYoungTAppraisedCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者(字段类型:varchar,字段长度:50,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.FileOriginName = objRow[convYoungTAppraisedCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名(字段类型:varchar,字段长度:500,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convYoungTAppraisedCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.FileNewName = objRow[convYoungTAppraisedCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.FileOldName = objRow[convYoungTAppraisedCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convYoungTAppraisedCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源(字段类型:bit,字段长度:1,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.IdUsingMode = objRow[convYoungTAppraisedCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号(字段类型:char,字段长度:4,是否可空:False)
 objvYoungTAppraisedCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convYoungTAppraisedCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.IndexNO = objRow[convYoungTAppraisedCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convYoungTAppraisedCase_Resource_Rel.IndexNO].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.BrowseCount = objRow[convYoungTAppraisedCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convYoungTAppraisedCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.UpdDate = objRow[convYoungTAppraisedCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.UpdUser = objRow[convYoungTAppraisedCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvYoungTAppraisedCase_Resource_RelEN.Memo = objRow[convYoungTAppraisedCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvYoungTAppraisedCase_Resource_RelDA: GetObjByIdMicroteachCaseResourceRel)", objException.Message));
}
return objvYoungTAppraisedCase_Resource_RelEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvYoungTAppraisedCase_Resource_RelEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvYoungTAppraisedCase_Resource_RelDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vYoungTAppraisedCase_Resource_Rel where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN = new clsvYoungTAppraisedCase_Resource_RelEN()
{
IdMicroteachCaseResourceRel = TransNullToInt(objRow[convYoungTAppraisedCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()), //微格案例资源关系流水号
FuncModuleId = objRow[convYoungTAppraisedCase_Resource_Rel.FuncModuleId].ToString().Trim(), //功能模块Id
FuncModuleName = objRow[convYoungTAppraisedCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.FuncModuleName].ToString().Trim(), //功能模块名称
IdMicroteachCase = objRow[convYoungTAppraisedCase_Resource_Rel.IdMicroteachCase].ToString().Trim(), //微格教学案例流水号
IdYoungTAppraisedCase = objRow[convYoungTAppraisedCase_Resource_Rel.IdYoungTAppraisedCase].ToString().Trim(), //青教评优案例流水号
YoungTAppraisedCaseID = objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseID].ToString().Trim(), //青教评优案例ID
YoungTAppraisedCaseName = objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseName].ToString().Trim(), //青教评优案例名称
YoungTAppraisedCaseText = objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseText] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseText].ToString().Trim(), //案例文本内容
YoungTAppraisedCaseDate = objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseDate].ToString().Trim(), //青教评优教学日期
YoungTAppraisedCaseTime = objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTime] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTime].ToString().Trim(), //青教评优教学时间
YoungTAppraisedCaseTheme = objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTheme] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTheme].ToString().Trim(), //青教评优案例主题词
YoungTAppraisedCaseDateIn = objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseDateIn] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseDateIn].ToString().Trim(), //案例入库日期
YoungTAppraisedCaseTimeIn = objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTimeIn] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTimeIn].ToString().Trim(), //案例入库时间
IdStudyLevel = objRow[convYoungTAppraisedCase_Resource_Rel.IdStudyLevel].ToString().Trim(), //id_StudyLevel
StudyLevelName = objRow[convYoungTAppraisedCase_Resource_Rel.StudyLevelName].ToString().Trim(), //学段名称
IdTeachingPlan = objRow[convYoungTAppraisedCase_Resource_Rel.IdTeachingPlan].ToString().Trim(), //教案流水号
IdDiscipline = objRow[convYoungTAppraisedCase_Resource_Rel.IdDiscipline].ToString().Trim(), //学科流水号
DisciplineID = objRow[convYoungTAppraisedCase_Resource_Rel.DisciplineID].ToString().Trim(), //学科ID
DisciplineName = objRow[convYoungTAppraisedCase_Resource_Rel.DisciplineName].ToString().Trim(), //学科名称
senateGaugeVersionID = objRow[convYoungTAppraisedCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(), //评价量表版本ID
senateGaugeVersionName = objRow[convYoungTAppraisedCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(), //评价量表版本名称
senateGaugeVersionTtlScore = TransNullToFloat(objRow[convYoungTAppraisedCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()), //评价量表版本总分
VersionNo = objRow[convYoungTAppraisedCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convYoungTAppraisedCase_Resource_Rel.VersionNo].ToString().Trim()), //版本号
IdTeachSkill = objRow[convYoungTAppraisedCase_Resource_Rel.IdTeachSkill].ToString().Trim(), //教学技能流水号
TeachSkillID = objRow[convYoungTAppraisedCase_Resource_Rel.TeachSkillID].ToString().Trim(), //教学技能ID
SkillTypeName = objRow[convYoungTAppraisedCase_Resource_Rel.SkillTypeName].ToString().Trim(), //技能类型名称
TeachSkillName = objRow[convYoungTAppraisedCase_Resource_Rel.TeachSkillName].ToString().Trim(), //教学技能名称
IdSkillType = objRow[convYoungTAppraisedCase_Resource_Rel.IdSkillType].ToString().Trim(), //技能类型流水号
CaseLevelId = objRow[convYoungTAppraisedCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.CaseLevelId].ToString().Trim(), //课例等级Id
OwnerId = objRow[convYoungTAppraisedCase_Resource_Rel.OwnerId].ToString().Trim(), //拥有者Id
TeacherID = objRow[convYoungTAppraisedCase_Resource_Rel.TeacherID].ToString().Trim(), //教师工号
TeacherName = objRow[convYoungTAppraisedCase_Resource_Rel.TeacherName].ToString().Trim(), //教师姓名
CollegeID = objRow[convYoungTAppraisedCase_Resource_Rel.CollegeID].ToString().Trim(), //学院ID
CollegeName = objRow[convYoungTAppraisedCase_Resource_Rel.CollegeName].ToString().Trim(), //学院名称
IdXzCollege = objRow[convYoungTAppraisedCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.IdXzCollege].ToString().Trim(), //学院流水号
EntryDate = objRow[convYoungTAppraisedCase_Resource_Rel.EntryDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.EntryDate].ToString().Trim(), //进校日期
IsDualVideo = TransNullToBool(objRow[convYoungTAppraisedCase_Resource_Rel.IsDualVideo].ToString().Trim()), //是否双视频
UserTypeId = objRow[convYoungTAppraisedCase_Resource_Rel.UserTypeId] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.UserTypeId].ToString().Trim(), //用户类型Id
UserTypeName = objRow[convYoungTAppraisedCase_Resource_Rel.UserTypeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.UserTypeName].ToString().Trim(), //用户类型名称
RecommendedDegreeId = objRow[convYoungTAppraisedCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(), //推荐度Id
RecommendedDegreeName = objRow[convYoungTAppraisedCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(), //推荐度名称
BrowseCount4Case = objRow[convYoungTAppraisedCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convYoungTAppraisedCase_Resource_Rel.BrowseCount4Case].ToString().Trim()), //课例浏览次数
EntryYear = objRow[convYoungTAppraisedCase_Resource_Rel.EntryYear] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.EntryYear].ToString().Trim(), //EntryYear
IdResource = objRow[convYoungTAppraisedCase_Resource_Rel.IdResource].ToString().Trim(), //资源流水号
ResourceID = objRow[convYoungTAppraisedCase_Resource_Rel.ResourceID].ToString().Trim(), //资源ID
IdFtpResource = objRow[convYoungTAppraisedCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.IdFtpResource].ToString().Trim(), //FTP资源流水号
IdFile = objRow[convYoungTAppraisedCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.IdFile].ToString().Trim(), //文件流水号
FileName = objRow[convYoungTAppraisedCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.FileName].ToString().Trim(), //文件名称
FileType = objRow[convYoungTAppraisedCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.FileType].ToString().Trim(), //文件类型
SaveDate = objRow[convYoungTAppraisedCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.SaveDate].ToString().Trim(), //创建日期
FileSize = objRow[convYoungTAppraisedCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.FileSize].ToString().Trim(), //文件大小
SaveTime = objRow[convYoungTAppraisedCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.SaveTime].ToString().Trim(), //创建时间
FtpResourceID = objRow[convYoungTAppraisedCase_Resource_Rel.FtpResourceID].ToString().Trim(), //FTP资源ID
FileOriginalName = objRow[convYoungTAppraisedCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.FileOriginalName].ToString().Trim(), //文件原名
FileDirName = objRow[convYoungTAppraisedCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.FileDirName].ToString().Trim(), //文件目录名
FileRename = objRow[convYoungTAppraisedCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.FileRename].ToString().Trim(), //文件新名
FileUpDate = objRow[convYoungTAppraisedCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.FileUpDate].ToString().Trim(), //创建日期
FileUpTime = objRow[convYoungTAppraisedCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.FileUpTime].ToString().Trim(), //创建时间
SaveMode = TransNullToBool(objRow[convYoungTAppraisedCase_Resource_Rel.SaveMode].ToString().Trim()), //文件存放方式
IdResourceType = objRow[convYoungTAppraisedCase_Resource_Rel.IdResourceType].ToString().Trim(), //资源类型流水号
ResourceTypeID = objRow[convYoungTAppraisedCase_Resource_Rel.ResourceTypeID].ToString().Trim(), //资源类型ID
ResourceTypeName = objRow[convYoungTAppraisedCase_Resource_Rel.ResourceTypeName].ToString().Trim(), //资源类型名称
ResourceOwner = objRow[convYoungTAppraisedCase_Resource_Rel.ResourceOwner].ToString().Trim(), //上传者
ftpFileType = objRow[convYoungTAppraisedCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.ftpFileType].ToString().Trim(), //ftp文件类型
ftpFileSize = objRow[convYoungTAppraisedCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.ftpFileSize].ToString().Trim(), //ftp文件大小
ftpResourceOwner = objRow[convYoungTAppraisedCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.ftpResourceOwner].ToString().Trim(), //Ftp资源拥有者
FileOriginName = objRow[convYoungTAppraisedCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.FileOriginName].ToString().Trim(), //原文件名
IsExistFile = TransNullToBool(objRow[convYoungTAppraisedCase_Resource_Rel.IsExistFile].ToString().Trim()), //是否存在文件
FileNewName = objRow[convYoungTAppraisedCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.FileNewName].ToString().Trim(), //新文件名
FileOldName = objRow[convYoungTAppraisedCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.FileOldName].ToString().Trim(), //旧文件名
IsMain = TransNullToBool(objRow[convYoungTAppraisedCase_Resource_Rel.IsMain].ToString().Trim()), //是否主资源
IdUsingMode = objRow[convYoungTAppraisedCase_Resource_Rel.IdUsingMode].ToString().Trim(), //资源使用模式流水号
IsVisible = TransNullToBool(objRow[convYoungTAppraisedCase_Resource_Rel.IsVisible].ToString().Trim()), //是否显示
IndexNO = objRow[convYoungTAppraisedCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convYoungTAppraisedCase_Resource_Rel.IndexNO].ToString().Trim()), //序号
BrowseCount = objRow[convYoungTAppraisedCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convYoungTAppraisedCase_Resource_Rel.BrowseCount].ToString().Trim()), //浏览次数
UpdDate = objRow[convYoungTAppraisedCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convYoungTAppraisedCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convYoungTAppraisedCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.Memo].ToString().Trim() //备注
};
objvYoungTAppraisedCase_Resource_RelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvYoungTAppraisedCase_Resource_RelEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvYoungTAppraisedCase_Resource_RelDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvYoungTAppraisedCase_Resource_RelEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN = new clsvYoungTAppraisedCase_Resource_RelEN();
try
{
objvYoungTAppraisedCase_Resource_RelEN.IdMicroteachCaseResourceRel = TransNullToInt(objRow[convYoungTAppraisedCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvYoungTAppraisedCase_Resource_RelEN.FuncModuleId = objRow[convYoungTAppraisedCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvYoungTAppraisedCase_Resource_RelEN.FuncModuleName = objRow[convYoungTAppraisedCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvYoungTAppraisedCase_Resource_RelEN.IdMicroteachCase = objRow[convYoungTAppraisedCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvYoungTAppraisedCase_Resource_RelEN.IdYoungTAppraisedCase = objRow[convYoungTAppraisedCase_Resource_Rel.IdYoungTAppraisedCase].ToString().Trim(); //青教评优案例流水号
objvYoungTAppraisedCase_Resource_RelEN.YoungTAppraisedCaseID = objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseID].ToString().Trim(); //青教评优案例ID
objvYoungTAppraisedCase_Resource_RelEN.YoungTAppraisedCaseName = objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseName].ToString().Trim(); //青教评优案例名称
objvYoungTAppraisedCase_Resource_RelEN.YoungTAppraisedCaseText = objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseText] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseText].ToString().Trim(); //案例文本内容
objvYoungTAppraisedCase_Resource_RelEN.YoungTAppraisedCaseDate = objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseDate].ToString().Trim(); //青教评优教学日期
objvYoungTAppraisedCase_Resource_RelEN.YoungTAppraisedCaseTime = objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTime] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTime].ToString().Trim(); //青教评优教学时间
objvYoungTAppraisedCase_Resource_RelEN.YoungTAppraisedCaseTheme = objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTheme] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTheme].ToString().Trim(); //青教评优案例主题词
objvYoungTAppraisedCase_Resource_RelEN.YoungTAppraisedCaseDateIn = objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseDateIn] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseDateIn].ToString().Trim(); //案例入库日期
objvYoungTAppraisedCase_Resource_RelEN.YoungTAppraisedCaseTimeIn = objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTimeIn] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTimeIn].ToString().Trim(); //案例入库时间
objvYoungTAppraisedCase_Resource_RelEN.IdStudyLevel = objRow[convYoungTAppraisedCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvYoungTAppraisedCase_Resource_RelEN.StudyLevelName = objRow[convYoungTAppraisedCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvYoungTAppraisedCase_Resource_RelEN.IdTeachingPlan = objRow[convYoungTAppraisedCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvYoungTAppraisedCase_Resource_RelEN.IdDiscipline = objRow[convYoungTAppraisedCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvYoungTAppraisedCase_Resource_RelEN.DisciplineID = objRow[convYoungTAppraisedCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID
objvYoungTAppraisedCase_Resource_RelEN.DisciplineName = objRow[convYoungTAppraisedCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvYoungTAppraisedCase_Resource_RelEN.senateGaugeVersionID = objRow[convYoungTAppraisedCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvYoungTAppraisedCase_Resource_RelEN.senateGaugeVersionName = objRow[convYoungTAppraisedCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvYoungTAppraisedCase_Resource_RelEN.senateGaugeVersionTtlScore = TransNullToFloat(objRow[convYoungTAppraisedCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvYoungTAppraisedCase_Resource_RelEN.VersionNo = objRow[convYoungTAppraisedCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convYoungTAppraisedCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvYoungTAppraisedCase_Resource_RelEN.IdTeachSkill = objRow[convYoungTAppraisedCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvYoungTAppraisedCase_Resource_RelEN.TeachSkillID = objRow[convYoungTAppraisedCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID
objvYoungTAppraisedCase_Resource_RelEN.SkillTypeName = objRow[convYoungTAppraisedCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称
objvYoungTAppraisedCase_Resource_RelEN.TeachSkillName = objRow[convYoungTAppraisedCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称
objvYoungTAppraisedCase_Resource_RelEN.IdSkillType = objRow[convYoungTAppraisedCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号
objvYoungTAppraisedCase_Resource_RelEN.CaseLevelId = objRow[convYoungTAppraisedCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvYoungTAppraisedCase_Resource_RelEN.OwnerId = objRow[convYoungTAppraisedCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvYoungTAppraisedCase_Resource_RelEN.TeacherID = objRow[convYoungTAppraisedCase_Resource_Rel.TeacherID].ToString().Trim(); //教师工号
objvYoungTAppraisedCase_Resource_RelEN.TeacherName = objRow[convYoungTAppraisedCase_Resource_Rel.TeacherName].ToString().Trim(); //教师姓名
objvYoungTAppraisedCase_Resource_RelEN.CollegeID = objRow[convYoungTAppraisedCase_Resource_Rel.CollegeID].ToString().Trim(); //学院ID
objvYoungTAppraisedCase_Resource_RelEN.CollegeName = objRow[convYoungTAppraisedCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvYoungTAppraisedCase_Resource_RelEN.IdXzCollege = objRow[convYoungTAppraisedCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvYoungTAppraisedCase_Resource_RelEN.EntryDate = objRow[convYoungTAppraisedCase_Resource_Rel.EntryDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.EntryDate].ToString().Trim(); //进校日期
objvYoungTAppraisedCase_Resource_RelEN.IsDualVideo = TransNullToBool(objRow[convYoungTAppraisedCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvYoungTAppraisedCase_Resource_RelEN.UserTypeId = objRow[convYoungTAppraisedCase_Resource_Rel.UserTypeId] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.UserTypeId].ToString().Trim(); //用户类型Id
objvYoungTAppraisedCase_Resource_RelEN.UserTypeName = objRow[convYoungTAppraisedCase_Resource_Rel.UserTypeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.UserTypeName].ToString().Trim(); //用户类型名称
objvYoungTAppraisedCase_Resource_RelEN.RecommendedDegreeId = objRow[convYoungTAppraisedCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvYoungTAppraisedCase_Resource_RelEN.RecommendedDegreeName = objRow[convYoungTAppraisedCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvYoungTAppraisedCase_Resource_RelEN.BrowseCount4Case = objRow[convYoungTAppraisedCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convYoungTAppraisedCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvYoungTAppraisedCase_Resource_RelEN.EntryYear = objRow[convYoungTAppraisedCase_Resource_Rel.EntryYear] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.EntryYear].ToString().Trim(); //EntryYear
objvYoungTAppraisedCase_Resource_RelEN.IdResource = objRow[convYoungTAppraisedCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvYoungTAppraisedCase_Resource_RelEN.ResourceID = objRow[convYoungTAppraisedCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvYoungTAppraisedCase_Resource_RelEN.IdFtpResource = objRow[convYoungTAppraisedCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvYoungTAppraisedCase_Resource_RelEN.IdFile = objRow[convYoungTAppraisedCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvYoungTAppraisedCase_Resource_RelEN.FileName = objRow[convYoungTAppraisedCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvYoungTAppraisedCase_Resource_RelEN.FileType = objRow[convYoungTAppraisedCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvYoungTAppraisedCase_Resource_RelEN.SaveDate = objRow[convYoungTAppraisedCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvYoungTAppraisedCase_Resource_RelEN.FileSize = objRow[convYoungTAppraisedCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvYoungTAppraisedCase_Resource_RelEN.SaveTime = objRow[convYoungTAppraisedCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvYoungTAppraisedCase_Resource_RelEN.FtpResourceID = objRow[convYoungTAppraisedCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvYoungTAppraisedCase_Resource_RelEN.FileOriginalName = objRow[convYoungTAppraisedCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvYoungTAppraisedCase_Resource_RelEN.FileDirName = objRow[convYoungTAppraisedCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvYoungTAppraisedCase_Resource_RelEN.FileRename = objRow[convYoungTAppraisedCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvYoungTAppraisedCase_Resource_RelEN.FileUpDate = objRow[convYoungTAppraisedCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvYoungTAppraisedCase_Resource_RelEN.FileUpTime = objRow[convYoungTAppraisedCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvYoungTAppraisedCase_Resource_RelEN.SaveMode = TransNullToBool(objRow[convYoungTAppraisedCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvYoungTAppraisedCase_Resource_RelEN.IdResourceType = objRow[convYoungTAppraisedCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvYoungTAppraisedCase_Resource_RelEN.ResourceTypeID = objRow[convYoungTAppraisedCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvYoungTAppraisedCase_Resource_RelEN.ResourceTypeName = objRow[convYoungTAppraisedCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvYoungTAppraisedCase_Resource_RelEN.ResourceOwner = objRow[convYoungTAppraisedCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvYoungTAppraisedCase_Resource_RelEN.ftpFileType = objRow[convYoungTAppraisedCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvYoungTAppraisedCase_Resource_RelEN.ftpFileSize = objRow[convYoungTAppraisedCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvYoungTAppraisedCase_Resource_RelEN.ftpResourceOwner = objRow[convYoungTAppraisedCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvYoungTAppraisedCase_Resource_RelEN.FileOriginName = objRow[convYoungTAppraisedCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvYoungTAppraisedCase_Resource_RelEN.IsExistFile = TransNullToBool(objRow[convYoungTAppraisedCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvYoungTAppraisedCase_Resource_RelEN.FileNewName = objRow[convYoungTAppraisedCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvYoungTAppraisedCase_Resource_RelEN.FileOldName = objRow[convYoungTAppraisedCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvYoungTAppraisedCase_Resource_RelEN.IsMain = TransNullToBool(objRow[convYoungTAppraisedCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvYoungTAppraisedCase_Resource_RelEN.IdUsingMode = objRow[convYoungTAppraisedCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvYoungTAppraisedCase_Resource_RelEN.IsVisible = TransNullToBool(objRow[convYoungTAppraisedCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvYoungTAppraisedCase_Resource_RelEN.IndexNO = objRow[convYoungTAppraisedCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convYoungTAppraisedCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvYoungTAppraisedCase_Resource_RelEN.BrowseCount = objRow[convYoungTAppraisedCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convYoungTAppraisedCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvYoungTAppraisedCase_Resource_RelEN.UpdDate = objRow[convYoungTAppraisedCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvYoungTAppraisedCase_Resource_RelEN.UpdUser = objRow[convYoungTAppraisedCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvYoungTAppraisedCase_Resource_RelEN.Memo = objRow[convYoungTAppraisedCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvYoungTAppraisedCase_Resource_RelDA: GetObjByDataRowvYoungTAppraisedCase_Resource_Rel)", objException.Message));
}
objvYoungTAppraisedCase_Resource_RelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvYoungTAppraisedCase_Resource_RelEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvYoungTAppraisedCase_Resource_RelEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN = new clsvYoungTAppraisedCase_Resource_RelEN();
try
{
objvYoungTAppraisedCase_Resource_RelEN.IdMicroteachCaseResourceRel = TransNullToInt(objRow[convYoungTAppraisedCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvYoungTAppraisedCase_Resource_RelEN.FuncModuleId = objRow[convYoungTAppraisedCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvYoungTAppraisedCase_Resource_RelEN.FuncModuleName = objRow[convYoungTAppraisedCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvYoungTAppraisedCase_Resource_RelEN.IdMicroteachCase = objRow[convYoungTAppraisedCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvYoungTAppraisedCase_Resource_RelEN.IdYoungTAppraisedCase = objRow[convYoungTAppraisedCase_Resource_Rel.IdYoungTAppraisedCase].ToString().Trim(); //青教评优案例流水号
objvYoungTAppraisedCase_Resource_RelEN.YoungTAppraisedCaseID = objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseID].ToString().Trim(); //青教评优案例ID
objvYoungTAppraisedCase_Resource_RelEN.YoungTAppraisedCaseName = objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseName].ToString().Trim(); //青教评优案例名称
objvYoungTAppraisedCase_Resource_RelEN.YoungTAppraisedCaseText = objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseText] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseText].ToString().Trim(); //案例文本内容
objvYoungTAppraisedCase_Resource_RelEN.YoungTAppraisedCaseDate = objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseDate].ToString().Trim(); //青教评优教学日期
objvYoungTAppraisedCase_Resource_RelEN.YoungTAppraisedCaseTime = objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTime] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTime].ToString().Trim(); //青教评优教学时间
objvYoungTAppraisedCase_Resource_RelEN.YoungTAppraisedCaseTheme = objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTheme] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTheme].ToString().Trim(); //青教评优案例主题词
objvYoungTAppraisedCase_Resource_RelEN.YoungTAppraisedCaseDateIn = objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseDateIn] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseDateIn].ToString().Trim(); //案例入库日期
objvYoungTAppraisedCase_Resource_RelEN.YoungTAppraisedCaseTimeIn = objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTimeIn] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTimeIn].ToString().Trim(); //案例入库时间
objvYoungTAppraisedCase_Resource_RelEN.IdStudyLevel = objRow[convYoungTAppraisedCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvYoungTAppraisedCase_Resource_RelEN.StudyLevelName = objRow[convYoungTAppraisedCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvYoungTAppraisedCase_Resource_RelEN.IdTeachingPlan = objRow[convYoungTAppraisedCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvYoungTAppraisedCase_Resource_RelEN.IdDiscipline = objRow[convYoungTAppraisedCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvYoungTAppraisedCase_Resource_RelEN.DisciplineID = objRow[convYoungTAppraisedCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID
objvYoungTAppraisedCase_Resource_RelEN.DisciplineName = objRow[convYoungTAppraisedCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvYoungTAppraisedCase_Resource_RelEN.senateGaugeVersionID = objRow[convYoungTAppraisedCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvYoungTAppraisedCase_Resource_RelEN.senateGaugeVersionName = objRow[convYoungTAppraisedCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvYoungTAppraisedCase_Resource_RelEN.senateGaugeVersionTtlScore = TransNullToFloat(objRow[convYoungTAppraisedCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvYoungTAppraisedCase_Resource_RelEN.VersionNo = objRow[convYoungTAppraisedCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convYoungTAppraisedCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvYoungTAppraisedCase_Resource_RelEN.IdTeachSkill = objRow[convYoungTAppraisedCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvYoungTAppraisedCase_Resource_RelEN.TeachSkillID = objRow[convYoungTAppraisedCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID
objvYoungTAppraisedCase_Resource_RelEN.SkillTypeName = objRow[convYoungTAppraisedCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称
objvYoungTAppraisedCase_Resource_RelEN.TeachSkillName = objRow[convYoungTAppraisedCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称
objvYoungTAppraisedCase_Resource_RelEN.IdSkillType = objRow[convYoungTAppraisedCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号
objvYoungTAppraisedCase_Resource_RelEN.CaseLevelId = objRow[convYoungTAppraisedCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvYoungTAppraisedCase_Resource_RelEN.OwnerId = objRow[convYoungTAppraisedCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvYoungTAppraisedCase_Resource_RelEN.TeacherID = objRow[convYoungTAppraisedCase_Resource_Rel.TeacherID].ToString().Trim(); //教师工号
objvYoungTAppraisedCase_Resource_RelEN.TeacherName = objRow[convYoungTAppraisedCase_Resource_Rel.TeacherName].ToString().Trim(); //教师姓名
objvYoungTAppraisedCase_Resource_RelEN.CollegeID = objRow[convYoungTAppraisedCase_Resource_Rel.CollegeID].ToString().Trim(); //学院ID
objvYoungTAppraisedCase_Resource_RelEN.CollegeName = objRow[convYoungTAppraisedCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvYoungTAppraisedCase_Resource_RelEN.IdXzCollege = objRow[convYoungTAppraisedCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvYoungTAppraisedCase_Resource_RelEN.EntryDate = objRow[convYoungTAppraisedCase_Resource_Rel.EntryDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.EntryDate].ToString().Trim(); //进校日期
objvYoungTAppraisedCase_Resource_RelEN.IsDualVideo = TransNullToBool(objRow[convYoungTAppraisedCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvYoungTAppraisedCase_Resource_RelEN.UserTypeId = objRow[convYoungTAppraisedCase_Resource_Rel.UserTypeId] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.UserTypeId].ToString().Trim(); //用户类型Id
objvYoungTAppraisedCase_Resource_RelEN.UserTypeName = objRow[convYoungTAppraisedCase_Resource_Rel.UserTypeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.UserTypeName].ToString().Trim(); //用户类型名称
objvYoungTAppraisedCase_Resource_RelEN.RecommendedDegreeId = objRow[convYoungTAppraisedCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvYoungTAppraisedCase_Resource_RelEN.RecommendedDegreeName = objRow[convYoungTAppraisedCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvYoungTAppraisedCase_Resource_RelEN.BrowseCount4Case = objRow[convYoungTAppraisedCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convYoungTAppraisedCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvYoungTAppraisedCase_Resource_RelEN.EntryYear = objRow[convYoungTAppraisedCase_Resource_Rel.EntryYear] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.EntryYear].ToString().Trim(); //EntryYear
objvYoungTAppraisedCase_Resource_RelEN.IdResource = objRow[convYoungTAppraisedCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvYoungTAppraisedCase_Resource_RelEN.ResourceID = objRow[convYoungTAppraisedCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvYoungTAppraisedCase_Resource_RelEN.IdFtpResource = objRow[convYoungTAppraisedCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvYoungTAppraisedCase_Resource_RelEN.IdFile = objRow[convYoungTAppraisedCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvYoungTAppraisedCase_Resource_RelEN.FileName = objRow[convYoungTAppraisedCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvYoungTAppraisedCase_Resource_RelEN.FileType = objRow[convYoungTAppraisedCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvYoungTAppraisedCase_Resource_RelEN.SaveDate = objRow[convYoungTAppraisedCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvYoungTAppraisedCase_Resource_RelEN.FileSize = objRow[convYoungTAppraisedCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvYoungTAppraisedCase_Resource_RelEN.SaveTime = objRow[convYoungTAppraisedCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvYoungTAppraisedCase_Resource_RelEN.FtpResourceID = objRow[convYoungTAppraisedCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvYoungTAppraisedCase_Resource_RelEN.FileOriginalName = objRow[convYoungTAppraisedCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvYoungTAppraisedCase_Resource_RelEN.FileDirName = objRow[convYoungTAppraisedCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvYoungTAppraisedCase_Resource_RelEN.FileRename = objRow[convYoungTAppraisedCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvYoungTAppraisedCase_Resource_RelEN.FileUpDate = objRow[convYoungTAppraisedCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvYoungTAppraisedCase_Resource_RelEN.FileUpTime = objRow[convYoungTAppraisedCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvYoungTAppraisedCase_Resource_RelEN.SaveMode = TransNullToBool(objRow[convYoungTAppraisedCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvYoungTAppraisedCase_Resource_RelEN.IdResourceType = objRow[convYoungTAppraisedCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvYoungTAppraisedCase_Resource_RelEN.ResourceTypeID = objRow[convYoungTAppraisedCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvYoungTAppraisedCase_Resource_RelEN.ResourceTypeName = objRow[convYoungTAppraisedCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvYoungTAppraisedCase_Resource_RelEN.ResourceOwner = objRow[convYoungTAppraisedCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvYoungTAppraisedCase_Resource_RelEN.ftpFileType = objRow[convYoungTAppraisedCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvYoungTAppraisedCase_Resource_RelEN.ftpFileSize = objRow[convYoungTAppraisedCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvYoungTAppraisedCase_Resource_RelEN.ftpResourceOwner = objRow[convYoungTAppraisedCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvYoungTAppraisedCase_Resource_RelEN.FileOriginName = objRow[convYoungTAppraisedCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvYoungTAppraisedCase_Resource_RelEN.IsExistFile = TransNullToBool(objRow[convYoungTAppraisedCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvYoungTAppraisedCase_Resource_RelEN.FileNewName = objRow[convYoungTAppraisedCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvYoungTAppraisedCase_Resource_RelEN.FileOldName = objRow[convYoungTAppraisedCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvYoungTAppraisedCase_Resource_RelEN.IsMain = TransNullToBool(objRow[convYoungTAppraisedCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvYoungTAppraisedCase_Resource_RelEN.IdUsingMode = objRow[convYoungTAppraisedCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvYoungTAppraisedCase_Resource_RelEN.IsVisible = TransNullToBool(objRow[convYoungTAppraisedCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvYoungTAppraisedCase_Resource_RelEN.IndexNO = objRow[convYoungTAppraisedCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convYoungTAppraisedCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvYoungTAppraisedCase_Resource_RelEN.BrowseCount = objRow[convYoungTAppraisedCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convYoungTAppraisedCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvYoungTAppraisedCase_Resource_RelEN.UpdDate = objRow[convYoungTAppraisedCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvYoungTAppraisedCase_Resource_RelEN.UpdUser = objRow[convYoungTAppraisedCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvYoungTAppraisedCase_Resource_RelEN.Memo = objRow[convYoungTAppraisedCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convYoungTAppraisedCase_Resource_Rel.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvYoungTAppraisedCase_Resource_RelDA: GetObjByDataRow)", objException.Message));
}
objvYoungTAppraisedCase_Resource_RelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvYoungTAppraisedCase_Resource_RelEN;
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
objSQL = clsvYoungTAppraisedCase_Resource_RelDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvYoungTAppraisedCase_Resource_RelEN._CurrTabName, convYoungTAppraisedCase_Resource_Rel.IdMicroteachCaseResourceRel, 8, "");
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
objSQL = clsvYoungTAppraisedCase_Resource_RelDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvYoungTAppraisedCase_Resource_RelEN._CurrTabName, convYoungTAppraisedCase_Resource_Rel.IdMicroteachCaseResourceRel, 8, strPrefix);
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
 objSQL = clsvYoungTAppraisedCase_Resource_RelDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdMicroteachCaseResourceRel from vYoungTAppraisedCase_Resource_Rel where " + strCondition;
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
 objSQL = clsvYoungTAppraisedCase_Resource_RelDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdMicroteachCaseResourceRel from vYoungTAppraisedCase_Resource_Rel where " + strCondition;
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
 /// <param name = "lngIdMicroteachCaseResourceRel">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngIdMicroteachCaseResourceRel)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCase_Resource_RelDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vYoungTAppraisedCase_Resource_Rel", "IdMicroteachCaseResourceRel = " + ""+ lngIdMicroteachCaseResourceRel+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvYoungTAppraisedCase_Resource_RelDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCase_Resource_RelDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vYoungTAppraisedCase_Resource_Rel", strCondition))
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
objSQL = clsvYoungTAppraisedCase_Resource_RelDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vYoungTAppraisedCase_Resource_Rel");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelENS">源对象</param>
 /// <param name = "objvYoungTAppraisedCase_Resource_RelENT">目标对象</param>
public void CopyTo(clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelENS, clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelENT)
{
objvYoungTAppraisedCase_Resource_RelENT.IdMicroteachCaseResourceRel = objvYoungTAppraisedCase_Resource_RelENS.IdMicroteachCaseResourceRel; //微格案例资源关系流水号
objvYoungTAppraisedCase_Resource_RelENT.FuncModuleId = objvYoungTAppraisedCase_Resource_RelENS.FuncModuleId; //功能模块Id
objvYoungTAppraisedCase_Resource_RelENT.FuncModuleName = objvYoungTAppraisedCase_Resource_RelENS.FuncModuleName; //功能模块名称
objvYoungTAppraisedCase_Resource_RelENT.IdMicroteachCase = objvYoungTAppraisedCase_Resource_RelENS.IdMicroteachCase; //微格教学案例流水号
objvYoungTAppraisedCase_Resource_RelENT.IdYoungTAppraisedCase = objvYoungTAppraisedCase_Resource_RelENS.IdYoungTAppraisedCase; //青教评优案例流水号
objvYoungTAppraisedCase_Resource_RelENT.YoungTAppraisedCaseID = objvYoungTAppraisedCase_Resource_RelENS.YoungTAppraisedCaseID; //青教评优案例ID
objvYoungTAppraisedCase_Resource_RelENT.YoungTAppraisedCaseName = objvYoungTAppraisedCase_Resource_RelENS.YoungTAppraisedCaseName; //青教评优案例名称
objvYoungTAppraisedCase_Resource_RelENT.YoungTAppraisedCaseText = objvYoungTAppraisedCase_Resource_RelENS.YoungTAppraisedCaseText; //案例文本内容
objvYoungTAppraisedCase_Resource_RelENT.YoungTAppraisedCaseDate = objvYoungTAppraisedCase_Resource_RelENS.YoungTAppraisedCaseDate; //青教评优教学日期
objvYoungTAppraisedCase_Resource_RelENT.YoungTAppraisedCaseTime = objvYoungTAppraisedCase_Resource_RelENS.YoungTAppraisedCaseTime; //青教评优教学时间
objvYoungTAppraisedCase_Resource_RelENT.YoungTAppraisedCaseTheme = objvYoungTAppraisedCase_Resource_RelENS.YoungTAppraisedCaseTheme; //青教评优案例主题词
objvYoungTAppraisedCase_Resource_RelENT.YoungTAppraisedCaseDateIn = objvYoungTAppraisedCase_Resource_RelENS.YoungTAppraisedCaseDateIn; //案例入库日期
objvYoungTAppraisedCase_Resource_RelENT.YoungTAppraisedCaseTimeIn = objvYoungTAppraisedCase_Resource_RelENS.YoungTAppraisedCaseTimeIn; //案例入库时间
objvYoungTAppraisedCase_Resource_RelENT.IdStudyLevel = objvYoungTAppraisedCase_Resource_RelENS.IdStudyLevel; //id_StudyLevel
objvYoungTAppraisedCase_Resource_RelENT.StudyLevelName = objvYoungTAppraisedCase_Resource_RelENS.StudyLevelName; //学段名称
objvYoungTAppraisedCase_Resource_RelENT.IdTeachingPlan = objvYoungTAppraisedCase_Resource_RelENS.IdTeachingPlan; //教案流水号
objvYoungTAppraisedCase_Resource_RelENT.IdDiscipline = objvYoungTAppraisedCase_Resource_RelENS.IdDiscipline; //学科流水号
objvYoungTAppraisedCase_Resource_RelENT.DisciplineID = objvYoungTAppraisedCase_Resource_RelENS.DisciplineID; //学科ID
objvYoungTAppraisedCase_Resource_RelENT.DisciplineName = objvYoungTAppraisedCase_Resource_RelENS.DisciplineName; //学科名称
objvYoungTAppraisedCase_Resource_RelENT.senateGaugeVersionID = objvYoungTAppraisedCase_Resource_RelENS.senateGaugeVersionID; //评价量表版本ID
objvYoungTAppraisedCase_Resource_RelENT.senateGaugeVersionName = objvYoungTAppraisedCase_Resource_RelENS.senateGaugeVersionName; //评价量表版本名称
objvYoungTAppraisedCase_Resource_RelENT.senateGaugeVersionTtlScore = objvYoungTAppraisedCase_Resource_RelENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvYoungTAppraisedCase_Resource_RelENT.VersionNo = objvYoungTAppraisedCase_Resource_RelENS.VersionNo; //版本号
objvYoungTAppraisedCase_Resource_RelENT.IdTeachSkill = objvYoungTAppraisedCase_Resource_RelENS.IdTeachSkill; //教学技能流水号
objvYoungTAppraisedCase_Resource_RelENT.TeachSkillID = objvYoungTAppraisedCase_Resource_RelENS.TeachSkillID; //教学技能ID
objvYoungTAppraisedCase_Resource_RelENT.SkillTypeName = objvYoungTAppraisedCase_Resource_RelENS.SkillTypeName; //技能类型名称
objvYoungTAppraisedCase_Resource_RelENT.TeachSkillName = objvYoungTAppraisedCase_Resource_RelENS.TeachSkillName; //教学技能名称
objvYoungTAppraisedCase_Resource_RelENT.IdSkillType = objvYoungTAppraisedCase_Resource_RelENS.IdSkillType; //技能类型流水号
objvYoungTAppraisedCase_Resource_RelENT.CaseLevelId = objvYoungTAppraisedCase_Resource_RelENS.CaseLevelId; //课例等级Id
objvYoungTAppraisedCase_Resource_RelENT.OwnerId = objvYoungTAppraisedCase_Resource_RelENS.OwnerId; //拥有者Id
objvYoungTAppraisedCase_Resource_RelENT.TeacherID = objvYoungTAppraisedCase_Resource_RelENS.TeacherID; //教师工号
objvYoungTAppraisedCase_Resource_RelENT.TeacherName = objvYoungTAppraisedCase_Resource_RelENS.TeacherName; //教师姓名
objvYoungTAppraisedCase_Resource_RelENT.CollegeID = objvYoungTAppraisedCase_Resource_RelENS.CollegeID; //学院ID
objvYoungTAppraisedCase_Resource_RelENT.CollegeName = objvYoungTAppraisedCase_Resource_RelENS.CollegeName; //学院名称
objvYoungTAppraisedCase_Resource_RelENT.IdXzCollege = objvYoungTAppraisedCase_Resource_RelENS.IdXzCollege; //学院流水号
objvYoungTAppraisedCase_Resource_RelENT.EntryDate = objvYoungTAppraisedCase_Resource_RelENS.EntryDate; //进校日期
objvYoungTAppraisedCase_Resource_RelENT.IsDualVideo = objvYoungTAppraisedCase_Resource_RelENS.IsDualVideo; //是否双视频
objvYoungTAppraisedCase_Resource_RelENT.UserTypeId = objvYoungTAppraisedCase_Resource_RelENS.UserTypeId; //用户类型Id
objvYoungTAppraisedCase_Resource_RelENT.UserTypeName = objvYoungTAppraisedCase_Resource_RelENS.UserTypeName; //用户类型名称
objvYoungTAppraisedCase_Resource_RelENT.RecommendedDegreeId = objvYoungTAppraisedCase_Resource_RelENS.RecommendedDegreeId; //推荐度Id
objvYoungTAppraisedCase_Resource_RelENT.RecommendedDegreeName = objvYoungTAppraisedCase_Resource_RelENS.RecommendedDegreeName; //推荐度名称
objvYoungTAppraisedCase_Resource_RelENT.BrowseCount4Case = objvYoungTAppraisedCase_Resource_RelENS.BrowseCount4Case; //课例浏览次数
objvYoungTAppraisedCase_Resource_RelENT.EntryYear = objvYoungTAppraisedCase_Resource_RelENS.EntryYear; //EntryYear
objvYoungTAppraisedCase_Resource_RelENT.IdResource = objvYoungTAppraisedCase_Resource_RelENS.IdResource; //资源流水号
objvYoungTAppraisedCase_Resource_RelENT.ResourceID = objvYoungTAppraisedCase_Resource_RelENS.ResourceID; //资源ID
objvYoungTAppraisedCase_Resource_RelENT.IdFtpResource = objvYoungTAppraisedCase_Resource_RelENS.IdFtpResource; //FTP资源流水号
objvYoungTAppraisedCase_Resource_RelENT.IdFile = objvYoungTAppraisedCase_Resource_RelENS.IdFile; //文件流水号
objvYoungTAppraisedCase_Resource_RelENT.FileName = objvYoungTAppraisedCase_Resource_RelENS.FileName; //文件名称
objvYoungTAppraisedCase_Resource_RelENT.FileType = objvYoungTAppraisedCase_Resource_RelENS.FileType; //文件类型
objvYoungTAppraisedCase_Resource_RelENT.SaveDate = objvYoungTAppraisedCase_Resource_RelENS.SaveDate; //创建日期
objvYoungTAppraisedCase_Resource_RelENT.FileSize = objvYoungTAppraisedCase_Resource_RelENS.FileSize; //文件大小
objvYoungTAppraisedCase_Resource_RelENT.SaveTime = objvYoungTAppraisedCase_Resource_RelENS.SaveTime; //创建时间
objvYoungTAppraisedCase_Resource_RelENT.FtpResourceID = objvYoungTAppraisedCase_Resource_RelENS.FtpResourceID; //FTP资源ID
objvYoungTAppraisedCase_Resource_RelENT.FileOriginalName = objvYoungTAppraisedCase_Resource_RelENS.FileOriginalName; //文件原名
objvYoungTAppraisedCase_Resource_RelENT.FileDirName = objvYoungTAppraisedCase_Resource_RelENS.FileDirName; //文件目录名
objvYoungTAppraisedCase_Resource_RelENT.FileRename = objvYoungTAppraisedCase_Resource_RelENS.FileRename; //文件新名
objvYoungTAppraisedCase_Resource_RelENT.FileUpDate = objvYoungTAppraisedCase_Resource_RelENS.FileUpDate; //创建日期
objvYoungTAppraisedCase_Resource_RelENT.FileUpTime = objvYoungTAppraisedCase_Resource_RelENS.FileUpTime; //创建时间
objvYoungTAppraisedCase_Resource_RelENT.SaveMode = objvYoungTAppraisedCase_Resource_RelENS.SaveMode; //文件存放方式
objvYoungTAppraisedCase_Resource_RelENT.IdResourceType = objvYoungTAppraisedCase_Resource_RelENS.IdResourceType; //资源类型流水号
objvYoungTAppraisedCase_Resource_RelENT.ResourceTypeID = objvYoungTAppraisedCase_Resource_RelENS.ResourceTypeID; //资源类型ID
objvYoungTAppraisedCase_Resource_RelENT.ResourceTypeName = objvYoungTAppraisedCase_Resource_RelENS.ResourceTypeName; //资源类型名称
objvYoungTAppraisedCase_Resource_RelENT.ResourceOwner = objvYoungTAppraisedCase_Resource_RelENS.ResourceOwner; //上传者
objvYoungTAppraisedCase_Resource_RelENT.ftpFileType = objvYoungTAppraisedCase_Resource_RelENS.ftpFileType; //ftp文件类型
objvYoungTAppraisedCase_Resource_RelENT.ftpFileSize = objvYoungTAppraisedCase_Resource_RelENS.ftpFileSize; //ftp文件大小
objvYoungTAppraisedCase_Resource_RelENT.ftpResourceOwner = objvYoungTAppraisedCase_Resource_RelENS.ftpResourceOwner; //Ftp资源拥有者
objvYoungTAppraisedCase_Resource_RelENT.FileOriginName = objvYoungTAppraisedCase_Resource_RelENS.FileOriginName; //原文件名
objvYoungTAppraisedCase_Resource_RelENT.IsExistFile = objvYoungTAppraisedCase_Resource_RelENS.IsExistFile; //是否存在文件
objvYoungTAppraisedCase_Resource_RelENT.FileNewName = objvYoungTAppraisedCase_Resource_RelENS.FileNewName; //新文件名
objvYoungTAppraisedCase_Resource_RelENT.FileOldName = objvYoungTAppraisedCase_Resource_RelENS.FileOldName; //旧文件名
objvYoungTAppraisedCase_Resource_RelENT.IsMain = objvYoungTAppraisedCase_Resource_RelENS.IsMain; //是否主资源
objvYoungTAppraisedCase_Resource_RelENT.IdUsingMode = objvYoungTAppraisedCase_Resource_RelENS.IdUsingMode; //资源使用模式流水号
objvYoungTAppraisedCase_Resource_RelENT.IsVisible = objvYoungTAppraisedCase_Resource_RelENS.IsVisible; //是否显示
objvYoungTAppraisedCase_Resource_RelENT.IndexNO = objvYoungTAppraisedCase_Resource_RelENS.IndexNO; //序号
objvYoungTAppraisedCase_Resource_RelENT.BrowseCount = objvYoungTAppraisedCase_Resource_RelENS.BrowseCount; //浏览次数
objvYoungTAppraisedCase_Resource_RelENT.UpdDate = objvYoungTAppraisedCase_Resource_RelENS.UpdDate; //修改日期
objvYoungTAppraisedCase_Resource_RelENT.UpdUser = objvYoungTAppraisedCase_Resource_RelENS.UpdUser; //修改人
objvYoungTAppraisedCase_Resource_RelENT.Memo = objvYoungTAppraisedCase_Resource_RelENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvYoungTAppraisedCase_Resource_RelEN objvYoungTAppraisedCase_Resource_RelEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_Resource_RelEN.FuncModuleId, 4, convYoungTAppraisedCase_Resource_Rel.FuncModuleId);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_Resource_RelEN.FuncModuleName, 30, convYoungTAppraisedCase_Resource_Rel.FuncModuleName);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_Resource_RelEN.IdMicroteachCase, 8, convYoungTAppraisedCase_Resource_Rel.IdMicroteachCase);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_Resource_RelEN.IdYoungTAppraisedCase, 8, convYoungTAppraisedCase_Resource_Rel.IdYoungTAppraisedCase);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_Resource_RelEN.YoungTAppraisedCaseID, 8, convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseID);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_Resource_RelEN.YoungTAppraisedCaseName, 100, convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseName);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_Resource_RelEN.YoungTAppraisedCaseText, 8000, convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseText);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_Resource_RelEN.YoungTAppraisedCaseDate, 8, convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseDate);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_Resource_RelEN.YoungTAppraisedCaseTime, 6, convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTime);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_Resource_RelEN.YoungTAppraisedCaseTheme, 200, convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTheme);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_Resource_RelEN.YoungTAppraisedCaseDateIn, 8, convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseDateIn);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_Resource_RelEN.YoungTAppraisedCaseTimeIn, 6, convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTimeIn);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_Resource_RelEN.IdStudyLevel, 4, convYoungTAppraisedCase_Resource_Rel.IdStudyLevel);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_Resource_RelEN.StudyLevelName, 50, convYoungTAppraisedCase_Resource_Rel.StudyLevelName);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_Resource_RelEN.IdTeachingPlan, 8, convYoungTAppraisedCase_Resource_Rel.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_Resource_RelEN.IdDiscipline, 4, convYoungTAppraisedCase_Resource_Rel.IdDiscipline);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_Resource_RelEN.DisciplineID, 4, convYoungTAppraisedCase_Resource_Rel.DisciplineID);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_Resource_RelEN.DisciplineName, 50, convYoungTAppraisedCase_Resource_Rel.DisciplineName);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_Resource_RelEN.senateGaugeVersionID, 4, convYoungTAppraisedCase_Resource_Rel.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_Resource_RelEN.senateGaugeVersionName, 200, convYoungTAppraisedCase_Resource_Rel.senateGaugeVersionName);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_Resource_RelEN.IdTeachSkill, 8, convYoungTAppraisedCase_Resource_Rel.IdTeachSkill);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_Resource_RelEN.TeachSkillID, 8, convYoungTAppraisedCase_Resource_Rel.TeachSkillID);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_Resource_RelEN.SkillTypeName, 50, convYoungTAppraisedCase_Resource_Rel.SkillTypeName);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_Resource_RelEN.TeachSkillName, 50, convYoungTAppraisedCase_Resource_Rel.TeachSkillName);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_Resource_RelEN.IdSkillType, 4, convYoungTAppraisedCase_Resource_Rel.IdSkillType);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_Resource_RelEN.CaseLevelId, 2, convYoungTAppraisedCase_Resource_Rel.CaseLevelId);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_Resource_RelEN.OwnerId, 20, convYoungTAppraisedCase_Resource_Rel.OwnerId);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_Resource_RelEN.TeacherID, 12, convYoungTAppraisedCase_Resource_Rel.TeacherID);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_Resource_RelEN.TeacherName, 50, convYoungTAppraisedCase_Resource_Rel.TeacherName);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_Resource_RelEN.CollegeID, 4, convYoungTAppraisedCase_Resource_Rel.CollegeID);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_Resource_RelEN.CollegeName, 100, convYoungTAppraisedCase_Resource_Rel.CollegeName);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_Resource_RelEN.IdXzCollege, 4, convYoungTAppraisedCase_Resource_Rel.IdXzCollege);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_Resource_RelEN.EntryDate, 8, convYoungTAppraisedCase_Resource_Rel.EntryDate);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_Resource_RelEN.UserTypeId, 2, convYoungTAppraisedCase_Resource_Rel.UserTypeId);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_Resource_RelEN.UserTypeName, 20, convYoungTAppraisedCase_Resource_Rel.UserTypeName);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_Resource_RelEN.RecommendedDegreeId, 2, convYoungTAppraisedCase_Resource_Rel.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_Resource_RelEN.RecommendedDegreeName, 30, convYoungTAppraisedCase_Resource_Rel.RecommendedDegreeName);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_Resource_RelEN.EntryYear, 8, convYoungTAppraisedCase_Resource_Rel.EntryYear);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_Resource_RelEN.IdResource, 8, convYoungTAppraisedCase_Resource_Rel.IdResource);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_Resource_RelEN.ResourceID, 8, convYoungTAppraisedCase_Resource_Rel.ResourceID);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_Resource_RelEN.IdFtpResource, 8, convYoungTAppraisedCase_Resource_Rel.IdFtpResource);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_Resource_RelEN.IdFile, 8, convYoungTAppraisedCase_Resource_Rel.IdFile);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_Resource_RelEN.FileName, 500, convYoungTAppraisedCase_Resource_Rel.FileName);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_Resource_RelEN.FileType, 30, convYoungTAppraisedCase_Resource_Rel.FileType);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_Resource_RelEN.SaveDate, 8, convYoungTAppraisedCase_Resource_Rel.SaveDate);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_Resource_RelEN.FileSize, 50, convYoungTAppraisedCase_Resource_Rel.FileSize);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_Resource_RelEN.SaveTime, 6, convYoungTAppraisedCase_Resource_Rel.SaveTime);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_Resource_RelEN.FtpResourceID, 8, convYoungTAppraisedCase_Resource_Rel.FtpResourceID);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_Resource_RelEN.FileOriginalName, 200, convYoungTAppraisedCase_Resource_Rel.FileOriginalName);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_Resource_RelEN.FileDirName, 200, convYoungTAppraisedCase_Resource_Rel.FileDirName);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_Resource_RelEN.FileRename, 200, convYoungTAppraisedCase_Resource_Rel.FileRename);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_Resource_RelEN.FileUpDate, 8, convYoungTAppraisedCase_Resource_Rel.FileUpDate);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_Resource_RelEN.FileUpTime, 6, convYoungTAppraisedCase_Resource_Rel.FileUpTime);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_Resource_RelEN.IdResourceType, 4, convYoungTAppraisedCase_Resource_Rel.IdResourceType);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_Resource_RelEN.ResourceTypeID, 4, convYoungTAppraisedCase_Resource_Rel.ResourceTypeID);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_Resource_RelEN.ResourceTypeName, 50, convYoungTAppraisedCase_Resource_Rel.ResourceTypeName);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_Resource_RelEN.ResourceOwner, 50, convYoungTAppraisedCase_Resource_Rel.ResourceOwner);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_Resource_RelEN.ftpFileType, 30, convYoungTAppraisedCase_Resource_Rel.ftpFileType);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_Resource_RelEN.ftpFileSize, 50, convYoungTAppraisedCase_Resource_Rel.ftpFileSize);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_Resource_RelEN.ftpResourceOwner, 50, convYoungTAppraisedCase_Resource_Rel.ftpResourceOwner);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_Resource_RelEN.FileOriginName, 500, convYoungTAppraisedCase_Resource_Rel.FileOriginName);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_Resource_RelEN.FileNewName, 530, convYoungTAppraisedCase_Resource_Rel.FileNewName);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_Resource_RelEN.FileOldName, 530, convYoungTAppraisedCase_Resource_Rel.FileOldName);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_Resource_RelEN.IdUsingMode, 4, convYoungTAppraisedCase_Resource_Rel.IdUsingMode);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_Resource_RelEN.UpdDate, 20, convYoungTAppraisedCase_Resource_Rel.UpdDate);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_Resource_RelEN.UpdUser, 20, convYoungTAppraisedCase_Resource_Rel.UpdUser);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCase_Resource_RelEN.Memo, 1000, convYoungTAppraisedCase_Resource_Rel.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_Resource_RelEN.FuncModuleId, convYoungTAppraisedCase_Resource_Rel.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_Resource_RelEN.FuncModuleName, convYoungTAppraisedCase_Resource_Rel.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_Resource_RelEN.IdMicroteachCase, convYoungTAppraisedCase_Resource_Rel.IdMicroteachCase);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_Resource_RelEN.IdYoungTAppraisedCase, convYoungTAppraisedCase_Resource_Rel.IdYoungTAppraisedCase);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_Resource_RelEN.YoungTAppraisedCaseID, convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseID);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_Resource_RelEN.YoungTAppraisedCaseName, convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseName);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_Resource_RelEN.YoungTAppraisedCaseText, convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseText);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_Resource_RelEN.YoungTAppraisedCaseDate, convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseDate);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_Resource_RelEN.YoungTAppraisedCaseTime, convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTime);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_Resource_RelEN.YoungTAppraisedCaseTheme, convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTheme);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_Resource_RelEN.YoungTAppraisedCaseDateIn, convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseDateIn);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_Resource_RelEN.YoungTAppraisedCaseTimeIn, convYoungTAppraisedCase_Resource_Rel.YoungTAppraisedCaseTimeIn);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_Resource_RelEN.IdStudyLevel, convYoungTAppraisedCase_Resource_Rel.IdStudyLevel);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_Resource_RelEN.StudyLevelName, convYoungTAppraisedCase_Resource_Rel.StudyLevelName);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_Resource_RelEN.IdTeachingPlan, convYoungTAppraisedCase_Resource_Rel.IdTeachingPlan);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_Resource_RelEN.IdDiscipline, convYoungTAppraisedCase_Resource_Rel.IdDiscipline);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_Resource_RelEN.DisciplineID, convYoungTAppraisedCase_Resource_Rel.DisciplineID);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_Resource_RelEN.DisciplineName, convYoungTAppraisedCase_Resource_Rel.DisciplineName);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_Resource_RelEN.senateGaugeVersionID, convYoungTAppraisedCase_Resource_Rel.senateGaugeVersionID);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_Resource_RelEN.senateGaugeVersionName, convYoungTAppraisedCase_Resource_Rel.senateGaugeVersionName);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_Resource_RelEN.IdTeachSkill, convYoungTAppraisedCase_Resource_Rel.IdTeachSkill);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_Resource_RelEN.TeachSkillID, convYoungTAppraisedCase_Resource_Rel.TeachSkillID);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_Resource_RelEN.SkillTypeName, convYoungTAppraisedCase_Resource_Rel.SkillTypeName);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_Resource_RelEN.TeachSkillName, convYoungTAppraisedCase_Resource_Rel.TeachSkillName);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_Resource_RelEN.IdSkillType, convYoungTAppraisedCase_Resource_Rel.IdSkillType);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_Resource_RelEN.CaseLevelId, convYoungTAppraisedCase_Resource_Rel.CaseLevelId);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_Resource_RelEN.OwnerId, convYoungTAppraisedCase_Resource_Rel.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_Resource_RelEN.TeacherID, convYoungTAppraisedCase_Resource_Rel.TeacherID);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_Resource_RelEN.TeacherName, convYoungTAppraisedCase_Resource_Rel.TeacherName);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_Resource_RelEN.CollegeID, convYoungTAppraisedCase_Resource_Rel.CollegeID);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_Resource_RelEN.CollegeName, convYoungTAppraisedCase_Resource_Rel.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_Resource_RelEN.IdXzCollege, convYoungTAppraisedCase_Resource_Rel.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_Resource_RelEN.EntryDate, convYoungTAppraisedCase_Resource_Rel.EntryDate);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_Resource_RelEN.UserTypeId, convYoungTAppraisedCase_Resource_Rel.UserTypeId);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_Resource_RelEN.UserTypeName, convYoungTAppraisedCase_Resource_Rel.UserTypeName);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_Resource_RelEN.RecommendedDegreeId, convYoungTAppraisedCase_Resource_Rel.RecommendedDegreeId);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_Resource_RelEN.RecommendedDegreeName, convYoungTAppraisedCase_Resource_Rel.RecommendedDegreeName);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_Resource_RelEN.EntryYear, convYoungTAppraisedCase_Resource_Rel.EntryYear);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_Resource_RelEN.IdResource, convYoungTAppraisedCase_Resource_Rel.IdResource);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_Resource_RelEN.ResourceID, convYoungTAppraisedCase_Resource_Rel.ResourceID);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_Resource_RelEN.IdFtpResource, convYoungTAppraisedCase_Resource_Rel.IdFtpResource);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_Resource_RelEN.IdFile, convYoungTAppraisedCase_Resource_Rel.IdFile);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_Resource_RelEN.FileName, convYoungTAppraisedCase_Resource_Rel.FileName);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_Resource_RelEN.FileType, convYoungTAppraisedCase_Resource_Rel.FileType);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_Resource_RelEN.SaveDate, convYoungTAppraisedCase_Resource_Rel.SaveDate);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_Resource_RelEN.FileSize, convYoungTAppraisedCase_Resource_Rel.FileSize);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_Resource_RelEN.SaveTime, convYoungTAppraisedCase_Resource_Rel.SaveTime);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_Resource_RelEN.FtpResourceID, convYoungTAppraisedCase_Resource_Rel.FtpResourceID);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_Resource_RelEN.FileOriginalName, convYoungTAppraisedCase_Resource_Rel.FileOriginalName);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_Resource_RelEN.FileDirName, convYoungTAppraisedCase_Resource_Rel.FileDirName);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_Resource_RelEN.FileRename, convYoungTAppraisedCase_Resource_Rel.FileRename);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_Resource_RelEN.FileUpDate, convYoungTAppraisedCase_Resource_Rel.FileUpDate);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_Resource_RelEN.FileUpTime, convYoungTAppraisedCase_Resource_Rel.FileUpTime);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_Resource_RelEN.IdResourceType, convYoungTAppraisedCase_Resource_Rel.IdResourceType);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_Resource_RelEN.ResourceTypeID, convYoungTAppraisedCase_Resource_Rel.ResourceTypeID);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_Resource_RelEN.ResourceTypeName, convYoungTAppraisedCase_Resource_Rel.ResourceTypeName);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_Resource_RelEN.ResourceOwner, convYoungTAppraisedCase_Resource_Rel.ResourceOwner);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_Resource_RelEN.ftpFileType, convYoungTAppraisedCase_Resource_Rel.ftpFileType);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_Resource_RelEN.ftpFileSize, convYoungTAppraisedCase_Resource_Rel.ftpFileSize);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_Resource_RelEN.ftpResourceOwner, convYoungTAppraisedCase_Resource_Rel.ftpResourceOwner);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_Resource_RelEN.FileOriginName, convYoungTAppraisedCase_Resource_Rel.FileOriginName);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_Resource_RelEN.FileNewName, convYoungTAppraisedCase_Resource_Rel.FileNewName);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_Resource_RelEN.FileOldName, convYoungTAppraisedCase_Resource_Rel.FileOldName);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_Resource_RelEN.IdUsingMode, convYoungTAppraisedCase_Resource_Rel.IdUsingMode);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_Resource_RelEN.UpdDate, convYoungTAppraisedCase_Resource_Rel.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_Resource_RelEN.UpdUser, convYoungTAppraisedCase_Resource_Rel.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCase_Resource_RelEN.Memo, convYoungTAppraisedCase_Resource_Rel.Memo);
//检查外键字段长度
 objvYoungTAppraisedCase_Resource_RelEN._IsCheckProperty = true;
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
 objSQL = clsvYoungTAppraisedCase_Resource_RelDA.GetSpecSQLObj();
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
 objSQL = clsvYoungTAppraisedCase_Resource_RelDA.GetSpecSQLObj();
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
 objSQL = clsvYoungTAppraisedCase_Resource_RelDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvYoungTAppraisedCase_Resource_RelEN._CurrTabName);
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
 objSQL = clsvYoungTAppraisedCase_Resource_RelDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvYoungTAppraisedCase_Resource_RelEN._CurrTabName, strCondition);
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
 objSQL = clsvYoungTAppraisedCase_Resource_RelDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}