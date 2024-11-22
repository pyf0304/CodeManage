
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCourseLearningCase4AppDA
 表名:vCourseLearningCase4App(01120271)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:45:47
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
 /// v课程学习案例4App(vCourseLearningCase4App)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvCourseLearningCase4AppDA : clsCommBase4DA
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
 return clsvCourseLearningCase4AppEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvCourseLearningCase4AppEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCourseLearningCase4AppEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvCourseLearningCase4AppEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvCourseLearningCase4AppEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:vCourseLearningCase4App中,检查关键字,长度不正确!(clsvCourseLearningCase4AppDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdCourseLearningCase)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vCourseLearningCase4App中,关键字不能为空 或 null!(clsvCourseLearningCase4AppDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdCourseLearningCase);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvCourseLearningCase4AppDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvCourseLearningCase4AppDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCase4AppDA.GetSpecSQLObj();
strSQL = "Select * from vCourseLearningCase4App where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vCourseLearningCase4App(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvCourseLearningCase4AppDA: GetDataTable_vCourseLearningCase4App)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCase4AppDA.GetSpecSQLObj();
strSQL = "Select * from vCourseLearningCase4App where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvCourseLearningCase4AppDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCase4AppDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvCourseLearningCase4AppDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCase4AppDA.GetSpecSQLObj();
strSQL = "Select * from vCourseLearningCase4App where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvCourseLearningCase4AppDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCase4AppDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvCourseLearningCase4AppDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCase4AppDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCourseLearningCase4App where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCourseLearningCase4App where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvCourseLearningCase4AppDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCase4AppDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vCourseLearningCase4App where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvCourseLearningCase4AppDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCase4AppDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vCourseLearningCase4App.* from vCourseLearningCase4App Left Join {1} on {2} where {3} and vCourseLearningCase4App.IdCourseLearningCase not in (Select top {5} vCourseLearningCase4App.IdCourseLearningCase from vCourseLearningCase4App Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCourseLearningCase4App where {1} and IdCourseLearningCase not in (Select top {2} IdCourseLearningCase from vCourseLearningCase4App where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCourseLearningCase4App where {1} and IdCourseLearningCase not in (Select top {3} IdCourseLearningCase from vCourseLearningCase4App where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvCourseLearningCase4AppDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCase4AppDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vCourseLearningCase4App.* from vCourseLearningCase4App Left Join {1} on {2} where {3} and vCourseLearningCase4App.IdCourseLearningCase not in (Select top {5} vCourseLearningCase4App.IdCourseLearningCase from vCourseLearningCase4App Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCourseLearningCase4App where {1} and IdCourseLearningCase not in (Select top {2} IdCourseLearningCase from vCourseLearningCase4App where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCourseLearningCase4App where {1} and IdCourseLearningCase not in (Select top {3} IdCourseLearningCase from vCourseLearningCase4App where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvCourseLearningCase4AppEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvCourseLearningCase4AppDA:GetObjLst)", objException.Message));
}
List<clsvCourseLearningCase4AppEN> arrObjLst = new List<clsvCourseLearningCase4AppEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCase4AppDA.GetSpecSQLObj();
strSQL = "Select * from vCourseLearningCase4App where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCase4AppEN objvCourseLearningCase4AppEN = new clsvCourseLearningCase4AppEN();
try
{
objvCourseLearningCase4AppEN.IdCourseLearningCase = objRow[convCourseLearningCase4App.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCase4AppEN.CourseLearningCaseID = objRow[convCourseLearningCase4App.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCase4AppEN.CourseLearningCaseName = objRow[convCourseLearningCase4App.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCase4AppEN.IsDualVideo = TransNullToBool(objRow[convCourseLearningCase4App.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCase4AppEN.CourseId = objRow[convCourseLearningCase4App.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCase4AppEN.CourseCode = objRow[convCourseLearningCase4App.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCase4App.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCase4AppEN.CourseName = objRow[convCourseLearningCase4App.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCase4App.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCase4AppEN.CourseChapterId = objRow[convCourseLearningCase4App.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCase4AppEN.ChapterId = objRow[convCourseLearningCase4App.ChapterId] == DBNull.Value ? null : objRow[convCourseLearningCase4App.ChapterId].ToString().Trim(); //章Id
objvCourseLearningCase4AppEN.ChapterName = objRow[convCourseLearningCase4App.ChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase4App.ChapterName].ToString().Trim(); //章名
objvCourseLearningCase4AppEN.ChapterNameSim = objRow[convCourseLearningCase4App.ChapterNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase4App.ChapterNameSim].ToString().Trim(); //章名简称
objvCourseLearningCase4AppEN.SectionName = objRow[convCourseLearningCase4App.SectionName] == DBNull.Value ? null : objRow[convCourseLearningCase4App.SectionName].ToString().Trim(); //节名
objvCourseLearningCase4AppEN.SectionNameSim = objRow[convCourseLearningCase4App.SectionNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase4App.SectionNameSim].ToString().Trim(); //节名简称
objvCourseLearningCase4AppEN.SectionId = objRow[convCourseLearningCase4App.SectionId] == DBNull.Value ? null : objRow[convCourseLearningCase4App.SectionId].ToString().Trim(); //节Id
objvCourseLearningCase4AppEN.VideoUrl = objRow[convCourseLearningCase4App.VideoUrl] == DBNull.Value ? null : objRow[convCourseLearningCase4App.VideoUrl].ToString().Trim(); //视频Url
objvCourseLearningCase4AppEN.VideoPath = objRow[convCourseLearningCase4App.VideoPath] == DBNull.Value ? null : objRow[convCourseLearningCase4App.VideoPath].ToString().Trim(); //视频目录
objvCourseLearningCase4AppEN.UpdDate = objRow[convCourseLearningCase4App.UpdDate] == DBNull.Value ? null : objRow[convCourseLearningCase4App.UpdDate].ToString().Trim(); //修改日期
objvCourseLearningCase4AppEN.Memo = objRow[convCourseLearningCase4App.Memo] == DBNull.Value ? null : objRow[convCourseLearningCase4App.Memo].ToString().Trim(); //备注
objvCourseLearningCase4AppEN.BrowseCount4Case = objRow[convCourseLearningCase4App.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase4App.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningCase4AppEN.ImageUrl = objRow[convCourseLearningCase4App.ImageUrl] == DBNull.Value ? null : objRow[convCourseLearningCase4App.ImageUrl].ToString().Trim(); //ImageUrl
objvCourseLearningCase4AppEN.OrderNum = objRow[convCourseLearningCase4App.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase4App.OrderNum].ToString().Trim()); //序号
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCourseLearningCase4AppDA: GetObjLst)", objException.Message));
}
objvCourseLearningCase4AppEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCourseLearningCase4AppEN);
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
public List<clsvCourseLearningCase4AppEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvCourseLearningCase4AppDA:GetObjLstByTabName)", objException.Message));
}
List<clsvCourseLearningCase4AppEN> arrObjLst = new List<clsvCourseLearningCase4AppEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCase4AppDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCase4AppEN objvCourseLearningCase4AppEN = new clsvCourseLearningCase4AppEN();
try
{
objvCourseLearningCase4AppEN.IdCourseLearningCase = objRow[convCourseLearningCase4App.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCase4AppEN.CourseLearningCaseID = objRow[convCourseLearningCase4App.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCase4AppEN.CourseLearningCaseName = objRow[convCourseLearningCase4App.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCase4AppEN.IsDualVideo = TransNullToBool(objRow[convCourseLearningCase4App.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCase4AppEN.CourseId = objRow[convCourseLearningCase4App.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCase4AppEN.CourseCode = objRow[convCourseLearningCase4App.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCase4App.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCase4AppEN.CourseName = objRow[convCourseLearningCase4App.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCase4App.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCase4AppEN.CourseChapterId = objRow[convCourseLearningCase4App.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCase4AppEN.ChapterId = objRow[convCourseLearningCase4App.ChapterId] == DBNull.Value ? null : objRow[convCourseLearningCase4App.ChapterId].ToString().Trim(); //章Id
objvCourseLearningCase4AppEN.ChapterName = objRow[convCourseLearningCase4App.ChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase4App.ChapterName].ToString().Trim(); //章名
objvCourseLearningCase4AppEN.ChapterNameSim = objRow[convCourseLearningCase4App.ChapterNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase4App.ChapterNameSim].ToString().Trim(); //章名简称
objvCourseLearningCase4AppEN.SectionName = objRow[convCourseLearningCase4App.SectionName] == DBNull.Value ? null : objRow[convCourseLearningCase4App.SectionName].ToString().Trim(); //节名
objvCourseLearningCase4AppEN.SectionNameSim = objRow[convCourseLearningCase4App.SectionNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase4App.SectionNameSim].ToString().Trim(); //节名简称
objvCourseLearningCase4AppEN.SectionId = objRow[convCourseLearningCase4App.SectionId] == DBNull.Value ? null : objRow[convCourseLearningCase4App.SectionId].ToString().Trim(); //节Id
objvCourseLearningCase4AppEN.VideoUrl = objRow[convCourseLearningCase4App.VideoUrl] == DBNull.Value ? null : objRow[convCourseLearningCase4App.VideoUrl].ToString().Trim(); //视频Url
objvCourseLearningCase4AppEN.VideoPath = objRow[convCourseLearningCase4App.VideoPath] == DBNull.Value ? null : objRow[convCourseLearningCase4App.VideoPath].ToString().Trim(); //视频目录
objvCourseLearningCase4AppEN.UpdDate = objRow[convCourseLearningCase4App.UpdDate] == DBNull.Value ? null : objRow[convCourseLearningCase4App.UpdDate].ToString().Trim(); //修改日期
objvCourseLearningCase4AppEN.Memo = objRow[convCourseLearningCase4App.Memo] == DBNull.Value ? null : objRow[convCourseLearningCase4App.Memo].ToString().Trim(); //备注
objvCourseLearningCase4AppEN.BrowseCount4Case = objRow[convCourseLearningCase4App.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase4App.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningCase4AppEN.ImageUrl = objRow[convCourseLearningCase4App.ImageUrl] == DBNull.Value ? null : objRow[convCourseLearningCase4App.ImageUrl].ToString().Trim(); //ImageUrl
objvCourseLearningCase4AppEN.OrderNum = objRow[convCourseLearningCase4App.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase4App.OrderNum].ToString().Trim()); //序号
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCourseLearningCase4AppDA: GetObjLst)", objException.Message));
}
objvCourseLearningCase4AppEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCourseLearningCase4AppEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvCourseLearningCase4AppEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvCourseLearningCase4App(ref clsvCourseLearningCase4AppEN objvCourseLearningCase4AppEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCase4AppDA.GetSpecSQLObj();
strSQL = "Select * from vCourseLearningCase4App where IdCourseLearningCase = " + "'"+ objvCourseLearningCase4AppEN.IdCourseLearningCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvCourseLearningCase4AppEN.IdCourseLearningCase = objDT.Rows[0][convCourseLearningCase4App.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCase4AppEN.CourseLearningCaseID = objDT.Rows[0][convCourseLearningCase4App.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCase4AppEN.CourseLearningCaseName = objDT.Rows[0][convCourseLearningCase4App.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCourseLearningCase4AppEN.IsDualVideo = TransNullToBool(objDT.Rows[0][convCourseLearningCase4App.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvCourseLearningCase4AppEN.CourseId = objDT.Rows[0][convCourseLearningCase4App.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningCase4AppEN.CourseCode = objDT.Rows[0][convCourseLearningCase4App.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvCourseLearningCase4AppEN.CourseName = objDT.Rows[0][convCourseLearningCase4App.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvCourseLearningCase4AppEN.CourseChapterId = objDT.Rows[0][convCourseLearningCase4App.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCase4AppEN.ChapterId = objDT.Rows[0][convCourseLearningCase4App.ChapterId].ToString().Trim(); //章Id(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningCase4AppEN.ChapterName = objDT.Rows[0][convCourseLearningCase4App.ChapterName].ToString().Trim(); //章名(字段类型:varchar,字段长度:100,是否可空:True)
 objvCourseLearningCase4AppEN.ChapterNameSim = objDT.Rows[0][convCourseLearningCase4App.ChapterNameSim].ToString().Trim(); //章名简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvCourseLearningCase4AppEN.SectionName = objDT.Rows[0][convCourseLearningCase4App.SectionName].ToString().Trim(); //节名(字段类型:varchar,字段长度:100,是否可空:True)
 objvCourseLearningCase4AppEN.SectionNameSim = objDT.Rows[0][convCourseLearningCase4App.SectionNameSim].ToString().Trim(); //节名简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvCourseLearningCase4AppEN.SectionId = objDT.Rows[0][convCourseLearningCase4App.SectionId].ToString().Trim(); //节Id(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningCase4AppEN.VideoUrl = objDT.Rows[0][convCourseLearningCase4App.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCourseLearningCase4AppEN.VideoPath = objDT.Rows[0][convCourseLearningCase4App.VideoPath].ToString().Trim(); //视频目录(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCourseLearningCase4AppEN.UpdDate = objDT.Rows[0][convCourseLearningCase4App.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvCourseLearningCase4AppEN.Memo = objDT.Rows[0][convCourseLearningCase4App.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCourseLearningCase4AppEN.BrowseCount4Case = TransNullToInt(objDT.Rows[0][convCourseLearningCase4App.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvCourseLearningCase4AppEN.ImageUrl = objDT.Rows[0][convCourseLearningCase4App.ImageUrl].ToString().Trim(); //ImageUrl(字段类型:varchar,字段长度:100,是否可空:True)
 objvCourseLearningCase4AppEN.OrderNum = TransNullToInt(objDT.Rows[0][convCourseLearningCase4App.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvCourseLearningCase4AppDA: GetvCourseLearningCase4App)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdCourseLearningCase">表关键字</param>
 /// <returns>表对象</returns>
public clsvCourseLearningCase4AppEN GetObjByIdCourseLearningCase(string strIdCourseLearningCase)
{
CheckPrimaryKey(strIdCourseLearningCase);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCase4AppDA.GetSpecSQLObj();
strSQL = "Select * from vCourseLearningCase4App where IdCourseLearningCase = " + "'"+ strIdCourseLearningCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvCourseLearningCase4AppEN objvCourseLearningCase4AppEN = new clsvCourseLearningCase4AppEN();
try
{
 objvCourseLearningCase4AppEN.IdCourseLearningCase = objRow[convCourseLearningCase4App.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCase4AppEN.CourseLearningCaseID = objRow[convCourseLearningCase4App.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCase4AppEN.CourseLearningCaseName = objRow[convCourseLearningCase4App.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCourseLearningCase4AppEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase4App.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvCourseLearningCase4AppEN.CourseId = objRow[convCourseLearningCase4App.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningCase4AppEN.CourseCode = objRow[convCourseLearningCase4App.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCase4App.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvCourseLearningCase4AppEN.CourseName = objRow[convCourseLearningCase4App.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCase4App.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvCourseLearningCase4AppEN.CourseChapterId = objRow[convCourseLearningCase4App.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCase4AppEN.ChapterId = objRow[convCourseLearningCase4App.ChapterId] == DBNull.Value ? null : objRow[convCourseLearningCase4App.ChapterId].ToString().Trim(); //章Id(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningCase4AppEN.ChapterName = objRow[convCourseLearningCase4App.ChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase4App.ChapterName].ToString().Trim(); //章名(字段类型:varchar,字段长度:100,是否可空:True)
 objvCourseLearningCase4AppEN.ChapterNameSim = objRow[convCourseLearningCase4App.ChapterNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase4App.ChapterNameSim].ToString().Trim(); //章名简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvCourseLearningCase4AppEN.SectionName = objRow[convCourseLearningCase4App.SectionName] == DBNull.Value ? null : objRow[convCourseLearningCase4App.SectionName].ToString().Trim(); //节名(字段类型:varchar,字段长度:100,是否可空:True)
 objvCourseLearningCase4AppEN.SectionNameSim = objRow[convCourseLearningCase4App.SectionNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase4App.SectionNameSim].ToString().Trim(); //节名简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvCourseLearningCase4AppEN.SectionId = objRow[convCourseLearningCase4App.SectionId] == DBNull.Value ? null : objRow[convCourseLearningCase4App.SectionId].ToString().Trim(); //节Id(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningCase4AppEN.VideoUrl = objRow[convCourseLearningCase4App.VideoUrl] == DBNull.Value ? null : objRow[convCourseLearningCase4App.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCourseLearningCase4AppEN.VideoPath = objRow[convCourseLearningCase4App.VideoPath] == DBNull.Value ? null : objRow[convCourseLearningCase4App.VideoPath].ToString().Trim(); //视频目录(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCourseLearningCase4AppEN.UpdDate = objRow[convCourseLearningCase4App.UpdDate] == DBNull.Value ? null : objRow[convCourseLearningCase4App.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvCourseLearningCase4AppEN.Memo = objRow[convCourseLearningCase4App.Memo] == DBNull.Value ? null : objRow[convCourseLearningCase4App.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCourseLearningCase4AppEN.BrowseCount4Case = objRow[convCourseLearningCase4App.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase4App.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvCourseLearningCase4AppEN.ImageUrl = objRow[convCourseLearningCase4App.ImageUrl] == DBNull.Value ? null : objRow[convCourseLearningCase4App.ImageUrl].ToString().Trim(); //ImageUrl(字段类型:varchar,字段长度:100,是否可空:True)
 objvCourseLearningCase4AppEN.OrderNum = objRow[convCourseLearningCase4App.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase4App.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvCourseLearningCase4AppDA: GetObjByIdCourseLearningCase)", objException.Message));
}
return objvCourseLearningCase4AppEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvCourseLearningCase4AppEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvCourseLearningCase4AppDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCase4AppDA.GetSpecSQLObj();
strSQL = "Select * from vCourseLearningCase4App where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvCourseLearningCase4AppEN objvCourseLearningCase4AppEN = new clsvCourseLearningCase4AppEN()
{
IdCourseLearningCase = objRow[convCourseLearningCase4App.IdCourseLearningCase].ToString().Trim(), //课程学习案例流水号
CourseLearningCaseID = objRow[convCourseLearningCase4App.CourseLearningCaseID].ToString().Trim(), //课程学习案例ID
CourseLearningCaseName = objRow[convCourseLearningCase4App.CourseLearningCaseName].ToString().Trim(), //课程学习案例名称
IsDualVideo = TransNullToBool(objRow[convCourseLearningCase4App.IsDualVideo].ToString().Trim()), //是否双视频
CourseId = objRow[convCourseLearningCase4App.CourseId].ToString().Trim(), //课程Id
CourseCode = objRow[convCourseLearningCase4App.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCase4App.CourseCode].ToString().Trim(), //课程代码
CourseName = objRow[convCourseLearningCase4App.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCase4App.CourseName].ToString().Trim(), //课程名称
CourseChapterId = objRow[convCourseLearningCase4App.CourseChapterId].ToString().Trim(), //课程章节ID
ChapterId = objRow[convCourseLearningCase4App.ChapterId] == DBNull.Value ? null : objRow[convCourseLearningCase4App.ChapterId].ToString().Trim(), //章Id
ChapterName = objRow[convCourseLearningCase4App.ChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase4App.ChapterName].ToString().Trim(), //章名
ChapterNameSim = objRow[convCourseLearningCase4App.ChapterNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase4App.ChapterNameSim].ToString().Trim(), //章名简称
SectionName = objRow[convCourseLearningCase4App.SectionName] == DBNull.Value ? null : objRow[convCourseLearningCase4App.SectionName].ToString().Trim(), //节名
SectionNameSim = objRow[convCourseLearningCase4App.SectionNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase4App.SectionNameSim].ToString().Trim(), //节名简称
SectionId = objRow[convCourseLearningCase4App.SectionId] == DBNull.Value ? null : objRow[convCourseLearningCase4App.SectionId].ToString().Trim(), //节Id
VideoUrl = objRow[convCourseLearningCase4App.VideoUrl] == DBNull.Value ? null : objRow[convCourseLearningCase4App.VideoUrl].ToString().Trim(), //视频Url
VideoPath = objRow[convCourseLearningCase4App.VideoPath] == DBNull.Value ? null : objRow[convCourseLearningCase4App.VideoPath].ToString().Trim(), //视频目录
UpdDate = objRow[convCourseLearningCase4App.UpdDate] == DBNull.Value ? null : objRow[convCourseLearningCase4App.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[convCourseLearningCase4App.Memo] == DBNull.Value ? null : objRow[convCourseLearningCase4App.Memo].ToString().Trim(), //备注
BrowseCount4Case = objRow[convCourseLearningCase4App.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase4App.BrowseCount4Case].ToString().Trim()), //课例浏览次数
ImageUrl = objRow[convCourseLearningCase4App.ImageUrl] == DBNull.Value ? null : objRow[convCourseLearningCase4App.ImageUrl].ToString().Trim(), //ImageUrl
OrderNum = objRow[convCourseLearningCase4App.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase4App.OrderNum].ToString().Trim()) //序号
};
objvCourseLearningCase4AppEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCourseLearningCase4AppEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvCourseLearningCase4AppDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvCourseLearningCase4AppEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCourseLearningCase4AppEN objvCourseLearningCase4AppEN = new clsvCourseLearningCase4AppEN();
try
{
objvCourseLearningCase4AppEN.IdCourseLearningCase = objRow[convCourseLearningCase4App.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCase4AppEN.CourseLearningCaseID = objRow[convCourseLearningCase4App.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCase4AppEN.CourseLearningCaseName = objRow[convCourseLearningCase4App.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCase4AppEN.IsDualVideo = TransNullToBool(objRow[convCourseLearningCase4App.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCase4AppEN.CourseId = objRow[convCourseLearningCase4App.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCase4AppEN.CourseCode = objRow[convCourseLearningCase4App.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCase4App.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCase4AppEN.CourseName = objRow[convCourseLearningCase4App.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCase4App.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCase4AppEN.CourseChapterId = objRow[convCourseLearningCase4App.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCase4AppEN.ChapterId = objRow[convCourseLearningCase4App.ChapterId] == DBNull.Value ? null : objRow[convCourseLearningCase4App.ChapterId].ToString().Trim(); //章Id
objvCourseLearningCase4AppEN.ChapterName = objRow[convCourseLearningCase4App.ChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase4App.ChapterName].ToString().Trim(); //章名
objvCourseLearningCase4AppEN.ChapterNameSim = objRow[convCourseLearningCase4App.ChapterNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase4App.ChapterNameSim].ToString().Trim(); //章名简称
objvCourseLearningCase4AppEN.SectionName = objRow[convCourseLearningCase4App.SectionName] == DBNull.Value ? null : objRow[convCourseLearningCase4App.SectionName].ToString().Trim(); //节名
objvCourseLearningCase4AppEN.SectionNameSim = objRow[convCourseLearningCase4App.SectionNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase4App.SectionNameSim].ToString().Trim(); //节名简称
objvCourseLearningCase4AppEN.SectionId = objRow[convCourseLearningCase4App.SectionId] == DBNull.Value ? null : objRow[convCourseLearningCase4App.SectionId].ToString().Trim(); //节Id
objvCourseLearningCase4AppEN.VideoUrl = objRow[convCourseLearningCase4App.VideoUrl] == DBNull.Value ? null : objRow[convCourseLearningCase4App.VideoUrl].ToString().Trim(); //视频Url
objvCourseLearningCase4AppEN.VideoPath = objRow[convCourseLearningCase4App.VideoPath] == DBNull.Value ? null : objRow[convCourseLearningCase4App.VideoPath].ToString().Trim(); //视频目录
objvCourseLearningCase4AppEN.UpdDate = objRow[convCourseLearningCase4App.UpdDate] == DBNull.Value ? null : objRow[convCourseLearningCase4App.UpdDate].ToString().Trim(); //修改日期
objvCourseLearningCase4AppEN.Memo = objRow[convCourseLearningCase4App.Memo] == DBNull.Value ? null : objRow[convCourseLearningCase4App.Memo].ToString().Trim(); //备注
objvCourseLearningCase4AppEN.BrowseCount4Case = objRow[convCourseLearningCase4App.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase4App.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningCase4AppEN.ImageUrl = objRow[convCourseLearningCase4App.ImageUrl] == DBNull.Value ? null : objRow[convCourseLearningCase4App.ImageUrl].ToString().Trim(); //ImageUrl
objvCourseLearningCase4AppEN.OrderNum = objRow[convCourseLearningCase4App.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase4App.OrderNum].ToString().Trim()); //序号
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvCourseLearningCase4AppDA: GetObjByDataRowvCourseLearningCase4App)", objException.Message));
}
objvCourseLearningCase4AppEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCourseLearningCase4AppEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvCourseLearningCase4AppEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCourseLearningCase4AppEN objvCourseLearningCase4AppEN = new clsvCourseLearningCase4AppEN();
try
{
objvCourseLearningCase4AppEN.IdCourseLearningCase = objRow[convCourseLearningCase4App.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCase4AppEN.CourseLearningCaseID = objRow[convCourseLearningCase4App.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCase4AppEN.CourseLearningCaseName = objRow[convCourseLearningCase4App.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCase4AppEN.IsDualVideo = TransNullToBool(objRow[convCourseLearningCase4App.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCase4AppEN.CourseId = objRow[convCourseLearningCase4App.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCase4AppEN.CourseCode = objRow[convCourseLearningCase4App.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCase4App.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCase4AppEN.CourseName = objRow[convCourseLearningCase4App.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCase4App.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCase4AppEN.CourseChapterId = objRow[convCourseLearningCase4App.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCase4AppEN.ChapterId = objRow[convCourseLearningCase4App.ChapterId] == DBNull.Value ? null : objRow[convCourseLearningCase4App.ChapterId].ToString().Trim(); //章Id
objvCourseLearningCase4AppEN.ChapterName = objRow[convCourseLearningCase4App.ChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase4App.ChapterName].ToString().Trim(); //章名
objvCourseLearningCase4AppEN.ChapterNameSim = objRow[convCourseLearningCase4App.ChapterNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase4App.ChapterNameSim].ToString().Trim(); //章名简称
objvCourseLearningCase4AppEN.SectionName = objRow[convCourseLearningCase4App.SectionName] == DBNull.Value ? null : objRow[convCourseLearningCase4App.SectionName].ToString().Trim(); //节名
objvCourseLearningCase4AppEN.SectionNameSim = objRow[convCourseLearningCase4App.SectionNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase4App.SectionNameSim].ToString().Trim(); //节名简称
objvCourseLearningCase4AppEN.SectionId = objRow[convCourseLearningCase4App.SectionId] == DBNull.Value ? null : objRow[convCourseLearningCase4App.SectionId].ToString().Trim(); //节Id
objvCourseLearningCase4AppEN.VideoUrl = objRow[convCourseLearningCase4App.VideoUrl] == DBNull.Value ? null : objRow[convCourseLearningCase4App.VideoUrl].ToString().Trim(); //视频Url
objvCourseLearningCase4AppEN.VideoPath = objRow[convCourseLearningCase4App.VideoPath] == DBNull.Value ? null : objRow[convCourseLearningCase4App.VideoPath].ToString().Trim(); //视频目录
objvCourseLearningCase4AppEN.UpdDate = objRow[convCourseLearningCase4App.UpdDate] == DBNull.Value ? null : objRow[convCourseLearningCase4App.UpdDate].ToString().Trim(); //修改日期
objvCourseLearningCase4AppEN.Memo = objRow[convCourseLearningCase4App.Memo] == DBNull.Value ? null : objRow[convCourseLearningCase4App.Memo].ToString().Trim(); //备注
objvCourseLearningCase4AppEN.BrowseCount4Case = objRow[convCourseLearningCase4App.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase4App.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningCase4AppEN.ImageUrl = objRow[convCourseLearningCase4App.ImageUrl] == DBNull.Value ? null : objRow[convCourseLearningCase4App.ImageUrl].ToString().Trim(); //ImageUrl
objvCourseLearningCase4AppEN.OrderNum = objRow[convCourseLearningCase4App.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCase4App.OrderNum].ToString().Trim()); //序号
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvCourseLearningCase4AppDA: GetObjByDataRow)", objException.Message));
}
objvCourseLearningCase4AppEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCourseLearningCase4AppEN;
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
objSQL = clsvCourseLearningCase4AppDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCourseLearningCase4AppEN._CurrTabName, convCourseLearningCase4App.IdCourseLearningCase, 8, "");
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
objSQL = clsvCourseLearningCase4AppDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCourseLearningCase4AppEN._CurrTabName, convCourseLearningCase4App.IdCourseLearningCase, 8, strPrefix);
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
 objSQL = clsvCourseLearningCase4AppDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdCourseLearningCase from vCourseLearningCase4App where " + strCondition;
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
 objSQL = clsvCourseLearningCase4AppDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdCourseLearningCase from vCourseLearningCase4App where " + strCondition;
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
 objSQL = clsvCourseLearningCase4AppDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCourseLearningCase4App", "IdCourseLearningCase = " + "'"+ strIdCourseLearningCase+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvCourseLearningCase4AppDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCase4AppDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCourseLearningCase4App", strCondition))
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
objSQL = clsvCourseLearningCase4AppDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vCourseLearningCase4App");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvCourseLearningCase4AppENS">源对象</param>
 /// <param name = "objvCourseLearningCase4AppENT">目标对象</param>
public void CopyTo(clsvCourseLearningCase4AppEN objvCourseLearningCase4AppENS, clsvCourseLearningCase4AppEN objvCourseLearningCase4AppENT)
{
objvCourseLearningCase4AppENT.IdCourseLearningCase = objvCourseLearningCase4AppENS.IdCourseLearningCase; //课程学习案例流水号
objvCourseLearningCase4AppENT.CourseLearningCaseID = objvCourseLearningCase4AppENS.CourseLearningCaseID; //课程学习案例ID
objvCourseLearningCase4AppENT.CourseLearningCaseName = objvCourseLearningCase4AppENS.CourseLearningCaseName; //课程学习案例名称
objvCourseLearningCase4AppENT.IsDualVideo = objvCourseLearningCase4AppENS.IsDualVideo; //是否双视频
objvCourseLearningCase4AppENT.CourseId = objvCourseLearningCase4AppENS.CourseId; //课程Id
objvCourseLearningCase4AppENT.CourseCode = objvCourseLearningCase4AppENS.CourseCode; //课程代码
objvCourseLearningCase4AppENT.CourseName = objvCourseLearningCase4AppENS.CourseName; //课程名称
objvCourseLearningCase4AppENT.CourseChapterId = objvCourseLearningCase4AppENS.CourseChapterId; //课程章节ID
objvCourseLearningCase4AppENT.ChapterId = objvCourseLearningCase4AppENS.ChapterId; //章Id
objvCourseLearningCase4AppENT.ChapterName = objvCourseLearningCase4AppENS.ChapterName; //章名
objvCourseLearningCase4AppENT.ChapterNameSim = objvCourseLearningCase4AppENS.ChapterNameSim; //章名简称
objvCourseLearningCase4AppENT.SectionName = objvCourseLearningCase4AppENS.SectionName; //节名
objvCourseLearningCase4AppENT.SectionNameSim = objvCourseLearningCase4AppENS.SectionNameSim; //节名简称
objvCourseLearningCase4AppENT.SectionId = objvCourseLearningCase4AppENS.SectionId; //节Id
objvCourseLearningCase4AppENT.VideoUrl = objvCourseLearningCase4AppENS.VideoUrl; //视频Url
objvCourseLearningCase4AppENT.VideoPath = objvCourseLearningCase4AppENS.VideoPath; //视频目录
objvCourseLearningCase4AppENT.UpdDate = objvCourseLearningCase4AppENS.UpdDate; //修改日期
objvCourseLearningCase4AppENT.Memo = objvCourseLearningCase4AppENS.Memo; //备注
objvCourseLearningCase4AppENT.BrowseCount4Case = objvCourseLearningCase4AppENS.BrowseCount4Case; //课例浏览次数
objvCourseLearningCase4AppENT.ImageUrl = objvCourseLearningCase4AppENS.ImageUrl; //ImageUrl
objvCourseLearningCase4AppENT.OrderNum = objvCourseLearningCase4AppENS.OrderNum; //序号
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvCourseLearningCase4AppEN objvCourseLearningCase4AppEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvCourseLearningCase4AppEN.IdCourseLearningCase, 8, convCourseLearningCase4App.IdCourseLearningCase);
clsCheckSql.CheckFieldLen(objvCourseLearningCase4AppEN.CourseLearningCaseID, 8, convCourseLearningCase4App.CourseLearningCaseID);
clsCheckSql.CheckFieldLen(objvCourseLearningCase4AppEN.CourseLearningCaseName, 100, convCourseLearningCase4App.CourseLearningCaseName);
clsCheckSql.CheckFieldLen(objvCourseLearningCase4AppEN.CourseId, 8, convCourseLearningCase4App.CourseId);
clsCheckSql.CheckFieldLen(objvCourseLearningCase4AppEN.CourseCode, 20, convCourseLearningCase4App.CourseCode);
clsCheckSql.CheckFieldLen(objvCourseLearningCase4AppEN.CourseName, 100, convCourseLearningCase4App.CourseName);
clsCheckSql.CheckFieldLen(objvCourseLearningCase4AppEN.CourseChapterId, 8, convCourseLearningCase4App.CourseChapterId);
clsCheckSql.CheckFieldLen(objvCourseLearningCase4AppEN.ChapterId, 8, convCourseLearningCase4App.ChapterId);
clsCheckSql.CheckFieldLen(objvCourseLearningCase4AppEN.ChapterName, 100, convCourseLearningCase4App.ChapterName);
clsCheckSql.CheckFieldLen(objvCourseLearningCase4AppEN.ChapterNameSim, 10, convCourseLearningCase4App.ChapterNameSim);
clsCheckSql.CheckFieldLen(objvCourseLearningCase4AppEN.SectionName, 100, convCourseLearningCase4App.SectionName);
clsCheckSql.CheckFieldLen(objvCourseLearningCase4AppEN.SectionNameSim, 10, convCourseLearningCase4App.SectionNameSim);
clsCheckSql.CheckFieldLen(objvCourseLearningCase4AppEN.SectionId, 8, convCourseLearningCase4App.SectionId);
clsCheckSql.CheckFieldLen(objvCourseLearningCase4AppEN.VideoUrl, 1000, convCourseLearningCase4App.VideoUrl);
clsCheckSql.CheckFieldLen(objvCourseLearningCase4AppEN.VideoPath, 1000, convCourseLearningCase4App.VideoPath);
clsCheckSql.CheckFieldLen(objvCourseLearningCase4AppEN.UpdDate, 20, convCourseLearningCase4App.UpdDate);
clsCheckSql.CheckFieldLen(objvCourseLearningCase4AppEN.Memo, 1000, convCourseLearningCase4App.Memo);
clsCheckSql.CheckFieldLen(objvCourseLearningCase4AppEN.ImageUrl, 100, convCourseLearningCase4App.ImageUrl);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase4AppEN.IdCourseLearningCase, convCourseLearningCase4App.IdCourseLearningCase);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase4AppEN.CourseLearningCaseID, convCourseLearningCase4App.CourseLearningCaseID);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase4AppEN.CourseLearningCaseName, convCourseLearningCase4App.CourseLearningCaseName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase4AppEN.CourseId, convCourseLearningCase4App.CourseId);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase4AppEN.CourseCode, convCourseLearningCase4App.CourseCode);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase4AppEN.CourseName, convCourseLearningCase4App.CourseName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase4AppEN.CourseChapterId, convCourseLearningCase4App.CourseChapterId);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase4AppEN.ChapterId, convCourseLearningCase4App.ChapterId);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase4AppEN.ChapterName, convCourseLearningCase4App.ChapterName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase4AppEN.ChapterNameSim, convCourseLearningCase4App.ChapterNameSim);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase4AppEN.SectionName, convCourseLearningCase4App.SectionName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase4AppEN.SectionNameSim, convCourseLearningCase4App.SectionNameSim);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase4AppEN.SectionId, convCourseLearningCase4App.SectionId);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase4AppEN.VideoUrl, convCourseLearningCase4App.VideoUrl);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase4AppEN.VideoPath, convCourseLearningCase4App.VideoPath);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase4AppEN.UpdDate, convCourseLearningCase4App.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase4AppEN.Memo, convCourseLearningCase4App.Memo);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCase4AppEN.ImageUrl, convCourseLearningCase4App.ImageUrl);
//检查外键字段长度
 objvCourseLearningCase4AppEN._IsCheckProperty = true;
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
 objSQL = clsvCourseLearningCase4AppDA.GetSpecSQLObj();
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
 objSQL = clsvCourseLearningCase4AppDA.GetSpecSQLObj();
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
 objSQL = clsvCourseLearningCase4AppDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCourseLearningCase4AppEN._CurrTabName);
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
 objSQL = clsvCourseLearningCase4AppDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCourseLearningCase4AppEN._CurrTabName, strCondition);
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
 objSQL = clsvCourseLearningCase4AppDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}