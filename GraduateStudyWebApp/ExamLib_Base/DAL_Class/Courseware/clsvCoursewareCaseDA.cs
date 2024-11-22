
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCoursewareCaseDA
 表名:vCoursewareCase(01120417)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:46:04
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课件(Courseware)
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
 /// v课件教学案例(vCoursewareCase)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvCoursewareCaseDA : clsCommBase4DA
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
 return clsvCoursewareCaseEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvCoursewareCaseEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCoursewareCaseEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvCoursewareCaseEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvCoursewareCaseEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strIdCoursewareCase">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strIdCoursewareCase)
{
strIdCoursewareCase = strIdCoursewareCase.Replace("'", "''");
if (strIdCoursewareCase.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vCoursewareCase中,检查关键字,长度不正确!(clsvCoursewareCaseDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdCoursewareCase)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vCoursewareCase中,关键字不能为空 或 null!(clsvCoursewareCaseDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdCoursewareCase);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvCoursewareCaseDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvCoursewareCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCaseDA.GetSpecSQLObj();
strSQL = "Select * from vCoursewareCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vCoursewareCase(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvCoursewareCaseDA: GetDataTable_vCoursewareCase)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCaseDA.GetSpecSQLObj();
strSQL = "Select * from vCoursewareCase where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvCoursewareCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvCoursewareCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCaseDA.GetSpecSQLObj();
strSQL = "Select * from vCoursewareCase where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvCoursewareCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvCoursewareCaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCaseDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCoursewareCase where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCoursewareCase where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvCoursewareCaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCaseDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vCoursewareCase where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvCoursewareCaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vCoursewareCase.* from vCoursewareCase Left Join {1} on {2} where {3} and vCoursewareCase.IdCoursewareCase not in (Select top {5} vCoursewareCase.IdCoursewareCase from vCoursewareCase Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCoursewareCase where {1} and IdCoursewareCase not in (Select top {2} IdCoursewareCase from vCoursewareCase where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCoursewareCase where {1} and IdCoursewareCase not in (Select top {3} IdCoursewareCase from vCoursewareCase where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvCoursewareCaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vCoursewareCase.* from vCoursewareCase Left Join {1} on {2} where {3} and vCoursewareCase.IdCoursewareCase not in (Select top {5} vCoursewareCase.IdCoursewareCase from vCoursewareCase Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCoursewareCase where {1} and IdCoursewareCase not in (Select top {2} IdCoursewareCase from vCoursewareCase where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCoursewareCase where {1} and IdCoursewareCase not in (Select top {3} IdCoursewareCase from vCoursewareCase where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvCoursewareCaseEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvCoursewareCaseDA:GetObjLst)", objException.Message));
}
List<clsvCoursewareCaseEN> arrObjLst = new List<clsvCoursewareCaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCaseDA.GetSpecSQLObj();
strSQL = "Select * from vCoursewareCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCoursewareCaseEN objvCoursewareCaseEN = new clsvCoursewareCaseEN();
try
{
objvCoursewareCaseEN.IdCoursewareCase = objRow[convCoursewareCase.IdCoursewareCase].ToString().Trim(); //课件教学案例流水号
objvCoursewareCaseEN.CoursewareCaseID = objRow[convCoursewareCase.CoursewareCaseID].ToString().Trim(); //课件教学案例ID
objvCoursewareCaseEN.CoursewareCaseName = objRow[convCoursewareCase.CoursewareCaseName].ToString().Trim(); //课件教学案例名称
objvCoursewareCaseEN.CoursewareCaseTheme = objRow[convCoursewareCase.CoursewareCaseTheme] == DBNull.Value ? null : objRow[convCoursewareCase.CoursewareCaseTheme].ToString().Trim(); //课件教学案例主题词
objvCoursewareCaseEN.IdCoursewareCaseType = objRow[convCoursewareCase.IdCoursewareCaseType].ToString().Trim(); //课件案例类型流水号
objvCoursewareCaseEN.CoursewareCaseTypeName = objRow[convCoursewareCase.CoursewareCaseTypeName] == DBNull.Value ? null : objRow[convCoursewareCase.CoursewareCaseTypeName].ToString().Trim(); //课件案例类型名称
objvCoursewareCaseEN.CoursewareCaseText = objRow[convCoursewareCase.CoursewareCaseText] == DBNull.Value ? null : objRow[convCoursewareCase.CoursewareCaseText].ToString().Trim(); //案例文本内容
objvCoursewareCaseEN.CoursewareCaseDate = objRow[convCoursewareCase.CoursewareCaseDate] == DBNull.Value ? null : objRow[convCoursewareCase.CoursewareCaseDate].ToString().Trim(); //课件教学日期
objvCoursewareCaseEN.CoursewareCaseTime = objRow[convCoursewareCase.CoursewareCaseTime] == DBNull.Value ? null : objRow[convCoursewareCase.CoursewareCaseTime].ToString().Trim(); //课件教学时间
objvCoursewareCaseEN.CoursewareCaseDateIn = objRow[convCoursewareCase.CoursewareCaseDateIn] == DBNull.Value ? null : objRow[convCoursewareCase.CoursewareCaseDateIn].ToString().Trim(); //案例入库日期
objvCoursewareCaseEN.CoursewareCaseTimeIn = objRow[convCoursewareCase.CoursewareCaseTimeIn] == DBNull.Value ? null : objRow[convCoursewareCase.CoursewareCaseTimeIn].ToString().Trim(); //案例入库时间
objvCoursewareCaseEN.IdStudyLevel = objRow[convCoursewareCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCoursewareCaseEN.StudyLevelName = objRow[convCoursewareCase.StudyLevelName] == DBNull.Value ? null : objRow[convCoursewareCase.StudyLevelName].ToString().Trim(); //学段名称
objvCoursewareCaseEN.IdTeachingPlan = objRow[convCoursewareCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convCoursewareCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCoursewareCaseEN.IdCaseType = objRow[convCoursewareCase.IdCaseType] == DBNull.Value ? null : objRow[convCoursewareCase.IdCaseType].ToString().Trim(); //案例类型流水号
objvCoursewareCaseEN.IdDiscipline = objRow[convCoursewareCase.IdDiscipline].ToString().Trim(); //学科流水号
objvCoursewareCaseEN.DisciplineID = objRow[convCoursewareCase.DisciplineID] == DBNull.Value ? null : objRow[convCoursewareCase.DisciplineID].ToString().Trim(); //学科ID
objvCoursewareCaseEN.DisciplineName = objRow[convCoursewareCase.DisciplineName] == DBNull.Value ? null : objRow[convCoursewareCase.DisciplineName].ToString().Trim(); //学科名称
objvCoursewareCaseEN.IdSenateGaugeVersion = objRow[convCoursewareCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convCoursewareCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCoursewareCaseEN.senateGaugeVersionID = objRow[convCoursewareCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCoursewareCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCoursewareCaseEN.senateGaugeVersionName = objRow[convCoursewareCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCoursewareCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCoursewareCaseEN.senateGaugeVersionTtlScore = objRow[convCoursewareCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convCoursewareCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCoursewareCaseEN.VersionNo = objRow[convCoursewareCase.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareCase.VersionNo].ToString().Trim()); //版本号
objvCoursewareCaseEN.IdTeachSkill = objRow[convCoursewareCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCoursewareCaseEN.TeachSkillID = objRow[convCoursewareCase.TeachSkillID] == DBNull.Value ? null : objRow[convCoursewareCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvCoursewareCaseEN.SkillTypeName = objRow[convCoursewareCase.SkillTypeName] == DBNull.Value ? null : objRow[convCoursewareCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvCoursewareCaseEN.TeachSkillName = objRow[convCoursewareCase.TeachSkillName] == DBNull.Value ? null : objRow[convCoursewareCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvCoursewareCaseEN.TeachSkillTheory = objRow[convCoursewareCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convCoursewareCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCoursewareCaseEN.TeachSkillOperMethod = objRow[convCoursewareCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCoursewareCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCoursewareCaseEN.IdSkillType = objRow[convCoursewareCase.IdSkillType] == DBNull.Value ? null : objRow[convCoursewareCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvCoursewareCaseEN.SkillTypeID = objRow[convCoursewareCase.SkillTypeID] == DBNull.Value ? null : objRow[convCoursewareCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvCoursewareCaseEN.CaseLevelId = objRow[convCoursewareCase.CaseLevelId] == DBNull.Value ? null : objRow[convCoursewareCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvCoursewareCaseEN.CaseLevelName = objRow[convCoursewareCase.CaseLevelName] == DBNull.Value ? null : objRow[convCoursewareCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvCoursewareCaseEN.DocFile = objRow[convCoursewareCase.DocFile] == DBNull.Value ? null : objRow[convCoursewareCase.DocFile].ToString().Trim(); //生成的Word文件名
objvCoursewareCaseEN.IsNeedGeneWord = TransNullToBool(objRow[convCoursewareCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvCoursewareCaseEN.WordCreateDate = objRow[convCoursewareCase.WordCreateDate] == DBNull.Value ? null : objRow[convCoursewareCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvCoursewareCaseEN.IsVisible = TransNullToBool(objRow[convCoursewareCase.IsVisible].ToString().Trim()); //是否显示
objvCoursewareCaseEN.OwnerId = objRow[convCoursewareCase.OwnerId].ToString().Trim(); //拥有者Id
objvCoursewareCaseEN.IdStudentInfo = objRow[convCoursewareCase.IdStudentInfo] == DBNull.Value ? null : objRow[convCoursewareCase.IdStudentInfo].ToString().Trim(); //学生流水号
objvCoursewareCaseEN.StuName = objRow[convCoursewareCase.StuName] == DBNull.Value ? null : objRow[convCoursewareCase.StuName].ToString().Trim(); //姓名
objvCoursewareCaseEN.StuID = objRow[convCoursewareCase.StuID] == DBNull.Value ? null : objRow[convCoursewareCase.StuID].ToString().Trim(); //学号
objvCoursewareCaseEN.PoliticsName = objRow[convCoursewareCase.PoliticsName] == DBNull.Value ? null : objRow[convCoursewareCase.PoliticsName].ToString().Trim(); //政治面貌
objvCoursewareCaseEN.SexDesc = objRow[convCoursewareCase.SexDesc] == DBNull.Value ? null : objRow[convCoursewareCase.SexDesc].ToString().Trim(); //性别名称
objvCoursewareCaseEN.EthnicName = objRow[convCoursewareCase.EthnicName] == DBNull.Value ? null : objRow[convCoursewareCase.EthnicName].ToString().Trim(); //民族名称
objvCoursewareCaseEN.UniZoneDesc = objRow[convCoursewareCase.UniZoneDesc] == DBNull.Value ? null : objRow[convCoursewareCase.UniZoneDesc].ToString().Trim(); //校区名称
objvCoursewareCaseEN.StuTypeDesc = objRow[convCoursewareCase.StuTypeDesc] == DBNull.Value ? null : objRow[convCoursewareCase.StuTypeDesc].ToString().Trim(); //学生类别名称
objvCoursewareCaseEN.IdXzCollege = objRow[convCoursewareCase.IdXzCollege] == DBNull.Value ? null : objRow[convCoursewareCase.IdXzCollege].ToString().Trim(); //学院流水号
objvCoursewareCaseEN.CollegeID = objRow[convCoursewareCase.CollegeID] == DBNull.Value ? null : objRow[convCoursewareCase.CollegeID].ToString().Trim(); //学院ID
objvCoursewareCaseEN.CollegeName = objRow[convCoursewareCase.CollegeName] == DBNull.Value ? null : objRow[convCoursewareCase.CollegeName].ToString().Trim(); //学院名称
objvCoursewareCaseEN.CollegeNameA = objRow[convCoursewareCase.CollegeNameA] == DBNull.Value ? null : objRow[convCoursewareCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvCoursewareCaseEN.IdXzMajor = objRow[convCoursewareCase.IdXzMajor] == DBNull.Value ? null : objRow[convCoursewareCase.IdXzMajor].ToString().Trim(); //专业流水号
objvCoursewareCaseEN.MajorName = objRow[convCoursewareCase.MajorName] == DBNull.Value ? null : objRow[convCoursewareCase.MajorName].ToString().Trim(); //专业名称
objvCoursewareCaseEN.IdGradeBase = objRow[convCoursewareCase.IdGradeBase] == DBNull.Value ? null : objRow[convCoursewareCase.IdGradeBase].ToString().Trim(); //年级流水号
objvCoursewareCaseEN.GradeBaseName = objRow[convCoursewareCase.GradeBaseName] == DBNull.Value ? null : objRow[convCoursewareCase.GradeBaseName].ToString().Trim(); //年级名称
objvCoursewareCaseEN.IdAdminCls = objRow[convCoursewareCase.IdAdminCls] == DBNull.Value ? null : objRow[convCoursewareCase.IdAdminCls].ToString().Trim(); //行政班流水号
objvCoursewareCaseEN.AdminClsId = objRow[convCoursewareCase.AdminClsId] == DBNull.Value ? null : objRow[convCoursewareCase.AdminClsId].ToString().Trim(); //行政班代号
objvCoursewareCaseEN.AdminClsName = objRow[convCoursewareCase.AdminClsName] == DBNull.Value ? null : objRow[convCoursewareCase.AdminClsName].ToString().Trim(); //行政班名称
objvCoursewareCaseEN.Birthday = objRow[convCoursewareCase.Birthday] == DBNull.Value ? null : objRow[convCoursewareCase.Birthday].ToString().Trim(); //出生日期
objvCoursewareCaseEN.NativePlace = objRow[convCoursewareCase.NativePlace] == DBNull.Value ? null : objRow[convCoursewareCase.NativePlace].ToString().Trim(); //籍贯
objvCoursewareCaseEN.Duty = objRow[convCoursewareCase.Duty] == DBNull.Value ? null : objRow[convCoursewareCase.Duty].ToString().Trim(); //职位
objvCoursewareCaseEN.IDCardNo = objRow[convCoursewareCase.IDCardNo] == DBNull.Value ? null : objRow[convCoursewareCase.IDCardNo].ToString().Trim(); //身份证号
objvCoursewareCaseEN.StuCardNo = objRow[convCoursewareCase.StuCardNo] == DBNull.Value ? null : objRow[convCoursewareCase.StuCardNo].ToString().Trim(); //学生证号
objvCoursewareCaseEN.LiveAddress = objRow[convCoursewareCase.LiveAddress] == DBNull.Value ? null : objRow[convCoursewareCase.LiveAddress].ToString().Trim(); //居住地址
objvCoursewareCaseEN.HomePhone = objRow[convCoursewareCase.HomePhone] == DBNull.Value ? null : objRow[convCoursewareCase.HomePhone].ToString().Trim(); //住宅电话
objvCoursewareCaseEN.EnrollmentDate = objRow[convCoursewareCase.EnrollmentDate] == DBNull.Value ? null : objRow[convCoursewareCase.EnrollmentDate].ToString().Trim(); //入校日期
objvCoursewareCaseEN.PostCode = objRow[convCoursewareCase.PostCode] == DBNull.Value ? null : objRow[convCoursewareCase.PostCode].ToString().Trim(); //邮编
objvCoursewareCaseEN.UserKindId = objRow[convCoursewareCase.UserKindId].ToString().Trim(); //用户类别Id
objvCoursewareCaseEN.UserKindName = objRow[convCoursewareCase.UserKindName] == DBNull.Value ? null : objRow[convCoursewareCase.UserKindName].ToString().Trim(); //用户类别名
objvCoursewareCaseEN.UserTypeId = objRow[convCoursewareCase.UserTypeId] == DBNull.Value ? null : objRow[convCoursewareCase.UserTypeId].ToString().Trim(); //用户类型Id
objvCoursewareCaseEN.UserTypeName = objRow[convCoursewareCase.UserTypeName] == DBNull.Value ? null : objRow[convCoursewareCase.UserTypeName].ToString().Trim(); //用户类型名称
objvCoursewareCaseEN.IsDualVideo = TransNullToBool(objRow[convCoursewareCase.IsDualVideo].ToString().Trim()); //是否双视频
objvCoursewareCaseEN.RecommendedDegreeId = objRow[convCoursewareCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCoursewareCaseEN.RecommendedDegreeName = objRow[convCoursewareCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCoursewareCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCoursewareCaseEN.ftpFileType = objRow[convCoursewareCase.ftpFileType] == DBNull.Value ? null : objRow[convCoursewareCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvCoursewareCaseEN.VideoUrl = objRow[convCoursewareCase.VideoUrl] == DBNull.Value ? null : objRow[convCoursewareCase.VideoUrl].ToString().Trim(); //视频Url
objvCoursewareCaseEN.VideoPath = objRow[convCoursewareCase.VideoPath] == DBNull.Value ? null : objRow[convCoursewareCase.VideoPath].ToString().Trim(); //视频目录
objvCoursewareCaseEN.ResErrMsg = objRow[convCoursewareCase.ResErrMsg] == DBNull.Value ? null : objRow[convCoursewareCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvCoursewareCaseEN.Memo = objRow[convCoursewareCase.Memo] == DBNull.Value ? null : objRow[convCoursewareCase.Memo].ToString().Trim(); //备注
objvCoursewareCaseEN.OwnerName = objRow[convCoursewareCase.OwnerName] == DBNull.Value ? null : objRow[convCoursewareCase.OwnerName].ToString().Trim(); //拥有者姓名
objvCoursewareCaseEN.OwnerNameWithId = objRow[convCoursewareCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convCoursewareCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCoursewareCaseEN.BrowseCount4Case = objRow[convCoursewareCase.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCoursewareCaseEN.IsHaveVideo = objRow[convCoursewareCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCoursewareCaseDA: GetObjLst)", objException.Message));
}
objvCoursewareCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCoursewareCaseEN);
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
public List<clsvCoursewareCaseEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvCoursewareCaseDA:GetObjLstByTabName)", objException.Message));
}
List<clsvCoursewareCaseEN> arrObjLst = new List<clsvCoursewareCaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCaseDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCoursewareCaseEN objvCoursewareCaseEN = new clsvCoursewareCaseEN();
try
{
objvCoursewareCaseEN.IdCoursewareCase = objRow[convCoursewareCase.IdCoursewareCase].ToString().Trim(); //课件教学案例流水号
objvCoursewareCaseEN.CoursewareCaseID = objRow[convCoursewareCase.CoursewareCaseID].ToString().Trim(); //课件教学案例ID
objvCoursewareCaseEN.CoursewareCaseName = objRow[convCoursewareCase.CoursewareCaseName].ToString().Trim(); //课件教学案例名称
objvCoursewareCaseEN.CoursewareCaseTheme = objRow[convCoursewareCase.CoursewareCaseTheme] == DBNull.Value ? null : objRow[convCoursewareCase.CoursewareCaseTheme].ToString().Trim(); //课件教学案例主题词
objvCoursewareCaseEN.IdCoursewareCaseType = objRow[convCoursewareCase.IdCoursewareCaseType].ToString().Trim(); //课件案例类型流水号
objvCoursewareCaseEN.CoursewareCaseTypeName = objRow[convCoursewareCase.CoursewareCaseTypeName] == DBNull.Value ? null : objRow[convCoursewareCase.CoursewareCaseTypeName].ToString().Trim(); //课件案例类型名称
objvCoursewareCaseEN.CoursewareCaseText = objRow[convCoursewareCase.CoursewareCaseText] == DBNull.Value ? null : objRow[convCoursewareCase.CoursewareCaseText].ToString().Trim(); //案例文本内容
objvCoursewareCaseEN.CoursewareCaseDate = objRow[convCoursewareCase.CoursewareCaseDate] == DBNull.Value ? null : objRow[convCoursewareCase.CoursewareCaseDate].ToString().Trim(); //课件教学日期
objvCoursewareCaseEN.CoursewareCaseTime = objRow[convCoursewareCase.CoursewareCaseTime] == DBNull.Value ? null : objRow[convCoursewareCase.CoursewareCaseTime].ToString().Trim(); //课件教学时间
objvCoursewareCaseEN.CoursewareCaseDateIn = objRow[convCoursewareCase.CoursewareCaseDateIn] == DBNull.Value ? null : objRow[convCoursewareCase.CoursewareCaseDateIn].ToString().Trim(); //案例入库日期
objvCoursewareCaseEN.CoursewareCaseTimeIn = objRow[convCoursewareCase.CoursewareCaseTimeIn] == DBNull.Value ? null : objRow[convCoursewareCase.CoursewareCaseTimeIn].ToString().Trim(); //案例入库时间
objvCoursewareCaseEN.IdStudyLevel = objRow[convCoursewareCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCoursewareCaseEN.StudyLevelName = objRow[convCoursewareCase.StudyLevelName] == DBNull.Value ? null : objRow[convCoursewareCase.StudyLevelName].ToString().Trim(); //学段名称
objvCoursewareCaseEN.IdTeachingPlan = objRow[convCoursewareCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convCoursewareCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCoursewareCaseEN.IdCaseType = objRow[convCoursewareCase.IdCaseType] == DBNull.Value ? null : objRow[convCoursewareCase.IdCaseType].ToString().Trim(); //案例类型流水号
objvCoursewareCaseEN.IdDiscipline = objRow[convCoursewareCase.IdDiscipline].ToString().Trim(); //学科流水号
objvCoursewareCaseEN.DisciplineID = objRow[convCoursewareCase.DisciplineID] == DBNull.Value ? null : objRow[convCoursewareCase.DisciplineID].ToString().Trim(); //学科ID
objvCoursewareCaseEN.DisciplineName = objRow[convCoursewareCase.DisciplineName] == DBNull.Value ? null : objRow[convCoursewareCase.DisciplineName].ToString().Trim(); //学科名称
objvCoursewareCaseEN.IdSenateGaugeVersion = objRow[convCoursewareCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convCoursewareCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCoursewareCaseEN.senateGaugeVersionID = objRow[convCoursewareCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCoursewareCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCoursewareCaseEN.senateGaugeVersionName = objRow[convCoursewareCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCoursewareCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCoursewareCaseEN.senateGaugeVersionTtlScore = objRow[convCoursewareCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convCoursewareCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCoursewareCaseEN.VersionNo = objRow[convCoursewareCase.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareCase.VersionNo].ToString().Trim()); //版本号
objvCoursewareCaseEN.IdTeachSkill = objRow[convCoursewareCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCoursewareCaseEN.TeachSkillID = objRow[convCoursewareCase.TeachSkillID] == DBNull.Value ? null : objRow[convCoursewareCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvCoursewareCaseEN.SkillTypeName = objRow[convCoursewareCase.SkillTypeName] == DBNull.Value ? null : objRow[convCoursewareCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvCoursewareCaseEN.TeachSkillName = objRow[convCoursewareCase.TeachSkillName] == DBNull.Value ? null : objRow[convCoursewareCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvCoursewareCaseEN.TeachSkillTheory = objRow[convCoursewareCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convCoursewareCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCoursewareCaseEN.TeachSkillOperMethod = objRow[convCoursewareCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCoursewareCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCoursewareCaseEN.IdSkillType = objRow[convCoursewareCase.IdSkillType] == DBNull.Value ? null : objRow[convCoursewareCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvCoursewareCaseEN.SkillTypeID = objRow[convCoursewareCase.SkillTypeID] == DBNull.Value ? null : objRow[convCoursewareCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvCoursewareCaseEN.CaseLevelId = objRow[convCoursewareCase.CaseLevelId] == DBNull.Value ? null : objRow[convCoursewareCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvCoursewareCaseEN.CaseLevelName = objRow[convCoursewareCase.CaseLevelName] == DBNull.Value ? null : objRow[convCoursewareCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvCoursewareCaseEN.DocFile = objRow[convCoursewareCase.DocFile] == DBNull.Value ? null : objRow[convCoursewareCase.DocFile].ToString().Trim(); //生成的Word文件名
objvCoursewareCaseEN.IsNeedGeneWord = TransNullToBool(objRow[convCoursewareCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvCoursewareCaseEN.WordCreateDate = objRow[convCoursewareCase.WordCreateDate] == DBNull.Value ? null : objRow[convCoursewareCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvCoursewareCaseEN.IsVisible = TransNullToBool(objRow[convCoursewareCase.IsVisible].ToString().Trim()); //是否显示
objvCoursewareCaseEN.OwnerId = objRow[convCoursewareCase.OwnerId].ToString().Trim(); //拥有者Id
objvCoursewareCaseEN.IdStudentInfo = objRow[convCoursewareCase.IdStudentInfo] == DBNull.Value ? null : objRow[convCoursewareCase.IdStudentInfo].ToString().Trim(); //学生流水号
objvCoursewareCaseEN.StuName = objRow[convCoursewareCase.StuName] == DBNull.Value ? null : objRow[convCoursewareCase.StuName].ToString().Trim(); //姓名
objvCoursewareCaseEN.StuID = objRow[convCoursewareCase.StuID] == DBNull.Value ? null : objRow[convCoursewareCase.StuID].ToString().Trim(); //学号
objvCoursewareCaseEN.PoliticsName = objRow[convCoursewareCase.PoliticsName] == DBNull.Value ? null : objRow[convCoursewareCase.PoliticsName].ToString().Trim(); //政治面貌
objvCoursewareCaseEN.SexDesc = objRow[convCoursewareCase.SexDesc] == DBNull.Value ? null : objRow[convCoursewareCase.SexDesc].ToString().Trim(); //性别名称
objvCoursewareCaseEN.EthnicName = objRow[convCoursewareCase.EthnicName] == DBNull.Value ? null : objRow[convCoursewareCase.EthnicName].ToString().Trim(); //民族名称
objvCoursewareCaseEN.UniZoneDesc = objRow[convCoursewareCase.UniZoneDesc] == DBNull.Value ? null : objRow[convCoursewareCase.UniZoneDesc].ToString().Trim(); //校区名称
objvCoursewareCaseEN.StuTypeDesc = objRow[convCoursewareCase.StuTypeDesc] == DBNull.Value ? null : objRow[convCoursewareCase.StuTypeDesc].ToString().Trim(); //学生类别名称
objvCoursewareCaseEN.IdXzCollege = objRow[convCoursewareCase.IdXzCollege] == DBNull.Value ? null : objRow[convCoursewareCase.IdXzCollege].ToString().Trim(); //学院流水号
objvCoursewareCaseEN.CollegeID = objRow[convCoursewareCase.CollegeID] == DBNull.Value ? null : objRow[convCoursewareCase.CollegeID].ToString().Trim(); //学院ID
objvCoursewareCaseEN.CollegeName = objRow[convCoursewareCase.CollegeName] == DBNull.Value ? null : objRow[convCoursewareCase.CollegeName].ToString().Trim(); //学院名称
objvCoursewareCaseEN.CollegeNameA = objRow[convCoursewareCase.CollegeNameA] == DBNull.Value ? null : objRow[convCoursewareCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvCoursewareCaseEN.IdXzMajor = objRow[convCoursewareCase.IdXzMajor] == DBNull.Value ? null : objRow[convCoursewareCase.IdXzMajor].ToString().Trim(); //专业流水号
objvCoursewareCaseEN.MajorName = objRow[convCoursewareCase.MajorName] == DBNull.Value ? null : objRow[convCoursewareCase.MajorName].ToString().Trim(); //专业名称
objvCoursewareCaseEN.IdGradeBase = objRow[convCoursewareCase.IdGradeBase] == DBNull.Value ? null : objRow[convCoursewareCase.IdGradeBase].ToString().Trim(); //年级流水号
objvCoursewareCaseEN.GradeBaseName = objRow[convCoursewareCase.GradeBaseName] == DBNull.Value ? null : objRow[convCoursewareCase.GradeBaseName].ToString().Trim(); //年级名称
objvCoursewareCaseEN.IdAdminCls = objRow[convCoursewareCase.IdAdminCls] == DBNull.Value ? null : objRow[convCoursewareCase.IdAdminCls].ToString().Trim(); //行政班流水号
objvCoursewareCaseEN.AdminClsId = objRow[convCoursewareCase.AdminClsId] == DBNull.Value ? null : objRow[convCoursewareCase.AdminClsId].ToString().Trim(); //行政班代号
objvCoursewareCaseEN.AdminClsName = objRow[convCoursewareCase.AdminClsName] == DBNull.Value ? null : objRow[convCoursewareCase.AdminClsName].ToString().Trim(); //行政班名称
objvCoursewareCaseEN.Birthday = objRow[convCoursewareCase.Birthday] == DBNull.Value ? null : objRow[convCoursewareCase.Birthday].ToString().Trim(); //出生日期
objvCoursewareCaseEN.NativePlace = objRow[convCoursewareCase.NativePlace] == DBNull.Value ? null : objRow[convCoursewareCase.NativePlace].ToString().Trim(); //籍贯
objvCoursewareCaseEN.Duty = objRow[convCoursewareCase.Duty] == DBNull.Value ? null : objRow[convCoursewareCase.Duty].ToString().Trim(); //职位
objvCoursewareCaseEN.IDCardNo = objRow[convCoursewareCase.IDCardNo] == DBNull.Value ? null : objRow[convCoursewareCase.IDCardNo].ToString().Trim(); //身份证号
objvCoursewareCaseEN.StuCardNo = objRow[convCoursewareCase.StuCardNo] == DBNull.Value ? null : objRow[convCoursewareCase.StuCardNo].ToString().Trim(); //学生证号
objvCoursewareCaseEN.LiveAddress = objRow[convCoursewareCase.LiveAddress] == DBNull.Value ? null : objRow[convCoursewareCase.LiveAddress].ToString().Trim(); //居住地址
objvCoursewareCaseEN.HomePhone = objRow[convCoursewareCase.HomePhone] == DBNull.Value ? null : objRow[convCoursewareCase.HomePhone].ToString().Trim(); //住宅电话
objvCoursewareCaseEN.EnrollmentDate = objRow[convCoursewareCase.EnrollmentDate] == DBNull.Value ? null : objRow[convCoursewareCase.EnrollmentDate].ToString().Trim(); //入校日期
objvCoursewareCaseEN.PostCode = objRow[convCoursewareCase.PostCode] == DBNull.Value ? null : objRow[convCoursewareCase.PostCode].ToString().Trim(); //邮编
objvCoursewareCaseEN.UserKindId = objRow[convCoursewareCase.UserKindId].ToString().Trim(); //用户类别Id
objvCoursewareCaseEN.UserKindName = objRow[convCoursewareCase.UserKindName] == DBNull.Value ? null : objRow[convCoursewareCase.UserKindName].ToString().Trim(); //用户类别名
objvCoursewareCaseEN.UserTypeId = objRow[convCoursewareCase.UserTypeId] == DBNull.Value ? null : objRow[convCoursewareCase.UserTypeId].ToString().Trim(); //用户类型Id
objvCoursewareCaseEN.UserTypeName = objRow[convCoursewareCase.UserTypeName] == DBNull.Value ? null : objRow[convCoursewareCase.UserTypeName].ToString().Trim(); //用户类型名称
objvCoursewareCaseEN.IsDualVideo = TransNullToBool(objRow[convCoursewareCase.IsDualVideo].ToString().Trim()); //是否双视频
objvCoursewareCaseEN.RecommendedDegreeId = objRow[convCoursewareCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCoursewareCaseEN.RecommendedDegreeName = objRow[convCoursewareCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCoursewareCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCoursewareCaseEN.ftpFileType = objRow[convCoursewareCase.ftpFileType] == DBNull.Value ? null : objRow[convCoursewareCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvCoursewareCaseEN.VideoUrl = objRow[convCoursewareCase.VideoUrl] == DBNull.Value ? null : objRow[convCoursewareCase.VideoUrl].ToString().Trim(); //视频Url
objvCoursewareCaseEN.VideoPath = objRow[convCoursewareCase.VideoPath] == DBNull.Value ? null : objRow[convCoursewareCase.VideoPath].ToString().Trim(); //视频目录
objvCoursewareCaseEN.ResErrMsg = objRow[convCoursewareCase.ResErrMsg] == DBNull.Value ? null : objRow[convCoursewareCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvCoursewareCaseEN.Memo = objRow[convCoursewareCase.Memo] == DBNull.Value ? null : objRow[convCoursewareCase.Memo].ToString().Trim(); //备注
objvCoursewareCaseEN.OwnerName = objRow[convCoursewareCase.OwnerName] == DBNull.Value ? null : objRow[convCoursewareCase.OwnerName].ToString().Trim(); //拥有者姓名
objvCoursewareCaseEN.OwnerNameWithId = objRow[convCoursewareCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convCoursewareCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCoursewareCaseEN.BrowseCount4Case = objRow[convCoursewareCase.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCoursewareCaseEN.IsHaveVideo = objRow[convCoursewareCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCoursewareCaseDA: GetObjLst)", objException.Message));
}
objvCoursewareCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCoursewareCaseEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvCoursewareCaseEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvCoursewareCase(ref clsvCoursewareCaseEN objvCoursewareCaseEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCaseDA.GetSpecSQLObj();
strSQL = "Select * from vCoursewareCase where IdCoursewareCase = " + "'"+ objvCoursewareCaseEN.IdCoursewareCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvCoursewareCaseEN.IdCoursewareCase = objDT.Rows[0][convCoursewareCase.IdCoursewareCase].ToString().Trim(); //课件教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareCaseEN.CoursewareCaseID = objDT.Rows[0][convCoursewareCase.CoursewareCaseID].ToString().Trim(); //课件教学案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareCaseEN.CoursewareCaseName = objDT.Rows[0][convCoursewareCase.CoursewareCaseName].ToString().Trim(); //课件教学案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCoursewareCaseEN.CoursewareCaseTheme = objDT.Rows[0][convCoursewareCase.CoursewareCaseTheme].ToString().Trim(); //课件教学案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareCaseEN.IdCoursewareCaseType = objDT.Rows[0][convCoursewareCase.IdCoursewareCaseType].ToString().Trim(); //课件案例类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareCaseEN.CoursewareCaseTypeName = objDT.Rows[0][convCoursewareCase.CoursewareCaseTypeName].ToString().Trim(); //课件案例类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareCaseEN.CoursewareCaseText = objDT.Rows[0][convCoursewareCase.CoursewareCaseText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objvCoursewareCaseEN.CoursewareCaseDate = objDT.Rows[0][convCoursewareCase.CoursewareCaseDate].ToString().Trim(); //课件教学日期(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareCaseEN.CoursewareCaseTime = objDT.Rows[0][convCoursewareCase.CoursewareCaseTime].ToString().Trim(); //课件教学时间(字段类型:char,字段长度:6,是否可空:True)
 objvCoursewareCaseEN.CoursewareCaseDateIn = objDT.Rows[0][convCoursewareCase.CoursewareCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareCaseEN.CoursewareCaseTimeIn = objDT.Rows[0][convCoursewareCase.CoursewareCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvCoursewareCaseEN.IdStudyLevel = objDT.Rows[0][convCoursewareCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvCoursewareCaseEN.StudyLevelName = objDT.Rows[0][convCoursewareCase.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareCaseEN.IdTeachingPlan = objDT.Rows[0][convCoursewareCase.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareCaseEN.IdCaseType = objDT.Rows[0][convCoursewareCase.IdCaseType].ToString().Trim(); //案例类型流水号(字段类型:char,字段长度:4,是否可空:True)
 objvCoursewareCaseEN.IdDiscipline = objDT.Rows[0][convCoursewareCase.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareCaseEN.DisciplineID = objDT.Rows[0][convCoursewareCase.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareCaseEN.DisciplineName = objDT.Rows[0][convCoursewareCase.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareCaseEN.IdSenateGaugeVersion = objDT.Rows[0][convCoursewareCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareCaseEN.senateGaugeVersionID = objDT.Rows[0][convCoursewareCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareCaseEN.senateGaugeVersionName = objDT.Rows[0][convCoursewareCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareCaseEN.senateGaugeVersionTtlScore = TransNullToFloat(objDT.Rows[0][convCoursewareCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvCoursewareCaseEN.VersionNo = TransNullToInt(objDT.Rows[0][convCoursewareCase.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvCoursewareCaseEN.IdTeachSkill = objDT.Rows[0][convCoursewareCase.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareCaseEN.TeachSkillID = objDT.Rows[0][convCoursewareCase.TeachSkillID].ToString().Trim(); //教学技能ID(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareCaseEN.SkillTypeName = objDT.Rows[0][convCoursewareCase.SkillTypeName].ToString().Trim(); //技能类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareCaseEN.TeachSkillName = objDT.Rows[0][convCoursewareCase.TeachSkillName].ToString().Trim(); //教学技能名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareCaseEN.TeachSkillTheory = objDT.Rows[0][convCoursewareCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvCoursewareCaseEN.TeachSkillOperMethod = objDT.Rows[0][convCoursewareCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法(字段类型:varchar,字段长度:2000,是否可空:True)
 objvCoursewareCaseEN.IdSkillType = objDT.Rows[0][convCoursewareCase.IdSkillType].ToString().Trim(); //技能类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareCaseEN.SkillTypeID = objDT.Rows[0][convCoursewareCase.SkillTypeID].ToString().Trim(); //技能类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareCaseEN.CaseLevelId = objDT.Rows[0][convCoursewareCase.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvCoursewareCaseEN.CaseLevelName = objDT.Rows[0][convCoursewareCase.CaseLevelName].ToString().Trim(); //案例等级名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvCoursewareCaseEN.DocFile = objDT.Rows[0][convCoursewareCase.DocFile].ToString().Trim(); //生成的Word文件名(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareCaseEN.IsNeedGeneWord = TransNullToBool(objDT.Rows[0][convCoursewareCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word(字段类型:bit,字段长度:1,是否可空:True)
 objvCoursewareCaseEN.WordCreateDate = objDT.Rows[0][convCoursewareCase.WordCreateDate].ToString().Trim(); //Word生成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objvCoursewareCaseEN.IsVisible = TransNullToBool(objDT.Rows[0][convCoursewareCase.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvCoursewareCaseEN.OwnerId = objDT.Rows[0][convCoursewareCase.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvCoursewareCaseEN.IdStudentInfo = objDT.Rows[0][convCoursewareCase.IdStudentInfo].ToString().Trim(); //学生流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareCaseEN.StuName = objDT.Rows[0][convCoursewareCase.StuName].ToString().Trim(); //姓名(字段类型:varchar,字段长度:50,是否可空:True)
 objvCoursewareCaseEN.StuID = objDT.Rows[0][convCoursewareCase.StuID].ToString().Trim(); //学号(字段类型:varchar,字段长度:20,是否可空:True)
 objvCoursewareCaseEN.PoliticsName = objDT.Rows[0][convCoursewareCase.PoliticsName].ToString().Trim(); //政治面貌(字段类型:varchar,字段长度:30,是否可空:False)
 objvCoursewareCaseEN.SexDesc = objDT.Rows[0][convCoursewareCase.SexDesc].ToString().Trim(); //性别名称(字段类型:varchar,字段长度:10,是否可空:True)
 objvCoursewareCaseEN.EthnicName = objDT.Rows[0][convCoursewareCase.EthnicName].ToString().Trim(); //民族名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCoursewareCaseEN.UniZoneDesc = objDT.Rows[0][convCoursewareCase.UniZoneDesc].ToString().Trim(); //校区名称(字段类型:varchar,字段长度:20,是否可空:False)
 objvCoursewareCaseEN.StuTypeDesc = objDT.Rows[0][convCoursewareCase.StuTypeDesc].ToString().Trim(); //学生类别名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareCaseEN.IdXzCollege = objDT.Rows[0][convCoursewareCase.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvCoursewareCaseEN.CollegeID = objDT.Rows[0][convCoursewareCase.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvCoursewareCaseEN.CollegeName = objDT.Rows[0][convCoursewareCase.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCoursewareCaseEN.CollegeNameA = objDT.Rows[0][convCoursewareCase.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvCoursewareCaseEN.IdXzMajor = objDT.Rows[0][convCoursewareCase.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareCaseEN.MajorName = objDT.Rows[0][convCoursewareCase.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCoursewareCaseEN.IdGradeBase = objDT.Rows[0][convCoursewareCase.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objvCoursewareCaseEN.GradeBaseName = objDT.Rows[0][convCoursewareCase.GradeBaseName].ToString().Trim(); //年级名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareCaseEN.IdAdminCls = objDT.Rows[0][convCoursewareCase.IdAdminCls].ToString().Trim(); //行政班流水号(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareCaseEN.AdminClsId = objDT.Rows[0][convCoursewareCase.AdminClsId].ToString().Trim(); //行政班代号(字段类型:varchar,字段长度:8,是否可空:True)
 objvCoursewareCaseEN.AdminClsName = objDT.Rows[0][convCoursewareCase.AdminClsName].ToString().Trim(); //行政班名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvCoursewareCaseEN.Birthday = objDT.Rows[0][convCoursewareCase.Birthday].ToString().Trim(); //出生日期(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareCaseEN.NativePlace = objDT.Rows[0][convCoursewareCase.NativePlace].ToString().Trim(); //籍贯(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareCaseEN.Duty = objDT.Rows[0][convCoursewareCase.Duty].ToString().Trim(); //职位(字段类型:varchar,字段长度:30,是否可空:True)
 objvCoursewareCaseEN.IDCardNo = objDT.Rows[0][convCoursewareCase.IDCardNo].ToString().Trim(); //身份证号(字段类型:varchar,字段长度:20,是否可空:True)
 objvCoursewareCaseEN.StuCardNo = objDT.Rows[0][convCoursewareCase.StuCardNo].ToString().Trim(); //学生证号(字段类型:varchar,字段长度:20,是否可空:True)
 objvCoursewareCaseEN.LiveAddress = objDT.Rows[0][convCoursewareCase.LiveAddress].ToString().Trim(); //居住地址(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareCaseEN.HomePhone = objDT.Rows[0][convCoursewareCase.HomePhone].ToString().Trim(); //住宅电话(字段类型:varchar,字段长度:20,是否可空:True)
 objvCoursewareCaseEN.EnrollmentDate = objDT.Rows[0][convCoursewareCase.EnrollmentDate].ToString().Trim(); //入校日期(字段类型:varchar,字段长度:8,是否可空:True)
 objvCoursewareCaseEN.PostCode = objDT.Rows[0][convCoursewareCase.PostCode].ToString().Trim(); //邮编(字段类型:char,字段长度:6,是否可空:True)
 objvCoursewareCaseEN.UserKindId = objDT.Rows[0][convCoursewareCase.UserKindId].ToString().Trim(); //用户类别Id(字段类型:char,字段长度:2,是否可空:False)
 objvCoursewareCaseEN.UserKindName = objDT.Rows[0][convCoursewareCase.UserKindName].ToString().Trim(); //用户类别名(字段类型:varchar,字段长度:30,是否可空:False)
 objvCoursewareCaseEN.UserTypeId = objDT.Rows[0][convCoursewareCase.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvCoursewareCaseEN.UserTypeName = objDT.Rows[0][convCoursewareCase.UserTypeName].ToString().Trim(); //用户类型名称(字段类型:varchar,字段长度:20,是否可空:True)
 objvCoursewareCaseEN.IsDualVideo = TransNullToBool(objDT.Rows[0][convCoursewareCase.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvCoursewareCaseEN.RecommendedDegreeId = objDT.Rows[0][convCoursewareCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvCoursewareCaseEN.RecommendedDegreeName = objDT.Rows[0][convCoursewareCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCoursewareCaseEN.ftpFileType = objDT.Rows[0][convCoursewareCase.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvCoursewareCaseEN.VideoUrl = objDT.Rows[0][convCoursewareCase.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCoursewareCaseEN.VideoPath = objDT.Rows[0][convCoursewareCase.VideoPath].ToString().Trim(); //视频目录(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCoursewareCaseEN.ResErrMsg = objDT.Rows[0][convCoursewareCase.ResErrMsg].ToString().Trim(); //资源错误信息(字段类型:varchar,字段长度:30,是否可空:True)
 objvCoursewareCaseEN.Memo = objDT.Rows[0][convCoursewareCase.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCoursewareCaseEN.OwnerName = objDT.Rows[0][convCoursewareCase.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvCoursewareCaseEN.OwnerNameWithId = objDT.Rows[0][convCoursewareCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
 objvCoursewareCaseEN.BrowseCount4Case = TransNullToInt(objDT.Rows[0][convCoursewareCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvCoursewareCaseEN.IsHaveVideo = objDT.Rows[0][convCoursewareCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo(字段类型:varchar,字段长度:6,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvCoursewareCaseDA: GetvCoursewareCase)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdCoursewareCase">表关键字</param>
 /// <returns>表对象</returns>
public clsvCoursewareCaseEN GetObjByIdCoursewareCase(string strIdCoursewareCase)
{
CheckPrimaryKey(strIdCoursewareCase);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCaseDA.GetSpecSQLObj();
strSQL = "Select * from vCoursewareCase where IdCoursewareCase = " + "'"+ strIdCoursewareCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvCoursewareCaseEN objvCoursewareCaseEN = new clsvCoursewareCaseEN();
try
{
 objvCoursewareCaseEN.IdCoursewareCase = objRow[convCoursewareCase.IdCoursewareCase].ToString().Trim(); //课件教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareCaseEN.CoursewareCaseID = objRow[convCoursewareCase.CoursewareCaseID].ToString().Trim(); //课件教学案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareCaseEN.CoursewareCaseName = objRow[convCoursewareCase.CoursewareCaseName].ToString().Trim(); //课件教学案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCoursewareCaseEN.CoursewareCaseTheme = objRow[convCoursewareCase.CoursewareCaseTheme] == DBNull.Value ? null : objRow[convCoursewareCase.CoursewareCaseTheme].ToString().Trim(); //课件教学案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareCaseEN.IdCoursewareCaseType = objRow[convCoursewareCase.IdCoursewareCaseType].ToString().Trim(); //课件案例类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareCaseEN.CoursewareCaseTypeName = objRow[convCoursewareCase.CoursewareCaseTypeName] == DBNull.Value ? null : objRow[convCoursewareCase.CoursewareCaseTypeName].ToString().Trim(); //课件案例类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareCaseEN.CoursewareCaseText = objRow[convCoursewareCase.CoursewareCaseText] == DBNull.Value ? null : objRow[convCoursewareCase.CoursewareCaseText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objvCoursewareCaseEN.CoursewareCaseDate = objRow[convCoursewareCase.CoursewareCaseDate] == DBNull.Value ? null : objRow[convCoursewareCase.CoursewareCaseDate].ToString().Trim(); //课件教学日期(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareCaseEN.CoursewareCaseTime = objRow[convCoursewareCase.CoursewareCaseTime] == DBNull.Value ? null : objRow[convCoursewareCase.CoursewareCaseTime].ToString().Trim(); //课件教学时间(字段类型:char,字段长度:6,是否可空:True)
 objvCoursewareCaseEN.CoursewareCaseDateIn = objRow[convCoursewareCase.CoursewareCaseDateIn] == DBNull.Value ? null : objRow[convCoursewareCase.CoursewareCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareCaseEN.CoursewareCaseTimeIn = objRow[convCoursewareCase.CoursewareCaseTimeIn] == DBNull.Value ? null : objRow[convCoursewareCase.CoursewareCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvCoursewareCaseEN.IdStudyLevel = objRow[convCoursewareCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvCoursewareCaseEN.StudyLevelName = objRow[convCoursewareCase.StudyLevelName] == DBNull.Value ? null : objRow[convCoursewareCase.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareCaseEN.IdTeachingPlan = objRow[convCoursewareCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convCoursewareCase.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareCaseEN.IdCaseType = objRow[convCoursewareCase.IdCaseType] == DBNull.Value ? null : objRow[convCoursewareCase.IdCaseType].ToString().Trim(); //案例类型流水号(字段类型:char,字段长度:4,是否可空:True)
 objvCoursewareCaseEN.IdDiscipline = objRow[convCoursewareCase.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareCaseEN.DisciplineID = objRow[convCoursewareCase.DisciplineID] == DBNull.Value ? null : objRow[convCoursewareCase.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareCaseEN.DisciplineName = objRow[convCoursewareCase.DisciplineName] == DBNull.Value ? null : objRow[convCoursewareCase.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareCaseEN.IdSenateGaugeVersion = objRow[convCoursewareCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convCoursewareCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareCaseEN.senateGaugeVersionID = objRow[convCoursewareCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCoursewareCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareCaseEN.senateGaugeVersionName = objRow[convCoursewareCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCoursewareCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareCaseEN.senateGaugeVersionTtlScore = objRow[convCoursewareCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convCoursewareCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvCoursewareCaseEN.VersionNo = objRow[convCoursewareCase.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCoursewareCase.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvCoursewareCaseEN.IdTeachSkill = objRow[convCoursewareCase.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareCaseEN.TeachSkillID = objRow[convCoursewareCase.TeachSkillID] == DBNull.Value ? null : objRow[convCoursewareCase.TeachSkillID].ToString().Trim(); //教学技能ID(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareCaseEN.SkillTypeName = objRow[convCoursewareCase.SkillTypeName] == DBNull.Value ? null : objRow[convCoursewareCase.SkillTypeName].ToString().Trim(); //技能类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareCaseEN.TeachSkillName = objRow[convCoursewareCase.TeachSkillName] == DBNull.Value ? null : objRow[convCoursewareCase.TeachSkillName].ToString().Trim(); //教学技能名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareCaseEN.TeachSkillTheory = objRow[convCoursewareCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convCoursewareCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvCoursewareCaseEN.TeachSkillOperMethod = objRow[convCoursewareCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCoursewareCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法(字段类型:varchar,字段长度:2000,是否可空:True)
 objvCoursewareCaseEN.IdSkillType = objRow[convCoursewareCase.IdSkillType] == DBNull.Value ? null : objRow[convCoursewareCase.IdSkillType].ToString().Trim(); //技能类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareCaseEN.SkillTypeID = objRow[convCoursewareCase.SkillTypeID] == DBNull.Value ? null : objRow[convCoursewareCase.SkillTypeID].ToString().Trim(); //技能类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareCaseEN.CaseLevelId = objRow[convCoursewareCase.CaseLevelId] == DBNull.Value ? null : objRow[convCoursewareCase.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvCoursewareCaseEN.CaseLevelName = objRow[convCoursewareCase.CaseLevelName] == DBNull.Value ? null : objRow[convCoursewareCase.CaseLevelName].ToString().Trim(); //案例等级名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvCoursewareCaseEN.DocFile = objRow[convCoursewareCase.DocFile] == DBNull.Value ? null : objRow[convCoursewareCase.DocFile].ToString().Trim(); //生成的Word文件名(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convCoursewareCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word(字段类型:bit,字段长度:1,是否可空:True)
 objvCoursewareCaseEN.WordCreateDate = objRow[convCoursewareCase.WordCreateDate] == DBNull.Value ? null : objRow[convCoursewareCase.WordCreateDate].ToString().Trim(); //Word生成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objvCoursewareCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCoursewareCase.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvCoursewareCaseEN.OwnerId = objRow[convCoursewareCase.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvCoursewareCaseEN.IdStudentInfo = objRow[convCoursewareCase.IdStudentInfo] == DBNull.Value ? null : objRow[convCoursewareCase.IdStudentInfo].ToString().Trim(); //学生流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareCaseEN.StuName = objRow[convCoursewareCase.StuName] == DBNull.Value ? null : objRow[convCoursewareCase.StuName].ToString().Trim(); //姓名(字段类型:varchar,字段长度:50,是否可空:True)
 objvCoursewareCaseEN.StuID = objRow[convCoursewareCase.StuID] == DBNull.Value ? null : objRow[convCoursewareCase.StuID].ToString().Trim(); //学号(字段类型:varchar,字段长度:20,是否可空:True)
 objvCoursewareCaseEN.PoliticsName = objRow[convCoursewareCase.PoliticsName] == DBNull.Value ? null : objRow[convCoursewareCase.PoliticsName].ToString().Trim(); //政治面貌(字段类型:varchar,字段长度:30,是否可空:False)
 objvCoursewareCaseEN.SexDesc = objRow[convCoursewareCase.SexDesc] == DBNull.Value ? null : objRow[convCoursewareCase.SexDesc].ToString().Trim(); //性别名称(字段类型:varchar,字段长度:10,是否可空:True)
 objvCoursewareCaseEN.EthnicName = objRow[convCoursewareCase.EthnicName] == DBNull.Value ? null : objRow[convCoursewareCase.EthnicName].ToString().Trim(); //民族名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCoursewareCaseEN.UniZoneDesc = objRow[convCoursewareCase.UniZoneDesc] == DBNull.Value ? null : objRow[convCoursewareCase.UniZoneDesc].ToString().Trim(); //校区名称(字段类型:varchar,字段长度:20,是否可空:False)
 objvCoursewareCaseEN.StuTypeDesc = objRow[convCoursewareCase.StuTypeDesc] == DBNull.Value ? null : objRow[convCoursewareCase.StuTypeDesc].ToString().Trim(); //学生类别名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareCaseEN.IdXzCollege = objRow[convCoursewareCase.IdXzCollege] == DBNull.Value ? null : objRow[convCoursewareCase.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvCoursewareCaseEN.CollegeID = objRow[convCoursewareCase.CollegeID] == DBNull.Value ? null : objRow[convCoursewareCase.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvCoursewareCaseEN.CollegeName = objRow[convCoursewareCase.CollegeName] == DBNull.Value ? null : objRow[convCoursewareCase.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCoursewareCaseEN.CollegeNameA = objRow[convCoursewareCase.CollegeNameA] == DBNull.Value ? null : objRow[convCoursewareCase.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvCoursewareCaseEN.IdXzMajor = objRow[convCoursewareCase.IdXzMajor] == DBNull.Value ? null : objRow[convCoursewareCase.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareCaseEN.MajorName = objRow[convCoursewareCase.MajorName] == DBNull.Value ? null : objRow[convCoursewareCase.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCoursewareCaseEN.IdGradeBase = objRow[convCoursewareCase.IdGradeBase] == DBNull.Value ? null : objRow[convCoursewareCase.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objvCoursewareCaseEN.GradeBaseName = objRow[convCoursewareCase.GradeBaseName] == DBNull.Value ? null : objRow[convCoursewareCase.GradeBaseName].ToString().Trim(); //年级名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareCaseEN.IdAdminCls = objRow[convCoursewareCase.IdAdminCls] == DBNull.Value ? null : objRow[convCoursewareCase.IdAdminCls].ToString().Trim(); //行政班流水号(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareCaseEN.AdminClsId = objRow[convCoursewareCase.AdminClsId] == DBNull.Value ? null : objRow[convCoursewareCase.AdminClsId].ToString().Trim(); //行政班代号(字段类型:varchar,字段长度:8,是否可空:True)
 objvCoursewareCaseEN.AdminClsName = objRow[convCoursewareCase.AdminClsName] == DBNull.Value ? null : objRow[convCoursewareCase.AdminClsName].ToString().Trim(); //行政班名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvCoursewareCaseEN.Birthday = objRow[convCoursewareCase.Birthday] == DBNull.Value ? null : objRow[convCoursewareCase.Birthday].ToString().Trim(); //出生日期(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareCaseEN.NativePlace = objRow[convCoursewareCase.NativePlace] == DBNull.Value ? null : objRow[convCoursewareCase.NativePlace].ToString().Trim(); //籍贯(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareCaseEN.Duty = objRow[convCoursewareCase.Duty] == DBNull.Value ? null : objRow[convCoursewareCase.Duty].ToString().Trim(); //职位(字段类型:varchar,字段长度:30,是否可空:True)
 objvCoursewareCaseEN.IDCardNo = objRow[convCoursewareCase.IDCardNo] == DBNull.Value ? null : objRow[convCoursewareCase.IDCardNo].ToString().Trim(); //身份证号(字段类型:varchar,字段长度:20,是否可空:True)
 objvCoursewareCaseEN.StuCardNo = objRow[convCoursewareCase.StuCardNo] == DBNull.Value ? null : objRow[convCoursewareCase.StuCardNo].ToString().Trim(); //学生证号(字段类型:varchar,字段长度:20,是否可空:True)
 objvCoursewareCaseEN.LiveAddress = objRow[convCoursewareCase.LiveAddress] == DBNull.Value ? null : objRow[convCoursewareCase.LiveAddress].ToString().Trim(); //居住地址(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareCaseEN.HomePhone = objRow[convCoursewareCase.HomePhone] == DBNull.Value ? null : objRow[convCoursewareCase.HomePhone].ToString().Trim(); //住宅电话(字段类型:varchar,字段长度:20,是否可空:True)
 objvCoursewareCaseEN.EnrollmentDate = objRow[convCoursewareCase.EnrollmentDate] == DBNull.Value ? null : objRow[convCoursewareCase.EnrollmentDate].ToString().Trim(); //入校日期(字段类型:varchar,字段长度:8,是否可空:True)
 objvCoursewareCaseEN.PostCode = objRow[convCoursewareCase.PostCode] == DBNull.Value ? null : objRow[convCoursewareCase.PostCode].ToString().Trim(); //邮编(字段类型:char,字段长度:6,是否可空:True)
 objvCoursewareCaseEN.UserKindId = objRow[convCoursewareCase.UserKindId].ToString().Trim(); //用户类别Id(字段类型:char,字段长度:2,是否可空:False)
 objvCoursewareCaseEN.UserKindName = objRow[convCoursewareCase.UserKindName] == DBNull.Value ? null : objRow[convCoursewareCase.UserKindName].ToString().Trim(); //用户类别名(字段类型:varchar,字段长度:30,是否可空:False)
 objvCoursewareCaseEN.UserTypeId = objRow[convCoursewareCase.UserTypeId] == DBNull.Value ? null : objRow[convCoursewareCase.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvCoursewareCaseEN.UserTypeName = objRow[convCoursewareCase.UserTypeName] == DBNull.Value ? null : objRow[convCoursewareCase.UserTypeName].ToString().Trim(); //用户类型名称(字段类型:varchar,字段长度:20,是否可空:True)
 objvCoursewareCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCoursewareCase.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvCoursewareCaseEN.RecommendedDegreeId = objRow[convCoursewareCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvCoursewareCaseEN.RecommendedDegreeName = objRow[convCoursewareCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCoursewareCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCoursewareCaseEN.ftpFileType = objRow[convCoursewareCase.ftpFileType] == DBNull.Value ? null : objRow[convCoursewareCase.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvCoursewareCaseEN.VideoUrl = objRow[convCoursewareCase.VideoUrl] == DBNull.Value ? null : objRow[convCoursewareCase.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCoursewareCaseEN.VideoPath = objRow[convCoursewareCase.VideoPath] == DBNull.Value ? null : objRow[convCoursewareCase.VideoPath].ToString().Trim(); //视频目录(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCoursewareCaseEN.ResErrMsg = objRow[convCoursewareCase.ResErrMsg] == DBNull.Value ? null : objRow[convCoursewareCase.ResErrMsg].ToString().Trim(); //资源错误信息(字段类型:varchar,字段长度:30,是否可空:True)
 objvCoursewareCaseEN.Memo = objRow[convCoursewareCase.Memo] == DBNull.Value ? null : objRow[convCoursewareCase.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCoursewareCaseEN.OwnerName = objRow[convCoursewareCase.OwnerName] == DBNull.Value ? null : objRow[convCoursewareCase.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvCoursewareCaseEN.OwnerNameWithId = objRow[convCoursewareCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convCoursewareCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
 objvCoursewareCaseEN.BrowseCount4Case = objRow[convCoursewareCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCoursewareCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvCoursewareCaseEN.IsHaveVideo = objRow[convCoursewareCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo(字段类型:varchar,字段长度:6,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvCoursewareCaseDA: GetObjByIdCoursewareCase)", objException.Message));
}
return objvCoursewareCaseEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvCoursewareCaseEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvCoursewareCaseDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCaseDA.GetSpecSQLObj();
strSQL = "Select * from vCoursewareCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvCoursewareCaseEN objvCoursewareCaseEN = new clsvCoursewareCaseEN()
{
IdCoursewareCase = objRow[convCoursewareCase.IdCoursewareCase].ToString().Trim(), //课件教学案例流水号
CoursewareCaseID = objRow[convCoursewareCase.CoursewareCaseID].ToString().Trim(), //课件教学案例ID
CoursewareCaseName = objRow[convCoursewareCase.CoursewareCaseName].ToString().Trim(), //课件教学案例名称
CoursewareCaseTheme = objRow[convCoursewareCase.CoursewareCaseTheme] == DBNull.Value ? null : objRow[convCoursewareCase.CoursewareCaseTheme].ToString().Trim(), //课件教学案例主题词
IdCoursewareCaseType = objRow[convCoursewareCase.IdCoursewareCaseType].ToString().Trim(), //课件案例类型流水号
CoursewareCaseTypeName = objRow[convCoursewareCase.CoursewareCaseTypeName] == DBNull.Value ? null : objRow[convCoursewareCase.CoursewareCaseTypeName].ToString().Trim(), //课件案例类型名称
CoursewareCaseText = objRow[convCoursewareCase.CoursewareCaseText] == DBNull.Value ? null : objRow[convCoursewareCase.CoursewareCaseText].ToString().Trim(), //案例文本内容
CoursewareCaseDate = objRow[convCoursewareCase.CoursewareCaseDate] == DBNull.Value ? null : objRow[convCoursewareCase.CoursewareCaseDate].ToString().Trim(), //课件教学日期
CoursewareCaseTime = objRow[convCoursewareCase.CoursewareCaseTime] == DBNull.Value ? null : objRow[convCoursewareCase.CoursewareCaseTime].ToString().Trim(), //课件教学时间
CoursewareCaseDateIn = objRow[convCoursewareCase.CoursewareCaseDateIn] == DBNull.Value ? null : objRow[convCoursewareCase.CoursewareCaseDateIn].ToString().Trim(), //案例入库日期
CoursewareCaseTimeIn = objRow[convCoursewareCase.CoursewareCaseTimeIn] == DBNull.Value ? null : objRow[convCoursewareCase.CoursewareCaseTimeIn].ToString().Trim(), //案例入库时间
IdStudyLevel = objRow[convCoursewareCase.IdStudyLevel].ToString().Trim(), //id_StudyLevel
StudyLevelName = objRow[convCoursewareCase.StudyLevelName] == DBNull.Value ? null : objRow[convCoursewareCase.StudyLevelName].ToString().Trim(), //学段名称
IdTeachingPlan = objRow[convCoursewareCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convCoursewareCase.IdTeachingPlan].ToString().Trim(), //教案流水号
IdCaseType = objRow[convCoursewareCase.IdCaseType] == DBNull.Value ? null : objRow[convCoursewareCase.IdCaseType].ToString().Trim(), //案例类型流水号
IdDiscipline = objRow[convCoursewareCase.IdDiscipline].ToString().Trim(), //学科流水号
DisciplineID = objRow[convCoursewareCase.DisciplineID] == DBNull.Value ? null : objRow[convCoursewareCase.DisciplineID].ToString().Trim(), //学科ID
DisciplineName = objRow[convCoursewareCase.DisciplineName] == DBNull.Value ? null : objRow[convCoursewareCase.DisciplineName].ToString().Trim(), //学科名称
IdSenateGaugeVersion = objRow[convCoursewareCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convCoursewareCase.IdSenateGaugeVersion].ToString().Trim(), //评价量表版本流水号
senateGaugeVersionID = objRow[convCoursewareCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCoursewareCase.senateGaugeVersionID].ToString().Trim(), //评价量表版本ID
senateGaugeVersionName = objRow[convCoursewareCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCoursewareCase.senateGaugeVersionName].ToString().Trim(), //评价量表版本名称
senateGaugeVersionTtlScore = objRow[convCoursewareCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convCoursewareCase.senateGaugeVersionTtlScore].ToString().Trim()), //评价量表版本总分
VersionNo = objRow[convCoursewareCase.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareCase.VersionNo].ToString().Trim()), //版本号
IdTeachSkill = objRow[convCoursewareCase.IdTeachSkill].ToString().Trim(), //教学技能流水号
TeachSkillID = objRow[convCoursewareCase.TeachSkillID] == DBNull.Value ? null : objRow[convCoursewareCase.TeachSkillID].ToString().Trim(), //教学技能ID
SkillTypeName = objRow[convCoursewareCase.SkillTypeName] == DBNull.Value ? null : objRow[convCoursewareCase.SkillTypeName].ToString().Trim(), //技能类型名称
TeachSkillName = objRow[convCoursewareCase.TeachSkillName] == DBNull.Value ? null : objRow[convCoursewareCase.TeachSkillName].ToString().Trim(), //教学技能名称
TeachSkillTheory = objRow[convCoursewareCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convCoursewareCase.TeachSkillTheory].ToString().Trim(), //教学技能理论阐述
TeachSkillOperMethod = objRow[convCoursewareCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCoursewareCase.TeachSkillOperMethod].ToString().Trim(), //教学技能实践操作方法
IdSkillType = objRow[convCoursewareCase.IdSkillType] == DBNull.Value ? null : objRow[convCoursewareCase.IdSkillType].ToString().Trim(), //技能类型流水号
SkillTypeID = objRow[convCoursewareCase.SkillTypeID] == DBNull.Value ? null : objRow[convCoursewareCase.SkillTypeID].ToString().Trim(), //技能类型ID
CaseLevelId = objRow[convCoursewareCase.CaseLevelId] == DBNull.Value ? null : objRow[convCoursewareCase.CaseLevelId].ToString().Trim(), //课例等级Id
CaseLevelName = objRow[convCoursewareCase.CaseLevelName] == DBNull.Value ? null : objRow[convCoursewareCase.CaseLevelName].ToString().Trim(), //案例等级名称
DocFile = objRow[convCoursewareCase.DocFile] == DBNull.Value ? null : objRow[convCoursewareCase.DocFile].ToString().Trim(), //生成的Word文件名
IsNeedGeneWord = TransNullToBool(objRow[convCoursewareCase.IsNeedGeneWord].ToString().Trim()), //是否需要生成Word
WordCreateDate = objRow[convCoursewareCase.WordCreateDate] == DBNull.Value ? null : objRow[convCoursewareCase.WordCreateDate].ToString().Trim(), //Word生成日期
IsVisible = TransNullToBool(objRow[convCoursewareCase.IsVisible].ToString().Trim()), //是否显示
OwnerId = objRow[convCoursewareCase.OwnerId].ToString().Trim(), //拥有者Id
IdStudentInfo = objRow[convCoursewareCase.IdStudentInfo] == DBNull.Value ? null : objRow[convCoursewareCase.IdStudentInfo].ToString().Trim(), //学生流水号
StuName = objRow[convCoursewareCase.StuName] == DBNull.Value ? null : objRow[convCoursewareCase.StuName].ToString().Trim(), //姓名
StuID = objRow[convCoursewareCase.StuID] == DBNull.Value ? null : objRow[convCoursewareCase.StuID].ToString().Trim(), //学号
PoliticsName = objRow[convCoursewareCase.PoliticsName] == DBNull.Value ? null : objRow[convCoursewareCase.PoliticsName].ToString().Trim(), //政治面貌
SexDesc = objRow[convCoursewareCase.SexDesc] == DBNull.Value ? null : objRow[convCoursewareCase.SexDesc].ToString().Trim(), //性别名称
EthnicName = objRow[convCoursewareCase.EthnicName] == DBNull.Value ? null : objRow[convCoursewareCase.EthnicName].ToString().Trim(), //民族名称
UniZoneDesc = objRow[convCoursewareCase.UniZoneDesc] == DBNull.Value ? null : objRow[convCoursewareCase.UniZoneDesc].ToString().Trim(), //校区名称
StuTypeDesc = objRow[convCoursewareCase.StuTypeDesc] == DBNull.Value ? null : objRow[convCoursewareCase.StuTypeDesc].ToString().Trim(), //学生类别名称
IdXzCollege = objRow[convCoursewareCase.IdXzCollege] == DBNull.Value ? null : objRow[convCoursewareCase.IdXzCollege].ToString().Trim(), //学院流水号
CollegeID = objRow[convCoursewareCase.CollegeID] == DBNull.Value ? null : objRow[convCoursewareCase.CollegeID].ToString().Trim(), //学院ID
CollegeName = objRow[convCoursewareCase.CollegeName] == DBNull.Value ? null : objRow[convCoursewareCase.CollegeName].ToString().Trim(), //学院名称
CollegeNameA = objRow[convCoursewareCase.CollegeNameA] == DBNull.Value ? null : objRow[convCoursewareCase.CollegeNameA].ToString().Trim(), //学院名称简写
IdXzMajor = objRow[convCoursewareCase.IdXzMajor] == DBNull.Value ? null : objRow[convCoursewareCase.IdXzMajor].ToString().Trim(), //专业流水号
MajorName = objRow[convCoursewareCase.MajorName] == DBNull.Value ? null : objRow[convCoursewareCase.MajorName].ToString().Trim(), //专业名称
IdGradeBase = objRow[convCoursewareCase.IdGradeBase] == DBNull.Value ? null : objRow[convCoursewareCase.IdGradeBase].ToString().Trim(), //年级流水号
GradeBaseName = objRow[convCoursewareCase.GradeBaseName] == DBNull.Value ? null : objRow[convCoursewareCase.GradeBaseName].ToString().Trim(), //年级名称
IdAdminCls = objRow[convCoursewareCase.IdAdminCls] == DBNull.Value ? null : objRow[convCoursewareCase.IdAdminCls].ToString().Trim(), //行政班流水号
AdminClsId = objRow[convCoursewareCase.AdminClsId] == DBNull.Value ? null : objRow[convCoursewareCase.AdminClsId].ToString().Trim(), //行政班代号
AdminClsName = objRow[convCoursewareCase.AdminClsName] == DBNull.Value ? null : objRow[convCoursewareCase.AdminClsName].ToString().Trim(), //行政班名称
Birthday = objRow[convCoursewareCase.Birthday] == DBNull.Value ? null : objRow[convCoursewareCase.Birthday].ToString().Trim(), //出生日期
NativePlace = objRow[convCoursewareCase.NativePlace] == DBNull.Value ? null : objRow[convCoursewareCase.NativePlace].ToString().Trim(), //籍贯
Duty = objRow[convCoursewareCase.Duty] == DBNull.Value ? null : objRow[convCoursewareCase.Duty].ToString().Trim(), //职位
IDCardNo = objRow[convCoursewareCase.IDCardNo] == DBNull.Value ? null : objRow[convCoursewareCase.IDCardNo].ToString().Trim(), //身份证号
StuCardNo = objRow[convCoursewareCase.StuCardNo] == DBNull.Value ? null : objRow[convCoursewareCase.StuCardNo].ToString().Trim(), //学生证号
LiveAddress = objRow[convCoursewareCase.LiveAddress] == DBNull.Value ? null : objRow[convCoursewareCase.LiveAddress].ToString().Trim(), //居住地址
HomePhone = objRow[convCoursewareCase.HomePhone] == DBNull.Value ? null : objRow[convCoursewareCase.HomePhone].ToString().Trim(), //住宅电话
EnrollmentDate = objRow[convCoursewareCase.EnrollmentDate] == DBNull.Value ? null : objRow[convCoursewareCase.EnrollmentDate].ToString().Trim(), //入校日期
PostCode = objRow[convCoursewareCase.PostCode] == DBNull.Value ? null : objRow[convCoursewareCase.PostCode].ToString().Trim(), //邮编
UserKindId = objRow[convCoursewareCase.UserKindId].ToString().Trim(), //用户类别Id
UserKindName = objRow[convCoursewareCase.UserKindName] == DBNull.Value ? null : objRow[convCoursewareCase.UserKindName].ToString().Trim(), //用户类别名
UserTypeId = objRow[convCoursewareCase.UserTypeId] == DBNull.Value ? null : objRow[convCoursewareCase.UserTypeId].ToString().Trim(), //用户类型Id
UserTypeName = objRow[convCoursewareCase.UserTypeName] == DBNull.Value ? null : objRow[convCoursewareCase.UserTypeName].ToString().Trim(), //用户类型名称
IsDualVideo = TransNullToBool(objRow[convCoursewareCase.IsDualVideo].ToString().Trim()), //是否双视频
RecommendedDegreeId = objRow[convCoursewareCase.RecommendedDegreeId].ToString().Trim(), //推荐度Id
RecommendedDegreeName = objRow[convCoursewareCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCoursewareCase.RecommendedDegreeName].ToString().Trim(), //推荐度名称
ftpFileType = objRow[convCoursewareCase.ftpFileType] == DBNull.Value ? null : objRow[convCoursewareCase.ftpFileType].ToString().Trim(), //ftp文件类型
VideoUrl = objRow[convCoursewareCase.VideoUrl] == DBNull.Value ? null : objRow[convCoursewareCase.VideoUrl].ToString().Trim(), //视频Url
VideoPath = objRow[convCoursewareCase.VideoPath] == DBNull.Value ? null : objRow[convCoursewareCase.VideoPath].ToString().Trim(), //视频目录
ResErrMsg = objRow[convCoursewareCase.ResErrMsg] == DBNull.Value ? null : objRow[convCoursewareCase.ResErrMsg].ToString().Trim(), //资源错误信息
Memo = objRow[convCoursewareCase.Memo] == DBNull.Value ? null : objRow[convCoursewareCase.Memo].ToString().Trim(), //备注
OwnerName = objRow[convCoursewareCase.OwnerName] == DBNull.Value ? null : objRow[convCoursewareCase.OwnerName].ToString().Trim(), //拥有者姓名
OwnerNameWithId = objRow[convCoursewareCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convCoursewareCase.OwnerNameWithId].ToString().Trim(), //拥有者名称附Id
BrowseCount4Case = objRow[convCoursewareCase.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareCase.BrowseCount4Case].ToString().Trim()), //课例浏览次数
IsHaveVideo = objRow[convCoursewareCase.IsHaveVideo].ToString().Trim() //IsHaveVideo
};
objvCoursewareCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCoursewareCaseEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvCoursewareCaseDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvCoursewareCaseEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCoursewareCaseEN objvCoursewareCaseEN = new clsvCoursewareCaseEN();
try
{
objvCoursewareCaseEN.IdCoursewareCase = objRow[convCoursewareCase.IdCoursewareCase].ToString().Trim(); //课件教学案例流水号
objvCoursewareCaseEN.CoursewareCaseID = objRow[convCoursewareCase.CoursewareCaseID].ToString().Trim(); //课件教学案例ID
objvCoursewareCaseEN.CoursewareCaseName = objRow[convCoursewareCase.CoursewareCaseName].ToString().Trim(); //课件教学案例名称
objvCoursewareCaseEN.CoursewareCaseTheme = objRow[convCoursewareCase.CoursewareCaseTheme] == DBNull.Value ? null : objRow[convCoursewareCase.CoursewareCaseTheme].ToString().Trim(); //课件教学案例主题词
objvCoursewareCaseEN.IdCoursewareCaseType = objRow[convCoursewareCase.IdCoursewareCaseType].ToString().Trim(); //课件案例类型流水号
objvCoursewareCaseEN.CoursewareCaseTypeName = objRow[convCoursewareCase.CoursewareCaseTypeName] == DBNull.Value ? null : objRow[convCoursewareCase.CoursewareCaseTypeName].ToString().Trim(); //课件案例类型名称
objvCoursewareCaseEN.CoursewareCaseText = objRow[convCoursewareCase.CoursewareCaseText] == DBNull.Value ? null : objRow[convCoursewareCase.CoursewareCaseText].ToString().Trim(); //案例文本内容
objvCoursewareCaseEN.CoursewareCaseDate = objRow[convCoursewareCase.CoursewareCaseDate] == DBNull.Value ? null : objRow[convCoursewareCase.CoursewareCaseDate].ToString().Trim(); //课件教学日期
objvCoursewareCaseEN.CoursewareCaseTime = objRow[convCoursewareCase.CoursewareCaseTime] == DBNull.Value ? null : objRow[convCoursewareCase.CoursewareCaseTime].ToString().Trim(); //课件教学时间
objvCoursewareCaseEN.CoursewareCaseDateIn = objRow[convCoursewareCase.CoursewareCaseDateIn] == DBNull.Value ? null : objRow[convCoursewareCase.CoursewareCaseDateIn].ToString().Trim(); //案例入库日期
objvCoursewareCaseEN.CoursewareCaseTimeIn = objRow[convCoursewareCase.CoursewareCaseTimeIn] == DBNull.Value ? null : objRow[convCoursewareCase.CoursewareCaseTimeIn].ToString().Trim(); //案例入库时间
objvCoursewareCaseEN.IdStudyLevel = objRow[convCoursewareCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCoursewareCaseEN.StudyLevelName = objRow[convCoursewareCase.StudyLevelName] == DBNull.Value ? null : objRow[convCoursewareCase.StudyLevelName].ToString().Trim(); //学段名称
objvCoursewareCaseEN.IdTeachingPlan = objRow[convCoursewareCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convCoursewareCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCoursewareCaseEN.IdCaseType = objRow[convCoursewareCase.IdCaseType] == DBNull.Value ? null : objRow[convCoursewareCase.IdCaseType].ToString().Trim(); //案例类型流水号
objvCoursewareCaseEN.IdDiscipline = objRow[convCoursewareCase.IdDiscipline].ToString().Trim(); //学科流水号
objvCoursewareCaseEN.DisciplineID = objRow[convCoursewareCase.DisciplineID] == DBNull.Value ? null : objRow[convCoursewareCase.DisciplineID].ToString().Trim(); //学科ID
objvCoursewareCaseEN.DisciplineName = objRow[convCoursewareCase.DisciplineName] == DBNull.Value ? null : objRow[convCoursewareCase.DisciplineName].ToString().Trim(); //学科名称
objvCoursewareCaseEN.IdSenateGaugeVersion = objRow[convCoursewareCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convCoursewareCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCoursewareCaseEN.senateGaugeVersionID = objRow[convCoursewareCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCoursewareCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCoursewareCaseEN.senateGaugeVersionName = objRow[convCoursewareCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCoursewareCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCoursewareCaseEN.senateGaugeVersionTtlScore = objRow[convCoursewareCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convCoursewareCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCoursewareCaseEN.VersionNo = objRow[convCoursewareCase.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareCase.VersionNo].ToString().Trim()); //版本号
objvCoursewareCaseEN.IdTeachSkill = objRow[convCoursewareCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCoursewareCaseEN.TeachSkillID = objRow[convCoursewareCase.TeachSkillID] == DBNull.Value ? null : objRow[convCoursewareCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvCoursewareCaseEN.SkillTypeName = objRow[convCoursewareCase.SkillTypeName] == DBNull.Value ? null : objRow[convCoursewareCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvCoursewareCaseEN.TeachSkillName = objRow[convCoursewareCase.TeachSkillName] == DBNull.Value ? null : objRow[convCoursewareCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvCoursewareCaseEN.TeachSkillTheory = objRow[convCoursewareCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convCoursewareCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCoursewareCaseEN.TeachSkillOperMethod = objRow[convCoursewareCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCoursewareCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCoursewareCaseEN.IdSkillType = objRow[convCoursewareCase.IdSkillType] == DBNull.Value ? null : objRow[convCoursewareCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvCoursewareCaseEN.SkillTypeID = objRow[convCoursewareCase.SkillTypeID] == DBNull.Value ? null : objRow[convCoursewareCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvCoursewareCaseEN.CaseLevelId = objRow[convCoursewareCase.CaseLevelId] == DBNull.Value ? null : objRow[convCoursewareCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvCoursewareCaseEN.CaseLevelName = objRow[convCoursewareCase.CaseLevelName] == DBNull.Value ? null : objRow[convCoursewareCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvCoursewareCaseEN.DocFile = objRow[convCoursewareCase.DocFile] == DBNull.Value ? null : objRow[convCoursewareCase.DocFile].ToString().Trim(); //生成的Word文件名
objvCoursewareCaseEN.IsNeedGeneWord = TransNullToBool(objRow[convCoursewareCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvCoursewareCaseEN.WordCreateDate = objRow[convCoursewareCase.WordCreateDate] == DBNull.Value ? null : objRow[convCoursewareCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvCoursewareCaseEN.IsVisible = TransNullToBool(objRow[convCoursewareCase.IsVisible].ToString().Trim()); //是否显示
objvCoursewareCaseEN.OwnerId = objRow[convCoursewareCase.OwnerId].ToString().Trim(); //拥有者Id
objvCoursewareCaseEN.IdStudentInfo = objRow[convCoursewareCase.IdStudentInfo] == DBNull.Value ? null : objRow[convCoursewareCase.IdStudentInfo].ToString().Trim(); //学生流水号
objvCoursewareCaseEN.StuName = objRow[convCoursewareCase.StuName] == DBNull.Value ? null : objRow[convCoursewareCase.StuName].ToString().Trim(); //姓名
objvCoursewareCaseEN.StuID = objRow[convCoursewareCase.StuID] == DBNull.Value ? null : objRow[convCoursewareCase.StuID].ToString().Trim(); //学号
objvCoursewareCaseEN.PoliticsName = objRow[convCoursewareCase.PoliticsName] == DBNull.Value ? null : objRow[convCoursewareCase.PoliticsName].ToString().Trim(); //政治面貌
objvCoursewareCaseEN.SexDesc = objRow[convCoursewareCase.SexDesc] == DBNull.Value ? null : objRow[convCoursewareCase.SexDesc].ToString().Trim(); //性别名称
objvCoursewareCaseEN.EthnicName = objRow[convCoursewareCase.EthnicName] == DBNull.Value ? null : objRow[convCoursewareCase.EthnicName].ToString().Trim(); //民族名称
objvCoursewareCaseEN.UniZoneDesc = objRow[convCoursewareCase.UniZoneDesc] == DBNull.Value ? null : objRow[convCoursewareCase.UniZoneDesc].ToString().Trim(); //校区名称
objvCoursewareCaseEN.StuTypeDesc = objRow[convCoursewareCase.StuTypeDesc] == DBNull.Value ? null : objRow[convCoursewareCase.StuTypeDesc].ToString().Trim(); //学生类别名称
objvCoursewareCaseEN.IdXzCollege = objRow[convCoursewareCase.IdXzCollege] == DBNull.Value ? null : objRow[convCoursewareCase.IdXzCollege].ToString().Trim(); //学院流水号
objvCoursewareCaseEN.CollegeID = objRow[convCoursewareCase.CollegeID] == DBNull.Value ? null : objRow[convCoursewareCase.CollegeID].ToString().Trim(); //学院ID
objvCoursewareCaseEN.CollegeName = objRow[convCoursewareCase.CollegeName] == DBNull.Value ? null : objRow[convCoursewareCase.CollegeName].ToString().Trim(); //学院名称
objvCoursewareCaseEN.CollegeNameA = objRow[convCoursewareCase.CollegeNameA] == DBNull.Value ? null : objRow[convCoursewareCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvCoursewareCaseEN.IdXzMajor = objRow[convCoursewareCase.IdXzMajor] == DBNull.Value ? null : objRow[convCoursewareCase.IdXzMajor].ToString().Trim(); //专业流水号
objvCoursewareCaseEN.MajorName = objRow[convCoursewareCase.MajorName] == DBNull.Value ? null : objRow[convCoursewareCase.MajorName].ToString().Trim(); //专业名称
objvCoursewareCaseEN.IdGradeBase = objRow[convCoursewareCase.IdGradeBase] == DBNull.Value ? null : objRow[convCoursewareCase.IdGradeBase].ToString().Trim(); //年级流水号
objvCoursewareCaseEN.GradeBaseName = objRow[convCoursewareCase.GradeBaseName] == DBNull.Value ? null : objRow[convCoursewareCase.GradeBaseName].ToString().Trim(); //年级名称
objvCoursewareCaseEN.IdAdminCls = objRow[convCoursewareCase.IdAdminCls] == DBNull.Value ? null : objRow[convCoursewareCase.IdAdminCls].ToString().Trim(); //行政班流水号
objvCoursewareCaseEN.AdminClsId = objRow[convCoursewareCase.AdminClsId] == DBNull.Value ? null : objRow[convCoursewareCase.AdminClsId].ToString().Trim(); //行政班代号
objvCoursewareCaseEN.AdminClsName = objRow[convCoursewareCase.AdminClsName] == DBNull.Value ? null : objRow[convCoursewareCase.AdminClsName].ToString().Trim(); //行政班名称
objvCoursewareCaseEN.Birthday = objRow[convCoursewareCase.Birthday] == DBNull.Value ? null : objRow[convCoursewareCase.Birthday].ToString().Trim(); //出生日期
objvCoursewareCaseEN.NativePlace = objRow[convCoursewareCase.NativePlace] == DBNull.Value ? null : objRow[convCoursewareCase.NativePlace].ToString().Trim(); //籍贯
objvCoursewareCaseEN.Duty = objRow[convCoursewareCase.Duty] == DBNull.Value ? null : objRow[convCoursewareCase.Duty].ToString().Trim(); //职位
objvCoursewareCaseEN.IDCardNo = objRow[convCoursewareCase.IDCardNo] == DBNull.Value ? null : objRow[convCoursewareCase.IDCardNo].ToString().Trim(); //身份证号
objvCoursewareCaseEN.StuCardNo = objRow[convCoursewareCase.StuCardNo] == DBNull.Value ? null : objRow[convCoursewareCase.StuCardNo].ToString().Trim(); //学生证号
objvCoursewareCaseEN.LiveAddress = objRow[convCoursewareCase.LiveAddress] == DBNull.Value ? null : objRow[convCoursewareCase.LiveAddress].ToString().Trim(); //居住地址
objvCoursewareCaseEN.HomePhone = objRow[convCoursewareCase.HomePhone] == DBNull.Value ? null : objRow[convCoursewareCase.HomePhone].ToString().Trim(); //住宅电话
objvCoursewareCaseEN.EnrollmentDate = objRow[convCoursewareCase.EnrollmentDate] == DBNull.Value ? null : objRow[convCoursewareCase.EnrollmentDate].ToString().Trim(); //入校日期
objvCoursewareCaseEN.PostCode = objRow[convCoursewareCase.PostCode] == DBNull.Value ? null : objRow[convCoursewareCase.PostCode].ToString().Trim(); //邮编
objvCoursewareCaseEN.UserKindId = objRow[convCoursewareCase.UserKindId].ToString().Trim(); //用户类别Id
objvCoursewareCaseEN.UserKindName = objRow[convCoursewareCase.UserKindName] == DBNull.Value ? null : objRow[convCoursewareCase.UserKindName].ToString().Trim(); //用户类别名
objvCoursewareCaseEN.UserTypeId = objRow[convCoursewareCase.UserTypeId] == DBNull.Value ? null : objRow[convCoursewareCase.UserTypeId].ToString().Trim(); //用户类型Id
objvCoursewareCaseEN.UserTypeName = objRow[convCoursewareCase.UserTypeName] == DBNull.Value ? null : objRow[convCoursewareCase.UserTypeName].ToString().Trim(); //用户类型名称
objvCoursewareCaseEN.IsDualVideo = TransNullToBool(objRow[convCoursewareCase.IsDualVideo].ToString().Trim()); //是否双视频
objvCoursewareCaseEN.RecommendedDegreeId = objRow[convCoursewareCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCoursewareCaseEN.RecommendedDegreeName = objRow[convCoursewareCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCoursewareCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCoursewareCaseEN.ftpFileType = objRow[convCoursewareCase.ftpFileType] == DBNull.Value ? null : objRow[convCoursewareCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvCoursewareCaseEN.VideoUrl = objRow[convCoursewareCase.VideoUrl] == DBNull.Value ? null : objRow[convCoursewareCase.VideoUrl].ToString().Trim(); //视频Url
objvCoursewareCaseEN.VideoPath = objRow[convCoursewareCase.VideoPath] == DBNull.Value ? null : objRow[convCoursewareCase.VideoPath].ToString().Trim(); //视频目录
objvCoursewareCaseEN.ResErrMsg = objRow[convCoursewareCase.ResErrMsg] == DBNull.Value ? null : objRow[convCoursewareCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvCoursewareCaseEN.Memo = objRow[convCoursewareCase.Memo] == DBNull.Value ? null : objRow[convCoursewareCase.Memo].ToString().Trim(); //备注
objvCoursewareCaseEN.OwnerName = objRow[convCoursewareCase.OwnerName] == DBNull.Value ? null : objRow[convCoursewareCase.OwnerName].ToString().Trim(); //拥有者姓名
objvCoursewareCaseEN.OwnerNameWithId = objRow[convCoursewareCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convCoursewareCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCoursewareCaseEN.BrowseCount4Case = objRow[convCoursewareCase.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCoursewareCaseEN.IsHaveVideo = objRow[convCoursewareCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvCoursewareCaseDA: GetObjByDataRowvCoursewareCase)", objException.Message));
}
objvCoursewareCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCoursewareCaseEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvCoursewareCaseEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCoursewareCaseEN objvCoursewareCaseEN = new clsvCoursewareCaseEN();
try
{
objvCoursewareCaseEN.IdCoursewareCase = objRow[convCoursewareCase.IdCoursewareCase].ToString().Trim(); //课件教学案例流水号
objvCoursewareCaseEN.CoursewareCaseID = objRow[convCoursewareCase.CoursewareCaseID].ToString().Trim(); //课件教学案例ID
objvCoursewareCaseEN.CoursewareCaseName = objRow[convCoursewareCase.CoursewareCaseName].ToString().Trim(); //课件教学案例名称
objvCoursewareCaseEN.CoursewareCaseTheme = objRow[convCoursewareCase.CoursewareCaseTheme] == DBNull.Value ? null : objRow[convCoursewareCase.CoursewareCaseTheme].ToString().Trim(); //课件教学案例主题词
objvCoursewareCaseEN.IdCoursewareCaseType = objRow[convCoursewareCase.IdCoursewareCaseType].ToString().Trim(); //课件案例类型流水号
objvCoursewareCaseEN.CoursewareCaseTypeName = objRow[convCoursewareCase.CoursewareCaseTypeName] == DBNull.Value ? null : objRow[convCoursewareCase.CoursewareCaseTypeName].ToString().Trim(); //课件案例类型名称
objvCoursewareCaseEN.CoursewareCaseText = objRow[convCoursewareCase.CoursewareCaseText] == DBNull.Value ? null : objRow[convCoursewareCase.CoursewareCaseText].ToString().Trim(); //案例文本内容
objvCoursewareCaseEN.CoursewareCaseDate = objRow[convCoursewareCase.CoursewareCaseDate] == DBNull.Value ? null : objRow[convCoursewareCase.CoursewareCaseDate].ToString().Trim(); //课件教学日期
objvCoursewareCaseEN.CoursewareCaseTime = objRow[convCoursewareCase.CoursewareCaseTime] == DBNull.Value ? null : objRow[convCoursewareCase.CoursewareCaseTime].ToString().Trim(); //课件教学时间
objvCoursewareCaseEN.CoursewareCaseDateIn = objRow[convCoursewareCase.CoursewareCaseDateIn] == DBNull.Value ? null : objRow[convCoursewareCase.CoursewareCaseDateIn].ToString().Trim(); //案例入库日期
objvCoursewareCaseEN.CoursewareCaseTimeIn = objRow[convCoursewareCase.CoursewareCaseTimeIn] == DBNull.Value ? null : objRow[convCoursewareCase.CoursewareCaseTimeIn].ToString().Trim(); //案例入库时间
objvCoursewareCaseEN.IdStudyLevel = objRow[convCoursewareCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCoursewareCaseEN.StudyLevelName = objRow[convCoursewareCase.StudyLevelName] == DBNull.Value ? null : objRow[convCoursewareCase.StudyLevelName].ToString().Trim(); //学段名称
objvCoursewareCaseEN.IdTeachingPlan = objRow[convCoursewareCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convCoursewareCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCoursewareCaseEN.IdCaseType = objRow[convCoursewareCase.IdCaseType] == DBNull.Value ? null : objRow[convCoursewareCase.IdCaseType].ToString().Trim(); //案例类型流水号
objvCoursewareCaseEN.IdDiscipline = objRow[convCoursewareCase.IdDiscipline].ToString().Trim(); //学科流水号
objvCoursewareCaseEN.DisciplineID = objRow[convCoursewareCase.DisciplineID] == DBNull.Value ? null : objRow[convCoursewareCase.DisciplineID].ToString().Trim(); //学科ID
objvCoursewareCaseEN.DisciplineName = objRow[convCoursewareCase.DisciplineName] == DBNull.Value ? null : objRow[convCoursewareCase.DisciplineName].ToString().Trim(); //学科名称
objvCoursewareCaseEN.IdSenateGaugeVersion = objRow[convCoursewareCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convCoursewareCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCoursewareCaseEN.senateGaugeVersionID = objRow[convCoursewareCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCoursewareCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCoursewareCaseEN.senateGaugeVersionName = objRow[convCoursewareCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCoursewareCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCoursewareCaseEN.senateGaugeVersionTtlScore = objRow[convCoursewareCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convCoursewareCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCoursewareCaseEN.VersionNo = objRow[convCoursewareCase.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareCase.VersionNo].ToString().Trim()); //版本号
objvCoursewareCaseEN.IdTeachSkill = objRow[convCoursewareCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCoursewareCaseEN.TeachSkillID = objRow[convCoursewareCase.TeachSkillID] == DBNull.Value ? null : objRow[convCoursewareCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvCoursewareCaseEN.SkillTypeName = objRow[convCoursewareCase.SkillTypeName] == DBNull.Value ? null : objRow[convCoursewareCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvCoursewareCaseEN.TeachSkillName = objRow[convCoursewareCase.TeachSkillName] == DBNull.Value ? null : objRow[convCoursewareCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvCoursewareCaseEN.TeachSkillTheory = objRow[convCoursewareCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convCoursewareCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCoursewareCaseEN.TeachSkillOperMethod = objRow[convCoursewareCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCoursewareCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCoursewareCaseEN.IdSkillType = objRow[convCoursewareCase.IdSkillType] == DBNull.Value ? null : objRow[convCoursewareCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvCoursewareCaseEN.SkillTypeID = objRow[convCoursewareCase.SkillTypeID] == DBNull.Value ? null : objRow[convCoursewareCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvCoursewareCaseEN.CaseLevelId = objRow[convCoursewareCase.CaseLevelId] == DBNull.Value ? null : objRow[convCoursewareCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvCoursewareCaseEN.CaseLevelName = objRow[convCoursewareCase.CaseLevelName] == DBNull.Value ? null : objRow[convCoursewareCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvCoursewareCaseEN.DocFile = objRow[convCoursewareCase.DocFile] == DBNull.Value ? null : objRow[convCoursewareCase.DocFile].ToString().Trim(); //生成的Word文件名
objvCoursewareCaseEN.IsNeedGeneWord = TransNullToBool(objRow[convCoursewareCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvCoursewareCaseEN.WordCreateDate = objRow[convCoursewareCase.WordCreateDate] == DBNull.Value ? null : objRow[convCoursewareCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvCoursewareCaseEN.IsVisible = TransNullToBool(objRow[convCoursewareCase.IsVisible].ToString().Trim()); //是否显示
objvCoursewareCaseEN.OwnerId = objRow[convCoursewareCase.OwnerId].ToString().Trim(); //拥有者Id
objvCoursewareCaseEN.IdStudentInfo = objRow[convCoursewareCase.IdStudentInfo] == DBNull.Value ? null : objRow[convCoursewareCase.IdStudentInfo].ToString().Trim(); //学生流水号
objvCoursewareCaseEN.StuName = objRow[convCoursewareCase.StuName] == DBNull.Value ? null : objRow[convCoursewareCase.StuName].ToString().Trim(); //姓名
objvCoursewareCaseEN.StuID = objRow[convCoursewareCase.StuID] == DBNull.Value ? null : objRow[convCoursewareCase.StuID].ToString().Trim(); //学号
objvCoursewareCaseEN.PoliticsName = objRow[convCoursewareCase.PoliticsName] == DBNull.Value ? null : objRow[convCoursewareCase.PoliticsName].ToString().Trim(); //政治面貌
objvCoursewareCaseEN.SexDesc = objRow[convCoursewareCase.SexDesc] == DBNull.Value ? null : objRow[convCoursewareCase.SexDesc].ToString().Trim(); //性别名称
objvCoursewareCaseEN.EthnicName = objRow[convCoursewareCase.EthnicName] == DBNull.Value ? null : objRow[convCoursewareCase.EthnicName].ToString().Trim(); //民族名称
objvCoursewareCaseEN.UniZoneDesc = objRow[convCoursewareCase.UniZoneDesc] == DBNull.Value ? null : objRow[convCoursewareCase.UniZoneDesc].ToString().Trim(); //校区名称
objvCoursewareCaseEN.StuTypeDesc = objRow[convCoursewareCase.StuTypeDesc] == DBNull.Value ? null : objRow[convCoursewareCase.StuTypeDesc].ToString().Trim(); //学生类别名称
objvCoursewareCaseEN.IdXzCollege = objRow[convCoursewareCase.IdXzCollege] == DBNull.Value ? null : objRow[convCoursewareCase.IdXzCollege].ToString().Trim(); //学院流水号
objvCoursewareCaseEN.CollegeID = objRow[convCoursewareCase.CollegeID] == DBNull.Value ? null : objRow[convCoursewareCase.CollegeID].ToString().Trim(); //学院ID
objvCoursewareCaseEN.CollegeName = objRow[convCoursewareCase.CollegeName] == DBNull.Value ? null : objRow[convCoursewareCase.CollegeName].ToString().Trim(); //学院名称
objvCoursewareCaseEN.CollegeNameA = objRow[convCoursewareCase.CollegeNameA] == DBNull.Value ? null : objRow[convCoursewareCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvCoursewareCaseEN.IdXzMajor = objRow[convCoursewareCase.IdXzMajor] == DBNull.Value ? null : objRow[convCoursewareCase.IdXzMajor].ToString().Trim(); //专业流水号
objvCoursewareCaseEN.MajorName = objRow[convCoursewareCase.MajorName] == DBNull.Value ? null : objRow[convCoursewareCase.MajorName].ToString().Trim(); //专业名称
objvCoursewareCaseEN.IdGradeBase = objRow[convCoursewareCase.IdGradeBase] == DBNull.Value ? null : objRow[convCoursewareCase.IdGradeBase].ToString().Trim(); //年级流水号
objvCoursewareCaseEN.GradeBaseName = objRow[convCoursewareCase.GradeBaseName] == DBNull.Value ? null : objRow[convCoursewareCase.GradeBaseName].ToString().Trim(); //年级名称
objvCoursewareCaseEN.IdAdminCls = objRow[convCoursewareCase.IdAdminCls] == DBNull.Value ? null : objRow[convCoursewareCase.IdAdminCls].ToString().Trim(); //行政班流水号
objvCoursewareCaseEN.AdminClsId = objRow[convCoursewareCase.AdminClsId] == DBNull.Value ? null : objRow[convCoursewareCase.AdminClsId].ToString().Trim(); //行政班代号
objvCoursewareCaseEN.AdminClsName = objRow[convCoursewareCase.AdminClsName] == DBNull.Value ? null : objRow[convCoursewareCase.AdminClsName].ToString().Trim(); //行政班名称
objvCoursewareCaseEN.Birthday = objRow[convCoursewareCase.Birthday] == DBNull.Value ? null : objRow[convCoursewareCase.Birthday].ToString().Trim(); //出生日期
objvCoursewareCaseEN.NativePlace = objRow[convCoursewareCase.NativePlace] == DBNull.Value ? null : objRow[convCoursewareCase.NativePlace].ToString().Trim(); //籍贯
objvCoursewareCaseEN.Duty = objRow[convCoursewareCase.Duty] == DBNull.Value ? null : objRow[convCoursewareCase.Duty].ToString().Trim(); //职位
objvCoursewareCaseEN.IDCardNo = objRow[convCoursewareCase.IDCardNo] == DBNull.Value ? null : objRow[convCoursewareCase.IDCardNo].ToString().Trim(); //身份证号
objvCoursewareCaseEN.StuCardNo = objRow[convCoursewareCase.StuCardNo] == DBNull.Value ? null : objRow[convCoursewareCase.StuCardNo].ToString().Trim(); //学生证号
objvCoursewareCaseEN.LiveAddress = objRow[convCoursewareCase.LiveAddress] == DBNull.Value ? null : objRow[convCoursewareCase.LiveAddress].ToString().Trim(); //居住地址
objvCoursewareCaseEN.HomePhone = objRow[convCoursewareCase.HomePhone] == DBNull.Value ? null : objRow[convCoursewareCase.HomePhone].ToString().Trim(); //住宅电话
objvCoursewareCaseEN.EnrollmentDate = objRow[convCoursewareCase.EnrollmentDate] == DBNull.Value ? null : objRow[convCoursewareCase.EnrollmentDate].ToString().Trim(); //入校日期
objvCoursewareCaseEN.PostCode = objRow[convCoursewareCase.PostCode] == DBNull.Value ? null : objRow[convCoursewareCase.PostCode].ToString().Trim(); //邮编
objvCoursewareCaseEN.UserKindId = objRow[convCoursewareCase.UserKindId].ToString().Trim(); //用户类别Id
objvCoursewareCaseEN.UserKindName = objRow[convCoursewareCase.UserKindName] == DBNull.Value ? null : objRow[convCoursewareCase.UserKindName].ToString().Trim(); //用户类别名
objvCoursewareCaseEN.UserTypeId = objRow[convCoursewareCase.UserTypeId] == DBNull.Value ? null : objRow[convCoursewareCase.UserTypeId].ToString().Trim(); //用户类型Id
objvCoursewareCaseEN.UserTypeName = objRow[convCoursewareCase.UserTypeName] == DBNull.Value ? null : objRow[convCoursewareCase.UserTypeName].ToString().Trim(); //用户类型名称
objvCoursewareCaseEN.IsDualVideo = TransNullToBool(objRow[convCoursewareCase.IsDualVideo].ToString().Trim()); //是否双视频
objvCoursewareCaseEN.RecommendedDegreeId = objRow[convCoursewareCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCoursewareCaseEN.RecommendedDegreeName = objRow[convCoursewareCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCoursewareCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCoursewareCaseEN.ftpFileType = objRow[convCoursewareCase.ftpFileType] == DBNull.Value ? null : objRow[convCoursewareCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvCoursewareCaseEN.VideoUrl = objRow[convCoursewareCase.VideoUrl] == DBNull.Value ? null : objRow[convCoursewareCase.VideoUrl].ToString().Trim(); //视频Url
objvCoursewareCaseEN.VideoPath = objRow[convCoursewareCase.VideoPath] == DBNull.Value ? null : objRow[convCoursewareCase.VideoPath].ToString().Trim(); //视频目录
objvCoursewareCaseEN.ResErrMsg = objRow[convCoursewareCase.ResErrMsg] == DBNull.Value ? null : objRow[convCoursewareCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvCoursewareCaseEN.Memo = objRow[convCoursewareCase.Memo] == DBNull.Value ? null : objRow[convCoursewareCase.Memo].ToString().Trim(); //备注
objvCoursewareCaseEN.OwnerName = objRow[convCoursewareCase.OwnerName] == DBNull.Value ? null : objRow[convCoursewareCase.OwnerName].ToString().Trim(); //拥有者姓名
objvCoursewareCaseEN.OwnerNameWithId = objRow[convCoursewareCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convCoursewareCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCoursewareCaseEN.BrowseCount4Case = objRow[convCoursewareCase.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCoursewareCaseEN.IsHaveVideo = objRow[convCoursewareCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvCoursewareCaseDA: GetObjByDataRow)", objException.Message));
}
objvCoursewareCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCoursewareCaseEN;
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
objSQL = clsvCoursewareCaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCoursewareCaseEN._CurrTabName, convCoursewareCase.IdCoursewareCase, 8, "");
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
objSQL = clsvCoursewareCaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCoursewareCaseEN._CurrTabName, convCoursewareCase.IdCoursewareCase, 8, strPrefix);
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
 objSQL = clsvCoursewareCaseDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdCoursewareCase from vCoursewareCase where " + strCondition;
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
 objSQL = clsvCoursewareCaseDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdCoursewareCase from vCoursewareCase where " + strCondition;
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
 /// <param name = "strIdCoursewareCase">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strIdCoursewareCase)
{
CheckPrimaryKey(strIdCoursewareCase);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCoursewareCase", "IdCoursewareCase = " + "'"+ strIdCoursewareCase+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvCoursewareCaseDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCoursewareCase", strCondition))
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
objSQL = clsvCoursewareCaseDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vCoursewareCase");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvCoursewareCaseENS">源对象</param>
 /// <param name = "objvCoursewareCaseENT">目标对象</param>
public void CopyTo(clsvCoursewareCaseEN objvCoursewareCaseENS, clsvCoursewareCaseEN objvCoursewareCaseENT)
{
objvCoursewareCaseENT.IdCoursewareCase = objvCoursewareCaseENS.IdCoursewareCase; //课件教学案例流水号
objvCoursewareCaseENT.CoursewareCaseID = objvCoursewareCaseENS.CoursewareCaseID; //课件教学案例ID
objvCoursewareCaseENT.CoursewareCaseName = objvCoursewareCaseENS.CoursewareCaseName; //课件教学案例名称
objvCoursewareCaseENT.CoursewareCaseTheme = objvCoursewareCaseENS.CoursewareCaseTheme; //课件教学案例主题词
objvCoursewareCaseENT.IdCoursewareCaseType = objvCoursewareCaseENS.IdCoursewareCaseType; //课件案例类型流水号
objvCoursewareCaseENT.CoursewareCaseTypeName = objvCoursewareCaseENS.CoursewareCaseTypeName; //课件案例类型名称
objvCoursewareCaseENT.CoursewareCaseText = objvCoursewareCaseENS.CoursewareCaseText; //案例文本内容
objvCoursewareCaseENT.CoursewareCaseDate = objvCoursewareCaseENS.CoursewareCaseDate; //课件教学日期
objvCoursewareCaseENT.CoursewareCaseTime = objvCoursewareCaseENS.CoursewareCaseTime; //课件教学时间
objvCoursewareCaseENT.CoursewareCaseDateIn = objvCoursewareCaseENS.CoursewareCaseDateIn; //案例入库日期
objvCoursewareCaseENT.CoursewareCaseTimeIn = objvCoursewareCaseENS.CoursewareCaseTimeIn; //案例入库时间
objvCoursewareCaseENT.IdStudyLevel = objvCoursewareCaseENS.IdStudyLevel; //id_StudyLevel
objvCoursewareCaseENT.StudyLevelName = objvCoursewareCaseENS.StudyLevelName; //学段名称
objvCoursewareCaseENT.IdTeachingPlan = objvCoursewareCaseENS.IdTeachingPlan; //教案流水号
objvCoursewareCaseENT.IdCaseType = objvCoursewareCaseENS.IdCaseType; //案例类型流水号
objvCoursewareCaseENT.IdDiscipline = objvCoursewareCaseENS.IdDiscipline; //学科流水号
objvCoursewareCaseENT.DisciplineID = objvCoursewareCaseENS.DisciplineID; //学科ID
objvCoursewareCaseENT.DisciplineName = objvCoursewareCaseENS.DisciplineName; //学科名称
objvCoursewareCaseENT.IdSenateGaugeVersion = objvCoursewareCaseENS.IdSenateGaugeVersion; //评价量表版本流水号
objvCoursewareCaseENT.senateGaugeVersionID = objvCoursewareCaseENS.senateGaugeVersionID; //评价量表版本ID
objvCoursewareCaseENT.senateGaugeVersionName = objvCoursewareCaseENS.senateGaugeVersionName; //评价量表版本名称
objvCoursewareCaseENT.senateGaugeVersionTtlScore = objvCoursewareCaseENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvCoursewareCaseENT.VersionNo = objvCoursewareCaseENS.VersionNo; //版本号
objvCoursewareCaseENT.IdTeachSkill = objvCoursewareCaseENS.IdTeachSkill; //教学技能流水号
objvCoursewareCaseENT.TeachSkillID = objvCoursewareCaseENS.TeachSkillID; //教学技能ID
objvCoursewareCaseENT.SkillTypeName = objvCoursewareCaseENS.SkillTypeName; //技能类型名称
objvCoursewareCaseENT.TeachSkillName = objvCoursewareCaseENS.TeachSkillName; //教学技能名称
objvCoursewareCaseENT.TeachSkillTheory = objvCoursewareCaseENS.TeachSkillTheory; //教学技能理论阐述
objvCoursewareCaseENT.TeachSkillOperMethod = objvCoursewareCaseENS.TeachSkillOperMethod; //教学技能实践操作方法
objvCoursewareCaseENT.IdSkillType = objvCoursewareCaseENS.IdSkillType; //技能类型流水号
objvCoursewareCaseENT.SkillTypeID = objvCoursewareCaseENS.SkillTypeID; //技能类型ID
objvCoursewareCaseENT.CaseLevelId = objvCoursewareCaseENS.CaseLevelId; //课例等级Id
objvCoursewareCaseENT.CaseLevelName = objvCoursewareCaseENS.CaseLevelName; //案例等级名称
objvCoursewareCaseENT.DocFile = objvCoursewareCaseENS.DocFile; //生成的Word文件名
objvCoursewareCaseENT.IsNeedGeneWord = objvCoursewareCaseENS.IsNeedGeneWord; //是否需要生成Word
objvCoursewareCaseENT.WordCreateDate = objvCoursewareCaseENS.WordCreateDate; //Word生成日期
objvCoursewareCaseENT.IsVisible = objvCoursewareCaseENS.IsVisible; //是否显示
objvCoursewareCaseENT.OwnerId = objvCoursewareCaseENS.OwnerId; //拥有者Id
objvCoursewareCaseENT.IdStudentInfo = objvCoursewareCaseENS.IdStudentInfo; //学生流水号
objvCoursewareCaseENT.StuName = objvCoursewareCaseENS.StuName; //姓名
objvCoursewareCaseENT.StuID = objvCoursewareCaseENS.StuID; //学号
objvCoursewareCaseENT.PoliticsName = objvCoursewareCaseENS.PoliticsName; //政治面貌
objvCoursewareCaseENT.SexDesc = objvCoursewareCaseENS.SexDesc; //性别名称
objvCoursewareCaseENT.EthnicName = objvCoursewareCaseENS.EthnicName; //民族名称
objvCoursewareCaseENT.UniZoneDesc = objvCoursewareCaseENS.UniZoneDesc; //校区名称
objvCoursewareCaseENT.StuTypeDesc = objvCoursewareCaseENS.StuTypeDesc; //学生类别名称
objvCoursewareCaseENT.IdXzCollege = objvCoursewareCaseENS.IdXzCollege; //学院流水号
objvCoursewareCaseENT.CollegeID = objvCoursewareCaseENS.CollegeID; //学院ID
objvCoursewareCaseENT.CollegeName = objvCoursewareCaseENS.CollegeName; //学院名称
objvCoursewareCaseENT.CollegeNameA = objvCoursewareCaseENS.CollegeNameA; //学院名称简写
objvCoursewareCaseENT.IdXzMajor = objvCoursewareCaseENS.IdXzMajor; //专业流水号
objvCoursewareCaseENT.MajorName = objvCoursewareCaseENS.MajorName; //专业名称
objvCoursewareCaseENT.IdGradeBase = objvCoursewareCaseENS.IdGradeBase; //年级流水号
objvCoursewareCaseENT.GradeBaseName = objvCoursewareCaseENS.GradeBaseName; //年级名称
objvCoursewareCaseENT.IdAdminCls = objvCoursewareCaseENS.IdAdminCls; //行政班流水号
objvCoursewareCaseENT.AdminClsId = objvCoursewareCaseENS.AdminClsId; //行政班代号
objvCoursewareCaseENT.AdminClsName = objvCoursewareCaseENS.AdminClsName; //行政班名称
objvCoursewareCaseENT.Birthday = objvCoursewareCaseENS.Birthday; //出生日期
objvCoursewareCaseENT.NativePlace = objvCoursewareCaseENS.NativePlace; //籍贯
objvCoursewareCaseENT.Duty = objvCoursewareCaseENS.Duty; //职位
objvCoursewareCaseENT.IDCardNo = objvCoursewareCaseENS.IDCardNo; //身份证号
objvCoursewareCaseENT.StuCardNo = objvCoursewareCaseENS.StuCardNo; //学生证号
objvCoursewareCaseENT.LiveAddress = objvCoursewareCaseENS.LiveAddress; //居住地址
objvCoursewareCaseENT.HomePhone = objvCoursewareCaseENS.HomePhone; //住宅电话
objvCoursewareCaseENT.EnrollmentDate = objvCoursewareCaseENS.EnrollmentDate; //入校日期
objvCoursewareCaseENT.PostCode = objvCoursewareCaseENS.PostCode; //邮编
objvCoursewareCaseENT.UserKindId = objvCoursewareCaseENS.UserKindId; //用户类别Id
objvCoursewareCaseENT.UserKindName = objvCoursewareCaseENS.UserKindName; //用户类别名
objvCoursewareCaseENT.UserTypeId = objvCoursewareCaseENS.UserTypeId; //用户类型Id
objvCoursewareCaseENT.UserTypeName = objvCoursewareCaseENS.UserTypeName; //用户类型名称
objvCoursewareCaseENT.IsDualVideo = objvCoursewareCaseENS.IsDualVideo; //是否双视频
objvCoursewareCaseENT.RecommendedDegreeId = objvCoursewareCaseENS.RecommendedDegreeId; //推荐度Id
objvCoursewareCaseENT.RecommendedDegreeName = objvCoursewareCaseENS.RecommendedDegreeName; //推荐度名称
objvCoursewareCaseENT.ftpFileType = objvCoursewareCaseENS.ftpFileType; //ftp文件类型
objvCoursewareCaseENT.VideoUrl = objvCoursewareCaseENS.VideoUrl; //视频Url
objvCoursewareCaseENT.VideoPath = objvCoursewareCaseENS.VideoPath; //视频目录
objvCoursewareCaseENT.ResErrMsg = objvCoursewareCaseENS.ResErrMsg; //资源错误信息
objvCoursewareCaseENT.Memo = objvCoursewareCaseENS.Memo; //备注
objvCoursewareCaseENT.OwnerName = objvCoursewareCaseENS.OwnerName; //拥有者姓名
objvCoursewareCaseENT.OwnerNameWithId = objvCoursewareCaseENS.OwnerNameWithId; //拥有者名称附Id
objvCoursewareCaseENT.BrowseCount4Case = objvCoursewareCaseENS.BrowseCount4Case; //课例浏览次数
objvCoursewareCaseENT.IsHaveVideo = objvCoursewareCaseENS.IsHaveVideo; //IsHaveVideo
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvCoursewareCaseEN objvCoursewareCaseEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.IdCoursewareCase, 8, convCoursewareCase.IdCoursewareCase);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.CoursewareCaseID, 8, convCoursewareCase.CoursewareCaseID);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.CoursewareCaseName, 100, convCoursewareCase.CoursewareCaseName);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.CoursewareCaseTheme, 200, convCoursewareCase.CoursewareCaseTheme);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.IdCoursewareCaseType, 4, convCoursewareCase.IdCoursewareCaseType);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.CoursewareCaseTypeName, 50, convCoursewareCase.CoursewareCaseTypeName);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.CoursewareCaseText, 8000, convCoursewareCase.CoursewareCaseText);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.CoursewareCaseDate, 8, convCoursewareCase.CoursewareCaseDate);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.CoursewareCaseTime, 6, convCoursewareCase.CoursewareCaseTime);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.CoursewareCaseDateIn, 8, convCoursewareCase.CoursewareCaseDateIn);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.CoursewareCaseTimeIn, 6, convCoursewareCase.CoursewareCaseTimeIn);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.IdStudyLevel, 4, convCoursewareCase.IdStudyLevel);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.StudyLevelName, 50, convCoursewareCase.StudyLevelName);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.IdTeachingPlan, 8, convCoursewareCase.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.IdCaseType, 4, convCoursewareCase.IdCaseType);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.IdDiscipline, 4, convCoursewareCase.IdDiscipline);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.DisciplineID, 4, convCoursewareCase.DisciplineID);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.DisciplineName, 50, convCoursewareCase.DisciplineName);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.IdSenateGaugeVersion, 4, convCoursewareCase.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.senateGaugeVersionID, 4, convCoursewareCase.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.senateGaugeVersionName, 200, convCoursewareCase.senateGaugeVersionName);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.IdTeachSkill, 8, convCoursewareCase.IdTeachSkill);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.TeachSkillID, 8, convCoursewareCase.TeachSkillID);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.SkillTypeName, 50, convCoursewareCase.SkillTypeName);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.TeachSkillName, 50, convCoursewareCase.TeachSkillName);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.TeachSkillTheory, 8000, convCoursewareCase.TeachSkillTheory);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.TeachSkillOperMethod, 2000, convCoursewareCase.TeachSkillOperMethod);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.IdSkillType, 4, convCoursewareCase.IdSkillType);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.SkillTypeID, 4, convCoursewareCase.SkillTypeID);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.CaseLevelId, 2, convCoursewareCase.CaseLevelId);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.CaseLevelName, 30, convCoursewareCase.CaseLevelName);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.DocFile, 200, convCoursewareCase.DocFile);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.WordCreateDate, 14, convCoursewareCase.WordCreateDate);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.OwnerId, 20, convCoursewareCase.OwnerId);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.IdStudentInfo, 8, convCoursewareCase.IdStudentInfo);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.StuName, 50, convCoursewareCase.StuName);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.StuID, 20, convCoursewareCase.StuID);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.PoliticsName, 30, convCoursewareCase.PoliticsName);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.SexDesc, 10, convCoursewareCase.SexDesc);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.EthnicName, 30, convCoursewareCase.EthnicName);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.UniZoneDesc, 20, convCoursewareCase.UniZoneDesc);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.StuTypeDesc, 50, convCoursewareCase.StuTypeDesc);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.IdXzCollege, 4, convCoursewareCase.IdXzCollege);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.CollegeID, 4, convCoursewareCase.CollegeID);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.CollegeName, 100, convCoursewareCase.CollegeName);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.CollegeNameA, 12, convCoursewareCase.CollegeNameA);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.IdXzMajor, 8, convCoursewareCase.IdXzMajor);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.MajorName, 100, convCoursewareCase.MajorName);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.IdGradeBase, 4, convCoursewareCase.IdGradeBase);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.GradeBaseName, 50, convCoursewareCase.GradeBaseName);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.IdAdminCls, 8, convCoursewareCase.IdAdminCls);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.AdminClsId, 8, convCoursewareCase.AdminClsId);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.AdminClsName, 100, convCoursewareCase.AdminClsName);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.Birthday, 8, convCoursewareCase.Birthday);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.NativePlace, 200, convCoursewareCase.NativePlace);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.Duty, 30, convCoursewareCase.Duty);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.IDCardNo, 20, convCoursewareCase.IDCardNo);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.StuCardNo, 20, convCoursewareCase.StuCardNo);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.LiveAddress, 200, convCoursewareCase.LiveAddress);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.HomePhone, 20, convCoursewareCase.HomePhone);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.EnrollmentDate, 8, convCoursewareCase.EnrollmentDate);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.PostCode, 6, convCoursewareCase.PostCode);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.UserKindId, 2, convCoursewareCase.UserKindId);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.UserKindName, 30, convCoursewareCase.UserKindName);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.UserTypeId, 2, convCoursewareCase.UserTypeId);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.UserTypeName, 20, convCoursewareCase.UserTypeName);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.RecommendedDegreeId, 2, convCoursewareCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.RecommendedDegreeName, 30, convCoursewareCase.RecommendedDegreeName);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.ftpFileType, 30, convCoursewareCase.ftpFileType);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.VideoUrl, 1000, convCoursewareCase.VideoUrl);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.VideoPath, 1000, convCoursewareCase.VideoPath);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.ResErrMsg, 30, convCoursewareCase.ResErrMsg);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.Memo, 1000, convCoursewareCase.Memo);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.OwnerName, 30, convCoursewareCase.OwnerName);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.OwnerNameWithId, 51, convCoursewareCase.OwnerNameWithId);
clsCheckSql.CheckFieldLen(objvCoursewareCaseEN.IsHaveVideo, 6, convCoursewareCase.IsHaveVideo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.IdCoursewareCase, convCoursewareCase.IdCoursewareCase);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.CoursewareCaseID, convCoursewareCase.CoursewareCaseID);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.CoursewareCaseName, convCoursewareCase.CoursewareCaseName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.CoursewareCaseTheme, convCoursewareCase.CoursewareCaseTheme);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.IdCoursewareCaseType, convCoursewareCase.IdCoursewareCaseType);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.CoursewareCaseTypeName, convCoursewareCase.CoursewareCaseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.CoursewareCaseText, convCoursewareCase.CoursewareCaseText);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.CoursewareCaseDate, convCoursewareCase.CoursewareCaseDate);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.CoursewareCaseTime, convCoursewareCase.CoursewareCaseTime);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.CoursewareCaseDateIn, convCoursewareCase.CoursewareCaseDateIn);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.CoursewareCaseTimeIn, convCoursewareCase.CoursewareCaseTimeIn);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.IdStudyLevel, convCoursewareCase.IdStudyLevel);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.StudyLevelName, convCoursewareCase.StudyLevelName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.IdTeachingPlan, convCoursewareCase.IdTeachingPlan);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.IdCaseType, convCoursewareCase.IdCaseType);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.IdDiscipline, convCoursewareCase.IdDiscipline);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.DisciplineID, convCoursewareCase.DisciplineID);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.DisciplineName, convCoursewareCase.DisciplineName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.IdSenateGaugeVersion, convCoursewareCase.IdSenateGaugeVersion);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.senateGaugeVersionID, convCoursewareCase.senateGaugeVersionID);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.senateGaugeVersionName, convCoursewareCase.senateGaugeVersionName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.IdTeachSkill, convCoursewareCase.IdTeachSkill);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.TeachSkillID, convCoursewareCase.TeachSkillID);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.SkillTypeName, convCoursewareCase.SkillTypeName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.TeachSkillName, convCoursewareCase.TeachSkillName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.TeachSkillTheory, convCoursewareCase.TeachSkillTheory);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.TeachSkillOperMethod, convCoursewareCase.TeachSkillOperMethod);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.IdSkillType, convCoursewareCase.IdSkillType);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.SkillTypeID, convCoursewareCase.SkillTypeID);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.CaseLevelId, convCoursewareCase.CaseLevelId);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.CaseLevelName, convCoursewareCase.CaseLevelName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.DocFile, convCoursewareCase.DocFile);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.WordCreateDate, convCoursewareCase.WordCreateDate);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.OwnerId, convCoursewareCase.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.IdStudentInfo, convCoursewareCase.IdStudentInfo);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.StuName, convCoursewareCase.StuName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.StuID, convCoursewareCase.StuID);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.PoliticsName, convCoursewareCase.PoliticsName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.SexDesc, convCoursewareCase.SexDesc);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.EthnicName, convCoursewareCase.EthnicName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.UniZoneDesc, convCoursewareCase.UniZoneDesc);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.StuTypeDesc, convCoursewareCase.StuTypeDesc);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.IdXzCollege, convCoursewareCase.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.CollegeID, convCoursewareCase.CollegeID);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.CollegeName, convCoursewareCase.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.CollegeNameA, convCoursewareCase.CollegeNameA);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.IdXzMajor, convCoursewareCase.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.MajorName, convCoursewareCase.MajorName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.IdGradeBase, convCoursewareCase.IdGradeBase);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.GradeBaseName, convCoursewareCase.GradeBaseName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.IdAdminCls, convCoursewareCase.IdAdminCls);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.AdminClsId, convCoursewareCase.AdminClsId);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.AdminClsName, convCoursewareCase.AdminClsName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.Birthday, convCoursewareCase.Birthday);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.NativePlace, convCoursewareCase.NativePlace);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.Duty, convCoursewareCase.Duty);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.IDCardNo, convCoursewareCase.IDCardNo);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.StuCardNo, convCoursewareCase.StuCardNo);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.LiveAddress, convCoursewareCase.LiveAddress);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.HomePhone, convCoursewareCase.HomePhone);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.EnrollmentDate, convCoursewareCase.EnrollmentDate);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.PostCode, convCoursewareCase.PostCode);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.UserKindId, convCoursewareCase.UserKindId);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.UserKindName, convCoursewareCase.UserKindName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.UserTypeId, convCoursewareCase.UserTypeId);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.UserTypeName, convCoursewareCase.UserTypeName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.RecommendedDegreeId, convCoursewareCase.RecommendedDegreeId);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.RecommendedDegreeName, convCoursewareCase.RecommendedDegreeName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.ftpFileType, convCoursewareCase.ftpFileType);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.VideoUrl, convCoursewareCase.VideoUrl);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.VideoPath, convCoursewareCase.VideoPath);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.ResErrMsg, convCoursewareCase.ResErrMsg);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.Memo, convCoursewareCase.Memo);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.OwnerName, convCoursewareCase.OwnerName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.OwnerNameWithId, convCoursewareCase.OwnerNameWithId);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseEN.IsHaveVideo, convCoursewareCase.IsHaveVideo);
//检查外键字段长度
 objvCoursewareCaseEN._IsCheckProperty = true;
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
 objSQL = clsvCoursewareCaseDA.GetSpecSQLObj();
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
 objSQL = clsvCoursewareCaseDA.GetSpecSQLObj();
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
 objSQL = clsvCoursewareCaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCoursewareCaseEN._CurrTabName);
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
 objSQL = clsvCoursewareCaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCoursewareCaseEN._CurrTabName, strCondition);
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
 objSQL = clsvCoursewareCaseDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}