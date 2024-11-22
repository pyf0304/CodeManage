
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvBrowseInfoStatistDA
 表名:vBrowseInfoStatist(01120470)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:44:30
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:实习记录(PracticeRecord)
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
 /// v浏览信息统计(vBrowseInfoStatist)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvBrowseInfoStatistDA : clsCommBase4DA
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
 return clsvBrowseInfoStatistEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvBrowseInfoStatistEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvBrowseInfoStatistEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvBrowseInfoStatistEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvBrowseInfoStatistEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvBrowseInfoStatistDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvBrowseInfoStatistDA.GetSpecSQLObj();
strSQL = "Select * from vBrowseInfoStatist where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vBrowseInfoStatist(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvBrowseInfoStatistDA: GetDataTable_vBrowseInfoStatist)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvBrowseInfoStatistDA.GetSpecSQLObj();
strSQL = "Select * from vBrowseInfoStatist where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvBrowseInfoStatistDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvBrowseInfoStatistDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvBrowseInfoStatistDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvBrowseInfoStatistDA.GetSpecSQLObj();
strSQL = "Select * from vBrowseInfoStatist where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvBrowseInfoStatistDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvBrowseInfoStatistDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvBrowseInfoStatistDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvBrowseInfoStatistDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vBrowseInfoStatist where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vBrowseInfoStatist where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvBrowseInfoStatistDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvBrowseInfoStatistDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vBrowseInfoStatist where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvBrowseInfoStatistDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvBrowseInfoStatistDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vBrowseInfoStatist.* from vBrowseInfoStatist Left Join {1} on {2} where {3} and vBrowseInfoStatist.IdBrowseInfoStatist not in (Select top {5} vBrowseInfoStatist.IdBrowseInfoStatist from vBrowseInfoStatist Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vBrowseInfoStatist where {1} and IdBrowseInfoStatist not in (Select top {2} IdBrowseInfoStatist from vBrowseInfoStatist where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vBrowseInfoStatist where {1} and IdBrowseInfoStatist not in (Select top {3} IdBrowseInfoStatist from vBrowseInfoStatist where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvBrowseInfoStatistDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvBrowseInfoStatistDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vBrowseInfoStatist.* from vBrowseInfoStatist Left Join {1} on {2} where {3} and vBrowseInfoStatist.IdBrowseInfoStatist not in (Select top {5} vBrowseInfoStatist.IdBrowseInfoStatist from vBrowseInfoStatist Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vBrowseInfoStatist where {1} and IdBrowseInfoStatist not in (Select top {2} IdBrowseInfoStatist from vBrowseInfoStatist where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vBrowseInfoStatist where {1} and IdBrowseInfoStatist not in (Select top {3} IdBrowseInfoStatist from vBrowseInfoStatist where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvBrowseInfoStatistEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvBrowseInfoStatistDA:GetObjLst)", objException.Message));
}
List<clsvBrowseInfoStatistEN> arrObjLst = new List<clsvBrowseInfoStatistEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvBrowseInfoStatistDA.GetSpecSQLObj();
strSQL = "Select * from vBrowseInfoStatist where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvBrowseInfoStatistEN objvBrowseInfoStatistEN = new clsvBrowseInfoStatistEN();
try
{
objvBrowseInfoStatistEN.IdBrowseInfoStatist = TransNullToInt(objRow[convBrowseInfoStatist.IdBrowseInfoStatist].ToString().Trim()); //浏览信息统计流水号
objvBrowseInfoStatistEN.SystemModuleName = objRow[convBrowseInfoStatist.SystemModuleName] == DBNull.Value ? null : objRow[convBrowseInfoStatist.SystemModuleName].ToString().Trim(); //系统模块名称
objvBrowseInfoStatistEN.IdUser = objRow[convBrowseInfoStatist.IdUser].ToString().Trim(); //id_User
objvBrowseInfoStatistEN.IdSystemModule = objRow[convBrowseInfoStatist.IdSystemModule].ToString().Trim(); //系统模块流水号
objvBrowseInfoStatistEN.ClassResourceID = objRow[convBrowseInfoStatist.ClassResourceID].ToString().Trim(); //资源流水号
objvBrowseInfoStatistEN.BrowseInfoStatistDate = objRow[convBrowseInfoStatist.BrowseInfoStatistDate] == DBNull.Value ? null : objRow[convBrowseInfoStatist.BrowseInfoStatistDate].ToString().Trim(); //浏览日期
objvBrowseInfoStatistEN.BrowseInfoStatistTime = objRow[convBrowseInfoStatist.BrowseInfoStatistTime] == DBNull.Value ? null : objRow[convBrowseInfoStatist.BrowseInfoStatistTime].ToString().Trim(); //浏览时间
objvBrowseInfoStatistEN.BrowseTypeId = objRow[convBrowseInfoStatist.BrowseTypeId] == DBNull.Value ? null : objRow[convBrowseInfoStatist.BrowseTypeId].ToString().Trim(); //BrowseTypeId
objvBrowseInfoStatistEN.BrowseSpendTime = objRow[convBrowseInfoStatist.BrowseSpendTime] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convBrowseInfoStatist.BrowseSpendTime].ToString().Trim()); //浏览花费时间
objvBrowseInfoStatistEN.BrowseTypeName = objRow[convBrowseInfoStatist.BrowseTypeName] == DBNull.Value ? null : objRow[convBrowseInfoStatist.BrowseTypeName].ToString().Trim(); //BrowseTypeName
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvBrowseInfoStatistDA: GetObjLst)", objException.Message));
}
objvBrowseInfoStatistEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvBrowseInfoStatistEN);
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
public List<clsvBrowseInfoStatistEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvBrowseInfoStatistDA:GetObjLstByTabName)", objException.Message));
}
List<clsvBrowseInfoStatistEN> arrObjLst = new List<clsvBrowseInfoStatistEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvBrowseInfoStatistDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvBrowseInfoStatistEN objvBrowseInfoStatistEN = new clsvBrowseInfoStatistEN();
try
{
objvBrowseInfoStatistEN.IdBrowseInfoStatist = TransNullToInt(objRow[convBrowseInfoStatist.IdBrowseInfoStatist].ToString().Trim()); //浏览信息统计流水号
objvBrowseInfoStatistEN.SystemModuleName = objRow[convBrowseInfoStatist.SystemModuleName] == DBNull.Value ? null : objRow[convBrowseInfoStatist.SystemModuleName].ToString().Trim(); //系统模块名称
objvBrowseInfoStatistEN.IdUser = objRow[convBrowseInfoStatist.IdUser].ToString().Trim(); //id_User
objvBrowseInfoStatistEN.IdSystemModule = objRow[convBrowseInfoStatist.IdSystemModule].ToString().Trim(); //系统模块流水号
objvBrowseInfoStatistEN.ClassResourceID = objRow[convBrowseInfoStatist.ClassResourceID].ToString().Trim(); //资源流水号
objvBrowseInfoStatistEN.BrowseInfoStatistDate = objRow[convBrowseInfoStatist.BrowseInfoStatistDate] == DBNull.Value ? null : objRow[convBrowseInfoStatist.BrowseInfoStatistDate].ToString().Trim(); //浏览日期
objvBrowseInfoStatistEN.BrowseInfoStatistTime = objRow[convBrowseInfoStatist.BrowseInfoStatistTime] == DBNull.Value ? null : objRow[convBrowseInfoStatist.BrowseInfoStatistTime].ToString().Trim(); //浏览时间
objvBrowseInfoStatistEN.BrowseTypeId = objRow[convBrowseInfoStatist.BrowseTypeId] == DBNull.Value ? null : objRow[convBrowseInfoStatist.BrowseTypeId].ToString().Trim(); //BrowseTypeId
objvBrowseInfoStatistEN.BrowseSpendTime = objRow[convBrowseInfoStatist.BrowseSpendTime] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convBrowseInfoStatist.BrowseSpendTime].ToString().Trim()); //浏览花费时间
objvBrowseInfoStatistEN.BrowseTypeName = objRow[convBrowseInfoStatist.BrowseTypeName] == DBNull.Value ? null : objRow[convBrowseInfoStatist.BrowseTypeName].ToString().Trim(); //BrowseTypeName
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvBrowseInfoStatistDA: GetObjLst)", objException.Message));
}
objvBrowseInfoStatistEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvBrowseInfoStatistEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvBrowseInfoStatistEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvBrowseInfoStatist(ref clsvBrowseInfoStatistEN objvBrowseInfoStatistEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvBrowseInfoStatistDA.GetSpecSQLObj();
strSQL = "Select * from vBrowseInfoStatist where IdBrowseInfoStatist = " + ""+ objvBrowseInfoStatistEN.IdBrowseInfoStatist+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvBrowseInfoStatistEN.IdBrowseInfoStatist = TransNullToInt(objDT.Rows[0][convBrowseInfoStatist.IdBrowseInfoStatist].ToString().Trim()); //浏览信息统计流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvBrowseInfoStatistEN.SystemModuleName = objDT.Rows[0][convBrowseInfoStatist.SystemModuleName].ToString().Trim(); //系统模块名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvBrowseInfoStatistEN.IdUser = objDT.Rows[0][convBrowseInfoStatist.IdUser].ToString().Trim(); //id_User(字段类型:char,字段长度:8,是否可空:True)
 objvBrowseInfoStatistEN.IdSystemModule = objDT.Rows[0][convBrowseInfoStatist.IdSystemModule].ToString().Trim(); //系统模块流水号(字段类型:char,字段长度:4,是否可空:False)
 objvBrowseInfoStatistEN.ClassResourceID = objDT.Rows[0][convBrowseInfoStatist.ClassResourceID].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objvBrowseInfoStatistEN.BrowseInfoStatistDate = objDT.Rows[0][convBrowseInfoStatist.BrowseInfoStatistDate].ToString().Trim(); //浏览日期(字段类型:char,字段长度:8,是否可空:True)
 objvBrowseInfoStatistEN.BrowseInfoStatistTime = objDT.Rows[0][convBrowseInfoStatist.BrowseInfoStatistTime].ToString().Trim(); //浏览时间(字段类型:char,字段长度:6,是否可空:True)
 objvBrowseInfoStatistEN.BrowseTypeId = objDT.Rows[0][convBrowseInfoStatist.BrowseTypeId].ToString().Trim(); //BrowseTypeId(字段类型:char,字段长度:4,是否可空:False)
 objvBrowseInfoStatistEN.BrowseSpendTime = TransNullToFloat(objDT.Rows[0][convBrowseInfoStatist.BrowseSpendTime].ToString().Trim()); //浏览花费时间(字段类型:float,字段长度:8,是否可空:True)
 objvBrowseInfoStatistEN.BrowseTypeName = objDT.Rows[0][convBrowseInfoStatist.BrowseTypeName].ToString().Trim(); //BrowseTypeName(字段类型:varchar,字段长度:100,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvBrowseInfoStatistDA: GetvBrowseInfoStatist)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdBrowseInfoStatist">表关键字</param>
 /// <returns>表对象</returns>
public clsvBrowseInfoStatistEN GetObjByIdBrowseInfoStatist(long lngIdBrowseInfoStatist)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvBrowseInfoStatistDA.GetSpecSQLObj();
strSQL = "Select * from vBrowseInfoStatist where IdBrowseInfoStatist = " + ""+ lngIdBrowseInfoStatist+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvBrowseInfoStatistEN objvBrowseInfoStatistEN = new clsvBrowseInfoStatistEN();
try
{
 objvBrowseInfoStatistEN.IdBrowseInfoStatist = Int32.Parse(objRow[convBrowseInfoStatist.IdBrowseInfoStatist].ToString().Trim()); //浏览信息统计流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvBrowseInfoStatistEN.SystemModuleName = objRow[convBrowseInfoStatist.SystemModuleName] == DBNull.Value ? null : objRow[convBrowseInfoStatist.SystemModuleName].ToString().Trim(); //系统模块名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvBrowseInfoStatistEN.IdUser = objRow[convBrowseInfoStatist.IdUser].ToString().Trim(); //id_User(字段类型:char,字段长度:8,是否可空:True)
 objvBrowseInfoStatistEN.IdSystemModule = objRow[convBrowseInfoStatist.IdSystemModule].ToString().Trim(); //系统模块流水号(字段类型:char,字段长度:4,是否可空:False)
 objvBrowseInfoStatistEN.ClassResourceID = objRow[convBrowseInfoStatist.ClassResourceID].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objvBrowseInfoStatistEN.BrowseInfoStatistDate = objRow[convBrowseInfoStatist.BrowseInfoStatistDate] == DBNull.Value ? null : objRow[convBrowseInfoStatist.BrowseInfoStatistDate].ToString().Trim(); //浏览日期(字段类型:char,字段长度:8,是否可空:True)
 objvBrowseInfoStatistEN.BrowseInfoStatistTime = objRow[convBrowseInfoStatist.BrowseInfoStatistTime] == DBNull.Value ? null : objRow[convBrowseInfoStatist.BrowseInfoStatistTime].ToString().Trim(); //浏览时间(字段类型:char,字段长度:6,是否可空:True)
 objvBrowseInfoStatistEN.BrowseTypeId = objRow[convBrowseInfoStatist.BrowseTypeId] == DBNull.Value ? null : objRow[convBrowseInfoStatist.BrowseTypeId].ToString().Trim(); //BrowseTypeId(字段类型:char,字段长度:4,是否可空:False)
 objvBrowseInfoStatistEN.BrowseSpendTime = objRow[convBrowseInfoStatist.BrowseSpendTime] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convBrowseInfoStatist.BrowseSpendTime].ToString().Trim()); //浏览花费时间(字段类型:float,字段长度:8,是否可空:True)
 objvBrowseInfoStatistEN.BrowseTypeName = objRow[convBrowseInfoStatist.BrowseTypeName] == DBNull.Value ? null : objRow[convBrowseInfoStatist.BrowseTypeName].ToString().Trim(); //BrowseTypeName(字段类型:varchar,字段长度:100,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvBrowseInfoStatistDA: GetObjByIdBrowseInfoStatist)", objException.Message));
}
return objvBrowseInfoStatistEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvBrowseInfoStatistEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvBrowseInfoStatistDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvBrowseInfoStatistDA.GetSpecSQLObj();
strSQL = "Select * from vBrowseInfoStatist where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvBrowseInfoStatistEN objvBrowseInfoStatistEN = new clsvBrowseInfoStatistEN()
{
IdBrowseInfoStatist = TransNullToInt(objRow[convBrowseInfoStatist.IdBrowseInfoStatist].ToString().Trim()), //浏览信息统计流水号
SystemModuleName = objRow[convBrowseInfoStatist.SystemModuleName] == DBNull.Value ? null : objRow[convBrowseInfoStatist.SystemModuleName].ToString().Trim(), //系统模块名称
IdUser = objRow[convBrowseInfoStatist.IdUser].ToString().Trim(), //id_User
IdSystemModule = objRow[convBrowseInfoStatist.IdSystemModule].ToString().Trim(), //系统模块流水号
ClassResourceID = objRow[convBrowseInfoStatist.ClassResourceID].ToString().Trim(), //资源流水号
BrowseInfoStatistDate = objRow[convBrowseInfoStatist.BrowseInfoStatistDate] == DBNull.Value ? null : objRow[convBrowseInfoStatist.BrowseInfoStatistDate].ToString().Trim(), //浏览日期
BrowseInfoStatistTime = objRow[convBrowseInfoStatist.BrowseInfoStatistTime] == DBNull.Value ? null : objRow[convBrowseInfoStatist.BrowseInfoStatistTime].ToString().Trim(), //浏览时间
BrowseTypeId = objRow[convBrowseInfoStatist.BrowseTypeId] == DBNull.Value ? null : objRow[convBrowseInfoStatist.BrowseTypeId].ToString().Trim(), //BrowseTypeId
BrowseSpendTime = objRow[convBrowseInfoStatist.BrowseSpendTime] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convBrowseInfoStatist.BrowseSpendTime].ToString().Trim()), //浏览花费时间
BrowseTypeName = objRow[convBrowseInfoStatist.BrowseTypeName] == DBNull.Value ? null : objRow[convBrowseInfoStatist.BrowseTypeName].ToString().Trim() //BrowseTypeName
};
objvBrowseInfoStatistEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvBrowseInfoStatistEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvBrowseInfoStatistDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvBrowseInfoStatistEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvBrowseInfoStatistEN objvBrowseInfoStatistEN = new clsvBrowseInfoStatistEN();
try
{
objvBrowseInfoStatistEN.IdBrowseInfoStatist = TransNullToInt(objRow[convBrowseInfoStatist.IdBrowseInfoStatist].ToString().Trim()); //浏览信息统计流水号
objvBrowseInfoStatistEN.SystemModuleName = objRow[convBrowseInfoStatist.SystemModuleName] == DBNull.Value ? null : objRow[convBrowseInfoStatist.SystemModuleName].ToString().Trim(); //系统模块名称
objvBrowseInfoStatistEN.IdUser = objRow[convBrowseInfoStatist.IdUser].ToString().Trim(); //id_User
objvBrowseInfoStatistEN.IdSystemModule = objRow[convBrowseInfoStatist.IdSystemModule].ToString().Trim(); //系统模块流水号
objvBrowseInfoStatistEN.ClassResourceID = objRow[convBrowseInfoStatist.ClassResourceID].ToString().Trim(); //资源流水号
objvBrowseInfoStatistEN.BrowseInfoStatistDate = objRow[convBrowseInfoStatist.BrowseInfoStatistDate] == DBNull.Value ? null : objRow[convBrowseInfoStatist.BrowseInfoStatistDate].ToString().Trim(); //浏览日期
objvBrowseInfoStatistEN.BrowseInfoStatistTime = objRow[convBrowseInfoStatist.BrowseInfoStatistTime] == DBNull.Value ? null : objRow[convBrowseInfoStatist.BrowseInfoStatistTime].ToString().Trim(); //浏览时间
objvBrowseInfoStatistEN.BrowseTypeId = objRow[convBrowseInfoStatist.BrowseTypeId] == DBNull.Value ? null : objRow[convBrowseInfoStatist.BrowseTypeId].ToString().Trim(); //BrowseTypeId
objvBrowseInfoStatistEN.BrowseSpendTime = objRow[convBrowseInfoStatist.BrowseSpendTime] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convBrowseInfoStatist.BrowseSpendTime].ToString().Trim()); //浏览花费时间
objvBrowseInfoStatistEN.BrowseTypeName = objRow[convBrowseInfoStatist.BrowseTypeName] == DBNull.Value ? null : objRow[convBrowseInfoStatist.BrowseTypeName].ToString().Trim(); //BrowseTypeName
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvBrowseInfoStatistDA: GetObjByDataRowvBrowseInfoStatist)", objException.Message));
}
objvBrowseInfoStatistEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvBrowseInfoStatistEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvBrowseInfoStatistEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvBrowseInfoStatistEN objvBrowseInfoStatistEN = new clsvBrowseInfoStatistEN();
try
{
objvBrowseInfoStatistEN.IdBrowseInfoStatist = TransNullToInt(objRow[convBrowseInfoStatist.IdBrowseInfoStatist].ToString().Trim()); //浏览信息统计流水号
objvBrowseInfoStatistEN.SystemModuleName = objRow[convBrowseInfoStatist.SystemModuleName] == DBNull.Value ? null : objRow[convBrowseInfoStatist.SystemModuleName].ToString().Trim(); //系统模块名称
objvBrowseInfoStatistEN.IdUser = objRow[convBrowseInfoStatist.IdUser].ToString().Trim(); //id_User
objvBrowseInfoStatistEN.IdSystemModule = objRow[convBrowseInfoStatist.IdSystemModule].ToString().Trim(); //系统模块流水号
objvBrowseInfoStatistEN.ClassResourceID = objRow[convBrowseInfoStatist.ClassResourceID].ToString().Trim(); //资源流水号
objvBrowseInfoStatistEN.BrowseInfoStatistDate = objRow[convBrowseInfoStatist.BrowseInfoStatistDate] == DBNull.Value ? null : objRow[convBrowseInfoStatist.BrowseInfoStatistDate].ToString().Trim(); //浏览日期
objvBrowseInfoStatistEN.BrowseInfoStatistTime = objRow[convBrowseInfoStatist.BrowseInfoStatistTime] == DBNull.Value ? null : objRow[convBrowseInfoStatist.BrowseInfoStatistTime].ToString().Trim(); //浏览时间
objvBrowseInfoStatistEN.BrowseTypeId = objRow[convBrowseInfoStatist.BrowseTypeId] == DBNull.Value ? null : objRow[convBrowseInfoStatist.BrowseTypeId].ToString().Trim(); //BrowseTypeId
objvBrowseInfoStatistEN.BrowseSpendTime = objRow[convBrowseInfoStatist.BrowseSpendTime] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convBrowseInfoStatist.BrowseSpendTime].ToString().Trim()); //浏览花费时间
objvBrowseInfoStatistEN.BrowseTypeName = objRow[convBrowseInfoStatist.BrowseTypeName] == DBNull.Value ? null : objRow[convBrowseInfoStatist.BrowseTypeName].ToString().Trim(); //BrowseTypeName
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvBrowseInfoStatistDA: GetObjByDataRow)", objException.Message));
}
objvBrowseInfoStatistEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvBrowseInfoStatistEN;
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
objSQL = clsvBrowseInfoStatistDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvBrowseInfoStatistEN._CurrTabName, convBrowseInfoStatist.IdBrowseInfoStatist, 8, "");
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
objSQL = clsvBrowseInfoStatistDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvBrowseInfoStatistEN._CurrTabName, convBrowseInfoStatist.IdBrowseInfoStatist, 8, strPrefix);
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
 objSQL = clsvBrowseInfoStatistDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdBrowseInfoStatist from vBrowseInfoStatist where " + strCondition;
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
 objSQL = clsvBrowseInfoStatistDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdBrowseInfoStatist from vBrowseInfoStatist where " + strCondition;
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
 /// <param name = "lngIdBrowseInfoStatist">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngIdBrowseInfoStatist)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvBrowseInfoStatistDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vBrowseInfoStatist", "IdBrowseInfoStatist = " + ""+ lngIdBrowseInfoStatist+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvBrowseInfoStatistDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvBrowseInfoStatistDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vBrowseInfoStatist", strCondition))
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
objSQL = clsvBrowseInfoStatistDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vBrowseInfoStatist");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvBrowseInfoStatistENS">源对象</param>
 /// <param name = "objvBrowseInfoStatistENT">目标对象</param>
