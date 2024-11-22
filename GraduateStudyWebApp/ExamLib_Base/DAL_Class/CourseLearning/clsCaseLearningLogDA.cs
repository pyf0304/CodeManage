
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCaseLearningLogDA
 表名:CaseLearningLog(01120365)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:07:17
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程学习(CourseLearning)
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
 /// 案例学习日志(CaseLearningLog)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsCaseLearningLogDA : clsCommBase4DA
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
 return clsCaseLearningLogEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsCaseLearningLogEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCaseLearningLogEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsCaseLearningLogEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsCaseLearningLogEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsCaseLearningLogDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseLearningLogDA.GetSpecSQLObj();
strSQL = "Select * from CaseLearningLog where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_CaseLearningLog(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsCaseLearningLogDA: GetDataTable_CaseLearningLog)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseLearningLogDA.GetSpecSQLObj();
strSQL = "Select * from CaseLearningLog where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsCaseLearningLogDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseLearningLogDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsCaseLearningLogDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseLearningLogDA.GetSpecSQLObj();
strSQL = "Select * from CaseLearningLog where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsCaseLearningLogDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseLearningLogDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsCaseLearningLogDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseLearningLogDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CaseLearningLog where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CaseLearningLog where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsCaseLearningLogDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseLearningLogDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from CaseLearningLog where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsCaseLearningLogDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseLearningLogDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} CaseLearningLog.* from CaseLearningLog Left Join {1} on {2} where {3} and CaseLearningLog.mId not in (Select top {5} CaseLearningLog.mId from CaseLearningLog Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CaseLearningLog where {1} and mId not in (Select top {2} mId from CaseLearningLog where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CaseLearningLog where {1} and mId not in (Select top {3} mId from CaseLearningLog where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsCaseLearningLogDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseLearningLogDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} CaseLearningLog.* from CaseLearningLog Left Join {1} on {2} where {3} and CaseLearningLog.mId not in (Select top {5} CaseLearningLog.mId from CaseLearningLog Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CaseLearningLog where {1} and mId not in (Select top {2} mId from CaseLearningLog where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CaseLearningLog where {1} and mId not in (Select top {3} mId from CaseLearningLog where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsCaseLearningLogEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsCaseLearningLogDA:GetObjLst)", objException.Message));
}
List<clsCaseLearningLogEN> arrObjLst = new List<clsCaseLearningLogEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseLearningLogDA.GetSpecSQLObj();
strSQL = "Select * from CaseLearningLog where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCaseLearningLogEN objCaseLearningLogEN = new clsCaseLearningLogEN();
try
{
objCaseLearningLogEN.mId = TransNullToInt(objRow[conCaseLearningLog.mId].ToString().Trim()); //mId
objCaseLearningLogEN.FuncModuleId = objRow[conCaseLearningLog.FuncModuleId].ToString().Trim(); //功能模块Id
objCaseLearningLogEN.CaseId = objRow[conCaseLearningLog.CaseId].ToString().Trim(); //案例Id
objCaseLearningLogEN.CaseName = objRow[conCaseLearningLog.CaseName] == DBNull.Value ? null : objRow[conCaseLearningLog.CaseName].ToString().Trim(); //案例名称
objCaseLearningLogEN.OwnerId = objRow[conCaseLearningLog.OwnerId] == DBNull.Value ? null : objRow[conCaseLearningLog.OwnerId].ToString().Trim(); //拥有者Id
objCaseLearningLogEN.UserId = objRow[conCaseLearningLog.UserId].ToString().Trim(); //用户ID
objCaseLearningLogEN.LearnStartTime = objRow[conCaseLearningLog.LearnStartTime].ToString().Trim(); //开始时间
objCaseLearningLogEN.LearnEndTime = objRow[conCaseLearningLog.LearnEndTime].ToString().Trim(); //结束时间
objCaseLearningLogEN.VideoStartTime = TransNullToDouble(objRow[conCaseLearningLog.VideoStartTime].ToString().Trim()); //观看视频开始时间
objCaseLearningLogEN.VideoEndTime = TransNullToDouble(objRow[conCaseLearningLog.VideoEndTime].ToString().Trim()); //观看视频结束时间
objCaseLearningLogEN.IpAddress = objRow[conCaseLearningLog.IpAddress] == DBNull.Value ? null : objRow[conCaseLearningLog.IpAddress].ToString().Trim(); //Ip地址
objCaseLearningLogEN.TimeLengthOfVideo = objRow[conCaseLearningLog.TimeLengthOfVideo] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCaseLearningLog.TimeLengthOfVideo].ToString().Trim()); //视频时长
objCaseLearningLogEN.Memo = objRow[conCaseLearningLog.Memo] == DBNull.Value ? null : objRow[conCaseLearningLog.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCaseLearningLogDA: GetObjLst)", objException.Message));
}
objCaseLearningLogEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCaseLearningLogEN);
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
public List<clsCaseLearningLogEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsCaseLearningLogDA:GetObjLstByTabName)", objException.Message));
}
List<clsCaseLearningLogEN> arrObjLst = new List<clsCaseLearningLogEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseLearningLogDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCaseLearningLogEN objCaseLearningLogEN = new clsCaseLearningLogEN();
try
{
objCaseLearningLogEN.mId = TransNullToInt(objRow[conCaseLearningLog.mId].ToString().Trim()); //mId
objCaseLearningLogEN.FuncModuleId = objRow[conCaseLearningLog.FuncModuleId].ToString().Trim(); //功能模块Id
objCaseLearningLogEN.CaseId = objRow[conCaseLearningLog.CaseId].ToString().Trim(); //案例Id
objCaseLearningLogEN.CaseName = objRow[conCaseLearningLog.CaseName] == DBNull.Value ? null : objRow[conCaseLearningLog.CaseName].ToString().Trim(); //案例名称
objCaseLearningLogEN.OwnerId = objRow[conCaseLearningLog.OwnerId] == DBNull.Value ? null : objRow[conCaseLearningLog.OwnerId].ToString().Trim(); //拥有者Id
objCaseLearningLogEN.UserId = objRow[conCaseLearningLog.UserId].ToString().Trim(); //用户ID
objCaseLearningLogEN.LearnStartTime = objRow[conCaseLearningLog.LearnStartTime].ToString().Trim(); //开始时间
objCaseLearningLogEN.LearnEndTime = objRow[conCaseLearningLog.LearnEndTime].ToString().Trim(); //结束时间
objCaseLearningLogEN.VideoStartTime = TransNullToDouble(objRow[conCaseLearningLog.VideoStartTime].ToString().Trim()); //观看视频开始时间
objCaseLearningLogEN.VideoEndTime = TransNullToDouble(objRow[conCaseLearningLog.VideoEndTime].ToString().Trim()); //观看视频结束时间
objCaseLearningLogEN.IpAddress = objRow[conCaseLearningLog.IpAddress] == DBNull.Value ? null : objRow[conCaseLearningLog.IpAddress].ToString().Trim(); //Ip地址
objCaseLearningLogEN.TimeLengthOfVideo = objRow[conCaseLearningLog.TimeLengthOfVideo] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCaseLearningLog.TimeLengthOfVideo].ToString().Trim()); //视频时长
objCaseLearningLogEN.Memo = objRow[conCaseLearningLog.Memo] == DBNull.Value ? null : objRow[conCaseLearningLog.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCaseLearningLogDA: GetObjLst)", objException.Message));
}
objCaseLearningLogEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCaseLearningLogEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objCaseLearningLogEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetCaseLearningLog(ref clsCaseLearningLogEN objCaseLearningLogEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseLearningLogDA.GetSpecSQLObj();
strSQL = "Select * from CaseLearningLog where mId = " + ""+ objCaseLearningLogEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objCaseLearningLogEN.mId = TransNullToInt(objDT.Rows[0][conCaseLearningLog.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objCaseLearningLogEN.FuncModuleId = objDT.Rows[0][conCaseLearningLog.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objCaseLearningLogEN.CaseId = objDT.Rows[0][conCaseLearningLog.CaseId].ToString().Trim(); //案例Id(字段类型:char,字段长度:8,是否可空:True)
 objCaseLearningLogEN.CaseName = objDT.Rows[0][conCaseLearningLog.CaseName].ToString().Trim(); //案例名称(字段类型:varchar,字段长度:100,是否可空:True)
 objCaseLearningLogEN.OwnerId = objDT.Rows[0][conCaseLearningLog.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objCaseLearningLogEN.UserId = objDT.Rows[0][conCaseLearningLog.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objCaseLearningLogEN.LearnStartTime = objDT.Rows[0][conCaseLearningLog.LearnStartTime].ToString().Trim(); //开始时间(字段类型:varchar,字段长度:14,是否可空:False)
 objCaseLearningLogEN.LearnEndTime = objDT.Rows[0][conCaseLearningLog.LearnEndTime].ToString().Trim(); //结束时间(字段类型:varchar,字段长度:14,是否可空:False)
 objCaseLearningLogEN.VideoStartTime = TransNullToDouble(objDT.Rows[0][conCaseLearningLog.VideoStartTime].ToString().Trim()); //观看视频开始时间(字段类型:decimal,字段长度:10,是否可空:False)
 objCaseLearningLogEN.VideoEndTime = TransNullToDouble(objDT.Rows[0][conCaseLearningLog.VideoEndTime].ToString().Trim()); //观看视频结束时间(字段类型:decimal,字段长度:10,是否可空:False)
 objCaseLearningLogEN.IpAddress = objDT.Rows[0][conCaseLearningLog.IpAddress].ToString().Trim(); //Ip地址(字段类型:varchar,字段长度:50,是否可空:True)
 objCaseLearningLogEN.TimeLengthOfVideo = TransNullToDouble(objDT.Rows[0][conCaseLearningLog.TimeLengthOfVideo].ToString().Trim()); //视频时长(字段类型:decimal,字段长度:12,是否可空:True)
 objCaseLearningLogEN.Memo = objDT.Rows[0][conCaseLearningLog.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsCaseLearningLogDA: GetCaseLearningLog)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsCaseLearningLogEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseLearningLogDA.GetSpecSQLObj();
strSQL = "Select * from CaseLearningLog where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsCaseLearningLogEN objCaseLearningLogEN = new clsCaseLearningLogEN();
try
{
 objCaseLearningLogEN.mId = Int32.Parse(objRow[conCaseLearningLog.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objCaseLearningLogEN.FuncModuleId = objRow[conCaseLearningLog.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objCaseLearningLogEN.CaseId = objRow[conCaseLearningLog.CaseId].ToString().Trim(); //案例Id(字段类型:char,字段长度:8,是否可空:True)
 objCaseLearningLogEN.CaseName = objRow[conCaseLearningLog.CaseName] == DBNull.Value ? null : objRow[conCaseLearningLog.CaseName].ToString().Trim(); //案例名称(字段类型:varchar,字段长度:100,是否可空:True)
 objCaseLearningLogEN.OwnerId = objRow[conCaseLearningLog.OwnerId] == DBNull.Value ? null : objRow[conCaseLearningLog.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objCaseLearningLogEN.UserId = objRow[conCaseLearningLog.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objCaseLearningLogEN.LearnStartTime = objRow[conCaseLearningLog.LearnStartTime].ToString().Trim(); //开始时间(字段类型:varchar,字段长度:14,是否可空:False)
 objCaseLearningLogEN.LearnEndTime = objRow[conCaseLearningLog.LearnEndTime].ToString().Trim(); //结束时间(字段类型:varchar,字段长度:14,是否可空:False)
 objCaseLearningLogEN.VideoStartTime = Double.Parse(objRow[conCaseLearningLog.VideoStartTime].ToString().Trim()); //观看视频开始时间(字段类型:decimal,字段长度:10,是否可空:False)
 objCaseLearningLogEN.VideoEndTime = Double.Parse(objRow[conCaseLearningLog.VideoEndTime].ToString().Trim()); //观看视频结束时间(字段类型:decimal,字段长度:10,是否可空:False)
 objCaseLearningLogEN.IpAddress = objRow[conCaseLearningLog.IpAddress] == DBNull.Value ? null : objRow[conCaseLearningLog.IpAddress].ToString().Trim(); //Ip地址(字段类型:varchar,字段长度:50,是否可空:True)
 objCaseLearningLogEN.TimeLengthOfVideo = objRow[conCaseLearningLog.TimeLengthOfVideo] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCaseLearningLog.TimeLengthOfVideo].ToString().Trim()); //视频时长(字段类型:decimal,字段长度:12,是否可空:True)
 objCaseLearningLogEN.Memo = objRow[conCaseLearningLog.Memo] == DBNull.Value ? null : objRow[conCaseLearningLog.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsCaseLearningLogDA: GetObjBymId)", objException.Message));
}
return objCaseLearningLogEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsCaseLearningLogEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsCaseLearningLogDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseLearningLogDA.GetSpecSQLObj();
strSQL = "Select * from CaseLearningLog where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsCaseLearningLogEN objCaseLearningLogEN = new clsCaseLearningLogEN()
{
mId = TransNullToInt(objRow[conCaseLearningLog.mId].ToString().Trim()), //mId
FuncModuleId = objRow[conCaseLearningLog.FuncModuleId].ToString().Trim(), //功能模块Id
CaseId = objRow[conCaseLearningLog.CaseId].ToString().Trim(), //案例Id
CaseName = objRow[conCaseLearningLog.CaseName] == DBNull.Value ? null : objRow[conCaseLearningLog.CaseName].ToString().Trim(), //案例名称
OwnerId = objRow[conCaseLearningLog.OwnerId] == DBNull.Value ? null : objRow[conCaseLearningLog.OwnerId].ToString().Trim(), //拥有者Id
UserId = objRow[conCaseLearningLog.UserId].ToString().Trim(), //用户ID
LearnStartTime = objRow[conCaseLearningLog.LearnStartTime].ToString().Trim(), //开始时间
LearnEndTime = objRow[conCaseLearningLog.LearnEndTime].ToString().Trim(), //结束时间
VideoStartTime = TransNullToDouble(objRow[conCaseLearningLog.VideoStartTime].ToString().Trim()), //观看视频开始时间
VideoEndTime = TransNullToDouble(objRow[conCaseLearningLog.VideoEndTime].ToString().Trim()), //观看视频结束时间
IpAddress = objRow[conCaseLearningLog.IpAddress] == DBNull.Value ? null : objRow[conCaseLearningLog.IpAddress].ToString().Trim(), //Ip地址
TimeLengthOfVideo = objRow[conCaseLearningLog.TimeLengthOfVideo] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCaseLearningLog.TimeLengthOfVideo].ToString().Trim()), //视频时长
Memo = objRow[conCaseLearningLog.Memo] == DBNull.Value ? null : objRow[conCaseLearningLog.Memo].ToString().Trim() //备注
};
objCaseLearningLogEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCaseLearningLogEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsCaseLearningLogDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsCaseLearningLogEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCaseLearningLogEN objCaseLearningLogEN = new clsCaseLearningLogEN();
try
{
objCaseLearningLogEN.mId = TransNullToInt(objRow[conCaseLearningLog.mId].ToString().Trim()); //mId
objCaseLearningLogEN.FuncModuleId = objRow[conCaseLearningLog.FuncModuleId].ToString().Trim(); //功能模块Id
objCaseLearningLogEN.CaseId = objRow[conCaseLearningLog.CaseId].ToString().Trim(); //案例Id
objCaseLearningLogEN.CaseName = objRow[conCaseLearningLog.CaseName] == DBNull.Value ? null : objRow[conCaseLearningLog.CaseName].ToString().Trim(); //案例名称
objCaseLearningLogEN.OwnerId = objRow[conCaseLearningLog.OwnerId] == DBNull.Value ? null : objRow[conCaseLearningLog.OwnerId].ToString().Trim(); //拥有者Id
objCaseLearningLogEN.UserId = objRow[conCaseLearningLog.UserId].ToString().Trim(); //用户ID
objCaseLearningLogEN.LearnStartTime = objRow[conCaseLearningLog.LearnStartTime].ToString().Trim(); //开始时间
objCaseLearningLogEN.LearnEndTime = objRow[conCaseLearningLog.LearnEndTime].ToString().Trim(); //结束时间
objCaseLearningLogEN.VideoStartTime = TransNullToDouble(objRow[conCaseLearningLog.VideoStartTime].ToString().Trim()); //观看视频开始时间
objCaseLearningLogEN.VideoEndTime = TransNullToDouble(objRow[conCaseLearningLog.VideoEndTime].ToString().Trim()); //观看视频结束时间
objCaseLearningLogEN.IpAddress = objRow[conCaseLearningLog.IpAddress] == DBNull.Value ? null : objRow[conCaseLearningLog.IpAddress].ToString().Trim(); //Ip地址
objCaseLearningLogEN.TimeLengthOfVideo = objRow[conCaseLearningLog.TimeLengthOfVideo] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCaseLearningLog.TimeLengthOfVideo].ToString().Trim()); //视频时长
objCaseLearningLogEN.Memo = objRow[conCaseLearningLog.Memo] == DBNull.Value ? null : objRow[conCaseLearningLog.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsCaseLearningLogDA: GetObjByDataRowCaseLearningLog)", objException.Message));
}
objCaseLearningLogEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCaseLearningLogEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsCaseLearningLogEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCaseLearningLogEN objCaseLearningLogEN = new clsCaseLearningLogEN();
try
{
objCaseLearningLogEN.mId = TransNullToInt(objRow[conCaseLearningLog.mId].ToString().Trim()); //mId
objCaseLearningLogEN.FuncModuleId = objRow[conCaseLearningLog.FuncModuleId].ToString().Trim(); //功能模块Id
objCaseLearningLogEN.CaseId = objRow[conCaseLearningLog.CaseId].ToString().Trim(); //案例Id
objCaseLearningLogEN.CaseName = objRow[conCaseLearningLog.CaseName] == DBNull.Value ? null : objRow[conCaseLearningLog.CaseName].ToString().Trim(); //案例名称
objCaseLearningLogEN.OwnerId = objRow[conCaseLearningLog.OwnerId] == DBNull.Value ? null : objRow[conCaseLearningLog.OwnerId].ToString().Trim(); //拥有者Id
objCaseLearningLogEN.UserId = objRow[conCaseLearningLog.UserId].ToString().Trim(); //用户ID
objCaseLearningLogEN.LearnStartTime = objRow[conCaseLearningLog.LearnStartTime].ToString().Trim(); //开始时间
objCaseLearningLogEN.LearnEndTime = objRow[conCaseLearningLog.LearnEndTime].ToString().Trim(); //结束时间
objCaseLearningLogEN.VideoStartTime = TransNullToDouble(objRow[conCaseLearningLog.VideoStartTime].ToString().Trim()); //观看视频开始时间
objCaseLearningLogEN.VideoEndTime = TransNullToDouble(objRow[conCaseLearningLog.VideoEndTime].ToString().Trim()); //观看视频结束时间
objCaseLearningLogEN.IpAddress = objRow[conCaseLearningLog.IpAddress] == DBNull.Value ? null : objRow[conCaseLearningLog.IpAddress].ToString().Trim(); //Ip地址
objCaseLearningLogEN.TimeLengthOfVideo = objRow[conCaseLearningLog.TimeLengthOfVideo] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCaseLearningLog.TimeLengthOfVideo].ToString().Trim()); //视频时长
objCaseLearningLogEN.Memo = objRow[conCaseLearningLog.Memo] == DBNull.Value ? null : objRow[conCaseLearningLog.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsCaseLearningLogDA: GetObjByDataRow)", objException.Message));
}
objCaseLearningLogEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCaseLearningLogEN;
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
objSQL = clsCaseLearningLogDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCaseLearningLogEN._CurrTabName, conCaseLearningLog.mId, 8, "");
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
objSQL = clsCaseLearningLogDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCaseLearningLogEN._CurrTabName, conCaseLearningLog.mId, 8, strPrefix);
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
 objSQL = clsCaseLearningLogDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from CaseLearningLog where " + strCondition;
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
 objSQL = clsCaseLearningLogDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from CaseLearningLog where " + strCondition;
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngmId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseLearningLogDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CaseLearningLog", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsCaseLearningLogDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseLearningLogDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CaseLearningLog", strCondition))
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
objSQL = clsCaseLearningLogDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("CaseLearningLog");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsCaseLearningLogEN objCaseLearningLogEN)
 {
 if (objCaseLearningLogEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCaseLearningLogEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseLearningLogDA.GetSpecSQLObj();
strSQL = "Select * from CaseLearningLog where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CaseLearningLog");
objRow = objDS.Tables["CaseLearningLog"].NewRow();
objRow[conCaseLearningLog.FuncModuleId] = objCaseLearningLogEN.FuncModuleId; //功能模块Id
objRow[conCaseLearningLog.CaseId] = objCaseLearningLogEN.CaseId; //案例Id
 if (objCaseLearningLogEN.CaseName !=  "")
 {
objRow[conCaseLearningLog.CaseName] = objCaseLearningLogEN.CaseName; //案例名称
 }
 if (objCaseLearningLogEN.OwnerId !=  "")
 {
objRow[conCaseLearningLog.OwnerId] = objCaseLearningLogEN.OwnerId; //拥有者Id
 }
objRow[conCaseLearningLog.UserId] = objCaseLearningLogEN.UserId; //用户ID
objRow[conCaseLearningLog.LearnStartTime] = objCaseLearningLogEN.LearnStartTime; //开始时间
objRow[conCaseLearningLog.LearnEndTime] = objCaseLearningLogEN.LearnEndTime; //结束时间
objRow[conCaseLearningLog.VideoStartTime] = objCaseLearningLogEN.VideoStartTime; //观看视频开始时间
objRow[conCaseLearningLog.VideoEndTime] = objCaseLearningLogEN.VideoEndTime; //观看视频结束时间
 if (objCaseLearningLogEN.IpAddress !=  "")
 {
objRow[conCaseLearningLog.IpAddress] = objCaseLearningLogEN.IpAddress; //Ip地址
 }
objRow[conCaseLearningLog.TimeLengthOfVideo] = objCaseLearningLogEN.TimeLengthOfVideo; //视频时长
 if (objCaseLearningLogEN.Memo !=  "")
 {
objRow[conCaseLearningLog.Memo] = objCaseLearningLogEN.Memo; //备注
 }
objDS.Tables[clsCaseLearningLogEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsCaseLearningLogEN._CurrTabName);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
return true;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2)
 /// </summary>
 /// <param name = "objCaseLearningLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCaseLearningLogEN objCaseLearningLogEN)
{
 if (objCaseLearningLogEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCaseLearningLogEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objCaseLearningLogEN.FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conCaseLearningLog.FuncModuleId);
 var strFuncModuleId = objCaseLearningLogEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId + "'");
 }
 
 if (objCaseLearningLogEN.CaseId !=  null)
 {
 arrFieldListForInsert.Add(conCaseLearningLog.CaseId);
 var strCaseId = objCaseLearningLogEN.CaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseId + "'");
 }
 
 if (objCaseLearningLogEN.CaseName !=  null)
 {
 arrFieldListForInsert.Add(conCaseLearningLog.CaseName);
 var strCaseName = objCaseLearningLogEN.CaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseName + "'");
 }
 
 if (objCaseLearningLogEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conCaseLearningLog.OwnerId);
 var strOwnerId = objCaseLearningLogEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 if (objCaseLearningLogEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conCaseLearningLog.UserId);
 var strUserId = objCaseLearningLogEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objCaseLearningLogEN.LearnStartTime !=  null)
 {
 arrFieldListForInsert.Add(conCaseLearningLog.LearnStartTime);
 var strLearnStartTime = objCaseLearningLogEN.LearnStartTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLearnStartTime + "'");
 }
 
 if (objCaseLearningLogEN.LearnEndTime !=  null)
 {
 arrFieldListForInsert.Add(conCaseLearningLog.LearnEndTime);
 var strLearnEndTime = objCaseLearningLogEN.LearnEndTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLearnEndTime + "'");
 }
 
 arrFieldListForInsert.Add(conCaseLearningLog.VideoStartTime);
 arrValueListForInsert.Add(objCaseLearningLogEN.VideoStartTime.ToString());
 
 arrFieldListForInsert.Add(conCaseLearningLog.VideoEndTime);
 arrValueListForInsert.Add(objCaseLearningLogEN.VideoEndTime.ToString());
 
 if (objCaseLearningLogEN.IpAddress !=  null)
 {
 arrFieldListForInsert.Add(conCaseLearningLog.IpAddress);
 var strIpAddress = objCaseLearningLogEN.IpAddress.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIpAddress + "'");
 }
 
 if (objCaseLearningLogEN.TimeLengthOfVideo !=  null)
 {
 arrFieldListForInsert.Add(conCaseLearningLog.TimeLengthOfVideo);
 arrValueListForInsert.Add(objCaseLearningLogEN.TimeLengthOfVideo.ToString());
 }
 
 if (objCaseLearningLogEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCaseLearningLog.Memo);
 var strMemo = objCaseLearningLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CaseLearningLog");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseLearningLogDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objCaseLearningLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsCaseLearningLogEN objCaseLearningLogEN)
{
 if (objCaseLearningLogEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCaseLearningLogEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objCaseLearningLogEN.FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conCaseLearningLog.FuncModuleId);
 var strFuncModuleId = objCaseLearningLogEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId + "'");
 }
 
 if (objCaseLearningLogEN.CaseId !=  null)
 {
 arrFieldListForInsert.Add(conCaseLearningLog.CaseId);
 var strCaseId = objCaseLearningLogEN.CaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseId + "'");
 }
 
 if (objCaseLearningLogEN.CaseName !=  null)
 {
 arrFieldListForInsert.Add(conCaseLearningLog.CaseName);
 var strCaseName = objCaseLearningLogEN.CaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseName + "'");
 }
 
 if (objCaseLearningLogEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conCaseLearningLog.OwnerId);
 var strOwnerId = objCaseLearningLogEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 if (objCaseLearningLogEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conCaseLearningLog.UserId);
 var strUserId = objCaseLearningLogEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objCaseLearningLogEN.LearnStartTime !=  null)
 {
 arrFieldListForInsert.Add(conCaseLearningLog.LearnStartTime);
 var strLearnStartTime = objCaseLearningLogEN.LearnStartTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLearnStartTime + "'");
 }
 
 if (objCaseLearningLogEN.LearnEndTime !=  null)
 {
 arrFieldListForInsert.Add(conCaseLearningLog.LearnEndTime);
 var strLearnEndTime = objCaseLearningLogEN.LearnEndTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLearnEndTime + "'");
 }
 
 arrFieldListForInsert.Add(conCaseLearningLog.VideoStartTime);
 arrValueListForInsert.Add(objCaseLearningLogEN.VideoStartTime.ToString());
 
 arrFieldListForInsert.Add(conCaseLearningLog.VideoEndTime);
 arrValueListForInsert.Add(objCaseLearningLogEN.VideoEndTime.ToString());
 
 if (objCaseLearningLogEN.IpAddress !=  null)
 {
 arrFieldListForInsert.Add(conCaseLearningLog.IpAddress);
 var strIpAddress = objCaseLearningLogEN.IpAddress.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIpAddress + "'");
 }
 
 if (objCaseLearningLogEN.TimeLengthOfVideo !=  null)
 {
 arrFieldListForInsert.Add(conCaseLearningLog.TimeLengthOfVideo);
 arrValueListForInsert.Add(objCaseLearningLogEN.TimeLengthOfVideo.ToString());
 }
 
 if (objCaseLearningLogEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCaseLearningLog.Memo);
 var strMemo = objCaseLearningLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CaseLearningLog");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseLearningLogDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objCaseLearningLogEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsCaseLearningLogEN objCaseLearningLogEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objCaseLearningLogEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCaseLearningLogEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objCaseLearningLogEN.FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conCaseLearningLog.FuncModuleId);
 var strFuncModuleId = objCaseLearningLogEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId + "'");
 }
 
 if (objCaseLearningLogEN.CaseId !=  null)
 {
 arrFieldListForInsert.Add(conCaseLearningLog.CaseId);
 var strCaseId = objCaseLearningLogEN.CaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseId + "'");
 }
 
 if (objCaseLearningLogEN.CaseName !=  null)
 {
 arrFieldListForInsert.Add(conCaseLearningLog.CaseName);
 var strCaseName = objCaseLearningLogEN.CaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseName + "'");
 }
 
 if (objCaseLearningLogEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conCaseLearningLog.OwnerId);
 var strOwnerId = objCaseLearningLogEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 if (objCaseLearningLogEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conCaseLearningLog.UserId);
 var strUserId = objCaseLearningLogEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objCaseLearningLogEN.LearnStartTime !=  null)
 {
 arrFieldListForInsert.Add(conCaseLearningLog.LearnStartTime);
 var strLearnStartTime = objCaseLearningLogEN.LearnStartTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLearnStartTime + "'");
 }
 
 if (objCaseLearningLogEN.LearnEndTime !=  null)
 {
 arrFieldListForInsert.Add(conCaseLearningLog.LearnEndTime);
 var strLearnEndTime = objCaseLearningLogEN.LearnEndTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLearnEndTime + "'");
 }
 
 arrFieldListForInsert.Add(conCaseLearningLog.VideoStartTime);
 arrValueListForInsert.Add(objCaseLearningLogEN.VideoStartTime.ToString());
 
 arrFieldListForInsert.Add(conCaseLearningLog.VideoEndTime);
 arrValueListForInsert.Add(objCaseLearningLogEN.VideoEndTime.ToString());
 
 if (objCaseLearningLogEN.IpAddress !=  null)
 {
 arrFieldListForInsert.Add(conCaseLearningLog.IpAddress);
 var strIpAddress = objCaseLearningLogEN.IpAddress.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIpAddress + "'");
 }
 
 if (objCaseLearningLogEN.TimeLengthOfVideo !=  null)
 {
 arrFieldListForInsert.Add(conCaseLearningLog.TimeLengthOfVideo);
 arrValueListForInsert.Add(objCaseLearningLogEN.TimeLengthOfVideo.ToString());
 }
 
 if (objCaseLearningLogEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCaseLearningLog.Memo);
 var strMemo = objCaseLearningLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CaseLearningLog");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseLearningLogDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objCaseLearningLogEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCaseLearningLogEN objCaseLearningLogEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objCaseLearningLogEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCaseLearningLogEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objCaseLearningLogEN.FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conCaseLearningLog.FuncModuleId);
 var strFuncModuleId = objCaseLearningLogEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId + "'");
 }
 
 if (objCaseLearningLogEN.CaseId !=  null)
 {
 arrFieldListForInsert.Add(conCaseLearningLog.CaseId);
 var strCaseId = objCaseLearningLogEN.CaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseId + "'");
 }
 
 if (objCaseLearningLogEN.CaseName !=  null)
 {
 arrFieldListForInsert.Add(conCaseLearningLog.CaseName);
 var strCaseName = objCaseLearningLogEN.CaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseName + "'");
 }
 
 if (objCaseLearningLogEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conCaseLearningLog.OwnerId);
 var strOwnerId = objCaseLearningLogEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 if (objCaseLearningLogEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conCaseLearningLog.UserId);
 var strUserId = objCaseLearningLogEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objCaseLearningLogEN.LearnStartTime !=  null)
 {
 arrFieldListForInsert.Add(conCaseLearningLog.LearnStartTime);
 var strLearnStartTime = objCaseLearningLogEN.LearnStartTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLearnStartTime + "'");
 }
 
 if (objCaseLearningLogEN.LearnEndTime !=  null)
 {
 arrFieldListForInsert.Add(conCaseLearningLog.LearnEndTime);
 var strLearnEndTime = objCaseLearningLogEN.LearnEndTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLearnEndTime + "'");
 }
 
 arrFieldListForInsert.Add(conCaseLearningLog.VideoStartTime);
 arrValueListForInsert.Add(objCaseLearningLogEN.VideoStartTime.ToString());
 
 arrFieldListForInsert.Add(conCaseLearningLog.VideoEndTime);
 arrValueListForInsert.Add(objCaseLearningLogEN.VideoEndTime.ToString());
 
 if (objCaseLearningLogEN.IpAddress !=  null)
 {
 arrFieldListForInsert.Add(conCaseLearningLog.IpAddress);
 var strIpAddress = objCaseLearningLogEN.IpAddress.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIpAddress + "'");
 }
 
 if (objCaseLearningLogEN.TimeLengthOfVideo !=  null)
 {
 arrFieldListForInsert.Add(conCaseLearningLog.TimeLengthOfVideo);
 arrValueListForInsert.Add(objCaseLearningLogEN.TimeLengthOfVideo.ToString());
 }
 
 if (objCaseLearningLogEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCaseLearningLog.Memo);
 var strMemo = objCaseLearningLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CaseLearningLog");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseLearningLogDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewCaseLearningLogs(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseLearningLogDA.GetSpecSQLObj();
