
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCourseLearningCaseQuantitySenateDA
 表名:vCourseLearningCaseQuantitySenate(01120455)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:45:51
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程学习(CourseLearning)
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
 /// v课程学习案例资源量化评议(vCourseLearningCaseQuantitySenate)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvCourseLearningCaseQuantitySenateDA : clsCommBase4DA
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
 return clsvCourseLearningCaseQuantitySenateEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvCourseLearningCaseQuantitySenateEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCourseLearningCaseQuantitySenateEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvCourseLearningCaseQuantitySenateEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvCourseLearningCaseQuantitySenateEN._ConnectString);
 }
 return objSQL;
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvCourseLearningCaseQuantitySenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vCourseLearningCaseQuantitySenate where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vCourseLearningCaseQuantitySenate(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvCourseLearningCaseQuantitySenateDA: GetDataTable_vCourseLearningCaseQuantitySenate)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vCourseLearningCaseQuantitySenate where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvCourseLearningCaseQuantitySenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCaseQuantitySenateDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvCourseLearningCaseQuantitySenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vCourseLearningCaseQuantitySenate where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvCourseLearningCaseQuantitySenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCaseQuantitySenateDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvCourseLearningCaseQuantitySenateDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCaseQuantitySenateDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCourseLearningCaseQuantitySenate where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCourseLearningCaseQuantitySenate where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvCourseLearningCaseQuantitySenateDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCaseQuantitySenateDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vCourseLearningCaseQuantitySenate where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvCourseLearningCaseQuantitySenateDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCaseQuantitySenateDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vCourseLearningCaseQuantitySenate.* from vCourseLearningCaseQuantitySenate Left Join {1} on {2} where {3} and vCourseLearningCaseQuantitySenate.IdmicroteachCaseQuantitySenate not in (Select top {5} vCourseLearningCaseQuantitySenate.IdmicroteachCaseQuantitySenate from vCourseLearningCaseQuantitySenate Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCourseLearningCaseQuantitySenate where {1} and IdmicroteachCaseQuantitySenate not in (Select top {2} IdmicroteachCaseQuantitySenate from vCourseLearningCaseQuantitySenate where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCourseLearningCaseQuantitySenate where {1} and IdmicroteachCaseQuantitySenate not in (Select top {3} IdmicroteachCaseQuantitySenate from vCourseLearningCaseQuantitySenate where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvCourseLearningCaseQuantitySenateDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCaseQuantitySenateDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vCourseLearningCaseQuantitySenate.* from vCourseLearningCaseQuantitySenate Left Join {1} on {2} where {3} and vCourseLearningCaseQuantitySenate.IdmicroteachCaseQuantitySenate not in (Select top {5} vCourseLearningCaseQuantitySenate.IdmicroteachCaseQuantitySenate from vCourseLearningCaseQuantitySenate Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCourseLearningCaseQuantitySenate where {1} and IdmicroteachCaseQuantitySenate not in (Select top {2} IdmicroteachCaseQuantitySenate from vCourseLearningCaseQuantitySenate where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCourseLearningCaseQuantitySenate where {1} and IdmicroteachCaseQuantitySenate not in (Select top {3} IdmicroteachCaseQuantitySenate from vCourseLearningCaseQuantitySenate where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvCourseLearningCaseQuantitySenateEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvCourseLearningCaseQuantitySenateDA:GetObjLst)", objException.Message));
}
List<clsvCourseLearningCaseQuantitySenateEN> arrObjLst = new List<clsvCourseLearningCaseQuantitySenateEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vCourseLearningCaseQuantitySenate where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN = new clsvCourseLearningCaseQuantitySenateEN();
try
{
objvCourseLearningCaseQuantitySenateEN.IdCourseLearningCase = objRow[convCourseLearningCaseQuantitySenate.IdCourseLearningCase] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseID = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseID] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseName = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTheme = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseDate = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTime = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseDateIn = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTypeName = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningCaseQuantitySenateEN.OwnerId = objRow[convCourseLearningCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvCourseLearningCaseQuantitySenateEN.OwnerName = objRow[convCourseLearningCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvCourseLearningCaseQuantitySenateEN.OwnerNameWithId = objRow[convCourseLearningCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCourseLearningCaseQuantitySenateEN.UserNameWithUserId = objRow[convCourseLearningCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvCourseLearningCaseQuantitySenateEN.IsDualVideo = TransNullToBool(objRow[convCourseLearningCaseQuantitySenate.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCaseQuantitySenateEN.IdXzCollege = objRow[convCourseLearningCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCaseQuantitySenateEN.CollegeID = objRow[convCourseLearningCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvCourseLearningCaseQuantitySenateEN.CollegeName = objRow[convCourseLearningCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCaseQuantitySenateEN.IdXzMajor = objRow[convCourseLearningCaseQuantitySenate.IdXzMajor] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningCaseQuantitySenateEN.MajorID = objRow[convCourseLearningCaseQuantitySenate.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCaseQuantitySenateEN.MajorName = objRow[convCourseLearningCaseQuantitySenate.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCaseQuantitySenateEN.CourseId = objRow[convCourseLearningCaseQuantitySenate.CourseId] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCaseQuantitySenateEN.CourseCode = objRow[convCourseLearningCaseQuantitySenate.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCaseQuantitySenateEN.CourseName = objRow[convCourseLearningCaseQuantitySenate.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCaseQuantitySenateEN.ViewCount = objRow[convCourseLearningCaseQuantitySenate.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCaseQuantitySenate.ViewCount].ToString().Trim()); //浏览量
objvCourseLearningCaseQuantitySenateEN.IsShow = TransNullToBool(objRow[convCourseLearningCaseQuantitySenate.IsShow].ToString().Trim()); //是否启用
objvCourseLearningCaseQuantitySenateEN.DownloadNumber = objRow[convCourseLearningCaseQuantitySenate.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCaseQuantitySenate.DownloadNumber].ToString().Trim()); //下载数目
objvCourseLearningCaseQuantitySenateEN.FileIntegration = objRow[convCourseLearningCaseQuantitySenate.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCaseQuantitySenate.FileIntegration].ToString().Trim()); //文件积分
objvCourseLearningCaseQuantitySenateEN.LikeCount = objRow[convCourseLearningCaseQuantitySenate.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCourseLearningCaseQuantitySenate.LikeCount].ToString().Trim()); //资源喜欢数量
objvCourseLearningCaseQuantitySenateEN.CollectionCount = objRow[convCourseLearningCaseQuantitySenate.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCourseLearningCaseQuantitySenate.CollectionCount].ToString().Trim()); //收藏数量
objvCourseLearningCaseQuantitySenateEN.CollegeNameA = objRow[convCourseLearningCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convCourseLearningCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvCourseLearningCaseQuantitySenateEN.FuncModuleId = objRow[convCourseLearningCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningCaseQuantitySenateEN.FuncModuleName = objRow[convCourseLearningCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningCaseQuantitySenateEN.IdMicroteachCase = objRow[convCourseLearningCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCourseLearningCaseQuantitySenateEN.IdAppraiseType = objRow[convCourseLearningCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvCourseLearningCaseQuantitySenateEN.AppraiseTypeName = objRow[convCourseLearningCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvCourseLearningCaseQuantitySenateEN.SenateTheme = objRow[convCourseLearningCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvCourseLearningCaseQuantitySenateEN.SenateContent = objRow[convCourseLearningCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvCourseLearningCaseQuantitySenateEN.SenateTotalScore = TransNullToFloat(objRow[convCourseLearningCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvCourseLearningCaseQuantitySenateEN.SenateDate = objRow[convCourseLearningCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvCourseLearningCaseQuantitySenateEN.SenateTime = objRow[convCourseLearningCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvCourseLearningCaseQuantitySenateEN.SenateIp = objRow[convCourseLearningCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvCourseLearningCaseQuantitySenateEN.BrowseCount = objRow[convCourseLearningCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvCourseLearningCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convCourseLearningCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCourseLearningCaseQuantitySenateEN.senateGaugeVersionID = objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCourseLearningCaseQuantitySenateEN.senateGaugeVersionName = objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCourseLearningCaseQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCourseLearningCaseQuantitySenateEN.UserId = objRow[convCourseLearningCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvCourseLearningCaseQuantitySenateEN.UserName = objRow[convCourseLearningCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvCourseLearningCaseQuantitySenateEN.UserKindId = objRow[convCourseLearningCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvCourseLearningCaseQuantitySenateEN.UserKindName = objRow[convCourseLearningCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvCourseLearningCaseQuantitySenateEN.UpdUser = objRow[convCourseLearningCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvCourseLearningCaseQuantitySenateEN.UpdUserName = objRow[convCourseLearningCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
objvCourseLearningCaseQuantitySenateEN.Memo = objRow[convCourseLearningCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.Memo].ToString().Trim(); //备注
objvCourseLearningCaseQuantitySenateEN.UserTypeName = objRow[convCourseLearningCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCourseLearningCaseQuantitySenateDA: GetObjLst)", objException.Message));
}
objvCourseLearningCaseQuantitySenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCourseLearningCaseQuantitySenateEN);
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
public List<clsvCourseLearningCaseQuantitySenateEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvCourseLearningCaseQuantitySenateDA:GetObjLstByTabName)", objException.Message));
}
List<clsvCourseLearningCaseQuantitySenateEN> arrObjLst = new List<clsvCourseLearningCaseQuantitySenateEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN = new clsvCourseLearningCaseQuantitySenateEN();
try
{
objvCourseLearningCaseQuantitySenateEN.IdCourseLearningCase = objRow[convCourseLearningCaseQuantitySenate.IdCourseLearningCase] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseID = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseID] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseName = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTheme = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseDate = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTime = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseDateIn = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTypeName = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningCaseQuantitySenateEN.OwnerId = objRow[convCourseLearningCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvCourseLearningCaseQuantitySenateEN.OwnerName = objRow[convCourseLearningCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvCourseLearningCaseQuantitySenateEN.OwnerNameWithId = objRow[convCourseLearningCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCourseLearningCaseQuantitySenateEN.UserNameWithUserId = objRow[convCourseLearningCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvCourseLearningCaseQuantitySenateEN.IsDualVideo = TransNullToBool(objRow[convCourseLearningCaseQuantitySenate.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCaseQuantitySenateEN.IdXzCollege = objRow[convCourseLearningCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCaseQuantitySenateEN.CollegeID = objRow[convCourseLearningCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvCourseLearningCaseQuantitySenateEN.CollegeName = objRow[convCourseLearningCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCaseQuantitySenateEN.IdXzMajor = objRow[convCourseLearningCaseQuantitySenate.IdXzMajor] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningCaseQuantitySenateEN.MajorID = objRow[convCourseLearningCaseQuantitySenate.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCaseQuantitySenateEN.MajorName = objRow[convCourseLearningCaseQuantitySenate.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCaseQuantitySenateEN.CourseId = objRow[convCourseLearningCaseQuantitySenate.CourseId] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCaseQuantitySenateEN.CourseCode = objRow[convCourseLearningCaseQuantitySenate.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCaseQuantitySenateEN.CourseName = objRow[convCourseLearningCaseQuantitySenate.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCaseQuantitySenateEN.ViewCount = objRow[convCourseLearningCaseQuantitySenate.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCaseQuantitySenate.ViewCount].ToString().Trim()); //浏览量
objvCourseLearningCaseQuantitySenateEN.IsShow = TransNullToBool(objRow[convCourseLearningCaseQuantitySenate.IsShow].ToString().Trim()); //是否启用
objvCourseLearningCaseQuantitySenateEN.DownloadNumber = objRow[convCourseLearningCaseQuantitySenate.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCaseQuantitySenate.DownloadNumber].ToString().Trim()); //下载数目
objvCourseLearningCaseQuantitySenateEN.FileIntegration = objRow[convCourseLearningCaseQuantitySenate.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCaseQuantitySenate.FileIntegration].ToString().Trim()); //文件积分
objvCourseLearningCaseQuantitySenateEN.LikeCount = objRow[convCourseLearningCaseQuantitySenate.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCourseLearningCaseQuantitySenate.LikeCount].ToString().Trim()); //资源喜欢数量
objvCourseLearningCaseQuantitySenateEN.CollectionCount = objRow[convCourseLearningCaseQuantitySenate.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCourseLearningCaseQuantitySenate.CollectionCount].ToString().Trim()); //收藏数量
objvCourseLearningCaseQuantitySenateEN.CollegeNameA = objRow[convCourseLearningCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convCourseLearningCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvCourseLearningCaseQuantitySenateEN.FuncModuleId = objRow[convCourseLearningCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningCaseQuantitySenateEN.FuncModuleName = objRow[convCourseLearningCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningCaseQuantitySenateEN.IdMicroteachCase = objRow[convCourseLearningCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCourseLearningCaseQuantitySenateEN.IdAppraiseType = objRow[convCourseLearningCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvCourseLearningCaseQuantitySenateEN.AppraiseTypeName = objRow[convCourseLearningCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvCourseLearningCaseQuantitySenateEN.SenateTheme = objRow[convCourseLearningCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvCourseLearningCaseQuantitySenateEN.SenateContent = objRow[convCourseLearningCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvCourseLearningCaseQuantitySenateEN.SenateTotalScore = TransNullToFloat(objRow[convCourseLearningCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvCourseLearningCaseQuantitySenateEN.SenateDate = objRow[convCourseLearningCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvCourseLearningCaseQuantitySenateEN.SenateTime = objRow[convCourseLearningCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvCourseLearningCaseQuantitySenateEN.SenateIp = objRow[convCourseLearningCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvCourseLearningCaseQuantitySenateEN.BrowseCount = objRow[convCourseLearningCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvCourseLearningCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convCourseLearningCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCourseLearningCaseQuantitySenateEN.senateGaugeVersionID = objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCourseLearningCaseQuantitySenateEN.senateGaugeVersionName = objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCourseLearningCaseQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCourseLearningCaseQuantitySenateEN.UserId = objRow[convCourseLearningCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvCourseLearningCaseQuantitySenateEN.UserName = objRow[convCourseLearningCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvCourseLearningCaseQuantitySenateEN.UserKindId = objRow[convCourseLearningCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvCourseLearningCaseQuantitySenateEN.UserKindName = objRow[convCourseLearningCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvCourseLearningCaseQuantitySenateEN.UpdUser = objRow[convCourseLearningCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvCourseLearningCaseQuantitySenateEN.UpdUserName = objRow[convCourseLearningCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
objvCourseLearningCaseQuantitySenateEN.Memo = objRow[convCourseLearningCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.Memo].ToString().Trim(); //备注
objvCourseLearningCaseQuantitySenateEN.UserTypeName = objRow[convCourseLearningCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCourseLearningCaseQuantitySenateDA: GetObjLst)", objException.Message));
}
objvCourseLearningCaseQuantitySenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCourseLearningCaseQuantitySenateEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvCourseLearningCaseQuantitySenate(ref clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vCourseLearningCaseQuantitySenate where IdmicroteachCaseQuantitySenate = " + ""+ objvCourseLearningCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvCourseLearningCaseQuantitySenateEN.IdCourseLearningCase = objDT.Rows[0][convCourseLearningCaseQuantitySenate.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseID = objDT.Rows[0][convCourseLearningCaseQuantitySenate.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseName = objDT.Rows[0][convCourseLearningCaseQuantitySenate.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTheme = objDT.Rows[0][convCourseLearningCaseQuantitySenate.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseDate = objDT.Rows[0][convCourseLearningCaseQuantitySenate.CourseLearningCaseDate].ToString().Trim(); //课程学习日期(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTime = objDT.Rows[0][convCourseLearningCaseQuantitySenate.CourseLearningCaseTime].ToString().Trim(); //课程学习时间(字段类型:char,字段长度:6,是否可空:True)
 objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseDateIn = objDT.Rows[0][convCourseLearningCaseQuantitySenate.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTimeIn = objDT.Rows[0][convCourseLearningCaseQuantitySenate.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTypeName = objDT.Rows[0][convCourseLearningCaseQuantitySenate.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCourseLearningCaseQuantitySenateEN.OwnerId = objDT.Rows[0][convCourseLearningCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvCourseLearningCaseQuantitySenateEN.OwnerName = objDT.Rows[0][convCourseLearningCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvCourseLearningCaseQuantitySenateEN.OwnerNameWithId = objDT.Rows[0][convCourseLearningCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
 objvCourseLearningCaseQuantitySenateEN.UserNameWithUserId = objDT.Rows[0][convCourseLearningCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId(字段类型:varchar,字段长度:51,是否可空:False)
 objvCourseLearningCaseQuantitySenateEN.IsDualVideo = TransNullToBool(objDT.Rows[0][convCourseLearningCaseQuantitySenate.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvCourseLearningCaseQuantitySenateEN.IdXzCollege = objDT.Rows[0][convCourseLearningCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvCourseLearningCaseQuantitySenateEN.CollegeID = objDT.Rows[0][convCourseLearningCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvCourseLearningCaseQuantitySenateEN.CollegeName = objDT.Rows[0][convCourseLearningCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCourseLearningCaseQuantitySenateEN.IdXzMajor = objDT.Rows[0][convCourseLearningCaseQuantitySenate.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCaseQuantitySenateEN.MajorID = objDT.Rows[0][convCourseLearningCaseQuantitySenate.MajorID].ToString().Trim(); //专业ID(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCaseQuantitySenateEN.MajorName = objDT.Rows[0][convCourseLearningCaseQuantitySenate.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCourseLearningCaseQuantitySenateEN.CourseId = objDT.Rows[0][convCourseLearningCaseQuantitySenate.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningCaseQuantitySenateEN.CourseCode = objDT.Rows[0][convCourseLearningCaseQuantitySenate.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvCourseLearningCaseQuantitySenateEN.CourseName = objDT.Rows[0][convCourseLearningCaseQuantitySenate.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvCourseLearningCaseQuantitySenateEN.ViewCount = TransNullToInt(objDT.Rows[0][convCourseLearningCaseQuantitySenate.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvCourseLearningCaseQuantitySenateEN.IsShow = TransNullToBool(objDT.Rows[0][convCourseLearningCaseQuantitySenate.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objvCourseLearningCaseQuantitySenateEN.DownloadNumber = TransNullToInt(objDT.Rows[0][convCourseLearningCaseQuantitySenate.DownloadNumber].ToString().Trim()); //下载数目(字段类型:int,字段长度:4,是否可空:True)
 objvCourseLearningCaseQuantitySenateEN.FileIntegration = TransNullToInt(objDT.Rows[0][convCourseLearningCaseQuantitySenate.FileIntegration].ToString().Trim()); //文件积分(字段类型:int,字段长度:4,是否可空:True)
 objvCourseLearningCaseQuantitySenateEN.LikeCount = TransNullToInt(objDT.Rows[0][convCourseLearningCaseQuantitySenate.LikeCount].ToString().Trim()); //资源喜欢数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvCourseLearningCaseQuantitySenateEN.CollectionCount = TransNullToInt(objDT.Rows[0][convCourseLearningCaseQuantitySenate.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvCourseLearningCaseQuantitySenateEN.CollegeNameA = objDT.Rows[0][convCourseLearningCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvCourseLearningCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objDT.Rows[0][convCourseLearningCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvCourseLearningCaseQuantitySenateEN.FuncModuleId = objDT.Rows[0][convCourseLearningCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvCourseLearningCaseQuantitySenateEN.FuncModuleName = objDT.Rows[0][convCourseLearningCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCourseLearningCaseQuantitySenateEN.IdMicroteachCase = objDT.Rows[0][convCourseLearningCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCaseQuantitySenateEN.IdAppraiseType = objDT.Rows[0][convCourseLearningCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCaseQuantitySenateEN.AppraiseTypeName = objDT.Rows[0][convCourseLearningCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCourseLearningCaseQuantitySenateEN.SenateTheme = objDT.Rows[0][convCourseLearningCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题(字段类型:varchar,字段长度:200,是否可空:True)
 objvCourseLearningCaseQuantitySenateEN.SenateContent = objDT.Rows[0][convCourseLearningCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvCourseLearningCaseQuantitySenateEN.SenateTotalScore = TransNullToFloat(objDT.Rows[0][convCourseLearningCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数(字段类型:float,字段长度:8,是否可空:False)
 objvCourseLearningCaseQuantitySenateEN.SenateDate = objDT.Rows[0][convCourseLearningCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningCaseQuantitySenateEN.SenateTime = objDT.Rows[0][convCourseLearningCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间(字段类型:char,字段长度:6,是否可空:True)
 objvCourseLearningCaseQuantitySenateEN.SenateIp = objDT.Rows[0][convCourseLearningCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip(字段类型:varchar,字段长度:50,是否可空:True)
 objvCourseLearningCaseQuantitySenateEN.BrowseCount = TransNullToInt(objDT.Rows[0][convCourseLearningCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvCourseLearningCaseQuantitySenateEN.IdSenateGaugeVersion = objDT.Rows[0][convCourseLearningCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCaseQuantitySenateEN.senateGaugeVersionID = objDT.Rows[0][convCourseLearningCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCaseQuantitySenateEN.senateGaugeVersionName = objDT.Rows[0][convCourseLearningCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvCourseLearningCaseQuantitySenateEN.senateGaugeVersionTtlScore = TransNullToFloat(objDT.Rows[0][convCourseLearningCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvCourseLearningCaseQuantitySenateEN.UserId = objDT.Rows[0][convCourseLearningCaseQuantitySenate.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvCourseLearningCaseQuantitySenateEN.UserName = objDT.Rows[0][convCourseLearningCaseQuantitySenate.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvCourseLearningCaseQuantitySenateEN.UserKindId = objDT.Rows[0][convCourseLearningCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id(字段类型:char,字段长度:2,是否可空:False)
 objvCourseLearningCaseQuantitySenateEN.UserKindName = objDT.Rows[0][convCourseLearningCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名(字段类型:varchar,字段长度:30,是否可空:False)
 objvCourseLearningCaseQuantitySenateEN.UpdUser = objDT.Rows[0][convCourseLearningCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvCourseLearningCaseQuantitySenateEN.UpdUserName = objDT.Rows[0][convCourseLearningCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName(字段类型:varchar,字段长度:20,是否可空:True)
 objvCourseLearningCaseQuantitySenateEN.Memo = objDT.Rows[0][convCourseLearningCaseQuantitySenate.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCourseLearningCaseQuantitySenateEN.UserTypeName = objDT.Rows[0][convCourseLearningCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称(字段类型:varchar,字段长度:20,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvCourseLearningCaseQuantitySenateDA: GetvCourseLearningCaseQuantitySenate)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdmicroteachCaseQuantitySenate">表关键字</param>
 /// <returns>表对象</returns>
public clsvCourseLearningCaseQuantitySenateEN GetObjByIdmicroteachCaseQuantitySenate(long lngIdmicroteachCaseQuantitySenate)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vCourseLearningCaseQuantitySenate where IdmicroteachCaseQuantitySenate = " + ""+ lngIdmicroteachCaseQuantitySenate+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN = new clsvCourseLearningCaseQuantitySenateEN();
try
{
 objvCourseLearningCaseQuantitySenateEN.IdCourseLearningCase = objRow[convCourseLearningCaseQuantitySenate.IdCourseLearningCase] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseID = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseID] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseName = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTheme = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseDate = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseDate].ToString().Trim(); //课程学习日期(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTime = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTime].ToString().Trim(); //课程学习时间(字段类型:char,字段长度:6,是否可空:True)
 objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseDateIn = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTypeName = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCourseLearningCaseQuantitySenateEN.OwnerId = objRow[convCourseLearningCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvCourseLearningCaseQuantitySenateEN.OwnerName = objRow[convCourseLearningCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvCourseLearningCaseQuantitySenateEN.OwnerNameWithId = objRow[convCourseLearningCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
 objvCourseLearningCaseQuantitySenateEN.UserNameWithUserId = objRow[convCourseLearningCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId(字段类型:varchar,字段长度:51,是否可空:False)
 objvCourseLearningCaseQuantitySenateEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseQuantitySenate.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvCourseLearningCaseQuantitySenateEN.IdXzCollege = objRow[convCourseLearningCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvCourseLearningCaseQuantitySenateEN.CollegeID = objRow[convCourseLearningCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvCourseLearningCaseQuantitySenateEN.CollegeName = objRow[convCourseLearningCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCourseLearningCaseQuantitySenateEN.IdXzMajor = objRow[convCourseLearningCaseQuantitySenate.IdXzMajor] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCaseQuantitySenateEN.MajorID = objRow[convCourseLearningCaseQuantitySenate.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.MajorID].ToString().Trim(); //专业ID(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCaseQuantitySenateEN.MajorName = objRow[convCourseLearningCaseQuantitySenate.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCourseLearningCaseQuantitySenateEN.CourseId = objRow[convCourseLearningCaseQuantitySenate.CourseId] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningCaseQuantitySenateEN.CourseCode = objRow[convCourseLearningCaseQuantitySenate.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvCourseLearningCaseQuantitySenateEN.CourseName = objRow[convCourseLearningCaseQuantitySenate.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvCourseLearningCaseQuantitySenateEN.ViewCount = objRow[convCourseLearningCaseQuantitySenate.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseQuantitySenate.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvCourseLearningCaseQuantitySenateEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseQuantitySenate.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objvCourseLearningCaseQuantitySenateEN.DownloadNumber = objRow[convCourseLearningCaseQuantitySenate.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseQuantitySenate.DownloadNumber].ToString().Trim()); //下载数目(字段类型:int,字段长度:4,是否可空:True)
 objvCourseLearningCaseQuantitySenateEN.FileIntegration = objRow[convCourseLearningCaseQuantitySenate.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseQuantitySenate.FileIntegration].ToString().Trim()); //文件积分(字段类型:int,字段长度:4,是否可空:True)
 objvCourseLearningCaseQuantitySenateEN.LikeCount = objRow[convCourseLearningCaseQuantitySenate.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseQuantitySenate.LikeCount].ToString().Trim()); //资源喜欢数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvCourseLearningCaseQuantitySenateEN.CollectionCount = objRow[convCourseLearningCaseQuantitySenate.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseQuantitySenate.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvCourseLearningCaseQuantitySenateEN.CollegeNameA = objRow[convCourseLearningCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvCourseLearningCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convCourseLearningCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvCourseLearningCaseQuantitySenateEN.FuncModuleId = objRow[convCourseLearningCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvCourseLearningCaseQuantitySenateEN.FuncModuleName = objRow[convCourseLearningCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCourseLearningCaseQuantitySenateEN.IdMicroteachCase = objRow[convCourseLearningCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCaseQuantitySenateEN.IdAppraiseType = objRow[convCourseLearningCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCaseQuantitySenateEN.AppraiseTypeName = objRow[convCourseLearningCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCourseLearningCaseQuantitySenateEN.SenateTheme = objRow[convCourseLearningCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题(字段类型:varchar,字段长度:200,是否可空:True)
 objvCourseLearningCaseQuantitySenateEN.SenateContent = objRow[convCourseLearningCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvCourseLearningCaseQuantitySenateEN.SenateTotalScore = Single.Parse(objRow[convCourseLearningCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数(字段类型:float,字段长度:8,是否可空:False)
 objvCourseLearningCaseQuantitySenateEN.SenateDate = objRow[convCourseLearningCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningCaseQuantitySenateEN.SenateTime = objRow[convCourseLearningCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间(字段类型:char,字段长度:6,是否可空:True)
 objvCourseLearningCaseQuantitySenateEN.SenateIp = objRow[convCourseLearningCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip(字段类型:varchar,字段长度:50,是否可空:True)
 objvCourseLearningCaseQuantitySenateEN.BrowseCount = objRow[convCourseLearningCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvCourseLearningCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convCourseLearningCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCaseQuantitySenateEN.senateGaugeVersionID = objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCaseQuantitySenateEN.senateGaugeVersionName = objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvCourseLearningCaseQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvCourseLearningCaseQuantitySenateEN.UserId = objRow[convCourseLearningCaseQuantitySenate.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvCourseLearningCaseQuantitySenateEN.UserName = objRow[convCourseLearningCaseQuantitySenate.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvCourseLearningCaseQuantitySenateEN.UserKindId = objRow[convCourseLearningCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id(字段类型:char,字段长度:2,是否可空:False)
 objvCourseLearningCaseQuantitySenateEN.UserKindName = objRow[convCourseLearningCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名(字段类型:varchar,字段长度:30,是否可空:False)
 objvCourseLearningCaseQuantitySenateEN.UpdUser = objRow[convCourseLearningCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvCourseLearningCaseQuantitySenateEN.UpdUserName = objRow[convCourseLearningCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName(字段类型:varchar,字段长度:20,是否可空:True)
 objvCourseLearningCaseQuantitySenateEN.Memo = objRow[convCourseLearningCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCourseLearningCaseQuantitySenateEN.UserTypeName = objRow[convCourseLearningCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称(字段类型:varchar,字段长度:20,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvCourseLearningCaseQuantitySenateDA: GetObjByIdmicroteachCaseQuantitySenate)", objException.Message));
}
return objvCourseLearningCaseQuantitySenateEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvCourseLearningCaseQuantitySenateEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvCourseLearningCaseQuantitySenateDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vCourseLearningCaseQuantitySenate where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN = new clsvCourseLearningCaseQuantitySenateEN()
{
IdCourseLearningCase = objRow[convCourseLearningCaseQuantitySenate.IdCourseLearningCase] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.IdCourseLearningCase].ToString().Trim(), //课程学习案例流水号
CourseLearningCaseID = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseID] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseID].ToString().Trim(), //课程学习案例ID
CourseLearningCaseName = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseName].ToString().Trim(), //课程学习案例名称
CourseLearningCaseTheme = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTheme].ToString().Trim(), //课程学习案例主题词
CourseLearningCaseDate = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseDate].ToString().Trim(), //课程学习日期
CourseLearningCaseTime = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTime].ToString().Trim(), //课程学习时间
CourseLearningCaseDateIn = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseDateIn].ToString().Trim(), //案例入库日期
CourseLearningCaseTimeIn = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTimeIn].ToString().Trim(), //案例入库时间
CourseLearningCaseTypeName = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTypeName].ToString().Trim(), //课程学习案例类型名称
OwnerId = objRow[convCourseLearningCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.OwnerId].ToString().Trim(), //拥有者Id
OwnerName = objRow[convCourseLearningCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.OwnerName].ToString().Trim(), //拥有者姓名
OwnerNameWithId = objRow[convCourseLearningCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.OwnerNameWithId].ToString().Trim(), //拥有者名称附Id
UserNameWithUserId = objRow[convCourseLearningCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UserNameWithUserId].ToString().Trim(), //UserNameWithUserId
IsDualVideo = TransNullToBool(objRow[convCourseLearningCaseQuantitySenate.IsDualVideo].ToString().Trim()), //是否双视频
IdXzCollege = objRow[convCourseLearningCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.IdXzCollege].ToString().Trim(), //学院流水号
CollegeID = objRow[convCourseLearningCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CollegeID].ToString().Trim(), //学院ID
CollegeName = objRow[convCourseLearningCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CollegeName].ToString().Trim(), //学院名称
IdXzMajor = objRow[convCourseLearningCaseQuantitySenate.IdXzMajor] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.IdXzMajor].ToString().Trim(), //专业流水号
MajorID = objRow[convCourseLearningCaseQuantitySenate.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.MajorID].ToString().Trim(), //专业ID
MajorName = objRow[convCourseLearningCaseQuantitySenate.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.MajorName].ToString().Trim(), //专业名称
CourseId = objRow[convCourseLearningCaseQuantitySenate.CourseId] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseId].ToString().Trim(), //课程Id
CourseCode = objRow[convCourseLearningCaseQuantitySenate.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseCode].ToString().Trim(), //课程代码
CourseName = objRow[convCourseLearningCaseQuantitySenate.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseName].ToString().Trim(), //课程名称
ViewCount = objRow[convCourseLearningCaseQuantitySenate.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCaseQuantitySenate.ViewCount].ToString().Trim()), //浏览量
IsShow = TransNullToBool(objRow[convCourseLearningCaseQuantitySenate.IsShow].ToString().Trim()), //是否启用
DownloadNumber = objRow[convCourseLearningCaseQuantitySenate.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCaseQuantitySenate.DownloadNumber].ToString().Trim()), //下载数目
FileIntegration = objRow[convCourseLearningCaseQuantitySenate.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCaseQuantitySenate.FileIntegration].ToString().Trim()), //文件积分
LikeCount = objRow[convCourseLearningCaseQuantitySenate.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCourseLearningCaseQuantitySenate.LikeCount].ToString().Trim()), //资源喜欢数量
CollectionCount = objRow[convCourseLearningCaseQuantitySenate.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCourseLearningCaseQuantitySenate.CollectionCount].ToString().Trim()), //收藏数量
CollegeNameA = objRow[convCourseLearningCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CollegeNameA].ToString().Trim(), //学院名称简写
IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convCourseLearningCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()), //微格量化评价流水号
FuncModuleId = objRow[convCourseLearningCaseQuantitySenate.FuncModuleId].ToString().Trim(), //功能模块Id
FuncModuleName = objRow[convCourseLearningCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.FuncModuleName].ToString().Trim(), //功能模块名称
IdMicroteachCase = objRow[convCourseLearningCaseQuantitySenate.IdMicroteachCase].ToString().Trim(), //微格教学案例流水号
IdAppraiseType = objRow[convCourseLearningCaseQuantitySenate.IdAppraiseType].ToString().Trim(), //评议类型流水号
AppraiseTypeName = objRow[convCourseLearningCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.AppraiseTypeName].ToString().Trim(), //评议类型名称
SenateTheme = objRow[convCourseLearningCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.SenateTheme].ToString().Trim(), //量化评价主题
SenateContent = objRow[convCourseLearningCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.SenateContent].ToString().Trim(), //评价内容
SenateTotalScore = TransNullToFloat(objRow[convCourseLearningCaseQuantitySenate.SenateTotalScore].ToString().Trim()), //评价分数
SenateDate = objRow[convCourseLearningCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.SenateDate].ToString().Trim(), //评价日期
SenateTime = objRow[convCourseLearningCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.SenateTime].ToString().Trim(), //评价时间
SenateIp = objRow[convCourseLearningCaseQuantitySenate.SenateIp].ToString().Trim(), //评议Ip
BrowseCount = objRow[convCourseLearningCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCaseQuantitySenate.BrowseCount].ToString().Trim()), //浏览次数
IdSenateGaugeVersion = objRow[convCourseLearningCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(), //评价量表版本流水号
senateGaugeVersionID = objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(), //评价量表版本ID
senateGaugeVersionName = objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(), //评价量表版本名称
senateGaugeVersionTtlScore = objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()), //评价量表版本总分
UserId = objRow[convCourseLearningCaseQuantitySenate.UserId].ToString().Trim(), //用户ID
UserName = objRow[convCourseLearningCaseQuantitySenate.UserName].ToString().Trim(), //用户名
UserKindId = objRow[convCourseLearningCaseQuantitySenate.UserKindId].ToString().Trim(), //用户类别Id
UserKindName = objRow[convCourseLearningCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UserKindName].ToString().Trim(), //用户类别名
UpdUser = objRow[convCourseLearningCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UpdUser].ToString().Trim(), //修改人
UpdUserName = objRow[convCourseLearningCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UpdUserName].ToString().Trim(), //UpdUserName
Memo = objRow[convCourseLearningCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.Memo].ToString().Trim(), //备注
UserTypeName = objRow[convCourseLearningCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UserTypeName].ToString().Trim() //用户类型名称
};
objvCourseLearningCaseQuantitySenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCourseLearningCaseQuantitySenateEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvCourseLearningCaseQuantitySenateDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvCourseLearningCaseQuantitySenateEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN = new clsvCourseLearningCaseQuantitySenateEN();
try
{
objvCourseLearningCaseQuantitySenateEN.IdCourseLearningCase = objRow[convCourseLearningCaseQuantitySenate.IdCourseLearningCase] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseID = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseID] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseName = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTheme = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseDate = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTime = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseDateIn = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTypeName = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningCaseQuantitySenateEN.OwnerId = objRow[convCourseLearningCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvCourseLearningCaseQuantitySenateEN.OwnerName = objRow[convCourseLearningCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvCourseLearningCaseQuantitySenateEN.OwnerNameWithId = objRow[convCourseLearningCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCourseLearningCaseQuantitySenateEN.UserNameWithUserId = objRow[convCourseLearningCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvCourseLearningCaseQuantitySenateEN.IsDualVideo = TransNullToBool(objRow[convCourseLearningCaseQuantitySenate.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCaseQuantitySenateEN.IdXzCollege = objRow[convCourseLearningCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCaseQuantitySenateEN.CollegeID = objRow[convCourseLearningCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvCourseLearningCaseQuantitySenateEN.CollegeName = objRow[convCourseLearningCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCaseQuantitySenateEN.IdXzMajor = objRow[convCourseLearningCaseQuantitySenate.IdXzMajor] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningCaseQuantitySenateEN.MajorID = objRow[convCourseLearningCaseQuantitySenate.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCaseQuantitySenateEN.MajorName = objRow[convCourseLearningCaseQuantitySenate.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCaseQuantitySenateEN.CourseId = objRow[convCourseLearningCaseQuantitySenate.CourseId] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCaseQuantitySenateEN.CourseCode = objRow[convCourseLearningCaseQuantitySenate.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCaseQuantitySenateEN.CourseName = objRow[convCourseLearningCaseQuantitySenate.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCaseQuantitySenateEN.ViewCount = objRow[convCourseLearningCaseQuantitySenate.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCaseQuantitySenate.ViewCount].ToString().Trim()); //浏览量
objvCourseLearningCaseQuantitySenateEN.IsShow = TransNullToBool(objRow[convCourseLearningCaseQuantitySenate.IsShow].ToString().Trim()); //是否启用
objvCourseLearningCaseQuantitySenateEN.DownloadNumber = objRow[convCourseLearningCaseQuantitySenate.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCaseQuantitySenate.DownloadNumber].ToString().Trim()); //下载数目
objvCourseLearningCaseQuantitySenateEN.FileIntegration = objRow[convCourseLearningCaseQuantitySenate.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCaseQuantitySenate.FileIntegration].ToString().Trim()); //文件积分
objvCourseLearningCaseQuantitySenateEN.LikeCount = objRow[convCourseLearningCaseQuantitySenate.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCourseLearningCaseQuantitySenate.LikeCount].ToString().Trim()); //资源喜欢数量
objvCourseLearningCaseQuantitySenateEN.CollectionCount = objRow[convCourseLearningCaseQuantitySenate.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCourseLearningCaseQuantitySenate.CollectionCount].ToString().Trim()); //收藏数量
objvCourseLearningCaseQuantitySenateEN.CollegeNameA = objRow[convCourseLearningCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convCourseLearningCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvCourseLearningCaseQuantitySenateEN.FuncModuleId = objRow[convCourseLearningCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningCaseQuantitySenateEN.FuncModuleName = objRow[convCourseLearningCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningCaseQuantitySenateEN.IdMicroteachCase = objRow[convCourseLearningCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCourseLearningCaseQuantitySenateEN.IdAppraiseType = objRow[convCourseLearningCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvCourseLearningCaseQuantitySenateEN.AppraiseTypeName = objRow[convCourseLearningCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvCourseLearningCaseQuantitySenateEN.SenateTheme = objRow[convCourseLearningCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvCourseLearningCaseQuantitySenateEN.SenateContent = objRow[convCourseLearningCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvCourseLearningCaseQuantitySenateEN.SenateTotalScore = TransNullToFloat(objRow[convCourseLearningCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvCourseLearningCaseQuantitySenateEN.SenateDate = objRow[convCourseLearningCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvCourseLearningCaseQuantitySenateEN.SenateTime = objRow[convCourseLearningCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvCourseLearningCaseQuantitySenateEN.SenateIp = objRow[convCourseLearningCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvCourseLearningCaseQuantitySenateEN.BrowseCount = objRow[convCourseLearningCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvCourseLearningCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convCourseLearningCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCourseLearningCaseQuantitySenateEN.senateGaugeVersionID = objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCourseLearningCaseQuantitySenateEN.senateGaugeVersionName = objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCourseLearningCaseQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCourseLearningCaseQuantitySenateEN.UserId = objRow[convCourseLearningCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvCourseLearningCaseQuantitySenateEN.UserName = objRow[convCourseLearningCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvCourseLearningCaseQuantitySenateEN.UserKindId = objRow[convCourseLearningCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvCourseLearningCaseQuantitySenateEN.UserKindName = objRow[convCourseLearningCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvCourseLearningCaseQuantitySenateEN.UpdUser = objRow[convCourseLearningCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvCourseLearningCaseQuantitySenateEN.UpdUserName = objRow[convCourseLearningCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
objvCourseLearningCaseQuantitySenateEN.Memo = objRow[convCourseLearningCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.Memo].ToString().Trim(); //备注
objvCourseLearningCaseQuantitySenateEN.UserTypeName = objRow[convCourseLearningCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvCourseLearningCaseQuantitySenateDA: GetObjByDataRowvCourseLearningCaseQuantitySenate)", objException.Message));
}
objvCourseLearningCaseQuantitySenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCourseLearningCaseQuantitySenateEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvCourseLearningCaseQuantitySenateEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN = new clsvCourseLearningCaseQuantitySenateEN();
try
{
objvCourseLearningCaseQuantitySenateEN.IdCourseLearningCase = objRow[convCourseLearningCaseQuantitySenate.IdCourseLearningCase] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseID = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseID] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseName = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTheme = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseDate = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTime = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseDateIn = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTypeName = objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningCaseQuantitySenateEN.OwnerId = objRow[convCourseLearningCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvCourseLearningCaseQuantitySenateEN.OwnerName = objRow[convCourseLearningCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvCourseLearningCaseQuantitySenateEN.OwnerNameWithId = objRow[convCourseLearningCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCourseLearningCaseQuantitySenateEN.UserNameWithUserId = objRow[convCourseLearningCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvCourseLearningCaseQuantitySenateEN.IsDualVideo = TransNullToBool(objRow[convCourseLearningCaseQuantitySenate.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCaseQuantitySenateEN.IdXzCollege = objRow[convCourseLearningCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCaseQuantitySenateEN.CollegeID = objRow[convCourseLearningCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvCourseLearningCaseQuantitySenateEN.CollegeName = objRow[convCourseLearningCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCaseQuantitySenateEN.IdXzMajor = objRow[convCourseLearningCaseQuantitySenate.IdXzMajor] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningCaseQuantitySenateEN.MajorID = objRow[convCourseLearningCaseQuantitySenate.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCaseQuantitySenateEN.MajorName = objRow[convCourseLearningCaseQuantitySenate.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCaseQuantitySenateEN.CourseId = objRow[convCourseLearningCaseQuantitySenate.CourseId] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCaseQuantitySenateEN.CourseCode = objRow[convCourseLearningCaseQuantitySenate.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCaseQuantitySenateEN.CourseName = objRow[convCourseLearningCaseQuantitySenate.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCaseQuantitySenateEN.ViewCount = objRow[convCourseLearningCaseQuantitySenate.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCaseQuantitySenate.ViewCount].ToString().Trim()); //浏览量
objvCourseLearningCaseQuantitySenateEN.IsShow = TransNullToBool(objRow[convCourseLearningCaseQuantitySenate.IsShow].ToString().Trim()); //是否启用
objvCourseLearningCaseQuantitySenateEN.DownloadNumber = objRow[convCourseLearningCaseQuantitySenate.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCaseQuantitySenate.DownloadNumber].ToString().Trim()); //下载数目
objvCourseLearningCaseQuantitySenateEN.FileIntegration = objRow[convCourseLearningCaseQuantitySenate.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCaseQuantitySenate.FileIntegration].ToString().Trim()); //文件积分
objvCourseLearningCaseQuantitySenateEN.LikeCount = objRow[convCourseLearningCaseQuantitySenate.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCourseLearningCaseQuantitySenate.LikeCount].ToString().Trim()); //资源喜欢数量
objvCourseLearningCaseQuantitySenateEN.CollectionCount = objRow[convCourseLearningCaseQuantitySenate.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCourseLearningCaseQuantitySenate.CollectionCount].ToString().Trim()); //收藏数量
objvCourseLearningCaseQuantitySenateEN.CollegeNameA = objRow[convCourseLearningCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convCourseLearningCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvCourseLearningCaseQuantitySenateEN.FuncModuleId = objRow[convCourseLearningCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningCaseQuantitySenateEN.FuncModuleName = objRow[convCourseLearningCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningCaseQuantitySenateEN.IdMicroteachCase = objRow[convCourseLearningCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCourseLearningCaseQuantitySenateEN.IdAppraiseType = objRow[convCourseLearningCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvCourseLearningCaseQuantitySenateEN.AppraiseTypeName = objRow[convCourseLearningCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvCourseLearningCaseQuantitySenateEN.SenateTheme = objRow[convCourseLearningCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvCourseLearningCaseQuantitySenateEN.SenateContent = objRow[convCourseLearningCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvCourseLearningCaseQuantitySenateEN.SenateTotalScore = TransNullToFloat(objRow[convCourseLearningCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvCourseLearningCaseQuantitySenateEN.SenateDate = objRow[convCourseLearningCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvCourseLearningCaseQuantitySenateEN.SenateTime = objRow[convCourseLearningCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvCourseLearningCaseQuantitySenateEN.SenateIp = objRow[convCourseLearningCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvCourseLearningCaseQuantitySenateEN.BrowseCount = objRow[convCourseLearningCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvCourseLearningCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convCourseLearningCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCourseLearningCaseQuantitySenateEN.senateGaugeVersionID = objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCourseLearningCaseQuantitySenateEN.senateGaugeVersionName = objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCourseLearningCaseQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convCourseLearningCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCourseLearningCaseQuantitySenateEN.UserId = objRow[convCourseLearningCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvCourseLearningCaseQuantitySenateEN.UserName = objRow[convCourseLearningCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvCourseLearningCaseQuantitySenateEN.UserKindId = objRow[convCourseLearningCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvCourseLearningCaseQuantitySenateEN.UserKindName = objRow[convCourseLearningCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvCourseLearningCaseQuantitySenateEN.UpdUser = objRow[convCourseLearningCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvCourseLearningCaseQuantitySenateEN.UpdUserName = objRow[convCourseLearningCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
objvCourseLearningCaseQuantitySenateEN.Memo = objRow[convCourseLearningCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.Memo].ToString().Trim(); //备注
objvCourseLearningCaseQuantitySenateEN.UserTypeName = objRow[convCourseLearningCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvCourseLearningCaseQuantitySenateDA: GetObjByDataRow)", objException.Message));
}
objvCourseLearningCaseQuantitySenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCourseLearningCaseQuantitySenateEN;
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
objSQL = clsvCourseLearningCaseQuantitySenateDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCourseLearningCaseQuantitySenateEN._CurrTabName, convCourseLearningCaseQuantitySenate.IdmicroteachCaseQuantitySenate, 8, "");
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
objSQL = clsvCourseLearningCaseQuantitySenateDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCourseLearningCaseQuantitySenateEN._CurrTabName, convCourseLearningCaseQuantitySenate.IdmicroteachCaseQuantitySenate, 8, strPrefix);
return strMaxValue;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstID)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public long GetFirstID(string strCondition) 
{
string strSQL ;
 System.Data.DataTable objDT ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCaseQuantitySenateDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdmicroteachCaseQuantitySenate from vCourseLearningCaseQuantitySenate where " + strCondition;
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
return 0;
}
strKeyValue = objDT.Rows[0][0].ToString();
return long.Parse(strKeyValue);
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
 objSQL = clsvCourseLearningCaseQuantitySenateDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdmicroteachCaseQuantitySenate from vCourseLearningCaseQuantitySenate where " + strCondition;
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
 /// <param name = "lngIdmicroteachCaseQuantitySenate">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngIdmicroteachCaseQuantitySenate)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCaseQuantitySenateDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCourseLearningCaseQuantitySenate", "IdmicroteachCaseQuantitySenate = " + ""+ lngIdmicroteachCaseQuantitySenate+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvCourseLearningCaseQuantitySenateDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCaseQuantitySenateDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCourseLearningCaseQuantitySenate", strCondition))
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
objSQL = clsvCourseLearningCaseQuantitySenateDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vCourseLearningCaseQuantitySenate");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateENS">源对象</param>
 /// <param name = "objvCourseLearningCaseQuantitySenateENT">目标对象</param>
public void CopyTo(clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateENS, clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateENT)
{
objvCourseLearningCaseQuantitySenateENT.IdCourseLearningCase = objvCourseLearningCaseQuantitySenateENS.IdCourseLearningCase; //课程学习案例流水号
objvCourseLearningCaseQuantitySenateENT.CourseLearningCaseID = objvCourseLearningCaseQuantitySenateENS.CourseLearningCaseID; //课程学习案例ID
objvCourseLearningCaseQuantitySenateENT.CourseLearningCaseName = objvCourseLearningCaseQuantitySenateENS.CourseLearningCaseName; //课程学习案例名称
objvCourseLearningCaseQuantitySenateENT.CourseLearningCaseTheme = objvCourseLearningCaseQuantitySenateENS.CourseLearningCaseTheme; //课程学习案例主题词
objvCourseLearningCaseQuantitySenateENT.CourseLearningCaseDate = objvCourseLearningCaseQuantitySenateENS.CourseLearningCaseDate; //课程学习日期
objvCourseLearningCaseQuantitySenateENT.CourseLearningCaseTime = objvCourseLearningCaseQuantitySenateENS.CourseLearningCaseTime; //课程学习时间
objvCourseLearningCaseQuantitySenateENT.CourseLearningCaseDateIn = objvCourseLearningCaseQuantitySenateENS.CourseLearningCaseDateIn; //案例入库日期
objvCourseLearningCaseQuantitySenateENT.CourseLearningCaseTimeIn = objvCourseLearningCaseQuantitySenateENS.CourseLearningCaseTimeIn; //案例入库时间
objvCourseLearningCaseQuantitySenateENT.CourseLearningCaseTypeName = objvCourseLearningCaseQuantitySenateENS.CourseLearningCaseTypeName; //课程学习案例类型名称
objvCourseLearningCaseQuantitySenateENT.OwnerId = objvCourseLearningCaseQuantitySenateENS.OwnerId; //拥有者Id
objvCourseLearningCaseQuantitySenateENT.OwnerName = objvCourseLearningCaseQuantitySenateENS.OwnerName; //拥有者姓名
objvCourseLearningCaseQuantitySenateENT.OwnerNameWithId = objvCourseLearningCaseQuantitySenateENS.OwnerNameWithId; //拥有者名称附Id
objvCourseLearningCaseQuantitySenateENT.UserNameWithUserId = objvCourseLearningCaseQuantitySenateENS.UserNameWithUserId; //UserNameWithUserId
objvCourseLearningCaseQuantitySenateENT.IsDualVideo = objvCourseLearningCaseQuantitySenateENS.IsDualVideo; //是否双视频
objvCourseLearningCaseQuantitySenateENT.IdXzCollege = objvCourseLearningCaseQuantitySenateENS.IdXzCollege; //学院流水号
objvCourseLearningCaseQuantitySenateENT.CollegeID = objvCourseLearningCaseQuantitySenateENS.CollegeID; //学院ID
objvCourseLearningCaseQuantitySenateENT.CollegeName = objvCourseLearningCaseQuantitySenateENS.CollegeName; //学院名称
objvCourseLearningCaseQuantitySenateENT.IdXzMajor = objvCourseLearningCaseQuantitySenateENS.IdXzMajor; //专业流水号
objvCourseLearningCaseQuantitySenateENT.MajorID = objvCourseLearningCaseQuantitySenateENS.MajorID; //专业ID
objvCourseLearningCaseQuantitySenateENT.MajorName = objvCourseLearningCaseQuantitySenateENS.MajorName; //专业名称
objvCourseLearningCaseQuantitySenateENT.CourseId = objvCourseLearningCaseQuantitySenateENS.CourseId; //课程Id
objvCourseLearningCaseQuantitySenateENT.CourseCode = objvCourseLearningCaseQuantitySenateENS.CourseCode; //课程代码
objvCourseLearningCaseQuantitySenateENT.CourseName = objvCourseLearningCaseQuantitySenateENS.CourseName; //课程名称
objvCourseLearningCaseQuantitySenateENT.ViewCount = objvCourseLearningCaseQuantitySenateENS.ViewCount; //浏览量
objvCourseLearningCaseQuantitySenateENT.IsShow = objvCourseLearningCaseQuantitySenateENS.IsShow; //是否启用
objvCourseLearningCaseQuantitySenateENT.DownloadNumber = objvCourseLearningCaseQuantitySenateENS.DownloadNumber; //下载数目
objvCourseLearningCaseQuantitySenateENT.FileIntegration = objvCourseLearningCaseQuantitySenateENS.FileIntegration; //文件积分
objvCourseLearningCaseQuantitySenateENT.LikeCount = objvCourseLearningCaseQuantitySenateENS.LikeCount; //资源喜欢数量
objvCourseLearningCaseQuantitySenateENT.CollectionCount = objvCourseLearningCaseQuantitySenateENS.CollectionCount; //收藏数量
objvCourseLearningCaseQuantitySenateENT.CollegeNameA = objvCourseLearningCaseQuantitySenateENS.CollegeNameA; //学院名称简写
objvCourseLearningCaseQuantitySenateENT.IdmicroteachCaseQuantitySenate = objvCourseLearningCaseQuantitySenateENS.IdmicroteachCaseQuantitySenate; //微格量化评价流水号
objvCourseLearningCaseQuantitySenateENT.FuncModuleId = objvCourseLearningCaseQuantitySenateENS.FuncModuleId; //功能模块Id
objvCourseLearningCaseQuantitySenateENT.FuncModuleName = objvCourseLearningCaseQuantitySenateENS.FuncModuleName; //功能模块名称
objvCourseLearningCaseQuantitySenateENT.IdMicroteachCase = objvCourseLearningCaseQuantitySenateENS.IdMicroteachCase; //微格教学案例流水号
objvCourseLearningCaseQuantitySenateENT.IdAppraiseType = objvCourseLearningCaseQuantitySenateENS.IdAppraiseType; //评议类型流水号
objvCourseLearningCaseQuantitySenateENT.AppraiseTypeName = objvCourseLearningCaseQuantitySenateENS.AppraiseTypeName; //评议类型名称
objvCourseLearningCaseQuantitySenateENT.SenateTheme = objvCourseLearningCaseQuantitySenateENS.SenateTheme; //量化评价主题
objvCourseLearningCaseQuantitySenateENT.SenateContent = objvCourseLearningCaseQuantitySenateENS.SenateContent; //评价内容
objvCourseLearningCaseQuantitySenateENT.SenateTotalScore = objvCourseLearningCaseQuantitySenateENS.SenateTotalScore; //评价分数
objvCourseLearningCaseQuantitySenateENT.SenateDate = objvCourseLearningCaseQuantitySenateENS.SenateDate; //评价日期
objvCourseLearningCaseQuantitySenateENT.SenateTime = objvCourseLearningCaseQuantitySenateENS.SenateTime; //评价时间
objvCourseLearningCaseQuantitySenateENT.SenateIp = objvCourseLearningCaseQuantitySenateENS.SenateIp; //评议Ip
objvCourseLearningCaseQuantitySenateENT.BrowseCount = objvCourseLearningCaseQuantitySenateENS.BrowseCount; //浏览次数
objvCourseLearningCaseQuantitySenateENT.IdSenateGaugeVersion = objvCourseLearningCaseQuantitySenateENS.IdSenateGaugeVersion; //评价量表版本流水号
objvCourseLearningCaseQuantitySenateENT.senateGaugeVersionID = objvCourseLearningCaseQuantitySenateENS.senateGaugeVersionID; //评价量表版本ID
objvCourseLearningCaseQuantitySenateENT.senateGaugeVersionName = objvCourseLearningCaseQuantitySenateENS.senateGaugeVersionName; //评价量表版本名称
objvCourseLearningCaseQuantitySenateENT.senateGaugeVersionTtlScore = objvCourseLearningCaseQuantitySenateENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvCourseLearningCaseQuantitySenateENT.UserId = objvCourseLearningCaseQuantitySenateENS.UserId; //用户ID
objvCourseLearningCaseQuantitySenateENT.UserName = objvCourseLearningCaseQuantitySenateENS.UserName; //用户名
objvCourseLearningCaseQuantitySenateENT.UserKindId = objvCourseLearningCaseQuantitySenateENS.UserKindId; //用户类别Id
objvCourseLearningCaseQuantitySenateENT.UserKindName = objvCourseLearningCaseQuantitySenateENS.UserKindName; //用户类别名
objvCourseLearningCaseQuantitySenateENT.UpdUser = objvCourseLearningCaseQuantitySenateENS.UpdUser; //修改人
objvCourseLearningCaseQuantitySenateENT.UpdUserName = objvCourseLearningCaseQuantitySenateENS.UpdUserName; //UpdUserName
objvCourseLearningCaseQuantitySenateENT.Memo = objvCourseLearningCaseQuantitySenateENS.Memo; //备注
objvCourseLearningCaseQuantitySenateENT.UserTypeName = objvCourseLearningCaseQuantitySenateENS.UserTypeName; //用户类型名称
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvCourseLearningCaseQuantitySenateEN objvCourseLearningCaseQuantitySenateEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvCourseLearningCaseQuantitySenateEN.IdCourseLearningCase, 8, convCourseLearningCaseQuantitySenate.IdCourseLearningCase);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseID, 8, convCourseLearningCaseQuantitySenate.CourseLearningCaseID);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseName, 100, convCourseLearningCaseQuantitySenate.CourseLearningCaseName);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTheme, 200, convCourseLearningCaseQuantitySenate.CourseLearningCaseTheme);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseDate, 8, convCourseLearningCaseQuantitySenate.CourseLearningCaseDate);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTime, 6, convCourseLearningCaseQuantitySenate.CourseLearningCaseTime);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseDateIn, 8, convCourseLearningCaseQuantitySenate.CourseLearningCaseDateIn);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTimeIn, 6, convCourseLearningCaseQuantitySenate.CourseLearningCaseTimeIn);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTypeName, 30, convCourseLearningCaseQuantitySenate.CourseLearningCaseTypeName);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseQuantitySenateEN.OwnerId, 20, convCourseLearningCaseQuantitySenate.OwnerId);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseQuantitySenateEN.OwnerName, 30, convCourseLearningCaseQuantitySenate.OwnerName);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseQuantitySenateEN.OwnerNameWithId, 51, convCourseLearningCaseQuantitySenate.OwnerNameWithId);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseQuantitySenateEN.UserNameWithUserId, 51, convCourseLearningCaseQuantitySenate.UserNameWithUserId);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseQuantitySenateEN.IdXzCollege, 4, convCourseLearningCaseQuantitySenate.IdXzCollege);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseQuantitySenateEN.CollegeID, 4, convCourseLearningCaseQuantitySenate.CollegeID);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseQuantitySenateEN.CollegeName, 100, convCourseLearningCaseQuantitySenate.CollegeName);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseQuantitySenateEN.IdXzMajor, 8, convCourseLearningCaseQuantitySenate.IdXzMajor);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseQuantitySenateEN.MajorID, 4, convCourseLearningCaseQuantitySenate.MajorID);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseQuantitySenateEN.MajorName, 100, convCourseLearningCaseQuantitySenate.MajorName);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseQuantitySenateEN.CourseId, 8, convCourseLearningCaseQuantitySenate.CourseId);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseQuantitySenateEN.CourseCode, 20, convCourseLearningCaseQuantitySenate.CourseCode);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseQuantitySenateEN.CourseName, 100, convCourseLearningCaseQuantitySenate.CourseName);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseQuantitySenateEN.CollegeNameA, 12, convCourseLearningCaseQuantitySenate.CollegeNameA);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseQuantitySenateEN.FuncModuleId, 4, convCourseLearningCaseQuantitySenate.FuncModuleId);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseQuantitySenateEN.FuncModuleName, 30, convCourseLearningCaseQuantitySenate.FuncModuleName);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseQuantitySenateEN.IdMicroteachCase, 8, convCourseLearningCaseQuantitySenate.IdMicroteachCase);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseQuantitySenateEN.IdAppraiseType, 4, convCourseLearningCaseQuantitySenate.IdAppraiseType);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseQuantitySenateEN.AppraiseTypeName, 50, convCourseLearningCaseQuantitySenate.AppraiseTypeName);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseQuantitySenateEN.SenateTheme, 200, convCourseLearningCaseQuantitySenate.SenateTheme);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseQuantitySenateEN.SenateContent, 2000, convCourseLearningCaseQuantitySenate.SenateContent);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseQuantitySenateEN.SenateDate, 8, convCourseLearningCaseQuantitySenate.SenateDate);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseQuantitySenateEN.SenateTime, 6, convCourseLearningCaseQuantitySenate.SenateTime);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseQuantitySenateEN.SenateIp, 50, convCourseLearningCaseQuantitySenate.SenateIp);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseQuantitySenateEN.IdSenateGaugeVersion, 4, convCourseLearningCaseQuantitySenate.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseQuantitySenateEN.senateGaugeVersionID, 4, convCourseLearningCaseQuantitySenate.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseQuantitySenateEN.senateGaugeVersionName, 200, convCourseLearningCaseQuantitySenate.senateGaugeVersionName);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseQuantitySenateEN.UserId, 18, convCourseLearningCaseQuantitySenate.UserId);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseQuantitySenateEN.UserName, 30, convCourseLearningCaseQuantitySenate.UserName);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseQuantitySenateEN.UserKindId, 2, convCourseLearningCaseQuantitySenate.UserKindId);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseQuantitySenateEN.UserKindName, 30, convCourseLearningCaseQuantitySenate.UserKindName);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseQuantitySenateEN.UpdUser, 20, convCourseLearningCaseQuantitySenate.UpdUser);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseQuantitySenateEN.UpdUserName, 20, convCourseLearningCaseQuantitySenate.UpdUserName);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseQuantitySenateEN.Memo, 1000, convCourseLearningCaseQuantitySenate.Memo);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseQuantitySenateEN.UserTypeName, 20, convCourseLearningCaseQuantitySenate.UserTypeName);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseQuantitySenateEN.IdCourseLearningCase, convCourseLearningCaseQuantitySenate.IdCourseLearningCase);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseID, convCourseLearningCaseQuantitySenate.CourseLearningCaseID);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseName, convCourseLearningCaseQuantitySenate.CourseLearningCaseName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTheme, convCourseLearningCaseQuantitySenate.CourseLearningCaseTheme);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseDate, convCourseLearningCaseQuantitySenate.CourseLearningCaseDate);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTime, convCourseLearningCaseQuantitySenate.CourseLearningCaseTime);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseDateIn, convCourseLearningCaseQuantitySenate.CourseLearningCaseDateIn);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTimeIn, convCourseLearningCaseQuantitySenate.CourseLearningCaseTimeIn);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseQuantitySenateEN.CourseLearningCaseTypeName, convCourseLearningCaseQuantitySenate.CourseLearningCaseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseQuantitySenateEN.OwnerId, convCourseLearningCaseQuantitySenate.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseQuantitySenateEN.OwnerName, convCourseLearningCaseQuantitySenate.OwnerName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseQuantitySenateEN.OwnerNameWithId, convCourseLearningCaseQuantitySenate.OwnerNameWithId);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseQuantitySenateEN.UserNameWithUserId, convCourseLearningCaseQuantitySenate.UserNameWithUserId);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseQuantitySenateEN.IdXzCollege, convCourseLearningCaseQuantitySenate.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseQuantitySenateEN.CollegeID, convCourseLearningCaseQuantitySenate.CollegeID);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseQuantitySenateEN.CollegeName, convCourseLearningCaseQuantitySenate.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseQuantitySenateEN.IdXzMajor, convCourseLearningCaseQuantitySenate.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseQuantitySenateEN.MajorID, convCourseLearningCaseQuantitySenate.MajorID);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseQuantitySenateEN.MajorName, convCourseLearningCaseQuantitySenate.MajorName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseQuantitySenateEN.CourseId, convCourseLearningCaseQuantitySenate.CourseId);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseQuantitySenateEN.CourseCode, convCourseLearningCaseQuantitySenate.CourseCode);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseQuantitySenateEN.CourseName, convCourseLearningCaseQuantitySenate.CourseName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseQuantitySenateEN.CollegeNameA, convCourseLearningCaseQuantitySenate.CollegeNameA);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseQuantitySenateEN.FuncModuleId, convCourseLearningCaseQuantitySenate.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseQuantitySenateEN.FuncModuleName, convCourseLearningCaseQuantitySenate.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseQuantitySenateEN.IdMicroteachCase, convCourseLearningCaseQuantitySenate.IdMicroteachCase);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseQuantitySenateEN.IdAppraiseType, convCourseLearningCaseQuantitySenate.IdAppraiseType);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseQuantitySenateEN.AppraiseTypeName, convCourseLearningCaseQuantitySenate.AppraiseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseQuantitySenateEN.SenateTheme, convCourseLearningCaseQuantitySenate.SenateTheme);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseQuantitySenateEN.SenateContent, convCourseLearningCaseQuantitySenate.SenateContent);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseQuantitySenateEN.SenateDate, convCourseLearningCaseQuantitySenate.SenateDate);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseQuantitySenateEN.SenateTime, convCourseLearningCaseQuantitySenate.SenateTime);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseQuantitySenateEN.SenateIp, convCourseLearningCaseQuantitySenate.SenateIp);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseQuantitySenateEN.IdSenateGaugeVersion, convCourseLearningCaseQuantitySenate.IdSenateGaugeVersion);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseQuantitySenateEN.senateGaugeVersionID, convCourseLearningCaseQuantitySenate.senateGaugeVersionID);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseQuantitySenateEN.senateGaugeVersionName, convCourseLearningCaseQuantitySenate.senateGaugeVersionName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseQuantitySenateEN.UserId, convCourseLearningCaseQuantitySenate.UserId);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseQuantitySenateEN.UserName, convCourseLearningCaseQuantitySenate.UserName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseQuantitySenateEN.UserKindId, convCourseLearningCaseQuantitySenate.UserKindId);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseQuantitySenateEN.UserKindName, convCourseLearningCaseQuantitySenate.UserKindName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseQuantitySenateEN.UpdUser, convCourseLearningCaseQuantitySenate.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseQuantitySenateEN.UpdUserName, convCourseLearningCaseQuantitySenate.UpdUserName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseQuantitySenateEN.Memo, convCourseLearningCaseQuantitySenate.Memo);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseQuantitySenateEN.UserTypeName, convCourseLearningCaseQuantitySenate.UserTypeName);
//检查外键字段长度
 objvCourseLearningCaseQuantitySenateEN._IsCheckProperty = true;
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
 objSQL = clsvCourseLearningCaseQuantitySenateDA.GetSpecSQLObj();
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
 objSQL = clsvCourseLearningCaseQuantitySenateDA.GetSpecSQLObj();
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
 objSQL = clsvCourseLearningCaseQuantitySenateDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCourseLearningCaseQuantitySenateEN._CurrTabName);
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
 objSQL = clsvCourseLearningCaseQuantitySenateDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCourseLearningCaseQuantitySenateEN._CurrTabName, strCondition);
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
 objSQL = clsvCourseLearningCaseQuantitySenateDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}