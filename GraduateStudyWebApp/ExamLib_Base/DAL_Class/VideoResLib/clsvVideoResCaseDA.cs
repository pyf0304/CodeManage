
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvVideoResCaseDA
 表名:vVideoResCase(01120372)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:50:56
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
 /// v视频资源案例(vVideoResCase)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvVideoResCaseDA : clsCommBase4DA
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
 return clsvVideoResCaseEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvVideoResCaseEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvVideoResCaseEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvVideoResCaseEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvVideoResCaseEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:vVideoResCase中,检查关键字,长度不正确!(clsvVideoResCaseDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdVideoResCase)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vVideoResCase中,关键字不能为空 或 null!(clsvVideoResCaseDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdVideoResCase);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvVideoResCaseDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvVideoResCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCaseDA.GetSpecSQLObj();
strSQL = "Select * from vVideoResCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vVideoResCase(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvVideoResCaseDA: GetDataTable_vVideoResCase)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCaseDA.GetSpecSQLObj();
strSQL = "Select * from vVideoResCase where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvVideoResCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvVideoResCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCaseDA.GetSpecSQLObj();
strSQL = "Select * from vVideoResCase where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvVideoResCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvVideoResCaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCaseDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vVideoResCase where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vVideoResCase where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvVideoResCaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCaseDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vVideoResCase where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvVideoResCaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vVideoResCase.* from vVideoResCase Left Join {1} on {2} where {3} and vVideoResCase.IdVideoResCase not in (Select top {5} vVideoResCase.IdVideoResCase from vVideoResCase Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vVideoResCase where {1} and IdVideoResCase not in (Select top {2} IdVideoResCase from vVideoResCase where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vVideoResCase where {1} and IdVideoResCase not in (Select top {3} IdVideoResCase from vVideoResCase where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvVideoResCaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vVideoResCase.* from vVideoResCase Left Join {1} on {2} where {3} and vVideoResCase.IdVideoResCase not in (Select top {5} vVideoResCase.IdVideoResCase from vVideoResCase Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vVideoResCase where {1} and IdVideoResCase not in (Select top {2} IdVideoResCase from vVideoResCase where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vVideoResCase where {1} and IdVideoResCase not in (Select top {3} IdVideoResCase from vVideoResCase where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvVideoResCaseEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvVideoResCaseDA:GetObjLst)", objException.Message));
}
List<clsvVideoResCaseEN> arrObjLst = new List<clsvVideoResCaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCaseDA.GetSpecSQLObj();
strSQL = "Select * from vVideoResCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoResCaseEN objvVideoResCaseEN = new clsvVideoResCaseEN();
try
{
objvVideoResCaseEN.IdVideoResCase = objRow[convVideoResCase.IdVideoResCase].ToString().Trim(); //视频资源案例流水号
objvVideoResCaseEN.VideoResCaseID = objRow[convVideoResCase.VideoResCaseID].ToString().Trim(); //视频资源案例ID
objvVideoResCaseEN.VideoResCaseName = objRow[convVideoResCase.VideoResCaseName].ToString().Trim(); //视频资源案例名称
objvVideoResCaseEN.VideoResCaseTheme = objRow[convVideoResCase.VideoResCaseTheme] == DBNull.Value ? null : objRow[convVideoResCase.VideoResCaseTheme].ToString().Trim(); //视频资源案例主题词
objvVideoResCaseEN.IdVideoResCaseType = objRow[convVideoResCase.IdVideoResCaseType].ToString().Trim(); //视频资源类型流水号
objvVideoResCaseEN.VideoResCaseTypeName = objRow[convVideoResCase.VideoResCaseTypeName] == DBNull.Value ? null : objRow[convVideoResCase.VideoResCaseTypeName].ToString().Trim(); //视频资源案例类型名称
objvVideoResCaseEN.VideoResCaseText = objRow[convVideoResCase.VideoResCaseText] == DBNull.Value ? null : objRow[convVideoResCase.VideoResCaseText].ToString().Trim(); //案例文本内容
objvVideoResCaseEN.VideoResCaseDate = objRow[convVideoResCase.VideoResCaseDate] == DBNull.Value ? null : objRow[convVideoResCase.VideoResCaseDate].ToString().Trim(); //视频资源日期
objvVideoResCaseEN.VideoResCaseTime = objRow[convVideoResCase.VideoResCaseTime] == DBNull.Value ? null : objRow[convVideoResCase.VideoResCaseTime].ToString().Trim(); //视频资源时间
objvVideoResCaseEN.VideoResCaseDateIn = objRow[convVideoResCase.VideoResCaseDateIn] == DBNull.Value ? null : objRow[convVideoResCase.VideoResCaseDateIn].ToString().Trim(); //案例入库日期
objvVideoResCaseEN.VideoResCaseTimeIn = objRow[convVideoResCase.VideoResCaseTimeIn] == DBNull.Value ? null : objRow[convVideoResCase.VideoResCaseTimeIn].ToString().Trim(); //案例入库时间
objvVideoResCaseEN.OwnerId = objRow[convVideoResCase.OwnerId].ToString().Trim(); //拥有者Id
objvVideoResCaseEN.IdStudyLevel = objRow[convVideoResCase.IdStudyLevel] == DBNull.Value ? null : objRow[convVideoResCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvVideoResCaseEN.StudyLevelName = objRow[convVideoResCase.StudyLevelName] == DBNull.Value ? null : objRow[convVideoResCase.StudyLevelName].ToString().Trim(); //学段名称
objvVideoResCaseEN.IdTeachingPlan = objRow[convVideoResCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convVideoResCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvVideoResCaseEN.IdDiscipline = objRow[convVideoResCase.IdDiscipline].ToString().Trim(); //学科流水号
objvVideoResCaseEN.DisciplineID = objRow[convVideoResCase.DisciplineID] == DBNull.Value ? null : objRow[convVideoResCase.DisciplineID].ToString().Trim(); //学科ID
objvVideoResCaseEN.DisciplineName = objRow[convVideoResCase.DisciplineName] == DBNull.Value ? null : objRow[convVideoResCase.DisciplineName].ToString().Trim(); //学科名称
objvVideoResCaseEN.IdSenateGaugeVersion = objRow[convVideoResCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convVideoResCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvVideoResCaseEN.senateGaugeVersionID = objRow[convVideoResCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoResCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoResCaseEN.senateGaugeVersionName = objRow[convVideoResCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoResCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoResCaseEN.senateGaugeVersionTtlScore = objRow[convVideoResCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convVideoResCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoResCaseEN.VersionNo = objRow[convVideoResCase.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase.VersionNo].ToString().Trim()); //版本号
objvVideoResCaseEN.IdTeachSkill = objRow[convVideoResCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvVideoResCaseEN.TeachSkillID = objRow[convVideoResCase.TeachSkillID] == DBNull.Value ? null : objRow[convVideoResCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvVideoResCaseEN.SkillTypeName = objRow[convVideoResCase.SkillTypeName] == DBNull.Value ? null : objRow[convVideoResCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvVideoResCaseEN.TeachSkillName = objRow[convVideoResCase.TeachSkillName] == DBNull.Value ? null : objRow[convVideoResCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvVideoResCaseEN.TeachSkillTheory = objRow[convVideoResCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convVideoResCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvVideoResCaseEN.TeachSkillOperMethod = objRow[convVideoResCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convVideoResCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvVideoResCaseEN.IdSkillType = objRow[convVideoResCase.IdSkillType] == DBNull.Value ? null : objRow[convVideoResCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvVideoResCaseEN.SkillTypeID = objRow[convVideoResCase.SkillTypeID] == DBNull.Value ? null : objRow[convVideoResCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvVideoResCaseEN.CaseLevelId = objRow[convVideoResCase.CaseLevelId] == DBNull.Value ? null : objRow[convVideoResCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvVideoResCaseEN.CaseLevelName = objRow[convVideoResCase.CaseLevelName] == DBNull.Value ? null : objRow[convVideoResCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvVideoResCaseEN.DocFile = objRow[convVideoResCase.DocFile] == DBNull.Value ? null : objRow[convVideoResCase.DocFile].ToString().Trim(); //生成的Word文件名
objvVideoResCaseEN.IsNeedGeneWord = TransNullToBool(objRow[convVideoResCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvVideoResCaseEN.WordCreateDate = objRow[convVideoResCase.WordCreateDate] == DBNull.Value ? null : objRow[convVideoResCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvVideoResCaseEN.IsVisible = TransNullToBool(objRow[convVideoResCase.IsVisible].ToString().Trim()); //是否显示
objvVideoResCaseEN.IsDualVideo = TransNullToBool(objRow[convVideoResCase.IsDualVideo].ToString().Trim()); //是否双视频
objvVideoResCaseEN.IdXzCollege = objRow[convVideoResCase.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoResCaseEN.CollegeID = objRow[convVideoResCase.CollegeID] == DBNull.Value ? null : objRow[convVideoResCase.CollegeID].ToString().Trim(); //学院ID
objvVideoResCaseEN.CollegeName = objRow[convVideoResCase.CollegeName] == DBNull.Value ? null : objRow[convVideoResCase.CollegeName].ToString().Trim(); //学院名称
objvVideoResCaseEN.CollegeNameA = objRow[convVideoResCase.CollegeNameA] == DBNull.Value ? null : objRow[convVideoResCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoResCaseEN.IdXzMajor = objRow[convVideoResCase.IdXzMajor].ToString().Trim(); //专业流水号
objvVideoResCaseEN.MajorID = objRow[convVideoResCase.MajorID] == DBNull.Value ? null : objRow[convVideoResCase.MajorID].ToString().Trim(); //专业ID
objvVideoResCaseEN.MajorName = objRow[convVideoResCase.MajorName] == DBNull.Value ? null : objRow[convVideoResCase.MajorName].ToString().Trim(); //专业名称
objvVideoResCaseEN.CourseChapterId = objRow[convVideoResCase.CourseChapterId] == DBNull.Value ? null : objRow[convVideoResCase.CourseChapterId].ToString().Trim(); //课程章节ID
objvVideoResCaseEN.CourseChapterName = objRow[convVideoResCase.CourseChapterName] == DBNull.Value ? null : objRow[convVideoResCase.CourseChapterName].ToString().Trim(); //课程章节名称
objvVideoResCaseEN.ParentNodeID = objRow[convVideoResCase.ParentNodeID] == DBNull.Value ? null : objRow[convVideoResCase.ParentNodeID].ToString().Trim(); //父节点编号
objvVideoResCaseEN.ParentNodeName = objRow[convVideoResCase.ParentNodeName] == DBNull.Value ? null : objRow[convVideoResCase.ParentNodeName].ToString().Trim(); //父节点名称
objvVideoResCaseEN.ViewCount = objRow[convVideoResCase.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase.ViewCount].ToString().Trim()); //浏览量
objvVideoResCaseEN.IsShow = TransNullToBool(objRow[convVideoResCase.IsShow].ToString().Trim()); //是否启用
objvVideoResCaseEN.DownloadNumber = objRow[convVideoResCase.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase.DownloadNumber].ToString().Trim()); //下载数目
objvVideoResCaseEN.FileIntegration = objRow[convVideoResCase.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase.FileIntegration].ToString().Trim()); //文件积分
objvVideoResCaseEN.LikeCount = objRow[convVideoResCase.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoResCase.LikeCount].ToString().Trim()); //资源喜欢数量
objvVideoResCaseEN.CollectionCount = objRow[convVideoResCase.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoResCase.CollectionCount].ToString().Trim()); //收藏数量
objvVideoResCaseEN.RecommendedDegreeId = objRow[convVideoResCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvVideoResCaseEN.RecommendedDegreeName = objRow[convVideoResCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convVideoResCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvVideoResCaseEN.ftpFileType = objRow[convVideoResCase.ftpFileType] == DBNull.Value ? null : objRow[convVideoResCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvVideoResCaseEN.CourseId = objRow[convVideoResCase.CourseId] == DBNull.Value ? null : objRow[convVideoResCase.CourseId].ToString().Trim(); //课程Id
objvVideoResCaseEN.CourseCode = objRow[convVideoResCase.CourseCode] == DBNull.Value ? null : objRow[convVideoResCase.CourseCode].ToString().Trim(); //课程代码
objvVideoResCaseEN.CourseName = objRow[convVideoResCase.CourseName] == DBNull.Value ? null : objRow[convVideoResCase.CourseName].ToString().Trim(); //课程名称
objvVideoResCaseEN.VideoUrl = objRow[convVideoResCase.VideoUrl] == DBNull.Value ? null : objRow[convVideoResCase.VideoUrl].ToString().Trim(); //视频Url
objvVideoResCaseEN.VideoPath = objRow[convVideoResCase.VideoPath] == DBNull.Value ? null : objRow[convVideoResCase.VideoPath].ToString().Trim(); //视频目录
objvVideoResCaseEN.ResErrMsg = objRow[convVideoResCase.ResErrMsg] == DBNull.Value ? null : objRow[convVideoResCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvVideoResCaseEN.UpdDate = objRow[convVideoResCase.UpdDate] == DBNull.Value ? null : objRow[convVideoResCase.UpdDate].ToString().Trim(); //修改日期
objvVideoResCaseEN.UpdUserId = objRow[convVideoResCase.UpdUserId] == DBNull.Value ? null : objRow[convVideoResCase.UpdUserId].ToString().Trim(); //修改用户Id
objvVideoResCaseEN.Memo = objRow[convVideoResCase.Memo] == DBNull.Value ? null : objRow[convVideoResCase.Memo].ToString().Trim(); //备注
objvVideoResCaseEN.OwnerNameWithId = objRow[convVideoResCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoResCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvVideoResCaseEN.OwnerName = objRow[convVideoResCase.OwnerName] == DBNull.Value ? null : objRow[convVideoResCase.OwnerName].ToString().Trim(); //拥有者姓名
objvVideoResCaseEN.BrowseCount4Case = objRow[convVideoResCase.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvVideoResCaseEN.IsHaveVideo = objRow[convVideoResCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvVideoResCaseDA: GetObjLst)", objException.Message));
}
objvVideoResCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvVideoResCaseEN);
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
public List<clsvVideoResCaseEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvVideoResCaseDA:GetObjLstByTabName)", objException.Message));
}
List<clsvVideoResCaseEN> arrObjLst = new List<clsvVideoResCaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCaseDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoResCaseEN objvVideoResCaseEN = new clsvVideoResCaseEN();
try
{
objvVideoResCaseEN.IdVideoResCase = objRow[convVideoResCase.IdVideoResCase].ToString().Trim(); //视频资源案例流水号
objvVideoResCaseEN.VideoResCaseID = objRow[convVideoResCase.VideoResCaseID].ToString().Trim(); //视频资源案例ID
objvVideoResCaseEN.VideoResCaseName = objRow[convVideoResCase.VideoResCaseName].ToString().Trim(); //视频资源案例名称
objvVideoResCaseEN.VideoResCaseTheme = objRow[convVideoResCase.VideoResCaseTheme] == DBNull.Value ? null : objRow[convVideoResCase.VideoResCaseTheme].ToString().Trim(); //视频资源案例主题词
objvVideoResCaseEN.IdVideoResCaseType = objRow[convVideoResCase.IdVideoResCaseType].ToString().Trim(); //视频资源类型流水号
objvVideoResCaseEN.VideoResCaseTypeName = objRow[convVideoResCase.VideoResCaseTypeName] == DBNull.Value ? null : objRow[convVideoResCase.VideoResCaseTypeName].ToString().Trim(); //视频资源案例类型名称
objvVideoResCaseEN.VideoResCaseText = objRow[convVideoResCase.VideoResCaseText] == DBNull.Value ? null : objRow[convVideoResCase.VideoResCaseText].ToString().Trim(); //案例文本内容
objvVideoResCaseEN.VideoResCaseDate = objRow[convVideoResCase.VideoResCaseDate] == DBNull.Value ? null : objRow[convVideoResCase.VideoResCaseDate].ToString().Trim(); //视频资源日期
objvVideoResCaseEN.VideoResCaseTime = objRow[convVideoResCase.VideoResCaseTime] == DBNull.Value ? null : objRow[convVideoResCase.VideoResCaseTime].ToString().Trim(); //视频资源时间
objvVideoResCaseEN.VideoResCaseDateIn = objRow[convVideoResCase.VideoResCaseDateIn] == DBNull.Value ? null : objRow[convVideoResCase.VideoResCaseDateIn].ToString().Trim(); //案例入库日期
objvVideoResCaseEN.VideoResCaseTimeIn = objRow[convVideoResCase.VideoResCaseTimeIn] == DBNull.Value ? null : objRow[convVideoResCase.VideoResCaseTimeIn].ToString().Trim(); //案例入库时间
objvVideoResCaseEN.OwnerId = objRow[convVideoResCase.OwnerId].ToString().Trim(); //拥有者Id
objvVideoResCaseEN.IdStudyLevel = objRow[convVideoResCase.IdStudyLevel] == DBNull.Value ? null : objRow[convVideoResCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvVideoResCaseEN.StudyLevelName = objRow[convVideoResCase.StudyLevelName] == DBNull.Value ? null : objRow[convVideoResCase.StudyLevelName].ToString().Trim(); //学段名称
objvVideoResCaseEN.IdTeachingPlan = objRow[convVideoResCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convVideoResCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvVideoResCaseEN.IdDiscipline = objRow[convVideoResCase.IdDiscipline].ToString().Trim(); //学科流水号
objvVideoResCaseEN.DisciplineID = objRow[convVideoResCase.DisciplineID] == DBNull.Value ? null : objRow[convVideoResCase.DisciplineID].ToString().Trim(); //学科ID
objvVideoResCaseEN.DisciplineName = objRow[convVideoResCase.DisciplineName] == DBNull.Value ? null : objRow[convVideoResCase.DisciplineName].ToString().Trim(); //学科名称
objvVideoResCaseEN.IdSenateGaugeVersion = objRow[convVideoResCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convVideoResCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvVideoResCaseEN.senateGaugeVersionID = objRow[convVideoResCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoResCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoResCaseEN.senateGaugeVersionName = objRow[convVideoResCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoResCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoResCaseEN.senateGaugeVersionTtlScore = objRow[convVideoResCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convVideoResCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoResCaseEN.VersionNo = objRow[convVideoResCase.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase.VersionNo].ToString().Trim()); //版本号
objvVideoResCaseEN.IdTeachSkill = objRow[convVideoResCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvVideoResCaseEN.TeachSkillID = objRow[convVideoResCase.TeachSkillID] == DBNull.Value ? null : objRow[convVideoResCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvVideoResCaseEN.SkillTypeName = objRow[convVideoResCase.SkillTypeName] == DBNull.Value ? null : objRow[convVideoResCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvVideoResCaseEN.TeachSkillName = objRow[convVideoResCase.TeachSkillName] == DBNull.Value ? null : objRow[convVideoResCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvVideoResCaseEN.TeachSkillTheory = objRow[convVideoResCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convVideoResCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvVideoResCaseEN.TeachSkillOperMethod = objRow[convVideoResCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convVideoResCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvVideoResCaseEN.IdSkillType = objRow[convVideoResCase.IdSkillType] == DBNull.Value ? null : objRow[convVideoResCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvVideoResCaseEN.SkillTypeID = objRow[convVideoResCase.SkillTypeID] == DBNull.Value ? null : objRow[convVideoResCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvVideoResCaseEN.CaseLevelId = objRow[convVideoResCase.CaseLevelId] == DBNull.Value ? null : objRow[convVideoResCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvVideoResCaseEN.CaseLevelName = objRow[convVideoResCase.CaseLevelName] == DBNull.Value ? null : objRow[convVideoResCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvVideoResCaseEN.DocFile = objRow[convVideoResCase.DocFile] == DBNull.Value ? null : objRow[convVideoResCase.DocFile].ToString().Trim(); //生成的Word文件名
objvVideoResCaseEN.IsNeedGeneWord = TransNullToBool(objRow[convVideoResCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvVideoResCaseEN.WordCreateDate = objRow[convVideoResCase.WordCreateDate] == DBNull.Value ? null : objRow[convVideoResCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvVideoResCaseEN.IsVisible = TransNullToBool(objRow[convVideoResCase.IsVisible].ToString().Trim()); //是否显示
objvVideoResCaseEN.IsDualVideo = TransNullToBool(objRow[convVideoResCase.IsDualVideo].ToString().Trim()); //是否双视频
objvVideoResCaseEN.IdXzCollege = objRow[convVideoResCase.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoResCaseEN.CollegeID = objRow[convVideoResCase.CollegeID] == DBNull.Value ? null : objRow[convVideoResCase.CollegeID].ToString().Trim(); //学院ID
objvVideoResCaseEN.CollegeName = objRow[convVideoResCase.CollegeName] == DBNull.Value ? null : objRow[convVideoResCase.CollegeName].ToString().Trim(); //学院名称
objvVideoResCaseEN.CollegeNameA = objRow[convVideoResCase.CollegeNameA] == DBNull.Value ? null : objRow[convVideoResCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoResCaseEN.IdXzMajor = objRow[convVideoResCase.IdXzMajor].ToString().Trim(); //专业流水号
objvVideoResCaseEN.MajorID = objRow[convVideoResCase.MajorID] == DBNull.Value ? null : objRow[convVideoResCase.MajorID].ToString().Trim(); //专业ID
objvVideoResCaseEN.MajorName = objRow[convVideoResCase.MajorName] == DBNull.Value ? null : objRow[convVideoResCase.MajorName].ToString().Trim(); //专业名称
objvVideoResCaseEN.CourseChapterId = objRow[convVideoResCase.CourseChapterId] == DBNull.Value ? null : objRow[convVideoResCase.CourseChapterId].ToString().Trim(); //课程章节ID
objvVideoResCaseEN.CourseChapterName = objRow[convVideoResCase.CourseChapterName] == DBNull.Value ? null : objRow[convVideoResCase.CourseChapterName].ToString().Trim(); //课程章节名称
objvVideoResCaseEN.ParentNodeID = objRow[convVideoResCase.ParentNodeID] == DBNull.Value ? null : objRow[convVideoResCase.ParentNodeID].ToString().Trim(); //父节点编号
objvVideoResCaseEN.ParentNodeName = objRow[convVideoResCase.ParentNodeName] == DBNull.Value ? null : objRow[convVideoResCase.ParentNodeName].ToString().Trim(); //父节点名称
objvVideoResCaseEN.ViewCount = objRow[convVideoResCase.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase.ViewCount].ToString().Trim()); //浏览量
objvVideoResCaseEN.IsShow = TransNullToBool(objRow[convVideoResCase.IsShow].ToString().Trim()); //是否启用
objvVideoResCaseEN.DownloadNumber = objRow[convVideoResCase.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase.DownloadNumber].ToString().Trim()); //下载数目
objvVideoResCaseEN.FileIntegration = objRow[convVideoResCase.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase.FileIntegration].ToString().Trim()); //文件积分
objvVideoResCaseEN.LikeCount = objRow[convVideoResCase.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoResCase.LikeCount].ToString().Trim()); //资源喜欢数量
objvVideoResCaseEN.CollectionCount = objRow[convVideoResCase.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoResCase.CollectionCount].ToString().Trim()); //收藏数量
objvVideoResCaseEN.RecommendedDegreeId = objRow[convVideoResCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvVideoResCaseEN.RecommendedDegreeName = objRow[convVideoResCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convVideoResCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvVideoResCaseEN.ftpFileType = objRow[convVideoResCase.ftpFileType] == DBNull.Value ? null : objRow[convVideoResCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvVideoResCaseEN.CourseId = objRow[convVideoResCase.CourseId] == DBNull.Value ? null : objRow[convVideoResCase.CourseId].ToString().Trim(); //课程Id
objvVideoResCaseEN.CourseCode = objRow[convVideoResCase.CourseCode] == DBNull.Value ? null : objRow[convVideoResCase.CourseCode].ToString().Trim(); //课程代码
objvVideoResCaseEN.CourseName = objRow[convVideoResCase.CourseName] == DBNull.Value ? null : objRow[convVideoResCase.CourseName].ToString().Trim(); //课程名称
objvVideoResCaseEN.VideoUrl = objRow[convVideoResCase.VideoUrl] == DBNull.Value ? null : objRow[convVideoResCase.VideoUrl].ToString().Trim(); //视频Url
objvVideoResCaseEN.VideoPath = objRow[convVideoResCase.VideoPath] == DBNull.Value ? null : objRow[convVideoResCase.VideoPath].ToString().Trim(); //视频目录
objvVideoResCaseEN.ResErrMsg = objRow[convVideoResCase.ResErrMsg] == DBNull.Value ? null : objRow[convVideoResCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvVideoResCaseEN.UpdDate = objRow[convVideoResCase.UpdDate] == DBNull.Value ? null : objRow[convVideoResCase.UpdDate].ToString().Trim(); //修改日期
objvVideoResCaseEN.UpdUserId = objRow[convVideoResCase.UpdUserId] == DBNull.Value ? null : objRow[convVideoResCase.UpdUserId].ToString().Trim(); //修改用户Id
objvVideoResCaseEN.Memo = objRow[convVideoResCase.Memo] == DBNull.Value ? null : objRow[convVideoResCase.Memo].ToString().Trim(); //备注
objvVideoResCaseEN.OwnerNameWithId = objRow[convVideoResCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoResCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvVideoResCaseEN.OwnerName = objRow[convVideoResCase.OwnerName] == DBNull.Value ? null : objRow[convVideoResCase.OwnerName].ToString().Trim(); //拥有者姓名
objvVideoResCaseEN.BrowseCount4Case = objRow[convVideoResCase.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvVideoResCaseEN.IsHaveVideo = objRow[convVideoResCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvVideoResCaseDA: GetObjLst)", objException.Message));
}
objvVideoResCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvVideoResCaseEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvVideoResCaseEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvVideoResCase(ref clsvVideoResCaseEN objvVideoResCaseEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCaseDA.GetSpecSQLObj();
strSQL = "Select * from vVideoResCase where IdVideoResCase = " + "'"+ objvVideoResCaseEN.IdVideoResCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvVideoResCaseEN.IdVideoResCase = objDT.Rows[0][convVideoResCase.IdVideoResCase].ToString().Trim(); //视频资源案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoResCaseEN.VideoResCaseID = objDT.Rows[0][convVideoResCase.VideoResCaseID].ToString().Trim(); //视频资源案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvVideoResCaseEN.VideoResCaseName = objDT.Rows[0][convVideoResCase.VideoResCaseName].ToString().Trim(); //视频资源案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvVideoResCaseEN.VideoResCaseTheme = objDT.Rows[0][convVideoResCase.VideoResCaseTheme].ToString().Trim(); //视频资源案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoResCaseEN.IdVideoResCaseType = objDT.Rows[0][convVideoResCase.IdVideoResCaseType].ToString().Trim(); //视频资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCaseEN.VideoResCaseTypeName = objDT.Rows[0][convVideoResCase.VideoResCaseTypeName].ToString().Trim(); //视频资源案例类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvVideoResCaseEN.VideoResCaseText = objDT.Rows[0][convVideoResCase.VideoResCaseText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objvVideoResCaseEN.VideoResCaseDate = objDT.Rows[0][convVideoResCase.VideoResCaseDate].ToString().Trim(); //视频资源日期(字段类型:char,字段长度:8,是否可空:True)
 objvVideoResCaseEN.VideoResCaseTime = objDT.Rows[0][convVideoResCase.VideoResCaseTime].ToString().Trim(); //视频资源时间(字段类型:char,字段长度:6,是否可空:True)
 objvVideoResCaseEN.VideoResCaseDateIn = objDT.Rows[0][convVideoResCase.VideoResCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvVideoResCaseEN.VideoResCaseTimeIn = objDT.Rows[0][convVideoResCase.VideoResCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvVideoResCaseEN.OwnerId = objDT.Rows[0][convVideoResCase.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvVideoResCaseEN.IdStudyLevel = objDT.Rows[0][convVideoResCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvVideoResCaseEN.StudyLevelName = objDT.Rows[0][convVideoResCase.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvVideoResCaseEN.IdTeachingPlan = objDT.Rows[0][convVideoResCase.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoResCaseEN.IdDiscipline = objDT.Rows[0][convVideoResCase.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCaseEN.DisciplineID = objDT.Rows[0][convVideoResCase.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCaseEN.DisciplineName = objDT.Rows[0][convVideoResCase.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvVideoResCaseEN.IdSenateGaugeVersion = objDT.Rows[0][convVideoResCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCaseEN.senateGaugeVersionID = objDT.Rows[0][convVideoResCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCaseEN.senateGaugeVersionName = objDT.Rows[0][convVideoResCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoResCaseEN.senateGaugeVersionTtlScore = TransNullToFloat(objDT.Rows[0][convVideoResCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvVideoResCaseEN.VersionNo = TransNullToInt(objDT.Rows[0][convVideoResCase.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvVideoResCaseEN.IdTeachSkill = objDT.Rows[0][convVideoResCase.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoResCaseEN.TeachSkillID = objDT.Rows[0][convVideoResCase.TeachSkillID].ToString().Trim(); //教学技能ID(字段类型:char,字段长度:8,是否可空:False)
 objvVideoResCaseEN.SkillTypeName = objDT.Rows[0][convVideoResCase.SkillTypeName].ToString().Trim(); //技能类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvVideoResCaseEN.TeachSkillName = objDT.Rows[0][convVideoResCase.TeachSkillName].ToString().Trim(); //教学技能名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvVideoResCaseEN.TeachSkillTheory = objDT.Rows[0][convVideoResCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvVideoResCaseEN.TeachSkillOperMethod = objDT.Rows[0][convVideoResCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法(字段类型:varchar,字段长度:2000,是否可空:True)
 objvVideoResCaseEN.IdSkillType = objDT.Rows[0][convVideoResCase.IdSkillType].ToString().Trim(); //技能类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCaseEN.SkillTypeID = objDT.Rows[0][convVideoResCase.SkillTypeID].ToString().Trim(); //技能类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCaseEN.CaseLevelId = objDT.Rows[0][convVideoResCase.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvVideoResCaseEN.CaseLevelName = objDT.Rows[0][convVideoResCase.CaseLevelName].ToString().Trim(); //案例等级名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvVideoResCaseEN.DocFile = objDT.Rows[0][convVideoResCase.DocFile].ToString().Trim(); //生成的Word文件名(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoResCaseEN.IsNeedGeneWord = TransNullToBool(objDT.Rows[0][convVideoResCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word(字段类型:bit,字段长度:1,是否可空:True)
 objvVideoResCaseEN.WordCreateDate = objDT.Rows[0][convVideoResCase.WordCreateDate].ToString().Trim(); //Word生成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objvVideoResCaseEN.IsVisible = TransNullToBool(objDT.Rows[0][convVideoResCase.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvVideoResCaseEN.IsDualVideo = TransNullToBool(objDT.Rows[0][convVideoResCase.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvVideoResCaseEN.IdXzCollege = objDT.Rows[0][convVideoResCase.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvVideoResCaseEN.CollegeID = objDT.Rows[0][convVideoResCase.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvVideoResCaseEN.CollegeName = objDT.Rows[0][convVideoResCase.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvVideoResCaseEN.CollegeNameA = objDT.Rows[0][convVideoResCase.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvVideoResCaseEN.IdXzMajor = objDT.Rows[0][convVideoResCase.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoResCaseEN.MajorID = objDT.Rows[0][convVideoResCase.MajorID].ToString().Trim(); //专业ID(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCaseEN.MajorName = objDT.Rows[0][convVideoResCase.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvVideoResCaseEN.CourseChapterId = objDT.Rows[0][convVideoResCase.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objvVideoResCaseEN.CourseChapterName = objDT.Rows[0][convVideoResCase.CourseChapterName].ToString().Trim(); //课程章节名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvVideoResCaseEN.ParentNodeID = objDT.Rows[0][convVideoResCase.ParentNodeID].ToString().Trim(); //父节点编号(字段类型:varchar,字段长度:8,是否可空:True)
 objvVideoResCaseEN.ParentNodeName = objDT.Rows[0][convVideoResCase.ParentNodeName].ToString().Trim(); //父节点名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvVideoResCaseEN.ViewCount = TransNullToInt(objDT.Rows[0][convVideoResCase.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvVideoResCaseEN.IsShow = TransNullToBool(objDT.Rows[0][convVideoResCase.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objvVideoResCaseEN.DownloadNumber = TransNullToInt(objDT.Rows[0][convVideoResCase.DownloadNumber].ToString().Trim()); //下载数目(字段类型:int,字段长度:4,是否可空:True)
 objvVideoResCaseEN.FileIntegration = TransNullToInt(objDT.Rows[0][convVideoResCase.FileIntegration].ToString().Trim()); //文件积分(字段类型:int,字段长度:4,是否可空:True)
 objvVideoResCaseEN.LikeCount = TransNullToInt(objDT.Rows[0][convVideoResCase.LikeCount].ToString().Trim()); //资源喜欢数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvVideoResCaseEN.CollectionCount = TransNullToInt(objDT.Rows[0][convVideoResCase.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvVideoResCaseEN.RecommendedDegreeId = objDT.Rows[0][convVideoResCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvVideoResCaseEN.RecommendedDegreeName = objDT.Rows[0][convVideoResCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvVideoResCaseEN.ftpFileType = objDT.Rows[0][convVideoResCase.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvVideoResCaseEN.CourseId = objDT.Rows[0][convVideoResCase.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvVideoResCaseEN.CourseCode = objDT.Rows[0][convVideoResCase.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvVideoResCaseEN.CourseName = objDT.Rows[0][convVideoResCase.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvVideoResCaseEN.VideoUrl = objDT.Rows[0][convVideoResCase.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objvVideoResCaseEN.VideoPath = objDT.Rows[0][convVideoResCase.VideoPath].ToString().Trim(); //视频目录(字段类型:varchar,字段长度:1000,是否可空:True)
 objvVideoResCaseEN.ResErrMsg = objDT.Rows[0][convVideoResCase.ResErrMsg].ToString().Trim(); //资源错误信息(字段类型:varchar,字段长度:30,是否可空:True)
 objvVideoResCaseEN.UpdDate = objDT.Rows[0][convVideoResCase.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvVideoResCaseEN.UpdUserId = objDT.Rows[0][convVideoResCase.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvVideoResCaseEN.Memo = objDT.Rows[0][convVideoResCase.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvVideoResCaseEN.OwnerNameWithId = objDT.Rows[0][convVideoResCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
 objvVideoResCaseEN.OwnerName = objDT.Rows[0][convVideoResCase.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvVideoResCaseEN.BrowseCount4Case = TransNullToInt(objDT.Rows[0][convVideoResCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvVideoResCaseEN.IsHaveVideo = objDT.Rows[0][convVideoResCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo(字段类型:varchar,字段长度:6,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvVideoResCaseDA: GetvVideoResCase)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdVideoResCase">表关键字</param>
 /// <returns>表对象</returns>
public clsvVideoResCaseEN GetObjByIdVideoResCase(string strIdVideoResCase)
{
CheckPrimaryKey(strIdVideoResCase);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCaseDA.GetSpecSQLObj();
strSQL = "Select * from vVideoResCase where IdVideoResCase = " + "'"+ strIdVideoResCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvVideoResCaseEN objvVideoResCaseEN = new clsvVideoResCaseEN();
try
{
 objvVideoResCaseEN.IdVideoResCase = objRow[convVideoResCase.IdVideoResCase].ToString().Trim(); //视频资源案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoResCaseEN.VideoResCaseID = objRow[convVideoResCase.VideoResCaseID].ToString().Trim(); //视频资源案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvVideoResCaseEN.VideoResCaseName = objRow[convVideoResCase.VideoResCaseName].ToString().Trim(); //视频资源案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvVideoResCaseEN.VideoResCaseTheme = objRow[convVideoResCase.VideoResCaseTheme] == DBNull.Value ? null : objRow[convVideoResCase.VideoResCaseTheme].ToString().Trim(); //视频资源案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoResCaseEN.IdVideoResCaseType = objRow[convVideoResCase.IdVideoResCaseType].ToString().Trim(); //视频资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCaseEN.VideoResCaseTypeName = objRow[convVideoResCase.VideoResCaseTypeName] == DBNull.Value ? null : objRow[convVideoResCase.VideoResCaseTypeName].ToString().Trim(); //视频资源案例类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvVideoResCaseEN.VideoResCaseText = objRow[convVideoResCase.VideoResCaseText] == DBNull.Value ? null : objRow[convVideoResCase.VideoResCaseText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objvVideoResCaseEN.VideoResCaseDate = objRow[convVideoResCase.VideoResCaseDate] == DBNull.Value ? null : objRow[convVideoResCase.VideoResCaseDate].ToString().Trim(); //视频资源日期(字段类型:char,字段长度:8,是否可空:True)
 objvVideoResCaseEN.VideoResCaseTime = objRow[convVideoResCase.VideoResCaseTime] == DBNull.Value ? null : objRow[convVideoResCase.VideoResCaseTime].ToString().Trim(); //视频资源时间(字段类型:char,字段长度:6,是否可空:True)
 objvVideoResCaseEN.VideoResCaseDateIn = objRow[convVideoResCase.VideoResCaseDateIn] == DBNull.Value ? null : objRow[convVideoResCase.VideoResCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvVideoResCaseEN.VideoResCaseTimeIn = objRow[convVideoResCase.VideoResCaseTimeIn] == DBNull.Value ? null : objRow[convVideoResCase.VideoResCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvVideoResCaseEN.OwnerId = objRow[convVideoResCase.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvVideoResCaseEN.IdStudyLevel = objRow[convVideoResCase.IdStudyLevel] == DBNull.Value ? null : objRow[convVideoResCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvVideoResCaseEN.StudyLevelName = objRow[convVideoResCase.StudyLevelName] == DBNull.Value ? null : objRow[convVideoResCase.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvVideoResCaseEN.IdTeachingPlan = objRow[convVideoResCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convVideoResCase.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoResCaseEN.IdDiscipline = objRow[convVideoResCase.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCaseEN.DisciplineID = objRow[convVideoResCase.DisciplineID] == DBNull.Value ? null : objRow[convVideoResCase.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCaseEN.DisciplineName = objRow[convVideoResCase.DisciplineName] == DBNull.Value ? null : objRow[convVideoResCase.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvVideoResCaseEN.IdSenateGaugeVersion = objRow[convVideoResCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convVideoResCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCaseEN.senateGaugeVersionID = objRow[convVideoResCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoResCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCaseEN.senateGaugeVersionName = objRow[convVideoResCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoResCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoResCaseEN.senateGaugeVersionTtlScore = objRow[convVideoResCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convVideoResCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvVideoResCaseEN.VersionNo = objRow[convVideoResCase.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoResCase.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvVideoResCaseEN.IdTeachSkill = objRow[convVideoResCase.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoResCaseEN.TeachSkillID = objRow[convVideoResCase.TeachSkillID] == DBNull.Value ? null : objRow[convVideoResCase.TeachSkillID].ToString().Trim(); //教学技能ID(字段类型:char,字段长度:8,是否可空:False)
 objvVideoResCaseEN.SkillTypeName = objRow[convVideoResCase.SkillTypeName] == DBNull.Value ? null : objRow[convVideoResCase.SkillTypeName].ToString().Trim(); //技能类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvVideoResCaseEN.TeachSkillName = objRow[convVideoResCase.TeachSkillName] == DBNull.Value ? null : objRow[convVideoResCase.TeachSkillName].ToString().Trim(); //教学技能名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvVideoResCaseEN.TeachSkillTheory = objRow[convVideoResCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convVideoResCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvVideoResCaseEN.TeachSkillOperMethod = objRow[convVideoResCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convVideoResCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法(字段类型:varchar,字段长度:2000,是否可空:True)
 objvVideoResCaseEN.IdSkillType = objRow[convVideoResCase.IdSkillType] == DBNull.Value ? null : objRow[convVideoResCase.IdSkillType].ToString().Trim(); //技能类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCaseEN.SkillTypeID = objRow[convVideoResCase.SkillTypeID] == DBNull.Value ? null : objRow[convVideoResCase.SkillTypeID].ToString().Trim(); //技能类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCaseEN.CaseLevelId = objRow[convVideoResCase.CaseLevelId] == DBNull.Value ? null : objRow[convVideoResCase.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvVideoResCaseEN.CaseLevelName = objRow[convVideoResCase.CaseLevelName] == DBNull.Value ? null : objRow[convVideoResCase.CaseLevelName].ToString().Trim(); //案例等级名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvVideoResCaseEN.DocFile = objRow[convVideoResCase.DocFile] == DBNull.Value ? null : objRow[convVideoResCase.DocFile].ToString().Trim(); //生成的Word文件名(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoResCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convVideoResCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word(字段类型:bit,字段长度:1,是否可空:True)
 objvVideoResCaseEN.WordCreateDate = objRow[convVideoResCase.WordCreateDate] == DBNull.Value ? null : objRow[convVideoResCase.WordCreateDate].ToString().Trim(); //Word生成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objvVideoResCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convVideoResCase.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvVideoResCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convVideoResCase.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvVideoResCaseEN.IdXzCollege = objRow[convVideoResCase.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvVideoResCaseEN.CollegeID = objRow[convVideoResCase.CollegeID] == DBNull.Value ? null : objRow[convVideoResCase.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvVideoResCaseEN.CollegeName = objRow[convVideoResCase.CollegeName] == DBNull.Value ? null : objRow[convVideoResCase.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvVideoResCaseEN.CollegeNameA = objRow[convVideoResCase.CollegeNameA] == DBNull.Value ? null : objRow[convVideoResCase.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvVideoResCaseEN.IdXzMajor = objRow[convVideoResCase.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoResCaseEN.MajorID = objRow[convVideoResCase.MajorID] == DBNull.Value ? null : objRow[convVideoResCase.MajorID].ToString().Trim(); //专业ID(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCaseEN.MajorName = objRow[convVideoResCase.MajorName] == DBNull.Value ? null : objRow[convVideoResCase.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvVideoResCaseEN.CourseChapterId = objRow[convVideoResCase.CourseChapterId] == DBNull.Value ? null : objRow[convVideoResCase.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objvVideoResCaseEN.CourseChapterName = objRow[convVideoResCase.CourseChapterName] == DBNull.Value ? null : objRow[convVideoResCase.CourseChapterName].ToString().Trim(); //课程章节名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvVideoResCaseEN.ParentNodeID = objRow[convVideoResCase.ParentNodeID] == DBNull.Value ? null : objRow[convVideoResCase.ParentNodeID].ToString().Trim(); //父节点编号(字段类型:varchar,字段长度:8,是否可空:True)
 objvVideoResCaseEN.ParentNodeName = objRow[convVideoResCase.ParentNodeName] == DBNull.Value ? null : objRow[convVideoResCase.ParentNodeName].ToString().Trim(); //父节点名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvVideoResCaseEN.ViewCount = objRow[convVideoResCase.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoResCase.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvVideoResCaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convVideoResCase.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objvVideoResCaseEN.DownloadNumber = objRow[convVideoResCase.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoResCase.DownloadNumber].ToString().Trim()); //下载数目(字段类型:int,字段长度:4,是否可空:True)
 objvVideoResCaseEN.FileIntegration = objRow[convVideoResCase.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoResCase.FileIntegration].ToString().Trim()); //文件积分(字段类型:int,字段长度:4,是否可空:True)
 objvVideoResCaseEN.LikeCount = objRow[convVideoResCase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoResCase.LikeCount].ToString().Trim()); //资源喜欢数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvVideoResCaseEN.CollectionCount = objRow[convVideoResCase.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoResCase.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvVideoResCaseEN.RecommendedDegreeId = objRow[convVideoResCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvVideoResCaseEN.RecommendedDegreeName = objRow[convVideoResCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convVideoResCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvVideoResCaseEN.ftpFileType = objRow[convVideoResCase.ftpFileType] == DBNull.Value ? null : objRow[convVideoResCase.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvVideoResCaseEN.CourseId = objRow[convVideoResCase.CourseId] == DBNull.Value ? null : objRow[convVideoResCase.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvVideoResCaseEN.CourseCode = objRow[convVideoResCase.CourseCode] == DBNull.Value ? null : objRow[convVideoResCase.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvVideoResCaseEN.CourseName = objRow[convVideoResCase.CourseName] == DBNull.Value ? null : objRow[convVideoResCase.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvVideoResCaseEN.VideoUrl = objRow[convVideoResCase.VideoUrl] == DBNull.Value ? null : objRow[convVideoResCase.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objvVideoResCaseEN.VideoPath = objRow[convVideoResCase.VideoPath] == DBNull.Value ? null : objRow[convVideoResCase.VideoPath].ToString().Trim(); //视频目录(字段类型:varchar,字段长度:1000,是否可空:True)
 objvVideoResCaseEN.ResErrMsg = objRow[convVideoResCase.ResErrMsg] == DBNull.Value ? null : objRow[convVideoResCase.ResErrMsg].ToString().Trim(); //资源错误信息(字段类型:varchar,字段长度:30,是否可空:True)
 objvVideoResCaseEN.UpdDate = objRow[convVideoResCase.UpdDate] == DBNull.Value ? null : objRow[convVideoResCase.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvVideoResCaseEN.UpdUserId = objRow[convVideoResCase.UpdUserId] == DBNull.Value ? null : objRow[convVideoResCase.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvVideoResCaseEN.Memo = objRow[convVideoResCase.Memo] == DBNull.Value ? null : objRow[convVideoResCase.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvVideoResCaseEN.OwnerNameWithId = objRow[convVideoResCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoResCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
 objvVideoResCaseEN.OwnerName = objRow[convVideoResCase.OwnerName] == DBNull.Value ? null : objRow[convVideoResCase.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvVideoResCaseEN.BrowseCount4Case = objRow[convVideoResCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoResCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvVideoResCaseEN.IsHaveVideo = objRow[convVideoResCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo(字段类型:varchar,字段长度:6,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvVideoResCaseDA: GetObjByIdVideoResCase)", objException.Message));
}
return objvVideoResCaseEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvVideoResCaseEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvVideoResCaseDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCaseDA.GetSpecSQLObj();
strSQL = "Select * from vVideoResCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvVideoResCaseEN objvVideoResCaseEN = new clsvVideoResCaseEN()
{
IdVideoResCase = objRow[convVideoResCase.IdVideoResCase].ToString().Trim(), //视频资源案例流水号
VideoResCaseID = objRow[convVideoResCase.VideoResCaseID].ToString().Trim(), //视频资源案例ID
VideoResCaseName = objRow[convVideoResCase.VideoResCaseName].ToString().Trim(), //视频资源案例名称
VideoResCaseTheme = objRow[convVideoResCase.VideoResCaseTheme] == DBNull.Value ? null : objRow[convVideoResCase.VideoResCaseTheme].ToString().Trim(), //视频资源案例主题词
IdVideoResCaseType = objRow[convVideoResCase.IdVideoResCaseType].ToString().Trim(), //视频资源类型流水号
VideoResCaseTypeName = objRow[convVideoResCase.VideoResCaseTypeName] == DBNull.Value ? null : objRow[convVideoResCase.VideoResCaseTypeName].ToString().Trim(), //视频资源案例类型名称
VideoResCaseText = objRow[convVideoResCase.VideoResCaseText] == DBNull.Value ? null : objRow[convVideoResCase.VideoResCaseText].ToString().Trim(), //案例文本内容
VideoResCaseDate = objRow[convVideoResCase.VideoResCaseDate] == DBNull.Value ? null : objRow[convVideoResCase.VideoResCaseDate].ToString().Trim(), //视频资源日期
VideoResCaseTime = objRow[convVideoResCase.VideoResCaseTime] == DBNull.Value ? null : objRow[convVideoResCase.VideoResCaseTime].ToString().Trim(), //视频资源时间
VideoResCaseDateIn = objRow[convVideoResCase.VideoResCaseDateIn] == DBNull.Value ? null : objRow[convVideoResCase.VideoResCaseDateIn].ToString().Trim(), //案例入库日期
VideoResCaseTimeIn = objRow[convVideoResCase.VideoResCaseTimeIn] == DBNull.Value ? null : objRow[convVideoResCase.VideoResCaseTimeIn].ToString().Trim(), //案例入库时间
OwnerId = objRow[convVideoResCase.OwnerId].ToString().Trim(), //拥有者Id
IdStudyLevel = objRow[convVideoResCase.IdStudyLevel] == DBNull.Value ? null : objRow[convVideoResCase.IdStudyLevel].ToString().Trim(), //id_StudyLevel
StudyLevelName = objRow[convVideoResCase.StudyLevelName] == DBNull.Value ? null : objRow[convVideoResCase.StudyLevelName].ToString().Trim(), //学段名称
IdTeachingPlan = objRow[convVideoResCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convVideoResCase.IdTeachingPlan].ToString().Trim(), //教案流水号
IdDiscipline = objRow[convVideoResCase.IdDiscipline].ToString().Trim(), //学科流水号
DisciplineID = objRow[convVideoResCase.DisciplineID] == DBNull.Value ? null : objRow[convVideoResCase.DisciplineID].ToString().Trim(), //学科ID
DisciplineName = objRow[convVideoResCase.DisciplineName] == DBNull.Value ? null : objRow[convVideoResCase.DisciplineName].ToString().Trim(), //学科名称
IdSenateGaugeVersion = objRow[convVideoResCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convVideoResCase.IdSenateGaugeVersion].ToString().Trim(), //评价量表版本流水号
senateGaugeVersionID = objRow[convVideoResCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoResCase.senateGaugeVersionID].ToString().Trim(), //评价量表版本ID
senateGaugeVersionName = objRow[convVideoResCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoResCase.senateGaugeVersionName].ToString().Trim(), //评价量表版本名称
senateGaugeVersionTtlScore = objRow[convVideoResCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convVideoResCase.senateGaugeVersionTtlScore].ToString().Trim()), //评价量表版本总分
VersionNo = objRow[convVideoResCase.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase.VersionNo].ToString().Trim()), //版本号
IdTeachSkill = objRow[convVideoResCase.IdTeachSkill].ToString().Trim(), //教学技能流水号
TeachSkillID = objRow[convVideoResCase.TeachSkillID] == DBNull.Value ? null : objRow[convVideoResCase.TeachSkillID].ToString().Trim(), //教学技能ID
SkillTypeName = objRow[convVideoResCase.SkillTypeName] == DBNull.Value ? null : objRow[convVideoResCase.SkillTypeName].ToString().Trim(), //技能类型名称
TeachSkillName = objRow[convVideoResCase.TeachSkillName] == DBNull.Value ? null : objRow[convVideoResCase.TeachSkillName].ToString().Trim(), //教学技能名称
TeachSkillTheory = objRow[convVideoResCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convVideoResCase.TeachSkillTheory].ToString().Trim(), //教学技能理论阐述
TeachSkillOperMethod = objRow[convVideoResCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convVideoResCase.TeachSkillOperMethod].ToString().Trim(), //教学技能实践操作方法
IdSkillType = objRow[convVideoResCase.IdSkillType] == DBNull.Value ? null : objRow[convVideoResCase.IdSkillType].ToString().Trim(), //技能类型流水号
SkillTypeID = objRow[convVideoResCase.SkillTypeID] == DBNull.Value ? null : objRow[convVideoResCase.SkillTypeID].ToString().Trim(), //技能类型ID
CaseLevelId = objRow[convVideoResCase.CaseLevelId] == DBNull.Value ? null : objRow[convVideoResCase.CaseLevelId].ToString().Trim(), //课例等级Id
CaseLevelName = objRow[convVideoResCase.CaseLevelName] == DBNull.Value ? null : objRow[convVideoResCase.CaseLevelName].ToString().Trim(), //案例等级名称
DocFile = objRow[convVideoResCase.DocFile] == DBNull.Value ? null : objRow[convVideoResCase.DocFile].ToString().Trim(), //生成的Word文件名
IsNeedGeneWord = TransNullToBool(objRow[convVideoResCase.IsNeedGeneWord].ToString().Trim()), //是否需要生成Word
WordCreateDate = objRow[convVideoResCase.WordCreateDate] == DBNull.Value ? null : objRow[convVideoResCase.WordCreateDate].ToString().Trim(), //Word生成日期
IsVisible = TransNullToBool(objRow[convVideoResCase.IsVisible].ToString().Trim()), //是否显示
IsDualVideo = TransNullToBool(objRow[convVideoResCase.IsDualVideo].ToString().Trim()), //是否双视频
IdXzCollege = objRow[convVideoResCase.IdXzCollege].ToString().Trim(), //学院流水号
CollegeID = objRow[convVideoResCase.CollegeID] == DBNull.Value ? null : objRow[convVideoResCase.CollegeID].ToString().Trim(), //学院ID
CollegeName = objRow[convVideoResCase.CollegeName] == DBNull.Value ? null : objRow[convVideoResCase.CollegeName].ToString().Trim(), //学院名称
CollegeNameA = objRow[convVideoResCase.CollegeNameA] == DBNull.Value ? null : objRow[convVideoResCase.CollegeNameA].ToString().Trim(), //学院名称简写
IdXzMajor = objRow[convVideoResCase.IdXzMajor].ToString().Trim(), //专业流水号
MajorID = objRow[convVideoResCase.MajorID] == DBNull.Value ? null : objRow[convVideoResCase.MajorID].ToString().Trim(), //专业ID
MajorName = objRow[convVideoResCase.MajorName] == DBNull.Value ? null : objRow[convVideoResCase.MajorName].ToString().Trim(), //专业名称
CourseChapterId = objRow[convVideoResCase.CourseChapterId] == DBNull.Value ? null : objRow[convVideoResCase.CourseChapterId].ToString().Trim(), //课程章节ID
CourseChapterName = objRow[convVideoResCase.CourseChapterName] == DBNull.Value ? null : objRow[convVideoResCase.CourseChapterName].ToString().Trim(), //课程章节名称
ParentNodeID = objRow[convVideoResCase.ParentNodeID] == DBNull.Value ? null : objRow[convVideoResCase.ParentNodeID].ToString().Trim(), //父节点编号
ParentNodeName = objRow[convVideoResCase.ParentNodeName] == DBNull.Value ? null : objRow[convVideoResCase.ParentNodeName].ToString().Trim(), //父节点名称
ViewCount = objRow[convVideoResCase.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase.ViewCount].ToString().Trim()), //浏览量
IsShow = TransNullToBool(objRow[convVideoResCase.IsShow].ToString().Trim()), //是否启用
DownloadNumber = objRow[convVideoResCase.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase.DownloadNumber].ToString().Trim()), //下载数目
FileIntegration = objRow[convVideoResCase.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase.FileIntegration].ToString().Trim()), //文件积分
LikeCount = objRow[convVideoResCase.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoResCase.LikeCount].ToString().Trim()), //资源喜欢数量
CollectionCount = objRow[convVideoResCase.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoResCase.CollectionCount].ToString().Trim()), //收藏数量
RecommendedDegreeId = objRow[convVideoResCase.RecommendedDegreeId].ToString().Trim(), //推荐度Id
RecommendedDegreeName = objRow[convVideoResCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convVideoResCase.RecommendedDegreeName].ToString().Trim(), //推荐度名称
ftpFileType = objRow[convVideoResCase.ftpFileType] == DBNull.Value ? null : objRow[convVideoResCase.ftpFileType].ToString().Trim(), //ftp文件类型
CourseId = objRow[convVideoResCase.CourseId] == DBNull.Value ? null : objRow[convVideoResCase.CourseId].ToString().Trim(), //课程Id
CourseCode = objRow[convVideoResCase.CourseCode] == DBNull.Value ? null : objRow[convVideoResCase.CourseCode].ToString().Trim(), //课程代码
CourseName = objRow[convVideoResCase.CourseName] == DBNull.Value ? null : objRow[convVideoResCase.CourseName].ToString().Trim(), //课程名称
VideoUrl = objRow[convVideoResCase.VideoUrl] == DBNull.Value ? null : objRow[convVideoResCase.VideoUrl].ToString().Trim(), //视频Url
VideoPath = objRow[convVideoResCase.VideoPath] == DBNull.Value ? null : objRow[convVideoResCase.VideoPath].ToString().Trim(), //视频目录
ResErrMsg = objRow[convVideoResCase.ResErrMsg] == DBNull.Value ? null : objRow[convVideoResCase.ResErrMsg].ToString().Trim(), //资源错误信息
UpdDate = objRow[convVideoResCase.UpdDate] == DBNull.Value ? null : objRow[convVideoResCase.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[convVideoResCase.UpdUserId] == DBNull.Value ? null : objRow[convVideoResCase.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[convVideoResCase.Memo] == DBNull.Value ? null : objRow[convVideoResCase.Memo].ToString().Trim(), //备注
OwnerNameWithId = objRow[convVideoResCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoResCase.OwnerNameWithId].ToString().Trim(), //拥有者名称附Id
OwnerName = objRow[convVideoResCase.OwnerName] == DBNull.Value ? null : objRow[convVideoResCase.OwnerName].ToString().Trim(), //拥有者姓名
BrowseCount4Case = objRow[convVideoResCase.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase.BrowseCount4Case].ToString().Trim()), //课例浏览次数
IsHaveVideo = objRow[convVideoResCase.IsHaveVideo].ToString().Trim() //IsHaveVideo
};
objvVideoResCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvVideoResCaseEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvVideoResCaseDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvVideoResCaseEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvVideoResCaseEN objvVideoResCaseEN = new clsvVideoResCaseEN();
try
{
objvVideoResCaseEN.IdVideoResCase = objRow[convVideoResCase.IdVideoResCase].ToString().Trim(); //视频资源案例流水号
objvVideoResCaseEN.VideoResCaseID = objRow[convVideoResCase.VideoResCaseID].ToString().Trim(); //视频资源案例ID
objvVideoResCaseEN.VideoResCaseName = objRow[convVideoResCase.VideoResCaseName].ToString().Trim(); //视频资源案例名称
objvVideoResCaseEN.VideoResCaseTheme = objRow[convVideoResCase.VideoResCaseTheme] == DBNull.Value ? null : objRow[convVideoResCase.VideoResCaseTheme].ToString().Trim(); //视频资源案例主题词
objvVideoResCaseEN.IdVideoResCaseType = objRow[convVideoResCase.IdVideoResCaseType].ToString().Trim(); //视频资源类型流水号
objvVideoResCaseEN.VideoResCaseTypeName = objRow[convVideoResCase.VideoResCaseTypeName] == DBNull.Value ? null : objRow[convVideoResCase.VideoResCaseTypeName].ToString().Trim(); //视频资源案例类型名称
objvVideoResCaseEN.VideoResCaseText = objRow[convVideoResCase.VideoResCaseText] == DBNull.Value ? null : objRow[convVideoResCase.VideoResCaseText].ToString().Trim(); //案例文本内容
objvVideoResCaseEN.VideoResCaseDate = objRow[convVideoResCase.VideoResCaseDate] == DBNull.Value ? null : objRow[convVideoResCase.VideoResCaseDate].ToString().Trim(); //视频资源日期
objvVideoResCaseEN.VideoResCaseTime = objRow[convVideoResCase.VideoResCaseTime] == DBNull.Value ? null : objRow[convVideoResCase.VideoResCaseTime].ToString().Trim(); //视频资源时间
objvVideoResCaseEN.VideoResCaseDateIn = objRow[convVideoResCase.VideoResCaseDateIn] == DBNull.Value ? null : objRow[convVideoResCase.VideoResCaseDateIn].ToString().Trim(); //案例入库日期
objvVideoResCaseEN.VideoResCaseTimeIn = objRow[convVideoResCase.VideoResCaseTimeIn] == DBNull.Value ? null : objRow[convVideoResCase.VideoResCaseTimeIn].ToString().Trim(); //案例入库时间
objvVideoResCaseEN.OwnerId = objRow[convVideoResCase.OwnerId].ToString().Trim(); //拥有者Id
objvVideoResCaseEN.IdStudyLevel = objRow[convVideoResCase.IdStudyLevel] == DBNull.Value ? null : objRow[convVideoResCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvVideoResCaseEN.StudyLevelName = objRow[convVideoResCase.StudyLevelName] == DBNull.Value ? null : objRow[convVideoResCase.StudyLevelName].ToString().Trim(); //学段名称
objvVideoResCaseEN.IdTeachingPlan = objRow[convVideoResCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convVideoResCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvVideoResCaseEN.IdDiscipline = objRow[convVideoResCase.IdDiscipline].ToString().Trim(); //学科流水号
objvVideoResCaseEN.DisciplineID = objRow[convVideoResCase.DisciplineID] == DBNull.Value ? null : objRow[convVideoResCase.DisciplineID].ToString().Trim(); //学科ID
objvVideoResCaseEN.DisciplineName = objRow[convVideoResCase.DisciplineName] == DBNull.Value ? null : objRow[convVideoResCase.DisciplineName].ToString().Trim(); //学科名称
objvVideoResCaseEN.IdSenateGaugeVersion = objRow[convVideoResCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convVideoResCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvVideoResCaseEN.senateGaugeVersionID = objRow[convVideoResCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoResCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoResCaseEN.senateGaugeVersionName = objRow[convVideoResCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoResCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoResCaseEN.senateGaugeVersionTtlScore = objRow[convVideoResCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convVideoResCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoResCaseEN.VersionNo = objRow[convVideoResCase.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase.VersionNo].ToString().Trim()); //版本号
objvVideoResCaseEN.IdTeachSkill = objRow[convVideoResCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvVideoResCaseEN.TeachSkillID = objRow[convVideoResCase.TeachSkillID] == DBNull.Value ? null : objRow[convVideoResCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvVideoResCaseEN.SkillTypeName = objRow[convVideoResCase.SkillTypeName] == DBNull.Value ? null : objRow[convVideoResCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvVideoResCaseEN.TeachSkillName = objRow[convVideoResCase.TeachSkillName] == DBNull.Value ? null : objRow[convVideoResCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvVideoResCaseEN.TeachSkillTheory = objRow[convVideoResCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convVideoResCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvVideoResCaseEN.TeachSkillOperMethod = objRow[convVideoResCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convVideoResCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvVideoResCaseEN.IdSkillType = objRow[convVideoResCase.IdSkillType] == DBNull.Value ? null : objRow[convVideoResCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvVideoResCaseEN.SkillTypeID = objRow[convVideoResCase.SkillTypeID] == DBNull.Value ? null : objRow[convVideoResCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvVideoResCaseEN.CaseLevelId = objRow[convVideoResCase.CaseLevelId] == DBNull.Value ? null : objRow[convVideoResCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvVideoResCaseEN.CaseLevelName = objRow[convVideoResCase.CaseLevelName] == DBNull.Value ? null : objRow[convVideoResCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvVideoResCaseEN.DocFile = objRow[convVideoResCase.DocFile] == DBNull.Value ? null : objRow[convVideoResCase.DocFile].ToString().Trim(); //生成的Word文件名
objvVideoResCaseEN.IsNeedGeneWord = TransNullToBool(objRow[convVideoResCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvVideoResCaseEN.WordCreateDate = objRow[convVideoResCase.WordCreateDate] == DBNull.Value ? null : objRow[convVideoResCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvVideoResCaseEN.IsVisible = TransNullToBool(objRow[convVideoResCase.IsVisible].ToString().Trim()); //是否显示
objvVideoResCaseEN.IsDualVideo = TransNullToBool(objRow[convVideoResCase.IsDualVideo].ToString().Trim()); //是否双视频
objvVideoResCaseEN.IdXzCollege = objRow[convVideoResCase.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoResCaseEN.CollegeID = objRow[convVideoResCase.CollegeID] == DBNull.Value ? null : objRow[convVideoResCase.CollegeID].ToString().Trim(); //学院ID
objvVideoResCaseEN.CollegeName = objRow[convVideoResCase.CollegeName] == DBNull.Value ? null : objRow[convVideoResCase.CollegeName].ToString().Trim(); //学院名称
objvVideoResCaseEN.CollegeNameA = objRow[convVideoResCase.CollegeNameA] == DBNull.Value ? null : objRow[convVideoResCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoResCaseEN.IdXzMajor = objRow[convVideoResCase.IdXzMajor].ToString().Trim(); //专业流水号
objvVideoResCaseEN.MajorID = objRow[convVideoResCase.MajorID] == DBNull.Value ? null : objRow[convVideoResCase.MajorID].ToString().Trim(); //专业ID
objvVideoResCaseEN.MajorName = objRow[convVideoResCase.MajorName] == DBNull.Value ? null : objRow[convVideoResCase.MajorName].ToString().Trim(); //专业名称
objvVideoResCaseEN.CourseChapterId = objRow[convVideoResCase.CourseChapterId] == DBNull.Value ? null : objRow[convVideoResCase.CourseChapterId].ToString().Trim(); //课程章节ID
objvVideoResCaseEN.CourseChapterName = objRow[convVideoResCase.CourseChapterName] == DBNull.Value ? null : objRow[convVideoResCase.CourseChapterName].ToString().Trim(); //课程章节名称
objvVideoResCaseEN.ParentNodeID = objRow[convVideoResCase.ParentNodeID] == DBNull.Value ? null : objRow[convVideoResCase.ParentNodeID].ToString().Trim(); //父节点编号
objvVideoResCaseEN.ParentNodeName = objRow[convVideoResCase.ParentNodeName] == DBNull.Value ? null : objRow[convVideoResCase.ParentNodeName].ToString().Trim(); //父节点名称
objvVideoResCaseEN.ViewCount = objRow[convVideoResCase.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase.ViewCount].ToString().Trim()); //浏览量
objvVideoResCaseEN.IsShow = TransNullToBool(objRow[convVideoResCase.IsShow].ToString().Trim()); //是否启用
objvVideoResCaseEN.DownloadNumber = objRow[convVideoResCase.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase.DownloadNumber].ToString().Trim()); //下载数目
objvVideoResCaseEN.FileIntegration = objRow[convVideoResCase.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase.FileIntegration].ToString().Trim()); //文件积分
objvVideoResCaseEN.LikeCount = objRow[convVideoResCase.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoResCase.LikeCount].ToString().Trim()); //资源喜欢数量
objvVideoResCaseEN.CollectionCount = objRow[convVideoResCase.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoResCase.CollectionCount].ToString().Trim()); //收藏数量
objvVideoResCaseEN.RecommendedDegreeId = objRow[convVideoResCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvVideoResCaseEN.RecommendedDegreeName = objRow[convVideoResCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convVideoResCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvVideoResCaseEN.ftpFileType = objRow[convVideoResCase.ftpFileType] == DBNull.Value ? null : objRow[convVideoResCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvVideoResCaseEN.CourseId = objRow[convVideoResCase.CourseId] == DBNull.Value ? null : objRow[convVideoResCase.CourseId].ToString().Trim(); //课程Id
objvVideoResCaseEN.CourseCode = objRow[convVideoResCase.CourseCode] == DBNull.Value ? null : objRow[convVideoResCase.CourseCode].ToString().Trim(); //课程代码
objvVideoResCaseEN.CourseName = objRow[convVideoResCase.CourseName] == DBNull.Value ? null : objRow[convVideoResCase.CourseName].ToString().Trim(); //课程名称
objvVideoResCaseEN.VideoUrl = objRow[convVideoResCase.VideoUrl] == DBNull.Value ? null : objRow[convVideoResCase.VideoUrl].ToString().Trim(); //视频Url
objvVideoResCaseEN.VideoPath = objRow[convVideoResCase.VideoPath] == DBNull.Value ? null : objRow[convVideoResCase.VideoPath].ToString().Trim(); //视频目录
objvVideoResCaseEN.ResErrMsg = objRow[convVideoResCase.ResErrMsg] == DBNull.Value ? null : objRow[convVideoResCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvVideoResCaseEN.UpdDate = objRow[convVideoResCase.UpdDate] == DBNull.Value ? null : objRow[convVideoResCase.UpdDate].ToString().Trim(); //修改日期
objvVideoResCaseEN.UpdUserId = objRow[convVideoResCase.UpdUserId] == DBNull.Value ? null : objRow[convVideoResCase.UpdUserId].ToString().Trim(); //修改用户Id
objvVideoResCaseEN.Memo = objRow[convVideoResCase.Memo] == DBNull.Value ? null : objRow[convVideoResCase.Memo].ToString().Trim(); //备注
objvVideoResCaseEN.OwnerNameWithId = objRow[convVideoResCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoResCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvVideoResCaseEN.OwnerName = objRow[convVideoResCase.OwnerName] == DBNull.Value ? null : objRow[convVideoResCase.OwnerName].ToString().Trim(); //拥有者姓名
objvVideoResCaseEN.BrowseCount4Case = objRow[convVideoResCase.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvVideoResCaseEN.IsHaveVideo = objRow[convVideoResCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvVideoResCaseDA: GetObjByDataRowvVideoResCase)", objException.Message));
}
objvVideoResCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvVideoResCaseEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvVideoResCaseEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvVideoResCaseEN objvVideoResCaseEN = new clsvVideoResCaseEN();
try
{
objvVideoResCaseEN.IdVideoResCase = objRow[convVideoResCase.IdVideoResCase].ToString().Trim(); //视频资源案例流水号
objvVideoResCaseEN.VideoResCaseID = objRow[convVideoResCase.VideoResCaseID].ToString().Trim(); //视频资源案例ID
objvVideoResCaseEN.VideoResCaseName = objRow[convVideoResCase.VideoResCaseName].ToString().Trim(); //视频资源案例名称
objvVideoResCaseEN.VideoResCaseTheme = objRow[convVideoResCase.VideoResCaseTheme] == DBNull.Value ? null : objRow[convVideoResCase.VideoResCaseTheme].ToString().Trim(); //视频资源案例主题词
objvVideoResCaseEN.IdVideoResCaseType = objRow[convVideoResCase.IdVideoResCaseType].ToString().Trim(); //视频资源类型流水号
objvVideoResCaseEN.VideoResCaseTypeName = objRow[convVideoResCase.VideoResCaseTypeName] == DBNull.Value ? null : objRow[convVideoResCase.VideoResCaseTypeName].ToString().Trim(); //视频资源案例类型名称
objvVideoResCaseEN.VideoResCaseText = objRow[convVideoResCase.VideoResCaseText] == DBNull.Value ? null : objRow[convVideoResCase.VideoResCaseText].ToString().Trim(); //案例文本内容
objvVideoResCaseEN.VideoResCaseDate = objRow[convVideoResCase.VideoResCaseDate] == DBNull.Value ? null : objRow[convVideoResCase.VideoResCaseDate].ToString().Trim(); //视频资源日期
objvVideoResCaseEN.VideoResCaseTime = objRow[convVideoResCase.VideoResCaseTime] == DBNull.Value ? null : objRow[convVideoResCase.VideoResCaseTime].ToString().Trim(); //视频资源时间
objvVideoResCaseEN.VideoResCaseDateIn = objRow[convVideoResCase.VideoResCaseDateIn] == DBNull.Value ? null : objRow[convVideoResCase.VideoResCaseDateIn].ToString().Trim(); //案例入库日期
objvVideoResCaseEN.VideoResCaseTimeIn = objRow[convVideoResCase.VideoResCaseTimeIn] == DBNull.Value ? null : objRow[convVideoResCase.VideoResCaseTimeIn].ToString().Trim(); //案例入库时间
objvVideoResCaseEN.OwnerId = objRow[convVideoResCase.OwnerId].ToString().Trim(); //拥有者Id
objvVideoResCaseEN.IdStudyLevel = objRow[convVideoResCase.IdStudyLevel] == DBNull.Value ? null : objRow[convVideoResCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvVideoResCaseEN.StudyLevelName = objRow[convVideoResCase.StudyLevelName] == DBNull.Value ? null : objRow[convVideoResCase.StudyLevelName].ToString().Trim(); //学段名称
objvVideoResCaseEN.IdTeachingPlan = objRow[convVideoResCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convVideoResCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvVideoResCaseEN.IdDiscipline = objRow[convVideoResCase.IdDiscipline].ToString().Trim(); //学科流水号
objvVideoResCaseEN.DisciplineID = objRow[convVideoResCase.DisciplineID] == DBNull.Value ? null : objRow[convVideoResCase.DisciplineID].ToString().Trim(); //学科ID
objvVideoResCaseEN.DisciplineName = objRow[convVideoResCase.DisciplineName] == DBNull.Value ? null : objRow[convVideoResCase.DisciplineName].ToString().Trim(); //学科名称
objvVideoResCaseEN.IdSenateGaugeVersion = objRow[convVideoResCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convVideoResCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvVideoResCaseEN.senateGaugeVersionID = objRow[convVideoResCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoResCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoResCaseEN.senateGaugeVersionName = objRow[convVideoResCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoResCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoResCaseEN.senateGaugeVersionTtlScore = objRow[convVideoResCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convVideoResCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoResCaseEN.VersionNo = objRow[convVideoResCase.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase.VersionNo].ToString().Trim()); //版本号
objvVideoResCaseEN.IdTeachSkill = objRow[convVideoResCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvVideoResCaseEN.TeachSkillID = objRow[convVideoResCase.TeachSkillID] == DBNull.Value ? null : objRow[convVideoResCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvVideoResCaseEN.SkillTypeName = objRow[convVideoResCase.SkillTypeName] == DBNull.Value ? null : objRow[convVideoResCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvVideoResCaseEN.TeachSkillName = objRow[convVideoResCase.TeachSkillName] == DBNull.Value ? null : objRow[convVideoResCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvVideoResCaseEN.TeachSkillTheory = objRow[convVideoResCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convVideoResCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvVideoResCaseEN.TeachSkillOperMethod = objRow[convVideoResCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convVideoResCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvVideoResCaseEN.IdSkillType = objRow[convVideoResCase.IdSkillType] == DBNull.Value ? null : objRow[convVideoResCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvVideoResCaseEN.SkillTypeID = objRow[convVideoResCase.SkillTypeID] == DBNull.Value ? null : objRow[convVideoResCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvVideoResCaseEN.CaseLevelId = objRow[convVideoResCase.CaseLevelId] == DBNull.Value ? null : objRow[convVideoResCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvVideoResCaseEN.CaseLevelName = objRow[convVideoResCase.CaseLevelName] == DBNull.Value ? null : objRow[convVideoResCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvVideoResCaseEN.DocFile = objRow[convVideoResCase.DocFile] == DBNull.Value ? null : objRow[convVideoResCase.DocFile].ToString().Trim(); //生成的Word文件名
objvVideoResCaseEN.IsNeedGeneWord = TransNullToBool(objRow[convVideoResCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvVideoResCaseEN.WordCreateDate = objRow[convVideoResCase.WordCreateDate] == DBNull.Value ? null : objRow[convVideoResCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvVideoResCaseEN.IsVisible = TransNullToBool(objRow[convVideoResCase.IsVisible].ToString().Trim()); //是否显示
objvVideoResCaseEN.IsDualVideo = TransNullToBool(objRow[convVideoResCase.IsDualVideo].ToString().Trim()); //是否双视频
objvVideoResCaseEN.IdXzCollege = objRow[convVideoResCase.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoResCaseEN.CollegeID = objRow[convVideoResCase.CollegeID] == DBNull.Value ? null : objRow[convVideoResCase.CollegeID].ToString().Trim(); //学院ID
objvVideoResCaseEN.CollegeName = objRow[convVideoResCase.CollegeName] == DBNull.Value ? null : objRow[convVideoResCase.CollegeName].ToString().Trim(); //学院名称
objvVideoResCaseEN.CollegeNameA = objRow[convVideoResCase.CollegeNameA] == DBNull.Value ? null : objRow[convVideoResCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoResCaseEN.IdXzMajor = objRow[convVideoResCase.IdXzMajor].ToString().Trim(); //专业流水号
objvVideoResCaseEN.MajorID = objRow[convVideoResCase.MajorID] == DBNull.Value ? null : objRow[convVideoResCase.MajorID].ToString().Trim(); //专业ID
objvVideoResCaseEN.MajorName = objRow[convVideoResCase.MajorName] == DBNull.Value ? null : objRow[convVideoResCase.MajorName].ToString().Trim(); //专业名称
objvVideoResCaseEN.CourseChapterId = objRow[convVideoResCase.CourseChapterId] == DBNull.Value ? null : objRow[convVideoResCase.CourseChapterId].ToString().Trim(); //课程章节ID
objvVideoResCaseEN.CourseChapterName = objRow[convVideoResCase.CourseChapterName] == DBNull.Value ? null : objRow[convVideoResCase.CourseChapterName].ToString().Trim(); //课程章节名称
objvVideoResCaseEN.ParentNodeID = objRow[convVideoResCase.ParentNodeID] == DBNull.Value ? null : objRow[convVideoResCase.ParentNodeID].ToString().Trim(); //父节点编号
objvVideoResCaseEN.ParentNodeName = objRow[convVideoResCase.ParentNodeName] == DBNull.Value ? null : objRow[convVideoResCase.ParentNodeName].ToString().Trim(); //父节点名称
objvVideoResCaseEN.ViewCount = objRow[convVideoResCase.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase.ViewCount].ToString().Trim()); //浏览量
objvVideoResCaseEN.IsShow = TransNullToBool(objRow[convVideoResCase.IsShow].ToString().Trim()); //是否启用
objvVideoResCaseEN.DownloadNumber = objRow[convVideoResCase.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase.DownloadNumber].ToString().Trim()); //下载数目
objvVideoResCaseEN.FileIntegration = objRow[convVideoResCase.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase.FileIntegration].ToString().Trim()); //文件积分
objvVideoResCaseEN.LikeCount = objRow[convVideoResCase.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoResCase.LikeCount].ToString().Trim()); //资源喜欢数量
objvVideoResCaseEN.CollectionCount = objRow[convVideoResCase.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoResCase.CollectionCount].ToString().Trim()); //收藏数量
objvVideoResCaseEN.RecommendedDegreeId = objRow[convVideoResCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvVideoResCaseEN.RecommendedDegreeName = objRow[convVideoResCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convVideoResCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvVideoResCaseEN.ftpFileType = objRow[convVideoResCase.ftpFileType] == DBNull.Value ? null : objRow[convVideoResCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvVideoResCaseEN.CourseId = objRow[convVideoResCase.CourseId] == DBNull.Value ? null : objRow[convVideoResCase.CourseId].ToString().Trim(); //课程Id
objvVideoResCaseEN.CourseCode = objRow[convVideoResCase.CourseCode] == DBNull.Value ? null : objRow[convVideoResCase.CourseCode].ToString().Trim(); //课程代码
objvVideoResCaseEN.CourseName = objRow[convVideoResCase.CourseName] == DBNull.Value ? null : objRow[convVideoResCase.CourseName].ToString().Trim(); //课程名称
objvVideoResCaseEN.VideoUrl = objRow[convVideoResCase.VideoUrl] == DBNull.Value ? null : objRow[convVideoResCase.VideoUrl].ToString().Trim(); //视频Url
objvVideoResCaseEN.VideoPath = objRow[convVideoResCase.VideoPath] == DBNull.Value ? null : objRow[convVideoResCase.VideoPath].ToString().Trim(); //视频目录
objvVideoResCaseEN.ResErrMsg = objRow[convVideoResCase.ResErrMsg] == DBNull.Value ? null : objRow[convVideoResCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvVideoResCaseEN.UpdDate = objRow[convVideoResCase.UpdDate] == DBNull.Value ? null : objRow[convVideoResCase.UpdDate].ToString().Trim(); //修改日期
objvVideoResCaseEN.UpdUserId = objRow[convVideoResCase.UpdUserId] == DBNull.Value ? null : objRow[convVideoResCase.UpdUserId].ToString().Trim(); //修改用户Id
objvVideoResCaseEN.Memo = objRow[convVideoResCase.Memo] == DBNull.Value ? null : objRow[convVideoResCase.Memo].ToString().Trim(); //备注
objvVideoResCaseEN.OwnerNameWithId = objRow[convVideoResCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoResCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvVideoResCaseEN.OwnerName = objRow[convVideoResCase.OwnerName] == DBNull.Value ? null : objRow[convVideoResCase.OwnerName].ToString().Trim(); //拥有者姓名
objvVideoResCaseEN.BrowseCount4Case = objRow[convVideoResCase.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvVideoResCaseEN.IsHaveVideo = objRow[convVideoResCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvVideoResCaseDA: GetObjByDataRow)", objException.Message));
}
objvVideoResCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvVideoResCaseEN;
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
objSQL = clsvVideoResCaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvVideoResCaseEN._CurrTabName, convVideoResCase.IdVideoResCase, 8, "");
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
objSQL = clsvVideoResCaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvVideoResCaseEN._CurrTabName, convVideoResCase.IdVideoResCase, 8, strPrefix);
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
 objSQL = clsvVideoResCaseDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdVideoResCase from vVideoResCase where " + strCondition;
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
 objSQL = clsvVideoResCaseDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdVideoResCase from vVideoResCase where " + strCondition;
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
 objSQL = clsvVideoResCaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vVideoResCase", "IdVideoResCase = " + "'"+ strIdVideoResCase+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvVideoResCaseDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vVideoResCase", strCondition))
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
objSQL = clsvVideoResCaseDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vVideoResCase");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvVideoResCaseENS">源对象</param>
 /// <param name = "objvVideoResCaseENT">目标对象</param>
public void CopyTo(clsvVideoResCaseEN objvVideoResCaseENS, clsvVideoResCaseEN objvVideoResCaseENT)
{
objvVideoResCaseENT.IdVideoResCase = objvVideoResCaseENS.IdVideoResCase; //视频资源案例流水号
objvVideoResCaseENT.VideoResCaseID = objvVideoResCaseENS.VideoResCaseID; //视频资源案例ID
objvVideoResCaseENT.VideoResCaseName = objvVideoResCaseENS.VideoResCaseName; //视频资源案例名称
objvVideoResCaseENT.VideoResCaseTheme = objvVideoResCaseENS.VideoResCaseTheme; //视频资源案例主题词
objvVideoResCaseENT.IdVideoResCaseType = objvVideoResCaseENS.IdVideoResCaseType; //视频资源类型流水号
objvVideoResCaseENT.VideoResCaseTypeName = objvVideoResCaseENS.VideoResCaseTypeName; //视频资源案例类型名称
objvVideoResCaseENT.VideoResCaseText = objvVideoResCaseENS.VideoResCaseText; //案例文本内容
objvVideoResCaseENT.VideoResCaseDate = objvVideoResCaseENS.VideoResCaseDate; //视频资源日期
objvVideoResCaseENT.VideoResCaseTime = objvVideoResCaseENS.VideoResCaseTime; //视频资源时间
objvVideoResCaseENT.VideoResCaseDateIn = objvVideoResCaseENS.VideoResCaseDateIn; //案例入库日期
objvVideoResCaseENT.VideoResCaseTimeIn = objvVideoResCaseENS.VideoResCaseTimeIn; //案例入库时间
objvVideoResCaseENT.OwnerId = objvVideoResCaseENS.OwnerId; //拥有者Id
objvVideoResCaseENT.IdStudyLevel = objvVideoResCaseENS.IdStudyLevel; //id_StudyLevel
objvVideoResCaseENT.StudyLevelName = objvVideoResCaseENS.StudyLevelName; //学段名称
objvVideoResCaseENT.IdTeachingPlan = objvVideoResCaseENS.IdTeachingPlan; //教案流水号
objvVideoResCaseENT.IdDiscipline = objvVideoResCaseENS.IdDiscipline; //学科流水号
objvVideoResCaseENT.DisciplineID = objvVideoResCaseENS.DisciplineID; //学科ID
objvVideoResCaseENT.DisciplineName = objvVideoResCaseENS.DisciplineName; //学科名称
objvVideoResCaseENT.IdSenateGaugeVersion = objvVideoResCaseENS.IdSenateGaugeVersion; //评价量表版本流水号
objvVideoResCaseENT.senateGaugeVersionID = objvVideoResCaseENS.senateGaugeVersionID; //评价量表版本ID
objvVideoResCaseENT.senateGaugeVersionName = objvVideoResCaseENS.senateGaugeVersionName; //评价量表版本名称
objvVideoResCaseENT.senateGaugeVersionTtlScore = objvVideoResCaseENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvVideoResCaseENT.VersionNo = objvVideoResCaseENS.VersionNo; //版本号
objvVideoResCaseENT.IdTeachSkill = objvVideoResCaseENS.IdTeachSkill; //教学技能流水号
objvVideoResCaseENT.TeachSkillID = objvVideoResCaseENS.TeachSkillID; //教学技能ID
objvVideoResCaseENT.SkillTypeName = objvVideoResCaseENS.SkillTypeName; //技能类型名称
objvVideoResCaseENT.TeachSkillName = objvVideoResCaseENS.TeachSkillName; //教学技能名称
objvVideoResCaseENT.TeachSkillTheory = objvVideoResCaseENS.TeachSkillTheory; //教学技能理论阐述
objvVideoResCaseENT.TeachSkillOperMethod = objvVideoResCaseENS.TeachSkillOperMethod; //教学技能实践操作方法
objvVideoResCaseENT.IdSkillType = objvVideoResCaseENS.IdSkillType; //技能类型流水号
objvVideoResCaseENT.SkillTypeID = objvVideoResCaseENS.SkillTypeID; //技能类型ID
objvVideoResCaseENT.CaseLevelId = objvVideoResCaseENS.CaseLevelId; //课例等级Id
objvVideoResCaseENT.CaseLevelName = objvVideoResCaseENS.CaseLevelName; //案例等级名称
objvVideoResCaseENT.DocFile = objvVideoResCaseENS.DocFile; //生成的Word文件名
objvVideoResCaseENT.IsNeedGeneWord = objvVideoResCaseENS.IsNeedGeneWord; //是否需要生成Word
objvVideoResCaseENT.WordCreateDate = objvVideoResCaseENS.WordCreateDate; //Word生成日期
objvVideoResCaseENT.IsVisible = objvVideoResCaseENS.IsVisible; //是否显示
objvVideoResCaseENT.IsDualVideo = objvVideoResCaseENS.IsDualVideo; //是否双视频
objvVideoResCaseENT.IdXzCollege = objvVideoResCaseENS.IdXzCollege; //学院流水号
objvVideoResCaseENT.CollegeID = objvVideoResCaseENS.CollegeID; //学院ID
objvVideoResCaseENT.CollegeName = objvVideoResCaseENS.CollegeName; //学院名称
objvVideoResCaseENT.CollegeNameA = objvVideoResCaseENS.CollegeNameA; //学院名称简写
objvVideoResCaseENT.IdXzMajor = objvVideoResCaseENS.IdXzMajor; //专业流水号
objvVideoResCaseENT.MajorID = objvVideoResCaseENS.MajorID; //专业ID
objvVideoResCaseENT.MajorName = objvVideoResCaseENS.MajorName; //专业名称
objvVideoResCaseENT.CourseChapterId = objvVideoResCaseENS.CourseChapterId; //课程章节ID
objvVideoResCaseENT.CourseChapterName = objvVideoResCaseENS.CourseChapterName; //课程章节名称
objvVideoResCaseENT.ParentNodeID = objvVideoResCaseENS.ParentNodeID; //父节点编号
objvVideoResCaseENT.ParentNodeName = objvVideoResCaseENS.ParentNodeName; //父节点名称
objvVideoResCaseENT.ViewCount = objvVideoResCaseENS.ViewCount; //浏览量
objvVideoResCaseENT.IsShow = objvVideoResCaseENS.IsShow; //是否启用
objvVideoResCaseENT.DownloadNumber = objvVideoResCaseENS.DownloadNumber; //下载数目
objvVideoResCaseENT.FileIntegration = objvVideoResCaseENS.FileIntegration; //文件积分
objvVideoResCaseENT.LikeCount = objvVideoResCaseENS.LikeCount; //资源喜欢数量
objvVideoResCaseENT.CollectionCount = objvVideoResCaseENS.CollectionCount; //收藏数量
objvVideoResCaseENT.RecommendedDegreeId = objvVideoResCaseENS.RecommendedDegreeId; //推荐度Id
objvVideoResCaseENT.RecommendedDegreeName = objvVideoResCaseENS.RecommendedDegreeName; //推荐度名称
objvVideoResCaseENT.ftpFileType = objvVideoResCaseENS.ftpFileType; //ftp文件类型
objvVideoResCaseENT.CourseId = objvVideoResCaseENS.CourseId; //课程Id
objvVideoResCaseENT.CourseCode = objvVideoResCaseENS.CourseCode; //课程代码
objvVideoResCaseENT.CourseName = objvVideoResCaseENS.CourseName; //课程名称
objvVideoResCaseENT.VideoUrl = objvVideoResCaseENS.VideoUrl; //视频Url
objvVideoResCaseENT.VideoPath = objvVideoResCaseENS.VideoPath; //视频目录
objvVideoResCaseENT.ResErrMsg = objvVideoResCaseENS.ResErrMsg; //资源错误信息
objvVideoResCaseENT.UpdDate = objvVideoResCaseENS.UpdDate; //修改日期
objvVideoResCaseENT.UpdUserId = objvVideoResCaseENS.UpdUserId; //修改用户Id
objvVideoResCaseENT.Memo = objvVideoResCaseENS.Memo; //备注
objvVideoResCaseENT.OwnerNameWithId = objvVideoResCaseENS.OwnerNameWithId; //拥有者名称附Id
objvVideoResCaseENT.OwnerName = objvVideoResCaseENS.OwnerName; //拥有者姓名
objvVideoResCaseENT.BrowseCount4Case = objvVideoResCaseENS.BrowseCount4Case; //课例浏览次数
objvVideoResCaseENT.IsHaveVideo = objvVideoResCaseENS.IsHaveVideo; //IsHaveVideo
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvVideoResCaseEN objvVideoResCaseEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvVideoResCaseEN.IdVideoResCase, 8, convVideoResCase.IdVideoResCase);
clsCheckSql.CheckFieldLen(objvVideoResCaseEN.VideoResCaseID, 8, convVideoResCase.VideoResCaseID);
clsCheckSql.CheckFieldLen(objvVideoResCaseEN.VideoResCaseName, 100, convVideoResCase.VideoResCaseName);
clsCheckSql.CheckFieldLen(objvVideoResCaseEN.VideoResCaseTheme, 200, convVideoResCase.VideoResCaseTheme);
clsCheckSql.CheckFieldLen(objvVideoResCaseEN.IdVideoResCaseType, 4, convVideoResCase.IdVideoResCaseType);
clsCheckSql.CheckFieldLen(objvVideoResCaseEN.VideoResCaseTypeName, 30, convVideoResCase.VideoResCaseTypeName);
clsCheckSql.CheckFieldLen(objvVideoResCaseEN.VideoResCaseText, 8000, convVideoResCase.VideoResCaseText);
clsCheckSql.CheckFieldLen(objvVideoResCaseEN.VideoResCaseDate, 8, convVideoResCase.VideoResCaseDate);
clsCheckSql.CheckFieldLen(objvVideoResCaseEN.VideoResCaseTime, 6, convVideoResCase.VideoResCaseTime);
clsCheckSql.CheckFieldLen(objvVideoResCaseEN.VideoResCaseDateIn, 8, convVideoResCase.VideoResCaseDateIn);
clsCheckSql.CheckFieldLen(objvVideoResCaseEN.VideoResCaseTimeIn, 6, convVideoResCase.VideoResCaseTimeIn);
clsCheckSql.CheckFieldLen(objvVideoResCaseEN.OwnerId, 20, convVideoResCase.OwnerId);
clsCheckSql.CheckFieldLen(objvVideoResCaseEN.IdStudyLevel, 4, convVideoResCase.IdStudyLevel);
clsCheckSql.CheckFieldLen(objvVideoResCaseEN.StudyLevelName, 50, convVideoResCase.StudyLevelName);
clsCheckSql.CheckFieldLen(objvVideoResCaseEN.IdTeachingPlan, 8, convVideoResCase.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objvVideoResCaseEN.IdDiscipline, 4, convVideoResCase.IdDiscipline);
clsCheckSql.CheckFieldLen(objvVideoResCaseEN.DisciplineID, 4, convVideoResCase.DisciplineID);
clsCheckSql.CheckFieldLen(objvVideoResCaseEN.DisciplineName, 50, convVideoResCase.DisciplineName);
clsCheckSql.CheckFieldLen(objvVideoResCaseEN.IdSenateGaugeVersion, 4, convVideoResCase.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objvVideoResCaseEN.senateGaugeVersionID, 4, convVideoResCase.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(objvVideoResCaseEN.senateGaugeVersionName, 200, convVideoResCase.senateGaugeVersionName);
clsCheckSql.CheckFieldLen(objvVideoResCaseEN.IdTeachSkill, 8, convVideoResCase.IdTeachSkill);
clsCheckSql.CheckFieldLen(objvVideoResCaseEN.TeachSkillID, 8, convVideoResCase.TeachSkillID);
clsCheckSql.CheckFieldLen(objvVideoResCaseEN.SkillTypeName, 50, convVideoResCase.SkillTypeName);
clsCheckSql.CheckFieldLen(objvVideoResCaseEN.TeachSkillName, 50, convVideoResCase.TeachSkillName);
clsCheckSql.CheckFieldLen(objvVideoResCaseEN.TeachSkillTheory, 8000, convVideoResCase.TeachSkillTheory);
clsCheckSql.CheckFieldLen(objvVideoResCaseEN.TeachSkillOperMethod, 2000, convVideoResCase.TeachSkillOperMethod);
clsCheckSql.CheckFieldLen(objvVideoResCaseEN.IdSkillType, 4, convVideoResCase.IdSkillType);
clsCheckSql.CheckFieldLen(objvVideoResCaseEN.SkillTypeID, 4, convVideoResCase.SkillTypeID);
clsCheckSql.CheckFieldLen(objvVideoResCaseEN.CaseLevelId, 2, convVideoResCase.CaseLevelId);
clsCheckSql.CheckFieldLen(objvVideoResCaseEN.CaseLevelName, 30, convVideoResCase.CaseLevelName);
clsCheckSql.CheckFieldLen(objvVideoResCaseEN.DocFile, 200, convVideoResCase.DocFile);
clsCheckSql.CheckFieldLen(objvVideoResCaseEN.WordCreateDate, 14, convVideoResCase.WordCreateDate);
clsCheckSql.CheckFieldLen(objvVideoResCaseEN.IdXzCollege, 4, convVideoResCase.IdXzCollege);
clsCheckSql.CheckFieldLen(objvVideoResCaseEN.CollegeID, 4, convVideoResCase.CollegeID);
clsCheckSql.CheckFieldLen(objvVideoResCaseEN.CollegeName, 100, convVideoResCase.CollegeName);
clsCheckSql.CheckFieldLen(objvVideoResCaseEN.CollegeNameA, 12, convVideoResCase.CollegeNameA);
clsCheckSql.CheckFieldLen(objvVideoResCaseEN.IdXzMajor, 8, convVideoResCase.IdXzMajor);
clsCheckSql.CheckFieldLen(objvVideoResCaseEN.MajorID, 4, convVideoResCase.MajorID);
clsCheckSql.CheckFieldLen(objvVideoResCaseEN.MajorName, 100, convVideoResCase.MajorName);
clsCheckSql.CheckFieldLen(objvVideoResCaseEN.CourseChapterId, 8, convVideoResCase.CourseChapterId);
clsCheckSql.CheckFieldLen(objvVideoResCaseEN.CourseChapterName, 100, convVideoResCase.CourseChapterName);
clsCheckSql.CheckFieldLen(objvVideoResCaseEN.ParentNodeID, 8, convVideoResCase.ParentNodeID);
clsCheckSql.CheckFieldLen(objvVideoResCaseEN.ParentNodeName, 50, convVideoResCase.ParentNodeName);
clsCheckSql.CheckFieldLen(objvVideoResCaseEN.RecommendedDegreeId, 2, convVideoResCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objvVideoResCaseEN.RecommendedDegreeName, 30, convVideoResCase.RecommendedDegreeName);
clsCheckSql.CheckFieldLen(objvVideoResCaseEN.ftpFileType, 30, convVideoResCase.ftpFileType);
clsCheckSql.CheckFieldLen(objvVideoResCaseEN.CourseId, 8, convVideoResCase.CourseId);
clsCheckSql.CheckFieldLen(objvVideoResCaseEN.CourseCode, 20, convVideoResCase.CourseCode);
clsCheckSql.CheckFieldLen(objvVideoResCaseEN.CourseName, 100, convVideoResCase.CourseName);
clsCheckSql.CheckFieldLen(objvVideoResCaseEN.VideoUrl, 1000, convVideoResCase.VideoUrl);
clsCheckSql.CheckFieldLen(objvVideoResCaseEN.VideoPath, 1000, convVideoResCase.VideoPath);
clsCheckSql.CheckFieldLen(objvVideoResCaseEN.ResErrMsg, 30, convVideoResCase.ResErrMsg);
clsCheckSql.CheckFieldLen(objvVideoResCaseEN.UpdDate, 20, convVideoResCase.UpdDate);
clsCheckSql.CheckFieldLen(objvVideoResCaseEN.UpdUserId, 20, convVideoResCase.UpdUserId);
clsCheckSql.CheckFieldLen(objvVideoResCaseEN.Memo, 1000, convVideoResCase.Memo);
clsCheckSql.CheckFieldLen(objvVideoResCaseEN.OwnerNameWithId, 51, convVideoResCase.OwnerNameWithId);
clsCheckSql.CheckFieldLen(objvVideoResCaseEN.OwnerName, 30, convVideoResCase.OwnerName);
clsCheckSql.CheckFieldLen(objvVideoResCaseEN.IsHaveVideo, 6, convVideoResCase.IsHaveVideo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseEN.IdVideoResCase, convVideoResCase.IdVideoResCase);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseEN.VideoResCaseID, convVideoResCase.VideoResCaseID);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseEN.VideoResCaseName, convVideoResCase.VideoResCaseName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseEN.VideoResCaseTheme, convVideoResCase.VideoResCaseTheme);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseEN.IdVideoResCaseType, convVideoResCase.IdVideoResCaseType);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseEN.VideoResCaseTypeName, convVideoResCase.VideoResCaseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseEN.VideoResCaseText, convVideoResCase.VideoResCaseText);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseEN.VideoResCaseDate, convVideoResCase.VideoResCaseDate);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseEN.VideoResCaseTime, convVideoResCase.VideoResCaseTime);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseEN.VideoResCaseDateIn, convVideoResCase.VideoResCaseDateIn);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseEN.VideoResCaseTimeIn, convVideoResCase.VideoResCaseTimeIn);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseEN.OwnerId, convVideoResCase.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseEN.IdStudyLevel, convVideoResCase.IdStudyLevel);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseEN.StudyLevelName, convVideoResCase.StudyLevelName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseEN.IdTeachingPlan, convVideoResCase.IdTeachingPlan);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseEN.IdDiscipline, convVideoResCase.IdDiscipline);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseEN.DisciplineID, convVideoResCase.DisciplineID);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseEN.DisciplineName, convVideoResCase.DisciplineName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseEN.IdSenateGaugeVersion, convVideoResCase.IdSenateGaugeVersion);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseEN.senateGaugeVersionID, convVideoResCase.senateGaugeVersionID);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseEN.senateGaugeVersionName, convVideoResCase.senateGaugeVersionName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseEN.IdTeachSkill, convVideoResCase.IdTeachSkill);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseEN.TeachSkillID, convVideoResCase.TeachSkillID);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseEN.SkillTypeName, convVideoResCase.SkillTypeName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseEN.TeachSkillName, convVideoResCase.TeachSkillName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseEN.TeachSkillTheory, convVideoResCase.TeachSkillTheory);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseEN.TeachSkillOperMethod, convVideoResCase.TeachSkillOperMethod);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseEN.IdSkillType, convVideoResCase.IdSkillType);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseEN.SkillTypeID, convVideoResCase.SkillTypeID);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseEN.CaseLevelId, convVideoResCase.CaseLevelId);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseEN.CaseLevelName, convVideoResCase.CaseLevelName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseEN.DocFile, convVideoResCase.DocFile);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseEN.WordCreateDate, convVideoResCase.WordCreateDate);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseEN.IdXzCollege, convVideoResCase.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseEN.CollegeID, convVideoResCase.CollegeID);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseEN.CollegeName, convVideoResCase.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseEN.CollegeNameA, convVideoResCase.CollegeNameA);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseEN.IdXzMajor, convVideoResCase.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseEN.MajorID, convVideoResCase.MajorID);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseEN.MajorName, convVideoResCase.MajorName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseEN.CourseChapterId, convVideoResCase.CourseChapterId);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseEN.CourseChapterName, convVideoResCase.CourseChapterName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseEN.ParentNodeID, convVideoResCase.ParentNodeID);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseEN.ParentNodeName, convVideoResCase.ParentNodeName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseEN.RecommendedDegreeId, convVideoResCase.RecommendedDegreeId);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseEN.RecommendedDegreeName, convVideoResCase.RecommendedDegreeName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseEN.ftpFileType, convVideoResCase.ftpFileType);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseEN.CourseId, convVideoResCase.CourseId);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseEN.CourseCode, convVideoResCase.CourseCode);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseEN.CourseName, convVideoResCase.CourseName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseEN.VideoUrl, convVideoResCase.VideoUrl);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseEN.VideoPath, convVideoResCase.VideoPath);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseEN.ResErrMsg, convVideoResCase.ResErrMsg);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseEN.UpdDate, convVideoResCase.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseEN.UpdUserId, convVideoResCase.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseEN.Memo, convVideoResCase.Memo);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseEN.OwnerNameWithId, convVideoResCase.OwnerNameWithId);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseEN.OwnerName, convVideoResCase.OwnerName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseEN.IsHaveVideo, convVideoResCase.IsHaveVideo);
//检查外键字段长度
 objvVideoResCaseEN._IsCheckProperty = true;
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
 objSQL = clsvVideoResCaseDA.GetSpecSQLObj();
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
 objSQL = clsvVideoResCaseDA.GetSpecSQLObj();
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
 objSQL = clsvVideoResCaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvVideoResCaseEN._CurrTabName);
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
 objSQL = clsvVideoResCaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvVideoResCaseEN._CurrTabName, strCondition);
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
 objSQL = clsvVideoResCaseDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}