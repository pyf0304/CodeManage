
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCoursewareResCase_BaseDA
 表名:vCoursewareResCase_Base(01120496)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:46:15
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课件资源库(CoursewareResLib)
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
 /// v课件资源案例_Base(vCoursewareResCase_Base)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvCoursewareResCase_BaseDA : clsCommBase4DA
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
 return clsvCoursewareResCase_BaseEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvCoursewareResCase_BaseEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCoursewareResCase_BaseEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvCoursewareResCase_BaseEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvCoursewareResCase_BaseEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strIdCoursewareResCase">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strIdCoursewareResCase)
{
strIdCoursewareResCase = strIdCoursewareResCase.Replace("'", "''");
if (strIdCoursewareResCase.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vCoursewareResCase_Base中,检查关键字,长度不正确!(clsvCoursewareResCase_BaseDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdCoursewareResCase)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vCoursewareResCase_Base中,关键字不能为空 或 null!(clsvCoursewareResCase_BaseDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdCoursewareResCase);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvCoursewareResCase_BaseDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvCoursewareResCase_BaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCase_BaseDA.GetSpecSQLObj();
strSQL = "Select * from vCoursewareResCase_Base where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vCoursewareResCase_Base(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvCoursewareResCase_BaseDA: GetDataTable_vCoursewareResCase_Base)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCase_BaseDA.GetSpecSQLObj();
strSQL = "Select * from vCoursewareResCase_Base where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvCoursewareResCase_BaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCase_BaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvCoursewareResCase_BaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCase_BaseDA.GetSpecSQLObj();
strSQL = "Select * from vCoursewareResCase_Base where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvCoursewareResCase_BaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCase_BaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvCoursewareResCase_BaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCase_BaseDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCoursewareResCase_Base where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCoursewareResCase_Base where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvCoursewareResCase_BaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCase_BaseDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vCoursewareResCase_Base where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvCoursewareResCase_BaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCase_BaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vCoursewareResCase_Base.* from vCoursewareResCase_Base Left Join {1} on {2} where {3} and vCoursewareResCase_Base.IdCoursewareResCase not in (Select top {5} vCoursewareResCase_Base.IdCoursewareResCase from vCoursewareResCase_Base Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCoursewareResCase_Base where {1} and IdCoursewareResCase not in (Select top {2} IdCoursewareResCase from vCoursewareResCase_Base where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCoursewareResCase_Base where {1} and IdCoursewareResCase not in (Select top {3} IdCoursewareResCase from vCoursewareResCase_Base where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvCoursewareResCase_BaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCase_BaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vCoursewareResCase_Base.* from vCoursewareResCase_Base Left Join {1} on {2} where {3} and vCoursewareResCase_Base.IdCoursewareResCase not in (Select top {5} vCoursewareResCase_Base.IdCoursewareResCase from vCoursewareResCase_Base Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCoursewareResCase_Base where {1} and IdCoursewareResCase not in (Select top {2} IdCoursewareResCase from vCoursewareResCase_Base where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCoursewareResCase_Base where {1} and IdCoursewareResCase not in (Select top {3} IdCoursewareResCase from vCoursewareResCase_Base where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvCoursewareResCase_BaseEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvCoursewareResCase_BaseDA:GetObjLst)", objException.Message));
}
List<clsvCoursewareResCase_BaseEN> arrObjLst = new List<clsvCoursewareResCase_BaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCase_BaseDA.GetSpecSQLObj();
strSQL = "Select * from vCoursewareResCase_Base where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN = new clsvCoursewareResCase_BaseEN();
try
{
objvCoursewareResCase_BaseEN.IdCoursewareResCase = objRow[convCoursewareResCase_Base.IdCoursewareResCase].ToString().Trim(); //课件资源案例流水号
objvCoursewareResCase_BaseEN.CoursewareResCaseID = objRow[convCoursewareResCase_Base.CoursewareResCaseID].ToString().Trim(); //课件资源案例ID
objvCoursewareResCase_BaseEN.CoursewareResCaseName = objRow[convCoursewareResCase_Base.CoursewareResCaseName].ToString().Trim(); //课件资源案例名称
objvCoursewareResCase_BaseEN.CoursewareResCaseTheme = objRow[convCoursewareResCase_Base.CoursewareResCaseTheme] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CoursewareResCaseTheme].ToString().Trim(); //课件资源案例主题词
objvCoursewareResCase_BaseEN.CoursewareResCaseText = objRow[convCoursewareResCase_Base.CoursewareResCaseText] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CoursewareResCaseText].ToString().Trim(); //案例文本内容
objvCoursewareResCase_BaseEN.IdCoursewareResCaseType = objRow[convCoursewareResCase_Base.IdCoursewareResCaseType].ToString().Trim(); //课件资源类型流水号
objvCoursewareResCase_BaseEN.CoursewareResCaseTypeName = objRow[convCoursewareResCase_Base.CoursewareResCaseTypeName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CoursewareResCaseTypeName].ToString().Trim(); //课件资源案例类型名称
objvCoursewareResCase_BaseEN.CoursewareResCaseDate = objRow[convCoursewareResCase_Base.CoursewareResCaseDate] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CoursewareResCaseDate].ToString().Trim(); //视频资源日期
objvCoursewareResCase_BaseEN.CoursewareResCaseTime = objRow[convCoursewareResCase_Base.CoursewareResCaseTime] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CoursewareResCaseTime].ToString().Trim(); //视频资源时间
objvCoursewareResCase_BaseEN.CoursewareResCaseDateIn = objRow[convCoursewareResCase_Base.CoursewareResCaseDateIn] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CoursewareResCaseDateIn].ToString().Trim(); //案例入库日期
objvCoursewareResCase_BaseEN.CoursewareResCaseTimeIn = objRow[convCoursewareResCase_Base.CoursewareResCaseTimeIn] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CoursewareResCaseTimeIn].ToString().Trim(); //案例入库时间
objvCoursewareResCase_BaseEN.OwnerId = objRow[convCoursewareResCase_Base.OwnerId].ToString().Trim(); //拥有者Id
objvCoursewareResCase_BaseEN.IdStudyLevel = objRow[convCoursewareResCase_Base.IdStudyLevel] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCoursewareResCase_BaseEN.StudyLevelName = objRow[convCoursewareResCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.StudyLevelName].ToString().Trim(); //学段名称
objvCoursewareResCase_BaseEN.IdTeachingPlan = objRow[convCoursewareResCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCoursewareResCase_BaseEN.IdDiscipline = objRow[convCoursewareResCase_Base.IdDiscipline].ToString().Trim(); //学科流水号
objvCoursewareResCase_BaseEN.DisciplineID = objRow[convCoursewareResCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.DisciplineID].ToString().Trim(); //学科ID
objvCoursewareResCase_BaseEN.DisciplineName = objRow[convCoursewareResCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.DisciplineName].ToString().Trim(); //学科名称
objvCoursewareResCase_BaseEN.IdSenateGaugeVersion = objRow[convCoursewareResCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCoursewareResCase_BaseEN.senateGaugeVersionID = objRow[convCoursewareResCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCoursewareResCase_BaseEN.senateGaugeVersionName = objRow[convCoursewareResCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCoursewareResCase_BaseEN.senateGaugeVersionTtlScore = objRow[convCoursewareResCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convCoursewareResCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCoursewareResCase_BaseEN.VersionNo = objRow[convCoursewareResCase_Base.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase_Base.VersionNo].ToString().Trim()); //版本号
objvCoursewareResCase_BaseEN.IdTeachSkill = objRow[convCoursewareResCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCoursewareResCase_BaseEN.TeachSkillID = objRow[convCoursewareResCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID
objvCoursewareResCase_BaseEN.SkillTypeName = objRow[convCoursewareResCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称
objvCoursewareResCase_BaseEN.TeachSkillName = objRow[convCoursewareResCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称
objvCoursewareResCase_BaseEN.TeachSkillTheory = objRow[convCoursewareResCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCoursewareResCase_BaseEN.TeachSkillOperMethod = objRow[convCoursewareResCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCoursewareResCase_BaseEN.IdSkillType = objRow[convCoursewareResCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号
objvCoursewareResCase_BaseEN.SkillTypeID = objRow[convCoursewareResCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID
objvCoursewareResCase_BaseEN.CaseLevelId = objRow[convCoursewareResCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvCoursewareResCase_BaseEN.CaseLevelName = objRow[convCoursewareResCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvCoursewareResCase_BaseEN.DocFile = objRow[convCoursewareResCase_Base.DocFile] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.DocFile].ToString().Trim(); //生成的Word文件名
objvCoursewareResCase_BaseEN.IsNeedGeneWord = TransNullToBool(objRow[convCoursewareResCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvCoursewareResCase_BaseEN.WordCreateDate = objRow[convCoursewareResCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期
objvCoursewareResCase_BaseEN.IsVisible = TransNullToBool(objRow[convCoursewareResCase_Base.IsVisible].ToString().Trim()); //是否显示
objvCoursewareResCase_BaseEN.IsDualVideo = TransNullToBool(objRow[convCoursewareResCase_Base.IsDualVideo].ToString().Trim()); //是否双视频
objvCoursewareResCase_BaseEN.IdXzCollege = objRow[convCoursewareResCase_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvCoursewareResCase_BaseEN.CollegeID = objRow[convCoursewareResCase_Base.CollegeID] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CollegeID].ToString().Trim(); //学院ID
objvCoursewareResCase_BaseEN.CollegeName = objRow[convCoursewareResCase_Base.CollegeName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CollegeName].ToString().Trim(); //学院名称
objvCoursewareResCase_BaseEN.CollegeNameA = objRow[convCoursewareResCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvCoursewareResCase_BaseEN.IdXzMajor = objRow[convCoursewareResCase_Base.IdXzMajor].ToString().Trim(); //专业流水号
objvCoursewareResCase_BaseEN.MajorID = objRow[convCoursewareResCase_Base.MajorID] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.MajorID].ToString().Trim(); //专业ID
objvCoursewareResCase_BaseEN.MajorName = objRow[convCoursewareResCase_Base.MajorName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.MajorName].ToString().Trim(); //专业名称
objvCoursewareResCase_BaseEN.CourseChapterId = objRow[convCoursewareResCase_Base.CourseChapterId] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CourseChapterId].ToString().Trim(); //课程章节ID
objvCoursewareResCase_BaseEN.CourseChapterName = objRow[convCoursewareResCase_Base.CourseChapterName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CourseChapterName].ToString().Trim(); //课程章节名称
objvCoursewareResCase_BaseEN.ParentNodeID = objRow[convCoursewareResCase_Base.ParentNodeID] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.ParentNodeID].ToString().Trim(); //父节点编号
objvCoursewareResCase_BaseEN.ParentNodeName = objRow[convCoursewareResCase_Base.ParentNodeName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.ParentNodeName].ToString().Trim(); //父节点名称
objvCoursewareResCase_BaseEN.ViewCount = objRow[convCoursewareResCase_Base.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase_Base.ViewCount].ToString().Trim()); //浏览量
objvCoursewareResCase_BaseEN.IsShow = TransNullToBool(objRow[convCoursewareResCase_Base.IsShow].ToString().Trim()); //是否启用
objvCoursewareResCase_BaseEN.DownloadNumber = objRow[convCoursewareResCase_Base.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase_Base.DownloadNumber].ToString().Trim()); //下载数目
objvCoursewareResCase_BaseEN.FileIntegration = objRow[convCoursewareResCase_Base.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase_Base.FileIntegration].ToString().Trim()); //文件积分
objvCoursewareResCase_BaseEN.LikeCount = objRow[convCoursewareResCase_Base.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCoursewareResCase_Base.LikeCount].ToString().Trim()); //资源喜欢数量
objvCoursewareResCase_BaseEN.CollectionCount = objRow[convCoursewareResCase_Base.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCoursewareResCase_Base.CollectionCount].ToString().Trim()); //收藏数量
objvCoursewareResCase_BaseEN.RecommendedDegreeId = objRow[convCoursewareResCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCoursewareResCase_BaseEN.RecommendedDegreeName = objRow[convCoursewareResCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCoursewareResCase_BaseEN.ftpFileType = objRow[convCoursewareResCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvCoursewareResCase_BaseEN.CourseId = objRow[convCoursewareResCase_Base.CourseId].ToString().Trim(); //课程Id
objvCoursewareResCase_BaseEN.CourseCode = objRow[convCoursewareResCase_Base.CourseCode] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CourseCode].ToString().Trim(); //课程代码
objvCoursewareResCase_BaseEN.CourseName = objRow[convCoursewareResCase_Base.CourseName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CourseName].ToString().Trim(); //课程名称
objvCoursewareResCase_BaseEN.VideoUrl = objRow[convCoursewareResCase_Base.VideoUrl] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.VideoUrl].ToString().Trim(); //视频Url
objvCoursewareResCase_BaseEN.VideoPath = objRow[convCoursewareResCase_Base.VideoPath] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.VideoPath].ToString().Trim(); //视频目录
objvCoursewareResCase_BaseEN.ResErrMsg = objRow[convCoursewareResCase_Base.ResErrMsg] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.ResErrMsg].ToString().Trim(); //资源错误信息
objvCoursewareResCase_BaseEN.Memo = objRow[convCoursewareResCase_Base.Memo] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.Memo].ToString().Trim(); //备注
objvCoursewareResCase_BaseEN.OwnerName = objRow[convCoursewareResCase_Base.OwnerName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvCoursewareResCase_BaseEN.OwnerNameWithId = objRow[convCoursewareResCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCoursewareResCase_BaseEN.BrowseCount4Case = objRow[convCoursewareResCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCoursewareResCase_BaseDA: GetObjLst)", objException.Message));
}
objvCoursewareResCase_BaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCoursewareResCase_BaseEN);
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
public List<clsvCoursewareResCase_BaseEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvCoursewareResCase_BaseDA:GetObjLstByTabName)", objException.Message));
}
List<clsvCoursewareResCase_BaseEN> arrObjLst = new List<clsvCoursewareResCase_BaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCase_BaseDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN = new clsvCoursewareResCase_BaseEN();
try
{
objvCoursewareResCase_BaseEN.IdCoursewareResCase = objRow[convCoursewareResCase_Base.IdCoursewareResCase].ToString().Trim(); //课件资源案例流水号
objvCoursewareResCase_BaseEN.CoursewareResCaseID = objRow[convCoursewareResCase_Base.CoursewareResCaseID].ToString().Trim(); //课件资源案例ID
objvCoursewareResCase_BaseEN.CoursewareResCaseName = objRow[convCoursewareResCase_Base.CoursewareResCaseName].ToString().Trim(); //课件资源案例名称
objvCoursewareResCase_BaseEN.CoursewareResCaseTheme = objRow[convCoursewareResCase_Base.CoursewareResCaseTheme] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CoursewareResCaseTheme].ToString().Trim(); //课件资源案例主题词
objvCoursewareResCase_BaseEN.CoursewareResCaseText = objRow[convCoursewareResCase_Base.CoursewareResCaseText] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CoursewareResCaseText].ToString().Trim(); //案例文本内容
objvCoursewareResCase_BaseEN.IdCoursewareResCaseType = objRow[convCoursewareResCase_Base.IdCoursewareResCaseType].ToString().Trim(); //课件资源类型流水号
objvCoursewareResCase_BaseEN.CoursewareResCaseTypeName = objRow[convCoursewareResCase_Base.CoursewareResCaseTypeName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CoursewareResCaseTypeName].ToString().Trim(); //课件资源案例类型名称
objvCoursewareResCase_BaseEN.CoursewareResCaseDate = objRow[convCoursewareResCase_Base.CoursewareResCaseDate] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CoursewareResCaseDate].ToString().Trim(); //视频资源日期
objvCoursewareResCase_BaseEN.CoursewareResCaseTime = objRow[convCoursewareResCase_Base.CoursewareResCaseTime] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CoursewareResCaseTime].ToString().Trim(); //视频资源时间
objvCoursewareResCase_BaseEN.CoursewareResCaseDateIn = objRow[convCoursewareResCase_Base.CoursewareResCaseDateIn] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CoursewareResCaseDateIn].ToString().Trim(); //案例入库日期
objvCoursewareResCase_BaseEN.CoursewareResCaseTimeIn = objRow[convCoursewareResCase_Base.CoursewareResCaseTimeIn] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CoursewareResCaseTimeIn].ToString().Trim(); //案例入库时间
objvCoursewareResCase_BaseEN.OwnerId = objRow[convCoursewareResCase_Base.OwnerId].ToString().Trim(); //拥有者Id
objvCoursewareResCase_BaseEN.IdStudyLevel = objRow[convCoursewareResCase_Base.IdStudyLevel] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCoursewareResCase_BaseEN.StudyLevelName = objRow[convCoursewareResCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.StudyLevelName].ToString().Trim(); //学段名称
objvCoursewareResCase_BaseEN.IdTeachingPlan = objRow[convCoursewareResCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCoursewareResCase_BaseEN.IdDiscipline = objRow[convCoursewareResCase_Base.IdDiscipline].ToString().Trim(); //学科流水号
objvCoursewareResCase_BaseEN.DisciplineID = objRow[convCoursewareResCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.DisciplineID].ToString().Trim(); //学科ID
objvCoursewareResCase_BaseEN.DisciplineName = objRow[convCoursewareResCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.DisciplineName].ToString().Trim(); //学科名称
objvCoursewareResCase_BaseEN.IdSenateGaugeVersion = objRow[convCoursewareResCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCoursewareResCase_BaseEN.senateGaugeVersionID = objRow[convCoursewareResCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCoursewareResCase_BaseEN.senateGaugeVersionName = objRow[convCoursewareResCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCoursewareResCase_BaseEN.senateGaugeVersionTtlScore = objRow[convCoursewareResCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convCoursewareResCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCoursewareResCase_BaseEN.VersionNo = objRow[convCoursewareResCase_Base.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase_Base.VersionNo].ToString().Trim()); //版本号
objvCoursewareResCase_BaseEN.IdTeachSkill = objRow[convCoursewareResCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCoursewareResCase_BaseEN.TeachSkillID = objRow[convCoursewareResCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID
objvCoursewareResCase_BaseEN.SkillTypeName = objRow[convCoursewareResCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称
objvCoursewareResCase_BaseEN.TeachSkillName = objRow[convCoursewareResCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称
objvCoursewareResCase_BaseEN.TeachSkillTheory = objRow[convCoursewareResCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCoursewareResCase_BaseEN.TeachSkillOperMethod = objRow[convCoursewareResCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCoursewareResCase_BaseEN.IdSkillType = objRow[convCoursewareResCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号
objvCoursewareResCase_BaseEN.SkillTypeID = objRow[convCoursewareResCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID
objvCoursewareResCase_BaseEN.CaseLevelId = objRow[convCoursewareResCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvCoursewareResCase_BaseEN.CaseLevelName = objRow[convCoursewareResCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvCoursewareResCase_BaseEN.DocFile = objRow[convCoursewareResCase_Base.DocFile] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.DocFile].ToString().Trim(); //生成的Word文件名
objvCoursewareResCase_BaseEN.IsNeedGeneWord = TransNullToBool(objRow[convCoursewareResCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvCoursewareResCase_BaseEN.WordCreateDate = objRow[convCoursewareResCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期
objvCoursewareResCase_BaseEN.IsVisible = TransNullToBool(objRow[convCoursewareResCase_Base.IsVisible].ToString().Trim()); //是否显示
objvCoursewareResCase_BaseEN.IsDualVideo = TransNullToBool(objRow[convCoursewareResCase_Base.IsDualVideo].ToString().Trim()); //是否双视频
objvCoursewareResCase_BaseEN.IdXzCollege = objRow[convCoursewareResCase_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvCoursewareResCase_BaseEN.CollegeID = objRow[convCoursewareResCase_Base.CollegeID] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CollegeID].ToString().Trim(); //学院ID
objvCoursewareResCase_BaseEN.CollegeName = objRow[convCoursewareResCase_Base.CollegeName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CollegeName].ToString().Trim(); //学院名称
objvCoursewareResCase_BaseEN.CollegeNameA = objRow[convCoursewareResCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvCoursewareResCase_BaseEN.IdXzMajor = objRow[convCoursewareResCase_Base.IdXzMajor].ToString().Trim(); //专业流水号
objvCoursewareResCase_BaseEN.MajorID = objRow[convCoursewareResCase_Base.MajorID] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.MajorID].ToString().Trim(); //专业ID
objvCoursewareResCase_BaseEN.MajorName = objRow[convCoursewareResCase_Base.MajorName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.MajorName].ToString().Trim(); //专业名称
objvCoursewareResCase_BaseEN.CourseChapterId = objRow[convCoursewareResCase_Base.CourseChapterId] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CourseChapterId].ToString().Trim(); //课程章节ID
objvCoursewareResCase_BaseEN.CourseChapterName = objRow[convCoursewareResCase_Base.CourseChapterName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CourseChapterName].ToString().Trim(); //课程章节名称
objvCoursewareResCase_BaseEN.ParentNodeID = objRow[convCoursewareResCase_Base.ParentNodeID] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.ParentNodeID].ToString().Trim(); //父节点编号
objvCoursewareResCase_BaseEN.ParentNodeName = objRow[convCoursewareResCase_Base.ParentNodeName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.ParentNodeName].ToString().Trim(); //父节点名称
objvCoursewareResCase_BaseEN.ViewCount = objRow[convCoursewareResCase_Base.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase_Base.ViewCount].ToString().Trim()); //浏览量
objvCoursewareResCase_BaseEN.IsShow = TransNullToBool(objRow[convCoursewareResCase_Base.IsShow].ToString().Trim()); //是否启用
objvCoursewareResCase_BaseEN.DownloadNumber = objRow[convCoursewareResCase_Base.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase_Base.DownloadNumber].ToString().Trim()); //下载数目
objvCoursewareResCase_BaseEN.FileIntegration = objRow[convCoursewareResCase_Base.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase_Base.FileIntegration].ToString().Trim()); //文件积分
objvCoursewareResCase_BaseEN.LikeCount = objRow[convCoursewareResCase_Base.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCoursewareResCase_Base.LikeCount].ToString().Trim()); //资源喜欢数量
objvCoursewareResCase_BaseEN.CollectionCount = objRow[convCoursewareResCase_Base.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCoursewareResCase_Base.CollectionCount].ToString().Trim()); //收藏数量
objvCoursewareResCase_BaseEN.RecommendedDegreeId = objRow[convCoursewareResCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCoursewareResCase_BaseEN.RecommendedDegreeName = objRow[convCoursewareResCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCoursewareResCase_BaseEN.ftpFileType = objRow[convCoursewareResCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvCoursewareResCase_BaseEN.CourseId = objRow[convCoursewareResCase_Base.CourseId].ToString().Trim(); //课程Id
objvCoursewareResCase_BaseEN.CourseCode = objRow[convCoursewareResCase_Base.CourseCode] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CourseCode].ToString().Trim(); //课程代码
objvCoursewareResCase_BaseEN.CourseName = objRow[convCoursewareResCase_Base.CourseName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CourseName].ToString().Trim(); //课程名称
objvCoursewareResCase_BaseEN.VideoUrl = objRow[convCoursewareResCase_Base.VideoUrl] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.VideoUrl].ToString().Trim(); //视频Url
objvCoursewareResCase_BaseEN.VideoPath = objRow[convCoursewareResCase_Base.VideoPath] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.VideoPath].ToString().Trim(); //视频目录
objvCoursewareResCase_BaseEN.ResErrMsg = objRow[convCoursewareResCase_Base.ResErrMsg] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.ResErrMsg].ToString().Trim(); //资源错误信息
objvCoursewareResCase_BaseEN.Memo = objRow[convCoursewareResCase_Base.Memo] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.Memo].ToString().Trim(); //备注
objvCoursewareResCase_BaseEN.OwnerName = objRow[convCoursewareResCase_Base.OwnerName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvCoursewareResCase_BaseEN.OwnerNameWithId = objRow[convCoursewareResCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCoursewareResCase_BaseEN.BrowseCount4Case = objRow[convCoursewareResCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCoursewareResCase_BaseDA: GetObjLst)", objException.Message));
}
objvCoursewareResCase_BaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCoursewareResCase_BaseEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvCoursewareResCase_BaseEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvCoursewareResCase_Base(ref clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCase_BaseDA.GetSpecSQLObj();
strSQL = "Select * from vCoursewareResCase_Base where IdCoursewareResCase = " + "'"+ objvCoursewareResCase_BaseEN.IdCoursewareResCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvCoursewareResCase_BaseEN.IdCoursewareResCase = objDT.Rows[0][convCoursewareResCase_Base.IdCoursewareResCase].ToString().Trim(); //课件资源案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareResCase_BaseEN.CoursewareResCaseID = objDT.Rows[0][convCoursewareResCase_Base.CoursewareResCaseID].ToString().Trim(); //课件资源案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareResCase_BaseEN.CoursewareResCaseName = objDT.Rows[0][convCoursewareResCase_Base.CoursewareResCaseName].ToString().Trim(); //课件资源案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCoursewareResCase_BaseEN.CoursewareResCaseTheme = objDT.Rows[0][convCoursewareResCase_Base.CoursewareResCaseTheme].ToString().Trim(); //课件资源案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareResCase_BaseEN.CoursewareResCaseText = objDT.Rows[0][convCoursewareResCase_Base.CoursewareResCaseText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objvCoursewareResCase_BaseEN.IdCoursewareResCaseType = objDT.Rows[0][convCoursewareResCase_Base.IdCoursewareResCaseType].ToString().Trim(); //课件资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareResCase_BaseEN.CoursewareResCaseTypeName = objDT.Rows[0][convCoursewareResCase_Base.CoursewareResCaseTypeName].ToString().Trim(); //课件资源案例类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCoursewareResCase_BaseEN.CoursewareResCaseDate = objDT.Rows[0][convCoursewareResCase_Base.CoursewareResCaseDate].ToString().Trim(); //视频资源日期(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareResCase_BaseEN.CoursewareResCaseTime = objDT.Rows[0][convCoursewareResCase_Base.CoursewareResCaseTime].ToString().Trim(); //视频资源时间(字段类型:char,字段长度:6,是否可空:True)
 objvCoursewareResCase_BaseEN.CoursewareResCaseDateIn = objDT.Rows[0][convCoursewareResCase_Base.CoursewareResCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareResCase_BaseEN.CoursewareResCaseTimeIn = objDT.Rows[0][convCoursewareResCase_Base.CoursewareResCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvCoursewareResCase_BaseEN.OwnerId = objDT.Rows[0][convCoursewareResCase_Base.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvCoursewareResCase_BaseEN.IdStudyLevel = objDT.Rows[0][convCoursewareResCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvCoursewareResCase_BaseEN.StudyLevelName = objDT.Rows[0][convCoursewareResCase_Base.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareResCase_BaseEN.IdTeachingPlan = objDT.Rows[0][convCoursewareResCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareResCase_BaseEN.IdDiscipline = objDT.Rows[0][convCoursewareResCase_Base.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareResCase_BaseEN.DisciplineID = objDT.Rows[0][convCoursewareResCase_Base.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareResCase_BaseEN.DisciplineName = objDT.Rows[0][convCoursewareResCase_Base.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareResCase_BaseEN.IdSenateGaugeVersion = objDT.Rows[0][convCoursewareResCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareResCase_BaseEN.senateGaugeVersionID = objDT.Rows[0][convCoursewareResCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareResCase_BaseEN.senateGaugeVersionName = objDT.Rows[0][convCoursewareResCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareResCase_BaseEN.senateGaugeVersionTtlScore = TransNullToFloat(objDT.Rows[0][convCoursewareResCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvCoursewareResCase_BaseEN.VersionNo = TransNullToInt(objDT.Rows[0][convCoursewareResCase_Base.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvCoursewareResCase_BaseEN.IdTeachSkill = objDT.Rows[0][convCoursewareResCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareResCase_BaseEN.TeachSkillID = objDT.Rows[0][convCoursewareResCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareResCase_BaseEN.SkillTypeName = objDT.Rows[0][convCoursewareResCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareResCase_BaseEN.TeachSkillName = objDT.Rows[0][convCoursewareResCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareResCase_BaseEN.TeachSkillTheory = objDT.Rows[0][convCoursewareResCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvCoursewareResCase_BaseEN.TeachSkillOperMethod = objDT.Rows[0][convCoursewareResCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法(字段类型:varchar,字段长度:2000,是否可空:True)
 objvCoursewareResCase_BaseEN.IdSkillType = objDT.Rows[0][convCoursewareResCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareResCase_BaseEN.SkillTypeID = objDT.Rows[0][convCoursewareResCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareResCase_BaseEN.CaseLevelId = objDT.Rows[0][convCoursewareResCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvCoursewareResCase_BaseEN.CaseLevelName = objDT.Rows[0][convCoursewareResCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvCoursewareResCase_BaseEN.DocFile = objDT.Rows[0][convCoursewareResCase_Base.DocFile].ToString().Trim(); //生成的Word文件名(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareResCase_BaseEN.IsNeedGeneWord = TransNullToBool(objDT.Rows[0][convCoursewareResCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word(字段类型:bit,字段长度:1,是否可空:True)
 objvCoursewareResCase_BaseEN.WordCreateDate = objDT.Rows[0][convCoursewareResCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objvCoursewareResCase_BaseEN.IsVisible = TransNullToBool(objDT.Rows[0][convCoursewareResCase_Base.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvCoursewareResCase_BaseEN.IsDualVideo = TransNullToBool(objDT.Rows[0][convCoursewareResCase_Base.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvCoursewareResCase_BaseEN.IdXzCollege = objDT.Rows[0][convCoursewareResCase_Base.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvCoursewareResCase_BaseEN.CollegeID = objDT.Rows[0][convCoursewareResCase_Base.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvCoursewareResCase_BaseEN.CollegeName = objDT.Rows[0][convCoursewareResCase_Base.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCoursewareResCase_BaseEN.CollegeNameA = objDT.Rows[0][convCoursewareResCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvCoursewareResCase_BaseEN.IdXzMajor = objDT.Rows[0][convCoursewareResCase_Base.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareResCase_BaseEN.MajorID = objDT.Rows[0][convCoursewareResCase_Base.MajorID].ToString().Trim(); //专业ID(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareResCase_BaseEN.MajorName = objDT.Rows[0][convCoursewareResCase_Base.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCoursewareResCase_BaseEN.CourseChapterId = objDT.Rows[0][convCoursewareResCase_Base.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareResCase_BaseEN.CourseChapterName = objDT.Rows[0][convCoursewareResCase_Base.CourseChapterName].ToString().Trim(); //课程章节名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCoursewareResCase_BaseEN.ParentNodeID = objDT.Rows[0][convCoursewareResCase_Base.ParentNodeID].ToString().Trim(); //父节点编号(字段类型:varchar,字段长度:8,是否可空:True)
 objvCoursewareResCase_BaseEN.ParentNodeName = objDT.Rows[0][convCoursewareResCase_Base.ParentNodeName].ToString().Trim(); //父节点名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvCoursewareResCase_BaseEN.ViewCount = TransNullToInt(objDT.Rows[0][convCoursewareResCase_Base.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvCoursewareResCase_BaseEN.IsShow = TransNullToBool(objDT.Rows[0][convCoursewareResCase_Base.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objvCoursewareResCase_BaseEN.DownloadNumber = TransNullToInt(objDT.Rows[0][convCoursewareResCase_Base.DownloadNumber].ToString().Trim()); //下载数目(字段类型:int,字段长度:4,是否可空:True)
 objvCoursewareResCase_BaseEN.FileIntegration = TransNullToInt(objDT.Rows[0][convCoursewareResCase_Base.FileIntegration].ToString().Trim()); //文件积分(字段类型:int,字段长度:4,是否可空:True)
 objvCoursewareResCase_BaseEN.LikeCount = TransNullToInt(objDT.Rows[0][convCoursewareResCase_Base.LikeCount].ToString().Trim()); //资源喜欢数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvCoursewareResCase_BaseEN.CollectionCount = TransNullToInt(objDT.Rows[0][convCoursewareResCase_Base.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvCoursewareResCase_BaseEN.RecommendedDegreeId = objDT.Rows[0][convCoursewareResCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvCoursewareResCase_BaseEN.RecommendedDegreeName = objDT.Rows[0][convCoursewareResCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCoursewareResCase_BaseEN.ftpFileType = objDT.Rows[0][convCoursewareResCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvCoursewareResCase_BaseEN.CourseId = objDT.Rows[0][convCoursewareResCase_Base.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareResCase_BaseEN.CourseCode = objDT.Rows[0][convCoursewareResCase_Base.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvCoursewareResCase_BaseEN.CourseName = objDT.Rows[0][convCoursewareResCase_Base.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvCoursewareResCase_BaseEN.VideoUrl = objDT.Rows[0][convCoursewareResCase_Base.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCoursewareResCase_BaseEN.VideoPath = objDT.Rows[0][convCoursewareResCase_Base.VideoPath].ToString().Trim(); //视频目录(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCoursewareResCase_BaseEN.ResErrMsg = objDT.Rows[0][convCoursewareResCase_Base.ResErrMsg].ToString().Trim(); //资源错误信息(字段类型:varchar,字段长度:30,是否可空:True)
 objvCoursewareResCase_BaseEN.Memo = objDT.Rows[0][convCoursewareResCase_Base.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCoursewareResCase_BaseEN.OwnerName = objDT.Rows[0][convCoursewareResCase_Base.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvCoursewareResCase_BaseEN.OwnerNameWithId = objDT.Rows[0][convCoursewareResCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
 objvCoursewareResCase_BaseEN.BrowseCount4Case = TransNullToInt(objDT.Rows[0][convCoursewareResCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvCoursewareResCase_BaseDA: GetvCoursewareResCase_Base)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdCoursewareResCase">表关键字</param>
 /// <returns>表对象</returns>
public clsvCoursewareResCase_BaseEN GetObjByIdCoursewareResCase(string strIdCoursewareResCase)
{
CheckPrimaryKey(strIdCoursewareResCase);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCase_BaseDA.GetSpecSQLObj();
strSQL = "Select * from vCoursewareResCase_Base where IdCoursewareResCase = " + "'"+ strIdCoursewareResCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN = new clsvCoursewareResCase_BaseEN();
try
{
 objvCoursewareResCase_BaseEN.IdCoursewareResCase = objRow[convCoursewareResCase_Base.IdCoursewareResCase].ToString().Trim(); //课件资源案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareResCase_BaseEN.CoursewareResCaseID = objRow[convCoursewareResCase_Base.CoursewareResCaseID].ToString().Trim(); //课件资源案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareResCase_BaseEN.CoursewareResCaseName = objRow[convCoursewareResCase_Base.CoursewareResCaseName].ToString().Trim(); //课件资源案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCoursewareResCase_BaseEN.CoursewareResCaseTheme = objRow[convCoursewareResCase_Base.CoursewareResCaseTheme] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CoursewareResCaseTheme].ToString().Trim(); //课件资源案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareResCase_BaseEN.CoursewareResCaseText = objRow[convCoursewareResCase_Base.CoursewareResCaseText] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CoursewareResCaseText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objvCoursewareResCase_BaseEN.IdCoursewareResCaseType = objRow[convCoursewareResCase_Base.IdCoursewareResCaseType].ToString().Trim(); //课件资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareResCase_BaseEN.CoursewareResCaseTypeName = objRow[convCoursewareResCase_Base.CoursewareResCaseTypeName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CoursewareResCaseTypeName].ToString().Trim(); //课件资源案例类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCoursewareResCase_BaseEN.CoursewareResCaseDate = objRow[convCoursewareResCase_Base.CoursewareResCaseDate] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CoursewareResCaseDate].ToString().Trim(); //视频资源日期(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareResCase_BaseEN.CoursewareResCaseTime = objRow[convCoursewareResCase_Base.CoursewareResCaseTime] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CoursewareResCaseTime].ToString().Trim(); //视频资源时间(字段类型:char,字段长度:6,是否可空:True)
 objvCoursewareResCase_BaseEN.CoursewareResCaseDateIn = objRow[convCoursewareResCase_Base.CoursewareResCaseDateIn] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CoursewareResCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareResCase_BaseEN.CoursewareResCaseTimeIn = objRow[convCoursewareResCase_Base.CoursewareResCaseTimeIn] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CoursewareResCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvCoursewareResCase_BaseEN.OwnerId = objRow[convCoursewareResCase_Base.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvCoursewareResCase_BaseEN.IdStudyLevel = objRow[convCoursewareResCase_Base.IdStudyLevel] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvCoursewareResCase_BaseEN.StudyLevelName = objRow[convCoursewareResCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareResCase_BaseEN.IdTeachingPlan = objRow[convCoursewareResCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareResCase_BaseEN.IdDiscipline = objRow[convCoursewareResCase_Base.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareResCase_BaseEN.DisciplineID = objRow[convCoursewareResCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareResCase_BaseEN.DisciplineName = objRow[convCoursewareResCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareResCase_BaseEN.IdSenateGaugeVersion = objRow[convCoursewareResCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareResCase_BaseEN.senateGaugeVersionID = objRow[convCoursewareResCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareResCase_BaseEN.senateGaugeVersionName = objRow[convCoursewareResCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareResCase_BaseEN.senateGaugeVersionTtlScore = objRow[convCoursewareResCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convCoursewareResCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvCoursewareResCase_BaseEN.VersionNo = objRow[convCoursewareResCase_Base.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCoursewareResCase_Base.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvCoursewareResCase_BaseEN.IdTeachSkill = objRow[convCoursewareResCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareResCase_BaseEN.TeachSkillID = objRow[convCoursewareResCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareResCase_BaseEN.SkillTypeName = objRow[convCoursewareResCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareResCase_BaseEN.TeachSkillName = objRow[convCoursewareResCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareResCase_BaseEN.TeachSkillTheory = objRow[convCoursewareResCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvCoursewareResCase_BaseEN.TeachSkillOperMethod = objRow[convCoursewareResCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法(字段类型:varchar,字段长度:2000,是否可空:True)
 objvCoursewareResCase_BaseEN.IdSkillType = objRow[convCoursewareResCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareResCase_BaseEN.SkillTypeID = objRow[convCoursewareResCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareResCase_BaseEN.CaseLevelId = objRow[convCoursewareResCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvCoursewareResCase_BaseEN.CaseLevelName = objRow[convCoursewareResCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvCoursewareResCase_BaseEN.DocFile = objRow[convCoursewareResCase_Base.DocFile] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.DocFile].ToString().Trim(); //生成的Word文件名(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareResCase_BaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convCoursewareResCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word(字段类型:bit,字段长度:1,是否可空:True)
 objvCoursewareResCase_BaseEN.WordCreateDate = objRow[convCoursewareResCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objvCoursewareResCase_BaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCoursewareResCase_Base.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvCoursewareResCase_BaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCoursewareResCase_Base.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvCoursewareResCase_BaseEN.IdXzCollege = objRow[convCoursewareResCase_Base.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvCoursewareResCase_BaseEN.CollegeID = objRow[convCoursewareResCase_Base.CollegeID] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvCoursewareResCase_BaseEN.CollegeName = objRow[convCoursewareResCase_Base.CollegeName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCoursewareResCase_BaseEN.CollegeNameA = objRow[convCoursewareResCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvCoursewareResCase_BaseEN.IdXzMajor = objRow[convCoursewareResCase_Base.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareResCase_BaseEN.MajorID = objRow[convCoursewareResCase_Base.MajorID] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.MajorID].ToString().Trim(); //专业ID(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareResCase_BaseEN.MajorName = objRow[convCoursewareResCase_Base.MajorName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCoursewareResCase_BaseEN.CourseChapterId = objRow[convCoursewareResCase_Base.CourseChapterId] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareResCase_BaseEN.CourseChapterName = objRow[convCoursewareResCase_Base.CourseChapterName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CourseChapterName].ToString().Trim(); //课程章节名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCoursewareResCase_BaseEN.ParentNodeID = objRow[convCoursewareResCase_Base.ParentNodeID] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.ParentNodeID].ToString().Trim(); //父节点编号(字段类型:varchar,字段长度:8,是否可空:True)
 objvCoursewareResCase_BaseEN.ParentNodeName = objRow[convCoursewareResCase_Base.ParentNodeName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.ParentNodeName].ToString().Trim(); //父节点名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvCoursewareResCase_BaseEN.ViewCount = objRow[convCoursewareResCase_Base.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCoursewareResCase_Base.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvCoursewareResCase_BaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convCoursewareResCase_Base.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objvCoursewareResCase_BaseEN.DownloadNumber = objRow[convCoursewareResCase_Base.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCoursewareResCase_Base.DownloadNumber].ToString().Trim()); //下载数目(字段类型:int,字段长度:4,是否可空:True)
 objvCoursewareResCase_BaseEN.FileIntegration = objRow[convCoursewareResCase_Base.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCoursewareResCase_Base.FileIntegration].ToString().Trim()); //文件积分(字段类型:int,字段长度:4,是否可空:True)
 objvCoursewareResCase_BaseEN.LikeCount = objRow[convCoursewareResCase_Base.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCoursewareResCase_Base.LikeCount].ToString().Trim()); //资源喜欢数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvCoursewareResCase_BaseEN.CollectionCount = objRow[convCoursewareResCase_Base.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCoursewareResCase_Base.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvCoursewareResCase_BaseEN.RecommendedDegreeId = objRow[convCoursewareResCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvCoursewareResCase_BaseEN.RecommendedDegreeName = objRow[convCoursewareResCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCoursewareResCase_BaseEN.ftpFileType = objRow[convCoursewareResCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvCoursewareResCase_BaseEN.CourseId = objRow[convCoursewareResCase_Base.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareResCase_BaseEN.CourseCode = objRow[convCoursewareResCase_Base.CourseCode] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvCoursewareResCase_BaseEN.CourseName = objRow[convCoursewareResCase_Base.CourseName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvCoursewareResCase_BaseEN.VideoUrl = objRow[convCoursewareResCase_Base.VideoUrl] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCoursewareResCase_BaseEN.VideoPath = objRow[convCoursewareResCase_Base.VideoPath] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.VideoPath].ToString().Trim(); //视频目录(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCoursewareResCase_BaseEN.ResErrMsg = objRow[convCoursewareResCase_Base.ResErrMsg] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.ResErrMsg].ToString().Trim(); //资源错误信息(字段类型:varchar,字段长度:30,是否可空:True)
 objvCoursewareResCase_BaseEN.Memo = objRow[convCoursewareResCase_Base.Memo] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCoursewareResCase_BaseEN.OwnerName = objRow[convCoursewareResCase_Base.OwnerName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvCoursewareResCase_BaseEN.OwnerNameWithId = objRow[convCoursewareResCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
 objvCoursewareResCase_BaseEN.BrowseCount4Case = objRow[convCoursewareResCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCoursewareResCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvCoursewareResCase_BaseDA: GetObjByIdCoursewareResCase)", objException.Message));
}
return objvCoursewareResCase_BaseEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvCoursewareResCase_BaseEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvCoursewareResCase_BaseDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCase_BaseDA.GetSpecSQLObj();
strSQL = "Select * from vCoursewareResCase_Base where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN = new clsvCoursewareResCase_BaseEN()
{
IdCoursewareResCase = objRow[convCoursewareResCase_Base.IdCoursewareResCase].ToString().Trim(), //课件资源案例流水号
CoursewareResCaseID = objRow[convCoursewareResCase_Base.CoursewareResCaseID].ToString().Trim(), //课件资源案例ID
CoursewareResCaseName = objRow[convCoursewareResCase_Base.CoursewareResCaseName].ToString().Trim(), //课件资源案例名称
CoursewareResCaseTheme = objRow[convCoursewareResCase_Base.CoursewareResCaseTheme] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CoursewareResCaseTheme].ToString().Trim(), //课件资源案例主题词
CoursewareResCaseText = objRow[convCoursewareResCase_Base.CoursewareResCaseText] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CoursewareResCaseText].ToString().Trim(), //案例文本内容
IdCoursewareResCaseType = objRow[convCoursewareResCase_Base.IdCoursewareResCaseType].ToString().Trim(), //课件资源类型流水号
CoursewareResCaseTypeName = objRow[convCoursewareResCase_Base.CoursewareResCaseTypeName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CoursewareResCaseTypeName].ToString().Trim(), //课件资源案例类型名称
CoursewareResCaseDate = objRow[convCoursewareResCase_Base.CoursewareResCaseDate] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CoursewareResCaseDate].ToString().Trim(), //视频资源日期
CoursewareResCaseTime = objRow[convCoursewareResCase_Base.CoursewareResCaseTime] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CoursewareResCaseTime].ToString().Trim(), //视频资源时间
CoursewareResCaseDateIn = objRow[convCoursewareResCase_Base.CoursewareResCaseDateIn] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CoursewareResCaseDateIn].ToString().Trim(), //案例入库日期
CoursewareResCaseTimeIn = objRow[convCoursewareResCase_Base.CoursewareResCaseTimeIn] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CoursewareResCaseTimeIn].ToString().Trim(), //案例入库时间
OwnerId = objRow[convCoursewareResCase_Base.OwnerId].ToString().Trim(), //拥有者Id
IdStudyLevel = objRow[convCoursewareResCase_Base.IdStudyLevel] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.IdStudyLevel].ToString().Trim(), //id_StudyLevel
StudyLevelName = objRow[convCoursewareResCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.StudyLevelName].ToString().Trim(), //学段名称
IdTeachingPlan = objRow[convCoursewareResCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.IdTeachingPlan].ToString().Trim(), //教案流水号
IdDiscipline = objRow[convCoursewareResCase_Base.IdDiscipline].ToString().Trim(), //学科流水号
DisciplineID = objRow[convCoursewareResCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.DisciplineID].ToString().Trim(), //学科ID
DisciplineName = objRow[convCoursewareResCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.DisciplineName].ToString().Trim(), //学科名称
IdSenateGaugeVersion = objRow[convCoursewareResCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.IdSenateGaugeVersion].ToString().Trim(), //评价量表版本流水号
senateGaugeVersionID = objRow[convCoursewareResCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.senateGaugeVersionID].ToString().Trim(), //评价量表版本ID
senateGaugeVersionName = objRow[convCoursewareResCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.senateGaugeVersionName].ToString().Trim(), //评价量表版本名称
senateGaugeVersionTtlScore = objRow[convCoursewareResCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convCoursewareResCase_Base.senateGaugeVersionTtlScore].ToString().Trim()), //评价量表版本总分
VersionNo = objRow[convCoursewareResCase_Base.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase_Base.VersionNo].ToString().Trim()), //版本号
IdTeachSkill = objRow[convCoursewareResCase_Base.IdTeachSkill].ToString().Trim(), //教学技能流水号
TeachSkillID = objRow[convCoursewareResCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.TeachSkillID].ToString().Trim(), //教学技能ID
SkillTypeName = objRow[convCoursewareResCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.SkillTypeName].ToString().Trim(), //技能类型名称
TeachSkillName = objRow[convCoursewareResCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.TeachSkillName].ToString().Trim(), //教学技能名称
TeachSkillTheory = objRow[convCoursewareResCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.TeachSkillTheory].ToString().Trim(), //教学技能理论阐述
TeachSkillOperMethod = objRow[convCoursewareResCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.TeachSkillOperMethod].ToString().Trim(), //教学技能实践操作方法
IdSkillType = objRow[convCoursewareResCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.IdSkillType].ToString().Trim(), //技能类型流水号
SkillTypeID = objRow[convCoursewareResCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.SkillTypeID].ToString().Trim(), //技能类型ID
CaseLevelId = objRow[convCoursewareResCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CaseLevelId].ToString().Trim(), //课例等级Id
CaseLevelName = objRow[convCoursewareResCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CaseLevelName].ToString().Trim(), //案例等级名称
DocFile = objRow[convCoursewareResCase_Base.DocFile] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.DocFile].ToString().Trim(), //生成的Word文件名
IsNeedGeneWord = TransNullToBool(objRow[convCoursewareResCase_Base.IsNeedGeneWord].ToString().Trim()), //是否需要生成Word
WordCreateDate = objRow[convCoursewareResCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.WordCreateDate].ToString().Trim(), //Word生成日期
IsVisible = TransNullToBool(objRow[convCoursewareResCase_Base.IsVisible].ToString().Trim()), //是否显示
IsDualVideo = TransNullToBool(objRow[convCoursewareResCase_Base.IsDualVideo].ToString().Trim()), //是否双视频
IdXzCollege = objRow[convCoursewareResCase_Base.IdXzCollege].ToString().Trim(), //学院流水号
CollegeID = objRow[convCoursewareResCase_Base.CollegeID] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CollegeID].ToString().Trim(), //学院ID
CollegeName = objRow[convCoursewareResCase_Base.CollegeName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CollegeName].ToString().Trim(), //学院名称
CollegeNameA = objRow[convCoursewareResCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CollegeNameA].ToString().Trim(), //学院名称简写
IdXzMajor = objRow[convCoursewareResCase_Base.IdXzMajor].ToString().Trim(), //专业流水号
MajorID = objRow[convCoursewareResCase_Base.MajorID] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.MajorID].ToString().Trim(), //专业ID
MajorName = objRow[convCoursewareResCase_Base.MajorName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.MajorName].ToString().Trim(), //专业名称
CourseChapterId = objRow[convCoursewareResCase_Base.CourseChapterId] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CourseChapterId].ToString().Trim(), //课程章节ID
CourseChapterName = objRow[convCoursewareResCase_Base.CourseChapterName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CourseChapterName].ToString().Trim(), //课程章节名称
ParentNodeID = objRow[convCoursewareResCase_Base.ParentNodeID] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.ParentNodeID].ToString().Trim(), //父节点编号
ParentNodeName = objRow[convCoursewareResCase_Base.ParentNodeName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.ParentNodeName].ToString().Trim(), //父节点名称
ViewCount = objRow[convCoursewareResCase_Base.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase_Base.ViewCount].ToString().Trim()), //浏览量
IsShow = TransNullToBool(objRow[convCoursewareResCase_Base.IsShow].ToString().Trim()), //是否启用
DownloadNumber = objRow[convCoursewareResCase_Base.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase_Base.DownloadNumber].ToString().Trim()), //下载数目
FileIntegration = objRow[convCoursewareResCase_Base.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase_Base.FileIntegration].ToString().Trim()), //文件积分
LikeCount = objRow[convCoursewareResCase_Base.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCoursewareResCase_Base.LikeCount].ToString().Trim()), //资源喜欢数量
CollectionCount = objRow[convCoursewareResCase_Base.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCoursewareResCase_Base.CollectionCount].ToString().Trim()), //收藏数量
RecommendedDegreeId = objRow[convCoursewareResCase_Base.RecommendedDegreeId].ToString().Trim(), //推荐度Id
RecommendedDegreeName = objRow[convCoursewareResCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.RecommendedDegreeName].ToString().Trim(), //推荐度名称
ftpFileType = objRow[convCoursewareResCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.ftpFileType].ToString().Trim(), //ftp文件类型
CourseId = objRow[convCoursewareResCase_Base.CourseId].ToString().Trim(), //课程Id
CourseCode = objRow[convCoursewareResCase_Base.CourseCode] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CourseCode].ToString().Trim(), //课程代码
CourseName = objRow[convCoursewareResCase_Base.CourseName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CourseName].ToString().Trim(), //课程名称
VideoUrl = objRow[convCoursewareResCase_Base.VideoUrl] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.VideoUrl].ToString().Trim(), //视频Url
VideoPath = objRow[convCoursewareResCase_Base.VideoPath] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.VideoPath].ToString().Trim(), //视频目录
ResErrMsg = objRow[convCoursewareResCase_Base.ResErrMsg] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.ResErrMsg].ToString().Trim(), //资源错误信息
Memo = objRow[convCoursewareResCase_Base.Memo] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.Memo].ToString().Trim(), //备注
OwnerName = objRow[convCoursewareResCase_Base.OwnerName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.OwnerName].ToString().Trim(), //拥有者姓名
OwnerNameWithId = objRow[convCoursewareResCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.OwnerNameWithId].ToString().Trim(), //拥有者名称附Id
BrowseCount4Case = objRow[convCoursewareResCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase_Base.BrowseCount4Case].ToString().Trim()) //课例浏览次数
};
objvCoursewareResCase_BaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCoursewareResCase_BaseEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvCoursewareResCase_BaseDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvCoursewareResCase_BaseEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN = new clsvCoursewareResCase_BaseEN();
try
{
objvCoursewareResCase_BaseEN.IdCoursewareResCase = objRow[convCoursewareResCase_Base.IdCoursewareResCase].ToString().Trim(); //课件资源案例流水号
objvCoursewareResCase_BaseEN.CoursewareResCaseID = objRow[convCoursewareResCase_Base.CoursewareResCaseID].ToString().Trim(); //课件资源案例ID
objvCoursewareResCase_BaseEN.CoursewareResCaseName = objRow[convCoursewareResCase_Base.CoursewareResCaseName].ToString().Trim(); //课件资源案例名称
objvCoursewareResCase_BaseEN.CoursewareResCaseTheme = objRow[convCoursewareResCase_Base.CoursewareResCaseTheme] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CoursewareResCaseTheme].ToString().Trim(); //课件资源案例主题词
objvCoursewareResCase_BaseEN.CoursewareResCaseText = objRow[convCoursewareResCase_Base.CoursewareResCaseText] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CoursewareResCaseText].ToString().Trim(); //案例文本内容
objvCoursewareResCase_BaseEN.IdCoursewareResCaseType = objRow[convCoursewareResCase_Base.IdCoursewareResCaseType].ToString().Trim(); //课件资源类型流水号
objvCoursewareResCase_BaseEN.CoursewareResCaseTypeName = objRow[convCoursewareResCase_Base.CoursewareResCaseTypeName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CoursewareResCaseTypeName].ToString().Trim(); //课件资源案例类型名称
objvCoursewareResCase_BaseEN.CoursewareResCaseDate = objRow[convCoursewareResCase_Base.CoursewareResCaseDate] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CoursewareResCaseDate].ToString().Trim(); //视频资源日期
objvCoursewareResCase_BaseEN.CoursewareResCaseTime = objRow[convCoursewareResCase_Base.CoursewareResCaseTime] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CoursewareResCaseTime].ToString().Trim(); //视频资源时间
objvCoursewareResCase_BaseEN.CoursewareResCaseDateIn = objRow[convCoursewareResCase_Base.CoursewareResCaseDateIn] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CoursewareResCaseDateIn].ToString().Trim(); //案例入库日期
objvCoursewareResCase_BaseEN.CoursewareResCaseTimeIn = objRow[convCoursewareResCase_Base.CoursewareResCaseTimeIn] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CoursewareResCaseTimeIn].ToString().Trim(); //案例入库时间
objvCoursewareResCase_BaseEN.OwnerId = objRow[convCoursewareResCase_Base.OwnerId].ToString().Trim(); //拥有者Id
objvCoursewareResCase_BaseEN.IdStudyLevel = objRow[convCoursewareResCase_Base.IdStudyLevel] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCoursewareResCase_BaseEN.StudyLevelName = objRow[convCoursewareResCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.StudyLevelName].ToString().Trim(); //学段名称
objvCoursewareResCase_BaseEN.IdTeachingPlan = objRow[convCoursewareResCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCoursewareResCase_BaseEN.IdDiscipline = objRow[convCoursewareResCase_Base.IdDiscipline].ToString().Trim(); //学科流水号
objvCoursewareResCase_BaseEN.DisciplineID = objRow[convCoursewareResCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.DisciplineID].ToString().Trim(); //学科ID
objvCoursewareResCase_BaseEN.DisciplineName = objRow[convCoursewareResCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.DisciplineName].ToString().Trim(); //学科名称
objvCoursewareResCase_BaseEN.IdSenateGaugeVersion = objRow[convCoursewareResCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCoursewareResCase_BaseEN.senateGaugeVersionID = objRow[convCoursewareResCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCoursewareResCase_BaseEN.senateGaugeVersionName = objRow[convCoursewareResCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCoursewareResCase_BaseEN.senateGaugeVersionTtlScore = objRow[convCoursewareResCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convCoursewareResCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCoursewareResCase_BaseEN.VersionNo = objRow[convCoursewareResCase_Base.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase_Base.VersionNo].ToString().Trim()); //版本号
objvCoursewareResCase_BaseEN.IdTeachSkill = objRow[convCoursewareResCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCoursewareResCase_BaseEN.TeachSkillID = objRow[convCoursewareResCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID
objvCoursewareResCase_BaseEN.SkillTypeName = objRow[convCoursewareResCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称
objvCoursewareResCase_BaseEN.TeachSkillName = objRow[convCoursewareResCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称
objvCoursewareResCase_BaseEN.TeachSkillTheory = objRow[convCoursewareResCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCoursewareResCase_BaseEN.TeachSkillOperMethod = objRow[convCoursewareResCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCoursewareResCase_BaseEN.IdSkillType = objRow[convCoursewareResCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号
objvCoursewareResCase_BaseEN.SkillTypeID = objRow[convCoursewareResCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID
objvCoursewareResCase_BaseEN.CaseLevelId = objRow[convCoursewareResCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvCoursewareResCase_BaseEN.CaseLevelName = objRow[convCoursewareResCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvCoursewareResCase_BaseEN.DocFile = objRow[convCoursewareResCase_Base.DocFile] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.DocFile].ToString().Trim(); //生成的Word文件名
objvCoursewareResCase_BaseEN.IsNeedGeneWord = TransNullToBool(objRow[convCoursewareResCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvCoursewareResCase_BaseEN.WordCreateDate = objRow[convCoursewareResCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期
objvCoursewareResCase_BaseEN.IsVisible = TransNullToBool(objRow[convCoursewareResCase_Base.IsVisible].ToString().Trim()); //是否显示
objvCoursewareResCase_BaseEN.IsDualVideo = TransNullToBool(objRow[convCoursewareResCase_Base.IsDualVideo].ToString().Trim()); //是否双视频
objvCoursewareResCase_BaseEN.IdXzCollege = objRow[convCoursewareResCase_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvCoursewareResCase_BaseEN.CollegeID = objRow[convCoursewareResCase_Base.CollegeID] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CollegeID].ToString().Trim(); //学院ID
objvCoursewareResCase_BaseEN.CollegeName = objRow[convCoursewareResCase_Base.CollegeName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CollegeName].ToString().Trim(); //学院名称
objvCoursewareResCase_BaseEN.CollegeNameA = objRow[convCoursewareResCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvCoursewareResCase_BaseEN.IdXzMajor = objRow[convCoursewareResCase_Base.IdXzMajor].ToString().Trim(); //专业流水号
objvCoursewareResCase_BaseEN.MajorID = objRow[convCoursewareResCase_Base.MajorID] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.MajorID].ToString().Trim(); //专业ID
objvCoursewareResCase_BaseEN.MajorName = objRow[convCoursewareResCase_Base.MajorName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.MajorName].ToString().Trim(); //专业名称
objvCoursewareResCase_BaseEN.CourseChapterId = objRow[convCoursewareResCase_Base.CourseChapterId] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CourseChapterId].ToString().Trim(); //课程章节ID
objvCoursewareResCase_BaseEN.CourseChapterName = objRow[convCoursewareResCase_Base.CourseChapterName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CourseChapterName].ToString().Trim(); //课程章节名称
objvCoursewareResCase_BaseEN.ParentNodeID = objRow[convCoursewareResCase_Base.ParentNodeID] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.ParentNodeID].ToString().Trim(); //父节点编号
objvCoursewareResCase_BaseEN.ParentNodeName = objRow[convCoursewareResCase_Base.ParentNodeName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.ParentNodeName].ToString().Trim(); //父节点名称
objvCoursewareResCase_BaseEN.ViewCount = objRow[convCoursewareResCase_Base.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase_Base.ViewCount].ToString().Trim()); //浏览量
objvCoursewareResCase_BaseEN.IsShow = TransNullToBool(objRow[convCoursewareResCase_Base.IsShow].ToString().Trim()); //是否启用
objvCoursewareResCase_BaseEN.DownloadNumber = objRow[convCoursewareResCase_Base.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase_Base.DownloadNumber].ToString().Trim()); //下载数目
objvCoursewareResCase_BaseEN.FileIntegration = objRow[convCoursewareResCase_Base.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase_Base.FileIntegration].ToString().Trim()); //文件积分
objvCoursewareResCase_BaseEN.LikeCount = objRow[convCoursewareResCase_Base.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCoursewareResCase_Base.LikeCount].ToString().Trim()); //资源喜欢数量
objvCoursewareResCase_BaseEN.CollectionCount = objRow[convCoursewareResCase_Base.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCoursewareResCase_Base.CollectionCount].ToString().Trim()); //收藏数量
objvCoursewareResCase_BaseEN.RecommendedDegreeId = objRow[convCoursewareResCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCoursewareResCase_BaseEN.RecommendedDegreeName = objRow[convCoursewareResCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCoursewareResCase_BaseEN.ftpFileType = objRow[convCoursewareResCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvCoursewareResCase_BaseEN.CourseId = objRow[convCoursewareResCase_Base.CourseId].ToString().Trim(); //课程Id
objvCoursewareResCase_BaseEN.CourseCode = objRow[convCoursewareResCase_Base.CourseCode] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CourseCode].ToString().Trim(); //课程代码
objvCoursewareResCase_BaseEN.CourseName = objRow[convCoursewareResCase_Base.CourseName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CourseName].ToString().Trim(); //课程名称
objvCoursewareResCase_BaseEN.VideoUrl = objRow[convCoursewareResCase_Base.VideoUrl] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.VideoUrl].ToString().Trim(); //视频Url
objvCoursewareResCase_BaseEN.VideoPath = objRow[convCoursewareResCase_Base.VideoPath] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.VideoPath].ToString().Trim(); //视频目录
objvCoursewareResCase_BaseEN.ResErrMsg = objRow[convCoursewareResCase_Base.ResErrMsg] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.ResErrMsg].ToString().Trim(); //资源错误信息
objvCoursewareResCase_BaseEN.Memo = objRow[convCoursewareResCase_Base.Memo] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.Memo].ToString().Trim(); //备注
objvCoursewareResCase_BaseEN.OwnerName = objRow[convCoursewareResCase_Base.OwnerName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvCoursewareResCase_BaseEN.OwnerNameWithId = objRow[convCoursewareResCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCoursewareResCase_BaseEN.BrowseCount4Case = objRow[convCoursewareResCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvCoursewareResCase_BaseDA: GetObjByDataRowvCoursewareResCase_Base)", objException.Message));
}
objvCoursewareResCase_BaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCoursewareResCase_BaseEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvCoursewareResCase_BaseEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN = new clsvCoursewareResCase_BaseEN();
try
{
objvCoursewareResCase_BaseEN.IdCoursewareResCase = objRow[convCoursewareResCase_Base.IdCoursewareResCase].ToString().Trim(); //课件资源案例流水号
objvCoursewareResCase_BaseEN.CoursewareResCaseID = objRow[convCoursewareResCase_Base.CoursewareResCaseID].ToString().Trim(); //课件资源案例ID
objvCoursewareResCase_BaseEN.CoursewareResCaseName = objRow[convCoursewareResCase_Base.CoursewareResCaseName].ToString().Trim(); //课件资源案例名称
objvCoursewareResCase_BaseEN.CoursewareResCaseTheme = objRow[convCoursewareResCase_Base.CoursewareResCaseTheme] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CoursewareResCaseTheme].ToString().Trim(); //课件资源案例主题词
objvCoursewareResCase_BaseEN.CoursewareResCaseText = objRow[convCoursewareResCase_Base.CoursewareResCaseText] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CoursewareResCaseText].ToString().Trim(); //案例文本内容
objvCoursewareResCase_BaseEN.IdCoursewareResCaseType = objRow[convCoursewareResCase_Base.IdCoursewareResCaseType].ToString().Trim(); //课件资源类型流水号
objvCoursewareResCase_BaseEN.CoursewareResCaseTypeName = objRow[convCoursewareResCase_Base.CoursewareResCaseTypeName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CoursewareResCaseTypeName].ToString().Trim(); //课件资源案例类型名称
objvCoursewareResCase_BaseEN.CoursewareResCaseDate = objRow[convCoursewareResCase_Base.CoursewareResCaseDate] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CoursewareResCaseDate].ToString().Trim(); //视频资源日期
objvCoursewareResCase_BaseEN.CoursewareResCaseTime = objRow[convCoursewareResCase_Base.CoursewareResCaseTime] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CoursewareResCaseTime].ToString().Trim(); //视频资源时间
objvCoursewareResCase_BaseEN.CoursewareResCaseDateIn = objRow[convCoursewareResCase_Base.CoursewareResCaseDateIn] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CoursewareResCaseDateIn].ToString().Trim(); //案例入库日期
objvCoursewareResCase_BaseEN.CoursewareResCaseTimeIn = objRow[convCoursewareResCase_Base.CoursewareResCaseTimeIn] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CoursewareResCaseTimeIn].ToString().Trim(); //案例入库时间
objvCoursewareResCase_BaseEN.OwnerId = objRow[convCoursewareResCase_Base.OwnerId].ToString().Trim(); //拥有者Id
objvCoursewareResCase_BaseEN.IdStudyLevel = objRow[convCoursewareResCase_Base.IdStudyLevel] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCoursewareResCase_BaseEN.StudyLevelName = objRow[convCoursewareResCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.StudyLevelName].ToString().Trim(); //学段名称
objvCoursewareResCase_BaseEN.IdTeachingPlan = objRow[convCoursewareResCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCoursewareResCase_BaseEN.IdDiscipline = objRow[convCoursewareResCase_Base.IdDiscipline].ToString().Trim(); //学科流水号
objvCoursewareResCase_BaseEN.DisciplineID = objRow[convCoursewareResCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.DisciplineID].ToString().Trim(); //学科ID
objvCoursewareResCase_BaseEN.DisciplineName = objRow[convCoursewareResCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.DisciplineName].ToString().Trim(); //学科名称
objvCoursewareResCase_BaseEN.IdSenateGaugeVersion = objRow[convCoursewareResCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCoursewareResCase_BaseEN.senateGaugeVersionID = objRow[convCoursewareResCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCoursewareResCase_BaseEN.senateGaugeVersionName = objRow[convCoursewareResCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCoursewareResCase_BaseEN.senateGaugeVersionTtlScore = objRow[convCoursewareResCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convCoursewareResCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCoursewareResCase_BaseEN.VersionNo = objRow[convCoursewareResCase_Base.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase_Base.VersionNo].ToString().Trim()); //版本号
objvCoursewareResCase_BaseEN.IdTeachSkill = objRow[convCoursewareResCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCoursewareResCase_BaseEN.TeachSkillID = objRow[convCoursewareResCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID
objvCoursewareResCase_BaseEN.SkillTypeName = objRow[convCoursewareResCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称
objvCoursewareResCase_BaseEN.TeachSkillName = objRow[convCoursewareResCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称
objvCoursewareResCase_BaseEN.TeachSkillTheory = objRow[convCoursewareResCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCoursewareResCase_BaseEN.TeachSkillOperMethod = objRow[convCoursewareResCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCoursewareResCase_BaseEN.IdSkillType = objRow[convCoursewareResCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号
objvCoursewareResCase_BaseEN.SkillTypeID = objRow[convCoursewareResCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID
objvCoursewareResCase_BaseEN.CaseLevelId = objRow[convCoursewareResCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvCoursewareResCase_BaseEN.CaseLevelName = objRow[convCoursewareResCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvCoursewareResCase_BaseEN.DocFile = objRow[convCoursewareResCase_Base.DocFile] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.DocFile].ToString().Trim(); //生成的Word文件名
objvCoursewareResCase_BaseEN.IsNeedGeneWord = TransNullToBool(objRow[convCoursewareResCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvCoursewareResCase_BaseEN.WordCreateDate = objRow[convCoursewareResCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期
objvCoursewareResCase_BaseEN.IsVisible = TransNullToBool(objRow[convCoursewareResCase_Base.IsVisible].ToString().Trim()); //是否显示
objvCoursewareResCase_BaseEN.IsDualVideo = TransNullToBool(objRow[convCoursewareResCase_Base.IsDualVideo].ToString().Trim()); //是否双视频
objvCoursewareResCase_BaseEN.IdXzCollege = objRow[convCoursewareResCase_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvCoursewareResCase_BaseEN.CollegeID = objRow[convCoursewareResCase_Base.CollegeID] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CollegeID].ToString().Trim(); //学院ID
objvCoursewareResCase_BaseEN.CollegeName = objRow[convCoursewareResCase_Base.CollegeName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CollegeName].ToString().Trim(); //学院名称
objvCoursewareResCase_BaseEN.CollegeNameA = objRow[convCoursewareResCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvCoursewareResCase_BaseEN.IdXzMajor = objRow[convCoursewareResCase_Base.IdXzMajor].ToString().Trim(); //专业流水号
objvCoursewareResCase_BaseEN.MajorID = objRow[convCoursewareResCase_Base.MajorID] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.MajorID].ToString().Trim(); //专业ID
objvCoursewareResCase_BaseEN.MajorName = objRow[convCoursewareResCase_Base.MajorName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.MajorName].ToString().Trim(); //专业名称
objvCoursewareResCase_BaseEN.CourseChapterId = objRow[convCoursewareResCase_Base.CourseChapterId] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CourseChapterId].ToString().Trim(); //课程章节ID
objvCoursewareResCase_BaseEN.CourseChapterName = objRow[convCoursewareResCase_Base.CourseChapterName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CourseChapterName].ToString().Trim(); //课程章节名称
objvCoursewareResCase_BaseEN.ParentNodeID = objRow[convCoursewareResCase_Base.ParentNodeID] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.ParentNodeID].ToString().Trim(); //父节点编号
objvCoursewareResCase_BaseEN.ParentNodeName = objRow[convCoursewareResCase_Base.ParentNodeName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.ParentNodeName].ToString().Trim(); //父节点名称
objvCoursewareResCase_BaseEN.ViewCount = objRow[convCoursewareResCase_Base.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase_Base.ViewCount].ToString().Trim()); //浏览量
objvCoursewareResCase_BaseEN.IsShow = TransNullToBool(objRow[convCoursewareResCase_Base.IsShow].ToString().Trim()); //是否启用
objvCoursewareResCase_BaseEN.DownloadNumber = objRow[convCoursewareResCase_Base.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase_Base.DownloadNumber].ToString().Trim()); //下载数目
objvCoursewareResCase_BaseEN.FileIntegration = objRow[convCoursewareResCase_Base.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase_Base.FileIntegration].ToString().Trim()); //文件积分
objvCoursewareResCase_BaseEN.LikeCount = objRow[convCoursewareResCase_Base.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCoursewareResCase_Base.LikeCount].ToString().Trim()); //资源喜欢数量
objvCoursewareResCase_BaseEN.CollectionCount = objRow[convCoursewareResCase_Base.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCoursewareResCase_Base.CollectionCount].ToString().Trim()); //收藏数量
objvCoursewareResCase_BaseEN.RecommendedDegreeId = objRow[convCoursewareResCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCoursewareResCase_BaseEN.RecommendedDegreeName = objRow[convCoursewareResCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCoursewareResCase_BaseEN.ftpFileType = objRow[convCoursewareResCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvCoursewareResCase_BaseEN.CourseId = objRow[convCoursewareResCase_Base.CourseId].ToString().Trim(); //课程Id
objvCoursewareResCase_BaseEN.CourseCode = objRow[convCoursewareResCase_Base.CourseCode] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CourseCode].ToString().Trim(); //课程代码
objvCoursewareResCase_BaseEN.CourseName = objRow[convCoursewareResCase_Base.CourseName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.CourseName].ToString().Trim(); //课程名称
objvCoursewareResCase_BaseEN.VideoUrl = objRow[convCoursewareResCase_Base.VideoUrl] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.VideoUrl].ToString().Trim(); //视频Url
objvCoursewareResCase_BaseEN.VideoPath = objRow[convCoursewareResCase_Base.VideoPath] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.VideoPath].ToString().Trim(); //视频目录
objvCoursewareResCase_BaseEN.ResErrMsg = objRow[convCoursewareResCase_Base.ResErrMsg] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.ResErrMsg].ToString().Trim(); //资源错误信息
objvCoursewareResCase_BaseEN.Memo = objRow[convCoursewareResCase_Base.Memo] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.Memo].ToString().Trim(); //备注
objvCoursewareResCase_BaseEN.OwnerName = objRow[convCoursewareResCase_Base.OwnerName] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvCoursewareResCase_BaseEN.OwnerNameWithId = objRow[convCoursewareResCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convCoursewareResCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCoursewareResCase_BaseEN.BrowseCount4Case = objRow[convCoursewareResCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvCoursewareResCase_BaseDA: GetObjByDataRow)", objException.Message));
}
objvCoursewareResCase_BaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCoursewareResCase_BaseEN;
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
objSQL = clsvCoursewareResCase_BaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCoursewareResCase_BaseEN._CurrTabName, convCoursewareResCase_Base.IdCoursewareResCase, 8, "");
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
objSQL = clsvCoursewareResCase_BaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCoursewareResCase_BaseEN._CurrTabName, convCoursewareResCase_Base.IdCoursewareResCase, 8, strPrefix);
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
 objSQL = clsvCoursewareResCase_BaseDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdCoursewareResCase from vCoursewareResCase_Base where " + strCondition;
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
 objSQL = clsvCoursewareResCase_BaseDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdCoursewareResCase from vCoursewareResCase_Base where " + strCondition;
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
 /// <param name = "strIdCoursewareResCase">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strIdCoursewareResCase)
{
CheckPrimaryKey(strIdCoursewareResCase);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCase_BaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCoursewareResCase_Base", "IdCoursewareResCase = " + "'"+ strIdCoursewareResCase+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvCoursewareResCase_BaseDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCase_BaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCoursewareResCase_Base", strCondition))
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
objSQL = clsvCoursewareResCase_BaseDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vCoursewareResCase_Base");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvCoursewareResCase_BaseENS">源对象</param>
 /// <param name = "objvCoursewareResCase_BaseENT">目标对象</param>
public void CopyTo(clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseENS, clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseENT)
{
objvCoursewareResCase_BaseENT.IdCoursewareResCase = objvCoursewareResCase_BaseENS.IdCoursewareResCase; //课件资源案例流水号
objvCoursewareResCase_BaseENT.CoursewareResCaseID = objvCoursewareResCase_BaseENS.CoursewareResCaseID; //课件资源案例ID
objvCoursewareResCase_BaseENT.CoursewareResCaseName = objvCoursewareResCase_BaseENS.CoursewareResCaseName; //课件资源案例名称
objvCoursewareResCase_BaseENT.CoursewareResCaseTheme = objvCoursewareResCase_BaseENS.CoursewareResCaseTheme; //课件资源案例主题词
objvCoursewareResCase_BaseENT.CoursewareResCaseText = objvCoursewareResCase_BaseENS.CoursewareResCaseText; //案例文本内容
objvCoursewareResCase_BaseENT.IdCoursewareResCaseType = objvCoursewareResCase_BaseENS.IdCoursewareResCaseType; //课件资源类型流水号
objvCoursewareResCase_BaseENT.CoursewareResCaseTypeName = objvCoursewareResCase_BaseENS.CoursewareResCaseTypeName; //课件资源案例类型名称
objvCoursewareResCase_BaseENT.CoursewareResCaseDate = objvCoursewareResCase_BaseENS.CoursewareResCaseDate; //视频资源日期
objvCoursewareResCase_BaseENT.CoursewareResCaseTime = objvCoursewareResCase_BaseENS.CoursewareResCaseTime; //视频资源时间
objvCoursewareResCase_BaseENT.CoursewareResCaseDateIn = objvCoursewareResCase_BaseENS.CoursewareResCaseDateIn; //案例入库日期
objvCoursewareResCase_BaseENT.CoursewareResCaseTimeIn = objvCoursewareResCase_BaseENS.CoursewareResCaseTimeIn; //案例入库时间
objvCoursewareResCase_BaseENT.OwnerId = objvCoursewareResCase_BaseENS.OwnerId; //拥有者Id
objvCoursewareResCase_BaseENT.IdStudyLevel = objvCoursewareResCase_BaseENS.IdStudyLevel; //id_StudyLevel
objvCoursewareResCase_BaseENT.StudyLevelName = objvCoursewareResCase_BaseENS.StudyLevelName; //学段名称
objvCoursewareResCase_BaseENT.IdTeachingPlan = objvCoursewareResCase_BaseENS.IdTeachingPlan; //教案流水号
objvCoursewareResCase_BaseENT.IdDiscipline = objvCoursewareResCase_BaseENS.IdDiscipline; //学科流水号
objvCoursewareResCase_BaseENT.DisciplineID = objvCoursewareResCase_BaseENS.DisciplineID; //学科ID
objvCoursewareResCase_BaseENT.DisciplineName = objvCoursewareResCase_BaseENS.DisciplineName; //学科名称
objvCoursewareResCase_BaseENT.IdSenateGaugeVersion = objvCoursewareResCase_BaseENS.IdSenateGaugeVersion; //评价量表版本流水号
objvCoursewareResCase_BaseENT.senateGaugeVersionID = objvCoursewareResCase_BaseENS.senateGaugeVersionID; //评价量表版本ID
objvCoursewareResCase_BaseENT.senateGaugeVersionName = objvCoursewareResCase_BaseENS.senateGaugeVersionName; //评价量表版本名称
objvCoursewareResCase_BaseENT.senateGaugeVersionTtlScore = objvCoursewareResCase_BaseENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvCoursewareResCase_BaseENT.VersionNo = objvCoursewareResCase_BaseENS.VersionNo; //版本号
objvCoursewareResCase_BaseENT.IdTeachSkill = objvCoursewareResCase_BaseENS.IdTeachSkill; //教学技能流水号
objvCoursewareResCase_BaseENT.TeachSkillID = objvCoursewareResCase_BaseENS.TeachSkillID; //教学技能ID
objvCoursewareResCase_BaseENT.SkillTypeName = objvCoursewareResCase_BaseENS.SkillTypeName; //技能类型名称
objvCoursewareResCase_BaseENT.TeachSkillName = objvCoursewareResCase_BaseENS.TeachSkillName; //教学技能名称
objvCoursewareResCase_BaseENT.TeachSkillTheory = objvCoursewareResCase_BaseENS.TeachSkillTheory; //教学技能理论阐述
objvCoursewareResCase_BaseENT.TeachSkillOperMethod = objvCoursewareResCase_BaseENS.TeachSkillOperMethod; //教学技能实践操作方法
objvCoursewareResCase_BaseENT.IdSkillType = objvCoursewareResCase_BaseENS.IdSkillType; //技能类型流水号
objvCoursewareResCase_BaseENT.SkillTypeID = objvCoursewareResCase_BaseENS.SkillTypeID; //技能类型ID
objvCoursewareResCase_BaseENT.CaseLevelId = objvCoursewareResCase_BaseENS.CaseLevelId; //课例等级Id
objvCoursewareResCase_BaseENT.CaseLevelName = objvCoursewareResCase_BaseENS.CaseLevelName; //案例等级名称
objvCoursewareResCase_BaseENT.DocFile = objvCoursewareResCase_BaseENS.DocFile; //生成的Word文件名
objvCoursewareResCase_BaseENT.IsNeedGeneWord = objvCoursewareResCase_BaseENS.IsNeedGeneWord; //是否需要生成Word
objvCoursewareResCase_BaseENT.WordCreateDate = objvCoursewareResCase_BaseENS.WordCreateDate; //Word生成日期
objvCoursewareResCase_BaseENT.IsVisible = objvCoursewareResCase_BaseENS.IsVisible; //是否显示
objvCoursewareResCase_BaseENT.IsDualVideo = objvCoursewareResCase_BaseENS.IsDualVideo; //是否双视频
objvCoursewareResCase_BaseENT.IdXzCollege = objvCoursewareResCase_BaseENS.IdXzCollege; //学院流水号
objvCoursewareResCase_BaseENT.CollegeID = objvCoursewareResCase_BaseENS.CollegeID; //学院ID
objvCoursewareResCase_BaseENT.CollegeName = objvCoursewareResCase_BaseENS.CollegeName; //学院名称
objvCoursewareResCase_BaseENT.CollegeNameA = objvCoursewareResCase_BaseENS.CollegeNameA; //学院名称简写
objvCoursewareResCase_BaseENT.IdXzMajor = objvCoursewareResCase_BaseENS.IdXzMajor; //专业流水号
objvCoursewareResCase_BaseENT.MajorID = objvCoursewareResCase_BaseENS.MajorID; //专业ID
objvCoursewareResCase_BaseENT.MajorName = objvCoursewareResCase_BaseENS.MajorName; //专业名称
objvCoursewareResCase_BaseENT.CourseChapterId = objvCoursewareResCase_BaseENS.CourseChapterId; //课程章节ID
objvCoursewareResCase_BaseENT.CourseChapterName = objvCoursewareResCase_BaseENS.CourseChapterName; //课程章节名称
objvCoursewareResCase_BaseENT.ParentNodeID = objvCoursewareResCase_BaseENS.ParentNodeID; //父节点编号
objvCoursewareResCase_BaseENT.ParentNodeName = objvCoursewareResCase_BaseENS.ParentNodeName; //父节点名称
objvCoursewareResCase_BaseENT.ViewCount = objvCoursewareResCase_BaseENS.ViewCount; //浏览量
objvCoursewareResCase_BaseENT.IsShow = objvCoursewareResCase_BaseENS.IsShow; //是否启用
objvCoursewareResCase_BaseENT.DownloadNumber = objvCoursewareResCase_BaseENS.DownloadNumber; //下载数目
objvCoursewareResCase_BaseENT.FileIntegration = objvCoursewareResCase_BaseENS.FileIntegration; //文件积分
objvCoursewareResCase_BaseENT.LikeCount = objvCoursewareResCase_BaseENS.LikeCount; //资源喜欢数量
objvCoursewareResCase_BaseENT.CollectionCount = objvCoursewareResCase_BaseENS.CollectionCount; //收藏数量
objvCoursewareResCase_BaseENT.RecommendedDegreeId = objvCoursewareResCase_BaseENS.RecommendedDegreeId; //推荐度Id
objvCoursewareResCase_BaseENT.RecommendedDegreeName = objvCoursewareResCase_BaseENS.RecommendedDegreeName; //推荐度名称
objvCoursewareResCase_BaseENT.ftpFileType = objvCoursewareResCase_BaseENS.ftpFileType; //ftp文件类型
objvCoursewareResCase_BaseENT.CourseId = objvCoursewareResCase_BaseENS.CourseId; //课程Id
objvCoursewareResCase_BaseENT.CourseCode = objvCoursewareResCase_BaseENS.CourseCode; //课程代码
objvCoursewareResCase_BaseENT.CourseName = objvCoursewareResCase_BaseENS.CourseName; //课程名称
objvCoursewareResCase_BaseENT.VideoUrl = objvCoursewareResCase_BaseENS.VideoUrl; //视频Url
objvCoursewareResCase_BaseENT.VideoPath = objvCoursewareResCase_BaseENS.VideoPath; //视频目录
objvCoursewareResCase_BaseENT.ResErrMsg = objvCoursewareResCase_BaseENS.ResErrMsg; //资源错误信息
objvCoursewareResCase_BaseENT.Memo = objvCoursewareResCase_BaseENS.Memo; //备注
objvCoursewareResCase_BaseENT.OwnerName = objvCoursewareResCase_BaseENS.OwnerName; //拥有者姓名
objvCoursewareResCase_BaseENT.OwnerNameWithId = objvCoursewareResCase_BaseENS.OwnerNameWithId; //拥有者名称附Id
objvCoursewareResCase_BaseENT.BrowseCount4Case = objvCoursewareResCase_BaseENS.BrowseCount4Case; //课例浏览次数
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvCoursewareResCase_BaseEN objvCoursewareResCase_BaseEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvCoursewareResCase_BaseEN.IdCoursewareResCase, 8, convCoursewareResCase_Base.IdCoursewareResCase);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_BaseEN.CoursewareResCaseID, 8, convCoursewareResCase_Base.CoursewareResCaseID);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_BaseEN.CoursewareResCaseName, 100, convCoursewareResCase_Base.CoursewareResCaseName);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_BaseEN.CoursewareResCaseTheme, 200, convCoursewareResCase_Base.CoursewareResCaseTheme);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_BaseEN.CoursewareResCaseText, 8000, convCoursewareResCase_Base.CoursewareResCaseText);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_BaseEN.IdCoursewareResCaseType, 4, convCoursewareResCase_Base.IdCoursewareResCaseType);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_BaseEN.CoursewareResCaseTypeName, 30, convCoursewareResCase_Base.CoursewareResCaseTypeName);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_BaseEN.CoursewareResCaseDate, 8, convCoursewareResCase_Base.CoursewareResCaseDate);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_BaseEN.CoursewareResCaseTime, 6, convCoursewareResCase_Base.CoursewareResCaseTime);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_BaseEN.CoursewareResCaseDateIn, 8, convCoursewareResCase_Base.CoursewareResCaseDateIn);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_BaseEN.CoursewareResCaseTimeIn, 6, convCoursewareResCase_Base.CoursewareResCaseTimeIn);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_BaseEN.OwnerId, 20, convCoursewareResCase_Base.OwnerId);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_BaseEN.IdStudyLevel, 4, convCoursewareResCase_Base.IdStudyLevel);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_BaseEN.StudyLevelName, 50, convCoursewareResCase_Base.StudyLevelName);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_BaseEN.IdTeachingPlan, 8, convCoursewareResCase_Base.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_BaseEN.IdDiscipline, 4, convCoursewareResCase_Base.IdDiscipline);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_BaseEN.DisciplineID, 4, convCoursewareResCase_Base.DisciplineID);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_BaseEN.DisciplineName, 50, convCoursewareResCase_Base.DisciplineName);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_BaseEN.IdSenateGaugeVersion, 4, convCoursewareResCase_Base.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_BaseEN.senateGaugeVersionID, 4, convCoursewareResCase_Base.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_BaseEN.senateGaugeVersionName, 200, convCoursewareResCase_Base.senateGaugeVersionName);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_BaseEN.IdTeachSkill, 8, convCoursewareResCase_Base.IdTeachSkill);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_BaseEN.TeachSkillID, 8, convCoursewareResCase_Base.TeachSkillID);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_BaseEN.SkillTypeName, 50, convCoursewareResCase_Base.SkillTypeName);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_BaseEN.TeachSkillName, 50, convCoursewareResCase_Base.TeachSkillName);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_BaseEN.TeachSkillTheory, 8000, convCoursewareResCase_Base.TeachSkillTheory);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_BaseEN.TeachSkillOperMethod, 2000, convCoursewareResCase_Base.TeachSkillOperMethod);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_BaseEN.IdSkillType, 4, convCoursewareResCase_Base.IdSkillType);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_BaseEN.SkillTypeID, 4, convCoursewareResCase_Base.SkillTypeID);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_BaseEN.CaseLevelId, 2, convCoursewareResCase_Base.CaseLevelId);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_BaseEN.CaseLevelName, 30, convCoursewareResCase_Base.CaseLevelName);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_BaseEN.DocFile, 200, convCoursewareResCase_Base.DocFile);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_BaseEN.WordCreateDate, 14, convCoursewareResCase_Base.WordCreateDate);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_BaseEN.IdXzCollege, 4, convCoursewareResCase_Base.IdXzCollege);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_BaseEN.CollegeID, 4, convCoursewareResCase_Base.CollegeID);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_BaseEN.CollegeName, 100, convCoursewareResCase_Base.CollegeName);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_BaseEN.CollegeNameA, 12, convCoursewareResCase_Base.CollegeNameA);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_BaseEN.IdXzMajor, 8, convCoursewareResCase_Base.IdXzMajor);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_BaseEN.MajorID, 4, convCoursewareResCase_Base.MajorID);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_BaseEN.MajorName, 100, convCoursewareResCase_Base.MajorName);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_BaseEN.CourseChapterId, 8, convCoursewareResCase_Base.CourseChapterId);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_BaseEN.CourseChapterName, 100, convCoursewareResCase_Base.CourseChapterName);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_BaseEN.ParentNodeID, 8, convCoursewareResCase_Base.ParentNodeID);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_BaseEN.ParentNodeName, 50, convCoursewareResCase_Base.ParentNodeName);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_BaseEN.RecommendedDegreeId, 2, convCoursewareResCase_Base.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_BaseEN.RecommendedDegreeName, 30, convCoursewareResCase_Base.RecommendedDegreeName);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_BaseEN.ftpFileType, 30, convCoursewareResCase_Base.ftpFileType);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_BaseEN.CourseId, 8, convCoursewareResCase_Base.CourseId);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_BaseEN.CourseCode, 20, convCoursewareResCase_Base.CourseCode);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_BaseEN.CourseName, 100, convCoursewareResCase_Base.CourseName);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_BaseEN.VideoUrl, 1000, convCoursewareResCase_Base.VideoUrl);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_BaseEN.VideoPath, 1000, convCoursewareResCase_Base.VideoPath);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_BaseEN.ResErrMsg, 30, convCoursewareResCase_Base.ResErrMsg);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_BaseEN.Memo, 1000, convCoursewareResCase_Base.Memo);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_BaseEN.OwnerName, 30, convCoursewareResCase_Base.OwnerName);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_BaseEN.OwnerNameWithId, 51, convCoursewareResCase_Base.OwnerNameWithId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_BaseEN.IdCoursewareResCase, convCoursewareResCase_Base.IdCoursewareResCase);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_BaseEN.CoursewareResCaseID, convCoursewareResCase_Base.CoursewareResCaseID);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_BaseEN.CoursewareResCaseName, convCoursewareResCase_Base.CoursewareResCaseName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_BaseEN.CoursewareResCaseTheme, convCoursewareResCase_Base.CoursewareResCaseTheme);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_BaseEN.CoursewareResCaseText, convCoursewareResCase_Base.CoursewareResCaseText);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_BaseEN.IdCoursewareResCaseType, convCoursewareResCase_Base.IdCoursewareResCaseType);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_BaseEN.CoursewareResCaseTypeName, convCoursewareResCase_Base.CoursewareResCaseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_BaseEN.CoursewareResCaseDate, convCoursewareResCase_Base.CoursewareResCaseDate);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_BaseEN.CoursewareResCaseTime, convCoursewareResCase_Base.CoursewareResCaseTime);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_BaseEN.CoursewareResCaseDateIn, convCoursewareResCase_Base.CoursewareResCaseDateIn);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_BaseEN.CoursewareResCaseTimeIn, convCoursewareResCase_Base.CoursewareResCaseTimeIn);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_BaseEN.OwnerId, convCoursewareResCase_Base.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_BaseEN.IdStudyLevel, convCoursewareResCase_Base.IdStudyLevel);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_BaseEN.StudyLevelName, convCoursewareResCase_Base.StudyLevelName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_BaseEN.IdTeachingPlan, convCoursewareResCase_Base.IdTeachingPlan);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_BaseEN.IdDiscipline, convCoursewareResCase_Base.IdDiscipline);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_BaseEN.DisciplineID, convCoursewareResCase_Base.DisciplineID);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_BaseEN.DisciplineName, convCoursewareResCase_Base.DisciplineName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_BaseEN.IdSenateGaugeVersion, convCoursewareResCase_Base.IdSenateGaugeVersion);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_BaseEN.senateGaugeVersionID, convCoursewareResCase_Base.senateGaugeVersionID);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_BaseEN.senateGaugeVersionName, convCoursewareResCase_Base.senateGaugeVersionName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_BaseEN.IdTeachSkill, convCoursewareResCase_Base.IdTeachSkill);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_BaseEN.TeachSkillID, convCoursewareResCase_Base.TeachSkillID);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_BaseEN.SkillTypeName, convCoursewareResCase_Base.SkillTypeName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_BaseEN.TeachSkillName, convCoursewareResCase_Base.TeachSkillName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_BaseEN.TeachSkillTheory, convCoursewareResCase_Base.TeachSkillTheory);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_BaseEN.TeachSkillOperMethod, convCoursewareResCase_Base.TeachSkillOperMethod);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_BaseEN.IdSkillType, convCoursewareResCase_Base.IdSkillType);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_BaseEN.SkillTypeID, convCoursewareResCase_Base.SkillTypeID);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_BaseEN.CaseLevelId, convCoursewareResCase_Base.CaseLevelId);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_BaseEN.CaseLevelName, convCoursewareResCase_Base.CaseLevelName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_BaseEN.DocFile, convCoursewareResCase_Base.DocFile);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_BaseEN.WordCreateDate, convCoursewareResCase_Base.WordCreateDate);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_BaseEN.IdXzCollege, convCoursewareResCase_Base.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_BaseEN.CollegeID, convCoursewareResCase_Base.CollegeID);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_BaseEN.CollegeName, convCoursewareResCase_Base.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_BaseEN.CollegeNameA, convCoursewareResCase_Base.CollegeNameA);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_BaseEN.IdXzMajor, convCoursewareResCase_Base.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_BaseEN.MajorID, convCoursewareResCase_Base.MajorID);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_BaseEN.MajorName, convCoursewareResCase_Base.MajorName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_BaseEN.CourseChapterId, convCoursewareResCase_Base.CourseChapterId);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_BaseEN.CourseChapterName, convCoursewareResCase_Base.CourseChapterName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_BaseEN.ParentNodeID, convCoursewareResCase_Base.ParentNodeID);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_BaseEN.ParentNodeName, convCoursewareResCase_Base.ParentNodeName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_BaseEN.RecommendedDegreeId, convCoursewareResCase_Base.RecommendedDegreeId);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_BaseEN.RecommendedDegreeName, convCoursewareResCase_Base.RecommendedDegreeName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_BaseEN.ftpFileType, convCoursewareResCase_Base.ftpFileType);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_BaseEN.CourseId, convCoursewareResCase_Base.CourseId);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_BaseEN.CourseCode, convCoursewareResCase_Base.CourseCode);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_BaseEN.CourseName, convCoursewareResCase_Base.CourseName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_BaseEN.VideoUrl, convCoursewareResCase_Base.VideoUrl);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_BaseEN.VideoPath, convCoursewareResCase_Base.VideoPath);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_BaseEN.ResErrMsg, convCoursewareResCase_Base.ResErrMsg);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_BaseEN.Memo, convCoursewareResCase_Base.Memo);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_BaseEN.OwnerName, convCoursewareResCase_Base.OwnerName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_BaseEN.OwnerNameWithId, convCoursewareResCase_Base.OwnerNameWithId);
//检查外键字段长度
 objvCoursewareResCase_BaseEN._IsCheckProperty = true;
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
 objSQL = clsvCoursewareResCase_BaseDA.GetSpecSQLObj();
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
 objSQL = clsvCoursewareResCase_BaseDA.GetSpecSQLObj();
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
 objSQL = clsvCoursewareResCase_BaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCoursewareResCase_BaseEN._CurrTabName);
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
 objSQL = clsvCoursewareResCase_BaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCoursewareResCase_BaseEN._CurrTabName, strCondition);
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
 objSQL = clsvCoursewareResCase_BaseDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}