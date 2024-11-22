
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPaperDownloadLogDA
 表名:vPaperDownloadLog(01120572)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:48:18
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培论文(GradEduPaper)
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
 /// v论文下载记录(vPaperDownloadLog)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvPaperDownloadLogDA : clsCommBase4DA
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
 return clsvPaperDownloadLogEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvPaperDownloadLogEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvPaperDownloadLogEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvPaperDownloadLogEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvPaperDownloadLogEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvPaperDownloadLogDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperDownloadLogDA.GetSpecSQLObj();
strSQL = "Select * from vPaperDownloadLog where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vPaperDownloadLog(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvPaperDownloadLogDA: GetDataTable_vPaperDownloadLog)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperDownloadLogDA.GetSpecSQLObj();
strSQL = "Select * from vPaperDownloadLog where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvPaperDownloadLogDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperDownloadLogDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvPaperDownloadLogDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperDownloadLogDA.GetSpecSQLObj();
strSQL = "Select * from vPaperDownloadLog where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvPaperDownloadLogDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperDownloadLogDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvPaperDownloadLogDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperDownloadLogDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPaperDownloadLog where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPaperDownloadLog where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvPaperDownloadLogDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperDownloadLogDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vPaperDownloadLog where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvPaperDownloadLogDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperDownloadLogDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vPaperDownloadLog.* from vPaperDownloadLog Left Join {1} on {2} where {3} and vPaperDownloadLog.PaperDownloadId not in (Select top {5} vPaperDownloadLog.PaperDownloadId from vPaperDownloadLog Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPaperDownloadLog where {1} and PaperDownloadId not in (Select top {2} PaperDownloadId from vPaperDownloadLog where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPaperDownloadLog where {1} and PaperDownloadId not in (Select top {3} PaperDownloadId from vPaperDownloadLog where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvPaperDownloadLogDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperDownloadLogDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vPaperDownloadLog.* from vPaperDownloadLog Left Join {1} on {2} where {3} and vPaperDownloadLog.PaperDownloadId not in (Select top {5} vPaperDownloadLog.PaperDownloadId from vPaperDownloadLog Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPaperDownloadLog where {1} and PaperDownloadId not in (Select top {2} PaperDownloadId from vPaperDownloadLog where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPaperDownloadLog where {1} and PaperDownloadId not in (Select top {3} PaperDownloadId from vPaperDownloadLog where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvPaperDownloadLogEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvPaperDownloadLogDA:GetObjLst)", objException.Message));
}
List<clsvPaperDownloadLogEN> arrObjLst = new List<clsvPaperDownloadLogEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperDownloadLogDA.GetSpecSQLObj();
strSQL = "Select * from vPaperDownloadLog where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperDownloadLogEN objvPaperDownloadLogEN = new clsvPaperDownloadLogEN();
try
{
objvPaperDownloadLogEN.PaperDownloadId = TransNullToInt(objRow[convPaperDownloadLog.PaperDownloadId].ToString().Trim()); //PaperDownloadId
objvPaperDownloadLogEN.DownloadFile = objRow[convPaperDownloadLog.DownloadFile] == DBNull.Value ? null : objRow[convPaperDownloadLog.DownloadFile].ToString().Trim(); //DownloadFile
objvPaperDownloadLogEN.DownloadLink = objRow[convPaperDownloadLog.DownloadLink] == DBNull.Value ? null : objRow[convPaperDownloadLog.DownloadLink].ToString().Trim(); //DownloadLink
objvPaperDownloadLogEN.PaperId = objRow[convPaperDownloadLog.PaperId] == DBNull.Value ? null : objRow[convPaperDownloadLog.PaperId].ToString().Trim(); //论文Id
objvPaperDownloadLogEN.UpdUser = objRow[convPaperDownloadLog.UpdUser] == DBNull.Value ? null : objRow[convPaperDownloadLog.UpdUser].ToString().Trim(); //修改人
objvPaperDownloadLogEN.UpdDate = objRow[convPaperDownloadLog.UpdDate] == DBNull.Value ? null : objRow[convPaperDownloadLog.UpdDate].ToString().Trim(); //修改日期
objvPaperDownloadLogEN.Memo = objRow[convPaperDownloadLog.Memo] == DBNull.Value ? null : objRow[convPaperDownloadLog.Memo].ToString().Trim(); //备注
objvPaperDownloadLogEN.PaperTitle = objRow[convPaperDownloadLog.PaperTitle] == DBNull.Value ? null : objRow[convPaperDownloadLog.PaperTitle].ToString().Trim(); //论文标题
objvPaperDownloadLogEN.Author = objRow[convPaperDownloadLog.Author] == DBNull.Value ? null : objRow[convPaperDownloadLog.Author].ToString().Trim(); //作者
objvPaperDownloadLogEN.Keyword = objRow[convPaperDownloadLog.Keyword] == DBNull.Value ? null : objRow[convPaperDownloadLog.Keyword].ToString().Trim(); //关键字
objvPaperDownloadLogEN.UserName = objRow[convPaperDownloadLog.UserName] == DBNull.Value ? null : objRow[convPaperDownloadLog.UserName].ToString().Trim(); //用户名
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvPaperDownloadLogDA: GetObjLst)", objException.Message));
}
objvPaperDownloadLogEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvPaperDownloadLogEN);
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
public List<clsvPaperDownloadLogEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvPaperDownloadLogDA:GetObjLstByTabName)", objException.Message));
}
List<clsvPaperDownloadLogEN> arrObjLst = new List<clsvPaperDownloadLogEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperDownloadLogDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperDownloadLogEN objvPaperDownloadLogEN = new clsvPaperDownloadLogEN();
try
{
objvPaperDownloadLogEN.PaperDownloadId = TransNullToInt(objRow[convPaperDownloadLog.PaperDownloadId].ToString().Trim()); //PaperDownloadId
objvPaperDownloadLogEN.DownloadFile = objRow[convPaperDownloadLog.DownloadFile] == DBNull.Value ? null : objRow[convPaperDownloadLog.DownloadFile].ToString().Trim(); //DownloadFile
objvPaperDownloadLogEN.DownloadLink = objRow[convPaperDownloadLog.DownloadLink] == DBNull.Value ? null : objRow[convPaperDownloadLog.DownloadLink].ToString().Trim(); //DownloadLink
objvPaperDownloadLogEN.PaperId = objRow[convPaperDownloadLog.PaperId] == DBNull.Value ? null : objRow[convPaperDownloadLog.PaperId].ToString().Trim(); //论文Id
objvPaperDownloadLogEN.UpdUser = objRow[convPaperDownloadLog.UpdUser] == DBNull.Value ? null : objRow[convPaperDownloadLog.UpdUser].ToString().Trim(); //修改人
objvPaperDownloadLogEN.UpdDate = objRow[convPaperDownloadLog.UpdDate] == DBNull.Value ? null : objRow[convPaperDownloadLog.UpdDate].ToString().Trim(); //修改日期
objvPaperDownloadLogEN.Memo = objRow[convPaperDownloadLog.Memo] == DBNull.Value ? null : objRow[convPaperDownloadLog.Memo].ToString().Trim(); //备注
objvPaperDownloadLogEN.PaperTitle = objRow[convPaperDownloadLog.PaperTitle] == DBNull.Value ? null : objRow[convPaperDownloadLog.PaperTitle].ToString().Trim(); //论文标题
objvPaperDownloadLogEN.Author = objRow[convPaperDownloadLog.Author] == DBNull.Value ? null : objRow[convPaperDownloadLog.Author].ToString().Trim(); //作者
objvPaperDownloadLogEN.Keyword = objRow[convPaperDownloadLog.Keyword] == DBNull.Value ? null : objRow[convPaperDownloadLog.Keyword].ToString().Trim(); //关键字
objvPaperDownloadLogEN.UserName = objRow[convPaperDownloadLog.UserName] == DBNull.Value ? null : objRow[convPaperDownloadLog.UserName].ToString().Trim(); //用户名
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvPaperDownloadLogDA: GetObjLst)", objException.Message));
}
objvPaperDownloadLogEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvPaperDownloadLogEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvPaperDownloadLogEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvPaperDownloadLog(ref clsvPaperDownloadLogEN objvPaperDownloadLogEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperDownloadLogDA.GetSpecSQLObj();
strSQL = "Select * from vPaperDownloadLog where PaperDownloadId = " + ""+ objvPaperDownloadLogEN.PaperDownloadId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvPaperDownloadLogEN.PaperDownloadId = TransNullToInt(objDT.Rows[0][convPaperDownloadLog.PaperDownloadId].ToString().Trim()); //PaperDownloadId(字段类型:bigint,字段长度:8,是否可空:False)
 objvPaperDownloadLogEN.DownloadFile = objDT.Rows[0][convPaperDownloadLog.DownloadFile].ToString().Trim(); //DownloadFile(字段类型:varchar,字段长度:500,是否可空:True)
 objvPaperDownloadLogEN.DownloadLink = objDT.Rows[0][convPaperDownloadLog.DownloadLink].ToString().Trim(); //DownloadLink(字段类型:varchar,字段长度:500,是否可空:True)
 objvPaperDownloadLogEN.PaperId = objDT.Rows[0][convPaperDownloadLog.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objvPaperDownloadLogEN.UpdUser = objDT.Rows[0][convPaperDownloadLog.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvPaperDownloadLogEN.UpdDate = objDT.Rows[0][convPaperDownloadLog.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvPaperDownloadLogEN.Memo = objDT.Rows[0][convPaperDownloadLog.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvPaperDownloadLogEN.PaperTitle = objDT.Rows[0][convPaperDownloadLog.PaperTitle].ToString().Trim(); //论文标题(字段类型:varchar,字段长度:500,是否可空:False)
 objvPaperDownloadLogEN.Author = objDT.Rows[0][convPaperDownloadLog.Author].ToString().Trim(); //作者(字段类型:varchar,字段长度:200,是否可空:True)
 objvPaperDownloadLogEN.Keyword = objDT.Rows[0][convPaperDownloadLog.Keyword].ToString().Trim(); //关键字(字段类型:varchar,字段长度:1000,是否可空:True)
 objvPaperDownloadLogEN.UserName = objDT.Rows[0][convPaperDownloadLog.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvPaperDownloadLogDA: GetvPaperDownloadLog)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngPaperDownloadId">表关键字</param>
 /// <returns>表对象</returns>
public clsvPaperDownloadLogEN GetObjByPaperDownloadId(long lngPaperDownloadId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperDownloadLogDA.GetSpecSQLObj();
strSQL = "Select * from vPaperDownloadLog where PaperDownloadId = " + ""+ lngPaperDownloadId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvPaperDownloadLogEN objvPaperDownloadLogEN = new clsvPaperDownloadLogEN();
try
{
 objvPaperDownloadLogEN.PaperDownloadId = Int32.Parse(objRow[convPaperDownloadLog.PaperDownloadId].ToString().Trim()); //PaperDownloadId(字段类型:bigint,字段长度:8,是否可空:False)
 objvPaperDownloadLogEN.DownloadFile = objRow[convPaperDownloadLog.DownloadFile] == DBNull.Value ? null : objRow[convPaperDownloadLog.DownloadFile].ToString().Trim(); //DownloadFile(字段类型:varchar,字段长度:500,是否可空:True)
 objvPaperDownloadLogEN.DownloadLink = objRow[convPaperDownloadLog.DownloadLink] == DBNull.Value ? null : objRow[convPaperDownloadLog.DownloadLink].ToString().Trim(); //DownloadLink(字段类型:varchar,字段长度:500,是否可空:True)
 objvPaperDownloadLogEN.PaperId = objRow[convPaperDownloadLog.PaperId] == DBNull.Value ? null : objRow[convPaperDownloadLog.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objvPaperDownloadLogEN.UpdUser = objRow[convPaperDownloadLog.UpdUser] == DBNull.Value ? null : objRow[convPaperDownloadLog.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvPaperDownloadLogEN.UpdDate = objRow[convPaperDownloadLog.UpdDate] == DBNull.Value ? null : objRow[convPaperDownloadLog.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvPaperDownloadLogEN.Memo = objRow[convPaperDownloadLog.Memo] == DBNull.Value ? null : objRow[convPaperDownloadLog.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvPaperDownloadLogEN.PaperTitle = objRow[convPaperDownloadLog.PaperTitle] == DBNull.Value ? null : objRow[convPaperDownloadLog.PaperTitle].ToString().Trim(); //论文标题(字段类型:varchar,字段长度:500,是否可空:False)
 objvPaperDownloadLogEN.Author = objRow[convPaperDownloadLog.Author] == DBNull.Value ? null : objRow[convPaperDownloadLog.Author].ToString().Trim(); //作者(字段类型:varchar,字段长度:200,是否可空:True)
 objvPaperDownloadLogEN.Keyword = objRow[convPaperDownloadLog.Keyword] == DBNull.Value ? null : objRow[convPaperDownloadLog.Keyword].ToString().Trim(); //关键字(字段类型:varchar,字段长度:1000,是否可空:True)
 objvPaperDownloadLogEN.UserName = objRow[convPaperDownloadLog.UserName] == DBNull.Value ? null : objRow[convPaperDownloadLog.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvPaperDownloadLogDA: GetObjByPaperDownloadId)", objException.Message));
}
return objvPaperDownloadLogEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvPaperDownloadLogEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvPaperDownloadLogDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperDownloadLogDA.GetSpecSQLObj();
strSQL = "Select * from vPaperDownloadLog where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvPaperDownloadLogEN objvPaperDownloadLogEN = new clsvPaperDownloadLogEN()
{
PaperDownloadId = TransNullToInt(objRow[convPaperDownloadLog.PaperDownloadId].ToString().Trim()), //PaperDownloadId
DownloadFile = objRow[convPaperDownloadLog.DownloadFile] == DBNull.Value ? null : objRow[convPaperDownloadLog.DownloadFile].ToString().Trim(), //DownloadFile
DownloadLink = objRow[convPaperDownloadLog.DownloadLink] == DBNull.Value ? null : objRow[convPaperDownloadLog.DownloadLink].ToString().Trim(), //DownloadLink
PaperId = objRow[convPaperDownloadLog.PaperId] == DBNull.Value ? null : objRow[convPaperDownloadLog.PaperId].ToString().Trim(), //论文Id
UpdUser = objRow[convPaperDownloadLog.UpdUser] == DBNull.Value ? null : objRow[convPaperDownloadLog.UpdUser].ToString().Trim(), //修改人
UpdDate = objRow[convPaperDownloadLog.UpdDate] == DBNull.Value ? null : objRow[convPaperDownloadLog.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[convPaperDownloadLog.Memo] == DBNull.Value ? null : objRow[convPaperDownloadLog.Memo].ToString().Trim(), //备注
PaperTitle = objRow[convPaperDownloadLog.PaperTitle] == DBNull.Value ? null : objRow[convPaperDownloadLog.PaperTitle].ToString().Trim(), //论文标题
Author = objRow[convPaperDownloadLog.Author] == DBNull.Value ? null : objRow[convPaperDownloadLog.Author].ToString().Trim(), //作者
Keyword = objRow[convPaperDownloadLog.Keyword] == DBNull.Value ? null : objRow[convPaperDownloadLog.Keyword].ToString().Trim(), //关键字
UserName = objRow[convPaperDownloadLog.UserName] == DBNull.Value ? null : objRow[convPaperDownloadLog.UserName].ToString().Trim() //用户名
};
objvPaperDownloadLogEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPaperDownloadLogEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvPaperDownloadLogDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvPaperDownloadLogEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvPaperDownloadLogEN objvPaperDownloadLogEN = new clsvPaperDownloadLogEN();
try
{
objvPaperDownloadLogEN.PaperDownloadId = TransNullToInt(objRow[convPaperDownloadLog.PaperDownloadId].ToString().Trim()); //PaperDownloadId
objvPaperDownloadLogEN.DownloadFile = objRow[convPaperDownloadLog.DownloadFile] == DBNull.Value ? null : objRow[convPaperDownloadLog.DownloadFile].ToString().Trim(); //DownloadFile
objvPaperDownloadLogEN.DownloadLink = objRow[convPaperDownloadLog.DownloadLink] == DBNull.Value ? null : objRow[convPaperDownloadLog.DownloadLink].ToString().Trim(); //DownloadLink
objvPaperDownloadLogEN.PaperId = objRow[convPaperDownloadLog.PaperId] == DBNull.Value ? null : objRow[convPaperDownloadLog.PaperId].ToString().Trim(); //论文Id
objvPaperDownloadLogEN.UpdUser = objRow[convPaperDownloadLog.UpdUser] == DBNull.Value ? null : objRow[convPaperDownloadLog.UpdUser].ToString().Trim(); //修改人
objvPaperDownloadLogEN.UpdDate = objRow[convPaperDownloadLog.UpdDate] == DBNull.Value ? null : objRow[convPaperDownloadLog.UpdDate].ToString().Trim(); //修改日期
objvPaperDownloadLogEN.Memo = objRow[convPaperDownloadLog.Memo] == DBNull.Value ? null : objRow[convPaperDownloadLog.Memo].ToString().Trim(); //备注
objvPaperDownloadLogEN.PaperTitle = objRow[convPaperDownloadLog.PaperTitle] == DBNull.Value ? null : objRow[convPaperDownloadLog.PaperTitle].ToString().Trim(); //论文标题
objvPaperDownloadLogEN.Author = objRow[convPaperDownloadLog.Author] == DBNull.Value ? null : objRow[convPaperDownloadLog.Author].ToString().Trim(); //作者
objvPaperDownloadLogEN.Keyword = objRow[convPaperDownloadLog.Keyword] == DBNull.Value ? null : objRow[convPaperDownloadLog.Keyword].ToString().Trim(); //关键字
objvPaperDownloadLogEN.UserName = objRow[convPaperDownloadLog.UserName] == DBNull.Value ? null : objRow[convPaperDownloadLog.UserName].ToString().Trim(); //用户名
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvPaperDownloadLogDA: GetObjByDataRowvPaperDownloadLog)", objException.Message));
}
objvPaperDownloadLogEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPaperDownloadLogEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvPaperDownloadLogEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvPaperDownloadLogEN objvPaperDownloadLogEN = new clsvPaperDownloadLogEN();
try
{
objvPaperDownloadLogEN.PaperDownloadId = TransNullToInt(objRow[convPaperDownloadLog.PaperDownloadId].ToString().Trim()); //PaperDownloadId
objvPaperDownloadLogEN.DownloadFile = objRow[convPaperDownloadLog.DownloadFile] == DBNull.Value ? null : objRow[convPaperDownloadLog.DownloadFile].ToString().Trim(); //DownloadFile
objvPaperDownloadLogEN.DownloadLink = objRow[convPaperDownloadLog.DownloadLink] == DBNull.Value ? null : objRow[convPaperDownloadLog.DownloadLink].ToString().Trim(); //DownloadLink
objvPaperDownloadLogEN.PaperId = objRow[convPaperDownloadLog.PaperId] == DBNull.Value ? null : objRow[convPaperDownloadLog.PaperId].ToString().Trim(); //论文Id
objvPaperDownloadLogEN.UpdUser = objRow[convPaperDownloadLog.UpdUser] == DBNull.Value ? null : objRow[convPaperDownloadLog.UpdUser].ToString().Trim(); //修改人
objvPaperDownloadLogEN.UpdDate = objRow[convPaperDownloadLog.UpdDate] == DBNull.Value ? null : objRow[convPaperDownloadLog.UpdDate].ToString().Trim(); //修改日期
objvPaperDownloadLogEN.Memo = objRow[convPaperDownloadLog.Memo] == DBNull.Value ? null : objRow[convPaperDownloadLog.Memo].ToString().Trim(); //备注
objvPaperDownloadLogEN.PaperTitle = objRow[convPaperDownloadLog.PaperTitle] == DBNull.Value ? null : objRow[convPaperDownloadLog.PaperTitle].ToString().Trim(); //论文标题
objvPaperDownloadLogEN.Author = objRow[convPaperDownloadLog.Author] == DBNull.Value ? null : objRow[convPaperDownloadLog.Author].ToString().Trim(); //作者
objvPaperDownloadLogEN.Keyword = objRow[convPaperDownloadLog.Keyword] == DBNull.Value ? null : objRow[convPaperDownloadLog.Keyword].ToString().Trim(); //关键字
objvPaperDownloadLogEN.UserName = objRow[convPaperDownloadLog.UserName] == DBNull.Value ? null : objRow[convPaperDownloadLog.UserName].ToString().Trim(); //用户名
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvPaperDownloadLogDA: GetObjByDataRow)", objException.Message));
}
objvPaperDownloadLogEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPaperDownloadLogEN;
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
objSQL = clsvPaperDownloadLogDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvPaperDownloadLogEN._CurrTabName, convPaperDownloadLog.PaperDownloadId, 8, "");
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
objSQL = clsvPaperDownloadLogDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvPaperDownloadLogEN._CurrTabName, convPaperDownloadLog.PaperDownloadId, 8, strPrefix);
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
 objSQL = clsvPaperDownloadLogDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select PaperDownloadId from vPaperDownloadLog where " + strCondition;
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
 objSQL = clsvPaperDownloadLogDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select PaperDownloadId from vPaperDownloadLog where " + strCondition;
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
 /// <param name = "lngPaperDownloadId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngPaperDownloadId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperDownloadLogDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vPaperDownloadLog", "PaperDownloadId = " + ""+ lngPaperDownloadId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvPaperDownloadLogDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperDownloadLogDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vPaperDownloadLog", strCondition))
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
objSQL = clsvPaperDownloadLogDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vPaperDownloadLog");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvPaperDownloadLogENS">源对象</param>
 /// <param name = "objvPaperDownloadLogENT">目标对象</param>
public void CopyTo(clsvPaperDownloadLogEN objvPaperDownloadLogENS, clsvPaperDownloadLogEN objvPaperDownloadLogENT)
{
objvPaperDownloadLogENT.PaperDownloadId = objvPaperDownloadLogENS.PaperDownloadId; //PaperDownloadId
objvPaperDownloadLogENT.DownloadFile = objvPaperDownloadLogENS.DownloadFile; //DownloadFile
objvPaperDownloadLogENT.DownloadLink = objvPaperDownloadLogENS.DownloadLink; //DownloadLink
objvPaperDownloadLogENT.PaperId = objvPaperDownloadLogENS.PaperId; //论文Id
objvPaperDownloadLogENT.UpdUser = objvPaperDownloadLogENS.UpdUser; //修改人
objvPaperDownloadLogENT.UpdDate = objvPaperDownloadLogENS.UpdDate; //修改日期
objvPaperDownloadLogENT.Memo = objvPaperDownloadLogENS.Memo; //备注
objvPaperDownloadLogENT.PaperTitle = objvPaperDownloadLogENS.PaperTitle; //论文标题
objvPaperDownloadLogENT.Author = objvPaperDownloadLogENS.Author; //作者
objvPaperDownloadLogENT.Keyword = objvPaperDownloadLogENS.Keyword; //关键字
objvPaperDownloadLogENT.UserName = objvPaperDownloadLogENS.UserName; //用户名
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvPaperDownloadLogEN objvPaperDownloadLogEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvPaperDownloadLogEN.DownloadFile, 500, convPaperDownloadLog.DownloadFile);
clsCheckSql.CheckFieldLen(objvPaperDownloadLogEN.DownloadLink, 500, convPaperDownloadLog.DownloadLink);
clsCheckSql.CheckFieldLen(objvPaperDownloadLogEN.PaperId, 8, convPaperDownloadLog.PaperId);
clsCheckSql.CheckFieldLen(objvPaperDownloadLogEN.UpdUser, 20, convPaperDownloadLog.UpdUser);
clsCheckSql.CheckFieldLen(objvPaperDownloadLogEN.UpdDate, 20, convPaperDownloadLog.UpdDate);
clsCheckSql.CheckFieldLen(objvPaperDownloadLogEN.Memo, 1000, convPaperDownloadLog.Memo);
clsCheckSql.CheckFieldLen(objvPaperDownloadLogEN.PaperTitle, 500, convPaperDownloadLog.PaperTitle);
clsCheckSql.CheckFieldLen(objvPaperDownloadLogEN.Author, 200, convPaperDownloadLog.Author);
clsCheckSql.CheckFieldLen(objvPaperDownloadLogEN.Keyword, 1000, convPaperDownloadLog.Keyword);
clsCheckSql.CheckFieldLen(objvPaperDownloadLogEN.UserName, 30, convPaperDownloadLog.UserName);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvPaperDownloadLogEN.DownloadFile, convPaperDownloadLog.DownloadFile);
clsCheckSql.CheckSqlInjection4Field(objvPaperDownloadLogEN.DownloadLink, convPaperDownloadLog.DownloadLink);
clsCheckSql.CheckSqlInjection4Field(objvPaperDownloadLogEN.PaperId, convPaperDownloadLog.PaperId);
clsCheckSql.CheckSqlInjection4Field(objvPaperDownloadLogEN.UpdUser, convPaperDownloadLog.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvPaperDownloadLogEN.UpdDate, convPaperDownloadLog.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvPaperDownloadLogEN.Memo, convPaperDownloadLog.Memo);
clsCheckSql.CheckSqlInjection4Field(objvPaperDownloadLogEN.PaperTitle, convPaperDownloadLog.PaperTitle);
clsCheckSql.CheckSqlInjection4Field(objvPaperDownloadLogEN.Author, convPaperDownloadLog.Author);
clsCheckSql.CheckSqlInjection4Field(objvPaperDownloadLogEN.Keyword, convPaperDownloadLog.Keyword);
clsCheckSql.CheckSqlInjection4Field(objvPaperDownloadLogEN.UserName, convPaperDownloadLog.UserName);
//检查外键字段长度
 objvPaperDownloadLogEN._IsCheckProperty = true;
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
 objSQL = clsvPaperDownloadLogDA.GetSpecSQLObj();
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
 objSQL = clsvPaperDownloadLogDA.GetSpecSQLObj();
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
 objSQL = clsvPaperDownloadLogDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvPaperDownloadLogEN._CurrTabName);
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
 objSQL = clsvPaperDownloadLogDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvPaperDownloadLogEN._CurrTabName, strCondition);
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
 objSQL = clsvPaperDownloadLogDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}