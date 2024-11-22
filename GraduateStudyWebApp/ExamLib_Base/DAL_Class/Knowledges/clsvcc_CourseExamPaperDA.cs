
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_CourseExamPaperDA
 表名:vcc_CourseExamPaper(01120098)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:04:15
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关(Knowledges)
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
 /// v考卷(vcc_CourseExamPaper)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvcc_CourseExamPaperDA : clsCommBase4DA
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
 return clsvcc_CourseExamPaperEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvcc_CourseExamPaperEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvcc_CourseExamPaperEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvcc_CourseExamPaperEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvcc_CourseExamPaperEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strCourseExamPaperId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strCourseExamPaperId)
{
strCourseExamPaperId = strCourseExamPaperId.Replace("'", "''");
if (strCourseExamPaperId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vcc_CourseExamPaper中,检查关键字,长度不正确!(clsvcc_CourseExamPaperDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strCourseExamPaperId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vcc_CourseExamPaper中,关键字不能为空 或 null!(clsvcc_CourseExamPaperDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCourseExamPaperId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvcc_CourseExamPaperDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvcc_CourseExamPaperDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseExamPaperDA.GetSpecSQLObj();
strSQL = "Select * from vcc_CourseExamPaper where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vcc_CourseExamPaper(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvcc_CourseExamPaperDA: GetDataTable_vcc_CourseExamPaper)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseExamPaperDA.GetSpecSQLObj();
strSQL = "Select * from vcc_CourseExamPaper where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvcc_CourseExamPaperDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseExamPaperDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvcc_CourseExamPaperDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseExamPaperDA.GetSpecSQLObj();
strSQL = "Select * from vcc_CourseExamPaper where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvcc_CourseExamPaperDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseExamPaperDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvcc_CourseExamPaperDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseExamPaperDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vcc_CourseExamPaper where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vcc_CourseExamPaper where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvcc_CourseExamPaperDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseExamPaperDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vcc_CourseExamPaper where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvcc_CourseExamPaperDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseExamPaperDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vcc_CourseExamPaper.* from vcc_CourseExamPaper Left Join {1} on {2} where {3} and vcc_CourseExamPaper.CourseExamPaperId not in (Select top {5} vcc_CourseExamPaper.CourseExamPaperId from vcc_CourseExamPaper Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vcc_CourseExamPaper where {1} and CourseExamPaperId not in (Select top {2} CourseExamPaperId from vcc_CourseExamPaper where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vcc_CourseExamPaper where {1} and CourseExamPaperId not in (Select top {3} CourseExamPaperId from vcc_CourseExamPaper where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvcc_CourseExamPaperDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseExamPaperDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vcc_CourseExamPaper.* from vcc_CourseExamPaper Left Join {1} on {2} where {3} and vcc_CourseExamPaper.CourseExamPaperId not in (Select top {5} vcc_CourseExamPaper.CourseExamPaperId from vcc_CourseExamPaper Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vcc_CourseExamPaper where {1} and CourseExamPaperId not in (Select top {2} CourseExamPaperId from vcc_CourseExamPaper where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vcc_CourseExamPaper where {1} and CourseExamPaperId not in (Select top {3} CourseExamPaperId from vcc_CourseExamPaper where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvcc_CourseExamPaperEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvcc_CourseExamPaperDA:GetObjLst)", objException.Message));
}
List<clsvcc_CourseExamPaperEN> arrObjLst = new List<clsvcc_CourseExamPaperEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseExamPaperDA.GetSpecSQLObj();
strSQL = "Select * from vcc_CourseExamPaper where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN = new clsvcc_CourseExamPaperEN();
try
{
objvcc_CourseExamPaperEN.CourseExamPaperId = objRow[convcc_CourseExamPaper.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_CourseExamPaperEN.CourseId = objRow[convcc_CourseExamPaper.CourseId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CourseId].ToString().Trim(); //课程Id
objvcc_CourseExamPaperEN.CourseName = objRow[convcc_CourseExamPaper.CourseName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CourseName].ToString().Trim(); //课程名称
objvcc_CourseExamPaperEN.ExamPaperName = objRow[convcc_CourseExamPaper.ExamPaperName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_CourseExamPaperEN.PaperIndex = objRow[convcc_CourseExamPaper.PaperIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaper.PaperIndex].ToString().Trim()); //试卷序号
objvcc_CourseExamPaperEN.ExamPaperTypeId = objRow[convcc_CourseExamPaper.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objvcc_CourseExamPaperEN.ExamPaperTypeName = objRow[convcc_CourseExamPaper.ExamPaperTypeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ExamPaperTypeName].ToString().Trim(); //试卷类型名称
objvcc_CourseExamPaperEN.IsShow = TransNullToBool(objRow[convcc_CourseExamPaper.IsShow].ToString().Trim()); //是否启用
objvcc_CourseExamPaperEN.TotalScore = objRow[convcc_CourseExamPaper.TotalScore] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convcc_CourseExamPaper.TotalScore].ToString().Trim()); //总得分
objvcc_CourseExamPaperEN.ViewCount = objRow[convcc_CourseExamPaper.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaper.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseExamPaperEN.DoneNumber = objRow[convcc_CourseExamPaper.DoneNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaper.DoneNumber].ToString().Trim()); //已做人数
objvcc_CourseExamPaperEN.PaperTime = objRow[convcc_CourseExamPaper.PaperTime] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaper.PaperTime].ToString().Trim()); //考试时间（分钟）
objvcc_CourseExamPaperEN.DownloadNumber = objRow[convcc_CourseExamPaper.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaper.DownloadNumber].ToString().Trim()); //下载数目
objvcc_CourseExamPaperEN.CollectionCount = objRow[convcc_CourseExamPaper.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convcc_CourseExamPaper.CollectionCount].ToString().Trim()); //收藏数量
objvcc_CourseExamPaperEN.LikeCount = objRow[convcc_CourseExamPaper.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convcc_CourseExamPaper.LikeCount].ToString().Trim()); //资源喜欢数量
objvcc_CourseExamPaperEN.IdXzMajor = objRow[convcc_CourseExamPaper.IdXzMajor] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_CourseExamPaperEN.MajorName = objRow[convcc_CourseExamPaper.MajorName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.MajorName].ToString().Trim(); //专业名称
objvcc_CourseExamPaperEN.PaperDispModeId = objRow[convcc_CourseExamPaper.PaperDispModeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.PaperDispModeId].ToString().Trim(); //试卷显示模式Id
objvcc_CourseExamPaperEN.PaperDispModeName = objRow[convcc_CourseExamPaper.PaperDispModeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.PaperDispModeName].ToString().Trim(); //试卷显示模式名称
objvcc_CourseExamPaperEN.ExamCreateTime = objRow[convcc_CourseExamPaper.ExamCreateTime] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ExamCreateTime].ToString().Trim(); //考卷建立时间
objvcc_CourseExamPaperEN.CreateUserID = objRow[convcc_CourseExamPaper.CreateUserID] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CreateUserID].ToString().Trim(); //建立用户ID
objvcc_CourseExamPaperEN.UserName = objRow[convcc_CourseExamPaper.UserName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.UserName].ToString().Trim(); //用户名
objvcc_CourseExamPaperEN.IsOpenToAllStu = TransNullToBool(objRow[convcc_CourseExamPaper.IsOpenToAllStu].ToString().Trim()); //全校师生
objvcc_CourseExamPaperEN.IsOpenToSchool = TransNullToBool(objRow[convcc_CourseExamPaper.IsOpenToSchool].ToString().Trim()); //全校师生公开
objvcc_CourseExamPaperEN.IsOpenToSocial = TransNullToBool(objRow[convcc_CourseExamPaper.IsOpenToSocial].ToString().Trim()); //社会公众
objvcc_CourseExamPaperEN.CourseChapterId = objRow[convcc_CourseExamPaper.CourseChapterId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseExamPaperEN.CourseChapterName = objRow[convcc_CourseExamPaper.CourseChapterName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_CourseExamPaperEN.ChapterId = objRow[convcc_CourseExamPaper.ChapterId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ChapterId].ToString().Trim(); //章Id
objvcc_CourseExamPaperEN.SectionId = objRow[convcc_CourseExamPaper.SectionId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.SectionId].ToString().Trim(); //节Id
objvcc_CourseExamPaperEN.ChapterName = objRow[convcc_CourseExamPaper.ChapterName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ChapterName].ToString().Trim(); //章名
objvcc_CourseExamPaperEN.SectionName = objRow[convcc_CourseExamPaper.SectionName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.SectionName].ToString().Trim(); //节名
objvcc_CourseExamPaperEN.ChapterNameSim = objRow[convcc_CourseExamPaper.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_CourseExamPaperEN.SectionNameSim = objRow[convcc_CourseExamPaper.SectionNameSim] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.SectionNameSim].ToString().Trim(); //节名简称
objvcc_CourseExamPaperEN.IsAutoGeneQuestion = TransNullToBool(objRow[convcc_CourseExamPaper.IsAutoGeneQuestion].ToString().Trim()); //是否自动生成题目
objvcc_CourseExamPaperEN.IsCanMultiDo = TransNullToBool(objRow[convcc_CourseExamPaper.IsCanMultiDo].ToString().Trim()); //是否可以做多次
objvcc_CourseExamPaperEN.UpdDate = objRow[convcc_CourseExamPaper.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseExamPaperEN.UpdUserId = objRow[convcc_CourseExamPaper.UpdUserId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_CourseExamPaperEN.Memo = objRow[convcc_CourseExamPaper.Memo] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.Memo].ToString().Trim(); //备注
objvcc_CourseExamPaperEN.QuestionNum = objRow[convcc_CourseExamPaper.QuestionNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaper.QuestionNum].ToString().Trim()); //题目数
objvcc_CourseExamPaperEN.BigTopicNum = objRow[convcc_CourseExamPaper.BigTopicNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaper.BigTopicNum].ToString().Trim()); //大标题数
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvcc_CourseExamPaperDA: GetObjLst)", objException.Message));
}
objvcc_CourseExamPaperEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvcc_CourseExamPaperEN);
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
public List<clsvcc_CourseExamPaperEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvcc_CourseExamPaperDA:GetObjLstByTabName)", objException.Message));
}
List<clsvcc_CourseExamPaperEN> arrObjLst = new List<clsvcc_CourseExamPaperEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseExamPaperDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN = new clsvcc_CourseExamPaperEN();
try
{
objvcc_CourseExamPaperEN.CourseExamPaperId = objRow[convcc_CourseExamPaper.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_CourseExamPaperEN.CourseId = objRow[convcc_CourseExamPaper.CourseId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CourseId].ToString().Trim(); //课程Id
objvcc_CourseExamPaperEN.CourseName = objRow[convcc_CourseExamPaper.CourseName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CourseName].ToString().Trim(); //课程名称
objvcc_CourseExamPaperEN.ExamPaperName = objRow[convcc_CourseExamPaper.ExamPaperName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_CourseExamPaperEN.PaperIndex = objRow[convcc_CourseExamPaper.PaperIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaper.PaperIndex].ToString().Trim()); //试卷序号
objvcc_CourseExamPaperEN.ExamPaperTypeId = objRow[convcc_CourseExamPaper.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objvcc_CourseExamPaperEN.ExamPaperTypeName = objRow[convcc_CourseExamPaper.ExamPaperTypeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ExamPaperTypeName].ToString().Trim(); //试卷类型名称
objvcc_CourseExamPaperEN.IsShow = TransNullToBool(objRow[convcc_CourseExamPaper.IsShow].ToString().Trim()); //是否启用
objvcc_CourseExamPaperEN.TotalScore = objRow[convcc_CourseExamPaper.TotalScore] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convcc_CourseExamPaper.TotalScore].ToString().Trim()); //总得分
objvcc_CourseExamPaperEN.ViewCount = objRow[convcc_CourseExamPaper.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaper.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseExamPaperEN.DoneNumber = objRow[convcc_CourseExamPaper.DoneNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaper.DoneNumber].ToString().Trim()); //已做人数
objvcc_CourseExamPaperEN.PaperTime = objRow[convcc_CourseExamPaper.PaperTime] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaper.PaperTime].ToString().Trim()); //考试时间（分钟）
objvcc_CourseExamPaperEN.DownloadNumber = objRow[convcc_CourseExamPaper.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaper.DownloadNumber].ToString().Trim()); //下载数目
objvcc_CourseExamPaperEN.CollectionCount = objRow[convcc_CourseExamPaper.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convcc_CourseExamPaper.CollectionCount].ToString().Trim()); //收藏数量
objvcc_CourseExamPaperEN.LikeCount = objRow[convcc_CourseExamPaper.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convcc_CourseExamPaper.LikeCount].ToString().Trim()); //资源喜欢数量
objvcc_CourseExamPaperEN.IdXzMajor = objRow[convcc_CourseExamPaper.IdXzMajor] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_CourseExamPaperEN.MajorName = objRow[convcc_CourseExamPaper.MajorName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.MajorName].ToString().Trim(); //专业名称
objvcc_CourseExamPaperEN.PaperDispModeId = objRow[convcc_CourseExamPaper.PaperDispModeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.PaperDispModeId].ToString().Trim(); //试卷显示模式Id
objvcc_CourseExamPaperEN.PaperDispModeName = objRow[convcc_CourseExamPaper.PaperDispModeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.PaperDispModeName].ToString().Trim(); //试卷显示模式名称
objvcc_CourseExamPaperEN.ExamCreateTime = objRow[convcc_CourseExamPaper.ExamCreateTime] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ExamCreateTime].ToString().Trim(); //考卷建立时间
objvcc_CourseExamPaperEN.CreateUserID = objRow[convcc_CourseExamPaper.CreateUserID] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CreateUserID].ToString().Trim(); //建立用户ID
objvcc_CourseExamPaperEN.UserName = objRow[convcc_CourseExamPaper.UserName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.UserName].ToString().Trim(); //用户名
objvcc_CourseExamPaperEN.IsOpenToAllStu = TransNullToBool(objRow[convcc_CourseExamPaper.IsOpenToAllStu].ToString().Trim()); //全校师生
objvcc_CourseExamPaperEN.IsOpenToSchool = TransNullToBool(objRow[convcc_CourseExamPaper.IsOpenToSchool].ToString().Trim()); //全校师生公开
objvcc_CourseExamPaperEN.IsOpenToSocial = TransNullToBool(objRow[convcc_CourseExamPaper.IsOpenToSocial].ToString().Trim()); //社会公众
objvcc_CourseExamPaperEN.CourseChapterId = objRow[convcc_CourseExamPaper.CourseChapterId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseExamPaperEN.CourseChapterName = objRow[convcc_CourseExamPaper.CourseChapterName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_CourseExamPaperEN.ChapterId = objRow[convcc_CourseExamPaper.ChapterId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ChapterId].ToString().Trim(); //章Id
objvcc_CourseExamPaperEN.SectionId = objRow[convcc_CourseExamPaper.SectionId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.SectionId].ToString().Trim(); //节Id
objvcc_CourseExamPaperEN.ChapterName = objRow[convcc_CourseExamPaper.ChapterName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ChapterName].ToString().Trim(); //章名
objvcc_CourseExamPaperEN.SectionName = objRow[convcc_CourseExamPaper.SectionName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.SectionName].ToString().Trim(); //节名
objvcc_CourseExamPaperEN.ChapterNameSim = objRow[convcc_CourseExamPaper.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_CourseExamPaperEN.SectionNameSim = objRow[convcc_CourseExamPaper.SectionNameSim] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.SectionNameSim].ToString().Trim(); //节名简称
objvcc_CourseExamPaperEN.IsAutoGeneQuestion = TransNullToBool(objRow[convcc_CourseExamPaper.IsAutoGeneQuestion].ToString().Trim()); //是否自动生成题目
objvcc_CourseExamPaperEN.IsCanMultiDo = TransNullToBool(objRow[convcc_CourseExamPaper.IsCanMultiDo].ToString().Trim()); //是否可以做多次
objvcc_CourseExamPaperEN.UpdDate = objRow[convcc_CourseExamPaper.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseExamPaperEN.UpdUserId = objRow[convcc_CourseExamPaper.UpdUserId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_CourseExamPaperEN.Memo = objRow[convcc_CourseExamPaper.Memo] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.Memo].ToString().Trim(); //备注
objvcc_CourseExamPaperEN.QuestionNum = objRow[convcc_CourseExamPaper.QuestionNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaper.QuestionNum].ToString().Trim()); //题目数
objvcc_CourseExamPaperEN.BigTopicNum = objRow[convcc_CourseExamPaper.BigTopicNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaper.BigTopicNum].ToString().Trim()); //大标题数
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvcc_CourseExamPaperDA: GetObjLst)", objException.Message));
}
objvcc_CourseExamPaperEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvcc_CourseExamPaperEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getvcc_CourseExamPaper(ref clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseExamPaperDA.GetSpecSQLObj();
strSQL = "Select * from vcc_CourseExamPaper where CourseExamPaperId = " + "'"+ objvcc_CourseExamPaperEN.CourseExamPaperId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvcc_CourseExamPaperEN.CourseExamPaperId = objDT.Rows[0][convcc_CourseExamPaper.CourseExamPaperId].ToString().Trim(); //考卷流水号(字段类型:char,字段长度:8,是否可空:True)
 objvcc_CourseExamPaperEN.CourseId = objDT.Rows[0][convcc_CourseExamPaper.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvcc_CourseExamPaperEN.CourseName = objDT.Rows[0][convcc_CourseExamPaper.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_CourseExamPaperEN.ExamPaperName = objDT.Rows[0][convcc_CourseExamPaper.ExamPaperName].ToString().Trim(); //考卷名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvcc_CourseExamPaperEN.PaperIndex = TransNullToInt(objDT.Rows[0][convcc_CourseExamPaper.PaperIndex].ToString().Trim()); //试卷序号(字段类型:int,字段长度:4,是否可空:True)
 objvcc_CourseExamPaperEN.ExamPaperTypeId = objDT.Rows[0][convcc_CourseExamPaper.ExamPaperTypeId].ToString().Trim(); //试卷类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvcc_CourseExamPaperEN.ExamPaperTypeName = objDT.Rows[0][convcc_CourseExamPaper.ExamPaperTypeName].ToString().Trim(); //试卷类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvcc_CourseExamPaperEN.IsShow = TransNullToBool(objDT.Rows[0][convcc_CourseExamPaper.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_CourseExamPaperEN.TotalScore = TransNullToDouble(objDT.Rows[0][convcc_CourseExamPaper.TotalScore].ToString().Trim()); //总得分(字段类型:decimal,字段长度:10,是否可空:False)
 objvcc_CourseExamPaperEN.ViewCount = TransNullToInt(objDT.Rows[0][convcc_CourseExamPaper.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvcc_CourseExamPaperEN.DoneNumber = TransNullToInt(objDT.Rows[0][convcc_CourseExamPaper.DoneNumber].ToString().Trim()); //已做人数(字段类型:int,字段长度:4,是否可空:True)
 objvcc_CourseExamPaperEN.PaperTime = TransNullToInt(objDT.Rows[0][convcc_CourseExamPaper.PaperTime].ToString().Trim()); //考试时间（分钟）(字段类型:int,字段长度:4,是否可空:True)
 objvcc_CourseExamPaperEN.DownloadNumber = TransNullToInt(objDT.Rows[0][convcc_CourseExamPaper.DownloadNumber].ToString().Trim()); //下载数目(字段类型:int,字段长度:4,是否可空:True)
 objvcc_CourseExamPaperEN.CollectionCount = TransNullToInt(objDT.Rows[0][convcc_CourseExamPaper.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvcc_CourseExamPaperEN.LikeCount = TransNullToInt(objDT.Rows[0][convcc_CourseExamPaper.LikeCount].ToString().Trim()); //资源喜欢数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvcc_CourseExamPaperEN.IdXzMajor = objDT.Rows[0][convcc_CourseExamPaper.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvcc_CourseExamPaperEN.MajorName = objDT.Rows[0][convcc_CourseExamPaper.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvcc_CourseExamPaperEN.PaperDispModeId = objDT.Rows[0][convcc_CourseExamPaper.PaperDispModeId].ToString().Trim(); //试卷显示模式Id(字段类型:char,字段长度:4,是否可空:True)
 objvcc_CourseExamPaperEN.PaperDispModeName = objDT.Rows[0][convcc_CourseExamPaper.PaperDispModeName].ToString().Trim(); //试卷显示模式名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvcc_CourseExamPaperEN.ExamCreateTime = objDT.Rows[0][convcc_CourseExamPaper.ExamCreateTime].ToString().Trim(); //考卷建立时间(字段类型:varchar,字段长度:14,是否可空:True)
 objvcc_CourseExamPaperEN.CreateUserID = objDT.Rows[0][convcc_CourseExamPaper.CreateUserID].ToString().Trim(); //建立用户ID(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_CourseExamPaperEN.UserName = objDT.Rows[0][convcc_CourseExamPaper.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvcc_CourseExamPaperEN.IsOpenToAllStu = TransNullToBool(objDT.Rows[0][convcc_CourseExamPaper.IsOpenToAllStu].ToString().Trim()); //全校师生(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_CourseExamPaperEN.IsOpenToSchool = TransNullToBool(objDT.Rows[0][convcc_CourseExamPaper.IsOpenToSchool].ToString().Trim()); //全校师生公开(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_CourseExamPaperEN.IsOpenToSocial = TransNullToBool(objDT.Rows[0][convcc_CourseExamPaper.IsOpenToSocial].ToString().Trim()); //社会公众(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_CourseExamPaperEN.CourseChapterId = objDT.Rows[0][convcc_CourseExamPaper.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objvcc_CourseExamPaperEN.CourseChapterName = objDT.Rows[0][convcc_CourseExamPaper.CourseChapterName].ToString().Trim(); //课程章节名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvcc_CourseExamPaperEN.ChapterId = objDT.Rows[0][convcc_CourseExamPaper.ChapterId].ToString().Trim(); //章Id(字段类型:char,字段长度:8,是否可空:True)
 objvcc_CourseExamPaperEN.SectionId = objDT.Rows[0][convcc_CourseExamPaper.SectionId].ToString().Trim(); //节Id(字段类型:char,字段长度:8,是否可空:True)
 objvcc_CourseExamPaperEN.ChapterName = objDT.Rows[0][convcc_CourseExamPaper.ChapterName].ToString().Trim(); //章名(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_CourseExamPaperEN.SectionName = objDT.Rows[0][convcc_CourseExamPaper.SectionName].ToString().Trim(); //节名(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_CourseExamPaperEN.ChapterNameSim = objDT.Rows[0][convcc_CourseExamPaper.ChapterNameSim].ToString().Trim(); //章名简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_CourseExamPaperEN.SectionNameSim = objDT.Rows[0][convcc_CourseExamPaper.SectionNameSim].ToString().Trim(); //节名简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_CourseExamPaperEN.IsAutoGeneQuestion = TransNullToBool(objDT.Rows[0][convcc_CourseExamPaper.IsAutoGeneQuestion].ToString().Trim()); //是否自动生成题目(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_CourseExamPaperEN.IsCanMultiDo = TransNullToBool(objDT.Rows[0][convcc_CourseExamPaper.IsCanMultiDo].ToString().Trim()); //是否可以做多次(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_CourseExamPaperEN.UpdDate = objDT.Rows[0][convcc_CourseExamPaper.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_CourseExamPaperEN.UpdUserId = objDT.Rows[0][convcc_CourseExamPaper.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_CourseExamPaperEN.Memo = objDT.Rows[0][convcc_CourseExamPaper.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvcc_CourseExamPaperEN.QuestionNum = TransNullToInt(objDT.Rows[0][convcc_CourseExamPaper.QuestionNum].ToString().Trim()); //题目数(字段类型:int,字段长度:4,是否可空:True)
 objvcc_CourseExamPaperEN.BigTopicNum = TransNullToInt(objDT.Rows[0][convcc_CourseExamPaper.BigTopicNum].ToString().Trim()); //大标题数(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvcc_CourseExamPaperDA: Getvcc_CourseExamPaper)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strCourseExamPaperId">表关键字</param>
 /// <returns>表对象</returns>
public clsvcc_CourseExamPaperEN GetObjByCourseExamPaperId(string strCourseExamPaperId)
{
CheckPrimaryKey(strCourseExamPaperId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseExamPaperDA.GetSpecSQLObj();
strSQL = "Select * from vcc_CourseExamPaper where CourseExamPaperId = " + "'"+ strCourseExamPaperId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN = new clsvcc_CourseExamPaperEN();
try
{
 objvcc_CourseExamPaperEN.CourseExamPaperId = objRow[convcc_CourseExamPaper.CourseExamPaperId].ToString().Trim(); //考卷流水号(字段类型:char,字段长度:8,是否可空:True)
 objvcc_CourseExamPaperEN.CourseId = objRow[convcc_CourseExamPaper.CourseId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvcc_CourseExamPaperEN.CourseName = objRow[convcc_CourseExamPaper.CourseName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_CourseExamPaperEN.ExamPaperName = objRow[convcc_CourseExamPaper.ExamPaperName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ExamPaperName].ToString().Trim(); //考卷名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvcc_CourseExamPaperEN.PaperIndex = objRow[convcc_CourseExamPaper.PaperIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.PaperIndex].ToString().Trim()); //试卷序号(字段类型:int,字段长度:4,是否可空:True)
 objvcc_CourseExamPaperEN.ExamPaperTypeId = objRow[convcc_CourseExamPaper.ExamPaperTypeId].ToString().Trim(); //试卷类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvcc_CourseExamPaperEN.ExamPaperTypeName = objRow[convcc_CourseExamPaper.ExamPaperTypeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ExamPaperTypeName].ToString().Trim(); //试卷类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvcc_CourseExamPaperEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaper.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_CourseExamPaperEN.TotalScore = objRow[convcc_CourseExamPaper.TotalScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_CourseExamPaper.TotalScore].ToString().Trim()); //总得分(字段类型:decimal,字段长度:10,是否可空:False)
 objvcc_CourseExamPaperEN.ViewCount = objRow[convcc_CourseExamPaper.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvcc_CourseExamPaperEN.DoneNumber = objRow[convcc_CourseExamPaper.DoneNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.DoneNumber].ToString().Trim()); //已做人数(字段类型:int,字段长度:4,是否可空:True)
 objvcc_CourseExamPaperEN.PaperTime = objRow[convcc_CourseExamPaper.PaperTime] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.PaperTime].ToString().Trim()); //考试时间（分钟）(字段类型:int,字段长度:4,是否可空:True)
 objvcc_CourseExamPaperEN.DownloadNumber = objRow[convcc_CourseExamPaper.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.DownloadNumber].ToString().Trim()); //下载数目(字段类型:int,字段长度:4,是否可空:True)
 objvcc_CourseExamPaperEN.CollectionCount = objRow[convcc_CourseExamPaper.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvcc_CourseExamPaperEN.LikeCount = objRow[convcc_CourseExamPaper.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.LikeCount].ToString().Trim()); //资源喜欢数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvcc_CourseExamPaperEN.IdXzMajor = objRow[convcc_CourseExamPaper.IdXzMajor] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvcc_CourseExamPaperEN.MajorName = objRow[convcc_CourseExamPaper.MajorName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvcc_CourseExamPaperEN.PaperDispModeId = objRow[convcc_CourseExamPaper.PaperDispModeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.PaperDispModeId].ToString().Trim(); //试卷显示模式Id(字段类型:char,字段长度:4,是否可空:True)
 objvcc_CourseExamPaperEN.PaperDispModeName = objRow[convcc_CourseExamPaper.PaperDispModeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.PaperDispModeName].ToString().Trim(); //试卷显示模式名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvcc_CourseExamPaperEN.ExamCreateTime = objRow[convcc_CourseExamPaper.ExamCreateTime] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ExamCreateTime].ToString().Trim(); //考卷建立时间(字段类型:varchar,字段长度:14,是否可空:True)
 objvcc_CourseExamPaperEN.CreateUserID = objRow[convcc_CourseExamPaper.CreateUserID] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CreateUserID].ToString().Trim(); //建立用户ID(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_CourseExamPaperEN.UserName = objRow[convcc_CourseExamPaper.UserName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvcc_CourseExamPaperEN.IsOpenToAllStu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaper.IsOpenToAllStu].ToString().Trim()); //全校师生(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_CourseExamPaperEN.IsOpenToSchool = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaper.IsOpenToSchool].ToString().Trim()); //全校师生公开(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_CourseExamPaperEN.IsOpenToSocial = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaper.IsOpenToSocial].ToString().Trim()); //社会公众(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_CourseExamPaperEN.CourseChapterId = objRow[convcc_CourseExamPaper.CourseChapterId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objvcc_CourseExamPaperEN.CourseChapterName = objRow[convcc_CourseExamPaper.CourseChapterName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CourseChapterName].ToString().Trim(); //课程章节名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvcc_CourseExamPaperEN.ChapterId = objRow[convcc_CourseExamPaper.ChapterId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ChapterId].ToString().Trim(); //章Id(字段类型:char,字段长度:8,是否可空:True)
 objvcc_CourseExamPaperEN.SectionId = objRow[convcc_CourseExamPaper.SectionId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.SectionId].ToString().Trim(); //节Id(字段类型:char,字段长度:8,是否可空:True)
 objvcc_CourseExamPaperEN.ChapterName = objRow[convcc_CourseExamPaper.ChapterName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ChapterName].ToString().Trim(); //章名(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_CourseExamPaperEN.SectionName = objRow[convcc_CourseExamPaper.SectionName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.SectionName].ToString().Trim(); //节名(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_CourseExamPaperEN.ChapterNameSim = objRow[convcc_CourseExamPaper.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ChapterNameSim].ToString().Trim(); //章名简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_CourseExamPaperEN.SectionNameSim = objRow[convcc_CourseExamPaper.SectionNameSim] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.SectionNameSim].ToString().Trim(); //节名简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_CourseExamPaperEN.IsAutoGeneQuestion = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaper.IsAutoGeneQuestion].ToString().Trim()); //是否自动生成题目(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_CourseExamPaperEN.IsCanMultiDo = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaper.IsCanMultiDo].ToString().Trim()); //是否可以做多次(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_CourseExamPaperEN.UpdDate = objRow[convcc_CourseExamPaper.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_CourseExamPaperEN.UpdUserId = objRow[convcc_CourseExamPaper.UpdUserId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_CourseExamPaperEN.Memo = objRow[convcc_CourseExamPaper.Memo] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvcc_CourseExamPaperEN.QuestionNum = objRow[convcc_CourseExamPaper.QuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.QuestionNum].ToString().Trim()); //题目数(字段类型:int,字段长度:4,是否可空:True)
 objvcc_CourseExamPaperEN.BigTopicNum = objRow[convcc_CourseExamPaper.BigTopicNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.BigTopicNum].ToString().Trim()); //大标题数(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvcc_CourseExamPaperDA: GetObjByCourseExamPaperId)", objException.Message));
}
return objvcc_CourseExamPaperEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvcc_CourseExamPaperEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvcc_CourseExamPaperDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseExamPaperDA.GetSpecSQLObj();
strSQL = "Select * from vcc_CourseExamPaper where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN = new clsvcc_CourseExamPaperEN()
{
CourseExamPaperId = objRow[convcc_CourseExamPaper.CourseExamPaperId].ToString().Trim(), //考卷流水号
CourseId = objRow[convcc_CourseExamPaper.CourseId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CourseId].ToString().Trim(), //课程Id
CourseName = objRow[convcc_CourseExamPaper.CourseName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CourseName].ToString().Trim(), //课程名称
ExamPaperName = objRow[convcc_CourseExamPaper.ExamPaperName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ExamPaperName].ToString().Trim(), //考卷名称
PaperIndex = objRow[convcc_CourseExamPaper.PaperIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaper.PaperIndex].ToString().Trim()), //试卷序号
ExamPaperTypeId = objRow[convcc_CourseExamPaper.ExamPaperTypeId].ToString().Trim(), //试卷类型Id
ExamPaperTypeName = objRow[convcc_CourseExamPaper.ExamPaperTypeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ExamPaperTypeName].ToString().Trim(), //试卷类型名称
IsShow = TransNullToBool(objRow[convcc_CourseExamPaper.IsShow].ToString().Trim()), //是否启用
TotalScore = objRow[convcc_CourseExamPaper.TotalScore] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convcc_CourseExamPaper.TotalScore].ToString().Trim()), //总得分
ViewCount = objRow[convcc_CourseExamPaper.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaper.ViewCount].ToString().Trim()), //浏览量
DoneNumber = objRow[convcc_CourseExamPaper.DoneNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaper.DoneNumber].ToString().Trim()), //已做人数
PaperTime = objRow[convcc_CourseExamPaper.PaperTime] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaper.PaperTime].ToString().Trim()), //考试时间（分钟）
DownloadNumber = objRow[convcc_CourseExamPaper.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaper.DownloadNumber].ToString().Trim()), //下载数目
CollectionCount = objRow[convcc_CourseExamPaper.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convcc_CourseExamPaper.CollectionCount].ToString().Trim()), //收藏数量
LikeCount = objRow[convcc_CourseExamPaper.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convcc_CourseExamPaper.LikeCount].ToString().Trim()), //资源喜欢数量
IdXzMajor = objRow[convcc_CourseExamPaper.IdXzMajor] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.IdXzMajor].ToString().Trim(), //专业流水号
MajorName = objRow[convcc_CourseExamPaper.MajorName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.MajorName].ToString().Trim(), //专业名称
PaperDispModeId = objRow[convcc_CourseExamPaper.PaperDispModeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.PaperDispModeId].ToString().Trim(), //试卷显示模式Id
PaperDispModeName = objRow[convcc_CourseExamPaper.PaperDispModeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.PaperDispModeName].ToString().Trim(), //试卷显示模式名称
ExamCreateTime = objRow[convcc_CourseExamPaper.ExamCreateTime] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ExamCreateTime].ToString().Trim(), //考卷建立时间
CreateUserID = objRow[convcc_CourseExamPaper.CreateUserID] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CreateUserID].ToString().Trim(), //建立用户ID
UserName = objRow[convcc_CourseExamPaper.UserName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.UserName].ToString().Trim(), //用户名
IsOpenToAllStu = TransNullToBool(objRow[convcc_CourseExamPaper.IsOpenToAllStu].ToString().Trim()), //全校师生
IsOpenToSchool = TransNullToBool(objRow[convcc_CourseExamPaper.IsOpenToSchool].ToString().Trim()), //全校师生公开
IsOpenToSocial = TransNullToBool(objRow[convcc_CourseExamPaper.IsOpenToSocial].ToString().Trim()), //社会公众
CourseChapterId = objRow[convcc_CourseExamPaper.CourseChapterId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CourseChapterId].ToString().Trim(), //课程章节ID
CourseChapterName = objRow[convcc_CourseExamPaper.CourseChapterName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CourseChapterName].ToString().Trim(), //课程章节名称
ChapterId = objRow[convcc_CourseExamPaper.ChapterId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ChapterId].ToString().Trim(), //章Id
SectionId = objRow[convcc_CourseExamPaper.SectionId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.SectionId].ToString().Trim(), //节Id
ChapterName = objRow[convcc_CourseExamPaper.ChapterName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ChapterName].ToString().Trim(), //章名
SectionName = objRow[convcc_CourseExamPaper.SectionName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.SectionName].ToString().Trim(), //节名
ChapterNameSim = objRow[convcc_CourseExamPaper.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ChapterNameSim].ToString().Trim(), //章名简称
SectionNameSim = objRow[convcc_CourseExamPaper.SectionNameSim] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.SectionNameSim].ToString().Trim(), //节名简称
IsAutoGeneQuestion = TransNullToBool(objRow[convcc_CourseExamPaper.IsAutoGeneQuestion].ToString().Trim()), //是否自动生成题目
IsCanMultiDo = TransNullToBool(objRow[convcc_CourseExamPaper.IsCanMultiDo].ToString().Trim()), //是否可以做多次
UpdDate = objRow[convcc_CourseExamPaper.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[convcc_CourseExamPaper.UpdUserId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[convcc_CourseExamPaper.Memo] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.Memo].ToString().Trim(), //备注
QuestionNum = objRow[convcc_CourseExamPaper.QuestionNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaper.QuestionNum].ToString().Trim()), //题目数
BigTopicNum = objRow[convcc_CourseExamPaper.BigTopicNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaper.BigTopicNum].ToString().Trim()) //大标题数
};
objvcc_CourseExamPaperEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvcc_CourseExamPaperEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvcc_CourseExamPaperDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvcc_CourseExamPaperEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN = new clsvcc_CourseExamPaperEN();
try
{
objvcc_CourseExamPaperEN.CourseExamPaperId = objRow[convcc_CourseExamPaper.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_CourseExamPaperEN.CourseId = objRow[convcc_CourseExamPaper.CourseId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CourseId].ToString().Trim(); //课程Id
objvcc_CourseExamPaperEN.CourseName = objRow[convcc_CourseExamPaper.CourseName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CourseName].ToString().Trim(); //课程名称
objvcc_CourseExamPaperEN.ExamPaperName = objRow[convcc_CourseExamPaper.ExamPaperName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_CourseExamPaperEN.PaperIndex = objRow[convcc_CourseExamPaper.PaperIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaper.PaperIndex].ToString().Trim()); //试卷序号
objvcc_CourseExamPaperEN.ExamPaperTypeId = objRow[convcc_CourseExamPaper.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objvcc_CourseExamPaperEN.ExamPaperTypeName = objRow[convcc_CourseExamPaper.ExamPaperTypeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ExamPaperTypeName].ToString().Trim(); //试卷类型名称
objvcc_CourseExamPaperEN.IsShow = TransNullToBool(objRow[convcc_CourseExamPaper.IsShow].ToString().Trim()); //是否启用
objvcc_CourseExamPaperEN.TotalScore = objRow[convcc_CourseExamPaper.TotalScore] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convcc_CourseExamPaper.TotalScore].ToString().Trim()); //总得分
objvcc_CourseExamPaperEN.ViewCount = objRow[convcc_CourseExamPaper.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaper.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseExamPaperEN.DoneNumber = objRow[convcc_CourseExamPaper.DoneNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaper.DoneNumber].ToString().Trim()); //已做人数
objvcc_CourseExamPaperEN.PaperTime = objRow[convcc_CourseExamPaper.PaperTime] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaper.PaperTime].ToString().Trim()); //考试时间（分钟）
objvcc_CourseExamPaperEN.DownloadNumber = objRow[convcc_CourseExamPaper.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaper.DownloadNumber].ToString().Trim()); //下载数目
objvcc_CourseExamPaperEN.CollectionCount = objRow[convcc_CourseExamPaper.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convcc_CourseExamPaper.CollectionCount].ToString().Trim()); //收藏数量
objvcc_CourseExamPaperEN.LikeCount = objRow[convcc_CourseExamPaper.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convcc_CourseExamPaper.LikeCount].ToString().Trim()); //资源喜欢数量
objvcc_CourseExamPaperEN.IdXzMajor = objRow[convcc_CourseExamPaper.IdXzMajor] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_CourseExamPaperEN.MajorName = objRow[convcc_CourseExamPaper.MajorName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.MajorName].ToString().Trim(); //专业名称
objvcc_CourseExamPaperEN.PaperDispModeId = objRow[convcc_CourseExamPaper.PaperDispModeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.PaperDispModeId].ToString().Trim(); //试卷显示模式Id
objvcc_CourseExamPaperEN.PaperDispModeName = objRow[convcc_CourseExamPaper.PaperDispModeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.PaperDispModeName].ToString().Trim(); //试卷显示模式名称
objvcc_CourseExamPaperEN.ExamCreateTime = objRow[convcc_CourseExamPaper.ExamCreateTime] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ExamCreateTime].ToString().Trim(); //考卷建立时间
objvcc_CourseExamPaperEN.CreateUserID = objRow[convcc_CourseExamPaper.CreateUserID] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CreateUserID].ToString().Trim(); //建立用户ID
objvcc_CourseExamPaperEN.UserName = objRow[convcc_CourseExamPaper.UserName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.UserName].ToString().Trim(); //用户名
objvcc_CourseExamPaperEN.IsOpenToAllStu = TransNullToBool(objRow[convcc_CourseExamPaper.IsOpenToAllStu].ToString().Trim()); //全校师生
objvcc_CourseExamPaperEN.IsOpenToSchool = TransNullToBool(objRow[convcc_CourseExamPaper.IsOpenToSchool].ToString().Trim()); //全校师生公开
objvcc_CourseExamPaperEN.IsOpenToSocial = TransNullToBool(objRow[convcc_CourseExamPaper.IsOpenToSocial].ToString().Trim()); //社会公众
objvcc_CourseExamPaperEN.CourseChapterId = objRow[convcc_CourseExamPaper.CourseChapterId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseExamPaperEN.CourseChapterName = objRow[convcc_CourseExamPaper.CourseChapterName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_CourseExamPaperEN.ChapterId = objRow[convcc_CourseExamPaper.ChapterId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ChapterId].ToString().Trim(); //章Id
objvcc_CourseExamPaperEN.SectionId = objRow[convcc_CourseExamPaper.SectionId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.SectionId].ToString().Trim(); //节Id
objvcc_CourseExamPaperEN.ChapterName = objRow[convcc_CourseExamPaper.ChapterName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ChapterName].ToString().Trim(); //章名
objvcc_CourseExamPaperEN.SectionName = objRow[convcc_CourseExamPaper.SectionName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.SectionName].ToString().Trim(); //节名
objvcc_CourseExamPaperEN.ChapterNameSim = objRow[convcc_CourseExamPaper.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_CourseExamPaperEN.SectionNameSim = objRow[convcc_CourseExamPaper.SectionNameSim] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.SectionNameSim].ToString().Trim(); //节名简称
objvcc_CourseExamPaperEN.IsAutoGeneQuestion = TransNullToBool(objRow[convcc_CourseExamPaper.IsAutoGeneQuestion].ToString().Trim()); //是否自动生成题目
objvcc_CourseExamPaperEN.IsCanMultiDo = TransNullToBool(objRow[convcc_CourseExamPaper.IsCanMultiDo].ToString().Trim()); //是否可以做多次
objvcc_CourseExamPaperEN.UpdDate = objRow[convcc_CourseExamPaper.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseExamPaperEN.UpdUserId = objRow[convcc_CourseExamPaper.UpdUserId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_CourseExamPaperEN.Memo = objRow[convcc_CourseExamPaper.Memo] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.Memo].ToString().Trim(); //备注
objvcc_CourseExamPaperEN.QuestionNum = objRow[convcc_CourseExamPaper.QuestionNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaper.QuestionNum].ToString().Trim()); //题目数
objvcc_CourseExamPaperEN.BigTopicNum = objRow[convcc_CourseExamPaper.BigTopicNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaper.BigTopicNum].ToString().Trim()); //大标题数
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvcc_CourseExamPaperDA: GetObjByDataRowvcc_CourseExamPaper)", objException.Message));
}
objvcc_CourseExamPaperEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvcc_CourseExamPaperEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvcc_CourseExamPaperEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN = new clsvcc_CourseExamPaperEN();
try
{
objvcc_CourseExamPaperEN.CourseExamPaperId = objRow[convcc_CourseExamPaper.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_CourseExamPaperEN.CourseId = objRow[convcc_CourseExamPaper.CourseId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CourseId].ToString().Trim(); //课程Id
objvcc_CourseExamPaperEN.CourseName = objRow[convcc_CourseExamPaper.CourseName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CourseName].ToString().Trim(); //课程名称
objvcc_CourseExamPaperEN.ExamPaperName = objRow[convcc_CourseExamPaper.ExamPaperName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_CourseExamPaperEN.PaperIndex = objRow[convcc_CourseExamPaper.PaperIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaper.PaperIndex].ToString().Trim()); //试卷序号
objvcc_CourseExamPaperEN.ExamPaperTypeId = objRow[convcc_CourseExamPaper.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objvcc_CourseExamPaperEN.ExamPaperTypeName = objRow[convcc_CourseExamPaper.ExamPaperTypeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ExamPaperTypeName].ToString().Trim(); //试卷类型名称
objvcc_CourseExamPaperEN.IsShow = TransNullToBool(objRow[convcc_CourseExamPaper.IsShow].ToString().Trim()); //是否启用
objvcc_CourseExamPaperEN.TotalScore = objRow[convcc_CourseExamPaper.TotalScore] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convcc_CourseExamPaper.TotalScore].ToString().Trim()); //总得分
objvcc_CourseExamPaperEN.ViewCount = objRow[convcc_CourseExamPaper.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaper.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseExamPaperEN.DoneNumber = objRow[convcc_CourseExamPaper.DoneNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaper.DoneNumber].ToString().Trim()); //已做人数
objvcc_CourseExamPaperEN.PaperTime = objRow[convcc_CourseExamPaper.PaperTime] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaper.PaperTime].ToString().Trim()); //考试时间（分钟）
objvcc_CourseExamPaperEN.DownloadNumber = objRow[convcc_CourseExamPaper.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaper.DownloadNumber].ToString().Trim()); //下载数目
objvcc_CourseExamPaperEN.CollectionCount = objRow[convcc_CourseExamPaper.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convcc_CourseExamPaper.CollectionCount].ToString().Trim()); //收藏数量
objvcc_CourseExamPaperEN.LikeCount = objRow[convcc_CourseExamPaper.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convcc_CourseExamPaper.LikeCount].ToString().Trim()); //资源喜欢数量
objvcc_CourseExamPaperEN.IdXzMajor = objRow[convcc_CourseExamPaper.IdXzMajor] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_CourseExamPaperEN.MajorName = objRow[convcc_CourseExamPaper.MajorName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.MajorName].ToString().Trim(); //专业名称
objvcc_CourseExamPaperEN.PaperDispModeId = objRow[convcc_CourseExamPaper.PaperDispModeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.PaperDispModeId].ToString().Trim(); //试卷显示模式Id
objvcc_CourseExamPaperEN.PaperDispModeName = objRow[convcc_CourseExamPaper.PaperDispModeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.PaperDispModeName].ToString().Trim(); //试卷显示模式名称
objvcc_CourseExamPaperEN.ExamCreateTime = objRow[convcc_CourseExamPaper.ExamCreateTime] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ExamCreateTime].ToString().Trim(); //考卷建立时间
objvcc_CourseExamPaperEN.CreateUserID = objRow[convcc_CourseExamPaper.CreateUserID] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CreateUserID].ToString().Trim(); //建立用户ID
objvcc_CourseExamPaperEN.UserName = objRow[convcc_CourseExamPaper.UserName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.UserName].ToString().Trim(); //用户名
objvcc_CourseExamPaperEN.IsOpenToAllStu = TransNullToBool(objRow[convcc_CourseExamPaper.IsOpenToAllStu].ToString().Trim()); //全校师生
objvcc_CourseExamPaperEN.IsOpenToSchool = TransNullToBool(objRow[convcc_CourseExamPaper.IsOpenToSchool].ToString().Trim()); //全校师生公开
objvcc_CourseExamPaperEN.IsOpenToSocial = TransNullToBool(objRow[convcc_CourseExamPaper.IsOpenToSocial].ToString().Trim()); //社会公众
objvcc_CourseExamPaperEN.CourseChapterId = objRow[convcc_CourseExamPaper.CourseChapterId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseExamPaperEN.CourseChapterName = objRow[convcc_CourseExamPaper.CourseChapterName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_CourseExamPaperEN.ChapterId = objRow[convcc_CourseExamPaper.ChapterId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ChapterId].ToString().Trim(); //章Id
objvcc_CourseExamPaperEN.SectionId = objRow[convcc_CourseExamPaper.SectionId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.SectionId].ToString().Trim(); //节Id
objvcc_CourseExamPaperEN.ChapterName = objRow[convcc_CourseExamPaper.ChapterName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ChapterName].ToString().Trim(); //章名
objvcc_CourseExamPaperEN.SectionName = objRow[convcc_CourseExamPaper.SectionName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.SectionName].ToString().Trim(); //节名
objvcc_CourseExamPaperEN.ChapterNameSim = objRow[convcc_CourseExamPaper.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_CourseExamPaperEN.SectionNameSim = objRow[convcc_CourseExamPaper.SectionNameSim] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.SectionNameSim].ToString().Trim(); //节名简称
objvcc_CourseExamPaperEN.IsAutoGeneQuestion = TransNullToBool(objRow[convcc_CourseExamPaper.IsAutoGeneQuestion].ToString().Trim()); //是否自动生成题目
objvcc_CourseExamPaperEN.IsCanMultiDo = TransNullToBool(objRow[convcc_CourseExamPaper.IsCanMultiDo].ToString().Trim()); //是否可以做多次
objvcc_CourseExamPaperEN.UpdDate = objRow[convcc_CourseExamPaper.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseExamPaperEN.UpdUserId = objRow[convcc_CourseExamPaper.UpdUserId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_CourseExamPaperEN.Memo = objRow[convcc_CourseExamPaper.Memo] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.Memo].ToString().Trim(); //备注
objvcc_CourseExamPaperEN.QuestionNum = objRow[convcc_CourseExamPaper.QuestionNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaper.QuestionNum].ToString().Trim()); //题目数
objvcc_CourseExamPaperEN.BigTopicNum = objRow[convcc_CourseExamPaper.BigTopicNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaper.BigTopicNum].ToString().Trim()); //大标题数
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvcc_CourseExamPaperDA: GetObjByDataRow)", objException.Message));
}
objvcc_CourseExamPaperEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvcc_CourseExamPaperEN;
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
objSQL = clsvcc_CourseExamPaperDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvcc_CourseExamPaperEN._CurrTabName, convcc_CourseExamPaper.CourseExamPaperId, 8, "");
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
objSQL = clsvcc_CourseExamPaperDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvcc_CourseExamPaperEN._CurrTabName, convcc_CourseExamPaper.CourseExamPaperId, 8, strPrefix);
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
 objSQL = clsvcc_CourseExamPaperDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select CourseExamPaperId from vcc_CourseExamPaper where " + strCondition;
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
 objSQL = clsvcc_CourseExamPaperDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select CourseExamPaperId from vcc_CourseExamPaper where " + strCondition;
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
 /// <param name = "strCourseExamPaperId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strCourseExamPaperId)
{
CheckPrimaryKey(strCourseExamPaperId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseExamPaperDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vcc_CourseExamPaper", "CourseExamPaperId = " + "'"+ strCourseExamPaperId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvcc_CourseExamPaperDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseExamPaperDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vcc_CourseExamPaper", strCondition))
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
objSQL = clsvcc_CourseExamPaperDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vcc_CourseExamPaper");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperENS">源对象</param>
 /// <param name = "objvcc_CourseExamPaperENT">目标对象</param>
public void CopyTo(clsvcc_CourseExamPaperEN objvcc_CourseExamPaperENS, clsvcc_CourseExamPaperEN objvcc_CourseExamPaperENT)
{
objvcc_CourseExamPaperENT.CourseExamPaperId = objvcc_CourseExamPaperENS.CourseExamPaperId; //考卷流水号
objvcc_CourseExamPaperENT.CourseId = objvcc_CourseExamPaperENS.CourseId; //课程Id
objvcc_CourseExamPaperENT.CourseName = objvcc_CourseExamPaperENS.CourseName; //课程名称
objvcc_CourseExamPaperENT.ExamPaperName = objvcc_CourseExamPaperENS.ExamPaperName; //考卷名称
objvcc_CourseExamPaperENT.PaperIndex = objvcc_CourseExamPaperENS.PaperIndex; //试卷序号
objvcc_CourseExamPaperENT.ExamPaperTypeId = objvcc_CourseExamPaperENS.ExamPaperTypeId; //试卷类型Id
objvcc_CourseExamPaperENT.ExamPaperTypeName = objvcc_CourseExamPaperENS.ExamPaperTypeName; //试卷类型名称
objvcc_CourseExamPaperENT.IsShow = objvcc_CourseExamPaperENS.IsShow; //是否启用
objvcc_CourseExamPaperENT.TotalScore = objvcc_CourseExamPaperENS.TotalScore; //总得分
objvcc_CourseExamPaperENT.ViewCount = objvcc_CourseExamPaperENS.ViewCount; //浏览量
objvcc_CourseExamPaperENT.DoneNumber = objvcc_CourseExamPaperENS.DoneNumber; //已做人数
objvcc_CourseExamPaperENT.PaperTime = objvcc_CourseExamPaperENS.PaperTime; //考试时间（分钟）
objvcc_CourseExamPaperENT.DownloadNumber = objvcc_CourseExamPaperENS.DownloadNumber; //下载数目
objvcc_CourseExamPaperENT.CollectionCount = objvcc_CourseExamPaperENS.CollectionCount; //收藏数量
objvcc_CourseExamPaperENT.LikeCount = objvcc_CourseExamPaperENS.LikeCount; //资源喜欢数量
objvcc_CourseExamPaperENT.IdXzMajor = objvcc_CourseExamPaperENS.IdXzMajor; //专业流水号
objvcc_CourseExamPaperENT.MajorName = objvcc_CourseExamPaperENS.MajorName; //专业名称
objvcc_CourseExamPaperENT.PaperDispModeId = objvcc_CourseExamPaperENS.PaperDispModeId; //试卷显示模式Id
objvcc_CourseExamPaperENT.PaperDispModeName = objvcc_CourseExamPaperENS.PaperDispModeName; //试卷显示模式名称
objvcc_CourseExamPaperENT.ExamCreateTime = objvcc_CourseExamPaperENS.ExamCreateTime; //考卷建立时间
objvcc_CourseExamPaperENT.CreateUserID = objvcc_CourseExamPaperENS.CreateUserID; //建立用户ID
objvcc_CourseExamPaperENT.UserName = objvcc_CourseExamPaperENS.UserName; //用户名
objvcc_CourseExamPaperENT.IsOpenToAllStu = objvcc_CourseExamPaperENS.IsOpenToAllStu; //全校师生
objvcc_CourseExamPaperENT.IsOpenToSchool = objvcc_CourseExamPaperENS.IsOpenToSchool; //全校师生公开
objvcc_CourseExamPaperENT.IsOpenToSocial = objvcc_CourseExamPaperENS.IsOpenToSocial; //社会公众
objvcc_CourseExamPaperENT.CourseChapterId = objvcc_CourseExamPaperENS.CourseChapterId; //课程章节ID
objvcc_CourseExamPaperENT.CourseChapterName = objvcc_CourseExamPaperENS.CourseChapterName; //课程章节名称
objvcc_CourseExamPaperENT.ChapterId = objvcc_CourseExamPaperENS.ChapterId; //章Id
objvcc_CourseExamPaperENT.SectionId = objvcc_CourseExamPaperENS.SectionId; //节Id
objvcc_CourseExamPaperENT.ChapterName = objvcc_CourseExamPaperENS.ChapterName; //章名
objvcc_CourseExamPaperENT.SectionName = objvcc_CourseExamPaperENS.SectionName; //节名
objvcc_CourseExamPaperENT.ChapterNameSim = objvcc_CourseExamPaperENS.ChapterNameSim; //章名简称
objvcc_CourseExamPaperENT.SectionNameSim = objvcc_CourseExamPaperENS.SectionNameSim; //节名简称
objvcc_CourseExamPaperENT.IsAutoGeneQuestion = objvcc_CourseExamPaperENS.IsAutoGeneQuestion; //是否自动生成题目
objvcc_CourseExamPaperENT.IsCanMultiDo = objvcc_CourseExamPaperENS.IsCanMultiDo; //是否可以做多次
objvcc_CourseExamPaperENT.UpdDate = objvcc_CourseExamPaperENS.UpdDate; //修改日期
objvcc_CourseExamPaperENT.UpdUserId = objvcc_CourseExamPaperENS.UpdUserId; //修改用户Id
objvcc_CourseExamPaperENT.Memo = objvcc_CourseExamPaperENS.Memo; //备注
objvcc_CourseExamPaperENT.QuestionNum = objvcc_CourseExamPaperENS.QuestionNum; //题目数
objvcc_CourseExamPaperENT.BigTopicNum = objvcc_CourseExamPaperENS.BigTopicNum; //大标题数
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvcc_CourseExamPaperEN.CourseExamPaperId, 8, convcc_CourseExamPaper.CourseExamPaperId);
clsCheckSql.CheckFieldLen(objvcc_CourseExamPaperEN.CourseId, 8, convcc_CourseExamPaper.CourseId);
clsCheckSql.CheckFieldLen(objvcc_CourseExamPaperEN.CourseName, 100, convcc_CourseExamPaper.CourseName);
clsCheckSql.CheckFieldLen(objvcc_CourseExamPaperEN.ExamPaperName, 500, convcc_CourseExamPaper.ExamPaperName);
clsCheckSql.CheckFieldLen(objvcc_CourseExamPaperEN.ExamPaperTypeId, 2, convcc_CourseExamPaper.ExamPaperTypeId);
clsCheckSql.CheckFieldLen(objvcc_CourseExamPaperEN.ExamPaperTypeName, 30, convcc_CourseExamPaper.ExamPaperTypeName);
clsCheckSql.CheckFieldLen(objvcc_CourseExamPaperEN.IdXzMajor, 8, convcc_CourseExamPaper.IdXzMajor);
clsCheckSql.CheckFieldLen(objvcc_CourseExamPaperEN.MajorName, 100, convcc_CourseExamPaper.MajorName);
clsCheckSql.CheckFieldLen(objvcc_CourseExamPaperEN.PaperDispModeId, 4, convcc_CourseExamPaper.PaperDispModeId);
clsCheckSql.CheckFieldLen(objvcc_CourseExamPaperEN.PaperDispModeName, 30, convcc_CourseExamPaper.PaperDispModeName);
clsCheckSql.CheckFieldLen(objvcc_CourseExamPaperEN.ExamCreateTime, 14, convcc_CourseExamPaper.ExamCreateTime);
clsCheckSql.CheckFieldLen(objvcc_CourseExamPaperEN.CreateUserID, 20, convcc_CourseExamPaper.CreateUserID);
clsCheckSql.CheckFieldLen(objvcc_CourseExamPaperEN.UserName, 30, convcc_CourseExamPaper.UserName);
clsCheckSql.CheckFieldLen(objvcc_CourseExamPaperEN.CourseChapterId, 8, convcc_CourseExamPaper.CourseChapterId);
clsCheckSql.CheckFieldLen(objvcc_CourseExamPaperEN.CourseChapterName, 100, convcc_CourseExamPaper.CourseChapterName);
clsCheckSql.CheckFieldLen(objvcc_CourseExamPaperEN.ChapterId, 8, convcc_CourseExamPaper.ChapterId);
clsCheckSql.CheckFieldLen(objvcc_CourseExamPaperEN.SectionId, 8, convcc_CourseExamPaper.SectionId);
clsCheckSql.CheckFieldLen(objvcc_CourseExamPaperEN.ChapterName, 100, convcc_CourseExamPaper.ChapterName);
clsCheckSql.CheckFieldLen(objvcc_CourseExamPaperEN.SectionName, 100, convcc_CourseExamPaper.SectionName);
clsCheckSql.CheckFieldLen(objvcc_CourseExamPaperEN.ChapterNameSim, 10, convcc_CourseExamPaper.ChapterNameSim);
clsCheckSql.CheckFieldLen(objvcc_CourseExamPaperEN.SectionNameSim, 10, convcc_CourseExamPaper.SectionNameSim);
clsCheckSql.CheckFieldLen(objvcc_CourseExamPaperEN.UpdDate, 20, convcc_CourseExamPaper.UpdDate);
clsCheckSql.CheckFieldLen(objvcc_CourseExamPaperEN.UpdUserId, 20, convcc_CourseExamPaper.UpdUserId);
clsCheckSql.CheckFieldLen(objvcc_CourseExamPaperEN.Memo, 1000, convcc_CourseExamPaper.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseExamPaperEN.CourseExamPaperId, convcc_CourseExamPaper.CourseExamPaperId);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseExamPaperEN.CourseId, convcc_CourseExamPaper.CourseId);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseExamPaperEN.CourseName, convcc_CourseExamPaper.CourseName);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseExamPaperEN.ExamPaperName, convcc_CourseExamPaper.ExamPaperName);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseExamPaperEN.ExamPaperTypeId, convcc_CourseExamPaper.ExamPaperTypeId);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseExamPaperEN.ExamPaperTypeName, convcc_CourseExamPaper.ExamPaperTypeName);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseExamPaperEN.IdXzMajor, convcc_CourseExamPaper.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseExamPaperEN.MajorName, convcc_CourseExamPaper.MajorName);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseExamPaperEN.PaperDispModeId, convcc_CourseExamPaper.PaperDispModeId);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseExamPaperEN.PaperDispModeName, convcc_CourseExamPaper.PaperDispModeName);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseExamPaperEN.ExamCreateTime, convcc_CourseExamPaper.ExamCreateTime);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseExamPaperEN.CreateUserID, convcc_CourseExamPaper.CreateUserID);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseExamPaperEN.UserName, convcc_CourseExamPaper.UserName);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseExamPaperEN.CourseChapterId, convcc_CourseExamPaper.CourseChapterId);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseExamPaperEN.CourseChapterName, convcc_CourseExamPaper.CourseChapterName);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseExamPaperEN.ChapterId, convcc_CourseExamPaper.ChapterId);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseExamPaperEN.SectionId, convcc_CourseExamPaper.SectionId);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseExamPaperEN.ChapterName, convcc_CourseExamPaper.ChapterName);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseExamPaperEN.SectionName, convcc_CourseExamPaper.SectionName);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseExamPaperEN.ChapterNameSim, convcc_CourseExamPaper.ChapterNameSim);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseExamPaperEN.SectionNameSim, convcc_CourseExamPaper.SectionNameSim);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseExamPaperEN.UpdDate, convcc_CourseExamPaper.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseExamPaperEN.UpdUserId, convcc_CourseExamPaper.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseExamPaperEN.Memo, convcc_CourseExamPaper.Memo);
//检查外键字段长度
 objvcc_CourseExamPaperEN._IsCheckProperty = true;
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
 objSQL = clsvcc_CourseExamPaperDA.GetSpecSQLObj();
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
 objSQL = clsvcc_CourseExamPaperDA.GetSpecSQLObj();
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
 objSQL = clsvcc_CourseExamPaperDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvcc_CourseExamPaperEN._CurrTabName);
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
 objSQL = clsvcc_CourseExamPaperDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvcc_CourseExamPaperEN._CurrTabName, strCondition);
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
 objSQL = clsvcc_CourseExamPaperDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}