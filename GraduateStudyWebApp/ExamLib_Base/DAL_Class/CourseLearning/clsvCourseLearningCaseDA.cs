
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCourseLearningCaseDA
 表名:vCourseLearningCase(01120267)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:03:20
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
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
 /// v课程学习案例(vCourseLearningCase)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvCourseLearningCaseDA : clsCommBase4DA
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
 return clsvCourseLearningCaseEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvCourseLearningCaseEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCourseLearningCaseEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvCourseLearningCaseEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvCourseLearningCaseEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strIdCourseLearningCase">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strIdCourseLearningCase)
{
strIdCourseLearningCase = strIdCourseLearningCase.Replace("'", "''");
if (strIdCourseLearningCase.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vCourseLearningCase中,检查关键字,长度不正确!(clsvCourseLearningCaseDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdCourseLearningCase)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vCourseLearningCase中,关键字不能为空 或 null!(clsvCourseLearningCaseDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdCourseLearningCase);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvCourseLearningCaseDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvCourseLearningCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCaseDA.GetSpecSQLObj();
strSQL = "Select * from vCourseLearningCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vCourseLearningCase(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvCourseLearningCaseDA: GetDataTable_vCourseLearningCase)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCaseDA.GetSpecSQLObj();
strSQL = "Select * from vCourseLearningCase where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvCourseLearningCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvCourseLearningCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCaseDA.GetSpecSQLObj();
strSQL = "Select * from vCourseLearningCase where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvCourseLearningCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvCourseLearningCaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCaseDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCourseLearningCase where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCourseLearningCase where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvCourseLearningCaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCaseDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vCourseLearningCase where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvCourseLearningCaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vCourseLearningCase.* from vCourseLearningCase Left Join {1} on {2} where {3} and vCourseLearningCase.IdCourseLearningCase not in (Select top {5} vCourseLearningCase.IdCourseLearningCase from vCourseLearningCase Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCourseLearningCase where {1} and IdCourseLearningCase not in (Select top {2} IdCourseLearningCase from vCourseLearningCase where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCourseLearningCase where {1} and IdCourseLearningCase not in (Select top {3} IdCourseLearningCase from vCourseLearningCase where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvCourseLearningCaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vCourseLearningCase.* from vCourseLearningCase Left Join {1} on {2} where {3} and vCourseLearningCase.IdCourseLearningCase not in (Select top {5} vCourseLearningCase.IdCourseLearningCase from vCourseLearningCase Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCourseLearningCase where {1} and IdCourseLearningCase not in (Select top {2} IdCourseLearningCase from vCourseLearningCase where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCourseLearningCase where {1} and IdCourseLearningCase not in (Select top {3} IdCourseLearningCase from vCourseLearningCase where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvCourseLearningCaseEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvCourseLearningCaseDA:GetObjLst)", objException.Message));
}
List<clsvCourseLearningCaseEN> arrObjLst = new List<clsvCourseLearningCaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCaseDA.GetSpecSQLObj();
strSQL = "Select * from vCourseLearningCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCaseEN objvCourseLearningCaseEN = new clsvCourseLearningCaseEN();
try
{
objvCourseLearningCaseEN.IdCourseLearningCase = objRow[convCourseLearningCase.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCaseEN.CourseLearningCaseID = objRow[convCourseLearningCase.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCaseEN.CourseLearningCaseName = objRow[convCourseLearningCase.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCaseEN.CourseLearningCaseText = objRow[convCourseLearningCase.CourseLearningCaseText] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseText].ToString().Trim(); //案例文本内容
objvCourseLearningCaseEN.CourseLearningCaseTheme = objRow[convCourseLearningCase.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningCaseEN.CourseLearningCaseDate = objRow[convCourseLearningCase.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningCaseEN.CourseLearningCaseTime = objRow[convCourseLearningCase.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningCaseEN.CourseLearningCaseDateIn = objRow[convCourseLearningCase.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningCaseEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCase.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningCaseEN.IdCaseType = objRow[convCourseLearningCase.IdCaseType] == DBNull.Value ? null : objRow[convCourseLearningCase.IdCaseType].ToString().Trim(); //案例类型流水号
objvCourseLearningCaseEN.CaseTypeName = objRow[convCourseLearningCase.CaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase.CaseTypeName].ToString().Trim(); //案例类型名称
objvCourseLearningCaseEN.IdCourseLearningCaseType = objRow[convCourseLearningCase.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号
objvCourseLearningCaseEN.CourseLearningCaseTypeName = objRow[convCourseLearningCase.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningCaseEN.OwnerId = objRow[convCourseLearningCase.OwnerId] == DBNull.Value ? null : objRow[convCourseLearningCase.OwnerId].ToString().Trim(); //拥有者Id
objvCourseLearningCaseEN.IdStudyLevel = objRow[convCourseLearningCase.IdStudyLevel] == DBNull.Value ? null : objRow[convCourseLearningCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCourseLearningCaseEN.StudyLevelName = objRow[convCourseLearningCase.StudyLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase.StudyLevelName].ToString().Trim(); //学段名称
objvCourseLearningCaseEN.IdTeachingPlan = objRow[convCourseLearningCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convCourseLearningCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCourseLearningCaseEN.IdDiscipline = objRow[convCourseLearningCase.IdDiscipline].ToString().Trim(); //学科流水号
objvCourseLearningCaseEN.DisciplineID = objRow[convCourseLearningCase.DisciplineID] == DBNull.Value ? null : objRow[convCourseLearningCase.DisciplineID].ToString().Trim(); //学科ID
objvCourseLearningCaseEN.DisciplineName = objRow[convCourseLearningCase.DisciplineName] == DBNull.Value ? null : objRow[convCourseLearningCase.DisciplineName].ToString().Trim(); //学科名称
objvCourseLearningCaseEN.IdSenateGaugeVersion = objRow[convCourseLearningCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convCourseLearningCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCourseLearningCaseEN.senateGaugeVersionID = objRow[convCourseLearningCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCourseLearningCaseEN.senateGaugeVersionName = objRow[convCourseLearningCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCourseLearningCaseEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convCourseLearningCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCourseLearningCaseEN.IsUse = TransNullToBool(objRow[convCourseLearningCase.IsUse].ToString().Trim()); //是否使用
objvCourseLearningCaseEN.VersionNo = objRow[convCourseLearningCase.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase.VersionNo].ToString().Trim()); //版本号
objvCourseLearningCaseEN.IdTeachSkill = objRow[convCourseLearningCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCourseLearningCaseEN.TeachSkillID = objRow[convCourseLearningCase.TeachSkillID] == DBNull.Value ? null : objRow[convCourseLearningCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvCourseLearningCaseEN.SkillTypeName = objRow[convCourseLearningCase.SkillTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvCourseLearningCaseEN.TeachSkillName = objRow[convCourseLearningCase.TeachSkillName] == DBNull.Value ? null : objRow[convCourseLearningCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvCourseLearningCaseEN.TeachSkillTheory = objRow[convCourseLearningCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convCourseLearningCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCourseLearningCaseEN.TeachSkillOperMethod = objRow[convCourseLearningCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCourseLearningCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCourseLearningCaseEN.IdSkillType = objRow[convCourseLearningCase.IdSkillType] == DBNull.Value ? null : objRow[convCourseLearningCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvCourseLearningCaseEN.SkillTypeID = objRow[convCourseLearningCase.SkillTypeID] == DBNull.Value ? null : objRow[convCourseLearningCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvCourseLearningCaseEN.CaseLevelId = objRow[convCourseLearningCase.CaseLevelId] == DBNull.Value ? null : objRow[convCourseLearningCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvCourseLearningCaseEN.CaseLevelName = objRow[convCourseLearningCase.CaseLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvCourseLearningCaseEN.DocFile = objRow[convCourseLearningCase.DocFile] == DBNull.Value ? null : objRow[convCourseLearningCase.DocFile].ToString().Trim(); //生成的Word文件名
objvCourseLearningCaseEN.IsNeedGeneWord = TransNullToBool(objRow[convCourseLearningCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvCourseLearningCaseEN.WordCreateDate = objRow[convCourseLearningCase.WordCreateDate] == DBNull.Value ? null : objRow[convCourseLearningCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvCourseLearningCaseEN.IsVisible = TransNullToBool(objRow[convCourseLearningCase.IsVisible].ToString().Trim()); //是否显示
objvCourseLearningCaseEN.IsDualVideo = TransNullToBool(objRow[convCourseLearningCase.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCaseEN.IdXzCollege = objRow[convCourseLearningCase.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCase.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCaseEN.CollegeId = objRow[convCourseLearningCase.CollegeId] == DBNull.Value ? null : objRow[convCourseLearningCase.CollegeId].ToString().Trim(); //学院ID
objvCourseLearningCaseEN.CollegeName = objRow[convCourseLearningCase.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCase.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCaseEN.CollegeNameA = objRow[convCourseLearningCase.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningCaseEN.IdXzMajor = objRow[convCourseLearningCase.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningCaseEN.MajorID = objRow[convCourseLearningCase.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCase.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCaseEN.MajorName = objRow[convCourseLearningCase.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCase.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCaseEN.CourseId = objRow[convCourseLearningCase.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCaseEN.CourseCode = objRow[convCourseLearningCase.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCaseEN.CourseName = objRow[convCourseLearningCase.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCaseEN.CourseChapterId = objRow[convCourseLearningCase.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCaseEN.CourseChapterName = objRow[convCourseLearningCase.CourseChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseChapterName].ToString().Trim(); //课程章节名称
objvCourseLearningCaseEN.ChapterId = objRow[convCourseLearningCase.ChapterId] == DBNull.Value ? null : objRow[convCourseLearningCase.ChapterId].ToString().Trim(); //章Id
objvCourseLearningCaseEN.SectionId = objRow[convCourseLearningCase.SectionId] == DBNull.Value ? null : objRow[convCourseLearningCase.SectionId].ToString().Trim(); //节Id
objvCourseLearningCaseEN.ChapterName = objRow[convCourseLearningCase.ChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase.ChapterName].ToString().Trim(); //章名
objvCourseLearningCaseEN.SectionName = objRow[convCourseLearningCase.SectionName] == DBNull.Value ? null : objRow[convCourseLearningCase.SectionName].ToString().Trim(); //节名
objvCourseLearningCaseEN.ChapterNameSim = objRow[convCourseLearningCase.ChapterNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase.ChapterNameSim].ToString().Trim(); //章名简称
objvCourseLearningCaseEN.SectionNameSim = objRow[convCourseLearningCase.SectionNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase.SectionNameSim].ToString().Trim(); //节名简称
objvCourseLearningCaseEN.ParentNodeId = objRow[convCourseLearningCase.ParentNodeId] == DBNull.Value ? null : objRow[convCourseLearningCase.ParentNodeId].ToString().Trim(); //父节点编号
objvCourseLearningCaseEN.CourseChapterReferred = objRow[convCourseLearningCase.CourseChapterReferred] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseChapterReferred].ToString().Trim(); //节简称
objvCourseLearningCaseEN.ParentNodeName = objRow[convCourseLearningCase.ParentNodeName] == DBNull.Value ? null : objRow[convCourseLearningCase.ParentNodeName].ToString().Trim(); //父节点名称
objvCourseLearningCaseEN.ParentNodeReferred = objRow[convCourseLearningCase.ParentNodeReferred] == DBNull.Value ? null : objRow[convCourseLearningCase.ParentNodeReferred].ToString().Trim(); //章简称
objvCourseLearningCaseEN.ViewCount = objRow[convCourseLearningCase.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase.ViewCount].ToString().Trim()); //浏览量
objvCourseLearningCaseEN.IsShow = TransNullToBool(objRow[convCourseLearningCase.IsShow].ToString().Trim()); //是否启用
objvCourseLearningCaseEN.DownloadNumber = objRow[convCourseLearningCase.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase.DownloadNumber].ToString().Trim()); //下载数目
objvCourseLearningCaseEN.FileIntegration = objRow[convCourseLearningCase.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase.FileIntegration].ToString().Trim()); //文件积分
objvCourseLearningCaseEN.LikeCount = objRow[convCourseLearningCase.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCourseLearningCase.LikeCount].ToString().Trim()); //资源喜欢数量
objvCourseLearningCaseEN.CollectionCount = objRow[convCourseLearningCase.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCourseLearningCase.CollectionCount].ToString().Trim()); //收藏数量
objvCourseLearningCaseEN.RecommendedDegreeId = objRow[convCourseLearningCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCourseLearningCaseEN.RecommendedDegreeName = objRow[convCourseLearningCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCourseLearningCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCourseLearningCaseEN.ftpFileType = objRow[convCourseLearningCase.ftpFileType] == DBNull.Value ? null : objRow[convCourseLearningCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvCourseLearningCaseEN.VideoUrl = objRow[convCourseLearningCase.VideoUrl] == DBNull.Value ? null : objRow[convCourseLearningCase.VideoUrl].ToString().Trim(); //视频Url
objvCourseLearningCaseEN.VideoPath = objRow[convCourseLearningCase.VideoPath] == DBNull.Value ? null : objRow[convCourseLearningCase.VideoPath].ToString().Trim(); //视频目录
objvCourseLearningCaseEN.ImageUrl = objRow[convCourseLearningCase.ImageUrl] == DBNull.Value ? null : objRow[convCourseLearningCase.ImageUrl].ToString().Trim(); //ImageUrl
objvCourseLearningCaseEN.ResErrMsg = objRow[convCourseLearningCase.ResErrMsg] == DBNull.Value ? null : objRow[convCourseLearningCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvCourseLearningCaseEN.OrderNum = objRow[convCourseLearningCase.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase.OrderNum].ToString().Trim()); //序号
objvCourseLearningCaseEN.UpdDate = objRow[convCourseLearningCase.UpdDate] == DBNull.Value ? null : objRow[convCourseLearningCase.UpdDate].ToString().Trim(); //修改日期
objvCourseLearningCaseEN.UpdUserId = objRow[convCourseLearningCase.UpdUserId] == DBNull.Value ? null : objRow[convCourseLearningCase.UpdUserId].ToString().Trim(); //修改用户Id
objvCourseLearningCaseEN.Memo = objRow[convCourseLearningCase.Memo] == DBNull.Value ? null : objRow[convCourseLearningCase.Memo].ToString().Trim(); //备注
objvCourseLearningCaseEN.IsHaveVideo = objRow[convCourseLearningCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
objvCourseLearningCaseEN.BrowseCount4Case = objRow[convCourseLearningCase.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningCaseEN.OwnerName = objRow[convCourseLearningCase.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCase.OwnerName].ToString().Trim(); //拥有者姓名
objvCourseLearningCaseEN.OwnerNameWithId = objRow[convCourseLearningCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCourseLearningCaseDA: GetObjLst)", objException.Message));
}
objvCourseLearningCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCourseLearningCaseEN);
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
public List<clsvCourseLearningCaseEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvCourseLearningCaseDA:GetObjLstByTabName)", objException.Message));
}
List<clsvCourseLearningCaseEN> arrObjLst = new List<clsvCourseLearningCaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCaseDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCaseEN objvCourseLearningCaseEN = new clsvCourseLearningCaseEN();
try
{
objvCourseLearningCaseEN.IdCourseLearningCase = objRow[convCourseLearningCase.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCaseEN.CourseLearningCaseID = objRow[convCourseLearningCase.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCaseEN.CourseLearningCaseName = objRow[convCourseLearningCase.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCaseEN.CourseLearningCaseText = objRow[convCourseLearningCase.CourseLearningCaseText] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseText].ToString().Trim(); //案例文本内容
objvCourseLearningCaseEN.CourseLearningCaseTheme = objRow[convCourseLearningCase.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningCaseEN.CourseLearningCaseDate = objRow[convCourseLearningCase.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningCaseEN.CourseLearningCaseTime = objRow[convCourseLearningCase.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningCaseEN.CourseLearningCaseDateIn = objRow[convCourseLearningCase.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningCaseEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCase.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningCaseEN.IdCaseType = objRow[convCourseLearningCase.IdCaseType] == DBNull.Value ? null : objRow[convCourseLearningCase.IdCaseType].ToString().Trim(); //案例类型流水号
objvCourseLearningCaseEN.CaseTypeName = objRow[convCourseLearningCase.CaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase.CaseTypeName].ToString().Trim(); //案例类型名称
objvCourseLearningCaseEN.IdCourseLearningCaseType = objRow[convCourseLearningCase.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号
objvCourseLearningCaseEN.CourseLearningCaseTypeName = objRow[convCourseLearningCase.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningCaseEN.OwnerId = objRow[convCourseLearningCase.OwnerId] == DBNull.Value ? null : objRow[convCourseLearningCase.OwnerId].ToString().Trim(); //拥有者Id
objvCourseLearningCaseEN.IdStudyLevel = objRow[convCourseLearningCase.IdStudyLevel] == DBNull.Value ? null : objRow[convCourseLearningCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCourseLearningCaseEN.StudyLevelName = objRow[convCourseLearningCase.StudyLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase.StudyLevelName].ToString().Trim(); //学段名称
objvCourseLearningCaseEN.IdTeachingPlan = objRow[convCourseLearningCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convCourseLearningCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCourseLearningCaseEN.IdDiscipline = objRow[convCourseLearningCase.IdDiscipline].ToString().Trim(); //学科流水号
objvCourseLearningCaseEN.DisciplineID = objRow[convCourseLearningCase.DisciplineID] == DBNull.Value ? null : objRow[convCourseLearningCase.DisciplineID].ToString().Trim(); //学科ID
objvCourseLearningCaseEN.DisciplineName = objRow[convCourseLearningCase.DisciplineName] == DBNull.Value ? null : objRow[convCourseLearningCase.DisciplineName].ToString().Trim(); //学科名称
objvCourseLearningCaseEN.IdSenateGaugeVersion = objRow[convCourseLearningCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convCourseLearningCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCourseLearningCaseEN.senateGaugeVersionID = objRow[convCourseLearningCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCourseLearningCaseEN.senateGaugeVersionName = objRow[convCourseLearningCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCourseLearningCaseEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convCourseLearningCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCourseLearningCaseEN.IsUse = TransNullToBool(objRow[convCourseLearningCase.IsUse].ToString().Trim()); //是否使用
objvCourseLearningCaseEN.VersionNo = objRow[convCourseLearningCase.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase.VersionNo].ToString().Trim()); //版本号
objvCourseLearningCaseEN.IdTeachSkill = objRow[convCourseLearningCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCourseLearningCaseEN.TeachSkillID = objRow[convCourseLearningCase.TeachSkillID] == DBNull.Value ? null : objRow[convCourseLearningCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvCourseLearningCaseEN.SkillTypeName = objRow[convCourseLearningCase.SkillTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvCourseLearningCaseEN.TeachSkillName = objRow[convCourseLearningCase.TeachSkillName] == DBNull.Value ? null : objRow[convCourseLearningCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvCourseLearningCaseEN.TeachSkillTheory = objRow[convCourseLearningCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convCourseLearningCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCourseLearningCaseEN.TeachSkillOperMethod = objRow[convCourseLearningCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCourseLearningCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCourseLearningCaseEN.IdSkillType = objRow[convCourseLearningCase.IdSkillType] == DBNull.Value ? null : objRow[convCourseLearningCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvCourseLearningCaseEN.SkillTypeID = objRow[convCourseLearningCase.SkillTypeID] == DBNull.Value ? null : objRow[convCourseLearningCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvCourseLearningCaseEN.CaseLevelId = objRow[convCourseLearningCase.CaseLevelId] == DBNull.Value ? null : objRow[convCourseLearningCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvCourseLearningCaseEN.CaseLevelName = objRow[convCourseLearningCase.CaseLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvCourseLearningCaseEN.DocFile = objRow[convCourseLearningCase.DocFile] == DBNull.Value ? null : objRow[convCourseLearningCase.DocFile].ToString().Trim(); //生成的Word文件名
objvCourseLearningCaseEN.IsNeedGeneWord = TransNullToBool(objRow[convCourseLearningCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvCourseLearningCaseEN.WordCreateDate = objRow[convCourseLearningCase.WordCreateDate] == DBNull.Value ? null : objRow[convCourseLearningCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvCourseLearningCaseEN.IsVisible = TransNullToBool(objRow[convCourseLearningCase.IsVisible].ToString().Trim()); //是否显示
objvCourseLearningCaseEN.IsDualVideo = TransNullToBool(objRow[convCourseLearningCase.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCaseEN.IdXzCollege = objRow[convCourseLearningCase.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCase.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCaseEN.CollegeId = objRow[convCourseLearningCase.CollegeId] == DBNull.Value ? null : objRow[convCourseLearningCase.CollegeId].ToString().Trim(); //学院ID
objvCourseLearningCaseEN.CollegeName = objRow[convCourseLearningCase.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCase.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCaseEN.CollegeNameA = objRow[convCourseLearningCase.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningCaseEN.IdXzMajor = objRow[convCourseLearningCase.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningCaseEN.MajorID = objRow[convCourseLearningCase.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCase.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCaseEN.MajorName = objRow[convCourseLearningCase.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCase.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCaseEN.CourseId = objRow[convCourseLearningCase.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCaseEN.CourseCode = objRow[convCourseLearningCase.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCaseEN.CourseName = objRow[convCourseLearningCase.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCaseEN.CourseChapterId = objRow[convCourseLearningCase.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCaseEN.CourseChapterName = objRow[convCourseLearningCase.CourseChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseChapterName].ToString().Trim(); //课程章节名称
objvCourseLearningCaseEN.ChapterId = objRow[convCourseLearningCase.ChapterId] == DBNull.Value ? null : objRow[convCourseLearningCase.ChapterId].ToString().Trim(); //章Id
objvCourseLearningCaseEN.SectionId = objRow[convCourseLearningCase.SectionId] == DBNull.Value ? null : objRow[convCourseLearningCase.SectionId].ToString().Trim(); //节Id
objvCourseLearningCaseEN.ChapterName = objRow[convCourseLearningCase.ChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase.ChapterName].ToString().Trim(); //章名
objvCourseLearningCaseEN.SectionName = objRow[convCourseLearningCase.SectionName] == DBNull.Value ? null : objRow[convCourseLearningCase.SectionName].ToString().Trim(); //节名
objvCourseLearningCaseEN.ChapterNameSim = objRow[convCourseLearningCase.ChapterNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase.ChapterNameSim].ToString().Trim(); //章名简称
objvCourseLearningCaseEN.SectionNameSim = objRow[convCourseLearningCase.SectionNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase.SectionNameSim].ToString().Trim(); //节名简称
objvCourseLearningCaseEN.ParentNodeId = objRow[convCourseLearningCase.ParentNodeId] == DBNull.Value ? null : objRow[convCourseLearningCase.ParentNodeId].ToString().Trim(); //父节点编号
objvCourseLearningCaseEN.CourseChapterReferred = objRow[convCourseLearningCase.CourseChapterReferred] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseChapterReferred].ToString().Trim(); //节简称
objvCourseLearningCaseEN.ParentNodeName = objRow[convCourseLearningCase.ParentNodeName] == DBNull.Value ? null : objRow[convCourseLearningCase.ParentNodeName].ToString().Trim(); //父节点名称
objvCourseLearningCaseEN.ParentNodeReferred = objRow[convCourseLearningCase.ParentNodeReferred] == DBNull.Value ? null : objRow[convCourseLearningCase.ParentNodeReferred].ToString().Trim(); //章简称
objvCourseLearningCaseEN.ViewCount = objRow[convCourseLearningCase.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase.ViewCount].ToString().Trim()); //浏览量
objvCourseLearningCaseEN.IsShow = TransNullToBool(objRow[convCourseLearningCase.IsShow].ToString().Trim()); //是否启用
objvCourseLearningCaseEN.DownloadNumber = objRow[convCourseLearningCase.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase.DownloadNumber].ToString().Trim()); //下载数目
objvCourseLearningCaseEN.FileIntegration = objRow[convCourseLearningCase.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase.FileIntegration].ToString().Trim()); //文件积分
objvCourseLearningCaseEN.LikeCount = objRow[convCourseLearningCase.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCourseLearningCase.LikeCount].ToString().Trim()); //资源喜欢数量
objvCourseLearningCaseEN.CollectionCount = objRow[convCourseLearningCase.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCourseLearningCase.CollectionCount].ToString().Trim()); //收藏数量
objvCourseLearningCaseEN.RecommendedDegreeId = objRow[convCourseLearningCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCourseLearningCaseEN.RecommendedDegreeName = objRow[convCourseLearningCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCourseLearningCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCourseLearningCaseEN.ftpFileType = objRow[convCourseLearningCase.ftpFileType] == DBNull.Value ? null : objRow[convCourseLearningCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvCourseLearningCaseEN.VideoUrl = objRow[convCourseLearningCase.VideoUrl] == DBNull.Value ? null : objRow[convCourseLearningCase.VideoUrl].ToString().Trim(); //视频Url
objvCourseLearningCaseEN.VideoPath = objRow[convCourseLearningCase.VideoPath] == DBNull.Value ? null : objRow[convCourseLearningCase.VideoPath].ToString().Trim(); //视频目录
objvCourseLearningCaseEN.ImageUrl = objRow[convCourseLearningCase.ImageUrl] == DBNull.Value ? null : objRow[convCourseLearningCase.ImageUrl].ToString().Trim(); //ImageUrl
objvCourseLearningCaseEN.ResErrMsg = objRow[convCourseLearningCase.ResErrMsg] == DBNull.Value ? null : objRow[convCourseLearningCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvCourseLearningCaseEN.OrderNum = objRow[convCourseLearningCase.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase.OrderNum].ToString().Trim()); //序号
objvCourseLearningCaseEN.UpdDate = objRow[convCourseLearningCase.UpdDate] == DBNull.Value ? null : objRow[convCourseLearningCase.UpdDate].ToString().Trim(); //修改日期
objvCourseLearningCaseEN.UpdUserId = objRow[convCourseLearningCase.UpdUserId] == DBNull.Value ? null : objRow[convCourseLearningCase.UpdUserId].ToString().Trim(); //修改用户Id
objvCourseLearningCaseEN.Memo = objRow[convCourseLearningCase.Memo] == DBNull.Value ? null : objRow[convCourseLearningCase.Memo].ToString().Trim(); //备注
objvCourseLearningCaseEN.IsHaveVideo = objRow[convCourseLearningCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
objvCourseLearningCaseEN.BrowseCount4Case = objRow[convCourseLearningCase.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningCaseEN.OwnerName = objRow[convCourseLearningCase.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCase.OwnerName].ToString().Trim(); //拥有者姓名
objvCourseLearningCaseEN.OwnerNameWithId = objRow[convCourseLearningCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCourseLearningCaseDA: GetObjLst)", objException.Message));
}
objvCourseLearningCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCourseLearningCaseEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvCourseLearningCaseEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvCourseLearningCase(ref clsvCourseLearningCaseEN objvCourseLearningCaseEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCaseDA.GetSpecSQLObj();
strSQL = "Select * from vCourseLearningCase where IdCourseLearningCase = " + "'"+ objvCourseLearningCaseEN.IdCourseLearningCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvCourseLearningCaseEN.IdCourseLearningCase = objDT.Rows[0][convCourseLearningCase.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCaseEN.CourseLearningCaseID = objDT.Rows[0][convCourseLearningCase.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCaseEN.CourseLearningCaseName = objDT.Rows[0][convCourseLearningCase.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCourseLearningCaseEN.CourseLearningCaseText = objDT.Rows[0][convCourseLearningCase.CourseLearningCaseText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objvCourseLearningCaseEN.CourseLearningCaseTheme = objDT.Rows[0][convCourseLearningCase.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvCourseLearningCaseEN.CourseLearningCaseDate = objDT.Rows[0][convCourseLearningCase.CourseLearningCaseDate].ToString().Trim(); //课程学习日期(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningCaseEN.CourseLearningCaseTime = objDT.Rows[0][convCourseLearningCase.CourseLearningCaseTime].ToString().Trim(); //课程学习时间(字段类型:char,字段长度:6,是否可空:True)
 objvCourseLearningCaseEN.CourseLearningCaseDateIn = objDT.Rows[0][convCourseLearningCase.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningCaseEN.CourseLearningCaseTimeIn = objDT.Rows[0][convCourseLearningCase.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvCourseLearningCaseEN.IdCaseType = objDT.Rows[0][convCourseLearningCase.IdCaseType].ToString().Trim(); //案例类型流水号(字段类型:char,字段长度:4,是否可空:True)
 objvCourseLearningCaseEN.CaseTypeName = objDT.Rows[0][convCourseLearningCase.CaseTypeName].ToString().Trim(); //案例类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCourseLearningCaseEN.IdCourseLearningCaseType = objDT.Rows[0][convCourseLearningCase.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCaseEN.CourseLearningCaseTypeName = objDT.Rows[0][convCourseLearningCase.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCourseLearningCaseEN.OwnerId = objDT.Rows[0][convCourseLearningCase.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvCourseLearningCaseEN.IdStudyLevel = objDT.Rows[0][convCourseLearningCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvCourseLearningCaseEN.StudyLevelName = objDT.Rows[0][convCourseLearningCase.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCourseLearningCaseEN.IdTeachingPlan = objDT.Rows[0][convCourseLearningCase.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCaseEN.IdDiscipline = objDT.Rows[0][convCourseLearningCase.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCaseEN.DisciplineID = objDT.Rows[0][convCourseLearningCase.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCaseEN.DisciplineName = objDT.Rows[0][convCourseLearningCase.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCourseLearningCaseEN.IdSenateGaugeVersion = objDT.Rows[0][convCourseLearningCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCaseEN.senateGaugeVersionID = objDT.Rows[0][convCourseLearningCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCaseEN.senateGaugeVersionName = objDT.Rows[0][convCourseLearningCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvCourseLearningCaseEN.senateGaugeVersionTtlScore = TransNullToFloat(objDT.Rows[0][convCourseLearningCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvCourseLearningCaseEN.IsUse = TransNullToBool(objDT.Rows[0][convCourseLearningCase.IsUse].ToString().Trim()); //是否使用(字段类型:bit,字段长度:1,是否可空:True)
 objvCourseLearningCaseEN.VersionNo = TransNullToInt(objDT.Rows[0][convCourseLearningCase.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvCourseLearningCaseEN.IdTeachSkill = objDT.Rows[0][convCourseLearningCase.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCaseEN.TeachSkillID = objDT.Rows[0][convCourseLearningCase.TeachSkillID].ToString().Trim(); //教学技能ID(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCaseEN.SkillTypeName = objDT.Rows[0][convCourseLearningCase.SkillTypeName].ToString().Trim(); //技能类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCourseLearningCaseEN.TeachSkillName = objDT.Rows[0][convCourseLearningCase.TeachSkillName].ToString().Trim(); //教学技能名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCourseLearningCaseEN.TeachSkillTheory = objDT.Rows[0][convCourseLearningCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvCourseLearningCaseEN.TeachSkillOperMethod = objDT.Rows[0][convCourseLearningCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法(字段类型:varchar,字段长度:2000,是否可空:True)
 objvCourseLearningCaseEN.IdSkillType = objDT.Rows[0][convCourseLearningCase.IdSkillType].ToString().Trim(); //技能类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCaseEN.SkillTypeID = objDT.Rows[0][convCourseLearningCase.SkillTypeID].ToString().Trim(); //技能类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCaseEN.CaseLevelId = objDT.Rows[0][convCourseLearningCase.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvCourseLearningCaseEN.CaseLevelName = objDT.Rows[0][convCourseLearningCase.CaseLevelName].ToString().Trim(); //案例等级名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvCourseLearningCaseEN.DocFile = objDT.Rows[0][convCourseLearningCase.DocFile].ToString().Trim(); //生成的Word文件名(字段类型:varchar,字段长度:200,是否可空:True)
 objvCourseLearningCaseEN.IsNeedGeneWord = TransNullToBool(objDT.Rows[0][convCourseLearningCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word(字段类型:bit,字段长度:1,是否可空:True)
 objvCourseLearningCaseEN.WordCreateDate = objDT.Rows[0][convCourseLearningCase.WordCreateDate].ToString().Trim(); //Word生成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objvCourseLearningCaseEN.IsVisible = TransNullToBool(objDT.Rows[0][convCourseLearningCase.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvCourseLearningCaseEN.IsDualVideo = TransNullToBool(objDT.Rows[0][convCourseLearningCase.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvCourseLearningCaseEN.IdXzCollege = objDT.Rows[0][convCourseLearningCase.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvCourseLearningCaseEN.CollegeId = objDT.Rows[0][convCourseLearningCase.CollegeId].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvCourseLearningCaseEN.CollegeName = objDT.Rows[0][convCourseLearningCase.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCourseLearningCaseEN.CollegeNameA = objDT.Rows[0][convCourseLearningCase.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvCourseLearningCaseEN.IdXzMajor = objDT.Rows[0][convCourseLearningCase.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCaseEN.MajorID = objDT.Rows[0][convCourseLearningCase.MajorID].ToString().Trim(); //专业ID(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCaseEN.MajorName = objDT.Rows[0][convCourseLearningCase.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCourseLearningCaseEN.CourseId = objDT.Rows[0][convCourseLearningCase.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningCaseEN.CourseCode = objDT.Rows[0][convCourseLearningCase.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvCourseLearningCaseEN.CourseName = objDT.Rows[0][convCourseLearningCase.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvCourseLearningCaseEN.CourseChapterId = objDT.Rows[0][convCourseLearningCase.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCaseEN.CourseChapterName = objDT.Rows[0][convCourseLearningCase.CourseChapterName].ToString().Trim(); //课程章节名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCourseLearningCaseEN.ChapterId = objDT.Rows[0][convCourseLearningCase.ChapterId].ToString().Trim(); //章Id(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningCaseEN.SectionId = objDT.Rows[0][convCourseLearningCase.SectionId].ToString().Trim(); //节Id(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningCaseEN.ChapterName = objDT.Rows[0][convCourseLearningCase.ChapterName].ToString().Trim(); //章名(字段类型:varchar,字段长度:100,是否可空:True)
 objvCourseLearningCaseEN.SectionName = objDT.Rows[0][convCourseLearningCase.SectionName].ToString().Trim(); //节名(字段类型:varchar,字段长度:100,是否可空:True)
 objvCourseLearningCaseEN.ChapterNameSim = objDT.Rows[0][convCourseLearningCase.ChapterNameSim].ToString().Trim(); //章名简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvCourseLearningCaseEN.SectionNameSim = objDT.Rows[0][convCourseLearningCase.SectionNameSim].ToString().Trim(); //节名简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvCourseLearningCaseEN.ParentNodeId = objDT.Rows[0][convCourseLearningCase.ParentNodeId].ToString().Trim(); //父节点编号(字段类型:varchar,字段长度:8,是否可空:True)
 objvCourseLearningCaseEN.CourseChapterReferred = objDT.Rows[0][convCourseLearningCase.CourseChapterReferred].ToString().Trim(); //节简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvCourseLearningCaseEN.ParentNodeName = objDT.Rows[0][convCourseLearningCase.ParentNodeName].ToString().Trim(); //父节点名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvCourseLearningCaseEN.ParentNodeReferred = objDT.Rows[0][convCourseLearningCase.ParentNodeReferred].ToString().Trim(); //章简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvCourseLearningCaseEN.ViewCount = TransNullToInt(objDT.Rows[0][convCourseLearningCase.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvCourseLearningCaseEN.IsShow = TransNullToBool(objDT.Rows[0][convCourseLearningCase.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objvCourseLearningCaseEN.DownloadNumber = TransNullToInt(objDT.Rows[0][convCourseLearningCase.DownloadNumber].ToString().Trim()); //下载数目(字段类型:int,字段长度:4,是否可空:True)
 objvCourseLearningCaseEN.FileIntegration = TransNullToInt(objDT.Rows[0][convCourseLearningCase.FileIntegration].ToString().Trim()); //文件积分(字段类型:int,字段长度:4,是否可空:True)
 objvCourseLearningCaseEN.LikeCount = TransNullToInt(objDT.Rows[0][convCourseLearningCase.LikeCount].ToString().Trim()); //资源喜欢数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvCourseLearningCaseEN.CollectionCount = TransNullToInt(objDT.Rows[0][convCourseLearningCase.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvCourseLearningCaseEN.RecommendedDegreeId = objDT.Rows[0][convCourseLearningCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvCourseLearningCaseEN.RecommendedDegreeName = objDT.Rows[0][convCourseLearningCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCourseLearningCaseEN.ftpFileType = objDT.Rows[0][convCourseLearningCase.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvCourseLearningCaseEN.VideoUrl = objDT.Rows[0][convCourseLearningCase.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCourseLearningCaseEN.VideoPath = objDT.Rows[0][convCourseLearningCase.VideoPath].ToString().Trim(); //视频目录(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCourseLearningCaseEN.ImageUrl = objDT.Rows[0][convCourseLearningCase.ImageUrl].ToString().Trim(); //ImageUrl(字段类型:varchar,字段长度:100,是否可空:True)
 objvCourseLearningCaseEN.ResErrMsg = objDT.Rows[0][convCourseLearningCase.ResErrMsg].ToString().Trim(); //资源错误信息(字段类型:varchar,字段长度:30,是否可空:True)
 objvCourseLearningCaseEN.OrderNum = TransNullToInt(objDT.Rows[0][convCourseLearningCase.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvCourseLearningCaseEN.UpdDate = objDT.Rows[0][convCourseLearningCase.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvCourseLearningCaseEN.UpdUserId = objDT.Rows[0][convCourseLearningCase.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvCourseLearningCaseEN.Memo = objDT.Rows[0][convCourseLearningCase.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCourseLearningCaseEN.IsHaveVideo = objDT.Rows[0][convCourseLearningCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo(字段类型:varchar,字段长度:6,是否可空:True)
 objvCourseLearningCaseEN.BrowseCount4Case = TransNullToInt(objDT.Rows[0][convCourseLearningCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvCourseLearningCaseEN.OwnerName = objDT.Rows[0][convCourseLearningCase.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvCourseLearningCaseEN.OwnerNameWithId = objDT.Rows[0][convCourseLearningCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvCourseLearningCaseDA: GetvCourseLearningCase)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdCourseLearningCase">表关键字</param>
 /// <returns>表对象</returns>
public clsvCourseLearningCaseEN GetObjByIdCourseLearningCase(string strIdCourseLearningCase)
{
CheckPrimaryKey(strIdCourseLearningCase);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCaseDA.GetSpecSQLObj();
strSQL = "Select * from vCourseLearningCase where IdCourseLearningCase = " + "'"+ strIdCourseLearningCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvCourseLearningCaseEN objvCourseLearningCaseEN = new clsvCourseLearningCaseEN();
try
{
 objvCourseLearningCaseEN.IdCourseLearningCase = objRow[convCourseLearningCase.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCaseEN.CourseLearningCaseID = objRow[convCourseLearningCase.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCaseEN.CourseLearningCaseName = objRow[convCourseLearningCase.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCourseLearningCaseEN.CourseLearningCaseText = objRow[convCourseLearningCase.CourseLearningCaseText] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objvCourseLearningCaseEN.CourseLearningCaseTheme = objRow[convCourseLearningCase.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvCourseLearningCaseEN.CourseLearningCaseDate = objRow[convCourseLearningCase.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseDate].ToString().Trim(); //课程学习日期(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningCaseEN.CourseLearningCaseTime = objRow[convCourseLearningCase.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseTime].ToString().Trim(); //课程学习时间(字段类型:char,字段长度:6,是否可空:True)
 objvCourseLearningCaseEN.CourseLearningCaseDateIn = objRow[convCourseLearningCase.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningCaseEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCase.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvCourseLearningCaseEN.IdCaseType = objRow[convCourseLearningCase.IdCaseType] == DBNull.Value ? null : objRow[convCourseLearningCase.IdCaseType].ToString().Trim(); //案例类型流水号(字段类型:char,字段长度:4,是否可空:True)
 objvCourseLearningCaseEN.CaseTypeName = objRow[convCourseLearningCase.CaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase.CaseTypeName].ToString().Trim(); //案例类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCourseLearningCaseEN.IdCourseLearningCaseType = objRow[convCourseLearningCase.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCaseEN.CourseLearningCaseTypeName = objRow[convCourseLearningCase.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCourseLearningCaseEN.OwnerId = objRow[convCourseLearningCase.OwnerId] == DBNull.Value ? null : objRow[convCourseLearningCase.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvCourseLearningCaseEN.IdStudyLevel = objRow[convCourseLearningCase.IdStudyLevel] == DBNull.Value ? null : objRow[convCourseLearningCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvCourseLearningCaseEN.StudyLevelName = objRow[convCourseLearningCase.StudyLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCourseLearningCaseEN.IdTeachingPlan = objRow[convCourseLearningCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convCourseLearningCase.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCaseEN.IdDiscipline = objRow[convCourseLearningCase.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCaseEN.DisciplineID = objRow[convCourseLearningCase.DisciplineID] == DBNull.Value ? null : objRow[convCourseLearningCase.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCaseEN.DisciplineName = objRow[convCourseLearningCase.DisciplineName] == DBNull.Value ? null : objRow[convCourseLearningCase.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCourseLearningCaseEN.IdSenateGaugeVersion = objRow[convCourseLearningCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convCourseLearningCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCaseEN.senateGaugeVersionID = objRow[convCourseLearningCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCaseEN.senateGaugeVersionName = objRow[convCourseLearningCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvCourseLearningCaseEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convCourseLearningCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvCourseLearningCaseEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase.IsUse].ToString().Trim()); //是否使用(字段类型:bit,字段长度:1,是否可空:True)
 objvCourseLearningCaseEN.VersionNo = objRow[convCourseLearningCase.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvCourseLearningCaseEN.IdTeachSkill = objRow[convCourseLearningCase.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCaseEN.TeachSkillID = objRow[convCourseLearningCase.TeachSkillID] == DBNull.Value ? null : objRow[convCourseLearningCase.TeachSkillID].ToString().Trim(); //教学技能ID(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCaseEN.SkillTypeName = objRow[convCourseLearningCase.SkillTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase.SkillTypeName].ToString().Trim(); //技能类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCourseLearningCaseEN.TeachSkillName = objRow[convCourseLearningCase.TeachSkillName] == DBNull.Value ? null : objRow[convCourseLearningCase.TeachSkillName].ToString().Trim(); //教学技能名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCourseLearningCaseEN.TeachSkillTheory = objRow[convCourseLearningCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convCourseLearningCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvCourseLearningCaseEN.TeachSkillOperMethod = objRow[convCourseLearningCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCourseLearningCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法(字段类型:varchar,字段长度:2000,是否可空:True)
 objvCourseLearningCaseEN.IdSkillType = objRow[convCourseLearningCase.IdSkillType] == DBNull.Value ? null : objRow[convCourseLearningCase.IdSkillType].ToString().Trim(); //技能类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCaseEN.SkillTypeID = objRow[convCourseLearningCase.SkillTypeID] == DBNull.Value ? null : objRow[convCourseLearningCase.SkillTypeID].ToString().Trim(); //技能类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCaseEN.CaseLevelId = objRow[convCourseLearningCase.CaseLevelId] == DBNull.Value ? null : objRow[convCourseLearningCase.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvCourseLearningCaseEN.CaseLevelName = objRow[convCourseLearningCase.CaseLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase.CaseLevelName].ToString().Trim(); //案例等级名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvCourseLearningCaseEN.DocFile = objRow[convCourseLearningCase.DocFile] == DBNull.Value ? null : objRow[convCourseLearningCase.DocFile].ToString().Trim(); //生成的Word文件名(字段类型:varchar,字段长度:200,是否可空:True)
 objvCourseLearningCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word(字段类型:bit,字段长度:1,是否可空:True)
 objvCourseLearningCaseEN.WordCreateDate = objRow[convCourseLearningCase.WordCreateDate] == DBNull.Value ? null : objRow[convCourseLearningCase.WordCreateDate].ToString().Trim(); //Word生成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objvCourseLearningCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvCourseLearningCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvCourseLearningCaseEN.IdXzCollege = objRow[convCourseLearningCase.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCase.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvCourseLearningCaseEN.CollegeId = objRow[convCourseLearningCase.CollegeId] == DBNull.Value ? null : objRow[convCourseLearningCase.CollegeId].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvCourseLearningCaseEN.CollegeName = objRow[convCourseLearningCase.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCase.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCourseLearningCaseEN.CollegeNameA = objRow[convCourseLearningCase.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCase.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvCourseLearningCaseEN.IdXzMajor = objRow[convCourseLearningCase.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCaseEN.MajorID = objRow[convCourseLearningCase.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCase.MajorID].ToString().Trim(); //专业ID(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCaseEN.MajorName = objRow[convCourseLearningCase.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCase.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCourseLearningCaseEN.CourseId = objRow[convCourseLearningCase.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningCaseEN.CourseCode = objRow[convCourseLearningCase.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvCourseLearningCaseEN.CourseName = objRow[convCourseLearningCase.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvCourseLearningCaseEN.CourseChapterId = objRow[convCourseLearningCase.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCaseEN.CourseChapterName = objRow[convCourseLearningCase.CourseChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseChapterName].ToString().Trim(); //课程章节名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCourseLearningCaseEN.ChapterId = objRow[convCourseLearningCase.ChapterId] == DBNull.Value ? null : objRow[convCourseLearningCase.ChapterId].ToString().Trim(); //章Id(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningCaseEN.SectionId = objRow[convCourseLearningCase.SectionId] == DBNull.Value ? null : objRow[convCourseLearningCase.SectionId].ToString().Trim(); //节Id(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningCaseEN.ChapterName = objRow[convCourseLearningCase.ChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase.ChapterName].ToString().Trim(); //章名(字段类型:varchar,字段长度:100,是否可空:True)
 objvCourseLearningCaseEN.SectionName = objRow[convCourseLearningCase.SectionName] == DBNull.Value ? null : objRow[convCourseLearningCase.SectionName].ToString().Trim(); //节名(字段类型:varchar,字段长度:100,是否可空:True)
 objvCourseLearningCaseEN.ChapterNameSim = objRow[convCourseLearningCase.ChapterNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase.ChapterNameSim].ToString().Trim(); //章名简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvCourseLearningCaseEN.SectionNameSim = objRow[convCourseLearningCase.SectionNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase.SectionNameSim].ToString().Trim(); //节名简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvCourseLearningCaseEN.ParentNodeId = objRow[convCourseLearningCase.ParentNodeId] == DBNull.Value ? null : objRow[convCourseLearningCase.ParentNodeId].ToString().Trim(); //父节点编号(字段类型:varchar,字段长度:8,是否可空:True)
 objvCourseLearningCaseEN.CourseChapterReferred = objRow[convCourseLearningCase.CourseChapterReferred] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseChapterReferred].ToString().Trim(); //节简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvCourseLearningCaseEN.ParentNodeName = objRow[convCourseLearningCase.ParentNodeName] == DBNull.Value ? null : objRow[convCourseLearningCase.ParentNodeName].ToString().Trim(); //父节点名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvCourseLearningCaseEN.ParentNodeReferred = objRow[convCourseLearningCase.ParentNodeReferred] == DBNull.Value ? null : objRow[convCourseLearningCase.ParentNodeReferred].ToString().Trim(); //章简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvCourseLearningCaseEN.ViewCount = objRow[convCourseLearningCase.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvCourseLearningCaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objvCourseLearningCaseEN.DownloadNumber = objRow[convCourseLearningCase.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.DownloadNumber].ToString().Trim()); //下载数目(字段类型:int,字段长度:4,是否可空:True)
 objvCourseLearningCaseEN.FileIntegration = objRow[convCourseLearningCase.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.FileIntegration].ToString().Trim()); //文件积分(字段类型:int,字段长度:4,是否可空:True)
 objvCourseLearningCaseEN.LikeCount = objRow[convCourseLearningCase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.LikeCount].ToString().Trim()); //资源喜欢数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvCourseLearningCaseEN.CollectionCount = objRow[convCourseLearningCase.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvCourseLearningCaseEN.RecommendedDegreeId = objRow[convCourseLearningCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvCourseLearningCaseEN.RecommendedDegreeName = objRow[convCourseLearningCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCourseLearningCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCourseLearningCaseEN.ftpFileType = objRow[convCourseLearningCase.ftpFileType] == DBNull.Value ? null : objRow[convCourseLearningCase.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvCourseLearningCaseEN.VideoUrl = objRow[convCourseLearningCase.VideoUrl] == DBNull.Value ? null : objRow[convCourseLearningCase.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCourseLearningCaseEN.VideoPath = objRow[convCourseLearningCase.VideoPath] == DBNull.Value ? null : objRow[convCourseLearningCase.VideoPath].ToString().Trim(); //视频目录(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCourseLearningCaseEN.ImageUrl = objRow[convCourseLearningCase.ImageUrl] == DBNull.Value ? null : objRow[convCourseLearningCase.ImageUrl].ToString().Trim(); //ImageUrl(字段类型:varchar,字段长度:100,是否可空:True)
 objvCourseLearningCaseEN.ResErrMsg = objRow[convCourseLearningCase.ResErrMsg] == DBNull.Value ? null : objRow[convCourseLearningCase.ResErrMsg].ToString().Trim(); //资源错误信息(字段类型:varchar,字段长度:30,是否可空:True)
 objvCourseLearningCaseEN.OrderNum = objRow[convCourseLearningCase.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvCourseLearningCaseEN.UpdDate = objRow[convCourseLearningCase.UpdDate] == DBNull.Value ? null : objRow[convCourseLearningCase.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvCourseLearningCaseEN.UpdUserId = objRow[convCourseLearningCase.UpdUserId] == DBNull.Value ? null : objRow[convCourseLearningCase.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvCourseLearningCaseEN.Memo = objRow[convCourseLearningCase.Memo] == DBNull.Value ? null : objRow[convCourseLearningCase.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCourseLearningCaseEN.IsHaveVideo = objRow[convCourseLearningCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo(字段类型:varchar,字段长度:6,是否可空:True)
 objvCourseLearningCaseEN.BrowseCount4Case = objRow[convCourseLearningCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvCourseLearningCaseEN.OwnerName = objRow[convCourseLearningCase.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCase.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvCourseLearningCaseEN.OwnerNameWithId = objRow[convCourseLearningCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvCourseLearningCaseDA: GetObjByIdCourseLearningCase)", objException.Message));
}
return objvCourseLearningCaseEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvCourseLearningCaseEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvCourseLearningCaseDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCaseDA.GetSpecSQLObj();
strSQL = "Select * from vCourseLearningCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvCourseLearningCaseEN objvCourseLearningCaseEN = new clsvCourseLearningCaseEN()
{
IdCourseLearningCase = objRow[convCourseLearningCase.IdCourseLearningCase].ToString().Trim(), //课程学习案例流水号
CourseLearningCaseID = objRow[convCourseLearningCase.CourseLearningCaseID].ToString().Trim(), //课程学习案例ID
CourseLearningCaseName = objRow[convCourseLearningCase.CourseLearningCaseName].ToString().Trim(), //课程学习案例名称
CourseLearningCaseText = objRow[convCourseLearningCase.CourseLearningCaseText] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseText].ToString().Trim(), //案例文本内容
CourseLearningCaseTheme = objRow[convCourseLearningCase.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseTheme].ToString().Trim(), //课程学习案例主题词
CourseLearningCaseDate = objRow[convCourseLearningCase.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseDate].ToString().Trim(), //课程学习日期
CourseLearningCaseTime = objRow[convCourseLearningCase.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseTime].ToString().Trim(), //课程学习时间
CourseLearningCaseDateIn = objRow[convCourseLearningCase.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseDateIn].ToString().Trim(), //案例入库日期
CourseLearningCaseTimeIn = objRow[convCourseLearningCase.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseTimeIn].ToString().Trim(), //案例入库时间
IdCaseType = objRow[convCourseLearningCase.IdCaseType] == DBNull.Value ? null : objRow[convCourseLearningCase.IdCaseType].ToString().Trim(), //案例类型流水号
CaseTypeName = objRow[convCourseLearningCase.CaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase.CaseTypeName].ToString().Trim(), //案例类型名称
IdCourseLearningCaseType = objRow[convCourseLearningCase.IdCourseLearningCaseType].ToString().Trim(), //课程学习案例类型流水号
CourseLearningCaseTypeName = objRow[convCourseLearningCase.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseTypeName].ToString().Trim(), //课程学习案例类型名称
OwnerId = objRow[convCourseLearningCase.OwnerId] == DBNull.Value ? null : objRow[convCourseLearningCase.OwnerId].ToString().Trim(), //拥有者Id
IdStudyLevel = objRow[convCourseLearningCase.IdStudyLevel] == DBNull.Value ? null : objRow[convCourseLearningCase.IdStudyLevel].ToString().Trim(), //id_StudyLevel
StudyLevelName = objRow[convCourseLearningCase.StudyLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase.StudyLevelName].ToString().Trim(), //学段名称
IdTeachingPlan = objRow[convCourseLearningCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convCourseLearningCase.IdTeachingPlan].ToString().Trim(), //教案流水号
IdDiscipline = objRow[convCourseLearningCase.IdDiscipline].ToString().Trim(), //学科流水号
DisciplineID = objRow[convCourseLearningCase.DisciplineID] == DBNull.Value ? null : objRow[convCourseLearningCase.DisciplineID].ToString().Trim(), //学科ID
DisciplineName = objRow[convCourseLearningCase.DisciplineName] == DBNull.Value ? null : objRow[convCourseLearningCase.DisciplineName].ToString().Trim(), //学科名称
IdSenateGaugeVersion = objRow[convCourseLearningCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convCourseLearningCase.IdSenateGaugeVersion].ToString().Trim(), //评价量表版本流水号
senateGaugeVersionID = objRow[convCourseLearningCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCase.senateGaugeVersionID].ToString().Trim(), //评价量表版本ID
senateGaugeVersionName = objRow[convCourseLearningCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCase.senateGaugeVersionName].ToString().Trim(), //评价量表版本名称
senateGaugeVersionTtlScore = objRow[convCourseLearningCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convCourseLearningCase.senateGaugeVersionTtlScore].ToString().Trim()), //评价量表版本总分
IsUse = TransNullToBool(objRow[convCourseLearningCase.IsUse].ToString().Trim()), //是否使用
VersionNo = objRow[convCourseLearningCase.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase.VersionNo].ToString().Trim()), //版本号
IdTeachSkill = objRow[convCourseLearningCase.IdTeachSkill].ToString().Trim(), //教学技能流水号
TeachSkillID = objRow[convCourseLearningCase.TeachSkillID] == DBNull.Value ? null : objRow[convCourseLearningCase.TeachSkillID].ToString().Trim(), //教学技能ID
SkillTypeName = objRow[convCourseLearningCase.SkillTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase.SkillTypeName].ToString().Trim(), //技能类型名称
TeachSkillName = objRow[convCourseLearningCase.TeachSkillName] == DBNull.Value ? null : objRow[convCourseLearningCase.TeachSkillName].ToString().Trim(), //教学技能名称
TeachSkillTheory = objRow[convCourseLearningCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convCourseLearningCase.TeachSkillTheory].ToString().Trim(), //教学技能理论阐述
TeachSkillOperMethod = objRow[convCourseLearningCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCourseLearningCase.TeachSkillOperMethod].ToString().Trim(), //教学技能实践操作方法
IdSkillType = objRow[convCourseLearningCase.IdSkillType] == DBNull.Value ? null : objRow[convCourseLearningCase.IdSkillType].ToString().Trim(), //技能类型流水号
SkillTypeID = objRow[convCourseLearningCase.SkillTypeID] == DBNull.Value ? null : objRow[convCourseLearningCase.SkillTypeID].ToString().Trim(), //技能类型ID
CaseLevelId = objRow[convCourseLearningCase.CaseLevelId] == DBNull.Value ? null : objRow[convCourseLearningCase.CaseLevelId].ToString().Trim(), //课例等级Id
CaseLevelName = objRow[convCourseLearningCase.CaseLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase.CaseLevelName].ToString().Trim(), //案例等级名称
DocFile = objRow[convCourseLearningCase.DocFile] == DBNull.Value ? null : objRow[convCourseLearningCase.DocFile].ToString().Trim(), //生成的Word文件名
IsNeedGeneWord = TransNullToBool(objRow[convCourseLearningCase.IsNeedGeneWord].ToString().Trim()), //是否需要生成Word
WordCreateDate = objRow[convCourseLearningCase.WordCreateDate] == DBNull.Value ? null : objRow[convCourseLearningCase.WordCreateDate].ToString().Trim(), //Word生成日期
IsVisible = TransNullToBool(objRow[convCourseLearningCase.IsVisible].ToString().Trim()), //是否显示
IsDualVideo = TransNullToBool(objRow[convCourseLearningCase.IsDualVideo].ToString().Trim()), //是否双视频
IdXzCollege = objRow[convCourseLearningCase.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCase.IdXzCollege].ToString().Trim(), //学院流水号
CollegeId = objRow[convCourseLearningCase.CollegeId] == DBNull.Value ? null : objRow[convCourseLearningCase.CollegeId].ToString().Trim(), //学院ID
CollegeName = objRow[convCourseLearningCase.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCase.CollegeName].ToString().Trim(), //学院名称
CollegeNameA = objRow[convCourseLearningCase.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCase.CollegeNameA].ToString().Trim(), //学院名称简写
IdXzMajor = objRow[convCourseLearningCase.IdXzMajor].ToString().Trim(), //专业流水号
MajorID = objRow[convCourseLearningCase.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCase.MajorID].ToString().Trim(), //专业ID
MajorName = objRow[convCourseLearningCase.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCase.MajorName].ToString().Trim(), //专业名称
CourseId = objRow[convCourseLearningCase.CourseId].ToString().Trim(), //课程Id
CourseCode = objRow[convCourseLearningCase.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseCode].ToString().Trim(), //课程代码
CourseName = objRow[convCourseLearningCase.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseName].ToString().Trim(), //课程名称
CourseChapterId = objRow[convCourseLearningCase.CourseChapterId].ToString().Trim(), //课程章节ID
CourseChapterName = objRow[convCourseLearningCase.CourseChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseChapterName].ToString().Trim(), //课程章节名称
ChapterId = objRow[convCourseLearningCase.ChapterId] == DBNull.Value ? null : objRow[convCourseLearningCase.ChapterId].ToString().Trim(), //章Id
SectionId = objRow[convCourseLearningCase.SectionId] == DBNull.Value ? null : objRow[convCourseLearningCase.SectionId].ToString().Trim(), //节Id
ChapterName = objRow[convCourseLearningCase.ChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase.ChapterName].ToString().Trim(), //章名
SectionName = objRow[convCourseLearningCase.SectionName] == DBNull.Value ? null : objRow[convCourseLearningCase.SectionName].ToString().Trim(), //节名
ChapterNameSim = objRow[convCourseLearningCase.ChapterNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase.ChapterNameSim].ToString().Trim(), //章名简称
SectionNameSim = objRow[convCourseLearningCase.SectionNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase.SectionNameSim].ToString().Trim(), //节名简称
ParentNodeId = objRow[convCourseLearningCase.ParentNodeId] == DBNull.Value ? null : objRow[convCourseLearningCase.ParentNodeId].ToString().Trim(), //父节点编号
CourseChapterReferred = objRow[convCourseLearningCase.CourseChapterReferred] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseChapterReferred].ToString().Trim(), //节简称
ParentNodeName = objRow[convCourseLearningCase.ParentNodeName] == DBNull.Value ? null : objRow[convCourseLearningCase.ParentNodeName].ToString().Trim(), //父节点名称
ParentNodeReferred = objRow[convCourseLearningCase.ParentNodeReferred] == DBNull.Value ? null : objRow[convCourseLearningCase.ParentNodeReferred].ToString().Trim(), //章简称
ViewCount = objRow[convCourseLearningCase.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase.ViewCount].ToString().Trim()), //浏览量
IsShow = TransNullToBool(objRow[convCourseLearningCase.IsShow].ToString().Trim()), //是否启用
DownloadNumber = objRow[convCourseLearningCase.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase.DownloadNumber].ToString().Trim()), //下载数目
FileIntegration = objRow[convCourseLearningCase.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase.FileIntegration].ToString().Trim()), //文件积分
LikeCount = objRow[convCourseLearningCase.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCourseLearningCase.LikeCount].ToString().Trim()), //资源喜欢数量
CollectionCount = objRow[convCourseLearningCase.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCourseLearningCase.CollectionCount].ToString().Trim()), //收藏数量
RecommendedDegreeId = objRow[convCourseLearningCase.RecommendedDegreeId].ToString().Trim(), //推荐度Id
RecommendedDegreeName = objRow[convCourseLearningCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCourseLearningCase.RecommendedDegreeName].ToString().Trim(), //推荐度名称
ftpFileType = objRow[convCourseLearningCase.ftpFileType] == DBNull.Value ? null : objRow[convCourseLearningCase.ftpFileType].ToString().Trim(), //ftp文件类型
VideoUrl = objRow[convCourseLearningCase.VideoUrl] == DBNull.Value ? null : objRow[convCourseLearningCase.VideoUrl].ToString().Trim(), //视频Url
VideoPath = objRow[convCourseLearningCase.VideoPath] == DBNull.Value ? null : objRow[convCourseLearningCase.VideoPath].ToString().Trim(), //视频目录
ImageUrl = objRow[convCourseLearningCase.ImageUrl] == DBNull.Value ? null : objRow[convCourseLearningCase.ImageUrl].ToString().Trim(), //ImageUrl
ResErrMsg = objRow[convCourseLearningCase.ResErrMsg] == DBNull.Value ? null : objRow[convCourseLearningCase.ResErrMsg].ToString().Trim(), //资源错误信息
OrderNum = objRow[convCourseLearningCase.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase.OrderNum].ToString().Trim()), //序号
UpdDate = objRow[convCourseLearningCase.UpdDate] == DBNull.Value ? null : objRow[convCourseLearningCase.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[convCourseLearningCase.UpdUserId] == DBNull.Value ? null : objRow[convCourseLearningCase.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[convCourseLearningCase.Memo] == DBNull.Value ? null : objRow[convCourseLearningCase.Memo].ToString().Trim(), //备注
IsHaveVideo = objRow[convCourseLearningCase.IsHaveVideo].ToString().Trim(), //IsHaveVideo
BrowseCount4Case = objRow[convCourseLearningCase.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase.BrowseCount4Case].ToString().Trim()), //课例浏览次数
OwnerName = objRow[convCourseLearningCase.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCase.OwnerName].ToString().Trim(), //拥有者姓名
OwnerNameWithId = objRow[convCourseLearningCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCase.OwnerNameWithId].ToString().Trim() //拥有者名称附Id
};
objvCourseLearningCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCourseLearningCaseEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvCourseLearningCaseDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvCourseLearningCaseEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCourseLearningCaseEN objvCourseLearningCaseEN = new clsvCourseLearningCaseEN();
try
{
objvCourseLearningCaseEN.IdCourseLearningCase = objRow[convCourseLearningCase.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCaseEN.CourseLearningCaseID = objRow[convCourseLearningCase.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCaseEN.CourseLearningCaseName = objRow[convCourseLearningCase.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCaseEN.CourseLearningCaseText = objRow[convCourseLearningCase.CourseLearningCaseText] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseText].ToString().Trim(); //案例文本内容
objvCourseLearningCaseEN.CourseLearningCaseTheme = objRow[convCourseLearningCase.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningCaseEN.CourseLearningCaseDate = objRow[convCourseLearningCase.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningCaseEN.CourseLearningCaseTime = objRow[convCourseLearningCase.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningCaseEN.CourseLearningCaseDateIn = objRow[convCourseLearningCase.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningCaseEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCase.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningCaseEN.IdCaseType = objRow[convCourseLearningCase.IdCaseType] == DBNull.Value ? null : objRow[convCourseLearningCase.IdCaseType].ToString().Trim(); //案例类型流水号
objvCourseLearningCaseEN.CaseTypeName = objRow[convCourseLearningCase.CaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase.CaseTypeName].ToString().Trim(); //案例类型名称
objvCourseLearningCaseEN.IdCourseLearningCaseType = objRow[convCourseLearningCase.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号
objvCourseLearningCaseEN.CourseLearningCaseTypeName = objRow[convCourseLearningCase.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningCaseEN.OwnerId = objRow[convCourseLearningCase.OwnerId] == DBNull.Value ? null : objRow[convCourseLearningCase.OwnerId].ToString().Trim(); //拥有者Id
objvCourseLearningCaseEN.IdStudyLevel = objRow[convCourseLearningCase.IdStudyLevel] == DBNull.Value ? null : objRow[convCourseLearningCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCourseLearningCaseEN.StudyLevelName = objRow[convCourseLearningCase.StudyLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase.StudyLevelName].ToString().Trim(); //学段名称
objvCourseLearningCaseEN.IdTeachingPlan = objRow[convCourseLearningCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convCourseLearningCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCourseLearningCaseEN.IdDiscipline = objRow[convCourseLearningCase.IdDiscipline].ToString().Trim(); //学科流水号
objvCourseLearningCaseEN.DisciplineID = objRow[convCourseLearningCase.DisciplineID] == DBNull.Value ? null : objRow[convCourseLearningCase.DisciplineID].ToString().Trim(); //学科ID
objvCourseLearningCaseEN.DisciplineName = objRow[convCourseLearningCase.DisciplineName] == DBNull.Value ? null : objRow[convCourseLearningCase.DisciplineName].ToString().Trim(); //学科名称
objvCourseLearningCaseEN.IdSenateGaugeVersion = objRow[convCourseLearningCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convCourseLearningCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCourseLearningCaseEN.senateGaugeVersionID = objRow[convCourseLearningCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCourseLearningCaseEN.senateGaugeVersionName = objRow[convCourseLearningCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCourseLearningCaseEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convCourseLearningCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCourseLearningCaseEN.IsUse = TransNullToBool(objRow[convCourseLearningCase.IsUse].ToString().Trim()); //是否使用
objvCourseLearningCaseEN.VersionNo = objRow[convCourseLearningCase.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase.VersionNo].ToString().Trim()); //版本号
objvCourseLearningCaseEN.IdTeachSkill = objRow[convCourseLearningCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCourseLearningCaseEN.TeachSkillID = objRow[convCourseLearningCase.TeachSkillID] == DBNull.Value ? null : objRow[convCourseLearningCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvCourseLearningCaseEN.SkillTypeName = objRow[convCourseLearningCase.SkillTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvCourseLearningCaseEN.TeachSkillName = objRow[convCourseLearningCase.TeachSkillName] == DBNull.Value ? null : objRow[convCourseLearningCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvCourseLearningCaseEN.TeachSkillTheory = objRow[convCourseLearningCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convCourseLearningCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCourseLearningCaseEN.TeachSkillOperMethod = objRow[convCourseLearningCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCourseLearningCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCourseLearningCaseEN.IdSkillType = objRow[convCourseLearningCase.IdSkillType] == DBNull.Value ? null : objRow[convCourseLearningCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvCourseLearningCaseEN.SkillTypeID = objRow[convCourseLearningCase.SkillTypeID] == DBNull.Value ? null : objRow[convCourseLearningCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvCourseLearningCaseEN.CaseLevelId = objRow[convCourseLearningCase.CaseLevelId] == DBNull.Value ? null : objRow[convCourseLearningCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvCourseLearningCaseEN.CaseLevelName = objRow[convCourseLearningCase.CaseLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvCourseLearningCaseEN.DocFile = objRow[convCourseLearningCase.DocFile] == DBNull.Value ? null : objRow[convCourseLearningCase.DocFile].ToString().Trim(); //生成的Word文件名
objvCourseLearningCaseEN.IsNeedGeneWord = TransNullToBool(objRow[convCourseLearningCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvCourseLearningCaseEN.WordCreateDate = objRow[convCourseLearningCase.WordCreateDate] == DBNull.Value ? null : objRow[convCourseLearningCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvCourseLearningCaseEN.IsVisible = TransNullToBool(objRow[convCourseLearningCase.IsVisible].ToString().Trim()); //是否显示
objvCourseLearningCaseEN.IsDualVideo = TransNullToBool(objRow[convCourseLearningCase.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCaseEN.IdXzCollege = objRow[convCourseLearningCase.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCase.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCaseEN.CollegeId = objRow[convCourseLearningCase.CollegeId] == DBNull.Value ? null : objRow[convCourseLearningCase.CollegeId].ToString().Trim(); //学院ID
objvCourseLearningCaseEN.CollegeName = objRow[convCourseLearningCase.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCase.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCaseEN.CollegeNameA = objRow[convCourseLearningCase.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningCaseEN.IdXzMajor = objRow[convCourseLearningCase.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningCaseEN.MajorID = objRow[convCourseLearningCase.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCase.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCaseEN.MajorName = objRow[convCourseLearningCase.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCase.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCaseEN.CourseId = objRow[convCourseLearningCase.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCaseEN.CourseCode = objRow[convCourseLearningCase.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCaseEN.CourseName = objRow[convCourseLearningCase.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCaseEN.CourseChapterId = objRow[convCourseLearningCase.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCaseEN.CourseChapterName = objRow[convCourseLearningCase.CourseChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseChapterName].ToString().Trim(); //课程章节名称
objvCourseLearningCaseEN.ChapterId = objRow[convCourseLearningCase.ChapterId] == DBNull.Value ? null : objRow[convCourseLearningCase.ChapterId].ToString().Trim(); //章Id
objvCourseLearningCaseEN.SectionId = objRow[convCourseLearningCase.SectionId] == DBNull.Value ? null : objRow[convCourseLearningCase.SectionId].ToString().Trim(); //节Id
objvCourseLearningCaseEN.ChapterName = objRow[convCourseLearningCase.ChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase.ChapterName].ToString().Trim(); //章名
objvCourseLearningCaseEN.SectionName = objRow[convCourseLearningCase.SectionName] == DBNull.Value ? null : objRow[convCourseLearningCase.SectionName].ToString().Trim(); //节名
objvCourseLearningCaseEN.ChapterNameSim = objRow[convCourseLearningCase.ChapterNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase.ChapterNameSim].ToString().Trim(); //章名简称
objvCourseLearningCaseEN.SectionNameSim = objRow[convCourseLearningCase.SectionNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase.SectionNameSim].ToString().Trim(); //节名简称
objvCourseLearningCaseEN.ParentNodeId = objRow[convCourseLearningCase.ParentNodeId] == DBNull.Value ? null : objRow[convCourseLearningCase.ParentNodeId].ToString().Trim(); //父节点编号
objvCourseLearningCaseEN.CourseChapterReferred = objRow[convCourseLearningCase.CourseChapterReferred] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseChapterReferred].ToString().Trim(); //节简称
objvCourseLearningCaseEN.ParentNodeName = objRow[convCourseLearningCase.ParentNodeName] == DBNull.Value ? null : objRow[convCourseLearningCase.ParentNodeName].ToString().Trim(); //父节点名称
objvCourseLearningCaseEN.ParentNodeReferred = objRow[convCourseLearningCase.ParentNodeReferred] == DBNull.Value ? null : objRow[convCourseLearningCase.ParentNodeReferred].ToString().Trim(); //章简称
objvCourseLearningCaseEN.ViewCount = objRow[convCourseLearningCase.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase.ViewCount].ToString().Trim()); //浏览量
objvCourseLearningCaseEN.IsShow = TransNullToBool(objRow[convCourseLearningCase.IsShow].ToString().Trim()); //是否启用
objvCourseLearningCaseEN.DownloadNumber = objRow[convCourseLearningCase.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase.DownloadNumber].ToString().Trim()); //下载数目
objvCourseLearningCaseEN.FileIntegration = objRow[convCourseLearningCase.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase.FileIntegration].ToString().Trim()); //文件积分
objvCourseLearningCaseEN.LikeCount = objRow[convCourseLearningCase.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCourseLearningCase.LikeCount].ToString().Trim()); //资源喜欢数量
objvCourseLearningCaseEN.CollectionCount = objRow[convCourseLearningCase.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCourseLearningCase.CollectionCount].ToString().Trim()); //收藏数量
objvCourseLearningCaseEN.RecommendedDegreeId = objRow[convCourseLearningCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCourseLearningCaseEN.RecommendedDegreeName = objRow[convCourseLearningCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCourseLearningCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCourseLearningCaseEN.ftpFileType = objRow[convCourseLearningCase.ftpFileType] == DBNull.Value ? null : objRow[convCourseLearningCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvCourseLearningCaseEN.VideoUrl = objRow[convCourseLearningCase.VideoUrl] == DBNull.Value ? null : objRow[convCourseLearningCase.VideoUrl].ToString().Trim(); //视频Url
objvCourseLearningCaseEN.VideoPath = objRow[convCourseLearningCase.VideoPath] == DBNull.Value ? null : objRow[convCourseLearningCase.VideoPath].ToString().Trim(); //视频目录
objvCourseLearningCaseEN.ImageUrl = objRow[convCourseLearningCase.ImageUrl] == DBNull.Value ? null : objRow[convCourseLearningCase.ImageUrl].ToString().Trim(); //ImageUrl
objvCourseLearningCaseEN.ResErrMsg = objRow[convCourseLearningCase.ResErrMsg] == DBNull.Value ? null : objRow[convCourseLearningCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvCourseLearningCaseEN.OrderNum = objRow[convCourseLearningCase.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase.OrderNum].ToString().Trim()); //序号
objvCourseLearningCaseEN.UpdDate = objRow[convCourseLearningCase.UpdDate] == DBNull.Value ? null : objRow[convCourseLearningCase.UpdDate].ToString().Trim(); //修改日期
objvCourseLearningCaseEN.UpdUserId = objRow[convCourseLearningCase.UpdUserId] == DBNull.Value ? null : objRow[convCourseLearningCase.UpdUserId].ToString().Trim(); //修改用户Id
objvCourseLearningCaseEN.Memo = objRow[convCourseLearningCase.Memo] == DBNull.Value ? null : objRow[convCourseLearningCase.Memo].ToString().Trim(); //备注
objvCourseLearningCaseEN.IsHaveVideo = objRow[convCourseLearningCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
objvCourseLearningCaseEN.BrowseCount4Case = objRow[convCourseLearningCase.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningCaseEN.OwnerName = objRow[convCourseLearningCase.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCase.OwnerName].ToString().Trim(); //拥有者姓名
objvCourseLearningCaseEN.OwnerNameWithId = objRow[convCourseLearningCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvCourseLearningCaseDA: GetObjByDataRowvCourseLearningCase)", objException.Message));
}
objvCourseLearningCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCourseLearningCaseEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvCourseLearningCaseEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCourseLearningCaseEN objvCourseLearningCaseEN = new clsvCourseLearningCaseEN();
try
{
objvCourseLearningCaseEN.IdCourseLearningCase = objRow[convCourseLearningCase.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCaseEN.CourseLearningCaseID = objRow[convCourseLearningCase.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCaseEN.CourseLearningCaseName = objRow[convCourseLearningCase.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCaseEN.CourseLearningCaseText = objRow[convCourseLearningCase.CourseLearningCaseText] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseText].ToString().Trim(); //案例文本内容
objvCourseLearningCaseEN.CourseLearningCaseTheme = objRow[convCourseLearningCase.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningCaseEN.CourseLearningCaseDate = objRow[convCourseLearningCase.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningCaseEN.CourseLearningCaseTime = objRow[convCourseLearningCase.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningCaseEN.CourseLearningCaseDateIn = objRow[convCourseLearningCase.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningCaseEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCase.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningCaseEN.IdCaseType = objRow[convCourseLearningCase.IdCaseType] == DBNull.Value ? null : objRow[convCourseLearningCase.IdCaseType].ToString().Trim(); //案例类型流水号
objvCourseLearningCaseEN.CaseTypeName = objRow[convCourseLearningCase.CaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase.CaseTypeName].ToString().Trim(); //案例类型名称
objvCourseLearningCaseEN.IdCourseLearningCaseType = objRow[convCourseLearningCase.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号
objvCourseLearningCaseEN.CourseLearningCaseTypeName = objRow[convCourseLearningCase.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningCaseEN.OwnerId = objRow[convCourseLearningCase.OwnerId] == DBNull.Value ? null : objRow[convCourseLearningCase.OwnerId].ToString().Trim(); //拥有者Id
objvCourseLearningCaseEN.IdStudyLevel = objRow[convCourseLearningCase.IdStudyLevel] == DBNull.Value ? null : objRow[convCourseLearningCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCourseLearningCaseEN.StudyLevelName = objRow[convCourseLearningCase.StudyLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase.StudyLevelName].ToString().Trim(); //学段名称
objvCourseLearningCaseEN.IdTeachingPlan = objRow[convCourseLearningCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convCourseLearningCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCourseLearningCaseEN.IdDiscipline = objRow[convCourseLearningCase.IdDiscipline].ToString().Trim(); //学科流水号
objvCourseLearningCaseEN.DisciplineID = objRow[convCourseLearningCase.DisciplineID] == DBNull.Value ? null : objRow[convCourseLearningCase.DisciplineID].ToString().Trim(); //学科ID
objvCourseLearningCaseEN.DisciplineName = objRow[convCourseLearningCase.DisciplineName] == DBNull.Value ? null : objRow[convCourseLearningCase.DisciplineName].ToString().Trim(); //学科名称
objvCourseLearningCaseEN.IdSenateGaugeVersion = objRow[convCourseLearningCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convCourseLearningCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCourseLearningCaseEN.senateGaugeVersionID = objRow[convCourseLearningCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCourseLearningCaseEN.senateGaugeVersionName = objRow[convCourseLearningCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCourseLearningCaseEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convCourseLearningCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCourseLearningCaseEN.IsUse = TransNullToBool(objRow[convCourseLearningCase.IsUse].ToString().Trim()); //是否使用
objvCourseLearningCaseEN.VersionNo = objRow[convCourseLearningCase.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase.VersionNo].ToString().Trim()); //版本号
objvCourseLearningCaseEN.IdTeachSkill = objRow[convCourseLearningCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCourseLearningCaseEN.TeachSkillID = objRow[convCourseLearningCase.TeachSkillID] == DBNull.Value ? null : objRow[convCourseLearningCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvCourseLearningCaseEN.SkillTypeName = objRow[convCourseLearningCase.SkillTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvCourseLearningCaseEN.TeachSkillName = objRow[convCourseLearningCase.TeachSkillName] == DBNull.Value ? null : objRow[convCourseLearningCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvCourseLearningCaseEN.TeachSkillTheory = objRow[convCourseLearningCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convCourseLearningCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCourseLearningCaseEN.TeachSkillOperMethod = objRow[convCourseLearningCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCourseLearningCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCourseLearningCaseEN.IdSkillType = objRow[convCourseLearningCase.IdSkillType] == DBNull.Value ? null : objRow[convCourseLearningCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvCourseLearningCaseEN.SkillTypeID = objRow[convCourseLearningCase.SkillTypeID] == DBNull.Value ? null : objRow[convCourseLearningCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvCourseLearningCaseEN.CaseLevelId = objRow[convCourseLearningCase.CaseLevelId] == DBNull.Value ? null : objRow[convCourseLearningCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvCourseLearningCaseEN.CaseLevelName = objRow[convCourseLearningCase.CaseLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvCourseLearningCaseEN.DocFile = objRow[convCourseLearningCase.DocFile] == DBNull.Value ? null : objRow[convCourseLearningCase.DocFile].ToString().Trim(); //生成的Word文件名
objvCourseLearningCaseEN.IsNeedGeneWord = TransNullToBool(objRow[convCourseLearningCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvCourseLearningCaseEN.WordCreateDate = objRow[convCourseLearningCase.WordCreateDate] == DBNull.Value ? null : objRow[convCourseLearningCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvCourseLearningCaseEN.IsVisible = TransNullToBool(objRow[convCourseLearningCase.IsVisible].ToString().Trim()); //是否显示
objvCourseLearningCaseEN.IsDualVideo = TransNullToBool(objRow[convCourseLearningCase.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCaseEN.IdXzCollege = objRow[convCourseLearningCase.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCase.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCaseEN.CollegeId = objRow[convCourseLearningCase.CollegeId] == DBNull.Value ? null : objRow[convCourseLearningCase.CollegeId].ToString().Trim(); //学院ID
objvCourseLearningCaseEN.CollegeName = objRow[convCourseLearningCase.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCase.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCaseEN.CollegeNameA = objRow[convCourseLearningCase.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningCaseEN.IdXzMajor = objRow[convCourseLearningCase.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningCaseEN.MajorID = objRow[convCourseLearningCase.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCase.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCaseEN.MajorName = objRow[convCourseLearningCase.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCase.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCaseEN.CourseId = objRow[convCourseLearningCase.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCaseEN.CourseCode = objRow[convCourseLearningCase.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCaseEN.CourseName = objRow[convCourseLearningCase.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCaseEN.CourseChapterId = objRow[convCourseLearningCase.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCaseEN.CourseChapterName = objRow[convCourseLearningCase.CourseChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseChapterName].ToString().Trim(); //课程章节名称
objvCourseLearningCaseEN.ChapterId = objRow[convCourseLearningCase.ChapterId] == DBNull.Value ? null : objRow[convCourseLearningCase.ChapterId].ToString().Trim(); //章Id
objvCourseLearningCaseEN.SectionId = objRow[convCourseLearningCase.SectionId] == DBNull.Value ? null : objRow[convCourseLearningCase.SectionId].ToString().Trim(); //节Id
objvCourseLearningCaseEN.ChapterName = objRow[convCourseLearningCase.ChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase.ChapterName].ToString().Trim(); //章名
objvCourseLearningCaseEN.SectionName = objRow[convCourseLearningCase.SectionName] == DBNull.Value ? null : objRow[convCourseLearningCase.SectionName].ToString().Trim(); //节名
objvCourseLearningCaseEN.ChapterNameSim = objRow[convCourseLearningCase.ChapterNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase.ChapterNameSim].ToString().Trim(); //章名简称
objvCourseLearningCaseEN.SectionNameSim = objRow[convCourseLearningCase.SectionNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase.SectionNameSim].ToString().Trim(); //节名简称
objvCourseLearningCaseEN.ParentNodeId = objRow[convCourseLearningCase.ParentNodeId] == DBNull.Value ? null : objRow[convCourseLearningCase.ParentNodeId].ToString().Trim(); //父节点编号
objvCourseLearningCaseEN.CourseChapterReferred = objRow[convCourseLearningCase.CourseChapterReferred] == DBNull.Value ? null : objRow[convCourseLearningCase.CourseChapterReferred].ToString().Trim(); //节简称
objvCourseLearningCaseEN.ParentNodeName = objRow[convCourseLearningCase.ParentNodeName] == DBNull.Value ? null : objRow[convCourseLearningCase.ParentNodeName].ToString().Trim(); //父节点名称
objvCourseLearningCaseEN.ParentNodeReferred = objRow[convCourseLearningCase.ParentNodeReferred] == DBNull.Value ? null : objRow[convCourseLearningCase.ParentNodeReferred].ToString().Trim(); //章简称
objvCourseLearningCaseEN.ViewCount = objRow[convCourseLearningCase.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase.ViewCount].ToString().Trim()); //浏览量
objvCourseLearningCaseEN.IsShow = TransNullToBool(objRow[convCourseLearningCase.IsShow].ToString().Trim()); //是否启用
objvCourseLearningCaseEN.DownloadNumber = objRow[convCourseLearningCase.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase.DownloadNumber].ToString().Trim()); //下载数目
objvCourseLearningCaseEN.FileIntegration = objRow[convCourseLearningCase.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase.FileIntegration].ToString().Trim()); //文件积分
objvCourseLearningCaseEN.LikeCount = objRow[convCourseLearningCase.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCourseLearningCase.LikeCount].ToString().Trim()); //资源喜欢数量
objvCourseLearningCaseEN.CollectionCount = objRow[convCourseLearningCase.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCourseLearningCase.CollectionCount].ToString().Trim()); //收藏数量
objvCourseLearningCaseEN.RecommendedDegreeId = objRow[convCourseLearningCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCourseLearningCaseEN.RecommendedDegreeName = objRow[convCourseLearningCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCourseLearningCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCourseLearningCaseEN.ftpFileType = objRow[convCourseLearningCase.ftpFileType] == DBNull.Value ? null : objRow[convCourseLearningCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvCourseLearningCaseEN.VideoUrl = objRow[convCourseLearningCase.VideoUrl] == DBNull.Value ? null : objRow[convCourseLearningCase.VideoUrl].ToString().Trim(); //视频Url
objvCourseLearningCaseEN.VideoPath = objRow[convCourseLearningCase.VideoPath] == DBNull.Value ? null : objRow[convCourseLearningCase.VideoPath].ToString().Trim(); //视频目录
objvCourseLearningCaseEN.ImageUrl = objRow[convCourseLearningCase.ImageUrl] == DBNull.Value ? null : objRow[convCourseLearningCase.ImageUrl].ToString().Trim(); //ImageUrl
objvCourseLearningCaseEN.ResErrMsg = objRow[convCourseLearningCase.ResErrMsg] == DBNull.Value ? null : objRow[convCourseLearningCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvCourseLearningCaseEN.OrderNum = objRow[convCourseLearningCase.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase.OrderNum].ToString().Trim()); //序号
objvCourseLearningCaseEN.UpdDate = objRow[convCourseLearningCase.UpdDate] == DBNull.Value ? null : objRow[convCourseLearningCase.UpdDate].ToString().Trim(); //修改日期
objvCourseLearningCaseEN.UpdUserId = objRow[convCourseLearningCase.UpdUserId] == DBNull.Value ? null : objRow[convCourseLearningCase.UpdUserId].ToString().Trim(); //修改用户Id
objvCourseLearningCaseEN.Memo = objRow[convCourseLearningCase.Memo] == DBNull.Value ? null : objRow[convCourseLearningCase.Memo].ToString().Trim(); //备注
objvCourseLearningCaseEN.IsHaveVideo = objRow[convCourseLearningCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
objvCourseLearningCaseEN.BrowseCount4Case = objRow[convCourseLearningCase.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningCaseEN.OwnerName = objRow[convCourseLearningCase.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCase.OwnerName].ToString().Trim(); //拥有者姓名
objvCourseLearningCaseEN.OwnerNameWithId = objRow[convCourseLearningCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvCourseLearningCaseDA: GetObjByDataRow)", objException.Message));
}
objvCourseLearningCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCourseLearningCaseEN;
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
objSQL = clsvCourseLearningCaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCourseLearningCaseEN._CurrTabName, convCourseLearningCase.IdCourseLearningCase, 8, "");
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
objSQL = clsvCourseLearningCaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCourseLearningCaseEN._CurrTabName, convCourseLearningCase.IdCourseLearningCase, 8, strPrefix);
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
 objSQL = clsvCourseLearningCaseDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdCourseLearningCase from vCourseLearningCase where " + strCondition;
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
 objSQL = clsvCourseLearningCaseDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdCourseLearningCase from vCourseLearningCase where " + strCondition;
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
 /// <param name = "strIdCourseLearningCase">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strIdCourseLearningCase)
{
CheckPrimaryKey(strIdCourseLearningCase);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCourseLearningCase", "IdCourseLearningCase = " + "'"+ strIdCourseLearningCase+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvCourseLearningCaseDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCourseLearningCase", strCondition))
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
objSQL = clsvCourseLearningCaseDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vCourseLearningCase");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvCourseLearningCaseENS">源对象</param>
 /// <param name = "objvCourseLearningCaseENT">目标对象</param>
public void CopyTo(clsvCourseLearningCaseEN objvCourseLearningCaseENS, clsvCourseLearningCaseEN objvCourseLearningCaseENT)
{
objvCourseLearningCaseENT.IdCourseLearningCase = objvCourseLearningCaseENS.IdCourseLearningCase; //课程学习案例流水号
objvCourseLearningCaseENT.CourseLearningCaseID = objvCourseLearningCaseENS.CourseLearningCaseID; //课程学习案例ID
objvCourseLearningCaseENT.CourseLearningCaseName = objvCourseLearningCaseENS.CourseLearningCaseName; //课程学习案例名称
objvCourseLearningCaseENT.CourseLearningCaseText = objvCourseLearningCaseENS.CourseLearningCaseText; //案例文本内容
objvCourseLearningCaseENT.CourseLearningCaseTheme = objvCourseLearningCaseENS.CourseLearningCaseTheme; //课程学习案例主题词
objvCourseLearningCaseENT.CourseLearningCaseDate = objvCourseLearningCaseENS.CourseLearningCaseDate; //课程学习日期
objvCourseLearningCaseENT.CourseLearningCaseTime = objvCourseLearningCaseENS.CourseLearningCaseTime; //课程学习时间
objvCourseLearningCaseENT.CourseLearningCaseDateIn = objvCourseLearningCaseENS.CourseLearningCaseDateIn; //案例入库日期
objvCourseLearningCaseENT.CourseLearningCaseTimeIn = objvCourseLearningCaseENS.CourseLearningCaseTimeIn; //案例入库时间
objvCourseLearningCaseENT.IdCaseType = objvCourseLearningCaseENS.IdCaseType; //案例类型流水号
objvCourseLearningCaseENT.CaseTypeName = objvCourseLearningCaseENS.CaseTypeName; //案例类型名称
objvCourseLearningCaseENT.IdCourseLearningCaseType = objvCourseLearningCaseENS.IdCourseLearningCaseType; //课程学习案例类型流水号
objvCourseLearningCaseENT.CourseLearningCaseTypeName = objvCourseLearningCaseENS.CourseLearningCaseTypeName; //课程学习案例类型名称
objvCourseLearningCaseENT.OwnerId = objvCourseLearningCaseENS.OwnerId; //拥有者Id
objvCourseLearningCaseENT.IdStudyLevel = objvCourseLearningCaseENS.IdStudyLevel; //id_StudyLevel
objvCourseLearningCaseENT.StudyLevelName = objvCourseLearningCaseENS.StudyLevelName; //学段名称
objvCourseLearningCaseENT.IdTeachingPlan = objvCourseLearningCaseENS.IdTeachingPlan; //教案流水号
objvCourseLearningCaseENT.IdDiscipline = objvCourseLearningCaseENS.IdDiscipline; //学科流水号
objvCourseLearningCaseENT.DisciplineID = objvCourseLearningCaseENS.DisciplineID; //学科ID
objvCourseLearningCaseENT.DisciplineName = objvCourseLearningCaseENS.DisciplineName; //学科名称
objvCourseLearningCaseENT.IdSenateGaugeVersion = objvCourseLearningCaseENS.IdSenateGaugeVersion; //评价量表版本流水号
objvCourseLearningCaseENT.senateGaugeVersionID = objvCourseLearningCaseENS.senateGaugeVersionID; //评价量表版本ID
objvCourseLearningCaseENT.senateGaugeVersionName = objvCourseLearningCaseENS.senateGaugeVersionName; //评价量表版本名称
objvCourseLearningCaseENT.senateGaugeVersionTtlScore = objvCourseLearningCaseENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvCourseLearningCaseENT.IsUse = objvCourseLearningCaseENS.IsUse; //是否使用
objvCourseLearningCaseENT.VersionNo = objvCourseLearningCaseENS.VersionNo; //版本号
objvCourseLearningCaseENT.IdTeachSkill = objvCourseLearningCaseENS.IdTeachSkill; //教学技能流水号
objvCourseLearningCaseENT.TeachSkillID = objvCourseLearningCaseENS.TeachSkillID; //教学技能ID
objvCourseLearningCaseENT.SkillTypeName = objvCourseLearningCaseENS.SkillTypeName; //技能类型名称
objvCourseLearningCaseENT.TeachSkillName = objvCourseLearningCaseENS.TeachSkillName; //教学技能名称
objvCourseLearningCaseENT.TeachSkillTheory = objvCourseLearningCaseENS.TeachSkillTheory; //教学技能理论阐述
objvCourseLearningCaseENT.TeachSkillOperMethod = objvCourseLearningCaseENS.TeachSkillOperMethod; //教学技能实践操作方法
objvCourseLearningCaseENT.IdSkillType = objvCourseLearningCaseENS.IdSkillType; //技能类型流水号
objvCourseLearningCaseENT.SkillTypeID = objvCourseLearningCaseENS.SkillTypeID; //技能类型ID
objvCourseLearningCaseENT.CaseLevelId = objvCourseLearningCaseENS.CaseLevelId; //课例等级Id
objvCourseLearningCaseENT.CaseLevelName = objvCourseLearningCaseENS.CaseLevelName; //案例等级名称
objvCourseLearningCaseENT.DocFile = objvCourseLearningCaseENS.DocFile; //生成的Word文件名
objvCourseLearningCaseENT.IsNeedGeneWord = objvCourseLearningCaseENS.IsNeedGeneWord; //是否需要生成Word
objvCourseLearningCaseENT.WordCreateDate = objvCourseLearningCaseENS.WordCreateDate; //Word生成日期
objvCourseLearningCaseENT.IsVisible = objvCourseLearningCaseENS.IsVisible; //是否显示
objvCourseLearningCaseENT.IsDualVideo = objvCourseLearningCaseENS.IsDualVideo; //是否双视频
objvCourseLearningCaseENT.IdXzCollege = objvCourseLearningCaseENS.IdXzCollege; //学院流水号
objvCourseLearningCaseENT.CollegeId = objvCourseLearningCaseENS.CollegeId; //学院ID
objvCourseLearningCaseENT.CollegeName = objvCourseLearningCaseENS.CollegeName; //学院名称
objvCourseLearningCaseENT.CollegeNameA = objvCourseLearningCaseENS.CollegeNameA; //学院名称简写
objvCourseLearningCaseENT.IdXzMajor = objvCourseLearningCaseENS.IdXzMajor; //专业流水号
objvCourseLearningCaseENT.MajorID = objvCourseLearningCaseENS.MajorID; //专业ID
objvCourseLearningCaseENT.MajorName = objvCourseLearningCaseENS.MajorName; //专业名称
objvCourseLearningCaseENT.CourseId = objvCourseLearningCaseENS.CourseId; //课程Id
objvCourseLearningCaseENT.CourseCode = objvCourseLearningCaseENS.CourseCode; //课程代码
objvCourseLearningCaseENT.CourseName = objvCourseLearningCaseENS.CourseName; //课程名称
objvCourseLearningCaseENT.CourseChapterId = objvCourseLearningCaseENS.CourseChapterId; //课程章节ID
objvCourseLearningCaseENT.CourseChapterName = objvCourseLearningCaseENS.CourseChapterName; //课程章节名称
objvCourseLearningCaseENT.ChapterId = objvCourseLearningCaseENS.ChapterId; //章Id
objvCourseLearningCaseENT.SectionId = objvCourseLearningCaseENS.SectionId; //节Id
objvCourseLearningCaseENT.ChapterName = objvCourseLearningCaseENS.ChapterName; //章名
objvCourseLearningCaseENT.SectionName = objvCourseLearningCaseENS.SectionName; //节名
objvCourseLearningCaseENT.ChapterNameSim = objvCourseLearningCaseENS.ChapterNameSim; //章名简称
objvCourseLearningCaseENT.SectionNameSim = objvCourseLearningCaseENS.SectionNameSim; //节名简称
objvCourseLearningCaseENT.ParentNodeId = objvCourseLearningCaseENS.ParentNodeId; //父节点编号
objvCourseLearningCaseENT.CourseChapterReferred = objvCourseLearningCaseENS.CourseChapterReferred; //节简称
objvCourseLearningCaseENT.ParentNodeName = objvCourseLearningCaseENS.ParentNodeName; //父节点名称
objvCourseLearningCaseENT.ParentNodeReferred = objvCourseLearningCaseENS.ParentNodeReferred; //章简称
objvCourseLearningCaseENT.ViewCount = objvCourseLearningCaseENS.ViewCount; //浏览量
objvCourseLearningCaseENT.IsShow = objvCourseLearningCaseENS.IsShow; //是否启用
objvCourseLearningCaseENT.DownloadNumber = objvCourseLearningCaseENS.DownloadNumber; //下载数目
objvCourseLearningCaseENT.FileIntegration = objvCourseLearningCaseENS.FileIntegration; //文件积分
objvCourseLearningCaseENT.LikeCount = objvCourseLearningCaseENS.LikeCount; //资源喜欢数量
objvCourseLearningCaseENT.CollectionCount = objvCourseLearningCaseENS.CollectionCount; //收藏数量
objvCourseLearningCaseENT.RecommendedDegreeId = objvCourseLearningCaseENS.RecommendedDegreeId; //推荐度Id
objvCourseLearningCaseENT.RecommendedDegreeName = objvCourseLearningCaseENS.RecommendedDegreeName; //推荐度名称
objvCourseLearningCaseENT.ftpFileType = objvCourseLearningCaseENS.ftpFileType; //ftp文件类型
objvCourseLearningCaseENT.VideoUrl = objvCourseLearningCaseENS.VideoUrl; //视频Url
objvCourseLearningCaseENT.VideoPath = objvCourseLearningCaseENS.VideoPath; //视频目录
objvCourseLearningCaseENT.ImageUrl = objvCourseLearningCaseENS.ImageUrl; //ImageUrl
objvCourseLearningCaseENT.ResErrMsg = objvCourseLearningCaseENS.ResErrMsg; //资源错误信息
objvCourseLearningCaseENT.OrderNum = objvCourseLearningCaseENS.OrderNum; //序号
objvCourseLearningCaseENT.UpdDate = objvCourseLearningCaseENS.UpdDate; //修改日期
objvCourseLearningCaseENT.UpdUserId = objvCourseLearningCaseENS.UpdUserId; //修改用户Id
objvCourseLearningCaseENT.Memo = objvCourseLearningCaseENS.Memo; //备注
objvCourseLearningCaseENT.IsHaveVideo = objvCourseLearningCaseENS.IsHaveVideo; //IsHaveVideo
objvCourseLearningCaseENT.BrowseCount4Case = objvCourseLearningCaseENS.BrowseCount4Case; //课例浏览次数
objvCourseLearningCaseENT.OwnerName = objvCourseLearningCaseENS.OwnerName; //拥有者姓名
objvCourseLearningCaseENT.OwnerNameWithId = objvCourseLearningCaseENS.OwnerNameWithId; //拥有者名称附Id
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvCourseLearningCaseEN objvCourseLearningCaseEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvCourseLearningCaseEN.IdCourseLearningCase, 8, convCourseLearningCase.IdCourseLearningCase);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseEN.CourseLearningCaseID, 8, convCourseLearningCase.CourseLearningCaseID);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseEN.CourseLearningCaseName, 100, convCourseLearningCase.CourseLearningCaseName);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseEN.CourseLearningCaseText, 8000, convCourseLearningCase.CourseLearningCaseText);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseEN.CourseLearningCaseTheme, 200, convCourseLearningCase.CourseLearningCaseTheme);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseEN.CourseLearningCaseDate, 8, convCourseLearningCase.CourseLearningCaseDate);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseEN.CourseLearningCaseTime, 6, convCourseLearningCase.CourseLearningCaseTime);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseEN.CourseLearningCaseDateIn, 8, convCourseLearningCase.CourseLearningCaseDateIn);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseEN.CourseLearningCaseTimeIn, 6, convCourseLearningCase.CourseLearningCaseTimeIn);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseEN.IdCaseType, 4, convCourseLearningCase.IdCaseType);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseEN.CaseTypeName, 50, convCourseLearningCase.CaseTypeName);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseEN.IdCourseLearningCaseType, 4, convCourseLearningCase.IdCourseLearningCaseType);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseEN.CourseLearningCaseTypeName, 30, convCourseLearningCase.CourseLearningCaseTypeName);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseEN.OwnerId, 20, convCourseLearningCase.OwnerId);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseEN.IdStudyLevel, 4, convCourseLearningCase.IdStudyLevel);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseEN.StudyLevelName, 50, convCourseLearningCase.StudyLevelName);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseEN.IdTeachingPlan, 8, convCourseLearningCase.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseEN.IdDiscipline, 4, convCourseLearningCase.IdDiscipline);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseEN.DisciplineID, 4, convCourseLearningCase.DisciplineID);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseEN.DisciplineName, 50, convCourseLearningCase.DisciplineName);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseEN.IdSenateGaugeVersion, 4, convCourseLearningCase.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseEN.senateGaugeVersionID, 4, convCourseLearningCase.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseEN.senateGaugeVersionName, 200, convCourseLearningCase.senateGaugeVersionName);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseEN.IdTeachSkill, 8, convCourseLearningCase.IdTeachSkill);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseEN.TeachSkillID, 8, convCourseLearningCase.TeachSkillID);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseEN.SkillTypeName, 50, convCourseLearningCase.SkillTypeName);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseEN.TeachSkillName, 50, convCourseLearningCase.TeachSkillName);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseEN.TeachSkillTheory, 8000, convCourseLearningCase.TeachSkillTheory);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseEN.TeachSkillOperMethod, 2000, convCourseLearningCase.TeachSkillOperMethod);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseEN.IdSkillType, 4, convCourseLearningCase.IdSkillType);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseEN.SkillTypeID, 4, convCourseLearningCase.SkillTypeID);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseEN.CaseLevelId, 2, convCourseLearningCase.CaseLevelId);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseEN.CaseLevelName, 30, convCourseLearningCase.CaseLevelName);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseEN.DocFile, 200, convCourseLearningCase.DocFile);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseEN.WordCreateDate, 14, convCourseLearningCase.WordCreateDate);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseEN.IdXzCollege, 4, convCourseLearningCase.IdXzCollege);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseEN.CollegeId, 4, convCourseLearningCase.CollegeId);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseEN.CollegeName, 100, convCourseLearningCase.CollegeName);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseEN.CollegeNameA, 12, convCourseLearningCase.CollegeNameA);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseEN.IdXzMajor, 8, convCourseLearningCase.IdXzMajor);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseEN.MajorID, 4, convCourseLearningCase.MajorID);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseEN.MajorName, 100, convCourseLearningCase.MajorName);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseEN.CourseId, 8, convCourseLearningCase.CourseId);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseEN.CourseCode, 20, convCourseLearningCase.CourseCode);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseEN.CourseName, 100, convCourseLearningCase.CourseName);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseEN.CourseChapterId, 8, convCourseLearningCase.CourseChapterId);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseEN.CourseChapterName, 100, convCourseLearningCase.CourseChapterName);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseEN.ChapterId, 8, convCourseLearningCase.ChapterId);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseEN.SectionId, 8, convCourseLearningCase.SectionId);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseEN.ChapterName, 100, convCourseLearningCase.ChapterName);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseEN.SectionName, 100, convCourseLearningCase.SectionName);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseEN.ChapterNameSim, 10, convCourseLearningCase.ChapterNameSim);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseEN.SectionNameSim, 10, convCourseLearningCase.SectionNameSim);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseEN.ParentNodeId, 8, convCourseLearningCase.ParentNodeId);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseEN.CourseChapterReferred, 10, convCourseLearningCase.CourseChapterReferred);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseEN.ParentNodeName, 100, convCourseLearningCase.ParentNodeName);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseEN.ParentNodeReferred, 10, convCourseLearningCase.ParentNodeReferred);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseEN.RecommendedDegreeId, 2, convCourseLearningCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseEN.RecommendedDegreeName, 30, convCourseLearningCase.RecommendedDegreeName);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseEN.ftpFileType, 30, convCourseLearningCase.ftpFileType);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseEN.VideoUrl, 1000, convCourseLearningCase.VideoUrl);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseEN.VideoPath, 1000, convCourseLearningCase.VideoPath);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseEN.ImageUrl, 100, convCourseLearningCase.ImageUrl);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseEN.ResErrMsg, 30, convCourseLearningCase.ResErrMsg);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseEN.UpdDate, 20, convCourseLearningCase.UpdDate);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseEN.UpdUserId, 20, convCourseLearningCase.UpdUserId);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseEN.Memo, 1000, convCourseLearningCase.Memo);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseEN.IsHaveVideo, 6, convCourseLearningCase.IsHaveVideo);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseEN.OwnerName, 30, convCourseLearningCase.OwnerName);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseEN.OwnerNameWithId, 51, convCourseLearningCase.OwnerNameWithId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseEN.IdCourseLearningCase, convCourseLearningCase.IdCourseLearningCase);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseEN.CourseLearningCaseID, convCourseLearningCase.CourseLearningCaseID);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseEN.CourseLearningCaseName, convCourseLearningCase.CourseLearningCaseName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseEN.CourseLearningCaseText, convCourseLearningCase.CourseLearningCaseText);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseEN.CourseLearningCaseTheme, convCourseLearningCase.CourseLearningCaseTheme);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseEN.CourseLearningCaseDate, convCourseLearningCase.CourseLearningCaseDate);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseEN.CourseLearningCaseTime, convCourseLearningCase.CourseLearningCaseTime);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseEN.CourseLearningCaseDateIn, convCourseLearningCase.CourseLearningCaseDateIn);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseEN.CourseLearningCaseTimeIn, convCourseLearningCase.CourseLearningCaseTimeIn);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseEN.IdCaseType, convCourseLearningCase.IdCaseType);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseEN.CaseTypeName, convCourseLearningCase.CaseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseEN.IdCourseLearningCaseType, convCourseLearningCase.IdCourseLearningCaseType);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseEN.CourseLearningCaseTypeName, convCourseLearningCase.CourseLearningCaseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseEN.OwnerId, convCourseLearningCase.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseEN.IdStudyLevel, convCourseLearningCase.IdStudyLevel);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseEN.StudyLevelName, convCourseLearningCase.StudyLevelName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseEN.IdTeachingPlan, convCourseLearningCase.IdTeachingPlan);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseEN.IdDiscipline, convCourseLearningCase.IdDiscipline);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseEN.DisciplineID, convCourseLearningCase.DisciplineID);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseEN.DisciplineName, convCourseLearningCase.DisciplineName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseEN.IdSenateGaugeVersion, convCourseLearningCase.IdSenateGaugeVersion);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseEN.senateGaugeVersionID, convCourseLearningCase.senateGaugeVersionID);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseEN.senateGaugeVersionName, convCourseLearningCase.senateGaugeVersionName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseEN.IdTeachSkill, convCourseLearningCase.IdTeachSkill);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseEN.TeachSkillID, convCourseLearningCase.TeachSkillID);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseEN.SkillTypeName, convCourseLearningCase.SkillTypeName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseEN.TeachSkillName, convCourseLearningCase.TeachSkillName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseEN.TeachSkillTheory, convCourseLearningCase.TeachSkillTheory);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseEN.TeachSkillOperMethod, convCourseLearningCase.TeachSkillOperMethod);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseEN.IdSkillType, convCourseLearningCase.IdSkillType);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseEN.SkillTypeID, convCourseLearningCase.SkillTypeID);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseEN.CaseLevelId, convCourseLearningCase.CaseLevelId);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseEN.CaseLevelName, convCourseLearningCase.CaseLevelName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseEN.DocFile, convCourseLearningCase.DocFile);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseEN.WordCreateDate, convCourseLearningCase.WordCreateDate);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseEN.IdXzCollege, convCourseLearningCase.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseEN.CollegeId, convCourseLearningCase.CollegeId);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseEN.CollegeName, convCourseLearningCase.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseEN.CollegeNameA, convCourseLearningCase.CollegeNameA);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseEN.IdXzMajor, convCourseLearningCase.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseEN.MajorID, convCourseLearningCase.MajorID);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseEN.MajorName, convCourseLearningCase.MajorName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseEN.CourseId, convCourseLearningCase.CourseId);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseEN.CourseCode, convCourseLearningCase.CourseCode);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseEN.CourseName, convCourseLearningCase.CourseName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseEN.CourseChapterId, convCourseLearningCase.CourseChapterId);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseEN.CourseChapterName, convCourseLearningCase.CourseChapterName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseEN.ChapterId, convCourseLearningCase.ChapterId);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseEN.SectionId, convCourseLearningCase.SectionId);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseEN.ChapterName, convCourseLearningCase.ChapterName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseEN.SectionName, convCourseLearningCase.SectionName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseEN.ChapterNameSim, convCourseLearningCase.ChapterNameSim);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseEN.SectionNameSim, convCourseLearningCase.SectionNameSim);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseEN.ParentNodeId, convCourseLearningCase.ParentNodeId);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseEN.CourseChapterReferred, convCourseLearningCase.CourseChapterReferred);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseEN.ParentNodeName, convCourseLearningCase.ParentNodeName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseEN.ParentNodeReferred, convCourseLearningCase.ParentNodeReferred);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseEN.RecommendedDegreeId, convCourseLearningCase.RecommendedDegreeId);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseEN.RecommendedDegreeName, convCourseLearningCase.RecommendedDegreeName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseEN.ftpFileType, convCourseLearningCase.ftpFileType);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseEN.VideoUrl, convCourseLearningCase.VideoUrl);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseEN.VideoPath, convCourseLearningCase.VideoPath);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseEN.ImageUrl, convCourseLearningCase.ImageUrl);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseEN.ResErrMsg, convCourseLearningCase.ResErrMsg);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseEN.UpdDate, convCourseLearningCase.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseEN.UpdUserId, convCourseLearningCase.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseEN.Memo, convCourseLearningCase.Memo);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseEN.IsHaveVideo, convCourseLearningCase.IsHaveVideo);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseEN.OwnerName, convCourseLearningCase.OwnerName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseEN.OwnerNameWithId, convCourseLearningCase.OwnerNameWithId);
//检查外键字段长度
 objvCourseLearningCaseEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetIdCourseLearningCase()
{
//获取某学院所有专业信息
string strSQL = "select IdCourseLearningCase, CourseLearningCaseName from vCourseLearningCase ";
 clsSpecSQLforSql mySql = clsvCourseLearningCaseDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

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
 objSQL = clsvCourseLearningCaseDA.GetSpecSQLObj();
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
 objSQL = clsvCourseLearningCaseDA.GetSpecSQLObj();
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
 objSQL = clsvCourseLearningCaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCourseLearningCaseEN._CurrTabName);
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
 objSQL = clsvCourseLearningCaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCourseLearningCaseEN._CurrTabName, strCondition);
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
 objSQL = clsvCourseLearningCaseDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}