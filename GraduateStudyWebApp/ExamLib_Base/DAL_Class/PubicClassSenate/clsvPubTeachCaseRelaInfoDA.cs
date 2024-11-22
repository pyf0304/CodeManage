
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPubTeachCaseRelaInfoDA
 表名:vPubTeachCaseRelaInfo(01120400)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:48:56
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课例观摩(PubicClassSenate)
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
 /// v公开课案例相关信息(vPubTeachCaseRelaInfo)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvPubTeachCaseRelaInfoDA : clsCommBase4DA
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
 return clsvPubTeachCaseRelaInfoEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvPubTeachCaseRelaInfoEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvPubTeachCaseRelaInfoEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvPubTeachCaseRelaInfoEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvPubTeachCaseRelaInfoEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvPubTeachCaseRelaInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubTeachCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vPubTeachCaseRelaInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vPubTeachCaseRelaInfo(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvPubTeachCaseRelaInfoDA: GetDataTable_vPubTeachCaseRelaInfo)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubTeachCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vPubTeachCaseRelaInfo where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvPubTeachCaseRelaInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubTeachCaseRelaInfoDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvPubTeachCaseRelaInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubTeachCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vPubTeachCaseRelaInfo where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvPubTeachCaseRelaInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubTeachCaseRelaInfoDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvPubTeachCaseRelaInfoDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubTeachCaseRelaInfoDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPubTeachCaseRelaInfo where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPubTeachCaseRelaInfo where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvPubTeachCaseRelaInfoDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubTeachCaseRelaInfoDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vPubTeachCaseRelaInfo where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvPubTeachCaseRelaInfoDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubTeachCaseRelaInfoDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vPubTeachCaseRelaInfo.* from vPubTeachCaseRelaInfo Left Join {1} on {2} where {3} and vPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfo not in (Select top {5} vPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfo from vPubTeachCaseRelaInfo Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPubTeachCaseRelaInfo where {1} and IdPubTeachCaseRelaInfo not in (Select top {2} IdPubTeachCaseRelaInfo from vPubTeachCaseRelaInfo where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPubTeachCaseRelaInfo where {1} and IdPubTeachCaseRelaInfo not in (Select top {3} IdPubTeachCaseRelaInfo from vPubTeachCaseRelaInfo where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvPubTeachCaseRelaInfoDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubTeachCaseRelaInfoDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vPubTeachCaseRelaInfo.* from vPubTeachCaseRelaInfo Left Join {1} on {2} where {3} and vPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfo not in (Select top {5} vPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfo from vPubTeachCaseRelaInfo Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPubTeachCaseRelaInfo where {1} and IdPubTeachCaseRelaInfo not in (Select top {2} IdPubTeachCaseRelaInfo from vPubTeachCaseRelaInfo where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPubTeachCaseRelaInfo where {1} and IdPubTeachCaseRelaInfo not in (Select top {3} IdPubTeachCaseRelaInfo from vPubTeachCaseRelaInfo where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvPubTeachCaseRelaInfoEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvPubTeachCaseRelaInfoDA:GetObjLst)", objException.Message));
}
List<clsvPubTeachCaseRelaInfoEN> arrObjLst = new List<clsvPubTeachCaseRelaInfoEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubTeachCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vPubTeachCaseRelaInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN = new clsvPubTeachCaseRelaInfoEN();
try
{
objvPubTeachCaseRelaInfoEN.IdPubTeachCaseRelaInfo = TransNullToInt(objRow[convPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfo].ToString().Trim()); //公开课案例相关信息流水号
objvPubTeachCaseRelaInfoEN.IsVisible = TransNullToBool(objRow[convPubTeachCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvPubTeachCaseRelaInfoEN.SubjectName = objRow[convPubTeachCaseRelaInfo.SubjectName].ToString().Trim(); //课题名称
objvPubTeachCaseRelaInfoEN.TeachingPlanAuthor = objRow[convPubTeachCaseRelaInfo.TeachingPlanAuthor] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingPlanAuthor].ToString().Trim(); //教案撰写人
objvPubTeachCaseRelaInfoEN.TeachingObject = objRow[convPubTeachCaseRelaInfo.TeachingObject] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingObject].ToString().Trim(); //教学目标
objvPubTeachCaseRelaInfoEN.TeachingEmphases = objRow[convPubTeachCaseRelaInfo.TeachingEmphases] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingEmphases].ToString().Trim(); //教学重点
objvPubTeachCaseRelaInfoEN.TeachingDifficulty = objRow[convPubTeachCaseRelaInfo.TeachingDifficulty] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingDifficulty].ToString().Trim(); //教学难点
objvPubTeachCaseRelaInfoEN.TeachingTool = objRow[convPubTeachCaseRelaInfo.TeachingTool] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingTool].ToString().Trim(); //教学用具
objvPubTeachCaseRelaInfoEN.TeachingProcess = objRow[convPubTeachCaseRelaInfo.TeachingProcess] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingProcess].ToString().Trim(); //教学过程
objvPubTeachCaseRelaInfoEN.IdFtpResource = objRow[convPubTeachCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvPubTeachCaseRelaInfoEN.FtpResourceID = objRow[convPubTeachCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvPubTeachCaseRelaInfoEN.FileOriginalName = objRow[convPubTeachCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvPubTeachCaseRelaInfoEN.FileDirName = objRow[convPubTeachCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvPubTeachCaseRelaInfoEN.FileRename = objRow[convPubTeachCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvPubTeachCaseRelaInfoEN.FileUpDate = objRow[convPubTeachCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvPubTeachCaseRelaInfoEN.FileUpTime = objRow[convPubTeachCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvPubTeachCaseRelaInfoEN.IdResource = objRow[convPubTeachCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvPubTeachCaseRelaInfoEN.SaveMode = TransNullToBool(objRow[convPubTeachCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvPubTeachCaseRelaInfoEN.IdResourceType = objRow[convPubTeachCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvPubTeachCaseRelaInfoEN.ResourceTypeID = objRow[convPubTeachCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvPubTeachCaseRelaInfoEN.ResourceTypeName = objRow[convPubTeachCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvPubTeachCaseRelaInfoEN.IdPubCaseType = objRow[convPubTeachCaseRelaInfo.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号
objvPubTeachCaseRelaInfoEN.PubCaseTypeID = objRow[convPubTeachCaseRelaInfo.PubCaseTypeID].ToString().Trim(); //公开课案例类型ID
objvPubTeachCaseRelaInfoEN.PubCaseTypeName = objRow[convPubTeachCaseRelaInfo.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPubTeachCaseRelaInfoEN.IdPubTeachCaseRelaInfoType = objRow[convPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfoType].ToString().Trim(); //公开课案例相关信息类型流水号
objvPubTeachCaseRelaInfoEN.PubTeachCaseRelaInfoTypeID = objRow[convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeID].ToString().Trim(); //公开课案例相关信息类型ID
objvPubTeachCaseRelaInfoEN.PubTeachCaseRelaInfoTypeName = objRow[convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeName].ToString().Trim(); //公开课案例相关信息类型名称
objvPubTeachCaseRelaInfoEN.TeachingPlanType = objRow[convPubTeachCaseRelaInfo.TeachingPlanType] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingPlanType].ToString().Trim(); //教案类型
objvPubTeachCaseRelaInfoEN.BrowseCount = objRow[convPubTeachCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPubTeachCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvPubTeachCaseRelaInfoEN.SimplePlanContent = objRow[convPubTeachCaseRelaInfo.SimplePlanContent] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.SimplePlanContent].ToString().Trim(); //简案内容
objvPubTeachCaseRelaInfoEN.ResourceOwner = objRow[convPubTeachCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvPubTeachCaseRelaInfoEN.ftpFileType = objRow[convPubTeachCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvPubTeachCaseRelaInfoEN.ftpFileSize = objRow[convPubTeachCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvPubTeachCaseRelaInfoEN.ftpResourceOwner = objRow[convPubTeachCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvPubTeachCaseRelaInfoEN.IdDiscipline = objRow[convPubTeachCaseRelaInfo.IdDiscipline].ToString().Trim(); //学科流水号
objvPubTeachCaseRelaInfoEN.DisciplineID = objRow[convPubTeachCaseRelaInfo.DisciplineID].ToString().Trim(); //学科ID
objvPubTeachCaseRelaInfoEN.DisciplineName = objRow[convPubTeachCaseRelaInfo.DisciplineName].ToString().Trim(); //学科名称
objvPubTeachCaseRelaInfoEN.IdStudyLevel = objRow[convPubTeachCaseRelaInfo.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvPubTeachCaseRelaInfoEN.StudyLevelName = objRow[convPubTeachCaseRelaInfo.StudyLevelName].ToString().Trim(); //学段名称
objvPubTeachCaseRelaInfoEN.IdFile = objRow[convPubTeachCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvPubTeachCaseRelaInfoEN.FileName = objRow[convPubTeachCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvPubTeachCaseRelaInfoEN.FileType = objRow[convPubTeachCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvPubTeachCaseRelaInfoEN.SaveDate = objRow[convPubTeachCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvPubTeachCaseRelaInfoEN.FileSize = objRow[convPubTeachCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvPubTeachCaseRelaInfoEN.SaveTime = objRow[convPubTeachCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvPubTeachCaseRelaInfoEN.IdPubClassCase = objRow[convPubTeachCaseRelaInfo.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubTeachCaseRelaInfoEN.PubClassCaseID = objRow[convPubTeachCaseRelaInfo.PubClassCaseID].ToString().Trim(); //案例ID
objvPubTeachCaseRelaInfoEN.PubClassCaseName = objRow[convPubTeachCaseRelaInfo.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubTeachCaseRelaInfoEN.PubClassCaseExecutor = objRow[convPubTeachCaseRelaInfo.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubTeachCaseRelaInfoEN.PubClassCaseTheme = objRow[convPubTeachCaseRelaInfo.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseTheme].ToString().Trim(); //案例主题词
objvPubTeachCaseRelaInfoEN.PubClassCaseBG = objRow[convPubTeachCaseRelaInfo.PubClassCaseBG] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseBG].ToString().Trim(); //案例背景资料
objvPubTeachCaseRelaInfoEN.PubClassCaseTeachDate = objRow[convPubTeachCaseRelaInfo.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPubTeachCaseRelaInfoEN.PubClassCaseDateIn = objRow[convPubTeachCaseRelaInfo.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objvPubTeachCaseRelaInfoEN.IdTeachingPlan = objRow[convPubTeachCaseRelaInfo.IdTeachingPlan].ToString().Trim(); //教案流水号
objvPubTeachCaseRelaInfoEN.Memo = objRow[convPubTeachCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.Memo].ToString().Trim(); //备注
objvPubTeachCaseRelaInfoEN.FileOriginName = objRow[convPubTeachCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvPubTeachCaseRelaInfoEN.IsExistFile = TransNullToBool(objRow[convPubTeachCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvPubTeachCaseRelaInfoEN.ResourceID = objRow[convPubTeachCaseRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvPubTeachCaseRelaInfoEN.FileNewName = objRow[convPubTeachCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvPubTeachCaseRelaInfoEN.FileOldName = objRow[convPubTeachCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvPubTeachCaseRelaInfoDA: GetObjLst)", objException.Message));
}
objvPubTeachCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvPubTeachCaseRelaInfoEN);
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
public List<clsvPubTeachCaseRelaInfoEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvPubTeachCaseRelaInfoDA:GetObjLstByTabName)", objException.Message));
}
List<clsvPubTeachCaseRelaInfoEN> arrObjLst = new List<clsvPubTeachCaseRelaInfoEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubTeachCaseRelaInfoDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN = new clsvPubTeachCaseRelaInfoEN();
try
{
objvPubTeachCaseRelaInfoEN.IdPubTeachCaseRelaInfo = TransNullToInt(objRow[convPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfo].ToString().Trim()); //公开课案例相关信息流水号
objvPubTeachCaseRelaInfoEN.IsVisible = TransNullToBool(objRow[convPubTeachCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvPubTeachCaseRelaInfoEN.SubjectName = objRow[convPubTeachCaseRelaInfo.SubjectName].ToString().Trim(); //课题名称
objvPubTeachCaseRelaInfoEN.TeachingPlanAuthor = objRow[convPubTeachCaseRelaInfo.TeachingPlanAuthor] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingPlanAuthor].ToString().Trim(); //教案撰写人
objvPubTeachCaseRelaInfoEN.TeachingObject = objRow[convPubTeachCaseRelaInfo.TeachingObject] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingObject].ToString().Trim(); //教学目标
objvPubTeachCaseRelaInfoEN.TeachingEmphases = objRow[convPubTeachCaseRelaInfo.TeachingEmphases] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingEmphases].ToString().Trim(); //教学重点
objvPubTeachCaseRelaInfoEN.TeachingDifficulty = objRow[convPubTeachCaseRelaInfo.TeachingDifficulty] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingDifficulty].ToString().Trim(); //教学难点
objvPubTeachCaseRelaInfoEN.TeachingTool = objRow[convPubTeachCaseRelaInfo.TeachingTool] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingTool].ToString().Trim(); //教学用具
objvPubTeachCaseRelaInfoEN.TeachingProcess = objRow[convPubTeachCaseRelaInfo.TeachingProcess] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingProcess].ToString().Trim(); //教学过程
objvPubTeachCaseRelaInfoEN.IdFtpResource = objRow[convPubTeachCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvPubTeachCaseRelaInfoEN.FtpResourceID = objRow[convPubTeachCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvPubTeachCaseRelaInfoEN.FileOriginalName = objRow[convPubTeachCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvPubTeachCaseRelaInfoEN.FileDirName = objRow[convPubTeachCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvPubTeachCaseRelaInfoEN.FileRename = objRow[convPubTeachCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvPubTeachCaseRelaInfoEN.FileUpDate = objRow[convPubTeachCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvPubTeachCaseRelaInfoEN.FileUpTime = objRow[convPubTeachCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvPubTeachCaseRelaInfoEN.IdResource = objRow[convPubTeachCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvPubTeachCaseRelaInfoEN.SaveMode = TransNullToBool(objRow[convPubTeachCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvPubTeachCaseRelaInfoEN.IdResourceType = objRow[convPubTeachCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvPubTeachCaseRelaInfoEN.ResourceTypeID = objRow[convPubTeachCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvPubTeachCaseRelaInfoEN.ResourceTypeName = objRow[convPubTeachCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvPubTeachCaseRelaInfoEN.IdPubCaseType = objRow[convPubTeachCaseRelaInfo.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号
objvPubTeachCaseRelaInfoEN.PubCaseTypeID = objRow[convPubTeachCaseRelaInfo.PubCaseTypeID].ToString().Trim(); //公开课案例类型ID
objvPubTeachCaseRelaInfoEN.PubCaseTypeName = objRow[convPubTeachCaseRelaInfo.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPubTeachCaseRelaInfoEN.IdPubTeachCaseRelaInfoType = objRow[convPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfoType].ToString().Trim(); //公开课案例相关信息类型流水号
objvPubTeachCaseRelaInfoEN.PubTeachCaseRelaInfoTypeID = objRow[convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeID].ToString().Trim(); //公开课案例相关信息类型ID
objvPubTeachCaseRelaInfoEN.PubTeachCaseRelaInfoTypeName = objRow[convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeName].ToString().Trim(); //公开课案例相关信息类型名称
objvPubTeachCaseRelaInfoEN.TeachingPlanType = objRow[convPubTeachCaseRelaInfo.TeachingPlanType] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingPlanType].ToString().Trim(); //教案类型
objvPubTeachCaseRelaInfoEN.BrowseCount = objRow[convPubTeachCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPubTeachCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvPubTeachCaseRelaInfoEN.SimplePlanContent = objRow[convPubTeachCaseRelaInfo.SimplePlanContent] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.SimplePlanContent].ToString().Trim(); //简案内容
objvPubTeachCaseRelaInfoEN.ResourceOwner = objRow[convPubTeachCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvPubTeachCaseRelaInfoEN.ftpFileType = objRow[convPubTeachCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvPubTeachCaseRelaInfoEN.ftpFileSize = objRow[convPubTeachCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvPubTeachCaseRelaInfoEN.ftpResourceOwner = objRow[convPubTeachCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvPubTeachCaseRelaInfoEN.IdDiscipline = objRow[convPubTeachCaseRelaInfo.IdDiscipline].ToString().Trim(); //学科流水号
objvPubTeachCaseRelaInfoEN.DisciplineID = objRow[convPubTeachCaseRelaInfo.DisciplineID].ToString().Trim(); //学科ID
objvPubTeachCaseRelaInfoEN.DisciplineName = objRow[convPubTeachCaseRelaInfo.DisciplineName].ToString().Trim(); //学科名称
objvPubTeachCaseRelaInfoEN.IdStudyLevel = objRow[convPubTeachCaseRelaInfo.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvPubTeachCaseRelaInfoEN.StudyLevelName = objRow[convPubTeachCaseRelaInfo.StudyLevelName].ToString().Trim(); //学段名称
objvPubTeachCaseRelaInfoEN.IdFile = objRow[convPubTeachCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvPubTeachCaseRelaInfoEN.FileName = objRow[convPubTeachCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvPubTeachCaseRelaInfoEN.FileType = objRow[convPubTeachCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvPubTeachCaseRelaInfoEN.SaveDate = objRow[convPubTeachCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvPubTeachCaseRelaInfoEN.FileSize = objRow[convPubTeachCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvPubTeachCaseRelaInfoEN.SaveTime = objRow[convPubTeachCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvPubTeachCaseRelaInfoEN.IdPubClassCase = objRow[convPubTeachCaseRelaInfo.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubTeachCaseRelaInfoEN.PubClassCaseID = objRow[convPubTeachCaseRelaInfo.PubClassCaseID].ToString().Trim(); //案例ID
objvPubTeachCaseRelaInfoEN.PubClassCaseName = objRow[convPubTeachCaseRelaInfo.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubTeachCaseRelaInfoEN.PubClassCaseExecutor = objRow[convPubTeachCaseRelaInfo.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubTeachCaseRelaInfoEN.PubClassCaseTheme = objRow[convPubTeachCaseRelaInfo.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseTheme].ToString().Trim(); //案例主题词
objvPubTeachCaseRelaInfoEN.PubClassCaseBG = objRow[convPubTeachCaseRelaInfo.PubClassCaseBG] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseBG].ToString().Trim(); //案例背景资料
objvPubTeachCaseRelaInfoEN.PubClassCaseTeachDate = objRow[convPubTeachCaseRelaInfo.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPubTeachCaseRelaInfoEN.PubClassCaseDateIn = objRow[convPubTeachCaseRelaInfo.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objvPubTeachCaseRelaInfoEN.IdTeachingPlan = objRow[convPubTeachCaseRelaInfo.IdTeachingPlan].ToString().Trim(); //教案流水号
objvPubTeachCaseRelaInfoEN.Memo = objRow[convPubTeachCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.Memo].ToString().Trim(); //备注
objvPubTeachCaseRelaInfoEN.FileOriginName = objRow[convPubTeachCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvPubTeachCaseRelaInfoEN.IsExistFile = TransNullToBool(objRow[convPubTeachCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvPubTeachCaseRelaInfoEN.ResourceID = objRow[convPubTeachCaseRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvPubTeachCaseRelaInfoEN.FileNewName = objRow[convPubTeachCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvPubTeachCaseRelaInfoEN.FileOldName = objRow[convPubTeachCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvPubTeachCaseRelaInfoDA: GetObjLst)", objException.Message));
}
objvPubTeachCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvPubTeachCaseRelaInfoEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvPubTeachCaseRelaInfo(ref clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubTeachCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vPubTeachCaseRelaInfo where IdPubTeachCaseRelaInfo = " + ""+ objvPubTeachCaseRelaInfoEN.IdPubTeachCaseRelaInfo+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvPubTeachCaseRelaInfoEN.IdPubTeachCaseRelaInfo = TransNullToInt(objDT.Rows[0][convPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfo].ToString().Trim()); //公开课案例相关信息流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvPubTeachCaseRelaInfoEN.IsVisible = TransNullToBool(objDT.Rows[0][convPubTeachCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvPubTeachCaseRelaInfoEN.SubjectName = objDT.Rows[0][convPubTeachCaseRelaInfo.SubjectName].ToString().Trim(); //课题名称(字段类型:varchar,字段长度:200,是否可空:False)
 objvPubTeachCaseRelaInfoEN.TeachingPlanAuthor = objDT.Rows[0][convPubTeachCaseRelaInfo.TeachingPlanAuthor].ToString().Trim(); //教案撰写人(字段类型:varchar,字段长度:50,是否可空:True)
 objvPubTeachCaseRelaInfoEN.TeachingObject = objDT.Rows[0][convPubTeachCaseRelaInfo.TeachingObject].ToString().Trim(); //教学目标(字段类型:varchar,字段长度:5000,是否可空:True)
 objvPubTeachCaseRelaInfoEN.TeachingEmphases = objDT.Rows[0][convPubTeachCaseRelaInfo.TeachingEmphases].ToString().Trim(); //教学重点(字段类型:varchar,字段长度:5000,是否可空:True)
 objvPubTeachCaseRelaInfoEN.TeachingDifficulty = objDT.Rows[0][convPubTeachCaseRelaInfo.TeachingDifficulty].ToString().Trim(); //教学难点(字段类型:varchar,字段长度:5000,是否可空:True)
 objvPubTeachCaseRelaInfoEN.TeachingTool = objDT.Rows[0][convPubTeachCaseRelaInfo.TeachingTool].ToString().Trim(); //教学用具(字段类型:varchar,字段长度:5000,是否可空:True)
 objvPubTeachCaseRelaInfoEN.TeachingProcess = objDT.Rows[0][convPubTeachCaseRelaInfo.TeachingProcess].ToString().Trim(); //教学过程(字段类型:varchar,字段长度:8000,是否可空:True)
 objvPubTeachCaseRelaInfoEN.IdFtpResource = objDT.Rows[0][convPubTeachCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objvPubTeachCaseRelaInfoEN.FtpResourceID = objDT.Rows[0][convPubTeachCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvPubTeachCaseRelaInfoEN.FileOriginalName = objDT.Rows[0][convPubTeachCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名(字段类型:varchar,字段长度:200,是否可空:True)
 objvPubTeachCaseRelaInfoEN.FileDirName = objDT.Rows[0][convPubTeachCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objvPubTeachCaseRelaInfoEN.FileRename = objDT.Rows[0][convPubTeachCaseRelaInfo.FileRename].ToString().Trim(); //文件新名(字段类型:varchar,字段长度:200,是否可空:True)
 objvPubTeachCaseRelaInfoEN.FileUpDate = objDT.Rows[0][convPubTeachCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvPubTeachCaseRelaInfoEN.FileUpTime = objDT.Rows[0][convPubTeachCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvPubTeachCaseRelaInfoEN.IdResource = objDT.Rows[0][convPubTeachCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objvPubTeachCaseRelaInfoEN.SaveMode = TransNullToBool(objDT.Rows[0][convPubTeachCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式(字段类型:bit,字段长度:1,是否可空:True)
 objvPubTeachCaseRelaInfoEN.IdResourceType = objDT.Rows[0][convPubTeachCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvPubTeachCaseRelaInfoEN.ResourceTypeID = objDT.Rows[0][convPubTeachCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvPubTeachCaseRelaInfoEN.ResourceTypeName = objDT.Rows[0][convPubTeachCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvPubTeachCaseRelaInfoEN.IdPubCaseType = objDT.Rows[0][convPubTeachCaseRelaInfo.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvPubTeachCaseRelaInfoEN.PubCaseTypeID = objDT.Rows[0][convPubTeachCaseRelaInfo.PubCaseTypeID].ToString().Trim(); //公开课案例类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvPubTeachCaseRelaInfoEN.PubCaseTypeName = objDT.Rows[0][convPubTeachCaseRelaInfo.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvPubTeachCaseRelaInfoEN.IdPubTeachCaseRelaInfoType = objDT.Rows[0][convPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfoType].ToString().Trim(); //公开课案例相关信息类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvPubTeachCaseRelaInfoEN.PubTeachCaseRelaInfoTypeID = objDT.Rows[0][convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeID].ToString().Trim(); //公开课案例相关信息类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvPubTeachCaseRelaInfoEN.PubTeachCaseRelaInfoTypeName = objDT.Rows[0][convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeName].ToString().Trim(); //公开课案例相关信息类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvPubTeachCaseRelaInfoEN.TeachingPlanType = objDT.Rows[0][convPubTeachCaseRelaInfo.TeachingPlanType].ToString().Trim(); //教案类型(字段类型:char,字段长度:1,是否可空:True)
 objvPubTeachCaseRelaInfoEN.BrowseCount = TransNullToInt(objDT.Rows[0][convPubTeachCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvPubTeachCaseRelaInfoEN.SimplePlanContent = objDT.Rows[0][convPubTeachCaseRelaInfo.SimplePlanContent].ToString().Trim(); //简案内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvPubTeachCaseRelaInfoEN.ResourceOwner = objDT.Rows[0][convPubTeachCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者(字段类型:varchar,字段长度:50,是否可空:False)
 objvPubTeachCaseRelaInfoEN.ftpFileType = objDT.Rows[0][convPubTeachCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvPubTeachCaseRelaInfoEN.ftpFileSize = objDT.Rows[0][convPubTeachCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvPubTeachCaseRelaInfoEN.ftpResourceOwner = objDT.Rows[0][convPubTeachCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者(字段类型:varchar,字段长度:50,是否可空:True)
 objvPubTeachCaseRelaInfoEN.IdDiscipline = objDT.Rows[0][convPubTeachCaseRelaInfo.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvPubTeachCaseRelaInfoEN.DisciplineID = objDT.Rows[0][convPubTeachCaseRelaInfo.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvPubTeachCaseRelaInfoEN.DisciplineName = objDT.Rows[0][convPubTeachCaseRelaInfo.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvPubTeachCaseRelaInfoEN.IdStudyLevel = objDT.Rows[0][convPubTeachCaseRelaInfo.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvPubTeachCaseRelaInfoEN.StudyLevelName = objDT.Rows[0][convPubTeachCaseRelaInfo.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvPubTeachCaseRelaInfoEN.IdFile = objDT.Rows[0][convPubTeachCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号(字段类型:char,字段长度:8,是否可空:True)
 objvPubTeachCaseRelaInfoEN.FileName = objDT.Rows[0][convPubTeachCaseRelaInfo.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvPubTeachCaseRelaInfoEN.FileType = objDT.Rows[0][convPubTeachCaseRelaInfo.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvPubTeachCaseRelaInfoEN.SaveDate = objDT.Rows[0][convPubTeachCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvPubTeachCaseRelaInfoEN.FileSize = objDT.Rows[0][convPubTeachCaseRelaInfo.FileSize].ToString().Trim(); //文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvPubTeachCaseRelaInfoEN.SaveTime = objDT.Rows[0][convPubTeachCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvPubTeachCaseRelaInfoEN.IdPubClassCase = objDT.Rows[0][convPubTeachCaseRelaInfo.IdPubClassCase].ToString().Trim(); //案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvPubTeachCaseRelaInfoEN.PubClassCaseID = objDT.Rows[0][convPubTeachCaseRelaInfo.PubClassCaseID].ToString().Trim(); //案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvPubTeachCaseRelaInfoEN.PubClassCaseName = objDT.Rows[0][convPubTeachCaseRelaInfo.PubClassCaseName].ToString().Trim(); //案例课题名称(字段类型:varchar,字段长度:200,是否可空:False)
 objvPubTeachCaseRelaInfoEN.PubClassCaseExecutor = objDT.Rows[0][convPubTeachCaseRelaInfo.PubClassCaseExecutor].ToString().Trim(); //案例执教者(字段类型:varchar,字段长度:50,是否可空:True)
 objvPubTeachCaseRelaInfoEN.PubClassCaseTheme = objDT.Rows[0][convPubTeachCaseRelaInfo.PubClassCaseTheme].ToString().Trim(); //案例主题词(字段类型:varchar,字段长度:500,是否可空:True)
 objvPubTeachCaseRelaInfoEN.PubClassCaseBG = objDT.Rows[0][convPubTeachCaseRelaInfo.PubClassCaseBG].ToString().Trim(); //案例背景资料(字段类型:text,字段长度:16,是否可空:True)
 objvPubTeachCaseRelaInfoEN.PubClassCaseTeachDate = objDT.Rows[0][convPubTeachCaseRelaInfo.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期(字段类型:char,字段长度:8,是否可空:True)
 objvPubTeachCaseRelaInfoEN.PubClassCaseDateIn = objDT.Rows[0][convPubTeachCaseRelaInfo.PubClassCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvPubTeachCaseRelaInfoEN.IdTeachingPlan = objDT.Rows[0][convPubTeachCaseRelaInfo.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvPubTeachCaseRelaInfoEN.Memo = objDT.Rows[0][convPubTeachCaseRelaInfo.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvPubTeachCaseRelaInfoEN.FileOriginName = objDT.Rows[0][convPubTeachCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名(字段类型:varchar,字段长度:500,是否可空:True)
 objvPubTeachCaseRelaInfoEN.IsExistFile = TransNullToBool(objDT.Rows[0][convPubTeachCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objvPubTeachCaseRelaInfoEN.ResourceID = objDT.Rows[0][convPubTeachCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvPubTeachCaseRelaInfoEN.FileNewName = objDT.Rows[0][convPubTeachCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvPubTeachCaseRelaInfoEN.FileOldName = objDT.Rows[0][convPubTeachCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名(字段类型:varchar,字段长度:530,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvPubTeachCaseRelaInfoDA: GetvPubTeachCaseRelaInfo)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdPubTeachCaseRelaInfo">表关键字</param>
 /// <returns>表对象</returns>
public clsvPubTeachCaseRelaInfoEN GetObjByIdPubTeachCaseRelaInfo(long lngIdPubTeachCaseRelaInfo)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubTeachCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vPubTeachCaseRelaInfo where IdPubTeachCaseRelaInfo = " + ""+ lngIdPubTeachCaseRelaInfo+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN = new clsvPubTeachCaseRelaInfoEN();
try
{
 objvPubTeachCaseRelaInfoEN.IdPubTeachCaseRelaInfo = Int32.Parse(objRow[convPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfo].ToString().Trim()); //公开课案例相关信息流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvPubTeachCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPubTeachCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvPubTeachCaseRelaInfoEN.SubjectName = objRow[convPubTeachCaseRelaInfo.SubjectName].ToString().Trim(); //课题名称(字段类型:varchar,字段长度:200,是否可空:False)
 objvPubTeachCaseRelaInfoEN.TeachingPlanAuthor = objRow[convPubTeachCaseRelaInfo.TeachingPlanAuthor] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingPlanAuthor].ToString().Trim(); //教案撰写人(字段类型:varchar,字段长度:50,是否可空:True)
 objvPubTeachCaseRelaInfoEN.TeachingObject = objRow[convPubTeachCaseRelaInfo.TeachingObject] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingObject].ToString().Trim(); //教学目标(字段类型:varchar,字段长度:5000,是否可空:True)
 objvPubTeachCaseRelaInfoEN.TeachingEmphases = objRow[convPubTeachCaseRelaInfo.TeachingEmphases] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingEmphases].ToString().Trim(); //教学重点(字段类型:varchar,字段长度:5000,是否可空:True)
 objvPubTeachCaseRelaInfoEN.TeachingDifficulty = objRow[convPubTeachCaseRelaInfo.TeachingDifficulty] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingDifficulty].ToString().Trim(); //教学难点(字段类型:varchar,字段长度:5000,是否可空:True)
 objvPubTeachCaseRelaInfoEN.TeachingTool = objRow[convPubTeachCaseRelaInfo.TeachingTool] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingTool].ToString().Trim(); //教学用具(字段类型:varchar,字段长度:5000,是否可空:True)
 objvPubTeachCaseRelaInfoEN.TeachingProcess = objRow[convPubTeachCaseRelaInfo.TeachingProcess] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingProcess].ToString().Trim(); //教学过程(字段类型:varchar,字段长度:8000,是否可空:True)
 objvPubTeachCaseRelaInfoEN.IdFtpResource = objRow[convPubTeachCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objvPubTeachCaseRelaInfoEN.FtpResourceID = objRow[convPubTeachCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvPubTeachCaseRelaInfoEN.FileOriginalName = objRow[convPubTeachCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名(字段类型:varchar,字段长度:200,是否可空:True)
 objvPubTeachCaseRelaInfoEN.FileDirName = objRow[convPubTeachCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objvPubTeachCaseRelaInfoEN.FileRename = objRow[convPubTeachCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileRename].ToString().Trim(); //文件新名(字段类型:varchar,字段长度:200,是否可空:True)
 objvPubTeachCaseRelaInfoEN.FileUpDate = objRow[convPubTeachCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvPubTeachCaseRelaInfoEN.FileUpTime = objRow[convPubTeachCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvPubTeachCaseRelaInfoEN.IdResource = objRow[convPubTeachCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objvPubTeachCaseRelaInfoEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convPubTeachCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式(字段类型:bit,字段长度:1,是否可空:True)
 objvPubTeachCaseRelaInfoEN.IdResourceType = objRow[convPubTeachCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvPubTeachCaseRelaInfoEN.ResourceTypeID = objRow[convPubTeachCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvPubTeachCaseRelaInfoEN.ResourceTypeName = objRow[convPubTeachCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvPubTeachCaseRelaInfoEN.IdPubCaseType = objRow[convPubTeachCaseRelaInfo.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvPubTeachCaseRelaInfoEN.PubCaseTypeID = objRow[convPubTeachCaseRelaInfo.PubCaseTypeID].ToString().Trim(); //公开课案例类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvPubTeachCaseRelaInfoEN.PubCaseTypeName = objRow[convPubTeachCaseRelaInfo.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvPubTeachCaseRelaInfoEN.IdPubTeachCaseRelaInfoType = objRow[convPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfoType].ToString().Trim(); //公开课案例相关信息类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvPubTeachCaseRelaInfoEN.PubTeachCaseRelaInfoTypeID = objRow[convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeID].ToString().Trim(); //公开课案例相关信息类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvPubTeachCaseRelaInfoEN.PubTeachCaseRelaInfoTypeName = objRow[convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeName].ToString().Trim(); //公开课案例相关信息类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvPubTeachCaseRelaInfoEN.TeachingPlanType = objRow[convPubTeachCaseRelaInfo.TeachingPlanType] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingPlanType].ToString().Trim(); //教案类型(字段类型:char,字段长度:1,是否可空:True)
 objvPubTeachCaseRelaInfoEN.BrowseCount = objRow[convPubTeachCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubTeachCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvPubTeachCaseRelaInfoEN.SimplePlanContent = objRow[convPubTeachCaseRelaInfo.SimplePlanContent] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.SimplePlanContent].ToString().Trim(); //简案内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvPubTeachCaseRelaInfoEN.ResourceOwner = objRow[convPubTeachCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者(字段类型:varchar,字段长度:50,是否可空:False)
 objvPubTeachCaseRelaInfoEN.ftpFileType = objRow[convPubTeachCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvPubTeachCaseRelaInfoEN.ftpFileSize = objRow[convPubTeachCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvPubTeachCaseRelaInfoEN.ftpResourceOwner = objRow[convPubTeachCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者(字段类型:varchar,字段长度:50,是否可空:True)
 objvPubTeachCaseRelaInfoEN.IdDiscipline = objRow[convPubTeachCaseRelaInfo.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvPubTeachCaseRelaInfoEN.DisciplineID = objRow[convPubTeachCaseRelaInfo.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvPubTeachCaseRelaInfoEN.DisciplineName = objRow[convPubTeachCaseRelaInfo.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvPubTeachCaseRelaInfoEN.IdStudyLevel = objRow[convPubTeachCaseRelaInfo.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvPubTeachCaseRelaInfoEN.StudyLevelName = objRow[convPubTeachCaseRelaInfo.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvPubTeachCaseRelaInfoEN.IdFile = objRow[convPubTeachCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号(字段类型:char,字段长度:8,是否可空:True)
 objvPubTeachCaseRelaInfoEN.FileName = objRow[convPubTeachCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvPubTeachCaseRelaInfoEN.FileType = objRow[convPubTeachCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvPubTeachCaseRelaInfoEN.SaveDate = objRow[convPubTeachCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvPubTeachCaseRelaInfoEN.FileSize = objRow[convPubTeachCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileSize].ToString().Trim(); //文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvPubTeachCaseRelaInfoEN.SaveTime = objRow[convPubTeachCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvPubTeachCaseRelaInfoEN.IdPubClassCase = objRow[convPubTeachCaseRelaInfo.IdPubClassCase].ToString().Trim(); //案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvPubTeachCaseRelaInfoEN.PubClassCaseID = objRow[convPubTeachCaseRelaInfo.PubClassCaseID].ToString().Trim(); //案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvPubTeachCaseRelaInfoEN.PubClassCaseName = objRow[convPubTeachCaseRelaInfo.PubClassCaseName].ToString().Trim(); //案例课题名称(字段类型:varchar,字段长度:200,是否可空:False)
 objvPubTeachCaseRelaInfoEN.PubClassCaseExecutor = objRow[convPubTeachCaseRelaInfo.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseExecutor].ToString().Trim(); //案例执教者(字段类型:varchar,字段长度:50,是否可空:True)
 objvPubTeachCaseRelaInfoEN.PubClassCaseTheme = objRow[convPubTeachCaseRelaInfo.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseTheme].ToString().Trim(); //案例主题词(字段类型:varchar,字段长度:500,是否可空:True)
 objvPubTeachCaseRelaInfoEN.PubClassCaseBG = objRow[convPubTeachCaseRelaInfo.PubClassCaseBG] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseBG].ToString().Trim(); //案例背景资料(字段类型:text,字段长度:16,是否可空:True)
 objvPubTeachCaseRelaInfoEN.PubClassCaseTeachDate = objRow[convPubTeachCaseRelaInfo.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期(字段类型:char,字段长度:8,是否可空:True)
 objvPubTeachCaseRelaInfoEN.PubClassCaseDateIn = objRow[convPubTeachCaseRelaInfo.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvPubTeachCaseRelaInfoEN.IdTeachingPlan = objRow[convPubTeachCaseRelaInfo.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvPubTeachCaseRelaInfoEN.Memo = objRow[convPubTeachCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvPubTeachCaseRelaInfoEN.FileOriginName = objRow[convPubTeachCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名(字段类型:varchar,字段长度:500,是否可空:True)
 objvPubTeachCaseRelaInfoEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convPubTeachCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objvPubTeachCaseRelaInfoEN.ResourceID = objRow[convPubTeachCaseRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvPubTeachCaseRelaInfoEN.FileNewName = objRow[convPubTeachCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvPubTeachCaseRelaInfoEN.FileOldName = objRow[convPubTeachCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名(字段类型:varchar,字段长度:530,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvPubTeachCaseRelaInfoDA: GetObjByIdPubTeachCaseRelaInfo)", objException.Message));
}
return objvPubTeachCaseRelaInfoEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvPubTeachCaseRelaInfoEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvPubTeachCaseRelaInfoDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubTeachCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vPubTeachCaseRelaInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN = new clsvPubTeachCaseRelaInfoEN()
{
IdPubTeachCaseRelaInfo = TransNullToInt(objRow[convPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfo].ToString().Trim()), //公开课案例相关信息流水号
IsVisible = TransNullToBool(objRow[convPubTeachCaseRelaInfo.IsVisible].ToString().Trim()), //是否显示
SubjectName = objRow[convPubTeachCaseRelaInfo.SubjectName].ToString().Trim(), //课题名称
TeachingPlanAuthor = objRow[convPubTeachCaseRelaInfo.TeachingPlanAuthor] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingPlanAuthor].ToString().Trim(), //教案撰写人
TeachingObject = objRow[convPubTeachCaseRelaInfo.TeachingObject] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingObject].ToString().Trim(), //教学目标
TeachingEmphases = objRow[convPubTeachCaseRelaInfo.TeachingEmphases] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingEmphases].ToString().Trim(), //教学重点
TeachingDifficulty = objRow[convPubTeachCaseRelaInfo.TeachingDifficulty] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingDifficulty].ToString().Trim(), //教学难点
TeachingTool = objRow[convPubTeachCaseRelaInfo.TeachingTool] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingTool].ToString().Trim(), //教学用具
TeachingProcess = objRow[convPubTeachCaseRelaInfo.TeachingProcess] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingProcess].ToString().Trim(), //教学过程
IdFtpResource = objRow[convPubTeachCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.IdFtpResource].ToString().Trim(), //FTP资源流水号
FtpResourceID = objRow[convPubTeachCaseRelaInfo.FtpResourceID].ToString().Trim(), //FTP资源ID
FileOriginalName = objRow[convPubTeachCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileOriginalName].ToString().Trim(), //文件原名
FileDirName = objRow[convPubTeachCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileDirName].ToString().Trim(), //文件目录名
FileRename = objRow[convPubTeachCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileRename].ToString().Trim(), //文件新名
FileUpDate = objRow[convPubTeachCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileUpDate].ToString().Trim(), //创建日期
FileUpTime = objRow[convPubTeachCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileUpTime].ToString().Trim(), //创建时间
IdResource = objRow[convPubTeachCaseRelaInfo.IdResource].ToString().Trim(), //资源流水号
SaveMode = TransNullToBool(objRow[convPubTeachCaseRelaInfo.SaveMode].ToString().Trim()), //文件存放方式
IdResourceType = objRow[convPubTeachCaseRelaInfo.IdResourceType].ToString().Trim(), //资源类型流水号
ResourceTypeID = objRow[convPubTeachCaseRelaInfo.ResourceTypeID].ToString().Trim(), //资源类型ID
ResourceTypeName = objRow[convPubTeachCaseRelaInfo.ResourceTypeName].ToString().Trim(), //资源类型名称
IdPubCaseType = objRow[convPubTeachCaseRelaInfo.IdPubCaseType].ToString().Trim(), //公开课案例类型流水号
PubCaseTypeID = objRow[convPubTeachCaseRelaInfo.PubCaseTypeID].ToString().Trim(), //公开课案例类型ID
PubCaseTypeName = objRow[convPubTeachCaseRelaInfo.PubCaseTypeName].ToString().Trim(), //公开课案例类型名称
IdPubTeachCaseRelaInfoType = objRow[convPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfoType].ToString().Trim(), //公开课案例相关信息类型流水号
PubTeachCaseRelaInfoTypeID = objRow[convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeID].ToString().Trim(), //公开课案例相关信息类型ID
PubTeachCaseRelaInfoTypeName = objRow[convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeName].ToString().Trim(), //公开课案例相关信息类型名称
TeachingPlanType = objRow[convPubTeachCaseRelaInfo.TeachingPlanType] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingPlanType].ToString().Trim(), //教案类型
BrowseCount = objRow[convPubTeachCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPubTeachCaseRelaInfo.BrowseCount].ToString().Trim()), //浏览次数
SimplePlanContent = objRow[convPubTeachCaseRelaInfo.SimplePlanContent] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.SimplePlanContent].ToString().Trim(), //简案内容
ResourceOwner = objRow[convPubTeachCaseRelaInfo.ResourceOwner].ToString().Trim(), //上传者
ftpFileType = objRow[convPubTeachCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.ftpFileType].ToString().Trim(), //ftp文件类型
ftpFileSize = objRow[convPubTeachCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.ftpFileSize].ToString().Trim(), //ftp文件大小
ftpResourceOwner = objRow[convPubTeachCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.ftpResourceOwner].ToString().Trim(), //Ftp资源拥有者
IdDiscipline = objRow[convPubTeachCaseRelaInfo.IdDiscipline].ToString().Trim(), //学科流水号
DisciplineID = objRow[convPubTeachCaseRelaInfo.DisciplineID].ToString().Trim(), //学科ID
DisciplineName = objRow[convPubTeachCaseRelaInfo.DisciplineName].ToString().Trim(), //学科名称
IdStudyLevel = objRow[convPubTeachCaseRelaInfo.IdStudyLevel].ToString().Trim(), //id_StudyLevel
StudyLevelName = objRow[convPubTeachCaseRelaInfo.StudyLevelName].ToString().Trim(), //学段名称
IdFile = objRow[convPubTeachCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.IdFile].ToString().Trim(), //文件流水号
FileName = objRow[convPubTeachCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileName].ToString().Trim(), //文件名称
FileType = objRow[convPubTeachCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileType].ToString().Trim(), //文件类型
SaveDate = objRow[convPubTeachCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.SaveDate].ToString().Trim(), //创建日期
FileSize = objRow[convPubTeachCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileSize].ToString().Trim(), //文件大小
SaveTime = objRow[convPubTeachCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.SaveTime].ToString().Trim(), //创建时间
IdPubClassCase = objRow[convPubTeachCaseRelaInfo.IdPubClassCase].ToString().Trim(), //案例流水号
PubClassCaseID = objRow[convPubTeachCaseRelaInfo.PubClassCaseID].ToString().Trim(), //案例ID
PubClassCaseName = objRow[convPubTeachCaseRelaInfo.PubClassCaseName].ToString().Trim(), //案例课题名称
PubClassCaseExecutor = objRow[convPubTeachCaseRelaInfo.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseExecutor].ToString().Trim(), //案例执教者
PubClassCaseTheme = objRow[convPubTeachCaseRelaInfo.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseTheme].ToString().Trim(), //案例主题词
PubClassCaseBG = objRow[convPubTeachCaseRelaInfo.PubClassCaseBG] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseBG].ToString().Trim(), //案例背景资料
PubClassCaseTeachDate = objRow[convPubTeachCaseRelaInfo.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseTeachDate].ToString().Trim(), //案例授课日期
PubClassCaseDateIn = objRow[convPubTeachCaseRelaInfo.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseDateIn].ToString().Trim(), //案例入库日期
IdTeachingPlan = objRow[convPubTeachCaseRelaInfo.IdTeachingPlan].ToString().Trim(), //教案流水号
Memo = objRow[convPubTeachCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.Memo].ToString().Trim(), //备注
FileOriginName = objRow[convPubTeachCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileOriginName].ToString().Trim(), //原文件名
IsExistFile = TransNullToBool(objRow[convPubTeachCaseRelaInfo.IsExistFile].ToString().Trim()), //是否存在文件
ResourceID = objRow[convPubTeachCaseRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.ResourceID].ToString().Trim(), //资源ID
FileNewName = objRow[convPubTeachCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileNewName].ToString().Trim(), //新文件名
FileOldName = objRow[convPubTeachCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileOldName].ToString().Trim() //旧文件名
};
objvPubTeachCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPubTeachCaseRelaInfoEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvPubTeachCaseRelaInfoDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvPubTeachCaseRelaInfoEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN = new clsvPubTeachCaseRelaInfoEN();
try
{
objvPubTeachCaseRelaInfoEN.IdPubTeachCaseRelaInfo = TransNullToInt(objRow[convPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfo].ToString().Trim()); //公开课案例相关信息流水号
objvPubTeachCaseRelaInfoEN.IsVisible = TransNullToBool(objRow[convPubTeachCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvPubTeachCaseRelaInfoEN.SubjectName = objRow[convPubTeachCaseRelaInfo.SubjectName].ToString().Trim(); //课题名称
objvPubTeachCaseRelaInfoEN.TeachingPlanAuthor = objRow[convPubTeachCaseRelaInfo.TeachingPlanAuthor] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingPlanAuthor].ToString().Trim(); //教案撰写人
objvPubTeachCaseRelaInfoEN.TeachingObject = objRow[convPubTeachCaseRelaInfo.TeachingObject] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingObject].ToString().Trim(); //教学目标
objvPubTeachCaseRelaInfoEN.TeachingEmphases = objRow[convPubTeachCaseRelaInfo.TeachingEmphases] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingEmphases].ToString().Trim(); //教学重点
objvPubTeachCaseRelaInfoEN.TeachingDifficulty = objRow[convPubTeachCaseRelaInfo.TeachingDifficulty] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingDifficulty].ToString().Trim(); //教学难点
objvPubTeachCaseRelaInfoEN.TeachingTool = objRow[convPubTeachCaseRelaInfo.TeachingTool] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingTool].ToString().Trim(); //教学用具
objvPubTeachCaseRelaInfoEN.TeachingProcess = objRow[convPubTeachCaseRelaInfo.TeachingProcess] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingProcess].ToString().Trim(); //教学过程
objvPubTeachCaseRelaInfoEN.IdFtpResource = objRow[convPubTeachCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvPubTeachCaseRelaInfoEN.FtpResourceID = objRow[convPubTeachCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvPubTeachCaseRelaInfoEN.FileOriginalName = objRow[convPubTeachCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvPubTeachCaseRelaInfoEN.FileDirName = objRow[convPubTeachCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvPubTeachCaseRelaInfoEN.FileRename = objRow[convPubTeachCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvPubTeachCaseRelaInfoEN.FileUpDate = objRow[convPubTeachCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvPubTeachCaseRelaInfoEN.FileUpTime = objRow[convPubTeachCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvPubTeachCaseRelaInfoEN.IdResource = objRow[convPubTeachCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvPubTeachCaseRelaInfoEN.SaveMode = TransNullToBool(objRow[convPubTeachCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvPubTeachCaseRelaInfoEN.IdResourceType = objRow[convPubTeachCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvPubTeachCaseRelaInfoEN.ResourceTypeID = objRow[convPubTeachCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvPubTeachCaseRelaInfoEN.ResourceTypeName = objRow[convPubTeachCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvPubTeachCaseRelaInfoEN.IdPubCaseType = objRow[convPubTeachCaseRelaInfo.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号
objvPubTeachCaseRelaInfoEN.PubCaseTypeID = objRow[convPubTeachCaseRelaInfo.PubCaseTypeID].ToString().Trim(); //公开课案例类型ID
objvPubTeachCaseRelaInfoEN.PubCaseTypeName = objRow[convPubTeachCaseRelaInfo.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPubTeachCaseRelaInfoEN.IdPubTeachCaseRelaInfoType = objRow[convPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfoType].ToString().Trim(); //公开课案例相关信息类型流水号
objvPubTeachCaseRelaInfoEN.PubTeachCaseRelaInfoTypeID = objRow[convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeID].ToString().Trim(); //公开课案例相关信息类型ID
objvPubTeachCaseRelaInfoEN.PubTeachCaseRelaInfoTypeName = objRow[convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeName].ToString().Trim(); //公开课案例相关信息类型名称
objvPubTeachCaseRelaInfoEN.TeachingPlanType = objRow[convPubTeachCaseRelaInfo.TeachingPlanType] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingPlanType].ToString().Trim(); //教案类型
objvPubTeachCaseRelaInfoEN.BrowseCount = objRow[convPubTeachCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPubTeachCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvPubTeachCaseRelaInfoEN.SimplePlanContent = objRow[convPubTeachCaseRelaInfo.SimplePlanContent] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.SimplePlanContent].ToString().Trim(); //简案内容
objvPubTeachCaseRelaInfoEN.ResourceOwner = objRow[convPubTeachCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvPubTeachCaseRelaInfoEN.ftpFileType = objRow[convPubTeachCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvPubTeachCaseRelaInfoEN.ftpFileSize = objRow[convPubTeachCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvPubTeachCaseRelaInfoEN.ftpResourceOwner = objRow[convPubTeachCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvPubTeachCaseRelaInfoEN.IdDiscipline = objRow[convPubTeachCaseRelaInfo.IdDiscipline].ToString().Trim(); //学科流水号
objvPubTeachCaseRelaInfoEN.DisciplineID = objRow[convPubTeachCaseRelaInfo.DisciplineID].ToString().Trim(); //学科ID
objvPubTeachCaseRelaInfoEN.DisciplineName = objRow[convPubTeachCaseRelaInfo.DisciplineName].ToString().Trim(); //学科名称
objvPubTeachCaseRelaInfoEN.IdStudyLevel = objRow[convPubTeachCaseRelaInfo.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvPubTeachCaseRelaInfoEN.StudyLevelName = objRow[convPubTeachCaseRelaInfo.StudyLevelName].ToString().Trim(); //学段名称
objvPubTeachCaseRelaInfoEN.IdFile = objRow[convPubTeachCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvPubTeachCaseRelaInfoEN.FileName = objRow[convPubTeachCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvPubTeachCaseRelaInfoEN.FileType = objRow[convPubTeachCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvPubTeachCaseRelaInfoEN.SaveDate = objRow[convPubTeachCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvPubTeachCaseRelaInfoEN.FileSize = objRow[convPubTeachCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvPubTeachCaseRelaInfoEN.SaveTime = objRow[convPubTeachCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvPubTeachCaseRelaInfoEN.IdPubClassCase = objRow[convPubTeachCaseRelaInfo.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubTeachCaseRelaInfoEN.PubClassCaseID = objRow[convPubTeachCaseRelaInfo.PubClassCaseID].ToString().Trim(); //案例ID
objvPubTeachCaseRelaInfoEN.PubClassCaseName = objRow[convPubTeachCaseRelaInfo.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubTeachCaseRelaInfoEN.PubClassCaseExecutor = objRow[convPubTeachCaseRelaInfo.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubTeachCaseRelaInfoEN.PubClassCaseTheme = objRow[convPubTeachCaseRelaInfo.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseTheme].ToString().Trim(); //案例主题词
objvPubTeachCaseRelaInfoEN.PubClassCaseBG = objRow[convPubTeachCaseRelaInfo.PubClassCaseBG] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseBG].ToString().Trim(); //案例背景资料
objvPubTeachCaseRelaInfoEN.PubClassCaseTeachDate = objRow[convPubTeachCaseRelaInfo.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPubTeachCaseRelaInfoEN.PubClassCaseDateIn = objRow[convPubTeachCaseRelaInfo.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objvPubTeachCaseRelaInfoEN.IdTeachingPlan = objRow[convPubTeachCaseRelaInfo.IdTeachingPlan].ToString().Trim(); //教案流水号
objvPubTeachCaseRelaInfoEN.Memo = objRow[convPubTeachCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.Memo].ToString().Trim(); //备注
objvPubTeachCaseRelaInfoEN.FileOriginName = objRow[convPubTeachCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvPubTeachCaseRelaInfoEN.IsExistFile = TransNullToBool(objRow[convPubTeachCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvPubTeachCaseRelaInfoEN.ResourceID = objRow[convPubTeachCaseRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvPubTeachCaseRelaInfoEN.FileNewName = objRow[convPubTeachCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvPubTeachCaseRelaInfoEN.FileOldName = objRow[convPubTeachCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvPubTeachCaseRelaInfoDA: GetObjByDataRowvPubTeachCaseRelaInfo)", objException.Message));
}
objvPubTeachCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPubTeachCaseRelaInfoEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvPubTeachCaseRelaInfoEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN = new clsvPubTeachCaseRelaInfoEN();
try
{
objvPubTeachCaseRelaInfoEN.IdPubTeachCaseRelaInfo = TransNullToInt(objRow[convPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfo].ToString().Trim()); //公开课案例相关信息流水号
objvPubTeachCaseRelaInfoEN.IsVisible = TransNullToBool(objRow[convPubTeachCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvPubTeachCaseRelaInfoEN.SubjectName = objRow[convPubTeachCaseRelaInfo.SubjectName].ToString().Trim(); //课题名称
objvPubTeachCaseRelaInfoEN.TeachingPlanAuthor = objRow[convPubTeachCaseRelaInfo.TeachingPlanAuthor] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingPlanAuthor].ToString().Trim(); //教案撰写人
objvPubTeachCaseRelaInfoEN.TeachingObject = objRow[convPubTeachCaseRelaInfo.TeachingObject] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingObject].ToString().Trim(); //教学目标
objvPubTeachCaseRelaInfoEN.TeachingEmphases = objRow[convPubTeachCaseRelaInfo.TeachingEmphases] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingEmphases].ToString().Trim(); //教学重点
objvPubTeachCaseRelaInfoEN.TeachingDifficulty = objRow[convPubTeachCaseRelaInfo.TeachingDifficulty] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingDifficulty].ToString().Trim(); //教学难点
objvPubTeachCaseRelaInfoEN.TeachingTool = objRow[convPubTeachCaseRelaInfo.TeachingTool] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingTool].ToString().Trim(); //教学用具
objvPubTeachCaseRelaInfoEN.TeachingProcess = objRow[convPubTeachCaseRelaInfo.TeachingProcess] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingProcess].ToString().Trim(); //教学过程
objvPubTeachCaseRelaInfoEN.IdFtpResource = objRow[convPubTeachCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvPubTeachCaseRelaInfoEN.FtpResourceID = objRow[convPubTeachCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvPubTeachCaseRelaInfoEN.FileOriginalName = objRow[convPubTeachCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvPubTeachCaseRelaInfoEN.FileDirName = objRow[convPubTeachCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvPubTeachCaseRelaInfoEN.FileRename = objRow[convPubTeachCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvPubTeachCaseRelaInfoEN.FileUpDate = objRow[convPubTeachCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvPubTeachCaseRelaInfoEN.FileUpTime = objRow[convPubTeachCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvPubTeachCaseRelaInfoEN.IdResource = objRow[convPubTeachCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvPubTeachCaseRelaInfoEN.SaveMode = TransNullToBool(objRow[convPubTeachCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvPubTeachCaseRelaInfoEN.IdResourceType = objRow[convPubTeachCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvPubTeachCaseRelaInfoEN.ResourceTypeID = objRow[convPubTeachCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvPubTeachCaseRelaInfoEN.ResourceTypeName = objRow[convPubTeachCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvPubTeachCaseRelaInfoEN.IdPubCaseType = objRow[convPubTeachCaseRelaInfo.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号
objvPubTeachCaseRelaInfoEN.PubCaseTypeID = objRow[convPubTeachCaseRelaInfo.PubCaseTypeID].ToString().Trim(); //公开课案例类型ID
objvPubTeachCaseRelaInfoEN.PubCaseTypeName = objRow[convPubTeachCaseRelaInfo.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPubTeachCaseRelaInfoEN.IdPubTeachCaseRelaInfoType = objRow[convPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfoType].ToString().Trim(); //公开课案例相关信息类型流水号
objvPubTeachCaseRelaInfoEN.PubTeachCaseRelaInfoTypeID = objRow[convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeID].ToString().Trim(); //公开课案例相关信息类型ID
objvPubTeachCaseRelaInfoEN.PubTeachCaseRelaInfoTypeName = objRow[convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeName].ToString().Trim(); //公开课案例相关信息类型名称
objvPubTeachCaseRelaInfoEN.TeachingPlanType = objRow[convPubTeachCaseRelaInfo.TeachingPlanType] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingPlanType].ToString().Trim(); //教案类型
objvPubTeachCaseRelaInfoEN.BrowseCount = objRow[convPubTeachCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPubTeachCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvPubTeachCaseRelaInfoEN.SimplePlanContent = objRow[convPubTeachCaseRelaInfo.SimplePlanContent] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.SimplePlanContent].ToString().Trim(); //简案内容
objvPubTeachCaseRelaInfoEN.ResourceOwner = objRow[convPubTeachCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvPubTeachCaseRelaInfoEN.ftpFileType = objRow[convPubTeachCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvPubTeachCaseRelaInfoEN.ftpFileSize = objRow[convPubTeachCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvPubTeachCaseRelaInfoEN.ftpResourceOwner = objRow[convPubTeachCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvPubTeachCaseRelaInfoEN.IdDiscipline = objRow[convPubTeachCaseRelaInfo.IdDiscipline].ToString().Trim(); //学科流水号
objvPubTeachCaseRelaInfoEN.DisciplineID = objRow[convPubTeachCaseRelaInfo.DisciplineID].ToString().Trim(); //学科ID
objvPubTeachCaseRelaInfoEN.DisciplineName = objRow[convPubTeachCaseRelaInfo.DisciplineName].ToString().Trim(); //学科名称
objvPubTeachCaseRelaInfoEN.IdStudyLevel = objRow[convPubTeachCaseRelaInfo.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvPubTeachCaseRelaInfoEN.StudyLevelName = objRow[convPubTeachCaseRelaInfo.StudyLevelName].ToString().Trim(); //学段名称
objvPubTeachCaseRelaInfoEN.IdFile = objRow[convPubTeachCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvPubTeachCaseRelaInfoEN.FileName = objRow[convPubTeachCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvPubTeachCaseRelaInfoEN.FileType = objRow[convPubTeachCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvPubTeachCaseRelaInfoEN.SaveDate = objRow[convPubTeachCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvPubTeachCaseRelaInfoEN.FileSize = objRow[convPubTeachCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvPubTeachCaseRelaInfoEN.SaveTime = objRow[convPubTeachCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvPubTeachCaseRelaInfoEN.IdPubClassCase = objRow[convPubTeachCaseRelaInfo.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubTeachCaseRelaInfoEN.PubClassCaseID = objRow[convPubTeachCaseRelaInfo.PubClassCaseID].ToString().Trim(); //案例ID
objvPubTeachCaseRelaInfoEN.PubClassCaseName = objRow[convPubTeachCaseRelaInfo.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubTeachCaseRelaInfoEN.PubClassCaseExecutor = objRow[convPubTeachCaseRelaInfo.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubTeachCaseRelaInfoEN.PubClassCaseTheme = objRow[convPubTeachCaseRelaInfo.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseTheme].ToString().Trim(); //案例主题词
objvPubTeachCaseRelaInfoEN.PubClassCaseBG = objRow[convPubTeachCaseRelaInfo.PubClassCaseBG] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseBG].ToString().Trim(); //案例背景资料
objvPubTeachCaseRelaInfoEN.PubClassCaseTeachDate = objRow[convPubTeachCaseRelaInfo.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPubTeachCaseRelaInfoEN.PubClassCaseDateIn = objRow[convPubTeachCaseRelaInfo.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objvPubTeachCaseRelaInfoEN.IdTeachingPlan = objRow[convPubTeachCaseRelaInfo.IdTeachingPlan].ToString().Trim(); //教案流水号
objvPubTeachCaseRelaInfoEN.Memo = objRow[convPubTeachCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.Memo].ToString().Trim(); //备注
objvPubTeachCaseRelaInfoEN.FileOriginName = objRow[convPubTeachCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvPubTeachCaseRelaInfoEN.IsExistFile = TransNullToBool(objRow[convPubTeachCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvPubTeachCaseRelaInfoEN.ResourceID = objRow[convPubTeachCaseRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvPubTeachCaseRelaInfoEN.FileNewName = objRow[convPubTeachCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvPubTeachCaseRelaInfoEN.FileOldName = objRow[convPubTeachCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvPubTeachCaseRelaInfoDA: GetObjByDataRow)", objException.Message));
}
objvPubTeachCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPubTeachCaseRelaInfoEN;
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
objSQL = clsvPubTeachCaseRelaInfoDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvPubTeachCaseRelaInfoEN._CurrTabName, convPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfo, 8, "");
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
objSQL = clsvPubTeachCaseRelaInfoDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvPubTeachCaseRelaInfoEN._CurrTabName, convPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfo, 8, strPrefix);
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
 objSQL = clsvPubTeachCaseRelaInfoDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdPubTeachCaseRelaInfo from vPubTeachCaseRelaInfo where " + strCondition;
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
 objSQL = clsvPubTeachCaseRelaInfoDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdPubTeachCaseRelaInfo from vPubTeachCaseRelaInfo where " + strCondition;
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
 /// <param name = "lngIdPubTeachCaseRelaInfo">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngIdPubTeachCaseRelaInfo)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubTeachCaseRelaInfoDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vPubTeachCaseRelaInfo", "IdPubTeachCaseRelaInfo = " + ""+ lngIdPubTeachCaseRelaInfo+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvPubTeachCaseRelaInfoDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubTeachCaseRelaInfoDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vPubTeachCaseRelaInfo", strCondition))
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
objSQL = clsvPubTeachCaseRelaInfoDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vPubTeachCaseRelaInfo");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoENS">源对象</param>
 /// <param name = "objvPubTeachCaseRelaInfoENT">目标对象</param>
public void CopyTo(clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoENS, clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoENT)
{
objvPubTeachCaseRelaInfoENT.IdPubTeachCaseRelaInfo = objvPubTeachCaseRelaInfoENS.IdPubTeachCaseRelaInfo; //公开课案例相关信息流水号
objvPubTeachCaseRelaInfoENT.IsVisible = objvPubTeachCaseRelaInfoENS.IsVisible; //是否显示
objvPubTeachCaseRelaInfoENT.SubjectName = objvPubTeachCaseRelaInfoENS.SubjectName; //课题名称
objvPubTeachCaseRelaInfoENT.TeachingPlanAuthor = objvPubTeachCaseRelaInfoENS.TeachingPlanAuthor; //教案撰写人
objvPubTeachCaseRelaInfoENT.TeachingObject = objvPubTeachCaseRelaInfoENS.TeachingObject; //教学目标
objvPubTeachCaseRelaInfoENT.TeachingEmphases = objvPubTeachCaseRelaInfoENS.TeachingEmphases; //教学重点
objvPubTeachCaseRelaInfoENT.TeachingDifficulty = objvPubTeachCaseRelaInfoENS.TeachingDifficulty; //教学难点
objvPubTeachCaseRelaInfoENT.TeachingTool = objvPubTeachCaseRelaInfoENS.TeachingTool; //教学用具
objvPubTeachCaseRelaInfoENT.TeachingProcess = objvPubTeachCaseRelaInfoENS.TeachingProcess; //教学过程
objvPubTeachCaseRelaInfoENT.IdFtpResource = objvPubTeachCaseRelaInfoENS.IdFtpResource; //FTP资源流水号
objvPubTeachCaseRelaInfoENT.FtpResourceID = objvPubTeachCaseRelaInfoENS.FtpResourceID; //FTP资源ID
objvPubTeachCaseRelaInfoENT.FileOriginalName = objvPubTeachCaseRelaInfoENS.FileOriginalName; //文件原名
objvPubTeachCaseRelaInfoENT.FileDirName = objvPubTeachCaseRelaInfoENS.FileDirName; //文件目录名
objvPubTeachCaseRelaInfoENT.FileRename = objvPubTeachCaseRelaInfoENS.FileRename; //文件新名
objvPubTeachCaseRelaInfoENT.FileUpDate = objvPubTeachCaseRelaInfoENS.FileUpDate; //创建日期
objvPubTeachCaseRelaInfoENT.FileUpTime = objvPubTeachCaseRelaInfoENS.FileUpTime; //创建时间
objvPubTeachCaseRelaInfoENT.IdResource = objvPubTeachCaseRelaInfoENS.IdResource; //资源流水号
objvPubTeachCaseRelaInfoENT.SaveMode = objvPubTeachCaseRelaInfoENS.SaveMode; //文件存放方式
objvPubTeachCaseRelaInfoENT.IdResourceType = objvPubTeachCaseRelaInfoENS.IdResourceType; //资源类型流水号
objvPubTeachCaseRelaInfoENT.ResourceTypeID = objvPubTeachCaseRelaInfoENS.ResourceTypeID; //资源类型ID
objvPubTeachCaseRelaInfoENT.ResourceTypeName = objvPubTeachCaseRelaInfoENS.ResourceTypeName; //资源类型名称
objvPubTeachCaseRelaInfoENT.IdPubCaseType = objvPubTeachCaseRelaInfoENS.IdPubCaseType; //公开课案例类型流水号
objvPubTeachCaseRelaInfoENT.PubCaseTypeID = objvPubTeachCaseRelaInfoENS.PubCaseTypeID; //公开课案例类型ID
objvPubTeachCaseRelaInfoENT.PubCaseTypeName = objvPubTeachCaseRelaInfoENS.PubCaseTypeName; //公开课案例类型名称
objvPubTeachCaseRelaInfoENT.IdPubTeachCaseRelaInfoType = objvPubTeachCaseRelaInfoENS.IdPubTeachCaseRelaInfoType; //公开课案例相关信息类型流水号
objvPubTeachCaseRelaInfoENT.PubTeachCaseRelaInfoTypeID = objvPubTeachCaseRelaInfoENS.PubTeachCaseRelaInfoTypeID; //公开课案例相关信息类型ID
objvPubTeachCaseRelaInfoENT.PubTeachCaseRelaInfoTypeName = objvPubTeachCaseRelaInfoENS.PubTeachCaseRelaInfoTypeName; //公开课案例相关信息类型名称
objvPubTeachCaseRelaInfoENT.TeachingPlanType = objvPubTeachCaseRelaInfoENS.TeachingPlanType; //教案类型
objvPubTeachCaseRelaInfoENT.BrowseCount = objvPubTeachCaseRelaInfoENS.BrowseCount; //浏览次数
objvPubTeachCaseRelaInfoENT.SimplePlanContent = objvPubTeachCaseRelaInfoENS.SimplePlanContent; //简案内容
objvPubTeachCaseRelaInfoENT.ResourceOwner = objvPubTeachCaseRelaInfoENS.ResourceOwner; //上传者
objvPubTeachCaseRelaInfoENT.ftpFileType = objvPubTeachCaseRelaInfoENS.ftpFileType; //ftp文件类型
objvPubTeachCaseRelaInfoENT.ftpFileSize = objvPubTeachCaseRelaInfoENS.ftpFileSize; //ftp文件大小
objvPubTeachCaseRelaInfoENT.ftpResourceOwner = objvPubTeachCaseRelaInfoENS.ftpResourceOwner; //Ftp资源拥有者
objvPubTeachCaseRelaInfoENT.IdDiscipline = objvPubTeachCaseRelaInfoENS.IdDiscipline; //学科流水号
objvPubTeachCaseRelaInfoENT.DisciplineID = objvPubTeachCaseRelaInfoENS.DisciplineID; //学科ID
objvPubTeachCaseRelaInfoENT.DisciplineName = objvPubTeachCaseRelaInfoENS.DisciplineName; //学科名称
objvPubTeachCaseRelaInfoENT.IdStudyLevel = objvPubTeachCaseRelaInfoENS.IdStudyLevel; //id_StudyLevel
objvPubTeachCaseRelaInfoENT.StudyLevelName = objvPubTeachCaseRelaInfoENS.StudyLevelName; //学段名称
objvPubTeachCaseRelaInfoENT.IdFile = objvPubTeachCaseRelaInfoENS.IdFile; //文件流水号
objvPubTeachCaseRelaInfoENT.FileName = objvPubTeachCaseRelaInfoENS.FileName; //文件名称
objvPubTeachCaseRelaInfoENT.FileType = objvPubTeachCaseRelaInfoENS.FileType; //文件类型
objvPubTeachCaseRelaInfoENT.SaveDate = objvPubTeachCaseRelaInfoENS.SaveDate; //创建日期
objvPubTeachCaseRelaInfoENT.FileSize = objvPubTeachCaseRelaInfoENS.FileSize; //文件大小
objvPubTeachCaseRelaInfoENT.SaveTime = objvPubTeachCaseRelaInfoENS.SaveTime; //创建时间
objvPubTeachCaseRelaInfoENT.IdPubClassCase = objvPubTeachCaseRelaInfoENS.IdPubClassCase; //案例流水号
objvPubTeachCaseRelaInfoENT.PubClassCaseID = objvPubTeachCaseRelaInfoENS.PubClassCaseID; //案例ID
objvPubTeachCaseRelaInfoENT.PubClassCaseName = objvPubTeachCaseRelaInfoENS.PubClassCaseName; //案例课题名称
objvPubTeachCaseRelaInfoENT.PubClassCaseExecutor = objvPubTeachCaseRelaInfoENS.PubClassCaseExecutor; //案例执教者
objvPubTeachCaseRelaInfoENT.PubClassCaseTheme = objvPubTeachCaseRelaInfoENS.PubClassCaseTheme; //案例主题词
objvPubTeachCaseRelaInfoENT.PubClassCaseBG = objvPubTeachCaseRelaInfoENS.PubClassCaseBG; //案例背景资料
objvPubTeachCaseRelaInfoENT.PubClassCaseTeachDate = objvPubTeachCaseRelaInfoENS.PubClassCaseTeachDate; //案例授课日期
objvPubTeachCaseRelaInfoENT.PubClassCaseDateIn = objvPubTeachCaseRelaInfoENS.PubClassCaseDateIn; //案例入库日期
objvPubTeachCaseRelaInfoENT.IdTeachingPlan = objvPubTeachCaseRelaInfoENS.IdTeachingPlan; //教案流水号
objvPubTeachCaseRelaInfoENT.Memo = objvPubTeachCaseRelaInfoENS.Memo; //备注
objvPubTeachCaseRelaInfoENT.FileOriginName = objvPubTeachCaseRelaInfoENS.FileOriginName; //原文件名
objvPubTeachCaseRelaInfoENT.IsExistFile = objvPubTeachCaseRelaInfoENS.IsExistFile; //是否存在文件
objvPubTeachCaseRelaInfoENT.ResourceID = objvPubTeachCaseRelaInfoENS.ResourceID; //资源ID
objvPubTeachCaseRelaInfoENT.FileNewName = objvPubTeachCaseRelaInfoENS.FileNewName; //新文件名
objvPubTeachCaseRelaInfoENT.FileOldName = objvPubTeachCaseRelaInfoENS.FileOldName; //旧文件名
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvPubTeachCaseRelaInfoEN.SubjectName, 200, convPubTeachCaseRelaInfo.SubjectName);
clsCheckSql.CheckFieldLen(objvPubTeachCaseRelaInfoEN.TeachingPlanAuthor, 50, convPubTeachCaseRelaInfo.TeachingPlanAuthor);
clsCheckSql.CheckFieldLen(objvPubTeachCaseRelaInfoEN.TeachingObject, 5000, convPubTeachCaseRelaInfo.TeachingObject);
clsCheckSql.CheckFieldLen(objvPubTeachCaseRelaInfoEN.TeachingEmphases, 5000, convPubTeachCaseRelaInfo.TeachingEmphases);
clsCheckSql.CheckFieldLen(objvPubTeachCaseRelaInfoEN.TeachingDifficulty, 5000, convPubTeachCaseRelaInfo.TeachingDifficulty);
clsCheckSql.CheckFieldLen(objvPubTeachCaseRelaInfoEN.TeachingTool, 5000, convPubTeachCaseRelaInfo.TeachingTool);
clsCheckSql.CheckFieldLen(objvPubTeachCaseRelaInfoEN.TeachingProcess, 8000, convPubTeachCaseRelaInfo.TeachingProcess);
clsCheckSql.CheckFieldLen(objvPubTeachCaseRelaInfoEN.IdFtpResource, 8, convPubTeachCaseRelaInfo.IdFtpResource);
clsCheckSql.CheckFieldLen(objvPubTeachCaseRelaInfoEN.FtpResourceID, 8, convPubTeachCaseRelaInfo.FtpResourceID);
clsCheckSql.CheckFieldLen(objvPubTeachCaseRelaInfoEN.FileOriginalName, 200, convPubTeachCaseRelaInfo.FileOriginalName);
clsCheckSql.CheckFieldLen(objvPubTeachCaseRelaInfoEN.FileDirName, 200, convPubTeachCaseRelaInfo.FileDirName);
clsCheckSql.CheckFieldLen(objvPubTeachCaseRelaInfoEN.FileRename, 200, convPubTeachCaseRelaInfo.FileRename);
clsCheckSql.CheckFieldLen(objvPubTeachCaseRelaInfoEN.FileUpDate, 8, convPubTeachCaseRelaInfo.FileUpDate);
clsCheckSql.CheckFieldLen(objvPubTeachCaseRelaInfoEN.FileUpTime, 6, convPubTeachCaseRelaInfo.FileUpTime);
clsCheckSql.CheckFieldLen(objvPubTeachCaseRelaInfoEN.IdResource, 8, convPubTeachCaseRelaInfo.IdResource);
clsCheckSql.CheckFieldLen(objvPubTeachCaseRelaInfoEN.IdResourceType, 4, convPubTeachCaseRelaInfo.IdResourceType);
clsCheckSql.CheckFieldLen(objvPubTeachCaseRelaInfoEN.ResourceTypeID, 4, convPubTeachCaseRelaInfo.ResourceTypeID);
clsCheckSql.CheckFieldLen(objvPubTeachCaseRelaInfoEN.ResourceTypeName, 50, convPubTeachCaseRelaInfo.ResourceTypeName);
clsCheckSql.CheckFieldLen(objvPubTeachCaseRelaInfoEN.IdPubCaseType, 4, convPubTeachCaseRelaInfo.IdPubCaseType);
clsCheckSql.CheckFieldLen(objvPubTeachCaseRelaInfoEN.PubCaseTypeID, 4, convPubTeachCaseRelaInfo.PubCaseTypeID);
clsCheckSql.CheckFieldLen(objvPubTeachCaseRelaInfoEN.PubCaseTypeName, 50, convPubTeachCaseRelaInfo.PubCaseTypeName);
clsCheckSql.CheckFieldLen(objvPubTeachCaseRelaInfoEN.IdPubTeachCaseRelaInfoType, 4, convPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfoType);
clsCheckSql.CheckFieldLen(objvPubTeachCaseRelaInfoEN.PubTeachCaseRelaInfoTypeID, 4, convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeID);
clsCheckSql.CheckFieldLen(objvPubTeachCaseRelaInfoEN.PubTeachCaseRelaInfoTypeName, 50, convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeName);
clsCheckSql.CheckFieldLen(objvPubTeachCaseRelaInfoEN.TeachingPlanType, 1, convPubTeachCaseRelaInfo.TeachingPlanType);
clsCheckSql.CheckFieldLen(objvPubTeachCaseRelaInfoEN.ResourceOwner, 50, convPubTeachCaseRelaInfo.ResourceOwner);
clsCheckSql.CheckFieldLen(objvPubTeachCaseRelaInfoEN.ftpFileType, 30, convPubTeachCaseRelaInfo.ftpFileType);
clsCheckSql.CheckFieldLen(objvPubTeachCaseRelaInfoEN.ftpFileSize, 50, convPubTeachCaseRelaInfo.ftpFileSize);
clsCheckSql.CheckFieldLen(objvPubTeachCaseRelaInfoEN.ftpResourceOwner, 50, convPubTeachCaseRelaInfo.ftpResourceOwner);
clsCheckSql.CheckFieldLen(objvPubTeachCaseRelaInfoEN.IdDiscipline, 4, convPubTeachCaseRelaInfo.IdDiscipline);
clsCheckSql.CheckFieldLen(objvPubTeachCaseRelaInfoEN.DisciplineID, 4, convPubTeachCaseRelaInfo.DisciplineID);
clsCheckSql.CheckFieldLen(objvPubTeachCaseRelaInfoEN.DisciplineName, 50, convPubTeachCaseRelaInfo.DisciplineName);
clsCheckSql.CheckFieldLen(objvPubTeachCaseRelaInfoEN.IdStudyLevel, 4, convPubTeachCaseRelaInfo.IdStudyLevel);
clsCheckSql.CheckFieldLen(objvPubTeachCaseRelaInfoEN.StudyLevelName, 50, convPubTeachCaseRelaInfo.StudyLevelName);
clsCheckSql.CheckFieldLen(objvPubTeachCaseRelaInfoEN.IdFile, 8, convPubTeachCaseRelaInfo.IdFile);
clsCheckSql.CheckFieldLen(objvPubTeachCaseRelaInfoEN.FileName, 500, convPubTeachCaseRelaInfo.FileName);
clsCheckSql.CheckFieldLen(objvPubTeachCaseRelaInfoEN.FileType, 30, convPubTeachCaseRelaInfo.FileType);
clsCheckSql.CheckFieldLen(objvPubTeachCaseRelaInfoEN.SaveDate, 8, convPubTeachCaseRelaInfo.SaveDate);
clsCheckSql.CheckFieldLen(objvPubTeachCaseRelaInfoEN.FileSize, 50, convPubTeachCaseRelaInfo.FileSize);
clsCheckSql.CheckFieldLen(objvPubTeachCaseRelaInfoEN.SaveTime, 6, convPubTeachCaseRelaInfo.SaveTime);
clsCheckSql.CheckFieldLen(objvPubTeachCaseRelaInfoEN.IdPubClassCase, 8, convPubTeachCaseRelaInfo.IdPubClassCase);
clsCheckSql.CheckFieldLen(objvPubTeachCaseRelaInfoEN.PubClassCaseID, 8, convPubTeachCaseRelaInfo.PubClassCaseID);
clsCheckSql.CheckFieldLen(objvPubTeachCaseRelaInfoEN.PubClassCaseName, 200, convPubTeachCaseRelaInfo.PubClassCaseName);
clsCheckSql.CheckFieldLen(objvPubTeachCaseRelaInfoEN.PubClassCaseExecutor, 50, convPubTeachCaseRelaInfo.PubClassCaseExecutor);
clsCheckSql.CheckFieldLen(objvPubTeachCaseRelaInfoEN.PubClassCaseTheme, 500, convPubTeachCaseRelaInfo.PubClassCaseTheme);
clsCheckSql.CheckFieldLen(objvPubTeachCaseRelaInfoEN.PubClassCaseTeachDate, 8, convPubTeachCaseRelaInfo.PubClassCaseTeachDate);
clsCheckSql.CheckFieldLen(objvPubTeachCaseRelaInfoEN.PubClassCaseDateIn, 8, convPubTeachCaseRelaInfo.PubClassCaseDateIn);
clsCheckSql.CheckFieldLen(objvPubTeachCaseRelaInfoEN.IdTeachingPlan, 8, convPubTeachCaseRelaInfo.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objvPubTeachCaseRelaInfoEN.Memo, 1000, convPubTeachCaseRelaInfo.Memo);
clsCheckSql.CheckFieldLen(objvPubTeachCaseRelaInfoEN.FileOriginName, 500, convPubTeachCaseRelaInfo.FileOriginName);
clsCheckSql.CheckFieldLen(objvPubTeachCaseRelaInfoEN.ResourceID, 8, convPubTeachCaseRelaInfo.ResourceID);
clsCheckSql.CheckFieldLen(objvPubTeachCaseRelaInfoEN.FileNewName, 530, convPubTeachCaseRelaInfo.FileNewName);
clsCheckSql.CheckFieldLen(objvPubTeachCaseRelaInfoEN.FileOldName, 530, convPubTeachCaseRelaInfo.FileOldName);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvPubTeachCaseRelaInfoEN.SubjectName, convPubTeachCaseRelaInfo.SubjectName);
clsCheckSql.CheckSqlInjection4Field(objvPubTeachCaseRelaInfoEN.TeachingPlanAuthor, convPubTeachCaseRelaInfo.TeachingPlanAuthor);
clsCheckSql.CheckSqlInjection4Field(objvPubTeachCaseRelaInfoEN.TeachingObject, convPubTeachCaseRelaInfo.TeachingObject);
clsCheckSql.CheckSqlInjection4Field(objvPubTeachCaseRelaInfoEN.TeachingEmphases, convPubTeachCaseRelaInfo.TeachingEmphases);
clsCheckSql.CheckSqlInjection4Field(objvPubTeachCaseRelaInfoEN.TeachingDifficulty, convPubTeachCaseRelaInfo.TeachingDifficulty);
clsCheckSql.CheckSqlInjection4Field(objvPubTeachCaseRelaInfoEN.TeachingTool, convPubTeachCaseRelaInfo.TeachingTool);
clsCheckSql.CheckSqlInjection4Field(objvPubTeachCaseRelaInfoEN.TeachingProcess, convPubTeachCaseRelaInfo.TeachingProcess);
clsCheckSql.CheckSqlInjection4Field(objvPubTeachCaseRelaInfoEN.IdFtpResource, convPubTeachCaseRelaInfo.IdFtpResource);
clsCheckSql.CheckSqlInjection4Field(objvPubTeachCaseRelaInfoEN.FtpResourceID, convPubTeachCaseRelaInfo.FtpResourceID);
clsCheckSql.CheckSqlInjection4Field(objvPubTeachCaseRelaInfoEN.FileOriginalName, convPubTeachCaseRelaInfo.FileOriginalName);
clsCheckSql.CheckSqlInjection4Field(objvPubTeachCaseRelaInfoEN.FileDirName, convPubTeachCaseRelaInfo.FileDirName);
clsCheckSql.CheckSqlInjection4Field(objvPubTeachCaseRelaInfoEN.FileRename, convPubTeachCaseRelaInfo.FileRename);
clsCheckSql.CheckSqlInjection4Field(objvPubTeachCaseRelaInfoEN.FileUpDate, convPubTeachCaseRelaInfo.FileUpDate);
clsCheckSql.CheckSqlInjection4Field(objvPubTeachCaseRelaInfoEN.FileUpTime, convPubTeachCaseRelaInfo.FileUpTime);
clsCheckSql.CheckSqlInjection4Field(objvPubTeachCaseRelaInfoEN.IdResource, convPubTeachCaseRelaInfo.IdResource);
clsCheckSql.CheckSqlInjection4Field(objvPubTeachCaseRelaInfoEN.IdResourceType, convPubTeachCaseRelaInfo.IdResourceType);
clsCheckSql.CheckSqlInjection4Field(objvPubTeachCaseRelaInfoEN.ResourceTypeID, convPubTeachCaseRelaInfo.ResourceTypeID);
clsCheckSql.CheckSqlInjection4Field(objvPubTeachCaseRelaInfoEN.ResourceTypeName, convPubTeachCaseRelaInfo.ResourceTypeName);
clsCheckSql.CheckSqlInjection4Field(objvPubTeachCaseRelaInfoEN.IdPubCaseType, convPubTeachCaseRelaInfo.IdPubCaseType);
clsCheckSql.CheckSqlInjection4Field(objvPubTeachCaseRelaInfoEN.PubCaseTypeID, convPubTeachCaseRelaInfo.PubCaseTypeID);
clsCheckSql.CheckSqlInjection4Field(objvPubTeachCaseRelaInfoEN.PubCaseTypeName, convPubTeachCaseRelaInfo.PubCaseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvPubTeachCaseRelaInfoEN.IdPubTeachCaseRelaInfoType, convPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfoType);
clsCheckSql.CheckSqlInjection4Field(objvPubTeachCaseRelaInfoEN.PubTeachCaseRelaInfoTypeID, convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeID);
clsCheckSql.CheckSqlInjection4Field(objvPubTeachCaseRelaInfoEN.PubTeachCaseRelaInfoTypeName, convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeName);
clsCheckSql.CheckSqlInjection4Field(objvPubTeachCaseRelaInfoEN.TeachingPlanType, convPubTeachCaseRelaInfo.TeachingPlanType);
clsCheckSql.CheckSqlInjection4Field(objvPubTeachCaseRelaInfoEN.ResourceOwner, convPubTeachCaseRelaInfo.ResourceOwner);
clsCheckSql.CheckSqlInjection4Field(objvPubTeachCaseRelaInfoEN.ftpFileType, convPubTeachCaseRelaInfo.ftpFileType);
clsCheckSql.CheckSqlInjection4Field(objvPubTeachCaseRelaInfoEN.ftpFileSize, convPubTeachCaseRelaInfo.ftpFileSize);
clsCheckSql.CheckSqlInjection4Field(objvPubTeachCaseRelaInfoEN.ftpResourceOwner, convPubTeachCaseRelaInfo.ftpResourceOwner);
clsCheckSql.CheckSqlInjection4Field(objvPubTeachCaseRelaInfoEN.IdDiscipline, convPubTeachCaseRelaInfo.IdDiscipline);
clsCheckSql.CheckSqlInjection4Field(objvPubTeachCaseRelaInfoEN.DisciplineID, convPubTeachCaseRelaInfo.DisciplineID);
clsCheckSql.CheckSqlInjection4Field(objvPubTeachCaseRelaInfoEN.DisciplineName, convPubTeachCaseRelaInfo.DisciplineName);
clsCheckSql.CheckSqlInjection4Field(objvPubTeachCaseRelaInfoEN.IdStudyLevel, convPubTeachCaseRelaInfo.IdStudyLevel);
clsCheckSql.CheckSqlInjection4Field(objvPubTeachCaseRelaInfoEN.StudyLevelName, convPubTeachCaseRelaInfo.StudyLevelName);
clsCheckSql.CheckSqlInjection4Field(objvPubTeachCaseRelaInfoEN.IdFile, convPubTeachCaseRelaInfo.IdFile);
clsCheckSql.CheckSqlInjection4Field(objvPubTeachCaseRelaInfoEN.FileName, convPubTeachCaseRelaInfo.FileName);
clsCheckSql.CheckSqlInjection4Field(objvPubTeachCaseRelaInfoEN.FileType, convPubTeachCaseRelaInfo.FileType);
clsCheckSql.CheckSqlInjection4Field(objvPubTeachCaseRelaInfoEN.SaveDate, convPubTeachCaseRelaInfo.SaveDate);
clsCheckSql.CheckSqlInjection4Field(objvPubTeachCaseRelaInfoEN.FileSize, convPubTeachCaseRelaInfo.FileSize);
clsCheckSql.CheckSqlInjection4Field(objvPubTeachCaseRelaInfoEN.SaveTime, convPubTeachCaseRelaInfo.SaveTime);
clsCheckSql.CheckSqlInjection4Field(objvPubTeachCaseRelaInfoEN.IdPubClassCase, convPubTeachCaseRelaInfo.IdPubClassCase);
clsCheckSql.CheckSqlInjection4Field(objvPubTeachCaseRelaInfoEN.PubClassCaseID, convPubTeachCaseRelaInfo.PubClassCaseID);
clsCheckSql.CheckSqlInjection4Field(objvPubTeachCaseRelaInfoEN.PubClassCaseName, convPubTeachCaseRelaInfo.PubClassCaseName);
clsCheckSql.CheckSqlInjection4Field(objvPubTeachCaseRelaInfoEN.PubClassCaseExecutor, convPubTeachCaseRelaInfo.PubClassCaseExecutor);
clsCheckSql.CheckSqlInjection4Field(objvPubTeachCaseRelaInfoEN.PubClassCaseTheme, convPubTeachCaseRelaInfo.PubClassCaseTheme);
clsCheckSql.CheckSqlInjection4Field(objvPubTeachCaseRelaInfoEN.PubClassCaseTeachDate, convPubTeachCaseRelaInfo.PubClassCaseTeachDate);
clsCheckSql.CheckSqlInjection4Field(objvPubTeachCaseRelaInfoEN.PubClassCaseDateIn, convPubTeachCaseRelaInfo.PubClassCaseDateIn);
clsCheckSql.CheckSqlInjection4Field(objvPubTeachCaseRelaInfoEN.IdTeachingPlan, convPubTeachCaseRelaInfo.IdTeachingPlan);
clsCheckSql.CheckSqlInjection4Field(objvPubTeachCaseRelaInfoEN.Memo, convPubTeachCaseRelaInfo.Memo);
clsCheckSql.CheckSqlInjection4Field(objvPubTeachCaseRelaInfoEN.FileOriginName, convPubTeachCaseRelaInfo.FileOriginName);
clsCheckSql.CheckSqlInjection4Field(objvPubTeachCaseRelaInfoEN.ResourceID, convPubTeachCaseRelaInfo.ResourceID);
clsCheckSql.CheckSqlInjection4Field(objvPubTeachCaseRelaInfoEN.FileNewName, convPubTeachCaseRelaInfo.FileNewName);
clsCheckSql.CheckSqlInjection4Field(objvPubTeachCaseRelaInfoEN.FileOldName, convPubTeachCaseRelaInfo.FileOldName);
//检查外键字段长度
 objvPubTeachCaseRelaInfoEN._IsCheckProperty = true;
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
 objSQL = clsvPubTeachCaseRelaInfoDA.GetSpecSQLObj();
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
 objSQL = clsvPubTeachCaseRelaInfoDA.GetSpecSQLObj();
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
 objSQL = clsvPubTeachCaseRelaInfoDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvPubTeachCaseRelaInfoEN._CurrTabName);
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
 objSQL = clsvPubTeachCaseRelaInfoDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvPubTeachCaseRelaInfoEN._CurrTabName, strCondition);
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
 objSQL = clsvPubTeachCaseRelaInfoDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}