strSQL = "Select * from CaseLearningLog where mId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CaseLearningLog");
//检查关键字的唯一性
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsCaseLearningLogEN._CurrTabName ].NewRow();
objRow[conCaseLearningLog.FuncModuleId] = oRow[conCaseLearningLog.FuncModuleId].ToString().Trim(); //功能模块Id
objRow[conCaseLearningLog.CaseId] = oRow[conCaseLearningLog.CaseId].ToString().Trim(); //案例Id
objRow[conCaseLearningLog.CaseName] = oRow[conCaseLearningLog.CaseName].ToString().Trim(); //案例名称
objRow[conCaseLearningLog.OwnerId] = oRow[conCaseLearningLog.OwnerId].ToString().Trim(); //拥有者Id
objRow[conCaseLearningLog.UserId] = oRow[conCaseLearningLog.UserId].ToString().Trim(); //用户ID
objRow[conCaseLearningLog.LearnStartTime] = oRow[conCaseLearningLog.LearnStartTime].ToString().Trim(); //开始时间
objRow[conCaseLearningLog.LearnEndTime] = oRow[conCaseLearningLog.LearnEndTime].ToString().Trim(); //结束时间
objRow[conCaseLearningLog.VideoStartTime] = oRow[conCaseLearningLog.VideoStartTime].ToString().Trim(); //观看视频开始时间
objRow[conCaseLearningLog.VideoEndTime] = oRow[conCaseLearningLog.VideoEndTime].ToString().Trim(); //观看视频结束时间
objRow[conCaseLearningLog.IpAddress] = oRow[conCaseLearningLog.IpAddress].ToString().Trim(); //Ip地址
objRow[conCaseLearningLog.TimeLengthOfVideo] = oRow[conCaseLearningLog.TimeLengthOfVideo].ToString().Trim(); //视频时长
objRow[conCaseLearningLog.Memo] = oRow[conCaseLearningLog.Memo].ToString().Trim(); //备注
 objDS.Tables[clsCaseLearningLogEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsCaseLearningLogEN._CurrTabName);
}
catch(Exception objException) 
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
objSQL.SQLConnect.Close();
}
return true;
}

 #endregion 添加记录

 #region 修改记录

 /// <summary>
 /// 功能:通过ADO修改记录
 /// (AutoGCLib.DALCode4CSharp:GenUpdate)
 /// </summary>
 /// <param name = "objCaseLearningLogEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsCaseLearningLogEN objCaseLearningLogEN)
{
 if (objCaseLearningLogEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCaseLearningLogEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseLearningLogDA.GetSpecSQLObj();
strSQL = "Select * from CaseLearningLog where mId = " + ""+ objCaseLearningLogEN.mId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsCaseLearningLogEN._CurrTabName);
if (objDS.Tables[clsCaseLearningLogEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:mId = " + ""+ objCaseLearningLogEN.mId+"");
return false;
}
objRow = objDS.Tables[clsCaseLearningLogEN._CurrTabName].Rows[0];
 if (objCaseLearningLogEN.IsUpdated(conCaseLearningLog.FuncModuleId))
 {
objRow[conCaseLearningLog.FuncModuleId] = objCaseLearningLogEN.FuncModuleId; //功能模块Id
 }
 if (objCaseLearningLogEN.IsUpdated(conCaseLearningLog.CaseId))
 {
objRow[conCaseLearningLog.CaseId] = objCaseLearningLogEN.CaseId; //案例Id
 }
 if (objCaseLearningLogEN.IsUpdated(conCaseLearningLog.CaseName))
 {
objRow[conCaseLearningLog.CaseName] = objCaseLearningLogEN.CaseName; //案例名称
 }
 if (objCaseLearningLogEN.IsUpdated(conCaseLearningLog.OwnerId))
 {
objRow[conCaseLearningLog.OwnerId] = objCaseLearningLogEN.OwnerId; //拥有者Id
 }
 if (objCaseLearningLogEN.IsUpdated(conCaseLearningLog.UserId))
 {
objRow[conCaseLearningLog.UserId] = objCaseLearningLogEN.UserId; //用户ID
 }
 if (objCaseLearningLogEN.IsUpdated(conCaseLearningLog.LearnStartTime))
 {
objRow[conCaseLearningLog.LearnStartTime] = objCaseLearningLogEN.LearnStartTime; //开始时间
 }
 if (objCaseLearningLogEN.IsUpdated(conCaseLearningLog.LearnEndTime))
 {
objRow[conCaseLearningLog.LearnEndTime] = objCaseLearningLogEN.LearnEndTime; //结束时间
 }
 if (objCaseLearningLogEN.IsUpdated(conCaseLearningLog.VideoStartTime))
 {
objRow[conCaseLearningLog.VideoStartTime] = objCaseLearningLogEN.VideoStartTime; //观看视频开始时间
 }
 if (objCaseLearningLogEN.IsUpdated(conCaseLearningLog.VideoEndTime))
 {
objRow[conCaseLearningLog.VideoEndTime] = objCaseLearningLogEN.VideoEndTime; //观看视频结束时间
 }
 if (objCaseLearningLogEN.IsUpdated(conCaseLearningLog.IpAddress))
 {
objRow[conCaseLearningLog.IpAddress] = objCaseLearningLogEN.IpAddress; //Ip地址
 }
 if (objCaseLearningLogEN.IsUpdated(conCaseLearningLog.TimeLengthOfVideo))
 {
objRow[conCaseLearningLog.TimeLengthOfVideo] = objCaseLearningLogEN.TimeLengthOfVideo; //视频时长
 }
 if (objCaseLearningLogEN.IsUpdated(conCaseLearningLog.Memo))
 {
objRow[conCaseLearningLog.Memo] = objCaseLearningLogEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsCaseLearningLogEN._CurrTabName);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
return true;
}


 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySql2)
 /// </summary>
 /// <param name = "objCaseLearningLogEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCaseLearningLogEN objCaseLearningLogEN)
{
 if (objCaseLearningLogEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCaseLearningLogEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseLearningLogDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update CaseLearningLog Set ");
 
 if (objCaseLearningLogEN.IsUpdated(conCaseLearningLog.FuncModuleId))
 {
 if (objCaseLearningLogEN.FuncModuleId !=  null)
 {
 var strFuncModuleId = objCaseLearningLogEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncModuleId, conCaseLearningLog.FuncModuleId); //功能模块Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseLearningLog.FuncModuleId); //功能模块Id
 }
 }
 
 if (objCaseLearningLogEN.IsUpdated(conCaseLearningLog.CaseId))
 {
 if (objCaseLearningLogEN.CaseId !=  null)
 {
 var strCaseId = objCaseLearningLogEN.CaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseId, conCaseLearningLog.CaseId); //案例Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseLearningLog.CaseId); //案例Id
 }
 }
 
 if (objCaseLearningLogEN.IsUpdated(conCaseLearningLog.CaseName))
 {
 if (objCaseLearningLogEN.CaseName !=  null)
 {
 var strCaseName = objCaseLearningLogEN.CaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseName, conCaseLearningLog.CaseName); //案例名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseLearningLog.CaseName); //案例名称
 }
 }
 
 if (objCaseLearningLogEN.IsUpdated(conCaseLearningLog.OwnerId))
 {
 if (objCaseLearningLogEN.OwnerId !=  null)
 {
 var strOwnerId = objCaseLearningLogEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOwnerId, conCaseLearningLog.OwnerId); //拥有者Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseLearningLog.OwnerId); //拥有者Id
 }
 }
 
 if (objCaseLearningLogEN.IsUpdated(conCaseLearningLog.UserId))
 {
 if (objCaseLearningLogEN.UserId !=  null)
 {
 var strUserId = objCaseLearningLogEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conCaseLearningLog.UserId); //用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseLearningLog.UserId); //用户ID
 }
 }
 
 if (objCaseLearningLogEN.IsUpdated(conCaseLearningLog.LearnStartTime))
 {
 if (objCaseLearningLogEN.LearnStartTime !=  null)
 {
 var strLearnStartTime = objCaseLearningLogEN.LearnStartTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLearnStartTime, conCaseLearningLog.LearnStartTime); //开始时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseLearningLog.LearnStartTime); //开始时间
 }
 }
 
 if (objCaseLearningLogEN.IsUpdated(conCaseLearningLog.LearnEndTime))
 {
 if (objCaseLearningLogEN.LearnEndTime !=  null)
 {
 var strLearnEndTime = objCaseLearningLogEN.LearnEndTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLearnEndTime, conCaseLearningLog.LearnEndTime); //结束时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseLearningLog.LearnEndTime); //结束时间
 }
 }
 
 if (objCaseLearningLogEN.IsUpdated(conCaseLearningLog.VideoStartTime))
 {
 sbSQL.AppendFormat("{1} = {0},",objCaseLearningLogEN.VideoStartTime, conCaseLearningLog.VideoStartTime); //观看视频开始时间
 }
 
 if (objCaseLearningLogEN.IsUpdated(conCaseLearningLog.VideoEndTime))
 {
 sbSQL.AppendFormat("{1} = {0},",objCaseLearningLogEN.VideoEndTime, conCaseLearningLog.VideoEndTime); //观看视频结束时间
 }
 
 if (objCaseLearningLogEN.IsUpdated(conCaseLearningLog.IpAddress))
 {
 if (objCaseLearningLogEN.IpAddress !=  null)
 {
 var strIpAddress = objCaseLearningLogEN.IpAddress.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIpAddress, conCaseLearningLog.IpAddress); //Ip地址
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseLearningLog.IpAddress); //Ip地址
 }
 }
 
 if (objCaseLearningLogEN.IsUpdated(conCaseLearningLog.TimeLengthOfVideo))
 {
 if (objCaseLearningLogEN.TimeLengthOfVideo !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCaseLearningLogEN.TimeLengthOfVideo, conCaseLearningLog.TimeLengthOfVideo); //视频时长
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseLearningLog.TimeLengthOfVideo); //视频时长
 }
 }
 
 if (objCaseLearningLogEN.IsUpdated(conCaseLearningLog.Memo))
 {
 if (objCaseLearningLogEN.Memo !=  null)
 {
 var strMemo = objCaseLearningLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conCaseLearningLog.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseLearningLog.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objCaseLearningLogEN.mId); 
 clsCheckSql.CheckSqlInjection4Update(sbSQL.ToString());
 return objSQL.ExecSql(sbSQL.ToString());
}
catch (Exception objException)
{
string strMsg = string.Format("发生错误:[{0}].SQL:[{1}].({2})",
     objException.Message, sbSQL.ToString(), clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
finally
{
}
}


 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySqlWithCondition)
 /// </summary>
 /// <param name = "objCaseLearningLogEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsCaseLearningLogEN objCaseLearningLogEN, string strCondition)
{
 if (objCaseLearningLogEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCaseLearningLogEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseLearningLogDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CaseLearningLog Set ");
 
 if (objCaseLearningLogEN.IsUpdated(conCaseLearningLog.FuncModuleId))
 {
 if (objCaseLearningLogEN.FuncModuleId !=  null)
 {
 var strFuncModuleId = objCaseLearningLogEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncModuleId = '{0}',", strFuncModuleId); //功能模块Id
 }
 else
 {
 sbSQL.Append(" FuncModuleId = null,"); //功能模块Id
 }
 }
 
 if (objCaseLearningLogEN.IsUpdated(conCaseLearningLog.CaseId))
 {
 if (objCaseLearningLogEN.CaseId !=  null)
 {
 var strCaseId = objCaseLearningLogEN.CaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseId = '{0}',", strCaseId); //案例Id
 }
 else
 {
 sbSQL.Append(" CaseId = null,"); //案例Id
 }
 }
 
 if (objCaseLearningLogEN.IsUpdated(conCaseLearningLog.CaseName))
 {
 if (objCaseLearningLogEN.CaseName !=  null)
 {
 var strCaseName = objCaseLearningLogEN.CaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseName = '{0}',", strCaseName); //案例名称
 }
 else
 {
 sbSQL.Append(" CaseName = null,"); //案例名称
 }
 }
 
 if (objCaseLearningLogEN.IsUpdated(conCaseLearningLog.OwnerId))
 {
 if (objCaseLearningLogEN.OwnerId !=  null)
 {
 var strOwnerId = objCaseLearningLogEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OwnerId = '{0}',", strOwnerId); //拥有者Id
 }
 else
 {
 sbSQL.Append(" OwnerId = null,"); //拥有者Id
 }
 }
 
 if (objCaseLearningLogEN.IsUpdated(conCaseLearningLog.UserId))
 {
 if (objCaseLearningLogEN.UserId !=  null)
 {
 var strUserId = objCaseLearningLogEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户ID
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户ID
 }
 }
 
 if (objCaseLearningLogEN.IsUpdated(conCaseLearningLog.LearnStartTime))
 {
 if (objCaseLearningLogEN.LearnStartTime !=  null)
 {
 var strLearnStartTime = objCaseLearningLogEN.LearnStartTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LearnStartTime = '{0}',", strLearnStartTime); //开始时间
 }
 else
 {
 sbSQL.Append(" LearnStartTime = null,"); //开始时间
 }
 }
 
 if (objCaseLearningLogEN.IsUpdated(conCaseLearningLog.LearnEndTime))
 {
 if (objCaseLearningLogEN.LearnEndTime !=  null)
 {
 var strLearnEndTime = objCaseLearningLogEN.LearnEndTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LearnEndTime = '{0}',", strLearnEndTime); //结束时间
 }
 else
 {
 sbSQL.Append(" LearnEndTime = null,"); //结束时间
 }
 }
 
 if (objCaseLearningLogEN.IsUpdated(conCaseLearningLog.VideoStartTime))
 {
 sbSQL.AppendFormat(" VideoStartTime = {0},", objCaseLearningLogEN.VideoStartTime); //观看视频开始时间
 }
 
 if (objCaseLearningLogEN.IsUpdated(conCaseLearningLog.VideoEndTime))
 {
 sbSQL.AppendFormat(" VideoEndTime = {0},", objCaseLearningLogEN.VideoEndTime); //观看视频结束时间
 }
 
 if (objCaseLearningLogEN.IsUpdated(conCaseLearningLog.IpAddress))
 {
 if (objCaseLearningLogEN.IpAddress !=  null)
 {
 var strIpAddress = objCaseLearningLogEN.IpAddress.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IpAddress = '{0}',", strIpAddress); //Ip地址
 }
 else
 {
 sbSQL.Append(" IpAddress = null,"); //Ip地址
 }
 }
 
 if (objCaseLearningLogEN.IsUpdated(conCaseLearningLog.TimeLengthOfVideo))
 {
 sbSQL.AppendFormat(" TimeLengthOfVideo = {0},", objCaseLearningLogEN.TimeLengthOfVideo); //视频时长
 }
 
 if (objCaseLearningLogEN.IsUpdated(conCaseLearningLog.Memo))
 {
 if (objCaseLearningLogEN.Memo !=  null)
 {
 var strMemo = objCaseLearningLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where {0}", strCondition); 
try
{
 clsCheckSql.CheckSqlInjection4Update(sbSQL.ToString());
 return objSQL.ExecSql(sbSQL.ToString());
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
}


 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式,根据条件修改记录.(带事务处理)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySqlWithConditionTransaction)
 /// </summary>
 /// <param name = "objCaseLearningLogEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsCaseLearningLogEN objCaseLearningLogEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objCaseLearningLogEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCaseLearningLogEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseLearningLogDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CaseLearningLog Set ");
 
 if (objCaseLearningLogEN.IsUpdated(conCaseLearningLog.FuncModuleId))
 {
 if (objCaseLearningLogEN.FuncModuleId !=  null)
 {
 var strFuncModuleId = objCaseLearningLogEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncModuleId = '{0}',", strFuncModuleId); //功能模块Id
 }
 else
 {
 sbSQL.Append(" FuncModuleId = null,"); //功能模块Id
 }
 }
 
 if (objCaseLearningLogEN.IsUpdated(conCaseLearningLog.CaseId))
 {
 if (objCaseLearningLogEN.CaseId !=  null)
 {
 var strCaseId = objCaseLearningLogEN.CaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseId = '{0}',", strCaseId); //案例Id
 }
 else
 {
 sbSQL.Append(" CaseId = null,"); //案例Id
 }
 }
 
 if (objCaseLearningLogEN.IsUpdated(conCaseLearningLog.CaseName))
 {
 if (objCaseLearningLogEN.CaseName !=  null)
 {
 var strCaseName = objCaseLearningLogEN.CaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseName = '{0}',", strCaseName); //案例名称
 }
 else
 {
 sbSQL.Append(" CaseName = null,"); //案例名称
 }
 }
 
 if (objCaseLearningLogEN.IsUpdated(conCaseLearningLog.OwnerId))
 {
 if (objCaseLearningLogEN.OwnerId !=  null)
 {
 var strOwnerId = objCaseLearningLogEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OwnerId = '{0}',", strOwnerId); //拥有者Id
 }
 else
 {
 sbSQL.Append(" OwnerId = null,"); //拥有者Id
 }
 }
 
 if (objCaseLearningLogEN.IsUpdated(conCaseLearningLog.UserId))
 {
 if (objCaseLearningLogEN.UserId !=  null)
 {
 var strUserId = objCaseLearningLogEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户ID
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户ID
 }
 }
 
 if (objCaseLearningLogEN.IsUpdated(conCaseLearningLog.LearnStartTime))
 {
 if (objCaseLearningLogEN.LearnStartTime !=  null)
 {
 var strLearnStartTime = objCaseLearningLogEN.LearnStartTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LearnStartTime = '{0}',", strLearnStartTime); //开始时间
 }
 else
 {
 sbSQL.Append(" LearnStartTime = null,"); //开始时间
 }
 }
 
 if (objCaseLearningLogEN.IsUpdated(conCaseLearningLog.LearnEndTime))
 {
 if (objCaseLearningLogEN.LearnEndTime !=  null)
 {
 var strLearnEndTime = objCaseLearningLogEN.LearnEndTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LearnEndTime = '{0}',", strLearnEndTime); //结束时间
 }
 else
 {
 sbSQL.Append(" LearnEndTime = null,"); //结束时间
 }
 }
 
 if (objCaseLearningLogEN.IsUpdated(conCaseLearningLog.VideoStartTime))
 {
 sbSQL.AppendFormat(" VideoStartTime = {0},", objCaseLearningLogEN.VideoStartTime); //观看视频开始时间
 }
 
 if (objCaseLearningLogEN.IsUpdated(conCaseLearningLog.VideoEndTime))
 {
 sbSQL.AppendFormat(" VideoEndTime = {0},", objCaseLearningLogEN.VideoEndTime); //观看视频结束时间
 }
 
 if (objCaseLearningLogEN.IsUpdated(conCaseLearningLog.IpAddress))
 {
 if (objCaseLearningLogEN.IpAddress !=  null)
 {
 var strIpAddress = objCaseLearningLogEN.IpAddress.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IpAddress = '{0}',", strIpAddress); //Ip地址
 }
 else
 {
 sbSQL.Append(" IpAddress = null,"); //Ip地址
 }
 }
 
 if (objCaseLearningLogEN.IsUpdated(conCaseLearningLog.TimeLengthOfVideo))
 {
 sbSQL.AppendFormat(" TimeLengthOfVideo = {0},", objCaseLearningLogEN.TimeLengthOfVideo); //视频时长
 }
 
 if (objCaseLearningLogEN.IsUpdated(conCaseLearningLog.Memo))
 {
 if (objCaseLearningLogEN.Memo !=  null)
 {
 var strMemo = objCaseLearningLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where {0}", strCondition); 
try
{
 clsCheckSql.CheckSqlInjection4Update(sbSQL.ToString());
 return objSQL.ExecSql(sbSQL.ToString(), objSqlConnection, objSqlTransaction);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
}


 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式.(带事务处理)
 /// /// 优点:1、能够处理字段中的单撇问题；
 /// /// 2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库;
 /// /// 3、支持事务处理.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySqlWithTransaction2)
 /// </summary>
 /// <param name = "objCaseLearningLogEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCaseLearningLogEN objCaseLearningLogEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objCaseLearningLogEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCaseLearningLogEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseLearningLogDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CaseLearningLog Set ");
 
 if (objCaseLearningLogEN.IsUpdated(conCaseLearningLog.FuncModuleId))
 {
 if (objCaseLearningLogEN.FuncModuleId !=  null)
 {
 var strFuncModuleId = objCaseLearningLogEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncModuleId, conCaseLearningLog.FuncModuleId); //功能模块Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseLearningLog.FuncModuleId); //功能模块Id
 }
 }
 
 if (objCaseLearningLogEN.IsUpdated(conCaseLearningLog.CaseId))
 {
 if (objCaseLearningLogEN.CaseId !=  null)
 {
 var strCaseId = objCaseLearningLogEN.CaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseId, conCaseLearningLog.CaseId); //案例Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseLearningLog.CaseId); //案例Id
 }
 }
 
 if (objCaseLearningLogEN.IsUpdated(conCaseLearningLog.CaseName))
 {
 if (objCaseLearningLogEN.CaseName !=  null)
 {
 var strCaseName = objCaseLearningLogEN.CaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseName, conCaseLearningLog.CaseName); //案例名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseLearningLog.CaseName); //案例名称
 }
 }
 
 if (objCaseLearningLogEN.IsUpdated(conCaseLearningLog.OwnerId))
 {
 if (objCaseLearningLogEN.OwnerId !=  null)
 {
 var strOwnerId = objCaseLearningLogEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOwnerId, conCaseLearningLog.OwnerId); //拥有者Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseLearningLog.OwnerId); //拥有者Id
 }
 }
 
 if (objCaseLearningLogEN.IsUpdated(conCaseLearningLog.UserId))
 {
 if (objCaseLearningLogEN.UserId !=  null)
 {
 var strUserId = objCaseLearningLogEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conCaseLearningLog.UserId); //用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseLearningLog.UserId); //用户ID
 }
 }
 
 if (objCaseLearningLogEN.IsUpdated(conCaseLearningLog.LearnStartTime))
 {
 if (objCaseLearningLogEN.LearnStartTime !=  null)
 {
 var strLearnStartTime = objCaseLearningLogEN.LearnStartTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLearnStartTime, conCaseLearningLog.LearnStartTime); //开始时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseLearningLog.LearnStartTime); //开始时间
 }
 }
 
 if (objCaseLearningLogEN.IsUpdated(conCaseLearningLog.LearnEndTime))
 {
 if (objCaseLearningLogEN.LearnEndTime !=  null)
 {
 var strLearnEndTime = objCaseLearningLogEN.LearnEndTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLearnEndTime, conCaseLearningLog.LearnEndTime); //结束时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseLearningLog.LearnEndTime); //结束时间
 }
 }
 
 if (objCaseLearningLogEN.IsUpdated(conCaseLearningLog.VideoStartTime))
 {
 sbSQL.AppendFormat("{1} = {0},",objCaseLearningLogEN.VideoStartTime, conCaseLearningLog.VideoStartTime); //观看视频开始时间
 }
 
 if (objCaseLearningLogEN.IsUpdated(conCaseLearningLog.VideoEndTime))
 {
 sbSQL.AppendFormat("{1} = {0},",objCaseLearningLogEN.VideoEndTime, conCaseLearningLog.VideoEndTime); //观看视频结束时间
 }
 
 if (objCaseLearningLogEN.IsUpdated(conCaseLearningLog.IpAddress))
 {
 if (objCaseLearningLogEN.IpAddress !=  null)
 {
 var strIpAddress = objCaseLearningLogEN.IpAddress.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIpAddress, conCaseLearningLog.IpAddress); //Ip地址
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseLearningLog.IpAddress); //Ip地址
 }
 }
 
 if (objCaseLearningLogEN.IsUpdated(conCaseLearningLog.TimeLengthOfVideo))
 {
 if (objCaseLearningLogEN.TimeLengthOfVideo !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCaseLearningLogEN.TimeLengthOfVideo, conCaseLearningLog.TimeLengthOfVideo); //视频时长
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseLearningLog.TimeLengthOfVideo); //视频时长
 }
 }
 
 if (objCaseLearningLogEN.IsUpdated(conCaseLearningLog.Memo))
 {
 if (objCaseLearningLogEN.Memo !=  null)
 {
 var strMemo = objCaseLearningLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conCaseLearningLog.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseLearningLog.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objCaseLearningLogEN.mId); 
try
{
 clsCheckSql.CheckSqlInjection4Update(sbSQL.ToString());
 return objSQL.ExecSql(sbSQL.ToString(), objSqlConnection, objSqlTransaction);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
}


 #endregion 修改记录

 #region 删除记录

 /// <summary>
 /// 功能:删除关键字所指定的记录,通过存储过程(SP)来删除。
 /// (AutoGCLib.DALCode4CSharp:GenDelRecordBySP)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngmId) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseLearningLogDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngmId,
};
 objSQL.ExecSP("CaseLearningLog_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngmId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseLearningLogDA.GetSpecSQLObj();
//删除CaseLearningLog本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CaseLearningLog where mId = " + ""+ lngmId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelCaseLearningLog(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseLearningLogDA.GetSpecSQLObj();
string strSQL;
string strKeyList;
if (lstKey.Count  == 0) return 0;
strKeyList = "";
for (int i = 0; i<lstKey.Count; i++)
{
if (i == 0) strKeyList = strKeyList + "" + lstKey[i].ToString() + "";
else strKeyList +=  "," + "" + lstKey[i].ToString() + "";
}
strSQL = "";
//删除CaseLearningLog本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CaseLearningLog where mId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngmId) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseLearningLogDA.GetSpecSQLObj();
//删除CaseLearningLog本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CaseLearningLog where mId = " + ""+ lngmId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelCaseLearningLog(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsCaseLearningLogDA: DelCaseLearningLog)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseLearningLogDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CaseLearningLog where " + strCondition ;
}
int intRecoCount = objSQL.ExecSql2(strSQL);
return intRecoCount;
}



 /// <summary>
 /// 功能:删除满足条件的多条记录,同时处理事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRecWithTransaction)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回是否删除成功。</returns>
