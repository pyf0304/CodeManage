
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_CourseChapter4KnowledgeDA
 表名:vcc_CourseChapter4Knowledge(01120158)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:03:40
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
 /// v课程章节表4知识点(vcc_CourseChapter4Knowledge)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvcc_CourseChapter4KnowledgeDA : clsCommBase4DA
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
 return clsvcc_CourseChapter4KnowledgeEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvcc_CourseChapter4KnowledgeEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvcc_CourseChapter4KnowledgeEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvcc_CourseChapter4KnowledgeEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvcc_CourseChapter4KnowledgeEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:vcc_CourseChapter4Knowledge中,检查关键字,长度不正确!(clsvcc_CourseChapter4KnowledgeDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strCourseChapterId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vcc_CourseChapter4Knowledge中,关键字不能为空 或 null!(clsvcc_CourseChapter4KnowledgeDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCourseChapterId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvcc_CourseChapter4KnowledgeDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvcc_CourseChapter4KnowledgeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseChapter4KnowledgeDA.GetSpecSQLObj();
strSQL = "Select * from vcc_CourseChapter4Knowledge where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vcc_CourseChapter4Knowledge(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvcc_CourseChapter4KnowledgeDA: GetDataTable_vcc_CourseChapter4Knowledge)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseChapter4KnowledgeDA.GetSpecSQLObj();
strSQL = "Select * from vcc_CourseChapter4Knowledge where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvcc_CourseChapter4KnowledgeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseChapter4KnowledgeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvcc_CourseChapter4KnowledgeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseChapter4KnowledgeDA.GetSpecSQLObj();
strSQL = "Select * from vcc_CourseChapter4Knowledge where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvcc_CourseChapter4KnowledgeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseChapter4KnowledgeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvcc_CourseChapter4KnowledgeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseChapter4KnowledgeDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vcc_CourseChapter4Knowledge where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vcc_CourseChapter4Knowledge where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvcc_CourseChapter4KnowledgeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseChapter4KnowledgeDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vcc_CourseChapter4Knowledge where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvcc_CourseChapter4KnowledgeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseChapter4KnowledgeDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vcc_CourseChapter4Knowledge.* from vcc_CourseChapter4Knowledge Left Join {1} on {2} where {3} and vcc_CourseChapter4Knowledge.CourseChapterId not in (Select top {5} vcc_CourseChapter4Knowledge.CourseChapterId from vcc_CourseChapter4Knowledge Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vcc_CourseChapter4Knowledge where {1} and CourseChapterId not in (Select top {2} CourseChapterId from vcc_CourseChapter4Knowledge where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vcc_CourseChapter4Knowledge where {1} and CourseChapterId not in (Select top {3} CourseChapterId from vcc_CourseChapter4Knowledge where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvcc_CourseChapter4KnowledgeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseChapter4KnowledgeDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vcc_CourseChapter4Knowledge.* from vcc_CourseChapter4Knowledge Left Join {1} on {2} where {3} and vcc_CourseChapter4Knowledge.CourseChapterId not in (Select top {5} vcc_CourseChapter4Knowledge.CourseChapterId from vcc_CourseChapter4Knowledge Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vcc_CourseChapter4Knowledge where {1} and CourseChapterId not in (Select top {2} CourseChapterId from vcc_CourseChapter4Knowledge where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vcc_CourseChapter4Knowledge where {1} and CourseChapterId not in (Select top {3} CourseChapterId from vcc_CourseChapter4Knowledge where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvcc_CourseChapter4KnowledgeEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvcc_CourseChapter4KnowledgeDA:GetObjLst)", objException.Message));
}
List<clsvcc_CourseChapter4KnowledgeEN> arrObjLst = new List<clsvcc_CourseChapter4KnowledgeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseChapter4KnowledgeDA.GetSpecSQLObj();
strSQL = "Select * from vcc_CourseChapter4Knowledge where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN = new clsvcc_CourseChapter4KnowledgeEN();
try
{
objvcc_CourseChapter4KnowledgeEN.CourseChapterId = objRow[convcc_CourseChapter4Knowledge.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseChapter4KnowledgeEN.CourseChapterName = objRow[convcc_CourseChapter4Knowledge.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_CourseChapter4KnowledgeEN.ChapterId = objRow[convcc_CourseChapter4Knowledge.ChapterId] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ChapterId].ToString().Trim(); //章Id
objvcc_CourseChapter4KnowledgeEN.SectionId = objRow[convcc_CourseChapter4Knowledge.SectionId] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.SectionId].ToString().Trim(); //节Id
objvcc_CourseChapter4KnowledgeEN.ChapterName = objRow[convcc_CourseChapter4Knowledge.ChapterName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ChapterName].ToString().Trim(); //章名
objvcc_CourseChapter4KnowledgeEN.SectionName = objRow[convcc_CourseChapter4Knowledge.SectionName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.SectionName].ToString().Trim(); //节名
objvcc_CourseChapter4KnowledgeEN.ChapterNameSim = objRow[convcc_CourseChapter4Knowledge.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_CourseChapter4KnowledgeEN.SectionNameSim = objRow[convcc_CourseChapter4Knowledge.SectionNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.SectionNameSim].ToString().Trim(); //节名简称
objvcc_CourseChapter4KnowledgeEN.ChapterContent = objRow[convcc_CourseChapter4Knowledge.ChapterContent] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ChapterContent].ToString().Trim(); //章节内容
objvcc_CourseChapter4KnowledgeEN.CourseId = objRow[convcc_CourseChapter4Knowledge.CourseId].ToString().Trim(); //课程Id
objvcc_CourseChapter4KnowledgeEN.CourseCode = objRow[convcc_CourseChapter4Knowledge.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseChapter4KnowledgeEN.CourseName = objRow[convcc_CourseChapter4Knowledge.CourseName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.CourseName].ToString().Trim(); //课程名称
objvcc_CourseChapter4KnowledgeEN.ThemeId = objRow[convcc_CourseChapter4Knowledge.ThemeId] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseChapter4KnowledgeEN.ParentNodeId = objRow[convcc_CourseChapter4Knowledge.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_CourseChapter4KnowledgeEN.IsOpenToAllStu = TransNullToBool(objRow[convcc_CourseChapter4Knowledge.IsOpenToAllStu].ToString().Trim()); //全校师生
objvcc_CourseChapter4KnowledgeEN.IsOpenToSchool = TransNullToBool(objRow[convcc_CourseChapter4Knowledge.IsOpenToSchool].ToString().Trim()); //全校师生公开
objvcc_CourseChapter4KnowledgeEN.IsOpenToSocial = TransNullToBool(objRow[convcc_CourseChapter4Knowledge.IsOpenToSocial].ToString().Trim()); //社会公众
objvcc_CourseChapter4KnowledgeEN.IsMustMenu = TransNullToBool(objRow[convcc_CourseChapter4Knowledge.IsMustMenu].ToString().Trim()); //是否必建栏目
objvcc_CourseChapter4KnowledgeEN.ThemeName = objRow[convcc_CourseChapter4Knowledge.ThemeName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ThemeName].ToString().Trim(); //主题名
objvcc_CourseChapter4KnowledgeEN.IsFile = TransNullToBool(objRow[convcc_CourseChapter4Knowledge.IsFile].ToString().Trim()); //项目或文件夹
objvcc_CourseChapter4KnowledgeEN.IsUse = TransNullToBool(objRow[convcc_CourseChapter4Knowledge.IsUse].ToString().Trim()); //是否使用
objvcc_CourseChapter4KnowledgeEN.ViewCount = objRow[convcc_CourseChapter4Knowledge.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseChapter4Knowledge.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseChapter4KnowledgeEN.CourseChapterReferred = objRow[convcc_CourseChapter4Knowledge.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_CourseChapter4KnowledgeEN.OrderNum = objRow[convcc_CourseChapter4Knowledge.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseChapter4Knowledge.OrderNum].ToString().Trim()); //序号
objvcc_CourseChapter4KnowledgeEN.CreateDate = objRow[convcc_CourseChapter4Knowledge.CreateDate] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseChapter4KnowledgeEN.EditPeople = objRow[convcc_CourseChapter4Knowledge.EditPeople] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.EditPeople].ToString().Trim(); //修改人
objvcc_CourseChapter4KnowledgeEN.UpdDate = objRow[convcc_CourseChapter4Knowledge.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseChapter4KnowledgeEN.Memo = objRow[convcc_CourseChapter4Knowledge.Memo] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.Memo].ToString().Trim(); //备注
objvcc_CourseChapter4KnowledgeEN.ParentNodeName = objRow[convcc_CourseChapter4Knowledge.ParentNodeName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_CourseChapter4KnowledgeEN.ParentNodeReferred = objRow[convcc_CourseChapter4Knowledge.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_CourseChapter4KnowledgeEN.KnowledgeNum = objRow[convcc_CourseChapter4Knowledge.KnowledgeNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseChapter4Knowledge.KnowledgeNum].ToString().Trim()); //知识点数
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvcc_CourseChapter4KnowledgeDA: GetObjLst)", objException.Message));
}
objvcc_CourseChapter4KnowledgeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvcc_CourseChapter4KnowledgeEN);
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
public List<clsvcc_CourseChapter4KnowledgeEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvcc_CourseChapter4KnowledgeDA:GetObjLstByTabName)", objException.Message));
}
List<clsvcc_CourseChapter4KnowledgeEN> arrObjLst = new List<clsvcc_CourseChapter4KnowledgeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseChapter4KnowledgeDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN = new clsvcc_CourseChapter4KnowledgeEN();
try
{
objvcc_CourseChapter4KnowledgeEN.CourseChapterId = objRow[convcc_CourseChapter4Knowledge.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseChapter4KnowledgeEN.CourseChapterName = objRow[convcc_CourseChapter4Knowledge.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_CourseChapter4KnowledgeEN.ChapterId = objRow[convcc_CourseChapter4Knowledge.ChapterId] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ChapterId].ToString().Trim(); //章Id
objvcc_CourseChapter4KnowledgeEN.SectionId = objRow[convcc_CourseChapter4Knowledge.SectionId] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.SectionId].ToString().Trim(); //节Id
objvcc_CourseChapter4KnowledgeEN.ChapterName = objRow[convcc_CourseChapter4Knowledge.ChapterName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ChapterName].ToString().Trim(); //章名
objvcc_CourseChapter4KnowledgeEN.SectionName = objRow[convcc_CourseChapter4Knowledge.SectionName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.SectionName].ToString().Trim(); //节名
objvcc_CourseChapter4KnowledgeEN.ChapterNameSim = objRow[convcc_CourseChapter4Knowledge.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_CourseChapter4KnowledgeEN.SectionNameSim = objRow[convcc_CourseChapter4Knowledge.SectionNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.SectionNameSim].ToString().Trim(); //节名简称
objvcc_CourseChapter4KnowledgeEN.ChapterContent = objRow[convcc_CourseChapter4Knowledge.ChapterContent] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ChapterContent].ToString().Trim(); //章节内容
objvcc_CourseChapter4KnowledgeEN.CourseId = objRow[convcc_CourseChapter4Knowledge.CourseId].ToString().Trim(); //课程Id
objvcc_CourseChapter4KnowledgeEN.CourseCode = objRow[convcc_CourseChapter4Knowledge.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseChapter4KnowledgeEN.CourseName = objRow[convcc_CourseChapter4Knowledge.CourseName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.CourseName].ToString().Trim(); //课程名称
objvcc_CourseChapter4KnowledgeEN.ThemeId = objRow[convcc_CourseChapter4Knowledge.ThemeId] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseChapter4KnowledgeEN.ParentNodeId = objRow[convcc_CourseChapter4Knowledge.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_CourseChapter4KnowledgeEN.IsOpenToAllStu = TransNullToBool(objRow[convcc_CourseChapter4Knowledge.IsOpenToAllStu].ToString().Trim()); //全校师生
objvcc_CourseChapter4KnowledgeEN.IsOpenToSchool = TransNullToBool(objRow[convcc_CourseChapter4Knowledge.IsOpenToSchool].ToString().Trim()); //全校师生公开
objvcc_CourseChapter4KnowledgeEN.IsOpenToSocial = TransNullToBool(objRow[convcc_CourseChapter4Knowledge.IsOpenToSocial].ToString().Trim()); //社会公众
objvcc_CourseChapter4KnowledgeEN.IsMustMenu = TransNullToBool(objRow[convcc_CourseChapter4Knowledge.IsMustMenu].ToString().Trim()); //是否必建栏目
objvcc_CourseChapter4KnowledgeEN.ThemeName = objRow[convcc_CourseChapter4Knowledge.ThemeName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ThemeName].ToString().Trim(); //主题名
objvcc_CourseChapter4KnowledgeEN.IsFile = TransNullToBool(objRow[convcc_CourseChapter4Knowledge.IsFile].ToString().Trim()); //项目或文件夹
objvcc_CourseChapter4KnowledgeEN.IsUse = TransNullToBool(objRow[convcc_CourseChapter4Knowledge.IsUse].ToString().Trim()); //是否使用
objvcc_CourseChapter4KnowledgeEN.ViewCount = objRow[convcc_CourseChapter4Knowledge.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseChapter4Knowledge.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseChapter4KnowledgeEN.CourseChapterReferred = objRow[convcc_CourseChapter4Knowledge.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_CourseChapter4KnowledgeEN.OrderNum = objRow[convcc_CourseChapter4Knowledge.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseChapter4Knowledge.OrderNum].ToString().Trim()); //序号
objvcc_CourseChapter4KnowledgeEN.CreateDate = objRow[convcc_CourseChapter4Knowledge.CreateDate] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseChapter4KnowledgeEN.EditPeople = objRow[convcc_CourseChapter4Knowledge.EditPeople] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.EditPeople].ToString().Trim(); //修改人
objvcc_CourseChapter4KnowledgeEN.UpdDate = objRow[convcc_CourseChapter4Knowledge.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseChapter4KnowledgeEN.Memo = objRow[convcc_CourseChapter4Knowledge.Memo] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.Memo].ToString().Trim(); //备注
objvcc_CourseChapter4KnowledgeEN.ParentNodeName = objRow[convcc_CourseChapter4Knowledge.ParentNodeName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_CourseChapter4KnowledgeEN.ParentNodeReferred = objRow[convcc_CourseChapter4Knowledge.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_CourseChapter4KnowledgeEN.KnowledgeNum = objRow[convcc_CourseChapter4Knowledge.KnowledgeNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseChapter4Knowledge.KnowledgeNum].ToString().Trim()); //知识点数
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvcc_CourseChapter4KnowledgeDA: GetObjLst)", objException.Message));
}
objvcc_CourseChapter4KnowledgeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvcc_CourseChapter4KnowledgeEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4KnowledgeEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getvcc_CourseChapter4Knowledge(ref clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseChapter4KnowledgeDA.GetSpecSQLObj();
strSQL = "Select * from vcc_CourseChapter4Knowledge where CourseChapterId = " + "'"+ objvcc_CourseChapter4KnowledgeEN.CourseChapterId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvcc_CourseChapter4KnowledgeEN.CourseChapterId = objDT.Rows[0][convcc_CourseChapter4Knowledge.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objvcc_CourseChapter4KnowledgeEN.CourseChapterName = objDT.Rows[0][convcc_CourseChapter4Knowledge.CourseChapterName].ToString().Trim(); //课程章节名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvcc_CourseChapter4KnowledgeEN.ChapterId = objDT.Rows[0][convcc_CourseChapter4Knowledge.ChapterId].ToString().Trim(); //章Id(字段类型:char,字段长度:8,是否可空:True)
 objvcc_CourseChapter4KnowledgeEN.SectionId = objDT.Rows[0][convcc_CourseChapter4Knowledge.SectionId].ToString().Trim(); //节Id(字段类型:char,字段长度:8,是否可空:True)
 objvcc_CourseChapter4KnowledgeEN.ChapterName = objDT.Rows[0][convcc_CourseChapter4Knowledge.ChapterName].ToString().Trim(); //章名(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_CourseChapter4KnowledgeEN.SectionName = objDT.Rows[0][convcc_CourseChapter4Knowledge.SectionName].ToString().Trim(); //节名(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_CourseChapter4KnowledgeEN.ChapterNameSim = objDT.Rows[0][convcc_CourseChapter4Knowledge.ChapterNameSim].ToString().Trim(); //章名简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_CourseChapter4KnowledgeEN.SectionNameSim = objDT.Rows[0][convcc_CourseChapter4Knowledge.SectionNameSim].ToString().Trim(); //节名简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_CourseChapter4KnowledgeEN.ChapterContent = objDT.Rows[0][convcc_CourseChapter4Knowledge.ChapterContent].ToString().Trim(); //章节内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvcc_CourseChapter4KnowledgeEN.CourseId = objDT.Rows[0][convcc_CourseChapter4Knowledge.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvcc_CourseChapter4KnowledgeEN.CourseCode = objDT.Rows[0][convcc_CourseChapter4Knowledge.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_CourseChapter4KnowledgeEN.CourseName = objDT.Rows[0][convcc_CourseChapter4Knowledge.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_CourseChapter4KnowledgeEN.ThemeId = objDT.Rows[0][convcc_CourseChapter4Knowledge.ThemeId].ToString().Trim(); //主题Id(字段类型:char,字段长度:4,是否可空:False)
 objvcc_CourseChapter4KnowledgeEN.ParentNodeId = objDT.Rows[0][convcc_CourseChapter4Knowledge.ParentNodeId].ToString().Trim(); //父节点编号(字段类型:varchar,字段长度:8,是否可空:True)
 objvcc_CourseChapter4KnowledgeEN.IsOpenToAllStu = TransNullToBool(objDT.Rows[0][convcc_CourseChapter4Knowledge.IsOpenToAllStu].ToString().Trim()); //全校师生(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_CourseChapter4KnowledgeEN.IsOpenToSchool = TransNullToBool(objDT.Rows[0][convcc_CourseChapter4Knowledge.IsOpenToSchool].ToString().Trim()); //全校师生公开(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_CourseChapter4KnowledgeEN.IsOpenToSocial = TransNullToBool(objDT.Rows[0][convcc_CourseChapter4Knowledge.IsOpenToSocial].ToString().Trim()); //社会公众(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_CourseChapter4KnowledgeEN.IsMustMenu = TransNullToBool(objDT.Rows[0][convcc_CourseChapter4Knowledge.IsMustMenu].ToString().Trim()); //是否必建栏目(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_CourseChapter4KnowledgeEN.ThemeName = objDT.Rows[0][convcc_CourseChapter4Knowledge.ThemeName].ToString().Trim(); //主题名(字段类型:varchar,字段长度:200,是否可空:False)
 objvcc_CourseChapter4KnowledgeEN.IsFile = TransNullToBool(objDT.Rows[0][convcc_CourseChapter4Knowledge.IsFile].ToString().Trim()); //项目或文件夹(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_CourseChapter4KnowledgeEN.IsUse = TransNullToBool(objDT.Rows[0][convcc_CourseChapter4Knowledge.IsUse].ToString().Trim()); //是否使用(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_CourseChapter4KnowledgeEN.ViewCount = TransNullToInt(objDT.Rows[0][convcc_CourseChapter4Knowledge.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvcc_CourseChapter4KnowledgeEN.CourseChapterReferred = objDT.Rows[0][convcc_CourseChapter4Knowledge.CourseChapterReferred].ToString().Trim(); //节简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_CourseChapter4KnowledgeEN.OrderNum = TransNullToInt(objDT.Rows[0][convcc_CourseChapter4Knowledge.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvcc_CourseChapter4KnowledgeEN.CreateDate = objDT.Rows[0][convcc_CourseChapter4Knowledge.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_CourseChapter4KnowledgeEN.EditPeople = objDT.Rows[0][convcc_CourseChapter4Knowledge.EditPeople].ToString().Trim(); //修改人(字段类型:varchar,字段长度:50,是否可空:True)
 objvcc_CourseChapter4KnowledgeEN.UpdDate = objDT.Rows[0][convcc_CourseChapter4Knowledge.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_CourseChapter4KnowledgeEN.Memo = objDT.Rows[0][convcc_CourseChapter4Knowledge.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvcc_CourseChapter4KnowledgeEN.ParentNodeName = objDT.Rows[0][convcc_CourseChapter4Knowledge.ParentNodeName].ToString().Trim(); //父节点名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_CourseChapter4KnowledgeEN.ParentNodeReferred = objDT.Rows[0][convcc_CourseChapter4Knowledge.ParentNodeReferred].ToString().Trim(); //章简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_CourseChapter4KnowledgeEN.KnowledgeNum = TransNullToInt(objDT.Rows[0][convcc_CourseChapter4Knowledge.KnowledgeNum].ToString().Trim()); //知识点数(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvcc_CourseChapter4KnowledgeDA: Getvcc_CourseChapter4Knowledge)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strCourseChapterId">表关键字</param>
 /// <returns>表对象</returns>
public clsvcc_CourseChapter4KnowledgeEN GetObjByCourseChapterId(string strCourseChapterId)
{
CheckPrimaryKey(strCourseChapterId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseChapter4KnowledgeDA.GetSpecSQLObj();
strSQL = "Select * from vcc_CourseChapter4Knowledge where CourseChapterId = " + "'"+ strCourseChapterId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN = new clsvcc_CourseChapter4KnowledgeEN();
try
{
 objvcc_CourseChapter4KnowledgeEN.CourseChapterId = objRow[convcc_CourseChapter4Knowledge.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objvcc_CourseChapter4KnowledgeEN.CourseChapterName = objRow[convcc_CourseChapter4Knowledge.CourseChapterName].ToString().Trim(); //课程章节名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvcc_CourseChapter4KnowledgeEN.ChapterId = objRow[convcc_CourseChapter4Knowledge.ChapterId] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ChapterId].ToString().Trim(); //章Id(字段类型:char,字段长度:8,是否可空:True)
 objvcc_CourseChapter4KnowledgeEN.SectionId = objRow[convcc_CourseChapter4Knowledge.SectionId] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.SectionId].ToString().Trim(); //节Id(字段类型:char,字段长度:8,是否可空:True)
 objvcc_CourseChapter4KnowledgeEN.ChapterName = objRow[convcc_CourseChapter4Knowledge.ChapterName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ChapterName].ToString().Trim(); //章名(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_CourseChapter4KnowledgeEN.SectionName = objRow[convcc_CourseChapter4Knowledge.SectionName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.SectionName].ToString().Trim(); //节名(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_CourseChapter4KnowledgeEN.ChapterNameSim = objRow[convcc_CourseChapter4Knowledge.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ChapterNameSim].ToString().Trim(); //章名简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_CourseChapter4KnowledgeEN.SectionNameSim = objRow[convcc_CourseChapter4Knowledge.SectionNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.SectionNameSim].ToString().Trim(); //节名简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_CourseChapter4KnowledgeEN.ChapterContent = objRow[convcc_CourseChapter4Knowledge.ChapterContent] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ChapterContent].ToString().Trim(); //章节内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvcc_CourseChapter4KnowledgeEN.CourseId = objRow[convcc_CourseChapter4Knowledge.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvcc_CourseChapter4KnowledgeEN.CourseCode = objRow[convcc_CourseChapter4Knowledge.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_CourseChapter4KnowledgeEN.CourseName = objRow[convcc_CourseChapter4Knowledge.CourseName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_CourseChapter4KnowledgeEN.ThemeId = objRow[convcc_CourseChapter4Knowledge.ThemeId] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ThemeId].ToString().Trim(); //主题Id(字段类型:char,字段长度:4,是否可空:False)
 objvcc_CourseChapter4KnowledgeEN.ParentNodeId = objRow[convcc_CourseChapter4Knowledge.ParentNodeId].ToString().Trim(); //父节点编号(字段类型:varchar,字段长度:8,是否可空:True)
 objvcc_CourseChapter4KnowledgeEN.IsOpenToAllStu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4Knowledge.IsOpenToAllStu].ToString().Trim()); //全校师生(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_CourseChapter4KnowledgeEN.IsOpenToSchool = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4Knowledge.IsOpenToSchool].ToString().Trim()); //全校师生公开(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_CourseChapter4KnowledgeEN.IsOpenToSocial = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4Knowledge.IsOpenToSocial].ToString().Trim()); //社会公众(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_CourseChapter4KnowledgeEN.IsMustMenu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4Knowledge.IsMustMenu].ToString().Trim()); //是否必建栏目(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_CourseChapter4KnowledgeEN.ThemeName = objRow[convcc_CourseChapter4Knowledge.ThemeName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ThemeName].ToString().Trim(); //主题名(字段类型:varchar,字段长度:200,是否可空:False)
 objvcc_CourseChapter4KnowledgeEN.IsFile = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4Knowledge.IsFile].ToString().Trim()); //项目或文件夹(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_CourseChapter4KnowledgeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4Knowledge.IsUse].ToString().Trim()); //是否使用(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_CourseChapter4KnowledgeEN.ViewCount = objRow[convcc_CourseChapter4Knowledge.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter4Knowledge.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvcc_CourseChapter4KnowledgeEN.CourseChapterReferred = objRow[convcc_CourseChapter4Knowledge.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.CourseChapterReferred].ToString().Trim(); //节简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_CourseChapter4KnowledgeEN.OrderNum = objRow[convcc_CourseChapter4Knowledge.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter4Knowledge.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvcc_CourseChapter4KnowledgeEN.CreateDate = objRow[convcc_CourseChapter4Knowledge.CreateDate] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_CourseChapter4KnowledgeEN.EditPeople = objRow[convcc_CourseChapter4Knowledge.EditPeople] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.EditPeople].ToString().Trim(); //修改人(字段类型:varchar,字段长度:50,是否可空:True)
 objvcc_CourseChapter4KnowledgeEN.UpdDate = objRow[convcc_CourseChapter4Knowledge.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_CourseChapter4KnowledgeEN.Memo = objRow[convcc_CourseChapter4Knowledge.Memo] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvcc_CourseChapter4KnowledgeEN.ParentNodeName = objRow[convcc_CourseChapter4Knowledge.ParentNodeName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ParentNodeName].ToString().Trim(); //父节点名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_CourseChapter4KnowledgeEN.ParentNodeReferred = objRow[convcc_CourseChapter4Knowledge.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ParentNodeReferred].ToString().Trim(); //章简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_CourseChapter4KnowledgeEN.KnowledgeNum = objRow[convcc_CourseChapter4Knowledge.KnowledgeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter4Knowledge.KnowledgeNum].ToString().Trim()); //知识点数(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvcc_CourseChapter4KnowledgeDA: GetObjByCourseChapterId)", objException.Message));
}
return objvcc_CourseChapter4KnowledgeEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvcc_CourseChapter4KnowledgeEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvcc_CourseChapter4KnowledgeDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseChapter4KnowledgeDA.GetSpecSQLObj();
strSQL = "Select * from vcc_CourseChapter4Knowledge where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN = new clsvcc_CourseChapter4KnowledgeEN()
{
CourseChapterId = objRow[convcc_CourseChapter4Knowledge.CourseChapterId].ToString().Trim(), //课程章节ID
CourseChapterName = objRow[convcc_CourseChapter4Knowledge.CourseChapterName].ToString().Trim(), //课程章节名称
ChapterId = objRow[convcc_CourseChapter4Knowledge.ChapterId] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ChapterId].ToString().Trim(), //章Id
SectionId = objRow[convcc_CourseChapter4Knowledge.SectionId] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.SectionId].ToString().Trim(), //节Id
ChapterName = objRow[convcc_CourseChapter4Knowledge.ChapterName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ChapterName].ToString().Trim(), //章名
SectionName = objRow[convcc_CourseChapter4Knowledge.SectionName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.SectionName].ToString().Trim(), //节名
ChapterNameSim = objRow[convcc_CourseChapter4Knowledge.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ChapterNameSim].ToString().Trim(), //章名简称
SectionNameSim = objRow[convcc_CourseChapter4Knowledge.SectionNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.SectionNameSim].ToString().Trim(), //节名简称
ChapterContent = objRow[convcc_CourseChapter4Knowledge.ChapterContent] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ChapterContent].ToString().Trim(), //章节内容
CourseId = objRow[convcc_CourseChapter4Knowledge.CourseId].ToString().Trim(), //课程Id
CourseCode = objRow[convcc_CourseChapter4Knowledge.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.CourseCode].ToString().Trim(), //课程代码
CourseName = objRow[convcc_CourseChapter4Knowledge.CourseName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.CourseName].ToString().Trim(), //课程名称
ThemeId = objRow[convcc_CourseChapter4Knowledge.ThemeId] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ThemeId].ToString().Trim(), //主题Id
ParentNodeId = objRow[convcc_CourseChapter4Knowledge.ParentNodeId].ToString().Trim(), //父节点编号
IsOpenToAllStu = TransNullToBool(objRow[convcc_CourseChapter4Knowledge.IsOpenToAllStu].ToString().Trim()), //全校师生
IsOpenToSchool = TransNullToBool(objRow[convcc_CourseChapter4Knowledge.IsOpenToSchool].ToString().Trim()), //全校师生公开
IsOpenToSocial = TransNullToBool(objRow[convcc_CourseChapter4Knowledge.IsOpenToSocial].ToString().Trim()), //社会公众
IsMustMenu = TransNullToBool(objRow[convcc_CourseChapter4Knowledge.IsMustMenu].ToString().Trim()), //是否必建栏目
ThemeName = objRow[convcc_CourseChapter4Knowledge.ThemeName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ThemeName].ToString().Trim(), //主题名
IsFile = TransNullToBool(objRow[convcc_CourseChapter4Knowledge.IsFile].ToString().Trim()), //项目或文件夹
IsUse = TransNullToBool(objRow[convcc_CourseChapter4Knowledge.IsUse].ToString().Trim()), //是否使用
ViewCount = objRow[convcc_CourseChapter4Knowledge.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseChapter4Knowledge.ViewCount].ToString().Trim()), //浏览量
CourseChapterReferred = objRow[convcc_CourseChapter4Knowledge.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.CourseChapterReferred].ToString().Trim(), //节简称
OrderNum = objRow[convcc_CourseChapter4Knowledge.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseChapter4Knowledge.OrderNum].ToString().Trim()), //序号
CreateDate = objRow[convcc_CourseChapter4Knowledge.CreateDate] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.CreateDate].ToString().Trim(), //建立日期
EditPeople = objRow[convcc_CourseChapter4Knowledge.EditPeople] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.EditPeople].ToString().Trim(), //修改人
UpdDate = objRow[convcc_CourseChapter4Knowledge.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[convcc_CourseChapter4Knowledge.Memo] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.Memo].ToString().Trim(), //备注
ParentNodeName = objRow[convcc_CourseChapter4Knowledge.ParentNodeName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ParentNodeName].ToString().Trim(), //父节点名称
ParentNodeReferred = objRow[convcc_CourseChapter4Knowledge.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ParentNodeReferred].ToString().Trim(), //章简称
KnowledgeNum = objRow[convcc_CourseChapter4Knowledge.KnowledgeNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseChapter4Knowledge.KnowledgeNum].ToString().Trim()) //知识点数
};
objvcc_CourseChapter4KnowledgeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvcc_CourseChapter4KnowledgeEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvcc_CourseChapter4KnowledgeDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvcc_CourseChapter4KnowledgeEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN = new clsvcc_CourseChapter4KnowledgeEN();
try
{
objvcc_CourseChapter4KnowledgeEN.CourseChapterId = objRow[convcc_CourseChapter4Knowledge.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseChapter4KnowledgeEN.CourseChapterName = objRow[convcc_CourseChapter4Knowledge.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_CourseChapter4KnowledgeEN.ChapterId = objRow[convcc_CourseChapter4Knowledge.ChapterId] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ChapterId].ToString().Trim(); //章Id
objvcc_CourseChapter4KnowledgeEN.SectionId = objRow[convcc_CourseChapter4Knowledge.SectionId] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.SectionId].ToString().Trim(); //节Id
objvcc_CourseChapter4KnowledgeEN.ChapterName = objRow[convcc_CourseChapter4Knowledge.ChapterName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ChapterName].ToString().Trim(); //章名
objvcc_CourseChapter4KnowledgeEN.SectionName = objRow[convcc_CourseChapter4Knowledge.SectionName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.SectionName].ToString().Trim(); //节名
objvcc_CourseChapter4KnowledgeEN.ChapterNameSim = objRow[convcc_CourseChapter4Knowledge.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_CourseChapter4KnowledgeEN.SectionNameSim = objRow[convcc_CourseChapter4Knowledge.SectionNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.SectionNameSim].ToString().Trim(); //节名简称
objvcc_CourseChapter4KnowledgeEN.ChapterContent = objRow[convcc_CourseChapter4Knowledge.ChapterContent] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ChapterContent].ToString().Trim(); //章节内容
objvcc_CourseChapter4KnowledgeEN.CourseId = objRow[convcc_CourseChapter4Knowledge.CourseId].ToString().Trim(); //课程Id
objvcc_CourseChapter4KnowledgeEN.CourseCode = objRow[convcc_CourseChapter4Knowledge.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseChapter4KnowledgeEN.CourseName = objRow[convcc_CourseChapter4Knowledge.CourseName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.CourseName].ToString().Trim(); //课程名称
objvcc_CourseChapter4KnowledgeEN.ThemeId = objRow[convcc_CourseChapter4Knowledge.ThemeId] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseChapter4KnowledgeEN.ParentNodeId = objRow[convcc_CourseChapter4Knowledge.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_CourseChapter4KnowledgeEN.IsOpenToAllStu = TransNullToBool(objRow[convcc_CourseChapter4Knowledge.IsOpenToAllStu].ToString().Trim()); //全校师生
objvcc_CourseChapter4KnowledgeEN.IsOpenToSchool = TransNullToBool(objRow[convcc_CourseChapter4Knowledge.IsOpenToSchool].ToString().Trim()); //全校师生公开
objvcc_CourseChapter4KnowledgeEN.IsOpenToSocial = TransNullToBool(objRow[convcc_CourseChapter4Knowledge.IsOpenToSocial].ToString().Trim()); //社会公众
objvcc_CourseChapter4KnowledgeEN.IsMustMenu = TransNullToBool(objRow[convcc_CourseChapter4Knowledge.IsMustMenu].ToString().Trim()); //是否必建栏目
objvcc_CourseChapter4KnowledgeEN.ThemeName = objRow[convcc_CourseChapter4Knowledge.ThemeName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ThemeName].ToString().Trim(); //主题名
objvcc_CourseChapter4KnowledgeEN.IsFile = TransNullToBool(objRow[convcc_CourseChapter4Knowledge.IsFile].ToString().Trim()); //项目或文件夹
objvcc_CourseChapter4KnowledgeEN.IsUse = TransNullToBool(objRow[convcc_CourseChapter4Knowledge.IsUse].ToString().Trim()); //是否使用
objvcc_CourseChapter4KnowledgeEN.ViewCount = objRow[convcc_CourseChapter4Knowledge.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseChapter4Knowledge.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseChapter4KnowledgeEN.CourseChapterReferred = objRow[convcc_CourseChapter4Knowledge.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_CourseChapter4KnowledgeEN.OrderNum = objRow[convcc_CourseChapter4Knowledge.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseChapter4Knowledge.OrderNum].ToString().Trim()); //序号
objvcc_CourseChapter4KnowledgeEN.CreateDate = objRow[convcc_CourseChapter4Knowledge.CreateDate] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseChapter4KnowledgeEN.EditPeople = objRow[convcc_CourseChapter4Knowledge.EditPeople] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.EditPeople].ToString().Trim(); //修改人
objvcc_CourseChapter4KnowledgeEN.UpdDate = objRow[convcc_CourseChapter4Knowledge.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseChapter4KnowledgeEN.Memo = objRow[convcc_CourseChapter4Knowledge.Memo] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.Memo].ToString().Trim(); //备注
objvcc_CourseChapter4KnowledgeEN.ParentNodeName = objRow[convcc_CourseChapter4Knowledge.ParentNodeName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_CourseChapter4KnowledgeEN.ParentNodeReferred = objRow[convcc_CourseChapter4Knowledge.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_CourseChapter4KnowledgeEN.KnowledgeNum = objRow[convcc_CourseChapter4Knowledge.KnowledgeNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseChapter4Knowledge.KnowledgeNum].ToString().Trim()); //知识点数
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvcc_CourseChapter4KnowledgeDA: GetObjByDataRowvcc_CourseChapter4Knowledge)", objException.Message));
}
objvcc_CourseChapter4KnowledgeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvcc_CourseChapter4KnowledgeEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvcc_CourseChapter4KnowledgeEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN = new clsvcc_CourseChapter4KnowledgeEN();
try
{
objvcc_CourseChapter4KnowledgeEN.CourseChapterId = objRow[convcc_CourseChapter4Knowledge.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseChapter4KnowledgeEN.CourseChapterName = objRow[convcc_CourseChapter4Knowledge.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_CourseChapter4KnowledgeEN.ChapterId = objRow[convcc_CourseChapter4Knowledge.ChapterId] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ChapterId].ToString().Trim(); //章Id
objvcc_CourseChapter4KnowledgeEN.SectionId = objRow[convcc_CourseChapter4Knowledge.SectionId] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.SectionId].ToString().Trim(); //节Id
objvcc_CourseChapter4KnowledgeEN.ChapterName = objRow[convcc_CourseChapter4Knowledge.ChapterName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ChapterName].ToString().Trim(); //章名
objvcc_CourseChapter4KnowledgeEN.SectionName = objRow[convcc_CourseChapter4Knowledge.SectionName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.SectionName].ToString().Trim(); //节名
objvcc_CourseChapter4KnowledgeEN.ChapterNameSim = objRow[convcc_CourseChapter4Knowledge.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_CourseChapter4KnowledgeEN.SectionNameSim = objRow[convcc_CourseChapter4Knowledge.SectionNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.SectionNameSim].ToString().Trim(); //节名简称
objvcc_CourseChapter4KnowledgeEN.ChapterContent = objRow[convcc_CourseChapter4Knowledge.ChapterContent] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ChapterContent].ToString().Trim(); //章节内容
objvcc_CourseChapter4KnowledgeEN.CourseId = objRow[convcc_CourseChapter4Knowledge.CourseId].ToString().Trim(); //课程Id
objvcc_CourseChapter4KnowledgeEN.CourseCode = objRow[convcc_CourseChapter4Knowledge.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseChapter4KnowledgeEN.CourseName = objRow[convcc_CourseChapter4Knowledge.CourseName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.CourseName].ToString().Trim(); //课程名称
objvcc_CourseChapter4KnowledgeEN.ThemeId = objRow[convcc_CourseChapter4Knowledge.ThemeId] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseChapter4KnowledgeEN.ParentNodeId = objRow[convcc_CourseChapter4Knowledge.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_CourseChapter4KnowledgeEN.IsOpenToAllStu = TransNullToBool(objRow[convcc_CourseChapter4Knowledge.IsOpenToAllStu].ToString().Trim()); //全校师生
objvcc_CourseChapter4KnowledgeEN.IsOpenToSchool = TransNullToBool(objRow[convcc_CourseChapter4Knowledge.IsOpenToSchool].ToString().Trim()); //全校师生公开
objvcc_CourseChapter4KnowledgeEN.IsOpenToSocial = TransNullToBool(objRow[convcc_CourseChapter4Knowledge.IsOpenToSocial].ToString().Trim()); //社会公众
objvcc_CourseChapter4KnowledgeEN.IsMustMenu = TransNullToBool(objRow[convcc_CourseChapter4Knowledge.IsMustMenu].ToString().Trim()); //是否必建栏目
objvcc_CourseChapter4KnowledgeEN.ThemeName = objRow[convcc_CourseChapter4Knowledge.ThemeName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ThemeName].ToString().Trim(); //主题名
objvcc_CourseChapter4KnowledgeEN.IsFile = TransNullToBool(objRow[convcc_CourseChapter4Knowledge.IsFile].ToString().Trim()); //项目或文件夹
objvcc_CourseChapter4KnowledgeEN.IsUse = TransNullToBool(objRow[convcc_CourseChapter4Knowledge.IsUse].ToString().Trim()); //是否使用
objvcc_CourseChapter4KnowledgeEN.ViewCount = objRow[convcc_CourseChapter4Knowledge.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseChapter4Knowledge.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseChapter4KnowledgeEN.CourseChapterReferred = objRow[convcc_CourseChapter4Knowledge.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_CourseChapter4KnowledgeEN.OrderNum = objRow[convcc_CourseChapter4Knowledge.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseChapter4Knowledge.OrderNum].ToString().Trim()); //序号
objvcc_CourseChapter4KnowledgeEN.CreateDate = objRow[convcc_CourseChapter4Knowledge.CreateDate] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseChapter4KnowledgeEN.EditPeople = objRow[convcc_CourseChapter4Knowledge.EditPeople] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.EditPeople].ToString().Trim(); //修改人
objvcc_CourseChapter4KnowledgeEN.UpdDate = objRow[convcc_CourseChapter4Knowledge.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseChapter4KnowledgeEN.Memo = objRow[convcc_CourseChapter4Knowledge.Memo] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.Memo].ToString().Trim(); //备注
objvcc_CourseChapter4KnowledgeEN.ParentNodeName = objRow[convcc_CourseChapter4Knowledge.ParentNodeName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_CourseChapter4KnowledgeEN.ParentNodeReferred = objRow[convcc_CourseChapter4Knowledge.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_CourseChapter4KnowledgeEN.KnowledgeNum = objRow[convcc_CourseChapter4Knowledge.KnowledgeNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseChapter4Knowledge.KnowledgeNum].ToString().Trim()); //知识点数
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvcc_CourseChapter4KnowledgeDA: GetObjByDataRow)", objException.Message));
}
objvcc_CourseChapter4KnowledgeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvcc_CourseChapter4KnowledgeEN;
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
objSQL = clsvcc_CourseChapter4KnowledgeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvcc_CourseChapter4KnowledgeEN._CurrTabName, convcc_CourseChapter4Knowledge.CourseChapterId, 8, "");
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
objSQL = clsvcc_CourseChapter4KnowledgeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvcc_CourseChapter4KnowledgeEN._CurrTabName, convcc_CourseChapter4Knowledge.CourseChapterId, 8, strPrefix);
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
 objSQL = clsvcc_CourseChapter4KnowledgeDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select CourseChapterId from vcc_CourseChapter4Knowledge where " + strCondition;
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
 objSQL = clsvcc_CourseChapter4KnowledgeDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select CourseChapterId from vcc_CourseChapter4Knowledge where " + strCondition;
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
 objSQL = clsvcc_CourseChapter4KnowledgeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vcc_CourseChapter4Knowledge", "CourseChapterId = " + "'"+ strCourseChapterId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvcc_CourseChapter4KnowledgeDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseChapter4KnowledgeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vcc_CourseChapter4Knowledge", strCondition))
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
objSQL = clsvcc_CourseChapter4KnowledgeDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vcc_CourseChapter4Knowledge");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4KnowledgeENS">源对象</param>
 /// <param name = "objvcc_CourseChapter4KnowledgeENT">目标对象</param>
public void CopyTo(clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeENS, clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeENT)
{
objvcc_CourseChapter4KnowledgeENT.CourseChapterId = objvcc_CourseChapter4KnowledgeENS.CourseChapterId; //课程章节ID
objvcc_CourseChapter4KnowledgeENT.CourseChapterName = objvcc_CourseChapter4KnowledgeENS.CourseChapterName; //课程章节名称
objvcc_CourseChapter4KnowledgeENT.ChapterId = objvcc_CourseChapter4KnowledgeENS.ChapterId; //章Id
objvcc_CourseChapter4KnowledgeENT.SectionId = objvcc_CourseChapter4KnowledgeENS.SectionId; //节Id
objvcc_CourseChapter4KnowledgeENT.ChapterName = objvcc_CourseChapter4KnowledgeENS.ChapterName; //章名
objvcc_CourseChapter4KnowledgeENT.SectionName = objvcc_CourseChapter4KnowledgeENS.SectionName; //节名
objvcc_CourseChapter4KnowledgeENT.ChapterNameSim = objvcc_CourseChapter4KnowledgeENS.ChapterNameSim; //章名简称
objvcc_CourseChapter4KnowledgeENT.SectionNameSim = objvcc_CourseChapter4KnowledgeENS.SectionNameSim; //节名简称
objvcc_CourseChapter4KnowledgeENT.ChapterContent = objvcc_CourseChapter4KnowledgeENS.ChapterContent; //章节内容
objvcc_CourseChapter4KnowledgeENT.CourseId = objvcc_CourseChapter4KnowledgeENS.CourseId; //课程Id
objvcc_CourseChapter4KnowledgeENT.CourseCode = objvcc_CourseChapter4KnowledgeENS.CourseCode; //课程代码
objvcc_CourseChapter4KnowledgeENT.CourseName = objvcc_CourseChapter4KnowledgeENS.CourseName; //课程名称
objvcc_CourseChapter4KnowledgeENT.ThemeId = objvcc_CourseChapter4KnowledgeENS.ThemeId; //主题Id
objvcc_CourseChapter4KnowledgeENT.ParentNodeId = objvcc_CourseChapter4KnowledgeENS.ParentNodeId; //父节点编号
objvcc_CourseChapter4KnowledgeENT.IsOpenToAllStu = objvcc_CourseChapter4KnowledgeENS.IsOpenToAllStu; //全校师生
objvcc_CourseChapter4KnowledgeENT.IsOpenToSchool = objvcc_CourseChapter4KnowledgeENS.IsOpenToSchool; //全校师生公开
objvcc_CourseChapter4KnowledgeENT.IsOpenToSocial = objvcc_CourseChapter4KnowledgeENS.IsOpenToSocial; //社会公众
objvcc_CourseChapter4KnowledgeENT.IsMustMenu = objvcc_CourseChapter4KnowledgeENS.IsMustMenu; //是否必建栏目
objvcc_CourseChapter4KnowledgeENT.ThemeName = objvcc_CourseChapter4KnowledgeENS.ThemeName; //主题名
objvcc_CourseChapter4KnowledgeENT.IsFile = objvcc_CourseChapter4KnowledgeENS.IsFile; //项目或文件夹
objvcc_CourseChapter4KnowledgeENT.IsUse = objvcc_CourseChapter4KnowledgeENS.IsUse; //是否使用
objvcc_CourseChapter4KnowledgeENT.ViewCount = objvcc_CourseChapter4KnowledgeENS.ViewCount; //浏览量
objvcc_CourseChapter4KnowledgeENT.CourseChapterReferred = objvcc_CourseChapter4KnowledgeENS.CourseChapterReferred; //节简称
objvcc_CourseChapter4KnowledgeENT.OrderNum = objvcc_CourseChapter4KnowledgeENS.OrderNum; //序号
objvcc_CourseChapter4KnowledgeENT.CreateDate = objvcc_CourseChapter4KnowledgeENS.CreateDate; //建立日期
objvcc_CourseChapter4KnowledgeENT.EditPeople = objvcc_CourseChapter4KnowledgeENS.EditPeople; //修改人
objvcc_CourseChapter4KnowledgeENT.UpdDate = objvcc_CourseChapter4KnowledgeENS.UpdDate; //修改日期
objvcc_CourseChapter4KnowledgeENT.Memo = objvcc_CourseChapter4KnowledgeENS.Memo; //备注
objvcc_CourseChapter4KnowledgeENT.ParentNodeName = objvcc_CourseChapter4KnowledgeENS.ParentNodeName; //父节点名称
objvcc_CourseChapter4KnowledgeENT.ParentNodeReferred = objvcc_CourseChapter4KnowledgeENS.ParentNodeReferred; //章简称
objvcc_CourseChapter4KnowledgeENT.KnowledgeNum = objvcc_CourseChapter4KnowledgeENS.KnowledgeNum; //知识点数
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvcc_CourseChapter4KnowledgeEN.CourseChapterId, 8, convcc_CourseChapter4Knowledge.CourseChapterId);
clsCheckSql.CheckFieldLen(objvcc_CourseChapter4KnowledgeEN.CourseChapterName, 100, convcc_CourseChapter4Knowledge.CourseChapterName);
clsCheckSql.CheckFieldLen(objvcc_CourseChapter4KnowledgeEN.ChapterId, 8, convcc_CourseChapter4Knowledge.ChapterId);
clsCheckSql.CheckFieldLen(objvcc_CourseChapter4KnowledgeEN.SectionId, 8, convcc_CourseChapter4Knowledge.SectionId);
clsCheckSql.CheckFieldLen(objvcc_CourseChapter4KnowledgeEN.ChapterName, 100, convcc_CourseChapter4Knowledge.ChapterName);
clsCheckSql.CheckFieldLen(objvcc_CourseChapter4KnowledgeEN.SectionName, 100, convcc_CourseChapter4Knowledge.SectionName);
clsCheckSql.CheckFieldLen(objvcc_CourseChapter4KnowledgeEN.ChapterNameSim, 10, convcc_CourseChapter4Knowledge.ChapterNameSim);
clsCheckSql.CheckFieldLen(objvcc_CourseChapter4KnowledgeEN.SectionNameSim, 10, convcc_CourseChapter4Knowledge.SectionNameSim);
clsCheckSql.CheckFieldLen(objvcc_CourseChapter4KnowledgeEN.CourseId, 8, convcc_CourseChapter4Knowledge.CourseId);
clsCheckSql.CheckFieldLen(objvcc_CourseChapter4KnowledgeEN.CourseCode, 20, convcc_CourseChapter4Knowledge.CourseCode);
clsCheckSql.CheckFieldLen(objvcc_CourseChapter4KnowledgeEN.CourseName, 100, convcc_CourseChapter4Knowledge.CourseName);
clsCheckSql.CheckFieldLen(objvcc_CourseChapter4KnowledgeEN.ThemeId, 4, convcc_CourseChapter4Knowledge.ThemeId);
clsCheckSql.CheckFieldLen(objvcc_CourseChapter4KnowledgeEN.ParentNodeId, 8, convcc_CourseChapter4Knowledge.ParentNodeId);
clsCheckSql.CheckFieldLen(objvcc_CourseChapter4KnowledgeEN.ThemeName, 200, convcc_CourseChapter4Knowledge.ThemeName);
clsCheckSql.CheckFieldLen(objvcc_CourseChapter4KnowledgeEN.CourseChapterReferred, 10, convcc_CourseChapter4Knowledge.CourseChapterReferred);
clsCheckSql.CheckFieldLen(objvcc_CourseChapter4KnowledgeEN.CreateDate, 20, convcc_CourseChapter4Knowledge.CreateDate);
clsCheckSql.CheckFieldLen(objvcc_CourseChapter4KnowledgeEN.EditPeople, 50, convcc_CourseChapter4Knowledge.EditPeople);
clsCheckSql.CheckFieldLen(objvcc_CourseChapter4KnowledgeEN.UpdDate, 20, convcc_CourseChapter4Knowledge.UpdDate);
clsCheckSql.CheckFieldLen(objvcc_CourseChapter4KnowledgeEN.Memo, 1000, convcc_CourseChapter4Knowledge.Memo);
clsCheckSql.CheckFieldLen(objvcc_CourseChapter4KnowledgeEN.ParentNodeName, 100, convcc_CourseChapter4Knowledge.ParentNodeName);
clsCheckSql.CheckFieldLen(objvcc_CourseChapter4KnowledgeEN.ParentNodeReferred, 10, convcc_CourseChapter4Knowledge.ParentNodeReferred);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseChapter4KnowledgeEN.CourseChapterId, convcc_CourseChapter4Knowledge.CourseChapterId);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseChapter4KnowledgeEN.CourseChapterName, convcc_CourseChapter4Knowledge.CourseChapterName);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseChapter4KnowledgeEN.ChapterId, convcc_CourseChapter4Knowledge.ChapterId);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseChapter4KnowledgeEN.SectionId, convcc_CourseChapter4Knowledge.SectionId);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseChapter4KnowledgeEN.ChapterName, convcc_CourseChapter4Knowledge.ChapterName);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseChapter4KnowledgeEN.SectionName, convcc_CourseChapter4Knowledge.SectionName);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseChapter4KnowledgeEN.ChapterNameSim, convcc_CourseChapter4Knowledge.ChapterNameSim);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseChapter4KnowledgeEN.SectionNameSim, convcc_CourseChapter4Knowledge.SectionNameSim);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseChapter4KnowledgeEN.CourseId, convcc_CourseChapter4Knowledge.CourseId);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseChapter4KnowledgeEN.CourseCode, convcc_CourseChapter4Knowledge.CourseCode);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseChapter4KnowledgeEN.CourseName, convcc_CourseChapter4Knowledge.CourseName);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseChapter4KnowledgeEN.ThemeId, convcc_CourseChapter4Knowledge.ThemeId);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseChapter4KnowledgeEN.ParentNodeId, convcc_CourseChapter4Knowledge.ParentNodeId);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseChapter4KnowledgeEN.ThemeName, convcc_CourseChapter4Knowledge.ThemeName);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseChapter4KnowledgeEN.CourseChapterReferred, convcc_CourseChapter4Knowledge.CourseChapterReferred);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseChapter4KnowledgeEN.CreateDate, convcc_CourseChapter4Knowledge.CreateDate);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseChapter4KnowledgeEN.EditPeople, convcc_CourseChapter4Knowledge.EditPeople);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseChapter4KnowledgeEN.UpdDate, convcc_CourseChapter4Knowledge.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseChapter4KnowledgeEN.Memo, convcc_CourseChapter4Knowledge.Memo);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseChapter4KnowledgeEN.ParentNodeName, convcc_CourseChapter4Knowledge.ParentNodeName);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseChapter4KnowledgeEN.ParentNodeReferred, convcc_CourseChapter4Knowledge.ParentNodeReferred);
//检查外键字段长度
 objvcc_CourseChapter4KnowledgeEN._IsCheckProperty = true;
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
 objSQL = clsvcc_CourseChapter4KnowledgeDA.GetSpecSQLObj();
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
 objSQL = clsvcc_CourseChapter4KnowledgeDA.GetSpecSQLObj();
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
 objSQL = clsvcc_CourseChapter4KnowledgeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvcc_CourseChapter4KnowledgeEN._CurrTabName);
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
 objSQL = clsvcc_CourseChapter4KnowledgeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvcc_CourseChapter4KnowledgeEN._CurrTabName, strCondition);
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
 objSQL = clsvcc_CourseChapter4KnowledgeDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}