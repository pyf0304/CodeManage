
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvVideoLibAppraiseDA
 表名:vVideoLibAppraise(01120266)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:50:39
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
 /// v视频库定性评议(vVideoLibAppraise)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvVideoLibAppraiseDA : clsCommBase4DA
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
 return clsvVideoLibAppraiseEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvVideoLibAppraiseEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvVideoLibAppraiseEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvVideoLibAppraiseEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvVideoLibAppraiseEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvVideoLibAppraiseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibAppraiseDA.GetSpecSQLObj();
strSQL = "Select * from vVideoLibAppraise where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vVideoLibAppraise(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvVideoLibAppraiseDA: GetDataTable_vVideoLibAppraise)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibAppraiseDA.GetSpecSQLObj();
strSQL = "Select * from vVideoLibAppraise where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvVideoLibAppraiseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibAppraiseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvVideoLibAppraiseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibAppraiseDA.GetSpecSQLObj();
strSQL = "Select * from vVideoLibAppraise where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvVideoLibAppraiseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibAppraiseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvVideoLibAppraiseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibAppraiseDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vVideoLibAppraise where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vVideoLibAppraise where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvVideoLibAppraiseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibAppraiseDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vVideoLibAppraise where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvVideoLibAppraiseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibAppraiseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vVideoLibAppraise.* from vVideoLibAppraise Left Join {1} on {2} where {3} and vVideoLibAppraise.IdMicroteachAppraise not in (Select top {5} vVideoLibAppraise.IdMicroteachAppraise from vVideoLibAppraise Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vVideoLibAppraise where {1} and IdMicroteachAppraise not in (Select top {2} IdMicroteachAppraise from vVideoLibAppraise where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vVideoLibAppraise where {1} and IdMicroteachAppraise not in (Select top {3} IdMicroteachAppraise from vVideoLibAppraise where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvVideoLibAppraiseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibAppraiseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vVideoLibAppraise.* from vVideoLibAppraise Left Join {1} on {2} where {3} and vVideoLibAppraise.IdMicroteachAppraise not in (Select top {5} vVideoLibAppraise.IdMicroteachAppraise from vVideoLibAppraise Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vVideoLibAppraise where {1} and IdMicroteachAppraise not in (Select top {2} IdMicroteachAppraise from vVideoLibAppraise where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vVideoLibAppraise where {1} and IdMicroteachAppraise not in (Select top {3} IdMicroteachAppraise from vVideoLibAppraise where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvVideoLibAppraiseEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvVideoLibAppraiseDA:GetObjLst)", objException.Message));
}
List<clsvVideoLibAppraiseEN> arrObjLst = new List<clsvVideoLibAppraiseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibAppraiseDA.GetSpecSQLObj();
strSQL = "Select * from vVideoLibAppraise where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLibAppraiseEN objvVideoLibAppraiseEN = new clsvVideoLibAppraiseEN();
try
{
objvVideoLibAppraiseEN.IdMicroteachAppraise = TransNullToInt(objRow[convVideoLibAppraise.IdMicroteachAppraise].ToString().Trim()); //评议流水号
objvVideoLibAppraiseEN.FuncModuleId = objRow[convVideoLibAppraise.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoLibAppraiseEN.FuncModuleName = objRow[convVideoLibAppraise.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLibAppraise.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoLibAppraiseEN.IdMicroteachCase = objRow[convVideoLibAppraise.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoLibAppraiseEN.IdVideoLib = objRow[convVideoLibAppraise.IdVideoLib] == DBNull.Value ? null : objRow[convVideoLibAppraise.IdVideoLib].ToString().Trim(); //视频库流水号
objvVideoLibAppraiseEN.VideoLibID = objRow[convVideoLibAppraise.VideoLibID] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLibAppraiseEN.VideoLibName = objRow[convVideoLibAppraise.VideoLibName] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibName].ToString().Trim(); //视频名称
objvVideoLibAppraiseEN.VideoLibTheme = objRow[convVideoLibAppraise.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibTheme].ToString().Trim(); //视频库主题词
objvVideoLibAppraiseEN.VideoLibTypeName = objRow[convVideoLibAppraise.VideoLibTypeName] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibTypeName].ToString().Trim(); //视频库类型名称
objvVideoLibAppraiseEN.VideoLibDate = objRow[convVideoLibAppraise.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibDate].ToString().Trim(); //视频资源日期
objvVideoLibAppraiseEN.VideoLibTime = objRow[convVideoLibAppraise.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibTime].ToString().Trim(); //视频资源时间
objvVideoLibAppraiseEN.VideoLibDateIn = objRow[convVideoLibAppraise.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibDateIn].ToString().Trim(); //案例入库日期
objvVideoLibAppraiseEN.VideoLibTimeIn = objRow[convVideoLibAppraise.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objvVideoLibAppraiseEN.IdXzCollege = objRow[convVideoLibAppraise.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLibAppraise.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLibAppraiseEN.CollegeID = objRow[convVideoLibAppraise.CollegeID] == DBNull.Value ? null : objRow[convVideoLibAppraise.CollegeID].ToString().Trim(); //学院ID
objvVideoLibAppraiseEN.CollegeName = objRow[convVideoLibAppraise.CollegeName] == DBNull.Value ? null : objRow[convVideoLibAppraise.CollegeName].ToString().Trim(); //学院名称
objvVideoLibAppraiseEN.CourseId = objRow[convVideoLibAppraise.CourseId] == DBNull.Value ? null : objRow[convVideoLibAppraise.CourseId].ToString().Trim(); //课程Id
objvVideoLibAppraiseEN.CourseCode = objRow[convVideoLibAppraise.CourseCode] == DBNull.Value ? null : objRow[convVideoLibAppraise.CourseCode].ToString().Trim(); //课程代码
objvVideoLibAppraiseEN.CourseName = objRow[convVideoLibAppraise.CourseName] == DBNull.Value ? null : objRow[convVideoLibAppraise.CourseName].ToString().Trim(); //课程名称
objvVideoLibAppraiseEN.BrowseCount4Case = objRow[convVideoLibAppraise.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLibAppraise.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvVideoLibAppraiseEN.IdAppraiseType = objRow[convVideoLibAppraise.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvVideoLibAppraiseEN.AppraiseTypeName = objRow[convVideoLibAppraise.AppraiseTypeName] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvVideoLibAppraiseEN.AppraiseTheme = objRow[convVideoLibAppraise.AppraiseTheme] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseTheme].ToString().Trim(); //评议主题
objvVideoLibAppraiseEN.AppraiseContent = objRow[convVideoLibAppraise.AppraiseContent] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseContent].ToString().Trim(); //评议内容
objvVideoLibAppraiseEN.AppraiseDate = objRow[convVideoLibAppraise.AppraiseDate] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseDate].ToString().Trim(); //评议日期
objvVideoLibAppraiseEN.AppraiseTime = objRow[convVideoLibAppraise.AppraiseTime] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseTime].ToString().Trim(); //评议时间
objvVideoLibAppraiseEN.IsVisual = TransNullToBool(objRow[convVideoLibAppraise.IsVisual].ToString().Trim()); //隐藏标志
objvVideoLibAppraiseEN.IsElite = TransNullToBool(objRow[convVideoLibAppraise.IsElite].ToString().Trim()); //精华标志
objvVideoLibAppraiseEN.ExcellentOne = objRow[convVideoLibAppraise.ExcellentOne] == DBNull.Value ? null : objRow[convVideoLibAppraise.ExcellentOne].ToString().Trim(); //优点1
objvVideoLibAppraiseEN.ExcellentTwo = objRow[convVideoLibAppraise.ExcellentTwo] == DBNull.Value ? null : objRow[convVideoLibAppraise.ExcellentTwo].ToString().Trim(); //优点2
objvVideoLibAppraiseEN.SuggestOne = objRow[convVideoLibAppraise.SuggestOne] == DBNull.Value ? null : objRow[convVideoLibAppraise.SuggestOne].ToString().Trim(); //建议1
objvVideoLibAppraiseEN.SuggestTwo = objRow[convVideoLibAppraise.SuggestTwo] == DBNull.Value ? null : objRow[convVideoLibAppraise.SuggestTwo].ToString().Trim(); //建议2
objvVideoLibAppraiseEN.MicroteachAppriseScore = objRow[convVideoLibAppraise.MicroteachAppriseScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convVideoLibAppraise.MicroteachAppriseScore].ToString().Trim()); //打分
objvVideoLibAppraiseEN.VideoStopTime = objRow[convVideoLibAppraise.VideoStopTime] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objvVideoLibAppraiseEN.BrowseCount = objRow[convVideoLibAppraise.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLibAppraise.BrowseCount].ToString().Trim()); //浏览次数
objvVideoLibAppraiseEN.UserId = objRow[convVideoLibAppraise.UserId].ToString().Trim(); //用户ID
objvVideoLibAppraiseEN.UserName = objRow[convVideoLibAppraise.UserName] == DBNull.Value ? null : objRow[convVideoLibAppraise.UserName].ToString().Trim(); //用户名
objvVideoLibAppraiseEN.UserNameWithUserId = objRow[convVideoLibAppraise.UserNameWithUserId] == DBNull.Value ? null : objRow[convVideoLibAppraise.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvVideoLibAppraiseDA: GetObjLst)", objException.Message));
}
objvVideoLibAppraiseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvVideoLibAppraiseEN);
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
public List<clsvVideoLibAppraiseEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvVideoLibAppraiseDA:GetObjLstByTabName)", objException.Message));
}
List<clsvVideoLibAppraiseEN> arrObjLst = new List<clsvVideoLibAppraiseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibAppraiseDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLibAppraiseEN objvVideoLibAppraiseEN = new clsvVideoLibAppraiseEN();
try
{
objvVideoLibAppraiseEN.IdMicroteachAppraise = TransNullToInt(objRow[convVideoLibAppraise.IdMicroteachAppraise].ToString().Trim()); //评议流水号
objvVideoLibAppraiseEN.FuncModuleId = objRow[convVideoLibAppraise.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoLibAppraiseEN.FuncModuleName = objRow[convVideoLibAppraise.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLibAppraise.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoLibAppraiseEN.IdMicroteachCase = objRow[convVideoLibAppraise.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoLibAppraiseEN.IdVideoLib = objRow[convVideoLibAppraise.IdVideoLib] == DBNull.Value ? null : objRow[convVideoLibAppraise.IdVideoLib].ToString().Trim(); //视频库流水号
objvVideoLibAppraiseEN.VideoLibID = objRow[convVideoLibAppraise.VideoLibID] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLibAppraiseEN.VideoLibName = objRow[convVideoLibAppraise.VideoLibName] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibName].ToString().Trim(); //视频名称
objvVideoLibAppraiseEN.VideoLibTheme = objRow[convVideoLibAppraise.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibTheme].ToString().Trim(); //视频库主题词
objvVideoLibAppraiseEN.VideoLibTypeName = objRow[convVideoLibAppraise.VideoLibTypeName] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibTypeName].ToString().Trim(); //视频库类型名称
objvVideoLibAppraiseEN.VideoLibDate = objRow[convVideoLibAppraise.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibDate].ToString().Trim(); //视频资源日期
objvVideoLibAppraiseEN.VideoLibTime = objRow[convVideoLibAppraise.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibTime].ToString().Trim(); //视频资源时间
objvVideoLibAppraiseEN.VideoLibDateIn = objRow[convVideoLibAppraise.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibDateIn].ToString().Trim(); //案例入库日期
objvVideoLibAppraiseEN.VideoLibTimeIn = objRow[convVideoLibAppraise.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objvVideoLibAppraiseEN.IdXzCollege = objRow[convVideoLibAppraise.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLibAppraise.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLibAppraiseEN.CollegeID = objRow[convVideoLibAppraise.CollegeID] == DBNull.Value ? null : objRow[convVideoLibAppraise.CollegeID].ToString().Trim(); //学院ID
objvVideoLibAppraiseEN.CollegeName = objRow[convVideoLibAppraise.CollegeName] == DBNull.Value ? null : objRow[convVideoLibAppraise.CollegeName].ToString().Trim(); //学院名称
objvVideoLibAppraiseEN.CourseId = objRow[convVideoLibAppraise.CourseId] == DBNull.Value ? null : objRow[convVideoLibAppraise.CourseId].ToString().Trim(); //课程Id
objvVideoLibAppraiseEN.CourseCode = objRow[convVideoLibAppraise.CourseCode] == DBNull.Value ? null : objRow[convVideoLibAppraise.CourseCode].ToString().Trim(); //课程代码
objvVideoLibAppraiseEN.CourseName = objRow[convVideoLibAppraise.CourseName] == DBNull.Value ? null : objRow[convVideoLibAppraise.CourseName].ToString().Trim(); //课程名称
objvVideoLibAppraiseEN.BrowseCount4Case = objRow[convVideoLibAppraise.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLibAppraise.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvVideoLibAppraiseEN.IdAppraiseType = objRow[convVideoLibAppraise.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvVideoLibAppraiseEN.AppraiseTypeName = objRow[convVideoLibAppraise.AppraiseTypeName] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvVideoLibAppraiseEN.AppraiseTheme = objRow[convVideoLibAppraise.AppraiseTheme] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseTheme].ToString().Trim(); //评议主题
objvVideoLibAppraiseEN.AppraiseContent = objRow[convVideoLibAppraise.AppraiseContent] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseContent].ToString().Trim(); //评议内容
objvVideoLibAppraiseEN.AppraiseDate = objRow[convVideoLibAppraise.AppraiseDate] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseDate].ToString().Trim(); //评议日期
objvVideoLibAppraiseEN.AppraiseTime = objRow[convVideoLibAppraise.AppraiseTime] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseTime].ToString().Trim(); //评议时间
objvVideoLibAppraiseEN.IsVisual = TransNullToBool(objRow[convVideoLibAppraise.IsVisual].ToString().Trim()); //隐藏标志
objvVideoLibAppraiseEN.IsElite = TransNullToBool(objRow[convVideoLibAppraise.IsElite].ToString().Trim()); //精华标志
objvVideoLibAppraiseEN.ExcellentOne = objRow[convVideoLibAppraise.ExcellentOne] == DBNull.Value ? null : objRow[convVideoLibAppraise.ExcellentOne].ToString().Trim(); //优点1
objvVideoLibAppraiseEN.ExcellentTwo = objRow[convVideoLibAppraise.ExcellentTwo] == DBNull.Value ? null : objRow[convVideoLibAppraise.ExcellentTwo].ToString().Trim(); //优点2
objvVideoLibAppraiseEN.SuggestOne = objRow[convVideoLibAppraise.SuggestOne] == DBNull.Value ? null : objRow[convVideoLibAppraise.SuggestOne].ToString().Trim(); //建议1
objvVideoLibAppraiseEN.SuggestTwo = objRow[convVideoLibAppraise.SuggestTwo] == DBNull.Value ? null : objRow[convVideoLibAppraise.SuggestTwo].ToString().Trim(); //建议2
objvVideoLibAppraiseEN.MicroteachAppriseScore = objRow[convVideoLibAppraise.MicroteachAppriseScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convVideoLibAppraise.MicroteachAppriseScore].ToString().Trim()); //打分
objvVideoLibAppraiseEN.VideoStopTime = objRow[convVideoLibAppraise.VideoStopTime] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objvVideoLibAppraiseEN.BrowseCount = objRow[convVideoLibAppraise.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLibAppraise.BrowseCount].ToString().Trim()); //浏览次数
objvVideoLibAppraiseEN.UserId = objRow[convVideoLibAppraise.UserId].ToString().Trim(); //用户ID
objvVideoLibAppraiseEN.UserName = objRow[convVideoLibAppraise.UserName] == DBNull.Value ? null : objRow[convVideoLibAppraise.UserName].ToString().Trim(); //用户名
objvVideoLibAppraiseEN.UserNameWithUserId = objRow[convVideoLibAppraise.UserNameWithUserId] == DBNull.Value ? null : objRow[convVideoLibAppraise.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvVideoLibAppraiseDA: GetObjLst)", objException.Message));
}
objvVideoLibAppraiseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvVideoLibAppraiseEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvVideoLibAppraise(ref clsvVideoLibAppraiseEN objvVideoLibAppraiseEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibAppraiseDA.GetSpecSQLObj();
strSQL = "Select * from vVideoLibAppraise where IdMicroteachAppraise = " + ""+ objvVideoLibAppraiseEN.IdMicroteachAppraise+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvVideoLibAppraiseEN.IdMicroteachAppraise = TransNullToInt(objDT.Rows[0][convVideoLibAppraise.IdMicroteachAppraise].ToString().Trim()); //评议流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvVideoLibAppraiseEN.FuncModuleId = objDT.Rows[0][convVideoLibAppraise.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvVideoLibAppraiseEN.FuncModuleName = objDT.Rows[0][convVideoLibAppraise.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvVideoLibAppraiseEN.IdMicroteachCase = objDT.Rows[0][convVideoLibAppraise.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoLibAppraiseEN.IdVideoLib = objDT.Rows[0][convVideoLibAppraise.IdVideoLib].ToString().Trim(); //视频库流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoLibAppraiseEN.VideoLibID = objDT.Rows[0][convVideoLibAppraise.VideoLibID].ToString().Trim(); //视频库ID(字段类型:char,字段长度:8,是否可空:False)
 objvVideoLibAppraiseEN.VideoLibName = objDT.Rows[0][convVideoLibAppraise.VideoLibName].ToString().Trim(); //视频名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvVideoLibAppraiseEN.VideoLibTheme = objDT.Rows[0][convVideoLibAppraise.VideoLibTheme].ToString().Trim(); //视频库主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoLibAppraiseEN.VideoLibTypeName = objDT.Rows[0][convVideoLibAppraise.VideoLibTypeName].ToString().Trim(); //视频库类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvVideoLibAppraiseEN.VideoLibDate = objDT.Rows[0][convVideoLibAppraise.VideoLibDate].ToString().Trim(); //视频资源日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvVideoLibAppraiseEN.VideoLibTime = objDT.Rows[0][convVideoLibAppraise.VideoLibTime].ToString().Trim(); //视频资源时间(字段类型:char,字段长度:6,是否可空:True)
 objvVideoLibAppraiseEN.VideoLibDateIn = objDT.Rows[0][convVideoLibAppraise.VideoLibDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvVideoLibAppraiseEN.VideoLibTimeIn = objDT.Rows[0][convVideoLibAppraise.VideoLibTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvVideoLibAppraiseEN.IdXzCollege = objDT.Rows[0][convVideoLibAppraise.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvVideoLibAppraiseEN.CollegeID = objDT.Rows[0][convVideoLibAppraise.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvVideoLibAppraiseEN.CollegeName = objDT.Rows[0][convVideoLibAppraise.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvVideoLibAppraiseEN.CourseId = objDT.Rows[0][convVideoLibAppraise.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvVideoLibAppraiseEN.CourseCode = objDT.Rows[0][convVideoLibAppraise.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvVideoLibAppraiseEN.CourseName = objDT.Rows[0][convVideoLibAppraise.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvVideoLibAppraiseEN.BrowseCount4Case = TransNullToInt(objDT.Rows[0][convVideoLibAppraise.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvVideoLibAppraiseEN.IdAppraiseType = objDT.Rows[0][convVideoLibAppraise.IdAppraiseType].ToString().Trim(); //评议类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvVideoLibAppraiseEN.AppraiseTypeName = objDT.Rows[0][convVideoLibAppraise.AppraiseTypeName].ToString().Trim(); //评议类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvVideoLibAppraiseEN.AppraiseTheme = objDT.Rows[0][convVideoLibAppraise.AppraiseTheme].ToString().Trim(); //评议主题(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoLibAppraiseEN.AppraiseContent = objDT.Rows[0][convVideoLibAppraise.AppraiseContent].ToString().Trim(); //评议内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvVideoLibAppraiseEN.AppraiseDate = objDT.Rows[0][convVideoLibAppraise.AppraiseDate].ToString().Trim(); //评议日期(字段类型:char,字段长度:8,是否可空:True)
 objvVideoLibAppraiseEN.AppraiseTime = objDT.Rows[0][convVideoLibAppraise.AppraiseTime].ToString().Trim(); //评议时间(字段类型:char,字段长度:6,是否可空:True)
 objvVideoLibAppraiseEN.IsVisual = TransNullToBool(objDT.Rows[0][convVideoLibAppraise.IsVisual].ToString().Trim()); //隐藏标志(字段类型:bit,字段长度:1,是否可空:False)
 objvVideoLibAppraiseEN.IsElite = TransNullToBool(objDT.Rows[0][convVideoLibAppraise.IsElite].ToString().Trim()); //精华标志(字段类型:bit,字段长度:1,是否可空:False)
 objvVideoLibAppraiseEN.ExcellentOne = objDT.Rows[0][convVideoLibAppraise.ExcellentOne].ToString().Trim(); //优点1(字段类型:varchar,字段长度:1000,是否可空:True)
 objvVideoLibAppraiseEN.ExcellentTwo = objDT.Rows[0][convVideoLibAppraise.ExcellentTwo].ToString().Trim(); //优点2(字段类型:varchar,字段长度:1000,是否可空:True)
 objvVideoLibAppraiseEN.SuggestOne = objDT.Rows[0][convVideoLibAppraise.SuggestOne].ToString().Trim(); //建议1(字段类型:varchar,字段长度:1000,是否可空:True)
 objvVideoLibAppraiseEN.SuggestTwo = objDT.Rows[0][convVideoLibAppraise.SuggestTwo].ToString().Trim(); //建议2(字段类型:varchar,字段长度:1000,是否可空:True)
 objvVideoLibAppraiseEN.MicroteachAppriseScore = TransNullToFloat(objDT.Rows[0][convVideoLibAppraise.MicroteachAppriseScore].ToString().Trim()); //打分(字段类型:float,字段长度:8,是否可空:True)
 objvVideoLibAppraiseEN.VideoStopTime = objDT.Rows[0][convVideoLibAppraise.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间(字段类型:varchar,字段长度:48,是否可空:True)
 objvVideoLibAppraiseEN.BrowseCount = TransNullToInt(objDT.Rows[0][convVideoLibAppraise.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvVideoLibAppraiseEN.UserId = objDT.Rows[0][convVideoLibAppraise.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvVideoLibAppraiseEN.UserName = objDT.Rows[0][convVideoLibAppraise.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvVideoLibAppraiseEN.UserNameWithUserId = objDT.Rows[0][convVideoLibAppraise.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId(字段类型:varchar,字段长度:51,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvVideoLibAppraiseDA: GetvVideoLibAppraise)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdMicroteachAppraise">表关键字</param>
 /// <returns>表对象</returns>
public clsvVideoLibAppraiseEN GetObjByIdMicroteachAppraise(long lngIdMicroteachAppraise)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibAppraiseDA.GetSpecSQLObj();
strSQL = "Select * from vVideoLibAppraise where IdMicroteachAppraise = " + ""+ lngIdMicroteachAppraise+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvVideoLibAppraiseEN objvVideoLibAppraiseEN = new clsvVideoLibAppraiseEN();
try
{
 objvVideoLibAppraiseEN.IdMicroteachAppraise = Int32.Parse(objRow[convVideoLibAppraise.IdMicroteachAppraise].ToString().Trim()); //评议流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvVideoLibAppraiseEN.FuncModuleId = objRow[convVideoLibAppraise.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvVideoLibAppraiseEN.FuncModuleName = objRow[convVideoLibAppraise.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLibAppraise.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvVideoLibAppraiseEN.IdMicroteachCase = objRow[convVideoLibAppraise.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoLibAppraiseEN.IdVideoLib = objRow[convVideoLibAppraise.IdVideoLib] == DBNull.Value ? null : objRow[convVideoLibAppraise.IdVideoLib].ToString().Trim(); //视频库流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoLibAppraiseEN.VideoLibID = objRow[convVideoLibAppraise.VideoLibID] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibID].ToString().Trim(); //视频库ID(字段类型:char,字段长度:8,是否可空:False)
 objvVideoLibAppraiseEN.VideoLibName = objRow[convVideoLibAppraise.VideoLibName] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibName].ToString().Trim(); //视频名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvVideoLibAppraiseEN.VideoLibTheme = objRow[convVideoLibAppraise.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibTheme].ToString().Trim(); //视频库主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoLibAppraiseEN.VideoLibTypeName = objRow[convVideoLibAppraise.VideoLibTypeName] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibTypeName].ToString().Trim(); //视频库类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvVideoLibAppraiseEN.VideoLibDate = objRow[convVideoLibAppraise.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibDate].ToString().Trim(); //视频资源日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvVideoLibAppraiseEN.VideoLibTime = objRow[convVideoLibAppraise.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibTime].ToString().Trim(); //视频资源时间(字段类型:char,字段长度:6,是否可空:True)
 objvVideoLibAppraiseEN.VideoLibDateIn = objRow[convVideoLibAppraise.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvVideoLibAppraiseEN.VideoLibTimeIn = objRow[convVideoLibAppraise.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvVideoLibAppraiseEN.IdXzCollege = objRow[convVideoLibAppraise.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLibAppraise.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvVideoLibAppraiseEN.CollegeID = objRow[convVideoLibAppraise.CollegeID] == DBNull.Value ? null : objRow[convVideoLibAppraise.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvVideoLibAppraiseEN.CollegeName = objRow[convVideoLibAppraise.CollegeName] == DBNull.Value ? null : objRow[convVideoLibAppraise.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvVideoLibAppraiseEN.CourseId = objRow[convVideoLibAppraise.CourseId] == DBNull.Value ? null : objRow[convVideoLibAppraise.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvVideoLibAppraiseEN.CourseCode = objRow[convVideoLibAppraise.CourseCode] == DBNull.Value ? null : objRow[convVideoLibAppraise.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvVideoLibAppraiseEN.CourseName = objRow[convVideoLibAppraise.CourseName] == DBNull.Value ? null : objRow[convVideoLibAppraise.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvVideoLibAppraiseEN.BrowseCount4Case = objRow[convVideoLibAppraise.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibAppraise.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvVideoLibAppraiseEN.IdAppraiseType = objRow[convVideoLibAppraise.IdAppraiseType].ToString().Trim(); //评议类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvVideoLibAppraiseEN.AppraiseTypeName = objRow[convVideoLibAppraise.AppraiseTypeName] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseTypeName].ToString().Trim(); //评议类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvVideoLibAppraiseEN.AppraiseTheme = objRow[convVideoLibAppraise.AppraiseTheme] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseTheme].ToString().Trim(); //评议主题(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoLibAppraiseEN.AppraiseContent = objRow[convVideoLibAppraise.AppraiseContent] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseContent].ToString().Trim(); //评议内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvVideoLibAppraiseEN.AppraiseDate = objRow[convVideoLibAppraise.AppraiseDate] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseDate].ToString().Trim(); //评议日期(字段类型:char,字段长度:8,是否可空:True)
 objvVideoLibAppraiseEN.AppraiseTime = objRow[convVideoLibAppraise.AppraiseTime] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseTime].ToString().Trim(); //评议时间(字段类型:char,字段长度:6,是否可空:True)
 objvVideoLibAppraiseEN.IsVisual = clsEntityBase2.TransNullToBool_S(objRow[convVideoLibAppraise.IsVisual].ToString().Trim()); //隐藏标志(字段类型:bit,字段长度:1,是否可空:False)
 objvVideoLibAppraiseEN.IsElite = clsEntityBase2.TransNullToBool_S(objRow[convVideoLibAppraise.IsElite].ToString().Trim()); //精华标志(字段类型:bit,字段长度:1,是否可空:False)
 objvVideoLibAppraiseEN.ExcellentOne = objRow[convVideoLibAppraise.ExcellentOne] == DBNull.Value ? null : objRow[convVideoLibAppraise.ExcellentOne].ToString().Trim(); //优点1(字段类型:varchar,字段长度:1000,是否可空:True)
 objvVideoLibAppraiseEN.ExcellentTwo = objRow[convVideoLibAppraise.ExcellentTwo] == DBNull.Value ? null : objRow[convVideoLibAppraise.ExcellentTwo].ToString().Trim(); //优点2(字段类型:varchar,字段长度:1000,是否可空:True)
 objvVideoLibAppraiseEN.SuggestOne = objRow[convVideoLibAppraise.SuggestOne] == DBNull.Value ? null : objRow[convVideoLibAppraise.SuggestOne].ToString().Trim(); //建议1(字段类型:varchar,字段长度:1000,是否可空:True)
 objvVideoLibAppraiseEN.SuggestTwo = objRow[convVideoLibAppraise.SuggestTwo] == DBNull.Value ? null : objRow[convVideoLibAppraise.SuggestTwo].ToString().Trim(); //建议2(字段类型:varchar,字段长度:1000,是否可空:True)
 objvVideoLibAppraiseEN.MicroteachAppriseScore = objRow[convVideoLibAppraise.MicroteachAppriseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convVideoLibAppraise.MicroteachAppriseScore].ToString().Trim()); //打分(字段类型:float,字段长度:8,是否可空:True)
 objvVideoLibAppraiseEN.VideoStopTime = objRow[convVideoLibAppraise.VideoStopTime] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间(字段类型:varchar,字段长度:48,是否可空:True)
 objvVideoLibAppraiseEN.BrowseCount = objRow[convVideoLibAppraise.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibAppraise.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvVideoLibAppraiseEN.UserId = objRow[convVideoLibAppraise.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvVideoLibAppraiseEN.UserName = objRow[convVideoLibAppraise.UserName] == DBNull.Value ? null : objRow[convVideoLibAppraise.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvVideoLibAppraiseEN.UserNameWithUserId = objRow[convVideoLibAppraise.UserNameWithUserId] == DBNull.Value ? null : objRow[convVideoLibAppraise.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId(字段类型:varchar,字段长度:51,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvVideoLibAppraiseDA: GetObjByIdMicroteachAppraise)", objException.Message));
}
return objvVideoLibAppraiseEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvVideoLibAppraiseEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvVideoLibAppraiseDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibAppraiseDA.GetSpecSQLObj();
strSQL = "Select * from vVideoLibAppraise where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvVideoLibAppraiseEN objvVideoLibAppraiseEN = new clsvVideoLibAppraiseEN()
{
IdMicroteachAppraise = TransNullToInt(objRow[convVideoLibAppraise.IdMicroteachAppraise].ToString().Trim()), //评议流水号
FuncModuleId = objRow[convVideoLibAppraise.FuncModuleId].ToString().Trim(), //功能模块Id
FuncModuleName = objRow[convVideoLibAppraise.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLibAppraise.FuncModuleName].ToString().Trim(), //功能模块名称
IdMicroteachCase = objRow[convVideoLibAppraise.IdMicroteachCase].ToString().Trim(), //微格教学案例流水号
IdVideoLib = objRow[convVideoLibAppraise.IdVideoLib] == DBNull.Value ? null : objRow[convVideoLibAppraise.IdVideoLib].ToString().Trim(), //视频库流水号
VideoLibID = objRow[convVideoLibAppraise.VideoLibID] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibID].ToString().Trim(), //视频库ID
VideoLibName = objRow[convVideoLibAppraise.VideoLibName] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibName].ToString().Trim(), //视频名称
VideoLibTheme = objRow[convVideoLibAppraise.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibTheme].ToString().Trim(), //视频库主题词
VideoLibTypeName = objRow[convVideoLibAppraise.VideoLibTypeName] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibTypeName].ToString().Trim(), //视频库类型名称
VideoLibDate = objRow[convVideoLibAppraise.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibDate].ToString().Trim(), //视频资源日期
VideoLibTime = objRow[convVideoLibAppraise.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibTime].ToString().Trim(), //视频资源时间
VideoLibDateIn = objRow[convVideoLibAppraise.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibDateIn].ToString().Trim(), //案例入库日期
VideoLibTimeIn = objRow[convVideoLibAppraise.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibTimeIn].ToString().Trim(), //案例入库时间
IdXzCollege = objRow[convVideoLibAppraise.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLibAppraise.IdXzCollege].ToString().Trim(), //学院流水号
CollegeID = objRow[convVideoLibAppraise.CollegeID] == DBNull.Value ? null : objRow[convVideoLibAppraise.CollegeID].ToString().Trim(), //学院ID
CollegeName = objRow[convVideoLibAppraise.CollegeName] == DBNull.Value ? null : objRow[convVideoLibAppraise.CollegeName].ToString().Trim(), //学院名称
CourseId = objRow[convVideoLibAppraise.CourseId] == DBNull.Value ? null : objRow[convVideoLibAppraise.CourseId].ToString().Trim(), //课程Id
CourseCode = objRow[convVideoLibAppraise.CourseCode] == DBNull.Value ? null : objRow[convVideoLibAppraise.CourseCode].ToString().Trim(), //课程代码
CourseName = objRow[convVideoLibAppraise.CourseName] == DBNull.Value ? null : objRow[convVideoLibAppraise.CourseName].ToString().Trim(), //课程名称
BrowseCount4Case = objRow[convVideoLibAppraise.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLibAppraise.BrowseCount4Case].ToString().Trim()), //课例浏览次数
IdAppraiseType = objRow[convVideoLibAppraise.IdAppraiseType].ToString().Trim(), //评议类型流水号
AppraiseTypeName = objRow[convVideoLibAppraise.AppraiseTypeName] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseTypeName].ToString().Trim(), //评议类型名称
AppraiseTheme = objRow[convVideoLibAppraise.AppraiseTheme] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseTheme].ToString().Trim(), //评议主题
AppraiseContent = objRow[convVideoLibAppraise.AppraiseContent] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseContent].ToString().Trim(), //评议内容
AppraiseDate = objRow[convVideoLibAppraise.AppraiseDate] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseDate].ToString().Trim(), //评议日期
AppraiseTime = objRow[convVideoLibAppraise.AppraiseTime] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseTime].ToString().Trim(), //评议时间
IsVisual = TransNullToBool(objRow[convVideoLibAppraise.IsVisual].ToString().Trim()), //隐藏标志
IsElite = TransNullToBool(objRow[convVideoLibAppraise.IsElite].ToString().Trim()), //精华标志
ExcellentOne = objRow[convVideoLibAppraise.ExcellentOne] == DBNull.Value ? null : objRow[convVideoLibAppraise.ExcellentOne].ToString().Trim(), //优点1
ExcellentTwo = objRow[convVideoLibAppraise.ExcellentTwo] == DBNull.Value ? null : objRow[convVideoLibAppraise.ExcellentTwo].ToString().Trim(), //优点2
SuggestOne = objRow[convVideoLibAppraise.SuggestOne] == DBNull.Value ? null : objRow[convVideoLibAppraise.SuggestOne].ToString().Trim(), //建议1
SuggestTwo = objRow[convVideoLibAppraise.SuggestTwo] == DBNull.Value ? null : objRow[convVideoLibAppraise.SuggestTwo].ToString().Trim(), //建议2
MicroteachAppriseScore = objRow[convVideoLibAppraise.MicroteachAppriseScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convVideoLibAppraise.MicroteachAppriseScore].ToString().Trim()), //打分
VideoStopTime = objRow[convVideoLibAppraise.VideoStopTime] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoStopTime].ToString().Trim(), //公开课案例视频暂停时间
BrowseCount = objRow[convVideoLibAppraise.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLibAppraise.BrowseCount].ToString().Trim()), //浏览次数
UserId = objRow[convVideoLibAppraise.UserId].ToString().Trim(), //用户ID
UserName = objRow[convVideoLibAppraise.UserName] == DBNull.Value ? null : objRow[convVideoLibAppraise.UserName].ToString().Trim(), //用户名
UserNameWithUserId = objRow[convVideoLibAppraise.UserNameWithUserId] == DBNull.Value ? null : objRow[convVideoLibAppraise.UserNameWithUserId].ToString().Trim() //UserNameWithUserId
};
objvVideoLibAppraiseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvVideoLibAppraiseEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvVideoLibAppraiseDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvVideoLibAppraiseEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvVideoLibAppraiseEN objvVideoLibAppraiseEN = new clsvVideoLibAppraiseEN();
try
{
objvVideoLibAppraiseEN.IdMicroteachAppraise = TransNullToInt(objRow[convVideoLibAppraise.IdMicroteachAppraise].ToString().Trim()); //评议流水号
objvVideoLibAppraiseEN.FuncModuleId = objRow[convVideoLibAppraise.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoLibAppraiseEN.FuncModuleName = objRow[convVideoLibAppraise.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLibAppraise.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoLibAppraiseEN.IdMicroteachCase = objRow[convVideoLibAppraise.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoLibAppraiseEN.IdVideoLib = objRow[convVideoLibAppraise.IdVideoLib] == DBNull.Value ? null : objRow[convVideoLibAppraise.IdVideoLib].ToString().Trim(); //视频库流水号
objvVideoLibAppraiseEN.VideoLibID = objRow[convVideoLibAppraise.VideoLibID] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLibAppraiseEN.VideoLibName = objRow[convVideoLibAppraise.VideoLibName] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibName].ToString().Trim(); //视频名称
objvVideoLibAppraiseEN.VideoLibTheme = objRow[convVideoLibAppraise.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibTheme].ToString().Trim(); //视频库主题词
objvVideoLibAppraiseEN.VideoLibTypeName = objRow[convVideoLibAppraise.VideoLibTypeName] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibTypeName].ToString().Trim(); //视频库类型名称
objvVideoLibAppraiseEN.VideoLibDate = objRow[convVideoLibAppraise.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibDate].ToString().Trim(); //视频资源日期
objvVideoLibAppraiseEN.VideoLibTime = objRow[convVideoLibAppraise.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibTime].ToString().Trim(); //视频资源时间
objvVideoLibAppraiseEN.VideoLibDateIn = objRow[convVideoLibAppraise.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibDateIn].ToString().Trim(); //案例入库日期
objvVideoLibAppraiseEN.VideoLibTimeIn = objRow[convVideoLibAppraise.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objvVideoLibAppraiseEN.IdXzCollege = objRow[convVideoLibAppraise.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLibAppraise.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLibAppraiseEN.CollegeID = objRow[convVideoLibAppraise.CollegeID] == DBNull.Value ? null : objRow[convVideoLibAppraise.CollegeID].ToString().Trim(); //学院ID
objvVideoLibAppraiseEN.CollegeName = objRow[convVideoLibAppraise.CollegeName] == DBNull.Value ? null : objRow[convVideoLibAppraise.CollegeName].ToString().Trim(); //学院名称
objvVideoLibAppraiseEN.CourseId = objRow[convVideoLibAppraise.CourseId] == DBNull.Value ? null : objRow[convVideoLibAppraise.CourseId].ToString().Trim(); //课程Id
objvVideoLibAppraiseEN.CourseCode = objRow[convVideoLibAppraise.CourseCode] == DBNull.Value ? null : objRow[convVideoLibAppraise.CourseCode].ToString().Trim(); //课程代码
objvVideoLibAppraiseEN.CourseName = objRow[convVideoLibAppraise.CourseName] == DBNull.Value ? null : objRow[convVideoLibAppraise.CourseName].ToString().Trim(); //课程名称
objvVideoLibAppraiseEN.BrowseCount4Case = objRow[convVideoLibAppraise.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLibAppraise.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvVideoLibAppraiseEN.IdAppraiseType = objRow[convVideoLibAppraise.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvVideoLibAppraiseEN.AppraiseTypeName = objRow[convVideoLibAppraise.AppraiseTypeName] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvVideoLibAppraiseEN.AppraiseTheme = objRow[convVideoLibAppraise.AppraiseTheme] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseTheme].ToString().Trim(); //评议主题
objvVideoLibAppraiseEN.AppraiseContent = objRow[convVideoLibAppraise.AppraiseContent] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseContent].ToString().Trim(); //评议内容
objvVideoLibAppraiseEN.AppraiseDate = objRow[convVideoLibAppraise.AppraiseDate] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseDate].ToString().Trim(); //评议日期
objvVideoLibAppraiseEN.AppraiseTime = objRow[convVideoLibAppraise.AppraiseTime] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseTime].ToString().Trim(); //评议时间
objvVideoLibAppraiseEN.IsVisual = TransNullToBool(objRow[convVideoLibAppraise.IsVisual].ToString().Trim()); //隐藏标志
objvVideoLibAppraiseEN.IsElite = TransNullToBool(objRow[convVideoLibAppraise.IsElite].ToString().Trim()); //精华标志
objvVideoLibAppraiseEN.ExcellentOne = objRow[convVideoLibAppraise.ExcellentOne] == DBNull.Value ? null : objRow[convVideoLibAppraise.ExcellentOne].ToString().Trim(); //优点1
objvVideoLibAppraiseEN.ExcellentTwo = objRow[convVideoLibAppraise.ExcellentTwo] == DBNull.Value ? null : objRow[convVideoLibAppraise.ExcellentTwo].ToString().Trim(); //优点2
objvVideoLibAppraiseEN.SuggestOne = objRow[convVideoLibAppraise.SuggestOne] == DBNull.Value ? null : objRow[convVideoLibAppraise.SuggestOne].ToString().Trim(); //建议1
objvVideoLibAppraiseEN.SuggestTwo = objRow[convVideoLibAppraise.SuggestTwo] == DBNull.Value ? null : objRow[convVideoLibAppraise.SuggestTwo].ToString().Trim(); //建议2
objvVideoLibAppraiseEN.MicroteachAppriseScore = objRow[convVideoLibAppraise.MicroteachAppriseScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convVideoLibAppraise.MicroteachAppriseScore].ToString().Trim()); //打分
objvVideoLibAppraiseEN.VideoStopTime = objRow[convVideoLibAppraise.VideoStopTime] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objvVideoLibAppraiseEN.BrowseCount = objRow[convVideoLibAppraise.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLibAppraise.BrowseCount].ToString().Trim()); //浏览次数
objvVideoLibAppraiseEN.UserId = objRow[convVideoLibAppraise.UserId].ToString().Trim(); //用户ID
objvVideoLibAppraiseEN.UserName = objRow[convVideoLibAppraise.UserName] == DBNull.Value ? null : objRow[convVideoLibAppraise.UserName].ToString().Trim(); //用户名
objvVideoLibAppraiseEN.UserNameWithUserId = objRow[convVideoLibAppraise.UserNameWithUserId] == DBNull.Value ? null : objRow[convVideoLibAppraise.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvVideoLibAppraiseDA: GetObjByDataRowvVideoLibAppraise)", objException.Message));
}
objvVideoLibAppraiseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvVideoLibAppraiseEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvVideoLibAppraiseEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvVideoLibAppraiseEN objvVideoLibAppraiseEN = new clsvVideoLibAppraiseEN();
try
{
objvVideoLibAppraiseEN.IdMicroteachAppraise = TransNullToInt(objRow[convVideoLibAppraise.IdMicroteachAppraise].ToString().Trim()); //评议流水号
objvVideoLibAppraiseEN.FuncModuleId = objRow[convVideoLibAppraise.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoLibAppraiseEN.FuncModuleName = objRow[convVideoLibAppraise.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLibAppraise.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoLibAppraiseEN.IdMicroteachCase = objRow[convVideoLibAppraise.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoLibAppraiseEN.IdVideoLib = objRow[convVideoLibAppraise.IdVideoLib] == DBNull.Value ? null : objRow[convVideoLibAppraise.IdVideoLib].ToString().Trim(); //视频库流水号
objvVideoLibAppraiseEN.VideoLibID = objRow[convVideoLibAppraise.VideoLibID] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLibAppraiseEN.VideoLibName = objRow[convVideoLibAppraise.VideoLibName] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibName].ToString().Trim(); //视频名称
objvVideoLibAppraiseEN.VideoLibTheme = objRow[convVideoLibAppraise.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibTheme].ToString().Trim(); //视频库主题词
objvVideoLibAppraiseEN.VideoLibTypeName = objRow[convVideoLibAppraise.VideoLibTypeName] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibTypeName].ToString().Trim(); //视频库类型名称
objvVideoLibAppraiseEN.VideoLibDate = objRow[convVideoLibAppraise.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibDate].ToString().Trim(); //视频资源日期
objvVideoLibAppraiseEN.VideoLibTime = objRow[convVideoLibAppraise.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibTime].ToString().Trim(); //视频资源时间
objvVideoLibAppraiseEN.VideoLibDateIn = objRow[convVideoLibAppraise.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibDateIn].ToString().Trim(); //案例入库日期
objvVideoLibAppraiseEN.VideoLibTimeIn = objRow[convVideoLibAppraise.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objvVideoLibAppraiseEN.IdXzCollege = objRow[convVideoLibAppraise.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLibAppraise.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLibAppraiseEN.CollegeID = objRow[convVideoLibAppraise.CollegeID] == DBNull.Value ? null : objRow[convVideoLibAppraise.CollegeID].ToString().Trim(); //学院ID
objvVideoLibAppraiseEN.CollegeName = objRow[convVideoLibAppraise.CollegeName] == DBNull.Value ? null : objRow[convVideoLibAppraise.CollegeName].ToString().Trim(); //学院名称
objvVideoLibAppraiseEN.CourseId = objRow[convVideoLibAppraise.CourseId] == DBNull.Value ? null : objRow[convVideoLibAppraise.CourseId].ToString().Trim(); //课程Id
objvVideoLibAppraiseEN.CourseCode = objRow[convVideoLibAppraise.CourseCode] == DBNull.Value ? null : objRow[convVideoLibAppraise.CourseCode].ToString().Trim(); //课程代码
objvVideoLibAppraiseEN.CourseName = objRow[convVideoLibAppraise.CourseName] == DBNull.Value ? null : objRow[convVideoLibAppraise.CourseName].ToString().Trim(); //课程名称
objvVideoLibAppraiseEN.BrowseCount4Case = objRow[convVideoLibAppraise.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLibAppraise.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvVideoLibAppraiseEN.IdAppraiseType = objRow[convVideoLibAppraise.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvVideoLibAppraiseEN.AppraiseTypeName = objRow[convVideoLibAppraise.AppraiseTypeName] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvVideoLibAppraiseEN.AppraiseTheme = objRow[convVideoLibAppraise.AppraiseTheme] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseTheme].ToString().Trim(); //评议主题
objvVideoLibAppraiseEN.AppraiseContent = objRow[convVideoLibAppraise.AppraiseContent] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseContent].ToString().Trim(); //评议内容
objvVideoLibAppraiseEN.AppraiseDate = objRow[convVideoLibAppraise.AppraiseDate] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseDate].ToString().Trim(); //评议日期
objvVideoLibAppraiseEN.AppraiseTime = objRow[convVideoLibAppraise.AppraiseTime] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseTime].ToString().Trim(); //评议时间
objvVideoLibAppraiseEN.IsVisual = TransNullToBool(objRow[convVideoLibAppraise.IsVisual].ToString().Trim()); //隐藏标志
objvVideoLibAppraiseEN.IsElite = TransNullToBool(objRow[convVideoLibAppraise.IsElite].ToString().Trim()); //精华标志
objvVideoLibAppraiseEN.ExcellentOne = objRow[convVideoLibAppraise.ExcellentOne] == DBNull.Value ? null : objRow[convVideoLibAppraise.ExcellentOne].ToString().Trim(); //优点1
objvVideoLibAppraiseEN.ExcellentTwo = objRow[convVideoLibAppraise.ExcellentTwo] == DBNull.Value ? null : objRow[convVideoLibAppraise.ExcellentTwo].ToString().Trim(); //优点2
objvVideoLibAppraiseEN.SuggestOne = objRow[convVideoLibAppraise.SuggestOne] == DBNull.Value ? null : objRow[convVideoLibAppraise.SuggestOne].ToString().Trim(); //建议1
objvVideoLibAppraiseEN.SuggestTwo = objRow[convVideoLibAppraise.SuggestTwo] == DBNull.Value ? null : objRow[convVideoLibAppraise.SuggestTwo].ToString().Trim(); //建议2
objvVideoLibAppraiseEN.MicroteachAppriseScore = objRow[convVideoLibAppraise.MicroteachAppriseScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convVideoLibAppraise.MicroteachAppriseScore].ToString().Trim()); //打分
objvVideoLibAppraiseEN.VideoStopTime = objRow[convVideoLibAppraise.VideoStopTime] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objvVideoLibAppraiseEN.BrowseCount = objRow[convVideoLibAppraise.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLibAppraise.BrowseCount].ToString().Trim()); //浏览次数
objvVideoLibAppraiseEN.UserId = objRow[convVideoLibAppraise.UserId].ToString().Trim(); //用户ID
objvVideoLibAppraiseEN.UserName = objRow[convVideoLibAppraise.UserName] == DBNull.Value ? null : objRow[convVideoLibAppraise.UserName].ToString().Trim(); //用户名
objvVideoLibAppraiseEN.UserNameWithUserId = objRow[convVideoLibAppraise.UserNameWithUserId] == DBNull.Value ? null : objRow[convVideoLibAppraise.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvVideoLibAppraiseDA: GetObjByDataRow)", objException.Message));
}
objvVideoLibAppraiseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvVideoLibAppraiseEN;
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
objSQL = clsvVideoLibAppraiseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvVideoLibAppraiseEN._CurrTabName, convVideoLibAppraise.IdMicroteachAppraise, 8, "");
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
objSQL = clsvVideoLibAppraiseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvVideoLibAppraiseEN._CurrTabName, convVideoLibAppraise.IdMicroteachAppraise, 8, strPrefix);
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
 objSQL = clsvVideoLibAppraiseDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdMicroteachAppraise from vVideoLibAppraise where " + strCondition;
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
 objSQL = clsvVideoLibAppraiseDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdMicroteachAppraise from vVideoLibAppraise where " + strCondition;
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
 /// <param name = "lngIdMicroteachAppraise">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngIdMicroteachAppraise)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibAppraiseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vVideoLibAppraise", "IdMicroteachAppraise = " + ""+ lngIdMicroteachAppraise+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvVideoLibAppraiseDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibAppraiseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vVideoLibAppraise", strCondition))
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
objSQL = clsvVideoLibAppraiseDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vVideoLibAppraise");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseENS">源对象</param>
 /// <param name = "objvVideoLibAppraiseENT">目标对象</param>
public void CopyTo(clsvVideoLibAppraiseEN objvVideoLibAppraiseENS, clsvVideoLibAppraiseEN objvVideoLibAppraiseENT)
{
objvVideoLibAppraiseENT.IdMicroteachAppraise = objvVideoLibAppraiseENS.IdMicroteachAppraise; //评议流水号
objvVideoLibAppraiseENT.FuncModuleId = objvVideoLibAppraiseENS.FuncModuleId; //功能模块Id
objvVideoLibAppraiseENT.FuncModuleName = objvVideoLibAppraiseENS.FuncModuleName; //功能模块名称
objvVideoLibAppraiseENT.IdMicroteachCase = objvVideoLibAppraiseENS.IdMicroteachCase; //微格教学案例流水号
objvVideoLibAppraiseENT.IdVideoLib = objvVideoLibAppraiseENS.IdVideoLib; //视频库流水号
objvVideoLibAppraiseENT.VideoLibID = objvVideoLibAppraiseENS.VideoLibID; //视频库ID
objvVideoLibAppraiseENT.VideoLibName = objvVideoLibAppraiseENS.VideoLibName; //视频名称
objvVideoLibAppraiseENT.VideoLibTheme = objvVideoLibAppraiseENS.VideoLibTheme; //视频库主题词
objvVideoLibAppraiseENT.VideoLibTypeName = objvVideoLibAppraiseENS.VideoLibTypeName; //视频库类型名称
objvVideoLibAppraiseENT.VideoLibDate = objvVideoLibAppraiseENS.VideoLibDate; //视频资源日期
objvVideoLibAppraiseENT.VideoLibTime = objvVideoLibAppraiseENS.VideoLibTime; //视频资源时间
objvVideoLibAppraiseENT.VideoLibDateIn = objvVideoLibAppraiseENS.VideoLibDateIn; //案例入库日期
objvVideoLibAppraiseENT.VideoLibTimeIn = objvVideoLibAppraiseENS.VideoLibTimeIn; //案例入库时间
objvVideoLibAppraiseENT.IdXzCollege = objvVideoLibAppraiseENS.IdXzCollege; //学院流水号
objvVideoLibAppraiseENT.CollegeID = objvVideoLibAppraiseENS.CollegeID; //学院ID
objvVideoLibAppraiseENT.CollegeName = objvVideoLibAppraiseENS.CollegeName; //学院名称
objvVideoLibAppraiseENT.CourseId = objvVideoLibAppraiseENS.CourseId; //课程Id
objvVideoLibAppraiseENT.CourseCode = objvVideoLibAppraiseENS.CourseCode; //课程代码
objvVideoLibAppraiseENT.CourseName = objvVideoLibAppraiseENS.CourseName; //课程名称
objvVideoLibAppraiseENT.BrowseCount4Case = objvVideoLibAppraiseENS.BrowseCount4Case; //课例浏览次数
objvVideoLibAppraiseENT.IdAppraiseType = objvVideoLibAppraiseENS.IdAppraiseType; //评议类型流水号
objvVideoLibAppraiseENT.AppraiseTypeName = objvVideoLibAppraiseENS.AppraiseTypeName; //评议类型名称
objvVideoLibAppraiseENT.AppraiseTheme = objvVideoLibAppraiseENS.AppraiseTheme; //评议主题
objvVideoLibAppraiseENT.AppraiseContent = objvVideoLibAppraiseENS.AppraiseContent; //评议内容
objvVideoLibAppraiseENT.AppraiseDate = objvVideoLibAppraiseENS.AppraiseDate; //评议日期
objvVideoLibAppraiseENT.AppraiseTime = objvVideoLibAppraiseENS.AppraiseTime; //评议时间
objvVideoLibAppraiseENT.IsVisual = objvVideoLibAppraiseENS.IsVisual; //隐藏标志
objvVideoLibAppraiseENT.IsElite = objvVideoLibAppraiseENS.IsElite; //精华标志
objvVideoLibAppraiseENT.ExcellentOne = objvVideoLibAppraiseENS.ExcellentOne; //优点1
objvVideoLibAppraiseENT.ExcellentTwo = objvVideoLibAppraiseENS.ExcellentTwo; //优点2
objvVideoLibAppraiseENT.SuggestOne = objvVideoLibAppraiseENS.SuggestOne; //建议1
objvVideoLibAppraiseENT.SuggestTwo = objvVideoLibAppraiseENS.SuggestTwo; //建议2
objvVideoLibAppraiseENT.MicroteachAppriseScore = objvVideoLibAppraiseENS.MicroteachAppriseScore; //打分
objvVideoLibAppraiseENT.VideoStopTime = objvVideoLibAppraiseENS.VideoStopTime; //公开课案例视频暂停时间
objvVideoLibAppraiseENT.BrowseCount = objvVideoLibAppraiseENS.BrowseCount; //浏览次数
objvVideoLibAppraiseENT.UserId = objvVideoLibAppraiseENS.UserId; //用户ID
objvVideoLibAppraiseENT.UserName = objvVideoLibAppraiseENS.UserName; //用户名
objvVideoLibAppraiseENT.UserNameWithUserId = objvVideoLibAppraiseENS.UserNameWithUserId; //UserNameWithUserId
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvVideoLibAppraiseEN objvVideoLibAppraiseEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvVideoLibAppraiseEN.FuncModuleId, 4, convVideoLibAppraise.FuncModuleId);
clsCheckSql.CheckFieldLen(objvVideoLibAppraiseEN.FuncModuleName, 30, convVideoLibAppraise.FuncModuleName);
clsCheckSql.CheckFieldLen(objvVideoLibAppraiseEN.IdMicroteachCase, 8, convVideoLibAppraise.IdMicroteachCase);
clsCheckSql.CheckFieldLen(objvVideoLibAppraiseEN.IdVideoLib, 8, convVideoLibAppraise.IdVideoLib);
clsCheckSql.CheckFieldLen(objvVideoLibAppraiseEN.VideoLibID, 8, convVideoLibAppraise.VideoLibID);
clsCheckSql.CheckFieldLen(objvVideoLibAppraiseEN.VideoLibName, 100, convVideoLibAppraise.VideoLibName);
clsCheckSql.CheckFieldLen(objvVideoLibAppraiseEN.VideoLibTheme, 200, convVideoLibAppraise.VideoLibTheme);
clsCheckSql.CheckFieldLen(objvVideoLibAppraiseEN.VideoLibTypeName, 30, convVideoLibAppraise.VideoLibTypeName);
clsCheckSql.CheckFieldLen(objvVideoLibAppraiseEN.VideoLibDate, 20, convVideoLibAppraise.VideoLibDate);
clsCheckSql.CheckFieldLen(objvVideoLibAppraiseEN.VideoLibTime, 6, convVideoLibAppraise.VideoLibTime);
clsCheckSql.CheckFieldLen(objvVideoLibAppraiseEN.VideoLibDateIn, 8, convVideoLibAppraise.VideoLibDateIn);
clsCheckSql.CheckFieldLen(objvVideoLibAppraiseEN.VideoLibTimeIn, 6, convVideoLibAppraise.VideoLibTimeIn);
clsCheckSql.CheckFieldLen(objvVideoLibAppraiseEN.IdXzCollege, 4, convVideoLibAppraise.IdXzCollege);
clsCheckSql.CheckFieldLen(objvVideoLibAppraiseEN.CollegeID, 4, convVideoLibAppraise.CollegeID);
clsCheckSql.CheckFieldLen(objvVideoLibAppraiseEN.CollegeName, 100, convVideoLibAppraise.CollegeName);
clsCheckSql.CheckFieldLen(objvVideoLibAppraiseEN.CourseId, 8, convVideoLibAppraise.CourseId);
clsCheckSql.CheckFieldLen(objvVideoLibAppraiseEN.CourseCode, 20, convVideoLibAppraise.CourseCode);
clsCheckSql.CheckFieldLen(objvVideoLibAppraiseEN.CourseName, 100, convVideoLibAppraise.CourseName);
clsCheckSql.CheckFieldLen(objvVideoLibAppraiseEN.IdAppraiseType, 4, convVideoLibAppraise.IdAppraiseType);
clsCheckSql.CheckFieldLen(objvVideoLibAppraiseEN.AppraiseTypeName, 50, convVideoLibAppraise.AppraiseTypeName);
clsCheckSql.CheckFieldLen(objvVideoLibAppraiseEN.AppraiseTheme, 200, convVideoLibAppraise.AppraiseTheme);
clsCheckSql.CheckFieldLen(objvVideoLibAppraiseEN.AppraiseContent, 2000, convVideoLibAppraise.AppraiseContent);
clsCheckSql.CheckFieldLen(objvVideoLibAppraiseEN.AppraiseDate, 8, convVideoLibAppraise.AppraiseDate);
clsCheckSql.CheckFieldLen(objvVideoLibAppraiseEN.AppraiseTime, 6, convVideoLibAppraise.AppraiseTime);
clsCheckSql.CheckFieldLen(objvVideoLibAppraiseEN.ExcellentOne, 1000, convVideoLibAppraise.ExcellentOne);
clsCheckSql.CheckFieldLen(objvVideoLibAppraiseEN.ExcellentTwo, 1000, convVideoLibAppraise.ExcellentTwo);
clsCheckSql.CheckFieldLen(objvVideoLibAppraiseEN.SuggestOne, 1000, convVideoLibAppraise.SuggestOne);
clsCheckSql.CheckFieldLen(objvVideoLibAppraiseEN.SuggestTwo, 1000, convVideoLibAppraise.SuggestTwo);
clsCheckSql.CheckFieldLen(objvVideoLibAppraiseEN.VideoStopTime, 48, convVideoLibAppraise.VideoStopTime);
clsCheckSql.CheckFieldLen(objvVideoLibAppraiseEN.UserId, 18, convVideoLibAppraise.UserId);
clsCheckSql.CheckFieldLen(objvVideoLibAppraiseEN.UserName, 30, convVideoLibAppraise.UserName);
clsCheckSql.CheckFieldLen(objvVideoLibAppraiseEN.UserNameWithUserId, 51, convVideoLibAppraise.UserNameWithUserId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvVideoLibAppraiseEN.FuncModuleId, convVideoLibAppraise.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibAppraiseEN.FuncModuleName, convVideoLibAppraise.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibAppraiseEN.IdMicroteachCase, convVideoLibAppraise.IdMicroteachCase);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibAppraiseEN.IdVideoLib, convVideoLibAppraise.IdVideoLib);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibAppraiseEN.VideoLibID, convVideoLibAppraise.VideoLibID);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibAppraiseEN.VideoLibName, convVideoLibAppraise.VideoLibName);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibAppraiseEN.VideoLibTheme, convVideoLibAppraise.VideoLibTheme);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibAppraiseEN.VideoLibTypeName, convVideoLibAppraise.VideoLibTypeName);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibAppraiseEN.VideoLibDate, convVideoLibAppraise.VideoLibDate);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibAppraiseEN.VideoLibTime, convVideoLibAppraise.VideoLibTime);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibAppraiseEN.VideoLibDateIn, convVideoLibAppraise.VideoLibDateIn);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibAppraiseEN.VideoLibTimeIn, convVideoLibAppraise.VideoLibTimeIn);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibAppraiseEN.IdXzCollege, convVideoLibAppraise.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibAppraiseEN.CollegeID, convVideoLibAppraise.CollegeID);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibAppraiseEN.CollegeName, convVideoLibAppraise.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibAppraiseEN.CourseId, convVideoLibAppraise.CourseId);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibAppraiseEN.CourseCode, convVideoLibAppraise.CourseCode);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibAppraiseEN.CourseName, convVideoLibAppraise.CourseName);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibAppraiseEN.IdAppraiseType, convVideoLibAppraise.IdAppraiseType);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibAppraiseEN.AppraiseTypeName, convVideoLibAppraise.AppraiseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibAppraiseEN.AppraiseTheme, convVideoLibAppraise.AppraiseTheme);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibAppraiseEN.AppraiseContent, convVideoLibAppraise.AppraiseContent);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibAppraiseEN.AppraiseDate, convVideoLibAppraise.AppraiseDate);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibAppraiseEN.AppraiseTime, convVideoLibAppraise.AppraiseTime);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibAppraiseEN.ExcellentOne, convVideoLibAppraise.ExcellentOne);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibAppraiseEN.ExcellentTwo, convVideoLibAppraise.ExcellentTwo);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibAppraiseEN.SuggestOne, convVideoLibAppraise.SuggestOne);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibAppraiseEN.SuggestTwo, convVideoLibAppraise.SuggestTwo);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibAppraiseEN.VideoStopTime, convVideoLibAppraise.VideoStopTime);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibAppraiseEN.UserId, convVideoLibAppraise.UserId);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibAppraiseEN.UserName, convVideoLibAppraise.UserName);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibAppraiseEN.UserNameWithUserId, convVideoLibAppraise.UserNameWithUserId);
//检查外键字段长度
 objvVideoLibAppraiseEN._IsCheckProperty = true;
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
 objSQL = clsvVideoLibAppraiseDA.GetSpecSQLObj();
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
 objSQL = clsvVideoLibAppraiseDA.GetSpecSQLObj();
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
 objSQL = clsvVideoLibAppraiseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvVideoLibAppraiseEN._CurrTabName);
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
 objSQL = clsvVideoLibAppraiseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvVideoLibAppraiseEN._CurrTabName, strCondition);
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
 objSQL = clsvVideoLibAppraiseDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}