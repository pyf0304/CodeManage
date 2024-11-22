
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_CourseChapterDA
 表名:cc_CourseChapter(01120060)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:01:56
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关(Knowledges)
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
 /// 课程章节(cc_CourseChapter)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clscc_CourseChapterDA : clsCommBase4DA
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
 return clscc_CourseChapterEN._CurrTabName;
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
if (string.IsNullOrEmpty(clscc_CourseChapterEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clscc_CourseChapterEN._ConnectString);
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
 if (string.IsNullOrEmpty(clscc_CourseChapterEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clscc_CourseChapterEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strCourseChapterId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strCourseChapterId)
{
strCourseChapterId = strCourseChapterId.Replace("'", "''");
if (strCourseChapterId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:cc_CourseChapter中,检查关键字,长度不正确!(clscc_CourseChapterDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strCourseChapterId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:cc_CourseChapter中,关键字不能为空 或 null!(clscc_CourseChapterDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCourseChapterId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clscc_CourseChapterDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clscc_CourseChapterDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseChapterDA.GetSpecSQLObj();
strSQL = "Select * from cc_CourseChapter where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_cc_CourseChapter(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clscc_CourseChapterDA: GetDataTable_cc_CourseChapter)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseChapterDA.GetSpecSQLObj();
strSQL = "Select * from cc_CourseChapter where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clscc_CourseChapterDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseChapterDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clscc_CourseChapterDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseChapterDA.GetSpecSQLObj();
strSQL = "Select * from cc_CourseChapter where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clscc_CourseChapterDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseChapterDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clscc_CourseChapterDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseChapterDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from cc_CourseChapter where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from cc_CourseChapter where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clscc_CourseChapterDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseChapterDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from cc_CourseChapter where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clscc_CourseChapterDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseChapterDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} cc_CourseChapter.* from cc_CourseChapter Left Join {1} on {2} where {3} and cc_CourseChapter.CourseChapterId not in (Select top {5} cc_CourseChapter.CourseChapterId from cc_CourseChapter Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from cc_CourseChapter where {1} and CourseChapterId not in (Select top {2} CourseChapterId from cc_CourseChapter where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from cc_CourseChapter where {1} and CourseChapterId not in (Select top {3} CourseChapterId from cc_CourseChapter where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clscc_CourseChapterDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseChapterDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} cc_CourseChapter.* from cc_CourseChapter Left Join {1} on {2} where {3} and cc_CourseChapter.CourseChapterId not in (Select top {5} cc_CourseChapter.CourseChapterId from cc_CourseChapter Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from cc_CourseChapter where {1} and CourseChapterId not in (Select top {2} CourseChapterId from cc_CourseChapter where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from cc_CourseChapter where {1} and CourseChapterId not in (Select top {3} CourseChapterId from cc_CourseChapter where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clscc_CourseChapterEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clscc_CourseChapterDA:GetObjLst)", objException.Message));
}
List<clscc_CourseChapterEN> arrObjLst = new List<clscc_CourseChapterEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseChapterDA.GetSpecSQLObj();
strSQL = "Select * from cc_CourseChapter where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseChapterEN objcc_CourseChapterEN = new clscc_CourseChapterEN();
try
{
objcc_CourseChapterEN.CourseChapterId = objRow[concc_CourseChapter.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_CourseChapterEN.CourseChapterName = objRow[concc_CourseChapter.CourseChapterName].ToString().Trim(); //课程章节名称
objcc_CourseChapterEN.ChapterId = objRow[concc_CourseChapter.ChapterId] == DBNull.Value ? null : objRow[concc_CourseChapter.ChapterId].ToString().Trim(); //章Id
objcc_CourseChapterEN.SectionId = objRow[concc_CourseChapter.SectionId] == DBNull.Value ? null : objRow[concc_CourseChapter.SectionId].ToString().Trim(); //节Id
objcc_CourseChapterEN.ChapterName = objRow[concc_CourseChapter.ChapterName] == DBNull.Value ? null : objRow[concc_CourseChapter.ChapterName].ToString().Trim(); //章名
objcc_CourseChapterEN.SectionName = objRow[concc_CourseChapter.SectionName] == DBNull.Value ? null : objRow[concc_CourseChapter.SectionName].ToString().Trim(); //节名
objcc_CourseChapterEN.ChapterNameSim = objRow[concc_CourseChapter.ChapterNameSim] == DBNull.Value ? null : objRow[concc_CourseChapter.ChapterNameSim].ToString().Trim(); //章名简称
objcc_CourseChapterEN.SectionNameSim = objRow[concc_CourseChapter.SectionNameSim] == DBNull.Value ? null : objRow[concc_CourseChapter.SectionNameSim].ToString().Trim(); //节名简称
objcc_CourseChapterEN.ChapterContent = objRow[concc_CourseChapter.ChapterContent] == DBNull.Value ? null : objRow[concc_CourseChapter.ChapterContent].ToString().Trim(); //章节内容
objcc_CourseChapterEN.CourseId = objRow[concc_CourseChapter.CourseId].ToString().Trim(); //课程Id
objcc_CourseChapterEN.ParentNodeId = objRow[concc_CourseChapter.ParentNodeId].ToString().Trim(); //父节点编号
objcc_CourseChapterEN.IsOpenToAllStu = TransNullToBool(objRow[concc_CourseChapter.IsOpenToAllStu].ToString().Trim()); //全校师生
objcc_CourseChapterEN.IsOpenToSchool = TransNullToBool(objRow[concc_CourseChapter.IsOpenToSchool].ToString().Trim()); //全校师生公开
objcc_CourseChapterEN.IsOpenToSocial = TransNullToBool(objRow[concc_CourseChapter.IsOpenToSocial].ToString().Trim()); //社会公众
objcc_CourseChapterEN.IsMustMenu = TransNullToBool(objRow[concc_CourseChapter.IsMustMenu].ToString().Trim()); //是否必建栏目
objcc_CourseChapterEN.ThemeName = objRow[concc_CourseChapter.ThemeName] == DBNull.Value ? null : objRow[concc_CourseChapter.ThemeName].ToString().Trim(); //主题名
objcc_CourseChapterEN.IsFile = TransNullToBool(objRow[concc_CourseChapter.IsFile].ToString().Trim()); //项目或文件夹
objcc_CourseChapterEN.IsUse = TransNullToBool(objRow[concc_CourseChapter.IsUse].ToString().Trim()); //是否使用
objcc_CourseChapterEN.ViewCount = objRow[concc_CourseChapter.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_CourseChapter.ViewCount].ToString().Trim()); //浏览量
objcc_CourseChapterEN.CourseChapterReferred = objRow[concc_CourseChapter.CourseChapterReferred] == DBNull.Value ? null : objRow[concc_CourseChapter.CourseChapterReferred].ToString().Trim(); //节简称
objcc_CourseChapterEN.OrderNum = objRow[concc_CourseChapter.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_CourseChapter.OrderNum].ToString().Trim()); //序号
objcc_CourseChapterEN.CreateDate = objRow[concc_CourseChapter.CreateDate] == DBNull.Value ? null : objRow[concc_CourseChapter.CreateDate].ToString().Trim(); //建立日期
objcc_CourseChapterEN.EditPeople = objRow[concc_CourseChapter.EditPeople] == DBNull.Value ? null : objRow[concc_CourseChapter.EditPeople].ToString().Trim(); //修改人
objcc_CourseChapterEN.UpdDate = objRow[concc_CourseChapter.UpdDate] == DBNull.Value ? null : objRow[concc_CourseChapter.UpdDate].ToString().Trim(); //修改日期
objcc_CourseChapterEN.Memo = objRow[concc_CourseChapter.Memo] == DBNull.Value ? null : objRow[concc_CourseChapter.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clscc_CourseChapterDA: GetObjLst)", objException.Message));
}
objcc_CourseChapterEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objcc_CourseChapterEN);
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
public List<clscc_CourseChapterEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clscc_CourseChapterDA:GetObjLstByTabName)", objException.Message));
}
List<clscc_CourseChapterEN> arrObjLst = new List<clscc_CourseChapterEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseChapterDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseChapterEN objcc_CourseChapterEN = new clscc_CourseChapterEN();
try
{
objcc_CourseChapterEN.CourseChapterId = objRow[concc_CourseChapter.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_CourseChapterEN.CourseChapterName = objRow[concc_CourseChapter.CourseChapterName].ToString().Trim(); //课程章节名称
objcc_CourseChapterEN.ChapterId = objRow[concc_CourseChapter.ChapterId] == DBNull.Value ? null : objRow[concc_CourseChapter.ChapterId].ToString().Trim(); //章Id
objcc_CourseChapterEN.SectionId = objRow[concc_CourseChapter.SectionId] == DBNull.Value ? null : objRow[concc_CourseChapter.SectionId].ToString().Trim(); //节Id
objcc_CourseChapterEN.ChapterName = objRow[concc_CourseChapter.ChapterName] == DBNull.Value ? null : objRow[concc_CourseChapter.ChapterName].ToString().Trim(); //章名
objcc_CourseChapterEN.SectionName = objRow[concc_CourseChapter.SectionName] == DBNull.Value ? null : objRow[concc_CourseChapter.SectionName].ToString().Trim(); //节名
objcc_CourseChapterEN.ChapterNameSim = objRow[concc_CourseChapter.ChapterNameSim] == DBNull.Value ? null : objRow[concc_CourseChapter.ChapterNameSim].ToString().Trim(); //章名简称
objcc_CourseChapterEN.SectionNameSim = objRow[concc_CourseChapter.SectionNameSim] == DBNull.Value ? null : objRow[concc_CourseChapter.SectionNameSim].ToString().Trim(); //节名简称
objcc_CourseChapterEN.ChapterContent = objRow[concc_CourseChapter.ChapterContent] == DBNull.Value ? null : objRow[concc_CourseChapter.ChapterContent].ToString().Trim(); //章节内容
objcc_CourseChapterEN.CourseId = objRow[concc_CourseChapter.CourseId].ToString().Trim(); //课程Id
objcc_CourseChapterEN.ParentNodeId = objRow[concc_CourseChapter.ParentNodeId].ToString().Trim(); //父节点编号
objcc_CourseChapterEN.IsOpenToAllStu = TransNullToBool(objRow[concc_CourseChapter.IsOpenToAllStu].ToString().Trim()); //全校师生
objcc_CourseChapterEN.IsOpenToSchool = TransNullToBool(objRow[concc_CourseChapter.IsOpenToSchool].ToString().Trim()); //全校师生公开
objcc_CourseChapterEN.IsOpenToSocial = TransNullToBool(objRow[concc_CourseChapter.IsOpenToSocial].ToString().Trim()); //社会公众
objcc_CourseChapterEN.IsMustMenu = TransNullToBool(objRow[concc_CourseChapter.IsMustMenu].ToString().Trim()); //是否必建栏目
objcc_CourseChapterEN.ThemeName = objRow[concc_CourseChapter.ThemeName] == DBNull.Value ? null : objRow[concc_CourseChapter.ThemeName].ToString().Trim(); //主题名
objcc_CourseChapterEN.IsFile = TransNullToBool(objRow[concc_CourseChapter.IsFile].ToString().Trim()); //项目或文件夹
objcc_CourseChapterEN.IsUse = TransNullToBool(objRow[concc_CourseChapter.IsUse].ToString().Trim()); //是否使用
objcc_CourseChapterEN.ViewCount = objRow[concc_CourseChapter.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_CourseChapter.ViewCount].ToString().Trim()); //浏览量
objcc_CourseChapterEN.CourseChapterReferred = objRow[concc_CourseChapter.CourseChapterReferred] == DBNull.Value ? null : objRow[concc_CourseChapter.CourseChapterReferred].ToString().Trim(); //节简称
objcc_CourseChapterEN.OrderNum = objRow[concc_CourseChapter.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_CourseChapter.OrderNum].ToString().Trim()); //序号
objcc_CourseChapterEN.CreateDate = objRow[concc_CourseChapter.CreateDate] == DBNull.Value ? null : objRow[concc_CourseChapter.CreateDate].ToString().Trim(); //建立日期
objcc_CourseChapterEN.EditPeople = objRow[concc_CourseChapter.EditPeople] == DBNull.Value ? null : objRow[concc_CourseChapter.EditPeople].ToString().Trim(); //修改人
objcc_CourseChapterEN.UpdDate = objRow[concc_CourseChapter.UpdDate] == DBNull.Value ? null : objRow[concc_CourseChapter.UpdDate].ToString().Trim(); //修改日期
objcc_CourseChapterEN.Memo = objRow[concc_CourseChapter.Memo] == DBNull.Value ? null : objRow[concc_CourseChapter.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clscc_CourseChapterDA: GetObjLst)", objException.Message));
}
objcc_CourseChapterEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objcc_CourseChapterEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objcc_CourseChapterEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getcc_CourseChapter(ref clscc_CourseChapterEN objcc_CourseChapterEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseChapterDA.GetSpecSQLObj();
strSQL = "Select * from cc_CourseChapter where CourseChapterId = " + "'"+ objcc_CourseChapterEN.CourseChapterId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objcc_CourseChapterEN.CourseChapterId = objDT.Rows[0][concc_CourseChapter.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objcc_CourseChapterEN.CourseChapterName = objDT.Rows[0][concc_CourseChapter.CourseChapterName].ToString().Trim(); //课程章节名称(字段类型:varchar,字段长度:100,是否可空:False)
 objcc_CourseChapterEN.ChapterId = objDT.Rows[0][concc_CourseChapter.ChapterId].ToString().Trim(); //章Id(字段类型:char,字段长度:8,是否可空:True)
 objcc_CourseChapterEN.SectionId = objDT.Rows[0][concc_CourseChapter.SectionId].ToString().Trim(); //节Id(字段类型:char,字段长度:8,是否可空:True)
 objcc_CourseChapterEN.ChapterName = objDT.Rows[0][concc_CourseChapter.ChapterName].ToString().Trim(); //章名(字段类型:varchar,字段长度:100,是否可空:True)
 objcc_CourseChapterEN.SectionName = objDT.Rows[0][concc_CourseChapter.SectionName].ToString().Trim(); //节名(字段类型:varchar,字段长度:100,是否可空:True)
 objcc_CourseChapterEN.ChapterNameSim = objDT.Rows[0][concc_CourseChapter.ChapterNameSim].ToString().Trim(); //章名简称(字段类型:varchar,字段长度:10,是否可空:True)
 objcc_CourseChapterEN.SectionNameSim = objDT.Rows[0][concc_CourseChapter.SectionNameSim].ToString().Trim(); //节名简称(字段类型:varchar,字段长度:10,是否可空:True)
 objcc_CourseChapterEN.ChapterContent = objDT.Rows[0][concc_CourseChapter.ChapterContent].ToString().Trim(); //章节内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objcc_CourseChapterEN.CourseId = objDT.Rows[0][concc_CourseChapter.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objcc_CourseChapterEN.ParentNodeId = objDT.Rows[0][concc_CourseChapter.ParentNodeId].ToString().Trim(); //父节点编号(字段类型:varchar,字段长度:8,是否可空:True)
 objcc_CourseChapterEN.IsOpenToAllStu = TransNullToBool(objDT.Rows[0][concc_CourseChapter.IsOpenToAllStu].ToString().Trim()); //全校师生(字段类型:bit,字段长度:1,是否可空:True)
 objcc_CourseChapterEN.IsOpenToSchool = TransNullToBool(objDT.Rows[0][concc_CourseChapter.IsOpenToSchool].ToString().Trim()); //全校师生公开(字段类型:bit,字段长度:1,是否可空:True)
 objcc_CourseChapterEN.IsOpenToSocial = TransNullToBool(objDT.Rows[0][concc_CourseChapter.IsOpenToSocial].ToString().Trim()); //社会公众(字段类型:bit,字段长度:1,是否可空:True)
 objcc_CourseChapterEN.IsMustMenu = TransNullToBool(objDT.Rows[0][concc_CourseChapter.IsMustMenu].ToString().Trim()); //是否必建栏目(字段类型:bit,字段长度:1,是否可空:True)
 objcc_CourseChapterEN.ThemeName = objDT.Rows[0][concc_CourseChapter.ThemeName].ToString().Trim(); //主题名(字段类型:varchar,字段长度:200,是否可空:False)
 objcc_CourseChapterEN.IsFile = TransNullToBool(objDT.Rows[0][concc_CourseChapter.IsFile].ToString().Trim()); //项目或文件夹(字段类型:bit,字段长度:1,是否可空:True)
 objcc_CourseChapterEN.IsUse = TransNullToBool(objDT.Rows[0][concc_CourseChapter.IsUse].ToString().Trim()); //是否使用(字段类型:bit,字段长度:1,是否可空:True)
 objcc_CourseChapterEN.ViewCount = TransNullToInt(objDT.Rows[0][concc_CourseChapter.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objcc_CourseChapterEN.CourseChapterReferred = objDT.Rows[0][concc_CourseChapter.CourseChapterReferred].ToString().Trim(); //节简称(字段类型:varchar,字段长度:10,是否可空:True)
 objcc_CourseChapterEN.OrderNum = TransNullToInt(objDT.Rows[0][concc_CourseChapter.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objcc_CourseChapterEN.CreateDate = objDT.Rows[0][concc_CourseChapter.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_CourseChapterEN.EditPeople = objDT.Rows[0][concc_CourseChapter.EditPeople].ToString().Trim(); //修改人(字段类型:varchar,字段长度:50,是否可空:True)
 objcc_CourseChapterEN.UpdDate = objDT.Rows[0][concc_CourseChapter.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_CourseChapterEN.Memo = objDT.Rows[0][concc_CourseChapter.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clscc_CourseChapterDA: Getcc_CourseChapter)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strCourseChapterId">表关键字</param>
 /// <returns>表对象</returns>
public clscc_CourseChapterEN GetObjByCourseChapterId(string strCourseChapterId)
{
CheckPrimaryKey(strCourseChapterId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseChapterDA.GetSpecSQLObj();
strSQL = "Select * from cc_CourseChapter where CourseChapterId = " + "'"+ strCourseChapterId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clscc_CourseChapterEN objcc_CourseChapterEN = new clscc_CourseChapterEN();
try
{
 objcc_CourseChapterEN.CourseChapterId = objRow[concc_CourseChapter.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objcc_CourseChapterEN.CourseChapterName = objRow[concc_CourseChapter.CourseChapterName].ToString().Trim(); //课程章节名称(字段类型:varchar,字段长度:100,是否可空:False)
 objcc_CourseChapterEN.ChapterId = objRow[concc_CourseChapter.ChapterId] == DBNull.Value ? null : objRow[concc_CourseChapter.ChapterId].ToString().Trim(); //章Id(字段类型:char,字段长度:8,是否可空:True)
 objcc_CourseChapterEN.SectionId = objRow[concc_CourseChapter.SectionId] == DBNull.Value ? null : objRow[concc_CourseChapter.SectionId].ToString().Trim(); //节Id(字段类型:char,字段长度:8,是否可空:True)
 objcc_CourseChapterEN.ChapterName = objRow[concc_CourseChapter.ChapterName] == DBNull.Value ? null : objRow[concc_CourseChapter.ChapterName].ToString().Trim(); //章名(字段类型:varchar,字段长度:100,是否可空:True)
 objcc_CourseChapterEN.SectionName = objRow[concc_CourseChapter.SectionName] == DBNull.Value ? null : objRow[concc_CourseChapter.SectionName].ToString().Trim(); //节名(字段类型:varchar,字段长度:100,是否可空:True)
 objcc_CourseChapterEN.ChapterNameSim = objRow[concc_CourseChapter.ChapterNameSim] == DBNull.Value ? null : objRow[concc_CourseChapter.ChapterNameSim].ToString().Trim(); //章名简称(字段类型:varchar,字段长度:10,是否可空:True)
 objcc_CourseChapterEN.SectionNameSim = objRow[concc_CourseChapter.SectionNameSim] == DBNull.Value ? null : objRow[concc_CourseChapter.SectionNameSim].ToString().Trim(); //节名简称(字段类型:varchar,字段长度:10,是否可空:True)
 objcc_CourseChapterEN.ChapterContent = objRow[concc_CourseChapter.ChapterContent] == DBNull.Value ? null : objRow[concc_CourseChapter.ChapterContent].ToString().Trim(); //章节内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objcc_CourseChapterEN.CourseId = objRow[concc_CourseChapter.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objcc_CourseChapterEN.ParentNodeId = objRow[concc_CourseChapter.ParentNodeId].ToString().Trim(); //父节点编号(字段类型:varchar,字段长度:8,是否可空:True)
 objcc_CourseChapterEN.IsOpenToAllStu = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseChapter.IsOpenToAllStu].ToString().Trim()); //全校师生(字段类型:bit,字段长度:1,是否可空:True)
 objcc_CourseChapterEN.IsOpenToSchool = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseChapter.IsOpenToSchool].ToString().Trim()); //全校师生公开(字段类型:bit,字段长度:1,是否可空:True)
 objcc_CourseChapterEN.IsOpenToSocial = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseChapter.IsOpenToSocial].ToString().Trim()); //社会公众(字段类型:bit,字段长度:1,是否可空:True)
 objcc_CourseChapterEN.IsMustMenu = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseChapter.IsMustMenu].ToString().Trim()); //是否必建栏目(字段类型:bit,字段长度:1,是否可空:True)
 objcc_CourseChapterEN.ThemeName = objRow[concc_CourseChapter.ThemeName] == DBNull.Value ? null : objRow[concc_CourseChapter.ThemeName].ToString().Trim(); //主题名(字段类型:varchar,字段长度:200,是否可空:False)
 objcc_CourseChapterEN.IsFile = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseChapter.IsFile].ToString().Trim()); //项目或文件夹(字段类型:bit,字段长度:1,是否可空:True)
 objcc_CourseChapterEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseChapter.IsUse].ToString().Trim()); //是否使用(字段类型:bit,字段长度:1,是否可空:True)
 objcc_CourseChapterEN.ViewCount = objRow[concc_CourseChapter.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseChapter.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objcc_CourseChapterEN.CourseChapterReferred = objRow[concc_CourseChapter.CourseChapterReferred] == DBNull.Value ? null : objRow[concc_CourseChapter.CourseChapterReferred].ToString().Trim(); //节简称(字段类型:varchar,字段长度:10,是否可空:True)
 objcc_CourseChapterEN.OrderNum = objRow[concc_CourseChapter.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseChapter.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objcc_CourseChapterEN.CreateDate = objRow[concc_CourseChapter.CreateDate] == DBNull.Value ? null : objRow[concc_CourseChapter.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_CourseChapterEN.EditPeople = objRow[concc_CourseChapter.EditPeople] == DBNull.Value ? null : objRow[concc_CourseChapter.EditPeople].ToString().Trim(); //修改人(字段类型:varchar,字段长度:50,是否可空:True)
 objcc_CourseChapterEN.UpdDate = objRow[concc_CourseChapter.UpdDate] == DBNull.Value ? null : objRow[concc_CourseChapter.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_CourseChapterEN.Memo = objRow[concc_CourseChapter.Memo] == DBNull.Value ? null : objRow[concc_CourseChapter.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clscc_CourseChapterDA: GetObjByCourseChapterId)", objException.Message));
}
return objcc_CourseChapterEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clscc_CourseChapterEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clscc_CourseChapterDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseChapterDA.GetSpecSQLObj();
strSQL = "Select * from cc_CourseChapter where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clscc_CourseChapterEN objcc_CourseChapterEN = new clscc_CourseChapterEN()
{
CourseChapterId = objRow[concc_CourseChapter.CourseChapterId].ToString().Trim(), //课程章节ID
CourseChapterName = objRow[concc_CourseChapter.CourseChapterName].ToString().Trim(), //课程章节名称
ChapterId = objRow[concc_CourseChapter.ChapterId] == DBNull.Value ? null : objRow[concc_CourseChapter.ChapterId].ToString().Trim(), //章Id
SectionId = objRow[concc_CourseChapter.SectionId] == DBNull.Value ? null : objRow[concc_CourseChapter.SectionId].ToString().Trim(), //节Id
ChapterName = objRow[concc_CourseChapter.ChapterName] == DBNull.Value ? null : objRow[concc_CourseChapter.ChapterName].ToString().Trim(), //章名
SectionName = objRow[concc_CourseChapter.SectionName] == DBNull.Value ? null : objRow[concc_CourseChapter.SectionName].ToString().Trim(), //节名
ChapterNameSim = objRow[concc_CourseChapter.ChapterNameSim] == DBNull.Value ? null : objRow[concc_CourseChapter.ChapterNameSim].ToString().Trim(), //章名简称
SectionNameSim = objRow[concc_CourseChapter.SectionNameSim] == DBNull.Value ? null : objRow[concc_CourseChapter.SectionNameSim].ToString().Trim(), //节名简称
ChapterContent = objRow[concc_CourseChapter.ChapterContent] == DBNull.Value ? null : objRow[concc_CourseChapter.ChapterContent].ToString().Trim(), //章节内容
CourseId = objRow[concc_CourseChapter.CourseId].ToString().Trim(), //课程Id
ParentNodeId = objRow[concc_CourseChapter.ParentNodeId].ToString().Trim(), //父节点编号
IsOpenToAllStu = TransNullToBool(objRow[concc_CourseChapter.IsOpenToAllStu].ToString().Trim()), //全校师生
IsOpenToSchool = TransNullToBool(objRow[concc_CourseChapter.IsOpenToSchool].ToString().Trim()), //全校师生公开
IsOpenToSocial = TransNullToBool(objRow[concc_CourseChapter.IsOpenToSocial].ToString().Trim()), //社会公众
IsMustMenu = TransNullToBool(objRow[concc_CourseChapter.IsMustMenu].ToString().Trim()), //是否必建栏目
ThemeName = objRow[concc_CourseChapter.ThemeName] == DBNull.Value ? null : objRow[concc_CourseChapter.ThemeName].ToString().Trim(), //主题名
IsFile = TransNullToBool(objRow[concc_CourseChapter.IsFile].ToString().Trim()), //项目或文件夹
IsUse = TransNullToBool(objRow[concc_CourseChapter.IsUse].ToString().Trim()), //是否使用
ViewCount = objRow[concc_CourseChapter.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_CourseChapter.ViewCount].ToString().Trim()), //浏览量
CourseChapterReferred = objRow[concc_CourseChapter.CourseChapterReferred] == DBNull.Value ? null : objRow[concc_CourseChapter.CourseChapterReferred].ToString().Trim(), //节简称
OrderNum = objRow[concc_CourseChapter.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_CourseChapter.OrderNum].ToString().Trim()), //序号
CreateDate = objRow[concc_CourseChapter.CreateDate] == DBNull.Value ? null : objRow[concc_CourseChapter.CreateDate].ToString().Trim(), //建立日期
EditPeople = objRow[concc_CourseChapter.EditPeople] == DBNull.Value ? null : objRow[concc_CourseChapter.EditPeople].ToString().Trim(), //修改人
UpdDate = objRow[concc_CourseChapter.UpdDate] == DBNull.Value ? null : objRow[concc_CourseChapter.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[concc_CourseChapter.Memo] == DBNull.Value ? null : objRow[concc_CourseChapter.Memo].ToString().Trim() //备注
};
objcc_CourseChapterEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcc_CourseChapterEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clscc_CourseChapterDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clscc_CourseChapterEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clscc_CourseChapterEN objcc_CourseChapterEN = new clscc_CourseChapterEN();
try
{
objcc_CourseChapterEN.CourseChapterId = objRow[concc_CourseChapter.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_CourseChapterEN.CourseChapterName = objRow[concc_CourseChapter.CourseChapterName].ToString().Trim(); //课程章节名称
objcc_CourseChapterEN.ChapterId = objRow[concc_CourseChapter.ChapterId] == DBNull.Value ? null : objRow[concc_CourseChapter.ChapterId].ToString().Trim(); //章Id
objcc_CourseChapterEN.SectionId = objRow[concc_CourseChapter.SectionId] == DBNull.Value ? null : objRow[concc_CourseChapter.SectionId].ToString().Trim(); //节Id
objcc_CourseChapterEN.ChapterName = objRow[concc_CourseChapter.ChapterName] == DBNull.Value ? null : objRow[concc_CourseChapter.ChapterName].ToString().Trim(); //章名
objcc_CourseChapterEN.SectionName = objRow[concc_CourseChapter.SectionName] == DBNull.Value ? null : objRow[concc_CourseChapter.SectionName].ToString().Trim(); //节名
objcc_CourseChapterEN.ChapterNameSim = objRow[concc_CourseChapter.ChapterNameSim] == DBNull.Value ? null : objRow[concc_CourseChapter.ChapterNameSim].ToString().Trim(); //章名简称
objcc_CourseChapterEN.SectionNameSim = objRow[concc_CourseChapter.SectionNameSim] == DBNull.Value ? null : objRow[concc_CourseChapter.SectionNameSim].ToString().Trim(); //节名简称
objcc_CourseChapterEN.ChapterContent = objRow[concc_CourseChapter.ChapterContent] == DBNull.Value ? null : objRow[concc_CourseChapter.ChapterContent].ToString().Trim(); //章节内容
objcc_CourseChapterEN.CourseId = objRow[concc_CourseChapter.CourseId].ToString().Trim(); //课程Id
objcc_CourseChapterEN.ParentNodeId = objRow[concc_CourseChapter.ParentNodeId].ToString().Trim(); //父节点编号
objcc_CourseChapterEN.IsOpenToAllStu = TransNullToBool(objRow[concc_CourseChapter.IsOpenToAllStu].ToString().Trim()); //全校师生
objcc_CourseChapterEN.IsOpenToSchool = TransNullToBool(objRow[concc_CourseChapter.IsOpenToSchool].ToString().Trim()); //全校师生公开
objcc_CourseChapterEN.IsOpenToSocial = TransNullToBool(objRow[concc_CourseChapter.IsOpenToSocial].ToString().Trim()); //社会公众
objcc_CourseChapterEN.IsMustMenu = TransNullToBool(objRow[concc_CourseChapter.IsMustMenu].ToString().Trim()); //是否必建栏目
objcc_CourseChapterEN.ThemeName = objRow[concc_CourseChapter.ThemeName] == DBNull.Value ? null : objRow[concc_CourseChapter.ThemeName].ToString().Trim(); //主题名
objcc_CourseChapterEN.IsFile = TransNullToBool(objRow[concc_CourseChapter.IsFile].ToString().Trim()); //项目或文件夹
objcc_CourseChapterEN.IsUse = TransNullToBool(objRow[concc_CourseChapter.IsUse].ToString().Trim()); //是否使用
objcc_CourseChapterEN.ViewCount = objRow[concc_CourseChapter.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_CourseChapter.ViewCount].ToString().Trim()); //浏览量
objcc_CourseChapterEN.CourseChapterReferred = objRow[concc_CourseChapter.CourseChapterReferred] == DBNull.Value ? null : objRow[concc_CourseChapter.CourseChapterReferred].ToString().Trim(); //节简称
objcc_CourseChapterEN.OrderNum = objRow[concc_CourseChapter.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_CourseChapter.OrderNum].ToString().Trim()); //序号
objcc_CourseChapterEN.CreateDate = objRow[concc_CourseChapter.CreateDate] == DBNull.Value ? null : objRow[concc_CourseChapter.CreateDate].ToString().Trim(); //建立日期
objcc_CourseChapterEN.EditPeople = objRow[concc_CourseChapter.EditPeople] == DBNull.Value ? null : objRow[concc_CourseChapter.EditPeople].ToString().Trim(); //修改人
objcc_CourseChapterEN.UpdDate = objRow[concc_CourseChapter.UpdDate] == DBNull.Value ? null : objRow[concc_CourseChapter.UpdDate].ToString().Trim(); //修改日期
objcc_CourseChapterEN.Memo = objRow[concc_CourseChapter.Memo] == DBNull.Value ? null : objRow[concc_CourseChapter.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clscc_CourseChapterDA: GetObjByDataRowcc_CourseChapter)", objException.Message));
}
objcc_CourseChapterEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcc_CourseChapterEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clscc_CourseChapterEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clscc_CourseChapterEN objcc_CourseChapterEN = new clscc_CourseChapterEN();
try
{
objcc_CourseChapterEN.CourseChapterId = objRow[concc_CourseChapter.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_CourseChapterEN.CourseChapterName = objRow[concc_CourseChapter.CourseChapterName].ToString().Trim(); //课程章节名称
objcc_CourseChapterEN.ChapterId = objRow[concc_CourseChapter.ChapterId] == DBNull.Value ? null : objRow[concc_CourseChapter.ChapterId].ToString().Trim(); //章Id
objcc_CourseChapterEN.SectionId = objRow[concc_CourseChapter.SectionId] == DBNull.Value ? null : objRow[concc_CourseChapter.SectionId].ToString().Trim(); //节Id
objcc_CourseChapterEN.ChapterName = objRow[concc_CourseChapter.ChapterName] == DBNull.Value ? null : objRow[concc_CourseChapter.ChapterName].ToString().Trim(); //章名
objcc_CourseChapterEN.SectionName = objRow[concc_CourseChapter.SectionName] == DBNull.Value ? null : objRow[concc_CourseChapter.SectionName].ToString().Trim(); //节名
objcc_CourseChapterEN.ChapterNameSim = objRow[concc_CourseChapter.ChapterNameSim] == DBNull.Value ? null : objRow[concc_CourseChapter.ChapterNameSim].ToString().Trim(); //章名简称
objcc_CourseChapterEN.SectionNameSim = objRow[concc_CourseChapter.SectionNameSim] == DBNull.Value ? null : objRow[concc_CourseChapter.SectionNameSim].ToString().Trim(); //节名简称
objcc_CourseChapterEN.ChapterContent = objRow[concc_CourseChapter.ChapterContent] == DBNull.Value ? null : objRow[concc_CourseChapter.ChapterContent].ToString().Trim(); //章节内容
objcc_CourseChapterEN.CourseId = objRow[concc_CourseChapter.CourseId].ToString().Trim(); //课程Id
objcc_CourseChapterEN.ParentNodeId = objRow[concc_CourseChapter.ParentNodeId].ToString().Trim(); //父节点编号
objcc_CourseChapterEN.IsOpenToAllStu = TransNullToBool(objRow[concc_CourseChapter.IsOpenToAllStu].ToString().Trim()); //全校师生
objcc_CourseChapterEN.IsOpenToSchool = TransNullToBool(objRow[concc_CourseChapter.IsOpenToSchool].ToString().Trim()); //全校师生公开
objcc_CourseChapterEN.IsOpenToSocial = TransNullToBool(objRow[concc_CourseChapter.IsOpenToSocial].ToString().Trim()); //社会公众
objcc_CourseChapterEN.IsMustMenu = TransNullToBool(objRow[concc_CourseChapter.IsMustMenu].ToString().Trim()); //是否必建栏目
objcc_CourseChapterEN.ThemeName = objRow[concc_CourseChapter.ThemeName] == DBNull.Value ? null : objRow[concc_CourseChapter.ThemeName].ToString().Trim(); //主题名
objcc_CourseChapterEN.IsFile = TransNullToBool(objRow[concc_CourseChapter.IsFile].ToString().Trim()); //项目或文件夹
objcc_CourseChapterEN.IsUse = TransNullToBool(objRow[concc_CourseChapter.IsUse].ToString().Trim()); //是否使用
objcc_CourseChapterEN.ViewCount = objRow[concc_CourseChapter.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_CourseChapter.ViewCount].ToString().Trim()); //浏览量
objcc_CourseChapterEN.CourseChapterReferred = objRow[concc_CourseChapter.CourseChapterReferred] == DBNull.Value ? null : objRow[concc_CourseChapter.CourseChapterReferred].ToString().Trim(); //节简称
objcc_CourseChapterEN.OrderNum = objRow[concc_CourseChapter.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_CourseChapter.OrderNum].ToString().Trim()); //序号
objcc_CourseChapterEN.CreateDate = objRow[concc_CourseChapter.CreateDate] == DBNull.Value ? null : objRow[concc_CourseChapter.CreateDate].ToString().Trim(); //建立日期
objcc_CourseChapterEN.EditPeople = objRow[concc_CourseChapter.EditPeople] == DBNull.Value ? null : objRow[concc_CourseChapter.EditPeople].ToString().Trim(); //修改人
objcc_CourseChapterEN.UpdDate = objRow[concc_CourseChapter.UpdDate] == DBNull.Value ? null : objRow[concc_CourseChapter.UpdDate].ToString().Trim(); //修改日期
objcc_CourseChapterEN.Memo = objRow[concc_CourseChapter.Memo] == DBNull.Value ? null : objRow[concc_CourseChapter.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clscc_CourseChapterDA: GetObjByDataRow)", objException.Message));
}
objcc_CourseChapterEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcc_CourseChapterEN;
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
objSQL = clscc_CourseChapterDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clscc_CourseChapterEN._CurrTabName, concc_CourseChapter.CourseChapterId, 8, "");
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
objSQL = clscc_CourseChapterDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clscc_CourseChapterEN._CurrTabName, concc_CourseChapter.CourseChapterId, 8, strPrefix);
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
 objSQL = clscc_CourseChapterDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select CourseChapterId from cc_CourseChapter where " + strCondition;
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
 objSQL = clscc_CourseChapterDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select CourseChapterId from cc_CourseChapter where " + strCondition;
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
 /// <param name = "strCourseChapterId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strCourseChapterId)
{
CheckPrimaryKey(strCourseChapterId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseChapterDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("cc_CourseChapter", "CourseChapterId = " + "'"+ strCourseChapterId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clscc_CourseChapterDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseChapterDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("cc_CourseChapter", strCondition))
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
objSQL = clscc_CourseChapterDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("cc_CourseChapter");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clscc_CourseChapterEN objcc_CourseChapterEN)
 {
 if (objcc_CourseChapterEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_CourseChapterEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseChapterDA.GetSpecSQLObj();
strSQL = "Select * from cc_CourseChapter where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "cc_CourseChapter");
objRow = objDS.Tables["cc_CourseChapter"].NewRow();
objRow[concc_CourseChapter.CourseChapterId] = objcc_CourseChapterEN.CourseChapterId; //课程章节ID
objRow[concc_CourseChapter.CourseChapterName] = objcc_CourseChapterEN.CourseChapterName; //课程章节名称
 if (objcc_CourseChapterEN.ChapterId !=  "")
 {
objRow[concc_CourseChapter.ChapterId] = objcc_CourseChapterEN.ChapterId; //章Id
 }
 if (objcc_CourseChapterEN.SectionId !=  "")
 {
objRow[concc_CourseChapter.SectionId] = objcc_CourseChapterEN.SectionId; //节Id
 }
 if (objcc_CourseChapterEN.ChapterName !=  "")
 {
objRow[concc_CourseChapter.ChapterName] = objcc_CourseChapterEN.ChapterName; //章名
 }
 if (objcc_CourseChapterEN.SectionName !=  "")
 {
objRow[concc_CourseChapter.SectionName] = objcc_CourseChapterEN.SectionName; //节名
 }
 if (objcc_CourseChapterEN.ChapterNameSim !=  "")
 {
objRow[concc_CourseChapter.ChapterNameSim] = objcc_CourseChapterEN.ChapterNameSim; //章名简称
 }
 if (objcc_CourseChapterEN.SectionNameSim !=  "")
 {
objRow[concc_CourseChapter.SectionNameSim] = objcc_CourseChapterEN.SectionNameSim; //节名简称
 }
 if (objcc_CourseChapterEN.ChapterContent !=  "")
 {
objRow[concc_CourseChapter.ChapterContent] = objcc_CourseChapterEN.ChapterContent; //章节内容
 }
objRow[concc_CourseChapter.CourseId] = objcc_CourseChapterEN.CourseId; //课程Id
objRow[concc_CourseChapter.ParentNodeId] = objcc_CourseChapterEN.ParentNodeId; //父节点编号
objRow[concc_CourseChapter.IsOpenToAllStu] = objcc_CourseChapterEN.IsOpenToAllStu; //全校师生
objRow[concc_CourseChapter.IsOpenToSchool] = objcc_CourseChapterEN.IsOpenToSchool; //全校师生公开
objRow[concc_CourseChapter.IsOpenToSocial] = objcc_CourseChapterEN.IsOpenToSocial; //社会公众
objRow[concc_CourseChapter.IsMustMenu] = objcc_CourseChapterEN.IsMustMenu; //是否必建栏目
 if (objcc_CourseChapterEN.ThemeName !=  "")
 {
objRow[concc_CourseChapter.ThemeName] = objcc_CourseChapterEN.ThemeName; //主题名
 }
objRow[concc_CourseChapter.IsFile] = objcc_CourseChapterEN.IsFile; //项目或文件夹
objRow[concc_CourseChapter.IsUse] = objcc_CourseChapterEN.IsUse; //是否使用
objRow[concc_CourseChapter.ViewCount] = objcc_CourseChapterEN.ViewCount; //浏览量
 if (objcc_CourseChapterEN.CourseChapterReferred !=  "")
 {
objRow[concc_CourseChapter.CourseChapterReferred] = objcc_CourseChapterEN.CourseChapterReferred; //节简称
 }
objRow[concc_CourseChapter.OrderNum] = objcc_CourseChapterEN.OrderNum; //序号
 if (objcc_CourseChapterEN.CreateDate !=  "")
 {
objRow[concc_CourseChapter.CreateDate] = objcc_CourseChapterEN.CreateDate; //建立日期
 }
 if (objcc_CourseChapterEN.EditPeople !=  "")
 {
objRow[concc_CourseChapter.EditPeople] = objcc_CourseChapterEN.EditPeople; //修改人
 }
 if (objcc_CourseChapterEN.UpdDate !=  "")
 {
objRow[concc_CourseChapter.UpdDate] = objcc_CourseChapterEN.UpdDate; //修改日期
 }
 if (objcc_CourseChapterEN.Memo !=  "")
 {
objRow[concc_CourseChapter.Memo] = objcc_CourseChapterEN.Memo; //备注
 }
objDS.Tables[clscc_CourseChapterEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clscc_CourseChapterEN._CurrTabName);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
return true;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2)
 /// </summary>
 /// <param name = "objcc_CourseChapterEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clscc_CourseChapterEN objcc_CourseChapterEN)
{
 if (objcc_CourseChapterEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_CourseChapterEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objcc_CourseChapterEN.CourseChapterId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.CourseChapterId);
 var strCourseChapterId = objcc_CourseChapterEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseChapterId + "'");
 }
 
 if (objcc_CourseChapterEN.CourseChapterName !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.CourseChapterName);
 var strCourseChapterName = objcc_CourseChapterEN.CourseChapterName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseChapterName + "'");
 }
 
 if (objcc_CourseChapterEN.ChapterId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.ChapterId);
 var strChapterId = objcc_CourseChapterEN.ChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strChapterId + "'");
 }
 
 if (objcc_CourseChapterEN.SectionId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.SectionId);
 var strSectionId = objcc_CourseChapterEN.SectionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSectionId + "'");
 }
 
 if (objcc_CourseChapterEN.ChapterName !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.ChapterName);
 var strChapterName = objcc_CourseChapterEN.ChapterName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strChapterName + "'");
 }
 
 if (objcc_CourseChapterEN.SectionName !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.SectionName);
 var strSectionName = objcc_CourseChapterEN.SectionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSectionName + "'");
 }
 
 if (objcc_CourseChapterEN.ChapterNameSim !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.ChapterNameSim);
 var strChapterNameSim = objcc_CourseChapterEN.ChapterNameSim.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strChapterNameSim + "'");
 }
 
 if (objcc_CourseChapterEN.SectionNameSim !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.SectionNameSim);
 var strSectionNameSim = objcc_CourseChapterEN.SectionNameSim.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSectionNameSim + "'");
 }
 
 if (objcc_CourseChapterEN.ChapterContent !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.ChapterContent);
 var strChapterContent = objcc_CourseChapterEN.ChapterContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strChapterContent + "'");
 }
 
 if (objcc_CourseChapterEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.CourseId);
 var strCourseId = objcc_CourseChapterEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objcc_CourseChapterEN.ParentNodeId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.ParentNodeId);
 var strParentNodeId = objcc_CourseChapterEN.ParentNodeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParentNodeId + "'");
 }
 
 arrFieldListForInsert.Add(concc_CourseChapter.IsOpenToAllStu);
 arrValueListForInsert.Add("'" + (objcc_CourseChapterEN.IsOpenToAllStu  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_CourseChapter.IsOpenToSchool);
 arrValueListForInsert.Add("'" + (objcc_CourseChapterEN.IsOpenToSchool  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_CourseChapter.IsOpenToSocial);
 arrValueListForInsert.Add("'" + (objcc_CourseChapterEN.IsOpenToSocial  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_CourseChapter.IsMustMenu);
 arrValueListForInsert.Add("'" + (objcc_CourseChapterEN.IsMustMenu  ==  false ? "0" : "1") + "'");
 
 if (objcc_CourseChapterEN.ThemeName !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.ThemeName);
 var strThemeName = objcc_CourseChapterEN.ThemeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strThemeName + "'");
 }
 
 arrFieldListForInsert.Add(concc_CourseChapter.IsFile);
 arrValueListForInsert.Add("'" + (objcc_CourseChapterEN.IsFile  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_CourseChapter.IsUse);
 arrValueListForInsert.Add("'" + (objcc_CourseChapterEN.IsUse  ==  false ? "0" : "1") + "'");
 
 if (objcc_CourseChapterEN.ViewCount !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.ViewCount);
 arrValueListForInsert.Add(objcc_CourseChapterEN.ViewCount.ToString());
 }
 
 if (objcc_CourseChapterEN.CourseChapterReferred !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.CourseChapterReferred);
 var strCourseChapterReferred = objcc_CourseChapterEN.CourseChapterReferred.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseChapterReferred + "'");
 }
 
 if (objcc_CourseChapterEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.OrderNum);
 arrValueListForInsert.Add(objcc_CourseChapterEN.OrderNum.ToString());
 }
 
 if (objcc_CourseChapterEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.CreateDate);
 var strCreateDate = objcc_CourseChapterEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objcc_CourseChapterEN.EditPeople !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.EditPeople);
 var strEditPeople = objcc_CourseChapterEN.EditPeople.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEditPeople + "'");
 }
 
 if (objcc_CourseChapterEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.UpdDate);
 var strUpdDate = objcc_CourseChapterEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcc_CourseChapterEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.Memo);
 var strMemo = objcc_CourseChapterEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_CourseChapter");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseChapterDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objcc_CourseChapterEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clscc_CourseChapterEN objcc_CourseChapterEN)
{
 if (objcc_CourseChapterEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_CourseChapterEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objcc_CourseChapterEN.CourseChapterId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.CourseChapterId);
 var strCourseChapterId = objcc_CourseChapterEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseChapterId + "'");
 }
 
 if (objcc_CourseChapterEN.CourseChapterName !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.CourseChapterName);
 var strCourseChapterName = objcc_CourseChapterEN.CourseChapterName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseChapterName + "'");
 }
 
 if (objcc_CourseChapterEN.ChapterId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.ChapterId);
 var strChapterId = objcc_CourseChapterEN.ChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strChapterId + "'");
 }
 
 if (objcc_CourseChapterEN.SectionId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.SectionId);
 var strSectionId = objcc_CourseChapterEN.SectionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSectionId + "'");
 }
 
 if (objcc_CourseChapterEN.ChapterName !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.ChapterName);
 var strChapterName = objcc_CourseChapterEN.ChapterName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strChapterName + "'");
 }
 
 if (objcc_CourseChapterEN.SectionName !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.SectionName);
 var strSectionName = objcc_CourseChapterEN.SectionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSectionName + "'");
 }
 
 if (objcc_CourseChapterEN.ChapterNameSim !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.ChapterNameSim);
 var strChapterNameSim = objcc_CourseChapterEN.ChapterNameSim.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strChapterNameSim + "'");
 }
 
 if (objcc_CourseChapterEN.SectionNameSim !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.SectionNameSim);
 var strSectionNameSim = objcc_CourseChapterEN.SectionNameSim.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSectionNameSim + "'");
 }
 
 if (objcc_CourseChapterEN.ChapterContent !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.ChapterContent);
 var strChapterContent = objcc_CourseChapterEN.ChapterContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strChapterContent + "'");
 }
 
 if (objcc_CourseChapterEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.CourseId);
 var strCourseId = objcc_CourseChapterEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objcc_CourseChapterEN.ParentNodeId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.ParentNodeId);
 var strParentNodeId = objcc_CourseChapterEN.ParentNodeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParentNodeId + "'");
 }
 
 arrFieldListForInsert.Add(concc_CourseChapter.IsOpenToAllStu);
 arrValueListForInsert.Add("'" + (objcc_CourseChapterEN.IsOpenToAllStu  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_CourseChapter.IsOpenToSchool);
 arrValueListForInsert.Add("'" + (objcc_CourseChapterEN.IsOpenToSchool  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_CourseChapter.IsOpenToSocial);
 arrValueListForInsert.Add("'" + (objcc_CourseChapterEN.IsOpenToSocial  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_CourseChapter.IsMustMenu);
 arrValueListForInsert.Add("'" + (objcc_CourseChapterEN.IsMustMenu  ==  false ? "0" : "1") + "'");
 
 if (objcc_CourseChapterEN.ThemeName !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.ThemeName);
 var strThemeName = objcc_CourseChapterEN.ThemeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strThemeName + "'");
 }
 
 arrFieldListForInsert.Add(concc_CourseChapter.IsFile);
 arrValueListForInsert.Add("'" + (objcc_CourseChapterEN.IsFile  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_CourseChapter.IsUse);
 arrValueListForInsert.Add("'" + (objcc_CourseChapterEN.IsUse  ==  false ? "0" : "1") + "'");
 
 if (objcc_CourseChapterEN.ViewCount !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.ViewCount);
 arrValueListForInsert.Add(objcc_CourseChapterEN.ViewCount.ToString());
 }
 
 if (objcc_CourseChapterEN.CourseChapterReferred !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.CourseChapterReferred);
 var strCourseChapterReferred = objcc_CourseChapterEN.CourseChapterReferred.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseChapterReferred + "'");
 }
 
 if (objcc_CourseChapterEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.OrderNum);
 arrValueListForInsert.Add(objcc_CourseChapterEN.OrderNum.ToString());
 }
 
 if (objcc_CourseChapterEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.CreateDate);
 var strCreateDate = objcc_CourseChapterEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objcc_CourseChapterEN.EditPeople !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.EditPeople);
 var strEditPeople = objcc_CourseChapterEN.EditPeople.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEditPeople + "'");
 }
 
 if (objcc_CourseChapterEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.UpdDate);
 var strUpdDate = objcc_CourseChapterEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcc_CourseChapterEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.Memo);
 var strMemo = objcc_CourseChapterEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_CourseChapter");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseChapterDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objcc_CourseChapterEN.CourseChapterId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objcc_CourseChapterEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clscc_CourseChapterEN objcc_CourseChapterEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objcc_CourseChapterEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_CourseChapterEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objcc_CourseChapterEN.CourseChapterId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.CourseChapterId);
 var strCourseChapterId = objcc_CourseChapterEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseChapterId + "'");
 }
 
 if (objcc_CourseChapterEN.CourseChapterName !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.CourseChapterName);
 var strCourseChapterName = objcc_CourseChapterEN.CourseChapterName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseChapterName + "'");
 }
 
 if (objcc_CourseChapterEN.ChapterId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.ChapterId);
 var strChapterId = objcc_CourseChapterEN.ChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strChapterId + "'");
 }
 
 if (objcc_CourseChapterEN.SectionId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.SectionId);
 var strSectionId = objcc_CourseChapterEN.SectionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSectionId + "'");
 }
 
 if (objcc_CourseChapterEN.ChapterName !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.ChapterName);
 var strChapterName = objcc_CourseChapterEN.ChapterName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strChapterName + "'");
 }
 
 if (objcc_CourseChapterEN.SectionName !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.SectionName);
 var strSectionName = objcc_CourseChapterEN.SectionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSectionName + "'");
 }
 
 if (objcc_CourseChapterEN.ChapterNameSim !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.ChapterNameSim);
 var strChapterNameSim = objcc_CourseChapterEN.ChapterNameSim.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strChapterNameSim + "'");
 }
 
 if (objcc_CourseChapterEN.SectionNameSim !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.SectionNameSim);
 var strSectionNameSim = objcc_CourseChapterEN.SectionNameSim.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSectionNameSim + "'");
 }
 
 if (objcc_CourseChapterEN.ChapterContent !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.ChapterContent);
 var strChapterContent = objcc_CourseChapterEN.ChapterContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strChapterContent + "'");
 }
 
 if (objcc_CourseChapterEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.CourseId);
 var strCourseId = objcc_CourseChapterEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objcc_CourseChapterEN.ParentNodeId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.ParentNodeId);
 var strParentNodeId = objcc_CourseChapterEN.ParentNodeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParentNodeId + "'");
 }
 
 arrFieldListForInsert.Add(concc_CourseChapter.IsOpenToAllStu);
 arrValueListForInsert.Add("'" + (objcc_CourseChapterEN.IsOpenToAllStu  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_CourseChapter.IsOpenToSchool);
 arrValueListForInsert.Add("'" + (objcc_CourseChapterEN.IsOpenToSchool  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_CourseChapter.IsOpenToSocial);
 arrValueListForInsert.Add("'" + (objcc_CourseChapterEN.IsOpenToSocial  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_CourseChapter.IsMustMenu);
 arrValueListForInsert.Add("'" + (objcc_CourseChapterEN.IsMustMenu  ==  false ? "0" : "1") + "'");
 
 if (objcc_CourseChapterEN.ThemeName !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.ThemeName);
 var strThemeName = objcc_CourseChapterEN.ThemeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strThemeName + "'");
 }
 
 arrFieldListForInsert.Add(concc_CourseChapter.IsFile);
 arrValueListForInsert.Add("'" + (objcc_CourseChapterEN.IsFile  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_CourseChapter.IsUse);
 arrValueListForInsert.Add("'" + (objcc_CourseChapterEN.IsUse  ==  false ? "0" : "1") + "'");
 
 if (objcc_CourseChapterEN.ViewCount !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.ViewCount);
 arrValueListForInsert.Add(objcc_CourseChapterEN.ViewCount.ToString());
 }
 
 if (objcc_CourseChapterEN.CourseChapterReferred !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.CourseChapterReferred);
 var strCourseChapterReferred = objcc_CourseChapterEN.CourseChapterReferred.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseChapterReferred + "'");
 }
 
 if (objcc_CourseChapterEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.OrderNum);
 arrValueListForInsert.Add(objcc_CourseChapterEN.OrderNum.ToString());
 }
 
 if (objcc_CourseChapterEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.CreateDate);
 var strCreateDate = objcc_CourseChapterEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objcc_CourseChapterEN.EditPeople !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.EditPeople);
 var strEditPeople = objcc_CourseChapterEN.EditPeople.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEditPeople + "'");
 }
 
 if (objcc_CourseChapterEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.UpdDate);
 var strUpdDate = objcc_CourseChapterEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcc_CourseChapterEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.Memo);
 var strMemo = objcc_CourseChapterEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_CourseChapter");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseChapterDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objcc_CourseChapterEN.CourseChapterId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objcc_CourseChapterEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clscc_CourseChapterEN objcc_CourseChapterEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objcc_CourseChapterEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_CourseChapterEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objcc_CourseChapterEN.CourseChapterId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.CourseChapterId);
 var strCourseChapterId = objcc_CourseChapterEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseChapterId + "'");
 }
 
 if (objcc_CourseChapterEN.CourseChapterName !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.CourseChapterName);
 var strCourseChapterName = objcc_CourseChapterEN.CourseChapterName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseChapterName + "'");
 }
 
 if (objcc_CourseChapterEN.ChapterId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.ChapterId);
 var strChapterId = objcc_CourseChapterEN.ChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strChapterId + "'");
 }
 
 if (objcc_CourseChapterEN.SectionId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.SectionId);
 var strSectionId = objcc_CourseChapterEN.SectionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSectionId + "'");
 }
 
 if (objcc_CourseChapterEN.ChapterName !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.ChapterName);
 var strChapterName = objcc_CourseChapterEN.ChapterName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strChapterName + "'");
 }
 
 if (objcc_CourseChapterEN.SectionName !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.SectionName);
 var strSectionName = objcc_CourseChapterEN.SectionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSectionName + "'");
 }
 
 if (objcc_CourseChapterEN.ChapterNameSim !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.ChapterNameSim);
 var strChapterNameSim = objcc_CourseChapterEN.ChapterNameSim.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strChapterNameSim + "'");
 }
 
 if (objcc_CourseChapterEN.SectionNameSim !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.SectionNameSim);
 var strSectionNameSim = objcc_CourseChapterEN.SectionNameSim.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSectionNameSim + "'");
 }
 
 if (objcc_CourseChapterEN.ChapterContent !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.ChapterContent);
 var strChapterContent = objcc_CourseChapterEN.ChapterContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strChapterContent + "'");
 }
 
 if (objcc_CourseChapterEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.CourseId);
 var strCourseId = objcc_CourseChapterEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objcc_CourseChapterEN.ParentNodeId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.ParentNodeId);
 var strParentNodeId = objcc_CourseChapterEN.ParentNodeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParentNodeId + "'");
 }
 
 arrFieldListForInsert.Add(concc_CourseChapter.IsOpenToAllStu);
 arrValueListForInsert.Add("'" + (objcc_CourseChapterEN.IsOpenToAllStu  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_CourseChapter.IsOpenToSchool);
 arrValueListForInsert.Add("'" + (objcc_CourseChapterEN.IsOpenToSchool  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_CourseChapter.IsOpenToSocial);
 arrValueListForInsert.Add("'" + (objcc_CourseChapterEN.IsOpenToSocial  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_CourseChapter.IsMustMenu);
 arrValueListForInsert.Add("'" + (objcc_CourseChapterEN.IsMustMenu  ==  false ? "0" : "1") + "'");
 
 if (objcc_CourseChapterEN.ThemeName !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.ThemeName);
 var strThemeName = objcc_CourseChapterEN.ThemeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strThemeName + "'");
 }
 
 arrFieldListForInsert.Add(concc_CourseChapter.IsFile);
 arrValueListForInsert.Add("'" + (objcc_CourseChapterEN.IsFile  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_CourseChapter.IsUse);
 arrValueListForInsert.Add("'" + (objcc_CourseChapterEN.IsUse  ==  false ? "0" : "1") + "'");
 
 if (objcc_CourseChapterEN.ViewCount !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.ViewCount);
 arrValueListForInsert.Add(objcc_CourseChapterEN.ViewCount.ToString());
 }
 
 if (objcc_CourseChapterEN.CourseChapterReferred !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.CourseChapterReferred);
 var strCourseChapterReferred = objcc_CourseChapterEN.CourseChapterReferred.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseChapterReferred + "'");
 }
 
 if (objcc_CourseChapterEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.OrderNum);
 arrValueListForInsert.Add(objcc_CourseChapterEN.OrderNum.ToString());
 }
 
 if (objcc_CourseChapterEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.CreateDate);
 var strCreateDate = objcc_CourseChapterEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objcc_CourseChapterEN.EditPeople !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.EditPeople);
 var strEditPeople = objcc_CourseChapterEN.EditPeople.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEditPeople + "'");
 }
 
 if (objcc_CourseChapterEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.UpdDate);
 var strUpdDate = objcc_CourseChapterEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcc_CourseChapterEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseChapter.Memo);
 var strMemo = objcc_CourseChapterEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_CourseChapter");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseChapterDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewcc_CourseChapters(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseChapterDA.GetSpecSQLObj();
