
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvClsRmTeachingCaseRelaInfoDA
 表名:vClsRmTeachingCaseRelaInfo(01120404)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:45:30
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课堂教学(ClsRmTeaching)
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
 /// v课堂教学案例相关信息(vClsRmTeachingCaseRelaInfo)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvClsRmTeachingCaseRelaInfoDA : clsCommBase4DA
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
 return clsvClsRmTeachingCaseRelaInfoEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvClsRmTeachingCaseRelaInfoEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvClsRmTeachingCaseRelaInfoEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvClsRmTeachingCaseRelaInfoEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvClsRmTeachingCaseRelaInfoEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvClsRmTeachingCaseRelaInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClsRmTeachingCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vClsRmTeachingCaseRelaInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vClsRmTeachingCaseRelaInfo(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvClsRmTeachingCaseRelaInfoDA: GetDataTable_vClsRmTeachingCaseRelaInfo)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClsRmTeachingCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vClsRmTeachingCaseRelaInfo where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvClsRmTeachingCaseRelaInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClsRmTeachingCaseRelaInfoDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvClsRmTeachingCaseRelaInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClsRmTeachingCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vClsRmTeachingCaseRelaInfo where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvClsRmTeachingCaseRelaInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClsRmTeachingCaseRelaInfoDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvClsRmTeachingCaseRelaInfoDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClsRmTeachingCaseRelaInfoDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vClsRmTeachingCaseRelaInfo where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vClsRmTeachingCaseRelaInfo where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvClsRmTeachingCaseRelaInfoDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClsRmTeachingCaseRelaInfoDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vClsRmTeachingCaseRelaInfo where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvClsRmTeachingCaseRelaInfoDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClsRmTeachingCaseRelaInfoDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vClsRmTeachingCaseRelaInfo.* from vClsRmTeachingCaseRelaInfo Left Join {1} on {2} where {3} and vClsRmTeachingCaseRelaInfo.IdMicroTeachCaseRelaInfo not in (Select top {5} vClsRmTeachingCaseRelaInfo.IdMicroTeachCaseRelaInfo from vClsRmTeachingCaseRelaInfo Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vClsRmTeachingCaseRelaInfo where {1} and IdMicroTeachCaseRelaInfo not in (Select top {2} IdMicroTeachCaseRelaInfo from vClsRmTeachingCaseRelaInfo where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vClsRmTeachingCaseRelaInfo where {1} and IdMicroTeachCaseRelaInfo not in (Select top {3} IdMicroTeachCaseRelaInfo from vClsRmTeachingCaseRelaInfo where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvClsRmTeachingCaseRelaInfoDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClsRmTeachingCaseRelaInfoDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vClsRmTeachingCaseRelaInfo.* from vClsRmTeachingCaseRelaInfo Left Join {1} on {2} where {3} and vClsRmTeachingCaseRelaInfo.IdMicroTeachCaseRelaInfo not in (Select top {5} vClsRmTeachingCaseRelaInfo.IdMicroTeachCaseRelaInfo from vClsRmTeachingCaseRelaInfo Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vClsRmTeachingCaseRelaInfo where {1} and IdMicroTeachCaseRelaInfo not in (Select top {2} IdMicroTeachCaseRelaInfo from vClsRmTeachingCaseRelaInfo where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vClsRmTeachingCaseRelaInfo where {1} and IdMicroTeachCaseRelaInfo not in (Select top {3} IdMicroTeachCaseRelaInfo from vClsRmTeachingCaseRelaInfo where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvClsRmTeachingCaseRelaInfoEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvClsRmTeachingCaseRelaInfoDA:GetObjLst)", objException.Message));
}
List<clsvClsRmTeachingCaseRelaInfoEN> arrObjLst = new List<clsvClsRmTeachingCaseRelaInfoEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClsRmTeachingCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vClsRmTeachingCaseRelaInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvClsRmTeachingCaseRelaInfoEN objvClsRmTeachingCaseRelaInfoEN = new clsvClsRmTeachingCaseRelaInfoEN();
try
{
objvClsRmTeachingCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = TransNullToInt(objRow[convClsRmTeachingCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvClsRmTeachingCaseRelaInfoEN.IdMicroteachCase = objRow[convClsRmTeachingCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvClsRmTeachingCaseRelaInfoEN.IdClsRmTeachingCase = objRow[convClsRmTeachingCaseRelaInfo.IdClsRmTeachingCase] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.IdClsRmTeachingCase].ToString().Trim(); //课堂教学案例流水号
objvClsRmTeachingCaseRelaInfoEN.ClsRmTeachingCaseName = objRow[convClsRmTeachingCaseRelaInfo.ClsRmTeachingCaseName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.ClsRmTeachingCaseName].ToString().Trim(); //课堂教学案例名称
objvClsRmTeachingCaseRelaInfoEN.IdResource = objRow[convClsRmTeachingCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvClsRmTeachingCaseRelaInfoEN.IsVisible = TransNullToBool(objRow[convClsRmTeachingCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvClsRmTeachingCaseRelaInfoEN.IdFile = objRow[convClsRmTeachingCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvClsRmTeachingCaseRelaInfoEN.FileName = objRow[convClsRmTeachingCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvClsRmTeachingCaseRelaInfoEN.FileType = objRow[convClsRmTeachingCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvClsRmTeachingCaseRelaInfoEN.SaveDate = objRow[convClsRmTeachingCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvClsRmTeachingCaseRelaInfoEN.FileSize = objRow[convClsRmTeachingCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvClsRmTeachingCaseRelaInfoEN.SaveTime = objRow[convClsRmTeachingCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvClsRmTeachingCaseRelaInfoEN.IdFtpResource = objRow[convClsRmTeachingCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvClsRmTeachingCaseRelaInfoEN.FtpResourceID = objRow[convClsRmTeachingCaseRelaInfo.FtpResourceID] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvClsRmTeachingCaseRelaInfoEN.FileOriginalName = objRow[convClsRmTeachingCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvClsRmTeachingCaseRelaInfoEN.FileDirName = objRow[convClsRmTeachingCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvClsRmTeachingCaseRelaInfoEN.FileRename = objRow[convClsRmTeachingCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvClsRmTeachingCaseRelaInfoEN.FileUpDate = objRow[convClsRmTeachingCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvClsRmTeachingCaseRelaInfoEN.FileUpTime = objRow[convClsRmTeachingCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvClsRmTeachingCaseRelaInfoEN.ResourceID = objRow[convClsRmTeachingCaseRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvClsRmTeachingCaseRelaInfoEN.SaveMode = TransNullToBool(objRow[convClsRmTeachingCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvClsRmTeachingCaseRelaInfoEN.IdResourceType = objRow[convClsRmTeachingCaseRelaInfo.IdResourceType] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvClsRmTeachingCaseRelaInfoEN.ResourceTypeID = objRow[convClsRmTeachingCaseRelaInfo.ResourceTypeID] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvClsRmTeachingCaseRelaInfoEN.ResourceTypeName = objRow[convClsRmTeachingCaseRelaInfo.ResourceTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvClsRmTeachingCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convClsRmTeachingCaseRelaInfo.IdMicroTeachCaseRelaInfoType] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvClsRmTeachingCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convClsRmTeachingCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objvClsRmTeachingCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convClsRmTeachingCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvClsRmTeachingCaseRelaInfoEN.BrowseCount = objRow[convClsRmTeachingCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convClsRmTeachingCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvClsRmTeachingCaseRelaInfoEN.ResourceOwner = objRow[convClsRmTeachingCaseRelaInfo.ResourceOwner] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvClsRmTeachingCaseRelaInfoEN.ftpFileType = objRow[convClsRmTeachingCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvClsRmTeachingCaseRelaInfoEN.ftpFileSize = objRow[convClsRmTeachingCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvClsRmTeachingCaseRelaInfoEN.ftpResourceOwner = objRow[convClsRmTeachingCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvClsRmTeachingCaseRelaInfoEN.FileOriginName = objRow[convClsRmTeachingCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvClsRmTeachingCaseRelaInfoEN.IsExistFile = TransNullToBool(objRow[convClsRmTeachingCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvClsRmTeachingCaseRelaInfoEN.Flag = objRow[convClsRmTeachingCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.Flag].ToString().Trim(); //标志
objvClsRmTeachingCaseRelaInfoEN.FuncModuleName = objRow[convClsRmTeachingCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvClsRmTeachingCaseRelaInfoEN.FuncModuleId = objRow[convClsRmTeachingCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvClsRmTeachingCaseRelaInfoEN.FileNewName = objRow[convClsRmTeachingCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvClsRmTeachingCaseRelaInfoEN.FileOldName = objRow[convClsRmTeachingCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvClsRmTeachingCaseRelaInfoEN.UpdDate = objRow[convClsRmTeachingCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvClsRmTeachingCaseRelaInfoEN.UpdUser = objRow[convClsRmTeachingCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objvClsRmTeachingCaseRelaInfoEN.Memo = objRow[convClsRmTeachingCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvClsRmTeachingCaseRelaInfoDA: GetObjLst)", objException.Message));
}
objvClsRmTeachingCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvClsRmTeachingCaseRelaInfoEN);
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
public List<clsvClsRmTeachingCaseRelaInfoEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvClsRmTeachingCaseRelaInfoDA:GetObjLstByTabName)", objException.Message));
}
List<clsvClsRmTeachingCaseRelaInfoEN> arrObjLst = new List<clsvClsRmTeachingCaseRelaInfoEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClsRmTeachingCaseRelaInfoDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvClsRmTeachingCaseRelaInfoEN objvClsRmTeachingCaseRelaInfoEN = new clsvClsRmTeachingCaseRelaInfoEN();
try
{
objvClsRmTeachingCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = TransNullToInt(objRow[convClsRmTeachingCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvClsRmTeachingCaseRelaInfoEN.IdMicroteachCase = objRow[convClsRmTeachingCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvClsRmTeachingCaseRelaInfoEN.IdClsRmTeachingCase = objRow[convClsRmTeachingCaseRelaInfo.IdClsRmTeachingCase] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.IdClsRmTeachingCase].ToString().Trim(); //课堂教学案例流水号
objvClsRmTeachingCaseRelaInfoEN.ClsRmTeachingCaseName = objRow[convClsRmTeachingCaseRelaInfo.ClsRmTeachingCaseName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.ClsRmTeachingCaseName].ToString().Trim(); //课堂教学案例名称
objvClsRmTeachingCaseRelaInfoEN.IdResource = objRow[convClsRmTeachingCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvClsRmTeachingCaseRelaInfoEN.IsVisible = TransNullToBool(objRow[convClsRmTeachingCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvClsRmTeachingCaseRelaInfoEN.IdFile = objRow[convClsRmTeachingCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvClsRmTeachingCaseRelaInfoEN.FileName = objRow[convClsRmTeachingCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvClsRmTeachingCaseRelaInfoEN.FileType = objRow[convClsRmTeachingCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvClsRmTeachingCaseRelaInfoEN.SaveDate = objRow[convClsRmTeachingCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvClsRmTeachingCaseRelaInfoEN.FileSize = objRow[convClsRmTeachingCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvClsRmTeachingCaseRelaInfoEN.SaveTime = objRow[convClsRmTeachingCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvClsRmTeachingCaseRelaInfoEN.IdFtpResource = objRow[convClsRmTeachingCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvClsRmTeachingCaseRelaInfoEN.FtpResourceID = objRow[convClsRmTeachingCaseRelaInfo.FtpResourceID] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvClsRmTeachingCaseRelaInfoEN.FileOriginalName = objRow[convClsRmTeachingCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvClsRmTeachingCaseRelaInfoEN.FileDirName = objRow[convClsRmTeachingCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvClsRmTeachingCaseRelaInfoEN.FileRename = objRow[convClsRmTeachingCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvClsRmTeachingCaseRelaInfoEN.FileUpDate = objRow[convClsRmTeachingCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvClsRmTeachingCaseRelaInfoEN.FileUpTime = objRow[convClsRmTeachingCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvClsRmTeachingCaseRelaInfoEN.ResourceID = objRow[convClsRmTeachingCaseRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvClsRmTeachingCaseRelaInfoEN.SaveMode = TransNullToBool(objRow[convClsRmTeachingCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvClsRmTeachingCaseRelaInfoEN.IdResourceType = objRow[convClsRmTeachingCaseRelaInfo.IdResourceType] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvClsRmTeachingCaseRelaInfoEN.ResourceTypeID = objRow[convClsRmTeachingCaseRelaInfo.ResourceTypeID] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvClsRmTeachingCaseRelaInfoEN.ResourceTypeName = objRow[convClsRmTeachingCaseRelaInfo.ResourceTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvClsRmTeachingCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convClsRmTeachingCaseRelaInfo.IdMicroTeachCaseRelaInfoType] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvClsRmTeachingCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convClsRmTeachingCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objvClsRmTeachingCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convClsRmTeachingCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvClsRmTeachingCaseRelaInfoEN.BrowseCount = objRow[convClsRmTeachingCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convClsRmTeachingCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvClsRmTeachingCaseRelaInfoEN.ResourceOwner = objRow[convClsRmTeachingCaseRelaInfo.ResourceOwner] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvClsRmTeachingCaseRelaInfoEN.ftpFileType = objRow[convClsRmTeachingCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvClsRmTeachingCaseRelaInfoEN.ftpFileSize = objRow[convClsRmTeachingCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvClsRmTeachingCaseRelaInfoEN.ftpResourceOwner = objRow[convClsRmTeachingCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvClsRmTeachingCaseRelaInfoEN.FileOriginName = objRow[convClsRmTeachingCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvClsRmTeachingCaseRelaInfoEN.IsExistFile = TransNullToBool(objRow[convClsRmTeachingCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvClsRmTeachingCaseRelaInfoEN.Flag = objRow[convClsRmTeachingCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.Flag].ToString().Trim(); //标志
objvClsRmTeachingCaseRelaInfoEN.FuncModuleName = objRow[convClsRmTeachingCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvClsRmTeachingCaseRelaInfoEN.FuncModuleId = objRow[convClsRmTeachingCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvClsRmTeachingCaseRelaInfoEN.FileNewName = objRow[convClsRmTeachingCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvClsRmTeachingCaseRelaInfoEN.FileOldName = objRow[convClsRmTeachingCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvClsRmTeachingCaseRelaInfoEN.UpdDate = objRow[convClsRmTeachingCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvClsRmTeachingCaseRelaInfoEN.UpdUser = objRow[convClsRmTeachingCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objvClsRmTeachingCaseRelaInfoEN.Memo = objRow[convClsRmTeachingCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvClsRmTeachingCaseRelaInfoDA: GetObjLst)", objException.Message));
}
objvClsRmTeachingCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvClsRmTeachingCaseRelaInfoEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseRelaInfoEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvClsRmTeachingCaseRelaInfo(ref clsvClsRmTeachingCaseRelaInfoEN objvClsRmTeachingCaseRelaInfoEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClsRmTeachingCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vClsRmTeachingCaseRelaInfo where IdMicroTeachCaseRelaInfo = " + ""+ objvClsRmTeachingCaseRelaInfoEN.IdMicroTeachCaseRelaInfo+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvClsRmTeachingCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = TransNullToInt(objDT.Rows[0][convClsRmTeachingCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvClsRmTeachingCaseRelaInfoEN.IdMicroteachCase = objDT.Rows[0][convClsRmTeachingCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvClsRmTeachingCaseRelaInfoEN.IdClsRmTeachingCase = objDT.Rows[0][convClsRmTeachingCaseRelaInfo.IdClsRmTeachingCase].ToString().Trim(); //课堂教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvClsRmTeachingCaseRelaInfoEN.ClsRmTeachingCaseName = objDT.Rows[0][convClsRmTeachingCaseRelaInfo.ClsRmTeachingCaseName].ToString().Trim(); //课堂教学案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvClsRmTeachingCaseRelaInfoEN.IdResource = objDT.Rows[0][convClsRmTeachingCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objvClsRmTeachingCaseRelaInfoEN.IsVisible = TransNullToBool(objDT.Rows[0][convClsRmTeachingCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvClsRmTeachingCaseRelaInfoEN.IdFile = objDT.Rows[0][convClsRmTeachingCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号(字段类型:char,字段长度:8,是否可空:True)
 objvClsRmTeachingCaseRelaInfoEN.FileName = objDT.Rows[0][convClsRmTeachingCaseRelaInfo.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvClsRmTeachingCaseRelaInfoEN.FileType = objDT.Rows[0][convClsRmTeachingCaseRelaInfo.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvClsRmTeachingCaseRelaInfoEN.SaveDate = objDT.Rows[0][convClsRmTeachingCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvClsRmTeachingCaseRelaInfoEN.FileSize = objDT.Rows[0][convClsRmTeachingCaseRelaInfo.FileSize].ToString().Trim(); //文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvClsRmTeachingCaseRelaInfoEN.SaveTime = objDT.Rows[0][convClsRmTeachingCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvClsRmTeachingCaseRelaInfoEN.IdFtpResource = objDT.Rows[0][convClsRmTeachingCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objvClsRmTeachingCaseRelaInfoEN.FtpResourceID = objDT.Rows[0][convClsRmTeachingCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvClsRmTeachingCaseRelaInfoEN.FileOriginalName = objDT.Rows[0][convClsRmTeachingCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名(字段类型:varchar,字段长度:200,是否可空:True)
 objvClsRmTeachingCaseRelaInfoEN.FileDirName = objDT.Rows[0][convClsRmTeachingCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objvClsRmTeachingCaseRelaInfoEN.FileRename = objDT.Rows[0][convClsRmTeachingCaseRelaInfo.FileRename].ToString().Trim(); //文件新名(字段类型:varchar,字段长度:200,是否可空:True)
 objvClsRmTeachingCaseRelaInfoEN.FileUpDate = objDT.Rows[0][convClsRmTeachingCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvClsRmTeachingCaseRelaInfoEN.FileUpTime = objDT.Rows[0][convClsRmTeachingCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvClsRmTeachingCaseRelaInfoEN.ResourceID = objDT.Rows[0][convClsRmTeachingCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvClsRmTeachingCaseRelaInfoEN.SaveMode = TransNullToBool(objDT.Rows[0][convClsRmTeachingCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式(字段类型:bit,字段长度:1,是否可空:True)
 objvClsRmTeachingCaseRelaInfoEN.IdResourceType = objDT.Rows[0][convClsRmTeachingCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvClsRmTeachingCaseRelaInfoEN.ResourceTypeID = objDT.Rows[0][convClsRmTeachingCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvClsRmTeachingCaseRelaInfoEN.ResourceTypeName = objDT.Rows[0][convClsRmTeachingCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvClsRmTeachingCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objDT.Rows[0][convClsRmTeachingCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvClsRmTeachingCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objDT.Rows[0][convClsRmTeachingCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvClsRmTeachingCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objDT.Rows[0][convClsRmTeachingCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvClsRmTeachingCaseRelaInfoEN.BrowseCount = TransNullToInt(objDT.Rows[0][convClsRmTeachingCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvClsRmTeachingCaseRelaInfoEN.ResourceOwner = objDT.Rows[0][convClsRmTeachingCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者(字段类型:varchar,字段长度:50,是否可空:False)
 objvClsRmTeachingCaseRelaInfoEN.ftpFileType = objDT.Rows[0][convClsRmTeachingCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvClsRmTeachingCaseRelaInfoEN.ftpFileSize = objDT.Rows[0][convClsRmTeachingCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvClsRmTeachingCaseRelaInfoEN.ftpResourceOwner = objDT.Rows[0][convClsRmTeachingCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者(字段类型:varchar,字段长度:50,是否可空:True)
 objvClsRmTeachingCaseRelaInfoEN.FileOriginName = objDT.Rows[0][convClsRmTeachingCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名(字段类型:varchar,字段长度:500,是否可空:True)
 objvClsRmTeachingCaseRelaInfoEN.IsExistFile = TransNullToBool(objDT.Rows[0][convClsRmTeachingCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objvClsRmTeachingCaseRelaInfoEN.Flag = objDT.Rows[0][convClsRmTeachingCaseRelaInfo.Flag].ToString().Trim(); //标志(字段类型:varchar,字段长度:50,是否可空:True)
 objvClsRmTeachingCaseRelaInfoEN.FuncModuleName = objDT.Rows[0][convClsRmTeachingCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvClsRmTeachingCaseRelaInfoEN.FuncModuleId = objDT.Rows[0][convClsRmTeachingCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvClsRmTeachingCaseRelaInfoEN.FileNewName = objDT.Rows[0][convClsRmTeachingCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvClsRmTeachingCaseRelaInfoEN.FileOldName = objDT.Rows[0][convClsRmTeachingCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvClsRmTeachingCaseRelaInfoEN.UpdDate = objDT.Rows[0][convClsRmTeachingCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvClsRmTeachingCaseRelaInfoEN.UpdUser = objDT.Rows[0][convClsRmTeachingCaseRelaInfo.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvClsRmTeachingCaseRelaInfoEN.Memo = objDT.Rows[0][convClsRmTeachingCaseRelaInfo.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvClsRmTeachingCaseRelaInfoDA: GetvClsRmTeachingCaseRelaInfo)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdMicroTeachCaseRelaInfo">表关键字</param>
 /// <returns>表对象</returns>
public clsvClsRmTeachingCaseRelaInfoEN GetObjByIdMicroTeachCaseRelaInfo(long lngIdMicroTeachCaseRelaInfo)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClsRmTeachingCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vClsRmTeachingCaseRelaInfo where IdMicroTeachCaseRelaInfo = " + ""+ lngIdMicroTeachCaseRelaInfo+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvClsRmTeachingCaseRelaInfoEN objvClsRmTeachingCaseRelaInfoEN = new clsvClsRmTeachingCaseRelaInfoEN();
try
{
 objvClsRmTeachingCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = Int32.Parse(objRow[convClsRmTeachingCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvClsRmTeachingCaseRelaInfoEN.IdMicroteachCase = objRow[convClsRmTeachingCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvClsRmTeachingCaseRelaInfoEN.IdClsRmTeachingCase = objRow[convClsRmTeachingCaseRelaInfo.IdClsRmTeachingCase] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.IdClsRmTeachingCase].ToString().Trim(); //课堂教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvClsRmTeachingCaseRelaInfoEN.ClsRmTeachingCaseName = objRow[convClsRmTeachingCaseRelaInfo.ClsRmTeachingCaseName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.ClsRmTeachingCaseName].ToString().Trim(); //课堂教学案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvClsRmTeachingCaseRelaInfoEN.IdResource = objRow[convClsRmTeachingCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objvClsRmTeachingCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvClsRmTeachingCaseRelaInfoEN.IdFile = objRow[convClsRmTeachingCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号(字段类型:char,字段长度:8,是否可空:True)
 objvClsRmTeachingCaseRelaInfoEN.FileName = objRow[convClsRmTeachingCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvClsRmTeachingCaseRelaInfoEN.FileType = objRow[convClsRmTeachingCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvClsRmTeachingCaseRelaInfoEN.SaveDate = objRow[convClsRmTeachingCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvClsRmTeachingCaseRelaInfoEN.FileSize = objRow[convClsRmTeachingCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FileSize].ToString().Trim(); //文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvClsRmTeachingCaseRelaInfoEN.SaveTime = objRow[convClsRmTeachingCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvClsRmTeachingCaseRelaInfoEN.IdFtpResource = objRow[convClsRmTeachingCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objvClsRmTeachingCaseRelaInfoEN.FtpResourceID = objRow[convClsRmTeachingCaseRelaInfo.FtpResourceID] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvClsRmTeachingCaseRelaInfoEN.FileOriginalName = objRow[convClsRmTeachingCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名(字段类型:varchar,字段长度:200,是否可空:True)
 objvClsRmTeachingCaseRelaInfoEN.FileDirName = objRow[convClsRmTeachingCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objvClsRmTeachingCaseRelaInfoEN.FileRename = objRow[convClsRmTeachingCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FileRename].ToString().Trim(); //文件新名(字段类型:varchar,字段长度:200,是否可空:True)
 objvClsRmTeachingCaseRelaInfoEN.FileUpDate = objRow[convClsRmTeachingCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvClsRmTeachingCaseRelaInfoEN.FileUpTime = objRow[convClsRmTeachingCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvClsRmTeachingCaseRelaInfoEN.ResourceID = objRow[convClsRmTeachingCaseRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvClsRmTeachingCaseRelaInfoEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式(字段类型:bit,字段长度:1,是否可空:True)
 objvClsRmTeachingCaseRelaInfoEN.IdResourceType = objRow[convClsRmTeachingCaseRelaInfo.IdResourceType] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvClsRmTeachingCaseRelaInfoEN.ResourceTypeID = objRow[convClsRmTeachingCaseRelaInfo.ResourceTypeID] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvClsRmTeachingCaseRelaInfoEN.ResourceTypeName = objRow[convClsRmTeachingCaseRelaInfo.ResourceTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvClsRmTeachingCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convClsRmTeachingCaseRelaInfo.IdMicroTeachCaseRelaInfoType] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvClsRmTeachingCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convClsRmTeachingCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvClsRmTeachingCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convClsRmTeachingCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvClsRmTeachingCaseRelaInfoEN.BrowseCount = objRow[convClsRmTeachingCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convClsRmTeachingCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvClsRmTeachingCaseRelaInfoEN.ResourceOwner = objRow[convClsRmTeachingCaseRelaInfo.ResourceOwner] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者(字段类型:varchar,字段长度:50,是否可空:False)
 objvClsRmTeachingCaseRelaInfoEN.ftpFileType = objRow[convClsRmTeachingCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvClsRmTeachingCaseRelaInfoEN.ftpFileSize = objRow[convClsRmTeachingCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvClsRmTeachingCaseRelaInfoEN.ftpResourceOwner = objRow[convClsRmTeachingCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者(字段类型:varchar,字段长度:50,是否可空:True)
 objvClsRmTeachingCaseRelaInfoEN.FileOriginName = objRow[convClsRmTeachingCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名(字段类型:varchar,字段长度:500,是否可空:True)
 objvClsRmTeachingCaseRelaInfoEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objvClsRmTeachingCaseRelaInfoEN.Flag = objRow[convClsRmTeachingCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.Flag].ToString().Trim(); //标志(字段类型:varchar,字段长度:50,是否可空:True)
 objvClsRmTeachingCaseRelaInfoEN.FuncModuleName = objRow[convClsRmTeachingCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvClsRmTeachingCaseRelaInfoEN.FuncModuleId = objRow[convClsRmTeachingCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvClsRmTeachingCaseRelaInfoEN.FileNewName = objRow[convClsRmTeachingCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvClsRmTeachingCaseRelaInfoEN.FileOldName = objRow[convClsRmTeachingCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvClsRmTeachingCaseRelaInfoEN.UpdDate = objRow[convClsRmTeachingCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvClsRmTeachingCaseRelaInfoEN.UpdUser = objRow[convClsRmTeachingCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvClsRmTeachingCaseRelaInfoEN.Memo = objRow[convClsRmTeachingCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvClsRmTeachingCaseRelaInfoDA: GetObjByIdMicroTeachCaseRelaInfo)", objException.Message));
}
return objvClsRmTeachingCaseRelaInfoEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvClsRmTeachingCaseRelaInfoEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvClsRmTeachingCaseRelaInfoDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClsRmTeachingCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vClsRmTeachingCaseRelaInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvClsRmTeachingCaseRelaInfoEN objvClsRmTeachingCaseRelaInfoEN = new clsvClsRmTeachingCaseRelaInfoEN()
{
IdMicroTeachCaseRelaInfo = TransNullToInt(objRow[convClsRmTeachingCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()), //案例相关信息流水号
IdMicroteachCase = objRow[convClsRmTeachingCaseRelaInfo.IdMicroteachCase].ToString().Trim(), //微格教学案例流水号
IdClsRmTeachingCase = objRow[convClsRmTeachingCaseRelaInfo.IdClsRmTeachingCase] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.IdClsRmTeachingCase].ToString().Trim(), //课堂教学案例流水号
ClsRmTeachingCaseName = objRow[convClsRmTeachingCaseRelaInfo.ClsRmTeachingCaseName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.ClsRmTeachingCaseName].ToString().Trim(), //课堂教学案例名称
IdResource = objRow[convClsRmTeachingCaseRelaInfo.IdResource].ToString().Trim(), //资源流水号
IsVisible = TransNullToBool(objRow[convClsRmTeachingCaseRelaInfo.IsVisible].ToString().Trim()), //是否显示
IdFile = objRow[convClsRmTeachingCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.IdFile].ToString().Trim(), //文件流水号
FileName = objRow[convClsRmTeachingCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FileName].ToString().Trim(), //文件名称
FileType = objRow[convClsRmTeachingCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FileType].ToString().Trim(), //文件类型
SaveDate = objRow[convClsRmTeachingCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.SaveDate].ToString().Trim(), //创建日期
FileSize = objRow[convClsRmTeachingCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FileSize].ToString().Trim(), //文件大小
SaveTime = objRow[convClsRmTeachingCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.SaveTime].ToString().Trim(), //创建时间
IdFtpResource = objRow[convClsRmTeachingCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.IdFtpResource].ToString().Trim(), //FTP资源流水号
FtpResourceID = objRow[convClsRmTeachingCaseRelaInfo.FtpResourceID] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FtpResourceID].ToString().Trim(), //FTP资源ID
FileOriginalName = objRow[convClsRmTeachingCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FileOriginalName].ToString().Trim(), //文件原名
FileDirName = objRow[convClsRmTeachingCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FileDirName].ToString().Trim(), //文件目录名
FileRename = objRow[convClsRmTeachingCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FileRename].ToString().Trim(), //文件新名
FileUpDate = objRow[convClsRmTeachingCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FileUpDate].ToString().Trim(), //创建日期
FileUpTime = objRow[convClsRmTeachingCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FileUpTime].ToString().Trim(), //创建时间
ResourceID = objRow[convClsRmTeachingCaseRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.ResourceID].ToString().Trim(), //资源ID
SaveMode = TransNullToBool(objRow[convClsRmTeachingCaseRelaInfo.SaveMode].ToString().Trim()), //文件存放方式
IdResourceType = objRow[convClsRmTeachingCaseRelaInfo.IdResourceType] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.IdResourceType].ToString().Trim(), //资源类型流水号
ResourceTypeID = objRow[convClsRmTeachingCaseRelaInfo.ResourceTypeID] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.ResourceTypeID].ToString().Trim(), //资源类型ID
ResourceTypeName = objRow[convClsRmTeachingCaseRelaInfo.ResourceTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.ResourceTypeName].ToString().Trim(), //资源类型名称
IdMicroTeachCaseRelaInfoType = objRow[convClsRmTeachingCaseRelaInfo.IdMicroTeachCaseRelaInfoType] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(), //微格案例相关信息类型流水号
MicroTeachCaseRelaInfoTypeID = objRow[convClsRmTeachingCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(), //微格案例相关信息类型ID
MicroTeachCaseRelaInfoTypeName = objRow[convClsRmTeachingCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(), //微格案例相关信息类型名称
BrowseCount = objRow[convClsRmTeachingCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convClsRmTeachingCaseRelaInfo.BrowseCount].ToString().Trim()), //浏览次数
ResourceOwner = objRow[convClsRmTeachingCaseRelaInfo.ResourceOwner] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.ResourceOwner].ToString().Trim(), //上传者
ftpFileType = objRow[convClsRmTeachingCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.ftpFileType].ToString().Trim(), //ftp文件类型
ftpFileSize = objRow[convClsRmTeachingCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.ftpFileSize].ToString().Trim(), //ftp文件大小
ftpResourceOwner = objRow[convClsRmTeachingCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.ftpResourceOwner].ToString().Trim(), //Ftp资源拥有者
FileOriginName = objRow[convClsRmTeachingCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FileOriginName].ToString().Trim(), //原文件名
IsExistFile = TransNullToBool(objRow[convClsRmTeachingCaseRelaInfo.IsExistFile].ToString().Trim()), //是否存在文件
Flag = objRow[convClsRmTeachingCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.Flag].ToString().Trim(), //标志
FuncModuleName = objRow[convClsRmTeachingCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FuncModuleName].ToString().Trim(), //功能模块名称
FuncModuleId = objRow[convClsRmTeachingCaseRelaInfo.FuncModuleId].ToString().Trim(), //功能模块Id
FileNewName = objRow[convClsRmTeachingCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FileNewName].ToString().Trim(), //新文件名
FileOldName = objRow[convClsRmTeachingCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FileOldName].ToString().Trim(), //旧文件名
UpdDate = objRow[convClsRmTeachingCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convClsRmTeachingCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convClsRmTeachingCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.Memo].ToString().Trim() //备注
};
objvClsRmTeachingCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvClsRmTeachingCaseRelaInfoEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvClsRmTeachingCaseRelaInfoDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvClsRmTeachingCaseRelaInfoEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvClsRmTeachingCaseRelaInfoEN objvClsRmTeachingCaseRelaInfoEN = new clsvClsRmTeachingCaseRelaInfoEN();
try
{
objvClsRmTeachingCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = TransNullToInt(objRow[convClsRmTeachingCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvClsRmTeachingCaseRelaInfoEN.IdMicroteachCase = objRow[convClsRmTeachingCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvClsRmTeachingCaseRelaInfoEN.IdClsRmTeachingCase = objRow[convClsRmTeachingCaseRelaInfo.IdClsRmTeachingCase] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.IdClsRmTeachingCase].ToString().Trim(); //课堂教学案例流水号
objvClsRmTeachingCaseRelaInfoEN.ClsRmTeachingCaseName = objRow[convClsRmTeachingCaseRelaInfo.ClsRmTeachingCaseName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.ClsRmTeachingCaseName].ToString().Trim(); //课堂教学案例名称
objvClsRmTeachingCaseRelaInfoEN.IdResource = objRow[convClsRmTeachingCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvClsRmTeachingCaseRelaInfoEN.IsVisible = TransNullToBool(objRow[convClsRmTeachingCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvClsRmTeachingCaseRelaInfoEN.IdFile = objRow[convClsRmTeachingCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvClsRmTeachingCaseRelaInfoEN.FileName = objRow[convClsRmTeachingCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvClsRmTeachingCaseRelaInfoEN.FileType = objRow[convClsRmTeachingCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvClsRmTeachingCaseRelaInfoEN.SaveDate = objRow[convClsRmTeachingCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvClsRmTeachingCaseRelaInfoEN.FileSize = objRow[convClsRmTeachingCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvClsRmTeachingCaseRelaInfoEN.SaveTime = objRow[convClsRmTeachingCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvClsRmTeachingCaseRelaInfoEN.IdFtpResource = objRow[convClsRmTeachingCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvClsRmTeachingCaseRelaInfoEN.FtpResourceID = objRow[convClsRmTeachingCaseRelaInfo.FtpResourceID] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvClsRmTeachingCaseRelaInfoEN.FileOriginalName = objRow[convClsRmTeachingCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvClsRmTeachingCaseRelaInfoEN.FileDirName = objRow[convClsRmTeachingCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvClsRmTeachingCaseRelaInfoEN.FileRename = objRow[convClsRmTeachingCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvClsRmTeachingCaseRelaInfoEN.FileUpDate = objRow[convClsRmTeachingCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvClsRmTeachingCaseRelaInfoEN.FileUpTime = objRow[convClsRmTeachingCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvClsRmTeachingCaseRelaInfoEN.ResourceID = objRow[convClsRmTeachingCaseRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvClsRmTeachingCaseRelaInfoEN.SaveMode = TransNullToBool(objRow[convClsRmTeachingCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvClsRmTeachingCaseRelaInfoEN.IdResourceType = objRow[convClsRmTeachingCaseRelaInfo.IdResourceType] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvClsRmTeachingCaseRelaInfoEN.ResourceTypeID = objRow[convClsRmTeachingCaseRelaInfo.ResourceTypeID] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvClsRmTeachingCaseRelaInfoEN.ResourceTypeName = objRow[convClsRmTeachingCaseRelaInfo.ResourceTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvClsRmTeachingCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convClsRmTeachingCaseRelaInfo.IdMicroTeachCaseRelaInfoType] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvClsRmTeachingCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convClsRmTeachingCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objvClsRmTeachingCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convClsRmTeachingCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvClsRmTeachingCaseRelaInfoEN.BrowseCount = objRow[convClsRmTeachingCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convClsRmTeachingCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvClsRmTeachingCaseRelaInfoEN.ResourceOwner = objRow[convClsRmTeachingCaseRelaInfo.ResourceOwner] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvClsRmTeachingCaseRelaInfoEN.ftpFileType = objRow[convClsRmTeachingCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvClsRmTeachingCaseRelaInfoEN.ftpFileSize = objRow[convClsRmTeachingCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvClsRmTeachingCaseRelaInfoEN.ftpResourceOwner = objRow[convClsRmTeachingCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvClsRmTeachingCaseRelaInfoEN.FileOriginName = objRow[convClsRmTeachingCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvClsRmTeachingCaseRelaInfoEN.IsExistFile = TransNullToBool(objRow[convClsRmTeachingCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvClsRmTeachingCaseRelaInfoEN.Flag = objRow[convClsRmTeachingCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.Flag].ToString().Trim(); //标志
objvClsRmTeachingCaseRelaInfoEN.FuncModuleName = objRow[convClsRmTeachingCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvClsRmTeachingCaseRelaInfoEN.FuncModuleId = objRow[convClsRmTeachingCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvClsRmTeachingCaseRelaInfoEN.FileNewName = objRow[convClsRmTeachingCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvClsRmTeachingCaseRelaInfoEN.FileOldName = objRow[convClsRmTeachingCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvClsRmTeachingCaseRelaInfoEN.UpdDate = objRow[convClsRmTeachingCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvClsRmTeachingCaseRelaInfoEN.UpdUser = objRow[convClsRmTeachingCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objvClsRmTeachingCaseRelaInfoEN.Memo = objRow[convClsRmTeachingCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvClsRmTeachingCaseRelaInfoDA: GetObjByDataRowvClsRmTeachingCaseRelaInfo)", objException.Message));
}
objvClsRmTeachingCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvClsRmTeachingCaseRelaInfoEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvClsRmTeachingCaseRelaInfoEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvClsRmTeachingCaseRelaInfoEN objvClsRmTeachingCaseRelaInfoEN = new clsvClsRmTeachingCaseRelaInfoEN();
try
{
objvClsRmTeachingCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = TransNullToInt(objRow[convClsRmTeachingCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvClsRmTeachingCaseRelaInfoEN.IdMicroteachCase = objRow[convClsRmTeachingCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvClsRmTeachingCaseRelaInfoEN.IdClsRmTeachingCase = objRow[convClsRmTeachingCaseRelaInfo.IdClsRmTeachingCase] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.IdClsRmTeachingCase].ToString().Trim(); //课堂教学案例流水号
objvClsRmTeachingCaseRelaInfoEN.ClsRmTeachingCaseName = objRow[convClsRmTeachingCaseRelaInfo.ClsRmTeachingCaseName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.ClsRmTeachingCaseName].ToString().Trim(); //课堂教学案例名称
objvClsRmTeachingCaseRelaInfoEN.IdResource = objRow[convClsRmTeachingCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvClsRmTeachingCaseRelaInfoEN.IsVisible = TransNullToBool(objRow[convClsRmTeachingCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvClsRmTeachingCaseRelaInfoEN.IdFile = objRow[convClsRmTeachingCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvClsRmTeachingCaseRelaInfoEN.FileName = objRow[convClsRmTeachingCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvClsRmTeachingCaseRelaInfoEN.FileType = objRow[convClsRmTeachingCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvClsRmTeachingCaseRelaInfoEN.SaveDate = objRow[convClsRmTeachingCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvClsRmTeachingCaseRelaInfoEN.FileSize = objRow[convClsRmTeachingCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvClsRmTeachingCaseRelaInfoEN.SaveTime = objRow[convClsRmTeachingCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvClsRmTeachingCaseRelaInfoEN.IdFtpResource = objRow[convClsRmTeachingCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvClsRmTeachingCaseRelaInfoEN.FtpResourceID = objRow[convClsRmTeachingCaseRelaInfo.FtpResourceID] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvClsRmTeachingCaseRelaInfoEN.FileOriginalName = objRow[convClsRmTeachingCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvClsRmTeachingCaseRelaInfoEN.FileDirName = objRow[convClsRmTeachingCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvClsRmTeachingCaseRelaInfoEN.FileRename = objRow[convClsRmTeachingCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvClsRmTeachingCaseRelaInfoEN.FileUpDate = objRow[convClsRmTeachingCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvClsRmTeachingCaseRelaInfoEN.FileUpTime = objRow[convClsRmTeachingCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvClsRmTeachingCaseRelaInfoEN.ResourceID = objRow[convClsRmTeachingCaseRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvClsRmTeachingCaseRelaInfoEN.SaveMode = TransNullToBool(objRow[convClsRmTeachingCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvClsRmTeachingCaseRelaInfoEN.IdResourceType = objRow[convClsRmTeachingCaseRelaInfo.IdResourceType] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvClsRmTeachingCaseRelaInfoEN.ResourceTypeID = objRow[convClsRmTeachingCaseRelaInfo.ResourceTypeID] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvClsRmTeachingCaseRelaInfoEN.ResourceTypeName = objRow[convClsRmTeachingCaseRelaInfo.ResourceTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvClsRmTeachingCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convClsRmTeachingCaseRelaInfo.IdMicroTeachCaseRelaInfoType] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvClsRmTeachingCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convClsRmTeachingCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objvClsRmTeachingCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convClsRmTeachingCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvClsRmTeachingCaseRelaInfoEN.BrowseCount = objRow[convClsRmTeachingCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convClsRmTeachingCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvClsRmTeachingCaseRelaInfoEN.ResourceOwner = objRow[convClsRmTeachingCaseRelaInfo.ResourceOwner] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvClsRmTeachingCaseRelaInfoEN.ftpFileType = objRow[convClsRmTeachingCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvClsRmTeachingCaseRelaInfoEN.ftpFileSize = objRow[convClsRmTeachingCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvClsRmTeachingCaseRelaInfoEN.ftpResourceOwner = objRow[convClsRmTeachingCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvClsRmTeachingCaseRelaInfoEN.FileOriginName = objRow[convClsRmTeachingCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvClsRmTeachingCaseRelaInfoEN.IsExistFile = TransNullToBool(objRow[convClsRmTeachingCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvClsRmTeachingCaseRelaInfoEN.Flag = objRow[convClsRmTeachingCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.Flag].ToString().Trim(); //标志
objvClsRmTeachingCaseRelaInfoEN.FuncModuleName = objRow[convClsRmTeachingCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvClsRmTeachingCaseRelaInfoEN.FuncModuleId = objRow[convClsRmTeachingCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvClsRmTeachingCaseRelaInfoEN.FileNewName = objRow[convClsRmTeachingCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvClsRmTeachingCaseRelaInfoEN.FileOldName = objRow[convClsRmTeachingCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvClsRmTeachingCaseRelaInfoEN.UpdDate = objRow[convClsRmTeachingCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvClsRmTeachingCaseRelaInfoEN.UpdUser = objRow[convClsRmTeachingCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objvClsRmTeachingCaseRelaInfoEN.Memo = objRow[convClsRmTeachingCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convClsRmTeachingCaseRelaInfo.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvClsRmTeachingCaseRelaInfoDA: GetObjByDataRow)", objException.Message));
}
objvClsRmTeachingCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvClsRmTeachingCaseRelaInfoEN;
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
objSQL = clsvClsRmTeachingCaseRelaInfoDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvClsRmTeachingCaseRelaInfoEN._CurrTabName, convClsRmTeachingCaseRelaInfo.IdMicroTeachCaseRelaInfo, 8, "");
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
objSQL = clsvClsRmTeachingCaseRelaInfoDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvClsRmTeachingCaseRelaInfoEN._CurrTabName, convClsRmTeachingCaseRelaInfo.IdMicroTeachCaseRelaInfo, 8, strPrefix);
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
 objSQL = clsvClsRmTeachingCaseRelaInfoDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdMicroTeachCaseRelaInfo from vClsRmTeachingCaseRelaInfo where " + strCondition;
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
 objSQL = clsvClsRmTeachingCaseRelaInfoDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdMicroTeachCaseRelaInfo from vClsRmTeachingCaseRelaInfo where " + strCondition;
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
 objSQL = clsvClsRmTeachingCaseRelaInfoDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vClsRmTeachingCaseRelaInfo", "IdMicroTeachCaseRelaInfo = " + ""+ lngIdMicroTeachCaseRelaInfo+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvClsRmTeachingCaseRelaInfoDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClsRmTeachingCaseRelaInfoDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vClsRmTeachingCaseRelaInfo", strCondition))
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
objSQL = clsvClsRmTeachingCaseRelaInfoDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vClsRmTeachingCaseRelaInfo");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseRelaInfoENS">源对象</param>
 /// <param name = "objvClsRmTeachingCaseRelaInfoENT">目标对象</param>
public void CopyTo(clsvClsRmTeachingCaseRelaInfoEN objvClsRmTeachingCaseRelaInfoENS, clsvClsRmTeachingCaseRelaInfoEN objvClsRmTeachingCaseRelaInfoENT)
{
objvClsRmTeachingCaseRelaInfoENT.IdMicroTeachCaseRelaInfo = objvClsRmTeachingCaseRelaInfoENS.IdMicroTeachCaseRelaInfo; //案例相关信息流水号
objvClsRmTeachingCaseRelaInfoENT.IdMicroteachCase = objvClsRmTeachingCaseRelaInfoENS.IdMicroteachCase; //微格教学案例流水号
objvClsRmTeachingCaseRelaInfoENT.IdClsRmTeachingCase = objvClsRmTeachingCaseRelaInfoENS.IdClsRmTeachingCase; //课堂教学案例流水号
objvClsRmTeachingCaseRelaInfoENT.ClsRmTeachingCaseName = objvClsRmTeachingCaseRelaInfoENS.ClsRmTeachingCaseName; //课堂教学案例名称
objvClsRmTeachingCaseRelaInfoENT.IdResource = objvClsRmTeachingCaseRelaInfoENS.IdResource; //资源流水号
objvClsRmTeachingCaseRelaInfoENT.IsVisible = objvClsRmTeachingCaseRelaInfoENS.IsVisible; //是否显示
objvClsRmTeachingCaseRelaInfoENT.IdFile = objvClsRmTeachingCaseRelaInfoENS.IdFile; //文件流水号
objvClsRmTeachingCaseRelaInfoENT.FileName = objvClsRmTeachingCaseRelaInfoENS.FileName; //文件名称
objvClsRmTeachingCaseRelaInfoENT.FileType = objvClsRmTeachingCaseRelaInfoENS.FileType; //文件类型
objvClsRmTeachingCaseRelaInfoENT.SaveDate = objvClsRmTeachingCaseRelaInfoENS.SaveDate; //创建日期
objvClsRmTeachingCaseRelaInfoENT.FileSize = objvClsRmTeachingCaseRelaInfoENS.FileSize; //文件大小
objvClsRmTeachingCaseRelaInfoENT.SaveTime = objvClsRmTeachingCaseRelaInfoENS.SaveTime; //创建时间
objvClsRmTeachingCaseRelaInfoENT.IdFtpResource = objvClsRmTeachingCaseRelaInfoENS.IdFtpResource; //FTP资源流水号
objvClsRmTeachingCaseRelaInfoENT.FtpResourceID = objvClsRmTeachingCaseRelaInfoENS.FtpResourceID; //FTP资源ID
objvClsRmTeachingCaseRelaInfoENT.FileOriginalName = objvClsRmTeachingCaseRelaInfoENS.FileOriginalName; //文件原名
objvClsRmTeachingCaseRelaInfoENT.FileDirName = objvClsRmTeachingCaseRelaInfoENS.FileDirName; //文件目录名
objvClsRmTeachingCaseRelaInfoENT.FileRename = objvClsRmTeachingCaseRelaInfoENS.FileRename; //文件新名
objvClsRmTeachingCaseRelaInfoENT.FileUpDate = objvClsRmTeachingCaseRelaInfoENS.FileUpDate; //创建日期
objvClsRmTeachingCaseRelaInfoENT.FileUpTime = objvClsRmTeachingCaseRelaInfoENS.FileUpTime; //创建时间
objvClsRmTeachingCaseRelaInfoENT.ResourceID = objvClsRmTeachingCaseRelaInfoENS.ResourceID; //资源ID
objvClsRmTeachingCaseRelaInfoENT.SaveMode = objvClsRmTeachingCaseRelaInfoENS.SaveMode; //文件存放方式
objvClsRmTeachingCaseRelaInfoENT.IdResourceType = objvClsRmTeachingCaseRelaInfoENS.IdResourceType; //资源类型流水号
objvClsRmTeachingCaseRelaInfoENT.ResourceTypeID = objvClsRmTeachingCaseRelaInfoENS.ResourceTypeID; //资源类型ID
objvClsRmTeachingCaseRelaInfoENT.ResourceTypeName = objvClsRmTeachingCaseRelaInfoENS.ResourceTypeName; //资源类型名称
objvClsRmTeachingCaseRelaInfoENT.IdMicroTeachCaseRelaInfoType = objvClsRmTeachingCaseRelaInfoENS.IdMicroTeachCaseRelaInfoType; //微格案例相关信息类型流水号
objvClsRmTeachingCaseRelaInfoENT.MicroTeachCaseRelaInfoTypeID = objvClsRmTeachingCaseRelaInfoENS.MicroTeachCaseRelaInfoTypeID; //微格案例相关信息类型ID
objvClsRmTeachingCaseRelaInfoENT.MicroTeachCaseRelaInfoTypeName = objvClsRmTeachingCaseRelaInfoENS.MicroTeachCaseRelaInfoTypeName; //微格案例相关信息类型名称
objvClsRmTeachingCaseRelaInfoENT.BrowseCount = objvClsRmTeachingCaseRelaInfoENS.BrowseCount; //浏览次数
objvClsRmTeachingCaseRelaInfoENT.ResourceOwner = objvClsRmTeachingCaseRelaInfoENS.ResourceOwner; //上传者
objvClsRmTeachingCaseRelaInfoENT.ftpFileType = objvClsRmTeachingCaseRelaInfoENS.ftpFileType; //ftp文件类型
objvClsRmTeachingCaseRelaInfoENT.ftpFileSize = objvClsRmTeachingCaseRelaInfoENS.ftpFileSize; //ftp文件大小
objvClsRmTeachingCaseRelaInfoENT.ftpResourceOwner = objvClsRmTeachingCaseRelaInfoENS.ftpResourceOwner; //Ftp资源拥有者
objvClsRmTeachingCaseRelaInfoENT.FileOriginName = objvClsRmTeachingCaseRelaInfoENS.FileOriginName; //原文件名
objvClsRmTeachingCaseRelaInfoENT.IsExistFile = objvClsRmTeachingCaseRelaInfoENS.IsExistFile; //是否存在文件
objvClsRmTeachingCaseRelaInfoENT.Flag = objvClsRmTeachingCaseRelaInfoENS.Flag; //标志
objvClsRmTeachingCaseRelaInfoENT.FuncModuleName = objvClsRmTeachingCaseRelaInfoENS.FuncModuleName; //功能模块名称
objvClsRmTeachingCaseRelaInfoENT.FuncModuleId = objvClsRmTeachingCaseRelaInfoENS.FuncModuleId; //功能模块Id
objvClsRmTeachingCaseRelaInfoENT.FileNewName = objvClsRmTeachingCaseRelaInfoENS.FileNewName; //新文件名
objvClsRmTeachingCaseRelaInfoENT.FileOldName = objvClsRmTeachingCaseRelaInfoENS.FileOldName; //旧文件名
objvClsRmTeachingCaseRelaInfoENT.UpdDate = objvClsRmTeachingCaseRelaInfoENS.UpdDate; //修改日期
objvClsRmTeachingCaseRelaInfoENT.UpdUser = objvClsRmTeachingCaseRelaInfoENS.UpdUser; //修改人
objvClsRmTeachingCaseRelaInfoENT.Memo = objvClsRmTeachingCaseRelaInfoENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvClsRmTeachingCaseRelaInfoEN objvClsRmTeachingCaseRelaInfoEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseRelaInfoEN.IdMicroteachCase, 8, convClsRmTeachingCaseRelaInfo.IdMicroteachCase);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseRelaInfoEN.IdClsRmTeachingCase, 8, convClsRmTeachingCaseRelaInfo.IdClsRmTeachingCase);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseRelaInfoEN.ClsRmTeachingCaseName, 100, convClsRmTeachingCaseRelaInfo.ClsRmTeachingCaseName);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseRelaInfoEN.IdResource, 8, convClsRmTeachingCaseRelaInfo.IdResource);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseRelaInfoEN.IdFile, 8, convClsRmTeachingCaseRelaInfo.IdFile);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseRelaInfoEN.FileName, 500, convClsRmTeachingCaseRelaInfo.FileName);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseRelaInfoEN.FileType, 30, convClsRmTeachingCaseRelaInfo.FileType);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseRelaInfoEN.SaveDate, 8, convClsRmTeachingCaseRelaInfo.SaveDate);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseRelaInfoEN.FileSize, 50, convClsRmTeachingCaseRelaInfo.FileSize);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseRelaInfoEN.SaveTime, 6, convClsRmTeachingCaseRelaInfo.SaveTime);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseRelaInfoEN.IdFtpResource, 8, convClsRmTeachingCaseRelaInfo.IdFtpResource);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseRelaInfoEN.FtpResourceID, 8, convClsRmTeachingCaseRelaInfo.FtpResourceID);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseRelaInfoEN.FileOriginalName, 200, convClsRmTeachingCaseRelaInfo.FileOriginalName);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseRelaInfoEN.FileDirName, 200, convClsRmTeachingCaseRelaInfo.FileDirName);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseRelaInfoEN.FileRename, 200, convClsRmTeachingCaseRelaInfo.FileRename);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseRelaInfoEN.FileUpDate, 8, convClsRmTeachingCaseRelaInfo.FileUpDate);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseRelaInfoEN.FileUpTime, 6, convClsRmTeachingCaseRelaInfo.FileUpTime);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseRelaInfoEN.ResourceID, 8, convClsRmTeachingCaseRelaInfo.ResourceID);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseRelaInfoEN.IdResourceType, 4, convClsRmTeachingCaseRelaInfo.IdResourceType);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseRelaInfoEN.ResourceTypeID, 4, convClsRmTeachingCaseRelaInfo.ResourceTypeID);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseRelaInfoEN.ResourceTypeName, 50, convClsRmTeachingCaseRelaInfo.ResourceTypeName);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType, 4, convClsRmTeachingCaseRelaInfo.IdMicroTeachCaseRelaInfoType);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID, 4, convClsRmTeachingCaseRelaInfo.MicroTeachCaseRelaInfoTypeID);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName, 50, convClsRmTeachingCaseRelaInfo.MicroTeachCaseRelaInfoTypeName);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseRelaInfoEN.ResourceOwner, 50, convClsRmTeachingCaseRelaInfo.ResourceOwner);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseRelaInfoEN.ftpFileType, 30, convClsRmTeachingCaseRelaInfo.ftpFileType);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseRelaInfoEN.ftpFileSize, 50, convClsRmTeachingCaseRelaInfo.ftpFileSize);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseRelaInfoEN.ftpResourceOwner, 50, convClsRmTeachingCaseRelaInfo.ftpResourceOwner);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseRelaInfoEN.FileOriginName, 500, convClsRmTeachingCaseRelaInfo.FileOriginName);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseRelaInfoEN.Flag, 50, convClsRmTeachingCaseRelaInfo.Flag);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseRelaInfoEN.FuncModuleName, 30, convClsRmTeachingCaseRelaInfo.FuncModuleName);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseRelaInfoEN.FuncModuleId, 4, convClsRmTeachingCaseRelaInfo.FuncModuleId);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseRelaInfoEN.FileNewName, 530, convClsRmTeachingCaseRelaInfo.FileNewName);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseRelaInfoEN.FileOldName, 530, convClsRmTeachingCaseRelaInfo.FileOldName);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseRelaInfoEN.UpdDate, 20, convClsRmTeachingCaseRelaInfo.UpdDate);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseRelaInfoEN.UpdUser, 20, convClsRmTeachingCaseRelaInfo.UpdUser);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseRelaInfoEN.Memo, 1000, convClsRmTeachingCaseRelaInfo.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseRelaInfoEN.IdMicroteachCase, convClsRmTeachingCaseRelaInfo.IdMicroteachCase);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseRelaInfoEN.IdClsRmTeachingCase, convClsRmTeachingCaseRelaInfo.IdClsRmTeachingCase);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseRelaInfoEN.ClsRmTeachingCaseName, convClsRmTeachingCaseRelaInfo.ClsRmTeachingCaseName);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseRelaInfoEN.IdResource, convClsRmTeachingCaseRelaInfo.IdResource);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseRelaInfoEN.IdFile, convClsRmTeachingCaseRelaInfo.IdFile);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseRelaInfoEN.FileName, convClsRmTeachingCaseRelaInfo.FileName);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseRelaInfoEN.FileType, convClsRmTeachingCaseRelaInfo.FileType);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseRelaInfoEN.SaveDate, convClsRmTeachingCaseRelaInfo.SaveDate);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseRelaInfoEN.FileSize, convClsRmTeachingCaseRelaInfo.FileSize);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseRelaInfoEN.SaveTime, convClsRmTeachingCaseRelaInfo.SaveTime);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseRelaInfoEN.IdFtpResource, convClsRmTeachingCaseRelaInfo.IdFtpResource);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseRelaInfoEN.FtpResourceID, convClsRmTeachingCaseRelaInfo.FtpResourceID);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseRelaInfoEN.FileOriginalName, convClsRmTeachingCaseRelaInfo.FileOriginalName);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseRelaInfoEN.FileDirName, convClsRmTeachingCaseRelaInfo.FileDirName);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseRelaInfoEN.FileRename, convClsRmTeachingCaseRelaInfo.FileRename);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseRelaInfoEN.FileUpDate, convClsRmTeachingCaseRelaInfo.FileUpDate);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseRelaInfoEN.FileUpTime, convClsRmTeachingCaseRelaInfo.FileUpTime);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseRelaInfoEN.ResourceID, convClsRmTeachingCaseRelaInfo.ResourceID);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseRelaInfoEN.IdResourceType, convClsRmTeachingCaseRelaInfo.IdResourceType);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseRelaInfoEN.ResourceTypeID, convClsRmTeachingCaseRelaInfo.ResourceTypeID);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseRelaInfoEN.ResourceTypeName, convClsRmTeachingCaseRelaInfo.ResourceTypeName);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType, convClsRmTeachingCaseRelaInfo.IdMicroTeachCaseRelaInfoType);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID, convClsRmTeachingCaseRelaInfo.MicroTeachCaseRelaInfoTypeID);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName, convClsRmTeachingCaseRelaInfo.MicroTeachCaseRelaInfoTypeName);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseRelaInfoEN.ResourceOwner, convClsRmTeachingCaseRelaInfo.ResourceOwner);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseRelaInfoEN.ftpFileType, convClsRmTeachingCaseRelaInfo.ftpFileType);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseRelaInfoEN.ftpFileSize, convClsRmTeachingCaseRelaInfo.ftpFileSize);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseRelaInfoEN.ftpResourceOwner, convClsRmTeachingCaseRelaInfo.ftpResourceOwner);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseRelaInfoEN.FileOriginName, convClsRmTeachingCaseRelaInfo.FileOriginName);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseRelaInfoEN.Flag, convClsRmTeachingCaseRelaInfo.Flag);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseRelaInfoEN.FuncModuleName, convClsRmTeachingCaseRelaInfo.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseRelaInfoEN.FuncModuleId, convClsRmTeachingCaseRelaInfo.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseRelaInfoEN.FileNewName, convClsRmTeachingCaseRelaInfo.FileNewName);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseRelaInfoEN.FileOldName, convClsRmTeachingCaseRelaInfo.FileOldName);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseRelaInfoEN.UpdDate, convClsRmTeachingCaseRelaInfo.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseRelaInfoEN.UpdUser, convClsRmTeachingCaseRelaInfo.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseRelaInfoEN.Memo, convClsRmTeachingCaseRelaInfo.Memo);
//检查外键字段长度
 objvClsRmTeachingCaseRelaInfoEN._IsCheckProperty = true;
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
 objSQL = clsvClsRmTeachingCaseRelaInfoDA.GetSpecSQLObj();
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
 objSQL = clsvClsRmTeachingCaseRelaInfoDA.GetSpecSQLObj();
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
 objSQL = clsvClsRmTeachingCaseRelaInfoDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvClsRmTeachingCaseRelaInfoEN._CurrTabName);
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
 objSQL = clsvClsRmTeachingCaseRelaInfoDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvClsRmTeachingCaseRelaInfoEN._CurrTabName, strCondition);
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
 objSQL = clsvClsRmTeachingCaseRelaInfoDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}