
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsVideoResCaseDA
 表名:VideoResCase(01120371)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:47:00
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
 /// 视频资源案例(VideoResCase)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsVideoResCaseDA : clsCommBase4DA
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
 return clsVideoResCaseEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsVideoResCaseEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsVideoResCaseEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsVideoResCaseEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsVideoResCaseEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strIdVideoResCase">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strIdVideoResCase)
{
strIdVideoResCase = strIdVideoResCase.Replace("'", "''");
if (strIdVideoResCase.Length > 8)
{
throw new Exception("(errid:Data000001)在表:VideoResCase中,检查关键字,长度不正确!(clsVideoResCaseDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdVideoResCase)  ==  true)
{
throw new Exception("(errid:Data000002)在表:VideoResCase中,关键字不能为空 或 null!(clsVideoResCaseDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdVideoResCase);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsVideoResCaseDA:CheckPrimaryKey)", objException.Message));
}
return true;
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsVideoResCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoResCaseDA.GetSpecSQLObj();
strSQL = "Select * from VideoResCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_VideoResCase(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsVideoResCaseDA: GetDataTable_VideoResCase)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoResCaseDA.GetSpecSQLObj();
strSQL = "Select * from VideoResCase where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsVideoResCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoResCaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsVideoResCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoResCaseDA.GetSpecSQLObj();
strSQL = "Select * from VideoResCase where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsVideoResCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoResCaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsVideoResCaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoResCaseDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from VideoResCase where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from VideoResCase where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsVideoResCaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoResCaseDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from VideoResCase where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsVideoResCaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoResCaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} VideoResCase.* from VideoResCase Left Join {1} on {2} where {3} and VideoResCase.IdVideoResCase not in (Select top {5} VideoResCase.IdVideoResCase from VideoResCase Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from VideoResCase where {1} and IdVideoResCase not in (Select top {2} IdVideoResCase from VideoResCase where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from VideoResCase where {1} and IdVideoResCase not in (Select top {3} IdVideoResCase from VideoResCase where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsVideoResCaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoResCaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} VideoResCase.* from VideoResCase Left Join {1} on {2} where {3} and VideoResCase.IdVideoResCase not in (Select top {5} VideoResCase.IdVideoResCase from VideoResCase Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from VideoResCase where {1} and IdVideoResCase not in (Select top {2} IdVideoResCase from VideoResCase where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from VideoResCase where {1} and IdVideoResCase not in (Select top {3} IdVideoResCase from VideoResCase where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsVideoResCaseEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsVideoResCaseDA:GetObjLst)", objException.Message));
}
List<clsVideoResCaseEN> arrObjLst = new List<clsVideoResCaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoResCaseDA.GetSpecSQLObj();
strSQL = "Select * from VideoResCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsVideoResCaseEN objVideoResCaseEN = new clsVideoResCaseEN();
try
{
objVideoResCaseEN.IdVideoResCase = objRow[conVideoResCase.IdVideoResCase].ToString().Trim(); //视频资源案例流水号
objVideoResCaseEN.VideoResCaseID = objRow[conVideoResCase.VideoResCaseID].ToString().Trim(); //视频资源案例ID
objVideoResCaseEN.VideoResCaseName = objRow[conVideoResCase.VideoResCaseName].ToString().Trim(); //视频资源案例名称
objVideoResCaseEN.VideoResCaseTheme = objRow[conVideoResCase.VideoResCaseTheme] == DBNull.Value ? null : objRow[conVideoResCase.VideoResCaseTheme].ToString().Trim(); //视频资源案例主题词
objVideoResCaseEN.IdVideoResCaseType = objRow[conVideoResCase.IdVideoResCaseType].ToString().Trim(); //视频资源类型流水号
objVideoResCaseEN.VideoResCaseText = objRow[conVideoResCase.VideoResCaseText] == DBNull.Value ? null : objRow[conVideoResCase.VideoResCaseText].ToString().Trim(); //案例文本内容
objVideoResCaseEN.VideoResCaseDate = objRow[conVideoResCase.VideoResCaseDate] == DBNull.Value ? null : objRow[conVideoResCase.VideoResCaseDate].ToString().Trim(); //视频资源日期
objVideoResCaseEN.VideoResCaseTime = objRow[conVideoResCase.VideoResCaseTime] == DBNull.Value ? null : objRow[conVideoResCase.VideoResCaseTime].ToString().Trim(); //视频资源时间
objVideoResCaseEN.VideoResCaseDateIn = objRow[conVideoResCase.VideoResCaseDateIn] == DBNull.Value ? null : objRow[conVideoResCase.VideoResCaseDateIn].ToString().Trim(); //案例入库日期
objVideoResCaseEN.VideoResCaseTimeIn = objRow[conVideoResCase.VideoResCaseTimeIn] == DBNull.Value ? null : objRow[conVideoResCase.VideoResCaseTimeIn].ToString().Trim(); //案例入库时间
objVideoResCaseEN.OwnerId = objRow[conVideoResCase.OwnerId].ToString().Trim(); //拥有者Id
objVideoResCaseEN.IdStudyLevel = objRow[conVideoResCase.IdStudyLevel] == DBNull.Value ? null : objRow[conVideoResCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objVideoResCaseEN.IdTeachingPlan = objRow[conVideoResCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conVideoResCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objVideoResCaseEN.IdDiscipline = objRow[conVideoResCase.IdDiscipline] == DBNull.Value ? null : objRow[conVideoResCase.IdDiscipline].ToString().Trim(); //学科流水号
objVideoResCaseEN.BrowseCount = objRow[conVideoResCase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conVideoResCase.BrowseCount].ToString().Trim()); //浏览次数
objVideoResCaseEN.IdSenateGaugeVersion = objRow[conVideoResCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conVideoResCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objVideoResCaseEN.IdTeachSkill = objRow[conVideoResCase.IdTeachSkill] == DBNull.Value ? null : objRow[conVideoResCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objVideoResCaseEN.CaseLevelId = objRow[conVideoResCase.CaseLevelId] == DBNull.Value ? null : objRow[conVideoResCase.CaseLevelId].ToString().Trim(); //课例等级Id
objVideoResCaseEN.DocFile = objRow[conVideoResCase.DocFile] == DBNull.Value ? null : objRow[conVideoResCase.DocFile].ToString().Trim(); //生成的Word文件名
objVideoResCaseEN.IsNeedGeneWord = TransNullToBool(objRow[conVideoResCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objVideoResCaseEN.WordCreateDate = objRow[conVideoResCase.WordCreateDate] == DBNull.Value ? null : objRow[conVideoResCase.WordCreateDate].ToString().Trim(); //Word生成日期
objVideoResCaseEN.IsVisible = TransNullToBool(objRow[conVideoResCase.IsVisible].ToString().Trim()); //是否显示
objVideoResCaseEN.IsDualVideo = TransNullToBool(objRow[conVideoResCase.IsDualVideo].ToString().Trim()); //是否双视频
objVideoResCaseEN.IdXzCollege = objRow[conVideoResCase.IdXzCollege].ToString().Trim(); //学院流水号
objVideoResCaseEN.IdXzMajor = objRow[conVideoResCase.IdXzMajor].ToString().Trim(); //专业流水号
objVideoResCaseEN.CourseChapterId = objRow[conVideoResCase.CourseChapterId] == DBNull.Value ? null : objRow[conVideoResCase.CourseChapterId].ToString().Trim(); //课程章节ID
objVideoResCaseEN.ViewCount = objRow[conVideoResCase.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conVideoResCase.ViewCount].ToString().Trim()); //浏览量
objVideoResCaseEN.IsShow = TransNullToBool(objRow[conVideoResCase.IsShow].ToString().Trim()); //是否启用
objVideoResCaseEN.DownloadNumber = objRow[conVideoResCase.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conVideoResCase.DownloadNumber].ToString().Trim()); //下载数目
objVideoResCaseEN.FileIntegration = objRow[conVideoResCase.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conVideoResCase.FileIntegration].ToString().Trim()); //文件积分
objVideoResCaseEN.LikeCount = objRow[conVideoResCase.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conVideoResCase.LikeCount].ToString().Trim()); //资源喜欢数量
objVideoResCaseEN.CollectionCount = objRow[conVideoResCase.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conVideoResCase.CollectionCount].ToString().Trim()); //收藏数量
objVideoResCaseEN.RecommendedDegreeId = objRow[conVideoResCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objVideoResCaseEN.ftpFileType = objRow[conVideoResCase.ftpFileType] == DBNull.Value ? null : objRow[conVideoResCase.ftpFileType].ToString().Trim(); //ftp文件类型
objVideoResCaseEN.CourseId = objRow[conVideoResCase.CourseId].ToString().Trim(); //课程Id
objVideoResCaseEN.VideoUrl = objRow[conVideoResCase.VideoUrl] == DBNull.Value ? null : objRow[conVideoResCase.VideoUrl].ToString().Trim(); //视频Url
objVideoResCaseEN.VideoPath = objRow[conVideoResCase.VideoPath] == DBNull.Value ? null : objRow[conVideoResCase.VideoPath].ToString().Trim(); //视频目录
objVideoResCaseEN.ResErrMsg = objRow[conVideoResCase.ResErrMsg] == DBNull.Value ? null : objRow[conVideoResCase.ResErrMsg].ToString().Trim(); //资源错误信息
objVideoResCaseEN.UpdDate = objRow[conVideoResCase.UpdDate] == DBNull.Value ? null : objRow[conVideoResCase.UpdDate].ToString().Trim(); //修改日期
objVideoResCaseEN.UpdUserId = objRow[conVideoResCase.UpdUserId] == DBNull.Value ? null : objRow[conVideoResCase.UpdUserId].ToString().Trim(); //修改用户Id
objVideoResCaseEN.Memo = objRow[conVideoResCase.Memo] == DBNull.Value ? null : objRow[conVideoResCase.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsVideoResCaseDA: GetObjLst)", objException.Message));
}
objVideoResCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objVideoResCaseEN);
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
public List<clsVideoResCaseEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsVideoResCaseDA:GetObjLstByTabName)", objException.Message));
}
List<clsVideoResCaseEN> arrObjLst = new List<clsVideoResCaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoResCaseDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsVideoResCaseEN objVideoResCaseEN = new clsVideoResCaseEN();
try
{
objVideoResCaseEN.IdVideoResCase = objRow[conVideoResCase.IdVideoResCase].ToString().Trim(); //视频资源案例流水号
objVideoResCaseEN.VideoResCaseID = objRow[conVideoResCase.VideoResCaseID].ToString().Trim(); //视频资源案例ID
objVideoResCaseEN.VideoResCaseName = objRow[conVideoResCase.VideoResCaseName].ToString().Trim(); //视频资源案例名称
objVideoResCaseEN.VideoResCaseTheme = objRow[conVideoResCase.VideoResCaseTheme] == DBNull.Value ? null : objRow[conVideoResCase.VideoResCaseTheme].ToString().Trim(); //视频资源案例主题词
objVideoResCaseEN.IdVideoResCaseType = objRow[conVideoResCase.IdVideoResCaseType].ToString().Trim(); //视频资源类型流水号
objVideoResCaseEN.VideoResCaseText = objRow[conVideoResCase.VideoResCaseText] == DBNull.Value ? null : objRow[conVideoResCase.VideoResCaseText].ToString().Trim(); //案例文本内容
objVideoResCaseEN.VideoResCaseDate = objRow[conVideoResCase.VideoResCaseDate] == DBNull.Value ? null : objRow[conVideoResCase.VideoResCaseDate].ToString().Trim(); //视频资源日期
objVideoResCaseEN.VideoResCaseTime = objRow[conVideoResCase.VideoResCaseTime] == DBNull.Value ? null : objRow[conVideoResCase.VideoResCaseTime].ToString().Trim(); //视频资源时间
objVideoResCaseEN.VideoResCaseDateIn = objRow[conVideoResCase.VideoResCaseDateIn] == DBNull.Value ? null : objRow[conVideoResCase.VideoResCaseDateIn].ToString().Trim(); //案例入库日期
objVideoResCaseEN.VideoResCaseTimeIn = objRow[conVideoResCase.VideoResCaseTimeIn] == DBNull.Value ? null : objRow[conVideoResCase.VideoResCaseTimeIn].ToString().Trim(); //案例入库时间
objVideoResCaseEN.OwnerId = objRow[conVideoResCase.OwnerId].ToString().Trim(); //拥有者Id
objVideoResCaseEN.IdStudyLevel = objRow[conVideoResCase.IdStudyLevel] == DBNull.Value ? null : objRow[conVideoResCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objVideoResCaseEN.IdTeachingPlan = objRow[conVideoResCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conVideoResCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objVideoResCaseEN.IdDiscipline = objRow[conVideoResCase.IdDiscipline] == DBNull.Value ? null : objRow[conVideoResCase.IdDiscipline].ToString().Trim(); //学科流水号
objVideoResCaseEN.BrowseCount = objRow[conVideoResCase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conVideoResCase.BrowseCount].ToString().Trim()); //浏览次数
objVideoResCaseEN.IdSenateGaugeVersion = objRow[conVideoResCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conVideoResCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objVideoResCaseEN.IdTeachSkill = objRow[conVideoResCase.IdTeachSkill] == DBNull.Value ? null : objRow[conVideoResCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objVideoResCaseEN.CaseLevelId = objRow[conVideoResCase.CaseLevelId] == DBNull.Value ? null : objRow[conVideoResCase.CaseLevelId].ToString().Trim(); //课例等级Id
objVideoResCaseEN.DocFile = objRow[conVideoResCase.DocFile] == DBNull.Value ? null : objRow[conVideoResCase.DocFile].ToString().Trim(); //生成的Word文件名
objVideoResCaseEN.IsNeedGeneWord = TransNullToBool(objRow[conVideoResCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objVideoResCaseEN.WordCreateDate = objRow[conVideoResCase.WordCreateDate] == DBNull.Value ? null : objRow[conVideoResCase.WordCreateDate].ToString().Trim(); //Word生成日期
objVideoResCaseEN.IsVisible = TransNullToBool(objRow[conVideoResCase.IsVisible].ToString().Trim()); //是否显示
objVideoResCaseEN.IsDualVideo = TransNullToBool(objRow[conVideoResCase.IsDualVideo].ToString().Trim()); //是否双视频
objVideoResCaseEN.IdXzCollege = objRow[conVideoResCase.IdXzCollege].ToString().Trim(); //学院流水号
objVideoResCaseEN.IdXzMajor = objRow[conVideoResCase.IdXzMajor].ToString().Trim(); //专业流水号
objVideoResCaseEN.CourseChapterId = objRow[conVideoResCase.CourseChapterId] == DBNull.Value ? null : objRow[conVideoResCase.CourseChapterId].ToString().Trim(); //课程章节ID
objVideoResCaseEN.ViewCount = objRow[conVideoResCase.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conVideoResCase.ViewCount].ToString().Trim()); //浏览量
objVideoResCaseEN.IsShow = TransNullToBool(objRow[conVideoResCase.IsShow].ToString().Trim()); //是否启用
objVideoResCaseEN.DownloadNumber = objRow[conVideoResCase.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conVideoResCase.DownloadNumber].ToString().Trim()); //下载数目
objVideoResCaseEN.FileIntegration = objRow[conVideoResCase.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conVideoResCase.FileIntegration].ToString().Trim()); //文件积分
objVideoResCaseEN.LikeCount = objRow[conVideoResCase.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conVideoResCase.LikeCount].ToString().Trim()); //资源喜欢数量
objVideoResCaseEN.CollectionCount = objRow[conVideoResCase.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conVideoResCase.CollectionCount].ToString().Trim()); //收藏数量
objVideoResCaseEN.RecommendedDegreeId = objRow[conVideoResCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objVideoResCaseEN.ftpFileType = objRow[conVideoResCase.ftpFileType] == DBNull.Value ? null : objRow[conVideoResCase.ftpFileType].ToString().Trim(); //ftp文件类型
objVideoResCaseEN.CourseId = objRow[conVideoResCase.CourseId].ToString().Trim(); //课程Id
objVideoResCaseEN.VideoUrl = objRow[conVideoResCase.VideoUrl] == DBNull.Value ? null : objRow[conVideoResCase.VideoUrl].ToString().Trim(); //视频Url
objVideoResCaseEN.VideoPath = objRow[conVideoResCase.VideoPath] == DBNull.Value ? null : objRow[conVideoResCase.VideoPath].ToString().Trim(); //视频目录
objVideoResCaseEN.ResErrMsg = objRow[conVideoResCase.ResErrMsg] == DBNull.Value ? null : objRow[conVideoResCase.ResErrMsg].ToString().Trim(); //资源错误信息
objVideoResCaseEN.UpdDate = objRow[conVideoResCase.UpdDate] == DBNull.Value ? null : objRow[conVideoResCase.UpdDate].ToString().Trim(); //修改日期
objVideoResCaseEN.UpdUserId = objRow[conVideoResCase.UpdUserId] == DBNull.Value ? null : objRow[conVideoResCase.UpdUserId].ToString().Trim(); //修改用户Id
objVideoResCaseEN.Memo = objRow[conVideoResCase.Memo] == DBNull.Value ? null : objRow[conVideoResCase.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsVideoResCaseDA: GetObjLst)", objException.Message));
}
objVideoResCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objVideoResCaseEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objVideoResCaseEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetVideoResCase(ref clsVideoResCaseEN objVideoResCaseEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoResCaseDA.GetSpecSQLObj();
strSQL = "Select * from VideoResCase where IdVideoResCase = " + "'"+ objVideoResCaseEN.IdVideoResCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objVideoResCaseEN.IdVideoResCase = objDT.Rows[0][conVideoResCase.IdVideoResCase].ToString().Trim(); //视频资源案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objVideoResCaseEN.VideoResCaseID = objDT.Rows[0][conVideoResCase.VideoResCaseID].ToString().Trim(); //视频资源案例ID(字段类型:char,字段长度:8,是否可空:False)
 objVideoResCaseEN.VideoResCaseName = objDT.Rows[0][conVideoResCase.VideoResCaseName].ToString().Trim(); //视频资源案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objVideoResCaseEN.VideoResCaseTheme = objDT.Rows[0][conVideoResCase.VideoResCaseTheme].ToString().Trim(); //视频资源案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objVideoResCaseEN.IdVideoResCaseType = objDT.Rows[0][conVideoResCase.IdVideoResCaseType].ToString().Trim(); //视频资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objVideoResCaseEN.VideoResCaseText = objDT.Rows[0][conVideoResCase.VideoResCaseText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objVideoResCaseEN.VideoResCaseDate = objDT.Rows[0][conVideoResCase.VideoResCaseDate].ToString().Trim(); //视频资源日期(字段类型:char,字段长度:8,是否可空:True)
 objVideoResCaseEN.VideoResCaseTime = objDT.Rows[0][conVideoResCase.VideoResCaseTime].ToString().Trim(); //视频资源时间(字段类型:char,字段长度:6,是否可空:True)
 objVideoResCaseEN.VideoResCaseDateIn = objDT.Rows[0][conVideoResCase.VideoResCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objVideoResCaseEN.VideoResCaseTimeIn = objDT.Rows[0][conVideoResCase.VideoResCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objVideoResCaseEN.OwnerId = objDT.Rows[0][conVideoResCase.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objVideoResCaseEN.IdStudyLevel = objDT.Rows[0][conVideoResCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objVideoResCaseEN.IdTeachingPlan = objDT.Rows[0][conVideoResCase.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objVideoResCaseEN.IdDiscipline = objDT.Rows[0][conVideoResCase.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objVideoResCaseEN.BrowseCount = TransNullToInt(objDT.Rows[0][conVideoResCase.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objVideoResCaseEN.IdSenateGaugeVersion = objDT.Rows[0][conVideoResCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objVideoResCaseEN.IdTeachSkill = objDT.Rows[0][conVideoResCase.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objVideoResCaseEN.CaseLevelId = objDT.Rows[0][conVideoResCase.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objVideoResCaseEN.DocFile = objDT.Rows[0][conVideoResCase.DocFile].ToString().Trim(); //生成的Word文件名(字段类型:varchar,字段长度:200,是否可空:True)
 objVideoResCaseEN.IsNeedGeneWord = TransNullToBool(objDT.Rows[0][conVideoResCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word(字段类型:bit,字段长度:1,是否可空:True)
 objVideoResCaseEN.WordCreateDate = objDT.Rows[0][conVideoResCase.WordCreateDate].ToString().Trim(); //Word生成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objVideoResCaseEN.IsVisible = TransNullToBool(objDT.Rows[0][conVideoResCase.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objVideoResCaseEN.IsDualVideo = TransNullToBool(objDT.Rows[0][conVideoResCase.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objVideoResCaseEN.IdXzCollege = objDT.Rows[0][conVideoResCase.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objVideoResCaseEN.IdXzMajor = objDT.Rows[0][conVideoResCase.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objVideoResCaseEN.CourseChapterId = objDT.Rows[0][conVideoResCase.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objVideoResCaseEN.ViewCount = TransNullToInt(objDT.Rows[0][conVideoResCase.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objVideoResCaseEN.IsShow = TransNullToBool(objDT.Rows[0][conVideoResCase.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objVideoResCaseEN.DownloadNumber = TransNullToInt(objDT.Rows[0][conVideoResCase.DownloadNumber].ToString().Trim()); //下载数目(字段类型:int,字段长度:4,是否可空:True)
 objVideoResCaseEN.FileIntegration = TransNullToInt(objDT.Rows[0][conVideoResCase.FileIntegration].ToString().Trim()); //文件积分(字段类型:int,字段长度:4,是否可空:True)
 objVideoResCaseEN.LikeCount = TransNullToInt(objDT.Rows[0][conVideoResCase.LikeCount].ToString().Trim()); //资源喜欢数量(字段类型:bigint,字段长度:8,是否可空:True)
 objVideoResCaseEN.CollectionCount = TransNullToInt(objDT.Rows[0][conVideoResCase.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objVideoResCaseEN.RecommendedDegreeId = objDT.Rows[0][conVideoResCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objVideoResCaseEN.ftpFileType = objDT.Rows[0][conVideoResCase.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objVideoResCaseEN.CourseId = objDT.Rows[0][conVideoResCase.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objVideoResCaseEN.VideoUrl = objDT.Rows[0][conVideoResCase.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objVideoResCaseEN.VideoPath = objDT.Rows[0][conVideoResCase.VideoPath].ToString().Trim(); //视频目录(字段类型:varchar,字段长度:1000,是否可空:True)
 objVideoResCaseEN.ResErrMsg = objDT.Rows[0][conVideoResCase.ResErrMsg].ToString().Trim(); //资源错误信息(字段类型:varchar,字段长度:30,是否可空:True)
 objVideoResCaseEN.UpdDate = objDT.Rows[0][conVideoResCase.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objVideoResCaseEN.UpdUserId = objDT.Rows[0][conVideoResCase.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objVideoResCaseEN.Memo = objDT.Rows[0][conVideoResCase.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsVideoResCaseDA: GetVideoResCase)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdVideoResCase">表关键字</param>
 /// <returns>表对象</returns>
public clsVideoResCaseEN GetObjByIdVideoResCase(string strIdVideoResCase)
{
CheckPrimaryKey(strIdVideoResCase);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoResCaseDA.GetSpecSQLObj();
strSQL = "Select * from VideoResCase where IdVideoResCase = " + "'"+ strIdVideoResCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsVideoResCaseEN objVideoResCaseEN = new clsVideoResCaseEN();
try
{
 objVideoResCaseEN.IdVideoResCase = objRow[conVideoResCase.IdVideoResCase].ToString().Trim(); //视频资源案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objVideoResCaseEN.VideoResCaseID = objRow[conVideoResCase.VideoResCaseID].ToString().Trim(); //视频资源案例ID(字段类型:char,字段长度:8,是否可空:False)
 objVideoResCaseEN.VideoResCaseName = objRow[conVideoResCase.VideoResCaseName].ToString().Trim(); //视频资源案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objVideoResCaseEN.VideoResCaseTheme = objRow[conVideoResCase.VideoResCaseTheme] == DBNull.Value ? null : objRow[conVideoResCase.VideoResCaseTheme].ToString().Trim(); //视频资源案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objVideoResCaseEN.IdVideoResCaseType = objRow[conVideoResCase.IdVideoResCaseType].ToString().Trim(); //视频资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objVideoResCaseEN.VideoResCaseText = objRow[conVideoResCase.VideoResCaseText] == DBNull.Value ? null : objRow[conVideoResCase.VideoResCaseText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objVideoResCaseEN.VideoResCaseDate = objRow[conVideoResCase.VideoResCaseDate] == DBNull.Value ? null : objRow[conVideoResCase.VideoResCaseDate].ToString().Trim(); //视频资源日期(字段类型:char,字段长度:8,是否可空:True)
 objVideoResCaseEN.VideoResCaseTime = objRow[conVideoResCase.VideoResCaseTime] == DBNull.Value ? null : objRow[conVideoResCase.VideoResCaseTime].ToString().Trim(); //视频资源时间(字段类型:char,字段长度:6,是否可空:True)
 objVideoResCaseEN.VideoResCaseDateIn = objRow[conVideoResCase.VideoResCaseDateIn] == DBNull.Value ? null : objRow[conVideoResCase.VideoResCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objVideoResCaseEN.VideoResCaseTimeIn = objRow[conVideoResCase.VideoResCaseTimeIn] == DBNull.Value ? null : objRow[conVideoResCase.VideoResCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objVideoResCaseEN.OwnerId = objRow[conVideoResCase.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objVideoResCaseEN.IdStudyLevel = objRow[conVideoResCase.IdStudyLevel] == DBNull.Value ? null : objRow[conVideoResCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objVideoResCaseEN.IdTeachingPlan = objRow[conVideoResCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conVideoResCase.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objVideoResCaseEN.IdDiscipline = objRow[conVideoResCase.IdDiscipline] == DBNull.Value ? null : objRow[conVideoResCase.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objVideoResCaseEN.BrowseCount = objRow[conVideoResCase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoResCase.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objVideoResCaseEN.IdSenateGaugeVersion = objRow[conVideoResCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conVideoResCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objVideoResCaseEN.IdTeachSkill = objRow[conVideoResCase.IdTeachSkill] == DBNull.Value ? null : objRow[conVideoResCase.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objVideoResCaseEN.CaseLevelId = objRow[conVideoResCase.CaseLevelId] == DBNull.Value ? null : objRow[conVideoResCase.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objVideoResCaseEN.DocFile = objRow[conVideoResCase.DocFile] == DBNull.Value ? null : objRow[conVideoResCase.DocFile].ToString().Trim(); //生成的Word文件名(字段类型:varchar,字段长度:200,是否可空:True)
 objVideoResCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[conVideoResCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word(字段类型:bit,字段长度:1,是否可空:True)
 objVideoResCaseEN.WordCreateDate = objRow[conVideoResCase.WordCreateDate] == DBNull.Value ? null : objRow[conVideoResCase.WordCreateDate].ToString().Trim(); //Word生成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objVideoResCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conVideoResCase.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objVideoResCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[conVideoResCase.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objVideoResCaseEN.IdXzCollege = objRow[conVideoResCase.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objVideoResCaseEN.IdXzMajor = objRow[conVideoResCase.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objVideoResCaseEN.CourseChapterId = objRow[conVideoResCase.CourseChapterId] == DBNull.Value ? null : objRow[conVideoResCase.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objVideoResCaseEN.ViewCount = objRow[conVideoResCase.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoResCase.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objVideoResCaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conVideoResCase.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objVideoResCaseEN.DownloadNumber = objRow[conVideoResCase.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoResCase.DownloadNumber].ToString().Trim()); //下载数目(字段类型:int,字段长度:4,是否可空:True)
 objVideoResCaseEN.FileIntegration = objRow[conVideoResCase.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoResCase.FileIntegration].ToString().Trim()); //文件积分(字段类型:int,字段长度:4,是否可空:True)
 objVideoResCaseEN.LikeCount = objRow[conVideoResCase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoResCase.LikeCount].ToString().Trim()); //资源喜欢数量(字段类型:bigint,字段长度:8,是否可空:True)
 objVideoResCaseEN.CollectionCount = objRow[conVideoResCase.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoResCase.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objVideoResCaseEN.RecommendedDegreeId = objRow[conVideoResCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objVideoResCaseEN.ftpFileType = objRow[conVideoResCase.ftpFileType] == DBNull.Value ? null : objRow[conVideoResCase.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objVideoResCaseEN.CourseId = objRow[conVideoResCase.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objVideoResCaseEN.VideoUrl = objRow[conVideoResCase.VideoUrl] == DBNull.Value ? null : objRow[conVideoResCase.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objVideoResCaseEN.VideoPath = objRow[conVideoResCase.VideoPath] == DBNull.Value ? null : objRow[conVideoResCase.VideoPath].ToString().Trim(); //视频目录(字段类型:varchar,字段长度:1000,是否可空:True)
 objVideoResCaseEN.ResErrMsg = objRow[conVideoResCase.ResErrMsg] == DBNull.Value ? null : objRow[conVideoResCase.ResErrMsg].ToString().Trim(); //资源错误信息(字段类型:varchar,字段长度:30,是否可空:True)
 objVideoResCaseEN.UpdDate = objRow[conVideoResCase.UpdDate] == DBNull.Value ? null : objRow[conVideoResCase.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objVideoResCaseEN.UpdUserId = objRow[conVideoResCase.UpdUserId] == DBNull.Value ? null : objRow[conVideoResCase.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objVideoResCaseEN.Memo = objRow[conVideoResCase.Memo] == DBNull.Value ? null : objRow[conVideoResCase.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsVideoResCaseDA: GetObjByIdVideoResCase)", objException.Message));
}
return objVideoResCaseEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsVideoResCaseEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsVideoResCaseDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoResCaseDA.GetSpecSQLObj();
strSQL = "Select * from VideoResCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsVideoResCaseEN objVideoResCaseEN = new clsVideoResCaseEN()
{
IdVideoResCase = objRow[conVideoResCase.IdVideoResCase].ToString().Trim(), //视频资源案例流水号
VideoResCaseID = objRow[conVideoResCase.VideoResCaseID].ToString().Trim(), //视频资源案例ID
VideoResCaseName = objRow[conVideoResCase.VideoResCaseName].ToString().Trim(), //视频资源案例名称
VideoResCaseTheme = objRow[conVideoResCase.VideoResCaseTheme] == DBNull.Value ? null : objRow[conVideoResCase.VideoResCaseTheme].ToString().Trim(), //视频资源案例主题词
IdVideoResCaseType = objRow[conVideoResCase.IdVideoResCaseType].ToString().Trim(), //视频资源类型流水号
VideoResCaseText = objRow[conVideoResCase.VideoResCaseText] == DBNull.Value ? null : objRow[conVideoResCase.VideoResCaseText].ToString().Trim(), //案例文本内容
VideoResCaseDate = objRow[conVideoResCase.VideoResCaseDate] == DBNull.Value ? null : objRow[conVideoResCase.VideoResCaseDate].ToString().Trim(), //视频资源日期
VideoResCaseTime = objRow[conVideoResCase.VideoResCaseTime] == DBNull.Value ? null : objRow[conVideoResCase.VideoResCaseTime].ToString().Trim(), //视频资源时间
VideoResCaseDateIn = objRow[conVideoResCase.VideoResCaseDateIn] == DBNull.Value ? null : objRow[conVideoResCase.VideoResCaseDateIn].ToString().Trim(), //案例入库日期
VideoResCaseTimeIn = objRow[conVideoResCase.VideoResCaseTimeIn] == DBNull.Value ? null : objRow[conVideoResCase.VideoResCaseTimeIn].ToString().Trim(), //案例入库时间
OwnerId = objRow[conVideoResCase.OwnerId].ToString().Trim(), //拥有者Id
IdStudyLevel = objRow[conVideoResCase.IdStudyLevel] == DBNull.Value ? null : objRow[conVideoResCase.IdStudyLevel].ToString().Trim(), //id_StudyLevel
IdTeachingPlan = objRow[conVideoResCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conVideoResCase.IdTeachingPlan].ToString().Trim(), //教案流水号
IdDiscipline = objRow[conVideoResCase.IdDiscipline] == DBNull.Value ? null : objRow[conVideoResCase.IdDiscipline].ToString().Trim(), //学科流水号
BrowseCount = objRow[conVideoResCase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conVideoResCase.BrowseCount].ToString().Trim()), //浏览次数
IdSenateGaugeVersion = objRow[conVideoResCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conVideoResCase.IdSenateGaugeVersion].ToString().Trim(), //评价量表版本流水号
IdTeachSkill = objRow[conVideoResCase.IdTeachSkill] == DBNull.Value ? null : objRow[conVideoResCase.IdTeachSkill].ToString().Trim(), //教学技能流水号
CaseLevelId = objRow[conVideoResCase.CaseLevelId] == DBNull.Value ? null : objRow[conVideoResCase.CaseLevelId].ToString().Trim(), //课例等级Id
DocFile = objRow[conVideoResCase.DocFile] == DBNull.Value ? null : objRow[conVideoResCase.DocFile].ToString().Trim(), //生成的Word文件名
IsNeedGeneWord = TransNullToBool(objRow[conVideoResCase.IsNeedGeneWord].ToString().Trim()), //是否需要生成Word
WordCreateDate = objRow[conVideoResCase.WordCreateDate] == DBNull.Value ? null : objRow[conVideoResCase.WordCreateDate].ToString().Trim(), //Word生成日期
IsVisible = TransNullToBool(objRow[conVideoResCase.IsVisible].ToString().Trim()), //是否显示
IsDualVideo = TransNullToBool(objRow[conVideoResCase.IsDualVideo].ToString().Trim()), //是否双视频
IdXzCollege = objRow[conVideoResCase.IdXzCollege].ToString().Trim(), //学院流水号
IdXzMajor = objRow[conVideoResCase.IdXzMajor].ToString().Trim(), //专业流水号
CourseChapterId = objRow[conVideoResCase.CourseChapterId] == DBNull.Value ? null : objRow[conVideoResCase.CourseChapterId].ToString().Trim(), //课程章节ID
ViewCount = objRow[conVideoResCase.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conVideoResCase.ViewCount].ToString().Trim()), //浏览量
IsShow = TransNullToBool(objRow[conVideoResCase.IsShow].ToString().Trim()), //是否启用
DownloadNumber = objRow[conVideoResCase.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conVideoResCase.DownloadNumber].ToString().Trim()), //下载数目
FileIntegration = objRow[conVideoResCase.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conVideoResCase.FileIntegration].ToString().Trim()), //文件积分
LikeCount = objRow[conVideoResCase.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conVideoResCase.LikeCount].ToString().Trim()), //资源喜欢数量
CollectionCount = objRow[conVideoResCase.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conVideoResCase.CollectionCount].ToString().Trim()), //收藏数量
RecommendedDegreeId = objRow[conVideoResCase.RecommendedDegreeId].ToString().Trim(), //推荐度Id
ftpFileType = objRow[conVideoResCase.ftpFileType] == DBNull.Value ? null : objRow[conVideoResCase.ftpFileType].ToString().Trim(), //ftp文件类型
CourseId = objRow[conVideoResCase.CourseId].ToString().Trim(), //课程Id
VideoUrl = objRow[conVideoResCase.VideoUrl] == DBNull.Value ? null : objRow[conVideoResCase.VideoUrl].ToString().Trim(), //视频Url
VideoPath = objRow[conVideoResCase.VideoPath] == DBNull.Value ? null : objRow[conVideoResCase.VideoPath].ToString().Trim(), //视频目录
ResErrMsg = objRow[conVideoResCase.ResErrMsg] == DBNull.Value ? null : objRow[conVideoResCase.ResErrMsg].ToString().Trim(), //资源错误信息
UpdDate = objRow[conVideoResCase.UpdDate] == DBNull.Value ? null : objRow[conVideoResCase.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[conVideoResCase.UpdUserId] == DBNull.Value ? null : objRow[conVideoResCase.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[conVideoResCase.Memo] == DBNull.Value ? null : objRow[conVideoResCase.Memo].ToString().Trim() //备注
};
objVideoResCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objVideoResCaseEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsVideoResCaseDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsVideoResCaseEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsVideoResCaseEN objVideoResCaseEN = new clsVideoResCaseEN();
try
{
objVideoResCaseEN.IdVideoResCase = objRow[conVideoResCase.IdVideoResCase].ToString().Trim(); //视频资源案例流水号
objVideoResCaseEN.VideoResCaseID = objRow[conVideoResCase.VideoResCaseID].ToString().Trim(); //视频资源案例ID
objVideoResCaseEN.VideoResCaseName = objRow[conVideoResCase.VideoResCaseName].ToString().Trim(); //视频资源案例名称
objVideoResCaseEN.VideoResCaseTheme = objRow[conVideoResCase.VideoResCaseTheme] == DBNull.Value ? null : objRow[conVideoResCase.VideoResCaseTheme].ToString().Trim(); //视频资源案例主题词
objVideoResCaseEN.IdVideoResCaseType = objRow[conVideoResCase.IdVideoResCaseType].ToString().Trim(); //视频资源类型流水号
objVideoResCaseEN.VideoResCaseText = objRow[conVideoResCase.VideoResCaseText] == DBNull.Value ? null : objRow[conVideoResCase.VideoResCaseText].ToString().Trim(); //案例文本内容
objVideoResCaseEN.VideoResCaseDate = objRow[conVideoResCase.VideoResCaseDate] == DBNull.Value ? null : objRow[conVideoResCase.VideoResCaseDate].ToString().Trim(); //视频资源日期
objVideoResCaseEN.VideoResCaseTime = objRow[conVideoResCase.VideoResCaseTime] == DBNull.Value ? null : objRow[conVideoResCase.VideoResCaseTime].ToString().Trim(); //视频资源时间
objVideoResCaseEN.VideoResCaseDateIn = objRow[conVideoResCase.VideoResCaseDateIn] == DBNull.Value ? null : objRow[conVideoResCase.VideoResCaseDateIn].ToString().Trim(); //案例入库日期
objVideoResCaseEN.VideoResCaseTimeIn = objRow[conVideoResCase.VideoResCaseTimeIn] == DBNull.Value ? null : objRow[conVideoResCase.VideoResCaseTimeIn].ToString().Trim(); //案例入库时间
objVideoResCaseEN.OwnerId = objRow[conVideoResCase.OwnerId].ToString().Trim(); //拥有者Id
objVideoResCaseEN.IdStudyLevel = objRow[conVideoResCase.IdStudyLevel] == DBNull.Value ? null : objRow[conVideoResCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objVideoResCaseEN.IdTeachingPlan = objRow[conVideoResCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conVideoResCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objVideoResCaseEN.IdDiscipline = objRow[conVideoResCase.IdDiscipline] == DBNull.Value ? null : objRow[conVideoResCase.IdDiscipline].ToString().Trim(); //学科流水号
objVideoResCaseEN.BrowseCount = objRow[conVideoResCase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conVideoResCase.BrowseCount].ToString().Trim()); //浏览次数
objVideoResCaseEN.IdSenateGaugeVersion = objRow[conVideoResCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conVideoResCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objVideoResCaseEN.IdTeachSkill = objRow[conVideoResCase.IdTeachSkill] == DBNull.Value ? null : objRow[conVideoResCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objVideoResCaseEN.CaseLevelId = objRow[conVideoResCase.CaseLevelId] == DBNull.Value ? null : objRow[conVideoResCase.CaseLevelId].ToString().Trim(); //课例等级Id
objVideoResCaseEN.DocFile = objRow[conVideoResCase.DocFile] == DBNull.Value ? null : objRow[conVideoResCase.DocFile].ToString().Trim(); //生成的Word文件名
objVideoResCaseEN.IsNeedGeneWord = TransNullToBool(objRow[conVideoResCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objVideoResCaseEN.WordCreateDate = objRow[conVideoResCase.WordCreateDate] == DBNull.Value ? null : objRow[conVideoResCase.WordCreateDate].ToString().Trim(); //Word生成日期
objVideoResCaseEN.IsVisible = TransNullToBool(objRow[conVideoResCase.IsVisible].ToString().Trim()); //是否显示
objVideoResCaseEN.IsDualVideo = TransNullToBool(objRow[conVideoResCase.IsDualVideo].ToString().Trim()); //是否双视频
objVideoResCaseEN.IdXzCollege = objRow[conVideoResCase.IdXzCollege].ToString().Trim(); //学院流水号
objVideoResCaseEN.IdXzMajor = objRow[conVideoResCase.IdXzMajor].ToString().Trim(); //专业流水号
objVideoResCaseEN.CourseChapterId = objRow[conVideoResCase.CourseChapterId] == DBNull.Value ? null : objRow[conVideoResCase.CourseChapterId].ToString().Trim(); //课程章节ID
objVideoResCaseEN.ViewCount = objRow[conVideoResCase.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conVideoResCase.ViewCount].ToString().Trim()); //浏览量
objVideoResCaseEN.IsShow = TransNullToBool(objRow[conVideoResCase.IsShow].ToString().Trim()); //是否启用
objVideoResCaseEN.DownloadNumber = objRow[conVideoResCase.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conVideoResCase.DownloadNumber].ToString().Trim()); //下载数目
objVideoResCaseEN.FileIntegration = objRow[conVideoResCase.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conVideoResCase.FileIntegration].ToString().Trim()); //文件积分
objVideoResCaseEN.LikeCount = objRow[conVideoResCase.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conVideoResCase.LikeCount].ToString().Trim()); //资源喜欢数量
objVideoResCaseEN.CollectionCount = objRow[conVideoResCase.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conVideoResCase.CollectionCount].ToString().Trim()); //收藏数量
objVideoResCaseEN.RecommendedDegreeId = objRow[conVideoResCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objVideoResCaseEN.ftpFileType = objRow[conVideoResCase.ftpFileType] == DBNull.Value ? null : objRow[conVideoResCase.ftpFileType].ToString().Trim(); //ftp文件类型
objVideoResCaseEN.CourseId = objRow[conVideoResCase.CourseId].ToString().Trim(); //课程Id
objVideoResCaseEN.VideoUrl = objRow[conVideoResCase.VideoUrl] == DBNull.Value ? null : objRow[conVideoResCase.VideoUrl].ToString().Trim(); //视频Url
objVideoResCaseEN.VideoPath = objRow[conVideoResCase.VideoPath] == DBNull.Value ? null : objRow[conVideoResCase.VideoPath].ToString().Trim(); //视频目录
objVideoResCaseEN.ResErrMsg = objRow[conVideoResCase.ResErrMsg] == DBNull.Value ? null : objRow[conVideoResCase.ResErrMsg].ToString().Trim(); //资源错误信息
objVideoResCaseEN.UpdDate = objRow[conVideoResCase.UpdDate] == DBNull.Value ? null : objRow[conVideoResCase.UpdDate].ToString().Trim(); //修改日期
objVideoResCaseEN.UpdUserId = objRow[conVideoResCase.UpdUserId] == DBNull.Value ? null : objRow[conVideoResCase.UpdUserId].ToString().Trim(); //修改用户Id
objVideoResCaseEN.Memo = objRow[conVideoResCase.Memo] == DBNull.Value ? null : objRow[conVideoResCase.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsVideoResCaseDA: GetObjByDataRowVideoResCase)", objException.Message));
}
objVideoResCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objVideoResCaseEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsVideoResCaseEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsVideoResCaseEN objVideoResCaseEN = new clsVideoResCaseEN();
try
{
objVideoResCaseEN.IdVideoResCase = objRow[conVideoResCase.IdVideoResCase].ToString().Trim(); //视频资源案例流水号
objVideoResCaseEN.VideoResCaseID = objRow[conVideoResCase.VideoResCaseID].ToString().Trim(); //视频资源案例ID
objVideoResCaseEN.VideoResCaseName = objRow[conVideoResCase.VideoResCaseName].ToString().Trim(); //视频资源案例名称
objVideoResCaseEN.VideoResCaseTheme = objRow[conVideoResCase.VideoResCaseTheme] == DBNull.Value ? null : objRow[conVideoResCase.VideoResCaseTheme].ToString().Trim(); //视频资源案例主题词
objVideoResCaseEN.IdVideoResCaseType = objRow[conVideoResCase.IdVideoResCaseType].ToString().Trim(); //视频资源类型流水号
objVideoResCaseEN.VideoResCaseText = objRow[conVideoResCase.VideoResCaseText] == DBNull.Value ? null : objRow[conVideoResCase.VideoResCaseText].ToString().Trim(); //案例文本内容
objVideoResCaseEN.VideoResCaseDate = objRow[conVideoResCase.VideoResCaseDate] == DBNull.Value ? null : objRow[conVideoResCase.VideoResCaseDate].ToString().Trim(); //视频资源日期
objVideoResCaseEN.VideoResCaseTime = objRow[conVideoResCase.VideoResCaseTime] == DBNull.Value ? null : objRow[conVideoResCase.VideoResCaseTime].ToString().Trim(); //视频资源时间
objVideoResCaseEN.VideoResCaseDateIn = objRow[conVideoResCase.VideoResCaseDateIn] == DBNull.Value ? null : objRow[conVideoResCase.VideoResCaseDateIn].ToString().Trim(); //案例入库日期
objVideoResCaseEN.VideoResCaseTimeIn = objRow[conVideoResCase.VideoResCaseTimeIn] == DBNull.Value ? null : objRow[conVideoResCase.VideoResCaseTimeIn].ToString().Trim(); //案例入库时间
objVideoResCaseEN.OwnerId = objRow[conVideoResCase.OwnerId].ToString().Trim(); //拥有者Id
objVideoResCaseEN.IdStudyLevel = objRow[conVideoResCase.IdStudyLevel] == DBNull.Value ? null : objRow[conVideoResCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objVideoResCaseEN.IdTeachingPlan = objRow[conVideoResCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conVideoResCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objVideoResCaseEN.IdDiscipline = objRow[conVideoResCase.IdDiscipline] == DBNull.Value ? null : objRow[conVideoResCase.IdDiscipline].ToString().Trim(); //学科流水号
objVideoResCaseEN.BrowseCount = objRow[conVideoResCase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conVideoResCase.BrowseCount].ToString().Trim()); //浏览次数
objVideoResCaseEN.IdSenateGaugeVersion = objRow[conVideoResCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conVideoResCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objVideoResCaseEN.IdTeachSkill = objRow[conVideoResCase.IdTeachSkill] == DBNull.Value ? null : objRow[conVideoResCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objVideoResCaseEN.CaseLevelId = objRow[conVideoResCase.CaseLevelId] == DBNull.Value ? null : objRow[conVideoResCase.CaseLevelId].ToString().Trim(); //课例等级Id
objVideoResCaseEN.DocFile = objRow[conVideoResCase.DocFile] == DBNull.Value ? null : objRow[conVideoResCase.DocFile].ToString().Trim(); //生成的Word文件名
objVideoResCaseEN.IsNeedGeneWord = TransNullToBool(objRow[conVideoResCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objVideoResCaseEN.WordCreateDate = objRow[conVideoResCase.WordCreateDate] == DBNull.Value ? null : objRow[conVideoResCase.WordCreateDate].ToString().Trim(); //Word生成日期
objVideoResCaseEN.IsVisible = TransNullToBool(objRow[conVideoResCase.IsVisible].ToString().Trim()); //是否显示
objVideoResCaseEN.IsDualVideo = TransNullToBool(objRow[conVideoResCase.IsDualVideo].ToString().Trim()); //是否双视频
objVideoResCaseEN.IdXzCollege = objRow[conVideoResCase.IdXzCollege].ToString().Trim(); //学院流水号
objVideoResCaseEN.IdXzMajor = objRow[conVideoResCase.IdXzMajor].ToString().Trim(); //专业流水号
objVideoResCaseEN.CourseChapterId = objRow[conVideoResCase.CourseChapterId] == DBNull.Value ? null : objRow[conVideoResCase.CourseChapterId].ToString().Trim(); //课程章节ID
objVideoResCaseEN.ViewCount = objRow[conVideoResCase.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conVideoResCase.ViewCount].ToString().Trim()); //浏览量
objVideoResCaseEN.IsShow = TransNullToBool(objRow[conVideoResCase.IsShow].ToString().Trim()); //是否启用
objVideoResCaseEN.DownloadNumber = objRow[conVideoResCase.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conVideoResCase.DownloadNumber].ToString().Trim()); //下载数目
objVideoResCaseEN.FileIntegration = objRow[conVideoResCase.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conVideoResCase.FileIntegration].ToString().Trim()); //文件积分
objVideoResCaseEN.LikeCount = objRow[conVideoResCase.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conVideoResCase.LikeCount].ToString().Trim()); //资源喜欢数量
objVideoResCaseEN.CollectionCount = objRow[conVideoResCase.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conVideoResCase.CollectionCount].ToString().Trim()); //收藏数量
objVideoResCaseEN.RecommendedDegreeId = objRow[conVideoResCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objVideoResCaseEN.ftpFileType = objRow[conVideoResCase.ftpFileType] == DBNull.Value ? null : objRow[conVideoResCase.ftpFileType].ToString().Trim(); //ftp文件类型
objVideoResCaseEN.CourseId = objRow[conVideoResCase.CourseId].ToString().Trim(); //课程Id
objVideoResCaseEN.VideoUrl = objRow[conVideoResCase.VideoUrl] == DBNull.Value ? null : objRow[conVideoResCase.VideoUrl].ToString().Trim(); //视频Url
objVideoResCaseEN.VideoPath = objRow[conVideoResCase.VideoPath] == DBNull.Value ? null : objRow[conVideoResCase.VideoPath].ToString().Trim(); //视频目录
objVideoResCaseEN.ResErrMsg = objRow[conVideoResCase.ResErrMsg] == DBNull.Value ? null : objRow[conVideoResCase.ResErrMsg].ToString().Trim(); //资源错误信息
objVideoResCaseEN.UpdDate = objRow[conVideoResCase.UpdDate] == DBNull.Value ? null : objRow[conVideoResCase.UpdDate].ToString().Trim(); //修改日期
objVideoResCaseEN.UpdUserId = objRow[conVideoResCase.UpdUserId] == DBNull.Value ? null : objRow[conVideoResCase.UpdUserId].ToString().Trim(); //修改用户Id
objVideoResCaseEN.Memo = objRow[conVideoResCase.Memo] == DBNull.Value ? null : objRow[conVideoResCase.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsVideoResCaseDA: GetObjByDataRow)", objException.Message));
}
objVideoResCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objVideoResCaseEN;
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
objSQL = clsVideoResCaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsVideoResCaseEN._CurrTabName, conVideoResCase.IdVideoResCase, 8, "");
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
objSQL = clsVideoResCaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsVideoResCaseEN._CurrTabName, conVideoResCase.IdVideoResCase, 8, strPrefix);
return strMaxValue;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstID)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public string GetFirstID(string strCondition) 
{
string strSQL ;
 System.Data.DataTable objDT ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoResCaseDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdVideoResCase from VideoResCase where " + strCondition;
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
return "";
}
strKeyValue = objDT.Rows[0][0].ToString();
return strKeyValue;
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
 objSQL = clsVideoResCaseDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdVideoResCase from VideoResCase where " + strCondition;
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
 /// <param name = "strIdVideoResCase">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strIdVideoResCase)
{
CheckPrimaryKey(strIdVideoResCase);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoResCaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("VideoResCase", "IdVideoResCase = " + "'"+ strIdVideoResCase+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsVideoResCaseDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoResCaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("VideoResCase", strCondition))
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
objSQL = clsVideoResCaseDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("VideoResCase");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsVideoResCaseEN objVideoResCaseEN)
 {
 objVideoResCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objVideoResCaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objVideoResCaseEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoResCaseDA.GetSpecSQLObj();
strSQL = "Select * from VideoResCase where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "VideoResCase");
objRow = objDS.Tables["VideoResCase"].NewRow();
objRow[conVideoResCase.IdVideoResCase] = objVideoResCaseEN.IdVideoResCase; //视频资源案例流水号
objRow[conVideoResCase.VideoResCaseID] = objVideoResCaseEN.VideoResCaseID; //视频资源案例ID
objRow[conVideoResCase.VideoResCaseName] = objVideoResCaseEN.VideoResCaseName; //视频资源案例名称
 if (objVideoResCaseEN.VideoResCaseTheme !=  "")
 {
objRow[conVideoResCase.VideoResCaseTheme] = objVideoResCaseEN.VideoResCaseTheme; //视频资源案例主题词
 }
objRow[conVideoResCase.IdVideoResCaseType] = objVideoResCaseEN.IdVideoResCaseType; //视频资源类型流水号
 if (objVideoResCaseEN.VideoResCaseText !=  "")
 {
objRow[conVideoResCase.VideoResCaseText] = objVideoResCaseEN.VideoResCaseText; //案例文本内容
 }
 if (objVideoResCaseEN.VideoResCaseDate !=  "")
 {
objRow[conVideoResCase.VideoResCaseDate] = objVideoResCaseEN.VideoResCaseDate; //视频资源日期
 }
 if (objVideoResCaseEN.VideoResCaseTime !=  "")
 {
objRow[conVideoResCase.VideoResCaseTime] = objVideoResCaseEN.VideoResCaseTime; //视频资源时间
 }
 if (objVideoResCaseEN.VideoResCaseDateIn !=  "")
 {
objRow[conVideoResCase.VideoResCaseDateIn] = objVideoResCaseEN.VideoResCaseDateIn; //案例入库日期
 }
 if (objVideoResCaseEN.VideoResCaseTimeIn !=  "")
 {
objRow[conVideoResCase.VideoResCaseTimeIn] = objVideoResCaseEN.VideoResCaseTimeIn; //案例入库时间
 }
objRow[conVideoResCase.OwnerId] = objVideoResCaseEN.OwnerId; //拥有者Id
 if (objVideoResCaseEN.IdStudyLevel !=  "")
 {
objRow[conVideoResCase.IdStudyLevel] = objVideoResCaseEN.IdStudyLevel; //id_StudyLevel
 }
 if (objVideoResCaseEN.IdTeachingPlan !=  "")
 {
objRow[conVideoResCase.IdTeachingPlan] = objVideoResCaseEN.IdTeachingPlan; //教案流水号
 }
 if (objVideoResCaseEN.IdDiscipline !=  "")
 {
objRow[conVideoResCase.IdDiscipline] = objVideoResCaseEN.IdDiscipline; //学科流水号
 }
objRow[conVideoResCase.BrowseCount] = objVideoResCaseEN.BrowseCount; //浏览次数
 if (objVideoResCaseEN.IdSenateGaugeVersion !=  "")
 {
objRow[conVideoResCase.IdSenateGaugeVersion] = objVideoResCaseEN.IdSenateGaugeVersion; //评价量表版本流水号
 }
 if (objVideoResCaseEN.IdTeachSkill !=  "")
 {
objRow[conVideoResCase.IdTeachSkill] = objVideoResCaseEN.IdTeachSkill; //教学技能流水号
 }
 if (objVideoResCaseEN.CaseLevelId !=  "")
 {
objRow[conVideoResCase.CaseLevelId] = objVideoResCaseEN.CaseLevelId; //课例等级Id
 }
 if (objVideoResCaseEN.DocFile !=  "")
 {
objRow[conVideoResCase.DocFile] = objVideoResCaseEN.DocFile; //生成的Word文件名
 }
objRow[conVideoResCase.IsNeedGeneWord] = objVideoResCaseEN.IsNeedGeneWord; //是否需要生成Word
 if (objVideoResCaseEN.WordCreateDate !=  "")
 {
objRow[conVideoResCase.WordCreateDate] = objVideoResCaseEN.WordCreateDate; //Word生成日期
 }
objRow[conVideoResCase.IsVisible] = objVideoResCaseEN.IsVisible; //是否显示
objRow[conVideoResCase.IsDualVideo] = objVideoResCaseEN.IsDualVideo; //是否双视频
objRow[conVideoResCase.IdXzCollege] = objVideoResCaseEN.IdXzCollege; //学院流水号
objRow[conVideoResCase.IdXzMajor] = objVideoResCaseEN.IdXzMajor; //专业流水号
 if (objVideoResCaseEN.CourseChapterId !=  "")
 {
objRow[conVideoResCase.CourseChapterId] = objVideoResCaseEN.CourseChapterId; //课程章节ID
 }
objRow[conVideoResCase.ViewCount] = objVideoResCaseEN.ViewCount; //浏览量
objRow[conVideoResCase.IsShow] = objVideoResCaseEN.IsShow; //是否启用
objRow[conVideoResCase.DownloadNumber] = objVideoResCaseEN.DownloadNumber; //下载数目
objRow[conVideoResCase.FileIntegration] = objVideoResCaseEN.FileIntegration; //文件积分
objRow[conVideoResCase.LikeCount] = objVideoResCaseEN.LikeCount; //资源喜欢数量
objRow[conVideoResCase.CollectionCount] = objVideoResCaseEN.CollectionCount; //收藏数量
objRow[conVideoResCase.RecommendedDegreeId] = objVideoResCaseEN.RecommendedDegreeId; //推荐度Id
 if (objVideoResCaseEN.ftpFileType !=  "")
 {
objRow[conVideoResCase.ftpFileType] = objVideoResCaseEN.ftpFileType; //ftp文件类型
 }
objRow[conVideoResCase.CourseId] = objVideoResCaseEN.CourseId; //课程Id
 if (objVideoResCaseEN.VideoUrl !=  "")
 {
objRow[conVideoResCase.VideoUrl] = objVideoResCaseEN.VideoUrl; //视频Url
 }
 if (objVideoResCaseEN.VideoPath !=  "")
 {
objRow[conVideoResCase.VideoPath] = objVideoResCaseEN.VideoPath; //视频目录
 }
 if (objVideoResCaseEN.ResErrMsg !=  "")
 {
objRow[conVideoResCase.ResErrMsg] = objVideoResCaseEN.ResErrMsg; //资源错误信息
 }
 if (objVideoResCaseEN.UpdDate !=  "")
 {
objRow[conVideoResCase.UpdDate] = objVideoResCaseEN.UpdDate; //修改日期
 }
 if (objVideoResCaseEN.UpdUserId !=  "")
 {
objRow[conVideoResCase.UpdUserId] = objVideoResCaseEN.UpdUserId; //修改用户Id
 }
 if (objVideoResCaseEN.Memo !=  "")
 {
objRow[conVideoResCase.Memo] = objVideoResCaseEN.Memo; //备注
 }
objDS.Tables[clsVideoResCaseEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsVideoResCaseEN._CurrTabName);
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
 /// <param name = "objVideoResCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsVideoResCaseEN objVideoResCaseEN)
{
 objVideoResCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objVideoResCaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objVideoResCaseEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objVideoResCaseEN.IdVideoResCase !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.IdVideoResCase);
 var strIdVideoResCase = objVideoResCaseEN.IdVideoResCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdVideoResCase + "'");
 }
 
 if (objVideoResCaseEN.VideoResCaseID !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.VideoResCaseID);
 var strVideoResCaseID = objVideoResCaseEN.VideoResCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoResCaseID + "'");
 }
 
 if (objVideoResCaseEN.VideoResCaseName !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.VideoResCaseName);
 var strVideoResCaseName = objVideoResCaseEN.VideoResCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoResCaseName + "'");
 }
 
 if (objVideoResCaseEN.VideoResCaseTheme !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.VideoResCaseTheme);
 var strVideoResCaseTheme = objVideoResCaseEN.VideoResCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoResCaseTheme + "'");
 }
 
 if (objVideoResCaseEN.IdVideoResCaseType !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.IdVideoResCaseType);
 var strIdVideoResCaseType = objVideoResCaseEN.IdVideoResCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdVideoResCaseType + "'");
 }
 
 if (objVideoResCaseEN.VideoResCaseText !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.VideoResCaseText);
 var strVideoResCaseText = objVideoResCaseEN.VideoResCaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoResCaseText + "'");
 }
 
 if (objVideoResCaseEN.VideoResCaseDate !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.VideoResCaseDate);
 var strVideoResCaseDate = objVideoResCaseEN.VideoResCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoResCaseDate + "'");
 }
 
 if (objVideoResCaseEN.VideoResCaseTime !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.VideoResCaseTime);
 var strVideoResCaseTime = objVideoResCaseEN.VideoResCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoResCaseTime + "'");
 }
 
 if (objVideoResCaseEN.VideoResCaseDateIn !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.VideoResCaseDateIn);
 var strVideoResCaseDateIn = objVideoResCaseEN.VideoResCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoResCaseDateIn + "'");
 }
 
 if (objVideoResCaseEN.VideoResCaseTimeIn !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.VideoResCaseTimeIn);
 var strVideoResCaseTimeIn = objVideoResCaseEN.VideoResCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoResCaseTimeIn + "'");
 }
 
 if (objVideoResCaseEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.OwnerId);
 var strOwnerId = objVideoResCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 if (objVideoResCaseEN.IdStudyLevel  ==  "")
 {
 objVideoResCaseEN.IdStudyLevel = null;
 }
 if (objVideoResCaseEN.IdStudyLevel !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.IdStudyLevel);
 var strIdStudyLevel = objVideoResCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudyLevel + "'");
 }
 
 if (objVideoResCaseEN.IdTeachingPlan !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.IdTeachingPlan);
 var strIdTeachingPlan = objVideoResCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachingPlan + "'");
 }
 
 if (objVideoResCaseEN.IdDiscipline !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.IdDiscipline);
 var strIdDiscipline = objVideoResCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdDiscipline + "'");
 }
 
 if (objVideoResCaseEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.BrowseCount);
 arrValueListForInsert.Add(objVideoResCaseEN.BrowseCount.ToString());
 }
 
 if (objVideoResCaseEN.IdSenateGaugeVersion  ==  "")
 {
 objVideoResCaseEN.IdSenateGaugeVersion = null;
 }
 if (objVideoResCaseEN.IdSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.IdSenateGaugeVersion);
 var strIdSenateGaugeVersion = objVideoResCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeVersion + "'");
 }
 
 if (objVideoResCaseEN.IdTeachSkill !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.IdTeachSkill);
 var strIdTeachSkill = objVideoResCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachSkill + "'");
 }
 
 if (objVideoResCaseEN.CaseLevelId !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.CaseLevelId);
 var strCaseLevelId = objVideoResCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseLevelId + "'");
 }
 
 if (objVideoResCaseEN.DocFile !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.DocFile);
 var strDocFile = objVideoResCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDocFile + "'");
 }
 
 arrFieldListForInsert.Add(conVideoResCase.IsNeedGeneWord);
 arrValueListForInsert.Add("'" + (objVideoResCaseEN.IsNeedGeneWord  ==  false ? "0" : "1") + "'");
 
 if (objVideoResCaseEN.WordCreateDate !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.WordCreateDate);
 var strWordCreateDate = objVideoResCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWordCreateDate + "'");
 }
 
 arrFieldListForInsert.Add(conVideoResCase.IsVisible);
 arrValueListForInsert.Add("'" + (objVideoResCaseEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conVideoResCase.IsDualVideo);
 arrValueListForInsert.Add("'" + (objVideoResCaseEN.IsDualVideo  ==  false ? "0" : "1") + "'");
 
 if (objVideoResCaseEN.IdXzCollege !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.IdXzCollege);
 var strIdXzCollege = objVideoResCaseEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzCollege + "'");
 }
 
 if (objVideoResCaseEN.IdXzMajor !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.IdXzMajor);
 var strIdXzMajor = objVideoResCaseEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzMajor + "'");
 }
 
 if (objVideoResCaseEN.CourseChapterId !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.CourseChapterId);
 var strCourseChapterId = objVideoResCaseEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseChapterId + "'");
 }
 
 if (objVideoResCaseEN.ViewCount !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.ViewCount);
 arrValueListForInsert.Add(objVideoResCaseEN.ViewCount.ToString());
 }
 
 arrFieldListForInsert.Add(conVideoResCase.IsShow);
 arrValueListForInsert.Add("'" + (objVideoResCaseEN.IsShow  ==  false ? "0" : "1") + "'");
 
 if (objVideoResCaseEN.DownloadNumber !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.DownloadNumber);
 arrValueListForInsert.Add(objVideoResCaseEN.DownloadNumber.ToString());
 }
 
 if (objVideoResCaseEN.FileIntegration !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.FileIntegration);
 arrValueListForInsert.Add(objVideoResCaseEN.FileIntegration.ToString());
 }
 
 if (objVideoResCaseEN.LikeCount !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.LikeCount);
 arrValueListForInsert.Add(objVideoResCaseEN.LikeCount.ToString());
 }
 
 if (objVideoResCaseEN.CollectionCount !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.CollectionCount);
 arrValueListForInsert.Add(objVideoResCaseEN.CollectionCount.ToString());
 }
 
 if (objVideoResCaseEN.RecommendedDegreeId !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.RecommendedDegreeId);
 var strRecommendedDegreeId = objVideoResCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRecommendedDegreeId + "'");
 }
 
 if (objVideoResCaseEN.ftpFileType !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.ftpFileType);
 var strftpFileType = objVideoResCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strftpFileType + "'");
 }
 
 if (objVideoResCaseEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.CourseId);
 var strCourseId = objVideoResCaseEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objVideoResCaseEN.VideoUrl !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.VideoUrl);
 var strVideoUrl = objVideoResCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoUrl + "'");
 }
 
 if (objVideoResCaseEN.VideoPath !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.VideoPath);
 var strVideoPath = objVideoResCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoPath + "'");
 }
 
 if (objVideoResCaseEN.ResErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.ResErrMsg);
 var strResErrMsg = objVideoResCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResErrMsg + "'");
 }
 
 if (objVideoResCaseEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.UpdDate);
 var strUpdDate = objVideoResCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objVideoResCaseEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.UpdUserId);
 var strUpdUserId = objVideoResCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objVideoResCaseEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.Memo);
 var strMemo = objVideoResCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into VideoResCase");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoResCaseDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objVideoResCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsVideoResCaseEN objVideoResCaseEN)
{
 objVideoResCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objVideoResCaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objVideoResCaseEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objVideoResCaseEN.IdVideoResCase !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.IdVideoResCase);
 var strIdVideoResCase = objVideoResCaseEN.IdVideoResCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdVideoResCase + "'");
 }
 
 if (objVideoResCaseEN.VideoResCaseID !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.VideoResCaseID);
 var strVideoResCaseID = objVideoResCaseEN.VideoResCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoResCaseID + "'");
 }
 
 if (objVideoResCaseEN.VideoResCaseName !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.VideoResCaseName);
 var strVideoResCaseName = objVideoResCaseEN.VideoResCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoResCaseName + "'");
 }
 
 if (objVideoResCaseEN.VideoResCaseTheme !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.VideoResCaseTheme);
 var strVideoResCaseTheme = objVideoResCaseEN.VideoResCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoResCaseTheme + "'");
 }
 
 if (objVideoResCaseEN.IdVideoResCaseType !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.IdVideoResCaseType);
 var strIdVideoResCaseType = objVideoResCaseEN.IdVideoResCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdVideoResCaseType + "'");
 }
 
 if (objVideoResCaseEN.VideoResCaseText !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.VideoResCaseText);
 var strVideoResCaseText = objVideoResCaseEN.VideoResCaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoResCaseText + "'");
 }
 
 if (objVideoResCaseEN.VideoResCaseDate !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.VideoResCaseDate);
 var strVideoResCaseDate = objVideoResCaseEN.VideoResCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoResCaseDate + "'");
 }
 
 if (objVideoResCaseEN.VideoResCaseTime !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.VideoResCaseTime);
 var strVideoResCaseTime = objVideoResCaseEN.VideoResCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoResCaseTime + "'");
 }
 
 if (objVideoResCaseEN.VideoResCaseDateIn !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.VideoResCaseDateIn);
 var strVideoResCaseDateIn = objVideoResCaseEN.VideoResCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoResCaseDateIn + "'");
 }
 
 if (objVideoResCaseEN.VideoResCaseTimeIn !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.VideoResCaseTimeIn);
 var strVideoResCaseTimeIn = objVideoResCaseEN.VideoResCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoResCaseTimeIn + "'");
 }
 
 if (objVideoResCaseEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.OwnerId);
 var strOwnerId = objVideoResCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 if (objVideoResCaseEN.IdStudyLevel  ==  "")
 {
 objVideoResCaseEN.IdStudyLevel = null;
 }
 if (objVideoResCaseEN.IdStudyLevel !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.IdStudyLevel);
 var strIdStudyLevel = objVideoResCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudyLevel + "'");
 }
 
 if (objVideoResCaseEN.IdTeachingPlan !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.IdTeachingPlan);
 var strIdTeachingPlan = objVideoResCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachingPlan + "'");
 }
 
 if (objVideoResCaseEN.IdDiscipline !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.IdDiscipline);
 var strIdDiscipline = objVideoResCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdDiscipline + "'");
 }
 
 if (objVideoResCaseEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.BrowseCount);
 arrValueListForInsert.Add(objVideoResCaseEN.BrowseCount.ToString());
 }
 
 if (objVideoResCaseEN.IdSenateGaugeVersion  ==  "")
 {
 objVideoResCaseEN.IdSenateGaugeVersion = null;
 }
 if (objVideoResCaseEN.IdSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.IdSenateGaugeVersion);
 var strIdSenateGaugeVersion = objVideoResCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeVersion + "'");
 }
 
 if (objVideoResCaseEN.IdTeachSkill !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.IdTeachSkill);
 var strIdTeachSkill = objVideoResCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachSkill + "'");
 }
 
 if (objVideoResCaseEN.CaseLevelId !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.CaseLevelId);
 var strCaseLevelId = objVideoResCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseLevelId + "'");
 }
 
 if (objVideoResCaseEN.DocFile !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.DocFile);
 var strDocFile = objVideoResCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDocFile + "'");
 }
 
 arrFieldListForInsert.Add(conVideoResCase.IsNeedGeneWord);
 arrValueListForInsert.Add("'" + (objVideoResCaseEN.IsNeedGeneWord  ==  false ? "0" : "1") + "'");
 
 if (objVideoResCaseEN.WordCreateDate !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.WordCreateDate);
 var strWordCreateDate = objVideoResCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWordCreateDate + "'");
 }
 
 arrFieldListForInsert.Add(conVideoResCase.IsVisible);
 arrValueListForInsert.Add("'" + (objVideoResCaseEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conVideoResCase.IsDualVideo);
 arrValueListForInsert.Add("'" + (objVideoResCaseEN.IsDualVideo  ==  false ? "0" : "1") + "'");
 
 if (objVideoResCaseEN.IdXzCollege !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.IdXzCollege);
 var strIdXzCollege = objVideoResCaseEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzCollege + "'");
 }
 
 if (objVideoResCaseEN.IdXzMajor !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.IdXzMajor);
 var strIdXzMajor = objVideoResCaseEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzMajor + "'");
 }
 
 if (objVideoResCaseEN.CourseChapterId !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.CourseChapterId);
 var strCourseChapterId = objVideoResCaseEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseChapterId + "'");
 }
 
 if (objVideoResCaseEN.ViewCount !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.ViewCount);
 arrValueListForInsert.Add(objVideoResCaseEN.ViewCount.ToString());
 }
 
 arrFieldListForInsert.Add(conVideoResCase.IsShow);
 arrValueListForInsert.Add("'" + (objVideoResCaseEN.IsShow  ==  false ? "0" : "1") + "'");
 
 if (objVideoResCaseEN.DownloadNumber !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.DownloadNumber);
 arrValueListForInsert.Add(objVideoResCaseEN.DownloadNumber.ToString());
 }
 
 if (objVideoResCaseEN.FileIntegration !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.FileIntegration);
 arrValueListForInsert.Add(objVideoResCaseEN.FileIntegration.ToString());
 }
 
 if (objVideoResCaseEN.LikeCount !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.LikeCount);
 arrValueListForInsert.Add(objVideoResCaseEN.LikeCount.ToString());
 }
 
 if (objVideoResCaseEN.CollectionCount !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.CollectionCount);
 arrValueListForInsert.Add(objVideoResCaseEN.CollectionCount.ToString());
 }
 
 if (objVideoResCaseEN.RecommendedDegreeId !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.RecommendedDegreeId);
 var strRecommendedDegreeId = objVideoResCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRecommendedDegreeId + "'");
 }
 
 if (objVideoResCaseEN.ftpFileType !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.ftpFileType);
 var strftpFileType = objVideoResCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strftpFileType + "'");
 }
 
 if (objVideoResCaseEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.CourseId);
 var strCourseId = objVideoResCaseEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objVideoResCaseEN.VideoUrl !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.VideoUrl);
 var strVideoUrl = objVideoResCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoUrl + "'");
 }
 
 if (objVideoResCaseEN.VideoPath !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.VideoPath);
 var strVideoPath = objVideoResCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoPath + "'");
 }
 
 if (objVideoResCaseEN.ResErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.ResErrMsg);
 var strResErrMsg = objVideoResCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResErrMsg + "'");
 }
 
 if (objVideoResCaseEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.UpdDate);
 var strUpdDate = objVideoResCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objVideoResCaseEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.UpdUserId);
 var strUpdUserId = objVideoResCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objVideoResCaseEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.Memo);
 var strMemo = objVideoResCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into VideoResCase");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoResCaseDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objVideoResCaseEN.IdVideoResCase;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objVideoResCaseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsVideoResCaseEN objVideoResCaseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objVideoResCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objVideoResCaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objVideoResCaseEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objVideoResCaseEN.IdVideoResCase !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.IdVideoResCase);
 var strIdVideoResCase = objVideoResCaseEN.IdVideoResCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdVideoResCase + "'");
 }
 
 if (objVideoResCaseEN.VideoResCaseID !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.VideoResCaseID);
 var strVideoResCaseID = objVideoResCaseEN.VideoResCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoResCaseID + "'");
 }
 
 if (objVideoResCaseEN.VideoResCaseName !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.VideoResCaseName);
 var strVideoResCaseName = objVideoResCaseEN.VideoResCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoResCaseName + "'");
 }
 
 if (objVideoResCaseEN.VideoResCaseTheme !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.VideoResCaseTheme);
 var strVideoResCaseTheme = objVideoResCaseEN.VideoResCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoResCaseTheme + "'");
 }
 
 if (objVideoResCaseEN.IdVideoResCaseType !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.IdVideoResCaseType);
 var strIdVideoResCaseType = objVideoResCaseEN.IdVideoResCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdVideoResCaseType + "'");
 }
 
 if (objVideoResCaseEN.VideoResCaseText !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.VideoResCaseText);
 var strVideoResCaseText = objVideoResCaseEN.VideoResCaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoResCaseText + "'");
 }
 
 if (objVideoResCaseEN.VideoResCaseDate !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.VideoResCaseDate);
 var strVideoResCaseDate = objVideoResCaseEN.VideoResCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoResCaseDate + "'");
 }
 
 if (objVideoResCaseEN.VideoResCaseTime !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.VideoResCaseTime);
 var strVideoResCaseTime = objVideoResCaseEN.VideoResCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoResCaseTime + "'");
 }
 
 if (objVideoResCaseEN.VideoResCaseDateIn !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.VideoResCaseDateIn);
 var strVideoResCaseDateIn = objVideoResCaseEN.VideoResCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoResCaseDateIn + "'");
 }
 
 if (objVideoResCaseEN.VideoResCaseTimeIn !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.VideoResCaseTimeIn);
 var strVideoResCaseTimeIn = objVideoResCaseEN.VideoResCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoResCaseTimeIn + "'");
 }
 
 if (objVideoResCaseEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.OwnerId);
 var strOwnerId = objVideoResCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 if (objVideoResCaseEN.IdStudyLevel  ==  "")
 {
 objVideoResCaseEN.IdStudyLevel = null;
 }
 if (objVideoResCaseEN.IdStudyLevel !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.IdStudyLevel);
 var strIdStudyLevel = objVideoResCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudyLevel + "'");
 }
 
 if (objVideoResCaseEN.IdTeachingPlan !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.IdTeachingPlan);
 var strIdTeachingPlan = objVideoResCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachingPlan + "'");
 }
 
 if (objVideoResCaseEN.IdDiscipline !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.IdDiscipline);
 var strIdDiscipline = objVideoResCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdDiscipline + "'");
 }
 
 if (objVideoResCaseEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.BrowseCount);
 arrValueListForInsert.Add(objVideoResCaseEN.BrowseCount.ToString());
 }
 
 if (objVideoResCaseEN.IdSenateGaugeVersion  ==  "")
 {
 objVideoResCaseEN.IdSenateGaugeVersion = null;
 }
 if (objVideoResCaseEN.IdSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.IdSenateGaugeVersion);
 var strIdSenateGaugeVersion = objVideoResCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeVersion + "'");
 }
 
 if (objVideoResCaseEN.IdTeachSkill !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.IdTeachSkill);
 var strIdTeachSkill = objVideoResCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachSkill + "'");
 }
 
 if (objVideoResCaseEN.CaseLevelId !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.CaseLevelId);
 var strCaseLevelId = objVideoResCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseLevelId + "'");
 }
 
 if (objVideoResCaseEN.DocFile !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.DocFile);
 var strDocFile = objVideoResCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDocFile + "'");
 }
 
 arrFieldListForInsert.Add(conVideoResCase.IsNeedGeneWord);
 arrValueListForInsert.Add("'" + (objVideoResCaseEN.IsNeedGeneWord  ==  false ? "0" : "1") + "'");
 
 if (objVideoResCaseEN.WordCreateDate !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.WordCreateDate);
 var strWordCreateDate = objVideoResCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWordCreateDate + "'");
 }
 
 arrFieldListForInsert.Add(conVideoResCase.IsVisible);
 arrValueListForInsert.Add("'" + (objVideoResCaseEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conVideoResCase.IsDualVideo);
 arrValueListForInsert.Add("'" + (objVideoResCaseEN.IsDualVideo  ==  false ? "0" : "1") + "'");
 
 if (objVideoResCaseEN.IdXzCollege !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.IdXzCollege);
 var strIdXzCollege = objVideoResCaseEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzCollege + "'");
 }
 
 if (objVideoResCaseEN.IdXzMajor !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.IdXzMajor);
 var strIdXzMajor = objVideoResCaseEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzMajor + "'");
 }
 
 if (objVideoResCaseEN.CourseChapterId !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.CourseChapterId);
 var strCourseChapterId = objVideoResCaseEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseChapterId + "'");
 }
 
 if (objVideoResCaseEN.ViewCount !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.ViewCount);
 arrValueListForInsert.Add(objVideoResCaseEN.ViewCount.ToString());
 }
 
 arrFieldListForInsert.Add(conVideoResCase.IsShow);
 arrValueListForInsert.Add("'" + (objVideoResCaseEN.IsShow  ==  false ? "0" : "1") + "'");
 
 if (objVideoResCaseEN.DownloadNumber !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.DownloadNumber);
 arrValueListForInsert.Add(objVideoResCaseEN.DownloadNumber.ToString());
 }
 
 if (objVideoResCaseEN.FileIntegration !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.FileIntegration);
 arrValueListForInsert.Add(objVideoResCaseEN.FileIntegration.ToString());
 }
 
 if (objVideoResCaseEN.LikeCount !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.LikeCount);
 arrValueListForInsert.Add(objVideoResCaseEN.LikeCount.ToString());
 }
 
 if (objVideoResCaseEN.CollectionCount !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.CollectionCount);
 arrValueListForInsert.Add(objVideoResCaseEN.CollectionCount.ToString());
 }
 
 if (objVideoResCaseEN.RecommendedDegreeId !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.RecommendedDegreeId);
 var strRecommendedDegreeId = objVideoResCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRecommendedDegreeId + "'");
 }
 
 if (objVideoResCaseEN.ftpFileType !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.ftpFileType);
 var strftpFileType = objVideoResCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strftpFileType + "'");
 }
 
 if (objVideoResCaseEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.CourseId);
 var strCourseId = objVideoResCaseEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objVideoResCaseEN.VideoUrl !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.VideoUrl);
 var strVideoUrl = objVideoResCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoUrl + "'");
 }
 
 if (objVideoResCaseEN.VideoPath !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.VideoPath);
 var strVideoPath = objVideoResCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoPath + "'");
 }
 
 if (objVideoResCaseEN.ResErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.ResErrMsg);
 var strResErrMsg = objVideoResCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResErrMsg + "'");
 }
 
 if (objVideoResCaseEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.UpdDate);
 var strUpdDate = objVideoResCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objVideoResCaseEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.UpdUserId);
 var strUpdUserId = objVideoResCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objVideoResCaseEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.Memo);
 var strMemo = objVideoResCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into VideoResCase");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoResCaseDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objVideoResCaseEN.IdVideoResCase;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objVideoResCaseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsVideoResCaseEN objVideoResCaseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objVideoResCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objVideoResCaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objVideoResCaseEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objVideoResCaseEN.IdVideoResCase !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.IdVideoResCase);
 var strIdVideoResCase = objVideoResCaseEN.IdVideoResCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdVideoResCase + "'");
 }
 
 if (objVideoResCaseEN.VideoResCaseID !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.VideoResCaseID);
 var strVideoResCaseID = objVideoResCaseEN.VideoResCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoResCaseID + "'");
 }
 
 if (objVideoResCaseEN.VideoResCaseName !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.VideoResCaseName);
 var strVideoResCaseName = objVideoResCaseEN.VideoResCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoResCaseName + "'");
 }
 
 if (objVideoResCaseEN.VideoResCaseTheme !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.VideoResCaseTheme);
 var strVideoResCaseTheme = objVideoResCaseEN.VideoResCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoResCaseTheme + "'");
 }
 
 if (objVideoResCaseEN.IdVideoResCaseType !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.IdVideoResCaseType);
 var strIdVideoResCaseType = objVideoResCaseEN.IdVideoResCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdVideoResCaseType + "'");
 }
 
 if (objVideoResCaseEN.VideoResCaseText !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.VideoResCaseText);
 var strVideoResCaseText = objVideoResCaseEN.VideoResCaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoResCaseText + "'");
 }
 
 if (objVideoResCaseEN.VideoResCaseDate !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.VideoResCaseDate);
 var strVideoResCaseDate = objVideoResCaseEN.VideoResCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoResCaseDate + "'");
 }
 
 if (objVideoResCaseEN.VideoResCaseTime !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.VideoResCaseTime);
 var strVideoResCaseTime = objVideoResCaseEN.VideoResCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoResCaseTime + "'");
 }
 
 if (objVideoResCaseEN.VideoResCaseDateIn !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.VideoResCaseDateIn);
 var strVideoResCaseDateIn = objVideoResCaseEN.VideoResCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoResCaseDateIn + "'");
 }
 
 if (objVideoResCaseEN.VideoResCaseTimeIn !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.VideoResCaseTimeIn);
 var strVideoResCaseTimeIn = objVideoResCaseEN.VideoResCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoResCaseTimeIn + "'");
 }
 
 if (objVideoResCaseEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.OwnerId);
 var strOwnerId = objVideoResCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 if (objVideoResCaseEN.IdStudyLevel  ==  "")
 {
 objVideoResCaseEN.IdStudyLevel = null;
 }
 if (objVideoResCaseEN.IdStudyLevel !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.IdStudyLevel);
 var strIdStudyLevel = objVideoResCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudyLevel + "'");
 }
 
 if (objVideoResCaseEN.IdTeachingPlan !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.IdTeachingPlan);
 var strIdTeachingPlan = objVideoResCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachingPlan + "'");
 }
 
 if (objVideoResCaseEN.IdDiscipline !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.IdDiscipline);
 var strIdDiscipline = objVideoResCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdDiscipline + "'");
 }
 
 if (objVideoResCaseEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.BrowseCount);
 arrValueListForInsert.Add(objVideoResCaseEN.BrowseCount.ToString());
 }
 
 if (objVideoResCaseEN.IdSenateGaugeVersion  ==  "")
 {
 objVideoResCaseEN.IdSenateGaugeVersion = null;
 }
 if (objVideoResCaseEN.IdSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.IdSenateGaugeVersion);
 var strIdSenateGaugeVersion = objVideoResCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeVersion + "'");
 }
 
 if (objVideoResCaseEN.IdTeachSkill !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.IdTeachSkill);
 var strIdTeachSkill = objVideoResCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachSkill + "'");
 }
 
 if (objVideoResCaseEN.CaseLevelId !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.CaseLevelId);
 var strCaseLevelId = objVideoResCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseLevelId + "'");
 }
 
 if (objVideoResCaseEN.DocFile !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.DocFile);
 var strDocFile = objVideoResCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDocFile + "'");
 }
 
 arrFieldListForInsert.Add(conVideoResCase.IsNeedGeneWord);
 arrValueListForInsert.Add("'" + (objVideoResCaseEN.IsNeedGeneWord  ==  false ? "0" : "1") + "'");
 
 if (objVideoResCaseEN.WordCreateDate !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.WordCreateDate);
 var strWordCreateDate = objVideoResCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWordCreateDate + "'");
 }
 
 arrFieldListForInsert.Add(conVideoResCase.IsVisible);
 arrValueListForInsert.Add("'" + (objVideoResCaseEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conVideoResCase.IsDualVideo);
 arrValueListForInsert.Add("'" + (objVideoResCaseEN.IsDualVideo  ==  false ? "0" : "1") + "'");
 
 if (objVideoResCaseEN.IdXzCollege !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.IdXzCollege);
 var strIdXzCollege = objVideoResCaseEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzCollege + "'");
 }
 
 if (objVideoResCaseEN.IdXzMajor !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.IdXzMajor);
 var strIdXzMajor = objVideoResCaseEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzMajor + "'");
 }
 
 if (objVideoResCaseEN.CourseChapterId !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.CourseChapterId);
 var strCourseChapterId = objVideoResCaseEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseChapterId + "'");
 }
 
 if (objVideoResCaseEN.ViewCount !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.ViewCount);
 arrValueListForInsert.Add(objVideoResCaseEN.ViewCount.ToString());
 }
 
 arrFieldListForInsert.Add(conVideoResCase.IsShow);
 arrValueListForInsert.Add("'" + (objVideoResCaseEN.IsShow  ==  false ? "0" : "1") + "'");
 
 if (objVideoResCaseEN.DownloadNumber !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.DownloadNumber);
 arrValueListForInsert.Add(objVideoResCaseEN.DownloadNumber.ToString());
 }
 
 if (objVideoResCaseEN.FileIntegration !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.FileIntegration);
 arrValueListForInsert.Add(objVideoResCaseEN.FileIntegration.ToString());
 }
 
 if (objVideoResCaseEN.LikeCount !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.LikeCount);
 arrValueListForInsert.Add(objVideoResCaseEN.LikeCount.ToString());
 }
 
 if (objVideoResCaseEN.CollectionCount !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.CollectionCount);
 arrValueListForInsert.Add(objVideoResCaseEN.CollectionCount.ToString());
 }
 
 if (objVideoResCaseEN.RecommendedDegreeId !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.RecommendedDegreeId);
 var strRecommendedDegreeId = objVideoResCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRecommendedDegreeId + "'");
 }
 
 if (objVideoResCaseEN.ftpFileType !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.ftpFileType);
 var strftpFileType = objVideoResCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strftpFileType + "'");
 }
 
 if (objVideoResCaseEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.CourseId);
 var strCourseId = objVideoResCaseEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objVideoResCaseEN.VideoUrl !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.VideoUrl);
 var strVideoUrl = objVideoResCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoUrl + "'");
 }
 
 if (objVideoResCaseEN.VideoPath !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.VideoPath);
 var strVideoPath = objVideoResCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoPath + "'");
 }
 
 if (objVideoResCaseEN.ResErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.ResErrMsg);
 var strResErrMsg = objVideoResCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResErrMsg + "'");
 }
 
 if (objVideoResCaseEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.UpdDate);
 var strUpdDate = objVideoResCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objVideoResCaseEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.UpdUserId);
 var strUpdUserId = objVideoResCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objVideoResCaseEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conVideoResCase.Memo);
 var strMemo = objVideoResCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into VideoResCase");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoResCaseDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewVideoResCases(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoResCaseDA.GetSpecSQLObj();
