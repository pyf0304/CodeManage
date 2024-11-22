
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvVideoLibQuantitySenateItems_Avg_VDA
 表名:vVideoLibQuantitySenateItems_Avg_V(01120471)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:50:44
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:视频库(VideoLib)
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
 /// v视频库量化评价详细表_Avg_V(vVideoLibQuantitySenateItems_Avg_V)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvVideoLibQuantitySenateItems_Avg_VDA : clsCommBase4DA
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
 return clsvVideoLibQuantitySenateItems_Avg_VEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvVideoLibQuantitySenateItems_Avg_VEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvVideoLibQuantitySenateItems_Avg_VEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvVideoLibQuantitySenateItems_Avg_VEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvVideoLibQuantitySenateItems_Avg_VEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvVideoLibQuantitySenateItems_Avg_VDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibQuantitySenateItems_Avg_VDA.GetSpecSQLObj();
strSQL = "Select * from vVideoLibQuantitySenateItems_Avg_V where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vVideoLibQuantitySenateItems_Avg_V(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvVideoLibQuantitySenateItems_Avg_VDA: GetDataTable_vVideoLibQuantitySenateItems_Avg_V)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibQuantitySenateItems_Avg_VDA.GetSpecSQLObj();
strSQL = "Select * from vVideoLibQuantitySenateItems_Avg_V where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvVideoLibQuantitySenateItems_Avg_VDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibQuantitySenateItems_Avg_VDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvVideoLibQuantitySenateItems_Avg_VDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibQuantitySenateItems_Avg_VDA.GetSpecSQLObj();
strSQL = "Select * from vVideoLibQuantitySenateItems_Avg_V where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvVideoLibQuantitySenateItems_Avg_VDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibQuantitySenateItems_Avg_VDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvVideoLibQuantitySenateItems_Avg_VDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibQuantitySenateItems_Avg_VDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vVideoLibQuantitySenateItems_Avg_V where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vVideoLibQuantitySenateItems_Avg_V where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvVideoLibQuantitySenateItems_Avg_VDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibQuantitySenateItems_Avg_VDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vVideoLibQuantitySenateItems_Avg_V where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvVideoLibQuantitySenateItems_Avg_VDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibQuantitySenateItems_Avg_VDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vVideoLibQuantitySenateItems_Avg_V.* from vVideoLibQuantitySenateItems_Avg_V Left Join {1} on {2} where {3} and vVideoLibQuantitySenateItems_Avg_V.IdmicroteachCaseQuantitySenate not in (Select top {5} vVideoLibQuantitySenateItems_Avg_V.IdmicroteachCaseQuantitySenate from vVideoLibQuantitySenateItems_Avg_V Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vVideoLibQuantitySenateItems_Avg_V where {1} and IdmicroteachCaseQuantitySenate not in (Select top {2} IdmicroteachCaseQuantitySenate from vVideoLibQuantitySenateItems_Avg_V where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vVideoLibQuantitySenateItems_Avg_V where {1} and IdmicroteachCaseQuantitySenate not in (Select top {3} IdmicroteachCaseQuantitySenate from vVideoLibQuantitySenateItems_Avg_V where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvVideoLibQuantitySenateItems_Avg_VDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibQuantitySenateItems_Avg_VDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vVideoLibQuantitySenateItems_Avg_V.* from vVideoLibQuantitySenateItems_Avg_V Left Join {1} on {2} where {3} and vVideoLibQuantitySenateItems_Avg_V.IdmicroteachCaseQuantitySenate not in (Select top {5} vVideoLibQuantitySenateItems_Avg_V.IdmicroteachCaseQuantitySenate from vVideoLibQuantitySenateItems_Avg_V Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vVideoLibQuantitySenateItems_Avg_V where {1} and IdmicroteachCaseQuantitySenate not in (Select top {2} IdmicroteachCaseQuantitySenate from vVideoLibQuantitySenateItems_Avg_V where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vVideoLibQuantitySenateItems_Avg_V where {1} and IdmicroteachCaseQuantitySenate not in (Select top {3} IdmicroteachCaseQuantitySenate from vVideoLibQuantitySenateItems_Avg_V where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvVideoLibQuantitySenateItems_Avg_VEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvVideoLibQuantitySenateItems_Avg_VDA:GetObjLst)", objException.Message));
}
List<clsvVideoLibQuantitySenateItems_Avg_VEN> arrObjLst = new List<clsvVideoLibQuantitySenateItems_Avg_VEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibQuantitySenateItems_Avg_VDA.GetSpecSQLObj();
strSQL = "Select * from vVideoLibQuantitySenateItems_Avg_V where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VEN = new clsvVideoLibQuantitySenateItems_Avg_VEN();
try
{
objvVideoLibQuantitySenateItems_Avg_VEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convVideoLibQuantitySenateItems_Avg_V.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvVideoLibQuantitySenateItems_Avg_VEN.FuncModuleId = objRow[convVideoLibQuantitySenateItems_Avg_V.FuncModuleId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoLibQuantitySenateItems_Avg_VEN.FuncModuleName = objRow[convVideoLibQuantitySenateItems_Avg_V.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoLibQuantitySenateItems_Avg_VEN.IdMicroteachCase = objRow[convVideoLibQuantitySenateItems_Avg_V.IdMicroteachCase] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoLibQuantitySenateItems_Avg_VEN.VideoLibID = objRow[convVideoLibQuantitySenateItems_Avg_V.VideoLibID] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLibQuantitySenateItems_Avg_VEN.VideoLibName = objRow[convVideoLibQuantitySenateItems_Avg_V.VideoLibName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.VideoLibName].ToString().Trim(); //视频名称
objvVideoLibQuantitySenateItems_Avg_VEN.IdAppraiseType = objRow[convVideoLibQuantitySenateItems_Avg_V.IdAppraiseType] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvVideoLibQuantitySenateItems_Avg_VEN.AppraiseTypeName = objRow[convVideoLibQuantitySenateItems_Avg_V.AppraiseTypeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvVideoLibQuantitySenateItems_Avg_VEN.SenateDate = objRow[convVideoLibQuantitySenateItems_Avg_V.SenateDate] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.SenateDate].ToString().Trim(); //评价日期
objvVideoLibQuantitySenateItems_Avg_VEN.senateGaugeVersionName = objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoLibQuantitySenateItems_Avg_VEN.UserName = objRow[convVideoLibQuantitySenateItems_Avg_V.UserName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.UserName].ToString().Trim(); //用户名
objvVideoLibQuantitySenateItems_Avg_VEN.IdSenateGaugeItem = objRow[convVideoLibQuantitySenateItems_Avg_V.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objvVideoLibQuantitySenateItems_Avg_VEN.senateGaugeItemName = objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemName].ToString().Trim(); //量表指标名称
objvVideoLibQuantitySenateItems_Avg_VEN.senateGaugeItemWeight = objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemWeight] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemWeight].ToString().Trim()); //量表指标权重
objvVideoLibQuantitySenateItems_Avg_VEN.SenateScoreAvg = objRow[convVideoLibQuantitySenateItems_Avg_V.SenateScoreAvg] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convVideoLibQuantitySenateItems_Avg_V.SenateScoreAvg].ToString().Trim()); //评议平均分
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvVideoLibQuantitySenateItems_Avg_VDA: GetObjLst)", objException.Message));
}
objvVideoLibQuantitySenateItems_Avg_VEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvVideoLibQuantitySenateItems_Avg_VEN);
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
public List<clsvVideoLibQuantitySenateItems_Avg_VEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvVideoLibQuantitySenateItems_Avg_VDA:GetObjLstByTabName)", objException.Message));
}
List<clsvVideoLibQuantitySenateItems_Avg_VEN> arrObjLst = new List<clsvVideoLibQuantitySenateItems_Avg_VEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibQuantitySenateItems_Avg_VDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VEN = new clsvVideoLibQuantitySenateItems_Avg_VEN();
try
{
objvVideoLibQuantitySenateItems_Avg_VEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convVideoLibQuantitySenateItems_Avg_V.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvVideoLibQuantitySenateItems_Avg_VEN.FuncModuleId = objRow[convVideoLibQuantitySenateItems_Avg_V.FuncModuleId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoLibQuantitySenateItems_Avg_VEN.FuncModuleName = objRow[convVideoLibQuantitySenateItems_Avg_V.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoLibQuantitySenateItems_Avg_VEN.IdMicroteachCase = objRow[convVideoLibQuantitySenateItems_Avg_V.IdMicroteachCase] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoLibQuantitySenateItems_Avg_VEN.VideoLibID = objRow[convVideoLibQuantitySenateItems_Avg_V.VideoLibID] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLibQuantitySenateItems_Avg_VEN.VideoLibName = objRow[convVideoLibQuantitySenateItems_Avg_V.VideoLibName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.VideoLibName].ToString().Trim(); //视频名称
objvVideoLibQuantitySenateItems_Avg_VEN.IdAppraiseType = objRow[convVideoLibQuantitySenateItems_Avg_V.IdAppraiseType] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvVideoLibQuantitySenateItems_Avg_VEN.AppraiseTypeName = objRow[convVideoLibQuantitySenateItems_Avg_V.AppraiseTypeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvVideoLibQuantitySenateItems_Avg_VEN.SenateDate = objRow[convVideoLibQuantitySenateItems_Avg_V.SenateDate] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.SenateDate].ToString().Trim(); //评价日期
objvVideoLibQuantitySenateItems_Avg_VEN.senateGaugeVersionName = objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoLibQuantitySenateItems_Avg_VEN.UserName = objRow[convVideoLibQuantitySenateItems_Avg_V.UserName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.UserName].ToString().Trim(); //用户名
objvVideoLibQuantitySenateItems_Avg_VEN.IdSenateGaugeItem = objRow[convVideoLibQuantitySenateItems_Avg_V.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objvVideoLibQuantitySenateItems_Avg_VEN.senateGaugeItemName = objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemName].ToString().Trim(); //量表指标名称
objvVideoLibQuantitySenateItems_Avg_VEN.senateGaugeItemWeight = objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemWeight] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemWeight].ToString().Trim()); //量表指标权重
objvVideoLibQuantitySenateItems_Avg_VEN.SenateScoreAvg = objRow[convVideoLibQuantitySenateItems_Avg_V.SenateScoreAvg] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convVideoLibQuantitySenateItems_Avg_V.SenateScoreAvg].ToString().Trim()); //评议平均分
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvVideoLibQuantitySenateItems_Avg_VDA: GetObjLst)", objException.Message));
}
objvVideoLibQuantitySenateItems_Avg_VEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvVideoLibQuantitySenateItems_Avg_VEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateItems_Avg_VEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvVideoLibQuantitySenateItems_Avg_V(ref clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibQuantitySenateItems_Avg_VDA.GetSpecSQLObj();
strSQL = "Select * from vVideoLibQuantitySenateItems_Avg_V where IdmicroteachCaseQuantitySenate = " + ""+ objvVideoLibQuantitySenateItems_Avg_VEN.IdmicroteachCaseQuantitySenate+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvVideoLibQuantitySenateItems_Avg_VEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objDT.Rows[0][convVideoLibQuantitySenateItems_Avg_V.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvVideoLibQuantitySenateItems_Avg_VEN.FuncModuleId = objDT.Rows[0][convVideoLibQuantitySenateItems_Avg_V.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvVideoLibQuantitySenateItems_Avg_VEN.FuncModuleName = objDT.Rows[0][convVideoLibQuantitySenateItems_Avg_V.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvVideoLibQuantitySenateItems_Avg_VEN.IdMicroteachCase = objDT.Rows[0][convVideoLibQuantitySenateItems_Avg_V.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoLibQuantitySenateItems_Avg_VEN.VideoLibID = objDT.Rows[0][convVideoLibQuantitySenateItems_Avg_V.VideoLibID].ToString().Trim(); //视频库ID(字段类型:char,字段长度:8,是否可空:False)
 objvVideoLibQuantitySenateItems_Avg_VEN.VideoLibName = objDT.Rows[0][convVideoLibQuantitySenateItems_Avg_V.VideoLibName].ToString().Trim(); //视频名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvVideoLibQuantitySenateItems_Avg_VEN.IdAppraiseType = objDT.Rows[0][convVideoLibQuantitySenateItems_Avg_V.IdAppraiseType].ToString().Trim(); //评议类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvVideoLibQuantitySenateItems_Avg_VEN.AppraiseTypeName = objDT.Rows[0][convVideoLibQuantitySenateItems_Avg_V.AppraiseTypeName].ToString().Trim(); //评议类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvVideoLibQuantitySenateItems_Avg_VEN.SenateDate = objDT.Rows[0][convVideoLibQuantitySenateItems_Avg_V.SenateDate].ToString().Trim(); //评价日期(字段类型:char,字段长度:8,是否可空:True)
 objvVideoLibQuantitySenateItems_Avg_VEN.senateGaugeVersionName = objDT.Rows[0][convVideoLibQuantitySenateItems_Avg_V.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoLibQuantitySenateItems_Avg_VEN.UserName = objDT.Rows[0][convVideoLibQuantitySenateItems_Avg_V.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvVideoLibQuantitySenateItems_Avg_VEN.IdSenateGaugeItem = objDT.Rows[0][convVideoLibQuantitySenateItems_Avg_V.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号(字段类型:char,字段长度:4,是否可空:False)
 objvVideoLibQuantitySenateItems_Avg_VEN.senateGaugeItemName = objDT.Rows[0][convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemName].ToString().Trim(); //量表指标名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoLibQuantitySenateItems_Avg_VEN.senateGaugeItemWeight = TransNullToFloat(objDT.Rows[0][convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemWeight].ToString().Trim()); //量表指标权重(字段类型:float,字段长度:8,是否可空:True)
 objvVideoLibQuantitySenateItems_Avg_VEN.SenateScoreAvg = TransNullToFloat(objDT.Rows[0][convVideoLibQuantitySenateItems_Avg_V.SenateScoreAvg].ToString().Trim()); //评议平均分(字段类型:float,字段长度:8,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvVideoLibQuantitySenateItems_Avg_VDA: GetvVideoLibQuantitySenateItems_Avg_V)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdmicroteachCaseQuantitySenate">表关键字</param>
 /// <returns>表对象</returns>
public clsvVideoLibQuantitySenateItems_Avg_VEN GetObjByIdmicroteachCaseQuantitySenate(long lngIdmicroteachCaseQuantitySenate)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibQuantitySenateItems_Avg_VDA.GetSpecSQLObj();
strSQL = "Select * from vVideoLibQuantitySenateItems_Avg_V where IdmicroteachCaseQuantitySenate = " + ""+ lngIdmicroteachCaseQuantitySenate+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VEN = new clsvVideoLibQuantitySenateItems_Avg_VEN();
try
{
 objvVideoLibQuantitySenateItems_Avg_VEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convVideoLibQuantitySenateItems_Avg_V.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvVideoLibQuantitySenateItems_Avg_VEN.FuncModuleId = objRow[convVideoLibQuantitySenateItems_Avg_V.FuncModuleId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvVideoLibQuantitySenateItems_Avg_VEN.FuncModuleName = objRow[convVideoLibQuantitySenateItems_Avg_V.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvVideoLibQuantitySenateItems_Avg_VEN.IdMicroteachCase = objRow[convVideoLibQuantitySenateItems_Avg_V.IdMicroteachCase] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoLibQuantitySenateItems_Avg_VEN.VideoLibID = objRow[convVideoLibQuantitySenateItems_Avg_V.VideoLibID] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.VideoLibID].ToString().Trim(); //视频库ID(字段类型:char,字段长度:8,是否可空:False)
 objvVideoLibQuantitySenateItems_Avg_VEN.VideoLibName = objRow[convVideoLibQuantitySenateItems_Avg_V.VideoLibName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.VideoLibName].ToString().Trim(); //视频名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvVideoLibQuantitySenateItems_Avg_VEN.IdAppraiseType = objRow[convVideoLibQuantitySenateItems_Avg_V.IdAppraiseType] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.IdAppraiseType].ToString().Trim(); //评议类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvVideoLibQuantitySenateItems_Avg_VEN.AppraiseTypeName = objRow[convVideoLibQuantitySenateItems_Avg_V.AppraiseTypeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.AppraiseTypeName].ToString().Trim(); //评议类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvVideoLibQuantitySenateItems_Avg_VEN.SenateDate = objRow[convVideoLibQuantitySenateItems_Avg_V.SenateDate] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.SenateDate].ToString().Trim(); //评价日期(字段类型:char,字段长度:8,是否可空:True)
 objvVideoLibQuantitySenateItems_Avg_VEN.senateGaugeVersionName = objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoLibQuantitySenateItems_Avg_VEN.UserName = objRow[convVideoLibQuantitySenateItems_Avg_V.UserName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvVideoLibQuantitySenateItems_Avg_VEN.IdSenateGaugeItem = objRow[convVideoLibQuantitySenateItems_Avg_V.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号(字段类型:char,字段长度:4,是否可空:False)
 objvVideoLibQuantitySenateItems_Avg_VEN.senateGaugeItemName = objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemName].ToString().Trim(); //量表指标名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoLibQuantitySenateItems_Avg_VEN.senateGaugeItemWeight = objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemWeight].ToString().Trim()); //量表指标权重(字段类型:float,字段长度:8,是否可空:True)
 objvVideoLibQuantitySenateItems_Avg_VEN.SenateScoreAvg = objRow[convVideoLibQuantitySenateItems_Avg_V.SenateScoreAvg] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convVideoLibQuantitySenateItems_Avg_V.SenateScoreAvg].ToString().Trim()); //评议平均分(字段类型:float,字段长度:8,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvVideoLibQuantitySenateItems_Avg_VDA: GetObjByIdmicroteachCaseQuantitySenate)", objException.Message));
}
return objvVideoLibQuantitySenateItems_Avg_VEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvVideoLibQuantitySenateItems_Avg_VEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvVideoLibQuantitySenateItems_Avg_VDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibQuantitySenateItems_Avg_VDA.GetSpecSQLObj();
strSQL = "Select * from vVideoLibQuantitySenateItems_Avg_V where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VEN = new clsvVideoLibQuantitySenateItems_Avg_VEN()
{
IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convVideoLibQuantitySenateItems_Avg_V.IdmicroteachCaseQuantitySenate].ToString().Trim()), //微格量化评价流水号
FuncModuleId = objRow[convVideoLibQuantitySenateItems_Avg_V.FuncModuleId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.FuncModuleId].ToString().Trim(), //功能模块Id
FuncModuleName = objRow[convVideoLibQuantitySenateItems_Avg_V.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.FuncModuleName].ToString().Trim(), //功能模块名称
IdMicroteachCase = objRow[convVideoLibQuantitySenateItems_Avg_V.IdMicroteachCase] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.IdMicroteachCase].ToString().Trim(), //微格教学案例流水号
VideoLibID = objRow[convVideoLibQuantitySenateItems_Avg_V.VideoLibID] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.VideoLibID].ToString().Trim(), //视频库ID
VideoLibName = objRow[convVideoLibQuantitySenateItems_Avg_V.VideoLibName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.VideoLibName].ToString().Trim(), //视频名称
IdAppraiseType = objRow[convVideoLibQuantitySenateItems_Avg_V.IdAppraiseType] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.IdAppraiseType].ToString().Trim(), //评议类型流水号
AppraiseTypeName = objRow[convVideoLibQuantitySenateItems_Avg_V.AppraiseTypeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.AppraiseTypeName].ToString().Trim(), //评议类型名称
SenateDate = objRow[convVideoLibQuantitySenateItems_Avg_V.SenateDate] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.SenateDate].ToString().Trim(), //评价日期
senateGaugeVersionName = objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeVersionName].ToString().Trim(), //评价量表版本名称
UserName = objRow[convVideoLibQuantitySenateItems_Avg_V.UserName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.UserName].ToString().Trim(), //用户名
IdSenateGaugeItem = objRow[convVideoLibQuantitySenateItems_Avg_V.IdSenateGaugeItem].ToString().Trim(), //量表指标流水号
senateGaugeItemName = objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemName].ToString().Trim(), //量表指标名称
senateGaugeItemWeight = objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemWeight] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemWeight].ToString().Trim()), //量表指标权重
SenateScoreAvg = objRow[convVideoLibQuantitySenateItems_Avg_V.SenateScoreAvg] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convVideoLibQuantitySenateItems_Avg_V.SenateScoreAvg].ToString().Trim()) //评议平均分
};
objvVideoLibQuantitySenateItems_Avg_VEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvVideoLibQuantitySenateItems_Avg_VEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvVideoLibQuantitySenateItems_Avg_VDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvVideoLibQuantitySenateItems_Avg_VEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VEN = new clsvVideoLibQuantitySenateItems_Avg_VEN();
try
{
objvVideoLibQuantitySenateItems_Avg_VEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convVideoLibQuantitySenateItems_Avg_V.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvVideoLibQuantitySenateItems_Avg_VEN.FuncModuleId = objRow[convVideoLibQuantitySenateItems_Avg_V.FuncModuleId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoLibQuantitySenateItems_Avg_VEN.FuncModuleName = objRow[convVideoLibQuantitySenateItems_Avg_V.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoLibQuantitySenateItems_Avg_VEN.IdMicroteachCase = objRow[convVideoLibQuantitySenateItems_Avg_V.IdMicroteachCase] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoLibQuantitySenateItems_Avg_VEN.VideoLibID = objRow[convVideoLibQuantitySenateItems_Avg_V.VideoLibID] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLibQuantitySenateItems_Avg_VEN.VideoLibName = objRow[convVideoLibQuantitySenateItems_Avg_V.VideoLibName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.VideoLibName].ToString().Trim(); //视频名称
objvVideoLibQuantitySenateItems_Avg_VEN.IdAppraiseType = objRow[convVideoLibQuantitySenateItems_Avg_V.IdAppraiseType] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvVideoLibQuantitySenateItems_Avg_VEN.AppraiseTypeName = objRow[convVideoLibQuantitySenateItems_Avg_V.AppraiseTypeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvVideoLibQuantitySenateItems_Avg_VEN.SenateDate = objRow[convVideoLibQuantitySenateItems_Avg_V.SenateDate] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.SenateDate].ToString().Trim(); //评价日期
objvVideoLibQuantitySenateItems_Avg_VEN.senateGaugeVersionName = objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoLibQuantitySenateItems_Avg_VEN.UserName = objRow[convVideoLibQuantitySenateItems_Avg_V.UserName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.UserName].ToString().Trim(); //用户名
objvVideoLibQuantitySenateItems_Avg_VEN.IdSenateGaugeItem = objRow[convVideoLibQuantitySenateItems_Avg_V.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objvVideoLibQuantitySenateItems_Avg_VEN.senateGaugeItemName = objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemName].ToString().Trim(); //量表指标名称
objvVideoLibQuantitySenateItems_Avg_VEN.senateGaugeItemWeight = objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemWeight] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemWeight].ToString().Trim()); //量表指标权重
objvVideoLibQuantitySenateItems_Avg_VEN.SenateScoreAvg = objRow[convVideoLibQuantitySenateItems_Avg_V.SenateScoreAvg] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convVideoLibQuantitySenateItems_Avg_V.SenateScoreAvg].ToString().Trim()); //评议平均分
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvVideoLibQuantitySenateItems_Avg_VDA: GetObjByDataRowvVideoLibQuantitySenateItems_Avg_V)", objException.Message));
}
objvVideoLibQuantitySenateItems_Avg_VEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvVideoLibQuantitySenateItems_Avg_VEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvVideoLibQuantitySenateItems_Avg_VEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VEN = new clsvVideoLibQuantitySenateItems_Avg_VEN();
try
{
objvVideoLibQuantitySenateItems_Avg_VEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convVideoLibQuantitySenateItems_Avg_V.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvVideoLibQuantitySenateItems_Avg_VEN.FuncModuleId = objRow[convVideoLibQuantitySenateItems_Avg_V.FuncModuleId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoLibQuantitySenateItems_Avg_VEN.FuncModuleName = objRow[convVideoLibQuantitySenateItems_Avg_V.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoLibQuantitySenateItems_Avg_VEN.IdMicroteachCase = objRow[convVideoLibQuantitySenateItems_Avg_V.IdMicroteachCase] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoLibQuantitySenateItems_Avg_VEN.VideoLibID = objRow[convVideoLibQuantitySenateItems_Avg_V.VideoLibID] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLibQuantitySenateItems_Avg_VEN.VideoLibName = objRow[convVideoLibQuantitySenateItems_Avg_V.VideoLibName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.VideoLibName].ToString().Trim(); //视频名称
objvVideoLibQuantitySenateItems_Avg_VEN.IdAppraiseType = objRow[convVideoLibQuantitySenateItems_Avg_V.IdAppraiseType] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvVideoLibQuantitySenateItems_Avg_VEN.AppraiseTypeName = objRow[convVideoLibQuantitySenateItems_Avg_V.AppraiseTypeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvVideoLibQuantitySenateItems_Avg_VEN.SenateDate = objRow[convVideoLibQuantitySenateItems_Avg_V.SenateDate] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.SenateDate].ToString().Trim(); //评价日期
objvVideoLibQuantitySenateItems_Avg_VEN.senateGaugeVersionName = objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoLibQuantitySenateItems_Avg_VEN.UserName = objRow[convVideoLibQuantitySenateItems_Avg_V.UserName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.UserName].ToString().Trim(); //用户名
objvVideoLibQuantitySenateItems_Avg_VEN.IdSenateGaugeItem = objRow[convVideoLibQuantitySenateItems_Avg_V.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objvVideoLibQuantitySenateItems_Avg_VEN.senateGaugeItemName = objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemName].ToString().Trim(); //量表指标名称
objvVideoLibQuantitySenateItems_Avg_VEN.senateGaugeItemWeight = objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemWeight] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemWeight].ToString().Trim()); //量表指标权重
objvVideoLibQuantitySenateItems_Avg_VEN.SenateScoreAvg = objRow[convVideoLibQuantitySenateItems_Avg_V.SenateScoreAvg] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convVideoLibQuantitySenateItems_Avg_V.SenateScoreAvg].ToString().Trim()); //评议平均分
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvVideoLibQuantitySenateItems_Avg_VDA: GetObjByDataRow)", objException.Message));
}
objvVideoLibQuantitySenateItems_Avg_VEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvVideoLibQuantitySenateItems_Avg_VEN;
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
objSQL = clsvVideoLibQuantitySenateItems_Avg_VDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvVideoLibQuantitySenateItems_Avg_VEN._CurrTabName, convVideoLibQuantitySenateItems_Avg_V.IdmicroteachCaseQuantitySenate, 8, "");
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
objSQL = clsvVideoLibQuantitySenateItems_Avg_VDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvVideoLibQuantitySenateItems_Avg_VEN._CurrTabName, convVideoLibQuantitySenateItems_Avg_V.IdmicroteachCaseQuantitySenate, 8, strPrefix);
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
 objSQL = clsvVideoLibQuantitySenateItems_Avg_VDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdmicroteachCaseQuantitySenate from vVideoLibQuantitySenateItems_Avg_V where " + strCondition;
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
 objSQL = clsvVideoLibQuantitySenateItems_Avg_VDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdmicroteachCaseQuantitySenate from vVideoLibQuantitySenateItems_Avg_V where " + strCondition;
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
 objSQL = clsvVideoLibQuantitySenateItems_Avg_VDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vVideoLibQuantitySenateItems_Avg_V", "IdmicroteachCaseQuantitySenate = " + ""+ lngIdmicroteachCaseQuantitySenate+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvVideoLibQuantitySenateItems_Avg_VDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibQuantitySenateItems_Avg_VDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vVideoLibQuantitySenateItems_Avg_V", strCondition))
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
objSQL = clsvVideoLibQuantitySenateItems_Avg_VDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vVideoLibQuantitySenateItems_Avg_V");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateItems_Avg_VENS">源对象</param>
 /// <param name = "objvVideoLibQuantitySenateItems_Avg_VENT">目标对象</param>
