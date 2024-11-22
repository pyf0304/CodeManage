
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCourseLearningCase_Resource_RelDA
 表名:vCourseLearningCase_Resource_Rel(01120434)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:45:44
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
 /// v课程学习案例资源关系(vCourseLearningCase_Resource_Rel)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvCourseLearningCase_Resource_RelDA : clsCommBase4DA
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
 return clsvCourseLearningCase_Resource_RelEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvCourseLearningCase_Resource_RelEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCourseLearningCase_Resource_RelEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvCourseLearningCase_Resource_RelEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvCourseLearningCase_Resource_RelEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvCourseLearningCase_Resource_RelDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vCourseLearningCase_Resource_Rel where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vCourseLearningCase_Resource_Rel(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvCourseLearningCase_Resource_RelDA: GetDataTable_vCourseLearningCase_Resource_Rel)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vCourseLearningCase_Resource_Rel where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvCourseLearningCase_Resource_RelDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCase_Resource_RelDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvCourseLearningCase_Resource_RelDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vCourseLearningCase_Resource_Rel where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvCourseLearningCase_Resource_RelDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCase_Resource_RelDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvCourseLearningCase_Resource_RelDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCase_Resource_RelDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCourseLearningCase_Resource_Rel where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCourseLearningCase_Resource_Rel where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvCourseLearningCase_Resource_RelDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCase_Resource_RelDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vCourseLearningCase_Resource_Rel where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvCourseLearningCase_Resource_RelDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCase_Resource_RelDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vCourseLearningCase_Resource_Rel.* from vCourseLearningCase_Resource_Rel Left Join {1} on {2} where {3} and vCourseLearningCase_Resource_Rel.IdMicroteachCaseResourceRel not in (Select top {5} vCourseLearningCase_Resource_Rel.IdMicroteachCaseResourceRel from vCourseLearningCase_Resource_Rel Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCourseLearningCase_Resource_Rel where {1} and IdMicroteachCaseResourceRel not in (Select top {2} IdMicroteachCaseResourceRel from vCourseLearningCase_Resource_Rel where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCourseLearningCase_Resource_Rel where {1} and IdMicroteachCaseResourceRel not in (Select top {3} IdMicroteachCaseResourceRel from vCourseLearningCase_Resource_Rel where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvCourseLearningCase_Resource_RelDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCase_Resource_RelDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vCourseLearningCase_Resource_Rel.* from vCourseLearningCase_Resource_Rel Left Join {1} on {2} where {3} and vCourseLearningCase_Resource_Rel.IdMicroteachCaseResourceRel not in (Select top {5} vCourseLearningCase_Resource_Rel.IdMicroteachCaseResourceRel from vCourseLearningCase_Resource_Rel Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCourseLearningCase_Resource_Rel where {1} and IdMicroteachCaseResourceRel not in (Select top {2} IdMicroteachCaseResourceRel from vCourseLearningCase_Resource_Rel where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCourseLearningCase_Resource_Rel where {1} and IdMicroteachCaseResourceRel not in (Select top {3} IdMicroteachCaseResourceRel from vCourseLearningCase_Resource_Rel where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvCourseLearningCase_Resource_RelEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvCourseLearningCase_Resource_RelDA:GetObjLst)", objException.Message));
}
List<clsvCourseLearningCase_Resource_RelEN> arrObjLst = new List<clsvCourseLearningCase_Resource_RelEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vCourseLearningCase_Resource_Rel where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN = new clsvCourseLearningCase_Resource_RelEN();
try
{
objvCourseLearningCase_Resource_RelEN.IdMicroteachCaseResourceRel = TransNullToInt(objRow[convCourseLearningCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvCourseLearningCase_Resource_RelEN.FuncModuleId = objRow[convCourseLearningCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningCase_Resource_RelEN.FuncModuleName = objRow[convCourseLearningCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningCase_Resource_RelEN.IdMicroteachCase = objRow[convCourseLearningCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseID = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseName = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseText = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseText] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseText].ToString().Trim(); //案例文本内容
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTheme = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseDate = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTime = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseDateIn = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningCase_Resource_RelEN.IdCourseLearningCaseType = objRow[convCourseLearningCase_Resource_Rel.IdCourseLearningCaseType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTypeName = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningCase_Resource_RelEN.OwnerId = objRow[convCourseLearningCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvCourseLearningCase_Resource_RelEN.OwnerName = objRow[convCourseLearningCase_Resource_Rel.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.OwnerName].ToString().Trim(); //拥有者姓名
objvCourseLearningCase_Resource_RelEN.OwnerNameWithId = objRow[convCourseLearningCase_Resource_Rel.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCourseLearningCase_Resource_RelEN.IdXzMajor = objRow[convCourseLearningCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningCase_Resource_RelEN.MajorID = objRow[convCourseLearningCase_Resource_Rel.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCase_Resource_RelEN.MajorName = objRow[convCourseLearningCase_Resource_Rel.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCase_Resource_RelEN.IdXzCollege = objRow[convCourseLearningCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCase_Resource_RelEN.CollegeID = objRow[convCourseLearningCase_Resource_Rel.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CollegeID].ToString().Trim(); //学院ID
objvCourseLearningCase_Resource_RelEN.CollegeName = objRow[convCourseLearningCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCase_Resource_RelEN.IdTeachSkill = objRow[convCourseLearningCase_Resource_Rel.IdTeachSkill] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCourseLearningCase_Resource_RelEN.TeachSkillID = objRow[convCourseLearningCase_Resource_Rel.TeachSkillID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID
objvCourseLearningCase_Resource_RelEN.TeachSkillName = objRow[convCourseLearningCase_Resource_Rel.TeachSkillName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称
objvCourseLearningCase_Resource_RelEN.TeachSkillTheory = objRow[convCourseLearningCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCourseLearningCase_Resource_RelEN.TeachSkillOperMethod = objRow[convCourseLearningCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCourseLearningCase_Resource_RelEN.SkillTypeID = objRow[convCourseLearningCase_Resource_Rel.SkillTypeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID
objvCourseLearningCase_Resource_RelEN.SkillTypeName = objRow[convCourseLearningCase_Resource_Rel.SkillTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称
objvCourseLearningCase_Resource_RelEN.IdDiscipline = objRow[convCourseLearningCase_Resource_Rel.IdDiscipline] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvCourseLearningCase_Resource_RelEN.DisciplineID = objRow[convCourseLearningCase_Resource_Rel.DisciplineID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID
objvCourseLearningCase_Resource_RelEN.DisciplineName = objRow[convCourseLearningCase_Resource_Rel.DisciplineName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvCourseLearningCase_Resource_RelEN.IdStudyLevel = objRow[convCourseLearningCase_Resource_Rel.IdStudyLevel] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCourseLearningCase_Resource_RelEN.StudyLevelName = objRow[convCourseLearningCase_Resource_Rel.StudyLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvCourseLearningCase_Resource_RelEN.IdFile = objRow[convCourseLearningCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvCourseLearningCase_Resource_RelEN.FileName = objRow[convCourseLearningCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvCourseLearningCase_Resource_RelEN.FileType = objRow[convCourseLearningCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvCourseLearningCase_Resource_RelEN.SaveDate = objRow[convCourseLearningCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvCourseLearningCase_Resource_RelEN.FileSize = objRow[convCourseLearningCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvCourseLearningCase_Resource_RelEN.SaveTime = objRow[convCourseLearningCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvCourseLearningCase_Resource_RelEN.IdSkillType = objRow[convCourseLearningCase_Resource_Rel.IdSkillType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号
objvCourseLearningCase_Resource_RelEN.IdTeachingPlan = objRow[convCourseLearningCase_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCourseLearningCase_Resource_RelEN.IdFtpResource = objRow[convCourseLearningCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvCourseLearningCase_Resource_RelEN.FtpResourceID = objRow[convCourseLearningCase_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvCourseLearningCase_Resource_RelEN.FileOriginalName = objRow[convCourseLearningCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvCourseLearningCase_Resource_RelEN.FileDirName = objRow[convCourseLearningCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvCourseLearningCase_Resource_RelEN.FileRename = objRow[convCourseLearningCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvCourseLearningCase_Resource_RelEN.FileUpDate = objRow[convCourseLearningCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvCourseLearningCase_Resource_RelEN.FileUpTime = objRow[convCourseLearningCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvCourseLearningCase_Resource_RelEN.IdResource = objRow[convCourseLearningCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvCourseLearningCase_Resource_RelEN.ResourceID = objRow[convCourseLearningCase_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvCourseLearningCase_Resource_RelEN.SaveMode = TransNullToBool(objRow[convCourseLearningCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvCourseLearningCase_Resource_RelEN.IsMain = TransNullToBool(objRow[convCourseLearningCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvCourseLearningCase_Resource_RelEN.IdResourceType = objRow[convCourseLearningCase_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvCourseLearningCase_Resource_RelEN.ResourceTypeID = objRow[convCourseLearningCase_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvCourseLearningCase_Resource_RelEN.ResourceTypeName = objRow[convCourseLearningCase_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvCourseLearningCase_Resource_RelEN.IdUsingMode = objRow[convCourseLearningCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvCourseLearningCase_Resource_RelEN.IndexNO = objRow[convCourseLearningCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvCourseLearningCase_Resource_RelEN.CourseId = objRow[convCourseLearningCase_Resource_Rel.CourseId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCase_Resource_RelEN.CourseCode = objRow[convCourseLearningCase_Resource_Rel.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCase_Resource_RelEN.CourseName = objRow[convCourseLearningCase_Resource_Rel.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCase_Resource_RelEN.BrowseCount = objRow[convCourseLearningCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvCourseLearningCase_Resource_RelEN.ResourceName = objRow[convCourseLearningCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvCourseLearningCase_Resource_RelEN.ResourceOwner = objRow[convCourseLearningCase_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvCourseLearningCase_Resource_RelEN.ftpFileType = objRow[convCourseLearningCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvCourseLearningCase_Resource_RelEN.ftpFileSize = objRow[convCourseLearningCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvCourseLearningCase_Resource_RelEN.ftpResourceOwner = objRow[convCourseLearningCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvCourseLearningCase_Resource_RelEN.VersionNo = objRow[convCourseLearningCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvCourseLearningCase_Resource_RelEN.FileOriginName = objRow[convCourseLearningCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvCourseLearningCase_Resource_RelEN.senateGaugeVersionID = objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCourseLearningCase_Resource_RelEN.senateGaugeVersionName = objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCourseLearningCase_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCourseLearningCase_Resource_RelEN.CaseLevelId = objRow[convCourseLearningCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvCourseLearningCase_Resource_RelEN.IsExistFile = TransNullToBool(objRow[convCourseLearningCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvCourseLearningCase_Resource_RelEN.BrowseCount4Case = objRow[convCourseLearningCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningCase_Resource_RelEN.FileNewName = objRow[convCourseLearningCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvCourseLearningCase_Resource_RelEN.FileOldName = objRow[convCourseLearningCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvCourseLearningCase_Resource_RelEN.IsDualVideo = TransNullToBool(objRow[convCourseLearningCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCase_Resource_RelEN.ViewCount = objRow[convCourseLearningCase_Resource_Rel.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase_Resource_Rel.ViewCount].ToString().Trim()); //浏览量
objvCourseLearningCase_Resource_RelEN.IsShow = TransNullToBool(objRow[convCourseLearningCase_Resource_Rel.IsShow].ToString().Trim()); //是否启用
objvCourseLearningCase_Resource_RelEN.DownloadNumber = objRow[convCourseLearningCase_Resource_Rel.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase_Resource_Rel.DownloadNumber].ToString().Trim()); //下载数目
objvCourseLearningCase_Resource_RelEN.FileIntegration = objRow[convCourseLearningCase_Resource_Rel.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase_Resource_Rel.FileIntegration].ToString().Trim()); //文件积分
objvCourseLearningCase_Resource_RelEN.LikeCount = objRow[convCourseLearningCase_Resource_Rel.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCourseLearningCase_Resource_Rel.LikeCount].ToString().Trim()); //资源喜欢数量
objvCourseLearningCase_Resource_RelEN.CollectionCount = objRow[convCourseLearningCase_Resource_Rel.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCourseLearningCase_Resource_Rel.CollectionCount].ToString().Trim()); //收藏数量
objvCourseLearningCase_Resource_RelEN.IsVisible = TransNullToBool(objRow[convCourseLearningCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvCourseLearningCase_Resource_RelEN.UpdDate = objRow[convCourseLearningCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvCourseLearningCase_Resource_RelEN.UpdUser = objRow[convCourseLearningCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvCourseLearningCase_Resource_RelEN.Memo = objRow[convCourseLearningCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.Memo].ToString().Trim(); //备注
objvCourseLearningCase_Resource_RelEN.RecommendedDegreeId = objRow[convCourseLearningCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCourseLearningCase_Resource_RelEN.RecommendedDegreeName = objRow[convCourseLearningCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCourseLearningCase_Resource_RelEN.CollegeNameA = objRow[convCourseLearningCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningCase_Resource_RelEN.CourseChapterId = objRow[convCourseLearningCase_Resource_Rel.CourseChapterId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCase_Resource_RelEN.CourseChapterName = objRow[convCourseLearningCase_Resource_Rel.CourseChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseChapterName].ToString().Trim(); //课程章节名称
objvCourseLearningCase_Resource_RelEN.CourseChapterReferred = objRow[convCourseLearningCase_Resource_Rel.CourseChapterReferred] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseChapterReferred].ToString().Trim(); //节简称
objvCourseLearningCase_Resource_RelEN.ParentNodeReferred = objRow[convCourseLearningCase_Resource_Rel.ParentNodeReferred] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ParentNodeReferred].ToString().Trim(); //章简称
objvCourseLearningCase_Resource_RelEN.ParentNodeID = objRow[convCourseLearningCase_Resource_Rel.ParentNodeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ParentNodeID].ToString().Trim(); //父节点编号
objvCourseLearningCase_Resource_RelEN.ParentNodeName = objRow[convCourseLearningCase_Resource_Rel.ParentNodeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ParentNodeName].ToString().Trim(); //父节点名称
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCourseLearningCase_Resource_RelDA: GetObjLst)", objException.Message));
}
objvCourseLearningCase_Resource_RelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCourseLearningCase_Resource_RelEN);
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
public List<clsvCourseLearningCase_Resource_RelEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvCourseLearningCase_Resource_RelDA:GetObjLstByTabName)", objException.Message));
}
List<clsvCourseLearningCase_Resource_RelEN> arrObjLst = new List<clsvCourseLearningCase_Resource_RelEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCase_Resource_RelDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN = new clsvCourseLearningCase_Resource_RelEN();
try
{
objvCourseLearningCase_Resource_RelEN.IdMicroteachCaseResourceRel = TransNullToInt(objRow[convCourseLearningCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvCourseLearningCase_Resource_RelEN.FuncModuleId = objRow[convCourseLearningCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningCase_Resource_RelEN.FuncModuleName = objRow[convCourseLearningCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningCase_Resource_RelEN.IdMicroteachCase = objRow[convCourseLearningCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseID = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseName = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseText = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseText] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseText].ToString().Trim(); //案例文本内容
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTheme = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseDate = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTime = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseDateIn = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningCase_Resource_RelEN.IdCourseLearningCaseType = objRow[convCourseLearningCase_Resource_Rel.IdCourseLearningCaseType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTypeName = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningCase_Resource_RelEN.OwnerId = objRow[convCourseLearningCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvCourseLearningCase_Resource_RelEN.OwnerName = objRow[convCourseLearningCase_Resource_Rel.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.OwnerName].ToString().Trim(); //拥有者姓名
objvCourseLearningCase_Resource_RelEN.OwnerNameWithId = objRow[convCourseLearningCase_Resource_Rel.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCourseLearningCase_Resource_RelEN.IdXzMajor = objRow[convCourseLearningCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningCase_Resource_RelEN.MajorID = objRow[convCourseLearningCase_Resource_Rel.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCase_Resource_RelEN.MajorName = objRow[convCourseLearningCase_Resource_Rel.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCase_Resource_RelEN.IdXzCollege = objRow[convCourseLearningCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCase_Resource_RelEN.CollegeID = objRow[convCourseLearningCase_Resource_Rel.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CollegeID].ToString().Trim(); //学院ID
objvCourseLearningCase_Resource_RelEN.CollegeName = objRow[convCourseLearningCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCase_Resource_RelEN.IdTeachSkill = objRow[convCourseLearningCase_Resource_Rel.IdTeachSkill] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCourseLearningCase_Resource_RelEN.TeachSkillID = objRow[convCourseLearningCase_Resource_Rel.TeachSkillID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID
objvCourseLearningCase_Resource_RelEN.TeachSkillName = objRow[convCourseLearningCase_Resource_Rel.TeachSkillName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称
objvCourseLearningCase_Resource_RelEN.TeachSkillTheory = objRow[convCourseLearningCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCourseLearningCase_Resource_RelEN.TeachSkillOperMethod = objRow[convCourseLearningCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCourseLearningCase_Resource_RelEN.SkillTypeID = objRow[convCourseLearningCase_Resource_Rel.SkillTypeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID
objvCourseLearningCase_Resource_RelEN.SkillTypeName = objRow[convCourseLearningCase_Resource_Rel.SkillTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称
objvCourseLearningCase_Resource_RelEN.IdDiscipline = objRow[convCourseLearningCase_Resource_Rel.IdDiscipline] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvCourseLearningCase_Resource_RelEN.DisciplineID = objRow[convCourseLearningCase_Resource_Rel.DisciplineID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID
objvCourseLearningCase_Resource_RelEN.DisciplineName = objRow[convCourseLearningCase_Resource_Rel.DisciplineName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvCourseLearningCase_Resource_RelEN.IdStudyLevel = objRow[convCourseLearningCase_Resource_Rel.IdStudyLevel] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCourseLearningCase_Resource_RelEN.StudyLevelName = objRow[convCourseLearningCase_Resource_Rel.StudyLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvCourseLearningCase_Resource_RelEN.IdFile = objRow[convCourseLearningCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvCourseLearningCase_Resource_RelEN.FileName = objRow[convCourseLearningCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvCourseLearningCase_Resource_RelEN.FileType = objRow[convCourseLearningCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvCourseLearningCase_Resource_RelEN.SaveDate = objRow[convCourseLearningCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvCourseLearningCase_Resource_RelEN.FileSize = objRow[convCourseLearningCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvCourseLearningCase_Resource_RelEN.SaveTime = objRow[convCourseLearningCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvCourseLearningCase_Resource_RelEN.IdSkillType = objRow[convCourseLearningCase_Resource_Rel.IdSkillType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号
objvCourseLearningCase_Resource_RelEN.IdTeachingPlan = objRow[convCourseLearningCase_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCourseLearningCase_Resource_RelEN.IdFtpResource = objRow[convCourseLearningCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvCourseLearningCase_Resource_RelEN.FtpResourceID = objRow[convCourseLearningCase_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvCourseLearningCase_Resource_RelEN.FileOriginalName = objRow[convCourseLearningCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvCourseLearningCase_Resource_RelEN.FileDirName = objRow[convCourseLearningCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvCourseLearningCase_Resource_RelEN.FileRename = objRow[convCourseLearningCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvCourseLearningCase_Resource_RelEN.FileUpDate = objRow[convCourseLearningCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvCourseLearningCase_Resource_RelEN.FileUpTime = objRow[convCourseLearningCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvCourseLearningCase_Resource_RelEN.IdResource = objRow[convCourseLearningCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvCourseLearningCase_Resource_RelEN.ResourceID = objRow[convCourseLearningCase_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvCourseLearningCase_Resource_RelEN.SaveMode = TransNullToBool(objRow[convCourseLearningCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvCourseLearningCase_Resource_RelEN.IsMain = TransNullToBool(objRow[convCourseLearningCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvCourseLearningCase_Resource_RelEN.IdResourceType = objRow[convCourseLearningCase_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvCourseLearningCase_Resource_RelEN.ResourceTypeID = objRow[convCourseLearningCase_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvCourseLearningCase_Resource_RelEN.ResourceTypeName = objRow[convCourseLearningCase_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvCourseLearningCase_Resource_RelEN.IdUsingMode = objRow[convCourseLearningCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvCourseLearningCase_Resource_RelEN.IndexNO = objRow[convCourseLearningCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvCourseLearningCase_Resource_RelEN.CourseId = objRow[convCourseLearningCase_Resource_Rel.CourseId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCase_Resource_RelEN.CourseCode = objRow[convCourseLearningCase_Resource_Rel.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCase_Resource_RelEN.CourseName = objRow[convCourseLearningCase_Resource_Rel.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCase_Resource_RelEN.BrowseCount = objRow[convCourseLearningCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvCourseLearningCase_Resource_RelEN.ResourceName = objRow[convCourseLearningCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvCourseLearningCase_Resource_RelEN.ResourceOwner = objRow[convCourseLearningCase_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvCourseLearningCase_Resource_RelEN.ftpFileType = objRow[convCourseLearningCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvCourseLearningCase_Resource_RelEN.ftpFileSize = objRow[convCourseLearningCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvCourseLearningCase_Resource_RelEN.ftpResourceOwner = objRow[convCourseLearningCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvCourseLearningCase_Resource_RelEN.VersionNo = objRow[convCourseLearningCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvCourseLearningCase_Resource_RelEN.FileOriginName = objRow[convCourseLearningCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvCourseLearningCase_Resource_RelEN.senateGaugeVersionID = objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCourseLearningCase_Resource_RelEN.senateGaugeVersionName = objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCourseLearningCase_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCourseLearningCase_Resource_RelEN.CaseLevelId = objRow[convCourseLearningCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvCourseLearningCase_Resource_RelEN.IsExistFile = TransNullToBool(objRow[convCourseLearningCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvCourseLearningCase_Resource_RelEN.BrowseCount4Case = objRow[convCourseLearningCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningCase_Resource_RelEN.FileNewName = objRow[convCourseLearningCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvCourseLearningCase_Resource_RelEN.FileOldName = objRow[convCourseLearningCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvCourseLearningCase_Resource_RelEN.IsDualVideo = TransNullToBool(objRow[convCourseLearningCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCase_Resource_RelEN.ViewCount = objRow[convCourseLearningCase_Resource_Rel.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase_Resource_Rel.ViewCount].ToString().Trim()); //浏览量
objvCourseLearningCase_Resource_RelEN.IsShow = TransNullToBool(objRow[convCourseLearningCase_Resource_Rel.IsShow].ToString().Trim()); //是否启用
objvCourseLearningCase_Resource_RelEN.DownloadNumber = objRow[convCourseLearningCase_Resource_Rel.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase_Resource_Rel.DownloadNumber].ToString().Trim()); //下载数目
objvCourseLearningCase_Resource_RelEN.FileIntegration = objRow[convCourseLearningCase_Resource_Rel.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase_Resource_Rel.FileIntegration].ToString().Trim()); //文件积分
objvCourseLearningCase_Resource_RelEN.LikeCount = objRow[convCourseLearningCase_Resource_Rel.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCourseLearningCase_Resource_Rel.LikeCount].ToString().Trim()); //资源喜欢数量
objvCourseLearningCase_Resource_RelEN.CollectionCount = objRow[convCourseLearningCase_Resource_Rel.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCourseLearningCase_Resource_Rel.CollectionCount].ToString().Trim()); //收藏数量
objvCourseLearningCase_Resource_RelEN.IsVisible = TransNullToBool(objRow[convCourseLearningCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvCourseLearningCase_Resource_RelEN.UpdDate = objRow[convCourseLearningCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvCourseLearningCase_Resource_RelEN.UpdUser = objRow[convCourseLearningCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvCourseLearningCase_Resource_RelEN.Memo = objRow[convCourseLearningCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.Memo].ToString().Trim(); //备注
objvCourseLearningCase_Resource_RelEN.RecommendedDegreeId = objRow[convCourseLearningCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCourseLearningCase_Resource_RelEN.RecommendedDegreeName = objRow[convCourseLearningCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCourseLearningCase_Resource_RelEN.CollegeNameA = objRow[convCourseLearningCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningCase_Resource_RelEN.CourseChapterId = objRow[convCourseLearningCase_Resource_Rel.CourseChapterId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCase_Resource_RelEN.CourseChapterName = objRow[convCourseLearningCase_Resource_Rel.CourseChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseChapterName].ToString().Trim(); //课程章节名称
objvCourseLearningCase_Resource_RelEN.CourseChapterReferred = objRow[convCourseLearningCase_Resource_Rel.CourseChapterReferred] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseChapterReferred].ToString().Trim(); //节简称
objvCourseLearningCase_Resource_RelEN.ParentNodeReferred = objRow[convCourseLearningCase_Resource_Rel.ParentNodeReferred] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ParentNodeReferred].ToString().Trim(); //章简称
objvCourseLearningCase_Resource_RelEN.ParentNodeID = objRow[convCourseLearningCase_Resource_Rel.ParentNodeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ParentNodeID].ToString().Trim(); //父节点编号
objvCourseLearningCase_Resource_RelEN.ParentNodeName = objRow[convCourseLearningCase_Resource_Rel.ParentNodeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ParentNodeName].ToString().Trim(); //父节点名称
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCourseLearningCase_Resource_RelDA: GetObjLst)", objException.Message));
}
objvCourseLearningCase_Resource_RelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCourseLearningCase_Resource_RelEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvCourseLearningCase_Resource_Rel(ref clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vCourseLearningCase_Resource_Rel where IdMicroteachCaseResourceRel = " + ""+ objvCourseLearningCase_Resource_RelEN.IdMicroteachCaseResourceRel+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvCourseLearningCase_Resource_RelEN.IdMicroteachCaseResourceRel = TransNullToInt(objDT.Rows[0][convCourseLearningCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.FuncModuleId = objDT.Rows[0][convCourseLearningCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.FuncModuleName = objDT.Rows[0][convCourseLearningCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.IdMicroteachCase = objDT.Rows[0][convCourseLearningCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.CourseLearningCaseID = objDT.Rows[0][convCourseLearningCase_Resource_Rel.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.CourseLearningCaseName = objDT.Rows[0][convCourseLearningCase_Resource_Rel.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.CourseLearningCaseText = objDT.Rows[0][convCourseLearningCase_Resource_Rel.CourseLearningCaseText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTheme = objDT.Rows[0][convCourseLearningCase_Resource_Rel.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.CourseLearningCaseDate = objDT.Rows[0][convCourseLearningCase_Resource_Rel.CourseLearningCaseDate].ToString().Trim(); //课程学习日期(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTime = objDT.Rows[0][convCourseLearningCase_Resource_Rel.CourseLearningCaseTime].ToString().Trim(); //课程学习时间(字段类型:char,字段长度:6,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.CourseLearningCaseDateIn = objDT.Rows[0][convCourseLearningCase_Resource_Rel.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTimeIn = objDT.Rows[0][convCourseLearningCase_Resource_Rel.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.IdCourseLearningCaseType = objDT.Rows[0][convCourseLearningCase_Resource_Rel.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTypeName = objDT.Rows[0][convCourseLearningCase_Resource_Rel.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.OwnerId = objDT.Rows[0][convCourseLearningCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.OwnerName = objDT.Rows[0][convCourseLearningCase_Resource_Rel.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.OwnerNameWithId = objDT.Rows[0][convCourseLearningCase_Resource_Rel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.IdXzMajor = objDT.Rows[0][convCourseLearningCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.MajorID = objDT.Rows[0][convCourseLearningCase_Resource_Rel.MajorID].ToString().Trim(); //专业ID(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.MajorName = objDT.Rows[0][convCourseLearningCase_Resource_Rel.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.IdXzCollege = objDT.Rows[0][convCourseLearningCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.CollegeID = objDT.Rows[0][convCourseLearningCase_Resource_Rel.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.CollegeName = objDT.Rows[0][convCourseLearningCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.IdTeachSkill = objDT.Rows[0][convCourseLearningCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.TeachSkillID = objDT.Rows[0][convCourseLearningCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.TeachSkillName = objDT.Rows[0][convCourseLearningCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.TeachSkillTheory = objDT.Rows[0][convCourseLearningCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.TeachSkillOperMethod = objDT.Rows[0][convCourseLearningCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法(字段类型:varchar,字段长度:2000,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.SkillTypeID = objDT.Rows[0][convCourseLearningCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.SkillTypeName = objDT.Rows[0][convCourseLearningCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.IdDiscipline = objDT.Rows[0][convCourseLearningCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.DisciplineID = objDT.Rows[0][convCourseLearningCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.DisciplineName = objDT.Rows[0][convCourseLearningCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.IdStudyLevel = objDT.Rows[0][convCourseLearningCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.StudyLevelName = objDT.Rows[0][convCourseLearningCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.IdFile = objDT.Rows[0][convCourseLearningCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.FileName = objDT.Rows[0][convCourseLearningCase_Resource_Rel.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.FileType = objDT.Rows[0][convCourseLearningCase_Resource_Rel.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.SaveDate = objDT.Rows[0][convCourseLearningCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.FileSize = objDT.Rows[0][convCourseLearningCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.SaveTime = objDT.Rows[0][convCourseLearningCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.IdSkillType = objDT.Rows[0][convCourseLearningCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.IdTeachingPlan = objDT.Rows[0][convCourseLearningCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.IdFtpResource = objDT.Rows[0][convCourseLearningCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.FtpResourceID = objDT.Rows[0][convCourseLearningCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.FileOriginalName = objDT.Rows[0][convCourseLearningCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名(字段类型:varchar,字段长度:200,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.FileDirName = objDT.Rows[0][convCourseLearningCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.FileRename = objDT.Rows[0][convCourseLearningCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名(字段类型:varchar,字段长度:200,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.FileUpDate = objDT.Rows[0][convCourseLearningCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.FileUpTime = objDT.Rows[0][convCourseLearningCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.IdResource = objDT.Rows[0][convCourseLearningCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.ResourceID = objDT.Rows[0][convCourseLearningCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.SaveMode = TransNullToBool(objDT.Rows[0][convCourseLearningCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式(字段类型:bit,字段长度:1,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.IsMain = TransNullToBool(objDT.Rows[0][convCourseLearningCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源(字段类型:bit,字段长度:1,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.IdResourceType = objDT.Rows[0][convCourseLearningCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.ResourceTypeID = objDT.Rows[0][convCourseLearningCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.ResourceTypeName = objDT.Rows[0][convCourseLearningCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.IdUsingMode = objDT.Rows[0][convCourseLearningCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.IndexNO = TransNullToInt(objDT.Rows[0][convCourseLearningCase_Resource_Rel.IndexNO].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.CourseId = objDT.Rows[0][convCourseLearningCase_Resource_Rel.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.CourseCode = objDT.Rows[0][convCourseLearningCase_Resource_Rel.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.CourseName = objDT.Rows[0][convCourseLearningCase_Resource_Rel.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.BrowseCount = TransNullToInt(objDT.Rows[0][convCourseLearningCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.ResourceName = objDT.Rows[0][convCourseLearningCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.ResourceOwner = objDT.Rows[0][convCourseLearningCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者(字段类型:varchar,字段长度:50,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.ftpFileType = objDT.Rows[0][convCourseLearningCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.ftpFileSize = objDT.Rows[0][convCourseLearningCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.ftpResourceOwner = objDT.Rows[0][convCourseLearningCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者(字段类型:varchar,字段长度:50,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.VersionNo = TransNullToInt(objDT.Rows[0][convCourseLearningCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.FileOriginName = objDT.Rows[0][convCourseLearningCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名(字段类型:varchar,字段长度:500,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.senateGaugeVersionID = objDT.Rows[0][convCourseLearningCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.senateGaugeVersionName = objDT.Rows[0][convCourseLearningCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.senateGaugeVersionTtlScore = TransNullToFloat(objDT.Rows[0][convCourseLearningCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.CaseLevelId = objDT.Rows[0][convCourseLearningCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.IsExistFile = TransNullToBool(objDT.Rows[0][convCourseLearningCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.BrowseCount4Case = TransNullToInt(objDT.Rows[0][convCourseLearningCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.FileNewName = objDT.Rows[0][convCourseLearningCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.FileOldName = objDT.Rows[0][convCourseLearningCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.IsDualVideo = TransNullToBool(objDT.Rows[0][convCourseLearningCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.ViewCount = TransNullToInt(objDT.Rows[0][convCourseLearningCase_Resource_Rel.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.IsShow = TransNullToBool(objDT.Rows[0][convCourseLearningCase_Resource_Rel.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.DownloadNumber = TransNullToInt(objDT.Rows[0][convCourseLearningCase_Resource_Rel.DownloadNumber].ToString().Trim()); //下载数目(字段类型:int,字段长度:4,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.FileIntegration = TransNullToInt(objDT.Rows[0][convCourseLearningCase_Resource_Rel.FileIntegration].ToString().Trim()); //文件积分(字段类型:int,字段长度:4,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.LikeCount = TransNullToInt(objDT.Rows[0][convCourseLearningCase_Resource_Rel.LikeCount].ToString().Trim()); //资源喜欢数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.CollectionCount = TransNullToInt(objDT.Rows[0][convCourseLearningCase_Resource_Rel.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.IsVisible = TransNullToBool(objDT.Rows[0][convCourseLearningCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.UpdDate = objDT.Rows[0][convCourseLearningCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.UpdUser = objDT.Rows[0][convCourseLearningCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.Memo = objDT.Rows[0][convCourseLearningCase_Resource_Rel.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.RecommendedDegreeId = objDT.Rows[0][convCourseLearningCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.RecommendedDegreeName = objDT.Rows[0][convCourseLearningCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.CollegeNameA = objDT.Rows[0][convCourseLearningCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.CourseChapterId = objDT.Rows[0][convCourseLearningCase_Resource_Rel.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.CourseChapterName = objDT.Rows[0][convCourseLearningCase_Resource_Rel.CourseChapterName].ToString().Trim(); //课程章节名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.CourseChapterReferred = objDT.Rows[0][convCourseLearningCase_Resource_Rel.CourseChapterReferred].ToString().Trim(); //节简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.ParentNodeReferred = objDT.Rows[0][convCourseLearningCase_Resource_Rel.ParentNodeReferred].ToString().Trim(); //章简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.ParentNodeID = objDT.Rows[0][convCourseLearningCase_Resource_Rel.ParentNodeID].ToString().Trim(); //父节点编号(字段类型:varchar,字段长度:8,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.ParentNodeName = objDT.Rows[0][convCourseLearningCase_Resource_Rel.ParentNodeName].ToString().Trim(); //父节点名称(字段类型:varchar,字段长度:50,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvCourseLearningCase_Resource_RelDA: GetvCourseLearningCase_Resource_Rel)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdMicroteachCaseResourceRel">表关键字</param>
 /// <returns>表对象</returns>
public clsvCourseLearningCase_Resource_RelEN GetObjByIdMicroteachCaseResourceRel(long lngIdMicroteachCaseResourceRel)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vCourseLearningCase_Resource_Rel where IdMicroteachCaseResourceRel = " + ""+ lngIdMicroteachCaseResourceRel+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN = new clsvCourseLearningCase_Resource_RelEN();
try
{
 objvCourseLearningCase_Resource_RelEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convCourseLearningCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.FuncModuleId = objRow[convCourseLearningCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.FuncModuleName = objRow[convCourseLearningCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.IdMicroteachCase = objRow[convCourseLearningCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.CourseLearningCaseID = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.CourseLearningCaseName = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.CourseLearningCaseText = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseText] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTheme = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.CourseLearningCaseDate = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseDate].ToString().Trim(); //课程学习日期(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTime = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTime].ToString().Trim(); //课程学习时间(字段类型:char,字段长度:6,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.CourseLearningCaseDateIn = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.IdCourseLearningCaseType = objRow[convCourseLearningCase_Resource_Rel.IdCourseLearningCaseType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTypeName = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.OwnerId = objRow[convCourseLearningCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.OwnerName = objRow[convCourseLearningCase_Resource_Rel.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.OwnerNameWithId = objRow[convCourseLearningCase_Resource_Rel.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.IdXzMajor = objRow[convCourseLearningCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.MajorID = objRow[convCourseLearningCase_Resource_Rel.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.MajorID].ToString().Trim(); //专业ID(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.MajorName = objRow[convCourseLearningCase_Resource_Rel.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.IdXzCollege = objRow[convCourseLearningCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.CollegeID = objRow[convCourseLearningCase_Resource_Rel.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.CollegeName = objRow[convCourseLearningCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.IdTeachSkill = objRow[convCourseLearningCase_Resource_Rel.IdTeachSkill] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.TeachSkillID = objRow[convCourseLearningCase_Resource_Rel.TeachSkillID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.TeachSkillName = objRow[convCourseLearningCase_Resource_Rel.TeachSkillName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.TeachSkillTheory = objRow[convCourseLearningCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.TeachSkillOperMethod = objRow[convCourseLearningCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法(字段类型:varchar,字段长度:2000,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.SkillTypeID = objRow[convCourseLearningCase_Resource_Rel.SkillTypeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.SkillTypeName = objRow[convCourseLearningCase_Resource_Rel.SkillTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.IdDiscipline = objRow[convCourseLearningCase_Resource_Rel.IdDiscipline] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.DisciplineID = objRow[convCourseLearningCase_Resource_Rel.DisciplineID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.DisciplineName = objRow[convCourseLearningCase_Resource_Rel.DisciplineName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.IdStudyLevel = objRow[convCourseLearningCase_Resource_Rel.IdStudyLevel] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.StudyLevelName = objRow[convCourseLearningCase_Resource_Rel.StudyLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.IdFile = objRow[convCourseLearningCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.FileName = objRow[convCourseLearningCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.FileType = objRow[convCourseLearningCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.SaveDate = objRow[convCourseLearningCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.FileSize = objRow[convCourseLearningCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.SaveTime = objRow[convCourseLearningCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.IdSkillType = objRow[convCourseLearningCase_Resource_Rel.IdSkillType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.IdTeachingPlan = objRow[convCourseLearningCase_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.IdFtpResource = objRow[convCourseLearningCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.FtpResourceID = objRow[convCourseLearningCase_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.FileOriginalName = objRow[convCourseLearningCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名(字段类型:varchar,字段长度:200,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.FileDirName = objRow[convCourseLearningCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.FileRename = objRow[convCourseLearningCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名(字段类型:varchar,字段长度:200,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.FileUpDate = objRow[convCourseLearningCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.FileUpTime = objRow[convCourseLearningCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.IdResource = objRow[convCourseLearningCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.ResourceID = objRow[convCourseLearningCase_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式(字段类型:bit,字段长度:1,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源(字段类型:bit,字段长度:1,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.IdResourceType = objRow[convCourseLearningCase_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.ResourceTypeID = objRow[convCourseLearningCase_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.ResourceTypeName = objRow[convCourseLearningCase_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.IdUsingMode = objRow[convCourseLearningCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.IndexNO = objRow[convCourseLearningCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.IndexNO].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.CourseId = objRow[convCourseLearningCase_Resource_Rel.CourseId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.CourseCode = objRow[convCourseLearningCase_Resource_Rel.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.CourseName = objRow[convCourseLearningCase_Resource_Rel.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.BrowseCount = objRow[convCourseLearningCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.ResourceName = objRow[convCourseLearningCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.ResourceOwner = objRow[convCourseLearningCase_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者(字段类型:varchar,字段长度:50,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.ftpFileType = objRow[convCourseLearningCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.ftpFileSize = objRow[convCourseLearningCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.ftpResourceOwner = objRow[convCourseLearningCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者(字段类型:varchar,字段长度:50,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.VersionNo = objRow[convCourseLearningCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.FileOriginName = objRow[convCourseLearningCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名(字段类型:varchar,字段长度:500,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.senateGaugeVersionID = objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.senateGaugeVersionName = objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.CaseLevelId = objRow[convCourseLearningCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.BrowseCount4Case = objRow[convCourseLearningCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.FileNewName = objRow[convCourseLearningCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.FileOldName = objRow[convCourseLearningCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.ViewCount = objRow[convCourseLearningCase_Resource_Rel.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Resource_Rel.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.DownloadNumber = objRow[convCourseLearningCase_Resource_Rel.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.DownloadNumber].ToString().Trim()); //下载数目(字段类型:int,字段长度:4,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.FileIntegration = objRow[convCourseLearningCase_Resource_Rel.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.FileIntegration].ToString().Trim()); //文件积分(字段类型:int,字段长度:4,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.LikeCount = objRow[convCourseLearningCase_Resource_Rel.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.LikeCount].ToString().Trim()); //资源喜欢数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.CollectionCount = objRow[convCourseLearningCase_Resource_Rel.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Resource_Rel.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.UpdDate = objRow[convCourseLearningCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.UpdUser = objRow[convCourseLearningCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.Memo = objRow[convCourseLearningCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.RecommendedDegreeId = objRow[convCourseLearningCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.RecommendedDegreeName = objRow[convCourseLearningCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.CollegeNameA = objRow[convCourseLearningCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.CourseChapterId = objRow[convCourseLearningCase_Resource_Rel.CourseChapterId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.CourseChapterName = objRow[convCourseLearningCase_Resource_Rel.CourseChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseChapterName].ToString().Trim(); //课程章节名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCourseLearningCase_Resource_RelEN.CourseChapterReferred = objRow[convCourseLearningCase_Resource_Rel.CourseChapterReferred] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseChapterReferred].ToString().Trim(); //节简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.ParentNodeReferred = objRow[convCourseLearningCase_Resource_Rel.ParentNodeReferred] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ParentNodeReferred].ToString().Trim(); //章简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.ParentNodeID = objRow[convCourseLearningCase_Resource_Rel.ParentNodeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ParentNodeID].ToString().Trim(); //父节点编号(字段类型:varchar,字段长度:8,是否可空:True)
 objvCourseLearningCase_Resource_RelEN.ParentNodeName = objRow[convCourseLearningCase_Resource_Rel.ParentNodeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ParentNodeName].ToString().Trim(); //父节点名称(字段类型:varchar,字段长度:50,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvCourseLearningCase_Resource_RelDA: GetObjByIdMicroteachCaseResourceRel)", objException.Message));
}
return objvCourseLearningCase_Resource_RelEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvCourseLearningCase_Resource_RelEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvCourseLearningCase_Resource_RelDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vCourseLearningCase_Resource_Rel where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN = new clsvCourseLearningCase_Resource_RelEN()
{
IdMicroteachCaseResourceRel = TransNullToInt(objRow[convCourseLearningCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()), //微格案例资源关系流水号
FuncModuleId = objRow[convCourseLearningCase_Resource_Rel.FuncModuleId].ToString().Trim(), //功能模块Id
FuncModuleName = objRow[convCourseLearningCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FuncModuleName].ToString().Trim(), //功能模块名称
IdMicroteachCase = objRow[convCourseLearningCase_Resource_Rel.IdMicroteachCase].ToString().Trim(), //微格教学案例流水号
CourseLearningCaseID = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseID].ToString().Trim(), //课程学习案例ID
CourseLearningCaseName = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseName].ToString().Trim(), //课程学习案例名称
CourseLearningCaseText = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseText] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseText].ToString().Trim(), //案例文本内容
CourseLearningCaseTheme = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTheme].ToString().Trim(), //课程学习案例主题词
CourseLearningCaseDate = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseDate].ToString().Trim(), //课程学习日期
CourseLearningCaseTime = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTime].ToString().Trim(), //课程学习时间
CourseLearningCaseDateIn = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseDateIn].ToString().Trim(), //案例入库日期
CourseLearningCaseTimeIn = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTimeIn].ToString().Trim(), //案例入库时间
IdCourseLearningCaseType = objRow[convCourseLearningCase_Resource_Rel.IdCourseLearningCaseType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdCourseLearningCaseType].ToString().Trim(), //课程学习案例类型流水号
CourseLearningCaseTypeName = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTypeName].ToString().Trim(), //课程学习案例类型名称
OwnerId = objRow[convCourseLearningCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.OwnerId].ToString().Trim(), //拥有者Id
OwnerName = objRow[convCourseLearningCase_Resource_Rel.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.OwnerName].ToString().Trim(), //拥有者姓名
OwnerNameWithId = objRow[convCourseLearningCase_Resource_Rel.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.OwnerNameWithId].ToString().Trim(), //拥有者名称附Id
IdXzMajor = objRow[convCourseLearningCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdXzMajor].ToString().Trim(), //专业流水号
MajorID = objRow[convCourseLearningCase_Resource_Rel.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.MajorID].ToString().Trim(), //专业ID
MajorName = objRow[convCourseLearningCase_Resource_Rel.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.MajorName].ToString().Trim(), //专业名称
IdXzCollege = objRow[convCourseLearningCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdXzCollege].ToString().Trim(), //学院流水号
CollegeID = objRow[convCourseLearningCase_Resource_Rel.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CollegeID].ToString().Trim(), //学院ID
CollegeName = objRow[convCourseLearningCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CollegeName].ToString().Trim(), //学院名称
IdTeachSkill = objRow[convCourseLearningCase_Resource_Rel.IdTeachSkill] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdTeachSkill].ToString().Trim(), //教学技能流水号
TeachSkillID = objRow[convCourseLearningCase_Resource_Rel.TeachSkillID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.TeachSkillID].ToString().Trim(), //教学技能ID
TeachSkillName = objRow[convCourseLearningCase_Resource_Rel.TeachSkillName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.TeachSkillName].ToString().Trim(), //教学技能名称
TeachSkillTheory = objRow[convCourseLearningCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.TeachSkillTheory].ToString().Trim(), //教学技能理论阐述
TeachSkillOperMethod = objRow[convCourseLearningCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(), //教学技能实践操作方法
SkillTypeID = objRow[convCourseLearningCase_Resource_Rel.SkillTypeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.SkillTypeID].ToString().Trim(), //技能类型ID
SkillTypeName = objRow[convCourseLearningCase_Resource_Rel.SkillTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.SkillTypeName].ToString().Trim(), //技能类型名称
IdDiscipline = objRow[convCourseLearningCase_Resource_Rel.IdDiscipline] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdDiscipline].ToString().Trim(), //学科流水号
DisciplineID = objRow[convCourseLearningCase_Resource_Rel.DisciplineID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.DisciplineID].ToString().Trim(), //学科ID
DisciplineName = objRow[convCourseLearningCase_Resource_Rel.DisciplineName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.DisciplineName].ToString().Trim(), //学科名称
IdStudyLevel = objRow[convCourseLearningCase_Resource_Rel.IdStudyLevel] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdStudyLevel].ToString().Trim(), //id_StudyLevel
StudyLevelName = objRow[convCourseLearningCase_Resource_Rel.StudyLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.StudyLevelName].ToString().Trim(), //学段名称
IdFile = objRow[convCourseLearningCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdFile].ToString().Trim(), //文件流水号
FileName = objRow[convCourseLearningCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileName].ToString().Trim(), //文件名称
FileType = objRow[convCourseLearningCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileType].ToString().Trim(), //文件类型
SaveDate = objRow[convCourseLearningCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.SaveDate].ToString().Trim(), //创建日期
FileSize = objRow[convCourseLearningCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileSize].ToString().Trim(), //文件大小
SaveTime = objRow[convCourseLearningCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.SaveTime].ToString().Trim(), //创建时间
IdSkillType = objRow[convCourseLearningCase_Resource_Rel.IdSkillType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdSkillType].ToString().Trim(), //技能类型流水号
IdTeachingPlan = objRow[convCourseLearningCase_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdTeachingPlan].ToString().Trim(), //教案流水号
IdFtpResource = objRow[convCourseLearningCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdFtpResource].ToString().Trim(), //FTP资源流水号
FtpResourceID = objRow[convCourseLearningCase_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FtpResourceID].ToString().Trim(), //FTP资源ID
FileOriginalName = objRow[convCourseLearningCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileOriginalName].ToString().Trim(), //文件原名
FileDirName = objRow[convCourseLearningCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileDirName].ToString().Trim(), //文件目录名
FileRename = objRow[convCourseLearningCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileRename].ToString().Trim(), //文件新名
FileUpDate = objRow[convCourseLearningCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileUpDate].ToString().Trim(), //创建日期
FileUpTime = objRow[convCourseLearningCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileUpTime].ToString().Trim(), //创建时间
IdResource = objRow[convCourseLearningCase_Resource_Rel.IdResource].ToString().Trim(), //资源流水号
ResourceID = objRow[convCourseLearningCase_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceID].ToString().Trim(), //资源ID
SaveMode = TransNullToBool(objRow[convCourseLearningCase_Resource_Rel.SaveMode].ToString().Trim()), //文件存放方式
IsMain = TransNullToBool(objRow[convCourseLearningCase_Resource_Rel.IsMain].ToString().Trim()), //是否主资源
IdResourceType = objRow[convCourseLearningCase_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdResourceType].ToString().Trim(), //资源类型流水号
ResourceTypeID = objRow[convCourseLearningCase_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceTypeID].ToString().Trim(), //资源类型ID
ResourceTypeName = objRow[convCourseLearningCase_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceTypeName].ToString().Trim(), //资源类型名称
IdUsingMode = objRow[convCourseLearningCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdUsingMode].ToString().Trim(), //资源使用模式流水号
IndexNO = objRow[convCourseLearningCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase_Resource_Rel.IndexNO].ToString().Trim()), //序号
CourseId = objRow[convCourseLearningCase_Resource_Rel.CourseId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseId].ToString().Trim(), //课程Id
CourseCode = objRow[convCourseLearningCase_Resource_Rel.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseCode].ToString().Trim(), //课程代码
CourseName = objRow[convCourseLearningCase_Resource_Rel.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseName].ToString().Trim(), //课程名称
BrowseCount = objRow[convCourseLearningCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase_Resource_Rel.BrowseCount].ToString().Trim()), //浏览次数
ResourceName = objRow[convCourseLearningCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceName].ToString().Trim(), //资源名称
ResourceOwner = objRow[convCourseLearningCase_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceOwner].ToString().Trim(), //上传者
ftpFileType = objRow[convCourseLearningCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ftpFileType].ToString().Trim(), //ftp文件类型
ftpFileSize = objRow[convCourseLearningCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ftpFileSize].ToString().Trim(), //ftp文件大小
ftpResourceOwner = objRow[convCourseLearningCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ftpResourceOwner].ToString().Trim(), //Ftp资源拥有者
VersionNo = objRow[convCourseLearningCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase_Resource_Rel.VersionNo].ToString().Trim()), //版本号
FileOriginName = objRow[convCourseLearningCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileOriginName].ToString().Trim(), //原文件名
senateGaugeVersionID = objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(), //评价量表版本ID
senateGaugeVersionName = objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(), //评价量表版本名称
senateGaugeVersionTtlScore = objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()), //评价量表版本总分
CaseLevelId = objRow[convCourseLearningCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CaseLevelId].ToString().Trim(), //课例等级Id
IsExistFile = TransNullToBool(objRow[convCourseLearningCase_Resource_Rel.IsExistFile].ToString().Trim()), //是否存在文件
BrowseCount4Case = objRow[convCourseLearningCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase_Resource_Rel.BrowseCount4Case].ToString().Trim()), //课例浏览次数
FileNewName = objRow[convCourseLearningCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileNewName].ToString().Trim(), //新文件名
FileOldName = objRow[convCourseLearningCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileOldName].ToString().Trim(), //旧文件名
IsDualVideo = TransNullToBool(objRow[convCourseLearningCase_Resource_Rel.IsDualVideo].ToString().Trim()), //是否双视频
ViewCount = objRow[convCourseLearningCase_Resource_Rel.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase_Resource_Rel.ViewCount].ToString().Trim()), //浏览量
IsShow = TransNullToBool(objRow[convCourseLearningCase_Resource_Rel.IsShow].ToString().Trim()), //是否启用
DownloadNumber = objRow[convCourseLearningCase_Resource_Rel.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase_Resource_Rel.DownloadNumber].ToString().Trim()), //下载数目
FileIntegration = objRow[convCourseLearningCase_Resource_Rel.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase_Resource_Rel.FileIntegration].ToString().Trim()), //文件积分
LikeCount = objRow[convCourseLearningCase_Resource_Rel.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCourseLearningCase_Resource_Rel.LikeCount].ToString().Trim()), //资源喜欢数量
CollectionCount = objRow[convCourseLearningCase_Resource_Rel.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCourseLearningCase_Resource_Rel.CollectionCount].ToString().Trim()), //收藏数量
IsVisible = TransNullToBool(objRow[convCourseLearningCase_Resource_Rel.IsVisible].ToString().Trim()), //是否显示
UpdDate = objRow[convCourseLearningCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convCourseLearningCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convCourseLearningCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.Memo].ToString().Trim(), //备注
RecommendedDegreeId = objRow[convCourseLearningCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(), //推荐度Id
RecommendedDegreeName = objRow[convCourseLearningCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(), //推荐度名称
CollegeNameA = objRow[convCourseLearningCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CollegeNameA].ToString().Trim(), //学院名称简写
CourseChapterId = objRow[convCourseLearningCase_Resource_Rel.CourseChapterId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseChapterId].ToString().Trim(), //课程章节ID
CourseChapterName = objRow[convCourseLearningCase_Resource_Rel.CourseChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseChapterName].ToString().Trim(), //课程章节名称
CourseChapterReferred = objRow[convCourseLearningCase_Resource_Rel.CourseChapterReferred] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseChapterReferred].ToString().Trim(), //节简称
ParentNodeReferred = objRow[convCourseLearningCase_Resource_Rel.ParentNodeReferred] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ParentNodeReferred].ToString().Trim(), //章简称
ParentNodeID = objRow[convCourseLearningCase_Resource_Rel.ParentNodeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ParentNodeID].ToString().Trim(), //父节点编号
ParentNodeName = objRow[convCourseLearningCase_Resource_Rel.ParentNodeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ParentNodeName].ToString().Trim() //父节点名称
};
objvCourseLearningCase_Resource_RelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCourseLearningCase_Resource_RelEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvCourseLearningCase_Resource_RelDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvCourseLearningCase_Resource_RelEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN = new clsvCourseLearningCase_Resource_RelEN();
try
{
objvCourseLearningCase_Resource_RelEN.IdMicroteachCaseResourceRel = TransNullToInt(objRow[convCourseLearningCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvCourseLearningCase_Resource_RelEN.FuncModuleId = objRow[convCourseLearningCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningCase_Resource_RelEN.FuncModuleName = objRow[convCourseLearningCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningCase_Resource_RelEN.IdMicroteachCase = objRow[convCourseLearningCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseID = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseName = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseText = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseText] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseText].ToString().Trim(); //案例文本内容
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTheme = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseDate = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTime = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseDateIn = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningCase_Resource_RelEN.IdCourseLearningCaseType = objRow[convCourseLearningCase_Resource_Rel.IdCourseLearningCaseType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTypeName = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningCase_Resource_RelEN.OwnerId = objRow[convCourseLearningCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvCourseLearningCase_Resource_RelEN.OwnerName = objRow[convCourseLearningCase_Resource_Rel.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.OwnerName].ToString().Trim(); //拥有者姓名
objvCourseLearningCase_Resource_RelEN.OwnerNameWithId = objRow[convCourseLearningCase_Resource_Rel.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCourseLearningCase_Resource_RelEN.IdXzMajor = objRow[convCourseLearningCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningCase_Resource_RelEN.MajorID = objRow[convCourseLearningCase_Resource_Rel.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCase_Resource_RelEN.MajorName = objRow[convCourseLearningCase_Resource_Rel.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCase_Resource_RelEN.IdXzCollege = objRow[convCourseLearningCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCase_Resource_RelEN.CollegeID = objRow[convCourseLearningCase_Resource_Rel.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CollegeID].ToString().Trim(); //学院ID
objvCourseLearningCase_Resource_RelEN.CollegeName = objRow[convCourseLearningCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCase_Resource_RelEN.IdTeachSkill = objRow[convCourseLearningCase_Resource_Rel.IdTeachSkill] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCourseLearningCase_Resource_RelEN.TeachSkillID = objRow[convCourseLearningCase_Resource_Rel.TeachSkillID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID
objvCourseLearningCase_Resource_RelEN.TeachSkillName = objRow[convCourseLearningCase_Resource_Rel.TeachSkillName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称
objvCourseLearningCase_Resource_RelEN.TeachSkillTheory = objRow[convCourseLearningCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCourseLearningCase_Resource_RelEN.TeachSkillOperMethod = objRow[convCourseLearningCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCourseLearningCase_Resource_RelEN.SkillTypeID = objRow[convCourseLearningCase_Resource_Rel.SkillTypeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID
objvCourseLearningCase_Resource_RelEN.SkillTypeName = objRow[convCourseLearningCase_Resource_Rel.SkillTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称
objvCourseLearningCase_Resource_RelEN.IdDiscipline = objRow[convCourseLearningCase_Resource_Rel.IdDiscipline] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvCourseLearningCase_Resource_RelEN.DisciplineID = objRow[convCourseLearningCase_Resource_Rel.DisciplineID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID
objvCourseLearningCase_Resource_RelEN.DisciplineName = objRow[convCourseLearningCase_Resource_Rel.DisciplineName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvCourseLearningCase_Resource_RelEN.IdStudyLevel = objRow[convCourseLearningCase_Resource_Rel.IdStudyLevel] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCourseLearningCase_Resource_RelEN.StudyLevelName = objRow[convCourseLearningCase_Resource_Rel.StudyLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvCourseLearningCase_Resource_RelEN.IdFile = objRow[convCourseLearningCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvCourseLearningCase_Resource_RelEN.FileName = objRow[convCourseLearningCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvCourseLearningCase_Resource_RelEN.FileType = objRow[convCourseLearningCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvCourseLearningCase_Resource_RelEN.SaveDate = objRow[convCourseLearningCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvCourseLearningCase_Resource_RelEN.FileSize = objRow[convCourseLearningCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvCourseLearningCase_Resource_RelEN.SaveTime = objRow[convCourseLearningCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvCourseLearningCase_Resource_RelEN.IdSkillType = objRow[convCourseLearningCase_Resource_Rel.IdSkillType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号
objvCourseLearningCase_Resource_RelEN.IdTeachingPlan = objRow[convCourseLearningCase_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCourseLearningCase_Resource_RelEN.IdFtpResource = objRow[convCourseLearningCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvCourseLearningCase_Resource_RelEN.FtpResourceID = objRow[convCourseLearningCase_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvCourseLearningCase_Resource_RelEN.FileOriginalName = objRow[convCourseLearningCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvCourseLearningCase_Resource_RelEN.FileDirName = objRow[convCourseLearningCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvCourseLearningCase_Resource_RelEN.FileRename = objRow[convCourseLearningCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvCourseLearningCase_Resource_RelEN.FileUpDate = objRow[convCourseLearningCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvCourseLearningCase_Resource_RelEN.FileUpTime = objRow[convCourseLearningCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvCourseLearningCase_Resource_RelEN.IdResource = objRow[convCourseLearningCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvCourseLearningCase_Resource_RelEN.ResourceID = objRow[convCourseLearningCase_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvCourseLearningCase_Resource_RelEN.SaveMode = TransNullToBool(objRow[convCourseLearningCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvCourseLearningCase_Resource_RelEN.IsMain = TransNullToBool(objRow[convCourseLearningCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvCourseLearningCase_Resource_RelEN.IdResourceType = objRow[convCourseLearningCase_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvCourseLearningCase_Resource_RelEN.ResourceTypeID = objRow[convCourseLearningCase_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvCourseLearningCase_Resource_RelEN.ResourceTypeName = objRow[convCourseLearningCase_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvCourseLearningCase_Resource_RelEN.IdUsingMode = objRow[convCourseLearningCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvCourseLearningCase_Resource_RelEN.IndexNO = objRow[convCourseLearningCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvCourseLearningCase_Resource_RelEN.CourseId = objRow[convCourseLearningCase_Resource_Rel.CourseId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCase_Resource_RelEN.CourseCode = objRow[convCourseLearningCase_Resource_Rel.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCase_Resource_RelEN.CourseName = objRow[convCourseLearningCase_Resource_Rel.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCase_Resource_RelEN.BrowseCount = objRow[convCourseLearningCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvCourseLearningCase_Resource_RelEN.ResourceName = objRow[convCourseLearningCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvCourseLearningCase_Resource_RelEN.ResourceOwner = objRow[convCourseLearningCase_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvCourseLearningCase_Resource_RelEN.ftpFileType = objRow[convCourseLearningCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvCourseLearningCase_Resource_RelEN.ftpFileSize = objRow[convCourseLearningCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvCourseLearningCase_Resource_RelEN.ftpResourceOwner = objRow[convCourseLearningCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvCourseLearningCase_Resource_RelEN.VersionNo = objRow[convCourseLearningCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvCourseLearningCase_Resource_RelEN.FileOriginName = objRow[convCourseLearningCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvCourseLearningCase_Resource_RelEN.senateGaugeVersionID = objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCourseLearningCase_Resource_RelEN.senateGaugeVersionName = objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCourseLearningCase_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCourseLearningCase_Resource_RelEN.CaseLevelId = objRow[convCourseLearningCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvCourseLearningCase_Resource_RelEN.IsExistFile = TransNullToBool(objRow[convCourseLearningCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvCourseLearningCase_Resource_RelEN.BrowseCount4Case = objRow[convCourseLearningCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningCase_Resource_RelEN.FileNewName = objRow[convCourseLearningCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvCourseLearningCase_Resource_RelEN.FileOldName = objRow[convCourseLearningCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvCourseLearningCase_Resource_RelEN.IsDualVideo = TransNullToBool(objRow[convCourseLearningCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCase_Resource_RelEN.ViewCount = objRow[convCourseLearningCase_Resource_Rel.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase_Resource_Rel.ViewCount].ToString().Trim()); //浏览量
objvCourseLearningCase_Resource_RelEN.IsShow = TransNullToBool(objRow[convCourseLearningCase_Resource_Rel.IsShow].ToString().Trim()); //是否启用
objvCourseLearningCase_Resource_RelEN.DownloadNumber = objRow[convCourseLearningCase_Resource_Rel.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase_Resource_Rel.DownloadNumber].ToString().Trim()); //下载数目
objvCourseLearningCase_Resource_RelEN.FileIntegration = objRow[convCourseLearningCase_Resource_Rel.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase_Resource_Rel.FileIntegration].ToString().Trim()); //文件积分
objvCourseLearningCase_Resource_RelEN.LikeCount = objRow[convCourseLearningCase_Resource_Rel.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCourseLearningCase_Resource_Rel.LikeCount].ToString().Trim()); //资源喜欢数量
objvCourseLearningCase_Resource_RelEN.CollectionCount = objRow[convCourseLearningCase_Resource_Rel.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCourseLearningCase_Resource_Rel.CollectionCount].ToString().Trim()); //收藏数量
objvCourseLearningCase_Resource_RelEN.IsVisible = TransNullToBool(objRow[convCourseLearningCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvCourseLearningCase_Resource_RelEN.UpdDate = objRow[convCourseLearningCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvCourseLearningCase_Resource_RelEN.UpdUser = objRow[convCourseLearningCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvCourseLearningCase_Resource_RelEN.Memo = objRow[convCourseLearningCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.Memo].ToString().Trim(); //备注
objvCourseLearningCase_Resource_RelEN.RecommendedDegreeId = objRow[convCourseLearningCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCourseLearningCase_Resource_RelEN.RecommendedDegreeName = objRow[convCourseLearningCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCourseLearningCase_Resource_RelEN.CollegeNameA = objRow[convCourseLearningCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningCase_Resource_RelEN.CourseChapterId = objRow[convCourseLearningCase_Resource_Rel.CourseChapterId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCase_Resource_RelEN.CourseChapterName = objRow[convCourseLearningCase_Resource_Rel.CourseChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseChapterName].ToString().Trim(); //课程章节名称
objvCourseLearningCase_Resource_RelEN.CourseChapterReferred = objRow[convCourseLearningCase_Resource_Rel.CourseChapterReferred] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseChapterReferred].ToString().Trim(); //节简称
objvCourseLearningCase_Resource_RelEN.ParentNodeReferred = objRow[convCourseLearningCase_Resource_Rel.ParentNodeReferred] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ParentNodeReferred].ToString().Trim(); //章简称
objvCourseLearningCase_Resource_RelEN.ParentNodeID = objRow[convCourseLearningCase_Resource_Rel.ParentNodeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ParentNodeID].ToString().Trim(); //父节点编号
objvCourseLearningCase_Resource_RelEN.ParentNodeName = objRow[convCourseLearningCase_Resource_Rel.ParentNodeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ParentNodeName].ToString().Trim(); //父节点名称
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvCourseLearningCase_Resource_RelDA: GetObjByDataRowvCourseLearningCase_Resource_Rel)", objException.Message));
}
objvCourseLearningCase_Resource_RelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCourseLearningCase_Resource_RelEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvCourseLearningCase_Resource_RelEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN = new clsvCourseLearningCase_Resource_RelEN();
try
{
objvCourseLearningCase_Resource_RelEN.IdMicroteachCaseResourceRel = TransNullToInt(objRow[convCourseLearningCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvCourseLearningCase_Resource_RelEN.FuncModuleId = objRow[convCourseLearningCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningCase_Resource_RelEN.FuncModuleName = objRow[convCourseLearningCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningCase_Resource_RelEN.IdMicroteachCase = objRow[convCourseLearningCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseID = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseName = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseText = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseText] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseText].ToString().Trim(); //案例文本内容
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTheme = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseDate = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTime = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseDateIn = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningCase_Resource_RelEN.IdCourseLearningCaseType = objRow[convCourseLearningCase_Resource_Rel.IdCourseLearningCaseType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号
objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTypeName = objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningCase_Resource_RelEN.OwnerId = objRow[convCourseLearningCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvCourseLearningCase_Resource_RelEN.OwnerName = objRow[convCourseLearningCase_Resource_Rel.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.OwnerName].ToString().Trim(); //拥有者姓名
objvCourseLearningCase_Resource_RelEN.OwnerNameWithId = objRow[convCourseLearningCase_Resource_Rel.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCourseLearningCase_Resource_RelEN.IdXzMajor = objRow[convCourseLearningCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningCase_Resource_RelEN.MajorID = objRow[convCourseLearningCase_Resource_Rel.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCase_Resource_RelEN.MajorName = objRow[convCourseLearningCase_Resource_Rel.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCase_Resource_RelEN.IdXzCollege = objRow[convCourseLearningCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCase_Resource_RelEN.CollegeID = objRow[convCourseLearningCase_Resource_Rel.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CollegeID].ToString().Trim(); //学院ID
objvCourseLearningCase_Resource_RelEN.CollegeName = objRow[convCourseLearningCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCase_Resource_RelEN.IdTeachSkill = objRow[convCourseLearningCase_Resource_Rel.IdTeachSkill] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCourseLearningCase_Resource_RelEN.TeachSkillID = objRow[convCourseLearningCase_Resource_Rel.TeachSkillID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID
objvCourseLearningCase_Resource_RelEN.TeachSkillName = objRow[convCourseLearningCase_Resource_Rel.TeachSkillName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称
objvCourseLearningCase_Resource_RelEN.TeachSkillTheory = objRow[convCourseLearningCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCourseLearningCase_Resource_RelEN.TeachSkillOperMethod = objRow[convCourseLearningCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCourseLearningCase_Resource_RelEN.SkillTypeID = objRow[convCourseLearningCase_Resource_Rel.SkillTypeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID
objvCourseLearningCase_Resource_RelEN.SkillTypeName = objRow[convCourseLearningCase_Resource_Rel.SkillTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称
objvCourseLearningCase_Resource_RelEN.IdDiscipline = objRow[convCourseLearningCase_Resource_Rel.IdDiscipline] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvCourseLearningCase_Resource_RelEN.DisciplineID = objRow[convCourseLearningCase_Resource_Rel.DisciplineID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID
objvCourseLearningCase_Resource_RelEN.DisciplineName = objRow[convCourseLearningCase_Resource_Rel.DisciplineName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvCourseLearningCase_Resource_RelEN.IdStudyLevel = objRow[convCourseLearningCase_Resource_Rel.IdStudyLevel] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCourseLearningCase_Resource_RelEN.StudyLevelName = objRow[convCourseLearningCase_Resource_Rel.StudyLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvCourseLearningCase_Resource_RelEN.IdFile = objRow[convCourseLearningCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvCourseLearningCase_Resource_RelEN.FileName = objRow[convCourseLearningCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvCourseLearningCase_Resource_RelEN.FileType = objRow[convCourseLearningCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvCourseLearningCase_Resource_RelEN.SaveDate = objRow[convCourseLearningCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvCourseLearningCase_Resource_RelEN.FileSize = objRow[convCourseLearningCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvCourseLearningCase_Resource_RelEN.SaveTime = objRow[convCourseLearningCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvCourseLearningCase_Resource_RelEN.IdSkillType = objRow[convCourseLearningCase_Resource_Rel.IdSkillType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号
objvCourseLearningCase_Resource_RelEN.IdTeachingPlan = objRow[convCourseLearningCase_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCourseLearningCase_Resource_RelEN.IdFtpResource = objRow[convCourseLearningCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvCourseLearningCase_Resource_RelEN.FtpResourceID = objRow[convCourseLearningCase_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvCourseLearningCase_Resource_RelEN.FileOriginalName = objRow[convCourseLearningCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvCourseLearningCase_Resource_RelEN.FileDirName = objRow[convCourseLearningCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvCourseLearningCase_Resource_RelEN.FileRename = objRow[convCourseLearningCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvCourseLearningCase_Resource_RelEN.FileUpDate = objRow[convCourseLearningCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvCourseLearningCase_Resource_RelEN.FileUpTime = objRow[convCourseLearningCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvCourseLearningCase_Resource_RelEN.IdResource = objRow[convCourseLearningCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvCourseLearningCase_Resource_RelEN.ResourceID = objRow[convCourseLearningCase_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvCourseLearningCase_Resource_RelEN.SaveMode = TransNullToBool(objRow[convCourseLearningCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvCourseLearningCase_Resource_RelEN.IsMain = TransNullToBool(objRow[convCourseLearningCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvCourseLearningCase_Resource_RelEN.IdResourceType = objRow[convCourseLearningCase_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvCourseLearningCase_Resource_RelEN.ResourceTypeID = objRow[convCourseLearningCase_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvCourseLearningCase_Resource_RelEN.ResourceTypeName = objRow[convCourseLearningCase_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvCourseLearningCase_Resource_RelEN.IdUsingMode = objRow[convCourseLearningCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvCourseLearningCase_Resource_RelEN.IndexNO = objRow[convCourseLearningCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvCourseLearningCase_Resource_RelEN.CourseId = objRow[convCourseLearningCase_Resource_Rel.CourseId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCase_Resource_RelEN.CourseCode = objRow[convCourseLearningCase_Resource_Rel.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCase_Resource_RelEN.CourseName = objRow[convCourseLearningCase_Resource_Rel.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCase_Resource_RelEN.BrowseCount = objRow[convCourseLearningCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvCourseLearningCase_Resource_RelEN.ResourceName = objRow[convCourseLearningCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvCourseLearningCase_Resource_RelEN.ResourceOwner = objRow[convCourseLearningCase_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvCourseLearningCase_Resource_RelEN.ftpFileType = objRow[convCourseLearningCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvCourseLearningCase_Resource_RelEN.ftpFileSize = objRow[convCourseLearningCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvCourseLearningCase_Resource_RelEN.ftpResourceOwner = objRow[convCourseLearningCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvCourseLearningCase_Resource_RelEN.VersionNo = objRow[convCourseLearningCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvCourseLearningCase_Resource_RelEN.FileOriginName = objRow[convCourseLearningCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvCourseLearningCase_Resource_RelEN.senateGaugeVersionID = objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCourseLearningCase_Resource_RelEN.senateGaugeVersionName = objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCourseLearningCase_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convCourseLearningCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCourseLearningCase_Resource_RelEN.CaseLevelId = objRow[convCourseLearningCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvCourseLearningCase_Resource_RelEN.IsExistFile = TransNullToBool(objRow[convCourseLearningCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvCourseLearningCase_Resource_RelEN.BrowseCount4Case = objRow[convCourseLearningCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningCase_Resource_RelEN.FileNewName = objRow[convCourseLearningCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvCourseLearningCase_Resource_RelEN.FileOldName = objRow[convCourseLearningCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvCourseLearningCase_Resource_RelEN.IsDualVideo = TransNullToBool(objRow[convCourseLearningCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCase_Resource_RelEN.ViewCount = objRow[convCourseLearningCase_Resource_Rel.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase_Resource_Rel.ViewCount].ToString().Trim()); //浏览量
objvCourseLearningCase_Resource_RelEN.IsShow = TransNullToBool(objRow[convCourseLearningCase_Resource_Rel.IsShow].ToString().Trim()); //是否启用
objvCourseLearningCase_Resource_RelEN.DownloadNumber = objRow[convCourseLearningCase_Resource_Rel.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase_Resource_Rel.DownloadNumber].ToString().Trim()); //下载数目
objvCourseLearningCase_Resource_RelEN.FileIntegration = objRow[convCourseLearningCase_Resource_Rel.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase_Resource_Rel.FileIntegration].ToString().Trim()); //文件积分
objvCourseLearningCase_Resource_RelEN.LikeCount = objRow[convCourseLearningCase_Resource_Rel.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCourseLearningCase_Resource_Rel.LikeCount].ToString().Trim()); //资源喜欢数量
objvCourseLearningCase_Resource_RelEN.CollectionCount = objRow[convCourseLearningCase_Resource_Rel.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCourseLearningCase_Resource_Rel.CollectionCount].ToString().Trim()); //收藏数量
objvCourseLearningCase_Resource_RelEN.IsVisible = TransNullToBool(objRow[convCourseLearningCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvCourseLearningCase_Resource_RelEN.UpdDate = objRow[convCourseLearningCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvCourseLearningCase_Resource_RelEN.UpdUser = objRow[convCourseLearningCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvCourseLearningCase_Resource_RelEN.Memo = objRow[convCourseLearningCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.Memo].ToString().Trim(); //备注
objvCourseLearningCase_Resource_RelEN.RecommendedDegreeId = objRow[convCourseLearningCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCourseLearningCase_Resource_RelEN.RecommendedDegreeName = objRow[convCourseLearningCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCourseLearningCase_Resource_RelEN.CollegeNameA = objRow[convCourseLearningCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningCase_Resource_RelEN.CourseChapterId = objRow[convCourseLearningCase_Resource_Rel.CourseChapterId] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCase_Resource_RelEN.CourseChapterName = objRow[convCourseLearningCase_Resource_Rel.CourseChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseChapterName].ToString().Trim(); //课程章节名称
objvCourseLearningCase_Resource_RelEN.CourseChapterReferred = objRow[convCourseLearningCase_Resource_Rel.CourseChapterReferred] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.CourseChapterReferred].ToString().Trim(); //节简称
objvCourseLearningCase_Resource_RelEN.ParentNodeReferred = objRow[convCourseLearningCase_Resource_Rel.ParentNodeReferred] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ParentNodeReferred].ToString().Trim(); //章简称
objvCourseLearningCase_Resource_RelEN.ParentNodeID = objRow[convCourseLearningCase_Resource_Rel.ParentNodeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ParentNodeID].ToString().Trim(); //父节点编号
objvCourseLearningCase_Resource_RelEN.ParentNodeName = objRow[convCourseLearningCase_Resource_Rel.ParentNodeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Resource_Rel.ParentNodeName].ToString().Trim(); //父节点名称
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvCourseLearningCase_Resource_RelDA: GetObjByDataRow)", objException.Message));
}
objvCourseLearningCase_Resource_RelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCourseLearningCase_Resource_RelEN;
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
objSQL = clsvCourseLearningCase_Resource_RelDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCourseLearningCase_Resource_RelEN._CurrTabName, convCourseLearningCase_Resource_Rel.IdMicroteachCaseResourceRel, 8, "");
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
objSQL = clsvCourseLearningCase_Resource_RelDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCourseLearningCase_Resource_RelEN._CurrTabName, convCourseLearningCase_Resource_Rel.IdMicroteachCaseResourceRel, 8, strPrefix);
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
 objSQL = clsvCourseLearningCase_Resource_RelDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdMicroteachCaseResourceRel from vCourseLearningCase_Resource_Rel where " + strCondition;
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
 objSQL = clsvCourseLearningCase_Resource_RelDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdMicroteachCaseResourceRel from vCourseLearningCase_Resource_Rel where " + strCondition;
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
 /// <param name = "lngIdMicroteachCaseResourceRel">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngIdMicroteachCaseResourceRel)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCase_Resource_RelDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCourseLearningCase_Resource_Rel", "IdMicroteachCaseResourceRel = " + ""+ lngIdMicroteachCaseResourceRel+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvCourseLearningCase_Resource_RelDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCase_Resource_RelDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCourseLearningCase_Resource_Rel", strCondition))
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
objSQL = clsvCourseLearningCase_Resource_RelDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vCourseLearningCase_Resource_Rel");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvCourseLearningCase_Resource_RelENS">源对象</param>
 /// <param name = "objvCourseLearningCase_Resource_RelENT">目标对象</param>
public void CopyTo(clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelENS, clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelENT)
{
objvCourseLearningCase_Resource_RelENT.IdMicroteachCaseResourceRel = objvCourseLearningCase_Resource_RelENS.IdMicroteachCaseResourceRel; //微格案例资源关系流水号
objvCourseLearningCase_Resource_RelENT.FuncModuleId = objvCourseLearningCase_Resource_RelENS.FuncModuleId; //功能模块Id
objvCourseLearningCase_Resource_RelENT.FuncModuleName = objvCourseLearningCase_Resource_RelENS.FuncModuleName; //功能模块名称
objvCourseLearningCase_Resource_RelENT.IdMicroteachCase = objvCourseLearningCase_Resource_RelENS.IdMicroteachCase; //微格教学案例流水号
objvCourseLearningCase_Resource_RelENT.CourseLearningCaseID = objvCourseLearningCase_Resource_RelENS.CourseLearningCaseID; //课程学习案例ID
objvCourseLearningCase_Resource_RelENT.CourseLearningCaseName = objvCourseLearningCase_Resource_RelENS.CourseLearningCaseName; //课程学习案例名称
objvCourseLearningCase_Resource_RelENT.CourseLearningCaseText = objvCourseLearningCase_Resource_RelENS.CourseLearningCaseText; //案例文本内容
objvCourseLearningCase_Resource_RelENT.CourseLearningCaseTheme = objvCourseLearningCase_Resource_RelENS.CourseLearningCaseTheme; //课程学习案例主题词
objvCourseLearningCase_Resource_RelENT.CourseLearningCaseDate = objvCourseLearningCase_Resource_RelENS.CourseLearningCaseDate; //课程学习日期
objvCourseLearningCase_Resource_RelENT.CourseLearningCaseTime = objvCourseLearningCase_Resource_RelENS.CourseLearningCaseTime; //课程学习时间
objvCourseLearningCase_Resource_RelENT.CourseLearningCaseDateIn = objvCourseLearningCase_Resource_RelENS.CourseLearningCaseDateIn; //案例入库日期
objvCourseLearningCase_Resource_RelENT.CourseLearningCaseTimeIn = objvCourseLearningCase_Resource_RelENS.CourseLearningCaseTimeIn; //案例入库时间
objvCourseLearningCase_Resource_RelENT.IdCourseLearningCaseType = objvCourseLearningCase_Resource_RelENS.IdCourseLearningCaseType; //课程学习案例类型流水号
objvCourseLearningCase_Resource_RelENT.CourseLearningCaseTypeName = objvCourseLearningCase_Resource_RelENS.CourseLearningCaseTypeName; //课程学习案例类型名称
objvCourseLearningCase_Resource_RelENT.OwnerId = objvCourseLearningCase_Resource_RelENS.OwnerId; //拥有者Id
objvCourseLearningCase_Resource_RelENT.OwnerName = objvCourseLearningCase_Resource_RelENS.OwnerName; //拥有者姓名
objvCourseLearningCase_Resource_RelENT.OwnerNameWithId = objvCourseLearningCase_Resource_RelENS.OwnerNameWithId; //拥有者名称附Id
objvCourseLearningCase_Resource_RelENT.IdXzMajor = objvCourseLearningCase_Resource_RelENS.IdXzMajor; //专业流水号
objvCourseLearningCase_Resource_RelENT.MajorID = objvCourseLearningCase_Resource_RelENS.MajorID; //专业ID
objvCourseLearningCase_Resource_RelENT.MajorName = objvCourseLearningCase_Resource_RelENS.MajorName; //专业名称
objvCourseLearningCase_Resource_RelENT.IdXzCollege = objvCourseLearningCase_Resource_RelENS.IdXzCollege; //学院流水号
objvCourseLearningCase_Resource_RelENT.CollegeID = objvCourseLearningCase_Resource_RelENS.CollegeID; //学院ID
objvCourseLearningCase_Resource_RelENT.CollegeName = objvCourseLearningCase_Resource_RelENS.CollegeName; //学院名称
objvCourseLearningCase_Resource_RelENT.IdTeachSkill = objvCourseLearningCase_Resource_RelENS.IdTeachSkill; //教学技能流水号
objvCourseLearningCase_Resource_RelENT.TeachSkillID = objvCourseLearningCase_Resource_RelENS.TeachSkillID; //教学技能ID
objvCourseLearningCase_Resource_RelENT.TeachSkillName = objvCourseLearningCase_Resource_RelENS.TeachSkillName; //教学技能名称
objvCourseLearningCase_Resource_RelENT.TeachSkillTheory = objvCourseLearningCase_Resource_RelENS.TeachSkillTheory; //教学技能理论阐述
objvCourseLearningCase_Resource_RelENT.TeachSkillOperMethod = objvCourseLearningCase_Resource_RelENS.TeachSkillOperMethod; //教学技能实践操作方法
objvCourseLearningCase_Resource_RelENT.SkillTypeID = objvCourseLearningCase_Resource_RelENS.SkillTypeID; //技能类型ID
objvCourseLearningCase_Resource_RelENT.SkillTypeName = objvCourseLearningCase_Resource_RelENS.SkillTypeName; //技能类型名称
objvCourseLearningCase_Resource_RelENT.IdDiscipline = objvCourseLearningCase_Resource_RelENS.IdDiscipline; //学科流水号
objvCourseLearningCase_Resource_RelENT.DisciplineID = objvCourseLearningCase_Resource_RelENS.DisciplineID; //学科ID
objvCourseLearningCase_Resource_RelENT.DisciplineName = objvCourseLearningCase_Resource_RelENS.DisciplineName; //学科名称
objvCourseLearningCase_Resource_RelENT.IdStudyLevel = objvCourseLearningCase_Resource_RelENS.IdStudyLevel; //id_StudyLevel
objvCourseLearningCase_Resource_RelENT.StudyLevelName = objvCourseLearningCase_Resource_RelENS.StudyLevelName; //学段名称
objvCourseLearningCase_Resource_RelENT.IdFile = objvCourseLearningCase_Resource_RelENS.IdFile; //文件流水号
objvCourseLearningCase_Resource_RelENT.FileName = objvCourseLearningCase_Resource_RelENS.FileName; //文件名称
objvCourseLearningCase_Resource_RelENT.FileType = objvCourseLearningCase_Resource_RelENS.FileType; //文件类型
objvCourseLearningCase_Resource_RelENT.SaveDate = objvCourseLearningCase_Resource_RelENS.SaveDate; //创建日期
objvCourseLearningCase_Resource_RelENT.FileSize = objvCourseLearningCase_Resource_RelENS.FileSize; //文件大小
objvCourseLearningCase_Resource_RelENT.SaveTime = objvCourseLearningCase_Resource_RelENS.SaveTime; //创建时间
objvCourseLearningCase_Resource_RelENT.IdSkillType = objvCourseLearningCase_Resource_RelENS.IdSkillType; //技能类型流水号
objvCourseLearningCase_Resource_RelENT.IdTeachingPlan = objvCourseLearningCase_Resource_RelENS.IdTeachingPlan; //教案流水号
objvCourseLearningCase_Resource_RelENT.IdFtpResource = objvCourseLearningCase_Resource_RelENS.IdFtpResource; //FTP资源流水号
objvCourseLearningCase_Resource_RelENT.FtpResourceID = objvCourseLearningCase_Resource_RelENS.FtpResourceID; //FTP资源ID
objvCourseLearningCase_Resource_RelENT.FileOriginalName = objvCourseLearningCase_Resource_RelENS.FileOriginalName; //文件原名
objvCourseLearningCase_Resource_RelENT.FileDirName = objvCourseLearningCase_Resource_RelENS.FileDirName; //文件目录名
objvCourseLearningCase_Resource_RelENT.FileRename = objvCourseLearningCase_Resource_RelENS.FileRename; //文件新名
objvCourseLearningCase_Resource_RelENT.FileUpDate = objvCourseLearningCase_Resource_RelENS.FileUpDate; //创建日期
objvCourseLearningCase_Resource_RelENT.FileUpTime = objvCourseLearningCase_Resource_RelENS.FileUpTime; //创建时间
objvCourseLearningCase_Resource_RelENT.IdResource = objvCourseLearningCase_Resource_RelENS.IdResource; //资源流水号
objvCourseLearningCase_Resource_RelENT.ResourceID = objvCourseLearningCase_Resource_RelENS.ResourceID; //资源ID
objvCourseLearningCase_Resource_RelENT.SaveMode = objvCourseLearningCase_Resource_RelENS.SaveMode; //文件存放方式
objvCourseLearningCase_Resource_RelENT.IsMain = objvCourseLearningCase_Resource_RelENS.IsMain; //是否主资源
objvCourseLearningCase_Resource_RelENT.IdResourceType = objvCourseLearningCase_Resource_RelENS.IdResourceType; //资源类型流水号
objvCourseLearningCase_Resource_RelENT.ResourceTypeID = objvCourseLearningCase_Resource_RelENS.ResourceTypeID; //资源类型ID
objvCourseLearningCase_Resource_RelENT.ResourceTypeName = objvCourseLearningCase_Resource_RelENS.ResourceTypeName; //资源类型名称
objvCourseLearningCase_Resource_RelENT.IdUsingMode = objvCourseLearningCase_Resource_RelENS.IdUsingMode; //资源使用模式流水号
objvCourseLearningCase_Resource_RelENT.IndexNO = objvCourseLearningCase_Resource_RelENS.IndexNO; //序号
objvCourseLearningCase_Resource_RelENT.CourseId = objvCourseLearningCase_Resource_RelENS.CourseId; //课程Id
objvCourseLearningCase_Resource_RelENT.CourseCode = objvCourseLearningCase_Resource_RelENS.CourseCode; //课程代码
objvCourseLearningCase_Resource_RelENT.CourseName = objvCourseLearningCase_Resource_RelENS.CourseName; //课程名称
objvCourseLearningCase_Resource_RelENT.BrowseCount = objvCourseLearningCase_Resource_RelENS.BrowseCount; //浏览次数
objvCourseLearningCase_Resource_RelENT.ResourceName = objvCourseLearningCase_Resource_RelENS.ResourceName; //资源名称
objvCourseLearningCase_Resource_RelENT.ResourceOwner = objvCourseLearningCase_Resource_RelENS.ResourceOwner; //上传者
objvCourseLearningCase_Resource_RelENT.ftpFileType = objvCourseLearningCase_Resource_RelENS.ftpFileType; //ftp文件类型
objvCourseLearningCase_Resource_RelENT.ftpFileSize = objvCourseLearningCase_Resource_RelENS.ftpFileSize; //ftp文件大小
objvCourseLearningCase_Resource_RelENT.ftpResourceOwner = objvCourseLearningCase_Resource_RelENS.ftpResourceOwner; //Ftp资源拥有者
objvCourseLearningCase_Resource_RelENT.VersionNo = objvCourseLearningCase_Resource_RelENS.VersionNo; //版本号
objvCourseLearningCase_Resource_RelENT.FileOriginName = objvCourseLearningCase_Resource_RelENS.FileOriginName; //原文件名
objvCourseLearningCase_Resource_RelENT.senateGaugeVersionID = objvCourseLearningCase_Resource_RelENS.senateGaugeVersionID; //评价量表版本ID
objvCourseLearningCase_Resource_RelENT.senateGaugeVersionName = objvCourseLearningCase_Resource_RelENS.senateGaugeVersionName; //评价量表版本名称
objvCourseLearningCase_Resource_RelENT.senateGaugeVersionTtlScore = objvCourseLearningCase_Resource_RelENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvCourseLearningCase_Resource_RelENT.CaseLevelId = objvCourseLearningCase_Resource_RelENS.CaseLevelId; //课例等级Id
objvCourseLearningCase_Resource_RelENT.IsExistFile = objvCourseLearningCase_Resource_RelENS.IsExistFile; //是否存在文件
objvCourseLearningCase_Resource_RelENT.BrowseCount4Case = objvCourseLearningCase_Resource_RelENS.BrowseCount4Case; //课例浏览次数
objvCourseLearningCase_Resource_RelENT.FileNewName = objvCourseLearningCase_Resource_RelENS.FileNewName; //新文件名
objvCourseLearningCase_Resource_RelENT.FileOldName = objvCourseLearningCase_Resource_RelENS.FileOldName; //旧文件名
objvCourseLearningCase_Resource_RelENT.IsDualVideo = objvCourseLearningCase_Resource_RelENS.IsDualVideo; //是否双视频
objvCourseLearningCase_Resource_RelENT.ViewCount = objvCourseLearningCase_Resource_RelENS.ViewCount; //浏览量
objvCourseLearningCase_Resource_RelENT.IsShow = objvCourseLearningCase_Resource_RelENS.IsShow; //是否启用
objvCourseLearningCase_Resource_RelENT.DownloadNumber = objvCourseLearningCase_Resource_RelENS.DownloadNumber; //下载数目
objvCourseLearningCase_Resource_RelENT.FileIntegration = objvCourseLearningCase_Resource_RelENS.FileIntegration; //文件积分
objvCourseLearningCase_Resource_RelENT.LikeCount = objvCourseLearningCase_Resource_RelENS.LikeCount; //资源喜欢数量
objvCourseLearningCase_Resource_RelENT.CollectionCount = objvCourseLearningCase_Resource_RelENS.CollectionCount; //收藏数量
objvCourseLearningCase_Resource_RelENT.IsVisible = objvCourseLearningCase_Resource_RelENS.IsVisible; //是否显示
objvCourseLearningCase_Resource_RelENT.UpdDate = objvCourseLearningCase_Resource_RelENS.UpdDate; //修改日期
objvCourseLearningCase_Resource_RelENT.UpdUser = objvCourseLearningCase_Resource_RelENS.UpdUser; //修改人
objvCourseLearningCase_Resource_RelENT.Memo = objvCourseLearningCase_Resource_RelENS.Memo; //备注
objvCourseLearningCase_Resource_RelENT.RecommendedDegreeId = objvCourseLearningCase_Resource_RelENS.RecommendedDegreeId; //推荐度Id
objvCourseLearningCase_Resource_RelENT.RecommendedDegreeName = objvCourseLearningCase_Resource_RelENS.RecommendedDegreeName; //推荐度名称
objvCourseLearningCase_Resource_RelENT.CollegeNameA = objvCourseLearningCase_Resource_RelENS.CollegeNameA; //学院名称简写
objvCourseLearningCase_Resource_RelENT.CourseChapterId = objvCourseLearningCase_Resource_RelENS.CourseChapterId; //课程章节ID
objvCourseLearningCase_Resource_RelENT.CourseChapterName = objvCourseLearningCase_Resource_RelENS.CourseChapterName; //课程章节名称
objvCourseLearningCase_Resource_RelENT.CourseChapterReferred = objvCourseLearningCase_Resource_RelENS.CourseChapterReferred; //节简称
objvCourseLearningCase_Resource_RelENT.ParentNodeReferred = objvCourseLearningCase_Resource_RelENS.ParentNodeReferred; //章简称
objvCourseLearningCase_Resource_RelENT.ParentNodeID = objvCourseLearningCase_Resource_RelENS.ParentNodeID; //父节点编号
objvCourseLearningCase_Resource_RelENT.ParentNodeName = objvCourseLearningCase_Resource_RelENS.ParentNodeName; //父节点名称
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvCourseLearningCase_Resource_RelEN objvCourseLearningCase_Resource_RelEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.FuncModuleId, 4, convCourseLearningCase_Resource_Rel.FuncModuleId);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.FuncModuleName, 30, convCourseLearningCase_Resource_Rel.FuncModuleName);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.IdMicroteachCase, 8, convCourseLearningCase_Resource_Rel.IdMicroteachCase);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.CourseLearningCaseID, 8, convCourseLearningCase_Resource_Rel.CourseLearningCaseID);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.CourseLearningCaseName, 100, convCourseLearningCase_Resource_Rel.CourseLearningCaseName);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.CourseLearningCaseText, 8000, convCourseLearningCase_Resource_Rel.CourseLearningCaseText);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTheme, 200, convCourseLearningCase_Resource_Rel.CourseLearningCaseTheme);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.CourseLearningCaseDate, 8, convCourseLearningCase_Resource_Rel.CourseLearningCaseDate);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTime, 6, convCourseLearningCase_Resource_Rel.CourseLearningCaseTime);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.CourseLearningCaseDateIn, 8, convCourseLearningCase_Resource_Rel.CourseLearningCaseDateIn);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTimeIn, 6, convCourseLearningCase_Resource_Rel.CourseLearningCaseTimeIn);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.IdCourseLearningCaseType, 4, convCourseLearningCase_Resource_Rel.IdCourseLearningCaseType);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTypeName, 30, convCourseLearningCase_Resource_Rel.CourseLearningCaseTypeName);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.OwnerId, 20, convCourseLearningCase_Resource_Rel.OwnerId);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.OwnerName, 30, convCourseLearningCase_Resource_Rel.OwnerName);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.OwnerNameWithId, 51, convCourseLearningCase_Resource_Rel.OwnerNameWithId);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.IdXzMajor, 8, convCourseLearningCase_Resource_Rel.IdXzMajor);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.MajorID, 4, convCourseLearningCase_Resource_Rel.MajorID);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.MajorName, 100, convCourseLearningCase_Resource_Rel.MajorName);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.IdXzCollege, 4, convCourseLearningCase_Resource_Rel.IdXzCollege);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.CollegeID, 4, convCourseLearningCase_Resource_Rel.CollegeID);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.CollegeName, 100, convCourseLearningCase_Resource_Rel.CollegeName);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.IdTeachSkill, 8, convCourseLearningCase_Resource_Rel.IdTeachSkill);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.TeachSkillID, 8, convCourseLearningCase_Resource_Rel.TeachSkillID);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.TeachSkillName, 50, convCourseLearningCase_Resource_Rel.TeachSkillName);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.TeachSkillTheory, 8000, convCourseLearningCase_Resource_Rel.TeachSkillTheory);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.TeachSkillOperMethod, 2000, convCourseLearningCase_Resource_Rel.TeachSkillOperMethod);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.SkillTypeID, 4, convCourseLearningCase_Resource_Rel.SkillTypeID);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.SkillTypeName, 50, convCourseLearningCase_Resource_Rel.SkillTypeName);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.IdDiscipline, 4, convCourseLearningCase_Resource_Rel.IdDiscipline);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.DisciplineID, 4, convCourseLearningCase_Resource_Rel.DisciplineID);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.DisciplineName, 50, convCourseLearningCase_Resource_Rel.DisciplineName);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.IdStudyLevel, 4, convCourseLearningCase_Resource_Rel.IdStudyLevel);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.StudyLevelName, 50, convCourseLearningCase_Resource_Rel.StudyLevelName);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.IdFile, 8, convCourseLearningCase_Resource_Rel.IdFile);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.FileName, 500, convCourseLearningCase_Resource_Rel.FileName);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.FileType, 30, convCourseLearningCase_Resource_Rel.FileType);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.SaveDate, 8, convCourseLearningCase_Resource_Rel.SaveDate);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.FileSize, 50, convCourseLearningCase_Resource_Rel.FileSize);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.SaveTime, 6, convCourseLearningCase_Resource_Rel.SaveTime);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.IdSkillType, 4, convCourseLearningCase_Resource_Rel.IdSkillType);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.IdTeachingPlan, 8, convCourseLearningCase_Resource_Rel.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.IdFtpResource, 8, convCourseLearningCase_Resource_Rel.IdFtpResource);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.FtpResourceID, 8, convCourseLearningCase_Resource_Rel.FtpResourceID);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.FileOriginalName, 200, convCourseLearningCase_Resource_Rel.FileOriginalName);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.FileDirName, 200, convCourseLearningCase_Resource_Rel.FileDirName);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.FileRename, 200, convCourseLearningCase_Resource_Rel.FileRename);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.FileUpDate, 8, convCourseLearningCase_Resource_Rel.FileUpDate);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.FileUpTime, 6, convCourseLearningCase_Resource_Rel.FileUpTime);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.IdResource, 8, convCourseLearningCase_Resource_Rel.IdResource);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.ResourceID, 8, convCourseLearningCase_Resource_Rel.ResourceID);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.IdResourceType, 4, convCourseLearningCase_Resource_Rel.IdResourceType);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.ResourceTypeID, 4, convCourseLearningCase_Resource_Rel.ResourceTypeID);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.ResourceTypeName, 50, convCourseLearningCase_Resource_Rel.ResourceTypeName);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.IdUsingMode, 4, convCourseLearningCase_Resource_Rel.IdUsingMode);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.CourseId, 8, convCourseLearningCase_Resource_Rel.CourseId);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.CourseCode, 20, convCourseLearningCase_Resource_Rel.CourseCode);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.CourseName, 100, convCourseLearningCase_Resource_Rel.CourseName);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.ResourceName, 100, convCourseLearningCase_Resource_Rel.ResourceName);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.ResourceOwner, 50, convCourseLearningCase_Resource_Rel.ResourceOwner);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.ftpFileType, 30, convCourseLearningCase_Resource_Rel.ftpFileType);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.ftpFileSize, 50, convCourseLearningCase_Resource_Rel.ftpFileSize);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.ftpResourceOwner, 50, convCourseLearningCase_Resource_Rel.ftpResourceOwner);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.FileOriginName, 500, convCourseLearningCase_Resource_Rel.FileOriginName);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.senateGaugeVersionID, 4, convCourseLearningCase_Resource_Rel.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.senateGaugeVersionName, 200, convCourseLearningCase_Resource_Rel.senateGaugeVersionName);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.CaseLevelId, 2, convCourseLearningCase_Resource_Rel.CaseLevelId);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.FileNewName, 530, convCourseLearningCase_Resource_Rel.FileNewName);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.FileOldName, 530, convCourseLearningCase_Resource_Rel.FileOldName);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.UpdDate, 20, convCourseLearningCase_Resource_Rel.UpdDate);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.UpdUser, 20, convCourseLearningCase_Resource_Rel.UpdUser);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.Memo, 1000, convCourseLearningCase_Resource_Rel.Memo);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.RecommendedDegreeId, 2, convCourseLearningCase_Resource_Rel.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.RecommendedDegreeName, 30, convCourseLearningCase_Resource_Rel.RecommendedDegreeName);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.CollegeNameA, 12, convCourseLearningCase_Resource_Rel.CollegeNameA);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.CourseChapterId, 8, convCourseLearningCase_Resource_Rel.CourseChapterId);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.CourseChapterName, 100, convCourseLearningCase_Resource_Rel.CourseChapterName);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.CourseChapterReferred, 10, convCourseLearningCase_Resource_Rel.CourseChapterReferred);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.ParentNodeReferred, 10, convCourseLearningCase_Resource_Rel.ParentNodeReferred);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.ParentNodeID, 8, convCourseLearningCase_Resource_Rel.ParentNodeID);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_Resource_RelEN.ParentNodeName, 50, convCourseLearningCase_Resource_Rel.ParentNodeName);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.FuncModuleId, convCourseLearningCase_Resource_Rel.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.FuncModuleName, convCourseLearningCase_Resource_Rel.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.IdMicroteachCase, convCourseLearningCase_Resource_Rel.IdMicroteachCase);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.CourseLearningCaseID, convCourseLearningCase_Resource_Rel.CourseLearningCaseID);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.CourseLearningCaseName, convCourseLearningCase_Resource_Rel.CourseLearningCaseName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.CourseLearningCaseText, convCourseLearningCase_Resource_Rel.CourseLearningCaseText);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTheme, convCourseLearningCase_Resource_Rel.CourseLearningCaseTheme);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.CourseLearningCaseDate, convCourseLearningCase_Resource_Rel.CourseLearningCaseDate);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTime, convCourseLearningCase_Resource_Rel.CourseLearningCaseTime);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.CourseLearningCaseDateIn, convCourseLearningCase_Resource_Rel.CourseLearningCaseDateIn);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTimeIn, convCourseLearningCase_Resource_Rel.CourseLearningCaseTimeIn);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.IdCourseLearningCaseType, convCourseLearningCase_Resource_Rel.IdCourseLearningCaseType);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.CourseLearningCaseTypeName, convCourseLearningCase_Resource_Rel.CourseLearningCaseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.OwnerId, convCourseLearningCase_Resource_Rel.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.OwnerName, convCourseLearningCase_Resource_Rel.OwnerName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.OwnerNameWithId, convCourseLearningCase_Resource_Rel.OwnerNameWithId);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.IdXzMajor, convCourseLearningCase_Resource_Rel.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.MajorID, convCourseLearningCase_Resource_Rel.MajorID);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.MajorName, convCourseLearningCase_Resource_Rel.MajorName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.IdXzCollege, convCourseLearningCase_Resource_Rel.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.CollegeID, convCourseLearningCase_Resource_Rel.CollegeID);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.CollegeName, convCourseLearningCase_Resource_Rel.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.IdTeachSkill, convCourseLearningCase_Resource_Rel.IdTeachSkill);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.TeachSkillID, convCourseLearningCase_Resource_Rel.TeachSkillID);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.TeachSkillName, convCourseLearningCase_Resource_Rel.TeachSkillName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.TeachSkillTheory, convCourseLearningCase_Resource_Rel.TeachSkillTheory);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.TeachSkillOperMethod, convCourseLearningCase_Resource_Rel.TeachSkillOperMethod);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.SkillTypeID, convCourseLearningCase_Resource_Rel.SkillTypeID);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.SkillTypeName, convCourseLearningCase_Resource_Rel.SkillTypeName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.IdDiscipline, convCourseLearningCase_Resource_Rel.IdDiscipline);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.DisciplineID, convCourseLearningCase_Resource_Rel.DisciplineID);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.DisciplineName, convCourseLearningCase_Resource_Rel.DisciplineName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.IdStudyLevel, convCourseLearningCase_Resource_Rel.IdStudyLevel);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.StudyLevelName, convCourseLearningCase_Resource_Rel.StudyLevelName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.IdFile, convCourseLearningCase_Resource_Rel.IdFile);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.FileName, convCourseLearningCase_Resource_Rel.FileName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.FileType, convCourseLearningCase_Resource_Rel.FileType);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.SaveDate, convCourseLearningCase_Resource_Rel.SaveDate);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.FileSize, convCourseLearningCase_Resource_Rel.FileSize);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.SaveTime, convCourseLearningCase_Resource_Rel.SaveTime);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.IdSkillType, convCourseLearningCase_Resource_Rel.IdSkillType);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.IdTeachingPlan, convCourseLearningCase_Resource_Rel.IdTeachingPlan);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.IdFtpResource, convCourseLearningCase_Resource_Rel.IdFtpResource);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.FtpResourceID, convCourseLearningCase_Resource_Rel.FtpResourceID);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.FileOriginalName, convCourseLearningCase_Resource_Rel.FileOriginalName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.FileDirName, convCourseLearningCase_Resource_Rel.FileDirName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.FileRename, convCourseLearningCase_Resource_Rel.FileRename);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.FileUpDate, convCourseLearningCase_Resource_Rel.FileUpDate);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.FileUpTime, convCourseLearningCase_Resource_Rel.FileUpTime);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.IdResource, convCourseLearningCase_Resource_Rel.IdResource);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.ResourceID, convCourseLearningCase_Resource_Rel.ResourceID);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.IdResourceType, convCourseLearningCase_Resource_Rel.IdResourceType);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.ResourceTypeID, convCourseLearningCase_Resource_Rel.ResourceTypeID);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.ResourceTypeName, convCourseLearningCase_Resource_Rel.ResourceTypeName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.IdUsingMode, convCourseLearningCase_Resource_Rel.IdUsingMode);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.CourseId, convCourseLearningCase_Resource_Rel.CourseId);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.CourseCode, convCourseLearningCase_Resource_Rel.CourseCode);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.CourseName, convCourseLearningCase_Resource_Rel.CourseName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.ResourceName, convCourseLearningCase_Resource_Rel.ResourceName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.ResourceOwner, convCourseLearningCase_Resource_Rel.ResourceOwner);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.ftpFileType, convCourseLearningCase_Resource_Rel.ftpFileType);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.ftpFileSize, convCourseLearningCase_Resource_Rel.ftpFileSize);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.ftpResourceOwner, convCourseLearningCase_Resource_Rel.ftpResourceOwner);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.FileOriginName, convCourseLearningCase_Resource_Rel.FileOriginName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.senateGaugeVersionID, convCourseLearningCase_Resource_Rel.senateGaugeVersionID);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.senateGaugeVersionName, convCourseLearningCase_Resource_Rel.senateGaugeVersionName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.CaseLevelId, convCourseLearningCase_Resource_Rel.CaseLevelId);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.FileNewName, convCourseLearningCase_Resource_Rel.FileNewName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.FileOldName, convCourseLearningCase_Resource_Rel.FileOldName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.UpdDate, convCourseLearningCase_Resource_Rel.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.UpdUser, convCourseLearningCase_Resource_Rel.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.Memo, convCourseLearningCase_Resource_Rel.Memo);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.RecommendedDegreeId, convCourseLearningCase_Resource_Rel.RecommendedDegreeId);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.RecommendedDegreeName, convCourseLearningCase_Resource_Rel.RecommendedDegreeName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.CollegeNameA, convCourseLearningCase_Resource_Rel.CollegeNameA);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.CourseChapterId, convCourseLearningCase_Resource_Rel.CourseChapterId);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.CourseChapterName, convCourseLearningCase_Resource_Rel.CourseChapterName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.CourseChapterReferred, convCourseLearningCase_Resource_Rel.CourseChapterReferred);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.ParentNodeReferred, convCourseLearningCase_Resource_Rel.ParentNodeReferred);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.ParentNodeID, convCourseLearningCase_Resource_Rel.ParentNodeID);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_Resource_RelEN.ParentNodeName, convCourseLearningCase_Resource_Rel.ParentNodeName);
//检查外键字段长度
 objvCourseLearningCase_Resource_RelEN._IsCheckProperty = true;
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
 objSQL = clsvCourseLearningCase_Resource_RelDA.GetSpecSQLObj();
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
 objSQL = clsvCourseLearningCase_Resource_RelDA.GetSpecSQLObj();
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
 objSQL = clsvCourseLearningCase_Resource_RelDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCourseLearningCase_Resource_RelEN._CurrTabName);
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
 objSQL = clsvCourseLearningCase_Resource_RelDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCourseLearningCase_Resource_RelEN._CurrTabName, strCondition);
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
 objSQL = clsvCourseLearningCase_Resource_RelDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}