public bool DelCaseLearningLogWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsCaseLearningLogDA: DelCaseLearningLogWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseLearningLogDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CaseLearningLog where " + strCondition ;
}
 bool bolResult = objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
return bolResult;
}


 #endregion 删除记录

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objCaseLearningLogENS">源对象</param>
 /// <param name = "objCaseLearningLogENT">目标对象</param>
public void CopyTo(clsCaseLearningLogEN objCaseLearningLogENS, clsCaseLearningLogEN objCaseLearningLogENT)
{
objCaseLearningLogENT.mId = objCaseLearningLogENS.mId; //mId
objCaseLearningLogENT.FuncModuleId = objCaseLearningLogENS.FuncModuleId; //功能模块Id
objCaseLearningLogENT.CaseId = objCaseLearningLogENS.CaseId; //案例Id
objCaseLearningLogENT.CaseName = objCaseLearningLogENS.CaseName; //案例名称
objCaseLearningLogENT.OwnerId = objCaseLearningLogENS.OwnerId; //拥有者Id
objCaseLearningLogENT.UserId = objCaseLearningLogENS.UserId; //用户ID
objCaseLearningLogENT.LearnStartTime = objCaseLearningLogENS.LearnStartTime; //开始时间
objCaseLearningLogENT.LearnEndTime = objCaseLearningLogENS.LearnEndTime; //结束时间
objCaseLearningLogENT.VideoStartTime = objCaseLearningLogENS.VideoStartTime; //观看视频开始时间
objCaseLearningLogENT.VideoEndTime = objCaseLearningLogENS.VideoEndTime; //观看视频结束时间
objCaseLearningLogENT.IpAddress = objCaseLearningLogENS.IpAddress; //Ip地址
objCaseLearningLogENT.TimeLengthOfVideo = objCaseLearningLogENS.TimeLengthOfVideo; //视频时长
objCaseLearningLogENT.Memo = objCaseLearningLogENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsCaseLearningLogEN objCaseLearningLogEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objCaseLearningLogEN.FuncModuleId, conCaseLearningLog.FuncModuleId);
clsCheckSql.CheckFieldNotNull(objCaseLearningLogEN.CaseId, conCaseLearningLog.CaseId);
clsCheckSql.CheckFieldNotNull(objCaseLearningLogEN.UserId, conCaseLearningLog.UserId);
clsCheckSql.CheckFieldNotNull(objCaseLearningLogEN.LearnStartTime, conCaseLearningLog.LearnStartTime);
clsCheckSql.CheckFieldNotNull(objCaseLearningLogEN.LearnEndTime, conCaseLearningLog.LearnEndTime);
clsCheckSql.CheckFieldNotNull(objCaseLearningLogEN.VideoStartTime, conCaseLearningLog.VideoStartTime);
clsCheckSql.CheckFieldNotNull(objCaseLearningLogEN.VideoEndTime, conCaseLearningLog.VideoEndTime);
//检查字段长度
clsCheckSql.CheckFieldLen(objCaseLearningLogEN.FuncModuleId, 4, conCaseLearningLog.FuncModuleId);
clsCheckSql.CheckFieldLen(objCaseLearningLogEN.CaseId, 8, conCaseLearningLog.CaseId);
clsCheckSql.CheckFieldLen(objCaseLearningLogEN.CaseName, 100, conCaseLearningLog.CaseName);
clsCheckSql.CheckFieldLen(objCaseLearningLogEN.OwnerId, 20, conCaseLearningLog.OwnerId);
clsCheckSql.CheckFieldLen(objCaseLearningLogEN.UserId, 18, conCaseLearningLog.UserId);
clsCheckSql.CheckFieldLen(objCaseLearningLogEN.LearnStartTime, 14, conCaseLearningLog.LearnStartTime);
clsCheckSql.CheckFieldLen(objCaseLearningLogEN.LearnEndTime, 14, conCaseLearningLog.LearnEndTime);
clsCheckSql.CheckFieldLen(objCaseLearningLogEN.IpAddress, 50, conCaseLearningLog.IpAddress);
clsCheckSql.CheckFieldLen(objCaseLearningLogEN.Memo, 1000, conCaseLearningLog.Memo);
//检查字段外键固定长度
 objCaseLearningLogEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsCaseLearningLogEN objCaseLearningLogEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCaseLearningLogEN.FuncModuleId, 4, conCaseLearningLog.FuncModuleId);
