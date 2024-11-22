
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCoursewareCaseRelaInfoDA
 表名:vCoursewareCaseRelaInfo(01120403)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:46:12
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课件(Courseware)
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
 /// vCoursewareCaseRelaInfo(vCoursewareCaseRelaInfo)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvCoursewareCaseRelaInfoDA : clsCommBase4DA
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
 return clsvCoursewareCaseRelaInfoEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvCoursewareCaseRelaInfoEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCoursewareCaseRelaInfoEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvCoursewareCaseRelaInfoEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvCoursewareCaseRelaInfoEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvCoursewareCaseRelaInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vCoursewareCaseRelaInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vCoursewareCaseRelaInfo(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvCoursewareCaseRelaInfoDA: GetDataTable_vCoursewareCaseRelaInfo)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vCoursewareCaseRelaInfo where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvCoursewareCaseRelaInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCaseRelaInfoDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvCoursewareCaseRelaInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vCoursewareCaseRelaInfo where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvCoursewareCaseRelaInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCaseRelaInfoDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvCoursewareCaseRelaInfoDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCaseRelaInfoDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCoursewareCaseRelaInfo where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCoursewareCaseRelaInfo where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvCoursewareCaseRelaInfoDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCaseRelaInfoDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vCoursewareCaseRelaInfo where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvCoursewareCaseRelaInfoDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCaseRelaInfoDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vCoursewareCaseRelaInfo.* from vCoursewareCaseRelaInfo Left Join {1} on {2} where {3} and vCoursewareCaseRelaInfo.IdMicroTeachCaseRelaInfo not in (Select top {5} vCoursewareCaseRelaInfo.IdMicroTeachCaseRelaInfo from vCoursewareCaseRelaInfo Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCoursewareCaseRelaInfo where {1} and IdMicroTeachCaseRelaInfo not in (Select top {2} IdMicroTeachCaseRelaInfo from vCoursewareCaseRelaInfo where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCoursewareCaseRelaInfo where {1} and IdMicroTeachCaseRelaInfo not in (Select top {3} IdMicroTeachCaseRelaInfo from vCoursewareCaseRelaInfo where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvCoursewareCaseRelaInfoDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCaseRelaInfoDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vCoursewareCaseRelaInfo.* from vCoursewareCaseRelaInfo Left Join {1} on {2} where {3} and vCoursewareCaseRelaInfo.IdMicroTeachCaseRelaInfo not in (Select top {5} vCoursewareCaseRelaInfo.IdMicroTeachCaseRelaInfo from vCoursewareCaseRelaInfo Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCoursewareCaseRelaInfo where {1} and IdMicroTeachCaseRelaInfo not in (Select top {2} IdMicroTeachCaseRelaInfo from vCoursewareCaseRelaInfo where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCoursewareCaseRelaInfo where {1} and IdMicroTeachCaseRelaInfo not in (Select top {3} IdMicroTeachCaseRelaInfo from vCoursewareCaseRelaInfo where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvCoursewareCaseRelaInfoEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvCoursewareCaseRelaInfoDA:GetObjLst)", objException.Message));
}
List<clsvCoursewareCaseRelaInfoEN> arrObjLst = new List<clsvCoursewareCaseRelaInfoEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vCoursewareCaseRelaInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCoursewareCaseRelaInfoEN objvCoursewareCaseRelaInfoEN = new clsvCoursewareCaseRelaInfoEN();
try
{
objvCoursewareCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = TransNullToInt(objRow[convCoursewareCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvCoursewareCaseRelaInfoEN.IdFile = objRow[convCoursewareCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvCoursewareCaseRelaInfoEN.FileName = objRow[convCoursewareCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvCoursewareCaseRelaInfoEN.FileType = objRow[convCoursewareCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvCoursewareCaseRelaInfoEN.SaveDate = objRow[convCoursewareCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvCoursewareCaseRelaInfoEN.FileSize = objRow[convCoursewareCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvCoursewareCaseRelaInfoEN.SaveTime = objRow[convCoursewareCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvCoursewareCaseRelaInfoEN.IdMicroteachCase = objRow[convCoursewareCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCoursewareCaseRelaInfoEN.IdFtpResource = objRow[convCoursewareCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvCoursewareCaseRelaInfoEN.FtpResourceID = objRow[convCoursewareCaseRelaInfo.FtpResourceID] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvCoursewareCaseRelaInfoEN.FileOriginalName = objRow[convCoursewareCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvCoursewareCaseRelaInfoEN.FileDirName = objRow[convCoursewareCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvCoursewareCaseRelaInfoEN.FileRename = objRow[convCoursewareCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvCoursewareCaseRelaInfoEN.FileUpDate = objRow[convCoursewareCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvCoursewareCaseRelaInfoEN.FileUpTime = objRow[convCoursewareCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvCoursewareCaseRelaInfoEN.IdResource = objRow[convCoursewareCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvCoursewareCaseRelaInfoEN.ResourceID = objRow[convCoursewareCaseRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvCoursewareCaseRelaInfoEN.SaveMode = TransNullToBool(objRow[convCoursewareCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvCoursewareCaseRelaInfoEN.IdResourceType = objRow[convCoursewareCaseRelaInfo.IdResourceType] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvCoursewareCaseRelaInfoEN.ResourceTypeID = objRow[convCoursewareCaseRelaInfo.ResourceTypeID] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvCoursewareCaseRelaInfoEN.ResourceTypeName = objRow[convCoursewareCaseRelaInfo.ResourceTypeName] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvCoursewareCaseRelaInfoEN.MajorName = objRow[convCoursewareCaseRelaInfo.MajorName] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.MajorName].ToString().Trim(); //专业名称
objvCoursewareCaseRelaInfoEN.CollegeID = objRow[convCoursewareCaseRelaInfo.CollegeID] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.CollegeID].ToString().Trim(); //学院ID
objvCoursewareCaseRelaInfoEN.CollegeName = objRow[convCoursewareCaseRelaInfo.CollegeName] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.CollegeName].ToString().Trim(); //学院名称
objvCoursewareCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convCoursewareCaseRelaInfo.IdMicroTeachCaseRelaInfoType] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvCoursewareCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convCoursewareCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objvCoursewareCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convCoursewareCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvCoursewareCaseRelaInfoEN.BrowseCount = objRow[convCoursewareCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvCoursewareCaseRelaInfoEN.ResourceOwner = objRow[convCoursewareCaseRelaInfo.ResourceOwner] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvCoursewareCaseRelaInfoEN.ftpFileType = objRow[convCoursewareCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvCoursewareCaseRelaInfoEN.ftpFileSize = objRow[convCoursewareCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvCoursewareCaseRelaInfoEN.ftpResourceOwner = objRow[convCoursewareCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvCoursewareCaseRelaInfoEN.FileOriginName = objRow[convCoursewareCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvCoursewareCaseRelaInfoEN.UpdDate = objRow[convCoursewareCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvCoursewareCaseRelaInfoEN.UpdUser = objRow[convCoursewareCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objvCoursewareCaseRelaInfoEN.IsExistFile = TransNullToBool(objRow[convCoursewareCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvCoursewareCaseRelaInfoEN.Flag = objRow[convCoursewareCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.Flag].ToString().Trim(); //标志
objvCoursewareCaseRelaInfoEN.FuncModuleName = objRow[convCoursewareCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvCoursewareCaseRelaInfoEN.FuncModuleId = objRow[convCoursewareCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvCoursewareCaseRelaInfoEN.FileNewName = objRow[convCoursewareCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvCoursewareCaseRelaInfoEN.FileOldName = objRow[convCoursewareCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvCoursewareCaseRelaInfoEN.CoursewareCaseName = objRow[convCoursewareCaseRelaInfo.CoursewareCaseName] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.CoursewareCaseName].ToString().Trim(); //课件教学案例名称
objvCoursewareCaseRelaInfoEN.IdCoursewareCase = objRow[convCoursewareCaseRelaInfo.IdCoursewareCase] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.IdCoursewareCase].ToString().Trim(); //课件教学案例流水号
objvCoursewareCaseRelaInfoEN.IsVisible = TransNullToBool(objRow[convCoursewareCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvCoursewareCaseRelaInfoEN.Memo = objRow[convCoursewareCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.Memo].ToString().Trim(); //备注
objvCoursewareCaseRelaInfoEN.IdXzCollege = objRow[convCoursewareCaseRelaInfo.IdXzCollege] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.IdXzCollege].ToString().Trim(); //学院流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCoursewareCaseRelaInfoDA: GetObjLst)", objException.Message));
}
objvCoursewareCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCoursewareCaseRelaInfoEN);
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
public List<clsvCoursewareCaseRelaInfoEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvCoursewareCaseRelaInfoDA:GetObjLstByTabName)", objException.Message));
}
List<clsvCoursewareCaseRelaInfoEN> arrObjLst = new List<clsvCoursewareCaseRelaInfoEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCaseRelaInfoDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCoursewareCaseRelaInfoEN objvCoursewareCaseRelaInfoEN = new clsvCoursewareCaseRelaInfoEN();
try
{
objvCoursewareCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = TransNullToInt(objRow[convCoursewareCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvCoursewareCaseRelaInfoEN.IdFile = objRow[convCoursewareCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvCoursewareCaseRelaInfoEN.FileName = objRow[convCoursewareCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvCoursewareCaseRelaInfoEN.FileType = objRow[convCoursewareCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvCoursewareCaseRelaInfoEN.SaveDate = objRow[convCoursewareCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvCoursewareCaseRelaInfoEN.FileSize = objRow[convCoursewareCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvCoursewareCaseRelaInfoEN.SaveTime = objRow[convCoursewareCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvCoursewareCaseRelaInfoEN.IdMicroteachCase = objRow[convCoursewareCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCoursewareCaseRelaInfoEN.IdFtpResource = objRow[convCoursewareCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvCoursewareCaseRelaInfoEN.FtpResourceID = objRow[convCoursewareCaseRelaInfo.FtpResourceID] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvCoursewareCaseRelaInfoEN.FileOriginalName = objRow[convCoursewareCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvCoursewareCaseRelaInfoEN.FileDirName = objRow[convCoursewareCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvCoursewareCaseRelaInfoEN.FileRename = objRow[convCoursewareCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvCoursewareCaseRelaInfoEN.FileUpDate = objRow[convCoursewareCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvCoursewareCaseRelaInfoEN.FileUpTime = objRow[convCoursewareCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvCoursewareCaseRelaInfoEN.IdResource = objRow[convCoursewareCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvCoursewareCaseRelaInfoEN.ResourceID = objRow[convCoursewareCaseRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvCoursewareCaseRelaInfoEN.SaveMode = TransNullToBool(objRow[convCoursewareCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvCoursewareCaseRelaInfoEN.IdResourceType = objRow[convCoursewareCaseRelaInfo.IdResourceType] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvCoursewareCaseRelaInfoEN.ResourceTypeID = objRow[convCoursewareCaseRelaInfo.ResourceTypeID] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvCoursewareCaseRelaInfoEN.ResourceTypeName = objRow[convCoursewareCaseRelaInfo.ResourceTypeName] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvCoursewareCaseRelaInfoEN.MajorName = objRow[convCoursewareCaseRelaInfo.MajorName] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.MajorName].ToString().Trim(); //专业名称
objvCoursewareCaseRelaInfoEN.CollegeID = objRow[convCoursewareCaseRelaInfo.CollegeID] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.CollegeID].ToString().Trim(); //学院ID
objvCoursewareCaseRelaInfoEN.CollegeName = objRow[convCoursewareCaseRelaInfo.CollegeName] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.CollegeName].ToString().Trim(); //学院名称
objvCoursewareCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convCoursewareCaseRelaInfo.IdMicroTeachCaseRelaInfoType] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvCoursewareCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convCoursewareCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objvCoursewareCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convCoursewareCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvCoursewareCaseRelaInfoEN.BrowseCount = objRow[convCoursewareCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvCoursewareCaseRelaInfoEN.ResourceOwner = objRow[convCoursewareCaseRelaInfo.ResourceOwner] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvCoursewareCaseRelaInfoEN.ftpFileType = objRow[convCoursewareCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvCoursewareCaseRelaInfoEN.ftpFileSize = objRow[convCoursewareCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvCoursewareCaseRelaInfoEN.ftpResourceOwner = objRow[convCoursewareCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvCoursewareCaseRelaInfoEN.FileOriginName = objRow[convCoursewareCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvCoursewareCaseRelaInfoEN.UpdDate = objRow[convCoursewareCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvCoursewareCaseRelaInfoEN.UpdUser = objRow[convCoursewareCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objvCoursewareCaseRelaInfoEN.IsExistFile = TransNullToBool(objRow[convCoursewareCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvCoursewareCaseRelaInfoEN.Flag = objRow[convCoursewareCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.Flag].ToString().Trim(); //标志
objvCoursewareCaseRelaInfoEN.FuncModuleName = objRow[convCoursewareCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvCoursewareCaseRelaInfoEN.FuncModuleId = objRow[convCoursewareCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvCoursewareCaseRelaInfoEN.FileNewName = objRow[convCoursewareCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvCoursewareCaseRelaInfoEN.FileOldName = objRow[convCoursewareCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvCoursewareCaseRelaInfoEN.CoursewareCaseName = objRow[convCoursewareCaseRelaInfo.CoursewareCaseName] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.CoursewareCaseName].ToString().Trim(); //课件教学案例名称
objvCoursewareCaseRelaInfoEN.IdCoursewareCase = objRow[convCoursewareCaseRelaInfo.IdCoursewareCase] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.IdCoursewareCase].ToString().Trim(); //课件教学案例流水号
objvCoursewareCaseRelaInfoEN.IsVisible = TransNullToBool(objRow[convCoursewareCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvCoursewareCaseRelaInfoEN.Memo = objRow[convCoursewareCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.Memo].ToString().Trim(); //备注
objvCoursewareCaseRelaInfoEN.IdXzCollege = objRow[convCoursewareCaseRelaInfo.IdXzCollege] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.IdXzCollege].ToString().Trim(); //学院流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCoursewareCaseRelaInfoDA: GetObjLst)", objException.Message));
}
objvCoursewareCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCoursewareCaseRelaInfoEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvCoursewareCaseRelaInfoEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvCoursewareCaseRelaInfo(ref clsvCoursewareCaseRelaInfoEN objvCoursewareCaseRelaInfoEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vCoursewareCaseRelaInfo where IdMicroTeachCaseRelaInfo = " + ""+ objvCoursewareCaseRelaInfoEN.IdMicroTeachCaseRelaInfo+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvCoursewareCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = TransNullToInt(objDT.Rows[0][convCoursewareCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvCoursewareCaseRelaInfoEN.IdFile = objDT.Rows[0][convCoursewareCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareCaseRelaInfoEN.FileName = objDT.Rows[0][convCoursewareCaseRelaInfo.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvCoursewareCaseRelaInfoEN.FileType = objDT.Rows[0][convCoursewareCaseRelaInfo.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvCoursewareCaseRelaInfoEN.SaveDate = objDT.Rows[0][convCoursewareCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareCaseRelaInfoEN.FileSize = objDT.Rows[0][convCoursewareCaseRelaInfo.FileSize].ToString().Trim(); //文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvCoursewareCaseRelaInfoEN.SaveTime = objDT.Rows[0][convCoursewareCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvCoursewareCaseRelaInfoEN.IdMicroteachCase = objDT.Rows[0][convCoursewareCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareCaseRelaInfoEN.IdFtpResource = objDT.Rows[0][convCoursewareCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareCaseRelaInfoEN.FtpResourceID = objDT.Rows[0][convCoursewareCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareCaseRelaInfoEN.FileOriginalName = objDT.Rows[0][convCoursewareCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareCaseRelaInfoEN.FileDirName = objDT.Rows[0][convCoursewareCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareCaseRelaInfoEN.FileRename = objDT.Rows[0][convCoursewareCaseRelaInfo.FileRename].ToString().Trim(); //文件新名(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareCaseRelaInfoEN.FileUpDate = objDT.Rows[0][convCoursewareCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareCaseRelaInfoEN.FileUpTime = objDT.Rows[0][convCoursewareCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvCoursewareCaseRelaInfoEN.IdResource = objDT.Rows[0][convCoursewareCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareCaseRelaInfoEN.ResourceID = objDT.Rows[0][convCoursewareCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareCaseRelaInfoEN.SaveMode = TransNullToBool(objDT.Rows[0][convCoursewareCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式(字段类型:bit,字段长度:1,是否可空:True)
 objvCoursewareCaseRelaInfoEN.IdResourceType = objDT.Rows[0][convCoursewareCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareCaseRelaInfoEN.ResourceTypeID = objDT.Rows[0][convCoursewareCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareCaseRelaInfoEN.ResourceTypeName = objDT.Rows[0][convCoursewareCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareCaseRelaInfoEN.MajorName = objDT.Rows[0][convCoursewareCaseRelaInfo.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCoursewareCaseRelaInfoEN.CollegeID = objDT.Rows[0][convCoursewareCaseRelaInfo.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvCoursewareCaseRelaInfoEN.CollegeName = objDT.Rows[0][convCoursewareCaseRelaInfo.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCoursewareCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objDT.Rows[0][convCoursewareCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objDT.Rows[0][convCoursewareCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objDT.Rows[0][convCoursewareCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareCaseRelaInfoEN.BrowseCount = TransNullToInt(objDT.Rows[0][convCoursewareCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvCoursewareCaseRelaInfoEN.ResourceOwner = objDT.Rows[0][convCoursewareCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareCaseRelaInfoEN.ftpFileType = objDT.Rows[0][convCoursewareCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvCoursewareCaseRelaInfoEN.ftpFileSize = objDT.Rows[0][convCoursewareCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvCoursewareCaseRelaInfoEN.ftpResourceOwner = objDT.Rows[0][convCoursewareCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者(字段类型:varchar,字段长度:50,是否可空:True)
 objvCoursewareCaseRelaInfoEN.FileOriginName = objDT.Rows[0][convCoursewareCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名(字段类型:varchar,字段长度:500,是否可空:True)
 objvCoursewareCaseRelaInfoEN.UpdDate = objDT.Rows[0][convCoursewareCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvCoursewareCaseRelaInfoEN.UpdUser = objDT.Rows[0][convCoursewareCaseRelaInfo.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvCoursewareCaseRelaInfoEN.IsExistFile = TransNullToBool(objDT.Rows[0][convCoursewareCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objvCoursewareCaseRelaInfoEN.Flag = objDT.Rows[0][convCoursewareCaseRelaInfo.Flag].ToString().Trim(); //标志(字段类型:varchar,字段长度:50,是否可空:True)
 objvCoursewareCaseRelaInfoEN.FuncModuleName = objDT.Rows[0][convCoursewareCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCoursewareCaseRelaInfoEN.FuncModuleId = objDT.Rows[0][convCoursewareCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvCoursewareCaseRelaInfoEN.FileNewName = objDT.Rows[0][convCoursewareCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvCoursewareCaseRelaInfoEN.FileOldName = objDT.Rows[0][convCoursewareCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvCoursewareCaseRelaInfoEN.CoursewareCaseName = objDT.Rows[0][convCoursewareCaseRelaInfo.CoursewareCaseName].ToString().Trim(); //课件教学案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCoursewareCaseRelaInfoEN.IdCoursewareCase = objDT.Rows[0][convCoursewareCaseRelaInfo.IdCoursewareCase].ToString().Trim(); //课件教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareCaseRelaInfoEN.IsVisible = TransNullToBool(objDT.Rows[0][convCoursewareCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvCoursewareCaseRelaInfoEN.Memo = objDT.Rows[0][convCoursewareCaseRelaInfo.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCoursewareCaseRelaInfoEN.IdXzCollege = objDT.Rows[0][convCoursewareCaseRelaInfo.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvCoursewareCaseRelaInfoDA: GetvCoursewareCaseRelaInfo)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdMicroTeachCaseRelaInfo">表关键字</param>
 /// <returns>表对象</returns>
public clsvCoursewareCaseRelaInfoEN GetObjByIdMicroTeachCaseRelaInfo(long lngIdMicroTeachCaseRelaInfo)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vCoursewareCaseRelaInfo where IdMicroTeachCaseRelaInfo = " + ""+ lngIdMicroTeachCaseRelaInfo+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvCoursewareCaseRelaInfoEN objvCoursewareCaseRelaInfoEN = new clsvCoursewareCaseRelaInfoEN();
try
{
 objvCoursewareCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = Int32.Parse(objRow[convCoursewareCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvCoursewareCaseRelaInfoEN.IdFile = objRow[convCoursewareCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareCaseRelaInfoEN.FileName = objRow[convCoursewareCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvCoursewareCaseRelaInfoEN.FileType = objRow[convCoursewareCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvCoursewareCaseRelaInfoEN.SaveDate = objRow[convCoursewareCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareCaseRelaInfoEN.FileSize = objRow[convCoursewareCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FileSize].ToString().Trim(); //文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvCoursewareCaseRelaInfoEN.SaveTime = objRow[convCoursewareCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvCoursewareCaseRelaInfoEN.IdMicroteachCase = objRow[convCoursewareCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareCaseRelaInfoEN.IdFtpResource = objRow[convCoursewareCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareCaseRelaInfoEN.FtpResourceID = objRow[convCoursewareCaseRelaInfo.FtpResourceID] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareCaseRelaInfoEN.FileOriginalName = objRow[convCoursewareCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareCaseRelaInfoEN.FileDirName = objRow[convCoursewareCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareCaseRelaInfoEN.FileRename = objRow[convCoursewareCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FileRename].ToString().Trim(); //文件新名(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareCaseRelaInfoEN.FileUpDate = objRow[convCoursewareCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareCaseRelaInfoEN.FileUpTime = objRow[convCoursewareCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvCoursewareCaseRelaInfoEN.IdResource = objRow[convCoursewareCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareCaseRelaInfoEN.ResourceID = objRow[convCoursewareCaseRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareCaseRelaInfoEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convCoursewareCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式(字段类型:bit,字段长度:1,是否可空:True)
 objvCoursewareCaseRelaInfoEN.IdResourceType = objRow[convCoursewareCaseRelaInfo.IdResourceType] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareCaseRelaInfoEN.ResourceTypeID = objRow[convCoursewareCaseRelaInfo.ResourceTypeID] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareCaseRelaInfoEN.ResourceTypeName = objRow[convCoursewareCaseRelaInfo.ResourceTypeName] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareCaseRelaInfoEN.MajorName = objRow[convCoursewareCaseRelaInfo.MajorName] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCoursewareCaseRelaInfoEN.CollegeID = objRow[convCoursewareCaseRelaInfo.CollegeID] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvCoursewareCaseRelaInfoEN.CollegeName = objRow[convCoursewareCaseRelaInfo.CollegeName] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCoursewareCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convCoursewareCaseRelaInfo.IdMicroTeachCaseRelaInfoType] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convCoursewareCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convCoursewareCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareCaseRelaInfoEN.BrowseCount = objRow[convCoursewareCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCoursewareCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvCoursewareCaseRelaInfoEN.ResourceOwner = objRow[convCoursewareCaseRelaInfo.ResourceOwner] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareCaseRelaInfoEN.ftpFileType = objRow[convCoursewareCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvCoursewareCaseRelaInfoEN.ftpFileSize = objRow[convCoursewareCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvCoursewareCaseRelaInfoEN.ftpResourceOwner = objRow[convCoursewareCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者(字段类型:varchar,字段长度:50,是否可空:True)
 objvCoursewareCaseRelaInfoEN.FileOriginName = objRow[convCoursewareCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名(字段类型:varchar,字段长度:500,是否可空:True)
 objvCoursewareCaseRelaInfoEN.UpdDate = objRow[convCoursewareCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvCoursewareCaseRelaInfoEN.UpdUser = objRow[convCoursewareCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvCoursewareCaseRelaInfoEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convCoursewareCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objvCoursewareCaseRelaInfoEN.Flag = objRow[convCoursewareCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.Flag].ToString().Trim(); //标志(字段类型:varchar,字段长度:50,是否可空:True)
 objvCoursewareCaseRelaInfoEN.FuncModuleName = objRow[convCoursewareCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCoursewareCaseRelaInfoEN.FuncModuleId = objRow[convCoursewareCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvCoursewareCaseRelaInfoEN.FileNewName = objRow[convCoursewareCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvCoursewareCaseRelaInfoEN.FileOldName = objRow[convCoursewareCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvCoursewareCaseRelaInfoEN.CoursewareCaseName = objRow[convCoursewareCaseRelaInfo.CoursewareCaseName] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.CoursewareCaseName].ToString().Trim(); //课件教学案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCoursewareCaseRelaInfoEN.IdCoursewareCase = objRow[convCoursewareCaseRelaInfo.IdCoursewareCase] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.IdCoursewareCase].ToString().Trim(); //课件教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCoursewareCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvCoursewareCaseRelaInfoEN.Memo = objRow[convCoursewareCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCoursewareCaseRelaInfoEN.IdXzCollege = objRow[convCoursewareCaseRelaInfo.IdXzCollege] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvCoursewareCaseRelaInfoDA: GetObjByIdMicroTeachCaseRelaInfo)", objException.Message));
}
return objvCoursewareCaseRelaInfoEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvCoursewareCaseRelaInfoEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvCoursewareCaseRelaInfoDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vCoursewareCaseRelaInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvCoursewareCaseRelaInfoEN objvCoursewareCaseRelaInfoEN = new clsvCoursewareCaseRelaInfoEN()
{
IdMicroTeachCaseRelaInfo = TransNullToInt(objRow[convCoursewareCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()), //案例相关信息流水号
IdFile = objRow[convCoursewareCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.IdFile].ToString().Trim(), //文件流水号
FileName = objRow[convCoursewareCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FileName].ToString().Trim(), //文件名称
FileType = objRow[convCoursewareCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FileType].ToString().Trim(), //文件类型
SaveDate = objRow[convCoursewareCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.SaveDate].ToString().Trim(), //创建日期
FileSize = objRow[convCoursewareCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FileSize].ToString().Trim(), //文件大小
SaveTime = objRow[convCoursewareCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.SaveTime].ToString().Trim(), //创建时间
IdMicroteachCase = objRow[convCoursewareCaseRelaInfo.IdMicroteachCase].ToString().Trim(), //微格教学案例流水号
IdFtpResource = objRow[convCoursewareCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.IdFtpResource].ToString().Trim(), //FTP资源流水号
FtpResourceID = objRow[convCoursewareCaseRelaInfo.FtpResourceID] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FtpResourceID].ToString().Trim(), //FTP资源ID
FileOriginalName = objRow[convCoursewareCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FileOriginalName].ToString().Trim(), //文件原名
FileDirName = objRow[convCoursewareCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FileDirName].ToString().Trim(), //文件目录名
FileRename = objRow[convCoursewareCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FileRename].ToString().Trim(), //文件新名
FileUpDate = objRow[convCoursewareCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FileUpDate].ToString().Trim(), //创建日期
FileUpTime = objRow[convCoursewareCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FileUpTime].ToString().Trim(), //创建时间
IdResource = objRow[convCoursewareCaseRelaInfo.IdResource].ToString().Trim(), //资源流水号
ResourceID = objRow[convCoursewareCaseRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.ResourceID].ToString().Trim(), //资源ID
SaveMode = TransNullToBool(objRow[convCoursewareCaseRelaInfo.SaveMode].ToString().Trim()), //文件存放方式
IdResourceType = objRow[convCoursewareCaseRelaInfo.IdResourceType] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.IdResourceType].ToString().Trim(), //资源类型流水号
ResourceTypeID = objRow[convCoursewareCaseRelaInfo.ResourceTypeID] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.ResourceTypeID].ToString().Trim(), //资源类型ID
ResourceTypeName = objRow[convCoursewareCaseRelaInfo.ResourceTypeName] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.ResourceTypeName].ToString().Trim(), //资源类型名称
MajorName = objRow[convCoursewareCaseRelaInfo.MajorName] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.MajorName].ToString().Trim(), //专业名称
CollegeID = objRow[convCoursewareCaseRelaInfo.CollegeID] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.CollegeID].ToString().Trim(), //学院ID
CollegeName = objRow[convCoursewareCaseRelaInfo.CollegeName] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.CollegeName].ToString().Trim(), //学院名称
IdMicroTeachCaseRelaInfoType = objRow[convCoursewareCaseRelaInfo.IdMicroTeachCaseRelaInfoType] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(), //微格案例相关信息类型流水号
MicroTeachCaseRelaInfoTypeID = objRow[convCoursewareCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(), //微格案例相关信息类型ID
MicroTeachCaseRelaInfoTypeName = objRow[convCoursewareCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(), //微格案例相关信息类型名称
BrowseCount = objRow[convCoursewareCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareCaseRelaInfo.BrowseCount].ToString().Trim()), //浏览次数
ResourceOwner = objRow[convCoursewareCaseRelaInfo.ResourceOwner] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.ResourceOwner].ToString().Trim(), //上传者
ftpFileType = objRow[convCoursewareCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.ftpFileType].ToString().Trim(), //ftp文件类型
ftpFileSize = objRow[convCoursewareCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.ftpFileSize].ToString().Trim(), //ftp文件大小
ftpResourceOwner = objRow[convCoursewareCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.ftpResourceOwner].ToString().Trim(), //Ftp资源拥有者
FileOriginName = objRow[convCoursewareCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FileOriginName].ToString().Trim(), //原文件名
UpdDate = objRow[convCoursewareCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convCoursewareCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.UpdUser].ToString().Trim(), //修改人
IsExistFile = TransNullToBool(objRow[convCoursewareCaseRelaInfo.IsExistFile].ToString().Trim()), //是否存在文件
Flag = objRow[convCoursewareCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.Flag].ToString().Trim(), //标志
FuncModuleName = objRow[convCoursewareCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FuncModuleName].ToString().Trim(), //功能模块名称
FuncModuleId = objRow[convCoursewareCaseRelaInfo.FuncModuleId].ToString().Trim(), //功能模块Id
FileNewName = objRow[convCoursewareCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FileNewName].ToString().Trim(), //新文件名
FileOldName = objRow[convCoursewareCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FileOldName].ToString().Trim(), //旧文件名
CoursewareCaseName = objRow[convCoursewareCaseRelaInfo.CoursewareCaseName] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.CoursewareCaseName].ToString().Trim(), //课件教学案例名称
IdCoursewareCase = objRow[convCoursewareCaseRelaInfo.IdCoursewareCase] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.IdCoursewareCase].ToString().Trim(), //课件教学案例流水号
IsVisible = TransNullToBool(objRow[convCoursewareCaseRelaInfo.IsVisible].ToString().Trim()), //是否显示
Memo = objRow[convCoursewareCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.Memo].ToString().Trim(), //备注
IdXzCollege = objRow[convCoursewareCaseRelaInfo.IdXzCollege] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.IdXzCollege].ToString().Trim() //学院流水号
};
objvCoursewareCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCoursewareCaseRelaInfoEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvCoursewareCaseRelaInfoDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvCoursewareCaseRelaInfoEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCoursewareCaseRelaInfoEN objvCoursewareCaseRelaInfoEN = new clsvCoursewareCaseRelaInfoEN();
try
{
objvCoursewareCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = TransNullToInt(objRow[convCoursewareCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvCoursewareCaseRelaInfoEN.IdFile = objRow[convCoursewareCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvCoursewareCaseRelaInfoEN.FileName = objRow[convCoursewareCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvCoursewareCaseRelaInfoEN.FileType = objRow[convCoursewareCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvCoursewareCaseRelaInfoEN.SaveDate = objRow[convCoursewareCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvCoursewareCaseRelaInfoEN.FileSize = objRow[convCoursewareCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvCoursewareCaseRelaInfoEN.SaveTime = objRow[convCoursewareCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvCoursewareCaseRelaInfoEN.IdMicroteachCase = objRow[convCoursewareCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCoursewareCaseRelaInfoEN.IdFtpResource = objRow[convCoursewareCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvCoursewareCaseRelaInfoEN.FtpResourceID = objRow[convCoursewareCaseRelaInfo.FtpResourceID] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvCoursewareCaseRelaInfoEN.FileOriginalName = objRow[convCoursewareCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvCoursewareCaseRelaInfoEN.FileDirName = objRow[convCoursewareCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvCoursewareCaseRelaInfoEN.FileRename = objRow[convCoursewareCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvCoursewareCaseRelaInfoEN.FileUpDate = objRow[convCoursewareCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvCoursewareCaseRelaInfoEN.FileUpTime = objRow[convCoursewareCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvCoursewareCaseRelaInfoEN.IdResource = objRow[convCoursewareCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvCoursewareCaseRelaInfoEN.ResourceID = objRow[convCoursewareCaseRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvCoursewareCaseRelaInfoEN.SaveMode = TransNullToBool(objRow[convCoursewareCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvCoursewareCaseRelaInfoEN.IdResourceType = objRow[convCoursewareCaseRelaInfo.IdResourceType] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvCoursewareCaseRelaInfoEN.ResourceTypeID = objRow[convCoursewareCaseRelaInfo.ResourceTypeID] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvCoursewareCaseRelaInfoEN.ResourceTypeName = objRow[convCoursewareCaseRelaInfo.ResourceTypeName] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvCoursewareCaseRelaInfoEN.MajorName = objRow[convCoursewareCaseRelaInfo.MajorName] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.MajorName].ToString().Trim(); //专业名称
objvCoursewareCaseRelaInfoEN.CollegeID = objRow[convCoursewareCaseRelaInfo.CollegeID] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.CollegeID].ToString().Trim(); //学院ID
objvCoursewareCaseRelaInfoEN.CollegeName = objRow[convCoursewareCaseRelaInfo.CollegeName] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.CollegeName].ToString().Trim(); //学院名称
objvCoursewareCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convCoursewareCaseRelaInfo.IdMicroTeachCaseRelaInfoType] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvCoursewareCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convCoursewareCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objvCoursewareCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convCoursewareCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvCoursewareCaseRelaInfoEN.BrowseCount = objRow[convCoursewareCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvCoursewareCaseRelaInfoEN.ResourceOwner = objRow[convCoursewareCaseRelaInfo.ResourceOwner] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvCoursewareCaseRelaInfoEN.ftpFileType = objRow[convCoursewareCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvCoursewareCaseRelaInfoEN.ftpFileSize = objRow[convCoursewareCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvCoursewareCaseRelaInfoEN.ftpResourceOwner = objRow[convCoursewareCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvCoursewareCaseRelaInfoEN.FileOriginName = objRow[convCoursewareCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvCoursewareCaseRelaInfoEN.UpdDate = objRow[convCoursewareCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvCoursewareCaseRelaInfoEN.UpdUser = objRow[convCoursewareCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objvCoursewareCaseRelaInfoEN.IsExistFile = TransNullToBool(objRow[convCoursewareCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvCoursewareCaseRelaInfoEN.Flag = objRow[convCoursewareCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.Flag].ToString().Trim(); //标志
objvCoursewareCaseRelaInfoEN.FuncModuleName = objRow[convCoursewareCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvCoursewareCaseRelaInfoEN.FuncModuleId = objRow[convCoursewareCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvCoursewareCaseRelaInfoEN.FileNewName = objRow[convCoursewareCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvCoursewareCaseRelaInfoEN.FileOldName = objRow[convCoursewareCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvCoursewareCaseRelaInfoEN.CoursewareCaseName = objRow[convCoursewareCaseRelaInfo.CoursewareCaseName] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.CoursewareCaseName].ToString().Trim(); //课件教学案例名称
objvCoursewareCaseRelaInfoEN.IdCoursewareCase = objRow[convCoursewareCaseRelaInfo.IdCoursewareCase] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.IdCoursewareCase].ToString().Trim(); //课件教学案例流水号
objvCoursewareCaseRelaInfoEN.IsVisible = TransNullToBool(objRow[convCoursewareCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvCoursewareCaseRelaInfoEN.Memo = objRow[convCoursewareCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.Memo].ToString().Trim(); //备注
objvCoursewareCaseRelaInfoEN.IdXzCollege = objRow[convCoursewareCaseRelaInfo.IdXzCollege] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.IdXzCollege].ToString().Trim(); //学院流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvCoursewareCaseRelaInfoDA: GetObjByDataRowvCoursewareCaseRelaInfo)", objException.Message));
}
objvCoursewareCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCoursewareCaseRelaInfoEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvCoursewareCaseRelaInfoEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCoursewareCaseRelaInfoEN objvCoursewareCaseRelaInfoEN = new clsvCoursewareCaseRelaInfoEN();
try
{
objvCoursewareCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = TransNullToInt(objRow[convCoursewareCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvCoursewareCaseRelaInfoEN.IdFile = objRow[convCoursewareCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvCoursewareCaseRelaInfoEN.FileName = objRow[convCoursewareCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvCoursewareCaseRelaInfoEN.FileType = objRow[convCoursewareCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvCoursewareCaseRelaInfoEN.SaveDate = objRow[convCoursewareCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvCoursewareCaseRelaInfoEN.FileSize = objRow[convCoursewareCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvCoursewareCaseRelaInfoEN.SaveTime = objRow[convCoursewareCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvCoursewareCaseRelaInfoEN.IdMicroteachCase = objRow[convCoursewareCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCoursewareCaseRelaInfoEN.IdFtpResource = objRow[convCoursewareCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvCoursewareCaseRelaInfoEN.FtpResourceID = objRow[convCoursewareCaseRelaInfo.FtpResourceID] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvCoursewareCaseRelaInfoEN.FileOriginalName = objRow[convCoursewareCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvCoursewareCaseRelaInfoEN.FileDirName = objRow[convCoursewareCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvCoursewareCaseRelaInfoEN.FileRename = objRow[convCoursewareCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvCoursewareCaseRelaInfoEN.FileUpDate = objRow[convCoursewareCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvCoursewareCaseRelaInfoEN.FileUpTime = objRow[convCoursewareCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvCoursewareCaseRelaInfoEN.IdResource = objRow[convCoursewareCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvCoursewareCaseRelaInfoEN.ResourceID = objRow[convCoursewareCaseRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvCoursewareCaseRelaInfoEN.SaveMode = TransNullToBool(objRow[convCoursewareCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvCoursewareCaseRelaInfoEN.IdResourceType = objRow[convCoursewareCaseRelaInfo.IdResourceType] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvCoursewareCaseRelaInfoEN.ResourceTypeID = objRow[convCoursewareCaseRelaInfo.ResourceTypeID] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvCoursewareCaseRelaInfoEN.ResourceTypeName = objRow[convCoursewareCaseRelaInfo.ResourceTypeName] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvCoursewareCaseRelaInfoEN.MajorName = objRow[convCoursewareCaseRelaInfo.MajorName] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.MajorName].ToString().Trim(); //专业名称
objvCoursewareCaseRelaInfoEN.CollegeID = objRow[convCoursewareCaseRelaInfo.CollegeID] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.CollegeID].ToString().Trim(); //学院ID
objvCoursewareCaseRelaInfoEN.CollegeName = objRow[convCoursewareCaseRelaInfo.CollegeName] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.CollegeName].ToString().Trim(); //学院名称
objvCoursewareCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convCoursewareCaseRelaInfo.IdMicroTeachCaseRelaInfoType] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvCoursewareCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convCoursewareCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objvCoursewareCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convCoursewareCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvCoursewareCaseRelaInfoEN.BrowseCount = objRow[convCoursewareCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvCoursewareCaseRelaInfoEN.ResourceOwner = objRow[convCoursewareCaseRelaInfo.ResourceOwner] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvCoursewareCaseRelaInfoEN.ftpFileType = objRow[convCoursewareCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvCoursewareCaseRelaInfoEN.ftpFileSize = objRow[convCoursewareCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvCoursewareCaseRelaInfoEN.ftpResourceOwner = objRow[convCoursewareCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvCoursewareCaseRelaInfoEN.FileOriginName = objRow[convCoursewareCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvCoursewareCaseRelaInfoEN.UpdDate = objRow[convCoursewareCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvCoursewareCaseRelaInfoEN.UpdUser = objRow[convCoursewareCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objvCoursewareCaseRelaInfoEN.IsExistFile = TransNullToBool(objRow[convCoursewareCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvCoursewareCaseRelaInfoEN.Flag = objRow[convCoursewareCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.Flag].ToString().Trim(); //标志
objvCoursewareCaseRelaInfoEN.FuncModuleName = objRow[convCoursewareCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvCoursewareCaseRelaInfoEN.FuncModuleId = objRow[convCoursewareCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvCoursewareCaseRelaInfoEN.FileNewName = objRow[convCoursewareCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvCoursewareCaseRelaInfoEN.FileOldName = objRow[convCoursewareCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvCoursewareCaseRelaInfoEN.CoursewareCaseName = objRow[convCoursewareCaseRelaInfo.CoursewareCaseName] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.CoursewareCaseName].ToString().Trim(); //课件教学案例名称
objvCoursewareCaseRelaInfoEN.IdCoursewareCase = objRow[convCoursewareCaseRelaInfo.IdCoursewareCase] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.IdCoursewareCase].ToString().Trim(); //课件教学案例流水号
objvCoursewareCaseRelaInfoEN.IsVisible = TransNullToBool(objRow[convCoursewareCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvCoursewareCaseRelaInfoEN.Memo = objRow[convCoursewareCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.Memo].ToString().Trim(); //备注
objvCoursewareCaseRelaInfoEN.IdXzCollege = objRow[convCoursewareCaseRelaInfo.IdXzCollege] == DBNull.Value ? null : objRow[convCoursewareCaseRelaInfo.IdXzCollege].ToString().Trim(); //学院流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvCoursewareCaseRelaInfoDA: GetObjByDataRow)", objException.Message));
}
objvCoursewareCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCoursewareCaseRelaInfoEN;
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
objSQL = clsvCoursewareCaseRelaInfoDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCoursewareCaseRelaInfoEN._CurrTabName, convCoursewareCaseRelaInfo.IdMicroTeachCaseRelaInfo, 8, "");
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
objSQL = clsvCoursewareCaseRelaInfoDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCoursewareCaseRelaInfoEN._CurrTabName, convCoursewareCaseRelaInfo.IdMicroTeachCaseRelaInfo, 8, strPrefix);
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
 objSQL = clsvCoursewareCaseRelaInfoDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdMicroTeachCaseRelaInfo from vCoursewareCaseRelaInfo where " + strCondition;
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
 objSQL = clsvCoursewareCaseRelaInfoDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdMicroTeachCaseRelaInfo from vCoursewareCaseRelaInfo where " + strCondition;
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
 objSQL = clsvCoursewareCaseRelaInfoDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCoursewareCaseRelaInfo", "IdMicroTeachCaseRelaInfo = " + ""+ lngIdMicroTeachCaseRelaInfo+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvCoursewareCaseRelaInfoDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCaseRelaInfoDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCoursewareCaseRelaInfo", strCondition))
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
objSQL = clsvCoursewareCaseRelaInfoDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vCoursewareCaseRelaInfo");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvCoursewareCaseRelaInfoENS">源对象</param>
 /// <param name = "objvCoursewareCaseRelaInfoENT">目标对象</param>
public void CopyTo(clsvCoursewareCaseRelaInfoEN objvCoursewareCaseRelaInfoENS, clsvCoursewareCaseRelaInfoEN objvCoursewareCaseRelaInfoENT)
{
objvCoursewareCaseRelaInfoENT.IdMicroTeachCaseRelaInfo = objvCoursewareCaseRelaInfoENS.IdMicroTeachCaseRelaInfo; //案例相关信息流水号
objvCoursewareCaseRelaInfoENT.IdFile = objvCoursewareCaseRelaInfoENS.IdFile; //文件流水号
objvCoursewareCaseRelaInfoENT.FileName = objvCoursewareCaseRelaInfoENS.FileName; //文件名称
objvCoursewareCaseRelaInfoENT.FileType = objvCoursewareCaseRelaInfoENS.FileType; //文件类型
objvCoursewareCaseRelaInfoENT.SaveDate = objvCoursewareCaseRelaInfoENS.SaveDate; //创建日期
objvCoursewareCaseRelaInfoENT.FileSize = objvCoursewareCaseRelaInfoENS.FileSize; //文件大小
objvCoursewareCaseRelaInfoENT.SaveTime = objvCoursewareCaseRelaInfoENS.SaveTime; //创建时间
objvCoursewareCaseRelaInfoENT.IdMicroteachCase = objvCoursewareCaseRelaInfoENS.IdMicroteachCase; //微格教学案例流水号
objvCoursewareCaseRelaInfoENT.IdFtpResource = objvCoursewareCaseRelaInfoENS.IdFtpResource; //FTP资源流水号
objvCoursewareCaseRelaInfoENT.FtpResourceID = objvCoursewareCaseRelaInfoENS.FtpResourceID; //FTP资源ID
objvCoursewareCaseRelaInfoENT.FileOriginalName = objvCoursewareCaseRelaInfoENS.FileOriginalName; //文件原名
objvCoursewareCaseRelaInfoENT.FileDirName = objvCoursewareCaseRelaInfoENS.FileDirName; //文件目录名
objvCoursewareCaseRelaInfoENT.FileRename = objvCoursewareCaseRelaInfoENS.FileRename; //文件新名
objvCoursewareCaseRelaInfoENT.FileUpDate = objvCoursewareCaseRelaInfoENS.FileUpDate; //创建日期
objvCoursewareCaseRelaInfoENT.FileUpTime = objvCoursewareCaseRelaInfoENS.FileUpTime; //创建时间
objvCoursewareCaseRelaInfoENT.IdResource = objvCoursewareCaseRelaInfoENS.IdResource; //资源流水号
objvCoursewareCaseRelaInfoENT.ResourceID = objvCoursewareCaseRelaInfoENS.ResourceID; //资源ID
objvCoursewareCaseRelaInfoENT.SaveMode = objvCoursewareCaseRelaInfoENS.SaveMode; //文件存放方式
objvCoursewareCaseRelaInfoENT.IdResourceType = objvCoursewareCaseRelaInfoENS.IdResourceType; //资源类型流水号
objvCoursewareCaseRelaInfoENT.ResourceTypeID = objvCoursewareCaseRelaInfoENS.ResourceTypeID; //资源类型ID
objvCoursewareCaseRelaInfoENT.ResourceTypeName = objvCoursewareCaseRelaInfoENS.ResourceTypeName; //资源类型名称
objvCoursewareCaseRelaInfoENT.MajorName = objvCoursewareCaseRelaInfoENS.MajorName; //专业名称
objvCoursewareCaseRelaInfoENT.CollegeID = objvCoursewareCaseRelaInfoENS.CollegeID; //学院ID
objvCoursewareCaseRelaInfoENT.CollegeName = objvCoursewareCaseRelaInfoENS.CollegeName; //学院名称
objvCoursewareCaseRelaInfoENT.IdMicroTeachCaseRelaInfoType = objvCoursewareCaseRelaInfoENS.IdMicroTeachCaseRelaInfoType; //微格案例相关信息类型流水号
objvCoursewareCaseRelaInfoENT.MicroTeachCaseRelaInfoTypeID = objvCoursewareCaseRelaInfoENS.MicroTeachCaseRelaInfoTypeID; //微格案例相关信息类型ID
objvCoursewareCaseRelaInfoENT.MicroTeachCaseRelaInfoTypeName = objvCoursewareCaseRelaInfoENS.MicroTeachCaseRelaInfoTypeName; //微格案例相关信息类型名称
objvCoursewareCaseRelaInfoENT.BrowseCount = objvCoursewareCaseRelaInfoENS.BrowseCount; //浏览次数
objvCoursewareCaseRelaInfoENT.ResourceOwner = objvCoursewareCaseRelaInfoENS.ResourceOwner; //上传者
objvCoursewareCaseRelaInfoENT.ftpFileType = objvCoursewareCaseRelaInfoENS.ftpFileType; //ftp文件类型
objvCoursewareCaseRelaInfoENT.ftpFileSize = objvCoursewareCaseRelaInfoENS.ftpFileSize; //ftp文件大小
objvCoursewareCaseRelaInfoENT.ftpResourceOwner = objvCoursewareCaseRelaInfoENS.ftpResourceOwner; //Ftp资源拥有者
objvCoursewareCaseRelaInfoENT.FileOriginName = objvCoursewareCaseRelaInfoENS.FileOriginName; //原文件名
objvCoursewareCaseRelaInfoENT.UpdDate = objvCoursewareCaseRelaInfoENS.UpdDate; //修改日期
objvCoursewareCaseRelaInfoENT.UpdUser = objvCoursewareCaseRelaInfoENS.UpdUser; //修改人
objvCoursewareCaseRelaInfoENT.IsExistFile = objvCoursewareCaseRelaInfoENS.IsExistFile; //是否存在文件
objvCoursewareCaseRelaInfoENT.Flag = objvCoursewareCaseRelaInfoENS.Flag; //标志
objvCoursewareCaseRelaInfoENT.FuncModuleName = objvCoursewareCaseRelaInfoENS.FuncModuleName; //功能模块名称
objvCoursewareCaseRelaInfoENT.FuncModuleId = objvCoursewareCaseRelaInfoENS.FuncModuleId; //功能模块Id
objvCoursewareCaseRelaInfoENT.FileNewName = objvCoursewareCaseRelaInfoENS.FileNewName; //新文件名
objvCoursewareCaseRelaInfoENT.FileOldName = objvCoursewareCaseRelaInfoENS.FileOldName; //旧文件名
objvCoursewareCaseRelaInfoENT.CoursewareCaseName = objvCoursewareCaseRelaInfoENS.CoursewareCaseName; //课件教学案例名称
objvCoursewareCaseRelaInfoENT.IdCoursewareCase = objvCoursewareCaseRelaInfoENS.IdCoursewareCase; //课件教学案例流水号
objvCoursewareCaseRelaInfoENT.IsVisible = objvCoursewareCaseRelaInfoENS.IsVisible; //是否显示
objvCoursewareCaseRelaInfoENT.Memo = objvCoursewareCaseRelaInfoENS.Memo; //备注
objvCoursewareCaseRelaInfoENT.IdXzCollege = objvCoursewareCaseRelaInfoENS.IdXzCollege; //学院流水号
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvCoursewareCaseRelaInfoEN objvCoursewareCaseRelaInfoEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvCoursewareCaseRelaInfoEN.IdFile, 8, convCoursewareCaseRelaInfo.IdFile);
clsCheckSql.CheckFieldLen(objvCoursewareCaseRelaInfoEN.FileName, 500, convCoursewareCaseRelaInfo.FileName);
clsCheckSql.CheckFieldLen(objvCoursewareCaseRelaInfoEN.FileType, 30, convCoursewareCaseRelaInfo.FileType);
clsCheckSql.CheckFieldLen(objvCoursewareCaseRelaInfoEN.SaveDate, 8, convCoursewareCaseRelaInfo.SaveDate);
clsCheckSql.CheckFieldLen(objvCoursewareCaseRelaInfoEN.FileSize, 50, convCoursewareCaseRelaInfo.FileSize);
clsCheckSql.CheckFieldLen(objvCoursewareCaseRelaInfoEN.SaveTime, 6, convCoursewareCaseRelaInfo.SaveTime);
clsCheckSql.CheckFieldLen(objvCoursewareCaseRelaInfoEN.IdMicroteachCase, 8, convCoursewareCaseRelaInfo.IdMicroteachCase);
clsCheckSql.CheckFieldLen(objvCoursewareCaseRelaInfoEN.IdFtpResource, 8, convCoursewareCaseRelaInfo.IdFtpResource);
clsCheckSql.CheckFieldLen(objvCoursewareCaseRelaInfoEN.FtpResourceID, 8, convCoursewareCaseRelaInfo.FtpResourceID);
clsCheckSql.CheckFieldLen(objvCoursewareCaseRelaInfoEN.FileOriginalName, 200, convCoursewareCaseRelaInfo.FileOriginalName);
clsCheckSql.CheckFieldLen(objvCoursewareCaseRelaInfoEN.FileDirName, 200, convCoursewareCaseRelaInfo.FileDirName);
clsCheckSql.CheckFieldLen(objvCoursewareCaseRelaInfoEN.FileRename, 200, convCoursewareCaseRelaInfo.FileRename);
clsCheckSql.CheckFieldLen(objvCoursewareCaseRelaInfoEN.FileUpDate, 8, convCoursewareCaseRelaInfo.FileUpDate);
clsCheckSql.CheckFieldLen(objvCoursewareCaseRelaInfoEN.FileUpTime, 6, convCoursewareCaseRelaInfo.FileUpTime);
clsCheckSql.CheckFieldLen(objvCoursewareCaseRelaInfoEN.IdResource, 8, convCoursewareCaseRelaInfo.IdResource);
clsCheckSql.CheckFieldLen(objvCoursewareCaseRelaInfoEN.ResourceID, 8, convCoursewareCaseRelaInfo.ResourceID);
clsCheckSql.CheckFieldLen(objvCoursewareCaseRelaInfoEN.IdResourceType, 4, convCoursewareCaseRelaInfo.IdResourceType);
clsCheckSql.CheckFieldLen(objvCoursewareCaseRelaInfoEN.ResourceTypeID, 4, convCoursewareCaseRelaInfo.ResourceTypeID);
clsCheckSql.CheckFieldLen(objvCoursewareCaseRelaInfoEN.ResourceTypeName, 50, convCoursewareCaseRelaInfo.ResourceTypeName);
clsCheckSql.CheckFieldLen(objvCoursewareCaseRelaInfoEN.MajorName, 100, convCoursewareCaseRelaInfo.MajorName);
clsCheckSql.CheckFieldLen(objvCoursewareCaseRelaInfoEN.CollegeID, 4, convCoursewareCaseRelaInfo.CollegeID);
clsCheckSql.CheckFieldLen(objvCoursewareCaseRelaInfoEN.CollegeName, 100, convCoursewareCaseRelaInfo.CollegeName);
clsCheckSql.CheckFieldLen(objvCoursewareCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType, 4, convCoursewareCaseRelaInfo.IdMicroTeachCaseRelaInfoType);
clsCheckSql.CheckFieldLen(objvCoursewareCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID, 4, convCoursewareCaseRelaInfo.MicroTeachCaseRelaInfoTypeID);
clsCheckSql.CheckFieldLen(objvCoursewareCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName, 50, convCoursewareCaseRelaInfo.MicroTeachCaseRelaInfoTypeName);
clsCheckSql.CheckFieldLen(objvCoursewareCaseRelaInfoEN.ResourceOwner, 50, convCoursewareCaseRelaInfo.ResourceOwner);
clsCheckSql.CheckFieldLen(objvCoursewareCaseRelaInfoEN.ftpFileType, 30, convCoursewareCaseRelaInfo.ftpFileType);
clsCheckSql.CheckFieldLen(objvCoursewareCaseRelaInfoEN.ftpFileSize, 50, convCoursewareCaseRelaInfo.ftpFileSize);
clsCheckSql.CheckFieldLen(objvCoursewareCaseRelaInfoEN.ftpResourceOwner, 50, convCoursewareCaseRelaInfo.ftpResourceOwner);
clsCheckSql.CheckFieldLen(objvCoursewareCaseRelaInfoEN.FileOriginName, 500, convCoursewareCaseRelaInfo.FileOriginName);
clsCheckSql.CheckFieldLen(objvCoursewareCaseRelaInfoEN.UpdDate, 20, convCoursewareCaseRelaInfo.UpdDate);
clsCheckSql.CheckFieldLen(objvCoursewareCaseRelaInfoEN.UpdUser, 20, convCoursewareCaseRelaInfo.UpdUser);
clsCheckSql.CheckFieldLen(objvCoursewareCaseRelaInfoEN.Flag, 50, convCoursewareCaseRelaInfo.Flag);
clsCheckSql.CheckFieldLen(objvCoursewareCaseRelaInfoEN.FuncModuleName, 30, convCoursewareCaseRelaInfo.FuncModuleName);
clsCheckSql.CheckFieldLen(objvCoursewareCaseRelaInfoEN.FuncModuleId, 4, convCoursewareCaseRelaInfo.FuncModuleId);
clsCheckSql.CheckFieldLen(objvCoursewareCaseRelaInfoEN.FileNewName, 530, convCoursewareCaseRelaInfo.FileNewName);
clsCheckSql.CheckFieldLen(objvCoursewareCaseRelaInfoEN.FileOldName, 530, convCoursewareCaseRelaInfo.FileOldName);
clsCheckSql.CheckFieldLen(objvCoursewareCaseRelaInfoEN.CoursewareCaseName, 100, convCoursewareCaseRelaInfo.CoursewareCaseName);
clsCheckSql.CheckFieldLen(objvCoursewareCaseRelaInfoEN.IdCoursewareCase, 8, convCoursewareCaseRelaInfo.IdCoursewareCase);
clsCheckSql.CheckFieldLen(objvCoursewareCaseRelaInfoEN.Memo, 1000, convCoursewareCaseRelaInfo.Memo);
clsCheckSql.CheckFieldLen(objvCoursewareCaseRelaInfoEN.IdXzCollege, 4, convCoursewareCaseRelaInfo.IdXzCollege);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseRelaInfoEN.IdFile, convCoursewareCaseRelaInfo.IdFile);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseRelaInfoEN.FileName, convCoursewareCaseRelaInfo.FileName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseRelaInfoEN.FileType, convCoursewareCaseRelaInfo.FileType);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseRelaInfoEN.SaveDate, convCoursewareCaseRelaInfo.SaveDate);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseRelaInfoEN.FileSize, convCoursewareCaseRelaInfo.FileSize);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseRelaInfoEN.SaveTime, convCoursewareCaseRelaInfo.SaveTime);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseRelaInfoEN.IdMicroteachCase, convCoursewareCaseRelaInfo.IdMicroteachCase);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseRelaInfoEN.IdFtpResource, convCoursewareCaseRelaInfo.IdFtpResource);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseRelaInfoEN.FtpResourceID, convCoursewareCaseRelaInfo.FtpResourceID);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseRelaInfoEN.FileOriginalName, convCoursewareCaseRelaInfo.FileOriginalName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseRelaInfoEN.FileDirName, convCoursewareCaseRelaInfo.FileDirName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseRelaInfoEN.FileRename, convCoursewareCaseRelaInfo.FileRename);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseRelaInfoEN.FileUpDate, convCoursewareCaseRelaInfo.FileUpDate);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseRelaInfoEN.FileUpTime, convCoursewareCaseRelaInfo.FileUpTime);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseRelaInfoEN.IdResource, convCoursewareCaseRelaInfo.IdResource);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseRelaInfoEN.ResourceID, convCoursewareCaseRelaInfo.ResourceID);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseRelaInfoEN.IdResourceType, convCoursewareCaseRelaInfo.IdResourceType);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseRelaInfoEN.ResourceTypeID, convCoursewareCaseRelaInfo.ResourceTypeID);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseRelaInfoEN.ResourceTypeName, convCoursewareCaseRelaInfo.ResourceTypeName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseRelaInfoEN.MajorName, convCoursewareCaseRelaInfo.MajorName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseRelaInfoEN.CollegeID, convCoursewareCaseRelaInfo.CollegeID);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseRelaInfoEN.CollegeName, convCoursewareCaseRelaInfo.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType, convCoursewareCaseRelaInfo.IdMicroTeachCaseRelaInfoType);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID, convCoursewareCaseRelaInfo.MicroTeachCaseRelaInfoTypeID);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName, convCoursewareCaseRelaInfo.MicroTeachCaseRelaInfoTypeName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseRelaInfoEN.ResourceOwner, convCoursewareCaseRelaInfo.ResourceOwner);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseRelaInfoEN.ftpFileType, convCoursewareCaseRelaInfo.ftpFileType);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseRelaInfoEN.ftpFileSize, convCoursewareCaseRelaInfo.ftpFileSize);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseRelaInfoEN.ftpResourceOwner, convCoursewareCaseRelaInfo.ftpResourceOwner);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseRelaInfoEN.FileOriginName, convCoursewareCaseRelaInfo.FileOriginName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseRelaInfoEN.UpdDate, convCoursewareCaseRelaInfo.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseRelaInfoEN.UpdUser, convCoursewareCaseRelaInfo.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseRelaInfoEN.Flag, convCoursewareCaseRelaInfo.Flag);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseRelaInfoEN.FuncModuleName, convCoursewareCaseRelaInfo.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseRelaInfoEN.FuncModuleId, convCoursewareCaseRelaInfo.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseRelaInfoEN.FileNewName, convCoursewareCaseRelaInfo.FileNewName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseRelaInfoEN.FileOldName, convCoursewareCaseRelaInfo.FileOldName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseRelaInfoEN.CoursewareCaseName, convCoursewareCaseRelaInfo.CoursewareCaseName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseRelaInfoEN.IdCoursewareCase, convCoursewareCaseRelaInfo.IdCoursewareCase);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseRelaInfoEN.Memo, convCoursewareCaseRelaInfo.Memo);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseRelaInfoEN.IdXzCollege, convCoursewareCaseRelaInfo.IdXzCollege);
//检查外键字段长度
 objvCoursewareCaseRelaInfoEN._IsCheckProperty = true;
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
 objSQL = clsvCoursewareCaseRelaInfoDA.GetSpecSQLObj();
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
 objSQL = clsvCoursewareCaseRelaInfoDA.GetSpecSQLObj();
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
 objSQL = clsvCoursewareCaseRelaInfoDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCoursewareCaseRelaInfoEN._CurrTabName);
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
 objSQL = clsvCoursewareCaseRelaInfoDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCoursewareCaseRelaInfoEN._CurrTabName, strCondition);
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
 objSQL = clsvCoursewareCaseRelaInfoDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}