public void CopyTo(clsvBrowseInfoStatistEN objvBrowseInfoStatistENS, clsvBrowseInfoStatistEN objvBrowseInfoStatistENT)
{
objvBrowseInfoStatistENT.IdBrowseInfoStatist = objvBrowseInfoStatistENS.IdBrowseInfoStatist; //浏览信息统计流水号
objvBrowseInfoStatistENT.SystemModuleName = objvBrowseInfoStatistENS.SystemModuleName; //系统模块名称
objvBrowseInfoStatistENT.IdUser = objvBrowseInfoStatistENS.IdUser; //id_User
objvBrowseInfoStatistENT.IdSystemModule = objvBrowseInfoStatistENS.IdSystemModule; //系统模块流水号
objvBrowseInfoStatistENT.ClassResourceID = objvBrowseInfoStatistENS.ClassResourceID; //资源流水号
objvBrowseInfoStatistENT.BrowseInfoStatistDate = objvBrowseInfoStatistENS.BrowseInfoStatistDate; //浏览日期
objvBrowseInfoStatistENT.BrowseInfoStatistTime = objvBrowseInfoStatistENS.BrowseInfoStatistTime; //浏览时间
objvBrowseInfoStatistENT.BrowseTypeId = objvBrowseInfoStatistENS.BrowseTypeId; //BrowseTypeId
objvBrowseInfoStatistENT.BrowseSpendTime = objvBrowseInfoStatistENS.BrowseSpendTime; //浏览花费时间
objvBrowseInfoStatistENT.BrowseTypeName = objvBrowseInfoStatistENS.BrowseTypeName; //BrowseTypeName
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvBrowseInfoStatistEN objvBrowseInfoStatistEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvBrowseInfoStatistEN.SystemModuleName, 100, convBrowseInfoStatist.SystemModuleName);
clsCheckSql.CheckFieldLen(objvBrowseInfoStatistEN.IdUser, 8, convBrowseInfoStatist.IdUser);
clsCheckSql.CheckFieldLen(objvBrowseInfoStatistEN.IdSystemModule, 4, convBrowseInfoStatist.IdSystemModule);
clsCheckSql.CheckFieldLen(objvBrowseInfoStatistEN.ClassResourceID, 8, convBrowseInfoStatist.ClassResourceID);
clsCheckSql.CheckFieldLen(objvBrowseInfoStatistEN.BrowseInfoStatistDate, 8, convBrowseInfoStatist.BrowseInfoStatistDate);
clsCheckSql.CheckFieldLen(objvBrowseInfoStatistEN.BrowseInfoStatistTime, 6, convBrowseInfoStatist.BrowseInfoStatistTime);
clsCheckSql.CheckFieldLen(objvBrowseInfoStatistEN.BrowseTypeId, 4, convBrowseInfoStatist.BrowseTypeId);
clsCheckSql.CheckFieldLen(objvBrowseInfoStatistEN.BrowseTypeName, 100, convBrowseInfoStatist.BrowseTypeName);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvBrowseInfoStatistEN.SystemModuleName, convBrowseInfoStatist.SystemModuleName);
clsCheckSql.CheckSqlInjection4Field(objvBrowseInfoStatistEN.IdUser, convBrowseInfoStatist.IdUser);
clsCheckSql.CheckSqlInjection4Field(objvBrowseInfoStatistEN.IdSystemModule, convBrowseInfoStatist.IdSystemModule);
clsCheckSql.CheckSqlInjection4Field(objvBrowseInfoStatistEN.ClassResourceID, convBrowseInfoStatist.ClassResourceID);
clsCheckSql.CheckSqlInjection4Field(objvBrowseInfoStatistEN.BrowseInfoStatistDate, convBrowseInfoStatist.BrowseInfoStatistDate);
clsCheckSql.CheckSqlInjection4Field(objvBrowseInfoStatistEN.BrowseInfoStatistTime, convBrowseInfoStatist.BrowseInfoStatistTime);
clsCheckSql.CheckSqlInjection4Field(objvBrowseInfoStatistEN.BrowseTypeId, convBrowseInfoStatist.BrowseTypeId);
clsCheckSql.CheckSqlInjection4Field(objvBrowseInfoStatistEN.BrowseTypeName, convBrowseInfoStatist.BrowseTypeName);
//检查外键字段长度
 objvBrowseInfoStatistEN._IsCheckProperty = true;
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
 objSQL = clsvBrowseInfoStatistDA.GetSpecSQLObj();
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
 objSQL = clsvBrowseInfoStatistDA.GetSpecSQLObj();
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
 objSQL = clsvBrowseInfoStatistDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvBrowseInfoStatistEN._CurrTabName);
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
 objSQL = clsvBrowseInfoStatistDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvBrowseInfoStatistEN._CurrTabName, strCondition);
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
 objSQL = clsvBrowseInfoStatistDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}