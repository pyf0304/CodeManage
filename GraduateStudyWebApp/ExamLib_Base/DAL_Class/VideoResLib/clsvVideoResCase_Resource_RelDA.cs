
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvVideoResCase_Resource_RelDA
 表名:vVideoResCase_Resource_Rel(01120424)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:50:59
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:视频资源库(VideoResLib)
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
 /// v视频资源案例资源关系(vVideoResCase_Resource_Rel)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvVideoResCase_Resource_RelDA : clsCommBase4DA
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
 return clsvVideoResCase_Resource_RelEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvVideoResCase_Resource_RelEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvVideoResCase_Resource_RelEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvVideoResCase_Resource_RelEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvVideoResCase_Resource_RelEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvVideoResCase_Resource_RelDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vVideoResCase_Resource_Rel where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vVideoResCase_Resource_Rel(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvVideoResCase_Resource_RelDA: GetDataTable_vVideoResCase_Resource_Rel)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vVideoResCase_Resource_Rel where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvVideoResCase_Resource_RelDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCase_Resource_RelDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvVideoResCase_Resource_RelDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vVideoResCase_Resource_Rel where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvVideoResCase_Resource_RelDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCase_Resource_RelDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvVideoResCase_Resource_RelDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCase_Resource_RelDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vVideoResCase_Resource_Rel where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vVideoResCase_Resource_Rel where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvVideoResCase_Resource_RelDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCase_Resource_RelDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vVideoResCase_Resource_Rel where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvVideoResCase_Resource_RelDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCase_Resource_RelDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vVideoResCase_Resource_Rel.* from vVideoResCase_Resource_Rel Left Join {1} on {2} where {3} and vVideoResCase_Resource_Rel.IdMicroteachCaseResourceRel not in (Select top {5} vVideoResCase_Resource_Rel.IdMicroteachCaseResourceRel from vVideoResCase_Resource_Rel Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vVideoResCase_Resource_Rel where {1} and IdMicroteachCaseResourceRel not in (Select top {2} IdMicroteachCaseResourceRel from vVideoResCase_Resource_Rel where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vVideoResCase_Resource_Rel where {1} and IdMicroteachCaseResourceRel not in (Select top {3} IdMicroteachCaseResourceRel from vVideoResCase_Resource_Rel where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvVideoResCase_Resource_RelDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCase_Resource_RelDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vVideoResCase_Resource_Rel.* from vVideoResCase_Resource_Rel Left Join {1} on {2} where {3} and vVideoResCase_Resource_Rel.IdMicroteachCaseResourceRel not in (Select top {5} vVideoResCase_Resource_Rel.IdMicroteachCaseResourceRel from vVideoResCase_Resource_Rel Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vVideoResCase_Resource_Rel where {1} and IdMicroteachCaseResourceRel not in (Select top {2} IdMicroteachCaseResourceRel from vVideoResCase_Resource_Rel where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vVideoResCase_Resource_Rel where {1} and IdMicroteachCaseResourceRel not in (Select top {3} IdMicroteachCaseResourceRel from vVideoResCase_Resource_Rel where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvVideoResCase_Resource_RelEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvVideoResCase_Resource_RelDA:GetObjLst)", objException.Message));
}
List<clsvVideoResCase_Resource_RelEN> arrObjLst = new List<clsvVideoResCase_Resource_RelEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vVideoResCase_Resource_Rel where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN = new clsvVideoResCase_Resource_RelEN();
try
{
objvVideoResCase_Resource_RelEN.IdMicroteachCaseResourceRel = TransNullToInt(objRow[convVideoResCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvVideoResCase_Resource_RelEN.FuncModuleId = objRow[convVideoResCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoResCase_Resource_RelEN.FuncModuleName = objRow[convVideoResCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoResCase_Resource_RelEN.IdMicroteachCase = objRow[convVideoResCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoResCase_Resource_RelEN.VideoResCaseID = objRow[convVideoResCase_Resource_Rel.VideoResCaseID] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.VideoResCaseID].ToString().Trim(); //视频资源案例ID
objvVideoResCase_Resource_RelEN.VideoResCaseName = objRow[convVideoResCase_Resource_Rel.VideoResCaseName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.VideoResCaseName].ToString().Trim(); //视频资源案例名称
objvVideoResCase_Resource_RelEN.VideoResCaseTheme = objRow[convVideoResCase_Resource_Rel.VideoResCaseTheme] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.VideoResCaseTheme].ToString().Trim(); //视频资源案例主题词
objvVideoResCase_Resource_RelEN.IdVideoResCaseType = objRow[convVideoResCase_Resource_Rel.IdVideoResCaseType] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.IdVideoResCaseType].ToString().Trim(); //视频资源类型流水号
objvVideoResCase_Resource_RelEN.VideoResCaseTypeName = objRow[convVideoResCase_Resource_Rel.VideoResCaseTypeName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.VideoResCaseTypeName].ToString().Trim(); //视频资源案例类型名称
objvVideoResCase_Resource_RelEN.VideoResCaseText = objRow[convVideoResCase_Resource_Rel.VideoResCaseText] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.VideoResCaseText].ToString().Trim(); //案例文本内容
objvVideoResCase_Resource_RelEN.VideoResCaseDate = objRow[convVideoResCase_Resource_Rel.VideoResCaseDate] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.VideoResCaseDate].ToString().Trim(); //视频资源日期
objvVideoResCase_Resource_RelEN.VideoResCaseTime = objRow[convVideoResCase_Resource_Rel.VideoResCaseTime] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.VideoResCaseTime].ToString().Trim(); //视频资源时间
objvVideoResCase_Resource_RelEN.VideoResCaseDateIn = objRow[convVideoResCase_Resource_Rel.VideoResCaseDateIn] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.VideoResCaseDateIn].ToString().Trim(); //案例入库日期
objvVideoResCase_Resource_RelEN.VideoResCaseTimeIn = objRow[convVideoResCase_Resource_Rel.VideoResCaseTimeIn] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.VideoResCaseTimeIn].ToString().Trim(); //案例入库时间
objvVideoResCase_Resource_RelEN.OwnerId = objRow[convVideoResCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvVideoResCase_Resource_RelEN.IdStudyLevel = objRow[convVideoResCase_Resource_Rel.IdStudyLevel] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvVideoResCase_Resource_RelEN.StudyLevelName = objRow[convVideoResCase_Resource_Rel.StudyLevelName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvVideoResCase_Resource_RelEN.IdTeachingPlan = objRow[convVideoResCase_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvVideoResCase_Resource_RelEN.IdDiscipline = objRow[convVideoResCase_Resource_Rel.IdDiscipline] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvVideoResCase_Resource_RelEN.DisciplineID = objRow[convVideoResCase_Resource_Rel.DisciplineID] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID
objvVideoResCase_Resource_RelEN.DisciplineName = objRow[convVideoResCase_Resource_Rel.DisciplineName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvVideoResCase_Resource_RelEN.senateGaugeVersionID = objRow[convVideoResCase_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoResCase_Resource_RelEN.senateGaugeVersionName = objRow[convVideoResCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoResCase_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convVideoResCase_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convVideoResCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoResCase_Resource_RelEN.VersionNo = objRow[convVideoResCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvVideoResCase_Resource_RelEN.IdTeachSkill = objRow[convVideoResCase_Resource_Rel.IdTeachSkill] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvVideoResCase_Resource_RelEN.TeachSkillID = objRow[convVideoResCase_Resource_Rel.TeachSkillID] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID
objvVideoResCase_Resource_RelEN.SkillTypeName = objRow[convVideoResCase_Resource_Rel.SkillTypeName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称
objvVideoResCase_Resource_RelEN.TeachSkillName = objRow[convVideoResCase_Resource_Rel.TeachSkillName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称
objvVideoResCase_Resource_RelEN.TeachSkillTheory = objRow[convVideoResCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvVideoResCase_Resource_RelEN.TeachSkillOperMethod = objRow[convVideoResCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvVideoResCase_Resource_RelEN.IdSkillType = objRow[convVideoResCase_Resource_Rel.IdSkillType] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号
objvVideoResCase_Resource_RelEN.SkillTypeID = objRow[convVideoResCase_Resource_Rel.SkillTypeID] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID
objvVideoResCase_Resource_RelEN.CaseLevelId = objRow[convVideoResCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvVideoResCase_Resource_RelEN.IsDualVideo = TransNullToBool(objRow[convVideoResCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvVideoResCase_Resource_RelEN.IdXzCollege = objRow[convVideoResCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoResCase_Resource_RelEN.CollegeID = objRow[convVideoResCase_Resource_Rel.CollegeID] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.CollegeID].ToString().Trim(); //学院ID
objvVideoResCase_Resource_RelEN.CollegeName = objRow[convVideoResCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvVideoResCase_Resource_RelEN.CollegeNameA = objRow[convVideoResCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoResCase_Resource_RelEN.IdXzMajor = objRow[convVideoResCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号
objvVideoResCase_Resource_RelEN.MajorID = objRow[convVideoResCase_Resource_Rel.MajorID] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.MajorID].ToString().Trim(); //专业ID
objvVideoResCase_Resource_RelEN.MajorName = objRow[convVideoResCase_Resource_Rel.MajorName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.MajorName].ToString().Trim(); //专业名称
objvVideoResCase_Resource_RelEN.CourseId = objRow[convVideoResCase_Resource_Rel.CourseId] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.CourseId].ToString().Trim(); //课程Id
objvVideoResCase_Resource_RelEN.CourseCode = objRow[convVideoResCase_Resource_Rel.CourseCode] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.CourseCode].ToString().Trim(); //课程代码
objvVideoResCase_Resource_RelEN.CourseName = objRow[convVideoResCase_Resource_Rel.CourseName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.CourseName].ToString().Trim(); //课程名称
objvVideoResCase_Resource_RelEN.CourseChapterId = objRow[convVideoResCase_Resource_Rel.CourseChapterId] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.CourseChapterId].ToString().Trim(); //课程章节ID
objvVideoResCase_Resource_RelEN.CourseChapterName = objRow[convVideoResCase_Resource_Rel.CourseChapterName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.CourseChapterName].ToString().Trim(); //课程章节名称
objvVideoResCase_Resource_RelEN.ParentNodeID = objRow[convVideoResCase_Resource_Rel.ParentNodeID] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.ParentNodeID].ToString().Trim(); //父节点编号
objvVideoResCase_Resource_RelEN.ParentNodeName = objRow[convVideoResCase_Resource_Rel.ParentNodeName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.ParentNodeName].ToString().Trim(); //父节点名称
objvVideoResCase_Resource_RelEN.ViewCount = objRow[convVideoResCase_Resource_Rel.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase_Resource_Rel.ViewCount].ToString().Trim()); //浏览量
objvVideoResCase_Resource_RelEN.IsShow = TransNullToBool(objRow[convVideoResCase_Resource_Rel.IsShow].ToString().Trim()); //是否启用
objvVideoResCase_Resource_RelEN.DownloadNumber = objRow[convVideoResCase_Resource_Rel.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase_Resource_Rel.DownloadNumber].ToString().Trim()); //下载数目
objvVideoResCase_Resource_RelEN.FileIntegration = objRow[convVideoResCase_Resource_Rel.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase_Resource_Rel.FileIntegration].ToString().Trim()); //文件积分
objvVideoResCase_Resource_RelEN.LikeCount = objRow[convVideoResCase_Resource_Rel.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoResCase_Resource_Rel.LikeCount].ToString().Trim()); //资源喜欢数量
objvVideoResCase_Resource_RelEN.CollectionCount = objRow[convVideoResCase_Resource_Rel.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoResCase_Resource_Rel.CollectionCount].ToString().Trim()); //收藏数量
objvVideoResCase_Resource_RelEN.RecommendedDegreeId = objRow[convVideoResCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvVideoResCase_Resource_RelEN.RecommendedDegreeName = objRow[convVideoResCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvVideoResCase_Resource_RelEN.BrowseCount4Case = objRow[convVideoResCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvVideoResCase_Resource_RelEN.OwnerName = objRow[convVideoResCase_Resource_Rel.OwnerName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.OwnerName].ToString().Trim(); //拥有者姓名
objvVideoResCase_Resource_RelEN.OwnerNameWithId = objRow[convVideoResCase_Resource_Rel.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvVideoResCase_Resource_RelEN.IdResource = objRow[convVideoResCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvVideoResCase_Resource_RelEN.ResourceID = objRow[convVideoResCase_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvVideoResCase_Resource_RelEN.ResourceName = objRow[convVideoResCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvVideoResCase_Resource_RelEN.IdFtpResource = objRow[convVideoResCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvVideoResCase_Resource_RelEN.IdFile = objRow[convVideoResCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvVideoResCase_Resource_RelEN.FileName = objRow[convVideoResCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvVideoResCase_Resource_RelEN.FileType = objRow[convVideoResCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvVideoResCase_Resource_RelEN.SaveDate = objRow[convVideoResCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvVideoResCase_Resource_RelEN.FileSize = objRow[convVideoResCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvVideoResCase_Resource_RelEN.SaveTime = objRow[convVideoResCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvVideoResCase_Resource_RelEN.FtpResourceID = objRow[convVideoResCase_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvVideoResCase_Resource_RelEN.FileOriginalName = objRow[convVideoResCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvVideoResCase_Resource_RelEN.FileDirName = objRow[convVideoResCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvVideoResCase_Resource_RelEN.FileRename = objRow[convVideoResCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvVideoResCase_Resource_RelEN.FileUpDate = objRow[convVideoResCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvVideoResCase_Resource_RelEN.FileUpTime = objRow[convVideoResCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvVideoResCase_Resource_RelEN.SaveMode = TransNullToBool(objRow[convVideoResCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvVideoResCase_Resource_RelEN.IdResourceType = objRow[convVideoResCase_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvVideoResCase_Resource_RelEN.ResourceTypeID = objRow[convVideoResCase_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvVideoResCase_Resource_RelEN.ResourceTypeName = objRow[convVideoResCase_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvVideoResCase_Resource_RelEN.ResourceOwner = objRow[convVideoResCase_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvVideoResCase_Resource_RelEN.ftpFileType = objRow[convVideoResCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvVideoResCase_Resource_RelEN.ftpFileSize = objRow[convVideoResCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvVideoResCase_Resource_RelEN.ftpResourceOwner = objRow[convVideoResCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvVideoResCase_Resource_RelEN.FileOriginName = objRow[convVideoResCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvVideoResCase_Resource_RelEN.IsExistFile = TransNullToBool(objRow[convVideoResCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvVideoResCase_Resource_RelEN.FileNewName = objRow[convVideoResCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvVideoResCase_Resource_RelEN.FileOldName = objRow[convVideoResCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvVideoResCase_Resource_RelEN.IsMain = TransNullToBool(objRow[convVideoResCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvVideoResCase_Resource_RelEN.IdUsingMode = objRow[convVideoResCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvVideoResCase_Resource_RelEN.IsVisible = TransNullToBool(objRow[convVideoResCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvVideoResCase_Resource_RelEN.IndexNO = objRow[convVideoResCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvVideoResCase_Resource_RelEN.BrowseCount = objRow[convVideoResCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvVideoResCase_Resource_RelEN.UpdDate = objRow[convVideoResCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvVideoResCase_Resource_RelEN.UpdUser = objRow[convVideoResCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvVideoResCase_Resource_RelEN.Memo = objRow[convVideoResCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvVideoResCase_Resource_RelDA: GetObjLst)", objException.Message));
}
objvVideoResCase_Resource_RelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvVideoResCase_Resource_RelEN);
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
public List<clsvVideoResCase_Resource_RelEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvVideoResCase_Resource_RelDA:GetObjLstByTabName)", objException.Message));
}
List<clsvVideoResCase_Resource_RelEN> arrObjLst = new List<clsvVideoResCase_Resource_RelEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCase_Resource_RelDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN = new clsvVideoResCase_Resource_RelEN();
try
{
objvVideoResCase_Resource_RelEN.IdMicroteachCaseResourceRel = TransNullToInt(objRow[convVideoResCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvVideoResCase_Resource_RelEN.FuncModuleId = objRow[convVideoResCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoResCase_Resource_RelEN.FuncModuleName = objRow[convVideoResCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoResCase_Resource_RelEN.IdMicroteachCase = objRow[convVideoResCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoResCase_Resource_RelEN.VideoResCaseID = objRow[convVideoResCase_Resource_Rel.VideoResCaseID] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.VideoResCaseID].ToString().Trim(); //视频资源案例ID
objvVideoResCase_Resource_RelEN.VideoResCaseName = objRow[convVideoResCase_Resource_Rel.VideoResCaseName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.VideoResCaseName].ToString().Trim(); //视频资源案例名称
objvVideoResCase_Resource_RelEN.VideoResCaseTheme = objRow[convVideoResCase_Resource_Rel.VideoResCaseTheme] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.VideoResCaseTheme].ToString().Trim(); //视频资源案例主题词
objvVideoResCase_Resource_RelEN.IdVideoResCaseType = objRow[convVideoResCase_Resource_Rel.IdVideoResCaseType] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.IdVideoResCaseType].ToString().Trim(); //视频资源类型流水号
objvVideoResCase_Resource_RelEN.VideoResCaseTypeName = objRow[convVideoResCase_Resource_Rel.VideoResCaseTypeName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.VideoResCaseTypeName].ToString().Trim(); //视频资源案例类型名称
objvVideoResCase_Resource_RelEN.VideoResCaseText = objRow[convVideoResCase_Resource_Rel.VideoResCaseText] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.VideoResCaseText].ToString().Trim(); //案例文本内容
objvVideoResCase_Resource_RelEN.VideoResCaseDate = objRow[convVideoResCase_Resource_Rel.VideoResCaseDate] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.VideoResCaseDate].ToString().Trim(); //视频资源日期
objvVideoResCase_Resource_RelEN.VideoResCaseTime = objRow[convVideoResCase_Resource_Rel.VideoResCaseTime] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.VideoResCaseTime].ToString().Trim(); //视频资源时间
objvVideoResCase_Resource_RelEN.VideoResCaseDateIn = objRow[convVideoResCase_Resource_Rel.VideoResCaseDateIn] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.VideoResCaseDateIn].ToString().Trim(); //案例入库日期
objvVideoResCase_Resource_RelEN.VideoResCaseTimeIn = objRow[convVideoResCase_Resource_Rel.VideoResCaseTimeIn] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.VideoResCaseTimeIn].ToString().Trim(); //案例入库时间
objvVideoResCase_Resource_RelEN.OwnerId = objRow[convVideoResCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvVideoResCase_Resource_RelEN.IdStudyLevel = objRow[convVideoResCase_Resource_Rel.IdStudyLevel] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvVideoResCase_Resource_RelEN.StudyLevelName = objRow[convVideoResCase_Resource_Rel.StudyLevelName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvVideoResCase_Resource_RelEN.IdTeachingPlan = objRow[convVideoResCase_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvVideoResCase_Resource_RelEN.IdDiscipline = objRow[convVideoResCase_Resource_Rel.IdDiscipline] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvVideoResCase_Resource_RelEN.DisciplineID = objRow[convVideoResCase_Resource_Rel.DisciplineID] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID
objvVideoResCase_Resource_RelEN.DisciplineName = objRow[convVideoResCase_Resource_Rel.DisciplineName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvVideoResCase_Resource_RelEN.senateGaugeVersionID = objRow[convVideoResCase_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoResCase_Resource_RelEN.senateGaugeVersionName = objRow[convVideoResCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoResCase_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convVideoResCase_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convVideoResCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoResCase_Resource_RelEN.VersionNo = objRow[convVideoResCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvVideoResCase_Resource_RelEN.IdTeachSkill = objRow[convVideoResCase_Resource_Rel.IdTeachSkill] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvVideoResCase_Resource_RelEN.TeachSkillID = objRow[convVideoResCase_Resource_Rel.TeachSkillID] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID
objvVideoResCase_Resource_RelEN.SkillTypeName = objRow[convVideoResCase_Resource_Rel.SkillTypeName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称
objvVideoResCase_Resource_RelEN.TeachSkillName = objRow[convVideoResCase_Resource_Rel.TeachSkillName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称
objvVideoResCase_Resource_RelEN.TeachSkillTheory = objRow[convVideoResCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvVideoResCase_Resource_RelEN.TeachSkillOperMethod = objRow[convVideoResCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvVideoResCase_Resource_RelEN.IdSkillType = objRow[convVideoResCase_Resource_Rel.IdSkillType] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号
objvVideoResCase_Resource_RelEN.SkillTypeID = objRow[convVideoResCase_Resource_Rel.SkillTypeID] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID
objvVideoResCase_Resource_RelEN.CaseLevelId = objRow[convVideoResCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvVideoResCase_Resource_RelEN.IsDualVideo = TransNullToBool(objRow[convVideoResCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvVideoResCase_Resource_RelEN.IdXzCollege = objRow[convVideoResCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoResCase_Resource_RelEN.CollegeID = objRow[convVideoResCase_Resource_Rel.CollegeID] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.CollegeID].ToString().Trim(); //学院ID
objvVideoResCase_Resource_RelEN.CollegeName = objRow[convVideoResCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvVideoResCase_Resource_RelEN.CollegeNameA = objRow[convVideoResCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoResCase_Resource_RelEN.IdXzMajor = objRow[convVideoResCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号
objvVideoResCase_Resource_RelEN.MajorID = objRow[convVideoResCase_Resource_Rel.MajorID] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.MajorID].ToString().Trim(); //专业ID
objvVideoResCase_Resource_RelEN.MajorName = objRow[convVideoResCase_Resource_Rel.MajorName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.MajorName].ToString().Trim(); //专业名称
objvVideoResCase_Resource_RelEN.CourseId = objRow[convVideoResCase_Resource_Rel.CourseId] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.CourseId].ToString().Trim(); //课程Id
objvVideoResCase_Resource_RelEN.CourseCode = objRow[convVideoResCase_Resource_Rel.CourseCode] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.CourseCode].ToString().Trim(); //课程代码
objvVideoResCase_Resource_RelEN.CourseName = objRow[convVideoResCase_Resource_Rel.CourseName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.CourseName].ToString().Trim(); //课程名称
objvVideoResCase_Resource_RelEN.CourseChapterId = objRow[convVideoResCase_Resource_Rel.CourseChapterId] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.CourseChapterId].ToString().Trim(); //课程章节ID
objvVideoResCase_Resource_RelEN.CourseChapterName = objRow[convVideoResCase_Resource_Rel.CourseChapterName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.CourseChapterName].ToString().Trim(); //课程章节名称
objvVideoResCase_Resource_RelEN.ParentNodeID = objRow[convVideoResCase_Resource_Rel.ParentNodeID] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.ParentNodeID].ToString().Trim(); //父节点编号
objvVideoResCase_Resource_RelEN.ParentNodeName = objRow[convVideoResCase_Resource_Rel.ParentNodeName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.ParentNodeName].ToString().Trim(); //父节点名称
objvVideoResCase_Resource_RelEN.ViewCount = objRow[convVideoResCase_Resource_Rel.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase_Resource_Rel.ViewCount].ToString().Trim()); //浏览量
objvVideoResCase_Resource_RelEN.IsShow = TransNullToBool(objRow[convVideoResCase_Resource_Rel.IsShow].ToString().Trim()); //是否启用
objvVideoResCase_Resource_RelEN.DownloadNumber = objRow[convVideoResCase_Resource_Rel.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase_Resource_Rel.DownloadNumber].ToString().Trim()); //下载数目
objvVideoResCase_Resource_RelEN.FileIntegration = objRow[convVideoResCase_Resource_Rel.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase_Resource_Rel.FileIntegration].ToString().Trim()); //文件积分
objvVideoResCase_Resource_RelEN.LikeCount = objRow[convVideoResCase_Resource_Rel.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoResCase_Resource_Rel.LikeCount].ToString().Trim()); //资源喜欢数量
objvVideoResCase_Resource_RelEN.CollectionCount = objRow[convVideoResCase_Resource_Rel.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoResCase_Resource_Rel.CollectionCount].ToString().Trim()); //收藏数量
objvVideoResCase_Resource_RelEN.RecommendedDegreeId = objRow[convVideoResCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvVideoResCase_Resource_RelEN.RecommendedDegreeName = objRow[convVideoResCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvVideoResCase_Resource_RelEN.BrowseCount4Case = objRow[convVideoResCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvVideoResCase_Resource_RelEN.OwnerName = objRow[convVideoResCase_Resource_Rel.OwnerName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.OwnerName].ToString().Trim(); //拥有者姓名
objvVideoResCase_Resource_RelEN.OwnerNameWithId = objRow[convVideoResCase_Resource_Rel.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvVideoResCase_Resource_RelEN.IdResource = objRow[convVideoResCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvVideoResCase_Resource_RelEN.ResourceID = objRow[convVideoResCase_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvVideoResCase_Resource_RelEN.ResourceName = objRow[convVideoResCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvVideoResCase_Resource_RelEN.IdFtpResource = objRow[convVideoResCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvVideoResCase_Resource_RelEN.IdFile = objRow[convVideoResCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvVideoResCase_Resource_RelEN.FileName = objRow[convVideoResCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvVideoResCase_Resource_RelEN.FileType = objRow[convVideoResCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvVideoResCase_Resource_RelEN.SaveDate = objRow[convVideoResCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvVideoResCase_Resource_RelEN.FileSize = objRow[convVideoResCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvVideoResCase_Resource_RelEN.SaveTime = objRow[convVideoResCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvVideoResCase_Resource_RelEN.FtpResourceID = objRow[convVideoResCase_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvVideoResCase_Resource_RelEN.FileOriginalName = objRow[convVideoResCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvVideoResCase_Resource_RelEN.FileDirName = objRow[convVideoResCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvVideoResCase_Resource_RelEN.FileRename = objRow[convVideoResCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvVideoResCase_Resource_RelEN.FileUpDate = objRow[convVideoResCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvVideoResCase_Resource_RelEN.FileUpTime = objRow[convVideoResCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvVideoResCase_Resource_RelEN.SaveMode = TransNullToBool(objRow[convVideoResCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvVideoResCase_Resource_RelEN.IdResourceType = objRow[convVideoResCase_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvVideoResCase_Resource_RelEN.ResourceTypeID = objRow[convVideoResCase_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvVideoResCase_Resource_RelEN.ResourceTypeName = objRow[convVideoResCase_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvVideoResCase_Resource_RelEN.ResourceOwner = objRow[convVideoResCase_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvVideoResCase_Resource_RelEN.ftpFileType = objRow[convVideoResCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvVideoResCase_Resource_RelEN.ftpFileSize = objRow[convVideoResCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvVideoResCase_Resource_RelEN.ftpResourceOwner = objRow[convVideoResCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvVideoResCase_Resource_RelEN.FileOriginName = objRow[convVideoResCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvVideoResCase_Resource_RelEN.IsExistFile = TransNullToBool(objRow[convVideoResCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvVideoResCase_Resource_RelEN.FileNewName = objRow[convVideoResCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvVideoResCase_Resource_RelEN.FileOldName = objRow[convVideoResCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvVideoResCase_Resource_RelEN.IsMain = TransNullToBool(objRow[convVideoResCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvVideoResCase_Resource_RelEN.IdUsingMode = objRow[convVideoResCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvVideoResCase_Resource_RelEN.IsVisible = TransNullToBool(objRow[convVideoResCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvVideoResCase_Resource_RelEN.IndexNO = objRow[convVideoResCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvVideoResCase_Resource_RelEN.BrowseCount = objRow[convVideoResCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvVideoResCase_Resource_RelEN.UpdDate = objRow[convVideoResCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvVideoResCase_Resource_RelEN.UpdUser = objRow[convVideoResCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvVideoResCase_Resource_RelEN.Memo = objRow[convVideoResCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvVideoResCase_Resource_RelDA: GetObjLst)", objException.Message));
}
objvVideoResCase_Resource_RelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvVideoResCase_Resource_RelEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvVideoResCase_Resource_Rel(ref clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vVideoResCase_Resource_Rel where IdMicroteachCaseResourceRel = " + ""+ objvVideoResCase_Resource_RelEN.IdMicroteachCaseResourceRel+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvVideoResCase_Resource_RelEN.IdMicroteachCaseResourceRel = TransNullToInt(objDT.Rows[0][convVideoResCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvVideoResCase_Resource_RelEN.FuncModuleId = objDT.Rows[0][convVideoResCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvVideoResCase_Resource_RelEN.FuncModuleName = objDT.Rows[0][convVideoResCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvVideoResCase_Resource_RelEN.IdMicroteachCase = objDT.Rows[0][convVideoResCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoResCase_Resource_RelEN.VideoResCaseID = objDT.Rows[0][convVideoResCase_Resource_Rel.VideoResCaseID].ToString().Trim(); //视频资源案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvVideoResCase_Resource_RelEN.VideoResCaseName = objDT.Rows[0][convVideoResCase_Resource_Rel.VideoResCaseName].ToString().Trim(); //视频资源案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvVideoResCase_Resource_RelEN.VideoResCaseTheme = objDT.Rows[0][convVideoResCase_Resource_Rel.VideoResCaseTheme].ToString().Trim(); //视频资源案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoResCase_Resource_RelEN.IdVideoResCaseType = objDT.Rows[0][convVideoResCase_Resource_Rel.IdVideoResCaseType].ToString().Trim(); //视频资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCase_Resource_RelEN.VideoResCaseTypeName = objDT.Rows[0][convVideoResCase_Resource_Rel.VideoResCaseTypeName].ToString().Trim(); //视频资源案例类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvVideoResCase_Resource_RelEN.VideoResCaseText = objDT.Rows[0][convVideoResCase_Resource_Rel.VideoResCaseText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objvVideoResCase_Resource_RelEN.VideoResCaseDate = objDT.Rows[0][convVideoResCase_Resource_Rel.VideoResCaseDate].ToString().Trim(); //视频资源日期(字段类型:char,字段长度:8,是否可空:True)
 objvVideoResCase_Resource_RelEN.VideoResCaseTime = objDT.Rows[0][convVideoResCase_Resource_Rel.VideoResCaseTime].ToString().Trim(); //视频资源时间(字段类型:char,字段长度:6,是否可空:True)
 objvVideoResCase_Resource_RelEN.VideoResCaseDateIn = objDT.Rows[0][convVideoResCase_Resource_Rel.VideoResCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvVideoResCase_Resource_RelEN.VideoResCaseTimeIn = objDT.Rows[0][convVideoResCase_Resource_Rel.VideoResCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvVideoResCase_Resource_RelEN.OwnerId = objDT.Rows[0][convVideoResCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvVideoResCase_Resource_RelEN.IdStudyLevel = objDT.Rows[0][convVideoResCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvVideoResCase_Resource_RelEN.StudyLevelName = objDT.Rows[0][convVideoResCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvVideoResCase_Resource_RelEN.IdTeachingPlan = objDT.Rows[0][convVideoResCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoResCase_Resource_RelEN.IdDiscipline = objDT.Rows[0][convVideoResCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCase_Resource_RelEN.DisciplineID = objDT.Rows[0][convVideoResCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCase_Resource_RelEN.DisciplineName = objDT.Rows[0][convVideoResCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvVideoResCase_Resource_RelEN.senateGaugeVersionID = objDT.Rows[0][convVideoResCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCase_Resource_RelEN.senateGaugeVersionName = objDT.Rows[0][convVideoResCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoResCase_Resource_RelEN.senateGaugeVersionTtlScore = TransNullToFloat(objDT.Rows[0][convVideoResCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvVideoResCase_Resource_RelEN.VersionNo = TransNullToInt(objDT.Rows[0][convVideoResCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvVideoResCase_Resource_RelEN.IdTeachSkill = objDT.Rows[0][convVideoResCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoResCase_Resource_RelEN.TeachSkillID = objDT.Rows[0][convVideoResCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID(字段类型:char,字段长度:8,是否可空:False)
 objvVideoResCase_Resource_RelEN.SkillTypeName = objDT.Rows[0][convVideoResCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvVideoResCase_Resource_RelEN.TeachSkillName = objDT.Rows[0][convVideoResCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvVideoResCase_Resource_RelEN.TeachSkillTheory = objDT.Rows[0][convVideoResCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvVideoResCase_Resource_RelEN.TeachSkillOperMethod = objDT.Rows[0][convVideoResCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法(字段类型:varchar,字段长度:2000,是否可空:True)
 objvVideoResCase_Resource_RelEN.IdSkillType = objDT.Rows[0][convVideoResCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCase_Resource_RelEN.SkillTypeID = objDT.Rows[0][convVideoResCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCase_Resource_RelEN.CaseLevelId = objDT.Rows[0][convVideoResCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvVideoResCase_Resource_RelEN.IsDualVideo = TransNullToBool(objDT.Rows[0][convVideoResCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvVideoResCase_Resource_RelEN.IdXzCollege = objDT.Rows[0][convVideoResCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvVideoResCase_Resource_RelEN.CollegeID = objDT.Rows[0][convVideoResCase_Resource_Rel.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvVideoResCase_Resource_RelEN.CollegeName = objDT.Rows[0][convVideoResCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvVideoResCase_Resource_RelEN.CollegeNameA = objDT.Rows[0][convVideoResCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvVideoResCase_Resource_RelEN.IdXzMajor = objDT.Rows[0][convVideoResCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoResCase_Resource_RelEN.MajorID = objDT.Rows[0][convVideoResCase_Resource_Rel.MajorID].ToString().Trim(); //专业ID(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCase_Resource_RelEN.MajorName = objDT.Rows[0][convVideoResCase_Resource_Rel.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvVideoResCase_Resource_RelEN.CourseId = objDT.Rows[0][convVideoResCase_Resource_Rel.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvVideoResCase_Resource_RelEN.CourseCode = objDT.Rows[0][convVideoResCase_Resource_Rel.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvVideoResCase_Resource_RelEN.CourseName = objDT.Rows[0][convVideoResCase_Resource_Rel.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvVideoResCase_Resource_RelEN.CourseChapterId = objDT.Rows[0][convVideoResCase_Resource_Rel.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objvVideoResCase_Resource_RelEN.CourseChapterName = objDT.Rows[0][convVideoResCase_Resource_Rel.CourseChapterName].ToString().Trim(); //课程章节名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvVideoResCase_Resource_RelEN.ParentNodeID = objDT.Rows[0][convVideoResCase_Resource_Rel.ParentNodeID].ToString().Trim(); //父节点编号(字段类型:varchar,字段长度:8,是否可空:True)
 objvVideoResCase_Resource_RelEN.ParentNodeName = objDT.Rows[0][convVideoResCase_Resource_Rel.ParentNodeName].ToString().Trim(); //父节点名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvVideoResCase_Resource_RelEN.ViewCount = TransNullToInt(objDT.Rows[0][convVideoResCase_Resource_Rel.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvVideoResCase_Resource_RelEN.IsShow = TransNullToBool(objDT.Rows[0][convVideoResCase_Resource_Rel.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objvVideoResCase_Resource_RelEN.DownloadNumber = TransNullToInt(objDT.Rows[0][convVideoResCase_Resource_Rel.DownloadNumber].ToString().Trim()); //下载数目(字段类型:int,字段长度:4,是否可空:True)
 objvVideoResCase_Resource_RelEN.FileIntegration = TransNullToInt(objDT.Rows[0][convVideoResCase_Resource_Rel.FileIntegration].ToString().Trim()); //文件积分(字段类型:int,字段长度:4,是否可空:True)
 objvVideoResCase_Resource_RelEN.LikeCount = TransNullToInt(objDT.Rows[0][convVideoResCase_Resource_Rel.LikeCount].ToString().Trim()); //资源喜欢数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvVideoResCase_Resource_RelEN.CollectionCount = TransNullToInt(objDT.Rows[0][convVideoResCase_Resource_Rel.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvVideoResCase_Resource_RelEN.RecommendedDegreeId = objDT.Rows[0][convVideoResCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvVideoResCase_Resource_RelEN.RecommendedDegreeName = objDT.Rows[0][convVideoResCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvVideoResCase_Resource_RelEN.BrowseCount4Case = TransNullToInt(objDT.Rows[0][convVideoResCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvVideoResCase_Resource_RelEN.OwnerName = objDT.Rows[0][convVideoResCase_Resource_Rel.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvVideoResCase_Resource_RelEN.OwnerNameWithId = objDT.Rows[0][convVideoResCase_Resource_Rel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
 objvVideoResCase_Resource_RelEN.IdResource = objDT.Rows[0][convVideoResCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoResCase_Resource_RelEN.ResourceID = objDT.Rows[0][convVideoResCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvVideoResCase_Resource_RelEN.ResourceName = objDT.Rows[0][convVideoResCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvVideoResCase_Resource_RelEN.IdFtpResource = objDT.Rows[0][convVideoResCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objvVideoResCase_Resource_RelEN.IdFile = objDT.Rows[0][convVideoResCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号(字段类型:char,字段长度:8,是否可空:True)
 objvVideoResCase_Resource_RelEN.FileName = objDT.Rows[0][convVideoResCase_Resource_Rel.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvVideoResCase_Resource_RelEN.FileType = objDT.Rows[0][convVideoResCase_Resource_Rel.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvVideoResCase_Resource_RelEN.SaveDate = objDT.Rows[0][convVideoResCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvVideoResCase_Resource_RelEN.FileSize = objDT.Rows[0][convVideoResCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvVideoResCase_Resource_RelEN.SaveTime = objDT.Rows[0][convVideoResCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvVideoResCase_Resource_RelEN.FtpResourceID = objDT.Rows[0][convVideoResCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvVideoResCase_Resource_RelEN.FileOriginalName = objDT.Rows[0][convVideoResCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoResCase_Resource_RelEN.FileDirName = objDT.Rows[0][convVideoResCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoResCase_Resource_RelEN.FileRename = objDT.Rows[0][convVideoResCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoResCase_Resource_RelEN.FileUpDate = objDT.Rows[0][convVideoResCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvVideoResCase_Resource_RelEN.FileUpTime = objDT.Rows[0][convVideoResCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvVideoResCase_Resource_RelEN.SaveMode = TransNullToBool(objDT.Rows[0][convVideoResCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式(字段类型:bit,字段长度:1,是否可空:True)
 objvVideoResCase_Resource_RelEN.IdResourceType = objDT.Rows[0][convVideoResCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCase_Resource_RelEN.ResourceTypeID = objDT.Rows[0][convVideoResCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCase_Resource_RelEN.ResourceTypeName = objDT.Rows[0][convVideoResCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvVideoResCase_Resource_RelEN.ResourceOwner = objDT.Rows[0][convVideoResCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者(字段类型:varchar,字段长度:50,是否可空:False)
 objvVideoResCase_Resource_RelEN.ftpFileType = objDT.Rows[0][convVideoResCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvVideoResCase_Resource_RelEN.ftpFileSize = objDT.Rows[0][convVideoResCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvVideoResCase_Resource_RelEN.ftpResourceOwner = objDT.Rows[0][convVideoResCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者(字段类型:varchar,字段长度:50,是否可空:True)
 objvVideoResCase_Resource_RelEN.FileOriginName = objDT.Rows[0][convVideoResCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名(字段类型:varchar,字段长度:500,是否可空:True)
 objvVideoResCase_Resource_RelEN.IsExistFile = TransNullToBool(objDT.Rows[0][convVideoResCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objvVideoResCase_Resource_RelEN.FileNewName = objDT.Rows[0][convVideoResCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvVideoResCase_Resource_RelEN.FileOldName = objDT.Rows[0][convVideoResCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvVideoResCase_Resource_RelEN.IsMain = TransNullToBool(objDT.Rows[0][convVideoResCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源(字段类型:bit,字段长度:1,是否可空:True)
 objvVideoResCase_Resource_RelEN.IdUsingMode = objDT.Rows[0][convVideoResCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCase_Resource_RelEN.IsVisible = TransNullToBool(objDT.Rows[0][convVideoResCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvVideoResCase_Resource_RelEN.IndexNO = TransNullToInt(objDT.Rows[0][convVideoResCase_Resource_Rel.IndexNO].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvVideoResCase_Resource_RelEN.BrowseCount = TransNullToInt(objDT.Rows[0][convVideoResCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvVideoResCase_Resource_RelEN.UpdDate = objDT.Rows[0][convVideoResCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvVideoResCase_Resource_RelEN.UpdUser = objDT.Rows[0][convVideoResCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvVideoResCase_Resource_RelEN.Memo = objDT.Rows[0][convVideoResCase_Resource_Rel.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvVideoResCase_Resource_RelDA: GetvVideoResCase_Resource_Rel)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdMicroteachCaseResourceRel">表关键字</param>
 /// <returns>表对象</returns>
public clsvVideoResCase_Resource_RelEN GetObjByIdMicroteachCaseResourceRel(long lngIdMicroteachCaseResourceRel)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vVideoResCase_Resource_Rel where IdMicroteachCaseResourceRel = " + ""+ lngIdMicroteachCaseResourceRel+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN = new clsvVideoResCase_Resource_RelEN();
try
{
 objvVideoResCase_Resource_RelEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convVideoResCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvVideoResCase_Resource_RelEN.FuncModuleId = objRow[convVideoResCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvVideoResCase_Resource_RelEN.FuncModuleName = objRow[convVideoResCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvVideoResCase_Resource_RelEN.IdMicroteachCase = objRow[convVideoResCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoResCase_Resource_RelEN.VideoResCaseID = objRow[convVideoResCase_Resource_Rel.VideoResCaseID] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.VideoResCaseID].ToString().Trim(); //视频资源案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvVideoResCase_Resource_RelEN.VideoResCaseName = objRow[convVideoResCase_Resource_Rel.VideoResCaseName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.VideoResCaseName].ToString().Trim(); //视频资源案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvVideoResCase_Resource_RelEN.VideoResCaseTheme = objRow[convVideoResCase_Resource_Rel.VideoResCaseTheme] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.VideoResCaseTheme].ToString().Trim(); //视频资源案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoResCase_Resource_RelEN.IdVideoResCaseType = objRow[convVideoResCase_Resource_Rel.IdVideoResCaseType] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.IdVideoResCaseType].ToString().Trim(); //视频资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCase_Resource_RelEN.VideoResCaseTypeName = objRow[convVideoResCase_Resource_Rel.VideoResCaseTypeName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.VideoResCaseTypeName].ToString().Trim(); //视频资源案例类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvVideoResCase_Resource_RelEN.VideoResCaseText = objRow[convVideoResCase_Resource_Rel.VideoResCaseText] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.VideoResCaseText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objvVideoResCase_Resource_RelEN.VideoResCaseDate = objRow[convVideoResCase_Resource_Rel.VideoResCaseDate] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.VideoResCaseDate].ToString().Trim(); //视频资源日期(字段类型:char,字段长度:8,是否可空:True)
 objvVideoResCase_Resource_RelEN.VideoResCaseTime = objRow[convVideoResCase_Resource_Rel.VideoResCaseTime] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.VideoResCaseTime].ToString().Trim(); //视频资源时间(字段类型:char,字段长度:6,是否可空:True)
 objvVideoResCase_Resource_RelEN.VideoResCaseDateIn = objRow[convVideoResCase_Resource_Rel.VideoResCaseDateIn] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.VideoResCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvVideoResCase_Resource_RelEN.VideoResCaseTimeIn = objRow[convVideoResCase_Resource_Rel.VideoResCaseTimeIn] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.VideoResCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvVideoResCase_Resource_RelEN.OwnerId = objRow[convVideoResCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvVideoResCase_Resource_RelEN.IdStudyLevel = objRow[convVideoResCase_Resource_Rel.IdStudyLevel] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvVideoResCase_Resource_RelEN.StudyLevelName = objRow[convVideoResCase_Resource_Rel.StudyLevelName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvVideoResCase_Resource_RelEN.IdTeachingPlan = objRow[convVideoResCase_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoResCase_Resource_RelEN.IdDiscipline = objRow[convVideoResCase_Resource_Rel.IdDiscipline] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCase_Resource_RelEN.DisciplineID = objRow[convVideoResCase_Resource_Rel.DisciplineID] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCase_Resource_RelEN.DisciplineName = objRow[convVideoResCase_Resource_Rel.DisciplineName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvVideoResCase_Resource_RelEN.senateGaugeVersionID = objRow[convVideoResCase_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCase_Resource_RelEN.senateGaugeVersionName = objRow[convVideoResCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoResCase_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convVideoResCase_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convVideoResCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvVideoResCase_Resource_RelEN.VersionNo = objRow[convVideoResCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoResCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvVideoResCase_Resource_RelEN.IdTeachSkill = objRow[convVideoResCase_Resource_Rel.IdTeachSkill] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoResCase_Resource_RelEN.TeachSkillID = objRow[convVideoResCase_Resource_Rel.TeachSkillID] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID(字段类型:char,字段长度:8,是否可空:False)
 objvVideoResCase_Resource_RelEN.SkillTypeName = objRow[convVideoResCase_Resource_Rel.SkillTypeName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvVideoResCase_Resource_RelEN.TeachSkillName = objRow[convVideoResCase_Resource_Rel.TeachSkillName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvVideoResCase_Resource_RelEN.TeachSkillTheory = objRow[convVideoResCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvVideoResCase_Resource_RelEN.TeachSkillOperMethod = objRow[convVideoResCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法(字段类型:varchar,字段长度:2000,是否可空:True)
 objvVideoResCase_Resource_RelEN.IdSkillType = objRow[convVideoResCase_Resource_Rel.IdSkillType] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCase_Resource_RelEN.SkillTypeID = objRow[convVideoResCase_Resource_Rel.SkillTypeID] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCase_Resource_RelEN.CaseLevelId = objRow[convVideoResCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvVideoResCase_Resource_RelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convVideoResCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvVideoResCase_Resource_RelEN.IdXzCollege = objRow[convVideoResCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvVideoResCase_Resource_RelEN.CollegeID = objRow[convVideoResCase_Resource_Rel.CollegeID] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvVideoResCase_Resource_RelEN.CollegeName = objRow[convVideoResCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvVideoResCase_Resource_RelEN.CollegeNameA = objRow[convVideoResCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvVideoResCase_Resource_RelEN.IdXzMajor = objRow[convVideoResCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoResCase_Resource_RelEN.MajorID = objRow[convVideoResCase_Resource_Rel.MajorID] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.MajorID].ToString().Trim(); //专业ID(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCase_Resource_RelEN.MajorName = objRow[convVideoResCase_Resource_Rel.MajorName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvVideoResCase_Resource_RelEN.CourseId = objRow[convVideoResCase_Resource_Rel.CourseId] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvVideoResCase_Resource_RelEN.CourseCode = objRow[convVideoResCase_Resource_Rel.CourseCode] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvVideoResCase_Resource_RelEN.CourseName = objRow[convVideoResCase_Resource_Rel.CourseName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvVideoResCase_Resource_RelEN.CourseChapterId = objRow[convVideoResCase_Resource_Rel.CourseChapterId] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objvVideoResCase_Resource_RelEN.CourseChapterName = objRow[convVideoResCase_Resource_Rel.CourseChapterName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.CourseChapterName].ToString().Trim(); //课程章节名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvVideoResCase_Resource_RelEN.ParentNodeID = objRow[convVideoResCase_Resource_Rel.ParentNodeID] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.ParentNodeID].ToString().Trim(); //父节点编号(字段类型:varchar,字段长度:8,是否可空:True)
 objvVideoResCase_Resource_RelEN.ParentNodeName = objRow[convVideoResCase_Resource_Rel.ParentNodeName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.ParentNodeName].ToString().Trim(); //父节点名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvVideoResCase_Resource_RelEN.ViewCount = objRow[convVideoResCase_Resource_Rel.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoResCase_Resource_Rel.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvVideoResCase_Resource_RelEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convVideoResCase_Resource_Rel.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objvVideoResCase_Resource_RelEN.DownloadNumber = objRow[convVideoResCase_Resource_Rel.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoResCase_Resource_Rel.DownloadNumber].ToString().Trim()); //下载数目(字段类型:int,字段长度:4,是否可空:True)
 objvVideoResCase_Resource_RelEN.FileIntegration = objRow[convVideoResCase_Resource_Rel.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoResCase_Resource_Rel.FileIntegration].ToString().Trim()); //文件积分(字段类型:int,字段长度:4,是否可空:True)
 objvVideoResCase_Resource_RelEN.LikeCount = objRow[convVideoResCase_Resource_Rel.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoResCase_Resource_Rel.LikeCount].ToString().Trim()); //资源喜欢数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvVideoResCase_Resource_RelEN.CollectionCount = objRow[convVideoResCase_Resource_Rel.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoResCase_Resource_Rel.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvVideoResCase_Resource_RelEN.RecommendedDegreeId = objRow[convVideoResCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvVideoResCase_Resource_RelEN.RecommendedDegreeName = objRow[convVideoResCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvVideoResCase_Resource_RelEN.BrowseCount4Case = objRow[convVideoResCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoResCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvVideoResCase_Resource_RelEN.OwnerName = objRow[convVideoResCase_Resource_Rel.OwnerName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvVideoResCase_Resource_RelEN.OwnerNameWithId = objRow[convVideoResCase_Resource_Rel.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
 objvVideoResCase_Resource_RelEN.IdResource = objRow[convVideoResCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoResCase_Resource_RelEN.ResourceID = objRow[convVideoResCase_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvVideoResCase_Resource_RelEN.ResourceName = objRow[convVideoResCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvVideoResCase_Resource_RelEN.IdFtpResource = objRow[convVideoResCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objvVideoResCase_Resource_RelEN.IdFile = objRow[convVideoResCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号(字段类型:char,字段长度:8,是否可空:True)
 objvVideoResCase_Resource_RelEN.FileName = objRow[convVideoResCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvVideoResCase_Resource_RelEN.FileType = objRow[convVideoResCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvVideoResCase_Resource_RelEN.SaveDate = objRow[convVideoResCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvVideoResCase_Resource_RelEN.FileSize = objRow[convVideoResCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvVideoResCase_Resource_RelEN.SaveTime = objRow[convVideoResCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvVideoResCase_Resource_RelEN.FtpResourceID = objRow[convVideoResCase_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvVideoResCase_Resource_RelEN.FileOriginalName = objRow[convVideoResCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoResCase_Resource_RelEN.FileDirName = objRow[convVideoResCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoResCase_Resource_RelEN.FileRename = objRow[convVideoResCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoResCase_Resource_RelEN.FileUpDate = objRow[convVideoResCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvVideoResCase_Resource_RelEN.FileUpTime = objRow[convVideoResCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvVideoResCase_Resource_RelEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convVideoResCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式(字段类型:bit,字段长度:1,是否可空:True)
 objvVideoResCase_Resource_RelEN.IdResourceType = objRow[convVideoResCase_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCase_Resource_RelEN.ResourceTypeID = objRow[convVideoResCase_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCase_Resource_RelEN.ResourceTypeName = objRow[convVideoResCase_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvVideoResCase_Resource_RelEN.ResourceOwner = objRow[convVideoResCase_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者(字段类型:varchar,字段长度:50,是否可空:False)
 objvVideoResCase_Resource_RelEN.ftpFileType = objRow[convVideoResCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvVideoResCase_Resource_RelEN.ftpFileSize = objRow[convVideoResCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvVideoResCase_Resource_RelEN.ftpResourceOwner = objRow[convVideoResCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者(字段类型:varchar,字段长度:50,是否可空:True)
 objvVideoResCase_Resource_RelEN.FileOriginName = objRow[convVideoResCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名(字段类型:varchar,字段长度:500,是否可空:True)
 objvVideoResCase_Resource_RelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convVideoResCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objvVideoResCase_Resource_RelEN.FileNewName = objRow[convVideoResCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvVideoResCase_Resource_RelEN.FileOldName = objRow[convVideoResCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvVideoResCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convVideoResCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源(字段类型:bit,字段长度:1,是否可空:True)
 objvVideoResCase_Resource_RelEN.IdUsingMode = objRow[convVideoResCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convVideoResCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvVideoResCase_Resource_RelEN.IndexNO = objRow[convVideoResCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoResCase_Resource_Rel.IndexNO].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvVideoResCase_Resource_RelEN.BrowseCount = objRow[convVideoResCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoResCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvVideoResCase_Resource_RelEN.UpdDate = objRow[convVideoResCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvVideoResCase_Resource_RelEN.UpdUser = objRow[convVideoResCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvVideoResCase_Resource_RelEN.Memo = objRow[convVideoResCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvVideoResCase_Resource_RelDA: GetObjByIdMicroteachCaseResourceRel)", objException.Message));
}
return objvVideoResCase_Resource_RelEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvVideoResCase_Resource_RelEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvVideoResCase_Resource_RelDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vVideoResCase_Resource_Rel where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN = new clsvVideoResCase_Resource_RelEN()
{
IdMicroteachCaseResourceRel = TransNullToInt(objRow[convVideoResCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()), //微格案例资源关系流水号
FuncModuleId = objRow[convVideoResCase_Resource_Rel.FuncModuleId].ToString().Trim(), //功能模块Id
FuncModuleName = objRow[convVideoResCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FuncModuleName].ToString().Trim(), //功能模块名称
IdMicroteachCase = objRow[convVideoResCase_Resource_Rel.IdMicroteachCase].ToString().Trim(), //微格教学案例流水号
VideoResCaseID = objRow[convVideoResCase_Resource_Rel.VideoResCaseID] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.VideoResCaseID].ToString().Trim(), //视频资源案例ID
VideoResCaseName = objRow[convVideoResCase_Resource_Rel.VideoResCaseName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.VideoResCaseName].ToString().Trim(), //视频资源案例名称
VideoResCaseTheme = objRow[convVideoResCase_Resource_Rel.VideoResCaseTheme] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.VideoResCaseTheme].ToString().Trim(), //视频资源案例主题词
IdVideoResCaseType = objRow[convVideoResCase_Resource_Rel.IdVideoResCaseType] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.IdVideoResCaseType].ToString().Trim(), //视频资源类型流水号
VideoResCaseTypeName = objRow[convVideoResCase_Resource_Rel.VideoResCaseTypeName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.VideoResCaseTypeName].ToString().Trim(), //视频资源案例类型名称
VideoResCaseText = objRow[convVideoResCase_Resource_Rel.VideoResCaseText] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.VideoResCaseText].ToString().Trim(), //案例文本内容
VideoResCaseDate = objRow[convVideoResCase_Resource_Rel.VideoResCaseDate] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.VideoResCaseDate].ToString().Trim(), //视频资源日期
VideoResCaseTime = objRow[convVideoResCase_Resource_Rel.VideoResCaseTime] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.VideoResCaseTime].ToString().Trim(), //视频资源时间
VideoResCaseDateIn = objRow[convVideoResCase_Resource_Rel.VideoResCaseDateIn] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.VideoResCaseDateIn].ToString().Trim(), //案例入库日期
VideoResCaseTimeIn = objRow[convVideoResCase_Resource_Rel.VideoResCaseTimeIn] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.VideoResCaseTimeIn].ToString().Trim(), //案例入库时间
OwnerId = objRow[convVideoResCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.OwnerId].ToString().Trim(), //拥有者Id
IdStudyLevel = objRow[convVideoResCase_Resource_Rel.IdStudyLevel] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.IdStudyLevel].ToString().Trim(), //id_StudyLevel
StudyLevelName = objRow[convVideoResCase_Resource_Rel.StudyLevelName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.StudyLevelName].ToString().Trim(), //学段名称
IdTeachingPlan = objRow[convVideoResCase_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.IdTeachingPlan].ToString().Trim(), //教案流水号
IdDiscipline = objRow[convVideoResCase_Resource_Rel.IdDiscipline] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.IdDiscipline].ToString().Trim(), //学科流水号
DisciplineID = objRow[convVideoResCase_Resource_Rel.DisciplineID] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.DisciplineID].ToString().Trim(), //学科ID
DisciplineName = objRow[convVideoResCase_Resource_Rel.DisciplineName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.DisciplineName].ToString().Trim(), //学科名称
senateGaugeVersionID = objRow[convVideoResCase_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(), //评价量表版本ID
senateGaugeVersionName = objRow[convVideoResCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(), //评价量表版本名称
senateGaugeVersionTtlScore = objRow[convVideoResCase_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convVideoResCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()), //评价量表版本总分
VersionNo = objRow[convVideoResCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase_Resource_Rel.VersionNo].ToString().Trim()), //版本号
IdTeachSkill = objRow[convVideoResCase_Resource_Rel.IdTeachSkill] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.IdTeachSkill].ToString().Trim(), //教学技能流水号
TeachSkillID = objRow[convVideoResCase_Resource_Rel.TeachSkillID] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.TeachSkillID].ToString().Trim(), //教学技能ID
SkillTypeName = objRow[convVideoResCase_Resource_Rel.SkillTypeName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.SkillTypeName].ToString().Trim(), //技能类型名称
TeachSkillName = objRow[convVideoResCase_Resource_Rel.TeachSkillName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.TeachSkillName].ToString().Trim(), //教学技能名称
TeachSkillTheory = objRow[convVideoResCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.TeachSkillTheory].ToString().Trim(), //教学技能理论阐述
TeachSkillOperMethod = objRow[convVideoResCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(), //教学技能实践操作方法
IdSkillType = objRow[convVideoResCase_Resource_Rel.IdSkillType] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.IdSkillType].ToString().Trim(), //技能类型流水号
SkillTypeID = objRow[convVideoResCase_Resource_Rel.SkillTypeID] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.SkillTypeID].ToString().Trim(), //技能类型ID
CaseLevelId = objRow[convVideoResCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.CaseLevelId].ToString().Trim(), //课例等级Id
IsDualVideo = TransNullToBool(objRow[convVideoResCase_Resource_Rel.IsDualVideo].ToString().Trim()), //是否双视频
IdXzCollege = objRow[convVideoResCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.IdXzCollege].ToString().Trim(), //学院流水号
CollegeID = objRow[convVideoResCase_Resource_Rel.CollegeID] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.CollegeID].ToString().Trim(), //学院ID
CollegeName = objRow[convVideoResCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.CollegeName].ToString().Trim(), //学院名称
CollegeNameA = objRow[convVideoResCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.CollegeNameA].ToString().Trim(), //学院名称简写
IdXzMajor = objRow[convVideoResCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.IdXzMajor].ToString().Trim(), //专业流水号
MajorID = objRow[convVideoResCase_Resource_Rel.MajorID] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.MajorID].ToString().Trim(), //专业ID
MajorName = objRow[convVideoResCase_Resource_Rel.MajorName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.MajorName].ToString().Trim(), //专业名称
CourseId = objRow[convVideoResCase_Resource_Rel.CourseId] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.CourseId].ToString().Trim(), //课程Id
CourseCode = objRow[convVideoResCase_Resource_Rel.CourseCode] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.CourseCode].ToString().Trim(), //课程代码
CourseName = objRow[convVideoResCase_Resource_Rel.CourseName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.CourseName].ToString().Trim(), //课程名称
CourseChapterId = objRow[convVideoResCase_Resource_Rel.CourseChapterId] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.CourseChapterId].ToString().Trim(), //课程章节ID
CourseChapterName = objRow[convVideoResCase_Resource_Rel.CourseChapterName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.CourseChapterName].ToString().Trim(), //课程章节名称
ParentNodeID = objRow[convVideoResCase_Resource_Rel.ParentNodeID] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.ParentNodeID].ToString().Trim(), //父节点编号
ParentNodeName = objRow[convVideoResCase_Resource_Rel.ParentNodeName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.ParentNodeName].ToString().Trim(), //父节点名称
ViewCount = objRow[convVideoResCase_Resource_Rel.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase_Resource_Rel.ViewCount].ToString().Trim()), //浏览量
IsShow = TransNullToBool(objRow[convVideoResCase_Resource_Rel.IsShow].ToString().Trim()), //是否启用
DownloadNumber = objRow[convVideoResCase_Resource_Rel.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase_Resource_Rel.DownloadNumber].ToString().Trim()), //下载数目
FileIntegration = objRow[convVideoResCase_Resource_Rel.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase_Resource_Rel.FileIntegration].ToString().Trim()), //文件积分
LikeCount = objRow[convVideoResCase_Resource_Rel.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoResCase_Resource_Rel.LikeCount].ToString().Trim()), //资源喜欢数量
CollectionCount = objRow[convVideoResCase_Resource_Rel.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoResCase_Resource_Rel.CollectionCount].ToString().Trim()), //收藏数量
RecommendedDegreeId = objRow[convVideoResCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(), //推荐度Id
RecommendedDegreeName = objRow[convVideoResCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(), //推荐度名称
BrowseCount4Case = objRow[convVideoResCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase_Resource_Rel.BrowseCount4Case].ToString().Trim()), //课例浏览次数
OwnerName = objRow[convVideoResCase_Resource_Rel.OwnerName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.OwnerName].ToString().Trim(), //拥有者姓名
OwnerNameWithId = objRow[convVideoResCase_Resource_Rel.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.OwnerNameWithId].ToString().Trim(), //拥有者名称附Id
IdResource = objRow[convVideoResCase_Resource_Rel.IdResource].ToString().Trim(), //资源流水号
ResourceID = objRow[convVideoResCase_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.ResourceID].ToString().Trim(), //资源ID
ResourceName = objRow[convVideoResCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.ResourceName].ToString().Trim(), //资源名称
IdFtpResource = objRow[convVideoResCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.IdFtpResource].ToString().Trim(), //FTP资源流水号
IdFile = objRow[convVideoResCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.IdFile].ToString().Trim(), //文件流水号
FileName = objRow[convVideoResCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FileName].ToString().Trim(), //文件名称
FileType = objRow[convVideoResCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FileType].ToString().Trim(), //文件类型
SaveDate = objRow[convVideoResCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.SaveDate].ToString().Trim(), //创建日期
FileSize = objRow[convVideoResCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FileSize].ToString().Trim(), //文件大小
SaveTime = objRow[convVideoResCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.SaveTime].ToString().Trim(), //创建时间
FtpResourceID = objRow[convVideoResCase_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FtpResourceID].ToString().Trim(), //FTP资源ID
FileOriginalName = objRow[convVideoResCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FileOriginalName].ToString().Trim(), //文件原名
FileDirName = objRow[convVideoResCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FileDirName].ToString().Trim(), //文件目录名
FileRename = objRow[convVideoResCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FileRename].ToString().Trim(), //文件新名
FileUpDate = objRow[convVideoResCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FileUpDate].ToString().Trim(), //创建日期
FileUpTime = objRow[convVideoResCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FileUpTime].ToString().Trim(), //创建时间
SaveMode = TransNullToBool(objRow[convVideoResCase_Resource_Rel.SaveMode].ToString().Trim()), //文件存放方式
IdResourceType = objRow[convVideoResCase_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.IdResourceType].ToString().Trim(), //资源类型流水号
ResourceTypeID = objRow[convVideoResCase_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.ResourceTypeID].ToString().Trim(), //资源类型ID
ResourceTypeName = objRow[convVideoResCase_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.ResourceTypeName].ToString().Trim(), //资源类型名称
ResourceOwner = objRow[convVideoResCase_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.ResourceOwner].ToString().Trim(), //上传者
ftpFileType = objRow[convVideoResCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.ftpFileType].ToString().Trim(), //ftp文件类型
ftpFileSize = objRow[convVideoResCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.ftpFileSize].ToString().Trim(), //ftp文件大小
ftpResourceOwner = objRow[convVideoResCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.ftpResourceOwner].ToString().Trim(), //Ftp资源拥有者
FileOriginName = objRow[convVideoResCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FileOriginName].ToString().Trim(), //原文件名
IsExistFile = TransNullToBool(objRow[convVideoResCase_Resource_Rel.IsExistFile].ToString().Trim()), //是否存在文件
FileNewName = objRow[convVideoResCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FileNewName].ToString().Trim(), //新文件名
FileOldName = objRow[convVideoResCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FileOldName].ToString().Trim(), //旧文件名
IsMain = TransNullToBool(objRow[convVideoResCase_Resource_Rel.IsMain].ToString().Trim()), //是否主资源
IdUsingMode = objRow[convVideoResCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.IdUsingMode].ToString().Trim(), //资源使用模式流水号
IsVisible = TransNullToBool(objRow[convVideoResCase_Resource_Rel.IsVisible].ToString().Trim()), //是否显示
IndexNO = objRow[convVideoResCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase_Resource_Rel.IndexNO].ToString().Trim()), //序号
BrowseCount = objRow[convVideoResCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase_Resource_Rel.BrowseCount].ToString().Trim()), //浏览次数
UpdDate = objRow[convVideoResCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convVideoResCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convVideoResCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.Memo].ToString().Trim() //备注
};
objvVideoResCase_Resource_RelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvVideoResCase_Resource_RelEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvVideoResCase_Resource_RelDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvVideoResCase_Resource_RelEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN = new clsvVideoResCase_Resource_RelEN();
try
{
objvVideoResCase_Resource_RelEN.IdMicroteachCaseResourceRel = TransNullToInt(objRow[convVideoResCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvVideoResCase_Resource_RelEN.FuncModuleId = objRow[convVideoResCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoResCase_Resource_RelEN.FuncModuleName = objRow[convVideoResCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoResCase_Resource_RelEN.IdMicroteachCase = objRow[convVideoResCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoResCase_Resource_RelEN.VideoResCaseID = objRow[convVideoResCase_Resource_Rel.VideoResCaseID] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.VideoResCaseID].ToString().Trim(); //视频资源案例ID
objvVideoResCase_Resource_RelEN.VideoResCaseName = objRow[convVideoResCase_Resource_Rel.VideoResCaseName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.VideoResCaseName].ToString().Trim(); //视频资源案例名称
objvVideoResCase_Resource_RelEN.VideoResCaseTheme = objRow[convVideoResCase_Resource_Rel.VideoResCaseTheme] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.VideoResCaseTheme].ToString().Trim(); //视频资源案例主题词
objvVideoResCase_Resource_RelEN.IdVideoResCaseType = objRow[convVideoResCase_Resource_Rel.IdVideoResCaseType] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.IdVideoResCaseType].ToString().Trim(); //视频资源类型流水号
objvVideoResCase_Resource_RelEN.VideoResCaseTypeName = objRow[convVideoResCase_Resource_Rel.VideoResCaseTypeName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.VideoResCaseTypeName].ToString().Trim(); //视频资源案例类型名称
objvVideoResCase_Resource_RelEN.VideoResCaseText = objRow[convVideoResCase_Resource_Rel.VideoResCaseText] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.VideoResCaseText].ToString().Trim(); //案例文本内容
objvVideoResCase_Resource_RelEN.VideoResCaseDate = objRow[convVideoResCase_Resource_Rel.VideoResCaseDate] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.VideoResCaseDate].ToString().Trim(); //视频资源日期
objvVideoResCase_Resource_RelEN.VideoResCaseTime = objRow[convVideoResCase_Resource_Rel.VideoResCaseTime] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.VideoResCaseTime].ToString().Trim(); //视频资源时间
objvVideoResCase_Resource_RelEN.VideoResCaseDateIn = objRow[convVideoResCase_Resource_Rel.VideoResCaseDateIn] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.VideoResCaseDateIn].ToString().Trim(); //案例入库日期
objvVideoResCase_Resource_RelEN.VideoResCaseTimeIn = objRow[convVideoResCase_Resource_Rel.VideoResCaseTimeIn] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.VideoResCaseTimeIn].ToString().Trim(); //案例入库时间
objvVideoResCase_Resource_RelEN.OwnerId = objRow[convVideoResCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvVideoResCase_Resource_RelEN.IdStudyLevel = objRow[convVideoResCase_Resource_Rel.IdStudyLevel] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvVideoResCase_Resource_RelEN.StudyLevelName = objRow[convVideoResCase_Resource_Rel.StudyLevelName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvVideoResCase_Resource_RelEN.IdTeachingPlan = objRow[convVideoResCase_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvVideoResCase_Resource_RelEN.IdDiscipline = objRow[convVideoResCase_Resource_Rel.IdDiscipline] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvVideoResCase_Resource_RelEN.DisciplineID = objRow[convVideoResCase_Resource_Rel.DisciplineID] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID
objvVideoResCase_Resource_RelEN.DisciplineName = objRow[convVideoResCase_Resource_Rel.DisciplineName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvVideoResCase_Resource_RelEN.senateGaugeVersionID = objRow[convVideoResCase_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoResCase_Resource_RelEN.senateGaugeVersionName = objRow[convVideoResCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoResCase_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convVideoResCase_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convVideoResCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoResCase_Resource_RelEN.VersionNo = objRow[convVideoResCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvVideoResCase_Resource_RelEN.IdTeachSkill = objRow[convVideoResCase_Resource_Rel.IdTeachSkill] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvVideoResCase_Resource_RelEN.TeachSkillID = objRow[convVideoResCase_Resource_Rel.TeachSkillID] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID
objvVideoResCase_Resource_RelEN.SkillTypeName = objRow[convVideoResCase_Resource_Rel.SkillTypeName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称
objvVideoResCase_Resource_RelEN.TeachSkillName = objRow[convVideoResCase_Resource_Rel.TeachSkillName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称
objvVideoResCase_Resource_RelEN.TeachSkillTheory = objRow[convVideoResCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvVideoResCase_Resource_RelEN.TeachSkillOperMethod = objRow[convVideoResCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvVideoResCase_Resource_RelEN.IdSkillType = objRow[convVideoResCase_Resource_Rel.IdSkillType] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号
objvVideoResCase_Resource_RelEN.SkillTypeID = objRow[convVideoResCase_Resource_Rel.SkillTypeID] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID
objvVideoResCase_Resource_RelEN.CaseLevelId = objRow[convVideoResCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvVideoResCase_Resource_RelEN.IsDualVideo = TransNullToBool(objRow[convVideoResCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvVideoResCase_Resource_RelEN.IdXzCollege = objRow[convVideoResCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoResCase_Resource_RelEN.CollegeID = objRow[convVideoResCase_Resource_Rel.CollegeID] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.CollegeID].ToString().Trim(); //学院ID
objvVideoResCase_Resource_RelEN.CollegeName = objRow[convVideoResCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvVideoResCase_Resource_RelEN.CollegeNameA = objRow[convVideoResCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoResCase_Resource_RelEN.IdXzMajor = objRow[convVideoResCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号
objvVideoResCase_Resource_RelEN.MajorID = objRow[convVideoResCase_Resource_Rel.MajorID] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.MajorID].ToString().Trim(); //专业ID
objvVideoResCase_Resource_RelEN.MajorName = objRow[convVideoResCase_Resource_Rel.MajorName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.MajorName].ToString().Trim(); //专业名称
objvVideoResCase_Resource_RelEN.CourseId = objRow[convVideoResCase_Resource_Rel.CourseId] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.CourseId].ToString().Trim(); //课程Id
objvVideoResCase_Resource_RelEN.CourseCode = objRow[convVideoResCase_Resource_Rel.CourseCode] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.CourseCode].ToString().Trim(); //课程代码
objvVideoResCase_Resource_RelEN.CourseName = objRow[convVideoResCase_Resource_Rel.CourseName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.CourseName].ToString().Trim(); //课程名称
objvVideoResCase_Resource_RelEN.CourseChapterId = objRow[convVideoResCase_Resource_Rel.CourseChapterId] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.CourseChapterId].ToString().Trim(); //课程章节ID
objvVideoResCase_Resource_RelEN.CourseChapterName = objRow[convVideoResCase_Resource_Rel.CourseChapterName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.CourseChapterName].ToString().Trim(); //课程章节名称
objvVideoResCase_Resource_RelEN.ParentNodeID = objRow[convVideoResCase_Resource_Rel.ParentNodeID] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.ParentNodeID].ToString().Trim(); //父节点编号
objvVideoResCase_Resource_RelEN.ParentNodeName = objRow[convVideoResCase_Resource_Rel.ParentNodeName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.ParentNodeName].ToString().Trim(); //父节点名称
objvVideoResCase_Resource_RelEN.ViewCount = objRow[convVideoResCase_Resource_Rel.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase_Resource_Rel.ViewCount].ToString().Trim()); //浏览量
objvVideoResCase_Resource_RelEN.IsShow = TransNullToBool(objRow[convVideoResCase_Resource_Rel.IsShow].ToString().Trim()); //是否启用
objvVideoResCase_Resource_RelEN.DownloadNumber = objRow[convVideoResCase_Resource_Rel.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase_Resource_Rel.DownloadNumber].ToString().Trim()); //下载数目
objvVideoResCase_Resource_RelEN.FileIntegration = objRow[convVideoResCase_Resource_Rel.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase_Resource_Rel.FileIntegration].ToString().Trim()); //文件积分
objvVideoResCase_Resource_RelEN.LikeCount = objRow[convVideoResCase_Resource_Rel.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoResCase_Resource_Rel.LikeCount].ToString().Trim()); //资源喜欢数量
objvVideoResCase_Resource_RelEN.CollectionCount = objRow[convVideoResCase_Resource_Rel.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoResCase_Resource_Rel.CollectionCount].ToString().Trim()); //收藏数量
objvVideoResCase_Resource_RelEN.RecommendedDegreeId = objRow[convVideoResCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvVideoResCase_Resource_RelEN.RecommendedDegreeName = objRow[convVideoResCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvVideoResCase_Resource_RelEN.BrowseCount4Case = objRow[convVideoResCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvVideoResCase_Resource_RelEN.OwnerName = objRow[convVideoResCase_Resource_Rel.OwnerName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.OwnerName].ToString().Trim(); //拥有者姓名
objvVideoResCase_Resource_RelEN.OwnerNameWithId = objRow[convVideoResCase_Resource_Rel.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvVideoResCase_Resource_RelEN.IdResource = objRow[convVideoResCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvVideoResCase_Resource_RelEN.ResourceID = objRow[convVideoResCase_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvVideoResCase_Resource_RelEN.ResourceName = objRow[convVideoResCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvVideoResCase_Resource_RelEN.IdFtpResource = objRow[convVideoResCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvVideoResCase_Resource_RelEN.IdFile = objRow[convVideoResCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvVideoResCase_Resource_RelEN.FileName = objRow[convVideoResCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvVideoResCase_Resource_RelEN.FileType = objRow[convVideoResCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvVideoResCase_Resource_RelEN.SaveDate = objRow[convVideoResCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvVideoResCase_Resource_RelEN.FileSize = objRow[convVideoResCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvVideoResCase_Resource_RelEN.SaveTime = objRow[convVideoResCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvVideoResCase_Resource_RelEN.FtpResourceID = objRow[convVideoResCase_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvVideoResCase_Resource_RelEN.FileOriginalName = objRow[convVideoResCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvVideoResCase_Resource_RelEN.FileDirName = objRow[convVideoResCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvVideoResCase_Resource_RelEN.FileRename = objRow[convVideoResCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvVideoResCase_Resource_RelEN.FileUpDate = objRow[convVideoResCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvVideoResCase_Resource_RelEN.FileUpTime = objRow[convVideoResCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvVideoResCase_Resource_RelEN.SaveMode = TransNullToBool(objRow[convVideoResCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvVideoResCase_Resource_RelEN.IdResourceType = objRow[convVideoResCase_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvVideoResCase_Resource_RelEN.ResourceTypeID = objRow[convVideoResCase_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvVideoResCase_Resource_RelEN.ResourceTypeName = objRow[convVideoResCase_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvVideoResCase_Resource_RelEN.ResourceOwner = objRow[convVideoResCase_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvVideoResCase_Resource_RelEN.ftpFileType = objRow[convVideoResCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvVideoResCase_Resource_RelEN.ftpFileSize = objRow[convVideoResCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvVideoResCase_Resource_RelEN.ftpResourceOwner = objRow[convVideoResCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvVideoResCase_Resource_RelEN.FileOriginName = objRow[convVideoResCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvVideoResCase_Resource_RelEN.IsExistFile = TransNullToBool(objRow[convVideoResCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvVideoResCase_Resource_RelEN.FileNewName = objRow[convVideoResCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvVideoResCase_Resource_RelEN.FileOldName = objRow[convVideoResCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvVideoResCase_Resource_RelEN.IsMain = TransNullToBool(objRow[convVideoResCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvVideoResCase_Resource_RelEN.IdUsingMode = objRow[convVideoResCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvVideoResCase_Resource_RelEN.IsVisible = TransNullToBool(objRow[convVideoResCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvVideoResCase_Resource_RelEN.IndexNO = objRow[convVideoResCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvVideoResCase_Resource_RelEN.BrowseCount = objRow[convVideoResCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvVideoResCase_Resource_RelEN.UpdDate = objRow[convVideoResCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvVideoResCase_Resource_RelEN.UpdUser = objRow[convVideoResCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvVideoResCase_Resource_RelEN.Memo = objRow[convVideoResCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvVideoResCase_Resource_RelDA: GetObjByDataRowvVideoResCase_Resource_Rel)", objException.Message));
}
objvVideoResCase_Resource_RelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvVideoResCase_Resource_RelEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvVideoResCase_Resource_RelEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN = new clsvVideoResCase_Resource_RelEN();
try
{
objvVideoResCase_Resource_RelEN.IdMicroteachCaseResourceRel = TransNullToInt(objRow[convVideoResCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvVideoResCase_Resource_RelEN.FuncModuleId = objRow[convVideoResCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoResCase_Resource_RelEN.FuncModuleName = objRow[convVideoResCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoResCase_Resource_RelEN.IdMicroteachCase = objRow[convVideoResCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoResCase_Resource_RelEN.VideoResCaseID = objRow[convVideoResCase_Resource_Rel.VideoResCaseID] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.VideoResCaseID].ToString().Trim(); //视频资源案例ID
objvVideoResCase_Resource_RelEN.VideoResCaseName = objRow[convVideoResCase_Resource_Rel.VideoResCaseName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.VideoResCaseName].ToString().Trim(); //视频资源案例名称
objvVideoResCase_Resource_RelEN.VideoResCaseTheme = objRow[convVideoResCase_Resource_Rel.VideoResCaseTheme] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.VideoResCaseTheme].ToString().Trim(); //视频资源案例主题词
objvVideoResCase_Resource_RelEN.IdVideoResCaseType = objRow[convVideoResCase_Resource_Rel.IdVideoResCaseType] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.IdVideoResCaseType].ToString().Trim(); //视频资源类型流水号
objvVideoResCase_Resource_RelEN.VideoResCaseTypeName = objRow[convVideoResCase_Resource_Rel.VideoResCaseTypeName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.VideoResCaseTypeName].ToString().Trim(); //视频资源案例类型名称
objvVideoResCase_Resource_RelEN.VideoResCaseText = objRow[convVideoResCase_Resource_Rel.VideoResCaseText] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.VideoResCaseText].ToString().Trim(); //案例文本内容
objvVideoResCase_Resource_RelEN.VideoResCaseDate = objRow[convVideoResCase_Resource_Rel.VideoResCaseDate] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.VideoResCaseDate].ToString().Trim(); //视频资源日期
objvVideoResCase_Resource_RelEN.VideoResCaseTime = objRow[convVideoResCase_Resource_Rel.VideoResCaseTime] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.VideoResCaseTime].ToString().Trim(); //视频资源时间
objvVideoResCase_Resource_RelEN.VideoResCaseDateIn = objRow[convVideoResCase_Resource_Rel.VideoResCaseDateIn] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.VideoResCaseDateIn].ToString().Trim(); //案例入库日期
objvVideoResCase_Resource_RelEN.VideoResCaseTimeIn = objRow[convVideoResCase_Resource_Rel.VideoResCaseTimeIn] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.VideoResCaseTimeIn].ToString().Trim(); //案例入库时间
objvVideoResCase_Resource_RelEN.OwnerId = objRow[convVideoResCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvVideoResCase_Resource_RelEN.IdStudyLevel = objRow[convVideoResCase_Resource_Rel.IdStudyLevel] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvVideoResCase_Resource_RelEN.StudyLevelName = objRow[convVideoResCase_Resource_Rel.StudyLevelName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvVideoResCase_Resource_RelEN.IdTeachingPlan = objRow[convVideoResCase_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvVideoResCase_Resource_RelEN.IdDiscipline = objRow[convVideoResCase_Resource_Rel.IdDiscipline] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvVideoResCase_Resource_RelEN.DisciplineID = objRow[convVideoResCase_Resource_Rel.DisciplineID] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID
objvVideoResCase_Resource_RelEN.DisciplineName = objRow[convVideoResCase_Resource_Rel.DisciplineName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvVideoResCase_Resource_RelEN.senateGaugeVersionID = objRow[convVideoResCase_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoResCase_Resource_RelEN.senateGaugeVersionName = objRow[convVideoResCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoResCase_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convVideoResCase_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convVideoResCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoResCase_Resource_RelEN.VersionNo = objRow[convVideoResCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvVideoResCase_Resource_RelEN.IdTeachSkill = objRow[convVideoResCase_Resource_Rel.IdTeachSkill] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvVideoResCase_Resource_RelEN.TeachSkillID = objRow[convVideoResCase_Resource_Rel.TeachSkillID] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID
objvVideoResCase_Resource_RelEN.SkillTypeName = objRow[convVideoResCase_Resource_Rel.SkillTypeName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称
objvVideoResCase_Resource_RelEN.TeachSkillName = objRow[convVideoResCase_Resource_Rel.TeachSkillName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称
objvVideoResCase_Resource_RelEN.TeachSkillTheory = objRow[convVideoResCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvVideoResCase_Resource_RelEN.TeachSkillOperMethod = objRow[convVideoResCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvVideoResCase_Resource_RelEN.IdSkillType = objRow[convVideoResCase_Resource_Rel.IdSkillType] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号
objvVideoResCase_Resource_RelEN.SkillTypeID = objRow[convVideoResCase_Resource_Rel.SkillTypeID] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID
objvVideoResCase_Resource_RelEN.CaseLevelId = objRow[convVideoResCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvVideoResCase_Resource_RelEN.IsDualVideo = TransNullToBool(objRow[convVideoResCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvVideoResCase_Resource_RelEN.IdXzCollege = objRow[convVideoResCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoResCase_Resource_RelEN.CollegeID = objRow[convVideoResCase_Resource_Rel.CollegeID] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.CollegeID].ToString().Trim(); //学院ID
objvVideoResCase_Resource_RelEN.CollegeName = objRow[convVideoResCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvVideoResCase_Resource_RelEN.CollegeNameA = objRow[convVideoResCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoResCase_Resource_RelEN.IdXzMajor = objRow[convVideoResCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号
objvVideoResCase_Resource_RelEN.MajorID = objRow[convVideoResCase_Resource_Rel.MajorID] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.MajorID].ToString().Trim(); //专业ID
objvVideoResCase_Resource_RelEN.MajorName = objRow[convVideoResCase_Resource_Rel.MajorName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.MajorName].ToString().Trim(); //专业名称
objvVideoResCase_Resource_RelEN.CourseId = objRow[convVideoResCase_Resource_Rel.CourseId] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.CourseId].ToString().Trim(); //课程Id
objvVideoResCase_Resource_RelEN.CourseCode = objRow[convVideoResCase_Resource_Rel.CourseCode] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.CourseCode].ToString().Trim(); //课程代码
objvVideoResCase_Resource_RelEN.CourseName = objRow[convVideoResCase_Resource_Rel.CourseName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.CourseName].ToString().Trim(); //课程名称
objvVideoResCase_Resource_RelEN.CourseChapterId = objRow[convVideoResCase_Resource_Rel.CourseChapterId] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.CourseChapterId].ToString().Trim(); //课程章节ID
objvVideoResCase_Resource_RelEN.CourseChapterName = objRow[convVideoResCase_Resource_Rel.CourseChapterName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.CourseChapterName].ToString().Trim(); //课程章节名称
objvVideoResCase_Resource_RelEN.ParentNodeID = objRow[convVideoResCase_Resource_Rel.ParentNodeID] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.ParentNodeID].ToString().Trim(); //父节点编号
objvVideoResCase_Resource_RelEN.ParentNodeName = objRow[convVideoResCase_Resource_Rel.ParentNodeName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.ParentNodeName].ToString().Trim(); //父节点名称
objvVideoResCase_Resource_RelEN.ViewCount = objRow[convVideoResCase_Resource_Rel.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase_Resource_Rel.ViewCount].ToString().Trim()); //浏览量
objvVideoResCase_Resource_RelEN.IsShow = TransNullToBool(objRow[convVideoResCase_Resource_Rel.IsShow].ToString().Trim()); //是否启用
objvVideoResCase_Resource_RelEN.DownloadNumber = objRow[convVideoResCase_Resource_Rel.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase_Resource_Rel.DownloadNumber].ToString().Trim()); //下载数目
objvVideoResCase_Resource_RelEN.FileIntegration = objRow[convVideoResCase_Resource_Rel.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase_Resource_Rel.FileIntegration].ToString().Trim()); //文件积分
objvVideoResCase_Resource_RelEN.LikeCount = objRow[convVideoResCase_Resource_Rel.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoResCase_Resource_Rel.LikeCount].ToString().Trim()); //资源喜欢数量
objvVideoResCase_Resource_RelEN.CollectionCount = objRow[convVideoResCase_Resource_Rel.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoResCase_Resource_Rel.CollectionCount].ToString().Trim()); //收藏数量
objvVideoResCase_Resource_RelEN.RecommendedDegreeId = objRow[convVideoResCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvVideoResCase_Resource_RelEN.RecommendedDegreeName = objRow[convVideoResCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvVideoResCase_Resource_RelEN.BrowseCount4Case = objRow[convVideoResCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvVideoResCase_Resource_RelEN.OwnerName = objRow[convVideoResCase_Resource_Rel.OwnerName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.OwnerName].ToString().Trim(); //拥有者姓名
objvVideoResCase_Resource_RelEN.OwnerNameWithId = objRow[convVideoResCase_Resource_Rel.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvVideoResCase_Resource_RelEN.IdResource = objRow[convVideoResCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvVideoResCase_Resource_RelEN.ResourceID = objRow[convVideoResCase_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvVideoResCase_Resource_RelEN.ResourceName = objRow[convVideoResCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvVideoResCase_Resource_RelEN.IdFtpResource = objRow[convVideoResCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvVideoResCase_Resource_RelEN.IdFile = objRow[convVideoResCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvVideoResCase_Resource_RelEN.FileName = objRow[convVideoResCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvVideoResCase_Resource_RelEN.FileType = objRow[convVideoResCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvVideoResCase_Resource_RelEN.SaveDate = objRow[convVideoResCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvVideoResCase_Resource_RelEN.FileSize = objRow[convVideoResCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvVideoResCase_Resource_RelEN.SaveTime = objRow[convVideoResCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvVideoResCase_Resource_RelEN.FtpResourceID = objRow[convVideoResCase_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvVideoResCase_Resource_RelEN.FileOriginalName = objRow[convVideoResCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvVideoResCase_Resource_RelEN.FileDirName = objRow[convVideoResCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvVideoResCase_Resource_RelEN.FileRename = objRow[convVideoResCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvVideoResCase_Resource_RelEN.FileUpDate = objRow[convVideoResCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvVideoResCase_Resource_RelEN.FileUpTime = objRow[convVideoResCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvVideoResCase_Resource_RelEN.SaveMode = TransNullToBool(objRow[convVideoResCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvVideoResCase_Resource_RelEN.IdResourceType = objRow[convVideoResCase_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvVideoResCase_Resource_RelEN.ResourceTypeID = objRow[convVideoResCase_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvVideoResCase_Resource_RelEN.ResourceTypeName = objRow[convVideoResCase_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvVideoResCase_Resource_RelEN.ResourceOwner = objRow[convVideoResCase_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvVideoResCase_Resource_RelEN.ftpFileType = objRow[convVideoResCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvVideoResCase_Resource_RelEN.ftpFileSize = objRow[convVideoResCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvVideoResCase_Resource_RelEN.ftpResourceOwner = objRow[convVideoResCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvVideoResCase_Resource_RelEN.FileOriginName = objRow[convVideoResCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvVideoResCase_Resource_RelEN.IsExistFile = TransNullToBool(objRow[convVideoResCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvVideoResCase_Resource_RelEN.FileNewName = objRow[convVideoResCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvVideoResCase_Resource_RelEN.FileOldName = objRow[convVideoResCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvVideoResCase_Resource_RelEN.IsMain = TransNullToBool(objRow[convVideoResCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvVideoResCase_Resource_RelEN.IdUsingMode = objRow[convVideoResCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvVideoResCase_Resource_RelEN.IsVisible = TransNullToBool(objRow[convVideoResCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvVideoResCase_Resource_RelEN.IndexNO = objRow[convVideoResCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvVideoResCase_Resource_RelEN.BrowseCount = objRow[convVideoResCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvVideoResCase_Resource_RelEN.UpdDate = objRow[convVideoResCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvVideoResCase_Resource_RelEN.UpdUser = objRow[convVideoResCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvVideoResCase_Resource_RelEN.Memo = objRow[convVideoResCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convVideoResCase_Resource_Rel.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvVideoResCase_Resource_RelDA: GetObjByDataRow)", objException.Message));
}
objvVideoResCase_Resource_RelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvVideoResCase_Resource_RelEN;
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
objSQL = clsvVideoResCase_Resource_RelDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvVideoResCase_Resource_RelEN._CurrTabName, convVideoResCase_Resource_Rel.IdMicroteachCaseResourceRel, 8, "");
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
objSQL = clsvVideoResCase_Resource_RelDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvVideoResCase_Resource_RelEN._CurrTabName, convVideoResCase_Resource_Rel.IdMicroteachCaseResourceRel, 8, strPrefix);
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
 objSQL = clsvVideoResCase_Resource_RelDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdMicroteachCaseResourceRel from vVideoResCase_Resource_Rel where " + strCondition;
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
 objSQL = clsvVideoResCase_Resource_RelDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdMicroteachCaseResourceRel from vVideoResCase_Resource_Rel where " + strCondition;
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
 objSQL = clsvVideoResCase_Resource_RelDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vVideoResCase_Resource_Rel", "IdMicroteachCaseResourceRel = " + ""+ lngIdMicroteachCaseResourceRel+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvVideoResCase_Resource_RelDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCase_Resource_RelDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vVideoResCase_Resource_Rel", strCondition))
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
objSQL = clsvVideoResCase_Resource_RelDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vVideoResCase_Resource_Rel");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvVideoResCase_Resource_RelENS">源对象</param>
 /// <param name = "objvVideoResCase_Resource_RelENT">目标对象</param>
public void CopyTo(clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelENS, clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelENT)
{
objvVideoResCase_Resource_RelENT.IdMicroteachCaseResourceRel = objvVideoResCase_Resource_RelENS.IdMicroteachCaseResourceRel; //微格案例资源关系流水号
objvVideoResCase_Resource_RelENT.FuncModuleId = objvVideoResCase_Resource_RelENS.FuncModuleId; //功能模块Id
objvVideoResCase_Resource_RelENT.FuncModuleName = objvVideoResCase_Resource_RelENS.FuncModuleName; //功能模块名称
objvVideoResCase_Resource_RelENT.IdMicroteachCase = objvVideoResCase_Resource_RelENS.IdMicroteachCase; //微格教学案例流水号
objvVideoResCase_Resource_RelENT.VideoResCaseID = objvVideoResCase_Resource_RelENS.VideoResCaseID; //视频资源案例ID
objvVideoResCase_Resource_RelENT.VideoResCaseName = objvVideoResCase_Resource_RelENS.VideoResCaseName; //视频资源案例名称
objvVideoResCase_Resource_RelENT.VideoResCaseTheme = objvVideoResCase_Resource_RelENS.VideoResCaseTheme; //视频资源案例主题词
objvVideoResCase_Resource_RelENT.IdVideoResCaseType = objvVideoResCase_Resource_RelENS.IdVideoResCaseType; //视频资源类型流水号
objvVideoResCase_Resource_RelENT.VideoResCaseTypeName = objvVideoResCase_Resource_RelENS.VideoResCaseTypeName; //视频资源案例类型名称
objvVideoResCase_Resource_RelENT.VideoResCaseText = objvVideoResCase_Resource_RelENS.VideoResCaseText; //案例文本内容
objvVideoResCase_Resource_RelENT.VideoResCaseDate = objvVideoResCase_Resource_RelENS.VideoResCaseDate; //视频资源日期
objvVideoResCase_Resource_RelENT.VideoResCaseTime = objvVideoResCase_Resource_RelENS.VideoResCaseTime; //视频资源时间
objvVideoResCase_Resource_RelENT.VideoResCaseDateIn = objvVideoResCase_Resource_RelENS.VideoResCaseDateIn; //案例入库日期
objvVideoResCase_Resource_RelENT.VideoResCaseTimeIn = objvVideoResCase_Resource_RelENS.VideoResCaseTimeIn; //案例入库时间
objvVideoResCase_Resource_RelENT.OwnerId = objvVideoResCase_Resource_RelENS.OwnerId; //拥有者Id
objvVideoResCase_Resource_RelENT.IdStudyLevel = objvVideoResCase_Resource_RelENS.IdStudyLevel; //id_StudyLevel
objvVideoResCase_Resource_RelENT.StudyLevelName = objvVideoResCase_Resource_RelENS.StudyLevelName; //学段名称
objvVideoResCase_Resource_RelENT.IdTeachingPlan = objvVideoResCase_Resource_RelENS.IdTeachingPlan; //教案流水号
objvVideoResCase_Resource_RelENT.IdDiscipline = objvVideoResCase_Resource_RelENS.IdDiscipline; //学科流水号
objvVideoResCase_Resource_RelENT.DisciplineID = objvVideoResCase_Resource_RelENS.DisciplineID; //学科ID
objvVideoResCase_Resource_RelENT.DisciplineName = objvVideoResCase_Resource_RelENS.DisciplineName; //学科名称
objvVideoResCase_Resource_RelENT.senateGaugeVersionID = objvVideoResCase_Resource_RelENS.senateGaugeVersionID; //评价量表版本ID
objvVideoResCase_Resource_RelENT.senateGaugeVersionName = objvVideoResCase_Resource_RelENS.senateGaugeVersionName; //评价量表版本名称
objvVideoResCase_Resource_RelENT.senateGaugeVersionTtlScore = objvVideoResCase_Resource_RelENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvVideoResCase_Resource_RelENT.VersionNo = objvVideoResCase_Resource_RelENS.VersionNo; //版本号
objvVideoResCase_Resource_RelENT.IdTeachSkill = objvVideoResCase_Resource_RelENS.IdTeachSkill; //教学技能流水号
objvVideoResCase_Resource_RelENT.TeachSkillID = objvVideoResCase_Resource_RelENS.TeachSkillID; //教学技能ID
objvVideoResCase_Resource_RelENT.SkillTypeName = objvVideoResCase_Resource_RelENS.SkillTypeName; //技能类型名称
objvVideoResCase_Resource_RelENT.TeachSkillName = objvVideoResCase_Resource_RelENS.TeachSkillName; //教学技能名称
objvVideoResCase_Resource_RelENT.TeachSkillTheory = objvVideoResCase_Resource_RelENS.TeachSkillTheory; //教学技能理论阐述
objvVideoResCase_Resource_RelENT.TeachSkillOperMethod = objvVideoResCase_Resource_RelENS.TeachSkillOperMethod; //教学技能实践操作方法
objvVideoResCase_Resource_RelENT.IdSkillType = objvVideoResCase_Resource_RelENS.IdSkillType; //技能类型流水号
objvVideoResCase_Resource_RelENT.SkillTypeID = objvVideoResCase_Resource_RelENS.SkillTypeID; //技能类型ID
objvVideoResCase_Resource_RelENT.CaseLevelId = objvVideoResCase_Resource_RelENS.CaseLevelId; //课例等级Id
objvVideoResCase_Resource_RelENT.IsDualVideo = objvVideoResCase_Resource_RelENS.IsDualVideo; //是否双视频
objvVideoResCase_Resource_RelENT.IdXzCollege = objvVideoResCase_Resource_RelENS.IdXzCollege; //学院流水号
objvVideoResCase_Resource_RelENT.CollegeID = objvVideoResCase_Resource_RelENS.CollegeID; //学院ID
objvVideoResCase_Resource_RelENT.CollegeName = objvVideoResCase_Resource_RelENS.CollegeName; //学院名称
objvVideoResCase_Resource_RelENT.CollegeNameA = objvVideoResCase_Resource_RelENS.CollegeNameA; //学院名称简写
objvVideoResCase_Resource_RelENT.IdXzMajor = objvVideoResCase_Resource_RelENS.IdXzMajor; //专业流水号
objvVideoResCase_Resource_RelENT.MajorID = objvVideoResCase_Resource_RelENS.MajorID; //专业ID
objvVideoResCase_Resource_RelENT.MajorName = objvVideoResCase_Resource_RelENS.MajorName; //专业名称
objvVideoResCase_Resource_RelENT.CourseId = objvVideoResCase_Resource_RelENS.CourseId; //课程Id
objvVideoResCase_Resource_RelENT.CourseCode = objvVideoResCase_Resource_RelENS.CourseCode; //课程代码
objvVideoResCase_Resource_RelENT.CourseName = objvVideoResCase_Resource_RelENS.CourseName; //课程名称
objvVideoResCase_Resource_RelENT.CourseChapterId = objvVideoResCase_Resource_RelENS.CourseChapterId; //课程章节ID
objvVideoResCase_Resource_RelENT.CourseChapterName = objvVideoResCase_Resource_RelENS.CourseChapterName; //课程章节名称
objvVideoResCase_Resource_RelENT.ParentNodeID = objvVideoResCase_Resource_RelENS.ParentNodeID; //父节点编号
objvVideoResCase_Resource_RelENT.ParentNodeName = objvVideoResCase_Resource_RelENS.ParentNodeName; //父节点名称
objvVideoResCase_Resource_RelENT.ViewCount = objvVideoResCase_Resource_RelENS.ViewCount; //浏览量
objvVideoResCase_Resource_RelENT.IsShow = objvVideoResCase_Resource_RelENS.IsShow; //是否启用
objvVideoResCase_Resource_RelENT.DownloadNumber = objvVideoResCase_Resource_RelENS.DownloadNumber; //下载数目
objvVideoResCase_Resource_RelENT.FileIntegration = objvVideoResCase_Resource_RelENS.FileIntegration; //文件积分
objvVideoResCase_Resource_RelENT.LikeCount = objvVideoResCase_Resource_RelENS.LikeCount; //资源喜欢数量
objvVideoResCase_Resource_RelENT.CollectionCount = objvVideoResCase_Resource_RelENS.CollectionCount; //收藏数量
objvVideoResCase_Resource_RelENT.RecommendedDegreeId = objvVideoResCase_Resource_RelENS.RecommendedDegreeId; //推荐度Id
objvVideoResCase_Resource_RelENT.RecommendedDegreeName = objvVideoResCase_Resource_RelENS.RecommendedDegreeName; //推荐度名称
objvVideoResCase_Resource_RelENT.BrowseCount4Case = objvVideoResCase_Resource_RelENS.BrowseCount4Case; //课例浏览次数
objvVideoResCase_Resource_RelENT.OwnerName = objvVideoResCase_Resource_RelENS.OwnerName; //拥有者姓名
objvVideoResCase_Resource_RelENT.OwnerNameWithId = objvVideoResCase_Resource_RelENS.OwnerNameWithId; //拥有者名称附Id
objvVideoResCase_Resource_RelENT.IdResource = objvVideoResCase_Resource_RelENS.IdResource; //资源流水号
objvVideoResCase_Resource_RelENT.ResourceID = objvVideoResCase_Resource_RelENS.ResourceID; //资源ID
objvVideoResCase_Resource_RelENT.ResourceName = objvVideoResCase_Resource_RelENS.ResourceName; //资源名称
objvVideoResCase_Resource_RelENT.IdFtpResource = objvVideoResCase_Resource_RelENS.IdFtpResource; //FTP资源流水号
objvVideoResCase_Resource_RelENT.IdFile = objvVideoResCase_Resource_RelENS.IdFile; //文件流水号
objvVideoResCase_Resource_RelENT.FileName = objvVideoResCase_Resource_RelENS.FileName; //文件名称
objvVideoResCase_Resource_RelENT.FileType = objvVideoResCase_Resource_RelENS.FileType; //文件类型
objvVideoResCase_Resource_RelENT.SaveDate = objvVideoResCase_Resource_RelENS.SaveDate; //创建日期
objvVideoResCase_Resource_RelENT.FileSize = objvVideoResCase_Resource_RelENS.FileSize; //文件大小
objvVideoResCase_Resource_RelENT.SaveTime = objvVideoResCase_Resource_RelENS.SaveTime; //创建时间
objvVideoResCase_Resource_RelENT.FtpResourceID = objvVideoResCase_Resource_RelENS.FtpResourceID; //FTP资源ID
objvVideoResCase_Resource_RelENT.FileOriginalName = objvVideoResCase_Resource_RelENS.FileOriginalName; //文件原名
objvVideoResCase_Resource_RelENT.FileDirName = objvVideoResCase_Resource_RelENS.FileDirName; //文件目录名
objvVideoResCase_Resource_RelENT.FileRename = objvVideoResCase_Resource_RelENS.FileRename; //文件新名
objvVideoResCase_Resource_RelENT.FileUpDate = objvVideoResCase_Resource_RelENS.FileUpDate; //创建日期
objvVideoResCase_Resource_RelENT.FileUpTime = objvVideoResCase_Resource_RelENS.FileUpTime; //创建时间
objvVideoResCase_Resource_RelENT.SaveMode = objvVideoResCase_Resource_RelENS.SaveMode; //文件存放方式
objvVideoResCase_Resource_RelENT.IdResourceType = objvVideoResCase_Resource_RelENS.IdResourceType; //资源类型流水号
objvVideoResCase_Resource_RelENT.ResourceTypeID = objvVideoResCase_Resource_RelENS.ResourceTypeID; //资源类型ID
objvVideoResCase_Resource_RelENT.ResourceTypeName = objvVideoResCase_Resource_RelENS.ResourceTypeName; //资源类型名称
objvVideoResCase_Resource_RelENT.ResourceOwner = objvVideoResCase_Resource_RelENS.ResourceOwner; //上传者
objvVideoResCase_Resource_RelENT.ftpFileType = objvVideoResCase_Resource_RelENS.ftpFileType; //ftp文件类型
objvVideoResCase_Resource_RelENT.ftpFileSize = objvVideoResCase_Resource_RelENS.ftpFileSize; //ftp文件大小
objvVideoResCase_Resource_RelENT.ftpResourceOwner = objvVideoResCase_Resource_RelENS.ftpResourceOwner; //Ftp资源拥有者
objvVideoResCase_Resource_RelENT.FileOriginName = objvVideoResCase_Resource_RelENS.FileOriginName; //原文件名
objvVideoResCase_Resource_RelENT.IsExistFile = objvVideoResCase_Resource_RelENS.IsExistFile; //是否存在文件
objvVideoResCase_Resource_RelENT.FileNewName = objvVideoResCase_Resource_RelENS.FileNewName; //新文件名
objvVideoResCase_Resource_RelENT.FileOldName = objvVideoResCase_Resource_RelENS.FileOldName; //旧文件名
objvVideoResCase_Resource_RelENT.IsMain = objvVideoResCase_Resource_RelENS.IsMain; //是否主资源
objvVideoResCase_Resource_RelENT.IdUsingMode = objvVideoResCase_Resource_RelENS.IdUsingMode; //资源使用模式流水号
objvVideoResCase_Resource_RelENT.IsVisible = objvVideoResCase_Resource_RelENS.IsVisible; //是否显示
objvVideoResCase_Resource_RelENT.IndexNO = objvVideoResCase_Resource_RelENS.IndexNO; //序号
objvVideoResCase_Resource_RelENT.BrowseCount = objvVideoResCase_Resource_RelENS.BrowseCount; //浏览次数
objvVideoResCase_Resource_RelENT.UpdDate = objvVideoResCase_Resource_RelENS.UpdDate; //修改日期
objvVideoResCase_Resource_RelENT.UpdUser = objvVideoResCase_Resource_RelENS.UpdUser; //修改人
objvVideoResCase_Resource_RelENT.Memo = objvVideoResCase_Resource_RelENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvVideoResCase_Resource_RelEN objvVideoResCase_Resource_RelEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.FuncModuleId, 4, convVideoResCase_Resource_Rel.FuncModuleId);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.FuncModuleName, 30, convVideoResCase_Resource_Rel.FuncModuleName);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.IdMicroteachCase, 8, convVideoResCase_Resource_Rel.IdMicroteachCase);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.VideoResCaseID, 8, convVideoResCase_Resource_Rel.VideoResCaseID);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.VideoResCaseName, 100, convVideoResCase_Resource_Rel.VideoResCaseName);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.VideoResCaseTheme, 200, convVideoResCase_Resource_Rel.VideoResCaseTheme);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.IdVideoResCaseType, 4, convVideoResCase_Resource_Rel.IdVideoResCaseType);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.VideoResCaseTypeName, 30, convVideoResCase_Resource_Rel.VideoResCaseTypeName);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.VideoResCaseText, 8000, convVideoResCase_Resource_Rel.VideoResCaseText);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.VideoResCaseDate, 8, convVideoResCase_Resource_Rel.VideoResCaseDate);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.VideoResCaseTime, 6, convVideoResCase_Resource_Rel.VideoResCaseTime);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.VideoResCaseDateIn, 8, convVideoResCase_Resource_Rel.VideoResCaseDateIn);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.VideoResCaseTimeIn, 6, convVideoResCase_Resource_Rel.VideoResCaseTimeIn);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.OwnerId, 20, convVideoResCase_Resource_Rel.OwnerId);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.IdStudyLevel, 4, convVideoResCase_Resource_Rel.IdStudyLevel);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.StudyLevelName, 50, convVideoResCase_Resource_Rel.StudyLevelName);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.IdTeachingPlan, 8, convVideoResCase_Resource_Rel.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.IdDiscipline, 4, convVideoResCase_Resource_Rel.IdDiscipline);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.DisciplineID, 4, convVideoResCase_Resource_Rel.DisciplineID);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.DisciplineName, 50, convVideoResCase_Resource_Rel.DisciplineName);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.senateGaugeVersionID, 4, convVideoResCase_Resource_Rel.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.senateGaugeVersionName, 200, convVideoResCase_Resource_Rel.senateGaugeVersionName);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.IdTeachSkill, 8, convVideoResCase_Resource_Rel.IdTeachSkill);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.TeachSkillID, 8, convVideoResCase_Resource_Rel.TeachSkillID);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.SkillTypeName, 50, convVideoResCase_Resource_Rel.SkillTypeName);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.TeachSkillName, 50, convVideoResCase_Resource_Rel.TeachSkillName);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.TeachSkillTheory, 8000, convVideoResCase_Resource_Rel.TeachSkillTheory);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.TeachSkillOperMethod, 2000, convVideoResCase_Resource_Rel.TeachSkillOperMethod);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.IdSkillType, 4, convVideoResCase_Resource_Rel.IdSkillType);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.SkillTypeID, 4, convVideoResCase_Resource_Rel.SkillTypeID);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.CaseLevelId, 2, convVideoResCase_Resource_Rel.CaseLevelId);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.IdXzCollege, 4, convVideoResCase_Resource_Rel.IdXzCollege);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.CollegeID, 4, convVideoResCase_Resource_Rel.CollegeID);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.CollegeName, 100, convVideoResCase_Resource_Rel.CollegeName);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.CollegeNameA, 12, convVideoResCase_Resource_Rel.CollegeNameA);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.IdXzMajor, 8, convVideoResCase_Resource_Rel.IdXzMajor);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.MajorID, 4, convVideoResCase_Resource_Rel.MajorID);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.MajorName, 100, convVideoResCase_Resource_Rel.MajorName);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.CourseId, 8, convVideoResCase_Resource_Rel.CourseId);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.CourseCode, 20, convVideoResCase_Resource_Rel.CourseCode);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.CourseName, 100, convVideoResCase_Resource_Rel.CourseName);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.CourseChapterId, 8, convVideoResCase_Resource_Rel.CourseChapterId);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.CourseChapterName, 100, convVideoResCase_Resource_Rel.CourseChapterName);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.ParentNodeID, 8, convVideoResCase_Resource_Rel.ParentNodeID);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.ParentNodeName, 50, convVideoResCase_Resource_Rel.ParentNodeName);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.RecommendedDegreeId, 2, convVideoResCase_Resource_Rel.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.RecommendedDegreeName, 30, convVideoResCase_Resource_Rel.RecommendedDegreeName);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.OwnerName, 30, convVideoResCase_Resource_Rel.OwnerName);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.OwnerNameWithId, 51, convVideoResCase_Resource_Rel.OwnerNameWithId);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.IdResource, 8, convVideoResCase_Resource_Rel.IdResource);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.ResourceID, 8, convVideoResCase_Resource_Rel.ResourceID);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.ResourceName, 100, convVideoResCase_Resource_Rel.ResourceName);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.IdFtpResource, 8, convVideoResCase_Resource_Rel.IdFtpResource);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.IdFile, 8, convVideoResCase_Resource_Rel.IdFile);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.FileName, 500, convVideoResCase_Resource_Rel.FileName);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.FileType, 30, convVideoResCase_Resource_Rel.FileType);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.SaveDate, 8, convVideoResCase_Resource_Rel.SaveDate);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.FileSize, 50, convVideoResCase_Resource_Rel.FileSize);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.SaveTime, 6, convVideoResCase_Resource_Rel.SaveTime);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.FtpResourceID, 8, convVideoResCase_Resource_Rel.FtpResourceID);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.FileOriginalName, 200, convVideoResCase_Resource_Rel.FileOriginalName);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.FileDirName, 200, convVideoResCase_Resource_Rel.FileDirName);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.FileRename, 200, convVideoResCase_Resource_Rel.FileRename);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.FileUpDate, 8, convVideoResCase_Resource_Rel.FileUpDate);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.FileUpTime, 6, convVideoResCase_Resource_Rel.FileUpTime);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.IdResourceType, 4, convVideoResCase_Resource_Rel.IdResourceType);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.ResourceTypeID, 4, convVideoResCase_Resource_Rel.ResourceTypeID);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.ResourceTypeName, 50, convVideoResCase_Resource_Rel.ResourceTypeName);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.ResourceOwner, 50, convVideoResCase_Resource_Rel.ResourceOwner);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.ftpFileType, 30, convVideoResCase_Resource_Rel.ftpFileType);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.ftpFileSize, 50, convVideoResCase_Resource_Rel.ftpFileSize);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.ftpResourceOwner, 50, convVideoResCase_Resource_Rel.ftpResourceOwner);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.FileOriginName, 500, convVideoResCase_Resource_Rel.FileOriginName);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.FileNewName, 530, convVideoResCase_Resource_Rel.FileNewName);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.FileOldName, 530, convVideoResCase_Resource_Rel.FileOldName);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.IdUsingMode, 4, convVideoResCase_Resource_Rel.IdUsingMode);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.UpdDate, 20, convVideoResCase_Resource_Rel.UpdDate);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.UpdUser, 20, convVideoResCase_Resource_Rel.UpdUser);
clsCheckSql.CheckFieldLen(objvVideoResCase_Resource_RelEN.Memo, 1000, convVideoResCase_Resource_Rel.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.FuncModuleId, convVideoResCase_Resource_Rel.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.FuncModuleName, convVideoResCase_Resource_Rel.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.IdMicroteachCase, convVideoResCase_Resource_Rel.IdMicroteachCase);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.VideoResCaseID, convVideoResCase_Resource_Rel.VideoResCaseID);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.VideoResCaseName, convVideoResCase_Resource_Rel.VideoResCaseName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.VideoResCaseTheme, convVideoResCase_Resource_Rel.VideoResCaseTheme);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.IdVideoResCaseType, convVideoResCase_Resource_Rel.IdVideoResCaseType);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.VideoResCaseTypeName, convVideoResCase_Resource_Rel.VideoResCaseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.VideoResCaseText, convVideoResCase_Resource_Rel.VideoResCaseText);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.VideoResCaseDate, convVideoResCase_Resource_Rel.VideoResCaseDate);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.VideoResCaseTime, convVideoResCase_Resource_Rel.VideoResCaseTime);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.VideoResCaseDateIn, convVideoResCase_Resource_Rel.VideoResCaseDateIn);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.VideoResCaseTimeIn, convVideoResCase_Resource_Rel.VideoResCaseTimeIn);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.OwnerId, convVideoResCase_Resource_Rel.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.IdStudyLevel, convVideoResCase_Resource_Rel.IdStudyLevel);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.StudyLevelName, convVideoResCase_Resource_Rel.StudyLevelName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.IdTeachingPlan, convVideoResCase_Resource_Rel.IdTeachingPlan);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.IdDiscipline, convVideoResCase_Resource_Rel.IdDiscipline);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.DisciplineID, convVideoResCase_Resource_Rel.DisciplineID);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.DisciplineName, convVideoResCase_Resource_Rel.DisciplineName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.senateGaugeVersionID, convVideoResCase_Resource_Rel.senateGaugeVersionID);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.senateGaugeVersionName, convVideoResCase_Resource_Rel.senateGaugeVersionName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.IdTeachSkill, convVideoResCase_Resource_Rel.IdTeachSkill);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.TeachSkillID, convVideoResCase_Resource_Rel.TeachSkillID);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.SkillTypeName, convVideoResCase_Resource_Rel.SkillTypeName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.TeachSkillName, convVideoResCase_Resource_Rel.TeachSkillName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.TeachSkillTheory, convVideoResCase_Resource_Rel.TeachSkillTheory);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.TeachSkillOperMethod, convVideoResCase_Resource_Rel.TeachSkillOperMethod);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.IdSkillType, convVideoResCase_Resource_Rel.IdSkillType);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.SkillTypeID, convVideoResCase_Resource_Rel.SkillTypeID);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.CaseLevelId, convVideoResCase_Resource_Rel.CaseLevelId);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.IdXzCollege, convVideoResCase_Resource_Rel.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.CollegeID, convVideoResCase_Resource_Rel.CollegeID);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.CollegeName, convVideoResCase_Resource_Rel.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.CollegeNameA, convVideoResCase_Resource_Rel.CollegeNameA);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.IdXzMajor, convVideoResCase_Resource_Rel.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.MajorID, convVideoResCase_Resource_Rel.MajorID);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.MajorName, convVideoResCase_Resource_Rel.MajorName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.CourseId, convVideoResCase_Resource_Rel.CourseId);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.CourseCode, convVideoResCase_Resource_Rel.CourseCode);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.CourseName, convVideoResCase_Resource_Rel.CourseName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.CourseChapterId, convVideoResCase_Resource_Rel.CourseChapterId);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.CourseChapterName, convVideoResCase_Resource_Rel.CourseChapterName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.ParentNodeID, convVideoResCase_Resource_Rel.ParentNodeID);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.ParentNodeName, convVideoResCase_Resource_Rel.ParentNodeName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.RecommendedDegreeId, convVideoResCase_Resource_Rel.RecommendedDegreeId);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.RecommendedDegreeName, convVideoResCase_Resource_Rel.RecommendedDegreeName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.OwnerName, convVideoResCase_Resource_Rel.OwnerName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.OwnerNameWithId, convVideoResCase_Resource_Rel.OwnerNameWithId);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.IdResource, convVideoResCase_Resource_Rel.IdResource);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.ResourceID, convVideoResCase_Resource_Rel.ResourceID);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.ResourceName, convVideoResCase_Resource_Rel.ResourceName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.IdFtpResource, convVideoResCase_Resource_Rel.IdFtpResource);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.IdFile, convVideoResCase_Resource_Rel.IdFile);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.FileName, convVideoResCase_Resource_Rel.FileName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.FileType, convVideoResCase_Resource_Rel.FileType);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.SaveDate, convVideoResCase_Resource_Rel.SaveDate);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.FileSize, convVideoResCase_Resource_Rel.FileSize);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.SaveTime, convVideoResCase_Resource_Rel.SaveTime);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.FtpResourceID, convVideoResCase_Resource_Rel.FtpResourceID);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.FileOriginalName, convVideoResCase_Resource_Rel.FileOriginalName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.FileDirName, convVideoResCase_Resource_Rel.FileDirName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.FileRename, convVideoResCase_Resource_Rel.FileRename);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.FileUpDate, convVideoResCase_Resource_Rel.FileUpDate);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.FileUpTime, convVideoResCase_Resource_Rel.FileUpTime);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.IdResourceType, convVideoResCase_Resource_Rel.IdResourceType);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.ResourceTypeID, convVideoResCase_Resource_Rel.ResourceTypeID);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.ResourceTypeName, convVideoResCase_Resource_Rel.ResourceTypeName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.ResourceOwner, convVideoResCase_Resource_Rel.ResourceOwner);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.ftpFileType, convVideoResCase_Resource_Rel.ftpFileType);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.ftpFileSize, convVideoResCase_Resource_Rel.ftpFileSize);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.ftpResourceOwner, convVideoResCase_Resource_Rel.ftpResourceOwner);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.FileOriginName, convVideoResCase_Resource_Rel.FileOriginName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.FileNewName, convVideoResCase_Resource_Rel.FileNewName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.FileOldName, convVideoResCase_Resource_Rel.FileOldName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.IdUsingMode, convVideoResCase_Resource_Rel.IdUsingMode);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.UpdDate, convVideoResCase_Resource_Rel.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.UpdUser, convVideoResCase_Resource_Rel.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_Resource_RelEN.Memo, convVideoResCase_Resource_Rel.Memo);
//检查外键字段长度
 objvVideoResCase_Resource_RelEN._IsCheckProperty = true;
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
 objSQL = clsvVideoResCase_Resource_RelDA.GetSpecSQLObj();
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
 objSQL = clsvVideoResCase_Resource_RelDA.GetSpecSQLObj();
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
 objSQL = clsvVideoResCase_Resource_RelDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvVideoResCase_Resource_RelEN._CurrTabName);
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
 objSQL = clsvVideoResCase_Resource_RelDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvVideoResCase_Resource_RelEN._CurrTabName, strCondition);
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
 objSQL = clsvVideoResCase_Resource_RelDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}