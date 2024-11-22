
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMicroTeachCaseDA
 表名:vMicroTeachCase(01120324)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:47:20
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:微格教学评议(MicroTeachSenate)
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
 /// v微格教学案例(vMicroTeachCase)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvMicroTeachCaseDA : clsCommBase4DA
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
 return clsvMicroTeachCaseEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvMicroTeachCaseEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvMicroTeachCaseEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvMicroTeachCaseEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvMicroTeachCaseEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strIdMicroteachCase">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strIdMicroteachCase)
{
strIdMicroteachCase = strIdMicroteachCase.Replace("'", "''");
if (strIdMicroteachCase.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vMicroTeachCase中,检查关键字,长度不正确!(clsvMicroTeachCaseDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdMicroteachCase)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vMicroTeachCase中,关键字不能为空 或 null!(clsvMicroTeachCaseDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdMicroteachCase);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvMicroTeachCaseDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvMicroTeachCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroTeachCaseDA.GetSpecSQLObj();
strSQL = "Select * from vMicroTeachCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vMicroTeachCase(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvMicroTeachCaseDA: GetDataTable_vMicroTeachCase)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroTeachCaseDA.GetSpecSQLObj();
strSQL = "Select * from vMicroTeachCase where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvMicroTeachCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroTeachCaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvMicroTeachCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroTeachCaseDA.GetSpecSQLObj();
strSQL = "Select * from vMicroTeachCase where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvMicroTeachCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroTeachCaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvMicroTeachCaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroTeachCaseDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vMicroTeachCase where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vMicroTeachCase where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvMicroTeachCaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroTeachCaseDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vMicroTeachCase where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvMicroTeachCaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroTeachCaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vMicroTeachCase.* from vMicroTeachCase Left Join {1} on {2} where {3} and vMicroTeachCase.IdMicroteachCase not in (Select top {5} vMicroTeachCase.IdMicroteachCase from vMicroTeachCase Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vMicroTeachCase where {1} and IdMicroteachCase not in (Select top {2} IdMicroteachCase from vMicroTeachCase where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vMicroTeachCase where {1} and IdMicroteachCase not in (Select top {3} IdMicroteachCase from vMicroTeachCase where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvMicroTeachCaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroTeachCaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vMicroTeachCase.* from vMicroTeachCase Left Join {1} on {2} where {3} and vMicroTeachCase.IdMicroteachCase not in (Select top {5} vMicroTeachCase.IdMicroteachCase from vMicroTeachCase Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vMicroTeachCase where {1} and IdMicroteachCase not in (Select top {2} IdMicroteachCase from vMicroTeachCase where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vMicroTeachCase where {1} and IdMicroteachCase not in (Select top {3} IdMicroteachCase from vMicroTeachCase where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvMicroTeachCaseEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvMicroTeachCaseDA:GetObjLst)", objException.Message));
}
List<clsvMicroTeachCaseEN> arrObjLst = new List<clsvMicroTeachCaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroTeachCaseDA.GetSpecSQLObj();
strSQL = "Select * from vMicroTeachCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroTeachCaseEN objvMicroTeachCaseEN = new clsvMicroTeachCaseEN();
try
{
objvMicroTeachCaseEN.IdMicroteachCase = objRow[convMicroTeachCase.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroTeachCaseEN.MicroteachCaseID = objRow[convMicroTeachCase.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroTeachCaseEN.MicroteachCaseName = objRow[convMicroTeachCase.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroTeachCaseEN.MicroteachCaseTheme = objRow[convMicroTeachCase.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroTeachCaseEN.MicroteachCaseDate = objRow[convMicroTeachCase.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroTeachCaseEN.MicroteachCaseTime = objRow[convMicroTeachCase.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroTeachCaseEN.MicroteachCaseDateIn = objRow[convMicroTeachCase.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroTeachCaseEN.IdStudyLevel = objRow[convMicroTeachCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroTeachCaseEN.StudyLevelName = objRow[convMicroTeachCase.StudyLevelName].ToString().Trim(); //学段名称
objvMicroTeachCaseEN.IdTeachingPlan = objRow[convMicroTeachCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroTeachCaseEN.MicroTeachCaseTimeIn = objRow[convMicroTeachCase.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroTeachCaseEN.IdMicroteachCaseType = objRow[convMicroTeachCase.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号
objvMicroTeachCaseEN.MicroteachCaseTypeName = objRow[convMicroTeachCase.MicroteachCaseTypeName] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseTypeName].ToString().Trim(); //微格案例类型名称
objvMicroTeachCaseEN.IdCaseType = objRow[convMicroTeachCase.IdCaseType].ToString().Trim(); //案例类型流水号
objvMicroTeachCaseEN.IdDiscipline = objRow[convMicroTeachCase.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroTeachCaseEN.DisciplineID = objRow[convMicroTeachCase.DisciplineID] == DBNull.Value ? null : objRow[convMicroTeachCase.DisciplineID].ToString().Trim(); //学科ID
objvMicroTeachCaseEN.DisciplineName = objRow[convMicroTeachCase.DisciplineName] == DBNull.Value ? null : objRow[convMicroTeachCase.DisciplineName].ToString().Trim(); //学科名称
objvMicroTeachCaseEN.IdSenateGaugeVersion = objRow[convMicroTeachCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMicroTeachCaseEN.senateGaugeVersionID = objRow[convMicroTeachCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroTeachCaseEN.senateGaugeVersionName = objRow[convMicroTeachCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroTeachCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroTeachCaseEN.senateGaugeVersionTtlScore = TransNullToFloat(objRow[convMicroTeachCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroTeachCaseEN.VersionNo = objRow[convMicroTeachCase.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroTeachCase.VersionNo].ToString().Trim()); //版本号
objvMicroTeachCaseEN.IdTeachSkill = objRow[convMicroTeachCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroTeachCaseEN.TeachSkillID = objRow[convMicroTeachCase.TeachSkillID] == DBNull.Value ? null : objRow[convMicroTeachCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroTeachCaseEN.SkillTypeName = objRow[convMicroTeachCase.SkillTypeName] == DBNull.Value ? null : objRow[convMicroTeachCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroTeachCaseEN.TeachSkillName = objRow[convMicroTeachCase.TeachSkillName] == DBNull.Value ? null : objRow[convMicroTeachCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroTeachCaseEN.TeachSkillTheory = objRow[convMicroTeachCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroTeachCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroTeachCaseEN.TeachSkillOperMethod = objRow[convMicroTeachCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroTeachCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroTeachCaseEN.IdSkillType = objRow[convMicroTeachCase.IdSkillType] == DBNull.Value ? null : objRow[convMicroTeachCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroTeachCaseEN.SkillTypeID = objRow[convMicroTeachCase.SkillTypeID] == DBNull.Value ? null : objRow[convMicroTeachCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroTeachCaseEN.CaseLevelId = objRow[convMicroTeachCase.CaseLevelId] == DBNull.Value ? null : objRow[convMicroTeachCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroTeachCaseEN.CaseLevelName = objRow[convMicroTeachCase.CaseLevelName] == DBNull.Value ? null : objRow[convMicroTeachCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvMicroTeachCaseEN.DocFile = objRow[convMicroTeachCase.DocFile] == DBNull.Value ? null : objRow[convMicroTeachCase.DocFile].ToString().Trim(); //生成的Word文件名
objvMicroTeachCaseEN.IsNeedGeneWord = TransNullToBool(objRow[convMicroTeachCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvMicroTeachCaseEN.WordCreateDate = objRow[convMicroTeachCase.WordCreateDate] == DBNull.Value ? null : objRow[convMicroTeachCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvMicroTeachCaseEN.IsVisible = TransNullToBool(objRow[convMicroTeachCase.IsVisible].ToString().Trim()); //是否显示
objvMicroTeachCaseEN.microteachCaseText = objRow[convMicroTeachCase.microteachCaseText] == DBNull.Value ? null : objRow[convMicroTeachCase.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroTeachCaseEN.OwnerId = objRow[convMicroTeachCase.OwnerId].ToString().Trim(); //拥有者Id
objvMicroTeachCaseEN.IdStudentInfo = objRow[convMicroTeachCase.IdStudentInfo] == DBNull.Value ? null : objRow[convMicroTeachCase.IdStudentInfo].ToString().Trim(); //学生流水号
objvMicroTeachCaseEN.StuName = objRow[convMicroTeachCase.StuName].ToString().Trim(); //姓名
objvMicroTeachCaseEN.StuID = objRow[convMicroTeachCase.StuID] == DBNull.Value ? null : objRow[convMicroTeachCase.StuID].ToString().Trim(); //学号
objvMicroTeachCaseEN.PoliticsName = objRow[convMicroTeachCase.PoliticsName] == DBNull.Value ? null : objRow[convMicroTeachCase.PoliticsName].ToString().Trim(); //政治面貌
objvMicroTeachCaseEN.SexDesc = objRow[convMicroTeachCase.SexDesc] == DBNull.Value ? null : objRow[convMicroTeachCase.SexDesc].ToString().Trim(); //性别名称
objvMicroTeachCaseEN.EthnicName = objRow[convMicroTeachCase.EthnicName] == DBNull.Value ? null : objRow[convMicroTeachCase.EthnicName].ToString().Trim(); //民族名称
objvMicroTeachCaseEN.UniZoneDesc = objRow[convMicroTeachCase.UniZoneDesc] == DBNull.Value ? null : objRow[convMicroTeachCase.UniZoneDesc].ToString().Trim(); //校区名称
objvMicroTeachCaseEN.StuTypeDesc = objRow[convMicroTeachCase.StuTypeDesc] == DBNull.Value ? null : objRow[convMicroTeachCase.StuTypeDesc].ToString().Trim(); //学生类别名称
objvMicroTeachCaseEN.IdXzCollege = objRow[convMicroTeachCase.IdXzCollege] == DBNull.Value ? null : objRow[convMicroTeachCase.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroTeachCaseEN.CollegeID = objRow[convMicroTeachCase.CollegeID] == DBNull.Value ? null : objRow[convMicroTeachCase.CollegeID].ToString().Trim(); //学院ID
objvMicroTeachCaseEN.CollegeName = objRow[convMicroTeachCase.CollegeName].ToString().Trim(); //学院名称
objvMicroTeachCaseEN.CollegeNameA = objRow[convMicroTeachCase.CollegeNameA] == DBNull.Value ? null : objRow[convMicroTeachCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvMicroTeachCaseEN.IdXzMajor = objRow[convMicroTeachCase.IdXzMajor] == DBNull.Value ? null : objRow[convMicroTeachCase.IdXzMajor].ToString().Trim(); //专业流水号
objvMicroTeachCaseEN.MajorName = objRow[convMicroTeachCase.MajorName].ToString().Trim(); //专业名称
objvMicroTeachCaseEN.IdGradeBase = objRow[convMicroTeachCase.IdGradeBase].ToString().Trim(); //年级流水号
objvMicroTeachCaseEN.GradeBaseName = objRow[convMicroTeachCase.GradeBaseName] == DBNull.Value ? null : objRow[convMicroTeachCase.GradeBaseName].ToString().Trim(); //年级名称
objvMicroTeachCaseEN.IdAdminCls = objRow[convMicroTeachCase.IdAdminCls] == DBNull.Value ? null : objRow[convMicroTeachCase.IdAdminCls].ToString().Trim(); //行政班流水号
objvMicroTeachCaseEN.AdminClsId = objRow[convMicroTeachCase.AdminClsId] == DBNull.Value ? null : objRow[convMicroTeachCase.AdminClsId].ToString().Trim(); //行政班代号
objvMicroTeachCaseEN.AdminClsName = objRow[convMicroTeachCase.AdminClsName] == DBNull.Value ? null : objRow[convMicroTeachCase.AdminClsName].ToString().Trim(); //行政班名称
objvMicroTeachCaseEN.Birthday = objRow[convMicroTeachCase.Birthday] == DBNull.Value ? null : objRow[convMicroTeachCase.Birthday].ToString().Trim(); //出生日期
objvMicroTeachCaseEN.NativePlace = objRow[convMicroTeachCase.NativePlace] == DBNull.Value ? null : objRow[convMicroTeachCase.NativePlace].ToString().Trim(); //籍贯
objvMicroTeachCaseEN.Duty = objRow[convMicroTeachCase.Duty] == DBNull.Value ? null : objRow[convMicroTeachCase.Duty].ToString().Trim(); //职位
objvMicroTeachCaseEN.IDCardNo = objRow[convMicroTeachCase.IDCardNo] == DBNull.Value ? null : objRow[convMicroTeachCase.IDCardNo].ToString().Trim(); //身份证号
objvMicroTeachCaseEN.StuCardNo = objRow[convMicroTeachCase.StuCardNo] == DBNull.Value ? null : objRow[convMicroTeachCase.StuCardNo].ToString().Trim(); //学生证号
objvMicroTeachCaseEN.LiveAddress = objRow[convMicroTeachCase.LiveAddress] == DBNull.Value ? null : objRow[convMicroTeachCase.LiveAddress].ToString().Trim(); //居住地址
objvMicroTeachCaseEN.HomePhone = objRow[convMicroTeachCase.HomePhone] == DBNull.Value ? null : objRow[convMicroTeachCase.HomePhone].ToString().Trim(); //住宅电话
objvMicroTeachCaseEN.EnrollmentDate = objRow[convMicroTeachCase.EnrollmentDate] == DBNull.Value ? null : objRow[convMicroTeachCase.EnrollmentDate].ToString().Trim(); //入校日期
objvMicroTeachCaseEN.PostCode = objRow[convMicroTeachCase.PostCode] == DBNull.Value ? null : objRow[convMicroTeachCase.PostCode].ToString().Trim(); //邮编
objvMicroTeachCaseEN.IsDualVideo = TransNullToBool(objRow[convMicroTeachCase.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroTeachCaseEN.UserKindId = objRow[convMicroTeachCase.UserKindId].ToString().Trim(); //用户类别Id
objvMicroTeachCaseEN.UserKindName = objRow[convMicroTeachCase.UserKindName] == DBNull.Value ? null : objRow[convMicroTeachCase.UserKindName].ToString().Trim(); //用户类别名
objvMicroTeachCaseEN.UserTypeId = objRow[convMicroTeachCase.UserTypeId] == DBNull.Value ? null : objRow[convMicroTeachCase.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroTeachCaseEN.UserTypeName = objRow[convMicroTeachCase.UserTypeName] == DBNull.Value ? null : objRow[convMicroTeachCase.UserTypeName].ToString().Trim(); //用户类型名称
objvMicroTeachCaseEN.RecommendedDegreeId = objRow[convMicroTeachCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroTeachCaseEN.RecommendedDegreeName = objRow[convMicroTeachCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroTeachCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroTeachCaseEN.ftpFileType = objRow[convMicroTeachCase.ftpFileType] == DBNull.Value ? null : objRow[convMicroTeachCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroTeachCaseEN.VideoUrl = objRow[convMicroTeachCase.VideoUrl] == DBNull.Value ? null : objRow[convMicroTeachCase.VideoUrl].ToString().Trim(); //视频Url
objvMicroTeachCaseEN.VideoPath = objRow[convMicroTeachCase.VideoPath] == DBNull.Value ? null : objRow[convMicroTeachCase.VideoPath].ToString().Trim(); //视频目录
objvMicroTeachCaseEN.ResErrMsg = objRow[convMicroTeachCase.ResErrMsg] == DBNull.Value ? null : objRow[convMicroTeachCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvMicroTeachCaseEN.Memo = objRow[convMicroTeachCase.Memo] == DBNull.Value ? null : objRow[convMicroTeachCase.Memo].ToString().Trim(); //备注
objvMicroTeachCaseEN.IsHaveVideo = objRow[convMicroTeachCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
objvMicroTeachCaseEN.OwnerName = objRow[convMicroTeachCase.OwnerName] == DBNull.Value ? null : objRow[convMicroTeachCase.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroTeachCaseEN.BrowseCount4Case = objRow[convMicroTeachCase.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroTeachCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvMicroTeachCaseDA: GetObjLst)", objException.Message));
}
objvMicroTeachCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvMicroTeachCaseEN);
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
public List<clsvMicroTeachCaseEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvMicroTeachCaseDA:GetObjLstByTabName)", objException.Message));
}
List<clsvMicroTeachCaseEN> arrObjLst = new List<clsvMicroTeachCaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroTeachCaseDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroTeachCaseEN objvMicroTeachCaseEN = new clsvMicroTeachCaseEN();
try
{
objvMicroTeachCaseEN.IdMicroteachCase = objRow[convMicroTeachCase.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroTeachCaseEN.MicroteachCaseID = objRow[convMicroTeachCase.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroTeachCaseEN.MicroteachCaseName = objRow[convMicroTeachCase.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroTeachCaseEN.MicroteachCaseTheme = objRow[convMicroTeachCase.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroTeachCaseEN.MicroteachCaseDate = objRow[convMicroTeachCase.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroTeachCaseEN.MicroteachCaseTime = objRow[convMicroTeachCase.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroTeachCaseEN.MicroteachCaseDateIn = objRow[convMicroTeachCase.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroTeachCaseEN.IdStudyLevel = objRow[convMicroTeachCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroTeachCaseEN.StudyLevelName = objRow[convMicroTeachCase.StudyLevelName].ToString().Trim(); //学段名称
objvMicroTeachCaseEN.IdTeachingPlan = objRow[convMicroTeachCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroTeachCaseEN.MicroTeachCaseTimeIn = objRow[convMicroTeachCase.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroTeachCaseEN.IdMicroteachCaseType = objRow[convMicroTeachCase.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号
objvMicroTeachCaseEN.MicroteachCaseTypeName = objRow[convMicroTeachCase.MicroteachCaseTypeName] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseTypeName].ToString().Trim(); //微格案例类型名称
objvMicroTeachCaseEN.IdCaseType = objRow[convMicroTeachCase.IdCaseType].ToString().Trim(); //案例类型流水号
objvMicroTeachCaseEN.IdDiscipline = objRow[convMicroTeachCase.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroTeachCaseEN.DisciplineID = objRow[convMicroTeachCase.DisciplineID] == DBNull.Value ? null : objRow[convMicroTeachCase.DisciplineID].ToString().Trim(); //学科ID
objvMicroTeachCaseEN.DisciplineName = objRow[convMicroTeachCase.DisciplineName] == DBNull.Value ? null : objRow[convMicroTeachCase.DisciplineName].ToString().Trim(); //学科名称
objvMicroTeachCaseEN.IdSenateGaugeVersion = objRow[convMicroTeachCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMicroTeachCaseEN.senateGaugeVersionID = objRow[convMicroTeachCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroTeachCaseEN.senateGaugeVersionName = objRow[convMicroTeachCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroTeachCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroTeachCaseEN.senateGaugeVersionTtlScore = TransNullToFloat(objRow[convMicroTeachCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroTeachCaseEN.VersionNo = objRow[convMicroTeachCase.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroTeachCase.VersionNo].ToString().Trim()); //版本号
objvMicroTeachCaseEN.IdTeachSkill = objRow[convMicroTeachCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroTeachCaseEN.TeachSkillID = objRow[convMicroTeachCase.TeachSkillID] == DBNull.Value ? null : objRow[convMicroTeachCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroTeachCaseEN.SkillTypeName = objRow[convMicroTeachCase.SkillTypeName] == DBNull.Value ? null : objRow[convMicroTeachCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroTeachCaseEN.TeachSkillName = objRow[convMicroTeachCase.TeachSkillName] == DBNull.Value ? null : objRow[convMicroTeachCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroTeachCaseEN.TeachSkillTheory = objRow[convMicroTeachCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroTeachCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroTeachCaseEN.TeachSkillOperMethod = objRow[convMicroTeachCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroTeachCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroTeachCaseEN.IdSkillType = objRow[convMicroTeachCase.IdSkillType] == DBNull.Value ? null : objRow[convMicroTeachCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroTeachCaseEN.SkillTypeID = objRow[convMicroTeachCase.SkillTypeID] == DBNull.Value ? null : objRow[convMicroTeachCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroTeachCaseEN.CaseLevelId = objRow[convMicroTeachCase.CaseLevelId] == DBNull.Value ? null : objRow[convMicroTeachCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroTeachCaseEN.CaseLevelName = objRow[convMicroTeachCase.CaseLevelName] == DBNull.Value ? null : objRow[convMicroTeachCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvMicroTeachCaseEN.DocFile = objRow[convMicroTeachCase.DocFile] == DBNull.Value ? null : objRow[convMicroTeachCase.DocFile].ToString().Trim(); //生成的Word文件名
objvMicroTeachCaseEN.IsNeedGeneWord = TransNullToBool(objRow[convMicroTeachCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvMicroTeachCaseEN.WordCreateDate = objRow[convMicroTeachCase.WordCreateDate] == DBNull.Value ? null : objRow[convMicroTeachCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvMicroTeachCaseEN.IsVisible = TransNullToBool(objRow[convMicroTeachCase.IsVisible].ToString().Trim()); //是否显示
objvMicroTeachCaseEN.microteachCaseText = objRow[convMicroTeachCase.microteachCaseText] == DBNull.Value ? null : objRow[convMicroTeachCase.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroTeachCaseEN.OwnerId = objRow[convMicroTeachCase.OwnerId].ToString().Trim(); //拥有者Id
objvMicroTeachCaseEN.IdStudentInfo = objRow[convMicroTeachCase.IdStudentInfo] == DBNull.Value ? null : objRow[convMicroTeachCase.IdStudentInfo].ToString().Trim(); //学生流水号
objvMicroTeachCaseEN.StuName = objRow[convMicroTeachCase.StuName].ToString().Trim(); //姓名
objvMicroTeachCaseEN.StuID = objRow[convMicroTeachCase.StuID] == DBNull.Value ? null : objRow[convMicroTeachCase.StuID].ToString().Trim(); //学号
objvMicroTeachCaseEN.PoliticsName = objRow[convMicroTeachCase.PoliticsName] == DBNull.Value ? null : objRow[convMicroTeachCase.PoliticsName].ToString().Trim(); //政治面貌
objvMicroTeachCaseEN.SexDesc = objRow[convMicroTeachCase.SexDesc] == DBNull.Value ? null : objRow[convMicroTeachCase.SexDesc].ToString().Trim(); //性别名称
objvMicroTeachCaseEN.EthnicName = objRow[convMicroTeachCase.EthnicName] == DBNull.Value ? null : objRow[convMicroTeachCase.EthnicName].ToString().Trim(); //民族名称
objvMicroTeachCaseEN.UniZoneDesc = objRow[convMicroTeachCase.UniZoneDesc] == DBNull.Value ? null : objRow[convMicroTeachCase.UniZoneDesc].ToString().Trim(); //校区名称
objvMicroTeachCaseEN.StuTypeDesc = objRow[convMicroTeachCase.StuTypeDesc] == DBNull.Value ? null : objRow[convMicroTeachCase.StuTypeDesc].ToString().Trim(); //学生类别名称
objvMicroTeachCaseEN.IdXzCollege = objRow[convMicroTeachCase.IdXzCollege] == DBNull.Value ? null : objRow[convMicroTeachCase.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroTeachCaseEN.CollegeID = objRow[convMicroTeachCase.CollegeID] == DBNull.Value ? null : objRow[convMicroTeachCase.CollegeID].ToString().Trim(); //学院ID
objvMicroTeachCaseEN.CollegeName = objRow[convMicroTeachCase.CollegeName].ToString().Trim(); //学院名称
objvMicroTeachCaseEN.CollegeNameA = objRow[convMicroTeachCase.CollegeNameA] == DBNull.Value ? null : objRow[convMicroTeachCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvMicroTeachCaseEN.IdXzMajor = objRow[convMicroTeachCase.IdXzMajor] == DBNull.Value ? null : objRow[convMicroTeachCase.IdXzMajor].ToString().Trim(); //专业流水号
objvMicroTeachCaseEN.MajorName = objRow[convMicroTeachCase.MajorName].ToString().Trim(); //专业名称
objvMicroTeachCaseEN.IdGradeBase = objRow[convMicroTeachCase.IdGradeBase].ToString().Trim(); //年级流水号
objvMicroTeachCaseEN.GradeBaseName = objRow[convMicroTeachCase.GradeBaseName] == DBNull.Value ? null : objRow[convMicroTeachCase.GradeBaseName].ToString().Trim(); //年级名称
objvMicroTeachCaseEN.IdAdminCls = objRow[convMicroTeachCase.IdAdminCls] == DBNull.Value ? null : objRow[convMicroTeachCase.IdAdminCls].ToString().Trim(); //行政班流水号
objvMicroTeachCaseEN.AdminClsId = objRow[convMicroTeachCase.AdminClsId] == DBNull.Value ? null : objRow[convMicroTeachCase.AdminClsId].ToString().Trim(); //行政班代号
objvMicroTeachCaseEN.AdminClsName = objRow[convMicroTeachCase.AdminClsName] == DBNull.Value ? null : objRow[convMicroTeachCase.AdminClsName].ToString().Trim(); //行政班名称
objvMicroTeachCaseEN.Birthday = objRow[convMicroTeachCase.Birthday] == DBNull.Value ? null : objRow[convMicroTeachCase.Birthday].ToString().Trim(); //出生日期
objvMicroTeachCaseEN.NativePlace = objRow[convMicroTeachCase.NativePlace] == DBNull.Value ? null : objRow[convMicroTeachCase.NativePlace].ToString().Trim(); //籍贯
objvMicroTeachCaseEN.Duty = objRow[convMicroTeachCase.Duty] == DBNull.Value ? null : objRow[convMicroTeachCase.Duty].ToString().Trim(); //职位
objvMicroTeachCaseEN.IDCardNo = objRow[convMicroTeachCase.IDCardNo] == DBNull.Value ? null : objRow[convMicroTeachCase.IDCardNo].ToString().Trim(); //身份证号
objvMicroTeachCaseEN.StuCardNo = objRow[convMicroTeachCase.StuCardNo] == DBNull.Value ? null : objRow[convMicroTeachCase.StuCardNo].ToString().Trim(); //学生证号
objvMicroTeachCaseEN.LiveAddress = objRow[convMicroTeachCase.LiveAddress] == DBNull.Value ? null : objRow[convMicroTeachCase.LiveAddress].ToString().Trim(); //居住地址
objvMicroTeachCaseEN.HomePhone = objRow[convMicroTeachCase.HomePhone] == DBNull.Value ? null : objRow[convMicroTeachCase.HomePhone].ToString().Trim(); //住宅电话
objvMicroTeachCaseEN.EnrollmentDate = objRow[convMicroTeachCase.EnrollmentDate] == DBNull.Value ? null : objRow[convMicroTeachCase.EnrollmentDate].ToString().Trim(); //入校日期
objvMicroTeachCaseEN.PostCode = objRow[convMicroTeachCase.PostCode] == DBNull.Value ? null : objRow[convMicroTeachCase.PostCode].ToString().Trim(); //邮编
objvMicroTeachCaseEN.IsDualVideo = TransNullToBool(objRow[convMicroTeachCase.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroTeachCaseEN.UserKindId = objRow[convMicroTeachCase.UserKindId].ToString().Trim(); //用户类别Id
objvMicroTeachCaseEN.UserKindName = objRow[convMicroTeachCase.UserKindName] == DBNull.Value ? null : objRow[convMicroTeachCase.UserKindName].ToString().Trim(); //用户类别名
objvMicroTeachCaseEN.UserTypeId = objRow[convMicroTeachCase.UserTypeId] == DBNull.Value ? null : objRow[convMicroTeachCase.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroTeachCaseEN.UserTypeName = objRow[convMicroTeachCase.UserTypeName] == DBNull.Value ? null : objRow[convMicroTeachCase.UserTypeName].ToString().Trim(); //用户类型名称
objvMicroTeachCaseEN.RecommendedDegreeId = objRow[convMicroTeachCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroTeachCaseEN.RecommendedDegreeName = objRow[convMicroTeachCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroTeachCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroTeachCaseEN.ftpFileType = objRow[convMicroTeachCase.ftpFileType] == DBNull.Value ? null : objRow[convMicroTeachCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroTeachCaseEN.VideoUrl = objRow[convMicroTeachCase.VideoUrl] == DBNull.Value ? null : objRow[convMicroTeachCase.VideoUrl].ToString().Trim(); //视频Url
objvMicroTeachCaseEN.VideoPath = objRow[convMicroTeachCase.VideoPath] == DBNull.Value ? null : objRow[convMicroTeachCase.VideoPath].ToString().Trim(); //视频目录
objvMicroTeachCaseEN.ResErrMsg = objRow[convMicroTeachCase.ResErrMsg] == DBNull.Value ? null : objRow[convMicroTeachCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvMicroTeachCaseEN.Memo = objRow[convMicroTeachCase.Memo] == DBNull.Value ? null : objRow[convMicroTeachCase.Memo].ToString().Trim(); //备注
objvMicroTeachCaseEN.IsHaveVideo = objRow[convMicroTeachCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
objvMicroTeachCaseEN.OwnerName = objRow[convMicroTeachCase.OwnerName] == DBNull.Value ? null : objRow[convMicroTeachCase.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroTeachCaseEN.BrowseCount4Case = objRow[convMicroTeachCase.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroTeachCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvMicroTeachCaseDA: GetObjLst)", objException.Message));
}
objvMicroTeachCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvMicroTeachCaseEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvMicroTeachCaseEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvMicroTeachCase(ref clsvMicroTeachCaseEN objvMicroTeachCaseEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroTeachCaseDA.GetSpecSQLObj();
strSQL = "Select * from vMicroTeachCase where IdMicroteachCase = " + "'"+ objvMicroTeachCaseEN.IdMicroteachCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvMicroTeachCaseEN.IdMicroteachCase = objDT.Rows[0][convMicroTeachCase.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMicroTeachCaseEN.MicroteachCaseID = objDT.Rows[0][convMicroTeachCase.MicroteachCaseID].ToString().Trim(); //微格教学案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvMicroTeachCaseEN.MicroteachCaseName = objDT.Rows[0][convMicroTeachCase.MicroteachCaseName].ToString().Trim(); //微格教学案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMicroTeachCaseEN.MicroteachCaseTheme = objDT.Rows[0][convMicroTeachCase.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroTeachCaseEN.MicroteachCaseDate = objDT.Rows[0][convMicroTeachCase.MicroteachCaseDate].ToString().Trim(); //微格教学日期(字段类型:char,字段长度:8,是否可空:True)
 objvMicroTeachCaseEN.MicroteachCaseTime = objDT.Rows[0][convMicroTeachCase.MicroteachCaseTime].ToString().Trim(); //微格教学时间(字段类型:char,字段长度:6,是否可空:True)
 objvMicroTeachCaseEN.MicroteachCaseDateIn = objDT.Rows[0][convMicroTeachCase.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvMicroTeachCaseEN.IdStudyLevel = objDT.Rows[0][convMicroTeachCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvMicroTeachCaseEN.StudyLevelName = objDT.Rows[0][convMicroTeachCase.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroTeachCaseEN.IdTeachingPlan = objDT.Rows[0][convMicroTeachCase.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMicroTeachCaseEN.MicroTeachCaseTimeIn = objDT.Rows[0][convMicroTeachCase.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvMicroTeachCaseEN.IdMicroteachCaseType = objDT.Rows[0][convMicroTeachCase.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMicroTeachCaseEN.MicroteachCaseTypeName = objDT.Rows[0][convMicroTeachCase.MicroteachCaseTypeName].ToString().Trim(); //微格案例类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroTeachCaseEN.IdCaseType = objDT.Rows[0][convMicroTeachCase.IdCaseType].ToString().Trim(); //案例类型流水号(字段类型:char,字段长度:4,是否可空:True)
 objvMicroTeachCaseEN.IdDiscipline = objDT.Rows[0][convMicroTeachCase.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMicroTeachCaseEN.DisciplineID = objDT.Rows[0][convMicroTeachCase.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvMicroTeachCaseEN.DisciplineName = objDT.Rows[0][convMicroTeachCase.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroTeachCaseEN.IdSenateGaugeVersion = objDT.Rows[0][convMicroTeachCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMicroTeachCaseEN.senateGaugeVersionID = objDT.Rows[0][convMicroTeachCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvMicroTeachCaseEN.senateGaugeVersionName = objDT.Rows[0][convMicroTeachCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroTeachCaseEN.senateGaugeVersionTtlScore = TransNullToFloat(objDT.Rows[0][convMicroTeachCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvMicroTeachCaseEN.VersionNo = TransNullToInt(objDT.Rows[0][convMicroTeachCase.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvMicroTeachCaseEN.IdTeachSkill = objDT.Rows[0][convMicroTeachCase.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMicroTeachCaseEN.TeachSkillID = objDT.Rows[0][convMicroTeachCase.TeachSkillID].ToString().Trim(); //教学技能ID(字段类型:char,字段长度:8,是否可空:False)
 objvMicroTeachCaseEN.SkillTypeName = objDT.Rows[0][convMicroTeachCase.SkillTypeName].ToString().Trim(); //技能类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroTeachCaseEN.TeachSkillName = objDT.Rows[0][convMicroTeachCase.TeachSkillName].ToString().Trim(); //教学技能名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroTeachCaseEN.TeachSkillTheory = objDT.Rows[0][convMicroTeachCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvMicroTeachCaseEN.TeachSkillOperMethod = objDT.Rows[0][convMicroTeachCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法(字段类型:varchar,字段长度:2000,是否可空:True)
 objvMicroTeachCaseEN.IdSkillType = objDT.Rows[0][convMicroTeachCase.IdSkillType].ToString().Trim(); //技能类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMicroTeachCaseEN.SkillTypeID = objDT.Rows[0][convMicroTeachCase.SkillTypeID].ToString().Trim(); //技能类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvMicroTeachCaseEN.CaseLevelId = objDT.Rows[0][convMicroTeachCase.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvMicroTeachCaseEN.CaseLevelName = objDT.Rows[0][convMicroTeachCase.CaseLevelName].ToString().Trim(); //案例等级名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvMicroTeachCaseEN.DocFile = objDT.Rows[0][convMicroTeachCase.DocFile].ToString().Trim(); //生成的Word文件名(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroTeachCaseEN.IsNeedGeneWord = TransNullToBool(objDT.Rows[0][convMicroTeachCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word(字段类型:bit,字段长度:1,是否可空:True)
 objvMicroTeachCaseEN.WordCreateDate = objDT.Rows[0][convMicroTeachCase.WordCreateDate].ToString().Trim(); //Word生成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objvMicroTeachCaseEN.IsVisible = TransNullToBool(objDT.Rows[0][convMicroTeachCase.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvMicroTeachCaseEN.microteachCaseText = objDT.Rows[0][convMicroTeachCase.microteachCaseText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objvMicroTeachCaseEN.OwnerId = objDT.Rows[0][convMicroTeachCase.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvMicroTeachCaseEN.IdStudentInfo = objDT.Rows[0][convMicroTeachCase.IdStudentInfo].ToString().Trim(); //学生流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMicroTeachCaseEN.StuName = objDT.Rows[0][convMicroTeachCase.StuName].ToString().Trim(); //姓名(字段类型:varchar,字段长度:50,是否可空:True)
 objvMicroTeachCaseEN.StuID = objDT.Rows[0][convMicroTeachCase.StuID].ToString().Trim(); //学号(字段类型:varchar,字段长度:20,是否可空:True)
 objvMicroTeachCaseEN.PoliticsName = objDT.Rows[0][convMicroTeachCase.PoliticsName].ToString().Trim(); //政治面貌(字段类型:varchar,字段长度:30,是否可空:False)
 objvMicroTeachCaseEN.SexDesc = objDT.Rows[0][convMicroTeachCase.SexDesc].ToString().Trim(); //性别名称(字段类型:varchar,字段长度:10,是否可空:True)
 objvMicroTeachCaseEN.EthnicName = objDT.Rows[0][convMicroTeachCase.EthnicName].ToString().Trim(); //民族名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvMicroTeachCaseEN.UniZoneDesc = objDT.Rows[0][convMicroTeachCase.UniZoneDesc].ToString().Trim(); //校区名称(字段类型:varchar,字段长度:20,是否可空:False)
 objvMicroTeachCaseEN.StuTypeDesc = objDT.Rows[0][convMicroTeachCase.StuTypeDesc].ToString().Trim(); //学生类别名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroTeachCaseEN.IdXzCollege = objDT.Rows[0][convMicroTeachCase.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvMicroTeachCaseEN.CollegeID = objDT.Rows[0][convMicroTeachCase.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvMicroTeachCaseEN.CollegeName = objDT.Rows[0][convMicroTeachCase.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMicroTeachCaseEN.CollegeNameA = objDT.Rows[0][convMicroTeachCase.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvMicroTeachCaseEN.IdXzMajor = objDT.Rows[0][convMicroTeachCase.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMicroTeachCaseEN.MajorName = objDT.Rows[0][convMicroTeachCase.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMicroTeachCaseEN.IdGradeBase = objDT.Rows[0][convMicroTeachCase.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objvMicroTeachCaseEN.GradeBaseName = objDT.Rows[0][convMicroTeachCase.GradeBaseName].ToString().Trim(); //年级名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroTeachCaseEN.IdAdminCls = objDT.Rows[0][convMicroTeachCase.IdAdminCls].ToString().Trim(); //行政班流水号(字段类型:char,字段长度:8,是否可空:True)
 objvMicroTeachCaseEN.AdminClsId = objDT.Rows[0][convMicroTeachCase.AdminClsId].ToString().Trim(); //行政班代号(字段类型:varchar,字段长度:8,是否可空:True)
 objvMicroTeachCaseEN.AdminClsName = objDT.Rows[0][convMicroTeachCase.AdminClsName].ToString().Trim(); //行政班名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvMicroTeachCaseEN.Birthday = objDT.Rows[0][convMicroTeachCase.Birthday].ToString().Trim(); //出生日期(字段类型:char,字段长度:8,是否可空:True)
 objvMicroTeachCaseEN.NativePlace = objDT.Rows[0][convMicroTeachCase.NativePlace].ToString().Trim(); //籍贯(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroTeachCaseEN.Duty = objDT.Rows[0][convMicroTeachCase.Duty].ToString().Trim(); //职位(字段类型:varchar,字段长度:30,是否可空:True)
 objvMicroTeachCaseEN.IDCardNo = objDT.Rows[0][convMicroTeachCase.IDCardNo].ToString().Trim(); //身份证号(字段类型:varchar,字段长度:20,是否可空:True)
 objvMicroTeachCaseEN.StuCardNo = objDT.Rows[0][convMicroTeachCase.StuCardNo].ToString().Trim(); //学生证号(字段类型:varchar,字段长度:20,是否可空:True)
 objvMicroTeachCaseEN.LiveAddress = objDT.Rows[0][convMicroTeachCase.LiveAddress].ToString().Trim(); //居住地址(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroTeachCaseEN.HomePhone = objDT.Rows[0][convMicroTeachCase.HomePhone].ToString().Trim(); //住宅电话(字段类型:varchar,字段长度:20,是否可空:True)
 objvMicroTeachCaseEN.EnrollmentDate = objDT.Rows[0][convMicroTeachCase.EnrollmentDate].ToString().Trim(); //入校日期(字段类型:varchar,字段长度:8,是否可空:True)
 objvMicroTeachCaseEN.PostCode = objDT.Rows[0][convMicroTeachCase.PostCode].ToString().Trim(); //邮编(字段类型:char,字段长度:6,是否可空:True)
 objvMicroTeachCaseEN.IsDualVideo = TransNullToBool(objDT.Rows[0][convMicroTeachCase.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvMicroTeachCaseEN.UserKindId = objDT.Rows[0][convMicroTeachCase.UserKindId].ToString().Trim(); //用户类别Id(字段类型:char,字段长度:2,是否可空:False)
 objvMicroTeachCaseEN.UserKindName = objDT.Rows[0][convMicroTeachCase.UserKindName].ToString().Trim(); //用户类别名(字段类型:varchar,字段长度:30,是否可空:False)
 objvMicroTeachCaseEN.UserTypeId = objDT.Rows[0][convMicroTeachCase.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvMicroTeachCaseEN.UserTypeName = objDT.Rows[0][convMicroTeachCase.UserTypeName].ToString().Trim(); //用户类型名称(字段类型:varchar,字段长度:20,是否可空:True)
 objvMicroTeachCaseEN.RecommendedDegreeId = objDT.Rows[0][convMicroTeachCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvMicroTeachCaseEN.RecommendedDegreeName = objDT.Rows[0][convMicroTeachCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvMicroTeachCaseEN.ftpFileType = objDT.Rows[0][convMicroTeachCase.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvMicroTeachCaseEN.VideoUrl = objDT.Rows[0][convMicroTeachCase.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objvMicroTeachCaseEN.VideoPath = objDT.Rows[0][convMicroTeachCase.VideoPath].ToString().Trim(); //视频目录(字段类型:varchar,字段长度:1000,是否可空:True)
 objvMicroTeachCaseEN.ResErrMsg = objDT.Rows[0][convMicroTeachCase.ResErrMsg].ToString().Trim(); //资源错误信息(字段类型:varchar,字段长度:30,是否可空:True)
 objvMicroTeachCaseEN.Memo = objDT.Rows[0][convMicroTeachCase.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvMicroTeachCaseEN.IsHaveVideo = objDT.Rows[0][convMicroTeachCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo(字段类型:varchar,字段长度:6,是否可空:True)
 objvMicroTeachCaseEN.OwnerName = objDT.Rows[0][convMicroTeachCase.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvMicroTeachCaseEN.BrowseCount4Case = TransNullToInt(objDT.Rows[0][convMicroTeachCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvMicroTeachCaseDA: GetvMicroTeachCase)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdMicroteachCase">表关键字</param>
 /// <returns>表对象</returns>
public clsvMicroTeachCaseEN GetObjByIdMicroteachCase(string strIdMicroteachCase)
{
CheckPrimaryKey(strIdMicroteachCase);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroTeachCaseDA.GetSpecSQLObj();
strSQL = "Select * from vMicroTeachCase where IdMicroteachCase = " + "'"+ strIdMicroteachCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvMicroTeachCaseEN objvMicroTeachCaseEN = new clsvMicroTeachCaseEN();
try
{
 objvMicroTeachCaseEN.IdMicroteachCase = objRow[convMicroTeachCase.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMicroTeachCaseEN.MicroteachCaseID = objRow[convMicroTeachCase.MicroteachCaseID].ToString().Trim(); //微格教学案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvMicroTeachCaseEN.MicroteachCaseName = objRow[convMicroTeachCase.MicroteachCaseName].ToString().Trim(); //微格教学案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMicroTeachCaseEN.MicroteachCaseTheme = objRow[convMicroTeachCase.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroTeachCaseEN.MicroteachCaseDate = objRow[convMicroTeachCase.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseDate].ToString().Trim(); //微格教学日期(字段类型:char,字段长度:8,是否可空:True)
 objvMicroTeachCaseEN.MicroteachCaseTime = objRow[convMicroTeachCase.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseTime].ToString().Trim(); //微格教学时间(字段类型:char,字段长度:6,是否可空:True)
 objvMicroTeachCaseEN.MicroteachCaseDateIn = objRow[convMicroTeachCase.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvMicroTeachCaseEN.IdStudyLevel = objRow[convMicroTeachCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvMicroTeachCaseEN.StudyLevelName = objRow[convMicroTeachCase.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroTeachCaseEN.IdTeachingPlan = objRow[convMicroTeachCase.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMicroTeachCaseEN.MicroTeachCaseTimeIn = objRow[convMicroTeachCase.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvMicroTeachCaseEN.IdMicroteachCaseType = objRow[convMicroTeachCase.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMicroTeachCaseEN.MicroteachCaseTypeName = objRow[convMicroTeachCase.MicroteachCaseTypeName] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseTypeName].ToString().Trim(); //微格案例类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroTeachCaseEN.IdCaseType = objRow[convMicroTeachCase.IdCaseType].ToString().Trim(); //案例类型流水号(字段类型:char,字段长度:4,是否可空:True)
 objvMicroTeachCaseEN.IdDiscipline = objRow[convMicroTeachCase.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMicroTeachCaseEN.DisciplineID = objRow[convMicroTeachCase.DisciplineID] == DBNull.Value ? null : objRow[convMicroTeachCase.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvMicroTeachCaseEN.DisciplineName = objRow[convMicroTeachCase.DisciplineName] == DBNull.Value ? null : objRow[convMicroTeachCase.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroTeachCaseEN.IdSenateGaugeVersion = objRow[convMicroTeachCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMicroTeachCaseEN.senateGaugeVersionID = objRow[convMicroTeachCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvMicroTeachCaseEN.senateGaugeVersionName = objRow[convMicroTeachCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroTeachCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroTeachCaseEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convMicroTeachCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvMicroTeachCaseEN.VersionNo = objRow[convMicroTeachCase.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroTeachCase.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvMicroTeachCaseEN.IdTeachSkill = objRow[convMicroTeachCase.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMicroTeachCaseEN.TeachSkillID = objRow[convMicroTeachCase.TeachSkillID] == DBNull.Value ? null : objRow[convMicroTeachCase.TeachSkillID].ToString().Trim(); //教学技能ID(字段类型:char,字段长度:8,是否可空:False)
 objvMicroTeachCaseEN.SkillTypeName = objRow[convMicroTeachCase.SkillTypeName] == DBNull.Value ? null : objRow[convMicroTeachCase.SkillTypeName].ToString().Trim(); //技能类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroTeachCaseEN.TeachSkillName = objRow[convMicroTeachCase.TeachSkillName] == DBNull.Value ? null : objRow[convMicroTeachCase.TeachSkillName].ToString().Trim(); //教学技能名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroTeachCaseEN.TeachSkillTheory = objRow[convMicroTeachCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroTeachCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvMicroTeachCaseEN.TeachSkillOperMethod = objRow[convMicroTeachCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroTeachCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法(字段类型:varchar,字段长度:2000,是否可空:True)
 objvMicroTeachCaseEN.IdSkillType = objRow[convMicroTeachCase.IdSkillType] == DBNull.Value ? null : objRow[convMicroTeachCase.IdSkillType].ToString().Trim(); //技能类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMicroTeachCaseEN.SkillTypeID = objRow[convMicroTeachCase.SkillTypeID] == DBNull.Value ? null : objRow[convMicroTeachCase.SkillTypeID].ToString().Trim(); //技能类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvMicroTeachCaseEN.CaseLevelId = objRow[convMicroTeachCase.CaseLevelId] == DBNull.Value ? null : objRow[convMicroTeachCase.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvMicroTeachCaseEN.CaseLevelName = objRow[convMicroTeachCase.CaseLevelName] == DBNull.Value ? null : objRow[convMicroTeachCase.CaseLevelName].ToString().Trim(); //案例等级名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvMicroTeachCaseEN.DocFile = objRow[convMicroTeachCase.DocFile] == DBNull.Value ? null : objRow[convMicroTeachCase.DocFile].ToString().Trim(); //生成的Word文件名(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroTeachCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convMicroTeachCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word(字段类型:bit,字段长度:1,是否可空:True)
 objvMicroTeachCaseEN.WordCreateDate = objRow[convMicroTeachCase.WordCreateDate] == DBNull.Value ? null : objRow[convMicroTeachCase.WordCreateDate].ToString().Trim(); //Word生成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objvMicroTeachCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroTeachCase.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvMicroTeachCaseEN.microteachCaseText = objRow[convMicroTeachCase.microteachCaseText] == DBNull.Value ? null : objRow[convMicroTeachCase.microteachCaseText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objvMicroTeachCaseEN.OwnerId = objRow[convMicroTeachCase.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvMicroTeachCaseEN.IdStudentInfo = objRow[convMicroTeachCase.IdStudentInfo] == DBNull.Value ? null : objRow[convMicroTeachCase.IdStudentInfo].ToString().Trim(); //学生流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMicroTeachCaseEN.StuName = objRow[convMicroTeachCase.StuName].ToString().Trim(); //姓名(字段类型:varchar,字段长度:50,是否可空:True)
 objvMicroTeachCaseEN.StuID = objRow[convMicroTeachCase.StuID] == DBNull.Value ? null : objRow[convMicroTeachCase.StuID].ToString().Trim(); //学号(字段类型:varchar,字段长度:20,是否可空:True)
 objvMicroTeachCaseEN.PoliticsName = objRow[convMicroTeachCase.PoliticsName] == DBNull.Value ? null : objRow[convMicroTeachCase.PoliticsName].ToString().Trim(); //政治面貌(字段类型:varchar,字段长度:30,是否可空:False)
 objvMicroTeachCaseEN.SexDesc = objRow[convMicroTeachCase.SexDesc] == DBNull.Value ? null : objRow[convMicroTeachCase.SexDesc].ToString().Trim(); //性别名称(字段类型:varchar,字段长度:10,是否可空:True)
 objvMicroTeachCaseEN.EthnicName = objRow[convMicroTeachCase.EthnicName] == DBNull.Value ? null : objRow[convMicroTeachCase.EthnicName].ToString().Trim(); //民族名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvMicroTeachCaseEN.UniZoneDesc = objRow[convMicroTeachCase.UniZoneDesc] == DBNull.Value ? null : objRow[convMicroTeachCase.UniZoneDesc].ToString().Trim(); //校区名称(字段类型:varchar,字段长度:20,是否可空:False)
 objvMicroTeachCaseEN.StuTypeDesc = objRow[convMicroTeachCase.StuTypeDesc] == DBNull.Value ? null : objRow[convMicroTeachCase.StuTypeDesc].ToString().Trim(); //学生类别名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroTeachCaseEN.IdXzCollege = objRow[convMicroTeachCase.IdXzCollege] == DBNull.Value ? null : objRow[convMicroTeachCase.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvMicroTeachCaseEN.CollegeID = objRow[convMicroTeachCase.CollegeID] == DBNull.Value ? null : objRow[convMicroTeachCase.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvMicroTeachCaseEN.CollegeName = objRow[convMicroTeachCase.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMicroTeachCaseEN.CollegeNameA = objRow[convMicroTeachCase.CollegeNameA] == DBNull.Value ? null : objRow[convMicroTeachCase.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvMicroTeachCaseEN.IdXzMajor = objRow[convMicroTeachCase.IdXzMajor] == DBNull.Value ? null : objRow[convMicroTeachCase.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMicroTeachCaseEN.MajorName = objRow[convMicroTeachCase.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMicroTeachCaseEN.IdGradeBase = objRow[convMicroTeachCase.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objvMicroTeachCaseEN.GradeBaseName = objRow[convMicroTeachCase.GradeBaseName] == DBNull.Value ? null : objRow[convMicroTeachCase.GradeBaseName].ToString().Trim(); //年级名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroTeachCaseEN.IdAdminCls = objRow[convMicroTeachCase.IdAdminCls] == DBNull.Value ? null : objRow[convMicroTeachCase.IdAdminCls].ToString().Trim(); //行政班流水号(字段类型:char,字段长度:8,是否可空:True)
 objvMicroTeachCaseEN.AdminClsId = objRow[convMicroTeachCase.AdminClsId] == DBNull.Value ? null : objRow[convMicroTeachCase.AdminClsId].ToString().Trim(); //行政班代号(字段类型:varchar,字段长度:8,是否可空:True)
 objvMicroTeachCaseEN.AdminClsName = objRow[convMicroTeachCase.AdminClsName] == DBNull.Value ? null : objRow[convMicroTeachCase.AdminClsName].ToString().Trim(); //行政班名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvMicroTeachCaseEN.Birthday = objRow[convMicroTeachCase.Birthday] == DBNull.Value ? null : objRow[convMicroTeachCase.Birthday].ToString().Trim(); //出生日期(字段类型:char,字段长度:8,是否可空:True)
 objvMicroTeachCaseEN.NativePlace = objRow[convMicroTeachCase.NativePlace] == DBNull.Value ? null : objRow[convMicroTeachCase.NativePlace].ToString().Trim(); //籍贯(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroTeachCaseEN.Duty = objRow[convMicroTeachCase.Duty] == DBNull.Value ? null : objRow[convMicroTeachCase.Duty].ToString().Trim(); //职位(字段类型:varchar,字段长度:30,是否可空:True)
 objvMicroTeachCaseEN.IDCardNo = objRow[convMicroTeachCase.IDCardNo] == DBNull.Value ? null : objRow[convMicroTeachCase.IDCardNo].ToString().Trim(); //身份证号(字段类型:varchar,字段长度:20,是否可空:True)
 objvMicroTeachCaseEN.StuCardNo = objRow[convMicroTeachCase.StuCardNo] == DBNull.Value ? null : objRow[convMicroTeachCase.StuCardNo].ToString().Trim(); //学生证号(字段类型:varchar,字段长度:20,是否可空:True)
 objvMicroTeachCaseEN.LiveAddress = objRow[convMicroTeachCase.LiveAddress] == DBNull.Value ? null : objRow[convMicroTeachCase.LiveAddress].ToString().Trim(); //居住地址(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroTeachCaseEN.HomePhone = objRow[convMicroTeachCase.HomePhone] == DBNull.Value ? null : objRow[convMicroTeachCase.HomePhone].ToString().Trim(); //住宅电话(字段类型:varchar,字段长度:20,是否可空:True)
 objvMicroTeachCaseEN.EnrollmentDate = objRow[convMicroTeachCase.EnrollmentDate] == DBNull.Value ? null : objRow[convMicroTeachCase.EnrollmentDate].ToString().Trim(); //入校日期(字段类型:varchar,字段长度:8,是否可空:True)
 objvMicroTeachCaseEN.PostCode = objRow[convMicroTeachCase.PostCode] == DBNull.Value ? null : objRow[convMicroTeachCase.PostCode].ToString().Trim(); //邮编(字段类型:char,字段长度:6,是否可空:True)
 objvMicroTeachCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convMicroTeachCase.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvMicroTeachCaseEN.UserKindId = objRow[convMicroTeachCase.UserKindId].ToString().Trim(); //用户类别Id(字段类型:char,字段长度:2,是否可空:False)
 objvMicroTeachCaseEN.UserKindName = objRow[convMicroTeachCase.UserKindName] == DBNull.Value ? null : objRow[convMicroTeachCase.UserKindName].ToString().Trim(); //用户类别名(字段类型:varchar,字段长度:30,是否可空:False)
 objvMicroTeachCaseEN.UserTypeId = objRow[convMicroTeachCase.UserTypeId] == DBNull.Value ? null : objRow[convMicroTeachCase.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvMicroTeachCaseEN.UserTypeName = objRow[convMicroTeachCase.UserTypeName] == DBNull.Value ? null : objRow[convMicroTeachCase.UserTypeName].ToString().Trim(); //用户类型名称(字段类型:varchar,字段长度:20,是否可空:True)
 objvMicroTeachCaseEN.RecommendedDegreeId = objRow[convMicroTeachCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvMicroTeachCaseEN.RecommendedDegreeName = objRow[convMicroTeachCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroTeachCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvMicroTeachCaseEN.ftpFileType = objRow[convMicroTeachCase.ftpFileType] == DBNull.Value ? null : objRow[convMicroTeachCase.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvMicroTeachCaseEN.VideoUrl = objRow[convMicroTeachCase.VideoUrl] == DBNull.Value ? null : objRow[convMicroTeachCase.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objvMicroTeachCaseEN.VideoPath = objRow[convMicroTeachCase.VideoPath] == DBNull.Value ? null : objRow[convMicroTeachCase.VideoPath].ToString().Trim(); //视频目录(字段类型:varchar,字段长度:1000,是否可空:True)
 objvMicroTeachCaseEN.ResErrMsg = objRow[convMicroTeachCase.ResErrMsg] == DBNull.Value ? null : objRow[convMicroTeachCase.ResErrMsg].ToString().Trim(); //资源错误信息(字段类型:varchar,字段长度:30,是否可空:True)
 objvMicroTeachCaseEN.Memo = objRow[convMicroTeachCase.Memo] == DBNull.Value ? null : objRow[convMicroTeachCase.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvMicroTeachCaseEN.IsHaveVideo = objRow[convMicroTeachCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo(字段类型:varchar,字段长度:6,是否可空:True)
 objvMicroTeachCaseEN.OwnerName = objRow[convMicroTeachCase.OwnerName] == DBNull.Value ? null : objRow[convMicroTeachCase.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvMicroTeachCaseEN.BrowseCount4Case = objRow[convMicroTeachCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroTeachCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvMicroTeachCaseDA: GetObjByIdMicroteachCase)", objException.Message));
}
return objvMicroTeachCaseEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvMicroTeachCaseEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvMicroTeachCaseDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroTeachCaseDA.GetSpecSQLObj();
strSQL = "Select * from vMicroTeachCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvMicroTeachCaseEN objvMicroTeachCaseEN = new clsvMicroTeachCaseEN()
{
IdMicroteachCase = objRow[convMicroTeachCase.IdMicroteachCase].ToString().Trim(), //微格教学案例流水号
MicroteachCaseID = objRow[convMicroTeachCase.MicroteachCaseID].ToString().Trim(), //微格教学案例ID
MicroteachCaseName = objRow[convMicroTeachCase.MicroteachCaseName].ToString().Trim(), //微格教学案例名称
MicroteachCaseTheme = objRow[convMicroTeachCase.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseTheme].ToString().Trim(), //微格教学案例主题词
MicroteachCaseDate = objRow[convMicroTeachCase.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseDate].ToString().Trim(), //微格教学日期
MicroteachCaseTime = objRow[convMicroTeachCase.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseTime].ToString().Trim(), //微格教学时间
MicroteachCaseDateIn = objRow[convMicroTeachCase.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseDateIn].ToString().Trim(), //案例入库日期
IdStudyLevel = objRow[convMicroTeachCase.IdStudyLevel].ToString().Trim(), //id_StudyLevel
StudyLevelName = objRow[convMicroTeachCase.StudyLevelName].ToString().Trim(), //学段名称
IdTeachingPlan = objRow[convMicroTeachCase.IdTeachingPlan].ToString().Trim(), //教案流水号
MicroTeachCaseTimeIn = objRow[convMicroTeachCase.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroTeachCaseTimeIn].ToString().Trim(), //案例入库时间
IdMicroteachCaseType = objRow[convMicroTeachCase.IdMicroteachCaseType].ToString().Trim(), //微格案例类型流水号
MicroteachCaseTypeName = objRow[convMicroTeachCase.MicroteachCaseTypeName] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseTypeName].ToString().Trim(), //微格案例类型名称
IdCaseType = objRow[convMicroTeachCase.IdCaseType].ToString().Trim(), //案例类型流水号
IdDiscipline = objRow[convMicroTeachCase.IdDiscipline].ToString().Trim(), //学科流水号
DisciplineID = objRow[convMicroTeachCase.DisciplineID] == DBNull.Value ? null : objRow[convMicroTeachCase.DisciplineID].ToString().Trim(), //学科ID
DisciplineName = objRow[convMicroTeachCase.DisciplineName] == DBNull.Value ? null : objRow[convMicroTeachCase.DisciplineName].ToString().Trim(), //学科名称
IdSenateGaugeVersion = objRow[convMicroTeachCase.IdSenateGaugeVersion].ToString().Trim(), //评价量表版本流水号
senateGaugeVersionID = objRow[convMicroTeachCase.senateGaugeVersionID].ToString().Trim(), //评价量表版本ID
senateGaugeVersionName = objRow[convMicroTeachCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroTeachCase.senateGaugeVersionName].ToString().Trim(), //评价量表版本名称
senateGaugeVersionTtlScore = TransNullToFloat(objRow[convMicroTeachCase.senateGaugeVersionTtlScore].ToString().Trim()), //评价量表版本总分
VersionNo = objRow[convMicroTeachCase.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroTeachCase.VersionNo].ToString().Trim()), //版本号
IdTeachSkill = objRow[convMicroTeachCase.IdTeachSkill].ToString().Trim(), //教学技能流水号
TeachSkillID = objRow[convMicroTeachCase.TeachSkillID] == DBNull.Value ? null : objRow[convMicroTeachCase.TeachSkillID].ToString().Trim(), //教学技能ID
SkillTypeName = objRow[convMicroTeachCase.SkillTypeName] == DBNull.Value ? null : objRow[convMicroTeachCase.SkillTypeName].ToString().Trim(), //技能类型名称
TeachSkillName = objRow[convMicroTeachCase.TeachSkillName] == DBNull.Value ? null : objRow[convMicroTeachCase.TeachSkillName].ToString().Trim(), //教学技能名称
TeachSkillTheory = objRow[convMicroTeachCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroTeachCase.TeachSkillTheory].ToString().Trim(), //教学技能理论阐述
TeachSkillOperMethod = objRow[convMicroTeachCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroTeachCase.TeachSkillOperMethod].ToString().Trim(), //教学技能实践操作方法
IdSkillType = objRow[convMicroTeachCase.IdSkillType] == DBNull.Value ? null : objRow[convMicroTeachCase.IdSkillType].ToString().Trim(), //技能类型流水号
SkillTypeID = objRow[convMicroTeachCase.SkillTypeID] == DBNull.Value ? null : objRow[convMicroTeachCase.SkillTypeID].ToString().Trim(), //技能类型ID
CaseLevelId = objRow[convMicroTeachCase.CaseLevelId] == DBNull.Value ? null : objRow[convMicroTeachCase.CaseLevelId].ToString().Trim(), //课例等级Id
CaseLevelName = objRow[convMicroTeachCase.CaseLevelName] == DBNull.Value ? null : objRow[convMicroTeachCase.CaseLevelName].ToString().Trim(), //案例等级名称
DocFile = objRow[convMicroTeachCase.DocFile] == DBNull.Value ? null : objRow[convMicroTeachCase.DocFile].ToString().Trim(), //生成的Word文件名
IsNeedGeneWord = TransNullToBool(objRow[convMicroTeachCase.IsNeedGeneWord].ToString().Trim()), //是否需要生成Word
WordCreateDate = objRow[convMicroTeachCase.WordCreateDate] == DBNull.Value ? null : objRow[convMicroTeachCase.WordCreateDate].ToString().Trim(), //Word生成日期
IsVisible = TransNullToBool(objRow[convMicroTeachCase.IsVisible].ToString().Trim()), //是否显示
microteachCaseText = objRow[convMicroTeachCase.microteachCaseText] == DBNull.Value ? null : objRow[convMicroTeachCase.microteachCaseText].ToString().Trim(), //案例文本内容
OwnerId = objRow[convMicroTeachCase.OwnerId].ToString().Trim(), //拥有者Id
IdStudentInfo = objRow[convMicroTeachCase.IdStudentInfo] == DBNull.Value ? null : objRow[convMicroTeachCase.IdStudentInfo].ToString().Trim(), //学生流水号
StuName = objRow[convMicroTeachCase.StuName].ToString().Trim(), //姓名
StuID = objRow[convMicroTeachCase.StuID] == DBNull.Value ? null : objRow[convMicroTeachCase.StuID].ToString().Trim(), //学号
PoliticsName = objRow[convMicroTeachCase.PoliticsName] == DBNull.Value ? null : objRow[convMicroTeachCase.PoliticsName].ToString().Trim(), //政治面貌
SexDesc = objRow[convMicroTeachCase.SexDesc] == DBNull.Value ? null : objRow[convMicroTeachCase.SexDesc].ToString().Trim(), //性别名称
EthnicName = objRow[convMicroTeachCase.EthnicName] == DBNull.Value ? null : objRow[convMicroTeachCase.EthnicName].ToString().Trim(), //民族名称
UniZoneDesc = objRow[convMicroTeachCase.UniZoneDesc] == DBNull.Value ? null : objRow[convMicroTeachCase.UniZoneDesc].ToString().Trim(), //校区名称
StuTypeDesc = objRow[convMicroTeachCase.StuTypeDesc] == DBNull.Value ? null : objRow[convMicroTeachCase.StuTypeDesc].ToString().Trim(), //学生类别名称
IdXzCollege = objRow[convMicroTeachCase.IdXzCollege] == DBNull.Value ? null : objRow[convMicroTeachCase.IdXzCollege].ToString().Trim(), //学院流水号
CollegeID = objRow[convMicroTeachCase.CollegeID] == DBNull.Value ? null : objRow[convMicroTeachCase.CollegeID].ToString().Trim(), //学院ID
CollegeName = objRow[convMicroTeachCase.CollegeName].ToString().Trim(), //学院名称
CollegeNameA = objRow[convMicroTeachCase.CollegeNameA] == DBNull.Value ? null : objRow[convMicroTeachCase.CollegeNameA].ToString().Trim(), //学院名称简写
IdXzMajor = objRow[convMicroTeachCase.IdXzMajor] == DBNull.Value ? null : objRow[convMicroTeachCase.IdXzMajor].ToString().Trim(), //专业流水号
MajorName = objRow[convMicroTeachCase.MajorName].ToString().Trim(), //专业名称
IdGradeBase = objRow[convMicroTeachCase.IdGradeBase].ToString().Trim(), //年级流水号
GradeBaseName = objRow[convMicroTeachCase.GradeBaseName] == DBNull.Value ? null : objRow[convMicroTeachCase.GradeBaseName].ToString().Trim(), //年级名称
IdAdminCls = objRow[convMicroTeachCase.IdAdminCls] == DBNull.Value ? null : objRow[convMicroTeachCase.IdAdminCls].ToString().Trim(), //行政班流水号
AdminClsId = objRow[convMicroTeachCase.AdminClsId] == DBNull.Value ? null : objRow[convMicroTeachCase.AdminClsId].ToString().Trim(), //行政班代号
AdminClsName = objRow[convMicroTeachCase.AdminClsName] == DBNull.Value ? null : objRow[convMicroTeachCase.AdminClsName].ToString().Trim(), //行政班名称
Birthday = objRow[convMicroTeachCase.Birthday] == DBNull.Value ? null : objRow[convMicroTeachCase.Birthday].ToString().Trim(), //出生日期
NativePlace = objRow[convMicroTeachCase.NativePlace] == DBNull.Value ? null : objRow[convMicroTeachCase.NativePlace].ToString().Trim(), //籍贯
Duty = objRow[convMicroTeachCase.Duty] == DBNull.Value ? null : objRow[convMicroTeachCase.Duty].ToString().Trim(), //职位
IDCardNo = objRow[convMicroTeachCase.IDCardNo] == DBNull.Value ? null : objRow[convMicroTeachCase.IDCardNo].ToString().Trim(), //身份证号
StuCardNo = objRow[convMicroTeachCase.StuCardNo] == DBNull.Value ? null : objRow[convMicroTeachCase.StuCardNo].ToString().Trim(), //学生证号
LiveAddress = objRow[convMicroTeachCase.LiveAddress] == DBNull.Value ? null : objRow[convMicroTeachCase.LiveAddress].ToString().Trim(), //居住地址
HomePhone = objRow[convMicroTeachCase.HomePhone] == DBNull.Value ? null : objRow[convMicroTeachCase.HomePhone].ToString().Trim(), //住宅电话
EnrollmentDate = objRow[convMicroTeachCase.EnrollmentDate] == DBNull.Value ? null : objRow[convMicroTeachCase.EnrollmentDate].ToString().Trim(), //入校日期
PostCode = objRow[convMicroTeachCase.PostCode] == DBNull.Value ? null : objRow[convMicroTeachCase.PostCode].ToString().Trim(), //邮编
IsDualVideo = TransNullToBool(objRow[convMicroTeachCase.IsDualVideo].ToString().Trim()), //是否双视频
UserKindId = objRow[convMicroTeachCase.UserKindId].ToString().Trim(), //用户类别Id
UserKindName = objRow[convMicroTeachCase.UserKindName] == DBNull.Value ? null : objRow[convMicroTeachCase.UserKindName].ToString().Trim(), //用户类别名
UserTypeId = objRow[convMicroTeachCase.UserTypeId] == DBNull.Value ? null : objRow[convMicroTeachCase.UserTypeId].ToString().Trim(), //用户类型Id
UserTypeName = objRow[convMicroTeachCase.UserTypeName] == DBNull.Value ? null : objRow[convMicroTeachCase.UserTypeName].ToString().Trim(), //用户类型名称
RecommendedDegreeId = objRow[convMicroTeachCase.RecommendedDegreeId].ToString().Trim(), //推荐度Id
RecommendedDegreeName = objRow[convMicroTeachCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroTeachCase.RecommendedDegreeName].ToString().Trim(), //推荐度名称
ftpFileType = objRow[convMicroTeachCase.ftpFileType] == DBNull.Value ? null : objRow[convMicroTeachCase.ftpFileType].ToString().Trim(), //ftp文件类型
VideoUrl = objRow[convMicroTeachCase.VideoUrl] == DBNull.Value ? null : objRow[convMicroTeachCase.VideoUrl].ToString().Trim(), //视频Url
VideoPath = objRow[convMicroTeachCase.VideoPath] == DBNull.Value ? null : objRow[convMicroTeachCase.VideoPath].ToString().Trim(), //视频目录
ResErrMsg = objRow[convMicroTeachCase.ResErrMsg] == DBNull.Value ? null : objRow[convMicroTeachCase.ResErrMsg].ToString().Trim(), //资源错误信息
Memo = objRow[convMicroTeachCase.Memo] == DBNull.Value ? null : objRow[convMicroTeachCase.Memo].ToString().Trim(), //备注
IsHaveVideo = objRow[convMicroTeachCase.IsHaveVideo].ToString().Trim(), //IsHaveVideo
OwnerName = objRow[convMicroTeachCase.OwnerName] == DBNull.Value ? null : objRow[convMicroTeachCase.OwnerName].ToString().Trim(), //拥有者姓名
BrowseCount4Case = objRow[convMicroTeachCase.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroTeachCase.BrowseCount4Case].ToString().Trim()) //课例浏览次数
};
objvMicroTeachCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvMicroTeachCaseEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvMicroTeachCaseDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvMicroTeachCaseEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvMicroTeachCaseEN objvMicroTeachCaseEN = new clsvMicroTeachCaseEN();
try
{
objvMicroTeachCaseEN.IdMicroteachCase = objRow[convMicroTeachCase.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroTeachCaseEN.MicroteachCaseID = objRow[convMicroTeachCase.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroTeachCaseEN.MicroteachCaseName = objRow[convMicroTeachCase.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroTeachCaseEN.MicroteachCaseTheme = objRow[convMicroTeachCase.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroTeachCaseEN.MicroteachCaseDate = objRow[convMicroTeachCase.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroTeachCaseEN.MicroteachCaseTime = objRow[convMicroTeachCase.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroTeachCaseEN.MicroteachCaseDateIn = objRow[convMicroTeachCase.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroTeachCaseEN.IdStudyLevel = objRow[convMicroTeachCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroTeachCaseEN.StudyLevelName = objRow[convMicroTeachCase.StudyLevelName].ToString().Trim(); //学段名称
objvMicroTeachCaseEN.IdTeachingPlan = objRow[convMicroTeachCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroTeachCaseEN.MicroTeachCaseTimeIn = objRow[convMicroTeachCase.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroTeachCaseEN.IdMicroteachCaseType = objRow[convMicroTeachCase.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号
objvMicroTeachCaseEN.MicroteachCaseTypeName = objRow[convMicroTeachCase.MicroteachCaseTypeName] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseTypeName].ToString().Trim(); //微格案例类型名称
objvMicroTeachCaseEN.IdCaseType = objRow[convMicroTeachCase.IdCaseType].ToString().Trim(); //案例类型流水号
objvMicroTeachCaseEN.IdDiscipline = objRow[convMicroTeachCase.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroTeachCaseEN.DisciplineID = objRow[convMicroTeachCase.DisciplineID] == DBNull.Value ? null : objRow[convMicroTeachCase.DisciplineID].ToString().Trim(); //学科ID
objvMicroTeachCaseEN.DisciplineName = objRow[convMicroTeachCase.DisciplineName] == DBNull.Value ? null : objRow[convMicroTeachCase.DisciplineName].ToString().Trim(); //学科名称
objvMicroTeachCaseEN.IdSenateGaugeVersion = objRow[convMicroTeachCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMicroTeachCaseEN.senateGaugeVersionID = objRow[convMicroTeachCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroTeachCaseEN.senateGaugeVersionName = objRow[convMicroTeachCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroTeachCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroTeachCaseEN.senateGaugeVersionTtlScore = TransNullToFloat(objRow[convMicroTeachCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroTeachCaseEN.VersionNo = objRow[convMicroTeachCase.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroTeachCase.VersionNo].ToString().Trim()); //版本号
objvMicroTeachCaseEN.IdTeachSkill = objRow[convMicroTeachCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroTeachCaseEN.TeachSkillID = objRow[convMicroTeachCase.TeachSkillID] == DBNull.Value ? null : objRow[convMicroTeachCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroTeachCaseEN.SkillTypeName = objRow[convMicroTeachCase.SkillTypeName] == DBNull.Value ? null : objRow[convMicroTeachCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroTeachCaseEN.TeachSkillName = objRow[convMicroTeachCase.TeachSkillName] == DBNull.Value ? null : objRow[convMicroTeachCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroTeachCaseEN.TeachSkillTheory = objRow[convMicroTeachCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroTeachCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroTeachCaseEN.TeachSkillOperMethod = objRow[convMicroTeachCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroTeachCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroTeachCaseEN.IdSkillType = objRow[convMicroTeachCase.IdSkillType] == DBNull.Value ? null : objRow[convMicroTeachCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroTeachCaseEN.SkillTypeID = objRow[convMicroTeachCase.SkillTypeID] == DBNull.Value ? null : objRow[convMicroTeachCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroTeachCaseEN.CaseLevelId = objRow[convMicroTeachCase.CaseLevelId] == DBNull.Value ? null : objRow[convMicroTeachCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroTeachCaseEN.CaseLevelName = objRow[convMicroTeachCase.CaseLevelName] == DBNull.Value ? null : objRow[convMicroTeachCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvMicroTeachCaseEN.DocFile = objRow[convMicroTeachCase.DocFile] == DBNull.Value ? null : objRow[convMicroTeachCase.DocFile].ToString().Trim(); //生成的Word文件名
objvMicroTeachCaseEN.IsNeedGeneWord = TransNullToBool(objRow[convMicroTeachCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvMicroTeachCaseEN.WordCreateDate = objRow[convMicroTeachCase.WordCreateDate] == DBNull.Value ? null : objRow[convMicroTeachCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvMicroTeachCaseEN.IsVisible = TransNullToBool(objRow[convMicroTeachCase.IsVisible].ToString().Trim()); //是否显示
objvMicroTeachCaseEN.microteachCaseText = objRow[convMicroTeachCase.microteachCaseText] == DBNull.Value ? null : objRow[convMicroTeachCase.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroTeachCaseEN.OwnerId = objRow[convMicroTeachCase.OwnerId].ToString().Trim(); //拥有者Id
objvMicroTeachCaseEN.IdStudentInfo = objRow[convMicroTeachCase.IdStudentInfo] == DBNull.Value ? null : objRow[convMicroTeachCase.IdStudentInfo].ToString().Trim(); //学生流水号
objvMicroTeachCaseEN.StuName = objRow[convMicroTeachCase.StuName].ToString().Trim(); //姓名
objvMicroTeachCaseEN.StuID = objRow[convMicroTeachCase.StuID] == DBNull.Value ? null : objRow[convMicroTeachCase.StuID].ToString().Trim(); //学号
objvMicroTeachCaseEN.PoliticsName = objRow[convMicroTeachCase.PoliticsName] == DBNull.Value ? null : objRow[convMicroTeachCase.PoliticsName].ToString().Trim(); //政治面貌
objvMicroTeachCaseEN.SexDesc = objRow[convMicroTeachCase.SexDesc] == DBNull.Value ? null : objRow[convMicroTeachCase.SexDesc].ToString().Trim(); //性别名称
objvMicroTeachCaseEN.EthnicName = objRow[convMicroTeachCase.EthnicName] == DBNull.Value ? null : objRow[convMicroTeachCase.EthnicName].ToString().Trim(); //民族名称
objvMicroTeachCaseEN.UniZoneDesc = objRow[convMicroTeachCase.UniZoneDesc] == DBNull.Value ? null : objRow[convMicroTeachCase.UniZoneDesc].ToString().Trim(); //校区名称
objvMicroTeachCaseEN.StuTypeDesc = objRow[convMicroTeachCase.StuTypeDesc] == DBNull.Value ? null : objRow[convMicroTeachCase.StuTypeDesc].ToString().Trim(); //学生类别名称
objvMicroTeachCaseEN.IdXzCollege = objRow[convMicroTeachCase.IdXzCollege] == DBNull.Value ? null : objRow[convMicroTeachCase.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroTeachCaseEN.CollegeID = objRow[convMicroTeachCase.CollegeID] == DBNull.Value ? null : objRow[convMicroTeachCase.CollegeID].ToString().Trim(); //学院ID
objvMicroTeachCaseEN.CollegeName = objRow[convMicroTeachCase.CollegeName].ToString().Trim(); //学院名称
objvMicroTeachCaseEN.CollegeNameA = objRow[convMicroTeachCase.CollegeNameA] == DBNull.Value ? null : objRow[convMicroTeachCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvMicroTeachCaseEN.IdXzMajor = objRow[convMicroTeachCase.IdXzMajor] == DBNull.Value ? null : objRow[convMicroTeachCase.IdXzMajor].ToString().Trim(); //专业流水号
objvMicroTeachCaseEN.MajorName = objRow[convMicroTeachCase.MajorName].ToString().Trim(); //专业名称
objvMicroTeachCaseEN.IdGradeBase = objRow[convMicroTeachCase.IdGradeBase].ToString().Trim(); //年级流水号
objvMicroTeachCaseEN.GradeBaseName = objRow[convMicroTeachCase.GradeBaseName] == DBNull.Value ? null : objRow[convMicroTeachCase.GradeBaseName].ToString().Trim(); //年级名称
objvMicroTeachCaseEN.IdAdminCls = objRow[convMicroTeachCase.IdAdminCls] == DBNull.Value ? null : objRow[convMicroTeachCase.IdAdminCls].ToString().Trim(); //行政班流水号
objvMicroTeachCaseEN.AdminClsId = objRow[convMicroTeachCase.AdminClsId] == DBNull.Value ? null : objRow[convMicroTeachCase.AdminClsId].ToString().Trim(); //行政班代号
objvMicroTeachCaseEN.AdminClsName = objRow[convMicroTeachCase.AdminClsName] == DBNull.Value ? null : objRow[convMicroTeachCase.AdminClsName].ToString().Trim(); //行政班名称
objvMicroTeachCaseEN.Birthday = objRow[convMicroTeachCase.Birthday] == DBNull.Value ? null : objRow[convMicroTeachCase.Birthday].ToString().Trim(); //出生日期
objvMicroTeachCaseEN.NativePlace = objRow[convMicroTeachCase.NativePlace] == DBNull.Value ? null : objRow[convMicroTeachCase.NativePlace].ToString().Trim(); //籍贯
objvMicroTeachCaseEN.Duty = objRow[convMicroTeachCase.Duty] == DBNull.Value ? null : objRow[convMicroTeachCase.Duty].ToString().Trim(); //职位
objvMicroTeachCaseEN.IDCardNo = objRow[convMicroTeachCase.IDCardNo] == DBNull.Value ? null : objRow[convMicroTeachCase.IDCardNo].ToString().Trim(); //身份证号
objvMicroTeachCaseEN.StuCardNo = objRow[convMicroTeachCase.StuCardNo] == DBNull.Value ? null : objRow[convMicroTeachCase.StuCardNo].ToString().Trim(); //学生证号
objvMicroTeachCaseEN.LiveAddress = objRow[convMicroTeachCase.LiveAddress] == DBNull.Value ? null : objRow[convMicroTeachCase.LiveAddress].ToString().Trim(); //居住地址
objvMicroTeachCaseEN.HomePhone = objRow[convMicroTeachCase.HomePhone] == DBNull.Value ? null : objRow[convMicroTeachCase.HomePhone].ToString().Trim(); //住宅电话
objvMicroTeachCaseEN.EnrollmentDate = objRow[convMicroTeachCase.EnrollmentDate] == DBNull.Value ? null : objRow[convMicroTeachCase.EnrollmentDate].ToString().Trim(); //入校日期
objvMicroTeachCaseEN.PostCode = objRow[convMicroTeachCase.PostCode] == DBNull.Value ? null : objRow[convMicroTeachCase.PostCode].ToString().Trim(); //邮编
objvMicroTeachCaseEN.IsDualVideo = TransNullToBool(objRow[convMicroTeachCase.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroTeachCaseEN.UserKindId = objRow[convMicroTeachCase.UserKindId].ToString().Trim(); //用户类别Id
objvMicroTeachCaseEN.UserKindName = objRow[convMicroTeachCase.UserKindName] == DBNull.Value ? null : objRow[convMicroTeachCase.UserKindName].ToString().Trim(); //用户类别名
objvMicroTeachCaseEN.UserTypeId = objRow[convMicroTeachCase.UserTypeId] == DBNull.Value ? null : objRow[convMicroTeachCase.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroTeachCaseEN.UserTypeName = objRow[convMicroTeachCase.UserTypeName] == DBNull.Value ? null : objRow[convMicroTeachCase.UserTypeName].ToString().Trim(); //用户类型名称
objvMicroTeachCaseEN.RecommendedDegreeId = objRow[convMicroTeachCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroTeachCaseEN.RecommendedDegreeName = objRow[convMicroTeachCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroTeachCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroTeachCaseEN.ftpFileType = objRow[convMicroTeachCase.ftpFileType] == DBNull.Value ? null : objRow[convMicroTeachCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroTeachCaseEN.VideoUrl = objRow[convMicroTeachCase.VideoUrl] == DBNull.Value ? null : objRow[convMicroTeachCase.VideoUrl].ToString().Trim(); //视频Url
objvMicroTeachCaseEN.VideoPath = objRow[convMicroTeachCase.VideoPath] == DBNull.Value ? null : objRow[convMicroTeachCase.VideoPath].ToString().Trim(); //视频目录
objvMicroTeachCaseEN.ResErrMsg = objRow[convMicroTeachCase.ResErrMsg] == DBNull.Value ? null : objRow[convMicroTeachCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvMicroTeachCaseEN.Memo = objRow[convMicroTeachCase.Memo] == DBNull.Value ? null : objRow[convMicroTeachCase.Memo].ToString().Trim(); //备注
objvMicroTeachCaseEN.IsHaveVideo = objRow[convMicroTeachCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
objvMicroTeachCaseEN.OwnerName = objRow[convMicroTeachCase.OwnerName] == DBNull.Value ? null : objRow[convMicroTeachCase.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroTeachCaseEN.BrowseCount4Case = objRow[convMicroTeachCase.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroTeachCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvMicroTeachCaseDA: GetObjByDataRowvMicroTeachCase)", objException.Message));
}
objvMicroTeachCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvMicroTeachCaseEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvMicroTeachCaseEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvMicroTeachCaseEN objvMicroTeachCaseEN = new clsvMicroTeachCaseEN();
try
{
objvMicroTeachCaseEN.IdMicroteachCase = objRow[convMicroTeachCase.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroTeachCaseEN.MicroteachCaseID = objRow[convMicroTeachCase.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroTeachCaseEN.MicroteachCaseName = objRow[convMicroTeachCase.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroTeachCaseEN.MicroteachCaseTheme = objRow[convMicroTeachCase.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroTeachCaseEN.MicroteachCaseDate = objRow[convMicroTeachCase.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroTeachCaseEN.MicroteachCaseTime = objRow[convMicroTeachCase.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroTeachCaseEN.MicroteachCaseDateIn = objRow[convMicroTeachCase.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroTeachCaseEN.IdStudyLevel = objRow[convMicroTeachCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroTeachCaseEN.StudyLevelName = objRow[convMicroTeachCase.StudyLevelName].ToString().Trim(); //学段名称
objvMicroTeachCaseEN.IdTeachingPlan = objRow[convMicroTeachCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroTeachCaseEN.MicroTeachCaseTimeIn = objRow[convMicroTeachCase.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroTeachCaseEN.IdMicroteachCaseType = objRow[convMicroTeachCase.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号
objvMicroTeachCaseEN.MicroteachCaseTypeName = objRow[convMicroTeachCase.MicroteachCaseTypeName] == DBNull.Value ? null : objRow[convMicroTeachCase.MicroteachCaseTypeName].ToString().Trim(); //微格案例类型名称
objvMicroTeachCaseEN.IdCaseType = objRow[convMicroTeachCase.IdCaseType].ToString().Trim(); //案例类型流水号
objvMicroTeachCaseEN.IdDiscipline = objRow[convMicroTeachCase.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroTeachCaseEN.DisciplineID = objRow[convMicroTeachCase.DisciplineID] == DBNull.Value ? null : objRow[convMicroTeachCase.DisciplineID].ToString().Trim(); //学科ID
objvMicroTeachCaseEN.DisciplineName = objRow[convMicroTeachCase.DisciplineName] == DBNull.Value ? null : objRow[convMicroTeachCase.DisciplineName].ToString().Trim(); //学科名称
objvMicroTeachCaseEN.IdSenateGaugeVersion = objRow[convMicroTeachCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMicroTeachCaseEN.senateGaugeVersionID = objRow[convMicroTeachCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroTeachCaseEN.senateGaugeVersionName = objRow[convMicroTeachCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroTeachCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroTeachCaseEN.senateGaugeVersionTtlScore = TransNullToFloat(objRow[convMicroTeachCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroTeachCaseEN.VersionNo = objRow[convMicroTeachCase.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroTeachCase.VersionNo].ToString().Trim()); //版本号
objvMicroTeachCaseEN.IdTeachSkill = objRow[convMicroTeachCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroTeachCaseEN.TeachSkillID = objRow[convMicroTeachCase.TeachSkillID] == DBNull.Value ? null : objRow[convMicroTeachCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroTeachCaseEN.SkillTypeName = objRow[convMicroTeachCase.SkillTypeName] == DBNull.Value ? null : objRow[convMicroTeachCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroTeachCaseEN.TeachSkillName = objRow[convMicroTeachCase.TeachSkillName] == DBNull.Value ? null : objRow[convMicroTeachCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroTeachCaseEN.TeachSkillTheory = objRow[convMicroTeachCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroTeachCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroTeachCaseEN.TeachSkillOperMethod = objRow[convMicroTeachCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroTeachCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroTeachCaseEN.IdSkillType = objRow[convMicroTeachCase.IdSkillType] == DBNull.Value ? null : objRow[convMicroTeachCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroTeachCaseEN.SkillTypeID = objRow[convMicroTeachCase.SkillTypeID] == DBNull.Value ? null : objRow[convMicroTeachCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroTeachCaseEN.CaseLevelId = objRow[convMicroTeachCase.CaseLevelId] == DBNull.Value ? null : objRow[convMicroTeachCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroTeachCaseEN.CaseLevelName = objRow[convMicroTeachCase.CaseLevelName] == DBNull.Value ? null : objRow[convMicroTeachCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvMicroTeachCaseEN.DocFile = objRow[convMicroTeachCase.DocFile] == DBNull.Value ? null : objRow[convMicroTeachCase.DocFile].ToString().Trim(); //生成的Word文件名
objvMicroTeachCaseEN.IsNeedGeneWord = TransNullToBool(objRow[convMicroTeachCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvMicroTeachCaseEN.WordCreateDate = objRow[convMicroTeachCase.WordCreateDate] == DBNull.Value ? null : objRow[convMicroTeachCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvMicroTeachCaseEN.IsVisible = TransNullToBool(objRow[convMicroTeachCase.IsVisible].ToString().Trim()); //是否显示
objvMicroTeachCaseEN.microteachCaseText = objRow[convMicroTeachCase.microteachCaseText] == DBNull.Value ? null : objRow[convMicroTeachCase.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroTeachCaseEN.OwnerId = objRow[convMicroTeachCase.OwnerId].ToString().Trim(); //拥有者Id
objvMicroTeachCaseEN.IdStudentInfo = objRow[convMicroTeachCase.IdStudentInfo] == DBNull.Value ? null : objRow[convMicroTeachCase.IdStudentInfo].ToString().Trim(); //学生流水号
objvMicroTeachCaseEN.StuName = objRow[convMicroTeachCase.StuName].ToString().Trim(); //姓名
objvMicroTeachCaseEN.StuID = objRow[convMicroTeachCase.StuID] == DBNull.Value ? null : objRow[convMicroTeachCase.StuID].ToString().Trim(); //学号
objvMicroTeachCaseEN.PoliticsName = objRow[convMicroTeachCase.PoliticsName] == DBNull.Value ? null : objRow[convMicroTeachCase.PoliticsName].ToString().Trim(); //政治面貌
objvMicroTeachCaseEN.SexDesc = objRow[convMicroTeachCase.SexDesc] == DBNull.Value ? null : objRow[convMicroTeachCase.SexDesc].ToString().Trim(); //性别名称
objvMicroTeachCaseEN.EthnicName = objRow[convMicroTeachCase.EthnicName] == DBNull.Value ? null : objRow[convMicroTeachCase.EthnicName].ToString().Trim(); //民族名称
objvMicroTeachCaseEN.UniZoneDesc = objRow[convMicroTeachCase.UniZoneDesc] == DBNull.Value ? null : objRow[convMicroTeachCase.UniZoneDesc].ToString().Trim(); //校区名称
objvMicroTeachCaseEN.StuTypeDesc = objRow[convMicroTeachCase.StuTypeDesc] == DBNull.Value ? null : objRow[convMicroTeachCase.StuTypeDesc].ToString().Trim(); //学生类别名称
objvMicroTeachCaseEN.IdXzCollege = objRow[convMicroTeachCase.IdXzCollege] == DBNull.Value ? null : objRow[convMicroTeachCase.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroTeachCaseEN.CollegeID = objRow[convMicroTeachCase.CollegeID] == DBNull.Value ? null : objRow[convMicroTeachCase.CollegeID].ToString().Trim(); //学院ID
objvMicroTeachCaseEN.CollegeName = objRow[convMicroTeachCase.CollegeName].ToString().Trim(); //学院名称
objvMicroTeachCaseEN.CollegeNameA = objRow[convMicroTeachCase.CollegeNameA] == DBNull.Value ? null : objRow[convMicroTeachCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvMicroTeachCaseEN.IdXzMajor = objRow[convMicroTeachCase.IdXzMajor] == DBNull.Value ? null : objRow[convMicroTeachCase.IdXzMajor].ToString().Trim(); //专业流水号
objvMicroTeachCaseEN.MajorName = objRow[convMicroTeachCase.MajorName].ToString().Trim(); //专业名称
objvMicroTeachCaseEN.IdGradeBase = objRow[convMicroTeachCase.IdGradeBase].ToString().Trim(); //年级流水号
objvMicroTeachCaseEN.GradeBaseName = objRow[convMicroTeachCase.GradeBaseName] == DBNull.Value ? null : objRow[convMicroTeachCase.GradeBaseName].ToString().Trim(); //年级名称
objvMicroTeachCaseEN.IdAdminCls = objRow[convMicroTeachCase.IdAdminCls] == DBNull.Value ? null : objRow[convMicroTeachCase.IdAdminCls].ToString().Trim(); //行政班流水号
objvMicroTeachCaseEN.AdminClsId = objRow[convMicroTeachCase.AdminClsId] == DBNull.Value ? null : objRow[convMicroTeachCase.AdminClsId].ToString().Trim(); //行政班代号
objvMicroTeachCaseEN.AdminClsName = objRow[convMicroTeachCase.AdminClsName] == DBNull.Value ? null : objRow[convMicroTeachCase.AdminClsName].ToString().Trim(); //行政班名称
objvMicroTeachCaseEN.Birthday = objRow[convMicroTeachCase.Birthday] == DBNull.Value ? null : objRow[convMicroTeachCase.Birthday].ToString().Trim(); //出生日期
objvMicroTeachCaseEN.NativePlace = objRow[convMicroTeachCase.NativePlace] == DBNull.Value ? null : objRow[convMicroTeachCase.NativePlace].ToString().Trim(); //籍贯
objvMicroTeachCaseEN.Duty = objRow[convMicroTeachCase.Duty] == DBNull.Value ? null : objRow[convMicroTeachCase.Duty].ToString().Trim(); //职位
objvMicroTeachCaseEN.IDCardNo = objRow[convMicroTeachCase.IDCardNo] == DBNull.Value ? null : objRow[convMicroTeachCase.IDCardNo].ToString().Trim(); //身份证号
objvMicroTeachCaseEN.StuCardNo = objRow[convMicroTeachCase.StuCardNo] == DBNull.Value ? null : objRow[convMicroTeachCase.StuCardNo].ToString().Trim(); //学生证号
objvMicroTeachCaseEN.LiveAddress = objRow[convMicroTeachCase.LiveAddress] == DBNull.Value ? null : objRow[convMicroTeachCase.LiveAddress].ToString().Trim(); //居住地址
objvMicroTeachCaseEN.HomePhone = objRow[convMicroTeachCase.HomePhone] == DBNull.Value ? null : objRow[convMicroTeachCase.HomePhone].ToString().Trim(); //住宅电话
objvMicroTeachCaseEN.EnrollmentDate = objRow[convMicroTeachCase.EnrollmentDate] == DBNull.Value ? null : objRow[convMicroTeachCase.EnrollmentDate].ToString().Trim(); //入校日期
objvMicroTeachCaseEN.PostCode = objRow[convMicroTeachCase.PostCode] == DBNull.Value ? null : objRow[convMicroTeachCase.PostCode].ToString().Trim(); //邮编
objvMicroTeachCaseEN.IsDualVideo = TransNullToBool(objRow[convMicroTeachCase.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroTeachCaseEN.UserKindId = objRow[convMicroTeachCase.UserKindId].ToString().Trim(); //用户类别Id
objvMicroTeachCaseEN.UserKindName = objRow[convMicroTeachCase.UserKindName] == DBNull.Value ? null : objRow[convMicroTeachCase.UserKindName].ToString().Trim(); //用户类别名
objvMicroTeachCaseEN.UserTypeId = objRow[convMicroTeachCase.UserTypeId] == DBNull.Value ? null : objRow[convMicroTeachCase.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroTeachCaseEN.UserTypeName = objRow[convMicroTeachCase.UserTypeName] == DBNull.Value ? null : objRow[convMicroTeachCase.UserTypeName].ToString().Trim(); //用户类型名称
objvMicroTeachCaseEN.RecommendedDegreeId = objRow[convMicroTeachCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroTeachCaseEN.RecommendedDegreeName = objRow[convMicroTeachCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroTeachCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroTeachCaseEN.ftpFileType = objRow[convMicroTeachCase.ftpFileType] == DBNull.Value ? null : objRow[convMicroTeachCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroTeachCaseEN.VideoUrl = objRow[convMicroTeachCase.VideoUrl] == DBNull.Value ? null : objRow[convMicroTeachCase.VideoUrl].ToString().Trim(); //视频Url
objvMicroTeachCaseEN.VideoPath = objRow[convMicroTeachCase.VideoPath] == DBNull.Value ? null : objRow[convMicroTeachCase.VideoPath].ToString().Trim(); //视频目录
objvMicroTeachCaseEN.ResErrMsg = objRow[convMicroTeachCase.ResErrMsg] == DBNull.Value ? null : objRow[convMicroTeachCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvMicroTeachCaseEN.Memo = objRow[convMicroTeachCase.Memo] == DBNull.Value ? null : objRow[convMicroTeachCase.Memo].ToString().Trim(); //备注
objvMicroTeachCaseEN.IsHaveVideo = objRow[convMicroTeachCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
objvMicroTeachCaseEN.OwnerName = objRow[convMicroTeachCase.OwnerName] == DBNull.Value ? null : objRow[convMicroTeachCase.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroTeachCaseEN.BrowseCount4Case = objRow[convMicroTeachCase.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroTeachCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvMicroTeachCaseDA: GetObjByDataRow)", objException.Message));
}
objvMicroTeachCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvMicroTeachCaseEN;
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
objSQL = clsvMicroTeachCaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvMicroTeachCaseEN._CurrTabName, convMicroTeachCase.IdMicroteachCase, 8, "");
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
objSQL = clsvMicroTeachCaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvMicroTeachCaseEN._CurrTabName, convMicroTeachCase.IdMicroteachCase, 8, strPrefix);
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
 objSQL = clsvMicroTeachCaseDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdMicroteachCase from vMicroTeachCase where " + strCondition;
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
 objSQL = clsvMicroTeachCaseDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdMicroteachCase from vMicroTeachCase where " + strCondition;
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
 /// <param name = "strIdMicroteachCase">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strIdMicroteachCase)
{
CheckPrimaryKey(strIdMicroteachCase);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroTeachCaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vMicroTeachCase", "IdMicroteachCase = " + "'"+ strIdMicroteachCase+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvMicroTeachCaseDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroTeachCaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vMicroTeachCase", strCondition))
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
objSQL = clsvMicroTeachCaseDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vMicroTeachCase");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvMicroTeachCaseENS">源对象</param>
 /// <param name = "objvMicroTeachCaseENT">目标对象</param>
public void CopyTo(clsvMicroTeachCaseEN objvMicroTeachCaseENS, clsvMicroTeachCaseEN objvMicroTeachCaseENT)
{
objvMicroTeachCaseENT.IdMicroteachCase = objvMicroTeachCaseENS.IdMicroteachCase; //微格教学案例流水号
objvMicroTeachCaseENT.MicroteachCaseID = objvMicroTeachCaseENS.MicroteachCaseID; //微格教学案例ID
objvMicroTeachCaseENT.MicroteachCaseName = objvMicroTeachCaseENS.MicroteachCaseName; //微格教学案例名称
objvMicroTeachCaseENT.MicroteachCaseTheme = objvMicroTeachCaseENS.MicroteachCaseTheme; //微格教学案例主题词
objvMicroTeachCaseENT.MicroteachCaseDate = objvMicroTeachCaseENS.MicroteachCaseDate; //微格教学日期
objvMicroTeachCaseENT.MicroteachCaseTime = objvMicroTeachCaseENS.MicroteachCaseTime; //微格教学时间
objvMicroTeachCaseENT.MicroteachCaseDateIn = objvMicroTeachCaseENS.MicroteachCaseDateIn; //案例入库日期
objvMicroTeachCaseENT.IdStudyLevel = objvMicroTeachCaseENS.IdStudyLevel; //id_StudyLevel
objvMicroTeachCaseENT.StudyLevelName = objvMicroTeachCaseENS.StudyLevelName; //学段名称
objvMicroTeachCaseENT.IdTeachingPlan = objvMicroTeachCaseENS.IdTeachingPlan; //教案流水号
objvMicroTeachCaseENT.MicroTeachCaseTimeIn = objvMicroTeachCaseENS.MicroTeachCaseTimeIn; //案例入库时间
objvMicroTeachCaseENT.IdMicroteachCaseType = objvMicroTeachCaseENS.IdMicroteachCaseType; //微格案例类型流水号
objvMicroTeachCaseENT.MicroteachCaseTypeName = objvMicroTeachCaseENS.MicroteachCaseTypeName; //微格案例类型名称
objvMicroTeachCaseENT.IdCaseType = objvMicroTeachCaseENS.IdCaseType; //案例类型流水号
objvMicroTeachCaseENT.IdDiscipline = objvMicroTeachCaseENS.IdDiscipline; //学科流水号
objvMicroTeachCaseENT.DisciplineID = objvMicroTeachCaseENS.DisciplineID; //学科ID
objvMicroTeachCaseENT.DisciplineName = objvMicroTeachCaseENS.DisciplineName; //学科名称
objvMicroTeachCaseENT.IdSenateGaugeVersion = objvMicroTeachCaseENS.IdSenateGaugeVersion; //评价量表版本流水号
objvMicroTeachCaseENT.senateGaugeVersionID = objvMicroTeachCaseENS.senateGaugeVersionID; //评价量表版本ID
objvMicroTeachCaseENT.senateGaugeVersionName = objvMicroTeachCaseENS.senateGaugeVersionName; //评价量表版本名称
objvMicroTeachCaseENT.senateGaugeVersionTtlScore = objvMicroTeachCaseENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvMicroTeachCaseENT.VersionNo = objvMicroTeachCaseENS.VersionNo; //版本号
objvMicroTeachCaseENT.IdTeachSkill = objvMicroTeachCaseENS.IdTeachSkill; //教学技能流水号
objvMicroTeachCaseENT.TeachSkillID = objvMicroTeachCaseENS.TeachSkillID; //教学技能ID
objvMicroTeachCaseENT.SkillTypeName = objvMicroTeachCaseENS.SkillTypeName; //技能类型名称
objvMicroTeachCaseENT.TeachSkillName = objvMicroTeachCaseENS.TeachSkillName; //教学技能名称
objvMicroTeachCaseENT.TeachSkillTheory = objvMicroTeachCaseENS.TeachSkillTheory; //教学技能理论阐述
objvMicroTeachCaseENT.TeachSkillOperMethod = objvMicroTeachCaseENS.TeachSkillOperMethod; //教学技能实践操作方法
objvMicroTeachCaseENT.IdSkillType = objvMicroTeachCaseENS.IdSkillType; //技能类型流水号
objvMicroTeachCaseENT.SkillTypeID = objvMicroTeachCaseENS.SkillTypeID; //技能类型ID
objvMicroTeachCaseENT.CaseLevelId = objvMicroTeachCaseENS.CaseLevelId; //课例等级Id
objvMicroTeachCaseENT.CaseLevelName = objvMicroTeachCaseENS.CaseLevelName; //案例等级名称
objvMicroTeachCaseENT.DocFile = objvMicroTeachCaseENS.DocFile; //生成的Word文件名
objvMicroTeachCaseENT.IsNeedGeneWord = objvMicroTeachCaseENS.IsNeedGeneWord; //是否需要生成Word
objvMicroTeachCaseENT.WordCreateDate = objvMicroTeachCaseENS.WordCreateDate; //Word生成日期
objvMicroTeachCaseENT.IsVisible = objvMicroTeachCaseENS.IsVisible; //是否显示
objvMicroTeachCaseENT.microteachCaseText = objvMicroTeachCaseENS.microteachCaseText; //案例文本内容
objvMicroTeachCaseENT.OwnerId = objvMicroTeachCaseENS.OwnerId; //拥有者Id
objvMicroTeachCaseENT.IdStudentInfo = objvMicroTeachCaseENS.IdStudentInfo; //学生流水号
objvMicroTeachCaseENT.StuName = objvMicroTeachCaseENS.StuName; //姓名
objvMicroTeachCaseENT.StuID = objvMicroTeachCaseENS.StuID; //学号
objvMicroTeachCaseENT.PoliticsName = objvMicroTeachCaseENS.PoliticsName; //政治面貌
objvMicroTeachCaseENT.SexDesc = objvMicroTeachCaseENS.SexDesc; //性别名称
objvMicroTeachCaseENT.EthnicName = objvMicroTeachCaseENS.EthnicName; //民族名称
objvMicroTeachCaseENT.UniZoneDesc = objvMicroTeachCaseENS.UniZoneDesc; //校区名称
objvMicroTeachCaseENT.StuTypeDesc = objvMicroTeachCaseENS.StuTypeDesc; //学生类别名称
objvMicroTeachCaseENT.IdXzCollege = objvMicroTeachCaseENS.IdXzCollege; //学院流水号
objvMicroTeachCaseENT.CollegeID = objvMicroTeachCaseENS.CollegeID; //学院ID
objvMicroTeachCaseENT.CollegeName = objvMicroTeachCaseENS.CollegeName; //学院名称
objvMicroTeachCaseENT.CollegeNameA = objvMicroTeachCaseENS.CollegeNameA; //学院名称简写
objvMicroTeachCaseENT.IdXzMajor = objvMicroTeachCaseENS.IdXzMajor; //专业流水号
objvMicroTeachCaseENT.MajorName = objvMicroTeachCaseENS.MajorName; //专业名称
objvMicroTeachCaseENT.IdGradeBase = objvMicroTeachCaseENS.IdGradeBase; //年级流水号
objvMicroTeachCaseENT.GradeBaseName = objvMicroTeachCaseENS.GradeBaseName; //年级名称
objvMicroTeachCaseENT.IdAdminCls = objvMicroTeachCaseENS.IdAdminCls; //行政班流水号
objvMicroTeachCaseENT.AdminClsId = objvMicroTeachCaseENS.AdminClsId; //行政班代号
objvMicroTeachCaseENT.AdminClsName = objvMicroTeachCaseENS.AdminClsName; //行政班名称
objvMicroTeachCaseENT.Birthday = objvMicroTeachCaseENS.Birthday; //出生日期
objvMicroTeachCaseENT.NativePlace = objvMicroTeachCaseENS.NativePlace; //籍贯
objvMicroTeachCaseENT.Duty = objvMicroTeachCaseENS.Duty; //职位
objvMicroTeachCaseENT.IDCardNo = objvMicroTeachCaseENS.IDCardNo; //身份证号
objvMicroTeachCaseENT.StuCardNo = objvMicroTeachCaseENS.StuCardNo; //学生证号
objvMicroTeachCaseENT.LiveAddress = objvMicroTeachCaseENS.LiveAddress; //居住地址
objvMicroTeachCaseENT.HomePhone = objvMicroTeachCaseENS.HomePhone; //住宅电话
objvMicroTeachCaseENT.EnrollmentDate = objvMicroTeachCaseENS.EnrollmentDate; //入校日期
objvMicroTeachCaseENT.PostCode = objvMicroTeachCaseENS.PostCode; //邮编
objvMicroTeachCaseENT.IsDualVideo = objvMicroTeachCaseENS.IsDualVideo; //是否双视频
objvMicroTeachCaseENT.UserKindId = objvMicroTeachCaseENS.UserKindId; //用户类别Id
objvMicroTeachCaseENT.UserKindName = objvMicroTeachCaseENS.UserKindName; //用户类别名
objvMicroTeachCaseENT.UserTypeId = objvMicroTeachCaseENS.UserTypeId; //用户类型Id
objvMicroTeachCaseENT.UserTypeName = objvMicroTeachCaseENS.UserTypeName; //用户类型名称
objvMicroTeachCaseENT.RecommendedDegreeId = objvMicroTeachCaseENS.RecommendedDegreeId; //推荐度Id
objvMicroTeachCaseENT.RecommendedDegreeName = objvMicroTeachCaseENS.RecommendedDegreeName; //推荐度名称
objvMicroTeachCaseENT.ftpFileType = objvMicroTeachCaseENS.ftpFileType; //ftp文件类型
objvMicroTeachCaseENT.VideoUrl = objvMicroTeachCaseENS.VideoUrl; //视频Url
objvMicroTeachCaseENT.VideoPath = objvMicroTeachCaseENS.VideoPath; //视频目录
objvMicroTeachCaseENT.ResErrMsg = objvMicroTeachCaseENS.ResErrMsg; //资源错误信息
objvMicroTeachCaseENT.Memo = objvMicroTeachCaseENS.Memo; //备注
objvMicroTeachCaseENT.IsHaveVideo = objvMicroTeachCaseENS.IsHaveVideo; //IsHaveVideo
objvMicroTeachCaseENT.OwnerName = objvMicroTeachCaseENS.OwnerName; //拥有者姓名
objvMicroTeachCaseENT.BrowseCount4Case = objvMicroTeachCaseENS.BrowseCount4Case; //课例浏览次数
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvMicroTeachCaseEN objvMicroTeachCaseEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.IdMicroteachCase, 8, convMicroTeachCase.IdMicroteachCase);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.MicroteachCaseID, 8, convMicroTeachCase.MicroteachCaseID);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.MicroteachCaseName, 100, convMicroTeachCase.MicroteachCaseName);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.MicroteachCaseTheme, 200, convMicroTeachCase.MicroteachCaseTheme);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.MicroteachCaseDate, 8, convMicroTeachCase.MicroteachCaseDate);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.MicroteachCaseTime, 6, convMicroTeachCase.MicroteachCaseTime);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.MicroteachCaseDateIn, 8, convMicroTeachCase.MicroteachCaseDateIn);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.IdStudyLevel, 4, convMicroTeachCase.IdStudyLevel);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.StudyLevelName, 50, convMicroTeachCase.StudyLevelName);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.IdTeachingPlan, 8, convMicroTeachCase.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.MicroTeachCaseTimeIn, 6, convMicroTeachCase.MicroTeachCaseTimeIn);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.IdMicroteachCaseType, 4, convMicroTeachCase.IdMicroteachCaseType);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.MicroteachCaseTypeName, 50, convMicroTeachCase.MicroteachCaseTypeName);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.IdCaseType, 4, convMicroTeachCase.IdCaseType);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.IdDiscipline, 4, convMicroTeachCase.IdDiscipline);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.DisciplineID, 4, convMicroTeachCase.DisciplineID);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.DisciplineName, 50, convMicroTeachCase.DisciplineName);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.IdSenateGaugeVersion, 4, convMicroTeachCase.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.senateGaugeVersionID, 4, convMicroTeachCase.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.senateGaugeVersionName, 200, convMicroTeachCase.senateGaugeVersionName);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.IdTeachSkill, 8, convMicroTeachCase.IdTeachSkill);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.TeachSkillID, 8, convMicroTeachCase.TeachSkillID);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.SkillTypeName, 50, convMicroTeachCase.SkillTypeName);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.TeachSkillName, 50, convMicroTeachCase.TeachSkillName);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.TeachSkillTheory, 8000, convMicroTeachCase.TeachSkillTheory);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.TeachSkillOperMethod, 2000, convMicroTeachCase.TeachSkillOperMethod);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.IdSkillType, 4, convMicroTeachCase.IdSkillType);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.SkillTypeID, 4, convMicroTeachCase.SkillTypeID);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.CaseLevelId, 2, convMicroTeachCase.CaseLevelId);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.CaseLevelName, 30, convMicroTeachCase.CaseLevelName);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.DocFile, 200, convMicroTeachCase.DocFile);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.WordCreateDate, 14, convMicroTeachCase.WordCreateDate);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.microteachCaseText, 8000, convMicroTeachCase.microteachCaseText);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.OwnerId, 20, convMicroTeachCase.OwnerId);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.IdStudentInfo, 8, convMicroTeachCase.IdStudentInfo);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.StuName, 50, convMicroTeachCase.StuName);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.StuID, 20, convMicroTeachCase.StuID);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.PoliticsName, 30, convMicroTeachCase.PoliticsName);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.SexDesc, 10, convMicroTeachCase.SexDesc);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.EthnicName, 30, convMicroTeachCase.EthnicName);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.UniZoneDesc, 20, convMicroTeachCase.UniZoneDesc);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.StuTypeDesc, 50, convMicroTeachCase.StuTypeDesc);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.IdXzCollege, 4, convMicroTeachCase.IdXzCollege);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.CollegeID, 4, convMicroTeachCase.CollegeID);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.CollegeName, 100, convMicroTeachCase.CollegeName);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.CollegeNameA, 12, convMicroTeachCase.CollegeNameA);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.IdXzMajor, 8, convMicroTeachCase.IdXzMajor);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.MajorName, 100, convMicroTeachCase.MajorName);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.IdGradeBase, 4, convMicroTeachCase.IdGradeBase);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.GradeBaseName, 50, convMicroTeachCase.GradeBaseName);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.IdAdminCls, 8, convMicroTeachCase.IdAdminCls);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.AdminClsId, 8, convMicroTeachCase.AdminClsId);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.AdminClsName, 100, convMicroTeachCase.AdminClsName);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.Birthday, 8, convMicroTeachCase.Birthday);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.NativePlace, 200, convMicroTeachCase.NativePlace);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.Duty, 30, convMicroTeachCase.Duty);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.IDCardNo, 20, convMicroTeachCase.IDCardNo);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.StuCardNo, 20, convMicroTeachCase.StuCardNo);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.LiveAddress, 200, convMicroTeachCase.LiveAddress);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.HomePhone, 20, convMicroTeachCase.HomePhone);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.EnrollmentDate, 8, convMicroTeachCase.EnrollmentDate);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.PostCode, 6, convMicroTeachCase.PostCode);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.UserKindId, 2, convMicroTeachCase.UserKindId);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.UserKindName, 30, convMicroTeachCase.UserKindName);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.UserTypeId, 2, convMicroTeachCase.UserTypeId);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.UserTypeName, 20, convMicroTeachCase.UserTypeName);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.RecommendedDegreeId, 2, convMicroTeachCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.RecommendedDegreeName, 30, convMicroTeachCase.RecommendedDegreeName);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.ftpFileType, 30, convMicroTeachCase.ftpFileType);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.VideoUrl, 1000, convMicroTeachCase.VideoUrl);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.VideoPath, 1000, convMicroTeachCase.VideoPath);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.ResErrMsg, 30, convMicroTeachCase.ResErrMsg);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.Memo, 1000, convMicroTeachCase.Memo);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.IsHaveVideo, 6, convMicroTeachCase.IsHaveVideo);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseEN.OwnerName, 30, convMicroTeachCase.OwnerName);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.IdMicroteachCase, convMicroTeachCase.IdMicroteachCase);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.MicroteachCaseID, convMicroTeachCase.MicroteachCaseID);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.MicroteachCaseName, convMicroTeachCase.MicroteachCaseName);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.MicroteachCaseTheme, convMicroTeachCase.MicroteachCaseTheme);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.MicroteachCaseDate, convMicroTeachCase.MicroteachCaseDate);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.MicroteachCaseTime, convMicroTeachCase.MicroteachCaseTime);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.MicroteachCaseDateIn, convMicroTeachCase.MicroteachCaseDateIn);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.IdStudyLevel, convMicroTeachCase.IdStudyLevel);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.StudyLevelName, convMicroTeachCase.StudyLevelName);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.IdTeachingPlan, convMicroTeachCase.IdTeachingPlan);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.MicroTeachCaseTimeIn, convMicroTeachCase.MicroTeachCaseTimeIn);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.IdMicroteachCaseType, convMicroTeachCase.IdMicroteachCaseType);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.MicroteachCaseTypeName, convMicroTeachCase.MicroteachCaseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.IdCaseType, convMicroTeachCase.IdCaseType);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.IdDiscipline, convMicroTeachCase.IdDiscipline);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.DisciplineID, convMicroTeachCase.DisciplineID);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.DisciplineName, convMicroTeachCase.DisciplineName);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.IdSenateGaugeVersion, convMicroTeachCase.IdSenateGaugeVersion);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.senateGaugeVersionID, convMicroTeachCase.senateGaugeVersionID);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.senateGaugeVersionName, convMicroTeachCase.senateGaugeVersionName);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.IdTeachSkill, convMicroTeachCase.IdTeachSkill);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.TeachSkillID, convMicroTeachCase.TeachSkillID);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.SkillTypeName, convMicroTeachCase.SkillTypeName);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.TeachSkillName, convMicroTeachCase.TeachSkillName);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.TeachSkillTheory, convMicroTeachCase.TeachSkillTheory);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.TeachSkillOperMethod, convMicroTeachCase.TeachSkillOperMethod);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.IdSkillType, convMicroTeachCase.IdSkillType);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.SkillTypeID, convMicroTeachCase.SkillTypeID);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.CaseLevelId, convMicroTeachCase.CaseLevelId);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.CaseLevelName, convMicroTeachCase.CaseLevelName);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.DocFile, convMicroTeachCase.DocFile);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.WordCreateDate, convMicroTeachCase.WordCreateDate);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.microteachCaseText, convMicroTeachCase.microteachCaseText);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.OwnerId, convMicroTeachCase.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.IdStudentInfo, convMicroTeachCase.IdStudentInfo);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.StuName, convMicroTeachCase.StuName);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.StuID, convMicroTeachCase.StuID);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.PoliticsName, convMicroTeachCase.PoliticsName);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.SexDesc, convMicroTeachCase.SexDesc);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.EthnicName, convMicroTeachCase.EthnicName);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.UniZoneDesc, convMicroTeachCase.UniZoneDesc);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.StuTypeDesc, convMicroTeachCase.StuTypeDesc);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.IdXzCollege, convMicroTeachCase.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.CollegeID, convMicroTeachCase.CollegeID);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.CollegeName, convMicroTeachCase.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.CollegeNameA, convMicroTeachCase.CollegeNameA);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.IdXzMajor, convMicroTeachCase.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.MajorName, convMicroTeachCase.MajorName);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.IdGradeBase, convMicroTeachCase.IdGradeBase);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.GradeBaseName, convMicroTeachCase.GradeBaseName);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.IdAdminCls, convMicroTeachCase.IdAdminCls);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.AdminClsId, convMicroTeachCase.AdminClsId);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.AdminClsName, convMicroTeachCase.AdminClsName);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.Birthday, convMicroTeachCase.Birthday);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.NativePlace, convMicroTeachCase.NativePlace);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.Duty, convMicroTeachCase.Duty);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.IDCardNo, convMicroTeachCase.IDCardNo);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.StuCardNo, convMicroTeachCase.StuCardNo);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.LiveAddress, convMicroTeachCase.LiveAddress);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.HomePhone, convMicroTeachCase.HomePhone);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.EnrollmentDate, convMicroTeachCase.EnrollmentDate);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.PostCode, convMicroTeachCase.PostCode);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.UserKindId, convMicroTeachCase.UserKindId);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.UserKindName, convMicroTeachCase.UserKindName);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.UserTypeId, convMicroTeachCase.UserTypeId);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.UserTypeName, convMicroTeachCase.UserTypeName);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.RecommendedDegreeId, convMicroTeachCase.RecommendedDegreeId);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.RecommendedDegreeName, convMicroTeachCase.RecommendedDegreeName);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.ftpFileType, convMicroTeachCase.ftpFileType);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.VideoUrl, convMicroTeachCase.VideoUrl);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.VideoPath, convMicroTeachCase.VideoPath);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.ResErrMsg, convMicroTeachCase.ResErrMsg);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.Memo, convMicroTeachCase.Memo);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.IsHaveVideo, convMicroTeachCase.IsHaveVideo);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseEN.OwnerName, convMicroTeachCase.OwnerName);
//检查外键字段长度
 objvMicroTeachCaseEN._IsCheckProperty = true;
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
 objSQL = clsvMicroTeachCaseDA.GetSpecSQLObj();
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
 objSQL = clsvMicroTeachCaseDA.GetSpecSQLObj();
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
 objSQL = clsvMicroTeachCaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvMicroTeachCaseEN._CurrTabName);
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
 objSQL = clsvMicroTeachCaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvMicroTeachCaseEN._CurrTabName, strCondition);
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
 objSQL = clsvMicroTeachCaseDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}