
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsVideoLibDA
 表名:VideoLib(01120261)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:46:48
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:视频库(VideoLib)
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
 /// 视频库(VideoLib)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsVideoLibDA : clsCommBase4DA
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
 return clsVideoLibEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsVideoLibEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsVideoLibEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsVideoLibEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsVideoLibEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strIdVideoLib">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strIdVideoLib)
{
strIdVideoLib = strIdVideoLib.Replace("'", "''");
if (strIdVideoLib.Length > 8)
{
throw new Exception("(errid:Data000001)在表:VideoLib中,检查关键字,长度不正确!(clsVideoLibDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdVideoLib)  ==  true)
{
throw new Exception("(errid:Data000002)在表:VideoLib中,关键字不能为空 或 null!(clsVideoLibDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdVideoLib);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsVideoLibDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsVideoLibDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoLibDA.GetSpecSQLObj();
strSQL = "Select * from VideoLib where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_VideoLib(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsVideoLibDA: GetDataTable_VideoLib)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoLibDA.GetSpecSQLObj();
strSQL = "Select * from VideoLib where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsVideoLibDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoLibDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsVideoLibDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoLibDA.GetSpecSQLObj();
strSQL = "Select * from VideoLib where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsVideoLibDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoLibDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsVideoLibDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoLibDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from VideoLib where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from VideoLib where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsVideoLibDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoLibDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from VideoLib where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsVideoLibDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoLibDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} VideoLib.* from VideoLib Left Join {1} on {2} where {3} and VideoLib.IdVideoLib not in (Select top {5} VideoLib.IdVideoLib from VideoLib Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from VideoLib where {1} and IdVideoLib not in (Select top {2} IdVideoLib from VideoLib where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from VideoLib where {1} and IdVideoLib not in (Select top {3} IdVideoLib from VideoLib where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsVideoLibDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoLibDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} VideoLib.* from VideoLib Left Join {1} on {2} where {3} and VideoLib.IdVideoLib not in (Select top {5} VideoLib.IdVideoLib from VideoLib Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from VideoLib where {1} and IdVideoLib not in (Select top {2} IdVideoLib from VideoLib where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from VideoLib where {1} and IdVideoLib not in (Select top {3} IdVideoLib from VideoLib where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsVideoLibEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsVideoLibDA:GetObjLst)", objException.Message));
}
List<clsVideoLibEN> arrObjLst = new List<clsVideoLibEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoLibDA.GetSpecSQLObj();
strSQL = "Select * from VideoLib where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsVideoLibEN objVideoLibEN = new clsVideoLibEN();
try
{
objVideoLibEN.IdVideoLib = objRow[conVideoLib.IdVideoLib].ToString().Trim(); //视频库流水号
objVideoLibEN.VideoLibID = objRow[conVideoLib.VideoLibID].ToString().Trim(); //视频库ID
objVideoLibEN.VideoLibName = objRow[conVideoLib.VideoLibName].ToString().Trim(); //视频名称
objVideoLibEN.VideoLibTheme = objRow[conVideoLib.VideoLibTheme] == DBNull.Value ? null : objRow[conVideoLib.VideoLibTheme].ToString().Trim(); //视频库主题词
objVideoLibEN.IdVideoLibType = objRow[conVideoLib.IdVideoLibType].ToString().Trim(); //视频库类型流水号
objVideoLibEN.VideoLibText = objRow[conVideoLib.VideoLibText] == DBNull.Value ? null : objRow[conVideoLib.VideoLibText].ToString().Trim(); //案例文本内容
objVideoLibEN.VideoLibDate = objRow[conVideoLib.VideoLibDate] == DBNull.Value ? null : objRow[conVideoLib.VideoLibDate].ToString().Trim(); //视频资源日期
objVideoLibEN.VideoLibTime = objRow[conVideoLib.VideoLibTime] == DBNull.Value ? null : objRow[conVideoLib.VideoLibTime].ToString().Trim(); //视频资源时间
objVideoLibEN.VideoLibDateIn = objRow[conVideoLib.VideoLibDateIn] == DBNull.Value ? null : objRow[conVideoLib.VideoLibDateIn].ToString().Trim(); //案例入库日期
objVideoLibEN.VideoLibTimeIn = objRow[conVideoLib.VideoLibTimeIn] == DBNull.Value ? null : objRow[conVideoLib.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objVideoLibEN.OwnerId = objRow[conVideoLib.OwnerId].ToString().Trim(); //拥有者Id
objVideoLibEN.IdTeachingPlan = objRow[conVideoLib.IdTeachingPlan] == DBNull.Value ? null : objRow[conVideoLib.IdTeachingPlan].ToString().Trim(); //教案流水号
objVideoLibEN.BrowseCount = objRow[conVideoLib.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conVideoLib.BrowseCount].ToString().Trim()); //浏览次数
objVideoLibEN.IdSenateGaugeVersion = objRow[conVideoLib.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conVideoLib.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objVideoLibEN.CaseLevelId = objRow[conVideoLib.CaseLevelId] == DBNull.Value ? null : objRow[conVideoLib.CaseLevelId].ToString().Trim(); //课例等级Id
objVideoLibEN.IsVisible = TransNullToBool(objRow[conVideoLib.IsVisible].ToString().Trim()); //是否显示
objVideoLibEN.IdXzCollege = objRow[conVideoLib.IdXzCollege] == DBNull.Value ? null : objRow[conVideoLib.IdXzCollege].ToString().Trim(); //学院流水号
objVideoLibEN.ViewCount = objRow[conVideoLib.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conVideoLib.ViewCount].ToString().Trim()); //浏览量
objVideoLibEN.DownloadNumber = objRow[conVideoLib.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conVideoLib.DownloadNumber].ToString().Trim()); //下载数目
objVideoLibEN.FileIntegration = objRow[conVideoLib.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conVideoLib.FileIntegration].ToString().Trim()); //文件积分
objVideoLibEN.LikeCount = objRow[conVideoLib.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conVideoLib.LikeCount].ToString().Trim()); //资源喜欢数量
objVideoLibEN.CollectionCount = objRow[conVideoLib.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conVideoLib.CollectionCount].ToString().Trim()); //收藏数量
objVideoLibEN.RecommendedDegreeId = objRow[conVideoLib.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objVideoLibEN.CourseId = objRow[conVideoLib.CourseId] == DBNull.Value ? null : objRow[conVideoLib.CourseId].ToString().Trim(); //课程Id
objVideoLibEN.VideoUrl = objRow[conVideoLib.VideoUrl] == DBNull.Value ? null : objRow[conVideoLib.VideoUrl].ToString().Trim(); //视频Url
objVideoLibEN.VideoPath = objRow[conVideoLib.VideoPath] == DBNull.Value ? null : objRow[conVideoLib.VideoPath].ToString().Trim(); //视频目录
objVideoLibEN.CoverPicUrl = objRow[conVideoLib.CoverPicUrl] == DBNull.Value ? null : objRow[conVideoLib.CoverPicUrl].ToString().Trim(); //封面Url
objVideoLibEN.CoverPicShortUrl = objRow[conVideoLib.CoverPicShortUrl] == DBNull.Value ? null : objRow[conVideoLib.CoverPicShortUrl].ToString().Trim(); //封面短Url
objVideoLibEN.ResErrMsg = objRow[conVideoLib.ResErrMsg] == DBNull.Value ? null : objRow[conVideoLib.ResErrMsg].ToString().Trim(); //资源错误信息
objVideoLibEN.UpdDate = objRow[conVideoLib.UpdDate] == DBNull.Value ? null : objRow[conVideoLib.UpdDate].ToString().Trim(); //修改日期
objVideoLibEN.UpdUserId = objRow[conVideoLib.UpdUserId] == DBNull.Value ? null : objRow[conVideoLib.UpdUserId].ToString().Trim(); //修改用户Id
objVideoLibEN.Memo = objRow[conVideoLib.Memo] == DBNull.Value ? null : objRow[conVideoLib.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsVideoLibDA: GetObjLst)", objException.Message));
}
objVideoLibEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objVideoLibEN);
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
public List<clsVideoLibEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsVideoLibDA:GetObjLstByTabName)", objException.Message));
}
List<clsVideoLibEN> arrObjLst = new List<clsVideoLibEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoLibDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsVideoLibEN objVideoLibEN = new clsVideoLibEN();
try
{
objVideoLibEN.IdVideoLib = objRow[conVideoLib.IdVideoLib].ToString().Trim(); //视频库流水号
objVideoLibEN.VideoLibID = objRow[conVideoLib.VideoLibID].ToString().Trim(); //视频库ID
objVideoLibEN.VideoLibName = objRow[conVideoLib.VideoLibName].ToString().Trim(); //视频名称
objVideoLibEN.VideoLibTheme = objRow[conVideoLib.VideoLibTheme] == DBNull.Value ? null : objRow[conVideoLib.VideoLibTheme].ToString().Trim(); //视频库主题词
objVideoLibEN.IdVideoLibType = objRow[conVideoLib.IdVideoLibType].ToString().Trim(); //视频库类型流水号
objVideoLibEN.VideoLibText = objRow[conVideoLib.VideoLibText] == DBNull.Value ? null : objRow[conVideoLib.VideoLibText].ToString().Trim(); //案例文本内容
objVideoLibEN.VideoLibDate = objRow[conVideoLib.VideoLibDate] == DBNull.Value ? null : objRow[conVideoLib.VideoLibDate].ToString().Trim(); //视频资源日期
objVideoLibEN.VideoLibTime = objRow[conVideoLib.VideoLibTime] == DBNull.Value ? null : objRow[conVideoLib.VideoLibTime].ToString().Trim(); //视频资源时间
objVideoLibEN.VideoLibDateIn = objRow[conVideoLib.VideoLibDateIn] == DBNull.Value ? null : objRow[conVideoLib.VideoLibDateIn].ToString().Trim(); //案例入库日期
objVideoLibEN.VideoLibTimeIn = objRow[conVideoLib.VideoLibTimeIn] == DBNull.Value ? null : objRow[conVideoLib.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objVideoLibEN.OwnerId = objRow[conVideoLib.OwnerId].ToString().Trim(); //拥有者Id
objVideoLibEN.IdTeachingPlan = objRow[conVideoLib.IdTeachingPlan] == DBNull.Value ? null : objRow[conVideoLib.IdTeachingPlan].ToString().Trim(); //教案流水号
objVideoLibEN.BrowseCount = objRow[conVideoLib.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conVideoLib.BrowseCount].ToString().Trim()); //浏览次数
objVideoLibEN.IdSenateGaugeVersion = objRow[conVideoLib.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conVideoLib.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objVideoLibEN.CaseLevelId = objRow[conVideoLib.CaseLevelId] == DBNull.Value ? null : objRow[conVideoLib.CaseLevelId].ToString().Trim(); //课例等级Id
objVideoLibEN.IsVisible = TransNullToBool(objRow[conVideoLib.IsVisible].ToString().Trim()); //是否显示
objVideoLibEN.IdXzCollege = objRow[conVideoLib.IdXzCollege] == DBNull.Value ? null : objRow[conVideoLib.IdXzCollege].ToString().Trim(); //学院流水号
objVideoLibEN.ViewCount = objRow[conVideoLib.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conVideoLib.ViewCount].ToString().Trim()); //浏览量
objVideoLibEN.DownloadNumber = objRow[conVideoLib.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conVideoLib.DownloadNumber].ToString().Trim()); //下载数目
objVideoLibEN.FileIntegration = objRow[conVideoLib.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conVideoLib.FileIntegration].ToString().Trim()); //文件积分
objVideoLibEN.LikeCount = objRow[conVideoLib.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conVideoLib.LikeCount].ToString().Trim()); //资源喜欢数量
objVideoLibEN.CollectionCount = objRow[conVideoLib.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conVideoLib.CollectionCount].ToString().Trim()); //收藏数量
objVideoLibEN.RecommendedDegreeId = objRow[conVideoLib.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objVideoLibEN.CourseId = objRow[conVideoLib.CourseId] == DBNull.Value ? null : objRow[conVideoLib.CourseId].ToString().Trim(); //课程Id
objVideoLibEN.VideoUrl = objRow[conVideoLib.VideoUrl] == DBNull.Value ? null : objRow[conVideoLib.VideoUrl].ToString().Trim(); //视频Url
objVideoLibEN.VideoPath = objRow[conVideoLib.VideoPath] == DBNull.Value ? null : objRow[conVideoLib.VideoPath].ToString().Trim(); //视频目录
objVideoLibEN.CoverPicUrl = objRow[conVideoLib.CoverPicUrl] == DBNull.Value ? null : objRow[conVideoLib.CoverPicUrl].ToString().Trim(); //封面Url
objVideoLibEN.CoverPicShortUrl = objRow[conVideoLib.CoverPicShortUrl] == DBNull.Value ? null : objRow[conVideoLib.CoverPicShortUrl].ToString().Trim(); //封面短Url
objVideoLibEN.ResErrMsg = objRow[conVideoLib.ResErrMsg] == DBNull.Value ? null : objRow[conVideoLib.ResErrMsg].ToString().Trim(); //资源错误信息
objVideoLibEN.UpdDate = objRow[conVideoLib.UpdDate] == DBNull.Value ? null : objRow[conVideoLib.UpdDate].ToString().Trim(); //修改日期
objVideoLibEN.UpdUserId = objRow[conVideoLib.UpdUserId] == DBNull.Value ? null : objRow[conVideoLib.UpdUserId].ToString().Trim(); //修改用户Id
objVideoLibEN.Memo = objRow[conVideoLib.Memo] == DBNull.Value ? null : objRow[conVideoLib.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsVideoLibDA: GetObjLst)", objException.Message));
}
objVideoLibEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objVideoLibEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objVideoLibEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetVideoLib(ref clsVideoLibEN objVideoLibEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoLibDA.GetSpecSQLObj();
strSQL = "Select * from VideoLib where IdVideoLib = " + "'"+ objVideoLibEN.IdVideoLib+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objVideoLibEN.IdVideoLib = objDT.Rows[0][conVideoLib.IdVideoLib].ToString().Trim(); //视频库流水号(字段类型:char,字段长度:8,是否可空:False)
 objVideoLibEN.VideoLibID = objDT.Rows[0][conVideoLib.VideoLibID].ToString().Trim(); //视频库ID(字段类型:char,字段长度:8,是否可空:False)
 objVideoLibEN.VideoLibName = objDT.Rows[0][conVideoLib.VideoLibName].ToString().Trim(); //视频名称(字段类型:varchar,字段长度:100,是否可空:False)
 objVideoLibEN.VideoLibTheme = objDT.Rows[0][conVideoLib.VideoLibTheme].ToString().Trim(); //视频库主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objVideoLibEN.IdVideoLibType = objDT.Rows[0][conVideoLib.IdVideoLibType].ToString().Trim(); //视频库类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objVideoLibEN.VideoLibText = objDT.Rows[0][conVideoLib.VideoLibText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objVideoLibEN.VideoLibDate = objDT.Rows[0][conVideoLib.VideoLibDate].ToString().Trim(); //视频资源日期(字段类型:varchar,字段长度:20,是否可空:True)
 objVideoLibEN.VideoLibTime = objDT.Rows[0][conVideoLib.VideoLibTime].ToString().Trim(); //视频资源时间(字段类型:char,字段长度:6,是否可空:True)
 objVideoLibEN.VideoLibDateIn = objDT.Rows[0][conVideoLib.VideoLibDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objVideoLibEN.VideoLibTimeIn = objDT.Rows[0][conVideoLib.VideoLibTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objVideoLibEN.OwnerId = objDT.Rows[0][conVideoLib.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objVideoLibEN.IdTeachingPlan = objDT.Rows[0][conVideoLib.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objVideoLibEN.BrowseCount = TransNullToInt(objDT.Rows[0][conVideoLib.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objVideoLibEN.IdSenateGaugeVersion = objDT.Rows[0][conVideoLib.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objVideoLibEN.CaseLevelId = objDT.Rows[0][conVideoLib.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objVideoLibEN.IsVisible = TransNullToBool(objDT.Rows[0][conVideoLib.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objVideoLibEN.IdXzCollege = objDT.Rows[0][conVideoLib.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objVideoLibEN.ViewCount = TransNullToInt(objDT.Rows[0][conVideoLib.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objVideoLibEN.DownloadNumber = TransNullToInt(objDT.Rows[0][conVideoLib.DownloadNumber].ToString().Trim()); //下载数目(字段类型:int,字段长度:4,是否可空:True)
 objVideoLibEN.FileIntegration = TransNullToInt(objDT.Rows[0][conVideoLib.FileIntegration].ToString().Trim()); //文件积分(字段类型:int,字段长度:4,是否可空:True)
 objVideoLibEN.LikeCount = TransNullToInt(objDT.Rows[0][conVideoLib.LikeCount].ToString().Trim()); //资源喜欢数量(字段类型:bigint,字段长度:8,是否可空:True)
 objVideoLibEN.CollectionCount = TransNullToInt(objDT.Rows[0][conVideoLib.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objVideoLibEN.RecommendedDegreeId = objDT.Rows[0][conVideoLib.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objVideoLibEN.CourseId = objDT.Rows[0][conVideoLib.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objVideoLibEN.VideoUrl = objDT.Rows[0][conVideoLib.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objVideoLibEN.VideoPath = objDT.Rows[0][conVideoLib.VideoPath].ToString().Trim(); //视频目录(字段类型:varchar,字段长度:1000,是否可空:True)
 objVideoLibEN.CoverPicUrl = objDT.Rows[0][conVideoLib.CoverPicUrl].ToString().Trim(); //封面Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objVideoLibEN.CoverPicShortUrl = objDT.Rows[0][conVideoLib.CoverPicShortUrl].ToString().Trim(); //封面短Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objVideoLibEN.ResErrMsg = objDT.Rows[0][conVideoLib.ResErrMsg].ToString().Trim(); //资源错误信息(字段类型:varchar,字段长度:30,是否可空:True)
 objVideoLibEN.UpdDate = objDT.Rows[0][conVideoLib.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objVideoLibEN.UpdUserId = objDT.Rows[0][conVideoLib.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objVideoLibEN.Memo = objDT.Rows[0][conVideoLib.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsVideoLibDA: GetVideoLib)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdVideoLib">表关键字</param>
 /// <returns>表对象</returns>
public clsVideoLibEN GetObjByIdVideoLib(string strIdVideoLib)
{
CheckPrimaryKey(strIdVideoLib);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoLibDA.GetSpecSQLObj();
strSQL = "Select * from VideoLib where IdVideoLib = " + "'"+ strIdVideoLib+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsVideoLibEN objVideoLibEN = new clsVideoLibEN();
try
{
 objVideoLibEN.IdVideoLib = objRow[conVideoLib.IdVideoLib].ToString().Trim(); //视频库流水号(字段类型:char,字段长度:8,是否可空:False)
 objVideoLibEN.VideoLibID = objRow[conVideoLib.VideoLibID].ToString().Trim(); //视频库ID(字段类型:char,字段长度:8,是否可空:False)
 objVideoLibEN.VideoLibName = objRow[conVideoLib.VideoLibName].ToString().Trim(); //视频名称(字段类型:varchar,字段长度:100,是否可空:False)
 objVideoLibEN.VideoLibTheme = objRow[conVideoLib.VideoLibTheme] == DBNull.Value ? null : objRow[conVideoLib.VideoLibTheme].ToString().Trim(); //视频库主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objVideoLibEN.IdVideoLibType = objRow[conVideoLib.IdVideoLibType].ToString().Trim(); //视频库类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objVideoLibEN.VideoLibText = objRow[conVideoLib.VideoLibText] == DBNull.Value ? null : objRow[conVideoLib.VideoLibText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objVideoLibEN.VideoLibDate = objRow[conVideoLib.VideoLibDate] == DBNull.Value ? null : objRow[conVideoLib.VideoLibDate].ToString().Trim(); //视频资源日期(字段类型:varchar,字段长度:20,是否可空:True)
 objVideoLibEN.VideoLibTime = objRow[conVideoLib.VideoLibTime] == DBNull.Value ? null : objRow[conVideoLib.VideoLibTime].ToString().Trim(); //视频资源时间(字段类型:char,字段长度:6,是否可空:True)
 objVideoLibEN.VideoLibDateIn = objRow[conVideoLib.VideoLibDateIn] == DBNull.Value ? null : objRow[conVideoLib.VideoLibDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objVideoLibEN.VideoLibTimeIn = objRow[conVideoLib.VideoLibTimeIn] == DBNull.Value ? null : objRow[conVideoLib.VideoLibTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objVideoLibEN.OwnerId = objRow[conVideoLib.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objVideoLibEN.IdTeachingPlan = objRow[conVideoLib.IdTeachingPlan] == DBNull.Value ? null : objRow[conVideoLib.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objVideoLibEN.BrowseCount = objRow[conVideoLib.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLib.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objVideoLibEN.IdSenateGaugeVersion = objRow[conVideoLib.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conVideoLib.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objVideoLibEN.CaseLevelId = objRow[conVideoLib.CaseLevelId] == DBNull.Value ? null : objRow[conVideoLib.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objVideoLibEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conVideoLib.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objVideoLibEN.IdXzCollege = objRow[conVideoLib.IdXzCollege] == DBNull.Value ? null : objRow[conVideoLib.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objVideoLibEN.ViewCount = objRow[conVideoLib.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLib.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objVideoLibEN.DownloadNumber = objRow[conVideoLib.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLib.DownloadNumber].ToString().Trim()); //下载数目(字段类型:int,字段长度:4,是否可空:True)
 objVideoLibEN.FileIntegration = objRow[conVideoLib.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLib.FileIntegration].ToString().Trim()); //文件积分(字段类型:int,字段长度:4,是否可空:True)
 objVideoLibEN.LikeCount = objRow[conVideoLib.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLib.LikeCount].ToString().Trim()); //资源喜欢数量(字段类型:bigint,字段长度:8,是否可空:True)
 objVideoLibEN.CollectionCount = objRow[conVideoLib.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLib.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objVideoLibEN.RecommendedDegreeId = objRow[conVideoLib.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objVideoLibEN.CourseId = objRow[conVideoLib.CourseId] == DBNull.Value ? null : objRow[conVideoLib.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objVideoLibEN.VideoUrl = objRow[conVideoLib.VideoUrl] == DBNull.Value ? null : objRow[conVideoLib.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objVideoLibEN.VideoPath = objRow[conVideoLib.VideoPath] == DBNull.Value ? null : objRow[conVideoLib.VideoPath].ToString().Trim(); //视频目录(字段类型:varchar,字段长度:1000,是否可空:True)
 objVideoLibEN.CoverPicUrl = objRow[conVideoLib.CoverPicUrl] == DBNull.Value ? null : objRow[conVideoLib.CoverPicUrl].ToString().Trim(); //封面Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objVideoLibEN.CoverPicShortUrl = objRow[conVideoLib.CoverPicShortUrl] == DBNull.Value ? null : objRow[conVideoLib.CoverPicShortUrl].ToString().Trim(); //封面短Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objVideoLibEN.ResErrMsg = objRow[conVideoLib.ResErrMsg] == DBNull.Value ? null : objRow[conVideoLib.ResErrMsg].ToString().Trim(); //资源错误信息(字段类型:varchar,字段长度:30,是否可空:True)
 objVideoLibEN.UpdDate = objRow[conVideoLib.UpdDate] == DBNull.Value ? null : objRow[conVideoLib.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objVideoLibEN.UpdUserId = objRow[conVideoLib.UpdUserId] == DBNull.Value ? null : objRow[conVideoLib.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objVideoLibEN.Memo = objRow[conVideoLib.Memo] == DBNull.Value ? null : objRow[conVideoLib.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsVideoLibDA: GetObjByIdVideoLib)", objException.Message));
}
return objVideoLibEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsVideoLibEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsVideoLibDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoLibDA.GetSpecSQLObj();
strSQL = "Select * from VideoLib where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsVideoLibEN objVideoLibEN = new clsVideoLibEN()
{
IdVideoLib = objRow[conVideoLib.IdVideoLib].ToString().Trim(), //视频库流水号
VideoLibID = objRow[conVideoLib.VideoLibID].ToString().Trim(), //视频库ID
VideoLibName = objRow[conVideoLib.VideoLibName].ToString().Trim(), //视频名称
VideoLibTheme = objRow[conVideoLib.VideoLibTheme] == DBNull.Value ? null : objRow[conVideoLib.VideoLibTheme].ToString().Trim(), //视频库主题词
IdVideoLibType = objRow[conVideoLib.IdVideoLibType].ToString().Trim(), //视频库类型流水号
VideoLibText = objRow[conVideoLib.VideoLibText] == DBNull.Value ? null : objRow[conVideoLib.VideoLibText].ToString().Trim(), //案例文本内容
VideoLibDate = objRow[conVideoLib.VideoLibDate] == DBNull.Value ? null : objRow[conVideoLib.VideoLibDate].ToString().Trim(), //视频资源日期
VideoLibTime = objRow[conVideoLib.VideoLibTime] == DBNull.Value ? null : objRow[conVideoLib.VideoLibTime].ToString().Trim(), //视频资源时间
VideoLibDateIn = objRow[conVideoLib.VideoLibDateIn] == DBNull.Value ? null : objRow[conVideoLib.VideoLibDateIn].ToString().Trim(), //案例入库日期
VideoLibTimeIn = objRow[conVideoLib.VideoLibTimeIn] == DBNull.Value ? null : objRow[conVideoLib.VideoLibTimeIn].ToString().Trim(), //案例入库时间
OwnerId = objRow[conVideoLib.OwnerId].ToString().Trim(), //拥有者Id
IdTeachingPlan = objRow[conVideoLib.IdTeachingPlan] == DBNull.Value ? null : objRow[conVideoLib.IdTeachingPlan].ToString().Trim(), //教案流水号
BrowseCount = objRow[conVideoLib.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conVideoLib.BrowseCount].ToString().Trim()), //浏览次数
IdSenateGaugeVersion = objRow[conVideoLib.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conVideoLib.IdSenateGaugeVersion].ToString().Trim(), //评价量表版本流水号
CaseLevelId = objRow[conVideoLib.CaseLevelId] == DBNull.Value ? null : objRow[conVideoLib.CaseLevelId].ToString().Trim(), //课例等级Id
IsVisible = TransNullToBool(objRow[conVideoLib.IsVisible].ToString().Trim()), //是否显示
IdXzCollege = objRow[conVideoLib.IdXzCollege] == DBNull.Value ? null : objRow[conVideoLib.IdXzCollege].ToString().Trim(), //学院流水号
ViewCount = objRow[conVideoLib.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conVideoLib.ViewCount].ToString().Trim()), //浏览量
DownloadNumber = objRow[conVideoLib.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conVideoLib.DownloadNumber].ToString().Trim()), //下载数目
FileIntegration = objRow[conVideoLib.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conVideoLib.FileIntegration].ToString().Trim()), //文件积分
LikeCount = objRow[conVideoLib.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conVideoLib.LikeCount].ToString().Trim()), //资源喜欢数量
CollectionCount = objRow[conVideoLib.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conVideoLib.CollectionCount].ToString().Trim()), //收藏数量
RecommendedDegreeId = objRow[conVideoLib.RecommendedDegreeId].ToString().Trim(), //推荐度Id
CourseId = objRow[conVideoLib.CourseId] == DBNull.Value ? null : objRow[conVideoLib.CourseId].ToString().Trim(), //课程Id
VideoUrl = objRow[conVideoLib.VideoUrl] == DBNull.Value ? null : objRow[conVideoLib.VideoUrl].ToString().Trim(), //视频Url
VideoPath = objRow[conVideoLib.VideoPath] == DBNull.Value ? null : objRow[conVideoLib.VideoPath].ToString().Trim(), //视频目录
CoverPicUrl = objRow[conVideoLib.CoverPicUrl] == DBNull.Value ? null : objRow[conVideoLib.CoverPicUrl].ToString().Trim(), //封面Url
CoverPicShortUrl = objRow[conVideoLib.CoverPicShortUrl] == DBNull.Value ? null : objRow[conVideoLib.CoverPicShortUrl].ToString().Trim(), //封面短Url
ResErrMsg = objRow[conVideoLib.ResErrMsg] == DBNull.Value ? null : objRow[conVideoLib.ResErrMsg].ToString().Trim(), //资源错误信息
UpdDate = objRow[conVideoLib.UpdDate] == DBNull.Value ? null : objRow[conVideoLib.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[conVideoLib.UpdUserId] == DBNull.Value ? null : objRow[conVideoLib.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[conVideoLib.Memo] == DBNull.Value ? null : objRow[conVideoLib.Memo].ToString().Trim() //备注
};
objVideoLibEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objVideoLibEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsVideoLibDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsVideoLibEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsVideoLibEN objVideoLibEN = new clsVideoLibEN();
try
{
objVideoLibEN.IdVideoLib = objRow[conVideoLib.IdVideoLib].ToString().Trim(); //视频库流水号
objVideoLibEN.VideoLibID = objRow[conVideoLib.VideoLibID].ToString().Trim(); //视频库ID
objVideoLibEN.VideoLibName = objRow[conVideoLib.VideoLibName].ToString().Trim(); //视频名称
objVideoLibEN.VideoLibTheme = objRow[conVideoLib.VideoLibTheme] == DBNull.Value ? null : objRow[conVideoLib.VideoLibTheme].ToString().Trim(); //视频库主题词
objVideoLibEN.IdVideoLibType = objRow[conVideoLib.IdVideoLibType].ToString().Trim(); //视频库类型流水号
objVideoLibEN.VideoLibText = objRow[conVideoLib.VideoLibText] == DBNull.Value ? null : objRow[conVideoLib.VideoLibText].ToString().Trim(); //案例文本内容
objVideoLibEN.VideoLibDate = objRow[conVideoLib.VideoLibDate] == DBNull.Value ? null : objRow[conVideoLib.VideoLibDate].ToString().Trim(); //视频资源日期
objVideoLibEN.VideoLibTime = objRow[conVideoLib.VideoLibTime] == DBNull.Value ? null : objRow[conVideoLib.VideoLibTime].ToString().Trim(); //视频资源时间
objVideoLibEN.VideoLibDateIn = objRow[conVideoLib.VideoLibDateIn] == DBNull.Value ? null : objRow[conVideoLib.VideoLibDateIn].ToString().Trim(); //案例入库日期
objVideoLibEN.VideoLibTimeIn = objRow[conVideoLib.VideoLibTimeIn] == DBNull.Value ? null : objRow[conVideoLib.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objVideoLibEN.OwnerId = objRow[conVideoLib.OwnerId].ToString().Trim(); //拥有者Id
objVideoLibEN.IdTeachingPlan = objRow[conVideoLib.IdTeachingPlan] == DBNull.Value ? null : objRow[conVideoLib.IdTeachingPlan].ToString().Trim(); //教案流水号
objVideoLibEN.BrowseCount = objRow[conVideoLib.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conVideoLib.BrowseCount].ToString().Trim()); //浏览次数
objVideoLibEN.IdSenateGaugeVersion = objRow[conVideoLib.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conVideoLib.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objVideoLibEN.CaseLevelId = objRow[conVideoLib.CaseLevelId] == DBNull.Value ? null : objRow[conVideoLib.CaseLevelId].ToString().Trim(); //课例等级Id
objVideoLibEN.IsVisible = TransNullToBool(objRow[conVideoLib.IsVisible].ToString().Trim()); //是否显示
objVideoLibEN.IdXzCollege = objRow[conVideoLib.IdXzCollege] == DBNull.Value ? null : objRow[conVideoLib.IdXzCollege].ToString().Trim(); //学院流水号
objVideoLibEN.ViewCount = objRow[conVideoLib.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conVideoLib.ViewCount].ToString().Trim()); //浏览量
objVideoLibEN.DownloadNumber = objRow[conVideoLib.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conVideoLib.DownloadNumber].ToString().Trim()); //下载数目
objVideoLibEN.FileIntegration = objRow[conVideoLib.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conVideoLib.FileIntegration].ToString().Trim()); //文件积分
objVideoLibEN.LikeCount = objRow[conVideoLib.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conVideoLib.LikeCount].ToString().Trim()); //资源喜欢数量
objVideoLibEN.CollectionCount = objRow[conVideoLib.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conVideoLib.CollectionCount].ToString().Trim()); //收藏数量
objVideoLibEN.RecommendedDegreeId = objRow[conVideoLib.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objVideoLibEN.CourseId = objRow[conVideoLib.CourseId] == DBNull.Value ? null : objRow[conVideoLib.CourseId].ToString().Trim(); //课程Id
objVideoLibEN.VideoUrl = objRow[conVideoLib.VideoUrl] == DBNull.Value ? null : objRow[conVideoLib.VideoUrl].ToString().Trim(); //视频Url
objVideoLibEN.VideoPath = objRow[conVideoLib.VideoPath] == DBNull.Value ? null : objRow[conVideoLib.VideoPath].ToString().Trim(); //视频目录
objVideoLibEN.CoverPicUrl = objRow[conVideoLib.CoverPicUrl] == DBNull.Value ? null : objRow[conVideoLib.CoverPicUrl].ToString().Trim(); //封面Url
objVideoLibEN.CoverPicShortUrl = objRow[conVideoLib.CoverPicShortUrl] == DBNull.Value ? null : objRow[conVideoLib.CoverPicShortUrl].ToString().Trim(); //封面短Url
objVideoLibEN.ResErrMsg = objRow[conVideoLib.ResErrMsg] == DBNull.Value ? null : objRow[conVideoLib.ResErrMsg].ToString().Trim(); //资源错误信息
objVideoLibEN.UpdDate = objRow[conVideoLib.UpdDate] == DBNull.Value ? null : objRow[conVideoLib.UpdDate].ToString().Trim(); //修改日期
objVideoLibEN.UpdUserId = objRow[conVideoLib.UpdUserId] == DBNull.Value ? null : objRow[conVideoLib.UpdUserId].ToString().Trim(); //修改用户Id
objVideoLibEN.Memo = objRow[conVideoLib.Memo] == DBNull.Value ? null : objRow[conVideoLib.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsVideoLibDA: GetObjByDataRowVideoLib)", objException.Message));
}
objVideoLibEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objVideoLibEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsVideoLibEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsVideoLibEN objVideoLibEN = new clsVideoLibEN();
try
{
objVideoLibEN.IdVideoLib = objRow[conVideoLib.IdVideoLib].ToString().Trim(); //视频库流水号
objVideoLibEN.VideoLibID = objRow[conVideoLib.VideoLibID].ToString().Trim(); //视频库ID
objVideoLibEN.VideoLibName = objRow[conVideoLib.VideoLibName].ToString().Trim(); //视频名称
objVideoLibEN.VideoLibTheme = objRow[conVideoLib.VideoLibTheme] == DBNull.Value ? null : objRow[conVideoLib.VideoLibTheme].ToString().Trim(); //视频库主题词
objVideoLibEN.IdVideoLibType = objRow[conVideoLib.IdVideoLibType].ToString().Trim(); //视频库类型流水号
objVideoLibEN.VideoLibText = objRow[conVideoLib.VideoLibText] == DBNull.Value ? null : objRow[conVideoLib.VideoLibText].ToString().Trim(); //案例文本内容
objVideoLibEN.VideoLibDate = objRow[conVideoLib.VideoLibDate] == DBNull.Value ? null : objRow[conVideoLib.VideoLibDate].ToString().Trim(); //视频资源日期
objVideoLibEN.VideoLibTime = objRow[conVideoLib.VideoLibTime] == DBNull.Value ? null : objRow[conVideoLib.VideoLibTime].ToString().Trim(); //视频资源时间
objVideoLibEN.VideoLibDateIn = objRow[conVideoLib.VideoLibDateIn] == DBNull.Value ? null : objRow[conVideoLib.VideoLibDateIn].ToString().Trim(); //案例入库日期
objVideoLibEN.VideoLibTimeIn = objRow[conVideoLib.VideoLibTimeIn] == DBNull.Value ? null : objRow[conVideoLib.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objVideoLibEN.OwnerId = objRow[conVideoLib.OwnerId].ToString().Trim(); //拥有者Id
objVideoLibEN.IdTeachingPlan = objRow[conVideoLib.IdTeachingPlan] == DBNull.Value ? null : objRow[conVideoLib.IdTeachingPlan].ToString().Trim(); //教案流水号
objVideoLibEN.BrowseCount = objRow[conVideoLib.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conVideoLib.BrowseCount].ToString().Trim()); //浏览次数
objVideoLibEN.IdSenateGaugeVersion = objRow[conVideoLib.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conVideoLib.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objVideoLibEN.CaseLevelId = objRow[conVideoLib.CaseLevelId] == DBNull.Value ? null : objRow[conVideoLib.CaseLevelId].ToString().Trim(); //课例等级Id
objVideoLibEN.IsVisible = TransNullToBool(objRow[conVideoLib.IsVisible].ToString().Trim()); //是否显示
objVideoLibEN.IdXzCollege = objRow[conVideoLib.IdXzCollege] == DBNull.Value ? null : objRow[conVideoLib.IdXzCollege].ToString().Trim(); //学院流水号
objVideoLibEN.ViewCount = objRow[conVideoLib.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conVideoLib.ViewCount].ToString().Trim()); //浏览量
objVideoLibEN.DownloadNumber = objRow[conVideoLib.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conVideoLib.DownloadNumber].ToString().Trim()); //下载数目
objVideoLibEN.FileIntegration = objRow[conVideoLib.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conVideoLib.FileIntegration].ToString().Trim()); //文件积分
objVideoLibEN.LikeCount = objRow[conVideoLib.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conVideoLib.LikeCount].ToString().Trim()); //资源喜欢数量
objVideoLibEN.CollectionCount = objRow[conVideoLib.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conVideoLib.CollectionCount].ToString().Trim()); //收藏数量
objVideoLibEN.RecommendedDegreeId = objRow[conVideoLib.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objVideoLibEN.CourseId = objRow[conVideoLib.CourseId] == DBNull.Value ? null : objRow[conVideoLib.CourseId].ToString().Trim(); //课程Id
objVideoLibEN.VideoUrl = objRow[conVideoLib.VideoUrl] == DBNull.Value ? null : objRow[conVideoLib.VideoUrl].ToString().Trim(); //视频Url
objVideoLibEN.VideoPath = objRow[conVideoLib.VideoPath] == DBNull.Value ? null : objRow[conVideoLib.VideoPath].ToString().Trim(); //视频目录
objVideoLibEN.CoverPicUrl = objRow[conVideoLib.CoverPicUrl] == DBNull.Value ? null : objRow[conVideoLib.CoverPicUrl].ToString().Trim(); //封面Url
objVideoLibEN.CoverPicShortUrl = objRow[conVideoLib.CoverPicShortUrl] == DBNull.Value ? null : objRow[conVideoLib.CoverPicShortUrl].ToString().Trim(); //封面短Url
objVideoLibEN.ResErrMsg = objRow[conVideoLib.ResErrMsg] == DBNull.Value ? null : objRow[conVideoLib.ResErrMsg].ToString().Trim(); //资源错误信息
objVideoLibEN.UpdDate = objRow[conVideoLib.UpdDate] == DBNull.Value ? null : objRow[conVideoLib.UpdDate].ToString().Trim(); //修改日期
objVideoLibEN.UpdUserId = objRow[conVideoLib.UpdUserId] == DBNull.Value ? null : objRow[conVideoLib.UpdUserId].ToString().Trim(); //修改用户Id
objVideoLibEN.Memo = objRow[conVideoLib.Memo] == DBNull.Value ? null : objRow[conVideoLib.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsVideoLibDA: GetObjByDataRow)", objException.Message));
}
objVideoLibEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objVideoLibEN;
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
objSQL = clsVideoLibDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsVideoLibEN._CurrTabName, conVideoLib.IdVideoLib, 8, "");
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
objSQL = clsVideoLibDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsVideoLibEN._CurrTabName, conVideoLib.IdVideoLib, 8, strPrefix);
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
 objSQL = clsVideoLibDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdVideoLib from VideoLib where " + strCondition;
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
 objSQL = clsVideoLibDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdVideoLib from VideoLib where " + strCondition;
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
 /// <param name = "strIdVideoLib">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strIdVideoLib)
{
CheckPrimaryKey(strIdVideoLib);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoLibDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("VideoLib", "IdVideoLib = " + "'"+ strIdVideoLib+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsVideoLibDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoLibDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("VideoLib", strCondition))
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
objSQL = clsVideoLibDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("VideoLib");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsVideoLibEN objVideoLibEN)
 {
 objVideoLibEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objVideoLibEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objVideoLibEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoLibDA.GetSpecSQLObj();
strSQL = "Select * from VideoLib where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "VideoLib");
objRow = objDS.Tables["VideoLib"].NewRow();
objRow[conVideoLib.IdVideoLib] = objVideoLibEN.IdVideoLib; //视频库流水号
objRow[conVideoLib.VideoLibID] = objVideoLibEN.VideoLibID; //视频库ID
objRow[conVideoLib.VideoLibName] = objVideoLibEN.VideoLibName; //视频名称
 if (objVideoLibEN.VideoLibTheme !=  "")
 {
objRow[conVideoLib.VideoLibTheme] = objVideoLibEN.VideoLibTheme; //视频库主题词
 }
objRow[conVideoLib.IdVideoLibType] = objVideoLibEN.IdVideoLibType; //视频库类型流水号
 if (objVideoLibEN.VideoLibText !=  "")
 {
objRow[conVideoLib.VideoLibText] = objVideoLibEN.VideoLibText; //案例文本内容
 }
 if (objVideoLibEN.VideoLibDate !=  "")
 {
objRow[conVideoLib.VideoLibDate] = objVideoLibEN.VideoLibDate; //视频资源日期
 }
 if (objVideoLibEN.VideoLibTime !=  "")
 {
objRow[conVideoLib.VideoLibTime] = objVideoLibEN.VideoLibTime; //视频资源时间
 }
 if (objVideoLibEN.VideoLibDateIn !=  "")
 {
objRow[conVideoLib.VideoLibDateIn] = objVideoLibEN.VideoLibDateIn; //案例入库日期
 }
 if (objVideoLibEN.VideoLibTimeIn !=  "")
 {
objRow[conVideoLib.VideoLibTimeIn] = objVideoLibEN.VideoLibTimeIn; //案例入库时间
 }
objRow[conVideoLib.OwnerId] = objVideoLibEN.OwnerId; //拥有者Id
 if (objVideoLibEN.IdTeachingPlan !=  "")
 {
objRow[conVideoLib.IdTeachingPlan] = objVideoLibEN.IdTeachingPlan; //教案流水号
 }
objRow[conVideoLib.BrowseCount] = objVideoLibEN.BrowseCount; //浏览次数
 if (objVideoLibEN.IdSenateGaugeVersion !=  "")
 {
objRow[conVideoLib.IdSenateGaugeVersion] = objVideoLibEN.IdSenateGaugeVersion; //评价量表版本流水号
 }
 if (objVideoLibEN.CaseLevelId !=  "")
 {
objRow[conVideoLib.CaseLevelId] = objVideoLibEN.CaseLevelId; //课例等级Id
 }
objRow[conVideoLib.IsVisible] = objVideoLibEN.IsVisible; //是否显示
 if (objVideoLibEN.IdXzCollege !=  "")
 {
objRow[conVideoLib.IdXzCollege] = objVideoLibEN.IdXzCollege; //学院流水号
 }
objRow[conVideoLib.ViewCount] = objVideoLibEN.ViewCount; //浏览量
objRow[conVideoLib.DownloadNumber] = objVideoLibEN.DownloadNumber; //下载数目
objRow[conVideoLib.FileIntegration] = objVideoLibEN.FileIntegration; //文件积分
objRow[conVideoLib.LikeCount] = objVideoLibEN.LikeCount; //资源喜欢数量
objRow[conVideoLib.CollectionCount] = objVideoLibEN.CollectionCount; //收藏数量
objRow[conVideoLib.RecommendedDegreeId] = objVideoLibEN.RecommendedDegreeId; //推荐度Id
 if (objVideoLibEN.CourseId !=  "")
 {
objRow[conVideoLib.CourseId] = objVideoLibEN.CourseId; //课程Id
 }
 if (objVideoLibEN.VideoUrl !=  "")
 {
objRow[conVideoLib.VideoUrl] = objVideoLibEN.VideoUrl; //视频Url
 }
 if (objVideoLibEN.VideoPath !=  "")
 {
objRow[conVideoLib.VideoPath] = objVideoLibEN.VideoPath; //视频目录
 }
 if (objVideoLibEN.CoverPicUrl !=  "")
 {
objRow[conVideoLib.CoverPicUrl] = objVideoLibEN.CoverPicUrl; //封面Url
 }
 if (objVideoLibEN.CoverPicShortUrl !=  "")
 {
objRow[conVideoLib.CoverPicShortUrl] = objVideoLibEN.CoverPicShortUrl; //封面短Url
 }
 if (objVideoLibEN.ResErrMsg !=  "")
 {
objRow[conVideoLib.ResErrMsg] = objVideoLibEN.ResErrMsg; //资源错误信息
 }
 if (objVideoLibEN.UpdDate !=  "")
 {
objRow[conVideoLib.UpdDate] = objVideoLibEN.UpdDate; //修改日期
 }
 if (objVideoLibEN.UpdUserId !=  "")
 {
objRow[conVideoLib.UpdUserId] = objVideoLibEN.UpdUserId; //修改用户Id
 }
 if (objVideoLibEN.Memo !=  "")
 {
objRow[conVideoLib.Memo] = objVideoLibEN.Memo; //备注
 }
objDS.Tables[clsVideoLibEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsVideoLibEN._CurrTabName);
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
 /// <param name = "objVideoLibEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsVideoLibEN objVideoLibEN)
{
 objVideoLibEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objVideoLibEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objVideoLibEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objVideoLibEN.IdVideoLib !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.IdVideoLib);
 var strIdVideoLib = objVideoLibEN.IdVideoLib.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdVideoLib + "'");
 }
 
 if (objVideoLibEN.VideoLibID !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.VideoLibID);
 var strVideoLibID = objVideoLibEN.VideoLibID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoLibID + "'");
 }
 
 if (objVideoLibEN.VideoLibName !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.VideoLibName);
 var strVideoLibName = objVideoLibEN.VideoLibName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoLibName + "'");
 }
 
 if (objVideoLibEN.VideoLibTheme !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.VideoLibTheme);
 var strVideoLibTheme = objVideoLibEN.VideoLibTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoLibTheme + "'");
 }
 
 if (objVideoLibEN.IdVideoLibType !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.IdVideoLibType);
 var strIdVideoLibType = objVideoLibEN.IdVideoLibType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdVideoLibType + "'");
 }
 
 if (objVideoLibEN.VideoLibText !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.VideoLibText);
 var strVideoLibText = objVideoLibEN.VideoLibText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoLibText + "'");
 }
 
 if (objVideoLibEN.VideoLibDate !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.VideoLibDate);
 var strVideoLibDate = objVideoLibEN.VideoLibDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoLibDate + "'");
 }
 
 if (objVideoLibEN.VideoLibTime !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.VideoLibTime);
 var strVideoLibTime = objVideoLibEN.VideoLibTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoLibTime + "'");
 }
 
 if (objVideoLibEN.VideoLibDateIn !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.VideoLibDateIn);
 var strVideoLibDateIn = objVideoLibEN.VideoLibDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoLibDateIn + "'");
 }
 
 if (objVideoLibEN.VideoLibTimeIn !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.VideoLibTimeIn);
 var strVideoLibTimeIn = objVideoLibEN.VideoLibTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoLibTimeIn + "'");
 }
 
 if (objVideoLibEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.OwnerId);
 var strOwnerId = objVideoLibEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 if (objVideoLibEN.IdTeachingPlan !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.IdTeachingPlan);
 var strIdTeachingPlan = objVideoLibEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachingPlan + "'");
 }
 
 if (objVideoLibEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.BrowseCount);
 arrValueListForInsert.Add(objVideoLibEN.BrowseCount.ToString());
 }
 
 if (objVideoLibEN.IdSenateGaugeVersion  ==  "")
 {
 objVideoLibEN.IdSenateGaugeVersion = null;
 }
 if (objVideoLibEN.IdSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.IdSenateGaugeVersion);
 var strIdSenateGaugeVersion = objVideoLibEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeVersion + "'");
 }
 
 if (objVideoLibEN.CaseLevelId !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.CaseLevelId);
 var strCaseLevelId = objVideoLibEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseLevelId + "'");
 }
 
 arrFieldListForInsert.Add(conVideoLib.IsVisible);
 arrValueListForInsert.Add("'" + (objVideoLibEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objVideoLibEN.IdXzCollege !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.IdXzCollege);
 var strIdXzCollege = objVideoLibEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzCollege + "'");
 }
 
 if (objVideoLibEN.ViewCount !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.ViewCount);
 arrValueListForInsert.Add(objVideoLibEN.ViewCount.ToString());
 }
 
 if (objVideoLibEN.DownloadNumber !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.DownloadNumber);
 arrValueListForInsert.Add(objVideoLibEN.DownloadNumber.ToString());
 }
 
 if (objVideoLibEN.FileIntegration !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.FileIntegration);
 arrValueListForInsert.Add(objVideoLibEN.FileIntegration.ToString());
 }
 
 if (objVideoLibEN.LikeCount !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.LikeCount);
 arrValueListForInsert.Add(objVideoLibEN.LikeCount.ToString());
 }
 
 if (objVideoLibEN.CollectionCount !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.CollectionCount);
 arrValueListForInsert.Add(objVideoLibEN.CollectionCount.ToString());
 }
 
 if (objVideoLibEN.RecommendedDegreeId !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.RecommendedDegreeId);
 var strRecommendedDegreeId = objVideoLibEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRecommendedDegreeId + "'");
 }
 
 if (objVideoLibEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.CourseId);
 var strCourseId = objVideoLibEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objVideoLibEN.VideoUrl !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.VideoUrl);
 var strVideoUrl = objVideoLibEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoUrl + "'");
 }
 
 if (objVideoLibEN.VideoPath !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.VideoPath);
 var strVideoPath = objVideoLibEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoPath + "'");
 }
 
 if (objVideoLibEN.CoverPicUrl !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.CoverPicUrl);
 var strCoverPicUrl = objVideoLibEN.CoverPicUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCoverPicUrl + "'");
 }
 
 if (objVideoLibEN.CoverPicShortUrl !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.CoverPicShortUrl);
 var strCoverPicShortUrl = objVideoLibEN.CoverPicShortUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCoverPicShortUrl + "'");
 }
 
 if (objVideoLibEN.ResErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.ResErrMsg);
 var strResErrMsg = objVideoLibEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResErrMsg + "'");
 }
 
 if (objVideoLibEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.UpdDate);
 var strUpdDate = objVideoLibEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objVideoLibEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.UpdUserId);
 var strUpdUserId = objVideoLibEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objVideoLibEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.Memo);
 var strMemo = objVideoLibEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into VideoLib");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoLibDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objVideoLibEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsVideoLibEN objVideoLibEN)
{
 objVideoLibEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objVideoLibEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objVideoLibEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objVideoLibEN.IdVideoLib !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.IdVideoLib);
 var strIdVideoLib = objVideoLibEN.IdVideoLib.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdVideoLib + "'");
 }
 
 if (objVideoLibEN.VideoLibID !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.VideoLibID);
 var strVideoLibID = objVideoLibEN.VideoLibID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoLibID + "'");
 }
 
 if (objVideoLibEN.VideoLibName !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.VideoLibName);
 var strVideoLibName = objVideoLibEN.VideoLibName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoLibName + "'");
 }
 
 if (objVideoLibEN.VideoLibTheme !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.VideoLibTheme);
 var strVideoLibTheme = objVideoLibEN.VideoLibTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoLibTheme + "'");
 }
 
 if (objVideoLibEN.IdVideoLibType !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.IdVideoLibType);
 var strIdVideoLibType = objVideoLibEN.IdVideoLibType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdVideoLibType + "'");
 }
 
 if (objVideoLibEN.VideoLibText !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.VideoLibText);
 var strVideoLibText = objVideoLibEN.VideoLibText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoLibText + "'");
 }
 
 if (objVideoLibEN.VideoLibDate !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.VideoLibDate);
 var strVideoLibDate = objVideoLibEN.VideoLibDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoLibDate + "'");
 }
 
 if (objVideoLibEN.VideoLibTime !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.VideoLibTime);
 var strVideoLibTime = objVideoLibEN.VideoLibTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoLibTime + "'");
 }
 
 if (objVideoLibEN.VideoLibDateIn !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.VideoLibDateIn);
 var strVideoLibDateIn = objVideoLibEN.VideoLibDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoLibDateIn + "'");
 }
 
 if (objVideoLibEN.VideoLibTimeIn !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.VideoLibTimeIn);
 var strVideoLibTimeIn = objVideoLibEN.VideoLibTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoLibTimeIn + "'");
 }
 
 if (objVideoLibEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.OwnerId);
 var strOwnerId = objVideoLibEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 if (objVideoLibEN.IdTeachingPlan !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.IdTeachingPlan);
 var strIdTeachingPlan = objVideoLibEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachingPlan + "'");
 }
 
 if (objVideoLibEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.BrowseCount);
 arrValueListForInsert.Add(objVideoLibEN.BrowseCount.ToString());
 }
 
 if (objVideoLibEN.IdSenateGaugeVersion  ==  "")
 {
 objVideoLibEN.IdSenateGaugeVersion = null;
 }
 if (objVideoLibEN.IdSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.IdSenateGaugeVersion);
 var strIdSenateGaugeVersion = objVideoLibEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeVersion + "'");
 }
 
 if (objVideoLibEN.CaseLevelId !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.CaseLevelId);
 var strCaseLevelId = objVideoLibEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseLevelId + "'");
 }
 
 arrFieldListForInsert.Add(conVideoLib.IsVisible);
 arrValueListForInsert.Add("'" + (objVideoLibEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objVideoLibEN.IdXzCollege !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.IdXzCollege);
 var strIdXzCollege = objVideoLibEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzCollege + "'");
 }
 
 if (objVideoLibEN.ViewCount !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.ViewCount);
 arrValueListForInsert.Add(objVideoLibEN.ViewCount.ToString());
 }
 
 if (objVideoLibEN.DownloadNumber !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.DownloadNumber);
 arrValueListForInsert.Add(objVideoLibEN.DownloadNumber.ToString());
 }
 
 if (objVideoLibEN.FileIntegration !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.FileIntegration);
 arrValueListForInsert.Add(objVideoLibEN.FileIntegration.ToString());
 }
 
 if (objVideoLibEN.LikeCount !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.LikeCount);
 arrValueListForInsert.Add(objVideoLibEN.LikeCount.ToString());
 }
 
 if (objVideoLibEN.CollectionCount !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.CollectionCount);
 arrValueListForInsert.Add(objVideoLibEN.CollectionCount.ToString());
 }
 
 if (objVideoLibEN.RecommendedDegreeId !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.RecommendedDegreeId);
 var strRecommendedDegreeId = objVideoLibEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRecommendedDegreeId + "'");
 }
 
 if (objVideoLibEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.CourseId);
 var strCourseId = objVideoLibEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objVideoLibEN.VideoUrl !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.VideoUrl);
 var strVideoUrl = objVideoLibEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoUrl + "'");
 }
 
 if (objVideoLibEN.VideoPath !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.VideoPath);
 var strVideoPath = objVideoLibEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoPath + "'");
 }
 
 if (objVideoLibEN.CoverPicUrl !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.CoverPicUrl);
 var strCoverPicUrl = objVideoLibEN.CoverPicUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCoverPicUrl + "'");
 }
 
 if (objVideoLibEN.CoverPicShortUrl !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.CoverPicShortUrl);
 var strCoverPicShortUrl = objVideoLibEN.CoverPicShortUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCoverPicShortUrl + "'");
 }
 
 if (objVideoLibEN.ResErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.ResErrMsg);
 var strResErrMsg = objVideoLibEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResErrMsg + "'");
 }
 
 if (objVideoLibEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.UpdDate);
 var strUpdDate = objVideoLibEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objVideoLibEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.UpdUserId);
 var strUpdUserId = objVideoLibEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objVideoLibEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.Memo);
 var strMemo = objVideoLibEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into VideoLib");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoLibDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objVideoLibEN.IdVideoLib;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objVideoLibEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsVideoLibEN objVideoLibEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objVideoLibEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objVideoLibEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objVideoLibEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objVideoLibEN.IdVideoLib !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.IdVideoLib);
 var strIdVideoLib = objVideoLibEN.IdVideoLib.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdVideoLib + "'");
 }
 
 if (objVideoLibEN.VideoLibID !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.VideoLibID);
 var strVideoLibID = objVideoLibEN.VideoLibID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoLibID + "'");
 }
 
 if (objVideoLibEN.VideoLibName !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.VideoLibName);
 var strVideoLibName = objVideoLibEN.VideoLibName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoLibName + "'");
 }
 
 if (objVideoLibEN.VideoLibTheme !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.VideoLibTheme);
 var strVideoLibTheme = objVideoLibEN.VideoLibTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoLibTheme + "'");
 }
 
 if (objVideoLibEN.IdVideoLibType !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.IdVideoLibType);
 var strIdVideoLibType = objVideoLibEN.IdVideoLibType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdVideoLibType + "'");
 }
 
 if (objVideoLibEN.VideoLibText !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.VideoLibText);
 var strVideoLibText = objVideoLibEN.VideoLibText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoLibText + "'");
 }
 
 if (objVideoLibEN.VideoLibDate !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.VideoLibDate);
 var strVideoLibDate = objVideoLibEN.VideoLibDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoLibDate + "'");
 }
 
 if (objVideoLibEN.VideoLibTime !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.VideoLibTime);
 var strVideoLibTime = objVideoLibEN.VideoLibTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoLibTime + "'");
 }
 
 if (objVideoLibEN.VideoLibDateIn !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.VideoLibDateIn);
 var strVideoLibDateIn = objVideoLibEN.VideoLibDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoLibDateIn + "'");
 }
 
 if (objVideoLibEN.VideoLibTimeIn !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.VideoLibTimeIn);
 var strVideoLibTimeIn = objVideoLibEN.VideoLibTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoLibTimeIn + "'");
 }
 
 if (objVideoLibEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.OwnerId);
 var strOwnerId = objVideoLibEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 if (objVideoLibEN.IdTeachingPlan !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.IdTeachingPlan);
 var strIdTeachingPlan = objVideoLibEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachingPlan + "'");
 }
 
 if (objVideoLibEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.BrowseCount);
 arrValueListForInsert.Add(objVideoLibEN.BrowseCount.ToString());
 }
 
 if (objVideoLibEN.IdSenateGaugeVersion  ==  "")
 {
 objVideoLibEN.IdSenateGaugeVersion = null;
 }
 if (objVideoLibEN.IdSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.IdSenateGaugeVersion);
 var strIdSenateGaugeVersion = objVideoLibEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeVersion + "'");
 }
 
 if (objVideoLibEN.CaseLevelId !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.CaseLevelId);
 var strCaseLevelId = objVideoLibEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseLevelId + "'");
 }
 
 arrFieldListForInsert.Add(conVideoLib.IsVisible);
 arrValueListForInsert.Add("'" + (objVideoLibEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objVideoLibEN.IdXzCollege !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.IdXzCollege);
 var strIdXzCollege = objVideoLibEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzCollege + "'");
 }
 
 if (objVideoLibEN.ViewCount !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.ViewCount);
 arrValueListForInsert.Add(objVideoLibEN.ViewCount.ToString());
 }
 
 if (objVideoLibEN.DownloadNumber !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.DownloadNumber);
 arrValueListForInsert.Add(objVideoLibEN.DownloadNumber.ToString());
 }
 
 if (objVideoLibEN.FileIntegration !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.FileIntegration);
 arrValueListForInsert.Add(objVideoLibEN.FileIntegration.ToString());
 }
 
 if (objVideoLibEN.LikeCount !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.LikeCount);
 arrValueListForInsert.Add(objVideoLibEN.LikeCount.ToString());
 }
 
 if (objVideoLibEN.CollectionCount !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.CollectionCount);
 arrValueListForInsert.Add(objVideoLibEN.CollectionCount.ToString());
 }
 
 if (objVideoLibEN.RecommendedDegreeId !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.RecommendedDegreeId);
 var strRecommendedDegreeId = objVideoLibEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRecommendedDegreeId + "'");
 }
 
 if (objVideoLibEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.CourseId);
 var strCourseId = objVideoLibEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objVideoLibEN.VideoUrl !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.VideoUrl);
 var strVideoUrl = objVideoLibEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoUrl + "'");
 }
 
 if (objVideoLibEN.VideoPath !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.VideoPath);
 var strVideoPath = objVideoLibEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoPath + "'");
 }
 
 if (objVideoLibEN.CoverPicUrl !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.CoverPicUrl);
 var strCoverPicUrl = objVideoLibEN.CoverPicUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCoverPicUrl + "'");
 }
 
 if (objVideoLibEN.CoverPicShortUrl !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.CoverPicShortUrl);
 var strCoverPicShortUrl = objVideoLibEN.CoverPicShortUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCoverPicShortUrl + "'");
 }
 
 if (objVideoLibEN.ResErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.ResErrMsg);
 var strResErrMsg = objVideoLibEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResErrMsg + "'");
 }
 
 if (objVideoLibEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.UpdDate);
 var strUpdDate = objVideoLibEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objVideoLibEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.UpdUserId);
 var strUpdUserId = objVideoLibEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objVideoLibEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.Memo);
 var strMemo = objVideoLibEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into VideoLib");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoLibDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objVideoLibEN.IdVideoLib;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objVideoLibEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsVideoLibEN objVideoLibEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objVideoLibEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objVideoLibEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objVideoLibEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objVideoLibEN.IdVideoLib !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.IdVideoLib);
 var strIdVideoLib = objVideoLibEN.IdVideoLib.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdVideoLib + "'");
 }
 
 if (objVideoLibEN.VideoLibID !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.VideoLibID);
 var strVideoLibID = objVideoLibEN.VideoLibID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoLibID + "'");
 }
 
 if (objVideoLibEN.VideoLibName !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.VideoLibName);
 var strVideoLibName = objVideoLibEN.VideoLibName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoLibName + "'");
 }
 
 if (objVideoLibEN.VideoLibTheme !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.VideoLibTheme);
 var strVideoLibTheme = objVideoLibEN.VideoLibTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoLibTheme + "'");
 }
 
 if (objVideoLibEN.IdVideoLibType !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.IdVideoLibType);
 var strIdVideoLibType = objVideoLibEN.IdVideoLibType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdVideoLibType + "'");
 }
 
 if (objVideoLibEN.VideoLibText !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.VideoLibText);
 var strVideoLibText = objVideoLibEN.VideoLibText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoLibText + "'");
 }
 
 if (objVideoLibEN.VideoLibDate !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.VideoLibDate);
 var strVideoLibDate = objVideoLibEN.VideoLibDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoLibDate + "'");
 }
 
 if (objVideoLibEN.VideoLibTime !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.VideoLibTime);
 var strVideoLibTime = objVideoLibEN.VideoLibTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoLibTime + "'");
 }
 
 if (objVideoLibEN.VideoLibDateIn !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.VideoLibDateIn);
 var strVideoLibDateIn = objVideoLibEN.VideoLibDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoLibDateIn + "'");
 }
 
 if (objVideoLibEN.VideoLibTimeIn !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.VideoLibTimeIn);
 var strVideoLibTimeIn = objVideoLibEN.VideoLibTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoLibTimeIn + "'");
 }
 
 if (objVideoLibEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.OwnerId);
 var strOwnerId = objVideoLibEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 if (objVideoLibEN.IdTeachingPlan !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.IdTeachingPlan);
 var strIdTeachingPlan = objVideoLibEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachingPlan + "'");
 }
 
 if (objVideoLibEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.BrowseCount);
 arrValueListForInsert.Add(objVideoLibEN.BrowseCount.ToString());
 }
 
 if (objVideoLibEN.IdSenateGaugeVersion  ==  "")
 {
 objVideoLibEN.IdSenateGaugeVersion = null;
 }
 if (objVideoLibEN.IdSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.IdSenateGaugeVersion);
 var strIdSenateGaugeVersion = objVideoLibEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeVersion + "'");
 }
 
 if (objVideoLibEN.CaseLevelId !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.CaseLevelId);
 var strCaseLevelId = objVideoLibEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseLevelId + "'");
 }
 
 arrFieldListForInsert.Add(conVideoLib.IsVisible);
 arrValueListForInsert.Add("'" + (objVideoLibEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objVideoLibEN.IdXzCollege !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.IdXzCollege);
 var strIdXzCollege = objVideoLibEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzCollege + "'");
 }
 
 if (objVideoLibEN.ViewCount !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.ViewCount);
 arrValueListForInsert.Add(objVideoLibEN.ViewCount.ToString());
 }
 
 if (objVideoLibEN.DownloadNumber !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.DownloadNumber);
 arrValueListForInsert.Add(objVideoLibEN.DownloadNumber.ToString());
 }
 
 if (objVideoLibEN.FileIntegration !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.FileIntegration);
 arrValueListForInsert.Add(objVideoLibEN.FileIntegration.ToString());
 }
 
 if (objVideoLibEN.LikeCount !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.LikeCount);
 arrValueListForInsert.Add(objVideoLibEN.LikeCount.ToString());
 }
 
 if (objVideoLibEN.CollectionCount !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.CollectionCount);
 arrValueListForInsert.Add(objVideoLibEN.CollectionCount.ToString());
 }
 
 if (objVideoLibEN.RecommendedDegreeId !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.RecommendedDegreeId);
 var strRecommendedDegreeId = objVideoLibEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRecommendedDegreeId + "'");
 }
 
 if (objVideoLibEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.CourseId);
 var strCourseId = objVideoLibEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objVideoLibEN.VideoUrl !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.VideoUrl);
 var strVideoUrl = objVideoLibEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoUrl + "'");
 }
 
 if (objVideoLibEN.VideoPath !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.VideoPath);
 var strVideoPath = objVideoLibEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoPath + "'");
 }
 
 if (objVideoLibEN.CoverPicUrl !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.CoverPicUrl);
 var strCoverPicUrl = objVideoLibEN.CoverPicUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCoverPicUrl + "'");
 }
 
 if (objVideoLibEN.CoverPicShortUrl !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.CoverPicShortUrl);
 var strCoverPicShortUrl = objVideoLibEN.CoverPicShortUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCoverPicShortUrl + "'");
 }
 
 if (objVideoLibEN.ResErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.ResErrMsg);
 var strResErrMsg = objVideoLibEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResErrMsg + "'");
 }
 
 if (objVideoLibEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.UpdDate);
 var strUpdDate = objVideoLibEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objVideoLibEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.UpdUserId);
 var strUpdUserId = objVideoLibEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objVideoLibEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conVideoLib.Memo);
 var strMemo = objVideoLibEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into VideoLib");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoLibDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewVideoLibs(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoLibDA.GetSpecSQLObj();
