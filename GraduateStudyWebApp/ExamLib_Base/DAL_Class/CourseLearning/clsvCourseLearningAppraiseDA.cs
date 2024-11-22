
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCourseLearningAppraiseDA
 表名:vCourseLearningAppraise(01120269)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:45:31
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
 /// v课程学习定性评议(vCourseLearningAppraise)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvCourseLearningAppraiseDA : clsCommBase4DA
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
 return clsvCourseLearningAppraiseEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvCourseLearningAppraiseEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCourseLearningAppraiseEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvCourseLearningAppraiseEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvCourseLearningAppraiseEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvCourseLearningAppraiseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningAppraiseDA.GetSpecSQLObj();
strSQL = "Select * from vCourseLearningAppraise where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vCourseLearningAppraise(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvCourseLearningAppraiseDA: GetDataTable_vCourseLearningAppraise)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningAppraiseDA.GetSpecSQLObj();
strSQL = "Select * from vCourseLearningAppraise where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvCourseLearningAppraiseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningAppraiseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvCourseLearningAppraiseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningAppraiseDA.GetSpecSQLObj();
strSQL = "Select * from vCourseLearningAppraise where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvCourseLearningAppraiseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningAppraiseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvCourseLearningAppraiseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningAppraiseDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCourseLearningAppraise where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCourseLearningAppraise where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvCourseLearningAppraiseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningAppraiseDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vCourseLearningAppraise where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvCourseLearningAppraiseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningAppraiseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vCourseLearningAppraise.* from vCourseLearningAppraise Left Join {1} on {2} where {3} and vCourseLearningAppraise.IdMicroteachAppraise not in (Select top {5} vCourseLearningAppraise.IdMicroteachAppraise from vCourseLearningAppraise Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCourseLearningAppraise where {1} and IdMicroteachAppraise not in (Select top {2} IdMicroteachAppraise from vCourseLearningAppraise where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCourseLearningAppraise where {1} and IdMicroteachAppraise not in (Select top {3} IdMicroteachAppraise from vCourseLearningAppraise where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvCourseLearningAppraiseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningAppraiseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vCourseLearningAppraise.* from vCourseLearningAppraise Left Join {1} on {2} where {3} and vCourseLearningAppraise.IdMicroteachAppraise not in (Select top {5} vCourseLearningAppraise.IdMicroteachAppraise from vCourseLearningAppraise Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCourseLearningAppraise where {1} and IdMicroteachAppraise not in (Select top {2} IdMicroteachAppraise from vCourseLearningAppraise where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCourseLearningAppraise where {1} and IdMicroteachAppraise not in (Select top {3} IdMicroteachAppraise from vCourseLearningAppraise where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvCourseLearningAppraiseEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvCourseLearningAppraiseDA:GetObjLst)", objException.Message));
}
List<clsvCourseLearningAppraiseEN> arrObjLst = new List<clsvCourseLearningAppraiseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningAppraiseDA.GetSpecSQLObj();
strSQL = "Select * from vCourseLearningAppraise where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN = new clsvCourseLearningAppraiseEN();
try
{
objvCourseLearningAppraiseEN.IdCourseLearningCase = objRow[convCourseLearningAppraise.IdCourseLearningCase] == DBNull.Value ? null : objRow[convCourseLearningAppraise.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningAppraiseEN.CourseLearningCaseID = objRow[convCourseLearningAppraise.CourseLearningCaseID] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningAppraiseEN.CourseLearningCaseName = objRow[convCourseLearningAppraise.CourseLearningCaseName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningAppraiseEN.CourseLearningCaseTheme = objRow[convCourseLearningAppraise.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningAppraiseEN.CourseLearningCaseDate = objRow[convCourseLearningAppraise.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningAppraiseEN.CourseLearningCaseTime = objRow[convCourseLearningAppraise.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningAppraiseEN.CourseLearningCaseDateIn = objRow[convCourseLearningAppraise.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningAppraiseEN.CourseLearningCaseTimeIn = objRow[convCourseLearningAppraise.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningAppraiseEN.CourseLearningCaseTypeName = objRow[convCourseLearningAppraise.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningAppraiseEN.UserNameWithUserId = objRow[convCourseLearningAppraise.UserNameWithUserId] == DBNull.Value ? null : objRow[convCourseLearningAppraise.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvCourseLearningAppraiseEN.IdXzCollege = objRow[convCourseLearningAppraise.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningAppraise.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningAppraiseEN.CollegeID = objRow[convCourseLearningAppraise.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CollegeID].ToString().Trim(); //学院ID
objvCourseLearningAppraiseEN.CollegeName = objRow[convCourseLearningAppraise.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningAppraiseEN.IdXzMajor = objRow[convCourseLearningAppraise.IdXzMajor] == DBNull.Value ? null : objRow[convCourseLearningAppraise.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningAppraiseEN.MajorID = objRow[convCourseLearningAppraise.MajorID] == DBNull.Value ? null : objRow[convCourseLearningAppraise.MajorID].ToString().Trim(); //专业ID
objvCourseLearningAppraiseEN.MajorName = objRow[convCourseLearningAppraise.MajorName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.MajorName].ToString().Trim(); //专业名称
objvCourseLearningAppraiseEN.CourseId = objRow[convCourseLearningAppraise.CourseId] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseId].ToString().Trim(); //课程Id
objvCourseLearningAppraiseEN.CourseCode = objRow[convCourseLearningAppraise.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningAppraiseEN.CourseName = objRow[convCourseLearningAppraise.CourseName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseName].ToString().Trim(); //课程名称
objvCourseLearningAppraiseEN.CollegeNameA = objRow[convCourseLearningAppraise.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningAppraiseEN.IdMicroteachAppraise = TransNullToInt(objRow[convCourseLearningAppraise.IdMicroteachAppraise].ToString().Trim()); //评议流水号
objvCourseLearningAppraiseEN.FuncModuleId = objRow[convCourseLearningAppraise.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningAppraiseEN.FuncModuleName = objRow[convCourseLearningAppraise.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningAppraiseEN.IdMicroteachCase = objRow[convCourseLearningAppraise.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCourseLearningAppraiseEN.IdAppraiseType = objRow[convCourseLearningAppraise.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvCourseLearningAppraiseEN.AppraiseTypeName = objRow[convCourseLearningAppraise.AppraiseTypeName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvCourseLearningAppraiseEN.AppraiseTheme = objRow[convCourseLearningAppraise.AppraiseTheme] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseTheme].ToString().Trim(); //评议主题
objvCourseLearningAppraiseEN.AppraiseContent = objRow[convCourseLearningAppraise.AppraiseContent] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseContent].ToString().Trim(); //评议内容
objvCourseLearningAppraiseEN.AppraiseDate = objRow[convCourseLearningAppraise.AppraiseDate] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseDate].ToString().Trim(); //评议日期
objvCourseLearningAppraiseEN.AppraiseTime = objRow[convCourseLearningAppraise.AppraiseTime] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseTime].ToString().Trim(); //评议时间
objvCourseLearningAppraiseEN.IsVisual = TransNullToBool(objRow[convCourseLearningAppraise.IsVisual].ToString().Trim()); //隐藏标志
objvCourseLearningAppraiseEN.IsElite = TransNullToBool(objRow[convCourseLearningAppraise.IsElite].ToString().Trim()); //精华标志
objvCourseLearningAppraiseEN.UserId = objRow[convCourseLearningAppraise.UserId].ToString().Trim(); //用户ID
objvCourseLearningAppraiseEN.ExcellentOne = objRow[convCourseLearningAppraise.ExcellentOne] == DBNull.Value ? null : objRow[convCourseLearningAppraise.ExcellentOne].ToString().Trim(); //优点1
objvCourseLearningAppraiseEN.ExcellentTwo = objRow[convCourseLearningAppraise.ExcellentTwo] == DBNull.Value ? null : objRow[convCourseLearningAppraise.ExcellentTwo].ToString().Trim(); //优点2
objvCourseLearningAppraiseEN.SuggestOne = objRow[convCourseLearningAppraise.SuggestOne] == DBNull.Value ? null : objRow[convCourseLearningAppraise.SuggestOne].ToString().Trim(); //建议1
objvCourseLearningAppraiseEN.SuggestTwo = objRow[convCourseLearningAppraise.SuggestTwo] == DBNull.Value ? null : objRow[convCourseLearningAppraise.SuggestTwo].ToString().Trim(); //建议2
objvCourseLearningAppraiseEN.MicroteachAppriseScore = objRow[convCourseLearningAppraise.MicroteachAppriseScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convCourseLearningAppraise.MicroteachAppriseScore].ToString().Trim()); //打分
objvCourseLearningAppraiseEN.VideoStopTime = objRow[convCourseLearningAppraise.VideoStopTime] == DBNull.Value ? null : objRow[convCourseLearningAppraise.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objvCourseLearningAppraiseEN.BrowseCount = objRow[convCourseLearningAppraise.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningAppraise.BrowseCount].ToString().Trim()); //浏览次数
objvCourseLearningAppraiseEN.BrowseCount4Case = objRow[convCourseLearningAppraise.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningAppraise.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningAppraiseEN.UserName = objRow[convCourseLearningAppraise.UserName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.UserName].ToString().Trim(); //用户名
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCourseLearningAppraiseDA: GetObjLst)", objException.Message));
}
objvCourseLearningAppraiseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCourseLearningAppraiseEN);
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
public List<clsvCourseLearningAppraiseEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvCourseLearningAppraiseDA:GetObjLstByTabName)", objException.Message));
}
List<clsvCourseLearningAppraiseEN> arrObjLst = new List<clsvCourseLearningAppraiseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningAppraiseDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN = new clsvCourseLearningAppraiseEN();
try
{
objvCourseLearningAppraiseEN.IdCourseLearningCase = objRow[convCourseLearningAppraise.IdCourseLearningCase] == DBNull.Value ? null : objRow[convCourseLearningAppraise.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningAppraiseEN.CourseLearningCaseID = objRow[convCourseLearningAppraise.CourseLearningCaseID] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningAppraiseEN.CourseLearningCaseName = objRow[convCourseLearningAppraise.CourseLearningCaseName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningAppraiseEN.CourseLearningCaseTheme = objRow[convCourseLearningAppraise.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningAppraiseEN.CourseLearningCaseDate = objRow[convCourseLearningAppraise.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningAppraiseEN.CourseLearningCaseTime = objRow[convCourseLearningAppraise.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningAppraiseEN.CourseLearningCaseDateIn = objRow[convCourseLearningAppraise.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningAppraiseEN.CourseLearningCaseTimeIn = objRow[convCourseLearningAppraise.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningAppraiseEN.CourseLearningCaseTypeName = objRow[convCourseLearningAppraise.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningAppraiseEN.UserNameWithUserId = objRow[convCourseLearningAppraise.UserNameWithUserId] == DBNull.Value ? null : objRow[convCourseLearningAppraise.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvCourseLearningAppraiseEN.IdXzCollege = objRow[convCourseLearningAppraise.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningAppraise.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningAppraiseEN.CollegeID = objRow[convCourseLearningAppraise.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CollegeID].ToString().Trim(); //学院ID
objvCourseLearningAppraiseEN.CollegeName = objRow[convCourseLearningAppraise.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningAppraiseEN.IdXzMajor = objRow[convCourseLearningAppraise.IdXzMajor] == DBNull.Value ? null : objRow[convCourseLearningAppraise.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningAppraiseEN.MajorID = objRow[convCourseLearningAppraise.MajorID] == DBNull.Value ? null : objRow[convCourseLearningAppraise.MajorID].ToString().Trim(); //专业ID
objvCourseLearningAppraiseEN.MajorName = objRow[convCourseLearningAppraise.MajorName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.MajorName].ToString().Trim(); //专业名称
objvCourseLearningAppraiseEN.CourseId = objRow[convCourseLearningAppraise.CourseId] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseId].ToString().Trim(); //课程Id
objvCourseLearningAppraiseEN.CourseCode = objRow[convCourseLearningAppraise.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningAppraiseEN.CourseName = objRow[convCourseLearningAppraise.CourseName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseName].ToString().Trim(); //课程名称
objvCourseLearningAppraiseEN.CollegeNameA = objRow[convCourseLearningAppraise.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningAppraiseEN.IdMicroteachAppraise = TransNullToInt(objRow[convCourseLearningAppraise.IdMicroteachAppraise].ToString().Trim()); //评议流水号
objvCourseLearningAppraiseEN.FuncModuleId = objRow[convCourseLearningAppraise.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningAppraiseEN.FuncModuleName = objRow[convCourseLearningAppraise.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningAppraiseEN.IdMicroteachCase = objRow[convCourseLearningAppraise.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCourseLearningAppraiseEN.IdAppraiseType = objRow[convCourseLearningAppraise.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvCourseLearningAppraiseEN.AppraiseTypeName = objRow[convCourseLearningAppraise.AppraiseTypeName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvCourseLearningAppraiseEN.AppraiseTheme = objRow[convCourseLearningAppraise.AppraiseTheme] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseTheme].ToString().Trim(); //评议主题
objvCourseLearningAppraiseEN.AppraiseContent = objRow[convCourseLearningAppraise.AppraiseContent] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseContent].ToString().Trim(); //评议内容
objvCourseLearningAppraiseEN.AppraiseDate = objRow[convCourseLearningAppraise.AppraiseDate] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseDate].ToString().Trim(); //评议日期
objvCourseLearningAppraiseEN.AppraiseTime = objRow[convCourseLearningAppraise.AppraiseTime] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseTime].ToString().Trim(); //评议时间
objvCourseLearningAppraiseEN.IsVisual = TransNullToBool(objRow[convCourseLearningAppraise.IsVisual].ToString().Trim()); //隐藏标志
objvCourseLearningAppraiseEN.IsElite = TransNullToBool(objRow[convCourseLearningAppraise.IsElite].ToString().Trim()); //精华标志
objvCourseLearningAppraiseEN.UserId = objRow[convCourseLearningAppraise.UserId].ToString().Trim(); //用户ID
objvCourseLearningAppraiseEN.ExcellentOne = objRow[convCourseLearningAppraise.ExcellentOne] == DBNull.Value ? null : objRow[convCourseLearningAppraise.ExcellentOne].ToString().Trim(); //优点1
objvCourseLearningAppraiseEN.ExcellentTwo = objRow[convCourseLearningAppraise.ExcellentTwo] == DBNull.Value ? null : objRow[convCourseLearningAppraise.ExcellentTwo].ToString().Trim(); //优点2
objvCourseLearningAppraiseEN.SuggestOne = objRow[convCourseLearningAppraise.SuggestOne] == DBNull.Value ? null : objRow[convCourseLearningAppraise.SuggestOne].ToString().Trim(); //建议1
objvCourseLearningAppraiseEN.SuggestTwo = objRow[convCourseLearningAppraise.SuggestTwo] == DBNull.Value ? null : objRow[convCourseLearningAppraise.SuggestTwo].ToString().Trim(); //建议2
objvCourseLearningAppraiseEN.MicroteachAppriseScore = objRow[convCourseLearningAppraise.MicroteachAppriseScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convCourseLearningAppraise.MicroteachAppriseScore].ToString().Trim()); //打分
objvCourseLearningAppraiseEN.VideoStopTime = objRow[convCourseLearningAppraise.VideoStopTime] == DBNull.Value ? null : objRow[convCourseLearningAppraise.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objvCourseLearningAppraiseEN.BrowseCount = objRow[convCourseLearningAppraise.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningAppraise.BrowseCount].ToString().Trim()); //浏览次数
objvCourseLearningAppraiseEN.BrowseCount4Case = objRow[convCourseLearningAppraise.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningAppraise.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningAppraiseEN.UserName = objRow[convCourseLearningAppraise.UserName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.UserName].ToString().Trim(); //用户名
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCourseLearningAppraiseDA: GetObjLst)", objException.Message));
}
objvCourseLearningAppraiseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCourseLearningAppraiseEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvCourseLearningAppraise(ref clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningAppraiseDA.GetSpecSQLObj();
strSQL = "Select * from vCourseLearningAppraise where IdMicroteachAppraise = " + ""+ objvCourseLearningAppraiseEN.IdMicroteachAppraise+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvCourseLearningAppraiseEN.IdCourseLearningCase = objDT.Rows[0][convCourseLearningAppraise.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningAppraiseEN.CourseLearningCaseID = objDT.Rows[0][convCourseLearningAppraise.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningAppraiseEN.CourseLearningCaseName = objDT.Rows[0][convCourseLearningAppraise.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCourseLearningAppraiseEN.CourseLearningCaseTheme = objDT.Rows[0][convCourseLearningAppraise.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvCourseLearningAppraiseEN.CourseLearningCaseDate = objDT.Rows[0][convCourseLearningAppraise.CourseLearningCaseDate].ToString().Trim(); //课程学习日期(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningAppraiseEN.CourseLearningCaseTime = objDT.Rows[0][convCourseLearningAppraise.CourseLearningCaseTime].ToString().Trim(); //课程学习时间(字段类型:char,字段长度:6,是否可空:True)
 objvCourseLearningAppraiseEN.CourseLearningCaseDateIn = objDT.Rows[0][convCourseLearningAppraise.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningAppraiseEN.CourseLearningCaseTimeIn = objDT.Rows[0][convCourseLearningAppraise.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvCourseLearningAppraiseEN.CourseLearningCaseTypeName = objDT.Rows[0][convCourseLearningAppraise.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCourseLearningAppraiseEN.UserNameWithUserId = objDT.Rows[0][convCourseLearningAppraise.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId(字段类型:varchar,字段长度:51,是否可空:False)
 objvCourseLearningAppraiseEN.IdXzCollege = objDT.Rows[0][convCourseLearningAppraise.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvCourseLearningAppraiseEN.CollegeID = objDT.Rows[0][convCourseLearningAppraise.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvCourseLearningAppraiseEN.CollegeName = objDT.Rows[0][convCourseLearningAppraise.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCourseLearningAppraiseEN.IdXzMajor = objDT.Rows[0][convCourseLearningAppraise.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningAppraiseEN.MajorID = objDT.Rows[0][convCourseLearningAppraise.MajorID].ToString().Trim(); //专业ID(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningAppraiseEN.MajorName = objDT.Rows[0][convCourseLearningAppraise.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCourseLearningAppraiseEN.CourseId = objDT.Rows[0][convCourseLearningAppraise.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningAppraiseEN.CourseCode = objDT.Rows[0][convCourseLearningAppraise.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvCourseLearningAppraiseEN.CourseName = objDT.Rows[0][convCourseLearningAppraise.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvCourseLearningAppraiseEN.CollegeNameA = objDT.Rows[0][convCourseLearningAppraise.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvCourseLearningAppraiseEN.IdMicroteachAppraise = TransNullToInt(objDT.Rows[0][convCourseLearningAppraise.IdMicroteachAppraise].ToString().Trim()); //评议流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvCourseLearningAppraiseEN.FuncModuleId = objDT.Rows[0][convCourseLearningAppraise.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvCourseLearningAppraiseEN.FuncModuleName = objDT.Rows[0][convCourseLearningAppraise.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCourseLearningAppraiseEN.IdMicroteachCase = objDT.Rows[0][convCourseLearningAppraise.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningAppraiseEN.IdAppraiseType = objDT.Rows[0][convCourseLearningAppraise.IdAppraiseType].ToString().Trim(); //评议类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningAppraiseEN.AppraiseTypeName = objDT.Rows[0][convCourseLearningAppraise.AppraiseTypeName].ToString().Trim(); //评议类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCourseLearningAppraiseEN.AppraiseTheme = objDT.Rows[0][convCourseLearningAppraise.AppraiseTheme].ToString().Trim(); //评议主题(字段类型:varchar,字段长度:200,是否可空:True)
 objvCourseLearningAppraiseEN.AppraiseContent = objDT.Rows[0][convCourseLearningAppraise.AppraiseContent].ToString().Trim(); //评议内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvCourseLearningAppraiseEN.AppraiseDate = objDT.Rows[0][convCourseLearningAppraise.AppraiseDate].ToString().Trim(); //评议日期(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningAppraiseEN.AppraiseTime = objDT.Rows[0][convCourseLearningAppraise.AppraiseTime].ToString().Trim(); //评议时间(字段类型:char,字段长度:6,是否可空:True)
 objvCourseLearningAppraiseEN.IsVisual = TransNullToBool(objDT.Rows[0][convCourseLearningAppraise.IsVisual].ToString().Trim()); //隐藏标志(字段类型:bit,字段长度:1,是否可空:False)
 objvCourseLearningAppraiseEN.IsElite = TransNullToBool(objDT.Rows[0][convCourseLearningAppraise.IsElite].ToString().Trim()); //精华标志(字段类型:bit,字段长度:1,是否可空:False)
 objvCourseLearningAppraiseEN.UserId = objDT.Rows[0][convCourseLearningAppraise.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvCourseLearningAppraiseEN.ExcellentOne = objDT.Rows[0][convCourseLearningAppraise.ExcellentOne].ToString().Trim(); //优点1(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCourseLearningAppraiseEN.ExcellentTwo = objDT.Rows[0][convCourseLearningAppraise.ExcellentTwo].ToString().Trim(); //优点2(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCourseLearningAppraiseEN.SuggestOne = objDT.Rows[0][convCourseLearningAppraise.SuggestOne].ToString().Trim(); //建议1(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCourseLearningAppraiseEN.SuggestTwo = objDT.Rows[0][convCourseLearningAppraise.SuggestTwo].ToString().Trim(); //建议2(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCourseLearningAppraiseEN.MicroteachAppriseScore = TransNullToFloat(objDT.Rows[0][convCourseLearningAppraise.MicroteachAppriseScore].ToString().Trim()); //打分(字段类型:float,字段长度:8,是否可空:True)
 objvCourseLearningAppraiseEN.VideoStopTime = objDT.Rows[0][convCourseLearningAppraise.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间(字段类型:varchar,字段长度:48,是否可空:True)
 objvCourseLearningAppraiseEN.BrowseCount = TransNullToInt(objDT.Rows[0][convCourseLearningAppraise.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvCourseLearningAppraiseEN.BrowseCount4Case = TransNullToInt(objDT.Rows[0][convCourseLearningAppraise.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvCourseLearningAppraiseEN.UserName = objDT.Rows[0][convCourseLearningAppraise.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvCourseLearningAppraiseDA: GetvCourseLearningAppraise)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdMicroteachAppraise">表关键字</param>
 /// <returns>表对象</returns>
public clsvCourseLearningAppraiseEN GetObjByIdMicroteachAppraise(long lngIdMicroteachAppraise)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningAppraiseDA.GetSpecSQLObj();
strSQL = "Select * from vCourseLearningAppraise where IdMicroteachAppraise = " + ""+ lngIdMicroteachAppraise+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN = new clsvCourseLearningAppraiseEN();
try
{
 objvCourseLearningAppraiseEN.IdCourseLearningCase = objRow[convCourseLearningAppraise.IdCourseLearningCase] == DBNull.Value ? null : objRow[convCourseLearningAppraise.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningAppraiseEN.CourseLearningCaseID = objRow[convCourseLearningAppraise.CourseLearningCaseID] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningAppraiseEN.CourseLearningCaseName = objRow[convCourseLearningAppraise.CourseLearningCaseName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCourseLearningAppraiseEN.CourseLearningCaseTheme = objRow[convCourseLearningAppraise.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvCourseLearningAppraiseEN.CourseLearningCaseDate = objRow[convCourseLearningAppraise.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseDate].ToString().Trim(); //课程学习日期(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningAppraiseEN.CourseLearningCaseTime = objRow[convCourseLearningAppraise.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseTime].ToString().Trim(); //课程学习时间(字段类型:char,字段长度:6,是否可空:True)
 objvCourseLearningAppraiseEN.CourseLearningCaseDateIn = objRow[convCourseLearningAppraise.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningAppraiseEN.CourseLearningCaseTimeIn = objRow[convCourseLearningAppraise.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvCourseLearningAppraiseEN.CourseLearningCaseTypeName = objRow[convCourseLearningAppraise.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCourseLearningAppraiseEN.UserNameWithUserId = objRow[convCourseLearningAppraise.UserNameWithUserId] == DBNull.Value ? null : objRow[convCourseLearningAppraise.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId(字段类型:varchar,字段长度:51,是否可空:False)
 objvCourseLearningAppraiseEN.IdXzCollege = objRow[convCourseLearningAppraise.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningAppraise.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvCourseLearningAppraiseEN.CollegeID = objRow[convCourseLearningAppraise.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvCourseLearningAppraiseEN.CollegeName = objRow[convCourseLearningAppraise.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCourseLearningAppraiseEN.IdXzMajor = objRow[convCourseLearningAppraise.IdXzMajor] == DBNull.Value ? null : objRow[convCourseLearningAppraise.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningAppraiseEN.MajorID = objRow[convCourseLearningAppraise.MajorID] == DBNull.Value ? null : objRow[convCourseLearningAppraise.MajorID].ToString().Trim(); //专业ID(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningAppraiseEN.MajorName = objRow[convCourseLearningAppraise.MajorName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCourseLearningAppraiseEN.CourseId = objRow[convCourseLearningAppraise.CourseId] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningAppraiseEN.CourseCode = objRow[convCourseLearningAppraise.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvCourseLearningAppraiseEN.CourseName = objRow[convCourseLearningAppraise.CourseName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvCourseLearningAppraiseEN.CollegeNameA = objRow[convCourseLearningAppraise.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvCourseLearningAppraiseEN.IdMicroteachAppraise = Int32.Parse(objRow[convCourseLearningAppraise.IdMicroteachAppraise].ToString().Trim()); //评议流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvCourseLearningAppraiseEN.FuncModuleId = objRow[convCourseLearningAppraise.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvCourseLearningAppraiseEN.FuncModuleName = objRow[convCourseLearningAppraise.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCourseLearningAppraiseEN.IdMicroteachCase = objRow[convCourseLearningAppraise.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningAppraiseEN.IdAppraiseType = objRow[convCourseLearningAppraise.IdAppraiseType].ToString().Trim(); //评议类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningAppraiseEN.AppraiseTypeName = objRow[convCourseLearningAppraise.AppraiseTypeName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseTypeName].ToString().Trim(); //评议类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCourseLearningAppraiseEN.AppraiseTheme = objRow[convCourseLearningAppraise.AppraiseTheme] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseTheme].ToString().Trim(); //评议主题(字段类型:varchar,字段长度:200,是否可空:True)
 objvCourseLearningAppraiseEN.AppraiseContent = objRow[convCourseLearningAppraise.AppraiseContent] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseContent].ToString().Trim(); //评议内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvCourseLearningAppraiseEN.AppraiseDate = objRow[convCourseLearningAppraise.AppraiseDate] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseDate].ToString().Trim(); //评议日期(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningAppraiseEN.AppraiseTime = objRow[convCourseLearningAppraise.AppraiseTime] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseTime].ToString().Trim(); //评议时间(字段类型:char,字段长度:6,是否可空:True)
 objvCourseLearningAppraiseEN.IsVisual = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningAppraise.IsVisual].ToString().Trim()); //隐藏标志(字段类型:bit,字段长度:1,是否可空:False)
 objvCourseLearningAppraiseEN.IsElite = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningAppraise.IsElite].ToString().Trim()); //精华标志(字段类型:bit,字段长度:1,是否可空:False)
 objvCourseLearningAppraiseEN.UserId = objRow[convCourseLearningAppraise.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvCourseLearningAppraiseEN.ExcellentOne = objRow[convCourseLearningAppraise.ExcellentOne] == DBNull.Value ? null : objRow[convCourseLearningAppraise.ExcellentOne].ToString().Trim(); //优点1(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCourseLearningAppraiseEN.ExcellentTwo = objRow[convCourseLearningAppraise.ExcellentTwo] == DBNull.Value ? null : objRow[convCourseLearningAppraise.ExcellentTwo].ToString().Trim(); //优点2(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCourseLearningAppraiseEN.SuggestOne = objRow[convCourseLearningAppraise.SuggestOne] == DBNull.Value ? null : objRow[convCourseLearningAppraise.SuggestOne].ToString().Trim(); //建议1(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCourseLearningAppraiseEN.SuggestTwo = objRow[convCourseLearningAppraise.SuggestTwo] == DBNull.Value ? null : objRow[convCourseLearningAppraise.SuggestTwo].ToString().Trim(); //建议2(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCourseLearningAppraiseEN.MicroteachAppriseScore = objRow[convCourseLearningAppraise.MicroteachAppriseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convCourseLearningAppraise.MicroteachAppriseScore].ToString().Trim()); //打分(字段类型:float,字段长度:8,是否可空:True)
 objvCourseLearningAppraiseEN.VideoStopTime = objRow[convCourseLearningAppraise.VideoStopTime] == DBNull.Value ? null : objRow[convCourseLearningAppraise.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间(字段类型:varchar,字段长度:48,是否可空:True)
 objvCourseLearningAppraiseEN.BrowseCount = objRow[convCourseLearningAppraise.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningAppraise.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvCourseLearningAppraiseEN.BrowseCount4Case = objRow[convCourseLearningAppraise.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningAppraise.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvCourseLearningAppraiseEN.UserName = objRow[convCourseLearningAppraise.UserName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvCourseLearningAppraiseDA: GetObjByIdMicroteachAppraise)", objException.Message));
}
return objvCourseLearningAppraiseEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvCourseLearningAppraiseEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvCourseLearningAppraiseDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningAppraiseDA.GetSpecSQLObj();
strSQL = "Select * from vCourseLearningAppraise where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN = new clsvCourseLearningAppraiseEN()
{
IdCourseLearningCase = objRow[convCourseLearningAppraise.IdCourseLearningCase] == DBNull.Value ? null : objRow[convCourseLearningAppraise.IdCourseLearningCase].ToString().Trim(), //课程学习案例流水号
CourseLearningCaseID = objRow[convCourseLearningAppraise.CourseLearningCaseID] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseID].ToString().Trim(), //课程学习案例ID
CourseLearningCaseName = objRow[convCourseLearningAppraise.CourseLearningCaseName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseName].ToString().Trim(), //课程学习案例名称
CourseLearningCaseTheme = objRow[convCourseLearningAppraise.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseTheme].ToString().Trim(), //课程学习案例主题词
CourseLearningCaseDate = objRow[convCourseLearningAppraise.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseDate].ToString().Trim(), //课程学习日期
CourseLearningCaseTime = objRow[convCourseLearningAppraise.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseTime].ToString().Trim(), //课程学习时间
CourseLearningCaseDateIn = objRow[convCourseLearningAppraise.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseDateIn].ToString().Trim(), //案例入库日期
CourseLearningCaseTimeIn = objRow[convCourseLearningAppraise.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseTimeIn].ToString().Trim(), //案例入库时间
CourseLearningCaseTypeName = objRow[convCourseLearningAppraise.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseTypeName].ToString().Trim(), //课程学习案例类型名称
UserNameWithUserId = objRow[convCourseLearningAppraise.UserNameWithUserId] == DBNull.Value ? null : objRow[convCourseLearningAppraise.UserNameWithUserId].ToString().Trim(), //UserNameWithUserId
IdXzCollege = objRow[convCourseLearningAppraise.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningAppraise.IdXzCollege].ToString().Trim(), //学院流水号
CollegeID = objRow[convCourseLearningAppraise.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CollegeID].ToString().Trim(), //学院ID
CollegeName = objRow[convCourseLearningAppraise.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CollegeName].ToString().Trim(), //学院名称
IdXzMajor = objRow[convCourseLearningAppraise.IdXzMajor] == DBNull.Value ? null : objRow[convCourseLearningAppraise.IdXzMajor].ToString().Trim(), //专业流水号
MajorID = objRow[convCourseLearningAppraise.MajorID] == DBNull.Value ? null : objRow[convCourseLearningAppraise.MajorID].ToString().Trim(), //专业ID
MajorName = objRow[convCourseLearningAppraise.MajorName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.MajorName].ToString().Trim(), //专业名称
CourseId = objRow[convCourseLearningAppraise.CourseId] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseId].ToString().Trim(), //课程Id
CourseCode = objRow[convCourseLearningAppraise.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseCode].ToString().Trim(), //课程代码
CourseName = objRow[convCourseLearningAppraise.CourseName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseName].ToString().Trim(), //课程名称
CollegeNameA = objRow[convCourseLearningAppraise.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CollegeNameA].ToString().Trim(), //学院名称简写
IdMicroteachAppraise = TransNullToInt(objRow[convCourseLearningAppraise.IdMicroteachAppraise].ToString().Trim()), //评议流水号
FuncModuleId = objRow[convCourseLearningAppraise.FuncModuleId].ToString().Trim(), //功能模块Id
FuncModuleName = objRow[convCourseLearningAppraise.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.FuncModuleName].ToString().Trim(), //功能模块名称
IdMicroteachCase = objRow[convCourseLearningAppraise.IdMicroteachCase].ToString().Trim(), //微格教学案例流水号
IdAppraiseType = objRow[convCourseLearningAppraise.IdAppraiseType].ToString().Trim(), //评议类型流水号
AppraiseTypeName = objRow[convCourseLearningAppraise.AppraiseTypeName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseTypeName].ToString().Trim(), //评议类型名称
AppraiseTheme = objRow[convCourseLearningAppraise.AppraiseTheme] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseTheme].ToString().Trim(), //评议主题
AppraiseContent = objRow[convCourseLearningAppraise.AppraiseContent] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseContent].ToString().Trim(), //评议内容
AppraiseDate = objRow[convCourseLearningAppraise.AppraiseDate] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseDate].ToString().Trim(), //评议日期
AppraiseTime = objRow[convCourseLearningAppraise.AppraiseTime] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseTime].ToString().Trim(), //评议时间
IsVisual = TransNullToBool(objRow[convCourseLearningAppraise.IsVisual].ToString().Trim()), //隐藏标志
IsElite = TransNullToBool(objRow[convCourseLearningAppraise.IsElite].ToString().Trim()), //精华标志
UserId = objRow[convCourseLearningAppraise.UserId].ToString().Trim(), //用户ID
ExcellentOne = objRow[convCourseLearningAppraise.ExcellentOne] == DBNull.Value ? null : objRow[convCourseLearningAppraise.ExcellentOne].ToString().Trim(), //优点1
ExcellentTwo = objRow[convCourseLearningAppraise.ExcellentTwo] == DBNull.Value ? null : objRow[convCourseLearningAppraise.ExcellentTwo].ToString().Trim(), //优点2
SuggestOne = objRow[convCourseLearningAppraise.SuggestOne] == DBNull.Value ? null : objRow[convCourseLearningAppraise.SuggestOne].ToString().Trim(), //建议1
SuggestTwo = objRow[convCourseLearningAppraise.SuggestTwo] == DBNull.Value ? null : objRow[convCourseLearningAppraise.SuggestTwo].ToString().Trim(), //建议2
MicroteachAppriseScore = objRow[convCourseLearningAppraise.MicroteachAppriseScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convCourseLearningAppraise.MicroteachAppriseScore].ToString().Trim()), //打分
VideoStopTime = objRow[convCourseLearningAppraise.VideoStopTime] == DBNull.Value ? null : objRow[convCourseLearningAppraise.VideoStopTime].ToString().Trim(), //公开课案例视频暂停时间
BrowseCount = objRow[convCourseLearningAppraise.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningAppraise.BrowseCount].ToString().Trim()), //浏览次数
BrowseCount4Case = objRow[convCourseLearningAppraise.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningAppraise.BrowseCount4Case].ToString().Trim()), //课例浏览次数
UserName = objRow[convCourseLearningAppraise.UserName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.UserName].ToString().Trim() //用户名
};
objvCourseLearningAppraiseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCourseLearningAppraiseEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvCourseLearningAppraiseDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvCourseLearningAppraiseEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN = new clsvCourseLearningAppraiseEN();
try
{
objvCourseLearningAppraiseEN.IdCourseLearningCase = objRow[convCourseLearningAppraise.IdCourseLearningCase] == DBNull.Value ? null : objRow[convCourseLearningAppraise.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningAppraiseEN.CourseLearningCaseID = objRow[convCourseLearningAppraise.CourseLearningCaseID] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningAppraiseEN.CourseLearningCaseName = objRow[convCourseLearningAppraise.CourseLearningCaseName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningAppraiseEN.CourseLearningCaseTheme = objRow[convCourseLearningAppraise.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningAppraiseEN.CourseLearningCaseDate = objRow[convCourseLearningAppraise.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningAppraiseEN.CourseLearningCaseTime = objRow[convCourseLearningAppraise.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningAppraiseEN.CourseLearningCaseDateIn = objRow[convCourseLearningAppraise.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningAppraiseEN.CourseLearningCaseTimeIn = objRow[convCourseLearningAppraise.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningAppraiseEN.CourseLearningCaseTypeName = objRow[convCourseLearningAppraise.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningAppraiseEN.UserNameWithUserId = objRow[convCourseLearningAppraise.UserNameWithUserId] == DBNull.Value ? null : objRow[convCourseLearningAppraise.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvCourseLearningAppraiseEN.IdXzCollege = objRow[convCourseLearningAppraise.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningAppraise.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningAppraiseEN.CollegeID = objRow[convCourseLearningAppraise.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CollegeID].ToString().Trim(); //学院ID
objvCourseLearningAppraiseEN.CollegeName = objRow[convCourseLearningAppraise.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningAppraiseEN.IdXzMajor = objRow[convCourseLearningAppraise.IdXzMajor] == DBNull.Value ? null : objRow[convCourseLearningAppraise.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningAppraiseEN.MajorID = objRow[convCourseLearningAppraise.MajorID] == DBNull.Value ? null : objRow[convCourseLearningAppraise.MajorID].ToString().Trim(); //专业ID
objvCourseLearningAppraiseEN.MajorName = objRow[convCourseLearningAppraise.MajorName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.MajorName].ToString().Trim(); //专业名称
objvCourseLearningAppraiseEN.CourseId = objRow[convCourseLearningAppraise.CourseId] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseId].ToString().Trim(); //课程Id
objvCourseLearningAppraiseEN.CourseCode = objRow[convCourseLearningAppraise.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningAppraiseEN.CourseName = objRow[convCourseLearningAppraise.CourseName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseName].ToString().Trim(); //课程名称
objvCourseLearningAppraiseEN.CollegeNameA = objRow[convCourseLearningAppraise.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningAppraiseEN.IdMicroteachAppraise = TransNullToInt(objRow[convCourseLearningAppraise.IdMicroteachAppraise].ToString().Trim()); //评议流水号
objvCourseLearningAppraiseEN.FuncModuleId = objRow[convCourseLearningAppraise.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningAppraiseEN.FuncModuleName = objRow[convCourseLearningAppraise.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningAppraiseEN.IdMicroteachCase = objRow[convCourseLearningAppraise.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCourseLearningAppraiseEN.IdAppraiseType = objRow[convCourseLearningAppraise.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvCourseLearningAppraiseEN.AppraiseTypeName = objRow[convCourseLearningAppraise.AppraiseTypeName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvCourseLearningAppraiseEN.AppraiseTheme = objRow[convCourseLearningAppraise.AppraiseTheme] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseTheme].ToString().Trim(); //评议主题
objvCourseLearningAppraiseEN.AppraiseContent = objRow[convCourseLearningAppraise.AppraiseContent] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseContent].ToString().Trim(); //评议内容
objvCourseLearningAppraiseEN.AppraiseDate = objRow[convCourseLearningAppraise.AppraiseDate] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseDate].ToString().Trim(); //评议日期
objvCourseLearningAppraiseEN.AppraiseTime = objRow[convCourseLearningAppraise.AppraiseTime] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseTime].ToString().Trim(); //评议时间
objvCourseLearningAppraiseEN.IsVisual = TransNullToBool(objRow[convCourseLearningAppraise.IsVisual].ToString().Trim()); //隐藏标志
objvCourseLearningAppraiseEN.IsElite = TransNullToBool(objRow[convCourseLearningAppraise.IsElite].ToString().Trim()); //精华标志
objvCourseLearningAppraiseEN.UserId = objRow[convCourseLearningAppraise.UserId].ToString().Trim(); //用户ID
objvCourseLearningAppraiseEN.ExcellentOne = objRow[convCourseLearningAppraise.ExcellentOne] == DBNull.Value ? null : objRow[convCourseLearningAppraise.ExcellentOne].ToString().Trim(); //优点1
objvCourseLearningAppraiseEN.ExcellentTwo = objRow[convCourseLearningAppraise.ExcellentTwo] == DBNull.Value ? null : objRow[convCourseLearningAppraise.ExcellentTwo].ToString().Trim(); //优点2
objvCourseLearningAppraiseEN.SuggestOne = objRow[convCourseLearningAppraise.SuggestOne] == DBNull.Value ? null : objRow[convCourseLearningAppraise.SuggestOne].ToString().Trim(); //建议1
objvCourseLearningAppraiseEN.SuggestTwo = objRow[convCourseLearningAppraise.SuggestTwo] == DBNull.Value ? null : objRow[convCourseLearningAppraise.SuggestTwo].ToString().Trim(); //建议2
objvCourseLearningAppraiseEN.MicroteachAppriseScore = objRow[convCourseLearningAppraise.MicroteachAppriseScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convCourseLearningAppraise.MicroteachAppriseScore].ToString().Trim()); //打分
objvCourseLearningAppraiseEN.VideoStopTime = objRow[convCourseLearningAppraise.VideoStopTime] == DBNull.Value ? null : objRow[convCourseLearningAppraise.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objvCourseLearningAppraiseEN.BrowseCount = objRow[convCourseLearningAppraise.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningAppraise.BrowseCount].ToString().Trim()); //浏览次数
objvCourseLearningAppraiseEN.BrowseCount4Case = objRow[convCourseLearningAppraise.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningAppraise.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningAppraiseEN.UserName = objRow[convCourseLearningAppraise.UserName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.UserName].ToString().Trim(); //用户名
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvCourseLearningAppraiseDA: GetObjByDataRowvCourseLearningAppraise)", objException.Message));
}
objvCourseLearningAppraiseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCourseLearningAppraiseEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvCourseLearningAppraiseEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN = new clsvCourseLearningAppraiseEN();
try
{
objvCourseLearningAppraiseEN.IdCourseLearningCase = objRow[convCourseLearningAppraise.IdCourseLearningCase] == DBNull.Value ? null : objRow[convCourseLearningAppraise.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningAppraiseEN.CourseLearningCaseID = objRow[convCourseLearningAppraise.CourseLearningCaseID] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningAppraiseEN.CourseLearningCaseName = objRow[convCourseLearningAppraise.CourseLearningCaseName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningAppraiseEN.CourseLearningCaseTheme = objRow[convCourseLearningAppraise.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningAppraiseEN.CourseLearningCaseDate = objRow[convCourseLearningAppraise.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningAppraiseEN.CourseLearningCaseTime = objRow[convCourseLearningAppraise.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningAppraiseEN.CourseLearningCaseDateIn = objRow[convCourseLearningAppraise.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningAppraiseEN.CourseLearningCaseTimeIn = objRow[convCourseLearningAppraise.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningAppraiseEN.CourseLearningCaseTypeName = objRow[convCourseLearningAppraise.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningAppraiseEN.UserNameWithUserId = objRow[convCourseLearningAppraise.UserNameWithUserId] == DBNull.Value ? null : objRow[convCourseLearningAppraise.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvCourseLearningAppraiseEN.IdXzCollege = objRow[convCourseLearningAppraise.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningAppraise.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningAppraiseEN.CollegeID = objRow[convCourseLearningAppraise.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CollegeID].ToString().Trim(); //学院ID
objvCourseLearningAppraiseEN.CollegeName = objRow[convCourseLearningAppraise.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningAppraiseEN.IdXzMajor = objRow[convCourseLearningAppraise.IdXzMajor] == DBNull.Value ? null : objRow[convCourseLearningAppraise.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningAppraiseEN.MajorID = objRow[convCourseLearningAppraise.MajorID] == DBNull.Value ? null : objRow[convCourseLearningAppraise.MajorID].ToString().Trim(); //专业ID
objvCourseLearningAppraiseEN.MajorName = objRow[convCourseLearningAppraise.MajorName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.MajorName].ToString().Trim(); //专业名称
objvCourseLearningAppraiseEN.CourseId = objRow[convCourseLearningAppraise.CourseId] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseId].ToString().Trim(); //课程Id
objvCourseLearningAppraiseEN.CourseCode = objRow[convCourseLearningAppraise.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningAppraiseEN.CourseName = objRow[convCourseLearningAppraise.CourseName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseName].ToString().Trim(); //课程名称
objvCourseLearningAppraiseEN.CollegeNameA = objRow[convCourseLearningAppraise.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningAppraiseEN.IdMicroteachAppraise = TransNullToInt(objRow[convCourseLearningAppraise.IdMicroteachAppraise].ToString().Trim()); //评议流水号
objvCourseLearningAppraiseEN.FuncModuleId = objRow[convCourseLearningAppraise.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningAppraiseEN.FuncModuleName = objRow[convCourseLearningAppraise.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningAppraiseEN.IdMicroteachCase = objRow[convCourseLearningAppraise.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCourseLearningAppraiseEN.IdAppraiseType = objRow[convCourseLearningAppraise.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvCourseLearningAppraiseEN.AppraiseTypeName = objRow[convCourseLearningAppraise.AppraiseTypeName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvCourseLearningAppraiseEN.AppraiseTheme = objRow[convCourseLearningAppraise.AppraiseTheme] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseTheme].ToString().Trim(); //评议主题
objvCourseLearningAppraiseEN.AppraiseContent = objRow[convCourseLearningAppraise.AppraiseContent] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseContent].ToString().Trim(); //评议内容
objvCourseLearningAppraiseEN.AppraiseDate = objRow[convCourseLearningAppraise.AppraiseDate] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseDate].ToString().Trim(); //评议日期
objvCourseLearningAppraiseEN.AppraiseTime = objRow[convCourseLearningAppraise.AppraiseTime] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseTime].ToString().Trim(); //评议时间
objvCourseLearningAppraiseEN.IsVisual = TransNullToBool(objRow[convCourseLearningAppraise.IsVisual].ToString().Trim()); //隐藏标志
objvCourseLearningAppraiseEN.IsElite = TransNullToBool(objRow[convCourseLearningAppraise.IsElite].ToString().Trim()); //精华标志
objvCourseLearningAppraiseEN.UserId = objRow[convCourseLearningAppraise.UserId].ToString().Trim(); //用户ID
objvCourseLearningAppraiseEN.ExcellentOne = objRow[convCourseLearningAppraise.ExcellentOne] == DBNull.Value ? null : objRow[convCourseLearningAppraise.ExcellentOne].ToString().Trim(); //优点1
objvCourseLearningAppraiseEN.ExcellentTwo = objRow[convCourseLearningAppraise.ExcellentTwo] == DBNull.Value ? null : objRow[convCourseLearningAppraise.ExcellentTwo].ToString().Trim(); //优点2
objvCourseLearningAppraiseEN.SuggestOne = objRow[convCourseLearningAppraise.SuggestOne] == DBNull.Value ? null : objRow[convCourseLearningAppraise.SuggestOne].ToString().Trim(); //建议1
objvCourseLearningAppraiseEN.SuggestTwo = objRow[convCourseLearningAppraise.SuggestTwo] == DBNull.Value ? null : objRow[convCourseLearningAppraise.SuggestTwo].ToString().Trim(); //建议2
objvCourseLearningAppraiseEN.MicroteachAppriseScore = objRow[convCourseLearningAppraise.MicroteachAppriseScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convCourseLearningAppraise.MicroteachAppriseScore].ToString().Trim()); //打分
objvCourseLearningAppraiseEN.VideoStopTime = objRow[convCourseLearningAppraise.VideoStopTime] == DBNull.Value ? null : objRow[convCourseLearningAppraise.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objvCourseLearningAppraiseEN.BrowseCount = objRow[convCourseLearningAppraise.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningAppraise.BrowseCount].ToString().Trim()); //浏览次数
objvCourseLearningAppraiseEN.BrowseCount4Case = objRow[convCourseLearningAppraise.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningAppraise.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningAppraiseEN.UserName = objRow[convCourseLearningAppraise.UserName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.UserName].ToString().Trim(); //用户名
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvCourseLearningAppraiseDA: GetObjByDataRow)", objException.Message));
}
objvCourseLearningAppraiseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCourseLearningAppraiseEN;
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
objSQL = clsvCourseLearningAppraiseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCourseLearningAppraiseEN._CurrTabName, convCourseLearningAppraise.IdMicroteachAppraise, 8, "");
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
objSQL = clsvCourseLearningAppraiseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCourseLearningAppraiseEN._CurrTabName, convCourseLearningAppraise.IdMicroteachAppraise, 8, strPrefix);
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
 objSQL = clsvCourseLearningAppraiseDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdMicroteachAppraise from vCourseLearningAppraise where " + strCondition;
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
 objSQL = clsvCourseLearningAppraiseDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdMicroteachAppraise from vCourseLearningAppraise where " + strCondition;
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
 /// <param name = "lngIdMicroteachAppraise">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngIdMicroteachAppraise)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningAppraiseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCourseLearningAppraise", "IdMicroteachAppraise = " + ""+ lngIdMicroteachAppraise+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvCourseLearningAppraiseDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningAppraiseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCourseLearningAppraise", strCondition))
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
objSQL = clsvCourseLearningAppraiseDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vCourseLearningAppraise");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseENS">源对象</param>
 /// <param name = "objvCourseLearningAppraiseENT">目标对象</param>
public void CopyTo(clsvCourseLearningAppraiseEN objvCourseLearningAppraiseENS, clsvCourseLearningAppraiseEN objvCourseLearningAppraiseENT)
{
objvCourseLearningAppraiseENT.IdCourseLearningCase = objvCourseLearningAppraiseENS.IdCourseLearningCase; //课程学习案例流水号
objvCourseLearningAppraiseENT.CourseLearningCaseID = objvCourseLearningAppraiseENS.CourseLearningCaseID; //课程学习案例ID
objvCourseLearningAppraiseENT.CourseLearningCaseName = objvCourseLearningAppraiseENS.CourseLearningCaseName; //课程学习案例名称
objvCourseLearningAppraiseENT.CourseLearningCaseTheme = objvCourseLearningAppraiseENS.CourseLearningCaseTheme; //课程学习案例主题词
objvCourseLearningAppraiseENT.CourseLearningCaseDate = objvCourseLearningAppraiseENS.CourseLearningCaseDate; //课程学习日期
objvCourseLearningAppraiseENT.CourseLearningCaseTime = objvCourseLearningAppraiseENS.CourseLearningCaseTime; //课程学习时间
objvCourseLearningAppraiseENT.CourseLearningCaseDateIn = objvCourseLearningAppraiseENS.CourseLearningCaseDateIn; //案例入库日期
objvCourseLearningAppraiseENT.CourseLearningCaseTimeIn = objvCourseLearningAppraiseENS.CourseLearningCaseTimeIn; //案例入库时间
objvCourseLearningAppraiseENT.CourseLearningCaseTypeName = objvCourseLearningAppraiseENS.CourseLearningCaseTypeName; //课程学习案例类型名称
objvCourseLearningAppraiseENT.UserNameWithUserId = objvCourseLearningAppraiseENS.UserNameWithUserId; //UserNameWithUserId
objvCourseLearningAppraiseENT.IdXzCollege = objvCourseLearningAppraiseENS.IdXzCollege; //学院流水号
objvCourseLearningAppraiseENT.CollegeID = objvCourseLearningAppraiseENS.CollegeID; //学院ID
objvCourseLearningAppraiseENT.CollegeName = objvCourseLearningAppraiseENS.CollegeName; //学院名称
objvCourseLearningAppraiseENT.IdXzMajor = objvCourseLearningAppraiseENS.IdXzMajor; //专业流水号
objvCourseLearningAppraiseENT.MajorID = objvCourseLearningAppraiseENS.MajorID; //专业ID
objvCourseLearningAppraiseENT.MajorName = objvCourseLearningAppraiseENS.MajorName; //专业名称
objvCourseLearningAppraiseENT.CourseId = objvCourseLearningAppraiseENS.CourseId; //课程Id
objvCourseLearningAppraiseENT.CourseCode = objvCourseLearningAppraiseENS.CourseCode; //课程代码
objvCourseLearningAppraiseENT.CourseName = objvCourseLearningAppraiseENS.CourseName; //课程名称
objvCourseLearningAppraiseENT.CollegeNameA = objvCourseLearningAppraiseENS.CollegeNameA; //学院名称简写
objvCourseLearningAppraiseENT.IdMicroteachAppraise = objvCourseLearningAppraiseENS.IdMicroteachAppraise; //评议流水号
objvCourseLearningAppraiseENT.FuncModuleId = objvCourseLearningAppraiseENS.FuncModuleId; //功能模块Id
objvCourseLearningAppraiseENT.FuncModuleName = objvCourseLearningAppraiseENS.FuncModuleName; //功能模块名称
objvCourseLearningAppraiseENT.IdMicroteachCase = objvCourseLearningAppraiseENS.IdMicroteachCase; //微格教学案例流水号
objvCourseLearningAppraiseENT.IdAppraiseType = objvCourseLearningAppraiseENS.IdAppraiseType; //评议类型流水号
objvCourseLearningAppraiseENT.AppraiseTypeName = objvCourseLearningAppraiseENS.AppraiseTypeName; //评议类型名称
objvCourseLearningAppraiseENT.AppraiseTheme = objvCourseLearningAppraiseENS.AppraiseTheme; //评议主题
objvCourseLearningAppraiseENT.AppraiseContent = objvCourseLearningAppraiseENS.AppraiseContent; //评议内容
objvCourseLearningAppraiseENT.AppraiseDate = objvCourseLearningAppraiseENS.AppraiseDate; //评议日期
objvCourseLearningAppraiseENT.AppraiseTime = objvCourseLearningAppraiseENS.AppraiseTime; //评议时间
objvCourseLearningAppraiseENT.IsVisual = objvCourseLearningAppraiseENS.IsVisual; //隐藏标志
objvCourseLearningAppraiseENT.IsElite = objvCourseLearningAppraiseENS.IsElite; //精华标志
objvCourseLearningAppraiseENT.UserId = objvCourseLearningAppraiseENS.UserId; //用户ID
objvCourseLearningAppraiseENT.ExcellentOne = objvCourseLearningAppraiseENS.ExcellentOne; //优点1
objvCourseLearningAppraiseENT.ExcellentTwo = objvCourseLearningAppraiseENS.ExcellentTwo; //优点2
objvCourseLearningAppraiseENT.SuggestOne = objvCourseLearningAppraiseENS.SuggestOne; //建议1
objvCourseLearningAppraiseENT.SuggestTwo = objvCourseLearningAppraiseENS.SuggestTwo; //建议2
objvCourseLearningAppraiseENT.MicroteachAppriseScore = objvCourseLearningAppraiseENS.MicroteachAppriseScore; //打分
objvCourseLearningAppraiseENT.VideoStopTime = objvCourseLearningAppraiseENS.VideoStopTime; //公开课案例视频暂停时间
objvCourseLearningAppraiseENT.BrowseCount = objvCourseLearningAppraiseENS.BrowseCount; //浏览次数
objvCourseLearningAppraiseENT.BrowseCount4Case = objvCourseLearningAppraiseENS.BrowseCount4Case; //课例浏览次数
objvCourseLearningAppraiseENT.UserName = objvCourseLearningAppraiseENS.UserName; //用户名
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvCourseLearningAppraiseEN.IdCourseLearningCase, 8, convCourseLearningAppraise.IdCourseLearningCase);
clsCheckSql.CheckFieldLen(objvCourseLearningAppraiseEN.CourseLearningCaseID, 8, convCourseLearningAppraise.CourseLearningCaseID);
clsCheckSql.CheckFieldLen(objvCourseLearningAppraiseEN.CourseLearningCaseName, 100, convCourseLearningAppraise.CourseLearningCaseName);
clsCheckSql.CheckFieldLen(objvCourseLearningAppraiseEN.CourseLearningCaseTheme, 200, convCourseLearningAppraise.CourseLearningCaseTheme);
clsCheckSql.CheckFieldLen(objvCourseLearningAppraiseEN.CourseLearningCaseDate, 8, convCourseLearningAppraise.CourseLearningCaseDate);
clsCheckSql.CheckFieldLen(objvCourseLearningAppraiseEN.CourseLearningCaseTime, 6, convCourseLearningAppraise.CourseLearningCaseTime);
clsCheckSql.CheckFieldLen(objvCourseLearningAppraiseEN.CourseLearningCaseDateIn, 8, convCourseLearningAppraise.CourseLearningCaseDateIn);
clsCheckSql.CheckFieldLen(objvCourseLearningAppraiseEN.CourseLearningCaseTimeIn, 6, convCourseLearningAppraise.CourseLearningCaseTimeIn);
clsCheckSql.CheckFieldLen(objvCourseLearningAppraiseEN.CourseLearningCaseTypeName, 30, convCourseLearningAppraise.CourseLearningCaseTypeName);
clsCheckSql.CheckFieldLen(objvCourseLearningAppraiseEN.UserNameWithUserId, 51, convCourseLearningAppraise.UserNameWithUserId);
clsCheckSql.CheckFieldLen(objvCourseLearningAppraiseEN.IdXzCollege, 4, convCourseLearningAppraise.IdXzCollege);
clsCheckSql.CheckFieldLen(objvCourseLearningAppraiseEN.CollegeID, 4, convCourseLearningAppraise.CollegeID);
clsCheckSql.CheckFieldLen(objvCourseLearningAppraiseEN.CollegeName, 100, convCourseLearningAppraise.CollegeName);
clsCheckSql.CheckFieldLen(objvCourseLearningAppraiseEN.IdXzMajor, 8, convCourseLearningAppraise.IdXzMajor);
clsCheckSql.CheckFieldLen(objvCourseLearningAppraiseEN.MajorID, 4, convCourseLearningAppraise.MajorID);
clsCheckSql.CheckFieldLen(objvCourseLearningAppraiseEN.MajorName, 100, convCourseLearningAppraise.MajorName);
clsCheckSql.CheckFieldLen(objvCourseLearningAppraiseEN.CourseId, 8, convCourseLearningAppraise.CourseId);
clsCheckSql.CheckFieldLen(objvCourseLearningAppraiseEN.CourseCode, 20, convCourseLearningAppraise.CourseCode);
clsCheckSql.CheckFieldLen(objvCourseLearningAppraiseEN.CourseName, 100, convCourseLearningAppraise.CourseName);
clsCheckSql.CheckFieldLen(objvCourseLearningAppraiseEN.CollegeNameA, 12, convCourseLearningAppraise.CollegeNameA);
clsCheckSql.CheckFieldLen(objvCourseLearningAppraiseEN.FuncModuleId, 4, convCourseLearningAppraise.FuncModuleId);
clsCheckSql.CheckFieldLen(objvCourseLearningAppraiseEN.FuncModuleName, 30, convCourseLearningAppraise.FuncModuleName);
clsCheckSql.CheckFieldLen(objvCourseLearningAppraiseEN.IdMicroteachCase, 8, convCourseLearningAppraise.IdMicroteachCase);
clsCheckSql.CheckFieldLen(objvCourseLearningAppraiseEN.IdAppraiseType, 4, convCourseLearningAppraise.IdAppraiseType);
clsCheckSql.CheckFieldLen(objvCourseLearningAppraiseEN.AppraiseTypeName, 50, convCourseLearningAppraise.AppraiseTypeName);
clsCheckSql.CheckFieldLen(objvCourseLearningAppraiseEN.AppraiseTheme, 200, convCourseLearningAppraise.AppraiseTheme);
clsCheckSql.CheckFieldLen(objvCourseLearningAppraiseEN.AppraiseContent, 2000, convCourseLearningAppraise.AppraiseContent);
clsCheckSql.CheckFieldLen(objvCourseLearningAppraiseEN.AppraiseDate, 8, convCourseLearningAppraise.AppraiseDate);
clsCheckSql.CheckFieldLen(objvCourseLearningAppraiseEN.AppraiseTime, 6, convCourseLearningAppraise.AppraiseTime);
clsCheckSql.CheckFieldLen(objvCourseLearningAppraiseEN.UserId, 18, convCourseLearningAppraise.UserId);
clsCheckSql.CheckFieldLen(objvCourseLearningAppraiseEN.ExcellentOne, 1000, convCourseLearningAppraise.ExcellentOne);
clsCheckSql.CheckFieldLen(objvCourseLearningAppraiseEN.ExcellentTwo, 1000, convCourseLearningAppraise.ExcellentTwo);
clsCheckSql.CheckFieldLen(objvCourseLearningAppraiseEN.SuggestOne, 1000, convCourseLearningAppraise.SuggestOne);
clsCheckSql.CheckFieldLen(objvCourseLearningAppraiseEN.SuggestTwo, 1000, convCourseLearningAppraise.SuggestTwo);
clsCheckSql.CheckFieldLen(objvCourseLearningAppraiseEN.VideoStopTime, 48, convCourseLearningAppraise.VideoStopTime);
clsCheckSql.CheckFieldLen(objvCourseLearningAppraiseEN.UserName, 30, convCourseLearningAppraise.UserName);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningAppraiseEN.IdCourseLearningCase, convCourseLearningAppraise.IdCourseLearningCase);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningAppraiseEN.CourseLearningCaseID, convCourseLearningAppraise.CourseLearningCaseID);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningAppraiseEN.CourseLearningCaseName, convCourseLearningAppraise.CourseLearningCaseName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningAppraiseEN.CourseLearningCaseTheme, convCourseLearningAppraise.CourseLearningCaseTheme);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningAppraiseEN.CourseLearningCaseDate, convCourseLearningAppraise.CourseLearningCaseDate);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningAppraiseEN.CourseLearningCaseTime, convCourseLearningAppraise.CourseLearningCaseTime);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningAppraiseEN.CourseLearningCaseDateIn, convCourseLearningAppraise.CourseLearningCaseDateIn);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningAppraiseEN.CourseLearningCaseTimeIn, convCourseLearningAppraise.CourseLearningCaseTimeIn);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningAppraiseEN.CourseLearningCaseTypeName, convCourseLearningAppraise.CourseLearningCaseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningAppraiseEN.UserNameWithUserId, convCourseLearningAppraise.UserNameWithUserId);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningAppraiseEN.IdXzCollege, convCourseLearningAppraise.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningAppraiseEN.CollegeID, convCourseLearningAppraise.CollegeID);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningAppraiseEN.CollegeName, convCourseLearningAppraise.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningAppraiseEN.IdXzMajor, convCourseLearningAppraise.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningAppraiseEN.MajorID, convCourseLearningAppraise.MajorID);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningAppraiseEN.MajorName, convCourseLearningAppraise.MajorName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningAppraiseEN.CourseId, convCourseLearningAppraise.CourseId);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningAppraiseEN.CourseCode, convCourseLearningAppraise.CourseCode);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningAppraiseEN.CourseName, convCourseLearningAppraise.CourseName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningAppraiseEN.CollegeNameA, convCourseLearningAppraise.CollegeNameA);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningAppraiseEN.FuncModuleId, convCourseLearningAppraise.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningAppraiseEN.FuncModuleName, convCourseLearningAppraise.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningAppraiseEN.IdMicroteachCase, convCourseLearningAppraise.IdMicroteachCase);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningAppraiseEN.IdAppraiseType, convCourseLearningAppraise.IdAppraiseType);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningAppraiseEN.AppraiseTypeName, convCourseLearningAppraise.AppraiseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningAppraiseEN.AppraiseTheme, convCourseLearningAppraise.AppraiseTheme);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningAppraiseEN.AppraiseContent, convCourseLearningAppraise.AppraiseContent);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningAppraiseEN.AppraiseDate, convCourseLearningAppraise.AppraiseDate);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningAppraiseEN.AppraiseTime, convCourseLearningAppraise.AppraiseTime);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningAppraiseEN.UserId, convCourseLearningAppraise.UserId);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningAppraiseEN.ExcellentOne, convCourseLearningAppraise.ExcellentOne);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningAppraiseEN.ExcellentTwo, convCourseLearningAppraise.ExcellentTwo);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningAppraiseEN.SuggestOne, convCourseLearningAppraise.SuggestOne);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningAppraiseEN.SuggestTwo, convCourseLearningAppraise.SuggestTwo);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningAppraiseEN.VideoStopTime, convCourseLearningAppraise.VideoStopTime);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningAppraiseEN.UserName, convCourseLearningAppraise.UserName);
//检查外键字段长度
 objvCourseLearningAppraiseEN._IsCheckProperty = true;
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
 objSQL = clsvCourseLearningAppraiseDA.GetSpecSQLObj();
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
 objSQL = clsvCourseLearningAppraiseDA.GetSpecSQLObj();
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
 objSQL = clsvCourseLearningAppraiseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCourseLearningAppraiseEN._CurrTabName);
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
 objSQL = clsvCourseLearningAppraiseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCourseLearningAppraiseEN._CurrTabName, strCondition);
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
 objSQL = clsvCourseLearningAppraiseDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}