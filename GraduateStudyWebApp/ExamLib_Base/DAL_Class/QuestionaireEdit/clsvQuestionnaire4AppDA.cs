
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQuestionnaire4AppDA
 表名:vQuestionnaire4App(01120221)
 * 版本:2024.11.08.1(服务器:WIN-SRV103-116)
 日期:2024/11/09 22:29:43
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:问卷维护(QuestionaireEdit)
 框架-层名:数据处理层(CS)(DALCode,0002)
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
 /// v题目表4App(vQuestionnaire4App)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvQuestionnaire4AppDA : clsCommBase4DA
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
 return clsvQuestionnaire4AppEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvQuestionnaire4AppEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQuestionnaire4AppEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvQuestionnaire4AppEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvQuestionnaire4AppEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvQuestionnaire4AppDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire4AppDA.GetSpecSQLObj();
strSQL = "Select * from vQuestionnaire4App where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vQuestionnaire4App(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvQuestionnaire4AppDA: GetDataTable_vQuestionnaire4App)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire4AppDA.GetSpecSQLObj();
strSQL = "Select * from vQuestionnaire4App where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvQuestionnaire4AppDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire4AppDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvQuestionnaire4AppDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire4AppDA.GetSpecSQLObj();
strSQL = "Select * from vQuestionnaire4App where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvQuestionnaire4AppDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire4AppDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvQuestionnaire4AppDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire4AppDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQuestionnaire4App where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQuestionnaire4App where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvQuestionnaire4AppDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire4AppDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vQuestionnaire4App where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvQuestionnaire4AppDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire4AppDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vQuestionnaire4App.* from vQuestionnaire4App Left Join {1} on {2} where {3} and vQuestionnaire4App.QuestionId not in (Select top {5} vQuestionnaire4App.QuestionId from vQuestionnaire4App Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQuestionnaire4App where {1} and QuestionId not in (Select top {2} QuestionId from vQuestionnaire4App where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQuestionnaire4App where {1} and QuestionId not in (Select top {3} QuestionId from vQuestionnaire4App where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvQuestionnaire4AppDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire4AppDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vQuestionnaire4App.* from vQuestionnaire4App Left Join {1} on {2} where {3} and vQuestionnaire4App.QuestionId not in (Select top {5} vQuestionnaire4App.QuestionId from vQuestionnaire4App Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQuestionnaire4App where {1} and QuestionId not in (Select top {2} QuestionId from vQuestionnaire4App where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQuestionnaire4App where {1} and QuestionId not in (Select top {3} QuestionId from vQuestionnaire4App where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvQuestionnaire4AppEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvQuestionnaire4AppDA:GetObjLst)", objException.Message));
}
List<clsvQuestionnaire4AppEN> arrObjLst = new List<clsvQuestionnaire4AppEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire4AppDA.GetSpecSQLObj();
strSQL = "Select * from vQuestionnaire4App where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaire4AppEN objvQuestionnaire4AppEN = new clsvQuestionnaire4AppEN();
try
{
objvQuestionnaire4AppEN.QuestionId = TransNullToInt(objRow[convQuestionnaire4App.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaire4AppEN.QuestionIndex = objRow[convQuestionnaire4App.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire4App.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaire4AppEN.QuestionName = objRow[convQuestionnaire4App.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire4App.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaire4AppEN.QuestionNo = objRow[convQuestionnaire4App.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire4App.QuestionNo].ToString().Trim(); //题目编号
objvQuestionnaire4AppEN.CourseId = objRow[convQuestionnaire4App.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire4App.CourseId].ToString().Trim(); //课程Id
objvQuestionnaire4AppEN.CourseCode = objRow[convQuestionnaire4App.CourseCode] == DBNull.Value ? null : objRow[convQuestionnaire4App.CourseCode].ToString().Trim(); //课程代码
objvQuestionnaire4AppEN.CourseName = objRow[convQuestionnaire4App.CourseName] == DBNull.Value ? null : objRow[convQuestionnaire4App.CourseName].ToString().Trim(); //课程名称
objvQuestionnaire4AppEN.CourseChapterId = objRow[convQuestionnaire4App.CourseChapterId] == DBNull.Value ? null : objRow[convQuestionnaire4App.CourseChapterId].ToString().Trim(); //课程章节ID
objvQuestionnaire4AppEN.ChapterId = objRow[convQuestionnaire4App.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire4App.ChapterId].ToString().Trim(); //章Id
objvQuestionnaire4AppEN.SectionId = objRow[convQuestionnaire4App.SectionId] == DBNull.Value ? null : objRow[convQuestionnaire4App.SectionId].ToString().Trim(); //节Id
objvQuestionnaire4AppEN.ChapterName = objRow[convQuestionnaire4App.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire4App.ChapterName].ToString().Trim(); //章名
objvQuestionnaire4AppEN.SectionName = objRow[convQuestionnaire4App.SectionName] == DBNull.Value ? null : objRow[convQuestionnaire4App.SectionName].ToString().Trim(); //节名
objvQuestionnaire4AppEN.ChapterNameSim = objRow[convQuestionnaire4App.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire4App.ChapterNameSim].ToString().Trim(); //章名简称
objvQuestionnaire4AppEN.SectionNameSim = objRow[convQuestionnaire4App.SectionNameSim] == DBNull.Value ? null : objRow[convQuestionnaire4App.SectionNameSim].ToString().Trim(); //节名简称
objvQuestionnaire4AppEN.ParentNodeId = objRow[convQuestionnaire4App.ParentNodeId] == DBNull.Value ? null : objRow[convQuestionnaire4App.ParentNodeId].ToString().Trim(); //父节点编号
objvQuestionnaire4AppEN.QuestionTypeId = objRow[convQuestionnaire4App.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire4App.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaire4AppEN.QuestionTypeName = objRow[convQuestionnaire4App.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionnaire4App.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionnaire4AppEN.ExamGradeId = objRow[convQuestionnaire4App.ExamGradeId] == DBNull.Value ? null : objRow[convQuestionnaire4App.ExamGradeId].ToString().Trim(); //题库等级ID
objvQuestionnaire4AppEN.ExamGradeName = objRow[convQuestionnaire4App.ExamGradeName] == DBNull.Value ? null : objRow[convQuestionnaire4App.ExamGradeName].ToString().Trim(); //题库等级名
objvQuestionnaire4AppEN.AnswerTypeId = objRow[convQuestionnaire4App.AnswerTypeId] == DBNull.Value ? null : objRow[convQuestionnaire4App.AnswerTypeId].ToString().Trim(); //答案类型ID
objvQuestionnaire4AppEN.QuestionScore = objRow[convQuestionnaire4App.QuestionScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convQuestionnaire4App.QuestionScore].ToString().Trim()); //题目得分
objvQuestionnaire4AppEN.UpdDate = objRow[convQuestionnaire4App.UpdDate].ToString().Trim(); //修改日期
objvQuestionnaire4AppEN.OptionNum = objRow[convQuestionnaire4App.OptionNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire4App.OptionNum].ToString().Trim()); //选项数
objvQuestionnaire4AppEN.ChapterOrderNum = objRow[convQuestionnaire4App.ChapterOrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire4App.ChapterOrderNum].ToString().Trim()); //章排序号
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvQuestionnaire4AppDA: GetObjLst)", objException.Message));
}
objvQuestionnaire4AppEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvQuestionnaire4AppEN);
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
public List<clsvQuestionnaire4AppEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvQuestionnaire4AppDA:GetObjLstByTabName)", objException.Message));
}
List<clsvQuestionnaire4AppEN> arrObjLst = new List<clsvQuestionnaire4AppEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire4AppDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaire4AppEN objvQuestionnaire4AppEN = new clsvQuestionnaire4AppEN();
try
{
objvQuestionnaire4AppEN.QuestionId = TransNullToInt(objRow[convQuestionnaire4App.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaire4AppEN.QuestionIndex = objRow[convQuestionnaire4App.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire4App.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaire4AppEN.QuestionName = objRow[convQuestionnaire4App.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire4App.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaire4AppEN.QuestionNo = objRow[convQuestionnaire4App.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire4App.QuestionNo].ToString().Trim(); //题目编号
objvQuestionnaire4AppEN.CourseId = objRow[convQuestionnaire4App.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire4App.CourseId].ToString().Trim(); //课程Id
objvQuestionnaire4AppEN.CourseCode = objRow[convQuestionnaire4App.CourseCode] == DBNull.Value ? null : objRow[convQuestionnaire4App.CourseCode].ToString().Trim(); //课程代码
objvQuestionnaire4AppEN.CourseName = objRow[convQuestionnaire4App.CourseName] == DBNull.Value ? null : objRow[convQuestionnaire4App.CourseName].ToString().Trim(); //课程名称
objvQuestionnaire4AppEN.CourseChapterId = objRow[convQuestionnaire4App.CourseChapterId] == DBNull.Value ? null : objRow[convQuestionnaire4App.CourseChapterId].ToString().Trim(); //课程章节ID
objvQuestionnaire4AppEN.ChapterId = objRow[convQuestionnaire4App.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire4App.ChapterId].ToString().Trim(); //章Id
objvQuestionnaire4AppEN.SectionId = objRow[convQuestionnaire4App.SectionId] == DBNull.Value ? null : objRow[convQuestionnaire4App.SectionId].ToString().Trim(); //节Id
objvQuestionnaire4AppEN.ChapterName = objRow[convQuestionnaire4App.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire4App.ChapterName].ToString().Trim(); //章名
objvQuestionnaire4AppEN.SectionName = objRow[convQuestionnaire4App.SectionName] == DBNull.Value ? null : objRow[convQuestionnaire4App.SectionName].ToString().Trim(); //节名
objvQuestionnaire4AppEN.ChapterNameSim = objRow[convQuestionnaire4App.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire4App.ChapterNameSim].ToString().Trim(); //章名简称
objvQuestionnaire4AppEN.SectionNameSim = objRow[convQuestionnaire4App.SectionNameSim] == DBNull.Value ? null : objRow[convQuestionnaire4App.SectionNameSim].ToString().Trim(); //节名简称
objvQuestionnaire4AppEN.ParentNodeId = objRow[convQuestionnaire4App.ParentNodeId] == DBNull.Value ? null : objRow[convQuestionnaire4App.ParentNodeId].ToString().Trim(); //父节点编号
objvQuestionnaire4AppEN.QuestionTypeId = objRow[convQuestionnaire4App.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire4App.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaire4AppEN.QuestionTypeName = objRow[convQuestionnaire4App.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionnaire4App.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionnaire4AppEN.ExamGradeId = objRow[convQuestionnaire4App.ExamGradeId] == DBNull.Value ? null : objRow[convQuestionnaire4App.ExamGradeId].ToString().Trim(); //题库等级ID
objvQuestionnaire4AppEN.ExamGradeName = objRow[convQuestionnaire4App.ExamGradeName] == DBNull.Value ? null : objRow[convQuestionnaire4App.ExamGradeName].ToString().Trim(); //题库等级名
objvQuestionnaire4AppEN.AnswerTypeId = objRow[convQuestionnaire4App.AnswerTypeId] == DBNull.Value ? null : objRow[convQuestionnaire4App.AnswerTypeId].ToString().Trim(); //答案类型ID
objvQuestionnaire4AppEN.QuestionScore = objRow[convQuestionnaire4App.QuestionScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convQuestionnaire4App.QuestionScore].ToString().Trim()); //题目得分
objvQuestionnaire4AppEN.UpdDate = objRow[convQuestionnaire4App.UpdDate].ToString().Trim(); //修改日期
objvQuestionnaire4AppEN.OptionNum = objRow[convQuestionnaire4App.OptionNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire4App.OptionNum].ToString().Trim()); //选项数
objvQuestionnaire4AppEN.ChapterOrderNum = objRow[convQuestionnaire4App.ChapterOrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire4App.ChapterOrderNum].ToString().Trim()); //章排序号
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvQuestionnaire4AppDA: GetObjLst)", objException.Message));
}
objvQuestionnaire4AppEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvQuestionnaire4AppEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvQuestionnaire4AppEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvQuestionnaire4App(ref clsvQuestionnaire4AppEN objvQuestionnaire4AppEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire4AppDA.GetSpecSQLObj();
strSQL = "Select * from vQuestionnaire4App where QuestionId = " + ""+ objvQuestionnaire4AppEN.QuestionId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvQuestionnaire4AppEN.QuestionId = TransNullToInt(objDT.Rows[0][convQuestionnaire4App.QuestionId].ToString().Trim()); //题目Id(字段类型:bigint,字段长度:8,是否可空:True)
 objvQuestionnaire4AppEN.QuestionIndex = TransNullToInt(objDT.Rows[0][convQuestionnaire4App.QuestionIndex].ToString().Trim()); //题目序号(字段类型:int,字段长度:4,是否可空:True)
 objvQuestionnaire4AppEN.QuestionName = objDT.Rows[0][convQuestionnaire4App.QuestionName].ToString().Trim(); //题目名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvQuestionnaire4AppEN.QuestionNo = objDT.Rows[0][convQuestionnaire4App.QuestionNo].ToString().Trim(); //题目编号(字段类型:varchar,字段长度:10,是否可空:True)
 objvQuestionnaire4AppEN.CourseId = objDT.Rows[0][convQuestionnaire4App.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvQuestionnaire4AppEN.CourseCode = objDT.Rows[0][convQuestionnaire4App.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvQuestionnaire4AppEN.CourseName = objDT.Rows[0][convQuestionnaire4App.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvQuestionnaire4AppEN.CourseChapterId = objDT.Rows[0][convQuestionnaire4App.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objvQuestionnaire4AppEN.ChapterId = objDT.Rows[0][convQuestionnaire4App.ChapterId].ToString().Trim(); //章Id(字段类型:char,字段长度:8,是否可空:True)
 objvQuestionnaire4AppEN.SectionId = objDT.Rows[0][convQuestionnaire4App.SectionId].ToString().Trim(); //节Id(字段类型:char,字段长度:8,是否可空:True)
 objvQuestionnaire4AppEN.ChapterName = objDT.Rows[0][convQuestionnaire4App.ChapterName].ToString().Trim(); //章名(字段类型:varchar,字段长度:100,是否可空:True)
 objvQuestionnaire4AppEN.SectionName = objDT.Rows[0][convQuestionnaire4App.SectionName].ToString().Trim(); //节名(字段类型:varchar,字段长度:100,是否可空:True)
 objvQuestionnaire4AppEN.ChapterNameSim = objDT.Rows[0][convQuestionnaire4App.ChapterNameSim].ToString().Trim(); //章名简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvQuestionnaire4AppEN.SectionNameSim = objDT.Rows[0][convQuestionnaire4App.SectionNameSim].ToString().Trim(); //节名简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvQuestionnaire4AppEN.ParentNodeId = objDT.Rows[0][convQuestionnaire4App.ParentNodeId].ToString().Trim(); //父节点编号(字段类型:varchar,字段长度:8,是否可空:True)
 objvQuestionnaire4AppEN.QuestionTypeId = objDT.Rows[0][convQuestionnaire4App.QuestionTypeId].ToString().Trim(); //题目类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvQuestionnaire4AppEN.QuestionTypeName = objDT.Rows[0][convQuestionnaire4App.QuestionTypeName].ToString().Trim(); //题目类型名(字段类型:varchar,字段长度:20,是否可空:True)
 objvQuestionnaire4AppEN.ExamGradeId = objDT.Rows[0][convQuestionnaire4App.ExamGradeId].ToString().Trim(); //题库等级ID(字段类型:char,字段长度:2,是否可空:True)
 objvQuestionnaire4AppEN.ExamGradeName = objDT.Rows[0][convQuestionnaire4App.ExamGradeName].ToString().Trim(); //题库等级名(字段类型:varchar,字段长度:50,是否可空:True)
 objvQuestionnaire4AppEN.AnswerTypeId = objDT.Rows[0][convQuestionnaire4App.AnswerTypeId].ToString().Trim(); //答案类型ID(字段类型:char,字段长度:2,是否可空:True)
 objvQuestionnaire4AppEN.QuestionScore = TransNullToFloat(objDT.Rows[0][convQuestionnaire4App.QuestionScore].ToString().Trim()); //题目得分(字段类型:float,字段长度:8,是否可空:True)
 objvQuestionnaire4AppEN.UpdDate = objDT.Rows[0][convQuestionnaire4App.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvQuestionnaire4AppEN.OptionNum = TransNullToInt(objDT.Rows[0][convQuestionnaire4App.OptionNum].ToString().Trim()); //选项数(字段类型:int,字段长度:4,是否可空:True)
 objvQuestionnaire4AppEN.ChapterOrderNum = TransNullToInt(objDT.Rows[0][convQuestionnaire4App.ChapterOrderNum].ToString().Trim()); //章排序号(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvQuestionnaire4AppDA: GetvQuestionnaire4App)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngQuestionId">表关键字</param>
 /// <returns>表对象</returns>
public clsvQuestionnaire4AppEN GetObjByQuestionId(long lngQuestionId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire4AppDA.GetSpecSQLObj();
strSQL = "Select * from vQuestionnaire4App where QuestionId = " + ""+ lngQuestionId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvQuestionnaire4AppEN objvQuestionnaire4AppEN = new clsvQuestionnaire4AppEN();
try
{
 objvQuestionnaire4AppEN.QuestionId = Int32.Parse(objRow[convQuestionnaire4App.QuestionId].ToString().Trim()); //题目Id(字段类型:bigint,字段长度:8,是否可空:True)
 objvQuestionnaire4AppEN.QuestionIndex = objRow[convQuestionnaire4App.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire4App.QuestionIndex].ToString().Trim()); //题目序号(字段类型:int,字段长度:4,是否可空:True)
 objvQuestionnaire4AppEN.QuestionName = objRow[convQuestionnaire4App.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire4App.QuestionName].ToString().Trim(); //题目名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvQuestionnaire4AppEN.QuestionNo = objRow[convQuestionnaire4App.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire4App.QuestionNo].ToString().Trim(); //题目编号(字段类型:varchar,字段长度:10,是否可空:True)
 objvQuestionnaire4AppEN.CourseId = objRow[convQuestionnaire4App.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire4App.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvQuestionnaire4AppEN.CourseCode = objRow[convQuestionnaire4App.CourseCode] == DBNull.Value ? null : objRow[convQuestionnaire4App.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvQuestionnaire4AppEN.CourseName = objRow[convQuestionnaire4App.CourseName] == DBNull.Value ? null : objRow[convQuestionnaire4App.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvQuestionnaire4AppEN.CourseChapterId = objRow[convQuestionnaire4App.CourseChapterId] == DBNull.Value ? null : objRow[convQuestionnaire4App.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objvQuestionnaire4AppEN.ChapterId = objRow[convQuestionnaire4App.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire4App.ChapterId].ToString().Trim(); //章Id(字段类型:char,字段长度:8,是否可空:True)
 objvQuestionnaire4AppEN.SectionId = objRow[convQuestionnaire4App.SectionId] == DBNull.Value ? null : objRow[convQuestionnaire4App.SectionId].ToString().Trim(); //节Id(字段类型:char,字段长度:8,是否可空:True)
 objvQuestionnaire4AppEN.ChapterName = objRow[convQuestionnaire4App.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire4App.ChapterName].ToString().Trim(); //章名(字段类型:varchar,字段长度:100,是否可空:True)
 objvQuestionnaire4AppEN.SectionName = objRow[convQuestionnaire4App.SectionName] == DBNull.Value ? null : objRow[convQuestionnaire4App.SectionName].ToString().Trim(); //节名(字段类型:varchar,字段长度:100,是否可空:True)
 objvQuestionnaire4AppEN.ChapterNameSim = objRow[convQuestionnaire4App.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire4App.ChapterNameSim].ToString().Trim(); //章名简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvQuestionnaire4AppEN.SectionNameSim = objRow[convQuestionnaire4App.SectionNameSim] == DBNull.Value ? null : objRow[convQuestionnaire4App.SectionNameSim].ToString().Trim(); //节名简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvQuestionnaire4AppEN.ParentNodeId = objRow[convQuestionnaire4App.ParentNodeId] == DBNull.Value ? null : objRow[convQuestionnaire4App.ParentNodeId].ToString().Trim(); //父节点编号(字段类型:varchar,字段长度:8,是否可空:True)
 objvQuestionnaire4AppEN.QuestionTypeId = objRow[convQuestionnaire4App.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire4App.QuestionTypeId].ToString().Trim(); //题目类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvQuestionnaire4AppEN.QuestionTypeName = objRow[convQuestionnaire4App.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionnaire4App.QuestionTypeName].ToString().Trim(); //题目类型名(字段类型:varchar,字段长度:20,是否可空:True)
 objvQuestionnaire4AppEN.ExamGradeId = objRow[convQuestionnaire4App.ExamGradeId] == DBNull.Value ? null : objRow[convQuestionnaire4App.ExamGradeId].ToString().Trim(); //题库等级ID(字段类型:char,字段长度:2,是否可空:True)
 objvQuestionnaire4AppEN.ExamGradeName = objRow[convQuestionnaire4App.ExamGradeName] == DBNull.Value ? null : objRow[convQuestionnaire4App.ExamGradeName].ToString().Trim(); //题库等级名(字段类型:varchar,字段长度:50,是否可空:True)
 objvQuestionnaire4AppEN.AnswerTypeId = objRow[convQuestionnaire4App.AnswerTypeId] == DBNull.Value ? null : objRow[convQuestionnaire4App.AnswerTypeId].ToString().Trim(); //答案类型ID(字段类型:char,字段长度:2,是否可空:True)
 objvQuestionnaire4AppEN.QuestionScore = objRow[convQuestionnaire4App.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convQuestionnaire4App.QuestionScore].ToString().Trim()); //题目得分(字段类型:float,字段长度:8,是否可空:True)
 objvQuestionnaire4AppEN.UpdDate = objRow[convQuestionnaire4App.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvQuestionnaire4AppEN.OptionNum = objRow[convQuestionnaire4App.OptionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire4App.OptionNum].ToString().Trim()); //选项数(字段类型:int,字段长度:4,是否可空:True)
 objvQuestionnaire4AppEN.ChapterOrderNum = objRow[convQuestionnaire4App.ChapterOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire4App.ChapterOrderNum].ToString().Trim()); //章排序号(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvQuestionnaire4AppDA: GetObjByQuestionId)", objException.Message));
}
return objvQuestionnaire4AppEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvQuestionnaire4AppEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvQuestionnaire4AppDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire4AppDA.GetSpecSQLObj();
strSQL = "Select * from vQuestionnaire4App where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvQuestionnaire4AppEN objvQuestionnaire4AppEN = new clsvQuestionnaire4AppEN()
{
QuestionId = TransNullToInt(objRow[convQuestionnaire4App.QuestionId].ToString().Trim()), //题目Id
QuestionIndex = objRow[convQuestionnaire4App.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire4App.QuestionIndex].ToString().Trim()), //题目序号
QuestionName = objRow[convQuestionnaire4App.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire4App.QuestionName].ToString().Trim(), //题目名称
QuestionNo = objRow[convQuestionnaire4App.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire4App.QuestionNo].ToString().Trim(), //题目编号
CourseId = objRow[convQuestionnaire4App.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire4App.CourseId].ToString().Trim(), //课程Id
CourseCode = objRow[convQuestionnaire4App.CourseCode] == DBNull.Value ? null : objRow[convQuestionnaire4App.CourseCode].ToString().Trim(), //课程代码
CourseName = objRow[convQuestionnaire4App.CourseName] == DBNull.Value ? null : objRow[convQuestionnaire4App.CourseName].ToString().Trim(), //课程名称
CourseChapterId = objRow[convQuestionnaire4App.CourseChapterId] == DBNull.Value ? null : objRow[convQuestionnaire4App.CourseChapterId].ToString().Trim(), //课程章节ID
ChapterId = objRow[convQuestionnaire4App.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire4App.ChapterId].ToString().Trim(), //章Id
SectionId = objRow[convQuestionnaire4App.SectionId] == DBNull.Value ? null : objRow[convQuestionnaire4App.SectionId].ToString().Trim(), //节Id
ChapterName = objRow[convQuestionnaire4App.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire4App.ChapterName].ToString().Trim(), //章名
SectionName = objRow[convQuestionnaire4App.SectionName] == DBNull.Value ? null : objRow[convQuestionnaire4App.SectionName].ToString().Trim(), //节名
ChapterNameSim = objRow[convQuestionnaire4App.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire4App.ChapterNameSim].ToString().Trim(), //章名简称
SectionNameSim = objRow[convQuestionnaire4App.SectionNameSim] == DBNull.Value ? null : objRow[convQuestionnaire4App.SectionNameSim].ToString().Trim(), //节名简称
ParentNodeId = objRow[convQuestionnaire4App.ParentNodeId] == DBNull.Value ? null : objRow[convQuestionnaire4App.ParentNodeId].ToString().Trim(), //父节点编号
QuestionTypeId = objRow[convQuestionnaire4App.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire4App.QuestionTypeId].ToString().Trim(), //题目类型Id
QuestionTypeName = objRow[convQuestionnaire4App.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionnaire4App.QuestionTypeName].ToString().Trim(), //题目类型名
ExamGradeId = objRow[convQuestionnaire4App.ExamGradeId] == DBNull.Value ? null : objRow[convQuestionnaire4App.ExamGradeId].ToString().Trim(), //题库等级ID
ExamGradeName = objRow[convQuestionnaire4App.ExamGradeName] == DBNull.Value ? null : objRow[convQuestionnaire4App.ExamGradeName].ToString().Trim(), //题库等级名
AnswerTypeId = objRow[convQuestionnaire4App.AnswerTypeId] == DBNull.Value ? null : objRow[convQuestionnaire4App.AnswerTypeId].ToString().Trim(), //答案类型ID
QuestionScore = objRow[convQuestionnaire4App.QuestionScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convQuestionnaire4App.QuestionScore].ToString().Trim()), //题目得分
UpdDate = objRow[convQuestionnaire4App.UpdDate].ToString().Trim(), //修改日期
OptionNum = objRow[convQuestionnaire4App.OptionNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire4App.OptionNum].ToString().Trim()), //选项数
ChapterOrderNum = objRow[convQuestionnaire4App.ChapterOrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire4App.ChapterOrderNum].ToString().Trim()) //章排序号
};
objvQuestionnaire4AppEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQuestionnaire4AppEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvQuestionnaire4AppDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvQuestionnaire4AppEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvQuestionnaire4AppEN objvQuestionnaire4AppEN = new clsvQuestionnaire4AppEN();
try
{
objvQuestionnaire4AppEN.QuestionId = TransNullToInt(objRow[convQuestionnaire4App.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaire4AppEN.QuestionIndex = objRow[convQuestionnaire4App.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire4App.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaire4AppEN.QuestionName = objRow[convQuestionnaire4App.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire4App.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaire4AppEN.QuestionNo = objRow[convQuestionnaire4App.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire4App.QuestionNo].ToString().Trim(); //题目编号
objvQuestionnaire4AppEN.CourseId = objRow[convQuestionnaire4App.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire4App.CourseId].ToString().Trim(); //课程Id
objvQuestionnaire4AppEN.CourseCode = objRow[convQuestionnaire4App.CourseCode] == DBNull.Value ? null : objRow[convQuestionnaire4App.CourseCode].ToString().Trim(); //课程代码
objvQuestionnaire4AppEN.CourseName = objRow[convQuestionnaire4App.CourseName] == DBNull.Value ? null : objRow[convQuestionnaire4App.CourseName].ToString().Trim(); //课程名称
objvQuestionnaire4AppEN.CourseChapterId = objRow[convQuestionnaire4App.CourseChapterId] == DBNull.Value ? null : objRow[convQuestionnaire4App.CourseChapterId].ToString().Trim(); //课程章节ID
objvQuestionnaire4AppEN.ChapterId = objRow[convQuestionnaire4App.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire4App.ChapterId].ToString().Trim(); //章Id
objvQuestionnaire4AppEN.SectionId = objRow[convQuestionnaire4App.SectionId] == DBNull.Value ? null : objRow[convQuestionnaire4App.SectionId].ToString().Trim(); //节Id
objvQuestionnaire4AppEN.ChapterName = objRow[convQuestionnaire4App.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire4App.ChapterName].ToString().Trim(); //章名
objvQuestionnaire4AppEN.SectionName = objRow[convQuestionnaire4App.SectionName] == DBNull.Value ? null : objRow[convQuestionnaire4App.SectionName].ToString().Trim(); //节名
objvQuestionnaire4AppEN.ChapterNameSim = objRow[convQuestionnaire4App.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire4App.ChapterNameSim].ToString().Trim(); //章名简称
objvQuestionnaire4AppEN.SectionNameSim = objRow[convQuestionnaire4App.SectionNameSim] == DBNull.Value ? null : objRow[convQuestionnaire4App.SectionNameSim].ToString().Trim(); //节名简称
objvQuestionnaire4AppEN.ParentNodeId = objRow[convQuestionnaire4App.ParentNodeId] == DBNull.Value ? null : objRow[convQuestionnaire4App.ParentNodeId].ToString().Trim(); //父节点编号
objvQuestionnaire4AppEN.QuestionTypeId = objRow[convQuestionnaire4App.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire4App.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaire4AppEN.QuestionTypeName = objRow[convQuestionnaire4App.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionnaire4App.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionnaire4AppEN.ExamGradeId = objRow[convQuestionnaire4App.ExamGradeId] == DBNull.Value ? null : objRow[convQuestionnaire4App.ExamGradeId].ToString().Trim(); //题库等级ID
objvQuestionnaire4AppEN.ExamGradeName = objRow[convQuestionnaire4App.ExamGradeName] == DBNull.Value ? null : objRow[convQuestionnaire4App.ExamGradeName].ToString().Trim(); //题库等级名
objvQuestionnaire4AppEN.AnswerTypeId = objRow[convQuestionnaire4App.AnswerTypeId] == DBNull.Value ? null : objRow[convQuestionnaire4App.AnswerTypeId].ToString().Trim(); //答案类型ID
objvQuestionnaire4AppEN.QuestionScore = objRow[convQuestionnaire4App.QuestionScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convQuestionnaire4App.QuestionScore].ToString().Trim()); //题目得分
objvQuestionnaire4AppEN.UpdDate = objRow[convQuestionnaire4App.UpdDate].ToString().Trim(); //修改日期
objvQuestionnaire4AppEN.OptionNum = objRow[convQuestionnaire4App.OptionNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire4App.OptionNum].ToString().Trim()); //选项数
objvQuestionnaire4AppEN.ChapterOrderNum = objRow[convQuestionnaire4App.ChapterOrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire4App.ChapterOrderNum].ToString().Trim()); //章排序号
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvQuestionnaire4AppDA: GetObjByDataRowvQuestionnaire4App)", objException.Message));
}
objvQuestionnaire4AppEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQuestionnaire4AppEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvQuestionnaire4AppEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvQuestionnaire4AppEN objvQuestionnaire4AppEN = new clsvQuestionnaire4AppEN();
try
{
objvQuestionnaire4AppEN.QuestionId = TransNullToInt(objRow[convQuestionnaire4App.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaire4AppEN.QuestionIndex = objRow[convQuestionnaire4App.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire4App.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaire4AppEN.QuestionName = objRow[convQuestionnaire4App.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire4App.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaire4AppEN.QuestionNo = objRow[convQuestionnaire4App.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire4App.QuestionNo].ToString().Trim(); //题目编号
objvQuestionnaire4AppEN.CourseId = objRow[convQuestionnaire4App.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire4App.CourseId].ToString().Trim(); //课程Id
objvQuestionnaire4AppEN.CourseCode = objRow[convQuestionnaire4App.CourseCode] == DBNull.Value ? null : objRow[convQuestionnaire4App.CourseCode].ToString().Trim(); //课程代码
objvQuestionnaire4AppEN.CourseName = objRow[convQuestionnaire4App.CourseName] == DBNull.Value ? null : objRow[convQuestionnaire4App.CourseName].ToString().Trim(); //课程名称
objvQuestionnaire4AppEN.CourseChapterId = objRow[convQuestionnaire4App.CourseChapterId] == DBNull.Value ? null : objRow[convQuestionnaire4App.CourseChapterId].ToString().Trim(); //课程章节ID
objvQuestionnaire4AppEN.ChapterId = objRow[convQuestionnaire4App.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire4App.ChapterId].ToString().Trim(); //章Id
objvQuestionnaire4AppEN.SectionId = objRow[convQuestionnaire4App.SectionId] == DBNull.Value ? null : objRow[convQuestionnaire4App.SectionId].ToString().Trim(); //节Id
objvQuestionnaire4AppEN.ChapterName = objRow[convQuestionnaire4App.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire4App.ChapterName].ToString().Trim(); //章名
objvQuestionnaire4AppEN.SectionName = objRow[convQuestionnaire4App.SectionName] == DBNull.Value ? null : objRow[convQuestionnaire4App.SectionName].ToString().Trim(); //节名
objvQuestionnaire4AppEN.ChapterNameSim = objRow[convQuestionnaire4App.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire4App.ChapterNameSim].ToString().Trim(); //章名简称
objvQuestionnaire4AppEN.SectionNameSim = objRow[convQuestionnaire4App.SectionNameSim] == DBNull.Value ? null : objRow[convQuestionnaire4App.SectionNameSim].ToString().Trim(); //节名简称
objvQuestionnaire4AppEN.ParentNodeId = objRow[convQuestionnaire4App.ParentNodeId] == DBNull.Value ? null : objRow[convQuestionnaire4App.ParentNodeId].ToString().Trim(); //父节点编号
objvQuestionnaire4AppEN.QuestionTypeId = objRow[convQuestionnaire4App.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire4App.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaire4AppEN.QuestionTypeName = objRow[convQuestionnaire4App.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionnaire4App.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionnaire4AppEN.ExamGradeId = objRow[convQuestionnaire4App.ExamGradeId] == DBNull.Value ? null : objRow[convQuestionnaire4App.ExamGradeId].ToString().Trim(); //题库等级ID
objvQuestionnaire4AppEN.ExamGradeName = objRow[convQuestionnaire4App.ExamGradeName] == DBNull.Value ? null : objRow[convQuestionnaire4App.ExamGradeName].ToString().Trim(); //题库等级名
objvQuestionnaire4AppEN.AnswerTypeId = objRow[convQuestionnaire4App.AnswerTypeId] == DBNull.Value ? null : objRow[convQuestionnaire4App.AnswerTypeId].ToString().Trim(); //答案类型ID
objvQuestionnaire4AppEN.QuestionScore = objRow[convQuestionnaire4App.QuestionScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convQuestionnaire4App.QuestionScore].ToString().Trim()); //题目得分
objvQuestionnaire4AppEN.UpdDate = objRow[convQuestionnaire4App.UpdDate].ToString().Trim(); //修改日期
objvQuestionnaire4AppEN.OptionNum = objRow[convQuestionnaire4App.OptionNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire4App.OptionNum].ToString().Trim()); //选项数
objvQuestionnaire4AppEN.ChapterOrderNum = objRow[convQuestionnaire4App.ChapterOrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire4App.ChapterOrderNum].ToString().Trim()); //章排序号
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvQuestionnaire4AppDA: GetObjByDataRow)", objException.Message));
}
objvQuestionnaire4AppEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQuestionnaire4AppEN;
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
objSQL = clsvQuestionnaire4AppDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvQuestionnaire4AppEN._CurrTabName, convQuestionnaire4App.QuestionId, 8, "");
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
objSQL = clsvQuestionnaire4AppDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvQuestionnaire4AppEN._CurrTabName, convQuestionnaire4App.QuestionId, 8, strPrefix);
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
 objSQL = clsvQuestionnaire4AppDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select QuestionId from vQuestionnaire4App where " + strCondition;
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
 objSQL = clsvQuestionnaire4AppDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select QuestionId from vQuestionnaire4App where " + strCondition;
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
 /// <param name = "lngQuestionId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngQuestionId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire4AppDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vQuestionnaire4App", "QuestionId = " + ""+ lngQuestionId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvQuestionnaire4AppDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire4AppDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vQuestionnaire4App", strCondition))
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
objSQL = clsvQuestionnaire4AppDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vQuestionnaire4App");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvQuestionnaire4AppENS">源对象</param>
 /// <param name = "objvQuestionnaire4AppENT">目标对象</param>
public void CopyTo(clsvQuestionnaire4AppEN objvQuestionnaire4AppENS, clsvQuestionnaire4AppEN objvQuestionnaire4AppENT)
{
objvQuestionnaire4AppENT.QuestionId = objvQuestionnaire4AppENS.QuestionId; //题目Id
objvQuestionnaire4AppENT.QuestionIndex = objvQuestionnaire4AppENS.QuestionIndex; //题目序号
objvQuestionnaire4AppENT.QuestionName = objvQuestionnaire4AppENS.QuestionName; //题目名称
objvQuestionnaire4AppENT.QuestionNo = objvQuestionnaire4AppENS.QuestionNo; //题目编号
objvQuestionnaire4AppENT.CourseId = objvQuestionnaire4AppENS.CourseId; //课程Id
objvQuestionnaire4AppENT.CourseCode = objvQuestionnaire4AppENS.CourseCode; //课程代码
objvQuestionnaire4AppENT.CourseName = objvQuestionnaire4AppENS.CourseName; //课程名称
objvQuestionnaire4AppENT.CourseChapterId = objvQuestionnaire4AppENS.CourseChapterId; //课程章节ID
objvQuestionnaire4AppENT.ChapterId = objvQuestionnaire4AppENS.ChapterId; //章Id
objvQuestionnaire4AppENT.SectionId = objvQuestionnaire4AppENS.SectionId; //节Id
objvQuestionnaire4AppENT.ChapterName = objvQuestionnaire4AppENS.ChapterName; //章名
objvQuestionnaire4AppENT.SectionName = objvQuestionnaire4AppENS.SectionName; //节名
objvQuestionnaire4AppENT.ChapterNameSim = objvQuestionnaire4AppENS.ChapterNameSim; //章名简称
objvQuestionnaire4AppENT.SectionNameSim = objvQuestionnaire4AppENS.SectionNameSim; //节名简称
objvQuestionnaire4AppENT.ParentNodeId = objvQuestionnaire4AppENS.ParentNodeId; //父节点编号
objvQuestionnaire4AppENT.QuestionTypeId = objvQuestionnaire4AppENS.QuestionTypeId; //题目类型Id
objvQuestionnaire4AppENT.QuestionTypeName = objvQuestionnaire4AppENS.QuestionTypeName; //题目类型名
objvQuestionnaire4AppENT.ExamGradeId = objvQuestionnaire4AppENS.ExamGradeId; //题库等级ID
objvQuestionnaire4AppENT.ExamGradeName = objvQuestionnaire4AppENS.ExamGradeName; //题库等级名
objvQuestionnaire4AppENT.AnswerTypeId = objvQuestionnaire4AppENS.AnswerTypeId; //答案类型ID
objvQuestionnaire4AppENT.QuestionScore = objvQuestionnaire4AppENS.QuestionScore; //题目得分
objvQuestionnaire4AppENT.UpdDate = objvQuestionnaire4AppENS.UpdDate; //修改日期
objvQuestionnaire4AppENT.OptionNum = objvQuestionnaire4AppENS.OptionNum; //选项数
objvQuestionnaire4AppENT.ChapterOrderNum = objvQuestionnaire4AppENS.ChapterOrderNum; //章排序号
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvQuestionnaire4AppEN objvQuestionnaire4AppEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvQuestionnaire4AppEN.QuestionName, 500, convQuestionnaire4App.QuestionName);
clsCheckSql.CheckFieldLen(objvQuestionnaire4AppEN.QuestionNo, 10, convQuestionnaire4App.QuestionNo);
clsCheckSql.CheckFieldLen(objvQuestionnaire4AppEN.CourseId, 8, convQuestionnaire4App.CourseId);
clsCheckSql.CheckFieldLen(objvQuestionnaire4AppEN.CourseCode, 20, convQuestionnaire4App.CourseCode);
clsCheckSql.CheckFieldLen(objvQuestionnaire4AppEN.CourseName, 100, convQuestionnaire4App.CourseName);
clsCheckSql.CheckFieldLen(objvQuestionnaire4AppEN.CourseChapterId, 8, convQuestionnaire4App.CourseChapterId);
clsCheckSql.CheckFieldLen(objvQuestionnaire4AppEN.ChapterId, 8, convQuestionnaire4App.ChapterId);
clsCheckSql.CheckFieldLen(objvQuestionnaire4AppEN.SectionId, 8, convQuestionnaire4App.SectionId);
clsCheckSql.CheckFieldLen(objvQuestionnaire4AppEN.ChapterName, 100, convQuestionnaire4App.ChapterName);
clsCheckSql.CheckFieldLen(objvQuestionnaire4AppEN.SectionName, 100, convQuestionnaire4App.SectionName);
clsCheckSql.CheckFieldLen(objvQuestionnaire4AppEN.ChapterNameSim, 10, convQuestionnaire4App.ChapterNameSim);
clsCheckSql.CheckFieldLen(objvQuestionnaire4AppEN.SectionNameSim, 10, convQuestionnaire4App.SectionNameSim);
clsCheckSql.CheckFieldLen(objvQuestionnaire4AppEN.ParentNodeId, 8, convQuestionnaire4App.ParentNodeId);
clsCheckSql.CheckFieldLen(objvQuestionnaire4AppEN.QuestionTypeId, 2, convQuestionnaire4App.QuestionTypeId);
clsCheckSql.CheckFieldLen(objvQuestionnaire4AppEN.QuestionTypeName, 20, convQuestionnaire4App.QuestionTypeName);
clsCheckSql.CheckFieldLen(objvQuestionnaire4AppEN.ExamGradeId, 2, convQuestionnaire4App.ExamGradeId);
clsCheckSql.CheckFieldLen(objvQuestionnaire4AppEN.ExamGradeName, 50, convQuestionnaire4App.ExamGradeName);
clsCheckSql.CheckFieldLen(objvQuestionnaire4AppEN.AnswerTypeId, 2, convQuestionnaire4App.AnswerTypeId);
clsCheckSql.CheckFieldLen(objvQuestionnaire4AppEN.UpdDate, 20, convQuestionnaire4App.UpdDate);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire4AppEN.QuestionName, convQuestionnaire4App.QuestionName);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire4AppEN.QuestionNo, convQuestionnaire4App.QuestionNo);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire4AppEN.CourseId, convQuestionnaire4App.CourseId);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire4AppEN.CourseCode, convQuestionnaire4App.CourseCode);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire4AppEN.CourseName, convQuestionnaire4App.CourseName);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire4AppEN.CourseChapterId, convQuestionnaire4App.CourseChapterId);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire4AppEN.ChapterId, convQuestionnaire4App.ChapterId);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire4AppEN.SectionId, convQuestionnaire4App.SectionId);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire4AppEN.ChapterName, convQuestionnaire4App.ChapterName);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire4AppEN.SectionName, convQuestionnaire4App.SectionName);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire4AppEN.ChapterNameSim, convQuestionnaire4App.ChapterNameSim);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire4AppEN.SectionNameSim, convQuestionnaire4App.SectionNameSim);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire4AppEN.ParentNodeId, convQuestionnaire4App.ParentNodeId);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire4AppEN.QuestionTypeId, convQuestionnaire4App.QuestionTypeId);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire4AppEN.QuestionTypeName, convQuestionnaire4App.QuestionTypeName);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire4AppEN.ExamGradeId, convQuestionnaire4App.ExamGradeId);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire4AppEN.ExamGradeName, convQuestionnaire4App.ExamGradeName);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire4AppEN.AnswerTypeId, convQuestionnaire4App.AnswerTypeId);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire4AppEN.UpdDate, convQuestionnaire4App.UpdDate);
//检查外键字段长度
 objvQuestionnaire4AppEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetQuestionId()
{
//获取某学院所有专业信息
string strSQL = "select QuestionId, QuestionName from vQuestionnaire4App ";
 clsSpecSQLforSql mySql = clsvQuestionnaire4AppDA.GetSpecSQLObj();
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
 objSQL = clsvQuestionnaire4AppDA.GetSpecSQLObj();
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
 objSQL = clsvQuestionnaire4AppDA.GetSpecSQLObj();
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
 objSQL = clsvQuestionnaire4AppDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvQuestionnaire4AppEN._CurrTabName);
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
 objSQL = clsvQuestionnaire4AppDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvQuestionnaire4AppEN._CurrTabName, strCondition);
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
 objSQL = clsvQuestionnaire4AppDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}