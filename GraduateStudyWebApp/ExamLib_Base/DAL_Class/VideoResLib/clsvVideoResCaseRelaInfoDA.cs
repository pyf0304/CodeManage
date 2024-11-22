
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvVideoResCaseRelaInfoDA
 表名:vVideoResCaseRelaInfo(01120398)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:51:04
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
 /// v视频资源案例相关信息(vVideoResCaseRelaInfo)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvVideoResCaseRelaInfoDA : clsCommBase4DA
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
 return clsvVideoResCaseRelaInfoEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvVideoResCaseRelaInfoEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvVideoResCaseRelaInfoEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvVideoResCaseRelaInfoEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvVideoResCaseRelaInfoEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvVideoResCaseRelaInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vVideoResCaseRelaInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vVideoResCaseRelaInfo(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvVideoResCaseRelaInfoDA: GetDataTable_vVideoResCaseRelaInfo)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vVideoResCaseRelaInfo where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvVideoResCaseRelaInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCaseRelaInfoDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvVideoResCaseRelaInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vVideoResCaseRelaInfo where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvVideoResCaseRelaInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCaseRelaInfoDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvVideoResCaseRelaInfoDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCaseRelaInfoDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vVideoResCaseRelaInfo where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vVideoResCaseRelaInfo where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvVideoResCaseRelaInfoDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCaseRelaInfoDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vVideoResCaseRelaInfo where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvVideoResCaseRelaInfoDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCaseRelaInfoDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vVideoResCaseRelaInfo.* from vVideoResCaseRelaInfo Left Join {1} on {2} where {3} and vVideoResCaseRelaInfo.IdMicroTeachCaseRelaInfo not in (Select top {5} vVideoResCaseRelaInfo.IdMicroTeachCaseRelaInfo from vVideoResCaseRelaInfo Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vVideoResCaseRelaInfo where {1} and IdMicroTeachCaseRelaInfo not in (Select top {2} IdMicroTeachCaseRelaInfo from vVideoResCaseRelaInfo where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vVideoResCaseRelaInfo where {1} and IdMicroTeachCaseRelaInfo not in (Select top {3} IdMicroTeachCaseRelaInfo from vVideoResCaseRelaInfo where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvVideoResCaseRelaInfoDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCaseRelaInfoDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vVideoResCaseRelaInfo.* from vVideoResCaseRelaInfo Left Join {1} on {2} where {3} and vVideoResCaseRelaInfo.IdMicroTeachCaseRelaInfo not in (Select top {5} vVideoResCaseRelaInfo.IdMicroTeachCaseRelaInfo from vVideoResCaseRelaInfo Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vVideoResCaseRelaInfo where {1} and IdMicroTeachCaseRelaInfo not in (Select top {2} IdMicroTeachCaseRelaInfo from vVideoResCaseRelaInfo where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vVideoResCaseRelaInfo where {1} and IdMicroTeachCaseRelaInfo not in (Select top {3} IdMicroTeachCaseRelaInfo from vVideoResCaseRelaInfo where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvVideoResCaseRelaInfoEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvVideoResCaseRelaInfoDA:GetObjLst)", objException.Message));
}
List<clsvVideoResCaseRelaInfoEN> arrObjLst = new List<clsvVideoResCaseRelaInfoEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vVideoResCaseRelaInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoResCaseRelaInfoEN objvVideoResCaseRelaInfoEN = new clsvVideoResCaseRelaInfoEN();
try
{
objvVideoResCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = TransNullToInt(objRow[convVideoResCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvVideoResCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convVideoResCaseRelaInfo.IdMicroTeachCaseRelaInfoType] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvVideoResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convVideoResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objvVideoResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convVideoResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvVideoResCaseRelaInfoEN.IdMicroteachCase = objRow[convVideoResCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoResCaseRelaInfoEN.IdVideoResCase = objRow[convVideoResCaseRelaInfo.IdVideoResCase] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.IdVideoResCase].ToString().Trim(); //视频资源案例流水号
objvVideoResCaseRelaInfoEN.VideoResCaseName = objRow[convVideoResCaseRelaInfo.VideoResCaseName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.VideoResCaseName].ToString().Trim(); //视频资源案例名称
objvVideoResCaseRelaInfoEN.FileName = objRow[convVideoResCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvVideoResCaseRelaInfoEN.FileType = objRow[convVideoResCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvVideoResCaseRelaInfoEN.SaveDate = objRow[convVideoResCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvVideoResCaseRelaInfoEN.FileSize = objRow[convVideoResCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvVideoResCaseRelaInfoEN.SaveTime = objRow[convVideoResCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvVideoResCaseRelaInfoEN.IdFtpResource = objRow[convVideoResCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvVideoResCaseRelaInfoEN.FtpResourceID = objRow[convVideoResCaseRelaInfo.FtpResourceID] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvVideoResCaseRelaInfoEN.FileOriginalName = objRow[convVideoResCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvVideoResCaseRelaInfoEN.FileDirName = objRow[convVideoResCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvVideoResCaseRelaInfoEN.FileRename = objRow[convVideoResCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvVideoResCaseRelaInfoEN.FileUpDate = objRow[convVideoResCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvVideoResCaseRelaInfoEN.FileUpTime = objRow[convVideoResCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvVideoResCaseRelaInfoEN.IdResource = objRow[convVideoResCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvVideoResCaseRelaInfoEN.ResourceID = objRow[convVideoResCaseRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvVideoResCaseRelaInfoEN.SaveMode = TransNullToBool(objRow[convVideoResCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvVideoResCaseRelaInfoEN.IdResourceType = objRow[convVideoResCaseRelaInfo.IdResourceType] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvVideoResCaseRelaInfoEN.ResourceTypeID = objRow[convVideoResCaseRelaInfo.ResourceTypeID] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvVideoResCaseRelaInfoEN.ResourceTypeName = objRow[convVideoResCaseRelaInfo.ResourceTypeName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvVideoResCaseRelaInfoEN.MajorID = objRow[convVideoResCaseRelaInfo.MajorID] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.MajorID].ToString().Trim(); //专业ID
objvVideoResCaseRelaInfoEN.MajorName = objRow[convVideoResCaseRelaInfo.MajorName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.MajorName].ToString().Trim(); //专业名称
objvVideoResCaseRelaInfoEN.CourseCode = objRow[convVideoResCaseRelaInfo.CourseCode] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.CourseCode].ToString().Trim(); //课程代码
objvVideoResCaseRelaInfoEN.CollegeID = objRow[convVideoResCaseRelaInfo.CollegeID] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.CollegeID].ToString().Trim(); //学院ID
objvVideoResCaseRelaInfoEN.CollegeName = objRow[convVideoResCaseRelaInfo.CollegeName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.CollegeName].ToString().Trim(); //学院名称
objvVideoResCaseRelaInfoEN.CourseName = objRow[convVideoResCaseRelaInfo.CourseName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.CourseName].ToString().Trim(); //课程名称
objvVideoResCaseRelaInfoEN.BrowseCount = objRow[convVideoResCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvVideoResCaseRelaInfoEN.ResourceOwner = objRow[convVideoResCaseRelaInfo.ResourceOwner] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvVideoResCaseRelaInfoEN.ftpFileType = objRow[convVideoResCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvVideoResCaseRelaInfoEN.ftpFileSize = objRow[convVideoResCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvVideoResCaseRelaInfoEN.ftpResourceOwner = objRow[convVideoResCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvVideoResCaseRelaInfoEN.FileOriginName = objRow[convVideoResCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvVideoResCaseRelaInfoEN.IsExistFile = TransNullToBool(objRow[convVideoResCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvVideoResCaseRelaInfoEN.Flag = objRow[convVideoResCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.Flag].ToString().Trim(); //标志
objvVideoResCaseRelaInfoEN.FuncModuleName = objRow[convVideoResCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoResCaseRelaInfoEN.FuncModuleId = objRow[convVideoResCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoResCaseRelaInfoEN.FileNewName = objRow[convVideoResCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvVideoResCaseRelaInfoEN.FileOldName = objRow[convVideoResCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvVideoResCaseRelaInfoEN.IsVisible = TransNullToBool(objRow[convVideoResCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvVideoResCaseRelaInfoEN.IdFile = objRow[convVideoResCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvVideoResCaseRelaInfoEN.UpdDate = objRow[convVideoResCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvVideoResCaseRelaInfoEN.UpdUser = objRow[convVideoResCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objvVideoResCaseRelaInfoEN.Memo = objRow[convVideoResCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.Memo].ToString().Trim(); //备注
objvVideoResCaseRelaInfoEN.CourseId = objRow[convVideoResCaseRelaInfo.CourseId] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.CourseId].ToString().Trim(); //课程Id
objvVideoResCaseRelaInfoEN.IdXzCollege = objRow[convVideoResCaseRelaInfo.IdXzCollege] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoResCaseRelaInfoEN.CollegeNameA = objRow[convVideoResCaseRelaInfo.CollegeNameA] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.CollegeNameA].ToString().Trim(); //学院名称简写
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvVideoResCaseRelaInfoDA: GetObjLst)", objException.Message));
}
objvVideoResCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvVideoResCaseRelaInfoEN);
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
public List<clsvVideoResCaseRelaInfoEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvVideoResCaseRelaInfoDA:GetObjLstByTabName)", objException.Message));
}
List<clsvVideoResCaseRelaInfoEN> arrObjLst = new List<clsvVideoResCaseRelaInfoEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCaseRelaInfoDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoResCaseRelaInfoEN objvVideoResCaseRelaInfoEN = new clsvVideoResCaseRelaInfoEN();
try
{
objvVideoResCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = TransNullToInt(objRow[convVideoResCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvVideoResCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convVideoResCaseRelaInfo.IdMicroTeachCaseRelaInfoType] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvVideoResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convVideoResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objvVideoResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convVideoResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvVideoResCaseRelaInfoEN.IdMicroteachCase = objRow[convVideoResCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoResCaseRelaInfoEN.IdVideoResCase = objRow[convVideoResCaseRelaInfo.IdVideoResCase] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.IdVideoResCase].ToString().Trim(); //视频资源案例流水号
objvVideoResCaseRelaInfoEN.VideoResCaseName = objRow[convVideoResCaseRelaInfo.VideoResCaseName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.VideoResCaseName].ToString().Trim(); //视频资源案例名称
objvVideoResCaseRelaInfoEN.FileName = objRow[convVideoResCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvVideoResCaseRelaInfoEN.FileType = objRow[convVideoResCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvVideoResCaseRelaInfoEN.SaveDate = objRow[convVideoResCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvVideoResCaseRelaInfoEN.FileSize = objRow[convVideoResCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvVideoResCaseRelaInfoEN.SaveTime = objRow[convVideoResCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvVideoResCaseRelaInfoEN.IdFtpResource = objRow[convVideoResCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvVideoResCaseRelaInfoEN.FtpResourceID = objRow[convVideoResCaseRelaInfo.FtpResourceID] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvVideoResCaseRelaInfoEN.FileOriginalName = objRow[convVideoResCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvVideoResCaseRelaInfoEN.FileDirName = objRow[convVideoResCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvVideoResCaseRelaInfoEN.FileRename = objRow[convVideoResCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvVideoResCaseRelaInfoEN.FileUpDate = objRow[convVideoResCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvVideoResCaseRelaInfoEN.FileUpTime = objRow[convVideoResCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvVideoResCaseRelaInfoEN.IdResource = objRow[convVideoResCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvVideoResCaseRelaInfoEN.ResourceID = objRow[convVideoResCaseRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvVideoResCaseRelaInfoEN.SaveMode = TransNullToBool(objRow[convVideoResCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvVideoResCaseRelaInfoEN.IdResourceType = objRow[convVideoResCaseRelaInfo.IdResourceType] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvVideoResCaseRelaInfoEN.ResourceTypeID = objRow[convVideoResCaseRelaInfo.ResourceTypeID] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvVideoResCaseRelaInfoEN.ResourceTypeName = objRow[convVideoResCaseRelaInfo.ResourceTypeName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvVideoResCaseRelaInfoEN.MajorID = objRow[convVideoResCaseRelaInfo.MajorID] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.MajorID].ToString().Trim(); //专业ID
objvVideoResCaseRelaInfoEN.MajorName = objRow[convVideoResCaseRelaInfo.MajorName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.MajorName].ToString().Trim(); //专业名称
objvVideoResCaseRelaInfoEN.CourseCode = objRow[convVideoResCaseRelaInfo.CourseCode] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.CourseCode].ToString().Trim(); //课程代码
objvVideoResCaseRelaInfoEN.CollegeID = objRow[convVideoResCaseRelaInfo.CollegeID] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.CollegeID].ToString().Trim(); //学院ID
objvVideoResCaseRelaInfoEN.CollegeName = objRow[convVideoResCaseRelaInfo.CollegeName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.CollegeName].ToString().Trim(); //学院名称
objvVideoResCaseRelaInfoEN.CourseName = objRow[convVideoResCaseRelaInfo.CourseName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.CourseName].ToString().Trim(); //课程名称
objvVideoResCaseRelaInfoEN.BrowseCount = objRow[convVideoResCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvVideoResCaseRelaInfoEN.ResourceOwner = objRow[convVideoResCaseRelaInfo.ResourceOwner] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvVideoResCaseRelaInfoEN.ftpFileType = objRow[convVideoResCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvVideoResCaseRelaInfoEN.ftpFileSize = objRow[convVideoResCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvVideoResCaseRelaInfoEN.ftpResourceOwner = objRow[convVideoResCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvVideoResCaseRelaInfoEN.FileOriginName = objRow[convVideoResCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvVideoResCaseRelaInfoEN.IsExistFile = TransNullToBool(objRow[convVideoResCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvVideoResCaseRelaInfoEN.Flag = objRow[convVideoResCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.Flag].ToString().Trim(); //标志
objvVideoResCaseRelaInfoEN.FuncModuleName = objRow[convVideoResCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoResCaseRelaInfoEN.FuncModuleId = objRow[convVideoResCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoResCaseRelaInfoEN.FileNewName = objRow[convVideoResCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvVideoResCaseRelaInfoEN.FileOldName = objRow[convVideoResCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvVideoResCaseRelaInfoEN.IsVisible = TransNullToBool(objRow[convVideoResCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvVideoResCaseRelaInfoEN.IdFile = objRow[convVideoResCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvVideoResCaseRelaInfoEN.UpdDate = objRow[convVideoResCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvVideoResCaseRelaInfoEN.UpdUser = objRow[convVideoResCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objvVideoResCaseRelaInfoEN.Memo = objRow[convVideoResCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.Memo].ToString().Trim(); //备注
objvVideoResCaseRelaInfoEN.CourseId = objRow[convVideoResCaseRelaInfo.CourseId] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.CourseId].ToString().Trim(); //课程Id
objvVideoResCaseRelaInfoEN.IdXzCollege = objRow[convVideoResCaseRelaInfo.IdXzCollege] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoResCaseRelaInfoEN.CollegeNameA = objRow[convVideoResCaseRelaInfo.CollegeNameA] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.CollegeNameA].ToString().Trim(); //学院名称简写
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvVideoResCaseRelaInfoDA: GetObjLst)", objException.Message));
}
objvVideoResCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvVideoResCaseRelaInfoEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvVideoResCaseRelaInfoEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvVideoResCaseRelaInfo(ref clsvVideoResCaseRelaInfoEN objvVideoResCaseRelaInfoEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vVideoResCaseRelaInfo where IdMicroTeachCaseRelaInfo = " + ""+ objvVideoResCaseRelaInfoEN.IdMicroTeachCaseRelaInfo+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvVideoResCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = TransNullToInt(objDT.Rows[0][convVideoResCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvVideoResCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objDT.Rows[0][convVideoResCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objDT.Rows[0][convVideoResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objDT.Rows[0][convVideoResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvVideoResCaseRelaInfoEN.IdMicroteachCase = objDT.Rows[0][convVideoResCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoResCaseRelaInfoEN.IdVideoResCase = objDT.Rows[0][convVideoResCaseRelaInfo.IdVideoResCase].ToString().Trim(); //视频资源案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoResCaseRelaInfoEN.VideoResCaseName = objDT.Rows[0][convVideoResCaseRelaInfo.VideoResCaseName].ToString().Trim(); //视频资源案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvVideoResCaseRelaInfoEN.FileName = objDT.Rows[0][convVideoResCaseRelaInfo.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvVideoResCaseRelaInfoEN.FileType = objDT.Rows[0][convVideoResCaseRelaInfo.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvVideoResCaseRelaInfoEN.SaveDate = objDT.Rows[0][convVideoResCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvVideoResCaseRelaInfoEN.FileSize = objDT.Rows[0][convVideoResCaseRelaInfo.FileSize].ToString().Trim(); //文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvVideoResCaseRelaInfoEN.SaveTime = objDT.Rows[0][convVideoResCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvVideoResCaseRelaInfoEN.IdFtpResource = objDT.Rows[0][convVideoResCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objvVideoResCaseRelaInfoEN.FtpResourceID = objDT.Rows[0][convVideoResCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvVideoResCaseRelaInfoEN.FileOriginalName = objDT.Rows[0][convVideoResCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoResCaseRelaInfoEN.FileDirName = objDT.Rows[0][convVideoResCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoResCaseRelaInfoEN.FileRename = objDT.Rows[0][convVideoResCaseRelaInfo.FileRename].ToString().Trim(); //文件新名(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoResCaseRelaInfoEN.FileUpDate = objDT.Rows[0][convVideoResCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvVideoResCaseRelaInfoEN.FileUpTime = objDT.Rows[0][convVideoResCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvVideoResCaseRelaInfoEN.IdResource = objDT.Rows[0][convVideoResCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoResCaseRelaInfoEN.ResourceID = objDT.Rows[0][convVideoResCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvVideoResCaseRelaInfoEN.SaveMode = TransNullToBool(objDT.Rows[0][convVideoResCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式(字段类型:bit,字段长度:1,是否可空:True)
 objvVideoResCaseRelaInfoEN.IdResourceType = objDT.Rows[0][convVideoResCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCaseRelaInfoEN.ResourceTypeID = objDT.Rows[0][convVideoResCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCaseRelaInfoEN.ResourceTypeName = objDT.Rows[0][convVideoResCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvVideoResCaseRelaInfoEN.MajorID = objDT.Rows[0][convVideoResCaseRelaInfo.MajorID].ToString().Trim(); //专业ID(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCaseRelaInfoEN.MajorName = objDT.Rows[0][convVideoResCaseRelaInfo.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvVideoResCaseRelaInfoEN.CourseCode = objDT.Rows[0][convVideoResCaseRelaInfo.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvVideoResCaseRelaInfoEN.CollegeID = objDT.Rows[0][convVideoResCaseRelaInfo.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvVideoResCaseRelaInfoEN.CollegeName = objDT.Rows[0][convVideoResCaseRelaInfo.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvVideoResCaseRelaInfoEN.CourseName = objDT.Rows[0][convVideoResCaseRelaInfo.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvVideoResCaseRelaInfoEN.BrowseCount = TransNullToInt(objDT.Rows[0][convVideoResCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvVideoResCaseRelaInfoEN.ResourceOwner = objDT.Rows[0][convVideoResCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者(字段类型:varchar,字段长度:50,是否可空:False)
 objvVideoResCaseRelaInfoEN.ftpFileType = objDT.Rows[0][convVideoResCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvVideoResCaseRelaInfoEN.ftpFileSize = objDT.Rows[0][convVideoResCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvVideoResCaseRelaInfoEN.ftpResourceOwner = objDT.Rows[0][convVideoResCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者(字段类型:varchar,字段长度:50,是否可空:True)
 objvVideoResCaseRelaInfoEN.FileOriginName = objDT.Rows[0][convVideoResCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名(字段类型:varchar,字段长度:500,是否可空:True)
 objvVideoResCaseRelaInfoEN.IsExistFile = TransNullToBool(objDT.Rows[0][convVideoResCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objvVideoResCaseRelaInfoEN.Flag = objDT.Rows[0][convVideoResCaseRelaInfo.Flag].ToString().Trim(); //标志(字段类型:varchar,字段长度:50,是否可空:True)
 objvVideoResCaseRelaInfoEN.FuncModuleName = objDT.Rows[0][convVideoResCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvVideoResCaseRelaInfoEN.FuncModuleId = objDT.Rows[0][convVideoResCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvVideoResCaseRelaInfoEN.FileNewName = objDT.Rows[0][convVideoResCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvVideoResCaseRelaInfoEN.FileOldName = objDT.Rows[0][convVideoResCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvVideoResCaseRelaInfoEN.IsVisible = TransNullToBool(objDT.Rows[0][convVideoResCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvVideoResCaseRelaInfoEN.IdFile = objDT.Rows[0][convVideoResCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号(字段类型:char,字段长度:8,是否可空:True)
 objvVideoResCaseRelaInfoEN.UpdDate = objDT.Rows[0][convVideoResCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvVideoResCaseRelaInfoEN.UpdUser = objDT.Rows[0][convVideoResCaseRelaInfo.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvVideoResCaseRelaInfoEN.Memo = objDT.Rows[0][convVideoResCaseRelaInfo.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvVideoResCaseRelaInfoEN.CourseId = objDT.Rows[0][convVideoResCaseRelaInfo.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvVideoResCaseRelaInfoEN.IdXzCollege = objDT.Rows[0][convVideoResCaseRelaInfo.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvVideoResCaseRelaInfoEN.CollegeNameA = objDT.Rows[0][convVideoResCaseRelaInfo.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvVideoResCaseRelaInfoDA: GetvVideoResCaseRelaInfo)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdMicroTeachCaseRelaInfo">表关键字</param>
 /// <returns>表对象</returns>
public clsvVideoResCaseRelaInfoEN GetObjByIdMicroTeachCaseRelaInfo(long lngIdMicroTeachCaseRelaInfo)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vVideoResCaseRelaInfo where IdMicroTeachCaseRelaInfo = " + ""+ lngIdMicroTeachCaseRelaInfo+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvVideoResCaseRelaInfoEN objvVideoResCaseRelaInfoEN = new clsvVideoResCaseRelaInfoEN();
try
{
 objvVideoResCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = Int32.Parse(objRow[convVideoResCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvVideoResCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convVideoResCaseRelaInfo.IdMicroTeachCaseRelaInfoType] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convVideoResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convVideoResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvVideoResCaseRelaInfoEN.IdMicroteachCase = objRow[convVideoResCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoResCaseRelaInfoEN.IdVideoResCase = objRow[convVideoResCaseRelaInfo.IdVideoResCase] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.IdVideoResCase].ToString().Trim(); //视频资源案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoResCaseRelaInfoEN.VideoResCaseName = objRow[convVideoResCaseRelaInfo.VideoResCaseName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.VideoResCaseName].ToString().Trim(); //视频资源案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvVideoResCaseRelaInfoEN.FileName = objRow[convVideoResCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvVideoResCaseRelaInfoEN.FileType = objRow[convVideoResCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvVideoResCaseRelaInfoEN.SaveDate = objRow[convVideoResCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvVideoResCaseRelaInfoEN.FileSize = objRow[convVideoResCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FileSize].ToString().Trim(); //文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvVideoResCaseRelaInfoEN.SaveTime = objRow[convVideoResCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvVideoResCaseRelaInfoEN.IdFtpResource = objRow[convVideoResCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objvVideoResCaseRelaInfoEN.FtpResourceID = objRow[convVideoResCaseRelaInfo.FtpResourceID] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvVideoResCaseRelaInfoEN.FileOriginalName = objRow[convVideoResCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoResCaseRelaInfoEN.FileDirName = objRow[convVideoResCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoResCaseRelaInfoEN.FileRename = objRow[convVideoResCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FileRename].ToString().Trim(); //文件新名(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoResCaseRelaInfoEN.FileUpDate = objRow[convVideoResCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvVideoResCaseRelaInfoEN.FileUpTime = objRow[convVideoResCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvVideoResCaseRelaInfoEN.IdResource = objRow[convVideoResCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoResCaseRelaInfoEN.ResourceID = objRow[convVideoResCaseRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvVideoResCaseRelaInfoEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convVideoResCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式(字段类型:bit,字段长度:1,是否可空:True)
 objvVideoResCaseRelaInfoEN.IdResourceType = objRow[convVideoResCaseRelaInfo.IdResourceType] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCaseRelaInfoEN.ResourceTypeID = objRow[convVideoResCaseRelaInfo.ResourceTypeID] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCaseRelaInfoEN.ResourceTypeName = objRow[convVideoResCaseRelaInfo.ResourceTypeName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvVideoResCaseRelaInfoEN.MajorID = objRow[convVideoResCaseRelaInfo.MajorID] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.MajorID].ToString().Trim(); //专业ID(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCaseRelaInfoEN.MajorName = objRow[convVideoResCaseRelaInfo.MajorName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvVideoResCaseRelaInfoEN.CourseCode = objRow[convVideoResCaseRelaInfo.CourseCode] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvVideoResCaseRelaInfoEN.CollegeID = objRow[convVideoResCaseRelaInfo.CollegeID] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvVideoResCaseRelaInfoEN.CollegeName = objRow[convVideoResCaseRelaInfo.CollegeName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvVideoResCaseRelaInfoEN.CourseName = objRow[convVideoResCaseRelaInfo.CourseName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvVideoResCaseRelaInfoEN.BrowseCount = objRow[convVideoResCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoResCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvVideoResCaseRelaInfoEN.ResourceOwner = objRow[convVideoResCaseRelaInfo.ResourceOwner] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者(字段类型:varchar,字段长度:50,是否可空:False)
 objvVideoResCaseRelaInfoEN.ftpFileType = objRow[convVideoResCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvVideoResCaseRelaInfoEN.ftpFileSize = objRow[convVideoResCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvVideoResCaseRelaInfoEN.ftpResourceOwner = objRow[convVideoResCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者(字段类型:varchar,字段长度:50,是否可空:True)
 objvVideoResCaseRelaInfoEN.FileOriginName = objRow[convVideoResCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名(字段类型:varchar,字段长度:500,是否可空:True)
 objvVideoResCaseRelaInfoEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convVideoResCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objvVideoResCaseRelaInfoEN.Flag = objRow[convVideoResCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.Flag].ToString().Trim(); //标志(字段类型:varchar,字段长度:50,是否可空:True)
 objvVideoResCaseRelaInfoEN.FuncModuleName = objRow[convVideoResCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvVideoResCaseRelaInfoEN.FuncModuleId = objRow[convVideoResCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvVideoResCaseRelaInfoEN.FileNewName = objRow[convVideoResCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvVideoResCaseRelaInfoEN.FileOldName = objRow[convVideoResCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvVideoResCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convVideoResCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvVideoResCaseRelaInfoEN.IdFile = objRow[convVideoResCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号(字段类型:char,字段长度:8,是否可空:True)
 objvVideoResCaseRelaInfoEN.UpdDate = objRow[convVideoResCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvVideoResCaseRelaInfoEN.UpdUser = objRow[convVideoResCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvVideoResCaseRelaInfoEN.Memo = objRow[convVideoResCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvVideoResCaseRelaInfoEN.CourseId = objRow[convVideoResCaseRelaInfo.CourseId] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvVideoResCaseRelaInfoEN.IdXzCollege = objRow[convVideoResCaseRelaInfo.IdXzCollege] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvVideoResCaseRelaInfoEN.CollegeNameA = objRow[convVideoResCaseRelaInfo.CollegeNameA] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvVideoResCaseRelaInfoDA: GetObjByIdMicroTeachCaseRelaInfo)", objException.Message));
}
return objvVideoResCaseRelaInfoEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvVideoResCaseRelaInfoEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvVideoResCaseRelaInfoDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vVideoResCaseRelaInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvVideoResCaseRelaInfoEN objvVideoResCaseRelaInfoEN = new clsvVideoResCaseRelaInfoEN()
{
IdMicroTeachCaseRelaInfo = TransNullToInt(objRow[convVideoResCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()), //案例相关信息流水号
IdMicroTeachCaseRelaInfoType = objRow[convVideoResCaseRelaInfo.IdMicroTeachCaseRelaInfoType] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(), //微格案例相关信息类型流水号
MicroTeachCaseRelaInfoTypeID = objRow[convVideoResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(), //微格案例相关信息类型ID
MicroTeachCaseRelaInfoTypeName = objRow[convVideoResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(), //微格案例相关信息类型名称
IdMicroteachCase = objRow[convVideoResCaseRelaInfo.IdMicroteachCase].ToString().Trim(), //微格教学案例流水号
IdVideoResCase = objRow[convVideoResCaseRelaInfo.IdVideoResCase] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.IdVideoResCase].ToString().Trim(), //视频资源案例流水号
VideoResCaseName = objRow[convVideoResCaseRelaInfo.VideoResCaseName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.VideoResCaseName].ToString().Trim(), //视频资源案例名称
FileName = objRow[convVideoResCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FileName].ToString().Trim(), //文件名称
FileType = objRow[convVideoResCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FileType].ToString().Trim(), //文件类型
SaveDate = objRow[convVideoResCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.SaveDate].ToString().Trim(), //创建日期
FileSize = objRow[convVideoResCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FileSize].ToString().Trim(), //文件大小
SaveTime = objRow[convVideoResCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.SaveTime].ToString().Trim(), //创建时间
IdFtpResource = objRow[convVideoResCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.IdFtpResource].ToString().Trim(), //FTP资源流水号
FtpResourceID = objRow[convVideoResCaseRelaInfo.FtpResourceID] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FtpResourceID].ToString().Trim(), //FTP资源ID
FileOriginalName = objRow[convVideoResCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FileOriginalName].ToString().Trim(), //文件原名
FileDirName = objRow[convVideoResCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FileDirName].ToString().Trim(), //文件目录名
FileRename = objRow[convVideoResCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FileRename].ToString().Trim(), //文件新名
FileUpDate = objRow[convVideoResCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FileUpDate].ToString().Trim(), //创建日期
FileUpTime = objRow[convVideoResCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FileUpTime].ToString().Trim(), //创建时间
IdResource = objRow[convVideoResCaseRelaInfo.IdResource].ToString().Trim(), //资源流水号
ResourceID = objRow[convVideoResCaseRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.ResourceID].ToString().Trim(), //资源ID
SaveMode = TransNullToBool(objRow[convVideoResCaseRelaInfo.SaveMode].ToString().Trim()), //文件存放方式
IdResourceType = objRow[convVideoResCaseRelaInfo.IdResourceType] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.IdResourceType].ToString().Trim(), //资源类型流水号
ResourceTypeID = objRow[convVideoResCaseRelaInfo.ResourceTypeID] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.ResourceTypeID].ToString().Trim(), //资源类型ID
ResourceTypeName = objRow[convVideoResCaseRelaInfo.ResourceTypeName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.ResourceTypeName].ToString().Trim(), //资源类型名称
MajorID = objRow[convVideoResCaseRelaInfo.MajorID] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.MajorID].ToString().Trim(), //专业ID
MajorName = objRow[convVideoResCaseRelaInfo.MajorName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.MajorName].ToString().Trim(), //专业名称
CourseCode = objRow[convVideoResCaseRelaInfo.CourseCode] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.CourseCode].ToString().Trim(), //课程代码
CollegeID = objRow[convVideoResCaseRelaInfo.CollegeID] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.CollegeID].ToString().Trim(), //学院ID
CollegeName = objRow[convVideoResCaseRelaInfo.CollegeName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.CollegeName].ToString().Trim(), //学院名称
CourseName = objRow[convVideoResCaseRelaInfo.CourseName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.CourseName].ToString().Trim(), //课程名称
BrowseCount = objRow[convVideoResCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCaseRelaInfo.BrowseCount].ToString().Trim()), //浏览次数
ResourceOwner = objRow[convVideoResCaseRelaInfo.ResourceOwner] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.ResourceOwner].ToString().Trim(), //上传者
ftpFileType = objRow[convVideoResCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.ftpFileType].ToString().Trim(), //ftp文件类型
ftpFileSize = objRow[convVideoResCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.ftpFileSize].ToString().Trim(), //ftp文件大小
ftpResourceOwner = objRow[convVideoResCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.ftpResourceOwner].ToString().Trim(), //Ftp资源拥有者
FileOriginName = objRow[convVideoResCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FileOriginName].ToString().Trim(), //原文件名
IsExistFile = TransNullToBool(objRow[convVideoResCaseRelaInfo.IsExistFile].ToString().Trim()), //是否存在文件
Flag = objRow[convVideoResCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.Flag].ToString().Trim(), //标志
FuncModuleName = objRow[convVideoResCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FuncModuleName].ToString().Trim(), //功能模块名称
FuncModuleId = objRow[convVideoResCaseRelaInfo.FuncModuleId].ToString().Trim(), //功能模块Id
FileNewName = objRow[convVideoResCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FileNewName].ToString().Trim(), //新文件名
FileOldName = objRow[convVideoResCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FileOldName].ToString().Trim(), //旧文件名
IsVisible = TransNullToBool(objRow[convVideoResCaseRelaInfo.IsVisible].ToString().Trim()), //是否显示
IdFile = objRow[convVideoResCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.IdFile].ToString().Trim(), //文件流水号
UpdDate = objRow[convVideoResCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convVideoResCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convVideoResCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.Memo].ToString().Trim(), //备注
CourseId = objRow[convVideoResCaseRelaInfo.CourseId] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.CourseId].ToString().Trim(), //课程Id
IdXzCollege = objRow[convVideoResCaseRelaInfo.IdXzCollege] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.IdXzCollege].ToString().Trim(), //学院流水号
CollegeNameA = objRow[convVideoResCaseRelaInfo.CollegeNameA] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.CollegeNameA].ToString().Trim() //学院名称简写
};
objvVideoResCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvVideoResCaseRelaInfoEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvVideoResCaseRelaInfoDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvVideoResCaseRelaInfoEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvVideoResCaseRelaInfoEN objvVideoResCaseRelaInfoEN = new clsvVideoResCaseRelaInfoEN();
try
{
objvVideoResCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = TransNullToInt(objRow[convVideoResCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvVideoResCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convVideoResCaseRelaInfo.IdMicroTeachCaseRelaInfoType] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvVideoResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convVideoResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objvVideoResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convVideoResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvVideoResCaseRelaInfoEN.IdMicroteachCase = objRow[convVideoResCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoResCaseRelaInfoEN.IdVideoResCase = objRow[convVideoResCaseRelaInfo.IdVideoResCase] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.IdVideoResCase].ToString().Trim(); //视频资源案例流水号
objvVideoResCaseRelaInfoEN.VideoResCaseName = objRow[convVideoResCaseRelaInfo.VideoResCaseName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.VideoResCaseName].ToString().Trim(); //视频资源案例名称
objvVideoResCaseRelaInfoEN.FileName = objRow[convVideoResCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvVideoResCaseRelaInfoEN.FileType = objRow[convVideoResCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvVideoResCaseRelaInfoEN.SaveDate = objRow[convVideoResCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvVideoResCaseRelaInfoEN.FileSize = objRow[convVideoResCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvVideoResCaseRelaInfoEN.SaveTime = objRow[convVideoResCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvVideoResCaseRelaInfoEN.IdFtpResource = objRow[convVideoResCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvVideoResCaseRelaInfoEN.FtpResourceID = objRow[convVideoResCaseRelaInfo.FtpResourceID] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvVideoResCaseRelaInfoEN.FileOriginalName = objRow[convVideoResCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvVideoResCaseRelaInfoEN.FileDirName = objRow[convVideoResCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvVideoResCaseRelaInfoEN.FileRename = objRow[convVideoResCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvVideoResCaseRelaInfoEN.FileUpDate = objRow[convVideoResCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvVideoResCaseRelaInfoEN.FileUpTime = objRow[convVideoResCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvVideoResCaseRelaInfoEN.IdResource = objRow[convVideoResCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvVideoResCaseRelaInfoEN.ResourceID = objRow[convVideoResCaseRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvVideoResCaseRelaInfoEN.SaveMode = TransNullToBool(objRow[convVideoResCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvVideoResCaseRelaInfoEN.IdResourceType = objRow[convVideoResCaseRelaInfo.IdResourceType] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvVideoResCaseRelaInfoEN.ResourceTypeID = objRow[convVideoResCaseRelaInfo.ResourceTypeID] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvVideoResCaseRelaInfoEN.ResourceTypeName = objRow[convVideoResCaseRelaInfo.ResourceTypeName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvVideoResCaseRelaInfoEN.MajorID = objRow[convVideoResCaseRelaInfo.MajorID] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.MajorID].ToString().Trim(); //专业ID
objvVideoResCaseRelaInfoEN.MajorName = objRow[convVideoResCaseRelaInfo.MajorName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.MajorName].ToString().Trim(); //专业名称
objvVideoResCaseRelaInfoEN.CourseCode = objRow[convVideoResCaseRelaInfo.CourseCode] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.CourseCode].ToString().Trim(); //课程代码
objvVideoResCaseRelaInfoEN.CollegeID = objRow[convVideoResCaseRelaInfo.CollegeID] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.CollegeID].ToString().Trim(); //学院ID
objvVideoResCaseRelaInfoEN.CollegeName = objRow[convVideoResCaseRelaInfo.CollegeName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.CollegeName].ToString().Trim(); //学院名称
objvVideoResCaseRelaInfoEN.CourseName = objRow[convVideoResCaseRelaInfo.CourseName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.CourseName].ToString().Trim(); //课程名称
objvVideoResCaseRelaInfoEN.BrowseCount = objRow[convVideoResCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvVideoResCaseRelaInfoEN.ResourceOwner = objRow[convVideoResCaseRelaInfo.ResourceOwner] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvVideoResCaseRelaInfoEN.ftpFileType = objRow[convVideoResCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvVideoResCaseRelaInfoEN.ftpFileSize = objRow[convVideoResCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvVideoResCaseRelaInfoEN.ftpResourceOwner = objRow[convVideoResCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvVideoResCaseRelaInfoEN.FileOriginName = objRow[convVideoResCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvVideoResCaseRelaInfoEN.IsExistFile = TransNullToBool(objRow[convVideoResCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvVideoResCaseRelaInfoEN.Flag = objRow[convVideoResCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.Flag].ToString().Trim(); //标志
objvVideoResCaseRelaInfoEN.FuncModuleName = objRow[convVideoResCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoResCaseRelaInfoEN.FuncModuleId = objRow[convVideoResCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoResCaseRelaInfoEN.FileNewName = objRow[convVideoResCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvVideoResCaseRelaInfoEN.FileOldName = objRow[convVideoResCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvVideoResCaseRelaInfoEN.IsVisible = TransNullToBool(objRow[convVideoResCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvVideoResCaseRelaInfoEN.IdFile = objRow[convVideoResCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvVideoResCaseRelaInfoEN.UpdDate = objRow[convVideoResCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvVideoResCaseRelaInfoEN.UpdUser = objRow[convVideoResCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objvVideoResCaseRelaInfoEN.Memo = objRow[convVideoResCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.Memo].ToString().Trim(); //备注
objvVideoResCaseRelaInfoEN.CourseId = objRow[convVideoResCaseRelaInfo.CourseId] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.CourseId].ToString().Trim(); //课程Id
objvVideoResCaseRelaInfoEN.IdXzCollege = objRow[convVideoResCaseRelaInfo.IdXzCollege] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoResCaseRelaInfoEN.CollegeNameA = objRow[convVideoResCaseRelaInfo.CollegeNameA] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.CollegeNameA].ToString().Trim(); //学院名称简写
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvVideoResCaseRelaInfoDA: GetObjByDataRowvVideoResCaseRelaInfo)", objException.Message));
}
objvVideoResCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvVideoResCaseRelaInfoEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvVideoResCaseRelaInfoEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvVideoResCaseRelaInfoEN objvVideoResCaseRelaInfoEN = new clsvVideoResCaseRelaInfoEN();
try
{
objvVideoResCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = TransNullToInt(objRow[convVideoResCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvVideoResCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convVideoResCaseRelaInfo.IdMicroTeachCaseRelaInfoType] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvVideoResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convVideoResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objvVideoResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convVideoResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvVideoResCaseRelaInfoEN.IdMicroteachCase = objRow[convVideoResCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoResCaseRelaInfoEN.IdVideoResCase = objRow[convVideoResCaseRelaInfo.IdVideoResCase] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.IdVideoResCase].ToString().Trim(); //视频资源案例流水号
objvVideoResCaseRelaInfoEN.VideoResCaseName = objRow[convVideoResCaseRelaInfo.VideoResCaseName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.VideoResCaseName].ToString().Trim(); //视频资源案例名称
objvVideoResCaseRelaInfoEN.FileName = objRow[convVideoResCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvVideoResCaseRelaInfoEN.FileType = objRow[convVideoResCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvVideoResCaseRelaInfoEN.SaveDate = objRow[convVideoResCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvVideoResCaseRelaInfoEN.FileSize = objRow[convVideoResCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvVideoResCaseRelaInfoEN.SaveTime = objRow[convVideoResCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvVideoResCaseRelaInfoEN.IdFtpResource = objRow[convVideoResCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvVideoResCaseRelaInfoEN.FtpResourceID = objRow[convVideoResCaseRelaInfo.FtpResourceID] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvVideoResCaseRelaInfoEN.FileOriginalName = objRow[convVideoResCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvVideoResCaseRelaInfoEN.FileDirName = objRow[convVideoResCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvVideoResCaseRelaInfoEN.FileRename = objRow[convVideoResCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvVideoResCaseRelaInfoEN.FileUpDate = objRow[convVideoResCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvVideoResCaseRelaInfoEN.FileUpTime = objRow[convVideoResCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvVideoResCaseRelaInfoEN.IdResource = objRow[convVideoResCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvVideoResCaseRelaInfoEN.ResourceID = objRow[convVideoResCaseRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvVideoResCaseRelaInfoEN.SaveMode = TransNullToBool(objRow[convVideoResCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvVideoResCaseRelaInfoEN.IdResourceType = objRow[convVideoResCaseRelaInfo.IdResourceType] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvVideoResCaseRelaInfoEN.ResourceTypeID = objRow[convVideoResCaseRelaInfo.ResourceTypeID] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvVideoResCaseRelaInfoEN.ResourceTypeName = objRow[convVideoResCaseRelaInfo.ResourceTypeName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvVideoResCaseRelaInfoEN.MajorID = objRow[convVideoResCaseRelaInfo.MajorID] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.MajorID].ToString().Trim(); //专业ID
objvVideoResCaseRelaInfoEN.MajorName = objRow[convVideoResCaseRelaInfo.MajorName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.MajorName].ToString().Trim(); //专业名称
objvVideoResCaseRelaInfoEN.CourseCode = objRow[convVideoResCaseRelaInfo.CourseCode] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.CourseCode].ToString().Trim(); //课程代码
objvVideoResCaseRelaInfoEN.CollegeID = objRow[convVideoResCaseRelaInfo.CollegeID] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.CollegeID].ToString().Trim(); //学院ID
objvVideoResCaseRelaInfoEN.CollegeName = objRow[convVideoResCaseRelaInfo.CollegeName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.CollegeName].ToString().Trim(); //学院名称
objvVideoResCaseRelaInfoEN.CourseName = objRow[convVideoResCaseRelaInfo.CourseName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.CourseName].ToString().Trim(); //课程名称
objvVideoResCaseRelaInfoEN.BrowseCount = objRow[convVideoResCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvVideoResCaseRelaInfoEN.ResourceOwner = objRow[convVideoResCaseRelaInfo.ResourceOwner] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvVideoResCaseRelaInfoEN.ftpFileType = objRow[convVideoResCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvVideoResCaseRelaInfoEN.ftpFileSize = objRow[convVideoResCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvVideoResCaseRelaInfoEN.ftpResourceOwner = objRow[convVideoResCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvVideoResCaseRelaInfoEN.FileOriginName = objRow[convVideoResCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvVideoResCaseRelaInfoEN.IsExistFile = TransNullToBool(objRow[convVideoResCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvVideoResCaseRelaInfoEN.Flag = objRow[convVideoResCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.Flag].ToString().Trim(); //标志
objvVideoResCaseRelaInfoEN.FuncModuleName = objRow[convVideoResCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoResCaseRelaInfoEN.FuncModuleId = objRow[convVideoResCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoResCaseRelaInfoEN.FileNewName = objRow[convVideoResCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvVideoResCaseRelaInfoEN.FileOldName = objRow[convVideoResCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvVideoResCaseRelaInfoEN.IsVisible = TransNullToBool(objRow[convVideoResCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvVideoResCaseRelaInfoEN.IdFile = objRow[convVideoResCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvVideoResCaseRelaInfoEN.UpdDate = objRow[convVideoResCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvVideoResCaseRelaInfoEN.UpdUser = objRow[convVideoResCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objvVideoResCaseRelaInfoEN.Memo = objRow[convVideoResCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.Memo].ToString().Trim(); //备注
objvVideoResCaseRelaInfoEN.CourseId = objRow[convVideoResCaseRelaInfo.CourseId] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.CourseId].ToString().Trim(); //课程Id
objvVideoResCaseRelaInfoEN.IdXzCollege = objRow[convVideoResCaseRelaInfo.IdXzCollege] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoResCaseRelaInfoEN.CollegeNameA = objRow[convVideoResCaseRelaInfo.CollegeNameA] == DBNull.Value ? null : objRow[convVideoResCaseRelaInfo.CollegeNameA].ToString().Trim(); //学院名称简写
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvVideoResCaseRelaInfoDA: GetObjByDataRow)", objException.Message));
}
objvVideoResCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvVideoResCaseRelaInfoEN;
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
objSQL = clsvVideoResCaseRelaInfoDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvVideoResCaseRelaInfoEN._CurrTabName, convVideoResCaseRelaInfo.IdMicroTeachCaseRelaInfo, 8, "");
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
objSQL = clsvVideoResCaseRelaInfoDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvVideoResCaseRelaInfoEN._CurrTabName, convVideoResCaseRelaInfo.IdMicroTeachCaseRelaInfo, 8, strPrefix);
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
 objSQL = clsvVideoResCaseRelaInfoDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdMicroTeachCaseRelaInfo from vVideoResCaseRelaInfo where " + strCondition;
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
 objSQL = clsvVideoResCaseRelaInfoDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdMicroTeachCaseRelaInfo from vVideoResCaseRelaInfo where " + strCondition;
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
 objSQL = clsvVideoResCaseRelaInfoDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vVideoResCaseRelaInfo", "IdMicroTeachCaseRelaInfo = " + ""+ lngIdMicroTeachCaseRelaInfo+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvVideoResCaseRelaInfoDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCaseRelaInfoDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vVideoResCaseRelaInfo", strCondition))
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
objSQL = clsvVideoResCaseRelaInfoDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vVideoResCaseRelaInfo");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvVideoResCaseRelaInfoENS">源对象</param>
 /// <param name = "objvVideoResCaseRelaInfoENT">目标对象</param>
public void CopyTo(clsvVideoResCaseRelaInfoEN objvVideoResCaseRelaInfoENS, clsvVideoResCaseRelaInfoEN objvVideoResCaseRelaInfoENT)
{
objvVideoResCaseRelaInfoENT.IdMicroTeachCaseRelaInfo = objvVideoResCaseRelaInfoENS.IdMicroTeachCaseRelaInfo; //案例相关信息流水号
objvVideoResCaseRelaInfoENT.IdMicroTeachCaseRelaInfoType = objvVideoResCaseRelaInfoENS.IdMicroTeachCaseRelaInfoType; //微格案例相关信息类型流水号
objvVideoResCaseRelaInfoENT.MicroTeachCaseRelaInfoTypeID = objvVideoResCaseRelaInfoENS.MicroTeachCaseRelaInfoTypeID; //微格案例相关信息类型ID
objvVideoResCaseRelaInfoENT.MicroTeachCaseRelaInfoTypeName = objvVideoResCaseRelaInfoENS.MicroTeachCaseRelaInfoTypeName; //微格案例相关信息类型名称
objvVideoResCaseRelaInfoENT.IdMicroteachCase = objvVideoResCaseRelaInfoENS.IdMicroteachCase; //微格教学案例流水号
objvVideoResCaseRelaInfoENT.IdVideoResCase = objvVideoResCaseRelaInfoENS.IdVideoResCase; //视频资源案例流水号
objvVideoResCaseRelaInfoENT.VideoResCaseName = objvVideoResCaseRelaInfoENS.VideoResCaseName; //视频资源案例名称
objvVideoResCaseRelaInfoENT.FileName = objvVideoResCaseRelaInfoENS.FileName; //文件名称
objvVideoResCaseRelaInfoENT.FileType = objvVideoResCaseRelaInfoENS.FileType; //文件类型
objvVideoResCaseRelaInfoENT.SaveDate = objvVideoResCaseRelaInfoENS.SaveDate; //创建日期
objvVideoResCaseRelaInfoENT.FileSize = objvVideoResCaseRelaInfoENS.FileSize; //文件大小
objvVideoResCaseRelaInfoENT.SaveTime = objvVideoResCaseRelaInfoENS.SaveTime; //创建时间
objvVideoResCaseRelaInfoENT.IdFtpResource = objvVideoResCaseRelaInfoENS.IdFtpResource; //FTP资源流水号
objvVideoResCaseRelaInfoENT.FtpResourceID = objvVideoResCaseRelaInfoENS.FtpResourceID; //FTP资源ID
objvVideoResCaseRelaInfoENT.FileOriginalName = objvVideoResCaseRelaInfoENS.FileOriginalName; //文件原名
objvVideoResCaseRelaInfoENT.FileDirName = objvVideoResCaseRelaInfoENS.FileDirName; //文件目录名
objvVideoResCaseRelaInfoENT.FileRename = objvVideoResCaseRelaInfoENS.FileRename; //文件新名
objvVideoResCaseRelaInfoENT.FileUpDate = objvVideoResCaseRelaInfoENS.FileUpDate; //创建日期
objvVideoResCaseRelaInfoENT.FileUpTime = objvVideoResCaseRelaInfoENS.FileUpTime; //创建时间
objvVideoResCaseRelaInfoENT.IdResource = objvVideoResCaseRelaInfoENS.IdResource; //资源流水号
objvVideoResCaseRelaInfoENT.ResourceID = objvVideoResCaseRelaInfoENS.ResourceID; //资源ID
objvVideoResCaseRelaInfoENT.SaveMode = objvVideoResCaseRelaInfoENS.SaveMode; //文件存放方式
objvVideoResCaseRelaInfoENT.IdResourceType = objvVideoResCaseRelaInfoENS.IdResourceType; //资源类型流水号
objvVideoResCaseRelaInfoENT.ResourceTypeID = objvVideoResCaseRelaInfoENS.ResourceTypeID; //资源类型ID
objvVideoResCaseRelaInfoENT.ResourceTypeName = objvVideoResCaseRelaInfoENS.ResourceTypeName; //资源类型名称
objvVideoResCaseRelaInfoENT.MajorID = objvVideoResCaseRelaInfoENS.MajorID; //专业ID
objvVideoResCaseRelaInfoENT.MajorName = objvVideoResCaseRelaInfoENS.MajorName; //专业名称
objvVideoResCaseRelaInfoENT.CourseCode = objvVideoResCaseRelaInfoENS.CourseCode; //课程代码
objvVideoResCaseRelaInfoENT.CollegeID = objvVideoResCaseRelaInfoENS.CollegeID; //学院ID
objvVideoResCaseRelaInfoENT.CollegeName = objvVideoResCaseRelaInfoENS.CollegeName; //学院名称
objvVideoResCaseRelaInfoENT.CourseName = objvVideoResCaseRelaInfoENS.CourseName; //课程名称
objvVideoResCaseRelaInfoENT.BrowseCount = objvVideoResCaseRelaInfoENS.BrowseCount; //浏览次数
objvVideoResCaseRelaInfoENT.ResourceOwner = objvVideoResCaseRelaInfoENS.ResourceOwner; //上传者
objvVideoResCaseRelaInfoENT.ftpFileType = objvVideoResCaseRelaInfoENS.ftpFileType; //ftp文件类型
objvVideoResCaseRelaInfoENT.ftpFileSize = objvVideoResCaseRelaInfoENS.ftpFileSize; //ftp文件大小
objvVideoResCaseRelaInfoENT.ftpResourceOwner = objvVideoResCaseRelaInfoENS.ftpResourceOwner; //Ftp资源拥有者
objvVideoResCaseRelaInfoENT.FileOriginName = objvVideoResCaseRelaInfoENS.FileOriginName; //原文件名
objvVideoResCaseRelaInfoENT.IsExistFile = objvVideoResCaseRelaInfoENS.IsExistFile; //是否存在文件
objvVideoResCaseRelaInfoENT.Flag = objvVideoResCaseRelaInfoENS.Flag; //标志
objvVideoResCaseRelaInfoENT.FuncModuleName = objvVideoResCaseRelaInfoENS.FuncModuleName; //功能模块名称
objvVideoResCaseRelaInfoENT.FuncModuleId = objvVideoResCaseRelaInfoENS.FuncModuleId; //功能模块Id
objvVideoResCaseRelaInfoENT.FileNewName = objvVideoResCaseRelaInfoENS.FileNewName; //新文件名
objvVideoResCaseRelaInfoENT.FileOldName = objvVideoResCaseRelaInfoENS.FileOldName; //旧文件名
objvVideoResCaseRelaInfoENT.IsVisible = objvVideoResCaseRelaInfoENS.IsVisible; //是否显示
objvVideoResCaseRelaInfoENT.IdFile = objvVideoResCaseRelaInfoENS.IdFile; //文件流水号
objvVideoResCaseRelaInfoENT.UpdDate = objvVideoResCaseRelaInfoENS.UpdDate; //修改日期
objvVideoResCaseRelaInfoENT.UpdUser = objvVideoResCaseRelaInfoENS.UpdUser; //修改人
objvVideoResCaseRelaInfoENT.Memo = objvVideoResCaseRelaInfoENS.Memo; //备注
objvVideoResCaseRelaInfoENT.CourseId = objvVideoResCaseRelaInfoENS.CourseId; //课程Id
objvVideoResCaseRelaInfoENT.IdXzCollege = objvVideoResCaseRelaInfoENS.IdXzCollege; //学院流水号
objvVideoResCaseRelaInfoENT.CollegeNameA = objvVideoResCaseRelaInfoENS.CollegeNameA; //学院名称简写
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvVideoResCaseRelaInfoEN objvVideoResCaseRelaInfoEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvVideoResCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType, 4, convVideoResCaseRelaInfo.IdMicroTeachCaseRelaInfoType);
clsCheckSql.CheckFieldLen(objvVideoResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID, 4, convVideoResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID);
clsCheckSql.CheckFieldLen(objvVideoResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName, 50, convVideoResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName);
clsCheckSql.CheckFieldLen(objvVideoResCaseRelaInfoEN.IdMicroteachCase, 8, convVideoResCaseRelaInfo.IdMicroteachCase);
clsCheckSql.CheckFieldLen(objvVideoResCaseRelaInfoEN.IdVideoResCase, 8, convVideoResCaseRelaInfo.IdVideoResCase);
clsCheckSql.CheckFieldLen(objvVideoResCaseRelaInfoEN.VideoResCaseName, 100, convVideoResCaseRelaInfo.VideoResCaseName);
clsCheckSql.CheckFieldLen(objvVideoResCaseRelaInfoEN.FileName, 500, convVideoResCaseRelaInfo.FileName);
clsCheckSql.CheckFieldLen(objvVideoResCaseRelaInfoEN.FileType, 30, convVideoResCaseRelaInfo.FileType);
clsCheckSql.CheckFieldLen(objvVideoResCaseRelaInfoEN.SaveDate, 8, convVideoResCaseRelaInfo.SaveDate);
clsCheckSql.CheckFieldLen(objvVideoResCaseRelaInfoEN.FileSize, 50, convVideoResCaseRelaInfo.FileSize);
clsCheckSql.CheckFieldLen(objvVideoResCaseRelaInfoEN.SaveTime, 6, convVideoResCaseRelaInfo.SaveTime);
clsCheckSql.CheckFieldLen(objvVideoResCaseRelaInfoEN.IdFtpResource, 8, convVideoResCaseRelaInfo.IdFtpResource);
clsCheckSql.CheckFieldLen(objvVideoResCaseRelaInfoEN.FtpResourceID, 8, convVideoResCaseRelaInfo.FtpResourceID);
clsCheckSql.CheckFieldLen(objvVideoResCaseRelaInfoEN.FileOriginalName, 200, convVideoResCaseRelaInfo.FileOriginalName);
clsCheckSql.CheckFieldLen(objvVideoResCaseRelaInfoEN.FileDirName, 200, convVideoResCaseRelaInfo.FileDirName);
clsCheckSql.CheckFieldLen(objvVideoResCaseRelaInfoEN.FileRename, 200, convVideoResCaseRelaInfo.FileRename);
clsCheckSql.CheckFieldLen(objvVideoResCaseRelaInfoEN.FileUpDate, 8, convVideoResCaseRelaInfo.FileUpDate);
clsCheckSql.CheckFieldLen(objvVideoResCaseRelaInfoEN.FileUpTime, 6, convVideoResCaseRelaInfo.FileUpTime);
clsCheckSql.CheckFieldLen(objvVideoResCaseRelaInfoEN.IdResource, 8, convVideoResCaseRelaInfo.IdResource);
clsCheckSql.CheckFieldLen(objvVideoResCaseRelaInfoEN.ResourceID, 8, convVideoResCaseRelaInfo.ResourceID);
clsCheckSql.CheckFieldLen(objvVideoResCaseRelaInfoEN.IdResourceType, 4, convVideoResCaseRelaInfo.IdResourceType);
clsCheckSql.CheckFieldLen(objvVideoResCaseRelaInfoEN.ResourceTypeID, 4, convVideoResCaseRelaInfo.ResourceTypeID);
clsCheckSql.CheckFieldLen(objvVideoResCaseRelaInfoEN.ResourceTypeName, 50, convVideoResCaseRelaInfo.ResourceTypeName);
clsCheckSql.CheckFieldLen(objvVideoResCaseRelaInfoEN.MajorID, 4, convVideoResCaseRelaInfo.MajorID);
clsCheckSql.CheckFieldLen(objvVideoResCaseRelaInfoEN.MajorName, 100, convVideoResCaseRelaInfo.MajorName);
clsCheckSql.CheckFieldLen(objvVideoResCaseRelaInfoEN.CourseCode, 20, convVideoResCaseRelaInfo.CourseCode);
clsCheckSql.CheckFieldLen(objvVideoResCaseRelaInfoEN.CollegeID, 4, convVideoResCaseRelaInfo.CollegeID);
clsCheckSql.CheckFieldLen(objvVideoResCaseRelaInfoEN.CollegeName, 100, convVideoResCaseRelaInfo.CollegeName);
clsCheckSql.CheckFieldLen(objvVideoResCaseRelaInfoEN.CourseName, 100, convVideoResCaseRelaInfo.CourseName);
clsCheckSql.CheckFieldLen(objvVideoResCaseRelaInfoEN.ResourceOwner, 50, convVideoResCaseRelaInfo.ResourceOwner);
clsCheckSql.CheckFieldLen(objvVideoResCaseRelaInfoEN.ftpFileType, 30, convVideoResCaseRelaInfo.ftpFileType);
clsCheckSql.CheckFieldLen(objvVideoResCaseRelaInfoEN.ftpFileSize, 50, convVideoResCaseRelaInfo.ftpFileSize);
clsCheckSql.CheckFieldLen(objvVideoResCaseRelaInfoEN.ftpResourceOwner, 50, convVideoResCaseRelaInfo.ftpResourceOwner);
clsCheckSql.CheckFieldLen(objvVideoResCaseRelaInfoEN.FileOriginName, 500, convVideoResCaseRelaInfo.FileOriginName);
clsCheckSql.CheckFieldLen(objvVideoResCaseRelaInfoEN.Flag, 50, convVideoResCaseRelaInfo.Flag);
clsCheckSql.CheckFieldLen(objvVideoResCaseRelaInfoEN.FuncModuleName, 30, convVideoResCaseRelaInfo.FuncModuleName);
clsCheckSql.CheckFieldLen(objvVideoResCaseRelaInfoEN.FuncModuleId, 4, convVideoResCaseRelaInfo.FuncModuleId);
clsCheckSql.CheckFieldLen(objvVideoResCaseRelaInfoEN.FileNewName, 530, convVideoResCaseRelaInfo.FileNewName);
clsCheckSql.CheckFieldLen(objvVideoResCaseRelaInfoEN.FileOldName, 530, convVideoResCaseRelaInfo.FileOldName);
clsCheckSql.CheckFieldLen(objvVideoResCaseRelaInfoEN.IdFile, 8, convVideoResCaseRelaInfo.IdFile);
clsCheckSql.CheckFieldLen(objvVideoResCaseRelaInfoEN.UpdDate, 20, convVideoResCaseRelaInfo.UpdDate);
clsCheckSql.CheckFieldLen(objvVideoResCaseRelaInfoEN.UpdUser, 20, convVideoResCaseRelaInfo.UpdUser);
clsCheckSql.CheckFieldLen(objvVideoResCaseRelaInfoEN.Memo, 1000, convVideoResCaseRelaInfo.Memo);
clsCheckSql.CheckFieldLen(objvVideoResCaseRelaInfoEN.CourseId, 8, convVideoResCaseRelaInfo.CourseId);
clsCheckSql.CheckFieldLen(objvVideoResCaseRelaInfoEN.IdXzCollege, 4, convVideoResCaseRelaInfo.IdXzCollege);
clsCheckSql.CheckFieldLen(objvVideoResCaseRelaInfoEN.CollegeNameA, 12, convVideoResCaseRelaInfo.CollegeNameA);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType, convVideoResCaseRelaInfo.IdMicroTeachCaseRelaInfoType);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID, convVideoResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName, convVideoResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseRelaInfoEN.IdMicroteachCase, convVideoResCaseRelaInfo.IdMicroteachCase);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseRelaInfoEN.IdVideoResCase, convVideoResCaseRelaInfo.IdVideoResCase);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseRelaInfoEN.VideoResCaseName, convVideoResCaseRelaInfo.VideoResCaseName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseRelaInfoEN.FileName, convVideoResCaseRelaInfo.FileName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseRelaInfoEN.FileType, convVideoResCaseRelaInfo.FileType);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseRelaInfoEN.SaveDate, convVideoResCaseRelaInfo.SaveDate);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseRelaInfoEN.FileSize, convVideoResCaseRelaInfo.FileSize);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseRelaInfoEN.SaveTime, convVideoResCaseRelaInfo.SaveTime);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseRelaInfoEN.IdFtpResource, convVideoResCaseRelaInfo.IdFtpResource);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseRelaInfoEN.FtpResourceID, convVideoResCaseRelaInfo.FtpResourceID);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseRelaInfoEN.FileOriginalName, convVideoResCaseRelaInfo.FileOriginalName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseRelaInfoEN.FileDirName, convVideoResCaseRelaInfo.FileDirName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseRelaInfoEN.FileRename, convVideoResCaseRelaInfo.FileRename);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseRelaInfoEN.FileUpDate, convVideoResCaseRelaInfo.FileUpDate);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseRelaInfoEN.FileUpTime, convVideoResCaseRelaInfo.FileUpTime);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseRelaInfoEN.IdResource, convVideoResCaseRelaInfo.IdResource);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseRelaInfoEN.ResourceID, convVideoResCaseRelaInfo.ResourceID);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseRelaInfoEN.IdResourceType, convVideoResCaseRelaInfo.IdResourceType);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseRelaInfoEN.ResourceTypeID, convVideoResCaseRelaInfo.ResourceTypeID);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseRelaInfoEN.ResourceTypeName, convVideoResCaseRelaInfo.ResourceTypeName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseRelaInfoEN.MajorID, convVideoResCaseRelaInfo.MajorID);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseRelaInfoEN.MajorName, convVideoResCaseRelaInfo.MajorName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseRelaInfoEN.CourseCode, convVideoResCaseRelaInfo.CourseCode);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseRelaInfoEN.CollegeID, convVideoResCaseRelaInfo.CollegeID);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseRelaInfoEN.CollegeName, convVideoResCaseRelaInfo.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseRelaInfoEN.CourseName, convVideoResCaseRelaInfo.CourseName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseRelaInfoEN.ResourceOwner, convVideoResCaseRelaInfo.ResourceOwner);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseRelaInfoEN.ftpFileType, convVideoResCaseRelaInfo.ftpFileType);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseRelaInfoEN.ftpFileSize, convVideoResCaseRelaInfo.ftpFileSize);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseRelaInfoEN.ftpResourceOwner, convVideoResCaseRelaInfo.ftpResourceOwner);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseRelaInfoEN.FileOriginName, convVideoResCaseRelaInfo.FileOriginName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseRelaInfoEN.Flag, convVideoResCaseRelaInfo.Flag);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseRelaInfoEN.FuncModuleName, convVideoResCaseRelaInfo.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseRelaInfoEN.FuncModuleId, convVideoResCaseRelaInfo.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseRelaInfoEN.FileNewName, convVideoResCaseRelaInfo.FileNewName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseRelaInfoEN.FileOldName, convVideoResCaseRelaInfo.FileOldName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseRelaInfoEN.IdFile, convVideoResCaseRelaInfo.IdFile);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseRelaInfoEN.UpdDate, convVideoResCaseRelaInfo.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseRelaInfoEN.UpdUser, convVideoResCaseRelaInfo.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseRelaInfoEN.Memo, convVideoResCaseRelaInfo.Memo);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseRelaInfoEN.CourseId, convVideoResCaseRelaInfo.CourseId);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseRelaInfoEN.IdXzCollege, convVideoResCaseRelaInfo.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseRelaInfoEN.CollegeNameA, convVideoResCaseRelaInfo.CollegeNameA);
//检查外键字段长度
 objvVideoResCaseRelaInfoEN._IsCheckProperty = true;
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
 objSQL = clsvVideoResCaseRelaInfoDA.GetSpecSQLObj();
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
 objSQL = clsvVideoResCaseRelaInfoDA.GetSpecSQLObj();
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
 objSQL = clsvVideoResCaseRelaInfoDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvVideoResCaseRelaInfoEN._CurrTabName);
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
 objSQL = clsvVideoResCaseRelaInfoDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvVideoResCaseRelaInfoEN._CurrTabName, strCondition);
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
 objSQL = clsvVideoResCaseRelaInfoDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}