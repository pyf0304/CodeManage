
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvVideoLib_Resource_RelDA
 表名:vVideoLib_Resource_Rel(01120442)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:50:35
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
 /// v视频库资源关系(vVideoLib_Resource_Rel)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvVideoLib_Resource_RelDA : clsCommBase4DA
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
 return clsvVideoLib_Resource_RelEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvVideoLib_Resource_RelEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvVideoLib_Resource_RelEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvVideoLib_Resource_RelEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvVideoLib_Resource_RelEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvVideoLib_Resource_RelDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLib_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vVideoLib_Resource_Rel where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vVideoLib_Resource_Rel(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvVideoLib_Resource_RelDA: GetDataTable_vVideoLib_Resource_Rel)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLib_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vVideoLib_Resource_Rel where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvVideoLib_Resource_RelDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLib_Resource_RelDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvVideoLib_Resource_RelDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLib_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vVideoLib_Resource_Rel where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvVideoLib_Resource_RelDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLib_Resource_RelDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvVideoLib_Resource_RelDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLib_Resource_RelDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vVideoLib_Resource_Rel where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vVideoLib_Resource_Rel where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvVideoLib_Resource_RelDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLib_Resource_RelDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vVideoLib_Resource_Rel where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvVideoLib_Resource_RelDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLib_Resource_RelDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vVideoLib_Resource_Rel.* from vVideoLib_Resource_Rel Left Join {1} on {2} where {3} and vVideoLib_Resource_Rel.IdMicroteachCaseResourceRel not in (Select top {5} vVideoLib_Resource_Rel.IdMicroteachCaseResourceRel from vVideoLib_Resource_Rel Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vVideoLib_Resource_Rel where {1} and IdMicroteachCaseResourceRel not in (Select top {2} IdMicroteachCaseResourceRel from vVideoLib_Resource_Rel where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vVideoLib_Resource_Rel where {1} and IdMicroteachCaseResourceRel not in (Select top {3} IdMicroteachCaseResourceRel from vVideoLib_Resource_Rel where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvVideoLib_Resource_RelDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLib_Resource_RelDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vVideoLib_Resource_Rel.* from vVideoLib_Resource_Rel Left Join {1} on {2} where {3} and vVideoLib_Resource_Rel.IdMicroteachCaseResourceRel not in (Select top {5} vVideoLib_Resource_Rel.IdMicroteachCaseResourceRel from vVideoLib_Resource_Rel Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vVideoLib_Resource_Rel where {1} and IdMicroteachCaseResourceRel not in (Select top {2} IdMicroteachCaseResourceRel from vVideoLib_Resource_Rel where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vVideoLib_Resource_Rel where {1} and IdMicroteachCaseResourceRel not in (Select top {3} IdMicroteachCaseResourceRel from vVideoLib_Resource_Rel where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvVideoLib_Resource_RelEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvVideoLib_Resource_RelDA:GetObjLst)", objException.Message));
}
List<clsvVideoLib_Resource_RelEN> arrObjLst = new List<clsvVideoLib_Resource_RelEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLib_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vVideoLib_Resource_Rel where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN = new clsvVideoLib_Resource_RelEN();
try
{
objvVideoLib_Resource_RelEN.IdMicroteachCaseResourceRel = TransNullToInt(objRow[convVideoLib_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvVideoLib_Resource_RelEN.FuncModuleId = objRow[convVideoLib_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoLib_Resource_RelEN.FuncModuleName = objRow[convVideoLib_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoLib_Resource_RelEN.IdMicroteachCase = objRow[convVideoLib_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoLib_Resource_RelEN.VideoLibID = objRow[convVideoLib_Resource_Rel.VideoLibID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLib_Resource_RelEN.VideoLibName = objRow[convVideoLib_Resource_Rel.VideoLibName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibName].ToString().Trim(); //视频名称
objvVideoLib_Resource_RelEN.VideoLibTheme = objRow[convVideoLib_Resource_Rel.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibTheme].ToString().Trim(); //视频库主题词
objvVideoLib_Resource_RelEN.IdVideoLibType = objRow[convVideoLib_Resource_Rel.IdVideoLibType] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdVideoLibType].ToString().Trim(); //视频库类型流水号
objvVideoLib_Resource_RelEN.VideoLibTypeName = objRow[convVideoLib_Resource_Rel.VideoLibTypeName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibTypeName].ToString().Trim(); //视频库类型名称
objvVideoLib_Resource_RelEN.VideoLibText = objRow[convVideoLib_Resource_Rel.VideoLibText] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibText].ToString().Trim(); //案例文本内容
objvVideoLib_Resource_RelEN.VideoLibDate = objRow[convVideoLib_Resource_Rel.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibDate].ToString().Trim(); //视频资源日期
objvVideoLib_Resource_RelEN.VideoLibTime = objRow[convVideoLib_Resource_Rel.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibTime].ToString().Trim(); //视频资源时间
objvVideoLib_Resource_RelEN.VideoLibDateIn = objRow[convVideoLib_Resource_Rel.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibDateIn].ToString().Trim(); //案例入库日期
objvVideoLib_Resource_RelEN.VideoLibTimeIn = objRow[convVideoLib_Resource_Rel.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objvVideoLib_Resource_RelEN.OwnerId = objRow[convVideoLib_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvVideoLib_Resource_RelEN.IdTeachingPlan = objRow[convVideoLib_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvVideoLib_Resource_RelEN.senateGaugeVersionID = objRow[convVideoLib_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoLib_Resource_RelEN.senateGaugeVersionName = objRow[convVideoLib_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoLib_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convVideoLib_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convVideoLib_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoLib_Resource_RelEN.VersionNo = objRow[convVideoLib_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvVideoLib_Resource_RelEN.CaseLevelId = objRow[convVideoLib_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvVideoLib_Resource_RelEN.IdXzCollege = objRow[convVideoLib_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLib_Resource_RelEN.CollegeID = objRow[convVideoLib_Resource_Rel.CollegeID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CollegeID].ToString().Trim(); //学院ID
objvVideoLib_Resource_RelEN.CollegeName = objRow[convVideoLib_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvVideoLib_Resource_RelEN.CollegeNameA = objRow[convVideoLib_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoLib_Resource_RelEN.ViewCount = objRow[convVideoLib_Resource_Rel.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib_Resource_Rel.ViewCount].ToString().Trim()); //浏览量
objvVideoLib_Resource_RelEN.DownloadNumber = objRow[convVideoLib_Resource_Rel.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib_Resource_Rel.DownloadNumber].ToString().Trim()); //下载数目
objvVideoLib_Resource_RelEN.FileIntegration = objRow[convVideoLib_Resource_Rel.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib_Resource_Rel.FileIntegration].ToString().Trim()); //文件积分
objvVideoLib_Resource_RelEN.LikeCount = objRow[convVideoLib_Resource_Rel.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoLib_Resource_Rel.LikeCount].ToString().Trim()); //资源喜欢数量
objvVideoLib_Resource_RelEN.CollectionCount = objRow[convVideoLib_Resource_Rel.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoLib_Resource_Rel.CollectionCount].ToString().Trim()); //收藏数量
objvVideoLib_Resource_RelEN.RecommendedDegreeId = objRow[convVideoLib_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvVideoLib_Resource_RelEN.RecommendedDegreeName = objRow[convVideoLib_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvVideoLib_Resource_RelEN.CourseId = objRow[convVideoLib_Resource_Rel.CourseId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CourseId].ToString().Trim(); //课程Id
objvVideoLib_Resource_RelEN.CourseCode = objRow[convVideoLib_Resource_Rel.CourseCode] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CourseCode].ToString().Trim(); //课程代码
objvVideoLib_Resource_RelEN.CourseName = objRow[convVideoLib_Resource_Rel.CourseName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CourseName].ToString().Trim(); //课程名称
objvVideoLib_Resource_RelEN.BrowseCount4Case = objRow[convVideoLib_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvVideoLib_Resource_RelEN.OwnerName = objRow[convVideoLib_Resource_Rel.OwnerName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.OwnerName].ToString().Trim(); //拥有者姓名
objvVideoLib_Resource_RelEN.OwnerNameWithId = objRow[convVideoLib_Resource_Rel.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvVideoLib_Resource_RelEN.IdResource = objRow[convVideoLib_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvVideoLib_Resource_RelEN.ResourceID = objRow[convVideoLib_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvVideoLib_Resource_RelEN.ResourceName = objRow[convVideoLib_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvVideoLib_Resource_RelEN.SaveMode = TransNullToBool(objRow[convVideoLib_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvVideoLib_Resource_RelEN.IdFtpResource = objRow[convVideoLib_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvVideoLib_Resource_RelEN.FtpResourceID = objRow[convVideoLib_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvVideoLib_Resource_RelEN.FileOriginalName = objRow[convVideoLib_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvVideoLib_Resource_RelEN.FileDirName = objRow[convVideoLib_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvVideoLib_Resource_RelEN.FileRename = objRow[convVideoLib_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvVideoLib_Resource_RelEN.FileUpDate = objRow[convVideoLib_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvVideoLib_Resource_RelEN.FileUpTime = objRow[convVideoLib_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvVideoLib_Resource_RelEN.FileSize = objRow[convVideoLib_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvVideoLib_Resource_RelEN.FileType = objRow[convVideoLib_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvVideoLib_Resource_RelEN.ResourceOwner = objRow[convVideoLib_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvVideoLib_Resource_RelEN.IsExistFile = TransNullToBool(objRow[convVideoLib_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvVideoLib_Resource_RelEN.IdFile = objRow[convVideoLib_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvVideoLib_Resource_RelEN.FileName = objRow[convVideoLib_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvVideoLib_Resource_RelEN.SaveDate = objRow[convVideoLib_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvVideoLib_Resource_RelEN.SaveTime = objRow[convVideoLib_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvVideoLib_Resource_RelEN.FileOriginName = objRow[convVideoLib_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvVideoLib_Resource_RelEN.IdResourceType = objRow[convVideoLib_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvVideoLib_Resource_RelEN.ResourceTypeID = objRow[convVideoLib_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvVideoLib_Resource_RelEN.ResourceTypeName = objRow[convVideoLib_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvVideoLib_Resource_RelEN.FileNewName = objRow[convVideoLib_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvVideoLib_Resource_RelEN.FileOldName = objRow[convVideoLib_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvVideoLib_Resource_RelEN.ftpFileType = objRow[convVideoLib_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvVideoLib_Resource_RelEN.ftpFileSize = objRow[convVideoLib_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvVideoLib_Resource_RelEN.ftpResourceOwner = objRow[convVideoLib_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvVideoLib_Resource_RelEN.IsMain = TransNullToBool(objRow[convVideoLib_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvVideoLib_Resource_RelEN.IdUsingMode = objRow[convVideoLib_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvVideoLib_Resource_RelEN.IsVisible = TransNullToBool(objRow[convVideoLib_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvVideoLib_Resource_RelEN.IndexNO = objRow[convVideoLib_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvVideoLib_Resource_RelEN.BrowseCount = objRow[convVideoLib_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvVideoLib_Resource_RelEN.UpdDate = objRow[convVideoLib_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvVideoLib_Resource_RelEN.UpdUser = objRow[convVideoLib_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvVideoLib_Resource_RelEN.Memo = objRow[convVideoLib_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvVideoLib_Resource_RelDA: GetObjLst)", objException.Message));
}
objvVideoLib_Resource_RelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvVideoLib_Resource_RelEN);
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
public List<clsvVideoLib_Resource_RelEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvVideoLib_Resource_RelDA:GetObjLstByTabName)", objException.Message));
}
List<clsvVideoLib_Resource_RelEN> arrObjLst = new List<clsvVideoLib_Resource_RelEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLib_Resource_RelDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN = new clsvVideoLib_Resource_RelEN();
try
{
objvVideoLib_Resource_RelEN.IdMicroteachCaseResourceRel = TransNullToInt(objRow[convVideoLib_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvVideoLib_Resource_RelEN.FuncModuleId = objRow[convVideoLib_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoLib_Resource_RelEN.FuncModuleName = objRow[convVideoLib_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoLib_Resource_RelEN.IdMicroteachCase = objRow[convVideoLib_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoLib_Resource_RelEN.VideoLibID = objRow[convVideoLib_Resource_Rel.VideoLibID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLib_Resource_RelEN.VideoLibName = objRow[convVideoLib_Resource_Rel.VideoLibName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibName].ToString().Trim(); //视频名称
objvVideoLib_Resource_RelEN.VideoLibTheme = objRow[convVideoLib_Resource_Rel.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibTheme].ToString().Trim(); //视频库主题词
objvVideoLib_Resource_RelEN.IdVideoLibType = objRow[convVideoLib_Resource_Rel.IdVideoLibType] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdVideoLibType].ToString().Trim(); //视频库类型流水号
objvVideoLib_Resource_RelEN.VideoLibTypeName = objRow[convVideoLib_Resource_Rel.VideoLibTypeName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibTypeName].ToString().Trim(); //视频库类型名称
objvVideoLib_Resource_RelEN.VideoLibText = objRow[convVideoLib_Resource_Rel.VideoLibText] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibText].ToString().Trim(); //案例文本内容
objvVideoLib_Resource_RelEN.VideoLibDate = objRow[convVideoLib_Resource_Rel.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibDate].ToString().Trim(); //视频资源日期
objvVideoLib_Resource_RelEN.VideoLibTime = objRow[convVideoLib_Resource_Rel.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibTime].ToString().Trim(); //视频资源时间
objvVideoLib_Resource_RelEN.VideoLibDateIn = objRow[convVideoLib_Resource_Rel.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibDateIn].ToString().Trim(); //案例入库日期
objvVideoLib_Resource_RelEN.VideoLibTimeIn = objRow[convVideoLib_Resource_Rel.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objvVideoLib_Resource_RelEN.OwnerId = objRow[convVideoLib_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvVideoLib_Resource_RelEN.IdTeachingPlan = objRow[convVideoLib_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvVideoLib_Resource_RelEN.senateGaugeVersionID = objRow[convVideoLib_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoLib_Resource_RelEN.senateGaugeVersionName = objRow[convVideoLib_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoLib_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convVideoLib_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convVideoLib_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoLib_Resource_RelEN.VersionNo = objRow[convVideoLib_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvVideoLib_Resource_RelEN.CaseLevelId = objRow[convVideoLib_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvVideoLib_Resource_RelEN.IdXzCollege = objRow[convVideoLib_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLib_Resource_RelEN.CollegeID = objRow[convVideoLib_Resource_Rel.CollegeID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CollegeID].ToString().Trim(); //学院ID
objvVideoLib_Resource_RelEN.CollegeName = objRow[convVideoLib_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvVideoLib_Resource_RelEN.CollegeNameA = objRow[convVideoLib_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoLib_Resource_RelEN.ViewCount = objRow[convVideoLib_Resource_Rel.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib_Resource_Rel.ViewCount].ToString().Trim()); //浏览量
objvVideoLib_Resource_RelEN.DownloadNumber = objRow[convVideoLib_Resource_Rel.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib_Resource_Rel.DownloadNumber].ToString().Trim()); //下载数目
objvVideoLib_Resource_RelEN.FileIntegration = objRow[convVideoLib_Resource_Rel.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib_Resource_Rel.FileIntegration].ToString().Trim()); //文件积分
objvVideoLib_Resource_RelEN.LikeCount = objRow[convVideoLib_Resource_Rel.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoLib_Resource_Rel.LikeCount].ToString().Trim()); //资源喜欢数量
objvVideoLib_Resource_RelEN.CollectionCount = objRow[convVideoLib_Resource_Rel.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoLib_Resource_Rel.CollectionCount].ToString().Trim()); //收藏数量
objvVideoLib_Resource_RelEN.RecommendedDegreeId = objRow[convVideoLib_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvVideoLib_Resource_RelEN.RecommendedDegreeName = objRow[convVideoLib_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvVideoLib_Resource_RelEN.CourseId = objRow[convVideoLib_Resource_Rel.CourseId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CourseId].ToString().Trim(); //课程Id
objvVideoLib_Resource_RelEN.CourseCode = objRow[convVideoLib_Resource_Rel.CourseCode] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CourseCode].ToString().Trim(); //课程代码
objvVideoLib_Resource_RelEN.CourseName = objRow[convVideoLib_Resource_Rel.CourseName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CourseName].ToString().Trim(); //课程名称
objvVideoLib_Resource_RelEN.BrowseCount4Case = objRow[convVideoLib_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvVideoLib_Resource_RelEN.OwnerName = objRow[convVideoLib_Resource_Rel.OwnerName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.OwnerName].ToString().Trim(); //拥有者姓名
objvVideoLib_Resource_RelEN.OwnerNameWithId = objRow[convVideoLib_Resource_Rel.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvVideoLib_Resource_RelEN.IdResource = objRow[convVideoLib_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvVideoLib_Resource_RelEN.ResourceID = objRow[convVideoLib_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvVideoLib_Resource_RelEN.ResourceName = objRow[convVideoLib_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvVideoLib_Resource_RelEN.SaveMode = TransNullToBool(objRow[convVideoLib_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvVideoLib_Resource_RelEN.IdFtpResource = objRow[convVideoLib_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvVideoLib_Resource_RelEN.FtpResourceID = objRow[convVideoLib_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvVideoLib_Resource_RelEN.FileOriginalName = objRow[convVideoLib_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvVideoLib_Resource_RelEN.FileDirName = objRow[convVideoLib_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvVideoLib_Resource_RelEN.FileRename = objRow[convVideoLib_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvVideoLib_Resource_RelEN.FileUpDate = objRow[convVideoLib_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvVideoLib_Resource_RelEN.FileUpTime = objRow[convVideoLib_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvVideoLib_Resource_RelEN.FileSize = objRow[convVideoLib_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvVideoLib_Resource_RelEN.FileType = objRow[convVideoLib_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvVideoLib_Resource_RelEN.ResourceOwner = objRow[convVideoLib_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvVideoLib_Resource_RelEN.IsExistFile = TransNullToBool(objRow[convVideoLib_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvVideoLib_Resource_RelEN.IdFile = objRow[convVideoLib_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvVideoLib_Resource_RelEN.FileName = objRow[convVideoLib_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvVideoLib_Resource_RelEN.SaveDate = objRow[convVideoLib_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvVideoLib_Resource_RelEN.SaveTime = objRow[convVideoLib_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvVideoLib_Resource_RelEN.FileOriginName = objRow[convVideoLib_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvVideoLib_Resource_RelEN.IdResourceType = objRow[convVideoLib_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvVideoLib_Resource_RelEN.ResourceTypeID = objRow[convVideoLib_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvVideoLib_Resource_RelEN.ResourceTypeName = objRow[convVideoLib_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvVideoLib_Resource_RelEN.FileNewName = objRow[convVideoLib_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvVideoLib_Resource_RelEN.FileOldName = objRow[convVideoLib_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvVideoLib_Resource_RelEN.ftpFileType = objRow[convVideoLib_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvVideoLib_Resource_RelEN.ftpFileSize = objRow[convVideoLib_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvVideoLib_Resource_RelEN.ftpResourceOwner = objRow[convVideoLib_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvVideoLib_Resource_RelEN.IsMain = TransNullToBool(objRow[convVideoLib_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvVideoLib_Resource_RelEN.IdUsingMode = objRow[convVideoLib_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvVideoLib_Resource_RelEN.IsVisible = TransNullToBool(objRow[convVideoLib_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvVideoLib_Resource_RelEN.IndexNO = objRow[convVideoLib_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvVideoLib_Resource_RelEN.BrowseCount = objRow[convVideoLib_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvVideoLib_Resource_RelEN.UpdDate = objRow[convVideoLib_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvVideoLib_Resource_RelEN.UpdUser = objRow[convVideoLib_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvVideoLib_Resource_RelEN.Memo = objRow[convVideoLib_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvVideoLib_Resource_RelDA: GetObjLst)", objException.Message));
}
objvVideoLib_Resource_RelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvVideoLib_Resource_RelEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvVideoLib_Resource_Rel(ref clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLib_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vVideoLib_Resource_Rel where IdMicroteachCaseResourceRel = " + ""+ objvVideoLib_Resource_RelEN.IdMicroteachCaseResourceRel+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvVideoLib_Resource_RelEN.IdMicroteachCaseResourceRel = TransNullToInt(objDT.Rows[0][convVideoLib_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvVideoLib_Resource_RelEN.FuncModuleId = objDT.Rows[0][convVideoLib_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvVideoLib_Resource_RelEN.FuncModuleName = objDT.Rows[0][convVideoLib_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvVideoLib_Resource_RelEN.IdMicroteachCase = objDT.Rows[0][convVideoLib_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoLib_Resource_RelEN.VideoLibID = objDT.Rows[0][convVideoLib_Resource_Rel.VideoLibID].ToString().Trim(); //视频库ID(字段类型:char,字段长度:8,是否可空:False)
 objvVideoLib_Resource_RelEN.VideoLibName = objDT.Rows[0][convVideoLib_Resource_Rel.VideoLibName].ToString().Trim(); //视频名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvVideoLib_Resource_RelEN.VideoLibTheme = objDT.Rows[0][convVideoLib_Resource_Rel.VideoLibTheme].ToString().Trim(); //视频库主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoLib_Resource_RelEN.IdVideoLibType = objDT.Rows[0][convVideoLib_Resource_Rel.IdVideoLibType].ToString().Trim(); //视频库类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvVideoLib_Resource_RelEN.VideoLibTypeName = objDT.Rows[0][convVideoLib_Resource_Rel.VideoLibTypeName].ToString().Trim(); //视频库类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvVideoLib_Resource_RelEN.VideoLibText = objDT.Rows[0][convVideoLib_Resource_Rel.VideoLibText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objvVideoLib_Resource_RelEN.VideoLibDate = objDT.Rows[0][convVideoLib_Resource_Rel.VideoLibDate].ToString().Trim(); //视频资源日期(字段类型:char,字段长度:8,是否可空:True)
 objvVideoLib_Resource_RelEN.VideoLibTime = objDT.Rows[0][convVideoLib_Resource_Rel.VideoLibTime].ToString().Trim(); //视频资源时间(字段类型:char,字段长度:6,是否可空:True)
 objvVideoLib_Resource_RelEN.VideoLibDateIn = objDT.Rows[0][convVideoLib_Resource_Rel.VideoLibDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvVideoLib_Resource_RelEN.VideoLibTimeIn = objDT.Rows[0][convVideoLib_Resource_Rel.VideoLibTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvVideoLib_Resource_RelEN.OwnerId = objDT.Rows[0][convVideoLib_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvVideoLib_Resource_RelEN.IdTeachingPlan = objDT.Rows[0][convVideoLib_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoLib_Resource_RelEN.senateGaugeVersionID = objDT.Rows[0][convVideoLib_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvVideoLib_Resource_RelEN.senateGaugeVersionName = objDT.Rows[0][convVideoLib_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoLib_Resource_RelEN.senateGaugeVersionTtlScore = TransNullToFloat(objDT.Rows[0][convVideoLib_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvVideoLib_Resource_RelEN.VersionNo = TransNullToInt(objDT.Rows[0][convVideoLib_Resource_Rel.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvVideoLib_Resource_RelEN.CaseLevelId = objDT.Rows[0][convVideoLib_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvVideoLib_Resource_RelEN.IdXzCollege = objDT.Rows[0][convVideoLib_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvVideoLib_Resource_RelEN.CollegeID = objDT.Rows[0][convVideoLib_Resource_Rel.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvVideoLib_Resource_RelEN.CollegeName = objDT.Rows[0][convVideoLib_Resource_Rel.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvVideoLib_Resource_RelEN.CollegeNameA = objDT.Rows[0][convVideoLib_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvVideoLib_Resource_RelEN.ViewCount = TransNullToInt(objDT.Rows[0][convVideoLib_Resource_Rel.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvVideoLib_Resource_RelEN.DownloadNumber = TransNullToInt(objDT.Rows[0][convVideoLib_Resource_Rel.DownloadNumber].ToString().Trim()); //下载数目(字段类型:int,字段长度:4,是否可空:True)
 objvVideoLib_Resource_RelEN.FileIntegration = TransNullToInt(objDT.Rows[0][convVideoLib_Resource_Rel.FileIntegration].ToString().Trim()); //文件积分(字段类型:int,字段长度:4,是否可空:True)
 objvVideoLib_Resource_RelEN.LikeCount = TransNullToInt(objDT.Rows[0][convVideoLib_Resource_Rel.LikeCount].ToString().Trim()); //资源喜欢数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvVideoLib_Resource_RelEN.CollectionCount = TransNullToInt(objDT.Rows[0][convVideoLib_Resource_Rel.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvVideoLib_Resource_RelEN.RecommendedDegreeId = objDT.Rows[0][convVideoLib_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvVideoLib_Resource_RelEN.RecommendedDegreeName = objDT.Rows[0][convVideoLib_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvVideoLib_Resource_RelEN.CourseId = objDT.Rows[0][convVideoLib_Resource_Rel.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvVideoLib_Resource_RelEN.CourseCode = objDT.Rows[0][convVideoLib_Resource_Rel.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvVideoLib_Resource_RelEN.CourseName = objDT.Rows[0][convVideoLib_Resource_Rel.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvVideoLib_Resource_RelEN.BrowseCount4Case = TransNullToInt(objDT.Rows[0][convVideoLib_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvVideoLib_Resource_RelEN.OwnerName = objDT.Rows[0][convVideoLib_Resource_Rel.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvVideoLib_Resource_RelEN.OwnerNameWithId = objDT.Rows[0][convVideoLib_Resource_Rel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
 objvVideoLib_Resource_RelEN.IdResource = objDT.Rows[0][convVideoLib_Resource_Rel.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoLib_Resource_RelEN.ResourceID = objDT.Rows[0][convVideoLib_Resource_Rel.ResourceID].ToString().Trim(); //资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvVideoLib_Resource_RelEN.ResourceName = objDT.Rows[0][convVideoLib_Resource_Rel.ResourceName].ToString().Trim(); //资源名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvVideoLib_Resource_RelEN.SaveMode = TransNullToBool(objDT.Rows[0][convVideoLib_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式(字段类型:bit,字段长度:1,是否可空:True)
 objvVideoLib_Resource_RelEN.IdFtpResource = objDT.Rows[0][convVideoLib_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objvVideoLib_Resource_RelEN.FtpResourceID = objDT.Rows[0][convVideoLib_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvVideoLib_Resource_RelEN.FileOriginalName = objDT.Rows[0][convVideoLib_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoLib_Resource_RelEN.FileDirName = objDT.Rows[0][convVideoLib_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoLib_Resource_RelEN.FileRename = objDT.Rows[0][convVideoLib_Resource_Rel.FileRename].ToString().Trim(); //文件新名(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoLib_Resource_RelEN.FileUpDate = objDT.Rows[0][convVideoLib_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvVideoLib_Resource_RelEN.FileUpTime = objDT.Rows[0][convVideoLib_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvVideoLib_Resource_RelEN.FileSize = objDT.Rows[0][convVideoLib_Resource_Rel.FileSize].ToString().Trim(); //文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvVideoLib_Resource_RelEN.FileType = objDT.Rows[0][convVideoLib_Resource_Rel.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvVideoLib_Resource_RelEN.ResourceOwner = objDT.Rows[0][convVideoLib_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者(字段类型:varchar,字段长度:50,是否可空:False)
 objvVideoLib_Resource_RelEN.IsExistFile = TransNullToBool(objDT.Rows[0][convVideoLib_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objvVideoLib_Resource_RelEN.IdFile = objDT.Rows[0][convVideoLib_Resource_Rel.IdFile].ToString().Trim(); //文件流水号(字段类型:char,字段长度:8,是否可空:True)
 objvVideoLib_Resource_RelEN.FileName = objDT.Rows[0][convVideoLib_Resource_Rel.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvVideoLib_Resource_RelEN.SaveDate = objDT.Rows[0][convVideoLib_Resource_Rel.SaveDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvVideoLib_Resource_RelEN.SaveTime = objDT.Rows[0][convVideoLib_Resource_Rel.SaveTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvVideoLib_Resource_RelEN.FileOriginName = objDT.Rows[0][convVideoLib_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名(字段类型:varchar,字段长度:500,是否可空:True)
 objvVideoLib_Resource_RelEN.IdResourceType = objDT.Rows[0][convVideoLib_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvVideoLib_Resource_RelEN.ResourceTypeID = objDT.Rows[0][convVideoLib_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvVideoLib_Resource_RelEN.ResourceTypeName = objDT.Rows[0][convVideoLib_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvVideoLib_Resource_RelEN.FileNewName = objDT.Rows[0][convVideoLib_Resource_Rel.FileNewName].ToString().Trim(); //新文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvVideoLib_Resource_RelEN.FileOldName = objDT.Rows[0][convVideoLib_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvVideoLib_Resource_RelEN.ftpFileType = objDT.Rows[0][convVideoLib_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvVideoLib_Resource_RelEN.ftpFileSize = objDT.Rows[0][convVideoLib_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvVideoLib_Resource_RelEN.ftpResourceOwner = objDT.Rows[0][convVideoLib_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者(字段类型:varchar,字段长度:50,是否可空:True)
 objvVideoLib_Resource_RelEN.IsMain = TransNullToBool(objDT.Rows[0][convVideoLib_Resource_Rel.IsMain].ToString().Trim()); //是否主资源(字段类型:bit,字段长度:1,是否可空:True)
 objvVideoLib_Resource_RelEN.IdUsingMode = objDT.Rows[0][convVideoLib_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号(字段类型:char,字段长度:4,是否可空:False)
 objvVideoLib_Resource_RelEN.IsVisible = TransNullToBool(objDT.Rows[0][convVideoLib_Resource_Rel.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvVideoLib_Resource_RelEN.IndexNO = TransNullToInt(objDT.Rows[0][convVideoLib_Resource_Rel.IndexNO].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvVideoLib_Resource_RelEN.BrowseCount = TransNullToInt(objDT.Rows[0][convVideoLib_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvVideoLib_Resource_RelEN.UpdDate = objDT.Rows[0][convVideoLib_Resource_Rel.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvVideoLib_Resource_RelEN.UpdUser = objDT.Rows[0][convVideoLib_Resource_Rel.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvVideoLib_Resource_RelEN.Memo = objDT.Rows[0][convVideoLib_Resource_Rel.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvVideoLib_Resource_RelDA: GetvVideoLib_Resource_Rel)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdMicroteachCaseResourceRel">表关键字</param>
 /// <returns>表对象</returns>
public clsvVideoLib_Resource_RelEN GetObjByIdMicroteachCaseResourceRel(long lngIdMicroteachCaseResourceRel)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLib_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vVideoLib_Resource_Rel where IdMicroteachCaseResourceRel = " + ""+ lngIdMicroteachCaseResourceRel+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN = new clsvVideoLib_Resource_RelEN();
try
{
 objvVideoLib_Resource_RelEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convVideoLib_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvVideoLib_Resource_RelEN.FuncModuleId = objRow[convVideoLib_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvVideoLib_Resource_RelEN.FuncModuleName = objRow[convVideoLib_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvVideoLib_Resource_RelEN.IdMicroteachCase = objRow[convVideoLib_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoLib_Resource_RelEN.VideoLibID = objRow[convVideoLib_Resource_Rel.VideoLibID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibID].ToString().Trim(); //视频库ID(字段类型:char,字段长度:8,是否可空:False)
 objvVideoLib_Resource_RelEN.VideoLibName = objRow[convVideoLib_Resource_Rel.VideoLibName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibName].ToString().Trim(); //视频名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvVideoLib_Resource_RelEN.VideoLibTheme = objRow[convVideoLib_Resource_Rel.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibTheme].ToString().Trim(); //视频库主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoLib_Resource_RelEN.IdVideoLibType = objRow[convVideoLib_Resource_Rel.IdVideoLibType] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdVideoLibType].ToString().Trim(); //视频库类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvVideoLib_Resource_RelEN.VideoLibTypeName = objRow[convVideoLib_Resource_Rel.VideoLibTypeName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibTypeName].ToString().Trim(); //视频库类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvVideoLib_Resource_RelEN.VideoLibText = objRow[convVideoLib_Resource_Rel.VideoLibText] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objvVideoLib_Resource_RelEN.VideoLibDate = objRow[convVideoLib_Resource_Rel.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibDate].ToString().Trim(); //视频资源日期(字段类型:char,字段长度:8,是否可空:True)
 objvVideoLib_Resource_RelEN.VideoLibTime = objRow[convVideoLib_Resource_Rel.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibTime].ToString().Trim(); //视频资源时间(字段类型:char,字段长度:6,是否可空:True)
 objvVideoLib_Resource_RelEN.VideoLibDateIn = objRow[convVideoLib_Resource_Rel.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvVideoLib_Resource_RelEN.VideoLibTimeIn = objRow[convVideoLib_Resource_Rel.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvVideoLib_Resource_RelEN.OwnerId = objRow[convVideoLib_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvVideoLib_Resource_RelEN.IdTeachingPlan = objRow[convVideoLib_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoLib_Resource_RelEN.senateGaugeVersionID = objRow[convVideoLib_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvVideoLib_Resource_RelEN.senateGaugeVersionName = objRow[convVideoLib_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoLib_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convVideoLib_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convVideoLib_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvVideoLib_Resource_RelEN.VersionNo = objRow[convVideoLib_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvVideoLib_Resource_RelEN.CaseLevelId = objRow[convVideoLib_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvVideoLib_Resource_RelEN.IdXzCollege = objRow[convVideoLib_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvVideoLib_Resource_RelEN.CollegeID = objRow[convVideoLib_Resource_Rel.CollegeID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvVideoLib_Resource_RelEN.CollegeName = objRow[convVideoLib_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvVideoLib_Resource_RelEN.CollegeNameA = objRow[convVideoLib_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvVideoLib_Resource_RelEN.ViewCount = objRow[convVideoLib_Resource_Rel.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvVideoLib_Resource_RelEN.DownloadNumber = objRow[convVideoLib_Resource_Rel.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.DownloadNumber].ToString().Trim()); //下载数目(字段类型:int,字段长度:4,是否可空:True)
 objvVideoLib_Resource_RelEN.FileIntegration = objRow[convVideoLib_Resource_Rel.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.FileIntegration].ToString().Trim()); //文件积分(字段类型:int,字段长度:4,是否可空:True)
 objvVideoLib_Resource_RelEN.LikeCount = objRow[convVideoLib_Resource_Rel.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.LikeCount].ToString().Trim()); //资源喜欢数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvVideoLib_Resource_RelEN.CollectionCount = objRow[convVideoLib_Resource_Rel.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvVideoLib_Resource_RelEN.RecommendedDegreeId = objRow[convVideoLib_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvVideoLib_Resource_RelEN.RecommendedDegreeName = objRow[convVideoLib_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvVideoLib_Resource_RelEN.CourseId = objRow[convVideoLib_Resource_Rel.CourseId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvVideoLib_Resource_RelEN.CourseCode = objRow[convVideoLib_Resource_Rel.CourseCode] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvVideoLib_Resource_RelEN.CourseName = objRow[convVideoLib_Resource_Rel.CourseName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvVideoLib_Resource_RelEN.BrowseCount4Case = objRow[convVideoLib_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvVideoLib_Resource_RelEN.OwnerName = objRow[convVideoLib_Resource_Rel.OwnerName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvVideoLib_Resource_RelEN.OwnerNameWithId = objRow[convVideoLib_Resource_Rel.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
 objvVideoLib_Resource_RelEN.IdResource = objRow[convVideoLib_Resource_Rel.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoLib_Resource_RelEN.ResourceID = objRow[convVideoLib_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceID].ToString().Trim(); //资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvVideoLib_Resource_RelEN.ResourceName = objRow[convVideoLib_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceName].ToString().Trim(); //资源名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvVideoLib_Resource_RelEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式(字段类型:bit,字段长度:1,是否可空:True)
 objvVideoLib_Resource_RelEN.IdFtpResource = objRow[convVideoLib_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objvVideoLib_Resource_RelEN.FtpResourceID = objRow[convVideoLib_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvVideoLib_Resource_RelEN.FileOriginalName = objRow[convVideoLib_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoLib_Resource_RelEN.FileDirName = objRow[convVideoLib_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoLib_Resource_RelEN.FileRename = objRow[convVideoLib_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileRename].ToString().Trim(); //文件新名(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoLib_Resource_RelEN.FileUpDate = objRow[convVideoLib_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvVideoLib_Resource_RelEN.FileUpTime = objRow[convVideoLib_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvVideoLib_Resource_RelEN.FileSize = objRow[convVideoLib_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileSize].ToString().Trim(); //文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvVideoLib_Resource_RelEN.FileType = objRow[convVideoLib_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvVideoLib_Resource_RelEN.ResourceOwner = objRow[convVideoLib_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者(字段类型:varchar,字段长度:50,是否可空:False)
 objvVideoLib_Resource_RelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objvVideoLib_Resource_RelEN.IdFile = objRow[convVideoLib_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdFile].ToString().Trim(); //文件流水号(字段类型:char,字段长度:8,是否可空:True)
 objvVideoLib_Resource_RelEN.FileName = objRow[convVideoLib_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvVideoLib_Resource_RelEN.SaveDate = objRow[convVideoLib_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.SaveDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvVideoLib_Resource_RelEN.SaveTime = objRow[convVideoLib_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.SaveTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvVideoLib_Resource_RelEN.FileOriginName = objRow[convVideoLib_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名(字段类型:varchar,字段长度:500,是否可空:True)
 objvVideoLib_Resource_RelEN.IdResourceType = objRow[convVideoLib_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvVideoLib_Resource_RelEN.ResourceTypeID = objRow[convVideoLib_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvVideoLib_Resource_RelEN.ResourceTypeName = objRow[convVideoLib_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvVideoLib_Resource_RelEN.FileNewName = objRow[convVideoLib_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileNewName].ToString().Trim(); //新文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvVideoLib_Resource_RelEN.FileOldName = objRow[convVideoLib_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvVideoLib_Resource_RelEN.ftpFileType = objRow[convVideoLib_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvVideoLib_Resource_RelEN.ftpFileSize = objRow[convVideoLib_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvVideoLib_Resource_RelEN.ftpResourceOwner = objRow[convVideoLib_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者(字段类型:varchar,字段长度:50,是否可空:True)
 objvVideoLib_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib_Resource_Rel.IsMain].ToString().Trim()); //是否主资源(字段类型:bit,字段长度:1,是否可空:True)
 objvVideoLib_Resource_RelEN.IdUsingMode = objRow[convVideoLib_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号(字段类型:char,字段长度:4,是否可空:False)
 objvVideoLib_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib_Resource_Rel.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvVideoLib_Resource_RelEN.IndexNO = objRow[convVideoLib_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.IndexNO].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvVideoLib_Resource_RelEN.BrowseCount = objRow[convVideoLib_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvVideoLib_Resource_RelEN.UpdDate = objRow[convVideoLib_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvVideoLib_Resource_RelEN.UpdUser = objRow[convVideoLib_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvVideoLib_Resource_RelEN.Memo = objRow[convVideoLib_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvVideoLib_Resource_RelDA: GetObjByIdMicroteachCaseResourceRel)", objException.Message));
}
return objvVideoLib_Resource_RelEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvVideoLib_Resource_RelEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvVideoLib_Resource_RelDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLib_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vVideoLib_Resource_Rel where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN = new clsvVideoLib_Resource_RelEN()
{
IdMicroteachCaseResourceRel = TransNullToInt(objRow[convVideoLib_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()), //微格案例资源关系流水号
FuncModuleId = objRow[convVideoLib_Resource_Rel.FuncModuleId].ToString().Trim(), //功能模块Id
FuncModuleName = objRow[convVideoLib_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FuncModuleName].ToString().Trim(), //功能模块名称
IdMicroteachCase = objRow[convVideoLib_Resource_Rel.IdMicroteachCase].ToString().Trim(), //微格教学案例流水号
VideoLibID = objRow[convVideoLib_Resource_Rel.VideoLibID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibID].ToString().Trim(), //视频库ID
VideoLibName = objRow[convVideoLib_Resource_Rel.VideoLibName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibName].ToString().Trim(), //视频名称
VideoLibTheme = objRow[convVideoLib_Resource_Rel.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibTheme].ToString().Trim(), //视频库主题词
IdVideoLibType = objRow[convVideoLib_Resource_Rel.IdVideoLibType] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdVideoLibType].ToString().Trim(), //视频库类型流水号
VideoLibTypeName = objRow[convVideoLib_Resource_Rel.VideoLibTypeName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibTypeName].ToString().Trim(), //视频库类型名称
VideoLibText = objRow[convVideoLib_Resource_Rel.VideoLibText] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibText].ToString().Trim(), //案例文本内容
VideoLibDate = objRow[convVideoLib_Resource_Rel.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibDate].ToString().Trim(), //视频资源日期
VideoLibTime = objRow[convVideoLib_Resource_Rel.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibTime].ToString().Trim(), //视频资源时间
VideoLibDateIn = objRow[convVideoLib_Resource_Rel.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibDateIn].ToString().Trim(), //案例入库日期
VideoLibTimeIn = objRow[convVideoLib_Resource_Rel.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibTimeIn].ToString().Trim(), //案例入库时间
OwnerId = objRow[convVideoLib_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.OwnerId].ToString().Trim(), //拥有者Id
IdTeachingPlan = objRow[convVideoLib_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdTeachingPlan].ToString().Trim(), //教案流水号
senateGaugeVersionID = objRow[convVideoLib_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.senateGaugeVersionID].ToString().Trim(), //评价量表版本ID
senateGaugeVersionName = objRow[convVideoLib_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.senateGaugeVersionName].ToString().Trim(), //评价量表版本名称
senateGaugeVersionTtlScore = objRow[convVideoLib_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convVideoLib_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()), //评价量表版本总分
VersionNo = objRow[convVideoLib_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib_Resource_Rel.VersionNo].ToString().Trim()), //版本号
CaseLevelId = objRow[convVideoLib_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CaseLevelId].ToString().Trim(), //课例等级Id
IdXzCollege = objRow[convVideoLib_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdXzCollege].ToString().Trim(), //学院流水号
CollegeID = objRow[convVideoLib_Resource_Rel.CollegeID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CollegeID].ToString().Trim(), //学院ID
CollegeName = objRow[convVideoLib_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CollegeName].ToString().Trim(), //学院名称
CollegeNameA = objRow[convVideoLib_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CollegeNameA].ToString().Trim(), //学院名称简写
ViewCount = objRow[convVideoLib_Resource_Rel.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib_Resource_Rel.ViewCount].ToString().Trim()), //浏览量
DownloadNumber = objRow[convVideoLib_Resource_Rel.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib_Resource_Rel.DownloadNumber].ToString().Trim()), //下载数目
FileIntegration = objRow[convVideoLib_Resource_Rel.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib_Resource_Rel.FileIntegration].ToString().Trim()), //文件积分
LikeCount = objRow[convVideoLib_Resource_Rel.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoLib_Resource_Rel.LikeCount].ToString().Trim()), //资源喜欢数量
CollectionCount = objRow[convVideoLib_Resource_Rel.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoLib_Resource_Rel.CollectionCount].ToString().Trim()), //收藏数量
RecommendedDegreeId = objRow[convVideoLib_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.RecommendedDegreeId].ToString().Trim(), //推荐度Id
RecommendedDegreeName = objRow[convVideoLib_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.RecommendedDegreeName].ToString().Trim(), //推荐度名称
CourseId = objRow[convVideoLib_Resource_Rel.CourseId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CourseId].ToString().Trim(), //课程Id
CourseCode = objRow[convVideoLib_Resource_Rel.CourseCode] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CourseCode].ToString().Trim(), //课程代码
CourseName = objRow[convVideoLib_Resource_Rel.CourseName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CourseName].ToString().Trim(), //课程名称
BrowseCount4Case = objRow[convVideoLib_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib_Resource_Rel.BrowseCount4Case].ToString().Trim()), //课例浏览次数
OwnerName = objRow[convVideoLib_Resource_Rel.OwnerName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.OwnerName].ToString().Trim(), //拥有者姓名
OwnerNameWithId = objRow[convVideoLib_Resource_Rel.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.OwnerNameWithId].ToString().Trim(), //拥有者名称附Id
IdResource = objRow[convVideoLib_Resource_Rel.IdResource].ToString().Trim(), //资源流水号
ResourceID = objRow[convVideoLib_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceID].ToString().Trim(), //资源ID
ResourceName = objRow[convVideoLib_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceName].ToString().Trim(), //资源名称
SaveMode = TransNullToBool(objRow[convVideoLib_Resource_Rel.SaveMode].ToString().Trim()), //文件存放方式
IdFtpResource = objRow[convVideoLib_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdFtpResource].ToString().Trim(), //FTP资源流水号
FtpResourceID = objRow[convVideoLib_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FtpResourceID].ToString().Trim(), //FTP资源ID
FileOriginalName = objRow[convVideoLib_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileOriginalName].ToString().Trim(), //文件原名
FileDirName = objRow[convVideoLib_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileDirName].ToString().Trim(), //文件目录名
FileRename = objRow[convVideoLib_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileRename].ToString().Trim(), //文件新名
FileUpDate = objRow[convVideoLib_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileUpDate].ToString().Trim(), //创建日期
FileUpTime = objRow[convVideoLib_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileUpTime].ToString().Trim(), //创建时间
FileSize = objRow[convVideoLib_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileSize].ToString().Trim(), //文件大小
FileType = objRow[convVideoLib_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileType].ToString().Trim(), //文件类型
ResourceOwner = objRow[convVideoLib_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceOwner].ToString().Trim(), //上传者
IsExistFile = TransNullToBool(objRow[convVideoLib_Resource_Rel.IsExistFile].ToString().Trim()), //是否存在文件
IdFile = objRow[convVideoLib_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdFile].ToString().Trim(), //文件流水号
FileName = objRow[convVideoLib_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileName].ToString().Trim(), //文件名称
SaveDate = objRow[convVideoLib_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.SaveDate].ToString().Trim(), //创建日期
SaveTime = objRow[convVideoLib_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.SaveTime].ToString().Trim(), //创建时间
FileOriginName = objRow[convVideoLib_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileOriginName].ToString().Trim(), //原文件名
IdResourceType = objRow[convVideoLib_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdResourceType].ToString().Trim(), //资源类型流水号
ResourceTypeID = objRow[convVideoLib_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceTypeID].ToString().Trim(), //资源类型ID
ResourceTypeName = objRow[convVideoLib_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceTypeName].ToString().Trim(), //资源类型名称
FileNewName = objRow[convVideoLib_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileNewName].ToString().Trim(), //新文件名
FileOldName = objRow[convVideoLib_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileOldName].ToString().Trim(), //旧文件名
ftpFileType = objRow[convVideoLib_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ftpFileType].ToString().Trim(), //ftp文件类型
ftpFileSize = objRow[convVideoLib_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ftpFileSize].ToString().Trim(), //ftp文件大小
ftpResourceOwner = objRow[convVideoLib_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ftpResourceOwner].ToString().Trim(), //Ftp资源拥有者
IsMain = TransNullToBool(objRow[convVideoLib_Resource_Rel.IsMain].ToString().Trim()), //是否主资源
IdUsingMode = objRow[convVideoLib_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdUsingMode].ToString().Trim(), //资源使用模式流水号
IsVisible = TransNullToBool(objRow[convVideoLib_Resource_Rel.IsVisible].ToString().Trim()), //是否显示
IndexNO = objRow[convVideoLib_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib_Resource_Rel.IndexNO].ToString().Trim()), //序号
BrowseCount = objRow[convVideoLib_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib_Resource_Rel.BrowseCount].ToString().Trim()), //浏览次数
UpdDate = objRow[convVideoLib_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convVideoLib_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convVideoLib_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.Memo].ToString().Trim() //备注
};
objvVideoLib_Resource_RelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvVideoLib_Resource_RelEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvVideoLib_Resource_RelDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvVideoLib_Resource_RelEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN = new clsvVideoLib_Resource_RelEN();
try
{
objvVideoLib_Resource_RelEN.IdMicroteachCaseResourceRel = TransNullToInt(objRow[convVideoLib_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvVideoLib_Resource_RelEN.FuncModuleId = objRow[convVideoLib_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoLib_Resource_RelEN.FuncModuleName = objRow[convVideoLib_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoLib_Resource_RelEN.IdMicroteachCase = objRow[convVideoLib_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoLib_Resource_RelEN.VideoLibID = objRow[convVideoLib_Resource_Rel.VideoLibID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLib_Resource_RelEN.VideoLibName = objRow[convVideoLib_Resource_Rel.VideoLibName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibName].ToString().Trim(); //视频名称
objvVideoLib_Resource_RelEN.VideoLibTheme = objRow[convVideoLib_Resource_Rel.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibTheme].ToString().Trim(); //视频库主题词
objvVideoLib_Resource_RelEN.IdVideoLibType = objRow[convVideoLib_Resource_Rel.IdVideoLibType] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdVideoLibType].ToString().Trim(); //视频库类型流水号
objvVideoLib_Resource_RelEN.VideoLibTypeName = objRow[convVideoLib_Resource_Rel.VideoLibTypeName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibTypeName].ToString().Trim(); //视频库类型名称
objvVideoLib_Resource_RelEN.VideoLibText = objRow[convVideoLib_Resource_Rel.VideoLibText] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibText].ToString().Trim(); //案例文本内容
objvVideoLib_Resource_RelEN.VideoLibDate = objRow[convVideoLib_Resource_Rel.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibDate].ToString().Trim(); //视频资源日期
objvVideoLib_Resource_RelEN.VideoLibTime = objRow[convVideoLib_Resource_Rel.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibTime].ToString().Trim(); //视频资源时间
objvVideoLib_Resource_RelEN.VideoLibDateIn = objRow[convVideoLib_Resource_Rel.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibDateIn].ToString().Trim(); //案例入库日期
objvVideoLib_Resource_RelEN.VideoLibTimeIn = objRow[convVideoLib_Resource_Rel.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objvVideoLib_Resource_RelEN.OwnerId = objRow[convVideoLib_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvVideoLib_Resource_RelEN.IdTeachingPlan = objRow[convVideoLib_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvVideoLib_Resource_RelEN.senateGaugeVersionID = objRow[convVideoLib_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoLib_Resource_RelEN.senateGaugeVersionName = objRow[convVideoLib_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoLib_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convVideoLib_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convVideoLib_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoLib_Resource_RelEN.VersionNo = objRow[convVideoLib_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvVideoLib_Resource_RelEN.CaseLevelId = objRow[convVideoLib_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvVideoLib_Resource_RelEN.IdXzCollege = objRow[convVideoLib_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLib_Resource_RelEN.CollegeID = objRow[convVideoLib_Resource_Rel.CollegeID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CollegeID].ToString().Trim(); //学院ID
objvVideoLib_Resource_RelEN.CollegeName = objRow[convVideoLib_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvVideoLib_Resource_RelEN.CollegeNameA = objRow[convVideoLib_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoLib_Resource_RelEN.ViewCount = objRow[convVideoLib_Resource_Rel.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib_Resource_Rel.ViewCount].ToString().Trim()); //浏览量
objvVideoLib_Resource_RelEN.DownloadNumber = objRow[convVideoLib_Resource_Rel.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib_Resource_Rel.DownloadNumber].ToString().Trim()); //下载数目
objvVideoLib_Resource_RelEN.FileIntegration = objRow[convVideoLib_Resource_Rel.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib_Resource_Rel.FileIntegration].ToString().Trim()); //文件积分
objvVideoLib_Resource_RelEN.LikeCount = objRow[convVideoLib_Resource_Rel.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoLib_Resource_Rel.LikeCount].ToString().Trim()); //资源喜欢数量
objvVideoLib_Resource_RelEN.CollectionCount = objRow[convVideoLib_Resource_Rel.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoLib_Resource_Rel.CollectionCount].ToString().Trim()); //收藏数量
objvVideoLib_Resource_RelEN.RecommendedDegreeId = objRow[convVideoLib_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvVideoLib_Resource_RelEN.RecommendedDegreeName = objRow[convVideoLib_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvVideoLib_Resource_RelEN.CourseId = objRow[convVideoLib_Resource_Rel.CourseId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CourseId].ToString().Trim(); //课程Id
objvVideoLib_Resource_RelEN.CourseCode = objRow[convVideoLib_Resource_Rel.CourseCode] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CourseCode].ToString().Trim(); //课程代码
objvVideoLib_Resource_RelEN.CourseName = objRow[convVideoLib_Resource_Rel.CourseName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CourseName].ToString().Trim(); //课程名称
objvVideoLib_Resource_RelEN.BrowseCount4Case = objRow[convVideoLib_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvVideoLib_Resource_RelEN.OwnerName = objRow[convVideoLib_Resource_Rel.OwnerName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.OwnerName].ToString().Trim(); //拥有者姓名
objvVideoLib_Resource_RelEN.OwnerNameWithId = objRow[convVideoLib_Resource_Rel.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvVideoLib_Resource_RelEN.IdResource = objRow[convVideoLib_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvVideoLib_Resource_RelEN.ResourceID = objRow[convVideoLib_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvVideoLib_Resource_RelEN.ResourceName = objRow[convVideoLib_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvVideoLib_Resource_RelEN.SaveMode = TransNullToBool(objRow[convVideoLib_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvVideoLib_Resource_RelEN.IdFtpResource = objRow[convVideoLib_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvVideoLib_Resource_RelEN.FtpResourceID = objRow[convVideoLib_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvVideoLib_Resource_RelEN.FileOriginalName = objRow[convVideoLib_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvVideoLib_Resource_RelEN.FileDirName = objRow[convVideoLib_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvVideoLib_Resource_RelEN.FileRename = objRow[convVideoLib_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvVideoLib_Resource_RelEN.FileUpDate = objRow[convVideoLib_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvVideoLib_Resource_RelEN.FileUpTime = objRow[convVideoLib_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvVideoLib_Resource_RelEN.FileSize = objRow[convVideoLib_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvVideoLib_Resource_RelEN.FileType = objRow[convVideoLib_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvVideoLib_Resource_RelEN.ResourceOwner = objRow[convVideoLib_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvVideoLib_Resource_RelEN.IsExistFile = TransNullToBool(objRow[convVideoLib_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvVideoLib_Resource_RelEN.IdFile = objRow[convVideoLib_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvVideoLib_Resource_RelEN.FileName = objRow[convVideoLib_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvVideoLib_Resource_RelEN.SaveDate = objRow[convVideoLib_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvVideoLib_Resource_RelEN.SaveTime = objRow[convVideoLib_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvVideoLib_Resource_RelEN.FileOriginName = objRow[convVideoLib_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvVideoLib_Resource_RelEN.IdResourceType = objRow[convVideoLib_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvVideoLib_Resource_RelEN.ResourceTypeID = objRow[convVideoLib_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvVideoLib_Resource_RelEN.ResourceTypeName = objRow[convVideoLib_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvVideoLib_Resource_RelEN.FileNewName = objRow[convVideoLib_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvVideoLib_Resource_RelEN.FileOldName = objRow[convVideoLib_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvVideoLib_Resource_RelEN.ftpFileType = objRow[convVideoLib_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvVideoLib_Resource_RelEN.ftpFileSize = objRow[convVideoLib_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvVideoLib_Resource_RelEN.ftpResourceOwner = objRow[convVideoLib_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvVideoLib_Resource_RelEN.IsMain = TransNullToBool(objRow[convVideoLib_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvVideoLib_Resource_RelEN.IdUsingMode = objRow[convVideoLib_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvVideoLib_Resource_RelEN.IsVisible = TransNullToBool(objRow[convVideoLib_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvVideoLib_Resource_RelEN.IndexNO = objRow[convVideoLib_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvVideoLib_Resource_RelEN.BrowseCount = objRow[convVideoLib_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvVideoLib_Resource_RelEN.UpdDate = objRow[convVideoLib_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvVideoLib_Resource_RelEN.UpdUser = objRow[convVideoLib_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvVideoLib_Resource_RelEN.Memo = objRow[convVideoLib_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvVideoLib_Resource_RelDA: GetObjByDataRowvVideoLib_Resource_Rel)", objException.Message));
}
objvVideoLib_Resource_RelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvVideoLib_Resource_RelEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvVideoLib_Resource_RelEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN = new clsvVideoLib_Resource_RelEN();
try
{
objvVideoLib_Resource_RelEN.IdMicroteachCaseResourceRel = TransNullToInt(objRow[convVideoLib_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvVideoLib_Resource_RelEN.FuncModuleId = objRow[convVideoLib_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoLib_Resource_RelEN.FuncModuleName = objRow[convVideoLib_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoLib_Resource_RelEN.IdMicroteachCase = objRow[convVideoLib_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoLib_Resource_RelEN.VideoLibID = objRow[convVideoLib_Resource_Rel.VideoLibID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLib_Resource_RelEN.VideoLibName = objRow[convVideoLib_Resource_Rel.VideoLibName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibName].ToString().Trim(); //视频名称
objvVideoLib_Resource_RelEN.VideoLibTheme = objRow[convVideoLib_Resource_Rel.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibTheme].ToString().Trim(); //视频库主题词
objvVideoLib_Resource_RelEN.IdVideoLibType = objRow[convVideoLib_Resource_Rel.IdVideoLibType] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdVideoLibType].ToString().Trim(); //视频库类型流水号
objvVideoLib_Resource_RelEN.VideoLibTypeName = objRow[convVideoLib_Resource_Rel.VideoLibTypeName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibTypeName].ToString().Trim(); //视频库类型名称
objvVideoLib_Resource_RelEN.VideoLibText = objRow[convVideoLib_Resource_Rel.VideoLibText] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibText].ToString().Trim(); //案例文本内容
objvVideoLib_Resource_RelEN.VideoLibDate = objRow[convVideoLib_Resource_Rel.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibDate].ToString().Trim(); //视频资源日期
objvVideoLib_Resource_RelEN.VideoLibTime = objRow[convVideoLib_Resource_Rel.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibTime].ToString().Trim(); //视频资源时间
objvVideoLib_Resource_RelEN.VideoLibDateIn = objRow[convVideoLib_Resource_Rel.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibDateIn].ToString().Trim(); //案例入库日期
objvVideoLib_Resource_RelEN.VideoLibTimeIn = objRow[convVideoLib_Resource_Rel.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objvVideoLib_Resource_RelEN.OwnerId = objRow[convVideoLib_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvVideoLib_Resource_RelEN.IdTeachingPlan = objRow[convVideoLib_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvVideoLib_Resource_RelEN.senateGaugeVersionID = objRow[convVideoLib_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoLib_Resource_RelEN.senateGaugeVersionName = objRow[convVideoLib_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoLib_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convVideoLib_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convVideoLib_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoLib_Resource_RelEN.VersionNo = objRow[convVideoLib_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvVideoLib_Resource_RelEN.CaseLevelId = objRow[convVideoLib_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvVideoLib_Resource_RelEN.IdXzCollege = objRow[convVideoLib_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLib_Resource_RelEN.CollegeID = objRow[convVideoLib_Resource_Rel.CollegeID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CollegeID].ToString().Trim(); //学院ID
objvVideoLib_Resource_RelEN.CollegeName = objRow[convVideoLib_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvVideoLib_Resource_RelEN.CollegeNameA = objRow[convVideoLib_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoLib_Resource_RelEN.ViewCount = objRow[convVideoLib_Resource_Rel.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib_Resource_Rel.ViewCount].ToString().Trim()); //浏览量
objvVideoLib_Resource_RelEN.DownloadNumber = objRow[convVideoLib_Resource_Rel.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib_Resource_Rel.DownloadNumber].ToString().Trim()); //下载数目
objvVideoLib_Resource_RelEN.FileIntegration = objRow[convVideoLib_Resource_Rel.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib_Resource_Rel.FileIntegration].ToString().Trim()); //文件积分
objvVideoLib_Resource_RelEN.LikeCount = objRow[convVideoLib_Resource_Rel.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoLib_Resource_Rel.LikeCount].ToString().Trim()); //资源喜欢数量
objvVideoLib_Resource_RelEN.CollectionCount = objRow[convVideoLib_Resource_Rel.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoLib_Resource_Rel.CollectionCount].ToString().Trim()); //收藏数量
objvVideoLib_Resource_RelEN.RecommendedDegreeId = objRow[convVideoLib_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvVideoLib_Resource_RelEN.RecommendedDegreeName = objRow[convVideoLib_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvVideoLib_Resource_RelEN.CourseId = objRow[convVideoLib_Resource_Rel.CourseId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CourseId].ToString().Trim(); //课程Id
objvVideoLib_Resource_RelEN.CourseCode = objRow[convVideoLib_Resource_Rel.CourseCode] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CourseCode].ToString().Trim(); //课程代码
objvVideoLib_Resource_RelEN.CourseName = objRow[convVideoLib_Resource_Rel.CourseName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CourseName].ToString().Trim(); //课程名称
objvVideoLib_Resource_RelEN.BrowseCount4Case = objRow[convVideoLib_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvVideoLib_Resource_RelEN.OwnerName = objRow[convVideoLib_Resource_Rel.OwnerName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.OwnerName].ToString().Trim(); //拥有者姓名
objvVideoLib_Resource_RelEN.OwnerNameWithId = objRow[convVideoLib_Resource_Rel.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvVideoLib_Resource_RelEN.IdResource = objRow[convVideoLib_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvVideoLib_Resource_RelEN.ResourceID = objRow[convVideoLib_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvVideoLib_Resource_RelEN.ResourceName = objRow[convVideoLib_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvVideoLib_Resource_RelEN.SaveMode = TransNullToBool(objRow[convVideoLib_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvVideoLib_Resource_RelEN.IdFtpResource = objRow[convVideoLib_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvVideoLib_Resource_RelEN.FtpResourceID = objRow[convVideoLib_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvVideoLib_Resource_RelEN.FileOriginalName = objRow[convVideoLib_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvVideoLib_Resource_RelEN.FileDirName = objRow[convVideoLib_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvVideoLib_Resource_RelEN.FileRename = objRow[convVideoLib_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvVideoLib_Resource_RelEN.FileUpDate = objRow[convVideoLib_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvVideoLib_Resource_RelEN.FileUpTime = objRow[convVideoLib_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvVideoLib_Resource_RelEN.FileSize = objRow[convVideoLib_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvVideoLib_Resource_RelEN.FileType = objRow[convVideoLib_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvVideoLib_Resource_RelEN.ResourceOwner = objRow[convVideoLib_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvVideoLib_Resource_RelEN.IsExistFile = TransNullToBool(objRow[convVideoLib_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvVideoLib_Resource_RelEN.IdFile = objRow[convVideoLib_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvVideoLib_Resource_RelEN.FileName = objRow[convVideoLib_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvVideoLib_Resource_RelEN.SaveDate = objRow[convVideoLib_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvVideoLib_Resource_RelEN.SaveTime = objRow[convVideoLib_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvVideoLib_Resource_RelEN.FileOriginName = objRow[convVideoLib_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvVideoLib_Resource_RelEN.IdResourceType = objRow[convVideoLib_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvVideoLib_Resource_RelEN.ResourceTypeID = objRow[convVideoLib_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvVideoLib_Resource_RelEN.ResourceTypeName = objRow[convVideoLib_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvVideoLib_Resource_RelEN.FileNewName = objRow[convVideoLib_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvVideoLib_Resource_RelEN.FileOldName = objRow[convVideoLib_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvVideoLib_Resource_RelEN.ftpFileType = objRow[convVideoLib_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvVideoLib_Resource_RelEN.ftpFileSize = objRow[convVideoLib_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvVideoLib_Resource_RelEN.ftpResourceOwner = objRow[convVideoLib_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvVideoLib_Resource_RelEN.IsMain = TransNullToBool(objRow[convVideoLib_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvVideoLib_Resource_RelEN.IdUsingMode = objRow[convVideoLib_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvVideoLib_Resource_RelEN.IsVisible = TransNullToBool(objRow[convVideoLib_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvVideoLib_Resource_RelEN.IndexNO = objRow[convVideoLib_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvVideoLib_Resource_RelEN.BrowseCount = objRow[convVideoLib_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvVideoLib_Resource_RelEN.UpdDate = objRow[convVideoLib_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvVideoLib_Resource_RelEN.UpdUser = objRow[convVideoLib_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvVideoLib_Resource_RelEN.Memo = objRow[convVideoLib_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvVideoLib_Resource_RelDA: GetObjByDataRow)", objException.Message));
}
objvVideoLib_Resource_RelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvVideoLib_Resource_RelEN;
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
objSQL = clsvVideoLib_Resource_RelDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvVideoLib_Resource_RelEN._CurrTabName, convVideoLib_Resource_Rel.IdMicroteachCaseResourceRel, 8, "");
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
objSQL = clsvVideoLib_Resource_RelDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvVideoLib_Resource_RelEN._CurrTabName, convVideoLib_Resource_Rel.IdMicroteachCaseResourceRel, 8, strPrefix);
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
 objSQL = clsvVideoLib_Resource_RelDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdMicroteachCaseResourceRel from vVideoLib_Resource_Rel where " + strCondition;
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
 objSQL = clsvVideoLib_Resource_RelDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdMicroteachCaseResourceRel from vVideoLib_Resource_Rel where " + strCondition;
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
 objSQL = clsvVideoLib_Resource_RelDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vVideoLib_Resource_Rel", "IdMicroteachCaseResourceRel = " + ""+ lngIdMicroteachCaseResourceRel+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvVideoLib_Resource_RelDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLib_Resource_RelDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vVideoLib_Resource_Rel", strCondition))
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
objSQL = clsvVideoLib_Resource_RelDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vVideoLib_Resource_Rel");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelENS">源对象</param>
 /// <param name = "objvVideoLib_Resource_RelENT">目标对象</param>
public void CopyTo(clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelENS, clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelENT)
{
objvVideoLib_Resource_RelENT.IdMicroteachCaseResourceRel = objvVideoLib_Resource_RelENS.IdMicroteachCaseResourceRel; //微格案例资源关系流水号
objvVideoLib_Resource_RelENT.FuncModuleId = objvVideoLib_Resource_RelENS.FuncModuleId; //功能模块Id
objvVideoLib_Resource_RelENT.FuncModuleName = objvVideoLib_Resource_RelENS.FuncModuleName; //功能模块名称
objvVideoLib_Resource_RelENT.IdMicroteachCase = objvVideoLib_Resource_RelENS.IdMicroteachCase; //微格教学案例流水号
objvVideoLib_Resource_RelENT.VideoLibID = objvVideoLib_Resource_RelENS.VideoLibID; //视频库ID
objvVideoLib_Resource_RelENT.VideoLibName = objvVideoLib_Resource_RelENS.VideoLibName; //视频名称
objvVideoLib_Resource_RelENT.VideoLibTheme = objvVideoLib_Resource_RelENS.VideoLibTheme; //视频库主题词
objvVideoLib_Resource_RelENT.IdVideoLibType = objvVideoLib_Resource_RelENS.IdVideoLibType; //视频库类型流水号
objvVideoLib_Resource_RelENT.VideoLibTypeName = objvVideoLib_Resource_RelENS.VideoLibTypeName; //视频库类型名称
objvVideoLib_Resource_RelENT.VideoLibText = objvVideoLib_Resource_RelENS.VideoLibText; //案例文本内容
objvVideoLib_Resource_RelENT.VideoLibDate = objvVideoLib_Resource_RelENS.VideoLibDate; //视频资源日期
objvVideoLib_Resource_RelENT.VideoLibTime = objvVideoLib_Resource_RelENS.VideoLibTime; //视频资源时间
objvVideoLib_Resource_RelENT.VideoLibDateIn = objvVideoLib_Resource_RelENS.VideoLibDateIn; //案例入库日期
objvVideoLib_Resource_RelENT.VideoLibTimeIn = objvVideoLib_Resource_RelENS.VideoLibTimeIn; //案例入库时间
objvVideoLib_Resource_RelENT.OwnerId = objvVideoLib_Resource_RelENS.OwnerId; //拥有者Id
objvVideoLib_Resource_RelENT.IdTeachingPlan = objvVideoLib_Resource_RelENS.IdTeachingPlan; //教案流水号
objvVideoLib_Resource_RelENT.senateGaugeVersionID = objvVideoLib_Resource_RelENS.senateGaugeVersionID; //评价量表版本ID
objvVideoLib_Resource_RelENT.senateGaugeVersionName = objvVideoLib_Resource_RelENS.senateGaugeVersionName; //评价量表版本名称
objvVideoLib_Resource_RelENT.senateGaugeVersionTtlScore = objvVideoLib_Resource_RelENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvVideoLib_Resource_RelENT.VersionNo = objvVideoLib_Resource_RelENS.VersionNo; //版本号
objvVideoLib_Resource_RelENT.CaseLevelId = objvVideoLib_Resource_RelENS.CaseLevelId; //课例等级Id
objvVideoLib_Resource_RelENT.IdXzCollege = objvVideoLib_Resource_RelENS.IdXzCollege; //学院流水号
objvVideoLib_Resource_RelENT.CollegeID = objvVideoLib_Resource_RelENS.CollegeID; //学院ID
objvVideoLib_Resource_RelENT.CollegeName = objvVideoLib_Resource_RelENS.CollegeName; //学院名称
objvVideoLib_Resource_RelENT.CollegeNameA = objvVideoLib_Resource_RelENS.CollegeNameA; //学院名称简写
objvVideoLib_Resource_RelENT.ViewCount = objvVideoLib_Resource_RelENS.ViewCount; //浏览量
objvVideoLib_Resource_RelENT.DownloadNumber = objvVideoLib_Resource_RelENS.DownloadNumber; //下载数目
objvVideoLib_Resource_RelENT.FileIntegration = objvVideoLib_Resource_RelENS.FileIntegration; //文件积分
objvVideoLib_Resource_RelENT.LikeCount = objvVideoLib_Resource_RelENS.LikeCount; //资源喜欢数量
objvVideoLib_Resource_RelENT.CollectionCount = objvVideoLib_Resource_RelENS.CollectionCount; //收藏数量
objvVideoLib_Resource_RelENT.RecommendedDegreeId = objvVideoLib_Resource_RelENS.RecommendedDegreeId; //推荐度Id
objvVideoLib_Resource_RelENT.RecommendedDegreeName = objvVideoLib_Resource_RelENS.RecommendedDegreeName; //推荐度名称
objvVideoLib_Resource_RelENT.CourseId = objvVideoLib_Resource_RelENS.CourseId; //课程Id
objvVideoLib_Resource_RelENT.CourseCode = objvVideoLib_Resource_RelENS.CourseCode; //课程代码
objvVideoLib_Resource_RelENT.CourseName = objvVideoLib_Resource_RelENS.CourseName; //课程名称
objvVideoLib_Resource_RelENT.BrowseCount4Case = objvVideoLib_Resource_RelENS.BrowseCount4Case; //课例浏览次数
objvVideoLib_Resource_RelENT.OwnerName = objvVideoLib_Resource_RelENS.OwnerName; //拥有者姓名
objvVideoLib_Resource_RelENT.OwnerNameWithId = objvVideoLib_Resource_RelENS.OwnerNameWithId; //拥有者名称附Id
objvVideoLib_Resource_RelENT.IdResource = objvVideoLib_Resource_RelENS.IdResource; //资源流水号
objvVideoLib_Resource_RelENT.ResourceID = objvVideoLib_Resource_RelENS.ResourceID; //资源ID
objvVideoLib_Resource_RelENT.ResourceName = objvVideoLib_Resource_RelENS.ResourceName; //资源名称
objvVideoLib_Resource_RelENT.SaveMode = objvVideoLib_Resource_RelENS.SaveMode; //文件存放方式
objvVideoLib_Resource_RelENT.IdFtpResource = objvVideoLib_Resource_RelENS.IdFtpResource; //FTP资源流水号
objvVideoLib_Resource_RelENT.FtpResourceID = objvVideoLib_Resource_RelENS.FtpResourceID; //FTP资源ID
objvVideoLib_Resource_RelENT.FileOriginalName = objvVideoLib_Resource_RelENS.FileOriginalName; //文件原名
objvVideoLib_Resource_RelENT.FileDirName = objvVideoLib_Resource_RelENS.FileDirName; //文件目录名
objvVideoLib_Resource_RelENT.FileRename = objvVideoLib_Resource_RelENS.FileRename; //文件新名
objvVideoLib_Resource_RelENT.FileUpDate = objvVideoLib_Resource_RelENS.FileUpDate; //创建日期
objvVideoLib_Resource_RelENT.FileUpTime = objvVideoLib_Resource_RelENS.FileUpTime; //创建时间
objvVideoLib_Resource_RelENT.FileSize = objvVideoLib_Resource_RelENS.FileSize; //文件大小
objvVideoLib_Resource_RelENT.FileType = objvVideoLib_Resource_RelENS.FileType; //文件类型
objvVideoLib_Resource_RelENT.ResourceOwner = objvVideoLib_Resource_RelENS.ResourceOwner; //上传者
objvVideoLib_Resource_RelENT.IsExistFile = objvVideoLib_Resource_RelENS.IsExistFile; //是否存在文件
objvVideoLib_Resource_RelENT.IdFile = objvVideoLib_Resource_RelENS.IdFile; //文件流水号
objvVideoLib_Resource_RelENT.FileName = objvVideoLib_Resource_RelENS.FileName; //文件名称
objvVideoLib_Resource_RelENT.SaveDate = objvVideoLib_Resource_RelENS.SaveDate; //创建日期
objvVideoLib_Resource_RelENT.SaveTime = objvVideoLib_Resource_RelENS.SaveTime; //创建时间
objvVideoLib_Resource_RelENT.FileOriginName = objvVideoLib_Resource_RelENS.FileOriginName; //原文件名
objvVideoLib_Resource_RelENT.IdResourceType = objvVideoLib_Resource_RelENS.IdResourceType; //资源类型流水号
objvVideoLib_Resource_RelENT.ResourceTypeID = objvVideoLib_Resource_RelENS.ResourceTypeID; //资源类型ID
objvVideoLib_Resource_RelENT.ResourceTypeName = objvVideoLib_Resource_RelENS.ResourceTypeName; //资源类型名称
objvVideoLib_Resource_RelENT.FileNewName = objvVideoLib_Resource_RelENS.FileNewName; //新文件名
objvVideoLib_Resource_RelENT.FileOldName = objvVideoLib_Resource_RelENS.FileOldName; //旧文件名
objvVideoLib_Resource_RelENT.ftpFileType = objvVideoLib_Resource_RelENS.ftpFileType; //ftp文件类型
objvVideoLib_Resource_RelENT.ftpFileSize = objvVideoLib_Resource_RelENS.ftpFileSize; //ftp文件大小
objvVideoLib_Resource_RelENT.ftpResourceOwner = objvVideoLib_Resource_RelENS.ftpResourceOwner; //Ftp资源拥有者
objvVideoLib_Resource_RelENT.IsMain = objvVideoLib_Resource_RelENS.IsMain; //是否主资源
objvVideoLib_Resource_RelENT.IdUsingMode = objvVideoLib_Resource_RelENS.IdUsingMode; //资源使用模式流水号
objvVideoLib_Resource_RelENT.IsVisible = objvVideoLib_Resource_RelENS.IsVisible; //是否显示
objvVideoLib_Resource_RelENT.IndexNO = objvVideoLib_Resource_RelENS.IndexNO; //序号
objvVideoLib_Resource_RelENT.BrowseCount = objvVideoLib_Resource_RelENS.BrowseCount; //浏览次数
objvVideoLib_Resource_RelENT.UpdDate = objvVideoLib_Resource_RelENS.UpdDate; //修改日期
objvVideoLib_Resource_RelENT.UpdUser = objvVideoLib_Resource_RelENS.UpdUser; //修改人
objvVideoLib_Resource_RelENT.Memo = objvVideoLib_Resource_RelENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvVideoLib_Resource_RelEN.FuncModuleId, 4, convVideoLib_Resource_Rel.FuncModuleId);
clsCheckSql.CheckFieldLen(objvVideoLib_Resource_RelEN.FuncModuleName, 30, convVideoLib_Resource_Rel.FuncModuleName);
clsCheckSql.CheckFieldLen(objvVideoLib_Resource_RelEN.IdMicroteachCase, 8, convVideoLib_Resource_Rel.IdMicroteachCase);
clsCheckSql.CheckFieldLen(objvVideoLib_Resource_RelEN.VideoLibID, 8, convVideoLib_Resource_Rel.VideoLibID);
clsCheckSql.CheckFieldLen(objvVideoLib_Resource_RelEN.VideoLibName, 100, convVideoLib_Resource_Rel.VideoLibName);
clsCheckSql.CheckFieldLen(objvVideoLib_Resource_RelEN.VideoLibTheme, 200, convVideoLib_Resource_Rel.VideoLibTheme);
clsCheckSql.CheckFieldLen(objvVideoLib_Resource_RelEN.IdVideoLibType, 4, convVideoLib_Resource_Rel.IdVideoLibType);
clsCheckSql.CheckFieldLen(objvVideoLib_Resource_RelEN.VideoLibTypeName, 30, convVideoLib_Resource_Rel.VideoLibTypeName);
clsCheckSql.CheckFieldLen(objvVideoLib_Resource_RelEN.VideoLibText, 8000, convVideoLib_Resource_Rel.VideoLibText);
clsCheckSql.CheckFieldLen(objvVideoLib_Resource_RelEN.VideoLibDate, 8, convVideoLib_Resource_Rel.VideoLibDate);
clsCheckSql.CheckFieldLen(objvVideoLib_Resource_RelEN.VideoLibTime, 6, convVideoLib_Resource_Rel.VideoLibTime);
clsCheckSql.CheckFieldLen(objvVideoLib_Resource_RelEN.VideoLibDateIn, 8, convVideoLib_Resource_Rel.VideoLibDateIn);
clsCheckSql.CheckFieldLen(objvVideoLib_Resource_RelEN.VideoLibTimeIn, 6, convVideoLib_Resource_Rel.VideoLibTimeIn);
clsCheckSql.CheckFieldLen(objvVideoLib_Resource_RelEN.OwnerId, 20, convVideoLib_Resource_Rel.OwnerId);
clsCheckSql.CheckFieldLen(objvVideoLib_Resource_RelEN.IdTeachingPlan, 8, convVideoLib_Resource_Rel.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objvVideoLib_Resource_RelEN.senateGaugeVersionID, 4, convVideoLib_Resource_Rel.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(objvVideoLib_Resource_RelEN.senateGaugeVersionName, 200, convVideoLib_Resource_Rel.senateGaugeVersionName);
clsCheckSql.CheckFieldLen(objvVideoLib_Resource_RelEN.CaseLevelId, 2, convVideoLib_Resource_Rel.CaseLevelId);
clsCheckSql.CheckFieldLen(objvVideoLib_Resource_RelEN.IdXzCollege, 4, convVideoLib_Resource_Rel.IdXzCollege);
clsCheckSql.CheckFieldLen(objvVideoLib_Resource_RelEN.CollegeID, 4, convVideoLib_Resource_Rel.CollegeID);
clsCheckSql.CheckFieldLen(objvVideoLib_Resource_RelEN.CollegeName, 100, convVideoLib_Resource_Rel.CollegeName);
clsCheckSql.CheckFieldLen(objvVideoLib_Resource_RelEN.CollegeNameA, 12, convVideoLib_Resource_Rel.CollegeNameA);
clsCheckSql.CheckFieldLen(objvVideoLib_Resource_RelEN.RecommendedDegreeId, 2, convVideoLib_Resource_Rel.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objvVideoLib_Resource_RelEN.RecommendedDegreeName, 30, convVideoLib_Resource_Rel.RecommendedDegreeName);
clsCheckSql.CheckFieldLen(objvVideoLib_Resource_RelEN.CourseId, 8, convVideoLib_Resource_Rel.CourseId);
clsCheckSql.CheckFieldLen(objvVideoLib_Resource_RelEN.CourseCode, 20, convVideoLib_Resource_Rel.CourseCode);
clsCheckSql.CheckFieldLen(objvVideoLib_Resource_RelEN.CourseName, 100, convVideoLib_Resource_Rel.CourseName);
clsCheckSql.CheckFieldLen(objvVideoLib_Resource_RelEN.OwnerName, 30, convVideoLib_Resource_Rel.OwnerName);
clsCheckSql.CheckFieldLen(objvVideoLib_Resource_RelEN.OwnerNameWithId, 51, convVideoLib_Resource_Rel.OwnerNameWithId);
clsCheckSql.CheckFieldLen(objvVideoLib_Resource_RelEN.IdResource, 8, convVideoLib_Resource_Rel.IdResource);
clsCheckSql.CheckFieldLen(objvVideoLib_Resource_RelEN.ResourceID, 8, convVideoLib_Resource_Rel.ResourceID);
clsCheckSql.CheckFieldLen(objvVideoLib_Resource_RelEN.ResourceName, 100, convVideoLib_Resource_Rel.ResourceName);
clsCheckSql.CheckFieldLen(objvVideoLib_Resource_RelEN.IdFtpResource, 8, convVideoLib_Resource_Rel.IdFtpResource);
clsCheckSql.CheckFieldLen(objvVideoLib_Resource_RelEN.FtpResourceID, 8, convVideoLib_Resource_Rel.FtpResourceID);
clsCheckSql.CheckFieldLen(objvVideoLib_Resource_RelEN.FileOriginalName, 200, convVideoLib_Resource_Rel.FileOriginalName);
clsCheckSql.CheckFieldLen(objvVideoLib_Resource_RelEN.FileDirName, 200, convVideoLib_Resource_Rel.FileDirName);
clsCheckSql.CheckFieldLen(objvVideoLib_Resource_RelEN.FileRename, 200, convVideoLib_Resource_Rel.FileRename);
clsCheckSql.CheckFieldLen(objvVideoLib_Resource_RelEN.FileUpDate, 8, convVideoLib_Resource_Rel.FileUpDate);
clsCheckSql.CheckFieldLen(objvVideoLib_Resource_RelEN.FileUpTime, 6, convVideoLib_Resource_Rel.FileUpTime);
clsCheckSql.CheckFieldLen(objvVideoLib_Resource_RelEN.FileSize, 50, convVideoLib_Resource_Rel.FileSize);
clsCheckSql.CheckFieldLen(objvVideoLib_Resource_RelEN.FileType, 30, convVideoLib_Resource_Rel.FileType);
clsCheckSql.CheckFieldLen(objvVideoLib_Resource_RelEN.ResourceOwner, 50, convVideoLib_Resource_Rel.ResourceOwner);
clsCheckSql.CheckFieldLen(objvVideoLib_Resource_RelEN.IdFile, 8, convVideoLib_Resource_Rel.IdFile);
clsCheckSql.CheckFieldLen(objvVideoLib_Resource_RelEN.FileName, 500, convVideoLib_Resource_Rel.FileName);
clsCheckSql.CheckFieldLen(objvVideoLib_Resource_RelEN.SaveDate, 8, convVideoLib_Resource_Rel.SaveDate);
clsCheckSql.CheckFieldLen(objvVideoLib_Resource_RelEN.SaveTime, 6, convVideoLib_Resource_Rel.SaveTime);
clsCheckSql.CheckFieldLen(objvVideoLib_Resource_RelEN.FileOriginName, 500, convVideoLib_Resource_Rel.FileOriginName);
clsCheckSql.CheckFieldLen(objvVideoLib_Resource_RelEN.IdResourceType, 4, convVideoLib_Resource_Rel.IdResourceType);
clsCheckSql.CheckFieldLen(objvVideoLib_Resource_RelEN.ResourceTypeID, 4, convVideoLib_Resource_Rel.ResourceTypeID);
clsCheckSql.CheckFieldLen(objvVideoLib_Resource_RelEN.ResourceTypeName, 50, convVideoLib_Resource_Rel.ResourceTypeName);
clsCheckSql.CheckFieldLen(objvVideoLib_Resource_RelEN.FileNewName, 530, convVideoLib_Resource_Rel.FileNewName);
clsCheckSql.CheckFieldLen(objvVideoLib_Resource_RelEN.FileOldName, 530, convVideoLib_Resource_Rel.FileOldName);
clsCheckSql.CheckFieldLen(objvVideoLib_Resource_RelEN.ftpFileType, 30, convVideoLib_Resource_Rel.ftpFileType);
clsCheckSql.CheckFieldLen(objvVideoLib_Resource_RelEN.ftpFileSize, 50, convVideoLib_Resource_Rel.ftpFileSize);
clsCheckSql.CheckFieldLen(objvVideoLib_Resource_RelEN.ftpResourceOwner, 50, convVideoLib_Resource_Rel.ftpResourceOwner);
clsCheckSql.CheckFieldLen(objvVideoLib_Resource_RelEN.IdUsingMode, 4, convVideoLib_Resource_Rel.IdUsingMode);
clsCheckSql.CheckFieldLen(objvVideoLib_Resource_RelEN.UpdDate, 20, convVideoLib_Resource_Rel.UpdDate);
clsCheckSql.CheckFieldLen(objvVideoLib_Resource_RelEN.UpdUser, 20, convVideoLib_Resource_Rel.UpdUser);
clsCheckSql.CheckFieldLen(objvVideoLib_Resource_RelEN.Memo, 1000, convVideoLib_Resource_Rel.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_Resource_RelEN.FuncModuleId, convVideoLib_Resource_Rel.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_Resource_RelEN.FuncModuleName, convVideoLib_Resource_Rel.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_Resource_RelEN.IdMicroteachCase, convVideoLib_Resource_Rel.IdMicroteachCase);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_Resource_RelEN.VideoLibID, convVideoLib_Resource_Rel.VideoLibID);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_Resource_RelEN.VideoLibName, convVideoLib_Resource_Rel.VideoLibName);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_Resource_RelEN.VideoLibTheme, convVideoLib_Resource_Rel.VideoLibTheme);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_Resource_RelEN.IdVideoLibType, convVideoLib_Resource_Rel.IdVideoLibType);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_Resource_RelEN.VideoLibTypeName, convVideoLib_Resource_Rel.VideoLibTypeName);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_Resource_RelEN.VideoLibText, convVideoLib_Resource_Rel.VideoLibText);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_Resource_RelEN.VideoLibDate, convVideoLib_Resource_Rel.VideoLibDate);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_Resource_RelEN.VideoLibTime, convVideoLib_Resource_Rel.VideoLibTime);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_Resource_RelEN.VideoLibDateIn, convVideoLib_Resource_Rel.VideoLibDateIn);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_Resource_RelEN.VideoLibTimeIn, convVideoLib_Resource_Rel.VideoLibTimeIn);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_Resource_RelEN.OwnerId, convVideoLib_Resource_Rel.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_Resource_RelEN.IdTeachingPlan, convVideoLib_Resource_Rel.IdTeachingPlan);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_Resource_RelEN.senateGaugeVersionID, convVideoLib_Resource_Rel.senateGaugeVersionID);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_Resource_RelEN.senateGaugeVersionName, convVideoLib_Resource_Rel.senateGaugeVersionName);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_Resource_RelEN.CaseLevelId, convVideoLib_Resource_Rel.CaseLevelId);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_Resource_RelEN.IdXzCollege, convVideoLib_Resource_Rel.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_Resource_RelEN.CollegeID, convVideoLib_Resource_Rel.CollegeID);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_Resource_RelEN.CollegeName, convVideoLib_Resource_Rel.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_Resource_RelEN.CollegeNameA, convVideoLib_Resource_Rel.CollegeNameA);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_Resource_RelEN.RecommendedDegreeId, convVideoLib_Resource_Rel.RecommendedDegreeId);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_Resource_RelEN.RecommendedDegreeName, convVideoLib_Resource_Rel.RecommendedDegreeName);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_Resource_RelEN.CourseId, convVideoLib_Resource_Rel.CourseId);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_Resource_RelEN.CourseCode, convVideoLib_Resource_Rel.CourseCode);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_Resource_RelEN.CourseName, convVideoLib_Resource_Rel.CourseName);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_Resource_RelEN.OwnerName, convVideoLib_Resource_Rel.OwnerName);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_Resource_RelEN.OwnerNameWithId, convVideoLib_Resource_Rel.OwnerNameWithId);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_Resource_RelEN.IdResource, convVideoLib_Resource_Rel.IdResource);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_Resource_RelEN.ResourceID, convVideoLib_Resource_Rel.ResourceID);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_Resource_RelEN.ResourceName, convVideoLib_Resource_Rel.ResourceName);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_Resource_RelEN.IdFtpResource, convVideoLib_Resource_Rel.IdFtpResource);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_Resource_RelEN.FtpResourceID, convVideoLib_Resource_Rel.FtpResourceID);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_Resource_RelEN.FileOriginalName, convVideoLib_Resource_Rel.FileOriginalName);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_Resource_RelEN.FileDirName, convVideoLib_Resource_Rel.FileDirName);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_Resource_RelEN.FileRename, convVideoLib_Resource_Rel.FileRename);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_Resource_RelEN.FileUpDate, convVideoLib_Resource_Rel.FileUpDate);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_Resource_RelEN.FileUpTime, convVideoLib_Resource_Rel.FileUpTime);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_Resource_RelEN.FileSize, convVideoLib_Resource_Rel.FileSize);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_Resource_RelEN.FileType, convVideoLib_Resource_Rel.FileType);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_Resource_RelEN.ResourceOwner, convVideoLib_Resource_Rel.ResourceOwner);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_Resource_RelEN.IdFile, convVideoLib_Resource_Rel.IdFile);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_Resource_RelEN.FileName, convVideoLib_Resource_Rel.FileName);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_Resource_RelEN.SaveDate, convVideoLib_Resource_Rel.SaveDate);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_Resource_RelEN.SaveTime, convVideoLib_Resource_Rel.SaveTime);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_Resource_RelEN.FileOriginName, convVideoLib_Resource_Rel.FileOriginName);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_Resource_RelEN.IdResourceType, convVideoLib_Resource_Rel.IdResourceType);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_Resource_RelEN.ResourceTypeID, convVideoLib_Resource_Rel.ResourceTypeID);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_Resource_RelEN.ResourceTypeName, convVideoLib_Resource_Rel.ResourceTypeName);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_Resource_RelEN.FileNewName, convVideoLib_Resource_Rel.FileNewName);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_Resource_RelEN.FileOldName, convVideoLib_Resource_Rel.FileOldName);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_Resource_RelEN.ftpFileType, convVideoLib_Resource_Rel.ftpFileType);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_Resource_RelEN.ftpFileSize, convVideoLib_Resource_Rel.ftpFileSize);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_Resource_RelEN.ftpResourceOwner, convVideoLib_Resource_Rel.ftpResourceOwner);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_Resource_RelEN.IdUsingMode, convVideoLib_Resource_Rel.IdUsingMode);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_Resource_RelEN.UpdDate, convVideoLib_Resource_Rel.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_Resource_RelEN.UpdUser, convVideoLib_Resource_Rel.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_Resource_RelEN.Memo, convVideoLib_Resource_Rel.Memo);
//检查外键字段长度
 objvVideoLib_Resource_RelEN._IsCheckProperty = true;
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
 objSQL = clsvVideoLib_Resource_RelDA.GetSpecSQLObj();
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
 objSQL = clsvVideoLib_Resource_RelDA.GetSpecSQLObj();
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
 objSQL = clsvVideoLib_Resource_RelDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvVideoLib_Resource_RelEN._CurrTabName);
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
 objSQL = clsvVideoLib_Resource_RelDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvVideoLib_Resource_RelEN._CurrTabName, strCondition);
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
 objSQL = clsvVideoLib_Resource_RelDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}