strSQL = "Select * from VideoResCase where IdVideoResCase = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "VideoResCase");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strIdVideoResCase = oRow[conVideoResCase.IdVideoResCase].ToString().Trim();
if (IsExist(strIdVideoResCase))
{
 string strResult = "关键字变量值为:" + string.Format("IdVideoResCase = {0}", strIdVideoResCase) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsVideoResCaseEN._CurrTabName ].NewRow();
objRow[conVideoResCase.IdVideoResCase] = oRow[conVideoResCase.IdVideoResCase].ToString().Trim(); //视频资源案例流水号
objRow[conVideoResCase.VideoResCaseID] = oRow[conVideoResCase.VideoResCaseID].ToString().Trim(); //视频资源案例ID
objRow[conVideoResCase.VideoResCaseName] = oRow[conVideoResCase.VideoResCaseName].ToString().Trim(); //视频资源案例名称
objRow[conVideoResCase.VideoResCaseTheme] = oRow[conVideoResCase.VideoResCaseTheme].ToString().Trim(); //视频资源案例主题词
objRow[conVideoResCase.IdVideoResCaseType] = oRow[conVideoResCase.IdVideoResCaseType].ToString().Trim(); //视频资源类型流水号
objRow[conVideoResCase.VideoResCaseText] = oRow[conVideoResCase.VideoResCaseText].ToString().Trim(); //案例文本内容
objRow[conVideoResCase.VideoResCaseDate] = oRow[conVideoResCase.VideoResCaseDate].ToString().Trim(); //视频资源日期
objRow[conVideoResCase.VideoResCaseTime] = oRow[conVideoResCase.VideoResCaseTime].ToString().Trim(); //视频资源时间
objRow[conVideoResCase.VideoResCaseDateIn] = oRow[conVideoResCase.VideoResCaseDateIn].ToString().Trim(); //案例入库日期
objRow[conVideoResCase.VideoResCaseTimeIn] = oRow[conVideoResCase.VideoResCaseTimeIn].ToString().Trim(); //案例入库时间
objRow[conVideoResCase.OwnerId] = oRow[conVideoResCase.OwnerId].ToString().Trim(); //拥有者Id
objRow[conVideoResCase.IdStudyLevel] = oRow[conVideoResCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objRow[conVideoResCase.IdTeachingPlan] = oRow[conVideoResCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objRow[conVideoResCase.IdDiscipline] = oRow[conVideoResCase.IdDiscipline].ToString().Trim(); //学科流水号
objRow[conVideoResCase.BrowseCount] = oRow[conVideoResCase.BrowseCount].ToString().Trim(); //浏览次数
objRow[conVideoResCase.IdSenateGaugeVersion] = oRow[conVideoResCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objRow[conVideoResCase.IdTeachSkill] = oRow[conVideoResCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objRow[conVideoResCase.CaseLevelId] = oRow[conVideoResCase.CaseLevelId].ToString().Trim(); //课例等级Id
objRow[conVideoResCase.DocFile] = oRow[conVideoResCase.DocFile].ToString().Trim(); //生成的Word文件名
objRow[conVideoResCase.IsNeedGeneWord] = oRow[conVideoResCase.IsNeedGeneWord].ToString().Trim(); //是否需要生成Word
objRow[conVideoResCase.WordCreateDate] = oRow[conVideoResCase.WordCreateDate].ToString().Trim(); //Word生成日期
objRow[conVideoResCase.IsVisible] = oRow[conVideoResCase.IsVisible].ToString().Trim(); //是否显示
objRow[conVideoResCase.IsDualVideo] = oRow[conVideoResCase.IsDualVideo].ToString().Trim(); //是否双视频
objRow[conVideoResCase.IdXzCollege] = oRow[conVideoResCase.IdXzCollege].ToString().Trim(); //学院流水号
objRow[conVideoResCase.IdXzMajor] = oRow[conVideoResCase.IdXzMajor].ToString().Trim(); //专业流水号
objRow[conVideoResCase.CourseChapterId] = oRow[conVideoResCase.CourseChapterId].ToString().Trim(); //课程章节ID
objRow[conVideoResCase.ViewCount] = oRow[conVideoResCase.ViewCount].ToString().Trim(); //浏览量
objRow[conVideoResCase.IsShow] = oRow[conVideoResCase.IsShow].ToString().Trim(); //是否启用
objRow[conVideoResCase.DownloadNumber] = oRow[conVideoResCase.DownloadNumber].ToString().Trim(); //下载数目
objRow[conVideoResCase.FileIntegration] = oRow[conVideoResCase.FileIntegration].ToString().Trim(); //文件积分
objRow[conVideoResCase.LikeCount] = oRow[conVideoResCase.LikeCount].ToString().Trim(); //资源喜欢数量
objRow[conVideoResCase.CollectionCount] = oRow[conVideoResCase.CollectionCount].ToString().Trim(); //收藏数量
objRow[conVideoResCase.RecommendedDegreeId] = oRow[conVideoResCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objRow[conVideoResCase.ftpFileType] = oRow[conVideoResCase.ftpFileType].ToString().Trim(); //ftp文件类型
objRow[conVideoResCase.CourseId] = oRow[conVideoResCase.CourseId].ToString().Trim(); //课程Id
objRow[conVideoResCase.VideoUrl] = oRow[conVideoResCase.VideoUrl].ToString().Trim(); //视频Url
objRow[conVideoResCase.VideoPath] = oRow[conVideoResCase.VideoPath].ToString().Trim(); //视频目录
objRow[conVideoResCase.ResErrMsg] = oRow[conVideoResCase.ResErrMsg].ToString().Trim(); //资源错误信息
objRow[conVideoResCase.UpdDate] = oRow[conVideoResCase.UpdDate].ToString().Trim(); //修改日期
objRow[conVideoResCase.UpdUserId] = oRow[conVideoResCase.UpdUserId].ToString().Trim(); //修改用户Id
objRow[conVideoResCase.Memo] = oRow[conVideoResCase.Memo].ToString().Trim(); //备注
 objDS.Tables[clsVideoResCaseEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsVideoResCaseEN._CurrTabName);
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
 /// <param name = "objVideoResCaseEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsVideoResCaseEN objVideoResCaseEN)
{
 objVideoResCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objVideoResCaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objVideoResCaseEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoResCaseDA.GetSpecSQLObj();
strSQL = "Select * from VideoResCase where IdVideoResCase = " + "'"+ objVideoResCaseEN.IdVideoResCase+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsVideoResCaseEN._CurrTabName);
if (objDS.Tables[clsVideoResCaseEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:IdVideoResCase = " + "'"+ objVideoResCaseEN.IdVideoResCase+"'");
return false;
}
objRow = objDS.Tables[clsVideoResCaseEN._CurrTabName].Rows[0];
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.IdVideoResCase))
 {
objRow[conVideoResCase.IdVideoResCase] = objVideoResCaseEN.IdVideoResCase; //视频资源案例流水号
 }
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.VideoResCaseID))
 {
objRow[conVideoResCase.VideoResCaseID] = objVideoResCaseEN.VideoResCaseID; //视频资源案例ID
 }
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.VideoResCaseName))
 {
objRow[conVideoResCase.VideoResCaseName] = objVideoResCaseEN.VideoResCaseName; //视频资源案例名称
 }
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.VideoResCaseTheme))
 {
objRow[conVideoResCase.VideoResCaseTheme] = objVideoResCaseEN.VideoResCaseTheme; //视频资源案例主题词
 }
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.IdVideoResCaseType))
 {
objRow[conVideoResCase.IdVideoResCaseType] = objVideoResCaseEN.IdVideoResCaseType; //视频资源类型流水号
 }
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.VideoResCaseText))
 {
objRow[conVideoResCase.VideoResCaseText] = objVideoResCaseEN.VideoResCaseText; //案例文本内容
 }
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.VideoResCaseDate))
 {
objRow[conVideoResCase.VideoResCaseDate] = objVideoResCaseEN.VideoResCaseDate; //视频资源日期
 }
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.VideoResCaseTime))
 {
objRow[conVideoResCase.VideoResCaseTime] = objVideoResCaseEN.VideoResCaseTime; //视频资源时间
 }
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.VideoResCaseDateIn))
 {
objRow[conVideoResCase.VideoResCaseDateIn] = objVideoResCaseEN.VideoResCaseDateIn; //案例入库日期
 }
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.VideoResCaseTimeIn))
 {
objRow[conVideoResCase.VideoResCaseTimeIn] = objVideoResCaseEN.VideoResCaseTimeIn; //案例入库时间
 }
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.OwnerId))
 {
objRow[conVideoResCase.OwnerId] = objVideoResCaseEN.OwnerId; //拥有者Id
 }
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.IdStudyLevel))
 {
objRow[conVideoResCase.IdStudyLevel] = objVideoResCaseEN.IdStudyLevel; //id_StudyLevel
 }
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.IdTeachingPlan))
 {
objRow[conVideoResCase.IdTeachingPlan] = objVideoResCaseEN.IdTeachingPlan; //教案流水号
 }
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.IdDiscipline))
 {
objRow[conVideoResCase.IdDiscipline] = objVideoResCaseEN.IdDiscipline; //学科流水号
 }
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.BrowseCount))
 {
objRow[conVideoResCase.BrowseCount] = objVideoResCaseEN.BrowseCount; //浏览次数
 }
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.IdSenateGaugeVersion))
 {
objRow[conVideoResCase.IdSenateGaugeVersion] = objVideoResCaseEN.IdSenateGaugeVersion; //评价量表版本流水号
 }
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.IdTeachSkill))
 {
objRow[conVideoResCase.IdTeachSkill] = objVideoResCaseEN.IdTeachSkill; //教学技能流水号
 }
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.CaseLevelId))
 {
objRow[conVideoResCase.CaseLevelId] = objVideoResCaseEN.CaseLevelId; //课例等级Id
 }
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.DocFile))
 {
objRow[conVideoResCase.DocFile] = objVideoResCaseEN.DocFile; //生成的Word文件名
 }
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.IsNeedGeneWord))
 {
objRow[conVideoResCase.IsNeedGeneWord] = objVideoResCaseEN.IsNeedGeneWord; //是否需要生成Word
 }
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.WordCreateDate))
 {
objRow[conVideoResCase.WordCreateDate] = objVideoResCaseEN.WordCreateDate; //Word生成日期
 }
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.IsVisible))
 {
objRow[conVideoResCase.IsVisible] = objVideoResCaseEN.IsVisible; //是否显示
 }
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.IsDualVideo))
 {
objRow[conVideoResCase.IsDualVideo] = objVideoResCaseEN.IsDualVideo; //是否双视频
 }
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.IdXzCollege))
 {
objRow[conVideoResCase.IdXzCollege] = objVideoResCaseEN.IdXzCollege; //学院流水号
 }
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.IdXzMajor))
 {
objRow[conVideoResCase.IdXzMajor] = objVideoResCaseEN.IdXzMajor; //专业流水号
 }
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.CourseChapterId))
 {
objRow[conVideoResCase.CourseChapterId] = objVideoResCaseEN.CourseChapterId; //课程章节ID
 }
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.ViewCount))
 {
objRow[conVideoResCase.ViewCount] = objVideoResCaseEN.ViewCount; //浏览量
 }
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.IsShow))
 {
objRow[conVideoResCase.IsShow] = objVideoResCaseEN.IsShow; //是否启用
 }
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.DownloadNumber))
 {
objRow[conVideoResCase.DownloadNumber] = objVideoResCaseEN.DownloadNumber; //下载数目
 }
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.FileIntegration))
 {
objRow[conVideoResCase.FileIntegration] = objVideoResCaseEN.FileIntegration; //文件积分
 }
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.LikeCount))
 {
objRow[conVideoResCase.LikeCount] = objVideoResCaseEN.LikeCount; //资源喜欢数量
 }
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.CollectionCount))
 {
objRow[conVideoResCase.CollectionCount] = objVideoResCaseEN.CollectionCount; //收藏数量
 }
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.RecommendedDegreeId))
 {
objRow[conVideoResCase.RecommendedDegreeId] = objVideoResCaseEN.RecommendedDegreeId; //推荐度Id
 }
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.ftpFileType))
 {
objRow[conVideoResCase.ftpFileType] = objVideoResCaseEN.ftpFileType; //ftp文件类型
 }
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.CourseId))
 {
objRow[conVideoResCase.CourseId] = objVideoResCaseEN.CourseId; //课程Id
 }
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.VideoUrl))
 {
objRow[conVideoResCase.VideoUrl] = objVideoResCaseEN.VideoUrl; //视频Url
 }
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.VideoPath))
 {
objRow[conVideoResCase.VideoPath] = objVideoResCaseEN.VideoPath; //视频目录
 }
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.ResErrMsg))
 {
objRow[conVideoResCase.ResErrMsg] = objVideoResCaseEN.ResErrMsg; //资源错误信息
 }
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.UpdDate))
 {
objRow[conVideoResCase.UpdDate] = objVideoResCaseEN.UpdDate; //修改日期
 }
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.UpdUserId))
 {
objRow[conVideoResCase.UpdUserId] = objVideoResCaseEN.UpdUserId; //修改用户Id
 }
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.Memo))
 {
objRow[conVideoResCase.Memo] = objVideoResCaseEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsVideoResCaseEN._CurrTabName);
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
 /// <param name = "objVideoResCaseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsVideoResCaseEN objVideoResCaseEN)
{
 objVideoResCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objVideoResCaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objVideoResCaseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoResCaseDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update VideoResCase Set ");
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.VideoResCaseID))
 {
 if (objVideoResCaseEN.VideoResCaseID !=  null)
 {
 var strVideoResCaseID = objVideoResCaseEN.VideoResCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoResCaseID, conVideoResCase.VideoResCaseID); //视频资源案例ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoResCase.VideoResCaseID); //视频资源案例ID
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.VideoResCaseName))
 {
 if (objVideoResCaseEN.VideoResCaseName !=  null)
 {
 var strVideoResCaseName = objVideoResCaseEN.VideoResCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoResCaseName, conVideoResCase.VideoResCaseName); //视频资源案例名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoResCase.VideoResCaseName); //视频资源案例名称
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.VideoResCaseTheme))
 {
 if (objVideoResCaseEN.VideoResCaseTheme !=  null)
 {
 var strVideoResCaseTheme = objVideoResCaseEN.VideoResCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoResCaseTheme, conVideoResCase.VideoResCaseTheme); //视频资源案例主题词
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoResCase.VideoResCaseTheme); //视频资源案例主题词
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.IdVideoResCaseType))
 {
 if (objVideoResCaseEN.IdVideoResCaseType !=  null)
 {
 var strIdVideoResCaseType = objVideoResCaseEN.IdVideoResCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdVideoResCaseType, conVideoResCase.IdVideoResCaseType); //视频资源类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoResCase.IdVideoResCaseType); //视频资源类型流水号
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.VideoResCaseText))
 {
 if (objVideoResCaseEN.VideoResCaseText !=  null)
 {
 var strVideoResCaseText = objVideoResCaseEN.VideoResCaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoResCaseText, conVideoResCase.VideoResCaseText); //案例文本内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoResCase.VideoResCaseText); //案例文本内容
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.VideoResCaseDate))
 {
 if (objVideoResCaseEN.VideoResCaseDate !=  null)
 {
 var strVideoResCaseDate = objVideoResCaseEN.VideoResCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoResCaseDate, conVideoResCase.VideoResCaseDate); //视频资源日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoResCase.VideoResCaseDate); //视频资源日期
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.VideoResCaseTime))
 {
 if (objVideoResCaseEN.VideoResCaseTime !=  null)
 {
 var strVideoResCaseTime = objVideoResCaseEN.VideoResCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoResCaseTime, conVideoResCase.VideoResCaseTime); //视频资源时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoResCase.VideoResCaseTime); //视频资源时间
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.VideoResCaseDateIn))
 {
 if (objVideoResCaseEN.VideoResCaseDateIn !=  null)
 {
 var strVideoResCaseDateIn = objVideoResCaseEN.VideoResCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoResCaseDateIn, conVideoResCase.VideoResCaseDateIn); //案例入库日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoResCase.VideoResCaseDateIn); //案例入库日期
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.VideoResCaseTimeIn))
 {
 if (objVideoResCaseEN.VideoResCaseTimeIn !=  null)
 {
 var strVideoResCaseTimeIn = objVideoResCaseEN.VideoResCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoResCaseTimeIn, conVideoResCase.VideoResCaseTimeIn); //案例入库时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoResCase.VideoResCaseTimeIn); //案例入库时间
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.OwnerId))
 {
 if (objVideoResCaseEN.OwnerId !=  null)
 {
 var strOwnerId = objVideoResCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOwnerId, conVideoResCase.OwnerId); //拥有者Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoResCase.OwnerId); //拥有者Id
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.IdStudyLevel))
 {
 if (objVideoResCaseEN.IdStudyLevel  ==  "")
 {
 objVideoResCaseEN.IdStudyLevel = null;
 }
 if (objVideoResCaseEN.IdStudyLevel !=  null)
 {
 var strIdStudyLevel = objVideoResCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdStudyLevel, conVideoResCase.IdStudyLevel); //id_StudyLevel
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoResCase.IdStudyLevel); //id_StudyLevel
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.IdTeachingPlan))
 {
 if (objVideoResCaseEN.IdTeachingPlan !=  null)
 {
 var strIdTeachingPlan = objVideoResCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdTeachingPlan, conVideoResCase.IdTeachingPlan); //教案流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoResCase.IdTeachingPlan); //教案流水号
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.IdDiscipline))
 {
 if (objVideoResCaseEN.IdDiscipline !=  null)
 {
 var strIdDiscipline = objVideoResCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdDiscipline, conVideoResCase.IdDiscipline); //学科流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoResCase.IdDiscipline); //学科流水号
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.BrowseCount))
 {
 if (objVideoResCaseEN.BrowseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objVideoResCaseEN.BrowseCount, conVideoResCase.BrowseCount); //浏览次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoResCase.BrowseCount); //浏览次数
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.IdSenateGaugeVersion))
 {
 if (objVideoResCaseEN.IdSenateGaugeVersion  ==  "")
 {
 objVideoResCaseEN.IdSenateGaugeVersion = null;
 }
 if (objVideoResCaseEN.IdSenateGaugeVersion !=  null)
 {
 var strIdSenateGaugeVersion = objVideoResCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdSenateGaugeVersion, conVideoResCase.IdSenateGaugeVersion); //评价量表版本流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoResCase.IdSenateGaugeVersion); //评价量表版本流水号
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.IdTeachSkill))
 {
 if (objVideoResCaseEN.IdTeachSkill !=  null)
 {
 var strIdTeachSkill = objVideoResCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdTeachSkill, conVideoResCase.IdTeachSkill); //教学技能流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoResCase.IdTeachSkill); //教学技能流水号
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.CaseLevelId))
 {
 if (objVideoResCaseEN.CaseLevelId !=  null)
 {
 var strCaseLevelId = objVideoResCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseLevelId, conVideoResCase.CaseLevelId); //课例等级Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoResCase.CaseLevelId); //课例等级Id
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.DocFile))
 {
 if (objVideoResCaseEN.DocFile !=  null)
 {
 var strDocFile = objVideoResCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDocFile, conVideoResCase.DocFile); //生成的Word文件名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoResCase.DocFile); //生成的Word文件名
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.IsNeedGeneWord))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objVideoResCaseEN.IsNeedGeneWord == true?"1":"0", conVideoResCase.IsNeedGeneWord); //是否需要生成Word
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.WordCreateDate))
 {
 if (objVideoResCaseEN.WordCreateDate !=  null)
 {
 var strWordCreateDate = objVideoResCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWordCreateDate, conVideoResCase.WordCreateDate); //Word生成日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoResCase.WordCreateDate); //Word生成日期
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.IsVisible))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objVideoResCaseEN.IsVisible == true?"1":"0", conVideoResCase.IsVisible); //是否显示
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.IsDualVideo))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objVideoResCaseEN.IsDualVideo == true?"1":"0", conVideoResCase.IsDualVideo); //是否双视频
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.IdXzCollege))
 {
 if (objVideoResCaseEN.IdXzCollege !=  null)
 {
 var strIdXzCollege = objVideoResCaseEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdXzCollege, conVideoResCase.IdXzCollege); //学院流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoResCase.IdXzCollege); //学院流水号
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.IdXzMajor))
 {
 if (objVideoResCaseEN.IdXzMajor !=  null)
 {
 var strIdXzMajor = objVideoResCaseEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdXzMajor, conVideoResCase.IdXzMajor); //专业流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoResCase.IdXzMajor); //专业流水号
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.CourseChapterId))
 {
 if (objVideoResCaseEN.CourseChapterId !=  null)
 {
 var strCourseChapterId = objVideoResCaseEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseChapterId, conVideoResCase.CourseChapterId); //课程章节ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoResCase.CourseChapterId); //课程章节ID
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.ViewCount))
 {
 if (objVideoResCaseEN.ViewCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objVideoResCaseEN.ViewCount, conVideoResCase.ViewCount); //浏览量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoResCase.ViewCount); //浏览量
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.IsShow))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objVideoResCaseEN.IsShow == true?"1":"0", conVideoResCase.IsShow); //是否启用
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.DownloadNumber))
 {
 if (objVideoResCaseEN.DownloadNumber !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objVideoResCaseEN.DownloadNumber, conVideoResCase.DownloadNumber); //下载数目
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoResCase.DownloadNumber); //下载数目
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.FileIntegration))
 {
 if (objVideoResCaseEN.FileIntegration !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objVideoResCaseEN.FileIntegration, conVideoResCase.FileIntegration); //文件积分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoResCase.FileIntegration); //文件积分
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.LikeCount))
 {
 if (objVideoResCaseEN.LikeCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objVideoResCaseEN.LikeCount, conVideoResCase.LikeCount); //资源喜欢数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoResCase.LikeCount); //资源喜欢数量
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.CollectionCount))
 {
 if (objVideoResCaseEN.CollectionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objVideoResCaseEN.CollectionCount, conVideoResCase.CollectionCount); //收藏数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoResCase.CollectionCount); //收藏数量
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.RecommendedDegreeId))
 {
 if (objVideoResCaseEN.RecommendedDegreeId !=  null)
 {
 var strRecommendedDegreeId = objVideoResCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRecommendedDegreeId, conVideoResCase.RecommendedDegreeId); //推荐度Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoResCase.RecommendedDegreeId); //推荐度Id
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.ftpFileType))
 {
 if (objVideoResCaseEN.ftpFileType !=  null)
 {
 var strftpFileType = objVideoResCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strftpFileType, conVideoResCase.ftpFileType); //ftp文件类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoResCase.ftpFileType); //ftp文件类型
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.CourseId))
 {
 if (objVideoResCaseEN.CourseId !=  null)
 {
 var strCourseId = objVideoResCaseEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, conVideoResCase.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoResCase.CourseId); //课程Id
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.VideoUrl))
 {
 if (objVideoResCaseEN.VideoUrl !=  null)
 {
 var strVideoUrl = objVideoResCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoUrl, conVideoResCase.VideoUrl); //视频Url
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoResCase.VideoUrl); //视频Url
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.VideoPath))
 {
 if (objVideoResCaseEN.VideoPath !=  null)
 {
 var strVideoPath = objVideoResCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoPath, conVideoResCase.VideoPath); //视频目录
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoResCase.VideoPath); //视频目录
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.ResErrMsg))
 {
 if (objVideoResCaseEN.ResErrMsg !=  null)
 {
 var strResErrMsg = objVideoResCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResErrMsg, conVideoResCase.ResErrMsg); //资源错误信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoResCase.ResErrMsg); //资源错误信息
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.UpdDate))
 {
 if (objVideoResCaseEN.UpdDate !=  null)
 {
 var strUpdDate = objVideoResCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conVideoResCase.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoResCase.UpdDate); //修改日期
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.UpdUserId))
 {
 if (objVideoResCaseEN.UpdUserId !=  null)
 {
 var strUpdUserId = objVideoResCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conVideoResCase.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoResCase.UpdUserId); //修改用户Id
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.Memo))
 {
 if (objVideoResCaseEN.Memo !=  null)
 {
 var strMemo = objVideoResCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conVideoResCase.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoResCase.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdVideoResCase = '{0}'", objVideoResCaseEN.IdVideoResCase); 
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
 /// <param name = "objVideoResCaseEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsVideoResCaseEN objVideoResCaseEN, string strCondition)
{
 objVideoResCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objVideoResCaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objVideoResCaseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoResCaseDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update VideoResCase Set ");
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.VideoResCaseID))
 {
 if (objVideoResCaseEN.VideoResCaseID !=  null)
 {
 var strVideoResCaseID = objVideoResCaseEN.VideoResCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoResCaseID = '{0}',", strVideoResCaseID); //视频资源案例ID
 }
 else
 {
 sbSQL.Append(" VideoResCaseID = null,"); //视频资源案例ID
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.VideoResCaseName))
 {
 if (objVideoResCaseEN.VideoResCaseName !=  null)
 {
 var strVideoResCaseName = objVideoResCaseEN.VideoResCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoResCaseName = '{0}',", strVideoResCaseName); //视频资源案例名称
 }
 else
 {
 sbSQL.Append(" VideoResCaseName = null,"); //视频资源案例名称
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.VideoResCaseTheme))
 {
 if (objVideoResCaseEN.VideoResCaseTheme !=  null)
 {
 var strVideoResCaseTheme = objVideoResCaseEN.VideoResCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoResCaseTheme = '{0}',", strVideoResCaseTheme); //视频资源案例主题词
 }
 else
 {
 sbSQL.Append(" VideoResCaseTheme = null,"); //视频资源案例主题词
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.IdVideoResCaseType))
 {
 if (objVideoResCaseEN.IdVideoResCaseType !=  null)
 {
 var strIdVideoResCaseType = objVideoResCaseEN.IdVideoResCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdVideoResCaseType = '{0}',", strIdVideoResCaseType); //视频资源类型流水号
 }
 else
 {
 sbSQL.Append(" IdVideoResCaseType = null,"); //视频资源类型流水号
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.VideoResCaseText))
 {
 if (objVideoResCaseEN.VideoResCaseText !=  null)
 {
 var strVideoResCaseText = objVideoResCaseEN.VideoResCaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoResCaseText = '{0}',", strVideoResCaseText); //案例文本内容
 }
 else
 {
 sbSQL.Append(" VideoResCaseText = null,"); //案例文本内容
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.VideoResCaseDate))
 {
 if (objVideoResCaseEN.VideoResCaseDate !=  null)
 {
 var strVideoResCaseDate = objVideoResCaseEN.VideoResCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoResCaseDate = '{0}',", strVideoResCaseDate); //视频资源日期
 }
 else
 {
 sbSQL.Append(" VideoResCaseDate = null,"); //视频资源日期
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.VideoResCaseTime))
 {
 if (objVideoResCaseEN.VideoResCaseTime !=  null)
 {
 var strVideoResCaseTime = objVideoResCaseEN.VideoResCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoResCaseTime = '{0}',", strVideoResCaseTime); //视频资源时间
 }
 else
 {
 sbSQL.Append(" VideoResCaseTime = null,"); //视频资源时间
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.VideoResCaseDateIn))
 {
 if (objVideoResCaseEN.VideoResCaseDateIn !=  null)
 {
 var strVideoResCaseDateIn = objVideoResCaseEN.VideoResCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoResCaseDateIn = '{0}',", strVideoResCaseDateIn); //案例入库日期
 }
 else
 {
 sbSQL.Append(" VideoResCaseDateIn = null,"); //案例入库日期
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.VideoResCaseTimeIn))
 {
 if (objVideoResCaseEN.VideoResCaseTimeIn !=  null)
 {
 var strVideoResCaseTimeIn = objVideoResCaseEN.VideoResCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoResCaseTimeIn = '{0}',", strVideoResCaseTimeIn); //案例入库时间
 }
 else
 {
 sbSQL.Append(" VideoResCaseTimeIn = null,"); //案例入库时间
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.OwnerId))
 {
 if (objVideoResCaseEN.OwnerId !=  null)
 {
 var strOwnerId = objVideoResCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OwnerId = '{0}',", strOwnerId); //拥有者Id
 }
 else
 {
 sbSQL.Append(" OwnerId = null,"); //拥有者Id
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.IdStudyLevel))
 {
 if (objVideoResCaseEN.IdStudyLevel  ==  "")
 {
 objVideoResCaseEN.IdStudyLevel = null;
 }
 if (objVideoResCaseEN.IdStudyLevel !=  null)
 {
 var strIdStudyLevel = objVideoResCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdStudyLevel = '{0}',", strIdStudyLevel); //id_StudyLevel
 }
 else
 {
 sbSQL.Append(" IdStudyLevel = null,"); //id_StudyLevel
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.IdTeachingPlan))
 {
 if (objVideoResCaseEN.IdTeachingPlan !=  null)
 {
 var strIdTeachingPlan = objVideoResCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdTeachingPlan = '{0}',", strIdTeachingPlan); //教案流水号
 }
 else
 {
 sbSQL.Append(" IdTeachingPlan = null,"); //教案流水号
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.IdDiscipline))
 {
 if (objVideoResCaseEN.IdDiscipline !=  null)
 {
 var strIdDiscipline = objVideoResCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdDiscipline = '{0}',", strIdDiscipline); //学科流水号
 }
 else
 {
 sbSQL.Append(" IdDiscipline = null,"); //学科流水号
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.BrowseCount))
 {
 sbSQL.AppendFormat(" BrowseCount = {0},", objVideoResCaseEN.BrowseCount); //浏览次数
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.IdSenateGaugeVersion))
 {
 if (objVideoResCaseEN.IdSenateGaugeVersion  ==  "")
 {
 objVideoResCaseEN.IdSenateGaugeVersion = null;
 }
 if (objVideoResCaseEN.IdSenateGaugeVersion !=  null)
 {
 var strIdSenateGaugeVersion = objVideoResCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdSenateGaugeVersion = '{0}',", strIdSenateGaugeVersion); //评价量表版本流水号
 }
 else
 {
 sbSQL.Append(" IdSenateGaugeVersion = null,"); //评价量表版本流水号
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.IdTeachSkill))
 {
 if (objVideoResCaseEN.IdTeachSkill !=  null)
 {
 var strIdTeachSkill = objVideoResCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdTeachSkill = '{0}',", strIdTeachSkill); //教学技能流水号
 }
 else
 {
 sbSQL.Append(" IdTeachSkill = null,"); //教学技能流水号
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.CaseLevelId))
 {
 if (objVideoResCaseEN.CaseLevelId !=  null)
 {
 var strCaseLevelId = objVideoResCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseLevelId = '{0}',", strCaseLevelId); //课例等级Id
 }
 else
 {
 sbSQL.Append(" CaseLevelId = null,"); //课例等级Id
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.DocFile))
 {
 if (objVideoResCaseEN.DocFile !=  null)
 {
 var strDocFile = objVideoResCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DocFile = '{0}',", strDocFile); //生成的Word文件名
 }
 else
 {
 sbSQL.Append(" DocFile = null,"); //生成的Word文件名
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.IsNeedGeneWord))
 {
 sbSQL.AppendFormat(" IsNeedGeneWord = '{0}',", objVideoResCaseEN.IsNeedGeneWord == true?"1":"0"); //是否需要生成Word
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.WordCreateDate))
 {
 if (objVideoResCaseEN.WordCreateDate !=  null)
 {
 var strWordCreateDate = objVideoResCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WordCreateDate = '{0}',", strWordCreateDate); //Word生成日期
 }
 else
 {
 sbSQL.Append(" WordCreateDate = null,"); //Word生成日期
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.IsVisible))
 {
 sbSQL.AppendFormat(" IsVisible = '{0}',", objVideoResCaseEN.IsVisible == true?"1":"0"); //是否显示
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.IsDualVideo))
 {
 sbSQL.AppendFormat(" IsDualVideo = '{0}',", objVideoResCaseEN.IsDualVideo == true?"1":"0"); //是否双视频
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.IdXzCollege))
 {
 if (objVideoResCaseEN.IdXzCollege !=  null)
 {
 var strIdXzCollege = objVideoResCaseEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdXzCollege = '{0}',", strIdXzCollege); //学院流水号
 }
 else
 {
 sbSQL.Append(" IdXzCollege = null,"); //学院流水号
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.IdXzMajor))
 {
 if (objVideoResCaseEN.IdXzMajor !=  null)
 {
 var strIdXzMajor = objVideoResCaseEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdXzMajor = '{0}',", strIdXzMajor); //专业流水号
 }
 else
 {
 sbSQL.Append(" IdXzMajor = null,"); //专业流水号
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.CourseChapterId))
 {
 if (objVideoResCaseEN.CourseChapterId !=  null)
 {
 var strCourseChapterId = objVideoResCaseEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseChapterId = '{0}',", strCourseChapterId); //课程章节ID
 }
 else
 {
 sbSQL.Append(" CourseChapterId = null,"); //课程章节ID
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.ViewCount))
 {
 sbSQL.AppendFormat(" ViewCount = {0},", objVideoResCaseEN.ViewCount); //浏览量
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.IsShow))
 {
 sbSQL.AppendFormat(" IsShow = '{0}',", objVideoResCaseEN.IsShow == true?"1":"0"); //是否启用
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.DownloadNumber))
 {
 sbSQL.AppendFormat(" DownloadNumber = {0},", objVideoResCaseEN.DownloadNumber); //下载数目
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.FileIntegration))
 {
 sbSQL.AppendFormat(" FileIntegration = {0},", objVideoResCaseEN.FileIntegration); //文件积分
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.LikeCount))
 {
 sbSQL.AppendFormat(" LikeCount = {0},", objVideoResCaseEN.LikeCount); //资源喜欢数量
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.CollectionCount))
 {
 sbSQL.AppendFormat(" CollectionCount = {0},", objVideoResCaseEN.CollectionCount); //收藏数量
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.RecommendedDegreeId))
 {
 if (objVideoResCaseEN.RecommendedDegreeId !=  null)
 {
 var strRecommendedDegreeId = objVideoResCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RecommendedDegreeId = '{0}',", strRecommendedDegreeId); //推荐度Id
 }
 else
 {
 sbSQL.Append(" RecommendedDegreeId = null,"); //推荐度Id
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.ftpFileType))
 {
 if (objVideoResCaseEN.ftpFileType !=  null)
 {
 var strftpFileType = objVideoResCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ftpFileType = '{0}',", strftpFileType); //ftp文件类型
 }
 else
 {
 sbSQL.Append(" ftpFileType = null,"); //ftp文件类型
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.CourseId))
 {
 if (objVideoResCaseEN.CourseId !=  null)
 {
 var strCourseId = objVideoResCaseEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.VideoUrl))
 {
 if (objVideoResCaseEN.VideoUrl !=  null)
 {
 var strVideoUrl = objVideoResCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoUrl = '{0}',", strVideoUrl); //视频Url
 }
 else
 {
 sbSQL.Append(" VideoUrl = null,"); //视频Url
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.VideoPath))
 {
 if (objVideoResCaseEN.VideoPath !=  null)
 {
 var strVideoPath = objVideoResCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoPath = '{0}',", strVideoPath); //视频目录
 }
 else
 {
 sbSQL.Append(" VideoPath = null,"); //视频目录
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.ResErrMsg))
 {
 if (objVideoResCaseEN.ResErrMsg !=  null)
 {
 var strResErrMsg = objVideoResCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResErrMsg = '{0}',", strResErrMsg); //资源错误信息
 }
 else
 {
 sbSQL.Append(" ResErrMsg = null,"); //资源错误信息
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.UpdDate))
 {
 if (objVideoResCaseEN.UpdDate !=  null)
 {
 var strUpdDate = objVideoResCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.UpdUserId))
 {
 if (objVideoResCaseEN.UpdUserId !=  null)
 {
 var strUpdUserId = objVideoResCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.Memo))
 {
 if (objVideoResCaseEN.Memo !=  null)
 {
 var strMemo = objVideoResCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objVideoResCaseEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsVideoResCaseEN objVideoResCaseEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objVideoResCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objVideoResCaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objVideoResCaseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoResCaseDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update VideoResCase Set ");
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.VideoResCaseID))
 {
 if (objVideoResCaseEN.VideoResCaseID !=  null)
 {
 var strVideoResCaseID = objVideoResCaseEN.VideoResCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoResCaseID = '{0}',", strVideoResCaseID); //视频资源案例ID
 }
 else
 {
 sbSQL.Append(" VideoResCaseID = null,"); //视频资源案例ID
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.VideoResCaseName))
 {
 if (objVideoResCaseEN.VideoResCaseName !=  null)
 {
 var strVideoResCaseName = objVideoResCaseEN.VideoResCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoResCaseName = '{0}',", strVideoResCaseName); //视频资源案例名称
 }
 else
 {
 sbSQL.Append(" VideoResCaseName = null,"); //视频资源案例名称
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.VideoResCaseTheme))
 {
 if (objVideoResCaseEN.VideoResCaseTheme !=  null)
 {
 var strVideoResCaseTheme = objVideoResCaseEN.VideoResCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoResCaseTheme = '{0}',", strVideoResCaseTheme); //视频资源案例主题词
 }
 else
 {
 sbSQL.Append(" VideoResCaseTheme = null,"); //视频资源案例主题词
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.IdVideoResCaseType))
 {
 if (objVideoResCaseEN.IdVideoResCaseType !=  null)
 {
 var strIdVideoResCaseType = objVideoResCaseEN.IdVideoResCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdVideoResCaseType = '{0}',", strIdVideoResCaseType); //视频资源类型流水号
 }
 else
 {
 sbSQL.Append(" IdVideoResCaseType = null,"); //视频资源类型流水号
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.VideoResCaseText))
 {
 if (objVideoResCaseEN.VideoResCaseText !=  null)
 {
 var strVideoResCaseText = objVideoResCaseEN.VideoResCaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoResCaseText = '{0}',", strVideoResCaseText); //案例文本内容
 }
 else
 {
 sbSQL.Append(" VideoResCaseText = null,"); //案例文本内容
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.VideoResCaseDate))
 {
 if (objVideoResCaseEN.VideoResCaseDate !=  null)
 {
 var strVideoResCaseDate = objVideoResCaseEN.VideoResCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoResCaseDate = '{0}',", strVideoResCaseDate); //视频资源日期
 }
 else
 {
 sbSQL.Append(" VideoResCaseDate = null,"); //视频资源日期
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.VideoResCaseTime))
 {
 if (objVideoResCaseEN.VideoResCaseTime !=  null)
 {
 var strVideoResCaseTime = objVideoResCaseEN.VideoResCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoResCaseTime = '{0}',", strVideoResCaseTime); //视频资源时间
 }
 else
 {
 sbSQL.Append(" VideoResCaseTime = null,"); //视频资源时间
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.VideoResCaseDateIn))
 {
 if (objVideoResCaseEN.VideoResCaseDateIn !=  null)
 {
 var strVideoResCaseDateIn = objVideoResCaseEN.VideoResCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoResCaseDateIn = '{0}',", strVideoResCaseDateIn); //案例入库日期
 }
 else
 {
 sbSQL.Append(" VideoResCaseDateIn = null,"); //案例入库日期
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.VideoResCaseTimeIn))
 {
 if (objVideoResCaseEN.VideoResCaseTimeIn !=  null)
 {
 var strVideoResCaseTimeIn = objVideoResCaseEN.VideoResCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoResCaseTimeIn = '{0}',", strVideoResCaseTimeIn); //案例入库时间
 }
 else
 {
 sbSQL.Append(" VideoResCaseTimeIn = null,"); //案例入库时间
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.OwnerId))
 {
 if (objVideoResCaseEN.OwnerId !=  null)
 {
 var strOwnerId = objVideoResCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OwnerId = '{0}',", strOwnerId); //拥有者Id
 }
 else
 {
 sbSQL.Append(" OwnerId = null,"); //拥有者Id
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.IdStudyLevel))
 {
 if (objVideoResCaseEN.IdStudyLevel  ==  "")
 {
 objVideoResCaseEN.IdStudyLevel = null;
 }
 if (objVideoResCaseEN.IdStudyLevel !=  null)
 {
 var strIdStudyLevel = objVideoResCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdStudyLevel = '{0}',", strIdStudyLevel); //id_StudyLevel
 }
 else
 {
 sbSQL.Append(" IdStudyLevel = null,"); //id_StudyLevel
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.IdTeachingPlan))
 {
 if (objVideoResCaseEN.IdTeachingPlan !=  null)
 {
 var strIdTeachingPlan = objVideoResCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdTeachingPlan = '{0}',", strIdTeachingPlan); //教案流水号
 }
 else
 {
 sbSQL.Append(" IdTeachingPlan = null,"); //教案流水号
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.IdDiscipline))
 {
 if (objVideoResCaseEN.IdDiscipline !=  null)
 {
 var strIdDiscipline = objVideoResCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdDiscipline = '{0}',", strIdDiscipline); //学科流水号
 }
 else
 {
 sbSQL.Append(" IdDiscipline = null,"); //学科流水号
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.BrowseCount))
 {
 sbSQL.AppendFormat(" BrowseCount = {0},", objVideoResCaseEN.BrowseCount); //浏览次数
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.IdSenateGaugeVersion))
 {
 if (objVideoResCaseEN.IdSenateGaugeVersion  ==  "")
 {
 objVideoResCaseEN.IdSenateGaugeVersion = null;
 }
 if (objVideoResCaseEN.IdSenateGaugeVersion !=  null)
 {
 var strIdSenateGaugeVersion = objVideoResCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdSenateGaugeVersion = '{0}',", strIdSenateGaugeVersion); //评价量表版本流水号
 }
 else
 {
 sbSQL.Append(" IdSenateGaugeVersion = null,"); //评价量表版本流水号
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.IdTeachSkill))
 {
 if (objVideoResCaseEN.IdTeachSkill !=  null)
 {
 var strIdTeachSkill = objVideoResCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdTeachSkill = '{0}',", strIdTeachSkill); //教学技能流水号
 }
 else
 {
 sbSQL.Append(" IdTeachSkill = null,"); //教学技能流水号
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.CaseLevelId))
 {
 if (objVideoResCaseEN.CaseLevelId !=  null)
 {
 var strCaseLevelId = objVideoResCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseLevelId = '{0}',", strCaseLevelId); //课例等级Id
 }
 else
 {
 sbSQL.Append(" CaseLevelId = null,"); //课例等级Id
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.DocFile))
 {
 if (objVideoResCaseEN.DocFile !=  null)
 {
 var strDocFile = objVideoResCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DocFile = '{0}',", strDocFile); //生成的Word文件名
 }
 else
 {
 sbSQL.Append(" DocFile = null,"); //生成的Word文件名
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.IsNeedGeneWord))
 {
 sbSQL.AppendFormat(" IsNeedGeneWord = '{0}',", objVideoResCaseEN.IsNeedGeneWord == true?"1":"0"); //是否需要生成Word
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.WordCreateDate))
 {
 if (objVideoResCaseEN.WordCreateDate !=  null)
 {
 var strWordCreateDate = objVideoResCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WordCreateDate = '{0}',", strWordCreateDate); //Word生成日期
 }
 else
 {
 sbSQL.Append(" WordCreateDate = null,"); //Word生成日期
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.IsVisible))
 {
 sbSQL.AppendFormat(" IsVisible = '{0}',", objVideoResCaseEN.IsVisible == true?"1":"0"); //是否显示
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.IsDualVideo))
 {
 sbSQL.AppendFormat(" IsDualVideo = '{0}',", objVideoResCaseEN.IsDualVideo == true?"1":"0"); //是否双视频
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.IdXzCollege))
 {
 if (objVideoResCaseEN.IdXzCollege !=  null)
 {
 var strIdXzCollege = objVideoResCaseEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdXzCollege = '{0}',", strIdXzCollege); //学院流水号
 }
 else
 {
 sbSQL.Append(" IdXzCollege = null,"); //学院流水号
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.IdXzMajor))
 {
 if (objVideoResCaseEN.IdXzMajor !=  null)
 {
 var strIdXzMajor = objVideoResCaseEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdXzMajor = '{0}',", strIdXzMajor); //专业流水号
 }
 else
 {
 sbSQL.Append(" IdXzMajor = null,"); //专业流水号
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.CourseChapterId))
 {
 if (objVideoResCaseEN.CourseChapterId !=  null)
 {
 var strCourseChapterId = objVideoResCaseEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseChapterId = '{0}',", strCourseChapterId); //课程章节ID
 }
 else
 {
 sbSQL.Append(" CourseChapterId = null,"); //课程章节ID
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.ViewCount))
 {
 sbSQL.AppendFormat(" ViewCount = {0},", objVideoResCaseEN.ViewCount); //浏览量
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.IsShow))
 {
 sbSQL.AppendFormat(" IsShow = '{0}',", objVideoResCaseEN.IsShow == true?"1":"0"); //是否启用
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.DownloadNumber))
 {
 sbSQL.AppendFormat(" DownloadNumber = {0},", objVideoResCaseEN.DownloadNumber); //下载数目
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.FileIntegration))
 {
 sbSQL.AppendFormat(" FileIntegration = {0},", objVideoResCaseEN.FileIntegration); //文件积分
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.LikeCount))
 {
 sbSQL.AppendFormat(" LikeCount = {0},", objVideoResCaseEN.LikeCount); //资源喜欢数量
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.CollectionCount))
 {
 sbSQL.AppendFormat(" CollectionCount = {0},", objVideoResCaseEN.CollectionCount); //收藏数量
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.RecommendedDegreeId))
 {
 if (objVideoResCaseEN.RecommendedDegreeId !=  null)
 {
 var strRecommendedDegreeId = objVideoResCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RecommendedDegreeId = '{0}',", strRecommendedDegreeId); //推荐度Id
 }
 else
 {
 sbSQL.Append(" RecommendedDegreeId = null,"); //推荐度Id
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.ftpFileType))
 {
 if (objVideoResCaseEN.ftpFileType !=  null)
 {
 var strftpFileType = objVideoResCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ftpFileType = '{0}',", strftpFileType); //ftp文件类型
 }
 else
 {
 sbSQL.Append(" ftpFileType = null,"); //ftp文件类型
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.CourseId))
 {
 if (objVideoResCaseEN.CourseId !=  null)
 {
 var strCourseId = objVideoResCaseEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.VideoUrl))
 {
 if (objVideoResCaseEN.VideoUrl !=  null)
 {
 var strVideoUrl = objVideoResCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoUrl = '{0}',", strVideoUrl); //视频Url
 }
 else
 {
 sbSQL.Append(" VideoUrl = null,"); //视频Url
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.VideoPath))
 {
 if (objVideoResCaseEN.VideoPath !=  null)
 {
 var strVideoPath = objVideoResCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoPath = '{0}',", strVideoPath); //视频目录
 }
 else
 {
 sbSQL.Append(" VideoPath = null,"); //视频目录
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.ResErrMsg))
 {
 if (objVideoResCaseEN.ResErrMsg !=  null)
 {
 var strResErrMsg = objVideoResCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResErrMsg = '{0}',", strResErrMsg); //资源错误信息
 }
 else
 {
 sbSQL.Append(" ResErrMsg = null,"); //资源错误信息
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.UpdDate))
 {
 if (objVideoResCaseEN.UpdDate !=  null)
 {
 var strUpdDate = objVideoResCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.UpdUserId))
 {
 if (objVideoResCaseEN.UpdUserId !=  null)
 {
 var strUpdUserId = objVideoResCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.Memo))
 {
 if (objVideoResCaseEN.Memo !=  null)
 {
 var strMemo = objVideoResCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objVideoResCaseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsVideoResCaseEN objVideoResCaseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objVideoResCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objVideoResCaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objVideoResCaseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoResCaseDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update VideoResCase Set ");
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.VideoResCaseID))
 {
 if (objVideoResCaseEN.VideoResCaseID !=  null)
 {
 var strVideoResCaseID = objVideoResCaseEN.VideoResCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoResCaseID, conVideoResCase.VideoResCaseID); //视频资源案例ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoResCase.VideoResCaseID); //视频资源案例ID
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.VideoResCaseName))
 {
 if (objVideoResCaseEN.VideoResCaseName !=  null)
 {
 var strVideoResCaseName = objVideoResCaseEN.VideoResCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoResCaseName, conVideoResCase.VideoResCaseName); //视频资源案例名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoResCase.VideoResCaseName); //视频资源案例名称
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.VideoResCaseTheme))
 {
 if (objVideoResCaseEN.VideoResCaseTheme !=  null)
 {
 var strVideoResCaseTheme = objVideoResCaseEN.VideoResCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoResCaseTheme, conVideoResCase.VideoResCaseTheme); //视频资源案例主题词
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoResCase.VideoResCaseTheme); //视频资源案例主题词
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.IdVideoResCaseType))
 {
 if (objVideoResCaseEN.IdVideoResCaseType !=  null)
 {
 var strIdVideoResCaseType = objVideoResCaseEN.IdVideoResCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdVideoResCaseType, conVideoResCase.IdVideoResCaseType); //视频资源类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoResCase.IdVideoResCaseType); //视频资源类型流水号
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.VideoResCaseText))
 {
 if (objVideoResCaseEN.VideoResCaseText !=  null)
 {
 var strVideoResCaseText = objVideoResCaseEN.VideoResCaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoResCaseText, conVideoResCase.VideoResCaseText); //案例文本内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoResCase.VideoResCaseText); //案例文本内容
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.VideoResCaseDate))
 {
 if (objVideoResCaseEN.VideoResCaseDate !=  null)
 {
 var strVideoResCaseDate = objVideoResCaseEN.VideoResCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoResCaseDate, conVideoResCase.VideoResCaseDate); //视频资源日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoResCase.VideoResCaseDate); //视频资源日期
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.VideoResCaseTime))
 {
 if (objVideoResCaseEN.VideoResCaseTime !=  null)
 {
 var strVideoResCaseTime = objVideoResCaseEN.VideoResCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoResCaseTime, conVideoResCase.VideoResCaseTime); //视频资源时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoResCase.VideoResCaseTime); //视频资源时间
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.VideoResCaseDateIn))
 {
 if (objVideoResCaseEN.VideoResCaseDateIn !=  null)
 {
 var strVideoResCaseDateIn = objVideoResCaseEN.VideoResCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoResCaseDateIn, conVideoResCase.VideoResCaseDateIn); //案例入库日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoResCase.VideoResCaseDateIn); //案例入库日期
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.VideoResCaseTimeIn))
 {
 if (objVideoResCaseEN.VideoResCaseTimeIn !=  null)
 {
 var strVideoResCaseTimeIn = objVideoResCaseEN.VideoResCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoResCaseTimeIn, conVideoResCase.VideoResCaseTimeIn); //案例入库时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoResCase.VideoResCaseTimeIn); //案例入库时间
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.OwnerId))
 {
 if (objVideoResCaseEN.OwnerId !=  null)
 {
 var strOwnerId = objVideoResCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOwnerId, conVideoResCase.OwnerId); //拥有者Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoResCase.OwnerId); //拥有者Id
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.IdStudyLevel))
 {
 if (objVideoResCaseEN.IdStudyLevel  ==  "")
 {
 objVideoResCaseEN.IdStudyLevel = null;
 }
 if (objVideoResCaseEN.IdStudyLevel !=  null)
 {
 var strIdStudyLevel = objVideoResCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdStudyLevel, conVideoResCase.IdStudyLevel); //id_StudyLevel
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoResCase.IdStudyLevel); //id_StudyLevel
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.IdTeachingPlan))
 {
 if (objVideoResCaseEN.IdTeachingPlan !=  null)
 {
 var strIdTeachingPlan = objVideoResCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdTeachingPlan, conVideoResCase.IdTeachingPlan); //教案流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoResCase.IdTeachingPlan); //教案流水号
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.IdDiscipline))
 {
 if (objVideoResCaseEN.IdDiscipline !=  null)
 {
 var strIdDiscipline = objVideoResCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdDiscipline, conVideoResCase.IdDiscipline); //学科流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoResCase.IdDiscipline); //学科流水号
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.BrowseCount))
 {
 if (objVideoResCaseEN.BrowseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objVideoResCaseEN.BrowseCount, conVideoResCase.BrowseCount); //浏览次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoResCase.BrowseCount); //浏览次数
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.IdSenateGaugeVersion))
 {
 if (objVideoResCaseEN.IdSenateGaugeVersion  ==  "")
 {
 objVideoResCaseEN.IdSenateGaugeVersion = null;
 }
 if (objVideoResCaseEN.IdSenateGaugeVersion !=  null)
 {
 var strIdSenateGaugeVersion = objVideoResCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdSenateGaugeVersion, conVideoResCase.IdSenateGaugeVersion); //评价量表版本流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoResCase.IdSenateGaugeVersion); //评价量表版本流水号
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.IdTeachSkill))
 {
 if (objVideoResCaseEN.IdTeachSkill !=  null)
 {
 var strIdTeachSkill = objVideoResCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdTeachSkill, conVideoResCase.IdTeachSkill); //教学技能流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoResCase.IdTeachSkill); //教学技能流水号
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.CaseLevelId))
 {
 if (objVideoResCaseEN.CaseLevelId !=  null)
 {
 var strCaseLevelId = objVideoResCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseLevelId, conVideoResCase.CaseLevelId); //课例等级Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoResCase.CaseLevelId); //课例等级Id
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.DocFile))
 {
 if (objVideoResCaseEN.DocFile !=  null)
 {
 var strDocFile = objVideoResCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDocFile, conVideoResCase.DocFile); //生成的Word文件名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoResCase.DocFile); //生成的Word文件名
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.IsNeedGeneWord))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objVideoResCaseEN.IsNeedGeneWord == true?"1":"0", conVideoResCase.IsNeedGeneWord); //是否需要生成Word
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.WordCreateDate))
 {
 if (objVideoResCaseEN.WordCreateDate !=  null)
 {
 var strWordCreateDate = objVideoResCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWordCreateDate, conVideoResCase.WordCreateDate); //Word生成日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoResCase.WordCreateDate); //Word生成日期
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.IsVisible))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objVideoResCaseEN.IsVisible == true?"1":"0", conVideoResCase.IsVisible); //是否显示
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.IsDualVideo))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objVideoResCaseEN.IsDualVideo == true?"1":"0", conVideoResCase.IsDualVideo); //是否双视频
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.IdXzCollege))
 {
 if (objVideoResCaseEN.IdXzCollege !=  null)
 {
 var strIdXzCollege = objVideoResCaseEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdXzCollege, conVideoResCase.IdXzCollege); //学院流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoResCase.IdXzCollege); //学院流水号
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.IdXzMajor))
 {
 if (objVideoResCaseEN.IdXzMajor !=  null)
 {
 var strIdXzMajor = objVideoResCaseEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdXzMajor, conVideoResCase.IdXzMajor); //专业流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoResCase.IdXzMajor); //专业流水号
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.CourseChapterId))
 {
 if (objVideoResCaseEN.CourseChapterId !=  null)
 {
 var strCourseChapterId = objVideoResCaseEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseChapterId, conVideoResCase.CourseChapterId); //课程章节ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoResCase.CourseChapterId); //课程章节ID
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.ViewCount))
 {
 if (objVideoResCaseEN.ViewCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objVideoResCaseEN.ViewCount, conVideoResCase.ViewCount); //浏览量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoResCase.ViewCount); //浏览量
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.IsShow))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objVideoResCaseEN.IsShow == true?"1":"0", conVideoResCase.IsShow); //是否启用
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.DownloadNumber))
 {
 if (objVideoResCaseEN.DownloadNumber !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objVideoResCaseEN.DownloadNumber, conVideoResCase.DownloadNumber); //下载数目
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoResCase.DownloadNumber); //下载数目
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.FileIntegration))
 {
 if (objVideoResCaseEN.FileIntegration !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objVideoResCaseEN.FileIntegration, conVideoResCase.FileIntegration); //文件积分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoResCase.FileIntegration); //文件积分
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.LikeCount))
 {
 if (objVideoResCaseEN.LikeCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objVideoResCaseEN.LikeCount, conVideoResCase.LikeCount); //资源喜欢数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoResCase.LikeCount); //资源喜欢数量
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.CollectionCount))
 {
 if (objVideoResCaseEN.CollectionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objVideoResCaseEN.CollectionCount, conVideoResCase.CollectionCount); //收藏数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoResCase.CollectionCount); //收藏数量
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.RecommendedDegreeId))
 {
 if (objVideoResCaseEN.RecommendedDegreeId !=  null)
 {
 var strRecommendedDegreeId = objVideoResCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRecommendedDegreeId, conVideoResCase.RecommendedDegreeId); //推荐度Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoResCase.RecommendedDegreeId); //推荐度Id
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.ftpFileType))
 {
 if (objVideoResCaseEN.ftpFileType !=  null)
 {
 var strftpFileType = objVideoResCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strftpFileType, conVideoResCase.ftpFileType); //ftp文件类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoResCase.ftpFileType); //ftp文件类型
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.CourseId))
 {
 if (objVideoResCaseEN.CourseId !=  null)
 {
 var strCourseId = objVideoResCaseEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, conVideoResCase.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoResCase.CourseId); //课程Id
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.VideoUrl))
 {
 if (objVideoResCaseEN.VideoUrl !=  null)
 {
 var strVideoUrl = objVideoResCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoUrl, conVideoResCase.VideoUrl); //视频Url
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoResCase.VideoUrl); //视频Url
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.VideoPath))
 {
 if (objVideoResCaseEN.VideoPath !=  null)
 {
 var strVideoPath = objVideoResCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoPath, conVideoResCase.VideoPath); //视频目录
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoResCase.VideoPath); //视频目录
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.ResErrMsg))
 {
 if (objVideoResCaseEN.ResErrMsg !=  null)
 {
 var strResErrMsg = objVideoResCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResErrMsg, conVideoResCase.ResErrMsg); //资源错误信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoResCase.ResErrMsg); //资源错误信息
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.UpdDate))
 {
 if (objVideoResCaseEN.UpdDate !=  null)
 {
 var strUpdDate = objVideoResCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conVideoResCase.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoResCase.UpdDate); //修改日期
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.UpdUserId))
 {
 if (objVideoResCaseEN.UpdUserId !=  null)
 {
 var strUpdUserId = objVideoResCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conVideoResCase.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoResCase.UpdUserId); //修改用户Id
 }
 }
 
 if (objVideoResCaseEN.IsUpdated(conVideoResCase.Memo))
 {
 if (objVideoResCaseEN.Memo !=  null)
 {
 var strMemo = objVideoResCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conVideoResCase.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoResCase.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdVideoResCase = '{0}'", objVideoResCaseEN.IdVideoResCase); 
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
 /// <param name = "strIdVideoResCase">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strIdVideoResCase) 
{
CheckPrimaryKey(strIdVideoResCase);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoResCaseDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strIdVideoResCase,
};
 objSQL.ExecSP("VideoResCase_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strIdVideoResCase">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strIdVideoResCase, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strIdVideoResCase);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoResCaseDA.GetSpecSQLObj();
//删除VideoResCase本表中与当前对象有关的记录
strSQL = strSQL + "Delete from VideoResCase where IdVideoResCase = " + "'"+ strIdVideoResCase+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelVideoResCase(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoResCaseDA.GetSpecSQLObj();
string strSQL;
string strKeyList;
if (lstKey.Count  == 0) return 0;
strKeyList = "";
for (int i = 0; i<lstKey.Count; i++)
{
if (i == 0) strKeyList = strKeyList + "'" + lstKey[i].ToString() + "'";
else strKeyList +=  "," + "'" + lstKey[i].ToString() + "'";
}
strSQL = "";
//删除VideoResCase本表中与当前对象有关的记录
strSQL = strSQL + "Delete from VideoResCase where IdVideoResCase in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strIdVideoResCase">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strIdVideoResCase) 
{
CheckPrimaryKey(strIdVideoResCase);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoResCaseDA.GetSpecSQLObj();
//删除VideoResCase本表中与当前对象有关的记录
strSQL = strSQL + "Delete from VideoResCase where IdVideoResCase = " + "'"+ strIdVideoResCase+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelVideoResCase(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsVideoResCaseDA: DelVideoResCase)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoResCaseDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from VideoResCase where " + strCondition ;
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
public bool DelVideoResCaseWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsVideoResCaseDA: DelVideoResCaseWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoResCaseDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from VideoResCase where " + strCondition ;
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
 /// <param name = "objVideoResCaseENS">源对象</param>
 /// <param name = "objVideoResCaseENT">目标对象</param>
public void CopyTo(clsVideoResCaseEN objVideoResCaseENS, clsVideoResCaseEN objVideoResCaseENT)
{
objVideoResCaseENT.IdVideoResCase = objVideoResCaseENS.IdVideoResCase; //视频资源案例流水号
objVideoResCaseENT.VideoResCaseID = objVideoResCaseENS.VideoResCaseID; //视频资源案例ID
objVideoResCaseENT.VideoResCaseName = objVideoResCaseENS.VideoResCaseName; //视频资源案例名称
objVideoResCaseENT.VideoResCaseTheme = objVideoResCaseENS.VideoResCaseTheme; //视频资源案例主题词
objVideoResCaseENT.IdVideoResCaseType = objVideoResCaseENS.IdVideoResCaseType; //视频资源类型流水号
objVideoResCaseENT.VideoResCaseText = objVideoResCaseENS.VideoResCaseText; //案例文本内容
objVideoResCaseENT.VideoResCaseDate = objVideoResCaseENS.VideoResCaseDate; //视频资源日期
objVideoResCaseENT.VideoResCaseTime = objVideoResCaseENS.VideoResCaseTime; //视频资源时间
objVideoResCaseENT.VideoResCaseDateIn = objVideoResCaseENS.VideoResCaseDateIn; //案例入库日期
objVideoResCaseENT.VideoResCaseTimeIn = objVideoResCaseENS.VideoResCaseTimeIn; //案例入库时间
objVideoResCaseENT.OwnerId = objVideoResCaseENS.OwnerId; //拥有者Id
objVideoResCaseENT.IdStudyLevel = objVideoResCaseENS.IdStudyLevel; //id_StudyLevel
objVideoResCaseENT.IdTeachingPlan = objVideoResCaseENS.IdTeachingPlan; //教案流水号
objVideoResCaseENT.IdDiscipline = objVideoResCaseENS.IdDiscipline; //学科流水号
objVideoResCaseENT.BrowseCount = objVideoResCaseENS.BrowseCount; //浏览次数
objVideoResCaseENT.IdSenateGaugeVersion = objVideoResCaseENS.IdSenateGaugeVersion; //评价量表版本流水号
objVideoResCaseENT.IdTeachSkill = objVideoResCaseENS.IdTeachSkill; //教学技能流水号
objVideoResCaseENT.CaseLevelId = objVideoResCaseENS.CaseLevelId; //课例等级Id
objVideoResCaseENT.DocFile = objVideoResCaseENS.DocFile; //生成的Word文件名
objVideoResCaseENT.IsNeedGeneWord = objVideoResCaseENS.IsNeedGeneWord; //是否需要生成Word
objVideoResCaseENT.WordCreateDate = objVideoResCaseENS.WordCreateDate; //Word生成日期
objVideoResCaseENT.IsVisible = objVideoResCaseENS.IsVisible; //是否显示
objVideoResCaseENT.IsDualVideo = objVideoResCaseENS.IsDualVideo; //是否双视频
objVideoResCaseENT.IdXzCollege = objVideoResCaseENS.IdXzCollege; //学院流水号
objVideoResCaseENT.IdXzMajor = objVideoResCaseENS.IdXzMajor; //专业流水号
objVideoResCaseENT.CourseChapterId = objVideoResCaseENS.CourseChapterId; //课程章节ID
objVideoResCaseENT.ViewCount = objVideoResCaseENS.ViewCount; //浏览量
objVideoResCaseENT.IsShow = objVideoResCaseENS.IsShow; //是否启用
objVideoResCaseENT.DownloadNumber = objVideoResCaseENS.DownloadNumber; //下载数目
objVideoResCaseENT.FileIntegration = objVideoResCaseENS.FileIntegration; //文件积分
objVideoResCaseENT.LikeCount = objVideoResCaseENS.LikeCount; //资源喜欢数量
objVideoResCaseENT.CollectionCount = objVideoResCaseENS.CollectionCount; //收藏数量
objVideoResCaseENT.RecommendedDegreeId = objVideoResCaseENS.RecommendedDegreeId; //推荐度Id
objVideoResCaseENT.ftpFileType = objVideoResCaseENS.ftpFileType; //ftp文件类型
objVideoResCaseENT.CourseId = objVideoResCaseENS.CourseId; //课程Id
objVideoResCaseENT.VideoUrl = objVideoResCaseENS.VideoUrl; //视频Url
objVideoResCaseENT.VideoPath = objVideoResCaseENS.VideoPath; //视频目录
objVideoResCaseENT.ResErrMsg = objVideoResCaseENS.ResErrMsg; //资源错误信息
objVideoResCaseENT.UpdDate = objVideoResCaseENS.UpdDate; //修改日期
objVideoResCaseENT.UpdUserId = objVideoResCaseENS.UpdUserId; //修改用户Id
objVideoResCaseENT.Memo = objVideoResCaseENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsVideoResCaseEN objVideoResCaseEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objVideoResCaseEN.VideoResCaseID, conVideoResCase.VideoResCaseID);
clsCheckSql.CheckFieldNotNull(objVideoResCaseEN.VideoResCaseName, conVideoResCase.VideoResCaseName);
clsCheckSql.CheckFieldNotNull(objVideoResCaseEN.IdVideoResCaseType, conVideoResCase.IdVideoResCaseType);
clsCheckSql.CheckFieldNotNull(objVideoResCaseEN.OwnerId, conVideoResCase.OwnerId);
clsCheckSql.CheckFieldNotNull(objVideoResCaseEN.IdXzCollege, conVideoResCase.IdXzCollege);
clsCheckSql.CheckFieldNotNull(objVideoResCaseEN.IdXzMajor, conVideoResCase.IdXzMajor);
clsCheckSql.CheckFieldNotNull(objVideoResCaseEN.RecommendedDegreeId, conVideoResCase.RecommendedDegreeId);
clsCheckSql.CheckFieldNotNull(objVideoResCaseEN.CourseId, conVideoResCase.CourseId);
//检查字段长度
clsCheckSql.CheckFieldLen(objVideoResCaseEN.IdVideoResCase, 8, conVideoResCase.IdVideoResCase);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.VideoResCaseID, 8, conVideoResCase.VideoResCaseID);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.VideoResCaseName, 100, conVideoResCase.VideoResCaseName);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.VideoResCaseTheme, 200, conVideoResCase.VideoResCaseTheme);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.IdVideoResCaseType, 4, conVideoResCase.IdVideoResCaseType);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.VideoResCaseText, 8000, conVideoResCase.VideoResCaseText);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.VideoResCaseDate, 8, conVideoResCase.VideoResCaseDate);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.VideoResCaseTime, 6, conVideoResCase.VideoResCaseTime);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.VideoResCaseDateIn, 8, conVideoResCase.VideoResCaseDateIn);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.VideoResCaseTimeIn, 6, conVideoResCase.VideoResCaseTimeIn);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.OwnerId, 20, conVideoResCase.OwnerId);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.IdStudyLevel, 4, conVideoResCase.IdStudyLevel);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.IdTeachingPlan, 8, conVideoResCase.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.IdDiscipline, 4, conVideoResCase.IdDiscipline);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.IdSenateGaugeVersion, 4, conVideoResCase.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.IdTeachSkill, 8, conVideoResCase.IdTeachSkill);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.CaseLevelId, 2, conVideoResCase.CaseLevelId);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.DocFile, 200, conVideoResCase.DocFile);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.WordCreateDate, 14, conVideoResCase.WordCreateDate);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.IdXzCollege, 4, conVideoResCase.IdXzCollege);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.IdXzMajor, 8, conVideoResCase.IdXzMajor);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.CourseChapterId, 8, conVideoResCase.CourseChapterId);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.RecommendedDegreeId, 2, conVideoResCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.ftpFileType, 30, conVideoResCase.ftpFileType);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.CourseId, 8, conVideoResCase.CourseId);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.VideoUrl, 1000, conVideoResCase.VideoUrl);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.VideoPath, 1000, conVideoResCase.VideoPath);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.ResErrMsg, 30, conVideoResCase.ResErrMsg);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.UpdDate, 20, conVideoResCase.UpdDate);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.UpdUserId, 20, conVideoResCase.UpdUserId);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.Memo, 1000, conVideoResCase.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objVideoResCaseEN.IdStudyLevel, 4, conVideoResCase.IdStudyLevel);
clsCheckSql.CheckFieldForeignKey(objVideoResCaseEN.IdSenateGaugeVersion, 4, conVideoResCase.IdSenateGaugeVersion);
 objVideoResCaseEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsVideoResCaseEN objVideoResCaseEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objVideoResCaseEN.VideoResCaseID, 8, conVideoResCase.VideoResCaseID);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.VideoResCaseName, 100, conVideoResCase.VideoResCaseName);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.VideoResCaseTheme, 200, conVideoResCase.VideoResCaseTheme);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.IdVideoResCaseType, 4, conVideoResCase.IdVideoResCaseType);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.VideoResCaseText, 8000, conVideoResCase.VideoResCaseText);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.VideoResCaseDate, 8, conVideoResCase.VideoResCaseDate);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.VideoResCaseTime, 6, conVideoResCase.VideoResCaseTime);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.VideoResCaseDateIn, 8, conVideoResCase.VideoResCaseDateIn);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.VideoResCaseTimeIn, 6, conVideoResCase.VideoResCaseTimeIn);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.OwnerId, 20, conVideoResCase.OwnerId);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.IdStudyLevel, 4, conVideoResCase.IdStudyLevel);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.IdTeachingPlan, 8, conVideoResCase.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.IdDiscipline, 4, conVideoResCase.IdDiscipline);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.IdSenateGaugeVersion, 4, conVideoResCase.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.IdTeachSkill, 8, conVideoResCase.IdTeachSkill);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.CaseLevelId, 2, conVideoResCase.CaseLevelId);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.DocFile, 200, conVideoResCase.DocFile);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.WordCreateDate, 14, conVideoResCase.WordCreateDate);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.IdXzCollege, 4, conVideoResCase.IdXzCollege);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.IdXzMajor, 8, conVideoResCase.IdXzMajor);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.CourseChapterId, 8, conVideoResCase.CourseChapterId);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.RecommendedDegreeId, 2, conVideoResCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.ftpFileType, 30, conVideoResCase.ftpFileType);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.CourseId, 8, conVideoResCase.CourseId);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.VideoUrl, 1000, conVideoResCase.VideoUrl);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.VideoPath, 1000, conVideoResCase.VideoPath);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.ResErrMsg, 30, conVideoResCase.ResErrMsg);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.UpdDate, 20, conVideoResCase.UpdDate);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.UpdUserId, 20, conVideoResCase.UpdUserId);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.Memo, 1000, conVideoResCase.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objVideoResCaseEN.IdStudyLevel, 4, conVideoResCase.IdStudyLevel);
