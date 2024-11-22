
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvVideoLib_BaseDA
 表名:vVideoLib_Base(01120329)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:50:33
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
 /// v视频库_Base(vVideoLib_Base)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvVideoLib_BaseDA : clsCommBase4DA
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
 return clsvVideoLib_BaseEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvVideoLib_BaseEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvVideoLib_BaseEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvVideoLib_BaseEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvVideoLib_BaseEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:vVideoLib_Base中,检查关键字,长度不正确!(clsvVideoLib_BaseDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdVideoLib)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vVideoLib_Base中,关键字不能为空 或 null!(clsvVideoLib_BaseDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdVideoLib);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvVideoLib_BaseDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvVideoLib_BaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLib_BaseDA.GetSpecSQLObj();
strSQL = "Select * from vVideoLib_Base where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vVideoLib_Base(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvVideoLib_BaseDA: GetDataTable_vVideoLib_Base)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLib_BaseDA.GetSpecSQLObj();
strSQL = "Select * from vVideoLib_Base where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvVideoLib_BaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLib_BaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvVideoLib_BaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLib_BaseDA.GetSpecSQLObj();
strSQL = "Select * from vVideoLib_Base where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvVideoLib_BaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLib_BaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvVideoLib_BaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLib_BaseDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vVideoLib_Base where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vVideoLib_Base where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvVideoLib_BaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLib_BaseDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vVideoLib_Base where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvVideoLib_BaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLib_BaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vVideoLib_Base.* from vVideoLib_Base Left Join {1} on {2} where {3} and vVideoLib_Base.IdVideoLib not in (Select top {5} vVideoLib_Base.IdVideoLib from vVideoLib_Base Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vVideoLib_Base where {1} and IdVideoLib not in (Select top {2} IdVideoLib from vVideoLib_Base where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vVideoLib_Base where {1} and IdVideoLib not in (Select top {3} IdVideoLib from vVideoLib_Base where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvVideoLib_BaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLib_BaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vVideoLib_Base.* from vVideoLib_Base Left Join {1} on {2} where {3} and vVideoLib_Base.IdVideoLib not in (Select top {5} vVideoLib_Base.IdVideoLib from vVideoLib_Base Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vVideoLib_Base where {1} and IdVideoLib not in (Select top {2} IdVideoLib from vVideoLib_Base where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vVideoLib_Base where {1} and IdVideoLib not in (Select top {3} IdVideoLib from vVideoLib_Base where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvVideoLib_BaseEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvVideoLib_BaseDA:GetObjLst)", objException.Message));
}
List<clsvVideoLib_BaseEN> arrObjLst = new List<clsvVideoLib_BaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLib_BaseDA.GetSpecSQLObj();
strSQL = "Select * from vVideoLib_Base where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLib_BaseEN objvVideoLib_BaseEN = new clsvVideoLib_BaseEN();
try
{
objvVideoLib_BaseEN.IdVideoLib = objRow[convVideoLib_Base.IdVideoLib].ToString().Trim(); //视频库流水号
objvVideoLib_BaseEN.VideoLibID = objRow[convVideoLib_Base.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLib_BaseEN.VideoLibName = objRow[convVideoLib_Base.VideoLibName].ToString().Trim(); //视频名称
objvVideoLib_BaseEN.VideoLibTheme = objRow[convVideoLib_Base.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibTheme].ToString().Trim(); //视频库主题词
objvVideoLib_BaseEN.IdVideoLibType = objRow[convVideoLib_Base.IdVideoLibType].ToString().Trim(); //视频库类型流水号
objvVideoLib_BaseEN.VideoLibTypeName = objRow[convVideoLib_Base.VideoLibTypeName] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibTypeName].ToString().Trim(); //视频库类型名称
objvVideoLib_BaseEN.VideoLibText = objRow[convVideoLib_Base.VideoLibText] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibText].ToString().Trim(); //案例文本内容
objvVideoLib_BaseEN.VideoLibDate = objRow[convVideoLib_Base.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibDate].ToString().Trim(); //视频资源日期
objvVideoLib_BaseEN.VideoLibTime = objRow[convVideoLib_Base.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibTime].ToString().Trim(); //视频资源时间
objvVideoLib_BaseEN.VideoLibDateIn = objRow[convVideoLib_Base.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibDateIn].ToString().Trim(); //案例入库日期
objvVideoLib_BaseEN.VideoLibTimeIn = objRow[convVideoLib_Base.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objvVideoLib_BaseEN.OwnerId = objRow[convVideoLib_Base.OwnerId].ToString().Trim(); //拥有者Id
objvVideoLib_BaseEN.IdTeachingPlan = objRow[convVideoLib_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convVideoLib_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvVideoLib_BaseEN.IdSenateGaugeVersion = objRow[convVideoLib_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convVideoLib_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvVideoLib_BaseEN.senateGaugeVersionID = objRow[convVideoLib_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoLib_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoLib_BaseEN.senateGaugeVersionName = objRow[convVideoLib_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLib_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoLib_BaseEN.senateGaugeVersionTtlScore = objRow[convVideoLib_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convVideoLib_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoLib_BaseEN.VersionNo = objRow[convVideoLib_Base.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib_Base.VersionNo].ToString().Trim()); //版本号
objvVideoLib_BaseEN.CaseLevelId = objRow[convVideoLib_Base.CaseLevelId] == DBNull.Value ? null : objRow[convVideoLib_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvVideoLib_BaseEN.CaseLevelName = objRow[convVideoLib_Base.CaseLevelName] == DBNull.Value ? null : objRow[convVideoLib_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvVideoLib_BaseEN.IsVisible = TransNullToBool(objRow[convVideoLib_Base.IsVisible].ToString().Trim()); //是否显示
objvVideoLib_BaseEN.IdXzCollege = objRow[convVideoLib_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLib_BaseEN.CollegeID = objRow[convVideoLib_Base.CollegeID] == DBNull.Value ? null : objRow[convVideoLib_Base.CollegeID].ToString().Trim(); //学院ID
objvVideoLib_BaseEN.CollegeName = objRow[convVideoLib_Base.CollegeName] == DBNull.Value ? null : objRow[convVideoLib_Base.CollegeName].ToString().Trim(); //学院名称
objvVideoLib_BaseEN.CollegeNameA = objRow[convVideoLib_Base.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLib_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoLib_BaseEN.ViewCount = objRow[convVideoLib_Base.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib_Base.ViewCount].ToString().Trim()); //浏览量
objvVideoLib_BaseEN.DownloadNumber = objRow[convVideoLib_Base.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib_Base.DownloadNumber].ToString().Trim()); //下载数目
objvVideoLib_BaseEN.FileIntegration = objRow[convVideoLib_Base.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib_Base.FileIntegration].ToString().Trim()); //文件积分
objvVideoLib_BaseEN.LikeCount = objRow[convVideoLib_Base.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoLib_Base.LikeCount].ToString().Trim()); //资源喜欢数量
objvVideoLib_BaseEN.CollectionCount = objRow[convVideoLib_Base.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoLib_Base.CollectionCount].ToString().Trim()); //收藏数量
objvVideoLib_BaseEN.RecommendedDegreeId = objRow[convVideoLib_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvVideoLib_BaseEN.RecommendedDegreeName = objRow[convVideoLib_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convVideoLib_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvVideoLib_BaseEN.CourseId = objRow[convVideoLib_Base.CourseId].ToString().Trim(); //课程Id
objvVideoLib_BaseEN.CourseCode = objRow[convVideoLib_Base.CourseCode] == DBNull.Value ? null : objRow[convVideoLib_Base.CourseCode].ToString().Trim(); //课程代码
objvVideoLib_BaseEN.CourseName = objRow[convVideoLib_Base.CourseName] == DBNull.Value ? null : objRow[convVideoLib_Base.CourseName].ToString().Trim(); //课程名称
objvVideoLib_BaseEN.VideoUrl = objRow[convVideoLib_Base.VideoUrl] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoUrl].ToString().Trim(); //视频Url
objvVideoLib_BaseEN.VideoPath = objRow[convVideoLib_Base.VideoPath] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoPath].ToString().Trim(); //视频目录
objvVideoLib_BaseEN.CoverPicUrl = objRow[convVideoLib_Base.CoverPicUrl] == DBNull.Value ? null : objRow[convVideoLib_Base.CoverPicUrl].ToString().Trim(); //封面Url
objvVideoLib_BaseEN.CoverPicShortUrl = objRow[convVideoLib_Base.CoverPicShortUrl] == DBNull.Value ? null : objRow[convVideoLib_Base.CoverPicShortUrl].ToString().Trim(); //封面短Url
objvVideoLib_BaseEN.ResErrMsg = objRow[convVideoLib_Base.ResErrMsg] == DBNull.Value ? null : objRow[convVideoLib_Base.ResErrMsg].ToString().Trim(); //资源错误信息
objvVideoLib_BaseEN.Memo = objRow[convVideoLib_Base.Memo] == DBNull.Value ? null : objRow[convVideoLib_Base.Memo].ToString().Trim(); //备注
objvVideoLib_BaseEN.BrowseCount4Case = objRow[convVideoLib_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvVideoLib_BaseEN.OwnerName = objRow[convVideoLib_Base.OwnerName] == DBNull.Value ? null : objRow[convVideoLib_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvVideoLib_BaseEN.OwnerNameWithId = objRow[convVideoLib_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoLib_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvVideoLib_BaseDA: GetObjLst)", objException.Message));
}
objvVideoLib_BaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvVideoLib_BaseEN);
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
public List<clsvVideoLib_BaseEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvVideoLib_BaseDA:GetObjLstByTabName)", objException.Message));
}
List<clsvVideoLib_BaseEN> arrObjLst = new List<clsvVideoLib_BaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLib_BaseDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLib_BaseEN objvVideoLib_BaseEN = new clsvVideoLib_BaseEN();
try
{
objvVideoLib_BaseEN.IdVideoLib = objRow[convVideoLib_Base.IdVideoLib].ToString().Trim(); //视频库流水号
objvVideoLib_BaseEN.VideoLibID = objRow[convVideoLib_Base.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLib_BaseEN.VideoLibName = objRow[convVideoLib_Base.VideoLibName].ToString().Trim(); //视频名称
objvVideoLib_BaseEN.VideoLibTheme = objRow[convVideoLib_Base.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibTheme].ToString().Trim(); //视频库主题词
objvVideoLib_BaseEN.IdVideoLibType = objRow[convVideoLib_Base.IdVideoLibType].ToString().Trim(); //视频库类型流水号
objvVideoLib_BaseEN.VideoLibTypeName = objRow[convVideoLib_Base.VideoLibTypeName] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibTypeName].ToString().Trim(); //视频库类型名称
objvVideoLib_BaseEN.VideoLibText = objRow[convVideoLib_Base.VideoLibText] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibText].ToString().Trim(); //案例文本内容
objvVideoLib_BaseEN.VideoLibDate = objRow[convVideoLib_Base.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibDate].ToString().Trim(); //视频资源日期
objvVideoLib_BaseEN.VideoLibTime = objRow[convVideoLib_Base.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibTime].ToString().Trim(); //视频资源时间
objvVideoLib_BaseEN.VideoLibDateIn = objRow[convVideoLib_Base.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibDateIn].ToString().Trim(); //案例入库日期
objvVideoLib_BaseEN.VideoLibTimeIn = objRow[convVideoLib_Base.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objvVideoLib_BaseEN.OwnerId = objRow[convVideoLib_Base.OwnerId].ToString().Trim(); //拥有者Id
objvVideoLib_BaseEN.IdTeachingPlan = objRow[convVideoLib_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convVideoLib_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvVideoLib_BaseEN.IdSenateGaugeVersion = objRow[convVideoLib_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convVideoLib_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvVideoLib_BaseEN.senateGaugeVersionID = objRow[convVideoLib_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoLib_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoLib_BaseEN.senateGaugeVersionName = objRow[convVideoLib_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLib_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoLib_BaseEN.senateGaugeVersionTtlScore = objRow[convVideoLib_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convVideoLib_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoLib_BaseEN.VersionNo = objRow[convVideoLib_Base.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib_Base.VersionNo].ToString().Trim()); //版本号
objvVideoLib_BaseEN.CaseLevelId = objRow[convVideoLib_Base.CaseLevelId] == DBNull.Value ? null : objRow[convVideoLib_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvVideoLib_BaseEN.CaseLevelName = objRow[convVideoLib_Base.CaseLevelName] == DBNull.Value ? null : objRow[convVideoLib_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvVideoLib_BaseEN.IsVisible = TransNullToBool(objRow[convVideoLib_Base.IsVisible].ToString().Trim()); //是否显示
objvVideoLib_BaseEN.IdXzCollege = objRow[convVideoLib_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLib_BaseEN.CollegeID = objRow[convVideoLib_Base.CollegeID] == DBNull.Value ? null : objRow[convVideoLib_Base.CollegeID].ToString().Trim(); //学院ID
objvVideoLib_BaseEN.CollegeName = objRow[convVideoLib_Base.CollegeName] == DBNull.Value ? null : objRow[convVideoLib_Base.CollegeName].ToString().Trim(); //学院名称
objvVideoLib_BaseEN.CollegeNameA = objRow[convVideoLib_Base.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLib_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoLib_BaseEN.ViewCount = objRow[convVideoLib_Base.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib_Base.ViewCount].ToString().Trim()); //浏览量
objvVideoLib_BaseEN.DownloadNumber = objRow[convVideoLib_Base.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib_Base.DownloadNumber].ToString().Trim()); //下载数目
objvVideoLib_BaseEN.FileIntegration = objRow[convVideoLib_Base.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib_Base.FileIntegration].ToString().Trim()); //文件积分
objvVideoLib_BaseEN.LikeCount = objRow[convVideoLib_Base.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoLib_Base.LikeCount].ToString().Trim()); //资源喜欢数量
objvVideoLib_BaseEN.CollectionCount = objRow[convVideoLib_Base.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoLib_Base.CollectionCount].ToString().Trim()); //收藏数量
objvVideoLib_BaseEN.RecommendedDegreeId = objRow[convVideoLib_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvVideoLib_BaseEN.RecommendedDegreeName = objRow[convVideoLib_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convVideoLib_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvVideoLib_BaseEN.CourseId = objRow[convVideoLib_Base.CourseId].ToString().Trim(); //课程Id
objvVideoLib_BaseEN.CourseCode = objRow[convVideoLib_Base.CourseCode] == DBNull.Value ? null : objRow[convVideoLib_Base.CourseCode].ToString().Trim(); //课程代码
objvVideoLib_BaseEN.CourseName = objRow[convVideoLib_Base.CourseName] == DBNull.Value ? null : objRow[convVideoLib_Base.CourseName].ToString().Trim(); //课程名称
objvVideoLib_BaseEN.VideoUrl = objRow[convVideoLib_Base.VideoUrl] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoUrl].ToString().Trim(); //视频Url
objvVideoLib_BaseEN.VideoPath = objRow[convVideoLib_Base.VideoPath] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoPath].ToString().Trim(); //视频目录
objvVideoLib_BaseEN.CoverPicUrl = objRow[convVideoLib_Base.CoverPicUrl] == DBNull.Value ? null : objRow[convVideoLib_Base.CoverPicUrl].ToString().Trim(); //封面Url
objvVideoLib_BaseEN.CoverPicShortUrl = objRow[convVideoLib_Base.CoverPicShortUrl] == DBNull.Value ? null : objRow[convVideoLib_Base.CoverPicShortUrl].ToString().Trim(); //封面短Url
objvVideoLib_BaseEN.ResErrMsg = objRow[convVideoLib_Base.ResErrMsg] == DBNull.Value ? null : objRow[convVideoLib_Base.ResErrMsg].ToString().Trim(); //资源错误信息
objvVideoLib_BaseEN.Memo = objRow[convVideoLib_Base.Memo] == DBNull.Value ? null : objRow[convVideoLib_Base.Memo].ToString().Trim(); //备注
objvVideoLib_BaseEN.BrowseCount4Case = objRow[convVideoLib_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvVideoLib_BaseEN.OwnerName = objRow[convVideoLib_Base.OwnerName] == DBNull.Value ? null : objRow[convVideoLib_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvVideoLib_BaseEN.OwnerNameWithId = objRow[convVideoLib_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoLib_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvVideoLib_BaseDA: GetObjLst)", objException.Message));
}
objvVideoLib_BaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvVideoLib_BaseEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvVideoLib_Base(ref clsvVideoLib_BaseEN objvVideoLib_BaseEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLib_BaseDA.GetSpecSQLObj();
strSQL = "Select * from vVideoLib_Base where IdVideoLib = " + "'"+ objvVideoLib_BaseEN.IdVideoLib+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvVideoLib_BaseEN.IdVideoLib = objDT.Rows[0][convVideoLib_Base.IdVideoLib].ToString().Trim(); //视频库流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoLib_BaseEN.VideoLibID = objDT.Rows[0][convVideoLib_Base.VideoLibID].ToString().Trim(); //视频库ID(字段类型:char,字段长度:8,是否可空:False)
 objvVideoLib_BaseEN.VideoLibName = objDT.Rows[0][convVideoLib_Base.VideoLibName].ToString().Trim(); //视频名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvVideoLib_BaseEN.VideoLibTheme = objDT.Rows[0][convVideoLib_Base.VideoLibTheme].ToString().Trim(); //视频库主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoLib_BaseEN.IdVideoLibType = objDT.Rows[0][convVideoLib_Base.IdVideoLibType].ToString().Trim(); //视频库类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvVideoLib_BaseEN.VideoLibTypeName = objDT.Rows[0][convVideoLib_Base.VideoLibTypeName].ToString().Trim(); //视频库类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvVideoLib_BaseEN.VideoLibText = objDT.Rows[0][convVideoLib_Base.VideoLibText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objvVideoLib_BaseEN.VideoLibDate = objDT.Rows[0][convVideoLib_Base.VideoLibDate].ToString().Trim(); //视频资源日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvVideoLib_BaseEN.VideoLibTime = objDT.Rows[0][convVideoLib_Base.VideoLibTime].ToString().Trim(); //视频资源时间(字段类型:char,字段长度:6,是否可空:True)
 objvVideoLib_BaseEN.VideoLibDateIn = objDT.Rows[0][convVideoLib_Base.VideoLibDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvVideoLib_BaseEN.VideoLibTimeIn = objDT.Rows[0][convVideoLib_Base.VideoLibTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvVideoLib_BaseEN.OwnerId = objDT.Rows[0][convVideoLib_Base.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvVideoLib_BaseEN.IdTeachingPlan = objDT.Rows[0][convVideoLib_Base.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoLib_BaseEN.IdSenateGaugeVersion = objDT.Rows[0][convVideoLib_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvVideoLib_BaseEN.senateGaugeVersionID = objDT.Rows[0][convVideoLib_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvVideoLib_BaseEN.senateGaugeVersionName = objDT.Rows[0][convVideoLib_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoLib_BaseEN.senateGaugeVersionTtlScore = TransNullToFloat(objDT.Rows[0][convVideoLib_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvVideoLib_BaseEN.VersionNo = TransNullToInt(objDT.Rows[0][convVideoLib_Base.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvVideoLib_BaseEN.CaseLevelId = objDT.Rows[0][convVideoLib_Base.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvVideoLib_BaseEN.CaseLevelName = objDT.Rows[0][convVideoLib_Base.CaseLevelName].ToString().Trim(); //案例等级名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvVideoLib_BaseEN.IsVisible = TransNullToBool(objDT.Rows[0][convVideoLib_Base.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvVideoLib_BaseEN.IdXzCollege = objDT.Rows[0][convVideoLib_Base.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvVideoLib_BaseEN.CollegeID = objDT.Rows[0][convVideoLib_Base.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvVideoLib_BaseEN.CollegeName = objDT.Rows[0][convVideoLib_Base.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvVideoLib_BaseEN.CollegeNameA = objDT.Rows[0][convVideoLib_Base.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvVideoLib_BaseEN.ViewCount = TransNullToInt(objDT.Rows[0][convVideoLib_Base.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvVideoLib_BaseEN.DownloadNumber = TransNullToInt(objDT.Rows[0][convVideoLib_Base.DownloadNumber].ToString().Trim()); //下载数目(字段类型:int,字段长度:4,是否可空:True)
 objvVideoLib_BaseEN.FileIntegration = TransNullToInt(objDT.Rows[0][convVideoLib_Base.FileIntegration].ToString().Trim()); //文件积分(字段类型:int,字段长度:4,是否可空:True)
 objvVideoLib_BaseEN.LikeCount = TransNullToInt(objDT.Rows[0][convVideoLib_Base.LikeCount].ToString().Trim()); //资源喜欢数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvVideoLib_BaseEN.CollectionCount = TransNullToInt(objDT.Rows[0][convVideoLib_Base.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvVideoLib_BaseEN.RecommendedDegreeId = objDT.Rows[0][convVideoLib_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvVideoLib_BaseEN.RecommendedDegreeName = objDT.Rows[0][convVideoLib_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvVideoLib_BaseEN.CourseId = objDT.Rows[0][convVideoLib_Base.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvVideoLib_BaseEN.CourseCode = objDT.Rows[0][convVideoLib_Base.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvVideoLib_BaseEN.CourseName = objDT.Rows[0][convVideoLib_Base.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvVideoLib_BaseEN.VideoUrl = objDT.Rows[0][convVideoLib_Base.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objvVideoLib_BaseEN.VideoPath = objDT.Rows[0][convVideoLib_Base.VideoPath].ToString().Trim(); //视频目录(字段类型:varchar,字段长度:1000,是否可空:True)
 objvVideoLib_BaseEN.CoverPicUrl = objDT.Rows[0][convVideoLib_Base.CoverPicUrl].ToString().Trim(); //封面Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objvVideoLib_BaseEN.CoverPicShortUrl = objDT.Rows[0][convVideoLib_Base.CoverPicShortUrl].ToString().Trim(); //封面短Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objvVideoLib_BaseEN.ResErrMsg = objDT.Rows[0][convVideoLib_Base.ResErrMsg].ToString().Trim(); //资源错误信息(字段类型:varchar,字段长度:30,是否可空:True)
 objvVideoLib_BaseEN.Memo = objDT.Rows[0][convVideoLib_Base.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvVideoLib_BaseEN.BrowseCount4Case = TransNullToInt(objDT.Rows[0][convVideoLib_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvVideoLib_BaseEN.OwnerName = objDT.Rows[0][convVideoLib_Base.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvVideoLib_BaseEN.OwnerNameWithId = objDT.Rows[0][convVideoLib_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvVideoLib_BaseDA: GetvVideoLib_Base)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdVideoLib">表关键字</param>
 /// <returns>表对象</returns>
public clsvVideoLib_BaseEN GetObjByIdVideoLib(string strIdVideoLib)
{
CheckPrimaryKey(strIdVideoLib);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLib_BaseDA.GetSpecSQLObj();
strSQL = "Select * from vVideoLib_Base where IdVideoLib = " + "'"+ strIdVideoLib+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvVideoLib_BaseEN objvVideoLib_BaseEN = new clsvVideoLib_BaseEN();
try
{
 objvVideoLib_BaseEN.IdVideoLib = objRow[convVideoLib_Base.IdVideoLib].ToString().Trim(); //视频库流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoLib_BaseEN.VideoLibID = objRow[convVideoLib_Base.VideoLibID].ToString().Trim(); //视频库ID(字段类型:char,字段长度:8,是否可空:False)
 objvVideoLib_BaseEN.VideoLibName = objRow[convVideoLib_Base.VideoLibName].ToString().Trim(); //视频名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvVideoLib_BaseEN.VideoLibTheme = objRow[convVideoLib_Base.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibTheme].ToString().Trim(); //视频库主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoLib_BaseEN.IdVideoLibType = objRow[convVideoLib_Base.IdVideoLibType].ToString().Trim(); //视频库类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvVideoLib_BaseEN.VideoLibTypeName = objRow[convVideoLib_Base.VideoLibTypeName] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibTypeName].ToString().Trim(); //视频库类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvVideoLib_BaseEN.VideoLibText = objRow[convVideoLib_Base.VideoLibText] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objvVideoLib_BaseEN.VideoLibDate = objRow[convVideoLib_Base.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibDate].ToString().Trim(); //视频资源日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvVideoLib_BaseEN.VideoLibTime = objRow[convVideoLib_Base.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibTime].ToString().Trim(); //视频资源时间(字段类型:char,字段长度:6,是否可空:True)
 objvVideoLib_BaseEN.VideoLibDateIn = objRow[convVideoLib_Base.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvVideoLib_BaseEN.VideoLibTimeIn = objRow[convVideoLib_Base.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvVideoLib_BaseEN.OwnerId = objRow[convVideoLib_Base.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvVideoLib_BaseEN.IdTeachingPlan = objRow[convVideoLib_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convVideoLib_Base.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoLib_BaseEN.IdSenateGaugeVersion = objRow[convVideoLib_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convVideoLib_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvVideoLib_BaseEN.senateGaugeVersionID = objRow[convVideoLib_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoLib_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvVideoLib_BaseEN.senateGaugeVersionName = objRow[convVideoLib_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLib_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoLib_BaseEN.senateGaugeVersionTtlScore = objRow[convVideoLib_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convVideoLib_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvVideoLib_BaseEN.VersionNo = objRow[convVideoLib_Base.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvVideoLib_BaseEN.CaseLevelId = objRow[convVideoLib_Base.CaseLevelId] == DBNull.Value ? null : objRow[convVideoLib_Base.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvVideoLib_BaseEN.CaseLevelName = objRow[convVideoLib_Base.CaseLevelName] == DBNull.Value ? null : objRow[convVideoLib_Base.CaseLevelName].ToString().Trim(); //案例等级名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvVideoLib_BaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib_Base.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvVideoLib_BaseEN.IdXzCollege = objRow[convVideoLib_Base.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvVideoLib_BaseEN.CollegeID = objRow[convVideoLib_Base.CollegeID] == DBNull.Value ? null : objRow[convVideoLib_Base.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvVideoLib_BaseEN.CollegeName = objRow[convVideoLib_Base.CollegeName] == DBNull.Value ? null : objRow[convVideoLib_Base.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvVideoLib_BaseEN.CollegeNameA = objRow[convVideoLib_Base.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLib_Base.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvVideoLib_BaseEN.ViewCount = objRow[convVideoLib_Base.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvVideoLib_BaseEN.DownloadNumber = objRow[convVideoLib_Base.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.DownloadNumber].ToString().Trim()); //下载数目(字段类型:int,字段长度:4,是否可空:True)
 objvVideoLib_BaseEN.FileIntegration = objRow[convVideoLib_Base.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.FileIntegration].ToString().Trim()); //文件积分(字段类型:int,字段长度:4,是否可空:True)
 objvVideoLib_BaseEN.LikeCount = objRow[convVideoLib_Base.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.LikeCount].ToString().Trim()); //资源喜欢数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvVideoLib_BaseEN.CollectionCount = objRow[convVideoLib_Base.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvVideoLib_BaseEN.RecommendedDegreeId = objRow[convVideoLib_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvVideoLib_BaseEN.RecommendedDegreeName = objRow[convVideoLib_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convVideoLib_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvVideoLib_BaseEN.CourseId = objRow[convVideoLib_Base.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvVideoLib_BaseEN.CourseCode = objRow[convVideoLib_Base.CourseCode] == DBNull.Value ? null : objRow[convVideoLib_Base.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvVideoLib_BaseEN.CourseName = objRow[convVideoLib_Base.CourseName] == DBNull.Value ? null : objRow[convVideoLib_Base.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvVideoLib_BaseEN.VideoUrl = objRow[convVideoLib_Base.VideoUrl] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objvVideoLib_BaseEN.VideoPath = objRow[convVideoLib_Base.VideoPath] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoPath].ToString().Trim(); //视频目录(字段类型:varchar,字段长度:1000,是否可空:True)
 objvVideoLib_BaseEN.CoverPicUrl = objRow[convVideoLib_Base.CoverPicUrl] == DBNull.Value ? null : objRow[convVideoLib_Base.CoverPicUrl].ToString().Trim(); //封面Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objvVideoLib_BaseEN.CoverPicShortUrl = objRow[convVideoLib_Base.CoverPicShortUrl] == DBNull.Value ? null : objRow[convVideoLib_Base.CoverPicShortUrl].ToString().Trim(); //封面短Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objvVideoLib_BaseEN.ResErrMsg = objRow[convVideoLib_Base.ResErrMsg] == DBNull.Value ? null : objRow[convVideoLib_Base.ResErrMsg].ToString().Trim(); //资源错误信息(字段类型:varchar,字段长度:30,是否可空:True)
 objvVideoLib_BaseEN.Memo = objRow[convVideoLib_Base.Memo] == DBNull.Value ? null : objRow[convVideoLib_Base.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvVideoLib_BaseEN.BrowseCount4Case = objRow[convVideoLib_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvVideoLib_BaseEN.OwnerName = objRow[convVideoLib_Base.OwnerName] == DBNull.Value ? null : objRow[convVideoLib_Base.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvVideoLib_BaseEN.OwnerNameWithId = objRow[convVideoLib_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoLib_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvVideoLib_BaseDA: GetObjByIdVideoLib)", objException.Message));
}
return objvVideoLib_BaseEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvVideoLib_BaseEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvVideoLib_BaseDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLib_BaseDA.GetSpecSQLObj();
strSQL = "Select * from vVideoLib_Base where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvVideoLib_BaseEN objvVideoLib_BaseEN = new clsvVideoLib_BaseEN()
{
IdVideoLib = objRow[convVideoLib_Base.IdVideoLib].ToString().Trim(), //视频库流水号
VideoLibID = objRow[convVideoLib_Base.VideoLibID].ToString().Trim(), //视频库ID
VideoLibName = objRow[convVideoLib_Base.VideoLibName].ToString().Trim(), //视频名称
VideoLibTheme = objRow[convVideoLib_Base.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibTheme].ToString().Trim(), //视频库主题词
IdVideoLibType = objRow[convVideoLib_Base.IdVideoLibType].ToString().Trim(), //视频库类型流水号
VideoLibTypeName = objRow[convVideoLib_Base.VideoLibTypeName] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibTypeName].ToString().Trim(), //视频库类型名称
VideoLibText = objRow[convVideoLib_Base.VideoLibText] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibText].ToString().Trim(), //案例文本内容
VideoLibDate = objRow[convVideoLib_Base.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibDate].ToString().Trim(), //视频资源日期
VideoLibTime = objRow[convVideoLib_Base.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibTime].ToString().Trim(), //视频资源时间
VideoLibDateIn = objRow[convVideoLib_Base.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibDateIn].ToString().Trim(), //案例入库日期
VideoLibTimeIn = objRow[convVideoLib_Base.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibTimeIn].ToString().Trim(), //案例入库时间
OwnerId = objRow[convVideoLib_Base.OwnerId].ToString().Trim(), //拥有者Id
IdTeachingPlan = objRow[convVideoLib_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convVideoLib_Base.IdTeachingPlan].ToString().Trim(), //教案流水号
IdSenateGaugeVersion = objRow[convVideoLib_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convVideoLib_Base.IdSenateGaugeVersion].ToString().Trim(), //评价量表版本流水号
senateGaugeVersionID = objRow[convVideoLib_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoLib_Base.senateGaugeVersionID].ToString().Trim(), //评价量表版本ID
senateGaugeVersionName = objRow[convVideoLib_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLib_Base.senateGaugeVersionName].ToString().Trim(), //评价量表版本名称
senateGaugeVersionTtlScore = objRow[convVideoLib_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convVideoLib_Base.senateGaugeVersionTtlScore].ToString().Trim()), //评价量表版本总分
VersionNo = objRow[convVideoLib_Base.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib_Base.VersionNo].ToString().Trim()), //版本号
CaseLevelId = objRow[convVideoLib_Base.CaseLevelId] == DBNull.Value ? null : objRow[convVideoLib_Base.CaseLevelId].ToString().Trim(), //课例等级Id
CaseLevelName = objRow[convVideoLib_Base.CaseLevelName] == DBNull.Value ? null : objRow[convVideoLib_Base.CaseLevelName].ToString().Trim(), //案例等级名称
IsVisible = TransNullToBool(objRow[convVideoLib_Base.IsVisible].ToString().Trim()), //是否显示
IdXzCollege = objRow[convVideoLib_Base.IdXzCollege].ToString().Trim(), //学院流水号
CollegeID = objRow[convVideoLib_Base.CollegeID] == DBNull.Value ? null : objRow[convVideoLib_Base.CollegeID].ToString().Trim(), //学院ID
CollegeName = objRow[convVideoLib_Base.CollegeName] == DBNull.Value ? null : objRow[convVideoLib_Base.CollegeName].ToString().Trim(), //学院名称
CollegeNameA = objRow[convVideoLib_Base.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLib_Base.CollegeNameA].ToString().Trim(), //学院名称简写
ViewCount = objRow[convVideoLib_Base.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib_Base.ViewCount].ToString().Trim()), //浏览量
DownloadNumber = objRow[convVideoLib_Base.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib_Base.DownloadNumber].ToString().Trim()), //下载数目
FileIntegration = objRow[convVideoLib_Base.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib_Base.FileIntegration].ToString().Trim()), //文件积分
LikeCount = objRow[convVideoLib_Base.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoLib_Base.LikeCount].ToString().Trim()), //资源喜欢数量
CollectionCount = objRow[convVideoLib_Base.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoLib_Base.CollectionCount].ToString().Trim()), //收藏数量
RecommendedDegreeId = objRow[convVideoLib_Base.RecommendedDegreeId].ToString().Trim(), //推荐度Id
RecommendedDegreeName = objRow[convVideoLib_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convVideoLib_Base.RecommendedDegreeName].ToString().Trim(), //推荐度名称
CourseId = objRow[convVideoLib_Base.CourseId].ToString().Trim(), //课程Id
CourseCode = objRow[convVideoLib_Base.CourseCode] == DBNull.Value ? null : objRow[convVideoLib_Base.CourseCode].ToString().Trim(), //课程代码
CourseName = objRow[convVideoLib_Base.CourseName] == DBNull.Value ? null : objRow[convVideoLib_Base.CourseName].ToString().Trim(), //课程名称
VideoUrl = objRow[convVideoLib_Base.VideoUrl] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoUrl].ToString().Trim(), //视频Url
VideoPath = objRow[convVideoLib_Base.VideoPath] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoPath].ToString().Trim(), //视频目录
CoverPicUrl = objRow[convVideoLib_Base.CoverPicUrl] == DBNull.Value ? null : objRow[convVideoLib_Base.CoverPicUrl].ToString().Trim(), //封面Url
CoverPicShortUrl = objRow[convVideoLib_Base.CoverPicShortUrl] == DBNull.Value ? null : objRow[convVideoLib_Base.CoverPicShortUrl].ToString().Trim(), //封面短Url
ResErrMsg = objRow[convVideoLib_Base.ResErrMsg] == DBNull.Value ? null : objRow[convVideoLib_Base.ResErrMsg].ToString().Trim(), //资源错误信息
Memo = objRow[convVideoLib_Base.Memo] == DBNull.Value ? null : objRow[convVideoLib_Base.Memo].ToString().Trim(), //备注
BrowseCount4Case = objRow[convVideoLib_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib_Base.BrowseCount4Case].ToString().Trim()), //课例浏览次数
OwnerName = objRow[convVideoLib_Base.OwnerName] == DBNull.Value ? null : objRow[convVideoLib_Base.OwnerName].ToString().Trim(), //拥有者姓名
OwnerNameWithId = objRow[convVideoLib_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoLib_Base.OwnerNameWithId].ToString().Trim() //拥有者名称附Id
};
objvVideoLib_BaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvVideoLib_BaseEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvVideoLib_BaseDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvVideoLib_BaseEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvVideoLib_BaseEN objvVideoLib_BaseEN = new clsvVideoLib_BaseEN();
try
{
objvVideoLib_BaseEN.IdVideoLib = objRow[convVideoLib_Base.IdVideoLib].ToString().Trim(); //视频库流水号
objvVideoLib_BaseEN.VideoLibID = objRow[convVideoLib_Base.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLib_BaseEN.VideoLibName = objRow[convVideoLib_Base.VideoLibName].ToString().Trim(); //视频名称
objvVideoLib_BaseEN.VideoLibTheme = objRow[convVideoLib_Base.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibTheme].ToString().Trim(); //视频库主题词
objvVideoLib_BaseEN.IdVideoLibType = objRow[convVideoLib_Base.IdVideoLibType].ToString().Trim(); //视频库类型流水号
objvVideoLib_BaseEN.VideoLibTypeName = objRow[convVideoLib_Base.VideoLibTypeName] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibTypeName].ToString().Trim(); //视频库类型名称
objvVideoLib_BaseEN.VideoLibText = objRow[convVideoLib_Base.VideoLibText] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibText].ToString().Trim(); //案例文本内容
objvVideoLib_BaseEN.VideoLibDate = objRow[convVideoLib_Base.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibDate].ToString().Trim(); //视频资源日期
objvVideoLib_BaseEN.VideoLibTime = objRow[convVideoLib_Base.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibTime].ToString().Trim(); //视频资源时间
objvVideoLib_BaseEN.VideoLibDateIn = objRow[convVideoLib_Base.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibDateIn].ToString().Trim(); //案例入库日期
objvVideoLib_BaseEN.VideoLibTimeIn = objRow[convVideoLib_Base.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objvVideoLib_BaseEN.OwnerId = objRow[convVideoLib_Base.OwnerId].ToString().Trim(); //拥有者Id
objvVideoLib_BaseEN.IdTeachingPlan = objRow[convVideoLib_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convVideoLib_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvVideoLib_BaseEN.IdSenateGaugeVersion = objRow[convVideoLib_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convVideoLib_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvVideoLib_BaseEN.senateGaugeVersionID = objRow[convVideoLib_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoLib_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoLib_BaseEN.senateGaugeVersionName = objRow[convVideoLib_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLib_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoLib_BaseEN.senateGaugeVersionTtlScore = objRow[convVideoLib_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convVideoLib_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoLib_BaseEN.VersionNo = objRow[convVideoLib_Base.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib_Base.VersionNo].ToString().Trim()); //版本号
objvVideoLib_BaseEN.CaseLevelId = objRow[convVideoLib_Base.CaseLevelId] == DBNull.Value ? null : objRow[convVideoLib_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvVideoLib_BaseEN.CaseLevelName = objRow[convVideoLib_Base.CaseLevelName] == DBNull.Value ? null : objRow[convVideoLib_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvVideoLib_BaseEN.IsVisible = TransNullToBool(objRow[convVideoLib_Base.IsVisible].ToString().Trim()); //是否显示
objvVideoLib_BaseEN.IdXzCollege = objRow[convVideoLib_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLib_BaseEN.CollegeID = objRow[convVideoLib_Base.CollegeID] == DBNull.Value ? null : objRow[convVideoLib_Base.CollegeID].ToString().Trim(); //学院ID
objvVideoLib_BaseEN.CollegeName = objRow[convVideoLib_Base.CollegeName] == DBNull.Value ? null : objRow[convVideoLib_Base.CollegeName].ToString().Trim(); //学院名称
objvVideoLib_BaseEN.CollegeNameA = objRow[convVideoLib_Base.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLib_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoLib_BaseEN.ViewCount = objRow[convVideoLib_Base.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib_Base.ViewCount].ToString().Trim()); //浏览量
objvVideoLib_BaseEN.DownloadNumber = objRow[convVideoLib_Base.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib_Base.DownloadNumber].ToString().Trim()); //下载数目
objvVideoLib_BaseEN.FileIntegration = objRow[convVideoLib_Base.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib_Base.FileIntegration].ToString().Trim()); //文件积分
objvVideoLib_BaseEN.LikeCount = objRow[convVideoLib_Base.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoLib_Base.LikeCount].ToString().Trim()); //资源喜欢数量
objvVideoLib_BaseEN.CollectionCount = objRow[convVideoLib_Base.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoLib_Base.CollectionCount].ToString().Trim()); //收藏数量
objvVideoLib_BaseEN.RecommendedDegreeId = objRow[convVideoLib_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvVideoLib_BaseEN.RecommendedDegreeName = objRow[convVideoLib_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convVideoLib_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvVideoLib_BaseEN.CourseId = objRow[convVideoLib_Base.CourseId].ToString().Trim(); //课程Id
objvVideoLib_BaseEN.CourseCode = objRow[convVideoLib_Base.CourseCode] == DBNull.Value ? null : objRow[convVideoLib_Base.CourseCode].ToString().Trim(); //课程代码
objvVideoLib_BaseEN.CourseName = objRow[convVideoLib_Base.CourseName] == DBNull.Value ? null : objRow[convVideoLib_Base.CourseName].ToString().Trim(); //课程名称
objvVideoLib_BaseEN.VideoUrl = objRow[convVideoLib_Base.VideoUrl] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoUrl].ToString().Trim(); //视频Url
objvVideoLib_BaseEN.VideoPath = objRow[convVideoLib_Base.VideoPath] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoPath].ToString().Trim(); //视频目录
objvVideoLib_BaseEN.CoverPicUrl = objRow[convVideoLib_Base.CoverPicUrl] == DBNull.Value ? null : objRow[convVideoLib_Base.CoverPicUrl].ToString().Trim(); //封面Url
objvVideoLib_BaseEN.CoverPicShortUrl = objRow[convVideoLib_Base.CoverPicShortUrl] == DBNull.Value ? null : objRow[convVideoLib_Base.CoverPicShortUrl].ToString().Trim(); //封面短Url
objvVideoLib_BaseEN.ResErrMsg = objRow[convVideoLib_Base.ResErrMsg] == DBNull.Value ? null : objRow[convVideoLib_Base.ResErrMsg].ToString().Trim(); //资源错误信息
objvVideoLib_BaseEN.Memo = objRow[convVideoLib_Base.Memo] == DBNull.Value ? null : objRow[convVideoLib_Base.Memo].ToString().Trim(); //备注
objvVideoLib_BaseEN.BrowseCount4Case = objRow[convVideoLib_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvVideoLib_BaseEN.OwnerName = objRow[convVideoLib_Base.OwnerName] == DBNull.Value ? null : objRow[convVideoLib_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvVideoLib_BaseEN.OwnerNameWithId = objRow[convVideoLib_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoLib_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvVideoLib_BaseDA: GetObjByDataRowvVideoLib_Base)", objException.Message));
}
objvVideoLib_BaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvVideoLib_BaseEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvVideoLib_BaseEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvVideoLib_BaseEN objvVideoLib_BaseEN = new clsvVideoLib_BaseEN();
try
{
objvVideoLib_BaseEN.IdVideoLib = objRow[convVideoLib_Base.IdVideoLib].ToString().Trim(); //视频库流水号
objvVideoLib_BaseEN.VideoLibID = objRow[convVideoLib_Base.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLib_BaseEN.VideoLibName = objRow[convVideoLib_Base.VideoLibName].ToString().Trim(); //视频名称
objvVideoLib_BaseEN.VideoLibTheme = objRow[convVideoLib_Base.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibTheme].ToString().Trim(); //视频库主题词
objvVideoLib_BaseEN.IdVideoLibType = objRow[convVideoLib_Base.IdVideoLibType].ToString().Trim(); //视频库类型流水号
objvVideoLib_BaseEN.VideoLibTypeName = objRow[convVideoLib_Base.VideoLibTypeName] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibTypeName].ToString().Trim(); //视频库类型名称
objvVideoLib_BaseEN.VideoLibText = objRow[convVideoLib_Base.VideoLibText] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibText].ToString().Trim(); //案例文本内容
objvVideoLib_BaseEN.VideoLibDate = objRow[convVideoLib_Base.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibDate].ToString().Trim(); //视频资源日期
objvVideoLib_BaseEN.VideoLibTime = objRow[convVideoLib_Base.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibTime].ToString().Trim(); //视频资源时间
objvVideoLib_BaseEN.VideoLibDateIn = objRow[convVideoLib_Base.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibDateIn].ToString().Trim(); //案例入库日期
objvVideoLib_BaseEN.VideoLibTimeIn = objRow[convVideoLib_Base.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objvVideoLib_BaseEN.OwnerId = objRow[convVideoLib_Base.OwnerId].ToString().Trim(); //拥有者Id
objvVideoLib_BaseEN.IdTeachingPlan = objRow[convVideoLib_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convVideoLib_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvVideoLib_BaseEN.IdSenateGaugeVersion = objRow[convVideoLib_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convVideoLib_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvVideoLib_BaseEN.senateGaugeVersionID = objRow[convVideoLib_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoLib_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoLib_BaseEN.senateGaugeVersionName = objRow[convVideoLib_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLib_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoLib_BaseEN.senateGaugeVersionTtlScore = objRow[convVideoLib_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convVideoLib_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoLib_BaseEN.VersionNo = objRow[convVideoLib_Base.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib_Base.VersionNo].ToString().Trim()); //版本号
objvVideoLib_BaseEN.CaseLevelId = objRow[convVideoLib_Base.CaseLevelId] == DBNull.Value ? null : objRow[convVideoLib_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvVideoLib_BaseEN.CaseLevelName = objRow[convVideoLib_Base.CaseLevelName] == DBNull.Value ? null : objRow[convVideoLib_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvVideoLib_BaseEN.IsVisible = TransNullToBool(objRow[convVideoLib_Base.IsVisible].ToString().Trim()); //是否显示
objvVideoLib_BaseEN.IdXzCollege = objRow[convVideoLib_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLib_BaseEN.CollegeID = objRow[convVideoLib_Base.CollegeID] == DBNull.Value ? null : objRow[convVideoLib_Base.CollegeID].ToString().Trim(); //学院ID
objvVideoLib_BaseEN.CollegeName = objRow[convVideoLib_Base.CollegeName] == DBNull.Value ? null : objRow[convVideoLib_Base.CollegeName].ToString().Trim(); //学院名称
objvVideoLib_BaseEN.CollegeNameA = objRow[convVideoLib_Base.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLib_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoLib_BaseEN.ViewCount = objRow[convVideoLib_Base.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib_Base.ViewCount].ToString().Trim()); //浏览量
objvVideoLib_BaseEN.DownloadNumber = objRow[convVideoLib_Base.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib_Base.DownloadNumber].ToString().Trim()); //下载数目
objvVideoLib_BaseEN.FileIntegration = objRow[convVideoLib_Base.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib_Base.FileIntegration].ToString().Trim()); //文件积分
objvVideoLib_BaseEN.LikeCount = objRow[convVideoLib_Base.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoLib_Base.LikeCount].ToString().Trim()); //资源喜欢数量
objvVideoLib_BaseEN.CollectionCount = objRow[convVideoLib_Base.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoLib_Base.CollectionCount].ToString().Trim()); //收藏数量
objvVideoLib_BaseEN.RecommendedDegreeId = objRow[convVideoLib_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvVideoLib_BaseEN.RecommendedDegreeName = objRow[convVideoLib_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convVideoLib_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvVideoLib_BaseEN.CourseId = objRow[convVideoLib_Base.CourseId].ToString().Trim(); //课程Id
objvVideoLib_BaseEN.CourseCode = objRow[convVideoLib_Base.CourseCode] == DBNull.Value ? null : objRow[convVideoLib_Base.CourseCode].ToString().Trim(); //课程代码
objvVideoLib_BaseEN.CourseName = objRow[convVideoLib_Base.CourseName] == DBNull.Value ? null : objRow[convVideoLib_Base.CourseName].ToString().Trim(); //课程名称
objvVideoLib_BaseEN.VideoUrl = objRow[convVideoLib_Base.VideoUrl] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoUrl].ToString().Trim(); //视频Url
objvVideoLib_BaseEN.VideoPath = objRow[convVideoLib_Base.VideoPath] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoPath].ToString().Trim(); //视频目录
objvVideoLib_BaseEN.CoverPicUrl = objRow[convVideoLib_Base.CoverPicUrl] == DBNull.Value ? null : objRow[convVideoLib_Base.CoverPicUrl].ToString().Trim(); //封面Url
objvVideoLib_BaseEN.CoverPicShortUrl = objRow[convVideoLib_Base.CoverPicShortUrl] == DBNull.Value ? null : objRow[convVideoLib_Base.CoverPicShortUrl].ToString().Trim(); //封面短Url
objvVideoLib_BaseEN.ResErrMsg = objRow[convVideoLib_Base.ResErrMsg] == DBNull.Value ? null : objRow[convVideoLib_Base.ResErrMsg].ToString().Trim(); //资源错误信息
objvVideoLib_BaseEN.Memo = objRow[convVideoLib_Base.Memo] == DBNull.Value ? null : objRow[convVideoLib_Base.Memo].ToString().Trim(); //备注
objvVideoLib_BaseEN.BrowseCount4Case = objRow[convVideoLib_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoLib_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvVideoLib_BaseEN.OwnerName = objRow[convVideoLib_Base.OwnerName] == DBNull.Value ? null : objRow[convVideoLib_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvVideoLib_BaseEN.OwnerNameWithId = objRow[convVideoLib_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoLib_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvVideoLib_BaseDA: GetObjByDataRow)", objException.Message));
}
objvVideoLib_BaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvVideoLib_BaseEN;
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
objSQL = clsvVideoLib_BaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvVideoLib_BaseEN._CurrTabName, convVideoLib_Base.IdVideoLib, 8, "");
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
objSQL = clsvVideoLib_BaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvVideoLib_BaseEN._CurrTabName, convVideoLib_Base.IdVideoLib, 8, strPrefix);
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
 objSQL = clsvVideoLib_BaseDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdVideoLib from vVideoLib_Base where " + strCondition;
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
 objSQL = clsvVideoLib_BaseDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdVideoLib from vVideoLib_Base where " + strCondition;
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
 objSQL = clsvVideoLib_BaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vVideoLib_Base", "IdVideoLib = " + "'"+ strIdVideoLib+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvVideoLib_BaseDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoLib_BaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vVideoLib_Base", strCondition))
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
objSQL = clsvVideoLib_BaseDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vVideoLib_Base");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvVideoLib_BaseENS">源对象</param>
 /// <param name = "objvVideoLib_BaseENT">目标对象</param>
public void CopyTo(clsvVideoLib_BaseEN objvVideoLib_BaseENS, clsvVideoLib_BaseEN objvVideoLib_BaseENT)
{
objvVideoLib_BaseENT.IdVideoLib = objvVideoLib_BaseENS.IdVideoLib; //视频库流水号
objvVideoLib_BaseENT.VideoLibID = objvVideoLib_BaseENS.VideoLibID; //视频库ID
objvVideoLib_BaseENT.VideoLibName = objvVideoLib_BaseENS.VideoLibName; //视频名称
objvVideoLib_BaseENT.VideoLibTheme = objvVideoLib_BaseENS.VideoLibTheme; //视频库主题词
objvVideoLib_BaseENT.IdVideoLibType = objvVideoLib_BaseENS.IdVideoLibType; //视频库类型流水号
objvVideoLib_BaseENT.VideoLibTypeName = objvVideoLib_BaseENS.VideoLibTypeName; //视频库类型名称
objvVideoLib_BaseENT.VideoLibText = objvVideoLib_BaseENS.VideoLibText; //案例文本内容
objvVideoLib_BaseENT.VideoLibDate = objvVideoLib_BaseENS.VideoLibDate; //视频资源日期
objvVideoLib_BaseENT.VideoLibTime = objvVideoLib_BaseENS.VideoLibTime; //视频资源时间
objvVideoLib_BaseENT.VideoLibDateIn = objvVideoLib_BaseENS.VideoLibDateIn; //案例入库日期
objvVideoLib_BaseENT.VideoLibTimeIn = objvVideoLib_BaseENS.VideoLibTimeIn; //案例入库时间
objvVideoLib_BaseENT.OwnerId = objvVideoLib_BaseENS.OwnerId; //拥有者Id
objvVideoLib_BaseENT.IdTeachingPlan = objvVideoLib_BaseENS.IdTeachingPlan; //教案流水号
objvVideoLib_BaseENT.IdSenateGaugeVersion = objvVideoLib_BaseENS.IdSenateGaugeVersion; //评价量表版本流水号
objvVideoLib_BaseENT.senateGaugeVersionID = objvVideoLib_BaseENS.senateGaugeVersionID; //评价量表版本ID
objvVideoLib_BaseENT.senateGaugeVersionName = objvVideoLib_BaseENS.senateGaugeVersionName; //评价量表版本名称
objvVideoLib_BaseENT.senateGaugeVersionTtlScore = objvVideoLib_BaseENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvVideoLib_BaseENT.VersionNo = objvVideoLib_BaseENS.VersionNo; //版本号
objvVideoLib_BaseENT.CaseLevelId = objvVideoLib_BaseENS.CaseLevelId; //课例等级Id
objvVideoLib_BaseENT.CaseLevelName = objvVideoLib_BaseENS.CaseLevelName; //案例等级名称
objvVideoLib_BaseENT.IsVisible = objvVideoLib_BaseENS.IsVisible; //是否显示
objvVideoLib_BaseENT.IdXzCollege = objvVideoLib_BaseENS.IdXzCollege; //学院流水号
objvVideoLib_BaseENT.CollegeID = objvVideoLib_BaseENS.CollegeID; //学院ID
objvVideoLib_BaseENT.CollegeName = objvVideoLib_BaseENS.CollegeName; //学院名称
objvVideoLib_BaseENT.CollegeNameA = objvVideoLib_BaseENS.CollegeNameA; //学院名称简写
objvVideoLib_BaseENT.ViewCount = objvVideoLib_BaseENS.ViewCount; //浏览量
objvVideoLib_BaseENT.DownloadNumber = objvVideoLib_BaseENS.DownloadNumber; //下载数目
objvVideoLib_BaseENT.FileIntegration = objvVideoLib_BaseENS.FileIntegration; //文件积分
objvVideoLib_BaseENT.LikeCount = objvVideoLib_BaseENS.LikeCount; //资源喜欢数量
objvVideoLib_BaseENT.CollectionCount = objvVideoLib_BaseENS.CollectionCount; //收藏数量
objvVideoLib_BaseENT.RecommendedDegreeId = objvVideoLib_BaseENS.RecommendedDegreeId; //推荐度Id
objvVideoLib_BaseENT.RecommendedDegreeName = objvVideoLib_BaseENS.RecommendedDegreeName; //推荐度名称
objvVideoLib_BaseENT.CourseId = objvVideoLib_BaseENS.CourseId; //课程Id
objvVideoLib_BaseENT.CourseCode = objvVideoLib_BaseENS.CourseCode; //课程代码
objvVideoLib_BaseENT.CourseName = objvVideoLib_BaseENS.CourseName; //课程名称
objvVideoLib_BaseENT.VideoUrl = objvVideoLib_BaseENS.VideoUrl; //视频Url
objvVideoLib_BaseENT.VideoPath = objvVideoLib_BaseENS.VideoPath; //视频目录
objvVideoLib_BaseENT.CoverPicUrl = objvVideoLib_BaseENS.CoverPicUrl; //封面Url
objvVideoLib_BaseENT.CoverPicShortUrl = objvVideoLib_BaseENS.CoverPicShortUrl; //封面短Url
objvVideoLib_BaseENT.ResErrMsg = objvVideoLib_BaseENS.ResErrMsg; //资源错误信息
objvVideoLib_BaseENT.Memo = objvVideoLib_BaseENS.Memo; //备注
objvVideoLib_BaseENT.BrowseCount4Case = objvVideoLib_BaseENS.BrowseCount4Case; //课例浏览次数
objvVideoLib_BaseENT.OwnerName = objvVideoLib_BaseENS.OwnerName; //拥有者姓名
objvVideoLib_BaseENT.OwnerNameWithId = objvVideoLib_BaseENS.OwnerNameWithId; //拥有者名称附Id
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvVideoLib_BaseEN objvVideoLib_BaseEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvVideoLib_BaseEN.IdVideoLib, 8, convVideoLib_Base.IdVideoLib);
clsCheckSql.CheckFieldLen(objvVideoLib_BaseEN.VideoLibID, 8, convVideoLib_Base.VideoLibID);
clsCheckSql.CheckFieldLen(objvVideoLib_BaseEN.VideoLibName, 100, convVideoLib_Base.VideoLibName);
clsCheckSql.CheckFieldLen(objvVideoLib_BaseEN.VideoLibTheme, 200, convVideoLib_Base.VideoLibTheme);
clsCheckSql.CheckFieldLen(objvVideoLib_BaseEN.IdVideoLibType, 4, convVideoLib_Base.IdVideoLibType);
clsCheckSql.CheckFieldLen(objvVideoLib_BaseEN.VideoLibTypeName, 30, convVideoLib_Base.VideoLibTypeName);
clsCheckSql.CheckFieldLen(objvVideoLib_BaseEN.VideoLibText, 8000, convVideoLib_Base.VideoLibText);
clsCheckSql.CheckFieldLen(objvVideoLib_BaseEN.VideoLibDate, 20, convVideoLib_Base.VideoLibDate);
clsCheckSql.CheckFieldLen(objvVideoLib_BaseEN.VideoLibTime, 6, convVideoLib_Base.VideoLibTime);
clsCheckSql.CheckFieldLen(objvVideoLib_BaseEN.VideoLibDateIn, 8, convVideoLib_Base.VideoLibDateIn);
clsCheckSql.CheckFieldLen(objvVideoLib_BaseEN.VideoLibTimeIn, 6, convVideoLib_Base.VideoLibTimeIn);
clsCheckSql.CheckFieldLen(objvVideoLib_BaseEN.OwnerId, 20, convVideoLib_Base.OwnerId);
clsCheckSql.CheckFieldLen(objvVideoLib_BaseEN.IdTeachingPlan, 8, convVideoLib_Base.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objvVideoLib_BaseEN.IdSenateGaugeVersion, 4, convVideoLib_Base.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objvVideoLib_BaseEN.senateGaugeVersionID, 4, convVideoLib_Base.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(objvVideoLib_BaseEN.senateGaugeVersionName, 200, convVideoLib_Base.senateGaugeVersionName);
clsCheckSql.CheckFieldLen(objvVideoLib_BaseEN.CaseLevelId, 2, convVideoLib_Base.CaseLevelId);
clsCheckSql.CheckFieldLen(objvVideoLib_BaseEN.CaseLevelName, 30, convVideoLib_Base.CaseLevelName);
clsCheckSql.CheckFieldLen(objvVideoLib_BaseEN.IdXzCollege, 4, convVideoLib_Base.IdXzCollege);
clsCheckSql.CheckFieldLen(objvVideoLib_BaseEN.CollegeID, 4, convVideoLib_Base.CollegeID);
clsCheckSql.CheckFieldLen(objvVideoLib_BaseEN.CollegeName, 100, convVideoLib_Base.CollegeName);
clsCheckSql.CheckFieldLen(objvVideoLib_BaseEN.CollegeNameA, 12, convVideoLib_Base.CollegeNameA);
clsCheckSql.CheckFieldLen(objvVideoLib_BaseEN.RecommendedDegreeId, 2, convVideoLib_Base.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objvVideoLib_BaseEN.RecommendedDegreeName, 30, convVideoLib_Base.RecommendedDegreeName);
clsCheckSql.CheckFieldLen(objvVideoLib_BaseEN.CourseId, 8, convVideoLib_Base.CourseId);
clsCheckSql.CheckFieldLen(objvVideoLib_BaseEN.CourseCode, 20, convVideoLib_Base.CourseCode);
clsCheckSql.CheckFieldLen(objvVideoLib_BaseEN.CourseName, 100, convVideoLib_Base.CourseName);
clsCheckSql.CheckFieldLen(objvVideoLib_BaseEN.VideoUrl, 1000, convVideoLib_Base.VideoUrl);
clsCheckSql.CheckFieldLen(objvVideoLib_BaseEN.VideoPath, 1000, convVideoLib_Base.VideoPath);
clsCheckSql.CheckFieldLen(objvVideoLib_BaseEN.CoverPicUrl, 1000, convVideoLib_Base.CoverPicUrl);
clsCheckSql.CheckFieldLen(objvVideoLib_BaseEN.CoverPicShortUrl, 1000, convVideoLib_Base.CoverPicShortUrl);
clsCheckSql.CheckFieldLen(objvVideoLib_BaseEN.ResErrMsg, 30, convVideoLib_Base.ResErrMsg);
clsCheckSql.CheckFieldLen(objvVideoLib_BaseEN.Memo, 1000, convVideoLib_Base.Memo);
clsCheckSql.CheckFieldLen(objvVideoLib_BaseEN.OwnerName, 30, convVideoLib_Base.OwnerName);
clsCheckSql.CheckFieldLen(objvVideoLib_BaseEN.OwnerNameWithId, 51, convVideoLib_Base.OwnerNameWithId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_BaseEN.IdVideoLib, convVideoLib_Base.IdVideoLib);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_BaseEN.VideoLibID, convVideoLib_Base.VideoLibID);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_BaseEN.VideoLibName, convVideoLib_Base.VideoLibName);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_BaseEN.VideoLibTheme, convVideoLib_Base.VideoLibTheme);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_BaseEN.IdVideoLibType, convVideoLib_Base.IdVideoLibType);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_BaseEN.VideoLibTypeName, convVideoLib_Base.VideoLibTypeName);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_BaseEN.VideoLibText, convVideoLib_Base.VideoLibText);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_BaseEN.VideoLibDate, convVideoLib_Base.VideoLibDate);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_BaseEN.VideoLibTime, convVideoLib_Base.VideoLibTime);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_BaseEN.VideoLibDateIn, convVideoLib_Base.VideoLibDateIn);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_BaseEN.VideoLibTimeIn, convVideoLib_Base.VideoLibTimeIn);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_BaseEN.OwnerId, convVideoLib_Base.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_BaseEN.IdTeachingPlan, convVideoLib_Base.IdTeachingPlan);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_BaseEN.IdSenateGaugeVersion, convVideoLib_Base.IdSenateGaugeVersion);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_BaseEN.senateGaugeVersionID, convVideoLib_Base.senateGaugeVersionID);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_BaseEN.senateGaugeVersionName, convVideoLib_Base.senateGaugeVersionName);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_BaseEN.CaseLevelId, convVideoLib_Base.CaseLevelId);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_BaseEN.CaseLevelName, convVideoLib_Base.CaseLevelName);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_BaseEN.IdXzCollege, convVideoLib_Base.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_BaseEN.CollegeID, convVideoLib_Base.CollegeID);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_BaseEN.CollegeName, convVideoLib_Base.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_BaseEN.CollegeNameA, convVideoLib_Base.CollegeNameA);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_BaseEN.RecommendedDegreeId, convVideoLib_Base.RecommendedDegreeId);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_BaseEN.RecommendedDegreeName, convVideoLib_Base.RecommendedDegreeName);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_BaseEN.CourseId, convVideoLib_Base.CourseId);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_BaseEN.CourseCode, convVideoLib_Base.CourseCode);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_BaseEN.CourseName, convVideoLib_Base.CourseName);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_BaseEN.VideoUrl, convVideoLib_Base.VideoUrl);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_BaseEN.VideoPath, convVideoLib_Base.VideoPath);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_BaseEN.CoverPicUrl, convVideoLib_Base.CoverPicUrl);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_BaseEN.CoverPicShortUrl, convVideoLib_Base.CoverPicShortUrl);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_BaseEN.ResErrMsg, convVideoLib_Base.ResErrMsg);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_BaseEN.Memo, convVideoLib_Base.Memo);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_BaseEN.OwnerName, convVideoLib_Base.OwnerName);
clsCheckSql.CheckSqlInjection4Field(objvVideoLib_BaseEN.OwnerNameWithId, convVideoLib_Base.OwnerNameWithId);
//检查外键字段长度
 objvVideoLib_BaseEN._IsCheckProperty = true;
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
 objSQL = clsvVideoLib_BaseDA.GetSpecSQLObj();
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
 objSQL = clsvVideoLib_BaseDA.GetSpecSQLObj();
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
 objSQL = clsvVideoLib_BaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvVideoLib_BaseEN._CurrTabName);
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
 objSQL = clsvVideoLib_BaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvVideoLib_BaseEN._CurrTabName, strCondition);
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
 objSQL = clsvVideoLib_BaseDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}