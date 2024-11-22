
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCoursewareResCaseDA
 表名:vCoursewareResCase(01120419)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:46:14
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
 /// v课件资源案例(vCoursewareResCase)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvCoursewareResCaseDA : clsCommBase4DA
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
 return clsvCoursewareResCaseEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvCoursewareResCaseEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCoursewareResCaseEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvCoursewareResCaseEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvCoursewareResCaseEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:vCoursewareResCase中,检查关键字,长度不正确!(clsvCoursewareResCaseDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdCoursewareResCase)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vCoursewareResCase中,关键字不能为空 或 null!(clsvCoursewareResCaseDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdCoursewareResCase);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvCoursewareResCaseDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvCoursewareResCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCaseDA.GetSpecSQLObj();
strSQL = "Select * from vCoursewareResCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vCoursewareResCase(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvCoursewareResCaseDA: GetDataTable_vCoursewareResCase)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCaseDA.GetSpecSQLObj();
strSQL = "Select * from vCoursewareResCase where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvCoursewareResCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvCoursewareResCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCaseDA.GetSpecSQLObj();
strSQL = "Select * from vCoursewareResCase where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvCoursewareResCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvCoursewareResCaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCaseDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCoursewareResCase where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCoursewareResCase where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvCoursewareResCaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCaseDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vCoursewareResCase where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvCoursewareResCaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vCoursewareResCase.* from vCoursewareResCase Left Join {1} on {2} where {3} and vCoursewareResCase.IdCoursewareResCase not in (Select top {5} vCoursewareResCase.IdCoursewareResCase from vCoursewareResCase Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCoursewareResCase where {1} and IdCoursewareResCase not in (Select top {2} IdCoursewareResCase from vCoursewareResCase where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCoursewareResCase where {1} and IdCoursewareResCase not in (Select top {3} IdCoursewareResCase from vCoursewareResCase where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvCoursewareResCaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vCoursewareResCase.* from vCoursewareResCase Left Join {1} on {2} where {3} and vCoursewareResCase.IdCoursewareResCase not in (Select top {5} vCoursewareResCase.IdCoursewareResCase from vCoursewareResCase Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCoursewareResCase where {1} and IdCoursewareResCase not in (Select top {2} IdCoursewareResCase from vCoursewareResCase where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCoursewareResCase where {1} and IdCoursewareResCase not in (Select top {3} IdCoursewareResCase from vCoursewareResCase where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvCoursewareResCaseEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvCoursewareResCaseDA:GetObjLst)", objException.Message));
}
List<clsvCoursewareResCaseEN> arrObjLst = new List<clsvCoursewareResCaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCaseDA.GetSpecSQLObj();
strSQL = "Select * from vCoursewareResCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCoursewareResCaseEN objvCoursewareResCaseEN = new clsvCoursewareResCaseEN();
try
{
objvCoursewareResCaseEN.IdCoursewareResCase = objRow[convCoursewareResCase.IdCoursewareResCase].ToString().Trim(); //课件资源案例流水号
objvCoursewareResCaseEN.CoursewareResCaseID = objRow[convCoursewareResCase.CoursewareResCaseID].ToString().Trim(); //课件资源案例ID
objvCoursewareResCaseEN.CoursewareResCaseName = objRow[convCoursewareResCase.CoursewareResCaseName].ToString().Trim(); //课件资源案例名称
objvCoursewareResCaseEN.CoursewareResCaseTheme = objRow[convCoursewareResCase.CoursewareResCaseTheme] == DBNull.Value ? null : objRow[convCoursewareResCase.CoursewareResCaseTheme].ToString().Trim(); //课件资源案例主题词
objvCoursewareResCaseEN.CoursewareResCaseText = objRow[convCoursewareResCase.CoursewareResCaseText] == DBNull.Value ? null : objRow[convCoursewareResCase.CoursewareResCaseText].ToString().Trim(); //案例文本内容
objvCoursewareResCaseEN.IdCoursewareResCaseType = objRow[convCoursewareResCase.IdCoursewareResCaseType].ToString().Trim(); //课件资源类型流水号
objvCoursewareResCaseEN.CoursewareResCaseTypeName = objRow[convCoursewareResCase.CoursewareResCaseTypeName] == DBNull.Value ? null : objRow[convCoursewareResCase.CoursewareResCaseTypeName].ToString().Trim(); //课件资源案例类型名称
objvCoursewareResCaseEN.CoursewareResCaseDate = objRow[convCoursewareResCase.CoursewareResCaseDate] == DBNull.Value ? null : objRow[convCoursewareResCase.CoursewareResCaseDate].ToString().Trim(); //视频资源日期
objvCoursewareResCaseEN.CoursewareResCaseTime = objRow[convCoursewareResCase.CoursewareResCaseTime] == DBNull.Value ? null : objRow[convCoursewareResCase.CoursewareResCaseTime].ToString().Trim(); //视频资源时间
objvCoursewareResCaseEN.CoursewareResCaseDateIn = objRow[convCoursewareResCase.CoursewareResCaseDateIn] == DBNull.Value ? null : objRow[convCoursewareResCase.CoursewareResCaseDateIn].ToString().Trim(); //案例入库日期
objvCoursewareResCaseEN.CoursewareResCaseTimeIn = objRow[convCoursewareResCase.CoursewareResCaseTimeIn] == DBNull.Value ? null : objRow[convCoursewareResCase.CoursewareResCaseTimeIn].ToString().Trim(); //案例入库时间
objvCoursewareResCaseEN.OwnerId = objRow[convCoursewareResCase.OwnerId].ToString().Trim(); //拥有者Id
objvCoursewareResCaseEN.IdStudyLevel = objRow[convCoursewareResCase.IdStudyLevel] == DBNull.Value ? null : objRow[convCoursewareResCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCoursewareResCaseEN.StudyLevelName = objRow[convCoursewareResCase.StudyLevelName] == DBNull.Value ? null : objRow[convCoursewareResCase.StudyLevelName].ToString().Trim(); //学段名称
objvCoursewareResCaseEN.IdTeachingPlan = objRow[convCoursewareResCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convCoursewareResCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCoursewareResCaseEN.IdDiscipline = objRow[convCoursewareResCase.IdDiscipline].ToString().Trim(); //学科流水号
objvCoursewareResCaseEN.DisciplineID = objRow[convCoursewareResCase.DisciplineID] == DBNull.Value ? null : objRow[convCoursewareResCase.DisciplineID].ToString().Trim(); //学科ID
objvCoursewareResCaseEN.DisciplineName = objRow[convCoursewareResCase.DisciplineName] == DBNull.Value ? null : objRow[convCoursewareResCase.DisciplineName].ToString().Trim(); //学科名称
objvCoursewareResCaseEN.IdSenateGaugeVersion = objRow[convCoursewareResCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convCoursewareResCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCoursewareResCaseEN.senateGaugeVersionID = objRow[convCoursewareResCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCoursewareResCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCoursewareResCaseEN.senateGaugeVersionName = objRow[convCoursewareResCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCoursewareResCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCoursewareResCaseEN.senateGaugeVersionTtlScore = objRow[convCoursewareResCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convCoursewareResCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCoursewareResCaseEN.VersionNo = objRow[convCoursewareResCase.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase.VersionNo].ToString().Trim()); //版本号
objvCoursewareResCaseEN.IdTeachSkill = objRow[convCoursewareResCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCoursewareResCaseEN.TeachSkillID = objRow[convCoursewareResCase.TeachSkillID] == DBNull.Value ? null : objRow[convCoursewareResCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvCoursewareResCaseEN.SkillTypeName = objRow[convCoursewareResCase.SkillTypeName] == DBNull.Value ? null : objRow[convCoursewareResCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvCoursewareResCaseEN.TeachSkillName = objRow[convCoursewareResCase.TeachSkillName] == DBNull.Value ? null : objRow[convCoursewareResCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvCoursewareResCaseEN.TeachSkillTheory = objRow[convCoursewareResCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convCoursewareResCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCoursewareResCaseEN.TeachSkillOperMethod = objRow[convCoursewareResCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCoursewareResCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCoursewareResCaseEN.IdSkillType = objRow[convCoursewareResCase.IdSkillType] == DBNull.Value ? null : objRow[convCoursewareResCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvCoursewareResCaseEN.SkillTypeID = objRow[convCoursewareResCase.SkillTypeID] == DBNull.Value ? null : objRow[convCoursewareResCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvCoursewareResCaseEN.CaseLevelId = objRow[convCoursewareResCase.CaseLevelId] == DBNull.Value ? null : objRow[convCoursewareResCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvCoursewareResCaseEN.CaseLevelName = objRow[convCoursewareResCase.CaseLevelName] == DBNull.Value ? null : objRow[convCoursewareResCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvCoursewareResCaseEN.DocFile = objRow[convCoursewareResCase.DocFile] == DBNull.Value ? null : objRow[convCoursewareResCase.DocFile].ToString().Trim(); //生成的Word文件名
objvCoursewareResCaseEN.IsNeedGeneWord = TransNullToBool(objRow[convCoursewareResCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvCoursewareResCaseEN.WordCreateDate = objRow[convCoursewareResCase.WordCreateDate] == DBNull.Value ? null : objRow[convCoursewareResCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvCoursewareResCaseEN.IsVisible = TransNullToBool(objRow[convCoursewareResCase.IsVisible].ToString().Trim()); //是否显示
objvCoursewareResCaseEN.IsDualVideo = TransNullToBool(objRow[convCoursewareResCase.IsDualVideo].ToString().Trim()); //是否双视频
objvCoursewareResCaseEN.IdXzCollege = objRow[convCoursewareResCase.IdXzCollege].ToString().Trim(); //学院流水号
objvCoursewareResCaseEN.CollegeID = objRow[convCoursewareResCase.CollegeID] == DBNull.Value ? null : objRow[convCoursewareResCase.CollegeID].ToString().Trim(); //学院ID
objvCoursewareResCaseEN.CollegeName = objRow[convCoursewareResCase.CollegeName] == DBNull.Value ? null : objRow[convCoursewareResCase.CollegeName].ToString().Trim(); //学院名称
objvCoursewareResCaseEN.CollegeNameA = objRow[convCoursewareResCase.CollegeNameA] == DBNull.Value ? null : objRow[convCoursewareResCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvCoursewareResCaseEN.IdXzMajor = objRow[convCoursewareResCase.IdXzMajor].ToString().Trim(); //专业流水号
objvCoursewareResCaseEN.MajorID = objRow[convCoursewareResCase.MajorID] == DBNull.Value ? null : objRow[convCoursewareResCase.MajorID].ToString().Trim(); //专业ID
objvCoursewareResCaseEN.MajorName = objRow[convCoursewareResCase.MajorName] == DBNull.Value ? null : objRow[convCoursewareResCase.MajorName].ToString().Trim(); //专业名称
objvCoursewareResCaseEN.CourseChapterId = objRow[convCoursewareResCase.CourseChapterId] == DBNull.Value ? null : objRow[convCoursewareResCase.CourseChapterId].ToString().Trim(); //课程章节ID
objvCoursewareResCaseEN.CourseChapterName = objRow[convCoursewareResCase.CourseChapterName] == DBNull.Value ? null : objRow[convCoursewareResCase.CourseChapterName].ToString().Trim(); //课程章节名称
objvCoursewareResCaseEN.ParentNodeID = objRow[convCoursewareResCase.ParentNodeID] == DBNull.Value ? null : objRow[convCoursewareResCase.ParentNodeID].ToString().Trim(); //父节点编号
objvCoursewareResCaseEN.ParentNodeName = objRow[convCoursewareResCase.ParentNodeName] == DBNull.Value ? null : objRow[convCoursewareResCase.ParentNodeName].ToString().Trim(); //父节点名称
objvCoursewareResCaseEN.ViewCount = objRow[convCoursewareResCase.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase.ViewCount].ToString().Trim()); //浏览量
objvCoursewareResCaseEN.IsShow = TransNullToBool(objRow[convCoursewareResCase.IsShow].ToString().Trim()); //是否启用
objvCoursewareResCaseEN.DownloadNumber = objRow[convCoursewareResCase.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase.DownloadNumber].ToString().Trim()); //下载数目
objvCoursewareResCaseEN.FileIntegration = objRow[convCoursewareResCase.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase.FileIntegration].ToString().Trim()); //文件积分
objvCoursewareResCaseEN.LikeCount = objRow[convCoursewareResCase.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCoursewareResCase.LikeCount].ToString().Trim()); //资源喜欢数量
objvCoursewareResCaseEN.CollectionCount = objRow[convCoursewareResCase.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCoursewareResCase.CollectionCount].ToString().Trim()); //收藏数量
objvCoursewareResCaseEN.RecommendedDegreeId = objRow[convCoursewareResCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCoursewareResCaseEN.RecommendedDegreeName = objRow[convCoursewareResCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCoursewareResCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCoursewareResCaseEN.ftpFileType = objRow[convCoursewareResCase.ftpFileType] == DBNull.Value ? null : objRow[convCoursewareResCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvCoursewareResCaseEN.CourseId = objRow[convCoursewareResCase.CourseId].ToString().Trim(); //课程Id
objvCoursewareResCaseEN.CourseCode = objRow[convCoursewareResCase.CourseCode] == DBNull.Value ? null : objRow[convCoursewareResCase.CourseCode].ToString().Trim(); //课程代码
objvCoursewareResCaseEN.CourseName = objRow[convCoursewareResCase.CourseName] == DBNull.Value ? null : objRow[convCoursewareResCase.CourseName].ToString().Trim(); //课程名称
objvCoursewareResCaseEN.VideoUrl = objRow[convCoursewareResCase.VideoUrl] == DBNull.Value ? null : objRow[convCoursewareResCase.VideoUrl].ToString().Trim(); //视频Url
objvCoursewareResCaseEN.VideoPath = objRow[convCoursewareResCase.VideoPath] == DBNull.Value ? null : objRow[convCoursewareResCase.VideoPath].ToString().Trim(); //视频目录
objvCoursewareResCaseEN.ResErrMsg = objRow[convCoursewareResCase.ResErrMsg] == DBNull.Value ? null : objRow[convCoursewareResCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvCoursewareResCaseEN.UpdDate = objRow[convCoursewareResCase.UpdDate] == DBNull.Value ? null : objRow[convCoursewareResCase.UpdDate].ToString().Trim(); //修改日期
objvCoursewareResCaseEN.UpdUserId = objRow[convCoursewareResCase.UpdUserId] == DBNull.Value ? null : objRow[convCoursewareResCase.UpdUserId].ToString().Trim(); //修改用户Id
objvCoursewareResCaseEN.Memo = objRow[convCoursewareResCase.Memo] == DBNull.Value ? null : objRow[convCoursewareResCase.Memo].ToString().Trim(); //备注
objvCoursewareResCaseEN.OwnerNameWithId = objRow[convCoursewareResCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convCoursewareResCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCoursewareResCaseEN.OwnerName = objRow[convCoursewareResCase.OwnerName] == DBNull.Value ? null : objRow[convCoursewareResCase.OwnerName].ToString().Trim(); //拥有者姓名
objvCoursewareResCaseEN.BrowseCount4Case = objRow[convCoursewareResCase.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCoursewareResCaseEN.IsHaveVideo = objRow[convCoursewareResCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCoursewareResCaseDA: GetObjLst)", objException.Message));
}
objvCoursewareResCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCoursewareResCaseEN);
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
public List<clsvCoursewareResCaseEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvCoursewareResCaseDA:GetObjLstByTabName)", objException.Message));
}
List<clsvCoursewareResCaseEN> arrObjLst = new List<clsvCoursewareResCaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCaseDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCoursewareResCaseEN objvCoursewareResCaseEN = new clsvCoursewareResCaseEN();
try
{
objvCoursewareResCaseEN.IdCoursewareResCase = objRow[convCoursewareResCase.IdCoursewareResCase].ToString().Trim(); //课件资源案例流水号
objvCoursewareResCaseEN.CoursewareResCaseID = objRow[convCoursewareResCase.CoursewareResCaseID].ToString().Trim(); //课件资源案例ID
objvCoursewareResCaseEN.CoursewareResCaseName = objRow[convCoursewareResCase.CoursewareResCaseName].ToString().Trim(); //课件资源案例名称
objvCoursewareResCaseEN.CoursewareResCaseTheme = objRow[convCoursewareResCase.CoursewareResCaseTheme] == DBNull.Value ? null : objRow[convCoursewareResCase.CoursewareResCaseTheme].ToString().Trim(); //课件资源案例主题词
objvCoursewareResCaseEN.CoursewareResCaseText = objRow[convCoursewareResCase.CoursewareResCaseText] == DBNull.Value ? null : objRow[convCoursewareResCase.CoursewareResCaseText].ToString().Trim(); //案例文本内容
objvCoursewareResCaseEN.IdCoursewareResCaseType = objRow[convCoursewareResCase.IdCoursewareResCaseType].ToString().Trim(); //课件资源类型流水号
objvCoursewareResCaseEN.CoursewareResCaseTypeName = objRow[convCoursewareResCase.CoursewareResCaseTypeName] == DBNull.Value ? null : objRow[convCoursewareResCase.CoursewareResCaseTypeName].ToString().Trim(); //课件资源案例类型名称
objvCoursewareResCaseEN.CoursewareResCaseDate = objRow[convCoursewareResCase.CoursewareResCaseDate] == DBNull.Value ? null : objRow[convCoursewareResCase.CoursewareResCaseDate].ToString().Trim(); //视频资源日期
objvCoursewareResCaseEN.CoursewareResCaseTime = objRow[convCoursewareResCase.CoursewareResCaseTime] == DBNull.Value ? null : objRow[convCoursewareResCase.CoursewareResCaseTime].ToString().Trim(); //视频资源时间
objvCoursewareResCaseEN.CoursewareResCaseDateIn = objRow[convCoursewareResCase.CoursewareResCaseDateIn] == DBNull.Value ? null : objRow[convCoursewareResCase.CoursewareResCaseDateIn].ToString().Trim(); //案例入库日期
objvCoursewareResCaseEN.CoursewareResCaseTimeIn = objRow[convCoursewareResCase.CoursewareResCaseTimeIn] == DBNull.Value ? null : objRow[convCoursewareResCase.CoursewareResCaseTimeIn].ToString().Trim(); //案例入库时间
objvCoursewareResCaseEN.OwnerId = objRow[convCoursewareResCase.OwnerId].ToString().Trim(); //拥有者Id
objvCoursewareResCaseEN.IdStudyLevel = objRow[convCoursewareResCase.IdStudyLevel] == DBNull.Value ? null : objRow[convCoursewareResCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCoursewareResCaseEN.StudyLevelName = objRow[convCoursewareResCase.StudyLevelName] == DBNull.Value ? null : objRow[convCoursewareResCase.StudyLevelName].ToString().Trim(); //学段名称
objvCoursewareResCaseEN.IdTeachingPlan = objRow[convCoursewareResCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convCoursewareResCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCoursewareResCaseEN.IdDiscipline = objRow[convCoursewareResCase.IdDiscipline].ToString().Trim(); //学科流水号
objvCoursewareResCaseEN.DisciplineID = objRow[convCoursewareResCase.DisciplineID] == DBNull.Value ? null : objRow[convCoursewareResCase.DisciplineID].ToString().Trim(); //学科ID
objvCoursewareResCaseEN.DisciplineName = objRow[convCoursewareResCase.DisciplineName] == DBNull.Value ? null : objRow[convCoursewareResCase.DisciplineName].ToString().Trim(); //学科名称
objvCoursewareResCaseEN.IdSenateGaugeVersion = objRow[convCoursewareResCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convCoursewareResCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCoursewareResCaseEN.senateGaugeVersionID = objRow[convCoursewareResCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCoursewareResCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCoursewareResCaseEN.senateGaugeVersionName = objRow[convCoursewareResCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCoursewareResCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCoursewareResCaseEN.senateGaugeVersionTtlScore = objRow[convCoursewareResCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convCoursewareResCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCoursewareResCaseEN.VersionNo = objRow[convCoursewareResCase.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase.VersionNo].ToString().Trim()); //版本号
objvCoursewareResCaseEN.IdTeachSkill = objRow[convCoursewareResCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCoursewareResCaseEN.TeachSkillID = objRow[convCoursewareResCase.TeachSkillID] == DBNull.Value ? null : objRow[convCoursewareResCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvCoursewareResCaseEN.SkillTypeName = objRow[convCoursewareResCase.SkillTypeName] == DBNull.Value ? null : objRow[convCoursewareResCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvCoursewareResCaseEN.TeachSkillName = objRow[convCoursewareResCase.TeachSkillName] == DBNull.Value ? null : objRow[convCoursewareResCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvCoursewareResCaseEN.TeachSkillTheory = objRow[convCoursewareResCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convCoursewareResCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCoursewareResCaseEN.TeachSkillOperMethod = objRow[convCoursewareResCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCoursewareResCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCoursewareResCaseEN.IdSkillType = objRow[convCoursewareResCase.IdSkillType] == DBNull.Value ? null : objRow[convCoursewareResCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvCoursewareResCaseEN.SkillTypeID = objRow[convCoursewareResCase.SkillTypeID] == DBNull.Value ? null : objRow[convCoursewareResCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvCoursewareResCaseEN.CaseLevelId = objRow[convCoursewareResCase.CaseLevelId] == DBNull.Value ? null : objRow[convCoursewareResCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvCoursewareResCaseEN.CaseLevelName = objRow[convCoursewareResCase.CaseLevelName] == DBNull.Value ? null : objRow[convCoursewareResCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvCoursewareResCaseEN.DocFile = objRow[convCoursewareResCase.DocFile] == DBNull.Value ? null : objRow[convCoursewareResCase.DocFile].ToString().Trim(); //生成的Word文件名
objvCoursewareResCaseEN.IsNeedGeneWord = TransNullToBool(objRow[convCoursewareResCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvCoursewareResCaseEN.WordCreateDate = objRow[convCoursewareResCase.WordCreateDate] == DBNull.Value ? null : objRow[convCoursewareResCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvCoursewareResCaseEN.IsVisible = TransNullToBool(objRow[convCoursewareResCase.IsVisible].ToString().Trim()); //是否显示
objvCoursewareResCaseEN.IsDualVideo = TransNullToBool(objRow[convCoursewareResCase.IsDualVideo].ToString().Trim()); //是否双视频
objvCoursewareResCaseEN.IdXzCollege = objRow[convCoursewareResCase.IdXzCollege].ToString().Trim(); //学院流水号
objvCoursewareResCaseEN.CollegeID = objRow[convCoursewareResCase.CollegeID] == DBNull.Value ? null : objRow[convCoursewareResCase.CollegeID].ToString().Trim(); //学院ID
objvCoursewareResCaseEN.CollegeName = objRow[convCoursewareResCase.CollegeName] == DBNull.Value ? null : objRow[convCoursewareResCase.CollegeName].ToString().Trim(); //学院名称
objvCoursewareResCaseEN.CollegeNameA = objRow[convCoursewareResCase.CollegeNameA] == DBNull.Value ? null : objRow[convCoursewareResCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvCoursewareResCaseEN.IdXzMajor = objRow[convCoursewareResCase.IdXzMajor].ToString().Trim(); //专业流水号
objvCoursewareResCaseEN.MajorID = objRow[convCoursewareResCase.MajorID] == DBNull.Value ? null : objRow[convCoursewareResCase.MajorID].ToString().Trim(); //专业ID
objvCoursewareResCaseEN.MajorName = objRow[convCoursewareResCase.MajorName] == DBNull.Value ? null : objRow[convCoursewareResCase.MajorName].ToString().Trim(); //专业名称
objvCoursewareResCaseEN.CourseChapterId = objRow[convCoursewareResCase.CourseChapterId] == DBNull.Value ? null : objRow[convCoursewareResCase.CourseChapterId].ToString().Trim(); //课程章节ID
objvCoursewareResCaseEN.CourseChapterName = objRow[convCoursewareResCase.CourseChapterName] == DBNull.Value ? null : objRow[convCoursewareResCase.CourseChapterName].ToString().Trim(); //课程章节名称
objvCoursewareResCaseEN.ParentNodeID = objRow[convCoursewareResCase.ParentNodeID] == DBNull.Value ? null : objRow[convCoursewareResCase.ParentNodeID].ToString().Trim(); //父节点编号
objvCoursewareResCaseEN.ParentNodeName = objRow[convCoursewareResCase.ParentNodeName] == DBNull.Value ? null : objRow[convCoursewareResCase.ParentNodeName].ToString().Trim(); //父节点名称
objvCoursewareResCaseEN.ViewCount = objRow[convCoursewareResCase.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase.ViewCount].ToString().Trim()); //浏览量
objvCoursewareResCaseEN.IsShow = TransNullToBool(objRow[convCoursewareResCase.IsShow].ToString().Trim()); //是否启用
objvCoursewareResCaseEN.DownloadNumber = objRow[convCoursewareResCase.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase.DownloadNumber].ToString().Trim()); //下载数目
objvCoursewareResCaseEN.FileIntegration = objRow[convCoursewareResCase.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase.FileIntegration].ToString().Trim()); //文件积分
objvCoursewareResCaseEN.LikeCount = objRow[convCoursewareResCase.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCoursewareResCase.LikeCount].ToString().Trim()); //资源喜欢数量
objvCoursewareResCaseEN.CollectionCount = objRow[convCoursewareResCase.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCoursewareResCase.CollectionCount].ToString().Trim()); //收藏数量
objvCoursewareResCaseEN.RecommendedDegreeId = objRow[convCoursewareResCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCoursewareResCaseEN.RecommendedDegreeName = objRow[convCoursewareResCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCoursewareResCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCoursewareResCaseEN.ftpFileType = objRow[convCoursewareResCase.ftpFileType] == DBNull.Value ? null : objRow[convCoursewareResCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvCoursewareResCaseEN.CourseId = objRow[convCoursewareResCase.CourseId].ToString().Trim(); //课程Id
objvCoursewareResCaseEN.CourseCode = objRow[convCoursewareResCase.CourseCode] == DBNull.Value ? null : objRow[convCoursewareResCase.CourseCode].ToString().Trim(); //课程代码
objvCoursewareResCaseEN.CourseName = objRow[convCoursewareResCase.CourseName] == DBNull.Value ? null : objRow[convCoursewareResCase.CourseName].ToString().Trim(); //课程名称
objvCoursewareResCaseEN.VideoUrl = objRow[convCoursewareResCase.VideoUrl] == DBNull.Value ? null : objRow[convCoursewareResCase.VideoUrl].ToString().Trim(); //视频Url
objvCoursewareResCaseEN.VideoPath = objRow[convCoursewareResCase.VideoPath] == DBNull.Value ? null : objRow[convCoursewareResCase.VideoPath].ToString().Trim(); //视频目录
objvCoursewareResCaseEN.ResErrMsg = objRow[convCoursewareResCase.ResErrMsg] == DBNull.Value ? null : objRow[convCoursewareResCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvCoursewareResCaseEN.UpdDate = objRow[convCoursewareResCase.UpdDate] == DBNull.Value ? null : objRow[convCoursewareResCase.UpdDate].ToString().Trim(); //修改日期
objvCoursewareResCaseEN.UpdUserId = objRow[convCoursewareResCase.UpdUserId] == DBNull.Value ? null : objRow[convCoursewareResCase.UpdUserId].ToString().Trim(); //修改用户Id
objvCoursewareResCaseEN.Memo = objRow[convCoursewareResCase.Memo] == DBNull.Value ? null : objRow[convCoursewareResCase.Memo].ToString().Trim(); //备注
objvCoursewareResCaseEN.OwnerNameWithId = objRow[convCoursewareResCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convCoursewareResCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCoursewareResCaseEN.OwnerName = objRow[convCoursewareResCase.OwnerName] == DBNull.Value ? null : objRow[convCoursewareResCase.OwnerName].ToString().Trim(); //拥有者姓名
objvCoursewareResCaseEN.BrowseCount4Case = objRow[convCoursewareResCase.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCoursewareResCaseEN.IsHaveVideo = objRow[convCoursewareResCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCoursewareResCaseDA: GetObjLst)", objException.Message));
}
objvCoursewareResCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCoursewareResCaseEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvCoursewareResCaseEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvCoursewareResCase(ref clsvCoursewareResCaseEN objvCoursewareResCaseEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCaseDA.GetSpecSQLObj();
strSQL = "Select * from vCoursewareResCase where IdCoursewareResCase = " + "'"+ objvCoursewareResCaseEN.IdCoursewareResCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvCoursewareResCaseEN.IdCoursewareResCase = objDT.Rows[0][convCoursewareResCase.IdCoursewareResCase].ToString().Trim(); //课件资源案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareResCaseEN.CoursewareResCaseID = objDT.Rows[0][convCoursewareResCase.CoursewareResCaseID].ToString().Trim(); //课件资源案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareResCaseEN.CoursewareResCaseName = objDT.Rows[0][convCoursewareResCase.CoursewareResCaseName].ToString().Trim(); //课件资源案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCoursewareResCaseEN.CoursewareResCaseTheme = objDT.Rows[0][convCoursewareResCase.CoursewareResCaseTheme].ToString().Trim(); //课件资源案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareResCaseEN.CoursewareResCaseText = objDT.Rows[0][convCoursewareResCase.CoursewareResCaseText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objvCoursewareResCaseEN.IdCoursewareResCaseType = objDT.Rows[0][convCoursewareResCase.IdCoursewareResCaseType].ToString().Trim(); //课件资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareResCaseEN.CoursewareResCaseTypeName = objDT.Rows[0][convCoursewareResCase.CoursewareResCaseTypeName].ToString().Trim(); //课件资源案例类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCoursewareResCaseEN.CoursewareResCaseDate = objDT.Rows[0][convCoursewareResCase.CoursewareResCaseDate].ToString().Trim(); //视频资源日期(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareResCaseEN.CoursewareResCaseTime = objDT.Rows[0][convCoursewareResCase.CoursewareResCaseTime].ToString().Trim(); //视频资源时间(字段类型:char,字段长度:6,是否可空:True)
 objvCoursewareResCaseEN.CoursewareResCaseDateIn = objDT.Rows[0][convCoursewareResCase.CoursewareResCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareResCaseEN.CoursewareResCaseTimeIn = objDT.Rows[0][convCoursewareResCase.CoursewareResCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvCoursewareResCaseEN.OwnerId = objDT.Rows[0][convCoursewareResCase.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvCoursewareResCaseEN.IdStudyLevel = objDT.Rows[0][convCoursewareResCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvCoursewareResCaseEN.StudyLevelName = objDT.Rows[0][convCoursewareResCase.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareResCaseEN.IdTeachingPlan = objDT.Rows[0][convCoursewareResCase.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareResCaseEN.IdDiscipline = objDT.Rows[0][convCoursewareResCase.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareResCaseEN.DisciplineID = objDT.Rows[0][convCoursewareResCase.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareResCaseEN.DisciplineName = objDT.Rows[0][convCoursewareResCase.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareResCaseEN.IdSenateGaugeVersion = objDT.Rows[0][convCoursewareResCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareResCaseEN.senateGaugeVersionID = objDT.Rows[0][convCoursewareResCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareResCaseEN.senateGaugeVersionName = objDT.Rows[0][convCoursewareResCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareResCaseEN.senateGaugeVersionTtlScore = TransNullToFloat(objDT.Rows[0][convCoursewareResCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvCoursewareResCaseEN.VersionNo = TransNullToInt(objDT.Rows[0][convCoursewareResCase.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvCoursewareResCaseEN.IdTeachSkill = objDT.Rows[0][convCoursewareResCase.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareResCaseEN.TeachSkillID = objDT.Rows[0][convCoursewareResCase.TeachSkillID].ToString().Trim(); //教学技能ID(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareResCaseEN.SkillTypeName = objDT.Rows[0][convCoursewareResCase.SkillTypeName].ToString().Trim(); //技能类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareResCaseEN.TeachSkillName = objDT.Rows[0][convCoursewareResCase.TeachSkillName].ToString().Trim(); //教学技能名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareResCaseEN.TeachSkillTheory = objDT.Rows[0][convCoursewareResCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvCoursewareResCaseEN.TeachSkillOperMethod = objDT.Rows[0][convCoursewareResCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法(字段类型:varchar,字段长度:2000,是否可空:True)
 objvCoursewareResCaseEN.IdSkillType = objDT.Rows[0][convCoursewareResCase.IdSkillType].ToString().Trim(); //技能类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareResCaseEN.SkillTypeID = objDT.Rows[0][convCoursewareResCase.SkillTypeID].ToString().Trim(); //技能类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareResCaseEN.CaseLevelId = objDT.Rows[0][convCoursewareResCase.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvCoursewareResCaseEN.CaseLevelName = objDT.Rows[0][convCoursewareResCase.CaseLevelName].ToString().Trim(); //案例等级名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvCoursewareResCaseEN.DocFile = objDT.Rows[0][convCoursewareResCase.DocFile].ToString().Trim(); //生成的Word文件名(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareResCaseEN.IsNeedGeneWord = TransNullToBool(objDT.Rows[0][convCoursewareResCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word(字段类型:bit,字段长度:1,是否可空:True)
 objvCoursewareResCaseEN.WordCreateDate = objDT.Rows[0][convCoursewareResCase.WordCreateDate].ToString().Trim(); //Word生成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objvCoursewareResCaseEN.IsVisible = TransNullToBool(objDT.Rows[0][convCoursewareResCase.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvCoursewareResCaseEN.IsDualVideo = TransNullToBool(objDT.Rows[0][convCoursewareResCase.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvCoursewareResCaseEN.IdXzCollege = objDT.Rows[0][convCoursewareResCase.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvCoursewareResCaseEN.CollegeID = objDT.Rows[0][convCoursewareResCase.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvCoursewareResCaseEN.CollegeName = objDT.Rows[0][convCoursewareResCase.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCoursewareResCaseEN.CollegeNameA = objDT.Rows[0][convCoursewareResCase.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvCoursewareResCaseEN.IdXzMajor = objDT.Rows[0][convCoursewareResCase.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareResCaseEN.MajorID = objDT.Rows[0][convCoursewareResCase.MajorID].ToString().Trim(); //专业ID(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareResCaseEN.MajorName = objDT.Rows[0][convCoursewareResCase.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCoursewareResCaseEN.CourseChapterId = objDT.Rows[0][convCoursewareResCase.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareResCaseEN.CourseChapterName = objDT.Rows[0][convCoursewareResCase.CourseChapterName].ToString().Trim(); //课程章节名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCoursewareResCaseEN.ParentNodeID = objDT.Rows[0][convCoursewareResCase.ParentNodeID].ToString().Trim(); //父节点编号(字段类型:varchar,字段长度:8,是否可空:True)
 objvCoursewareResCaseEN.ParentNodeName = objDT.Rows[0][convCoursewareResCase.ParentNodeName].ToString().Trim(); //父节点名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvCoursewareResCaseEN.ViewCount = TransNullToInt(objDT.Rows[0][convCoursewareResCase.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvCoursewareResCaseEN.IsShow = TransNullToBool(objDT.Rows[0][convCoursewareResCase.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objvCoursewareResCaseEN.DownloadNumber = TransNullToInt(objDT.Rows[0][convCoursewareResCase.DownloadNumber].ToString().Trim()); //下载数目(字段类型:int,字段长度:4,是否可空:True)
 objvCoursewareResCaseEN.FileIntegration = TransNullToInt(objDT.Rows[0][convCoursewareResCase.FileIntegration].ToString().Trim()); //文件积分(字段类型:int,字段长度:4,是否可空:True)
 objvCoursewareResCaseEN.LikeCount = TransNullToInt(objDT.Rows[0][convCoursewareResCase.LikeCount].ToString().Trim()); //资源喜欢数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvCoursewareResCaseEN.CollectionCount = TransNullToInt(objDT.Rows[0][convCoursewareResCase.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvCoursewareResCaseEN.RecommendedDegreeId = objDT.Rows[0][convCoursewareResCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvCoursewareResCaseEN.RecommendedDegreeName = objDT.Rows[0][convCoursewareResCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCoursewareResCaseEN.ftpFileType = objDT.Rows[0][convCoursewareResCase.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvCoursewareResCaseEN.CourseId = objDT.Rows[0][convCoursewareResCase.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareResCaseEN.CourseCode = objDT.Rows[0][convCoursewareResCase.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvCoursewareResCaseEN.CourseName = objDT.Rows[0][convCoursewareResCase.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvCoursewareResCaseEN.VideoUrl = objDT.Rows[0][convCoursewareResCase.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCoursewareResCaseEN.VideoPath = objDT.Rows[0][convCoursewareResCase.VideoPath].ToString().Trim(); //视频目录(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCoursewareResCaseEN.ResErrMsg = objDT.Rows[0][convCoursewareResCase.ResErrMsg].ToString().Trim(); //资源错误信息(字段类型:varchar,字段长度:30,是否可空:True)
 objvCoursewareResCaseEN.UpdDate = objDT.Rows[0][convCoursewareResCase.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvCoursewareResCaseEN.UpdUserId = objDT.Rows[0][convCoursewareResCase.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvCoursewareResCaseEN.Memo = objDT.Rows[0][convCoursewareResCase.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCoursewareResCaseEN.OwnerNameWithId = objDT.Rows[0][convCoursewareResCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
 objvCoursewareResCaseEN.OwnerName = objDT.Rows[0][convCoursewareResCase.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvCoursewareResCaseEN.BrowseCount4Case = TransNullToInt(objDT.Rows[0][convCoursewareResCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvCoursewareResCaseEN.IsHaveVideo = objDT.Rows[0][convCoursewareResCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo(字段类型:varchar,字段长度:6,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvCoursewareResCaseDA: GetvCoursewareResCase)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdCoursewareResCase">表关键字</param>
 /// <returns>表对象</returns>
public clsvCoursewareResCaseEN GetObjByIdCoursewareResCase(string strIdCoursewareResCase)
{
CheckPrimaryKey(strIdCoursewareResCase);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCaseDA.GetSpecSQLObj();
strSQL = "Select * from vCoursewareResCase where IdCoursewareResCase = " + "'"+ strIdCoursewareResCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvCoursewareResCaseEN objvCoursewareResCaseEN = new clsvCoursewareResCaseEN();
try
{
 objvCoursewareResCaseEN.IdCoursewareResCase = objRow[convCoursewareResCase.IdCoursewareResCase].ToString().Trim(); //课件资源案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareResCaseEN.CoursewareResCaseID = objRow[convCoursewareResCase.CoursewareResCaseID].ToString().Trim(); //课件资源案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareResCaseEN.CoursewareResCaseName = objRow[convCoursewareResCase.CoursewareResCaseName].ToString().Trim(); //课件资源案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCoursewareResCaseEN.CoursewareResCaseTheme = objRow[convCoursewareResCase.CoursewareResCaseTheme] == DBNull.Value ? null : objRow[convCoursewareResCase.CoursewareResCaseTheme].ToString().Trim(); //课件资源案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareResCaseEN.CoursewareResCaseText = objRow[convCoursewareResCase.CoursewareResCaseText] == DBNull.Value ? null : objRow[convCoursewareResCase.CoursewareResCaseText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objvCoursewareResCaseEN.IdCoursewareResCaseType = objRow[convCoursewareResCase.IdCoursewareResCaseType].ToString().Trim(); //课件资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareResCaseEN.CoursewareResCaseTypeName = objRow[convCoursewareResCase.CoursewareResCaseTypeName] == DBNull.Value ? null : objRow[convCoursewareResCase.CoursewareResCaseTypeName].ToString().Trim(); //课件资源案例类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCoursewareResCaseEN.CoursewareResCaseDate = objRow[convCoursewareResCase.CoursewareResCaseDate] == DBNull.Value ? null : objRow[convCoursewareResCase.CoursewareResCaseDate].ToString().Trim(); //视频资源日期(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareResCaseEN.CoursewareResCaseTime = objRow[convCoursewareResCase.CoursewareResCaseTime] == DBNull.Value ? null : objRow[convCoursewareResCase.CoursewareResCaseTime].ToString().Trim(); //视频资源时间(字段类型:char,字段长度:6,是否可空:True)
 objvCoursewareResCaseEN.CoursewareResCaseDateIn = objRow[convCoursewareResCase.CoursewareResCaseDateIn] == DBNull.Value ? null : objRow[convCoursewareResCase.CoursewareResCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareResCaseEN.CoursewareResCaseTimeIn = objRow[convCoursewareResCase.CoursewareResCaseTimeIn] == DBNull.Value ? null : objRow[convCoursewareResCase.CoursewareResCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvCoursewareResCaseEN.OwnerId = objRow[convCoursewareResCase.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvCoursewareResCaseEN.IdStudyLevel = objRow[convCoursewareResCase.IdStudyLevel] == DBNull.Value ? null : objRow[convCoursewareResCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvCoursewareResCaseEN.StudyLevelName = objRow[convCoursewareResCase.StudyLevelName] == DBNull.Value ? null : objRow[convCoursewareResCase.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareResCaseEN.IdTeachingPlan = objRow[convCoursewareResCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convCoursewareResCase.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareResCaseEN.IdDiscipline = objRow[convCoursewareResCase.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareResCaseEN.DisciplineID = objRow[convCoursewareResCase.DisciplineID] == DBNull.Value ? null : objRow[convCoursewareResCase.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareResCaseEN.DisciplineName = objRow[convCoursewareResCase.DisciplineName] == DBNull.Value ? null : objRow[convCoursewareResCase.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareResCaseEN.IdSenateGaugeVersion = objRow[convCoursewareResCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convCoursewareResCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareResCaseEN.senateGaugeVersionID = objRow[convCoursewareResCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCoursewareResCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareResCaseEN.senateGaugeVersionName = objRow[convCoursewareResCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCoursewareResCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareResCaseEN.senateGaugeVersionTtlScore = objRow[convCoursewareResCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convCoursewareResCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvCoursewareResCaseEN.VersionNo = objRow[convCoursewareResCase.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCoursewareResCase.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvCoursewareResCaseEN.IdTeachSkill = objRow[convCoursewareResCase.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareResCaseEN.TeachSkillID = objRow[convCoursewareResCase.TeachSkillID] == DBNull.Value ? null : objRow[convCoursewareResCase.TeachSkillID].ToString().Trim(); //教学技能ID(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareResCaseEN.SkillTypeName = objRow[convCoursewareResCase.SkillTypeName] == DBNull.Value ? null : objRow[convCoursewareResCase.SkillTypeName].ToString().Trim(); //技能类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareResCaseEN.TeachSkillName = objRow[convCoursewareResCase.TeachSkillName] == DBNull.Value ? null : objRow[convCoursewareResCase.TeachSkillName].ToString().Trim(); //教学技能名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareResCaseEN.TeachSkillTheory = objRow[convCoursewareResCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convCoursewareResCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvCoursewareResCaseEN.TeachSkillOperMethod = objRow[convCoursewareResCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCoursewareResCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法(字段类型:varchar,字段长度:2000,是否可空:True)
 objvCoursewareResCaseEN.IdSkillType = objRow[convCoursewareResCase.IdSkillType] == DBNull.Value ? null : objRow[convCoursewareResCase.IdSkillType].ToString().Trim(); //技能类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareResCaseEN.SkillTypeID = objRow[convCoursewareResCase.SkillTypeID] == DBNull.Value ? null : objRow[convCoursewareResCase.SkillTypeID].ToString().Trim(); //技能类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareResCaseEN.CaseLevelId = objRow[convCoursewareResCase.CaseLevelId] == DBNull.Value ? null : objRow[convCoursewareResCase.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvCoursewareResCaseEN.CaseLevelName = objRow[convCoursewareResCase.CaseLevelName] == DBNull.Value ? null : objRow[convCoursewareResCase.CaseLevelName].ToString().Trim(); //案例等级名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvCoursewareResCaseEN.DocFile = objRow[convCoursewareResCase.DocFile] == DBNull.Value ? null : objRow[convCoursewareResCase.DocFile].ToString().Trim(); //生成的Word文件名(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareResCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convCoursewareResCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word(字段类型:bit,字段长度:1,是否可空:True)
 objvCoursewareResCaseEN.WordCreateDate = objRow[convCoursewareResCase.WordCreateDate] == DBNull.Value ? null : objRow[convCoursewareResCase.WordCreateDate].ToString().Trim(); //Word生成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objvCoursewareResCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCoursewareResCase.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvCoursewareResCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCoursewareResCase.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvCoursewareResCaseEN.IdXzCollege = objRow[convCoursewareResCase.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvCoursewareResCaseEN.CollegeID = objRow[convCoursewareResCase.CollegeID] == DBNull.Value ? null : objRow[convCoursewareResCase.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvCoursewareResCaseEN.CollegeName = objRow[convCoursewareResCase.CollegeName] == DBNull.Value ? null : objRow[convCoursewareResCase.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCoursewareResCaseEN.CollegeNameA = objRow[convCoursewareResCase.CollegeNameA] == DBNull.Value ? null : objRow[convCoursewareResCase.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvCoursewareResCaseEN.IdXzMajor = objRow[convCoursewareResCase.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareResCaseEN.MajorID = objRow[convCoursewareResCase.MajorID] == DBNull.Value ? null : objRow[convCoursewareResCase.MajorID].ToString().Trim(); //专业ID(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareResCaseEN.MajorName = objRow[convCoursewareResCase.MajorName] == DBNull.Value ? null : objRow[convCoursewareResCase.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCoursewareResCaseEN.CourseChapterId = objRow[convCoursewareResCase.CourseChapterId] == DBNull.Value ? null : objRow[convCoursewareResCase.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareResCaseEN.CourseChapterName = objRow[convCoursewareResCase.CourseChapterName] == DBNull.Value ? null : objRow[convCoursewareResCase.CourseChapterName].ToString().Trim(); //课程章节名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCoursewareResCaseEN.ParentNodeID = objRow[convCoursewareResCase.ParentNodeID] == DBNull.Value ? null : objRow[convCoursewareResCase.ParentNodeID].ToString().Trim(); //父节点编号(字段类型:varchar,字段长度:8,是否可空:True)
 objvCoursewareResCaseEN.ParentNodeName = objRow[convCoursewareResCase.ParentNodeName] == DBNull.Value ? null : objRow[convCoursewareResCase.ParentNodeName].ToString().Trim(); //父节点名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvCoursewareResCaseEN.ViewCount = objRow[convCoursewareResCase.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCoursewareResCase.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvCoursewareResCaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convCoursewareResCase.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objvCoursewareResCaseEN.DownloadNumber = objRow[convCoursewareResCase.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCoursewareResCase.DownloadNumber].ToString().Trim()); //下载数目(字段类型:int,字段长度:4,是否可空:True)
 objvCoursewareResCaseEN.FileIntegration = objRow[convCoursewareResCase.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCoursewareResCase.FileIntegration].ToString().Trim()); //文件积分(字段类型:int,字段长度:4,是否可空:True)
 objvCoursewareResCaseEN.LikeCount = objRow[convCoursewareResCase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCoursewareResCase.LikeCount].ToString().Trim()); //资源喜欢数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvCoursewareResCaseEN.CollectionCount = objRow[convCoursewareResCase.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCoursewareResCase.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvCoursewareResCaseEN.RecommendedDegreeId = objRow[convCoursewareResCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvCoursewareResCaseEN.RecommendedDegreeName = objRow[convCoursewareResCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCoursewareResCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCoursewareResCaseEN.ftpFileType = objRow[convCoursewareResCase.ftpFileType] == DBNull.Value ? null : objRow[convCoursewareResCase.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvCoursewareResCaseEN.CourseId = objRow[convCoursewareResCase.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareResCaseEN.CourseCode = objRow[convCoursewareResCase.CourseCode] == DBNull.Value ? null : objRow[convCoursewareResCase.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvCoursewareResCaseEN.CourseName = objRow[convCoursewareResCase.CourseName] == DBNull.Value ? null : objRow[convCoursewareResCase.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvCoursewareResCaseEN.VideoUrl = objRow[convCoursewareResCase.VideoUrl] == DBNull.Value ? null : objRow[convCoursewareResCase.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCoursewareResCaseEN.VideoPath = objRow[convCoursewareResCase.VideoPath] == DBNull.Value ? null : objRow[convCoursewareResCase.VideoPath].ToString().Trim(); //视频目录(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCoursewareResCaseEN.ResErrMsg = objRow[convCoursewareResCase.ResErrMsg] == DBNull.Value ? null : objRow[convCoursewareResCase.ResErrMsg].ToString().Trim(); //资源错误信息(字段类型:varchar,字段长度:30,是否可空:True)
 objvCoursewareResCaseEN.UpdDate = objRow[convCoursewareResCase.UpdDate] == DBNull.Value ? null : objRow[convCoursewareResCase.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvCoursewareResCaseEN.UpdUserId = objRow[convCoursewareResCase.UpdUserId] == DBNull.Value ? null : objRow[convCoursewareResCase.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvCoursewareResCaseEN.Memo = objRow[convCoursewareResCase.Memo] == DBNull.Value ? null : objRow[convCoursewareResCase.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCoursewareResCaseEN.OwnerNameWithId = objRow[convCoursewareResCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convCoursewareResCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
 objvCoursewareResCaseEN.OwnerName = objRow[convCoursewareResCase.OwnerName] == DBNull.Value ? null : objRow[convCoursewareResCase.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvCoursewareResCaseEN.BrowseCount4Case = objRow[convCoursewareResCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCoursewareResCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvCoursewareResCaseEN.IsHaveVideo = objRow[convCoursewareResCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo(字段类型:varchar,字段长度:6,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvCoursewareResCaseDA: GetObjByIdCoursewareResCase)", objException.Message));
}
return objvCoursewareResCaseEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvCoursewareResCaseEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvCoursewareResCaseDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCaseDA.GetSpecSQLObj();
strSQL = "Select * from vCoursewareResCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvCoursewareResCaseEN objvCoursewareResCaseEN = new clsvCoursewareResCaseEN()
{
IdCoursewareResCase = objRow[convCoursewareResCase.IdCoursewareResCase].ToString().Trim(), //课件资源案例流水号
CoursewareResCaseID = objRow[convCoursewareResCase.CoursewareResCaseID].ToString().Trim(), //课件资源案例ID
CoursewareResCaseName = objRow[convCoursewareResCase.CoursewareResCaseName].ToString().Trim(), //课件资源案例名称
CoursewareResCaseTheme = objRow[convCoursewareResCase.CoursewareResCaseTheme] == DBNull.Value ? null : objRow[convCoursewareResCase.CoursewareResCaseTheme].ToString().Trim(), //课件资源案例主题词
CoursewareResCaseText = objRow[convCoursewareResCase.CoursewareResCaseText] == DBNull.Value ? null : objRow[convCoursewareResCase.CoursewareResCaseText].ToString().Trim(), //案例文本内容
IdCoursewareResCaseType = objRow[convCoursewareResCase.IdCoursewareResCaseType].ToString().Trim(), //课件资源类型流水号
CoursewareResCaseTypeName = objRow[convCoursewareResCase.CoursewareResCaseTypeName] == DBNull.Value ? null : objRow[convCoursewareResCase.CoursewareResCaseTypeName].ToString().Trim(), //课件资源案例类型名称
CoursewareResCaseDate = objRow[convCoursewareResCase.CoursewareResCaseDate] == DBNull.Value ? null : objRow[convCoursewareResCase.CoursewareResCaseDate].ToString().Trim(), //视频资源日期
CoursewareResCaseTime = objRow[convCoursewareResCase.CoursewareResCaseTime] == DBNull.Value ? null : objRow[convCoursewareResCase.CoursewareResCaseTime].ToString().Trim(), //视频资源时间
CoursewareResCaseDateIn = objRow[convCoursewareResCase.CoursewareResCaseDateIn] == DBNull.Value ? null : objRow[convCoursewareResCase.CoursewareResCaseDateIn].ToString().Trim(), //案例入库日期
CoursewareResCaseTimeIn = objRow[convCoursewareResCase.CoursewareResCaseTimeIn] == DBNull.Value ? null : objRow[convCoursewareResCase.CoursewareResCaseTimeIn].ToString().Trim(), //案例入库时间
OwnerId = objRow[convCoursewareResCase.OwnerId].ToString().Trim(), //拥有者Id
IdStudyLevel = objRow[convCoursewareResCase.IdStudyLevel] == DBNull.Value ? null : objRow[convCoursewareResCase.IdStudyLevel].ToString().Trim(), //id_StudyLevel
StudyLevelName = objRow[convCoursewareResCase.StudyLevelName] == DBNull.Value ? null : objRow[convCoursewareResCase.StudyLevelName].ToString().Trim(), //学段名称
IdTeachingPlan = objRow[convCoursewareResCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convCoursewareResCase.IdTeachingPlan].ToString().Trim(), //教案流水号
IdDiscipline = objRow[convCoursewareResCase.IdDiscipline].ToString().Trim(), //学科流水号
DisciplineID = objRow[convCoursewareResCase.DisciplineID] == DBNull.Value ? null : objRow[convCoursewareResCase.DisciplineID].ToString().Trim(), //学科ID
DisciplineName = objRow[convCoursewareResCase.DisciplineName] == DBNull.Value ? null : objRow[convCoursewareResCase.DisciplineName].ToString().Trim(), //学科名称
IdSenateGaugeVersion = objRow[convCoursewareResCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convCoursewareResCase.IdSenateGaugeVersion].ToString().Trim(), //评价量表版本流水号
senateGaugeVersionID = objRow[convCoursewareResCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCoursewareResCase.senateGaugeVersionID].ToString().Trim(), //评价量表版本ID
senateGaugeVersionName = objRow[convCoursewareResCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCoursewareResCase.senateGaugeVersionName].ToString().Trim(), //评价量表版本名称
senateGaugeVersionTtlScore = objRow[convCoursewareResCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convCoursewareResCase.senateGaugeVersionTtlScore].ToString().Trim()), //评价量表版本总分
VersionNo = objRow[convCoursewareResCase.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase.VersionNo].ToString().Trim()), //版本号
IdTeachSkill = objRow[convCoursewareResCase.IdTeachSkill].ToString().Trim(), //教学技能流水号
TeachSkillID = objRow[convCoursewareResCase.TeachSkillID] == DBNull.Value ? null : objRow[convCoursewareResCase.TeachSkillID].ToString().Trim(), //教学技能ID
SkillTypeName = objRow[convCoursewareResCase.SkillTypeName] == DBNull.Value ? null : objRow[convCoursewareResCase.SkillTypeName].ToString().Trim(), //技能类型名称
TeachSkillName = objRow[convCoursewareResCase.TeachSkillName] == DBNull.Value ? null : objRow[convCoursewareResCase.TeachSkillName].ToString().Trim(), //教学技能名称
TeachSkillTheory = objRow[convCoursewareResCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convCoursewareResCase.TeachSkillTheory].ToString().Trim(), //教学技能理论阐述
TeachSkillOperMethod = objRow[convCoursewareResCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCoursewareResCase.TeachSkillOperMethod].ToString().Trim(), //教学技能实践操作方法
IdSkillType = objRow[convCoursewareResCase.IdSkillType] == DBNull.Value ? null : objRow[convCoursewareResCase.IdSkillType].ToString().Trim(), //技能类型流水号
SkillTypeID = objRow[convCoursewareResCase.SkillTypeID] == DBNull.Value ? null : objRow[convCoursewareResCase.SkillTypeID].ToString().Trim(), //技能类型ID
CaseLevelId = objRow[convCoursewareResCase.CaseLevelId] == DBNull.Value ? null : objRow[convCoursewareResCase.CaseLevelId].ToString().Trim(), //课例等级Id
CaseLevelName = objRow[convCoursewareResCase.CaseLevelName] == DBNull.Value ? null : objRow[convCoursewareResCase.CaseLevelName].ToString().Trim(), //案例等级名称
DocFile = objRow[convCoursewareResCase.DocFile] == DBNull.Value ? null : objRow[convCoursewareResCase.DocFile].ToString().Trim(), //生成的Word文件名
IsNeedGeneWord = TransNullToBool(objRow[convCoursewareResCase.IsNeedGeneWord].ToString().Trim()), //是否需要生成Word
WordCreateDate = objRow[convCoursewareResCase.WordCreateDate] == DBNull.Value ? null : objRow[convCoursewareResCase.WordCreateDate].ToString().Trim(), //Word生成日期
IsVisible = TransNullToBool(objRow[convCoursewareResCase.IsVisible].ToString().Trim()), //是否显示
IsDualVideo = TransNullToBool(objRow[convCoursewareResCase.IsDualVideo].ToString().Trim()), //是否双视频
IdXzCollege = objRow[convCoursewareResCase.IdXzCollege].ToString().Trim(), //学院流水号
CollegeID = objRow[convCoursewareResCase.CollegeID] == DBNull.Value ? null : objRow[convCoursewareResCase.CollegeID].ToString().Trim(), //学院ID
CollegeName = objRow[convCoursewareResCase.CollegeName] == DBNull.Value ? null : objRow[convCoursewareResCase.CollegeName].ToString().Trim(), //学院名称
CollegeNameA = objRow[convCoursewareResCase.CollegeNameA] == DBNull.Value ? null : objRow[convCoursewareResCase.CollegeNameA].ToString().Trim(), //学院名称简写
IdXzMajor = objRow[convCoursewareResCase.IdXzMajor].ToString().Trim(), //专业流水号
MajorID = objRow[convCoursewareResCase.MajorID] == DBNull.Value ? null : objRow[convCoursewareResCase.MajorID].ToString().Trim(), //专业ID
MajorName = objRow[convCoursewareResCase.MajorName] == DBNull.Value ? null : objRow[convCoursewareResCase.MajorName].ToString().Trim(), //专业名称
CourseChapterId = objRow[convCoursewareResCase.CourseChapterId] == DBNull.Value ? null : objRow[convCoursewareResCase.CourseChapterId].ToString().Trim(), //课程章节ID
CourseChapterName = objRow[convCoursewareResCase.CourseChapterName] == DBNull.Value ? null : objRow[convCoursewareResCase.CourseChapterName].ToString().Trim(), //课程章节名称
ParentNodeID = objRow[convCoursewareResCase.ParentNodeID] == DBNull.Value ? null : objRow[convCoursewareResCase.ParentNodeID].ToString().Trim(), //父节点编号
ParentNodeName = objRow[convCoursewareResCase.ParentNodeName] == DBNull.Value ? null : objRow[convCoursewareResCase.ParentNodeName].ToString().Trim(), //父节点名称
ViewCount = objRow[convCoursewareResCase.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase.ViewCount].ToString().Trim()), //浏览量
IsShow = TransNullToBool(objRow[convCoursewareResCase.IsShow].ToString().Trim()), //是否启用
DownloadNumber = objRow[convCoursewareResCase.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase.DownloadNumber].ToString().Trim()), //下载数目
FileIntegration = objRow[convCoursewareResCase.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase.FileIntegration].ToString().Trim()), //文件积分
LikeCount = objRow[convCoursewareResCase.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCoursewareResCase.LikeCount].ToString().Trim()), //资源喜欢数量
CollectionCount = objRow[convCoursewareResCase.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCoursewareResCase.CollectionCount].ToString().Trim()), //收藏数量
RecommendedDegreeId = objRow[convCoursewareResCase.RecommendedDegreeId].ToString().Trim(), //推荐度Id
RecommendedDegreeName = objRow[convCoursewareResCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCoursewareResCase.RecommendedDegreeName].ToString().Trim(), //推荐度名称
ftpFileType = objRow[convCoursewareResCase.ftpFileType] == DBNull.Value ? null : objRow[convCoursewareResCase.ftpFileType].ToString().Trim(), //ftp文件类型
CourseId = objRow[convCoursewareResCase.CourseId].ToString().Trim(), //课程Id
CourseCode = objRow[convCoursewareResCase.CourseCode] == DBNull.Value ? null : objRow[convCoursewareResCase.CourseCode].ToString().Trim(), //课程代码
CourseName = objRow[convCoursewareResCase.CourseName] == DBNull.Value ? null : objRow[convCoursewareResCase.CourseName].ToString().Trim(), //课程名称
VideoUrl = objRow[convCoursewareResCase.VideoUrl] == DBNull.Value ? null : objRow[convCoursewareResCase.VideoUrl].ToString().Trim(), //视频Url
VideoPath = objRow[convCoursewareResCase.VideoPath] == DBNull.Value ? null : objRow[convCoursewareResCase.VideoPath].ToString().Trim(), //视频目录
ResErrMsg = objRow[convCoursewareResCase.ResErrMsg] == DBNull.Value ? null : objRow[convCoursewareResCase.ResErrMsg].ToString().Trim(), //资源错误信息
UpdDate = objRow[convCoursewareResCase.UpdDate] == DBNull.Value ? null : objRow[convCoursewareResCase.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[convCoursewareResCase.UpdUserId] == DBNull.Value ? null : objRow[convCoursewareResCase.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[convCoursewareResCase.Memo] == DBNull.Value ? null : objRow[convCoursewareResCase.Memo].ToString().Trim(), //备注
OwnerNameWithId = objRow[convCoursewareResCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convCoursewareResCase.OwnerNameWithId].ToString().Trim(), //拥有者名称附Id
OwnerName = objRow[convCoursewareResCase.OwnerName] == DBNull.Value ? null : objRow[convCoursewareResCase.OwnerName].ToString().Trim(), //拥有者姓名
BrowseCount4Case = objRow[convCoursewareResCase.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase.BrowseCount4Case].ToString().Trim()), //课例浏览次数
IsHaveVideo = objRow[convCoursewareResCase.IsHaveVideo].ToString().Trim() //IsHaveVideo
};
objvCoursewareResCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCoursewareResCaseEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvCoursewareResCaseDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvCoursewareResCaseEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCoursewareResCaseEN objvCoursewareResCaseEN = new clsvCoursewareResCaseEN();
try
{
objvCoursewareResCaseEN.IdCoursewareResCase = objRow[convCoursewareResCase.IdCoursewareResCase].ToString().Trim(); //课件资源案例流水号
objvCoursewareResCaseEN.CoursewareResCaseID = objRow[convCoursewareResCase.CoursewareResCaseID].ToString().Trim(); //课件资源案例ID
objvCoursewareResCaseEN.CoursewareResCaseName = objRow[convCoursewareResCase.CoursewareResCaseName].ToString().Trim(); //课件资源案例名称
objvCoursewareResCaseEN.CoursewareResCaseTheme = objRow[convCoursewareResCase.CoursewareResCaseTheme] == DBNull.Value ? null : objRow[convCoursewareResCase.CoursewareResCaseTheme].ToString().Trim(); //课件资源案例主题词
objvCoursewareResCaseEN.CoursewareResCaseText = objRow[convCoursewareResCase.CoursewareResCaseText] == DBNull.Value ? null : objRow[convCoursewareResCase.CoursewareResCaseText].ToString().Trim(); //案例文本内容
objvCoursewareResCaseEN.IdCoursewareResCaseType = objRow[convCoursewareResCase.IdCoursewareResCaseType].ToString().Trim(); //课件资源类型流水号
objvCoursewareResCaseEN.CoursewareResCaseTypeName = objRow[convCoursewareResCase.CoursewareResCaseTypeName] == DBNull.Value ? null : objRow[convCoursewareResCase.CoursewareResCaseTypeName].ToString().Trim(); //课件资源案例类型名称
objvCoursewareResCaseEN.CoursewareResCaseDate = objRow[convCoursewareResCase.CoursewareResCaseDate] == DBNull.Value ? null : objRow[convCoursewareResCase.CoursewareResCaseDate].ToString().Trim(); //视频资源日期
objvCoursewareResCaseEN.CoursewareResCaseTime = objRow[convCoursewareResCase.CoursewareResCaseTime] == DBNull.Value ? null : objRow[convCoursewareResCase.CoursewareResCaseTime].ToString().Trim(); //视频资源时间
objvCoursewareResCaseEN.CoursewareResCaseDateIn = objRow[convCoursewareResCase.CoursewareResCaseDateIn] == DBNull.Value ? null : objRow[convCoursewareResCase.CoursewareResCaseDateIn].ToString().Trim(); //案例入库日期
objvCoursewareResCaseEN.CoursewareResCaseTimeIn = objRow[convCoursewareResCase.CoursewareResCaseTimeIn] == DBNull.Value ? null : objRow[convCoursewareResCase.CoursewareResCaseTimeIn].ToString().Trim(); //案例入库时间
objvCoursewareResCaseEN.OwnerId = objRow[convCoursewareResCase.OwnerId].ToString().Trim(); //拥有者Id
objvCoursewareResCaseEN.IdStudyLevel = objRow[convCoursewareResCase.IdStudyLevel] == DBNull.Value ? null : objRow[convCoursewareResCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCoursewareResCaseEN.StudyLevelName = objRow[convCoursewareResCase.StudyLevelName] == DBNull.Value ? null : objRow[convCoursewareResCase.StudyLevelName].ToString().Trim(); //学段名称
objvCoursewareResCaseEN.IdTeachingPlan = objRow[convCoursewareResCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convCoursewareResCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCoursewareResCaseEN.IdDiscipline = objRow[convCoursewareResCase.IdDiscipline].ToString().Trim(); //学科流水号
objvCoursewareResCaseEN.DisciplineID = objRow[convCoursewareResCase.DisciplineID] == DBNull.Value ? null : objRow[convCoursewareResCase.DisciplineID].ToString().Trim(); //学科ID
objvCoursewareResCaseEN.DisciplineName = objRow[convCoursewareResCase.DisciplineName] == DBNull.Value ? null : objRow[convCoursewareResCase.DisciplineName].ToString().Trim(); //学科名称
objvCoursewareResCaseEN.IdSenateGaugeVersion = objRow[convCoursewareResCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convCoursewareResCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCoursewareResCaseEN.senateGaugeVersionID = objRow[convCoursewareResCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCoursewareResCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCoursewareResCaseEN.senateGaugeVersionName = objRow[convCoursewareResCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCoursewareResCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCoursewareResCaseEN.senateGaugeVersionTtlScore = objRow[convCoursewareResCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convCoursewareResCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCoursewareResCaseEN.VersionNo = objRow[convCoursewareResCase.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase.VersionNo].ToString().Trim()); //版本号
objvCoursewareResCaseEN.IdTeachSkill = objRow[convCoursewareResCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCoursewareResCaseEN.TeachSkillID = objRow[convCoursewareResCase.TeachSkillID] == DBNull.Value ? null : objRow[convCoursewareResCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvCoursewareResCaseEN.SkillTypeName = objRow[convCoursewareResCase.SkillTypeName] == DBNull.Value ? null : objRow[convCoursewareResCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvCoursewareResCaseEN.TeachSkillName = objRow[convCoursewareResCase.TeachSkillName] == DBNull.Value ? null : objRow[convCoursewareResCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvCoursewareResCaseEN.TeachSkillTheory = objRow[convCoursewareResCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convCoursewareResCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCoursewareResCaseEN.TeachSkillOperMethod = objRow[convCoursewareResCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCoursewareResCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCoursewareResCaseEN.IdSkillType = objRow[convCoursewareResCase.IdSkillType] == DBNull.Value ? null : objRow[convCoursewareResCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvCoursewareResCaseEN.SkillTypeID = objRow[convCoursewareResCase.SkillTypeID] == DBNull.Value ? null : objRow[convCoursewareResCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvCoursewareResCaseEN.CaseLevelId = objRow[convCoursewareResCase.CaseLevelId] == DBNull.Value ? null : objRow[convCoursewareResCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvCoursewareResCaseEN.CaseLevelName = objRow[convCoursewareResCase.CaseLevelName] == DBNull.Value ? null : objRow[convCoursewareResCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvCoursewareResCaseEN.DocFile = objRow[convCoursewareResCase.DocFile] == DBNull.Value ? null : objRow[convCoursewareResCase.DocFile].ToString().Trim(); //生成的Word文件名
objvCoursewareResCaseEN.IsNeedGeneWord = TransNullToBool(objRow[convCoursewareResCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvCoursewareResCaseEN.WordCreateDate = objRow[convCoursewareResCase.WordCreateDate] == DBNull.Value ? null : objRow[convCoursewareResCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvCoursewareResCaseEN.IsVisible = TransNullToBool(objRow[convCoursewareResCase.IsVisible].ToString().Trim()); //是否显示
objvCoursewareResCaseEN.IsDualVideo = TransNullToBool(objRow[convCoursewareResCase.IsDualVideo].ToString().Trim()); //是否双视频
objvCoursewareResCaseEN.IdXzCollege = objRow[convCoursewareResCase.IdXzCollege].ToString().Trim(); //学院流水号
objvCoursewareResCaseEN.CollegeID = objRow[convCoursewareResCase.CollegeID] == DBNull.Value ? null : objRow[convCoursewareResCase.CollegeID].ToString().Trim(); //学院ID
objvCoursewareResCaseEN.CollegeName = objRow[convCoursewareResCase.CollegeName] == DBNull.Value ? null : objRow[convCoursewareResCase.CollegeName].ToString().Trim(); //学院名称
objvCoursewareResCaseEN.CollegeNameA = objRow[convCoursewareResCase.CollegeNameA] == DBNull.Value ? null : objRow[convCoursewareResCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvCoursewareResCaseEN.IdXzMajor = objRow[convCoursewareResCase.IdXzMajor].ToString().Trim(); //专业流水号
objvCoursewareResCaseEN.MajorID = objRow[convCoursewareResCase.MajorID] == DBNull.Value ? null : objRow[convCoursewareResCase.MajorID].ToString().Trim(); //专业ID
objvCoursewareResCaseEN.MajorName = objRow[convCoursewareResCase.MajorName] == DBNull.Value ? null : objRow[convCoursewareResCase.MajorName].ToString().Trim(); //专业名称
objvCoursewareResCaseEN.CourseChapterId = objRow[convCoursewareResCase.CourseChapterId] == DBNull.Value ? null : objRow[convCoursewareResCase.CourseChapterId].ToString().Trim(); //课程章节ID
objvCoursewareResCaseEN.CourseChapterName = objRow[convCoursewareResCase.CourseChapterName] == DBNull.Value ? null : objRow[convCoursewareResCase.CourseChapterName].ToString().Trim(); //课程章节名称
objvCoursewareResCaseEN.ParentNodeID = objRow[convCoursewareResCase.ParentNodeID] == DBNull.Value ? null : objRow[convCoursewareResCase.ParentNodeID].ToString().Trim(); //父节点编号
objvCoursewareResCaseEN.ParentNodeName = objRow[convCoursewareResCase.ParentNodeName] == DBNull.Value ? null : objRow[convCoursewareResCase.ParentNodeName].ToString().Trim(); //父节点名称
objvCoursewareResCaseEN.ViewCount = objRow[convCoursewareResCase.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase.ViewCount].ToString().Trim()); //浏览量
objvCoursewareResCaseEN.IsShow = TransNullToBool(objRow[convCoursewareResCase.IsShow].ToString().Trim()); //是否启用
objvCoursewareResCaseEN.DownloadNumber = objRow[convCoursewareResCase.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase.DownloadNumber].ToString().Trim()); //下载数目
objvCoursewareResCaseEN.FileIntegration = objRow[convCoursewareResCase.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase.FileIntegration].ToString().Trim()); //文件积分
objvCoursewareResCaseEN.LikeCount = objRow[convCoursewareResCase.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCoursewareResCase.LikeCount].ToString().Trim()); //资源喜欢数量
objvCoursewareResCaseEN.CollectionCount = objRow[convCoursewareResCase.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCoursewareResCase.CollectionCount].ToString().Trim()); //收藏数量
objvCoursewareResCaseEN.RecommendedDegreeId = objRow[convCoursewareResCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCoursewareResCaseEN.RecommendedDegreeName = objRow[convCoursewareResCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCoursewareResCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCoursewareResCaseEN.ftpFileType = objRow[convCoursewareResCase.ftpFileType] == DBNull.Value ? null : objRow[convCoursewareResCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvCoursewareResCaseEN.CourseId = objRow[convCoursewareResCase.CourseId].ToString().Trim(); //课程Id
objvCoursewareResCaseEN.CourseCode = objRow[convCoursewareResCase.CourseCode] == DBNull.Value ? null : objRow[convCoursewareResCase.CourseCode].ToString().Trim(); //课程代码
objvCoursewareResCaseEN.CourseName = objRow[convCoursewareResCase.CourseName] == DBNull.Value ? null : objRow[convCoursewareResCase.CourseName].ToString().Trim(); //课程名称
objvCoursewareResCaseEN.VideoUrl = objRow[convCoursewareResCase.VideoUrl] == DBNull.Value ? null : objRow[convCoursewareResCase.VideoUrl].ToString().Trim(); //视频Url
objvCoursewareResCaseEN.VideoPath = objRow[convCoursewareResCase.VideoPath] == DBNull.Value ? null : objRow[convCoursewareResCase.VideoPath].ToString().Trim(); //视频目录
objvCoursewareResCaseEN.ResErrMsg = objRow[convCoursewareResCase.ResErrMsg] == DBNull.Value ? null : objRow[convCoursewareResCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvCoursewareResCaseEN.UpdDate = objRow[convCoursewareResCase.UpdDate] == DBNull.Value ? null : objRow[convCoursewareResCase.UpdDate].ToString().Trim(); //修改日期
objvCoursewareResCaseEN.UpdUserId = objRow[convCoursewareResCase.UpdUserId] == DBNull.Value ? null : objRow[convCoursewareResCase.UpdUserId].ToString().Trim(); //修改用户Id
objvCoursewareResCaseEN.Memo = objRow[convCoursewareResCase.Memo] == DBNull.Value ? null : objRow[convCoursewareResCase.Memo].ToString().Trim(); //备注
objvCoursewareResCaseEN.OwnerNameWithId = objRow[convCoursewareResCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convCoursewareResCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCoursewareResCaseEN.OwnerName = objRow[convCoursewareResCase.OwnerName] == DBNull.Value ? null : objRow[convCoursewareResCase.OwnerName].ToString().Trim(); //拥有者姓名
objvCoursewareResCaseEN.BrowseCount4Case = objRow[convCoursewareResCase.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCoursewareResCaseEN.IsHaveVideo = objRow[convCoursewareResCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvCoursewareResCaseDA: GetObjByDataRowvCoursewareResCase)", objException.Message));
}
objvCoursewareResCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCoursewareResCaseEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvCoursewareResCaseEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCoursewareResCaseEN objvCoursewareResCaseEN = new clsvCoursewareResCaseEN();
try
{
objvCoursewareResCaseEN.IdCoursewareResCase = objRow[convCoursewareResCase.IdCoursewareResCase].ToString().Trim(); //课件资源案例流水号
objvCoursewareResCaseEN.CoursewareResCaseID = objRow[convCoursewareResCase.CoursewareResCaseID].ToString().Trim(); //课件资源案例ID
objvCoursewareResCaseEN.CoursewareResCaseName = objRow[convCoursewareResCase.CoursewareResCaseName].ToString().Trim(); //课件资源案例名称
objvCoursewareResCaseEN.CoursewareResCaseTheme = objRow[convCoursewareResCase.CoursewareResCaseTheme] == DBNull.Value ? null : objRow[convCoursewareResCase.CoursewareResCaseTheme].ToString().Trim(); //课件资源案例主题词
objvCoursewareResCaseEN.CoursewareResCaseText = objRow[convCoursewareResCase.CoursewareResCaseText] == DBNull.Value ? null : objRow[convCoursewareResCase.CoursewareResCaseText].ToString().Trim(); //案例文本内容
objvCoursewareResCaseEN.IdCoursewareResCaseType = objRow[convCoursewareResCase.IdCoursewareResCaseType].ToString().Trim(); //课件资源类型流水号
objvCoursewareResCaseEN.CoursewareResCaseTypeName = objRow[convCoursewareResCase.CoursewareResCaseTypeName] == DBNull.Value ? null : objRow[convCoursewareResCase.CoursewareResCaseTypeName].ToString().Trim(); //课件资源案例类型名称
objvCoursewareResCaseEN.CoursewareResCaseDate = objRow[convCoursewareResCase.CoursewareResCaseDate] == DBNull.Value ? null : objRow[convCoursewareResCase.CoursewareResCaseDate].ToString().Trim(); //视频资源日期
objvCoursewareResCaseEN.CoursewareResCaseTime = objRow[convCoursewareResCase.CoursewareResCaseTime] == DBNull.Value ? null : objRow[convCoursewareResCase.CoursewareResCaseTime].ToString().Trim(); //视频资源时间
objvCoursewareResCaseEN.CoursewareResCaseDateIn = objRow[convCoursewareResCase.CoursewareResCaseDateIn] == DBNull.Value ? null : objRow[convCoursewareResCase.CoursewareResCaseDateIn].ToString().Trim(); //案例入库日期
objvCoursewareResCaseEN.CoursewareResCaseTimeIn = objRow[convCoursewareResCase.CoursewareResCaseTimeIn] == DBNull.Value ? null : objRow[convCoursewareResCase.CoursewareResCaseTimeIn].ToString().Trim(); //案例入库时间
objvCoursewareResCaseEN.OwnerId = objRow[convCoursewareResCase.OwnerId].ToString().Trim(); //拥有者Id
objvCoursewareResCaseEN.IdStudyLevel = objRow[convCoursewareResCase.IdStudyLevel] == DBNull.Value ? null : objRow[convCoursewareResCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCoursewareResCaseEN.StudyLevelName = objRow[convCoursewareResCase.StudyLevelName] == DBNull.Value ? null : objRow[convCoursewareResCase.StudyLevelName].ToString().Trim(); //学段名称
objvCoursewareResCaseEN.IdTeachingPlan = objRow[convCoursewareResCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convCoursewareResCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCoursewareResCaseEN.IdDiscipline = objRow[convCoursewareResCase.IdDiscipline].ToString().Trim(); //学科流水号
objvCoursewareResCaseEN.DisciplineID = objRow[convCoursewareResCase.DisciplineID] == DBNull.Value ? null : objRow[convCoursewareResCase.DisciplineID].ToString().Trim(); //学科ID
objvCoursewareResCaseEN.DisciplineName = objRow[convCoursewareResCase.DisciplineName] == DBNull.Value ? null : objRow[convCoursewareResCase.DisciplineName].ToString().Trim(); //学科名称
objvCoursewareResCaseEN.IdSenateGaugeVersion = objRow[convCoursewareResCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convCoursewareResCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCoursewareResCaseEN.senateGaugeVersionID = objRow[convCoursewareResCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCoursewareResCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCoursewareResCaseEN.senateGaugeVersionName = objRow[convCoursewareResCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCoursewareResCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCoursewareResCaseEN.senateGaugeVersionTtlScore = objRow[convCoursewareResCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convCoursewareResCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCoursewareResCaseEN.VersionNo = objRow[convCoursewareResCase.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase.VersionNo].ToString().Trim()); //版本号
objvCoursewareResCaseEN.IdTeachSkill = objRow[convCoursewareResCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCoursewareResCaseEN.TeachSkillID = objRow[convCoursewareResCase.TeachSkillID] == DBNull.Value ? null : objRow[convCoursewareResCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvCoursewareResCaseEN.SkillTypeName = objRow[convCoursewareResCase.SkillTypeName] == DBNull.Value ? null : objRow[convCoursewareResCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvCoursewareResCaseEN.TeachSkillName = objRow[convCoursewareResCase.TeachSkillName] == DBNull.Value ? null : objRow[convCoursewareResCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvCoursewareResCaseEN.TeachSkillTheory = objRow[convCoursewareResCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convCoursewareResCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCoursewareResCaseEN.TeachSkillOperMethod = objRow[convCoursewareResCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCoursewareResCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCoursewareResCaseEN.IdSkillType = objRow[convCoursewareResCase.IdSkillType] == DBNull.Value ? null : objRow[convCoursewareResCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvCoursewareResCaseEN.SkillTypeID = objRow[convCoursewareResCase.SkillTypeID] == DBNull.Value ? null : objRow[convCoursewareResCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvCoursewareResCaseEN.CaseLevelId = objRow[convCoursewareResCase.CaseLevelId] == DBNull.Value ? null : objRow[convCoursewareResCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvCoursewareResCaseEN.CaseLevelName = objRow[convCoursewareResCase.CaseLevelName] == DBNull.Value ? null : objRow[convCoursewareResCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvCoursewareResCaseEN.DocFile = objRow[convCoursewareResCase.DocFile] == DBNull.Value ? null : objRow[convCoursewareResCase.DocFile].ToString().Trim(); //生成的Word文件名
objvCoursewareResCaseEN.IsNeedGeneWord = TransNullToBool(objRow[convCoursewareResCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvCoursewareResCaseEN.WordCreateDate = objRow[convCoursewareResCase.WordCreateDate] == DBNull.Value ? null : objRow[convCoursewareResCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvCoursewareResCaseEN.IsVisible = TransNullToBool(objRow[convCoursewareResCase.IsVisible].ToString().Trim()); //是否显示
objvCoursewareResCaseEN.IsDualVideo = TransNullToBool(objRow[convCoursewareResCase.IsDualVideo].ToString().Trim()); //是否双视频
objvCoursewareResCaseEN.IdXzCollege = objRow[convCoursewareResCase.IdXzCollege].ToString().Trim(); //学院流水号
objvCoursewareResCaseEN.CollegeID = objRow[convCoursewareResCase.CollegeID] == DBNull.Value ? null : objRow[convCoursewareResCase.CollegeID].ToString().Trim(); //学院ID
objvCoursewareResCaseEN.CollegeName = objRow[convCoursewareResCase.CollegeName] == DBNull.Value ? null : objRow[convCoursewareResCase.CollegeName].ToString().Trim(); //学院名称
objvCoursewareResCaseEN.CollegeNameA = objRow[convCoursewareResCase.CollegeNameA] == DBNull.Value ? null : objRow[convCoursewareResCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvCoursewareResCaseEN.IdXzMajor = objRow[convCoursewareResCase.IdXzMajor].ToString().Trim(); //专业流水号
objvCoursewareResCaseEN.MajorID = objRow[convCoursewareResCase.MajorID] == DBNull.Value ? null : objRow[convCoursewareResCase.MajorID].ToString().Trim(); //专业ID
objvCoursewareResCaseEN.MajorName = objRow[convCoursewareResCase.MajorName] == DBNull.Value ? null : objRow[convCoursewareResCase.MajorName].ToString().Trim(); //专业名称
objvCoursewareResCaseEN.CourseChapterId = objRow[convCoursewareResCase.CourseChapterId] == DBNull.Value ? null : objRow[convCoursewareResCase.CourseChapterId].ToString().Trim(); //课程章节ID
objvCoursewareResCaseEN.CourseChapterName = objRow[convCoursewareResCase.CourseChapterName] == DBNull.Value ? null : objRow[convCoursewareResCase.CourseChapterName].ToString().Trim(); //课程章节名称
objvCoursewareResCaseEN.ParentNodeID = objRow[convCoursewareResCase.ParentNodeID] == DBNull.Value ? null : objRow[convCoursewareResCase.ParentNodeID].ToString().Trim(); //父节点编号
objvCoursewareResCaseEN.ParentNodeName = objRow[convCoursewareResCase.ParentNodeName] == DBNull.Value ? null : objRow[convCoursewareResCase.ParentNodeName].ToString().Trim(); //父节点名称
objvCoursewareResCaseEN.ViewCount = objRow[convCoursewareResCase.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase.ViewCount].ToString().Trim()); //浏览量
objvCoursewareResCaseEN.IsShow = TransNullToBool(objRow[convCoursewareResCase.IsShow].ToString().Trim()); //是否启用
objvCoursewareResCaseEN.DownloadNumber = objRow[convCoursewareResCase.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase.DownloadNumber].ToString().Trim()); //下载数目
objvCoursewareResCaseEN.FileIntegration = objRow[convCoursewareResCase.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase.FileIntegration].ToString().Trim()); //文件积分
objvCoursewareResCaseEN.LikeCount = objRow[convCoursewareResCase.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCoursewareResCase.LikeCount].ToString().Trim()); //资源喜欢数量
objvCoursewareResCaseEN.CollectionCount = objRow[convCoursewareResCase.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCoursewareResCase.CollectionCount].ToString().Trim()); //收藏数量
objvCoursewareResCaseEN.RecommendedDegreeId = objRow[convCoursewareResCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCoursewareResCaseEN.RecommendedDegreeName = objRow[convCoursewareResCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCoursewareResCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCoursewareResCaseEN.ftpFileType = objRow[convCoursewareResCase.ftpFileType] == DBNull.Value ? null : objRow[convCoursewareResCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvCoursewareResCaseEN.CourseId = objRow[convCoursewareResCase.CourseId].ToString().Trim(); //课程Id
objvCoursewareResCaseEN.CourseCode = objRow[convCoursewareResCase.CourseCode] == DBNull.Value ? null : objRow[convCoursewareResCase.CourseCode].ToString().Trim(); //课程代码
objvCoursewareResCaseEN.CourseName = objRow[convCoursewareResCase.CourseName] == DBNull.Value ? null : objRow[convCoursewareResCase.CourseName].ToString().Trim(); //课程名称
objvCoursewareResCaseEN.VideoUrl = objRow[convCoursewareResCase.VideoUrl] == DBNull.Value ? null : objRow[convCoursewareResCase.VideoUrl].ToString().Trim(); //视频Url
objvCoursewareResCaseEN.VideoPath = objRow[convCoursewareResCase.VideoPath] == DBNull.Value ? null : objRow[convCoursewareResCase.VideoPath].ToString().Trim(); //视频目录
objvCoursewareResCaseEN.ResErrMsg = objRow[convCoursewareResCase.ResErrMsg] == DBNull.Value ? null : objRow[convCoursewareResCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvCoursewareResCaseEN.UpdDate = objRow[convCoursewareResCase.UpdDate] == DBNull.Value ? null : objRow[convCoursewareResCase.UpdDate].ToString().Trim(); //修改日期
objvCoursewareResCaseEN.UpdUserId = objRow[convCoursewareResCase.UpdUserId] == DBNull.Value ? null : objRow[convCoursewareResCase.UpdUserId].ToString().Trim(); //修改用户Id
objvCoursewareResCaseEN.Memo = objRow[convCoursewareResCase.Memo] == DBNull.Value ? null : objRow[convCoursewareResCase.Memo].ToString().Trim(); //备注
objvCoursewareResCaseEN.OwnerNameWithId = objRow[convCoursewareResCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convCoursewareResCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCoursewareResCaseEN.OwnerName = objRow[convCoursewareResCase.OwnerName] == DBNull.Value ? null : objRow[convCoursewareResCase.OwnerName].ToString().Trim(); //拥有者姓名
objvCoursewareResCaseEN.BrowseCount4Case = objRow[convCoursewareResCase.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCoursewareResCaseEN.IsHaveVideo = objRow[convCoursewareResCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvCoursewareResCaseDA: GetObjByDataRow)", objException.Message));
}
objvCoursewareResCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCoursewareResCaseEN;
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
objSQL = clsvCoursewareResCaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCoursewareResCaseEN._CurrTabName, convCoursewareResCase.IdCoursewareResCase, 8, "");
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
objSQL = clsvCoursewareResCaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCoursewareResCaseEN._CurrTabName, convCoursewareResCase.IdCoursewareResCase, 8, strPrefix);
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
 objSQL = clsvCoursewareResCaseDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdCoursewareResCase from vCoursewareResCase where " + strCondition;
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
 objSQL = clsvCoursewareResCaseDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdCoursewareResCase from vCoursewareResCase where " + strCondition;
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
 objSQL = clsvCoursewareResCaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCoursewareResCase", "IdCoursewareResCase = " + "'"+ strIdCoursewareResCase+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvCoursewareResCaseDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCoursewareResCase", strCondition))
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
objSQL = clsvCoursewareResCaseDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vCoursewareResCase");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvCoursewareResCaseENS">源对象</param>
 /// <param name = "objvCoursewareResCaseENT">目标对象</param>
public void CopyTo(clsvCoursewareResCaseEN objvCoursewareResCaseENS, clsvCoursewareResCaseEN objvCoursewareResCaseENT)
{
objvCoursewareResCaseENT.IdCoursewareResCase = objvCoursewareResCaseENS.IdCoursewareResCase; //课件资源案例流水号
objvCoursewareResCaseENT.CoursewareResCaseID = objvCoursewareResCaseENS.CoursewareResCaseID; //课件资源案例ID
objvCoursewareResCaseENT.CoursewareResCaseName = objvCoursewareResCaseENS.CoursewareResCaseName; //课件资源案例名称
objvCoursewareResCaseENT.CoursewareResCaseTheme = objvCoursewareResCaseENS.CoursewareResCaseTheme; //课件资源案例主题词
objvCoursewareResCaseENT.CoursewareResCaseText = objvCoursewareResCaseENS.CoursewareResCaseText; //案例文本内容
objvCoursewareResCaseENT.IdCoursewareResCaseType = objvCoursewareResCaseENS.IdCoursewareResCaseType; //课件资源类型流水号
objvCoursewareResCaseENT.CoursewareResCaseTypeName = objvCoursewareResCaseENS.CoursewareResCaseTypeName; //课件资源案例类型名称
objvCoursewareResCaseENT.CoursewareResCaseDate = objvCoursewareResCaseENS.CoursewareResCaseDate; //视频资源日期
objvCoursewareResCaseENT.CoursewareResCaseTime = objvCoursewareResCaseENS.CoursewareResCaseTime; //视频资源时间
objvCoursewareResCaseENT.CoursewareResCaseDateIn = objvCoursewareResCaseENS.CoursewareResCaseDateIn; //案例入库日期
objvCoursewareResCaseENT.CoursewareResCaseTimeIn = objvCoursewareResCaseENS.CoursewareResCaseTimeIn; //案例入库时间
objvCoursewareResCaseENT.OwnerId = objvCoursewareResCaseENS.OwnerId; //拥有者Id
objvCoursewareResCaseENT.IdStudyLevel = objvCoursewareResCaseENS.IdStudyLevel; //id_StudyLevel
objvCoursewareResCaseENT.StudyLevelName = objvCoursewareResCaseENS.StudyLevelName; //学段名称
objvCoursewareResCaseENT.IdTeachingPlan = objvCoursewareResCaseENS.IdTeachingPlan; //教案流水号
objvCoursewareResCaseENT.IdDiscipline = objvCoursewareResCaseENS.IdDiscipline; //学科流水号
objvCoursewareResCaseENT.DisciplineID = objvCoursewareResCaseENS.DisciplineID; //学科ID
objvCoursewareResCaseENT.DisciplineName = objvCoursewareResCaseENS.DisciplineName; //学科名称
objvCoursewareResCaseENT.IdSenateGaugeVersion = objvCoursewareResCaseENS.IdSenateGaugeVersion; //评价量表版本流水号
objvCoursewareResCaseENT.senateGaugeVersionID = objvCoursewareResCaseENS.senateGaugeVersionID; //评价量表版本ID
objvCoursewareResCaseENT.senateGaugeVersionName = objvCoursewareResCaseENS.senateGaugeVersionName; //评价量表版本名称
objvCoursewareResCaseENT.senateGaugeVersionTtlScore = objvCoursewareResCaseENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvCoursewareResCaseENT.VersionNo = objvCoursewareResCaseENS.VersionNo; //版本号
objvCoursewareResCaseENT.IdTeachSkill = objvCoursewareResCaseENS.IdTeachSkill; //教学技能流水号
objvCoursewareResCaseENT.TeachSkillID = objvCoursewareResCaseENS.TeachSkillID; //教学技能ID
objvCoursewareResCaseENT.SkillTypeName = objvCoursewareResCaseENS.SkillTypeName; //技能类型名称
objvCoursewareResCaseENT.TeachSkillName = objvCoursewareResCaseENS.TeachSkillName; //教学技能名称
objvCoursewareResCaseENT.TeachSkillTheory = objvCoursewareResCaseENS.TeachSkillTheory; //教学技能理论阐述
objvCoursewareResCaseENT.TeachSkillOperMethod = objvCoursewareResCaseENS.TeachSkillOperMethod; //教学技能实践操作方法
objvCoursewareResCaseENT.IdSkillType = objvCoursewareResCaseENS.IdSkillType; //技能类型流水号
objvCoursewareResCaseENT.SkillTypeID = objvCoursewareResCaseENS.SkillTypeID; //技能类型ID
objvCoursewareResCaseENT.CaseLevelId = objvCoursewareResCaseENS.CaseLevelId; //课例等级Id
objvCoursewareResCaseENT.CaseLevelName = objvCoursewareResCaseENS.CaseLevelName; //案例等级名称
objvCoursewareResCaseENT.DocFile = objvCoursewareResCaseENS.DocFile; //生成的Word文件名
objvCoursewareResCaseENT.IsNeedGeneWord = objvCoursewareResCaseENS.IsNeedGeneWord; //是否需要生成Word
objvCoursewareResCaseENT.WordCreateDate = objvCoursewareResCaseENS.WordCreateDate; //Word生成日期
objvCoursewareResCaseENT.IsVisible = objvCoursewareResCaseENS.IsVisible; //是否显示
objvCoursewareResCaseENT.IsDualVideo = objvCoursewareResCaseENS.IsDualVideo; //是否双视频
objvCoursewareResCaseENT.IdXzCollege = objvCoursewareResCaseENS.IdXzCollege; //学院流水号
objvCoursewareResCaseENT.CollegeID = objvCoursewareResCaseENS.CollegeID; //学院ID
objvCoursewareResCaseENT.CollegeName = objvCoursewareResCaseENS.CollegeName; //学院名称
objvCoursewareResCaseENT.CollegeNameA = objvCoursewareResCaseENS.CollegeNameA; //学院名称简写
objvCoursewareResCaseENT.IdXzMajor = objvCoursewareResCaseENS.IdXzMajor; //专业流水号
objvCoursewareResCaseENT.MajorID = objvCoursewareResCaseENS.MajorID; //专业ID
objvCoursewareResCaseENT.MajorName = objvCoursewareResCaseENS.MajorName; //专业名称
objvCoursewareResCaseENT.CourseChapterId = objvCoursewareResCaseENS.CourseChapterId; //课程章节ID
objvCoursewareResCaseENT.CourseChapterName = objvCoursewareResCaseENS.CourseChapterName; //课程章节名称
objvCoursewareResCaseENT.ParentNodeID = objvCoursewareResCaseENS.ParentNodeID; //父节点编号
objvCoursewareResCaseENT.ParentNodeName = objvCoursewareResCaseENS.ParentNodeName; //父节点名称
objvCoursewareResCaseENT.ViewCount = objvCoursewareResCaseENS.ViewCount; //浏览量
objvCoursewareResCaseENT.IsShow = objvCoursewareResCaseENS.IsShow; //是否启用
objvCoursewareResCaseENT.DownloadNumber = objvCoursewareResCaseENS.DownloadNumber; //下载数目
objvCoursewareResCaseENT.FileIntegration = objvCoursewareResCaseENS.FileIntegration; //文件积分
objvCoursewareResCaseENT.LikeCount = objvCoursewareResCaseENS.LikeCount; //资源喜欢数量
objvCoursewareResCaseENT.CollectionCount = objvCoursewareResCaseENS.CollectionCount; //收藏数量
objvCoursewareResCaseENT.RecommendedDegreeId = objvCoursewareResCaseENS.RecommendedDegreeId; //推荐度Id
objvCoursewareResCaseENT.RecommendedDegreeName = objvCoursewareResCaseENS.RecommendedDegreeName; //推荐度名称
objvCoursewareResCaseENT.ftpFileType = objvCoursewareResCaseENS.ftpFileType; //ftp文件类型
objvCoursewareResCaseENT.CourseId = objvCoursewareResCaseENS.CourseId; //课程Id
objvCoursewareResCaseENT.CourseCode = objvCoursewareResCaseENS.CourseCode; //课程代码
objvCoursewareResCaseENT.CourseName = objvCoursewareResCaseENS.CourseName; //课程名称
objvCoursewareResCaseENT.VideoUrl = objvCoursewareResCaseENS.VideoUrl; //视频Url
objvCoursewareResCaseENT.VideoPath = objvCoursewareResCaseENS.VideoPath; //视频目录
objvCoursewareResCaseENT.ResErrMsg = objvCoursewareResCaseENS.ResErrMsg; //资源错误信息
objvCoursewareResCaseENT.UpdDate = objvCoursewareResCaseENS.UpdDate; //修改日期
objvCoursewareResCaseENT.UpdUserId = objvCoursewareResCaseENS.UpdUserId; //修改用户Id
objvCoursewareResCaseENT.Memo = objvCoursewareResCaseENS.Memo; //备注
objvCoursewareResCaseENT.OwnerNameWithId = objvCoursewareResCaseENS.OwnerNameWithId; //拥有者名称附Id
objvCoursewareResCaseENT.OwnerName = objvCoursewareResCaseENS.OwnerName; //拥有者姓名
objvCoursewareResCaseENT.BrowseCount4Case = objvCoursewareResCaseENS.BrowseCount4Case; //课例浏览次数
objvCoursewareResCaseENT.IsHaveVideo = objvCoursewareResCaseENS.IsHaveVideo; //IsHaveVideo
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvCoursewareResCaseEN objvCoursewareResCaseEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvCoursewareResCaseEN.IdCoursewareResCase, 8, convCoursewareResCase.IdCoursewareResCase);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseEN.CoursewareResCaseID, 8, convCoursewareResCase.CoursewareResCaseID);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseEN.CoursewareResCaseName, 100, convCoursewareResCase.CoursewareResCaseName);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseEN.CoursewareResCaseTheme, 200, convCoursewareResCase.CoursewareResCaseTheme);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseEN.CoursewareResCaseText, 8000, convCoursewareResCase.CoursewareResCaseText);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseEN.IdCoursewareResCaseType, 4, convCoursewareResCase.IdCoursewareResCaseType);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseEN.CoursewareResCaseTypeName, 30, convCoursewareResCase.CoursewareResCaseTypeName);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseEN.CoursewareResCaseDate, 8, convCoursewareResCase.CoursewareResCaseDate);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseEN.CoursewareResCaseTime, 6, convCoursewareResCase.CoursewareResCaseTime);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseEN.CoursewareResCaseDateIn, 8, convCoursewareResCase.CoursewareResCaseDateIn);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseEN.CoursewareResCaseTimeIn, 6, convCoursewareResCase.CoursewareResCaseTimeIn);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseEN.OwnerId, 20, convCoursewareResCase.OwnerId);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseEN.IdStudyLevel, 4, convCoursewareResCase.IdStudyLevel);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseEN.StudyLevelName, 50, convCoursewareResCase.StudyLevelName);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseEN.IdTeachingPlan, 8, convCoursewareResCase.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseEN.IdDiscipline, 4, convCoursewareResCase.IdDiscipline);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseEN.DisciplineID, 4, convCoursewareResCase.DisciplineID);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseEN.DisciplineName, 50, convCoursewareResCase.DisciplineName);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseEN.IdSenateGaugeVersion, 4, convCoursewareResCase.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseEN.senateGaugeVersionID, 4, convCoursewareResCase.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseEN.senateGaugeVersionName, 200, convCoursewareResCase.senateGaugeVersionName);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseEN.IdTeachSkill, 8, convCoursewareResCase.IdTeachSkill);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseEN.TeachSkillID, 8, convCoursewareResCase.TeachSkillID);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseEN.SkillTypeName, 50, convCoursewareResCase.SkillTypeName);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseEN.TeachSkillName, 50, convCoursewareResCase.TeachSkillName);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseEN.TeachSkillTheory, 8000, convCoursewareResCase.TeachSkillTheory);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseEN.TeachSkillOperMethod, 2000, convCoursewareResCase.TeachSkillOperMethod);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseEN.IdSkillType, 4, convCoursewareResCase.IdSkillType);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseEN.SkillTypeID, 4, convCoursewareResCase.SkillTypeID);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseEN.CaseLevelId, 2, convCoursewareResCase.CaseLevelId);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseEN.CaseLevelName, 30, convCoursewareResCase.CaseLevelName);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseEN.DocFile, 200, convCoursewareResCase.DocFile);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseEN.WordCreateDate, 14, convCoursewareResCase.WordCreateDate);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseEN.IdXzCollege, 4, convCoursewareResCase.IdXzCollege);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseEN.CollegeID, 4, convCoursewareResCase.CollegeID);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseEN.CollegeName, 100, convCoursewareResCase.CollegeName);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseEN.CollegeNameA, 12, convCoursewareResCase.CollegeNameA);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseEN.IdXzMajor, 8, convCoursewareResCase.IdXzMajor);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseEN.MajorID, 4, convCoursewareResCase.MajorID);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseEN.MajorName, 100, convCoursewareResCase.MajorName);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseEN.CourseChapterId, 8, convCoursewareResCase.CourseChapterId);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseEN.CourseChapterName, 100, convCoursewareResCase.CourseChapterName);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseEN.ParentNodeID, 8, convCoursewareResCase.ParentNodeID);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseEN.ParentNodeName, 50, convCoursewareResCase.ParentNodeName);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseEN.RecommendedDegreeId, 2, convCoursewareResCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseEN.RecommendedDegreeName, 30, convCoursewareResCase.RecommendedDegreeName);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseEN.ftpFileType, 30, convCoursewareResCase.ftpFileType);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseEN.CourseId, 8, convCoursewareResCase.CourseId);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseEN.CourseCode, 20, convCoursewareResCase.CourseCode);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseEN.CourseName, 100, convCoursewareResCase.CourseName);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseEN.VideoUrl, 1000, convCoursewareResCase.VideoUrl);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseEN.VideoPath, 1000, convCoursewareResCase.VideoPath);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseEN.ResErrMsg, 30, convCoursewareResCase.ResErrMsg);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseEN.UpdDate, 20, convCoursewareResCase.UpdDate);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseEN.UpdUserId, 20, convCoursewareResCase.UpdUserId);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseEN.Memo, 1000, convCoursewareResCase.Memo);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseEN.OwnerNameWithId, 51, convCoursewareResCase.OwnerNameWithId);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseEN.OwnerName, 30, convCoursewareResCase.OwnerName);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseEN.IsHaveVideo, 6, convCoursewareResCase.IsHaveVideo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseEN.IdCoursewareResCase, convCoursewareResCase.IdCoursewareResCase);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseEN.CoursewareResCaseID, convCoursewareResCase.CoursewareResCaseID);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseEN.CoursewareResCaseName, convCoursewareResCase.CoursewareResCaseName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseEN.CoursewareResCaseTheme, convCoursewareResCase.CoursewareResCaseTheme);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseEN.CoursewareResCaseText, convCoursewareResCase.CoursewareResCaseText);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseEN.IdCoursewareResCaseType, convCoursewareResCase.IdCoursewareResCaseType);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseEN.CoursewareResCaseTypeName, convCoursewareResCase.CoursewareResCaseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseEN.CoursewareResCaseDate, convCoursewareResCase.CoursewareResCaseDate);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseEN.CoursewareResCaseTime, convCoursewareResCase.CoursewareResCaseTime);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseEN.CoursewareResCaseDateIn, convCoursewareResCase.CoursewareResCaseDateIn);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseEN.CoursewareResCaseTimeIn, convCoursewareResCase.CoursewareResCaseTimeIn);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseEN.OwnerId, convCoursewareResCase.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseEN.IdStudyLevel, convCoursewareResCase.IdStudyLevel);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseEN.StudyLevelName, convCoursewareResCase.StudyLevelName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseEN.IdTeachingPlan, convCoursewareResCase.IdTeachingPlan);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseEN.IdDiscipline, convCoursewareResCase.IdDiscipline);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseEN.DisciplineID, convCoursewareResCase.DisciplineID);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseEN.DisciplineName, convCoursewareResCase.DisciplineName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseEN.IdSenateGaugeVersion, convCoursewareResCase.IdSenateGaugeVersion);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseEN.senateGaugeVersionID, convCoursewareResCase.senateGaugeVersionID);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseEN.senateGaugeVersionName, convCoursewareResCase.senateGaugeVersionName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseEN.IdTeachSkill, convCoursewareResCase.IdTeachSkill);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseEN.TeachSkillID, convCoursewareResCase.TeachSkillID);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseEN.SkillTypeName, convCoursewareResCase.SkillTypeName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseEN.TeachSkillName, convCoursewareResCase.TeachSkillName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseEN.TeachSkillTheory, convCoursewareResCase.TeachSkillTheory);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseEN.TeachSkillOperMethod, convCoursewareResCase.TeachSkillOperMethod);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseEN.IdSkillType, convCoursewareResCase.IdSkillType);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseEN.SkillTypeID, convCoursewareResCase.SkillTypeID);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseEN.CaseLevelId, convCoursewareResCase.CaseLevelId);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseEN.CaseLevelName, convCoursewareResCase.CaseLevelName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseEN.DocFile, convCoursewareResCase.DocFile);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseEN.WordCreateDate, convCoursewareResCase.WordCreateDate);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseEN.IdXzCollege, convCoursewareResCase.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseEN.CollegeID, convCoursewareResCase.CollegeID);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseEN.CollegeName, convCoursewareResCase.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseEN.CollegeNameA, convCoursewareResCase.CollegeNameA);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseEN.IdXzMajor, convCoursewareResCase.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseEN.MajorID, convCoursewareResCase.MajorID);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseEN.MajorName, convCoursewareResCase.MajorName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseEN.CourseChapterId, convCoursewareResCase.CourseChapterId);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseEN.CourseChapterName, convCoursewareResCase.CourseChapterName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseEN.ParentNodeID, convCoursewareResCase.ParentNodeID);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseEN.ParentNodeName, convCoursewareResCase.ParentNodeName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseEN.RecommendedDegreeId, convCoursewareResCase.RecommendedDegreeId);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseEN.RecommendedDegreeName, convCoursewareResCase.RecommendedDegreeName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseEN.ftpFileType, convCoursewareResCase.ftpFileType);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseEN.CourseId, convCoursewareResCase.CourseId);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseEN.CourseCode, convCoursewareResCase.CourseCode);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseEN.CourseName, convCoursewareResCase.CourseName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseEN.VideoUrl, convCoursewareResCase.VideoUrl);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseEN.VideoPath, convCoursewareResCase.VideoPath);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseEN.ResErrMsg, convCoursewareResCase.ResErrMsg);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseEN.UpdDate, convCoursewareResCase.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseEN.UpdUserId, convCoursewareResCase.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseEN.Memo, convCoursewareResCase.Memo);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseEN.OwnerNameWithId, convCoursewareResCase.OwnerNameWithId);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseEN.OwnerName, convCoursewareResCase.OwnerName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseEN.IsHaveVideo, convCoursewareResCase.IsHaveVideo);
//检查外键字段长度
 objvCoursewareResCaseEN._IsCheckProperty = true;
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
 objSQL = clsvCoursewareResCaseDA.GetSpecSQLObj();
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
 objSQL = clsvCoursewareResCaseDA.GetSpecSQLObj();
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
 objSQL = clsvCoursewareResCaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCoursewareResCaseEN._CurrTabName);
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
 objSQL = clsvCoursewareResCaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCoursewareResCaseEN._CurrTabName, strCondition);
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
 objSQL = clsvCoursewareResCaseDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}