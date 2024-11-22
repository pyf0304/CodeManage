
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCourseLearningCase_BaseDA
 表名:vCourseLearningCase_Base(01120268)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:03:43
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
 /// v课程学习案例_Base(vCourseLearningCase_Base)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvCourseLearningCase_BaseDA : clsCommBase4DA
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
 return clsvCourseLearningCase_BaseEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvCourseLearningCase_BaseEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCourseLearningCase_BaseEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvCourseLearningCase_BaseEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvCourseLearningCase_BaseEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:vCourseLearningCase_Base中,检查关键字,长度不正确!(clsvCourseLearningCase_BaseDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdCourseLearningCase)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vCourseLearningCase_Base中,关键字不能为空 或 null!(clsvCourseLearningCase_BaseDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdCourseLearningCase);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvCourseLearningCase_BaseDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvCourseLearningCase_BaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCase_BaseDA.GetSpecSQLObj();
strSQL = "Select * from vCourseLearningCase_Base where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vCourseLearningCase_Base(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvCourseLearningCase_BaseDA: GetDataTable_vCourseLearningCase_Base)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCase_BaseDA.GetSpecSQLObj();
strSQL = "Select * from vCourseLearningCase_Base where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvCourseLearningCase_BaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCase_BaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvCourseLearningCase_BaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCase_BaseDA.GetSpecSQLObj();
strSQL = "Select * from vCourseLearningCase_Base where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvCourseLearningCase_BaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCase_BaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvCourseLearningCase_BaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCase_BaseDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCourseLearningCase_Base where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCourseLearningCase_Base where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvCourseLearningCase_BaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCase_BaseDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vCourseLearningCase_Base where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvCourseLearningCase_BaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCase_BaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vCourseLearningCase_Base.* from vCourseLearningCase_Base Left Join {1} on {2} where {3} and vCourseLearningCase_Base.IdCourseLearningCase not in (Select top {5} vCourseLearningCase_Base.IdCourseLearningCase from vCourseLearningCase_Base Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCourseLearningCase_Base where {1} and IdCourseLearningCase not in (Select top {2} IdCourseLearningCase from vCourseLearningCase_Base where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCourseLearningCase_Base where {1} and IdCourseLearningCase not in (Select top {3} IdCourseLearningCase from vCourseLearningCase_Base where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvCourseLearningCase_BaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCase_BaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vCourseLearningCase_Base.* from vCourseLearningCase_Base Left Join {1} on {2} where {3} and vCourseLearningCase_Base.IdCourseLearningCase not in (Select top {5} vCourseLearningCase_Base.IdCourseLearningCase from vCourseLearningCase_Base Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCourseLearningCase_Base where {1} and IdCourseLearningCase not in (Select top {2} IdCourseLearningCase from vCourseLearningCase_Base where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCourseLearningCase_Base where {1} and IdCourseLearningCase not in (Select top {3} IdCourseLearningCase from vCourseLearningCase_Base where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvCourseLearningCase_BaseEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvCourseLearningCase_BaseDA:GetObjLst)", objException.Message));
}
List<clsvCourseLearningCase_BaseEN> arrObjLst = new List<clsvCourseLearningCase_BaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCase_BaseDA.GetSpecSQLObj();
strSQL = "Select * from vCourseLearningCase_Base where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN = new clsvCourseLearningCase_BaseEN();
try
{
objvCourseLearningCase_BaseEN.IdCourseLearningCase = objRow[convCourseLearningCase_Base.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCase_BaseEN.CourseLearningCaseID = objRow[convCourseLearningCase_Base.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCase_BaseEN.CourseLearningCaseName = objRow[convCourseLearningCase_Base.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCase_BaseEN.CourseLearningCaseText = objRow[convCourseLearningCase_Base.CourseLearningCaseText] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseText].ToString().Trim(); //案例文本内容
objvCourseLearningCase_BaseEN.CourseLearningCaseTheme = objRow[convCourseLearningCase_Base.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningCase_BaseEN.CourseLearningCaseDate = objRow[convCourseLearningCase_Base.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningCase_BaseEN.CourseLearningCaseTime = objRow[convCourseLearningCase_Base.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningCase_BaseEN.CourseLearningCaseDateIn = objRow[convCourseLearningCase_Base.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningCase_BaseEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCase_Base.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningCase_BaseEN.IdCaseType = objRow[convCourseLearningCase_Base.IdCaseType] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdCaseType].ToString().Trim(); //案例类型流水号
objvCourseLearningCase_BaseEN.CaseTypeName = objRow[convCourseLearningCase_Base.CaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CaseTypeName].ToString().Trim(); //案例类型名称
objvCourseLearningCase_BaseEN.IdCourseLearningCaseType = objRow[convCourseLearningCase_Base.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号
objvCourseLearningCase_BaseEN.CourseLearningCaseTypeName = objRow[convCourseLearningCase_Base.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningCase_BaseEN.OwnerId = objRow[convCourseLearningCase_Base.OwnerId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.OwnerId].ToString().Trim(); //拥有者Id
objvCourseLearningCase_BaseEN.IdStudyLevel = objRow[convCourseLearningCase_Base.IdStudyLevel] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCourseLearningCase_BaseEN.StudyLevelName = objRow[convCourseLearningCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.StudyLevelName].ToString().Trim(); //学段名称
objvCourseLearningCase_BaseEN.IdTeachingPlan = objRow[convCourseLearningCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCourseLearningCase_BaseEN.IdDiscipline = objRow[convCourseLearningCase_Base.IdDiscipline].ToString().Trim(); //学科流水号
objvCourseLearningCase_BaseEN.DisciplineID = objRow[convCourseLearningCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.DisciplineID].ToString().Trim(); //学科ID
objvCourseLearningCase_BaseEN.DisciplineName = objRow[convCourseLearningCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.DisciplineName].ToString().Trim(); //学科名称
objvCourseLearningCase_BaseEN.IdSenateGaugeVersion = objRow[convCourseLearningCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCourseLearningCase_BaseEN.senateGaugeVersionID = objRow[convCourseLearningCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCourseLearningCase_BaseEN.senateGaugeVersionName = objRow[convCourseLearningCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCourseLearningCase_BaseEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convCourseLearningCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCourseLearningCase_BaseEN.VersionNo = objRow[convCourseLearningCase_Base.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase_Base.VersionNo].ToString().Trim()); //版本号
objvCourseLearningCase_BaseEN.IdTeachSkill = objRow[convCourseLearningCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCourseLearningCase_BaseEN.TeachSkillID = objRow[convCourseLearningCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID
objvCourseLearningCase_BaseEN.SkillTypeName = objRow[convCourseLearningCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称
objvCourseLearningCase_BaseEN.TeachSkillName = objRow[convCourseLearningCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称
objvCourseLearningCase_BaseEN.TeachSkillTheory = objRow[convCourseLearningCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCourseLearningCase_BaseEN.TeachSkillOperMethod = objRow[convCourseLearningCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCourseLearningCase_BaseEN.IdSkillType = objRow[convCourseLearningCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号
objvCourseLearningCase_BaseEN.SkillTypeID = objRow[convCourseLearningCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID
objvCourseLearningCase_BaseEN.CaseLevelId = objRow[convCourseLearningCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvCourseLearningCase_BaseEN.CaseLevelName = objRow[convCourseLearningCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvCourseLearningCase_BaseEN.DocFile = objRow[convCourseLearningCase_Base.DocFile] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.DocFile].ToString().Trim(); //生成的Word文件名
objvCourseLearningCase_BaseEN.IsNeedGeneWord = TransNullToBool(objRow[convCourseLearningCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvCourseLearningCase_BaseEN.WordCreateDate = objRow[convCourseLearningCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期
objvCourseLearningCase_BaseEN.IsVisible = TransNullToBool(objRow[convCourseLearningCase_Base.IsVisible].ToString().Trim()); //是否显示
objvCourseLearningCase_BaseEN.IsDualVideo = TransNullToBool(objRow[convCourseLearningCase_Base.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCase_BaseEN.IdXzCollege = objRow[convCourseLearningCase_Base.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCase_BaseEN.CollegeId = objRow[convCourseLearningCase_Base.CollegeId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CollegeId].ToString().Trim(); //学院ID
objvCourseLearningCase_BaseEN.CollegeName = objRow[convCourseLearningCase_Base.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCase_BaseEN.CollegeNameA = objRow[convCourseLearningCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningCase_BaseEN.IdXzMajor = objRow[convCourseLearningCase_Base.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningCase_BaseEN.MajorID = objRow[convCourseLearningCase_Base.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCase_BaseEN.MajorName = objRow[convCourseLearningCase_Base.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCase_BaseEN.CourseId = objRow[convCourseLearningCase_Base.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCase_BaseEN.CourseCode = objRow[convCourseLearningCase_Base.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCase_BaseEN.CourseName = objRow[convCourseLearningCase_Base.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCase_BaseEN.CourseChapterId = objRow[convCourseLearningCase_Base.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCase_BaseEN.CourseChapterName = objRow[convCourseLearningCase_Base.CourseChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseChapterName].ToString().Trim(); //课程章节名称
objvCourseLearningCase_BaseEN.ChapterId = objRow[convCourseLearningCase_Base.ChapterId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ChapterId].ToString().Trim(); //章Id
objvCourseLearningCase_BaseEN.ParentNodeId = objRow[convCourseLearningCase_Base.ParentNodeId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ParentNodeId].ToString().Trim(); //父节点编号
objvCourseLearningCase_BaseEN.CourseChapterReferred = objRow[convCourseLearningCase_Base.CourseChapterReferred] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseChapterReferred].ToString().Trim(); //节简称
objvCourseLearningCase_BaseEN.ChapterName = objRow[convCourseLearningCase_Base.ChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ChapterName].ToString().Trim(); //章名
objvCourseLearningCase_BaseEN.ChapterNameSim = objRow[convCourseLearningCase_Base.ChapterNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ChapterNameSim].ToString().Trim(); //章名简称
objvCourseLearningCase_BaseEN.SectionName = objRow[convCourseLearningCase_Base.SectionName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SectionName].ToString().Trim(); //节名
objvCourseLearningCase_BaseEN.SectionNameSim = objRow[convCourseLearningCase_Base.SectionNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SectionNameSim].ToString().Trim(); //节名简称
objvCourseLearningCase_BaseEN.SectionId = objRow[convCourseLearningCase_Base.SectionId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SectionId].ToString().Trim(); //节Id
objvCourseLearningCase_BaseEN.ParentNodeReferred = objRow[convCourseLearningCase_Base.ParentNodeReferred] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ParentNodeReferred].ToString().Trim(); //章简称
objvCourseLearningCase_BaseEN.ParentNodeName = objRow[convCourseLearningCase_Base.ParentNodeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ParentNodeName].ToString().Trim(); //父节点名称
objvCourseLearningCase_BaseEN.ViewCount = objRow[convCourseLearningCase_Base.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase_Base.ViewCount].ToString().Trim()); //浏览量
objvCourseLearningCase_BaseEN.IsShow = TransNullToBool(objRow[convCourseLearningCase_Base.IsShow].ToString().Trim()); //是否启用
objvCourseLearningCase_BaseEN.DownloadNumber = objRow[convCourseLearningCase_Base.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase_Base.DownloadNumber].ToString().Trim()); //下载数目
objvCourseLearningCase_BaseEN.FileIntegration = objRow[convCourseLearningCase_Base.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase_Base.FileIntegration].ToString().Trim()); //文件积分
objvCourseLearningCase_BaseEN.LikeCount = objRow[convCourseLearningCase_Base.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCourseLearningCase_Base.LikeCount].ToString().Trim()); //资源喜欢数量
objvCourseLearningCase_BaseEN.CollectionCount = objRow[convCourseLearningCase_Base.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCourseLearningCase_Base.CollectionCount].ToString().Trim()); //收藏数量
objvCourseLearningCase_BaseEN.RecommendedDegreeId = objRow[convCourseLearningCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCourseLearningCase_BaseEN.RecommendedDegreeName = objRow[convCourseLearningCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCourseLearningCase_BaseEN.ftpFileType = objRow[convCourseLearningCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvCourseLearningCase_BaseEN.VideoUrl = objRow[convCourseLearningCase_Base.VideoUrl] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.VideoUrl].ToString().Trim(); //视频Url
objvCourseLearningCase_BaseEN.VideoPath = objRow[convCourseLearningCase_Base.VideoPath] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.VideoPath].ToString().Trim(); //视频目录
objvCourseLearningCase_BaseEN.ResErrMsg = objRow[convCourseLearningCase_Base.ResErrMsg] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ResErrMsg].ToString().Trim(); //资源错误信息
objvCourseLearningCase_BaseEN.Memo = objRow[convCourseLearningCase_Base.Memo] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.Memo].ToString().Trim(); //备注
objvCourseLearningCase_BaseEN.BrowseCount4Case = objRow[convCourseLearningCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningCase_BaseEN.OwnerName = objRow[convCourseLearningCase_Base.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvCourseLearningCase_BaseEN.OwnerNameWithId = objRow[convCourseLearningCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCourseLearningCase_BaseEN.OrderNum = objRow[convCourseLearningCase_Base.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase_Base.OrderNum].ToString().Trim()); //序号
objvCourseLearningCase_BaseEN.IsUse = TransNullToBool(objRow[convCourseLearningCase_Base.IsUse].ToString().Trim()); //是否使用
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCourseLearningCase_BaseDA: GetObjLst)", objException.Message));
}
objvCourseLearningCase_BaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCourseLearningCase_BaseEN);
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
public List<clsvCourseLearningCase_BaseEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvCourseLearningCase_BaseDA:GetObjLstByTabName)", objException.Message));
}
List<clsvCourseLearningCase_BaseEN> arrObjLst = new List<clsvCourseLearningCase_BaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCase_BaseDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN = new clsvCourseLearningCase_BaseEN();
try
{
objvCourseLearningCase_BaseEN.IdCourseLearningCase = objRow[convCourseLearningCase_Base.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCase_BaseEN.CourseLearningCaseID = objRow[convCourseLearningCase_Base.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCase_BaseEN.CourseLearningCaseName = objRow[convCourseLearningCase_Base.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCase_BaseEN.CourseLearningCaseText = objRow[convCourseLearningCase_Base.CourseLearningCaseText] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseText].ToString().Trim(); //案例文本内容
objvCourseLearningCase_BaseEN.CourseLearningCaseTheme = objRow[convCourseLearningCase_Base.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningCase_BaseEN.CourseLearningCaseDate = objRow[convCourseLearningCase_Base.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningCase_BaseEN.CourseLearningCaseTime = objRow[convCourseLearningCase_Base.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningCase_BaseEN.CourseLearningCaseDateIn = objRow[convCourseLearningCase_Base.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningCase_BaseEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCase_Base.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningCase_BaseEN.IdCaseType = objRow[convCourseLearningCase_Base.IdCaseType] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdCaseType].ToString().Trim(); //案例类型流水号
objvCourseLearningCase_BaseEN.CaseTypeName = objRow[convCourseLearningCase_Base.CaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CaseTypeName].ToString().Trim(); //案例类型名称
objvCourseLearningCase_BaseEN.IdCourseLearningCaseType = objRow[convCourseLearningCase_Base.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号
objvCourseLearningCase_BaseEN.CourseLearningCaseTypeName = objRow[convCourseLearningCase_Base.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningCase_BaseEN.OwnerId = objRow[convCourseLearningCase_Base.OwnerId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.OwnerId].ToString().Trim(); //拥有者Id
objvCourseLearningCase_BaseEN.IdStudyLevel = objRow[convCourseLearningCase_Base.IdStudyLevel] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCourseLearningCase_BaseEN.StudyLevelName = objRow[convCourseLearningCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.StudyLevelName].ToString().Trim(); //学段名称
objvCourseLearningCase_BaseEN.IdTeachingPlan = objRow[convCourseLearningCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCourseLearningCase_BaseEN.IdDiscipline = objRow[convCourseLearningCase_Base.IdDiscipline].ToString().Trim(); //学科流水号
objvCourseLearningCase_BaseEN.DisciplineID = objRow[convCourseLearningCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.DisciplineID].ToString().Trim(); //学科ID
objvCourseLearningCase_BaseEN.DisciplineName = objRow[convCourseLearningCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.DisciplineName].ToString().Trim(); //学科名称
objvCourseLearningCase_BaseEN.IdSenateGaugeVersion = objRow[convCourseLearningCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCourseLearningCase_BaseEN.senateGaugeVersionID = objRow[convCourseLearningCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCourseLearningCase_BaseEN.senateGaugeVersionName = objRow[convCourseLearningCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCourseLearningCase_BaseEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convCourseLearningCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCourseLearningCase_BaseEN.VersionNo = objRow[convCourseLearningCase_Base.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase_Base.VersionNo].ToString().Trim()); //版本号
objvCourseLearningCase_BaseEN.IdTeachSkill = objRow[convCourseLearningCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCourseLearningCase_BaseEN.TeachSkillID = objRow[convCourseLearningCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID
objvCourseLearningCase_BaseEN.SkillTypeName = objRow[convCourseLearningCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称
objvCourseLearningCase_BaseEN.TeachSkillName = objRow[convCourseLearningCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称
objvCourseLearningCase_BaseEN.TeachSkillTheory = objRow[convCourseLearningCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCourseLearningCase_BaseEN.TeachSkillOperMethod = objRow[convCourseLearningCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCourseLearningCase_BaseEN.IdSkillType = objRow[convCourseLearningCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号
objvCourseLearningCase_BaseEN.SkillTypeID = objRow[convCourseLearningCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID
objvCourseLearningCase_BaseEN.CaseLevelId = objRow[convCourseLearningCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvCourseLearningCase_BaseEN.CaseLevelName = objRow[convCourseLearningCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvCourseLearningCase_BaseEN.DocFile = objRow[convCourseLearningCase_Base.DocFile] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.DocFile].ToString().Trim(); //生成的Word文件名
objvCourseLearningCase_BaseEN.IsNeedGeneWord = TransNullToBool(objRow[convCourseLearningCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvCourseLearningCase_BaseEN.WordCreateDate = objRow[convCourseLearningCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期
objvCourseLearningCase_BaseEN.IsVisible = TransNullToBool(objRow[convCourseLearningCase_Base.IsVisible].ToString().Trim()); //是否显示
objvCourseLearningCase_BaseEN.IsDualVideo = TransNullToBool(objRow[convCourseLearningCase_Base.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCase_BaseEN.IdXzCollege = objRow[convCourseLearningCase_Base.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCase_BaseEN.CollegeId = objRow[convCourseLearningCase_Base.CollegeId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CollegeId].ToString().Trim(); //学院ID
objvCourseLearningCase_BaseEN.CollegeName = objRow[convCourseLearningCase_Base.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCase_BaseEN.CollegeNameA = objRow[convCourseLearningCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningCase_BaseEN.IdXzMajor = objRow[convCourseLearningCase_Base.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningCase_BaseEN.MajorID = objRow[convCourseLearningCase_Base.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCase_BaseEN.MajorName = objRow[convCourseLearningCase_Base.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCase_BaseEN.CourseId = objRow[convCourseLearningCase_Base.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCase_BaseEN.CourseCode = objRow[convCourseLearningCase_Base.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCase_BaseEN.CourseName = objRow[convCourseLearningCase_Base.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCase_BaseEN.CourseChapterId = objRow[convCourseLearningCase_Base.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCase_BaseEN.CourseChapterName = objRow[convCourseLearningCase_Base.CourseChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseChapterName].ToString().Trim(); //课程章节名称
objvCourseLearningCase_BaseEN.ChapterId = objRow[convCourseLearningCase_Base.ChapterId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ChapterId].ToString().Trim(); //章Id
objvCourseLearningCase_BaseEN.ParentNodeId = objRow[convCourseLearningCase_Base.ParentNodeId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ParentNodeId].ToString().Trim(); //父节点编号
objvCourseLearningCase_BaseEN.CourseChapterReferred = objRow[convCourseLearningCase_Base.CourseChapterReferred] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseChapterReferred].ToString().Trim(); //节简称
objvCourseLearningCase_BaseEN.ChapterName = objRow[convCourseLearningCase_Base.ChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ChapterName].ToString().Trim(); //章名
objvCourseLearningCase_BaseEN.ChapterNameSim = objRow[convCourseLearningCase_Base.ChapterNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ChapterNameSim].ToString().Trim(); //章名简称
objvCourseLearningCase_BaseEN.SectionName = objRow[convCourseLearningCase_Base.SectionName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SectionName].ToString().Trim(); //节名
objvCourseLearningCase_BaseEN.SectionNameSim = objRow[convCourseLearningCase_Base.SectionNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SectionNameSim].ToString().Trim(); //节名简称
objvCourseLearningCase_BaseEN.SectionId = objRow[convCourseLearningCase_Base.SectionId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SectionId].ToString().Trim(); //节Id
objvCourseLearningCase_BaseEN.ParentNodeReferred = objRow[convCourseLearningCase_Base.ParentNodeReferred] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ParentNodeReferred].ToString().Trim(); //章简称
objvCourseLearningCase_BaseEN.ParentNodeName = objRow[convCourseLearningCase_Base.ParentNodeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ParentNodeName].ToString().Trim(); //父节点名称
objvCourseLearningCase_BaseEN.ViewCount = objRow[convCourseLearningCase_Base.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase_Base.ViewCount].ToString().Trim()); //浏览量
objvCourseLearningCase_BaseEN.IsShow = TransNullToBool(objRow[convCourseLearningCase_Base.IsShow].ToString().Trim()); //是否启用
objvCourseLearningCase_BaseEN.DownloadNumber = objRow[convCourseLearningCase_Base.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase_Base.DownloadNumber].ToString().Trim()); //下载数目
objvCourseLearningCase_BaseEN.FileIntegration = objRow[convCourseLearningCase_Base.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase_Base.FileIntegration].ToString().Trim()); //文件积分
objvCourseLearningCase_BaseEN.LikeCount = objRow[convCourseLearningCase_Base.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCourseLearningCase_Base.LikeCount].ToString().Trim()); //资源喜欢数量
objvCourseLearningCase_BaseEN.CollectionCount = objRow[convCourseLearningCase_Base.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCourseLearningCase_Base.CollectionCount].ToString().Trim()); //收藏数量
objvCourseLearningCase_BaseEN.RecommendedDegreeId = objRow[convCourseLearningCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCourseLearningCase_BaseEN.RecommendedDegreeName = objRow[convCourseLearningCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCourseLearningCase_BaseEN.ftpFileType = objRow[convCourseLearningCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvCourseLearningCase_BaseEN.VideoUrl = objRow[convCourseLearningCase_Base.VideoUrl] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.VideoUrl].ToString().Trim(); //视频Url
objvCourseLearningCase_BaseEN.VideoPath = objRow[convCourseLearningCase_Base.VideoPath] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.VideoPath].ToString().Trim(); //视频目录
objvCourseLearningCase_BaseEN.ResErrMsg = objRow[convCourseLearningCase_Base.ResErrMsg] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ResErrMsg].ToString().Trim(); //资源错误信息
objvCourseLearningCase_BaseEN.Memo = objRow[convCourseLearningCase_Base.Memo] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.Memo].ToString().Trim(); //备注
objvCourseLearningCase_BaseEN.BrowseCount4Case = objRow[convCourseLearningCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningCase_BaseEN.OwnerName = objRow[convCourseLearningCase_Base.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvCourseLearningCase_BaseEN.OwnerNameWithId = objRow[convCourseLearningCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCourseLearningCase_BaseEN.OrderNum = objRow[convCourseLearningCase_Base.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase_Base.OrderNum].ToString().Trim()); //序号
objvCourseLearningCase_BaseEN.IsUse = TransNullToBool(objRow[convCourseLearningCase_Base.IsUse].ToString().Trim()); //是否使用
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCourseLearningCase_BaseDA: GetObjLst)", objException.Message));
}
objvCourseLearningCase_BaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCourseLearningCase_BaseEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvCourseLearningCase_Base(ref clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCase_BaseDA.GetSpecSQLObj();
strSQL = "Select * from vCourseLearningCase_Base where IdCourseLearningCase = " + "'"+ objvCourseLearningCase_BaseEN.IdCourseLearningCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvCourseLearningCase_BaseEN.IdCourseLearningCase = objDT.Rows[0][convCourseLearningCase_Base.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCase_BaseEN.CourseLearningCaseID = objDT.Rows[0][convCourseLearningCase_Base.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCase_BaseEN.CourseLearningCaseName = objDT.Rows[0][convCourseLearningCase_Base.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCourseLearningCase_BaseEN.CourseLearningCaseText = objDT.Rows[0][convCourseLearningCase_Base.CourseLearningCaseText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objvCourseLearningCase_BaseEN.CourseLearningCaseTheme = objDT.Rows[0][convCourseLearningCase_Base.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvCourseLearningCase_BaseEN.CourseLearningCaseDate = objDT.Rows[0][convCourseLearningCase_Base.CourseLearningCaseDate].ToString().Trim(); //课程学习日期(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningCase_BaseEN.CourseLearningCaseTime = objDT.Rows[0][convCourseLearningCase_Base.CourseLearningCaseTime].ToString().Trim(); //课程学习时间(字段类型:char,字段长度:6,是否可空:True)
 objvCourseLearningCase_BaseEN.CourseLearningCaseDateIn = objDT.Rows[0][convCourseLearningCase_Base.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningCase_BaseEN.CourseLearningCaseTimeIn = objDT.Rows[0][convCourseLearningCase_Base.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvCourseLearningCase_BaseEN.IdCaseType = objDT.Rows[0][convCourseLearningCase_Base.IdCaseType].ToString().Trim(); //案例类型流水号(字段类型:char,字段长度:4,是否可空:True)
 objvCourseLearningCase_BaseEN.CaseTypeName = objDT.Rows[0][convCourseLearningCase_Base.CaseTypeName].ToString().Trim(); //案例类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCourseLearningCase_BaseEN.IdCourseLearningCaseType = objDT.Rows[0][convCourseLearningCase_Base.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCase_BaseEN.CourseLearningCaseTypeName = objDT.Rows[0][convCourseLearningCase_Base.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCourseLearningCase_BaseEN.OwnerId = objDT.Rows[0][convCourseLearningCase_Base.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvCourseLearningCase_BaseEN.IdStudyLevel = objDT.Rows[0][convCourseLearningCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvCourseLearningCase_BaseEN.StudyLevelName = objDT.Rows[0][convCourseLearningCase_Base.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCourseLearningCase_BaseEN.IdTeachingPlan = objDT.Rows[0][convCourseLearningCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCase_BaseEN.IdDiscipline = objDT.Rows[0][convCourseLearningCase_Base.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCase_BaseEN.DisciplineID = objDT.Rows[0][convCourseLearningCase_Base.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCase_BaseEN.DisciplineName = objDT.Rows[0][convCourseLearningCase_Base.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCourseLearningCase_BaseEN.IdSenateGaugeVersion = objDT.Rows[0][convCourseLearningCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCase_BaseEN.senateGaugeVersionID = objDT.Rows[0][convCourseLearningCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCase_BaseEN.senateGaugeVersionName = objDT.Rows[0][convCourseLearningCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvCourseLearningCase_BaseEN.senateGaugeVersionTtlScore = TransNullToFloat(objDT.Rows[0][convCourseLearningCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvCourseLearningCase_BaseEN.VersionNo = TransNullToInt(objDT.Rows[0][convCourseLearningCase_Base.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvCourseLearningCase_BaseEN.IdTeachSkill = objDT.Rows[0][convCourseLearningCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCase_BaseEN.TeachSkillID = objDT.Rows[0][convCourseLearningCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCase_BaseEN.SkillTypeName = objDT.Rows[0][convCourseLearningCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCourseLearningCase_BaseEN.TeachSkillName = objDT.Rows[0][convCourseLearningCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCourseLearningCase_BaseEN.TeachSkillTheory = objDT.Rows[0][convCourseLearningCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvCourseLearningCase_BaseEN.TeachSkillOperMethod = objDT.Rows[0][convCourseLearningCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法(字段类型:varchar,字段长度:2000,是否可空:True)
 objvCourseLearningCase_BaseEN.IdSkillType = objDT.Rows[0][convCourseLearningCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCase_BaseEN.SkillTypeID = objDT.Rows[0][convCourseLearningCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCase_BaseEN.CaseLevelId = objDT.Rows[0][convCourseLearningCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvCourseLearningCase_BaseEN.CaseLevelName = objDT.Rows[0][convCourseLearningCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvCourseLearningCase_BaseEN.DocFile = objDT.Rows[0][convCourseLearningCase_Base.DocFile].ToString().Trim(); //生成的Word文件名(字段类型:varchar,字段长度:200,是否可空:True)
 objvCourseLearningCase_BaseEN.IsNeedGeneWord = TransNullToBool(objDT.Rows[0][convCourseLearningCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word(字段类型:bit,字段长度:1,是否可空:True)
 objvCourseLearningCase_BaseEN.WordCreateDate = objDT.Rows[0][convCourseLearningCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objvCourseLearningCase_BaseEN.IsVisible = TransNullToBool(objDT.Rows[0][convCourseLearningCase_Base.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvCourseLearningCase_BaseEN.IsDualVideo = TransNullToBool(objDT.Rows[0][convCourseLearningCase_Base.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvCourseLearningCase_BaseEN.IdXzCollege = objDT.Rows[0][convCourseLearningCase_Base.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvCourseLearningCase_BaseEN.CollegeId = objDT.Rows[0][convCourseLearningCase_Base.CollegeId].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvCourseLearningCase_BaseEN.CollegeName = objDT.Rows[0][convCourseLearningCase_Base.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCourseLearningCase_BaseEN.CollegeNameA = objDT.Rows[0][convCourseLearningCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvCourseLearningCase_BaseEN.IdXzMajor = objDT.Rows[0][convCourseLearningCase_Base.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCase_BaseEN.MajorID = objDT.Rows[0][convCourseLearningCase_Base.MajorID].ToString().Trim(); //专业ID(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCase_BaseEN.MajorName = objDT.Rows[0][convCourseLearningCase_Base.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCourseLearningCase_BaseEN.CourseId = objDT.Rows[0][convCourseLearningCase_Base.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningCase_BaseEN.CourseCode = objDT.Rows[0][convCourseLearningCase_Base.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvCourseLearningCase_BaseEN.CourseName = objDT.Rows[0][convCourseLearningCase_Base.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvCourseLearningCase_BaseEN.CourseChapterId = objDT.Rows[0][convCourseLearningCase_Base.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCase_BaseEN.CourseChapterName = objDT.Rows[0][convCourseLearningCase_Base.CourseChapterName].ToString().Trim(); //课程章节名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCourseLearningCase_BaseEN.ChapterId = objDT.Rows[0][convCourseLearningCase_Base.ChapterId].ToString().Trim(); //章Id(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningCase_BaseEN.ParentNodeId = objDT.Rows[0][convCourseLearningCase_Base.ParentNodeId].ToString().Trim(); //父节点编号(字段类型:varchar,字段长度:8,是否可空:True)
 objvCourseLearningCase_BaseEN.CourseChapterReferred = objDT.Rows[0][convCourseLearningCase_Base.CourseChapterReferred].ToString().Trim(); //节简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvCourseLearningCase_BaseEN.ChapterName = objDT.Rows[0][convCourseLearningCase_Base.ChapterName].ToString().Trim(); //章名(字段类型:varchar,字段长度:100,是否可空:True)
 objvCourseLearningCase_BaseEN.ChapterNameSim = objDT.Rows[0][convCourseLearningCase_Base.ChapterNameSim].ToString().Trim(); //章名简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvCourseLearningCase_BaseEN.SectionName = objDT.Rows[0][convCourseLearningCase_Base.SectionName].ToString().Trim(); //节名(字段类型:varchar,字段长度:100,是否可空:True)
 objvCourseLearningCase_BaseEN.SectionNameSim = objDT.Rows[0][convCourseLearningCase_Base.SectionNameSim].ToString().Trim(); //节名简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvCourseLearningCase_BaseEN.SectionId = objDT.Rows[0][convCourseLearningCase_Base.SectionId].ToString().Trim(); //节Id(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningCase_BaseEN.ParentNodeReferred = objDT.Rows[0][convCourseLearningCase_Base.ParentNodeReferred].ToString().Trim(); //章简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvCourseLearningCase_BaseEN.ParentNodeName = objDT.Rows[0][convCourseLearningCase_Base.ParentNodeName].ToString().Trim(); //父节点名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvCourseLearningCase_BaseEN.ViewCount = TransNullToInt(objDT.Rows[0][convCourseLearningCase_Base.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvCourseLearningCase_BaseEN.IsShow = TransNullToBool(objDT.Rows[0][convCourseLearningCase_Base.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objvCourseLearningCase_BaseEN.DownloadNumber = TransNullToInt(objDT.Rows[0][convCourseLearningCase_Base.DownloadNumber].ToString().Trim()); //下载数目(字段类型:int,字段长度:4,是否可空:True)
 objvCourseLearningCase_BaseEN.FileIntegration = TransNullToInt(objDT.Rows[0][convCourseLearningCase_Base.FileIntegration].ToString().Trim()); //文件积分(字段类型:int,字段长度:4,是否可空:True)
 objvCourseLearningCase_BaseEN.LikeCount = TransNullToInt(objDT.Rows[0][convCourseLearningCase_Base.LikeCount].ToString().Trim()); //资源喜欢数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvCourseLearningCase_BaseEN.CollectionCount = TransNullToInt(objDT.Rows[0][convCourseLearningCase_Base.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvCourseLearningCase_BaseEN.RecommendedDegreeId = objDT.Rows[0][convCourseLearningCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvCourseLearningCase_BaseEN.RecommendedDegreeName = objDT.Rows[0][convCourseLearningCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCourseLearningCase_BaseEN.ftpFileType = objDT.Rows[0][convCourseLearningCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvCourseLearningCase_BaseEN.VideoUrl = objDT.Rows[0][convCourseLearningCase_Base.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCourseLearningCase_BaseEN.VideoPath = objDT.Rows[0][convCourseLearningCase_Base.VideoPath].ToString().Trim(); //视频目录(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCourseLearningCase_BaseEN.ResErrMsg = objDT.Rows[0][convCourseLearningCase_Base.ResErrMsg].ToString().Trim(); //资源错误信息(字段类型:varchar,字段长度:30,是否可空:True)
 objvCourseLearningCase_BaseEN.Memo = objDT.Rows[0][convCourseLearningCase_Base.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCourseLearningCase_BaseEN.BrowseCount4Case = TransNullToInt(objDT.Rows[0][convCourseLearningCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvCourseLearningCase_BaseEN.OwnerName = objDT.Rows[0][convCourseLearningCase_Base.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvCourseLearningCase_BaseEN.OwnerNameWithId = objDT.Rows[0][convCourseLearningCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
 objvCourseLearningCase_BaseEN.OrderNum = TransNullToInt(objDT.Rows[0][convCourseLearningCase_Base.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvCourseLearningCase_BaseEN.IsUse = TransNullToBool(objDT.Rows[0][convCourseLearningCase_Base.IsUse].ToString().Trim()); //是否使用(字段类型:bit,字段长度:1,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvCourseLearningCase_BaseDA: GetvCourseLearningCase_Base)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdCourseLearningCase">表关键字</param>
 /// <returns>表对象</returns>
public clsvCourseLearningCase_BaseEN GetObjByIdCourseLearningCase(string strIdCourseLearningCase)
{
CheckPrimaryKey(strIdCourseLearningCase);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCase_BaseDA.GetSpecSQLObj();
strSQL = "Select * from vCourseLearningCase_Base where IdCourseLearningCase = " + "'"+ strIdCourseLearningCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN = new clsvCourseLearningCase_BaseEN();
try
{
 objvCourseLearningCase_BaseEN.IdCourseLearningCase = objRow[convCourseLearningCase_Base.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCase_BaseEN.CourseLearningCaseID = objRow[convCourseLearningCase_Base.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCase_BaseEN.CourseLearningCaseName = objRow[convCourseLearningCase_Base.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCourseLearningCase_BaseEN.CourseLearningCaseText = objRow[convCourseLearningCase_Base.CourseLearningCaseText] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objvCourseLearningCase_BaseEN.CourseLearningCaseTheme = objRow[convCourseLearningCase_Base.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvCourseLearningCase_BaseEN.CourseLearningCaseDate = objRow[convCourseLearningCase_Base.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseDate].ToString().Trim(); //课程学习日期(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningCase_BaseEN.CourseLearningCaseTime = objRow[convCourseLearningCase_Base.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseTime].ToString().Trim(); //课程学习时间(字段类型:char,字段长度:6,是否可空:True)
 objvCourseLearningCase_BaseEN.CourseLearningCaseDateIn = objRow[convCourseLearningCase_Base.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningCase_BaseEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCase_Base.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvCourseLearningCase_BaseEN.IdCaseType = objRow[convCourseLearningCase_Base.IdCaseType] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdCaseType].ToString().Trim(); //案例类型流水号(字段类型:char,字段长度:4,是否可空:True)
 objvCourseLearningCase_BaseEN.CaseTypeName = objRow[convCourseLearningCase_Base.CaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CaseTypeName].ToString().Trim(); //案例类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCourseLearningCase_BaseEN.IdCourseLearningCaseType = objRow[convCourseLearningCase_Base.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCase_BaseEN.CourseLearningCaseTypeName = objRow[convCourseLearningCase_Base.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCourseLearningCase_BaseEN.OwnerId = objRow[convCourseLearningCase_Base.OwnerId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvCourseLearningCase_BaseEN.IdStudyLevel = objRow[convCourseLearningCase_Base.IdStudyLevel] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvCourseLearningCase_BaseEN.StudyLevelName = objRow[convCourseLearningCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCourseLearningCase_BaseEN.IdTeachingPlan = objRow[convCourseLearningCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCase_BaseEN.IdDiscipline = objRow[convCourseLearningCase_Base.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCase_BaseEN.DisciplineID = objRow[convCourseLearningCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCase_BaseEN.DisciplineName = objRow[convCourseLearningCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCourseLearningCase_BaseEN.IdSenateGaugeVersion = objRow[convCourseLearningCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCase_BaseEN.senateGaugeVersionID = objRow[convCourseLearningCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCase_BaseEN.senateGaugeVersionName = objRow[convCourseLearningCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvCourseLearningCase_BaseEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convCourseLearningCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvCourseLearningCase_BaseEN.VersionNo = objRow[convCourseLearningCase_Base.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvCourseLearningCase_BaseEN.IdTeachSkill = objRow[convCourseLearningCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCase_BaseEN.TeachSkillID = objRow[convCourseLearningCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCase_BaseEN.SkillTypeName = objRow[convCourseLearningCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCourseLearningCase_BaseEN.TeachSkillName = objRow[convCourseLearningCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCourseLearningCase_BaseEN.TeachSkillTheory = objRow[convCourseLearningCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvCourseLearningCase_BaseEN.TeachSkillOperMethod = objRow[convCourseLearningCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法(字段类型:varchar,字段长度:2000,是否可空:True)
 objvCourseLearningCase_BaseEN.IdSkillType = objRow[convCourseLearningCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCase_BaseEN.SkillTypeID = objRow[convCourseLearningCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCase_BaseEN.CaseLevelId = objRow[convCourseLearningCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvCourseLearningCase_BaseEN.CaseLevelName = objRow[convCourseLearningCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvCourseLearningCase_BaseEN.DocFile = objRow[convCourseLearningCase_Base.DocFile] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.DocFile].ToString().Trim(); //生成的Word文件名(字段类型:varchar,字段长度:200,是否可空:True)
 objvCourseLearningCase_BaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word(字段类型:bit,字段长度:1,是否可空:True)
 objvCourseLearningCase_BaseEN.WordCreateDate = objRow[convCourseLearningCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objvCourseLearningCase_BaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Base.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvCourseLearningCase_BaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Base.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvCourseLearningCase_BaseEN.IdXzCollege = objRow[convCourseLearningCase_Base.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvCourseLearningCase_BaseEN.CollegeId = objRow[convCourseLearningCase_Base.CollegeId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CollegeId].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvCourseLearningCase_BaseEN.CollegeName = objRow[convCourseLearningCase_Base.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCourseLearningCase_BaseEN.CollegeNameA = objRow[convCourseLearningCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvCourseLearningCase_BaseEN.IdXzMajor = objRow[convCourseLearningCase_Base.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCase_BaseEN.MajorID = objRow[convCourseLearningCase_Base.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.MajorID].ToString().Trim(); //专业ID(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCase_BaseEN.MajorName = objRow[convCourseLearningCase_Base.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCourseLearningCase_BaseEN.CourseId = objRow[convCourseLearningCase_Base.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningCase_BaseEN.CourseCode = objRow[convCourseLearningCase_Base.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvCourseLearningCase_BaseEN.CourseName = objRow[convCourseLearningCase_Base.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvCourseLearningCase_BaseEN.CourseChapterId = objRow[convCourseLearningCase_Base.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCase_BaseEN.CourseChapterName = objRow[convCourseLearningCase_Base.CourseChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseChapterName].ToString().Trim(); //课程章节名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCourseLearningCase_BaseEN.ChapterId = objRow[convCourseLearningCase_Base.ChapterId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ChapterId].ToString().Trim(); //章Id(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningCase_BaseEN.ParentNodeId = objRow[convCourseLearningCase_Base.ParentNodeId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ParentNodeId].ToString().Trim(); //父节点编号(字段类型:varchar,字段长度:8,是否可空:True)
 objvCourseLearningCase_BaseEN.CourseChapterReferred = objRow[convCourseLearningCase_Base.CourseChapterReferred] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseChapterReferred].ToString().Trim(); //节简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvCourseLearningCase_BaseEN.ChapterName = objRow[convCourseLearningCase_Base.ChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ChapterName].ToString().Trim(); //章名(字段类型:varchar,字段长度:100,是否可空:True)
 objvCourseLearningCase_BaseEN.ChapterNameSim = objRow[convCourseLearningCase_Base.ChapterNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ChapterNameSim].ToString().Trim(); //章名简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvCourseLearningCase_BaseEN.SectionName = objRow[convCourseLearningCase_Base.SectionName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SectionName].ToString().Trim(); //节名(字段类型:varchar,字段长度:100,是否可空:True)
 objvCourseLearningCase_BaseEN.SectionNameSim = objRow[convCourseLearningCase_Base.SectionNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SectionNameSim].ToString().Trim(); //节名简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvCourseLearningCase_BaseEN.SectionId = objRow[convCourseLearningCase_Base.SectionId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SectionId].ToString().Trim(); //节Id(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningCase_BaseEN.ParentNodeReferred = objRow[convCourseLearningCase_Base.ParentNodeReferred] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ParentNodeReferred].ToString().Trim(); //章简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvCourseLearningCase_BaseEN.ParentNodeName = objRow[convCourseLearningCase_Base.ParentNodeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ParentNodeName].ToString().Trim(); //父节点名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvCourseLearningCase_BaseEN.ViewCount = objRow[convCourseLearningCase_Base.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvCourseLearningCase_BaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Base.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objvCourseLearningCase_BaseEN.DownloadNumber = objRow[convCourseLearningCase_Base.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.DownloadNumber].ToString().Trim()); //下载数目(字段类型:int,字段长度:4,是否可空:True)
 objvCourseLearningCase_BaseEN.FileIntegration = objRow[convCourseLearningCase_Base.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.FileIntegration].ToString().Trim()); //文件积分(字段类型:int,字段长度:4,是否可空:True)
 objvCourseLearningCase_BaseEN.LikeCount = objRow[convCourseLearningCase_Base.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.LikeCount].ToString().Trim()); //资源喜欢数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvCourseLearningCase_BaseEN.CollectionCount = objRow[convCourseLearningCase_Base.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvCourseLearningCase_BaseEN.RecommendedDegreeId = objRow[convCourseLearningCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvCourseLearningCase_BaseEN.RecommendedDegreeName = objRow[convCourseLearningCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCourseLearningCase_BaseEN.ftpFileType = objRow[convCourseLearningCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvCourseLearningCase_BaseEN.VideoUrl = objRow[convCourseLearningCase_Base.VideoUrl] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCourseLearningCase_BaseEN.VideoPath = objRow[convCourseLearningCase_Base.VideoPath] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.VideoPath].ToString().Trim(); //视频目录(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCourseLearningCase_BaseEN.ResErrMsg = objRow[convCourseLearningCase_Base.ResErrMsg] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ResErrMsg].ToString().Trim(); //资源错误信息(字段类型:varchar,字段长度:30,是否可空:True)
 objvCourseLearningCase_BaseEN.Memo = objRow[convCourseLearningCase_Base.Memo] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCourseLearningCase_BaseEN.BrowseCount4Case = objRow[convCourseLearningCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvCourseLearningCase_BaseEN.OwnerName = objRow[convCourseLearningCase_Base.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvCourseLearningCase_BaseEN.OwnerNameWithId = objRow[convCourseLearningCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
 objvCourseLearningCase_BaseEN.OrderNum = objRow[convCourseLearningCase_Base.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase_Base.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvCourseLearningCase_BaseEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase_Base.IsUse].ToString().Trim()); //是否使用(字段类型:bit,字段长度:1,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvCourseLearningCase_BaseDA: GetObjByIdCourseLearningCase)", objException.Message));
}
return objvCourseLearningCase_BaseEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvCourseLearningCase_BaseEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvCourseLearningCase_BaseDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCase_BaseDA.GetSpecSQLObj();
strSQL = "Select * from vCourseLearningCase_Base where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN = new clsvCourseLearningCase_BaseEN()
{
IdCourseLearningCase = objRow[convCourseLearningCase_Base.IdCourseLearningCase].ToString().Trim(), //课程学习案例流水号
CourseLearningCaseID = objRow[convCourseLearningCase_Base.CourseLearningCaseID].ToString().Trim(), //课程学习案例ID
CourseLearningCaseName = objRow[convCourseLearningCase_Base.CourseLearningCaseName].ToString().Trim(), //课程学习案例名称
CourseLearningCaseText = objRow[convCourseLearningCase_Base.CourseLearningCaseText] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseText].ToString().Trim(), //案例文本内容
CourseLearningCaseTheme = objRow[convCourseLearningCase_Base.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseTheme].ToString().Trim(), //课程学习案例主题词
CourseLearningCaseDate = objRow[convCourseLearningCase_Base.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseDate].ToString().Trim(), //课程学习日期
CourseLearningCaseTime = objRow[convCourseLearningCase_Base.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseTime].ToString().Trim(), //课程学习时间
CourseLearningCaseDateIn = objRow[convCourseLearningCase_Base.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseDateIn].ToString().Trim(), //案例入库日期
CourseLearningCaseTimeIn = objRow[convCourseLearningCase_Base.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseTimeIn].ToString().Trim(), //案例入库时间
IdCaseType = objRow[convCourseLearningCase_Base.IdCaseType] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdCaseType].ToString().Trim(), //案例类型流水号
CaseTypeName = objRow[convCourseLearningCase_Base.CaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CaseTypeName].ToString().Trim(), //案例类型名称
IdCourseLearningCaseType = objRow[convCourseLearningCase_Base.IdCourseLearningCaseType].ToString().Trim(), //课程学习案例类型流水号
CourseLearningCaseTypeName = objRow[convCourseLearningCase_Base.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseTypeName].ToString().Trim(), //课程学习案例类型名称
OwnerId = objRow[convCourseLearningCase_Base.OwnerId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.OwnerId].ToString().Trim(), //拥有者Id
IdStudyLevel = objRow[convCourseLearningCase_Base.IdStudyLevel] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdStudyLevel].ToString().Trim(), //id_StudyLevel
StudyLevelName = objRow[convCourseLearningCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.StudyLevelName].ToString().Trim(), //学段名称
IdTeachingPlan = objRow[convCourseLearningCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdTeachingPlan].ToString().Trim(), //教案流水号
IdDiscipline = objRow[convCourseLearningCase_Base.IdDiscipline].ToString().Trim(), //学科流水号
DisciplineID = objRow[convCourseLearningCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.DisciplineID].ToString().Trim(), //学科ID
DisciplineName = objRow[convCourseLearningCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.DisciplineName].ToString().Trim(), //学科名称
IdSenateGaugeVersion = objRow[convCourseLearningCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdSenateGaugeVersion].ToString().Trim(), //评价量表版本流水号
senateGaugeVersionID = objRow[convCourseLearningCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.senateGaugeVersionID].ToString().Trim(), //评价量表版本ID
senateGaugeVersionName = objRow[convCourseLearningCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.senateGaugeVersionName].ToString().Trim(), //评价量表版本名称
senateGaugeVersionTtlScore = objRow[convCourseLearningCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convCourseLearningCase_Base.senateGaugeVersionTtlScore].ToString().Trim()), //评价量表版本总分
VersionNo = objRow[convCourseLearningCase_Base.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase_Base.VersionNo].ToString().Trim()), //版本号
IdTeachSkill = objRow[convCourseLearningCase_Base.IdTeachSkill].ToString().Trim(), //教学技能流水号
TeachSkillID = objRow[convCourseLearningCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.TeachSkillID].ToString().Trim(), //教学技能ID
SkillTypeName = objRow[convCourseLearningCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SkillTypeName].ToString().Trim(), //技能类型名称
TeachSkillName = objRow[convCourseLearningCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.TeachSkillName].ToString().Trim(), //教学技能名称
TeachSkillTheory = objRow[convCourseLearningCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.TeachSkillTheory].ToString().Trim(), //教学技能理论阐述
TeachSkillOperMethod = objRow[convCourseLearningCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.TeachSkillOperMethod].ToString().Trim(), //教学技能实践操作方法
IdSkillType = objRow[convCourseLearningCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdSkillType].ToString().Trim(), //技能类型流水号
SkillTypeID = objRow[convCourseLearningCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SkillTypeID].ToString().Trim(), //技能类型ID
CaseLevelId = objRow[convCourseLearningCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CaseLevelId].ToString().Trim(), //课例等级Id
CaseLevelName = objRow[convCourseLearningCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CaseLevelName].ToString().Trim(), //案例等级名称
DocFile = objRow[convCourseLearningCase_Base.DocFile] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.DocFile].ToString().Trim(), //生成的Word文件名
IsNeedGeneWord = TransNullToBool(objRow[convCourseLearningCase_Base.IsNeedGeneWord].ToString().Trim()), //是否需要生成Word
WordCreateDate = objRow[convCourseLearningCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.WordCreateDate].ToString().Trim(), //Word生成日期
IsVisible = TransNullToBool(objRow[convCourseLearningCase_Base.IsVisible].ToString().Trim()), //是否显示
IsDualVideo = TransNullToBool(objRow[convCourseLearningCase_Base.IsDualVideo].ToString().Trim()), //是否双视频
IdXzCollege = objRow[convCourseLearningCase_Base.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdXzCollege].ToString().Trim(), //学院流水号
CollegeId = objRow[convCourseLearningCase_Base.CollegeId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CollegeId].ToString().Trim(), //学院ID
CollegeName = objRow[convCourseLearningCase_Base.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CollegeName].ToString().Trim(), //学院名称
CollegeNameA = objRow[convCourseLearningCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CollegeNameA].ToString().Trim(), //学院名称简写
IdXzMajor = objRow[convCourseLearningCase_Base.IdXzMajor].ToString().Trim(), //专业流水号
MajorID = objRow[convCourseLearningCase_Base.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.MajorID].ToString().Trim(), //专业ID
MajorName = objRow[convCourseLearningCase_Base.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.MajorName].ToString().Trim(), //专业名称
CourseId = objRow[convCourseLearningCase_Base.CourseId].ToString().Trim(), //课程Id
CourseCode = objRow[convCourseLearningCase_Base.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseCode].ToString().Trim(), //课程代码
CourseName = objRow[convCourseLearningCase_Base.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseName].ToString().Trim(), //课程名称
CourseChapterId = objRow[convCourseLearningCase_Base.CourseChapterId].ToString().Trim(), //课程章节ID
CourseChapterName = objRow[convCourseLearningCase_Base.CourseChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseChapterName].ToString().Trim(), //课程章节名称
ChapterId = objRow[convCourseLearningCase_Base.ChapterId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ChapterId].ToString().Trim(), //章Id
ParentNodeId = objRow[convCourseLearningCase_Base.ParentNodeId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ParentNodeId].ToString().Trim(), //父节点编号
CourseChapterReferred = objRow[convCourseLearningCase_Base.CourseChapterReferred] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseChapterReferred].ToString().Trim(), //节简称
ChapterName = objRow[convCourseLearningCase_Base.ChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ChapterName].ToString().Trim(), //章名
ChapterNameSim = objRow[convCourseLearningCase_Base.ChapterNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ChapterNameSim].ToString().Trim(), //章名简称
SectionName = objRow[convCourseLearningCase_Base.SectionName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SectionName].ToString().Trim(), //节名
SectionNameSim = objRow[convCourseLearningCase_Base.SectionNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SectionNameSim].ToString().Trim(), //节名简称
SectionId = objRow[convCourseLearningCase_Base.SectionId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SectionId].ToString().Trim(), //节Id
ParentNodeReferred = objRow[convCourseLearningCase_Base.ParentNodeReferred] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ParentNodeReferred].ToString().Trim(), //章简称
ParentNodeName = objRow[convCourseLearningCase_Base.ParentNodeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ParentNodeName].ToString().Trim(), //父节点名称
ViewCount = objRow[convCourseLearningCase_Base.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase_Base.ViewCount].ToString().Trim()), //浏览量
IsShow = TransNullToBool(objRow[convCourseLearningCase_Base.IsShow].ToString().Trim()), //是否启用
DownloadNumber = objRow[convCourseLearningCase_Base.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase_Base.DownloadNumber].ToString().Trim()), //下载数目
FileIntegration = objRow[convCourseLearningCase_Base.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase_Base.FileIntegration].ToString().Trim()), //文件积分
LikeCount = objRow[convCourseLearningCase_Base.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCourseLearningCase_Base.LikeCount].ToString().Trim()), //资源喜欢数量
CollectionCount = objRow[convCourseLearningCase_Base.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCourseLearningCase_Base.CollectionCount].ToString().Trim()), //收藏数量
RecommendedDegreeId = objRow[convCourseLearningCase_Base.RecommendedDegreeId].ToString().Trim(), //推荐度Id
RecommendedDegreeName = objRow[convCourseLearningCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.RecommendedDegreeName].ToString().Trim(), //推荐度名称
ftpFileType = objRow[convCourseLearningCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ftpFileType].ToString().Trim(), //ftp文件类型
VideoUrl = objRow[convCourseLearningCase_Base.VideoUrl] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.VideoUrl].ToString().Trim(), //视频Url
VideoPath = objRow[convCourseLearningCase_Base.VideoPath] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.VideoPath].ToString().Trim(), //视频目录
ResErrMsg = objRow[convCourseLearningCase_Base.ResErrMsg] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ResErrMsg].ToString().Trim(), //资源错误信息
Memo = objRow[convCourseLearningCase_Base.Memo] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.Memo].ToString().Trim(), //备注
BrowseCount4Case = objRow[convCourseLearningCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase_Base.BrowseCount4Case].ToString().Trim()), //课例浏览次数
OwnerName = objRow[convCourseLearningCase_Base.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.OwnerName].ToString().Trim(), //拥有者姓名
OwnerNameWithId = objRow[convCourseLearningCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.OwnerNameWithId].ToString().Trim(), //拥有者名称附Id
OrderNum = objRow[convCourseLearningCase_Base.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase_Base.OrderNum].ToString().Trim()), //序号
IsUse = TransNullToBool(objRow[convCourseLearningCase_Base.IsUse].ToString().Trim()) //是否使用
};
objvCourseLearningCase_BaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCourseLearningCase_BaseEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvCourseLearningCase_BaseDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvCourseLearningCase_BaseEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN = new clsvCourseLearningCase_BaseEN();
try
{
objvCourseLearningCase_BaseEN.IdCourseLearningCase = objRow[convCourseLearningCase_Base.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCase_BaseEN.CourseLearningCaseID = objRow[convCourseLearningCase_Base.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCase_BaseEN.CourseLearningCaseName = objRow[convCourseLearningCase_Base.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCase_BaseEN.CourseLearningCaseText = objRow[convCourseLearningCase_Base.CourseLearningCaseText] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseText].ToString().Trim(); //案例文本内容
objvCourseLearningCase_BaseEN.CourseLearningCaseTheme = objRow[convCourseLearningCase_Base.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningCase_BaseEN.CourseLearningCaseDate = objRow[convCourseLearningCase_Base.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningCase_BaseEN.CourseLearningCaseTime = objRow[convCourseLearningCase_Base.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningCase_BaseEN.CourseLearningCaseDateIn = objRow[convCourseLearningCase_Base.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningCase_BaseEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCase_Base.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningCase_BaseEN.IdCaseType = objRow[convCourseLearningCase_Base.IdCaseType] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdCaseType].ToString().Trim(); //案例类型流水号
objvCourseLearningCase_BaseEN.CaseTypeName = objRow[convCourseLearningCase_Base.CaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CaseTypeName].ToString().Trim(); //案例类型名称
objvCourseLearningCase_BaseEN.IdCourseLearningCaseType = objRow[convCourseLearningCase_Base.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号
objvCourseLearningCase_BaseEN.CourseLearningCaseTypeName = objRow[convCourseLearningCase_Base.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningCase_BaseEN.OwnerId = objRow[convCourseLearningCase_Base.OwnerId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.OwnerId].ToString().Trim(); //拥有者Id
objvCourseLearningCase_BaseEN.IdStudyLevel = objRow[convCourseLearningCase_Base.IdStudyLevel] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCourseLearningCase_BaseEN.StudyLevelName = objRow[convCourseLearningCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.StudyLevelName].ToString().Trim(); //学段名称
objvCourseLearningCase_BaseEN.IdTeachingPlan = objRow[convCourseLearningCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCourseLearningCase_BaseEN.IdDiscipline = objRow[convCourseLearningCase_Base.IdDiscipline].ToString().Trim(); //学科流水号
objvCourseLearningCase_BaseEN.DisciplineID = objRow[convCourseLearningCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.DisciplineID].ToString().Trim(); //学科ID
objvCourseLearningCase_BaseEN.DisciplineName = objRow[convCourseLearningCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.DisciplineName].ToString().Trim(); //学科名称
objvCourseLearningCase_BaseEN.IdSenateGaugeVersion = objRow[convCourseLearningCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCourseLearningCase_BaseEN.senateGaugeVersionID = objRow[convCourseLearningCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCourseLearningCase_BaseEN.senateGaugeVersionName = objRow[convCourseLearningCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCourseLearningCase_BaseEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convCourseLearningCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCourseLearningCase_BaseEN.VersionNo = objRow[convCourseLearningCase_Base.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase_Base.VersionNo].ToString().Trim()); //版本号
objvCourseLearningCase_BaseEN.IdTeachSkill = objRow[convCourseLearningCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCourseLearningCase_BaseEN.TeachSkillID = objRow[convCourseLearningCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID
objvCourseLearningCase_BaseEN.SkillTypeName = objRow[convCourseLearningCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称
objvCourseLearningCase_BaseEN.TeachSkillName = objRow[convCourseLearningCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称
objvCourseLearningCase_BaseEN.TeachSkillTheory = objRow[convCourseLearningCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCourseLearningCase_BaseEN.TeachSkillOperMethod = objRow[convCourseLearningCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCourseLearningCase_BaseEN.IdSkillType = objRow[convCourseLearningCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号
objvCourseLearningCase_BaseEN.SkillTypeID = objRow[convCourseLearningCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID
objvCourseLearningCase_BaseEN.CaseLevelId = objRow[convCourseLearningCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvCourseLearningCase_BaseEN.CaseLevelName = objRow[convCourseLearningCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvCourseLearningCase_BaseEN.DocFile = objRow[convCourseLearningCase_Base.DocFile] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.DocFile].ToString().Trim(); //生成的Word文件名
objvCourseLearningCase_BaseEN.IsNeedGeneWord = TransNullToBool(objRow[convCourseLearningCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvCourseLearningCase_BaseEN.WordCreateDate = objRow[convCourseLearningCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期
objvCourseLearningCase_BaseEN.IsVisible = TransNullToBool(objRow[convCourseLearningCase_Base.IsVisible].ToString().Trim()); //是否显示
objvCourseLearningCase_BaseEN.IsDualVideo = TransNullToBool(objRow[convCourseLearningCase_Base.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCase_BaseEN.IdXzCollege = objRow[convCourseLearningCase_Base.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCase_BaseEN.CollegeId = objRow[convCourseLearningCase_Base.CollegeId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CollegeId].ToString().Trim(); //学院ID
objvCourseLearningCase_BaseEN.CollegeName = objRow[convCourseLearningCase_Base.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCase_BaseEN.CollegeNameA = objRow[convCourseLearningCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningCase_BaseEN.IdXzMajor = objRow[convCourseLearningCase_Base.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningCase_BaseEN.MajorID = objRow[convCourseLearningCase_Base.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCase_BaseEN.MajorName = objRow[convCourseLearningCase_Base.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCase_BaseEN.CourseId = objRow[convCourseLearningCase_Base.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCase_BaseEN.CourseCode = objRow[convCourseLearningCase_Base.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCase_BaseEN.CourseName = objRow[convCourseLearningCase_Base.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCase_BaseEN.CourseChapterId = objRow[convCourseLearningCase_Base.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCase_BaseEN.CourseChapterName = objRow[convCourseLearningCase_Base.CourseChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseChapterName].ToString().Trim(); //课程章节名称
objvCourseLearningCase_BaseEN.ChapterId = objRow[convCourseLearningCase_Base.ChapterId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ChapterId].ToString().Trim(); //章Id
objvCourseLearningCase_BaseEN.ParentNodeId = objRow[convCourseLearningCase_Base.ParentNodeId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ParentNodeId].ToString().Trim(); //父节点编号
objvCourseLearningCase_BaseEN.CourseChapterReferred = objRow[convCourseLearningCase_Base.CourseChapterReferred] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseChapterReferred].ToString().Trim(); //节简称
objvCourseLearningCase_BaseEN.ChapterName = objRow[convCourseLearningCase_Base.ChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ChapterName].ToString().Trim(); //章名
objvCourseLearningCase_BaseEN.ChapterNameSim = objRow[convCourseLearningCase_Base.ChapterNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ChapterNameSim].ToString().Trim(); //章名简称
objvCourseLearningCase_BaseEN.SectionName = objRow[convCourseLearningCase_Base.SectionName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SectionName].ToString().Trim(); //节名
objvCourseLearningCase_BaseEN.SectionNameSim = objRow[convCourseLearningCase_Base.SectionNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SectionNameSim].ToString().Trim(); //节名简称
objvCourseLearningCase_BaseEN.SectionId = objRow[convCourseLearningCase_Base.SectionId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SectionId].ToString().Trim(); //节Id
objvCourseLearningCase_BaseEN.ParentNodeReferred = objRow[convCourseLearningCase_Base.ParentNodeReferred] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ParentNodeReferred].ToString().Trim(); //章简称
objvCourseLearningCase_BaseEN.ParentNodeName = objRow[convCourseLearningCase_Base.ParentNodeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ParentNodeName].ToString().Trim(); //父节点名称
objvCourseLearningCase_BaseEN.ViewCount = objRow[convCourseLearningCase_Base.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase_Base.ViewCount].ToString().Trim()); //浏览量
objvCourseLearningCase_BaseEN.IsShow = TransNullToBool(objRow[convCourseLearningCase_Base.IsShow].ToString().Trim()); //是否启用
objvCourseLearningCase_BaseEN.DownloadNumber = objRow[convCourseLearningCase_Base.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase_Base.DownloadNumber].ToString().Trim()); //下载数目
objvCourseLearningCase_BaseEN.FileIntegration = objRow[convCourseLearningCase_Base.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase_Base.FileIntegration].ToString().Trim()); //文件积分
objvCourseLearningCase_BaseEN.LikeCount = objRow[convCourseLearningCase_Base.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCourseLearningCase_Base.LikeCount].ToString().Trim()); //资源喜欢数量
objvCourseLearningCase_BaseEN.CollectionCount = objRow[convCourseLearningCase_Base.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCourseLearningCase_Base.CollectionCount].ToString().Trim()); //收藏数量
objvCourseLearningCase_BaseEN.RecommendedDegreeId = objRow[convCourseLearningCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCourseLearningCase_BaseEN.RecommendedDegreeName = objRow[convCourseLearningCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCourseLearningCase_BaseEN.ftpFileType = objRow[convCourseLearningCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvCourseLearningCase_BaseEN.VideoUrl = objRow[convCourseLearningCase_Base.VideoUrl] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.VideoUrl].ToString().Trim(); //视频Url
objvCourseLearningCase_BaseEN.VideoPath = objRow[convCourseLearningCase_Base.VideoPath] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.VideoPath].ToString().Trim(); //视频目录
objvCourseLearningCase_BaseEN.ResErrMsg = objRow[convCourseLearningCase_Base.ResErrMsg] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ResErrMsg].ToString().Trim(); //资源错误信息
objvCourseLearningCase_BaseEN.Memo = objRow[convCourseLearningCase_Base.Memo] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.Memo].ToString().Trim(); //备注
objvCourseLearningCase_BaseEN.BrowseCount4Case = objRow[convCourseLearningCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningCase_BaseEN.OwnerName = objRow[convCourseLearningCase_Base.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvCourseLearningCase_BaseEN.OwnerNameWithId = objRow[convCourseLearningCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCourseLearningCase_BaseEN.OrderNum = objRow[convCourseLearningCase_Base.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase_Base.OrderNum].ToString().Trim()); //序号
objvCourseLearningCase_BaseEN.IsUse = TransNullToBool(objRow[convCourseLearningCase_Base.IsUse].ToString().Trim()); //是否使用
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvCourseLearningCase_BaseDA: GetObjByDataRowvCourseLearningCase_Base)", objException.Message));
}
objvCourseLearningCase_BaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCourseLearningCase_BaseEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvCourseLearningCase_BaseEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN = new clsvCourseLearningCase_BaseEN();
try
{
objvCourseLearningCase_BaseEN.IdCourseLearningCase = objRow[convCourseLearningCase_Base.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCase_BaseEN.CourseLearningCaseID = objRow[convCourseLearningCase_Base.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCase_BaseEN.CourseLearningCaseName = objRow[convCourseLearningCase_Base.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCase_BaseEN.CourseLearningCaseText = objRow[convCourseLearningCase_Base.CourseLearningCaseText] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseText].ToString().Trim(); //案例文本内容
objvCourseLearningCase_BaseEN.CourseLearningCaseTheme = objRow[convCourseLearningCase_Base.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningCase_BaseEN.CourseLearningCaseDate = objRow[convCourseLearningCase_Base.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningCase_BaseEN.CourseLearningCaseTime = objRow[convCourseLearningCase_Base.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningCase_BaseEN.CourseLearningCaseDateIn = objRow[convCourseLearningCase_Base.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningCase_BaseEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCase_Base.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningCase_BaseEN.IdCaseType = objRow[convCourseLearningCase_Base.IdCaseType] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdCaseType].ToString().Trim(); //案例类型流水号
objvCourseLearningCase_BaseEN.CaseTypeName = objRow[convCourseLearningCase_Base.CaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CaseTypeName].ToString().Trim(); //案例类型名称
objvCourseLearningCase_BaseEN.IdCourseLearningCaseType = objRow[convCourseLearningCase_Base.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号
objvCourseLearningCase_BaseEN.CourseLearningCaseTypeName = objRow[convCourseLearningCase_Base.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningCase_BaseEN.OwnerId = objRow[convCourseLearningCase_Base.OwnerId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.OwnerId].ToString().Trim(); //拥有者Id
objvCourseLearningCase_BaseEN.IdStudyLevel = objRow[convCourseLearningCase_Base.IdStudyLevel] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCourseLearningCase_BaseEN.StudyLevelName = objRow[convCourseLearningCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.StudyLevelName].ToString().Trim(); //学段名称
objvCourseLearningCase_BaseEN.IdTeachingPlan = objRow[convCourseLearningCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCourseLearningCase_BaseEN.IdDiscipline = objRow[convCourseLearningCase_Base.IdDiscipline].ToString().Trim(); //学科流水号
objvCourseLearningCase_BaseEN.DisciplineID = objRow[convCourseLearningCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.DisciplineID].ToString().Trim(); //学科ID
objvCourseLearningCase_BaseEN.DisciplineName = objRow[convCourseLearningCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.DisciplineName].ToString().Trim(); //学科名称
objvCourseLearningCase_BaseEN.IdSenateGaugeVersion = objRow[convCourseLearningCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCourseLearningCase_BaseEN.senateGaugeVersionID = objRow[convCourseLearningCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCourseLearningCase_BaseEN.senateGaugeVersionName = objRow[convCourseLearningCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCourseLearningCase_BaseEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convCourseLearningCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCourseLearningCase_BaseEN.VersionNo = objRow[convCourseLearningCase_Base.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase_Base.VersionNo].ToString().Trim()); //版本号
objvCourseLearningCase_BaseEN.IdTeachSkill = objRow[convCourseLearningCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCourseLearningCase_BaseEN.TeachSkillID = objRow[convCourseLearningCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID
objvCourseLearningCase_BaseEN.SkillTypeName = objRow[convCourseLearningCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称
objvCourseLearningCase_BaseEN.TeachSkillName = objRow[convCourseLearningCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称
objvCourseLearningCase_BaseEN.TeachSkillTheory = objRow[convCourseLearningCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCourseLearningCase_BaseEN.TeachSkillOperMethod = objRow[convCourseLearningCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCourseLearningCase_BaseEN.IdSkillType = objRow[convCourseLearningCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号
objvCourseLearningCase_BaseEN.SkillTypeID = objRow[convCourseLearningCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID
objvCourseLearningCase_BaseEN.CaseLevelId = objRow[convCourseLearningCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvCourseLearningCase_BaseEN.CaseLevelName = objRow[convCourseLearningCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvCourseLearningCase_BaseEN.DocFile = objRow[convCourseLearningCase_Base.DocFile] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.DocFile].ToString().Trim(); //生成的Word文件名
objvCourseLearningCase_BaseEN.IsNeedGeneWord = TransNullToBool(objRow[convCourseLearningCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvCourseLearningCase_BaseEN.WordCreateDate = objRow[convCourseLearningCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期
objvCourseLearningCase_BaseEN.IsVisible = TransNullToBool(objRow[convCourseLearningCase_Base.IsVisible].ToString().Trim()); //是否显示
objvCourseLearningCase_BaseEN.IsDualVideo = TransNullToBool(objRow[convCourseLearningCase_Base.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCase_BaseEN.IdXzCollege = objRow[convCourseLearningCase_Base.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCase_BaseEN.CollegeId = objRow[convCourseLearningCase_Base.CollegeId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CollegeId].ToString().Trim(); //学院ID
objvCourseLearningCase_BaseEN.CollegeName = objRow[convCourseLearningCase_Base.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCase_BaseEN.CollegeNameA = objRow[convCourseLearningCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningCase_BaseEN.IdXzMajor = objRow[convCourseLearningCase_Base.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningCase_BaseEN.MajorID = objRow[convCourseLearningCase_Base.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCase_BaseEN.MajorName = objRow[convCourseLearningCase_Base.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCase_BaseEN.CourseId = objRow[convCourseLearningCase_Base.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCase_BaseEN.CourseCode = objRow[convCourseLearningCase_Base.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCase_BaseEN.CourseName = objRow[convCourseLearningCase_Base.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCase_BaseEN.CourseChapterId = objRow[convCourseLearningCase_Base.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCase_BaseEN.CourseChapterName = objRow[convCourseLearningCase_Base.CourseChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseChapterName].ToString().Trim(); //课程章节名称
objvCourseLearningCase_BaseEN.ChapterId = objRow[convCourseLearningCase_Base.ChapterId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ChapterId].ToString().Trim(); //章Id
objvCourseLearningCase_BaseEN.ParentNodeId = objRow[convCourseLearningCase_Base.ParentNodeId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ParentNodeId].ToString().Trim(); //父节点编号
objvCourseLearningCase_BaseEN.CourseChapterReferred = objRow[convCourseLearningCase_Base.CourseChapterReferred] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.CourseChapterReferred].ToString().Trim(); //节简称
objvCourseLearningCase_BaseEN.ChapterName = objRow[convCourseLearningCase_Base.ChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ChapterName].ToString().Trim(); //章名
objvCourseLearningCase_BaseEN.ChapterNameSim = objRow[convCourseLearningCase_Base.ChapterNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ChapterNameSim].ToString().Trim(); //章名简称
objvCourseLearningCase_BaseEN.SectionName = objRow[convCourseLearningCase_Base.SectionName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SectionName].ToString().Trim(); //节名
objvCourseLearningCase_BaseEN.SectionNameSim = objRow[convCourseLearningCase_Base.SectionNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SectionNameSim].ToString().Trim(); //节名简称
objvCourseLearningCase_BaseEN.SectionId = objRow[convCourseLearningCase_Base.SectionId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.SectionId].ToString().Trim(); //节Id
objvCourseLearningCase_BaseEN.ParentNodeReferred = objRow[convCourseLearningCase_Base.ParentNodeReferred] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ParentNodeReferred].ToString().Trim(); //章简称
objvCourseLearningCase_BaseEN.ParentNodeName = objRow[convCourseLearningCase_Base.ParentNodeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ParentNodeName].ToString().Trim(); //父节点名称
objvCourseLearningCase_BaseEN.ViewCount = objRow[convCourseLearningCase_Base.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase_Base.ViewCount].ToString().Trim()); //浏览量
objvCourseLearningCase_BaseEN.IsShow = TransNullToBool(objRow[convCourseLearningCase_Base.IsShow].ToString().Trim()); //是否启用
objvCourseLearningCase_BaseEN.DownloadNumber = objRow[convCourseLearningCase_Base.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase_Base.DownloadNumber].ToString().Trim()); //下载数目
objvCourseLearningCase_BaseEN.FileIntegration = objRow[convCourseLearningCase_Base.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase_Base.FileIntegration].ToString().Trim()); //文件积分
objvCourseLearningCase_BaseEN.LikeCount = objRow[convCourseLearningCase_Base.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCourseLearningCase_Base.LikeCount].ToString().Trim()); //资源喜欢数量
objvCourseLearningCase_BaseEN.CollectionCount = objRow[convCourseLearningCase_Base.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCourseLearningCase_Base.CollectionCount].ToString().Trim()); //收藏数量
objvCourseLearningCase_BaseEN.RecommendedDegreeId = objRow[convCourseLearningCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCourseLearningCase_BaseEN.RecommendedDegreeName = objRow[convCourseLearningCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCourseLearningCase_BaseEN.ftpFileType = objRow[convCourseLearningCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvCourseLearningCase_BaseEN.VideoUrl = objRow[convCourseLearningCase_Base.VideoUrl] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.VideoUrl].ToString().Trim(); //视频Url
objvCourseLearningCase_BaseEN.VideoPath = objRow[convCourseLearningCase_Base.VideoPath] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.VideoPath].ToString().Trim(); //视频目录
objvCourseLearningCase_BaseEN.ResErrMsg = objRow[convCourseLearningCase_Base.ResErrMsg] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.ResErrMsg].ToString().Trim(); //资源错误信息
objvCourseLearningCase_BaseEN.Memo = objRow[convCourseLearningCase_Base.Memo] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.Memo].ToString().Trim(); //备注
objvCourseLearningCase_BaseEN.BrowseCount4Case = objRow[convCourseLearningCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningCase_BaseEN.OwnerName = objRow[convCourseLearningCase_Base.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvCourseLearningCase_BaseEN.OwnerNameWithId = objRow[convCourseLearningCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCourseLearningCase_BaseEN.OrderNum = objRow[convCourseLearningCase_Base.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase_Base.OrderNum].ToString().Trim()); //序号
objvCourseLearningCase_BaseEN.IsUse = TransNullToBool(objRow[convCourseLearningCase_Base.IsUse].ToString().Trim()); //是否使用
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvCourseLearningCase_BaseDA: GetObjByDataRow)", objException.Message));
}
objvCourseLearningCase_BaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCourseLearningCase_BaseEN;
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
objSQL = clsvCourseLearningCase_BaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCourseLearningCase_BaseEN._CurrTabName, convCourseLearningCase_Base.IdCourseLearningCase, 8, "");
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
objSQL = clsvCourseLearningCase_BaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCourseLearningCase_BaseEN._CurrTabName, convCourseLearningCase_Base.IdCourseLearningCase, 8, strPrefix);
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
 objSQL = clsvCourseLearningCase_BaseDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdCourseLearningCase from vCourseLearningCase_Base where " + strCondition;
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
 objSQL = clsvCourseLearningCase_BaseDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdCourseLearningCase from vCourseLearningCase_Base where " + strCondition;
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
 objSQL = clsvCourseLearningCase_BaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCourseLearningCase_Base", "IdCourseLearningCase = " + "'"+ strIdCourseLearningCase+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvCourseLearningCase_BaseDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCase_BaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCourseLearningCase_Base", strCondition))
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
objSQL = clsvCourseLearningCase_BaseDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vCourseLearningCase_Base");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvCourseLearningCase_BaseENS">源对象</param>
 /// <param name = "objvCourseLearningCase_BaseENT">目标对象</param>
public void CopyTo(clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseENS, clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseENT)
{
objvCourseLearningCase_BaseENT.IdCourseLearningCase = objvCourseLearningCase_BaseENS.IdCourseLearningCase; //课程学习案例流水号
objvCourseLearningCase_BaseENT.CourseLearningCaseID = objvCourseLearningCase_BaseENS.CourseLearningCaseID; //课程学习案例ID
objvCourseLearningCase_BaseENT.CourseLearningCaseName = objvCourseLearningCase_BaseENS.CourseLearningCaseName; //课程学习案例名称
objvCourseLearningCase_BaseENT.CourseLearningCaseText = objvCourseLearningCase_BaseENS.CourseLearningCaseText; //案例文本内容
objvCourseLearningCase_BaseENT.CourseLearningCaseTheme = objvCourseLearningCase_BaseENS.CourseLearningCaseTheme; //课程学习案例主题词
objvCourseLearningCase_BaseENT.CourseLearningCaseDate = objvCourseLearningCase_BaseENS.CourseLearningCaseDate; //课程学习日期
objvCourseLearningCase_BaseENT.CourseLearningCaseTime = objvCourseLearningCase_BaseENS.CourseLearningCaseTime; //课程学习时间
objvCourseLearningCase_BaseENT.CourseLearningCaseDateIn = objvCourseLearningCase_BaseENS.CourseLearningCaseDateIn; //案例入库日期
objvCourseLearningCase_BaseENT.CourseLearningCaseTimeIn = objvCourseLearningCase_BaseENS.CourseLearningCaseTimeIn; //案例入库时间
objvCourseLearningCase_BaseENT.IdCaseType = objvCourseLearningCase_BaseENS.IdCaseType; //案例类型流水号
objvCourseLearningCase_BaseENT.CaseTypeName = objvCourseLearningCase_BaseENS.CaseTypeName; //案例类型名称
objvCourseLearningCase_BaseENT.IdCourseLearningCaseType = objvCourseLearningCase_BaseENS.IdCourseLearningCaseType; //课程学习案例类型流水号
objvCourseLearningCase_BaseENT.CourseLearningCaseTypeName = objvCourseLearningCase_BaseENS.CourseLearningCaseTypeName; //课程学习案例类型名称
objvCourseLearningCase_BaseENT.OwnerId = objvCourseLearningCase_BaseENS.OwnerId; //拥有者Id
objvCourseLearningCase_BaseENT.IdStudyLevel = objvCourseLearningCase_BaseENS.IdStudyLevel; //id_StudyLevel
objvCourseLearningCase_BaseENT.StudyLevelName = objvCourseLearningCase_BaseENS.StudyLevelName; //学段名称
objvCourseLearningCase_BaseENT.IdTeachingPlan = objvCourseLearningCase_BaseENS.IdTeachingPlan; //教案流水号
objvCourseLearningCase_BaseENT.IdDiscipline = objvCourseLearningCase_BaseENS.IdDiscipline; //学科流水号
objvCourseLearningCase_BaseENT.DisciplineID = objvCourseLearningCase_BaseENS.DisciplineID; //学科ID
objvCourseLearningCase_BaseENT.DisciplineName = objvCourseLearningCase_BaseENS.DisciplineName; //学科名称
objvCourseLearningCase_BaseENT.IdSenateGaugeVersion = objvCourseLearningCase_BaseENS.IdSenateGaugeVersion; //评价量表版本流水号
objvCourseLearningCase_BaseENT.senateGaugeVersionID = objvCourseLearningCase_BaseENS.senateGaugeVersionID; //评价量表版本ID
objvCourseLearningCase_BaseENT.senateGaugeVersionName = objvCourseLearningCase_BaseENS.senateGaugeVersionName; //评价量表版本名称
objvCourseLearningCase_BaseENT.senateGaugeVersionTtlScore = objvCourseLearningCase_BaseENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvCourseLearningCase_BaseENT.VersionNo = objvCourseLearningCase_BaseENS.VersionNo; //版本号
objvCourseLearningCase_BaseENT.IdTeachSkill = objvCourseLearningCase_BaseENS.IdTeachSkill; //教学技能流水号
objvCourseLearningCase_BaseENT.TeachSkillID = objvCourseLearningCase_BaseENS.TeachSkillID; //教学技能ID
objvCourseLearningCase_BaseENT.SkillTypeName = objvCourseLearningCase_BaseENS.SkillTypeName; //技能类型名称
objvCourseLearningCase_BaseENT.TeachSkillName = objvCourseLearningCase_BaseENS.TeachSkillName; //教学技能名称
objvCourseLearningCase_BaseENT.TeachSkillTheory = objvCourseLearningCase_BaseENS.TeachSkillTheory; //教学技能理论阐述
objvCourseLearningCase_BaseENT.TeachSkillOperMethod = objvCourseLearningCase_BaseENS.TeachSkillOperMethod; //教学技能实践操作方法
objvCourseLearningCase_BaseENT.IdSkillType = objvCourseLearningCase_BaseENS.IdSkillType; //技能类型流水号
objvCourseLearningCase_BaseENT.SkillTypeID = objvCourseLearningCase_BaseENS.SkillTypeID; //技能类型ID
objvCourseLearningCase_BaseENT.CaseLevelId = objvCourseLearningCase_BaseENS.CaseLevelId; //课例等级Id
objvCourseLearningCase_BaseENT.CaseLevelName = objvCourseLearningCase_BaseENS.CaseLevelName; //案例等级名称
objvCourseLearningCase_BaseENT.DocFile = objvCourseLearningCase_BaseENS.DocFile; //生成的Word文件名
objvCourseLearningCase_BaseENT.IsNeedGeneWord = objvCourseLearningCase_BaseENS.IsNeedGeneWord; //是否需要生成Word
objvCourseLearningCase_BaseENT.WordCreateDate = objvCourseLearningCase_BaseENS.WordCreateDate; //Word生成日期
objvCourseLearningCase_BaseENT.IsVisible = objvCourseLearningCase_BaseENS.IsVisible; //是否显示
objvCourseLearningCase_BaseENT.IsDualVideo = objvCourseLearningCase_BaseENS.IsDualVideo; //是否双视频
objvCourseLearningCase_BaseENT.IdXzCollege = objvCourseLearningCase_BaseENS.IdXzCollege; //学院流水号
objvCourseLearningCase_BaseENT.CollegeId = objvCourseLearningCase_BaseENS.CollegeId; //学院ID
objvCourseLearningCase_BaseENT.CollegeName = objvCourseLearningCase_BaseENS.CollegeName; //学院名称
objvCourseLearningCase_BaseENT.CollegeNameA = objvCourseLearningCase_BaseENS.CollegeNameA; //学院名称简写
objvCourseLearningCase_BaseENT.IdXzMajor = objvCourseLearningCase_BaseENS.IdXzMajor; //专业流水号
objvCourseLearningCase_BaseENT.MajorID = objvCourseLearningCase_BaseENS.MajorID; //专业ID
objvCourseLearningCase_BaseENT.MajorName = objvCourseLearningCase_BaseENS.MajorName; //专业名称
objvCourseLearningCase_BaseENT.CourseId = objvCourseLearningCase_BaseENS.CourseId; //课程Id
objvCourseLearningCase_BaseENT.CourseCode = objvCourseLearningCase_BaseENS.CourseCode; //课程代码
objvCourseLearningCase_BaseENT.CourseName = objvCourseLearningCase_BaseENS.CourseName; //课程名称
objvCourseLearningCase_BaseENT.CourseChapterId = objvCourseLearningCase_BaseENS.CourseChapterId; //课程章节ID
objvCourseLearningCase_BaseENT.CourseChapterName = objvCourseLearningCase_BaseENS.CourseChapterName; //课程章节名称
objvCourseLearningCase_BaseENT.ChapterId = objvCourseLearningCase_BaseENS.ChapterId; //章Id
objvCourseLearningCase_BaseENT.ParentNodeId = objvCourseLearningCase_BaseENS.ParentNodeId; //父节点编号
objvCourseLearningCase_BaseENT.CourseChapterReferred = objvCourseLearningCase_BaseENS.CourseChapterReferred; //节简称
objvCourseLearningCase_BaseENT.ChapterName = objvCourseLearningCase_BaseENS.ChapterName; //章名
objvCourseLearningCase_BaseENT.ChapterNameSim = objvCourseLearningCase_BaseENS.ChapterNameSim; //章名简称
objvCourseLearningCase_BaseENT.SectionName = objvCourseLearningCase_BaseENS.SectionName; //节名
objvCourseLearningCase_BaseENT.SectionNameSim = objvCourseLearningCase_BaseENS.SectionNameSim; //节名简称
objvCourseLearningCase_BaseENT.SectionId = objvCourseLearningCase_BaseENS.SectionId; //节Id
objvCourseLearningCase_BaseENT.ParentNodeReferred = objvCourseLearningCase_BaseENS.ParentNodeReferred; //章简称
objvCourseLearningCase_BaseENT.ParentNodeName = objvCourseLearningCase_BaseENS.ParentNodeName; //父节点名称
objvCourseLearningCase_BaseENT.ViewCount = objvCourseLearningCase_BaseENS.ViewCount; //浏览量
objvCourseLearningCase_BaseENT.IsShow = objvCourseLearningCase_BaseENS.IsShow; //是否启用
objvCourseLearningCase_BaseENT.DownloadNumber = objvCourseLearningCase_BaseENS.DownloadNumber; //下载数目
objvCourseLearningCase_BaseENT.FileIntegration = objvCourseLearningCase_BaseENS.FileIntegration; //文件积分
objvCourseLearningCase_BaseENT.LikeCount = objvCourseLearningCase_BaseENS.LikeCount; //资源喜欢数量
objvCourseLearningCase_BaseENT.CollectionCount = objvCourseLearningCase_BaseENS.CollectionCount; //收藏数量
objvCourseLearningCase_BaseENT.RecommendedDegreeId = objvCourseLearningCase_BaseENS.RecommendedDegreeId; //推荐度Id
objvCourseLearningCase_BaseENT.RecommendedDegreeName = objvCourseLearningCase_BaseENS.RecommendedDegreeName; //推荐度名称
objvCourseLearningCase_BaseENT.ftpFileType = objvCourseLearningCase_BaseENS.ftpFileType; //ftp文件类型
objvCourseLearningCase_BaseENT.VideoUrl = objvCourseLearningCase_BaseENS.VideoUrl; //视频Url
objvCourseLearningCase_BaseENT.VideoPath = objvCourseLearningCase_BaseENS.VideoPath; //视频目录
objvCourseLearningCase_BaseENT.ResErrMsg = objvCourseLearningCase_BaseENS.ResErrMsg; //资源错误信息
objvCourseLearningCase_BaseENT.Memo = objvCourseLearningCase_BaseENS.Memo; //备注
objvCourseLearningCase_BaseENT.BrowseCount4Case = objvCourseLearningCase_BaseENS.BrowseCount4Case; //课例浏览次数
objvCourseLearningCase_BaseENT.OwnerName = objvCourseLearningCase_BaseENS.OwnerName; //拥有者姓名
objvCourseLearningCase_BaseENT.OwnerNameWithId = objvCourseLearningCase_BaseENS.OwnerNameWithId; //拥有者名称附Id
objvCourseLearningCase_BaseENT.OrderNum = objvCourseLearningCase_BaseENS.OrderNum; //序号
objvCourseLearningCase_BaseENT.IsUse = objvCourseLearningCase_BaseENS.IsUse; //是否使用
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvCourseLearningCase_BaseEN objvCourseLearningCase_BaseEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvCourseLearningCase_BaseEN.IdCourseLearningCase, 8, convCourseLearningCase_Base.IdCourseLearningCase);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_BaseEN.CourseLearningCaseID, 8, convCourseLearningCase_Base.CourseLearningCaseID);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_BaseEN.CourseLearningCaseName, 100, convCourseLearningCase_Base.CourseLearningCaseName);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_BaseEN.CourseLearningCaseText, 8000, convCourseLearningCase_Base.CourseLearningCaseText);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_BaseEN.CourseLearningCaseTheme, 200, convCourseLearningCase_Base.CourseLearningCaseTheme);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_BaseEN.CourseLearningCaseDate, 8, convCourseLearningCase_Base.CourseLearningCaseDate);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_BaseEN.CourseLearningCaseTime, 6, convCourseLearningCase_Base.CourseLearningCaseTime);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_BaseEN.CourseLearningCaseDateIn, 8, convCourseLearningCase_Base.CourseLearningCaseDateIn);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_BaseEN.CourseLearningCaseTimeIn, 6, convCourseLearningCase_Base.CourseLearningCaseTimeIn);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_BaseEN.IdCaseType, 4, convCourseLearningCase_Base.IdCaseType);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_BaseEN.CaseTypeName, 50, convCourseLearningCase_Base.CaseTypeName);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_BaseEN.IdCourseLearningCaseType, 4, convCourseLearningCase_Base.IdCourseLearningCaseType);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_BaseEN.CourseLearningCaseTypeName, 30, convCourseLearningCase_Base.CourseLearningCaseTypeName);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_BaseEN.OwnerId, 20, convCourseLearningCase_Base.OwnerId);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_BaseEN.IdStudyLevel, 4, convCourseLearningCase_Base.IdStudyLevel);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_BaseEN.StudyLevelName, 50, convCourseLearningCase_Base.StudyLevelName);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_BaseEN.IdTeachingPlan, 8, convCourseLearningCase_Base.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_BaseEN.IdDiscipline, 4, convCourseLearningCase_Base.IdDiscipline);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_BaseEN.DisciplineID, 4, convCourseLearningCase_Base.DisciplineID);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_BaseEN.DisciplineName, 50, convCourseLearningCase_Base.DisciplineName);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_BaseEN.IdSenateGaugeVersion, 4, convCourseLearningCase_Base.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_BaseEN.senateGaugeVersionID, 4, convCourseLearningCase_Base.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_BaseEN.senateGaugeVersionName, 200, convCourseLearningCase_Base.senateGaugeVersionName);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_BaseEN.IdTeachSkill, 8, convCourseLearningCase_Base.IdTeachSkill);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_BaseEN.TeachSkillID, 8, convCourseLearningCase_Base.TeachSkillID);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_BaseEN.SkillTypeName, 50, convCourseLearningCase_Base.SkillTypeName);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_BaseEN.TeachSkillName, 50, convCourseLearningCase_Base.TeachSkillName);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_BaseEN.TeachSkillTheory, 8000, convCourseLearningCase_Base.TeachSkillTheory);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_BaseEN.TeachSkillOperMethod, 2000, convCourseLearningCase_Base.TeachSkillOperMethod);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_BaseEN.IdSkillType, 4, convCourseLearningCase_Base.IdSkillType);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_BaseEN.SkillTypeID, 4, convCourseLearningCase_Base.SkillTypeID);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_BaseEN.CaseLevelId, 2, convCourseLearningCase_Base.CaseLevelId);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_BaseEN.CaseLevelName, 30, convCourseLearningCase_Base.CaseLevelName);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_BaseEN.DocFile, 200, convCourseLearningCase_Base.DocFile);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_BaseEN.WordCreateDate, 14, convCourseLearningCase_Base.WordCreateDate);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_BaseEN.IdXzCollege, 4, convCourseLearningCase_Base.IdXzCollege);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_BaseEN.CollegeId, 4, convCourseLearningCase_Base.CollegeId);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_BaseEN.CollegeName, 100, convCourseLearningCase_Base.CollegeName);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_BaseEN.CollegeNameA, 12, convCourseLearningCase_Base.CollegeNameA);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_BaseEN.IdXzMajor, 8, convCourseLearningCase_Base.IdXzMajor);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_BaseEN.MajorID, 4, convCourseLearningCase_Base.MajorID);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_BaseEN.MajorName, 100, convCourseLearningCase_Base.MajorName);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_BaseEN.CourseId, 8, convCourseLearningCase_Base.CourseId);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_BaseEN.CourseCode, 20, convCourseLearningCase_Base.CourseCode);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_BaseEN.CourseName, 100, convCourseLearningCase_Base.CourseName);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_BaseEN.CourseChapterId, 8, convCourseLearningCase_Base.CourseChapterId);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_BaseEN.CourseChapterName, 100, convCourseLearningCase_Base.CourseChapterName);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_BaseEN.ChapterId, 8, convCourseLearningCase_Base.ChapterId);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_BaseEN.ParentNodeId, 8, convCourseLearningCase_Base.ParentNodeId);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_BaseEN.CourseChapterReferred, 10, convCourseLearningCase_Base.CourseChapterReferred);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_BaseEN.ChapterName, 100, convCourseLearningCase_Base.ChapterName);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_BaseEN.ChapterNameSim, 10, convCourseLearningCase_Base.ChapterNameSim);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_BaseEN.SectionName, 100, convCourseLearningCase_Base.SectionName);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_BaseEN.SectionNameSim, 10, convCourseLearningCase_Base.SectionNameSim);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_BaseEN.SectionId, 8, convCourseLearningCase_Base.SectionId);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_BaseEN.ParentNodeReferred, 10, convCourseLearningCase_Base.ParentNodeReferred);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_BaseEN.ParentNodeName, 100, convCourseLearningCase_Base.ParentNodeName);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_BaseEN.RecommendedDegreeId, 2, convCourseLearningCase_Base.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_BaseEN.RecommendedDegreeName, 30, convCourseLearningCase_Base.RecommendedDegreeName);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_BaseEN.ftpFileType, 30, convCourseLearningCase_Base.ftpFileType);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_BaseEN.VideoUrl, 1000, convCourseLearningCase_Base.VideoUrl);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_BaseEN.VideoPath, 1000, convCourseLearningCase_Base.VideoPath);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_BaseEN.ResErrMsg, 30, convCourseLearningCase_Base.ResErrMsg);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_BaseEN.Memo, 1000, convCourseLearningCase_Base.Memo);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_BaseEN.OwnerName, 30, convCourseLearningCase_Base.OwnerName);
clsCheckSql.CheckFieldLen(objvCourseLearningCase_BaseEN.OwnerNameWithId, 51, convCourseLearningCase_Base.OwnerNameWithId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_BaseEN.IdCourseLearningCase, convCourseLearningCase_Base.IdCourseLearningCase);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_BaseEN.CourseLearningCaseID, convCourseLearningCase_Base.CourseLearningCaseID);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_BaseEN.CourseLearningCaseName, convCourseLearningCase_Base.CourseLearningCaseName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_BaseEN.CourseLearningCaseText, convCourseLearningCase_Base.CourseLearningCaseText);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_BaseEN.CourseLearningCaseTheme, convCourseLearningCase_Base.CourseLearningCaseTheme);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_BaseEN.CourseLearningCaseDate, convCourseLearningCase_Base.CourseLearningCaseDate);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_BaseEN.CourseLearningCaseTime, convCourseLearningCase_Base.CourseLearningCaseTime);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_BaseEN.CourseLearningCaseDateIn, convCourseLearningCase_Base.CourseLearningCaseDateIn);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_BaseEN.CourseLearningCaseTimeIn, convCourseLearningCase_Base.CourseLearningCaseTimeIn);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_BaseEN.IdCaseType, convCourseLearningCase_Base.IdCaseType);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_BaseEN.CaseTypeName, convCourseLearningCase_Base.CaseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_BaseEN.IdCourseLearningCaseType, convCourseLearningCase_Base.IdCourseLearningCaseType);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_BaseEN.CourseLearningCaseTypeName, convCourseLearningCase_Base.CourseLearningCaseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_BaseEN.OwnerId, convCourseLearningCase_Base.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_BaseEN.IdStudyLevel, convCourseLearningCase_Base.IdStudyLevel);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_BaseEN.StudyLevelName, convCourseLearningCase_Base.StudyLevelName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_BaseEN.IdTeachingPlan, convCourseLearningCase_Base.IdTeachingPlan);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_BaseEN.IdDiscipline, convCourseLearningCase_Base.IdDiscipline);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_BaseEN.DisciplineID, convCourseLearningCase_Base.DisciplineID);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_BaseEN.DisciplineName, convCourseLearningCase_Base.DisciplineName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_BaseEN.IdSenateGaugeVersion, convCourseLearningCase_Base.IdSenateGaugeVersion);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_BaseEN.senateGaugeVersionID, convCourseLearningCase_Base.senateGaugeVersionID);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_BaseEN.senateGaugeVersionName, convCourseLearningCase_Base.senateGaugeVersionName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_BaseEN.IdTeachSkill, convCourseLearningCase_Base.IdTeachSkill);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_BaseEN.TeachSkillID, convCourseLearningCase_Base.TeachSkillID);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_BaseEN.SkillTypeName, convCourseLearningCase_Base.SkillTypeName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_BaseEN.TeachSkillName, convCourseLearningCase_Base.TeachSkillName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_BaseEN.TeachSkillTheory, convCourseLearningCase_Base.TeachSkillTheory);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_BaseEN.TeachSkillOperMethod, convCourseLearningCase_Base.TeachSkillOperMethod);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_BaseEN.IdSkillType, convCourseLearningCase_Base.IdSkillType);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_BaseEN.SkillTypeID, convCourseLearningCase_Base.SkillTypeID);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_BaseEN.CaseLevelId, convCourseLearningCase_Base.CaseLevelId);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_BaseEN.CaseLevelName, convCourseLearningCase_Base.CaseLevelName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_BaseEN.DocFile, convCourseLearningCase_Base.DocFile);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_BaseEN.WordCreateDate, convCourseLearningCase_Base.WordCreateDate);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_BaseEN.IdXzCollege, convCourseLearningCase_Base.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_BaseEN.CollegeId, convCourseLearningCase_Base.CollegeId);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_BaseEN.CollegeName, convCourseLearningCase_Base.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_BaseEN.CollegeNameA, convCourseLearningCase_Base.CollegeNameA);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_BaseEN.IdXzMajor, convCourseLearningCase_Base.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_BaseEN.MajorID, convCourseLearningCase_Base.MajorID);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_BaseEN.MajorName, convCourseLearningCase_Base.MajorName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_BaseEN.CourseId, convCourseLearningCase_Base.CourseId);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_BaseEN.CourseCode, convCourseLearningCase_Base.CourseCode);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_BaseEN.CourseName, convCourseLearningCase_Base.CourseName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_BaseEN.CourseChapterId, convCourseLearningCase_Base.CourseChapterId);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_BaseEN.CourseChapterName, convCourseLearningCase_Base.CourseChapterName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_BaseEN.ChapterId, convCourseLearningCase_Base.ChapterId);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_BaseEN.ParentNodeId, convCourseLearningCase_Base.ParentNodeId);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_BaseEN.CourseChapterReferred, convCourseLearningCase_Base.CourseChapterReferred);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_BaseEN.ChapterName, convCourseLearningCase_Base.ChapterName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_BaseEN.ChapterNameSim, convCourseLearningCase_Base.ChapterNameSim);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_BaseEN.SectionName, convCourseLearningCase_Base.SectionName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_BaseEN.SectionNameSim, convCourseLearningCase_Base.SectionNameSim);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_BaseEN.SectionId, convCourseLearningCase_Base.SectionId);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_BaseEN.ParentNodeReferred, convCourseLearningCase_Base.ParentNodeReferred);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_BaseEN.ParentNodeName, convCourseLearningCase_Base.ParentNodeName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_BaseEN.RecommendedDegreeId, convCourseLearningCase_Base.RecommendedDegreeId);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_BaseEN.RecommendedDegreeName, convCourseLearningCase_Base.RecommendedDegreeName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_BaseEN.ftpFileType, convCourseLearningCase_Base.ftpFileType);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_BaseEN.VideoUrl, convCourseLearningCase_Base.VideoUrl);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_BaseEN.VideoPath, convCourseLearningCase_Base.VideoPath);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_BaseEN.ResErrMsg, convCourseLearningCase_Base.ResErrMsg);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_BaseEN.Memo, convCourseLearningCase_Base.Memo);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_BaseEN.OwnerName, convCourseLearningCase_Base.OwnerName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase_BaseEN.OwnerNameWithId, convCourseLearningCase_Base.OwnerNameWithId);
//检查外键字段长度
 objvCourseLearningCase_BaseEN._IsCheckProperty = true;
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
string strSQL = "select IdCourseLearningCase, CourseLearningCaseName from vCourseLearningCase_Base ";
 clsSpecSQLforSql mySql = clsvCourseLearningCase_BaseDA.GetSpecSQLObj();
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
 objSQL = clsvCourseLearningCase_BaseDA.GetSpecSQLObj();
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
 objSQL = clsvCourseLearningCase_BaseDA.GetSpecSQLObj();
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
 objSQL = clsvCourseLearningCase_BaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCourseLearningCase_BaseEN._CurrTabName);
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
 objSQL = clsvCourseLearningCase_BaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCourseLearningCase_BaseEN._CurrTabName, strCondition);
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
 objSQL = clsvCourseLearningCase_BaseDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}