public void CopyTo(clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VENS, clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VENT)
{
objvVideoLibQuantitySenateItems_Avg_VENT.IdmicroteachCaseQuantitySenate = objvVideoLibQuantitySenateItems_Avg_VENS.IdmicroteachCaseQuantitySenate; //微格量化评价流水号
objvVideoLibQuantitySenateItems_Avg_VENT.FuncModuleId = objvVideoLibQuantitySenateItems_Avg_VENS.FuncModuleId; //功能模块Id
objvVideoLibQuantitySenateItems_Avg_VENT.FuncModuleName = objvVideoLibQuantitySenateItems_Avg_VENS.FuncModuleName; //功能模块名称
objvVideoLibQuantitySenateItems_Avg_VENT.IdMicroteachCase = objvVideoLibQuantitySenateItems_Avg_VENS.IdMicroteachCase; //微格教学案例流水号
objvVideoLibQuantitySenateItems_Avg_VENT.VideoLibID = objvVideoLibQuantitySenateItems_Avg_VENS.VideoLibID; //视频库ID
objvVideoLibQuantitySenateItems_Avg_VENT.VideoLibName = objvVideoLibQuantitySenateItems_Avg_VENS.VideoLibName; //视频名称
objvVideoLibQuantitySenateItems_Avg_VENT.IdAppraiseType = objvVideoLibQuantitySenateItems_Avg_VENS.IdAppraiseType; //评议类型流水号
objvVideoLibQuantitySenateItems_Avg_VENT.AppraiseTypeName = objvVideoLibQuantitySenateItems_Avg_VENS.AppraiseTypeName; //评议类型名称
objvVideoLibQuantitySenateItems_Avg_VENT.SenateDate = objvVideoLibQuantitySenateItems_Avg_VENS.SenateDate; //评价日期
objvVideoLibQuantitySenateItems_Avg_VENT.senateGaugeVersionName = objvVideoLibQuantitySenateItems_Avg_VENS.senateGaugeVersionName; //评价量表版本名称
objvVideoLibQuantitySenateItems_Avg_VENT.UserName = objvVideoLibQuantitySenateItems_Avg_VENS.UserName; //用户名
objvVideoLibQuantitySenateItems_Avg_VENT.IdSenateGaugeItem = objvVideoLibQuantitySenateItems_Avg_VENS.IdSenateGaugeItem; //量表指标流水号
objvVideoLibQuantitySenateItems_Avg_VENT.senateGaugeItemName = objvVideoLibQuantitySenateItems_Avg_VENS.senateGaugeItemName; //量表指标名称
objvVideoLibQuantitySenateItems_Avg_VENT.senateGaugeItemWeight = objvVideoLibQuantitySenateItems_Avg_VENS.senateGaugeItemWeight; //量表指标权重
objvVideoLibQuantitySenateItems_Avg_VENT.SenateScoreAvg = objvVideoLibQuantitySenateItems_Avg_VENS.SenateScoreAvg; //评议平均分
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvVideoLibQuantitySenateItems_Avg_VEN.FuncModuleId, 4, convVideoLibQuantitySenateItems_Avg_V.FuncModuleId);
clsCheckSql.CheckFieldLen(objvVideoLibQuantitySenateItems_Avg_VEN.FuncModuleName, 30, convVideoLibQuantitySenateItems_Avg_V.FuncModuleName);
clsCheckSql.CheckFieldLen(objvVideoLibQuantitySenateItems_Avg_VEN.IdMicroteachCase, 8, convVideoLibQuantitySenateItems_Avg_V.IdMicroteachCase);
clsCheckSql.CheckFieldLen(objvVideoLibQuantitySenateItems_Avg_VEN.VideoLibID, 8, convVideoLibQuantitySenateItems_Avg_V.VideoLibID);
clsCheckSql.CheckFieldLen(objvVideoLibQuantitySenateItems_Avg_VEN.VideoLibName, 100, convVideoLibQuantitySenateItems_Avg_V.VideoLibName);
clsCheckSql.CheckFieldLen(objvVideoLibQuantitySenateItems_Avg_VEN.IdAppraiseType, 4, convVideoLibQuantitySenateItems_Avg_V.IdAppraiseType);
clsCheckSql.CheckFieldLen(objvVideoLibQuantitySenateItems_Avg_VEN.AppraiseTypeName, 50, convVideoLibQuantitySenateItems_Avg_V.AppraiseTypeName);
clsCheckSql.CheckFieldLen(objvVideoLibQuantitySenateItems_Avg_VEN.SenateDate, 8, convVideoLibQuantitySenateItems_Avg_V.SenateDate);
clsCheckSql.CheckFieldLen(objvVideoLibQuantitySenateItems_Avg_VEN.senateGaugeVersionName, 200, convVideoLibQuantitySenateItems_Avg_V.senateGaugeVersionName);
clsCheckSql.CheckFieldLen(objvVideoLibQuantitySenateItems_Avg_VEN.UserName, 30, convVideoLibQuantitySenateItems_Avg_V.UserName);
clsCheckSql.CheckFieldLen(objvVideoLibQuantitySenateItems_Avg_VEN.IdSenateGaugeItem, 4, convVideoLibQuantitySenateItems_Avg_V.IdSenateGaugeItem);
clsCheckSql.CheckFieldLen(objvVideoLibQuantitySenateItems_Avg_VEN.senateGaugeItemName, 200, convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemName);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvVideoLibQuantitySenateItems_Avg_VEN.FuncModuleId, convVideoLibQuantitySenateItems_Avg_V.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibQuantitySenateItems_Avg_VEN.FuncModuleName, convVideoLibQuantitySenateItems_Avg_V.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibQuantitySenateItems_Avg_VEN.IdMicroteachCase, convVideoLibQuantitySenateItems_Avg_V.IdMicroteachCase);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibQuantitySenateItems_Avg_VEN.VideoLibID, convVideoLibQuantitySenateItems_Avg_V.VideoLibID);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibQuantitySenateItems_Avg_VEN.VideoLibName, convVideoLibQuantitySenateItems_Avg_V.VideoLibName);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibQuantitySenateItems_Avg_VEN.IdAppraiseType, convVideoLibQuantitySenateItems_Avg_V.IdAppraiseType);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibQuantitySenateItems_Avg_VEN.AppraiseTypeName, convVideoLibQuantitySenateItems_Avg_V.AppraiseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibQuantitySenateItems_Avg_VEN.SenateDate, convVideoLibQuantitySenateItems_Avg_V.SenateDate);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibQuantitySenateItems_Avg_VEN.senateGaugeVersionName, convVideoLibQuantitySenateItems_Avg_V.senateGaugeVersionName);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibQuantitySenateItems_Avg_VEN.UserName, convVideoLibQuantitySenateItems_Avg_V.UserName);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibQuantitySenateItems_Avg_VEN.IdSenateGaugeItem, convVideoLibQuantitySenateItems_Avg_V.IdSenateGaugeItem);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibQuantitySenateItems_Avg_VEN.senateGaugeItemName, convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemName);
//检查外键字段长度
 objvVideoLibQuantitySenateItems_Avg_VEN._IsCheckProperty = true;
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
 objSQL = clsvVideoLibQuantitySenateItems_Avg_VDA.GetSpecSQLObj();
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
 objSQL = clsvVideoLibQuantitySenateItems_Avg_VDA.GetSpecSQLObj();
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
 objSQL = clsvVideoLibQuantitySenateItems_Avg_VDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvVideoLibQuantitySenateItems_Avg_VEN._CurrTabName);
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
 objSQL = clsvVideoLibQuantitySenateItems_Avg_VDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvVideoLibQuantitySenateItems_Avg_VEN._CurrTabName, strCondition);
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
 objSQL = clsvVideoLibQuantitySenateItems_Avg_VDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}