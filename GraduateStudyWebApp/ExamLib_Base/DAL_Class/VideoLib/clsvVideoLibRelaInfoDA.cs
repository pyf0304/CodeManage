
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvVideoLibRelaInfoDA
 表名:vVideoLibRelaInfo(01120405)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:50:46
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
 /// v视频库相关信息(vVideoLibRelaInfo)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvVideoLibRelaInfoDA : clsCommBase4DA
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
 return clsvVideoLibRelaInfoEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvVideoLibRelaInfoEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvVideoLibRelaInfoEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvVideoLibRelaInfoEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvVideoLibRelaInfoEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvVideoLibRelaInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vVideoLibRelaInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vVideoLibRelaInfo(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvVideoLibRelaInfoDA: GetDataTable_vVideoLibRelaInfo)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vVideoLibRelaInfo where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvVideoLibRelaInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibRelaInfoDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvVideoLibRelaInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vVideoLibRelaInfo where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvVideoLibRelaInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibRelaInfoDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvVideoLibRelaInfoDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibRelaInfoDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vVideoLibRelaInfo where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vVideoLibRelaInfo where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvVideoLibRelaInfoDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibRelaInfoDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vVideoLibRelaInfo where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvVideoLibRelaInfoDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibRelaInfoDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vVideoLibRelaInfo.* from vVideoLibRelaInfo Left Join {1} on {2} where {3} and vVideoLibRelaInfo.IdMicroTeachCaseRelaInfo not in (Select top {5} vVideoLibRelaInfo.IdMicroTeachCaseRelaInfo from vVideoLibRelaInfo Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vVideoLibRelaInfo where {1} and IdMicroTeachCaseRelaInfo not in (Select top {2} IdMicroTeachCaseRelaInfo from vVideoLibRelaInfo where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vVideoLibRelaInfo where {1} and IdMicroTeachCaseRelaInfo not in (Select top {3} IdMicroTeachCaseRelaInfo from vVideoLibRelaInfo where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvVideoLibRelaInfoDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibRelaInfoDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vVideoLibRelaInfo.* from vVideoLibRelaInfo Left Join {1} on {2} where {3} and vVideoLibRelaInfo.IdMicroTeachCaseRelaInfo not in (Select top {5} vVideoLibRelaInfo.IdMicroTeachCaseRelaInfo from vVideoLibRelaInfo Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vVideoLibRelaInfo where {1} and IdMicroTeachCaseRelaInfo not in (Select top {2} IdMicroTeachCaseRelaInfo from vVideoLibRelaInfo where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vVideoLibRelaInfo where {1} and IdMicroTeachCaseRelaInfo not in (Select top {3} IdMicroTeachCaseRelaInfo from vVideoLibRelaInfo where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvVideoLibRelaInfoEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvVideoLibRelaInfoDA:GetObjLst)", objException.Message));
}
List<clsvVideoLibRelaInfoEN> arrObjLst = new List<clsvVideoLibRelaInfoEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vVideoLibRelaInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN = new clsvVideoLibRelaInfoEN();
try
{
objvVideoLibRelaInfoEN.IdMicroTeachCaseRelaInfo = TransNullToInt(objRow[convVideoLibRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvVideoLibRelaInfoEN.FuncModuleId = objRow[convVideoLibRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoLibRelaInfoEN.FuncModuleName = objRow[convVideoLibRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoLibRelaInfoEN.IdMicroteachCase = objRow[convVideoLibRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoLibRelaInfoEN.IdVideoLib = objRow[convVideoLibRelaInfo.IdVideoLib] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdVideoLib].ToString().Trim(); //视频库流水号
objvVideoLibRelaInfoEN.VideoLibName = objRow[convVideoLibRelaInfo.VideoLibName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.VideoLibName].ToString().Trim(); //视频名称
objvVideoLibRelaInfoEN.IdXzCollege = objRow[convVideoLibRelaInfo.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLibRelaInfoEN.CollegeID = objRow[convVideoLibRelaInfo.CollegeID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CollegeID].ToString().Trim(); //学院ID
objvVideoLibRelaInfoEN.CollegeName = objRow[convVideoLibRelaInfo.CollegeName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CollegeName].ToString().Trim(); //学院名称
objvVideoLibRelaInfoEN.CollegeNameA = objRow[convVideoLibRelaInfo.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoLibRelaInfoEN.CourseId = objRow[convVideoLibRelaInfo.CourseId] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CourseId].ToString().Trim(); //课程Id
objvVideoLibRelaInfoEN.CourseCode = objRow[convVideoLibRelaInfo.CourseCode] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CourseCode].ToString().Trim(); //课程代码
objvVideoLibRelaInfoEN.CourseName = objRow[convVideoLibRelaInfo.CourseName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CourseName].ToString().Trim(); //课程名称
objvVideoLibRelaInfoEN.IdResource = objRow[convVideoLibRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvVideoLibRelaInfoEN.ResourceID = objRow[convVideoLibRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvVideoLibRelaInfoEN.SaveMode = TransNullToBool(objRow[convVideoLibRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvVideoLibRelaInfoEN.IdFtpResource = objRow[convVideoLibRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvVideoLibRelaInfoEN.FtpResourceID = objRow[convVideoLibRelaInfo.FtpResourceID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvVideoLibRelaInfoEN.FileOriginalName = objRow[convVideoLibRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvVideoLibRelaInfoEN.FileDirName = objRow[convVideoLibRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvVideoLibRelaInfoEN.FileRename = objRow[convVideoLibRelaInfo.FileRename] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileRename].ToString().Trim(); //文件新名
objvVideoLibRelaInfoEN.FileUpDate = objRow[convVideoLibRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvVideoLibRelaInfoEN.FileUpTime = objRow[convVideoLibRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvVideoLibRelaInfoEN.FileSize = objRow[convVideoLibRelaInfo.FileSize] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileSize].ToString().Trim(); //文件大小
objvVideoLibRelaInfoEN.FileType = objRow[convVideoLibRelaInfo.FileType] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileType].ToString().Trim(); //文件类型
objvVideoLibRelaInfoEN.ResourceOwner = objRow[convVideoLibRelaInfo.ResourceOwner] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvVideoLibRelaInfoEN.IsExistFile = TransNullToBool(objRow[convVideoLibRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvVideoLibRelaInfoEN.IdFile = objRow[convVideoLibRelaInfo.IdFile] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvVideoLibRelaInfoEN.FileName = objRow[convVideoLibRelaInfo.FileName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileName].ToString().Trim(); //文件名称
objvVideoLibRelaInfoEN.SaveDate = objRow[convVideoLibRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvVideoLibRelaInfoEN.SaveTime = objRow[convVideoLibRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvVideoLibRelaInfoEN.FileOriginName = objRow[convVideoLibRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvVideoLibRelaInfoEN.IdResourceType = objRow[convVideoLibRelaInfo.IdResourceType] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvVideoLibRelaInfoEN.ResourceTypeID = objRow[convVideoLibRelaInfo.ResourceTypeID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvVideoLibRelaInfoEN.ResourceTypeName = objRow[convVideoLibRelaInfo.ResourceTypeName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvVideoLibRelaInfoEN.FileNewName = objRow[convVideoLibRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvVideoLibRelaInfoEN.FileOldName = objRow[convVideoLibRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvVideoLibRelaInfoEN.ftpFileType = objRow[convVideoLibRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvVideoLibRelaInfoEN.ftpFileSize = objRow[convVideoLibRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvVideoLibRelaInfoEN.ftpResourceOwner = objRow[convVideoLibRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvVideoLibRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convVideoLibRelaInfo.IdMicroTeachCaseRelaInfoType] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvVideoLibRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objvVideoLibRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvVideoLibRelaInfoEN.IsVisible = TransNullToBool(objRow[convVideoLibRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvVideoLibRelaInfoEN.BrowseCount = objRow[convVideoLibRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLibRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvVideoLibRelaInfoEN.Flag = objRow[convVideoLibRelaInfo.Flag] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.Flag].ToString().Trim(); //标志
objvVideoLibRelaInfoEN.UpdDate = objRow[convVideoLibRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvVideoLibRelaInfoEN.UpdUser = objRow[convVideoLibRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.UpdUser].ToString().Trim(); //修改人
objvVideoLibRelaInfoEN.Memo = objRow[convVideoLibRelaInfo.Memo] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvVideoLibRelaInfoDA: GetObjLst)", objException.Message));
}
objvVideoLibRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvVideoLibRelaInfoEN);
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
public List<clsvVideoLibRelaInfoEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvVideoLibRelaInfoDA:GetObjLstByTabName)", objException.Message));
}
List<clsvVideoLibRelaInfoEN> arrObjLst = new List<clsvVideoLibRelaInfoEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibRelaInfoDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN = new clsvVideoLibRelaInfoEN();
try
{
objvVideoLibRelaInfoEN.IdMicroTeachCaseRelaInfo = TransNullToInt(objRow[convVideoLibRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvVideoLibRelaInfoEN.FuncModuleId = objRow[convVideoLibRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoLibRelaInfoEN.FuncModuleName = objRow[convVideoLibRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoLibRelaInfoEN.IdMicroteachCase = objRow[convVideoLibRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoLibRelaInfoEN.IdVideoLib = objRow[convVideoLibRelaInfo.IdVideoLib] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdVideoLib].ToString().Trim(); //视频库流水号
objvVideoLibRelaInfoEN.VideoLibName = objRow[convVideoLibRelaInfo.VideoLibName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.VideoLibName].ToString().Trim(); //视频名称
objvVideoLibRelaInfoEN.IdXzCollege = objRow[convVideoLibRelaInfo.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLibRelaInfoEN.CollegeID = objRow[convVideoLibRelaInfo.CollegeID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CollegeID].ToString().Trim(); //学院ID
objvVideoLibRelaInfoEN.CollegeName = objRow[convVideoLibRelaInfo.CollegeName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CollegeName].ToString().Trim(); //学院名称
objvVideoLibRelaInfoEN.CollegeNameA = objRow[convVideoLibRelaInfo.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoLibRelaInfoEN.CourseId = objRow[convVideoLibRelaInfo.CourseId] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CourseId].ToString().Trim(); //课程Id
objvVideoLibRelaInfoEN.CourseCode = objRow[convVideoLibRelaInfo.CourseCode] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CourseCode].ToString().Trim(); //课程代码
objvVideoLibRelaInfoEN.CourseName = objRow[convVideoLibRelaInfo.CourseName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CourseName].ToString().Trim(); //课程名称
objvVideoLibRelaInfoEN.IdResource = objRow[convVideoLibRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvVideoLibRelaInfoEN.ResourceID = objRow[convVideoLibRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvVideoLibRelaInfoEN.SaveMode = TransNullToBool(objRow[convVideoLibRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvVideoLibRelaInfoEN.IdFtpResource = objRow[convVideoLibRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvVideoLibRelaInfoEN.FtpResourceID = objRow[convVideoLibRelaInfo.FtpResourceID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvVideoLibRelaInfoEN.FileOriginalName = objRow[convVideoLibRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvVideoLibRelaInfoEN.FileDirName = objRow[convVideoLibRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvVideoLibRelaInfoEN.FileRename = objRow[convVideoLibRelaInfo.FileRename] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileRename].ToString().Trim(); //文件新名
objvVideoLibRelaInfoEN.FileUpDate = objRow[convVideoLibRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvVideoLibRelaInfoEN.FileUpTime = objRow[convVideoLibRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvVideoLibRelaInfoEN.FileSize = objRow[convVideoLibRelaInfo.FileSize] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileSize].ToString().Trim(); //文件大小
objvVideoLibRelaInfoEN.FileType = objRow[convVideoLibRelaInfo.FileType] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileType].ToString().Trim(); //文件类型
objvVideoLibRelaInfoEN.ResourceOwner = objRow[convVideoLibRelaInfo.ResourceOwner] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvVideoLibRelaInfoEN.IsExistFile = TransNullToBool(objRow[convVideoLibRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvVideoLibRelaInfoEN.IdFile = objRow[convVideoLibRelaInfo.IdFile] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvVideoLibRelaInfoEN.FileName = objRow[convVideoLibRelaInfo.FileName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileName].ToString().Trim(); //文件名称
objvVideoLibRelaInfoEN.SaveDate = objRow[convVideoLibRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvVideoLibRelaInfoEN.SaveTime = objRow[convVideoLibRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvVideoLibRelaInfoEN.FileOriginName = objRow[convVideoLibRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvVideoLibRelaInfoEN.IdResourceType = objRow[convVideoLibRelaInfo.IdResourceType] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvVideoLibRelaInfoEN.ResourceTypeID = objRow[convVideoLibRelaInfo.ResourceTypeID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvVideoLibRelaInfoEN.ResourceTypeName = objRow[convVideoLibRelaInfo.ResourceTypeName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvVideoLibRelaInfoEN.FileNewName = objRow[convVideoLibRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvVideoLibRelaInfoEN.FileOldName = objRow[convVideoLibRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvVideoLibRelaInfoEN.ftpFileType = objRow[convVideoLibRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvVideoLibRelaInfoEN.ftpFileSize = objRow[convVideoLibRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvVideoLibRelaInfoEN.ftpResourceOwner = objRow[convVideoLibRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvVideoLibRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convVideoLibRelaInfo.IdMicroTeachCaseRelaInfoType] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvVideoLibRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objvVideoLibRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvVideoLibRelaInfoEN.IsVisible = TransNullToBool(objRow[convVideoLibRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvVideoLibRelaInfoEN.BrowseCount = objRow[convVideoLibRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLibRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvVideoLibRelaInfoEN.Flag = objRow[convVideoLibRelaInfo.Flag] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.Flag].ToString().Trim(); //标志
objvVideoLibRelaInfoEN.UpdDate = objRow[convVideoLibRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvVideoLibRelaInfoEN.UpdUser = objRow[convVideoLibRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.UpdUser].ToString().Trim(); //修改人
objvVideoLibRelaInfoEN.Memo = objRow[convVideoLibRelaInfo.Memo] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvVideoLibRelaInfoDA: GetObjLst)", objException.Message));
}
objvVideoLibRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvVideoLibRelaInfoEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvVideoLibRelaInfo(ref clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vVideoLibRelaInfo where IdMicroTeachCaseRelaInfo = " + ""+ objvVideoLibRelaInfoEN.IdMicroTeachCaseRelaInfo+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvVideoLibRelaInfoEN.IdMicroTeachCaseRelaInfo = TransNullToInt(objDT.Rows[0][convVideoLibRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvVideoLibRelaInfoEN.FuncModuleId = objDT.Rows[0][convVideoLibRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvVideoLibRelaInfoEN.FuncModuleName = objDT.Rows[0][convVideoLibRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvVideoLibRelaInfoEN.IdMicroteachCase = objDT.Rows[0][convVideoLibRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoLibRelaInfoEN.IdVideoLib = objDT.Rows[0][convVideoLibRelaInfo.IdVideoLib].ToString().Trim(); //视频库流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoLibRelaInfoEN.VideoLibName = objDT.Rows[0][convVideoLibRelaInfo.VideoLibName].ToString().Trim(); //视频名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvVideoLibRelaInfoEN.IdXzCollege = objDT.Rows[0][convVideoLibRelaInfo.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvVideoLibRelaInfoEN.CollegeID = objDT.Rows[0][convVideoLibRelaInfo.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvVideoLibRelaInfoEN.CollegeName = objDT.Rows[0][convVideoLibRelaInfo.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvVideoLibRelaInfoEN.CollegeNameA = objDT.Rows[0][convVideoLibRelaInfo.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvVideoLibRelaInfoEN.CourseId = objDT.Rows[0][convVideoLibRelaInfo.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvVideoLibRelaInfoEN.CourseCode = objDT.Rows[0][convVideoLibRelaInfo.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvVideoLibRelaInfoEN.CourseName = objDT.Rows[0][convVideoLibRelaInfo.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvVideoLibRelaInfoEN.IdResource = objDT.Rows[0][convVideoLibRelaInfo.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoLibRelaInfoEN.ResourceID = objDT.Rows[0][convVideoLibRelaInfo.ResourceID].ToString().Trim(); //资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvVideoLibRelaInfoEN.SaveMode = TransNullToBool(objDT.Rows[0][convVideoLibRelaInfo.SaveMode].ToString().Trim()); //文件存放方式(字段类型:bit,字段长度:1,是否可空:True)
 objvVideoLibRelaInfoEN.IdFtpResource = objDT.Rows[0][convVideoLibRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objvVideoLibRelaInfoEN.FtpResourceID = objDT.Rows[0][convVideoLibRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvVideoLibRelaInfoEN.FileOriginalName = objDT.Rows[0][convVideoLibRelaInfo.FileOriginalName].ToString().Trim(); //文件原名(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoLibRelaInfoEN.FileDirName = objDT.Rows[0][convVideoLibRelaInfo.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoLibRelaInfoEN.FileRename = objDT.Rows[0][convVideoLibRelaInfo.FileRename].ToString().Trim(); //文件新名(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoLibRelaInfoEN.FileUpDate = objDT.Rows[0][convVideoLibRelaInfo.FileUpDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvVideoLibRelaInfoEN.FileUpTime = objDT.Rows[0][convVideoLibRelaInfo.FileUpTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvVideoLibRelaInfoEN.FileSize = objDT.Rows[0][convVideoLibRelaInfo.FileSize].ToString().Trim(); //文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvVideoLibRelaInfoEN.FileType = objDT.Rows[0][convVideoLibRelaInfo.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvVideoLibRelaInfoEN.ResourceOwner = objDT.Rows[0][convVideoLibRelaInfo.ResourceOwner].ToString().Trim(); //上传者(字段类型:varchar,字段长度:50,是否可空:False)
 objvVideoLibRelaInfoEN.IsExistFile = TransNullToBool(objDT.Rows[0][convVideoLibRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objvVideoLibRelaInfoEN.IdFile = objDT.Rows[0][convVideoLibRelaInfo.IdFile].ToString().Trim(); //文件流水号(字段类型:char,字段长度:8,是否可空:True)
 objvVideoLibRelaInfoEN.FileName = objDT.Rows[0][convVideoLibRelaInfo.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvVideoLibRelaInfoEN.SaveDate = objDT.Rows[0][convVideoLibRelaInfo.SaveDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvVideoLibRelaInfoEN.SaveTime = objDT.Rows[0][convVideoLibRelaInfo.SaveTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvVideoLibRelaInfoEN.FileOriginName = objDT.Rows[0][convVideoLibRelaInfo.FileOriginName].ToString().Trim(); //原文件名(字段类型:varchar,字段长度:500,是否可空:True)
 objvVideoLibRelaInfoEN.IdResourceType = objDT.Rows[0][convVideoLibRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvVideoLibRelaInfoEN.ResourceTypeID = objDT.Rows[0][convVideoLibRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvVideoLibRelaInfoEN.ResourceTypeName = objDT.Rows[0][convVideoLibRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvVideoLibRelaInfoEN.FileNewName = objDT.Rows[0][convVideoLibRelaInfo.FileNewName].ToString().Trim(); //新文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvVideoLibRelaInfoEN.FileOldName = objDT.Rows[0][convVideoLibRelaInfo.FileOldName].ToString().Trim(); //旧文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvVideoLibRelaInfoEN.ftpFileType = objDT.Rows[0][convVideoLibRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvVideoLibRelaInfoEN.ftpFileSize = objDT.Rows[0][convVideoLibRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvVideoLibRelaInfoEN.ftpResourceOwner = objDT.Rows[0][convVideoLibRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者(字段类型:varchar,字段长度:50,是否可空:True)
 objvVideoLibRelaInfoEN.IdMicroTeachCaseRelaInfoType = objDT.Rows[0][convVideoLibRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvVideoLibRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objDT.Rows[0][convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvVideoLibRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objDT.Rows[0][convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvVideoLibRelaInfoEN.IsVisible = TransNullToBool(objDT.Rows[0][convVideoLibRelaInfo.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvVideoLibRelaInfoEN.BrowseCount = TransNullToInt(objDT.Rows[0][convVideoLibRelaInfo.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvVideoLibRelaInfoEN.Flag = objDT.Rows[0][convVideoLibRelaInfo.Flag].ToString().Trim(); //标志(字段类型:varchar,字段长度:50,是否可空:True)
 objvVideoLibRelaInfoEN.UpdDate = objDT.Rows[0][convVideoLibRelaInfo.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvVideoLibRelaInfoEN.UpdUser = objDT.Rows[0][convVideoLibRelaInfo.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvVideoLibRelaInfoEN.Memo = objDT.Rows[0][convVideoLibRelaInfo.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvVideoLibRelaInfoDA: GetvVideoLibRelaInfo)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdMicroTeachCaseRelaInfo">表关键字</param>
 /// <returns>表对象</returns>
public clsvVideoLibRelaInfoEN GetObjByIdMicroTeachCaseRelaInfo(long lngIdMicroTeachCaseRelaInfo)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vVideoLibRelaInfo where IdMicroTeachCaseRelaInfo = " + ""+ lngIdMicroTeachCaseRelaInfo+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN = new clsvVideoLibRelaInfoEN();
try
{
 objvVideoLibRelaInfoEN.IdMicroTeachCaseRelaInfo = Int32.Parse(objRow[convVideoLibRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvVideoLibRelaInfoEN.FuncModuleId = objRow[convVideoLibRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvVideoLibRelaInfoEN.FuncModuleName = objRow[convVideoLibRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvVideoLibRelaInfoEN.IdMicroteachCase = objRow[convVideoLibRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoLibRelaInfoEN.IdVideoLib = objRow[convVideoLibRelaInfo.IdVideoLib] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdVideoLib].ToString().Trim(); //视频库流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoLibRelaInfoEN.VideoLibName = objRow[convVideoLibRelaInfo.VideoLibName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.VideoLibName].ToString().Trim(); //视频名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvVideoLibRelaInfoEN.IdXzCollege = objRow[convVideoLibRelaInfo.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvVideoLibRelaInfoEN.CollegeID = objRow[convVideoLibRelaInfo.CollegeID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvVideoLibRelaInfoEN.CollegeName = objRow[convVideoLibRelaInfo.CollegeName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvVideoLibRelaInfoEN.CollegeNameA = objRow[convVideoLibRelaInfo.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvVideoLibRelaInfoEN.CourseId = objRow[convVideoLibRelaInfo.CourseId] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvVideoLibRelaInfoEN.CourseCode = objRow[convVideoLibRelaInfo.CourseCode] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvVideoLibRelaInfoEN.CourseName = objRow[convVideoLibRelaInfo.CourseName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvVideoLibRelaInfoEN.IdResource = objRow[convVideoLibRelaInfo.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoLibRelaInfoEN.ResourceID = objRow[convVideoLibRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ResourceID].ToString().Trim(); //资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvVideoLibRelaInfoEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convVideoLibRelaInfo.SaveMode].ToString().Trim()); //文件存放方式(字段类型:bit,字段长度:1,是否可空:True)
 objvVideoLibRelaInfoEN.IdFtpResource = objRow[convVideoLibRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objvVideoLibRelaInfoEN.FtpResourceID = objRow[convVideoLibRelaInfo.FtpResourceID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvVideoLibRelaInfoEN.FileOriginalName = objRow[convVideoLibRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileOriginalName].ToString().Trim(); //文件原名(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoLibRelaInfoEN.FileDirName = objRow[convVideoLibRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoLibRelaInfoEN.FileRename = objRow[convVideoLibRelaInfo.FileRename] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileRename].ToString().Trim(); //文件新名(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoLibRelaInfoEN.FileUpDate = objRow[convVideoLibRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileUpDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvVideoLibRelaInfoEN.FileUpTime = objRow[convVideoLibRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileUpTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvVideoLibRelaInfoEN.FileSize = objRow[convVideoLibRelaInfo.FileSize] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileSize].ToString().Trim(); //文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvVideoLibRelaInfoEN.FileType = objRow[convVideoLibRelaInfo.FileType] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvVideoLibRelaInfoEN.ResourceOwner = objRow[convVideoLibRelaInfo.ResourceOwner] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ResourceOwner].ToString().Trim(); //上传者(字段类型:varchar,字段长度:50,是否可空:False)
 objvVideoLibRelaInfoEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convVideoLibRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objvVideoLibRelaInfoEN.IdFile = objRow[convVideoLibRelaInfo.IdFile] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdFile].ToString().Trim(); //文件流水号(字段类型:char,字段长度:8,是否可空:True)
 objvVideoLibRelaInfoEN.FileName = objRow[convVideoLibRelaInfo.FileName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvVideoLibRelaInfoEN.SaveDate = objRow[convVideoLibRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.SaveDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvVideoLibRelaInfoEN.SaveTime = objRow[convVideoLibRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.SaveTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvVideoLibRelaInfoEN.FileOriginName = objRow[convVideoLibRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileOriginName].ToString().Trim(); //原文件名(字段类型:varchar,字段长度:500,是否可空:True)
 objvVideoLibRelaInfoEN.IdResourceType = objRow[convVideoLibRelaInfo.IdResourceType] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvVideoLibRelaInfoEN.ResourceTypeID = objRow[convVideoLibRelaInfo.ResourceTypeID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvVideoLibRelaInfoEN.ResourceTypeName = objRow[convVideoLibRelaInfo.ResourceTypeName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvVideoLibRelaInfoEN.FileNewName = objRow[convVideoLibRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileNewName].ToString().Trim(); //新文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvVideoLibRelaInfoEN.FileOldName = objRow[convVideoLibRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileOldName].ToString().Trim(); //旧文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvVideoLibRelaInfoEN.ftpFileType = objRow[convVideoLibRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvVideoLibRelaInfoEN.ftpFileSize = objRow[convVideoLibRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvVideoLibRelaInfoEN.ftpResourceOwner = objRow[convVideoLibRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者(字段类型:varchar,字段长度:50,是否可空:True)
 objvVideoLibRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convVideoLibRelaInfo.IdMicroTeachCaseRelaInfoType] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvVideoLibRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvVideoLibRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvVideoLibRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convVideoLibRelaInfo.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvVideoLibRelaInfoEN.BrowseCount = objRow[convVideoLibRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibRelaInfo.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvVideoLibRelaInfoEN.Flag = objRow[convVideoLibRelaInfo.Flag] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.Flag].ToString().Trim(); //标志(字段类型:varchar,字段长度:50,是否可空:True)
 objvVideoLibRelaInfoEN.UpdDate = objRow[convVideoLibRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvVideoLibRelaInfoEN.UpdUser = objRow[convVideoLibRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvVideoLibRelaInfoEN.Memo = objRow[convVideoLibRelaInfo.Memo] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvVideoLibRelaInfoDA: GetObjByIdMicroTeachCaseRelaInfo)", objException.Message));
}
return objvVideoLibRelaInfoEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvVideoLibRelaInfoEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvVideoLibRelaInfoDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vVideoLibRelaInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN = new clsvVideoLibRelaInfoEN()
{
IdMicroTeachCaseRelaInfo = TransNullToInt(objRow[convVideoLibRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()), //案例相关信息流水号
FuncModuleId = objRow[convVideoLibRelaInfo.FuncModuleId].ToString().Trim(), //功能模块Id
FuncModuleName = objRow[convVideoLibRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FuncModuleName].ToString().Trim(), //功能模块名称
IdMicroteachCase = objRow[convVideoLibRelaInfo.IdMicroteachCase].ToString().Trim(), //微格教学案例流水号
IdVideoLib = objRow[convVideoLibRelaInfo.IdVideoLib] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdVideoLib].ToString().Trim(), //视频库流水号
VideoLibName = objRow[convVideoLibRelaInfo.VideoLibName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.VideoLibName].ToString().Trim(), //视频名称
IdXzCollege = objRow[convVideoLibRelaInfo.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdXzCollege].ToString().Trim(), //学院流水号
CollegeID = objRow[convVideoLibRelaInfo.CollegeID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CollegeID].ToString().Trim(), //学院ID
CollegeName = objRow[convVideoLibRelaInfo.CollegeName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CollegeName].ToString().Trim(), //学院名称
CollegeNameA = objRow[convVideoLibRelaInfo.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CollegeNameA].ToString().Trim(), //学院名称简写
CourseId = objRow[convVideoLibRelaInfo.CourseId] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CourseId].ToString().Trim(), //课程Id
CourseCode = objRow[convVideoLibRelaInfo.CourseCode] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CourseCode].ToString().Trim(), //课程代码
CourseName = objRow[convVideoLibRelaInfo.CourseName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CourseName].ToString().Trim(), //课程名称
IdResource = objRow[convVideoLibRelaInfo.IdResource].ToString().Trim(), //资源流水号
ResourceID = objRow[convVideoLibRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ResourceID].ToString().Trim(), //资源ID
SaveMode = TransNullToBool(objRow[convVideoLibRelaInfo.SaveMode].ToString().Trim()), //文件存放方式
IdFtpResource = objRow[convVideoLibRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdFtpResource].ToString().Trim(), //FTP资源流水号
FtpResourceID = objRow[convVideoLibRelaInfo.FtpResourceID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FtpResourceID].ToString().Trim(), //FTP资源ID
FileOriginalName = objRow[convVideoLibRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileOriginalName].ToString().Trim(), //文件原名
FileDirName = objRow[convVideoLibRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileDirName].ToString().Trim(), //文件目录名
FileRename = objRow[convVideoLibRelaInfo.FileRename] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileRename].ToString().Trim(), //文件新名
FileUpDate = objRow[convVideoLibRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileUpDate].ToString().Trim(), //创建日期
FileUpTime = objRow[convVideoLibRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileUpTime].ToString().Trim(), //创建时间
FileSize = objRow[convVideoLibRelaInfo.FileSize] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileSize].ToString().Trim(), //文件大小
FileType = objRow[convVideoLibRelaInfo.FileType] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileType].ToString().Trim(), //文件类型
ResourceOwner = objRow[convVideoLibRelaInfo.ResourceOwner] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ResourceOwner].ToString().Trim(), //上传者
IsExistFile = TransNullToBool(objRow[convVideoLibRelaInfo.IsExistFile].ToString().Trim()), //是否存在文件
IdFile = objRow[convVideoLibRelaInfo.IdFile] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdFile].ToString().Trim(), //文件流水号
FileName = objRow[convVideoLibRelaInfo.FileName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileName].ToString().Trim(), //文件名称
SaveDate = objRow[convVideoLibRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.SaveDate].ToString().Trim(), //创建日期
SaveTime = objRow[convVideoLibRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.SaveTime].ToString().Trim(), //创建时间
FileOriginName = objRow[convVideoLibRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileOriginName].ToString().Trim(), //原文件名
IdResourceType = objRow[convVideoLibRelaInfo.IdResourceType] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdResourceType].ToString().Trim(), //资源类型流水号
ResourceTypeID = objRow[convVideoLibRelaInfo.ResourceTypeID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ResourceTypeID].ToString().Trim(), //资源类型ID
ResourceTypeName = objRow[convVideoLibRelaInfo.ResourceTypeName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ResourceTypeName].ToString().Trim(), //资源类型名称
FileNewName = objRow[convVideoLibRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileNewName].ToString().Trim(), //新文件名
FileOldName = objRow[convVideoLibRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileOldName].ToString().Trim(), //旧文件名
ftpFileType = objRow[convVideoLibRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ftpFileType].ToString().Trim(), //ftp文件类型
ftpFileSize = objRow[convVideoLibRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ftpFileSize].ToString().Trim(), //ftp文件大小
ftpResourceOwner = objRow[convVideoLibRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ftpResourceOwner].ToString().Trim(), //Ftp资源拥有者
IdMicroTeachCaseRelaInfoType = objRow[convVideoLibRelaInfo.IdMicroTeachCaseRelaInfoType] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(), //微格案例相关信息类型流水号
MicroTeachCaseRelaInfoTypeID = objRow[convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(), //微格案例相关信息类型ID
MicroTeachCaseRelaInfoTypeName = objRow[convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(), //微格案例相关信息类型名称
IsVisible = TransNullToBool(objRow[convVideoLibRelaInfo.IsVisible].ToString().Trim()), //是否显示
BrowseCount = objRow[convVideoLibRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLibRelaInfo.BrowseCount].ToString().Trim()), //浏览次数
Flag = objRow[convVideoLibRelaInfo.Flag] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.Flag].ToString().Trim(), //标志
UpdDate = objRow[convVideoLibRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convVideoLibRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convVideoLibRelaInfo.Memo] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.Memo].ToString().Trim() //备注
};
objvVideoLibRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvVideoLibRelaInfoEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvVideoLibRelaInfoDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvVideoLibRelaInfoEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN = new clsvVideoLibRelaInfoEN();
try
{
objvVideoLibRelaInfoEN.IdMicroTeachCaseRelaInfo = TransNullToInt(objRow[convVideoLibRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvVideoLibRelaInfoEN.FuncModuleId = objRow[convVideoLibRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoLibRelaInfoEN.FuncModuleName = objRow[convVideoLibRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoLibRelaInfoEN.IdMicroteachCase = objRow[convVideoLibRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoLibRelaInfoEN.IdVideoLib = objRow[convVideoLibRelaInfo.IdVideoLib] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdVideoLib].ToString().Trim(); //视频库流水号
objvVideoLibRelaInfoEN.VideoLibName = objRow[convVideoLibRelaInfo.VideoLibName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.VideoLibName].ToString().Trim(); //视频名称
objvVideoLibRelaInfoEN.IdXzCollege = objRow[convVideoLibRelaInfo.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLibRelaInfoEN.CollegeID = objRow[convVideoLibRelaInfo.CollegeID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CollegeID].ToString().Trim(); //学院ID
objvVideoLibRelaInfoEN.CollegeName = objRow[convVideoLibRelaInfo.CollegeName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CollegeName].ToString().Trim(); //学院名称
objvVideoLibRelaInfoEN.CollegeNameA = objRow[convVideoLibRelaInfo.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoLibRelaInfoEN.CourseId = objRow[convVideoLibRelaInfo.CourseId] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CourseId].ToString().Trim(); //课程Id
objvVideoLibRelaInfoEN.CourseCode = objRow[convVideoLibRelaInfo.CourseCode] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CourseCode].ToString().Trim(); //课程代码
objvVideoLibRelaInfoEN.CourseName = objRow[convVideoLibRelaInfo.CourseName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CourseName].ToString().Trim(); //课程名称
objvVideoLibRelaInfoEN.IdResource = objRow[convVideoLibRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvVideoLibRelaInfoEN.ResourceID = objRow[convVideoLibRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvVideoLibRelaInfoEN.SaveMode = TransNullToBool(objRow[convVideoLibRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvVideoLibRelaInfoEN.IdFtpResource = objRow[convVideoLibRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvVideoLibRelaInfoEN.FtpResourceID = objRow[convVideoLibRelaInfo.FtpResourceID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvVideoLibRelaInfoEN.FileOriginalName = objRow[convVideoLibRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvVideoLibRelaInfoEN.FileDirName = objRow[convVideoLibRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvVideoLibRelaInfoEN.FileRename = objRow[convVideoLibRelaInfo.FileRename] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileRename].ToString().Trim(); //文件新名
objvVideoLibRelaInfoEN.FileUpDate = objRow[convVideoLibRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvVideoLibRelaInfoEN.FileUpTime = objRow[convVideoLibRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvVideoLibRelaInfoEN.FileSize = objRow[convVideoLibRelaInfo.FileSize] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileSize].ToString().Trim(); //文件大小
objvVideoLibRelaInfoEN.FileType = objRow[convVideoLibRelaInfo.FileType] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileType].ToString().Trim(); //文件类型
objvVideoLibRelaInfoEN.ResourceOwner = objRow[convVideoLibRelaInfo.ResourceOwner] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvVideoLibRelaInfoEN.IsExistFile = TransNullToBool(objRow[convVideoLibRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvVideoLibRelaInfoEN.IdFile = objRow[convVideoLibRelaInfo.IdFile] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvVideoLibRelaInfoEN.FileName = objRow[convVideoLibRelaInfo.FileName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileName].ToString().Trim(); //文件名称
objvVideoLibRelaInfoEN.SaveDate = objRow[convVideoLibRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvVideoLibRelaInfoEN.SaveTime = objRow[convVideoLibRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvVideoLibRelaInfoEN.FileOriginName = objRow[convVideoLibRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvVideoLibRelaInfoEN.IdResourceType = objRow[convVideoLibRelaInfo.IdResourceType] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvVideoLibRelaInfoEN.ResourceTypeID = objRow[convVideoLibRelaInfo.ResourceTypeID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvVideoLibRelaInfoEN.ResourceTypeName = objRow[convVideoLibRelaInfo.ResourceTypeName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvVideoLibRelaInfoEN.FileNewName = objRow[convVideoLibRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvVideoLibRelaInfoEN.FileOldName = objRow[convVideoLibRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvVideoLibRelaInfoEN.ftpFileType = objRow[convVideoLibRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvVideoLibRelaInfoEN.ftpFileSize = objRow[convVideoLibRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvVideoLibRelaInfoEN.ftpResourceOwner = objRow[convVideoLibRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvVideoLibRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convVideoLibRelaInfo.IdMicroTeachCaseRelaInfoType] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvVideoLibRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objvVideoLibRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvVideoLibRelaInfoEN.IsVisible = TransNullToBool(objRow[convVideoLibRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvVideoLibRelaInfoEN.BrowseCount = objRow[convVideoLibRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLibRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvVideoLibRelaInfoEN.Flag = objRow[convVideoLibRelaInfo.Flag] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.Flag].ToString().Trim(); //标志
objvVideoLibRelaInfoEN.UpdDate = objRow[convVideoLibRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvVideoLibRelaInfoEN.UpdUser = objRow[convVideoLibRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.UpdUser].ToString().Trim(); //修改人
objvVideoLibRelaInfoEN.Memo = objRow[convVideoLibRelaInfo.Memo] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvVideoLibRelaInfoDA: GetObjByDataRowvVideoLibRelaInfo)", objException.Message));
}
objvVideoLibRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvVideoLibRelaInfoEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvVideoLibRelaInfoEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN = new clsvVideoLibRelaInfoEN();
try
{
objvVideoLibRelaInfoEN.IdMicroTeachCaseRelaInfo = TransNullToInt(objRow[convVideoLibRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvVideoLibRelaInfoEN.FuncModuleId = objRow[convVideoLibRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoLibRelaInfoEN.FuncModuleName = objRow[convVideoLibRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoLibRelaInfoEN.IdMicroteachCase = objRow[convVideoLibRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoLibRelaInfoEN.IdVideoLib = objRow[convVideoLibRelaInfo.IdVideoLib] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdVideoLib].ToString().Trim(); //视频库流水号
objvVideoLibRelaInfoEN.VideoLibName = objRow[convVideoLibRelaInfo.VideoLibName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.VideoLibName].ToString().Trim(); //视频名称
objvVideoLibRelaInfoEN.IdXzCollege = objRow[convVideoLibRelaInfo.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLibRelaInfoEN.CollegeID = objRow[convVideoLibRelaInfo.CollegeID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CollegeID].ToString().Trim(); //学院ID
objvVideoLibRelaInfoEN.CollegeName = objRow[convVideoLibRelaInfo.CollegeName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CollegeName].ToString().Trim(); //学院名称
objvVideoLibRelaInfoEN.CollegeNameA = objRow[convVideoLibRelaInfo.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoLibRelaInfoEN.CourseId = objRow[convVideoLibRelaInfo.CourseId] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CourseId].ToString().Trim(); //课程Id
objvVideoLibRelaInfoEN.CourseCode = objRow[convVideoLibRelaInfo.CourseCode] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CourseCode].ToString().Trim(); //课程代码
objvVideoLibRelaInfoEN.CourseName = objRow[convVideoLibRelaInfo.CourseName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CourseName].ToString().Trim(); //课程名称
objvVideoLibRelaInfoEN.IdResource = objRow[convVideoLibRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvVideoLibRelaInfoEN.ResourceID = objRow[convVideoLibRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvVideoLibRelaInfoEN.SaveMode = TransNullToBool(objRow[convVideoLibRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvVideoLibRelaInfoEN.IdFtpResource = objRow[convVideoLibRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvVideoLibRelaInfoEN.FtpResourceID = objRow[convVideoLibRelaInfo.FtpResourceID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvVideoLibRelaInfoEN.FileOriginalName = objRow[convVideoLibRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvVideoLibRelaInfoEN.FileDirName = objRow[convVideoLibRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvVideoLibRelaInfoEN.FileRename = objRow[convVideoLibRelaInfo.FileRename] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileRename].ToString().Trim(); //文件新名
objvVideoLibRelaInfoEN.FileUpDate = objRow[convVideoLibRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvVideoLibRelaInfoEN.FileUpTime = objRow[convVideoLibRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvVideoLibRelaInfoEN.FileSize = objRow[convVideoLibRelaInfo.FileSize] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileSize].ToString().Trim(); //文件大小
objvVideoLibRelaInfoEN.FileType = objRow[convVideoLibRelaInfo.FileType] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileType].ToString().Trim(); //文件类型
objvVideoLibRelaInfoEN.ResourceOwner = objRow[convVideoLibRelaInfo.ResourceOwner] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvVideoLibRelaInfoEN.IsExistFile = TransNullToBool(objRow[convVideoLibRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvVideoLibRelaInfoEN.IdFile = objRow[convVideoLibRelaInfo.IdFile] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvVideoLibRelaInfoEN.FileName = objRow[convVideoLibRelaInfo.FileName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileName].ToString().Trim(); //文件名称
objvVideoLibRelaInfoEN.SaveDate = objRow[convVideoLibRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvVideoLibRelaInfoEN.SaveTime = objRow[convVideoLibRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvVideoLibRelaInfoEN.FileOriginName = objRow[convVideoLibRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvVideoLibRelaInfoEN.IdResourceType = objRow[convVideoLibRelaInfo.IdResourceType] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvVideoLibRelaInfoEN.ResourceTypeID = objRow[convVideoLibRelaInfo.ResourceTypeID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvVideoLibRelaInfoEN.ResourceTypeName = objRow[convVideoLibRelaInfo.ResourceTypeName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvVideoLibRelaInfoEN.FileNewName = objRow[convVideoLibRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvVideoLibRelaInfoEN.FileOldName = objRow[convVideoLibRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvVideoLibRelaInfoEN.ftpFileType = objRow[convVideoLibRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvVideoLibRelaInfoEN.ftpFileSize = objRow[convVideoLibRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvVideoLibRelaInfoEN.ftpResourceOwner = objRow[convVideoLibRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvVideoLibRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convVideoLibRelaInfo.IdMicroTeachCaseRelaInfoType] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvVideoLibRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objvVideoLibRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvVideoLibRelaInfoEN.IsVisible = TransNullToBool(objRow[convVideoLibRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvVideoLibRelaInfoEN.BrowseCount = objRow[convVideoLibRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLibRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvVideoLibRelaInfoEN.Flag = objRow[convVideoLibRelaInfo.Flag] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.Flag].ToString().Trim(); //标志
objvVideoLibRelaInfoEN.UpdDate = objRow[convVideoLibRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvVideoLibRelaInfoEN.UpdUser = objRow[convVideoLibRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.UpdUser].ToString().Trim(); //修改人
objvVideoLibRelaInfoEN.Memo = objRow[convVideoLibRelaInfo.Memo] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvVideoLibRelaInfoDA: GetObjByDataRow)", objException.Message));
}
objvVideoLibRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvVideoLibRelaInfoEN;
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
objSQL = clsvVideoLibRelaInfoDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvVideoLibRelaInfoEN._CurrTabName, convVideoLibRelaInfo.IdMicroTeachCaseRelaInfo, 8, "");
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
objSQL = clsvVideoLibRelaInfoDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvVideoLibRelaInfoEN._CurrTabName, convVideoLibRelaInfo.IdMicroTeachCaseRelaInfo, 8, strPrefix);
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
 objSQL = clsvVideoLibRelaInfoDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdMicroTeachCaseRelaInfo from vVideoLibRelaInfo where " + strCondition;
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
 objSQL = clsvVideoLibRelaInfoDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdMicroTeachCaseRelaInfo from vVideoLibRelaInfo where " + strCondition;
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
 objSQL = clsvVideoLibRelaInfoDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vVideoLibRelaInfo", "IdMicroTeachCaseRelaInfo = " + ""+ lngIdMicroTeachCaseRelaInfo+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvVideoLibRelaInfoDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibRelaInfoDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vVideoLibRelaInfo", strCondition))
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
objSQL = clsvVideoLibRelaInfoDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vVideoLibRelaInfo");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoENS">源对象</param>
 /// <param name = "objvVideoLibRelaInfoENT">目标对象</param>
public void CopyTo(clsvVideoLibRelaInfoEN objvVideoLibRelaInfoENS, clsvVideoLibRelaInfoEN objvVideoLibRelaInfoENT)
{
objvVideoLibRelaInfoENT.IdMicroTeachCaseRelaInfo = objvVideoLibRelaInfoENS.IdMicroTeachCaseRelaInfo; //案例相关信息流水号
objvVideoLibRelaInfoENT.FuncModuleId = objvVideoLibRelaInfoENS.FuncModuleId; //功能模块Id
objvVideoLibRelaInfoENT.FuncModuleName = objvVideoLibRelaInfoENS.FuncModuleName; //功能模块名称
objvVideoLibRelaInfoENT.IdMicroteachCase = objvVideoLibRelaInfoENS.IdMicroteachCase; //微格教学案例流水号
objvVideoLibRelaInfoENT.IdVideoLib = objvVideoLibRelaInfoENS.IdVideoLib; //视频库流水号
objvVideoLibRelaInfoENT.VideoLibName = objvVideoLibRelaInfoENS.VideoLibName; //视频名称
objvVideoLibRelaInfoENT.IdXzCollege = objvVideoLibRelaInfoENS.IdXzCollege; //学院流水号
objvVideoLibRelaInfoENT.CollegeID = objvVideoLibRelaInfoENS.CollegeID; //学院ID
objvVideoLibRelaInfoENT.CollegeName = objvVideoLibRelaInfoENS.CollegeName; //学院名称
objvVideoLibRelaInfoENT.CollegeNameA = objvVideoLibRelaInfoENS.CollegeNameA; //学院名称简写
objvVideoLibRelaInfoENT.CourseId = objvVideoLibRelaInfoENS.CourseId; //课程Id
objvVideoLibRelaInfoENT.CourseCode = objvVideoLibRelaInfoENS.CourseCode; //课程代码
objvVideoLibRelaInfoENT.CourseName = objvVideoLibRelaInfoENS.CourseName; //课程名称
objvVideoLibRelaInfoENT.IdResource = objvVideoLibRelaInfoENS.IdResource; //资源流水号
objvVideoLibRelaInfoENT.ResourceID = objvVideoLibRelaInfoENS.ResourceID; //资源ID
objvVideoLibRelaInfoENT.SaveMode = objvVideoLibRelaInfoENS.SaveMode; //文件存放方式
objvVideoLibRelaInfoENT.IdFtpResource = objvVideoLibRelaInfoENS.IdFtpResource; //FTP资源流水号
objvVideoLibRelaInfoENT.FtpResourceID = objvVideoLibRelaInfoENS.FtpResourceID; //FTP资源ID
objvVideoLibRelaInfoENT.FileOriginalName = objvVideoLibRelaInfoENS.FileOriginalName; //文件原名
objvVideoLibRelaInfoENT.FileDirName = objvVideoLibRelaInfoENS.FileDirName; //文件目录名
objvVideoLibRelaInfoENT.FileRename = objvVideoLibRelaInfoENS.FileRename; //文件新名
objvVideoLibRelaInfoENT.FileUpDate = objvVideoLibRelaInfoENS.FileUpDate; //创建日期
objvVideoLibRelaInfoENT.FileUpTime = objvVideoLibRelaInfoENS.FileUpTime; //创建时间
objvVideoLibRelaInfoENT.FileSize = objvVideoLibRelaInfoENS.FileSize; //文件大小
objvVideoLibRelaInfoENT.FileType = objvVideoLibRelaInfoENS.FileType; //文件类型
objvVideoLibRelaInfoENT.ResourceOwner = objvVideoLibRelaInfoENS.ResourceOwner; //上传者
objvVideoLibRelaInfoENT.IsExistFile = objvVideoLibRelaInfoENS.IsExistFile; //是否存在文件
objvVideoLibRelaInfoENT.IdFile = objvVideoLibRelaInfoENS.IdFile; //文件流水号
objvVideoLibRelaInfoENT.FileName = objvVideoLibRelaInfoENS.FileName; //文件名称
objvVideoLibRelaInfoENT.SaveDate = objvVideoLibRelaInfoENS.SaveDate; //创建日期
objvVideoLibRelaInfoENT.SaveTime = objvVideoLibRelaInfoENS.SaveTime; //创建时间
objvVideoLibRelaInfoENT.FileOriginName = objvVideoLibRelaInfoENS.FileOriginName; //原文件名
objvVideoLibRelaInfoENT.IdResourceType = objvVideoLibRelaInfoENS.IdResourceType; //资源类型流水号
objvVideoLibRelaInfoENT.ResourceTypeID = objvVideoLibRelaInfoENS.ResourceTypeID; //资源类型ID
objvVideoLibRelaInfoENT.ResourceTypeName = objvVideoLibRelaInfoENS.ResourceTypeName; //资源类型名称
objvVideoLibRelaInfoENT.FileNewName = objvVideoLibRelaInfoENS.FileNewName; //新文件名
objvVideoLibRelaInfoENT.FileOldName = objvVideoLibRelaInfoENS.FileOldName; //旧文件名
objvVideoLibRelaInfoENT.ftpFileType = objvVideoLibRelaInfoENS.ftpFileType; //ftp文件类型
objvVideoLibRelaInfoENT.ftpFileSize = objvVideoLibRelaInfoENS.ftpFileSize; //ftp文件大小
objvVideoLibRelaInfoENT.ftpResourceOwner = objvVideoLibRelaInfoENS.ftpResourceOwner; //Ftp资源拥有者
objvVideoLibRelaInfoENT.IdMicroTeachCaseRelaInfoType = objvVideoLibRelaInfoENS.IdMicroTeachCaseRelaInfoType; //微格案例相关信息类型流水号
objvVideoLibRelaInfoENT.MicroTeachCaseRelaInfoTypeID = objvVideoLibRelaInfoENS.MicroTeachCaseRelaInfoTypeID; //微格案例相关信息类型ID
objvVideoLibRelaInfoENT.MicroTeachCaseRelaInfoTypeName = objvVideoLibRelaInfoENS.MicroTeachCaseRelaInfoTypeName; //微格案例相关信息类型名称
objvVideoLibRelaInfoENT.IsVisible = objvVideoLibRelaInfoENS.IsVisible; //是否显示
objvVideoLibRelaInfoENT.BrowseCount = objvVideoLibRelaInfoENS.BrowseCount; //浏览次数
objvVideoLibRelaInfoENT.Flag = objvVideoLibRelaInfoENS.Flag; //标志
objvVideoLibRelaInfoENT.UpdDate = objvVideoLibRelaInfoENS.UpdDate; //修改日期
objvVideoLibRelaInfoENT.UpdUser = objvVideoLibRelaInfoENS.UpdUser; //修改人
objvVideoLibRelaInfoENT.Memo = objvVideoLibRelaInfoENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvVideoLibRelaInfoEN.FuncModuleId, 4, convVideoLibRelaInfo.FuncModuleId);
clsCheckSql.CheckFieldLen(objvVideoLibRelaInfoEN.FuncModuleName, 30, convVideoLibRelaInfo.FuncModuleName);
clsCheckSql.CheckFieldLen(objvVideoLibRelaInfoEN.IdMicroteachCase, 8, convVideoLibRelaInfo.IdMicroteachCase);
clsCheckSql.CheckFieldLen(objvVideoLibRelaInfoEN.IdVideoLib, 8, convVideoLibRelaInfo.IdVideoLib);
clsCheckSql.CheckFieldLen(objvVideoLibRelaInfoEN.VideoLibName, 100, convVideoLibRelaInfo.VideoLibName);
clsCheckSql.CheckFieldLen(objvVideoLibRelaInfoEN.IdXzCollege, 4, convVideoLibRelaInfo.IdXzCollege);
clsCheckSql.CheckFieldLen(objvVideoLibRelaInfoEN.CollegeID, 4, convVideoLibRelaInfo.CollegeID);
clsCheckSql.CheckFieldLen(objvVideoLibRelaInfoEN.CollegeName, 100, convVideoLibRelaInfo.CollegeName);
clsCheckSql.CheckFieldLen(objvVideoLibRelaInfoEN.CollegeNameA, 12, convVideoLibRelaInfo.CollegeNameA);
clsCheckSql.CheckFieldLen(objvVideoLibRelaInfoEN.CourseId, 8, convVideoLibRelaInfo.CourseId);
clsCheckSql.CheckFieldLen(objvVideoLibRelaInfoEN.CourseCode, 20, convVideoLibRelaInfo.CourseCode);
clsCheckSql.CheckFieldLen(objvVideoLibRelaInfoEN.CourseName, 100, convVideoLibRelaInfo.CourseName);
clsCheckSql.CheckFieldLen(objvVideoLibRelaInfoEN.IdResource, 8, convVideoLibRelaInfo.IdResource);
clsCheckSql.CheckFieldLen(objvVideoLibRelaInfoEN.ResourceID, 8, convVideoLibRelaInfo.ResourceID);
clsCheckSql.CheckFieldLen(objvVideoLibRelaInfoEN.IdFtpResource, 8, convVideoLibRelaInfo.IdFtpResource);
clsCheckSql.CheckFieldLen(objvVideoLibRelaInfoEN.FtpResourceID, 8, convVideoLibRelaInfo.FtpResourceID);
clsCheckSql.CheckFieldLen(objvVideoLibRelaInfoEN.FileOriginalName, 200, convVideoLibRelaInfo.FileOriginalName);
clsCheckSql.CheckFieldLen(objvVideoLibRelaInfoEN.FileDirName, 200, convVideoLibRelaInfo.FileDirName);
clsCheckSql.CheckFieldLen(objvVideoLibRelaInfoEN.FileRename, 200, convVideoLibRelaInfo.FileRename);
clsCheckSql.CheckFieldLen(objvVideoLibRelaInfoEN.FileUpDate, 8, convVideoLibRelaInfo.FileUpDate);
clsCheckSql.CheckFieldLen(objvVideoLibRelaInfoEN.FileUpTime, 6, convVideoLibRelaInfo.FileUpTime);
clsCheckSql.CheckFieldLen(objvVideoLibRelaInfoEN.FileSize, 50, convVideoLibRelaInfo.FileSize);
clsCheckSql.CheckFieldLen(objvVideoLibRelaInfoEN.FileType, 30, convVideoLibRelaInfo.FileType);
clsCheckSql.CheckFieldLen(objvVideoLibRelaInfoEN.ResourceOwner, 50, convVideoLibRelaInfo.ResourceOwner);
clsCheckSql.CheckFieldLen(objvVideoLibRelaInfoEN.IdFile, 8, convVideoLibRelaInfo.IdFile);
clsCheckSql.CheckFieldLen(objvVideoLibRelaInfoEN.FileName, 500, convVideoLibRelaInfo.FileName);
clsCheckSql.CheckFieldLen(objvVideoLibRelaInfoEN.SaveDate, 8, convVideoLibRelaInfo.SaveDate);
clsCheckSql.CheckFieldLen(objvVideoLibRelaInfoEN.SaveTime, 6, convVideoLibRelaInfo.SaveTime);
clsCheckSql.CheckFieldLen(objvVideoLibRelaInfoEN.FileOriginName, 500, convVideoLibRelaInfo.FileOriginName);
clsCheckSql.CheckFieldLen(objvVideoLibRelaInfoEN.IdResourceType, 4, convVideoLibRelaInfo.IdResourceType);
clsCheckSql.CheckFieldLen(objvVideoLibRelaInfoEN.ResourceTypeID, 4, convVideoLibRelaInfo.ResourceTypeID);
clsCheckSql.CheckFieldLen(objvVideoLibRelaInfoEN.ResourceTypeName, 50, convVideoLibRelaInfo.ResourceTypeName);
clsCheckSql.CheckFieldLen(objvVideoLibRelaInfoEN.FileNewName, 530, convVideoLibRelaInfo.FileNewName);
clsCheckSql.CheckFieldLen(objvVideoLibRelaInfoEN.FileOldName, 530, convVideoLibRelaInfo.FileOldName);
clsCheckSql.CheckFieldLen(objvVideoLibRelaInfoEN.ftpFileType, 30, convVideoLibRelaInfo.ftpFileType);
clsCheckSql.CheckFieldLen(objvVideoLibRelaInfoEN.ftpFileSize, 50, convVideoLibRelaInfo.ftpFileSize);
clsCheckSql.CheckFieldLen(objvVideoLibRelaInfoEN.ftpResourceOwner, 50, convVideoLibRelaInfo.ftpResourceOwner);
clsCheckSql.CheckFieldLen(objvVideoLibRelaInfoEN.IdMicroTeachCaseRelaInfoType, 4, convVideoLibRelaInfo.IdMicroTeachCaseRelaInfoType);
clsCheckSql.CheckFieldLen(objvVideoLibRelaInfoEN.MicroTeachCaseRelaInfoTypeID, 4, convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeID);
clsCheckSql.CheckFieldLen(objvVideoLibRelaInfoEN.MicroTeachCaseRelaInfoTypeName, 50, convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeName);
clsCheckSql.CheckFieldLen(objvVideoLibRelaInfoEN.Flag, 50, convVideoLibRelaInfo.Flag);
clsCheckSql.CheckFieldLen(objvVideoLibRelaInfoEN.UpdDate, 20, convVideoLibRelaInfo.UpdDate);
clsCheckSql.CheckFieldLen(objvVideoLibRelaInfoEN.UpdUser, 20, convVideoLibRelaInfo.UpdUser);
clsCheckSql.CheckFieldLen(objvVideoLibRelaInfoEN.Memo, 1000, convVideoLibRelaInfo.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvVideoLibRelaInfoEN.FuncModuleId, convVideoLibRelaInfo.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibRelaInfoEN.FuncModuleName, convVideoLibRelaInfo.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibRelaInfoEN.IdMicroteachCase, convVideoLibRelaInfo.IdMicroteachCase);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibRelaInfoEN.IdVideoLib, convVideoLibRelaInfo.IdVideoLib);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibRelaInfoEN.VideoLibName, convVideoLibRelaInfo.VideoLibName);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibRelaInfoEN.IdXzCollege, convVideoLibRelaInfo.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibRelaInfoEN.CollegeID, convVideoLibRelaInfo.CollegeID);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibRelaInfoEN.CollegeName, convVideoLibRelaInfo.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibRelaInfoEN.CollegeNameA, convVideoLibRelaInfo.CollegeNameA);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibRelaInfoEN.CourseId, convVideoLibRelaInfo.CourseId);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibRelaInfoEN.CourseCode, convVideoLibRelaInfo.CourseCode);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibRelaInfoEN.CourseName, convVideoLibRelaInfo.CourseName);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibRelaInfoEN.IdResource, convVideoLibRelaInfo.IdResource);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibRelaInfoEN.ResourceID, convVideoLibRelaInfo.ResourceID);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibRelaInfoEN.IdFtpResource, convVideoLibRelaInfo.IdFtpResource);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibRelaInfoEN.FtpResourceID, convVideoLibRelaInfo.FtpResourceID);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibRelaInfoEN.FileOriginalName, convVideoLibRelaInfo.FileOriginalName);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibRelaInfoEN.FileDirName, convVideoLibRelaInfo.FileDirName);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibRelaInfoEN.FileRename, convVideoLibRelaInfo.FileRename);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibRelaInfoEN.FileUpDate, convVideoLibRelaInfo.FileUpDate);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibRelaInfoEN.FileUpTime, convVideoLibRelaInfo.FileUpTime);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibRelaInfoEN.FileSize, convVideoLibRelaInfo.FileSize);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibRelaInfoEN.FileType, convVideoLibRelaInfo.FileType);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibRelaInfoEN.ResourceOwner, convVideoLibRelaInfo.ResourceOwner);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibRelaInfoEN.IdFile, convVideoLibRelaInfo.IdFile);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibRelaInfoEN.FileName, convVideoLibRelaInfo.FileName);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibRelaInfoEN.SaveDate, convVideoLibRelaInfo.SaveDate);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibRelaInfoEN.SaveTime, convVideoLibRelaInfo.SaveTime);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibRelaInfoEN.FileOriginName, convVideoLibRelaInfo.FileOriginName);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibRelaInfoEN.IdResourceType, convVideoLibRelaInfo.IdResourceType);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibRelaInfoEN.ResourceTypeID, convVideoLibRelaInfo.ResourceTypeID);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibRelaInfoEN.ResourceTypeName, convVideoLibRelaInfo.ResourceTypeName);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibRelaInfoEN.FileNewName, convVideoLibRelaInfo.FileNewName);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibRelaInfoEN.FileOldName, convVideoLibRelaInfo.FileOldName);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibRelaInfoEN.ftpFileType, convVideoLibRelaInfo.ftpFileType);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibRelaInfoEN.ftpFileSize, convVideoLibRelaInfo.ftpFileSize);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibRelaInfoEN.ftpResourceOwner, convVideoLibRelaInfo.ftpResourceOwner);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibRelaInfoEN.IdMicroTeachCaseRelaInfoType, convVideoLibRelaInfo.IdMicroTeachCaseRelaInfoType);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibRelaInfoEN.MicroTeachCaseRelaInfoTypeID, convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeID);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibRelaInfoEN.MicroTeachCaseRelaInfoTypeName, convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeName);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibRelaInfoEN.Flag, convVideoLibRelaInfo.Flag);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibRelaInfoEN.UpdDate, convVideoLibRelaInfo.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibRelaInfoEN.UpdUser, convVideoLibRelaInfo.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibRelaInfoEN.Memo, convVideoLibRelaInfo.Memo);
//检查外键字段长度
 objvVideoLibRelaInfoEN._IsCheckProperty = true;
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
 objSQL = clsvVideoLibRelaInfoDA.GetSpecSQLObj();
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
 objSQL = clsvVideoLibRelaInfoDA.GetSpecSQLObj();
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
 objSQL = clsvVideoLibRelaInfoDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvVideoLibRelaInfoEN._CurrTabName);
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
 objSQL = clsvVideoLibRelaInfoDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvVideoLibRelaInfoEN._CurrTabName, strCondition);
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
 objSQL = clsvVideoLibRelaInfoDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}