clsCheckSql.CheckFieldForeignKey(objVideoResCaseEN.IdSenateGaugeVersion, 4, conVideoResCase.IdSenateGaugeVersion);
 objVideoResCaseEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsVideoResCaseEN objVideoResCaseEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objVideoResCaseEN.IdVideoResCase, 8, conVideoResCase.IdVideoResCase);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.VideoResCaseID, 8, conVideoResCase.VideoResCaseID);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.VideoResCaseName, 100, conVideoResCase.VideoResCaseName);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.VideoResCaseTheme, 200, conVideoResCase.VideoResCaseTheme);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.IdVideoResCaseType, 4, conVideoResCase.IdVideoResCaseType);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.VideoResCaseText, 8000, conVideoResCase.VideoResCaseText);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.VideoResCaseDate, 8, conVideoResCase.VideoResCaseDate);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.VideoResCaseTime, 6, conVideoResCase.VideoResCaseTime);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.VideoResCaseDateIn, 8, conVideoResCase.VideoResCaseDateIn);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.VideoResCaseTimeIn, 6, conVideoResCase.VideoResCaseTimeIn);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.OwnerId, 20, conVideoResCase.OwnerId);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.IdStudyLevel, 4, conVideoResCase.IdStudyLevel);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.IdTeachingPlan, 8, conVideoResCase.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.IdDiscipline, 4, conVideoResCase.IdDiscipline);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.IdSenateGaugeVersion, 4, conVideoResCase.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.IdTeachSkill, 8, conVideoResCase.IdTeachSkill);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.CaseLevelId, 2, conVideoResCase.CaseLevelId);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.DocFile, 200, conVideoResCase.DocFile);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.WordCreateDate, 14, conVideoResCase.WordCreateDate);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.IdXzCollege, 4, conVideoResCase.IdXzCollege);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.IdXzMajor, 8, conVideoResCase.IdXzMajor);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.CourseChapterId, 8, conVideoResCase.CourseChapterId);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.RecommendedDegreeId, 2, conVideoResCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.ftpFileType, 30, conVideoResCase.ftpFileType);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.CourseId, 8, conVideoResCase.CourseId);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.VideoUrl, 1000, conVideoResCase.VideoUrl);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.VideoPath, 1000, conVideoResCase.VideoPath);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.ResErrMsg, 30, conVideoResCase.ResErrMsg);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.UpdDate, 20, conVideoResCase.UpdDate);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.UpdUserId, 20, conVideoResCase.UpdUserId);
