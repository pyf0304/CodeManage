
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCoursewareCaseQuantitySenateDA
 表名:vCoursewareCaseQuantitySenate(01120454)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:46:10
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
 /// v课件量化评议(vCoursewareCaseQuantitySenate)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvCoursewareCaseQuantitySenateDA : clsCommBase4DA
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
 return clsvCoursewareCaseQuantitySenateEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvCoursewareCaseQuantitySenateEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCoursewareCaseQuantitySenateEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvCoursewareCaseQuantitySenateEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvCoursewareCaseQuantitySenateEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvCoursewareCaseQuantitySenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vCoursewareCaseQuantitySenate where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vCoursewareCaseQuantitySenate(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvCoursewareCaseQuantitySenateDA: GetDataTable_vCoursewareCaseQuantitySenate)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vCoursewareCaseQuantitySenate where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvCoursewareCaseQuantitySenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCaseQuantitySenateDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvCoursewareCaseQuantitySenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vCoursewareCaseQuantitySenate where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvCoursewareCaseQuantitySenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCaseQuantitySenateDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvCoursewareCaseQuantitySenateDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCaseQuantitySenateDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCoursewareCaseQuantitySenate where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCoursewareCaseQuantitySenate where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvCoursewareCaseQuantitySenateDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCaseQuantitySenateDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vCoursewareCaseQuantitySenate where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvCoursewareCaseQuantitySenateDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCaseQuantitySenateDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vCoursewareCaseQuantitySenate.* from vCoursewareCaseQuantitySenate Left Join {1} on {2} where {3} and vCoursewareCaseQuantitySenate.IdmicroteachCaseQuantitySenate not in (Select top {5} vCoursewareCaseQuantitySenate.IdmicroteachCaseQuantitySenate from vCoursewareCaseQuantitySenate Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCoursewareCaseQuantitySenate where {1} and IdmicroteachCaseQuantitySenate not in (Select top {2} IdmicroteachCaseQuantitySenate from vCoursewareCaseQuantitySenate where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCoursewareCaseQuantitySenate where {1} and IdmicroteachCaseQuantitySenate not in (Select top {3} IdmicroteachCaseQuantitySenate from vCoursewareCaseQuantitySenate where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvCoursewareCaseQuantitySenateDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCaseQuantitySenateDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vCoursewareCaseQuantitySenate.* from vCoursewareCaseQuantitySenate Left Join {1} on {2} where {3} and vCoursewareCaseQuantitySenate.IdmicroteachCaseQuantitySenate not in (Select top {5} vCoursewareCaseQuantitySenate.IdmicroteachCaseQuantitySenate from vCoursewareCaseQuantitySenate Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCoursewareCaseQuantitySenate where {1} and IdmicroteachCaseQuantitySenate not in (Select top {2} IdmicroteachCaseQuantitySenate from vCoursewareCaseQuantitySenate where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCoursewareCaseQuantitySenate where {1} and IdmicroteachCaseQuantitySenate not in (Select top {3} IdmicroteachCaseQuantitySenate from vCoursewareCaseQuantitySenate where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvCoursewareCaseQuantitySenateEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvCoursewareCaseQuantitySenateDA:GetObjLst)", objException.Message));
}
List<clsvCoursewareCaseQuantitySenateEN> arrObjLst = new List<clsvCoursewareCaseQuantitySenateEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vCoursewareCaseQuantitySenate where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCoursewareCaseQuantitySenateEN objvCoursewareCaseQuantitySenateEN = new clsvCoursewareCaseQuantitySenateEN();
try
{
objvCoursewareCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convCoursewareCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvCoursewareCaseQuantitySenateEN.UserId = objRow[convCoursewareCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvCoursewareCaseQuantitySenateEN.IdMicroteachCase = objRow[convCoursewareCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCoursewareCaseQuantitySenateEN.IdAppraiseType = objRow[convCoursewareCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvCoursewareCaseQuantitySenateEN.AppraiseTypeName = objRow[convCoursewareCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvCoursewareCaseQuantitySenateEN.CollegeID = objRow[convCoursewareCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvCoursewareCaseQuantitySenateEN.CollegeName = objRow[convCoursewareCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvCoursewareCaseQuantitySenateEN.BrowseCount = objRow[convCoursewareCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvCoursewareCaseQuantitySenateEN.SenateTheme = objRow[convCoursewareCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvCoursewareCaseQuantitySenateEN.SenateContent = objRow[convCoursewareCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvCoursewareCaseQuantitySenateEN.SenateTotalScore = TransNullToFloat(objRow[convCoursewareCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvCoursewareCaseQuantitySenateEN.SenateDate = objRow[convCoursewareCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvCoursewareCaseQuantitySenateEN.SenateTime = objRow[convCoursewareCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvCoursewareCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convCoursewareCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCoursewareCaseQuantitySenateEN.senateGaugeVersionID = objRow[convCoursewareCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCoursewareCaseQuantitySenateEN.senateGaugeVersionName = objRow[convCoursewareCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCoursewareCaseQuantitySenateEN.UpdUser = objRow[convCoursewareCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvCoursewareCaseQuantitySenateEN.UpdUserName = objRow[convCoursewareCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
objvCoursewareCaseQuantitySenateEN.FuncModuleName = objRow[convCoursewareCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvCoursewareCaseQuantitySenateEN.FuncModuleId = objRow[convCoursewareCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvCoursewareCaseQuantitySenateEN.UserTypeId = objRow[convCoursewareCaseQuantitySenate.UserTypeId] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.UserTypeId].ToString().Trim(); //用户类型Id
objvCoursewareCaseQuantitySenateEN.SenateIp = objRow[convCoursewareCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvCoursewareCaseQuantitySenateEN.UserTypeName = objRow[convCoursewareCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
objvCoursewareCaseQuantitySenateEN.UserName = objRow[convCoursewareCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvCoursewareCaseQuantitySenateEN.OwnerId = objRow[convCoursewareCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvCoursewareCaseQuantitySenateEN.OwnerName = objRow[convCoursewareCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvCoursewareCaseQuantitySenateEN.UserNameWithUserId = objRow[convCoursewareCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvCoursewareCaseQuantitySenateEN.IsDualVideo = TransNullToBool(objRow[convCoursewareCaseQuantitySenate.IsDualVideo].ToString().Trim()); //是否双视频
objvCoursewareCaseQuantitySenateEN.CoursewareCaseDate = objRow[convCoursewareCaseQuantitySenate.CoursewareCaseDate] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.CoursewareCaseDate].ToString().Trim(); //课件教学日期
objvCoursewareCaseQuantitySenateEN.CoursewareCaseDateIn = objRow[convCoursewareCaseQuantitySenate.CoursewareCaseDateIn] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.CoursewareCaseDateIn].ToString().Trim(); //案例入库日期
objvCoursewareCaseQuantitySenateEN.CoursewareCaseID = objRow[convCoursewareCaseQuantitySenate.CoursewareCaseID] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.CoursewareCaseID].ToString().Trim(); //课件教学案例ID
objvCoursewareCaseQuantitySenateEN.CoursewareCaseName = objRow[convCoursewareCaseQuantitySenate.CoursewareCaseName] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.CoursewareCaseName].ToString().Trim(); //课件教学案例名称
objvCoursewareCaseQuantitySenateEN.CoursewareCaseTheme = objRow[convCoursewareCaseQuantitySenate.CoursewareCaseTheme] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.CoursewareCaseTheme].ToString().Trim(); //课件教学案例主题词
objvCoursewareCaseQuantitySenateEN.CoursewareCaseTime = objRow[convCoursewareCaseQuantitySenate.CoursewareCaseTime] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.CoursewareCaseTime].ToString().Trim(); //课件教学时间
objvCoursewareCaseQuantitySenateEN.CoursewareCaseTimeIn = objRow[convCoursewareCaseQuantitySenate.CoursewareCaseTimeIn] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.CoursewareCaseTimeIn].ToString().Trim(); //案例入库时间
objvCoursewareCaseQuantitySenateEN.IdCoursewareCase = objRow[convCoursewareCaseQuantitySenate.IdCoursewareCase] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.IdCoursewareCase].ToString().Trim(); //课件教学案例流水号
objvCoursewareCaseQuantitySenateEN.IdCoursewareCaseType = objRow[convCoursewareCaseQuantitySenate.IdCoursewareCaseType] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.IdCoursewareCaseType].ToString().Trim(); //课件案例类型流水号
objvCoursewareCaseQuantitySenateEN.CoursewareCaseTypeName = objRow[convCoursewareCaseQuantitySenate.CoursewareCaseTypeName] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.CoursewareCaseTypeName].ToString().Trim(); //课件案例类型名称
objvCoursewareCaseQuantitySenateEN.UserKindId = objRow[convCoursewareCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvCoursewareCaseQuantitySenateEN.UserKindName = objRow[convCoursewareCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvCoursewareCaseQuantitySenateEN.Memo = objRow[convCoursewareCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.Memo].ToString().Trim(); //备注
objvCoursewareCaseQuantitySenateEN.OwnerNameWithId = objRow[convCoursewareCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCoursewareCaseQuantitySenateEN.IdXzCollege = objRow[convCoursewareCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvCoursewareCaseQuantitySenateEN.CollegeNameA = objRow[convCoursewareCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCoursewareCaseQuantitySenateDA: GetObjLst)", objException.Message));
}
objvCoursewareCaseQuantitySenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCoursewareCaseQuantitySenateEN);
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
public List<clsvCoursewareCaseQuantitySenateEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvCoursewareCaseQuantitySenateDA:GetObjLstByTabName)", objException.Message));
}
List<clsvCoursewareCaseQuantitySenateEN> arrObjLst = new List<clsvCoursewareCaseQuantitySenateEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCoursewareCaseQuantitySenateEN objvCoursewareCaseQuantitySenateEN = new clsvCoursewareCaseQuantitySenateEN();
try
{
objvCoursewareCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convCoursewareCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvCoursewareCaseQuantitySenateEN.UserId = objRow[convCoursewareCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvCoursewareCaseQuantitySenateEN.IdMicroteachCase = objRow[convCoursewareCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCoursewareCaseQuantitySenateEN.IdAppraiseType = objRow[convCoursewareCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvCoursewareCaseQuantitySenateEN.AppraiseTypeName = objRow[convCoursewareCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvCoursewareCaseQuantitySenateEN.CollegeID = objRow[convCoursewareCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvCoursewareCaseQuantitySenateEN.CollegeName = objRow[convCoursewareCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvCoursewareCaseQuantitySenateEN.BrowseCount = objRow[convCoursewareCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvCoursewareCaseQuantitySenateEN.SenateTheme = objRow[convCoursewareCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvCoursewareCaseQuantitySenateEN.SenateContent = objRow[convCoursewareCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvCoursewareCaseQuantitySenateEN.SenateTotalScore = TransNullToFloat(objRow[convCoursewareCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvCoursewareCaseQuantitySenateEN.SenateDate = objRow[convCoursewareCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvCoursewareCaseQuantitySenateEN.SenateTime = objRow[convCoursewareCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvCoursewareCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convCoursewareCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCoursewareCaseQuantitySenateEN.senateGaugeVersionID = objRow[convCoursewareCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCoursewareCaseQuantitySenateEN.senateGaugeVersionName = objRow[convCoursewareCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCoursewareCaseQuantitySenateEN.UpdUser = objRow[convCoursewareCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvCoursewareCaseQuantitySenateEN.UpdUserName = objRow[convCoursewareCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
objvCoursewareCaseQuantitySenateEN.FuncModuleName = objRow[convCoursewareCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvCoursewareCaseQuantitySenateEN.FuncModuleId = objRow[convCoursewareCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvCoursewareCaseQuantitySenateEN.UserTypeId = objRow[convCoursewareCaseQuantitySenate.UserTypeId] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.UserTypeId].ToString().Trim(); //用户类型Id
objvCoursewareCaseQuantitySenateEN.SenateIp = objRow[convCoursewareCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvCoursewareCaseQuantitySenateEN.UserTypeName = objRow[convCoursewareCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
objvCoursewareCaseQuantitySenateEN.UserName = objRow[convCoursewareCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvCoursewareCaseQuantitySenateEN.OwnerId = objRow[convCoursewareCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvCoursewareCaseQuantitySenateEN.OwnerName = objRow[convCoursewareCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvCoursewareCaseQuantitySenateEN.UserNameWithUserId = objRow[convCoursewareCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvCoursewareCaseQuantitySenateEN.IsDualVideo = TransNullToBool(objRow[convCoursewareCaseQuantitySenate.IsDualVideo].ToString().Trim()); //是否双视频
objvCoursewareCaseQuantitySenateEN.CoursewareCaseDate = objRow[convCoursewareCaseQuantitySenate.CoursewareCaseDate] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.CoursewareCaseDate].ToString().Trim(); //课件教学日期
objvCoursewareCaseQuantitySenateEN.CoursewareCaseDateIn = objRow[convCoursewareCaseQuantitySenate.CoursewareCaseDateIn] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.CoursewareCaseDateIn].ToString().Trim(); //案例入库日期
objvCoursewareCaseQuantitySenateEN.CoursewareCaseID = objRow[convCoursewareCaseQuantitySenate.CoursewareCaseID] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.CoursewareCaseID].ToString().Trim(); //课件教学案例ID
objvCoursewareCaseQuantitySenateEN.CoursewareCaseName = objRow[convCoursewareCaseQuantitySenate.CoursewareCaseName] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.CoursewareCaseName].ToString().Trim(); //课件教学案例名称
objvCoursewareCaseQuantitySenateEN.CoursewareCaseTheme = objRow[convCoursewareCaseQuantitySenate.CoursewareCaseTheme] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.CoursewareCaseTheme].ToString().Trim(); //课件教学案例主题词
objvCoursewareCaseQuantitySenateEN.CoursewareCaseTime = objRow[convCoursewareCaseQuantitySenate.CoursewareCaseTime] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.CoursewareCaseTime].ToString().Trim(); //课件教学时间
objvCoursewareCaseQuantitySenateEN.CoursewareCaseTimeIn = objRow[convCoursewareCaseQuantitySenate.CoursewareCaseTimeIn] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.CoursewareCaseTimeIn].ToString().Trim(); //案例入库时间
objvCoursewareCaseQuantitySenateEN.IdCoursewareCase = objRow[convCoursewareCaseQuantitySenate.IdCoursewareCase] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.IdCoursewareCase].ToString().Trim(); //课件教学案例流水号
objvCoursewareCaseQuantitySenateEN.IdCoursewareCaseType = objRow[convCoursewareCaseQuantitySenate.IdCoursewareCaseType] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.IdCoursewareCaseType].ToString().Trim(); //课件案例类型流水号
objvCoursewareCaseQuantitySenateEN.CoursewareCaseTypeName = objRow[convCoursewareCaseQuantitySenate.CoursewareCaseTypeName] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.CoursewareCaseTypeName].ToString().Trim(); //课件案例类型名称
objvCoursewareCaseQuantitySenateEN.UserKindId = objRow[convCoursewareCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvCoursewareCaseQuantitySenateEN.UserKindName = objRow[convCoursewareCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvCoursewareCaseQuantitySenateEN.Memo = objRow[convCoursewareCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.Memo].ToString().Trim(); //备注
objvCoursewareCaseQuantitySenateEN.OwnerNameWithId = objRow[convCoursewareCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCoursewareCaseQuantitySenateEN.IdXzCollege = objRow[convCoursewareCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvCoursewareCaseQuantitySenateEN.CollegeNameA = objRow[convCoursewareCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCoursewareCaseQuantitySenateDA: GetObjLst)", objException.Message));
}
objvCoursewareCaseQuantitySenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCoursewareCaseQuantitySenateEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvCoursewareCaseQuantitySenateEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvCoursewareCaseQuantitySenate(ref clsvCoursewareCaseQuantitySenateEN objvCoursewareCaseQuantitySenateEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vCoursewareCaseQuantitySenate where IdmicroteachCaseQuantitySenate = " + ""+ objvCoursewareCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvCoursewareCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objDT.Rows[0][convCoursewareCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvCoursewareCaseQuantitySenateEN.UserId = objDT.Rows[0][convCoursewareCaseQuantitySenate.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvCoursewareCaseQuantitySenateEN.IdMicroteachCase = objDT.Rows[0][convCoursewareCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareCaseQuantitySenateEN.IdAppraiseType = objDT.Rows[0][convCoursewareCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareCaseQuantitySenateEN.AppraiseTypeName = objDT.Rows[0][convCoursewareCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareCaseQuantitySenateEN.CollegeID = objDT.Rows[0][convCoursewareCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvCoursewareCaseQuantitySenateEN.CollegeName = objDT.Rows[0][convCoursewareCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCoursewareCaseQuantitySenateEN.BrowseCount = TransNullToInt(objDT.Rows[0][convCoursewareCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvCoursewareCaseQuantitySenateEN.SenateTheme = objDT.Rows[0][convCoursewareCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareCaseQuantitySenateEN.SenateContent = objDT.Rows[0][convCoursewareCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvCoursewareCaseQuantitySenateEN.SenateTotalScore = TransNullToFloat(objDT.Rows[0][convCoursewareCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数(字段类型:float,字段长度:8,是否可空:False)
 objvCoursewareCaseQuantitySenateEN.SenateDate = objDT.Rows[0][convCoursewareCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareCaseQuantitySenateEN.SenateTime = objDT.Rows[0][convCoursewareCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间(字段类型:char,字段长度:6,是否可空:True)
 objvCoursewareCaseQuantitySenateEN.IdSenateGaugeVersion = objDT.Rows[0][convCoursewareCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareCaseQuantitySenateEN.senateGaugeVersionID = objDT.Rows[0][convCoursewareCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareCaseQuantitySenateEN.senateGaugeVersionName = objDT.Rows[0][convCoursewareCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareCaseQuantitySenateEN.UpdUser = objDT.Rows[0][convCoursewareCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvCoursewareCaseQuantitySenateEN.UpdUserName = objDT.Rows[0][convCoursewareCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName(字段类型:varchar,字段长度:20,是否可空:True)
 objvCoursewareCaseQuantitySenateEN.FuncModuleName = objDT.Rows[0][convCoursewareCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCoursewareCaseQuantitySenateEN.FuncModuleId = objDT.Rows[0][convCoursewareCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvCoursewareCaseQuantitySenateEN.UserTypeId = objDT.Rows[0][convCoursewareCaseQuantitySenate.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvCoursewareCaseQuantitySenateEN.SenateIp = objDT.Rows[0][convCoursewareCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip(字段类型:varchar,字段长度:50,是否可空:True)
 objvCoursewareCaseQuantitySenateEN.UserTypeName = objDT.Rows[0][convCoursewareCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称(字段类型:varchar,字段长度:20,是否可空:True)
 objvCoursewareCaseQuantitySenateEN.UserName = objDT.Rows[0][convCoursewareCaseQuantitySenate.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvCoursewareCaseQuantitySenateEN.OwnerId = objDT.Rows[0][convCoursewareCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvCoursewareCaseQuantitySenateEN.OwnerName = objDT.Rows[0][convCoursewareCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvCoursewareCaseQuantitySenateEN.UserNameWithUserId = objDT.Rows[0][convCoursewareCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId(字段类型:varchar,字段长度:51,是否可空:False)
 objvCoursewareCaseQuantitySenateEN.IsDualVideo = TransNullToBool(objDT.Rows[0][convCoursewareCaseQuantitySenate.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvCoursewareCaseQuantitySenateEN.CoursewareCaseDate = objDT.Rows[0][convCoursewareCaseQuantitySenate.CoursewareCaseDate].ToString().Trim(); //课件教学日期(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareCaseQuantitySenateEN.CoursewareCaseDateIn = objDT.Rows[0][convCoursewareCaseQuantitySenate.CoursewareCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareCaseQuantitySenateEN.CoursewareCaseID = objDT.Rows[0][convCoursewareCaseQuantitySenate.CoursewareCaseID].ToString().Trim(); //课件教学案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareCaseQuantitySenateEN.CoursewareCaseName = objDT.Rows[0][convCoursewareCaseQuantitySenate.CoursewareCaseName].ToString().Trim(); //课件教学案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCoursewareCaseQuantitySenateEN.CoursewareCaseTheme = objDT.Rows[0][convCoursewareCaseQuantitySenate.CoursewareCaseTheme].ToString().Trim(); //课件教学案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareCaseQuantitySenateEN.CoursewareCaseTime = objDT.Rows[0][convCoursewareCaseQuantitySenate.CoursewareCaseTime].ToString().Trim(); //课件教学时间(字段类型:char,字段长度:6,是否可空:True)
 objvCoursewareCaseQuantitySenateEN.CoursewareCaseTimeIn = objDT.Rows[0][convCoursewareCaseQuantitySenate.CoursewareCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvCoursewareCaseQuantitySenateEN.IdCoursewareCase = objDT.Rows[0][convCoursewareCaseQuantitySenate.IdCoursewareCase].ToString().Trim(); //课件教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareCaseQuantitySenateEN.IdCoursewareCaseType = objDT.Rows[0][convCoursewareCaseQuantitySenate.IdCoursewareCaseType].ToString().Trim(); //课件案例类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareCaseQuantitySenateEN.CoursewareCaseTypeName = objDT.Rows[0][convCoursewareCaseQuantitySenate.CoursewareCaseTypeName].ToString().Trim(); //课件案例类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareCaseQuantitySenateEN.UserKindId = objDT.Rows[0][convCoursewareCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id(字段类型:char,字段长度:2,是否可空:False)
 objvCoursewareCaseQuantitySenateEN.UserKindName = objDT.Rows[0][convCoursewareCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名(字段类型:varchar,字段长度:30,是否可空:False)
 objvCoursewareCaseQuantitySenateEN.Memo = objDT.Rows[0][convCoursewareCaseQuantitySenate.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCoursewareCaseQuantitySenateEN.OwnerNameWithId = objDT.Rows[0][convCoursewareCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
 objvCoursewareCaseQuantitySenateEN.IdXzCollege = objDT.Rows[0][convCoursewareCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvCoursewareCaseQuantitySenateEN.CollegeNameA = objDT.Rows[0][convCoursewareCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvCoursewareCaseQuantitySenateDA: GetvCoursewareCaseQuantitySenate)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdmicroteachCaseQuantitySenate">表关键字</param>
 /// <returns>表对象</returns>
public clsvCoursewareCaseQuantitySenateEN GetObjByIdmicroteachCaseQuantitySenate(long lngIdmicroteachCaseQuantitySenate)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vCoursewareCaseQuantitySenate where IdmicroteachCaseQuantitySenate = " + ""+ lngIdmicroteachCaseQuantitySenate+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvCoursewareCaseQuantitySenateEN objvCoursewareCaseQuantitySenateEN = new clsvCoursewareCaseQuantitySenateEN();
try
{
 objvCoursewareCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convCoursewareCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvCoursewareCaseQuantitySenateEN.UserId = objRow[convCoursewareCaseQuantitySenate.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvCoursewareCaseQuantitySenateEN.IdMicroteachCase = objRow[convCoursewareCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareCaseQuantitySenateEN.IdAppraiseType = objRow[convCoursewareCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareCaseQuantitySenateEN.AppraiseTypeName = objRow[convCoursewareCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareCaseQuantitySenateEN.CollegeID = objRow[convCoursewareCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvCoursewareCaseQuantitySenateEN.CollegeName = objRow[convCoursewareCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCoursewareCaseQuantitySenateEN.BrowseCount = objRow[convCoursewareCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCoursewareCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvCoursewareCaseQuantitySenateEN.SenateTheme = objRow[convCoursewareCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareCaseQuantitySenateEN.SenateContent = objRow[convCoursewareCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvCoursewareCaseQuantitySenateEN.SenateTotalScore = Single.Parse(objRow[convCoursewareCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数(字段类型:float,字段长度:8,是否可空:False)
 objvCoursewareCaseQuantitySenateEN.SenateDate = objRow[convCoursewareCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareCaseQuantitySenateEN.SenateTime = objRow[convCoursewareCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间(字段类型:char,字段长度:6,是否可空:True)
 objvCoursewareCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convCoursewareCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareCaseQuantitySenateEN.senateGaugeVersionID = objRow[convCoursewareCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareCaseQuantitySenateEN.senateGaugeVersionName = objRow[convCoursewareCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareCaseQuantitySenateEN.UpdUser = objRow[convCoursewareCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvCoursewareCaseQuantitySenateEN.UpdUserName = objRow[convCoursewareCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName(字段类型:varchar,字段长度:20,是否可空:True)
 objvCoursewareCaseQuantitySenateEN.FuncModuleName = objRow[convCoursewareCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCoursewareCaseQuantitySenateEN.FuncModuleId = objRow[convCoursewareCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvCoursewareCaseQuantitySenateEN.UserTypeId = objRow[convCoursewareCaseQuantitySenate.UserTypeId] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvCoursewareCaseQuantitySenateEN.SenateIp = objRow[convCoursewareCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip(字段类型:varchar,字段长度:50,是否可空:True)
 objvCoursewareCaseQuantitySenateEN.UserTypeName = objRow[convCoursewareCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称(字段类型:varchar,字段长度:20,是否可空:True)
 objvCoursewareCaseQuantitySenateEN.UserName = objRow[convCoursewareCaseQuantitySenate.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvCoursewareCaseQuantitySenateEN.OwnerId = objRow[convCoursewareCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvCoursewareCaseQuantitySenateEN.OwnerName = objRow[convCoursewareCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvCoursewareCaseQuantitySenateEN.UserNameWithUserId = objRow[convCoursewareCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId(字段类型:varchar,字段长度:51,是否可空:False)
 objvCoursewareCaseQuantitySenateEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCoursewareCaseQuantitySenate.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvCoursewareCaseQuantitySenateEN.CoursewareCaseDate = objRow[convCoursewareCaseQuantitySenate.CoursewareCaseDate] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.CoursewareCaseDate].ToString().Trim(); //课件教学日期(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareCaseQuantitySenateEN.CoursewareCaseDateIn = objRow[convCoursewareCaseQuantitySenate.CoursewareCaseDateIn] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.CoursewareCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareCaseQuantitySenateEN.CoursewareCaseID = objRow[convCoursewareCaseQuantitySenate.CoursewareCaseID] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.CoursewareCaseID].ToString().Trim(); //课件教学案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareCaseQuantitySenateEN.CoursewareCaseName = objRow[convCoursewareCaseQuantitySenate.CoursewareCaseName] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.CoursewareCaseName].ToString().Trim(); //课件教学案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCoursewareCaseQuantitySenateEN.CoursewareCaseTheme = objRow[convCoursewareCaseQuantitySenate.CoursewareCaseTheme] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.CoursewareCaseTheme].ToString().Trim(); //课件教学案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareCaseQuantitySenateEN.CoursewareCaseTime = objRow[convCoursewareCaseQuantitySenate.CoursewareCaseTime] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.CoursewareCaseTime].ToString().Trim(); //课件教学时间(字段类型:char,字段长度:6,是否可空:True)
 objvCoursewareCaseQuantitySenateEN.CoursewareCaseTimeIn = objRow[convCoursewareCaseQuantitySenate.CoursewareCaseTimeIn] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.CoursewareCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvCoursewareCaseQuantitySenateEN.IdCoursewareCase = objRow[convCoursewareCaseQuantitySenate.IdCoursewareCase] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.IdCoursewareCase].ToString().Trim(); //课件教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareCaseQuantitySenateEN.IdCoursewareCaseType = objRow[convCoursewareCaseQuantitySenate.IdCoursewareCaseType] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.IdCoursewareCaseType].ToString().Trim(); //课件案例类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareCaseQuantitySenateEN.CoursewareCaseTypeName = objRow[convCoursewareCaseQuantitySenate.CoursewareCaseTypeName] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.CoursewareCaseTypeName].ToString().Trim(); //课件案例类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareCaseQuantitySenateEN.UserKindId = objRow[convCoursewareCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id(字段类型:char,字段长度:2,是否可空:False)
 objvCoursewareCaseQuantitySenateEN.UserKindName = objRow[convCoursewareCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名(字段类型:varchar,字段长度:30,是否可空:False)
 objvCoursewareCaseQuantitySenateEN.Memo = objRow[convCoursewareCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCoursewareCaseQuantitySenateEN.OwnerNameWithId = objRow[convCoursewareCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
 objvCoursewareCaseQuantitySenateEN.IdXzCollege = objRow[convCoursewareCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvCoursewareCaseQuantitySenateEN.CollegeNameA = objRow[convCoursewareCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvCoursewareCaseQuantitySenateDA: GetObjByIdmicroteachCaseQuantitySenate)", objException.Message));
}
return objvCoursewareCaseQuantitySenateEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvCoursewareCaseQuantitySenateEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvCoursewareCaseQuantitySenateDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vCoursewareCaseQuantitySenate where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvCoursewareCaseQuantitySenateEN objvCoursewareCaseQuantitySenateEN = new clsvCoursewareCaseQuantitySenateEN()
{
IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convCoursewareCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()), //微格量化评价流水号
UserId = objRow[convCoursewareCaseQuantitySenate.UserId].ToString().Trim(), //用户ID
IdMicroteachCase = objRow[convCoursewareCaseQuantitySenate.IdMicroteachCase].ToString().Trim(), //微格教学案例流水号
IdAppraiseType = objRow[convCoursewareCaseQuantitySenate.IdAppraiseType].ToString().Trim(), //评议类型流水号
AppraiseTypeName = objRow[convCoursewareCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.AppraiseTypeName].ToString().Trim(), //评议类型名称
CollegeID = objRow[convCoursewareCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.CollegeID].ToString().Trim(), //学院ID
CollegeName = objRow[convCoursewareCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.CollegeName].ToString().Trim(), //学院名称
BrowseCount = objRow[convCoursewareCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareCaseQuantitySenate.BrowseCount].ToString().Trim()), //浏览次数
SenateTheme = objRow[convCoursewareCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.SenateTheme].ToString().Trim(), //量化评价主题
SenateContent = objRow[convCoursewareCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.SenateContent].ToString().Trim(), //评价内容
SenateTotalScore = TransNullToFloat(objRow[convCoursewareCaseQuantitySenate.SenateTotalScore].ToString().Trim()), //评价分数
SenateDate = objRow[convCoursewareCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.SenateDate].ToString().Trim(), //评价日期
SenateTime = objRow[convCoursewareCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.SenateTime].ToString().Trim(), //评价时间
IdSenateGaugeVersion = objRow[convCoursewareCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(), //评价量表版本流水号
senateGaugeVersionID = objRow[convCoursewareCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(), //评价量表版本ID
senateGaugeVersionName = objRow[convCoursewareCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(), //评价量表版本名称
UpdUser = objRow[convCoursewareCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.UpdUser].ToString().Trim(), //修改人
UpdUserName = objRow[convCoursewareCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.UpdUserName].ToString().Trim(), //UpdUserName
FuncModuleName = objRow[convCoursewareCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.FuncModuleName].ToString().Trim(), //功能模块名称
FuncModuleId = objRow[convCoursewareCaseQuantitySenate.FuncModuleId].ToString().Trim(), //功能模块Id
UserTypeId = objRow[convCoursewareCaseQuantitySenate.UserTypeId] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.UserTypeId].ToString().Trim(), //用户类型Id
SenateIp = objRow[convCoursewareCaseQuantitySenate.SenateIp].ToString().Trim(), //评议Ip
UserTypeName = objRow[convCoursewareCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.UserTypeName].ToString().Trim(), //用户类型名称
UserName = objRow[convCoursewareCaseQuantitySenate.UserName].ToString().Trim(), //用户名
OwnerId = objRow[convCoursewareCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.OwnerId].ToString().Trim(), //拥有者Id
OwnerName = objRow[convCoursewareCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.OwnerName].ToString().Trim(), //拥有者姓名
UserNameWithUserId = objRow[convCoursewareCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.UserNameWithUserId].ToString().Trim(), //UserNameWithUserId
IsDualVideo = TransNullToBool(objRow[convCoursewareCaseQuantitySenate.IsDualVideo].ToString().Trim()), //是否双视频
CoursewareCaseDate = objRow[convCoursewareCaseQuantitySenate.CoursewareCaseDate] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.CoursewareCaseDate].ToString().Trim(), //课件教学日期
CoursewareCaseDateIn = objRow[convCoursewareCaseQuantitySenate.CoursewareCaseDateIn] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.CoursewareCaseDateIn].ToString().Trim(), //案例入库日期
CoursewareCaseID = objRow[convCoursewareCaseQuantitySenate.CoursewareCaseID] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.CoursewareCaseID].ToString().Trim(), //课件教学案例ID
CoursewareCaseName = objRow[convCoursewareCaseQuantitySenate.CoursewareCaseName] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.CoursewareCaseName].ToString().Trim(), //课件教学案例名称
CoursewareCaseTheme = objRow[convCoursewareCaseQuantitySenate.CoursewareCaseTheme] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.CoursewareCaseTheme].ToString().Trim(), //课件教学案例主题词
CoursewareCaseTime = objRow[convCoursewareCaseQuantitySenate.CoursewareCaseTime] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.CoursewareCaseTime].ToString().Trim(), //课件教学时间
CoursewareCaseTimeIn = objRow[convCoursewareCaseQuantitySenate.CoursewareCaseTimeIn] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.CoursewareCaseTimeIn].ToString().Trim(), //案例入库时间
IdCoursewareCase = objRow[convCoursewareCaseQuantitySenate.IdCoursewareCase] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.IdCoursewareCase].ToString().Trim(), //课件教学案例流水号
IdCoursewareCaseType = objRow[convCoursewareCaseQuantitySenate.IdCoursewareCaseType] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.IdCoursewareCaseType].ToString().Trim(), //课件案例类型流水号
CoursewareCaseTypeName = objRow[convCoursewareCaseQuantitySenate.CoursewareCaseTypeName] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.CoursewareCaseTypeName].ToString().Trim(), //课件案例类型名称
UserKindId = objRow[convCoursewareCaseQuantitySenate.UserKindId].ToString().Trim(), //用户类别Id
UserKindName = objRow[convCoursewareCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.UserKindName].ToString().Trim(), //用户类别名
Memo = objRow[convCoursewareCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.Memo].ToString().Trim(), //备注
OwnerNameWithId = objRow[convCoursewareCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.OwnerNameWithId].ToString().Trim(), //拥有者名称附Id
IdXzCollege = objRow[convCoursewareCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.IdXzCollege].ToString().Trim(), //学院流水号
CollegeNameA = objRow[convCoursewareCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.CollegeNameA].ToString().Trim() //学院名称简写
};
objvCoursewareCaseQuantitySenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCoursewareCaseQuantitySenateEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvCoursewareCaseQuantitySenateDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvCoursewareCaseQuantitySenateEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCoursewareCaseQuantitySenateEN objvCoursewareCaseQuantitySenateEN = new clsvCoursewareCaseQuantitySenateEN();
try
{
objvCoursewareCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convCoursewareCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvCoursewareCaseQuantitySenateEN.UserId = objRow[convCoursewareCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvCoursewareCaseQuantitySenateEN.IdMicroteachCase = objRow[convCoursewareCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCoursewareCaseQuantitySenateEN.IdAppraiseType = objRow[convCoursewareCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvCoursewareCaseQuantitySenateEN.AppraiseTypeName = objRow[convCoursewareCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvCoursewareCaseQuantitySenateEN.CollegeID = objRow[convCoursewareCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvCoursewareCaseQuantitySenateEN.CollegeName = objRow[convCoursewareCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvCoursewareCaseQuantitySenateEN.BrowseCount = objRow[convCoursewareCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvCoursewareCaseQuantitySenateEN.SenateTheme = objRow[convCoursewareCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvCoursewareCaseQuantitySenateEN.SenateContent = objRow[convCoursewareCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvCoursewareCaseQuantitySenateEN.SenateTotalScore = TransNullToFloat(objRow[convCoursewareCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvCoursewareCaseQuantitySenateEN.SenateDate = objRow[convCoursewareCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvCoursewareCaseQuantitySenateEN.SenateTime = objRow[convCoursewareCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvCoursewareCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convCoursewareCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCoursewareCaseQuantitySenateEN.senateGaugeVersionID = objRow[convCoursewareCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCoursewareCaseQuantitySenateEN.senateGaugeVersionName = objRow[convCoursewareCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCoursewareCaseQuantitySenateEN.UpdUser = objRow[convCoursewareCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvCoursewareCaseQuantitySenateEN.UpdUserName = objRow[convCoursewareCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
objvCoursewareCaseQuantitySenateEN.FuncModuleName = objRow[convCoursewareCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvCoursewareCaseQuantitySenateEN.FuncModuleId = objRow[convCoursewareCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvCoursewareCaseQuantitySenateEN.UserTypeId = objRow[convCoursewareCaseQuantitySenate.UserTypeId] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.UserTypeId].ToString().Trim(); //用户类型Id
objvCoursewareCaseQuantitySenateEN.SenateIp = objRow[convCoursewareCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvCoursewareCaseQuantitySenateEN.UserTypeName = objRow[convCoursewareCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
objvCoursewareCaseQuantitySenateEN.UserName = objRow[convCoursewareCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvCoursewareCaseQuantitySenateEN.OwnerId = objRow[convCoursewareCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvCoursewareCaseQuantitySenateEN.OwnerName = objRow[convCoursewareCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvCoursewareCaseQuantitySenateEN.UserNameWithUserId = objRow[convCoursewareCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvCoursewareCaseQuantitySenateEN.IsDualVideo = TransNullToBool(objRow[convCoursewareCaseQuantitySenate.IsDualVideo].ToString().Trim()); //是否双视频
objvCoursewareCaseQuantitySenateEN.CoursewareCaseDate = objRow[convCoursewareCaseQuantitySenate.CoursewareCaseDate] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.CoursewareCaseDate].ToString().Trim(); //课件教学日期
objvCoursewareCaseQuantitySenateEN.CoursewareCaseDateIn = objRow[convCoursewareCaseQuantitySenate.CoursewareCaseDateIn] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.CoursewareCaseDateIn].ToString().Trim(); //案例入库日期
objvCoursewareCaseQuantitySenateEN.CoursewareCaseID = objRow[convCoursewareCaseQuantitySenate.CoursewareCaseID] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.CoursewareCaseID].ToString().Trim(); //课件教学案例ID
objvCoursewareCaseQuantitySenateEN.CoursewareCaseName = objRow[convCoursewareCaseQuantitySenate.CoursewareCaseName] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.CoursewareCaseName].ToString().Trim(); //课件教学案例名称
objvCoursewareCaseQuantitySenateEN.CoursewareCaseTheme = objRow[convCoursewareCaseQuantitySenate.CoursewareCaseTheme] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.CoursewareCaseTheme].ToString().Trim(); //课件教学案例主题词
objvCoursewareCaseQuantitySenateEN.CoursewareCaseTime = objRow[convCoursewareCaseQuantitySenate.CoursewareCaseTime] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.CoursewareCaseTime].ToString().Trim(); //课件教学时间
objvCoursewareCaseQuantitySenateEN.CoursewareCaseTimeIn = objRow[convCoursewareCaseQuantitySenate.CoursewareCaseTimeIn] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.CoursewareCaseTimeIn].ToString().Trim(); //案例入库时间
objvCoursewareCaseQuantitySenateEN.IdCoursewareCase = objRow[convCoursewareCaseQuantitySenate.IdCoursewareCase] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.IdCoursewareCase].ToString().Trim(); //课件教学案例流水号
objvCoursewareCaseQuantitySenateEN.IdCoursewareCaseType = objRow[convCoursewareCaseQuantitySenate.IdCoursewareCaseType] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.IdCoursewareCaseType].ToString().Trim(); //课件案例类型流水号
objvCoursewareCaseQuantitySenateEN.CoursewareCaseTypeName = objRow[convCoursewareCaseQuantitySenate.CoursewareCaseTypeName] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.CoursewareCaseTypeName].ToString().Trim(); //课件案例类型名称
objvCoursewareCaseQuantitySenateEN.UserKindId = objRow[convCoursewareCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvCoursewareCaseQuantitySenateEN.UserKindName = objRow[convCoursewareCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvCoursewareCaseQuantitySenateEN.Memo = objRow[convCoursewareCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.Memo].ToString().Trim(); //备注
objvCoursewareCaseQuantitySenateEN.OwnerNameWithId = objRow[convCoursewareCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCoursewareCaseQuantitySenateEN.IdXzCollege = objRow[convCoursewareCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvCoursewareCaseQuantitySenateEN.CollegeNameA = objRow[convCoursewareCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvCoursewareCaseQuantitySenateDA: GetObjByDataRowvCoursewareCaseQuantitySenate)", objException.Message));
}
objvCoursewareCaseQuantitySenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCoursewareCaseQuantitySenateEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvCoursewareCaseQuantitySenateEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCoursewareCaseQuantitySenateEN objvCoursewareCaseQuantitySenateEN = new clsvCoursewareCaseQuantitySenateEN();
try
{
objvCoursewareCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convCoursewareCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvCoursewareCaseQuantitySenateEN.UserId = objRow[convCoursewareCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvCoursewareCaseQuantitySenateEN.IdMicroteachCase = objRow[convCoursewareCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCoursewareCaseQuantitySenateEN.IdAppraiseType = objRow[convCoursewareCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvCoursewareCaseQuantitySenateEN.AppraiseTypeName = objRow[convCoursewareCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvCoursewareCaseQuantitySenateEN.CollegeID = objRow[convCoursewareCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvCoursewareCaseQuantitySenateEN.CollegeName = objRow[convCoursewareCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvCoursewareCaseQuantitySenateEN.BrowseCount = objRow[convCoursewareCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvCoursewareCaseQuantitySenateEN.SenateTheme = objRow[convCoursewareCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvCoursewareCaseQuantitySenateEN.SenateContent = objRow[convCoursewareCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvCoursewareCaseQuantitySenateEN.SenateTotalScore = TransNullToFloat(objRow[convCoursewareCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvCoursewareCaseQuantitySenateEN.SenateDate = objRow[convCoursewareCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvCoursewareCaseQuantitySenateEN.SenateTime = objRow[convCoursewareCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvCoursewareCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convCoursewareCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCoursewareCaseQuantitySenateEN.senateGaugeVersionID = objRow[convCoursewareCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCoursewareCaseQuantitySenateEN.senateGaugeVersionName = objRow[convCoursewareCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCoursewareCaseQuantitySenateEN.UpdUser = objRow[convCoursewareCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvCoursewareCaseQuantitySenateEN.UpdUserName = objRow[convCoursewareCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
objvCoursewareCaseQuantitySenateEN.FuncModuleName = objRow[convCoursewareCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvCoursewareCaseQuantitySenateEN.FuncModuleId = objRow[convCoursewareCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvCoursewareCaseQuantitySenateEN.UserTypeId = objRow[convCoursewareCaseQuantitySenate.UserTypeId] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.UserTypeId].ToString().Trim(); //用户类型Id
objvCoursewareCaseQuantitySenateEN.SenateIp = objRow[convCoursewareCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvCoursewareCaseQuantitySenateEN.UserTypeName = objRow[convCoursewareCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
objvCoursewareCaseQuantitySenateEN.UserName = objRow[convCoursewareCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvCoursewareCaseQuantitySenateEN.OwnerId = objRow[convCoursewareCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvCoursewareCaseQuantitySenateEN.OwnerName = objRow[convCoursewareCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvCoursewareCaseQuantitySenateEN.UserNameWithUserId = objRow[convCoursewareCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvCoursewareCaseQuantitySenateEN.IsDualVideo = TransNullToBool(objRow[convCoursewareCaseQuantitySenate.IsDualVideo].ToString().Trim()); //是否双视频
objvCoursewareCaseQuantitySenateEN.CoursewareCaseDate = objRow[convCoursewareCaseQuantitySenate.CoursewareCaseDate] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.CoursewareCaseDate].ToString().Trim(); //课件教学日期
objvCoursewareCaseQuantitySenateEN.CoursewareCaseDateIn = objRow[convCoursewareCaseQuantitySenate.CoursewareCaseDateIn] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.CoursewareCaseDateIn].ToString().Trim(); //案例入库日期
objvCoursewareCaseQuantitySenateEN.CoursewareCaseID = objRow[convCoursewareCaseQuantitySenate.CoursewareCaseID] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.CoursewareCaseID].ToString().Trim(); //课件教学案例ID
objvCoursewareCaseQuantitySenateEN.CoursewareCaseName = objRow[convCoursewareCaseQuantitySenate.CoursewareCaseName] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.CoursewareCaseName].ToString().Trim(); //课件教学案例名称
objvCoursewareCaseQuantitySenateEN.CoursewareCaseTheme = objRow[convCoursewareCaseQuantitySenate.CoursewareCaseTheme] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.CoursewareCaseTheme].ToString().Trim(); //课件教学案例主题词
objvCoursewareCaseQuantitySenateEN.CoursewareCaseTime = objRow[convCoursewareCaseQuantitySenate.CoursewareCaseTime] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.CoursewareCaseTime].ToString().Trim(); //课件教学时间
objvCoursewareCaseQuantitySenateEN.CoursewareCaseTimeIn = objRow[convCoursewareCaseQuantitySenate.CoursewareCaseTimeIn] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.CoursewareCaseTimeIn].ToString().Trim(); //案例入库时间
objvCoursewareCaseQuantitySenateEN.IdCoursewareCase = objRow[convCoursewareCaseQuantitySenate.IdCoursewareCase] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.IdCoursewareCase].ToString().Trim(); //课件教学案例流水号
objvCoursewareCaseQuantitySenateEN.IdCoursewareCaseType = objRow[convCoursewareCaseQuantitySenate.IdCoursewareCaseType] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.IdCoursewareCaseType].ToString().Trim(); //课件案例类型流水号
objvCoursewareCaseQuantitySenateEN.CoursewareCaseTypeName = objRow[convCoursewareCaseQuantitySenate.CoursewareCaseTypeName] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.CoursewareCaseTypeName].ToString().Trim(); //课件案例类型名称
objvCoursewareCaseQuantitySenateEN.UserKindId = objRow[convCoursewareCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvCoursewareCaseQuantitySenateEN.UserKindName = objRow[convCoursewareCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvCoursewareCaseQuantitySenateEN.Memo = objRow[convCoursewareCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.Memo].ToString().Trim(); //备注
objvCoursewareCaseQuantitySenateEN.OwnerNameWithId = objRow[convCoursewareCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCoursewareCaseQuantitySenateEN.IdXzCollege = objRow[convCoursewareCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvCoursewareCaseQuantitySenateEN.CollegeNameA = objRow[convCoursewareCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convCoursewareCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvCoursewareCaseQuantitySenateDA: GetObjByDataRow)", objException.Message));
}
objvCoursewareCaseQuantitySenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCoursewareCaseQuantitySenateEN;
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
objSQL = clsvCoursewareCaseQuantitySenateDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCoursewareCaseQuantitySenateEN._CurrTabName, convCoursewareCaseQuantitySenate.IdmicroteachCaseQuantitySenate, 8, "");
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
objSQL = clsvCoursewareCaseQuantitySenateDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCoursewareCaseQuantitySenateEN._CurrTabName, convCoursewareCaseQuantitySenate.IdmicroteachCaseQuantitySenate, 8, strPrefix);
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
 objSQL = clsvCoursewareCaseQuantitySenateDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdmicroteachCaseQuantitySenate from vCoursewareCaseQuantitySenate where " + strCondition;
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
 objSQL = clsvCoursewareCaseQuantitySenateDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdmicroteachCaseQuantitySenate from vCoursewareCaseQuantitySenate where " + strCondition;
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
 objSQL = clsvCoursewareCaseQuantitySenateDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCoursewareCaseQuantitySenate", "IdmicroteachCaseQuantitySenate = " + ""+ lngIdmicroteachCaseQuantitySenate+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvCoursewareCaseQuantitySenateDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCaseQuantitySenateDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCoursewareCaseQuantitySenate", strCondition))
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
objSQL = clsvCoursewareCaseQuantitySenateDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vCoursewareCaseQuantitySenate");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvCoursewareCaseQuantitySenateENS">源对象</param>
 /// <param name = "objvCoursewareCaseQuantitySenateENT">目标对象</param>
public void CopyTo(clsvCoursewareCaseQuantitySenateEN objvCoursewareCaseQuantitySenateENS, clsvCoursewareCaseQuantitySenateEN objvCoursewareCaseQuantitySenateENT)
{
objvCoursewareCaseQuantitySenateENT.IdmicroteachCaseQuantitySenate = objvCoursewareCaseQuantitySenateENS.IdmicroteachCaseQuantitySenate; //微格量化评价流水号
objvCoursewareCaseQuantitySenateENT.UserId = objvCoursewareCaseQuantitySenateENS.UserId; //用户ID
objvCoursewareCaseQuantitySenateENT.IdMicroteachCase = objvCoursewareCaseQuantitySenateENS.IdMicroteachCase; //微格教学案例流水号
objvCoursewareCaseQuantitySenateENT.IdAppraiseType = objvCoursewareCaseQuantitySenateENS.IdAppraiseType; //评议类型流水号
objvCoursewareCaseQuantitySenateENT.AppraiseTypeName = objvCoursewareCaseQuantitySenateENS.AppraiseTypeName; //评议类型名称
objvCoursewareCaseQuantitySenateENT.CollegeID = objvCoursewareCaseQuantitySenateENS.CollegeID; //学院ID
objvCoursewareCaseQuantitySenateENT.CollegeName = objvCoursewareCaseQuantitySenateENS.CollegeName; //学院名称
objvCoursewareCaseQuantitySenateENT.BrowseCount = objvCoursewareCaseQuantitySenateENS.BrowseCount; //浏览次数
objvCoursewareCaseQuantitySenateENT.SenateTheme = objvCoursewareCaseQuantitySenateENS.SenateTheme; //量化评价主题
objvCoursewareCaseQuantitySenateENT.SenateContent = objvCoursewareCaseQuantitySenateENS.SenateContent; //评价内容
objvCoursewareCaseQuantitySenateENT.SenateTotalScore = objvCoursewareCaseQuantitySenateENS.SenateTotalScore; //评价分数
objvCoursewareCaseQuantitySenateENT.SenateDate = objvCoursewareCaseQuantitySenateENS.SenateDate; //评价日期
objvCoursewareCaseQuantitySenateENT.SenateTime = objvCoursewareCaseQuantitySenateENS.SenateTime; //评价时间
objvCoursewareCaseQuantitySenateENT.IdSenateGaugeVersion = objvCoursewareCaseQuantitySenateENS.IdSenateGaugeVersion; //评价量表版本流水号
objvCoursewareCaseQuantitySenateENT.senateGaugeVersionID = objvCoursewareCaseQuantitySenateENS.senateGaugeVersionID; //评价量表版本ID
objvCoursewareCaseQuantitySenateENT.senateGaugeVersionName = objvCoursewareCaseQuantitySenateENS.senateGaugeVersionName; //评价量表版本名称
objvCoursewareCaseQuantitySenateENT.UpdUser = objvCoursewareCaseQuantitySenateENS.UpdUser; //修改人
objvCoursewareCaseQuantitySenateENT.UpdUserName = objvCoursewareCaseQuantitySenateENS.UpdUserName; //UpdUserName
objvCoursewareCaseQuantitySenateENT.FuncModuleName = objvCoursewareCaseQuantitySenateENS.FuncModuleName; //功能模块名称
objvCoursewareCaseQuantitySenateENT.FuncModuleId = objvCoursewareCaseQuantitySenateENS.FuncModuleId; //功能模块Id
objvCoursewareCaseQuantitySenateENT.UserTypeId = objvCoursewareCaseQuantitySenateENS.UserTypeId; //用户类型Id
objvCoursewareCaseQuantitySenateENT.SenateIp = objvCoursewareCaseQuantitySenateENS.SenateIp; //评议Ip
objvCoursewareCaseQuantitySenateENT.UserTypeName = objvCoursewareCaseQuantitySenateENS.UserTypeName; //用户类型名称
objvCoursewareCaseQuantitySenateENT.UserName = objvCoursewareCaseQuantitySenateENS.UserName; //用户名
objvCoursewareCaseQuantitySenateENT.OwnerId = objvCoursewareCaseQuantitySenateENS.OwnerId; //拥有者Id
objvCoursewareCaseQuantitySenateENT.OwnerName = objvCoursewareCaseQuantitySenateENS.OwnerName; //拥有者姓名
objvCoursewareCaseQuantitySenateENT.UserNameWithUserId = objvCoursewareCaseQuantitySenateENS.UserNameWithUserId; //UserNameWithUserId
objvCoursewareCaseQuantitySenateENT.IsDualVideo = objvCoursewareCaseQuantitySenateENS.IsDualVideo; //是否双视频
objvCoursewareCaseQuantitySenateENT.CoursewareCaseDate = objvCoursewareCaseQuantitySenateENS.CoursewareCaseDate; //课件教学日期
objvCoursewareCaseQuantitySenateENT.CoursewareCaseDateIn = objvCoursewareCaseQuantitySenateENS.CoursewareCaseDateIn; //案例入库日期
objvCoursewareCaseQuantitySenateENT.CoursewareCaseID = objvCoursewareCaseQuantitySenateENS.CoursewareCaseID; //课件教学案例ID
objvCoursewareCaseQuantitySenateENT.CoursewareCaseName = objvCoursewareCaseQuantitySenateENS.CoursewareCaseName; //课件教学案例名称
objvCoursewareCaseQuantitySenateENT.CoursewareCaseTheme = objvCoursewareCaseQuantitySenateENS.CoursewareCaseTheme; //课件教学案例主题词
objvCoursewareCaseQuantitySenateENT.CoursewareCaseTime = objvCoursewareCaseQuantitySenateENS.CoursewareCaseTime; //课件教学时间
objvCoursewareCaseQuantitySenateENT.CoursewareCaseTimeIn = objvCoursewareCaseQuantitySenateENS.CoursewareCaseTimeIn; //案例入库时间
objvCoursewareCaseQuantitySenateENT.IdCoursewareCase = objvCoursewareCaseQuantitySenateENS.IdCoursewareCase; //课件教学案例流水号
objvCoursewareCaseQuantitySenateENT.IdCoursewareCaseType = objvCoursewareCaseQuantitySenateENS.IdCoursewareCaseType; //课件案例类型流水号
objvCoursewareCaseQuantitySenateENT.CoursewareCaseTypeName = objvCoursewareCaseQuantitySenateENS.CoursewareCaseTypeName; //课件案例类型名称
objvCoursewareCaseQuantitySenateENT.UserKindId = objvCoursewareCaseQuantitySenateENS.UserKindId; //用户类别Id
objvCoursewareCaseQuantitySenateENT.UserKindName = objvCoursewareCaseQuantitySenateENS.UserKindName; //用户类别名
objvCoursewareCaseQuantitySenateENT.Memo = objvCoursewareCaseQuantitySenateENS.Memo; //备注
objvCoursewareCaseQuantitySenateENT.OwnerNameWithId = objvCoursewareCaseQuantitySenateENS.OwnerNameWithId; //拥有者名称附Id
objvCoursewareCaseQuantitySenateENT.IdXzCollege = objvCoursewareCaseQuantitySenateENS.IdXzCollege; //学院流水号
objvCoursewareCaseQuantitySenateENT.CollegeNameA = objvCoursewareCaseQuantitySenateENS.CollegeNameA; //学院名称简写
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvCoursewareCaseQuantitySenateEN objvCoursewareCaseQuantitySenateEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvCoursewareCaseQuantitySenateEN.UserId, 18, convCoursewareCaseQuantitySenate.UserId);
clsCheckSql.CheckFieldLen(objvCoursewareCaseQuantitySenateEN.IdMicroteachCase, 8, convCoursewareCaseQuantitySenate.IdMicroteachCase);
clsCheckSql.CheckFieldLen(objvCoursewareCaseQuantitySenateEN.IdAppraiseType, 4, convCoursewareCaseQuantitySenate.IdAppraiseType);
clsCheckSql.CheckFieldLen(objvCoursewareCaseQuantitySenateEN.AppraiseTypeName, 50, convCoursewareCaseQuantitySenate.AppraiseTypeName);
clsCheckSql.CheckFieldLen(objvCoursewareCaseQuantitySenateEN.CollegeID, 4, convCoursewareCaseQuantitySenate.CollegeID);
clsCheckSql.CheckFieldLen(objvCoursewareCaseQuantitySenateEN.CollegeName, 100, convCoursewareCaseQuantitySenate.CollegeName);
clsCheckSql.CheckFieldLen(objvCoursewareCaseQuantitySenateEN.SenateTheme, 200, convCoursewareCaseQuantitySenate.SenateTheme);
clsCheckSql.CheckFieldLen(objvCoursewareCaseQuantitySenateEN.SenateContent, 2000, convCoursewareCaseQuantitySenate.SenateContent);
clsCheckSql.CheckFieldLen(objvCoursewareCaseQuantitySenateEN.SenateDate, 8, convCoursewareCaseQuantitySenate.SenateDate);
clsCheckSql.CheckFieldLen(objvCoursewareCaseQuantitySenateEN.SenateTime, 6, convCoursewareCaseQuantitySenate.SenateTime);
clsCheckSql.CheckFieldLen(objvCoursewareCaseQuantitySenateEN.IdSenateGaugeVersion, 4, convCoursewareCaseQuantitySenate.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objvCoursewareCaseQuantitySenateEN.senateGaugeVersionID, 4, convCoursewareCaseQuantitySenate.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(objvCoursewareCaseQuantitySenateEN.senateGaugeVersionName, 200, convCoursewareCaseQuantitySenate.senateGaugeVersionName);
clsCheckSql.CheckFieldLen(objvCoursewareCaseQuantitySenateEN.UpdUser, 20, convCoursewareCaseQuantitySenate.UpdUser);
clsCheckSql.CheckFieldLen(objvCoursewareCaseQuantitySenateEN.UpdUserName, 20, convCoursewareCaseQuantitySenate.UpdUserName);
clsCheckSql.CheckFieldLen(objvCoursewareCaseQuantitySenateEN.FuncModuleName, 30, convCoursewareCaseQuantitySenate.FuncModuleName);
clsCheckSql.CheckFieldLen(objvCoursewareCaseQuantitySenateEN.FuncModuleId, 4, convCoursewareCaseQuantitySenate.FuncModuleId);
clsCheckSql.CheckFieldLen(objvCoursewareCaseQuantitySenateEN.UserTypeId, 2, convCoursewareCaseQuantitySenate.UserTypeId);
clsCheckSql.CheckFieldLen(objvCoursewareCaseQuantitySenateEN.SenateIp, 50, convCoursewareCaseQuantitySenate.SenateIp);
clsCheckSql.CheckFieldLen(objvCoursewareCaseQuantitySenateEN.UserTypeName, 20, convCoursewareCaseQuantitySenate.UserTypeName);
clsCheckSql.CheckFieldLen(objvCoursewareCaseQuantitySenateEN.UserName, 30, convCoursewareCaseQuantitySenate.UserName);
clsCheckSql.CheckFieldLen(objvCoursewareCaseQuantitySenateEN.OwnerId, 20, convCoursewareCaseQuantitySenate.OwnerId);
clsCheckSql.CheckFieldLen(objvCoursewareCaseQuantitySenateEN.OwnerName, 30, convCoursewareCaseQuantitySenate.OwnerName);
clsCheckSql.CheckFieldLen(objvCoursewareCaseQuantitySenateEN.UserNameWithUserId, 51, convCoursewareCaseQuantitySenate.UserNameWithUserId);
clsCheckSql.CheckFieldLen(objvCoursewareCaseQuantitySenateEN.CoursewareCaseDate, 8, convCoursewareCaseQuantitySenate.CoursewareCaseDate);
clsCheckSql.CheckFieldLen(objvCoursewareCaseQuantitySenateEN.CoursewareCaseDateIn, 8, convCoursewareCaseQuantitySenate.CoursewareCaseDateIn);
clsCheckSql.CheckFieldLen(objvCoursewareCaseQuantitySenateEN.CoursewareCaseID, 8, convCoursewareCaseQuantitySenate.CoursewareCaseID);
clsCheckSql.CheckFieldLen(objvCoursewareCaseQuantitySenateEN.CoursewareCaseName, 100, convCoursewareCaseQuantitySenate.CoursewareCaseName);
clsCheckSql.CheckFieldLen(objvCoursewareCaseQuantitySenateEN.CoursewareCaseTheme, 200, convCoursewareCaseQuantitySenate.CoursewareCaseTheme);
clsCheckSql.CheckFieldLen(objvCoursewareCaseQuantitySenateEN.CoursewareCaseTime, 6, convCoursewareCaseQuantitySenate.CoursewareCaseTime);
clsCheckSql.CheckFieldLen(objvCoursewareCaseQuantitySenateEN.CoursewareCaseTimeIn, 6, convCoursewareCaseQuantitySenate.CoursewareCaseTimeIn);
clsCheckSql.CheckFieldLen(objvCoursewareCaseQuantitySenateEN.IdCoursewareCase, 8, convCoursewareCaseQuantitySenate.IdCoursewareCase);
clsCheckSql.CheckFieldLen(objvCoursewareCaseQuantitySenateEN.IdCoursewareCaseType, 4, convCoursewareCaseQuantitySenate.IdCoursewareCaseType);
clsCheckSql.CheckFieldLen(objvCoursewareCaseQuantitySenateEN.CoursewareCaseTypeName, 50, convCoursewareCaseQuantitySenate.CoursewareCaseTypeName);
clsCheckSql.CheckFieldLen(objvCoursewareCaseQuantitySenateEN.UserKindId, 2, convCoursewareCaseQuantitySenate.UserKindId);
clsCheckSql.CheckFieldLen(objvCoursewareCaseQuantitySenateEN.UserKindName, 30, convCoursewareCaseQuantitySenate.UserKindName);
clsCheckSql.CheckFieldLen(objvCoursewareCaseQuantitySenateEN.Memo, 1000, convCoursewareCaseQuantitySenate.Memo);
clsCheckSql.CheckFieldLen(objvCoursewareCaseQuantitySenateEN.OwnerNameWithId, 51, convCoursewareCaseQuantitySenate.OwnerNameWithId);
clsCheckSql.CheckFieldLen(objvCoursewareCaseQuantitySenateEN.IdXzCollege, 4, convCoursewareCaseQuantitySenate.IdXzCollege);
clsCheckSql.CheckFieldLen(objvCoursewareCaseQuantitySenateEN.CollegeNameA, 12, convCoursewareCaseQuantitySenate.CollegeNameA);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseQuantitySenateEN.UserId, convCoursewareCaseQuantitySenate.UserId);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseQuantitySenateEN.IdMicroteachCase, convCoursewareCaseQuantitySenate.IdMicroteachCase);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseQuantitySenateEN.IdAppraiseType, convCoursewareCaseQuantitySenate.IdAppraiseType);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseQuantitySenateEN.AppraiseTypeName, convCoursewareCaseQuantitySenate.AppraiseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseQuantitySenateEN.CollegeID, convCoursewareCaseQuantitySenate.CollegeID);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseQuantitySenateEN.CollegeName, convCoursewareCaseQuantitySenate.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseQuantitySenateEN.SenateTheme, convCoursewareCaseQuantitySenate.SenateTheme);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseQuantitySenateEN.SenateContent, convCoursewareCaseQuantitySenate.SenateContent);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseQuantitySenateEN.SenateDate, convCoursewareCaseQuantitySenate.SenateDate);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseQuantitySenateEN.SenateTime, convCoursewareCaseQuantitySenate.SenateTime);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseQuantitySenateEN.IdSenateGaugeVersion, convCoursewareCaseQuantitySenate.IdSenateGaugeVersion);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseQuantitySenateEN.senateGaugeVersionID, convCoursewareCaseQuantitySenate.senateGaugeVersionID);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseQuantitySenateEN.senateGaugeVersionName, convCoursewareCaseQuantitySenate.senateGaugeVersionName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseQuantitySenateEN.UpdUser, convCoursewareCaseQuantitySenate.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseQuantitySenateEN.UpdUserName, convCoursewareCaseQuantitySenate.UpdUserName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseQuantitySenateEN.FuncModuleName, convCoursewareCaseQuantitySenate.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseQuantitySenateEN.FuncModuleId, convCoursewareCaseQuantitySenate.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseQuantitySenateEN.UserTypeId, convCoursewareCaseQuantitySenate.UserTypeId);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseQuantitySenateEN.SenateIp, convCoursewareCaseQuantitySenate.SenateIp);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseQuantitySenateEN.UserTypeName, convCoursewareCaseQuantitySenate.UserTypeName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseQuantitySenateEN.UserName, convCoursewareCaseQuantitySenate.UserName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseQuantitySenateEN.OwnerId, convCoursewareCaseQuantitySenate.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseQuantitySenateEN.OwnerName, convCoursewareCaseQuantitySenate.OwnerName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseQuantitySenateEN.UserNameWithUserId, convCoursewareCaseQuantitySenate.UserNameWithUserId);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseQuantitySenateEN.CoursewareCaseDate, convCoursewareCaseQuantitySenate.CoursewareCaseDate);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseQuantitySenateEN.CoursewareCaseDateIn, convCoursewareCaseQuantitySenate.CoursewareCaseDateIn);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseQuantitySenateEN.CoursewareCaseID, convCoursewareCaseQuantitySenate.CoursewareCaseID);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseQuantitySenateEN.CoursewareCaseName, convCoursewareCaseQuantitySenate.CoursewareCaseName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseQuantitySenateEN.CoursewareCaseTheme, convCoursewareCaseQuantitySenate.CoursewareCaseTheme);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseQuantitySenateEN.CoursewareCaseTime, convCoursewareCaseQuantitySenate.CoursewareCaseTime);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseQuantitySenateEN.CoursewareCaseTimeIn, convCoursewareCaseQuantitySenate.CoursewareCaseTimeIn);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseQuantitySenateEN.IdCoursewareCase, convCoursewareCaseQuantitySenate.IdCoursewareCase);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseQuantitySenateEN.IdCoursewareCaseType, convCoursewareCaseQuantitySenate.IdCoursewareCaseType);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseQuantitySenateEN.CoursewareCaseTypeName, convCoursewareCaseQuantitySenate.CoursewareCaseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseQuantitySenateEN.UserKindId, convCoursewareCaseQuantitySenate.UserKindId);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseQuantitySenateEN.UserKindName, convCoursewareCaseQuantitySenate.UserKindName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseQuantitySenateEN.Memo, convCoursewareCaseQuantitySenate.Memo);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseQuantitySenateEN.OwnerNameWithId, convCoursewareCaseQuantitySenate.OwnerNameWithId);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseQuantitySenateEN.IdXzCollege, convCoursewareCaseQuantitySenate.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCaseQuantitySenateEN.CollegeNameA, convCoursewareCaseQuantitySenate.CollegeNameA);
//检查外键字段长度
 objvCoursewareCaseQuantitySenateEN._IsCheckProperty = true;
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
 objSQL = clsvCoursewareCaseQuantitySenateDA.GetSpecSQLObj();
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
 objSQL = clsvCoursewareCaseQuantitySenateDA.GetSpecSQLObj();
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
 objSQL = clsvCoursewareCaseQuantitySenateDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCoursewareCaseQuantitySenateEN._CurrTabName);
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
 objSQL = clsvCoursewareCaseQuantitySenateDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCoursewareCaseQuantitySenateEN._CurrTabName, strCondition);
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
 objSQL = clsvCoursewareCaseQuantitySenateDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}