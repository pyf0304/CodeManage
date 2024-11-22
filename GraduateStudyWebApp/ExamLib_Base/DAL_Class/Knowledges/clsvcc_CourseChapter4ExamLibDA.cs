
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_CourseChapter4ExamLibDA
 表名:vcc_CourseChapter4ExamLib(01120159)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:03:53
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
 /// v课程章节表4题库(vcc_CourseChapter4ExamLib)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvcc_CourseChapter4ExamLibDA : clsCommBase4DA
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
 return clsvcc_CourseChapter4ExamLibEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvcc_CourseChapter4ExamLibEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvcc_CourseChapter4ExamLibEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvcc_CourseChapter4ExamLibEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvcc_CourseChapter4ExamLibEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:vcc_CourseChapter4ExamLib中,检查关键字,长度不正确!(clsvcc_CourseChapter4ExamLibDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strCourseChapterId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vcc_CourseChapter4ExamLib中,关键字不能为空 或 null!(clsvcc_CourseChapter4ExamLibDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCourseChapterId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvcc_CourseChapter4ExamLibDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvcc_CourseChapter4ExamLibDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseChapter4ExamLibDA.GetSpecSQLObj();
strSQL = "Select * from vcc_CourseChapter4ExamLib where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vcc_CourseChapter4ExamLib(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvcc_CourseChapter4ExamLibDA: GetDataTable_vcc_CourseChapter4ExamLib)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseChapter4ExamLibDA.GetSpecSQLObj();
strSQL = "Select * from vcc_CourseChapter4ExamLib where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvcc_CourseChapter4ExamLibDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseChapter4ExamLibDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvcc_CourseChapter4ExamLibDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseChapter4ExamLibDA.GetSpecSQLObj();
strSQL = "Select * from vcc_CourseChapter4ExamLib where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvcc_CourseChapter4ExamLibDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseChapter4ExamLibDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvcc_CourseChapter4ExamLibDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseChapter4ExamLibDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vcc_CourseChapter4ExamLib where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vcc_CourseChapter4ExamLib where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvcc_CourseChapter4ExamLibDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseChapter4ExamLibDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vcc_CourseChapter4ExamLib where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvcc_CourseChapter4ExamLibDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseChapter4ExamLibDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vcc_CourseChapter4ExamLib.* from vcc_CourseChapter4ExamLib Left Join {1} on {2} where {3} and vcc_CourseChapter4ExamLib.CourseChapterId not in (Select top {5} vcc_CourseChapter4ExamLib.CourseChapterId from vcc_CourseChapter4ExamLib Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vcc_CourseChapter4ExamLib where {1} and CourseChapterId not in (Select top {2} CourseChapterId from vcc_CourseChapter4ExamLib where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vcc_CourseChapter4ExamLib where {1} and CourseChapterId not in (Select top {3} CourseChapterId from vcc_CourseChapter4ExamLib where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvcc_CourseChapter4ExamLibDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseChapter4ExamLibDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vcc_CourseChapter4ExamLib.* from vcc_CourseChapter4ExamLib Left Join {1} on {2} where {3} and vcc_CourseChapter4ExamLib.CourseChapterId not in (Select top {5} vcc_CourseChapter4ExamLib.CourseChapterId from vcc_CourseChapter4ExamLib Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vcc_CourseChapter4ExamLib where {1} and CourseChapterId not in (Select top {2} CourseChapterId from vcc_CourseChapter4ExamLib where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vcc_CourseChapter4ExamLib where {1} and CourseChapterId not in (Select top {3} CourseChapterId from vcc_CourseChapter4ExamLib where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvcc_CourseChapter4ExamLibEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvcc_CourseChapter4ExamLibDA:GetObjLst)", objException.Message));
}
List<clsvcc_CourseChapter4ExamLibEN> arrObjLst = new List<clsvcc_CourseChapter4ExamLibEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseChapter4ExamLibDA.GetSpecSQLObj();
strSQL = "Select * from vcc_CourseChapter4ExamLib where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN = new clsvcc_CourseChapter4ExamLibEN();
try
{
objvcc_CourseChapter4ExamLibEN.CourseChapterId = objRow[convcc_CourseChapter4ExamLib.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseChapter4ExamLibEN.CourseChapterName = objRow[convcc_CourseChapter4ExamLib.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_CourseChapter4ExamLibEN.ChapterId = objRow[convcc_CourseChapter4ExamLib.ChapterId] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ChapterId].ToString().Trim(); //章Id
objvcc_CourseChapter4ExamLibEN.SectionId = objRow[convcc_CourseChapter4ExamLib.SectionId] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.SectionId].ToString().Trim(); //节Id
objvcc_CourseChapter4ExamLibEN.ChapterName = objRow[convcc_CourseChapter4ExamLib.ChapterName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ChapterName].ToString().Trim(); //章名
objvcc_CourseChapter4ExamLibEN.SectionName = objRow[convcc_CourseChapter4ExamLib.SectionName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.SectionName].ToString().Trim(); //节名
objvcc_CourseChapter4ExamLibEN.ChapterNameSim = objRow[convcc_CourseChapter4ExamLib.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_CourseChapter4ExamLibEN.SectionNameSim = objRow[convcc_CourseChapter4ExamLib.SectionNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.SectionNameSim].ToString().Trim(); //节名简称
objvcc_CourseChapter4ExamLibEN.ChapterContent = objRow[convcc_CourseChapter4ExamLib.ChapterContent] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ChapterContent].ToString().Trim(); //章节内容
objvcc_CourseChapter4ExamLibEN.CourseId = objRow[convcc_CourseChapter4ExamLib.CourseId].ToString().Trim(); //课程Id
objvcc_CourseChapter4ExamLibEN.CourseCode = objRow[convcc_CourseChapter4ExamLib.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseChapter4ExamLibEN.CourseName = objRow[convcc_CourseChapter4ExamLib.CourseName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.CourseName].ToString().Trim(); //课程名称
objvcc_CourseChapter4ExamLibEN.ThemeId = objRow[convcc_CourseChapter4ExamLib.ThemeId] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseChapter4ExamLibEN.ParentNodeId = objRow[convcc_CourseChapter4ExamLib.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_CourseChapter4ExamLibEN.IsOpenToAllStu = TransNullToBool(objRow[convcc_CourseChapter4ExamLib.IsOpenToAllStu].ToString().Trim()); //全校师生
objvcc_CourseChapter4ExamLibEN.IsOpenToSchool = TransNullToBool(objRow[convcc_CourseChapter4ExamLib.IsOpenToSchool].ToString().Trim()); //全校师生公开
objvcc_CourseChapter4ExamLibEN.IsOpenToSocial = TransNullToBool(objRow[convcc_CourseChapter4ExamLib.IsOpenToSocial].ToString().Trim()); //社会公众
objvcc_CourseChapter4ExamLibEN.IsMustMenu = TransNullToBool(objRow[convcc_CourseChapter4ExamLib.IsMustMenu].ToString().Trim()); //是否必建栏目
objvcc_CourseChapter4ExamLibEN.ThemeName = objRow[convcc_CourseChapter4ExamLib.ThemeName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ThemeName].ToString().Trim(); //主题名
objvcc_CourseChapter4ExamLibEN.IsFile = TransNullToBool(objRow[convcc_CourseChapter4ExamLib.IsFile].ToString().Trim()); //项目或文件夹
objvcc_CourseChapter4ExamLibEN.IsUse = TransNullToBool(objRow[convcc_CourseChapter4ExamLib.IsUse].ToString().Trim()); //是否使用
objvcc_CourseChapter4ExamLibEN.ViewCount = objRow[convcc_CourseChapter4ExamLib.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseChapter4ExamLib.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseChapter4ExamLibEN.CourseChapterReferred = objRow[convcc_CourseChapter4ExamLib.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_CourseChapter4ExamLibEN.OrderNum = objRow[convcc_CourseChapter4ExamLib.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseChapter4ExamLib.OrderNum].ToString().Trim()); //序号
objvcc_CourseChapter4ExamLibEN.CreateDate = objRow[convcc_CourseChapter4ExamLib.CreateDate] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseChapter4ExamLibEN.EditPeople = objRow[convcc_CourseChapter4ExamLib.EditPeople] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.EditPeople].ToString().Trim(); //修改人
objvcc_CourseChapter4ExamLibEN.UpdDate = objRow[convcc_CourseChapter4ExamLib.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseChapter4ExamLibEN.Memo = objRow[convcc_CourseChapter4ExamLib.Memo] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.Memo].ToString().Trim(); //备注
objvcc_CourseChapter4ExamLibEN.ParentNodeName = objRow[convcc_CourseChapter4ExamLib.ParentNodeName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_CourseChapter4ExamLibEN.ParentNodeReferred = objRow[convcc_CourseChapter4ExamLib.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_CourseChapter4ExamLibEN.QuesionnaireNum = objRow[convcc_CourseChapter4ExamLib.QuesionnaireNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseChapter4ExamLib.QuesionnaireNum].ToString().Trim()); //习题数
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvcc_CourseChapter4ExamLibDA: GetObjLst)", objException.Message));
}
objvcc_CourseChapter4ExamLibEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvcc_CourseChapter4ExamLibEN);
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
public List<clsvcc_CourseChapter4ExamLibEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvcc_CourseChapter4ExamLibDA:GetObjLstByTabName)", objException.Message));
}
List<clsvcc_CourseChapter4ExamLibEN> arrObjLst = new List<clsvcc_CourseChapter4ExamLibEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseChapter4ExamLibDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN = new clsvcc_CourseChapter4ExamLibEN();
try
{
objvcc_CourseChapter4ExamLibEN.CourseChapterId = objRow[convcc_CourseChapter4ExamLib.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseChapter4ExamLibEN.CourseChapterName = objRow[convcc_CourseChapter4ExamLib.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_CourseChapter4ExamLibEN.ChapterId = objRow[convcc_CourseChapter4ExamLib.ChapterId] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ChapterId].ToString().Trim(); //章Id
objvcc_CourseChapter4ExamLibEN.SectionId = objRow[convcc_CourseChapter4ExamLib.SectionId] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.SectionId].ToString().Trim(); //节Id
objvcc_CourseChapter4ExamLibEN.ChapterName = objRow[convcc_CourseChapter4ExamLib.ChapterName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ChapterName].ToString().Trim(); //章名
objvcc_CourseChapter4ExamLibEN.SectionName = objRow[convcc_CourseChapter4ExamLib.SectionName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.SectionName].ToString().Trim(); //节名
objvcc_CourseChapter4ExamLibEN.ChapterNameSim = objRow[convcc_CourseChapter4ExamLib.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_CourseChapter4ExamLibEN.SectionNameSim = objRow[convcc_CourseChapter4ExamLib.SectionNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.SectionNameSim].ToString().Trim(); //节名简称
objvcc_CourseChapter4ExamLibEN.ChapterContent = objRow[convcc_CourseChapter4ExamLib.ChapterContent] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ChapterContent].ToString().Trim(); //章节内容
objvcc_CourseChapter4ExamLibEN.CourseId = objRow[convcc_CourseChapter4ExamLib.CourseId].ToString().Trim(); //课程Id
objvcc_CourseChapter4ExamLibEN.CourseCode = objRow[convcc_CourseChapter4ExamLib.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseChapter4ExamLibEN.CourseName = objRow[convcc_CourseChapter4ExamLib.CourseName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.CourseName].ToString().Trim(); //课程名称
objvcc_CourseChapter4ExamLibEN.ThemeId = objRow[convcc_CourseChapter4ExamLib.ThemeId] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseChapter4ExamLibEN.ParentNodeId = objRow[convcc_CourseChapter4ExamLib.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_CourseChapter4ExamLibEN.IsOpenToAllStu = TransNullToBool(objRow[convcc_CourseChapter4ExamLib.IsOpenToAllStu].ToString().Trim()); //全校师生
objvcc_CourseChapter4ExamLibEN.IsOpenToSchool = TransNullToBool(objRow[convcc_CourseChapter4ExamLib.IsOpenToSchool].ToString().Trim()); //全校师生公开
objvcc_CourseChapter4ExamLibEN.IsOpenToSocial = TransNullToBool(objRow[convcc_CourseChapter4ExamLib.IsOpenToSocial].ToString().Trim()); //社会公众
objvcc_CourseChapter4ExamLibEN.IsMustMenu = TransNullToBool(objRow[convcc_CourseChapter4ExamLib.IsMustMenu].ToString().Trim()); //是否必建栏目
objvcc_CourseChapter4ExamLibEN.ThemeName = objRow[convcc_CourseChapter4ExamLib.ThemeName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ThemeName].ToString().Trim(); //主题名
objvcc_CourseChapter4ExamLibEN.IsFile = TransNullToBool(objRow[convcc_CourseChapter4ExamLib.IsFile].ToString().Trim()); //项目或文件夹
objvcc_CourseChapter4ExamLibEN.IsUse = TransNullToBool(objRow[convcc_CourseChapter4ExamLib.IsUse].ToString().Trim()); //是否使用
objvcc_CourseChapter4ExamLibEN.ViewCount = objRow[convcc_CourseChapter4ExamLib.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseChapter4ExamLib.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseChapter4ExamLibEN.CourseChapterReferred = objRow[convcc_CourseChapter4ExamLib.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_CourseChapter4ExamLibEN.OrderNum = objRow[convcc_CourseChapter4ExamLib.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseChapter4ExamLib.OrderNum].ToString().Trim()); //序号
objvcc_CourseChapter4ExamLibEN.CreateDate = objRow[convcc_CourseChapter4ExamLib.CreateDate] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseChapter4ExamLibEN.EditPeople = objRow[convcc_CourseChapter4ExamLib.EditPeople] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.EditPeople].ToString().Trim(); //修改人
objvcc_CourseChapter4ExamLibEN.UpdDate = objRow[convcc_CourseChapter4ExamLib.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseChapter4ExamLibEN.Memo = objRow[convcc_CourseChapter4ExamLib.Memo] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.Memo].ToString().Trim(); //备注
objvcc_CourseChapter4ExamLibEN.ParentNodeName = objRow[convcc_CourseChapter4ExamLib.ParentNodeName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_CourseChapter4ExamLibEN.ParentNodeReferred = objRow[convcc_CourseChapter4ExamLib.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_CourseChapter4ExamLibEN.QuesionnaireNum = objRow[convcc_CourseChapter4ExamLib.QuesionnaireNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseChapter4ExamLib.QuesionnaireNum].ToString().Trim()); //习题数
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvcc_CourseChapter4ExamLibDA: GetObjLst)", objException.Message));
}
objvcc_CourseChapter4ExamLibEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvcc_CourseChapter4ExamLibEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4ExamLibEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getvcc_CourseChapter4ExamLib(ref clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseChapter4ExamLibDA.GetSpecSQLObj();
strSQL = "Select * from vcc_CourseChapter4ExamLib where CourseChapterId = " + "'"+ objvcc_CourseChapter4ExamLibEN.CourseChapterId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvcc_CourseChapter4ExamLibEN.CourseChapterId = objDT.Rows[0][convcc_CourseChapter4ExamLib.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objvcc_CourseChapter4ExamLibEN.CourseChapterName = objDT.Rows[0][convcc_CourseChapter4ExamLib.CourseChapterName].ToString().Trim(); //课程章节名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvcc_CourseChapter4ExamLibEN.ChapterId = objDT.Rows[0][convcc_CourseChapter4ExamLib.ChapterId].ToString().Trim(); //章Id(字段类型:char,字段长度:8,是否可空:True)
 objvcc_CourseChapter4ExamLibEN.SectionId = objDT.Rows[0][convcc_CourseChapter4ExamLib.SectionId].ToString().Trim(); //节Id(字段类型:char,字段长度:8,是否可空:True)
 objvcc_CourseChapter4ExamLibEN.ChapterName = objDT.Rows[0][convcc_CourseChapter4ExamLib.ChapterName].ToString().Trim(); //章名(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_CourseChapter4ExamLibEN.SectionName = objDT.Rows[0][convcc_CourseChapter4ExamLib.SectionName].ToString().Trim(); //节名(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_CourseChapter4ExamLibEN.ChapterNameSim = objDT.Rows[0][convcc_CourseChapter4ExamLib.ChapterNameSim].ToString().Trim(); //章名简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_CourseChapter4ExamLibEN.SectionNameSim = objDT.Rows[0][convcc_CourseChapter4ExamLib.SectionNameSim].ToString().Trim(); //节名简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_CourseChapter4ExamLibEN.ChapterContent = objDT.Rows[0][convcc_CourseChapter4ExamLib.ChapterContent].ToString().Trim(); //章节内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvcc_CourseChapter4ExamLibEN.CourseId = objDT.Rows[0][convcc_CourseChapter4ExamLib.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvcc_CourseChapter4ExamLibEN.CourseCode = objDT.Rows[0][convcc_CourseChapter4ExamLib.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_CourseChapter4ExamLibEN.CourseName = objDT.Rows[0][convcc_CourseChapter4ExamLib.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_CourseChapter4ExamLibEN.ThemeId = objDT.Rows[0][convcc_CourseChapter4ExamLib.ThemeId].ToString().Trim(); //主题Id(字段类型:char,字段长度:4,是否可空:False)
 objvcc_CourseChapter4ExamLibEN.ParentNodeId = objDT.Rows[0][convcc_CourseChapter4ExamLib.ParentNodeId].ToString().Trim(); //父节点编号(字段类型:varchar,字段长度:8,是否可空:True)
 objvcc_CourseChapter4ExamLibEN.IsOpenToAllStu = TransNullToBool(objDT.Rows[0][convcc_CourseChapter4ExamLib.IsOpenToAllStu].ToString().Trim()); //全校师生(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_CourseChapter4ExamLibEN.IsOpenToSchool = TransNullToBool(objDT.Rows[0][convcc_CourseChapter4ExamLib.IsOpenToSchool].ToString().Trim()); //全校师生公开(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_CourseChapter4ExamLibEN.IsOpenToSocial = TransNullToBool(objDT.Rows[0][convcc_CourseChapter4ExamLib.IsOpenToSocial].ToString().Trim()); //社会公众(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_CourseChapter4ExamLibEN.IsMustMenu = TransNullToBool(objDT.Rows[0][convcc_CourseChapter4ExamLib.IsMustMenu].ToString().Trim()); //是否必建栏目(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_CourseChapter4ExamLibEN.ThemeName = objDT.Rows[0][convcc_CourseChapter4ExamLib.ThemeName].ToString().Trim(); //主题名(字段类型:varchar,字段长度:200,是否可空:False)
 objvcc_CourseChapter4ExamLibEN.IsFile = TransNullToBool(objDT.Rows[0][convcc_CourseChapter4ExamLib.IsFile].ToString().Trim()); //项目或文件夹(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_CourseChapter4ExamLibEN.IsUse = TransNullToBool(objDT.Rows[0][convcc_CourseChapter4ExamLib.IsUse].ToString().Trim()); //是否使用(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_CourseChapter4ExamLibEN.ViewCount = TransNullToInt(objDT.Rows[0][convcc_CourseChapter4ExamLib.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvcc_CourseChapter4ExamLibEN.CourseChapterReferred = objDT.Rows[0][convcc_CourseChapter4ExamLib.CourseChapterReferred].ToString().Trim(); //节简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_CourseChapter4ExamLibEN.OrderNum = TransNullToInt(objDT.Rows[0][convcc_CourseChapter4ExamLib.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvcc_CourseChapter4ExamLibEN.CreateDate = objDT.Rows[0][convcc_CourseChapter4ExamLib.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_CourseChapter4ExamLibEN.EditPeople = objDT.Rows[0][convcc_CourseChapter4ExamLib.EditPeople].ToString().Trim(); //修改人(字段类型:varchar,字段长度:50,是否可空:True)
 objvcc_CourseChapter4ExamLibEN.UpdDate = objDT.Rows[0][convcc_CourseChapter4ExamLib.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_CourseChapter4ExamLibEN.Memo = objDT.Rows[0][convcc_CourseChapter4ExamLib.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvcc_CourseChapter4ExamLibEN.ParentNodeName = objDT.Rows[0][convcc_CourseChapter4ExamLib.ParentNodeName].ToString().Trim(); //父节点名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_CourseChapter4ExamLibEN.ParentNodeReferred = objDT.Rows[0][convcc_CourseChapter4ExamLib.ParentNodeReferred].ToString().Trim(); //章简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_CourseChapter4ExamLibEN.QuesionnaireNum = TransNullToInt(objDT.Rows[0][convcc_CourseChapter4ExamLib.QuesionnaireNum].ToString().Trim()); //习题数(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvcc_CourseChapter4ExamLibDA: Getvcc_CourseChapter4ExamLib)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strCourseChapterId">表关键字</param>
 /// <returns>表对象</returns>
public clsvcc_CourseChapter4ExamLibEN GetObjByCourseChapterId(string strCourseChapterId)
{
CheckPrimaryKey(strCourseChapterId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseChapter4ExamLibDA.GetSpecSQLObj();
strSQL = "Select * from vcc_CourseChapter4ExamLib where CourseChapterId = " + "'"+ strCourseChapterId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN = new clsvcc_CourseChapter4ExamLibEN();
try
{
 objvcc_CourseChapter4ExamLibEN.CourseChapterId = objRow[convcc_CourseChapter4ExamLib.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objvcc_CourseChapter4ExamLibEN.CourseChapterName = objRow[convcc_CourseChapter4ExamLib.CourseChapterName].ToString().Trim(); //课程章节名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvcc_CourseChapter4ExamLibEN.ChapterId = objRow[convcc_CourseChapter4ExamLib.ChapterId] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ChapterId].ToString().Trim(); //章Id(字段类型:char,字段长度:8,是否可空:True)
 objvcc_CourseChapter4ExamLibEN.SectionId = objRow[convcc_CourseChapter4ExamLib.SectionId] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.SectionId].ToString().Trim(); //节Id(字段类型:char,字段长度:8,是否可空:True)
 objvcc_CourseChapter4ExamLibEN.ChapterName = objRow[convcc_CourseChapter4ExamLib.ChapterName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ChapterName].ToString().Trim(); //章名(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_CourseChapter4ExamLibEN.SectionName = objRow[convcc_CourseChapter4ExamLib.SectionName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.SectionName].ToString().Trim(); //节名(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_CourseChapter4ExamLibEN.ChapterNameSim = objRow[convcc_CourseChapter4ExamLib.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ChapterNameSim].ToString().Trim(); //章名简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_CourseChapter4ExamLibEN.SectionNameSim = objRow[convcc_CourseChapter4ExamLib.SectionNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.SectionNameSim].ToString().Trim(); //节名简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_CourseChapter4ExamLibEN.ChapterContent = objRow[convcc_CourseChapter4ExamLib.ChapterContent] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ChapterContent].ToString().Trim(); //章节内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvcc_CourseChapter4ExamLibEN.CourseId = objRow[convcc_CourseChapter4ExamLib.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvcc_CourseChapter4ExamLibEN.CourseCode = objRow[convcc_CourseChapter4ExamLib.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_CourseChapter4ExamLibEN.CourseName = objRow[convcc_CourseChapter4ExamLib.CourseName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_CourseChapter4ExamLibEN.ThemeId = objRow[convcc_CourseChapter4ExamLib.ThemeId] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ThemeId].ToString().Trim(); //主题Id(字段类型:char,字段长度:4,是否可空:False)
 objvcc_CourseChapter4ExamLibEN.ParentNodeId = objRow[convcc_CourseChapter4ExamLib.ParentNodeId].ToString().Trim(); //父节点编号(字段类型:varchar,字段长度:8,是否可空:True)
 objvcc_CourseChapter4ExamLibEN.IsOpenToAllStu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4ExamLib.IsOpenToAllStu].ToString().Trim()); //全校师生(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_CourseChapter4ExamLibEN.IsOpenToSchool = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4ExamLib.IsOpenToSchool].ToString().Trim()); //全校师生公开(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_CourseChapter4ExamLibEN.IsOpenToSocial = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4ExamLib.IsOpenToSocial].ToString().Trim()); //社会公众(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_CourseChapter4ExamLibEN.IsMustMenu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4ExamLib.IsMustMenu].ToString().Trim()); //是否必建栏目(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_CourseChapter4ExamLibEN.ThemeName = objRow[convcc_CourseChapter4ExamLib.ThemeName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ThemeName].ToString().Trim(); //主题名(字段类型:varchar,字段长度:200,是否可空:False)
 objvcc_CourseChapter4ExamLibEN.IsFile = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4ExamLib.IsFile].ToString().Trim()); //项目或文件夹(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_CourseChapter4ExamLibEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4ExamLib.IsUse].ToString().Trim()); //是否使用(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_CourseChapter4ExamLibEN.ViewCount = objRow[convcc_CourseChapter4ExamLib.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter4ExamLib.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvcc_CourseChapter4ExamLibEN.CourseChapterReferred = objRow[convcc_CourseChapter4ExamLib.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.CourseChapterReferred].ToString().Trim(); //节简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_CourseChapter4ExamLibEN.OrderNum = objRow[convcc_CourseChapter4ExamLib.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter4ExamLib.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvcc_CourseChapter4ExamLibEN.CreateDate = objRow[convcc_CourseChapter4ExamLib.CreateDate] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_CourseChapter4ExamLibEN.EditPeople = objRow[convcc_CourseChapter4ExamLib.EditPeople] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.EditPeople].ToString().Trim(); //修改人(字段类型:varchar,字段长度:50,是否可空:True)
 objvcc_CourseChapter4ExamLibEN.UpdDate = objRow[convcc_CourseChapter4ExamLib.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_CourseChapter4ExamLibEN.Memo = objRow[convcc_CourseChapter4ExamLib.Memo] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvcc_CourseChapter4ExamLibEN.ParentNodeName = objRow[convcc_CourseChapter4ExamLib.ParentNodeName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ParentNodeName].ToString().Trim(); //父节点名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_CourseChapter4ExamLibEN.ParentNodeReferred = objRow[convcc_CourseChapter4ExamLib.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ParentNodeReferred].ToString().Trim(); //章简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_CourseChapter4ExamLibEN.QuesionnaireNum = objRow[convcc_CourseChapter4ExamLib.QuesionnaireNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter4ExamLib.QuesionnaireNum].ToString().Trim()); //习题数(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvcc_CourseChapter4ExamLibDA: GetObjByCourseChapterId)", objException.Message));
}
return objvcc_CourseChapter4ExamLibEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvcc_CourseChapter4ExamLibEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvcc_CourseChapter4ExamLibDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseChapter4ExamLibDA.GetSpecSQLObj();
strSQL = "Select * from vcc_CourseChapter4ExamLib where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN = new clsvcc_CourseChapter4ExamLibEN()
{
CourseChapterId = objRow[convcc_CourseChapter4ExamLib.CourseChapterId].ToString().Trim(), //课程章节ID
CourseChapterName = objRow[convcc_CourseChapter4ExamLib.CourseChapterName].ToString().Trim(), //课程章节名称
ChapterId = objRow[convcc_CourseChapter4ExamLib.ChapterId] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ChapterId].ToString().Trim(), //章Id
SectionId = objRow[convcc_CourseChapter4ExamLib.SectionId] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.SectionId].ToString().Trim(), //节Id
ChapterName = objRow[convcc_CourseChapter4ExamLib.ChapterName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ChapterName].ToString().Trim(), //章名
SectionName = objRow[convcc_CourseChapter4ExamLib.SectionName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.SectionName].ToString().Trim(), //节名
ChapterNameSim = objRow[convcc_CourseChapter4ExamLib.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ChapterNameSim].ToString().Trim(), //章名简称
SectionNameSim = objRow[convcc_CourseChapter4ExamLib.SectionNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.SectionNameSim].ToString().Trim(), //节名简称
ChapterContent = objRow[convcc_CourseChapter4ExamLib.ChapterContent] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ChapterContent].ToString().Trim(), //章节内容
CourseId = objRow[convcc_CourseChapter4ExamLib.CourseId].ToString().Trim(), //课程Id
CourseCode = objRow[convcc_CourseChapter4ExamLib.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.CourseCode].ToString().Trim(), //课程代码
CourseName = objRow[convcc_CourseChapter4ExamLib.CourseName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.CourseName].ToString().Trim(), //课程名称
ThemeId = objRow[convcc_CourseChapter4ExamLib.ThemeId] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ThemeId].ToString().Trim(), //主题Id
ParentNodeId = objRow[convcc_CourseChapter4ExamLib.ParentNodeId].ToString().Trim(), //父节点编号
IsOpenToAllStu = TransNullToBool(objRow[convcc_CourseChapter4ExamLib.IsOpenToAllStu].ToString().Trim()), //全校师生
IsOpenToSchool = TransNullToBool(objRow[convcc_CourseChapter4ExamLib.IsOpenToSchool].ToString().Trim()), //全校师生公开
IsOpenToSocial = TransNullToBool(objRow[convcc_CourseChapter4ExamLib.IsOpenToSocial].ToString().Trim()), //社会公众
IsMustMenu = TransNullToBool(objRow[convcc_CourseChapter4ExamLib.IsMustMenu].ToString().Trim()), //是否必建栏目
ThemeName = objRow[convcc_CourseChapter4ExamLib.ThemeName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ThemeName].ToString().Trim(), //主题名
IsFile = TransNullToBool(objRow[convcc_CourseChapter4ExamLib.IsFile].ToString().Trim()), //项目或文件夹
IsUse = TransNullToBool(objRow[convcc_CourseChapter4ExamLib.IsUse].ToString().Trim()), //是否使用
ViewCount = objRow[convcc_CourseChapter4ExamLib.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseChapter4ExamLib.ViewCount].ToString().Trim()), //浏览量
CourseChapterReferred = objRow[convcc_CourseChapter4ExamLib.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.CourseChapterReferred].ToString().Trim(), //节简称
OrderNum = objRow[convcc_CourseChapter4ExamLib.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseChapter4ExamLib.OrderNum].ToString().Trim()), //序号
CreateDate = objRow[convcc_CourseChapter4ExamLib.CreateDate] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.CreateDate].ToString().Trim(), //建立日期
EditPeople = objRow[convcc_CourseChapter4ExamLib.EditPeople] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.EditPeople].ToString().Trim(), //修改人
UpdDate = objRow[convcc_CourseChapter4ExamLib.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[convcc_CourseChapter4ExamLib.Memo] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.Memo].ToString().Trim(), //备注
ParentNodeName = objRow[convcc_CourseChapter4ExamLib.ParentNodeName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ParentNodeName].ToString().Trim(), //父节点名称
ParentNodeReferred = objRow[convcc_CourseChapter4ExamLib.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ParentNodeReferred].ToString().Trim(), //章简称
QuesionnaireNum = objRow[convcc_CourseChapter4ExamLib.QuesionnaireNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseChapter4ExamLib.QuesionnaireNum].ToString().Trim()) //习题数
};
objvcc_CourseChapter4ExamLibEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvcc_CourseChapter4ExamLibEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvcc_CourseChapter4ExamLibDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvcc_CourseChapter4ExamLibEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN = new clsvcc_CourseChapter4ExamLibEN();
try
{
objvcc_CourseChapter4ExamLibEN.CourseChapterId = objRow[convcc_CourseChapter4ExamLib.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseChapter4ExamLibEN.CourseChapterName = objRow[convcc_CourseChapter4ExamLib.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_CourseChapter4ExamLibEN.ChapterId = objRow[convcc_CourseChapter4ExamLib.ChapterId] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ChapterId].ToString().Trim(); //章Id
objvcc_CourseChapter4ExamLibEN.SectionId = objRow[convcc_CourseChapter4ExamLib.SectionId] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.SectionId].ToString().Trim(); //节Id
objvcc_CourseChapter4ExamLibEN.ChapterName = objRow[convcc_CourseChapter4ExamLib.ChapterName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ChapterName].ToString().Trim(); //章名
objvcc_CourseChapter4ExamLibEN.SectionName = objRow[convcc_CourseChapter4ExamLib.SectionName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.SectionName].ToString().Trim(); //节名
objvcc_CourseChapter4ExamLibEN.ChapterNameSim = objRow[convcc_CourseChapter4ExamLib.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_CourseChapter4ExamLibEN.SectionNameSim = objRow[convcc_CourseChapter4ExamLib.SectionNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.SectionNameSim].ToString().Trim(); //节名简称
objvcc_CourseChapter4ExamLibEN.ChapterContent = objRow[convcc_CourseChapter4ExamLib.ChapterContent] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ChapterContent].ToString().Trim(); //章节内容
objvcc_CourseChapter4ExamLibEN.CourseId = objRow[convcc_CourseChapter4ExamLib.CourseId].ToString().Trim(); //课程Id
objvcc_CourseChapter4ExamLibEN.CourseCode = objRow[convcc_CourseChapter4ExamLib.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseChapter4ExamLibEN.CourseName = objRow[convcc_CourseChapter4ExamLib.CourseName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.CourseName].ToString().Trim(); //课程名称
objvcc_CourseChapter4ExamLibEN.ThemeId = objRow[convcc_CourseChapter4ExamLib.ThemeId] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseChapter4ExamLibEN.ParentNodeId = objRow[convcc_CourseChapter4ExamLib.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_CourseChapter4ExamLibEN.IsOpenToAllStu = TransNullToBool(objRow[convcc_CourseChapter4ExamLib.IsOpenToAllStu].ToString().Trim()); //全校师生
objvcc_CourseChapter4ExamLibEN.IsOpenToSchool = TransNullToBool(objRow[convcc_CourseChapter4ExamLib.IsOpenToSchool].ToString().Trim()); //全校师生公开
objvcc_CourseChapter4ExamLibEN.IsOpenToSocial = TransNullToBool(objRow[convcc_CourseChapter4ExamLib.IsOpenToSocial].ToString().Trim()); //社会公众
objvcc_CourseChapter4ExamLibEN.IsMustMenu = TransNullToBool(objRow[convcc_CourseChapter4ExamLib.IsMustMenu].ToString().Trim()); //是否必建栏目
objvcc_CourseChapter4ExamLibEN.ThemeName = objRow[convcc_CourseChapter4ExamLib.ThemeName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ThemeName].ToString().Trim(); //主题名
objvcc_CourseChapter4ExamLibEN.IsFile = TransNullToBool(objRow[convcc_CourseChapter4ExamLib.IsFile].ToString().Trim()); //项目或文件夹
objvcc_CourseChapter4ExamLibEN.IsUse = TransNullToBool(objRow[convcc_CourseChapter4ExamLib.IsUse].ToString().Trim()); //是否使用
objvcc_CourseChapter4ExamLibEN.ViewCount = objRow[convcc_CourseChapter4ExamLib.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseChapter4ExamLib.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseChapter4ExamLibEN.CourseChapterReferred = objRow[convcc_CourseChapter4ExamLib.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_CourseChapter4ExamLibEN.OrderNum = objRow[convcc_CourseChapter4ExamLib.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseChapter4ExamLib.OrderNum].ToString().Trim()); //序号
objvcc_CourseChapter4ExamLibEN.CreateDate = objRow[convcc_CourseChapter4ExamLib.CreateDate] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseChapter4ExamLibEN.EditPeople = objRow[convcc_CourseChapter4ExamLib.EditPeople] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.EditPeople].ToString().Trim(); //修改人
objvcc_CourseChapter4ExamLibEN.UpdDate = objRow[convcc_CourseChapter4ExamLib.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseChapter4ExamLibEN.Memo = objRow[convcc_CourseChapter4ExamLib.Memo] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.Memo].ToString().Trim(); //备注
objvcc_CourseChapter4ExamLibEN.ParentNodeName = objRow[convcc_CourseChapter4ExamLib.ParentNodeName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_CourseChapter4ExamLibEN.ParentNodeReferred = objRow[convcc_CourseChapter4ExamLib.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_CourseChapter4ExamLibEN.QuesionnaireNum = objRow[convcc_CourseChapter4ExamLib.QuesionnaireNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseChapter4ExamLib.QuesionnaireNum].ToString().Trim()); //习题数
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvcc_CourseChapter4ExamLibDA: GetObjByDataRowvcc_CourseChapter4ExamLib)", objException.Message));
}
objvcc_CourseChapter4ExamLibEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvcc_CourseChapter4ExamLibEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvcc_CourseChapter4ExamLibEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN = new clsvcc_CourseChapter4ExamLibEN();
try
{
objvcc_CourseChapter4ExamLibEN.CourseChapterId = objRow[convcc_CourseChapter4ExamLib.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseChapter4ExamLibEN.CourseChapterName = objRow[convcc_CourseChapter4ExamLib.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_CourseChapter4ExamLibEN.ChapterId = objRow[convcc_CourseChapter4ExamLib.ChapterId] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ChapterId].ToString().Trim(); //章Id
objvcc_CourseChapter4ExamLibEN.SectionId = objRow[convcc_CourseChapter4ExamLib.SectionId] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.SectionId].ToString().Trim(); //节Id
objvcc_CourseChapter4ExamLibEN.ChapterName = objRow[convcc_CourseChapter4ExamLib.ChapterName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ChapterName].ToString().Trim(); //章名
objvcc_CourseChapter4ExamLibEN.SectionName = objRow[convcc_CourseChapter4ExamLib.SectionName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.SectionName].ToString().Trim(); //节名
objvcc_CourseChapter4ExamLibEN.ChapterNameSim = objRow[convcc_CourseChapter4ExamLib.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_CourseChapter4ExamLibEN.SectionNameSim = objRow[convcc_CourseChapter4ExamLib.SectionNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.SectionNameSim].ToString().Trim(); //节名简称
objvcc_CourseChapter4ExamLibEN.ChapterContent = objRow[convcc_CourseChapter4ExamLib.ChapterContent] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ChapterContent].ToString().Trim(); //章节内容
objvcc_CourseChapter4ExamLibEN.CourseId = objRow[convcc_CourseChapter4ExamLib.CourseId].ToString().Trim(); //课程Id
objvcc_CourseChapter4ExamLibEN.CourseCode = objRow[convcc_CourseChapter4ExamLib.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseChapter4ExamLibEN.CourseName = objRow[convcc_CourseChapter4ExamLib.CourseName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.CourseName].ToString().Trim(); //课程名称
objvcc_CourseChapter4ExamLibEN.ThemeId = objRow[convcc_CourseChapter4ExamLib.ThemeId] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseChapter4ExamLibEN.ParentNodeId = objRow[convcc_CourseChapter4ExamLib.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_CourseChapter4ExamLibEN.IsOpenToAllStu = TransNullToBool(objRow[convcc_CourseChapter4ExamLib.IsOpenToAllStu].ToString().Trim()); //全校师生
objvcc_CourseChapter4ExamLibEN.IsOpenToSchool = TransNullToBool(objRow[convcc_CourseChapter4ExamLib.IsOpenToSchool].ToString().Trim()); //全校师生公开
objvcc_CourseChapter4ExamLibEN.IsOpenToSocial = TransNullToBool(objRow[convcc_CourseChapter4ExamLib.IsOpenToSocial].ToString().Trim()); //社会公众
objvcc_CourseChapter4ExamLibEN.IsMustMenu = TransNullToBool(objRow[convcc_CourseChapter4ExamLib.IsMustMenu].ToString().Trim()); //是否必建栏目
objvcc_CourseChapter4ExamLibEN.ThemeName = objRow[convcc_CourseChapter4ExamLib.ThemeName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ThemeName].ToString().Trim(); //主题名
objvcc_CourseChapter4ExamLibEN.IsFile = TransNullToBool(objRow[convcc_CourseChapter4ExamLib.IsFile].ToString().Trim()); //项目或文件夹
objvcc_CourseChapter4ExamLibEN.IsUse = TransNullToBool(objRow[convcc_CourseChapter4ExamLib.IsUse].ToString().Trim()); //是否使用
objvcc_CourseChapter4ExamLibEN.ViewCount = objRow[convcc_CourseChapter4ExamLib.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseChapter4ExamLib.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseChapter4ExamLibEN.CourseChapterReferred = objRow[convcc_CourseChapter4ExamLib.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_CourseChapter4ExamLibEN.OrderNum = objRow[convcc_CourseChapter4ExamLib.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseChapter4ExamLib.OrderNum].ToString().Trim()); //序号
objvcc_CourseChapter4ExamLibEN.CreateDate = objRow[convcc_CourseChapter4ExamLib.CreateDate] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseChapter4ExamLibEN.EditPeople = objRow[convcc_CourseChapter4ExamLib.EditPeople] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.EditPeople].ToString().Trim(); //修改人
objvcc_CourseChapter4ExamLibEN.UpdDate = objRow[convcc_CourseChapter4ExamLib.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseChapter4ExamLibEN.Memo = objRow[convcc_CourseChapter4ExamLib.Memo] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.Memo].ToString().Trim(); //备注
objvcc_CourseChapter4ExamLibEN.ParentNodeName = objRow[convcc_CourseChapter4ExamLib.ParentNodeName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_CourseChapter4ExamLibEN.ParentNodeReferred = objRow[convcc_CourseChapter4ExamLib.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_CourseChapter4ExamLibEN.QuesionnaireNum = objRow[convcc_CourseChapter4ExamLib.QuesionnaireNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseChapter4ExamLib.QuesionnaireNum].ToString().Trim()); //习题数
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvcc_CourseChapter4ExamLibDA: GetObjByDataRow)", objException.Message));
}
objvcc_CourseChapter4ExamLibEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvcc_CourseChapter4ExamLibEN;
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
objSQL = clsvcc_CourseChapter4ExamLibDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvcc_CourseChapter4ExamLibEN._CurrTabName, convcc_CourseChapter4ExamLib.CourseChapterId, 8, "");
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
objSQL = clsvcc_CourseChapter4ExamLibDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvcc_CourseChapter4ExamLibEN._CurrTabName, convcc_CourseChapter4ExamLib.CourseChapterId, 8, strPrefix);
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
 objSQL = clsvcc_CourseChapter4ExamLibDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select CourseChapterId from vcc_CourseChapter4ExamLib where " + strCondition;
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
 objSQL = clsvcc_CourseChapter4ExamLibDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select CourseChapterId from vcc_CourseChapter4ExamLib where " + strCondition;
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
 objSQL = clsvcc_CourseChapter4ExamLibDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vcc_CourseChapter4ExamLib", "CourseChapterId = " + "'"+ strCourseChapterId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvcc_CourseChapter4ExamLibDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseChapter4ExamLibDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vcc_CourseChapter4ExamLib", strCondition))
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
objSQL = clsvcc_CourseChapter4ExamLibDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vcc_CourseChapter4ExamLib");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4ExamLibENS">源对象</param>
 /// <param name = "objvcc_CourseChapter4ExamLibENT">目标对象</param>
public void CopyTo(clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibENS, clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibENT)
{
objvcc_CourseChapter4ExamLibENT.CourseChapterId = objvcc_CourseChapter4ExamLibENS.CourseChapterId; //课程章节ID
objvcc_CourseChapter4ExamLibENT.CourseChapterName = objvcc_CourseChapter4ExamLibENS.CourseChapterName; //课程章节名称
objvcc_CourseChapter4ExamLibENT.ChapterId = objvcc_CourseChapter4ExamLibENS.ChapterId; //章Id
objvcc_CourseChapter4ExamLibENT.SectionId = objvcc_CourseChapter4ExamLibENS.SectionId; //节Id
objvcc_CourseChapter4ExamLibENT.ChapterName = objvcc_CourseChapter4ExamLibENS.ChapterName; //章名
objvcc_CourseChapter4ExamLibENT.SectionName = objvcc_CourseChapter4ExamLibENS.SectionName; //节名
objvcc_CourseChapter4ExamLibENT.ChapterNameSim = objvcc_CourseChapter4ExamLibENS.ChapterNameSim; //章名简称
objvcc_CourseChapter4ExamLibENT.SectionNameSim = objvcc_CourseChapter4ExamLibENS.SectionNameSim; //节名简称
objvcc_CourseChapter4ExamLibENT.ChapterContent = objvcc_CourseChapter4ExamLibENS.ChapterContent; //章节内容
objvcc_CourseChapter4ExamLibENT.CourseId = objvcc_CourseChapter4ExamLibENS.CourseId; //课程Id
objvcc_CourseChapter4ExamLibENT.CourseCode = objvcc_CourseChapter4ExamLibENS.CourseCode; //课程代码
objvcc_CourseChapter4ExamLibENT.CourseName = objvcc_CourseChapter4ExamLibENS.CourseName; //课程名称
objvcc_CourseChapter4ExamLibENT.ThemeId = objvcc_CourseChapter4ExamLibENS.ThemeId; //主题Id
objvcc_CourseChapter4ExamLibENT.ParentNodeId = objvcc_CourseChapter4ExamLibENS.ParentNodeId; //父节点编号
objvcc_CourseChapter4ExamLibENT.IsOpenToAllStu = objvcc_CourseChapter4ExamLibENS.IsOpenToAllStu; //全校师生
objvcc_CourseChapter4ExamLibENT.IsOpenToSchool = objvcc_CourseChapter4ExamLibENS.IsOpenToSchool; //全校师生公开
objvcc_CourseChapter4ExamLibENT.IsOpenToSocial = objvcc_CourseChapter4ExamLibENS.IsOpenToSocial; //社会公众
objvcc_CourseChapter4ExamLibENT.IsMustMenu = objvcc_CourseChapter4ExamLibENS.IsMustMenu; //是否必建栏目
objvcc_CourseChapter4ExamLibENT.ThemeName = objvcc_CourseChapter4ExamLibENS.ThemeName; //主题名
objvcc_CourseChapter4ExamLibENT.IsFile = objvcc_CourseChapter4ExamLibENS.IsFile; //项目或文件夹
objvcc_CourseChapter4ExamLibENT.IsUse = objvcc_CourseChapter4ExamLibENS.IsUse; //是否使用
objvcc_CourseChapter4ExamLibENT.ViewCount = objvcc_CourseChapter4ExamLibENS.ViewCount; //浏览量
objvcc_CourseChapter4ExamLibENT.CourseChapterReferred = objvcc_CourseChapter4ExamLibENS.CourseChapterReferred; //节简称
objvcc_CourseChapter4ExamLibENT.OrderNum = objvcc_CourseChapter4ExamLibENS.OrderNum; //序号
objvcc_CourseChapter4ExamLibENT.CreateDate = objvcc_CourseChapter4ExamLibENS.CreateDate; //建立日期
objvcc_CourseChapter4ExamLibENT.EditPeople = objvcc_CourseChapter4ExamLibENS.EditPeople; //修改人
objvcc_CourseChapter4ExamLibENT.UpdDate = objvcc_CourseChapter4ExamLibENS.UpdDate; //修改日期
objvcc_CourseChapter4ExamLibENT.Memo = objvcc_CourseChapter4ExamLibENS.Memo; //备注
objvcc_CourseChapter4ExamLibENT.ParentNodeName = objvcc_CourseChapter4ExamLibENS.ParentNodeName; //父节点名称
objvcc_CourseChapter4ExamLibENT.ParentNodeReferred = objvcc_CourseChapter4ExamLibENS.ParentNodeReferred; //章简称
objvcc_CourseChapter4ExamLibENT.QuesionnaireNum = objvcc_CourseChapter4ExamLibENS.QuesionnaireNum; //习题数
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvcc_CourseChapter4ExamLibEN.CourseChapterId, 8, convcc_CourseChapter4ExamLib.CourseChapterId);
clsCheckSql.CheckFieldLen(objvcc_CourseChapter4ExamLibEN.CourseChapterName, 100, convcc_CourseChapter4ExamLib.CourseChapterName);
clsCheckSql.CheckFieldLen(objvcc_CourseChapter4ExamLibEN.ChapterId, 8, convcc_CourseChapter4ExamLib.ChapterId);
clsCheckSql.CheckFieldLen(objvcc_CourseChapter4ExamLibEN.SectionId, 8, convcc_CourseChapter4ExamLib.SectionId);
clsCheckSql.CheckFieldLen(objvcc_CourseChapter4ExamLibEN.ChapterName, 100, convcc_CourseChapter4ExamLib.ChapterName);
clsCheckSql.CheckFieldLen(objvcc_CourseChapter4ExamLibEN.SectionName, 100, convcc_CourseChapter4ExamLib.SectionName);
clsCheckSql.CheckFieldLen(objvcc_CourseChapter4ExamLibEN.ChapterNameSim, 10, convcc_CourseChapter4ExamLib.ChapterNameSim);
clsCheckSql.CheckFieldLen(objvcc_CourseChapter4ExamLibEN.SectionNameSim, 10, convcc_CourseChapter4ExamLib.SectionNameSim);
clsCheckSql.CheckFieldLen(objvcc_CourseChapter4ExamLibEN.CourseId, 8, convcc_CourseChapter4ExamLib.CourseId);
clsCheckSql.CheckFieldLen(objvcc_CourseChapter4ExamLibEN.CourseCode, 20, convcc_CourseChapter4ExamLib.CourseCode);
clsCheckSql.CheckFieldLen(objvcc_CourseChapter4ExamLibEN.CourseName, 100, convcc_CourseChapter4ExamLib.CourseName);
clsCheckSql.CheckFieldLen(objvcc_CourseChapter4ExamLibEN.ThemeId, 4, convcc_CourseChapter4ExamLib.ThemeId);
clsCheckSql.CheckFieldLen(objvcc_CourseChapter4ExamLibEN.ParentNodeId, 8, convcc_CourseChapter4ExamLib.ParentNodeId);
clsCheckSql.CheckFieldLen(objvcc_CourseChapter4ExamLibEN.ThemeName, 200, convcc_CourseChapter4ExamLib.ThemeName);
clsCheckSql.CheckFieldLen(objvcc_CourseChapter4ExamLibEN.CourseChapterReferred, 10, convcc_CourseChapter4ExamLib.CourseChapterReferred);
clsCheckSql.CheckFieldLen(objvcc_CourseChapter4ExamLibEN.CreateDate, 20, convcc_CourseChapter4ExamLib.CreateDate);
clsCheckSql.CheckFieldLen(objvcc_CourseChapter4ExamLibEN.EditPeople, 50, convcc_CourseChapter4ExamLib.EditPeople);
clsCheckSql.CheckFieldLen(objvcc_CourseChapter4ExamLibEN.UpdDate, 20, convcc_CourseChapter4ExamLib.UpdDate);
clsCheckSql.CheckFieldLen(objvcc_CourseChapter4ExamLibEN.Memo, 1000, convcc_CourseChapter4ExamLib.Memo);
clsCheckSql.CheckFieldLen(objvcc_CourseChapter4ExamLibEN.ParentNodeName, 100, convcc_CourseChapter4ExamLib.ParentNodeName);
clsCheckSql.CheckFieldLen(objvcc_CourseChapter4ExamLibEN.ParentNodeReferred, 10, convcc_CourseChapter4ExamLib.ParentNodeReferred);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseChapter4ExamLibEN.CourseChapterId, convcc_CourseChapter4ExamLib.CourseChapterId);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseChapter4ExamLibEN.CourseChapterName, convcc_CourseChapter4ExamLib.CourseChapterName);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseChapter4ExamLibEN.ChapterId, convcc_CourseChapter4ExamLib.ChapterId);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseChapter4ExamLibEN.SectionId, convcc_CourseChapter4ExamLib.SectionId);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseChapter4ExamLibEN.ChapterName, convcc_CourseChapter4ExamLib.ChapterName);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseChapter4ExamLibEN.SectionName, convcc_CourseChapter4ExamLib.SectionName);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseChapter4ExamLibEN.ChapterNameSim, convcc_CourseChapter4ExamLib.ChapterNameSim);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseChapter4ExamLibEN.SectionNameSim, convcc_CourseChapter4ExamLib.SectionNameSim);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseChapter4ExamLibEN.CourseId, convcc_CourseChapter4ExamLib.CourseId);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseChapter4ExamLibEN.CourseCode, convcc_CourseChapter4ExamLib.CourseCode);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseChapter4ExamLibEN.CourseName, convcc_CourseChapter4ExamLib.CourseName);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseChapter4ExamLibEN.ThemeId, convcc_CourseChapter4ExamLib.ThemeId);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseChapter4ExamLibEN.ParentNodeId, convcc_CourseChapter4ExamLib.ParentNodeId);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseChapter4ExamLibEN.ThemeName, convcc_CourseChapter4ExamLib.ThemeName);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseChapter4ExamLibEN.CourseChapterReferred, convcc_CourseChapter4ExamLib.CourseChapterReferred);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseChapter4ExamLibEN.CreateDate, convcc_CourseChapter4ExamLib.CreateDate);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseChapter4ExamLibEN.EditPeople, convcc_CourseChapter4ExamLib.EditPeople);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseChapter4ExamLibEN.UpdDate, convcc_CourseChapter4ExamLib.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseChapter4ExamLibEN.Memo, convcc_CourseChapter4ExamLib.Memo);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseChapter4ExamLibEN.ParentNodeName, convcc_CourseChapter4ExamLib.ParentNodeName);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseChapter4ExamLibEN.ParentNodeReferred, convcc_CourseChapter4ExamLib.ParentNodeReferred);
//检查外键字段长度
 objvcc_CourseChapter4ExamLibEN._IsCheckProperty = true;
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
 objSQL = clsvcc_CourseChapter4ExamLibDA.GetSpecSQLObj();
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
 objSQL = clsvcc_CourseChapter4ExamLibDA.GetSpecSQLObj();
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
 objSQL = clsvcc_CourseChapter4ExamLibDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvcc_CourseChapter4ExamLibEN._CurrTabName);
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
 objSQL = clsvcc_CourseChapter4ExamLibDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvcc_CourseChapter4ExamLibEN._CurrTabName, strCondition);
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
 objSQL = clsvcc_CourseChapter4ExamLibDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}