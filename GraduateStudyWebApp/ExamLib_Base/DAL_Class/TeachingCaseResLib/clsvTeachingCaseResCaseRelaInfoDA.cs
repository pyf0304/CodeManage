
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTeachingCaseResCaseRelaInfoDA
 表名:vTeachingCaseResCaseRelaInfo(01120394)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:50:10
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:教学案例资源(TeachingCaseResLib)
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
 /// v教学案例资源案例相关信息(vTeachingCaseResCaseRelaInfo)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvTeachingCaseResCaseRelaInfoDA : clsCommBase4DA
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
 return clsvTeachingCaseResCaseRelaInfoEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvTeachingCaseResCaseRelaInfoEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvTeachingCaseResCaseRelaInfoEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvTeachingCaseResCaseRelaInfoEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvTeachingCaseResCaseRelaInfoEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvTeachingCaseResCaseRelaInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingCaseResCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vTeachingCaseResCaseRelaInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vTeachingCaseResCaseRelaInfo(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvTeachingCaseResCaseRelaInfoDA: GetDataTable_vTeachingCaseResCaseRelaInfo)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingCaseResCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vTeachingCaseResCaseRelaInfo where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvTeachingCaseResCaseRelaInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingCaseResCaseRelaInfoDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvTeachingCaseResCaseRelaInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingCaseResCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vTeachingCaseResCaseRelaInfo where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvTeachingCaseResCaseRelaInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingCaseResCaseRelaInfoDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvTeachingCaseResCaseRelaInfoDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingCaseResCaseRelaInfoDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vTeachingCaseResCaseRelaInfo where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vTeachingCaseResCaseRelaInfo where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvTeachingCaseResCaseRelaInfoDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingCaseResCaseRelaInfoDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vTeachingCaseResCaseRelaInfo where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvTeachingCaseResCaseRelaInfoDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingCaseResCaseRelaInfoDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vTeachingCaseResCaseRelaInfo.* from vTeachingCaseResCaseRelaInfo Left Join {1} on {2} where {3} and vTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfo not in (Select top {5} vTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfo from vTeachingCaseResCaseRelaInfo Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vTeachingCaseResCaseRelaInfo where {1} and IdMicroTeachCaseRelaInfo not in (Select top {2} IdMicroTeachCaseRelaInfo from vTeachingCaseResCaseRelaInfo where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vTeachingCaseResCaseRelaInfo where {1} and IdMicroTeachCaseRelaInfo not in (Select top {3} IdMicroTeachCaseRelaInfo from vTeachingCaseResCaseRelaInfo where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvTeachingCaseResCaseRelaInfoDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingCaseResCaseRelaInfoDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vTeachingCaseResCaseRelaInfo.* from vTeachingCaseResCaseRelaInfo Left Join {1} on {2} where {3} and vTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfo not in (Select top {5} vTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfo from vTeachingCaseResCaseRelaInfo Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vTeachingCaseResCaseRelaInfo where {1} and IdMicroTeachCaseRelaInfo not in (Select top {2} IdMicroTeachCaseRelaInfo from vTeachingCaseResCaseRelaInfo where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vTeachingCaseResCaseRelaInfo where {1} and IdMicroTeachCaseRelaInfo not in (Select top {3} IdMicroTeachCaseRelaInfo from vTeachingCaseResCaseRelaInfo where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvTeachingCaseResCaseRelaInfoEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvTeachingCaseResCaseRelaInfoDA:GetObjLst)", objException.Message));
}
List<clsvTeachingCaseResCaseRelaInfoEN> arrObjLst = new List<clsvTeachingCaseResCaseRelaInfoEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingCaseResCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vTeachingCaseResCaseRelaInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN = new clsvTeachingCaseResCaseRelaInfoEN();
try
{
objvTeachingCaseResCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = TransNullToInt(objRow[convTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvTeachingCaseResCaseRelaInfoEN.FuncModuleId = objRow[convTeachingCaseResCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvTeachingCaseResCaseRelaInfoEN.FuncModuleName = objRow[convTeachingCaseResCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvTeachingCaseResCaseRelaInfoEN.IdMicroteachCase = objRow[convTeachingCaseResCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvTeachingCaseResCaseRelaInfoEN.IdTeachingCaseResCase = objRow[convTeachingCaseResCaseRelaInfo.IdTeachingCaseResCase] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号
objvTeachingCaseResCaseRelaInfoEN.TeachingCaseResCaseName = objRow[convTeachingCaseResCaseRelaInfo.TeachingCaseResCaseName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objvTeachingCaseResCaseRelaInfoEN.IdXzCollege = objRow[convTeachingCaseResCaseRelaInfo.IdXzCollege] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingCaseResCaseRelaInfoEN.CollegeID = objRow[convTeachingCaseResCaseRelaInfo.CollegeID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CollegeID].ToString().Trim(); //学院ID
objvTeachingCaseResCaseRelaInfoEN.CollegeName = objRow[convTeachingCaseResCaseRelaInfo.CollegeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CollegeName].ToString().Trim(); //学院名称
objvTeachingCaseResCaseRelaInfoEN.CollegeNameA = objRow[convTeachingCaseResCaseRelaInfo.CollegeNameA] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachingCaseResCaseRelaInfoEN.MajorID = objRow[convTeachingCaseResCaseRelaInfo.MajorID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.MajorID].ToString().Trim(); //专业ID
objvTeachingCaseResCaseRelaInfoEN.MajorName = objRow[convTeachingCaseResCaseRelaInfo.MajorName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.MajorName].ToString().Trim(); //专业名称
objvTeachingCaseResCaseRelaInfoEN.CourseId = objRow[convTeachingCaseResCaseRelaInfo.CourseId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CourseId].ToString().Trim(); //课程Id
objvTeachingCaseResCaseRelaInfoEN.CourseCode = objRow[convTeachingCaseResCaseRelaInfo.CourseCode] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CourseCode].ToString().Trim(); //课程代码
objvTeachingCaseResCaseRelaInfoEN.CourseName = objRow[convTeachingCaseResCaseRelaInfo.CourseName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CourseName].ToString().Trim(); //课程名称
objvTeachingCaseResCaseRelaInfoEN.IdResource = objRow[convTeachingCaseResCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvTeachingCaseResCaseRelaInfoEN.ResourceID = objRow[convTeachingCaseResCaseRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvTeachingCaseResCaseRelaInfoEN.IdFtpResource = objRow[convTeachingCaseResCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvTeachingCaseResCaseRelaInfoEN.IdFile = objRow[convTeachingCaseResCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvTeachingCaseResCaseRelaInfoEN.FileName = objRow[convTeachingCaseResCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvTeachingCaseResCaseRelaInfoEN.FileType = objRow[convTeachingCaseResCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvTeachingCaseResCaseRelaInfoEN.SaveDate = objRow[convTeachingCaseResCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvTeachingCaseResCaseRelaInfoEN.FileSize = objRow[convTeachingCaseResCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvTeachingCaseResCaseRelaInfoEN.SaveTime = objRow[convTeachingCaseResCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvTeachingCaseResCaseRelaInfoEN.FtpResourceID = objRow[convTeachingCaseResCaseRelaInfo.FtpResourceID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvTeachingCaseResCaseRelaInfoEN.FileOriginalName = objRow[convTeachingCaseResCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvTeachingCaseResCaseRelaInfoEN.FileDirName = objRow[convTeachingCaseResCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvTeachingCaseResCaseRelaInfoEN.FileRename = objRow[convTeachingCaseResCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvTeachingCaseResCaseRelaInfoEN.FileUpDate = objRow[convTeachingCaseResCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvTeachingCaseResCaseRelaInfoEN.FileUpTime = objRow[convTeachingCaseResCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvTeachingCaseResCaseRelaInfoEN.SaveMode = TransNullToBool(objRow[convTeachingCaseResCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvTeachingCaseResCaseRelaInfoEN.IdResourceType = objRow[convTeachingCaseResCaseRelaInfo.IdResourceType] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvTeachingCaseResCaseRelaInfoEN.ResourceTypeID = objRow[convTeachingCaseResCaseRelaInfo.ResourceTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvTeachingCaseResCaseRelaInfoEN.ResourceTypeName = objRow[convTeachingCaseResCaseRelaInfo.ResourceTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvTeachingCaseResCaseRelaInfoEN.ResourceOwner = objRow[convTeachingCaseResCaseRelaInfo.ResourceOwner] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvTeachingCaseResCaseRelaInfoEN.ftpFileType = objRow[convTeachingCaseResCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachingCaseResCaseRelaInfoEN.ftpFileSize = objRow[convTeachingCaseResCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvTeachingCaseResCaseRelaInfoEN.ftpResourceOwner = objRow[convTeachingCaseResCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvTeachingCaseResCaseRelaInfoEN.FileOriginName = objRow[convTeachingCaseResCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvTeachingCaseResCaseRelaInfoEN.IsExistFile = TransNullToBool(objRow[convTeachingCaseResCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvTeachingCaseResCaseRelaInfoEN.FileNewName = objRow[convTeachingCaseResCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvTeachingCaseResCaseRelaInfoEN.FileOldName = objRow[convTeachingCaseResCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvTeachingCaseResCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfoType] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvTeachingCaseResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objvTeachingCaseResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvTeachingCaseResCaseRelaInfoEN.IsVisible = TransNullToBool(objRow[convTeachingCaseResCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvTeachingCaseResCaseRelaInfoEN.BrowseCount = objRow[convTeachingCaseResCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvTeachingCaseResCaseRelaInfoEN.Flag = objRow[convTeachingCaseResCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.Flag].ToString().Trim(); //标志
objvTeachingCaseResCaseRelaInfoEN.UpdDate = objRow[convTeachingCaseResCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvTeachingCaseResCaseRelaInfoEN.UpdUser = objRow[convTeachingCaseResCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objvTeachingCaseResCaseRelaInfoEN.Memo = objRow[convTeachingCaseResCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvTeachingCaseResCaseRelaInfoDA: GetObjLst)", objException.Message));
}
objvTeachingCaseResCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvTeachingCaseResCaseRelaInfoEN);
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
public List<clsvTeachingCaseResCaseRelaInfoEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvTeachingCaseResCaseRelaInfoDA:GetObjLstByTabName)", objException.Message));
}
List<clsvTeachingCaseResCaseRelaInfoEN> arrObjLst = new List<clsvTeachingCaseResCaseRelaInfoEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingCaseResCaseRelaInfoDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN = new clsvTeachingCaseResCaseRelaInfoEN();
try
{
objvTeachingCaseResCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = TransNullToInt(objRow[convTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvTeachingCaseResCaseRelaInfoEN.FuncModuleId = objRow[convTeachingCaseResCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvTeachingCaseResCaseRelaInfoEN.FuncModuleName = objRow[convTeachingCaseResCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvTeachingCaseResCaseRelaInfoEN.IdMicroteachCase = objRow[convTeachingCaseResCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvTeachingCaseResCaseRelaInfoEN.IdTeachingCaseResCase = objRow[convTeachingCaseResCaseRelaInfo.IdTeachingCaseResCase] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号
objvTeachingCaseResCaseRelaInfoEN.TeachingCaseResCaseName = objRow[convTeachingCaseResCaseRelaInfo.TeachingCaseResCaseName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objvTeachingCaseResCaseRelaInfoEN.IdXzCollege = objRow[convTeachingCaseResCaseRelaInfo.IdXzCollege] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingCaseResCaseRelaInfoEN.CollegeID = objRow[convTeachingCaseResCaseRelaInfo.CollegeID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CollegeID].ToString().Trim(); //学院ID
objvTeachingCaseResCaseRelaInfoEN.CollegeName = objRow[convTeachingCaseResCaseRelaInfo.CollegeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CollegeName].ToString().Trim(); //学院名称
objvTeachingCaseResCaseRelaInfoEN.CollegeNameA = objRow[convTeachingCaseResCaseRelaInfo.CollegeNameA] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachingCaseResCaseRelaInfoEN.MajorID = objRow[convTeachingCaseResCaseRelaInfo.MajorID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.MajorID].ToString().Trim(); //专业ID
objvTeachingCaseResCaseRelaInfoEN.MajorName = objRow[convTeachingCaseResCaseRelaInfo.MajorName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.MajorName].ToString().Trim(); //专业名称
objvTeachingCaseResCaseRelaInfoEN.CourseId = objRow[convTeachingCaseResCaseRelaInfo.CourseId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CourseId].ToString().Trim(); //课程Id
objvTeachingCaseResCaseRelaInfoEN.CourseCode = objRow[convTeachingCaseResCaseRelaInfo.CourseCode] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CourseCode].ToString().Trim(); //课程代码
objvTeachingCaseResCaseRelaInfoEN.CourseName = objRow[convTeachingCaseResCaseRelaInfo.CourseName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CourseName].ToString().Trim(); //课程名称
objvTeachingCaseResCaseRelaInfoEN.IdResource = objRow[convTeachingCaseResCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvTeachingCaseResCaseRelaInfoEN.ResourceID = objRow[convTeachingCaseResCaseRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvTeachingCaseResCaseRelaInfoEN.IdFtpResource = objRow[convTeachingCaseResCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvTeachingCaseResCaseRelaInfoEN.IdFile = objRow[convTeachingCaseResCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvTeachingCaseResCaseRelaInfoEN.FileName = objRow[convTeachingCaseResCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvTeachingCaseResCaseRelaInfoEN.FileType = objRow[convTeachingCaseResCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvTeachingCaseResCaseRelaInfoEN.SaveDate = objRow[convTeachingCaseResCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvTeachingCaseResCaseRelaInfoEN.FileSize = objRow[convTeachingCaseResCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvTeachingCaseResCaseRelaInfoEN.SaveTime = objRow[convTeachingCaseResCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvTeachingCaseResCaseRelaInfoEN.FtpResourceID = objRow[convTeachingCaseResCaseRelaInfo.FtpResourceID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvTeachingCaseResCaseRelaInfoEN.FileOriginalName = objRow[convTeachingCaseResCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvTeachingCaseResCaseRelaInfoEN.FileDirName = objRow[convTeachingCaseResCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvTeachingCaseResCaseRelaInfoEN.FileRename = objRow[convTeachingCaseResCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvTeachingCaseResCaseRelaInfoEN.FileUpDate = objRow[convTeachingCaseResCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvTeachingCaseResCaseRelaInfoEN.FileUpTime = objRow[convTeachingCaseResCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvTeachingCaseResCaseRelaInfoEN.SaveMode = TransNullToBool(objRow[convTeachingCaseResCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvTeachingCaseResCaseRelaInfoEN.IdResourceType = objRow[convTeachingCaseResCaseRelaInfo.IdResourceType] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvTeachingCaseResCaseRelaInfoEN.ResourceTypeID = objRow[convTeachingCaseResCaseRelaInfo.ResourceTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvTeachingCaseResCaseRelaInfoEN.ResourceTypeName = objRow[convTeachingCaseResCaseRelaInfo.ResourceTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvTeachingCaseResCaseRelaInfoEN.ResourceOwner = objRow[convTeachingCaseResCaseRelaInfo.ResourceOwner] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvTeachingCaseResCaseRelaInfoEN.ftpFileType = objRow[convTeachingCaseResCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachingCaseResCaseRelaInfoEN.ftpFileSize = objRow[convTeachingCaseResCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvTeachingCaseResCaseRelaInfoEN.ftpResourceOwner = objRow[convTeachingCaseResCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvTeachingCaseResCaseRelaInfoEN.FileOriginName = objRow[convTeachingCaseResCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvTeachingCaseResCaseRelaInfoEN.IsExistFile = TransNullToBool(objRow[convTeachingCaseResCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvTeachingCaseResCaseRelaInfoEN.FileNewName = objRow[convTeachingCaseResCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvTeachingCaseResCaseRelaInfoEN.FileOldName = objRow[convTeachingCaseResCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvTeachingCaseResCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfoType] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvTeachingCaseResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objvTeachingCaseResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvTeachingCaseResCaseRelaInfoEN.IsVisible = TransNullToBool(objRow[convTeachingCaseResCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvTeachingCaseResCaseRelaInfoEN.BrowseCount = objRow[convTeachingCaseResCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvTeachingCaseResCaseRelaInfoEN.Flag = objRow[convTeachingCaseResCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.Flag].ToString().Trim(); //标志
objvTeachingCaseResCaseRelaInfoEN.UpdDate = objRow[convTeachingCaseResCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvTeachingCaseResCaseRelaInfoEN.UpdUser = objRow[convTeachingCaseResCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objvTeachingCaseResCaseRelaInfoEN.Memo = objRow[convTeachingCaseResCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvTeachingCaseResCaseRelaInfoDA: GetObjLst)", objException.Message));
}
objvTeachingCaseResCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvTeachingCaseResCaseRelaInfoEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvTeachingCaseResCaseRelaInfo(ref clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingCaseResCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vTeachingCaseResCaseRelaInfo where IdMicroTeachCaseRelaInfo = " + ""+ objvTeachingCaseResCaseRelaInfoEN.IdMicroTeachCaseRelaInfo+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvTeachingCaseResCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = TransNullToInt(objDT.Rows[0][convTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvTeachingCaseResCaseRelaInfoEN.FuncModuleId = objDT.Rows[0][convTeachingCaseResCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvTeachingCaseResCaseRelaInfoEN.FuncModuleName = objDT.Rows[0][convTeachingCaseResCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvTeachingCaseResCaseRelaInfoEN.IdMicroteachCase = objDT.Rows[0][convTeachingCaseResCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvTeachingCaseResCaseRelaInfoEN.IdTeachingCaseResCase = objDT.Rows[0][convTeachingCaseResCaseRelaInfo.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvTeachingCaseResCaseRelaInfoEN.TeachingCaseResCaseName = objDT.Rows[0][convTeachingCaseResCaseRelaInfo.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvTeachingCaseResCaseRelaInfoEN.IdXzCollege = objDT.Rows[0][convTeachingCaseResCaseRelaInfo.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvTeachingCaseResCaseRelaInfoEN.CollegeID = objDT.Rows[0][convTeachingCaseResCaseRelaInfo.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvTeachingCaseResCaseRelaInfoEN.CollegeName = objDT.Rows[0][convTeachingCaseResCaseRelaInfo.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvTeachingCaseResCaseRelaInfoEN.CollegeNameA = objDT.Rows[0][convTeachingCaseResCaseRelaInfo.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvTeachingCaseResCaseRelaInfoEN.MajorID = objDT.Rows[0][convTeachingCaseResCaseRelaInfo.MajorID].ToString().Trim(); //专业ID(字段类型:char,字段长度:4,是否可空:False)
 objvTeachingCaseResCaseRelaInfoEN.MajorName = objDT.Rows[0][convTeachingCaseResCaseRelaInfo.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvTeachingCaseResCaseRelaInfoEN.CourseId = objDT.Rows[0][convTeachingCaseResCaseRelaInfo.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvTeachingCaseResCaseRelaInfoEN.CourseCode = objDT.Rows[0][convTeachingCaseResCaseRelaInfo.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvTeachingCaseResCaseRelaInfoEN.CourseName = objDT.Rows[0][convTeachingCaseResCaseRelaInfo.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvTeachingCaseResCaseRelaInfoEN.IdResource = objDT.Rows[0][convTeachingCaseResCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objvTeachingCaseResCaseRelaInfoEN.ResourceID = objDT.Rows[0][convTeachingCaseResCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvTeachingCaseResCaseRelaInfoEN.IdFtpResource = objDT.Rows[0][convTeachingCaseResCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objvTeachingCaseResCaseRelaInfoEN.IdFile = objDT.Rows[0][convTeachingCaseResCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号(字段类型:char,字段长度:8,是否可空:True)
 objvTeachingCaseResCaseRelaInfoEN.FileName = objDT.Rows[0][convTeachingCaseResCaseRelaInfo.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvTeachingCaseResCaseRelaInfoEN.FileType = objDT.Rows[0][convTeachingCaseResCaseRelaInfo.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvTeachingCaseResCaseRelaInfoEN.SaveDate = objDT.Rows[0][convTeachingCaseResCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvTeachingCaseResCaseRelaInfoEN.FileSize = objDT.Rows[0][convTeachingCaseResCaseRelaInfo.FileSize].ToString().Trim(); //文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvTeachingCaseResCaseRelaInfoEN.SaveTime = objDT.Rows[0][convTeachingCaseResCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvTeachingCaseResCaseRelaInfoEN.FtpResourceID = objDT.Rows[0][convTeachingCaseResCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvTeachingCaseResCaseRelaInfoEN.FileOriginalName = objDT.Rows[0][convTeachingCaseResCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名(字段类型:varchar,字段长度:200,是否可空:True)
 objvTeachingCaseResCaseRelaInfoEN.FileDirName = objDT.Rows[0][convTeachingCaseResCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objvTeachingCaseResCaseRelaInfoEN.FileRename = objDT.Rows[0][convTeachingCaseResCaseRelaInfo.FileRename].ToString().Trim(); //文件新名(字段类型:varchar,字段长度:200,是否可空:True)
 objvTeachingCaseResCaseRelaInfoEN.FileUpDate = objDT.Rows[0][convTeachingCaseResCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvTeachingCaseResCaseRelaInfoEN.FileUpTime = objDT.Rows[0][convTeachingCaseResCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvTeachingCaseResCaseRelaInfoEN.SaveMode = TransNullToBool(objDT.Rows[0][convTeachingCaseResCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式(字段类型:bit,字段长度:1,是否可空:True)
 objvTeachingCaseResCaseRelaInfoEN.IdResourceType = objDT.Rows[0][convTeachingCaseResCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvTeachingCaseResCaseRelaInfoEN.ResourceTypeID = objDT.Rows[0][convTeachingCaseResCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvTeachingCaseResCaseRelaInfoEN.ResourceTypeName = objDT.Rows[0][convTeachingCaseResCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvTeachingCaseResCaseRelaInfoEN.ResourceOwner = objDT.Rows[0][convTeachingCaseResCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者(字段类型:varchar,字段长度:50,是否可空:False)
 objvTeachingCaseResCaseRelaInfoEN.ftpFileType = objDT.Rows[0][convTeachingCaseResCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvTeachingCaseResCaseRelaInfoEN.ftpFileSize = objDT.Rows[0][convTeachingCaseResCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvTeachingCaseResCaseRelaInfoEN.ftpResourceOwner = objDT.Rows[0][convTeachingCaseResCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者(字段类型:varchar,字段长度:50,是否可空:True)
 objvTeachingCaseResCaseRelaInfoEN.FileOriginName = objDT.Rows[0][convTeachingCaseResCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名(字段类型:varchar,字段长度:500,是否可空:True)
 objvTeachingCaseResCaseRelaInfoEN.IsExistFile = TransNullToBool(objDT.Rows[0][convTeachingCaseResCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objvTeachingCaseResCaseRelaInfoEN.FileNewName = objDT.Rows[0][convTeachingCaseResCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvTeachingCaseResCaseRelaInfoEN.FileOldName = objDT.Rows[0][convTeachingCaseResCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvTeachingCaseResCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objDT.Rows[0][convTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvTeachingCaseResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objDT.Rows[0][convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvTeachingCaseResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objDT.Rows[0][convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvTeachingCaseResCaseRelaInfoEN.IsVisible = TransNullToBool(objDT.Rows[0][convTeachingCaseResCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvTeachingCaseResCaseRelaInfoEN.BrowseCount = TransNullToInt(objDT.Rows[0][convTeachingCaseResCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvTeachingCaseResCaseRelaInfoEN.Flag = objDT.Rows[0][convTeachingCaseResCaseRelaInfo.Flag].ToString().Trim(); //标志(字段类型:varchar,字段长度:50,是否可空:True)
 objvTeachingCaseResCaseRelaInfoEN.UpdDate = objDT.Rows[0][convTeachingCaseResCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvTeachingCaseResCaseRelaInfoEN.UpdUser = objDT.Rows[0][convTeachingCaseResCaseRelaInfo.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvTeachingCaseResCaseRelaInfoEN.Memo = objDT.Rows[0][convTeachingCaseResCaseRelaInfo.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvTeachingCaseResCaseRelaInfoDA: GetvTeachingCaseResCaseRelaInfo)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdMicroTeachCaseRelaInfo">表关键字</param>
 /// <returns>表对象</returns>
public clsvTeachingCaseResCaseRelaInfoEN GetObjByIdMicroTeachCaseRelaInfo(long lngIdMicroTeachCaseRelaInfo)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingCaseResCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vTeachingCaseResCaseRelaInfo where IdMicroTeachCaseRelaInfo = " + ""+ lngIdMicroTeachCaseRelaInfo+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN = new clsvTeachingCaseResCaseRelaInfoEN();
try
{
 objvTeachingCaseResCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = Int32.Parse(objRow[convTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvTeachingCaseResCaseRelaInfoEN.FuncModuleId = objRow[convTeachingCaseResCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvTeachingCaseResCaseRelaInfoEN.FuncModuleName = objRow[convTeachingCaseResCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvTeachingCaseResCaseRelaInfoEN.IdMicroteachCase = objRow[convTeachingCaseResCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvTeachingCaseResCaseRelaInfoEN.IdTeachingCaseResCase = objRow[convTeachingCaseResCaseRelaInfo.IdTeachingCaseResCase] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvTeachingCaseResCaseRelaInfoEN.TeachingCaseResCaseName = objRow[convTeachingCaseResCaseRelaInfo.TeachingCaseResCaseName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvTeachingCaseResCaseRelaInfoEN.IdXzCollege = objRow[convTeachingCaseResCaseRelaInfo.IdXzCollege] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvTeachingCaseResCaseRelaInfoEN.CollegeID = objRow[convTeachingCaseResCaseRelaInfo.CollegeID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvTeachingCaseResCaseRelaInfoEN.CollegeName = objRow[convTeachingCaseResCaseRelaInfo.CollegeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvTeachingCaseResCaseRelaInfoEN.CollegeNameA = objRow[convTeachingCaseResCaseRelaInfo.CollegeNameA] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvTeachingCaseResCaseRelaInfoEN.MajorID = objRow[convTeachingCaseResCaseRelaInfo.MajorID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.MajorID].ToString().Trim(); //专业ID(字段类型:char,字段长度:4,是否可空:False)
 objvTeachingCaseResCaseRelaInfoEN.MajorName = objRow[convTeachingCaseResCaseRelaInfo.MajorName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvTeachingCaseResCaseRelaInfoEN.CourseId = objRow[convTeachingCaseResCaseRelaInfo.CourseId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvTeachingCaseResCaseRelaInfoEN.CourseCode = objRow[convTeachingCaseResCaseRelaInfo.CourseCode] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvTeachingCaseResCaseRelaInfoEN.CourseName = objRow[convTeachingCaseResCaseRelaInfo.CourseName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvTeachingCaseResCaseRelaInfoEN.IdResource = objRow[convTeachingCaseResCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objvTeachingCaseResCaseRelaInfoEN.ResourceID = objRow[convTeachingCaseResCaseRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvTeachingCaseResCaseRelaInfoEN.IdFtpResource = objRow[convTeachingCaseResCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objvTeachingCaseResCaseRelaInfoEN.IdFile = objRow[convTeachingCaseResCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号(字段类型:char,字段长度:8,是否可空:True)
 objvTeachingCaseResCaseRelaInfoEN.FileName = objRow[convTeachingCaseResCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvTeachingCaseResCaseRelaInfoEN.FileType = objRow[convTeachingCaseResCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvTeachingCaseResCaseRelaInfoEN.SaveDate = objRow[convTeachingCaseResCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvTeachingCaseResCaseRelaInfoEN.FileSize = objRow[convTeachingCaseResCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileSize].ToString().Trim(); //文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvTeachingCaseResCaseRelaInfoEN.SaveTime = objRow[convTeachingCaseResCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvTeachingCaseResCaseRelaInfoEN.FtpResourceID = objRow[convTeachingCaseResCaseRelaInfo.FtpResourceID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvTeachingCaseResCaseRelaInfoEN.FileOriginalName = objRow[convTeachingCaseResCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名(字段类型:varchar,字段长度:200,是否可空:True)
 objvTeachingCaseResCaseRelaInfoEN.FileDirName = objRow[convTeachingCaseResCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objvTeachingCaseResCaseRelaInfoEN.FileRename = objRow[convTeachingCaseResCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileRename].ToString().Trim(); //文件新名(字段类型:varchar,字段长度:200,是否可空:True)
 objvTeachingCaseResCaseRelaInfoEN.FileUpDate = objRow[convTeachingCaseResCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvTeachingCaseResCaseRelaInfoEN.FileUpTime = objRow[convTeachingCaseResCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvTeachingCaseResCaseRelaInfoEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式(字段类型:bit,字段长度:1,是否可空:True)
 objvTeachingCaseResCaseRelaInfoEN.IdResourceType = objRow[convTeachingCaseResCaseRelaInfo.IdResourceType] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvTeachingCaseResCaseRelaInfoEN.ResourceTypeID = objRow[convTeachingCaseResCaseRelaInfo.ResourceTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvTeachingCaseResCaseRelaInfoEN.ResourceTypeName = objRow[convTeachingCaseResCaseRelaInfo.ResourceTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvTeachingCaseResCaseRelaInfoEN.ResourceOwner = objRow[convTeachingCaseResCaseRelaInfo.ResourceOwner] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者(字段类型:varchar,字段长度:50,是否可空:False)
 objvTeachingCaseResCaseRelaInfoEN.ftpFileType = objRow[convTeachingCaseResCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvTeachingCaseResCaseRelaInfoEN.ftpFileSize = objRow[convTeachingCaseResCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvTeachingCaseResCaseRelaInfoEN.ftpResourceOwner = objRow[convTeachingCaseResCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者(字段类型:varchar,字段长度:50,是否可空:True)
 objvTeachingCaseResCaseRelaInfoEN.FileOriginName = objRow[convTeachingCaseResCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名(字段类型:varchar,字段长度:500,是否可空:True)
 objvTeachingCaseResCaseRelaInfoEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objvTeachingCaseResCaseRelaInfoEN.FileNewName = objRow[convTeachingCaseResCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvTeachingCaseResCaseRelaInfoEN.FileOldName = objRow[convTeachingCaseResCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvTeachingCaseResCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfoType] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvTeachingCaseResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvTeachingCaseResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvTeachingCaseResCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvTeachingCaseResCaseRelaInfoEN.BrowseCount = objRow[convTeachingCaseResCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvTeachingCaseResCaseRelaInfoEN.Flag = objRow[convTeachingCaseResCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.Flag].ToString().Trim(); //标志(字段类型:varchar,字段长度:50,是否可空:True)
 objvTeachingCaseResCaseRelaInfoEN.UpdDate = objRow[convTeachingCaseResCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvTeachingCaseResCaseRelaInfoEN.UpdUser = objRow[convTeachingCaseResCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvTeachingCaseResCaseRelaInfoEN.Memo = objRow[convTeachingCaseResCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvTeachingCaseResCaseRelaInfoDA: GetObjByIdMicroTeachCaseRelaInfo)", objException.Message));
}
return objvTeachingCaseResCaseRelaInfoEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvTeachingCaseResCaseRelaInfoEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvTeachingCaseResCaseRelaInfoDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingCaseResCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vTeachingCaseResCaseRelaInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN = new clsvTeachingCaseResCaseRelaInfoEN()
{
IdMicroTeachCaseRelaInfo = TransNullToInt(objRow[convTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()), //案例相关信息流水号
FuncModuleId = objRow[convTeachingCaseResCaseRelaInfo.FuncModuleId].ToString().Trim(), //功能模块Id
FuncModuleName = objRow[convTeachingCaseResCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FuncModuleName].ToString().Trim(), //功能模块名称
IdMicroteachCase = objRow[convTeachingCaseResCaseRelaInfo.IdMicroteachCase].ToString().Trim(), //微格教学案例流水号
IdTeachingCaseResCase = objRow[convTeachingCaseResCaseRelaInfo.IdTeachingCaseResCase] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdTeachingCaseResCase].ToString().Trim(), //教学案例资源案例流水号
TeachingCaseResCaseName = objRow[convTeachingCaseResCaseRelaInfo.TeachingCaseResCaseName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.TeachingCaseResCaseName].ToString().Trim(), //教学案例资源案例名称
IdXzCollege = objRow[convTeachingCaseResCaseRelaInfo.IdXzCollege] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdXzCollege].ToString().Trim(), //学院流水号
CollegeID = objRow[convTeachingCaseResCaseRelaInfo.CollegeID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CollegeID].ToString().Trim(), //学院ID
CollegeName = objRow[convTeachingCaseResCaseRelaInfo.CollegeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CollegeName].ToString().Trim(), //学院名称
CollegeNameA = objRow[convTeachingCaseResCaseRelaInfo.CollegeNameA] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CollegeNameA].ToString().Trim(), //学院名称简写
MajorID = objRow[convTeachingCaseResCaseRelaInfo.MajorID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.MajorID].ToString().Trim(), //专业ID
MajorName = objRow[convTeachingCaseResCaseRelaInfo.MajorName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.MajorName].ToString().Trim(), //专业名称
CourseId = objRow[convTeachingCaseResCaseRelaInfo.CourseId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CourseId].ToString().Trim(), //课程Id
CourseCode = objRow[convTeachingCaseResCaseRelaInfo.CourseCode] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CourseCode].ToString().Trim(), //课程代码
CourseName = objRow[convTeachingCaseResCaseRelaInfo.CourseName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CourseName].ToString().Trim(), //课程名称
IdResource = objRow[convTeachingCaseResCaseRelaInfo.IdResource].ToString().Trim(), //资源流水号
ResourceID = objRow[convTeachingCaseResCaseRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ResourceID].ToString().Trim(), //资源ID
IdFtpResource = objRow[convTeachingCaseResCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdFtpResource].ToString().Trim(), //FTP资源流水号
IdFile = objRow[convTeachingCaseResCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdFile].ToString().Trim(), //文件流水号
FileName = objRow[convTeachingCaseResCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileName].ToString().Trim(), //文件名称
FileType = objRow[convTeachingCaseResCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileType].ToString().Trim(), //文件类型
SaveDate = objRow[convTeachingCaseResCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.SaveDate].ToString().Trim(), //创建日期
FileSize = objRow[convTeachingCaseResCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileSize].ToString().Trim(), //文件大小
SaveTime = objRow[convTeachingCaseResCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.SaveTime].ToString().Trim(), //创建时间
FtpResourceID = objRow[convTeachingCaseResCaseRelaInfo.FtpResourceID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FtpResourceID].ToString().Trim(), //FTP资源ID
FileOriginalName = objRow[convTeachingCaseResCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileOriginalName].ToString().Trim(), //文件原名
FileDirName = objRow[convTeachingCaseResCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileDirName].ToString().Trim(), //文件目录名
FileRename = objRow[convTeachingCaseResCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileRename].ToString().Trim(), //文件新名
FileUpDate = objRow[convTeachingCaseResCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileUpDate].ToString().Trim(), //创建日期
FileUpTime = objRow[convTeachingCaseResCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileUpTime].ToString().Trim(), //创建时间
SaveMode = TransNullToBool(objRow[convTeachingCaseResCaseRelaInfo.SaveMode].ToString().Trim()), //文件存放方式
IdResourceType = objRow[convTeachingCaseResCaseRelaInfo.IdResourceType] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdResourceType].ToString().Trim(), //资源类型流水号
ResourceTypeID = objRow[convTeachingCaseResCaseRelaInfo.ResourceTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ResourceTypeID].ToString().Trim(), //资源类型ID
ResourceTypeName = objRow[convTeachingCaseResCaseRelaInfo.ResourceTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ResourceTypeName].ToString().Trim(), //资源类型名称
ResourceOwner = objRow[convTeachingCaseResCaseRelaInfo.ResourceOwner] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ResourceOwner].ToString().Trim(), //上传者
ftpFileType = objRow[convTeachingCaseResCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ftpFileType].ToString().Trim(), //ftp文件类型
ftpFileSize = objRow[convTeachingCaseResCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ftpFileSize].ToString().Trim(), //ftp文件大小
ftpResourceOwner = objRow[convTeachingCaseResCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ftpResourceOwner].ToString().Trim(), //Ftp资源拥有者
FileOriginName = objRow[convTeachingCaseResCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileOriginName].ToString().Trim(), //原文件名
IsExistFile = TransNullToBool(objRow[convTeachingCaseResCaseRelaInfo.IsExistFile].ToString().Trim()), //是否存在文件
FileNewName = objRow[convTeachingCaseResCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileNewName].ToString().Trim(), //新文件名
FileOldName = objRow[convTeachingCaseResCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileOldName].ToString().Trim(), //旧文件名
IdMicroTeachCaseRelaInfoType = objRow[convTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfoType] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(), //微格案例相关信息类型流水号
MicroTeachCaseRelaInfoTypeID = objRow[convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(), //微格案例相关信息类型ID
MicroTeachCaseRelaInfoTypeName = objRow[convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(), //微格案例相关信息类型名称
IsVisible = TransNullToBool(objRow[convTeachingCaseResCaseRelaInfo.IsVisible].ToString().Trim()), //是否显示
BrowseCount = objRow[convTeachingCaseResCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCaseRelaInfo.BrowseCount].ToString().Trim()), //浏览次数
Flag = objRow[convTeachingCaseResCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.Flag].ToString().Trim(), //标志
UpdDate = objRow[convTeachingCaseResCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convTeachingCaseResCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convTeachingCaseResCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.Memo].ToString().Trim() //备注
};
objvTeachingCaseResCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvTeachingCaseResCaseRelaInfoEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvTeachingCaseResCaseRelaInfoDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvTeachingCaseResCaseRelaInfoEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN = new clsvTeachingCaseResCaseRelaInfoEN();
try
{
objvTeachingCaseResCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = TransNullToInt(objRow[convTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvTeachingCaseResCaseRelaInfoEN.FuncModuleId = objRow[convTeachingCaseResCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvTeachingCaseResCaseRelaInfoEN.FuncModuleName = objRow[convTeachingCaseResCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvTeachingCaseResCaseRelaInfoEN.IdMicroteachCase = objRow[convTeachingCaseResCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvTeachingCaseResCaseRelaInfoEN.IdTeachingCaseResCase = objRow[convTeachingCaseResCaseRelaInfo.IdTeachingCaseResCase] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号
objvTeachingCaseResCaseRelaInfoEN.TeachingCaseResCaseName = objRow[convTeachingCaseResCaseRelaInfo.TeachingCaseResCaseName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objvTeachingCaseResCaseRelaInfoEN.IdXzCollege = objRow[convTeachingCaseResCaseRelaInfo.IdXzCollege] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingCaseResCaseRelaInfoEN.CollegeID = objRow[convTeachingCaseResCaseRelaInfo.CollegeID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CollegeID].ToString().Trim(); //学院ID
objvTeachingCaseResCaseRelaInfoEN.CollegeName = objRow[convTeachingCaseResCaseRelaInfo.CollegeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CollegeName].ToString().Trim(); //学院名称
objvTeachingCaseResCaseRelaInfoEN.CollegeNameA = objRow[convTeachingCaseResCaseRelaInfo.CollegeNameA] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachingCaseResCaseRelaInfoEN.MajorID = objRow[convTeachingCaseResCaseRelaInfo.MajorID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.MajorID].ToString().Trim(); //专业ID
objvTeachingCaseResCaseRelaInfoEN.MajorName = objRow[convTeachingCaseResCaseRelaInfo.MajorName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.MajorName].ToString().Trim(); //专业名称
objvTeachingCaseResCaseRelaInfoEN.CourseId = objRow[convTeachingCaseResCaseRelaInfo.CourseId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CourseId].ToString().Trim(); //课程Id
objvTeachingCaseResCaseRelaInfoEN.CourseCode = objRow[convTeachingCaseResCaseRelaInfo.CourseCode] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CourseCode].ToString().Trim(); //课程代码
objvTeachingCaseResCaseRelaInfoEN.CourseName = objRow[convTeachingCaseResCaseRelaInfo.CourseName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CourseName].ToString().Trim(); //课程名称
objvTeachingCaseResCaseRelaInfoEN.IdResource = objRow[convTeachingCaseResCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvTeachingCaseResCaseRelaInfoEN.ResourceID = objRow[convTeachingCaseResCaseRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvTeachingCaseResCaseRelaInfoEN.IdFtpResource = objRow[convTeachingCaseResCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvTeachingCaseResCaseRelaInfoEN.IdFile = objRow[convTeachingCaseResCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvTeachingCaseResCaseRelaInfoEN.FileName = objRow[convTeachingCaseResCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvTeachingCaseResCaseRelaInfoEN.FileType = objRow[convTeachingCaseResCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvTeachingCaseResCaseRelaInfoEN.SaveDate = objRow[convTeachingCaseResCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvTeachingCaseResCaseRelaInfoEN.FileSize = objRow[convTeachingCaseResCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvTeachingCaseResCaseRelaInfoEN.SaveTime = objRow[convTeachingCaseResCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvTeachingCaseResCaseRelaInfoEN.FtpResourceID = objRow[convTeachingCaseResCaseRelaInfo.FtpResourceID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvTeachingCaseResCaseRelaInfoEN.FileOriginalName = objRow[convTeachingCaseResCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvTeachingCaseResCaseRelaInfoEN.FileDirName = objRow[convTeachingCaseResCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvTeachingCaseResCaseRelaInfoEN.FileRename = objRow[convTeachingCaseResCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvTeachingCaseResCaseRelaInfoEN.FileUpDate = objRow[convTeachingCaseResCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvTeachingCaseResCaseRelaInfoEN.FileUpTime = objRow[convTeachingCaseResCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvTeachingCaseResCaseRelaInfoEN.SaveMode = TransNullToBool(objRow[convTeachingCaseResCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvTeachingCaseResCaseRelaInfoEN.IdResourceType = objRow[convTeachingCaseResCaseRelaInfo.IdResourceType] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvTeachingCaseResCaseRelaInfoEN.ResourceTypeID = objRow[convTeachingCaseResCaseRelaInfo.ResourceTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvTeachingCaseResCaseRelaInfoEN.ResourceTypeName = objRow[convTeachingCaseResCaseRelaInfo.ResourceTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvTeachingCaseResCaseRelaInfoEN.ResourceOwner = objRow[convTeachingCaseResCaseRelaInfo.ResourceOwner] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvTeachingCaseResCaseRelaInfoEN.ftpFileType = objRow[convTeachingCaseResCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachingCaseResCaseRelaInfoEN.ftpFileSize = objRow[convTeachingCaseResCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvTeachingCaseResCaseRelaInfoEN.ftpResourceOwner = objRow[convTeachingCaseResCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvTeachingCaseResCaseRelaInfoEN.FileOriginName = objRow[convTeachingCaseResCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvTeachingCaseResCaseRelaInfoEN.IsExistFile = TransNullToBool(objRow[convTeachingCaseResCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvTeachingCaseResCaseRelaInfoEN.FileNewName = objRow[convTeachingCaseResCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvTeachingCaseResCaseRelaInfoEN.FileOldName = objRow[convTeachingCaseResCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvTeachingCaseResCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfoType] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvTeachingCaseResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objvTeachingCaseResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvTeachingCaseResCaseRelaInfoEN.IsVisible = TransNullToBool(objRow[convTeachingCaseResCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvTeachingCaseResCaseRelaInfoEN.BrowseCount = objRow[convTeachingCaseResCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvTeachingCaseResCaseRelaInfoEN.Flag = objRow[convTeachingCaseResCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.Flag].ToString().Trim(); //标志
objvTeachingCaseResCaseRelaInfoEN.UpdDate = objRow[convTeachingCaseResCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvTeachingCaseResCaseRelaInfoEN.UpdUser = objRow[convTeachingCaseResCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objvTeachingCaseResCaseRelaInfoEN.Memo = objRow[convTeachingCaseResCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvTeachingCaseResCaseRelaInfoDA: GetObjByDataRowvTeachingCaseResCaseRelaInfo)", objException.Message));
}
objvTeachingCaseResCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvTeachingCaseResCaseRelaInfoEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvTeachingCaseResCaseRelaInfoEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN = new clsvTeachingCaseResCaseRelaInfoEN();
try
{
objvTeachingCaseResCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = TransNullToInt(objRow[convTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvTeachingCaseResCaseRelaInfoEN.FuncModuleId = objRow[convTeachingCaseResCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvTeachingCaseResCaseRelaInfoEN.FuncModuleName = objRow[convTeachingCaseResCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvTeachingCaseResCaseRelaInfoEN.IdMicroteachCase = objRow[convTeachingCaseResCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvTeachingCaseResCaseRelaInfoEN.IdTeachingCaseResCase = objRow[convTeachingCaseResCaseRelaInfo.IdTeachingCaseResCase] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号
objvTeachingCaseResCaseRelaInfoEN.TeachingCaseResCaseName = objRow[convTeachingCaseResCaseRelaInfo.TeachingCaseResCaseName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objvTeachingCaseResCaseRelaInfoEN.IdXzCollege = objRow[convTeachingCaseResCaseRelaInfo.IdXzCollege] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingCaseResCaseRelaInfoEN.CollegeID = objRow[convTeachingCaseResCaseRelaInfo.CollegeID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CollegeID].ToString().Trim(); //学院ID
objvTeachingCaseResCaseRelaInfoEN.CollegeName = objRow[convTeachingCaseResCaseRelaInfo.CollegeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CollegeName].ToString().Trim(); //学院名称
objvTeachingCaseResCaseRelaInfoEN.CollegeNameA = objRow[convTeachingCaseResCaseRelaInfo.CollegeNameA] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachingCaseResCaseRelaInfoEN.MajorID = objRow[convTeachingCaseResCaseRelaInfo.MajorID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.MajorID].ToString().Trim(); //专业ID
objvTeachingCaseResCaseRelaInfoEN.MajorName = objRow[convTeachingCaseResCaseRelaInfo.MajorName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.MajorName].ToString().Trim(); //专业名称
objvTeachingCaseResCaseRelaInfoEN.CourseId = objRow[convTeachingCaseResCaseRelaInfo.CourseId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CourseId].ToString().Trim(); //课程Id
objvTeachingCaseResCaseRelaInfoEN.CourseCode = objRow[convTeachingCaseResCaseRelaInfo.CourseCode] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CourseCode].ToString().Trim(); //课程代码
objvTeachingCaseResCaseRelaInfoEN.CourseName = objRow[convTeachingCaseResCaseRelaInfo.CourseName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CourseName].ToString().Trim(); //课程名称
objvTeachingCaseResCaseRelaInfoEN.IdResource = objRow[convTeachingCaseResCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvTeachingCaseResCaseRelaInfoEN.ResourceID = objRow[convTeachingCaseResCaseRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvTeachingCaseResCaseRelaInfoEN.IdFtpResource = objRow[convTeachingCaseResCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvTeachingCaseResCaseRelaInfoEN.IdFile = objRow[convTeachingCaseResCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvTeachingCaseResCaseRelaInfoEN.FileName = objRow[convTeachingCaseResCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvTeachingCaseResCaseRelaInfoEN.FileType = objRow[convTeachingCaseResCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvTeachingCaseResCaseRelaInfoEN.SaveDate = objRow[convTeachingCaseResCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvTeachingCaseResCaseRelaInfoEN.FileSize = objRow[convTeachingCaseResCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvTeachingCaseResCaseRelaInfoEN.SaveTime = objRow[convTeachingCaseResCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvTeachingCaseResCaseRelaInfoEN.FtpResourceID = objRow[convTeachingCaseResCaseRelaInfo.FtpResourceID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvTeachingCaseResCaseRelaInfoEN.FileOriginalName = objRow[convTeachingCaseResCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvTeachingCaseResCaseRelaInfoEN.FileDirName = objRow[convTeachingCaseResCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvTeachingCaseResCaseRelaInfoEN.FileRename = objRow[convTeachingCaseResCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvTeachingCaseResCaseRelaInfoEN.FileUpDate = objRow[convTeachingCaseResCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvTeachingCaseResCaseRelaInfoEN.FileUpTime = objRow[convTeachingCaseResCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvTeachingCaseResCaseRelaInfoEN.SaveMode = TransNullToBool(objRow[convTeachingCaseResCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvTeachingCaseResCaseRelaInfoEN.IdResourceType = objRow[convTeachingCaseResCaseRelaInfo.IdResourceType] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvTeachingCaseResCaseRelaInfoEN.ResourceTypeID = objRow[convTeachingCaseResCaseRelaInfo.ResourceTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvTeachingCaseResCaseRelaInfoEN.ResourceTypeName = objRow[convTeachingCaseResCaseRelaInfo.ResourceTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvTeachingCaseResCaseRelaInfoEN.ResourceOwner = objRow[convTeachingCaseResCaseRelaInfo.ResourceOwner] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvTeachingCaseResCaseRelaInfoEN.ftpFileType = objRow[convTeachingCaseResCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachingCaseResCaseRelaInfoEN.ftpFileSize = objRow[convTeachingCaseResCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvTeachingCaseResCaseRelaInfoEN.ftpResourceOwner = objRow[convTeachingCaseResCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvTeachingCaseResCaseRelaInfoEN.FileOriginName = objRow[convTeachingCaseResCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvTeachingCaseResCaseRelaInfoEN.IsExistFile = TransNullToBool(objRow[convTeachingCaseResCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvTeachingCaseResCaseRelaInfoEN.FileNewName = objRow[convTeachingCaseResCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvTeachingCaseResCaseRelaInfoEN.FileOldName = objRow[convTeachingCaseResCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvTeachingCaseResCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfoType] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvTeachingCaseResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objvTeachingCaseResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvTeachingCaseResCaseRelaInfoEN.IsVisible = TransNullToBool(objRow[convTeachingCaseResCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvTeachingCaseResCaseRelaInfoEN.BrowseCount = objRow[convTeachingCaseResCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvTeachingCaseResCaseRelaInfoEN.Flag = objRow[convTeachingCaseResCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.Flag].ToString().Trim(); //标志
objvTeachingCaseResCaseRelaInfoEN.UpdDate = objRow[convTeachingCaseResCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvTeachingCaseResCaseRelaInfoEN.UpdUser = objRow[convTeachingCaseResCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objvTeachingCaseResCaseRelaInfoEN.Memo = objRow[convTeachingCaseResCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvTeachingCaseResCaseRelaInfoDA: GetObjByDataRow)", objException.Message));
}
objvTeachingCaseResCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvTeachingCaseResCaseRelaInfoEN;
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
objSQL = clsvTeachingCaseResCaseRelaInfoDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvTeachingCaseResCaseRelaInfoEN._CurrTabName, convTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfo, 8, "");
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
objSQL = clsvTeachingCaseResCaseRelaInfoDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvTeachingCaseResCaseRelaInfoEN._CurrTabName, convTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfo, 8, strPrefix);
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
 objSQL = clsvTeachingCaseResCaseRelaInfoDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdMicroTeachCaseRelaInfo from vTeachingCaseResCaseRelaInfo where " + strCondition;
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
 objSQL = clsvTeachingCaseResCaseRelaInfoDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdMicroTeachCaseRelaInfo from vTeachingCaseResCaseRelaInfo where " + strCondition;
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
 /// <param name = "lngIdMicroTeachCaseRelaInfo">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngIdMicroTeachCaseRelaInfo)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingCaseResCaseRelaInfoDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vTeachingCaseResCaseRelaInfo", "IdMicroTeachCaseRelaInfo = " + ""+ lngIdMicroTeachCaseRelaInfo+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvTeachingCaseResCaseRelaInfoDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingCaseResCaseRelaInfoDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vTeachingCaseResCaseRelaInfo", strCondition))
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
objSQL = clsvTeachingCaseResCaseRelaInfoDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vTeachingCaseResCaseRelaInfo");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoENS">源对象</param>
 /// <param name = "objvTeachingCaseResCaseRelaInfoENT">目标对象</param>
public void CopyTo(clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoENS, clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoENT)
{
objvTeachingCaseResCaseRelaInfoENT.IdMicroTeachCaseRelaInfo = objvTeachingCaseResCaseRelaInfoENS.IdMicroTeachCaseRelaInfo; //案例相关信息流水号
objvTeachingCaseResCaseRelaInfoENT.FuncModuleId = objvTeachingCaseResCaseRelaInfoENS.FuncModuleId; //功能模块Id
objvTeachingCaseResCaseRelaInfoENT.FuncModuleName = objvTeachingCaseResCaseRelaInfoENS.FuncModuleName; //功能模块名称
objvTeachingCaseResCaseRelaInfoENT.IdMicroteachCase = objvTeachingCaseResCaseRelaInfoENS.IdMicroteachCase; //微格教学案例流水号
objvTeachingCaseResCaseRelaInfoENT.IdTeachingCaseResCase = objvTeachingCaseResCaseRelaInfoENS.IdTeachingCaseResCase; //教学案例资源案例流水号
objvTeachingCaseResCaseRelaInfoENT.TeachingCaseResCaseName = objvTeachingCaseResCaseRelaInfoENS.TeachingCaseResCaseName; //教学案例资源案例名称
objvTeachingCaseResCaseRelaInfoENT.IdXzCollege = objvTeachingCaseResCaseRelaInfoENS.IdXzCollege; //学院流水号
objvTeachingCaseResCaseRelaInfoENT.CollegeID = objvTeachingCaseResCaseRelaInfoENS.CollegeID; //学院ID
objvTeachingCaseResCaseRelaInfoENT.CollegeName = objvTeachingCaseResCaseRelaInfoENS.CollegeName; //学院名称
objvTeachingCaseResCaseRelaInfoENT.CollegeNameA = objvTeachingCaseResCaseRelaInfoENS.CollegeNameA; //学院名称简写
objvTeachingCaseResCaseRelaInfoENT.MajorID = objvTeachingCaseResCaseRelaInfoENS.MajorID; //专业ID
objvTeachingCaseResCaseRelaInfoENT.MajorName = objvTeachingCaseResCaseRelaInfoENS.MajorName; //专业名称
objvTeachingCaseResCaseRelaInfoENT.CourseId = objvTeachingCaseResCaseRelaInfoENS.CourseId; //课程Id
objvTeachingCaseResCaseRelaInfoENT.CourseCode = objvTeachingCaseResCaseRelaInfoENS.CourseCode; //课程代码
objvTeachingCaseResCaseRelaInfoENT.CourseName = objvTeachingCaseResCaseRelaInfoENS.CourseName; //课程名称
objvTeachingCaseResCaseRelaInfoENT.IdResource = objvTeachingCaseResCaseRelaInfoENS.IdResource; //资源流水号
objvTeachingCaseResCaseRelaInfoENT.ResourceID = objvTeachingCaseResCaseRelaInfoENS.ResourceID; //资源ID
objvTeachingCaseResCaseRelaInfoENT.IdFtpResource = objvTeachingCaseResCaseRelaInfoENS.IdFtpResource; //FTP资源流水号
objvTeachingCaseResCaseRelaInfoENT.IdFile = objvTeachingCaseResCaseRelaInfoENS.IdFile; //文件流水号
objvTeachingCaseResCaseRelaInfoENT.FileName = objvTeachingCaseResCaseRelaInfoENS.FileName; //文件名称
objvTeachingCaseResCaseRelaInfoENT.FileType = objvTeachingCaseResCaseRelaInfoENS.FileType; //文件类型
objvTeachingCaseResCaseRelaInfoENT.SaveDate = objvTeachingCaseResCaseRelaInfoENS.SaveDate; //创建日期
objvTeachingCaseResCaseRelaInfoENT.FileSize = objvTeachingCaseResCaseRelaInfoENS.FileSize; //文件大小
objvTeachingCaseResCaseRelaInfoENT.SaveTime = objvTeachingCaseResCaseRelaInfoENS.SaveTime; //创建时间
objvTeachingCaseResCaseRelaInfoENT.FtpResourceID = objvTeachingCaseResCaseRelaInfoENS.FtpResourceID; //FTP资源ID
objvTeachingCaseResCaseRelaInfoENT.FileOriginalName = objvTeachingCaseResCaseRelaInfoENS.FileOriginalName; //文件原名
objvTeachingCaseResCaseRelaInfoENT.FileDirName = objvTeachingCaseResCaseRelaInfoENS.FileDirName; //文件目录名
objvTeachingCaseResCaseRelaInfoENT.FileRename = objvTeachingCaseResCaseRelaInfoENS.FileRename; //文件新名
objvTeachingCaseResCaseRelaInfoENT.FileUpDate = objvTeachingCaseResCaseRelaInfoENS.FileUpDate; //创建日期
objvTeachingCaseResCaseRelaInfoENT.FileUpTime = objvTeachingCaseResCaseRelaInfoENS.FileUpTime; //创建时间
objvTeachingCaseResCaseRelaInfoENT.SaveMode = objvTeachingCaseResCaseRelaInfoENS.SaveMode; //文件存放方式
objvTeachingCaseResCaseRelaInfoENT.IdResourceType = objvTeachingCaseResCaseRelaInfoENS.IdResourceType; //资源类型流水号
objvTeachingCaseResCaseRelaInfoENT.ResourceTypeID = objvTeachingCaseResCaseRelaInfoENS.ResourceTypeID; //资源类型ID
objvTeachingCaseResCaseRelaInfoENT.ResourceTypeName = objvTeachingCaseResCaseRelaInfoENS.ResourceTypeName; //资源类型名称
objvTeachingCaseResCaseRelaInfoENT.ResourceOwner = objvTeachingCaseResCaseRelaInfoENS.ResourceOwner; //上传者
objvTeachingCaseResCaseRelaInfoENT.ftpFileType = objvTeachingCaseResCaseRelaInfoENS.ftpFileType; //ftp文件类型
objvTeachingCaseResCaseRelaInfoENT.ftpFileSize = objvTeachingCaseResCaseRelaInfoENS.ftpFileSize; //ftp文件大小
objvTeachingCaseResCaseRelaInfoENT.ftpResourceOwner = objvTeachingCaseResCaseRelaInfoENS.ftpResourceOwner; //Ftp资源拥有者
objvTeachingCaseResCaseRelaInfoENT.FileOriginName = objvTeachingCaseResCaseRelaInfoENS.FileOriginName; //原文件名
objvTeachingCaseResCaseRelaInfoENT.IsExistFile = objvTeachingCaseResCaseRelaInfoENS.IsExistFile; //是否存在文件
objvTeachingCaseResCaseRelaInfoENT.FileNewName = objvTeachingCaseResCaseRelaInfoENS.FileNewName; //新文件名
objvTeachingCaseResCaseRelaInfoENT.FileOldName = objvTeachingCaseResCaseRelaInfoENS.FileOldName; //旧文件名
objvTeachingCaseResCaseRelaInfoENT.IdMicroTeachCaseRelaInfoType = objvTeachingCaseResCaseRelaInfoENS.IdMicroTeachCaseRelaInfoType; //微格案例相关信息类型流水号
objvTeachingCaseResCaseRelaInfoENT.MicroTeachCaseRelaInfoTypeID = objvTeachingCaseResCaseRelaInfoENS.MicroTeachCaseRelaInfoTypeID; //微格案例相关信息类型ID
objvTeachingCaseResCaseRelaInfoENT.MicroTeachCaseRelaInfoTypeName = objvTeachingCaseResCaseRelaInfoENS.MicroTeachCaseRelaInfoTypeName; //微格案例相关信息类型名称
objvTeachingCaseResCaseRelaInfoENT.IsVisible = objvTeachingCaseResCaseRelaInfoENS.IsVisible; //是否显示
objvTeachingCaseResCaseRelaInfoENT.BrowseCount = objvTeachingCaseResCaseRelaInfoENS.BrowseCount; //浏览次数
objvTeachingCaseResCaseRelaInfoENT.Flag = objvTeachingCaseResCaseRelaInfoENS.Flag; //标志
objvTeachingCaseResCaseRelaInfoENT.UpdDate = objvTeachingCaseResCaseRelaInfoENS.UpdDate; //修改日期
objvTeachingCaseResCaseRelaInfoENT.UpdUser = objvTeachingCaseResCaseRelaInfoENS.UpdUser; //修改人
objvTeachingCaseResCaseRelaInfoENT.Memo = objvTeachingCaseResCaseRelaInfoENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseRelaInfoEN.FuncModuleId, 4, convTeachingCaseResCaseRelaInfo.FuncModuleId);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseRelaInfoEN.FuncModuleName, 30, convTeachingCaseResCaseRelaInfo.FuncModuleName);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseRelaInfoEN.IdMicroteachCase, 8, convTeachingCaseResCaseRelaInfo.IdMicroteachCase);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseRelaInfoEN.IdTeachingCaseResCase, 8, convTeachingCaseResCaseRelaInfo.IdTeachingCaseResCase);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseRelaInfoEN.TeachingCaseResCaseName, 100, convTeachingCaseResCaseRelaInfo.TeachingCaseResCaseName);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseRelaInfoEN.IdXzCollege, 4, convTeachingCaseResCaseRelaInfo.IdXzCollege);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseRelaInfoEN.CollegeID, 4, convTeachingCaseResCaseRelaInfo.CollegeID);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseRelaInfoEN.CollegeName, 100, convTeachingCaseResCaseRelaInfo.CollegeName);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseRelaInfoEN.CollegeNameA, 12, convTeachingCaseResCaseRelaInfo.CollegeNameA);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseRelaInfoEN.MajorID, 4, convTeachingCaseResCaseRelaInfo.MajorID);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseRelaInfoEN.MajorName, 100, convTeachingCaseResCaseRelaInfo.MajorName);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseRelaInfoEN.CourseId, 8, convTeachingCaseResCaseRelaInfo.CourseId);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseRelaInfoEN.CourseCode, 20, convTeachingCaseResCaseRelaInfo.CourseCode);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseRelaInfoEN.CourseName, 100, convTeachingCaseResCaseRelaInfo.CourseName);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseRelaInfoEN.IdResource, 8, convTeachingCaseResCaseRelaInfo.IdResource);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseRelaInfoEN.ResourceID, 8, convTeachingCaseResCaseRelaInfo.ResourceID);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseRelaInfoEN.IdFtpResource, 8, convTeachingCaseResCaseRelaInfo.IdFtpResource);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseRelaInfoEN.IdFile, 8, convTeachingCaseResCaseRelaInfo.IdFile);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseRelaInfoEN.FileName, 500, convTeachingCaseResCaseRelaInfo.FileName);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseRelaInfoEN.FileType, 30, convTeachingCaseResCaseRelaInfo.FileType);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseRelaInfoEN.SaveDate, 8, convTeachingCaseResCaseRelaInfo.SaveDate);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseRelaInfoEN.FileSize, 50, convTeachingCaseResCaseRelaInfo.FileSize);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseRelaInfoEN.SaveTime, 6, convTeachingCaseResCaseRelaInfo.SaveTime);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseRelaInfoEN.FtpResourceID, 8, convTeachingCaseResCaseRelaInfo.FtpResourceID);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseRelaInfoEN.FileOriginalName, 200, convTeachingCaseResCaseRelaInfo.FileOriginalName);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseRelaInfoEN.FileDirName, 200, convTeachingCaseResCaseRelaInfo.FileDirName);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseRelaInfoEN.FileRename, 200, convTeachingCaseResCaseRelaInfo.FileRename);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseRelaInfoEN.FileUpDate, 8, convTeachingCaseResCaseRelaInfo.FileUpDate);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseRelaInfoEN.FileUpTime, 6, convTeachingCaseResCaseRelaInfo.FileUpTime);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseRelaInfoEN.IdResourceType, 4, convTeachingCaseResCaseRelaInfo.IdResourceType);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseRelaInfoEN.ResourceTypeID, 4, convTeachingCaseResCaseRelaInfo.ResourceTypeID);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseRelaInfoEN.ResourceTypeName, 50, convTeachingCaseResCaseRelaInfo.ResourceTypeName);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseRelaInfoEN.ResourceOwner, 50, convTeachingCaseResCaseRelaInfo.ResourceOwner);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseRelaInfoEN.ftpFileType, 30, convTeachingCaseResCaseRelaInfo.ftpFileType);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseRelaInfoEN.ftpFileSize, 50, convTeachingCaseResCaseRelaInfo.ftpFileSize);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseRelaInfoEN.ftpResourceOwner, 50, convTeachingCaseResCaseRelaInfo.ftpResourceOwner);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseRelaInfoEN.FileOriginName, 500, convTeachingCaseResCaseRelaInfo.FileOriginName);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseRelaInfoEN.FileNewName, 530, convTeachingCaseResCaseRelaInfo.FileNewName);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseRelaInfoEN.FileOldName, 530, convTeachingCaseResCaseRelaInfo.FileOldName);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType, 4, convTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfoType);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID, 4, convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName, 50, convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseRelaInfoEN.Flag, 50, convTeachingCaseResCaseRelaInfo.Flag);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseRelaInfoEN.UpdDate, 20, convTeachingCaseResCaseRelaInfo.UpdDate);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseRelaInfoEN.UpdUser, 20, convTeachingCaseResCaseRelaInfo.UpdUser);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseRelaInfoEN.Memo, 1000, convTeachingCaseResCaseRelaInfo.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseRelaInfoEN.FuncModuleId, convTeachingCaseResCaseRelaInfo.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseRelaInfoEN.FuncModuleName, convTeachingCaseResCaseRelaInfo.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseRelaInfoEN.IdMicroteachCase, convTeachingCaseResCaseRelaInfo.IdMicroteachCase);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseRelaInfoEN.IdTeachingCaseResCase, convTeachingCaseResCaseRelaInfo.IdTeachingCaseResCase);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseRelaInfoEN.TeachingCaseResCaseName, convTeachingCaseResCaseRelaInfo.TeachingCaseResCaseName);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseRelaInfoEN.IdXzCollege, convTeachingCaseResCaseRelaInfo.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseRelaInfoEN.CollegeID, convTeachingCaseResCaseRelaInfo.CollegeID);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseRelaInfoEN.CollegeName, convTeachingCaseResCaseRelaInfo.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseRelaInfoEN.CollegeNameA, convTeachingCaseResCaseRelaInfo.CollegeNameA);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseRelaInfoEN.MajorID, convTeachingCaseResCaseRelaInfo.MajorID);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseRelaInfoEN.MajorName, convTeachingCaseResCaseRelaInfo.MajorName);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseRelaInfoEN.CourseId, convTeachingCaseResCaseRelaInfo.CourseId);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseRelaInfoEN.CourseCode, convTeachingCaseResCaseRelaInfo.CourseCode);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseRelaInfoEN.CourseName, convTeachingCaseResCaseRelaInfo.CourseName);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseRelaInfoEN.IdResource, convTeachingCaseResCaseRelaInfo.IdResource);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseRelaInfoEN.ResourceID, convTeachingCaseResCaseRelaInfo.ResourceID);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseRelaInfoEN.IdFtpResource, convTeachingCaseResCaseRelaInfo.IdFtpResource);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseRelaInfoEN.IdFile, convTeachingCaseResCaseRelaInfo.IdFile);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseRelaInfoEN.FileName, convTeachingCaseResCaseRelaInfo.FileName);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseRelaInfoEN.FileType, convTeachingCaseResCaseRelaInfo.FileType);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseRelaInfoEN.SaveDate, convTeachingCaseResCaseRelaInfo.SaveDate);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseRelaInfoEN.FileSize, convTeachingCaseResCaseRelaInfo.FileSize);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseRelaInfoEN.SaveTime, convTeachingCaseResCaseRelaInfo.SaveTime);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseRelaInfoEN.FtpResourceID, convTeachingCaseResCaseRelaInfo.FtpResourceID);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseRelaInfoEN.FileOriginalName, convTeachingCaseResCaseRelaInfo.FileOriginalName);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseRelaInfoEN.FileDirName, convTeachingCaseResCaseRelaInfo.FileDirName);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseRelaInfoEN.FileRename, convTeachingCaseResCaseRelaInfo.FileRename);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseRelaInfoEN.FileUpDate, convTeachingCaseResCaseRelaInfo.FileUpDate);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseRelaInfoEN.FileUpTime, convTeachingCaseResCaseRelaInfo.FileUpTime);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseRelaInfoEN.IdResourceType, convTeachingCaseResCaseRelaInfo.IdResourceType);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseRelaInfoEN.ResourceTypeID, convTeachingCaseResCaseRelaInfo.ResourceTypeID);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseRelaInfoEN.ResourceTypeName, convTeachingCaseResCaseRelaInfo.ResourceTypeName);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseRelaInfoEN.ResourceOwner, convTeachingCaseResCaseRelaInfo.ResourceOwner);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseRelaInfoEN.ftpFileType, convTeachingCaseResCaseRelaInfo.ftpFileType);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseRelaInfoEN.ftpFileSize, convTeachingCaseResCaseRelaInfo.ftpFileSize);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseRelaInfoEN.ftpResourceOwner, convTeachingCaseResCaseRelaInfo.ftpResourceOwner);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseRelaInfoEN.FileOriginName, convTeachingCaseResCaseRelaInfo.FileOriginName);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseRelaInfoEN.FileNewName, convTeachingCaseResCaseRelaInfo.FileNewName);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseRelaInfoEN.FileOldName, convTeachingCaseResCaseRelaInfo.FileOldName);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType, convTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfoType);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID, convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName, convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseRelaInfoEN.Flag, convTeachingCaseResCaseRelaInfo.Flag);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseRelaInfoEN.UpdDate, convTeachingCaseResCaseRelaInfo.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseRelaInfoEN.UpdUser, convTeachingCaseResCaseRelaInfo.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseRelaInfoEN.Memo, convTeachingCaseResCaseRelaInfo.Memo);
//检查外键字段长度
 objvTeachingCaseResCaseRelaInfoEN._IsCheckProperty = true;
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
 objSQL = clsvTeachingCaseResCaseRelaInfoDA.GetSpecSQLObj();
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
 objSQL = clsvTeachingCaseResCaseRelaInfoDA.GetSpecSQLObj();
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
 objSQL = clsvTeachingCaseResCaseRelaInfoDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvTeachingCaseResCaseRelaInfoEN._CurrTabName);
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
 objSQL = clsvTeachingCaseResCaseRelaInfoDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvTeachingCaseResCaseRelaInfoEN._CurrTabName, strCondition);
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
 objSQL = clsvTeachingCaseResCaseRelaInfoDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}