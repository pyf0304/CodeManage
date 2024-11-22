
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMicroteachCase_Resource_Rel_BaseDA
 表名:vMicroteachCase_Resource_Rel_Base(01120490)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:47:30
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:微格教学评议(MicroTeachSenate)
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
 /// vMicroteachCase_Resource_Rel_Base(vMicroteachCase_Resource_Rel_Base)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvMicroteachCase_Resource_Rel_BaseDA : clsCommBase4DA
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
 return clsvMicroteachCase_Resource_Rel_BaseEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvMicroteachCase_Resource_Rel_BaseEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvMicroteachCase_Resource_Rel_BaseEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvMicroteachCase_Resource_Rel_BaseEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvMicroteachCase_Resource_Rel_BaseEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvMicroteachCase_Resource_Rel_BaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase_Resource_Rel_BaseDA.GetSpecSQLObj();
strSQL = "Select * from vMicroteachCase_Resource_Rel_Base where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vMicroteachCase_Resource_Rel_Base(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvMicroteachCase_Resource_Rel_BaseDA: GetDataTable_vMicroteachCase_Resource_Rel_Base)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase_Resource_Rel_BaseDA.GetSpecSQLObj();
strSQL = "Select * from vMicroteachCase_Resource_Rel_Base where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvMicroteachCase_Resource_Rel_BaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase_Resource_Rel_BaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvMicroteachCase_Resource_Rel_BaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase_Resource_Rel_BaseDA.GetSpecSQLObj();
strSQL = "Select * from vMicroteachCase_Resource_Rel_Base where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvMicroteachCase_Resource_Rel_BaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase_Resource_Rel_BaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvMicroteachCase_Resource_Rel_BaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase_Resource_Rel_BaseDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vMicroteachCase_Resource_Rel_Base where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vMicroteachCase_Resource_Rel_Base where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvMicroteachCase_Resource_Rel_BaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase_Resource_Rel_BaseDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vMicroteachCase_Resource_Rel_Base where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvMicroteachCase_Resource_Rel_BaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase_Resource_Rel_BaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vMicroteachCase_Resource_Rel_Base.* from vMicroteachCase_Resource_Rel_Base Left Join {1} on {2} where {3} and vMicroteachCase_Resource_Rel_Base.IdMicroteachCaseResourceRel not in (Select top {5} vMicroteachCase_Resource_Rel_Base.IdMicroteachCaseResourceRel from vMicroteachCase_Resource_Rel_Base Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vMicroteachCase_Resource_Rel_Base where {1} and IdMicroteachCaseResourceRel not in (Select top {2} IdMicroteachCaseResourceRel from vMicroteachCase_Resource_Rel_Base where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vMicroteachCase_Resource_Rel_Base where {1} and IdMicroteachCaseResourceRel not in (Select top {3} IdMicroteachCaseResourceRel from vMicroteachCase_Resource_Rel_Base where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvMicroteachCase_Resource_Rel_BaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase_Resource_Rel_BaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vMicroteachCase_Resource_Rel_Base.* from vMicroteachCase_Resource_Rel_Base Left Join {1} on {2} where {3} and vMicroteachCase_Resource_Rel_Base.IdMicroteachCaseResourceRel not in (Select top {5} vMicroteachCase_Resource_Rel_Base.IdMicroteachCaseResourceRel from vMicroteachCase_Resource_Rel_Base Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vMicroteachCase_Resource_Rel_Base where {1} and IdMicroteachCaseResourceRel not in (Select top {2} IdMicroteachCaseResourceRel from vMicroteachCase_Resource_Rel_Base where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vMicroteachCase_Resource_Rel_Base where {1} and IdMicroteachCaseResourceRel not in (Select top {3} IdMicroteachCaseResourceRel from vMicroteachCase_Resource_Rel_Base where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvMicroteachCase_Resource_Rel_BaseEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvMicroteachCase_Resource_Rel_BaseDA:GetObjLst)", objException.Message));
}
List<clsvMicroteachCase_Resource_Rel_BaseEN> arrObjLst = new List<clsvMicroteachCase_Resource_Rel_BaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase_Resource_Rel_BaseDA.GetSpecSQLObj();
strSQL = "Select * from vMicroteachCase_Resource_Rel_Base where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN = new clsvMicroteachCase_Resource_Rel_BaseEN();
try
{
objvMicroteachCase_Resource_Rel_BaseEN.IdMicroteachCaseResourceRel = TransNullToInt(objRow[convMicroteachCase_Resource_Rel_Base.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvMicroteachCase_Resource_Rel_BaseEN.FuncModuleId = objRow[convMicroteachCase_Resource_Rel_Base.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCase_Resource_Rel_BaseEN.FuncModuleName = objRow[convMicroteachCase_Resource_Rel_Base.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachCase_Resource_Rel_BaseEN.IdMicroteachCase = objRow[convMicroteachCase_Resource_Rel_Base.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase_Resource_Rel_BaseEN.IdResource = objRow[convMicroteachCase_Resource_Rel_Base.IdResource].ToString().Trim(); //资源流水号
objvMicroteachCase_Resource_Rel_BaseEN.ResourceID = objRow[convMicroteachCase_Resource_Rel_Base.ResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceID].ToString().Trim(); //资源ID
objvMicroteachCase_Resource_Rel_BaseEN.ResourceName = objRow[convMicroteachCase_Resource_Rel_Base.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceName].ToString().Trim(); //资源名称
objvMicroteachCase_Resource_Rel_BaseEN.IdFtpResource = objRow[convMicroteachCase_Resource_Rel_Base.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroteachCase_Resource_Rel_BaseEN.IdFile = objRow[convMicroteachCase_Resource_Rel_Base.IdFile] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.IdFile].ToString().Trim(); //文件流水号
objvMicroteachCase_Resource_Rel_BaseEN.FileName = objRow[convMicroteachCase_Resource_Rel_Base.FileName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileName].ToString().Trim(); //文件名称
objvMicroteachCase_Resource_Rel_BaseEN.FileType = objRow[convMicroteachCase_Resource_Rel_Base.FileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileType].ToString().Trim(); //文件类型
objvMicroteachCase_Resource_Rel_BaseEN.SaveDate = objRow[convMicroteachCase_Resource_Rel_Base.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.SaveDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel_BaseEN.FileSize = objRow[convMicroteachCase_Resource_Rel_Base.FileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileSize].ToString().Trim(); //文件大小
objvMicroteachCase_Resource_Rel_BaseEN.SaveTime = objRow[convMicroteachCase_Resource_Rel_Base.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.SaveTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel_BaseEN.FtpResourceID = objRow[convMicroteachCase_Resource_Rel_Base.FtpResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroteachCase_Resource_Rel_BaseEN.FileOriginalName = objRow[convMicroteachCase_Resource_Rel_Base.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileOriginalName].ToString().Trim(); //文件原名
objvMicroteachCase_Resource_Rel_BaseEN.FileDirName = objRow[convMicroteachCase_Resource_Rel_Base.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileDirName].ToString().Trim(); //文件目录名
objvMicroteachCase_Resource_Rel_BaseEN.FileRename = objRow[convMicroteachCase_Resource_Rel_Base.FileRename] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileRename].ToString().Trim(); //文件新名
objvMicroteachCase_Resource_Rel_BaseEN.FileUpDate = objRow[convMicroteachCase_Resource_Rel_Base.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileUpDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel_BaseEN.FileUpTime = objRow[convMicroteachCase_Resource_Rel_Base.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileUpTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel_BaseEN.SaveMode = TransNullToBool(objRow[convMicroteachCase_Resource_Rel_Base.SaveMode].ToString().Trim()); //文件存放方式
objvMicroteachCase_Resource_Rel_BaseEN.IdResourceType = objRow[convMicroteachCase_Resource_Rel_Base.IdResourceType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroteachCase_Resource_Rel_BaseEN.ResourceTypeID = objRow[convMicroteachCase_Resource_Rel_Base.ResourceTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroteachCase_Resource_Rel_BaseEN.ResourceTypeName = objRow[convMicroteachCase_Resource_Rel_Base.ResourceTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroteachCase_Resource_Rel_BaseEN.ResourceOwner = objRow[convMicroteachCase_Resource_Rel_Base.ResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceOwner].ToString().Trim(); //上传者
objvMicroteachCase_Resource_Rel_BaseEN.ftpFileType = objRow[convMicroteachCase_Resource_Rel_Base.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroteachCase_Resource_Rel_BaseEN.ftpFileSize = objRow[convMicroteachCase_Resource_Rel_Base.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroteachCase_Resource_Rel_BaseEN.ftpResourceOwner = objRow[convMicroteachCase_Resource_Rel_Base.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroteachCase_Resource_Rel_BaseEN.FileOriginName = objRow[convMicroteachCase_Resource_Rel_Base.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileOriginName].ToString().Trim(); //原文件名
objvMicroteachCase_Resource_Rel_BaseEN.IsExistFile = TransNullToBool(objRow[convMicroteachCase_Resource_Rel_Base.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroteachCase_Resource_Rel_BaseEN.FileNewName = objRow[convMicroteachCase_Resource_Rel_Base.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileNewName].ToString().Trim(); //新文件名
objvMicroteachCase_Resource_Rel_BaseEN.FileOldName = objRow[convMicroteachCase_Resource_Rel_Base.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileOldName].ToString().Trim(); //旧文件名
objvMicroteachCase_Resource_Rel_BaseEN.IsMain = TransNullToBool(objRow[convMicroteachCase_Resource_Rel_Base.IsMain].ToString().Trim()); //是否主资源
objvMicroteachCase_Resource_Rel_BaseEN.IdUsingMode = objRow[convMicroteachCase_Resource_Rel_Base.IdUsingMode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvMicroteachCase_Resource_Rel_BaseEN.IndexNO = objRow[convMicroteachCase_Resource_Rel_Base.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase_Resource_Rel_Base.IndexNO].ToString().Trim()); //序号
objvMicroteachCase_Resource_Rel_BaseEN.BrowseCount = objRow[convMicroteachCase_Resource_Rel_Base.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase_Resource_Rel_Base.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachCase_Resource_Rel_BaseEN.UpdDate = objRow[convMicroteachCase_Resource_Rel_Base.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.UpdDate].ToString().Trim(); //修改日期
objvMicroteachCase_Resource_Rel_BaseEN.UpdUser = objRow[convMicroteachCase_Resource_Rel_Base.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.UpdUser].ToString().Trim(); //修改人
objvMicroteachCase_Resource_Rel_BaseEN.Memo = objRow[convMicroteachCase_Resource_Rel_Base.Memo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvMicroteachCase_Resource_Rel_BaseDA: GetObjLst)", objException.Message));
}
objvMicroteachCase_Resource_Rel_BaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvMicroteachCase_Resource_Rel_BaseEN);
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
public List<clsvMicroteachCase_Resource_Rel_BaseEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvMicroteachCase_Resource_Rel_BaseDA:GetObjLstByTabName)", objException.Message));
}
List<clsvMicroteachCase_Resource_Rel_BaseEN> arrObjLst = new List<clsvMicroteachCase_Resource_Rel_BaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase_Resource_Rel_BaseDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN = new clsvMicroteachCase_Resource_Rel_BaseEN();
try
{
objvMicroteachCase_Resource_Rel_BaseEN.IdMicroteachCaseResourceRel = TransNullToInt(objRow[convMicroteachCase_Resource_Rel_Base.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvMicroteachCase_Resource_Rel_BaseEN.FuncModuleId = objRow[convMicroteachCase_Resource_Rel_Base.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCase_Resource_Rel_BaseEN.FuncModuleName = objRow[convMicroteachCase_Resource_Rel_Base.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachCase_Resource_Rel_BaseEN.IdMicroteachCase = objRow[convMicroteachCase_Resource_Rel_Base.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase_Resource_Rel_BaseEN.IdResource = objRow[convMicroteachCase_Resource_Rel_Base.IdResource].ToString().Trim(); //资源流水号
objvMicroteachCase_Resource_Rel_BaseEN.ResourceID = objRow[convMicroteachCase_Resource_Rel_Base.ResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceID].ToString().Trim(); //资源ID
objvMicroteachCase_Resource_Rel_BaseEN.ResourceName = objRow[convMicroteachCase_Resource_Rel_Base.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceName].ToString().Trim(); //资源名称
objvMicroteachCase_Resource_Rel_BaseEN.IdFtpResource = objRow[convMicroteachCase_Resource_Rel_Base.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroteachCase_Resource_Rel_BaseEN.IdFile = objRow[convMicroteachCase_Resource_Rel_Base.IdFile] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.IdFile].ToString().Trim(); //文件流水号
objvMicroteachCase_Resource_Rel_BaseEN.FileName = objRow[convMicroteachCase_Resource_Rel_Base.FileName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileName].ToString().Trim(); //文件名称
objvMicroteachCase_Resource_Rel_BaseEN.FileType = objRow[convMicroteachCase_Resource_Rel_Base.FileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileType].ToString().Trim(); //文件类型
objvMicroteachCase_Resource_Rel_BaseEN.SaveDate = objRow[convMicroteachCase_Resource_Rel_Base.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.SaveDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel_BaseEN.FileSize = objRow[convMicroteachCase_Resource_Rel_Base.FileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileSize].ToString().Trim(); //文件大小
objvMicroteachCase_Resource_Rel_BaseEN.SaveTime = objRow[convMicroteachCase_Resource_Rel_Base.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.SaveTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel_BaseEN.FtpResourceID = objRow[convMicroteachCase_Resource_Rel_Base.FtpResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroteachCase_Resource_Rel_BaseEN.FileOriginalName = objRow[convMicroteachCase_Resource_Rel_Base.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileOriginalName].ToString().Trim(); //文件原名
objvMicroteachCase_Resource_Rel_BaseEN.FileDirName = objRow[convMicroteachCase_Resource_Rel_Base.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileDirName].ToString().Trim(); //文件目录名
objvMicroteachCase_Resource_Rel_BaseEN.FileRename = objRow[convMicroteachCase_Resource_Rel_Base.FileRename] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileRename].ToString().Trim(); //文件新名
objvMicroteachCase_Resource_Rel_BaseEN.FileUpDate = objRow[convMicroteachCase_Resource_Rel_Base.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileUpDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel_BaseEN.FileUpTime = objRow[convMicroteachCase_Resource_Rel_Base.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileUpTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel_BaseEN.SaveMode = TransNullToBool(objRow[convMicroteachCase_Resource_Rel_Base.SaveMode].ToString().Trim()); //文件存放方式
objvMicroteachCase_Resource_Rel_BaseEN.IdResourceType = objRow[convMicroteachCase_Resource_Rel_Base.IdResourceType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroteachCase_Resource_Rel_BaseEN.ResourceTypeID = objRow[convMicroteachCase_Resource_Rel_Base.ResourceTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroteachCase_Resource_Rel_BaseEN.ResourceTypeName = objRow[convMicroteachCase_Resource_Rel_Base.ResourceTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroteachCase_Resource_Rel_BaseEN.ResourceOwner = objRow[convMicroteachCase_Resource_Rel_Base.ResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceOwner].ToString().Trim(); //上传者
objvMicroteachCase_Resource_Rel_BaseEN.ftpFileType = objRow[convMicroteachCase_Resource_Rel_Base.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroteachCase_Resource_Rel_BaseEN.ftpFileSize = objRow[convMicroteachCase_Resource_Rel_Base.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroteachCase_Resource_Rel_BaseEN.ftpResourceOwner = objRow[convMicroteachCase_Resource_Rel_Base.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroteachCase_Resource_Rel_BaseEN.FileOriginName = objRow[convMicroteachCase_Resource_Rel_Base.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileOriginName].ToString().Trim(); //原文件名
objvMicroteachCase_Resource_Rel_BaseEN.IsExistFile = TransNullToBool(objRow[convMicroteachCase_Resource_Rel_Base.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroteachCase_Resource_Rel_BaseEN.FileNewName = objRow[convMicroteachCase_Resource_Rel_Base.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileNewName].ToString().Trim(); //新文件名
objvMicroteachCase_Resource_Rel_BaseEN.FileOldName = objRow[convMicroteachCase_Resource_Rel_Base.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileOldName].ToString().Trim(); //旧文件名
objvMicroteachCase_Resource_Rel_BaseEN.IsMain = TransNullToBool(objRow[convMicroteachCase_Resource_Rel_Base.IsMain].ToString().Trim()); //是否主资源
objvMicroteachCase_Resource_Rel_BaseEN.IdUsingMode = objRow[convMicroteachCase_Resource_Rel_Base.IdUsingMode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvMicroteachCase_Resource_Rel_BaseEN.IndexNO = objRow[convMicroteachCase_Resource_Rel_Base.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase_Resource_Rel_Base.IndexNO].ToString().Trim()); //序号
objvMicroteachCase_Resource_Rel_BaseEN.BrowseCount = objRow[convMicroteachCase_Resource_Rel_Base.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase_Resource_Rel_Base.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachCase_Resource_Rel_BaseEN.UpdDate = objRow[convMicroteachCase_Resource_Rel_Base.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.UpdDate].ToString().Trim(); //修改日期
objvMicroteachCase_Resource_Rel_BaseEN.UpdUser = objRow[convMicroteachCase_Resource_Rel_Base.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.UpdUser].ToString().Trim(); //修改人
objvMicroteachCase_Resource_Rel_BaseEN.Memo = objRow[convMicroteachCase_Resource_Rel_Base.Memo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvMicroteachCase_Resource_Rel_BaseDA: GetObjLst)", objException.Message));
}
objvMicroteachCase_Resource_Rel_BaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvMicroteachCase_Resource_Rel_BaseEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvMicroteachCase_Resource_Rel_Base(ref clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase_Resource_Rel_BaseDA.GetSpecSQLObj();
strSQL = "Select * from vMicroteachCase_Resource_Rel_Base where IdMicroteachCaseResourceRel = " + ""+ objvMicroteachCase_Resource_Rel_BaseEN.IdMicroteachCaseResourceRel+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvMicroteachCase_Resource_Rel_BaseEN.IdMicroteachCaseResourceRel = TransNullToInt(objDT.Rows[0][convMicroteachCase_Resource_Rel_Base.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvMicroteachCase_Resource_Rel_BaseEN.FuncModuleId = objDT.Rows[0][convMicroteachCase_Resource_Rel_Base.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvMicroteachCase_Resource_Rel_BaseEN.FuncModuleName = objDT.Rows[0][convMicroteachCase_Resource_Rel_Base.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvMicroteachCase_Resource_Rel_BaseEN.IdMicroteachCase = objDT.Rows[0][convMicroteachCase_Resource_Rel_Base.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase_Resource_Rel_BaseEN.IdResource = objDT.Rows[0][convMicroteachCase_Resource_Rel_Base.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase_Resource_Rel_BaseEN.ResourceID = objDT.Rows[0][convMicroteachCase_Resource_Rel_Base.ResourceID].ToString().Trim(); //资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase_Resource_Rel_BaseEN.ResourceName = objDT.Rows[0][convMicroteachCase_Resource_Rel_Base.ResourceName].ToString().Trim(); //资源名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMicroteachCase_Resource_Rel_BaseEN.IdFtpResource = objDT.Rows[0][convMicroteachCase_Resource_Rel_Base.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCase_Resource_Rel_BaseEN.IdFile = objDT.Rows[0][convMicroteachCase_Resource_Rel_Base.IdFile].ToString().Trim(); //文件流水号(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCase_Resource_Rel_BaseEN.FileName = objDT.Rows[0][convMicroteachCase_Resource_Rel_Base.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvMicroteachCase_Resource_Rel_BaseEN.FileType = objDT.Rows[0][convMicroteachCase_Resource_Rel_Base.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvMicroteachCase_Resource_Rel_BaseEN.SaveDate = objDT.Rows[0][convMicroteachCase_Resource_Rel_Base.SaveDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCase_Resource_Rel_BaseEN.FileSize = objDT.Rows[0][convMicroteachCase_Resource_Rel_Base.FileSize].ToString().Trim(); //文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvMicroteachCase_Resource_Rel_BaseEN.SaveTime = objDT.Rows[0][convMicroteachCase_Resource_Rel_Base.SaveTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvMicroteachCase_Resource_Rel_BaseEN.FtpResourceID = objDT.Rows[0][convMicroteachCase_Resource_Rel_Base.FtpResourceID].ToString().Trim(); //FTP资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase_Resource_Rel_BaseEN.FileOriginalName = objDT.Rows[0][convMicroteachCase_Resource_Rel_Base.FileOriginalName].ToString().Trim(); //文件原名(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCase_Resource_Rel_BaseEN.FileDirName = objDT.Rows[0][convMicroteachCase_Resource_Rel_Base.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCase_Resource_Rel_BaseEN.FileRename = objDT.Rows[0][convMicroteachCase_Resource_Rel_Base.FileRename].ToString().Trim(); //文件新名(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCase_Resource_Rel_BaseEN.FileUpDate = objDT.Rows[0][convMicroteachCase_Resource_Rel_Base.FileUpDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCase_Resource_Rel_BaseEN.FileUpTime = objDT.Rows[0][convMicroteachCase_Resource_Rel_Base.FileUpTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvMicroteachCase_Resource_Rel_BaseEN.SaveMode = TransNullToBool(objDT.Rows[0][convMicroteachCase_Resource_Rel_Base.SaveMode].ToString().Trim()); //文件存放方式(字段类型:bit,字段长度:1,是否可空:True)
 objvMicroteachCase_Resource_Rel_BaseEN.IdResourceType = objDT.Rows[0][convMicroteachCase_Resource_Rel_Base.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase_Resource_Rel_BaseEN.ResourceTypeID = objDT.Rows[0][convMicroteachCase_Resource_Rel_Base.ResourceTypeID].ToString().Trim(); //资源类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase_Resource_Rel_BaseEN.ResourceTypeName = objDT.Rows[0][convMicroteachCase_Resource_Rel_Base.ResourceTypeName].ToString().Trim(); //资源类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCase_Resource_Rel_BaseEN.ResourceOwner = objDT.Rows[0][convMicroteachCase_Resource_Rel_Base.ResourceOwner].ToString().Trim(); //上传者(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCase_Resource_Rel_BaseEN.ftpFileType = objDT.Rows[0][convMicroteachCase_Resource_Rel_Base.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvMicroteachCase_Resource_Rel_BaseEN.ftpFileSize = objDT.Rows[0][convMicroteachCase_Resource_Rel_Base.ftpFileSize].ToString().Trim(); //ftp文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvMicroteachCase_Resource_Rel_BaseEN.ftpResourceOwner = objDT.Rows[0][convMicroteachCase_Resource_Rel_Base.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者(字段类型:varchar,字段长度:50,是否可空:True)
 objvMicroteachCase_Resource_Rel_BaseEN.FileOriginName = objDT.Rows[0][convMicroteachCase_Resource_Rel_Base.FileOriginName].ToString().Trim(); //原文件名(字段类型:varchar,字段长度:500,是否可空:True)
 objvMicroteachCase_Resource_Rel_BaseEN.IsExistFile = TransNullToBool(objDT.Rows[0][convMicroteachCase_Resource_Rel_Base.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objvMicroteachCase_Resource_Rel_BaseEN.FileNewName = objDT.Rows[0][convMicroteachCase_Resource_Rel_Base.FileNewName].ToString().Trim(); //新文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvMicroteachCase_Resource_Rel_BaseEN.FileOldName = objDT.Rows[0][convMicroteachCase_Resource_Rel_Base.FileOldName].ToString().Trim(); //旧文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvMicroteachCase_Resource_Rel_BaseEN.IsMain = TransNullToBool(objDT.Rows[0][convMicroteachCase_Resource_Rel_Base.IsMain].ToString().Trim()); //是否主资源(字段类型:bit,字段长度:1,是否可空:True)
 objvMicroteachCase_Resource_Rel_BaseEN.IdUsingMode = objDT.Rows[0][convMicroteachCase_Resource_Rel_Base.IdUsingMode].ToString().Trim(); //资源使用模式流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase_Resource_Rel_BaseEN.IndexNO = TransNullToInt(objDT.Rows[0][convMicroteachCase_Resource_Rel_Base.IndexNO].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvMicroteachCase_Resource_Rel_BaseEN.BrowseCount = TransNullToInt(objDT.Rows[0][convMicroteachCase_Resource_Rel_Base.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvMicroteachCase_Resource_Rel_BaseEN.UpdDate = objDT.Rows[0][convMicroteachCase_Resource_Rel_Base.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvMicroteachCase_Resource_Rel_BaseEN.UpdUser = objDT.Rows[0][convMicroteachCase_Resource_Rel_Base.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvMicroteachCase_Resource_Rel_BaseEN.Memo = objDT.Rows[0][convMicroteachCase_Resource_Rel_Base.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvMicroteachCase_Resource_Rel_BaseDA: GetvMicroteachCase_Resource_Rel_Base)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdMicroteachCaseResourceRel">表关键字</param>
 /// <returns>表对象</returns>
public clsvMicroteachCase_Resource_Rel_BaseEN GetObjByIdMicroteachCaseResourceRel(long lngIdMicroteachCaseResourceRel)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase_Resource_Rel_BaseDA.GetSpecSQLObj();
strSQL = "Select * from vMicroteachCase_Resource_Rel_Base where IdMicroteachCaseResourceRel = " + ""+ lngIdMicroteachCaseResourceRel+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN = new clsvMicroteachCase_Resource_Rel_BaseEN();
try
{
 objvMicroteachCase_Resource_Rel_BaseEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convMicroteachCase_Resource_Rel_Base.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvMicroteachCase_Resource_Rel_BaseEN.FuncModuleId = objRow[convMicroteachCase_Resource_Rel_Base.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvMicroteachCase_Resource_Rel_BaseEN.FuncModuleName = objRow[convMicroteachCase_Resource_Rel_Base.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvMicroteachCase_Resource_Rel_BaseEN.IdMicroteachCase = objRow[convMicroteachCase_Resource_Rel_Base.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase_Resource_Rel_BaseEN.IdResource = objRow[convMicroteachCase_Resource_Rel_Base.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase_Resource_Rel_BaseEN.ResourceID = objRow[convMicroteachCase_Resource_Rel_Base.ResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceID].ToString().Trim(); //资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase_Resource_Rel_BaseEN.ResourceName = objRow[convMicroteachCase_Resource_Rel_Base.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceName].ToString().Trim(); //资源名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMicroteachCase_Resource_Rel_BaseEN.IdFtpResource = objRow[convMicroteachCase_Resource_Rel_Base.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCase_Resource_Rel_BaseEN.IdFile = objRow[convMicroteachCase_Resource_Rel_Base.IdFile] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.IdFile].ToString().Trim(); //文件流水号(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCase_Resource_Rel_BaseEN.FileName = objRow[convMicroteachCase_Resource_Rel_Base.FileName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvMicroteachCase_Resource_Rel_BaseEN.FileType = objRow[convMicroteachCase_Resource_Rel_Base.FileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvMicroteachCase_Resource_Rel_BaseEN.SaveDate = objRow[convMicroteachCase_Resource_Rel_Base.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.SaveDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCase_Resource_Rel_BaseEN.FileSize = objRow[convMicroteachCase_Resource_Rel_Base.FileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileSize].ToString().Trim(); //文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvMicroteachCase_Resource_Rel_BaseEN.SaveTime = objRow[convMicroteachCase_Resource_Rel_Base.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.SaveTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvMicroteachCase_Resource_Rel_BaseEN.FtpResourceID = objRow[convMicroteachCase_Resource_Rel_Base.FtpResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FtpResourceID].ToString().Trim(); //FTP资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase_Resource_Rel_BaseEN.FileOriginalName = objRow[convMicroteachCase_Resource_Rel_Base.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileOriginalName].ToString().Trim(); //文件原名(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCase_Resource_Rel_BaseEN.FileDirName = objRow[convMicroteachCase_Resource_Rel_Base.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCase_Resource_Rel_BaseEN.FileRename = objRow[convMicroteachCase_Resource_Rel_Base.FileRename] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileRename].ToString().Trim(); //文件新名(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCase_Resource_Rel_BaseEN.FileUpDate = objRow[convMicroteachCase_Resource_Rel_Base.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileUpDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCase_Resource_Rel_BaseEN.FileUpTime = objRow[convMicroteachCase_Resource_Rel_Base.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileUpTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvMicroteachCase_Resource_Rel_BaseEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel_Base.SaveMode].ToString().Trim()); //文件存放方式(字段类型:bit,字段长度:1,是否可空:True)
 objvMicroteachCase_Resource_Rel_BaseEN.IdResourceType = objRow[convMicroteachCase_Resource_Rel_Base.IdResourceType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase_Resource_Rel_BaseEN.ResourceTypeID = objRow[convMicroteachCase_Resource_Rel_Base.ResourceTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceTypeID].ToString().Trim(); //资源类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase_Resource_Rel_BaseEN.ResourceTypeName = objRow[convMicroteachCase_Resource_Rel_Base.ResourceTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceTypeName].ToString().Trim(); //资源类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCase_Resource_Rel_BaseEN.ResourceOwner = objRow[convMicroteachCase_Resource_Rel_Base.ResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceOwner].ToString().Trim(); //上传者(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCase_Resource_Rel_BaseEN.ftpFileType = objRow[convMicroteachCase_Resource_Rel_Base.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvMicroteachCase_Resource_Rel_BaseEN.ftpFileSize = objRow[convMicroteachCase_Resource_Rel_Base.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ftpFileSize].ToString().Trim(); //ftp文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvMicroteachCase_Resource_Rel_BaseEN.ftpResourceOwner = objRow[convMicroteachCase_Resource_Rel_Base.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者(字段类型:varchar,字段长度:50,是否可空:True)
 objvMicroteachCase_Resource_Rel_BaseEN.FileOriginName = objRow[convMicroteachCase_Resource_Rel_Base.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileOriginName].ToString().Trim(); //原文件名(字段类型:varchar,字段长度:500,是否可空:True)
 objvMicroteachCase_Resource_Rel_BaseEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel_Base.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objvMicroteachCase_Resource_Rel_BaseEN.FileNewName = objRow[convMicroteachCase_Resource_Rel_Base.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileNewName].ToString().Trim(); //新文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvMicroteachCase_Resource_Rel_BaseEN.FileOldName = objRow[convMicroteachCase_Resource_Rel_Base.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileOldName].ToString().Trim(); //旧文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvMicroteachCase_Resource_Rel_BaseEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel_Base.IsMain].ToString().Trim()); //是否主资源(字段类型:bit,字段长度:1,是否可空:True)
 objvMicroteachCase_Resource_Rel_BaseEN.IdUsingMode = objRow[convMicroteachCase_Resource_Rel_Base.IdUsingMode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.IdUsingMode].ToString().Trim(); //资源使用模式流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase_Resource_Rel_BaseEN.IndexNO = objRow[convMicroteachCase_Resource_Rel_Base.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel_Base.IndexNO].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvMicroteachCase_Resource_Rel_BaseEN.BrowseCount = objRow[convMicroteachCase_Resource_Rel_Base.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel_Base.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvMicroteachCase_Resource_Rel_BaseEN.UpdDate = objRow[convMicroteachCase_Resource_Rel_Base.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvMicroteachCase_Resource_Rel_BaseEN.UpdUser = objRow[convMicroteachCase_Resource_Rel_Base.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvMicroteachCase_Resource_Rel_BaseEN.Memo = objRow[convMicroteachCase_Resource_Rel_Base.Memo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvMicroteachCase_Resource_Rel_BaseDA: GetObjByIdMicroteachCaseResourceRel)", objException.Message));
}
return objvMicroteachCase_Resource_Rel_BaseEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvMicroteachCase_Resource_Rel_BaseEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvMicroteachCase_Resource_Rel_BaseDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase_Resource_Rel_BaseDA.GetSpecSQLObj();
strSQL = "Select * from vMicroteachCase_Resource_Rel_Base where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN = new clsvMicroteachCase_Resource_Rel_BaseEN()
{
IdMicroteachCaseResourceRel = TransNullToInt(objRow[convMicroteachCase_Resource_Rel_Base.IdMicroteachCaseResourceRel].ToString().Trim()), //微格案例资源关系流水号
FuncModuleId = objRow[convMicroteachCase_Resource_Rel_Base.FuncModuleId].ToString().Trim(), //功能模块Id
FuncModuleName = objRow[convMicroteachCase_Resource_Rel_Base.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FuncModuleName].ToString().Trim(), //功能模块名称
IdMicroteachCase = objRow[convMicroteachCase_Resource_Rel_Base.IdMicroteachCase].ToString().Trim(), //微格教学案例流水号
IdResource = objRow[convMicroteachCase_Resource_Rel_Base.IdResource].ToString().Trim(), //资源流水号
ResourceID = objRow[convMicroteachCase_Resource_Rel_Base.ResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceID].ToString().Trim(), //资源ID
ResourceName = objRow[convMicroteachCase_Resource_Rel_Base.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceName].ToString().Trim(), //资源名称
IdFtpResource = objRow[convMicroteachCase_Resource_Rel_Base.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.IdFtpResource].ToString().Trim(), //FTP资源流水号
IdFile = objRow[convMicroteachCase_Resource_Rel_Base.IdFile] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.IdFile].ToString().Trim(), //文件流水号
FileName = objRow[convMicroteachCase_Resource_Rel_Base.FileName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileName].ToString().Trim(), //文件名称
FileType = objRow[convMicroteachCase_Resource_Rel_Base.FileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileType].ToString().Trim(), //文件类型
SaveDate = objRow[convMicroteachCase_Resource_Rel_Base.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.SaveDate].ToString().Trim(), //创建日期
FileSize = objRow[convMicroteachCase_Resource_Rel_Base.FileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileSize].ToString().Trim(), //文件大小
SaveTime = objRow[convMicroteachCase_Resource_Rel_Base.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.SaveTime].ToString().Trim(), //创建时间
FtpResourceID = objRow[convMicroteachCase_Resource_Rel_Base.FtpResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FtpResourceID].ToString().Trim(), //FTP资源ID
FileOriginalName = objRow[convMicroteachCase_Resource_Rel_Base.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileOriginalName].ToString().Trim(), //文件原名
FileDirName = objRow[convMicroteachCase_Resource_Rel_Base.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileDirName].ToString().Trim(), //文件目录名
FileRename = objRow[convMicroteachCase_Resource_Rel_Base.FileRename] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileRename].ToString().Trim(), //文件新名
FileUpDate = objRow[convMicroteachCase_Resource_Rel_Base.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileUpDate].ToString().Trim(), //创建日期
FileUpTime = objRow[convMicroteachCase_Resource_Rel_Base.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileUpTime].ToString().Trim(), //创建时间
SaveMode = TransNullToBool(objRow[convMicroteachCase_Resource_Rel_Base.SaveMode].ToString().Trim()), //文件存放方式
IdResourceType = objRow[convMicroteachCase_Resource_Rel_Base.IdResourceType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.IdResourceType].ToString().Trim(), //资源类型流水号
ResourceTypeID = objRow[convMicroteachCase_Resource_Rel_Base.ResourceTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceTypeID].ToString().Trim(), //资源类型ID
ResourceTypeName = objRow[convMicroteachCase_Resource_Rel_Base.ResourceTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceTypeName].ToString().Trim(), //资源类型名称
ResourceOwner = objRow[convMicroteachCase_Resource_Rel_Base.ResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceOwner].ToString().Trim(), //上传者
ftpFileType = objRow[convMicroteachCase_Resource_Rel_Base.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ftpFileType].ToString().Trim(), //ftp文件类型
ftpFileSize = objRow[convMicroteachCase_Resource_Rel_Base.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ftpFileSize].ToString().Trim(), //ftp文件大小
ftpResourceOwner = objRow[convMicroteachCase_Resource_Rel_Base.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ftpResourceOwner].ToString().Trim(), //Ftp资源拥有者
FileOriginName = objRow[convMicroteachCase_Resource_Rel_Base.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileOriginName].ToString().Trim(), //原文件名
IsExistFile = TransNullToBool(objRow[convMicroteachCase_Resource_Rel_Base.IsExistFile].ToString().Trim()), //是否存在文件
FileNewName = objRow[convMicroteachCase_Resource_Rel_Base.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileNewName].ToString().Trim(), //新文件名
FileOldName = objRow[convMicroteachCase_Resource_Rel_Base.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileOldName].ToString().Trim(), //旧文件名
IsMain = TransNullToBool(objRow[convMicroteachCase_Resource_Rel_Base.IsMain].ToString().Trim()), //是否主资源
IdUsingMode = objRow[convMicroteachCase_Resource_Rel_Base.IdUsingMode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.IdUsingMode].ToString().Trim(), //资源使用模式流水号
IndexNO = objRow[convMicroteachCase_Resource_Rel_Base.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase_Resource_Rel_Base.IndexNO].ToString().Trim()), //序号
BrowseCount = objRow[convMicroteachCase_Resource_Rel_Base.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase_Resource_Rel_Base.BrowseCount].ToString().Trim()), //浏览次数
UpdDate = objRow[convMicroteachCase_Resource_Rel_Base.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convMicroteachCase_Resource_Rel_Base.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convMicroteachCase_Resource_Rel_Base.Memo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.Memo].ToString().Trim() //备注
};
objvMicroteachCase_Resource_Rel_BaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvMicroteachCase_Resource_Rel_BaseEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvMicroteachCase_Resource_Rel_BaseDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvMicroteachCase_Resource_Rel_BaseEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN = new clsvMicroteachCase_Resource_Rel_BaseEN();
try
{
objvMicroteachCase_Resource_Rel_BaseEN.IdMicroteachCaseResourceRel = TransNullToInt(objRow[convMicroteachCase_Resource_Rel_Base.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvMicroteachCase_Resource_Rel_BaseEN.FuncModuleId = objRow[convMicroteachCase_Resource_Rel_Base.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCase_Resource_Rel_BaseEN.FuncModuleName = objRow[convMicroteachCase_Resource_Rel_Base.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachCase_Resource_Rel_BaseEN.IdMicroteachCase = objRow[convMicroteachCase_Resource_Rel_Base.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase_Resource_Rel_BaseEN.IdResource = objRow[convMicroteachCase_Resource_Rel_Base.IdResource].ToString().Trim(); //资源流水号
objvMicroteachCase_Resource_Rel_BaseEN.ResourceID = objRow[convMicroteachCase_Resource_Rel_Base.ResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceID].ToString().Trim(); //资源ID
objvMicroteachCase_Resource_Rel_BaseEN.ResourceName = objRow[convMicroteachCase_Resource_Rel_Base.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceName].ToString().Trim(); //资源名称
objvMicroteachCase_Resource_Rel_BaseEN.IdFtpResource = objRow[convMicroteachCase_Resource_Rel_Base.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroteachCase_Resource_Rel_BaseEN.IdFile = objRow[convMicroteachCase_Resource_Rel_Base.IdFile] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.IdFile].ToString().Trim(); //文件流水号
objvMicroteachCase_Resource_Rel_BaseEN.FileName = objRow[convMicroteachCase_Resource_Rel_Base.FileName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileName].ToString().Trim(); //文件名称
objvMicroteachCase_Resource_Rel_BaseEN.FileType = objRow[convMicroteachCase_Resource_Rel_Base.FileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileType].ToString().Trim(); //文件类型
objvMicroteachCase_Resource_Rel_BaseEN.SaveDate = objRow[convMicroteachCase_Resource_Rel_Base.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.SaveDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel_BaseEN.FileSize = objRow[convMicroteachCase_Resource_Rel_Base.FileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileSize].ToString().Trim(); //文件大小
objvMicroteachCase_Resource_Rel_BaseEN.SaveTime = objRow[convMicroteachCase_Resource_Rel_Base.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.SaveTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel_BaseEN.FtpResourceID = objRow[convMicroteachCase_Resource_Rel_Base.FtpResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroteachCase_Resource_Rel_BaseEN.FileOriginalName = objRow[convMicroteachCase_Resource_Rel_Base.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileOriginalName].ToString().Trim(); //文件原名
objvMicroteachCase_Resource_Rel_BaseEN.FileDirName = objRow[convMicroteachCase_Resource_Rel_Base.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileDirName].ToString().Trim(); //文件目录名
objvMicroteachCase_Resource_Rel_BaseEN.FileRename = objRow[convMicroteachCase_Resource_Rel_Base.FileRename] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileRename].ToString().Trim(); //文件新名
objvMicroteachCase_Resource_Rel_BaseEN.FileUpDate = objRow[convMicroteachCase_Resource_Rel_Base.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileUpDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel_BaseEN.FileUpTime = objRow[convMicroteachCase_Resource_Rel_Base.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileUpTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel_BaseEN.SaveMode = TransNullToBool(objRow[convMicroteachCase_Resource_Rel_Base.SaveMode].ToString().Trim()); //文件存放方式
objvMicroteachCase_Resource_Rel_BaseEN.IdResourceType = objRow[convMicroteachCase_Resource_Rel_Base.IdResourceType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroteachCase_Resource_Rel_BaseEN.ResourceTypeID = objRow[convMicroteachCase_Resource_Rel_Base.ResourceTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroteachCase_Resource_Rel_BaseEN.ResourceTypeName = objRow[convMicroteachCase_Resource_Rel_Base.ResourceTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroteachCase_Resource_Rel_BaseEN.ResourceOwner = objRow[convMicroteachCase_Resource_Rel_Base.ResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceOwner].ToString().Trim(); //上传者
objvMicroteachCase_Resource_Rel_BaseEN.ftpFileType = objRow[convMicroteachCase_Resource_Rel_Base.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroteachCase_Resource_Rel_BaseEN.ftpFileSize = objRow[convMicroteachCase_Resource_Rel_Base.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroteachCase_Resource_Rel_BaseEN.ftpResourceOwner = objRow[convMicroteachCase_Resource_Rel_Base.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroteachCase_Resource_Rel_BaseEN.FileOriginName = objRow[convMicroteachCase_Resource_Rel_Base.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileOriginName].ToString().Trim(); //原文件名
objvMicroteachCase_Resource_Rel_BaseEN.IsExistFile = TransNullToBool(objRow[convMicroteachCase_Resource_Rel_Base.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroteachCase_Resource_Rel_BaseEN.FileNewName = objRow[convMicroteachCase_Resource_Rel_Base.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileNewName].ToString().Trim(); //新文件名
objvMicroteachCase_Resource_Rel_BaseEN.FileOldName = objRow[convMicroteachCase_Resource_Rel_Base.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileOldName].ToString().Trim(); //旧文件名
objvMicroteachCase_Resource_Rel_BaseEN.IsMain = TransNullToBool(objRow[convMicroteachCase_Resource_Rel_Base.IsMain].ToString().Trim()); //是否主资源
objvMicroteachCase_Resource_Rel_BaseEN.IdUsingMode = objRow[convMicroteachCase_Resource_Rel_Base.IdUsingMode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvMicroteachCase_Resource_Rel_BaseEN.IndexNO = objRow[convMicroteachCase_Resource_Rel_Base.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase_Resource_Rel_Base.IndexNO].ToString().Trim()); //序号
objvMicroteachCase_Resource_Rel_BaseEN.BrowseCount = objRow[convMicroteachCase_Resource_Rel_Base.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase_Resource_Rel_Base.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachCase_Resource_Rel_BaseEN.UpdDate = objRow[convMicroteachCase_Resource_Rel_Base.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.UpdDate].ToString().Trim(); //修改日期
objvMicroteachCase_Resource_Rel_BaseEN.UpdUser = objRow[convMicroteachCase_Resource_Rel_Base.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.UpdUser].ToString().Trim(); //修改人
objvMicroteachCase_Resource_Rel_BaseEN.Memo = objRow[convMicroteachCase_Resource_Rel_Base.Memo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvMicroteachCase_Resource_Rel_BaseDA: GetObjByDataRowvMicroteachCase_Resource_Rel_Base)", objException.Message));
}
objvMicroteachCase_Resource_Rel_BaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvMicroteachCase_Resource_Rel_BaseEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvMicroteachCase_Resource_Rel_BaseEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN = new clsvMicroteachCase_Resource_Rel_BaseEN();
try
{
objvMicroteachCase_Resource_Rel_BaseEN.IdMicroteachCaseResourceRel = TransNullToInt(objRow[convMicroteachCase_Resource_Rel_Base.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvMicroteachCase_Resource_Rel_BaseEN.FuncModuleId = objRow[convMicroteachCase_Resource_Rel_Base.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCase_Resource_Rel_BaseEN.FuncModuleName = objRow[convMicroteachCase_Resource_Rel_Base.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachCase_Resource_Rel_BaseEN.IdMicroteachCase = objRow[convMicroteachCase_Resource_Rel_Base.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase_Resource_Rel_BaseEN.IdResource = objRow[convMicroteachCase_Resource_Rel_Base.IdResource].ToString().Trim(); //资源流水号
objvMicroteachCase_Resource_Rel_BaseEN.ResourceID = objRow[convMicroteachCase_Resource_Rel_Base.ResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceID].ToString().Trim(); //资源ID
objvMicroteachCase_Resource_Rel_BaseEN.ResourceName = objRow[convMicroteachCase_Resource_Rel_Base.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceName].ToString().Trim(); //资源名称
objvMicroteachCase_Resource_Rel_BaseEN.IdFtpResource = objRow[convMicroteachCase_Resource_Rel_Base.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroteachCase_Resource_Rel_BaseEN.IdFile = objRow[convMicroteachCase_Resource_Rel_Base.IdFile] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.IdFile].ToString().Trim(); //文件流水号
objvMicroteachCase_Resource_Rel_BaseEN.FileName = objRow[convMicroteachCase_Resource_Rel_Base.FileName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileName].ToString().Trim(); //文件名称
objvMicroteachCase_Resource_Rel_BaseEN.FileType = objRow[convMicroteachCase_Resource_Rel_Base.FileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileType].ToString().Trim(); //文件类型
objvMicroteachCase_Resource_Rel_BaseEN.SaveDate = objRow[convMicroteachCase_Resource_Rel_Base.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.SaveDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel_BaseEN.FileSize = objRow[convMicroteachCase_Resource_Rel_Base.FileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileSize].ToString().Trim(); //文件大小
objvMicroteachCase_Resource_Rel_BaseEN.SaveTime = objRow[convMicroteachCase_Resource_Rel_Base.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.SaveTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel_BaseEN.FtpResourceID = objRow[convMicroteachCase_Resource_Rel_Base.FtpResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroteachCase_Resource_Rel_BaseEN.FileOriginalName = objRow[convMicroteachCase_Resource_Rel_Base.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileOriginalName].ToString().Trim(); //文件原名
objvMicroteachCase_Resource_Rel_BaseEN.FileDirName = objRow[convMicroteachCase_Resource_Rel_Base.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileDirName].ToString().Trim(); //文件目录名
objvMicroteachCase_Resource_Rel_BaseEN.FileRename = objRow[convMicroteachCase_Resource_Rel_Base.FileRename] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileRename].ToString().Trim(); //文件新名
objvMicroteachCase_Resource_Rel_BaseEN.FileUpDate = objRow[convMicroteachCase_Resource_Rel_Base.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileUpDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel_BaseEN.FileUpTime = objRow[convMicroteachCase_Resource_Rel_Base.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileUpTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel_BaseEN.SaveMode = TransNullToBool(objRow[convMicroteachCase_Resource_Rel_Base.SaveMode].ToString().Trim()); //文件存放方式
objvMicroteachCase_Resource_Rel_BaseEN.IdResourceType = objRow[convMicroteachCase_Resource_Rel_Base.IdResourceType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroteachCase_Resource_Rel_BaseEN.ResourceTypeID = objRow[convMicroteachCase_Resource_Rel_Base.ResourceTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroteachCase_Resource_Rel_BaseEN.ResourceTypeName = objRow[convMicroteachCase_Resource_Rel_Base.ResourceTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroteachCase_Resource_Rel_BaseEN.ResourceOwner = objRow[convMicroteachCase_Resource_Rel_Base.ResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceOwner].ToString().Trim(); //上传者
objvMicroteachCase_Resource_Rel_BaseEN.ftpFileType = objRow[convMicroteachCase_Resource_Rel_Base.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroteachCase_Resource_Rel_BaseEN.ftpFileSize = objRow[convMicroteachCase_Resource_Rel_Base.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroteachCase_Resource_Rel_BaseEN.ftpResourceOwner = objRow[convMicroteachCase_Resource_Rel_Base.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroteachCase_Resource_Rel_BaseEN.FileOriginName = objRow[convMicroteachCase_Resource_Rel_Base.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileOriginName].ToString().Trim(); //原文件名
objvMicroteachCase_Resource_Rel_BaseEN.IsExistFile = TransNullToBool(objRow[convMicroteachCase_Resource_Rel_Base.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroteachCase_Resource_Rel_BaseEN.FileNewName = objRow[convMicroteachCase_Resource_Rel_Base.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileNewName].ToString().Trim(); //新文件名
objvMicroteachCase_Resource_Rel_BaseEN.FileOldName = objRow[convMicroteachCase_Resource_Rel_Base.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileOldName].ToString().Trim(); //旧文件名
objvMicroteachCase_Resource_Rel_BaseEN.IsMain = TransNullToBool(objRow[convMicroteachCase_Resource_Rel_Base.IsMain].ToString().Trim()); //是否主资源
objvMicroteachCase_Resource_Rel_BaseEN.IdUsingMode = objRow[convMicroteachCase_Resource_Rel_Base.IdUsingMode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvMicroteachCase_Resource_Rel_BaseEN.IndexNO = objRow[convMicroteachCase_Resource_Rel_Base.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase_Resource_Rel_Base.IndexNO].ToString().Trim()); //序号
objvMicroteachCase_Resource_Rel_BaseEN.BrowseCount = objRow[convMicroteachCase_Resource_Rel_Base.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase_Resource_Rel_Base.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachCase_Resource_Rel_BaseEN.UpdDate = objRow[convMicroteachCase_Resource_Rel_Base.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.UpdDate].ToString().Trim(); //修改日期
objvMicroteachCase_Resource_Rel_BaseEN.UpdUser = objRow[convMicroteachCase_Resource_Rel_Base.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.UpdUser].ToString().Trim(); //修改人
objvMicroteachCase_Resource_Rel_BaseEN.Memo = objRow[convMicroteachCase_Resource_Rel_Base.Memo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvMicroteachCase_Resource_Rel_BaseDA: GetObjByDataRow)", objException.Message));
}
objvMicroteachCase_Resource_Rel_BaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvMicroteachCase_Resource_Rel_BaseEN;
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
objSQL = clsvMicroteachCase_Resource_Rel_BaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvMicroteachCase_Resource_Rel_BaseEN._CurrTabName, convMicroteachCase_Resource_Rel_Base.IdMicroteachCaseResourceRel, 8, "");
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
objSQL = clsvMicroteachCase_Resource_Rel_BaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvMicroteachCase_Resource_Rel_BaseEN._CurrTabName, convMicroteachCase_Resource_Rel_Base.IdMicroteachCaseResourceRel, 8, strPrefix);
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
 objSQL = clsvMicroteachCase_Resource_Rel_BaseDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdMicroteachCaseResourceRel from vMicroteachCase_Resource_Rel_Base where " + strCondition;
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
 objSQL = clsvMicroteachCase_Resource_Rel_BaseDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdMicroteachCaseResourceRel from vMicroteachCase_Resource_Rel_Base where " + strCondition;
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
 objSQL = clsvMicroteachCase_Resource_Rel_BaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vMicroteachCase_Resource_Rel_Base", "IdMicroteachCaseResourceRel = " + ""+ lngIdMicroteachCaseResourceRel+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvMicroteachCase_Resource_Rel_BaseDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase_Resource_Rel_BaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vMicroteachCase_Resource_Rel_Base", strCondition))
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
objSQL = clsvMicroteachCase_Resource_Rel_BaseDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vMicroteachCase_Resource_Rel_Base");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseENS">源对象</param>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseENT">目标对象</param>
public void CopyTo(clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseENS, clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseENT)
{
objvMicroteachCase_Resource_Rel_BaseENT.IdMicroteachCaseResourceRel = objvMicroteachCase_Resource_Rel_BaseENS.IdMicroteachCaseResourceRel; //微格案例资源关系流水号
objvMicroteachCase_Resource_Rel_BaseENT.FuncModuleId = objvMicroteachCase_Resource_Rel_BaseENS.FuncModuleId; //功能模块Id
objvMicroteachCase_Resource_Rel_BaseENT.FuncModuleName = objvMicroteachCase_Resource_Rel_BaseENS.FuncModuleName; //功能模块名称
objvMicroteachCase_Resource_Rel_BaseENT.IdMicroteachCase = objvMicroteachCase_Resource_Rel_BaseENS.IdMicroteachCase; //微格教学案例流水号
objvMicroteachCase_Resource_Rel_BaseENT.IdResource = objvMicroteachCase_Resource_Rel_BaseENS.IdResource; //资源流水号
objvMicroteachCase_Resource_Rel_BaseENT.ResourceID = objvMicroteachCase_Resource_Rel_BaseENS.ResourceID; //资源ID
objvMicroteachCase_Resource_Rel_BaseENT.ResourceName = objvMicroteachCase_Resource_Rel_BaseENS.ResourceName; //资源名称
objvMicroteachCase_Resource_Rel_BaseENT.IdFtpResource = objvMicroteachCase_Resource_Rel_BaseENS.IdFtpResource; //FTP资源流水号
objvMicroteachCase_Resource_Rel_BaseENT.IdFile = objvMicroteachCase_Resource_Rel_BaseENS.IdFile; //文件流水号
objvMicroteachCase_Resource_Rel_BaseENT.FileName = objvMicroteachCase_Resource_Rel_BaseENS.FileName; //文件名称
objvMicroteachCase_Resource_Rel_BaseENT.FileType = objvMicroteachCase_Resource_Rel_BaseENS.FileType; //文件类型
objvMicroteachCase_Resource_Rel_BaseENT.SaveDate = objvMicroteachCase_Resource_Rel_BaseENS.SaveDate; //创建日期
objvMicroteachCase_Resource_Rel_BaseENT.FileSize = objvMicroteachCase_Resource_Rel_BaseENS.FileSize; //文件大小
objvMicroteachCase_Resource_Rel_BaseENT.SaveTime = objvMicroteachCase_Resource_Rel_BaseENS.SaveTime; //创建时间
objvMicroteachCase_Resource_Rel_BaseENT.FtpResourceID = objvMicroteachCase_Resource_Rel_BaseENS.FtpResourceID; //FTP资源ID
objvMicroteachCase_Resource_Rel_BaseENT.FileOriginalName = objvMicroteachCase_Resource_Rel_BaseENS.FileOriginalName; //文件原名
objvMicroteachCase_Resource_Rel_BaseENT.FileDirName = objvMicroteachCase_Resource_Rel_BaseENS.FileDirName; //文件目录名
objvMicroteachCase_Resource_Rel_BaseENT.FileRename = objvMicroteachCase_Resource_Rel_BaseENS.FileRename; //文件新名
objvMicroteachCase_Resource_Rel_BaseENT.FileUpDate = objvMicroteachCase_Resource_Rel_BaseENS.FileUpDate; //创建日期
objvMicroteachCase_Resource_Rel_BaseENT.FileUpTime = objvMicroteachCase_Resource_Rel_BaseENS.FileUpTime; //创建时间
objvMicroteachCase_Resource_Rel_BaseENT.SaveMode = objvMicroteachCase_Resource_Rel_BaseENS.SaveMode; //文件存放方式
objvMicroteachCase_Resource_Rel_BaseENT.IdResourceType = objvMicroteachCase_Resource_Rel_BaseENS.IdResourceType; //资源类型流水号
objvMicroteachCase_Resource_Rel_BaseENT.ResourceTypeID = objvMicroteachCase_Resource_Rel_BaseENS.ResourceTypeID; //资源类型ID
objvMicroteachCase_Resource_Rel_BaseENT.ResourceTypeName = objvMicroteachCase_Resource_Rel_BaseENS.ResourceTypeName; //资源类型名称
objvMicroteachCase_Resource_Rel_BaseENT.ResourceOwner = objvMicroteachCase_Resource_Rel_BaseENS.ResourceOwner; //上传者
objvMicroteachCase_Resource_Rel_BaseENT.ftpFileType = objvMicroteachCase_Resource_Rel_BaseENS.ftpFileType; //ftp文件类型
objvMicroteachCase_Resource_Rel_BaseENT.ftpFileSize = objvMicroteachCase_Resource_Rel_BaseENS.ftpFileSize; //ftp文件大小
objvMicroteachCase_Resource_Rel_BaseENT.ftpResourceOwner = objvMicroteachCase_Resource_Rel_BaseENS.ftpResourceOwner; //Ftp资源拥有者
objvMicroteachCase_Resource_Rel_BaseENT.FileOriginName = objvMicroteachCase_Resource_Rel_BaseENS.FileOriginName; //原文件名
objvMicroteachCase_Resource_Rel_BaseENT.IsExistFile = objvMicroteachCase_Resource_Rel_BaseENS.IsExistFile; //是否存在文件
objvMicroteachCase_Resource_Rel_BaseENT.FileNewName = objvMicroteachCase_Resource_Rel_BaseENS.FileNewName; //新文件名
objvMicroteachCase_Resource_Rel_BaseENT.FileOldName = objvMicroteachCase_Resource_Rel_BaseENS.FileOldName; //旧文件名
objvMicroteachCase_Resource_Rel_BaseENT.IsMain = objvMicroteachCase_Resource_Rel_BaseENS.IsMain; //是否主资源
objvMicroteachCase_Resource_Rel_BaseENT.IdUsingMode = objvMicroteachCase_Resource_Rel_BaseENS.IdUsingMode; //资源使用模式流水号
objvMicroteachCase_Resource_Rel_BaseENT.IndexNO = objvMicroteachCase_Resource_Rel_BaseENS.IndexNO; //序号
objvMicroteachCase_Resource_Rel_BaseENT.BrowseCount = objvMicroteachCase_Resource_Rel_BaseENS.BrowseCount; //浏览次数
objvMicroteachCase_Resource_Rel_BaseENT.UpdDate = objvMicroteachCase_Resource_Rel_BaseENS.UpdDate; //修改日期
objvMicroteachCase_Resource_Rel_BaseENT.UpdUser = objvMicroteachCase_Resource_Rel_BaseENS.UpdUser; //修改人
objvMicroteachCase_Resource_Rel_BaseENT.Memo = objvMicroteachCase_Resource_Rel_BaseENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel_BaseEN.FuncModuleId, 4, convMicroteachCase_Resource_Rel_Base.FuncModuleId);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel_BaseEN.FuncModuleName, 30, convMicroteachCase_Resource_Rel_Base.FuncModuleName);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel_BaseEN.IdMicroteachCase, 8, convMicroteachCase_Resource_Rel_Base.IdMicroteachCase);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel_BaseEN.IdResource, 8, convMicroteachCase_Resource_Rel_Base.IdResource);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel_BaseEN.ResourceID, 8, convMicroteachCase_Resource_Rel_Base.ResourceID);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel_BaseEN.ResourceName, 100, convMicroteachCase_Resource_Rel_Base.ResourceName);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel_BaseEN.IdFtpResource, 8, convMicroteachCase_Resource_Rel_Base.IdFtpResource);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel_BaseEN.IdFile, 8, convMicroteachCase_Resource_Rel_Base.IdFile);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel_BaseEN.FileName, 500, convMicroteachCase_Resource_Rel_Base.FileName);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel_BaseEN.FileType, 30, convMicroteachCase_Resource_Rel_Base.FileType);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel_BaseEN.SaveDate, 8, convMicroteachCase_Resource_Rel_Base.SaveDate);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel_BaseEN.FileSize, 50, convMicroteachCase_Resource_Rel_Base.FileSize);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel_BaseEN.SaveTime, 6, convMicroteachCase_Resource_Rel_Base.SaveTime);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel_BaseEN.FtpResourceID, 8, convMicroteachCase_Resource_Rel_Base.FtpResourceID);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel_BaseEN.FileOriginalName, 200, convMicroteachCase_Resource_Rel_Base.FileOriginalName);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel_BaseEN.FileDirName, 200, convMicroteachCase_Resource_Rel_Base.FileDirName);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel_BaseEN.FileRename, 200, convMicroteachCase_Resource_Rel_Base.FileRename);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel_BaseEN.FileUpDate, 8, convMicroteachCase_Resource_Rel_Base.FileUpDate);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel_BaseEN.FileUpTime, 6, convMicroteachCase_Resource_Rel_Base.FileUpTime);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel_BaseEN.IdResourceType, 4, convMicroteachCase_Resource_Rel_Base.IdResourceType);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel_BaseEN.ResourceTypeID, 4, convMicroteachCase_Resource_Rel_Base.ResourceTypeID);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel_BaseEN.ResourceTypeName, 50, convMicroteachCase_Resource_Rel_Base.ResourceTypeName);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel_BaseEN.ResourceOwner, 50, convMicroteachCase_Resource_Rel_Base.ResourceOwner);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel_BaseEN.ftpFileType, 30, convMicroteachCase_Resource_Rel_Base.ftpFileType);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel_BaseEN.ftpFileSize, 50, convMicroteachCase_Resource_Rel_Base.ftpFileSize);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel_BaseEN.ftpResourceOwner, 50, convMicroteachCase_Resource_Rel_Base.ftpResourceOwner);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel_BaseEN.FileOriginName, 500, convMicroteachCase_Resource_Rel_Base.FileOriginName);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel_BaseEN.FileNewName, 530, convMicroteachCase_Resource_Rel_Base.FileNewName);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel_BaseEN.FileOldName, 530, convMicroteachCase_Resource_Rel_Base.FileOldName);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel_BaseEN.IdUsingMode, 4, convMicroteachCase_Resource_Rel_Base.IdUsingMode);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel_BaseEN.UpdDate, 20, convMicroteachCase_Resource_Rel_Base.UpdDate);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel_BaseEN.UpdUser, 20, convMicroteachCase_Resource_Rel_Base.UpdUser);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel_BaseEN.Memo, 1000, convMicroteachCase_Resource_Rel_Base.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel_BaseEN.FuncModuleId, convMicroteachCase_Resource_Rel_Base.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel_BaseEN.FuncModuleName, convMicroteachCase_Resource_Rel_Base.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel_BaseEN.IdMicroteachCase, convMicroteachCase_Resource_Rel_Base.IdMicroteachCase);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel_BaseEN.IdResource, convMicroteachCase_Resource_Rel_Base.IdResource);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel_BaseEN.ResourceID, convMicroteachCase_Resource_Rel_Base.ResourceID);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel_BaseEN.ResourceName, convMicroteachCase_Resource_Rel_Base.ResourceName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel_BaseEN.IdFtpResource, convMicroteachCase_Resource_Rel_Base.IdFtpResource);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel_BaseEN.IdFile, convMicroteachCase_Resource_Rel_Base.IdFile);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel_BaseEN.FileName, convMicroteachCase_Resource_Rel_Base.FileName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel_BaseEN.FileType, convMicroteachCase_Resource_Rel_Base.FileType);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel_BaseEN.SaveDate, convMicroteachCase_Resource_Rel_Base.SaveDate);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel_BaseEN.FileSize, convMicroteachCase_Resource_Rel_Base.FileSize);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel_BaseEN.SaveTime, convMicroteachCase_Resource_Rel_Base.SaveTime);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel_BaseEN.FtpResourceID, convMicroteachCase_Resource_Rel_Base.FtpResourceID);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel_BaseEN.FileOriginalName, convMicroteachCase_Resource_Rel_Base.FileOriginalName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel_BaseEN.FileDirName, convMicroteachCase_Resource_Rel_Base.FileDirName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel_BaseEN.FileRename, convMicroteachCase_Resource_Rel_Base.FileRename);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel_BaseEN.FileUpDate, convMicroteachCase_Resource_Rel_Base.FileUpDate);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel_BaseEN.FileUpTime, convMicroteachCase_Resource_Rel_Base.FileUpTime);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel_BaseEN.IdResourceType, convMicroteachCase_Resource_Rel_Base.IdResourceType);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel_BaseEN.ResourceTypeID, convMicroteachCase_Resource_Rel_Base.ResourceTypeID);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel_BaseEN.ResourceTypeName, convMicroteachCase_Resource_Rel_Base.ResourceTypeName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel_BaseEN.ResourceOwner, convMicroteachCase_Resource_Rel_Base.ResourceOwner);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel_BaseEN.ftpFileType, convMicroteachCase_Resource_Rel_Base.ftpFileType);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel_BaseEN.ftpFileSize, convMicroteachCase_Resource_Rel_Base.ftpFileSize);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel_BaseEN.ftpResourceOwner, convMicroteachCase_Resource_Rel_Base.ftpResourceOwner);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel_BaseEN.FileOriginName, convMicroteachCase_Resource_Rel_Base.FileOriginName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel_BaseEN.FileNewName, convMicroteachCase_Resource_Rel_Base.FileNewName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel_BaseEN.FileOldName, convMicroteachCase_Resource_Rel_Base.FileOldName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel_BaseEN.IdUsingMode, convMicroteachCase_Resource_Rel_Base.IdUsingMode);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel_BaseEN.UpdDate, convMicroteachCase_Resource_Rel_Base.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel_BaseEN.UpdUser, convMicroteachCase_Resource_Rel_Base.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel_BaseEN.Memo, convMicroteachCase_Resource_Rel_Base.Memo);
//检查外键字段长度
 objvMicroteachCase_Resource_Rel_BaseEN._IsCheckProperty = true;
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
 objSQL = clsvMicroteachCase_Resource_Rel_BaseDA.GetSpecSQLObj();
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
 objSQL = clsvMicroteachCase_Resource_Rel_BaseDA.GetSpecSQLObj();
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
 objSQL = clsvMicroteachCase_Resource_Rel_BaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvMicroteachCase_Resource_Rel_BaseEN._CurrTabName);
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
 objSQL = clsvMicroteachCase_Resource_Rel_BaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvMicroteachCase_Resource_Rel_BaseEN._CurrTabName, strCondition);
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
 objSQL = clsvMicroteachCase_Resource_Rel_BaseDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}