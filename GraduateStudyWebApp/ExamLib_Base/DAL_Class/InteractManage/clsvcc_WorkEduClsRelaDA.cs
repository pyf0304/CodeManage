
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_WorkEduClsRelaDA
 表名:vcc_WorkEduClsRela(01120197)
 * 版本:2024.11.08.1(服务器:WIN-SRV103-116)
 日期:2024/11/09 22:29:51
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理(InteractManage)
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
 /// v作业教学班关系表(vcc_WorkEduClsRela)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvcc_WorkEduClsRelaDA : clsCommBase4DA
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
 return clsvcc_WorkEduClsRelaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvcc_WorkEduClsRelaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvcc_WorkEduClsRelaEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvcc_WorkEduClsRelaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvcc_WorkEduClsRelaEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvcc_WorkEduClsRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkEduClsRelaDA.GetSpecSQLObj();
strSQL = "Select * from vcc_WorkEduClsRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vcc_WorkEduClsRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvcc_WorkEduClsRelaDA: GetDataTable_vcc_WorkEduClsRela)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkEduClsRelaDA.GetSpecSQLObj();
strSQL = "Select * from vcc_WorkEduClsRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvcc_WorkEduClsRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkEduClsRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvcc_WorkEduClsRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkEduClsRelaDA.GetSpecSQLObj();
strSQL = "Select * from vcc_WorkEduClsRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvcc_WorkEduClsRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkEduClsRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvcc_WorkEduClsRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkEduClsRelaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vcc_WorkEduClsRela where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vcc_WorkEduClsRela where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvcc_WorkEduClsRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkEduClsRelaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vcc_WorkEduClsRela where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvcc_WorkEduClsRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkEduClsRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vcc_WorkEduClsRela.* from vcc_WorkEduClsRela Left Join {1} on {2} where {3} and vcc_WorkEduClsRela.IdWorkEduClsRela not in (Select top {5} vcc_WorkEduClsRela.IdWorkEduClsRela from vcc_WorkEduClsRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vcc_WorkEduClsRela where {1} and IdWorkEduClsRela not in (Select top {2} IdWorkEduClsRela from vcc_WorkEduClsRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vcc_WorkEduClsRela where {1} and IdWorkEduClsRela not in (Select top {3} IdWorkEduClsRela from vcc_WorkEduClsRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvcc_WorkEduClsRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkEduClsRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vcc_WorkEduClsRela.* from vcc_WorkEduClsRela Left Join {1} on {2} where {3} and vcc_WorkEduClsRela.IdWorkEduClsRela not in (Select top {5} vcc_WorkEduClsRela.IdWorkEduClsRela from vcc_WorkEduClsRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vcc_WorkEduClsRela where {1} and IdWorkEduClsRela not in (Select top {2} IdWorkEduClsRela from vcc_WorkEduClsRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vcc_WorkEduClsRela where {1} and IdWorkEduClsRela not in (Select top {3} IdWorkEduClsRela from vcc_WorkEduClsRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvcc_WorkEduClsRelaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvcc_WorkEduClsRelaDA:GetObjLst)", objException.Message));
}
List<clsvcc_WorkEduClsRelaEN> arrObjLst = new List<clsvcc_WorkEduClsRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkEduClsRelaDA.GetSpecSQLObj();
strSQL = "Select * from vcc_WorkEduClsRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN = new clsvcc_WorkEduClsRelaEN();
try
{
objvcc_WorkEduClsRelaEN.IdWorkEduClsRela = TransNullToInt(objRow[convcc_WorkEduClsRela.IdWorkEduClsRela].ToString().Trim()); //作业教学班关系流水号
objvcc_WorkEduClsRelaEN.QuestionId = objRow[convcc_WorkEduClsRela.QuestionId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convcc_WorkEduClsRela.QuestionId].ToString().Trim()); //题目Id
objvcc_WorkEduClsRelaEN.QuestionIndex = objRow[convcc_WorkEduClsRela.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_WorkEduClsRela.QuestionIndex].ToString().Trim()); //题目序号
objvcc_WorkEduClsRelaEN.QuestionName = objRow[convcc_WorkEduClsRela.QuestionName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionName].ToString().Trim(); //题目名称
objvcc_WorkEduClsRelaEN.QuestionContent = objRow[convcc_WorkEduClsRela.QuestionContent] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionContent].ToString().Trim(); //题目内容
objvcc_WorkEduClsRelaEN.CourseId = objRow[convcc_WorkEduClsRela.CourseId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseId].ToString().Trim(); //课程Id
objvcc_WorkEduClsRelaEN.CourseName = objRow[convcc_WorkEduClsRela.CourseName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseName].ToString().Trim(); //课程名称
objvcc_WorkEduClsRelaEN.CourseChapterId = objRow[convcc_WorkEduClsRela.CourseChapterId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkEduClsRelaEN.CourseChapterName = objRow[convcc_WorkEduClsRela.CourseChapterName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkEduClsRelaEN.ChapterName = objRow[convcc_WorkEduClsRela.ChapterName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ChapterName].ToString().Trim(); //章名
objvcc_WorkEduClsRelaEN.SectionName = objRow[convcc_WorkEduClsRela.SectionName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.SectionName].ToString().Trim(); //节名
objvcc_WorkEduClsRelaEN.ChapterNameSim = objRow[convcc_WorkEduClsRela.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkEduClsRelaEN.SectionNameSim = objRow[convcc_WorkEduClsRela.SectionNameSim] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkEduClsRelaEN.ParentNodeId = objRow[convcc_WorkEduClsRela.ParentNodeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_WorkEduClsRelaEN.CourseChapterReferred = objRow[convcc_WorkEduClsRela.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkEduClsRelaEN.ParentNodeName = objRow[convcc_WorkEduClsRela.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkEduClsRelaEN.ParentNodeReferred = objRow[convcc_WorkEduClsRela.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkEduClsRelaEN.QuestionTypeId = objRow[convcc_WorkEduClsRela.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_WorkEduClsRelaEN.QuestionTypeName = objRow[convcc_WorkEduClsRela.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionTypeName].ToString().Trim(); //题目类型名
objvcc_WorkEduClsRelaEN.ExamGradeId = objRow[convcc_WorkEduClsRela.ExamGradeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ExamGradeId].ToString().Trim(); //题库等级ID
objvcc_WorkEduClsRelaEN.ExamGradeName = objRow[convcc_WorkEduClsRela.ExamGradeName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ExamGradeName].ToString().Trim(); //题库等级名
objvcc_WorkEduClsRelaEN.AnswerTypeId = objRow[convcc_WorkEduClsRela.AnswerTypeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.AnswerTypeId].ToString().Trim(); //答案类型ID
objvcc_WorkEduClsRelaEN.AnswerModeId = objRow[convcc_WorkEduClsRela.AnswerModeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.AnswerModeId].ToString().Trim(); //答案模式Id
objvcc_WorkEduClsRelaEN.DefaultValue = objRow[convcc_WorkEduClsRela.DefaultValue] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.DefaultValue].ToString().Trim(); //缺省值
objvcc_WorkEduClsRelaEN.TextDirectId = objRow[convcc_WorkEduClsRela.TextDirectId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.TextDirectId].ToString().Trim(); //文本方向ID
objvcc_WorkEduClsRelaEN.RelaEvent = objRow[convcc_WorkEduClsRela.RelaEvent] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.RelaEvent].ToString().Trim(); //相关事件
objvcc_WorkEduClsRelaEN.CheckBoxLimitCount = objRow[convcc_WorkEduClsRela.CheckBoxLimitCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_WorkEduClsRela.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objvcc_WorkEduClsRelaEN.AnswerAttLimitSize = objRow[convcc_WorkEduClsRela.AnswerAttLimitSize] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convcc_WorkEduClsRela.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objvcc_WorkEduClsRelaEN.LimitedResourceType = objRow[convcc_WorkEduClsRela.LimitedResourceType] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.LimitedResourceType].ToString().Trim(); //限制资源类型
objvcc_WorkEduClsRelaEN.QuestionTypeId4Course = objRow[convcc_WorkEduClsRela.QuestionTypeId4Course] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvcc_WorkEduClsRelaEN.QuestionTypeName4Course = objRow[convcc_WorkEduClsRela.QuestionTypeName4Course] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程
objvcc_WorkEduClsRelaEN.IdCurrEduCls = objRow[convcc_WorkEduClsRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvcc_WorkEduClsRelaEN.CurrEduClsId = objRow[convcc_WorkEduClsRela.CurrEduClsId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CurrEduClsId].ToString().Trim(); //教学班Id
objvcc_WorkEduClsRelaEN.EduClsName = objRow[convcc_WorkEduClsRela.EduClsName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.EduClsName].ToString().Trim(); //教学班名
objvcc_WorkEduClsRelaEN.Scores = objRow[convcc_WorkEduClsRela.Scores] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convcc_WorkEduClsRela.Scores].ToString().Trim()); //分值
objvcc_WorkEduClsRelaEN.TeacherId = objRow[convcc_WorkEduClsRela.TeacherId].ToString().Trim(); //教师工号
objvcc_WorkEduClsRelaEN.IsPublish = TransNullToBool(objRow[convcc_WorkEduClsRela.IsPublish].ToString().Trim()); //是否发布
objvcc_WorkEduClsRelaEN.PubDate = objRow[convcc_WorkEduClsRela.PubDate].ToString().Trim(); //发布日期
objvcc_WorkEduClsRelaEN.publisher = objRow[convcc_WorkEduClsRela.publisher] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.publisher].ToString().Trim(); //发布者Id
objvcc_WorkEduClsRelaEN.SpecifyCompletionDate = objRow[convcc_WorkEduClsRela.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objvcc_WorkEduClsRelaEN.IsCurrEduCls = TransNullToBool(objRow[convcc_WorkEduClsRela.IsCurrEduCls].ToString().Trim()); //是否为教学班作业
objvcc_WorkEduClsRelaEN.IsGroupWork = TransNullToBool(objRow[convcc_WorkEduClsRela.IsGroupWork].ToString().Trim()); //是否为小组作业
objvcc_WorkEduClsRelaEN.CourseStudentGroupId = objRow[convcc_WorkEduClsRela.CourseStudentGroupId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convcc_WorkEduClsRela.CourseStudentGroupId].ToString().Trim()); //学生分组表流水号
objvcc_WorkEduClsRelaEN.WorkTypeId = objRow[convcc_WorkEduClsRela.WorkTypeId].ToString().Trim(); //作业类型Id
objvcc_WorkEduClsRelaEN.WorkTypeName = objRow[convcc_WorkEduClsRela.WorkTypeName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.WorkTypeName].ToString().Trim(); //作业类型名称
objvcc_WorkEduClsRelaEN.UpdDate = objRow[convcc_WorkEduClsRela.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkEduClsRelaEN.UpdUserId = objRow[convcc_WorkEduClsRela.UpdUserId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_WorkEduClsRelaEN.Memo = objRow[convcc_WorkEduClsRela.Memo] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.Memo].ToString().Trim(); //备注
objvcc_WorkEduClsRelaEN.StuNum = objRow[convcc_WorkEduClsRela.StuNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_WorkEduClsRela.StuNum].ToString().Trim()); //学生数
objvcc_WorkEduClsRelaEN.EduClsStuNum = objRow[convcc_WorkEduClsRela.EduClsStuNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_WorkEduClsRela.EduClsStuNum].ToString().Trim()); //教学班学生数
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvcc_WorkEduClsRelaDA: GetObjLst)", objException.Message));
}
objvcc_WorkEduClsRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvcc_WorkEduClsRelaEN);
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
public List<clsvcc_WorkEduClsRelaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvcc_WorkEduClsRelaDA:GetObjLstByTabName)", objException.Message));
}
List<clsvcc_WorkEduClsRelaEN> arrObjLst = new List<clsvcc_WorkEduClsRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkEduClsRelaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN = new clsvcc_WorkEduClsRelaEN();
try
{
objvcc_WorkEduClsRelaEN.IdWorkEduClsRela = TransNullToInt(objRow[convcc_WorkEduClsRela.IdWorkEduClsRela].ToString().Trim()); //作业教学班关系流水号
objvcc_WorkEduClsRelaEN.QuestionId = objRow[convcc_WorkEduClsRela.QuestionId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convcc_WorkEduClsRela.QuestionId].ToString().Trim()); //题目Id
objvcc_WorkEduClsRelaEN.QuestionIndex = objRow[convcc_WorkEduClsRela.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_WorkEduClsRela.QuestionIndex].ToString().Trim()); //题目序号
objvcc_WorkEduClsRelaEN.QuestionName = objRow[convcc_WorkEduClsRela.QuestionName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionName].ToString().Trim(); //题目名称
objvcc_WorkEduClsRelaEN.QuestionContent = objRow[convcc_WorkEduClsRela.QuestionContent] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionContent].ToString().Trim(); //题目内容
objvcc_WorkEduClsRelaEN.CourseId = objRow[convcc_WorkEduClsRela.CourseId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseId].ToString().Trim(); //课程Id
objvcc_WorkEduClsRelaEN.CourseName = objRow[convcc_WorkEduClsRela.CourseName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseName].ToString().Trim(); //课程名称
objvcc_WorkEduClsRelaEN.CourseChapterId = objRow[convcc_WorkEduClsRela.CourseChapterId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkEduClsRelaEN.CourseChapterName = objRow[convcc_WorkEduClsRela.CourseChapterName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkEduClsRelaEN.ChapterName = objRow[convcc_WorkEduClsRela.ChapterName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ChapterName].ToString().Trim(); //章名
objvcc_WorkEduClsRelaEN.SectionName = objRow[convcc_WorkEduClsRela.SectionName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.SectionName].ToString().Trim(); //节名
objvcc_WorkEduClsRelaEN.ChapterNameSim = objRow[convcc_WorkEduClsRela.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkEduClsRelaEN.SectionNameSim = objRow[convcc_WorkEduClsRela.SectionNameSim] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkEduClsRelaEN.ParentNodeId = objRow[convcc_WorkEduClsRela.ParentNodeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_WorkEduClsRelaEN.CourseChapterReferred = objRow[convcc_WorkEduClsRela.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkEduClsRelaEN.ParentNodeName = objRow[convcc_WorkEduClsRela.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkEduClsRelaEN.ParentNodeReferred = objRow[convcc_WorkEduClsRela.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkEduClsRelaEN.QuestionTypeId = objRow[convcc_WorkEduClsRela.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_WorkEduClsRelaEN.QuestionTypeName = objRow[convcc_WorkEduClsRela.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionTypeName].ToString().Trim(); //题目类型名
objvcc_WorkEduClsRelaEN.ExamGradeId = objRow[convcc_WorkEduClsRela.ExamGradeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ExamGradeId].ToString().Trim(); //题库等级ID
objvcc_WorkEduClsRelaEN.ExamGradeName = objRow[convcc_WorkEduClsRela.ExamGradeName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ExamGradeName].ToString().Trim(); //题库等级名
objvcc_WorkEduClsRelaEN.AnswerTypeId = objRow[convcc_WorkEduClsRela.AnswerTypeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.AnswerTypeId].ToString().Trim(); //答案类型ID
objvcc_WorkEduClsRelaEN.AnswerModeId = objRow[convcc_WorkEduClsRela.AnswerModeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.AnswerModeId].ToString().Trim(); //答案模式Id
objvcc_WorkEduClsRelaEN.DefaultValue = objRow[convcc_WorkEduClsRela.DefaultValue] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.DefaultValue].ToString().Trim(); //缺省值
objvcc_WorkEduClsRelaEN.TextDirectId = objRow[convcc_WorkEduClsRela.TextDirectId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.TextDirectId].ToString().Trim(); //文本方向ID
objvcc_WorkEduClsRelaEN.RelaEvent = objRow[convcc_WorkEduClsRela.RelaEvent] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.RelaEvent].ToString().Trim(); //相关事件
objvcc_WorkEduClsRelaEN.CheckBoxLimitCount = objRow[convcc_WorkEduClsRela.CheckBoxLimitCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_WorkEduClsRela.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objvcc_WorkEduClsRelaEN.AnswerAttLimitSize = objRow[convcc_WorkEduClsRela.AnswerAttLimitSize] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convcc_WorkEduClsRela.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objvcc_WorkEduClsRelaEN.LimitedResourceType = objRow[convcc_WorkEduClsRela.LimitedResourceType] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.LimitedResourceType].ToString().Trim(); //限制资源类型
objvcc_WorkEduClsRelaEN.QuestionTypeId4Course = objRow[convcc_WorkEduClsRela.QuestionTypeId4Course] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvcc_WorkEduClsRelaEN.QuestionTypeName4Course = objRow[convcc_WorkEduClsRela.QuestionTypeName4Course] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程
objvcc_WorkEduClsRelaEN.IdCurrEduCls = objRow[convcc_WorkEduClsRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvcc_WorkEduClsRelaEN.CurrEduClsId = objRow[convcc_WorkEduClsRela.CurrEduClsId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CurrEduClsId].ToString().Trim(); //教学班Id
objvcc_WorkEduClsRelaEN.EduClsName = objRow[convcc_WorkEduClsRela.EduClsName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.EduClsName].ToString().Trim(); //教学班名
objvcc_WorkEduClsRelaEN.Scores = objRow[convcc_WorkEduClsRela.Scores] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convcc_WorkEduClsRela.Scores].ToString().Trim()); //分值
objvcc_WorkEduClsRelaEN.TeacherId = objRow[convcc_WorkEduClsRela.TeacherId].ToString().Trim(); //教师工号
objvcc_WorkEduClsRelaEN.IsPublish = TransNullToBool(objRow[convcc_WorkEduClsRela.IsPublish].ToString().Trim()); //是否发布
objvcc_WorkEduClsRelaEN.PubDate = objRow[convcc_WorkEduClsRela.PubDate].ToString().Trim(); //发布日期
objvcc_WorkEduClsRelaEN.publisher = objRow[convcc_WorkEduClsRela.publisher] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.publisher].ToString().Trim(); //发布者Id
objvcc_WorkEduClsRelaEN.SpecifyCompletionDate = objRow[convcc_WorkEduClsRela.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objvcc_WorkEduClsRelaEN.IsCurrEduCls = TransNullToBool(objRow[convcc_WorkEduClsRela.IsCurrEduCls].ToString().Trim()); //是否为教学班作业
objvcc_WorkEduClsRelaEN.IsGroupWork = TransNullToBool(objRow[convcc_WorkEduClsRela.IsGroupWork].ToString().Trim()); //是否为小组作业
objvcc_WorkEduClsRelaEN.CourseStudentGroupId = objRow[convcc_WorkEduClsRela.CourseStudentGroupId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convcc_WorkEduClsRela.CourseStudentGroupId].ToString().Trim()); //学生分组表流水号
objvcc_WorkEduClsRelaEN.WorkTypeId = objRow[convcc_WorkEduClsRela.WorkTypeId].ToString().Trim(); //作业类型Id
objvcc_WorkEduClsRelaEN.WorkTypeName = objRow[convcc_WorkEduClsRela.WorkTypeName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.WorkTypeName].ToString().Trim(); //作业类型名称
objvcc_WorkEduClsRelaEN.UpdDate = objRow[convcc_WorkEduClsRela.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkEduClsRelaEN.UpdUserId = objRow[convcc_WorkEduClsRela.UpdUserId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_WorkEduClsRelaEN.Memo = objRow[convcc_WorkEduClsRela.Memo] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.Memo].ToString().Trim(); //备注
objvcc_WorkEduClsRelaEN.StuNum = objRow[convcc_WorkEduClsRela.StuNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_WorkEduClsRela.StuNum].ToString().Trim()); //学生数
objvcc_WorkEduClsRelaEN.EduClsStuNum = objRow[convcc_WorkEduClsRela.EduClsStuNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_WorkEduClsRela.EduClsStuNum].ToString().Trim()); //教学班学生数
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvcc_WorkEduClsRelaDA: GetObjLst)", objException.Message));
}
objvcc_WorkEduClsRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvcc_WorkEduClsRelaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getvcc_WorkEduClsRela(ref clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkEduClsRelaDA.GetSpecSQLObj();
strSQL = "Select * from vcc_WorkEduClsRela where IdWorkEduClsRela = " + ""+ objvcc_WorkEduClsRelaEN.IdWorkEduClsRela+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvcc_WorkEduClsRelaEN.IdWorkEduClsRela = TransNullToInt(objDT.Rows[0][convcc_WorkEduClsRela.IdWorkEduClsRela].ToString().Trim()); //作业教学班关系流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvcc_WorkEduClsRelaEN.QuestionId = TransNullToInt(objDT.Rows[0][convcc_WorkEduClsRela.QuestionId].ToString().Trim()); //题目Id(字段类型:bigint,字段长度:8,是否可空:True)
 objvcc_WorkEduClsRelaEN.QuestionIndex = TransNullToInt(objDT.Rows[0][convcc_WorkEduClsRela.QuestionIndex].ToString().Trim()); //题目序号(字段类型:int,字段长度:4,是否可空:True)
 objvcc_WorkEduClsRelaEN.QuestionName = objDT.Rows[0][convcc_WorkEduClsRela.QuestionName].ToString().Trim(); //题目名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvcc_WorkEduClsRelaEN.QuestionContent = objDT.Rows[0][convcc_WorkEduClsRela.QuestionContent].ToString().Trim(); //题目内容(字段类型:varchar,字段长度:4000,是否可空:True)
 objvcc_WorkEduClsRelaEN.CourseId = objDT.Rows[0][convcc_WorkEduClsRela.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvcc_WorkEduClsRelaEN.CourseName = objDT.Rows[0][convcc_WorkEduClsRela.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_WorkEduClsRelaEN.CourseChapterId = objDT.Rows[0][convcc_WorkEduClsRela.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objvcc_WorkEduClsRelaEN.CourseChapterName = objDT.Rows[0][convcc_WorkEduClsRela.CourseChapterName].ToString().Trim(); //课程章节名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvcc_WorkEduClsRelaEN.ChapterName = objDT.Rows[0][convcc_WorkEduClsRela.ChapterName].ToString().Trim(); //章名(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_WorkEduClsRelaEN.SectionName = objDT.Rows[0][convcc_WorkEduClsRela.SectionName].ToString().Trim(); //节名(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_WorkEduClsRelaEN.ChapterNameSim = objDT.Rows[0][convcc_WorkEduClsRela.ChapterNameSim].ToString().Trim(); //章名简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_WorkEduClsRelaEN.SectionNameSim = objDT.Rows[0][convcc_WorkEduClsRela.SectionNameSim].ToString().Trim(); //节名简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_WorkEduClsRelaEN.ParentNodeId = objDT.Rows[0][convcc_WorkEduClsRela.ParentNodeId].ToString().Trim(); //父节点编号(字段类型:varchar,字段长度:8,是否可空:True)
 objvcc_WorkEduClsRelaEN.CourseChapterReferred = objDT.Rows[0][convcc_WorkEduClsRela.CourseChapterReferred].ToString().Trim(); //节简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_WorkEduClsRelaEN.ParentNodeName = objDT.Rows[0][convcc_WorkEduClsRela.ParentNodeName].ToString().Trim(); //父节点名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_WorkEduClsRelaEN.ParentNodeReferred = objDT.Rows[0][convcc_WorkEduClsRela.ParentNodeReferred].ToString().Trim(); //章简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_WorkEduClsRelaEN.QuestionTypeId = objDT.Rows[0][convcc_WorkEduClsRela.QuestionTypeId].ToString().Trim(); //题目类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvcc_WorkEduClsRelaEN.QuestionTypeName = objDT.Rows[0][convcc_WorkEduClsRela.QuestionTypeName].ToString().Trim(); //题目类型名(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_WorkEduClsRelaEN.ExamGradeId = objDT.Rows[0][convcc_WorkEduClsRela.ExamGradeId].ToString().Trim(); //题库等级ID(字段类型:char,字段长度:2,是否可空:True)
 objvcc_WorkEduClsRelaEN.ExamGradeName = objDT.Rows[0][convcc_WorkEduClsRela.ExamGradeName].ToString().Trim(); //题库等级名(字段类型:varchar,字段长度:50,是否可空:True)
 objvcc_WorkEduClsRelaEN.AnswerTypeId = objDT.Rows[0][convcc_WorkEduClsRela.AnswerTypeId].ToString().Trim(); //答案类型ID(字段类型:char,字段长度:2,是否可空:True)
 objvcc_WorkEduClsRelaEN.AnswerModeId = objDT.Rows[0][convcc_WorkEduClsRela.AnswerModeId].ToString().Trim(); //答案模式Id(字段类型:char,字段长度:4,是否可空:True)
 objvcc_WorkEduClsRelaEN.DefaultValue = objDT.Rows[0][convcc_WorkEduClsRela.DefaultValue].ToString().Trim(); //缺省值(字段类型:varchar,字段长度:50,是否可空:True)
 objvcc_WorkEduClsRelaEN.TextDirectId = objDT.Rows[0][convcc_WorkEduClsRela.TextDirectId].ToString().Trim(); //文本方向ID(字段类型:char,字段长度:4,是否可空:True)
 objvcc_WorkEduClsRelaEN.RelaEvent = objDT.Rows[0][convcc_WorkEduClsRela.RelaEvent].ToString().Trim(); //相关事件(字段类型:varchar,字段长度:4000,是否可空:True)
 objvcc_WorkEduClsRelaEN.CheckBoxLimitCount = TransNullToInt(objDT.Rows[0][convcc_WorkEduClsRela.CheckBoxLimitCount].ToString().Trim()); //复选框限制数(字段类型:int,字段长度:4,是否可空:True)
 objvcc_WorkEduClsRelaEN.AnswerAttLimitSize = TransNullToInt(objDT.Rows[0][convcc_WorkEduClsRela.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小(字段类型:bigint,字段长度:8,是否可空:True)
 objvcc_WorkEduClsRelaEN.LimitedResourceType = objDT.Rows[0][convcc_WorkEduClsRela.LimitedResourceType].ToString().Trim(); //限制资源类型(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_WorkEduClsRelaEN.QuestionTypeId4Course = objDT.Rows[0][convcc_WorkEduClsRela.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程(字段类型:char,字段长度:8,是否可空:False)
 objvcc_WorkEduClsRelaEN.QuestionTypeName4Course = objDT.Rows[0][convcc_WorkEduClsRela.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程(字段类型:varchar,字段长度:30,是否可空:False)
 objvcc_WorkEduClsRelaEN.IdCurrEduCls = objDT.Rows[0][convcc_WorkEduClsRela.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvcc_WorkEduClsRelaEN.CurrEduClsId = objDT.Rows[0][convcc_WorkEduClsRela.CurrEduClsId].ToString().Trim(); //教学班Id(字段类型:varchar,字段长度:15,是否可空:True)
 objvcc_WorkEduClsRelaEN.EduClsName = objDT.Rows[0][convcc_WorkEduClsRela.EduClsName].ToString().Trim(); //教学班名(字段类型:varchar,字段长度:100,是否可空:False)
 objvcc_WorkEduClsRelaEN.Scores = TransNullToDouble(objDT.Rows[0][convcc_WorkEduClsRela.Scores].ToString().Trim()); //分值(字段类型:decimal,字段长度:8,是否可空:True)
 objvcc_WorkEduClsRelaEN.TeacherId = objDT.Rows[0][convcc_WorkEduClsRela.TeacherId].ToString().Trim(); //教师工号(字段类型:varchar,字段长度:12,是否可空:False)
 objvcc_WorkEduClsRelaEN.IsPublish = TransNullToBool(objDT.Rows[0][convcc_WorkEduClsRela.IsPublish].ToString().Trim()); //是否发布(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_WorkEduClsRelaEN.PubDate = objDT.Rows[0][convcc_WorkEduClsRela.PubDate].ToString().Trim(); //发布日期(字段类型:varchar,字段长度:14,是否可空:False)
 objvcc_WorkEduClsRelaEN.publisher = objDT.Rows[0][convcc_WorkEduClsRela.publisher].ToString().Trim(); //发布者Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_WorkEduClsRelaEN.SpecifyCompletionDate = objDT.Rows[0][convcc_WorkEduClsRela.SpecifyCompletionDate].ToString().Trim(); //指定完成日期(字段类型:varchar,字段长度:14,是否可空:False)
 objvcc_WorkEduClsRelaEN.IsCurrEduCls = TransNullToBool(objDT.Rows[0][convcc_WorkEduClsRela.IsCurrEduCls].ToString().Trim()); //是否为教学班作业(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_WorkEduClsRelaEN.IsGroupWork = TransNullToBool(objDT.Rows[0][convcc_WorkEduClsRela.IsGroupWork].ToString().Trim()); //是否为小组作业(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_WorkEduClsRelaEN.CourseStudentGroupId = TransNullToInt(objDT.Rows[0][convcc_WorkEduClsRela.CourseStudentGroupId].ToString().Trim()); //学生分组表流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvcc_WorkEduClsRelaEN.WorkTypeId = objDT.Rows[0][convcc_WorkEduClsRela.WorkTypeId].ToString().Trim(); //作业类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvcc_WorkEduClsRelaEN.WorkTypeName = objDT.Rows[0][convcc_WorkEduClsRela.WorkTypeName].ToString().Trim(); //作业类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvcc_WorkEduClsRelaEN.UpdDate = objDT.Rows[0][convcc_WorkEduClsRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_WorkEduClsRelaEN.UpdUserId = objDT.Rows[0][convcc_WorkEduClsRela.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_WorkEduClsRelaEN.Memo = objDT.Rows[0][convcc_WorkEduClsRela.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvcc_WorkEduClsRelaEN.StuNum = TransNullToInt(objDT.Rows[0][convcc_WorkEduClsRela.StuNum].ToString().Trim()); //学生数(字段类型:int,字段长度:4,是否可空:True)
 objvcc_WorkEduClsRelaEN.EduClsStuNum = TransNullToInt(objDT.Rows[0][convcc_WorkEduClsRela.EduClsStuNum].ToString().Trim()); //教学班学生数(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvcc_WorkEduClsRelaDA: Getvcc_WorkEduClsRela)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdWorkEduClsRela">表关键字</param>
 /// <returns>表对象</returns>
public clsvcc_WorkEduClsRelaEN GetObjByIdWorkEduClsRela(long lngIdWorkEduClsRela)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkEduClsRelaDA.GetSpecSQLObj();
strSQL = "Select * from vcc_WorkEduClsRela where IdWorkEduClsRela = " + ""+ lngIdWorkEduClsRela+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN = new clsvcc_WorkEduClsRelaEN();
try
{
 objvcc_WorkEduClsRelaEN.IdWorkEduClsRela = Int32.Parse(objRow[convcc_WorkEduClsRela.IdWorkEduClsRela].ToString().Trim()); //作业教学班关系流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvcc_WorkEduClsRelaEN.QuestionId = objRow[convcc_WorkEduClsRela.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.QuestionId].ToString().Trim()); //题目Id(字段类型:bigint,字段长度:8,是否可空:True)
 objvcc_WorkEduClsRelaEN.QuestionIndex = objRow[convcc_WorkEduClsRela.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.QuestionIndex].ToString().Trim()); //题目序号(字段类型:int,字段长度:4,是否可空:True)
 objvcc_WorkEduClsRelaEN.QuestionName = objRow[convcc_WorkEduClsRela.QuestionName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionName].ToString().Trim(); //题目名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvcc_WorkEduClsRelaEN.QuestionContent = objRow[convcc_WorkEduClsRela.QuestionContent] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionContent].ToString().Trim(); //题目内容(字段类型:varchar,字段长度:4000,是否可空:True)
 objvcc_WorkEduClsRelaEN.CourseId = objRow[convcc_WorkEduClsRela.CourseId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvcc_WorkEduClsRelaEN.CourseName = objRow[convcc_WorkEduClsRela.CourseName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_WorkEduClsRelaEN.CourseChapterId = objRow[convcc_WorkEduClsRela.CourseChapterId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objvcc_WorkEduClsRelaEN.CourseChapterName = objRow[convcc_WorkEduClsRela.CourseChapterName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseChapterName].ToString().Trim(); //课程章节名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvcc_WorkEduClsRelaEN.ChapterName = objRow[convcc_WorkEduClsRela.ChapterName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ChapterName].ToString().Trim(); //章名(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_WorkEduClsRelaEN.SectionName = objRow[convcc_WorkEduClsRela.SectionName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.SectionName].ToString().Trim(); //节名(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_WorkEduClsRelaEN.ChapterNameSim = objRow[convcc_WorkEduClsRela.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ChapterNameSim].ToString().Trim(); //章名简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_WorkEduClsRelaEN.SectionNameSim = objRow[convcc_WorkEduClsRela.SectionNameSim] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.SectionNameSim].ToString().Trim(); //节名简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_WorkEduClsRelaEN.ParentNodeId = objRow[convcc_WorkEduClsRela.ParentNodeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ParentNodeId].ToString().Trim(); //父节点编号(字段类型:varchar,字段长度:8,是否可空:True)
 objvcc_WorkEduClsRelaEN.CourseChapterReferred = objRow[convcc_WorkEduClsRela.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseChapterReferred].ToString().Trim(); //节简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_WorkEduClsRelaEN.ParentNodeName = objRow[convcc_WorkEduClsRela.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ParentNodeName].ToString().Trim(); //父节点名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_WorkEduClsRelaEN.ParentNodeReferred = objRow[convcc_WorkEduClsRela.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ParentNodeReferred].ToString().Trim(); //章简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_WorkEduClsRelaEN.QuestionTypeId = objRow[convcc_WorkEduClsRela.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionTypeId].ToString().Trim(); //题目类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvcc_WorkEduClsRelaEN.QuestionTypeName = objRow[convcc_WorkEduClsRela.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionTypeName].ToString().Trim(); //题目类型名(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_WorkEduClsRelaEN.ExamGradeId = objRow[convcc_WorkEduClsRela.ExamGradeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ExamGradeId].ToString().Trim(); //题库等级ID(字段类型:char,字段长度:2,是否可空:True)
 objvcc_WorkEduClsRelaEN.ExamGradeName = objRow[convcc_WorkEduClsRela.ExamGradeName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ExamGradeName].ToString().Trim(); //题库等级名(字段类型:varchar,字段长度:50,是否可空:True)
 objvcc_WorkEduClsRelaEN.AnswerTypeId = objRow[convcc_WorkEduClsRela.AnswerTypeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.AnswerTypeId].ToString().Trim(); //答案类型ID(字段类型:char,字段长度:2,是否可空:True)
 objvcc_WorkEduClsRelaEN.AnswerModeId = objRow[convcc_WorkEduClsRela.AnswerModeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.AnswerModeId].ToString().Trim(); //答案模式Id(字段类型:char,字段长度:4,是否可空:True)
 objvcc_WorkEduClsRelaEN.DefaultValue = objRow[convcc_WorkEduClsRela.DefaultValue] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.DefaultValue].ToString().Trim(); //缺省值(字段类型:varchar,字段长度:50,是否可空:True)
 objvcc_WorkEduClsRelaEN.TextDirectId = objRow[convcc_WorkEduClsRela.TextDirectId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.TextDirectId].ToString().Trim(); //文本方向ID(字段类型:char,字段长度:4,是否可空:True)
 objvcc_WorkEduClsRelaEN.RelaEvent = objRow[convcc_WorkEduClsRela.RelaEvent] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.RelaEvent].ToString().Trim(); //相关事件(字段类型:varchar,字段长度:4000,是否可空:True)
 objvcc_WorkEduClsRelaEN.CheckBoxLimitCount = objRow[convcc_WorkEduClsRela.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.CheckBoxLimitCount].ToString().Trim()); //复选框限制数(字段类型:int,字段长度:4,是否可空:True)
 objvcc_WorkEduClsRelaEN.AnswerAttLimitSize = objRow[convcc_WorkEduClsRela.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小(字段类型:bigint,字段长度:8,是否可空:True)
 objvcc_WorkEduClsRelaEN.LimitedResourceType = objRow[convcc_WorkEduClsRela.LimitedResourceType] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.LimitedResourceType].ToString().Trim(); //限制资源类型(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_WorkEduClsRelaEN.QuestionTypeId4Course = objRow[convcc_WorkEduClsRela.QuestionTypeId4Course] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程(字段类型:char,字段长度:8,是否可空:False)
 objvcc_WorkEduClsRelaEN.QuestionTypeName4Course = objRow[convcc_WorkEduClsRela.QuestionTypeName4Course] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程(字段类型:varchar,字段长度:30,是否可空:False)
 objvcc_WorkEduClsRelaEN.IdCurrEduCls = objRow[convcc_WorkEduClsRela.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvcc_WorkEduClsRelaEN.CurrEduClsId = objRow[convcc_WorkEduClsRela.CurrEduClsId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CurrEduClsId].ToString().Trim(); //教学班Id(字段类型:varchar,字段长度:15,是否可空:True)
 objvcc_WorkEduClsRelaEN.EduClsName = objRow[convcc_WorkEduClsRela.EduClsName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.EduClsName].ToString().Trim(); //教学班名(字段类型:varchar,字段长度:100,是否可空:False)
 objvcc_WorkEduClsRelaEN.Scores = objRow[convcc_WorkEduClsRela.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_WorkEduClsRela.Scores].ToString().Trim()); //分值(字段类型:decimal,字段长度:8,是否可空:True)
 objvcc_WorkEduClsRelaEN.TeacherId = objRow[convcc_WorkEduClsRela.TeacherId].ToString().Trim(); //教师工号(字段类型:varchar,字段长度:12,是否可空:False)
 objvcc_WorkEduClsRelaEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkEduClsRela.IsPublish].ToString().Trim()); //是否发布(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_WorkEduClsRelaEN.PubDate = objRow[convcc_WorkEduClsRela.PubDate].ToString().Trim(); //发布日期(字段类型:varchar,字段长度:14,是否可空:False)
 objvcc_WorkEduClsRelaEN.publisher = objRow[convcc_WorkEduClsRela.publisher] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.publisher].ToString().Trim(); //发布者Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_WorkEduClsRelaEN.SpecifyCompletionDate = objRow[convcc_WorkEduClsRela.SpecifyCompletionDate].ToString().Trim(); //指定完成日期(字段类型:varchar,字段长度:14,是否可空:False)
 objvcc_WorkEduClsRelaEN.IsCurrEduCls = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkEduClsRela.IsCurrEduCls].ToString().Trim()); //是否为教学班作业(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_WorkEduClsRelaEN.IsGroupWork = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkEduClsRela.IsGroupWork].ToString().Trim()); //是否为小组作业(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_WorkEduClsRelaEN.CourseStudentGroupId = objRow[convcc_WorkEduClsRela.CourseStudentGroupId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.CourseStudentGroupId].ToString().Trim()); //学生分组表流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvcc_WorkEduClsRelaEN.WorkTypeId = objRow[convcc_WorkEduClsRela.WorkTypeId].ToString().Trim(); //作业类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvcc_WorkEduClsRelaEN.WorkTypeName = objRow[convcc_WorkEduClsRela.WorkTypeName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.WorkTypeName].ToString().Trim(); //作业类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvcc_WorkEduClsRelaEN.UpdDate = objRow[convcc_WorkEduClsRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_WorkEduClsRelaEN.UpdUserId = objRow[convcc_WorkEduClsRela.UpdUserId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_WorkEduClsRelaEN.Memo = objRow[convcc_WorkEduClsRela.Memo] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvcc_WorkEduClsRelaEN.StuNum = objRow[convcc_WorkEduClsRela.StuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.StuNum].ToString().Trim()); //学生数(字段类型:int,字段长度:4,是否可空:True)
 objvcc_WorkEduClsRelaEN.EduClsStuNum = objRow[convcc_WorkEduClsRela.EduClsStuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.EduClsStuNum].ToString().Trim()); //教学班学生数(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvcc_WorkEduClsRelaDA: GetObjByIdWorkEduClsRela)", objException.Message));
}
return objvcc_WorkEduClsRelaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvcc_WorkEduClsRelaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvcc_WorkEduClsRelaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkEduClsRelaDA.GetSpecSQLObj();
strSQL = "Select * from vcc_WorkEduClsRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN = new clsvcc_WorkEduClsRelaEN()
{
IdWorkEduClsRela = TransNullToInt(objRow[convcc_WorkEduClsRela.IdWorkEduClsRela].ToString().Trim()), //作业教学班关系流水号
QuestionId = objRow[convcc_WorkEduClsRela.QuestionId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convcc_WorkEduClsRela.QuestionId].ToString().Trim()), //题目Id
QuestionIndex = objRow[convcc_WorkEduClsRela.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_WorkEduClsRela.QuestionIndex].ToString().Trim()), //题目序号
QuestionName = objRow[convcc_WorkEduClsRela.QuestionName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionName].ToString().Trim(), //题目名称
QuestionContent = objRow[convcc_WorkEduClsRela.QuestionContent] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionContent].ToString().Trim(), //题目内容
CourseId = objRow[convcc_WorkEduClsRela.CourseId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseId].ToString().Trim(), //课程Id
CourseName = objRow[convcc_WorkEduClsRela.CourseName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseName].ToString().Trim(), //课程名称
CourseChapterId = objRow[convcc_WorkEduClsRela.CourseChapterId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseChapterId].ToString().Trim(), //课程章节ID
CourseChapterName = objRow[convcc_WorkEduClsRela.CourseChapterName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseChapterName].ToString().Trim(), //课程章节名称
ChapterName = objRow[convcc_WorkEduClsRela.ChapterName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ChapterName].ToString().Trim(), //章名
SectionName = objRow[convcc_WorkEduClsRela.SectionName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.SectionName].ToString().Trim(), //节名
ChapterNameSim = objRow[convcc_WorkEduClsRela.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ChapterNameSim].ToString().Trim(), //章名简称
SectionNameSim = objRow[convcc_WorkEduClsRela.SectionNameSim] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.SectionNameSim].ToString().Trim(), //节名简称
ParentNodeId = objRow[convcc_WorkEduClsRela.ParentNodeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ParentNodeId].ToString().Trim(), //父节点编号
CourseChapterReferred = objRow[convcc_WorkEduClsRela.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseChapterReferred].ToString().Trim(), //节简称
ParentNodeName = objRow[convcc_WorkEduClsRela.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ParentNodeName].ToString().Trim(), //父节点名称
ParentNodeReferred = objRow[convcc_WorkEduClsRela.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ParentNodeReferred].ToString().Trim(), //章简称
QuestionTypeId = objRow[convcc_WorkEduClsRela.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionTypeId].ToString().Trim(), //题目类型Id
QuestionTypeName = objRow[convcc_WorkEduClsRela.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionTypeName].ToString().Trim(), //题目类型名
ExamGradeId = objRow[convcc_WorkEduClsRela.ExamGradeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ExamGradeId].ToString().Trim(), //题库等级ID
ExamGradeName = objRow[convcc_WorkEduClsRela.ExamGradeName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ExamGradeName].ToString().Trim(), //题库等级名
AnswerTypeId = objRow[convcc_WorkEduClsRela.AnswerTypeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.AnswerTypeId].ToString().Trim(), //答案类型ID
AnswerModeId = objRow[convcc_WorkEduClsRela.AnswerModeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.AnswerModeId].ToString().Trim(), //答案模式Id
DefaultValue = objRow[convcc_WorkEduClsRela.DefaultValue] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.DefaultValue].ToString().Trim(), //缺省值
TextDirectId = objRow[convcc_WorkEduClsRela.TextDirectId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.TextDirectId].ToString().Trim(), //文本方向ID
RelaEvent = objRow[convcc_WorkEduClsRela.RelaEvent] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.RelaEvent].ToString().Trim(), //相关事件
CheckBoxLimitCount = objRow[convcc_WorkEduClsRela.CheckBoxLimitCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_WorkEduClsRela.CheckBoxLimitCount].ToString().Trim()), //复选框限制数
AnswerAttLimitSize = objRow[convcc_WorkEduClsRela.AnswerAttLimitSize] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convcc_WorkEduClsRela.AnswerAttLimitSize].ToString().Trim()), //回答附件限制大小
LimitedResourceType = objRow[convcc_WorkEduClsRela.LimitedResourceType] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.LimitedResourceType].ToString().Trim(), //限制资源类型
QuestionTypeId4Course = objRow[convcc_WorkEduClsRela.QuestionTypeId4Course] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionTypeId4Course].ToString().Trim(), //题目类型Id4课程
QuestionTypeName4Course = objRow[convcc_WorkEduClsRela.QuestionTypeName4Course] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionTypeName4Course].ToString().Trim(), //题目类型名4课程
IdCurrEduCls = objRow[convcc_WorkEduClsRela.IdCurrEduCls].ToString().Trim(), //教学班流水号
CurrEduClsId = objRow[convcc_WorkEduClsRela.CurrEduClsId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CurrEduClsId].ToString().Trim(), //教学班Id
EduClsName = objRow[convcc_WorkEduClsRela.EduClsName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.EduClsName].ToString().Trim(), //教学班名
Scores = objRow[convcc_WorkEduClsRela.Scores] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convcc_WorkEduClsRela.Scores].ToString().Trim()), //分值
TeacherId = objRow[convcc_WorkEduClsRela.TeacherId].ToString().Trim(), //教师工号
IsPublish = TransNullToBool(objRow[convcc_WorkEduClsRela.IsPublish].ToString().Trim()), //是否发布
PubDate = objRow[convcc_WorkEduClsRela.PubDate].ToString().Trim(), //发布日期
publisher = objRow[convcc_WorkEduClsRela.publisher] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.publisher].ToString().Trim(), //发布者Id
SpecifyCompletionDate = objRow[convcc_WorkEduClsRela.SpecifyCompletionDate].ToString().Trim(), //指定完成日期
IsCurrEduCls = TransNullToBool(objRow[convcc_WorkEduClsRela.IsCurrEduCls].ToString().Trim()), //是否为教学班作业
IsGroupWork = TransNullToBool(objRow[convcc_WorkEduClsRela.IsGroupWork].ToString().Trim()), //是否为小组作业
CourseStudentGroupId = objRow[convcc_WorkEduClsRela.CourseStudentGroupId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convcc_WorkEduClsRela.CourseStudentGroupId].ToString().Trim()), //学生分组表流水号
WorkTypeId = objRow[convcc_WorkEduClsRela.WorkTypeId].ToString().Trim(), //作业类型Id
WorkTypeName = objRow[convcc_WorkEduClsRela.WorkTypeName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.WorkTypeName].ToString().Trim(), //作业类型名称
UpdDate = objRow[convcc_WorkEduClsRela.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[convcc_WorkEduClsRela.UpdUserId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[convcc_WorkEduClsRela.Memo] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.Memo].ToString().Trim(), //备注
StuNum = objRow[convcc_WorkEduClsRela.StuNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_WorkEduClsRela.StuNum].ToString().Trim()), //学生数
EduClsStuNum = objRow[convcc_WorkEduClsRela.EduClsStuNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_WorkEduClsRela.EduClsStuNum].ToString().Trim()) //教学班学生数
};
objvcc_WorkEduClsRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvcc_WorkEduClsRelaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvcc_WorkEduClsRelaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvcc_WorkEduClsRelaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN = new clsvcc_WorkEduClsRelaEN();
try
{
objvcc_WorkEduClsRelaEN.IdWorkEduClsRela = TransNullToInt(objRow[convcc_WorkEduClsRela.IdWorkEduClsRela].ToString().Trim()); //作业教学班关系流水号
objvcc_WorkEduClsRelaEN.QuestionId = objRow[convcc_WorkEduClsRela.QuestionId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convcc_WorkEduClsRela.QuestionId].ToString().Trim()); //题目Id
objvcc_WorkEduClsRelaEN.QuestionIndex = objRow[convcc_WorkEduClsRela.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_WorkEduClsRela.QuestionIndex].ToString().Trim()); //题目序号
objvcc_WorkEduClsRelaEN.QuestionName = objRow[convcc_WorkEduClsRela.QuestionName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionName].ToString().Trim(); //题目名称
objvcc_WorkEduClsRelaEN.QuestionContent = objRow[convcc_WorkEduClsRela.QuestionContent] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionContent].ToString().Trim(); //题目内容
objvcc_WorkEduClsRelaEN.CourseId = objRow[convcc_WorkEduClsRela.CourseId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseId].ToString().Trim(); //课程Id
objvcc_WorkEduClsRelaEN.CourseName = objRow[convcc_WorkEduClsRela.CourseName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseName].ToString().Trim(); //课程名称
objvcc_WorkEduClsRelaEN.CourseChapterId = objRow[convcc_WorkEduClsRela.CourseChapterId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkEduClsRelaEN.CourseChapterName = objRow[convcc_WorkEduClsRela.CourseChapterName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkEduClsRelaEN.ChapterName = objRow[convcc_WorkEduClsRela.ChapterName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ChapterName].ToString().Trim(); //章名
objvcc_WorkEduClsRelaEN.SectionName = objRow[convcc_WorkEduClsRela.SectionName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.SectionName].ToString().Trim(); //节名
objvcc_WorkEduClsRelaEN.ChapterNameSim = objRow[convcc_WorkEduClsRela.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkEduClsRelaEN.SectionNameSim = objRow[convcc_WorkEduClsRela.SectionNameSim] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkEduClsRelaEN.ParentNodeId = objRow[convcc_WorkEduClsRela.ParentNodeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_WorkEduClsRelaEN.CourseChapterReferred = objRow[convcc_WorkEduClsRela.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkEduClsRelaEN.ParentNodeName = objRow[convcc_WorkEduClsRela.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkEduClsRelaEN.ParentNodeReferred = objRow[convcc_WorkEduClsRela.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkEduClsRelaEN.QuestionTypeId = objRow[convcc_WorkEduClsRela.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_WorkEduClsRelaEN.QuestionTypeName = objRow[convcc_WorkEduClsRela.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionTypeName].ToString().Trim(); //题目类型名
objvcc_WorkEduClsRelaEN.ExamGradeId = objRow[convcc_WorkEduClsRela.ExamGradeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ExamGradeId].ToString().Trim(); //题库等级ID
objvcc_WorkEduClsRelaEN.ExamGradeName = objRow[convcc_WorkEduClsRela.ExamGradeName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ExamGradeName].ToString().Trim(); //题库等级名
objvcc_WorkEduClsRelaEN.AnswerTypeId = objRow[convcc_WorkEduClsRela.AnswerTypeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.AnswerTypeId].ToString().Trim(); //答案类型ID
objvcc_WorkEduClsRelaEN.AnswerModeId = objRow[convcc_WorkEduClsRela.AnswerModeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.AnswerModeId].ToString().Trim(); //答案模式Id
objvcc_WorkEduClsRelaEN.DefaultValue = objRow[convcc_WorkEduClsRela.DefaultValue] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.DefaultValue].ToString().Trim(); //缺省值
objvcc_WorkEduClsRelaEN.TextDirectId = objRow[convcc_WorkEduClsRela.TextDirectId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.TextDirectId].ToString().Trim(); //文本方向ID
objvcc_WorkEduClsRelaEN.RelaEvent = objRow[convcc_WorkEduClsRela.RelaEvent] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.RelaEvent].ToString().Trim(); //相关事件
objvcc_WorkEduClsRelaEN.CheckBoxLimitCount = objRow[convcc_WorkEduClsRela.CheckBoxLimitCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_WorkEduClsRela.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objvcc_WorkEduClsRelaEN.AnswerAttLimitSize = objRow[convcc_WorkEduClsRela.AnswerAttLimitSize] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convcc_WorkEduClsRela.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objvcc_WorkEduClsRelaEN.LimitedResourceType = objRow[convcc_WorkEduClsRela.LimitedResourceType] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.LimitedResourceType].ToString().Trim(); //限制资源类型
objvcc_WorkEduClsRelaEN.QuestionTypeId4Course = objRow[convcc_WorkEduClsRela.QuestionTypeId4Course] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvcc_WorkEduClsRelaEN.QuestionTypeName4Course = objRow[convcc_WorkEduClsRela.QuestionTypeName4Course] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程
objvcc_WorkEduClsRelaEN.IdCurrEduCls = objRow[convcc_WorkEduClsRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvcc_WorkEduClsRelaEN.CurrEduClsId = objRow[convcc_WorkEduClsRela.CurrEduClsId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CurrEduClsId].ToString().Trim(); //教学班Id
objvcc_WorkEduClsRelaEN.EduClsName = objRow[convcc_WorkEduClsRela.EduClsName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.EduClsName].ToString().Trim(); //教学班名
objvcc_WorkEduClsRelaEN.Scores = objRow[convcc_WorkEduClsRela.Scores] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convcc_WorkEduClsRela.Scores].ToString().Trim()); //分值
objvcc_WorkEduClsRelaEN.TeacherId = objRow[convcc_WorkEduClsRela.TeacherId].ToString().Trim(); //教师工号
objvcc_WorkEduClsRelaEN.IsPublish = TransNullToBool(objRow[convcc_WorkEduClsRela.IsPublish].ToString().Trim()); //是否发布
objvcc_WorkEduClsRelaEN.PubDate = objRow[convcc_WorkEduClsRela.PubDate].ToString().Trim(); //发布日期
objvcc_WorkEduClsRelaEN.publisher = objRow[convcc_WorkEduClsRela.publisher] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.publisher].ToString().Trim(); //发布者Id
objvcc_WorkEduClsRelaEN.SpecifyCompletionDate = objRow[convcc_WorkEduClsRela.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objvcc_WorkEduClsRelaEN.IsCurrEduCls = TransNullToBool(objRow[convcc_WorkEduClsRela.IsCurrEduCls].ToString().Trim()); //是否为教学班作业
objvcc_WorkEduClsRelaEN.IsGroupWork = TransNullToBool(objRow[convcc_WorkEduClsRela.IsGroupWork].ToString().Trim()); //是否为小组作业
objvcc_WorkEduClsRelaEN.CourseStudentGroupId = objRow[convcc_WorkEduClsRela.CourseStudentGroupId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convcc_WorkEduClsRela.CourseStudentGroupId].ToString().Trim()); //学生分组表流水号
objvcc_WorkEduClsRelaEN.WorkTypeId = objRow[convcc_WorkEduClsRela.WorkTypeId].ToString().Trim(); //作业类型Id
objvcc_WorkEduClsRelaEN.WorkTypeName = objRow[convcc_WorkEduClsRela.WorkTypeName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.WorkTypeName].ToString().Trim(); //作业类型名称
objvcc_WorkEduClsRelaEN.UpdDate = objRow[convcc_WorkEduClsRela.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkEduClsRelaEN.UpdUserId = objRow[convcc_WorkEduClsRela.UpdUserId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_WorkEduClsRelaEN.Memo = objRow[convcc_WorkEduClsRela.Memo] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.Memo].ToString().Trim(); //备注
objvcc_WorkEduClsRelaEN.StuNum = objRow[convcc_WorkEduClsRela.StuNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_WorkEduClsRela.StuNum].ToString().Trim()); //学生数
objvcc_WorkEduClsRelaEN.EduClsStuNum = objRow[convcc_WorkEduClsRela.EduClsStuNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_WorkEduClsRela.EduClsStuNum].ToString().Trim()); //教学班学生数
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvcc_WorkEduClsRelaDA: GetObjByDataRowvcc_WorkEduClsRela)", objException.Message));
}
objvcc_WorkEduClsRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvcc_WorkEduClsRelaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvcc_WorkEduClsRelaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN = new clsvcc_WorkEduClsRelaEN();
try
{
objvcc_WorkEduClsRelaEN.IdWorkEduClsRela = TransNullToInt(objRow[convcc_WorkEduClsRela.IdWorkEduClsRela].ToString().Trim()); //作业教学班关系流水号
objvcc_WorkEduClsRelaEN.QuestionId = objRow[convcc_WorkEduClsRela.QuestionId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convcc_WorkEduClsRela.QuestionId].ToString().Trim()); //题目Id
objvcc_WorkEduClsRelaEN.QuestionIndex = objRow[convcc_WorkEduClsRela.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_WorkEduClsRela.QuestionIndex].ToString().Trim()); //题目序号
objvcc_WorkEduClsRelaEN.QuestionName = objRow[convcc_WorkEduClsRela.QuestionName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionName].ToString().Trim(); //题目名称
objvcc_WorkEduClsRelaEN.QuestionContent = objRow[convcc_WorkEduClsRela.QuestionContent] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionContent].ToString().Trim(); //题目内容
objvcc_WorkEduClsRelaEN.CourseId = objRow[convcc_WorkEduClsRela.CourseId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseId].ToString().Trim(); //课程Id
objvcc_WorkEduClsRelaEN.CourseName = objRow[convcc_WorkEduClsRela.CourseName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseName].ToString().Trim(); //课程名称
objvcc_WorkEduClsRelaEN.CourseChapterId = objRow[convcc_WorkEduClsRela.CourseChapterId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkEduClsRelaEN.CourseChapterName = objRow[convcc_WorkEduClsRela.CourseChapterName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkEduClsRelaEN.ChapterName = objRow[convcc_WorkEduClsRela.ChapterName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ChapterName].ToString().Trim(); //章名
objvcc_WorkEduClsRelaEN.SectionName = objRow[convcc_WorkEduClsRela.SectionName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.SectionName].ToString().Trim(); //节名
objvcc_WorkEduClsRelaEN.ChapterNameSim = objRow[convcc_WorkEduClsRela.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkEduClsRelaEN.SectionNameSim = objRow[convcc_WorkEduClsRela.SectionNameSim] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkEduClsRelaEN.ParentNodeId = objRow[convcc_WorkEduClsRela.ParentNodeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_WorkEduClsRelaEN.CourseChapterReferred = objRow[convcc_WorkEduClsRela.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkEduClsRelaEN.ParentNodeName = objRow[convcc_WorkEduClsRela.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkEduClsRelaEN.ParentNodeReferred = objRow[convcc_WorkEduClsRela.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkEduClsRelaEN.QuestionTypeId = objRow[convcc_WorkEduClsRela.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_WorkEduClsRelaEN.QuestionTypeName = objRow[convcc_WorkEduClsRela.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionTypeName].ToString().Trim(); //题目类型名
objvcc_WorkEduClsRelaEN.ExamGradeId = objRow[convcc_WorkEduClsRela.ExamGradeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ExamGradeId].ToString().Trim(); //题库等级ID
objvcc_WorkEduClsRelaEN.ExamGradeName = objRow[convcc_WorkEduClsRela.ExamGradeName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ExamGradeName].ToString().Trim(); //题库等级名
objvcc_WorkEduClsRelaEN.AnswerTypeId = objRow[convcc_WorkEduClsRela.AnswerTypeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.AnswerTypeId].ToString().Trim(); //答案类型ID
objvcc_WorkEduClsRelaEN.AnswerModeId = objRow[convcc_WorkEduClsRela.AnswerModeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.AnswerModeId].ToString().Trim(); //答案模式Id
objvcc_WorkEduClsRelaEN.DefaultValue = objRow[convcc_WorkEduClsRela.DefaultValue] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.DefaultValue].ToString().Trim(); //缺省值
objvcc_WorkEduClsRelaEN.TextDirectId = objRow[convcc_WorkEduClsRela.TextDirectId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.TextDirectId].ToString().Trim(); //文本方向ID
objvcc_WorkEduClsRelaEN.RelaEvent = objRow[convcc_WorkEduClsRela.RelaEvent] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.RelaEvent].ToString().Trim(); //相关事件
objvcc_WorkEduClsRelaEN.CheckBoxLimitCount = objRow[convcc_WorkEduClsRela.CheckBoxLimitCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_WorkEduClsRela.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objvcc_WorkEduClsRelaEN.AnswerAttLimitSize = objRow[convcc_WorkEduClsRela.AnswerAttLimitSize] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convcc_WorkEduClsRela.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objvcc_WorkEduClsRelaEN.LimitedResourceType = objRow[convcc_WorkEduClsRela.LimitedResourceType] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.LimitedResourceType].ToString().Trim(); //限制资源类型
objvcc_WorkEduClsRelaEN.QuestionTypeId4Course = objRow[convcc_WorkEduClsRela.QuestionTypeId4Course] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvcc_WorkEduClsRelaEN.QuestionTypeName4Course = objRow[convcc_WorkEduClsRela.QuestionTypeName4Course] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程
objvcc_WorkEduClsRelaEN.IdCurrEduCls = objRow[convcc_WorkEduClsRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvcc_WorkEduClsRelaEN.CurrEduClsId = objRow[convcc_WorkEduClsRela.CurrEduClsId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CurrEduClsId].ToString().Trim(); //教学班Id
objvcc_WorkEduClsRelaEN.EduClsName = objRow[convcc_WorkEduClsRela.EduClsName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.EduClsName].ToString().Trim(); //教学班名
objvcc_WorkEduClsRelaEN.Scores = objRow[convcc_WorkEduClsRela.Scores] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convcc_WorkEduClsRela.Scores].ToString().Trim()); //分值
objvcc_WorkEduClsRelaEN.TeacherId = objRow[convcc_WorkEduClsRela.TeacherId].ToString().Trim(); //教师工号
objvcc_WorkEduClsRelaEN.IsPublish = TransNullToBool(objRow[convcc_WorkEduClsRela.IsPublish].ToString().Trim()); //是否发布
objvcc_WorkEduClsRelaEN.PubDate = objRow[convcc_WorkEduClsRela.PubDate].ToString().Trim(); //发布日期
objvcc_WorkEduClsRelaEN.publisher = objRow[convcc_WorkEduClsRela.publisher] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.publisher].ToString().Trim(); //发布者Id
objvcc_WorkEduClsRelaEN.SpecifyCompletionDate = objRow[convcc_WorkEduClsRela.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objvcc_WorkEduClsRelaEN.IsCurrEduCls = TransNullToBool(objRow[convcc_WorkEduClsRela.IsCurrEduCls].ToString().Trim()); //是否为教学班作业
objvcc_WorkEduClsRelaEN.IsGroupWork = TransNullToBool(objRow[convcc_WorkEduClsRela.IsGroupWork].ToString().Trim()); //是否为小组作业
objvcc_WorkEduClsRelaEN.CourseStudentGroupId = objRow[convcc_WorkEduClsRela.CourseStudentGroupId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convcc_WorkEduClsRela.CourseStudentGroupId].ToString().Trim()); //学生分组表流水号
objvcc_WorkEduClsRelaEN.WorkTypeId = objRow[convcc_WorkEduClsRela.WorkTypeId].ToString().Trim(); //作业类型Id
objvcc_WorkEduClsRelaEN.WorkTypeName = objRow[convcc_WorkEduClsRela.WorkTypeName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.WorkTypeName].ToString().Trim(); //作业类型名称
objvcc_WorkEduClsRelaEN.UpdDate = objRow[convcc_WorkEduClsRela.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkEduClsRelaEN.UpdUserId = objRow[convcc_WorkEduClsRela.UpdUserId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_WorkEduClsRelaEN.Memo = objRow[convcc_WorkEduClsRela.Memo] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.Memo].ToString().Trim(); //备注
objvcc_WorkEduClsRelaEN.StuNum = objRow[convcc_WorkEduClsRela.StuNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_WorkEduClsRela.StuNum].ToString().Trim()); //学生数
objvcc_WorkEduClsRelaEN.EduClsStuNum = objRow[convcc_WorkEduClsRela.EduClsStuNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_WorkEduClsRela.EduClsStuNum].ToString().Trim()); //教学班学生数
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvcc_WorkEduClsRelaDA: GetObjByDataRow)", objException.Message));
}
objvcc_WorkEduClsRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvcc_WorkEduClsRelaEN;
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
objSQL = clsvcc_WorkEduClsRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvcc_WorkEduClsRelaEN._CurrTabName, convcc_WorkEduClsRela.IdWorkEduClsRela, 8, "");
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
objSQL = clsvcc_WorkEduClsRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvcc_WorkEduClsRelaEN._CurrTabName, convcc_WorkEduClsRela.IdWorkEduClsRela, 8, strPrefix);
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
 objSQL = clsvcc_WorkEduClsRelaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdWorkEduClsRela from vcc_WorkEduClsRela where " + strCondition;
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
 objSQL = clsvcc_WorkEduClsRelaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdWorkEduClsRela from vcc_WorkEduClsRela where " + strCondition;
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
 /// <param name = "lngIdWorkEduClsRela">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngIdWorkEduClsRela)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkEduClsRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vcc_WorkEduClsRela", "IdWorkEduClsRela = " + ""+ lngIdWorkEduClsRela+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvcc_WorkEduClsRelaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkEduClsRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vcc_WorkEduClsRela", strCondition))
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
objSQL = clsvcc_WorkEduClsRelaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vcc_WorkEduClsRela");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaENS">源对象</param>
 /// <param name = "objvcc_WorkEduClsRelaENT">目标对象</param>
