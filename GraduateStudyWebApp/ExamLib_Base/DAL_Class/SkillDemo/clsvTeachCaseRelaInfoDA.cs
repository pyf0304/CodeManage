
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTeachCaseRelaInfoDA
 表名:vTeachCaseRelaInfo(01120399)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:49:54
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:技能示范(SkillDemo)
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
 /// 案例相关信息表视图(vTeachCaseRelaInfo)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvTeachCaseRelaInfoDA : clsCommBase4DA
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
 return clsvTeachCaseRelaInfoEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvTeachCaseRelaInfoEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvTeachCaseRelaInfoEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvTeachCaseRelaInfoEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvTeachCaseRelaInfoEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvTeachCaseRelaInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vTeachCaseRelaInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vTeachCaseRelaInfo(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvTeachCaseRelaInfoDA: GetDataTable_vTeachCaseRelaInfo)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vTeachCaseRelaInfo where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvTeachCaseRelaInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachCaseRelaInfoDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvTeachCaseRelaInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vTeachCaseRelaInfo where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvTeachCaseRelaInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachCaseRelaInfoDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvTeachCaseRelaInfoDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachCaseRelaInfoDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vTeachCaseRelaInfo where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vTeachCaseRelaInfo where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvTeachCaseRelaInfoDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachCaseRelaInfoDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vTeachCaseRelaInfo where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvTeachCaseRelaInfoDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachCaseRelaInfoDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vTeachCaseRelaInfo.* from vTeachCaseRelaInfo Left Join {1} on {2} where {3} and vTeachCaseRelaInfo.IdTeachCaseRelaInfo not in (Select top {5} vTeachCaseRelaInfo.IdTeachCaseRelaInfo from vTeachCaseRelaInfo Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vTeachCaseRelaInfo where {1} and IdTeachCaseRelaInfo not in (Select top {2} IdTeachCaseRelaInfo from vTeachCaseRelaInfo where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vTeachCaseRelaInfo where {1} and IdTeachCaseRelaInfo not in (Select top {3} IdTeachCaseRelaInfo from vTeachCaseRelaInfo where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvTeachCaseRelaInfoDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachCaseRelaInfoDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vTeachCaseRelaInfo.* from vTeachCaseRelaInfo Left Join {1} on {2} where {3} and vTeachCaseRelaInfo.IdTeachCaseRelaInfo not in (Select top {5} vTeachCaseRelaInfo.IdTeachCaseRelaInfo from vTeachCaseRelaInfo Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vTeachCaseRelaInfo where {1} and IdTeachCaseRelaInfo not in (Select top {2} IdTeachCaseRelaInfo from vTeachCaseRelaInfo where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vTeachCaseRelaInfo where {1} and IdTeachCaseRelaInfo not in (Select top {3} IdTeachCaseRelaInfo from vTeachCaseRelaInfo where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvTeachCaseRelaInfoEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvTeachCaseRelaInfoDA:GetObjLst)", objException.Message));
}
List<clsvTeachCaseRelaInfoEN> arrObjLst = new List<clsvTeachCaseRelaInfoEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vTeachCaseRelaInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN = new clsvTeachCaseRelaInfoEN();
try
{
objvTeachCaseRelaInfoEN.IdTeachCaseRelaInfo = TransNullToInt(objRow[convTeachCaseRelaInfo.IdTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvTeachCaseRelaInfoEN.IdTeachCase = objRow[convTeachCaseRelaInfo.IdTeachCase].ToString().Trim(); //案例流水号
objvTeachCaseRelaInfoEN.TeachCaseName = objRow[convTeachCaseRelaInfo.TeachCaseName].ToString().Trim(); //案例名称
objvTeachCaseRelaInfoEN.IdResource = objRow[convTeachCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvTeachCaseRelaInfoEN.ResourceID = objRow[convTeachCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvTeachCaseRelaInfoEN.SaveMode = TransNullToBool(objRow[convTeachCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvTeachCaseRelaInfoEN.IdFtpResource = objRow[convTeachCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvTeachCaseRelaInfoEN.FtpResourceID = objRow[convTeachCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvTeachCaseRelaInfoEN.FileOriginalName = objRow[convTeachCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvTeachCaseRelaInfoEN.FileDirName = objRow[convTeachCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvTeachCaseRelaInfoEN.FileRename = objRow[convTeachCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvTeachCaseRelaInfoEN.FileUpDate = objRow[convTeachCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvTeachCaseRelaInfoEN.FileUpTime = objRow[convTeachCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvTeachCaseRelaInfoEN.FileSize = objRow[convTeachCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvTeachCaseRelaInfoEN.FileType = objRow[convTeachCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvTeachCaseRelaInfoEN.ResourceOwner = objRow[convTeachCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvTeachCaseRelaInfoEN.IdFile = objRow[convTeachCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvTeachCaseRelaInfoEN.FileName = objRow[convTeachCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvTeachCaseRelaInfoEN.SaveDate = objRow[convTeachCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvTeachCaseRelaInfoEN.SaveTime = objRow[convTeachCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvTeachCaseRelaInfoEN.FileOriginName = objRow[convTeachCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvTeachCaseRelaInfoEN.IdResourceType = objRow[convTeachCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvTeachCaseRelaInfoEN.ResourceTypeID = objRow[convTeachCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvTeachCaseRelaInfoEN.ResourceTypeName = objRow[convTeachCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvTeachCaseRelaInfoEN.FileNewName = objRow[convTeachCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvTeachCaseRelaInfoEN.FileOldName = objRow[convTeachCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvTeachCaseRelaInfoEN.ftpFileType = objRow[convTeachCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachCaseRelaInfoEN.ftpFileSize = objRow[convTeachCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvTeachCaseRelaInfoEN.ftpResourceOwner = objRow[convTeachCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvTeachCaseRelaInfoEN.IdTeachCaseRelaInfoType = objRow[convTeachCaseRelaInfo.IdTeachCaseRelaInfoType].ToString().Trim(); //案例相关信息类型流水号
objvTeachCaseRelaInfoEN.TeachCaseRelaInfoTypeID = objRow[convTeachCaseRelaInfo.TeachCaseRelaInfoTypeID].ToString().Trim(); //案例相关信息类型ID
objvTeachCaseRelaInfoEN.TeachCaseRelaInfoTypeName = objRow[convTeachCaseRelaInfo.TeachCaseRelaInfoTypeName].ToString().Trim(); //案例相关信息类型名称
objvTeachCaseRelaInfoEN.IsVisible = TransNullToBool(objRow[convTeachCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvTeachCaseRelaInfoEN.BrowseCount = objRow[convTeachCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvTeachCaseRelaInfoEN.Memo = objRow[convTeachCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvTeachCaseRelaInfoDA: GetObjLst)", objException.Message));
}
objvTeachCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvTeachCaseRelaInfoEN);
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
public List<clsvTeachCaseRelaInfoEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvTeachCaseRelaInfoDA:GetObjLstByTabName)", objException.Message));
}
List<clsvTeachCaseRelaInfoEN> arrObjLst = new List<clsvTeachCaseRelaInfoEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachCaseRelaInfoDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN = new clsvTeachCaseRelaInfoEN();
try
{
objvTeachCaseRelaInfoEN.IdTeachCaseRelaInfo = TransNullToInt(objRow[convTeachCaseRelaInfo.IdTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvTeachCaseRelaInfoEN.IdTeachCase = objRow[convTeachCaseRelaInfo.IdTeachCase].ToString().Trim(); //案例流水号
objvTeachCaseRelaInfoEN.TeachCaseName = objRow[convTeachCaseRelaInfo.TeachCaseName].ToString().Trim(); //案例名称
objvTeachCaseRelaInfoEN.IdResource = objRow[convTeachCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvTeachCaseRelaInfoEN.ResourceID = objRow[convTeachCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvTeachCaseRelaInfoEN.SaveMode = TransNullToBool(objRow[convTeachCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvTeachCaseRelaInfoEN.IdFtpResource = objRow[convTeachCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvTeachCaseRelaInfoEN.FtpResourceID = objRow[convTeachCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvTeachCaseRelaInfoEN.FileOriginalName = objRow[convTeachCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvTeachCaseRelaInfoEN.FileDirName = objRow[convTeachCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvTeachCaseRelaInfoEN.FileRename = objRow[convTeachCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvTeachCaseRelaInfoEN.FileUpDate = objRow[convTeachCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvTeachCaseRelaInfoEN.FileUpTime = objRow[convTeachCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvTeachCaseRelaInfoEN.FileSize = objRow[convTeachCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvTeachCaseRelaInfoEN.FileType = objRow[convTeachCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvTeachCaseRelaInfoEN.ResourceOwner = objRow[convTeachCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvTeachCaseRelaInfoEN.IdFile = objRow[convTeachCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvTeachCaseRelaInfoEN.FileName = objRow[convTeachCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvTeachCaseRelaInfoEN.SaveDate = objRow[convTeachCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvTeachCaseRelaInfoEN.SaveTime = objRow[convTeachCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvTeachCaseRelaInfoEN.FileOriginName = objRow[convTeachCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvTeachCaseRelaInfoEN.IdResourceType = objRow[convTeachCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvTeachCaseRelaInfoEN.ResourceTypeID = objRow[convTeachCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvTeachCaseRelaInfoEN.ResourceTypeName = objRow[convTeachCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvTeachCaseRelaInfoEN.FileNewName = objRow[convTeachCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvTeachCaseRelaInfoEN.FileOldName = objRow[convTeachCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvTeachCaseRelaInfoEN.ftpFileType = objRow[convTeachCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachCaseRelaInfoEN.ftpFileSize = objRow[convTeachCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvTeachCaseRelaInfoEN.ftpResourceOwner = objRow[convTeachCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvTeachCaseRelaInfoEN.IdTeachCaseRelaInfoType = objRow[convTeachCaseRelaInfo.IdTeachCaseRelaInfoType].ToString().Trim(); //案例相关信息类型流水号
objvTeachCaseRelaInfoEN.TeachCaseRelaInfoTypeID = objRow[convTeachCaseRelaInfo.TeachCaseRelaInfoTypeID].ToString().Trim(); //案例相关信息类型ID
objvTeachCaseRelaInfoEN.TeachCaseRelaInfoTypeName = objRow[convTeachCaseRelaInfo.TeachCaseRelaInfoTypeName].ToString().Trim(); //案例相关信息类型名称
objvTeachCaseRelaInfoEN.IsVisible = TransNullToBool(objRow[convTeachCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvTeachCaseRelaInfoEN.BrowseCount = objRow[convTeachCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvTeachCaseRelaInfoEN.Memo = objRow[convTeachCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvTeachCaseRelaInfoDA: GetObjLst)", objException.Message));
}
objvTeachCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvTeachCaseRelaInfoEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvTeachCaseRelaInfo(ref clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vTeachCaseRelaInfo where IdTeachCaseRelaInfo = " + ""+ objvTeachCaseRelaInfoEN.IdTeachCaseRelaInfo+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvTeachCaseRelaInfoEN.IdTeachCaseRelaInfo = TransNullToInt(objDT.Rows[0][convTeachCaseRelaInfo.IdTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvTeachCaseRelaInfoEN.IdTeachCase = objDT.Rows[0][convTeachCaseRelaInfo.IdTeachCase].ToString().Trim(); //案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvTeachCaseRelaInfoEN.TeachCaseName = objDT.Rows[0][convTeachCaseRelaInfo.TeachCaseName].ToString().Trim(); //案例名称(字段类型:varchar,字段长度:200,是否可空:False)
 objvTeachCaseRelaInfoEN.IdResource = objDT.Rows[0][convTeachCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objvTeachCaseRelaInfoEN.ResourceID = objDT.Rows[0][convTeachCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvTeachCaseRelaInfoEN.SaveMode = TransNullToBool(objDT.Rows[0][convTeachCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式(字段类型:bit,字段长度:1,是否可空:True)
 objvTeachCaseRelaInfoEN.IdFtpResource = objDT.Rows[0][convTeachCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objvTeachCaseRelaInfoEN.FtpResourceID = objDT.Rows[0][convTeachCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvTeachCaseRelaInfoEN.FileOriginalName = objDT.Rows[0][convTeachCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名(字段类型:varchar,字段长度:200,是否可空:True)
 objvTeachCaseRelaInfoEN.FileDirName = objDT.Rows[0][convTeachCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objvTeachCaseRelaInfoEN.FileRename = objDT.Rows[0][convTeachCaseRelaInfo.FileRename].ToString().Trim(); //文件新名(字段类型:varchar,字段长度:200,是否可空:True)
 objvTeachCaseRelaInfoEN.FileUpDate = objDT.Rows[0][convTeachCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvTeachCaseRelaInfoEN.FileUpTime = objDT.Rows[0][convTeachCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvTeachCaseRelaInfoEN.FileSize = objDT.Rows[0][convTeachCaseRelaInfo.FileSize].ToString().Trim(); //文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvTeachCaseRelaInfoEN.FileType = objDT.Rows[0][convTeachCaseRelaInfo.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvTeachCaseRelaInfoEN.ResourceOwner = objDT.Rows[0][convTeachCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者(字段类型:varchar,字段长度:50,是否可空:False)
 objvTeachCaseRelaInfoEN.IdFile = objDT.Rows[0][convTeachCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号(字段类型:char,字段长度:8,是否可空:True)
 objvTeachCaseRelaInfoEN.FileName = objDT.Rows[0][convTeachCaseRelaInfo.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvTeachCaseRelaInfoEN.SaveDate = objDT.Rows[0][convTeachCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvTeachCaseRelaInfoEN.SaveTime = objDT.Rows[0][convTeachCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvTeachCaseRelaInfoEN.FileOriginName = objDT.Rows[0][convTeachCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名(字段类型:varchar,字段长度:500,是否可空:True)
 objvTeachCaseRelaInfoEN.IdResourceType = objDT.Rows[0][convTeachCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvTeachCaseRelaInfoEN.ResourceTypeID = objDT.Rows[0][convTeachCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvTeachCaseRelaInfoEN.ResourceTypeName = objDT.Rows[0][convTeachCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvTeachCaseRelaInfoEN.FileNewName = objDT.Rows[0][convTeachCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvTeachCaseRelaInfoEN.FileOldName = objDT.Rows[0][convTeachCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvTeachCaseRelaInfoEN.ftpFileType = objDT.Rows[0][convTeachCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvTeachCaseRelaInfoEN.ftpFileSize = objDT.Rows[0][convTeachCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvTeachCaseRelaInfoEN.ftpResourceOwner = objDT.Rows[0][convTeachCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者(字段类型:varchar,字段长度:50,是否可空:True)
 objvTeachCaseRelaInfoEN.IdTeachCaseRelaInfoType = objDT.Rows[0][convTeachCaseRelaInfo.IdTeachCaseRelaInfoType].ToString().Trim(); //案例相关信息类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvTeachCaseRelaInfoEN.TeachCaseRelaInfoTypeID = objDT.Rows[0][convTeachCaseRelaInfo.TeachCaseRelaInfoTypeID].ToString().Trim(); //案例相关信息类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvTeachCaseRelaInfoEN.TeachCaseRelaInfoTypeName = objDT.Rows[0][convTeachCaseRelaInfo.TeachCaseRelaInfoTypeName].ToString().Trim(); //案例相关信息类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvTeachCaseRelaInfoEN.IsVisible = TransNullToBool(objDT.Rows[0][convTeachCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvTeachCaseRelaInfoEN.BrowseCount = TransNullToInt(objDT.Rows[0][convTeachCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvTeachCaseRelaInfoEN.Memo = objDT.Rows[0][convTeachCaseRelaInfo.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvTeachCaseRelaInfoDA: GetvTeachCaseRelaInfo)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdTeachCaseRelaInfo">表关键字</param>
 /// <returns>表对象</returns>
public clsvTeachCaseRelaInfoEN GetObjByIdTeachCaseRelaInfo(long lngIdTeachCaseRelaInfo)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vTeachCaseRelaInfo where IdTeachCaseRelaInfo = " + ""+ lngIdTeachCaseRelaInfo+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN = new clsvTeachCaseRelaInfoEN();
try
{
 objvTeachCaseRelaInfoEN.IdTeachCaseRelaInfo = Int32.Parse(objRow[convTeachCaseRelaInfo.IdTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvTeachCaseRelaInfoEN.IdTeachCase = objRow[convTeachCaseRelaInfo.IdTeachCase].ToString().Trim(); //案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvTeachCaseRelaInfoEN.TeachCaseName = objRow[convTeachCaseRelaInfo.TeachCaseName].ToString().Trim(); //案例名称(字段类型:varchar,字段长度:200,是否可空:False)
 objvTeachCaseRelaInfoEN.IdResource = objRow[convTeachCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objvTeachCaseRelaInfoEN.ResourceID = objRow[convTeachCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvTeachCaseRelaInfoEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convTeachCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式(字段类型:bit,字段长度:1,是否可空:True)
 objvTeachCaseRelaInfoEN.IdFtpResource = objRow[convTeachCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objvTeachCaseRelaInfoEN.FtpResourceID = objRow[convTeachCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvTeachCaseRelaInfoEN.FileOriginalName = objRow[convTeachCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名(字段类型:varchar,字段长度:200,是否可空:True)
 objvTeachCaseRelaInfoEN.FileDirName = objRow[convTeachCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objvTeachCaseRelaInfoEN.FileRename = objRow[convTeachCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileRename].ToString().Trim(); //文件新名(字段类型:varchar,字段长度:200,是否可空:True)
 objvTeachCaseRelaInfoEN.FileUpDate = objRow[convTeachCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvTeachCaseRelaInfoEN.FileUpTime = objRow[convTeachCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvTeachCaseRelaInfoEN.FileSize = objRow[convTeachCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileSize].ToString().Trim(); //文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvTeachCaseRelaInfoEN.FileType = objRow[convTeachCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvTeachCaseRelaInfoEN.ResourceOwner = objRow[convTeachCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者(字段类型:varchar,字段长度:50,是否可空:False)
 objvTeachCaseRelaInfoEN.IdFile = objRow[convTeachCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号(字段类型:char,字段长度:8,是否可空:True)
 objvTeachCaseRelaInfoEN.FileName = objRow[convTeachCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvTeachCaseRelaInfoEN.SaveDate = objRow[convTeachCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvTeachCaseRelaInfoEN.SaveTime = objRow[convTeachCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvTeachCaseRelaInfoEN.FileOriginName = objRow[convTeachCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名(字段类型:varchar,字段长度:500,是否可空:True)
 objvTeachCaseRelaInfoEN.IdResourceType = objRow[convTeachCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvTeachCaseRelaInfoEN.ResourceTypeID = objRow[convTeachCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvTeachCaseRelaInfoEN.ResourceTypeName = objRow[convTeachCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvTeachCaseRelaInfoEN.FileNewName = objRow[convTeachCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvTeachCaseRelaInfoEN.FileOldName = objRow[convTeachCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvTeachCaseRelaInfoEN.ftpFileType = objRow[convTeachCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvTeachCaseRelaInfoEN.ftpFileSize = objRow[convTeachCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvTeachCaseRelaInfoEN.ftpResourceOwner = objRow[convTeachCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者(字段类型:varchar,字段长度:50,是否可空:True)
 objvTeachCaseRelaInfoEN.IdTeachCaseRelaInfoType = objRow[convTeachCaseRelaInfo.IdTeachCaseRelaInfoType].ToString().Trim(); //案例相关信息类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvTeachCaseRelaInfoEN.TeachCaseRelaInfoTypeID = objRow[convTeachCaseRelaInfo.TeachCaseRelaInfoTypeID].ToString().Trim(); //案例相关信息类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvTeachCaseRelaInfoEN.TeachCaseRelaInfoTypeName = objRow[convTeachCaseRelaInfo.TeachCaseRelaInfoTypeName].ToString().Trim(); //案例相关信息类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvTeachCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvTeachCaseRelaInfoEN.BrowseCount = objRow[convTeachCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvTeachCaseRelaInfoEN.Memo = objRow[convTeachCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvTeachCaseRelaInfoDA: GetObjByIdTeachCaseRelaInfo)", objException.Message));
}
return objvTeachCaseRelaInfoEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvTeachCaseRelaInfoEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvTeachCaseRelaInfoDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vTeachCaseRelaInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN = new clsvTeachCaseRelaInfoEN()
{
IdTeachCaseRelaInfo = TransNullToInt(objRow[convTeachCaseRelaInfo.IdTeachCaseRelaInfo].ToString().Trim()), //案例相关信息流水号
IdTeachCase = objRow[convTeachCaseRelaInfo.IdTeachCase].ToString().Trim(), //案例流水号
TeachCaseName = objRow[convTeachCaseRelaInfo.TeachCaseName].ToString().Trim(), //案例名称
IdResource = objRow[convTeachCaseRelaInfo.IdResource].ToString().Trim(), //资源流水号
ResourceID = objRow[convTeachCaseRelaInfo.ResourceID].ToString().Trim(), //资源ID
SaveMode = TransNullToBool(objRow[convTeachCaseRelaInfo.SaveMode].ToString().Trim()), //文件存放方式
IdFtpResource = objRow[convTeachCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.IdFtpResource].ToString().Trim(), //FTP资源流水号
FtpResourceID = objRow[convTeachCaseRelaInfo.FtpResourceID].ToString().Trim(), //FTP资源ID
FileOriginalName = objRow[convTeachCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileOriginalName].ToString().Trim(), //文件原名
FileDirName = objRow[convTeachCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileDirName].ToString().Trim(), //文件目录名
FileRename = objRow[convTeachCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileRename].ToString().Trim(), //文件新名
FileUpDate = objRow[convTeachCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileUpDate].ToString().Trim(), //创建日期
FileUpTime = objRow[convTeachCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileUpTime].ToString().Trim(), //创建时间
FileSize = objRow[convTeachCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileSize].ToString().Trim(), //文件大小
FileType = objRow[convTeachCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileType].ToString().Trim(), //文件类型
ResourceOwner = objRow[convTeachCaseRelaInfo.ResourceOwner].ToString().Trim(), //上传者
IdFile = objRow[convTeachCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.IdFile].ToString().Trim(), //文件流水号
FileName = objRow[convTeachCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileName].ToString().Trim(), //文件名称
SaveDate = objRow[convTeachCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.SaveDate].ToString().Trim(), //创建日期
SaveTime = objRow[convTeachCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.SaveTime].ToString().Trim(), //创建时间
FileOriginName = objRow[convTeachCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileOriginName].ToString().Trim(), //原文件名
IdResourceType = objRow[convTeachCaseRelaInfo.IdResourceType].ToString().Trim(), //资源类型流水号
ResourceTypeID = objRow[convTeachCaseRelaInfo.ResourceTypeID].ToString().Trim(), //资源类型ID
ResourceTypeName = objRow[convTeachCaseRelaInfo.ResourceTypeName].ToString().Trim(), //资源类型名称
FileNewName = objRow[convTeachCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileNewName].ToString().Trim(), //新文件名
FileOldName = objRow[convTeachCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileOldName].ToString().Trim(), //旧文件名
ftpFileType = objRow[convTeachCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.ftpFileType].ToString().Trim(), //ftp文件类型
ftpFileSize = objRow[convTeachCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.ftpFileSize].ToString().Trim(), //ftp文件大小
ftpResourceOwner = objRow[convTeachCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.ftpResourceOwner].ToString().Trim(), //Ftp资源拥有者
IdTeachCaseRelaInfoType = objRow[convTeachCaseRelaInfo.IdTeachCaseRelaInfoType].ToString().Trim(), //案例相关信息类型流水号
TeachCaseRelaInfoTypeID = objRow[convTeachCaseRelaInfo.TeachCaseRelaInfoTypeID].ToString().Trim(), //案例相关信息类型ID
TeachCaseRelaInfoTypeName = objRow[convTeachCaseRelaInfo.TeachCaseRelaInfoTypeName].ToString().Trim(), //案例相关信息类型名称
IsVisible = TransNullToBool(objRow[convTeachCaseRelaInfo.IsVisible].ToString().Trim()), //是否显示
BrowseCount = objRow[convTeachCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachCaseRelaInfo.BrowseCount].ToString().Trim()), //浏览次数
Memo = objRow[convTeachCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.Memo].ToString().Trim() //备注
};
objvTeachCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvTeachCaseRelaInfoEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvTeachCaseRelaInfoDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvTeachCaseRelaInfoEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN = new clsvTeachCaseRelaInfoEN();
try
{
objvTeachCaseRelaInfoEN.IdTeachCaseRelaInfo = TransNullToInt(objRow[convTeachCaseRelaInfo.IdTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvTeachCaseRelaInfoEN.IdTeachCase = objRow[convTeachCaseRelaInfo.IdTeachCase].ToString().Trim(); //案例流水号
objvTeachCaseRelaInfoEN.TeachCaseName = objRow[convTeachCaseRelaInfo.TeachCaseName].ToString().Trim(); //案例名称
objvTeachCaseRelaInfoEN.IdResource = objRow[convTeachCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvTeachCaseRelaInfoEN.ResourceID = objRow[convTeachCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvTeachCaseRelaInfoEN.SaveMode = TransNullToBool(objRow[convTeachCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvTeachCaseRelaInfoEN.IdFtpResource = objRow[convTeachCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvTeachCaseRelaInfoEN.FtpResourceID = objRow[convTeachCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvTeachCaseRelaInfoEN.FileOriginalName = objRow[convTeachCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvTeachCaseRelaInfoEN.FileDirName = objRow[convTeachCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvTeachCaseRelaInfoEN.FileRename = objRow[convTeachCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvTeachCaseRelaInfoEN.FileUpDate = objRow[convTeachCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvTeachCaseRelaInfoEN.FileUpTime = objRow[convTeachCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvTeachCaseRelaInfoEN.FileSize = objRow[convTeachCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvTeachCaseRelaInfoEN.FileType = objRow[convTeachCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvTeachCaseRelaInfoEN.ResourceOwner = objRow[convTeachCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvTeachCaseRelaInfoEN.IdFile = objRow[convTeachCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvTeachCaseRelaInfoEN.FileName = objRow[convTeachCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvTeachCaseRelaInfoEN.SaveDate = objRow[convTeachCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvTeachCaseRelaInfoEN.SaveTime = objRow[convTeachCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvTeachCaseRelaInfoEN.FileOriginName = objRow[convTeachCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvTeachCaseRelaInfoEN.IdResourceType = objRow[convTeachCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvTeachCaseRelaInfoEN.ResourceTypeID = objRow[convTeachCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvTeachCaseRelaInfoEN.ResourceTypeName = objRow[convTeachCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvTeachCaseRelaInfoEN.FileNewName = objRow[convTeachCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvTeachCaseRelaInfoEN.FileOldName = objRow[convTeachCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvTeachCaseRelaInfoEN.ftpFileType = objRow[convTeachCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachCaseRelaInfoEN.ftpFileSize = objRow[convTeachCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvTeachCaseRelaInfoEN.ftpResourceOwner = objRow[convTeachCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvTeachCaseRelaInfoEN.IdTeachCaseRelaInfoType = objRow[convTeachCaseRelaInfo.IdTeachCaseRelaInfoType].ToString().Trim(); //案例相关信息类型流水号
objvTeachCaseRelaInfoEN.TeachCaseRelaInfoTypeID = objRow[convTeachCaseRelaInfo.TeachCaseRelaInfoTypeID].ToString().Trim(); //案例相关信息类型ID
objvTeachCaseRelaInfoEN.TeachCaseRelaInfoTypeName = objRow[convTeachCaseRelaInfo.TeachCaseRelaInfoTypeName].ToString().Trim(); //案例相关信息类型名称
objvTeachCaseRelaInfoEN.IsVisible = TransNullToBool(objRow[convTeachCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvTeachCaseRelaInfoEN.BrowseCount = objRow[convTeachCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvTeachCaseRelaInfoEN.Memo = objRow[convTeachCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvTeachCaseRelaInfoDA: GetObjByDataRowvTeachCaseRelaInfo)", objException.Message));
}
objvTeachCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvTeachCaseRelaInfoEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvTeachCaseRelaInfoEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN = new clsvTeachCaseRelaInfoEN();
try
{
objvTeachCaseRelaInfoEN.IdTeachCaseRelaInfo = TransNullToInt(objRow[convTeachCaseRelaInfo.IdTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvTeachCaseRelaInfoEN.IdTeachCase = objRow[convTeachCaseRelaInfo.IdTeachCase].ToString().Trim(); //案例流水号
objvTeachCaseRelaInfoEN.TeachCaseName = objRow[convTeachCaseRelaInfo.TeachCaseName].ToString().Trim(); //案例名称
objvTeachCaseRelaInfoEN.IdResource = objRow[convTeachCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvTeachCaseRelaInfoEN.ResourceID = objRow[convTeachCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvTeachCaseRelaInfoEN.SaveMode = TransNullToBool(objRow[convTeachCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvTeachCaseRelaInfoEN.IdFtpResource = objRow[convTeachCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvTeachCaseRelaInfoEN.FtpResourceID = objRow[convTeachCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvTeachCaseRelaInfoEN.FileOriginalName = objRow[convTeachCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvTeachCaseRelaInfoEN.FileDirName = objRow[convTeachCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvTeachCaseRelaInfoEN.FileRename = objRow[convTeachCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvTeachCaseRelaInfoEN.FileUpDate = objRow[convTeachCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvTeachCaseRelaInfoEN.FileUpTime = objRow[convTeachCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvTeachCaseRelaInfoEN.FileSize = objRow[convTeachCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvTeachCaseRelaInfoEN.FileType = objRow[convTeachCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvTeachCaseRelaInfoEN.ResourceOwner = objRow[convTeachCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvTeachCaseRelaInfoEN.IdFile = objRow[convTeachCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvTeachCaseRelaInfoEN.FileName = objRow[convTeachCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvTeachCaseRelaInfoEN.SaveDate = objRow[convTeachCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvTeachCaseRelaInfoEN.SaveTime = objRow[convTeachCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvTeachCaseRelaInfoEN.FileOriginName = objRow[convTeachCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvTeachCaseRelaInfoEN.IdResourceType = objRow[convTeachCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvTeachCaseRelaInfoEN.ResourceTypeID = objRow[convTeachCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvTeachCaseRelaInfoEN.ResourceTypeName = objRow[convTeachCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvTeachCaseRelaInfoEN.FileNewName = objRow[convTeachCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvTeachCaseRelaInfoEN.FileOldName = objRow[convTeachCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvTeachCaseRelaInfoEN.ftpFileType = objRow[convTeachCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachCaseRelaInfoEN.ftpFileSize = objRow[convTeachCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvTeachCaseRelaInfoEN.ftpResourceOwner = objRow[convTeachCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvTeachCaseRelaInfoEN.IdTeachCaseRelaInfoType = objRow[convTeachCaseRelaInfo.IdTeachCaseRelaInfoType].ToString().Trim(); //案例相关信息类型流水号
objvTeachCaseRelaInfoEN.TeachCaseRelaInfoTypeID = objRow[convTeachCaseRelaInfo.TeachCaseRelaInfoTypeID].ToString().Trim(); //案例相关信息类型ID
objvTeachCaseRelaInfoEN.TeachCaseRelaInfoTypeName = objRow[convTeachCaseRelaInfo.TeachCaseRelaInfoTypeName].ToString().Trim(); //案例相关信息类型名称
objvTeachCaseRelaInfoEN.IsVisible = TransNullToBool(objRow[convTeachCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvTeachCaseRelaInfoEN.BrowseCount = objRow[convTeachCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvTeachCaseRelaInfoEN.Memo = objRow[convTeachCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvTeachCaseRelaInfoDA: GetObjByDataRow)", objException.Message));
}
objvTeachCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvTeachCaseRelaInfoEN;
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
objSQL = clsvTeachCaseRelaInfoDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvTeachCaseRelaInfoEN._CurrTabName, convTeachCaseRelaInfo.IdTeachCaseRelaInfo, 8, "");
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
objSQL = clsvTeachCaseRelaInfoDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvTeachCaseRelaInfoEN._CurrTabName, convTeachCaseRelaInfo.IdTeachCaseRelaInfo, 8, strPrefix);
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
 objSQL = clsvTeachCaseRelaInfoDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdTeachCaseRelaInfo from vTeachCaseRelaInfo where " + strCondition;
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
 objSQL = clsvTeachCaseRelaInfoDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdTeachCaseRelaInfo from vTeachCaseRelaInfo where " + strCondition;
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
 /// <param name = "lngIdTeachCaseRelaInfo">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngIdTeachCaseRelaInfo)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachCaseRelaInfoDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vTeachCaseRelaInfo", "IdTeachCaseRelaInfo = " + ""+ lngIdTeachCaseRelaInfo+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvTeachCaseRelaInfoDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachCaseRelaInfoDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vTeachCaseRelaInfo", strCondition))
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
objSQL = clsvTeachCaseRelaInfoDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vTeachCaseRelaInfo");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoENS">源对象</param>
 /// <param name = "objvTeachCaseRelaInfoENT">目标对象</param>
public void CopyTo(clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoENS, clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoENT)
{
objvTeachCaseRelaInfoENT.IdTeachCaseRelaInfo = objvTeachCaseRelaInfoENS.IdTeachCaseRelaInfo; //案例相关信息流水号
objvTeachCaseRelaInfoENT.IdTeachCase = objvTeachCaseRelaInfoENS.IdTeachCase; //案例流水号
objvTeachCaseRelaInfoENT.TeachCaseName = objvTeachCaseRelaInfoENS.TeachCaseName; //案例名称
objvTeachCaseRelaInfoENT.IdResource = objvTeachCaseRelaInfoENS.IdResource; //资源流水号
objvTeachCaseRelaInfoENT.ResourceID = objvTeachCaseRelaInfoENS.ResourceID; //资源ID
objvTeachCaseRelaInfoENT.SaveMode = objvTeachCaseRelaInfoENS.SaveMode; //文件存放方式
objvTeachCaseRelaInfoENT.IdFtpResource = objvTeachCaseRelaInfoENS.IdFtpResource; //FTP资源流水号
objvTeachCaseRelaInfoENT.FtpResourceID = objvTeachCaseRelaInfoENS.FtpResourceID; //FTP资源ID
objvTeachCaseRelaInfoENT.FileOriginalName = objvTeachCaseRelaInfoENS.FileOriginalName; //文件原名
objvTeachCaseRelaInfoENT.FileDirName = objvTeachCaseRelaInfoENS.FileDirName; //文件目录名
objvTeachCaseRelaInfoENT.FileRename = objvTeachCaseRelaInfoENS.FileRename; //文件新名
objvTeachCaseRelaInfoENT.FileUpDate = objvTeachCaseRelaInfoENS.FileUpDate; //创建日期
objvTeachCaseRelaInfoENT.FileUpTime = objvTeachCaseRelaInfoENS.FileUpTime; //创建时间
objvTeachCaseRelaInfoENT.FileSize = objvTeachCaseRelaInfoENS.FileSize; //文件大小
objvTeachCaseRelaInfoENT.FileType = objvTeachCaseRelaInfoENS.FileType; //文件类型
objvTeachCaseRelaInfoENT.ResourceOwner = objvTeachCaseRelaInfoENS.ResourceOwner; //上传者
objvTeachCaseRelaInfoENT.IdFile = objvTeachCaseRelaInfoENS.IdFile; //文件流水号
objvTeachCaseRelaInfoENT.FileName = objvTeachCaseRelaInfoENS.FileName; //文件名称
objvTeachCaseRelaInfoENT.SaveDate = objvTeachCaseRelaInfoENS.SaveDate; //创建日期
objvTeachCaseRelaInfoENT.SaveTime = objvTeachCaseRelaInfoENS.SaveTime; //创建时间
objvTeachCaseRelaInfoENT.FileOriginName = objvTeachCaseRelaInfoENS.FileOriginName; //原文件名
objvTeachCaseRelaInfoENT.IdResourceType = objvTeachCaseRelaInfoENS.IdResourceType; //资源类型流水号
objvTeachCaseRelaInfoENT.ResourceTypeID = objvTeachCaseRelaInfoENS.ResourceTypeID; //资源类型ID
objvTeachCaseRelaInfoENT.ResourceTypeName = objvTeachCaseRelaInfoENS.ResourceTypeName; //资源类型名称
objvTeachCaseRelaInfoENT.FileNewName = objvTeachCaseRelaInfoENS.FileNewName; //新文件名
objvTeachCaseRelaInfoENT.FileOldName = objvTeachCaseRelaInfoENS.FileOldName; //旧文件名
objvTeachCaseRelaInfoENT.ftpFileType = objvTeachCaseRelaInfoENS.ftpFileType; //ftp文件类型
objvTeachCaseRelaInfoENT.ftpFileSize = objvTeachCaseRelaInfoENS.ftpFileSize; //ftp文件大小
objvTeachCaseRelaInfoENT.ftpResourceOwner = objvTeachCaseRelaInfoENS.ftpResourceOwner; //Ftp资源拥有者
objvTeachCaseRelaInfoENT.IdTeachCaseRelaInfoType = objvTeachCaseRelaInfoENS.IdTeachCaseRelaInfoType; //案例相关信息类型流水号
objvTeachCaseRelaInfoENT.TeachCaseRelaInfoTypeID = objvTeachCaseRelaInfoENS.TeachCaseRelaInfoTypeID; //案例相关信息类型ID
objvTeachCaseRelaInfoENT.TeachCaseRelaInfoTypeName = objvTeachCaseRelaInfoENS.TeachCaseRelaInfoTypeName; //案例相关信息类型名称
objvTeachCaseRelaInfoENT.IsVisible = objvTeachCaseRelaInfoENS.IsVisible; //是否显示
objvTeachCaseRelaInfoENT.BrowseCount = objvTeachCaseRelaInfoENS.BrowseCount; //浏览次数
objvTeachCaseRelaInfoENT.Memo = objvTeachCaseRelaInfoENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvTeachCaseRelaInfoEN.IdTeachCase, 8, convTeachCaseRelaInfo.IdTeachCase);
clsCheckSql.CheckFieldLen(objvTeachCaseRelaInfoEN.TeachCaseName, 200, convTeachCaseRelaInfo.TeachCaseName);
clsCheckSql.CheckFieldLen(objvTeachCaseRelaInfoEN.IdResource, 8, convTeachCaseRelaInfo.IdResource);
clsCheckSql.CheckFieldLen(objvTeachCaseRelaInfoEN.ResourceID, 8, convTeachCaseRelaInfo.ResourceID);
clsCheckSql.CheckFieldLen(objvTeachCaseRelaInfoEN.IdFtpResource, 8, convTeachCaseRelaInfo.IdFtpResource);
clsCheckSql.CheckFieldLen(objvTeachCaseRelaInfoEN.FtpResourceID, 8, convTeachCaseRelaInfo.FtpResourceID);
clsCheckSql.CheckFieldLen(objvTeachCaseRelaInfoEN.FileOriginalName, 200, convTeachCaseRelaInfo.FileOriginalName);
clsCheckSql.CheckFieldLen(objvTeachCaseRelaInfoEN.FileDirName, 200, convTeachCaseRelaInfo.FileDirName);
clsCheckSql.CheckFieldLen(objvTeachCaseRelaInfoEN.FileRename, 200, convTeachCaseRelaInfo.FileRename);
clsCheckSql.CheckFieldLen(objvTeachCaseRelaInfoEN.FileUpDate, 8, convTeachCaseRelaInfo.FileUpDate);
clsCheckSql.CheckFieldLen(objvTeachCaseRelaInfoEN.FileUpTime, 6, convTeachCaseRelaInfo.FileUpTime);
clsCheckSql.CheckFieldLen(objvTeachCaseRelaInfoEN.FileSize, 50, convTeachCaseRelaInfo.FileSize);
clsCheckSql.CheckFieldLen(objvTeachCaseRelaInfoEN.FileType, 30, convTeachCaseRelaInfo.FileType);
clsCheckSql.CheckFieldLen(objvTeachCaseRelaInfoEN.ResourceOwner, 50, convTeachCaseRelaInfo.ResourceOwner);
clsCheckSql.CheckFieldLen(objvTeachCaseRelaInfoEN.IdFile, 8, convTeachCaseRelaInfo.IdFile);
clsCheckSql.CheckFieldLen(objvTeachCaseRelaInfoEN.FileName, 500, convTeachCaseRelaInfo.FileName);
clsCheckSql.CheckFieldLen(objvTeachCaseRelaInfoEN.SaveDate, 8, convTeachCaseRelaInfo.SaveDate);
clsCheckSql.CheckFieldLen(objvTeachCaseRelaInfoEN.SaveTime, 6, convTeachCaseRelaInfo.SaveTime);
clsCheckSql.CheckFieldLen(objvTeachCaseRelaInfoEN.FileOriginName, 500, convTeachCaseRelaInfo.FileOriginName);
clsCheckSql.CheckFieldLen(objvTeachCaseRelaInfoEN.IdResourceType, 4, convTeachCaseRelaInfo.IdResourceType);
clsCheckSql.CheckFieldLen(objvTeachCaseRelaInfoEN.ResourceTypeID, 4, convTeachCaseRelaInfo.ResourceTypeID);
clsCheckSql.CheckFieldLen(objvTeachCaseRelaInfoEN.ResourceTypeName, 50, convTeachCaseRelaInfo.ResourceTypeName);
clsCheckSql.CheckFieldLen(objvTeachCaseRelaInfoEN.FileNewName, 530, convTeachCaseRelaInfo.FileNewName);
clsCheckSql.CheckFieldLen(objvTeachCaseRelaInfoEN.FileOldName, 530, convTeachCaseRelaInfo.FileOldName);
clsCheckSql.CheckFieldLen(objvTeachCaseRelaInfoEN.ftpFileType, 30, convTeachCaseRelaInfo.ftpFileType);
clsCheckSql.CheckFieldLen(objvTeachCaseRelaInfoEN.ftpFileSize, 50, convTeachCaseRelaInfo.ftpFileSize);
clsCheckSql.CheckFieldLen(objvTeachCaseRelaInfoEN.ftpResourceOwner, 50, convTeachCaseRelaInfo.ftpResourceOwner);
clsCheckSql.CheckFieldLen(objvTeachCaseRelaInfoEN.IdTeachCaseRelaInfoType, 4, convTeachCaseRelaInfo.IdTeachCaseRelaInfoType);
clsCheckSql.CheckFieldLen(objvTeachCaseRelaInfoEN.TeachCaseRelaInfoTypeID, 4, convTeachCaseRelaInfo.TeachCaseRelaInfoTypeID);
clsCheckSql.CheckFieldLen(objvTeachCaseRelaInfoEN.TeachCaseRelaInfoTypeName, 50, convTeachCaseRelaInfo.TeachCaseRelaInfoTypeName);
clsCheckSql.CheckFieldLen(objvTeachCaseRelaInfoEN.Memo, 1000, convTeachCaseRelaInfo.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvTeachCaseRelaInfoEN.IdTeachCase, convTeachCaseRelaInfo.IdTeachCase);
clsCheckSql.CheckSqlInjection4Field(objvTeachCaseRelaInfoEN.TeachCaseName, convTeachCaseRelaInfo.TeachCaseName);
clsCheckSql.CheckSqlInjection4Field(objvTeachCaseRelaInfoEN.IdResource, convTeachCaseRelaInfo.IdResource);
clsCheckSql.CheckSqlInjection4Field(objvTeachCaseRelaInfoEN.ResourceID, convTeachCaseRelaInfo.ResourceID);
clsCheckSql.CheckSqlInjection4Field(objvTeachCaseRelaInfoEN.IdFtpResource, convTeachCaseRelaInfo.IdFtpResource);
clsCheckSql.CheckSqlInjection4Field(objvTeachCaseRelaInfoEN.FtpResourceID, convTeachCaseRelaInfo.FtpResourceID);
clsCheckSql.CheckSqlInjection4Field(objvTeachCaseRelaInfoEN.FileOriginalName, convTeachCaseRelaInfo.FileOriginalName);
clsCheckSql.CheckSqlInjection4Field(objvTeachCaseRelaInfoEN.FileDirName, convTeachCaseRelaInfo.FileDirName);
clsCheckSql.CheckSqlInjection4Field(objvTeachCaseRelaInfoEN.FileRename, convTeachCaseRelaInfo.FileRename);
clsCheckSql.CheckSqlInjection4Field(objvTeachCaseRelaInfoEN.FileUpDate, convTeachCaseRelaInfo.FileUpDate);
clsCheckSql.CheckSqlInjection4Field(objvTeachCaseRelaInfoEN.FileUpTime, convTeachCaseRelaInfo.FileUpTime);
clsCheckSql.CheckSqlInjection4Field(objvTeachCaseRelaInfoEN.FileSize, convTeachCaseRelaInfo.FileSize);
clsCheckSql.CheckSqlInjection4Field(objvTeachCaseRelaInfoEN.FileType, convTeachCaseRelaInfo.FileType);
clsCheckSql.CheckSqlInjection4Field(objvTeachCaseRelaInfoEN.ResourceOwner, convTeachCaseRelaInfo.ResourceOwner);
clsCheckSql.CheckSqlInjection4Field(objvTeachCaseRelaInfoEN.IdFile, convTeachCaseRelaInfo.IdFile);
clsCheckSql.CheckSqlInjection4Field(objvTeachCaseRelaInfoEN.FileName, convTeachCaseRelaInfo.FileName);
clsCheckSql.CheckSqlInjection4Field(objvTeachCaseRelaInfoEN.SaveDate, convTeachCaseRelaInfo.SaveDate);
clsCheckSql.CheckSqlInjection4Field(objvTeachCaseRelaInfoEN.SaveTime, convTeachCaseRelaInfo.SaveTime);
clsCheckSql.CheckSqlInjection4Field(objvTeachCaseRelaInfoEN.FileOriginName, convTeachCaseRelaInfo.FileOriginName);
clsCheckSql.CheckSqlInjection4Field(objvTeachCaseRelaInfoEN.IdResourceType, convTeachCaseRelaInfo.IdResourceType);
clsCheckSql.CheckSqlInjection4Field(objvTeachCaseRelaInfoEN.ResourceTypeID, convTeachCaseRelaInfo.ResourceTypeID);
clsCheckSql.CheckSqlInjection4Field(objvTeachCaseRelaInfoEN.ResourceTypeName, convTeachCaseRelaInfo.ResourceTypeName);
clsCheckSql.CheckSqlInjection4Field(objvTeachCaseRelaInfoEN.FileNewName, convTeachCaseRelaInfo.FileNewName);
clsCheckSql.CheckSqlInjection4Field(objvTeachCaseRelaInfoEN.FileOldName, convTeachCaseRelaInfo.FileOldName);
clsCheckSql.CheckSqlInjection4Field(objvTeachCaseRelaInfoEN.ftpFileType, convTeachCaseRelaInfo.ftpFileType);
clsCheckSql.CheckSqlInjection4Field(objvTeachCaseRelaInfoEN.ftpFileSize, convTeachCaseRelaInfo.ftpFileSize);
clsCheckSql.CheckSqlInjection4Field(objvTeachCaseRelaInfoEN.ftpResourceOwner, convTeachCaseRelaInfo.ftpResourceOwner);
clsCheckSql.CheckSqlInjection4Field(objvTeachCaseRelaInfoEN.IdTeachCaseRelaInfoType, convTeachCaseRelaInfo.IdTeachCaseRelaInfoType);
clsCheckSql.CheckSqlInjection4Field(objvTeachCaseRelaInfoEN.TeachCaseRelaInfoTypeID, convTeachCaseRelaInfo.TeachCaseRelaInfoTypeID);
clsCheckSql.CheckSqlInjection4Field(objvTeachCaseRelaInfoEN.TeachCaseRelaInfoTypeName, convTeachCaseRelaInfo.TeachCaseRelaInfoTypeName);
clsCheckSql.CheckSqlInjection4Field(objvTeachCaseRelaInfoEN.Memo, convTeachCaseRelaInfo.Memo);
//检查外键字段长度
 objvTeachCaseRelaInfoEN._IsCheckProperty = true;
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
 objSQL = clsvTeachCaseRelaInfoDA.GetSpecSQLObj();
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
 objSQL = clsvTeachCaseRelaInfoDA.GetSpecSQLObj();
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
 objSQL = clsvTeachCaseRelaInfoDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvTeachCaseRelaInfoEN._CurrTabName);
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
 objSQL = clsvTeachCaseRelaInfoDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvTeachCaseRelaInfoEN._CurrTabName, strCondition);
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
 objSQL = clsvTeachCaseRelaInfoDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}