clsCheckSql.CheckFieldLen(objVideoResCaseEN.Memo, 1000, conVideoResCase.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objVideoResCaseEN.IdVideoResCase, conVideoResCase.IdVideoResCase);
clsCheckSql.CheckSqlInjection4Field(objVideoResCaseEN.VideoResCaseID, conVideoResCase.VideoResCaseID);
clsCheckSql.CheckSqlInjection4Field(objVideoResCaseEN.VideoResCaseName, conVideoResCase.VideoResCaseName);
clsCheckSql.CheckSqlInjection4Field(objVideoResCaseEN.VideoResCaseTheme, conVideoResCase.VideoResCaseTheme);
clsCheckSql.CheckSqlInjection4Field(objVideoResCaseEN.IdVideoResCaseType, conVideoResCase.IdVideoResCaseType);
clsCheckSql.CheckSqlInjection4Field(objVideoResCaseEN.VideoResCaseText, conVideoResCase.VideoResCaseText);
clsCheckSql.CheckSqlInjection4Field(objVideoResCaseEN.VideoResCaseDate, conVideoResCase.VideoResCaseDate);
clsCheckSql.CheckSqlInjection4Field(objVideoResCaseEN.VideoResCaseTime, conVideoResCase.VideoResCaseTime);
clsCheckSql.CheckSqlInjection4Field(objVideoResCaseEN.VideoResCaseDateIn, conVideoResCase.VideoResCaseDateIn);
clsCheckSql.CheckSqlInjection4Field(objVideoResCaseEN.VideoResCaseTimeIn, conVideoResCase.VideoResCaseTimeIn);
clsCheckSql.CheckSqlInjection4Field(objVideoResCaseEN.OwnerId, conVideoResCase.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objVideoResCaseEN.IdStudyLevel, conVideoResCase.IdStudyLevel);
clsCheckSql.CheckSqlInjection4Field(objVideoResCaseEN.IdTeachingPlan, conVideoResCase.IdTeachingPlan);
clsCheckSql.CheckSqlInjection4Field(objVideoResCaseEN.IdDiscipline, conVideoResCase.IdDiscipline);
clsCheckSql.CheckSqlInjection4Field(objVideoResCaseEN.IdSenateGaugeVersion, conVideoResCase.IdSenateGaugeVersion);
clsCheckSql.CheckSqlInjection4Field(objVideoResCaseEN.IdTeachSkill, conVideoResCase.IdTeachSkill);
clsCheckSql.CheckSqlInjection4Field(objVideoResCaseEN.CaseLevelId, conVideoResCase.CaseLevelId);
clsCheckSql.CheckSqlInjection4Field(objVideoResCaseEN.DocFile, conVideoResCase.DocFile);
clsCheckSql.CheckSqlInjection4Field(objVideoResCaseEN.WordCreateDate, conVideoResCase.WordCreateDate);
clsCheckSql.CheckSqlInjection4Field(objVideoResCaseEN.IdXzCollege, conVideoResCase.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objVideoResCaseEN.IdXzMajor, conVideoResCase.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objVideoResCaseEN.CourseChapterId, conVideoResCase.CourseChapterId);
clsCheckSql.CheckSqlInjection4Field(objVideoResCaseEN.RecommendedDegreeId, conVideoResCase.RecommendedDegreeId);
clsCheckSql.CheckSqlInjection4Field(objVideoResCaseEN.ftpFileType, conVideoResCase.ftpFileType);
clsCheckSql.CheckSqlInjection4Field(objVideoResCaseEN.CourseId, conVideoResCase.CourseId);
clsCheckSql.CheckSqlInjection4Field(objVideoResCaseEN.VideoUrl, conVideoResCase.VideoUrl);
clsCheckSql.CheckSqlInjection4Field(objVideoResCaseEN.VideoPath, conVideoResCase.VideoPath);
clsCheckSql.CheckSqlInjection4Field(objVideoResCaseEN.ResErrMsg, conVideoResCase.ResErrMsg);
clsCheckSql.CheckSqlInjection4Field(objVideoResCaseEN.UpdDate, conVideoResCase.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objVideoResCaseEN.UpdUserId, conVideoResCase.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objVideoResCaseEN.Memo, conVideoResCase.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objVideoResCaseEN.IdStudyLevel, 4, conVideoResCase.IdStudyLevel);
clsCheckSql.CheckFieldForeignKey(objVideoResCaseEN.IdSenateGaugeVersion, 4, conVideoResCase.IdSenateGaugeVersion);
 objVideoResCaseEN._IsCheckProperty = true;
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
 objSQL = clsVideoResCaseDA.GetSpecSQLObj();
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
 objSQL = clsVideoResCaseDA.GetSpecSQLObj();
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
 objSQL = clsVideoResCaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsVideoResCaseEN._CurrTabName);
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
 objSQL = clsVideoResCaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsVideoResCaseEN._CurrTabName, strCondition);
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
 objSQL = clsVideoResCaseDA.GetSpecSQLObj();
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
 objSQL = clsVideoResCaseDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}