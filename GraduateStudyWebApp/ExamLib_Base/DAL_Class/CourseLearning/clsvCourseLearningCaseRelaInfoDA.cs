
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCourseLearningCaseRelaInfoDA
 表名:vCourseLearningCaseRelaInfo(01120270)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:45:56
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
 /// v课程学习案例相关信息(vCourseLearningCaseRelaInfo)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvCourseLearningCaseRelaInfoDA : clsCommBase4DA
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
 return clsvCourseLearningCaseRelaInfoEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvCourseLearningCaseRelaInfoEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCourseLearningCaseRelaInfoEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvCourseLearningCaseRelaInfoEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvCourseLearningCaseRelaInfoEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvCourseLearningCaseRelaInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vCourseLearningCaseRelaInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vCourseLearningCaseRelaInfo(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvCourseLearningCaseRelaInfoDA: GetDataTable_vCourseLearningCaseRelaInfo)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vCourseLearningCaseRelaInfo where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvCourseLearningCaseRelaInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCaseRelaInfoDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvCourseLearningCaseRelaInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vCourseLearningCaseRelaInfo where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvCourseLearningCaseRelaInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCaseRelaInfoDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvCourseLearningCaseRelaInfoDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCaseRelaInfoDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCourseLearningCaseRelaInfo where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCourseLearningCaseRelaInfo where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvCourseLearningCaseRelaInfoDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCaseRelaInfoDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vCourseLearningCaseRelaInfo where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvCourseLearningCaseRelaInfoDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCaseRelaInfoDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vCourseLearningCaseRelaInfo.* from vCourseLearningCaseRelaInfo Left Join {1} on {2} where {3} and vCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfo not in (Select top {5} vCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfo from vCourseLearningCaseRelaInfo Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCourseLearningCaseRelaInfo where {1} and IdMicroTeachCaseRelaInfo not in (Select top {2} IdMicroTeachCaseRelaInfo from vCourseLearningCaseRelaInfo where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCourseLearningCaseRelaInfo where {1} and IdMicroTeachCaseRelaInfo not in (Select top {3} IdMicroTeachCaseRelaInfo from vCourseLearningCaseRelaInfo where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvCourseLearningCaseRelaInfoDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCaseRelaInfoDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vCourseLearningCaseRelaInfo.* from vCourseLearningCaseRelaInfo Left Join {1} on {2} where {3} and vCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfo not in (Select top {5} vCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfo from vCourseLearningCaseRelaInfo Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCourseLearningCaseRelaInfo where {1} and IdMicroTeachCaseRelaInfo not in (Select top {2} IdMicroTeachCaseRelaInfo from vCourseLearningCaseRelaInfo where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCourseLearningCaseRelaInfo where {1} and IdMicroTeachCaseRelaInfo not in (Select top {3} IdMicroTeachCaseRelaInfo from vCourseLearningCaseRelaInfo where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvCourseLearningCaseRelaInfoEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvCourseLearningCaseRelaInfoDA:GetObjLst)", objException.Message));
}
List<clsvCourseLearningCaseRelaInfoEN> arrObjLst = new List<clsvCourseLearningCaseRelaInfoEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vCourseLearningCaseRelaInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN = new clsvCourseLearningCaseRelaInfoEN();
try
{
objvCourseLearningCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = TransNullToInt(objRow[convCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvCourseLearningCaseRelaInfoEN.FuncModuleId = objRow[convCourseLearningCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningCaseRelaInfoEN.FuncModuleName = objRow[convCourseLearningCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningCaseRelaInfoEN.IdCourseLearningCase = objRow[convCourseLearningCaseRelaInfo.IdCourseLearningCase] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCaseRelaInfoEN.IdMicroteachCase = objRow[convCourseLearningCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCourseLearningCaseRelaInfoEN.CourseLearningCaseName = objRow[convCourseLearningCaseRelaInfo.CourseLearningCaseName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfoType] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvCourseLearningCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objvCourseLearningCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvCourseLearningCaseRelaInfoEN.IdFile = objRow[convCourseLearningCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvCourseLearningCaseRelaInfoEN.FileName = objRow[convCourseLearningCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvCourseLearningCaseRelaInfoEN.FileType = objRow[convCourseLearningCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvCourseLearningCaseRelaInfoEN.SaveDate = objRow[convCourseLearningCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvCourseLearningCaseRelaInfoEN.FileSize = objRow[convCourseLearningCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvCourseLearningCaseRelaInfoEN.SaveTime = objRow[convCourseLearningCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvCourseLearningCaseRelaInfoEN.IdFtpResource = objRow[convCourseLearningCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvCourseLearningCaseRelaInfoEN.FtpResourceID = objRow[convCourseLearningCaseRelaInfo.FtpResourceID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvCourseLearningCaseRelaInfoEN.FileOriginalName = objRow[convCourseLearningCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvCourseLearningCaseRelaInfoEN.FileDirName = objRow[convCourseLearningCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvCourseLearningCaseRelaInfoEN.FileRename = objRow[convCourseLearningCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvCourseLearningCaseRelaInfoEN.FileUpDate = objRow[convCourseLearningCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvCourseLearningCaseRelaInfoEN.FileUpTime = objRow[convCourseLearningCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvCourseLearningCaseRelaInfoEN.IdResource = objRow[convCourseLearningCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvCourseLearningCaseRelaInfoEN.ResourceID = objRow[convCourseLearningCaseRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvCourseLearningCaseRelaInfoEN.SaveMode = TransNullToBool(objRow[convCourseLearningCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvCourseLearningCaseRelaInfoEN.IdResourceType = objRow[convCourseLearningCaseRelaInfo.IdResourceType] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvCourseLearningCaseRelaInfoEN.ResourceTypeID = objRow[convCourseLearningCaseRelaInfo.ResourceTypeID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvCourseLearningCaseRelaInfoEN.ResourceTypeName = objRow[convCourseLearningCaseRelaInfo.ResourceTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvCourseLearningCaseRelaInfoEN.MajorID = objRow[convCourseLearningCaseRelaInfo.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCaseRelaInfoEN.MajorName = objRow[convCourseLearningCaseRelaInfo.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCaseRelaInfoEN.IdXzCollege = objRow[convCourseLearningCaseRelaInfo.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCaseRelaInfoEN.CollegeID = objRow[convCourseLearningCaseRelaInfo.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CollegeID].ToString().Trim(); //学院ID
objvCourseLearningCaseRelaInfoEN.CollegeName = objRow[convCourseLearningCaseRelaInfo.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCaseRelaInfoEN.CourseId = objRow[convCourseLearningCaseRelaInfo.CourseId] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCaseRelaInfoEN.CourseCode = objRow[convCourseLearningCaseRelaInfo.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCaseRelaInfoEN.CourseName = objRow[convCourseLearningCaseRelaInfo.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCaseRelaInfoEN.BrowseCount = objRow[convCourseLearningCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvCourseLearningCaseRelaInfoEN.ResourceOwner = objRow[convCourseLearningCaseRelaInfo.ResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvCourseLearningCaseRelaInfoEN.ftpFileType = objRow[convCourseLearningCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvCourseLearningCaseRelaInfoEN.ftpFileSize = objRow[convCourseLearningCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvCourseLearningCaseRelaInfoEN.ftpResourceOwner = objRow[convCourseLearningCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvCourseLearningCaseRelaInfoEN.FileOriginName = objRow[convCourseLearningCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvCourseLearningCaseRelaInfoEN.IsExistFile = TransNullToBool(objRow[convCourseLearningCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvCourseLearningCaseRelaInfoEN.Flag = objRow[convCourseLearningCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.Flag].ToString().Trim(); //标志
objvCourseLearningCaseRelaInfoEN.FileNewName = objRow[convCourseLearningCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvCourseLearningCaseRelaInfoEN.FileOldName = objRow[convCourseLearningCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvCourseLearningCaseRelaInfoEN.IsVisible = TransNullToBool(objRow[convCourseLearningCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvCourseLearningCaseRelaInfoEN.UpdDate = objRow[convCourseLearningCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvCourseLearningCaseRelaInfoEN.UpdUser = objRow[convCourseLearningCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objvCourseLearningCaseRelaInfoEN.Memo = objRow[convCourseLearningCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCourseLearningCaseRelaInfoDA: GetObjLst)", objException.Message));
}
objvCourseLearningCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCourseLearningCaseRelaInfoEN);
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
public List<clsvCourseLearningCaseRelaInfoEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvCourseLearningCaseRelaInfoDA:GetObjLstByTabName)", objException.Message));
}
List<clsvCourseLearningCaseRelaInfoEN> arrObjLst = new List<clsvCourseLearningCaseRelaInfoEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCaseRelaInfoDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN = new clsvCourseLearningCaseRelaInfoEN();
try
{
objvCourseLearningCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = TransNullToInt(objRow[convCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvCourseLearningCaseRelaInfoEN.FuncModuleId = objRow[convCourseLearningCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningCaseRelaInfoEN.FuncModuleName = objRow[convCourseLearningCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningCaseRelaInfoEN.IdCourseLearningCase = objRow[convCourseLearningCaseRelaInfo.IdCourseLearningCase] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCaseRelaInfoEN.IdMicroteachCase = objRow[convCourseLearningCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCourseLearningCaseRelaInfoEN.CourseLearningCaseName = objRow[convCourseLearningCaseRelaInfo.CourseLearningCaseName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfoType] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvCourseLearningCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objvCourseLearningCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvCourseLearningCaseRelaInfoEN.IdFile = objRow[convCourseLearningCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvCourseLearningCaseRelaInfoEN.FileName = objRow[convCourseLearningCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvCourseLearningCaseRelaInfoEN.FileType = objRow[convCourseLearningCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvCourseLearningCaseRelaInfoEN.SaveDate = objRow[convCourseLearningCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvCourseLearningCaseRelaInfoEN.FileSize = objRow[convCourseLearningCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvCourseLearningCaseRelaInfoEN.SaveTime = objRow[convCourseLearningCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvCourseLearningCaseRelaInfoEN.IdFtpResource = objRow[convCourseLearningCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvCourseLearningCaseRelaInfoEN.FtpResourceID = objRow[convCourseLearningCaseRelaInfo.FtpResourceID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvCourseLearningCaseRelaInfoEN.FileOriginalName = objRow[convCourseLearningCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvCourseLearningCaseRelaInfoEN.FileDirName = objRow[convCourseLearningCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvCourseLearningCaseRelaInfoEN.FileRename = objRow[convCourseLearningCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvCourseLearningCaseRelaInfoEN.FileUpDate = objRow[convCourseLearningCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvCourseLearningCaseRelaInfoEN.FileUpTime = objRow[convCourseLearningCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvCourseLearningCaseRelaInfoEN.IdResource = objRow[convCourseLearningCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvCourseLearningCaseRelaInfoEN.ResourceID = objRow[convCourseLearningCaseRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvCourseLearningCaseRelaInfoEN.SaveMode = TransNullToBool(objRow[convCourseLearningCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvCourseLearningCaseRelaInfoEN.IdResourceType = objRow[convCourseLearningCaseRelaInfo.IdResourceType] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvCourseLearningCaseRelaInfoEN.ResourceTypeID = objRow[convCourseLearningCaseRelaInfo.ResourceTypeID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvCourseLearningCaseRelaInfoEN.ResourceTypeName = objRow[convCourseLearningCaseRelaInfo.ResourceTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvCourseLearningCaseRelaInfoEN.MajorID = objRow[convCourseLearningCaseRelaInfo.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCaseRelaInfoEN.MajorName = objRow[convCourseLearningCaseRelaInfo.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCaseRelaInfoEN.IdXzCollege = objRow[convCourseLearningCaseRelaInfo.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCaseRelaInfoEN.CollegeID = objRow[convCourseLearningCaseRelaInfo.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CollegeID].ToString().Trim(); //学院ID
objvCourseLearningCaseRelaInfoEN.CollegeName = objRow[convCourseLearningCaseRelaInfo.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCaseRelaInfoEN.CourseId = objRow[convCourseLearningCaseRelaInfo.CourseId] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCaseRelaInfoEN.CourseCode = objRow[convCourseLearningCaseRelaInfo.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCaseRelaInfoEN.CourseName = objRow[convCourseLearningCaseRelaInfo.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCaseRelaInfoEN.BrowseCount = objRow[convCourseLearningCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvCourseLearningCaseRelaInfoEN.ResourceOwner = objRow[convCourseLearningCaseRelaInfo.ResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvCourseLearningCaseRelaInfoEN.ftpFileType = objRow[convCourseLearningCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvCourseLearningCaseRelaInfoEN.ftpFileSize = objRow[convCourseLearningCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvCourseLearningCaseRelaInfoEN.ftpResourceOwner = objRow[convCourseLearningCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvCourseLearningCaseRelaInfoEN.FileOriginName = objRow[convCourseLearningCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvCourseLearningCaseRelaInfoEN.IsExistFile = TransNullToBool(objRow[convCourseLearningCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvCourseLearningCaseRelaInfoEN.Flag = objRow[convCourseLearningCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.Flag].ToString().Trim(); //标志
objvCourseLearningCaseRelaInfoEN.FileNewName = objRow[convCourseLearningCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvCourseLearningCaseRelaInfoEN.FileOldName = objRow[convCourseLearningCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvCourseLearningCaseRelaInfoEN.IsVisible = TransNullToBool(objRow[convCourseLearningCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvCourseLearningCaseRelaInfoEN.UpdDate = objRow[convCourseLearningCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvCourseLearningCaseRelaInfoEN.UpdUser = objRow[convCourseLearningCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objvCourseLearningCaseRelaInfoEN.Memo = objRow[convCourseLearningCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCourseLearningCaseRelaInfoDA: GetObjLst)", objException.Message));
}
objvCourseLearningCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCourseLearningCaseRelaInfoEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvCourseLearningCaseRelaInfo(ref clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vCourseLearningCaseRelaInfo where IdMicroTeachCaseRelaInfo = " + ""+ objvCourseLearningCaseRelaInfoEN.IdMicroTeachCaseRelaInfo+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvCourseLearningCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = TransNullToInt(objDT.Rows[0][convCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvCourseLearningCaseRelaInfoEN.FuncModuleId = objDT.Rows[0][convCourseLearningCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvCourseLearningCaseRelaInfoEN.FuncModuleName = objDT.Rows[0][convCourseLearningCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCourseLearningCaseRelaInfoEN.IdCourseLearningCase = objDT.Rows[0][convCourseLearningCaseRelaInfo.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCaseRelaInfoEN.IdMicroteachCase = objDT.Rows[0][convCourseLearningCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCaseRelaInfoEN.CourseLearningCaseName = objDT.Rows[0][convCourseLearningCaseRelaInfo.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCourseLearningCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objDT.Rows[0][convCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objDT.Rows[0][convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objDT.Rows[0][convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCourseLearningCaseRelaInfoEN.IdFile = objDT.Rows[0][convCourseLearningCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningCaseRelaInfoEN.FileName = objDT.Rows[0][convCourseLearningCaseRelaInfo.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvCourseLearningCaseRelaInfoEN.FileType = objDT.Rows[0][convCourseLearningCaseRelaInfo.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvCourseLearningCaseRelaInfoEN.SaveDate = objDT.Rows[0][convCourseLearningCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningCaseRelaInfoEN.FileSize = objDT.Rows[0][convCourseLearningCaseRelaInfo.FileSize].ToString().Trim(); //文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvCourseLearningCaseRelaInfoEN.SaveTime = objDT.Rows[0][convCourseLearningCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvCourseLearningCaseRelaInfoEN.IdFtpResource = objDT.Rows[0][convCourseLearningCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningCaseRelaInfoEN.FtpResourceID = objDT.Rows[0][convCourseLearningCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCaseRelaInfoEN.FileOriginalName = objDT.Rows[0][convCourseLearningCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名(字段类型:varchar,字段长度:200,是否可空:True)
 objvCourseLearningCaseRelaInfoEN.FileDirName = objDT.Rows[0][convCourseLearningCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objvCourseLearningCaseRelaInfoEN.FileRename = objDT.Rows[0][convCourseLearningCaseRelaInfo.FileRename].ToString().Trim(); //文件新名(字段类型:varchar,字段长度:200,是否可空:True)
 objvCourseLearningCaseRelaInfoEN.FileUpDate = objDT.Rows[0][convCourseLearningCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningCaseRelaInfoEN.FileUpTime = objDT.Rows[0][convCourseLearningCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvCourseLearningCaseRelaInfoEN.IdResource = objDT.Rows[0][convCourseLearningCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCaseRelaInfoEN.ResourceID = objDT.Rows[0][convCourseLearningCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCaseRelaInfoEN.SaveMode = TransNullToBool(objDT.Rows[0][convCourseLearningCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式(字段类型:bit,字段长度:1,是否可空:True)
 objvCourseLearningCaseRelaInfoEN.IdResourceType = objDT.Rows[0][convCourseLearningCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCaseRelaInfoEN.ResourceTypeID = objDT.Rows[0][convCourseLearningCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCaseRelaInfoEN.ResourceTypeName = objDT.Rows[0][convCourseLearningCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCourseLearningCaseRelaInfoEN.MajorID = objDT.Rows[0][convCourseLearningCaseRelaInfo.MajorID].ToString().Trim(); //专业ID(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCaseRelaInfoEN.MajorName = objDT.Rows[0][convCourseLearningCaseRelaInfo.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCourseLearningCaseRelaInfoEN.IdXzCollege = objDT.Rows[0][convCourseLearningCaseRelaInfo.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvCourseLearningCaseRelaInfoEN.CollegeID = objDT.Rows[0][convCourseLearningCaseRelaInfo.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvCourseLearningCaseRelaInfoEN.CollegeName = objDT.Rows[0][convCourseLearningCaseRelaInfo.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCourseLearningCaseRelaInfoEN.CourseId = objDT.Rows[0][convCourseLearningCaseRelaInfo.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningCaseRelaInfoEN.CourseCode = objDT.Rows[0][convCourseLearningCaseRelaInfo.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvCourseLearningCaseRelaInfoEN.CourseName = objDT.Rows[0][convCourseLearningCaseRelaInfo.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvCourseLearningCaseRelaInfoEN.BrowseCount = TransNullToInt(objDT.Rows[0][convCourseLearningCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvCourseLearningCaseRelaInfoEN.ResourceOwner = objDT.Rows[0][convCourseLearningCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者(字段类型:varchar,字段长度:50,是否可空:False)
 objvCourseLearningCaseRelaInfoEN.ftpFileType = objDT.Rows[0][convCourseLearningCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvCourseLearningCaseRelaInfoEN.ftpFileSize = objDT.Rows[0][convCourseLearningCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvCourseLearningCaseRelaInfoEN.ftpResourceOwner = objDT.Rows[0][convCourseLearningCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者(字段类型:varchar,字段长度:50,是否可空:True)
 objvCourseLearningCaseRelaInfoEN.FileOriginName = objDT.Rows[0][convCourseLearningCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名(字段类型:varchar,字段长度:500,是否可空:True)
 objvCourseLearningCaseRelaInfoEN.IsExistFile = TransNullToBool(objDT.Rows[0][convCourseLearningCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objvCourseLearningCaseRelaInfoEN.Flag = objDT.Rows[0][convCourseLearningCaseRelaInfo.Flag].ToString().Trim(); //标志(字段类型:varchar,字段长度:50,是否可空:True)
 objvCourseLearningCaseRelaInfoEN.FileNewName = objDT.Rows[0][convCourseLearningCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvCourseLearningCaseRelaInfoEN.FileOldName = objDT.Rows[0][convCourseLearningCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvCourseLearningCaseRelaInfoEN.IsVisible = TransNullToBool(objDT.Rows[0][convCourseLearningCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvCourseLearningCaseRelaInfoEN.UpdDate = objDT.Rows[0][convCourseLearningCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvCourseLearningCaseRelaInfoEN.UpdUser = objDT.Rows[0][convCourseLearningCaseRelaInfo.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvCourseLearningCaseRelaInfoEN.Memo = objDT.Rows[0][convCourseLearningCaseRelaInfo.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvCourseLearningCaseRelaInfoDA: GetvCourseLearningCaseRelaInfo)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdMicroTeachCaseRelaInfo">表关键字</param>
 /// <returns>表对象</returns>
public clsvCourseLearningCaseRelaInfoEN GetObjByIdMicroTeachCaseRelaInfo(long lngIdMicroTeachCaseRelaInfo)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vCourseLearningCaseRelaInfo where IdMicroTeachCaseRelaInfo = " + ""+ lngIdMicroTeachCaseRelaInfo+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN = new clsvCourseLearningCaseRelaInfoEN();
try
{
 objvCourseLearningCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = Int32.Parse(objRow[convCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvCourseLearningCaseRelaInfoEN.FuncModuleId = objRow[convCourseLearningCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvCourseLearningCaseRelaInfoEN.FuncModuleName = objRow[convCourseLearningCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCourseLearningCaseRelaInfoEN.IdCourseLearningCase = objRow[convCourseLearningCaseRelaInfo.IdCourseLearningCase] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCaseRelaInfoEN.IdMicroteachCase = objRow[convCourseLearningCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCaseRelaInfoEN.CourseLearningCaseName = objRow[convCourseLearningCaseRelaInfo.CourseLearningCaseName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCourseLearningCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfoType] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCourseLearningCaseRelaInfoEN.IdFile = objRow[convCourseLearningCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningCaseRelaInfoEN.FileName = objRow[convCourseLearningCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvCourseLearningCaseRelaInfoEN.FileType = objRow[convCourseLearningCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvCourseLearningCaseRelaInfoEN.SaveDate = objRow[convCourseLearningCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningCaseRelaInfoEN.FileSize = objRow[convCourseLearningCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileSize].ToString().Trim(); //文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvCourseLearningCaseRelaInfoEN.SaveTime = objRow[convCourseLearningCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvCourseLearningCaseRelaInfoEN.IdFtpResource = objRow[convCourseLearningCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningCaseRelaInfoEN.FtpResourceID = objRow[convCourseLearningCaseRelaInfo.FtpResourceID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCaseRelaInfoEN.FileOriginalName = objRow[convCourseLearningCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名(字段类型:varchar,字段长度:200,是否可空:True)
 objvCourseLearningCaseRelaInfoEN.FileDirName = objRow[convCourseLearningCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objvCourseLearningCaseRelaInfoEN.FileRename = objRow[convCourseLearningCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileRename].ToString().Trim(); //文件新名(字段类型:varchar,字段长度:200,是否可空:True)
 objvCourseLearningCaseRelaInfoEN.FileUpDate = objRow[convCourseLearningCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningCaseRelaInfoEN.FileUpTime = objRow[convCourseLearningCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvCourseLearningCaseRelaInfoEN.IdResource = objRow[convCourseLearningCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCaseRelaInfoEN.ResourceID = objRow[convCourseLearningCaseRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCaseRelaInfoEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式(字段类型:bit,字段长度:1,是否可空:True)
 objvCourseLearningCaseRelaInfoEN.IdResourceType = objRow[convCourseLearningCaseRelaInfo.IdResourceType] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCaseRelaInfoEN.ResourceTypeID = objRow[convCourseLearningCaseRelaInfo.ResourceTypeID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCaseRelaInfoEN.ResourceTypeName = objRow[convCourseLearningCaseRelaInfo.ResourceTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCourseLearningCaseRelaInfoEN.MajorID = objRow[convCourseLearningCaseRelaInfo.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.MajorID].ToString().Trim(); //专业ID(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCaseRelaInfoEN.MajorName = objRow[convCourseLearningCaseRelaInfo.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCourseLearningCaseRelaInfoEN.IdXzCollege = objRow[convCourseLearningCaseRelaInfo.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvCourseLearningCaseRelaInfoEN.CollegeID = objRow[convCourseLearningCaseRelaInfo.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvCourseLearningCaseRelaInfoEN.CollegeName = objRow[convCourseLearningCaseRelaInfo.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCourseLearningCaseRelaInfoEN.CourseId = objRow[convCourseLearningCaseRelaInfo.CourseId] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningCaseRelaInfoEN.CourseCode = objRow[convCourseLearningCaseRelaInfo.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvCourseLearningCaseRelaInfoEN.CourseName = objRow[convCourseLearningCaseRelaInfo.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvCourseLearningCaseRelaInfoEN.BrowseCount = objRow[convCourseLearningCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvCourseLearningCaseRelaInfoEN.ResourceOwner = objRow[convCourseLearningCaseRelaInfo.ResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者(字段类型:varchar,字段长度:50,是否可空:False)
 objvCourseLearningCaseRelaInfoEN.ftpFileType = objRow[convCourseLearningCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvCourseLearningCaseRelaInfoEN.ftpFileSize = objRow[convCourseLearningCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvCourseLearningCaseRelaInfoEN.ftpResourceOwner = objRow[convCourseLearningCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者(字段类型:varchar,字段长度:50,是否可空:True)
 objvCourseLearningCaseRelaInfoEN.FileOriginName = objRow[convCourseLearningCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名(字段类型:varchar,字段长度:500,是否可空:True)
 objvCourseLearningCaseRelaInfoEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objvCourseLearningCaseRelaInfoEN.Flag = objRow[convCourseLearningCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.Flag].ToString().Trim(); //标志(字段类型:varchar,字段长度:50,是否可空:True)
 objvCourseLearningCaseRelaInfoEN.FileNewName = objRow[convCourseLearningCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvCourseLearningCaseRelaInfoEN.FileOldName = objRow[convCourseLearningCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvCourseLearningCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvCourseLearningCaseRelaInfoEN.UpdDate = objRow[convCourseLearningCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvCourseLearningCaseRelaInfoEN.UpdUser = objRow[convCourseLearningCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvCourseLearningCaseRelaInfoEN.Memo = objRow[convCourseLearningCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvCourseLearningCaseRelaInfoDA: GetObjByIdMicroTeachCaseRelaInfo)", objException.Message));
}
return objvCourseLearningCaseRelaInfoEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvCourseLearningCaseRelaInfoEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvCourseLearningCaseRelaInfoDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vCourseLearningCaseRelaInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN = new clsvCourseLearningCaseRelaInfoEN()
{
IdMicroTeachCaseRelaInfo = TransNullToInt(objRow[convCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()), //案例相关信息流水号
FuncModuleId = objRow[convCourseLearningCaseRelaInfo.FuncModuleId].ToString().Trim(), //功能模块Id
FuncModuleName = objRow[convCourseLearningCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FuncModuleName].ToString().Trim(), //功能模块名称
IdCourseLearningCase = objRow[convCourseLearningCaseRelaInfo.IdCourseLearningCase] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdCourseLearningCase].ToString().Trim(), //课程学习案例流水号
IdMicroteachCase = objRow[convCourseLearningCaseRelaInfo.IdMicroteachCase].ToString().Trim(), //微格教学案例流水号
CourseLearningCaseName = objRow[convCourseLearningCaseRelaInfo.CourseLearningCaseName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CourseLearningCaseName].ToString().Trim(), //课程学习案例名称
IdMicroTeachCaseRelaInfoType = objRow[convCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfoType] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(), //微格案例相关信息类型流水号
MicroTeachCaseRelaInfoTypeID = objRow[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(), //微格案例相关信息类型ID
MicroTeachCaseRelaInfoTypeName = objRow[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(), //微格案例相关信息类型名称
IdFile = objRow[convCourseLearningCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdFile].ToString().Trim(), //文件流水号
FileName = objRow[convCourseLearningCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileName].ToString().Trim(), //文件名称
FileType = objRow[convCourseLearningCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileType].ToString().Trim(), //文件类型
SaveDate = objRow[convCourseLearningCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.SaveDate].ToString().Trim(), //创建日期
FileSize = objRow[convCourseLearningCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileSize].ToString().Trim(), //文件大小
SaveTime = objRow[convCourseLearningCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.SaveTime].ToString().Trim(), //创建时间
IdFtpResource = objRow[convCourseLearningCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdFtpResource].ToString().Trim(), //FTP资源流水号
FtpResourceID = objRow[convCourseLearningCaseRelaInfo.FtpResourceID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FtpResourceID].ToString().Trim(), //FTP资源ID
FileOriginalName = objRow[convCourseLearningCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileOriginalName].ToString().Trim(), //文件原名
FileDirName = objRow[convCourseLearningCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileDirName].ToString().Trim(), //文件目录名
FileRename = objRow[convCourseLearningCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileRename].ToString().Trim(), //文件新名
FileUpDate = objRow[convCourseLearningCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileUpDate].ToString().Trim(), //创建日期
FileUpTime = objRow[convCourseLearningCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileUpTime].ToString().Trim(), //创建时间
IdResource = objRow[convCourseLearningCaseRelaInfo.IdResource].ToString().Trim(), //资源流水号
ResourceID = objRow[convCourseLearningCaseRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ResourceID].ToString().Trim(), //资源ID
SaveMode = TransNullToBool(objRow[convCourseLearningCaseRelaInfo.SaveMode].ToString().Trim()), //文件存放方式
IdResourceType = objRow[convCourseLearningCaseRelaInfo.IdResourceType] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdResourceType].ToString().Trim(), //资源类型流水号
ResourceTypeID = objRow[convCourseLearningCaseRelaInfo.ResourceTypeID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ResourceTypeID].ToString().Trim(), //资源类型ID
ResourceTypeName = objRow[convCourseLearningCaseRelaInfo.ResourceTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ResourceTypeName].ToString().Trim(), //资源类型名称
MajorID = objRow[convCourseLearningCaseRelaInfo.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.MajorID].ToString().Trim(), //专业ID
MajorName = objRow[convCourseLearningCaseRelaInfo.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.MajorName].ToString().Trim(), //专业名称
IdXzCollege = objRow[convCourseLearningCaseRelaInfo.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdXzCollege].ToString().Trim(), //学院流水号
CollegeID = objRow[convCourseLearningCaseRelaInfo.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CollegeID].ToString().Trim(), //学院ID
CollegeName = objRow[convCourseLearningCaseRelaInfo.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CollegeName].ToString().Trim(), //学院名称
CourseId = objRow[convCourseLearningCaseRelaInfo.CourseId] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CourseId].ToString().Trim(), //课程Id
CourseCode = objRow[convCourseLearningCaseRelaInfo.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CourseCode].ToString().Trim(), //课程代码
CourseName = objRow[convCourseLearningCaseRelaInfo.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CourseName].ToString().Trim(), //课程名称
BrowseCount = objRow[convCourseLearningCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCaseRelaInfo.BrowseCount].ToString().Trim()), //浏览次数
ResourceOwner = objRow[convCourseLearningCaseRelaInfo.ResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ResourceOwner].ToString().Trim(), //上传者
ftpFileType = objRow[convCourseLearningCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ftpFileType].ToString().Trim(), //ftp文件类型
ftpFileSize = objRow[convCourseLearningCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ftpFileSize].ToString().Trim(), //ftp文件大小
ftpResourceOwner = objRow[convCourseLearningCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ftpResourceOwner].ToString().Trim(), //Ftp资源拥有者
FileOriginName = objRow[convCourseLearningCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileOriginName].ToString().Trim(), //原文件名
IsExistFile = TransNullToBool(objRow[convCourseLearningCaseRelaInfo.IsExistFile].ToString().Trim()), //是否存在文件
Flag = objRow[convCourseLearningCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.Flag].ToString().Trim(), //标志
FileNewName = objRow[convCourseLearningCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileNewName].ToString().Trim(), //新文件名
FileOldName = objRow[convCourseLearningCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileOldName].ToString().Trim(), //旧文件名
IsVisible = TransNullToBool(objRow[convCourseLearningCaseRelaInfo.IsVisible].ToString().Trim()), //是否显示
UpdDate = objRow[convCourseLearningCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convCourseLearningCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convCourseLearningCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.Memo].ToString().Trim() //备注
};
objvCourseLearningCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCourseLearningCaseRelaInfoEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvCourseLearningCaseRelaInfoDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvCourseLearningCaseRelaInfoEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN = new clsvCourseLearningCaseRelaInfoEN();
try
{
objvCourseLearningCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = TransNullToInt(objRow[convCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvCourseLearningCaseRelaInfoEN.FuncModuleId = objRow[convCourseLearningCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningCaseRelaInfoEN.FuncModuleName = objRow[convCourseLearningCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningCaseRelaInfoEN.IdCourseLearningCase = objRow[convCourseLearningCaseRelaInfo.IdCourseLearningCase] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCaseRelaInfoEN.IdMicroteachCase = objRow[convCourseLearningCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCourseLearningCaseRelaInfoEN.CourseLearningCaseName = objRow[convCourseLearningCaseRelaInfo.CourseLearningCaseName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfoType] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvCourseLearningCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objvCourseLearningCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvCourseLearningCaseRelaInfoEN.IdFile = objRow[convCourseLearningCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvCourseLearningCaseRelaInfoEN.FileName = objRow[convCourseLearningCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvCourseLearningCaseRelaInfoEN.FileType = objRow[convCourseLearningCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvCourseLearningCaseRelaInfoEN.SaveDate = objRow[convCourseLearningCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvCourseLearningCaseRelaInfoEN.FileSize = objRow[convCourseLearningCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvCourseLearningCaseRelaInfoEN.SaveTime = objRow[convCourseLearningCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvCourseLearningCaseRelaInfoEN.IdFtpResource = objRow[convCourseLearningCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvCourseLearningCaseRelaInfoEN.FtpResourceID = objRow[convCourseLearningCaseRelaInfo.FtpResourceID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvCourseLearningCaseRelaInfoEN.FileOriginalName = objRow[convCourseLearningCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvCourseLearningCaseRelaInfoEN.FileDirName = objRow[convCourseLearningCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvCourseLearningCaseRelaInfoEN.FileRename = objRow[convCourseLearningCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvCourseLearningCaseRelaInfoEN.FileUpDate = objRow[convCourseLearningCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvCourseLearningCaseRelaInfoEN.FileUpTime = objRow[convCourseLearningCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvCourseLearningCaseRelaInfoEN.IdResource = objRow[convCourseLearningCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvCourseLearningCaseRelaInfoEN.ResourceID = objRow[convCourseLearningCaseRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvCourseLearningCaseRelaInfoEN.SaveMode = TransNullToBool(objRow[convCourseLearningCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvCourseLearningCaseRelaInfoEN.IdResourceType = objRow[convCourseLearningCaseRelaInfo.IdResourceType] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvCourseLearningCaseRelaInfoEN.ResourceTypeID = objRow[convCourseLearningCaseRelaInfo.ResourceTypeID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvCourseLearningCaseRelaInfoEN.ResourceTypeName = objRow[convCourseLearningCaseRelaInfo.ResourceTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvCourseLearningCaseRelaInfoEN.MajorID = objRow[convCourseLearningCaseRelaInfo.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCaseRelaInfoEN.MajorName = objRow[convCourseLearningCaseRelaInfo.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCaseRelaInfoEN.IdXzCollege = objRow[convCourseLearningCaseRelaInfo.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCaseRelaInfoEN.CollegeID = objRow[convCourseLearningCaseRelaInfo.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CollegeID].ToString().Trim(); //学院ID
objvCourseLearningCaseRelaInfoEN.CollegeName = objRow[convCourseLearningCaseRelaInfo.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCaseRelaInfoEN.CourseId = objRow[convCourseLearningCaseRelaInfo.CourseId] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCaseRelaInfoEN.CourseCode = objRow[convCourseLearningCaseRelaInfo.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCaseRelaInfoEN.CourseName = objRow[convCourseLearningCaseRelaInfo.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCaseRelaInfoEN.BrowseCount = objRow[convCourseLearningCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvCourseLearningCaseRelaInfoEN.ResourceOwner = objRow[convCourseLearningCaseRelaInfo.ResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvCourseLearningCaseRelaInfoEN.ftpFileType = objRow[convCourseLearningCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvCourseLearningCaseRelaInfoEN.ftpFileSize = objRow[convCourseLearningCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvCourseLearningCaseRelaInfoEN.ftpResourceOwner = objRow[convCourseLearningCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvCourseLearningCaseRelaInfoEN.FileOriginName = objRow[convCourseLearningCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvCourseLearningCaseRelaInfoEN.IsExistFile = TransNullToBool(objRow[convCourseLearningCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvCourseLearningCaseRelaInfoEN.Flag = objRow[convCourseLearningCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.Flag].ToString().Trim(); //标志
objvCourseLearningCaseRelaInfoEN.FileNewName = objRow[convCourseLearningCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvCourseLearningCaseRelaInfoEN.FileOldName = objRow[convCourseLearningCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvCourseLearningCaseRelaInfoEN.IsVisible = TransNullToBool(objRow[convCourseLearningCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvCourseLearningCaseRelaInfoEN.UpdDate = objRow[convCourseLearningCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvCourseLearningCaseRelaInfoEN.UpdUser = objRow[convCourseLearningCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objvCourseLearningCaseRelaInfoEN.Memo = objRow[convCourseLearningCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvCourseLearningCaseRelaInfoDA: GetObjByDataRowvCourseLearningCaseRelaInfo)", objException.Message));
}
objvCourseLearningCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCourseLearningCaseRelaInfoEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvCourseLearningCaseRelaInfoEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN = new clsvCourseLearningCaseRelaInfoEN();
try
{
objvCourseLearningCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = TransNullToInt(objRow[convCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvCourseLearningCaseRelaInfoEN.FuncModuleId = objRow[convCourseLearningCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningCaseRelaInfoEN.FuncModuleName = objRow[convCourseLearningCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningCaseRelaInfoEN.IdCourseLearningCase = objRow[convCourseLearningCaseRelaInfo.IdCourseLearningCase] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCaseRelaInfoEN.IdMicroteachCase = objRow[convCourseLearningCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCourseLearningCaseRelaInfoEN.CourseLearningCaseName = objRow[convCourseLearningCaseRelaInfo.CourseLearningCaseName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfoType] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvCourseLearningCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objvCourseLearningCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvCourseLearningCaseRelaInfoEN.IdFile = objRow[convCourseLearningCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvCourseLearningCaseRelaInfoEN.FileName = objRow[convCourseLearningCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvCourseLearningCaseRelaInfoEN.FileType = objRow[convCourseLearningCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvCourseLearningCaseRelaInfoEN.SaveDate = objRow[convCourseLearningCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvCourseLearningCaseRelaInfoEN.FileSize = objRow[convCourseLearningCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvCourseLearningCaseRelaInfoEN.SaveTime = objRow[convCourseLearningCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvCourseLearningCaseRelaInfoEN.IdFtpResource = objRow[convCourseLearningCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvCourseLearningCaseRelaInfoEN.FtpResourceID = objRow[convCourseLearningCaseRelaInfo.FtpResourceID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvCourseLearningCaseRelaInfoEN.FileOriginalName = objRow[convCourseLearningCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvCourseLearningCaseRelaInfoEN.FileDirName = objRow[convCourseLearningCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvCourseLearningCaseRelaInfoEN.FileRename = objRow[convCourseLearningCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvCourseLearningCaseRelaInfoEN.FileUpDate = objRow[convCourseLearningCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvCourseLearningCaseRelaInfoEN.FileUpTime = objRow[convCourseLearningCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvCourseLearningCaseRelaInfoEN.IdResource = objRow[convCourseLearningCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvCourseLearningCaseRelaInfoEN.ResourceID = objRow[convCourseLearningCaseRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvCourseLearningCaseRelaInfoEN.SaveMode = TransNullToBool(objRow[convCourseLearningCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvCourseLearningCaseRelaInfoEN.IdResourceType = objRow[convCourseLearningCaseRelaInfo.IdResourceType] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvCourseLearningCaseRelaInfoEN.ResourceTypeID = objRow[convCourseLearningCaseRelaInfo.ResourceTypeID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvCourseLearningCaseRelaInfoEN.ResourceTypeName = objRow[convCourseLearningCaseRelaInfo.ResourceTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvCourseLearningCaseRelaInfoEN.MajorID = objRow[convCourseLearningCaseRelaInfo.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCaseRelaInfoEN.MajorName = objRow[convCourseLearningCaseRelaInfo.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCaseRelaInfoEN.IdXzCollege = objRow[convCourseLearningCaseRelaInfo.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCaseRelaInfoEN.CollegeID = objRow[convCourseLearningCaseRelaInfo.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CollegeID].ToString().Trim(); //学院ID
objvCourseLearningCaseRelaInfoEN.CollegeName = objRow[convCourseLearningCaseRelaInfo.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCaseRelaInfoEN.CourseId = objRow[convCourseLearningCaseRelaInfo.CourseId] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCaseRelaInfoEN.CourseCode = objRow[convCourseLearningCaseRelaInfo.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCaseRelaInfoEN.CourseName = objRow[convCourseLearningCaseRelaInfo.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCaseRelaInfoEN.BrowseCount = objRow[convCourseLearningCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvCourseLearningCaseRelaInfoEN.ResourceOwner = objRow[convCourseLearningCaseRelaInfo.ResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvCourseLearningCaseRelaInfoEN.ftpFileType = objRow[convCourseLearningCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvCourseLearningCaseRelaInfoEN.ftpFileSize = objRow[convCourseLearningCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvCourseLearningCaseRelaInfoEN.ftpResourceOwner = objRow[convCourseLearningCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvCourseLearningCaseRelaInfoEN.FileOriginName = objRow[convCourseLearningCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvCourseLearningCaseRelaInfoEN.IsExistFile = TransNullToBool(objRow[convCourseLearningCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvCourseLearningCaseRelaInfoEN.Flag = objRow[convCourseLearningCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.Flag].ToString().Trim(); //标志
objvCourseLearningCaseRelaInfoEN.FileNewName = objRow[convCourseLearningCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvCourseLearningCaseRelaInfoEN.FileOldName = objRow[convCourseLearningCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvCourseLearningCaseRelaInfoEN.IsVisible = TransNullToBool(objRow[convCourseLearningCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvCourseLearningCaseRelaInfoEN.UpdDate = objRow[convCourseLearningCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvCourseLearningCaseRelaInfoEN.UpdUser = objRow[convCourseLearningCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objvCourseLearningCaseRelaInfoEN.Memo = objRow[convCourseLearningCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvCourseLearningCaseRelaInfoDA: GetObjByDataRow)", objException.Message));
}
objvCourseLearningCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCourseLearningCaseRelaInfoEN;
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
objSQL = clsvCourseLearningCaseRelaInfoDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCourseLearningCaseRelaInfoEN._CurrTabName, convCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfo, 8, "");
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
objSQL = clsvCourseLearningCaseRelaInfoDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCourseLearningCaseRelaInfoEN._CurrTabName, convCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfo, 8, strPrefix);
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
 objSQL = clsvCourseLearningCaseRelaInfoDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdMicroTeachCaseRelaInfo from vCourseLearningCaseRelaInfo where " + strCondition;
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
 objSQL = clsvCourseLearningCaseRelaInfoDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdMicroTeachCaseRelaInfo from vCourseLearningCaseRelaInfo where " + strCondition;
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
 /// <param name = "lngIdMicroTeachCaseRelaInfo">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngIdMicroTeachCaseRelaInfo)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCaseRelaInfoDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCourseLearningCaseRelaInfo", "IdMicroTeachCaseRelaInfo = " + ""+ lngIdMicroTeachCaseRelaInfo+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvCourseLearningCaseRelaInfoDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCaseRelaInfoDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCourseLearningCaseRelaInfo", strCondition))
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
objSQL = clsvCourseLearningCaseRelaInfoDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vCourseLearningCaseRelaInfo");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoENS">源对象</param>
 /// <param name = "objvCourseLearningCaseRelaInfoENT">目标对象</param>
public void CopyTo(clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoENS, clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoENT)
{
objvCourseLearningCaseRelaInfoENT.IdMicroTeachCaseRelaInfo = objvCourseLearningCaseRelaInfoENS.IdMicroTeachCaseRelaInfo; //案例相关信息流水号
objvCourseLearningCaseRelaInfoENT.FuncModuleId = objvCourseLearningCaseRelaInfoENS.FuncModuleId; //功能模块Id
objvCourseLearningCaseRelaInfoENT.FuncModuleName = objvCourseLearningCaseRelaInfoENS.FuncModuleName; //功能模块名称
objvCourseLearningCaseRelaInfoENT.IdCourseLearningCase = objvCourseLearningCaseRelaInfoENS.IdCourseLearningCase; //课程学习案例流水号
objvCourseLearningCaseRelaInfoENT.IdMicroteachCase = objvCourseLearningCaseRelaInfoENS.IdMicroteachCase; //微格教学案例流水号
objvCourseLearningCaseRelaInfoENT.CourseLearningCaseName = objvCourseLearningCaseRelaInfoENS.CourseLearningCaseName; //课程学习案例名称
objvCourseLearningCaseRelaInfoENT.IdMicroTeachCaseRelaInfoType = objvCourseLearningCaseRelaInfoENS.IdMicroTeachCaseRelaInfoType; //微格案例相关信息类型流水号
objvCourseLearningCaseRelaInfoENT.MicroTeachCaseRelaInfoTypeID = objvCourseLearningCaseRelaInfoENS.MicroTeachCaseRelaInfoTypeID; //微格案例相关信息类型ID
objvCourseLearningCaseRelaInfoENT.MicroTeachCaseRelaInfoTypeName = objvCourseLearningCaseRelaInfoENS.MicroTeachCaseRelaInfoTypeName; //微格案例相关信息类型名称
objvCourseLearningCaseRelaInfoENT.IdFile = objvCourseLearningCaseRelaInfoENS.IdFile; //文件流水号
objvCourseLearningCaseRelaInfoENT.FileName = objvCourseLearningCaseRelaInfoENS.FileName; //文件名称
objvCourseLearningCaseRelaInfoENT.FileType = objvCourseLearningCaseRelaInfoENS.FileType; //文件类型
objvCourseLearningCaseRelaInfoENT.SaveDate = objvCourseLearningCaseRelaInfoENS.SaveDate; //创建日期
objvCourseLearningCaseRelaInfoENT.FileSize = objvCourseLearningCaseRelaInfoENS.FileSize; //文件大小
objvCourseLearningCaseRelaInfoENT.SaveTime = objvCourseLearningCaseRelaInfoENS.SaveTime; //创建时间
objvCourseLearningCaseRelaInfoENT.IdFtpResource = objvCourseLearningCaseRelaInfoENS.IdFtpResource; //FTP资源流水号
objvCourseLearningCaseRelaInfoENT.FtpResourceID = objvCourseLearningCaseRelaInfoENS.FtpResourceID; //FTP资源ID
objvCourseLearningCaseRelaInfoENT.FileOriginalName = objvCourseLearningCaseRelaInfoENS.FileOriginalName; //文件原名
objvCourseLearningCaseRelaInfoENT.FileDirName = objvCourseLearningCaseRelaInfoENS.FileDirName; //文件目录名
objvCourseLearningCaseRelaInfoENT.FileRename = objvCourseLearningCaseRelaInfoENS.FileRename; //文件新名
objvCourseLearningCaseRelaInfoENT.FileUpDate = objvCourseLearningCaseRelaInfoENS.FileUpDate; //创建日期
objvCourseLearningCaseRelaInfoENT.FileUpTime = objvCourseLearningCaseRelaInfoENS.FileUpTime; //创建时间
objvCourseLearningCaseRelaInfoENT.IdResource = objvCourseLearningCaseRelaInfoENS.IdResource; //资源流水号
objvCourseLearningCaseRelaInfoENT.ResourceID = objvCourseLearningCaseRelaInfoENS.ResourceID; //资源ID
objvCourseLearningCaseRelaInfoENT.SaveMode = objvCourseLearningCaseRelaInfoENS.SaveMode; //文件存放方式
objvCourseLearningCaseRelaInfoENT.IdResourceType = objvCourseLearningCaseRelaInfoENS.IdResourceType; //资源类型流水号
objvCourseLearningCaseRelaInfoENT.ResourceTypeID = objvCourseLearningCaseRelaInfoENS.ResourceTypeID; //资源类型ID
objvCourseLearningCaseRelaInfoENT.ResourceTypeName = objvCourseLearningCaseRelaInfoENS.ResourceTypeName; //资源类型名称
objvCourseLearningCaseRelaInfoENT.MajorID = objvCourseLearningCaseRelaInfoENS.MajorID; //专业ID
objvCourseLearningCaseRelaInfoENT.MajorName = objvCourseLearningCaseRelaInfoENS.MajorName; //专业名称
objvCourseLearningCaseRelaInfoENT.IdXzCollege = objvCourseLearningCaseRelaInfoENS.IdXzCollege; //学院流水号
objvCourseLearningCaseRelaInfoENT.CollegeID = objvCourseLearningCaseRelaInfoENS.CollegeID; //学院ID
objvCourseLearningCaseRelaInfoENT.CollegeName = objvCourseLearningCaseRelaInfoENS.CollegeName; //学院名称
objvCourseLearningCaseRelaInfoENT.CourseId = objvCourseLearningCaseRelaInfoENS.CourseId; //课程Id
objvCourseLearningCaseRelaInfoENT.CourseCode = objvCourseLearningCaseRelaInfoENS.CourseCode; //课程代码
objvCourseLearningCaseRelaInfoENT.CourseName = objvCourseLearningCaseRelaInfoENS.CourseName; //课程名称
objvCourseLearningCaseRelaInfoENT.BrowseCount = objvCourseLearningCaseRelaInfoENS.BrowseCount; //浏览次数
objvCourseLearningCaseRelaInfoENT.ResourceOwner = objvCourseLearningCaseRelaInfoENS.ResourceOwner; //上传者
objvCourseLearningCaseRelaInfoENT.ftpFileType = objvCourseLearningCaseRelaInfoENS.ftpFileType; //ftp文件类型
objvCourseLearningCaseRelaInfoENT.ftpFileSize = objvCourseLearningCaseRelaInfoENS.ftpFileSize; //ftp文件大小
objvCourseLearningCaseRelaInfoENT.ftpResourceOwner = objvCourseLearningCaseRelaInfoENS.ftpResourceOwner; //Ftp资源拥有者
objvCourseLearningCaseRelaInfoENT.FileOriginName = objvCourseLearningCaseRelaInfoENS.FileOriginName; //原文件名
objvCourseLearningCaseRelaInfoENT.IsExistFile = objvCourseLearningCaseRelaInfoENS.IsExistFile; //是否存在文件
objvCourseLearningCaseRelaInfoENT.Flag = objvCourseLearningCaseRelaInfoENS.Flag; //标志
objvCourseLearningCaseRelaInfoENT.FileNewName = objvCourseLearningCaseRelaInfoENS.FileNewName; //新文件名
objvCourseLearningCaseRelaInfoENT.FileOldName = objvCourseLearningCaseRelaInfoENS.FileOldName; //旧文件名
objvCourseLearningCaseRelaInfoENT.IsVisible = objvCourseLearningCaseRelaInfoENS.IsVisible; //是否显示
objvCourseLearningCaseRelaInfoENT.UpdDate = objvCourseLearningCaseRelaInfoENS.UpdDate; //修改日期
objvCourseLearningCaseRelaInfoENT.UpdUser = objvCourseLearningCaseRelaInfoENS.UpdUser; //修改人
objvCourseLearningCaseRelaInfoENT.Memo = objvCourseLearningCaseRelaInfoENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvCourseLearningCaseRelaInfoEN.FuncModuleId, 4, convCourseLearningCaseRelaInfo.FuncModuleId);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseRelaInfoEN.FuncModuleName, 30, convCourseLearningCaseRelaInfo.FuncModuleName);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseRelaInfoEN.IdCourseLearningCase, 8, convCourseLearningCaseRelaInfo.IdCourseLearningCase);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseRelaInfoEN.IdMicroteachCase, 8, convCourseLearningCaseRelaInfo.IdMicroteachCase);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseRelaInfoEN.CourseLearningCaseName, 100, convCourseLearningCaseRelaInfo.CourseLearningCaseName);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType, 4, convCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfoType);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID, 4, convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeID);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName, 50, convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeName);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseRelaInfoEN.IdFile, 8, convCourseLearningCaseRelaInfo.IdFile);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseRelaInfoEN.FileName, 500, convCourseLearningCaseRelaInfo.FileName);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseRelaInfoEN.FileType, 30, convCourseLearningCaseRelaInfo.FileType);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseRelaInfoEN.SaveDate, 8, convCourseLearningCaseRelaInfo.SaveDate);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseRelaInfoEN.FileSize, 50, convCourseLearningCaseRelaInfo.FileSize);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseRelaInfoEN.SaveTime, 6, convCourseLearningCaseRelaInfo.SaveTime);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseRelaInfoEN.IdFtpResource, 8, convCourseLearningCaseRelaInfo.IdFtpResource);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseRelaInfoEN.FtpResourceID, 8, convCourseLearningCaseRelaInfo.FtpResourceID);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseRelaInfoEN.FileOriginalName, 200, convCourseLearningCaseRelaInfo.FileOriginalName);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseRelaInfoEN.FileDirName, 200, convCourseLearningCaseRelaInfo.FileDirName);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseRelaInfoEN.FileRename, 200, convCourseLearningCaseRelaInfo.FileRename);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseRelaInfoEN.FileUpDate, 8, convCourseLearningCaseRelaInfo.FileUpDate);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseRelaInfoEN.FileUpTime, 6, convCourseLearningCaseRelaInfo.FileUpTime);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseRelaInfoEN.IdResource, 8, convCourseLearningCaseRelaInfo.IdResource);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseRelaInfoEN.ResourceID, 8, convCourseLearningCaseRelaInfo.ResourceID);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseRelaInfoEN.IdResourceType, 4, convCourseLearningCaseRelaInfo.IdResourceType);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseRelaInfoEN.ResourceTypeID, 4, convCourseLearningCaseRelaInfo.ResourceTypeID);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseRelaInfoEN.ResourceTypeName, 50, convCourseLearningCaseRelaInfo.ResourceTypeName);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseRelaInfoEN.MajorID, 4, convCourseLearningCaseRelaInfo.MajorID);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseRelaInfoEN.MajorName, 100, convCourseLearningCaseRelaInfo.MajorName);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseRelaInfoEN.IdXzCollege, 4, convCourseLearningCaseRelaInfo.IdXzCollege);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseRelaInfoEN.CollegeID, 4, convCourseLearningCaseRelaInfo.CollegeID);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseRelaInfoEN.CollegeName, 100, convCourseLearningCaseRelaInfo.CollegeName);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseRelaInfoEN.CourseId, 8, convCourseLearningCaseRelaInfo.CourseId);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseRelaInfoEN.CourseCode, 20, convCourseLearningCaseRelaInfo.CourseCode);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseRelaInfoEN.CourseName, 100, convCourseLearningCaseRelaInfo.CourseName);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseRelaInfoEN.ResourceOwner, 50, convCourseLearningCaseRelaInfo.ResourceOwner);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseRelaInfoEN.ftpFileType, 30, convCourseLearningCaseRelaInfo.ftpFileType);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseRelaInfoEN.ftpFileSize, 50, convCourseLearningCaseRelaInfo.ftpFileSize);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseRelaInfoEN.ftpResourceOwner, 50, convCourseLearningCaseRelaInfo.ftpResourceOwner);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseRelaInfoEN.FileOriginName, 500, convCourseLearningCaseRelaInfo.FileOriginName);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseRelaInfoEN.Flag, 50, convCourseLearningCaseRelaInfo.Flag);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseRelaInfoEN.FileNewName, 530, convCourseLearningCaseRelaInfo.FileNewName);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseRelaInfoEN.FileOldName, 530, convCourseLearningCaseRelaInfo.FileOldName);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseRelaInfoEN.UpdDate, 20, convCourseLearningCaseRelaInfo.UpdDate);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseRelaInfoEN.UpdUser, 20, convCourseLearningCaseRelaInfo.UpdUser);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseRelaInfoEN.Memo, 1000, convCourseLearningCaseRelaInfo.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseRelaInfoEN.FuncModuleId, convCourseLearningCaseRelaInfo.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseRelaInfoEN.FuncModuleName, convCourseLearningCaseRelaInfo.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseRelaInfoEN.IdCourseLearningCase, convCourseLearningCaseRelaInfo.IdCourseLearningCase);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseRelaInfoEN.IdMicroteachCase, convCourseLearningCaseRelaInfo.IdMicroteachCase);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseRelaInfoEN.CourseLearningCaseName, convCourseLearningCaseRelaInfo.CourseLearningCaseName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType, convCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfoType);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID, convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeID);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName, convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseRelaInfoEN.IdFile, convCourseLearningCaseRelaInfo.IdFile);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseRelaInfoEN.FileName, convCourseLearningCaseRelaInfo.FileName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseRelaInfoEN.FileType, convCourseLearningCaseRelaInfo.FileType);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseRelaInfoEN.SaveDate, convCourseLearningCaseRelaInfo.SaveDate);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseRelaInfoEN.FileSize, convCourseLearningCaseRelaInfo.FileSize);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseRelaInfoEN.SaveTime, convCourseLearningCaseRelaInfo.SaveTime);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseRelaInfoEN.IdFtpResource, convCourseLearningCaseRelaInfo.IdFtpResource);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseRelaInfoEN.FtpResourceID, convCourseLearningCaseRelaInfo.FtpResourceID);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseRelaInfoEN.FileOriginalName, convCourseLearningCaseRelaInfo.FileOriginalName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseRelaInfoEN.FileDirName, convCourseLearningCaseRelaInfo.FileDirName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseRelaInfoEN.FileRename, convCourseLearningCaseRelaInfo.FileRename);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseRelaInfoEN.FileUpDate, convCourseLearningCaseRelaInfo.FileUpDate);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseRelaInfoEN.FileUpTime, convCourseLearningCaseRelaInfo.FileUpTime);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseRelaInfoEN.IdResource, convCourseLearningCaseRelaInfo.IdResource);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseRelaInfoEN.ResourceID, convCourseLearningCaseRelaInfo.ResourceID);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseRelaInfoEN.IdResourceType, convCourseLearningCaseRelaInfo.IdResourceType);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseRelaInfoEN.ResourceTypeID, convCourseLearningCaseRelaInfo.ResourceTypeID);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseRelaInfoEN.ResourceTypeName, convCourseLearningCaseRelaInfo.ResourceTypeName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseRelaInfoEN.MajorID, convCourseLearningCaseRelaInfo.MajorID);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseRelaInfoEN.MajorName, convCourseLearningCaseRelaInfo.MajorName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseRelaInfoEN.IdXzCollege, convCourseLearningCaseRelaInfo.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseRelaInfoEN.CollegeID, convCourseLearningCaseRelaInfo.CollegeID);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseRelaInfoEN.CollegeName, convCourseLearningCaseRelaInfo.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseRelaInfoEN.CourseId, convCourseLearningCaseRelaInfo.CourseId);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseRelaInfoEN.CourseCode, convCourseLearningCaseRelaInfo.CourseCode);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseRelaInfoEN.CourseName, convCourseLearningCaseRelaInfo.CourseName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseRelaInfoEN.ResourceOwner, convCourseLearningCaseRelaInfo.ResourceOwner);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseRelaInfoEN.ftpFileType, convCourseLearningCaseRelaInfo.ftpFileType);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseRelaInfoEN.ftpFileSize, convCourseLearningCaseRelaInfo.ftpFileSize);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseRelaInfoEN.ftpResourceOwner, convCourseLearningCaseRelaInfo.ftpResourceOwner);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseRelaInfoEN.FileOriginName, convCourseLearningCaseRelaInfo.FileOriginName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseRelaInfoEN.Flag, convCourseLearningCaseRelaInfo.Flag);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseRelaInfoEN.FileNewName, convCourseLearningCaseRelaInfo.FileNewName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseRelaInfoEN.FileOldName, convCourseLearningCaseRelaInfo.FileOldName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseRelaInfoEN.UpdDate, convCourseLearningCaseRelaInfo.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseRelaInfoEN.UpdUser, convCourseLearningCaseRelaInfo.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseRelaInfoEN.Memo, convCourseLearningCaseRelaInfo.Memo);
//检查外键字段长度
 objvCourseLearningCaseRelaInfoEN._IsCheckProperty = true;
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
 objSQL = clsvCourseLearningCaseRelaInfoDA.GetSpecSQLObj();
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
 objSQL = clsvCourseLearningCaseRelaInfoDA.GetSpecSQLObj();
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
 objSQL = clsvCourseLearningCaseRelaInfoDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCourseLearningCaseRelaInfoEN._CurrTabName);
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
 objSQL = clsvCourseLearningCaseRelaInfoDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCourseLearningCaseRelaInfoEN._CurrTabName, strCondition);
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
 objSQL = clsvCourseLearningCaseRelaInfoDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}