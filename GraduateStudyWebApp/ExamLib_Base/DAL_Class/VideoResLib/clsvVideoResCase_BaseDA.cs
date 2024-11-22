
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvVideoResCase_BaseDA
 表名:vVideoResCase_Base(01120527)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:50:57
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
 /// v视频资源案例_Base(vVideoResCase_Base)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvVideoResCase_BaseDA : clsCommBase4DA
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
 return clsvVideoResCase_BaseEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvVideoResCase_BaseEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvVideoResCase_BaseEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvVideoResCase_BaseEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvVideoResCase_BaseEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:vVideoResCase_Base中,检查关键字,长度不正确!(clsvVideoResCase_BaseDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdVideoResCase)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vVideoResCase_Base中,关键字不能为空 或 null!(clsvVideoResCase_BaseDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdVideoResCase);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvVideoResCase_BaseDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvVideoResCase_BaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCase_BaseDA.GetSpecSQLObj();
strSQL = "Select * from vVideoResCase_Base where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vVideoResCase_Base(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvVideoResCase_BaseDA: GetDataTable_vVideoResCase_Base)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCase_BaseDA.GetSpecSQLObj();
strSQL = "Select * from vVideoResCase_Base where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvVideoResCase_BaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCase_BaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvVideoResCase_BaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCase_BaseDA.GetSpecSQLObj();
strSQL = "Select * from vVideoResCase_Base where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvVideoResCase_BaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCase_BaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvVideoResCase_BaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCase_BaseDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vVideoResCase_Base where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vVideoResCase_Base where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvVideoResCase_BaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCase_BaseDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vVideoResCase_Base where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvVideoResCase_BaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCase_BaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vVideoResCase_Base.* from vVideoResCase_Base Left Join {1} on {2} where {3} and vVideoResCase_Base.IdVideoResCase not in (Select top {5} vVideoResCase_Base.IdVideoResCase from vVideoResCase_Base Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vVideoResCase_Base where {1} and IdVideoResCase not in (Select top {2} IdVideoResCase from vVideoResCase_Base where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vVideoResCase_Base where {1} and IdVideoResCase not in (Select top {3} IdVideoResCase from vVideoResCase_Base where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvVideoResCase_BaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCase_BaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vVideoResCase_Base.* from vVideoResCase_Base Left Join {1} on {2} where {3} and vVideoResCase_Base.IdVideoResCase not in (Select top {5} vVideoResCase_Base.IdVideoResCase from vVideoResCase_Base Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vVideoResCase_Base where {1} and IdVideoResCase not in (Select top {2} IdVideoResCase from vVideoResCase_Base where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vVideoResCase_Base where {1} and IdVideoResCase not in (Select top {3} IdVideoResCase from vVideoResCase_Base where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvVideoResCase_BaseEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvVideoResCase_BaseDA:GetObjLst)", objException.Message));
}
List<clsvVideoResCase_BaseEN> arrObjLst = new List<clsvVideoResCase_BaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCase_BaseDA.GetSpecSQLObj();
strSQL = "Select * from vVideoResCase_Base where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoResCase_BaseEN objvVideoResCase_BaseEN = new clsvVideoResCase_BaseEN();
try
{
objvVideoResCase_BaseEN.IdVideoResCase = objRow[convVideoResCase_Base.IdVideoResCase].ToString().Trim(); //视频资源案例流水号
objvVideoResCase_BaseEN.VideoResCaseID = objRow[convVideoResCase_Base.VideoResCaseID].ToString().Trim(); //视频资源案例ID
objvVideoResCase_BaseEN.VideoResCaseName = objRow[convVideoResCase_Base.VideoResCaseName].ToString().Trim(); //视频资源案例名称
objvVideoResCase_BaseEN.VideoResCaseTheme = objRow[convVideoResCase_Base.VideoResCaseTheme] == DBNull.Value ? null : objRow[convVideoResCase_Base.VideoResCaseTheme].ToString().Trim(); //视频资源案例主题词
objvVideoResCase_BaseEN.IdVideoResCaseType = objRow[convVideoResCase_Base.IdVideoResCaseType].ToString().Trim(); //视频资源类型流水号
objvVideoResCase_BaseEN.VideoResCaseTypeName = objRow[convVideoResCase_Base.VideoResCaseTypeName] == DBNull.Value ? null : objRow[convVideoResCase_Base.VideoResCaseTypeName].ToString().Trim(); //视频资源案例类型名称
objvVideoResCase_BaseEN.VideoResCaseText = objRow[convVideoResCase_Base.VideoResCaseText] == DBNull.Value ? null : objRow[convVideoResCase_Base.VideoResCaseText].ToString().Trim(); //案例文本内容
objvVideoResCase_BaseEN.VideoResCaseDate = objRow[convVideoResCase_Base.VideoResCaseDate] == DBNull.Value ? null : objRow[convVideoResCase_Base.VideoResCaseDate].ToString().Trim(); //视频资源日期
objvVideoResCase_BaseEN.VideoResCaseTime = objRow[convVideoResCase_Base.VideoResCaseTime] == DBNull.Value ? null : objRow[convVideoResCase_Base.VideoResCaseTime].ToString().Trim(); //视频资源时间
objvVideoResCase_BaseEN.VideoResCaseDateIn = objRow[convVideoResCase_Base.VideoResCaseDateIn] == DBNull.Value ? null : objRow[convVideoResCase_Base.VideoResCaseDateIn].ToString().Trim(); //案例入库日期
objvVideoResCase_BaseEN.VideoResCaseTimeIn = objRow[convVideoResCase_Base.VideoResCaseTimeIn] == DBNull.Value ? null : objRow[convVideoResCase_Base.VideoResCaseTimeIn].ToString().Trim(); //案例入库时间
objvVideoResCase_BaseEN.OwnerId = objRow[convVideoResCase_Base.OwnerId].ToString().Trim(); //拥有者Id
objvVideoResCase_BaseEN.IdStudyLevel = objRow[convVideoResCase_Base.IdStudyLevel] == DBNull.Value ? null : objRow[convVideoResCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvVideoResCase_BaseEN.StudyLevelName = objRow[convVideoResCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convVideoResCase_Base.StudyLevelName].ToString().Trim(); //学段名称
objvVideoResCase_BaseEN.IdTeachingPlan = objRow[convVideoResCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convVideoResCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvVideoResCase_BaseEN.IdDiscipline = objRow[convVideoResCase_Base.IdDiscipline].ToString().Trim(); //学科流水号
objvVideoResCase_BaseEN.DisciplineID = objRow[convVideoResCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convVideoResCase_Base.DisciplineID].ToString().Trim(); //学科ID
objvVideoResCase_BaseEN.DisciplineName = objRow[convVideoResCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convVideoResCase_Base.DisciplineName].ToString().Trim(); //学科名称
objvVideoResCase_BaseEN.IdSenateGaugeVersion = objRow[convVideoResCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convVideoResCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvVideoResCase_BaseEN.senateGaugeVersionID = objRow[convVideoResCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoResCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoResCase_BaseEN.senateGaugeVersionName = objRow[convVideoResCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoResCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoResCase_BaseEN.senateGaugeVersionTtlScore = objRow[convVideoResCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convVideoResCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoResCase_BaseEN.VersionNo = objRow[convVideoResCase_Base.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase_Base.VersionNo].ToString().Trim()); //版本号
objvVideoResCase_BaseEN.IdTeachSkill = objRow[convVideoResCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvVideoResCase_BaseEN.TeachSkillID = objRow[convVideoResCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convVideoResCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID
objvVideoResCase_BaseEN.SkillTypeName = objRow[convVideoResCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convVideoResCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称
objvVideoResCase_BaseEN.TeachSkillName = objRow[convVideoResCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convVideoResCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称
objvVideoResCase_BaseEN.TeachSkillTheory = objRow[convVideoResCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convVideoResCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvVideoResCase_BaseEN.TeachSkillOperMethod = objRow[convVideoResCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convVideoResCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvVideoResCase_BaseEN.IdSkillType = objRow[convVideoResCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convVideoResCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号
objvVideoResCase_BaseEN.SkillTypeID = objRow[convVideoResCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convVideoResCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID
objvVideoResCase_BaseEN.CaseLevelId = objRow[convVideoResCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convVideoResCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvVideoResCase_BaseEN.CaseLevelName = objRow[convVideoResCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convVideoResCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvVideoResCase_BaseEN.DocFile = objRow[convVideoResCase_Base.DocFile] == DBNull.Value ? null : objRow[convVideoResCase_Base.DocFile].ToString().Trim(); //生成的Word文件名
objvVideoResCase_BaseEN.IsNeedGeneWord = TransNullToBool(objRow[convVideoResCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvVideoResCase_BaseEN.WordCreateDate = objRow[convVideoResCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convVideoResCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期
objvVideoResCase_BaseEN.IsVisible = TransNullToBool(objRow[convVideoResCase_Base.IsVisible].ToString().Trim()); //是否显示
objvVideoResCase_BaseEN.IsDualVideo = TransNullToBool(objRow[convVideoResCase_Base.IsDualVideo].ToString().Trim()); //是否双视频
objvVideoResCase_BaseEN.IdXzCollege = objRow[convVideoResCase_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoResCase_BaseEN.CollegeID = objRow[convVideoResCase_Base.CollegeID] == DBNull.Value ? null : objRow[convVideoResCase_Base.CollegeID].ToString().Trim(); //学院ID
objvVideoResCase_BaseEN.CollegeName = objRow[convVideoResCase_Base.CollegeName] == DBNull.Value ? null : objRow[convVideoResCase_Base.CollegeName].ToString().Trim(); //学院名称
objvVideoResCase_BaseEN.CollegeNameA = objRow[convVideoResCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convVideoResCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoResCase_BaseEN.IdXzMajor = objRow[convVideoResCase_Base.IdXzMajor].ToString().Trim(); //专业流水号
objvVideoResCase_BaseEN.MajorID = objRow[convVideoResCase_Base.MajorID] == DBNull.Value ? null : objRow[convVideoResCase_Base.MajorID].ToString().Trim(); //专业ID
objvVideoResCase_BaseEN.MajorName = objRow[convVideoResCase_Base.MajorName] == DBNull.Value ? null : objRow[convVideoResCase_Base.MajorName].ToString().Trim(); //专业名称
objvVideoResCase_BaseEN.CourseChapterId = objRow[convVideoResCase_Base.CourseChapterId] == DBNull.Value ? null : objRow[convVideoResCase_Base.CourseChapterId].ToString().Trim(); //课程章节ID
objvVideoResCase_BaseEN.CourseChapterName = objRow[convVideoResCase_Base.CourseChapterName] == DBNull.Value ? null : objRow[convVideoResCase_Base.CourseChapterName].ToString().Trim(); //课程章节名称
objvVideoResCase_BaseEN.ParentNodeID = objRow[convVideoResCase_Base.ParentNodeID] == DBNull.Value ? null : objRow[convVideoResCase_Base.ParentNodeID].ToString().Trim(); //父节点编号
objvVideoResCase_BaseEN.ParentNodeName = objRow[convVideoResCase_Base.ParentNodeName] == DBNull.Value ? null : objRow[convVideoResCase_Base.ParentNodeName].ToString().Trim(); //父节点名称
objvVideoResCase_BaseEN.ViewCount = objRow[convVideoResCase_Base.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase_Base.ViewCount].ToString().Trim()); //浏览量
objvVideoResCase_BaseEN.IsShow = TransNullToBool(objRow[convVideoResCase_Base.IsShow].ToString().Trim()); //是否启用
objvVideoResCase_BaseEN.DownloadNumber = objRow[convVideoResCase_Base.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase_Base.DownloadNumber].ToString().Trim()); //下载数目
objvVideoResCase_BaseEN.FileIntegration = objRow[convVideoResCase_Base.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase_Base.FileIntegration].ToString().Trim()); //文件积分
objvVideoResCase_BaseEN.LikeCount = objRow[convVideoResCase_Base.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoResCase_Base.LikeCount].ToString().Trim()); //资源喜欢数量
objvVideoResCase_BaseEN.CollectionCount = objRow[convVideoResCase_Base.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoResCase_Base.CollectionCount].ToString().Trim()); //收藏数量
objvVideoResCase_BaseEN.RecommendedDegreeId = objRow[convVideoResCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvVideoResCase_BaseEN.RecommendedDegreeName = objRow[convVideoResCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convVideoResCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvVideoResCase_BaseEN.ftpFileType = objRow[convVideoResCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convVideoResCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvVideoResCase_BaseEN.CourseId = objRow[convVideoResCase_Base.CourseId].ToString().Trim(); //课程Id
objvVideoResCase_BaseEN.CourseCode = objRow[convVideoResCase_Base.CourseCode] == DBNull.Value ? null : objRow[convVideoResCase_Base.CourseCode].ToString().Trim(); //课程代码
objvVideoResCase_BaseEN.CourseName = objRow[convVideoResCase_Base.CourseName] == DBNull.Value ? null : objRow[convVideoResCase_Base.CourseName].ToString().Trim(); //课程名称
objvVideoResCase_BaseEN.VideoUrl = objRow[convVideoResCase_Base.VideoUrl] == DBNull.Value ? null : objRow[convVideoResCase_Base.VideoUrl].ToString().Trim(); //视频Url
objvVideoResCase_BaseEN.VideoPath = objRow[convVideoResCase_Base.VideoPath] == DBNull.Value ? null : objRow[convVideoResCase_Base.VideoPath].ToString().Trim(); //视频目录
objvVideoResCase_BaseEN.ResErrMsg = objRow[convVideoResCase_Base.ResErrMsg] == DBNull.Value ? null : objRow[convVideoResCase_Base.ResErrMsg].ToString().Trim(); //资源错误信息
objvVideoResCase_BaseEN.Memo = objRow[convVideoResCase_Base.Memo] == DBNull.Value ? null : objRow[convVideoResCase_Base.Memo].ToString().Trim(); //备注
objvVideoResCase_BaseEN.OwnerName = objRow[convVideoResCase_Base.OwnerName] == DBNull.Value ? null : objRow[convVideoResCase_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvVideoResCase_BaseEN.OwnerNameWithId = objRow[convVideoResCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoResCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvVideoResCase_BaseEN.BrowseCount4Case = objRow[convVideoResCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvVideoResCase_BaseDA: GetObjLst)", objException.Message));
}
objvVideoResCase_BaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvVideoResCase_BaseEN);
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
public List<clsvVideoResCase_BaseEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvVideoResCase_BaseDA:GetObjLstByTabName)", objException.Message));
}
List<clsvVideoResCase_BaseEN> arrObjLst = new List<clsvVideoResCase_BaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCase_BaseDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoResCase_BaseEN objvVideoResCase_BaseEN = new clsvVideoResCase_BaseEN();
try
{
objvVideoResCase_BaseEN.IdVideoResCase = objRow[convVideoResCase_Base.IdVideoResCase].ToString().Trim(); //视频资源案例流水号
objvVideoResCase_BaseEN.VideoResCaseID = objRow[convVideoResCase_Base.VideoResCaseID].ToString().Trim(); //视频资源案例ID
objvVideoResCase_BaseEN.VideoResCaseName = objRow[convVideoResCase_Base.VideoResCaseName].ToString().Trim(); //视频资源案例名称
objvVideoResCase_BaseEN.VideoResCaseTheme = objRow[convVideoResCase_Base.VideoResCaseTheme] == DBNull.Value ? null : objRow[convVideoResCase_Base.VideoResCaseTheme].ToString().Trim(); //视频资源案例主题词
objvVideoResCase_BaseEN.IdVideoResCaseType = objRow[convVideoResCase_Base.IdVideoResCaseType].ToString().Trim(); //视频资源类型流水号
objvVideoResCase_BaseEN.VideoResCaseTypeName = objRow[convVideoResCase_Base.VideoResCaseTypeName] == DBNull.Value ? null : objRow[convVideoResCase_Base.VideoResCaseTypeName].ToString().Trim(); //视频资源案例类型名称
objvVideoResCase_BaseEN.VideoResCaseText = objRow[convVideoResCase_Base.VideoResCaseText] == DBNull.Value ? null : objRow[convVideoResCase_Base.VideoResCaseText].ToString().Trim(); //案例文本内容
objvVideoResCase_BaseEN.VideoResCaseDate = objRow[convVideoResCase_Base.VideoResCaseDate] == DBNull.Value ? null : objRow[convVideoResCase_Base.VideoResCaseDate].ToString().Trim(); //视频资源日期
objvVideoResCase_BaseEN.VideoResCaseTime = objRow[convVideoResCase_Base.VideoResCaseTime] == DBNull.Value ? null : objRow[convVideoResCase_Base.VideoResCaseTime].ToString().Trim(); //视频资源时间
objvVideoResCase_BaseEN.VideoResCaseDateIn = objRow[convVideoResCase_Base.VideoResCaseDateIn] == DBNull.Value ? null : objRow[convVideoResCase_Base.VideoResCaseDateIn].ToString().Trim(); //案例入库日期
objvVideoResCase_BaseEN.VideoResCaseTimeIn = objRow[convVideoResCase_Base.VideoResCaseTimeIn] == DBNull.Value ? null : objRow[convVideoResCase_Base.VideoResCaseTimeIn].ToString().Trim(); //案例入库时间
objvVideoResCase_BaseEN.OwnerId = objRow[convVideoResCase_Base.OwnerId].ToString().Trim(); //拥有者Id
objvVideoResCase_BaseEN.IdStudyLevel = objRow[convVideoResCase_Base.IdStudyLevel] == DBNull.Value ? null : objRow[convVideoResCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvVideoResCase_BaseEN.StudyLevelName = objRow[convVideoResCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convVideoResCase_Base.StudyLevelName].ToString().Trim(); //学段名称
objvVideoResCase_BaseEN.IdTeachingPlan = objRow[convVideoResCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convVideoResCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvVideoResCase_BaseEN.IdDiscipline = objRow[convVideoResCase_Base.IdDiscipline].ToString().Trim(); //学科流水号
objvVideoResCase_BaseEN.DisciplineID = objRow[convVideoResCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convVideoResCase_Base.DisciplineID].ToString().Trim(); //学科ID
objvVideoResCase_BaseEN.DisciplineName = objRow[convVideoResCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convVideoResCase_Base.DisciplineName].ToString().Trim(); //学科名称
objvVideoResCase_BaseEN.IdSenateGaugeVersion = objRow[convVideoResCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convVideoResCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvVideoResCase_BaseEN.senateGaugeVersionID = objRow[convVideoResCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoResCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoResCase_BaseEN.senateGaugeVersionName = objRow[convVideoResCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoResCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoResCase_BaseEN.senateGaugeVersionTtlScore = objRow[convVideoResCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convVideoResCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoResCase_BaseEN.VersionNo = objRow[convVideoResCase_Base.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase_Base.VersionNo].ToString().Trim()); //版本号
objvVideoResCase_BaseEN.IdTeachSkill = objRow[convVideoResCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvVideoResCase_BaseEN.TeachSkillID = objRow[convVideoResCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convVideoResCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID
objvVideoResCase_BaseEN.SkillTypeName = objRow[convVideoResCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convVideoResCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称
objvVideoResCase_BaseEN.TeachSkillName = objRow[convVideoResCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convVideoResCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称
objvVideoResCase_BaseEN.TeachSkillTheory = objRow[convVideoResCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convVideoResCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvVideoResCase_BaseEN.TeachSkillOperMethod = objRow[convVideoResCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convVideoResCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvVideoResCase_BaseEN.IdSkillType = objRow[convVideoResCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convVideoResCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号
objvVideoResCase_BaseEN.SkillTypeID = objRow[convVideoResCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convVideoResCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID
objvVideoResCase_BaseEN.CaseLevelId = objRow[convVideoResCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convVideoResCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvVideoResCase_BaseEN.CaseLevelName = objRow[convVideoResCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convVideoResCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvVideoResCase_BaseEN.DocFile = objRow[convVideoResCase_Base.DocFile] == DBNull.Value ? null : objRow[convVideoResCase_Base.DocFile].ToString().Trim(); //生成的Word文件名
objvVideoResCase_BaseEN.IsNeedGeneWord = TransNullToBool(objRow[convVideoResCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvVideoResCase_BaseEN.WordCreateDate = objRow[convVideoResCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convVideoResCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期
objvVideoResCase_BaseEN.IsVisible = TransNullToBool(objRow[convVideoResCase_Base.IsVisible].ToString().Trim()); //是否显示
objvVideoResCase_BaseEN.IsDualVideo = TransNullToBool(objRow[convVideoResCase_Base.IsDualVideo].ToString().Trim()); //是否双视频
objvVideoResCase_BaseEN.IdXzCollege = objRow[convVideoResCase_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoResCase_BaseEN.CollegeID = objRow[convVideoResCase_Base.CollegeID] == DBNull.Value ? null : objRow[convVideoResCase_Base.CollegeID].ToString().Trim(); //学院ID
objvVideoResCase_BaseEN.CollegeName = objRow[convVideoResCase_Base.CollegeName] == DBNull.Value ? null : objRow[convVideoResCase_Base.CollegeName].ToString().Trim(); //学院名称
objvVideoResCase_BaseEN.CollegeNameA = objRow[convVideoResCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convVideoResCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoResCase_BaseEN.IdXzMajor = objRow[convVideoResCase_Base.IdXzMajor].ToString().Trim(); //专业流水号
objvVideoResCase_BaseEN.MajorID = objRow[convVideoResCase_Base.MajorID] == DBNull.Value ? null : objRow[convVideoResCase_Base.MajorID].ToString().Trim(); //专业ID
objvVideoResCase_BaseEN.MajorName = objRow[convVideoResCase_Base.MajorName] == DBNull.Value ? null : objRow[convVideoResCase_Base.MajorName].ToString().Trim(); //专业名称
objvVideoResCase_BaseEN.CourseChapterId = objRow[convVideoResCase_Base.CourseChapterId] == DBNull.Value ? null : objRow[convVideoResCase_Base.CourseChapterId].ToString().Trim(); //课程章节ID
objvVideoResCase_BaseEN.CourseChapterName = objRow[convVideoResCase_Base.CourseChapterName] == DBNull.Value ? null : objRow[convVideoResCase_Base.CourseChapterName].ToString().Trim(); //课程章节名称
objvVideoResCase_BaseEN.ParentNodeID = objRow[convVideoResCase_Base.ParentNodeID] == DBNull.Value ? null : objRow[convVideoResCase_Base.ParentNodeID].ToString().Trim(); //父节点编号
objvVideoResCase_BaseEN.ParentNodeName = objRow[convVideoResCase_Base.ParentNodeName] == DBNull.Value ? null : objRow[convVideoResCase_Base.ParentNodeName].ToString().Trim(); //父节点名称
objvVideoResCase_BaseEN.ViewCount = objRow[convVideoResCase_Base.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase_Base.ViewCount].ToString().Trim()); //浏览量
objvVideoResCase_BaseEN.IsShow = TransNullToBool(objRow[convVideoResCase_Base.IsShow].ToString().Trim()); //是否启用
objvVideoResCase_BaseEN.DownloadNumber = objRow[convVideoResCase_Base.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase_Base.DownloadNumber].ToString().Trim()); //下载数目
objvVideoResCase_BaseEN.FileIntegration = objRow[convVideoResCase_Base.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase_Base.FileIntegration].ToString().Trim()); //文件积分
objvVideoResCase_BaseEN.LikeCount = objRow[convVideoResCase_Base.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoResCase_Base.LikeCount].ToString().Trim()); //资源喜欢数量
objvVideoResCase_BaseEN.CollectionCount = objRow[convVideoResCase_Base.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoResCase_Base.CollectionCount].ToString().Trim()); //收藏数量
objvVideoResCase_BaseEN.RecommendedDegreeId = objRow[convVideoResCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvVideoResCase_BaseEN.RecommendedDegreeName = objRow[convVideoResCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convVideoResCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvVideoResCase_BaseEN.ftpFileType = objRow[convVideoResCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convVideoResCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvVideoResCase_BaseEN.CourseId = objRow[convVideoResCase_Base.CourseId].ToString().Trim(); //课程Id
objvVideoResCase_BaseEN.CourseCode = objRow[convVideoResCase_Base.CourseCode] == DBNull.Value ? null : objRow[convVideoResCase_Base.CourseCode].ToString().Trim(); //课程代码
objvVideoResCase_BaseEN.CourseName = objRow[convVideoResCase_Base.CourseName] == DBNull.Value ? null : objRow[convVideoResCase_Base.CourseName].ToString().Trim(); //课程名称
objvVideoResCase_BaseEN.VideoUrl = objRow[convVideoResCase_Base.VideoUrl] == DBNull.Value ? null : objRow[convVideoResCase_Base.VideoUrl].ToString().Trim(); //视频Url
objvVideoResCase_BaseEN.VideoPath = objRow[convVideoResCase_Base.VideoPath] == DBNull.Value ? null : objRow[convVideoResCase_Base.VideoPath].ToString().Trim(); //视频目录
objvVideoResCase_BaseEN.ResErrMsg = objRow[convVideoResCase_Base.ResErrMsg] == DBNull.Value ? null : objRow[convVideoResCase_Base.ResErrMsg].ToString().Trim(); //资源错误信息
objvVideoResCase_BaseEN.Memo = objRow[convVideoResCase_Base.Memo] == DBNull.Value ? null : objRow[convVideoResCase_Base.Memo].ToString().Trim(); //备注
objvVideoResCase_BaseEN.OwnerName = objRow[convVideoResCase_Base.OwnerName] == DBNull.Value ? null : objRow[convVideoResCase_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvVideoResCase_BaseEN.OwnerNameWithId = objRow[convVideoResCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoResCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvVideoResCase_BaseEN.BrowseCount4Case = objRow[convVideoResCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvVideoResCase_BaseDA: GetObjLst)", objException.Message));
}
objvVideoResCase_BaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvVideoResCase_BaseEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvVideoResCase_BaseEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvVideoResCase_Base(ref clsvVideoResCase_BaseEN objvVideoResCase_BaseEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCase_BaseDA.GetSpecSQLObj();
strSQL = "Select * from vVideoResCase_Base where IdVideoResCase = " + "'"+ objvVideoResCase_BaseEN.IdVideoResCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvVideoResCase_BaseEN.IdVideoResCase = objDT.Rows[0][convVideoResCase_Base.IdVideoResCase].ToString().Trim(); //视频资源案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoResCase_BaseEN.VideoResCaseID = objDT.Rows[0][convVideoResCase_Base.VideoResCaseID].ToString().Trim(); //视频资源案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvVideoResCase_BaseEN.VideoResCaseName = objDT.Rows[0][convVideoResCase_Base.VideoResCaseName].ToString().Trim(); //视频资源案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvVideoResCase_BaseEN.VideoResCaseTheme = objDT.Rows[0][convVideoResCase_Base.VideoResCaseTheme].ToString().Trim(); //视频资源案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoResCase_BaseEN.IdVideoResCaseType = objDT.Rows[0][convVideoResCase_Base.IdVideoResCaseType].ToString().Trim(); //视频资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCase_BaseEN.VideoResCaseTypeName = objDT.Rows[0][convVideoResCase_Base.VideoResCaseTypeName].ToString().Trim(); //视频资源案例类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvVideoResCase_BaseEN.VideoResCaseText = objDT.Rows[0][convVideoResCase_Base.VideoResCaseText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objvVideoResCase_BaseEN.VideoResCaseDate = objDT.Rows[0][convVideoResCase_Base.VideoResCaseDate].ToString().Trim(); //视频资源日期(字段类型:char,字段长度:8,是否可空:True)
 objvVideoResCase_BaseEN.VideoResCaseTime = objDT.Rows[0][convVideoResCase_Base.VideoResCaseTime].ToString().Trim(); //视频资源时间(字段类型:char,字段长度:6,是否可空:True)
 objvVideoResCase_BaseEN.VideoResCaseDateIn = objDT.Rows[0][convVideoResCase_Base.VideoResCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvVideoResCase_BaseEN.VideoResCaseTimeIn = objDT.Rows[0][convVideoResCase_Base.VideoResCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvVideoResCase_BaseEN.OwnerId = objDT.Rows[0][convVideoResCase_Base.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvVideoResCase_BaseEN.IdStudyLevel = objDT.Rows[0][convVideoResCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvVideoResCase_BaseEN.StudyLevelName = objDT.Rows[0][convVideoResCase_Base.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvVideoResCase_BaseEN.IdTeachingPlan = objDT.Rows[0][convVideoResCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoResCase_BaseEN.IdDiscipline = objDT.Rows[0][convVideoResCase_Base.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCase_BaseEN.DisciplineID = objDT.Rows[0][convVideoResCase_Base.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCase_BaseEN.DisciplineName = objDT.Rows[0][convVideoResCase_Base.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvVideoResCase_BaseEN.IdSenateGaugeVersion = objDT.Rows[0][convVideoResCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCase_BaseEN.senateGaugeVersionID = objDT.Rows[0][convVideoResCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCase_BaseEN.senateGaugeVersionName = objDT.Rows[0][convVideoResCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoResCase_BaseEN.senateGaugeVersionTtlScore = TransNullToFloat(objDT.Rows[0][convVideoResCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvVideoResCase_BaseEN.VersionNo = TransNullToInt(objDT.Rows[0][convVideoResCase_Base.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvVideoResCase_BaseEN.IdTeachSkill = objDT.Rows[0][convVideoResCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoResCase_BaseEN.TeachSkillID = objDT.Rows[0][convVideoResCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID(字段类型:char,字段长度:8,是否可空:False)
 objvVideoResCase_BaseEN.SkillTypeName = objDT.Rows[0][convVideoResCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvVideoResCase_BaseEN.TeachSkillName = objDT.Rows[0][convVideoResCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvVideoResCase_BaseEN.TeachSkillTheory = objDT.Rows[0][convVideoResCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvVideoResCase_BaseEN.TeachSkillOperMethod = objDT.Rows[0][convVideoResCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法(字段类型:varchar,字段长度:2000,是否可空:True)
 objvVideoResCase_BaseEN.IdSkillType = objDT.Rows[0][convVideoResCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCase_BaseEN.SkillTypeID = objDT.Rows[0][convVideoResCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCase_BaseEN.CaseLevelId = objDT.Rows[0][convVideoResCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvVideoResCase_BaseEN.CaseLevelName = objDT.Rows[0][convVideoResCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvVideoResCase_BaseEN.DocFile = objDT.Rows[0][convVideoResCase_Base.DocFile].ToString().Trim(); //生成的Word文件名(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoResCase_BaseEN.IsNeedGeneWord = TransNullToBool(objDT.Rows[0][convVideoResCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word(字段类型:bit,字段长度:1,是否可空:True)
 objvVideoResCase_BaseEN.WordCreateDate = objDT.Rows[0][convVideoResCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objvVideoResCase_BaseEN.IsVisible = TransNullToBool(objDT.Rows[0][convVideoResCase_Base.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvVideoResCase_BaseEN.IsDualVideo = TransNullToBool(objDT.Rows[0][convVideoResCase_Base.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvVideoResCase_BaseEN.IdXzCollege = objDT.Rows[0][convVideoResCase_Base.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvVideoResCase_BaseEN.CollegeID = objDT.Rows[0][convVideoResCase_Base.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvVideoResCase_BaseEN.CollegeName = objDT.Rows[0][convVideoResCase_Base.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvVideoResCase_BaseEN.CollegeNameA = objDT.Rows[0][convVideoResCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvVideoResCase_BaseEN.IdXzMajor = objDT.Rows[0][convVideoResCase_Base.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoResCase_BaseEN.MajorID = objDT.Rows[0][convVideoResCase_Base.MajorID].ToString().Trim(); //专业ID(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCase_BaseEN.MajorName = objDT.Rows[0][convVideoResCase_Base.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvVideoResCase_BaseEN.CourseChapterId = objDT.Rows[0][convVideoResCase_Base.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objvVideoResCase_BaseEN.CourseChapterName = objDT.Rows[0][convVideoResCase_Base.CourseChapterName].ToString().Trim(); //课程章节名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvVideoResCase_BaseEN.ParentNodeID = objDT.Rows[0][convVideoResCase_Base.ParentNodeID].ToString().Trim(); //父节点编号(字段类型:varchar,字段长度:8,是否可空:True)
 objvVideoResCase_BaseEN.ParentNodeName = objDT.Rows[0][convVideoResCase_Base.ParentNodeName].ToString().Trim(); //父节点名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvVideoResCase_BaseEN.ViewCount = TransNullToInt(objDT.Rows[0][convVideoResCase_Base.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvVideoResCase_BaseEN.IsShow = TransNullToBool(objDT.Rows[0][convVideoResCase_Base.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objvVideoResCase_BaseEN.DownloadNumber = TransNullToInt(objDT.Rows[0][convVideoResCase_Base.DownloadNumber].ToString().Trim()); //下载数目(字段类型:int,字段长度:4,是否可空:True)
 objvVideoResCase_BaseEN.FileIntegration = TransNullToInt(objDT.Rows[0][convVideoResCase_Base.FileIntegration].ToString().Trim()); //文件积分(字段类型:int,字段长度:4,是否可空:True)
 objvVideoResCase_BaseEN.LikeCount = TransNullToInt(objDT.Rows[0][convVideoResCase_Base.LikeCount].ToString().Trim()); //资源喜欢数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvVideoResCase_BaseEN.CollectionCount = TransNullToInt(objDT.Rows[0][convVideoResCase_Base.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvVideoResCase_BaseEN.RecommendedDegreeId = objDT.Rows[0][convVideoResCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvVideoResCase_BaseEN.RecommendedDegreeName = objDT.Rows[0][convVideoResCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvVideoResCase_BaseEN.ftpFileType = objDT.Rows[0][convVideoResCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvVideoResCase_BaseEN.CourseId = objDT.Rows[0][convVideoResCase_Base.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvVideoResCase_BaseEN.CourseCode = objDT.Rows[0][convVideoResCase_Base.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvVideoResCase_BaseEN.CourseName = objDT.Rows[0][convVideoResCase_Base.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvVideoResCase_BaseEN.VideoUrl = objDT.Rows[0][convVideoResCase_Base.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objvVideoResCase_BaseEN.VideoPath = objDT.Rows[0][convVideoResCase_Base.VideoPath].ToString().Trim(); //视频目录(字段类型:varchar,字段长度:1000,是否可空:True)
 objvVideoResCase_BaseEN.ResErrMsg = objDT.Rows[0][convVideoResCase_Base.ResErrMsg].ToString().Trim(); //资源错误信息(字段类型:varchar,字段长度:30,是否可空:True)
 objvVideoResCase_BaseEN.Memo = objDT.Rows[0][convVideoResCase_Base.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvVideoResCase_BaseEN.OwnerName = objDT.Rows[0][convVideoResCase_Base.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvVideoResCase_BaseEN.OwnerNameWithId = objDT.Rows[0][convVideoResCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
 objvVideoResCase_BaseEN.BrowseCount4Case = TransNullToInt(objDT.Rows[0][convVideoResCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvVideoResCase_BaseDA: GetvVideoResCase_Base)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdVideoResCase">表关键字</param>
 /// <returns>表对象</returns>
public clsvVideoResCase_BaseEN GetObjByIdVideoResCase(string strIdVideoResCase)
{
CheckPrimaryKey(strIdVideoResCase);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCase_BaseDA.GetSpecSQLObj();
strSQL = "Select * from vVideoResCase_Base where IdVideoResCase = " + "'"+ strIdVideoResCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvVideoResCase_BaseEN objvVideoResCase_BaseEN = new clsvVideoResCase_BaseEN();
try
{
 objvVideoResCase_BaseEN.IdVideoResCase = objRow[convVideoResCase_Base.IdVideoResCase].ToString().Trim(); //视频资源案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoResCase_BaseEN.VideoResCaseID = objRow[convVideoResCase_Base.VideoResCaseID].ToString().Trim(); //视频资源案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvVideoResCase_BaseEN.VideoResCaseName = objRow[convVideoResCase_Base.VideoResCaseName].ToString().Trim(); //视频资源案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvVideoResCase_BaseEN.VideoResCaseTheme = objRow[convVideoResCase_Base.VideoResCaseTheme] == DBNull.Value ? null : objRow[convVideoResCase_Base.VideoResCaseTheme].ToString().Trim(); //视频资源案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoResCase_BaseEN.IdVideoResCaseType = objRow[convVideoResCase_Base.IdVideoResCaseType].ToString().Trim(); //视频资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCase_BaseEN.VideoResCaseTypeName = objRow[convVideoResCase_Base.VideoResCaseTypeName] == DBNull.Value ? null : objRow[convVideoResCase_Base.VideoResCaseTypeName].ToString().Trim(); //视频资源案例类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvVideoResCase_BaseEN.VideoResCaseText = objRow[convVideoResCase_Base.VideoResCaseText] == DBNull.Value ? null : objRow[convVideoResCase_Base.VideoResCaseText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objvVideoResCase_BaseEN.VideoResCaseDate = objRow[convVideoResCase_Base.VideoResCaseDate] == DBNull.Value ? null : objRow[convVideoResCase_Base.VideoResCaseDate].ToString().Trim(); //视频资源日期(字段类型:char,字段长度:8,是否可空:True)
 objvVideoResCase_BaseEN.VideoResCaseTime = objRow[convVideoResCase_Base.VideoResCaseTime] == DBNull.Value ? null : objRow[convVideoResCase_Base.VideoResCaseTime].ToString().Trim(); //视频资源时间(字段类型:char,字段长度:6,是否可空:True)
 objvVideoResCase_BaseEN.VideoResCaseDateIn = objRow[convVideoResCase_Base.VideoResCaseDateIn] == DBNull.Value ? null : objRow[convVideoResCase_Base.VideoResCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvVideoResCase_BaseEN.VideoResCaseTimeIn = objRow[convVideoResCase_Base.VideoResCaseTimeIn] == DBNull.Value ? null : objRow[convVideoResCase_Base.VideoResCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvVideoResCase_BaseEN.OwnerId = objRow[convVideoResCase_Base.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvVideoResCase_BaseEN.IdStudyLevel = objRow[convVideoResCase_Base.IdStudyLevel] == DBNull.Value ? null : objRow[convVideoResCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvVideoResCase_BaseEN.StudyLevelName = objRow[convVideoResCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convVideoResCase_Base.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvVideoResCase_BaseEN.IdTeachingPlan = objRow[convVideoResCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convVideoResCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoResCase_BaseEN.IdDiscipline = objRow[convVideoResCase_Base.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCase_BaseEN.DisciplineID = objRow[convVideoResCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convVideoResCase_Base.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCase_BaseEN.DisciplineName = objRow[convVideoResCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convVideoResCase_Base.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvVideoResCase_BaseEN.IdSenateGaugeVersion = objRow[convVideoResCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convVideoResCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCase_BaseEN.senateGaugeVersionID = objRow[convVideoResCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoResCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCase_BaseEN.senateGaugeVersionName = objRow[convVideoResCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoResCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoResCase_BaseEN.senateGaugeVersionTtlScore = objRow[convVideoResCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convVideoResCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvVideoResCase_BaseEN.VersionNo = objRow[convVideoResCase_Base.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoResCase_Base.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvVideoResCase_BaseEN.IdTeachSkill = objRow[convVideoResCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoResCase_BaseEN.TeachSkillID = objRow[convVideoResCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convVideoResCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID(字段类型:char,字段长度:8,是否可空:False)
 objvVideoResCase_BaseEN.SkillTypeName = objRow[convVideoResCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convVideoResCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvVideoResCase_BaseEN.TeachSkillName = objRow[convVideoResCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convVideoResCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvVideoResCase_BaseEN.TeachSkillTheory = objRow[convVideoResCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convVideoResCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvVideoResCase_BaseEN.TeachSkillOperMethod = objRow[convVideoResCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convVideoResCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法(字段类型:varchar,字段长度:2000,是否可空:True)
 objvVideoResCase_BaseEN.IdSkillType = objRow[convVideoResCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convVideoResCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCase_BaseEN.SkillTypeID = objRow[convVideoResCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convVideoResCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCase_BaseEN.CaseLevelId = objRow[convVideoResCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convVideoResCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvVideoResCase_BaseEN.CaseLevelName = objRow[convVideoResCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convVideoResCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvVideoResCase_BaseEN.DocFile = objRow[convVideoResCase_Base.DocFile] == DBNull.Value ? null : objRow[convVideoResCase_Base.DocFile].ToString().Trim(); //生成的Word文件名(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoResCase_BaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convVideoResCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word(字段类型:bit,字段长度:1,是否可空:True)
 objvVideoResCase_BaseEN.WordCreateDate = objRow[convVideoResCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convVideoResCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objvVideoResCase_BaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convVideoResCase_Base.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvVideoResCase_BaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convVideoResCase_Base.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvVideoResCase_BaseEN.IdXzCollege = objRow[convVideoResCase_Base.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvVideoResCase_BaseEN.CollegeID = objRow[convVideoResCase_Base.CollegeID] == DBNull.Value ? null : objRow[convVideoResCase_Base.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvVideoResCase_BaseEN.CollegeName = objRow[convVideoResCase_Base.CollegeName] == DBNull.Value ? null : objRow[convVideoResCase_Base.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvVideoResCase_BaseEN.CollegeNameA = objRow[convVideoResCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convVideoResCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvVideoResCase_BaseEN.IdXzMajor = objRow[convVideoResCase_Base.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoResCase_BaseEN.MajorID = objRow[convVideoResCase_Base.MajorID] == DBNull.Value ? null : objRow[convVideoResCase_Base.MajorID].ToString().Trim(); //专业ID(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCase_BaseEN.MajorName = objRow[convVideoResCase_Base.MajorName] == DBNull.Value ? null : objRow[convVideoResCase_Base.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvVideoResCase_BaseEN.CourseChapterId = objRow[convVideoResCase_Base.CourseChapterId] == DBNull.Value ? null : objRow[convVideoResCase_Base.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objvVideoResCase_BaseEN.CourseChapterName = objRow[convVideoResCase_Base.CourseChapterName] == DBNull.Value ? null : objRow[convVideoResCase_Base.CourseChapterName].ToString().Trim(); //课程章节名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvVideoResCase_BaseEN.ParentNodeID = objRow[convVideoResCase_Base.ParentNodeID] == DBNull.Value ? null : objRow[convVideoResCase_Base.ParentNodeID].ToString().Trim(); //父节点编号(字段类型:varchar,字段长度:8,是否可空:True)
 objvVideoResCase_BaseEN.ParentNodeName = objRow[convVideoResCase_Base.ParentNodeName] == DBNull.Value ? null : objRow[convVideoResCase_Base.ParentNodeName].ToString().Trim(); //父节点名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvVideoResCase_BaseEN.ViewCount = objRow[convVideoResCase_Base.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoResCase_Base.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvVideoResCase_BaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convVideoResCase_Base.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objvVideoResCase_BaseEN.DownloadNumber = objRow[convVideoResCase_Base.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoResCase_Base.DownloadNumber].ToString().Trim()); //下载数目(字段类型:int,字段长度:4,是否可空:True)
 objvVideoResCase_BaseEN.FileIntegration = objRow[convVideoResCase_Base.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoResCase_Base.FileIntegration].ToString().Trim()); //文件积分(字段类型:int,字段长度:4,是否可空:True)
 objvVideoResCase_BaseEN.LikeCount = objRow[convVideoResCase_Base.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoResCase_Base.LikeCount].ToString().Trim()); //资源喜欢数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvVideoResCase_BaseEN.CollectionCount = objRow[convVideoResCase_Base.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoResCase_Base.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvVideoResCase_BaseEN.RecommendedDegreeId = objRow[convVideoResCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvVideoResCase_BaseEN.RecommendedDegreeName = objRow[convVideoResCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convVideoResCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvVideoResCase_BaseEN.ftpFileType = objRow[convVideoResCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convVideoResCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvVideoResCase_BaseEN.CourseId = objRow[convVideoResCase_Base.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvVideoResCase_BaseEN.CourseCode = objRow[convVideoResCase_Base.CourseCode] == DBNull.Value ? null : objRow[convVideoResCase_Base.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvVideoResCase_BaseEN.CourseName = objRow[convVideoResCase_Base.CourseName] == DBNull.Value ? null : objRow[convVideoResCase_Base.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvVideoResCase_BaseEN.VideoUrl = objRow[convVideoResCase_Base.VideoUrl] == DBNull.Value ? null : objRow[convVideoResCase_Base.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objvVideoResCase_BaseEN.VideoPath = objRow[convVideoResCase_Base.VideoPath] == DBNull.Value ? null : objRow[convVideoResCase_Base.VideoPath].ToString().Trim(); //视频目录(字段类型:varchar,字段长度:1000,是否可空:True)
 objvVideoResCase_BaseEN.ResErrMsg = objRow[convVideoResCase_Base.ResErrMsg] == DBNull.Value ? null : objRow[convVideoResCase_Base.ResErrMsg].ToString().Trim(); //资源错误信息(字段类型:varchar,字段长度:30,是否可空:True)
 objvVideoResCase_BaseEN.Memo = objRow[convVideoResCase_Base.Memo] == DBNull.Value ? null : objRow[convVideoResCase_Base.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvVideoResCase_BaseEN.OwnerName = objRow[convVideoResCase_Base.OwnerName] == DBNull.Value ? null : objRow[convVideoResCase_Base.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvVideoResCase_BaseEN.OwnerNameWithId = objRow[convVideoResCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoResCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
 objvVideoResCase_BaseEN.BrowseCount4Case = objRow[convVideoResCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoResCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvVideoResCase_BaseDA: GetObjByIdVideoResCase)", objException.Message));
}
return objvVideoResCase_BaseEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvVideoResCase_BaseEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvVideoResCase_BaseDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCase_BaseDA.GetSpecSQLObj();
strSQL = "Select * from vVideoResCase_Base where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvVideoResCase_BaseEN objvVideoResCase_BaseEN = new clsvVideoResCase_BaseEN()
{
IdVideoResCase = objRow[convVideoResCase_Base.IdVideoResCase].ToString().Trim(), //视频资源案例流水号
VideoResCaseID = objRow[convVideoResCase_Base.VideoResCaseID].ToString().Trim(), //视频资源案例ID
VideoResCaseName = objRow[convVideoResCase_Base.VideoResCaseName].ToString().Trim(), //视频资源案例名称
VideoResCaseTheme = objRow[convVideoResCase_Base.VideoResCaseTheme] == DBNull.Value ? null : objRow[convVideoResCase_Base.VideoResCaseTheme].ToString().Trim(), //视频资源案例主题词
IdVideoResCaseType = objRow[convVideoResCase_Base.IdVideoResCaseType].ToString().Trim(), //视频资源类型流水号
VideoResCaseTypeName = objRow[convVideoResCase_Base.VideoResCaseTypeName] == DBNull.Value ? null : objRow[convVideoResCase_Base.VideoResCaseTypeName].ToString().Trim(), //视频资源案例类型名称
VideoResCaseText = objRow[convVideoResCase_Base.VideoResCaseText] == DBNull.Value ? null : objRow[convVideoResCase_Base.VideoResCaseText].ToString().Trim(), //案例文本内容
VideoResCaseDate = objRow[convVideoResCase_Base.VideoResCaseDate] == DBNull.Value ? null : objRow[convVideoResCase_Base.VideoResCaseDate].ToString().Trim(), //视频资源日期
VideoResCaseTime = objRow[convVideoResCase_Base.VideoResCaseTime] == DBNull.Value ? null : objRow[convVideoResCase_Base.VideoResCaseTime].ToString().Trim(), //视频资源时间
VideoResCaseDateIn = objRow[convVideoResCase_Base.VideoResCaseDateIn] == DBNull.Value ? null : objRow[convVideoResCase_Base.VideoResCaseDateIn].ToString().Trim(), //案例入库日期
VideoResCaseTimeIn = objRow[convVideoResCase_Base.VideoResCaseTimeIn] == DBNull.Value ? null : objRow[convVideoResCase_Base.VideoResCaseTimeIn].ToString().Trim(), //案例入库时间
OwnerId = objRow[convVideoResCase_Base.OwnerId].ToString().Trim(), //拥有者Id
IdStudyLevel = objRow[convVideoResCase_Base.IdStudyLevel] == DBNull.Value ? null : objRow[convVideoResCase_Base.IdStudyLevel].ToString().Trim(), //id_StudyLevel
StudyLevelName = objRow[convVideoResCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convVideoResCase_Base.StudyLevelName].ToString().Trim(), //学段名称
IdTeachingPlan = objRow[convVideoResCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convVideoResCase_Base.IdTeachingPlan].ToString().Trim(), //教案流水号
IdDiscipline = objRow[convVideoResCase_Base.IdDiscipline].ToString().Trim(), //学科流水号
DisciplineID = objRow[convVideoResCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convVideoResCase_Base.DisciplineID].ToString().Trim(), //学科ID
DisciplineName = objRow[convVideoResCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convVideoResCase_Base.DisciplineName].ToString().Trim(), //学科名称
IdSenateGaugeVersion = objRow[convVideoResCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convVideoResCase_Base.IdSenateGaugeVersion].ToString().Trim(), //评价量表版本流水号
senateGaugeVersionID = objRow[convVideoResCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoResCase_Base.senateGaugeVersionID].ToString().Trim(), //评价量表版本ID
senateGaugeVersionName = objRow[convVideoResCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoResCase_Base.senateGaugeVersionName].ToString().Trim(), //评价量表版本名称
senateGaugeVersionTtlScore = objRow[convVideoResCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convVideoResCase_Base.senateGaugeVersionTtlScore].ToString().Trim()), //评价量表版本总分
VersionNo = objRow[convVideoResCase_Base.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase_Base.VersionNo].ToString().Trim()), //版本号
IdTeachSkill = objRow[convVideoResCase_Base.IdTeachSkill].ToString().Trim(), //教学技能流水号
TeachSkillID = objRow[convVideoResCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convVideoResCase_Base.TeachSkillID].ToString().Trim(), //教学技能ID
SkillTypeName = objRow[convVideoResCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convVideoResCase_Base.SkillTypeName].ToString().Trim(), //技能类型名称
TeachSkillName = objRow[convVideoResCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convVideoResCase_Base.TeachSkillName].ToString().Trim(), //教学技能名称
TeachSkillTheory = objRow[convVideoResCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convVideoResCase_Base.TeachSkillTheory].ToString().Trim(), //教学技能理论阐述
TeachSkillOperMethod = objRow[convVideoResCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convVideoResCase_Base.TeachSkillOperMethod].ToString().Trim(), //教学技能实践操作方法
IdSkillType = objRow[convVideoResCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convVideoResCase_Base.IdSkillType].ToString().Trim(), //技能类型流水号
SkillTypeID = objRow[convVideoResCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convVideoResCase_Base.SkillTypeID].ToString().Trim(), //技能类型ID
CaseLevelId = objRow[convVideoResCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convVideoResCase_Base.CaseLevelId].ToString().Trim(), //课例等级Id
CaseLevelName = objRow[convVideoResCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convVideoResCase_Base.CaseLevelName].ToString().Trim(), //案例等级名称
DocFile = objRow[convVideoResCase_Base.DocFile] == DBNull.Value ? null : objRow[convVideoResCase_Base.DocFile].ToString().Trim(), //生成的Word文件名
IsNeedGeneWord = TransNullToBool(objRow[convVideoResCase_Base.IsNeedGeneWord].ToString().Trim()), //是否需要生成Word
WordCreateDate = objRow[convVideoResCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convVideoResCase_Base.WordCreateDate].ToString().Trim(), //Word生成日期
IsVisible = TransNullToBool(objRow[convVideoResCase_Base.IsVisible].ToString().Trim()), //是否显示
IsDualVideo = TransNullToBool(objRow[convVideoResCase_Base.IsDualVideo].ToString().Trim()), //是否双视频
IdXzCollege = objRow[convVideoResCase_Base.IdXzCollege].ToString().Trim(), //学院流水号
CollegeID = objRow[convVideoResCase_Base.CollegeID] == DBNull.Value ? null : objRow[convVideoResCase_Base.CollegeID].ToString().Trim(), //学院ID
CollegeName = objRow[convVideoResCase_Base.CollegeName] == DBNull.Value ? null : objRow[convVideoResCase_Base.CollegeName].ToString().Trim(), //学院名称
CollegeNameA = objRow[convVideoResCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convVideoResCase_Base.CollegeNameA].ToString().Trim(), //学院名称简写
IdXzMajor = objRow[convVideoResCase_Base.IdXzMajor].ToString().Trim(), //专业流水号
MajorID = objRow[convVideoResCase_Base.MajorID] == DBNull.Value ? null : objRow[convVideoResCase_Base.MajorID].ToString().Trim(), //专业ID
MajorName = objRow[convVideoResCase_Base.MajorName] == DBNull.Value ? null : objRow[convVideoResCase_Base.MajorName].ToString().Trim(), //专业名称
CourseChapterId = objRow[convVideoResCase_Base.CourseChapterId] == DBNull.Value ? null : objRow[convVideoResCase_Base.CourseChapterId].ToString().Trim(), //课程章节ID
CourseChapterName = objRow[convVideoResCase_Base.CourseChapterName] == DBNull.Value ? null : objRow[convVideoResCase_Base.CourseChapterName].ToString().Trim(), //课程章节名称
ParentNodeID = objRow[convVideoResCase_Base.ParentNodeID] == DBNull.Value ? null : objRow[convVideoResCase_Base.ParentNodeID].ToString().Trim(), //父节点编号
ParentNodeName = objRow[convVideoResCase_Base.ParentNodeName] == DBNull.Value ? null : objRow[convVideoResCase_Base.ParentNodeName].ToString().Trim(), //父节点名称
ViewCount = objRow[convVideoResCase_Base.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase_Base.ViewCount].ToString().Trim()), //浏览量
IsShow = TransNullToBool(objRow[convVideoResCase_Base.IsShow].ToString().Trim()), //是否启用
DownloadNumber = objRow[convVideoResCase_Base.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase_Base.DownloadNumber].ToString().Trim()), //下载数目
FileIntegration = objRow[convVideoResCase_Base.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase_Base.FileIntegration].ToString().Trim()), //文件积分
LikeCount = objRow[convVideoResCase_Base.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoResCase_Base.LikeCount].ToString().Trim()), //资源喜欢数量
CollectionCount = objRow[convVideoResCase_Base.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoResCase_Base.CollectionCount].ToString().Trim()), //收藏数量
RecommendedDegreeId = objRow[convVideoResCase_Base.RecommendedDegreeId].ToString().Trim(), //推荐度Id
RecommendedDegreeName = objRow[convVideoResCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convVideoResCase_Base.RecommendedDegreeName].ToString().Trim(), //推荐度名称
ftpFileType = objRow[convVideoResCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convVideoResCase_Base.ftpFileType].ToString().Trim(), //ftp文件类型
CourseId = objRow[convVideoResCase_Base.CourseId].ToString().Trim(), //课程Id
CourseCode = objRow[convVideoResCase_Base.CourseCode] == DBNull.Value ? null : objRow[convVideoResCase_Base.CourseCode].ToString().Trim(), //课程代码
CourseName = objRow[convVideoResCase_Base.CourseName] == DBNull.Value ? null : objRow[convVideoResCase_Base.CourseName].ToString().Trim(), //课程名称
VideoUrl = objRow[convVideoResCase_Base.VideoUrl] == DBNull.Value ? null : objRow[convVideoResCase_Base.VideoUrl].ToString().Trim(), //视频Url
VideoPath = objRow[convVideoResCase_Base.VideoPath] == DBNull.Value ? null : objRow[convVideoResCase_Base.VideoPath].ToString().Trim(), //视频目录
ResErrMsg = objRow[convVideoResCase_Base.ResErrMsg] == DBNull.Value ? null : objRow[convVideoResCase_Base.ResErrMsg].ToString().Trim(), //资源错误信息
Memo = objRow[convVideoResCase_Base.Memo] == DBNull.Value ? null : objRow[convVideoResCase_Base.Memo].ToString().Trim(), //备注
OwnerName = objRow[convVideoResCase_Base.OwnerName] == DBNull.Value ? null : objRow[convVideoResCase_Base.OwnerName].ToString().Trim(), //拥有者姓名
OwnerNameWithId = objRow[convVideoResCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoResCase_Base.OwnerNameWithId].ToString().Trim(), //拥有者名称附Id
BrowseCount4Case = objRow[convVideoResCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase_Base.BrowseCount4Case].ToString().Trim()) //课例浏览次数
};
objvVideoResCase_BaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvVideoResCase_BaseEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvVideoResCase_BaseDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvVideoResCase_BaseEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvVideoResCase_BaseEN objvVideoResCase_BaseEN = new clsvVideoResCase_BaseEN();
try
{
objvVideoResCase_BaseEN.IdVideoResCase = objRow[convVideoResCase_Base.IdVideoResCase].ToString().Trim(); //视频资源案例流水号
objvVideoResCase_BaseEN.VideoResCaseID = objRow[convVideoResCase_Base.VideoResCaseID].ToString().Trim(); //视频资源案例ID
objvVideoResCase_BaseEN.VideoResCaseName = objRow[convVideoResCase_Base.VideoResCaseName].ToString().Trim(); //视频资源案例名称
objvVideoResCase_BaseEN.VideoResCaseTheme = objRow[convVideoResCase_Base.VideoResCaseTheme] == DBNull.Value ? null : objRow[convVideoResCase_Base.VideoResCaseTheme].ToString().Trim(); //视频资源案例主题词
objvVideoResCase_BaseEN.IdVideoResCaseType = objRow[convVideoResCase_Base.IdVideoResCaseType].ToString().Trim(); //视频资源类型流水号
objvVideoResCase_BaseEN.VideoResCaseTypeName = objRow[convVideoResCase_Base.VideoResCaseTypeName] == DBNull.Value ? null : objRow[convVideoResCase_Base.VideoResCaseTypeName].ToString().Trim(); //视频资源案例类型名称
objvVideoResCase_BaseEN.VideoResCaseText = objRow[convVideoResCase_Base.VideoResCaseText] == DBNull.Value ? null : objRow[convVideoResCase_Base.VideoResCaseText].ToString().Trim(); //案例文本内容
objvVideoResCase_BaseEN.VideoResCaseDate = objRow[convVideoResCase_Base.VideoResCaseDate] == DBNull.Value ? null : objRow[convVideoResCase_Base.VideoResCaseDate].ToString().Trim(); //视频资源日期
objvVideoResCase_BaseEN.VideoResCaseTime = objRow[convVideoResCase_Base.VideoResCaseTime] == DBNull.Value ? null : objRow[convVideoResCase_Base.VideoResCaseTime].ToString().Trim(); //视频资源时间
objvVideoResCase_BaseEN.VideoResCaseDateIn = objRow[convVideoResCase_Base.VideoResCaseDateIn] == DBNull.Value ? null : objRow[convVideoResCase_Base.VideoResCaseDateIn].ToString().Trim(); //案例入库日期
objvVideoResCase_BaseEN.VideoResCaseTimeIn = objRow[convVideoResCase_Base.VideoResCaseTimeIn] == DBNull.Value ? null : objRow[convVideoResCase_Base.VideoResCaseTimeIn].ToString().Trim(); //案例入库时间
objvVideoResCase_BaseEN.OwnerId = objRow[convVideoResCase_Base.OwnerId].ToString().Trim(); //拥有者Id
objvVideoResCase_BaseEN.IdStudyLevel = objRow[convVideoResCase_Base.IdStudyLevel] == DBNull.Value ? null : objRow[convVideoResCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvVideoResCase_BaseEN.StudyLevelName = objRow[convVideoResCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convVideoResCase_Base.StudyLevelName].ToString().Trim(); //学段名称
objvVideoResCase_BaseEN.IdTeachingPlan = objRow[convVideoResCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convVideoResCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvVideoResCase_BaseEN.IdDiscipline = objRow[convVideoResCase_Base.IdDiscipline].ToString().Trim(); //学科流水号
objvVideoResCase_BaseEN.DisciplineID = objRow[convVideoResCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convVideoResCase_Base.DisciplineID].ToString().Trim(); //学科ID
objvVideoResCase_BaseEN.DisciplineName = objRow[convVideoResCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convVideoResCase_Base.DisciplineName].ToString().Trim(); //学科名称
objvVideoResCase_BaseEN.IdSenateGaugeVersion = objRow[convVideoResCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convVideoResCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvVideoResCase_BaseEN.senateGaugeVersionID = objRow[convVideoResCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoResCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoResCase_BaseEN.senateGaugeVersionName = objRow[convVideoResCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoResCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoResCase_BaseEN.senateGaugeVersionTtlScore = objRow[convVideoResCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convVideoResCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoResCase_BaseEN.VersionNo = objRow[convVideoResCase_Base.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase_Base.VersionNo].ToString().Trim()); //版本号
objvVideoResCase_BaseEN.IdTeachSkill = objRow[convVideoResCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvVideoResCase_BaseEN.TeachSkillID = objRow[convVideoResCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convVideoResCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID
objvVideoResCase_BaseEN.SkillTypeName = objRow[convVideoResCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convVideoResCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称
objvVideoResCase_BaseEN.TeachSkillName = objRow[convVideoResCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convVideoResCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称
objvVideoResCase_BaseEN.TeachSkillTheory = objRow[convVideoResCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convVideoResCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvVideoResCase_BaseEN.TeachSkillOperMethod = objRow[convVideoResCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convVideoResCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvVideoResCase_BaseEN.IdSkillType = objRow[convVideoResCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convVideoResCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号
objvVideoResCase_BaseEN.SkillTypeID = objRow[convVideoResCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convVideoResCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID
objvVideoResCase_BaseEN.CaseLevelId = objRow[convVideoResCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convVideoResCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvVideoResCase_BaseEN.CaseLevelName = objRow[convVideoResCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convVideoResCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvVideoResCase_BaseEN.DocFile = objRow[convVideoResCase_Base.DocFile] == DBNull.Value ? null : objRow[convVideoResCase_Base.DocFile].ToString().Trim(); //生成的Word文件名
objvVideoResCase_BaseEN.IsNeedGeneWord = TransNullToBool(objRow[convVideoResCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvVideoResCase_BaseEN.WordCreateDate = objRow[convVideoResCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convVideoResCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期
objvVideoResCase_BaseEN.IsVisible = TransNullToBool(objRow[convVideoResCase_Base.IsVisible].ToString().Trim()); //是否显示
objvVideoResCase_BaseEN.IsDualVideo = TransNullToBool(objRow[convVideoResCase_Base.IsDualVideo].ToString().Trim()); //是否双视频
objvVideoResCase_BaseEN.IdXzCollege = objRow[convVideoResCase_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoResCase_BaseEN.CollegeID = objRow[convVideoResCase_Base.CollegeID] == DBNull.Value ? null : objRow[convVideoResCase_Base.CollegeID].ToString().Trim(); //学院ID
objvVideoResCase_BaseEN.CollegeName = objRow[convVideoResCase_Base.CollegeName] == DBNull.Value ? null : objRow[convVideoResCase_Base.CollegeName].ToString().Trim(); //学院名称
objvVideoResCase_BaseEN.CollegeNameA = objRow[convVideoResCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convVideoResCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoResCase_BaseEN.IdXzMajor = objRow[convVideoResCase_Base.IdXzMajor].ToString().Trim(); //专业流水号
objvVideoResCase_BaseEN.MajorID = objRow[convVideoResCase_Base.MajorID] == DBNull.Value ? null : objRow[convVideoResCase_Base.MajorID].ToString().Trim(); //专业ID
objvVideoResCase_BaseEN.MajorName = objRow[convVideoResCase_Base.MajorName] == DBNull.Value ? null : objRow[convVideoResCase_Base.MajorName].ToString().Trim(); //专业名称
objvVideoResCase_BaseEN.CourseChapterId = objRow[convVideoResCase_Base.CourseChapterId] == DBNull.Value ? null : objRow[convVideoResCase_Base.CourseChapterId].ToString().Trim(); //课程章节ID
objvVideoResCase_BaseEN.CourseChapterName = objRow[convVideoResCase_Base.CourseChapterName] == DBNull.Value ? null : objRow[convVideoResCase_Base.CourseChapterName].ToString().Trim(); //课程章节名称
objvVideoResCase_BaseEN.ParentNodeID = objRow[convVideoResCase_Base.ParentNodeID] == DBNull.Value ? null : objRow[convVideoResCase_Base.ParentNodeID].ToString().Trim(); //父节点编号
objvVideoResCase_BaseEN.ParentNodeName = objRow[convVideoResCase_Base.ParentNodeName] == DBNull.Value ? null : objRow[convVideoResCase_Base.ParentNodeName].ToString().Trim(); //父节点名称
objvVideoResCase_BaseEN.ViewCount = objRow[convVideoResCase_Base.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase_Base.ViewCount].ToString().Trim()); //浏览量
objvVideoResCase_BaseEN.IsShow = TransNullToBool(objRow[convVideoResCase_Base.IsShow].ToString().Trim()); //是否启用
objvVideoResCase_BaseEN.DownloadNumber = objRow[convVideoResCase_Base.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase_Base.DownloadNumber].ToString().Trim()); //下载数目
objvVideoResCase_BaseEN.FileIntegration = objRow[convVideoResCase_Base.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase_Base.FileIntegration].ToString().Trim()); //文件积分
objvVideoResCase_BaseEN.LikeCount = objRow[convVideoResCase_Base.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoResCase_Base.LikeCount].ToString().Trim()); //资源喜欢数量
objvVideoResCase_BaseEN.CollectionCount = objRow[convVideoResCase_Base.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoResCase_Base.CollectionCount].ToString().Trim()); //收藏数量
objvVideoResCase_BaseEN.RecommendedDegreeId = objRow[convVideoResCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvVideoResCase_BaseEN.RecommendedDegreeName = objRow[convVideoResCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convVideoResCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvVideoResCase_BaseEN.ftpFileType = objRow[convVideoResCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convVideoResCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvVideoResCase_BaseEN.CourseId = objRow[convVideoResCase_Base.CourseId].ToString().Trim(); //课程Id
objvVideoResCase_BaseEN.CourseCode = objRow[convVideoResCase_Base.CourseCode] == DBNull.Value ? null : objRow[convVideoResCase_Base.CourseCode].ToString().Trim(); //课程代码
objvVideoResCase_BaseEN.CourseName = objRow[convVideoResCase_Base.CourseName] == DBNull.Value ? null : objRow[convVideoResCase_Base.CourseName].ToString().Trim(); //课程名称
objvVideoResCase_BaseEN.VideoUrl = objRow[convVideoResCase_Base.VideoUrl] == DBNull.Value ? null : objRow[convVideoResCase_Base.VideoUrl].ToString().Trim(); //视频Url
objvVideoResCase_BaseEN.VideoPath = objRow[convVideoResCase_Base.VideoPath] == DBNull.Value ? null : objRow[convVideoResCase_Base.VideoPath].ToString().Trim(); //视频目录
objvVideoResCase_BaseEN.ResErrMsg = objRow[convVideoResCase_Base.ResErrMsg] == DBNull.Value ? null : objRow[convVideoResCase_Base.ResErrMsg].ToString().Trim(); //资源错误信息
objvVideoResCase_BaseEN.Memo = objRow[convVideoResCase_Base.Memo] == DBNull.Value ? null : objRow[convVideoResCase_Base.Memo].ToString().Trim(); //备注
objvVideoResCase_BaseEN.OwnerName = objRow[convVideoResCase_Base.OwnerName] == DBNull.Value ? null : objRow[convVideoResCase_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvVideoResCase_BaseEN.OwnerNameWithId = objRow[convVideoResCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoResCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvVideoResCase_BaseEN.BrowseCount4Case = objRow[convVideoResCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvVideoResCase_BaseDA: GetObjByDataRowvVideoResCase_Base)", objException.Message));
}
objvVideoResCase_BaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvVideoResCase_BaseEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvVideoResCase_BaseEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvVideoResCase_BaseEN objvVideoResCase_BaseEN = new clsvVideoResCase_BaseEN();
try
{
objvVideoResCase_BaseEN.IdVideoResCase = objRow[convVideoResCase_Base.IdVideoResCase].ToString().Trim(); //视频资源案例流水号
objvVideoResCase_BaseEN.VideoResCaseID = objRow[convVideoResCase_Base.VideoResCaseID].ToString().Trim(); //视频资源案例ID
objvVideoResCase_BaseEN.VideoResCaseName = objRow[convVideoResCase_Base.VideoResCaseName].ToString().Trim(); //视频资源案例名称
objvVideoResCase_BaseEN.VideoResCaseTheme = objRow[convVideoResCase_Base.VideoResCaseTheme] == DBNull.Value ? null : objRow[convVideoResCase_Base.VideoResCaseTheme].ToString().Trim(); //视频资源案例主题词
objvVideoResCase_BaseEN.IdVideoResCaseType = objRow[convVideoResCase_Base.IdVideoResCaseType].ToString().Trim(); //视频资源类型流水号
objvVideoResCase_BaseEN.VideoResCaseTypeName = objRow[convVideoResCase_Base.VideoResCaseTypeName] == DBNull.Value ? null : objRow[convVideoResCase_Base.VideoResCaseTypeName].ToString().Trim(); //视频资源案例类型名称
objvVideoResCase_BaseEN.VideoResCaseText = objRow[convVideoResCase_Base.VideoResCaseText] == DBNull.Value ? null : objRow[convVideoResCase_Base.VideoResCaseText].ToString().Trim(); //案例文本内容
objvVideoResCase_BaseEN.VideoResCaseDate = objRow[convVideoResCase_Base.VideoResCaseDate] == DBNull.Value ? null : objRow[convVideoResCase_Base.VideoResCaseDate].ToString().Trim(); //视频资源日期
objvVideoResCase_BaseEN.VideoResCaseTime = objRow[convVideoResCase_Base.VideoResCaseTime] == DBNull.Value ? null : objRow[convVideoResCase_Base.VideoResCaseTime].ToString().Trim(); //视频资源时间
objvVideoResCase_BaseEN.VideoResCaseDateIn = objRow[convVideoResCase_Base.VideoResCaseDateIn] == DBNull.Value ? null : objRow[convVideoResCase_Base.VideoResCaseDateIn].ToString().Trim(); //案例入库日期
objvVideoResCase_BaseEN.VideoResCaseTimeIn = objRow[convVideoResCase_Base.VideoResCaseTimeIn] == DBNull.Value ? null : objRow[convVideoResCase_Base.VideoResCaseTimeIn].ToString().Trim(); //案例入库时间
objvVideoResCase_BaseEN.OwnerId = objRow[convVideoResCase_Base.OwnerId].ToString().Trim(); //拥有者Id
objvVideoResCase_BaseEN.IdStudyLevel = objRow[convVideoResCase_Base.IdStudyLevel] == DBNull.Value ? null : objRow[convVideoResCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvVideoResCase_BaseEN.StudyLevelName = objRow[convVideoResCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convVideoResCase_Base.StudyLevelName].ToString().Trim(); //学段名称
objvVideoResCase_BaseEN.IdTeachingPlan = objRow[convVideoResCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convVideoResCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvVideoResCase_BaseEN.IdDiscipline = objRow[convVideoResCase_Base.IdDiscipline].ToString().Trim(); //学科流水号
objvVideoResCase_BaseEN.DisciplineID = objRow[convVideoResCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convVideoResCase_Base.DisciplineID].ToString().Trim(); //学科ID
objvVideoResCase_BaseEN.DisciplineName = objRow[convVideoResCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convVideoResCase_Base.DisciplineName].ToString().Trim(); //学科名称
objvVideoResCase_BaseEN.IdSenateGaugeVersion = objRow[convVideoResCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convVideoResCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvVideoResCase_BaseEN.senateGaugeVersionID = objRow[convVideoResCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoResCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoResCase_BaseEN.senateGaugeVersionName = objRow[convVideoResCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoResCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoResCase_BaseEN.senateGaugeVersionTtlScore = objRow[convVideoResCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convVideoResCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoResCase_BaseEN.VersionNo = objRow[convVideoResCase_Base.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase_Base.VersionNo].ToString().Trim()); //版本号
objvVideoResCase_BaseEN.IdTeachSkill = objRow[convVideoResCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvVideoResCase_BaseEN.TeachSkillID = objRow[convVideoResCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convVideoResCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID
objvVideoResCase_BaseEN.SkillTypeName = objRow[convVideoResCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convVideoResCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称
objvVideoResCase_BaseEN.TeachSkillName = objRow[convVideoResCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convVideoResCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称
objvVideoResCase_BaseEN.TeachSkillTheory = objRow[convVideoResCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convVideoResCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvVideoResCase_BaseEN.TeachSkillOperMethod = objRow[convVideoResCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convVideoResCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvVideoResCase_BaseEN.IdSkillType = objRow[convVideoResCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convVideoResCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号
objvVideoResCase_BaseEN.SkillTypeID = objRow[convVideoResCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convVideoResCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID
objvVideoResCase_BaseEN.CaseLevelId = objRow[convVideoResCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convVideoResCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvVideoResCase_BaseEN.CaseLevelName = objRow[convVideoResCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convVideoResCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvVideoResCase_BaseEN.DocFile = objRow[convVideoResCase_Base.DocFile] == DBNull.Value ? null : objRow[convVideoResCase_Base.DocFile].ToString().Trim(); //生成的Word文件名
objvVideoResCase_BaseEN.IsNeedGeneWord = TransNullToBool(objRow[convVideoResCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvVideoResCase_BaseEN.WordCreateDate = objRow[convVideoResCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convVideoResCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期
objvVideoResCase_BaseEN.IsVisible = TransNullToBool(objRow[convVideoResCase_Base.IsVisible].ToString().Trim()); //是否显示
objvVideoResCase_BaseEN.IsDualVideo = TransNullToBool(objRow[convVideoResCase_Base.IsDualVideo].ToString().Trim()); //是否双视频
objvVideoResCase_BaseEN.IdXzCollege = objRow[convVideoResCase_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoResCase_BaseEN.CollegeID = objRow[convVideoResCase_Base.CollegeID] == DBNull.Value ? null : objRow[convVideoResCase_Base.CollegeID].ToString().Trim(); //学院ID
objvVideoResCase_BaseEN.CollegeName = objRow[convVideoResCase_Base.CollegeName] == DBNull.Value ? null : objRow[convVideoResCase_Base.CollegeName].ToString().Trim(); //学院名称
objvVideoResCase_BaseEN.CollegeNameA = objRow[convVideoResCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convVideoResCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoResCase_BaseEN.IdXzMajor = objRow[convVideoResCase_Base.IdXzMajor].ToString().Trim(); //专业流水号
objvVideoResCase_BaseEN.MajorID = objRow[convVideoResCase_Base.MajorID] == DBNull.Value ? null : objRow[convVideoResCase_Base.MajorID].ToString().Trim(); //专业ID
objvVideoResCase_BaseEN.MajorName = objRow[convVideoResCase_Base.MajorName] == DBNull.Value ? null : objRow[convVideoResCase_Base.MajorName].ToString().Trim(); //专业名称
objvVideoResCase_BaseEN.CourseChapterId = objRow[convVideoResCase_Base.CourseChapterId] == DBNull.Value ? null : objRow[convVideoResCase_Base.CourseChapterId].ToString().Trim(); //课程章节ID
objvVideoResCase_BaseEN.CourseChapterName = objRow[convVideoResCase_Base.CourseChapterName] == DBNull.Value ? null : objRow[convVideoResCase_Base.CourseChapterName].ToString().Trim(); //课程章节名称
objvVideoResCase_BaseEN.ParentNodeID = objRow[convVideoResCase_Base.ParentNodeID] == DBNull.Value ? null : objRow[convVideoResCase_Base.ParentNodeID].ToString().Trim(); //父节点编号
objvVideoResCase_BaseEN.ParentNodeName = objRow[convVideoResCase_Base.ParentNodeName] == DBNull.Value ? null : objRow[convVideoResCase_Base.ParentNodeName].ToString().Trim(); //父节点名称
objvVideoResCase_BaseEN.ViewCount = objRow[convVideoResCase_Base.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase_Base.ViewCount].ToString().Trim()); //浏览量
objvVideoResCase_BaseEN.IsShow = TransNullToBool(objRow[convVideoResCase_Base.IsShow].ToString().Trim()); //是否启用
objvVideoResCase_BaseEN.DownloadNumber = objRow[convVideoResCase_Base.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase_Base.DownloadNumber].ToString().Trim()); //下载数目
objvVideoResCase_BaseEN.FileIntegration = objRow[convVideoResCase_Base.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase_Base.FileIntegration].ToString().Trim()); //文件积分
objvVideoResCase_BaseEN.LikeCount = objRow[convVideoResCase_Base.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoResCase_Base.LikeCount].ToString().Trim()); //资源喜欢数量
objvVideoResCase_BaseEN.CollectionCount = objRow[convVideoResCase_Base.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convVideoResCase_Base.CollectionCount].ToString().Trim()); //收藏数量
objvVideoResCase_BaseEN.RecommendedDegreeId = objRow[convVideoResCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvVideoResCase_BaseEN.RecommendedDegreeName = objRow[convVideoResCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convVideoResCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvVideoResCase_BaseEN.ftpFileType = objRow[convVideoResCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convVideoResCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvVideoResCase_BaseEN.CourseId = objRow[convVideoResCase_Base.CourseId].ToString().Trim(); //课程Id
objvVideoResCase_BaseEN.CourseCode = objRow[convVideoResCase_Base.CourseCode] == DBNull.Value ? null : objRow[convVideoResCase_Base.CourseCode].ToString().Trim(); //课程代码
objvVideoResCase_BaseEN.CourseName = objRow[convVideoResCase_Base.CourseName] == DBNull.Value ? null : objRow[convVideoResCase_Base.CourseName].ToString().Trim(); //课程名称
objvVideoResCase_BaseEN.VideoUrl = objRow[convVideoResCase_Base.VideoUrl] == DBNull.Value ? null : objRow[convVideoResCase_Base.VideoUrl].ToString().Trim(); //视频Url
objvVideoResCase_BaseEN.VideoPath = objRow[convVideoResCase_Base.VideoPath] == DBNull.Value ? null : objRow[convVideoResCase_Base.VideoPath].ToString().Trim(); //视频目录
objvVideoResCase_BaseEN.ResErrMsg = objRow[convVideoResCase_Base.ResErrMsg] == DBNull.Value ? null : objRow[convVideoResCase_Base.ResErrMsg].ToString().Trim(); //资源错误信息
objvVideoResCase_BaseEN.Memo = objRow[convVideoResCase_Base.Memo] == DBNull.Value ? null : objRow[convVideoResCase_Base.Memo].ToString().Trim(); //备注
objvVideoResCase_BaseEN.OwnerName = objRow[convVideoResCase_Base.OwnerName] == DBNull.Value ? null : objRow[convVideoResCase_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvVideoResCase_BaseEN.OwnerNameWithId = objRow[convVideoResCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoResCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvVideoResCase_BaseEN.BrowseCount4Case = objRow[convVideoResCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvVideoResCase_BaseDA: GetObjByDataRow)", objException.Message));
}
objvVideoResCase_BaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvVideoResCase_BaseEN;
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
objSQL = clsvVideoResCase_BaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvVideoResCase_BaseEN._CurrTabName, convVideoResCase_Base.IdVideoResCase, 8, "");
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
objSQL = clsvVideoResCase_BaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvVideoResCase_BaseEN._CurrTabName, convVideoResCase_Base.IdVideoResCase, 8, strPrefix);
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
 objSQL = clsvVideoResCase_BaseDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdVideoResCase from vVideoResCase_Base where " + strCondition;
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
 objSQL = clsvVideoResCase_BaseDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdVideoResCase from vVideoResCase_Base where " + strCondition;
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
 objSQL = clsvVideoResCase_BaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vVideoResCase_Base", "IdVideoResCase = " + "'"+ strIdVideoResCase+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvVideoResCase_BaseDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCase_BaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vVideoResCase_Base", strCondition))
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
objSQL = clsvVideoResCase_BaseDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vVideoResCase_Base");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvVideoResCase_BaseENS">源对象</param>
 /// <param name = "objvVideoResCase_BaseENT">目标对象</param>
public void CopyTo(clsvVideoResCase_BaseEN objvVideoResCase_BaseENS, clsvVideoResCase_BaseEN objvVideoResCase_BaseENT)
{
objvVideoResCase_BaseENT.IdVideoResCase = objvVideoResCase_BaseENS.IdVideoResCase; //视频资源案例流水号
objvVideoResCase_BaseENT.VideoResCaseID = objvVideoResCase_BaseENS.VideoResCaseID; //视频资源案例ID
objvVideoResCase_BaseENT.VideoResCaseName = objvVideoResCase_BaseENS.VideoResCaseName; //视频资源案例名称
objvVideoResCase_BaseENT.VideoResCaseTheme = objvVideoResCase_BaseENS.VideoResCaseTheme; //视频资源案例主题词
objvVideoResCase_BaseENT.IdVideoResCaseType = objvVideoResCase_BaseENS.IdVideoResCaseType; //视频资源类型流水号
objvVideoResCase_BaseENT.VideoResCaseTypeName = objvVideoResCase_BaseENS.VideoResCaseTypeName; //视频资源案例类型名称
objvVideoResCase_BaseENT.VideoResCaseText = objvVideoResCase_BaseENS.VideoResCaseText; //案例文本内容
objvVideoResCase_BaseENT.VideoResCaseDate = objvVideoResCase_BaseENS.VideoResCaseDate; //视频资源日期
objvVideoResCase_BaseENT.VideoResCaseTime = objvVideoResCase_BaseENS.VideoResCaseTime; //视频资源时间
objvVideoResCase_BaseENT.VideoResCaseDateIn = objvVideoResCase_BaseENS.VideoResCaseDateIn; //案例入库日期
objvVideoResCase_BaseENT.VideoResCaseTimeIn = objvVideoResCase_BaseENS.VideoResCaseTimeIn; //案例入库时间
objvVideoResCase_BaseENT.OwnerId = objvVideoResCase_BaseENS.OwnerId; //拥有者Id
objvVideoResCase_BaseENT.IdStudyLevel = objvVideoResCase_BaseENS.IdStudyLevel; //id_StudyLevel
objvVideoResCase_BaseENT.StudyLevelName = objvVideoResCase_BaseENS.StudyLevelName; //学段名称
objvVideoResCase_BaseENT.IdTeachingPlan = objvVideoResCase_BaseENS.IdTeachingPlan; //教案流水号
objvVideoResCase_BaseENT.IdDiscipline = objvVideoResCase_BaseENS.IdDiscipline; //学科流水号
objvVideoResCase_BaseENT.DisciplineID = objvVideoResCase_BaseENS.DisciplineID; //学科ID
objvVideoResCase_BaseENT.DisciplineName = objvVideoResCase_BaseENS.DisciplineName; //学科名称
objvVideoResCase_BaseENT.IdSenateGaugeVersion = objvVideoResCase_BaseENS.IdSenateGaugeVersion; //评价量表版本流水号
objvVideoResCase_BaseENT.senateGaugeVersionID = objvVideoResCase_BaseENS.senateGaugeVersionID; //评价量表版本ID
objvVideoResCase_BaseENT.senateGaugeVersionName = objvVideoResCase_BaseENS.senateGaugeVersionName; //评价量表版本名称
objvVideoResCase_BaseENT.senateGaugeVersionTtlScore = objvVideoResCase_BaseENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvVideoResCase_BaseENT.VersionNo = objvVideoResCase_BaseENS.VersionNo; //版本号
objvVideoResCase_BaseENT.IdTeachSkill = objvVideoResCase_BaseENS.IdTeachSkill; //教学技能流水号
objvVideoResCase_BaseENT.TeachSkillID = objvVideoResCase_BaseENS.TeachSkillID; //教学技能ID
objvVideoResCase_BaseENT.SkillTypeName = objvVideoResCase_BaseENS.SkillTypeName; //技能类型名称
objvVideoResCase_BaseENT.TeachSkillName = objvVideoResCase_BaseENS.TeachSkillName; //教学技能名称
objvVideoResCase_BaseENT.TeachSkillTheory = objvVideoResCase_BaseENS.TeachSkillTheory; //教学技能理论阐述
objvVideoResCase_BaseENT.TeachSkillOperMethod = objvVideoResCase_BaseENS.TeachSkillOperMethod; //教学技能实践操作方法
objvVideoResCase_BaseENT.IdSkillType = objvVideoResCase_BaseENS.IdSkillType; //技能类型流水号
objvVideoResCase_BaseENT.SkillTypeID = objvVideoResCase_BaseENS.SkillTypeID; //技能类型ID
objvVideoResCase_BaseENT.CaseLevelId = objvVideoResCase_BaseENS.CaseLevelId; //课例等级Id
objvVideoResCase_BaseENT.CaseLevelName = objvVideoResCase_BaseENS.CaseLevelName; //案例等级名称
objvVideoResCase_BaseENT.DocFile = objvVideoResCase_BaseENS.DocFile; //生成的Word文件名
objvVideoResCase_BaseENT.IsNeedGeneWord = objvVideoResCase_BaseENS.IsNeedGeneWord; //是否需要生成Word
objvVideoResCase_BaseENT.WordCreateDate = objvVideoResCase_BaseENS.WordCreateDate; //Word生成日期
objvVideoResCase_BaseENT.IsVisible = objvVideoResCase_BaseENS.IsVisible; //是否显示
objvVideoResCase_BaseENT.IsDualVideo = objvVideoResCase_BaseENS.IsDualVideo; //是否双视频
objvVideoResCase_BaseENT.IdXzCollege = objvVideoResCase_BaseENS.IdXzCollege; //学院流水号
objvVideoResCase_BaseENT.CollegeID = objvVideoResCase_BaseENS.CollegeID; //学院ID
objvVideoResCase_BaseENT.CollegeName = objvVideoResCase_BaseENS.CollegeName; //学院名称
objvVideoResCase_BaseENT.CollegeNameA = objvVideoResCase_BaseENS.CollegeNameA; //学院名称简写
objvVideoResCase_BaseENT.IdXzMajor = objvVideoResCase_BaseENS.IdXzMajor; //专业流水号
objvVideoResCase_BaseENT.MajorID = objvVideoResCase_BaseENS.MajorID; //专业ID
objvVideoResCase_BaseENT.MajorName = objvVideoResCase_BaseENS.MajorName; //专业名称
objvVideoResCase_BaseENT.CourseChapterId = objvVideoResCase_BaseENS.CourseChapterId; //课程章节ID
objvVideoResCase_BaseENT.CourseChapterName = objvVideoResCase_BaseENS.CourseChapterName; //课程章节名称
objvVideoResCase_BaseENT.ParentNodeID = objvVideoResCase_BaseENS.ParentNodeID; //父节点编号
objvVideoResCase_BaseENT.ParentNodeName = objvVideoResCase_BaseENS.ParentNodeName; //父节点名称
objvVideoResCase_BaseENT.ViewCount = objvVideoResCase_BaseENS.ViewCount; //浏览量
objvVideoResCase_BaseENT.IsShow = objvVideoResCase_BaseENS.IsShow; //是否启用
objvVideoResCase_BaseENT.DownloadNumber = objvVideoResCase_BaseENS.DownloadNumber; //下载数目
objvVideoResCase_BaseENT.FileIntegration = objvVideoResCase_BaseENS.FileIntegration; //文件积分
objvVideoResCase_BaseENT.LikeCount = objvVideoResCase_BaseENS.LikeCount; //资源喜欢数量
objvVideoResCase_BaseENT.CollectionCount = objvVideoResCase_BaseENS.CollectionCount; //收藏数量
objvVideoResCase_BaseENT.RecommendedDegreeId = objvVideoResCase_BaseENS.RecommendedDegreeId; //推荐度Id
objvVideoResCase_BaseENT.RecommendedDegreeName = objvVideoResCase_BaseENS.RecommendedDegreeName; //推荐度名称
objvVideoResCase_BaseENT.ftpFileType = objvVideoResCase_BaseENS.ftpFileType; //ftp文件类型
objvVideoResCase_BaseENT.CourseId = objvVideoResCase_BaseENS.CourseId; //课程Id
objvVideoResCase_BaseENT.CourseCode = objvVideoResCase_BaseENS.CourseCode; //课程代码
objvVideoResCase_BaseENT.CourseName = objvVideoResCase_BaseENS.CourseName; //课程名称
objvVideoResCase_BaseENT.VideoUrl = objvVideoResCase_BaseENS.VideoUrl; //视频Url
objvVideoResCase_BaseENT.VideoPath = objvVideoResCase_BaseENS.VideoPath; //视频目录
objvVideoResCase_BaseENT.ResErrMsg = objvVideoResCase_BaseENS.ResErrMsg; //资源错误信息
objvVideoResCase_BaseENT.Memo = objvVideoResCase_BaseENS.Memo; //备注
objvVideoResCase_BaseENT.OwnerName = objvVideoResCase_BaseENS.OwnerName; //拥有者姓名
objvVideoResCase_BaseENT.OwnerNameWithId = objvVideoResCase_BaseENS.OwnerNameWithId; //拥有者名称附Id
objvVideoResCase_BaseENT.BrowseCount4Case = objvVideoResCase_BaseENS.BrowseCount4Case; //课例浏览次数
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvVideoResCase_BaseEN objvVideoResCase_BaseEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvVideoResCase_BaseEN.IdVideoResCase, 8, convVideoResCase_Base.IdVideoResCase);
clsCheckSql.CheckFieldLen(objvVideoResCase_BaseEN.VideoResCaseID, 8, convVideoResCase_Base.VideoResCaseID);
clsCheckSql.CheckFieldLen(objvVideoResCase_BaseEN.VideoResCaseName, 100, convVideoResCase_Base.VideoResCaseName);
clsCheckSql.CheckFieldLen(objvVideoResCase_BaseEN.VideoResCaseTheme, 200, convVideoResCase_Base.VideoResCaseTheme);
clsCheckSql.CheckFieldLen(objvVideoResCase_BaseEN.IdVideoResCaseType, 4, convVideoResCase_Base.IdVideoResCaseType);
clsCheckSql.CheckFieldLen(objvVideoResCase_BaseEN.VideoResCaseTypeName, 30, convVideoResCase_Base.VideoResCaseTypeName);
clsCheckSql.CheckFieldLen(objvVideoResCase_BaseEN.VideoResCaseText, 8000, convVideoResCase_Base.VideoResCaseText);
clsCheckSql.CheckFieldLen(objvVideoResCase_BaseEN.VideoResCaseDate, 8, convVideoResCase_Base.VideoResCaseDate);
clsCheckSql.CheckFieldLen(objvVideoResCase_BaseEN.VideoResCaseTime, 6, convVideoResCase_Base.VideoResCaseTime);
clsCheckSql.CheckFieldLen(objvVideoResCase_BaseEN.VideoResCaseDateIn, 8, convVideoResCase_Base.VideoResCaseDateIn);
clsCheckSql.CheckFieldLen(objvVideoResCase_BaseEN.VideoResCaseTimeIn, 6, convVideoResCase_Base.VideoResCaseTimeIn);
clsCheckSql.CheckFieldLen(objvVideoResCase_BaseEN.OwnerId, 20, convVideoResCase_Base.OwnerId);
clsCheckSql.CheckFieldLen(objvVideoResCase_BaseEN.IdStudyLevel, 4, convVideoResCase_Base.IdStudyLevel);
clsCheckSql.CheckFieldLen(objvVideoResCase_BaseEN.StudyLevelName, 50, convVideoResCase_Base.StudyLevelName);
clsCheckSql.CheckFieldLen(objvVideoResCase_BaseEN.IdTeachingPlan, 8, convVideoResCase_Base.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objvVideoResCase_BaseEN.IdDiscipline, 4, convVideoResCase_Base.IdDiscipline);
clsCheckSql.CheckFieldLen(objvVideoResCase_BaseEN.DisciplineID, 4, convVideoResCase_Base.DisciplineID);
clsCheckSql.CheckFieldLen(objvVideoResCase_BaseEN.DisciplineName, 50, convVideoResCase_Base.DisciplineName);
clsCheckSql.CheckFieldLen(objvVideoResCase_BaseEN.IdSenateGaugeVersion, 4, convVideoResCase_Base.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objvVideoResCase_BaseEN.senateGaugeVersionID, 4, convVideoResCase_Base.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(objvVideoResCase_BaseEN.senateGaugeVersionName, 200, convVideoResCase_Base.senateGaugeVersionName);
clsCheckSql.CheckFieldLen(objvVideoResCase_BaseEN.IdTeachSkill, 8, convVideoResCase_Base.IdTeachSkill);
clsCheckSql.CheckFieldLen(objvVideoResCase_BaseEN.TeachSkillID, 8, convVideoResCase_Base.TeachSkillID);
clsCheckSql.CheckFieldLen(objvVideoResCase_BaseEN.SkillTypeName, 50, convVideoResCase_Base.SkillTypeName);
clsCheckSql.CheckFieldLen(objvVideoResCase_BaseEN.TeachSkillName, 50, convVideoResCase_Base.TeachSkillName);
clsCheckSql.CheckFieldLen(objvVideoResCase_BaseEN.TeachSkillTheory, 8000, convVideoResCase_Base.TeachSkillTheory);
clsCheckSql.CheckFieldLen(objvVideoResCase_BaseEN.TeachSkillOperMethod, 2000, convVideoResCase_Base.TeachSkillOperMethod);
clsCheckSql.CheckFieldLen(objvVideoResCase_BaseEN.IdSkillType, 4, convVideoResCase_Base.IdSkillType);
clsCheckSql.CheckFieldLen(objvVideoResCase_BaseEN.SkillTypeID, 4, convVideoResCase_Base.SkillTypeID);
clsCheckSql.CheckFieldLen(objvVideoResCase_BaseEN.CaseLevelId, 2, convVideoResCase_Base.CaseLevelId);
clsCheckSql.CheckFieldLen(objvVideoResCase_BaseEN.CaseLevelName, 30, convVideoResCase_Base.CaseLevelName);
clsCheckSql.CheckFieldLen(objvVideoResCase_BaseEN.DocFile, 200, convVideoResCase_Base.DocFile);
clsCheckSql.CheckFieldLen(objvVideoResCase_BaseEN.WordCreateDate, 14, convVideoResCase_Base.WordCreateDate);
clsCheckSql.CheckFieldLen(objvVideoResCase_BaseEN.IdXzCollege, 4, convVideoResCase_Base.IdXzCollege);
clsCheckSql.CheckFieldLen(objvVideoResCase_BaseEN.CollegeID, 4, convVideoResCase_Base.CollegeID);
clsCheckSql.CheckFieldLen(objvVideoResCase_BaseEN.CollegeName, 100, convVideoResCase_Base.CollegeName);
clsCheckSql.CheckFieldLen(objvVideoResCase_BaseEN.CollegeNameA, 12, convVideoResCase_Base.CollegeNameA);
clsCheckSql.CheckFieldLen(objvVideoResCase_BaseEN.IdXzMajor, 8, convVideoResCase_Base.IdXzMajor);
clsCheckSql.CheckFieldLen(objvVideoResCase_BaseEN.MajorID, 4, convVideoResCase_Base.MajorID);
clsCheckSql.CheckFieldLen(objvVideoResCase_BaseEN.MajorName, 100, convVideoResCase_Base.MajorName);
clsCheckSql.CheckFieldLen(objvVideoResCase_BaseEN.CourseChapterId, 8, convVideoResCase_Base.CourseChapterId);
clsCheckSql.CheckFieldLen(objvVideoResCase_BaseEN.CourseChapterName, 100, convVideoResCase_Base.CourseChapterName);
clsCheckSql.CheckFieldLen(objvVideoResCase_BaseEN.ParentNodeID, 8, convVideoResCase_Base.ParentNodeID);
clsCheckSql.CheckFieldLen(objvVideoResCase_BaseEN.ParentNodeName, 50, convVideoResCase_Base.ParentNodeName);
clsCheckSql.CheckFieldLen(objvVideoResCase_BaseEN.RecommendedDegreeId, 2, convVideoResCase_Base.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objvVideoResCase_BaseEN.RecommendedDegreeName, 30, convVideoResCase_Base.RecommendedDegreeName);
clsCheckSql.CheckFieldLen(objvVideoResCase_BaseEN.ftpFileType, 30, convVideoResCase_Base.ftpFileType);
clsCheckSql.CheckFieldLen(objvVideoResCase_BaseEN.CourseId, 8, convVideoResCase_Base.CourseId);
clsCheckSql.CheckFieldLen(objvVideoResCase_BaseEN.CourseCode, 20, convVideoResCase_Base.CourseCode);
clsCheckSql.CheckFieldLen(objvVideoResCase_BaseEN.CourseName, 100, convVideoResCase_Base.CourseName);
clsCheckSql.CheckFieldLen(objvVideoResCase_BaseEN.VideoUrl, 1000, convVideoResCase_Base.VideoUrl);
clsCheckSql.CheckFieldLen(objvVideoResCase_BaseEN.VideoPath, 1000, convVideoResCase_Base.VideoPath);
clsCheckSql.CheckFieldLen(objvVideoResCase_BaseEN.ResErrMsg, 30, convVideoResCase_Base.ResErrMsg);
clsCheckSql.CheckFieldLen(objvVideoResCase_BaseEN.Memo, 1000, convVideoResCase_Base.Memo);
clsCheckSql.CheckFieldLen(objvVideoResCase_BaseEN.OwnerName, 30, convVideoResCase_Base.OwnerName);
clsCheckSql.CheckFieldLen(objvVideoResCase_BaseEN.OwnerNameWithId, 51, convVideoResCase_Base.OwnerNameWithId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_BaseEN.IdVideoResCase, convVideoResCase_Base.IdVideoResCase);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_BaseEN.VideoResCaseID, convVideoResCase_Base.VideoResCaseID);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_BaseEN.VideoResCaseName, convVideoResCase_Base.VideoResCaseName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_BaseEN.VideoResCaseTheme, convVideoResCase_Base.VideoResCaseTheme);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_BaseEN.IdVideoResCaseType, convVideoResCase_Base.IdVideoResCaseType);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_BaseEN.VideoResCaseTypeName, convVideoResCase_Base.VideoResCaseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_BaseEN.VideoResCaseText, convVideoResCase_Base.VideoResCaseText);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_BaseEN.VideoResCaseDate, convVideoResCase_Base.VideoResCaseDate);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_BaseEN.VideoResCaseTime, convVideoResCase_Base.VideoResCaseTime);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_BaseEN.VideoResCaseDateIn, convVideoResCase_Base.VideoResCaseDateIn);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_BaseEN.VideoResCaseTimeIn, convVideoResCase_Base.VideoResCaseTimeIn);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_BaseEN.OwnerId, convVideoResCase_Base.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_BaseEN.IdStudyLevel, convVideoResCase_Base.IdStudyLevel);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_BaseEN.StudyLevelName, convVideoResCase_Base.StudyLevelName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_BaseEN.IdTeachingPlan, convVideoResCase_Base.IdTeachingPlan);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_BaseEN.IdDiscipline, convVideoResCase_Base.IdDiscipline);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_BaseEN.DisciplineID, convVideoResCase_Base.DisciplineID);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_BaseEN.DisciplineName, convVideoResCase_Base.DisciplineName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_BaseEN.IdSenateGaugeVersion, convVideoResCase_Base.IdSenateGaugeVersion);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_BaseEN.senateGaugeVersionID, convVideoResCase_Base.senateGaugeVersionID);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_BaseEN.senateGaugeVersionName, convVideoResCase_Base.senateGaugeVersionName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_BaseEN.IdTeachSkill, convVideoResCase_Base.IdTeachSkill);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_BaseEN.TeachSkillID, convVideoResCase_Base.TeachSkillID);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_BaseEN.SkillTypeName, convVideoResCase_Base.SkillTypeName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_BaseEN.TeachSkillName, convVideoResCase_Base.TeachSkillName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_BaseEN.TeachSkillTheory, convVideoResCase_Base.TeachSkillTheory);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_BaseEN.TeachSkillOperMethod, convVideoResCase_Base.TeachSkillOperMethod);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_BaseEN.IdSkillType, convVideoResCase_Base.IdSkillType);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_BaseEN.SkillTypeID, convVideoResCase_Base.SkillTypeID);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_BaseEN.CaseLevelId, convVideoResCase_Base.CaseLevelId);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_BaseEN.CaseLevelName, convVideoResCase_Base.CaseLevelName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_BaseEN.DocFile, convVideoResCase_Base.DocFile);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_BaseEN.WordCreateDate, convVideoResCase_Base.WordCreateDate);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_BaseEN.IdXzCollege, convVideoResCase_Base.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_BaseEN.CollegeID, convVideoResCase_Base.CollegeID);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_BaseEN.CollegeName, convVideoResCase_Base.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_BaseEN.CollegeNameA, convVideoResCase_Base.CollegeNameA);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_BaseEN.IdXzMajor, convVideoResCase_Base.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_BaseEN.MajorID, convVideoResCase_Base.MajorID);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_BaseEN.MajorName, convVideoResCase_Base.MajorName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_BaseEN.CourseChapterId, convVideoResCase_Base.CourseChapterId);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_BaseEN.CourseChapterName, convVideoResCase_Base.CourseChapterName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_BaseEN.ParentNodeID, convVideoResCase_Base.ParentNodeID);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_BaseEN.ParentNodeName, convVideoResCase_Base.ParentNodeName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_BaseEN.RecommendedDegreeId, convVideoResCase_Base.RecommendedDegreeId);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_BaseEN.RecommendedDegreeName, convVideoResCase_Base.RecommendedDegreeName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_BaseEN.ftpFileType, convVideoResCase_Base.ftpFileType);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_BaseEN.CourseId, convVideoResCase_Base.CourseId);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_BaseEN.CourseCode, convVideoResCase_Base.CourseCode);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_BaseEN.CourseName, convVideoResCase_Base.CourseName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_BaseEN.VideoUrl, convVideoResCase_Base.VideoUrl);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_BaseEN.VideoPath, convVideoResCase_Base.VideoPath);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_BaseEN.ResErrMsg, convVideoResCase_Base.ResErrMsg);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_BaseEN.Memo, convVideoResCase_Base.Memo);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_BaseEN.OwnerName, convVideoResCase_Base.OwnerName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCase_BaseEN.OwnerNameWithId, convVideoResCase_Base.OwnerNameWithId);
//检查外键字段长度
 objvVideoResCase_BaseEN._IsCheckProperty = true;
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
 objSQL = clsvVideoResCase_BaseDA.GetSpecSQLObj();
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
 objSQL = clsvVideoResCase_BaseDA.GetSpecSQLObj();
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
 objSQL = clsvVideoResCase_BaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvVideoResCase_BaseEN._CurrTabName);
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
 objSQL = clsvVideoResCase_BaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvVideoResCase_BaseEN._CurrTabName, strCondition);
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
 objSQL = clsvVideoResCase_BaseDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}