strSQL = "Select * from cc_CourseChapter where CourseChapterId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "cc_CourseChapter");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strCourseChapterId = oRow[concc_CourseChapter.CourseChapterId].ToString().Trim();
if (IsExist(strCourseChapterId))
{
 string strResult = "关键字变量值为:" + string.Format("CourseChapterId = {0}", strCourseChapterId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clscc_CourseChapterEN._CurrTabName ].NewRow();
objRow[concc_CourseChapter.CourseChapterId] = oRow[concc_CourseChapter.CourseChapterId].ToString().Trim(); //课程章节ID
objRow[concc_CourseChapter.CourseChapterName] = oRow[concc_CourseChapter.CourseChapterName].ToString().Trim(); //课程章节名称
objRow[concc_CourseChapter.ChapterId] = oRow[concc_CourseChapter.ChapterId].ToString().Trim(); //章Id
objRow[concc_CourseChapter.SectionId] = oRow[concc_CourseChapter.SectionId].ToString().Trim(); //节Id
objRow[concc_CourseChapter.ChapterName] = oRow[concc_CourseChapter.ChapterName].ToString().Trim(); //章名
objRow[concc_CourseChapter.SectionName] = oRow[concc_CourseChapter.SectionName].ToString().Trim(); //节名
objRow[concc_CourseChapter.ChapterNameSim] = oRow[concc_CourseChapter.ChapterNameSim].ToString().Trim(); //章名简称
objRow[concc_CourseChapter.SectionNameSim] = oRow[concc_CourseChapter.SectionNameSim].ToString().Trim(); //节名简称
objRow[concc_CourseChapter.ChapterContent] = oRow[concc_CourseChapter.ChapterContent].ToString().Trim(); //章节内容
objRow[concc_CourseChapter.CourseId] = oRow[concc_CourseChapter.CourseId].ToString().Trim(); //课程Id
objRow[concc_CourseChapter.ParentNodeId] = oRow[concc_CourseChapter.ParentNodeId].ToString().Trim(); //父节点编号
objRow[concc_CourseChapter.IsOpenToAllStu] = oRow[concc_CourseChapter.IsOpenToAllStu].ToString().Trim(); //全校师生
objRow[concc_CourseChapter.IsOpenToSchool] = oRow[concc_CourseChapter.IsOpenToSchool].ToString().Trim(); //全校师生公开
objRow[concc_CourseChapter.IsOpenToSocial] = oRow[concc_CourseChapter.IsOpenToSocial].ToString().Trim(); //社会公众
objRow[concc_CourseChapter.IsMustMenu] = oRow[concc_CourseChapter.IsMustMenu].ToString().Trim(); //是否必建栏目
objRow[concc_CourseChapter.ThemeName] = oRow[concc_CourseChapter.ThemeName].ToString().Trim(); //主题名
objRow[concc_CourseChapter.IsFile] = oRow[concc_CourseChapter.IsFile].ToString().Trim(); //项目或文件夹
objRow[concc_CourseChapter.IsUse] = oRow[concc_CourseChapter.IsUse].ToString().Trim(); //是否使用
objRow[concc_CourseChapter.ViewCount] = oRow[concc_CourseChapter.ViewCount].ToString().Trim(); //浏览量
objRow[concc_CourseChapter.CourseChapterReferred] = oRow[concc_CourseChapter.CourseChapterReferred].ToString().Trim(); //节简称
objRow[concc_CourseChapter.OrderNum] = oRow[concc_CourseChapter.OrderNum].ToString().Trim(); //序号
objRow[concc_CourseChapter.CreateDate] = oRow[concc_CourseChapter.CreateDate].ToString().Trim(); //建立日期
objRow[concc_CourseChapter.EditPeople] = oRow[concc_CourseChapter.EditPeople].ToString().Trim(); //修改人
objRow[concc_CourseChapter.UpdDate] = oRow[concc_CourseChapter.UpdDate].ToString().Trim(); //修改日期
objRow[concc_CourseChapter.Memo] = oRow[concc_CourseChapter.Memo].ToString().Trim(); //备注
 objDS.Tables[clscc_CourseChapterEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clscc_CourseChapterEN._CurrTabName);
}
catch(Exception objException) 
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
objSQL.SQLConnect.Close();
}
return true;
}

 #endregion 添加记录

 #region 修改记录

 /// <summary>
 /// 功能:通过ADO修改记录
 /// (AutoGCLib.DALCode4CSharp:GenUpdate)
 /// </summary>
 /// <param name = "objcc_CourseChapterEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clscc_CourseChapterEN objcc_CourseChapterEN)
{
 if (objcc_CourseChapterEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_CourseChapterEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseChapterDA.GetSpecSQLObj();
strSQL = "Select * from cc_CourseChapter where CourseChapterId = " + "'"+ objcc_CourseChapterEN.CourseChapterId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clscc_CourseChapterEN._CurrTabName);
if (objDS.Tables[clscc_CourseChapterEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:CourseChapterId = " + "'"+ objcc_CourseChapterEN.CourseChapterId+"'");
return false;
}
objRow = objDS.Tables[clscc_CourseChapterEN._CurrTabName].Rows[0];
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.CourseChapterId))
 {
objRow[concc_CourseChapter.CourseChapterId] = objcc_CourseChapterEN.CourseChapterId; //课程章节ID
 }
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.CourseChapterName))
 {
objRow[concc_CourseChapter.CourseChapterName] = objcc_CourseChapterEN.CourseChapterName; //课程章节名称
 }
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.ChapterId))
 {
objRow[concc_CourseChapter.ChapterId] = objcc_CourseChapterEN.ChapterId; //章Id
 }
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.SectionId))
 {
objRow[concc_CourseChapter.SectionId] = objcc_CourseChapterEN.SectionId; //节Id
 }
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.ChapterName))
 {
objRow[concc_CourseChapter.ChapterName] = objcc_CourseChapterEN.ChapterName; //章名
 }
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.SectionName))
 {
objRow[concc_CourseChapter.SectionName] = objcc_CourseChapterEN.SectionName; //节名
 }
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.ChapterNameSim))
 {
objRow[concc_CourseChapter.ChapterNameSim] = objcc_CourseChapterEN.ChapterNameSim; //章名简称
 }
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.SectionNameSim))
 {
objRow[concc_CourseChapter.SectionNameSim] = objcc_CourseChapterEN.SectionNameSim; //节名简称
 }
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.ChapterContent))
 {
objRow[concc_CourseChapter.ChapterContent] = objcc_CourseChapterEN.ChapterContent; //章节内容
 }
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.CourseId))
 {
objRow[concc_CourseChapter.CourseId] = objcc_CourseChapterEN.CourseId; //课程Id
 }
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.ParentNodeId))
 {
objRow[concc_CourseChapter.ParentNodeId] = objcc_CourseChapterEN.ParentNodeId; //父节点编号
 }
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.IsOpenToAllStu))
 {
objRow[concc_CourseChapter.IsOpenToAllStu] = objcc_CourseChapterEN.IsOpenToAllStu; //全校师生
 }
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.IsOpenToSchool))
 {
objRow[concc_CourseChapter.IsOpenToSchool] = objcc_CourseChapterEN.IsOpenToSchool; //全校师生公开
 }
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.IsOpenToSocial))
 {
objRow[concc_CourseChapter.IsOpenToSocial] = objcc_CourseChapterEN.IsOpenToSocial; //社会公众
 }
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.IsMustMenu))
 {
objRow[concc_CourseChapter.IsMustMenu] = objcc_CourseChapterEN.IsMustMenu; //是否必建栏目
 }
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.ThemeName))
 {
objRow[concc_CourseChapter.ThemeName] = objcc_CourseChapterEN.ThemeName; //主题名
 }
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.IsFile))
 {
objRow[concc_CourseChapter.IsFile] = objcc_CourseChapterEN.IsFile; //项目或文件夹
 }
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.IsUse))
 {
objRow[concc_CourseChapter.IsUse] = objcc_CourseChapterEN.IsUse; //是否使用
 }
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.ViewCount))
 {
objRow[concc_CourseChapter.ViewCount] = objcc_CourseChapterEN.ViewCount; //浏览量
 }
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.CourseChapterReferred))
 {
objRow[concc_CourseChapter.CourseChapterReferred] = objcc_CourseChapterEN.CourseChapterReferred; //节简称
 }
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.OrderNum))
 {
objRow[concc_CourseChapter.OrderNum] = objcc_CourseChapterEN.OrderNum; //序号
 }
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.CreateDate))
 {
objRow[concc_CourseChapter.CreateDate] = objcc_CourseChapterEN.CreateDate; //建立日期
 }
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.EditPeople))
 {
objRow[concc_CourseChapter.EditPeople] = objcc_CourseChapterEN.EditPeople; //修改人
 }
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.UpdDate))
 {
objRow[concc_CourseChapter.UpdDate] = objcc_CourseChapterEN.UpdDate; //修改日期
 }
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.Memo))
 {
objRow[concc_CourseChapter.Memo] = objcc_CourseChapterEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clscc_CourseChapterEN._CurrTabName);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
return true;
}


 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySql2)
 /// </summary>
 /// <param name = "objcc_CourseChapterEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clscc_CourseChapterEN objcc_CourseChapterEN)
{
 if (objcc_CourseChapterEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_CourseChapterEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseChapterDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update cc_CourseChapter Set ");
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.CourseChapterName))
 {
 if (objcc_CourseChapterEN.CourseChapterName !=  null)
 {
 var strCourseChapterName = objcc_CourseChapterEN.CourseChapterName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseChapterName, concc_CourseChapter.CourseChapterName); //课程章节名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseChapter.CourseChapterName); //课程章节名称
 }
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.ChapterId))
 {
 if (objcc_CourseChapterEN.ChapterId !=  null)
 {
 var strChapterId = objcc_CourseChapterEN.ChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strChapterId, concc_CourseChapter.ChapterId); //章Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseChapter.ChapterId); //章Id
 }
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.SectionId))
 {
 if (objcc_CourseChapterEN.SectionId !=  null)
 {
 var strSectionId = objcc_CourseChapterEN.SectionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSectionId, concc_CourseChapter.SectionId); //节Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseChapter.SectionId); //节Id
 }
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.ChapterName))
 {
 if (objcc_CourseChapterEN.ChapterName !=  null)
 {
 var strChapterName = objcc_CourseChapterEN.ChapterName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strChapterName, concc_CourseChapter.ChapterName); //章名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseChapter.ChapterName); //章名
 }
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.SectionName))
 {
 if (objcc_CourseChapterEN.SectionName !=  null)
 {
 var strSectionName = objcc_CourseChapterEN.SectionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSectionName, concc_CourseChapter.SectionName); //节名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseChapter.SectionName); //节名
 }
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.ChapterNameSim))
 {
 if (objcc_CourseChapterEN.ChapterNameSim !=  null)
 {
 var strChapterNameSim = objcc_CourseChapterEN.ChapterNameSim.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strChapterNameSim, concc_CourseChapter.ChapterNameSim); //章名简称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseChapter.ChapterNameSim); //章名简称
 }
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.SectionNameSim))
 {
 if (objcc_CourseChapterEN.SectionNameSim !=  null)
 {
 var strSectionNameSim = objcc_CourseChapterEN.SectionNameSim.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSectionNameSim, concc_CourseChapter.SectionNameSim); //节名简称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseChapter.SectionNameSim); //节名简称
 }
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.ChapterContent))
 {
 if (objcc_CourseChapterEN.ChapterContent !=  null)
 {
 var strChapterContent = objcc_CourseChapterEN.ChapterContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strChapterContent, concc_CourseChapter.ChapterContent); //章节内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseChapter.ChapterContent); //章节内容
 }
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.CourseId))
 {
 if (objcc_CourseChapterEN.CourseId !=  null)
 {
 var strCourseId = objcc_CourseChapterEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, concc_CourseChapter.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseChapter.CourseId); //课程Id
 }
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.ParentNodeId))
 {
 if (objcc_CourseChapterEN.ParentNodeId !=  null)
 {
 var strParentNodeId = objcc_CourseChapterEN.ParentNodeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParentNodeId, concc_CourseChapter.ParentNodeId); //父节点编号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseChapter.ParentNodeId); //父节点编号
 }
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.IsOpenToAllStu))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_CourseChapterEN.IsOpenToAllStu == true?"1":"0", concc_CourseChapter.IsOpenToAllStu); //全校师生
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.IsOpenToSchool))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_CourseChapterEN.IsOpenToSchool == true?"1":"0", concc_CourseChapter.IsOpenToSchool); //全校师生公开
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.IsOpenToSocial))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_CourseChapterEN.IsOpenToSocial == true?"1":"0", concc_CourseChapter.IsOpenToSocial); //社会公众
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.IsMustMenu))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_CourseChapterEN.IsMustMenu == true?"1":"0", concc_CourseChapter.IsMustMenu); //是否必建栏目
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.ThemeName))
 {
 if (objcc_CourseChapterEN.ThemeName !=  null)
 {
 var strThemeName = objcc_CourseChapterEN.ThemeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strThemeName, concc_CourseChapter.ThemeName); //主题名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseChapter.ThemeName); //主题名
 }
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.IsFile))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_CourseChapterEN.IsFile == true?"1":"0", concc_CourseChapter.IsFile); //项目或文件夹
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.IsUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_CourseChapterEN.IsUse == true?"1":"0", concc_CourseChapter.IsUse); //是否使用
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.ViewCount))
 {
 if (objcc_CourseChapterEN.ViewCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseChapterEN.ViewCount, concc_CourseChapter.ViewCount); //浏览量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseChapter.ViewCount); //浏览量
 }
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.CourseChapterReferred))
 {
 if (objcc_CourseChapterEN.CourseChapterReferred !=  null)
 {
 var strCourseChapterReferred = objcc_CourseChapterEN.CourseChapterReferred.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseChapterReferred, concc_CourseChapter.CourseChapterReferred); //节简称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseChapter.CourseChapterReferred); //节简称
 }
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.OrderNum))
 {
 if (objcc_CourseChapterEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseChapterEN.OrderNum, concc_CourseChapter.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseChapter.OrderNum); //序号
 }
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.CreateDate))
 {
 if (objcc_CourseChapterEN.CreateDate !=  null)
 {
 var strCreateDate = objcc_CourseChapterEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateDate, concc_CourseChapter.CreateDate); //建立日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseChapter.CreateDate); //建立日期
 }
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.EditPeople))
 {
 if (objcc_CourseChapterEN.EditPeople !=  null)
 {
 var strEditPeople = objcc_CourseChapterEN.EditPeople.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEditPeople, concc_CourseChapter.EditPeople); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseChapter.EditPeople); //修改人
 }
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.UpdDate))
 {
 if (objcc_CourseChapterEN.UpdDate !=  null)
 {
 var strUpdDate = objcc_CourseChapterEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, concc_CourseChapter.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseChapter.UpdDate); //修改日期
 }
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.Memo))
 {
 if (objcc_CourseChapterEN.Memo !=  null)
 {
 var strMemo = objcc_CourseChapterEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, concc_CourseChapter.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseChapter.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where CourseChapterId = '{0}'", objcc_CourseChapterEN.CourseChapterId); 
 clsCheckSql.CheckSqlInjection4Update(sbSQL.ToString());
 return objSQL.ExecSql(sbSQL.ToString());
}
catch (Exception objException)
{
string strMsg = string.Format("发生错误:[{0}].SQL:[{1}].({2})",
     objException.Message, sbSQL.ToString(), clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
finally
{
}
}


 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySqlWithCondition)
 /// </summary>
 /// <param name = "objcc_CourseChapterEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clscc_CourseChapterEN objcc_CourseChapterEN, string strCondition)
{
 if (objcc_CourseChapterEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_CourseChapterEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseChapterDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update cc_CourseChapter Set ");
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.CourseChapterName))
 {
 if (objcc_CourseChapterEN.CourseChapterName !=  null)
 {
 var strCourseChapterName = objcc_CourseChapterEN.CourseChapterName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseChapterName = '{0}',", strCourseChapterName); //课程章节名称
 }
 else
 {
 sbSQL.Append(" CourseChapterName = null,"); //课程章节名称
 }
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.ChapterId))
 {
 if (objcc_CourseChapterEN.ChapterId !=  null)
 {
 var strChapterId = objcc_CourseChapterEN.ChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ChapterId = '{0}',", strChapterId); //章Id
 }
 else
 {
 sbSQL.Append(" ChapterId = null,"); //章Id
 }
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.SectionId))
 {
 if (objcc_CourseChapterEN.SectionId !=  null)
 {
 var strSectionId = objcc_CourseChapterEN.SectionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SectionId = '{0}',", strSectionId); //节Id
 }
 else
 {
 sbSQL.Append(" SectionId = null,"); //节Id
 }
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.ChapterName))
 {
 if (objcc_CourseChapterEN.ChapterName !=  null)
 {
 var strChapterName = objcc_CourseChapterEN.ChapterName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ChapterName = '{0}',", strChapterName); //章名
 }
 else
 {
 sbSQL.Append(" ChapterName = null,"); //章名
 }
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.SectionName))
 {
 if (objcc_CourseChapterEN.SectionName !=  null)
 {
 var strSectionName = objcc_CourseChapterEN.SectionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SectionName = '{0}',", strSectionName); //节名
 }
 else
 {
 sbSQL.Append(" SectionName = null,"); //节名
 }
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.ChapterNameSim))
 {
 if (objcc_CourseChapterEN.ChapterNameSim !=  null)
 {
 var strChapterNameSim = objcc_CourseChapterEN.ChapterNameSim.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ChapterNameSim = '{0}',", strChapterNameSim); //章名简称
 }
 else
 {
 sbSQL.Append(" ChapterNameSim = null,"); //章名简称
 }
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.SectionNameSim))
 {
 if (objcc_CourseChapterEN.SectionNameSim !=  null)
 {
 var strSectionNameSim = objcc_CourseChapterEN.SectionNameSim.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SectionNameSim = '{0}',", strSectionNameSim); //节名简称
 }
 else
 {
 sbSQL.Append(" SectionNameSim = null,"); //节名简称
 }
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.ChapterContent))
 {
 if (objcc_CourseChapterEN.ChapterContent !=  null)
 {
 var strChapterContent = objcc_CourseChapterEN.ChapterContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ChapterContent = '{0}',", strChapterContent); //章节内容
 }
 else
 {
 sbSQL.Append(" ChapterContent = null,"); //章节内容
 }
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.CourseId))
 {
 if (objcc_CourseChapterEN.CourseId !=  null)
 {
 var strCourseId = objcc_CourseChapterEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.ParentNodeId))
 {
 if (objcc_CourseChapterEN.ParentNodeId !=  null)
 {
 var strParentNodeId = objcc_CourseChapterEN.ParentNodeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParentNodeId = '{0}',", strParentNodeId); //父节点编号
 }
 else
 {
 sbSQL.Append(" ParentNodeId = null,"); //父节点编号
 }
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.IsOpenToAllStu))
 {
 sbSQL.AppendFormat(" IsOpenToAllStu = '{0}',", objcc_CourseChapterEN.IsOpenToAllStu == true?"1":"0"); //全校师生
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.IsOpenToSchool))
 {
 sbSQL.AppendFormat(" IsOpenToSchool = '{0}',", objcc_CourseChapterEN.IsOpenToSchool == true?"1":"0"); //全校师生公开
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.IsOpenToSocial))
 {
 sbSQL.AppendFormat(" IsOpenToSocial = '{0}',", objcc_CourseChapterEN.IsOpenToSocial == true?"1":"0"); //社会公众
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.IsMustMenu))
 {
 sbSQL.AppendFormat(" IsMustMenu = '{0}',", objcc_CourseChapterEN.IsMustMenu == true?"1":"0"); //是否必建栏目
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.ThemeName))
 {
 if (objcc_CourseChapterEN.ThemeName !=  null)
 {
 var strThemeName = objcc_CourseChapterEN.ThemeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ThemeName = '{0}',", strThemeName); //主题名
 }
 else
 {
 sbSQL.Append(" ThemeName = null,"); //主题名
 }
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.IsFile))
 {
 sbSQL.AppendFormat(" IsFile = '{0}',", objcc_CourseChapterEN.IsFile == true?"1":"0"); //项目或文件夹
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.IsUse))
 {
 sbSQL.AppendFormat(" IsUse = '{0}',", objcc_CourseChapterEN.IsUse == true?"1":"0"); //是否使用
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.ViewCount))
 {
 if (objcc_CourseChapterEN.ViewCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseChapterEN.ViewCount, concc_CourseChapter.ViewCount); //浏览量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseChapter.ViewCount); //浏览量
 }
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.CourseChapterReferred))
 {
 if (objcc_CourseChapterEN.CourseChapterReferred !=  null)
 {
 var strCourseChapterReferred = objcc_CourseChapterEN.CourseChapterReferred.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseChapterReferred = '{0}',", strCourseChapterReferred); //节简称
 }
 else
 {
 sbSQL.Append(" CourseChapterReferred = null,"); //节简称
 }
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.OrderNum))
 {
 if (objcc_CourseChapterEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseChapterEN.OrderNum, concc_CourseChapter.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseChapter.OrderNum); //序号
 }
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.CreateDate))
 {
 if (objcc_CourseChapterEN.CreateDate !=  null)
 {
 var strCreateDate = objcc_CourseChapterEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateDate = '{0}',", strCreateDate); //建立日期
 }
 else
 {
 sbSQL.Append(" CreateDate = null,"); //建立日期
 }
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.EditPeople))
 {
 if (objcc_CourseChapterEN.EditPeople !=  null)
 {
 var strEditPeople = objcc_CourseChapterEN.EditPeople.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EditPeople = '{0}',", strEditPeople); //修改人
 }
 else
 {
 sbSQL.Append(" EditPeople = null,"); //修改人
 }
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.UpdDate))
 {
 if (objcc_CourseChapterEN.UpdDate !=  null)
 {
 var strUpdDate = objcc_CourseChapterEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.Memo))
 {
 if (objcc_CourseChapterEN.Memo !=  null)
 {
 var strMemo = objcc_CourseChapterEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where {0}", strCondition); 
try
{
 clsCheckSql.CheckSqlInjection4Update(sbSQL.ToString());
 return objSQL.ExecSql(sbSQL.ToString());
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
}


 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式,根据条件修改记录.(带事务处理)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySqlWithConditionTransaction)
 /// </summary>
 /// <param name = "objcc_CourseChapterEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clscc_CourseChapterEN objcc_CourseChapterEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objcc_CourseChapterEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_CourseChapterEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseChapterDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update cc_CourseChapter Set ");
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.CourseChapterName))
 {
 if (objcc_CourseChapterEN.CourseChapterName !=  null)
 {
 var strCourseChapterName = objcc_CourseChapterEN.CourseChapterName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseChapterName = '{0}',", strCourseChapterName); //课程章节名称
 }
 else
 {
 sbSQL.Append(" CourseChapterName = null,"); //课程章节名称
 }
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.ChapterId))
 {
 if (objcc_CourseChapterEN.ChapterId !=  null)
 {
 var strChapterId = objcc_CourseChapterEN.ChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ChapterId = '{0}',", strChapterId); //章Id
 }
 else
 {
 sbSQL.Append(" ChapterId = null,"); //章Id
 }
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.SectionId))
 {
 if (objcc_CourseChapterEN.SectionId !=  null)
 {
 var strSectionId = objcc_CourseChapterEN.SectionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SectionId = '{0}',", strSectionId); //节Id
 }
 else
 {
 sbSQL.Append(" SectionId = null,"); //节Id
 }
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.ChapterName))
 {
 if (objcc_CourseChapterEN.ChapterName !=  null)
 {
 var strChapterName = objcc_CourseChapterEN.ChapterName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ChapterName = '{0}',", strChapterName); //章名
 }
 else
 {
 sbSQL.Append(" ChapterName = null,"); //章名
 }
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.SectionName))
 {
 if (objcc_CourseChapterEN.SectionName !=  null)
 {
 var strSectionName = objcc_CourseChapterEN.SectionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SectionName = '{0}',", strSectionName); //节名
 }
 else
 {
 sbSQL.Append(" SectionName = null,"); //节名
 }
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.ChapterNameSim))
 {
 if (objcc_CourseChapterEN.ChapterNameSim !=  null)
 {
 var strChapterNameSim = objcc_CourseChapterEN.ChapterNameSim.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ChapterNameSim = '{0}',", strChapterNameSim); //章名简称
 }
 else
 {
 sbSQL.Append(" ChapterNameSim = null,"); //章名简称
 }
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.SectionNameSim))
 {
 if (objcc_CourseChapterEN.SectionNameSim !=  null)
 {
 var strSectionNameSim = objcc_CourseChapterEN.SectionNameSim.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SectionNameSim = '{0}',", strSectionNameSim); //节名简称
 }
 else
 {
 sbSQL.Append(" SectionNameSim = null,"); //节名简称
 }
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.ChapterContent))
 {
 if (objcc_CourseChapterEN.ChapterContent !=  null)
 {
 var strChapterContent = objcc_CourseChapterEN.ChapterContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ChapterContent = '{0}',", strChapterContent); //章节内容
 }
 else
 {
 sbSQL.Append(" ChapterContent = null,"); //章节内容
 }
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.CourseId))
 {
 if (objcc_CourseChapterEN.CourseId !=  null)
 {
 var strCourseId = objcc_CourseChapterEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.ParentNodeId))
 {
 if (objcc_CourseChapterEN.ParentNodeId !=  null)
 {
 var strParentNodeId = objcc_CourseChapterEN.ParentNodeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParentNodeId = '{0}',", strParentNodeId); //父节点编号
 }
 else
 {
 sbSQL.Append(" ParentNodeId = null,"); //父节点编号
 }
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.IsOpenToAllStu))
 {
 sbSQL.AppendFormat(" IsOpenToAllStu = '{0}',", objcc_CourseChapterEN.IsOpenToAllStu == true?"1":"0"); //全校师生
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.IsOpenToSchool))
 {
 sbSQL.AppendFormat(" IsOpenToSchool = '{0}',", objcc_CourseChapterEN.IsOpenToSchool == true?"1":"0"); //全校师生公开
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.IsOpenToSocial))
 {
 sbSQL.AppendFormat(" IsOpenToSocial = '{0}',", objcc_CourseChapterEN.IsOpenToSocial == true?"1":"0"); //社会公众
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.IsMustMenu))
 {
 sbSQL.AppendFormat(" IsMustMenu = '{0}',", objcc_CourseChapterEN.IsMustMenu == true?"1":"0"); //是否必建栏目
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.ThemeName))
 {
 if (objcc_CourseChapterEN.ThemeName !=  null)
 {
 var strThemeName = objcc_CourseChapterEN.ThemeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ThemeName = '{0}',", strThemeName); //主题名
 }
 else
 {
 sbSQL.Append(" ThemeName = null,"); //主题名
 }
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.IsFile))
 {
 sbSQL.AppendFormat(" IsFile = '{0}',", objcc_CourseChapterEN.IsFile == true?"1":"0"); //项目或文件夹
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.IsUse))
 {
 sbSQL.AppendFormat(" IsUse = '{0}',", objcc_CourseChapterEN.IsUse == true?"1":"0"); //是否使用
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.ViewCount))
 {
 if (objcc_CourseChapterEN.ViewCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseChapterEN.ViewCount, concc_CourseChapter.ViewCount); //浏览量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseChapter.ViewCount); //浏览量
 }
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.CourseChapterReferred))
 {
 if (objcc_CourseChapterEN.CourseChapterReferred !=  null)
 {
 var strCourseChapterReferred = objcc_CourseChapterEN.CourseChapterReferred.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseChapterReferred = '{0}',", strCourseChapterReferred); //节简称
 }
 else
 {
 sbSQL.Append(" CourseChapterReferred = null,"); //节简称
 }
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.OrderNum))
 {
 if (objcc_CourseChapterEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseChapterEN.OrderNum, concc_CourseChapter.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseChapter.OrderNum); //序号
 }
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.CreateDate))
 {
 if (objcc_CourseChapterEN.CreateDate !=  null)
 {
 var strCreateDate = objcc_CourseChapterEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateDate = '{0}',", strCreateDate); //建立日期
 }
 else
 {
 sbSQL.Append(" CreateDate = null,"); //建立日期
 }
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.EditPeople))
 {
 if (objcc_CourseChapterEN.EditPeople !=  null)
 {
 var strEditPeople = objcc_CourseChapterEN.EditPeople.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EditPeople = '{0}',", strEditPeople); //修改人
 }
 else
 {
 sbSQL.Append(" EditPeople = null,"); //修改人
 }
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.UpdDate))
 {
 if (objcc_CourseChapterEN.UpdDate !=  null)
 {
 var strUpdDate = objcc_CourseChapterEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.Memo))
 {
 if (objcc_CourseChapterEN.Memo !=  null)
 {
 var strMemo = objcc_CourseChapterEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where {0}", strCondition); 
try
{
 clsCheckSql.CheckSqlInjection4Update(sbSQL.ToString());
 return objSQL.ExecSql(sbSQL.ToString(), objSqlConnection, objSqlTransaction);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
}


 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式.(带事务处理)
 /// /// 优点:1、能够处理字段中的单撇问题；
 /// /// 2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库;
 /// /// 3、支持事务处理.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySqlWithTransaction2)
 /// </summary>
 /// <param name = "objcc_CourseChapterEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clscc_CourseChapterEN objcc_CourseChapterEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objcc_CourseChapterEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_CourseChapterEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseChapterDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update cc_CourseChapter Set ");
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.CourseChapterName))
 {
 if (objcc_CourseChapterEN.CourseChapterName !=  null)
 {
 var strCourseChapterName = objcc_CourseChapterEN.CourseChapterName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseChapterName, concc_CourseChapter.CourseChapterName); //课程章节名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseChapter.CourseChapterName); //课程章节名称
 }
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.ChapterId))
 {
 if (objcc_CourseChapterEN.ChapterId !=  null)
 {
 var strChapterId = objcc_CourseChapterEN.ChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strChapterId, concc_CourseChapter.ChapterId); //章Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseChapter.ChapterId); //章Id
 }
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.SectionId))
 {
 if (objcc_CourseChapterEN.SectionId !=  null)
 {
 var strSectionId = objcc_CourseChapterEN.SectionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSectionId, concc_CourseChapter.SectionId); //节Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseChapter.SectionId); //节Id
 }
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.ChapterName))
 {
 if (objcc_CourseChapterEN.ChapterName !=  null)
 {
 var strChapterName = objcc_CourseChapterEN.ChapterName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strChapterName, concc_CourseChapter.ChapterName); //章名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseChapter.ChapterName); //章名
 }
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.SectionName))
 {
 if (objcc_CourseChapterEN.SectionName !=  null)
 {
 var strSectionName = objcc_CourseChapterEN.SectionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSectionName, concc_CourseChapter.SectionName); //节名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseChapter.SectionName); //节名
 }
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.ChapterNameSim))
 {
 if (objcc_CourseChapterEN.ChapterNameSim !=  null)
 {
 var strChapterNameSim = objcc_CourseChapterEN.ChapterNameSim.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strChapterNameSim, concc_CourseChapter.ChapterNameSim); //章名简称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseChapter.ChapterNameSim); //章名简称
 }
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.SectionNameSim))
 {
 if (objcc_CourseChapterEN.SectionNameSim !=  null)
 {
 var strSectionNameSim = objcc_CourseChapterEN.SectionNameSim.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSectionNameSim, concc_CourseChapter.SectionNameSim); //节名简称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseChapter.SectionNameSim); //节名简称
 }
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.ChapterContent))
 {
 if (objcc_CourseChapterEN.ChapterContent !=  null)
 {
 var strChapterContent = objcc_CourseChapterEN.ChapterContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strChapterContent, concc_CourseChapter.ChapterContent); //章节内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseChapter.ChapterContent); //章节内容
 }
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.CourseId))
 {
 if (objcc_CourseChapterEN.CourseId !=  null)
 {
 var strCourseId = objcc_CourseChapterEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, concc_CourseChapter.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseChapter.CourseId); //课程Id
 }
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.ParentNodeId))
 {
 if (objcc_CourseChapterEN.ParentNodeId !=  null)
 {
 var strParentNodeId = objcc_CourseChapterEN.ParentNodeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParentNodeId, concc_CourseChapter.ParentNodeId); //父节点编号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseChapter.ParentNodeId); //父节点编号
 }
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.IsOpenToAllStu))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_CourseChapterEN.IsOpenToAllStu == true?"1":"0", concc_CourseChapter.IsOpenToAllStu); //全校师生
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.IsOpenToSchool))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_CourseChapterEN.IsOpenToSchool == true?"1":"0", concc_CourseChapter.IsOpenToSchool); //全校师生公开
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.IsOpenToSocial))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_CourseChapterEN.IsOpenToSocial == true?"1":"0", concc_CourseChapter.IsOpenToSocial); //社会公众
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.IsMustMenu))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_CourseChapterEN.IsMustMenu == true?"1":"0", concc_CourseChapter.IsMustMenu); //是否必建栏目
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.ThemeName))
 {
 if (objcc_CourseChapterEN.ThemeName !=  null)
 {
 var strThemeName = objcc_CourseChapterEN.ThemeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strThemeName, concc_CourseChapter.ThemeName); //主题名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseChapter.ThemeName); //主题名
 }
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.IsFile))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_CourseChapterEN.IsFile == true?"1":"0", concc_CourseChapter.IsFile); //项目或文件夹
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.IsUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_CourseChapterEN.IsUse == true?"1":"0", concc_CourseChapter.IsUse); //是否使用
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.ViewCount))
 {
 if (objcc_CourseChapterEN.ViewCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseChapterEN.ViewCount, concc_CourseChapter.ViewCount); //浏览量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseChapter.ViewCount); //浏览量
 }
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.CourseChapterReferred))
 {
 if (objcc_CourseChapterEN.CourseChapterReferred !=  null)
 {
 var strCourseChapterReferred = objcc_CourseChapterEN.CourseChapterReferred.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseChapterReferred, concc_CourseChapter.CourseChapterReferred); //节简称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseChapter.CourseChapterReferred); //节简称
 }
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.OrderNum))
 {
 if (objcc_CourseChapterEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseChapterEN.OrderNum, concc_CourseChapter.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseChapter.OrderNum); //序号
 }
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.CreateDate))
 {
 if (objcc_CourseChapterEN.CreateDate !=  null)
 {
 var strCreateDate = objcc_CourseChapterEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateDate, concc_CourseChapter.CreateDate); //建立日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseChapter.CreateDate); //建立日期
 }
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.EditPeople))
 {
 if (objcc_CourseChapterEN.EditPeople !=  null)
 {
 var strEditPeople = objcc_CourseChapterEN.EditPeople.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEditPeople, concc_CourseChapter.EditPeople); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseChapter.EditPeople); //修改人
 }
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.UpdDate))
 {
 if (objcc_CourseChapterEN.UpdDate !=  null)
 {
 var strUpdDate = objcc_CourseChapterEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, concc_CourseChapter.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseChapter.UpdDate); //修改日期
 }
 }
 
 if (objcc_CourseChapterEN.IsUpdated(concc_CourseChapter.Memo))
 {
 if (objcc_CourseChapterEN.Memo !=  null)
 {
 var strMemo = objcc_CourseChapterEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, concc_CourseChapter.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseChapter.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where CourseChapterId = '{0}'", objcc_CourseChapterEN.CourseChapterId); 
try
{
 clsCheckSql.CheckSqlInjection4Update(sbSQL.ToString());
 return objSQL.ExecSql(sbSQL.ToString(), objSqlConnection, objSqlTransaction);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
}


 #endregion 修改记录

 #region 删除记录

 /// <summary>
 /// 功能:删除关键字所指定的记录,通过存储过程(SP)来删除。
 /// (AutoGCLib.DALCode4CSharp:GenDelRecordBySP)
 /// </summary>
 /// <param name = "strCourseChapterId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strCourseChapterId) 
{
CheckPrimaryKey(strCourseChapterId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseChapterDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strCourseChapterId,
};
 objSQL.ExecSP("cc_CourseChapter_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strCourseChapterId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strCourseChapterId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strCourseChapterId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseChapterDA.GetSpecSQLObj();
//删除cc_CourseChapter本表中与当前对象有关的记录
strSQL = strSQL + "Delete from cc_CourseChapter where CourseChapterId = " + "'"+ strCourseChapterId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delcc_CourseChapter(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseChapterDA.GetSpecSQLObj();
string strSQL;
string strKeyList;
if (lstKey.Count  == 0) return 0;
strKeyList = "";
for (int i = 0; i<lstKey.Count; i++)
{
if (i == 0) strKeyList = strKeyList + "'" + lstKey[i].ToString() + "'";
else strKeyList +=  "," + "'" + lstKey[i].ToString() + "'";
}
strSQL = "";
//删除cc_CourseChapter本表中与当前对象有关的记录
strSQL = strSQL + "Delete from cc_CourseChapter where CourseChapterId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strCourseChapterId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strCourseChapterId) 
{
CheckPrimaryKey(strCourseChapterId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseChapterDA.GetSpecSQLObj();
//删除cc_CourseChapter本表中与当前对象有关的记录
strSQL = strSQL + "Delete from cc_CourseChapter where CourseChapterId = " + "'"+ strCourseChapterId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delcc_CourseChapter(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clscc_CourseChapterDA: Delcc_CourseChapter)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseChapterDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from cc_CourseChapter where " + strCondition ;
}
int intRecoCount = objSQL.ExecSql2(strSQL);
return intRecoCount;
}



 /// <summary>
 /// 功能:删除满足条件的多条记录,同时处理事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRecWithTransaction)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回是否删除成功。</returns>
public bool Delcc_CourseChapterWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clscc_CourseChapterDA: Delcc_CourseChapterWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseChapterDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from cc_CourseChapter where " + strCondition ;
}
 bool bolResult = objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
return bolResult;
}


 #endregion 删除记录

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objcc_CourseChapterENS">源对象</param>
 /// <param name = "objcc_CourseChapterENT">目标对象</param>
public void CopyTo(clscc_CourseChapterEN objcc_CourseChapterENS, clscc_CourseChapterEN objcc_CourseChapterENT)
{
objcc_CourseChapterENT.CourseChapterId = objcc_CourseChapterENS.CourseChapterId; //课程章节ID
objcc_CourseChapterENT.CourseChapterName = objcc_CourseChapterENS.CourseChapterName; //课程章节名称
objcc_CourseChapterENT.ChapterId = objcc_CourseChapterENS.ChapterId; //章Id
objcc_CourseChapterENT.SectionId = objcc_CourseChapterENS.SectionId; //节Id
objcc_CourseChapterENT.ChapterName = objcc_CourseChapterENS.ChapterName; //章名
objcc_CourseChapterENT.SectionName = objcc_CourseChapterENS.SectionName; //节名
objcc_CourseChapterENT.ChapterNameSim = objcc_CourseChapterENS.ChapterNameSim; //章名简称
objcc_CourseChapterENT.SectionNameSim = objcc_CourseChapterENS.SectionNameSim; //节名简称
objcc_CourseChapterENT.ChapterContent = objcc_CourseChapterENS.ChapterContent; //章节内容
objcc_CourseChapterENT.CourseId = objcc_CourseChapterENS.CourseId; //课程Id
objcc_CourseChapterENT.ParentNodeId = objcc_CourseChapterENS.ParentNodeId; //父节点编号
objcc_CourseChapterENT.IsOpenToAllStu = objcc_CourseChapterENS.IsOpenToAllStu; //全校师生
objcc_CourseChapterENT.IsOpenToSchool = objcc_CourseChapterENS.IsOpenToSchool; //全校师生公开
objcc_CourseChapterENT.IsOpenToSocial = objcc_CourseChapterENS.IsOpenToSocial; //社会公众
objcc_CourseChapterENT.IsMustMenu = objcc_CourseChapterENS.IsMustMenu; //是否必建栏目
objcc_CourseChapterENT.ThemeName = objcc_CourseChapterENS.ThemeName; //主题名
objcc_CourseChapterENT.IsFile = objcc_CourseChapterENS.IsFile; //项目或文件夹
objcc_CourseChapterENT.IsUse = objcc_CourseChapterENS.IsUse; //是否使用
objcc_CourseChapterENT.ViewCount = objcc_CourseChapterENS.ViewCount; //浏览量
objcc_CourseChapterENT.CourseChapterReferred = objcc_CourseChapterENS.CourseChapterReferred; //节简称
objcc_CourseChapterENT.OrderNum = objcc_CourseChapterENS.OrderNum; //序号
objcc_CourseChapterENT.CreateDate = objcc_CourseChapterENS.CreateDate; //建立日期
objcc_CourseChapterENT.EditPeople = objcc_CourseChapterENS.EditPeople; //修改人
objcc_CourseChapterENT.UpdDate = objcc_CourseChapterENS.UpdDate; //修改日期
objcc_CourseChapterENT.Memo = objcc_CourseChapterENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clscc_CourseChapterEN objcc_CourseChapterEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objcc_CourseChapterEN.CourseChapterName, concc_CourseChapter.CourseChapterName);
clsCheckSql.CheckFieldNotNull(objcc_CourseChapterEN.CourseId, concc_CourseChapter.CourseId);
clsCheckSql.CheckFieldNotNull(objcc_CourseChapterEN.ParentNodeId, concc_CourseChapter.ParentNodeId);
clsCheckSql.CheckFieldNotNull(objcc_CourseChapterEN.IsOpenToAllStu, concc_CourseChapter.IsOpenToAllStu);
clsCheckSql.CheckFieldNotNull(objcc_CourseChapterEN.IsOpenToSchool, concc_CourseChapter.IsOpenToSchool);
clsCheckSql.CheckFieldNotNull(objcc_CourseChapterEN.IsOpenToSocial, concc_CourseChapter.IsOpenToSocial);
clsCheckSql.CheckFieldNotNull(objcc_CourseChapterEN.IsMustMenu, concc_CourseChapter.IsMustMenu);
clsCheckSql.CheckFieldNotNull(objcc_CourseChapterEN.IsFile, concc_CourseChapter.IsFile);
//检查字段长度
clsCheckSql.CheckFieldLen(objcc_CourseChapterEN.CourseChapterId, 8, concc_CourseChapter.CourseChapterId);
clsCheckSql.CheckFieldLen(objcc_CourseChapterEN.CourseChapterName, 100, concc_CourseChapter.CourseChapterName);
clsCheckSql.CheckFieldLen(objcc_CourseChapterEN.ChapterId, 8, concc_CourseChapter.ChapterId);
clsCheckSql.CheckFieldLen(objcc_CourseChapterEN.SectionId, 8, concc_CourseChapter.SectionId);
clsCheckSql.CheckFieldLen(objcc_CourseChapterEN.ChapterName, 100, concc_CourseChapter.ChapterName);
clsCheckSql.CheckFieldLen(objcc_CourseChapterEN.SectionName, 100, concc_CourseChapter.SectionName);
clsCheckSql.CheckFieldLen(objcc_CourseChapterEN.ChapterNameSim, 10, concc_CourseChapter.ChapterNameSim);
clsCheckSql.CheckFieldLen(objcc_CourseChapterEN.SectionNameSim, 10, concc_CourseChapter.SectionNameSim);
clsCheckSql.CheckFieldLen(objcc_CourseChapterEN.CourseId, 8, concc_CourseChapter.CourseId);
clsCheckSql.CheckFieldLen(objcc_CourseChapterEN.ParentNodeId, 8, concc_CourseChapter.ParentNodeId);
clsCheckSql.CheckFieldLen(objcc_CourseChapterEN.ThemeName, 200, concc_CourseChapter.ThemeName);
clsCheckSql.CheckFieldLen(objcc_CourseChapterEN.CourseChapterReferred, 10, concc_CourseChapter.CourseChapterReferred);
clsCheckSql.CheckFieldLen(objcc_CourseChapterEN.CreateDate, 20, concc_CourseChapter.CreateDate);
clsCheckSql.CheckFieldLen(objcc_CourseChapterEN.EditPeople, 50, concc_CourseChapter.EditPeople);
clsCheckSql.CheckFieldLen(objcc_CourseChapterEN.UpdDate, 20, concc_CourseChapter.UpdDate);
clsCheckSql.CheckFieldLen(objcc_CourseChapterEN.Memo, 1000, concc_CourseChapter.Memo);
//检查字段外键固定长度
 objcc_CourseChapterEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clscc_CourseChapterEN objcc_CourseChapterEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objcc_CourseChapterEN.CourseChapterName, 100, concc_CourseChapter.CourseChapterName);
clsCheckSql.CheckFieldLen(objcc_CourseChapterEN.ChapterId, 8, concc_CourseChapter.ChapterId);
clsCheckSql.CheckFieldLen(objcc_CourseChapterEN.SectionId, 8, concc_CourseChapter.SectionId);
clsCheckSql.CheckFieldLen(objcc_CourseChapterEN.ChapterName, 100, concc_CourseChapter.ChapterName);
clsCheckSql.CheckFieldLen(objcc_CourseChapterEN.SectionName, 100, concc_CourseChapter.SectionName);
clsCheckSql.CheckFieldLen(objcc_CourseChapterEN.ChapterNameSim, 10, concc_CourseChapter.ChapterNameSim);
clsCheckSql.CheckFieldLen(objcc_CourseChapterEN.SectionNameSim, 10, concc_CourseChapter.SectionNameSim);
clsCheckSql.CheckFieldLen(objcc_CourseChapterEN.CourseId, 8, concc_CourseChapter.CourseId);
clsCheckSql.CheckFieldLen(objcc_CourseChapterEN.ParentNodeId, 8, concc_CourseChapter.ParentNodeId);
clsCheckSql.CheckFieldLen(objcc_CourseChapterEN.ThemeName, 200, concc_CourseChapter.ThemeName);
clsCheckSql.CheckFieldLen(objcc_CourseChapterEN.CourseChapterReferred, 10, concc_CourseChapter.CourseChapterReferred);
clsCheckSql.CheckFieldLen(objcc_CourseChapterEN.CreateDate, 20, concc_CourseChapter.CreateDate);
clsCheckSql.CheckFieldLen(objcc_CourseChapterEN.EditPeople, 50, concc_CourseChapter.EditPeople);
clsCheckSql.CheckFieldLen(objcc_CourseChapterEN.UpdDate, 20, concc_CourseChapter.UpdDate);
clsCheckSql.CheckFieldLen(objcc_CourseChapterEN.Memo, 1000, concc_CourseChapter.Memo);
//检查外键字段长度
 objcc_CourseChapterEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clscc_CourseChapterEN objcc_CourseChapterEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objcc_CourseChapterEN.CourseChapterId, 8, concc_CourseChapter.CourseChapterId);
clsCheckSql.CheckFieldLen(objcc_CourseChapterEN.CourseChapterName, 100, concc_CourseChapter.CourseChapterName);
clsCheckSql.CheckFieldLen(objcc_CourseChapterEN.ChapterId, 8, concc_CourseChapter.ChapterId);
clsCheckSql.CheckFieldLen(objcc_CourseChapterEN.SectionId, 8, concc_CourseChapter.SectionId);
clsCheckSql.CheckFieldLen(objcc_CourseChapterEN.ChapterName, 100, concc_CourseChapter.ChapterName);
clsCheckSql.CheckFieldLen(objcc_CourseChapterEN.SectionName, 100, concc_CourseChapter.SectionName);
clsCheckSql.CheckFieldLen(objcc_CourseChapterEN.ChapterNameSim, 10, concc_CourseChapter.ChapterNameSim);
clsCheckSql.CheckFieldLen(objcc_CourseChapterEN.SectionNameSim, 10, concc_CourseChapter.SectionNameSim);
clsCheckSql.CheckFieldLen(objcc_CourseChapterEN.CourseId, 8, concc_CourseChapter.CourseId);
clsCheckSql.CheckFieldLen(objcc_CourseChapterEN.ParentNodeId, 8, concc_CourseChapter.ParentNodeId);
clsCheckSql.CheckFieldLen(objcc_CourseChapterEN.ThemeName, 200, concc_CourseChapter.ThemeName);
clsCheckSql.CheckFieldLen(objcc_CourseChapterEN.CourseChapterReferred, 10, concc_CourseChapter.CourseChapterReferred);
clsCheckSql.CheckFieldLen(objcc_CourseChapterEN.CreateDate, 20, concc_CourseChapter.CreateDate);
clsCheckSql.CheckFieldLen(objcc_CourseChapterEN.EditPeople, 50, concc_CourseChapter.EditPeople);
clsCheckSql.CheckFieldLen(objcc_CourseChapterEN.UpdDate, 20, concc_CourseChapter.UpdDate);
clsCheckSql.CheckFieldLen(objcc_CourseChapterEN.Memo, 1000, concc_CourseChapter.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objcc_CourseChapterEN.CourseChapterId, concc_CourseChapter.CourseChapterId);
clsCheckSql.CheckSqlInjection4Field(objcc_CourseChapterEN.CourseChapterName, concc_CourseChapter.CourseChapterName);
clsCheckSql.CheckSqlInjection4Field(objcc_CourseChapterEN.ChapterId, concc_CourseChapter.ChapterId);
clsCheckSql.CheckSqlInjection4Field(objcc_CourseChapterEN.SectionId, concc_CourseChapter.SectionId);
clsCheckSql.CheckSqlInjection4Field(objcc_CourseChapterEN.ChapterName, concc_CourseChapter.ChapterName);
clsCheckSql.CheckSqlInjection4Field(objcc_CourseChapterEN.SectionName, concc_CourseChapter.SectionName);
clsCheckSql.CheckSqlInjection4Field(objcc_CourseChapterEN.ChapterNameSim, concc_CourseChapter.ChapterNameSim);
clsCheckSql.CheckSqlInjection4Field(objcc_CourseChapterEN.SectionNameSim, concc_CourseChapter.SectionNameSim);
clsCheckSql.CheckSqlInjection4Field(objcc_CourseChapterEN.CourseId, concc_CourseChapter.CourseId);
clsCheckSql.CheckSqlInjection4Field(objcc_CourseChapterEN.ParentNodeId, concc_CourseChapter.ParentNodeId);
clsCheckSql.CheckSqlInjection4Field(objcc_CourseChapterEN.ThemeName, concc_CourseChapter.ThemeName);
clsCheckSql.CheckSqlInjection4Field(objcc_CourseChapterEN.CourseChapterReferred, concc_CourseChapter.CourseChapterReferred);
clsCheckSql.CheckSqlInjection4Field(objcc_CourseChapterEN.CreateDate, concc_CourseChapter.CreateDate);
clsCheckSql.CheckSqlInjection4Field(objcc_CourseChapterEN.EditPeople, concc_CourseChapter.EditPeople);
clsCheckSql.CheckSqlInjection4Field(objcc_CourseChapterEN.UpdDate, concc_CourseChapter.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objcc_CourseChapterEN.Memo, concc_CourseChapter.Memo);
//检查外键字段长度
 objcc_CourseChapterEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetCourseChapterId()
{
//获取某学院所有专业信息
string strSQL = "select CourseChapterId, CourseChapterName from cc_CourseChapter ";
 clsSpecSQLforSql mySql = clscc_CourseChapterDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--cc_CourseChapter(课程章节),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objcc_CourseChapterEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clscc_CourseChapterEN objcc_CourseChapterEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CourseId = '{0}'", objcc_CourseChapterEN.CourseId);
 sbCondition.AppendFormat(" and CourseChapterName = '{0}'", objcc_CourseChapterEN.CourseChapterName);
return sbCondition.ToString();
}

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
 objSQL = clscc_CourseChapterDA.GetSpecSQLObj();
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
 objSQL = clscc_CourseChapterDA.GetSpecSQLObj();
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
 objSQL = clscc_CourseChapterDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clscc_CourseChapterEN._CurrTabName);
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
 objSQL = clscc_CourseChapterDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clscc_CourseChapterEN._CurrTabName, strCondition);
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
 objSQL = clscc_CourseChapterDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 /// <summary>
 /// 功能:设置给定表中的符合条件的某字段的值
 /// (AutoGCLib.DALCode4CSharp:GenfunSetFldValue_S)
 /// </summary>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "varValue">值</param>
 /// <param name = "strCondition">条件串</param>
 /// <returns>影响的记录数</returns>
public static int SetFldValue<T>(string strTabName, string strFldName, T varValue, string strCondition) 
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseChapterDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}