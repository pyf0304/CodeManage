
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCoursewareCase_BaseDA
 表名:vCoursewareCase_Base(01120494)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:46:06
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
 /// v课件教学案例_Base(vCoursewareCase_Base)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvCoursewareCase_BaseDA : clsCommBase4DA
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
 return clsvCoursewareCase_BaseEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvCoursewareCase_BaseEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCoursewareCase_BaseEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvCoursewareCase_BaseEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvCoursewareCase_BaseEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:vCoursewareCase_Base中,检查关键字,长度不正确!(clsvCoursewareCase_BaseDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdCoursewareCase)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vCoursewareCase_Base中,关键字不能为空 或 null!(clsvCoursewareCase_BaseDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdCoursewareCase);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvCoursewareCase_BaseDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvCoursewareCase_BaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCase_BaseDA.GetSpecSQLObj();
strSQL = "Select * from vCoursewareCase_Base where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vCoursewareCase_Base(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvCoursewareCase_BaseDA: GetDataTable_vCoursewareCase_Base)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCase_BaseDA.GetSpecSQLObj();
strSQL = "Select * from vCoursewareCase_Base where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvCoursewareCase_BaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCase_BaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvCoursewareCase_BaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCase_BaseDA.GetSpecSQLObj();
strSQL = "Select * from vCoursewareCase_Base where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvCoursewareCase_BaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCase_BaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvCoursewareCase_BaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCase_BaseDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCoursewareCase_Base where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCoursewareCase_Base where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvCoursewareCase_BaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCase_BaseDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vCoursewareCase_Base where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvCoursewareCase_BaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCase_BaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vCoursewareCase_Base.* from vCoursewareCase_Base Left Join {1} on {2} where {3} and vCoursewareCase_Base.IdCoursewareCase not in (Select top {5} vCoursewareCase_Base.IdCoursewareCase from vCoursewareCase_Base Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCoursewareCase_Base where {1} and IdCoursewareCase not in (Select top {2} IdCoursewareCase from vCoursewareCase_Base where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCoursewareCase_Base where {1} and IdCoursewareCase not in (Select top {3} IdCoursewareCase from vCoursewareCase_Base where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvCoursewareCase_BaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCase_BaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vCoursewareCase_Base.* from vCoursewareCase_Base Left Join {1} on {2} where {3} and vCoursewareCase_Base.IdCoursewareCase not in (Select top {5} vCoursewareCase_Base.IdCoursewareCase from vCoursewareCase_Base Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCoursewareCase_Base where {1} and IdCoursewareCase not in (Select top {2} IdCoursewareCase from vCoursewareCase_Base where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCoursewareCase_Base where {1} and IdCoursewareCase not in (Select top {3} IdCoursewareCase from vCoursewareCase_Base where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvCoursewareCase_BaseEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvCoursewareCase_BaseDA:GetObjLst)", objException.Message));
}
List<clsvCoursewareCase_BaseEN> arrObjLst = new List<clsvCoursewareCase_BaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCase_BaseDA.GetSpecSQLObj();
strSQL = "Select * from vCoursewareCase_Base where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN = new clsvCoursewareCase_BaseEN();
try
{
objvCoursewareCase_BaseEN.IdCoursewareCase = objRow[convCoursewareCase_Base.IdCoursewareCase].ToString().Trim(); //课件教学案例流水号
objvCoursewareCase_BaseEN.CoursewareCaseID = objRow[convCoursewareCase_Base.CoursewareCaseID].ToString().Trim(); //课件教学案例ID
objvCoursewareCase_BaseEN.CoursewareCaseName = objRow[convCoursewareCase_Base.CoursewareCaseName].ToString().Trim(); //课件教学案例名称
objvCoursewareCase_BaseEN.CoursewareCaseTheme = objRow[convCoursewareCase_Base.CoursewareCaseTheme] == DBNull.Value ? null : objRow[convCoursewareCase_Base.CoursewareCaseTheme].ToString().Trim(); //课件教学案例主题词
objvCoursewareCase_BaseEN.IdCoursewareCaseType = objRow[convCoursewareCase_Base.IdCoursewareCaseType].ToString().Trim(); //课件案例类型流水号
objvCoursewareCase_BaseEN.CoursewareCaseTypeName = objRow[convCoursewareCase_Base.CoursewareCaseTypeName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.CoursewareCaseTypeName].ToString().Trim(); //课件案例类型名称
objvCoursewareCase_BaseEN.CoursewareCaseText = objRow[convCoursewareCase_Base.CoursewareCaseText] == DBNull.Value ? null : objRow[convCoursewareCase_Base.CoursewareCaseText].ToString().Trim(); //案例文本内容
objvCoursewareCase_BaseEN.CoursewareCaseDate = objRow[convCoursewareCase_Base.CoursewareCaseDate] == DBNull.Value ? null : objRow[convCoursewareCase_Base.CoursewareCaseDate].ToString().Trim(); //课件教学日期
objvCoursewareCase_BaseEN.CoursewareCaseTime = objRow[convCoursewareCase_Base.CoursewareCaseTime] == DBNull.Value ? null : objRow[convCoursewareCase_Base.CoursewareCaseTime].ToString().Trim(); //课件教学时间
objvCoursewareCase_BaseEN.CoursewareCaseDateIn = objRow[convCoursewareCase_Base.CoursewareCaseDateIn] == DBNull.Value ? null : objRow[convCoursewareCase_Base.CoursewareCaseDateIn].ToString().Trim(); //案例入库日期
objvCoursewareCase_BaseEN.CoursewareCaseTimeIn = objRow[convCoursewareCase_Base.CoursewareCaseTimeIn] == DBNull.Value ? null : objRow[convCoursewareCase_Base.CoursewareCaseTimeIn].ToString().Trim(); //案例入库时间
objvCoursewareCase_BaseEN.IdStudyLevel = objRow[convCoursewareCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCoursewareCase_BaseEN.StudyLevelName = objRow[convCoursewareCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.StudyLevelName].ToString().Trim(); //学段名称
objvCoursewareCase_BaseEN.IdTeachingPlan = objRow[convCoursewareCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convCoursewareCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCoursewareCase_BaseEN.IdCaseType = objRow[convCoursewareCase_Base.IdCaseType] == DBNull.Value ? null : objRow[convCoursewareCase_Base.IdCaseType].ToString().Trim(); //案例类型流水号
objvCoursewareCase_BaseEN.IdDiscipline = objRow[convCoursewareCase_Base.IdDiscipline].ToString().Trim(); //学科流水号
objvCoursewareCase_BaseEN.DisciplineID = objRow[convCoursewareCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convCoursewareCase_Base.DisciplineID].ToString().Trim(); //学科ID
objvCoursewareCase_BaseEN.DisciplineName = objRow[convCoursewareCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.DisciplineName].ToString().Trim(); //学科名称
objvCoursewareCase_BaseEN.IdSenateGaugeVersion = objRow[convCoursewareCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convCoursewareCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCoursewareCase_BaseEN.senateGaugeVersionID = objRow[convCoursewareCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCoursewareCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCoursewareCase_BaseEN.senateGaugeVersionName = objRow[convCoursewareCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCoursewareCase_BaseEN.senateGaugeVersionTtlScore = objRow[convCoursewareCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convCoursewareCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCoursewareCase_BaseEN.VersionNo = objRow[convCoursewareCase_Base.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareCase_Base.VersionNo].ToString().Trim()); //版本号
objvCoursewareCase_BaseEN.IdTeachSkill = objRow[convCoursewareCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCoursewareCase_BaseEN.TeachSkillID = objRow[convCoursewareCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convCoursewareCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID
objvCoursewareCase_BaseEN.SkillTypeName = objRow[convCoursewareCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称
objvCoursewareCase_BaseEN.TeachSkillName = objRow[convCoursewareCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称
objvCoursewareCase_BaseEN.TeachSkillTheory = objRow[convCoursewareCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convCoursewareCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCoursewareCase_BaseEN.TeachSkillOperMethod = objRow[convCoursewareCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCoursewareCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCoursewareCase_BaseEN.IdSkillType = objRow[convCoursewareCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convCoursewareCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号
objvCoursewareCase_BaseEN.SkillTypeID = objRow[convCoursewareCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convCoursewareCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID
objvCoursewareCase_BaseEN.CaseLevelId = objRow[convCoursewareCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convCoursewareCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvCoursewareCase_BaseEN.CaseLevelName = objRow[convCoursewareCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvCoursewareCase_BaseEN.DocFile = objRow[convCoursewareCase_Base.DocFile] == DBNull.Value ? null : objRow[convCoursewareCase_Base.DocFile].ToString().Trim(); //生成的Word文件名
objvCoursewareCase_BaseEN.IsNeedGeneWord = TransNullToBool(objRow[convCoursewareCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvCoursewareCase_BaseEN.WordCreateDate = objRow[convCoursewareCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convCoursewareCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期
objvCoursewareCase_BaseEN.IsVisible = TransNullToBool(objRow[convCoursewareCase_Base.IsVisible].ToString().Trim()); //是否显示
objvCoursewareCase_BaseEN.OwnerId = objRow[convCoursewareCase_Base.OwnerId].ToString().Trim(); //拥有者Id
objvCoursewareCase_BaseEN.IdStudentInfo = objRow[convCoursewareCase_Base.IdStudentInfo] == DBNull.Value ? null : objRow[convCoursewareCase_Base.IdStudentInfo].ToString().Trim(); //学生流水号
objvCoursewareCase_BaseEN.StuName = objRow[convCoursewareCase_Base.StuName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.StuName].ToString().Trim(); //姓名
objvCoursewareCase_BaseEN.StuID = objRow[convCoursewareCase_Base.StuID] == DBNull.Value ? null : objRow[convCoursewareCase_Base.StuID].ToString().Trim(); //学号
objvCoursewareCase_BaseEN.PoliticsName = objRow[convCoursewareCase_Base.PoliticsName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.PoliticsName].ToString().Trim(); //政治面貌
objvCoursewareCase_BaseEN.SexDesc = objRow[convCoursewareCase_Base.SexDesc] == DBNull.Value ? null : objRow[convCoursewareCase_Base.SexDesc].ToString().Trim(); //性别名称
objvCoursewareCase_BaseEN.EthnicName = objRow[convCoursewareCase_Base.EthnicName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.EthnicName].ToString().Trim(); //民族名称
objvCoursewareCase_BaseEN.UniZoneDesc = objRow[convCoursewareCase_Base.UniZoneDesc] == DBNull.Value ? null : objRow[convCoursewareCase_Base.UniZoneDesc].ToString().Trim(); //校区名称
objvCoursewareCase_BaseEN.StuTypeDesc = objRow[convCoursewareCase_Base.StuTypeDesc] == DBNull.Value ? null : objRow[convCoursewareCase_Base.StuTypeDesc].ToString().Trim(); //学生类别名称
objvCoursewareCase_BaseEN.IdXzCollege = objRow[convCoursewareCase_Base.IdXzCollege] == DBNull.Value ? null : objRow[convCoursewareCase_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvCoursewareCase_BaseEN.CollegeID = objRow[convCoursewareCase_Base.CollegeID] == DBNull.Value ? null : objRow[convCoursewareCase_Base.CollegeID].ToString().Trim(); //学院ID
objvCoursewareCase_BaseEN.CollegeName = objRow[convCoursewareCase_Base.CollegeName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.CollegeName].ToString().Trim(); //学院名称
objvCoursewareCase_BaseEN.CollegeNameA = objRow[convCoursewareCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convCoursewareCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvCoursewareCase_BaseEN.IdXzMajor = objRow[convCoursewareCase_Base.IdXzMajor] == DBNull.Value ? null : objRow[convCoursewareCase_Base.IdXzMajor].ToString().Trim(); //专业流水号
objvCoursewareCase_BaseEN.MajorName = objRow[convCoursewareCase_Base.MajorName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.MajorName].ToString().Trim(); //专业名称
objvCoursewareCase_BaseEN.IdGradeBase = objRow[convCoursewareCase_Base.IdGradeBase] == DBNull.Value ? null : objRow[convCoursewareCase_Base.IdGradeBase].ToString().Trim(); //年级流水号
objvCoursewareCase_BaseEN.GradeBaseName = objRow[convCoursewareCase_Base.GradeBaseName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.GradeBaseName].ToString().Trim(); //年级名称
objvCoursewareCase_BaseEN.IdAdminCls = objRow[convCoursewareCase_Base.IdAdminCls] == DBNull.Value ? null : objRow[convCoursewareCase_Base.IdAdminCls].ToString().Trim(); //行政班流水号
objvCoursewareCase_BaseEN.AdminClsId = objRow[convCoursewareCase_Base.AdminClsId] == DBNull.Value ? null : objRow[convCoursewareCase_Base.AdminClsId].ToString().Trim(); //行政班代号
objvCoursewareCase_BaseEN.AdminClsName = objRow[convCoursewareCase_Base.AdminClsName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.AdminClsName].ToString().Trim(); //行政班名称
objvCoursewareCase_BaseEN.Birthday = objRow[convCoursewareCase_Base.Birthday] == DBNull.Value ? null : objRow[convCoursewareCase_Base.Birthday].ToString().Trim(); //出生日期
objvCoursewareCase_BaseEN.NativePlace = objRow[convCoursewareCase_Base.NativePlace] == DBNull.Value ? null : objRow[convCoursewareCase_Base.NativePlace].ToString().Trim(); //籍贯
objvCoursewareCase_BaseEN.Duty = objRow[convCoursewareCase_Base.Duty] == DBNull.Value ? null : objRow[convCoursewareCase_Base.Duty].ToString().Trim(); //职位
objvCoursewareCase_BaseEN.IDCardNo = objRow[convCoursewareCase_Base.IDCardNo] == DBNull.Value ? null : objRow[convCoursewareCase_Base.IDCardNo].ToString().Trim(); //身份证号
objvCoursewareCase_BaseEN.StuCardNo = objRow[convCoursewareCase_Base.StuCardNo] == DBNull.Value ? null : objRow[convCoursewareCase_Base.StuCardNo].ToString().Trim(); //学生证号
objvCoursewareCase_BaseEN.LiveAddress = objRow[convCoursewareCase_Base.LiveAddress] == DBNull.Value ? null : objRow[convCoursewareCase_Base.LiveAddress].ToString().Trim(); //居住地址
objvCoursewareCase_BaseEN.HomePhone = objRow[convCoursewareCase_Base.HomePhone] == DBNull.Value ? null : objRow[convCoursewareCase_Base.HomePhone].ToString().Trim(); //住宅电话
objvCoursewareCase_BaseEN.EnrollmentDate = objRow[convCoursewareCase_Base.EnrollmentDate] == DBNull.Value ? null : objRow[convCoursewareCase_Base.EnrollmentDate].ToString().Trim(); //入校日期
objvCoursewareCase_BaseEN.PostCode = objRow[convCoursewareCase_Base.PostCode] == DBNull.Value ? null : objRow[convCoursewareCase_Base.PostCode].ToString().Trim(); //邮编
objvCoursewareCase_BaseEN.UserKindId = objRow[convCoursewareCase_Base.UserKindId].ToString().Trim(); //用户类别Id
objvCoursewareCase_BaseEN.UserKindName = objRow[convCoursewareCase_Base.UserKindName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.UserKindName].ToString().Trim(); //用户类别名
objvCoursewareCase_BaseEN.UserTypeId = objRow[convCoursewareCase_Base.UserTypeId] == DBNull.Value ? null : objRow[convCoursewareCase_Base.UserTypeId].ToString().Trim(); //用户类型Id
objvCoursewareCase_BaseEN.IsDualVideo = TransNullToBool(objRow[convCoursewareCase_Base.IsDualVideo].ToString().Trim()); //是否双视频
objvCoursewareCase_BaseEN.RecommendedDegreeId = objRow[convCoursewareCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCoursewareCase_BaseEN.RecommendedDegreeName = objRow[convCoursewareCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCoursewareCase_BaseEN.ftpFileType = objRow[convCoursewareCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convCoursewareCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvCoursewareCase_BaseEN.VideoUrl = objRow[convCoursewareCase_Base.VideoUrl] == DBNull.Value ? null : objRow[convCoursewareCase_Base.VideoUrl].ToString().Trim(); //视频Url
objvCoursewareCase_BaseEN.VideoPath = objRow[convCoursewareCase_Base.VideoPath] == DBNull.Value ? null : objRow[convCoursewareCase_Base.VideoPath].ToString().Trim(); //视频目录
objvCoursewareCase_BaseEN.ResErrMsg = objRow[convCoursewareCase_Base.ResErrMsg] == DBNull.Value ? null : objRow[convCoursewareCase_Base.ResErrMsg].ToString().Trim(); //资源错误信息
objvCoursewareCase_BaseEN.Memo = objRow[convCoursewareCase_Base.Memo] == DBNull.Value ? null : objRow[convCoursewareCase_Base.Memo].ToString().Trim(); //备注
objvCoursewareCase_BaseEN.OwnerName = objRow[convCoursewareCase_Base.OwnerName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvCoursewareCase_BaseEN.OwnerNameWithId = objRow[convCoursewareCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convCoursewareCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCoursewareCase_BaseEN.BrowseCount4Case = objRow[convCoursewareCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCoursewareCase_BaseDA: GetObjLst)", objException.Message));
}
objvCoursewareCase_BaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCoursewareCase_BaseEN);
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
public List<clsvCoursewareCase_BaseEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvCoursewareCase_BaseDA:GetObjLstByTabName)", objException.Message));
}
List<clsvCoursewareCase_BaseEN> arrObjLst = new List<clsvCoursewareCase_BaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCase_BaseDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN = new clsvCoursewareCase_BaseEN();
try
{
objvCoursewareCase_BaseEN.IdCoursewareCase = objRow[convCoursewareCase_Base.IdCoursewareCase].ToString().Trim(); //课件教学案例流水号
objvCoursewareCase_BaseEN.CoursewareCaseID = objRow[convCoursewareCase_Base.CoursewareCaseID].ToString().Trim(); //课件教学案例ID
objvCoursewareCase_BaseEN.CoursewareCaseName = objRow[convCoursewareCase_Base.CoursewareCaseName].ToString().Trim(); //课件教学案例名称
objvCoursewareCase_BaseEN.CoursewareCaseTheme = objRow[convCoursewareCase_Base.CoursewareCaseTheme] == DBNull.Value ? null : objRow[convCoursewareCase_Base.CoursewareCaseTheme].ToString().Trim(); //课件教学案例主题词
objvCoursewareCase_BaseEN.IdCoursewareCaseType = objRow[convCoursewareCase_Base.IdCoursewareCaseType].ToString().Trim(); //课件案例类型流水号
objvCoursewareCase_BaseEN.CoursewareCaseTypeName = objRow[convCoursewareCase_Base.CoursewareCaseTypeName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.CoursewareCaseTypeName].ToString().Trim(); //课件案例类型名称
objvCoursewareCase_BaseEN.CoursewareCaseText = objRow[convCoursewareCase_Base.CoursewareCaseText] == DBNull.Value ? null : objRow[convCoursewareCase_Base.CoursewareCaseText].ToString().Trim(); //案例文本内容
objvCoursewareCase_BaseEN.CoursewareCaseDate = objRow[convCoursewareCase_Base.CoursewareCaseDate] == DBNull.Value ? null : objRow[convCoursewareCase_Base.CoursewareCaseDate].ToString().Trim(); //课件教学日期
objvCoursewareCase_BaseEN.CoursewareCaseTime = objRow[convCoursewareCase_Base.CoursewareCaseTime] == DBNull.Value ? null : objRow[convCoursewareCase_Base.CoursewareCaseTime].ToString().Trim(); //课件教学时间
objvCoursewareCase_BaseEN.CoursewareCaseDateIn = objRow[convCoursewareCase_Base.CoursewareCaseDateIn] == DBNull.Value ? null : objRow[convCoursewareCase_Base.CoursewareCaseDateIn].ToString().Trim(); //案例入库日期
objvCoursewareCase_BaseEN.CoursewareCaseTimeIn = objRow[convCoursewareCase_Base.CoursewareCaseTimeIn] == DBNull.Value ? null : objRow[convCoursewareCase_Base.CoursewareCaseTimeIn].ToString().Trim(); //案例入库时间
objvCoursewareCase_BaseEN.IdStudyLevel = objRow[convCoursewareCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCoursewareCase_BaseEN.StudyLevelName = objRow[convCoursewareCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.StudyLevelName].ToString().Trim(); //学段名称
objvCoursewareCase_BaseEN.IdTeachingPlan = objRow[convCoursewareCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convCoursewareCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCoursewareCase_BaseEN.IdCaseType = objRow[convCoursewareCase_Base.IdCaseType] == DBNull.Value ? null : objRow[convCoursewareCase_Base.IdCaseType].ToString().Trim(); //案例类型流水号
objvCoursewareCase_BaseEN.IdDiscipline = objRow[convCoursewareCase_Base.IdDiscipline].ToString().Trim(); //学科流水号
objvCoursewareCase_BaseEN.DisciplineID = objRow[convCoursewareCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convCoursewareCase_Base.DisciplineID].ToString().Trim(); //学科ID
objvCoursewareCase_BaseEN.DisciplineName = objRow[convCoursewareCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.DisciplineName].ToString().Trim(); //学科名称
objvCoursewareCase_BaseEN.IdSenateGaugeVersion = objRow[convCoursewareCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convCoursewareCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCoursewareCase_BaseEN.senateGaugeVersionID = objRow[convCoursewareCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCoursewareCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCoursewareCase_BaseEN.senateGaugeVersionName = objRow[convCoursewareCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCoursewareCase_BaseEN.senateGaugeVersionTtlScore = objRow[convCoursewareCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convCoursewareCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCoursewareCase_BaseEN.VersionNo = objRow[convCoursewareCase_Base.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareCase_Base.VersionNo].ToString().Trim()); //版本号
objvCoursewareCase_BaseEN.IdTeachSkill = objRow[convCoursewareCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCoursewareCase_BaseEN.TeachSkillID = objRow[convCoursewareCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convCoursewareCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID
objvCoursewareCase_BaseEN.SkillTypeName = objRow[convCoursewareCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称
objvCoursewareCase_BaseEN.TeachSkillName = objRow[convCoursewareCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称
objvCoursewareCase_BaseEN.TeachSkillTheory = objRow[convCoursewareCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convCoursewareCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCoursewareCase_BaseEN.TeachSkillOperMethod = objRow[convCoursewareCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCoursewareCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCoursewareCase_BaseEN.IdSkillType = objRow[convCoursewareCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convCoursewareCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号
objvCoursewareCase_BaseEN.SkillTypeID = objRow[convCoursewareCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convCoursewareCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID
objvCoursewareCase_BaseEN.CaseLevelId = objRow[convCoursewareCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convCoursewareCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvCoursewareCase_BaseEN.CaseLevelName = objRow[convCoursewareCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvCoursewareCase_BaseEN.DocFile = objRow[convCoursewareCase_Base.DocFile] == DBNull.Value ? null : objRow[convCoursewareCase_Base.DocFile].ToString().Trim(); //生成的Word文件名
objvCoursewareCase_BaseEN.IsNeedGeneWord = TransNullToBool(objRow[convCoursewareCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvCoursewareCase_BaseEN.WordCreateDate = objRow[convCoursewareCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convCoursewareCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期
objvCoursewareCase_BaseEN.IsVisible = TransNullToBool(objRow[convCoursewareCase_Base.IsVisible].ToString().Trim()); //是否显示
objvCoursewareCase_BaseEN.OwnerId = objRow[convCoursewareCase_Base.OwnerId].ToString().Trim(); //拥有者Id
objvCoursewareCase_BaseEN.IdStudentInfo = objRow[convCoursewareCase_Base.IdStudentInfo] == DBNull.Value ? null : objRow[convCoursewareCase_Base.IdStudentInfo].ToString().Trim(); //学生流水号
objvCoursewareCase_BaseEN.StuName = objRow[convCoursewareCase_Base.StuName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.StuName].ToString().Trim(); //姓名
objvCoursewareCase_BaseEN.StuID = objRow[convCoursewareCase_Base.StuID] == DBNull.Value ? null : objRow[convCoursewareCase_Base.StuID].ToString().Trim(); //学号
objvCoursewareCase_BaseEN.PoliticsName = objRow[convCoursewareCase_Base.PoliticsName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.PoliticsName].ToString().Trim(); //政治面貌
objvCoursewareCase_BaseEN.SexDesc = objRow[convCoursewareCase_Base.SexDesc] == DBNull.Value ? null : objRow[convCoursewareCase_Base.SexDesc].ToString().Trim(); //性别名称
objvCoursewareCase_BaseEN.EthnicName = objRow[convCoursewareCase_Base.EthnicName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.EthnicName].ToString().Trim(); //民族名称
objvCoursewareCase_BaseEN.UniZoneDesc = objRow[convCoursewareCase_Base.UniZoneDesc] == DBNull.Value ? null : objRow[convCoursewareCase_Base.UniZoneDesc].ToString().Trim(); //校区名称
objvCoursewareCase_BaseEN.StuTypeDesc = objRow[convCoursewareCase_Base.StuTypeDesc] == DBNull.Value ? null : objRow[convCoursewareCase_Base.StuTypeDesc].ToString().Trim(); //学生类别名称
objvCoursewareCase_BaseEN.IdXzCollege = objRow[convCoursewareCase_Base.IdXzCollege] == DBNull.Value ? null : objRow[convCoursewareCase_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvCoursewareCase_BaseEN.CollegeID = objRow[convCoursewareCase_Base.CollegeID] == DBNull.Value ? null : objRow[convCoursewareCase_Base.CollegeID].ToString().Trim(); //学院ID
objvCoursewareCase_BaseEN.CollegeName = objRow[convCoursewareCase_Base.CollegeName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.CollegeName].ToString().Trim(); //学院名称
objvCoursewareCase_BaseEN.CollegeNameA = objRow[convCoursewareCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convCoursewareCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvCoursewareCase_BaseEN.IdXzMajor = objRow[convCoursewareCase_Base.IdXzMajor] == DBNull.Value ? null : objRow[convCoursewareCase_Base.IdXzMajor].ToString().Trim(); //专业流水号
objvCoursewareCase_BaseEN.MajorName = objRow[convCoursewareCase_Base.MajorName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.MajorName].ToString().Trim(); //专业名称
objvCoursewareCase_BaseEN.IdGradeBase = objRow[convCoursewareCase_Base.IdGradeBase] == DBNull.Value ? null : objRow[convCoursewareCase_Base.IdGradeBase].ToString().Trim(); //年级流水号
objvCoursewareCase_BaseEN.GradeBaseName = objRow[convCoursewareCase_Base.GradeBaseName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.GradeBaseName].ToString().Trim(); //年级名称
objvCoursewareCase_BaseEN.IdAdminCls = objRow[convCoursewareCase_Base.IdAdminCls] == DBNull.Value ? null : objRow[convCoursewareCase_Base.IdAdminCls].ToString().Trim(); //行政班流水号
objvCoursewareCase_BaseEN.AdminClsId = objRow[convCoursewareCase_Base.AdminClsId] == DBNull.Value ? null : objRow[convCoursewareCase_Base.AdminClsId].ToString().Trim(); //行政班代号
objvCoursewareCase_BaseEN.AdminClsName = objRow[convCoursewareCase_Base.AdminClsName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.AdminClsName].ToString().Trim(); //行政班名称
objvCoursewareCase_BaseEN.Birthday = objRow[convCoursewareCase_Base.Birthday] == DBNull.Value ? null : objRow[convCoursewareCase_Base.Birthday].ToString().Trim(); //出生日期
objvCoursewareCase_BaseEN.NativePlace = objRow[convCoursewareCase_Base.NativePlace] == DBNull.Value ? null : objRow[convCoursewareCase_Base.NativePlace].ToString().Trim(); //籍贯
objvCoursewareCase_BaseEN.Duty = objRow[convCoursewareCase_Base.Duty] == DBNull.Value ? null : objRow[convCoursewareCase_Base.Duty].ToString().Trim(); //职位
objvCoursewareCase_BaseEN.IDCardNo = objRow[convCoursewareCase_Base.IDCardNo] == DBNull.Value ? null : objRow[convCoursewareCase_Base.IDCardNo].ToString().Trim(); //身份证号
objvCoursewareCase_BaseEN.StuCardNo = objRow[convCoursewareCase_Base.StuCardNo] == DBNull.Value ? null : objRow[convCoursewareCase_Base.StuCardNo].ToString().Trim(); //学生证号
objvCoursewareCase_BaseEN.LiveAddress = objRow[convCoursewareCase_Base.LiveAddress] == DBNull.Value ? null : objRow[convCoursewareCase_Base.LiveAddress].ToString().Trim(); //居住地址
objvCoursewareCase_BaseEN.HomePhone = objRow[convCoursewareCase_Base.HomePhone] == DBNull.Value ? null : objRow[convCoursewareCase_Base.HomePhone].ToString().Trim(); //住宅电话
objvCoursewareCase_BaseEN.EnrollmentDate = objRow[convCoursewareCase_Base.EnrollmentDate] == DBNull.Value ? null : objRow[convCoursewareCase_Base.EnrollmentDate].ToString().Trim(); //入校日期
objvCoursewareCase_BaseEN.PostCode = objRow[convCoursewareCase_Base.PostCode] == DBNull.Value ? null : objRow[convCoursewareCase_Base.PostCode].ToString().Trim(); //邮编
objvCoursewareCase_BaseEN.UserKindId = objRow[convCoursewareCase_Base.UserKindId].ToString().Trim(); //用户类别Id
objvCoursewareCase_BaseEN.UserKindName = objRow[convCoursewareCase_Base.UserKindName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.UserKindName].ToString().Trim(); //用户类别名
objvCoursewareCase_BaseEN.UserTypeId = objRow[convCoursewareCase_Base.UserTypeId] == DBNull.Value ? null : objRow[convCoursewareCase_Base.UserTypeId].ToString().Trim(); //用户类型Id
objvCoursewareCase_BaseEN.IsDualVideo = TransNullToBool(objRow[convCoursewareCase_Base.IsDualVideo].ToString().Trim()); //是否双视频
objvCoursewareCase_BaseEN.RecommendedDegreeId = objRow[convCoursewareCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCoursewareCase_BaseEN.RecommendedDegreeName = objRow[convCoursewareCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCoursewareCase_BaseEN.ftpFileType = objRow[convCoursewareCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convCoursewareCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvCoursewareCase_BaseEN.VideoUrl = objRow[convCoursewareCase_Base.VideoUrl] == DBNull.Value ? null : objRow[convCoursewareCase_Base.VideoUrl].ToString().Trim(); //视频Url
objvCoursewareCase_BaseEN.VideoPath = objRow[convCoursewareCase_Base.VideoPath] == DBNull.Value ? null : objRow[convCoursewareCase_Base.VideoPath].ToString().Trim(); //视频目录
objvCoursewareCase_BaseEN.ResErrMsg = objRow[convCoursewareCase_Base.ResErrMsg] == DBNull.Value ? null : objRow[convCoursewareCase_Base.ResErrMsg].ToString().Trim(); //资源错误信息
objvCoursewareCase_BaseEN.Memo = objRow[convCoursewareCase_Base.Memo] == DBNull.Value ? null : objRow[convCoursewareCase_Base.Memo].ToString().Trim(); //备注
objvCoursewareCase_BaseEN.OwnerName = objRow[convCoursewareCase_Base.OwnerName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvCoursewareCase_BaseEN.OwnerNameWithId = objRow[convCoursewareCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convCoursewareCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCoursewareCase_BaseEN.BrowseCount4Case = objRow[convCoursewareCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCoursewareCase_BaseDA: GetObjLst)", objException.Message));
}
objvCoursewareCase_BaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCoursewareCase_BaseEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvCoursewareCase_Base(ref clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCase_BaseDA.GetSpecSQLObj();
strSQL = "Select * from vCoursewareCase_Base where IdCoursewareCase = " + "'"+ objvCoursewareCase_BaseEN.IdCoursewareCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvCoursewareCase_BaseEN.IdCoursewareCase = objDT.Rows[0][convCoursewareCase_Base.IdCoursewareCase].ToString().Trim(); //课件教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareCase_BaseEN.CoursewareCaseID = objDT.Rows[0][convCoursewareCase_Base.CoursewareCaseID].ToString().Trim(); //课件教学案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareCase_BaseEN.CoursewareCaseName = objDT.Rows[0][convCoursewareCase_Base.CoursewareCaseName].ToString().Trim(); //课件教学案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCoursewareCase_BaseEN.CoursewareCaseTheme = objDT.Rows[0][convCoursewareCase_Base.CoursewareCaseTheme].ToString().Trim(); //课件教学案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareCase_BaseEN.IdCoursewareCaseType = objDT.Rows[0][convCoursewareCase_Base.IdCoursewareCaseType].ToString().Trim(); //课件案例类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareCase_BaseEN.CoursewareCaseTypeName = objDT.Rows[0][convCoursewareCase_Base.CoursewareCaseTypeName].ToString().Trim(); //课件案例类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareCase_BaseEN.CoursewareCaseText = objDT.Rows[0][convCoursewareCase_Base.CoursewareCaseText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objvCoursewareCase_BaseEN.CoursewareCaseDate = objDT.Rows[0][convCoursewareCase_Base.CoursewareCaseDate].ToString().Trim(); //课件教学日期(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareCase_BaseEN.CoursewareCaseTime = objDT.Rows[0][convCoursewareCase_Base.CoursewareCaseTime].ToString().Trim(); //课件教学时间(字段类型:char,字段长度:6,是否可空:True)
 objvCoursewareCase_BaseEN.CoursewareCaseDateIn = objDT.Rows[0][convCoursewareCase_Base.CoursewareCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareCase_BaseEN.CoursewareCaseTimeIn = objDT.Rows[0][convCoursewareCase_Base.CoursewareCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvCoursewareCase_BaseEN.IdStudyLevel = objDT.Rows[0][convCoursewareCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvCoursewareCase_BaseEN.StudyLevelName = objDT.Rows[0][convCoursewareCase_Base.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareCase_BaseEN.IdTeachingPlan = objDT.Rows[0][convCoursewareCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareCase_BaseEN.IdCaseType = objDT.Rows[0][convCoursewareCase_Base.IdCaseType].ToString().Trim(); //案例类型流水号(字段类型:char,字段长度:4,是否可空:True)
 objvCoursewareCase_BaseEN.IdDiscipline = objDT.Rows[0][convCoursewareCase_Base.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareCase_BaseEN.DisciplineID = objDT.Rows[0][convCoursewareCase_Base.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareCase_BaseEN.DisciplineName = objDT.Rows[0][convCoursewareCase_Base.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareCase_BaseEN.IdSenateGaugeVersion = objDT.Rows[0][convCoursewareCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareCase_BaseEN.senateGaugeVersionID = objDT.Rows[0][convCoursewareCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareCase_BaseEN.senateGaugeVersionName = objDT.Rows[0][convCoursewareCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareCase_BaseEN.senateGaugeVersionTtlScore = TransNullToFloat(objDT.Rows[0][convCoursewareCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvCoursewareCase_BaseEN.VersionNo = TransNullToInt(objDT.Rows[0][convCoursewareCase_Base.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvCoursewareCase_BaseEN.IdTeachSkill = objDT.Rows[0][convCoursewareCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareCase_BaseEN.TeachSkillID = objDT.Rows[0][convCoursewareCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareCase_BaseEN.SkillTypeName = objDT.Rows[0][convCoursewareCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareCase_BaseEN.TeachSkillName = objDT.Rows[0][convCoursewareCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareCase_BaseEN.TeachSkillTheory = objDT.Rows[0][convCoursewareCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvCoursewareCase_BaseEN.TeachSkillOperMethod = objDT.Rows[0][convCoursewareCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法(字段类型:varchar,字段长度:2000,是否可空:True)
 objvCoursewareCase_BaseEN.IdSkillType = objDT.Rows[0][convCoursewareCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareCase_BaseEN.SkillTypeID = objDT.Rows[0][convCoursewareCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareCase_BaseEN.CaseLevelId = objDT.Rows[0][convCoursewareCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvCoursewareCase_BaseEN.CaseLevelName = objDT.Rows[0][convCoursewareCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvCoursewareCase_BaseEN.DocFile = objDT.Rows[0][convCoursewareCase_Base.DocFile].ToString().Trim(); //生成的Word文件名(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareCase_BaseEN.IsNeedGeneWord = TransNullToBool(objDT.Rows[0][convCoursewareCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word(字段类型:bit,字段长度:1,是否可空:True)
 objvCoursewareCase_BaseEN.WordCreateDate = objDT.Rows[0][convCoursewareCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objvCoursewareCase_BaseEN.IsVisible = TransNullToBool(objDT.Rows[0][convCoursewareCase_Base.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvCoursewareCase_BaseEN.OwnerId = objDT.Rows[0][convCoursewareCase_Base.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvCoursewareCase_BaseEN.IdStudentInfo = objDT.Rows[0][convCoursewareCase_Base.IdStudentInfo].ToString().Trim(); //学生流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareCase_BaseEN.StuName = objDT.Rows[0][convCoursewareCase_Base.StuName].ToString().Trim(); //姓名(字段类型:varchar,字段长度:50,是否可空:True)
 objvCoursewareCase_BaseEN.StuID = objDT.Rows[0][convCoursewareCase_Base.StuID].ToString().Trim(); //学号(字段类型:varchar,字段长度:20,是否可空:True)
 objvCoursewareCase_BaseEN.PoliticsName = objDT.Rows[0][convCoursewareCase_Base.PoliticsName].ToString().Trim(); //政治面貌(字段类型:varchar,字段长度:30,是否可空:False)
 objvCoursewareCase_BaseEN.SexDesc = objDT.Rows[0][convCoursewareCase_Base.SexDesc].ToString().Trim(); //性别名称(字段类型:varchar,字段长度:10,是否可空:True)
 objvCoursewareCase_BaseEN.EthnicName = objDT.Rows[0][convCoursewareCase_Base.EthnicName].ToString().Trim(); //民族名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCoursewareCase_BaseEN.UniZoneDesc = objDT.Rows[0][convCoursewareCase_Base.UniZoneDesc].ToString().Trim(); //校区名称(字段类型:varchar,字段长度:20,是否可空:False)
 objvCoursewareCase_BaseEN.StuTypeDesc = objDT.Rows[0][convCoursewareCase_Base.StuTypeDesc].ToString().Trim(); //学生类别名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareCase_BaseEN.IdXzCollege = objDT.Rows[0][convCoursewareCase_Base.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvCoursewareCase_BaseEN.CollegeID = objDT.Rows[0][convCoursewareCase_Base.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvCoursewareCase_BaseEN.CollegeName = objDT.Rows[0][convCoursewareCase_Base.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCoursewareCase_BaseEN.CollegeNameA = objDT.Rows[0][convCoursewareCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvCoursewareCase_BaseEN.IdXzMajor = objDT.Rows[0][convCoursewareCase_Base.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareCase_BaseEN.MajorName = objDT.Rows[0][convCoursewareCase_Base.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCoursewareCase_BaseEN.IdGradeBase = objDT.Rows[0][convCoursewareCase_Base.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objvCoursewareCase_BaseEN.GradeBaseName = objDT.Rows[0][convCoursewareCase_Base.GradeBaseName].ToString().Trim(); //年级名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareCase_BaseEN.IdAdminCls = objDT.Rows[0][convCoursewareCase_Base.IdAdminCls].ToString().Trim(); //行政班流水号(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareCase_BaseEN.AdminClsId = objDT.Rows[0][convCoursewareCase_Base.AdminClsId].ToString().Trim(); //行政班代号(字段类型:varchar,字段长度:8,是否可空:True)
 objvCoursewareCase_BaseEN.AdminClsName = objDT.Rows[0][convCoursewareCase_Base.AdminClsName].ToString().Trim(); //行政班名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvCoursewareCase_BaseEN.Birthday = objDT.Rows[0][convCoursewareCase_Base.Birthday].ToString().Trim(); //出生日期(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareCase_BaseEN.NativePlace = objDT.Rows[0][convCoursewareCase_Base.NativePlace].ToString().Trim(); //籍贯(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareCase_BaseEN.Duty = objDT.Rows[0][convCoursewareCase_Base.Duty].ToString().Trim(); //职位(字段类型:varchar,字段长度:30,是否可空:True)
 objvCoursewareCase_BaseEN.IDCardNo = objDT.Rows[0][convCoursewareCase_Base.IDCardNo].ToString().Trim(); //身份证号(字段类型:varchar,字段长度:20,是否可空:True)
 objvCoursewareCase_BaseEN.StuCardNo = objDT.Rows[0][convCoursewareCase_Base.StuCardNo].ToString().Trim(); //学生证号(字段类型:varchar,字段长度:20,是否可空:True)
 objvCoursewareCase_BaseEN.LiveAddress = objDT.Rows[0][convCoursewareCase_Base.LiveAddress].ToString().Trim(); //居住地址(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareCase_BaseEN.HomePhone = objDT.Rows[0][convCoursewareCase_Base.HomePhone].ToString().Trim(); //住宅电话(字段类型:varchar,字段长度:20,是否可空:True)
 objvCoursewareCase_BaseEN.EnrollmentDate = objDT.Rows[0][convCoursewareCase_Base.EnrollmentDate].ToString().Trim(); //入校日期(字段类型:varchar,字段长度:8,是否可空:True)
 objvCoursewareCase_BaseEN.PostCode = objDT.Rows[0][convCoursewareCase_Base.PostCode].ToString().Trim(); //邮编(字段类型:char,字段长度:6,是否可空:True)
 objvCoursewareCase_BaseEN.UserKindId = objDT.Rows[0][convCoursewareCase_Base.UserKindId].ToString().Trim(); //用户类别Id(字段类型:char,字段长度:2,是否可空:False)
 objvCoursewareCase_BaseEN.UserKindName = objDT.Rows[0][convCoursewareCase_Base.UserKindName].ToString().Trim(); //用户类别名(字段类型:varchar,字段长度:30,是否可空:False)
 objvCoursewareCase_BaseEN.UserTypeId = objDT.Rows[0][convCoursewareCase_Base.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvCoursewareCase_BaseEN.IsDualVideo = TransNullToBool(objDT.Rows[0][convCoursewareCase_Base.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvCoursewareCase_BaseEN.RecommendedDegreeId = objDT.Rows[0][convCoursewareCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvCoursewareCase_BaseEN.RecommendedDegreeName = objDT.Rows[0][convCoursewareCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCoursewareCase_BaseEN.ftpFileType = objDT.Rows[0][convCoursewareCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvCoursewareCase_BaseEN.VideoUrl = objDT.Rows[0][convCoursewareCase_Base.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCoursewareCase_BaseEN.VideoPath = objDT.Rows[0][convCoursewareCase_Base.VideoPath].ToString().Trim(); //视频目录(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCoursewareCase_BaseEN.ResErrMsg = objDT.Rows[0][convCoursewareCase_Base.ResErrMsg].ToString().Trim(); //资源错误信息(字段类型:varchar,字段长度:30,是否可空:True)
 objvCoursewareCase_BaseEN.Memo = objDT.Rows[0][convCoursewareCase_Base.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCoursewareCase_BaseEN.OwnerName = objDT.Rows[0][convCoursewareCase_Base.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvCoursewareCase_BaseEN.OwnerNameWithId = objDT.Rows[0][convCoursewareCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
 objvCoursewareCase_BaseEN.BrowseCount4Case = TransNullToInt(objDT.Rows[0][convCoursewareCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvCoursewareCase_BaseDA: GetvCoursewareCase_Base)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdCoursewareCase">表关键字</param>
 /// <returns>表对象</returns>
public clsvCoursewareCase_BaseEN GetObjByIdCoursewareCase(string strIdCoursewareCase)
{
CheckPrimaryKey(strIdCoursewareCase);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCase_BaseDA.GetSpecSQLObj();
strSQL = "Select * from vCoursewareCase_Base where IdCoursewareCase = " + "'"+ strIdCoursewareCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN = new clsvCoursewareCase_BaseEN();
try
{
 objvCoursewareCase_BaseEN.IdCoursewareCase = objRow[convCoursewareCase_Base.IdCoursewareCase].ToString().Trim(); //课件教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareCase_BaseEN.CoursewareCaseID = objRow[convCoursewareCase_Base.CoursewareCaseID].ToString().Trim(); //课件教学案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareCase_BaseEN.CoursewareCaseName = objRow[convCoursewareCase_Base.CoursewareCaseName].ToString().Trim(); //课件教学案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCoursewareCase_BaseEN.CoursewareCaseTheme = objRow[convCoursewareCase_Base.CoursewareCaseTheme] == DBNull.Value ? null : objRow[convCoursewareCase_Base.CoursewareCaseTheme].ToString().Trim(); //课件教学案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareCase_BaseEN.IdCoursewareCaseType = objRow[convCoursewareCase_Base.IdCoursewareCaseType].ToString().Trim(); //课件案例类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareCase_BaseEN.CoursewareCaseTypeName = objRow[convCoursewareCase_Base.CoursewareCaseTypeName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.CoursewareCaseTypeName].ToString().Trim(); //课件案例类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareCase_BaseEN.CoursewareCaseText = objRow[convCoursewareCase_Base.CoursewareCaseText] == DBNull.Value ? null : objRow[convCoursewareCase_Base.CoursewareCaseText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objvCoursewareCase_BaseEN.CoursewareCaseDate = objRow[convCoursewareCase_Base.CoursewareCaseDate] == DBNull.Value ? null : objRow[convCoursewareCase_Base.CoursewareCaseDate].ToString().Trim(); //课件教学日期(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareCase_BaseEN.CoursewareCaseTime = objRow[convCoursewareCase_Base.CoursewareCaseTime] == DBNull.Value ? null : objRow[convCoursewareCase_Base.CoursewareCaseTime].ToString().Trim(); //课件教学时间(字段类型:char,字段长度:6,是否可空:True)
 objvCoursewareCase_BaseEN.CoursewareCaseDateIn = objRow[convCoursewareCase_Base.CoursewareCaseDateIn] == DBNull.Value ? null : objRow[convCoursewareCase_Base.CoursewareCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareCase_BaseEN.CoursewareCaseTimeIn = objRow[convCoursewareCase_Base.CoursewareCaseTimeIn] == DBNull.Value ? null : objRow[convCoursewareCase_Base.CoursewareCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvCoursewareCase_BaseEN.IdStudyLevel = objRow[convCoursewareCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvCoursewareCase_BaseEN.StudyLevelName = objRow[convCoursewareCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareCase_BaseEN.IdTeachingPlan = objRow[convCoursewareCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convCoursewareCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareCase_BaseEN.IdCaseType = objRow[convCoursewareCase_Base.IdCaseType] == DBNull.Value ? null : objRow[convCoursewareCase_Base.IdCaseType].ToString().Trim(); //案例类型流水号(字段类型:char,字段长度:4,是否可空:True)
 objvCoursewareCase_BaseEN.IdDiscipline = objRow[convCoursewareCase_Base.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareCase_BaseEN.DisciplineID = objRow[convCoursewareCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convCoursewareCase_Base.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareCase_BaseEN.DisciplineName = objRow[convCoursewareCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareCase_BaseEN.IdSenateGaugeVersion = objRow[convCoursewareCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convCoursewareCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareCase_BaseEN.senateGaugeVersionID = objRow[convCoursewareCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCoursewareCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareCase_BaseEN.senateGaugeVersionName = objRow[convCoursewareCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareCase_BaseEN.senateGaugeVersionTtlScore = objRow[convCoursewareCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convCoursewareCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvCoursewareCase_BaseEN.VersionNo = objRow[convCoursewareCase_Base.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCoursewareCase_Base.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvCoursewareCase_BaseEN.IdTeachSkill = objRow[convCoursewareCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareCase_BaseEN.TeachSkillID = objRow[convCoursewareCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convCoursewareCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareCase_BaseEN.SkillTypeName = objRow[convCoursewareCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareCase_BaseEN.TeachSkillName = objRow[convCoursewareCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareCase_BaseEN.TeachSkillTheory = objRow[convCoursewareCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convCoursewareCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvCoursewareCase_BaseEN.TeachSkillOperMethod = objRow[convCoursewareCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCoursewareCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法(字段类型:varchar,字段长度:2000,是否可空:True)
 objvCoursewareCase_BaseEN.IdSkillType = objRow[convCoursewareCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convCoursewareCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareCase_BaseEN.SkillTypeID = objRow[convCoursewareCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convCoursewareCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareCase_BaseEN.CaseLevelId = objRow[convCoursewareCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convCoursewareCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvCoursewareCase_BaseEN.CaseLevelName = objRow[convCoursewareCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvCoursewareCase_BaseEN.DocFile = objRow[convCoursewareCase_Base.DocFile] == DBNull.Value ? null : objRow[convCoursewareCase_Base.DocFile].ToString().Trim(); //生成的Word文件名(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareCase_BaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convCoursewareCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word(字段类型:bit,字段长度:1,是否可空:True)
 objvCoursewareCase_BaseEN.WordCreateDate = objRow[convCoursewareCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convCoursewareCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objvCoursewareCase_BaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCoursewareCase_Base.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvCoursewareCase_BaseEN.OwnerId = objRow[convCoursewareCase_Base.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvCoursewareCase_BaseEN.IdStudentInfo = objRow[convCoursewareCase_Base.IdStudentInfo] == DBNull.Value ? null : objRow[convCoursewareCase_Base.IdStudentInfo].ToString().Trim(); //学生流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareCase_BaseEN.StuName = objRow[convCoursewareCase_Base.StuName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.StuName].ToString().Trim(); //姓名(字段类型:varchar,字段长度:50,是否可空:True)
 objvCoursewareCase_BaseEN.StuID = objRow[convCoursewareCase_Base.StuID] == DBNull.Value ? null : objRow[convCoursewareCase_Base.StuID].ToString().Trim(); //学号(字段类型:varchar,字段长度:20,是否可空:True)
 objvCoursewareCase_BaseEN.PoliticsName = objRow[convCoursewareCase_Base.PoliticsName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.PoliticsName].ToString().Trim(); //政治面貌(字段类型:varchar,字段长度:30,是否可空:False)
 objvCoursewareCase_BaseEN.SexDesc = objRow[convCoursewareCase_Base.SexDesc] == DBNull.Value ? null : objRow[convCoursewareCase_Base.SexDesc].ToString().Trim(); //性别名称(字段类型:varchar,字段长度:10,是否可空:True)
 objvCoursewareCase_BaseEN.EthnicName = objRow[convCoursewareCase_Base.EthnicName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.EthnicName].ToString().Trim(); //民族名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCoursewareCase_BaseEN.UniZoneDesc = objRow[convCoursewareCase_Base.UniZoneDesc] == DBNull.Value ? null : objRow[convCoursewareCase_Base.UniZoneDesc].ToString().Trim(); //校区名称(字段类型:varchar,字段长度:20,是否可空:False)
 objvCoursewareCase_BaseEN.StuTypeDesc = objRow[convCoursewareCase_Base.StuTypeDesc] == DBNull.Value ? null : objRow[convCoursewareCase_Base.StuTypeDesc].ToString().Trim(); //学生类别名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareCase_BaseEN.IdXzCollege = objRow[convCoursewareCase_Base.IdXzCollege] == DBNull.Value ? null : objRow[convCoursewareCase_Base.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvCoursewareCase_BaseEN.CollegeID = objRow[convCoursewareCase_Base.CollegeID] == DBNull.Value ? null : objRow[convCoursewareCase_Base.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvCoursewareCase_BaseEN.CollegeName = objRow[convCoursewareCase_Base.CollegeName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCoursewareCase_BaseEN.CollegeNameA = objRow[convCoursewareCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convCoursewareCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvCoursewareCase_BaseEN.IdXzMajor = objRow[convCoursewareCase_Base.IdXzMajor] == DBNull.Value ? null : objRow[convCoursewareCase_Base.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareCase_BaseEN.MajorName = objRow[convCoursewareCase_Base.MajorName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCoursewareCase_BaseEN.IdGradeBase = objRow[convCoursewareCase_Base.IdGradeBase] == DBNull.Value ? null : objRow[convCoursewareCase_Base.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objvCoursewareCase_BaseEN.GradeBaseName = objRow[convCoursewareCase_Base.GradeBaseName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.GradeBaseName].ToString().Trim(); //年级名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareCase_BaseEN.IdAdminCls = objRow[convCoursewareCase_Base.IdAdminCls] == DBNull.Value ? null : objRow[convCoursewareCase_Base.IdAdminCls].ToString().Trim(); //行政班流水号(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareCase_BaseEN.AdminClsId = objRow[convCoursewareCase_Base.AdminClsId] == DBNull.Value ? null : objRow[convCoursewareCase_Base.AdminClsId].ToString().Trim(); //行政班代号(字段类型:varchar,字段长度:8,是否可空:True)
 objvCoursewareCase_BaseEN.AdminClsName = objRow[convCoursewareCase_Base.AdminClsName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.AdminClsName].ToString().Trim(); //行政班名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvCoursewareCase_BaseEN.Birthday = objRow[convCoursewareCase_Base.Birthday] == DBNull.Value ? null : objRow[convCoursewareCase_Base.Birthday].ToString().Trim(); //出生日期(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareCase_BaseEN.NativePlace = objRow[convCoursewareCase_Base.NativePlace] == DBNull.Value ? null : objRow[convCoursewareCase_Base.NativePlace].ToString().Trim(); //籍贯(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareCase_BaseEN.Duty = objRow[convCoursewareCase_Base.Duty] == DBNull.Value ? null : objRow[convCoursewareCase_Base.Duty].ToString().Trim(); //职位(字段类型:varchar,字段长度:30,是否可空:True)
 objvCoursewareCase_BaseEN.IDCardNo = objRow[convCoursewareCase_Base.IDCardNo] == DBNull.Value ? null : objRow[convCoursewareCase_Base.IDCardNo].ToString().Trim(); //身份证号(字段类型:varchar,字段长度:20,是否可空:True)
 objvCoursewareCase_BaseEN.StuCardNo = objRow[convCoursewareCase_Base.StuCardNo] == DBNull.Value ? null : objRow[convCoursewareCase_Base.StuCardNo].ToString().Trim(); //学生证号(字段类型:varchar,字段长度:20,是否可空:True)
 objvCoursewareCase_BaseEN.LiveAddress = objRow[convCoursewareCase_Base.LiveAddress] == DBNull.Value ? null : objRow[convCoursewareCase_Base.LiveAddress].ToString().Trim(); //居住地址(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareCase_BaseEN.HomePhone = objRow[convCoursewareCase_Base.HomePhone] == DBNull.Value ? null : objRow[convCoursewareCase_Base.HomePhone].ToString().Trim(); //住宅电话(字段类型:varchar,字段长度:20,是否可空:True)
 objvCoursewareCase_BaseEN.EnrollmentDate = objRow[convCoursewareCase_Base.EnrollmentDate] == DBNull.Value ? null : objRow[convCoursewareCase_Base.EnrollmentDate].ToString().Trim(); //入校日期(字段类型:varchar,字段长度:8,是否可空:True)
 objvCoursewareCase_BaseEN.PostCode = objRow[convCoursewareCase_Base.PostCode] == DBNull.Value ? null : objRow[convCoursewareCase_Base.PostCode].ToString().Trim(); //邮编(字段类型:char,字段长度:6,是否可空:True)
 objvCoursewareCase_BaseEN.UserKindId = objRow[convCoursewareCase_Base.UserKindId].ToString().Trim(); //用户类别Id(字段类型:char,字段长度:2,是否可空:False)
 objvCoursewareCase_BaseEN.UserKindName = objRow[convCoursewareCase_Base.UserKindName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.UserKindName].ToString().Trim(); //用户类别名(字段类型:varchar,字段长度:30,是否可空:False)
 objvCoursewareCase_BaseEN.UserTypeId = objRow[convCoursewareCase_Base.UserTypeId] == DBNull.Value ? null : objRow[convCoursewareCase_Base.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvCoursewareCase_BaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCoursewareCase_Base.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvCoursewareCase_BaseEN.RecommendedDegreeId = objRow[convCoursewareCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvCoursewareCase_BaseEN.RecommendedDegreeName = objRow[convCoursewareCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCoursewareCase_BaseEN.ftpFileType = objRow[convCoursewareCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convCoursewareCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvCoursewareCase_BaseEN.VideoUrl = objRow[convCoursewareCase_Base.VideoUrl] == DBNull.Value ? null : objRow[convCoursewareCase_Base.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCoursewareCase_BaseEN.VideoPath = objRow[convCoursewareCase_Base.VideoPath] == DBNull.Value ? null : objRow[convCoursewareCase_Base.VideoPath].ToString().Trim(); //视频目录(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCoursewareCase_BaseEN.ResErrMsg = objRow[convCoursewareCase_Base.ResErrMsg] == DBNull.Value ? null : objRow[convCoursewareCase_Base.ResErrMsg].ToString().Trim(); //资源错误信息(字段类型:varchar,字段长度:30,是否可空:True)
 objvCoursewareCase_BaseEN.Memo = objRow[convCoursewareCase_Base.Memo] == DBNull.Value ? null : objRow[convCoursewareCase_Base.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCoursewareCase_BaseEN.OwnerName = objRow[convCoursewareCase_Base.OwnerName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvCoursewareCase_BaseEN.OwnerNameWithId = objRow[convCoursewareCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convCoursewareCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
 objvCoursewareCase_BaseEN.BrowseCount4Case = objRow[convCoursewareCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCoursewareCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvCoursewareCase_BaseDA: GetObjByIdCoursewareCase)", objException.Message));
}
return objvCoursewareCase_BaseEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvCoursewareCase_BaseEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvCoursewareCase_BaseDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCase_BaseDA.GetSpecSQLObj();
strSQL = "Select * from vCoursewareCase_Base where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN = new clsvCoursewareCase_BaseEN()
{
IdCoursewareCase = objRow[convCoursewareCase_Base.IdCoursewareCase].ToString().Trim(), //课件教学案例流水号
CoursewareCaseID = objRow[convCoursewareCase_Base.CoursewareCaseID].ToString().Trim(), //课件教学案例ID
CoursewareCaseName = objRow[convCoursewareCase_Base.CoursewareCaseName].ToString().Trim(), //课件教学案例名称
CoursewareCaseTheme = objRow[convCoursewareCase_Base.CoursewareCaseTheme] == DBNull.Value ? null : objRow[convCoursewareCase_Base.CoursewareCaseTheme].ToString().Trim(), //课件教学案例主题词
IdCoursewareCaseType = objRow[convCoursewareCase_Base.IdCoursewareCaseType].ToString().Trim(), //课件案例类型流水号
CoursewareCaseTypeName = objRow[convCoursewareCase_Base.CoursewareCaseTypeName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.CoursewareCaseTypeName].ToString().Trim(), //课件案例类型名称
CoursewareCaseText = objRow[convCoursewareCase_Base.CoursewareCaseText] == DBNull.Value ? null : objRow[convCoursewareCase_Base.CoursewareCaseText].ToString().Trim(), //案例文本内容
CoursewareCaseDate = objRow[convCoursewareCase_Base.CoursewareCaseDate] == DBNull.Value ? null : objRow[convCoursewareCase_Base.CoursewareCaseDate].ToString().Trim(), //课件教学日期
CoursewareCaseTime = objRow[convCoursewareCase_Base.CoursewareCaseTime] == DBNull.Value ? null : objRow[convCoursewareCase_Base.CoursewareCaseTime].ToString().Trim(), //课件教学时间
CoursewareCaseDateIn = objRow[convCoursewareCase_Base.CoursewareCaseDateIn] == DBNull.Value ? null : objRow[convCoursewareCase_Base.CoursewareCaseDateIn].ToString().Trim(), //案例入库日期
CoursewareCaseTimeIn = objRow[convCoursewareCase_Base.CoursewareCaseTimeIn] == DBNull.Value ? null : objRow[convCoursewareCase_Base.CoursewareCaseTimeIn].ToString().Trim(), //案例入库时间
IdStudyLevel = objRow[convCoursewareCase_Base.IdStudyLevel].ToString().Trim(), //id_StudyLevel
StudyLevelName = objRow[convCoursewareCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.StudyLevelName].ToString().Trim(), //学段名称
IdTeachingPlan = objRow[convCoursewareCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convCoursewareCase_Base.IdTeachingPlan].ToString().Trim(), //教案流水号
IdCaseType = objRow[convCoursewareCase_Base.IdCaseType] == DBNull.Value ? null : objRow[convCoursewareCase_Base.IdCaseType].ToString().Trim(), //案例类型流水号
IdDiscipline = objRow[convCoursewareCase_Base.IdDiscipline].ToString().Trim(), //学科流水号
DisciplineID = objRow[convCoursewareCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convCoursewareCase_Base.DisciplineID].ToString().Trim(), //学科ID
DisciplineName = objRow[convCoursewareCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.DisciplineName].ToString().Trim(), //学科名称
IdSenateGaugeVersion = objRow[convCoursewareCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convCoursewareCase_Base.IdSenateGaugeVersion].ToString().Trim(), //评价量表版本流水号
senateGaugeVersionID = objRow[convCoursewareCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCoursewareCase_Base.senateGaugeVersionID].ToString().Trim(), //评价量表版本ID
senateGaugeVersionName = objRow[convCoursewareCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.senateGaugeVersionName].ToString().Trim(), //评价量表版本名称
senateGaugeVersionTtlScore = objRow[convCoursewareCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convCoursewareCase_Base.senateGaugeVersionTtlScore].ToString().Trim()), //评价量表版本总分
VersionNo = objRow[convCoursewareCase_Base.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareCase_Base.VersionNo].ToString().Trim()), //版本号
IdTeachSkill = objRow[convCoursewareCase_Base.IdTeachSkill].ToString().Trim(), //教学技能流水号
TeachSkillID = objRow[convCoursewareCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convCoursewareCase_Base.TeachSkillID].ToString().Trim(), //教学技能ID
SkillTypeName = objRow[convCoursewareCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.SkillTypeName].ToString().Trim(), //技能类型名称
TeachSkillName = objRow[convCoursewareCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.TeachSkillName].ToString().Trim(), //教学技能名称
TeachSkillTheory = objRow[convCoursewareCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convCoursewareCase_Base.TeachSkillTheory].ToString().Trim(), //教学技能理论阐述
TeachSkillOperMethod = objRow[convCoursewareCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCoursewareCase_Base.TeachSkillOperMethod].ToString().Trim(), //教学技能实践操作方法
IdSkillType = objRow[convCoursewareCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convCoursewareCase_Base.IdSkillType].ToString().Trim(), //技能类型流水号
SkillTypeID = objRow[convCoursewareCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convCoursewareCase_Base.SkillTypeID].ToString().Trim(), //技能类型ID
CaseLevelId = objRow[convCoursewareCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convCoursewareCase_Base.CaseLevelId].ToString().Trim(), //课例等级Id
CaseLevelName = objRow[convCoursewareCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.CaseLevelName].ToString().Trim(), //案例等级名称
DocFile = objRow[convCoursewareCase_Base.DocFile] == DBNull.Value ? null : objRow[convCoursewareCase_Base.DocFile].ToString().Trim(), //生成的Word文件名
IsNeedGeneWord = TransNullToBool(objRow[convCoursewareCase_Base.IsNeedGeneWord].ToString().Trim()), //是否需要生成Word
WordCreateDate = objRow[convCoursewareCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convCoursewareCase_Base.WordCreateDate].ToString().Trim(), //Word生成日期
IsVisible = TransNullToBool(objRow[convCoursewareCase_Base.IsVisible].ToString().Trim()), //是否显示
OwnerId = objRow[convCoursewareCase_Base.OwnerId].ToString().Trim(), //拥有者Id
IdStudentInfo = objRow[convCoursewareCase_Base.IdStudentInfo] == DBNull.Value ? null : objRow[convCoursewareCase_Base.IdStudentInfo].ToString().Trim(), //学生流水号
StuName = objRow[convCoursewareCase_Base.StuName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.StuName].ToString().Trim(), //姓名
StuID = objRow[convCoursewareCase_Base.StuID] == DBNull.Value ? null : objRow[convCoursewareCase_Base.StuID].ToString().Trim(), //学号
PoliticsName = objRow[convCoursewareCase_Base.PoliticsName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.PoliticsName].ToString().Trim(), //政治面貌
SexDesc = objRow[convCoursewareCase_Base.SexDesc] == DBNull.Value ? null : objRow[convCoursewareCase_Base.SexDesc].ToString().Trim(), //性别名称
EthnicName = objRow[convCoursewareCase_Base.EthnicName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.EthnicName].ToString().Trim(), //民族名称
UniZoneDesc = objRow[convCoursewareCase_Base.UniZoneDesc] == DBNull.Value ? null : objRow[convCoursewareCase_Base.UniZoneDesc].ToString().Trim(), //校区名称
StuTypeDesc = objRow[convCoursewareCase_Base.StuTypeDesc] == DBNull.Value ? null : objRow[convCoursewareCase_Base.StuTypeDesc].ToString().Trim(), //学生类别名称
IdXzCollege = objRow[convCoursewareCase_Base.IdXzCollege] == DBNull.Value ? null : objRow[convCoursewareCase_Base.IdXzCollege].ToString().Trim(), //学院流水号
CollegeID = objRow[convCoursewareCase_Base.CollegeID] == DBNull.Value ? null : objRow[convCoursewareCase_Base.CollegeID].ToString().Trim(), //学院ID
CollegeName = objRow[convCoursewareCase_Base.CollegeName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.CollegeName].ToString().Trim(), //学院名称
CollegeNameA = objRow[convCoursewareCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convCoursewareCase_Base.CollegeNameA].ToString().Trim(), //学院名称简写
IdXzMajor = objRow[convCoursewareCase_Base.IdXzMajor] == DBNull.Value ? null : objRow[convCoursewareCase_Base.IdXzMajor].ToString().Trim(), //专业流水号
MajorName = objRow[convCoursewareCase_Base.MajorName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.MajorName].ToString().Trim(), //专业名称
IdGradeBase = objRow[convCoursewareCase_Base.IdGradeBase] == DBNull.Value ? null : objRow[convCoursewareCase_Base.IdGradeBase].ToString().Trim(), //年级流水号
GradeBaseName = objRow[convCoursewareCase_Base.GradeBaseName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.GradeBaseName].ToString().Trim(), //年级名称
IdAdminCls = objRow[convCoursewareCase_Base.IdAdminCls] == DBNull.Value ? null : objRow[convCoursewareCase_Base.IdAdminCls].ToString().Trim(), //行政班流水号
AdminClsId = objRow[convCoursewareCase_Base.AdminClsId] == DBNull.Value ? null : objRow[convCoursewareCase_Base.AdminClsId].ToString().Trim(), //行政班代号
AdminClsName = objRow[convCoursewareCase_Base.AdminClsName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.AdminClsName].ToString().Trim(), //行政班名称
Birthday = objRow[convCoursewareCase_Base.Birthday] == DBNull.Value ? null : objRow[convCoursewareCase_Base.Birthday].ToString().Trim(), //出生日期
NativePlace = objRow[convCoursewareCase_Base.NativePlace] == DBNull.Value ? null : objRow[convCoursewareCase_Base.NativePlace].ToString().Trim(), //籍贯
Duty = objRow[convCoursewareCase_Base.Duty] == DBNull.Value ? null : objRow[convCoursewareCase_Base.Duty].ToString().Trim(), //职位
IDCardNo = objRow[convCoursewareCase_Base.IDCardNo] == DBNull.Value ? null : objRow[convCoursewareCase_Base.IDCardNo].ToString().Trim(), //身份证号
StuCardNo = objRow[convCoursewareCase_Base.StuCardNo] == DBNull.Value ? null : objRow[convCoursewareCase_Base.StuCardNo].ToString().Trim(), //学生证号
LiveAddress = objRow[convCoursewareCase_Base.LiveAddress] == DBNull.Value ? null : objRow[convCoursewareCase_Base.LiveAddress].ToString().Trim(), //居住地址
HomePhone = objRow[convCoursewareCase_Base.HomePhone] == DBNull.Value ? null : objRow[convCoursewareCase_Base.HomePhone].ToString().Trim(), //住宅电话
EnrollmentDate = objRow[convCoursewareCase_Base.EnrollmentDate] == DBNull.Value ? null : objRow[convCoursewareCase_Base.EnrollmentDate].ToString().Trim(), //入校日期
PostCode = objRow[convCoursewareCase_Base.PostCode] == DBNull.Value ? null : objRow[convCoursewareCase_Base.PostCode].ToString().Trim(), //邮编
UserKindId = objRow[convCoursewareCase_Base.UserKindId].ToString().Trim(), //用户类别Id
UserKindName = objRow[convCoursewareCase_Base.UserKindName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.UserKindName].ToString().Trim(), //用户类别名
UserTypeId = objRow[convCoursewareCase_Base.UserTypeId] == DBNull.Value ? null : objRow[convCoursewareCase_Base.UserTypeId].ToString().Trim(), //用户类型Id
IsDualVideo = TransNullToBool(objRow[convCoursewareCase_Base.IsDualVideo].ToString().Trim()), //是否双视频
RecommendedDegreeId = objRow[convCoursewareCase_Base.RecommendedDegreeId].ToString().Trim(), //推荐度Id
RecommendedDegreeName = objRow[convCoursewareCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.RecommendedDegreeName].ToString().Trim(), //推荐度名称
ftpFileType = objRow[convCoursewareCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convCoursewareCase_Base.ftpFileType].ToString().Trim(), //ftp文件类型
VideoUrl = objRow[convCoursewareCase_Base.VideoUrl] == DBNull.Value ? null : objRow[convCoursewareCase_Base.VideoUrl].ToString().Trim(), //视频Url
VideoPath = objRow[convCoursewareCase_Base.VideoPath] == DBNull.Value ? null : objRow[convCoursewareCase_Base.VideoPath].ToString().Trim(), //视频目录
ResErrMsg = objRow[convCoursewareCase_Base.ResErrMsg] == DBNull.Value ? null : objRow[convCoursewareCase_Base.ResErrMsg].ToString().Trim(), //资源错误信息
Memo = objRow[convCoursewareCase_Base.Memo] == DBNull.Value ? null : objRow[convCoursewareCase_Base.Memo].ToString().Trim(), //备注
OwnerName = objRow[convCoursewareCase_Base.OwnerName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.OwnerName].ToString().Trim(), //拥有者姓名
OwnerNameWithId = objRow[convCoursewareCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convCoursewareCase_Base.OwnerNameWithId].ToString().Trim(), //拥有者名称附Id
BrowseCount4Case = objRow[convCoursewareCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareCase_Base.BrowseCount4Case].ToString().Trim()) //课例浏览次数
};
objvCoursewareCase_BaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCoursewareCase_BaseEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvCoursewareCase_BaseDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvCoursewareCase_BaseEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN = new clsvCoursewareCase_BaseEN();
try
{
objvCoursewareCase_BaseEN.IdCoursewareCase = objRow[convCoursewareCase_Base.IdCoursewareCase].ToString().Trim(); //课件教学案例流水号
objvCoursewareCase_BaseEN.CoursewareCaseID = objRow[convCoursewareCase_Base.CoursewareCaseID].ToString().Trim(); //课件教学案例ID
objvCoursewareCase_BaseEN.CoursewareCaseName = objRow[convCoursewareCase_Base.CoursewareCaseName].ToString().Trim(); //课件教学案例名称
objvCoursewareCase_BaseEN.CoursewareCaseTheme = objRow[convCoursewareCase_Base.CoursewareCaseTheme] == DBNull.Value ? null : objRow[convCoursewareCase_Base.CoursewareCaseTheme].ToString().Trim(); //课件教学案例主题词
objvCoursewareCase_BaseEN.IdCoursewareCaseType = objRow[convCoursewareCase_Base.IdCoursewareCaseType].ToString().Trim(); //课件案例类型流水号
objvCoursewareCase_BaseEN.CoursewareCaseTypeName = objRow[convCoursewareCase_Base.CoursewareCaseTypeName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.CoursewareCaseTypeName].ToString().Trim(); //课件案例类型名称
objvCoursewareCase_BaseEN.CoursewareCaseText = objRow[convCoursewareCase_Base.CoursewareCaseText] == DBNull.Value ? null : objRow[convCoursewareCase_Base.CoursewareCaseText].ToString().Trim(); //案例文本内容
objvCoursewareCase_BaseEN.CoursewareCaseDate = objRow[convCoursewareCase_Base.CoursewareCaseDate] == DBNull.Value ? null : objRow[convCoursewareCase_Base.CoursewareCaseDate].ToString().Trim(); //课件教学日期
objvCoursewareCase_BaseEN.CoursewareCaseTime = objRow[convCoursewareCase_Base.CoursewareCaseTime] == DBNull.Value ? null : objRow[convCoursewareCase_Base.CoursewareCaseTime].ToString().Trim(); //课件教学时间
objvCoursewareCase_BaseEN.CoursewareCaseDateIn = objRow[convCoursewareCase_Base.CoursewareCaseDateIn] == DBNull.Value ? null : objRow[convCoursewareCase_Base.CoursewareCaseDateIn].ToString().Trim(); //案例入库日期
objvCoursewareCase_BaseEN.CoursewareCaseTimeIn = objRow[convCoursewareCase_Base.CoursewareCaseTimeIn] == DBNull.Value ? null : objRow[convCoursewareCase_Base.CoursewareCaseTimeIn].ToString().Trim(); //案例入库时间
objvCoursewareCase_BaseEN.IdStudyLevel = objRow[convCoursewareCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCoursewareCase_BaseEN.StudyLevelName = objRow[convCoursewareCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.StudyLevelName].ToString().Trim(); //学段名称
objvCoursewareCase_BaseEN.IdTeachingPlan = objRow[convCoursewareCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convCoursewareCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCoursewareCase_BaseEN.IdCaseType = objRow[convCoursewareCase_Base.IdCaseType] == DBNull.Value ? null : objRow[convCoursewareCase_Base.IdCaseType].ToString().Trim(); //案例类型流水号
objvCoursewareCase_BaseEN.IdDiscipline = objRow[convCoursewareCase_Base.IdDiscipline].ToString().Trim(); //学科流水号
objvCoursewareCase_BaseEN.DisciplineID = objRow[convCoursewareCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convCoursewareCase_Base.DisciplineID].ToString().Trim(); //学科ID
objvCoursewareCase_BaseEN.DisciplineName = objRow[convCoursewareCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.DisciplineName].ToString().Trim(); //学科名称
objvCoursewareCase_BaseEN.IdSenateGaugeVersion = objRow[convCoursewareCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convCoursewareCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCoursewareCase_BaseEN.senateGaugeVersionID = objRow[convCoursewareCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCoursewareCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCoursewareCase_BaseEN.senateGaugeVersionName = objRow[convCoursewareCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCoursewareCase_BaseEN.senateGaugeVersionTtlScore = objRow[convCoursewareCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convCoursewareCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCoursewareCase_BaseEN.VersionNo = objRow[convCoursewareCase_Base.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareCase_Base.VersionNo].ToString().Trim()); //版本号
objvCoursewareCase_BaseEN.IdTeachSkill = objRow[convCoursewareCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCoursewareCase_BaseEN.TeachSkillID = objRow[convCoursewareCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convCoursewareCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID
objvCoursewareCase_BaseEN.SkillTypeName = objRow[convCoursewareCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称
objvCoursewareCase_BaseEN.TeachSkillName = objRow[convCoursewareCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称
objvCoursewareCase_BaseEN.TeachSkillTheory = objRow[convCoursewareCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convCoursewareCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCoursewareCase_BaseEN.TeachSkillOperMethod = objRow[convCoursewareCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCoursewareCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCoursewareCase_BaseEN.IdSkillType = objRow[convCoursewareCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convCoursewareCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号
objvCoursewareCase_BaseEN.SkillTypeID = objRow[convCoursewareCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convCoursewareCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID
objvCoursewareCase_BaseEN.CaseLevelId = objRow[convCoursewareCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convCoursewareCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvCoursewareCase_BaseEN.CaseLevelName = objRow[convCoursewareCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvCoursewareCase_BaseEN.DocFile = objRow[convCoursewareCase_Base.DocFile] == DBNull.Value ? null : objRow[convCoursewareCase_Base.DocFile].ToString().Trim(); //生成的Word文件名
objvCoursewareCase_BaseEN.IsNeedGeneWord = TransNullToBool(objRow[convCoursewareCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvCoursewareCase_BaseEN.WordCreateDate = objRow[convCoursewareCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convCoursewareCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期
objvCoursewareCase_BaseEN.IsVisible = TransNullToBool(objRow[convCoursewareCase_Base.IsVisible].ToString().Trim()); //是否显示
objvCoursewareCase_BaseEN.OwnerId = objRow[convCoursewareCase_Base.OwnerId].ToString().Trim(); //拥有者Id
objvCoursewareCase_BaseEN.IdStudentInfo = objRow[convCoursewareCase_Base.IdStudentInfo] == DBNull.Value ? null : objRow[convCoursewareCase_Base.IdStudentInfo].ToString().Trim(); //学生流水号
objvCoursewareCase_BaseEN.StuName = objRow[convCoursewareCase_Base.StuName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.StuName].ToString().Trim(); //姓名
objvCoursewareCase_BaseEN.StuID = objRow[convCoursewareCase_Base.StuID] == DBNull.Value ? null : objRow[convCoursewareCase_Base.StuID].ToString().Trim(); //学号
objvCoursewareCase_BaseEN.PoliticsName = objRow[convCoursewareCase_Base.PoliticsName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.PoliticsName].ToString().Trim(); //政治面貌
objvCoursewareCase_BaseEN.SexDesc = objRow[convCoursewareCase_Base.SexDesc] == DBNull.Value ? null : objRow[convCoursewareCase_Base.SexDesc].ToString().Trim(); //性别名称
objvCoursewareCase_BaseEN.EthnicName = objRow[convCoursewareCase_Base.EthnicName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.EthnicName].ToString().Trim(); //民族名称
objvCoursewareCase_BaseEN.UniZoneDesc = objRow[convCoursewareCase_Base.UniZoneDesc] == DBNull.Value ? null : objRow[convCoursewareCase_Base.UniZoneDesc].ToString().Trim(); //校区名称
objvCoursewareCase_BaseEN.StuTypeDesc = objRow[convCoursewareCase_Base.StuTypeDesc] == DBNull.Value ? null : objRow[convCoursewareCase_Base.StuTypeDesc].ToString().Trim(); //学生类别名称
objvCoursewareCase_BaseEN.IdXzCollege = objRow[convCoursewareCase_Base.IdXzCollege] == DBNull.Value ? null : objRow[convCoursewareCase_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvCoursewareCase_BaseEN.CollegeID = objRow[convCoursewareCase_Base.CollegeID] == DBNull.Value ? null : objRow[convCoursewareCase_Base.CollegeID].ToString().Trim(); //学院ID
objvCoursewareCase_BaseEN.CollegeName = objRow[convCoursewareCase_Base.CollegeName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.CollegeName].ToString().Trim(); //学院名称
objvCoursewareCase_BaseEN.CollegeNameA = objRow[convCoursewareCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convCoursewareCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvCoursewareCase_BaseEN.IdXzMajor = objRow[convCoursewareCase_Base.IdXzMajor] == DBNull.Value ? null : objRow[convCoursewareCase_Base.IdXzMajor].ToString().Trim(); //专业流水号
objvCoursewareCase_BaseEN.MajorName = objRow[convCoursewareCase_Base.MajorName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.MajorName].ToString().Trim(); //专业名称
objvCoursewareCase_BaseEN.IdGradeBase = objRow[convCoursewareCase_Base.IdGradeBase] == DBNull.Value ? null : objRow[convCoursewareCase_Base.IdGradeBase].ToString().Trim(); //年级流水号
objvCoursewareCase_BaseEN.GradeBaseName = objRow[convCoursewareCase_Base.GradeBaseName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.GradeBaseName].ToString().Trim(); //年级名称
objvCoursewareCase_BaseEN.IdAdminCls = objRow[convCoursewareCase_Base.IdAdminCls] == DBNull.Value ? null : objRow[convCoursewareCase_Base.IdAdminCls].ToString().Trim(); //行政班流水号
objvCoursewareCase_BaseEN.AdminClsId = objRow[convCoursewareCase_Base.AdminClsId] == DBNull.Value ? null : objRow[convCoursewareCase_Base.AdminClsId].ToString().Trim(); //行政班代号
objvCoursewareCase_BaseEN.AdminClsName = objRow[convCoursewareCase_Base.AdminClsName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.AdminClsName].ToString().Trim(); //行政班名称
objvCoursewareCase_BaseEN.Birthday = objRow[convCoursewareCase_Base.Birthday] == DBNull.Value ? null : objRow[convCoursewareCase_Base.Birthday].ToString().Trim(); //出生日期
objvCoursewareCase_BaseEN.NativePlace = objRow[convCoursewareCase_Base.NativePlace] == DBNull.Value ? null : objRow[convCoursewareCase_Base.NativePlace].ToString().Trim(); //籍贯
objvCoursewareCase_BaseEN.Duty = objRow[convCoursewareCase_Base.Duty] == DBNull.Value ? null : objRow[convCoursewareCase_Base.Duty].ToString().Trim(); //职位
objvCoursewareCase_BaseEN.IDCardNo = objRow[convCoursewareCase_Base.IDCardNo] == DBNull.Value ? null : objRow[convCoursewareCase_Base.IDCardNo].ToString().Trim(); //身份证号
objvCoursewareCase_BaseEN.StuCardNo = objRow[convCoursewareCase_Base.StuCardNo] == DBNull.Value ? null : objRow[convCoursewareCase_Base.StuCardNo].ToString().Trim(); //学生证号
objvCoursewareCase_BaseEN.LiveAddress = objRow[convCoursewareCase_Base.LiveAddress] == DBNull.Value ? null : objRow[convCoursewareCase_Base.LiveAddress].ToString().Trim(); //居住地址
objvCoursewareCase_BaseEN.HomePhone = objRow[convCoursewareCase_Base.HomePhone] == DBNull.Value ? null : objRow[convCoursewareCase_Base.HomePhone].ToString().Trim(); //住宅电话
objvCoursewareCase_BaseEN.EnrollmentDate = objRow[convCoursewareCase_Base.EnrollmentDate] == DBNull.Value ? null : objRow[convCoursewareCase_Base.EnrollmentDate].ToString().Trim(); //入校日期
objvCoursewareCase_BaseEN.PostCode = objRow[convCoursewareCase_Base.PostCode] == DBNull.Value ? null : objRow[convCoursewareCase_Base.PostCode].ToString().Trim(); //邮编
objvCoursewareCase_BaseEN.UserKindId = objRow[convCoursewareCase_Base.UserKindId].ToString().Trim(); //用户类别Id
objvCoursewareCase_BaseEN.UserKindName = objRow[convCoursewareCase_Base.UserKindName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.UserKindName].ToString().Trim(); //用户类别名
objvCoursewareCase_BaseEN.UserTypeId = objRow[convCoursewareCase_Base.UserTypeId] == DBNull.Value ? null : objRow[convCoursewareCase_Base.UserTypeId].ToString().Trim(); //用户类型Id
objvCoursewareCase_BaseEN.IsDualVideo = TransNullToBool(objRow[convCoursewareCase_Base.IsDualVideo].ToString().Trim()); //是否双视频
objvCoursewareCase_BaseEN.RecommendedDegreeId = objRow[convCoursewareCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCoursewareCase_BaseEN.RecommendedDegreeName = objRow[convCoursewareCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCoursewareCase_BaseEN.ftpFileType = objRow[convCoursewareCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convCoursewareCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvCoursewareCase_BaseEN.VideoUrl = objRow[convCoursewareCase_Base.VideoUrl] == DBNull.Value ? null : objRow[convCoursewareCase_Base.VideoUrl].ToString().Trim(); //视频Url
objvCoursewareCase_BaseEN.VideoPath = objRow[convCoursewareCase_Base.VideoPath] == DBNull.Value ? null : objRow[convCoursewareCase_Base.VideoPath].ToString().Trim(); //视频目录
objvCoursewareCase_BaseEN.ResErrMsg = objRow[convCoursewareCase_Base.ResErrMsg] == DBNull.Value ? null : objRow[convCoursewareCase_Base.ResErrMsg].ToString().Trim(); //资源错误信息
objvCoursewareCase_BaseEN.Memo = objRow[convCoursewareCase_Base.Memo] == DBNull.Value ? null : objRow[convCoursewareCase_Base.Memo].ToString().Trim(); //备注
objvCoursewareCase_BaseEN.OwnerName = objRow[convCoursewareCase_Base.OwnerName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvCoursewareCase_BaseEN.OwnerNameWithId = objRow[convCoursewareCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convCoursewareCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCoursewareCase_BaseEN.BrowseCount4Case = objRow[convCoursewareCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvCoursewareCase_BaseDA: GetObjByDataRowvCoursewareCase_Base)", objException.Message));
}
objvCoursewareCase_BaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCoursewareCase_BaseEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvCoursewareCase_BaseEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN = new clsvCoursewareCase_BaseEN();
try
{
objvCoursewareCase_BaseEN.IdCoursewareCase = objRow[convCoursewareCase_Base.IdCoursewareCase].ToString().Trim(); //课件教学案例流水号
objvCoursewareCase_BaseEN.CoursewareCaseID = objRow[convCoursewareCase_Base.CoursewareCaseID].ToString().Trim(); //课件教学案例ID
objvCoursewareCase_BaseEN.CoursewareCaseName = objRow[convCoursewareCase_Base.CoursewareCaseName].ToString().Trim(); //课件教学案例名称
objvCoursewareCase_BaseEN.CoursewareCaseTheme = objRow[convCoursewareCase_Base.CoursewareCaseTheme] == DBNull.Value ? null : objRow[convCoursewareCase_Base.CoursewareCaseTheme].ToString().Trim(); //课件教学案例主题词
objvCoursewareCase_BaseEN.IdCoursewareCaseType = objRow[convCoursewareCase_Base.IdCoursewareCaseType].ToString().Trim(); //课件案例类型流水号
objvCoursewareCase_BaseEN.CoursewareCaseTypeName = objRow[convCoursewareCase_Base.CoursewareCaseTypeName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.CoursewareCaseTypeName].ToString().Trim(); //课件案例类型名称
objvCoursewareCase_BaseEN.CoursewareCaseText = objRow[convCoursewareCase_Base.CoursewareCaseText] == DBNull.Value ? null : objRow[convCoursewareCase_Base.CoursewareCaseText].ToString().Trim(); //案例文本内容
objvCoursewareCase_BaseEN.CoursewareCaseDate = objRow[convCoursewareCase_Base.CoursewareCaseDate] == DBNull.Value ? null : objRow[convCoursewareCase_Base.CoursewareCaseDate].ToString().Trim(); //课件教学日期
objvCoursewareCase_BaseEN.CoursewareCaseTime = objRow[convCoursewareCase_Base.CoursewareCaseTime] == DBNull.Value ? null : objRow[convCoursewareCase_Base.CoursewareCaseTime].ToString().Trim(); //课件教学时间
objvCoursewareCase_BaseEN.CoursewareCaseDateIn = objRow[convCoursewareCase_Base.CoursewareCaseDateIn] == DBNull.Value ? null : objRow[convCoursewareCase_Base.CoursewareCaseDateIn].ToString().Trim(); //案例入库日期
objvCoursewareCase_BaseEN.CoursewareCaseTimeIn = objRow[convCoursewareCase_Base.CoursewareCaseTimeIn] == DBNull.Value ? null : objRow[convCoursewareCase_Base.CoursewareCaseTimeIn].ToString().Trim(); //案例入库时间
objvCoursewareCase_BaseEN.IdStudyLevel = objRow[convCoursewareCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCoursewareCase_BaseEN.StudyLevelName = objRow[convCoursewareCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.StudyLevelName].ToString().Trim(); //学段名称
objvCoursewareCase_BaseEN.IdTeachingPlan = objRow[convCoursewareCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convCoursewareCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCoursewareCase_BaseEN.IdCaseType = objRow[convCoursewareCase_Base.IdCaseType] == DBNull.Value ? null : objRow[convCoursewareCase_Base.IdCaseType].ToString().Trim(); //案例类型流水号
objvCoursewareCase_BaseEN.IdDiscipline = objRow[convCoursewareCase_Base.IdDiscipline].ToString().Trim(); //学科流水号
objvCoursewareCase_BaseEN.DisciplineID = objRow[convCoursewareCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convCoursewareCase_Base.DisciplineID].ToString().Trim(); //学科ID
objvCoursewareCase_BaseEN.DisciplineName = objRow[convCoursewareCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.DisciplineName].ToString().Trim(); //学科名称
objvCoursewareCase_BaseEN.IdSenateGaugeVersion = objRow[convCoursewareCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convCoursewareCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCoursewareCase_BaseEN.senateGaugeVersionID = objRow[convCoursewareCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCoursewareCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCoursewareCase_BaseEN.senateGaugeVersionName = objRow[convCoursewareCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCoursewareCase_BaseEN.senateGaugeVersionTtlScore = objRow[convCoursewareCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convCoursewareCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCoursewareCase_BaseEN.VersionNo = objRow[convCoursewareCase_Base.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareCase_Base.VersionNo].ToString().Trim()); //版本号
objvCoursewareCase_BaseEN.IdTeachSkill = objRow[convCoursewareCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCoursewareCase_BaseEN.TeachSkillID = objRow[convCoursewareCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convCoursewareCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID
objvCoursewareCase_BaseEN.SkillTypeName = objRow[convCoursewareCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称
objvCoursewareCase_BaseEN.TeachSkillName = objRow[convCoursewareCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称
objvCoursewareCase_BaseEN.TeachSkillTheory = objRow[convCoursewareCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convCoursewareCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCoursewareCase_BaseEN.TeachSkillOperMethod = objRow[convCoursewareCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCoursewareCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCoursewareCase_BaseEN.IdSkillType = objRow[convCoursewareCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convCoursewareCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号
objvCoursewareCase_BaseEN.SkillTypeID = objRow[convCoursewareCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convCoursewareCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID
objvCoursewareCase_BaseEN.CaseLevelId = objRow[convCoursewareCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convCoursewareCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvCoursewareCase_BaseEN.CaseLevelName = objRow[convCoursewareCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvCoursewareCase_BaseEN.DocFile = objRow[convCoursewareCase_Base.DocFile] == DBNull.Value ? null : objRow[convCoursewareCase_Base.DocFile].ToString().Trim(); //生成的Word文件名
objvCoursewareCase_BaseEN.IsNeedGeneWord = TransNullToBool(objRow[convCoursewareCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvCoursewareCase_BaseEN.WordCreateDate = objRow[convCoursewareCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convCoursewareCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期
objvCoursewareCase_BaseEN.IsVisible = TransNullToBool(objRow[convCoursewareCase_Base.IsVisible].ToString().Trim()); //是否显示
objvCoursewareCase_BaseEN.OwnerId = objRow[convCoursewareCase_Base.OwnerId].ToString().Trim(); //拥有者Id
objvCoursewareCase_BaseEN.IdStudentInfo = objRow[convCoursewareCase_Base.IdStudentInfo] == DBNull.Value ? null : objRow[convCoursewareCase_Base.IdStudentInfo].ToString().Trim(); //学生流水号
objvCoursewareCase_BaseEN.StuName = objRow[convCoursewareCase_Base.StuName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.StuName].ToString().Trim(); //姓名
objvCoursewareCase_BaseEN.StuID = objRow[convCoursewareCase_Base.StuID] == DBNull.Value ? null : objRow[convCoursewareCase_Base.StuID].ToString().Trim(); //学号
objvCoursewareCase_BaseEN.PoliticsName = objRow[convCoursewareCase_Base.PoliticsName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.PoliticsName].ToString().Trim(); //政治面貌
objvCoursewareCase_BaseEN.SexDesc = objRow[convCoursewareCase_Base.SexDesc] == DBNull.Value ? null : objRow[convCoursewareCase_Base.SexDesc].ToString().Trim(); //性别名称
objvCoursewareCase_BaseEN.EthnicName = objRow[convCoursewareCase_Base.EthnicName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.EthnicName].ToString().Trim(); //民族名称
objvCoursewareCase_BaseEN.UniZoneDesc = objRow[convCoursewareCase_Base.UniZoneDesc] == DBNull.Value ? null : objRow[convCoursewareCase_Base.UniZoneDesc].ToString().Trim(); //校区名称
objvCoursewareCase_BaseEN.StuTypeDesc = objRow[convCoursewareCase_Base.StuTypeDesc] == DBNull.Value ? null : objRow[convCoursewareCase_Base.StuTypeDesc].ToString().Trim(); //学生类别名称
objvCoursewareCase_BaseEN.IdXzCollege = objRow[convCoursewareCase_Base.IdXzCollege] == DBNull.Value ? null : objRow[convCoursewareCase_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvCoursewareCase_BaseEN.CollegeID = objRow[convCoursewareCase_Base.CollegeID] == DBNull.Value ? null : objRow[convCoursewareCase_Base.CollegeID].ToString().Trim(); //学院ID
objvCoursewareCase_BaseEN.CollegeName = objRow[convCoursewareCase_Base.CollegeName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.CollegeName].ToString().Trim(); //学院名称
objvCoursewareCase_BaseEN.CollegeNameA = objRow[convCoursewareCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convCoursewareCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvCoursewareCase_BaseEN.IdXzMajor = objRow[convCoursewareCase_Base.IdXzMajor] == DBNull.Value ? null : objRow[convCoursewareCase_Base.IdXzMajor].ToString().Trim(); //专业流水号
objvCoursewareCase_BaseEN.MajorName = objRow[convCoursewareCase_Base.MajorName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.MajorName].ToString().Trim(); //专业名称
objvCoursewareCase_BaseEN.IdGradeBase = objRow[convCoursewareCase_Base.IdGradeBase] == DBNull.Value ? null : objRow[convCoursewareCase_Base.IdGradeBase].ToString().Trim(); //年级流水号
objvCoursewareCase_BaseEN.GradeBaseName = objRow[convCoursewareCase_Base.GradeBaseName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.GradeBaseName].ToString().Trim(); //年级名称
objvCoursewareCase_BaseEN.IdAdminCls = objRow[convCoursewareCase_Base.IdAdminCls] == DBNull.Value ? null : objRow[convCoursewareCase_Base.IdAdminCls].ToString().Trim(); //行政班流水号
objvCoursewareCase_BaseEN.AdminClsId = objRow[convCoursewareCase_Base.AdminClsId] == DBNull.Value ? null : objRow[convCoursewareCase_Base.AdminClsId].ToString().Trim(); //行政班代号
objvCoursewareCase_BaseEN.AdminClsName = objRow[convCoursewareCase_Base.AdminClsName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.AdminClsName].ToString().Trim(); //行政班名称
objvCoursewareCase_BaseEN.Birthday = objRow[convCoursewareCase_Base.Birthday] == DBNull.Value ? null : objRow[convCoursewareCase_Base.Birthday].ToString().Trim(); //出生日期
objvCoursewareCase_BaseEN.NativePlace = objRow[convCoursewareCase_Base.NativePlace] == DBNull.Value ? null : objRow[convCoursewareCase_Base.NativePlace].ToString().Trim(); //籍贯
objvCoursewareCase_BaseEN.Duty = objRow[convCoursewareCase_Base.Duty] == DBNull.Value ? null : objRow[convCoursewareCase_Base.Duty].ToString().Trim(); //职位
objvCoursewareCase_BaseEN.IDCardNo = objRow[convCoursewareCase_Base.IDCardNo] == DBNull.Value ? null : objRow[convCoursewareCase_Base.IDCardNo].ToString().Trim(); //身份证号
objvCoursewareCase_BaseEN.StuCardNo = objRow[convCoursewareCase_Base.StuCardNo] == DBNull.Value ? null : objRow[convCoursewareCase_Base.StuCardNo].ToString().Trim(); //学生证号
objvCoursewareCase_BaseEN.LiveAddress = objRow[convCoursewareCase_Base.LiveAddress] == DBNull.Value ? null : objRow[convCoursewareCase_Base.LiveAddress].ToString().Trim(); //居住地址
objvCoursewareCase_BaseEN.HomePhone = objRow[convCoursewareCase_Base.HomePhone] == DBNull.Value ? null : objRow[convCoursewareCase_Base.HomePhone].ToString().Trim(); //住宅电话
objvCoursewareCase_BaseEN.EnrollmentDate = objRow[convCoursewareCase_Base.EnrollmentDate] == DBNull.Value ? null : objRow[convCoursewareCase_Base.EnrollmentDate].ToString().Trim(); //入校日期
objvCoursewareCase_BaseEN.PostCode = objRow[convCoursewareCase_Base.PostCode] == DBNull.Value ? null : objRow[convCoursewareCase_Base.PostCode].ToString().Trim(); //邮编
objvCoursewareCase_BaseEN.UserKindId = objRow[convCoursewareCase_Base.UserKindId].ToString().Trim(); //用户类别Id
objvCoursewareCase_BaseEN.UserKindName = objRow[convCoursewareCase_Base.UserKindName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.UserKindName].ToString().Trim(); //用户类别名
objvCoursewareCase_BaseEN.UserTypeId = objRow[convCoursewareCase_Base.UserTypeId] == DBNull.Value ? null : objRow[convCoursewareCase_Base.UserTypeId].ToString().Trim(); //用户类型Id
objvCoursewareCase_BaseEN.IsDualVideo = TransNullToBool(objRow[convCoursewareCase_Base.IsDualVideo].ToString().Trim()); //是否双视频
objvCoursewareCase_BaseEN.RecommendedDegreeId = objRow[convCoursewareCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCoursewareCase_BaseEN.RecommendedDegreeName = objRow[convCoursewareCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCoursewareCase_BaseEN.ftpFileType = objRow[convCoursewareCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convCoursewareCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvCoursewareCase_BaseEN.VideoUrl = objRow[convCoursewareCase_Base.VideoUrl] == DBNull.Value ? null : objRow[convCoursewareCase_Base.VideoUrl].ToString().Trim(); //视频Url
objvCoursewareCase_BaseEN.VideoPath = objRow[convCoursewareCase_Base.VideoPath] == DBNull.Value ? null : objRow[convCoursewareCase_Base.VideoPath].ToString().Trim(); //视频目录
objvCoursewareCase_BaseEN.ResErrMsg = objRow[convCoursewareCase_Base.ResErrMsg] == DBNull.Value ? null : objRow[convCoursewareCase_Base.ResErrMsg].ToString().Trim(); //资源错误信息
objvCoursewareCase_BaseEN.Memo = objRow[convCoursewareCase_Base.Memo] == DBNull.Value ? null : objRow[convCoursewareCase_Base.Memo].ToString().Trim(); //备注
objvCoursewareCase_BaseEN.OwnerName = objRow[convCoursewareCase_Base.OwnerName] == DBNull.Value ? null : objRow[convCoursewareCase_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvCoursewareCase_BaseEN.OwnerNameWithId = objRow[convCoursewareCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convCoursewareCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCoursewareCase_BaseEN.BrowseCount4Case = objRow[convCoursewareCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvCoursewareCase_BaseDA: GetObjByDataRow)", objException.Message));
}
objvCoursewareCase_BaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCoursewareCase_BaseEN;
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
objSQL = clsvCoursewareCase_BaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCoursewareCase_BaseEN._CurrTabName, convCoursewareCase_Base.IdCoursewareCase, 8, "");
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
objSQL = clsvCoursewareCase_BaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCoursewareCase_BaseEN._CurrTabName, convCoursewareCase_Base.IdCoursewareCase, 8, strPrefix);
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
 objSQL = clsvCoursewareCase_BaseDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdCoursewareCase from vCoursewareCase_Base where " + strCondition;
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
 objSQL = clsvCoursewareCase_BaseDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdCoursewareCase from vCoursewareCase_Base where " + strCondition;
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
 objSQL = clsvCoursewareCase_BaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCoursewareCase_Base", "IdCoursewareCase = " + "'"+ strIdCoursewareCase+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvCoursewareCase_BaseDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCase_BaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCoursewareCase_Base", strCondition))
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
objSQL = clsvCoursewareCase_BaseDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vCoursewareCase_Base");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvCoursewareCase_BaseENS">源对象</param>
 /// <param name = "objvCoursewareCase_BaseENT">目标对象</param>
public void CopyTo(clsvCoursewareCase_BaseEN objvCoursewareCase_BaseENS, clsvCoursewareCase_BaseEN objvCoursewareCase_BaseENT)
{
objvCoursewareCase_BaseENT.IdCoursewareCase = objvCoursewareCase_BaseENS.IdCoursewareCase; //课件教学案例流水号
objvCoursewareCase_BaseENT.CoursewareCaseID = objvCoursewareCase_BaseENS.CoursewareCaseID; //课件教学案例ID
objvCoursewareCase_BaseENT.CoursewareCaseName = objvCoursewareCase_BaseENS.CoursewareCaseName; //课件教学案例名称
objvCoursewareCase_BaseENT.CoursewareCaseTheme = objvCoursewareCase_BaseENS.CoursewareCaseTheme; //课件教学案例主题词
objvCoursewareCase_BaseENT.IdCoursewareCaseType = objvCoursewareCase_BaseENS.IdCoursewareCaseType; //课件案例类型流水号
objvCoursewareCase_BaseENT.CoursewareCaseTypeName = objvCoursewareCase_BaseENS.CoursewareCaseTypeName; //课件案例类型名称
objvCoursewareCase_BaseENT.CoursewareCaseText = objvCoursewareCase_BaseENS.CoursewareCaseText; //案例文本内容
objvCoursewareCase_BaseENT.CoursewareCaseDate = objvCoursewareCase_BaseENS.CoursewareCaseDate; //课件教学日期
objvCoursewareCase_BaseENT.CoursewareCaseTime = objvCoursewareCase_BaseENS.CoursewareCaseTime; //课件教学时间
objvCoursewareCase_BaseENT.CoursewareCaseDateIn = objvCoursewareCase_BaseENS.CoursewareCaseDateIn; //案例入库日期
objvCoursewareCase_BaseENT.CoursewareCaseTimeIn = objvCoursewareCase_BaseENS.CoursewareCaseTimeIn; //案例入库时间
objvCoursewareCase_BaseENT.IdStudyLevel = objvCoursewareCase_BaseENS.IdStudyLevel; //id_StudyLevel
objvCoursewareCase_BaseENT.StudyLevelName = objvCoursewareCase_BaseENS.StudyLevelName; //学段名称
objvCoursewareCase_BaseENT.IdTeachingPlan = objvCoursewareCase_BaseENS.IdTeachingPlan; //教案流水号
objvCoursewareCase_BaseENT.IdCaseType = objvCoursewareCase_BaseENS.IdCaseType; //案例类型流水号
objvCoursewareCase_BaseENT.IdDiscipline = objvCoursewareCase_BaseENS.IdDiscipline; //学科流水号
objvCoursewareCase_BaseENT.DisciplineID = objvCoursewareCase_BaseENS.DisciplineID; //学科ID
objvCoursewareCase_BaseENT.DisciplineName = objvCoursewareCase_BaseENS.DisciplineName; //学科名称
objvCoursewareCase_BaseENT.IdSenateGaugeVersion = objvCoursewareCase_BaseENS.IdSenateGaugeVersion; //评价量表版本流水号
objvCoursewareCase_BaseENT.senateGaugeVersionID = objvCoursewareCase_BaseENS.senateGaugeVersionID; //评价量表版本ID
objvCoursewareCase_BaseENT.senateGaugeVersionName = objvCoursewareCase_BaseENS.senateGaugeVersionName; //评价量表版本名称
objvCoursewareCase_BaseENT.senateGaugeVersionTtlScore = objvCoursewareCase_BaseENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvCoursewareCase_BaseENT.VersionNo = objvCoursewareCase_BaseENS.VersionNo; //版本号
objvCoursewareCase_BaseENT.IdTeachSkill = objvCoursewareCase_BaseENS.IdTeachSkill; //教学技能流水号
objvCoursewareCase_BaseENT.TeachSkillID = objvCoursewareCase_BaseENS.TeachSkillID; //教学技能ID
objvCoursewareCase_BaseENT.SkillTypeName = objvCoursewareCase_BaseENS.SkillTypeName; //技能类型名称
objvCoursewareCase_BaseENT.TeachSkillName = objvCoursewareCase_BaseENS.TeachSkillName; //教学技能名称
objvCoursewareCase_BaseENT.TeachSkillTheory = objvCoursewareCase_BaseENS.TeachSkillTheory; //教学技能理论阐述
objvCoursewareCase_BaseENT.TeachSkillOperMethod = objvCoursewareCase_BaseENS.TeachSkillOperMethod; //教学技能实践操作方法
objvCoursewareCase_BaseENT.IdSkillType = objvCoursewareCase_BaseENS.IdSkillType; //技能类型流水号
objvCoursewareCase_BaseENT.SkillTypeID = objvCoursewareCase_BaseENS.SkillTypeID; //技能类型ID
objvCoursewareCase_BaseENT.CaseLevelId = objvCoursewareCase_BaseENS.CaseLevelId; //课例等级Id
objvCoursewareCase_BaseENT.CaseLevelName = objvCoursewareCase_BaseENS.CaseLevelName; //案例等级名称
objvCoursewareCase_BaseENT.DocFile = objvCoursewareCase_BaseENS.DocFile; //生成的Word文件名
objvCoursewareCase_BaseENT.IsNeedGeneWord = objvCoursewareCase_BaseENS.IsNeedGeneWord; //是否需要生成Word
objvCoursewareCase_BaseENT.WordCreateDate = objvCoursewareCase_BaseENS.WordCreateDate; //Word生成日期
objvCoursewareCase_BaseENT.IsVisible = objvCoursewareCase_BaseENS.IsVisible; //是否显示
objvCoursewareCase_BaseENT.OwnerId = objvCoursewareCase_BaseENS.OwnerId; //拥有者Id
objvCoursewareCase_BaseENT.IdStudentInfo = objvCoursewareCase_BaseENS.IdStudentInfo; //学生流水号
objvCoursewareCase_BaseENT.StuName = objvCoursewareCase_BaseENS.StuName; //姓名
objvCoursewareCase_BaseENT.StuID = objvCoursewareCase_BaseENS.StuID; //学号
objvCoursewareCase_BaseENT.PoliticsName = objvCoursewareCase_BaseENS.PoliticsName; //政治面貌
objvCoursewareCase_BaseENT.SexDesc = objvCoursewareCase_BaseENS.SexDesc; //性别名称
objvCoursewareCase_BaseENT.EthnicName = objvCoursewareCase_BaseENS.EthnicName; //民族名称
objvCoursewareCase_BaseENT.UniZoneDesc = objvCoursewareCase_BaseENS.UniZoneDesc; //校区名称
objvCoursewareCase_BaseENT.StuTypeDesc = objvCoursewareCase_BaseENS.StuTypeDesc; //学生类别名称
objvCoursewareCase_BaseENT.IdXzCollege = objvCoursewareCase_BaseENS.IdXzCollege; //学院流水号
objvCoursewareCase_BaseENT.CollegeID = objvCoursewareCase_BaseENS.CollegeID; //学院ID
objvCoursewareCase_BaseENT.CollegeName = objvCoursewareCase_BaseENS.CollegeName; //学院名称
objvCoursewareCase_BaseENT.CollegeNameA = objvCoursewareCase_BaseENS.CollegeNameA; //学院名称简写
objvCoursewareCase_BaseENT.IdXzMajor = objvCoursewareCase_BaseENS.IdXzMajor; //专业流水号
objvCoursewareCase_BaseENT.MajorName = objvCoursewareCase_BaseENS.MajorName; //专业名称
objvCoursewareCase_BaseENT.IdGradeBase = objvCoursewareCase_BaseENS.IdGradeBase; //年级流水号
objvCoursewareCase_BaseENT.GradeBaseName = objvCoursewareCase_BaseENS.GradeBaseName; //年级名称
objvCoursewareCase_BaseENT.IdAdminCls = objvCoursewareCase_BaseENS.IdAdminCls; //行政班流水号
objvCoursewareCase_BaseENT.AdminClsId = objvCoursewareCase_BaseENS.AdminClsId; //行政班代号
objvCoursewareCase_BaseENT.AdminClsName = objvCoursewareCase_BaseENS.AdminClsName; //行政班名称
objvCoursewareCase_BaseENT.Birthday = objvCoursewareCase_BaseENS.Birthday; //出生日期
objvCoursewareCase_BaseENT.NativePlace = objvCoursewareCase_BaseENS.NativePlace; //籍贯
objvCoursewareCase_BaseENT.Duty = objvCoursewareCase_BaseENS.Duty; //职位
objvCoursewareCase_BaseENT.IDCardNo = objvCoursewareCase_BaseENS.IDCardNo; //身份证号
objvCoursewareCase_BaseENT.StuCardNo = objvCoursewareCase_BaseENS.StuCardNo; //学生证号
objvCoursewareCase_BaseENT.LiveAddress = objvCoursewareCase_BaseENS.LiveAddress; //居住地址
objvCoursewareCase_BaseENT.HomePhone = objvCoursewareCase_BaseENS.HomePhone; //住宅电话
objvCoursewareCase_BaseENT.EnrollmentDate = objvCoursewareCase_BaseENS.EnrollmentDate; //入校日期
objvCoursewareCase_BaseENT.PostCode = objvCoursewareCase_BaseENS.PostCode; //邮编
objvCoursewareCase_BaseENT.UserKindId = objvCoursewareCase_BaseENS.UserKindId; //用户类别Id
objvCoursewareCase_BaseENT.UserKindName = objvCoursewareCase_BaseENS.UserKindName; //用户类别名
objvCoursewareCase_BaseENT.UserTypeId = objvCoursewareCase_BaseENS.UserTypeId; //用户类型Id
objvCoursewareCase_BaseENT.IsDualVideo = objvCoursewareCase_BaseENS.IsDualVideo; //是否双视频
objvCoursewareCase_BaseENT.RecommendedDegreeId = objvCoursewareCase_BaseENS.RecommendedDegreeId; //推荐度Id
objvCoursewareCase_BaseENT.RecommendedDegreeName = objvCoursewareCase_BaseENS.RecommendedDegreeName; //推荐度名称
objvCoursewareCase_BaseENT.ftpFileType = objvCoursewareCase_BaseENS.ftpFileType; //ftp文件类型
objvCoursewareCase_BaseENT.VideoUrl = objvCoursewareCase_BaseENS.VideoUrl; //视频Url
objvCoursewareCase_BaseENT.VideoPath = objvCoursewareCase_BaseENS.VideoPath; //视频目录
objvCoursewareCase_BaseENT.ResErrMsg = objvCoursewareCase_BaseENS.ResErrMsg; //资源错误信息
objvCoursewareCase_BaseENT.Memo = objvCoursewareCase_BaseENS.Memo; //备注
objvCoursewareCase_BaseENT.OwnerName = objvCoursewareCase_BaseENS.OwnerName; //拥有者姓名
objvCoursewareCase_BaseENT.OwnerNameWithId = objvCoursewareCase_BaseENS.OwnerNameWithId; //拥有者名称附Id
objvCoursewareCase_BaseENT.BrowseCount4Case = objvCoursewareCase_BaseENS.BrowseCount4Case; //课例浏览次数
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvCoursewareCase_BaseEN objvCoursewareCase_BaseEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvCoursewareCase_BaseEN.IdCoursewareCase, 8, convCoursewareCase_Base.IdCoursewareCase);
clsCheckSql.CheckFieldLen(objvCoursewareCase_BaseEN.CoursewareCaseID, 8, convCoursewareCase_Base.CoursewareCaseID);
clsCheckSql.CheckFieldLen(objvCoursewareCase_BaseEN.CoursewareCaseName, 100, convCoursewareCase_Base.CoursewareCaseName);
clsCheckSql.CheckFieldLen(objvCoursewareCase_BaseEN.CoursewareCaseTheme, 200, convCoursewareCase_Base.CoursewareCaseTheme);
clsCheckSql.CheckFieldLen(objvCoursewareCase_BaseEN.IdCoursewareCaseType, 4, convCoursewareCase_Base.IdCoursewareCaseType);
clsCheckSql.CheckFieldLen(objvCoursewareCase_BaseEN.CoursewareCaseTypeName, 50, convCoursewareCase_Base.CoursewareCaseTypeName);
clsCheckSql.CheckFieldLen(objvCoursewareCase_BaseEN.CoursewareCaseText, 8000, convCoursewareCase_Base.CoursewareCaseText);
clsCheckSql.CheckFieldLen(objvCoursewareCase_BaseEN.CoursewareCaseDate, 8, convCoursewareCase_Base.CoursewareCaseDate);
clsCheckSql.CheckFieldLen(objvCoursewareCase_BaseEN.CoursewareCaseTime, 6, convCoursewareCase_Base.CoursewareCaseTime);
clsCheckSql.CheckFieldLen(objvCoursewareCase_BaseEN.CoursewareCaseDateIn, 8, convCoursewareCase_Base.CoursewareCaseDateIn);
clsCheckSql.CheckFieldLen(objvCoursewareCase_BaseEN.CoursewareCaseTimeIn, 6, convCoursewareCase_Base.CoursewareCaseTimeIn);
clsCheckSql.CheckFieldLen(objvCoursewareCase_BaseEN.IdStudyLevel, 4, convCoursewareCase_Base.IdStudyLevel);
clsCheckSql.CheckFieldLen(objvCoursewareCase_BaseEN.StudyLevelName, 50, convCoursewareCase_Base.StudyLevelName);
clsCheckSql.CheckFieldLen(objvCoursewareCase_BaseEN.IdTeachingPlan, 8, convCoursewareCase_Base.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objvCoursewareCase_BaseEN.IdCaseType, 4, convCoursewareCase_Base.IdCaseType);
clsCheckSql.CheckFieldLen(objvCoursewareCase_BaseEN.IdDiscipline, 4, convCoursewareCase_Base.IdDiscipline);
clsCheckSql.CheckFieldLen(objvCoursewareCase_BaseEN.DisciplineID, 4, convCoursewareCase_Base.DisciplineID);
clsCheckSql.CheckFieldLen(objvCoursewareCase_BaseEN.DisciplineName, 50, convCoursewareCase_Base.DisciplineName);
clsCheckSql.CheckFieldLen(objvCoursewareCase_BaseEN.IdSenateGaugeVersion, 4, convCoursewareCase_Base.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objvCoursewareCase_BaseEN.senateGaugeVersionID, 4, convCoursewareCase_Base.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(objvCoursewareCase_BaseEN.senateGaugeVersionName, 200, convCoursewareCase_Base.senateGaugeVersionName);
clsCheckSql.CheckFieldLen(objvCoursewareCase_BaseEN.IdTeachSkill, 8, convCoursewareCase_Base.IdTeachSkill);
clsCheckSql.CheckFieldLen(objvCoursewareCase_BaseEN.TeachSkillID, 8, convCoursewareCase_Base.TeachSkillID);
clsCheckSql.CheckFieldLen(objvCoursewareCase_BaseEN.SkillTypeName, 50, convCoursewareCase_Base.SkillTypeName);
clsCheckSql.CheckFieldLen(objvCoursewareCase_BaseEN.TeachSkillName, 50, convCoursewareCase_Base.TeachSkillName);
clsCheckSql.CheckFieldLen(objvCoursewareCase_BaseEN.TeachSkillTheory, 8000, convCoursewareCase_Base.TeachSkillTheory);
clsCheckSql.CheckFieldLen(objvCoursewareCase_BaseEN.TeachSkillOperMethod, 2000, convCoursewareCase_Base.TeachSkillOperMethod);
clsCheckSql.CheckFieldLen(objvCoursewareCase_BaseEN.IdSkillType, 4, convCoursewareCase_Base.IdSkillType);
clsCheckSql.CheckFieldLen(objvCoursewareCase_BaseEN.SkillTypeID, 4, convCoursewareCase_Base.SkillTypeID);
clsCheckSql.CheckFieldLen(objvCoursewareCase_BaseEN.CaseLevelId, 2, convCoursewareCase_Base.CaseLevelId);
clsCheckSql.CheckFieldLen(objvCoursewareCase_BaseEN.CaseLevelName, 30, convCoursewareCase_Base.CaseLevelName);
clsCheckSql.CheckFieldLen(objvCoursewareCase_BaseEN.DocFile, 200, convCoursewareCase_Base.DocFile);
clsCheckSql.CheckFieldLen(objvCoursewareCase_BaseEN.WordCreateDate, 14, convCoursewareCase_Base.WordCreateDate);
clsCheckSql.CheckFieldLen(objvCoursewareCase_BaseEN.OwnerId, 20, convCoursewareCase_Base.OwnerId);
clsCheckSql.CheckFieldLen(objvCoursewareCase_BaseEN.IdStudentInfo, 8, convCoursewareCase_Base.IdStudentInfo);
clsCheckSql.CheckFieldLen(objvCoursewareCase_BaseEN.StuName, 50, convCoursewareCase_Base.StuName);
clsCheckSql.CheckFieldLen(objvCoursewareCase_BaseEN.StuID, 20, convCoursewareCase_Base.StuID);
clsCheckSql.CheckFieldLen(objvCoursewareCase_BaseEN.PoliticsName, 30, convCoursewareCase_Base.PoliticsName);
clsCheckSql.CheckFieldLen(objvCoursewareCase_BaseEN.SexDesc, 10, convCoursewareCase_Base.SexDesc);
clsCheckSql.CheckFieldLen(objvCoursewareCase_BaseEN.EthnicName, 30, convCoursewareCase_Base.EthnicName);
clsCheckSql.CheckFieldLen(objvCoursewareCase_BaseEN.UniZoneDesc, 20, convCoursewareCase_Base.UniZoneDesc);
clsCheckSql.CheckFieldLen(objvCoursewareCase_BaseEN.StuTypeDesc, 50, convCoursewareCase_Base.StuTypeDesc);
clsCheckSql.CheckFieldLen(objvCoursewareCase_BaseEN.IdXzCollege, 4, convCoursewareCase_Base.IdXzCollege);
clsCheckSql.CheckFieldLen(objvCoursewareCase_BaseEN.CollegeID, 4, convCoursewareCase_Base.CollegeID);
clsCheckSql.CheckFieldLen(objvCoursewareCase_BaseEN.CollegeName, 100, convCoursewareCase_Base.CollegeName);
clsCheckSql.CheckFieldLen(objvCoursewareCase_BaseEN.CollegeNameA, 12, convCoursewareCase_Base.CollegeNameA);
clsCheckSql.CheckFieldLen(objvCoursewareCase_BaseEN.IdXzMajor, 8, convCoursewareCase_Base.IdXzMajor);
clsCheckSql.CheckFieldLen(objvCoursewareCase_BaseEN.MajorName, 100, convCoursewareCase_Base.MajorName);
clsCheckSql.CheckFieldLen(objvCoursewareCase_BaseEN.IdGradeBase, 4, convCoursewareCase_Base.IdGradeBase);
clsCheckSql.CheckFieldLen(objvCoursewareCase_BaseEN.GradeBaseName, 50, convCoursewareCase_Base.GradeBaseName);
clsCheckSql.CheckFieldLen(objvCoursewareCase_BaseEN.IdAdminCls, 8, convCoursewareCase_Base.IdAdminCls);
clsCheckSql.CheckFieldLen(objvCoursewareCase_BaseEN.AdminClsId, 8, convCoursewareCase_Base.AdminClsId);
clsCheckSql.CheckFieldLen(objvCoursewareCase_BaseEN.AdminClsName, 100, convCoursewareCase_Base.AdminClsName);
clsCheckSql.CheckFieldLen(objvCoursewareCase_BaseEN.Birthday, 8, convCoursewareCase_Base.Birthday);
clsCheckSql.CheckFieldLen(objvCoursewareCase_BaseEN.NativePlace, 200, convCoursewareCase_Base.NativePlace);
clsCheckSql.CheckFieldLen(objvCoursewareCase_BaseEN.Duty, 30, convCoursewareCase_Base.Duty);
clsCheckSql.CheckFieldLen(objvCoursewareCase_BaseEN.IDCardNo, 20, convCoursewareCase_Base.IDCardNo);
clsCheckSql.CheckFieldLen(objvCoursewareCase_BaseEN.StuCardNo, 20, convCoursewareCase_Base.StuCardNo);
clsCheckSql.CheckFieldLen(objvCoursewareCase_BaseEN.LiveAddress, 200, convCoursewareCase_Base.LiveAddress);
clsCheckSql.CheckFieldLen(objvCoursewareCase_BaseEN.HomePhone, 20, convCoursewareCase_Base.HomePhone);
clsCheckSql.CheckFieldLen(objvCoursewareCase_BaseEN.EnrollmentDate, 8, convCoursewareCase_Base.EnrollmentDate);
clsCheckSql.CheckFieldLen(objvCoursewareCase_BaseEN.PostCode, 6, convCoursewareCase_Base.PostCode);
clsCheckSql.CheckFieldLen(objvCoursewareCase_BaseEN.UserKindId, 2, convCoursewareCase_Base.UserKindId);
clsCheckSql.CheckFieldLen(objvCoursewareCase_BaseEN.UserKindName, 30, convCoursewareCase_Base.UserKindName);
clsCheckSql.CheckFieldLen(objvCoursewareCase_BaseEN.UserTypeId, 2, convCoursewareCase_Base.UserTypeId);
clsCheckSql.CheckFieldLen(objvCoursewareCase_BaseEN.RecommendedDegreeId, 2, convCoursewareCase_Base.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objvCoursewareCase_BaseEN.RecommendedDegreeName, 30, convCoursewareCase_Base.RecommendedDegreeName);
clsCheckSql.CheckFieldLen(objvCoursewareCase_BaseEN.ftpFileType, 30, convCoursewareCase_Base.ftpFileType);
clsCheckSql.CheckFieldLen(objvCoursewareCase_BaseEN.VideoUrl, 1000, convCoursewareCase_Base.VideoUrl);
clsCheckSql.CheckFieldLen(objvCoursewareCase_BaseEN.VideoPath, 1000, convCoursewareCase_Base.VideoPath);
clsCheckSql.CheckFieldLen(objvCoursewareCase_BaseEN.ResErrMsg, 30, convCoursewareCase_Base.ResErrMsg);
clsCheckSql.CheckFieldLen(objvCoursewareCase_BaseEN.Memo, 1000, convCoursewareCase_Base.Memo);
clsCheckSql.CheckFieldLen(objvCoursewareCase_BaseEN.OwnerName, 30, convCoursewareCase_Base.OwnerName);
clsCheckSql.CheckFieldLen(objvCoursewareCase_BaseEN.OwnerNameWithId, 51, convCoursewareCase_Base.OwnerNameWithId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_BaseEN.IdCoursewareCase, convCoursewareCase_Base.IdCoursewareCase);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_BaseEN.CoursewareCaseID, convCoursewareCase_Base.CoursewareCaseID);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_BaseEN.CoursewareCaseName, convCoursewareCase_Base.CoursewareCaseName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_BaseEN.CoursewareCaseTheme, convCoursewareCase_Base.CoursewareCaseTheme);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_BaseEN.IdCoursewareCaseType, convCoursewareCase_Base.IdCoursewareCaseType);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_BaseEN.CoursewareCaseTypeName, convCoursewareCase_Base.CoursewareCaseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_BaseEN.CoursewareCaseText, convCoursewareCase_Base.CoursewareCaseText);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_BaseEN.CoursewareCaseDate, convCoursewareCase_Base.CoursewareCaseDate);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_BaseEN.CoursewareCaseTime, convCoursewareCase_Base.CoursewareCaseTime);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_BaseEN.CoursewareCaseDateIn, convCoursewareCase_Base.CoursewareCaseDateIn);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_BaseEN.CoursewareCaseTimeIn, convCoursewareCase_Base.CoursewareCaseTimeIn);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_BaseEN.IdStudyLevel, convCoursewareCase_Base.IdStudyLevel);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_BaseEN.StudyLevelName, convCoursewareCase_Base.StudyLevelName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_BaseEN.IdTeachingPlan, convCoursewareCase_Base.IdTeachingPlan);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_BaseEN.IdCaseType, convCoursewareCase_Base.IdCaseType);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_BaseEN.IdDiscipline, convCoursewareCase_Base.IdDiscipline);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_BaseEN.DisciplineID, convCoursewareCase_Base.DisciplineID);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_BaseEN.DisciplineName, convCoursewareCase_Base.DisciplineName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_BaseEN.IdSenateGaugeVersion, convCoursewareCase_Base.IdSenateGaugeVersion);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_BaseEN.senateGaugeVersionID, convCoursewareCase_Base.senateGaugeVersionID);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_BaseEN.senateGaugeVersionName, convCoursewareCase_Base.senateGaugeVersionName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_BaseEN.IdTeachSkill, convCoursewareCase_Base.IdTeachSkill);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_BaseEN.TeachSkillID, convCoursewareCase_Base.TeachSkillID);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_BaseEN.SkillTypeName, convCoursewareCase_Base.SkillTypeName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_BaseEN.TeachSkillName, convCoursewareCase_Base.TeachSkillName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_BaseEN.TeachSkillTheory, convCoursewareCase_Base.TeachSkillTheory);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_BaseEN.TeachSkillOperMethod, convCoursewareCase_Base.TeachSkillOperMethod);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_BaseEN.IdSkillType, convCoursewareCase_Base.IdSkillType);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_BaseEN.SkillTypeID, convCoursewareCase_Base.SkillTypeID);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_BaseEN.CaseLevelId, convCoursewareCase_Base.CaseLevelId);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_BaseEN.CaseLevelName, convCoursewareCase_Base.CaseLevelName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_BaseEN.DocFile, convCoursewareCase_Base.DocFile);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_BaseEN.WordCreateDate, convCoursewareCase_Base.WordCreateDate);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_BaseEN.OwnerId, convCoursewareCase_Base.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_BaseEN.IdStudentInfo, convCoursewareCase_Base.IdStudentInfo);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_BaseEN.StuName, convCoursewareCase_Base.StuName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_BaseEN.StuID, convCoursewareCase_Base.StuID);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_BaseEN.PoliticsName, convCoursewareCase_Base.PoliticsName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_BaseEN.SexDesc, convCoursewareCase_Base.SexDesc);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_BaseEN.EthnicName, convCoursewareCase_Base.EthnicName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_BaseEN.UniZoneDesc, convCoursewareCase_Base.UniZoneDesc);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_BaseEN.StuTypeDesc, convCoursewareCase_Base.StuTypeDesc);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_BaseEN.IdXzCollege, convCoursewareCase_Base.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_BaseEN.CollegeID, convCoursewareCase_Base.CollegeID);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_BaseEN.CollegeName, convCoursewareCase_Base.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_BaseEN.CollegeNameA, convCoursewareCase_Base.CollegeNameA);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_BaseEN.IdXzMajor, convCoursewareCase_Base.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_BaseEN.MajorName, convCoursewareCase_Base.MajorName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_BaseEN.IdGradeBase, convCoursewareCase_Base.IdGradeBase);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_BaseEN.GradeBaseName, convCoursewareCase_Base.GradeBaseName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_BaseEN.IdAdminCls, convCoursewareCase_Base.IdAdminCls);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_BaseEN.AdminClsId, convCoursewareCase_Base.AdminClsId);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_BaseEN.AdminClsName, convCoursewareCase_Base.AdminClsName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_BaseEN.Birthday, convCoursewareCase_Base.Birthday);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_BaseEN.NativePlace, convCoursewareCase_Base.NativePlace);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_BaseEN.Duty, convCoursewareCase_Base.Duty);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_BaseEN.IDCardNo, convCoursewareCase_Base.IDCardNo);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_BaseEN.StuCardNo, convCoursewareCase_Base.StuCardNo);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_BaseEN.LiveAddress, convCoursewareCase_Base.LiveAddress);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_BaseEN.HomePhone, convCoursewareCase_Base.HomePhone);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_BaseEN.EnrollmentDate, convCoursewareCase_Base.EnrollmentDate);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_BaseEN.PostCode, convCoursewareCase_Base.PostCode);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_BaseEN.UserKindId, convCoursewareCase_Base.UserKindId);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_BaseEN.UserKindName, convCoursewareCase_Base.UserKindName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_BaseEN.UserTypeId, convCoursewareCase_Base.UserTypeId);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_BaseEN.RecommendedDegreeId, convCoursewareCase_Base.RecommendedDegreeId);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_BaseEN.RecommendedDegreeName, convCoursewareCase_Base.RecommendedDegreeName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_BaseEN.ftpFileType, convCoursewareCase_Base.ftpFileType);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_BaseEN.VideoUrl, convCoursewareCase_Base.VideoUrl);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_BaseEN.VideoPath, convCoursewareCase_Base.VideoPath);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_BaseEN.ResErrMsg, convCoursewareCase_Base.ResErrMsg);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_BaseEN.Memo, convCoursewareCase_Base.Memo);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_BaseEN.OwnerName, convCoursewareCase_Base.OwnerName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_BaseEN.OwnerNameWithId, convCoursewareCase_Base.OwnerNameWithId);
//检查外键字段长度
 objvCoursewareCase_BaseEN._IsCheckProperty = true;
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
 objSQL = clsvCoursewareCase_BaseDA.GetSpecSQLObj();
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
 objSQL = clsvCoursewareCase_BaseDA.GetSpecSQLObj();
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
 objSQL = clsvCoursewareCase_BaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCoursewareCase_BaseEN._CurrTabName);
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
 objSQL = clsvCoursewareCase_BaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCoursewareCase_BaseEN._CurrTabName, strCondition);
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
 objSQL = clsvCoursewareCase_BaseDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}