strSQL = "Select * from VideoLib where IdVideoLib = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "VideoLib");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strIdVideoLib = oRow[conVideoLib.IdVideoLib].ToString().Trim();
if (IsExist(strIdVideoLib))
{
 string strResult = "关键字变量值为:" + string.Format("IdVideoLib = {0}", strIdVideoLib) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsVideoLibEN._CurrTabName ].NewRow();
objRow[conVideoLib.IdVideoLib] = oRow[conVideoLib.IdVideoLib].ToString().Trim(); //视频库流水号
objRow[conVideoLib.VideoLibID] = oRow[conVideoLib.VideoLibID].ToString().Trim(); //视频库ID
objRow[conVideoLib.VideoLibName] = oRow[conVideoLib.VideoLibName].ToString().Trim(); //视频名称
objRow[conVideoLib.VideoLibTheme] = oRow[conVideoLib.VideoLibTheme].ToString().Trim(); //视频库主题词
objRow[conVideoLib.IdVideoLibType] = oRow[conVideoLib.IdVideoLibType].ToString().Trim(); //视频库类型流水号
objRow[conVideoLib.VideoLibText] = oRow[conVideoLib.VideoLibText].ToString().Trim(); //案例文本内容
objRow[conVideoLib.VideoLibDate] = oRow[conVideoLib.VideoLibDate].ToString().Trim(); //视频资源日期
objRow[conVideoLib.VideoLibTime] = oRow[conVideoLib.VideoLibTime].ToString().Trim(); //视频资源时间
objRow[conVideoLib.VideoLibDateIn] = oRow[conVideoLib.VideoLibDateIn].ToString().Trim(); //案例入库日期
objRow[conVideoLib.VideoLibTimeIn] = oRow[conVideoLib.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objRow[conVideoLib.OwnerId] = oRow[conVideoLib.OwnerId].ToString().Trim(); //拥有者Id
objRow[conVideoLib.IdTeachingPlan] = oRow[conVideoLib.IdTeachingPlan].ToString().Trim(); //教案流水号
objRow[conVideoLib.BrowseCount] = oRow[conVideoLib.BrowseCount].ToString().Trim(); //浏览次数
objRow[conVideoLib.IdSenateGaugeVersion] = oRow[conVideoLib.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objRow[conVideoLib.CaseLevelId] = oRow[conVideoLib.CaseLevelId].ToString().Trim(); //课例等级Id
objRow[conVideoLib.IsVisible] = oRow[conVideoLib.IsVisible].ToString().Trim(); //是否显示
objRow[conVideoLib.IdXzCollege] = oRow[conVideoLib.IdXzCollege].ToString().Trim(); //学院流水号
objRow[conVideoLib.ViewCount] = oRow[conVideoLib.ViewCount].ToString().Trim(); //浏览量
objRow[conVideoLib.DownloadNumber] = oRow[conVideoLib.DownloadNumber].ToString().Trim(); //下载数目
objRow[conVideoLib.FileIntegration] = oRow[conVideoLib.FileIntegration].ToString().Trim(); //文件积分
objRow[conVideoLib.LikeCount] = oRow[conVideoLib.LikeCount].ToString().Trim(); //资源喜欢数量
objRow[conVideoLib.CollectionCount] = oRow[conVideoLib.CollectionCount].ToString().Trim(); //收藏数量
objRow[conVideoLib.RecommendedDegreeId] = oRow[conVideoLib.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objRow[conVideoLib.CourseId] = oRow[conVideoLib.CourseId].ToString().Trim(); //课程Id
objRow[conVideoLib.VideoUrl] = oRow[conVideoLib.VideoUrl].ToString().Trim(); //视频Url
objRow[conVideoLib.VideoPath] = oRow[conVideoLib.VideoPath].ToString().Trim(); //视频目录
objRow[conVideoLib.CoverPicUrl] = oRow[conVideoLib.CoverPicUrl].ToString().Trim(); //封面Url
objRow[conVideoLib.CoverPicShortUrl] = oRow[conVideoLib.CoverPicShortUrl].ToString().Trim(); //封面短Url
objRow[conVideoLib.ResErrMsg] = oRow[conVideoLib.ResErrMsg].ToString().Trim(); //资源错误信息
objRow[conVideoLib.UpdDate] = oRow[conVideoLib.UpdDate].ToString().Trim(); //修改日期
objRow[conVideoLib.UpdUserId] = oRow[conVideoLib.UpdUserId].ToString().Trim(); //修改用户Id
objRow[conVideoLib.Memo] = oRow[conVideoLib.Memo].ToString().Trim(); //备注
 objDS.Tables[clsVideoLibEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsVideoLibEN._CurrTabName);
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
 /// <param name = "objVideoLibEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsVideoLibEN objVideoLibEN)
{
 objVideoLibEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objVideoLibEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objVideoLibEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoLibDA.GetSpecSQLObj();
strSQL = "Select * from VideoLib where IdVideoLib = " + "'"+ objVideoLibEN.IdVideoLib+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsVideoLibEN._CurrTabName);
if (objDS.Tables[clsVideoLibEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:IdVideoLib = " + "'"+ objVideoLibEN.IdVideoLib+"'");
return false;
}
objRow = objDS.Tables[clsVideoLibEN._CurrTabName].Rows[0];
 if (objVideoLibEN.IsUpdated(conVideoLib.IdVideoLib))
 {
objRow[conVideoLib.IdVideoLib] = objVideoLibEN.IdVideoLib; //视频库流水号
 }
 if (objVideoLibEN.IsUpdated(conVideoLib.VideoLibID))
 {
objRow[conVideoLib.VideoLibID] = objVideoLibEN.VideoLibID; //视频库ID
 }
 if (objVideoLibEN.IsUpdated(conVideoLib.VideoLibName))
 {
objRow[conVideoLib.VideoLibName] = objVideoLibEN.VideoLibName; //视频名称
 }
 if (objVideoLibEN.IsUpdated(conVideoLib.VideoLibTheme))
 {
objRow[conVideoLib.VideoLibTheme] = objVideoLibEN.VideoLibTheme; //视频库主题词
 }
 if (objVideoLibEN.IsUpdated(conVideoLib.IdVideoLibType))
 {
objRow[conVideoLib.IdVideoLibType] = objVideoLibEN.IdVideoLibType; //视频库类型流水号
 }
 if (objVideoLibEN.IsUpdated(conVideoLib.VideoLibText))
 {
objRow[conVideoLib.VideoLibText] = objVideoLibEN.VideoLibText; //案例文本内容
 }
 if (objVideoLibEN.IsUpdated(conVideoLib.VideoLibDate))
 {
objRow[conVideoLib.VideoLibDate] = objVideoLibEN.VideoLibDate; //视频资源日期
 }
 if (objVideoLibEN.IsUpdated(conVideoLib.VideoLibTime))
 {
objRow[conVideoLib.VideoLibTime] = objVideoLibEN.VideoLibTime; //视频资源时间
 }
 if (objVideoLibEN.IsUpdated(conVideoLib.VideoLibDateIn))
 {
objRow[conVideoLib.VideoLibDateIn] = objVideoLibEN.VideoLibDateIn; //案例入库日期
 }
 if (objVideoLibEN.IsUpdated(conVideoLib.VideoLibTimeIn))
 {
objRow[conVideoLib.VideoLibTimeIn] = objVideoLibEN.VideoLibTimeIn; //案例入库时间
 }
 if (objVideoLibEN.IsUpdated(conVideoLib.OwnerId))
 {
objRow[conVideoLib.OwnerId] = objVideoLibEN.OwnerId; //拥有者Id
 }
 if (objVideoLibEN.IsUpdated(conVideoLib.IdTeachingPlan))
 {
objRow[conVideoLib.IdTeachingPlan] = objVideoLibEN.IdTeachingPlan; //教案流水号
 }
 if (objVideoLibEN.IsUpdated(conVideoLib.BrowseCount))
 {
objRow[conVideoLib.BrowseCount] = objVideoLibEN.BrowseCount; //浏览次数
 }
 if (objVideoLibEN.IsUpdated(conVideoLib.IdSenateGaugeVersion))
 {
objRow[conVideoLib.IdSenateGaugeVersion] = objVideoLibEN.IdSenateGaugeVersion; //评价量表版本流水号
 }
 if (objVideoLibEN.IsUpdated(conVideoLib.CaseLevelId))
 {
objRow[conVideoLib.CaseLevelId] = objVideoLibEN.CaseLevelId; //课例等级Id
 }
 if (objVideoLibEN.IsUpdated(conVideoLib.IsVisible))
 {
objRow[conVideoLib.IsVisible] = objVideoLibEN.IsVisible; //是否显示
 }
 if (objVideoLibEN.IsUpdated(conVideoLib.IdXzCollege))
 {
objRow[conVideoLib.IdXzCollege] = objVideoLibEN.IdXzCollege; //学院流水号
 }
 if (objVideoLibEN.IsUpdated(conVideoLib.ViewCount))
 {
objRow[conVideoLib.ViewCount] = objVideoLibEN.ViewCount; //浏览量
 }
 if (objVideoLibEN.IsUpdated(conVideoLib.DownloadNumber))
 {
objRow[conVideoLib.DownloadNumber] = objVideoLibEN.DownloadNumber; //下载数目
 }
 if (objVideoLibEN.IsUpdated(conVideoLib.FileIntegration))
 {
objRow[conVideoLib.FileIntegration] = objVideoLibEN.FileIntegration; //文件积分
 }
 if (objVideoLibEN.IsUpdated(conVideoLib.LikeCount))
 {
objRow[conVideoLib.LikeCount] = objVideoLibEN.LikeCount; //资源喜欢数量
 }
 if (objVideoLibEN.IsUpdated(conVideoLib.CollectionCount))
 {
objRow[conVideoLib.CollectionCount] = objVideoLibEN.CollectionCount; //收藏数量
 }
 if (objVideoLibEN.IsUpdated(conVideoLib.RecommendedDegreeId))
 {
objRow[conVideoLib.RecommendedDegreeId] = objVideoLibEN.RecommendedDegreeId; //推荐度Id
 }
 if (objVideoLibEN.IsUpdated(conVideoLib.CourseId))
 {
objRow[conVideoLib.CourseId] = objVideoLibEN.CourseId; //课程Id
 }
 if (objVideoLibEN.IsUpdated(conVideoLib.VideoUrl))
 {
objRow[conVideoLib.VideoUrl] = objVideoLibEN.VideoUrl; //视频Url
 }
 if (objVideoLibEN.IsUpdated(conVideoLib.VideoPath))
 {
objRow[conVideoLib.VideoPath] = objVideoLibEN.VideoPath; //视频目录
 }
 if (objVideoLibEN.IsUpdated(conVideoLib.CoverPicUrl))
 {
objRow[conVideoLib.CoverPicUrl] = objVideoLibEN.CoverPicUrl; //封面Url
 }
 if (objVideoLibEN.IsUpdated(conVideoLib.CoverPicShortUrl))
 {
objRow[conVideoLib.CoverPicShortUrl] = objVideoLibEN.CoverPicShortUrl; //封面短Url
 }
 if (objVideoLibEN.IsUpdated(conVideoLib.ResErrMsg))
 {
objRow[conVideoLib.ResErrMsg] = objVideoLibEN.ResErrMsg; //资源错误信息
 }
 if (objVideoLibEN.IsUpdated(conVideoLib.UpdDate))
 {
objRow[conVideoLib.UpdDate] = objVideoLibEN.UpdDate; //修改日期
 }
 if (objVideoLibEN.IsUpdated(conVideoLib.UpdUserId))
 {
objRow[conVideoLib.UpdUserId] = objVideoLibEN.UpdUserId; //修改用户Id
 }
 if (objVideoLibEN.IsUpdated(conVideoLib.Memo))
 {
objRow[conVideoLib.Memo] = objVideoLibEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsVideoLibEN._CurrTabName);
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
 /// <param name = "objVideoLibEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsVideoLibEN objVideoLibEN)
{
 objVideoLibEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objVideoLibEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objVideoLibEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoLibDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update VideoLib Set ");
 
 if (objVideoLibEN.IsUpdated(conVideoLib.VideoLibID))
 {
 if (objVideoLibEN.VideoLibID !=  null)
 {
 var strVideoLibID = objVideoLibEN.VideoLibID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoLibID, conVideoLib.VideoLibID); //视频库ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoLib.VideoLibID); //视频库ID
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.VideoLibName))
 {
 if (objVideoLibEN.VideoLibName !=  null)
 {
 var strVideoLibName = objVideoLibEN.VideoLibName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoLibName, conVideoLib.VideoLibName); //视频名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoLib.VideoLibName); //视频名称
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.VideoLibTheme))
 {
 if (objVideoLibEN.VideoLibTheme !=  null)
 {
 var strVideoLibTheme = objVideoLibEN.VideoLibTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoLibTheme, conVideoLib.VideoLibTheme); //视频库主题词
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoLib.VideoLibTheme); //视频库主题词
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.IdVideoLibType))
 {
 if (objVideoLibEN.IdVideoLibType !=  null)
 {
 var strIdVideoLibType = objVideoLibEN.IdVideoLibType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdVideoLibType, conVideoLib.IdVideoLibType); //视频库类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoLib.IdVideoLibType); //视频库类型流水号
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.VideoLibText))
 {
 if (objVideoLibEN.VideoLibText !=  null)
 {
 var strVideoLibText = objVideoLibEN.VideoLibText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoLibText, conVideoLib.VideoLibText); //案例文本内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoLib.VideoLibText); //案例文本内容
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.VideoLibDate))
 {
 if (objVideoLibEN.VideoLibDate !=  null)
 {
 var strVideoLibDate = objVideoLibEN.VideoLibDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoLibDate, conVideoLib.VideoLibDate); //视频资源日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoLib.VideoLibDate); //视频资源日期
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.VideoLibTime))
 {
 if (objVideoLibEN.VideoLibTime !=  null)
 {
 var strVideoLibTime = objVideoLibEN.VideoLibTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoLibTime, conVideoLib.VideoLibTime); //视频资源时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoLib.VideoLibTime); //视频资源时间
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.VideoLibDateIn))
 {
 if (objVideoLibEN.VideoLibDateIn !=  null)
 {
 var strVideoLibDateIn = objVideoLibEN.VideoLibDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoLibDateIn, conVideoLib.VideoLibDateIn); //案例入库日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoLib.VideoLibDateIn); //案例入库日期
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.VideoLibTimeIn))
 {
 if (objVideoLibEN.VideoLibTimeIn !=  null)
 {
 var strVideoLibTimeIn = objVideoLibEN.VideoLibTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoLibTimeIn, conVideoLib.VideoLibTimeIn); //案例入库时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoLib.VideoLibTimeIn); //案例入库时间
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.OwnerId))
 {
 if (objVideoLibEN.OwnerId !=  null)
 {
 var strOwnerId = objVideoLibEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOwnerId, conVideoLib.OwnerId); //拥有者Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoLib.OwnerId); //拥有者Id
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.IdTeachingPlan))
 {
 if (objVideoLibEN.IdTeachingPlan !=  null)
 {
 var strIdTeachingPlan = objVideoLibEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdTeachingPlan, conVideoLib.IdTeachingPlan); //教案流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoLib.IdTeachingPlan); //教案流水号
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.BrowseCount))
 {
 if (objVideoLibEN.BrowseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objVideoLibEN.BrowseCount, conVideoLib.BrowseCount); //浏览次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoLib.BrowseCount); //浏览次数
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.IdSenateGaugeVersion))
 {
 if (objVideoLibEN.IdSenateGaugeVersion  ==  "")
 {
 objVideoLibEN.IdSenateGaugeVersion = null;
 }
 if (objVideoLibEN.IdSenateGaugeVersion !=  null)
 {
 var strIdSenateGaugeVersion = objVideoLibEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdSenateGaugeVersion, conVideoLib.IdSenateGaugeVersion); //评价量表版本流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoLib.IdSenateGaugeVersion); //评价量表版本流水号
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.CaseLevelId))
 {
 if (objVideoLibEN.CaseLevelId !=  null)
 {
 var strCaseLevelId = objVideoLibEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseLevelId, conVideoLib.CaseLevelId); //课例等级Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoLib.CaseLevelId); //课例等级Id
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.IsVisible))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objVideoLibEN.IsVisible == true?"1":"0", conVideoLib.IsVisible); //是否显示
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.IdXzCollege))
 {
 if (objVideoLibEN.IdXzCollege !=  null)
 {
 var strIdXzCollege = objVideoLibEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdXzCollege, conVideoLib.IdXzCollege); //学院流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoLib.IdXzCollege); //学院流水号
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.ViewCount))
 {
 if (objVideoLibEN.ViewCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objVideoLibEN.ViewCount, conVideoLib.ViewCount); //浏览量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoLib.ViewCount); //浏览量
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.DownloadNumber))
 {
 if (objVideoLibEN.DownloadNumber !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objVideoLibEN.DownloadNumber, conVideoLib.DownloadNumber); //下载数目
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoLib.DownloadNumber); //下载数目
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.FileIntegration))
 {
 if (objVideoLibEN.FileIntegration !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objVideoLibEN.FileIntegration, conVideoLib.FileIntegration); //文件积分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoLib.FileIntegration); //文件积分
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.LikeCount))
 {
 if (objVideoLibEN.LikeCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objVideoLibEN.LikeCount, conVideoLib.LikeCount); //资源喜欢数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoLib.LikeCount); //资源喜欢数量
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.CollectionCount))
 {
 if (objVideoLibEN.CollectionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objVideoLibEN.CollectionCount, conVideoLib.CollectionCount); //收藏数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoLib.CollectionCount); //收藏数量
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.RecommendedDegreeId))
 {
 if (objVideoLibEN.RecommendedDegreeId !=  null)
 {
 var strRecommendedDegreeId = objVideoLibEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRecommendedDegreeId, conVideoLib.RecommendedDegreeId); //推荐度Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoLib.RecommendedDegreeId); //推荐度Id
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.CourseId))
 {
 if (objVideoLibEN.CourseId !=  null)
 {
 var strCourseId = objVideoLibEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, conVideoLib.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoLib.CourseId); //课程Id
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.VideoUrl))
 {
 if (objVideoLibEN.VideoUrl !=  null)
 {
 var strVideoUrl = objVideoLibEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoUrl, conVideoLib.VideoUrl); //视频Url
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoLib.VideoUrl); //视频Url
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.VideoPath))
 {
 if (objVideoLibEN.VideoPath !=  null)
 {
 var strVideoPath = objVideoLibEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoPath, conVideoLib.VideoPath); //视频目录
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoLib.VideoPath); //视频目录
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.CoverPicUrl))
 {
 if (objVideoLibEN.CoverPicUrl !=  null)
 {
 var strCoverPicUrl = objVideoLibEN.CoverPicUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCoverPicUrl, conVideoLib.CoverPicUrl); //封面Url
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoLib.CoverPicUrl); //封面Url
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.CoverPicShortUrl))
 {
 if (objVideoLibEN.CoverPicShortUrl !=  null)
 {
 var strCoverPicShortUrl = objVideoLibEN.CoverPicShortUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCoverPicShortUrl, conVideoLib.CoverPicShortUrl); //封面短Url
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoLib.CoverPicShortUrl); //封面短Url
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.ResErrMsg))
 {
 if (objVideoLibEN.ResErrMsg !=  null)
 {
 var strResErrMsg = objVideoLibEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResErrMsg, conVideoLib.ResErrMsg); //资源错误信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoLib.ResErrMsg); //资源错误信息
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.UpdDate))
 {
 if (objVideoLibEN.UpdDate !=  null)
 {
 var strUpdDate = objVideoLibEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conVideoLib.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoLib.UpdDate); //修改日期
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.UpdUserId))
 {
 if (objVideoLibEN.UpdUserId !=  null)
 {
 var strUpdUserId = objVideoLibEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conVideoLib.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoLib.UpdUserId); //修改用户Id
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.Memo))
 {
 if (objVideoLibEN.Memo !=  null)
 {
 var strMemo = objVideoLibEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conVideoLib.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoLib.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdVideoLib = '{0}'", objVideoLibEN.IdVideoLib); 
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
 /// <param name = "objVideoLibEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsVideoLibEN objVideoLibEN, string strCondition)
{
 objVideoLibEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objVideoLibEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objVideoLibEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoLibDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update VideoLib Set ");
 
 if (objVideoLibEN.IsUpdated(conVideoLib.VideoLibID))
 {
 if (objVideoLibEN.VideoLibID !=  null)
 {
 var strVideoLibID = objVideoLibEN.VideoLibID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoLibID = '{0}',", strVideoLibID); //视频库ID
 }
 else
 {
 sbSQL.Append(" VideoLibID = null,"); //视频库ID
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.VideoLibName))
 {
 if (objVideoLibEN.VideoLibName !=  null)
 {
 var strVideoLibName = objVideoLibEN.VideoLibName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoLibName = '{0}',", strVideoLibName); //视频名称
 }
 else
 {
 sbSQL.Append(" VideoLibName = null,"); //视频名称
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.VideoLibTheme))
 {
 if (objVideoLibEN.VideoLibTheme !=  null)
 {
 var strVideoLibTheme = objVideoLibEN.VideoLibTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoLibTheme = '{0}',", strVideoLibTheme); //视频库主题词
 }
 else
 {
 sbSQL.Append(" VideoLibTheme = null,"); //视频库主题词
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.IdVideoLibType))
 {
 if (objVideoLibEN.IdVideoLibType !=  null)
 {
 var strIdVideoLibType = objVideoLibEN.IdVideoLibType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdVideoLibType = '{0}',", strIdVideoLibType); //视频库类型流水号
 }
 else
 {
 sbSQL.Append(" IdVideoLibType = null,"); //视频库类型流水号
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.VideoLibText))
 {
 if (objVideoLibEN.VideoLibText !=  null)
 {
 var strVideoLibText = objVideoLibEN.VideoLibText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoLibText = '{0}',", strVideoLibText); //案例文本内容
 }
 else
 {
 sbSQL.Append(" VideoLibText = null,"); //案例文本内容
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.VideoLibDate))
 {
 if (objVideoLibEN.VideoLibDate !=  null)
 {
 var strVideoLibDate = objVideoLibEN.VideoLibDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoLibDate = '{0}',", strVideoLibDate); //视频资源日期
 }
 else
 {
 sbSQL.Append(" VideoLibDate = null,"); //视频资源日期
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.VideoLibTime))
 {
 if (objVideoLibEN.VideoLibTime !=  null)
 {
 var strVideoLibTime = objVideoLibEN.VideoLibTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoLibTime = '{0}',", strVideoLibTime); //视频资源时间
 }
 else
 {
 sbSQL.Append(" VideoLibTime = null,"); //视频资源时间
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.VideoLibDateIn))
 {
 if (objVideoLibEN.VideoLibDateIn !=  null)
 {
 var strVideoLibDateIn = objVideoLibEN.VideoLibDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoLibDateIn = '{0}',", strVideoLibDateIn); //案例入库日期
 }
 else
 {
 sbSQL.Append(" VideoLibDateIn = null,"); //案例入库日期
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.VideoLibTimeIn))
 {
 if (objVideoLibEN.VideoLibTimeIn !=  null)
 {
 var strVideoLibTimeIn = objVideoLibEN.VideoLibTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoLibTimeIn = '{0}',", strVideoLibTimeIn); //案例入库时间
 }
 else
 {
 sbSQL.Append(" VideoLibTimeIn = null,"); //案例入库时间
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.OwnerId))
 {
 if (objVideoLibEN.OwnerId !=  null)
 {
 var strOwnerId = objVideoLibEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OwnerId = '{0}',", strOwnerId); //拥有者Id
 }
 else
 {
 sbSQL.Append(" OwnerId = null,"); //拥有者Id
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.IdTeachingPlan))
 {
 if (objVideoLibEN.IdTeachingPlan !=  null)
 {
 var strIdTeachingPlan = objVideoLibEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdTeachingPlan = '{0}',", strIdTeachingPlan); //教案流水号
 }
 else
 {
 sbSQL.Append(" IdTeachingPlan = null,"); //教案流水号
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.BrowseCount))
 {
 sbSQL.AppendFormat(" BrowseCount = {0},", objVideoLibEN.BrowseCount); //浏览次数
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.IdSenateGaugeVersion))
 {
 if (objVideoLibEN.IdSenateGaugeVersion  ==  "")
 {
 objVideoLibEN.IdSenateGaugeVersion = null;
 }
 if (objVideoLibEN.IdSenateGaugeVersion !=  null)
 {
 var strIdSenateGaugeVersion = objVideoLibEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdSenateGaugeVersion = '{0}',", strIdSenateGaugeVersion); //评价量表版本流水号
 }
 else
 {
 sbSQL.Append(" IdSenateGaugeVersion = null,"); //评价量表版本流水号
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.CaseLevelId))
 {
 if (objVideoLibEN.CaseLevelId !=  null)
 {
 var strCaseLevelId = objVideoLibEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseLevelId = '{0}',", strCaseLevelId); //课例等级Id
 }
 else
 {
 sbSQL.Append(" CaseLevelId = null,"); //课例等级Id
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.IsVisible))
 {
 sbSQL.AppendFormat(" IsVisible = '{0}',", objVideoLibEN.IsVisible == true?"1":"0"); //是否显示
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.IdXzCollege))
 {
 if (objVideoLibEN.IdXzCollege !=  null)
 {
 var strIdXzCollege = objVideoLibEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdXzCollege = '{0}',", strIdXzCollege); //学院流水号
 }
 else
 {
 sbSQL.Append(" IdXzCollege = null,"); //学院流水号
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.ViewCount))
 {
 sbSQL.AppendFormat(" ViewCount = {0},", objVideoLibEN.ViewCount); //浏览量
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.DownloadNumber))
 {
 sbSQL.AppendFormat(" DownloadNumber = {0},", objVideoLibEN.DownloadNumber); //下载数目
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.FileIntegration))
 {
 sbSQL.AppendFormat(" FileIntegration = {0},", objVideoLibEN.FileIntegration); //文件积分
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.LikeCount))
 {
 sbSQL.AppendFormat(" LikeCount = {0},", objVideoLibEN.LikeCount); //资源喜欢数量
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.CollectionCount))
 {
 sbSQL.AppendFormat(" CollectionCount = {0},", objVideoLibEN.CollectionCount); //收藏数量
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.RecommendedDegreeId))
 {
 if (objVideoLibEN.RecommendedDegreeId !=  null)
 {
 var strRecommendedDegreeId = objVideoLibEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RecommendedDegreeId = '{0}',", strRecommendedDegreeId); //推荐度Id
 }
 else
 {
 sbSQL.Append(" RecommendedDegreeId = null,"); //推荐度Id
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.CourseId))
 {
 if (objVideoLibEN.CourseId !=  null)
 {
 var strCourseId = objVideoLibEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.VideoUrl))
 {
 if (objVideoLibEN.VideoUrl !=  null)
 {
 var strVideoUrl = objVideoLibEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoUrl = '{0}',", strVideoUrl); //视频Url
 }
 else
 {
 sbSQL.Append(" VideoUrl = null,"); //视频Url
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.VideoPath))
 {
 if (objVideoLibEN.VideoPath !=  null)
 {
 var strVideoPath = objVideoLibEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoPath = '{0}',", strVideoPath); //视频目录
 }
 else
 {
 sbSQL.Append(" VideoPath = null,"); //视频目录
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.CoverPicUrl))
 {
 if (objVideoLibEN.CoverPicUrl !=  null)
 {
 var strCoverPicUrl = objVideoLibEN.CoverPicUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CoverPicUrl = '{0}',", strCoverPicUrl); //封面Url
 }
 else
 {
 sbSQL.Append(" CoverPicUrl = null,"); //封面Url
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.CoverPicShortUrl))
 {
 if (objVideoLibEN.CoverPicShortUrl !=  null)
 {
 var strCoverPicShortUrl = objVideoLibEN.CoverPicShortUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CoverPicShortUrl = '{0}',", strCoverPicShortUrl); //封面短Url
 }
 else
 {
 sbSQL.Append(" CoverPicShortUrl = null,"); //封面短Url
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.ResErrMsg))
 {
 if (objVideoLibEN.ResErrMsg !=  null)
 {
 var strResErrMsg = objVideoLibEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResErrMsg = '{0}',", strResErrMsg); //资源错误信息
 }
 else
 {
 sbSQL.Append(" ResErrMsg = null,"); //资源错误信息
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.UpdDate))
 {
 if (objVideoLibEN.UpdDate !=  null)
 {
 var strUpdDate = objVideoLibEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.UpdUserId))
 {
 if (objVideoLibEN.UpdUserId !=  null)
 {
 var strUpdUserId = objVideoLibEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.Memo))
 {
 if (objVideoLibEN.Memo !=  null)
 {
 var strMemo = objVideoLibEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objVideoLibEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsVideoLibEN objVideoLibEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objVideoLibEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objVideoLibEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objVideoLibEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoLibDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update VideoLib Set ");
 
 if (objVideoLibEN.IsUpdated(conVideoLib.VideoLibID))
 {
 if (objVideoLibEN.VideoLibID !=  null)
 {
 var strVideoLibID = objVideoLibEN.VideoLibID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoLibID = '{0}',", strVideoLibID); //视频库ID
 }
 else
 {
 sbSQL.Append(" VideoLibID = null,"); //视频库ID
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.VideoLibName))
 {
 if (objVideoLibEN.VideoLibName !=  null)
 {
 var strVideoLibName = objVideoLibEN.VideoLibName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoLibName = '{0}',", strVideoLibName); //视频名称
 }
 else
 {
 sbSQL.Append(" VideoLibName = null,"); //视频名称
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.VideoLibTheme))
 {
 if (objVideoLibEN.VideoLibTheme !=  null)
 {
 var strVideoLibTheme = objVideoLibEN.VideoLibTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoLibTheme = '{0}',", strVideoLibTheme); //视频库主题词
 }
 else
 {
 sbSQL.Append(" VideoLibTheme = null,"); //视频库主题词
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.IdVideoLibType))
 {
 if (objVideoLibEN.IdVideoLibType !=  null)
 {
 var strIdVideoLibType = objVideoLibEN.IdVideoLibType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdVideoLibType = '{0}',", strIdVideoLibType); //视频库类型流水号
 }
 else
 {
 sbSQL.Append(" IdVideoLibType = null,"); //视频库类型流水号
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.VideoLibText))
 {
 if (objVideoLibEN.VideoLibText !=  null)
 {
 var strVideoLibText = objVideoLibEN.VideoLibText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoLibText = '{0}',", strVideoLibText); //案例文本内容
 }
 else
 {
 sbSQL.Append(" VideoLibText = null,"); //案例文本内容
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.VideoLibDate))
 {
 if (objVideoLibEN.VideoLibDate !=  null)
 {
 var strVideoLibDate = objVideoLibEN.VideoLibDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoLibDate = '{0}',", strVideoLibDate); //视频资源日期
 }
 else
 {
 sbSQL.Append(" VideoLibDate = null,"); //视频资源日期
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.VideoLibTime))
 {
 if (objVideoLibEN.VideoLibTime !=  null)
 {
 var strVideoLibTime = objVideoLibEN.VideoLibTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoLibTime = '{0}',", strVideoLibTime); //视频资源时间
 }
 else
 {
 sbSQL.Append(" VideoLibTime = null,"); //视频资源时间
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.VideoLibDateIn))
 {
 if (objVideoLibEN.VideoLibDateIn !=  null)
 {
 var strVideoLibDateIn = objVideoLibEN.VideoLibDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoLibDateIn = '{0}',", strVideoLibDateIn); //案例入库日期
 }
 else
 {
 sbSQL.Append(" VideoLibDateIn = null,"); //案例入库日期
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.VideoLibTimeIn))
 {
 if (objVideoLibEN.VideoLibTimeIn !=  null)
 {
 var strVideoLibTimeIn = objVideoLibEN.VideoLibTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoLibTimeIn = '{0}',", strVideoLibTimeIn); //案例入库时间
 }
 else
 {
 sbSQL.Append(" VideoLibTimeIn = null,"); //案例入库时间
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.OwnerId))
 {
 if (objVideoLibEN.OwnerId !=  null)
 {
 var strOwnerId = objVideoLibEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OwnerId = '{0}',", strOwnerId); //拥有者Id
 }
 else
 {
 sbSQL.Append(" OwnerId = null,"); //拥有者Id
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.IdTeachingPlan))
 {
 if (objVideoLibEN.IdTeachingPlan !=  null)
 {
 var strIdTeachingPlan = objVideoLibEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdTeachingPlan = '{0}',", strIdTeachingPlan); //教案流水号
 }
 else
 {
 sbSQL.Append(" IdTeachingPlan = null,"); //教案流水号
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.BrowseCount))
 {
 sbSQL.AppendFormat(" BrowseCount = {0},", objVideoLibEN.BrowseCount); //浏览次数
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.IdSenateGaugeVersion))
 {
 if (objVideoLibEN.IdSenateGaugeVersion  ==  "")
 {
 objVideoLibEN.IdSenateGaugeVersion = null;
 }
 if (objVideoLibEN.IdSenateGaugeVersion !=  null)
 {
 var strIdSenateGaugeVersion = objVideoLibEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdSenateGaugeVersion = '{0}',", strIdSenateGaugeVersion); //评价量表版本流水号
 }
 else
 {
 sbSQL.Append(" IdSenateGaugeVersion = null,"); //评价量表版本流水号
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.CaseLevelId))
 {
 if (objVideoLibEN.CaseLevelId !=  null)
 {
 var strCaseLevelId = objVideoLibEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseLevelId = '{0}',", strCaseLevelId); //课例等级Id
 }
 else
 {
 sbSQL.Append(" CaseLevelId = null,"); //课例等级Id
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.IsVisible))
 {
 sbSQL.AppendFormat(" IsVisible = '{0}',", objVideoLibEN.IsVisible == true?"1":"0"); //是否显示
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.IdXzCollege))
 {
 if (objVideoLibEN.IdXzCollege !=  null)
 {
 var strIdXzCollege = objVideoLibEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdXzCollege = '{0}',", strIdXzCollege); //学院流水号
 }
 else
 {
 sbSQL.Append(" IdXzCollege = null,"); //学院流水号
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.ViewCount))
 {
 sbSQL.AppendFormat(" ViewCount = {0},", objVideoLibEN.ViewCount); //浏览量
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.DownloadNumber))
 {
 sbSQL.AppendFormat(" DownloadNumber = {0},", objVideoLibEN.DownloadNumber); //下载数目
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.FileIntegration))
 {
 sbSQL.AppendFormat(" FileIntegration = {0},", objVideoLibEN.FileIntegration); //文件积分
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.LikeCount))
 {
 sbSQL.AppendFormat(" LikeCount = {0},", objVideoLibEN.LikeCount); //资源喜欢数量
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.CollectionCount))
 {
 sbSQL.AppendFormat(" CollectionCount = {0},", objVideoLibEN.CollectionCount); //收藏数量
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.RecommendedDegreeId))
 {
 if (objVideoLibEN.RecommendedDegreeId !=  null)
 {
 var strRecommendedDegreeId = objVideoLibEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RecommendedDegreeId = '{0}',", strRecommendedDegreeId); //推荐度Id
 }
 else
 {
 sbSQL.Append(" RecommendedDegreeId = null,"); //推荐度Id
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.CourseId))
 {
 if (objVideoLibEN.CourseId !=  null)
 {
 var strCourseId = objVideoLibEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.VideoUrl))
 {
 if (objVideoLibEN.VideoUrl !=  null)
 {
 var strVideoUrl = objVideoLibEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoUrl = '{0}',", strVideoUrl); //视频Url
 }
 else
 {
 sbSQL.Append(" VideoUrl = null,"); //视频Url
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.VideoPath))
 {
 if (objVideoLibEN.VideoPath !=  null)
 {
 var strVideoPath = objVideoLibEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoPath = '{0}',", strVideoPath); //视频目录
 }
 else
 {
 sbSQL.Append(" VideoPath = null,"); //视频目录
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.CoverPicUrl))
 {
 if (objVideoLibEN.CoverPicUrl !=  null)
 {
 var strCoverPicUrl = objVideoLibEN.CoverPicUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CoverPicUrl = '{0}',", strCoverPicUrl); //封面Url
 }
 else
 {
 sbSQL.Append(" CoverPicUrl = null,"); //封面Url
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.CoverPicShortUrl))
 {
 if (objVideoLibEN.CoverPicShortUrl !=  null)
 {
 var strCoverPicShortUrl = objVideoLibEN.CoverPicShortUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CoverPicShortUrl = '{0}',", strCoverPicShortUrl); //封面短Url
 }
 else
 {
 sbSQL.Append(" CoverPicShortUrl = null,"); //封面短Url
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.ResErrMsg))
 {
 if (objVideoLibEN.ResErrMsg !=  null)
 {
 var strResErrMsg = objVideoLibEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResErrMsg = '{0}',", strResErrMsg); //资源错误信息
 }
 else
 {
 sbSQL.Append(" ResErrMsg = null,"); //资源错误信息
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.UpdDate))
 {
 if (objVideoLibEN.UpdDate !=  null)
 {
 var strUpdDate = objVideoLibEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.UpdUserId))
 {
 if (objVideoLibEN.UpdUserId !=  null)
 {
 var strUpdUserId = objVideoLibEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.Memo))
 {
 if (objVideoLibEN.Memo !=  null)
 {
 var strMemo = objVideoLibEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objVideoLibEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsVideoLibEN objVideoLibEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objVideoLibEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objVideoLibEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objVideoLibEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoLibDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update VideoLib Set ");
 
 if (objVideoLibEN.IsUpdated(conVideoLib.VideoLibID))
 {
 if (objVideoLibEN.VideoLibID !=  null)
 {
 var strVideoLibID = objVideoLibEN.VideoLibID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoLibID, conVideoLib.VideoLibID); //视频库ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoLib.VideoLibID); //视频库ID
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.VideoLibName))
 {
 if (objVideoLibEN.VideoLibName !=  null)
 {
 var strVideoLibName = objVideoLibEN.VideoLibName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoLibName, conVideoLib.VideoLibName); //视频名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoLib.VideoLibName); //视频名称
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.VideoLibTheme))
 {
 if (objVideoLibEN.VideoLibTheme !=  null)
 {
 var strVideoLibTheme = objVideoLibEN.VideoLibTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoLibTheme, conVideoLib.VideoLibTheme); //视频库主题词
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoLib.VideoLibTheme); //视频库主题词
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.IdVideoLibType))
 {
 if (objVideoLibEN.IdVideoLibType !=  null)
 {
 var strIdVideoLibType = objVideoLibEN.IdVideoLibType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdVideoLibType, conVideoLib.IdVideoLibType); //视频库类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoLib.IdVideoLibType); //视频库类型流水号
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.VideoLibText))
 {
 if (objVideoLibEN.VideoLibText !=  null)
 {
 var strVideoLibText = objVideoLibEN.VideoLibText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoLibText, conVideoLib.VideoLibText); //案例文本内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoLib.VideoLibText); //案例文本内容
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.VideoLibDate))
 {
 if (objVideoLibEN.VideoLibDate !=  null)
 {
 var strVideoLibDate = objVideoLibEN.VideoLibDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoLibDate, conVideoLib.VideoLibDate); //视频资源日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoLib.VideoLibDate); //视频资源日期
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.VideoLibTime))
 {
 if (objVideoLibEN.VideoLibTime !=  null)
 {
 var strVideoLibTime = objVideoLibEN.VideoLibTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoLibTime, conVideoLib.VideoLibTime); //视频资源时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoLib.VideoLibTime); //视频资源时间
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.VideoLibDateIn))
 {
 if (objVideoLibEN.VideoLibDateIn !=  null)
 {
 var strVideoLibDateIn = objVideoLibEN.VideoLibDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoLibDateIn, conVideoLib.VideoLibDateIn); //案例入库日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoLib.VideoLibDateIn); //案例入库日期
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.VideoLibTimeIn))
 {
 if (objVideoLibEN.VideoLibTimeIn !=  null)
 {
 var strVideoLibTimeIn = objVideoLibEN.VideoLibTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoLibTimeIn, conVideoLib.VideoLibTimeIn); //案例入库时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoLib.VideoLibTimeIn); //案例入库时间
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.OwnerId))
 {
 if (objVideoLibEN.OwnerId !=  null)
 {
 var strOwnerId = objVideoLibEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOwnerId, conVideoLib.OwnerId); //拥有者Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoLib.OwnerId); //拥有者Id
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.IdTeachingPlan))
 {
 if (objVideoLibEN.IdTeachingPlan !=  null)
 {
 var strIdTeachingPlan = objVideoLibEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdTeachingPlan, conVideoLib.IdTeachingPlan); //教案流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoLib.IdTeachingPlan); //教案流水号
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.BrowseCount))
 {
 if (objVideoLibEN.BrowseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objVideoLibEN.BrowseCount, conVideoLib.BrowseCount); //浏览次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoLib.BrowseCount); //浏览次数
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.IdSenateGaugeVersion))
 {
 if (objVideoLibEN.IdSenateGaugeVersion  ==  "")
 {
 objVideoLibEN.IdSenateGaugeVersion = null;
 }
 if (objVideoLibEN.IdSenateGaugeVersion !=  null)
 {
 var strIdSenateGaugeVersion = objVideoLibEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdSenateGaugeVersion, conVideoLib.IdSenateGaugeVersion); //评价量表版本流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoLib.IdSenateGaugeVersion); //评价量表版本流水号
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.CaseLevelId))
 {
 if (objVideoLibEN.CaseLevelId !=  null)
 {
 var strCaseLevelId = objVideoLibEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseLevelId, conVideoLib.CaseLevelId); //课例等级Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoLib.CaseLevelId); //课例等级Id
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.IsVisible))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objVideoLibEN.IsVisible == true?"1":"0", conVideoLib.IsVisible); //是否显示
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.IdXzCollege))
 {
 if (objVideoLibEN.IdXzCollege !=  null)
 {
 var strIdXzCollege = objVideoLibEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdXzCollege, conVideoLib.IdXzCollege); //学院流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoLib.IdXzCollege); //学院流水号
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.ViewCount))
 {
 if (objVideoLibEN.ViewCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objVideoLibEN.ViewCount, conVideoLib.ViewCount); //浏览量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoLib.ViewCount); //浏览量
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.DownloadNumber))
 {
 if (objVideoLibEN.DownloadNumber !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objVideoLibEN.DownloadNumber, conVideoLib.DownloadNumber); //下载数目
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoLib.DownloadNumber); //下载数目
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.FileIntegration))
 {
 if (objVideoLibEN.FileIntegration !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objVideoLibEN.FileIntegration, conVideoLib.FileIntegration); //文件积分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoLib.FileIntegration); //文件积分
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.LikeCount))
 {
 if (objVideoLibEN.LikeCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objVideoLibEN.LikeCount, conVideoLib.LikeCount); //资源喜欢数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoLib.LikeCount); //资源喜欢数量
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.CollectionCount))
 {
 if (objVideoLibEN.CollectionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objVideoLibEN.CollectionCount, conVideoLib.CollectionCount); //收藏数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoLib.CollectionCount); //收藏数量
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.RecommendedDegreeId))
 {
 if (objVideoLibEN.RecommendedDegreeId !=  null)
 {
 var strRecommendedDegreeId = objVideoLibEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRecommendedDegreeId, conVideoLib.RecommendedDegreeId); //推荐度Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoLib.RecommendedDegreeId); //推荐度Id
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.CourseId))
 {
 if (objVideoLibEN.CourseId !=  null)
 {
 var strCourseId = objVideoLibEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, conVideoLib.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoLib.CourseId); //课程Id
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.VideoUrl))
 {
 if (objVideoLibEN.VideoUrl !=  null)
 {
 var strVideoUrl = objVideoLibEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoUrl, conVideoLib.VideoUrl); //视频Url
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoLib.VideoUrl); //视频Url
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.VideoPath))
 {
 if (objVideoLibEN.VideoPath !=  null)
 {
 var strVideoPath = objVideoLibEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoPath, conVideoLib.VideoPath); //视频目录
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoLib.VideoPath); //视频目录
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.CoverPicUrl))
 {
 if (objVideoLibEN.CoverPicUrl !=  null)
 {
 var strCoverPicUrl = objVideoLibEN.CoverPicUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCoverPicUrl, conVideoLib.CoverPicUrl); //封面Url
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoLib.CoverPicUrl); //封面Url
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.CoverPicShortUrl))
 {
 if (objVideoLibEN.CoverPicShortUrl !=  null)
 {
 var strCoverPicShortUrl = objVideoLibEN.CoverPicShortUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCoverPicShortUrl, conVideoLib.CoverPicShortUrl); //封面短Url
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoLib.CoverPicShortUrl); //封面短Url
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.ResErrMsg))
 {
 if (objVideoLibEN.ResErrMsg !=  null)
 {
 var strResErrMsg = objVideoLibEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResErrMsg, conVideoLib.ResErrMsg); //资源错误信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoLib.ResErrMsg); //资源错误信息
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.UpdDate))
 {
 if (objVideoLibEN.UpdDate !=  null)
 {
 var strUpdDate = objVideoLibEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conVideoLib.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoLib.UpdDate); //修改日期
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.UpdUserId))
 {
 if (objVideoLibEN.UpdUserId !=  null)
 {
 var strUpdUserId = objVideoLibEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conVideoLib.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoLib.UpdUserId); //修改用户Id
 }
 }
 
 if (objVideoLibEN.IsUpdated(conVideoLib.Memo))
 {
 if (objVideoLibEN.Memo !=  null)
 {
 var strMemo = objVideoLibEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conVideoLib.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoLib.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdVideoLib = '{0}'", objVideoLibEN.IdVideoLib); 
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
 /// <param name = "strIdVideoLib">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strIdVideoLib) 
{
CheckPrimaryKey(strIdVideoLib);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoLibDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strIdVideoLib,
};
 objSQL.ExecSP("VideoLib_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strIdVideoLib">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strIdVideoLib, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strIdVideoLib);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoLibDA.GetSpecSQLObj();
//删除VideoLib本表中与当前对象有关的记录
strSQL = strSQL + "Delete from VideoLib where IdVideoLib = " + "'"+ strIdVideoLib+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelVideoLib(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoLibDA.GetSpecSQLObj();
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
//删除VideoLib本表中与当前对象有关的记录
strSQL = strSQL + "Delete from VideoLib where IdVideoLib in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strIdVideoLib">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strIdVideoLib) 
{
CheckPrimaryKey(strIdVideoLib);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoLibDA.GetSpecSQLObj();
//删除VideoLib本表中与当前对象有关的记录
strSQL = strSQL + "Delete from VideoLib where IdVideoLib = " + "'"+ strIdVideoLib+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelVideoLib(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsVideoLibDA: DelVideoLib)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoLibDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from VideoLib where " + strCondition ;
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
public bool DelVideoLibWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsVideoLibDA: DelVideoLibWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoLibDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from VideoLib where " + strCondition ;
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
 /// <param name = "objVideoLibENS">源对象</param>
 /// <param name = "objVideoLibENT">目标对象</param>
public void CopyTo(clsVideoLibEN objVideoLibENS, clsVideoLibEN objVideoLibENT)
{
objVideoLibENT.IdVideoLib = objVideoLibENS.IdVideoLib; //视频库流水号
objVideoLibENT.VideoLibID = objVideoLibENS.VideoLibID; //视频库ID
objVideoLibENT.VideoLibName = objVideoLibENS.VideoLibName; //视频名称
objVideoLibENT.VideoLibTheme = objVideoLibENS.VideoLibTheme; //视频库主题词
objVideoLibENT.IdVideoLibType = objVideoLibENS.IdVideoLibType; //视频库类型流水号
objVideoLibENT.VideoLibText = objVideoLibENS.VideoLibText; //案例文本内容
objVideoLibENT.VideoLibDate = objVideoLibENS.VideoLibDate; //视频资源日期
objVideoLibENT.VideoLibTime = objVideoLibENS.VideoLibTime; //视频资源时间
objVideoLibENT.VideoLibDateIn = objVideoLibENS.VideoLibDateIn; //案例入库日期
objVideoLibENT.VideoLibTimeIn = objVideoLibENS.VideoLibTimeIn; //案例入库时间
objVideoLibENT.OwnerId = objVideoLibENS.OwnerId; //拥有者Id
objVideoLibENT.IdTeachingPlan = objVideoLibENS.IdTeachingPlan; //教案流水号
objVideoLibENT.BrowseCount = objVideoLibENS.BrowseCount; //浏览次数
objVideoLibENT.IdSenateGaugeVersion = objVideoLibENS.IdSenateGaugeVersion; //评价量表版本流水号
objVideoLibENT.CaseLevelId = objVideoLibENS.CaseLevelId; //课例等级Id
objVideoLibENT.IsVisible = objVideoLibENS.IsVisible; //是否显示
objVideoLibENT.IdXzCollege = objVideoLibENS.IdXzCollege; //学院流水号
objVideoLibENT.ViewCount = objVideoLibENS.ViewCount; //浏览量
objVideoLibENT.DownloadNumber = objVideoLibENS.DownloadNumber; //下载数目
objVideoLibENT.FileIntegration = objVideoLibENS.FileIntegration; //文件积分
objVideoLibENT.LikeCount = objVideoLibENS.LikeCount; //资源喜欢数量
objVideoLibENT.CollectionCount = objVideoLibENS.CollectionCount; //收藏数量
objVideoLibENT.RecommendedDegreeId = objVideoLibENS.RecommendedDegreeId; //推荐度Id
objVideoLibENT.CourseId = objVideoLibENS.CourseId; //课程Id
objVideoLibENT.VideoUrl = objVideoLibENS.VideoUrl; //视频Url
objVideoLibENT.VideoPath = objVideoLibENS.VideoPath; //视频目录
objVideoLibENT.CoverPicUrl = objVideoLibENS.CoverPicUrl; //封面Url
objVideoLibENT.CoverPicShortUrl = objVideoLibENS.CoverPicShortUrl; //封面短Url
objVideoLibENT.ResErrMsg = objVideoLibENS.ResErrMsg; //资源错误信息
objVideoLibENT.UpdDate = objVideoLibENS.UpdDate; //修改日期
objVideoLibENT.UpdUserId = objVideoLibENS.UpdUserId; //修改用户Id
objVideoLibENT.Memo = objVideoLibENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsVideoLibEN objVideoLibEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objVideoLibEN.VideoLibID, conVideoLib.VideoLibID);
clsCheckSql.CheckFieldNotNull(objVideoLibEN.VideoLibName, conVideoLib.VideoLibName);
clsCheckSql.CheckFieldNotNull(objVideoLibEN.IdVideoLibType, conVideoLib.IdVideoLibType);
clsCheckSql.CheckFieldNotNull(objVideoLibEN.OwnerId, conVideoLib.OwnerId);
clsCheckSql.CheckFieldNotNull(objVideoLibEN.RecommendedDegreeId, conVideoLib.RecommendedDegreeId);
//检查字段长度
clsCheckSql.CheckFieldLen(objVideoLibEN.IdVideoLib, 8, conVideoLib.IdVideoLib);
clsCheckSql.CheckFieldLen(objVideoLibEN.VideoLibID, 8, conVideoLib.VideoLibID);
clsCheckSql.CheckFieldLen(objVideoLibEN.VideoLibName, 100, conVideoLib.VideoLibName);
clsCheckSql.CheckFieldLen(objVideoLibEN.VideoLibTheme, 200, conVideoLib.VideoLibTheme);
clsCheckSql.CheckFieldLen(objVideoLibEN.IdVideoLibType, 4, conVideoLib.IdVideoLibType);
clsCheckSql.CheckFieldLen(objVideoLibEN.VideoLibText, 8000, conVideoLib.VideoLibText);
clsCheckSql.CheckFieldLen(objVideoLibEN.VideoLibDate, 20, conVideoLib.VideoLibDate);
clsCheckSql.CheckFieldLen(objVideoLibEN.VideoLibTime, 6, conVideoLib.VideoLibTime);
clsCheckSql.CheckFieldLen(objVideoLibEN.VideoLibDateIn, 8, conVideoLib.VideoLibDateIn);
clsCheckSql.CheckFieldLen(objVideoLibEN.VideoLibTimeIn, 6, conVideoLib.VideoLibTimeIn);
clsCheckSql.CheckFieldLen(objVideoLibEN.OwnerId, 20, conVideoLib.OwnerId);
clsCheckSql.CheckFieldLen(objVideoLibEN.IdTeachingPlan, 8, conVideoLib.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objVideoLibEN.IdSenateGaugeVersion, 4, conVideoLib.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objVideoLibEN.CaseLevelId, 2, conVideoLib.CaseLevelId);
clsCheckSql.CheckFieldLen(objVideoLibEN.IdXzCollege, 4, conVideoLib.IdXzCollege);
clsCheckSql.CheckFieldLen(objVideoLibEN.RecommendedDegreeId, 2, conVideoLib.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objVideoLibEN.CourseId, 8, conVideoLib.CourseId);
clsCheckSql.CheckFieldLen(objVideoLibEN.VideoUrl, 1000, conVideoLib.VideoUrl);
clsCheckSql.CheckFieldLen(objVideoLibEN.VideoPath, 1000, conVideoLib.VideoPath);
clsCheckSql.CheckFieldLen(objVideoLibEN.CoverPicUrl, 1000, conVideoLib.CoverPicUrl);
clsCheckSql.CheckFieldLen(objVideoLibEN.CoverPicShortUrl, 1000, conVideoLib.CoverPicShortUrl);
clsCheckSql.CheckFieldLen(objVideoLibEN.ResErrMsg, 30, conVideoLib.ResErrMsg);
clsCheckSql.CheckFieldLen(objVideoLibEN.UpdDate, 20, conVideoLib.UpdDate);
clsCheckSql.CheckFieldLen(objVideoLibEN.UpdUserId, 20, conVideoLib.UpdUserId);
clsCheckSql.CheckFieldLen(objVideoLibEN.Memo, 1000, conVideoLib.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objVideoLibEN.IdSenateGaugeVersion, 4, conVideoLib.IdSenateGaugeVersion);
 objVideoLibEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsVideoLibEN objVideoLibEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objVideoLibEN.VideoLibID, 8, conVideoLib.VideoLibID);
clsCheckSql.CheckFieldLen(objVideoLibEN.VideoLibName, 100, conVideoLib.VideoLibName);
clsCheckSql.CheckFieldLen(objVideoLibEN.VideoLibTheme, 200, conVideoLib.VideoLibTheme);
clsCheckSql.CheckFieldLen(objVideoLibEN.IdVideoLibType, 4, conVideoLib.IdVideoLibType);
clsCheckSql.CheckFieldLen(objVideoLibEN.VideoLibText, 8000, conVideoLib.VideoLibText);
clsCheckSql.CheckFieldLen(objVideoLibEN.VideoLibDate, 20, conVideoLib.VideoLibDate);
clsCheckSql.CheckFieldLen(objVideoLibEN.VideoLibTime, 6, conVideoLib.VideoLibTime);
clsCheckSql.CheckFieldLen(objVideoLibEN.VideoLibDateIn, 8, conVideoLib.VideoLibDateIn);
clsCheckSql.CheckFieldLen(objVideoLibEN.VideoLibTimeIn, 6, conVideoLib.VideoLibTimeIn);
clsCheckSql.CheckFieldLen(objVideoLibEN.OwnerId, 20, conVideoLib.OwnerId);
clsCheckSql.CheckFieldLen(objVideoLibEN.IdTeachingPlan, 8, conVideoLib.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objVideoLibEN.IdSenateGaugeVersion, 4, conVideoLib.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objVideoLibEN.CaseLevelId, 2, conVideoLib.CaseLevelId);
clsCheckSql.CheckFieldLen(objVideoLibEN.IdXzCollege, 4, conVideoLib.IdXzCollege);
clsCheckSql.CheckFieldLen(objVideoLibEN.RecommendedDegreeId, 2, conVideoLib.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objVideoLibEN.CourseId, 8, conVideoLib.CourseId);
clsCheckSql.CheckFieldLen(objVideoLibEN.VideoUrl, 1000, conVideoLib.VideoUrl);
clsCheckSql.CheckFieldLen(objVideoLibEN.VideoPath, 1000, conVideoLib.VideoPath);
clsCheckSql.CheckFieldLen(objVideoLibEN.CoverPicUrl, 1000, conVideoLib.CoverPicUrl);
clsCheckSql.CheckFieldLen(objVideoLibEN.CoverPicShortUrl, 1000, conVideoLib.CoverPicShortUrl);
clsCheckSql.CheckFieldLen(objVideoLibEN.ResErrMsg, 30, conVideoLib.ResErrMsg);
clsCheckSql.CheckFieldLen(objVideoLibEN.UpdDate, 20, conVideoLib.UpdDate);
clsCheckSql.CheckFieldLen(objVideoLibEN.UpdUserId, 20, conVideoLib.UpdUserId);
clsCheckSql.CheckFieldLen(objVideoLibEN.Memo, 1000, conVideoLib.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objVideoLibEN.IdSenateGaugeVersion, 4, conVideoLib.IdSenateGaugeVersion);
 objVideoLibEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsVideoLibEN objVideoLibEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objVideoLibEN.IdVideoLib, 8, conVideoLib.IdVideoLib);
clsCheckSql.CheckFieldLen(objVideoLibEN.VideoLibID, 8, conVideoLib.VideoLibID);
clsCheckSql.CheckFieldLen(objVideoLibEN.VideoLibName, 100, conVideoLib.VideoLibName);
clsCheckSql.CheckFieldLen(objVideoLibEN.VideoLibTheme, 200, conVideoLib.VideoLibTheme);
clsCheckSql.CheckFieldLen(objVideoLibEN.IdVideoLibType, 4, conVideoLib.IdVideoLibType);
clsCheckSql.CheckFieldLen(objVideoLibEN.VideoLibText, 8000, conVideoLib.VideoLibText);
clsCheckSql.CheckFieldLen(objVideoLibEN.VideoLibDate, 20, conVideoLib.VideoLibDate);
clsCheckSql.CheckFieldLen(objVideoLibEN.VideoLibTime, 6, conVideoLib.VideoLibTime);
clsCheckSql.CheckFieldLen(objVideoLibEN.VideoLibDateIn, 8, conVideoLib.VideoLibDateIn);
clsCheckSql.CheckFieldLen(objVideoLibEN.VideoLibTimeIn, 6, conVideoLib.VideoLibTimeIn);
clsCheckSql.CheckFieldLen(objVideoLibEN.OwnerId, 20, conVideoLib.OwnerId);
clsCheckSql.CheckFieldLen(objVideoLibEN.IdTeachingPlan, 8, conVideoLib.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objVideoLibEN.IdSenateGaugeVersion, 4, conVideoLib.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objVideoLibEN.CaseLevelId, 2, conVideoLib.CaseLevelId);
clsCheckSql.CheckFieldLen(objVideoLibEN.IdXzCollege, 4, conVideoLib.IdXzCollege);
clsCheckSql.CheckFieldLen(objVideoLibEN.RecommendedDegreeId, 2, conVideoLib.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objVideoLibEN.CourseId, 8, conVideoLib.CourseId);
clsCheckSql.CheckFieldLen(objVideoLibEN.VideoUrl, 1000, conVideoLib.VideoUrl);
clsCheckSql.CheckFieldLen(objVideoLibEN.VideoPath, 1000, conVideoLib.VideoPath);
clsCheckSql.CheckFieldLen(objVideoLibEN.CoverPicUrl, 1000, conVideoLib.CoverPicUrl);
clsCheckSql.CheckFieldLen(objVideoLibEN.CoverPicShortUrl, 1000, conVideoLib.CoverPicShortUrl);
clsCheckSql.CheckFieldLen(objVideoLibEN.ResErrMsg, 30, conVideoLib.ResErrMsg);
clsCheckSql.CheckFieldLen(objVideoLibEN.UpdDate, 20, conVideoLib.UpdDate);
clsCheckSql.CheckFieldLen(objVideoLibEN.UpdUserId, 20, conVideoLib.UpdUserId);
clsCheckSql.CheckFieldLen(objVideoLibEN.Memo, 1000, conVideoLib.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objVideoLibEN.IdVideoLib, conVideoLib.IdVideoLib);
clsCheckSql.CheckSqlInjection4Field(objVideoLibEN.VideoLibID, conVideoLib.VideoLibID);
clsCheckSql.CheckSqlInjection4Field(objVideoLibEN.VideoLibName, conVideoLib.VideoLibName);
clsCheckSql.CheckSqlInjection4Field(objVideoLibEN.VideoLibTheme, conVideoLib.VideoLibTheme);
clsCheckSql.CheckSqlInjection4Field(objVideoLibEN.IdVideoLibType, conVideoLib.IdVideoLibType);
clsCheckSql.CheckSqlInjection4Field(objVideoLibEN.VideoLibText, conVideoLib.VideoLibText);
clsCheckSql.CheckSqlInjection4Field(objVideoLibEN.VideoLibDate, conVideoLib.VideoLibDate);
clsCheckSql.CheckSqlInjection4Field(objVideoLibEN.VideoLibTime, conVideoLib.VideoLibTime);
clsCheckSql.CheckSqlInjection4Field(objVideoLibEN.VideoLibDateIn, conVideoLib.VideoLibDateIn);
clsCheckSql.CheckSqlInjection4Field(objVideoLibEN.VideoLibTimeIn, conVideoLib.VideoLibTimeIn);
clsCheckSql.CheckSqlInjection4Field(objVideoLibEN.OwnerId, conVideoLib.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objVideoLibEN.IdTeachingPlan, conVideoLib.IdTeachingPlan);
clsCheckSql.CheckSqlInjection4Field(objVideoLibEN.IdSenateGaugeVersion, conVideoLib.IdSenateGaugeVersion);
clsCheckSql.CheckSqlInjection4Field(objVideoLibEN.CaseLevelId, conVideoLib.CaseLevelId);
clsCheckSql.CheckSqlInjection4Field(objVideoLibEN.IdXzCollege, conVideoLib.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objVideoLibEN.RecommendedDegreeId, conVideoLib.RecommendedDegreeId);
clsCheckSql.CheckSqlInjection4Field(objVideoLibEN.CourseId, conVideoLib.CourseId);
clsCheckSql.CheckSqlInjection4Field(objVideoLibEN.VideoUrl, conVideoLib.VideoUrl);
clsCheckSql.CheckSqlInjection4Field(objVideoLibEN.VideoPath, conVideoLib.VideoPath);
clsCheckSql.CheckSqlInjection4Field(objVideoLibEN.CoverPicUrl, conVideoLib.CoverPicUrl);
clsCheckSql.CheckSqlInjection4Field(objVideoLibEN.CoverPicShortUrl, conVideoLib.CoverPicShortUrl);
clsCheckSql.CheckSqlInjection4Field(objVideoLibEN.ResErrMsg, conVideoLib.ResErrMsg);
clsCheckSql.CheckSqlInjection4Field(objVideoLibEN.UpdDate, conVideoLib.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objVideoLibEN.UpdUserId, conVideoLib.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objVideoLibEN.Memo, conVideoLib.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objVideoLibEN.IdSenateGaugeVersion, 4, conVideoLib.IdSenateGaugeVersion);
 objVideoLibEN._IsCheckProperty = true;
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
 objSQL = clsVideoLibDA.GetSpecSQLObj();
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
 objSQL = clsVideoLibDA.GetSpecSQLObj();
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
 objSQL = clsVideoLibDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsVideoLibEN._CurrTabName);
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
 objSQL = clsVideoLibDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsVideoLibEN._CurrTabName, strCondition);
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
 objSQL = clsVideoLibDA.GetSpecSQLObj();
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
 objSQL = clsVideoLibDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}