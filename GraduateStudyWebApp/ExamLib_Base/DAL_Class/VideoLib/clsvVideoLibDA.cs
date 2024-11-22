
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvVideoLibDA
 表名:vVideoLib(01120262)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:50:31
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
 /// v视频库(vVideoLib)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvVideoLibDA : clsCommBase4DA
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
 return clsvVideoLibEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvVideoLibEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvVideoLibEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvVideoLibEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvVideoLibEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:vVideoLib中,检查关键字,长度不正确!(clsvVideoLibDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdVideoLib)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vVideoLib中,关键字不能为空 或 null!(clsvVideoLibDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdVideoLib);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvVideoLibDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvVideoLibDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibDA.GetSpecSQLObj();
strSQL = "Select * from vVideoLib where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vVideoLib(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvVideoLibDA: GetDataTable_vVideoLib)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibDA.GetSpecSQLObj();
strSQL = "Select * from vVideoLib where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvVideoLibDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvVideoLibDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibDA.GetSpecSQLObj();
strSQL = "Select * from vVideoLib where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvVideoLibDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvVideoLibDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vVideoLib where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vVideoLib where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvVideoLibDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vVideoLib where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvVideoLibDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vVideoLib.* from vVideoLib Left Join {1} on {2} where {3} and vVideoLib.IdVideoLib not in (Select top {5} vVideoLib.IdVideoLib from vVideoLib Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vVideoLib where {1} and IdVideoLib not in (Select top {2} IdVideoLib from vVideoLib where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vVideoLib where {1} and IdVideoLib not in (Select top {3} IdVideoLib from vVideoLib where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvVideoLibDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vVideoLib.* from vVideoLib Left Join {1} on {2} where {3} and vVideoLib.IdVideoLib not in (Select top {5} vVideoLib.IdVideoLib from vVideoLib Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vVideoLib where {1} and IdVideoLib not in (Select top {2} IdVideoLib from vVideoLib where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vVideoLib where {1} and IdVideoLib not in (Select top {3} IdVideoLib from vVideoLib where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvVideoLibEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvVideoLibDA:GetObjLst)", objException.Message));
}
List<clsvVideoLibEN> arrObjLst = new List<clsvVideoLibEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibDA.GetSpecSQLObj();
strSQL = "Select * from vVideoLib where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLibEN objvVideoLibEN = new clsvVideoLibEN();
try
{
objvVideoLibEN.IdVideoLib = objRow[convVideoLib.IdVideoLib].ToString().Trim(); //视频库流水号
objvVideoLibEN.AppraiseCount = objRow[convVideoLib.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib.AppraiseCount].ToString().Trim()); //评论数
objvVideoLibEN.LikeNum = objRow[convVideoLib.LikeNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib.LikeNum].ToString().Trim()); //点赞数
objvVideoLibEN.PlayNum = objRow[convVideoLib.PlayNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib.PlayNum].ToString().Trim()); //播放数
objvVideoLibEN.VideoLibID = objRow[convVideoLib.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLibEN.VideoLibName = objRow[convVideoLib.VideoLibName].ToString().Trim(); //视频名称
objvVideoLibEN.VideoLibTheme = objRow[convVideoLib.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLib.VideoLibTheme].ToString().Trim(); //视频库主题词
objvVideoLibEN.IdVideoLibType = objRow[convVideoLib.IdVideoLibType].ToString().Trim(); //视频库类型流水号
objvVideoLibEN.VideoLibTypeName = objRow[convVideoLib.VideoLibTypeName].ToString().Trim(); //视频库类型名称
objvVideoLibEN.VideoLibText = objRow[convVideoLib.VideoLibText] == DBNull.Value ? null : objRow[convVideoLib.VideoLibText].ToString().Trim(); //案例文本内容
objvVideoLibEN.VideoLibDate = objRow[convVideoLib.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLib.VideoLibDate].ToString().Trim(); //视频资源日期
objvVideoLibEN.VideoLibTime = objRow[convVideoLib.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLib.VideoLibTime].ToString().Trim(); //视频资源时间
objvVideoLibEN.VideoLibDateIn = objRow[convVideoLib.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLib.VideoLibDateIn].ToString().Trim(); //案例入库日期
objvVideoLibEN.VideoLibTimeIn = objRow[convVideoLib.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLib.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objvVideoLibEN.OwnerId = objRow[convVideoLib.OwnerId].ToString().Trim(); //拥有者Id
objvVideoLibEN.IdTeachingPlan = objRow[convVideoLib.IdTeachingPlan].ToString().Trim(); //教案流水号
objvVideoLibEN.IdSenateGaugeVersion = objRow[convVideoLib.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvVideoLibEN.senateGaugeVersionID = objRow[convVideoLib.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoLibEN.senateGaugeVersionName = objRow[convVideoLib.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLib.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoLibEN.senateGaugeVersionTtlScore = TransNullToFloat(objRow[convVideoLib.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoLibEN.IsUse = TransNullToBool(objRow[convVideoLib.IsUse].ToString().Trim()); //是否使用
objvVideoLibEN.VersionNo = objRow[convVideoLib.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib.VersionNo].ToString().Trim()); //版本号
objvVideoLibEN.CaseLevelId = objRow[convVideoLib.CaseLevelId] == DBNull.Value ? null : objRow[convVideoLib.CaseLevelId].ToString().Trim(); //课例等级Id
objvVideoLibEN.CaseLevelName = objRow[convVideoLib.CaseLevelName] == DBNull.Value ? null : objRow[convVideoLib.CaseLevelName].ToString().Trim(); //案例等级名称
objvVideoLibEN.IsVisible = TransNullToBool(objRow[convVideoLib.IsVisible].ToString().Trim()); //是否显示
objvVideoLibEN.IdXzCollege = objRow[convVideoLib.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLib.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLibEN.CollegeID = objRow[convVideoLib.CollegeID].ToString().Trim(); //学院ID
objvVideoLibEN.CollegeName = objRow[convVideoLib.CollegeName].ToString().Trim(); //学院名称
objvVideoLibEN.CollegeNameA = objRow[convVideoLib.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLib.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoLibEN.ViewCount = objRow[convVideoLib.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib.ViewCount].ToString().Trim()); //浏览量
objvVideoLibEN.DownloadNumber = objRow[convVideoLib.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib.DownloadNumber].ToString().Trim()); //下载数目
objvVideoLibEN.FileIntegration = objRow[convVideoLib.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib.FileIntegration].ToString().Trim()); //文件积分
objvVideoLibEN.LikeCount = objRow[convVideoLib.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoLib.LikeCount].ToString().Trim()); //资源喜欢数量
objvVideoLibEN.CollectionCount = objRow[convVideoLib.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoLib.CollectionCount].ToString().Trim()); //收藏数量
objvVideoLibEN.RecommendedDegreeId = objRow[convVideoLib.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvVideoLibEN.RecommendedDegreeName = objRow[convVideoLib.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvVideoLibEN.CourseId = objRow[convVideoLib.CourseId].ToString().Trim(); //课程Id
objvVideoLibEN.CourseCode = objRow[convVideoLib.CourseCode] == DBNull.Value ? null : objRow[convVideoLib.CourseCode].ToString().Trim(); //课程代码
objvVideoLibEN.CourseName = objRow[convVideoLib.CourseName] == DBNull.Value ? null : objRow[convVideoLib.CourseName].ToString().Trim(); //课程名称
objvVideoLibEN.VideoUrl = objRow[convVideoLib.VideoUrl] == DBNull.Value ? null : objRow[convVideoLib.VideoUrl].ToString().Trim(); //视频Url
objvVideoLibEN.VideoPath = objRow[convVideoLib.VideoPath] == DBNull.Value ? null : objRow[convVideoLib.VideoPath].ToString().Trim(); //视频目录
objvVideoLibEN.CoverPicUrl = objRow[convVideoLib.CoverPicUrl] == DBNull.Value ? null : objRow[convVideoLib.CoverPicUrl].ToString().Trim(); //封面Url
objvVideoLibEN.CoverPicShortUrl = objRow[convVideoLib.CoverPicShortUrl] == DBNull.Value ? null : objRow[convVideoLib.CoverPicShortUrl].ToString().Trim(); //封面短Url
objvVideoLibEN.ResErrMsg = objRow[convVideoLib.ResErrMsg] == DBNull.Value ? null : objRow[convVideoLib.ResErrMsg].ToString().Trim(); //资源错误信息
objvVideoLibEN.UpdDate = objRow[convVideoLib.UpdDate] == DBNull.Value ? null : objRow[convVideoLib.UpdDate].ToString().Trim(); //修改日期
objvVideoLibEN.UpdUserId = objRow[convVideoLib.UpdUserId] == DBNull.Value ? null : objRow[convVideoLib.UpdUserId].ToString().Trim(); //修改用户Id
objvVideoLibEN.Memo = objRow[convVideoLib.Memo] == DBNull.Value ? null : objRow[convVideoLib.Memo].ToString().Trim(); //备注
objvVideoLibEN.BrowseCount4Case = objRow[convVideoLib.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvVideoLibEN.OwnerName = objRow[convVideoLib.OwnerName] == DBNull.Value ? null : objRow[convVideoLib.OwnerName].ToString().Trim(); //拥有者姓名
objvVideoLibEN.OwnerNameWithId = objRow[convVideoLib.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoLib.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvVideoLibEN.IsHaveVideo = objRow[convVideoLib.IsHaveVideo] == DBNull.Value ? null : objRow[convVideoLib.IsHaveVideo].ToString().Trim(); //IsHaveVideo
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvVideoLibDA: GetObjLst)", objException.Message));
}
objvVideoLibEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvVideoLibEN);
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
public List<clsvVideoLibEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvVideoLibDA:GetObjLstByTabName)", objException.Message));
}
List<clsvVideoLibEN> arrObjLst = new List<clsvVideoLibEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLibEN objvVideoLibEN = new clsvVideoLibEN();
try
{
objvVideoLibEN.IdVideoLib = objRow[convVideoLib.IdVideoLib].ToString().Trim(); //视频库流水号
objvVideoLibEN.AppraiseCount = objRow[convVideoLib.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib.AppraiseCount].ToString().Trim()); //评论数
objvVideoLibEN.LikeNum = objRow[convVideoLib.LikeNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib.LikeNum].ToString().Trim()); //点赞数
objvVideoLibEN.PlayNum = objRow[convVideoLib.PlayNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib.PlayNum].ToString().Trim()); //播放数
objvVideoLibEN.VideoLibID = objRow[convVideoLib.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLibEN.VideoLibName = objRow[convVideoLib.VideoLibName].ToString().Trim(); //视频名称
objvVideoLibEN.VideoLibTheme = objRow[convVideoLib.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLib.VideoLibTheme].ToString().Trim(); //视频库主题词
objvVideoLibEN.IdVideoLibType = objRow[convVideoLib.IdVideoLibType].ToString().Trim(); //视频库类型流水号
objvVideoLibEN.VideoLibTypeName = objRow[convVideoLib.VideoLibTypeName].ToString().Trim(); //视频库类型名称
objvVideoLibEN.VideoLibText = objRow[convVideoLib.VideoLibText] == DBNull.Value ? null : objRow[convVideoLib.VideoLibText].ToString().Trim(); //案例文本内容
objvVideoLibEN.VideoLibDate = objRow[convVideoLib.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLib.VideoLibDate].ToString().Trim(); //视频资源日期
objvVideoLibEN.VideoLibTime = objRow[convVideoLib.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLib.VideoLibTime].ToString().Trim(); //视频资源时间
objvVideoLibEN.VideoLibDateIn = objRow[convVideoLib.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLib.VideoLibDateIn].ToString().Trim(); //案例入库日期
objvVideoLibEN.VideoLibTimeIn = objRow[convVideoLib.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLib.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objvVideoLibEN.OwnerId = objRow[convVideoLib.OwnerId].ToString().Trim(); //拥有者Id
objvVideoLibEN.IdTeachingPlan = objRow[convVideoLib.IdTeachingPlan].ToString().Trim(); //教案流水号
objvVideoLibEN.IdSenateGaugeVersion = objRow[convVideoLib.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvVideoLibEN.senateGaugeVersionID = objRow[convVideoLib.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoLibEN.senateGaugeVersionName = objRow[convVideoLib.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLib.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoLibEN.senateGaugeVersionTtlScore = TransNullToFloat(objRow[convVideoLib.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoLibEN.IsUse = TransNullToBool(objRow[convVideoLib.IsUse].ToString().Trim()); //是否使用
objvVideoLibEN.VersionNo = objRow[convVideoLib.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib.VersionNo].ToString().Trim()); //版本号
objvVideoLibEN.CaseLevelId = objRow[convVideoLib.CaseLevelId] == DBNull.Value ? null : objRow[convVideoLib.CaseLevelId].ToString().Trim(); //课例等级Id
objvVideoLibEN.CaseLevelName = objRow[convVideoLib.CaseLevelName] == DBNull.Value ? null : objRow[convVideoLib.CaseLevelName].ToString().Trim(); //案例等级名称
objvVideoLibEN.IsVisible = TransNullToBool(objRow[convVideoLib.IsVisible].ToString().Trim()); //是否显示
objvVideoLibEN.IdXzCollege = objRow[convVideoLib.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLib.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLibEN.CollegeID = objRow[convVideoLib.CollegeID].ToString().Trim(); //学院ID
objvVideoLibEN.CollegeName = objRow[convVideoLib.CollegeName].ToString().Trim(); //学院名称
objvVideoLibEN.CollegeNameA = objRow[convVideoLib.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLib.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoLibEN.ViewCount = objRow[convVideoLib.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib.ViewCount].ToString().Trim()); //浏览量
objvVideoLibEN.DownloadNumber = objRow[convVideoLib.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib.DownloadNumber].ToString().Trim()); //下载数目
objvVideoLibEN.FileIntegration = objRow[convVideoLib.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib.FileIntegration].ToString().Trim()); //文件积分
objvVideoLibEN.LikeCount = objRow[convVideoLib.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoLib.LikeCount].ToString().Trim()); //资源喜欢数量
objvVideoLibEN.CollectionCount = objRow[convVideoLib.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoLib.CollectionCount].ToString().Trim()); //收藏数量
objvVideoLibEN.RecommendedDegreeId = objRow[convVideoLib.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvVideoLibEN.RecommendedDegreeName = objRow[convVideoLib.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvVideoLibEN.CourseId = objRow[convVideoLib.CourseId].ToString().Trim(); //课程Id
objvVideoLibEN.CourseCode = objRow[convVideoLib.CourseCode] == DBNull.Value ? null : objRow[convVideoLib.CourseCode].ToString().Trim(); //课程代码
objvVideoLibEN.CourseName = objRow[convVideoLib.CourseName] == DBNull.Value ? null : objRow[convVideoLib.CourseName].ToString().Trim(); //课程名称
objvVideoLibEN.VideoUrl = objRow[convVideoLib.VideoUrl] == DBNull.Value ? null : objRow[convVideoLib.VideoUrl].ToString().Trim(); //视频Url
objvVideoLibEN.VideoPath = objRow[convVideoLib.VideoPath] == DBNull.Value ? null : objRow[convVideoLib.VideoPath].ToString().Trim(); //视频目录
objvVideoLibEN.CoverPicUrl = objRow[convVideoLib.CoverPicUrl] == DBNull.Value ? null : objRow[convVideoLib.CoverPicUrl].ToString().Trim(); //封面Url
objvVideoLibEN.CoverPicShortUrl = objRow[convVideoLib.CoverPicShortUrl] == DBNull.Value ? null : objRow[convVideoLib.CoverPicShortUrl].ToString().Trim(); //封面短Url
objvVideoLibEN.ResErrMsg = objRow[convVideoLib.ResErrMsg] == DBNull.Value ? null : objRow[convVideoLib.ResErrMsg].ToString().Trim(); //资源错误信息
objvVideoLibEN.UpdDate = objRow[convVideoLib.UpdDate] == DBNull.Value ? null : objRow[convVideoLib.UpdDate].ToString().Trim(); //修改日期
objvVideoLibEN.UpdUserId = objRow[convVideoLib.UpdUserId] == DBNull.Value ? null : objRow[convVideoLib.UpdUserId].ToString().Trim(); //修改用户Id
objvVideoLibEN.Memo = objRow[convVideoLib.Memo] == DBNull.Value ? null : objRow[convVideoLib.Memo].ToString().Trim(); //备注
objvVideoLibEN.BrowseCount4Case = objRow[convVideoLib.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvVideoLibEN.OwnerName = objRow[convVideoLib.OwnerName] == DBNull.Value ? null : objRow[convVideoLib.OwnerName].ToString().Trim(); //拥有者姓名
objvVideoLibEN.OwnerNameWithId = objRow[convVideoLib.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoLib.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvVideoLibEN.IsHaveVideo = objRow[convVideoLib.IsHaveVideo] == DBNull.Value ? null : objRow[convVideoLib.IsHaveVideo].ToString().Trim(); //IsHaveVideo
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvVideoLibDA: GetObjLst)", objException.Message));
}
objvVideoLibEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvVideoLibEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvVideoLib(ref clsvVideoLibEN objvVideoLibEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibDA.GetSpecSQLObj();
strSQL = "Select * from vVideoLib where IdVideoLib = " + "'"+ objvVideoLibEN.IdVideoLib+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvVideoLibEN.IdVideoLib = objDT.Rows[0][convVideoLib.IdVideoLib].ToString().Trim(); //视频库流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoLibEN.AppraiseCount = TransNullToInt(objDT.Rows[0][convVideoLib.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objvVideoLibEN.LikeNum = TransNullToInt(objDT.Rows[0][convVideoLib.LikeNum].ToString().Trim()); //点赞数(字段类型:int,字段长度:4,是否可空:True)
 objvVideoLibEN.PlayNum = TransNullToInt(objDT.Rows[0][convVideoLib.PlayNum].ToString().Trim()); //播放数(字段类型:int,字段长度:4,是否可空:True)
 objvVideoLibEN.VideoLibID = objDT.Rows[0][convVideoLib.VideoLibID].ToString().Trim(); //视频库ID(字段类型:char,字段长度:8,是否可空:False)
 objvVideoLibEN.VideoLibName = objDT.Rows[0][convVideoLib.VideoLibName].ToString().Trim(); //视频名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvVideoLibEN.VideoLibTheme = objDT.Rows[0][convVideoLib.VideoLibTheme].ToString().Trim(); //视频库主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoLibEN.IdVideoLibType = objDT.Rows[0][convVideoLib.IdVideoLibType].ToString().Trim(); //视频库类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvVideoLibEN.VideoLibTypeName = objDT.Rows[0][convVideoLib.VideoLibTypeName].ToString().Trim(); //视频库类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvVideoLibEN.VideoLibText = objDT.Rows[0][convVideoLib.VideoLibText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objvVideoLibEN.VideoLibDate = objDT.Rows[0][convVideoLib.VideoLibDate].ToString().Trim(); //视频资源日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvVideoLibEN.VideoLibTime = objDT.Rows[0][convVideoLib.VideoLibTime].ToString().Trim(); //视频资源时间(字段类型:char,字段长度:6,是否可空:True)
 objvVideoLibEN.VideoLibDateIn = objDT.Rows[0][convVideoLib.VideoLibDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvVideoLibEN.VideoLibTimeIn = objDT.Rows[0][convVideoLib.VideoLibTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvVideoLibEN.OwnerId = objDT.Rows[0][convVideoLib.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvVideoLibEN.IdTeachingPlan = objDT.Rows[0][convVideoLib.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoLibEN.IdSenateGaugeVersion = objDT.Rows[0][convVideoLib.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvVideoLibEN.senateGaugeVersionID = objDT.Rows[0][convVideoLib.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvVideoLibEN.senateGaugeVersionName = objDT.Rows[0][convVideoLib.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoLibEN.senateGaugeVersionTtlScore = TransNullToFloat(objDT.Rows[0][convVideoLib.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvVideoLibEN.IsUse = TransNullToBool(objDT.Rows[0][convVideoLib.IsUse].ToString().Trim()); //是否使用(字段类型:bit,字段长度:1,是否可空:True)
 objvVideoLibEN.VersionNo = TransNullToInt(objDT.Rows[0][convVideoLib.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvVideoLibEN.CaseLevelId = objDT.Rows[0][convVideoLib.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvVideoLibEN.CaseLevelName = objDT.Rows[0][convVideoLib.CaseLevelName].ToString().Trim(); //案例等级名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvVideoLibEN.IsVisible = TransNullToBool(objDT.Rows[0][convVideoLib.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvVideoLibEN.IdXzCollege = objDT.Rows[0][convVideoLib.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvVideoLibEN.CollegeID = objDT.Rows[0][convVideoLib.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvVideoLibEN.CollegeName = objDT.Rows[0][convVideoLib.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvVideoLibEN.CollegeNameA = objDT.Rows[0][convVideoLib.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvVideoLibEN.ViewCount = TransNullToInt(objDT.Rows[0][convVideoLib.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvVideoLibEN.DownloadNumber = TransNullToInt(objDT.Rows[0][convVideoLib.DownloadNumber].ToString().Trim()); //下载数目(字段类型:int,字段长度:4,是否可空:True)
 objvVideoLibEN.FileIntegration = TransNullToInt(objDT.Rows[0][convVideoLib.FileIntegration].ToString().Trim()); //文件积分(字段类型:int,字段长度:4,是否可空:True)
 objvVideoLibEN.LikeCount = TransNullToInt(objDT.Rows[0][convVideoLib.LikeCount].ToString().Trim()); //资源喜欢数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvVideoLibEN.CollectionCount = TransNullToInt(objDT.Rows[0][convVideoLib.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvVideoLibEN.RecommendedDegreeId = objDT.Rows[0][convVideoLib.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvVideoLibEN.RecommendedDegreeName = objDT.Rows[0][convVideoLib.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvVideoLibEN.CourseId = objDT.Rows[0][convVideoLib.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvVideoLibEN.CourseCode = objDT.Rows[0][convVideoLib.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvVideoLibEN.CourseName = objDT.Rows[0][convVideoLib.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvVideoLibEN.VideoUrl = objDT.Rows[0][convVideoLib.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objvVideoLibEN.VideoPath = objDT.Rows[0][convVideoLib.VideoPath].ToString().Trim(); //视频目录(字段类型:varchar,字段长度:1000,是否可空:True)
 objvVideoLibEN.CoverPicUrl = objDT.Rows[0][convVideoLib.CoverPicUrl].ToString().Trim(); //封面Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objvVideoLibEN.CoverPicShortUrl = objDT.Rows[0][convVideoLib.CoverPicShortUrl].ToString().Trim(); //封面短Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objvVideoLibEN.ResErrMsg = objDT.Rows[0][convVideoLib.ResErrMsg].ToString().Trim(); //资源错误信息(字段类型:varchar,字段长度:30,是否可空:True)
 objvVideoLibEN.UpdDate = objDT.Rows[0][convVideoLib.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvVideoLibEN.UpdUserId = objDT.Rows[0][convVideoLib.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvVideoLibEN.Memo = objDT.Rows[0][convVideoLib.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvVideoLibEN.BrowseCount4Case = TransNullToInt(objDT.Rows[0][convVideoLib.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvVideoLibEN.OwnerName = objDT.Rows[0][convVideoLib.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvVideoLibEN.OwnerNameWithId = objDT.Rows[0][convVideoLib.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
 objvVideoLibEN.IsHaveVideo = objDT.Rows[0][convVideoLib.IsHaveVideo].ToString().Trim(); //IsHaveVideo(字段类型:varchar,字段长度:6,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvVideoLibDA: GetvVideoLib)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdVideoLib">表关键字</param>
 /// <returns>表对象</returns>
public clsvVideoLibEN GetObjByIdVideoLib(string strIdVideoLib)
{
CheckPrimaryKey(strIdVideoLib);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibDA.GetSpecSQLObj();
strSQL = "Select * from vVideoLib where IdVideoLib = " + "'"+ strIdVideoLib+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvVideoLibEN objvVideoLibEN = new clsvVideoLibEN();
try
{
 objvVideoLibEN.IdVideoLib = objRow[convVideoLib.IdVideoLib].ToString().Trim(); //视频库流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoLibEN.AppraiseCount = objRow[convVideoLib.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objvVideoLibEN.LikeNum = objRow[convVideoLib.LikeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.LikeNum].ToString().Trim()); //点赞数(字段类型:int,字段长度:4,是否可空:True)
 objvVideoLibEN.PlayNum = objRow[convVideoLib.PlayNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.PlayNum].ToString().Trim()); //播放数(字段类型:int,字段长度:4,是否可空:True)
 objvVideoLibEN.VideoLibID = objRow[convVideoLib.VideoLibID].ToString().Trim(); //视频库ID(字段类型:char,字段长度:8,是否可空:False)
 objvVideoLibEN.VideoLibName = objRow[convVideoLib.VideoLibName].ToString().Trim(); //视频名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvVideoLibEN.VideoLibTheme = objRow[convVideoLib.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLib.VideoLibTheme].ToString().Trim(); //视频库主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoLibEN.IdVideoLibType = objRow[convVideoLib.IdVideoLibType].ToString().Trim(); //视频库类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvVideoLibEN.VideoLibTypeName = objRow[convVideoLib.VideoLibTypeName].ToString().Trim(); //视频库类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvVideoLibEN.VideoLibText = objRow[convVideoLib.VideoLibText] == DBNull.Value ? null : objRow[convVideoLib.VideoLibText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objvVideoLibEN.VideoLibDate = objRow[convVideoLib.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLib.VideoLibDate].ToString().Trim(); //视频资源日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvVideoLibEN.VideoLibTime = objRow[convVideoLib.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLib.VideoLibTime].ToString().Trim(); //视频资源时间(字段类型:char,字段长度:6,是否可空:True)
 objvVideoLibEN.VideoLibDateIn = objRow[convVideoLib.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLib.VideoLibDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvVideoLibEN.VideoLibTimeIn = objRow[convVideoLib.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLib.VideoLibTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvVideoLibEN.OwnerId = objRow[convVideoLib.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvVideoLibEN.IdTeachingPlan = objRow[convVideoLib.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoLibEN.IdSenateGaugeVersion = objRow[convVideoLib.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvVideoLibEN.senateGaugeVersionID = objRow[convVideoLib.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvVideoLibEN.senateGaugeVersionName = objRow[convVideoLib.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLib.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoLibEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convVideoLib.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvVideoLibEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib.IsUse].ToString().Trim()); //是否使用(字段类型:bit,字段长度:1,是否可空:True)
 objvVideoLibEN.VersionNo = objRow[convVideoLib.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvVideoLibEN.CaseLevelId = objRow[convVideoLib.CaseLevelId] == DBNull.Value ? null : objRow[convVideoLib.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvVideoLibEN.CaseLevelName = objRow[convVideoLib.CaseLevelName] == DBNull.Value ? null : objRow[convVideoLib.CaseLevelName].ToString().Trim(); //案例等级名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvVideoLibEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvVideoLibEN.IdXzCollege = objRow[convVideoLib.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLib.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvVideoLibEN.CollegeID = objRow[convVideoLib.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvVideoLibEN.CollegeName = objRow[convVideoLib.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvVideoLibEN.CollegeNameA = objRow[convVideoLib.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLib.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvVideoLibEN.ViewCount = objRow[convVideoLib.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvVideoLibEN.DownloadNumber = objRow[convVideoLib.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.DownloadNumber].ToString().Trim()); //下载数目(字段类型:int,字段长度:4,是否可空:True)
 objvVideoLibEN.FileIntegration = objRow[convVideoLib.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.FileIntegration].ToString().Trim()); //文件积分(字段类型:int,字段长度:4,是否可空:True)
 objvVideoLibEN.LikeCount = objRow[convVideoLib.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.LikeCount].ToString().Trim()); //资源喜欢数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvVideoLibEN.CollectionCount = objRow[convVideoLib.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvVideoLibEN.RecommendedDegreeId = objRow[convVideoLib.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvVideoLibEN.RecommendedDegreeName = objRow[convVideoLib.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvVideoLibEN.CourseId = objRow[convVideoLib.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvVideoLibEN.CourseCode = objRow[convVideoLib.CourseCode] == DBNull.Value ? null : objRow[convVideoLib.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvVideoLibEN.CourseName = objRow[convVideoLib.CourseName] == DBNull.Value ? null : objRow[convVideoLib.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvVideoLibEN.VideoUrl = objRow[convVideoLib.VideoUrl] == DBNull.Value ? null : objRow[convVideoLib.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objvVideoLibEN.VideoPath = objRow[convVideoLib.VideoPath] == DBNull.Value ? null : objRow[convVideoLib.VideoPath].ToString().Trim(); //视频目录(字段类型:varchar,字段长度:1000,是否可空:True)
 objvVideoLibEN.CoverPicUrl = objRow[convVideoLib.CoverPicUrl] == DBNull.Value ? null : objRow[convVideoLib.CoverPicUrl].ToString().Trim(); //封面Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objvVideoLibEN.CoverPicShortUrl = objRow[convVideoLib.CoverPicShortUrl] == DBNull.Value ? null : objRow[convVideoLib.CoverPicShortUrl].ToString().Trim(); //封面短Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objvVideoLibEN.ResErrMsg = objRow[convVideoLib.ResErrMsg] == DBNull.Value ? null : objRow[convVideoLib.ResErrMsg].ToString().Trim(); //资源错误信息(字段类型:varchar,字段长度:30,是否可空:True)
 objvVideoLibEN.UpdDate = objRow[convVideoLib.UpdDate] == DBNull.Value ? null : objRow[convVideoLib.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvVideoLibEN.UpdUserId = objRow[convVideoLib.UpdUserId] == DBNull.Value ? null : objRow[convVideoLib.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvVideoLibEN.Memo = objRow[convVideoLib.Memo] == DBNull.Value ? null : objRow[convVideoLib.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvVideoLibEN.BrowseCount4Case = objRow[convVideoLib.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvVideoLibEN.OwnerName = objRow[convVideoLib.OwnerName] == DBNull.Value ? null : objRow[convVideoLib.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvVideoLibEN.OwnerNameWithId = objRow[convVideoLib.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoLib.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
 objvVideoLibEN.IsHaveVideo = objRow[convVideoLib.IsHaveVideo] == DBNull.Value ? null : objRow[convVideoLib.IsHaveVideo].ToString().Trim(); //IsHaveVideo(字段类型:varchar,字段长度:6,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvVideoLibDA: GetObjByIdVideoLib)", objException.Message));
}
return objvVideoLibEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvVideoLibEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvVideoLibDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibDA.GetSpecSQLObj();
strSQL = "Select * from vVideoLib where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvVideoLibEN objvVideoLibEN = new clsvVideoLibEN()
{
IdVideoLib = objRow[convVideoLib.IdVideoLib].ToString().Trim(), //视频库流水号
AppraiseCount = objRow[convVideoLib.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib.AppraiseCount].ToString().Trim()), //评论数
LikeNum = objRow[convVideoLib.LikeNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib.LikeNum].ToString().Trim()), //点赞数
PlayNum = objRow[convVideoLib.PlayNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib.PlayNum].ToString().Trim()), //播放数
VideoLibID = objRow[convVideoLib.VideoLibID].ToString().Trim(), //视频库ID
VideoLibName = objRow[convVideoLib.VideoLibName].ToString().Trim(), //视频名称
VideoLibTheme = objRow[convVideoLib.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLib.VideoLibTheme].ToString().Trim(), //视频库主题词
IdVideoLibType = objRow[convVideoLib.IdVideoLibType].ToString().Trim(), //视频库类型流水号
VideoLibTypeName = objRow[convVideoLib.VideoLibTypeName].ToString().Trim(), //视频库类型名称
VideoLibText = objRow[convVideoLib.VideoLibText] == DBNull.Value ? null : objRow[convVideoLib.VideoLibText].ToString().Trim(), //案例文本内容
VideoLibDate = objRow[convVideoLib.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLib.VideoLibDate].ToString().Trim(), //视频资源日期
VideoLibTime = objRow[convVideoLib.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLib.VideoLibTime].ToString().Trim(), //视频资源时间
VideoLibDateIn = objRow[convVideoLib.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLib.VideoLibDateIn].ToString().Trim(), //案例入库日期
VideoLibTimeIn = objRow[convVideoLib.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLib.VideoLibTimeIn].ToString().Trim(), //案例入库时间
OwnerId = objRow[convVideoLib.OwnerId].ToString().Trim(), //拥有者Id
IdTeachingPlan = objRow[convVideoLib.IdTeachingPlan].ToString().Trim(), //教案流水号
IdSenateGaugeVersion = objRow[convVideoLib.IdSenateGaugeVersion].ToString().Trim(), //评价量表版本流水号
senateGaugeVersionID = objRow[convVideoLib.senateGaugeVersionID].ToString().Trim(), //评价量表版本ID
senateGaugeVersionName = objRow[convVideoLib.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLib.senateGaugeVersionName].ToString().Trim(), //评价量表版本名称
senateGaugeVersionTtlScore = TransNullToFloat(objRow[convVideoLib.senateGaugeVersionTtlScore].ToString().Trim()), //评价量表版本总分
IsUse = TransNullToBool(objRow[convVideoLib.IsUse].ToString().Trim()), //是否使用
VersionNo = objRow[convVideoLib.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib.VersionNo].ToString().Trim()), //版本号
CaseLevelId = objRow[convVideoLib.CaseLevelId] == DBNull.Value ? null : objRow[convVideoLib.CaseLevelId].ToString().Trim(), //课例等级Id
CaseLevelName = objRow[convVideoLib.CaseLevelName] == DBNull.Value ? null : objRow[convVideoLib.CaseLevelName].ToString().Trim(), //案例等级名称
IsVisible = TransNullToBool(objRow[convVideoLib.IsVisible].ToString().Trim()), //是否显示
IdXzCollege = objRow[convVideoLib.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLib.IdXzCollege].ToString().Trim(), //学院流水号
CollegeID = objRow[convVideoLib.CollegeID].ToString().Trim(), //学院ID
CollegeName = objRow[convVideoLib.CollegeName].ToString().Trim(), //学院名称
CollegeNameA = objRow[convVideoLib.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLib.CollegeNameA].ToString().Trim(), //学院名称简写
ViewCount = objRow[convVideoLib.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib.ViewCount].ToString().Trim()), //浏览量
DownloadNumber = objRow[convVideoLib.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib.DownloadNumber].ToString().Trim()), //下载数目
FileIntegration = objRow[convVideoLib.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib.FileIntegration].ToString().Trim()), //文件积分
LikeCount = objRow[convVideoLib.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoLib.LikeCount].ToString().Trim()), //资源喜欢数量
CollectionCount = objRow[convVideoLib.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoLib.CollectionCount].ToString().Trim()), //收藏数量
RecommendedDegreeId = objRow[convVideoLib.RecommendedDegreeId].ToString().Trim(), //推荐度Id
RecommendedDegreeName = objRow[convVideoLib.RecommendedDegreeName].ToString().Trim(), //推荐度名称
CourseId = objRow[convVideoLib.CourseId].ToString().Trim(), //课程Id
CourseCode = objRow[convVideoLib.CourseCode] == DBNull.Value ? null : objRow[convVideoLib.CourseCode].ToString().Trim(), //课程代码
CourseName = objRow[convVideoLib.CourseName] == DBNull.Value ? null : objRow[convVideoLib.CourseName].ToString().Trim(), //课程名称
VideoUrl = objRow[convVideoLib.VideoUrl] == DBNull.Value ? null : objRow[convVideoLib.VideoUrl].ToString().Trim(), //视频Url
VideoPath = objRow[convVideoLib.VideoPath] == DBNull.Value ? null : objRow[convVideoLib.VideoPath].ToString().Trim(), //视频目录
CoverPicUrl = objRow[convVideoLib.CoverPicUrl] == DBNull.Value ? null : objRow[convVideoLib.CoverPicUrl].ToString().Trim(), //封面Url
CoverPicShortUrl = objRow[convVideoLib.CoverPicShortUrl] == DBNull.Value ? null : objRow[convVideoLib.CoverPicShortUrl].ToString().Trim(), //封面短Url
ResErrMsg = objRow[convVideoLib.ResErrMsg] == DBNull.Value ? null : objRow[convVideoLib.ResErrMsg].ToString().Trim(), //资源错误信息
UpdDate = objRow[convVideoLib.UpdDate] == DBNull.Value ? null : objRow[convVideoLib.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[convVideoLib.UpdUserId] == DBNull.Value ? null : objRow[convVideoLib.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[convVideoLib.Memo] == DBNull.Value ? null : objRow[convVideoLib.Memo].ToString().Trim(), //备注
BrowseCount4Case = objRow[convVideoLib.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib.BrowseCount4Case].ToString().Trim()), //课例浏览次数
OwnerName = objRow[convVideoLib.OwnerName] == DBNull.Value ? null : objRow[convVideoLib.OwnerName].ToString().Trim(), //拥有者姓名
OwnerNameWithId = objRow[convVideoLib.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoLib.OwnerNameWithId].ToString().Trim(), //拥有者名称附Id
IsHaveVideo = objRow[convVideoLib.IsHaveVideo] == DBNull.Value ? null : objRow[convVideoLib.IsHaveVideo].ToString().Trim() //IsHaveVideo
};
objvVideoLibEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvVideoLibEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvVideoLibDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvVideoLibEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvVideoLibEN objvVideoLibEN = new clsvVideoLibEN();
try
{
objvVideoLibEN.IdVideoLib = objRow[convVideoLib.IdVideoLib].ToString().Trim(); //视频库流水号
objvVideoLibEN.AppraiseCount = objRow[convVideoLib.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib.AppraiseCount].ToString().Trim()); //评论数
objvVideoLibEN.LikeNum = objRow[convVideoLib.LikeNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib.LikeNum].ToString().Trim()); //点赞数
objvVideoLibEN.PlayNum = objRow[convVideoLib.PlayNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib.PlayNum].ToString().Trim()); //播放数
objvVideoLibEN.VideoLibID = objRow[convVideoLib.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLibEN.VideoLibName = objRow[convVideoLib.VideoLibName].ToString().Trim(); //视频名称
objvVideoLibEN.VideoLibTheme = objRow[convVideoLib.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLib.VideoLibTheme].ToString().Trim(); //视频库主题词
objvVideoLibEN.IdVideoLibType = objRow[convVideoLib.IdVideoLibType].ToString().Trim(); //视频库类型流水号
objvVideoLibEN.VideoLibTypeName = objRow[convVideoLib.VideoLibTypeName].ToString().Trim(); //视频库类型名称
objvVideoLibEN.VideoLibText = objRow[convVideoLib.VideoLibText] == DBNull.Value ? null : objRow[convVideoLib.VideoLibText].ToString().Trim(); //案例文本内容
objvVideoLibEN.VideoLibDate = objRow[convVideoLib.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLib.VideoLibDate].ToString().Trim(); //视频资源日期
objvVideoLibEN.VideoLibTime = objRow[convVideoLib.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLib.VideoLibTime].ToString().Trim(); //视频资源时间
objvVideoLibEN.VideoLibDateIn = objRow[convVideoLib.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLib.VideoLibDateIn].ToString().Trim(); //案例入库日期
objvVideoLibEN.VideoLibTimeIn = objRow[convVideoLib.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLib.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objvVideoLibEN.OwnerId = objRow[convVideoLib.OwnerId].ToString().Trim(); //拥有者Id
objvVideoLibEN.IdTeachingPlan = objRow[convVideoLib.IdTeachingPlan].ToString().Trim(); //教案流水号
objvVideoLibEN.IdSenateGaugeVersion = objRow[convVideoLib.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvVideoLibEN.senateGaugeVersionID = objRow[convVideoLib.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoLibEN.senateGaugeVersionName = objRow[convVideoLib.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLib.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoLibEN.senateGaugeVersionTtlScore = TransNullToFloat(objRow[convVideoLib.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoLibEN.IsUse = TransNullToBool(objRow[convVideoLib.IsUse].ToString().Trim()); //是否使用
objvVideoLibEN.VersionNo = objRow[convVideoLib.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib.VersionNo].ToString().Trim()); //版本号
objvVideoLibEN.CaseLevelId = objRow[convVideoLib.CaseLevelId] == DBNull.Value ? null : objRow[convVideoLib.CaseLevelId].ToString().Trim(); //课例等级Id
objvVideoLibEN.CaseLevelName = objRow[convVideoLib.CaseLevelName] == DBNull.Value ? null : objRow[convVideoLib.CaseLevelName].ToString().Trim(); //案例等级名称
objvVideoLibEN.IsVisible = TransNullToBool(objRow[convVideoLib.IsVisible].ToString().Trim()); //是否显示
objvVideoLibEN.IdXzCollege = objRow[convVideoLib.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLib.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLibEN.CollegeID = objRow[convVideoLib.CollegeID].ToString().Trim(); //学院ID
objvVideoLibEN.CollegeName = objRow[convVideoLib.CollegeName].ToString().Trim(); //学院名称
objvVideoLibEN.CollegeNameA = objRow[convVideoLib.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLib.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoLibEN.ViewCount = objRow[convVideoLib.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib.ViewCount].ToString().Trim()); //浏览量
objvVideoLibEN.DownloadNumber = objRow[convVideoLib.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib.DownloadNumber].ToString().Trim()); //下载数目
objvVideoLibEN.FileIntegration = objRow[convVideoLib.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib.FileIntegration].ToString().Trim()); //文件积分
objvVideoLibEN.LikeCount = objRow[convVideoLib.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoLib.LikeCount].ToString().Trim()); //资源喜欢数量
objvVideoLibEN.CollectionCount = objRow[convVideoLib.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoLib.CollectionCount].ToString().Trim()); //收藏数量
objvVideoLibEN.RecommendedDegreeId = objRow[convVideoLib.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvVideoLibEN.RecommendedDegreeName = objRow[convVideoLib.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvVideoLibEN.CourseId = objRow[convVideoLib.CourseId].ToString().Trim(); //课程Id
objvVideoLibEN.CourseCode = objRow[convVideoLib.CourseCode] == DBNull.Value ? null : objRow[convVideoLib.CourseCode].ToString().Trim(); //课程代码
objvVideoLibEN.CourseName = objRow[convVideoLib.CourseName] == DBNull.Value ? null : objRow[convVideoLib.CourseName].ToString().Trim(); //课程名称
objvVideoLibEN.VideoUrl = objRow[convVideoLib.VideoUrl] == DBNull.Value ? null : objRow[convVideoLib.VideoUrl].ToString().Trim(); //视频Url
objvVideoLibEN.VideoPath = objRow[convVideoLib.VideoPath] == DBNull.Value ? null : objRow[convVideoLib.VideoPath].ToString().Trim(); //视频目录
objvVideoLibEN.CoverPicUrl = objRow[convVideoLib.CoverPicUrl] == DBNull.Value ? null : objRow[convVideoLib.CoverPicUrl].ToString().Trim(); //封面Url
objvVideoLibEN.CoverPicShortUrl = objRow[convVideoLib.CoverPicShortUrl] == DBNull.Value ? null : objRow[convVideoLib.CoverPicShortUrl].ToString().Trim(); //封面短Url
objvVideoLibEN.ResErrMsg = objRow[convVideoLib.ResErrMsg] == DBNull.Value ? null : objRow[convVideoLib.ResErrMsg].ToString().Trim(); //资源错误信息
objvVideoLibEN.UpdDate = objRow[convVideoLib.UpdDate] == DBNull.Value ? null : objRow[convVideoLib.UpdDate].ToString().Trim(); //修改日期
objvVideoLibEN.UpdUserId = objRow[convVideoLib.UpdUserId] == DBNull.Value ? null : objRow[convVideoLib.UpdUserId].ToString().Trim(); //修改用户Id
objvVideoLibEN.Memo = objRow[convVideoLib.Memo] == DBNull.Value ? null : objRow[convVideoLib.Memo].ToString().Trim(); //备注
objvVideoLibEN.BrowseCount4Case = objRow[convVideoLib.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvVideoLibEN.OwnerName = objRow[convVideoLib.OwnerName] == DBNull.Value ? null : objRow[convVideoLib.OwnerName].ToString().Trim(); //拥有者姓名
objvVideoLibEN.OwnerNameWithId = objRow[convVideoLib.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoLib.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvVideoLibEN.IsHaveVideo = objRow[convVideoLib.IsHaveVideo] == DBNull.Value ? null : objRow[convVideoLib.IsHaveVideo].ToString().Trim(); //IsHaveVideo
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvVideoLibDA: GetObjByDataRowvVideoLib)", objException.Message));
}
objvVideoLibEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvVideoLibEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvVideoLibEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvVideoLibEN objvVideoLibEN = new clsvVideoLibEN();
try
{
objvVideoLibEN.IdVideoLib = objRow[convVideoLib.IdVideoLib].ToString().Trim(); //视频库流水号
objvVideoLibEN.AppraiseCount = objRow[convVideoLib.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib.AppraiseCount].ToString().Trim()); //评论数
objvVideoLibEN.LikeNum = objRow[convVideoLib.LikeNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib.LikeNum].ToString().Trim()); //点赞数
objvVideoLibEN.PlayNum = objRow[convVideoLib.PlayNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib.PlayNum].ToString().Trim()); //播放数
objvVideoLibEN.VideoLibID = objRow[convVideoLib.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLibEN.VideoLibName = objRow[convVideoLib.VideoLibName].ToString().Trim(); //视频名称
objvVideoLibEN.VideoLibTheme = objRow[convVideoLib.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLib.VideoLibTheme].ToString().Trim(); //视频库主题词
objvVideoLibEN.IdVideoLibType = objRow[convVideoLib.IdVideoLibType].ToString().Trim(); //视频库类型流水号
objvVideoLibEN.VideoLibTypeName = objRow[convVideoLib.VideoLibTypeName].ToString().Trim(); //视频库类型名称
objvVideoLibEN.VideoLibText = objRow[convVideoLib.VideoLibText] == DBNull.Value ? null : objRow[convVideoLib.VideoLibText].ToString().Trim(); //案例文本内容
objvVideoLibEN.VideoLibDate = objRow[convVideoLib.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLib.VideoLibDate].ToString().Trim(); //视频资源日期
objvVideoLibEN.VideoLibTime = objRow[convVideoLib.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLib.VideoLibTime].ToString().Trim(); //视频资源时间
objvVideoLibEN.VideoLibDateIn = objRow[convVideoLib.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLib.VideoLibDateIn].ToString().Trim(); //案例入库日期
objvVideoLibEN.VideoLibTimeIn = objRow[convVideoLib.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLib.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objvVideoLibEN.OwnerId = objRow[convVideoLib.OwnerId].ToString().Trim(); //拥有者Id
objvVideoLibEN.IdTeachingPlan = objRow[convVideoLib.IdTeachingPlan].ToString().Trim(); //教案流水号
objvVideoLibEN.IdSenateGaugeVersion = objRow[convVideoLib.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvVideoLibEN.senateGaugeVersionID = objRow[convVideoLib.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoLibEN.senateGaugeVersionName = objRow[convVideoLib.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLib.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoLibEN.senateGaugeVersionTtlScore = TransNullToFloat(objRow[convVideoLib.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoLibEN.IsUse = TransNullToBool(objRow[convVideoLib.IsUse].ToString().Trim()); //是否使用
objvVideoLibEN.VersionNo = objRow[convVideoLib.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib.VersionNo].ToString().Trim()); //版本号
objvVideoLibEN.CaseLevelId = objRow[convVideoLib.CaseLevelId] == DBNull.Value ? null : objRow[convVideoLib.CaseLevelId].ToString().Trim(); //课例等级Id
objvVideoLibEN.CaseLevelName = objRow[convVideoLib.CaseLevelName] == DBNull.Value ? null : objRow[convVideoLib.CaseLevelName].ToString().Trim(); //案例等级名称
objvVideoLibEN.IsVisible = TransNullToBool(objRow[convVideoLib.IsVisible].ToString().Trim()); //是否显示
objvVideoLibEN.IdXzCollege = objRow[convVideoLib.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLib.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLibEN.CollegeID = objRow[convVideoLib.CollegeID].ToString().Trim(); //学院ID
objvVideoLibEN.CollegeName = objRow[convVideoLib.CollegeName].ToString().Trim(); //学院名称
objvVideoLibEN.CollegeNameA = objRow[convVideoLib.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLib.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoLibEN.ViewCount = objRow[convVideoLib.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib.ViewCount].ToString().Trim()); //浏览量
objvVideoLibEN.DownloadNumber = objRow[convVideoLib.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib.DownloadNumber].ToString().Trim()); //下载数目
objvVideoLibEN.FileIntegration = objRow[convVideoLib.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib.FileIntegration].ToString().Trim()); //文件积分
objvVideoLibEN.LikeCount = objRow[convVideoLib.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoLib.LikeCount].ToString().Trim()); //资源喜欢数量
objvVideoLibEN.CollectionCount = objRow[convVideoLib.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoLib.CollectionCount].ToString().Trim()); //收藏数量
objvVideoLibEN.RecommendedDegreeId = objRow[convVideoLib.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvVideoLibEN.RecommendedDegreeName = objRow[convVideoLib.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvVideoLibEN.CourseId = objRow[convVideoLib.CourseId].ToString().Trim(); //课程Id
objvVideoLibEN.CourseCode = objRow[convVideoLib.CourseCode] == DBNull.Value ? null : objRow[convVideoLib.CourseCode].ToString().Trim(); //课程代码
objvVideoLibEN.CourseName = objRow[convVideoLib.CourseName] == DBNull.Value ? null : objRow[convVideoLib.CourseName].ToString().Trim(); //课程名称
objvVideoLibEN.VideoUrl = objRow[convVideoLib.VideoUrl] == DBNull.Value ? null : objRow[convVideoLib.VideoUrl].ToString().Trim(); //视频Url
objvVideoLibEN.VideoPath = objRow[convVideoLib.VideoPath] == DBNull.Value ? null : objRow[convVideoLib.VideoPath].ToString().Trim(); //视频目录
objvVideoLibEN.CoverPicUrl = objRow[convVideoLib.CoverPicUrl] == DBNull.Value ? null : objRow[convVideoLib.CoverPicUrl].ToString().Trim(); //封面Url
objvVideoLibEN.CoverPicShortUrl = objRow[convVideoLib.CoverPicShortUrl] == DBNull.Value ? null : objRow[convVideoLib.CoverPicShortUrl].ToString().Trim(); //封面短Url
objvVideoLibEN.ResErrMsg = objRow[convVideoLib.ResErrMsg] == DBNull.Value ? null : objRow[convVideoLib.ResErrMsg].ToString().Trim(); //资源错误信息
objvVideoLibEN.UpdDate = objRow[convVideoLib.UpdDate] == DBNull.Value ? null : objRow[convVideoLib.UpdDate].ToString().Trim(); //修改日期
objvVideoLibEN.UpdUserId = objRow[convVideoLib.UpdUserId] == DBNull.Value ? null : objRow[convVideoLib.UpdUserId].ToString().Trim(); //修改用户Id
objvVideoLibEN.Memo = objRow[convVideoLib.Memo] == DBNull.Value ? null : objRow[convVideoLib.Memo].ToString().Trim(); //备注
objvVideoLibEN.BrowseCount4Case = objRow[convVideoLib.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvVideoLibEN.OwnerName = objRow[convVideoLib.OwnerName] == DBNull.Value ? null : objRow[convVideoLib.OwnerName].ToString().Trim(); //拥有者姓名
objvVideoLibEN.OwnerNameWithId = objRow[convVideoLib.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoLib.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvVideoLibEN.IsHaveVideo = objRow[convVideoLib.IsHaveVideo] == DBNull.Value ? null : objRow[convVideoLib.IsHaveVideo].ToString().Trim(); //IsHaveVideo
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvVideoLibDA: GetObjByDataRow)", objException.Message));
}
objvVideoLibEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvVideoLibEN;
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
objSQL = clsvVideoLibDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvVideoLibEN._CurrTabName, convVideoLib.IdVideoLib, 8, "");
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
objSQL = clsvVideoLibDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvVideoLibEN._CurrTabName, convVideoLib.IdVideoLib, 8, strPrefix);
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
 objSQL = clsvVideoLibDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdVideoLib from vVideoLib where " + strCondition;
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
 objSQL = clsvVideoLibDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdVideoLib from vVideoLib where " + strCondition;
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
 objSQL = clsvVideoLibDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vVideoLib", "IdVideoLib = " + "'"+ strIdVideoLib+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvVideoLibDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLibDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vVideoLib", strCondition))
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
objSQL = clsvVideoLibDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vVideoLib");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvVideoLibENS">源对象</param>
 /// <param name = "objvVideoLibENT">目标对象</param>
public void CopyTo(clsvVideoLibEN objvVideoLibENS, clsvVideoLibEN objvVideoLibENT)
{
objvVideoLibENT.IdVideoLib = objvVideoLibENS.IdVideoLib; //视频库流水号
objvVideoLibENT.AppraiseCount = objvVideoLibENS.AppraiseCount; //评论数
objvVideoLibENT.LikeNum = objvVideoLibENS.LikeNum; //点赞数
objvVideoLibENT.PlayNum = objvVideoLibENS.PlayNum; //播放数
objvVideoLibENT.VideoLibID = objvVideoLibENS.VideoLibID; //视频库ID
objvVideoLibENT.VideoLibName = objvVideoLibENS.VideoLibName; //视频名称
objvVideoLibENT.VideoLibTheme = objvVideoLibENS.VideoLibTheme; //视频库主题词
objvVideoLibENT.IdVideoLibType = objvVideoLibENS.IdVideoLibType; //视频库类型流水号
objvVideoLibENT.VideoLibTypeName = objvVideoLibENS.VideoLibTypeName; //视频库类型名称
objvVideoLibENT.VideoLibText = objvVideoLibENS.VideoLibText; //案例文本内容
objvVideoLibENT.VideoLibDate = objvVideoLibENS.VideoLibDate; //视频资源日期
objvVideoLibENT.VideoLibTime = objvVideoLibENS.VideoLibTime; //视频资源时间
objvVideoLibENT.VideoLibDateIn = objvVideoLibENS.VideoLibDateIn; //案例入库日期
objvVideoLibENT.VideoLibTimeIn = objvVideoLibENS.VideoLibTimeIn; //案例入库时间
objvVideoLibENT.OwnerId = objvVideoLibENS.OwnerId; //拥有者Id
objvVideoLibENT.IdTeachingPlan = objvVideoLibENS.IdTeachingPlan; //教案流水号
objvVideoLibENT.IdSenateGaugeVersion = objvVideoLibENS.IdSenateGaugeVersion; //评价量表版本流水号
objvVideoLibENT.senateGaugeVersionID = objvVideoLibENS.senateGaugeVersionID; //评价量表版本ID
objvVideoLibENT.senateGaugeVersionName = objvVideoLibENS.senateGaugeVersionName; //评价量表版本名称
objvVideoLibENT.senateGaugeVersionTtlScore = objvVideoLibENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvVideoLibENT.IsUse = objvVideoLibENS.IsUse; //是否使用
objvVideoLibENT.VersionNo = objvVideoLibENS.VersionNo; //版本号
objvVideoLibENT.CaseLevelId = objvVideoLibENS.CaseLevelId; //课例等级Id
objvVideoLibENT.CaseLevelName = objvVideoLibENS.CaseLevelName; //案例等级名称
objvVideoLibENT.IsVisible = objvVideoLibENS.IsVisible; //是否显示
objvVideoLibENT.IdXzCollege = objvVideoLibENS.IdXzCollege; //学院流水号
objvVideoLibENT.CollegeID = objvVideoLibENS.CollegeID; //学院ID
objvVideoLibENT.CollegeName = objvVideoLibENS.CollegeName; //学院名称
objvVideoLibENT.CollegeNameA = objvVideoLibENS.CollegeNameA; //学院名称简写
objvVideoLibENT.ViewCount = objvVideoLibENS.ViewCount; //浏览量
objvVideoLibENT.DownloadNumber = objvVideoLibENS.DownloadNumber; //下载数目
objvVideoLibENT.FileIntegration = objvVideoLibENS.FileIntegration; //文件积分
objvVideoLibENT.LikeCount = objvVideoLibENS.LikeCount; //资源喜欢数量
objvVideoLibENT.CollectionCount = objvVideoLibENS.CollectionCount; //收藏数量
objvVideoLibENT.RecommendedDegreeId = objvVideoLibENS.RecommendedDegreeId; //推荐度Id
objvVideoLibENT.RecommendedDegreeName = objvVideoLibENS.RecommendedDegreeName; //推荐度名称
objvVideoLibENT.CourseId = objvVideoLibENS.CourseId; //课程Id
objvVideoLibENT.CourseCode = objvVideoLibENS.CourseCode; //课程代码
objvVideoLibENT.CourseName = objvVideoLibENS.CourseName; //课程名称
objvVideoLibENT.VideoUrl = objvVideoLibENS.VideoUrl; //视频Url
objvVideoLibENT.VideoPath = objvVideoLibENS.VideoPath; //视频目录
objvVideoLibENT.CoverPicUrl = objvVideoLibENS.CoverPicUrl; //封面Url
objvVideoLibENT.CoverPicShortUrl = objvVideoLibENS.CoverPicShortUrl; //封面短Url
objvVideoLibENT.ResErrMsg = objvVideoLibENS.ResErrMsg; //资源错误信息
objvVideoLibENT.UpdDate = objvVideoLibENS.UpdDate; //修改日期
objvVideoLibENT.UpdUserId = objvVideoLibENS.UpdUserId; //修改用户Id
objvVideoLibENT.Memo = objvVideoLibENS.Memo; //备注
objvVideoLibENT.BrowseCount4Case = objvVideoLibENS.BrowseCount4Case; //课例浏览次数
objvVideoLibENT.OwnerName = objvVideoLibENS.OwnerName; //拥有者姓名
objvVideoLibENT.OwnerNameWithId = objvVideoLibENS.OwnerNameWithId; //拥有者名称附Id
objvVideoLibENT.IsHaveVideo = objvVideoLibENS.IsHaveVideo; //IsHaveVideo
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvVideoLibEN objvVideoLibEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvVideoLibEN.IdVideoLib, 8, convVideoLib.IdVideoLib);
clsCheckSql.CheckFieldLen(objvVideoLibEN.VideoLibID, 8, convVideoLib.VideoLibID);
clsCheckSql.CheckFieldLen(objvVideoLibEN.VideoLibName, 100, convVideoLib.VideoLibName);
clsCheckSql.CheckFieldLen(objvVideoLibEN.VideoLibTheme, 200, convVideoLib.VideoLibTheme);
clsCheckSql.CheckFieldLen(objvVideoLibEN.IdVideoLibType, 4, convVideoLib.IdVideoLibType);
clsCheckSql.CheckFieldLen(objvVideoLibEN.VideoLibTypeName, 30, convVideoLib.VideoLibTypeName);
clsCheckSql.CheckFieldLen(objvVideoLibEN.VideoLibText, 8000, convVideoLib.VideoLibText);
clsCheckSql.CheckFieldLen(objvVideoLibEN.VideoLibDate, 20, convVideoLib.VideoLibDate);
clsCheckSql.CheckFieldLen(objvVideoLibEN.VideoLibTime, 6, convVideoLib.VideoLibTime);
clsCheckSql.CheckFieldLen(objvVideoLibEN.VideoLibDateIn, 8, convVideoLib.VideoLibDateIn);
clsCheckSql.CheckFieldLen(objvVideoLibEN.VideoLibTimeIn, 6, convVideoLib.VideoLibTimeIn);
clsCheckSql.CheckFieldLen(objvVideoLibEN.OwnerId, 20, convVideoLib.OwnerId);
clsCheckSql.CheckFieldLen(objvVideoLibEN.IdTeachingPlan, 8, convVideoLib.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objvVideoLibEN.IdSenateGaugeVersion, 4, convVideoLib.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objvVideoLibEN.senateGaugeVersionID, 4, convVideoLib.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(objvVideoLibEN.senateGaugeVersionName, 200, convVideoLib.senateGaugeVersionName);
clsCheckSql.CheckFieldLen(objvVideoLibEN.CaseLevelId, 2, convVideoLib.CaseLevelId);
clsCheckSql.CheckFieldLen(objvVideoLibEN.CaseLevelName, 30, convVideoLib.CaseLevelName);
clsCheckSql.CheckFieldLen(objvVideoLibEN.IdXzCollege, 4, convVideoLib.IdXzCollege);
clsCheckSql.CheckFieldLen(objvVideoLibEN.CollegeID, 4, convVideoLib.CollegeID);
clsCheckSql.CheckFieldLen(objvVideoLibEN.CollegeName, 100, convVideoLib.CollegeName);
clsCheckSql.CheckFieldLen(objvVideoLibEN.CollegeNameA, 12, convVideoLib.CollegeNameA);
clsCheckSql.CheckFieldLen(objvVideoLibEN.RecommendedDegreeId, 2, convVideoLib.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objvVideoLibEN.RecommendedDegreeName, 30, convVideoLib.RecommendedDegreeName);
clsCheckSql.CheckFieldLen(objvVideoLibEN.CourseId, 8, convVideoLib.CourseId);
clsCheckSql.CheckFieldLen(objvVideoLibEN.CourseCode, 20, convVideoLib.CourseCode);
clsCheckSql.CheckFieldLen(objvVideoLibEN.CourseName, 100, convVideoLib.CourseName);
clsCheckSql.CheckFieldLen(objvVideoLibEN.VideoUrl, 1000, convVideoLib.VideoUrl);
clsCheckSql.CheckFieldLen(objvVideoLibEN.VideoPath, 1000, convVideoLib.VideoPath);
clsCheckSql.CheckFieldLen(objvVideoLibEN.CoverPicUrl, 1000, convVideoLib.CoverPicUrl);
clsCheckSql.CheckFieldLen(objvVideoLibEN.CoverPicShortUrl, 1000, convVideoLib.CoverPicShortUrl);
clsCheckSql.CheckFieldLen(objvVideoLibEN.ResErrMsg, 30, convVideoLib.ResErrMsg);
clsCheckSql.CheckFieldLen(objvVideoLibEN.UpdDate, 20, convVideoLib.UpdDate);
clsCheckSql.CheckFieldLen(objvVideoLibEN.UpdUserId, 20, convVideoLib.UpdUserId);
clsCheckSql.CheckFieldLen(objvVideoLibEN.Memo, 1000, convVideoLib.Memo);
clsCheckSql.CheckFieldLen(objvVideoLibEN.OwnerName, 30, convVideoLib.OwnerName);
clsCheckSql.CheckFieldLen(objvVideoLibEN.OwnerNameWithId, 51, convVideoLib.OwnerNameWithId);
clsCheckSql.CheckFieldLen(objvVideoLibEN.IsHaveVideo, 6, convVideoLib.IsHaveVideo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvVideoLibEN.IdVideoLib, convVideoLib.IdVideoLib);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibEN.VideoLibID, convVideoLib.VideoLibID);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibEN.VideoLibName, convVideoLib.VideoLibName);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibEN.VideoLibTheme, convVideoLib.VideoLibTheme);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibEN.IdVideoLibType, convVideoLib.IdVideoLibType);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibEN.VideoLibTypeName, convVideoLib.VideoLibTypeName);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibEN.VideoLibText, convVideoLib.VideoLibText);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibEN.VideoLibDate, convVideoLib.VideoLibDate);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibEN.VideoLibTime, convVideoLib.VideoLibTime);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibEN.VideoLibDateIn, convVideoLib.VideoLibDateIn);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibEN.VideoLibTimeIn, convVideoLib.VideoLibTimeIn);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibEN.OwnerId, convVideoLib.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibEN.IdTeachingPlan, convVideoLib.IdTeachingPlan);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibEN.IdSenateGaugeVersion, convVideoLib.IdSenateGaugeVersion);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibEN.senateGaugeVersionID, convVideoLib.senateGaugeVersionID);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibEN.senateGaugeVersionName, convVideoLib.senateGaugeVersionName);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibEN.CaseLevelId, convVideoLib.CaseLevelId);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibEN.CaseLevelName, convVideoLib.CaseLevelName);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibEN.IdXzCollege, convVideoLib.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibEN.CollegeID, convVideoLib.CollegeID);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibEN.CollegeName, convVideoLib.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibEN.CollegeNameA, convVideoLib.CollegeNameA);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibEN.RecommendedDegreeId, convVideoLib.RecommendedDegreeId);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibEN.RecommendedDegreeName, convVideoLib.RecommendedDegreeName);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibEN.CourseId, convVideoLib.CourseId);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibEN.CourseCode, convVideoLib.CourseCode);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibEN.CourseName, convVideoLib.CourseName);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibEN.VideoUrl, convVideoLib.VideoUrl);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibEN.VideoPath, convVideoLib.VideoPath);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibEN.CoverPicUrl, convVideoLib.CoverPicUrl);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibEN.CoverPicShortUrl, convVideoLib.CoverPicShortUrl);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibEN.ResErrMsg, convVideoLib.ResErrMsg);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibEN.UpdDate, convVideoLib.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibEN.UpdUserId, convVideoLib.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibEN.Memo, convVideoLib.Memo);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibEN.OwnerName, convVideoLib.OwnerName);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibEN.OwnerNameWithId, convVideoLib.OwnerNameWithId);
clsCheckSql.CheckSqlInjection4Field(objvVideoLibEN.IsHaveVideo, convVideoLib.IsHaveVideo);
//检查外键字段长度
 objvVideoLibEN._IsCheckProperty = true;
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
 objSQL = clsvVideoLibDA.GetSpecSQLObj();
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
 objSQL = clsvVideoLibDA.GetSpecSQLObj();
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
 objSQL = clsvVideoLibDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvVideoLibEN._CurrTabName);
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
 objSQL = clsvVideoLibDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvVideoLibEN._CurrTabName, strCondition);
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
 objSQL = clsvVideoLibDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}