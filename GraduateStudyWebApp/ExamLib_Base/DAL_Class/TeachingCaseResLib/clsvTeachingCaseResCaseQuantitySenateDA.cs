
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTeachingCaseResCaseQuantitySenateDA
 表名:vTeachingCaseResCaseQuantitySenate(01120450)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:50:08
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
 /// v教学案例资源量化评议(vTeachingCaseResCaseQuantitySenate)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvTeachingCaseResCaseQuantitySenateDA : clsCommBase4DA
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
 return clsvTeachingCaseResCaseQuantitySenateEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvTeachingCaseResCaseQuantitySenateEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvTeachingCaseResCaseQuantitySenateEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvTeachingCaseResCaseQuantitySenateEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvTeachingCaseResCaseQuantitySenateEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvTeachingCaseResCaseQuantitySenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingCaseResCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vTeachingCaseResCaseQuantitySenate where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vTeachingCaseResCaseQuantitySenate(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvTeachingCaseResCaseQuantitySenateDA: GetDataTable_vTeachingCaseResCaseQuantitySenate)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingCaseResCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vTeachingCaseResCaseQuantitySenate where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvTeachingCaseResCaseQuantitySenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingCaseResCaseQuantitySenateDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvTeachingCaseResCaseQuantitySenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingCaseResCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vTeachingCaseResCaseQuantitySenate where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvTeachingCaseResCaseQuantitySenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingCaseResCaseQuantitySenateDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvTeachingCaseResCaseQuantitySenateDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingCaseResCaseQuantitySenateDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vTeachingCaseResCaseQuantitySenate where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vTeachingCaseResCaseQuantitySenate where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvTeachingCaseResCaseQuantitySenateDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingCaseResCaseQuantitySenateDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vTeachingCaseResCaseQuantitySenate where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvTeachingCaseResCaseQuantitySenateDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingCaseResCaseQuantitySenateDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vTeachingCaseResCaseQuantitySenate.* from vTeachingCaseResCaseQuantitySenate Left Join {1} on {2} where {3} and vTeachingCaseResCaseQuantitySenate.IdmicroteachCaseQuantitySenate not in (Select top {5} vTeachingCaseResCaseQuantitySenate.IdmicroteachCaseQuantitySenate from vTeachingCaseResCaseQuantitySenate Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vTeachingCaseResCaseQuantitySenate where {1} and IdmicroteachCaseQuantitySenate not in (Select top {2} IdmicroteachCaseQuantitySenate from vTeachingCaseResCaseQuantitySenate where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vTeachingCaseResCaseQuantitySenate where {1} and IdmicroteachCaseQuantitySenate not in (Select top {3} IdmicroteachCaseQuantitySenate from vTeachingCaseResCaseQuantitySenate where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvTeachingCaseResCaseQuantitySenateDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingCaseResCaseQuantitySenateDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vTeachingCaseResCaseQuantitySenate.* from vTeachingCaseResCaseQuantitySenate Left Join {1} on {2} where {3} and vTeachingCaseResCaseQuantitySenate.IdmicroteachCaseQuantitySenate not in (Select top {5} vTeachingCaseResCaseQuantitySenate.IdmicroteachCaseQuantitySenate from vTeachingCaseResCaseQuantitySenate Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vTeachingCaseResCaseQuantitySenate where {1} and IdmicroteachCaseQuantitySenate not in (Select top {2} IdmicroteachCaseQuantitySenate from vTeachingCaseResCaseQuantitySenate where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vTeachingCaseResCaseQuantitySenate where {1} and IdmicroteachCaseQuantitySenate not in (Select top {3} IdmicroteachCaseQuantitySenate from vTeachingCaseResCaseQuantitySenate where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvTeachingCaseResCaseQuantitySenateEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvTeachingCaseResCaseQuantitySenateDA:GetObjLst)", objException.Message));
}
List<clsvTeachingCaseResCaseQuantitySenateEN> arrObjLst = new List<clsvTeachingCaseResCaseQuantitySenateEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingCaseResCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vTeachingCaseResCaseQuantitySenate where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN = new clsvTeachingCaseResCaseQuantitySenateEN();
try
{
objvTeachingCaseResCaseQuantitySenateEN.UserTypeName = objRow[convTeachingCaseResCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
objvTeachingCaseResCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convTeachingCaseResCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvTeachingCaseResCaseQuantitySenateEN.FuncModuleId = objRow[convTeachingCaseResCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvTeachingCaseResCaseQuantitySenateEN.FuncModuleName = objRow[convTeachingCaseResCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvTeachingCaseResCaseQuantitySenateEN.IdMicroteachCase = objRow[convTeachingCaseResCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvTeachingCaseResCaseQuantitySenateEN.IdTeachingCaseResCase = objRow[convTeachingCaseResCaseQuantitySenate.IdTeachingCaseResCase] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseID = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseName = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTheme = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTheme] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseDate = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTime = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTime] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseDateIn = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDateIn] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTimeIn = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTimeIn] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTypeName = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTypeName].ToString().Trim(); //教学案例资源案例类型名称
objvTeachingCaseResCaseQuantitySenateEN.OwnerId = objRow[convTeachingCaseResCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvTeachingCaseResCaseQuantitySenateEN.OwnerName = objRow[convTeachingCaseResCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvTeachingCaseResCaseQuantitySenateEN.OwnerNameWithId = objRow[convTeachingCaseResCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvTeachingCaseResCaseQuantitySenateEN.IsDualVideo = TransNullToBool(objRow[convTeachingCaseResCaseQuantitySenate.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachingCaseResCaseQuantitySenateEN.IdXzCollege = objRow[convTeachingCaseResCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingCaseResCaseQuantitySenateEN.CollegeID = objRow[convTeachingCaseResCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvTeachingCaseResCaseQuantitySenateEN.CollegeName = objRow[convTeachingCaseResCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvTeachingCaseResCaseQuantitySenateEN.IdXzMajor = objRow[convTeachingCaseResCaseQuantitySenate.IdXzMajor] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.IdXzMajor].ToString().Trim(); //专业流水号
objvTeachingCaseResCaseQuantitySenateEN.MajorID = objRow[convTeachingCaseResCaseQuantitySenate.MajorID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.MajorID].ToString().Trim(); //专业ID
objvTeachingCaseResCaseQuantitySenateEN.MajorName = objRow[convTeachingCaseResCaseQuantitySenate.MajorName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.MajorName].ToString().Trim(); //专业名称
objvTeachingCaseResCaseQuantitySenateEN.CourseId = objRow[convTeachingCaseResCaseQuantitySenate.CourseId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CourseId].ToString().Trim(); //课程Id
objvTeachingCaseResCaseQuantitySenateEN.CourseCode = objRow[convTeachingCaseResCaseQuantitySenate.CourseCode] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CourseCode].ToString().Trim(); //课程代码
objvTeachingCaseResCaseQuantitySenateEN.CourseName = objRow[convTeachingCaseResCaseQuantitySenate.CourseName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CourseName].ToString().Trim(); //课程名称
objvTeachingCaseResCaseQuantitySenateEN.ViewCount = objRow[convTeachingCaseResCaseQuantitySenate.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCaseQuantitySenate.ViewCount].ToString().Trim()); //浏览量
objvTeachingCaseResCaseQuantitySenateEN.IsShow = TransNullToBool(objRow[convTeachingCaseResCaseQuantitySenate.IsShow].ToString().Trim()); //是否启用
objvTeachingCaseResCaseQuantitySenateEN.DownloadNumber = objRow[convTeachingCaseResCaseQuantitySenate.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCaseQuantitySenate.DownloadNumber].ToString().Trim()); //下载数目
objvTeachingCaseResCaseQuantitySenateEN.FileIntegration = objRow[convTeachingCaseResCaseQuantitySenate.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCaseQuantitySenate.FileIntegration].ToString().Trim()); //文件积分
objvTeachingCaseResCaseQuantitySenateEN.LikeCount = objRow[convTeachingCaseResCaseQuantitySenate.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convTeachingCaseResCaseQuantitySenate.LikeCount].ToString().Trim()); //资源喜欢数量
objvTeachingCaseResCaseQuantitySenateEN.CollectionCount = objRow[convTeachingCaseResCaseQuantitySenate.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convTeachingCaseResCaseQuantitySenate.CollectionCount].ToString().Trim()); //收藏数量
objvTeachingCaseResCaseQuantitySenateEN.CollegeNameA = objRow[convTeachingCaseResCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachingCaseResCaseQuantitySenateEN.IdAppraiseType = objRow[convTeachingCaseResCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvTeachingCaseResCaseQuantitySenateEN.AppraiseTypeName = objRow[convTeachingCaseResCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvTeachingCaseResCaseQuantitySenateEN.SenateTheme = objRow[convTeachingCaseResCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvTeachingCaseResCaseQuantitySenateEN.SenateContent = objRow[convTeachingCaseResCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvTeachingCaseResCaseQuantitySenateEN.SenateTotalScore = TransNullToFloat(objRow[convTeachingCaseResCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvTeachingCaseResCaseQuantitySenateEN.SenateDate = objRow[convTeachingCaseResCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvTeachingCaseResCaseQuantitySenateEN.SenateTime = objRow[convTeachingCaseResCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvTeachingCaseResCaseQuantitySenateEN.SenateIp = objRow[convTeachingCaseResCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvTeachingCaseResCaseQuantitySenateEN.BrowseCount = objRow[convTeachingCaseResCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvTeachingCaseResCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convTeachingCaseResCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvTeachingCaseResCaseQuantitySenateEN.senateGaugeVersionID = objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvTeachingCaseResCaseQuantitySenateEN.senateGaugeVersionName = objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvTeachingCaseResCaseQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvTeachingCaseResCaseQuantitySenateEN.UserId = objRow[convTeachingCaseResCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvTeachingCaseResCaseQuantitySenateEN.UserNameWithUserId = objRow[convTeachingCaseResCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvTeachingCaseResCaseQuantitySenateEN.UserName = objRow[convTeachingCaseResCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvTeachingCaseResCaseQuantitySenateEN.UserKindId = objRow[convTeachingCaseResCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvTeachingCaseResCaseQuantitySenateEN.UserKindName = objRow[convTeachingCaseResCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvTeachingCaseResCaseQuantitySenateEN.UpdUser = objRow[convTeachingCaseResCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvTeachingCaseResCaseQuantitySenateEN.Memo = objRow[convTeachingCaseResCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.Memo].ToString().Trim(); //备注
objvTeachingCaseResCaseQuantitySenateEN.UpdUserName = objRow[convTeachingCaseResCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvTeachingCaseResCaseQuantitySenateDA: GetObjLst)", objException.Message));
}
objvTeachingCaseResCaseQuantitySenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvTeachingCaseResCaseQuantitySenateEN);
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
public List<clsvTeachingCaseResCaseQuantitySenateEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvTeachingCaseResCaseQuantitySenateDA:GetObjLstByTabName)", objException.Message));
}
List<clsvTeachingCaseResCaseQuantitySenateEN> arrObjLst = new List<clsvTeachingCaseResCaseQuantitySenateEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingCaseResCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN = new clsvTeachingCaseResCaseQuantitySenateEN();
try
{
objvTeachingCaseResCaseQuantitySenateEN.UserTypeName = objRow[convTeachingCaseResCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
objvTeachingCaseResCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convTeachingCaseResCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvTeachingCaseResCaseQuantitySenateEN.FuncModuleId = objRow[convTeachingCaseResCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvTeachingCaseResCaseQuantitySenateEN.FuncModuleName = objRow[convTeachingCaseResCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvTeachingCaseResCaseQuantitySenateEN.IdMicroteachCase = objRow[convTeachingCaseResCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvTeachingCaseResCaseQuantitySenateEN.IdTeachingCaseResCase = objRow[convTeachingCaseResCaseQuantitySenate.IdTeachingCaseResCase] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseID = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseName = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTheme = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTheme] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseDate = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTime = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTime] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseDateIn = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDateIn] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTimeIn = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTimeIn] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTypeName = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTypeName].ToString().Trim(); //教学案例资源案例类型名称
objvTeachingCaseResCaseQuantitySenateEN.OwnerId = objRow[convTeachingCaseResCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvTeachingCaseResCaseQuantitySenateEN.OwnerName = objRow[convTeachingCaseResCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvTeachingCaseResCaseQuantitySenateEN.OwnerNameWithId = objRow[convTeachingCaseResCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvTeachingCaseResCaseQuantitySenateEN.IsDualVideo = TransNullToBool(objRow[convTeachingCaseResCaseQuantitySenate.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachingCaseResCaseQuantitySenateEN.IdXzCollege = objRow[convTeachingCaseResCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingCaseResCaseQuantitySenateEN.CollegeID = objRow[convTeachingCaseResCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvTeachingCaseResCaseQuantitySenateEN.CollegeName = objRow[convTeachingCaseResCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvTeachingCaseResCaseQuantitySenateEN.IdXzMajor = objRow[convTeachingCaseResCaseQuantitySenate.IdXzMajor] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.IdXzMajor].ToString().Trim(); //专业流水号
objvTeachingCaseResCaseQuantitySenateEN.MajorID = objRow[convTeachingCaseResCaseQuantitySenate.MajorID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.MajorID].ToString().Trim(); //专业ID
objvTeachingCaseResCaseQuantitySenateEN.MajorName = objRow[convTeachingCaseResCaseQuantitySenate.MajorName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.MajorName].ToString().Trim(); //专业名称
objvTeachingCaseResCaseQuantitySenateEN.CourseId = objRow[convTeachingCaseResCaseQuantitySenate.CourseId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CourseId].ToString().Trim(); //课程Id
objvTeachingCaseResCaseQuantitySenateEN.CourseCode = objRow[convTeachingCaseResCaseQuantitySenate.CourseCode] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CourseCode].ToString().Trim(); //课程代码
objvTeachingCaseResCaseQuantitySenateEN.CourseName = objRow[convTeachingCaseResCaseQuantitySenate.CourseName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CourseName].ToString().Trim(); //课程名称
objvTeachingCaseResCaseQuantitySenateEN.ViewCount = objRow[convTeachingCaseResCaseQuantitySenate.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCaseQuantitySenate.ViewCount].ToString().Trim()); //浏览量
objvTeachingCaseResCaseQuantitySenateEN.IsShow = TransNullToBool(objRow[convTeachingCaseResCaseQuantitySenate.IsShow].ToString().Trim()); //是否启用
objvTeachingCaseResCaseQuantitySenateEN.DownloadNumber = objRow[convTeachingCaseResCaseQuantitySenate.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCaseQuantitySenate.DownloadNumber].ToString().Trim()); //下载数目
objvTeachingCaseResCaseQuantitySenateEN.FileIntegration = objRow[convTeachingCaseResCaseQuantitySenate.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCaseQuantitySenate.FileIntegration].ToString().Trim()); //文件积分
objvTeachingCaseResCaseQuantitySenateEN.LikeCount = objRow[convTeachingCaseResCaseQuantitySenate.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convTeachingCaseResCaseQuantitySenate.LikeCount].ToString().Trim()); //资源喜欢数量
objvTeachingCaseResCaseQuantitySenateEN.CollectionCount = objRow[convTeachingCaseResCaseQuantitySenate.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convTeachingCaseResCaseQuantitySenate.CollectionCount].ToString().Trim()); //收藏数量
objvTeachingCaseResCaseQuantitySenateEN.CollegeNameA = objRow[convTeachingCaseResCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachingCaseResCaseQuantitySenateEN.IdAppraiseType = objRow[convTeachingCaseResCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvTeachingCaseResCaseQuantitySenateEN.AppraiseTypeName = objRow[convTeachingCaseResCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvTeachingCaseResCaseQuantitySenateEN.SenateTheme = objRow[convTeachingCaseResCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvTeachingCaseResCaseQuantitySenateEN.SenateContent = objRow[convTeachingCaseResCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvTeachingCaseResCaseQuantitySenateEN.SenateTotalScore = TransNullToFloat(objRow[convTeachingCaseResCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvTeachingCaseResCaseQuantitySenateEN.SenateDate = objRow[convTeachingCaseResCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvTeachingCaseResCaseQuantitySenateEN.SenateTime = objRow[convTeachingCaseResCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvTeachingCaseResCaseQuantitySenateEN.SenateIp = objRow[convTeachingCaseResCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvTeachingCaseResCaseQuantitySenateEN.BrowseCount = objRow[convTeachingCaseResCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvTeachingCaseResCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convTeachingCaseResCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvTeachingCaseResCaseQuantitySenateEN.senateGaugeVersionID = objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvTeachingCaseResCaseQuantitySenateEN.senateGaugeVersionName = objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvTeachingCaseResCaseQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvTeachingCaseResCaseQuantitySenateEN.UserId = objRow[convTeachingCaseResCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvTeachingCaseResCaseQuantitySenateEN.UserNameWithUserId = objRow[convTeachingCaseResCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvTeachingCaseResCaseQuantitySenateEN.UserName = objRow[convTeachingCaseResCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvTeachingCaseResCaseQuantitySenateEN.UserKindId = objRow[convTeachingCaseResCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvTeachingCaseResCaseQuantitySenateEN.UserKindName = objRow[convTeachingCaseResCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvTeachingCaseResCaseQuantitySenateEN.UpdUser = objRow[convTeachingCaseResCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvTeachingCaseResCaseQuantitySenateEN.Memo = objRow[convTeachingCaseResCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.Memo].ToString().Trim(); //备注
objvTeachingCaseResCaseQuantitySenateEN.UpdUserName = objRow[convTeachingCaseResCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvTeachingCaseResCaseQuantitySenateDA: GetObjLst)", objException.Message));
}
objvTeachingCaseResCaseQuantitySenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvTeachingCaseResCaseQuantitySenateEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvTeachingCaseResCaseQuantitySenate(ref clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingCaseResCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vTeachingCaseResCaseQuantitySenate where IdmicroteachCaseQuantitySenate = " + ""+ objvTeachingCaseResCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvTeachingCaseResCaseQuantitySenateEN.UserTypeName = objDT.Rows[0][convTeachingCaseResCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称(字段类型:varchar,字段长度:20,是否可空:True)
 objvTeachingCaseResCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objDT.Rows[0][convTeachingCaseResCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvTeachingCaseResCaseQuantitySenateEN.FuncModuleId = objDT.Rows[0][convTeachingCaseResCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvTeachingCaseResCaseQuantitySenateEN.FuncModuleName = objDT.Rows[0][convTeachingCaseResCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvTeachingCaseResCaseQuantitySenateEN.IdMicroteachCase = objDT.Rows[0][convTeachingCaseResCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvTeachingCaseResCaseQuantitySenateEN.IdTeachingCaseResCase = objDT.Rows[0][convTeachingCaseResCaseQuantitySenate.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseID = objDT.Rows[0][convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseName = objDT.Rows[0][convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTheme = objDT.Rows[0][convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseDate = objDT.Rows[0][convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期(字段类型:char,字段长度:8,是否可空:True)
 objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTime = objDT.Rows[0][convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间(字段类型:char,字段长度:6,是否可空:True)
 objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseDateIn = objDT.Rows[0][convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTimeIn = objDT.Rows[0][convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTypeName = objDT.Rows[0][convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTypeName].ToString().Trim(); //教学案例资源案例类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvTeachingCaseResCaseQuantitySenateEN.OwnerId = objDT.Rows[0][convTeachingCaseResCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvTeachingCaseResCaseQuantitySenateEN.OwnerName = objDT.Rows[0][convTeachingCaseResCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvTeachingCaseResCaseQuantitySenateEN.OwnerNameWithId = objDT.Rows[0][convTeachingCaseResCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
 objvTeachingCaseResCaseQuantitySenateEN.IsDualVideo = TransNullToBool(objDT.Rows[0][convTeachingCaseResCaseQuantitySenate.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvTeachingCaseResCaseQuantitySenateEN.IdXzCollege = objDT.Rows[0][convTeachingCaseResCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvTeachingCaseResCaseQuantitySenateEN.CollegeID = objDT.Rows[0][convTeachingCaseResCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvTeachingCaseResCaseQuantitySenateEN.CollegeName = objDT.Rows[0][convTeachingCaseResCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvTeachingCaseResCaseQuantitySenateEN.IdXzMajor = objDT.Rows[0][convTeachingCaseResCaseQuantitySenate.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvTeachingCaseResCaseQuantitySenateEN.MajorID = objDT.Rows[0][convTeachingCaseResCaseQuantitySenate.MajorID].ToString().Trim(); //专业ID(字段类型:char,字段长度:4,是否可空:False)
 objvTeachingCaseResCaseQuantitySenateEN.MajorName = objDT.Rows[0][convTeachingCaseResCaseQuantitySenate.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvTeachingCaseResCaseQuantitySenateEN.CourseId = objDT.Rows[0][convTeachingCaseResCaseQuantitySenate.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvTeachingCaseResCaseQuantitySenateEN.CourseCode = objDT.Rows[0][convTeachingCaseResCaseQuantitySenate.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvTeachingCaseResCaseQuantitySenateEN.CourseName = objDT.Rows[0][convTeachingCaseResCaseQuantitySenate.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvTeachingCaseResCaseQuantitySenateEN.ViewCount = TransNullToInt(objDT.Rows[0][convTeachingCaseResCaseQuantitySenate.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvTeachingCaseResCaseQuantitySenateEN.IsShow = TransNullToBool(objDT.Rows[0][convTeachingCaseResCaseQuantitySenate.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objvTeachingCaseResCaseQuantitySenateEN.DownloadNumber = TransNullToInt(objDT.Rows[0][convTeachingCaseResCaseQuantitySenate.DownloadNumber].ToString().Trim()); //下载数目(字段类型:int,字段长度:4,是否可空:True)
 objvTeachingCaseResCaseQuantitySenateEN.FileIntegration = TransNullToInt(objDT.Rows[0][convTeachingCaseResCaseQuantitySenate.FileIntegration].ToString().Trim()); //文件积分(字段类型:int,字段长度:4,是否可空:True)
 objvTeachingCaseResCaseQuantitySenateEN.LikeCount = TransNullToInt(objDT.Rows[0][convTeachingCaseResCaseQuantitySenate.LikeCount].ToString().Trim()); //资源喜欢数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvTeachingCaseResCaseQuantitySenateEN.CollectionCount = TransNullToInt(objDT.Rows[0][convTeachingCaseResCaseQuantitySenate.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvTeachingCaseResCaseQuantitySenateEN.CollegeNameA = objDT.Rows[0][convTeachingCaseResCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvTeachingCaseResCaseQuantitySenateEN.IdAppraiseType = objDT.Rows[0][convTeachingCaseResCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvTeachingCaseResCaseQuantitySenateEN.AppraiseTypeName = objDT.Rows[0][convTeachingCaseResCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvTeachingCaseResCaseQuantitySenateEN.SenateTheme = objDT.Rows[0][convTeachingCaseResCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题(字段类型:varchar,字段长度:200,是否可空:True)
 objvTeachingCaseResCaseQuantitySenateEN.SenateContent = objDT.Rows[0][convTeachingCaseResCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvTeachingCaseResCaseQuantitySenateEN.SenateTotalScore = TransNullToFloat(objDT.Rows[0][convTeachingCaseResCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数(字段类型:float,字段长度:8,是否可空:False)
 objvTeachingCaseResCaseQuantitySenateEN.SenateDate = objDT.Rows[0][convTeachingCaseResCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期(字段类型:char,字段长度:8,是否可空:True)
 objvTeachingCaseResCaseQuantitySenateEN.SenateTime = objDT.Rows[0][convTeachingCaseResCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间(字段类型:char,字段长度:6,是否可空:True)
 objvTeachingCaseResCaseQuantitySenateEN.SenateIp = objDT.Rows[0][convTeachingCaseResCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip(字段类型:varchar,字段长度:50,是否可空:True)
 objvTeachingCaseResCaseQuantitySenateEN.BrowseCount = TransNullToInt(objDT.Rows[0][convTeachingCaseResCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvTeachingCaseResCaseQuantitySenateEN.IdSenateGaugeVersion = objDT.Rows[0][convTeachingCaseResCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvTeachingCaseResCaseQuantitySenateEN.senateGaugeVersionID = objDT.Rows[0][convTeachingCaseResCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvTeachingCaseResCaseQuantitySenateEN.senateGaugeVersionName = objDT.Rows[0][convTeachingCaseResCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvTeachingCaseResCaseQuantitySenateEN.senateGaugeVersionTtlScore = TransNullToFloat(objDT.Rows[0][convTeachingCaseResCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvTeachingCaseResCaseQuantitySenateEN.UserId = objDT.Rows[0][convTeachingCaseResCaseQuantitySenate.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvTeachingCaseResCaseQuantitySenateEN.UserNameWithUserId = objDT.Rows[0][convTeachingCaseResCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId(字段类型:varchar,字段长度:51,是否可空:False)
 objvTeachingCaseResCaseQuantitySenateEN.UserName = objDT.Rows[0][convTeachingCaseResCaseQuantitySenate.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvTeachingCaseResCaseQuantitySenateEN.UserKindId = objDT.Rows[0][convTeachingCaseResCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id(字段类型:char,字段长度:2,是否可空:False)
 objvTeachingCaseResCaseQuantitySenateEN.UserKindName = objDT.Rows[0][convTeachingCaseResCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名(字段类型:varchar,字段长度:30,是否可空:False)
 objvTeachingCaseResCaseQuantitySenateEN.UpdUser = objDT.Rows[0][convTeachingCaseResCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvTeachingCaseResCaseQuantitySenateEN.Memo = objDT.Rows[0][convTeachingCaseResCaseQuantitySenate.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvTeachingCaseResCaseQuantitySenateEN.UpdUserName = objDT.Rows[0][convTeachingCaseResCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName(字段类型:varchar,字段长度:20,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvTeachingCaseResCaseQuantitySenateDA: GetvTeachingCaseResCaseQuantitySenate)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdmicroteachCaseQuantitySenate">表关键字</param>
 /// <returns>表对象</returns>
public clsvTeachingCaseResCaseQuantitySenateEN GetObjByIdmicroteachCaseQuantitySenate(long lngIdmicroteachCaseQuantitySenate)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingCaseResCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vTeachingCaseResCaseQuantitySenate where IdmicroteachCaseQuantitySenate = " + ""+ lngIdmicroteachCaseQuantitySenate+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN = new clsvTeachingCaseResCaseQuantitySenateEN();
try
{
 objvTeachingCaseResCaseQuantitySenateEN.UserTypeName = objRow[convTeachingCaseResCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称(字段类型:varchar,字段长度:20,是否可空:True)
 objvTeachingCaseResCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convTeachingCaseResCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvTeachingCaseResCaseQuantitySenateEN.FuncModuleId = objRow[convTeachingCaseResCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvTeachingCaseResCaseQuantitySenateEN.FuncModuleName = objRow[convTeachingCaseResCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvTeachingCaseResCaseQuantitySenateEN.IdMicroteachCase = objRow[convTeachingCaseResCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvTeachingCaseResCaseQuantitySenateEN.IdTeachingCaseResCase = objRow[convTeachingCaseResCaseQuantitySenate.IdTeachingCaseResCase] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseID = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseName = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTheme = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTheme] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseDate = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期(字段类型:char,字段长度:8,是否可空:True)
 objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTime = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTime] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间(字段类型:char,字段长度:6,是否可空:True)
 objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseDateIn = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDateIn] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTimeIn = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTimeIn] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTypeName = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTypeName].ToString().Trim(); //教学案例资源案例类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvTeachingCaseResCaseQuantitySenateEN.OwnerId = objRow[convTeachingCaseResCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvTeachingCaseResCaseQuantitySenateEN.OwnerName = objRow[convTeachingCaseResCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvTeachingCaseResCaseQuantitySenateEN.OwnerNameWithId = objRow[convTeachingCaseResCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
 objvTeachingCaseResCaseQuantitySenateEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCaseQuantitySenate.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvTeachingCaseResCaseQuantitySenateEN.IdXzCollege = objRow[convTeachingCaseResCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvTeachingCaseResCaseQuantitySenateEN.CollegeID = objRow[convTeachingCaseResCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvTeachingCaseResCaseQuantitySenateEN.CollegeName = objRow[convTeachingCaseResCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvTeachingCaseResCaseQuantitySenateEN.IdXzMajor = objRow[convTeachingCaseResCaseQuantitySenate.IdXzMajor] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvTeachingCaseResCaseQuantitySenateEN.MajorID = objRow[convTeachingCaseResCaseQuantitySenate.MajorID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.MajorID].ToString().Trim(); //专业ID(字段类型:char,字段长度:4,是否可空:False)
 objvTeachingCaseResCaseQuantitySenateEN.MajorName = objRow[convTeachingCaseResCaseQuantitySenate.MajorName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvTeachingCaseResCaseQuantitySenateEN.CourseId = objRow[convTeachingCaseResCaseQuantitySenate.CourseId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvTeachingCaseResCaseQuantitySenateEN.CourseCode = objRow[convTeachingCaseResCaseQuantitySenate.CourseCode] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvTeachingCaseResCaseQuantitySenateEN.CourseName = objRow[convTeachingCaseResCaseQuantitySenate.CourseName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvTeachingCaseResCaseQuantitySenateEN.ViewCount = objRow[convTeachingCaseResCaseQuantitySenate.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseQuantitySenate.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvTeachingCaseResCaseQuantitySenateEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCaseQuantitySenate.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objvTeachingCaseResCaseQuantitySenateEN.DownloadNumber = objRow[convTeachingCaseResCaseQuantitySenate.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseQuantitySenate.DownloadNumber].ToString().Trim()); //下载数目(字段类型:int,字段长度:4,是否可空:True)
 objvTeachingCaseResCaseQuantitySenateEN.FileIntegration = objRow[convTeachingCaseResCaseQuantitySenate.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseQuantitySenate.FileIntegration].ToString().Trim()); //文件积分(字段类型:int,字段长度:4,是否可空:True)
 objvTeachingCaseResCaseQuantitySenateEN.LikeCount = objRow[convTeachingCaseResCaseQuantitySenate.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseQuantitySenate.LikeCount].ToString().Trim()); //资源喜欢数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvTeachingCaseResCaseQuantitySenateEN.CollectionCount = objRow[convTeachingCaseResCaseQuantitySenate.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseQuantitySenate.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvTeachingCaseResCaseQuantitySenateEN.CollegeNameA = objRow[convTeachingCaseResCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvTeachingCaseResCaseQuantitySenateEN.IdAppraiseType = objRow[convTeachingCaseResCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvTeachingCaseResCaseQuantitySenateEN.AppraiseTypeName = objRow[convTeachingCaseResCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvTeachingCaseResCaseQuantitySenateEN.SenateTheme = objRow[convTeachingCaseResCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题(字段类型:varchar,字段长度:200,是否可空:True)
 objvTeachingCaseResCaseQuantitySenateEN.SenateContent = objRow[convTeachingCaseResCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvTeachingCaseResCaseQuantitySenateEN.SenateTotalScore = Single.Parse(objRow[convTeachingCaseResCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数(字段类型:float,字段长度:8,是否可空:False)
 objvTeachingCaseResCaseQuantitySenateEN.SenateDate = objRow[convTeachingCaseResCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期(字段类型:char,字段长度:8,是否可空:True)
 objvTeachingCaseResCaseQuantitySenateEN.SenateTime = objRow[convTeachingCaseResCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间(字段类型:char,字段长度:6,是否可空:True)
 objvTeachingCaseResCaseQuantitySenateEN.SenateIp = objRow[convTeachingCaseResCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip(字段类型:varchar,字段长度:50,是否可空:True)
 objvTeachingCaseResCaseQuantitySenateEN.BrowseCount = objRow[convTeachingCaseResCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvTeachingCaseResCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convTeachingCaseResCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvTeachingCaseResCaseQuantitySenateEN.senateGaugeVersionID = objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvTeachingCaseResCaseQuantitySenateEN.senateGaugeVersionName = objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvTeachingCaseResCaseQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvTeachingCaseResCaseQuantitySenateEN.UserId = objRow[convTeachingCaseResCaseQuantitySenate.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvTeachingCaseResCaseQuantitySenateEN.UserNameWithUserId = objRow[convTeachingCaseResCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId(字段类型:varchar,字段长度:51,是否可空:False)
 objvTeachingCaseResCaseQuantitySenateEN.UserName = objRow[convTeachingCaseResCaseQuantitySenate.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvTeachingCaseResCaseQuantitySenateEN.UserKindId = objRow[convTeachingCaseResCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id(字段类型:char,字段长度:2,是否可空:False)
 objvTeachingCaseResCaseQuantitySenateEN.UserKindName = objRow[convTeachingCaseResCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名(字段类型:varchar,字段长度:30,是否可空:False)
 objvTeachingCaseResCaseQuantitySenateEN.UpdUser = objRow[convTeachingCaseResCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvTeachingCaseResCaseQuantitySenateEN.Memo = objRow[convTeachingCaseResCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvTeachingCaseResCaseQuantitySenateEN.UpdUserName = objRow[convTeachingCaseResCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName(字段类型:varchar,字段长度:20,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvTeachingCaseResCaseQuantitySenateDA: GetObjByIdmicroteachCaseQuantitySenate)", objException.Message));
}
return objvTeachingCaseResCaseQuantitySenateEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvTeachingCaseResCaseQuantitySenateEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvTeachingCaseResCaseQuantitySenateDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingCaseResCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vTeachingCaseResCaseQuantitySenate where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN = new clsvTeachingCaseResCaseQuantitySenateEN()
{
UserTypeName = objRow[convTeachingCaseResCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UserTypeName].ToString().Trim(), //用户类型名称
IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convTeachingCaseResCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()), //微格量化评价流水号
FuncModuleId = objRow[convTeachingCaseResCaseQuantitySenate.FuncModuleId].ToString().Trim(), //功能模块Id
FuncModuleName = objRow[convTeachingCaseResCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.FuncModuleName].ToString().Trim(), //功能模块名称
IdMicroteachCase = objRow[convTeachingCaseResCaseQuantitySenate.IdMicroteachCase].ToString().Trim(), //微格教学案例流水号
IdTeachingCaseResCase = objRow[convTeachingCaseResCaseQuantitySenate.IdTeachingCaseResCase] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.IdTeachingCaseResCase].ToString().Trim(), //教学案例资源案例流水号
TeachingCaseResCaseID = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseID].ToString().Trim(), //教学案例资源案例ID
TeachingCaseResCaseName = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseName].ToString().Trim(), //教学案例资源案例名称
TeachingCaseResCaseTheme = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTheme] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTheme].ToString().Trim(), //教学案例资源案例主题词
TeachingCaseResCaseDate = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDate].ToString().Trim(), //视频资源日期
TeachingCaseResCaseTime = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTime] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTime].ToString().Trim(), //视频资源时间
TeachingCaseResCaseDateIn = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDateIn] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDateIn].ToString().Trim(), //案例入库日期
TeachingCaseResCaseTimeIn = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTimeIn] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTimeIn].ToString().Trim(), //案例入库时间
TeachingCaseResCaseTypeName = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTypeName].ToString().Trim(), //教学案例资源案例类型名称
OwnerId = objRow[convTeachingCaseResCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.OwnerId].ToString().Trim(), //拥有者Id
OwnerName = objRow[convTeachingCaseResCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.OwnerName].ToString().Trim(), //拥有者姓名
OwnerNameWithId = objRow[convTeachingCaseResCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.OwnerNameWithId].ToString().Trim(), //拥有者名称附Id
IsDualVideo = TransNullToBool(objRow[convTeachingCaseResCaseQuantitySenate.IsDualVideo].ToString().Trim()), //是否双视频
IdXzCollege = objRow[convTeachingCaseResCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.IdXzCollege].ToString().Trim(), //学院流水号
CollegeID = objRow[convTeachingCaseResCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CollegeID].ToString().Trim(), //学院ID
CollegeName = objRow[convTeachingCaseResCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CollegeName].ToString().Trim(), //学院名称
IdXzMajor = objRow[convTeachingCaseResCaseQuantitySenate.IdXzMajor] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.IdXzMajor].ToString().Trim(), //专业流水号
MajorID = objRow[convTeachingCaseResCaseQuantitySenate.MajorID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.MajorID].ToString().Trim(), //专业ID
MajorName = objRow[convTeachingCaseResCaseQuantitySenate.MajorName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.MajorName].ToString().Trim(), //专业名称
CourseId = objRow[convTeachingCaseResCaseQuantitySenate.CourseId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CourseId].ToString().Trim(), //课程Id
CourseCode = objRow[convTeachingCaseResCaseQuantitySenate.CourseCode] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CourseCode].ToString().Trim(), //课程代码
CourseName = objRow[convTeachingCaseResCaseQuantitySenate.CourseName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CourseName].ToString().Trim(), //课程名称
ViewCount = objRow[convTeachingCaseResCaseQuantitySenate.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCaseQuantitySenate.ViewCount].ToString().Trim()), //浏览量
IsShow = TransNullToBool(objRow[convTeachingCaseResCaseQuantitySenate.IsShow].ToString().Trim()), //是否启用
DownloadNumber = objRow[convTeachingCaseResCaseQuantitySenate.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCaseQuantitySenate.DownloadNumber].ToString().Trim()), //下载数目
FileIntegration = objRow[convTeachingCaseResCaseQuantitySenate.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCaseQuantitySenate.FileIntegration].ToString().Trim()), //文件积分
LikeCount = objRow[convTeachingCaseResCaseQuantitySenate.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convTeachingCaseResCaseQuantitySenate.LikeCount].ToString().Trim()), //资源喜欢数量
CollectionCount = objRow[convTeachingCaseResCaseQuantitySenate.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convTeachingCaseResCaseQuantitySenate.CollectionCount].ToString().Trim()), //收藏数量
CollegeNameA = objRow[convTeachingCaseResCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CollegeNameA].ToString().Trim(), //学院名称简写
IdAppraiseType = objRow[convTeachingCaseResCaseQuantitySenate.IdAppraiseType].ToString().Trim(), //评议类型流水号
AppraiseTypeName = objRow[convTeachingCaseResCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.AppraiseTypeName].ToString().Trim(), //评议类型名称
SenateTheme = objRow[convTeachingCaseResCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.SenateTheme].ToString().Trim(), //量化评价主题
SenateContent = objRow[convTeachingCaseResCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.SenateContent].ToString().Trim(), //评价内容
SenateTotalScore = TransNullToFloat(objRow[convTeachingCaseResCaseQuantitySenate.SenateTotalScore].ToString().Trim()), //评价分数
SenateDate = objRow[convTeachingCaseResCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.SenateDate].ToString().Trim(), //评价日期
SenateTime = objRow[convTeachingCaseResCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.SenateTime].ToString().Trim(), //评价时间
SenateIp = objRow[convTeachingCaseResCaseQuantitySenate.SenateIp].ToString().Trim(), //评议Ip
BrowseCount = objRow[convTeachingCaseResCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCaseQuantitySenate.BrowseCount].ToString().Trim()), //浏览次数
IdSenateGaugeVersion = objRow[convTeachingCaseResCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(), //评价量表版本流水号
senateGaugeVersionID = objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(), //评价量表版本ID
senateGaugeVersionName = objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(), //评价量表版本名称
senateGaugeVersionTtlScore = objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()), //评价量表版本总分
UserId = objRow[convTeachingCaseResCaseQuantitySenate.UserId].ToString().Trim(), //用户ID
UserNameWithUserId = objRow[convTeachingCaseResCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UserNameWithUserId].ToString().Trim(), //UserNameWithUserId
UserName = objRow[convTeachingCaseResCaseQuantitySenate.UserName].ToString().Trim(), //用户名
UserKindId = objRow[convTeachingCaseResCaseQuantitySenate.UserKindId].ToString().Trim(), //用户类别Id
UserKindName = objRow[convTeachingCaseResCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UserKindName].ToString().Trim(), //用户类别名
UpdUser = objRow[convTeachingCaseResCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convTeachingCaseResCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.Memo].ToString().Trim(), //备注
UpdUserName = objRow[convTeachingCaseResCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UpdUserName].ToString().Trim() //UpdUserName
};
objvTeachingCaseResCaseQuantitySenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvTeachingCaseResCaseQuantitySenateEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvTeachingCaseResCaseQuantitySenateDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvTeachingCaseResCaseQuantitySenateEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN = new clsvTeachingCaseResCaseQuantitySenateEN();
try
{
objvTeachingCaseResCaseQuantitySenateEN.UserTypeName = objRow[convTeachingCaseResCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
objvTeachingCaseResCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convTeachingCaseResCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvTeachingCaseResCaseQuantitySenateEN.FuncModuleId = objRow[convTeachingCaseResCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvTeachingCaseResCaseQuantitySenateEN.FuncModuleName = objRow[convTeachingCaseResCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvTeachingCaseResCaseQuantitySenateEN.IdMicroteachCase = objRow[convTeachingCaseResCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvTeachingCaseResCaseQuantitySenateEN.IdTeachingCaseResCase = objRow[convTeachingCaseResCaseQuantitySenate.IdTeachingCaseResCase] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseID = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseName = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTheme = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTheme] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseDate = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTime = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTime] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseDateIn = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDateIn] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTimeIn = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTimeIn] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTypeName = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTypeName].ToString().Trim(); //教学案例资源案例类型名称
objvTeachingCaseResCaseQuantitySenateEN.OwnerId = objRow[convTeachingCaseResCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvTeachingCaseResCaseQuantitySenateEN.OwnerName = objRow[convTeachingCaseResCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvTeachingCaseResCaseQuantitySenateEN.OwnerNameWithId = objRow[convTeachingCaseResCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvTeachingCaseResCaseQuantitySenateEN.IsDualVideo = TransNullToBool(objRow[convTeachingCaseResCaseQuantitySenate.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachingCaseResCaseQuantitySenateEN.IdXzCollege = objRow[convTeachingCaseResCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingCaseResCaseQuantitySenateEN.CollegeID = objRow[convTeachingCaseResCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvTeachingCaseResCaseQuantitySenateEN.CollegeName = objRow[convTeachingCaseResCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvTeachingCaseResCaseQuantitySenateEN.IdXzMajor = objRow[convTeachingCaseResCaseQuantitySenate.IdXzMajor] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.IdXzMajor].ToString().Trim(); //专业流水号
objvTeachingCaseResCaseQuantitySenateEN.MajorID = objRow[convTeachingCaseResCaseQuantitySenate.MajorID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.MajorID].ToString().Trim(); //专业ID
objvTeachingCaseResCaseQuantitySenateEN.MajorName = objRow[convTeachingCaseResCaseQuantitySenate.MajorName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.MajorName].ToString().Trim(); //专业名称
objvTeachingCaseResCaseQuantitySenateEN.CourseId = objRow[convTeachingCaseResCaseQuantitySenate.CourseId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CourseId].ToString().Trim(); //课程Id
objvTeachingCaseResCaseQuantitySenateEN.CourseCode = objRow[convTeachingCaseResCaseQuantitySenate.CourseCode] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CourseCode].ToString().Trim(); //课程代码
objvTeachingCaseResCaseQuantitySenateEN.CourseName = objRow[convTeachingCaseResCaseQuantitySenate.CourseName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CourseName].ToString().Trim(); //课程名称
objvTeachingCaseResCaseQuantitySenateEN.ViewCount = objRow[convTeachingCaseResCaseQuantitySenate.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCaseQuantitySenate.ViewCount].ToString().Trim()); //浏览量
objvTeachingCaseResCaseQuantitySenateEN.IsShow = TransNullToBool(objRow[convTeachingCaseResCaseQuantitySenate.IsShow].ToString().Trim()); //是否启用
objvTeachingCaseResCaseQuantitySenateEN.DownloadNumber = objRow[convTeachingCaseResCaseQuantitySenate.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCaseQuantitySenate.DownloadNumber].ToString().Trim()); //下载数目
objvTeachingCaseResCaseQuantitySenateEN.FileIntegration = objRow[convTeachingCaseResCaseQuantitySenate.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCaseQuantitySenate.FileIntegration].ToString().Trim()); //文件积分
objvTeachingCaseResCaseQuantitySenateEN.LikeCount = objRow[convTeachingCaseResCaseQuantitySenate.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convTeachingCaseResCaseQuantitySenate.LikeCount].ToString().Trim()); //资源喜欢数量
objvTeachingCaseResCaseQuantitySenateEN.CollectionCount = objRow[convTeachingCaseResCaseQuantitySenate.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convTeachingCaseResCaseQuantitySenate.CollectionCount].ToString().Trim()); //收藏数量
objvTeachingCaseResCaseQuantitySenateEN.CollegeNameA = objRow[convTeachingCaseResCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachingCaseResCaseQuantitySenateEN.IdAppraiseType = objRow[convTeachingCaseResCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvTeachingCaseResCaseQuantitySenateEN.AppraiseTypeName = objRow[convTeachingCaseResCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvTeachingCaseResCaseQuantitySenateEN.SenateTheme = objRow[convTeachingCaseResCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvTeachingCaseResCaseQuantitySenateEN.SenateContent = objRow[convTeachingCaseResCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvTeachingCaseResCaseQuantitySenateEN.SenateTotalScore = TransNullToFloat(objRow[convTeachingCaseResCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvTeachingCaseResCaseQuantitySenateEN.SenateDate = objRow[convTeachingCaseResCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvTeachingCaseResCaseQuantitySenateEN.SenateTime = objRow[convTeachingCaseResCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvTeachingCaseResCaseQuantitySenateEN.SenateIp = objRow[convTeachingCaseResCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvTeachingCaseResCaseQuantitySenateEN.BrowseCount = objRow[convTeachingCaseResCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvTeachingCaseResCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convTeachingCaseResCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvTeachingCaseResCaseQuantitySenateEN.senateGaugeVersionID = objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvTeachingCaseResCaseQuantitySenateEN.senateGaugeVersionName = objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvTeachingCaseResCaseQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvTeachingCaseResCaseQuantitySenateEN.UserId = objRow[convTeachingCaseResCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvTeachingCaseResCaseQuantitySenateEN.UserNameWithUserId = objRow[convTeachingCaseResCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvTeachingCaseResCaseQuantitySenateEN.UserName = objRow[convTeachingCaseResCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvTeachingCaseResCaseQuantitySenateEN.UserKindId = objRow[convTeachingCaseResCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvTeachingCaseResCaseQuantitySenateEN.UserKindName = objRow[convTeachingCaseResCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvTeachingCaseResCaseQuantitySenateEN.UpdUser = objRow[convTeachingCaseResCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvTeachingCaseResCaseQuantitySenateEN.Memo = objRow[convTeachingCaseResCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.Memo].ToString().Trim(); //备注
objvTeachingCaseResCaseQuantitySenateEN.UpdUserName = objRow[convTeachingCaseResCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvTeachingCaseResCaseQuantitySenateDA: GetObjByDataRowvTeachingCaseResCaseQuantitySenate)", objException.Message));
}
objvTeachingCaseResCaseQuantitySenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvTeachingCaseResCaseQuantitySenateEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvTeachingCaseResCaseQuantitySenateEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN = new clsvTeachingCaseResCaseQuantitySenateEN();
try
{
objvTeachingCaseResCaseQuantitySenateEN.UserTypeName = objRow[convTeachingCaseResCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
objvTeachingCaseResCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convTeachingCaseResCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvTeachingCaseResCaseQuantitySenateEN.FuncModuleId = objRow[convTeachingCaseResCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvTeachingCaseResCaseQuantitySenateEN.FuncModuleName = objRow[convTeachingCaseResCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvTeachingCaseResCaseQuantitySenateEN.IdMicroteachCase = objRow[convTeachingCaseResCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvTeachingCaseResCaseQuantitySenateEN.IdTeachingCaseResCase = objRow[convTeachingCaseResCaseQuantitySenate.IdTeachingCaseResCase] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseID = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseName = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTheme = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTheme] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseDate = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTime = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTime] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseDateIn = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDateIn] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTimeIn = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTimeIn] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTypeName = objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTypeName].ToString().Trim(); //教学案例资源案例类型名称
objvTeachingCaseResCaseQuantitySenateEN.OwnerId = objRow[convTeachingCaseResCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvTeachingCaseResCaseQuantitySenateEN.OwnerName = objRow[convTeachingCaseResCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvTeachingCaseResCaseQuantitySenateEN.OwnerNameWithId = objRow[convTeachingCaseResCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvTeachingCaseResCaseQuantitySenateEN.IsDualVideo = TransNullToBool(objRow[convTeachingCaseResCaseQuantitySenate.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachingCaseResCaseQuantitySenateEN.IdXzCollege = objRow[convTeachingCaseResCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingCaseResCaseQuantitySenateEN.CollegeID = objRow[convTeachingCaseResCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvTeachingCaseResCaseQuantitySenateEN.CollegeName = objRow[convTeachingCaseResCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvTeachingCaseResCaseQuantitySenateEN.IdXzMajor = objRow[convTeachingCaseResCaseQuantitySenate.IdXzMajor] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.IdXzMajor].ToString().Trim(); //专业流水号
objvTeachingCaseResCaseQuantitySenateEN.MajorID = objRow[convTeachingCaseResCaseQuantitySenate.MajorID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.MajorID].ToString().Trim(); //专业ID
objvTeachingCaseResCaseQuantitySenateEN.MajorName = objRow[convTeachingCaseResCaseQuantitySenate.MajorName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.MajorName].ToString().Trim(); //专业名称
objvTeachingCaseResCaseQuantitySenateEN.CourseId = objRow[convTeachingCaseResCaseQuantitySenate.CourseId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CourseId].ToString().Trim(); //课程Id
objvTeachingCaseResCaseQuantitySenateEN.CourseCode = objRow[convTeachingCaseResCaseQuantitySenate.CourseCode] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CourseCode].ToString().Trim(); //课程代码
objvTeachingCaseResCaseQuantitySenateEN.CourseName = objRow[convTeachingCaseResCaseQuantitySenate.CourseName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CourseName].ToString().Trim(); //课程名称
objvTeachingCaseResCaseQuantitySenateEN.ViewCount = objRow[convTeachingCaseResCaseQuantitySenate.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCaseQuantitySenate.ViewCount].ToString().Trim()); //浏览量
objvTeachingCaseResCaseQuantitySenateEN.IsShow = TransNullToBool(objRow[convTeachingCaseResCaseQuantitySenate.IsShow].ToString().Trim()); //是否启用
objvTeachingCaseResCaseQuantitySenateEN.DownloadNumber = objRow[convTeachingCaseResCaseQuantitySenate.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCaseQuantitySenate.DownloadNumber].ToString().Trim()); //下载数目
objvTeachingCaseResCaseQuantitySenateEN.FileIntegration = objRow[convTeachingCaseResCaseQuantitySenate.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCaseQuantitySenate.FileIntegration].ToString().Trim()); //文件积分
objvTeachingCaseResCaseQuantitySenateEN.LikeCount = objRow[convTeachingCaseResCaseQuantitySenate.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convTeachingCaseResCaseQuantitySenate.LikeCount].ToString().Trim()); //资源喜欢数量
objvTeachingCaseResCaseQuantitySenateEN.CollectionCount = objRow[convTeachingCaseResCaseQuantitySenate.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convTeachingCaseResCaseQuantitySenate.CollectionCount].ToString().Trim()); //收藏数量
objvTeachingCaseResCaseQuantitySenateEN.CollegeNameA = objRow[convTeachingCaseResCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachingCaseResCaseQuantitySenateEN.IdAppraiseType = objRow[convTeachingCaseResCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvTeachingCaseResCaseQuantitySenateEN.AppraiseTypeName = objRow[convTeachingCaseResCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvTeachingCaseResCaseQuantitySenateEN.SenateTheme = objRow[convTeachingCaseResCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvTeachingCaseResCaseQuantitySenateEN.SenateContent = objRow[convTeachingCaseResCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvTeachingCaseResCaseQuantitySenateEN.SenateTotalScore = TransNullToFloat(objRow[convTeachingCaseResCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvTeachingCaseResCaseQuantitySenateEN.SenateDate = objRow[convTeachingCaseResCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvTeachingCaseResCaseQuantitySenateEN.SenateTime = objRow[convTeachingCaseResCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvTeachingCaseResCaseQuantitySenateEN.SenateIp = objRow[convTeachingCaseResCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvTeachingCaseResCaseQuantitySenateEN.BrowseCount = objRow[convTeachingCaseResCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvTeachingCaseResCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convTeachingCaseResCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvTeachingCaseResCaseQuantitySenateEN.senateGaugeVersionID = objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvTeachingCaseResCaseQuantitySenateEN.senateGaugeVersionName = objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvTeachingCaseResCaseQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convTeachingCaseResCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvTeachingCaseResCaseQuantitySenateEN.UserId = objRow[convTeachingCaseResCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvTeachingCaseResCaseQuantitySenateEN.UserNameWithUserId = objRow[convTeachingCaseResCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvTeachingCaseResCaseQuantitySenateEN.UserName = objRow[convTeachingCaseResCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvTeachingCaseResCaseQuantitySenateEN.UserKindId = objRow[convTeachingCaseResCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvTeachingCaseResCaseQuantitySenateEN.UserKindName = objRow[convTeachingCaseResCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvTeachingCaseResCaseQuantitySenateEN.UpdUser = objRow[convTeachingCaseResCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvTeachingCaseResCaseQuantitySenateEN.Memo = objRow[convTeachingCaseResCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.Memo].ToString().Trim(); //备注
objvTeachingCaseResCaseQuantitySenateEN.UpdUserName = objRow[convTeachingCaseResCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvTeachingCaseResCaseQuantitySenateDA: GetObjByDataRow)", objException.Message));
}
objvTeachingCaseResCaseQuantitySenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvTeachingCaseResCaseQuantitySenateEN;
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
objSQL = clsvTeachingCaseResCaseQuantitySenateDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvTeachingCaseResCaseQuantitySenateEN._CurrTabName, convTeachingCaseResCaseQuantitySenate.IdmicroteachCaseQuantitySenate, 8, "");
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
objSQL = clsvTeachingCaseResCaseQuantitySenateDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvTeachingCaseResCaseQuantitySenateEN._CurrTabName, convTeachingCaseResCaseQuantitySenate.IdmicroteachCaseQuantitySenate, 8, strPrefix);
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
 objSQL = clsvTeachingCaseResCaseQuantitySenateDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdmicroteachCaseQuantitySenate from vTeachingCaseResCaseQuantitySenate where " + strCondition;
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
 objSQL = clsvTeachingCaseResCaseQuantitySenateDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdmicroteachCaseQuantitySenate from vTeachingCaseResCaseQuantitySenate where " + strCondition;
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
 /// <param name = "lngIdmicroteachCaseQuantitySenate">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngIdmicroteachCaseQuantitySenate)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingCaseResCaseQuantitySenateDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vTeachingCaseResCaseQuantitySenate", "IdmicroteachCaseQuantitySenate = " + ""+ lngIdmicroteachCaseQuantitySenate+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvTeachingCaseResCaseQuantitySenateDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingCaseResCaseQuantitySenateDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vTeachingCaseResCaseQuantitySenate", strCondition))
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
objSQL = clsvTeachingCaseResCaseQuantitySenateDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vTeachingCaseResCaseQuantitySenate");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateENS">源对象</param>
 /// <param name = "objvTeachingCaseResCaseQuantitySenateENT">目标对象</param>
public void CopyTo(clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateENS, clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateENT)
{
objvTeachingCaseResCaseQuantitySenateENT.UserTypeName = objvTeachingCaseResCaseQuantitySenateENS.UserTypeName; //用户类型名称
objvTeachingCaseResCaseQuantitySenateENT.IdmicroteachCaseQuantitySenate = objvTeachingCaseResCaseQuantitySenateENS.IdmicroteachCaseQuantitySenate; //微格量化评价流水号
objvTeachingCaseResCaseQuantitySenateENT.FuncModuleId = objvTeachingCaseResCaseQuantitySenateENS.FuncModuleId; //功能模块Id
objvTeachingCaseResCaseQuantitySenateENT.FuncModuleName = objvTeachingCaseResCaseQuantitySenateENS.FuncModuleName; //功能模块名称
objvTeachingCaseResCaseQuantitySenateENT.IdMicroteachCase = objvTeachingCaseResCaseQuantitySenateENS.IdMicroteachCase; //微格教学案例流水号
objvTeachingCaseResCaseQuantitySenateENT.IdTeachingCaseResCase = objvTeachingCaseResCaseQuantitySenateENS.IdTeachingCaseResCase; //教学案例资源案例流水号
objvTeachingCaseResCaseQuantitySenateENT.TeachingCaseResCaseID = objvTeachingCaseResCaseQuantitySenateENS.TeachingCaseResCaseID; //教学案例资源案例ID
objvTeachingCaseResCaseQuantitySenateENT.TeachingCaseResCaseName = objvTeachingCaseResCaseQuantitySenateENS.TeachingCaseResCaseName; //教学案例资源案例名称
objvTeachingCaseResCaseQuantitySenateENT.TeachingCaseResCaseTheme = objvTeachingCaseResCaseQuantitySenateENS.TeachingCaseResCaseTheme; //教学案例资源案例主题词
objvTeachingCaseResCaseQuantitySenateENT.TeachingCaseResCaseDate = objvTeachingCaseResCaseQuantitySenateENS.TeachingCaseResCaseDate; //视频资源日期
objvTeachingCaseResCaseQuantitySenateENT.TeachingCaseResCaseTime = objvTeachingCaseResCaseQuantitySenateENS.TeachingCaseResCaseTime; //视频资源时间
objvTeachingCaseResCaseQuantitySenateENT.TeachingCaseResCaseDateIn = objvTeachingCaseResCaseQuantitySenateENS.TeachingCaseResCaseDateIn; //案例入库日期
objvTeachingCaseResCaseQuantitySenateENT.TeachingCaseResCaseTimeIn = objvTeachingCaseResCaseQuantitySenateENS.TeachingCaseResCaseTimeIn; //案例入库时间
objvTeachingCaseResCaseQuantitySenateENT.TeachingCaseResCaseTypeName = objvTeachingCaseResCaseQuantitySenateENS.TeachingCaseResCaseTypeName; //教学案例资源案例类型名称
objvTeachingCaseResCaseQuantitySenateENT.OwnerId = objvTeachingCaseResCaseQuantitySenateENS.OwnerId; //拥有者Id
objvTeachingCaseResCaseQuantitySenateENT.OwnerName = objvTeachingCaseResCaseQuantitySenateENS.OwnerName; //拥有者姓名
objvTeachingCaseResCaseQuantitySenateENT.OwnerNameWithId = objvTeachingCaseResCaseQuantitySenateENS.OwnerNameWithId; //拥有者名称附Id
objvTeachingCaseResCaseQuantitySenateENT.IsDualVideo = objvTeachingCaseResCaseQuantitySenateENS.IsDualVideo; //是否双视频
objvTeachingCaseResCaseQuantitySenateENT.IdXzCollege = objvTeachingCaseResCaseQuantitySenateENS.IdXzCollege; //学院流水号
objvTeachingCaseResCaseQuantitySenateENT.CollegeID = objvTeachingCaseResCaseQuantitySenateENS.CollegeID; //学院ID
objvTeachingCaseResCaseQuantitySenateENT.CollegeName = objvTeachingCaseResCaseQuantitySenateENS.CollegeName; //学院名称
objvTeachingCaseResCaseQuantitySenateENT.IdXzMajor = objvTeachingCaseResCaseQuantitySenateENS.IdXzMajor; //专业流水号
objvTeachingCaseResCaseQuantitySenateENT.MajorID = objvTeachingCaseResCaseQuantitySenateENS.MajorID; //专业ID
objvTeachingCaseResCaseQuantitySenateENT.MajorName = objvTeachingCaseResCaseQuantitySenateENS.MajorName; //专业名称
objvTeachingCaseResCaseQuantitySenateENT.CourseId = objvTeachingCaseResCaseQuantitySenateENS.CourseId; //课程Id
objvTeachingCaseResCaseQuantitySenateENT.CourseCode = objvTeachingCaseResCaseQuantitySenateENS.CourseCode; //课程代码
objvTeachingCaseResCaseQuantitySenateENT.CourseName = objvTeachingCaseResCaseQuantitySenateENS.CourseName; //课程名称
objvTeachingCaseResCaseQuantitySenateENT.ViewCount = objvTeachingCaseResCaseQuantitySenateENS.ViewCount; //浏览量
objvTeachingCaseResCaseQuantitySenateENT.IsShow = objvTeachingCaseResCaseQuantitySenateENS.IsShow; //是否启用
objvTeachingCaseResCaseQuantitySenateENT.DownloadNumber = objvTeachingCaseResCaseQuantitySenateENS.DownloadNumber; //下载数目
objvTeachingCaseResCaseQuantitySenateENT.FileIntegration = objvTeachingCaseResCaseQuantitySenateENS.FileIntegration; //文件积分
objvTeachingCaseResCaseQuantitySenateENT.LikeCount = objvTeachingCaseResCaseQuantitySenateENS.LikeCount; //资源喜欢数量
objvTeachingCaseResCaseQuantitySenateENT.CollectionCount = objvTeachingCaseResCaseQuantitySenateENS.CollectionCount; //收藏数量
objvTeachingCaseResCaseQuantitySenateENT.CollegeNameA = objvTeachingCaseResCaseQuantitySenateENS.CollegeNameA; //学院名称简写
objvTeachingCaseResCaseQuantitySenateENT.IdAppraiseType = objvTeachingCaseResCaseQuantitySenateENS.IdAppraiseType; //评议类型流水号
objvTeachingCaseResCaseQuantitySenateENT.AppraiseTypeName = objvTeachingCaseResCaseQuantitySenateENS.AppraiseTypeName; //评议类型名称
objvTeachingCaseResCaseQuantitySenateENT.SenateTheme = objvTeachingCaseResCaseQuantitySenateENS.SenateTheme; //量化评价主题
objvTeachingCaseResCaseQuantitySenateENT.SenateContent = objvTeachingCaseResCaseQuantitySenateENS.SenateContent; //评价内容
objvTeachingCaseResCaseQuantitySenateENT.SenateTotalScore = objvTeachingCaseResCaseQuantitySenateENS.SenateTotalScore; //评价分数
objvTeachingCaseResCaseQuantitySenateENT.SenateDate = objvTeachingCaseResCaseQuantitySenateENS.SenateDate; //评价日期
objvTeachingCaseResCaseQuantitySenateENT.SenateTime = objvTeachingCaseResCaseQuantitySenateENS.SenateTime; //评价时间
objvTeachingCaseResCaseQuantitySenateENT.SenateIp = objvTeachingCaseResCaseQuantitySenateENS.SenateIp; //评议Ip
objvTeachingCaseResCaseQuantitySenateENT.BrowseCount = objvTeachingCaseResCaseQuantitySenateENS.BrowseCount; //浏览次数
objvTeachingCaseResCaseQuantitySenateENT.IdSenateGaugeVersion = objvTeachingCaseResCaseQuantitySenateENS.IdSenateGaugeVersion; //评价量表版本流水号
objvTeachingCaseResCaseQuantitySenateENT.senateGaugeVersionID = objvTeachingCaseResCaseQuantitySenateENS.senateGaugeVersionID; //评价量表版本ID
objvTeachingCaseResCaseQuantitySenateENT.senateGaugeVersionName = objvTeachingCaseResCaseQuantitySenateENS.senateGaugeVersionName; //评价量表版本名称
objvTeachingCaseResCaseQuantitySenateENT.senateGaugeVersionTtlScore = objvTeachingCaseResCaseQuantitySenateENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvTeachingCaseResCaseQuantitySenateENT.UserId = objvTeachingCaseResCaseQuantitySenateENS.UserId; //用户ID
objvTeachingCaseResCaseQuantitySenateENT.UserNameWithUserId = objvTeachingCaseResCaseQuantitySenateENS.UserNameWithUserId; //UserNameWithUserId
objvTeachingCaseResCaseQuantitySenateENT.UserName = objvTeachingCaseResCaseQuantitySenateENS.UserName; //用户名
objvTeachingCaseResCaseQuantitySenateENT.UserKindId = objvTeachingCaseResCaseQuantitySenateENS.UserKindId; //用户类别Id
objvTeachingCaseResCaseQuantitySenateENT.UserKindName = objvTeachingCaseResCaseQuantitySenateENS.UserKindName; //用户类别名
objvTeachingCaseResCaseQuantitySenateENT.UpdUser = objvTeachingCaseResCaseQuantitySenateENS.UpdUser; //修改人
objvTeachingCaseResCaseQuantitySenateENT.Memo = objvTeachingCaseResCaseQuantitySenateENS.Memo; //备注
objvTeachingCaseResCaseQuantitySenateENT.UpdUserName = objvTeachingCaseResCaseQuantitySenateENS.UpdUserName; //UpdUserName
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvTeachingCaseResCaseQuantitySenateEN objvTeachingCaseResCaseQuantitySenateEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseQuantitySenateEN.UserTypeName, 20, convTeachingCaseResCaseQuantitySenate.UserTypeName);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseQuantitySenateEN.FuncModuleId, 4, convTeachingCaseResCaseQuantitySenate.FuncModuleId);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseQuantitySenateEN.FuncModuleName, 30, convTeachingCaseResCaseQuantitySenate.FuncModuleName);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseQuantitySenateEN.IdMicroteachCase, 8, convTeachingCaseResCaseQuantitySenate.IdMicroteachCase);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseQuantitySenateEN.IdTeachingCaseResCase, 8, convTeachingCaseResCaseQuantitySenate.IdTeachingCaseResCase);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseID, 8, convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseID);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseName, 100, convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseName);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTheme, 200, convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTheme);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseDate, 8, convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDate);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTime, 6, convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTime);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseDateIn, 8, convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDateIn);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTimeIn, 6, convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTimeIn);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTypeName, 30, convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTypeName);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseQuantitySenateEN.OwnerId, 20, convTeachingCaseResCaseQuantitySenate.OwnerId);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseQuantitySenateEN.OwnerName, 30, convTeachingCaseResCaseQuantitySenate.OwnerName);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseQuantitySenateEN.OwnerNameWithId, 51, convTeachingCaseResCaseQuantitySenate.OwnerNameWithId);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseQuantitySenateEN.IdXzCollege, 4, convTeachingCaseResCaseQuantitySenate.IdXzCollege);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseQuantitySenateEN.CollegeID, 4, convTeachingCaseResCaseQuantitySenate.CollegeID);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseQuantitySenateEN.CollegeName, 100, convTeachingCaseResCaseQuantitySenate.CollegeName);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseQuantitySenateEN.IdXzMajor, 8, convTeachingCaseResCaseQuantitySenate.IdXzMajor);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseQuantitySenateEN.MajorID, 4, convTeachingCaseResCaseQuantitySenate.MajorID);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseQuantitySenateEN.MajorName, 100, convTeachingCaseResCaseQuantitySenate.MajorName);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseQuantitySenateEN.CourseId, 8, convTeachingCaseResCaseQuantitySenate.CourseId);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseQuantitySenateEN.CourseCode, 20, convTeachingCaseResCaseQuantitySenate.CourseCode);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseQuantitySenateEN.CourseName, 100, convTeachingCaseResCaseQuantitySenate.CourseName);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseQuantitySenateEN.CollegeNameA, 12, convTeachingCaseResCaseQuantitySenate.CollegeNameA);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseQuantitySenateEN.IdAppraiseType, 4, convTeachingCaseResCaseQuantitySenate.IdAppraiseType);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseQuantitySenateEN.AppraiseTypeName, 50, convTeachingCaseResCaseQuantitySenate.AppraiseTypeName);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseQuantitySenateEN.SenateTheme, 200, convTeachingCaseResCaseQuantitySenate.SenateTheme);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseQuantitySenateEN.SenateContent, 2000, convTeachingCaseResCaseQuantitySenate.SenateContent);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseQuantitySenateEN.SenateDate, 8, convTeachingCaseResCaseQuantitySenate.SenateDate);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseQuantitySenateEN.SenateTime, 6, convTeachingCaseResCaseQuantitySenate.SenateTime);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseQuantitySenateEN.SenateIp, 50, convTeachingCaseResCaseQuantitySenate.SenateIp);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseQuantitySenateEN.IdSenateGaugeVersion, 4, convTeachingCaseResCaseQuantitySenate.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseQuantitySenateEN.senateGaugeVersionID, 4, convTeachingCaseResCaseQuantitySenate.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseQuantitySenateEN.senateGaugeVersionName, 200, convTeachingCaseResCaseQuantitySenate.senateGaugeVersionName);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseQuantitySenateEN.UserId, 18, convTeachingCaseResCaseQuantitySenate.UserId);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseQuantitySenateEN.UserNameWithUserId, 51, convTeachingCaseResCaseQuantitySenate.UserNameWithUserId);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseQuantitySenateEN.UserName, 30, convTeachingCaseResCaseQuantitySenate.UserName);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseQuantitySenateEN.UserKindId, 2, convTeachingCaseResCaseQuantitySenate.UserKindId);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseQuantitySenateEN.UserKindName, 30, convTeachingCaseResCaseQuantitySenate.UserKindName);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseQuantitySenateEN.UpdUser, 20, convTeachingCaseResCaseQuantitySenate.UpdUser);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseQuantitySenateEN.Memo, 1000, convTeachingCaseResCaseQuantitySenate.Memo);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseQuantitySenateEN.UpdUserName, 20, convTeachingCaseResCaseQuantitySenate.UpdUserName);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseQuantitySenateEN.UserTypeName, convTeachingCaseResCaseQuantitySenate.UserTypeName);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseQuantitySenateEN.FuncModuleId, convTeachingCaseResCaseQuantitySenate.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseQuantitySenateEN.FuncModuleName, convTeachingCaseResCaseQuantitySenate.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseQuantitySenateEN.IdMicroteachCase, convTeachingCaseResCaseQuantitySenate.IdMicroteachCase);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseQuantitySenateEN.IdTeachingCaseResCase, convTeachingCaseResCaseQuantitySenate.IdTeachingCaseResCase);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseID, convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseID);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseName, convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseName);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTheme, convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTheme);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseDate, convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDate);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTime, convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTime);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseDateIn, convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDateIn);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTimeIn, convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTimeIn);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseQuantitySenateEN.TeachingCaseResCaseTypeName, convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseQuantitySenateEN.OwnerId, convTeachingCaseResCaseQuantitySenate.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseQuantitySenateEN.OwnerName, convTeachingCaseResCaseQuantitySenate.OwnerName);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseQuantitySenateEN.OwnerNameWithId, convTeachingCaseResCaseQuantitySenate.OwnerNameWithId);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseQuantitySenateEN.IdXzCollege, convTeachingCaseResCaseQuantitySenate.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseQuantitySenateEN.CollegeID, convTeachingCaseResCaseQuantitySenate.CollegeID);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseQuantitySenateEN.CollegeName, convTeachingCaseResCaseQuantitySenate.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseQuantitySenateEN.IdXzMajor, convTeachingCaseResCaseQuantitySenate.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseQuantitySenateEN.MajorID, convTeachingCaseResCaseQuantitySenate.MajorID);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseQuantitySenateEN.MajorName, convTeachingCaseResCaseQuantitySenate.MajorName);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseQuantitySenateEN.CourseId, convTeachingCaseResCaseQuantitySenate.CourseId);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseQuantitySenateEN.CourseCode, convTeachingCaseResCaseQuantitySenate.CourseCode);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseQuantitySenateEN.CourseName, convTeachingCaseResCaseQuantitySenate.CourseName);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseQuantitySenateEN.CollegeNameA, convTeachingCaseResCaseQuantitySenate.CollegeNameA);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseQuantitySenateEN.IdAppraiseType, convTeachingCaseResCaseQuantitySenate.IdAppraiseType);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseQuantitySenateEN.AppraiseTypeName, convTeachingCaseResCaseQuantitySenate.AppraiseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseQuantitySenateEN.SenateTheme, convTeachingCaseResCaseQuantitySenate.SenateTheme);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseQuantitySenateEN.SenateContent, convTeachingCaseResCaseQuantitySenate.SenateContent);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseQuantitySenateEN.SenateDate, convTeachingCaseResCaseQuantitySenate.SenateDate);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseQuantitySenateEN.SenateTime, convTeachingCaseResCaseQuantitySenate.SenateTime);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseQuantitySenateEN.SenateIp, convTeachingCaseResCaseQuantitySenate.SenateIp);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseQuantitySenateEN.IdSenateGaugeVersion, convTeachingCaseResCaseQuantitySenate.IdSenateGaugeVersion);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseQuantitySenateEN.senateGaugeVersionID, convTeachingCaseResCaseQuantitySenate.senateGaugeVersionID);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseQuantitySenateEN.senateGaugeVersionName, convTeachingCaseResCaseQuantitySenate.senateGaugeVersionName);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseQuantitySenateEN.UserId, convTeachingCaseResCaseQuantitySenate.UserId);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseQuantitySenateEN.UserNameWithUserId, convTeachingCaseResCaseQuantitySenate.UserNameWithUserId);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseQuantitySenateEN.UserName, convTeachingCaseResCaseQuantitySenate.UserName);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseQuantitySenateEN.UserKindId, convTeachingCaseResCaseQuantitySenate.UserKindId);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseQuantitySenateEN.UserKindName, convTeachingCaseResCaseQuantitySenate.UserKindName);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseQuantitySenateEN.UpdUser, convTeachingCaseResCaseQuantitySenate.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseQuantitySenateEN.Memo, convTeachingCaseResCaseQuantitySenate.Memo);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseQuantitySenateEN.UpdUserName, convTeachingCaseResCaseQuantitySenate.UpdUserName);
//检查外键字段长度
 objvTeachingCaseResCaseQuantitySenateEN._IsCheckProperty = true;
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
 objSQL = clsvTeachingCaseResCaseQuantitySenateDA.GetSpecSQLObj();
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
 objSQL = clsvTeachingCaseResCaseQuantitySenateDA.GetSpecSQLObj();
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
 objSQL = clsvTeachingCaseResCaseQuantitySenateDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvTeachingCaseResCaseQuantitySenateEN._CurrTabName);
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
 objSQL = clsvTeachingCaseResCaseQuantitySenateDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvTeachingCaseResCaseQuantitySenateEN._CurrTabName, strCondition);
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
 objSQL = clsvTeachingCaseResCaseQuantitySenateDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}