public void CopyTo(clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaENS, clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaENT)
{
objvcc_WorkEduClsRelaENT.IdWorkEduClsRela = objvcc_WorkEduClsRelaENS.IdWorkEduClsRela; //作业教学班关系流水号
objvcc_WorkEduClsRelaENT.QuestionId = objvcc_WorkEduClsRelaENS.QuestionId; //题目Id
objvcc_WorkEduClsRelaENT.QuestionIndex = objvcc_WorkEduClsRelaENS.QuestionIndex; //题目序号
objvcc_WorkEduClsRelaENT.QuestionName = objvcc_WorkEduClsRelaENS.QuestionName; //题目名称
objvcc_WorkEduClsRelaENT.QuestionContent = objvcc_WorkEduClsRelaENS.QuestionContent; //题目内容
objvcc_WorkEduClsRelaENT.CourseId = objvcc_WorkEduClsRelaENS.CourseId; //课程Id
objvcc_WorkEduClsRelaENT.CourseName = objvcc_WorkEduClsRelaENS.CourseName; //课程名称
objvcc_WorkEduClsRelaENT.CourseChapterId = objvcc_WorkEduClsRelaENS.CourseChapterId; //课程章节ID
objvcc_WorkEduClsRelaENT.CourseChapterName = objvcc_WorkEduClsRelaENS.CourseChapterName; //课程章节名称
objvcc_WorkEduClsRelaENT.ChapterName = objvcc_WorkEduClsRelaENS.ChapterName; //章名
objvcc_WorkEduClsRelaENT.SectionName = objvcc_WorkEduClsRelaENS.SectionName; //节名
objvcc_WorkEduClsRelaENT.ChapterNameSim = objvcc_WorkEduClsRelaENS.ChapterNameSim; //章名简称
objvcc_WorkEduClsRelaENT.SectionNameSim = objvcc_WorkEduClsRelaENS.SectionNameSim; //节名简称
objvcc_WorkEduClsRelaENT.ParentNodeId = objvcc_WorkEduClsRelaENS.ParentNodeId; //父节点编号
objvcc_WorkEduClsRelaENT.CourseChapterReferred = objvcc_WorkEduClsRelaENS.CourseChapterReferred; //节简称
objvcc_WorkEduClsRelaENT.ParentNodeName = objvcc_WorkEduClsRelaENS.ParentNodeName; //父节点名称
objvcc_WorkEduClsRelaENT.ParentNodeReferred = objvcc_WorkEduClsRelaENS.ParentNodeReferred; //章简称
objvcc_WorkEduClsRelaENT.QuestionTypeId = objvcc_WorkEduClsRelaENS.QuestionTypeId; //题目类型Id
objvcc_WorkEduClsRelaENT.QuestionTypeName = objvcc_WorkEduClsRelaENS.QuestionTypeName; //题目类型名
objvcc_WorkEduClsRelaENT.ExamGradeId = objvcc_WorkEduClsRelaENS.ExamGradeId; //题库等级ID
objvcc_WorkEduClsRelaENT.ExamGradeName = objvcc_WorkEduClsRelaENS.ExamGradeName; //题库等级名
objvcc_WorkEduClsRelaENT.AnswerTypeId = objvcc_WorkEduClsRelaENS.AnswerTypeId; //答案类型ID
objvcc_WorkEduClsRelaENT.AnswerModeId = objvcc_WorkEduClsRelaENS.AnswerModeId; //答案模式Id
objvcc_WorkEduClsRelaENT.DefaultValue = objvcc_WorkEduClsRelaENS.DefaultValue; //缺省值
objvcc_WorkEduClsRelaENT.TextDirectId = objvcc_WorkEduClsRelaENS.TextDirectId; //文本方向ID
objvcc_WorkEduClsRelaENT.RelaEvent = objvcc_WorkEduClsRelaENS.RelaEvent; //相关事件
objvcc_WorkEduClsRelaENT.CheckBoxLimitCount = objvcc_WorkEduClsRelaENS.CheckBoxLimitCount; //复选框限制数
objvcc_WorkEduClsRelaENT.AnswerAttLimitSize = objvcc_WorkEduClsRelaENS.AnswerAttLimitSize; //回答附件限制大小
objvcc_WorkEduClsRelaENT.LimitedResourceType = objvcc_WorkEduClsRelaENS.LimitedResourceType; //限制资源类型
objvcc_WorkEduClsRelaENT.QuestionTypeId4Course = objvcc_WorkEduClsRelaENS.QuestionTypeId4Course; //题目类型Id4课程
objvcc_WorkEduClsRelaENT.QuestionTypeName4Course = objvcc_WorkEduClsRelaENS.QuestionTypeName4Course; //题目类型名4课程
objvcc_WorkEduClsRelaENT.IdCurrEduCls = objvcc_WorkEduClsRelaENS.IdCurrEduCls; //教学班流水号
objvcc_WorkEduClsRelaENT.CurrEduClsId = objvcc_WorkEduClsRelaENS.CurrEduClsId; //教学班Id
objvcc_WorkEduClsRelaENT.EduClsName = objvcc_WorkEduClsRelaENS.EduClsName; //教学班名
objvcc_WorkEduClsRelaENT.Scores = objvcc_WorkEduClsRelaENS.Scores; //分值
objvcc_WorkEduClsRelaENT.TeacherId = objvcc_WorkEduClsRelaENS.TeacherId; //教师工号
objvcc_WorkEduClsRelaENT.IsPublish = objvcc_WorkEduClsRelaENS.IsPublish; //是否发布
objvcc_WorkEduClsRelaENT.PubDate = objvcc_WorkEduClsRelaENS.PubDate; //发布日期
objvcc_WorkEduClsRelaENT.publisher = objvcc_WorkEduClsRelaENS.publisher; //发布者Id
objvcc_WorkEduClsRelaENT.SpecifyCompletionDate = objvcc_WorkEduClsRelaENS.SpecifyCompletionDate; //指定完成日期
objvcc_WorkEduClsRelaENT.IsCurrEduCls = objvcc_WorkEduClsRelaENS.IsCurrEduCls; //是否为教学班作业
objvcc_WorkEduClsRelaENT.IsGroupWork = objvcc_WorkEduClsRelaENS.IsGroupWork; //是否为小组作业
objvcc_WorkEduClsRelaENT.CourseStudentGroupId = objvcc_WorkEduClsRelaENS.CourseStudentGroupId; //学生分组表流水号
objvcc_WorkEduClsRelaENT.WorkTypeId = objvcc_WorkEduClsRelaENS.WorkTypeId; //作业类型Id
objvcc_WorkEduClsRelaENT.WorkTypeName = objvcc_WorkEduClsRelaENS.WorkTypeName; //作业类型名称
objvcc_WorkEduClsRelaENT.UpdDate = objvcc_WorkEduClsRelaENS.UpdDate; //修改日期
objvcc_WorkEduClsRelaENT.UpdUserId = objvcc_WorkEduClsRelaENS.UpdUserId; //修改用户Id
objvcc_WorkEduClsRelaENT.Memo = objvcc_WorkEduClsRelaENS.Memo; //备注
objvcc_WorkEduClsRelaENT.StuNum = objvcc_WorkEduClsRelaENS.StuNum; //学生数
objvcc_WorkEduClsRelaENT.EduClsStuNum = objvcc_WorkEduClsRelaENS.EduClsStuNum; //教学班学生数
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvcc_WorkEduClsRelaEN.QuestionName, 500, convcc_WorkEduClsRela.QuestionName);
clsCheckSql.CheckFieldLen(objvcc_WorkEduClsRelaEN.QuestionContent, 4000, convcc_WorkEduClsRela.QuestionContent);
clsCheckSql.CheckFieldLen(objvcc_WorkEduClsRelaEN.CourseId, 8, convcc_WorkEduClsRela.CourseId);
clsCheckSql.CheckFieldLen(objvcc_WorkEduClsRelaEN.CourseName, 100, convcc_WorkEduClsRela.CourseName);
clsCheckSql.CheckFieldLen(objvcc_WorkEduClsRelaEN.CourseChapterId, 8, convcc_WorkEduClsRela.CourseChapterId);
clsCheckSql.CheckFieldLen(objvcc_WorkEduClsRelaEN.CourseChapterName, 100, convcc_WorkEduClsRela.CourseChapterName);
clsCheckSql.CheckFieldLen(objvcc_WorkEduClsRelaEN.ChapterName, 100, convcc_WorkEduClsRela.ChapterName);
clsCheckSql.CheckFieldLen(objvcc_WorkEduClsRelaEN.SectionName, 100, convcc_WorkEduClsRela.SectionName);
clsCheckSql.CheckFieldLen(objvcc_WorkEduClsRelaEN.ChapterNameSim, 10, convcc_WorkEduClsRela.ChapterNameSim);
clsCheckSql.CheckFieldLen(objvcc_WorkEduClsRelaEN.SectionNameSim, 10, convcc_WorkEduClsRela.SectionNameSim);
clsCheckSql.CheckFieldLen(objvcc_WorkEduClsRelaEN.ParentNodeId, 8, convcc_WorkEduClsRela.ParentNodeId);
clsCheckSql.CheckFieldLen(objvcc_WorkEduClsRelaEN.CourseChapterReferred, 10, convcc_WorkEduClsRela.CourseChapterReferred);
clsCheckSql.CheckFieldLen(objvcc_WorkEduClsRelaEN.ParentNodeName, 100, convcc_WorkEduClsRela.ParentNodeName);
clsCheckSql.CheckFieldLen(objvcc_WorkEduClsRelaEN.ParentNodeReferred, 10, convcc_WorkEduClsRela.ParentNodeReferred);
clsCheckSql.CheckFieldLen(objvcc_WorkEduClsRelaEN.QuestionTypeId, 2, convcc_WorkEduClsRela.QuestionTypeId);
clsCheckSql.CheckFieldLen(objvcc_WorkEduClsRelaEN.QuestionTypeName, 20, convcc_WorkEduClsRela.QuestionTypeName);
clsCheckSql.CheckFieldLen(objvcc_WorkEduClsRelaEN.ExamGradeId, 2, convcc_WorkEduClsRela.ExamGradeId);
clsCheckSql.CheckFieldLen(objvcc_WorkEduClsRelaEN.ExamGradeName, 50, convcc_WorkEduClsRela.ExamGradeName);
clsCheckSql.CheckFieldLen(objvcc_WorkEduClsRelaEN.AnswerTypeId, 2, convcc_WorkEduClsRela.AnswerTypeId);
clsCheckSql.CheckFieldLen(objvcc_WorkEduClsRelaEN.AnswerModeId, 4, convcc_WorkEduClsRela.AnswerModeId);
clsCheckSql.CheckFieldLen(objvcc_WorkEduClsRelaEN.DefaultValue, 50, convcc_WorkEduClsRela.DefaultValue);
clsCheckSql.CheckFieldLen(objvcc_WorkEduClsRelaEN.TextDirectId, 4, convcc_WorkEduClsRela.TextDirectId);
clsCheckSql.CheckFieldLen(objvcc_WorkEduClsRelaEN.RelaEvent, 4000, convcc_WorkEduClsRela.RelaEvent);
clsCheckSql.CheckFieldLen(objvcc_WorkEduClsRelaEN.LimitedResourceType, 100, convcc_WorkEduClsRela.LimitedResourceType);
clsCheckSql.CheckFieldLen(objvcc_WorkEduClsRelaEN.QuestionTypeId4Course, 8, convcc_WorkEduClsRela.QuestionTypeId4Course);
clsCheckSql.CheckFieldLen(objvcc_WorkEduClsRelaEN.QuestionTypeName4Course, 30, convcc_WorkEduClsRela.QuestionTypeName4Course);
clsCheckSql.CheckFieldLen(objvcc_WorkEduClsRelaEN.IdCurrEduCls, 8, convcc_WorkEduClsRela.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objvcc_WorkEduClsRelaEN.CurrEduClsId, 15, convcc_WorkEduClsRela.CurrEduClsId);
clsCheckSql.CheckFieldLen(objvcc_WorkEduClsRelaEN.EduClsName, 100, convcc_WorkEduClsRela.EduClsName);
clsCheckSql.CheckFieldLen(objvcc_WorkEduClsRelaEN.TeacherId, 12, convcc_WorkEduClsRela.TeacherId);
clsCheckSql.CheckFieldLen(objvcc_WorkEduClsRelaEN.PubDate, 14, convcc_WorkEduClsRela.PubDate);
clsCheckSql.CheckFieldLen(objvcc_WorkEduClsRelaEN.publisher, 20, convcc_WorkEduClsRela.publisher);
clsCheckSql.CheckFieldLen(objvcc_WorkEduClsRelaEN.SpecifyCompletionDate, 14, convcc_WorkEduClsRela.SpecifyCompletionDate);
clsCheckSql.CheckFieldLen(objvcc_WorkEduClsRelaEN.WorkTypeId, 2, convcc_WorkEduClsRela.WorkTypeId);
clsCheckSql.CheckFieldLen(objvcc_WorkEduClsRelaEN.WorkTypeName, 30, convcc_WorkEduClsRela.WorkTypeName);
clsCheckSql.CheckFieldLen(objvcc_WorkEduClsRelaEN.UpdDate, 20, convcc_WorkEduClsRela.UpdDate);
clsCheckSql.CheckFieldLen(objvcc_WorkEduClsRelaEN.UpdUserId, 20, convcc_WorkEduClsRela.UpdUserId);
clsCheckSql.CheckFieldLen(objvcc_WorkEduClsRelaEN.Memo, 1000, convcc_WorkEduClsRela.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkEduClsRelaEN.QuestionName, convcc_WorkEduClsRela.QuestionName);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkEduClsRelaEN.QuestionContent, convcc_WorkEduClsRela.QuestionContent);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkEduClsRelaEN.CourseId, convcc_WorkEduClsRela.CourseId);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkEduClsRelaEN.CourseName, convcc_WorkEduClsRela.CourseName);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkEduClsRelaEN.CourseChapterId, convcc_WorkEduClsRela.CourseChapterId);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkEduClsRelaEN.CourseChapterName, convcc_WorkEduClsRela.CourseChapterName);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkEduClsRelaEN.ChapterName, convcc_WorkEduClsRela.ChapterName);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkEduClsRelaEN.SectionName, convcc_WorkEduClsRela.SectionName);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkEduClsRelaEN.ChapterNameSim, convcc_WorkEduClsRela.ChapterNameSim);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkEduClsRelaEN.SectionNameSim, convcc_WorkEduClsRela.SectionNameSim);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkEduClsRelaEN.ParentNodeId, convcc_WorkEduClsRela.ParentNodeId);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkEduClsRelaEN.CourseChapterReferred, convcc_WorkEduClsRela.CourseChapterReferred);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkEduClsRelaEN.ParentNodeName, convcc_WorkEduClsRela.ParentNodeName);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkEduClsRelaEN.ParentNodeReferred, convcc_WorkEduClsRela.ParentNodeReferred);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkEduClsRelaEN.QuestionTypeId, convcc_WorkEduClsRela.QuestionTypeId);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkEduClsRelaEN.QuestionTypeName, convcc_WorkEduClsRela.QuestionTypeName);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkEduClsRelaEN.ExamGradeId, convcc_WorkEduClsRela.ExamGradeId);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkEduClsRelaEN.ExamGradeName, convcc_WorkEduClsRela.ExamGradeName);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkEduClsRelaEN.AnswerTypeId, convcc_WorkEduClsRela.AnswerTypeId);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkEduClsRelaEN.AnswerModeId, convcc_WorkEduClsRela.AnswerModeId);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkEduClsRelaEN.DefaultValue, convcc_WorkEduClsRela.DefaultValue);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkEduClsRelaEN.TextDirectId, convcc_WorkEduClsRela.TextDirectId);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkEduClsRelaEN.RelaEvent, convcc_WorkEduClsRela.RelaEvent);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkEduClsRelaEN.LimitedResourceType, convcc_WorkEduClsRela.LimitedResourceType);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkEduClsRelaEN.QuestionTypeId4Course, convcc_WorkEduClsRela.QuestionTypeId4Course);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkEduClsRelaEN.QuestionTypeName4Course, convcc_WorkEduClsRela.QuestionTypeName4Course);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkEduClsRelaEN.IdCurrEduCls, convcc_WorkEduClsRela.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkEduClsRelaEN.CurrEduClsId, convcc_WorkEduClsRela.CurrEduClsId);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkEduClsRelaEN.EduClsName, convcc_WorkEduClsRela.EduClsName);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkEduClsRelaEN.TeacherId, convcc_WorkEduClsRela.TeacherId);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkEduClsRelaEN.PubDate, convcc_WorkEduClsRela.PubDate);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkEduClsRelaEN.publisher, convcc_WorkEduClsRela.publisher);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkEduClsRelaEN.SpecifyCompletionDate, convcc_WorkEduClsRela.SpecifyCompletionDate);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkEduClsRelaEN.WorkTypeId, convcc_WorkEduClsRela.WorkTypeId);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkEduClsRelaEN.WorkTypeName, convcc_WorkEduClsRela.WorkTypeName);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkEduClsRelaEN.UpdDate, convcc_WorkEduClsRela.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkEduClsRelaEN.UpdUserId, convcc_WorkEduClsRela.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkEduClsRelaEN.Memo, convcc_WorkEduClsRela.Memo);
//检查外键字段长度
 objvcc_WorkEduClsRelaEN._IsCheckProperty = true;
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
 objSQL = clsvcc_WorkEduClsRelaDA.GetSpecSQLObj();
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
 objSQL = clsvcc_WorkEduClsRelaDA.GetSpecSQLObj();
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
 objSQL = clsvcc_WorkEduClsRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvcc_WorkEduClsRelaEN._CurrTabName);
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
 objSQL = clsvcc_WorkEduClsRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvcc_WorkEduClsRelaEN._CurrTabName, strCondition);
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
 objSQL = clsvcc_WorkEduClsRelaDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}