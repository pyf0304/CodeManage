
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvYoungTAppraisedCaseRelaInfoDA
 表名:vYoungTAppraisedCaseRelaInfo(01120396)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:51:29
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:青教评优(YoungTeachersAppraised)
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
 /// vYoungTAppraisedCaseRelaInfo(vYoungTAppraisedCaseRelaInfo)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvYoungTAppraisedCaseRelaInfoDA : clsCommBase4DA
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
 return clsvYoungTAppraisedCaseRelaInfoEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvYoungTAppraisedCaseRelaInfoEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvYoungTAppraisedCaseRelaInfoEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvYoungTAppraisedCaseRelaInfoEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvYoungTAppraisedCaseRelaInfoEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvYoungTAppraisedCaseRelaInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vYoungTAppraisedCaseRelaInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vYoungTAppraisedCaseRelaInfo(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvYoungTAppraisedCaseRelaInfoDA: GetDataTable_vYoungTAppraisedCaseRelaInfo)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vYoungTAppraisedCaseRelaInfo where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvYoungTAppraisedCaseRelaInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCaseRelaInfoDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvYoungTAppraisedCaseRelaInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vYoungTAppraisedCaseRelaInfo where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvYoungTAppraisedCaseRelaInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCaseRelaInfoDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvYoungTAppraisedCaseRelaInfoDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCaseRelaInfoDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vYoungTAppraisedCaseRelaInfo where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vYoungTAppraisedCaseRelaInfo where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvYoungTAppraisedCaseRelaInfoDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCaseRelaInfoDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vYoungTAppraisedCaseRelaInfo where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvYoungTAppraisedCaseRelaInfoDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCaseRelaInfoDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vYoungTAppraisedCaseRelaInfo.* from vYoungTAppraisedCaseRelaInfo Left Join {1} on {2} where {3} and vYoungTAppraisedCaseRelaInfo.IdMicroTeachCaseRelaInfo not in (Select top {5} vYoungTAppraisedCaseRelaInfo.IdMicroTeachCaseRelaInfo from vYoungTAppraisedCaseRelaInfo Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vYoungTAppraisedCaseRelaInfo where {1} and IdMicroTeachCaseRelaInfo not in (Select top {2} IdMicroTeachCaseRelaInfo from vYoungTAppraisedCaseRelaInfo where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vYoungTAppraisedCaseRelaInfo where {1} and IdMicroTeachCaseRelaInfo not in (Select top {3} IdMicroTeachCaseRelaInfo from vYoungTAppraisedCaseRelaInfo where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvYoungTAppraisedCaseRelaInfoDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCaseRelaInfoDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vYoungTAppraisedCaseRelaInfo.* from vYoungTAppraisedCaseRelaInfo Left Join {1} on {2} where {3} and vYoungTAppraisedCaseRelaInfo.IdMicroTeachCaseRelaInfo not in (Select top {5} vYoungTAppraisedCaseRelaInfo.IdMicroTeachCaseRelaInfo from vYoungTAppraisedCaseRelaInfo Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vYoungTAppraisedCaseRelaInfo where {1} and IdMicroTeachCaseRelaInfo not in (Select top {2} IdMicroTeachCaseRelaInfo from vYoungTAppraisedCaseRelaInfo where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vYoungTAppraisedCaseRelaInfo where {1} and IdMicroTeachCaseRelaInfo not in (Select top {3} IdMicroTeachCaseRelaInfo from vYoungTAppraisedCaseRelaInfo where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvYoungTAppraisedCaseRelaInfoEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvYoungTAppraisedCaseRelaInfoDA:GetObjLst)", objException.Message));
}
List<clsvYoungTAppraisedCaseRelaInfoEN> arrObjLst = new List<clsvYoungTAppraisedCaseRelaInfoEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vYoungTAppraisedCaseRelaInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvYoungTAppraisedCaseRelaInfoEN objvYoungTAppraisedCaseRelaInfoEN = new clsvYoungTAppraisedCaseRelaInfoEN();
try
{
objvYoungTAppraisedCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = TransNullToInt(objRow[convYoungTAppraisedCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvYoungTAppraisedCaseRelaInfoEN.IsVisible = TransNullToBool(objRow[convYoungTAppraisedCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvYoungTAppraisedCaseRelaInfoEN.IdFile = objRow[convYoungTAppraisedCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvYoungTAppraisedCaseRelaInfoEN.FileName = objRow[convYoungTAppraisedCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvYoungTAppraisedCaseRelaInfoEN.FileType = objRow[convYoungTAppraisedCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvYoungTAppraisedCaseRelaInfoEN.SaveDate = objRow[convYoungTAppraisedCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvYoungTAppraisedCaseRelaInfoEN.FileSize = objRow[convYoungTAppraisedCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvYoungTAppraisedCaseRelaInfoEN.SaveTime = objRow[convYoungTAppraisedCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvYoungTAppraisedCaseRelaInfoEN.IdFtpResource = objRow[convYoungTAppraisedCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvYoungTAppraisedCaseRelaInfoEN.FtpResourceID = objRow[convYoungTAppraisedCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvYoungTAppraisedCaseRelaInfoEN.FileOriginalName = objRow[convYoungTAppraisedCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvYoungTAppraisedCaseRelaInfoEN.FileDirName = objRow[convYoungTAppraisedCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvYoungTAppraisedCaseRelaInfoEN.FileRename = objRow[convYoungTAppraisedCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvYoungTAppraisedCaseRelaInfoEN.FileUpDate = objRow[convYoungTAppraisedCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvYoungTAppraisedCaseRelaInfoEN.FileUpTime = objRow[convYoungTAppraisedCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvYoungTAppraisedCaseRelaInfoEN.IdResource = objRow[convYoungTAppraisedCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvYoungTAppraisedCaseRelaInfoEN.ResourceID = objRow[convYoungTAppraisedCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvYoungTAppraisedCaseRelaInfoEN.SaveMode = TransNullToBool(objRow[convYoungTAppraisedCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvYoungTAppraisedCaseRelaInfoEN.IdResourceType = objRow[convYoungTAppraisedCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvYoungTAppraisedCaseRelaInfoEN.ResourceTypeID = objRow[convYoungTAppraisedCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvYoungTAppraisedCaseRelaInfoEN.ResourceTypeName = objRow[convYoungTAppraisedCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvYoungTAppraisedCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convYoungTAppraisedCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvYoungTAppraisedCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convYoungTAppraisedCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvYoungTAppraisedCaseRelaInfoEN.BrowseCount = objRow[convYoungTAppraisedCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convYoungTAppraisedCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvYoungTAppraisedCaseRelaInfoEN.ResourceOwner = objRow[convYoungTAppraisedCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvYoungTAppraisedCaseRelaInfoEN.ftpFileType = objRow[convYoungTAppraisedCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvYoungTAppraisedCaseRelaInfoEN.ftpFileSize = objRow[convYoungTAppraisedCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvYoungTAppraisedCaseRelaInfoEN.ftpResourceOwner = objRow[convYoungTAppraisedCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvYoungTAppraisedCaseRelaInfoEN.FileOriginName = objRow[convYoungTAppraisedCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvYoungTAppraisedCaseRelaInfoEN.IdYoungTAppraisedCase = objRow[convYoungTAppraisedCaseRelaInfo.IdYoungTAppraisedCase].ToString().Trim(); //青教评优案例流水号
objvYoungTAppraisedCaseRelaInfoEN.YoungTAppraisedCaseName = objRow[convYoungTAppraisedCaseRelaInfo.YoungTAppraisedCaseName].ToString().Trim(); //青教评优案例名称
objvYoungTAppraisedCaseRelaInfoEN.Flag = objRow[convYoungTAppraisedCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.Flag].ToString().Trim(); //标志
objvYoungTAppraisedCaseRelaInfoEN.FileNewName = objRow[convYoungTAppraisedCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvYoungTAppraisedCaseRelaInfoEN.FileOldName = objRow[convYoungTAppraisedCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvYoungTAppraisedCaseRelaInfoEN.IsExistFile = TransNullToBool(objRow[convYoungTAppraisedCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvYoungTAppraisedCaseRelaInfoEN.FuncModuleId = objRow[convYoungTAppraisedCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvYoungTAppraisedCaseRelaInfoEN.FuncModuleName = objRow[convYoungTAppraisedCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvYoungTAppraisedCaseRelaInfoEN.IdMicroteachCase = objRow[convYoungTAppraisedCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvYoungTAppraisedCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convYoungTAppraisedCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objvYoungTAppraisedCaseRelaInfoEN.UpdDate = objRow[convYoungTAppraisedCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvYoungTAppraisedCaseRelaInfoEN.UpdUser = objRow[convYoungTAppraisedCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objvYoungTAppraisedCaseRelaInfoEN.Memo = objRow[convYoungTAppraisedCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvYoungTAppraisedCaseRelaInfoDA: GetObjLst)", objException.Message));
}
objvYoungTAppraisedCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvYoungTAppraisedCaseRelaInfoEN);
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
public List<clsvYoungTAppraisedCaseRelaInfoEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvYoungTAppraisedCaseRelaInfoDA:GetObjLstByTabName)", objException.Message));
}
List<clsvYoungTAppraisedCaseRelaInfoEN> arrObjLst = new List<clsvYoungTAppraisedCaseRelaInfoEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCaseRelaInfoDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvYoungTAppraisedCaseRelaInfoEN objvYoungTAppraisedCaseRelaInfoEN = new clsvYoungTAppraisedCaseRelaInfoEN();
try
{
objvYoungTAppraisedCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = TransNullToInt(objRow[convYoungTAppraisedCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvYoungTAppraisedCaseRelaInfoEN.IsVisible = TransNullToBool(objRow[convYoungTAppraisedCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvYoungTAppraisedCaseRelaInfoEN.IdFile = objRow[convYoungTAppraisedCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvYoungTAppraisedCaseRelaInfoEN.FileName = objRow[convYoungTAppraisedCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvYoungTAppraisedCaseRelaInfoEN.FileType = objRow[convYoungTAppraisedCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvYoungTAppraisedCaseRelaInfoEN.SaveDate = objRow[convYoungTAppraisedCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvYoungTAppraisedCaseRelaInfoEN.FileSize = objRow[convYoungTAppraisedCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvYoungTAppraisedCaseRelaInfoEN.SaveTime = objRow[convYoungTAppraisedCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvYoungTAppraisedCaseRelaInfoEN.IdFtpResource = objRow[convYoungTAppraisedCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvYoungTAppraisedCaseRelaInfoEN.FtpResourceID = objRow[convYoungTAppraisedCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvYoungTAppraisedCaseRelaInfoEN.FileOriginalName = objRow[convYoungTAppraisedCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvYoungTAppraisedCaseRelaInfoEN.FileDirName = objRow[convYoungTAppraisedCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvYoungTAppraisedCaseRelaInfoEN.FileRename = objRow[convYoungTAppraisedCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvYoungTAppraisedCaseRelaInfoEN.FileUpDate = objRow[convYoungTAppraisedCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvYoungTAppraisedCaseRelaInfoEN.FileUpTime = objRow[convYoungTAppraisedCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvYoungTAppraisedCaseRelaInfoEN.IdResource = objRow[convYoungTAppraisedCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvYoungTAppraisedCaseRelaInfoEN.ResourceID = objRow[convYoungTAppraisedCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvYoungTAppraisedCaseRelaInfoEN.SaveMode = TransNullToBool(objRow[convYoungTAppraisedCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvYoungTAppraisedCaseRelaInfoEN.IdResourceType = objRow[convYoungTAppraisedCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvYoungTAppraisedCaseRelaInfoEN.ResourceTypeID = objRow[convYoungTAppraisedCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvYoungTAppraisedCaseRelaInfoEN.ResourceTypeName = objRow[convYoungTAppraisedCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvYoungTAppraisedCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convYoungTAppraisedCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvYoungTAppraisedCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convYoungTAppraisedCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvYoungTAppraisedCaseRelaInfoEN.BrowseCount = objRow[convYoungTAppraisedCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convYoungTAppraisedCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvYoungTAppraisedCaseRelaInfoEN.ResourceOwner = objRow[convYoungTAppraisedCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvYoungTAppraisedCaseRelaInfoEN.ftpFileType = objRow[convYoungTAppraisedCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvYoungTAppraisedCaseRelaInfoEN.ftpFileSize = objRow[convYoungTAppraisedCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvYoungTAppraisedCaseRelaInfoEN.ftpResourceOwner = objRow[convYoungTAppraisedCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvYoungTAppraisedCaseRelaInfoEN.FileOriginName = objRow[convYoungTAppraisedCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvYoungTAppraisedCaseRelaInfoEN.IdYoungTAppraisedCase = objRow[convYoungTAppraisedCaseRelaInfo.IdYoungTAppraisedCase].ToString().Trim(); //青教评优案例流水号
objvYoungTAppraisedCaseRelaInfoEN.YoungTAppraisedCaseName = objRow[convYoungTAppraisedCaseRelaInfo.YoungTAppraisedCaseName].ToString().Trim(); //青教评优案例名称
objvYoungTAppraisedCaseRelaInfoEN.Flag = objRow[convYoungTAppraisedCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.Flag].ToString().Trim(); //标志
objvYoungTAppraisedCaseRelaInfoEN.FileNewName = objRow[convYoungTAppraisedCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvYoungTAppraisedCaseRelaInfoEN.FileOldName = objRow[convYoungTAppraisedCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvYoungTAppraisedCaseRelaInfoEN.IsExistFile = TransNullToBool(objRow[convYoungTAppraisedCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvYoungTAppraisedCaseRelaInfoEN.FuncModuleId = objRow[convYoungTAppraisedCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvYoungTAppraisedCaseRelaInfoEN.FuncModuleName = objRow[convYoungTAppraisedCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvYoungTAppraisedCaseRelaInfoEN.IdMicroteachCase = objRow[convYoungTAppraisedCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvYoungTAppraisedCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convYoungTAppraisedCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objvYoungTAppraisedCaseRelaInfoEN.UpdDate = objRow[convYoungTAppraisedCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvYoungTAppraisedCaseRelaInfoEN.UpdUser = objRow[convYoungTAppraisedCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objvYoungTAppraisedCaseRelaInfoEN.Memo = objRow[convYoungTAppraisedCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvYoungTAppraisedCaseRelaInfoDA: GetObjLst)", objException.Message));
}
objvYoungTAppraisedCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvYoungTAppraisedCaseRelaInfoEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseRelaInfoEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvYoungTAppraisedCaseRelaInfo(ref clsvYoungTAppraisedCaseRelaInfoEN objvYoungTAppraisedCaseRelaInfoEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vYoungTAppraisedCaseRelaInfo where IdMicroTeachCaseRelaInfo = " + ""+ objvYoungTAppraisedCaseRelaInfoEN.IdMicroTeachCaseRelaInfo+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvYoungTAppraisedCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = TransNullToInt(objDT.Rows[0][convYoungTAppraisedCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvYoungTAppraisedCaseRelaInfoEN.IsVisible = TransNullToBool(objDT.Rows[0][convYoungTAppraisedCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvYoungTAppraisedCaseRelaInfoEN.IdFile = objDT.Rows[0][convYoungTAppraisedCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号(字段类型:char,字段长度:8,是否可空:True)
 objvYoungTAppraisedCaseRelaInfoEN.FileName = objDT.Rows[0][convYoungTAppraisedCaseRelaInfo.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvYoungTAppraisedCaseRelaInfoEN.FileType = objDT.Rows[0][convYoungTAppraisedCaseRelaInfo.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvYoungTAppraisedCaseRelaInfoEN.SaveDate = objDT.Rows[0][convYoungTAppraisedCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvYoungTAppraisedCaseRelaInfoEN.FileSize = objDT.Rows[0][convYoungTAppraisedCaseRelaInfo.FileSize].ToString().Trim(); //文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvYoungTAppraisedCaseRelaInfoEN.SaveTime = objDT.Rows[0][convYoungTAppraisedCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvYoungTAppraisedCaseRelaInfoEN.IdFtpResource = objDT.Rows[0][convYoungTAppraisedCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objvYoungTAppraisedCaseRelaInfoEN.FtpResourceID = objDT.Rows[0][convYoungTAppraisedCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvYoungTAppraisedCaseRelaInfoEN.FileOriginalName = objDT.Rows[0][convYoungTAppraisedCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名(字段类型:varchar,字段长度:200,是否可空:True)
 objvYoungTAppraisedCaseRelaInfoEN.FileDirName = objDT.Rows[0][convYoungTAppraisedCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objvYoungTAppraisedCaseRelaInfoEN.FileRename = objDT.Rows[0][convYoungTAppraisedCaseRelaInfo.FileRename].ToString().Trim(); //文件新名(字段类型:varchar,字段长度:200,是否可空:True)
 objvYoungTAppraisedCaseRelaInfoEN.FileUpDate = objDT.Rows[0][convYoungTAppraisedCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvYoungTAppraisedCaseRelaInfoEN.FileUpTime = objDT.Rows[0][convYoungTAppraisedCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvYoungTAppraisedCaseRelaInfoEN.IdResource = objDT.Rows[0][convYoungTAppraisedCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objvYoungTAppraisedCaseRelaInfoEN.ResourceID = objDT.Rows[0][convYoungTAppraisedCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvYoungTAppraisedCaseRelaInfoEN.SaveMode = TransNullToBool(objDT.Rows[0][convYoungTAppraisedCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式(字段类型:bit,字段长度:1,是否可空:True)
 objvYoungTAppraisedCaseRelaInfoEN.IdResourceType = objDT.Rows[0][convYoungTAppraisedCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvYoungTAppraisedCaseRelaInfoEN.ResourceTypeID = objDT.Rows[0][convYoungTAppraisedCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvYoungTAppraisedCaseRelaInfoEN.ResourceTypeName = objDT.Rows[0][convYoungTAppraisedCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvYoungTAppraisedCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objDT.Rows[0][convYoungTAppraisedCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvYoungTAppraisedCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objDT.Rows[0][convYoungTAppraisedCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvYoungTAppraisedCaseRelaInfoEN.BrowseCount = TransNullToInt(objDT.Rows[0][convYoungTAppraisedCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvYoungTAppraisedCaseRelaInfoEN.ResourceOwner = objDT.Rows[0][convYoungTAppraisedCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者(字段类型:varchar,字段长度:50,是否可空:False)
 objvYoungTAppraisedCaseRelaInfoEN.ftpFileType = objDT.Rows[0][convYoungTAppraisedCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvYoungTAppraisedCaseRelaInfoEN.ftpFileSize = objDT.Rows[0][convYoungTAppraisedCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvYoungTAppraisedCaseRelaInfoEN.ftpResourceOwner = objDT.Rows[0][convYoungTAppraisedCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者(字段类型:varchar,字段长度:50,是否可空:True)
 objvYoungTAppraisedCaseRelaInfoEN.FileOriginName = objDT.Rows[0][convYoungTAppraisedCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名(字段类型:varchar,字段长度:500,是否可空:True)
 objvYoungTAppraisedCaseRelaInfoEN.IdYoungTAppraisedCase = objDT.Rows[0][convYoungTAppraisedCaseRelaInfo.IdYoungTAppraisedCase].ToString().Trim(); //青教评优案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvYoungTAppraisedCaseRelaInfoEN.YoungTAppraisedCaseName = objDT.Rows[0][convYoungTAppraisedCaseRelaInfo.YoungTAppraisedCaseName].ToString().Trim(); //青教评优案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvYoungTAppraisedCaseRelaInfoEN.Flag = objDT.Rows[0][convYoungTAppraisedCaseRelaInfo.Flag].ToString().Trim(); //标志(字段类型:varchar,字段长度:50,是否可空:True)
 objvYoungTAppraisedCaseRelaInfoEN.FileNewName = objDT.Rows[0][convYoungTAppraisedCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvYoungTAppraisedCaseRelaInfoEN.FileOldName = objDT.Rows[0][convYoungTAppraisedCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvYoungTAppraisedCaseRelaInfoEN.IsExistFile = TransNullToBool(objDT.Rows[0][convYoungTAppraisedCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objvYoungTAppraisedCaseRelaInfoEN.FuncModuleId = objDT.Rows[0][convYoungTAppraisedCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvYoungTAppraisedCaseRelaInfoEN.FuncModuleName = objDT.Rows[0][convYoungTAppraisedCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvYoungTAppraisedCaseRelaInfoEN.IdMicroteachCase = objDT.Rows[0][convYoungTAppraisedCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvYoungTAppraisedCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objDT.Rows[0][convYoungTAppraisedCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvYoungTAppraisedCaseRelaInfoEN.UpdDate = objDT.Rows[0][convYoungTAppraisedCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvYoungTAppraisedCaseRelaInfoEN.UpdUser = objDT.Rows[0][convYoungTAppraisedCaseRelaInfo.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvYoungTAppraisedCaseRelaInfoEN.Memo = objDT.Rows[0][convYoungTAppraisedCaseRelaInfo.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvYoungTAppraisedCaseRelaInfoDA: GetvYoungTAppraisedCaseRelaInfo)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdMicroTeachCaseRelaInfo">表关键字</param>
 /// <returns>表对象</returns>
public clsvYoungTAppraisedCaseRelaInfoEN GetObjByIdMicroTeachCaseRelaInfo(long lngIdMicroTeachCaseRelaInfo)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vYoungTAppraisedCaseRelaInfo where IdMicroTeachCaseRelaInfo = " + ""+ lngIdMicroTeachCaseRelaInfo+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvYoungTAppraisedCaseRelaInfoEN objvYoungTAppraisedCaseRelaInfoEN = new clsvYoungTAppraisedCaseRelaInfoEN();
try
{
 objvYoungTAppraisedCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = Int32.Parse(objRow[convYoungTAppraisedCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvYoungTAppraisedCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convYoungTAppraisedCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvYoungTAppraisedCaseRelaInfoEN.IdFile = objRow[convYoungTAppraisedCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号(字段类型:char,字段长度:8,是否可空:True)
 objvYoungTAppraisedCaseRelaInfoEN.FileName = objRow[convYoungTAppraisedCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvYoungTAppraisedCaseRelaInfoEN.FileType = objRow[convYoungTAppraisedCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvYoungTAppraisedCaseRelaInfoEN.SaveDate = objRow[convYoungTAppraisedCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvYoungTAppraisedCaseRelaInfoEN.FileSize = objRow[convYoungTAppraisedCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.FileSize].ToString().Trim(); //文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvYoungTAppraisedCaseRelaInfoEN.SaveTime = objRow[convYoungTAppraisedCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvYoungTAppraisedCaseRelaInfoEN.IdFtpResource = objRow[convYoungTAppraisedCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objvYoungTAppraisedCaseRelaInfoEN.FtpResourceID = objRow[convYoungTAppraisedCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvYoungTAppraisedCaseRelaInfoEN.FileOriginalName = objRow[convYoungTAppraisedCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名(字段类型:varchar,字段长度:200,是否可空:True)
 objvYoungTAppraisedCaseRelaInfoEN.FileDirName = objRow[convYoungTAppraisedCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objvYoungTAppraisedCaseRelaInfoEN.FileRename = objRow[convYoungTAppraisedCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.FileRename].ToString().Trim(); //文件新名(字段类型:varchar,字段长度:200,是否可空:True)
 objvYoungTAppraisedCaseRelaInfoEN.FileUpDate = objRow[convYoungTAppraisedCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvYoungTAppraisedCaseRelaInfoEN.FileUpTime = objRow[convYoungTAppraisedCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvYoungTAppraisedCaseRelaInfoEN.IdResource = objRow[convYoungTAppraisedCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objvYoungTAppraisedCaseRelaInfoEN.ResourceID = objRow[convYoungTAppraisedCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvYoungTAppraisedCaseRelaInfoEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convYoungTAppraisedCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式(字段类型:bit,字段长度:1,是否可空:True)
 objvYoungTAppraisedCaseRelaInfoEN.IdResourceType = objRow[convYoungTAppraisedCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvYoungTAppraisedCaseRelaInfoEN.ResourceTypeID = objRow[convYoungTAppraisedCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvYoungTAppraisedCaseRelaInfoEN.ResourceTypeName = objRow[convYoungTAppraisedCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvYoungTAppraisedCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convYoungTAppraisedCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvYoungTAppraisedCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convYoungTAppraisedCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvYoungTAppraisedCaseRelaInfoEN.BrowseCount = objRow[convYoungTAppraisedCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convYoungTAppraisedCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvYoungTAppraisedCaseRelaInfoEN.ResourceOwner = objRow[convYoungTAppraisedCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者(字段类型:varchar,字段长度:50,是否可空:False)
 objvYoungTAppraisedCaseRelaInfoEN.ftpFileType = objRow[convYoungTAppraisedCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvYoungTAppraisedCaseRelaInfoEN.ftpFileSize = objRow[convYoungTAppraisedCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvYoungTAppraisedCaseRelaInfoEN.ftpResourceOwner = objRow[convYoungTAppraisedCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者(字段类型:varchar,字段长度:50,是否可空:True)
 objvYoungTAppraisedCaseRelaInfoEN.FileOriginName = objRow[convYoungTAppraisedCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名(字段类型:varchar,字段长度:500,是否可空:True)
 objvYoungTAppraisedCaseRelaInfoEN.IdYoungTAppraisedCase = objRow[convYoungTAppraisedCaseRelaInfo.IdYoungTAppraisedCase].ToString().Trim(); //青教评优案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvYoungTAppraisedCaseRelaInfoEN.YoungTAppraisedCaseName = objRow[convYoungTAppraisedCaseRelaInfo.YoungTAppraisedCaseName].ToString().Trim(); //青教评优案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvYoungTAppraisedCaseRelaInfoEN.Flag = objRow[convYoungTAppraisedCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.Flag].ToString().Trim(); //标志(字段类型:varchar,字段长度:50,是否可空:True)
 objvYoungTAppraisedCaseRelaInfoEN.FileNewName = objRow[convYoungTAppraisedCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvYoungTAppraisedCaseRelaInfoEN.FileOldName = objRow[convYoungTAppraisedCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvYoungTAppraisedCaseRelaInfoEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convYoungTAppraisedCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objvYoungTAppraisedCaseRelaInfoEN.FuncModuleId = objRow[convYoungTAppraisedCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvYoungTAppraisedCaseRelaInfoEN.FuncModuleName = objRow[convYoungTAppraisedCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvYoungTAppraisedCaseRelaInfoEN.IdMicroteachCase = objRow[convYoungTAppraisedCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvYoungTAppraisedCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convYoungTAppraisedCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvYoungTAppraisedCaseRelaInfoEN.UpdDate = objRow[convYoungTAppraisedCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvYoungTAppraisedCaseRelaInfoEN.UpdUser = objRow[convYoungTAppraisedCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvYoungTAppraisedCaseRelaInfoEN.Memo = objRow[convYoungTAppraisedCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvYoungTAppraisedCaseRelaInfoDA: GetObjByIdMicroTeachCaseRelaInfo)", objException.Message));
}
return objvYoungTAppraisedCaseRelaInfoEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvYoungTAppraisedCaseRelaInfoEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvYoungTAppraisedCaseRelaInfoDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vYoungTAppraisedCaseRelaInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvYoungTAppraisedCaseRelaInfoEN objvYoungTAppraisedCaseRelaInfoEN = new clsvYoungTAppraisedCaseRelaInfoEN()
{
IdMicroTeachCaseRelaInfo = TransNullToInt(objRow[convYoungTAppraisedCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()), //案例相关信息流水号
IsVisible = TransNullToBool(objRow[convYoungTAppraisedCaseRelaInfo.IsVisible].ToString().Trim()), //是否显示
IdFile = objRow[convYoungTAppraisedCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.IdFile].ToString().Trim(), //文件流水号
FileName = objRow[convYoungTAppraisedCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.FileName].ToString().Trim(), //文件名称
FileType = objRow[convYoungTAppraisedCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.FileType].ToString().Trim(), //文件类型
SaveDate = objRow[convYoungTAppraisedCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.SaveDate].ToString().Trim(), //创建日期
FileSize = objRow[convYoungTAppraisedCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.FileSize].ToString().Trim(), //文件大小
SaveTime = objRow[convYoungTAppraisedCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.SaveTime].ToString().Trim(), //创建时间
IdFtpResource = objRow[convYoungTAppraisedCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.IdFtpResource].ToString().Trim(), //FTP资源流水号
FtpResourceID = objRow[convYoungTAppraisedCaseRelaInfo.FtpResourceID].ToString().Trim(), //FTP资源ID
FileOriginalName = objRow[convYoungTAppraisedCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.FileOriginalName].ToString().Trim(), //文件原名
FileDirName = objRow[convYoungTAppraisedCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.FileDirName].ToString().Trim(), //文件目录名
FileRename = objRow[convYoungTAppraisedCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.FileRename].ToString().Trim(), //文件新名
FileUpDate = objRow[convYoungTAppraisedCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.FileUpDate].ToString().Trim(), //创建日期
FileUpTime = objRow[convYoungTAppraisedCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.FileUpTime].ToString().Trim(), //创建时间
IdResource = objRow[convYoungTAppraisedCaseRelaInfo.IdResource].ToString().Trim(), //资源流水号
ResourceID = objRow[convYoungTAppraisedCaseRelaInfo.ResourceID].ToString().Trim(), //资源ID
SaveMode = TransNullToBool(objRow[convYoungTAppraisedCaseRelaInfo.SaveMode].ToString().Trim()), //文件存放方式
IdResourceType = objRow[convYoungTAppraisedCaseRelaInfo.IdResourceType].ToString().Trim(), //资源类型流水号
ResourceTypeID = objRow[convYoungTAppraisedCaseRelaInfo.ResourceTypeID].ToString().Trim(), //资源类型ID
ResourceTypeName = objRow[convYoungTAppraisedCaseRelaInfo.ResourceTypeName].ToString().Trim(), //资源类型名称
IdMicroTeachCaseRelaInfoType = objRow[convYoungTAppraisedCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(), //微格案例相关信息类型流水号
MicroTeachCaseRelaInfoTypeName = objRow[convYoungTAppraisedCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(), //微格案例相关信息类型名称
BrowseCount = objRow[convYoungTAppraisedCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convYoungTAppraisedCaseRelaInfo.BrowseCount].ToString().Trim()), //浏览次数
ResourceOwner = objRow[convYoungTAppraisedCaseRelaInfo.ResourceOwner].ToString().Trim(), //上传者
ftpFileType = objRow[convYoungTAppraisedCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.ftpFileType].ToString().Trim(), //ftp文件类型
ftpFileSize = objRow[convYoungTAppraisedCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.ftpFileSize].ToString().Trim(), //ftp文件大小
ftpResourceOwner = objRow[convYoungTAppraisedCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.ftpResourceOwner].ToString().Trim(), //Ftp资源拥有者
FileOriginName = objRow[convYoungTAppraisedCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.FileOriginName].ToString().Trim(), //原文件名
IdYoungTAppraisedCase = objRow[convYoungTAppraisedCaseRelaInfo.IdYoungTAppraisedCase].ToString().Trim(), //青教评优案例流水号
YoungTAppraisedCaseName = objRow[convYoungTAppraisedCaseRelaInfo.YoungTAppraisedCaseName].ToString().Trim(), //青教评优案例名称
Flag = objRow[convYoungTAppraisedCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.Flag].ToString().Trim(), //标志
FileNewName = objRow[convYoungTAppraisedCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.FileNewName].ToString().Trim(), //新文件名
FileOldName = objRow[convYoungTAppraisedCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.FileOldName].ToString().Trim(), //旧文件名
IsExistFile = TransNullToBool(objRow[convYoungTAppraisedCaseRelaInfo.IsExistFile].ToString().Trim()), //是否存在文件
FuncModuleId = objRow[convYoungTAppraisedCaseRelaInfo.FuncModuleId].ToString().Trim(), //功能模块Id
FuncModuleName = objRow[convYoungTAppraisedCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.FuncModuleName].ToString().Trim(), //功能模块名称
IdMicroteachCase = objRow[convYoungTAppraisedCaseRelaInfo.IdMicroteachCase].ToString().Trim(), //微格教学案例流水号
MicroTeachCaseRelaInfoTypeID = objRow[convYoungTAppraisedCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(), //微格案例相关信息类型ID
UpdDate = objRow[convYoungTAppraisedCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convYoungTAppraisedCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convYoungTAppraisedCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.Memo].ToString().Trim() //备注
};
objvYoungTAppraisedCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvYoungTAppraisedCaseRelaInfoEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvYoungTAppraisedCaseRelaInfoDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvYoungTAppraisedCaseRelaInfoEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvYoungTAppraisedCaseRelaInfoEN objvYoungTAppraisedCaseRelaInfoEN = new clsvYoungTAppraisedCaseRelaInfoEN();
try
{
objvYoungTAppraisedCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = TransNullToInt(objRow[convYoungTAppraisedCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvYoungTAppraisedCaseRelaInfoEN.IsVisible = TransNullToBool(objRow[convYoungTAppraisedCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvYoungTAppraisedCaseRelaInfoEN.IdFile = objRow[convYoungTAppraisedCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvYoungTAppraisedCaseRelaInfoEN.FileName = objRow[convYoungTAppraisedCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvYoungTAppraisedCaseRelaInfoEN.FileType = objRow[convYoungTAppraisedCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvYoungTAppraisedCaseRelaInfoEN.SaveDate = objRow[convYoungTAppraisedCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvYoungTAppraisedCaseRelaInfoEN.FileSize = objRow[convYoungTAppraisedCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvYoungTAppraisedCaseRelaInfoEN.SaveTime = objRow[convYoungTAppraisedCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvYoungTAppraisedCaseRelaInfoEN.IdFtpResource = objRow[convYoungTAppraisedCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvYoungTAppraisedCaseRelaInfoEN.FtpResourceID = objRow[convYoungTAppraisedCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvYoungTAppraisedCaseRelaInfoEN.FileOriginalName = objRow[convYoungTAppraisedCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvYoungTAppraisedCaseRelaInfoEN.FileDirName = objRow[convYoungTAppraisedCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvYoungTAppraisedCaseRelaInfoEN.FileRename = objRow[convYoungTAppraisedCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvYoungTAppraisedCaseRelaInfoEN.FileUpDate = objRow[convYoungTAppraisedCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvYoungTAppraisedCaseRelaInfoEN.FileUpTime = objRow[convYoungTAppraisedCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvYoungTAppraisedCaseRelaInfoEN.IdResource = objRow[convYoungTAppraisedCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvYoungTAppraisedCaseRelaInfoEN.ResourceID = objRow[convYoungTAppraisedCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvYoungTAppraisedCaseRelaInfoEN.SaveMode = TransNullToBool(objRow[convYoungTAppraisedCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvYoungTAppraisedCaseRelaInfoEN.IdResourceType = objRow[convYoungTAppraisedCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvYoungTAppraisedCaseRelaInfoEN.ResourceTypeID = objRow[convYoungTAppraisedCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvYoungTAppraisedCaseRelaInfoEN.ResourceTypeName = objRow[convYoungTAppraisedCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvYoungTAppraisedCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convYoungTAppraisedCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvYoungTAppraisedCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convYoungTAppraisedCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvYoungTAppraisedCaseRelaInfoEN.BrowseCount = objRow[convYoungTAppraisedCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convYoungTAppraisedCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvYoungTAppraisedCaseRelaInfoEN.ResourceOwner = objRow[convYoungTAppraisedCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvYoungTAppraisedCaseRelaInfoEN.ftpFileType = objRow[convYoungTAppraisedCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvYoungTAppraisedCaseRelaInfoEN.ftpFileSize = objRow[convYoungTAppraisedCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvYoungTAppraisedCaseRelaInfoEN.ftpResourceOwner = objRow[convYoungTAppraisedCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvYoungTAppraisedCaseRelaInfoEN.FileOriginName = objRow[convYoungTAppraisedCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvYoungTAppraisedCaseRelaInfoEN.IdYoungTAppraisedCase = objRow[convYoungTAppraisedCaseRelaInfo.IdYoungTAppraisedCase].ToString().Trim(); //青教评优案例流水号
objvYoungTAppraisedCaseRelaInfoEN.YoungTAppraisedCaseName = objRow[convYoungTAppraisedCaseRelaInfo.YoungTAppraisedCaseName].ToString().Trim(); //青教评优案例名称
objvYoungTAppraisedCaseRelaInfoEN.Flag = objRow[convYoungTAppraisedCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.Flag].ToString().Trim(); //标志
objvYoungTAppraisedCaseRelaInfoEN.FileNewName = objRow[convYoungTAppraisedCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvYoungTAppraisedCaseRelaInfoEN.FileOldName = objRow[convYoungTAppraisedCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvYoungTAppraisedCaseRelaInfoEN.IsExistFile = TransNullToBool(objRow[convYoungTAppraisedCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvYoungTAppraisedCaseRelaInfoEN.FuncModuleId = objRow[convYoungTAppraisedCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvYoungTAppraisedCaseRelaInfoEN.FuncModuleName = objRow[convYoungTAppraisedCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvYoungTAppraisedCaseRelaInfoEN.IdMicroteachCase = objRow[convYoungTAppraisedCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvYoungTAppraisedCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convYoungTAppraisedCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objvYoungTAppraisedCaseRelaInfoEN.UpdDate = objRow[convYoungTAppraisedCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvYoungTAppraisedCaseRelaInfoEN.UpdUser = objRow[convYoungTAppraisedCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objvYoungTAppraisedCaseRelaInfoEN.Memo = objRow[convYoungTAppraisedCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvYoungTAppraisedCaseRelaInfoDA: GetObjByDataRowvYoungTAppraisedCaseRelaInfo)", objException.Message));
}
objvYoungTAppraisedCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvYoungTAppraisedCaseRelaInfoEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvYoungTAppraisedCaseRelaInfoEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvYoungTAppraisedCaseRelaInfoEN objvYoungTAppraisedCaseRelaInfoEN = new clsvYoungTAppraisedCaseRelaInfoEN();
try
{
objvYoungTAppraisedCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = TransNullToInt(objRow[convYoungTAppraisedCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvYoungTAppraisedCaseRelaInfoEN.IsVisible = TransNullToBool(objRow[convYoungTAppraisedCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvYoungTAppraisedCaseRelaInfoEN.IdFile = objRow[convYoungTAppraisedCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvYoungTAppraisedCaseRelaInfoEN.FileName = objRow[convYoungTAppraisedCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvYoungTAppraisedCaseRelaInfoEN.FileType = objRow[convYoungTAppraisedCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvYoungTAppraisedCaseRelaInfoEN.SaveDate = objRow[convYoungTAppraisedCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvYoungTAppraisedCaseRelaInfoEN.FileSize = objRow[convYoungTAppraisedCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvYoungTAppraisedCaseRelaInfoEN.SaveTime = objRow[convYoungTAppraisedCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvYoungTAppraisedCaseRelaInfoEN.IdFtpResource = objRow[convYoungTAppraisedCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvYoungTAppraisedCaseRelaInfoEN.FtpResourceID = objRow[convYoungTAppraisedCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvYoungTAppraisedCaseRelaInfoEN.FileOriginalName = objRow[convYoungTAppraisedCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvYoungTAppraisedCaseRelaInfoEN.FileDirName = objRow[convYoungTAppraisedCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvYoungTAppraisedCaseRelaInfoEN.FileRename = objRow[convYoungTAppraisedCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvYoungTAppraisedCaseRelaInfoEN.FileUpDate = objRow[convYoungTAppraisedCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvYoungTAppraisedCaseRelaInfoEN.FileUpTime = objRow[convYoungTAppraisedCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvYoungTAppraisedCaseRelaInfoEN.IdResource = objRow[convYoungTAppraisedCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvYoungTAppraisedCaseRelaInfoEN.ResourceID = objRow[convYoungTAppraisedCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvYoungTAppraisedCaseRelaInfoEN.SaveMode = TransNullToBool(objRow[convYoungTAppraisedCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvYoungTAppraisedCaseRelaInfoEN.IdResourceType = objRow[convYoungTAppraisedCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvYoungTAppraisedCaseRelaInfoEN.ResourceTypeID = objRow[convYoungTAppraisedCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvYoungTAppraisedCaseRelaInfoEN.ResourceTypeName = objRow[convYoungTAppraisedCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvYoungTAppraisedCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convYoungTAppraisedCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvYoungTAppraisedCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convYoungTAppraisedCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvYoungTAppraisedCaseRelaInfoEN.BrowseCount = objRow[convYoungTAppraisedCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convYoungTAppraisedCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvYoungTAppraisedCaseRelaInfoEN.ResourceOwner = objRow[convYoungTAppraisedCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvYoungTAppraisedCaseRelaInfoEN.ftpFileType = objRow[convYoungTAppraisedCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvYoungTAppraisedCaseRelaInfoEN.ftpFileSize = objRow[convYoungTAppraisedCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvYoungTAppraisedCaseRelaInfoEN.ftpResourceOwner = objRow[convYoungTAppraisedCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvYoungTAppraisedCaseRelaInfoEN.FileOriginName = objRow[convYoungTAppraisedCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvYoungTAppraisedCaseRelaInfoEN.IdYoungTAppraisedCase = objRow[convYoungTAppraisedCaseRelaInfo.IdYoungTAppraisedCase].ToString().Trim(); //青教评优案例流水号
objvYoungTAppraisedCaseRelaInfoEN.YoungTAppraisedCaseName = objRow[convYoungTAppraisedCaseRelaInfo.YoungTAppraisedCaseName].ToString().Trim(); //青教评优案例名称
objvYoungTAppraisedCaseRelaInfoEN.Flag = objRow[convYoungTAppraisedCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.Flag].ToString().Trim(); //标志
objvYoungTAppraisedCaseRelaInfoEN.FileNewName = objRow[convYoungTAppraisedCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvYoungTAppraisedCaseRelaInfoEN.FileOldName = objRow[convYoungTAppraisedCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvYoungTAppraisedCaseRelaInfoEN.IsExistFile = TransNullToBool(objRow[convYoungTAppraisedCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvYoungTAppraisedCaseRelaInfoEN.FuncModuleId = objRow[convYoungTAppraisedCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvYoungTAppraisedCaseRelaInfoEN.FuncModuleName = objRow[convYoungTAppraisedCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvYoungTAppraisedCaseRelaInfoEN.IdMicroteachCase = objRow[convYoungTAppraisedCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvYoungTAppraisedCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convYoungTAppraisedCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objvYoungTAppraisedCaseRelaInfoEN.UpdDate = objRow[convYoungTAppraisedCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvYoungTAppraisedCaseRelaInfoEN.UpdUser = objRow[convYoungTAppraisedCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objvYoungTAppraisedCaseRelaInfoEN.Memo = objRow[convYoungTAppraisedCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseRelaInfo.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvYoungTAppraisedCaseRelaInfoDA: GetObjByDataRow)", objException.Message));
}
objvYoungTAppraisedCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvYoungTAppraisedCaseRelaInfoEN;
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
objSQL = clsvYoungTAppraisedCaseRelaInfoDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvYoungTAppraisedCaseRelaInfoEN._CurrTabName, convYoungTAppraisedCaseRelaInfo.IdMicroTeachCaseRelaInfo, 8, "");
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
objSQL = clsvYoungTAppraisedCaseRelaInfoDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvYoungTAppraisedCaseRelaInfoEN._CurrTabName, convYoungTAppraisedCaseRelaInfo.IdMicroTeachCaseRelaInfo, 8, strPrefix);
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
 objSQL = clsvYoungTAppraisedCaseRelaInfoDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdMicroTeachCaseRelaInfo from vYoungTAppraisedCaseRelaInfo where " + strCondition;
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
 objSQL = clsvYoungTAppraisedCaseRelaInfoDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdMicroTeachCaseRelaInfo from vYoungTAppraisedCaseRelaInfo where " + strCondition;
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
 objSQL = clsvYoungTAppraisedCaseRelaInfoDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vYoungTAppraisedCaseRelaInfo", "IdMicroTeachCaseRelaInfo = " + ""+ lngIdMicroTeachCaseRelaInfo+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvYoungTAppraisedCaseRelaInfoDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCaseRelaInfoDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vYoungTAppraisedCaseRelaInfo", strCondition))
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
objSQL = clsvYoungTAppraisedCaseRelaInfoDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vYoungTAppraisedCaseRelaInfo");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseRelaInfoENS">源对象</param>
 /// <param name = "objvYoungTAppraisedCaseRelaInfoENT">目标对象</param>
public void CopyTo(clsvYoungTAppraisedCaseRelaInfoEN objvYoungTAppraisedCaseRelaInfoENS, clsvYoungTAppraisedCaseRelaInfoEN objvYoungTAppraisedCaseRelaInfoENT)
{
objvYoungTAppraisedCaseRelaInfoENT.IdMicroTeachCaseRelaInfo = objvYoungTAppraisedCaseRelaInfoENS.IdMicroTeachCaseRelaInfo; //案例相关信息流水号
objvYoungTAppraisedCaseRelaInfoENT.IsVisible = objvYoungTAppraisedCaseRelaInfoENS.IsVisible; //是否显示
objvYoungTAppraisedCaseRelaInfoENT.IdFile = objvYoungTAppraisedCaseRelaInfoENS.IdFile; //文件流水号
objvYoungTAppraisedCaseRelaInfoENT.FileName = objvYoungTAppraisedCaseRelaInfoENS.FileName; //文件名称
objvYoungTAppraisedCaseRelaInfoENT.FileType = objvYoungTAppraisedCaseRelaInfoENS.FileType; //文件类型
objvYoungTAppraisedCaseRelaInfoENT.SaveDate = objvYoungTAppraisedCaseRelaInfoENS.SaveDate; //创建日期
objvYoungTAppraisedCaseRelaInfoENT.FileSize = objvYoungTAppraisedCaseRelaInfoENS.FileSize; //文件大小
objvYoungTAppraisedCaseRelaInfoENT.SaveTime = objvYoungTAppraisedCaseRelaInfoENS.SaveTime; //创建时间
objvYoungTAppraisedCaseRelaInfoENT.IdFtpResource = objvYoungTAppraisedCaseRelaInfoENS.IdFtpResource; //FTP资源流水号
objvYoungTAppraisedCaseRelaInfoENT.FtpResourceID = objvYoungTAppraisedCaseRelaInfoENS.FtpResourceID; //FTP资源ID
objvYoungTAppraisedCaseRelaInfoENT.FileOriginalName = objvYoungTAppraisedCaseRelaInfoENS.FileOriginalName; //文件原名
objvYoungTAppraisedCaseRelaInfoENT.FileDirName = objvYoungTAppraisedCaseRelaInfoENS.FileDirName; //文件目录名
objvYoungTAppraisedCaseRelaInfoENT.FileRename = objvYoungTAppraisedCaseRelaInfoENS.FileRename; //文件新名
objvYoungTAppraisedCaseRelaInfoENT.FileUpDate = objvYoungTAppraisedCaseRelaInfoENS.FileUpDate; //创建日期
objvYoungTAppraisedCaseRelaInfoENT.FileUpTime = objvYoungTAppraisedCaseRelaInfoENS.FileUpTime; //创建时间
objvYoungTAppraisedCaseRelaInfoENT.IdResource = objvYoungTAppraisedCaseRelaInfoENS.IdResource; //资源流水号
objvYoungTAppraisedCaseRelaInfoENT.ResourceID = objvYoungTAppraisedCaseRelaInfoENS.ResourceID; //资源ID
objvYoungTAppraisedCaseRelaInfoENT.SaveMode = objvYoungTAppraisedCaseRelaInfoENS.SaveMode; //文件存放方式
objvYoungTAppraisedCaseRelaInfoENT.IdResourceType = objvYoungTAppraisedCaseRelaInfoENS.IdResourceType; //资源类型流水号
objvYoungTAppraisedCaseRelaInfoENT.ResourceTypeID = objvYoungTAppraisedCaseRelaInfoENS.ResourceTypeID; //资源类型ID
objvYoungTAppraisedCaseRelaInfoENT.ResourceTypeName = objvYoungTAppraisedCaseRelaInfoENS.ResourceTypeName; //资源类型名称
objvYoungTAppraisedCaseRelaInfoENT.IdMicroTeachCaseRelaInfoType = objvYoungTAppraisedCaseRelaInfoENS.IdMicroTeachCaseRelaInfoType; //微格案例相关信息类型流水号
objvYoungTAppraisedCaseRelaInfoENT.MicroTeachCaseRelaInfoTypeName = objvYoungTAppraisedCaseRelaInfoENS.MicroTeachCaseRelaInfoTypeName; //微格案例相关信息类型名称
objvYoungTAppraisedCaseRelaInfoENT.BrowseCount = objvYoungTAppraisedCaseRelaInfoENS.BrowseCount; //浏览次数
objvYoungTAppraisedCaseRelaInfoENT.ResourceOwner = objvYoungTAppraisedCaseRelaInfoENS.ResourceOwner; //上传者
objvYoungTAppraisedCaseRelaInfoENT.ftpFileType = objvYoungTAppraisedCaseRelaInfoENS.ftpFileType; //ftp文件类型
objvYoungTAppraisedCaseRelaInfoENT.ftpFileSize = objvYoungTAppraisedCaseRelaInfoENS.ftpFileSize; //ftp文件大小
objvYoungTAppraisedCaseRelaInfoENT.ftpResourceOwner = objvYoungTAppraisedCaseRelaInfoENS.ftpResourceOwner; //Ftp资源拥有者
objvYoungTAppraisedCaseRelaInfoENT.FileOriginName = objvYoungTAppraisedCaseRelaInfoENS.FileOriginName; //原文件名
objvYoungTAppraisedCaseRelaInfoENT.IdYoungTAppraisedCase = objvYoungTAppraisedCaseRelaInfoENS.IdYoungTAppraisedCase; //青教评优案例流水号
objvYoungTAppraisedCaseRelaInfoENT.YoungTAppraisedCaseName = objvYoungTAppraisedCaseRelaInfoENS.YoungTAppraisedCaseName; //青教评优案例名称
objvYoungTAppraisedCaseRelaInfoENT.Flag = objvYoungTAppraisedCaseRelaInfoENS.Flag; //标志
objvYoungTAppraisedCaseRelaInfoENT.FileNewName = objvYoungTAppraisedCaseRelaInfoENS.FileNewName; //新文件名
objvYoungTAppraisedCaseRelaInfoENT.FileOldName = objvYoungTAppraisedCaseRelaInfoENS.FileOldName; //旧文件名
objvYoungTAppraisedCaseRelaInfoENT.IsExistFile = objvYoungTAppraisedCaseRelaInfoENS.IsExistFile; //是否存在文件
objvYoungTAppraisedCaseRelaInfoENT.FuncModuleId = objvYoungTAppraisedCaseRelaInfoENS.FuncModuleId; //功能模块Id
objvYoungTAppraisedCaseRelaInfoENT.FuncModuleName = objvYoungTAppraisedCaseRelaInfoENS.FuncModuleName; //功能模块名称
objvYoungTAppraisedCaseRelaInfoENT.IdMicroteachCase = objvYoungTAppraisedCaseRelaInfoENS.IdMicroteachCase; //微格教学案例流水号
objvYoungTAppraisedCaseRelaInfoENT.MicroTeachCaseRelaInfoTypeID = objvYoungTAppraisedCaseRelaInfoENS.MicroTeachCaseRelaInfoTypeID; //微格案例相关信息类型ID
objvYoungTAppraisedCaseRelaInfoENT.UpdDate = objvYoungTAppraisedCaseRelaInfoENS.UpdDate; //修改日期
objvYoungTAppraisedCaseRelaInfoENT.UpdUser = objvYoungTAppraisedCaseRelaInfoENS.UpdUser; //修改人
objvYoungTAppraisedCaseRelaInfoENT.Memo = objvYoungTAppraisedCaseRelaInfoENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvYoungTAppraisedCaseRelaInfoEN objvYoungTAppraisedCaseRelaInfoEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseRelaInfoEN.IdFile, 8, convYoungTAppraisedCaseRelaInfo.IdFile);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseRelaInfoEN.FileName, 500, convYoungTAppraisedCaseRelaInfo.FileName);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseRelaInfoEN.FileType, 30, convYoungTAppraisedCaseRelaInfo.FileType);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseRelaInfoEN.SaveDate, 8, convYoungTAppraisedCaseRelaInfo.SaveDate);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseRelaInfoEN.FileSize, 50, convYoungTAppraisedCaseRelaInfo.FileSize);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseRelaInfoEN.SaveTime, 6, convYoungTAppraisedCaseRelaInfo.SaveTime);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseRelaInfoEN.IdFtpResource, 8, convYoungTAppraisedCaseRelaInfo.IdFtpResource);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseRelaInfoEN.FtpResourceID, 8, convYoungTAppraisedCaseRelaInfo.FtpResourceID);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseRelaInfoEN.FileOriginalName, 200, convYoungTAppraisedCaseRelaInfo.FileOriginalName);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseRelaInfoEN.FileDirName, 200, convYoungTAppraisedCaseRelaInfo.FileDirName);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseRelaInfoEN.FileRename, 200, convYoungTAppraisedCaseRelaInfo.FileRename);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseRelaInfoEN.FileUpDate, 8, convYoungTAppraisedCaseRelaInfo.FileUpDate);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseRelaInfoEN.FileUpTime, 6, convYoungTAppraisedCaseRelaInfo.FileUpTime);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseRelaInfoEN.IdResource, 8, convYoungTAppraisedCaseRelaInfo.IdResource);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseRelaInfoEN.ResourceID, 8, convYoungTAppraisedCaseRelaInfo.ResourceID);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseRelaInfoEN.IdResourceType, 4, convYoungTAppraisedCaseRelaInfo.IdResourceType);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseRelaInfoEN.ResourceTypeID, 4, convYoungTAppraisedCaseRelaInfo.ResourceTypeID);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseRelaInfoEN.ResourceTypeName, 50, convYoungTAppraisedCaseRelaInfo.ResourceTypeName);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType, 4, convYoungTAppraisedCaseRelaInfo.IdMicroTeachCaseRelaInfoType);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName, 50, convYoungTAppraisedCaseRelaInfo.MicroTeachCaseRelaInfoTypeName);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseRelaInfoEN.ResourceOwner, 50, convYoungTAppraisedCaseRelaInfo.ResourceOwner);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseRelaInfoEN.ftpFileType, 30, convYoungTAppraisedCaseRelaInfo.ftpFileType);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseRelaInfoEN.ftpFileSize, 50, convYoungTAppraisedCaseRelaInfo.ftpFileSize);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseRelaInfoEN.ftpResourceOwner, 50, convYoungTAppraisedCaseRelaInfo.ftpResourceOwner);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseRelaInfoEN.FileOriginName, 500, convYoungTAppraisedCaseRelaInfo.FileOriginName);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseRelaInfoEN.IdYoungTAppraisedCase, 8, convYoungTAppraisedCaseRelaInfo.IdYoungTAppraisedCase);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseRelaInfoEN.YoungTAppraisedCaseName, 100, convYoungTAppraisedCaseRelaInfo.YoungTAppraisedCaseName);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseRelaInfoEN.Flag, 50, convYoungTAppraisedCaseRelaInfo.Flag);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseRelaInfoEN.FileNewName, 530, convYoungTAppraisedCaseRelaInfo.FileNewName);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseRelaInfoEN.FileOldName, 530, convYoungTAppraisedCaseRelaInfo.FileOldName);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseRelaInfoEN.FuncModuleId, 4, convYoungTAppraisedCaseRelaInfo.FuncModuleId);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseRelaInfoEN.FuncModuleName, 30, convYoungTAppraisedCaseRelaInfo.FuncModuleName);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseRelaInfoEN.IdMicroteachCase, 8, convYoungTAppraisedCaseRelaInfo.IdMicroteachCase);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID, 4, convYoungTAppraisedCaseRelaInfo.MicroTeachCaseRelaInfoTypeID);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseRelaInfoEN.UpdDate, 20, convYoungTAppraisedCaseRelaInfo.UpdDate);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseRelaInfoEN.UpdUser, 20, convYoungTAppraisedCaseRelaInfo.UpdUser);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseRelaInfoEN.Memo, 1000, convYoungTAppraisedCaseRelaInfo.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseRelaInfoEN.IdFile, convYoungTAppraisedCaseRelaInfo.IdFile);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseRelaInfoEN.FileName, convYoungTAppraisedCaseRelaInfo.FileName);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseRelaInfoEN.FileType, convYoungTAppraisedCaseRelaInfo.FileType);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseRelaInfoEN.SaveDate, convYoungTAppraisedCaseRelaInfo.SaveDate);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseRelaInfoEN.FileSize, convYoungTAppraisedCaseRelaInfo.FileSize);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseRelaInfoEN.SaveTime, convYoungTAppraisedCaseRelaInfo.SaveTime);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseRelaInfoEN.IdFtpResource, convYoungTAppraisedCaseRelaInfo.IdFtpResource);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseRelaInfoEN.FtpResourceID, convYoungTAppraisedCaseRelaInfo.FtpResourceID);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseRelaInfoEN.FileOriginalName, convYoungTAppraisedCaseRelaInfo.FileOriginalName);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseRelaInfoEN.FileDirName, convYoungTAppraisedCaseRelaInfo.FileDirName);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseRelaInfoEN.FileRename, convYoungTAppraisedCaseRelaInfo.FileRename);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseRelaInfoEN.FileUpDate, convYoungTAppraisedCaseRelaInfo.FileUpDate);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseRelaInfoEN.FileUpTime, convYoungTAppraisedCaseRelaInfo.FileUpTime);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseRelaInfoEN.IdResource, convYoungTAppraisedCaseRelaInfo.IdResource);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseRelaInfoEN.ResourceID, convYoungTAppraisedCaseRelaInfo.ResourceID);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseRelaInfoEN.IdResourceType, convYoungTAppraisedCaseRelaInfo.IdResourceType);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseRelaInfoEN.ResourceTypeID, convYoungTAppraisedCaseRelaInfo.ResourceTypeID);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseRelaInfoEN.ResourceTypeName, convYoungTAppraisedCaseRelaInfo.ResourceTypeName);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType, convYoungTAppraisedCaseRelaInfo.IdMicroTeachCaseRelaInfoType);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName, convYoungTAppraisedCaseRelaInfo.MicroTeachCaseRelaInfoTypeName);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseRelaInfoEN.ResourceOwner, convYoungTAppraisedCaseRelaInfo.ResourceOwner);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseRelaInfoEN.ftpFileType, convYoungTAppraisedCaseRelaInfo.ftpFileType);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseRelaInfoEN.ftpFileSize, convYoungTAppraisedCaseRelaInfo.ftpFileSize);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseRelaInfoEN.ftpResourceOwner, convYoungTAppraisedCaseRelaInfo.ftpResourceOwner);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseRelaInfoEN.FileOriginName, convYoungTAppraisedCaseRelaInfo.FileOriginName);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseRelaInfoEN.IdYoungTAppraisedCase, convYoungTAppraisedCaseRelaInfo.IdYoungTAppraisedCase);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseRelaInfoEN.YoungTAppraisedCaseName, convYoungTAppraisedCaseRelaInfo.YoungTAppraisedCaseName);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseRelaInfoEN.Flag, convYoungTAppraisedCaseRelaInfo.Flag);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseRelaInfoEN.FileNewName, convYoungTAppraisedCaseRelaInfo.FileNewName);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseRelaInfoEN.FileOldName, convYoungTAppraisedCaseRelaInfo.FileOldName);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseRelaInfoEN.FuncModuleId, convYoungTAppraisedCaseRelaInfo.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseRelaInfoEN.FuncModuleName, convYoungTAppraisedCaseRelaInfo.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseRelaInfoEN.IdMicroteachCase, convYoungTAppraisedCaseRelaInfo.IdMicroteachCase);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID, convYoungTAppraisedCaseRelaInfo.MicroTeachCaseRelaInfoTypeID);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseRelaInfoEN.UpdDate, convYoungTAppraisedCaseRelaInfo.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseRelaInfoEN.UpdUser, convYoungTAppraisedCaseRelaInfo.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseRelaInfoEN.Memo, convYoungTAppraisedCaseRelaInfo.Memo);
//检查外键字段长度
 objvYoungTAppraisedCaseRelaInfoEN._IsCheckProperty = true;
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
 objSQL = clsvYoungTAppraisedCaseRelaInfoDA.GetSpecSQLObj();
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
 objSQL = clsvYoungTAppraisedCaseRelaInfoDA.GetSpecSQLObj();
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
 objSQL = clsvYoungTAppraisedCaseRelaInfoDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvYoungTAppraisedCaseRelaInfoEN._CurrTabName);
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
 objSQL = clsvYoungTAppraisedCaseRelaInfoDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvYoungTAppraisedCaseRelaInfoEN._CurrTabName, strCondition);
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
 objSQL = clsvYoungTAppraisedCaseRelaInfoDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}