clsCheckSql.CheckFieldLen(objCaseLearningLogEN.CaseId, 8, conCaseLearningLog.CaseId);
clsCheckSql.CheckFieldLen(objCaseLearningLogEN.CaseName, 100, conCaseLearningLog.CaseName);
clsCheckSql.CheckFieldLen(objCaseLearningLogEN.OwnerId, 20, conCaseLearningLog.OwnerId);
clsCheckSql.CheckFieldLen(objCaseLearningLogEN.UserId, 18, conCaseLearningLog.UserId);
clsCheckSql.CheckFieldLen(objCaseLearningLogEN.LearnStartTime, 14, conCaseLearningLog.LearnStartTime);
clsCheckSql.CheckFieldLen(objCaseLearningLogEN.LearnEndTime, 14, conCaseLearningLog.LearnEndTime);
clsCheckSql.CheckFieldLen(objCaseLearningLogEN.IpAddress, 50, conCaseLearningLog.IpAddress);
clsCheckSql.CheckFieldLen(objCaseLearningLogEN.Memo, 1000, conCaseLearningLog.Memo);
//检查外键字段长度
 objCaseLearningLogEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsCaseLearningLogEN objCaseLearningLogEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCaseLearningLogEN.FuncModuleId, 4, conCaseLearningLog.FuncModuleId);
