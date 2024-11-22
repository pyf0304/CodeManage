
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvVideoLibQuantitySenateDA
 表名:vVideoLibQuantitySenate(01120449)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:50:41
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
 /// v视频库量化评议(vVideoLibQuantitySenate)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvVideoLibQuantitySenateDA : clsCommBase4DA
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
 return clsvVideoLibQuantitySenateEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvVideoLibQuantitySenateEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvVideoLibQuantitySenateEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvVideoLibQuantitySenateEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvVideoLibQuantitySenateEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvVideoLibQuantitySenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vVideoLibQuantitySenate where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vVideoLibQuantitySenate(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvVideoLibQuantitySenateDA: GetDataTable_vVideoLibQuantitySenate)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vVideoLibQuantitySenate where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvVideoLibQuantitySenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibQuantitySenateDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvVideoLibQuantitySenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vVideoLibQuantitySenate where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvVideoLibQuantitySenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibQuantitySenateDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvVideoLibQuantitySenateDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibQuantitySenateDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vVideoLibQuantitySenate where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vVideoLibQuantitySenate where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvVideoLibQuantitySenateDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibQuantitySenateDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vVideoLibQuantitySenate where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvVideoLibQuantitySenateDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibQuantitySenateDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vVideoLibQuantitySenate.* from vVideoLibQuantitySenate Left Join {1} on {2} where {3} and vVideoLibQuantitySenate.IdmicroteachCaseQuantitySenate not in (Select top {5} vVideoLibQuantitySenate.IdmicroteachCaseQuantitySenate from vVideoLibQuantitySenate Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vVideoLibQuantitySenate where {1} and IdmicroteachCaseQuantitySenate not in (Select top {2} IdmicroteachCaseQuantitySenate from vVideoLibQuantitySenate where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vVideoLibQuantitySenate where {1} and IdmicroteachCaseQuantitySenate not in (Select top {3} IdmicroteachCaseQuantitySenate from vVideoLibQuantitySenate where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvVideoLibQuantitySenateDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibQuantitySenateDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vVideoLibQuantitySenate.* from vVideoLibQuantitySenate Left Join {1} on {2} where {3} and vVideoLibQuantitySenate.IdmicroteachCaseQuantitySenate not in (Select top {5} vVideoLibQuantitySenate.IdmicroteachCaseQuantitySenate from vVideoLibQuantitySenate Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vVideoLibQuantitySenate where {1} and IdmicroteachCaseQuantitySenate not in (Select top {2} IdmicroteachCaseQuantitySenate from vVideoLibQuantitySenate where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vVideoLibQuantitySenate where {1} and IdmicroteachCaseQuantitySenate not in (Select top {3} IdmicroteachCaseQuantitySenate from vVideoLibQuantitySenate where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvVideoLibQuantitySenateEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvVideoLibQuantitySenateDA:GetObjLst)", objException.Message));
}
List<clsvVideoLibQuantitySenateEN> arrObjLst = new List<clsvVideoLibQuantitySenateEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vVideoLibQuantitySenate where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN = new clsvVideoLibQuantitySenateEN();
try
{
objvVideoLibQuantitySenateEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convVideoLibQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvVideoLibQuantitySenateEN.FuncModuleId = objRow[convVideoLibQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoLibQuantitySenateEN.FuncModuleName = objRow[convVideoLibQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoLibQuantitySenateEN.IdMicroteachCase = objRow[convVideoLibQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoLibQuantitySenateEN.IdVideoLib = objRow[convVideoLibQuantitySenate.IdVideoLib] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.IdVideoLib].ToString().Trim(); //视频库流水号
objvVideoLibQuantitySenateEN.VideoLibID = objRow[convVideoLibQuantitySenate.VideoLibID] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLibQuantitySenateEN.VideoLibName = objRow[convVideoLibQuantitySenate.VideoLibName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibName].ToString().Trim(); //视频名称
objvVideoLibQuantitySenateEN.VideoLibTheme = objRow[convVideoLibQuantitySenate.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibTheme].ToString().Trim(); //视频库主题词
objvVideoLibQuantitySenateEN.VideoLibTypeName = objRow[convVideoLibQuantitySenate.VideoLibTypeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibTypeName].ToString().Trim(); //视频库类型名称
objvVideoLibQuantitySenateEN.VideoLibDate = objRow[convVideoLibQuantitySenate.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibDate].ToString().Trim(); //视频资源日期
objvVideoLibQuantitySenateEN.VideoLibTime = objRow[convVideoLibQuantitySenate.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibTime].ToString().Trim(); //视频资源时间
objvVideoLibQuantitySenateEN.VideoLibDateIn = objRow[convVideoLibQuantitySenate.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibDateIn].ToString().Trim(); //案例入库日期
objvVideoLibQuantitySenateEN.VideoLibTimeIn = objRow[convVideoLibQuantitySenate.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objvVideoLibQuantitySenateEN.OwnerId = objRow[convVideoLibQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvVideoLibQuantitySenateEN.IdXzCollege = objRow[convVideoLibQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLibQuantitySenateEN.CollegeID = objRow[convVideoLibQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvVideoLibQuantitySenateEN.CollegeName = objRow[convVideoLibQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvVideoLibQuantitySenateEN.CollegeNameA = objRow[convVideoLibQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoLibQuantitySenateEN.ViewCount = objRow[convVideoLibQuantitySenate.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLibQuantitySenate.ViewCount].ToString().Trim()); //浏览量
objvVideoLibQuantitySenateEN.DownloadNumber = objRow[convVideoLibQuantitySenate.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLibQuantitySenate.DownloadNumber].ToString().Trim()); //下载数目
objvVideoLibQuantitySenateEN.FileIntegration = objRow[convVideoLibQuantitySenate.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLibQuantitySenate.FileIntegration].ToString().Trim()); //文件积分
objvVideoLibQuantitySenateEN.LikeCount = objRow[convVideoLibQuantitySenate.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoLibQuantitySenate.LikeCount].ToString().Trim()); //资源喜欢数量
objvVideoLibQuantitySenateEN.CollectionCount = objRow[convVideoLibQuantitySenate.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoLibQuantitySenate.CollectionCount].ToString().Trim()); //收藏数量
objvVideoLibQuantitySenateEN.CourseId = objRow[convVideoLibQuantitySenate.CourseId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CourseId].ToString().Trim(); //课程Id
objvVideoLibQuantitySenateEN.CourseCode = objRow[convVideoLibQuantitySenate.CourseCode] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CourseCode].ToString().Trim(); //课程代码
objvVideoLibQuantitySenateEN.CourseName = objRow[convVideoLibQuantitySenate.CourseName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CourseName].ToString().Trim(); //课程名称
objvVideoLibQuantitySenateEN.OwnerName = objRow[convVideoLibQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvVideoLibQuantitySenateEN.OwnerNameWithId = objRow[convVideoLibQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvVideoLibQuantitySenateEN.IdAppraiseType = objRow[convVideoLibQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvVideoLibQuantitySenateEN.AppraiseTypeName = objRow[convVideoLibQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvVideoLibQuantitySenateEN.SenateTheme = objRow[convVideoLibQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvVideoLibQuantitySenateEN.SenateContent = objRow[convVideoLibQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvVideoLibQuantitySenateEN.SenateTotalScore = TransNullToFloat(objRow[convVideoLibQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvVideoLibQuantitySenateEN.SenateDate = objRow[convVideoLibQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvVideoLibQuantitySenateEN.SenateTime = objRow[convVideoLibQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvVideoLibQuantitySenateEN.SenateIp = objRow[convVideoLibQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvVideoLibQuantitySenateEN.BrowseCount = objRow[convVideoLibQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLibQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvVideoLibQuantitySenateEN.IdSenateGaugeVersion = objRow[convVideoLibQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvVideoLibQuantitySenateEN.senateGaugeVersionID = objRow[convVideoLibQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoLibQuantitySenateEN.senateGaugeVersionName = objRow[convVideoLibQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoLibQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convVideoLibQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convVideoLibQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoLibQuantitySenateEN.UserId = objRow[convVideoLibQuantitySenate.UserId].ToString().Trim(); //用户ID
objvVideoLibQuantitySenateEN.UserNameWithUserId = objRow[convVideoLibQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvVideoLibQuantitySenateEN.UserName = objRow[convVideoLibQuantitySenate.UserName].ToString().Trim(); //用户名
objvVideoLibQuantitySenateEN.UserKindId = objRow[convVideoLibQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvVideoLibQuantitySenateEN.UserKindName = objRow[convVideoLibQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvVideoLibQuantitySenateEN.UserTypeId = objRow[convVideoLibQuantitySenate.UserTypeId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UserTypeId].ToString().Trim(); //用户类型Id
objvVideoLibQuantitySenateEN.UserTypeName = objRow[convVideoLibQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
objvVideoLibQuantitySenateEN.UpdUser = objRow[convVideoLibQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvVideoLibQuantitySenateEN.Memo = objRow[convVideoLibQuantitySenate.Memo] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.Memo].ToString().Trim(); //备注
objvVideoLibQuantitySenateEN.UpdUserName = objRow[convVideoLibQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvVideoLibQuantitySenateDA: GetObjLst)", objException.Message));
}
objvVideoLibQuantitySenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvVideoLibQuantitySenateEN);
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
public List<clsvVideoLibQuantitySenateEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvVideoLibQuantitySenateDA:GetObjLstByTabName)", objException.Message));
}
List<clsvVideoLibQuantitySenateEN> arrObjLst = new List<clsvVideoLibQuantitySenateEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibQuantitySenateDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN = new clsvVideoLibQuantitySenateEN();
try
{
objvVideoLibQuantitySenateEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convVideoLibQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvVideoLibQuantitySenateEN.FuncModuleId = objRow[convVideoLibQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoLibQuantitySenateEN.FuncModuleName = objRow[convVideoLibQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoLibQuantitySenateEN.IdMicroteachCase = objRow[convVideoLibQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoLibQuantitySenateEN.IdVideoLib = objRow[convVideoLibQuantitySenate.IdVideoLib] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.IdVideoLib].ToString().Trim(); //视频库流水号
objvVideoLibQuantitySenateEN.VideoLibID = objRow[convVideoLibQuantitySenate.VideoLibID] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLibQuantitySenateEN.VideoLibName = objRow[convVideoLibQuantitySenate.VideoLibName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibName].ToString().Trim(); //视频名称
objvVideoLibQuantitySenateEN.VideoLibTheme = objRow[convVideoLibQuantitySenate.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibTheme].ToString().Trim(); //视频库主题词
objvVideoLibQuantitySenateEN.VideoLibTypeName = objRow[convVideoLibQuantitySenate.VideoLibTypeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibTypeName].ToString().Trim(); //视频库类型名称
objvVideoLibQuantitySenateEN.VideoLibDate = objRow[convVideoLibQuantitySenate.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibDate].ToString().Trim(); //视频资源日期
objvVideoLibQuantitySenateEN.VideoLibTime = objRow[convVideoLibQuantitySenate.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibTime].ToString().Trim(); //视频资源时间
objvVideoLibQuantitySenateEN.VideoLibDateIn = objRow[convVideoLibQuantitySenate.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibDateIn].ToString().Trim(); //案例入库日期
objvVideoLibQuantitySenateEN.VideoLibTimeIn = objRow[convVideoLibQuantitySenate.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objvVideoLibQuantitySenateEN.OwnerId = objRow[convVideoLibQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvVideoLibQuantitySenateEN.IdXzCollege = objRow[convVideoLibQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLibQuantitySenateEN.CollegeID = objRow[convVideoLibQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvVideoLibQuantitySenateEN.CollegeName = objRow[convVideoLibQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvVideoLibQuantitySenateEN.CollegeNameA = objRow[convVideoLibQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoLibQuantitySenateEN.ViewCount = objRow[convVideoLibQuantitySenate.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLibQuantitySenate.ViewCount].ToString().Trim()); //浏览量
objvVideoLibQuantitySenateEN.DownloadNumber = objRow[convVideoLibQuantitySenate.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLibQuantitySenate.DownloadNumber].ToString().Trim()); //下载数目
objvVideoLibQuantitySenateEN.FileIntegration = objRow[convVideoLibQuantitySenate.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLibQuantitySenate.FileIntegration].ToString().Trim()); //文件积分
objvVideoLibQuantitySenateEN.LikeCount = objRow[convVideoLibQuantitySenate.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoLibQuantitySenate.LikeCount].ToString().Trim()); //资源喜欢数量
objvVideoLibQuantitySenateEN.CollectionCount = objRow[convVideoLibQuantitySenate.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoLibQuantitySenate.CollectionCount].ToString().Trim()); //收藏数量
objvVideoLibQuantitySenateEN.CourseId = objRow[convVideoLibQuantitySenate.CourseId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CourseId].ToString().Trim(); //课程Id
objvVideoLibQuantitySenateEN.CourseCode = objRow[convVideoLibQuantitySenate.CourseCode] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CourseCode].ToString().Trim(); //课程代码
objvVideoLibQuantitySenateEN.CourseName = objRow[convVideoLibQuantitySenate.CourseName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CourseName].ToString().Trim(); //课程名称
objvVideoLibQuantitySenateEN.OwnerName = objRow[convVideoLibQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvVideoLibQuantitySenateEN.OwnerNameWithId = objRow[convVideoLibQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvVideoLibQuantitySenateEN.IdAppraiseType = objRow[convVideoLibQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvVideoLibQuantitySenateEN.AppraiseTypeName = objRow[convVideoLibQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvVideoLibQuantitySenateEN.SenateTheme = objRow[convVideoLibQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvVideoLibQuantitySenateEN.SenateContent = objRow[convVideoLibQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvVideoLibQuantitySenateEN.SenateTotalScore = TransNullToFloat(objRow[convVideoLibQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvVideoLibQuantitySenateEN.SenateDate = objRow[convVideoLibQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvVideoLibQuantitySenateEN.SenateTime = objRow[convVideoLibQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvVideoLibQuantitySenateEN.SenateIp = objRow[convVideoLibQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvVideoLibQuantitySenateEN.BrowseCount = objRow[convVideoLibQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLibQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvVideoLibQuantitySenateEN.IdSenateGaugeVersion = objRow[convVideoLibQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvVideoLibQuantitySenateEN.senateGaugeVersionID = objRow[convVideoLibQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoLibQuantitySenateEN.senateGaugeVersionName = objRow[convVideoLibQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoLibQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convVideoLibQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convVideoLibQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoLibQuantitySenateEN.UserId = objRow[convVideoLibQuantitySenate.UserId].ToString().Trim(); //用户ID
objvVideoLibQuantitySenateEN.UserNameWithUserId = objRow[convVideoLibQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvVideoLibQuantitySenateEN.UserName = objRow[convVideoLibQuantitySenate.UserName].ToString().Trim(); //用户名
objvVideoLibQuantitySenateEN.UserKindId = objRow[convVideoLibQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvVideoLibQuantitySenateEN.UserKindName = objRow[convVideoLibQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvVideoLibQuantitySenateEN.UserTypeId = objRow[convVideoLibQuantitySenate.UserTypeId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UserTypeId].ToString().Trim(); //用户类型Id
objvVideoLibQuantitySenateEN.UserTypeName = objRow[convVideoLibQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
objvVideoLibQuantitySenateEN.UpdUser = objRow[convVideoLibQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvVideoLibQuantitySenateEN.Memo = objRow[convVideoLibQuantitySenate.Memo] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.Memo].ToString().Trim(); //备注
objvVideoLibQuantitySenateEN.UpdUserName = objRow[convVideoLibQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvVideoLibQuantitySenateDA: GetObjLst)", objException.Message));
}
objvVideoLibQuantitySenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvVideoLibQuantitySenateEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvVideoLibQuantitySenate(ref clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vVideoLibQuantitySenate where IdmicroteachCaseQuantitySenate = " + ""+ objvVideoLibQuantitySenateEN.IdmicroteachCaseQuantitySenate+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvVideoLibQuantitySenateEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objDT.Rows[0][convVideoLibQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvVideoLibQuantitySenateEN.FuncModuleId = objDT.Rows[0][convVideoLibQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvVideoLibQuantitySenateEN.FuncModuleName = objDT.Rows[0][convVideoLibQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvVideoLibQuantitySenateEN.IdMicroteachCase = objDT.Rows[0][convVideoLibQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoLibQuantitySenateEN.IdVideoLib = objDT.Rows[0][convVideoLibQuantitySenate.IdVideoLib].ToString().Trim(); //视频库流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoLibQuantitySenateEN.VideoLibID = objDT.Rows[0][convVideoLibQuantitySenate.VideoLibID].ToString().Trim(); //视频库ID(字段类型:char,字段长度:8,是否可空:False)
 objvVideoLibQuantitySenateEN.VideoLibName = objDT.Rows[0][convVideoLibQuantitySenate.VideoLibName].ToString().Trim(); //视频名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvVideoLibQuantitySenateEN.VideoLibTheme = objDT.Rows[0][convVideoLibQuantitySenate.VideoLibTheme].ToString().Trim(); //视频库主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoLibQuantitySenateEN.VideoLibTypeName = objDT.Rows[0][convVideoLibQuantitySenate.VideoLibTypeName].ToString().Trim(); //视频库类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvVideoLibQuantitySenateEN.VideoLibDate = objDT.Rows[0][convVideoLibQuantitySenate.VideoLibDate].ToString().Trim(); //视频资源日期(字段类型:char,字段长度:8,是否可空:True)
 objvVideoLibQuantitySenateEN.VideoLibTime = objDT.Rows[0][convVideoLibQuantitySenate.VideoLibTime].ToString().Trim(); //视频资源时间(字段类型:char,字段长度:6,是否可空:True)
 objvVideoLibQuantitySenateEN.VideoLibDateIn = objDT.Rows[0][convVideoLibQuantitySenate.VideoLibDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvVideoLibQuantitySenateEN.VideoLibTimeIn = objDT.Rows[0][convVideoLibQuantitySenate.VideoLibTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvVideoLibQuantitySenateEN.OwnerId = objDT.Rows[0][convVideoLibQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvVideoLibQuantitySenateEN.IdXzCollege = objDT.Rows[0][convVideoLibQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvVideoLibQuantitySenateEN.CollegeID = objDT.Rows[0][convVideoLibQuantitySenate.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvVideoLibQuantitySenateEN.CollegeName = objDT.Rows[0][convVideoLibQuantitySenate.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvVideoLibQuantitySenateEN.CollegeNameA = objDT.Rows[0][convVideoLibQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvVideoLibQuantitySenateEN.ViewCount = TransNullToInt(objDT.Rows[0][convVideoLibQuantitySenate.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvVideoLibQuantitySenateEN.DownloadNumber = TransNullToInt(objDT.Rows[0][convVideoLibQuantitySenate.DownloadNumber].ToString().Trim()); //下载数目(字段类型:int,字段长度:4,是否可空:True)
 objvVideoLibQuantitySenateEN.FileIntegration = TransNullToInt(objDT.Rows[0][convVideoLibQuantitySenate.FileIntegration].ToString().Trim()); //文件积分(字段类型:int,字段长度:4,是否可空:True)
 objvVideoLibQuantitySenateEN.LikeCount = TransNullToInt(objDT.Rows[0][convVideoLibQuantitySenate.LikeCount].ToString().Trim()); //资源喜欢数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvVideoLibQuantitySenateEN.CollectionCount = TransNullToInt(objDT.Rows[0][convVideoLibQuantitySenate.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvVideoLibQuantitySenateEN.CourseId = objDT.Rows[0][convVideoLibQuantitySenate.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvVideoLibQuantitySenateEN.CourseCode = objDT.Rows[0][convVideoLibQuantitySenate.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvVideoLibQuantitySenateEN.CourseName = objDT.Rows[0][convVideoLibQuantitySenate.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvVideoLibQuantitySenateEN.OwnerName = objDT.Rows[0][convVideoLibQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvVideoLibQuantitySenateEN.OwnerNameWithId = objDT.Rows[0][convVideoLibQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
 objvVideoLibQuantitySenateEN.IdAppraiseType = objDT.Rows[0][convVideoLibQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvVideoLibQuantitySenateEN.AppraiseTypeName = objDT.Rows[0][convVideoLibQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvVideoLibQuantitySenateEN.SenateTheme = objDT.Rows[0][convVideoLibQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoLibQuantitySenateEN.SenateContent = objDT.Rows[0][convVideoLibQuantitySenate.SenateContent].ToString().Trim(); //评价内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvVideoLibQuantitySenateEN.SenateTotalScore = TransNullToFloat(objDT.Rows[0][convVideoLibQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数(字段类型:float,字段长度:8,是否可空:False)
 objvVideoLibQuantitySenateEN.SenateDate = objDT.Rows[0][convVideoLibQuantitySenate.SenateDate].ToString().Trim(); //评价日期(字段类型:char,字段长度:8,是否可空:True)
 objvVideoLibQuantitySenateEN.SenateTime = objDT.Rows[0][convVideoLibQuantitySenate.SenateTime].ToString().Trim(); //评价时间(字段类型:char,字段长度:6,是否可空:True)
 objvVideoLibQuantitySenateEN.SenateIp = objDT.Rows[0][convVideoLibQuantitySenate.SenateIp].ToString().Trim(); //评议Ip(字段类型:varchar,字段长度:50,是否可空:True)
 objvVideoLibQuantitySenateEN.BrowseCount = TransNullToInt(objDT.Rows[0][convVideoLibQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvVideoLibQuantitySenateEN.IdSenateGaugeVersion = objDT.Rows[0][convVideoLibQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvVideoLibQuantitySenateEN.senateGaugeVersionID = objDT.Rows[0][convVideoLibQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvVideoLibQuantitySenateEN.senateGaugeVersionName = objDT.Rows[0][convVideoLibQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoLibQuantitySenateEN.senateGaugeVersionTtlScore = TransNullToFloat(objDT.Rows[0][convVideoLibQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvVideoLibQuantitySenateEN.UserId = objDT.Rows[0][convVideoLibQuantitySenate.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvVideoLibQuantitySenateEN.UserNameWithUserId = objDT.Rows[0][convVideoLibQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId(字段类型:varchar,字段长度:51,是否可空:False)
 objvVideoLibQuantitySenateEN.UserName = objDT.Rows[0][convVideoLibQuantitySenate.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvVideoLibQuantitySenateEN.UserKindId = objDT.Rows[0][convVideoLibQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id(字段类型:char,字段长度:2,是否可空:False)
 objvVideoLibQuantitySenateEN.UserKindName = objDT.Rows[0][convVideoLibQuantitySenate.UserKindName].ToString().Trim(); //用户类别名(字段类型:varchar,字段长度:30,是否可空:False)
 objvVideoLibQuantitySenateEN.UserTypeId = objDT.Rows[0][convVideoLibQuantitySenate.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvVideoLibQuantitySenateEN.UserTypeName = objDT.Rows[0][convVideoLibQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称(字段类型:varchar,字段长度:20,是否可空:True)
 objvVideoLibQuantitySenateEN.UpdUser = objDT.Rows[0][convVideoLibQuantitySenate.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvVideoLibQuantitySenateEN.Memo = objDT.Rows[0][convVideoLibQuantitySenate.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvVideoLibQuantitySenateEN.UpdUserName = objDT.Rows[0][convVideoLibQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName(字段类型:varchar,字段长度:20,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvVideoLibQuantitySenateDA: GetvVideoLibQuantitySenate)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdmicroteachCaseQuantitySenate">表关键字</param>
 /// <returns>表对象</returns>
public clsvVideoLibQuantitySenateEN GetObjByIdmicroteachCaseQuantitySenate(long lngIdmicroteachCaseQuantitySenate)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vVideoLibQuantitySenate where IdmicroteachCaseQuantitySenate = " + ""+ lngIdmicroteachCaseQuantitySenate+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN = new clsvVideoLibQuantitySenateEN();
try
{
 objvVideoLibQuantitySenateEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convVideoLibQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvVideoLibQuantitySenateEN.FuncModuleId = objRow[convVideoLibQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvVideoLibQuantitySenateEN.FuncModuleName = objRow[convVideoLibQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvVideoLibQuantitySenateEN.IdMicroteachCase = objRow[convVideoLibQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoLibQuantitySenateEN.IdVideoLib = objRow[convVideoLibQuantitySenate.IdVideoLib] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.IdVideoLib].ToString().Trim(); //视频库流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoLibQuantitySenateEN.VideoLibID = objRow[convVideoLibQuantitySenate.VideoLibID] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibID].ToString().Trim(); //视频库ID(字段类型:char,字段长度:8,是否可空:False)
 objvVideoLibQuantitySenateEN.VideoLibName = objRow[convVideoLibQuantitySenate.VideoLibName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibName].ToString().Trim(); //视频名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvVideoLibQuantitySenateEN.VideoLibTheme = objRow[convVideoLibQuantitySenate.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibTheme].ToString().Trim(); //视频库主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoLibQuantitySenateEN.VideoLibTypeName = objRow[convVideoLibQuantitySenate.VideoLibTypeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibTypeName].ToString().Trim(); //视频库类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvVideoLibQuantitySenateEN.VideoLibDate = objRow[convVideoLibQuantitySenate.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibDate].ToString().Trim(); //视频资源日期(字段类型:char,字段长度:8,是否可空:True)
 objvVideoLibQuantitySenateEN.VideoLibTime = objRow[convVideoLibQuantitySenate.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibTime].ToString().Trim(); //视频资源时间(字段类型:char,字段长度:6,是否可空:True)
 objvVideoLibQuantitySenateEN.VideoLibDateIn = objRow[convVideoLibQuantitySenate.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvVideoLibQuantitySenateEN.VideoLibTimeIn = objRow[convVideoLibQuantitySenate.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvVideoLibQuantitySenateEN.OwnerId = objRow[convVideoLibQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvVideoLibQuantitySenateEN.IdXzCollege = objRow[convVideoLibQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvVideoLibQuantitySenateEN.CollegeID = objRow[convVideoLibQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvVideoLibQuantitySenateEN.CollegeName = objRow[convVideoLibQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvVideoLibQuantitySenateEN.CollegeNameA = objRow[convVideoLibQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvVideoLibQuantitySenateEN.ViewCount = objRow[convVideoLibQuantitySenate.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibQuantitySenate.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvVideoLibQuantitySenateEN.DownloadNumber = objRow[convVideoLibQuantitySenate.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibQuantitySenate.DownloadNumber].ToString().Trim()); //下载数目(字段类型:int,字段长度:4,是否可空:True)
 objvVideoLibQuantitySenateEN.FileIntegration = objRow[convVideoLibQuantitySenate.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibQuantitySenate.FileIntegration].ToString().Trim()); //文件积分(字段类型:int,字段长度:4,是否可空:True)
 objvVideoLibQuantitySenateEN.LikeCount = objRow[convVideoLibQuantitySenate.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibQuantitySenate.LikeCount].ToString().Trim()); //资源喜欢数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvVideoLibQuantitySenateEN.CollectionCount = objRow[convVideoLibQuantitySenate.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibQuantitySenate.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvVideoLibQuantitySenateEN.CourseId = objRow[convVideoLibQuantitySenate.CourseId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvVideoLibQuantitySenateEN.CourseCode = objRow[convVideoLibQuantitySenate.CourseCode] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvVideoLibQuantitySenateEN.CourseName = objRow[convVideoLibQuantitySenate.CourseName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvVideoLibQuantitySenateEN.OwnerName = objRow[convVideoLibQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvVideoLibQuantitySenateEN.OwnerNameWithId = objRow[convVideoLibQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
 objvVideoLibQuantitySenateEN.IdAppraiseType = objRow[convVideoLibQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvVideoLibQuantitySenateEN.AppraiseTypeName = objRow[convVideoLibQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvVideoLibQuantitySenateEN.SenateTheme = objRow[convVideoLibQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoLibQuantitySenateEN.SenateContent = objRow[convVideoLibQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.SenateContent].ToString().Trim(); //评价内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvVideoLibQuantitySenateEN.SenateTotalScore = Single.Parse(objRow[convVideoLibQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数(字段类型:float,字段长度:8,是否可空:False)
 objvVideoLibQuantitySenateEN.SenateDate = objRow[convVideoLibQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.SenateDate].ToString().Trim(); //评价日期(字段类型:char,字段长度:8,是否可空:True)
 objvVideoLibQuantitySenateEN.SenateTime = objRow[convVideoLibQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.SenateTime].ToString().Trim(); //评价时间(字段类型:char,字段长度:6,是否可空:True)
 objvVideoLibQuantitySenateEN.SenateIp = objRow[convVideoLibQuantitySenate.SenateIp].ToString().Trim(); //评议Ip(字段类型:varchar,字段长度:50,是否可空:True)
 objvVideoLibQuantitySenateEN.BrowseCount = objRow[convVideoLibQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvVideoLibQuantitySenateEN.IdSenateGaugeVersion = objRow[convVideoLibQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvVideoLibQuantitySenateEN.senateGaugeVersionID = objRow[convVideoLibQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvVideoLibQuantitySenateEN.senateGaugeVersionName = objRow[convVideoLibQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoLibQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convVideoLibQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convVideoLibQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvVideoLibQuantitySenateEN.UserId = objRow[convVideoLibQuantitySenate.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvVideoLibQuantitySenateEN.UserNameWithUserId = objRow[convVideoLibQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId(字段类型:varchar,字段长度:51,是否可空:False)
 objvVideoLibQuantitySenateEN.UserName = objRow[convVideoLibQuantitySenate.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvVideoLibQuantitySenateEN.UserKindId = objRow[convVideoLibQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id(字段类型:char,字段长度:2,是否可空:False)
 objvVideoLibQuantitySenateEN.UserKindName = objRow[convVideoLibQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UserKindName].ToString().Trim(); //用户类别名(字段类型:varchar,字段长度:30,是否可空:False)
 objvVideoLibQuantitySenateEN.UserTypeId = objRow[convVideoLibQuantitySenate.UserTypeId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvVideoLibQuantitySenateEN.UserTypeName = objRow[convVideoLibQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称(字段类型:varchar,字段长度:20,是否可空:True)
 objvVideoLibQuantitySenateEN.UpdUser = objRow[convVideoLibQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvVideoLibQuantitySenateEN.Memo = objRow[convVideoLibQuantitySenate.Memo] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvVideoLibQuantitySenateEN.UpdUserName = objRow[convVideoLibQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName(字段类型:varchar,字段长度:20,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvVideoLibQuantitySenateDA: GetObjByIdmicroteachCaseQuantitySenate)", objException.Message));
}
return objvVideoLibQuantitySenateEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvVideoLibQuantitySenateEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvVideoLibQuantitySenateDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vVideoLibQuantitySenate where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN = new clsvVideoLibQuantitySenateEN()
{
IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convVideoLibQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()), //微格量化评价流水号
FuncModuleId = objRow[convVideoLibQuantitySenate.FuncModuleId].ToString().Trim(), //功能模块Id
FuncModuleName = objRow[convVideoLibQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.FuncModuleName].ToString().Trim(), //功能模块名称
IdMicroteachCase = objRow[convVideoLibQuantitySenate.IdMicroteachCase].ToString().Trim(), //微格教学案例流水号
IdVideoLib = objRow[convVideoLibQuantitySenate.IdVideoLib] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.IdVideoLib].ToString().Trim(), //视频库流水号
VideoLibID = objRow[convVideoLibQuantitySenate.VideoLibID] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibID].ToString().Trim(), //视频库ID
VideoLibName = objRow[convVideoLibQuantitySenate.VideoLibName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibName].ToString().Trim(), //视频名称
VideoLibTheme = objRow[convVideoLibQuantitySenate.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibTheme].ToString().Trim(), //视频库主题词
VideoLibTypeName = objRow[convVideoLibQuantitySenate.VideoLibTypeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibTypeName].ToString().Trim(), //视频库类型名称
VideoLibDate = objRow[convVideoLibQuantitySenate.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibDate].ToString().Trim(), //视频资源日期
VideoLibTime = objRow[convVideoLibQuantitySenate.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibTime].ToString().Trim(), //视频资源时间
VideoLibDateIn = objRow[convVideoLibQuantitySenate.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibDateIn].ToString().Trim(), //案例入库日期
VideoLibTimeIn = objRow[convVideoLibQuantitySenate.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibTimeIn].ToString().Trim(), //案例入库时间
OwnerId = objRow[convVideoLibQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.OwnerId].ToString().Trim(), //拥有者Id
IdXzCollege = objRow[convVideoLibQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.IdXzCollege].ToString().Trim(), //学院流水号
CollegeID = objRow[convVideoLibQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CollegeID].ToString().Trim(), //学院ID
CollegeName = objRow[convVideoLibQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CollegeName].ToString().Trim(), //学院名称
CollegeNameA = objRow[convVideoLibQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CollegeNameA].ToString().Trim(), //学院名称简写
ViewCount = objRow[convVideoLibQuantitySenate.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLibQuantitySenate.ViewCount].ToString().Trim()), //浏览量
DownloadNumber = objRow[convVideoLibQuantitySenate.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLibQuantitySenate.DownloadNumber].ToString().Trim()), //下载数目
FileIntegration = objRow[convVideoLibQuantitySenate.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLibQuantitySenate.FileIntegration].ToString().Trim()), //文件积分
LikeCount = objRow[convVideoLibQuantitySenate.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoLibQuantitySenate.LikeCount].ToString().Trim()), //资源喜欢数量
CollectionCount = objRow[convVideoLibQuantitySenate.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoLibQuantitySenate.CollectionCount].ToString().Trim()), //收藏数量
CourseId = objRow[convVideoLibQuantitySenate.CourseId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CourseId].ToString().Trim(), //课程Id
CourseCode = objRow[convVideoLibQuantitySenate.CourseCode] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CourseCode].ToString().Trim(), //课程代码
CourseName = objRow[convVideoLibQuantitySenate.CourseName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CourseName].ToString().Trim(), //课程名称
OwnerName = objRow[convVideoLibQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.OwnerName].ToString().Trim(), //拥有者姓名
OwnerNameWithId = objRow[convVideoLibQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.OwnerNameWithId].ToString().Trim(), //拥有者名称附Id
IdAppraiseType = objRow[convVideoLibQuantitySenate.IdAppraiseType].ToString().Trim(), //评议类型流水号
AppraiseTypeName = objRow[convVideoLibQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.AppraiseTypeName].ToString().Trim(), //评议类型名称
SenateTheme = objRow[convVideoLibQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.SenateTheme].ToString().Trim(), //量化评价主题
SenateContent = objRow[convVideoLibQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.SenateContent].ToString().Trim(), //评价内容
SenateTotalScore = TransNullToFloat(objRow[convVideoLibQuantitySenate.SenateTotalScore].ToString().Trim()), //评价分数
SenateDate = objRow[convVideoLibQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.SenateDate].ToString().Trim(), //评价日期
SenateTime = objRow[convVideoLibQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.SenateTime].ToString().Trim(), //评价时间
SenateIp = objRow[convVideoLibQuantitySenate.SenateIp].ToString().Trim(), //评议Ip
BrowseCount = objRow[convVideoLibQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLibQuantitySenate.BrowseCount].ToString().Trim()), //浏览次数
IdSenateGaugeVersion = objRow[convVideoLibQuantitySenate.IdSenateGaugeVersion].ToString().Trim(), //评价量表版本流水号
senateGaugeVersionID = objRow[convVideoLibQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.senateGaugeVersionID].ToString().Trim(), //评价量表版本ID
senateGaugeVersionName = objRow[convVideoLibQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.senateGaugeVersionName].ToString().Trim(), //评价量表版本名称
senateGaugeVersionTtlScore = objRow[convVideoLibQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convVideoLibQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()), //评价量表版本总分
UserId = objRow[convVideoLibQuantitySenate.UserId].ToString().Trim(), //用户ID
UserNameWithUserId = objRow[convVideoLibQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UserNameWithUserId].ToString().Trim(), //UserNameWithUserId
UserName = objRow[convVideoLibQuantitySenate.UserName].ToString().Trim(), //用户名
UserKindId = objRow[convVideoLibQuantitySenate.UserKindId].ToString().Trim(), //用户类别Id
UserKindName = objRow[convVideoLibQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UserKindName].ToString().Trim(), //用户类别名
UserTypeId = objRow[convVideoLibQuantitySenate.UserTypeId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UserTypeId].ToString().Trim(), //用户类型Id
UserTypeName = objRow[convVideoLibQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UserTypeName].ToString().Trim(), //用户类型名称
UpdUser = objRow[convVideoLibQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convVideoLibQuantitySenate.Memo] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.Memo].ToString().Trim(), //备注
UpdUserName = objRow[convVideoLibQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UpdUserName].ToString().Trim() //UpdUserName
};
objvVideoLibQuantitySenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvVideoLibQuantitySenateEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvVideoLibQuantitySenateDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvVideoLibQuantitySenateEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN = new clsvVideoLibQuantitySenateEN();
try
{
objvVideoLibQuantitySenateEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convVideoLibQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvVideoLibQuantitySenateEN.FuncModuleId = objRow[convVideoLibQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoLibQuantitySenateEN.FuncModuleName = objRow[convVideoLibQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoLibQuantitySenateEN.IdMicroteachCase = objRow[convVideoLibQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoLibQuantitySenateEN.IdVideoLib = objRow[convVideoLibQuantitySenate.IdVideoLib] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.IdVideoLib].ToString().Trim(); //视频库流水号
objvVideoLibQuantitySenateEN.VideoLibID = objRow[convVideoLibQuantitySenate.VideoLibID] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLibQuantitySenateEN.VideoLibName = objRow[convVideoLibQuantitySenate.VideoLibName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibName].ToString().Trim(); //视频名称
objvVideoLibQuantitySenateEN.VideoLibTheme = objRow[convVideoLibQuantitySenate.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibTheme].ToString().Trim(); //视频库主题词
objvVideoLibQuantitySenateEN.VideoLibTypeName = objRow[convVideoLibQuantitySenate.VideoLibTypeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibTypeName].ToString().Trim(); //视频库类型名称
objvVideoLibQuantitySenateEN.VideoLibDate = objRow[convVideoLibQuantitySenate.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibDate].ToString().Trim(); //视频资源日期
objvVideoLibQuantitySenateEN.VideoLibTime = objRow[convVideoLibQuantitySenate.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibTime].ToString().Trim(); //视频资源时间
objvVideoLibQuantitySenateEN.VideoLibDateIn = objRow[convVideoLibQuantitySenate.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibDateIn].ToString().Trim(); //案例入库日期
objvVideoLibQuantitySenateEN.VideoLibTimeIn = objRow[convVideoLibQuantitySenate.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objvVideoLibQuantitySenateEN.OwnerId = objRow[convVideoLibQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvVideoLibQuantitySenateEN.IdXzCollege = objRow[convVideoLibQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLibQuantitySenateEN.CollegeID = objRow[convVideoLibQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvVideoLibQuantitySenateEN.CollegeName = objRow[convVideoLibQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvVideoLibQuantitySenateEN.CollegeNameA = objRow[convVideoLibQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoLibQuantitySenateEN.ViewCount = objRow[convVideoLibQuantitySenate.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLibQuantitySenate.ViewCount].ToString().Trim()); //浏览量
objvVideoLibQuantitySenateEN.DownloadNumber = objRow[convVideoLibQuantitySenate.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLibQuantitySenate.DownloadNumber].ToString().Trim()); //下载数目
objvVideoLibQuantitySenateEN.FileIntegration = objRow[convVideoLibQuantitySenate.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLibQuantitySenate.FileIntegration].ToString().Trim()); //文件积分
objvVideoLibQuantitySenateEN.LikeCount = objRow[convVideoLibQuantitySenate.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoLibQuantitySenate.LikeCount].ToString().Trim()); //资源喜欢数量
objvVideoLibQuantitySenateEN.CollectionCount = objRow[convVideoLibQuantitySenate.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoLibQuantitySenate.CollectionCount].ToString().Trim()); //收藏数量
objvVideoLibQuantitySenateEN.CourseId = objRow[convVideoLibQuantitySenate.CourseId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CourseId].ToString().Trim(); //课程Id
objvVideoLibQuantitySenateEN.CourseCode = objRow[convVideoLibQuantitySenate.CourseCode] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CourseCode].ToString().Trim(); //课程代码
objvVideoLibQuantitySenateEN.CourseName = objRow[convVideoLibQuantitySenate.CourseName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CourseName].ToString().Trim(); //课程名称
objvVideoLibQuantitySenateEN.OwnerName = objRow[convVideoLibQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvVideoLibQuantitySenateEN.OwnerNameWithId = objRow[convVideoLibQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvVideoLibQuantitySenateEN.IdAppraiseType = objRow[convVideoLibQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvVideoLibQuantitySenateEN.AppraiseTypeName = objRow[convVideoLibQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvVideoLibQuantitySenateEN.SenateTheme = objRow[convVideoLibQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvVideoLibQuantitySenateEN.SenateContent = objRow[convVideoLibQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvVideoLibQuantitySenateEN.SenateTotalScore = TransNullToFloat(objRow[convVideoLibQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvVideoLibQuantitySenateEN.SenateDate = objRow[convVideoLibQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvVideoLibQuantitySenateEN.SenateTime = objRow[convVideoLibQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvVideoLibQuantitySenateEN.SenateIp = objRow[convVideoLibQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvVideoLibQuantitySenateEN.BrowseCount = objRow[convVideoLibQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLibQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvVideoLibQuantitySenateEN.IdSenateGaugeVersion = objRow[convVideoLibQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvVideoLibQuantitySenateEN.senateGaugeVersionID = objRow[convVideoLibQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoLibQuantitySenateEN.senateGaugeVersionName = objRow[convVideoLibQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoLibQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convVideoLibQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convVideoLibQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoLibQuantitySenateEN.UserId = objRow[convVideoLibQuantitySenate.UserId].ToString().Trim(); //用户ID
objvVideoLibQuantitySenateEN.UserNameWithUserId = objRow[convVideoLibQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvVideoLibQuantitySenateEN.UserName = objRow[convVideoLibQuantitySenate.UserName].ToString().Trim(); //用户名
objvVideoLibQuantitySenateEN.UserKindId = objRow[convVideoLibQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvVideoLibQuantitySenateEN.UserKindName = objRow[convVideoLibQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvVideoLibQuantitySenateEN.UserTypeId = objRow[convVideoLibQuantitySenate.UserTypeId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UserTypeId].ToString().Trim(); //用户类型Id
objvVideoLibQuantitySenateEN.UserTypeName = objRow[convVideoLibQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
objvVideoLibQuantitySenateEN.UpdUser = objRow[convVideoLibQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvVideoLibQuantitySenateEN.Memo = objRow[convVideoLibQuantitySenate.Memo] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.Memo].ToString().Trim(); //备注
objvVideoLibQuantitySenateEN.UpdUserName = objRow[convVideoLibQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvVideoLibQuantitySenateDA: GetObjByDataRowvVideoLibQuantitySenate)", objException.Message));
}
objvVideoLibQuantitySenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvVideoLibQuantitySenateEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvVideoLibQuantitySenateEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN = new clsvVideoLibQuantitySenateEN();
try
{
objvVideoLibQuantitySenateEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convVideoLibQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvVideoLibQuantitySenateEN.FuncModuleId = objRow[convVideoLibQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoLibQuantitySenateEN.FuncModuleName = objRow[convVideoLibQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoLibQuantitySenateEN.IdMicroteachCase = objRow[convVideoLibQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoLibQuantitySenateEN.IdVideoLib = objRow[convVideoLibQuantitySenate.IdVideoLib] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.IdVideoLib].ToString().Trim(); //视频库流水号
objvVideoLibQuantitySenateEN.VideoLibID = objRow[convVideoLibQuantitySenate.VideoLibID] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLibQuantitySenateEN.VideoLibName = objRow[convVideoLibQuantitySenate.VideoLibName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibName].ToString().Trim(); //视频名称
objvVideoLibQuantitySenateEN.VideoLibTheme = objRow[convVideoLibQuantitySenate.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibTheme].ToString().Trim(); //视频库主题词
objvVideoLibQuantitySenateEN.VideoLibTypeName = objRow[convVideoLibQuantitySenate.VideoLibTypeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibTypeName].ToString().Trim(); //视频库类型名称
objvVideoLibQuantitySenateEN.VideoLibDate = objRow[convVideoLibQuantitySenate.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibDate].ToString().Trim(); //视频资源日期
objvVideoLibQuantitySenateEN.VideoLibTime = objRow[convVideoLibQuantitySenate.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibTime].ToString().Trim(); //视频资源时间
objvVideoLibQuantitySenateEN.VideoLibDateIn = objRow[convVideoLibQuantitySenate.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibDateIn].ToString().Trim(); //案例入库日期
objvVideoLibQuantitySenateEN.VideoLibTimeIn = objRow[convVideoLibQuantitySenate.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objvVideoLibQuantitySenateEN.OwnerId = objRow[convVideoLibQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvVideoLibQuantitySenateEN.IdXzCollege = objRow[convVideoLibQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLibQuantitySenateEN.CollegeID = objRow[convVideoLibQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvVideoLibQuantitySenateEN.CollegeName = objRow[convVideoLibQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvVideoLibQuantitySenateEN.CollegeNameA = objRow[convVideoLibQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoLibQuantitySenateEN.ViewCount = objRow[convVideoLibQuantitySenate.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLibQuantitySenate.ViewCount].ToString().Trim()); //浏览量
objvVideoLibQuantitySenateEN.DownloadNumber = objRow[convVideoLibQuantitySenate.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLibQuantitySenate.DownloadNumber].ToString().Trim()); //下载数目
objvVideoLibQuantitySenateEN.FileIntegration = objRow[convVideoLibQuantitySenate.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLibQuantitySenate.FileIntegration].ToString().Trim()); //文件积分
objvVideoLibQuantitySenateEN.LikeCount = objRow[convVideoLibQuantitySenate.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoLibQuantitySenate.LikeCount].ToString().Trim()); //资源喜欢数量
objvVideoLibQuantitySenateEN.CollectionCount = objRow[convVideoLibQuantitySenate.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoLibQuantitySenate.CollectionCount].ToString().Trim()); //收藏数量
objvVideoLibQuantitySenateEN.CourseId = objRow[convVideoLibQuantitySenate.CourseId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CourseId].ToString().Trim(); //课程Id
objvVideoLibQuantitySenateEN.CourseCode = objRow[convVideoLibQuantitySenate.CourseCode] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CourseCode].ToString().Trim(); //课程代码
objvVideoLibQuantitySenateEN.CourseName = objRow[convVideoLibQuantitySenate.CourseName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.CourseName].ToString().Trim(); //课程名称
objvVideoLibQuantitySenateEN.OwnerName = objRow[convVideoLibQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvVideoLibQuantitySenateEN.OwnerNameWithId = objRow[convVideoLibQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvVideoLibQuantitySenateEN.IdAppraiseType = objRow[convVideoLibQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvVideoLibQuantitySenateEN.AppraiseTypeName = objRow[convVideoLibQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvVideoLibQuantitySenateEN.SenateTheme = objRow[convVideoLibQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvVideoLibQuantitySenateEN.SenateContent = objRow[convVideoLibQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvVideoLibQuantitySenateEN.SenateTotalScore = TransNullToFloat(objRow[convVideoLibQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvVideoLibQuantitySenateEN.SenateDate = objRow[convVideoLibQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvVideoLibQuantitySenateEN.SenateTime = objRow[convVideoLibQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvVideoLibQuantitySenateEN.SenateIp = objRow[convVideoLibQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvVideoLibQuantitySenateEN.BrowseCount = objRow[convVideoLibQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLibQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvVideoLibQuantitySenateEN.IdSenateGaugeVersion = objRow[convVideoLibQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvVideoLibQuantitySenateEN.senateGaugeVersionID = objRow[convVideoLibQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoLibQuantitySenateEN.senateGaugeVersionName = objRow[convVideoLibQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoLibQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convVideoLibQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convVideoLibQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoLibQuantitySenateEN.UserId = objRow[convVideoLibQuantitySenate.UserId].ToString().Trim(); //用户ID
objvVideoLibQuantitySenateEN.UserNameWithUserId = objRow[convVideoLibQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvVideoLibQuantitySenateEN.UserName = objRow[convVideoLibQuantitySenate.UserName].ToString().Trim(); //用户名
objvVideoLibQuantitySenateEN.UserKindId = objRow[convVideoLibQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvVideoLibQuantitySenateEN.UserKindName = objRow[convVideoLibQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvVideoLibQuantitySenateEN.UserTypeId = objRow[convVideoLibQuantitySenate.UserTypeId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UserTypeId].ToString().Trim(); //用户类型Id
objvVideoLibQuantitySenateEN.UserTypeName = objRow[convVideoLibQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
objvVideoLibQuantitySenateEN.UpdUser = objRow[convVideoLibQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvVideoLibQuantitySenateEN.Memo = objRow[convVideoLibQuantitySenate.Memo] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.Memo].ToString().Trim(); //备注
objvVideoLibQuantitySenateEN.UpdUserName = objRow[convVideoLibQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvVideoLibQuantitySenateDA: GetObjByDataRow)", objException.Message));
}
objvVideoLibQuantitySenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvVideoLibQuantitySenateEN;
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
objSQL = clsvVideoLibQuantitySenateDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvVideoLibQuantitySenateEN._CurrTabName, convVideoLibQuantitySenate.IdmicroteachCaseQuantitySenate, 8, "");
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
objSQL = clsvVideoLibQuantitySenateDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvVideoLibQuantitySenateEN._CurrTabName, convVideoLibQuantitySenate.IdmicroteachCaseQuantitySenate, 8, strPrefix);
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
 objSQL = clsvVideoLibQuantitySenateDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdmicroteachCaseQuantitySenate from vVideoLibQuantitySenate where " + strCondition;
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
 objSQL = clsvVideoLibQuantitySenateDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdmicroteachCaseQuantitySenate from vVideoLibQuantitySenate where " + strCondition;
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
 objSQL = clsvVideoLibQuantitySenateDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vVideoLibQuantitySenate", "IdmicroteachCaseQuantitySenate = " + ""+ lngIdmicroteachCaseQuantitySenate+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvVideoLibQuantitySenateDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibQuantitySenateDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vVideoLibQuantitySenate", strCondition))
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
objSQL = clsvVideoLibQuantitySenateDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vVideoLibQuantitySenate");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateENS">源对象</param>
 /// <param name = "objvVideoLibQuantitySenateENT">目标对象</param>
public void CopyTo(clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateENS, clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateENT)
{
objvVideoLibQuantitySenateENT.IdmicroteachCaseQuantitySenate = objvVideoLibQuantitySenateENS.IdmicroteachCaseQuantitySenate; //微格量化评价流水号
objvVideoLibQuantitySenateENT.FuncModuleId = objvVideoLibQuantitySenateENS.FuncModuleId; //功能模块Id
objvVideoLibQuantitySenateENT.FuncModuleName = objvVideoLibQuantitySenateENS.FuncModuleName; //功能模块名称
objvVideoLibQuantitySenateENT.IdMicroteachCase = objvVideoLibQuantitySenateENS.IdMicroteachCase; //微格教学案例流水号
objvVideoLibQuantitySenateENT.IdVideoLib = objvVideoLibQuantitySenateENS.IdVideoLib; //视频库流水号
objvVideoLibQuantitySenateENT.VideoLibID = objvVideoLibQuantitySenateENS.VideoLibID; //视频库ID
objvVideoLibQuantitySenateENT.VideoLibName = objvVideoLibQuantitySenateENS.VideoLibName; //视频名称
objvVideoLibQuantitySenateENT.VideoLibTheme = objvVideoLibQuantitySenateENS.VideoLibTheme; //视频库主题词
objvVideoLibQuantitySenateENT.VideoLibTypeName = objvVideoLibQuantitySenateENS.VideoLibTypeName; //视频库类型名称
objvVideoLibQuantitySenateENT.VideoLibDate = objvVideoLibQuantitySenateENS.VideoLibDate; //视频资源日期
objvVideoLibQuantitySenateENT.VideoLibTime = objvVideoLibQuantitySenateENS.VideoLibTime; //视频资源时间
objvVideoLibQuantitySenateENT.VideoLibDateIn = objvVideoLibQuantitySenateENS.VideoLibDateIn; //案例入库日期
objvVideoLibQuantitySenateENT.VideoLibTimeIn = objvVideoLibQuantitySenateENS.VideoLibTimeIn; //案例入库时间
objvVideoLibQuantitySenateENT.OwnerId = objvVideoLibQuantitySenateENS.OwnerId; //拥有者Id
objvVideoLibQuantitySenateENT.IdXzCollege = objvVideoLibQuantitySenateENS.IdXzCollege; //学院流水号
objvVideoLibQuantitySenateENT.CollegeID = objvVideoLibQuantitySenateENS.CollegeID; //学院ID
objvVideoLibQuantitySenateENT.CollegeName = objvVideoLibQuantitySenateENS.CollegeName; //学院名称
objvVideoLibQuantitySenateENT.CollegeNameA = objvVideoLibQuantitySenateENS.CollegeNameA; //学院名称简写
objvVideoLibQuantitySenateENT.ViewCount = objvVideoLibQuantitySenateENS.ViewCount; //浏览量
objvVideoLibQuantitySenateENT.DownloadNumber = objvVideoLibQuantitySenateENS.DownloadNumber; //下载数目
objvVideoLibQuantitySenateENT.FileIntegration = objvVideoLibQuantitySenateENS.FileIntegration; //文件积分
objvVideoLibQuantitySenateENT.LikeCount = objvVideoLibQuantitySenateENS.LikeCount; //资源喜欢数量
objvVideoLibQuantitySenateENT.CollectionCount = objvVideoLibQuantitySenateENS.CollectionCount; //收藏数量
objvVideoLibQuantitySenateENT.CourseId = objvVideoLibQuantitySenateENS.CourseId; //课程Id
objvVideoLibQuantitySenateENT.CourseCode = objvVideoLibQuantitySenateENS.CourseCode; //课程代码
objvVideoLibQuantitySenateENT.CourseName = objvVideoLibQuantitySenateENS.CourseName; //课程名称
objvVideoLibQuantitySenateENT.OwnerName = objvVideoLibQuantitySenateENS.OwnerName; //拥有者姓名
objvVideoLibQuantitySenateENT.OwnerNameWithId = objvVideoLibQuantitySenateENS.OwnerNameWithId; //拥有者名称附Id
objvVideoLibQuantitySenateENT.IdAppraiseType = objvVideoLibQuantitySenateENS.IdAppraiseType; //评议类型流水号
objvVideoLibQuantitySenateENT.AppraiseTypeName = objvVideoLibQuantitySenateENS.AppraiseTypeName; //评议类型名称
objvVideoLibQuantitySenateENT.SenateTheme = objvVideoLibQuantitySenateENS.SenateTheme; //量化评价主题
objvVideoLibQuantitySenateENT.SenateContent = objvVideoLibQuantitySenateENS.SenateContent; //评价内容
objvVideoLibQuantitySenateENT.SenateTotalScore = objvVideoLibQuantitySenateENS.SenateTotalScore; //评价分数
objvVideoLibQuantitySenateENT.SenateDate = objvVideoLibQuantitySenateENS.SenateDate; //评价日期
objvVideoLibQuantitySenateENT.SenateTime = objvVideoLibQuantitySenateENS.SenateTime; //评价时间
objvVideoLibQuantitySenateENT.SenateIp = objvVideoLibQuantitySenateENS.SenateIp; //评议Ip
objvVideoLibQuantitySenateENT.BrowseCount = objvVideoLibQuantitySenateENS.BrowseCount; //浏览次数
objvVideoLibQuantitySenateENT.IdSenateGaugeVersion = objvVideoLibQuantitySenateENS.IdSenateGaugeVersion; //评价量表版本流水号
objvVideoLibQuantitySenateENT.senateGaugeVersionID = objvVideoLibQuantitySenateENS.senateGaugeVersionID; //评价量表版本ID
objvVideoLibQuantitySenateENT.senateGaugeVersionName = objvVideoLibQuantitySenateENS.senateGaugeVersionName; //评价量表版本名称
objvVideoLibQuantitySenateENT.senateGaugeVersionTtlScore = objvVideoLibQuantitySenateENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvVideoLibQuantitySenateENT.UserId = objvVideoLibQuantitySenateENS.UserId; //用户ID
objvVideoLibQuantitySenateENT.UserNameWithUserId = objvVideoLibQuantitySenateENS.UserNameWithUserId; //UserNameWithUserId
objvVideoLibQuantitySenateENT.UserName = objvVideoLibQuantitySenateENS.UserName; //用户名
objvVideoLibQuantitySenateENT.UserKindId = objvVideoLibQuantitySenateENS.UserKindId; //用户类别Id
objvVideoLibQuantitySenateENT.UserKindName = objvVideoLibQuantitySenateENS.UserKindName; //用户类别名
objvVideoLibQuantitySenateENT.UserTypeId = objvVideoLibQuantitySenateENS.UserTypeId; //用户类型Id
objvVideoLibQuantitySenateENT.UserTypeName = objvVideoLibQuantitySenateENS.UserTypeName; //用户类型名称
objvVideoLibQuantitySenateENT.UpdUser = objvVideoLibQuantitySenateENS.UpdUser; //修改人
objvVideoLibQuantitySenateENT.Memo = objvVideoLibQuantitySenateENS.Memo; //备注
objvVideoLibQuantitySenateENT.UpdUserName = objvVideoLibQuantitySenateENS.UpdUserName; //UpdUserName
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvVideoLibQuantitySenateEN objvVideoLibQuantitySenateEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvVideoLibQuantitySenateEN.FuncModuleId, 4, convVideoLibQuantitySenate.FuncModuleId);
clsCheckSql.CheckFieldLen(objvVideoLibQuantitySenateEN.FuncModuleName, 30, convVideoLibQuantitySenate.FuncModuleName);
clsCheckSql.CheckFieldLen(objvVideoLibQuantitySenateEN.IdMicroteachCase, 8, convVideoLibQuantitySenate.IdMicroteachCase);
clsCheckSql.CheckFieldLen(objvVideoLibQuantitySenateEN.IdVideoLib, 8, convVideoLibQuantitySenate.IdVideoLib);
clsCheckSql.CheckFieldLen(objvVideoLibQuantitySenateEN.VideoLibID, 8, convVideoLibQuantitySenate.VideoLibID);
clsCheckSql.CheckFieldLen(objvVideoLibQuantitySenateEN.VideoLibName, 100, convVideoLibQuantitySenate.VideoLibName);
clsCheckSql.CheckFieldLen(objvVideoLibQuantitySenateEN.VideoLibTheme, 200, convVideoLibQuantitySenate.VideoLibTheme);
clsCheckSql.CheckFieldLen(objvVideoLibQuantitySenateEN.VideoLibTypeName, 30, convVideoLibQuantitySenate.VideoLibTypeName);
clsCheckSql.CheckFieldLen(objvVideoLibQuantitySenateEN.VideoLibDate, 8, convVideoLibQuantitySenate.VideoLibDate);
clsCheckSql.CheckFieldLen(objvVideoLibQuantitySenateEN.VideoLibTime, 6, convVideoLibQuantitySenate.VideoLibTime);
clsCheckSql.CheckFieldLen(objvVideoLibQuantitySenateEN.VideoLibDateIn, 8, convVideoLibQuantitySenate.VideoLibDateIn);
clsCheckSql.CheckFieldLen(objvVideoLibQuantitySenateEN.VideoLibTimeIn, 6, convVideoLibQuantitySenate.VideoLibTimeIn);
clsCheckSql.CheckFieldLen(objvVideoLibQuantitySenateEN.OwnerId, 20, convVideoLibQuantitySenate.OwnerId);
clsCheckSql.CheckFieldLen(objvVideoLibQuantitySenateEN.IdXzCollege, 4, convVideoLibQuantitySenate.IdXzCollege);
clsCheckSql.CheckFieldLen(objvVideoLibQuantitySenateEN.CollegeID, 4, convVideoLibQuantitySenate.CollegeID);
clsCheckSql.CheckFieldLen(objvVideoLibQuantitySenateEN.CollegeName, 100, convVideoLibQuantitySenate.CollegeName);
clsCheckSql.CheckFieldLen(objvVideoLibQuantitySenateEN.CollegeNameA, 12, convVideoLibQuantitySenate.CollegeNameA);
clsCheckSql.CheckFieldLen(objvVideoLibQuantitySenateEN.CourseId, 8, convVideoLibQuantitySenate.CourseId);
clsCheckSql.CheckFieldLen(objvVideoLibQuantitySenateEN.CourseCode, 20, convVideoLibQuantitySenate.CourseCode);
clsCheckSql.CheckFieldLen(objvVideoLibQuantitySenateEN.CourseName, 100, convVideoLibQuantitySenate.CourseName);
clsCheckSql.CheckFieldLen(objvVideoLibQuantitySenateEN.OwnerName, 30, convVideoLibQuantitySenate.OwnerName);
clsCheckSql.CheckFieldLen(objvVideoLibQuantitySenateEN.OwnerNameWithId, 51, convVideoLibQuantitySenate.OwnerNameWithId);
clsCheckSql.CheckFieldLen(objvVideoLibQuantitySenateEN.IdAppraiseType, 4, convVideoLibQuantitySenate.IdAppraiseType);
clsCheckSql.CheckFieldLen(objvVideoLibQuantitySenateEN.AppraiseTypeName, 50, convVideoLibQuantitySenate.AppraiseTypeName);
clsCheckSql.CheckFieldLen(objvVideoLibQuantitySenateEN.SenateTheme, 200, convVideoLibQuantitySenate.SenateTheme);
clsCheckSql.CheckFieldLen(objvVideoLibQuantitySenateEN.SenateContent, 2000, convVideoLibQuantitySenate.SenateContent);
clsCheckSql.CheckFieldLen(objvVideoLibQuantitySenateEN.SenateDate, 8, convVideoLibQuantitySenate.SenateDate);
clsCheckSql.CheckFieldLen(objvVideoLibQuantitySenateEN.SenateTime, 6, convVideoLibQuantitySenate.SenateTime);
clsCheckSql.CheckFieldLen(objvVideoLibQuantitySenateEN.SenateIp, 50, convVideoLibQuantitySenate.SenateIp);
clsCheckSql.CheckFieldLen(objvVideoLibQuantitySenateEN.IdSenateGaugeVersion, 4, convVideoLibQuantitySenate.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objvVideoLibQuantitySenateEN.senateGaugeVersionID, 4, convVideoLibQuantitySenate.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(objvVideoLibQuantitySenateEN.senateGaugeVersionName, 200, convVideoLibQuantitySenate.senateGaugeVersionName);
clsCheckSql.CheckFieldLen(objvVideoLibQuantitySenateEN.UserId, 18, convVideoLibQuantitySenate.UserId);
clsCheckSql.CheckFieldLen(objvVideoLibQuantitySenateEN.UserNameWithUserId, 51, convVideoLibQuantitySenate.UserNameWithUserId);
clsCheckSql.CheckFieldLen(objvVideoLibQuantitySenateEN.UserName, 30, convVideoLibQuantitySenate.UserName);
clsCheckSql.CheckFieldLen(objvVideoLibQuantitySenateEN.UserKindId, 2, convVideoLibQuantitySenate.UserKindId);
clsCheckSql.CheckFieldLen(objvVideoLibQuantitySenateEN.UserKindName, 30, convVideoLibQuantitySenate.UserKindName);
clsCheckSql.CheckFieldLen(objvVideoLibQuantitySenateEN.UserTypeId, 2, convVideoLibQuantitySenate.UserTypeId);
clsCheckSql.CheckFieldLen(objvVideoLibQuantitySenateEN.UserTypeName, 20, convVideoLibQuantitySenate.UserTypeName);
clsCheckSql.CheckFieldLen(objvVideoLibQuantitySenateEN.UpdUser, 20, convVideoLibQuantitySenate.UpdUser);
clsCheckSql.CheckFieldLen(objvVideoLibQuantitySenateEN.Memo, 1000, convVideoLibQuantitySenate.Memo);
clsCheckSql.CheckFieldLen(objvVideoLibQuantitySenateEN.UpdUserName, 20, convVideoLibQuantitySenate.UpdUserName);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvVideoLibQuantitySenateEN.FuncModuleId, convVideoLibQuantitySenate.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibQuantitySenateEN.FuncModuleName, convVideoLibQuantitySenate.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibQuantitySenateEN.IdMicroteachCase, convVideoLibQuantitySenate.IdMicroteachCase);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibQuantitySenateEN.IdVideoLib, convVideoLibQuantitySenate.IdVideoLib);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibQuantitySenateEN.VideoLibID, convVideoLibQuantitySenate.VideoLibID);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibQuantitySenateEN.VideoLibName, convVideoLibQuantitySenate.VideoLibName);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibQuantitySenateEN.VideoLibTheme, convVideoLibQuantitySenate.VideoLibTheme);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibQuantitySenateEN.VideoLibTypeName, convVideoLibQuantitySenate.VideoLibTypeName);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibQuantitySenateEN.VideoLibDate, convVideoLibQuantitySenate.VideoLibDate);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibQuantitySenateEN.VideoLibTime, convVideoLibQuantitySenate.VideoLibTime);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibQuantitySenateEN.VideoLibDateIn, convVideoLibQuantitySenate.VideoLibDateIn);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibQuantitySenateEN.VideoLibTimeIn, convVideoLibQuantitySenate.VideoLibTimeIn);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibQuantitySenateEN.OwnerId, convVideoLibQuantitySenate.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibQuantitySenateEN.IdXzCollege, convVideoLibQuantitySenate.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibQuantitySenateEN.CollegeID, convVideoLibQuantitySenate.CollegeID);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibQuantitySenateEN.CollegeName, convVideoLibQuantitySenate.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibQuantitySenateEN.CollegeNameA, convVideoLibQuantitySenate.CollegeNameA);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibQuantitySenateEN.CourseId, convVideoLibQuantitySenate.CourseId);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibQuantitySenateEN.CourseCode, convVideoLibQuantitySenate.CourseCode);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibQuantitySenateEN.CourseName, convVideoLibQuantitySenate.CourseName);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibQuantitySenateEN.OwnerName, convVideoLibQuantitySenate.OwnerName);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibQuantitySenateEN.OwnerNameWithId, convVideoLibQuantitySenate.OwnerNameWithId);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibQuantitySenateEN.IdAppraiseType, convVideoLibQuantitySenate.IdAppraiseType);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibQuantitySenateEN.AppraiseTypeName, convVideoLibQuantitySenate.AppraiseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibQuantitySenateEN.SenateTheme, convVideoLibQuantitySenate.SenateTheme);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibQuantitySenateEN.SenateContent, convVideoLibQuantitySenate.SenateContent);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibQuantitySenateEN.SenateDate, convVideoLibQuantitySenate.SenateDate);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibQuantitySenateEN.SenateTime, convVideoLibQuantitySenate.SenateTime);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibQuantitySenateEN.SenateIp, convVideoLibQuantitySenate.SenateIp);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibQuantitySenateEN.IdSenateGaugeVersion, convVideoLibQuantitySenate.IdSenateGaugeVersion);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibQuantitySenateEN.senateGaugeVersionID, convVideoLibQuantitySenate.senateGaugeVersionID);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibQuantitySenateEN.senateGaugeVersionName, convVideoLibQuantitySenate.senateGaugeVersionName);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibQuantitySenateEN.UserId, convVideoLibQuantitySenate.UserId);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibQuantitySenateEN.UserNameWithUserId, convVideoLibQuantitySenate.UserNameWithUserId);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibQuantitySenateEN.UserName, convVideoLibQuantitySenate.UserName);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibQuantitySenateEN.UserKindId, convVideoLibQuantitySenate.UserKindId);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibQuantitySenateEN.UserKindName, convVideoLibQuantitySenate.UserKindName);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibQuantitySenateEN.UserTypeId, convVideoLibQuantitySenate.UserTypeId);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibQuantitySenateEN.UserTypeName, convVideoLibQuantitySenate.UserTypeName);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibQuantitySenateEN.UpdUser, convVideoLibQuantitySenate.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibQuantitySenateEN.Memo, convVideoLibQuantitySenate.Memo);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibQuantitySenateEN.UpdUserName, convVideoLibQuantitySenate.UpdUserName);
//检查外键字段长度
 objvVideoLibQuantitySenateEN._IsCheckProperty = true;
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
 objSQL = clsvVideoLibQuantitySenateDA.GetSpecSQLObj();
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
 objSQL = clsvVideoLibQuantitySenateDA.GetSpecSQLObj();
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
 objSQL = clsvVideoLibQuantitySenateDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvVideoLibQuantitySenateEN._CurrTabName);
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
 objSQL = clsvVideoLibQuantitySenateDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvVideoLibQuantitySenateEN._CurrTabName, strCondition);
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
 objSQL = clsvVideoLibQuantitySenateDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}