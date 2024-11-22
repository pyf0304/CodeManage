
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMandarinCaseDA
 表名:vMandarinCase(01120465)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:47:09
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:普通话点播(Mandarin)
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
 /// v普通话教学案例(vMandarinCase)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvMandarinCaseDA : clsCommBase4DA
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
 return clsvMandarinCaseEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvMandarinCaseEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvMandarinCaseEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvMandarinCaseEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvMandarinCaseEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strIdMandarinCase">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strIdMandarinCase)
{
strIdMandarinCase = strIdMandarinCase.Replace("'", "''");
if (strIdMandarinCase.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vMandarinCase中,检查关键字,长度不正确!(clsvMandarinCaseDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdMandarinCase)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vMandarinCase中,关键字不能为空 或 null!(clsvMandarinCaseDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdMandarinCase);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvMandarinCaseDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvMandarinCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMandarinCaseDA.GetSpecSQLObj();
strSQL = "Select * from vMandarinCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vMandarinCase(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvMandarinCaseDA: GetDataTable_vMandarinCase)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMandarinCaseDA.GetSpecSQLObj();
strSQL = "Select * from vMandarinCase where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvMandarinCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMandarinCaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvMandarinCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMandarinCaseDA.GetSpecSQLObj();
strSQL = "Select * from vMandarinCase where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvMandarinCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMandarinCaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvMandarinCaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMandarinCaseDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vMandarinCase where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vMandarinCase where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvMandarinCaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMandarinCaseDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vMandarinCase where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvMandarinCaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMandarinCaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vMandarinCase.* from vMandarinCase Left Join {1} on {2} where {3} and vMandarinCase.IdMandarinCase not in (Select top {5} vMandarinCase.IdMandarinCase from vMandarinCase Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vMandarinCase where {1} and IdMandarinCase not in (Select top {2} IdMandarinCase from vMandarinCase where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vMandarinCase where {1} and IdMandarinCase not in (Select top {3} IdMandarinCase from vMandarinCase where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvMandarinCaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMandarinCaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vMandarinCase.* from vMandarinCase Left Join {1} on {2} where {3} and vMandarinCase.IdMandarinCase not in (Select top {5} vMandarinCase.IdMandarinCase from vMandarinCase Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vMandarinCase where {1} and IdMandarinCase not in (Select top {2} IdMandarinCase from vMandarinCase where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vMandarinCase where {1} and IdMandarinCase not in (Select top {3} IdMandarinCase from vMandarinCase where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvMandarinCaseEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvMandarinCaseDA:GetObjLst)", objException.Message));
}
List<clsvMandarinCaseEN> arrObjLst = new List<clsvMandarinCaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMandarinCaseDA.GetSpecSQLObj();
strSQL = "Select * from vMandarinCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMandarinCaseEN objvMandarinCaseEN = new clsvMandarinCaseEN();
try
{
objvMandarinCaseEN.IdMandarinCase = objRow[convMandarinCase.IdMandarinCase].ToString().Trim(); //普通话案例流水号
objvMandarinCaseEN.MandarinCaseID = objRow[convMandarinCase.MandarinCaseID].ToString().Trim(); //普通话教学案例ID
objvMandarinCaseEN.MandarinCaseName = objRow[convMandarinCase.MandarinCaseName].ToString().Trim(); //普通话教学案例名称
objvMandarinCaseEN.IdDiscipline = objRow[convMandarinCase.IdDiscipline].ToString().Trim(); //学科流水号
objvMandarinCaseEN.DisciplineID = objRow[convMandarinCase.DisciplineID].ToString().Trim(); //学科ID
objvMandarinCaseEN.DisciplineName = objRow[convMandarinCase.DisciplineName].ToString().Trim(); //学科名称
objvMandarinCaseEN.IdStudyLevel = objRow[convMandarinCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMandarinCaseEN.StudyLevelName = objRow[convMandarinCase.StudyLevelName].ToString().Trim(); //学段名称
objvMandarinCaseEN.MandarinCaseTheme = objRow[convMandarinCase.MandarinCaseTheme] == DBNull.Value ? null : objRow[convMandarinCase.MandarinCaseTheme].ToString().Trim(); //普通话教学案例主题词
objvMandarinCaseEN.MandarinCaseDate = objRow[convMandarinCase.MandarinCaseDate] == DBNull.Value ? null : objRow[convMandarinCase.MandarinCaseDate].ToString().Trim(); //普通话教学日期
objvMandarinCaseEN.MandarinCaseTime = objRow[convMandarinCase.MandarinCaseTime] == DBNull.Value ? null : objRow[convMandarinCase.MandarinCaseTime].ToString().Trim(); //普通话教学时间
objvMandarinCaseEN.MandarinCaseDateIn = objRow[convMandarinCase.MandarinCaseDateIn] == DBNull.Value ? null : objRow[convMandarinCase.MandarinCaseDateIn].ToString().Trim(); //案例入库日期
objvMandarinCaseEN.MandarinCaseTimeIn = objRow[convMandarinCase.MandarinCaseTimeIn] == DBNull.Value ? null : objRow[convMandarinCase.MandarinCaseTimeIn].ToString().Trim(); //案例入库时间
objvMandarinCaseEN.IdTeachingPlan = objRow[convMandarinCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMandarinCaseEN.IdSenateGaugeVersion = objRow[convMandarinCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMandarinCaseEN.senateGaugeVersionID = objRow[convMandarinCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMandarinCaseEN.senateGaugeVersionName = objRow[convMandarinCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMandarinCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMandarinCaseEN.senateGaugeVersionTtlScore = TransNullToFloat(objRow[convMandarinCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMandarinCaseEN.VersionNo = objRow[convMandarinCase.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMandarinCase.VersionNo].ToString().Trim()); //版本号
objvMandarinCaseEN.CaseLevelId = objRow[convMandarinCase.CaseLevelId] == DBNull.Value ? null : objRow[convMandarinCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvMandarinCaseEN.IsNeedGeneWord = TransNullToBool(objRow[convMandarinCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvMandarinCaseEN.DocFile = objRow[convMandarinCase.DocFile] == DBNull.Value ? null : objRow[convMandarinCase.DocFile].ToString().Trim(); //生成的Word文件名
objvMandarinCaseEN.WordCreateDate = objRow[convMandarinCase.WordCreateDate] == DBNull.Value ? null : objRow[convMandarinCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvMandarinCaseEN.IsVisible = TransNullToBool(objRow[convMandarinCase.IsVisible].ToString().Trim()); //是否显示
objvMandarinCaseEN.OwnerId = objRow[convMandarinCase.OwnerId].ToString().Trim(); //拥有者Id
objvMandarinCaseEN.StuName = objRow[convMandarinCase.StuName] == DBNull.Value ? null : objRow[convMandarinCase.StuName].ToString().Trim(); //姓名
objvMandarinCaseEN.StuID = objRow[convMandarinCase.StuID] == DBNull.Value ? null : objRow[convMandarinCase.StuID].ToString().Trim(); //学号
objvMandarinCaseEN.CollegeID = objRow[convMandarinCase.CollegeID] == DBNull.Value ? null : objRow[convMandarinCase.CollegeID].ToString().Trim(); //学院ID
objvMandarinCaseEN.CollegeName = objRow[convMandarinCase.CollegeName].ToString().Trim(); //学院名称
objvMandarinCaseEN.IdXzCollege = objRow[convMandarinCase.IdXzCollege] == DBNull.Value ? null : objRow[convMandarinCase.IdXzCollege].ToString().Trim(); //学院流水号
objvMandarinCaseEN.CollegeNameA = objRow[convMandarinCase.CollegeNameA] == DBNull.Value ? null : objRow[convMandarinCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvMandarinCaseEN.IdXzMajor = objRow[convMandarinCase.IdXzMajor] == DBNull.Value ? null : objRow[convMandarinCase.IdXzMajor].ToString().Trim(); //专业流水号
objvMandarinCaseEN.MajorName = objRow[convMandarinCase.MajorName] == DBNull.Value ? null : objRow[convMandarinCase.MajorName].ToString().Trim(); //专业名称
objvMandarinCaseEN.IdGradeBase = objRow[convMandarinCase.IdGradeBase] == DBNull.Value ? null : objRow[convMandarinCase.IdGradeBase].ToString().Trim(); //年级流水号
objvMandarinCaseEN.GradeBaseName = objRow[convMandarinCase.GradeBaseName] == DBNull.Value ? null : objRow[convMandarinCase.GradeBaseName].ToString().Trim(); //年级名称
objvMandarinCaseEN.IdAdminCls = objRow[convMandarinCase.IdAdminCls] == DBNull.Value ? null : objRow[convMandarinCase.IdAdminCls].ToString().Trim(); //行政班流水号
objvMandarinCaseEN.IsDualVideo = TransNullToBool(objRow[convMandarinCase.IsDualVideo].ToString().Trim()); //是否双视频
objvMandarinCaseEN.IdMandarinCaseType = objRow[convMandarinCase.IdMandarinCaseType].ToString().Trim(); //普通话案例类型流水号
objvMandarinCaseEN.MandarinCaseTypeName = objRow[convMandarinCase.MandarinCaseTypeName] == DBNull.Value ? null : objRow[convMandarinCase.MandarinCaseTypeName].ToString().Trim(); //普通话案例类型名称
objvMandarinCaseEN.UserTypeId = objRow[convMandarinCase.UserTypeId] == DBNull.Value ? null : objRow[convMandarinCase.UserTypeId].ToString().Trim(); //用户类型Id
objvMandarinCaseEN.UserTypeName = objRow[convMandarinCase.UserTypeName] == DBNull.Value ? null : objRow[convMandarinCase.UserTypeName].ToString().Trim(); //用户类型名称
objvMandarinCaseEN.RecommendedDegreeId = objRow[convMandarinCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMandarinCaseEN.RecommendedDegreeName = objRow[convMandarinCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMandarinCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMandarinCaseEN.ftpFileType = objRow[convMandarinCase.ftpFileType] == DBNull.Value ? null : objRow[convMandarinCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvMandarinCaseEN.VideoUrl = objRow[convMandarinCase.VideoUrl] == DBNull.Value ? null : objRow[convMandarinCase.VideoUrl].ToString().Trim(); //视频Url
objvMandarinCaseEN.VideoPath = objRow[convMandarinCase.VideoPath] == DBNull.Value ? null : objRow[convMandarinCase.VideoPath].ToString().Trim(); //视频目录
objvMandarinCaseEN.ResErrMsg = objRow[convMandarinCase.ResErrMsg] == DBNull.Value ? null : objRow[convMandarinCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvMandarinCaseEN.UpdDate = objRow[convMandarinCase.UpdDate] == DBNull.Value ? null : objRow[convMandarinCase.UpdDate].ToString().Trim(); //修改日期
objvMandarinCaseEN.UpdUserId = objRow[convMandarinCase.UpdUserId] == DBNull.Value ? null : objRow[convMandarinCase.UpdUserId].ToString().Trim(); //修改用户Id
objvMandarinCaseEN.Memo = objRow[convMandarinCase.Memo] == DBNull.Value ? null : objRow[convMandarinCase.Memo].ToString().Trim(); //备注
objvMandarinCaseEN.BrowseCount4Case = objRow[convMandarinCase.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMandarinCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMandarinCaseEN.IsHaveVideo = objRow[convMandarinCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
objvMandarinCaseEN.OwnerNameWithId = objRow[convMandarinCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convMandarinCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMandarinCaseEN.OwnerName = objRow[convMandarinCase.OwnerName] == DBNull.Value ? null : objRow[convMandarinCase.OwnerName].ToString().Trim(); //拥有者姓名
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvMandarinCaseDA: GetObjLst)", objException.Message));
}
objvMandarinCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvMandarinCaseEN);
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
public List<clsvMandarinCaseEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvMandarinCaseDA:GetObjLstByTabName)", objException.Message));
}
List<clsvMandarinCaseEN> arrObjLst = new List<clsvMandarinCaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMandarinCaseDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMandarinCaseEN objvMandarinCaseEN = new clsvMandarinCaseEN();
try
{
objvMandarinCaseEN.IdMandarinCase = objRow[convMandarinCase.IdMandarinCase].ToString().Trim(); //普通话案例流水号
objvMandarinCaseEN.MandarinCaseID = objRow[convMandarinCase.MandarinCaseID].ToString().Trim(); //普通话教学案例ID
objvMandarinCaseEN.MandarinCaseName = objRow[convMandarinCase.MandarinCaseName].ToString().Trim(); //普通话教学案例名称
objvMandarinCaseEN.IdDiscipline = objRow[convMandarinCase.IdDiscipline].ToString().Trim(); //学科流水号
objvMandarinCaseEN.DisciplineID = objRow[convMandarinCase.DisciplineID].ToString().Trim(); //学科ID
objvMandarinCaseEN.DisciplineName = objRow[convMandarinCase.DisciplineName].ToString().Trim(); //学科名称
objvMandarinCaseEN.IdStudyLevel = objRow[convMandarinCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMandarinCaseEN.StudyLevelName = objRow[convMandarinCase.StudyLevelName].ToString().Trim(); //学段名称
objvMandarinCaseEN.MandarinCaseTheme = objRow[convMandarinCase.MandarinCaseTheme] == DBNull.Value ? null : objRow[convMandarinCase.MandarinCaseTheme].ToString().Trim(); //普通话教学案例主题词
objvMandarinCaseEN.MandarinCaseDate = objRow[convMandarinCase.MandarinCaseDate] == DBNull.Value ? null : objRow[convMandarinCase.MandarinCaseDate].ToString().Trim(); //普通话教学日期
objvMandarinCaseEN.MandarinCaseTime = objRow[convMandarinCase.MandarinCaseTime] == DBNull.Value ? null : objRow[convMandarinCase.MandarinCaseTime].ToString().Trim(); //普通话教学时间
objvMandarinCaseEN.MandarinCaseDateIn = objRow[convMandarinCase.MandarinCaseDateIn] == DBNull.Value ? null : objRow[convMandarinCase.MandarinCaseDateIn].ToString().Trim(); //案例入库日期
objvMandarinCaseEN.MandarinCaseTimeIn = objRow[convMandarinCase.MandarinCaseTimeIn] == DBNull.Value ? null : objRow[convMandarinCase.MandarinCaseTimeIn].ToString().Trim(); //案例入库时间
objvMandarinCaseEN.IdTeachingPlan = objRow[convMandarinCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMandarinCaseEN.IdSenateGaugeVersion = objRow[convMandarinCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMandarinCaseEN.senateGaugeVersionID = objRow[convMandarinCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMandarinCaseEN.senateGaugeVersionName = objRow[convMandarinCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMandarinCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMandarinCaseEN.senateGaugeVersionTtlScore = TransNullToFloat(objRow[convMandarinCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMandarinCaseEN.VersionNo = objRow[convMandarinCase.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMandarinCase.VersionNo].ToString().Trim()); //版本号
objvMandarinCaseEN.CaseLevelId = objRow[convMandarinCase.CaseLevelId] == DBNull.Value ? null : objRow[convMandarinCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvMandarinCaseEN.IsNeedGeneWord = TransNullToBool(objRow[convMandarinCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvMandarinCaseEN.DocFile = objRow[convMandarinCase.DocFile] == DBNull.Value ? null : objRow[convMandarinCase.DocFile].ToString().Trim(); //生成的Word文件名
objvMandarinCaseEN.WordCreateDate = objRow[convMandarinCase.WordCreateDate] == DBNull.Value ? null : objRow[convMandarinCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvMandarinCaseEN.IsVisible = TransNullToBool(objRow[convMandarinCase.IsVisible].ToString().Trim()); //是否显示
objvMandarinCaseEN.OwnerId = objRow[convMandarinCase.OwnerId].ToString().Trim(); //拥有者Id
objvMandarinCaseEN.StuName = objRow[convMandarinCase.StuName] == DBNull.Value ? null : objRow[convMandarinCase.StuName].ToString().Trim(); //姓名
objvMandarinCaseEN.StuID = objRow[convMandarinCase.StuID] == DBNull.Value ? null : objRow[convMandarinCase.StuID].ToString().Trim(); //学号
objvMandarinCaseEN.CollegeID = objRow[convMandarinCase.CollegeID] == DBNull.Value ? null : objRow[convMandarinCase.CollegeID].ToString().Trim(); //学院ID
objvMandarinCaseEN.CollegeName = objRow[convMandarinCase.CollegeName].ToString().Trim(); //学院名称
objvMandarinCaseEN.IdXzCollege = objRow[convMandarinCase.IdXzCollege] == DBNull.Value ? null : objRow[convMandarinCase.IdXzCollege].ToString().Trim(); //学院流水号
objvMandarinCaseEN.CollegeNameA = objRow[convMandarinCase.CollegeNameA] == DBNull.Value ? null : objRow[convMandarinCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvMandarinCaseEN.IdXzMajor = objRow[convMandarinCase.IdXzMajor] == DBNull.Value ? null : objRow[convMandarinCase.IdXzMajor].ToString().Trim(); //专业流水号
objvMandarinCaseEN.MajorName = objRow[convMandarinCase.MajorName] == DBNull.Value ? null : objRow[convMandarinCase.MajorName].ToString().Trim(); //专业名称
objvMandarinCaseEN.IdGradeBase = objRow[convMandarinCase.IdGradeBase] == DBNull.Value ? null : objRow[convMandarinCase.IdGradeBase].ToString().Trim(); //年级流水号
objvMandarinCaseEN.GradeBaseName = objRow[convMandarinCase.GradeBaseName] == DBNull.Value ? null : objRow[convMandarinCase.GradeBaseName].ToString().Trim(); //年级名称
objvMandarinCaseEN.IdAdminCls = objRow[convMandarinCase.IdAdminCls] == DBNull.Value ? null : objRow[convMandarinCase.IdAdminCls].ToString().Trim(); //行政班流水号
objvMandarinCaseEN.IsDualVideo = TransNullToBool(objRow[convMandarinCase.IsDualVideo].ToString().Trim()); //是否双视频
objvMandarinCaseEN.IdMandarinCaseType = objRow[convMandarinCase.IdMandarinCaseType].ToString().Trim(); //普通话案例类型流水号
objvMandarinCaseEN.MandarinCaseTypeName = objRow[convMandarinCase.MandarinCaseTypeName] == DBNull.Value ? null : objRow[convMandarinCase.MandarinCaseTypeName].ToString().Trim(); //普通话案例类型名称
objvMandarinCaseEN.UserTypeId = objRow[convMandarinCase.UserTypeId] == DBNull.Value ? null : objRow[convMandarinCase.UserTypeId].ToString().Trim(); //用户类型Id
objvMandarinCaseEN.UserTypeName = objRow[convMandarinCase.UserTypeName] == DBNull.Value ? null : objRow[convMandarinCase.UserTypeName].ToString().Trim(); //用户类型名称
objvMandarinCaseEN.RecommendedDegreeId = objRow[convMandarinCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMandarinCaseEN.RecommendedDegreeName = objRow[convMandarinCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMandarinCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMandarinCaseEN.ftpFileType = objRow[convMandarinCase.ftpFileType] == DBNull.Value ? null : objRow[convMandarinCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvMandarinCaseEN.VideoUrl = objRow[convMandarinCase.VideoUrl] == DBNull.Value ? null : objRow[convMandarinCase.VideoUrl].ToString().Trim(); //视频Url
objvMandarinCaseEN.VideoPath = objRow[convMandarinCase.VideoPath] == DBNull.Value ? null : objRow[convMandarinCase.VideoPath].ToString().Trim(); //视频目录
objvMandarinCaseEN.ResErrMsg = objRow[convMandarinCase.ResErrMsg] == DBNull.Value ? null : objRow[convMandarinCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvMandarinCaseEN.UpdDate = objRow[convMandarinCase.UpdDate] == DBNull.Value ? null : objRow[convMandarinCase.UpdDate].ToString().Trim(); //修改日期
objvMandarinCaseEN.UpdUserId = objRow[convMandarinCase.UpdUserId] == DBNull.Value ? null : objRow[convMandarinCase.UpdUserId].ToString().Trim(); //修改用户Id
objvMandarinCaseEN.Memo = objRow[convMandarinCase.Memo] == DBNull.Value ? null : objRow[convMandarinCase.Memo].ToString().Trim(); //备注
objvMandarinCaseEN.BrowseCount4Case = objRow[convMandarinCase.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMandarinCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMandarinCaseEN.IsHaveVideo = objRow[convMandarinCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
objvMandarinCaseEN.OwnerNameWithId = objRow[convMandarinCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convMandarinCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMandarinCaseEN.OwnerName = objRow[convMandarinCase.OwnerName] == DBNull.Value ? null : objRow[convMandarinCase.OwnerName].ToString().Trim(); //拥有者姓名
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvMandarinCaseDA: GetObjLst)", objException.Message));
}
objvMandarinCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvMandarinCaseEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvMandarinCaseEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvMandarinCase(ref clsvMandarinCaseEN objvMandarinCaseEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMandarinCaseDA.GetSpecSQLObj();
strSQL = "Select * from vMandarinCase where IdMandarinCase = " + "'"+ objvMandarinCaseEN.IdMandarinCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvMandarinCaseEN.IdMandarinCase = objDT.Rows[0][convMandarinCase.IdMandarinCase].ToString().Trim(); //普通话案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMandarinCaseEN.MandarinCaseID = objDT.Rows[0][convMandarinCase.MandarinCaseID].ToString().Trim(); //普通话教学案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvMandarinCaseEN.MandarinCaseName = objDT.Rows[0][convMandarinCase.MandarinCaseName].ToString().Trim(); //普通话教学案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMandarinCaseEN.IdDiscipline = objDT.Rows[0][convMandarinCase.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMandarinCaseEN.DisciplineID = objDT.Rows[0][convMandarinCase.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvMandarinCaseEN.DisciplineName = objDT.Rows[0][convMandarinCase.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMandarinCaseEN.IdStudyLevel = objDT.Rows[0][convMandarinCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvMandarinCaseEN.StudyLevelName = objDT.Rows[0][convMandarinCase.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMandarinCaseEN.MandarinCaseTheme = objDT.Rows[0][convMandarinCase.MandarinCaseTheme].ToString().Trim(); //普通话教学案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvMandarinCaseEN.MandarinCaseDate = objDT.Rows[0][convMandarinCase.MandarinCaseDate].ToString().Trim(); //普通话教学日期(字段类型:char,字段长度:8,是否可空:True)
 objvMandarinCaseEN.MandarinCaseTime = objDT.Rows[0][convMandarinCase.MandarinCaseTime].ToString().Trim(); //普通话教学时间(字段类型:char,字段长度:6,是否可空:True)
 objvMandarinCaseEN.MandarinCaseDateIn = objDT.Rows[0][convMandarinCase.MandarinCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvMandarinCaseEN.MandarinCaseTimeIn = objDT.Rows[0][convMandarinCase.MandarinCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvMandarinCaseEN.IdTeachingPlan = objDT.Rows[0][convMandarinCase.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMandarinCaseEN.IdSenateGaugeVersion = objDT.Rows[0][convMandarinCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMandarinCaseEN.senateGaugeVersionID = objDT.Rows[0][convMandarinCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvMandarinCaseEN.senateGaugeVersionName = objDT.Rows[0][convMandarinCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvMandarinCaseEN.senateGaugeVersionTtlScore = TransNullToFloat(objDT.Rows[0][convMandarinCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvMandarinCaseEN.VersionNo = TransNullToInt(objDT.Rows[0][convMandarinCase.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvMandarinCaseEN.CaseLevelId = objDT.Rows[0][convMandarinCase.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvMandarinCaseEN.IsNeedGeneWord = TransNullToBool(objDT.Rows[0][convMandarinCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word(字段类型:bit,字段长度:1,是否可空:True)
 objvMandarinCaseEN.DocFile = objDT.Rows[0][convMandarinCase.DocFile].ToString().Trim(); //生成的Word文件名(字段类型:varchar,字段长度:200,是否可空:True)
 objvMandarinCaseEN.WordCreateDate = objDT.Rows[0][convMandarinCase.WordCreateDate].ToString().Trim(); //Word生成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objvMandarinCaseEN.IsVisible = TransNullToBool(objDT.Rows[0][convMandarinCase.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvMandarinCaseEN.OwnerId = objDT.Rows[0][convMandarinCase.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvMandarinCaseEN.StuName = objDT.Rows[0][convMandarinCase.StuName].ToString().Trim(); //姓名(字段类型:varchar,字段长度:50,是否可空:True)
 objvMandarinCaseEN.StuID = objDT.Rows[0][convMandarinCase.StuID].ToString().Trim(); //学号(字段类型:varchar,字段长度:20,是否可空:True)
 objvMandarinCaseEN.CollegeID = objDT.Rows[0][convMandarinCase.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvMandarinCaseEN.CollegeName = objDT.Rows[0][convMandarinCase.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMandarinCaseEN.IdXzCollege = objDT.Rows[0][convMandarinCase.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvMandarinCaseEN.CollegeNameA = objDT.Rows[0][convMandarinCase.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvMandarinCaseEN.IdXzMajor = objDT.Rows[0][convMandarinCase.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMandarinCaseEN.MajorName = objDT.Rows[0][convMandarinCase.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMandarinCaseEN.IdGradeBase = objDT.Rows[0][convMandarinCase.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objvMandarinCaseEN.GradeBaseName = objDT.Rows[0][convMandarinCase.GradeBaseName].ToString().Trim(); //年级名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMandarinCaseEN.IdAdminCls = objDT.Rows[0][convMandarinCase.IdAdminCls].ToString().Trim(); //行政班流水号(字段类型:char,字段长度:8,是否可空:True)
 objvMandarinCaseEN.IsDualVideo = TransNullToBool(objDT.Rows[0][convMandarinCase.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvMandarinCaseEN.IdMandarinCaseType = objDT.Rows[0][convMandarinCase.IdMandarinCaseType].ToString().Trim(); //普通话案例类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMandarinCaseEN.MandarinCaseTypeName = objDT.Rows[0][convMandarinCase.MandarinCaseTypeName].ToString().Trim(); //普通话案例类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMandarinCaseEN.UserTypeId = objDT.Rows[0][convMandarinCase.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvMandarinCaseEN.UserTypeName = objDT.Rows[0][convMandarinCase.UserTypeName].ToString().Trim(); //用户类型名称(字段类型:varchar,字段长度:20,是否可空:True)
 objvMandarinCaseEN.RecommendedDegreeId = objDT.Rows[0][convMandarinCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvMandarinCaseEN.RecommendedDegreeName = objDT.Rows[0][convMandarinCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvMandarinCaseEN.ftpFileType = objDT.Rows[0][convMandarinCase.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvMandarinCaseEN.VideoUrl = objDT.Rows[0][convMandarinCase.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objvMandarinCaseEN.VideoPath = objDT.Rows[0][convMandarinCase.VideoPath].ToString().Trim(); //视频目录(字段类型:varchar,字段长度:1000,是否可空:True)
 objvMandarinCaseEN.ResErrMsg = objDT.Rows[0][convMandarinCase.ResErrMsg].ToString().Trim(); //资源错误信息(字段类型:varchar,字段长度:30,是否可空:True)
 objvMandarinCaseEN.UpdDate = objDT.Rows[0][convMandarinCase.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvMandarinCaseEN.UpdUserId = objDT.Rows[0][convMandarinCase.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvMandarinCaseEN.Memo = objDT.Rows[0][convMandarinCase.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvMandarinCaseEN.BrowseCount4Case = TransNullToInt(objDT.Rows[0][convMandarinCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvMandarinCaseEN.IsHaveVideo = objDT.Rows[0][convMandarinCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo(字段类型:varchar,字段长度:6,是否可空:True)
 objvMandarinCaseEN.OwnerNameWithId = objDT.Rows[0][convMandarinCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
 objvMandarinCaseEN.OwnerName = objDT.Rows[0][convMandarinCase.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvMandarinCaseDA: GetvMandarinCase)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdMandarinCase">表关键字</param>
 /// <returns>表对象</returns>
public clsvMandarinCaseEN GetObjByIdMandarinCase(string strIdMandarinCase)
{
CheckPrimaryKey(strIdMandarinCase);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMandarinCaseDA.GetSpecSQLObj();
strSQL = "Select * from vMandarinCase where IdMandarinCase = " + "'"+ strIdMandarinCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvMandarinCaseEN objvMandarinCaseEN = new clsvMandarinCaseEN();
try
{
 objvMandarinCaseEN.IdMandarinCase = objRow[convMandarinCase.IdMandarinCase].ToString().Trim(); //普通话案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMandarinCaseEN.MandarinCaseID = objRow[convMandarinCase.MandarinCaseID].ToString().Trim(); //普通话教学案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvMandarinCaseEN.MandarinCaseName = objRow[convMandarinCase.MandarinCaseName].ToString().Trim(); //普通话教学案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMandarinCaseEN.IdDiscipline = objRow[convMandarinCase.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMandarinCaseEN.DisciplineID = objRow[convMandarinCase.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvMandarinCaseEN.DisciplineName = objRow[convMandarinCase.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMandarinCaseEN.IdStudyLevel = objRow[convMandarinCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvMandarinCaseEN.StudyLevelName = objRow[convMandarinCase.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMandarinCaseEN.MandarinCaseTheme = objRow[convMandarinCase.MandarinCaseTheme] == DBNull.Value ? null : objRow[convMandarinCase.MandarinCaseTheme].ToString().Trim(); //普通话教学案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvMandarinCaseEN.MandarinCaseDate = objRow[convMandarinCase.MandarinCaseDate] == DBNull.Value ? null : objRow[convMandarinCase.MandarinCaseDate].ToString().Trim(); //普通话教学日期(字段类型:char,字段长度:8,是否可空:True)
 objvMandarinCaseEN.MandarinCaseTime = objRow[convMandarinCase.MandarinCaseTime] == DBNull.Value ? null : objRow[convMandarinCase.MandarinCaseTime].ToString().Trim(); //普通话教学时间(字段类型:char,字段长度:6,是否可空:True)
 objvMandarinCaseEN.MandarinCaseDateIn = objRow[convMandarinCase.MandarinCaseDateIn] == DBNull.Value ? null : objRow[convMandarinCase.MandarinCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvMandarinCaseEN.MandarinCaseTimeIn = objRow[convMandarinCase.MandarinCaseTimeIn] == DBNull.Value ? null : objRow[convMandarinCase.MandarinCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvMandarinCaseEN.IdTeachingPlan = objRow[convMandarinCase.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMandarinCaseEN.IdSenateGaugeVersion = objRow[convMandarinCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMandarinCaseEN.senateGaugeVersionID = objRow[convMandarinCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvMandarinCaseEN.senateGaugeVersionName = objRow[convMandarinCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMandarinCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvMandarinCaseEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convMandarinCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvMandarinCaseEN.VersionNo = objRow[convMandarinCase.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMandarinCase.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvMandarinCaseEN.CaseLevelId = objRow[convMandarinCase.CaseLevelId] == DBNull.Value ? null : objRow[convMandarinCase.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvMandarinCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convMandarinCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word(字段类型:bit,字段长度:1,是否可空:True)
 objvMandarinCaseEN.DocFile = objRow[convMandarinCase.DocFile] == DBNull.Value ? null : objRow[convMandarinCase.DocFile].ToString().Trim(); //生成的Word文件名(字段类型:varchar,字段长度:200,是否可空:True)
 objvMandarinCaseEN.WordCreateDate = objRow[convMandarinCase.WordCreateDate] == DBNull.Value ? null : objRow[convMandarinCase.WordCreateDate].ToString().Trim(); //Word生成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objvMandarinCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMandarinCase.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvMandarinCaseEN.OwnerId = objRow[convMandarinCase.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvMandarinCaseEN.StuName = objRow[convMandarinCase.StuName] == DBNull.Value ? null : objRow[convMandarinCase.StuName].ToString().Trim(); //姓名(字段类型:varchar,字段长度:50,是否可空:True)
 objvMandarinCaseEN.StuID = objRow[convMandarinCase.StuID] == DBNull.Value ? null : objRow[convMandarinCase.StuID].ToString().Trim(); //学号(字段类型:varchar,字段长度:20,是否可空:True)
 objvMandarinCaseEN.CollegeID = objRow[convMandarinCase.CollegeID] == DBNull.Value ? null : objRow[convMandarinCase.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvMandarinCaseEN.CollegeName = objRow[convMandarinCase.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMandarinCaseEN.IdXzCollege = objRow[convMandarinCase.IdXzCollege] == DBNull.Value ? null : objRow[convMandarinCase.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvMandarinCaseEN.CollegeNameA = objRow[convMandarinCase.CollegeNameA] == DBNull.Value ? null : objRow[convMandarinCase.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvMandarinCaseEN.IdXzMajor = objRow[convMandarinCase.IdXzMajor] == DBNull.Value ? null : objRow[convMandarinCase.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMandarinCaseEN.MajorName = objRow[convMandarinCase.MajorName] == DBNull.Value ? null : objRow[convMandarinCase.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMandarinCaseEN.IdGradeBase = objRow[convMandarinCase.IdGradeBase] == DBNull.Value ? null : objRow[convMandarinCase.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objvMandarinCaseEN.GradeBaseName = objRow[convMandarinCase.GradeBaseName] == DBNull.Value ? null : objRow[convMandarinCase.GradeBaseName].ToString().Trim(); //年级名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMandarinCaseEN.IdAdminCls = objRow[convMandarinCase.IdAdminCls] == DBNull.Value ? null : objRow[convMandarinCase.IdAdminCls].ToString().Trim(); //行政班流水号(字段类型:char,字段长度:8,是否可空:True)
 objvMandarinCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convMandarinCase.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvMandarinCaseEN.IdMandarinCaseType = objRow[convMandarinCase.IdMandarinCaseType].ToString().Trim(); //普通话案例类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMandarinCaseEN.MandarinCaseTypeName = objRow[convMandarinCase.MandarinCaseTypeName] == DBNull.Value ? null : objRow[convMandarinCase.MandarinCaseTypeName].ToString().Trim(); //普通话案例类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMandarinCaseEN.UserTypeId = objRow[convMandarinCase.UserTypeId] == DBNull.Value ? null : objRow[convMandarinCase.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvMandarinCaseEN.UserTypeName = objRow[convMandarinCase.UserTypeName] == DBNull.Value ? null : objRow[convMandarinCase.UserTypeName].ToString().Trim(); //用户类型名称(字段类型:varchar,字段长度:20,是否可空:True)
 objvMandarinCaseEN.RecommendedDegreeId = objRow[convMandarinCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvMandarinCaseEN.RecommendedDegreeName = objRow[convMandarinCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMandarinCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvMandarinCaseEN.ftpFileType = objRow[convMandarinCase.ftpFileType] == DBNull.Value ? null : objRow[convMandarinCase.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvMandarinCaseEN.VideoUrl = objRow[convMandarinCase.VideoUrl] == DBNull.Value ? null : objRow[convMandarinCase.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objvMandarinCaseEN.VideoPath = objRow[convMandarinCase.VideoPath] == DBNull.Value ? null : objRow[convMandarinCase.VideoPath].ToString().Trim(); //视频目录(字段类型:varchar,字段长度:1000,是否可空:True)
 objvMandarinCaseEN.ResErrMsg = objRow[convMandarinCase.ResErrMsg] == DBNull.Value ? null : objRow[convMandarinCase.ResErrMsg].ToString().Trim(); //资源错误信息(字段类型:varchar,字段长度:30,是否可空:True)
 objvMandarinCaseEN.UpdDate = objRow[convMandarinCase.UpdDate] == DBNull.Value ? null : objRow[convMandarinCase.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvMandarinCaseEN.UpdUserId = objRow[convMandarinCase.UpdUserId] == DBNull.Value ? null : objRow[convMandarinCase.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvMandarinCaseEN.Memo = objRow[convMandarinCase.Memo] == DBNull.Value ? null : objRow[convMandarinCase.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvMandarinCaseEN.BrowseCount4Case = objRow[convMandarinCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMandarinCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvMandarinCaseEN.IsHaveVideo = objRow[convMandarinCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo(字段类型:varchar,字段长度:6,是否可空:True)
 objvMandarinCaseEN.OwnerNameWithId = objRow[convMandarinCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convMandarinCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
 objvMandarinCaseEN.OwnerName = objRow[convMandarinCase.OwnerName] == DBNull.Value ? null : objRow[convMandarinCase.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvMandarinCaseDA: GetObjByIdMandarinCase)", objException.Message));
}
return objvMandarinCaseEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvMandarinCaseEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvMandarinCaseDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMandarinCaseDA.GetSpecSQLObj();
strSQL = "Select * from vMandarinCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvMandarinCaseEN objvMandarinCaseEN = new clsvMandarinCaseEN()
{
IdMandarinCase = objRow[convMandarinCase.IdMandarinCase].ToString().Trim(), //普通话案例流水号
MandarinCaseID = objRow[convMandarinCase.MandarinCaseID].ToString().Trim(), //普通话教学案例ID
MandarinCaseName = objRow[convMandarinCase.MandarinCaseName].ToString().Trim(), //普通话教学案例名称
IdDiscipline = objRow[convMandarinCase.IdDiscipline].ToString().Trim(), //学科流水号
DisciplineID = objRow[convMandarinCase.DisciplineID].ToString().Trim(), //学科ID
DisciplineName = objRow[convMandarinCase.DisciplineName].ToString().Trim(), //学科名称
IdStudyLevel = objRow[convMandarinCase.IdStudyLevel].ToString().Trim(), //id_StudyLevel
StudyLevelName = objRow[convMandarinCase.StudyLevelName].ToString().Trim(), //学段名称
MandarinCaseTheme = objRow[convMandarinCase.MandarinCaseTheme] == DBNull.Value ? null : objRow[convMandarinCase.MandarinCaseTheme].ToString().Trim(), //普通话教学案例主题词
MandarinCaseDate = objRow[convMandarinCase.MandarinCaseDate] == DBNull.Value ? null : objRow[convMandarinCase.MandarinCaseDate].ToString().Trim(), //普通话教学日期
MandarinCaseTime = objRow[convMandarinCase.MandarinCaseTime] == DBNull.Value ? null : objRow[convMandarinCase.MandarinCaseTime].ToString().Trim(), //普通话教学时间
MandarinCaseDateIn = objRow[convMandarinCase.MandarinCaseDateIn] == DBNull.Value ? null : objRow[convMandarinCase.MandarinCaseDateIn].ToString().Trim(), //案例入库日期
MandarinCaseTimeIn = objRow[convMandarinCase.MandarinCaseTimeIn] == DBNull.Value ? null : objRow[convMandarinCase.MandarinCaseTimeIn].ToString().Trim(), //案例入库时间
IdTeachingPlan = objRow[convMandarinCase.IdTeachingPlan].ToString().Trim(), //教案流水号
IdSenateGaugeVersion = objRow[convMandarinCase.IdSenateGaugeVersion].ToString().Trim(), //评价量表版本流水号
senateGaugeVersionID = objRow[convMandarinCase.senateGaugeVersionID].ToString().Trim(), //评价量表版本ID
senateGaugeVersionName = objRow[convMandarinCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMandarinCase.senateGaugeVersionName].ToString().Trim(), //评价量表版本名称
senateGaugeVersionTtlScore = TransNullToFloat(objRow[convMandarinCase.senateGaugeVersionTtlScore].ToString().Trim()), //评价量表版本总分
VersionNo = objRow[convMandarinCase.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMandarinCase.VersionNo].ToString().Trim()), //版本号
CaseLevelId = objRow[convMandarinCase.CaseLevelId] == DBNull.Value ? null : objRow[convMandarinCase.CaseLevelId].ToString().Trim(), //课例等级Id
IsNeedGeneWord = TransNullToBool(objRow[convMandarinCase.IsNeedGeneWord].ToString().Trim()), //是否需要生成Word
DocFile = objRow[convMandarinCase.DocFile] == DBNull.Value ? null : objRow[convMandarinCase.DocFile].ToString().Trim(), //生成的Word文件名
WordCreateDate = objRow[convMandarinCase.WordCreateDate] == DBNull.Value ? null : objRow[convMandarinCase.WordCreateDate].ToString().Trim(), //Word生成日期
IsVisible = TransNullToBool(objRow[convMandarinCase.IsVisible].ToString().Trim()), //是否显示
OwnerId = objRow[convMandarinCase.OwnerId].ToString().Trim(), //拥有者Id
StuName = objRow[convMandarinCase.StuName] == DBNull.Value ? null : objRow[convMandarinCase.StuName].ToString().Trim(), //姓名
StuID = objRow[convMandarinCase.StuID] == DBNull.Value ? null : objRow[convMandarinCase.StuID].ToString().Trim(), //学号
CollegeID = objRow[convMandarinCase.CollegeID] == DBNull.Value ? null : objRow[convMandarinCase.CollegeID].ToString().Trim(), //学院ID
CollegeName = objRow[convMandarinCase.CollegeName].ToString().Trim(), //学院名称
IdXzCollege = objRow[convMandarinCase.IdXzCollege] == DBNull.Value ? null : objRow[convMandarinCase.IdXzCollege].ToString().Trim(), //学院流水号
CollegeNameA = objRow[convMandarinCase.CollegeNameA] == DBNull.Value ? null : objRow[convMandarinCase.CollegeNameA].ToString().Trim(), //学院名称简写
IdXzMajor = objRow[convMandarinCase.IdXzMajor] == DBNull.Value ? null : objRow[convMandarinCase.IdXzMajor].ToString().Trim(), //专业流水号
MajorName = objRow[convMandarinCase.MajorName] == DBNull.Value ? null : objRow[convMandarinCase.MajorName].ToString().Trim(), //专业名称
IdGradeBase = objRow[convMandarinCase.IdGradeBase] == DBNull.Value ? null : objRow[convMandarinCase.IdGradeBase].ToString().Trim(), //年级流水号
GradeBaseName = objRow[convMandarinCase.GradeBaseName] == DBNull.Value ? null : objRow[convMandarinCase.GradeBaseName].ToString().Trim(), //年级名称
IdAdminCls = objRow[convMandarinCase.IdAdminCls] == DBNull.Value ? null : objRow[convMandarinCase.IdAdminCls].ToString().Trim(), //行政班流水号
IsDualVideo = TransNullToBool(objRow[convMandarinCase.IsDualVideo].ToString().Trim()), //是否双视频
IdMandarinCaseType = objRow[convMandarinCase.IdMandarinCaseType].ToString().Trim(), //普通话案例类型流水号
MandarinCaseTypeName = objRow[convMandarinCase.MandarinCaseTypeName] == DBNull.Value ? null : objRow[convMandarinCase.MandarinCaseTypeName].ToString().Trim(), //普通话案例类型名称
UserTypeId = objRow[convMandarinCase.UserTypeId] == DBNull.Value ? null : objRow[convMandarinCase.UserTypeId].ToString().Trim(), //用户类型Id
UserTypeName = objRow[convMandarinCase.UserTypeName] == DBNull.Value ? null : objRow[convMandarinCase.UserTypeName].ToString().Trim(), //用户类型名称
RecommendedDegreeId = objRow[convMandarinCase.RecommendedDegreeId].ToString().Trim(), //推荐度Id
RecommendedDegreeName = objRow[convMandarinCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMandarinCase.RecommendedDegreeName].ToString().Trim(), //推荐度名称
ftpFileType = objRow[convMandarinCase.ftpFileType] == DBNull.Value ? null : objRow[convMandarinCase.ftpFileType].ToString().Trim(), //ftp文件类型
VideoUrl = objRow[convMandarinCase.VideoUrl] == DBNull.Value ? null : objRow[convMandarinCase.VideoUrl].ToString().Trim(), //视频Url
VideoPath = objRow[convMandarinCase.VideoPath] == DBNull.Value ? null : objRow[convMandarinCase.VideoPath].ToString().Trim(), //视频目录
ResErrMsg = objRow[convMandarinCase.ResErrMsg] == DBNull.Value ? null : objRow[convMandarinCase.ResErrMsg].ToString().Trim(), //资源错误信息
UpdDate = objRow[convMandarinCase.UpdDate] == DBNull.Value ? null : objRow[convMandarinCase.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[convMandarinCase.UpdUserId] == DBNull.Value ? null : objRow[convMandarinCase.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[convMandarinCase.Memo] == DBNull.Value ? null : objRow[convMandarinCase.Memo].ToString().Trim(), //备注
BrowseCount4Case = objRow[convMandarinCase.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMandarinCase.BrowseCount4Case].ToString().Trim()), //课例浏览次数
IsHaveVideo = objRow[convMandarinCase.IsHaveVideo].ToString().Trim(), //IsHaveVideo
OwnerNameWithId = objRow[convMandarinCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convMandarinCase.OwnerNameWithId].ToString().Trim(), //拥有者名称附Id
OwnerName = objRow[convMandarinCase.OwnerName] == DBNull.Value ? null : objRow[convMandarinCase.OwnerName].ToString().Trim() //拥有者姓名
};
objvMandarinCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvMandarinCaseEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvMandarinCaseDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvMandarinCaseEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvMandarinCaseEN objvMandarinCaseEN = new clsvMandarinCaseEN();
try
{
objvMandarinCaseEN.IdMandarinCase = objRow[convMandarinCase.IdMandarinCase].ToString().Trim(); //普通话案例流水号
objvMandarinCaseEN.MandarinCaseID = objRow[convMandarinCase.MandarinCaseID].ToString().Trim(); //普通话教学案例ID
objvMandarinCaseEN.MandarinCaseName = objRow[convMandarinCase.MandarinCaseName].ToString().Trim(); //普通话教学案例名称
objvMandarinCaseEN.IdDiscipline = objRow[convMandarinCase.IdDiscipline].ToString().Trim(); //学科流水号
objvMandarinCaseEN.DisciplineID = objRow[convMandarinCase.DisciplineID].ToString().Trim(); //学科ID
objvMandarinCaseEN.DisciplineName = objRow[convMandarinCase.DisciplineName].ToString().Trim(); //学科名称
objvMandarinCaseEN.IdStudyLevel = objRow[convMandarinCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMandarinCaseEN.StudyLevelName = objRow[convMandarinCase.StudyLevelName].ToString().Trim(); //学段名称
objvMandarinCaseEN.MandarinCaseTheme = objRow[convMandarinCase.MandarinCaseTheme] == DBNull.Value ? null : objRow[convMandarinCase.MandarinCaseTheme].ToString().Trim(); //普通话教学案例主题词
objvMandarinCaseEN.MandarinCaseDate = objRow[convMandarinCase.MandarinCaseDate] == DBNull.Value ? null : objRow[convMandarinCase.MandarinCaseDate].ToString().Trim(); //普通话教学日期
objvMandarinCaseEN.MandarinCaseTime = objRow[convMandarinCase.MandarinCaseTime] == DBNull.Value ? null : objRow[convMandarinCase.MandarinCaseTime].ToString().Trim(); //普通话教学时间
objvMandarinCaseEN.MandarinCaseDateIn = objRow[convMandarinCase.MandarinCaseDateIn] == DBNull.Value ? null : objRow[convMandarinCase.MandarinCaseDateIn].ToString().Trim(); //案例入库日期
objvMandarinCaseEN.MandarinCaseTimeIn = objRow[convMandarinCase.MandarinCaseTimeIn] == DBNull.Value ? null : objRow[convMandarinCase.MandarinCaseTimeIn].ToString().Trim(); //案例入库时间
objvMandarinCaseEN.IdTeachingPlan = objRow[convMandarinCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMandarinCaseEN.IdSenateGaugeVersion = objRow[convMandarinCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMandarinCaseEN.senateGaugeVersionID = objRow[convMandarinCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMandarinCaseEN.senateGaugeVersionName = objRow[convMandarinCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMandarinCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMandarinCaseEN.senateGaugeVersionTtlScore = TransNullToFloat(objRow[convMandarinCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMandarinCaseEN.VersionNo = objRow[convMandarinCase.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMandarinCase.VersionNo].ToString().Trim()); //版本号
objvMandarinCaseEN.CaseLevelId = objRow[convMandarinCase.CaseLevelId] == DBNull.Value ? null : objRow[convMandarinCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvMandarinCaseEN.IsNeedGeneWord = TransNullToBool(objRow[convMandarinCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvMandarinCaseEN.DocFile = objRow[convMandarinCase.DocFile] == DBNull.Value ? null : objRow[convMandarinCase.DocFile].ToString().Trim(); //生成的Word文件名
objvMandarinCaseEN.WordCreateDate = objRow[convMandarinCase.WordCreateDate] == DBNull.Value ? null : objRow[convMandarinCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvMandarinCaseEN.IsVisible = TransNullToBool(objRow[convMandarinCase.IsVisible].ToString().Trim()); //是否显示
objvMandarinCaseEN.OwnerId = objRow[convMandarinCase.OwnerId].ToString().Trim(); //拥有者Id
objvMandarinCaseEN.StuName = objRow[convMandarinCase.StuName] == DBNull.Value ? null : objRow[convMandarinCase.StuName].ToString().Trim(); //姓名
objvMandarinCaseEN.StuID = objRow[convMandarinCase.StuID] == DBNull.Value ? null : objRow[convMandarinCase.StuID].ToString().Trim(); //学号
objvMandarinCaseEN.CollegeID = objRow[convMandarinCase.CollegeID] == DBNull.Value ? null : objRow[convMandarinCase.CollegeID].ToString().Trim(); //学院ID
objvMandarinCaseEN.CollegeName = objRow[convMandarinCase.CollegeName].ToString().Trim(); //学院名称
objvMandarinCaseEN.IdXzCollege = objRow[convMandarinCase.IdXzCollege] == DBNull.Value ? null : objRow[convMandarinCase.IdXzCollege].ToString().Trim(); //学院流水号
objvMandarinCaseEN.CollegeNameA = objRow[convMandarinCase.CollegeNameA] == DBNull.Value ? null : objRow[convMandarinCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvMandarinCaseEN.IdXzMajor = objRow[convMandarinCase.IdXzMajor] == DBNull.Value ? null : objRow[convMandarinCase.IdXzMajor].ToString().Trim(); //专业流水号
objvMandarinCaseEN.MajorName = objRow[convMandarinCase.MajorName] == DBNull.Value ? null : objRow[convMandarinCase.MajorName].ToString().Trim(); //专业名称
objvMandarinCaseEN.IdGradeBase = objRow[convMandarinCase.IdGradeBase] == DBNull.Value ? null : objRow[convMandarinCase.IdGradeBase].ToString().Trim(); //年级流水号
objvMandarinCaseEN.GradeBaseName = objRow[convMandarinCase.GradeBaseName] == DBNull.Value ? null : objRow[convMandarinCase.GradeBaseName].ToString().Trim(); //年级名称
objvMandarinCaseEN.IdAdminCls = objRow[convMandarinCase.IdAdminCls] == DBNull.Value ? null : objRow[convMandarinCase.IdAdminCls].ToString().Trim(); //行政班流水号
objvMandarinCaseEN.IsDualVideo = TransNullToBool(objRow[convMandarinCase.IsDualVideo].ToString().Trim()); //是否双视频
objvMandarinCaseEN.IdMandarinCaseType = objRow[convMandarinCase.IdMandarinCaseType].ToString().Trim(); //普通话案例类型流水号
objvMandarinCaseEN.MandarinCaseTypeName = objRow[convMandarinCase.MandarinCaseTypeName] == DBNull.Value ? null : objRow[convMandarinCase.MandarinCaseTypeName].ToString().Trim(); //普通话案例类型名称
objvMandarinCaseEN.UserTypeId = objRow[convMandarinCase.UserTypeId] == DBNull.Value ? null : objRow[convMandarinCase.UserTypeId].ToString().Trim(); //用户类型Id
objvMandarinCaseEN.UserTypeName = objRow[convMandarinCase.UserTypeName] == DBNull.Value ? null : objRow[convMandarinCase.UserTypeName].ToString().Trim(); //用户类型名称
objvMandarinCaseEN.RecommendedDegreeId = objRow[convMandarinCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMandarinCaseEN.RecommendedDegreeName = objRow[convMandarinCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMandarinCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMandarinCaseEN.ftpFileType = objRow[convMandarinCase.ftpFileType] == DBNull.Value ? null : objRow[convMandarinCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvMandarinCaseEN.VideoUrl = objRow[convMandarinCase.VideoUrl] == DBNull.Value ? null : objRow[convMandarinCase.VideoUrl].ToString().Trim(); //视频Url
objvMandarinCaseEN.VideoPath = objRow[convMandarinCase.VideoPath] == DBNull.Value ? null : objRow[convMandarinCase.VideoPath].ToString().Trim(); //视频目录
objvMandarinCaseEN.ResErrMsg = objRow[convMandarinCase.ResErrMsg] == DBNull.Value ? null : objRow[convMandarinCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvMandarinCaseEN.UpdDate = objRow[convMandarinCase.UpdDate] == DBNull.Value ? null : objRow[convMandarinCase.UpdDate].ToString().Trim(); //修改日期
objvMandarinCaseEN.UpdUserId = objRow[convMandarinCase.UpdUserId] == DBNull.Value ? null : objRow[convMandarinCase.UpdUserId].ToString().Trim(); //修改用户Id
objvMandarinCaseEN.Memo = objRow[convMandarinCase.Memo] == DBNull.Value ? null : objRow[convMandarinCase.Memo].ToString().Trim(); //备注
objvMandarinCaseEN.BrowseCount4Case = objRow[convMandarinCase.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMandarinCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMandarinCaseEN.IsHaveVideo = objRow[convMandarinCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
objvMandarinCaseEN.OwnerNameWithId = objRow[convMandarinCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convMandarinCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMandarinCaseEN.OwnerName = objRow[convMandarinCase.OwnerName] == DBNull.Value ? null : objRow[convMandarinCase.OwnerName].ToString().Trim(); //拥有者姓名
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvMandarinCaseDA: GetObjByDataRowvMandarinCase)", objException.Message));
}
objvMandarinCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvMandarinCaseEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvMandarinCaseEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvMandarinCaseEN objvMandarinCaseEN = new clsvMandarinCaseEN();
try
{
objvMandarinCaseEN.IdMandarinCase = objRow[convMandarinCase.IdMandarinCase].ToString().Trim(); //普通话案例流水号
objvMandarinCaseEN.MandarinCaseID = objRow[convMandarinCase.MandarinCaseID].ToString().Trim(); //普通话教学案例ID
objvMandarinCaseEN.MandarinCaseName = objRow[convMandarinCase.MandarinCaseName].ToString().Trim(); //普通话教学案例名称
objvMandarinCaseEN.IdDiscipline = objRow[convMandarinCase.IdDiscipline].ToString().Trim(); //学科流水号
objvMandarinCaseEN.DisciplineID = objRow[convMandarinCase.DisciplineID].ToString().Trim(); //学科ID
objvMandarinCaseEN.DisciplineName = objRow[convMandarinCase.DisciplineName].ToString().Trim(); //学科名称
objvMandarinCaseEN.IdStudyLevel = objRow[convMandarinCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMandarinCaseEN.StudyLevelName = objRow[convMandarinCase.StudyLevelName].ToString().Trim(); //学段名称
objvMandarinCaseEN.MandarinCaseTheme = objRow[convMandarinCase.MandarinCaseTheme] == DBNull.Value ? null : objRow[convMandarinCase.MandarinCaseTheme].ToString().Trim(); //普通话教学案例主题词
objvMandarinCaseEN.MandarinCaseDate = objRow[convMandarinCase.MandarinCaseDate] == DBNull.Value ? null : objRow[convMandarinCase.MandarinCaseDate].ToString().Trim(); //普通话教学日期
objvMandarinCaseEN.MandarinCaseTime = objRow[convMandarinCase.MandarinCaseTime] == DBNull.Value ? null : objRow[convMandarinCase.MandarinCaseTime].ToString().Trim(); //普通话教学时间
objvMandarinCaseEN.MandarinCaseDateIn = objRow[convMandarinCase.MandarinCaseDateIn] == DBNull.Value ? null : objRow[convMandarinCase.MandarinCaseDateIn].ToString().Trim(); //案例入库日期
objvMandarinCaseEN.MandarinCaseTimeIn = objRow[convMandarinCase.MandarinCaseTimeIn] == DBNull.Value ? null : objRow[convMandarinCase.MandarinCaseTimeIn].ToString().Trim(); //案例入库时间
objvMandarinCaseEN.IdTeachingPlan = objRow[convMandarinCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMandarinCaseEN.IdSenateGaugeVersion = objRow[convMandarinCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMandarinCaseEN.senateGaugeVersionID = objRow[convMandarinCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMandarinCaseEN.senateGaugeVersionName = objRow[convMandarinCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMandarinCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMandarinCaseEN.senateGaugeVersionTtlScore = TransNullToFloat(objRow[convMandarinCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMandarinCaseEN.VersionNo = objRow[convMandarinCase.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMandarinCase.VersionNo].ToString().Trim()); //版本号
objvMandarinCaseEN.CaseLevelId = objRow[convMandarinCase.CaseLevelId] == DBNull.Value ? null : objRow[convMandarinCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvMandarinCaseEN.IsNeedGeneWord = TransNullToBool(objRow[convMandarinCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvMandarinCaseEN.DocFile = objRow[convMandarinCase.DocFile] == DBNull.Value ? null : objRow[convMandarinCase.DocFile].ToString().Trim(); //生成的Word文件名
objvMandarinCaseEN.WordCreateDate = objRow[convMandarinCase.WordCreateDate] == DBNull.Value ? null : objRow[convMandarinCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvMandarinCaseEN.IsVisible = TransNullToBool(objRow[convMandarinCase.IsVisible].ToString().Trim()); //是否显示
objvMandarinCaseEN.OwnerId = objRow[convMandarinCase.OwnerId].ToString().Trim(); //拥有者Id
objvMandarinCaseEN.StuName = objRow[convMandarinCase.StuName] == DBNull.Value ? null : objRow[convMandarinCase.StuName].ToString().Trim(); //姓名
objvMandarinCaseEN.StuID = objRow[convMandarinCase.StuID] == DBNull.Value ? null : objRow[convMandarinCase.StuID].ToString().Trim(); //学号
objvMandarinCaseEN.CollegeID = objRow[convMandarinCase.CollegeID] == DBNull.Value ? null : objRow[convMandarinCase.CollegeID].ToString().Trim(); //学院ID
objvMandarinCaseEN.CollegeName = objRow[convMandarinCase.CollegeName].ToString().Trim(); //学院名称
objvMandarinCaseEN.IdXzCollege = objRow[convMandarinCase.IdXzCollege] == DBNull.Value ? null : objRow[convMandarinCase.IdXzCollege].ToString().Trim(); //学院流水号
objvMandarinCaseEN.CollegeNameA = objRow[convMandarinCase.CollegeNameA] == DBNull.Value ? null : objRow[convMandarinCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvMandarinCaseEN.IdXzMajor = objRow[convMandarinCase.IdXzMajor] == DBNull.Value ? null : objRow[convMandarinCase.IdXzMajor].ToString().Trim(); //专业流水号
objvMandarinCaseEN.MajorName = objRow[convMandarinCase.MajorName] == DBNull.Value ? null : objRow[convMandarinCase.MajorName].ToString().Trim(); //专业名称
objvMandarinCaseEN.IdGradeBase = objRow[convMandarinCase.IdGradeBase] == DBNull.Value ? null : objRow[convMandarinCase.IdGradeBase].ToString().Trim(); //年级流水号
objvMandarinCaseEN.GradeBaseName = objRow[convMandarinCase.GradeBaseName] == DBNull.Value ? null : objRow[convMandarinCase.GradeBaseName].ToString().Trim(); //年级名称
objvMandarinCaseEN.IdAdminCls = objRow[convMandarinCase.IdAdminCls] == DBNull.Value ? null : objRow[convMandarinCase.IdAdminCls].ToString().Trim(); //行政班流水号
objvMandarinCaseEN.IsDualVideo = TransNullToBool(objRow[convMandarinCase.IsDualVideo].ToString().Trim()); //是否双视频
objvMandarinCaseEN.IdMandarinCaseType = objRow[convMandarinCase.IdMandarinCaseType].ToString().Trim(); //普通话案例类型流水号
objvMandarinCaseEN.MandarinCaseTypeName = objRow[convMandarinCase.MandarinCaseTypeName] == DBNull.Value ? null : objRow[convMandarinCase.MandarinCaseTypeName].ToString().Trim(); //普通话案例类型名称
objvMandarinCaseEN.UserTypeId = objRow[convMandarinCase.UserTypeId] == DBNull.Value ? null : objRow[convMandarinCase.UserTypeId].ToString().Trim(); //用户类型Id
objvMandarinCaseEN.UserTypeName = objRow[convMandarinCase.UserTypeName] == DBNull.Value ? null : objRow[convMandarinCase.UserTypeName].ToString().Trim(); //用户类型名称
objvMandarinCaseEN.RecommendedDegreeId = objRow[convMandarinCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMandarinCaseEN.RecommendedDegreeName = objRow[convMandarinCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMandarinCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMandarinCaseEN.ftpFileType = objRow[convMandarinCase.ftpFileType] == DBNull.Value ? null : objRow[convMandarinCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvMandarinCaseEN.VideoUrl = objRow[convMandarinCase.VideoUrl] == DBNull.Value ? null : objRow[convMandarinCase.VideoUrl].ToString().Trim(); //视频Url
objvMandarinCaseEN.VideoPath = objRow[convMandarinCase.VideoPath] == DBNull.Value ? null : objRow[convMandarinCase.VideoPath].ToString().Trim(); //视频目录
objvMandarinCaseEN.ResErrMsg = objRow[convMandarinCase.ResErrMsg] == DBNull.Value ? null : objRow[convMandarinCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvMandarinCaseEN.UpdDate = objRow[convMandarinCase.UpdDate] == DBNull.Value ? null : objRow[convMandarinCase.UpdDate].ToString().Trim(); //修改日期
objvMandarinCaseEN.UpdUserId = objRow[convMandarinCase.UpdUserId] == DBNull.Value ? null : objRow[convMandarinCase.UpdUserId].ToString().Trim(); //修改用户Id
objvMandarinCaseEN.Memo = objRow[convMandarinCase.Memo] == DBNull.Value ? null : objRow[convMandarinCase.Memo].ToString().Trim(); //备注
objvMandarinCaseEN.BrowseCount4Case = objRow[convMandarinCase.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMandarinCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMandarinCaseEN.IsHaveVideo = objRow[convMandarinCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
objvMandarinCaseEN.OwnerNameWithId = objRow[convMandarinCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convMandarinCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMandarinCaseEN.OwnerName = objRow[convMandarinCase.OwnerName] == DBNull.Value ? null : objRow[convMandarinCase.OwnerName].ToString().Trim(); //拥有者姓名
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvMandarinCaseDA: GetObjByDataRow)", objException.Message));
}
objvMandarinCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvMandarinCaseEN;
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
objSQL = clsvMandarinCaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvMandarinCaseEN._CurrTabName, convMandarinCase.IdMandarinCase, 8, "");
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
objSQL = clsvMandarinCaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvMandarinCaseEN._CurrTabName, convMandarinCase.IdMandarinCase, 8, strPrefix);
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
 objSQL = clsvMandarinCaseDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdMandarinCase from vMandarinCase where " + strCondition;
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
 objSQL = clsvMandarinCaseDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdMandarinCase from vMandarinCase where " + strCondition;
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
 /// <param name = "strIdMandarinCase">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strIdMandarinCase)
{
CheckPrimaryKey(strIdMandarinCase);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMandarinCaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vMandarinCase", "IdMandarinCase = " + "'"+ strIdMandarinCase+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvMandarinCaseDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMandarinCaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vMandarinCase", strCondition))
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
objSQL = clsvMandarinCaseDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vMandarinCase");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvMandarinCaseENS">源对象</param>
 /// <param name = "objvMandarinCaseENT">目标对象</param>
public void CopyTo(clsvMandarinCaseEN objvMandarinCaseENS, clsvMandarinCaseEN objvMandarinCaseENT)
{
objvMandarinCaseENT.IdMandarinCase = objvMandarinCaseENS.IdMandarinCase; //普通话案例流水号
objvMandarinCaseENT.MandarinCaseID = objvMandarinCaseENS.MandarinCaseID; //普通话教学案例ID
objvMandarinCaseENT.MandarinCaseName = objvMandarinCaseENS.MandarinCaseName; //普通话教学案例名称
objvMandarinCaseENT.IdDiscipline = objvMandarinCaseENS.IdDiscipline; //学科流水号
objvMandarinCaseENT.DisciplineID = objvMandarinCaseENS.DisciplineID; //学科ID
objvMandarinCaseENT.DisciplineName = objvMandarinCaseENS.DisciplineName; //学科名称
objvMandarinCaseENT.IdStudyLevel = objvMandarinCaseENS.IdStudyLevel; //id_StudyLevel
objvMandarinCaseENT.StudyLevelName = objvMandarinCaseENS.StudyLevelName; //学段名称
objvMandarinCaseENT.MandarinCaseTheme = objvMandarinCaseENS.MandarinCaseTheme; //普通话教学案例主题词
objvMandarinCaseENT.MandarinCaseDate = objvMandarinCaseENS.MandarinCaseDate; //普通话教学日期
objvMandarinCaseENT.MandarinCaseTime = objvMandarinCaseENS.MandarinCaseTime; //普通话教学时间
objvMandarinCaseENT.MandarinCaseDateIn = objvMandarinCaseENS.MandarinCaseDateIn; //案例入库日期
objvMandarinCaseENT.MandarinCaseTimeIn = objvMandarinCaseENS.MandarinCaseTimeIn; //案例入库时间
objvMandarinCaseENT.IdTeachingPlan = objvMandarinCaseENS.IdTeachingPlan; //教案流水号
objvMandarinCaseENT.IdSenateGaugeVersion = objvMandarinCaseENS.IdSenateGaugeVersion; //评价量表版本流水号
objvMandarinCaseENT.senateGaugeVersionID = objvMandarinCaseENS.senateGaugeVersionID; //评价量表版本ID
objvMandarinCaseENT.senateGaugeVersionName = objvMandarinCaseENS.senateGaugeVersionName; //评价量表版本名称
objvMandarinCaseENT.senateGaugeVersionTtlScore = objvMandarinCaseENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvMandarinCaseENT.VersionNo = objvMandarinCaseENS.VersionNo; //版本号
objvMandarinCaseENT.CaseLevelId = objvMandarinCaseENS.CaseLevelId; //课例等级Id
objvMandarinCaseENT.IsNeedGeneWord = objvMandarinCaseENS.IsNeedGeneWord; //是否需要生成Word
objvMandarinCaseENT.DocFile = objvMandarinCaseENS.DocFile; //生成的Word文件名
objvMandarinCaseENT.WordCreateDate = objvMandarinCaseENS.WordCreateDate; //Word生成日期
objvMandarinCaseENT.IsVisible = objvMandarinCaseENS.IsVisible; //是否显示
objvMandarinCaseENT.OwnerId = objvMandarinCaseENS.OwnerId; //拥有者Id
objvMandarinCaseENT.StuName = objvMandarinCaseENS.StuName; //姓名
objvMandarinCaseENT.StuID = objvMandarinCaseENS.StuID; //学号
objvMandarinCaseENT.CollegeID = objvMandarinCaseENS.CollegeID; //学院ID
objvMandarinCaseENT.CollegeName = objvMandarinCaseENS.CollegeName; //学院名称
objvMandarinCaseENT.IdXzCollege = objvMandarinCaseENS.IdXzCollege; //学院流水号
objvMandarinCaseENT.CollegeNameA = objvMandarinCaseENS.CollegeNameA; //学院名称简写
objvMandarinCaseENT.IdXzMajor = objvMandarinCaseENS.IdXzMajor; //专业流水号
objvMandarinCaseENT.MajorName = objvMandarinCaseENS.MajorName; //专业名称
objvMandarinCaseENT.IdGradeBase = objvMandarinCaseENS.IdGradeBase; //年级流水号
objvMandarinCaseENT.GradeBaseName = objvMandarinCaseENS.GradeBaseName; //年级名称
objvMandarinCaseENT.IdAdminCls = objvMandarinCaseENS.IdAdminCls; //行政班流水号
objvMandarinCaseENT.IsDualVideo = objvMandarinCaseENS.IsDualVideo; //是否双视频
objvMandarinCaseENT.IdMandarinCaseType = objvMandarinCaseENS.IdMandarinCaseType; //普通话案例类型流水号
objvMandarinCaseENT.MandarinCaseTypeName = objvMandarinCaseENS.MandarinCaseTypeName; //普通话案例类型名称
objvMandarinCaseENT.UserTypeId = objvMandarinCaseENS.UserTypeId; //用户类型Id
objvMandarinCaseENT.UserTypeName = objvMandarinCaseENS.UserTypeName; //用户类型名称
objvMandarinCaseENT.RecommendedDegreeId = objvMandarinCaseENS.RecommendedDegreeId; //推荐度Id
objvMandarinCaseENT.RecommendedDegreeName = objvMandarinCaseENS.RecommendedDegreeName; //推荐度名称
objvMandarinCaseENT.ftpFileType = objvMandarinCaseENS.ftpFileType; //ftp文件类型
objvMandarinCaseENT.VideoUrl = objvMandarinCaseENS.VideoUrl; //视频Url
objvMandarinCaseENT.VideoPath = objvMandarinCaseENS.VideoPath; //视频目录
objvMandarinCaseENT.ResErrMsg = objvMandarinCaseENS.ResErrMsg; //资源错误信息
objvMandarinCaseENT.UpdDate = objvMandarinCaseENS.UpdDate; //修改日期
objvMandarinCaseENT.UpdUserId = objvMandarinCaseENS.UpdUserId; //修改用户Id
objvMandarinCaseENT.Memo = objvMandarinCaseENS.Memo; //备注
objvMandarinCaseENT.BrowseCount4Case = objvMandarinCaseENS.BrowseCount4Case; //课例浏览次数
objvMandarinCaseENT.IsHaveVideo = objvMandarinCaseENS.IsHaveVideo; //IsHaveVideo
objvMandarinCaseENT.OwnerNameWithId = objvMandarinCaseENS.OwnerNameWithId; //拥有者名称附Id
objvMandarinCaseENT.OwnerName = objvMandarinCaseENS.OwnerName; //拥有者姓名
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvMandarinCaseEN objvMandarinCaseEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvMandarinCaseEN.IdMandarinCase, 8, convMandarinCase.IdMandarinCase);
clsCheckSql.CheckFieldLen(objvMandarinCaseEN.MandarinCaseID, 8, convMandarinCase.MandarinCaseID);
clsCheckSql.CheckFieldLen(objvMandarinCaseEN.MandarinCaseName, 100, convMandarinCase.MandarinCaseName);
clsCheckSql.CheckFieldLen(objvMandarinCaseEN.IdDiscipline, 4, convMandarinCase.IdDiscipline);
clsCheckSql.CheckFieldLen(objvMandarinCaseEN.DisciplineID, 4, convMandarinCase.DisciplineID);
clsCheckSql.CheckFieldLen(objvMandarinCaseEN.DisciplineName, 50, convMandarinCase.DisciplineName);
clsCheckSql.CheckFieldLen(objvMandarinCaseEN.IdStudyLevel, 4, convMandarinCase.IdStudyLevel);
clsCheckSql.CheckFieldLen(objvMandarinCaseEN.StudyLevelName, 50, convMandarinCase.StudyLevelName);
clsCheckSql.CheckFieldLen(objvMandarinCaseEN.MandarinCaseTheme, 200, convMandarinCase.MandarinCaseTheme);
clsCheckSql.CheckFieldLen(objvMandarinCaseEN.MandarinCaseDate, 8, convMandarinCase.MandarinCaseDate);
clsCheckSql.CheckFieldLen(objvMandarinCaseEN.MandarinCaseTime, 6, convMandarinCase.MandarinCaseTime);
clsCheckSql.CheckFieldLen(objvMandarinCaseEN.MandarinCaseDateIn, 8, convMandarinCase.MandarinCaseDateIn);
clsCheckSql.CheckFieldLen(objvMandarinCaseEN.MandarinCaseTimeIn, 6, convMandarinCase.MandarinCaseTimeIn);
clsCheckSql.CheckFieldLen(objvMandarinCaseEN.IdTeachingPlan, 8, convMandarinCase.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objvMandarinCaseEN.IdSenateGaugeVersion, 4, convMandarinCase.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objvMandarinCaseEN.senateGaugeVersionID, 4, convMandarinCase.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(objvMandarinCaseEN.senateGaugeVersionName, 200, convMandarinCase.senateGaugeVersionName);
clsCheckSql.CheckFieldLen(objvMandarinCaseEN.CaseLevelId, 2, convMandarinCase.CaseLevelId);
clsCheckSql.CheckFieldLen(objvMandarinCaseEN.DocFile, 200, convMandarinCase.DocFile);
clsCheckSql.CheckFieldLen(objvMandarinCaseEN.WordCreateDate, 14, convMandarinCase.WordCreateDate);
clsCheckSql.CheckFieldLen(objvMandarinCaseEN.OwnerId, 20, convMandarinCase.OwnerId);
clsCheckSql.CheckFieldLen(objvMandarinCaseEN.StuName, 50, convMandarinCase.StuName);
clsCheckSql.CheckFieldLen(objvMandarinCaseEN.StuID, 20, convMandarinCase.StuID);
clsCheckSql.CheckFieldLen(objvMandarinCaseEN.CollegeID, 4, convMandarinCase.CollegeID);
clsCheckSql.CheckFieldLen(objvMandarinCaseEN.CollegeName, 100, convMandarinCase.CollegeName);
clsCheckSql.CheckFieldLen(objvMandarinCaseEN.IdXzCollege, 4, convMandarinCase.IdXzCollege);
clsCheckSql.CheckFieldLen(objvMandarinCaseEN.CollegeNameA, 12, convMandarinCase.CollegeNameA);
clsCheckSql.CheckFieldLen(objvMandarinCaseEN.IdXzMajor, 8, convMandarinCase.IdXzMajor);
clsCheckSql.CheckFieldLen(objvMandarinCaseEN.MajorName, 100, convMandarinCase.MajorName);
clsCheckSql.CheckFieldLen(objvMandarinCaseEN.IdGradeBase, 4, convMandarinCase.IdGradeBase);
clsCheckSql.CheckFieldLen(objvMandarinCaseEN.GradeBaseName, 50, convMandarinCase.GradeBaseName);
clsCheckSql.CheckFieldLen(objvMandarinCaseEN.IdAdminCls, 8, convMandarinCase.IdAdminCls);
clsCheckSql.CheckFieldLen(objvMandarinCaseEN.IdMandarinCaseType, 4, convMandarinCase.IdMandarinCaseType);
clsCheckSql.CheckFieldLen(objvMandarinCaseEN.MandarinCaseTypeName, 50, convMandarinCase.MandarinCaseTypeName);
clsCheckSql.CheckFieldLen(objvMandarinCaseEN.UserTypeId, 2, convMandarinCase.UserTypeId);
clsCheckSql.CheckFieldLen(objvMandarinCaseEN.UserTypeName, 20, convMandarinCase.UserTypeName);
clsCheckSql.CheckFieldLen(objvMandarinCaseEN.RecommendedDegreeId, 2, convMandarinCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objvMandarinCaseEN.RecommendedDegreeName, 30, convMandarinCase.RecommendedDegreeName);
clsCheckSql.CheckFieldLen(objvMandarinCaseEN.ftpFileType, 30, convMandarinCase.ftpFileType);
clsCheckSql.CheckFieldLen(objvMandarinCaseEN.VideoUrl, 1000, convMandarinCase.VideoUrl);
clsCheckSql.CheckFieldLen(objvMandarinCaseEN.VideoPath, 1000, convMandarinCase.VideoPath);
clsCheckSql.CheckFieldLen(objvMandarinCaseEN.ResErrMsg, 30, convMandarinCase.ResErrMsg);
clsCheckSql.CheckFieldLen(objvMandarinCaseEN.UpdDate, 20, convMandarinCase.UpdDate);
clsCheckSql.CheckFieldLen(objvMandarinCaseEN.UpdUserId, 20, convMandarinCase.UpdUserId);
clsCheckSql.CheckFieldLen(objvMandarinCaseEN.Memo, 1000, convMandarinCase.Memo);
clsCheckSql.CheckFieldLen(objvMandarinCaseEN.IsHaveVideo, 6, convMandarinCase.IsHaveVideo);
clsCheckSql.CheckFieldLen(objvMandarinCaseEN.OwnerNameWithId, 51, convMandarinCase.OwnerNameWithId);
clsCheckSql.CheckFieldLen(objvMandarinCaseEN.OwnerName, 30, convMandarinCase.OwnerName);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseEN.IdMandarinCase, convMandarinCase.IdMandarinCase);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseEN.MandarinCaseID, convMandarinCase.MandarinCaseID);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseEN.MandarinCaseName, convMandarinCase.MandarinCaseName);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseEN.IdDiscipline, convMandarinCase.IdDiscipline);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseEN.DisciplineID, convMandarinCase.DisciplineID);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseEN.DisciplineName, convMandarinCase.DisciplineName);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseEN.IdStudyLevel, convMandarinCase.IdStudyLevel);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseEN.StudyLevelName, convMandarinCase.StudyLevelName);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseEN.MandarinCaseTheme, convMandarinCase.MandarinCaseTheme);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseEN.MandarinCaseDate, convMandarinCase.MandarinCaseDate);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseEN.MandarinCaseTime, convMandarinCase.MandarinCaseTime);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseEN.MandarinCaseDateIn, convMandarinCase.MandarinCaseDateIn);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseEN.MandarinCaseTimeIn, convMandarinCase.MandarinCaseTimeIn);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseEN.IdTeachingPlan, convMandarinCase.IdTeachingPlan);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseEN.IdSenateGaugeVersion, convMandarinCase.IdSenateGaugeVersion);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseEN.senateGaugeVersionID, convMandarinCase.senateGaugeVersionID);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseEN.senateGaugeVersionName, convMandarinCase.senateGaugeVersionName);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseEN.CaseLevelId, convMandarinCase.CaseLevelId);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseEN.DocFile, convMandarinCase.DocFile);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseEN.WordCreateDate, convMandarinCase.WordCreateDate);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseEN.OwnerId, convMandarinCase.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseEN.StuName, convMandarinCase.StuName);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseEN.StuID, convMandarinCase.StuID);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseEN.CollegeID, convMandarinCase.CollegeID);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseEN.CollegeName, convMandarinCase.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseEN.IdXzCollege, convMandarinCase.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseEN.CollegeNameA, convMandarinCase.CollegeNameA);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseEN.IdXzMajor, convMandarinCase.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseEN.MajorName, convMandarinCase.MajorName);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseEN.IdGradeBase, convMandarinCase.IdGradeBase);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseEN.GradeBaseName, convMandarinCase.GradeBaseName);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseEN.IdAdminCls, convMandarinCase.IdAdminCls);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseEN.IdMandarinCaseType, convMandarinCase.IdMandarinCaseType);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseEN.MandarinCaseTypeName, convMandarinCase.MandarinCaseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseEN.UserTypeId, convMandarinCase.UserTypeId);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseEN.UserTypeName, convMandarinCase.UserTypeName);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseEN.RecommendedDegreeId, convMandarinCase.RecommendedDegreeId);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseEN.RecommendedDegreeName, convMandarinCase.RecommendedDegreeName);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseEN.ftpFileType, convMandarinCase.ftpFileType);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseEN.VideoUrl, convMandarinCase.VideoUrl);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseEN.VideoPath, convMandarinCase.VideoPath);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseEN.ResErrMsg, convMandarinCase.ResErrMsg);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseEN.UpdDate, convMandarinCase.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseEN.UpdUserId, convMandarinCase.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseEN.Memo, convMandarinCase.Memo);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseEN.IsHaveVideo, convMandarinCase.IsHaveVideo);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseEN.OwnerNameWithId, convMandarinCase.OwnerNameWithId);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseEN.OwnerName, convMandarinCase.OwnerName);
//检查外键字段长度
 objvMandarinCaseEN._IsCheckProperty = true;
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
 objSQL = clsvMandarinCaseDA.GetSpecSQLObj();
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
 objSQL = clsvMandarinCaseDA.GetSpecSQLObj();
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
 objSQL = clsvMandarinCaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvMandarinCaseEN._CurrTabName);
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
 objSQL = clsvMandarinCaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvMandarinCaseEN._CurrTabName, strCondition);
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
 objSQL = clsvMandarinCaseDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}