clsCheckSql.CheckFieldLen(objCaseLearningLogEN.CaseId, 8, conCaseLearningLog.CaseId);
clsCheckSql.CheckFieldLen(objCaseLearningLogEN.CaseName, 100, conCaseLearningLog.CaseName);
clsCheckSql.CheckFieldLen(objCaseLearningLogEN.OwnerId, 20, conCaseLearningLog.OwnerId);
clsCheckSql.CheckFieldLen(objCaseLearningLogEN.UserId, 18, conCaseLearningLog.UserId);
clsCheckSql.CheckFieldLen(objCaseLearningLogEN.LearnStartTime, 14, conCaseLearningLog.LearnStartTime);
clsCheckSql.CheckFieldLen(objCaseLearningLogEN.LearnEndTime, 14, conCaseLearningLog.LearnEndTime);
clsCheckSql.CheckFieldLen(objCaseLearningLogEN.IpAddress, 50, conCaseLearningLog.IpAddress);
clsCheckSql.CheckFieldLen(objCaseLearningLogEN.Memo, 1000, conCaseLearningLog.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objCaseLearningLogEN.FuncModuleId, conCaseLearningLog.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objCaseLearningLogEN.CaseId, conCaseLearningLog.CaseId);
clsCheckSql.CheckSqlInjection4Field(objCaseLearningLogEN.CaseName, conCaseLearningLog.CaseName);
clsCheckSql.CheckSqlInjection4Field(objCaseLearningLogEN.OwnerId, conCaseLearningLog.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objCaseLearningLogEN.UserId, conCaseLearningLog.UserId);
clsCheckSql.CheckSqlInjection4Field(objCaseLearningLogEN.LearnStartTime, conCaseLearningLog.LearnStartTime);
clsCheckSql.CheckSqlInjection4Field(objCaseLearningLogEN.LearnEndTime, conCaseLearningLog.LearnEndTime);
clsCheckSql.CheckSqlInjection4Field(objCaseLearningLogEN.IpAddress, conCaseLearningLog.IpAddress);
clsCheckSql.CheckSqlInjection4Field(objCaseLearningLogEN.Memo, conCaseLearningLog.Memo);
//检查外键字段长度
 objCaseLearningLogEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--CaseLearningLog(案例学习日志),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objCaseLearningLogEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsCaseLearningLogEN objCaseLearningLogEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CaseId = '{0}'", objCaseLearningLogEN.CaseId);
 if (objCaseLearningLogEN.OwnerId == null)
{
 sbCondition.AppendFormat(" and OwnerId is null");
}
else
{
 sbCondition.AppendFormat(" and OwnerId = '{0}'", objCaseLearningLogEN.OwnerId);
}
 sbCondition.AppendFormat(" and LearnStartTime = '{0}'", objCaseLearningLogEN.LearnStartTime);
 sbCondition.AppendFormat(" and VideoEndTime = '{0}'", objCaseLearningLogEN.VideoEndTime);
return sbCondition.ToString();
}

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
 objSQL = clsCaseLearningLogDA.GetSpecSQLObj();
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
 objSQL = clsCaseLearningLogDA.GetSpecSQLObj();
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
 objSQL = clsCaseLearningLogDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCaseLearningLogEN._CurrTabName);
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
 objSQL = clsCaseLearningLogDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCaseLearningLogEN._CurrTabName, strCondition);
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
 objSQL = clsCaseLearningLogDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 /// <summary>
 /// 功能:设置给定表中的符合条件的某字段的值
 /// (AutoGCLib.DALCode4CSharp:GenfunSetFldValue_S)
 /// </summary>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "varValue">值</param>
 /// <param name = "strCondition">条件串</param>
 /// <returns>影响的记录数</returns>
public static int SetFldValue<T>(string strTabName, string strFldName, T varValue, string strCondition) 
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseLearningLogDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}