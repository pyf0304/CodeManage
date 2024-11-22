
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_WorkStuRelationDA
 表名:vcc_WorkStuRelation(01120198)
 * 版本:2024.11.08.1(服务器:WIN-SRV103-116)
 日期:2024/11/09 22:30:12
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
 /// v作业与学生关系表(vcc_WorkStuRelation)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvcc_WorkStuRelationDA : clsCommBase4DA
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
 return clsvcc_WorkStuRelationEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvcc_WorkStuRelationEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvcc_WorkStuRelationEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvcc_WorkStuRelationEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvcc_WorkStuRelationEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvcc_WorkStuRelationDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkStuRelationDA.GetSpecSQLObj();
strSQL = "Select * from vcc_WorkStuRelation where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vcc_WorkStuRelation(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvcc_WorkStuRelationDA: GetDataTable_vcc_WorkStuRelation)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkStuRelationDA.GetSpecSQLObj();
strSQL = "Select * from vcc_WorkStuRelation where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvcc_WorkStuRelationDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkStuRelationDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvcc_WorkStuRelationDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkStuRelationDA.GetSpecSQLObj();
strSQL = "Select * from vcc_WorkStuRelation where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvcc_WorkStuRelationDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkStuRelationDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvcc_WorkStuRelationDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkStuRelationDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vcc_WorkStuRelation where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vcc_WorkStuRelation where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvcc_WorkStuRelationDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkStuRelationDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vcc_WorkStuRelation where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvcc_WorkStuRelationDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkStuRelationDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vcc_WorkStuRelation.* from vcc_WorkStuRelation Left Join {1} on {2} where {3} and vcc_WorkStuRelation.IdWorkStuRelation not in (Select top {5} vcc_WorkStuRelation.IdWorkStuRelation from vcc_WorkStuRelation Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vcc_WorkStuRelation where {1} and IdWorkStuRelation not in (Select top {2} IdWorkStuRelation from vcc_WorkStuRelation where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vcc_WorkStuRelation where {1} and IdWorkStuRelation not in (Select top {3} IdWorkStuRelation from vcc_WorkStuRelation where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvcc_WorkStuRelationDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkStuRelationDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vcc_WorkStuRelation.* from vcc_WorkStuRelation Left Join {1} on {2} where {3} and vcc_WorkStuRelation.IdWorkStuRelation not in (Select top {5} vcc_WorkStuRelation.IdWorkStuRelation from vcc_WorkStuRelation Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vcc_WorkStuRelation where {1} and IdWorkStuRelation not in (Select top {2} IdWorkStuRelation from vcc_WorkStuRelation where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vcc_WorkStuRelation where {1} and IdWorkStuRelation not in (Select top {3} IdWorkStuRelation from vcc_WorkStuRelation where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvcc_WorkStuRelationEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvcc_WorkStuRelationDA:GetObjLst)", objException.Message));
}
List<clsvcc_WorkStuRelationEN> arrObjLst = new List<clsvcc_WorkStuRelationEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkStuRelationDA.GetSpecSQLObj();
strSQL = "Select * from vcc_WorkStuRelation where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN = new clsvcc_WorkStuRelationEN();
try
{
objvcc_WorkStuRelationEN.IdWorkStuRelation = TransNullToInt(objRow[convcc_WorkStuRelation.IdWorkStuRelation].ToString().Trim()); //流水号
objvcc_WorkStuRelationEN.IdCurrEduCls = objRow[convcc_WorkStuRelation.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvcc_WorkStuRelationEN.IdWorkEduClsRela = objRow[convcc_WorkStuRelation.IdWorkEduClsRela] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convcc_WorkStuRelation.IdWorkEduClsRela].ToString().Trim()); //作业教学班关系流水号
objvcc_WorkStuRelationEN.QuestionId = objRow[convcc_WorkStuRelation.QuestionId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convcc_WorkStuRelation.QuestionId].ToString().Trim()); //题目Id
objvcc_WorkStuRelationEN.QuestionIndex = objRow[convcc_WorkStuRelation.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_WorkStuRelation.QuestionIndex].ToString().Trim()); //题目序号
objvcc_WorkStuRelationEN.QuestionName = objRow[convcc_WorkStuRelation.QuestionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionName].ToString().Trim(); //题目名称
objvcc_WorkStuRelationEN.QuestionContent = objRow[convcc_WorkStuRelation.QuestionContent] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionContent].ToString().Trim(); //题目内容
objvcc_WorkStuRelationEN.CourseId = objRow[convcc_WorkStuRelation.CourseId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseId].ToString().Trim(); //课程Id
objvcc_WorkStuRelationEN.CourseName = objRow[convcc_WorkStuRelation.CourseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseName].ToString().Trim(); //课程名称
objvcc_WorkStuRelationEN.CourseChapterId = objRow[convcc_WorkStuRelation.CourseChapterId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkStuRelationEN.CourseChapterName = objRow[convcc_WorkStuRelation.CourseChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkStuRelationEN.ChapterName = objRow[convcc_WorkStuRelation.ChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ChapterName].ToString().Trim(); //章名
objvcc_WorkStuRelationEN.SectionName = objRow[convcc_WorkStuRelation.SectionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.SectionName].ToString().Trim(); //节名
objvcc_WorkStuRelationEN.ChapterNameSim = objRow[convcc_WorkStuRelation.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkStuRelationEN.SectionNameSim = objRow[convcc_WorkStuRelation.SectionNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkStuRelationEN.ParentNodeId = objRow[convcc_WorkStuRelation.ParentNodeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_WorkStuRelationEN.CourseChapterReferred = objRow[convcc_WorkStuRelation.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkStuRelationEN.ParentNodeName = objRow[convcc_WorkStuRelation.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkStuRelationEN.ParentNodeReferred = objRow[convcc_WorkStuRelation.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkStuRelationEN.QuestionTypeId = objRow[convcc_WorkStuRelation.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_WorkStuRelationEN.QuestionTypeName = objRow[convcc_WorkStuRelation.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionTypeName].ToString().Trim(); //题目类型名
objvcc_WorkStuRelationEN.AnswerTypeId = objRow[convcc_WorkStuRelation.AnswerTypeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerTypeId].ToString().Trim(); //答案类型ID
objvcc_WorkStuRelationEN.DefaultValue = objRow[convcc_WorkStuRelation.DefaultValue] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.DefaultValue].ToString().Trim(); //缺省值
objvcc_WorkStuRelationEN.TextDirectId = objRow[convcc_WorkStuRelation.TextDirectId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.TextDirectId].ToString().Trim(); //文本方向ID
objvcc_WorkStuRelationEN.RelaEvent = objRow[convcc_WorkStuRelation.RelaEvent] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.RelaEvent].ToString().Trim(); //相关事件
objvcc_WorkStuRelationEN.CheckBoxLimitCount = objRow[convcc_WorkStuRelation.CheckBoxLimitCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_WorkStuRelation.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objvcc_WorkStuRelationEN.AnswerAttLimitSize = objRow[convcc_WorkStuRelation.AnswerAttLimitSize] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convcc_WorkStuRelation.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objvcc_WorkStuRelationEN.LimitedResourceType = objRow[convcc_WorkStuRelation.LimitedResourceType] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.LimitedResourceType].ToString().Trim(); //限制资源类型
objvcc_WorkStuRelationEN.QuestionTypeId4Course = objRow[convcc_WorkStuRelation.QuestionTypeId4Course] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvcc_WorkStuRelationEN.QuestionTypeName4Course = objRow[convcc_WorkStuRelation.QuestionTypeName4Course] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程
objvcc_WorkStuRelationEN.CurrEduClsId = objRow[convcc_WorkStuRelation.CurrEduClsId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CurrEduClsId].ToString().Trim(); //教学班Id
objvcc_WorkStuRelationEN.EduClsName = objRow[convcc_WorkStuRelation.EduClsName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.EduClsName].ToString().Trim(); //教学班名
objvcc_WorkStuRelationEN.TeacherId = objRow[convcc_WorkStuRelation.TeacherId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.TeacherId].ToString().Trim(); //教师工号
objvcc_WorkStuRelationEN.PubDate = objRow[convcc_WorkStuRelation.PubDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.PubDate].ToString().Trim(); //发布日期
objvcc_WorkStuRelationEN.IsCurrEduCls = TransNullToBool(objRow[convcc_WorkStuRelation.IsCurrEduCls].ToString().Trim()); //是否为教学班作业
objvcc_WorkStuRelationEN.IsGroupWork = TransNullToBool(objRow[convcc_WorkStuRelation.IsGroupWork].ToString().Trim()); //是否为小组作业
objvcc_WorkStuRelationEN.CourseStudentGroupId = objRow[convcc_WorkStuRelation.CourseStudentGroupId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convcc_WorkStuRelation.CourseStudentGroupId].ToString().Trim()); //学生分组表流水号
objvcc_WorkStuRelationEN.WorkTypeName = objRow[convcc_WorkStuRelation.WorkTypeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.WorkTypeName].ToString().Trim(); //作业类型名称
objvcc_WorkStuRelationEN.Scores = objRow[convcc_WorkStuRelation.Scores] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convcc_WorkStuRelation.Scores].ToString().Trim()); //分值
objvcc_WorkStuRelationEN.SpecifyCompletionDate = objRow[convcc_WorkStuRelation.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objvcc_WorkStuRelationEN.IdStudentInfo = objRow[convcc_WorkStuRelation.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_WorkStuRelationEN.StuId = objRow[convcc_WorkStuRelation.StuId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.StuId].ToString().Trim(); //学号
objvcc_WorkStuRelationEN.StuName = objRow[convcc_WorkStuRelation.StuName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.StuName].ToString().Trim(); //姓名
objvcc_WorkStuRelationEN.IdXzCollege = objRow[convcc_WorkStuRelation.IdXzCollege] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_WorkStuRelationEN.CollegeName = objRow[convcc_WorkStuRelation.CollegeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CollegeName].ToString().Trim(); //学院名称
objvcc_WorkStuRelationEN.CollegeNameA = objRow[convcc_WorkStuRelation.CollegeNameA] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_WorkStuRelationEN.IdXzMajor = objRow[convcc_WorkStuRelation.IdXzMajor] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_WorkStuRelationEN.MajorId = objRow[convcc_WorkStuRelation.MajorId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.MajorId].ToString().Trim(); //专业Id
objvcc_WorkStuRelationEN.MajorName = objRow[convcc_WorkStuRelation.MajorName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.MajorName].ToString().Trim(); //专业名称
objvcc_WorkStuRelationEN.IdGradeBase = objRow[convcc_WorkStuRelation.IdGradeBase] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.IdGradeBase].ToString().Trim(); //年级流水号
objvcc_WorkStuRelationEN.GradeBaseName = objRow[convcc_WorkStuRelation.GradeBaseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.GradeBaseName].ToString().Trim(); //年级名称
objvcc_WorkStuRelationEN.AdminClsName = objRow[convcc_WorkStuRelation.AdminClsName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AdminClsName].ToString().Trim(); //行政班名称
objvcc_WorkStuRelationEN.AdminClsId = objRow[convcc_WorkStuRelation.AdminClsId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AdminClsId].ToString().Trim(); //行政班代号
objvcc_WorkStuRelationEN.AnswerModeId = objRow[convcc_WorkStuRelation.AnswerModeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerModeId].ToString().Trim(); //答案模式Id
objvcc_WorkStuRelationEN.AnswerOptionId = objRow[convcc_WorkStuRelation.AnswerOptionId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerOptionId].ToString().Trim(); //回答选项Id
objvcc_WorkStuRelationEN.AnswerMultiOptions = objRow[convcc_WorkStuRelation.AnswerMultiOptions] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerMultiOptions].ToString().Trim(); //多选项答案
objvcc_WorkStuRelationEN.AnswerBoolResult = TransNullToBool(objRow[convcc_WorkStuRelation.AnswerBoolResult].ToString().Trim()); //答案布尔结果
objvcc_WorkStuRelationEN.StuAnswerText = objRow[convcc_WorkStuRelation.StuAnswerText] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.StuAnswerText].ToString().Trim(); //学生回答文本
objvcc_WorkStuRelationEN.IsPublish = TransNullToBool(objRow[convcc_WorkStuRelation.IsPublish].ToString().Trim()); //是否发布
objvcc_WorkStuRelationEN.IsLook = TransNullToBool(objRow[convcc_WorkStuRelation.IsLook].ToString().Trim()); //是否查看
objvcc_WorkStuRelationEN.IsSave = TransNullToBool(objRow[convcc_WorkStuRelation.IsSave].ToString().Trim()); //是否保存
objvcc_WorkStuRelationEN.IsSubmit = TransNullToBool(objRow[convcc_WorkStuRelation.IsSubmit].ToString().Trim()); //是否提交
objvcc_WorkStuRelationEN.ApplySendBackDate = objRow[convcc_WorkStuRelation.ApplySendBackDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ApplySendBackDate].ToString().Trim(); //申请退回日期
objvcc_WorkStuRelationEN.IsApplySendBack = TransNullToBool(objRow[convcc_WorkStuRelation.IsApplySendBack].ToString().Trim()); //是否申请退回
objvcc_WorkStuRelationEN.RealFinishDate = objRow[convcc_WorkStuRelation.RealFinishDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.RealFinishDate].ToString().Trim(); //实际完成日期
objvcc_WorkStuRelationEN.OperateTime = objRow[convcc_WorkStuRelation.OperateTime] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.OperateTime].ToString().Trim(); //操作时间
objvcc_WorkStuRelationEN.Score = objRow[convcc_WorkStuRelation.Score] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convcc_WorkStuRelation.Score].ToString().Trim()); //得分
objvcc_WorkStuRelationEN.Comment = objRow[convcc_WorkStuRelation.Comment] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.Comment].ToString().Trim(); //批注
objvcc_WorkStuRelationEN.IsMarking = TransNullToBool(objRow[convcc_WorkStuRelation.IsMarking].ToString().Trim()); //是否批阅
objvcc_WorkStuRelationEN.MarkerId = objRow[convcc_WorkStuRelation.MarkerId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.MarkerId].ToString().Trim(); //打分者
objvcc_WorkStuRelationEN.MarkDate = objRow[convcc_WorkStuRelation.MarkDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.MarkDate].ToString().Trim(); //打分日期
objvcc_WorkStuRelationEN.IsSendBack = TransNullToBool(objRow[convcc_WorkStuRelation.IsSendBack].ToString().Trim()); //是否退回
objvcc_WorkStuRelationEN.IsInErrorQuestion = TransNullToBool(objRow[convcc_WorkStuRelation.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objvcc_WorkStuRelationEN.WorkTypeId = objRow[convcc_WorkStuRelation.WorkTypeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.WorkTypeId].ToString().Trim(); //作业类型Id
objvcc_WorkStuRelationEN.AnswerIP = objRow[convcc_WorkStuRelation.AnswerIP] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerIP].ToString().Trim(); //回答IP
objvcc_WorkStuRelationEN.AnswerDate = objRow[convcc_WorkStuRelation.AnswerDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerDate].ToString().Trim(); //回答日期
objvcc_WorkStuRelationEN.AnswerTime = objRow[convcc_WorkStuRelation.AnswerTime] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerTime].ToString().Trim(); //回答时间
objvcc_WorkStuRelationEN.CourseExamPaperId = objRow[convcc_WorkStuRelation.CourseExamPaperId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_WorkStuRelationEN.IsRight = TransNullToBool(objRow[convcc_WorkStuRelation.IsRight].ToString().Trim()); //是否正确
objvcc_WorkStuRelationEN.IsAccessKnowledge = TransNullToBool(objRow[convcc_WorkStuRelation.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objvcc_WorkStuRelationEN.IsNotProcessTimeout = TransNullToBool(objRow[convcc_WorkStuRelation.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objvcc_WorkStuRelationEN.SchoolYear = objRow[convcc_WorkStuRelation.SchoolYear] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.SchoolYear].ToString().Trim(); //学年
objvcc_WorkStuRelationEN.SchoolTerm = objRow[convcc_WorkStuRelation.SchoolTerm] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.SchoolTerm].ToString().Trim(); //学期
objvcc_WorkStuRelationEN.ErrMsg = objRow[convcc_WorkStuRelation.ErrMsg] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ErrMsg].ToString().Trim(); //错误信息
objvcc_WorkStuRelationEN.UpdDate = objRow[convcc_WorkStuRelation.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkStuRelationEN.UpdUserId = objRow[convcc_WorkStuRelation.UpdUserId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_WorkStuRelationEN.Memo = objRow[convcc_WorkStuRelation.Memo] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvcc_WorkStuRelationDA: GetObjLst)", objException.Message));
}
objvcc_WorkStuRelationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvcc_WorkStuRelationEN);
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
public List<clsvcc_WorkStuRelationEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvcc_WorkStuRelationDA:GetObjLstByTabName)", objException.Message));
}
List<clsvcc_WorkStuRelationEN> arrObjLst = new List<clsvcc_WorkStuRelationEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkStuRelationDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN = new clsvcc_WorkStuRelationEN();
try
{
objvcc_WorkStuRelationEN.IdWorkStuRelation = TransNullToInt(objRow[convcc_WorkStuRelation.IdWorkStuRelation].ToString().Trim()); //流水号
objvcc_WorkStuRelationEN.IdCurrEduCls = objRow[convcc_WorkStuRelation.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvcc_WorkStuRelationEN.IdWorkEduClsRela = objRow[convcc_WorkStuRelation.IdWorkEduClsRela] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convcc_WorkStuRelation.IdWorkEduClsRela].ToString().Trim()); //作业教学班关系流水号
objvcc_WorkStuRelationEN.QuestionId = objRow[convcc_WorkStuRelation.QuestionId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convcc_WorkStuRelation.QuestionId].ToString().Trim()); //题目Id
objvcc_WorkStuRelationEN.QuestionIndex = objRow[convcc_WorkStuRelation.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_WorkStuRelation.QuestionIndex].ToString().Trim()); //题目序号
objvcc_WorkStuRelationEN.QuestionName = objRow[convcc_WorkStuRelation.QuestionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionName].ToString().Trim(); //题目名称
objvcc_WorkStuRelationEN.QuestionContent = objRow[convcc_WorkStuRelation.QuestionContent] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionContent].ToString().Trim(); //题目内容
objvcc_WorkStuRelationEN.CourseId = objRow[convcc_WorkStuRelation.CourseId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseId].ToString().Trim(); //课程Id
objvcc_WorkStuRelationEN.CourseName = objRow[convcc_WorkStuRelation.CourseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseName].ToString().Trim(); //课程名称
objvcc_WorkStuRelationEN.CourseChapterId = objRow[convcc_WorkStuRelation.CourseChapterId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkStuRelationEN.CourseChapterName = objRow[convcc_WorkStuRelation.CourseChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkStuRelationEN.ChapterName = objRow[convcc_WorkStuRelation.ChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ChapterName].ToString().Trim(); //章名
objvcc_WorkStuRelationEN.SectionName = objRow[convcc_WorkStuRelation.SectionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.SectionName].ToString().Trim(); //节名
objvcc_WorkStuRelationEN.ChapterNameSim = objRow[convcc_WorkStuRelation.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkStuRelationEN.SectionNameSim = objRow[convcc_WorkStuRelation.SectionNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkStuRelationEN.ParentNodeId = objRow[convcc_WorkStuRelation.ParentNodeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_WorkStuRelationEN.CourseChapterReferred = objRow[convcc_WorkStuRelation.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkStuRelationEN.ParentNodeName = objRow[convcc_WorkStuRelation.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkStuRelationEN.ParentNodeReferred = objRow[convcc_WorkStuRelation.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkStuRelationEN.QuestionTypeId = objRow[convcc_WorkStuRelation.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_WorkStuRelationEN.QuestionTypeName = objRow[convcc_WorkStuRelation.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionTypeName].ToString().Trim(); //题目类型名
objvcc_WorkStuRelationEN.AnswerTypeId = objRow[convcc_WorkStuRelation.AnswerTypeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerTypeId].ToString().Trim(); //答案类型ID
objvcc_WorkStuRelationEN.DefaultValue = objRow[convcc_WorkStuRelation.DefaultValue] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.DefaultValue].ToString().Trim(); //缺省值
objvcc_WorkStuRelationEN.TextDirectId = objRow[convcc_WorkStuRelation.TextDirectId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.TextDirectId].ToString().Trim(); //文本方向ID
objvcc_WorkStuRelationEN.RelaEvent = objRow[convcc_WorkStuRelation.RelaEvent] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.RelaEvent].ToString().Trim(); //相关事件
objvcc_WorkStuRelationEN.CheckBoxLimitCount = objRow[convcc_WorkStuRelation.CheckBoxLimitCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_WorkStuRelation.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objvcc_WorkStuRelationEN.AnswerAttLimitSize = objRow[convcc_WorkStuRelation.AnswerAttLimitSize] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convcc_WorkStuRelation.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objvcc_WorkStuRelationEN.LimitedResourceType = objRow[convcc_WorkStuRelation.LimitedResourceType] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.LimitedResourceType].ToString().Trim(); //限制资源类型
objvcc_WorkStuRelationEN.QuestionTypeId4Course = objRow[convcc_WorkStuRelation.QuestionTypeId4Course] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvcc_WorkStuRelationEN.QuestionTypeName4Course = objRow[convcc_WorkStuRelation.QuestionTypeName4Course] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程
objvcc_WorkStuRelationEN.CurrEduClsId = objRow[convcc_WorkStuRelation.CurrEduClsId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CurrEduClsId].ToString().Trim(); //教学班Id
objvcc_WorkStuRelationEN.EduClsName = objRow[convcc_WorkStuRelation.EduClsName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.EduClsName].ToString().Trim(); //教学班名
objvcc_WorkStuRelationEN.TeacherId = objRow[convcc_WorkStuRelation.TeacherId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.TeacherId].ToString().Trim(); //教师工号
objvcc_WorkStuRelationEN.PubDate = objRow[convcc_WorkStuRelation.PubDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.PubDate].ToString().Trim(); //发布日期
objvcc_WorkStuRelationEN.IsCurrEduCls = TransNullToBool(objRow[convcc_WorkStuRelation.IsCurrEduCls].ToString().Trim()); //是否为教学班作业
objvcc_WorkStuRelationEN.IsGroupWork = TransNullToBool(objRow[convcc_WorkStuRelation.IsGroupWork].ToString().Trim()); //是否为小组作业
objvcc_WorkStuRelationEN.CourseStudentGroupId = objRow[convcc_WorkStuRelation.CourseStudentGroupId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convcc_WorkStuRelation.CourseStudentGroupId].ToString().Trim()); //学生分组表流水号
objvcc_WorkStuRelationEN.WorkTypeName = objRow[convcc_WorkStuRelation.WorkTypeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.WorkTypeName].ToString().Trim(); //作业类型名称
objvcc_WorkStuRelationEN.Scores = objRow[convcc_WorkStuRelation.Scores] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convcc_WorkStuRelation.Scores].ToString().Trim()); //分值
objvcc_WorkStuRelationEN.SpecifyCompletionDate = objRow[convcc_WorkStuRelation.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objvcc_WorkStuRelationEN.IdStudentInfo = objRow[convcc_WorkStuRelation.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_WorkStuRelationEN.StuId = objRow[convcc_WorkStuRelation.StuId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.StuId].ToString().Trim(); //学号
objvcc_WorkStuRelationEN.StuName = objRow[convcc_WorkStuRelation.StuName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.StuName].ToString().Trim(); //姓名
objvcc_WorkStuRelationEN.IdXzCollege = objRow[convcc_WorkStuRelation.IdXzCollege] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_WorkStuRelationEN.CollegeName = objRow[convcc_WorkStuRelation.CollegeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CollegeName].ToString().Trim(); //学院名称
objvcc_WorkStuRelationEN.CollegeNameA = objRow[convcc_WorkStuRelation.CollegeNameA] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_WorkStuRelationEN.IdXzMajor = objRow[convcc_WorkStuRelation.IdXzMajor] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_WorkStuRelationEN.MajorId = objRow[convcc_WorkStuRelation.MajorId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.MajorId].ToString().Trim(); //专业Id
objvcc_WorkStuRelationEN.MajorName = objRow[convcc_WorkStuRelation.MajorName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.MajorName].ToString().Trim(); //专业名称
objvcc_WorkStuRelationEN.IdGradeBase = objRow[convcc_WorkStuRelation.IdGradeBase] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.IdGradeBase].ToString().Trim(); //年级流水号
objvcc_WorkStuRelationEN.GradeBaseName = objRow[convcc_WorkStuRelation.GradeBaseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.GradeBaseName].ToString().Trim(); //年级名称
objvcc_WorkStuRelationEN.AdminClsName = objRow[convcc_WorkStuRelation.AdminClsName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AdminClsName].ToString().Trim(); //行政班名称
objvcc_WorkStuRelationEN.AdminClsId = objRow[convcc_WorkStuRelation.AdminClsId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AdminClsId].ToString().Trim(); //行政班代号
objvcc_WorkStuRelationEN.AnswerModeId = objRow[convcc_WorkStuRelation.AnswerModeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerModeId].ToString().Trim(); //答案模式Id
objvcc_WorkStuRelationEN.AnswerOptionId = objRow[convcc_WorkStuRelation.AnswerOptionId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerOptionId].ToString().Trim(); //回答选项Id
objvcc_WorkStuRelationEN.AnswerMultiOptions = objRow[convcc_WorkStuRelation.AnswerMultiOptions] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerMultiOptions].ToString().Trim(); //多选项答案
objvcc_WorkStuRelationEN.AnswerBoolResult = TransNullToBool(objRow[convcc_WorkStuRelation.AnswerBoolResult].ToString().Trim()); //答案布尔结果
objvcc_WorkStuRelationEN.StuAnswerText = objRow[convcc_WorkStuRelation.StuAnswerText] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.StuAnswerText].ToString().Trim(); //学生回答文本
objvcc_WorkStuRelationEN.IsPublish = TransNullToBool(objRow[convcc_WorkStuRelation.IsPublish].ToString().Trim()); //是否发布
objvcc_WorkStuRelationEN.IsLook = TransNullToBool(objRow[convcc_WorkStuRelation.IsLook].ToString().Trim()); //是否查看
objvcc_WorkStuRelationEN.IsSave = TransNullToBool(objRow[convcc_WorkStuRelation.IsSave].ToString().Trim()); //是否保存
objvcc_WorkStuRelationEN.IsSubmit = TransNullToBool(objRow[convcc_WorkStuRelation.IsSubmit].ToString().Trim()); //是否提交
objvcc_WorkStuRelationEN.ApplySendBackDate = objRow[convcc_WorkStuRelation.ApplySendBackDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ApplySendBackDate].ToString().Trim(); //申请退回日期
objvcc_WorkStuRelationEN.IsApplySendBack = TransNullToBool(objRow[convcc_WorkStuRelation.IsApplySendBack].ToString().Trim()); //是否申请退回
objvcc_WorkStuRelationEN.RealFinishDate = objRow[convcc_WorkStuRelation.RealFinishDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.RealFinishDate].ToString().Trim(); //实际完成日期
objvcc_WorkStuRelationEN.OperateTime = objRow[convcc_WorkStuRelation.OperateTime] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.OperateTime].ToString().Trim(); //操作时间
objvcc_WorkStuRelationEN.Score = objRow[convcc_WorkStuRelation.Score] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convcc_WorkStuRelation.Score].ToString().Trim()); //得分
objvcc_WorkStuRelationEN.Comment = objRow[convcc_WorkStuRelation.Comment] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.Comment].ToString().Trim(); //批注
objvcc_WorkStuRelationEN.IsMarking = TransNullToBool(objRow[convcc_WorkStuRelation.IsMarking].ToString().Trim()); //是否批阅
objvcc_WorkStuRelationEN.MarkerId = objRow[convcc_WorkStuRelation.MarkerId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.MarkerId].ToString().Trim(); //打分者
objvcc_WorkStuRelationEN.MarkDate = objRow[convcc_WorkStuRelation.MarkDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.MarkDate].ToString().Trim(); //打分日期
objvcc_WorkStuRelationEN.IsSendBack = TransNullToBool(objRow[convcc_WorkStuRelation.IsSendBack].ToString().Trim()); //是否退回
objvcc_WorkStuRelationEN.IsInErrorQuestion = TransNullToBool(objRow[convcc_WorkStuRelation.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objvcc_WorkStuRelationEN.WorkTypeId = objRow[convcc_WorkStuRelation.WorkTypeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.WorkTypeId].ToString().Trim(); //作业类型Id
objvcc_WorkStuRelationEN.AnswerIP = objRow[convcc_WorkStuRelation.AnswerIP] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerIP].ToString().Trim(); //回答IP
objvcc_WorkStuRelationEN.AnswerDate = objRow[convcc_WorkStuRelation.AnswerDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerDate].ToString().Trim(); //回答日期
objvcc_WorkStuRelationEN.AnswerTime = objRow[convcc_WorkStuRelation.AnswerTime] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerTime].ToString().Trim(); //回答时间
objvcc_WorkStuRelationEN.CourseExamPaperId = objRow[convcc_WorkStuRelation.CourseExamPaperId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_WorkStuRelationEN.IsRight = TransNullToBool(objRow[convcc_WorkStuRelation.IsRight].ToString().Trim()); //是否正确
objvcc_WorkStuRelationEN.IsAccessKnowledge = TransNullToBool(objRow[convcc_WorkStuRelation.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objvcc_WorkStuRelationEN.IsNotProcessTimeout = TransNullToBool(objRow[convcc_WorkStuRelation.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objvcc_WorkStuRelationEN.SchoolYear = objRow[convcc_WorkStuRelation.SchoolYear] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.SchoolYear].ToString().Trim(); //学年
objvcc_WorkStuRelationEN.SchoolTerm = objRow[convcc_WorkStuRelation.SchoolTerm] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.SchoolTerm].ToString().Trim(); //学期
objvcc_WorkStuRelationEN.ErrMsg = objRow[convcc_WorkStuRelation.ErrMsg] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ErrMsg].ToString().Trim(); //错误信息
objvcc_WorkStuRelationEN.UpdDate = objRow[convcc_WorkStuRelation.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkStuRelationEN.UpdUserId = objRow[convcc_WorkStuRelation.UpdUserId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_WorkStuRelationEN.Memo = objRow[convcc_WorkStuRelation.Memo] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvcc_WorkStuRelationDA: GetObjLst)", objException.Message));
}
objvcc_WorkStuRelationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvcc_WorkStuRelationEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getvcc_WorkStuRelation(ref clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkStuRelationDA.GetSpecSQLObj();
strSQL = "Select * from vcc_WorkStuRelation where IdWorkStuRelation = " + ""+ objvcc_WorkStuRelationEN.IdWorkStuRelation+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvcc_WorkStuRelationEN.IdWorkStuRelation = TransNullToInt(objDT.Rows[0][convcc_WorkStuRelation.IdWorkStuRelation].ToString().Trim()); //流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvcc_WorkStuRelationEN.IdCurrEduCls = objDT.Rows[0][convcc_WorkStuRelation.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvcc_WorkStuRelationEN.IdWorkEduClsRela = TransNullToInt(objDT.Rows[0][convcc_WorkStuRelation.IdWorkEduClsRela].ToString().Trim()); //作业教学班关系流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvcc_WorkStuRelationEN.QuestionId = TransNullToInt(objDT.Rows[0][convcc_WorkStuRelation.QuestionId].ToString().Trim()); //题目Id(字段类型:bigint,字段长度:8,是否可空:True)
 objvcc_WorkStuRelationEN.QuestionIndex = TransNullToInt(objDT.Rows[0][convcc_WorkStuRelation.QuestionIndex].ToString().Trim()); //题目序号(字段类型:int,字段长度:4,是否可空:True)
 objvcc_WorkStuRelationEN.QuestionName = objDT.Rows[0][convcc_WorkStuRelation.QuestionName].ToString().Trim(); //题目名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvcc_WorkStuRelationEN.QuestionContent = objDT.Rows[0][convcc_WorkStuRelation.QuestionContent].ToString().Trim(); //题目内容(字段类型:varchar,字段长度:4000,是否可空:True)
 objvcc_WorkStuRelationEN.CourseId = objDT.Rows[0][convcc_WorkStuRelation.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvcc_WorkStuRelationEN.CourseName = objDT.Rows[0][convcc_WorkStuRelation.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_WorkStuRelationEN.CourseChapterId = objDT.Rows[0][convcc_WorkStuRelation.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objvcc_WorkStuRelationEN.CourseChapterName = objDT.Rows[0][convcc_WorkStuRelation.CourseChapterName].ToString().Trim(); //课程章节名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvcc_WorkStuRelationEN.ChapterName = objDT.Rows[0][convcc_WorkStuRelation.ChapterName].ToString().Trim(); //章名(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_WorkStuRelationEN.SectionName = objDT.Rows[0][convcc_WorkStuRelation.SectionName].ToString().Trim(); //节名(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_WorkStuRelationEN.ChapterNameSim = objDT.Rows[0][convcc_WorkStuRelation.ChapterNameSim].ToString().Trim(); //章名简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_WorkStuRelationEN.SectionNameSim = objDT.Rows[0][convcc_WorkStuRelation.SectionNameSim].ToString().Trim(); //节名简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_WorkStuRelationEN.ParentNodeId = objDT.Rows[0][convcc_WorkStuRelation.ParentNodeId].ToString().Trim(); //父节点编号(字段类型:varchar,字段长度:8,是否可空:True)
 objvcc_WorkStuRelationEN.CourseChapterReferred = objDT.Rows[0][convcc_WorkStuRelation.CourseChapterReferred].ToString().Trim(); //节简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_WorkStuRelationEN.ParentNodeName = objDT.Rows[0][convcc_WorkStuRelation.ParentNodeName].ToString().Trim(); //父节点名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_WorkStuRelationEN.ParentNodeReferred = objDT.Rows[0][convcc_WorkStuRelation.ParentNodeReferred].ToString().Trim(); //章简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_WorkStuRelationEN.QuestionTypeId = objDT.Rows[0][convcc_WorkStuRelation.QuestionTypeId].ToString().Trim(); //题目类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvcc_WorkStuRelationEN.QuestionTypeName = objDT.Rows[0][convcc_WorkStuRelation.QuestionTypeName].ToString().Trim(); //题目类型名(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_WorkStuRelationEN.AnswerTypeId = objDT.Rows[0][convcc_WorkStuRelation.AnswerTypeId].ToString().Trim(); //答案类型ID(字段类型:char,字段长度:2,是否可空:True)
 objvcc_WorkStuRelationEN.DefaultValue = objDT.Rows[0][convcc_WorkStuRelation.DefaultValue].ToString().Trim(); //缺省值(字段类型:varchar,字段长度:50,是否可空:True)
 objvcc_WorkStuRelationEN.TextDirectId = objDT.Rows[0][convcc_WorkStuRelation.TextDirectId].ToString().Trim(); //文本方向ID(字段类型:char,字段长度:4,是否可空:True)
 objvcc_WorkStuRelationEN.RelaEvent = objDT.Rows[0][convcc_WorkStuRelation.RelaEvent].ToString().Trim(); //相关事件(字段类型:varchar,字段长度:4000,是否可空:True)
 objvcc_WorkStuRelationEN.CheckBoxLimitCount = TransNullToInt(objDT.Rows[0][convcc_WorkStuRelation.CheckBoxLimitCount].ToString().Trim()); //复选框限制数(字段类型:int,字段长度:4,是否可空:True)
 objvcc_WorkStuRelationEN.AnswerAttLimitSize = TransNullToInt(objDT.Rows[0][convcc_WorkStuRelation.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小(字段类型:bigint,字段长度:8,是否可空:True)
 objvcc_WorkStuRelationEN.LimitedResourceType = objDT.Rows[0][convcc_WorkStuRelation.LimitedResourceType].ToString().Trim(); //限制资源类型(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_WorkStuRelationEN.QuestionTypeId4Course = objDT.Rows[0][convcc_WorkStuRelation.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程(字段类型:char,字段长度:8,是否可空:False)
 objvcc_WorkStuRelationEN.QuestionTypeName4Course = objDT.Rows[0][convcc_WorkStuRelation.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程(字段类型:varchar,字段长度:30,是否可空:False)
 objvcc_WorkStuRelationEN.CurrEduClsId = objDT.Rows[0][convcc_WorkStuRelation.CurrEduClsId].ToString().Trim(); //教学班Id(字段类型:varchar,字段长度:15,是否可空:True)
 objvcc_WorkStuRelationEN.EduClsName = objDT.Rows[0][convcc_WorkStuRelation.EduClsName].ToString().Trim(); //教学班名(字段类型:varchar,字段长度:100,是否可空:False)
 objvcc_WorkStuRelationEN.TeacherId = objDT.Rows[0][convcc_WorkStuRelation.TeacherId].ToString().Trim(); //教师工号(字段类型:varchar,字段长度:12,是否可空:False)
 objvcc_WorkStuRelationEN.PubDate = objDT.Rows[0][convcc_WorkStuRelation.PubDate].ToString().Trim(); //发布日期(字段类型:varchar,字段长度:14,是否可空:False)
 objvcc_WorkStuRelationEN.IsCurrEduCls = TransNullToBool(objDT.Rows[0][convcc_WorkStuRelation.IsCurrEduCls].ToString().Trim()); //是否为教学班作业(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_WorkStuRelationEN.IsGroupWork = TransNullToBool(objDT.Rows[0][convcc_WorkStuRelation.IsGroupWork].ToString().Trim()); //是否为小组作业(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_WorkStuRelationEN.CourseStudentGroupId = TransNullToInt(objDT.Rows[0][convcc_WorkStuRelation.CourseStudentGroupId].ToString().Trim()); //学生分组表流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvcc_WorkStuRelationEN.WorkTypeName = objDT.Rows[0][convcc_WorkStuRelation.WorkTypeName].ToString().Trim(); //作业类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvcc_WorkStuRelationEN.Scores = TransNullToDouble(objDT.Rows[0][convcc_WorkStuRelation.Scores].ToString().Trim()); //分值(字段类型:decimal,字段长度:8,是否可空:True)
 objvcc_WorkStuRelationEN.SpecifyCompletionDate = objDT.Rows[0][convcc_WorkStuRelation.SpecifyCompletionDate].ToString().Trim(); //指定完成日期(字段类型:varchar,字段长度:14,是否可空:False)
 objvcc_WorkStuRelationEN.IdStudentInfo = objDT.Rows[0][convcc_WorkStuRelation.IdStudentInfo].ToString().Trim(); //学生流水号(字段类型:char,字段长度:8,是否可空:False)
 objvcc_WorkStuRelationEN.StuId = objDT.Rows[0][convcc_WorkStuRelation.StuId].ToString().Trim(); //学号(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_WorkStuRelationEN.StuName = objDT.Rows[0][convcc_WorkStuRelation.StuName].ToString().Trim(); //姓名(字段类型:varchar,字段长度:50,是否可空:True)
 objvcc_WorkStuRelationEN.IdXzCollege = objDT.Rows[0][convcc_WorkStuRelation.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvcc_WorkStuRelationEN.CollegeName = objDT.Rows[0][convcc_WorkStuRelation.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvcc_WorkStuRelationEN.CollegeNameA = objDT.Rows[0][convcc_WorkStuRelation.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvcc_WorkStuRelationEN.IdXzMajor = objDT.Rows[0][convcc_WorkStuRelation.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvcc_WorkStuRelationEN.MajorId = objDT.Rows[0][convcc_WorkStuRelation.MajorId].ToString().Trim(); //专业Id(字段类型:char,字段长度:4,是否可空:False)
 objvcc_WorkStuRelationEN.MajorName = objDT.Rows[0][convcc_WorkStuRelation.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvcc_WorkStuRelationEN.IdGradeBase = objDT.Rows[0][convcc_WorkStuRelation.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objvcc_WorkStuRelationEN.GradeBaseName = objDT.Rows[0][convcc_WorkStuRelation.GradeBaseName].ToString().Trim(); //年级名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvcc_WorkStuRelationEN.AdminClsName = objDT.Rows[0][convcc_WorkStuRelation.AdminClsName].ToString().Trim(); //行政班名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_WorkStuRelationEN.AdminClsId = objDT.Rows[0][convcc_WorkStuRelation.AdminClsId].ToString().Trim(); //行政班代号(字段类型:varchar,字段长度:8,是否可空:True)
 objvcc_WorkStuRelationEN.AnswerModeId = objDT.Rows[0][convcc_WorkStuRelation.AnswerModeId].ToString().Trim(); //答案模式Id(字段类型:char,字段长度:4,是否可空:True)
 objvcc_WorkStuRelationEN.AnswerOptionId = objDT.Rows[0][convcc_WorkStuRelation.AnswerOptionId].ToString().Trim(); //回答选项Id(字段类型:char,字段长度:8,是否可空:True)
 objvcc_WorkStuRelationEN.AnswerMultiOptions = objDT.Rows[0][convcc_WorkStuRelation.AnswerMultiOptions].ToString().Trim(); //多选项答案(字段类型:varchar,字段长度:300,是否可空:True)
 objvcc_WorkStuRelationEN.AnswerBoolResult = TransNullToBool(objDT.Rows[0][convcc_WorkStuRelation.AnswerBoolResult].ToString().Trim()); //答案布尔结果(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_WorkStuRelationEN.StuAnswerText = objDT.Rows[0][convcc_WorkStuRelation.StuAnswerText].ToString().Trim(); //学生回答文本(字段类型:text,字段长度:2147483647,是否可空:True)
 objvcc_WorkStuRelationEN.IsPublish = TransNullToBool(objDT.Rows[0][convcc_WorkStuRelation.IsPublish].ToString().Trim()); //是否发布(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_WorkStuRelationEN.IsLook = TransNullToBool(objDT.Rows[0][convcc_WorkStuRelation.IsLook].ToString().Trim()); //是否查看(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_WorkStuRelationEN.IsSave = TransNullToBool(objDT.Rows[0][convcc_WorkStuRelation.IsSave].ToString().Trim()); //是否保存(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_WorkStuRelationEN.IsSubmit = TransNullToBool(objDT.Rows[0][convcc_WorkStuRelation.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_WorkStuRelationEN.ApplySendBackDate = objDT.Rows[0][convcc_WorkStuRelation.ApplySendBackDate].ToString().Trim(); //申请退回日期(字段类型:varchar,字段长度:14,是否可空:True)
 objvcc_WorkStuRelationEN.IsApplySendBack = TransNullToBool(objDT.Rows[0][convcc_WorkStuRelation.IsApplySendBack].ToString().Trim()); //是否申请退回(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_WorkStuRelationEN.RealFinishDate = objDT.Rows[0][convcc_WorkStuRelation.RealFinishDate].ToString().Trim(); //实际完成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objvcc_WorkStuRelationEN.OperateTime = objDT.Rows[0][convcc_WorkStuRelation.OperateTime].ToString().Trim(); //操作时间(字段类型:varchar,字段长度:14,是否可空:True)
 objvcc_WorkStuRelationEN.Score = TransNullToDouble(objDT.Rows[0][convcc_WorkStuRelation.Score].ToString().Trim()); //得分(字段类型:decimal,字段长度:6,是否可空:True)
 objvcc_WorkStuRelationEN.Comment = objDT.Rows[0][convcc_WorkStuRelation.Comment].ToString().Trim(); //批注(字段类型:text,字段长度:2147483647,是否可空:True)
 objvcc_WorkStuRelationEN.IsMarking = TransNullToBool(objDT.Rows[0][convcc_WorkStuRelation.IsMarking].ToString().Trim()); //是否批阅(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_WorkStuRelationEN.MarkerId = objDT.Rows[0][convcc_WorkStuRelation.MarkerId].ToString().Trim(); //打分者(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_WorkStuRelationEN.MarkDate = objDT.Rows[0][convcc_WorkStuRelation.MarkDate].ToString().Trim(); //打分日期(字段类型:varchar,字段长度:14,是否可空:True)
 objvcc_WorkStuRelationEN.IsSendBack = TransNullToBool(objDT.Rows[0][convcc_WorkStuRelation.IsSendBack].ToString().Trim()); //是否退回(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_WorkStuRelationEN.IsInErrorQuestion = TransNullToBool(objDT.Rows[0][convcc_WorkStuRelation.IsInErrorQuestion].ToString().Trim()); //是否进入错题(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_WorkStuRelationEN.WorkTypeId = objDT.Rows[0][convcc_WorkStuRelation.WorkTypeId].ToString().Trim(); //作业类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvcc_WorkStuRelationEN.AnswerIP = objDT.Rows[0][convcc_WorkStuRelation.AnswerIP].ToString().Trim(); //回答IP(字段类型:varchar,字段长度:30,是否可空:True)
 objvcc_WorkStuRelationEN.AnswerDate = objDT.Rows[0][convcc_WorkStuRelation.AnswerDate].ToString().Trim(); //回答日期(字段类型:varchar,字段长度:8,是否可空:True)
 objvcc_WorkStuRelationEN.AnswerTime = objDT.Rows[0][convcc_WorkStuRelation.AnswerTime].ToString().Trim(); //回答时间(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_WorkStuRelationEN.CourseExamPaperId = objDT.Rows[0][convcc_WorkStuRelation.CourseExamPaperId].ToString().Trim(); //考卷流水号(字段类型:char,字段长度:8,是否可空:True)
 objvcc_WorkStuRelationEN.IsRight = TransNullToBool(objDT.Rows[0][convcc_WorkStuRelation.IsRight].ToString().Trim()); //是否正确(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_WorkStuRelationEN.IsAccessKnowledge = TransNullToBool(objDT.Rows[0][convcc_WorkStuRelation.IsAccessKnowledge].ToString().Trim()); //是否处理知识点(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_WorkStuRelationEN.IsNotProcessTimeout = TransNullToBool(objDT.Rows[0][convcc_WorkStuRelation.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_WorkStuRelationEN.SchoolYear = objDT.Rows[0][convcc_WorkStuRelation.SchoolYear].ToString().Trim(); //学年(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_WorkStuRelationEN.SchoolTerm = objDT.Rows[0][convcc_WorkStuRelation.SchoolTerm].ToString().Trim(); //学期(字段类型:char,字段长度:1,是否可空:True)
 objvcc_WorkStuRelationEN.ErrMsg = objDT.Rows[0][convcc_WorkStuRelation.ErrMsg].ToString().Trim(); //错误信息(字段类型:varchar,字段长度:200,是否可空:True)
 objvcc_WorkStuRelationEN.UpdDate = objDT.Rows[0][convcc_WorkStuRelation.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_WorkStuRelationEN.UpdUserId = objDT.Rows[0][convcc_WorkStuRelation.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_WorkStuRelationEN.Memo = objDT.Rows[0][convcc_WorkStuRelation.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvcc_WorkStuRelationDA: Getvcc_WorkStuRelation)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdWorkStuRelation">表关键字</param>
 /// <returns>表对象</returns>
public clsvcc_WorkStuRelationEN GetObjByIdWorkStuRelation(long lngIdWorkStuRelation)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkStuRelationDA.GetSpecSQLObj();
strSQL = "Select * from vcc_WorkStuRelation where IdWorkStuRelation = " + ""+ lngIdWorkStuRelation+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN = new clsvcc_WorkStuRelationEN();
try
{
 objvcc_WorkStuRelationEN.IdWorkStuRelation = Int32.Parse(objRow[convcc_WorkStuRelation.IdWorkStuRelation].ToString().Trim()); //流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvcc_WorkStuRelationEN.IdCurrEduCls = objRow[convcc_WorkStuRelation.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvcc_WorkStuRelationEN.IdWorkEduClsRela = objRow[convcc_WorkStuRelation.IdWorkEduClsRela] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation.IdWorkEduClsRela].ToString().Trim()); //作业教学班关系流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvcc_WorkStuRelationEN.QuestionId = objRow[convcc_WorkStuRelation.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation.QuestionId].ToString().Trim()); //题目Id(字段类型:bigint,字段长度:8,是否可空:True)
 objvcc_WorkStuRelationEN.QuestionIndex = objRow[convcc_WorkStuRelation.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation.QuestionIndex].ToString().Trim()); //题目序号(字段类型:int,字段长度:4,是否可空:True)
 objvcc_WorkStuRelationEN.QuestionName = objRow[convcc_WorkStuRelation.QuestionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionName].ToString().Trim(); //题目名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvcc_WorkStuRelationEN.QuestionContent = objRow[convcc_WorkStuRelation.QuestionContent] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionContent].ToString().Trim(); //题目内容(字段类型:varchar,字段长度:4000,是否可空:True)
 objvcc_WorkStuRelationEN.CourseId = objRow[convcc_WorkStuRelation.CourseId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvcc_WorkStuRelationEN.CourseName = objRow[convcc_WorkStuRelation.CourseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_WorkStuRelationEN.CourseChapterId = objRow[convcc_WorkStuRelation.CourseChapterId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objvcc_WorkStuRelationEN.CourseChapterName = objRow[convcc_WorkStuRelation.CourseChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseChapterName].ToString().Trim(); //课程章节名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvcc_WorkStuRelationEN.ChapterName = objRow[convcc_WorkStuRelation.ChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ChapterName].ToString().Trim(); //章名(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_WorkStuRelationEN.SectionName = objRow[convcc_WorkStuRelation.SectionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.SectionName].ToString().Trim(); //节名(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_WorkStuRelationEN.ChapterNameSim = objRow[convcc_WorkStuRelation.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ChapterNameSim].ToString().Trim(); //章名简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_WorkStuRelationEN.SectionNameSim = objRow[convcc_WorkStuRelation.SectionNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.SectionNameSim].ToString().Trim(); //节名简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_WorkStuRelationEN.ParentNodeId = objRow[convcc_WorkStuRelation.ParentNodeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ParentNodeId].ToString().Trim(); //父节点编号(字段类型:varchar,字段长度:8,是否可空:True)
 objvcc_WorkStuRelationEN.CourseChapterReferred = objRow[convcc_WorkStuRelation.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseChapterReferred].ToString().Trim(); //节简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_WorkStuRelationEN.ParentNodeName = objRow[convcc_WorkStuRelation.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ParentNodeName].ToString().Trim(); //父节点名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_WorkStuRelationEN.ParentNodeReferred = objRow[convcc_WorkStuRelation.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ParentNodeReferred].ToString().Trim(); //章简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_WorkStuRelationEN.QuestionTypeId = objRow[convcc_WorkStuRelation.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionTypeId].ToString().Trim(); //题目类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvcc_WorkStuRelationEN.QuestionTypeName = objRow[convcc_WorkStuRelation.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionTypeName].ToString().Trim(); //题目类型名(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_WorkStuRelationEN.AnswerTypeId = objRow[convcc_WorkStuRelation.AnswerTypeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerTypeId].ToString().Trim(); //答案类型ID(字段类型:char,字段长度:2,是否可空:True)
 objvcc_WorkStuRelationEN.DefaultValue = objRow[convcc_WorkStuRelation.DefaultValue] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.DefaultValue].ToString().Trim(); //缺省值(字段类型:varchar,字段长度:50,是否可空:True)
 objvcc_WorkStuRelationEN.TextDirectId = objRow[convcc_WorkStuRelation.TextDirectId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.TextDirectId].ToString().Trim(); //文本方向ID(字段类型:char,字段长度:4,是否可空:True)
 objvcc_WorkStuRelationEN.RelaEvent = objRow[convcc_WorkStuRelation.RelaEvent] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.RelaEvent].ToString().Trim(); //相关事件(字段类型:varchar,字段长度:4000,是否可空:True)
 objvcc_WorkStuRelationEN.CheckBoxLimitCount = objRow[convcc_WorkStuRelation.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation.CheckBoxLimitCount].ToString().Trim()); //复选框限制数(字段类型:int,字段长度:4,是否可空:True)
 objvcc_WorkStuRelationEN.AnswerAttLimitSize = objRow[convcc_WorkStuRelation.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小(字段类型:bigint,字段长度:8,是否可空:True)
 objvcc_WorkStuRelationEN.LimitedResourceType = objRow[convcc_WorkStuRelation.LimitedResourceType] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.LimitedResourceType].ToString().Trim(); //限制资源类型(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_WorkStuRelationEN.QuestionTypeId4Course = objRow[convcc_WorkStuRelation.QuestionTypeId4Course] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程(字段类型:char,字段长度:8,是否可空:False)
 objvcc_WorkStuRelationEN.QuestionTypeName4Course = objRow[convcc_WorkStuRelation.QuestionTypeName4Course] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程(字段类型:varchar,字段长度:30,是否可空:False)
 objvcc_WorkStuRelationEN.CurrEduClsId = objRow[convcc_WorkStuRelation.CurrEduClsId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CurrEduClsId].ToString().Trim(); //教学班Id(字段类型:varchar,字段长度:15,是否可空:True)
 objvcc_WorkStuRelationEN.EduClsName = objRow[convcc_WorkStuRelation.EduClsName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.EduClsName].ToString().Trim(); //教学班名(字段类型:varchar,字段长度:100,是否可空:False)
 objvcc_WorkStuRelationEN.TeacherId = objRow[convcc_WorkStuRelation.TeacherId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.TeacherId].ToString().Trim(); //教师工号(字段类型:varchar,字段长度:12,是否可空:False)
 objvcc_WorkStuRelationEN.PubDate = objRow[convcc_WorkStuRelation.PubDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.PubDate].ToString().Trim(); //发布日期(字段类型:varchar,字段长度:14,是否可空:False)
 objvcc_WorkStuRelationEN.IsCurrEduCls = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsCurrEduCls].ToString().Trim()); //是否为教学班作业(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_WorkStuRelationEN.IsGroupWork = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsGroupWork].ToString().Trim()); //是否为小组作业(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_WorkStuRelationEN.CourseStudentGroupId = objRow[convcc_WorkStuRelation.CourseStudentGroupId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation.CourseStudentGroupId].ToString().Trim()); //学生分组表流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvcc_WorkStuRelationEN.WorkTypeName = objRow[convcc_WorkStuRelation.WorkTypeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.WorkTypeName].ToString().Trim(); //作业类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvcc_WorkStuRelationEN.Scores = objRow[convcc_WorkStuRelation.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_WorkStuRelation.Scores].ToString().Trim()); //分值(字段类型:decimal,字段长度:8,是否可空:True)
 objvcc_WorkStuRelationEN.SpecifyCompletionDate = objRow[convcc_WorkStuRelation.SpecifyCompletionDate].ToString().Trim(); //指定完成日期(字段类型:varchar,字段长度:14,是否可空:False)
 objvcc_WorkStuRelationEN.IdStudentInfo = objRow[convcc_WorkStuRelation.IdStudentInfo].ToString().Trim(); //学生流水号(字段类型:char,字段长度:8,是否可空:False)
 objvcc_WorkStuRelationEN.StuId = objRow[convcc_WorkStuRelation.StuId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.StuId].ToString().Trim(); //学号(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_WorkStuRelationEN.StuName = objRow[convcc_WorkStuRelation.StuName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.StuName].ToString().Trim(); //姓名(字段类型:varchar,字段长度:50,是否可空:True)
 objvcc_WorkStuRelationEN.IdXzCollege = objRow[convcc_WorkStuRelation.IdXzCollege] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvcc_WorkStuRelationEN.CollegeName = objRow[convcc_WorkStuRelation.CollegeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvcc_WorkStuRelationEN.CollegeNameA = objRow[convcc_WorkStuRelation.CollegeNameA] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvcc_WorkStuRelationEN.IdXzMajor = objRow[convcc_WorkStuRelation.IdXzMajor] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvcc_WorkStuRelationEN.MajorId = objRow[convcc_WorkStuRelation.MajorId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.MajorId].ToString().Trim(); //专业Id(字段类型:char,字段长度:4,是否可空:False)
 objvcc_WorkStuRelationEN.MajorName = objRow[convcc_WorkStuRelation.MajorName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvcc_WorkStuRelationEN.IdGradeBase = objRow[convcc_WorkStuRelation.IdGradeBase] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objvcc_WorkStuRelationEN.GradeBaseName = objRow[convcc_WorkStuRelation.GradeBaseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.GradeBaseName].ToString().Trim(); //年级名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvcc_WorkStuRelationEN.AdminClsName = objRow[convcc_WorkStuRelation.AdminClsName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AdminClsName].ToString().Trim(); //行政班名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_WorkStuRelationEN.AdminClsId = objRow[convcc_WorkStuRelation.AdminClsId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AdminClsId].ToString().Trim(); //行政班代号(字段类型:varchar,字段长度:8,是否可空:True)
 objvcc_WorkStuRelationEN.AnswerModeId = objRow[convcc_WorkStuRelation.AnswerModeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerModeId].ToString().Trim(); //答案模式Id(字段类型:char,字段长度:4,是否可空:True)
 objvcc_WorkStuRelationEN.AnswerOptionId = objRow[convcc_WorkStuRelation.AnswerOptionId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerOptionId].ToString().Trim(); //回答选项Id(字段类型:char,字段长度:8,是否可空:True)
 objvcc_WorkStuRelationEN.AnswerMultiOptions = objRow[convcc_WorkStuRelation.AnswerMultiOptions] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerMultiOptions].ToString().Trim(); //多选项答案(字段类型:varchar,字段长度:300,是否可空:True)
 objvcc_WorkStuRelationEN.AnswerBoolResult = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.AnswerBoolResult].ToString().Trim()); //答案布尔结果(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_WorkStuRelationEN.StuAnswerText = objRow[convcc_WorkStuRelation.StuAnswerText] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.StuAnswerText].ToString().Trim(); //学生回答文本(字段类型:text,字段长度:2147483647,是否可空:True)
 objvcc_WorkStuRelationEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsPublish].ToString().Trim()); //是否发布(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_WorkStuRelationEN.IsLook = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsLook].ToString().Trim()); //是否查看(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_WorkStuRelationEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsSave].ToString().Trim()); //是否保存(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_WorkStuRelationEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_WorkStuRelationEN.ApplySendBackDate = objRow[convcc_WorkStuRelation.ApplySendBackDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ApplySendBackDate].ToString().Trim(); //申请退回日期(字段类型:varchar,字段长度:14,是否可空:True)
 objvcc_WorkStuRelationEN.IsApplySendBack = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsApplySendBack].ToString().Trim()); //是否申请退回(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_WorkStuRelationEN.RealFinishDate = objRow[convcc_WorkStuRelation.RealFinishDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.RealFinishDate].ToString().Trim(); //实际完成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objvcc_WorkStuRelationEN.OperateTime = objRow[convcc_WorkStuRelation.OperateTime] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.OperateTime].ToString().Trim(); //操作时间(字段类型:varchar,字段长度:14,是否可空:True)
 objvcc_WorkStuRelationEN.Score = objRow[convcc_WorkStuRelation.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_WorkStuRelation.Score].ToString().Trim()); //得分(字段类型:decimal,字段长度:6,是否可空:True)
 objvcc_WorkStuRelationEN.Comment = objRow[convcc_WorkStuRelation.Comment] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.Comment].ToString().Trim(); //批注(字段类型:text,字段长度:2147483647,是否可空:True)
 objvcc_WorkStuRelationEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsMarking].ToString().Trim()); //是否批阅(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_WorkStuRelationEN.MarkerId = objRow[convcc_WorkStuRelation.MarkerId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.MarkerId].ToString().Trim(); //打分者(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_WorkStuRelationEN.MarkDate = objRow[convcc_WorkStuRelation.MarkDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.MarkDate].ToString().Trim(); //打分日期(字段类型:varchar,字段长度:14,是否可空:True)
 objvcc_WorkStuRelationEN.IsSendBack = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsSendBack].ToString().Trim()); //是否退回(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_WorkStuRelationEN.IsInErrorQuestion = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsInErrorQuestion].ToString().Trim()); //是否进入错题(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_WorkStuRelationEN.WorkTypeId = objRow[convcc_WorkStuRelation.WorkTypeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.WorkTypeId].ToString().Trim(); //作业类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvcc_WorkStuRelationEN.AnswerIP = objRow[convcc_WorkStuRelation.AnswerIP] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerIP].ToString().Trim(); //回答IP(字段类型:varchar,字段长度:30,是否可空:True)
 objvcc_WorkStuRelationEN.AnswerDate = objRow[convcc_WorkStuRelation.AnswerDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerDate].ToString().Trim(); //回答日期(字段类型:varchar,字段长度:8,是否可空:True)
 objvcc_WorkStuRelationEN.AnswerTime = objRow[convcc_WorkStuRelation.AnswerTime] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerTime].ToString().Trim(); //回答时间(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_WorkStuRelationEN.CourseExamPaperId = objRow[convcc_WorkStuRelation.CourseExamPaperId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseExamPaperId].ToString().Trim(); //考卷流水号(字段类型:char,字段长度:8,是否可空:True)
 objvcc_WorkStuRelationEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsRight].ToString().Trim()); //是否正确(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_WorkStuRelationEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsAccessKnowledge].ToString().Trim()); //是否处理知识点(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_WorkStuRelationEN.IsNotProcessTimeout = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_WorkStuRelationEN.SchoolYear = objRow[convcc_WorkStuRelation.SchoolYear] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.SchoolYear].ToString().Trim(); //学年(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_WorkStuRelationEN.SchoolTerm = objRow[convcc_WorkStuRelation.SchoolTerm] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.SchoolTerm].ToString().Trim(); //学期(字段类型:char,字段长度:1,是否可空:True)
 objvcc_WorkStuRelationEN.ErrMsg = objRow[convcc_WorkStuRelation.ErrMsg] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ErrMsg].ToString().Trim(); //错误信息(字段类型:varchar,字段长度:200,是否可空:True)
 objvcc_WorkStuRelationEN.UpdDate = objRow[convcc_WorkStuRelation.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_WorkStuRelationEN.UpdUserId = objRow[convcc_WorkStuRelation.UpdUserId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_WorkStuRelationEN.Memo = objRow[convcc_WorkStuRelation.Memo] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvcc_WorkStuRelationDA: GetObjByIdWorkStuRelation)", objException.Message));
}
return objvcc_WorkStuRelationEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvcc_WorkStuRelationEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvcc_WorkStuRelationDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkStuRelationDA.GetSpecSQLObj();
strSQL = "Select * from vcc_WorkStuRelation where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN = new clsvcc_WorkStuRelationEN()
{
IdWorkStuRelation = TransNullToInt(objRow[convcc_WorkStuRelation.IdWorkStuRelation].ToString().Trim()), //流水号
IdCurrEduCls = objRow[convcc_WorkStuRelation.IdCurrEduCls].ToString().Trim(), //教学班流水号
IdWorkEduClsRela = objRow[convcc_WorkStuRelation.IdWorkEduClsRela] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convcc_WorkStuRelation.IdWorkEduClsRela].ToString().Trim()), //作业教学班关系流水号
QuestionId = objRow[convcc_WorkStuRelation.QuestionId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convcc_WorkStuRelation.QuestionId].ToString().Trim()), //题目Id
QuestionIndex = objRow[convcc_WorkStuRelation.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_WorkStuRelation.QuestionIndex].ToString().Trim()), //题目序号
QuestionName = objRow[convcc_WorkStuRelation.QuestionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionName].ToString().Trim(), //题目名称
QuestionContent = objRow[convcc_WorkStuRelation.QuestionContent] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionContent].ToString().Trim(), //题目内容
CourseId = objRow[convcc_WorkStuRelation.CourseId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseId].ToString().Trim(), //课程Id
CourseName = objRow[convcc_WorkStuRelation.CourseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseName].ToString().Trim(), //课程名称
CourseChapterId = objRow[convcc_WorkStuRelation.CourseChapterId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseChapterId].ToString().Trim(), //课程章节ID
CourseChapterName = objRow[convcc_WorkStuRelation.CourseChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseChapterName].ToString().Trim(), //课程章节名称
ChapterName = objRow[convcc_WorkStuRelation.ChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ChapterName].ToString().Trim(), //章名
SectionName = objRow[convcc_WorkStuRelation.SectionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.SectionName].ToString().Trim(), //节名
ChapterNameSim = objRow[convcc_WorkStuRelation.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ChapterNameSim].ToString().Trim(), //章名简称
SectionNameSim = objRow[convcc_WorkStuRelation.SectionNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.SectionNameSim].ToString().Trim(), //节名简称
ParentNodeId = objRow[convcc_WorkStuRelation.ParentNodeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ParentNodeId].ToString().Trim(), //父节点编号
CourseChapterReferred = objRow[convcc_WorkStuRelation.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseChapterReferred].ToString().Trim(), //节简称
ParentNodeName = objRow[convcc_WorkStuRelation.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ParentNodeName].ToString().Trim(), //父节点名称
ParentNodeReferred = objRow[convcc_WorkStuRelation.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ParentNodeReferred].ToString().Trim(), //章简称
QuestionTypeId = objRow[convcc_WorkStuRelation.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionTypeId].ToString().Trim(), //题目类型Id
QuestionTypeName = objRow[convcc_WorkStuRelation.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionTypeName].ToString().Trim(), //题目类型名
AnswerTypeId = objRow[convcc_WorkStuRelation.AnswerTypeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerTypeId].ToString().Trim(), //答案类型ID
DefaultValue = objRow[convcc_WorkStuRelation.DefaultValue] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.DefaultValue].ToString().Trim(), //缺省值
TextDirectId = objRow[convcc_WorkStuRelation.TextDirectId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.TextDirectId].ToString().Trim(), //文本方向ID
RelaEvent = objRow[convcc_WorkStuRelation.RelaEvent] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.RelaEvent].ToString().Trim(), //相关事件
CheckBoxLimitCount = objRow[convcc_WorkStuRelation.CheckBoxLimitCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_WorkStuRelation.CheckBoxLimitCount].ToString().Trim()), //复选框限制数
AnswerAttLimitSize = objRow[convcc_WorkStuRelation.AnswerAttLimitSize] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convcc_WorkStuRelation.AnswerAttLimitSize].ToString().Trim()), //回答附件限制大小
LimitedResourceType = objRow[convcc_WorkStuRelation.LimitedResourceType] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.LimitedResourceType].ToString().Trim(), //限制资源类型
QuestionTypeId4Course = objRow[convcc_WorkStuRelation.QuestionTypeId4Course] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionTypeId4Course].ToString().Trim(), //题目类型Id4课程
QuestionTypeName4Course = objRow[convcc_WorkStuRelation.QuestionTypeName4Course] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionTypeName4Course].ToString().Trim(), //题目类型名4课程
CurrEduClsId = objRow[convcc_WorkStuRelation.CurrEduClsId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CurrEduClsId].ToString().Trim(), //教学班Id
EduClsName = objRow[convcc_WorkStuRelation.EduClsName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.EduClsName].ToString().Trim(), //教学班名
TeacherId = objRow[convcc_WorkStuRelation.TeacherId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.TeacherId].ToString().Trim(), //教师工号
PubDate = objRow[convcc_WorkStuRelation.PubDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.PubDate].ToString().Trim(), //发布日期
IsCurrEduCls = TransNullToBool(objRow[convcc_WorkStuRelation.IsCurrEduCls].ToString().Trim()), //是否为教学班作业
IsGroupWork = TransNullToBool(objRow[convcc_WorkStuRelation.IsGroupWork].ToString().Trim()), //是否为小组作业
CourseStudentGroupId = objRow[convcc_WorkStuRelation.CourseStudentGroupId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convcc_WorkStuRelation.CourseStudentGroupId].ToString().Trim()), //学生分组表流水号
WorkTypeName = objRow[convcc_WorkStuRelation.WorkTypeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.WorkTypeName].ToString().Trim(), //作业类型名称
Scores = objRow[convcc_WorkStuRelation.Scores] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convcc_WorkStuRelation.Scores].ToString().Trim()), //分值
SpecifyCompletionDate = objRow[convcc_WorkStuRelation.SpecifyCompletionDate].ToString().Trim(), //指定完成日期
IdStudentInfo = objRow[convcc_WorkStuRelation.IdStudentInfo].ToString().Trim(), //学生流水号
StuId = objRow[convcc_WorkStuRelation.StuId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.StuId].ToString().Trim(), //学号
StuName = objRow[convcc_WorkStuRelation.StuName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.StuName].ToString().Trim(), //姓名
IdXzCollege = objRow[convcc_WorkStuRelation.IdXzCollege] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.IdXzCollege].ToString().Trim(), //学院流水号
CollegeName = objRow[convcc_WorkStuRelation.CollegeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CollegeName].ToString().Trim(), //学院名称
CollegeNameA = objRow[convcc_WorkStuRelation.CollegeNameA] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CollegeNameA].ToString().Trim(), //学院名称简写
IdXzMajor = objRow[convcc_WorkStuRelation.IdXzMajor] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.IdXzMajor].ToString().Trim(), //专业流水号
MajorId = objRow[convcc_WorkStuRelation.MajorId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.MajorId].ToString().Trim(), //专业Id
MajorName = objRow[convcc_WorkStuRelation.MajorName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.MajorName].ToString().Trim(), //专业名称
IdGradeBase = objRow[convcc_WorkStuRelation.IdGradeBase] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.IdGradeBase].ToString().Trim(), //年级流水号
GradeBaseName = objRow[convcc_WorkStuRelation.GradeBaseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.GradeBaseName].ToString().Trim(), //年级名称
AdminClsName = objRow[convcc_WorkStuRelation.AdminClsName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AdminClsName].ToString().Trim(), //行政班名称
AdminClsId = objRow[convcc_WorkStuRelation.AdminClsId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AdminClsId].ToString().Trim(), //行政班代号
AnswerModeId = objRow[convcc_WorkStuRelation.AnswerModeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerModeId].ToString().Trim(), //答案模式Id
AnswerOptionId = objRow[convcc_WorkStuRelation.AnswerOptionId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerOptionId].ToString().Trim(), //回答选项Id
AnswerMultiOptions = objRow[convcc_WorkStuRelation.AnswerMultiOptions] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerMultiOptions].ToString().Trim(), //多选项答案
AnswerBoolResult = TransNullToBool(objRow[convcc_WorkStuRelation.AnswerBoolResult].ToString().Trim()), //答案布尔结果
StuAnswerText = objRow[convcc_WorkStuRelation.StuAnswerText] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.StuAnswerText].ToString().Trim(), //学生回答文本
IsPublish = TransNullToBool(objRow[convcc_WorkStuRelation.IsPublish].ToString().Trim()), //是否发布
IsLook = TransNullToBool(objRow[convcc_WorkStuRelation.IsLook].ToString().Trim()), //是否查看
IsSave = TransNullToBool(objRow[convcc_WorkStuRelation.IsSave].ToString().Trim()), //是否保存
IsSubmit = TransNullToBool(objRow[convcc_WorkStuRelation.IsSubmit].ToString().Trim()), //是否提交
ApplySendBackDate = objRow[convcc_WorkStuRelation.ApplySendBackDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ApplySendBackDate].ToString().Trim(), //申请退回日期
IsApplySendBack = TransNullToBool(objRow[convcc_WorkStuRelation.IsApplySendBack].ToString().Trim()), //是否申请退回
RealFinishDate = objRow[convcc_WorkStuRelation.RealFinishDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.RealFinishDate].ToString().Trim(), //实际完成日期
OperateTime = objRow[convcc_WorkStuRelation.OperateTime] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.OperateTime].ToString().Trim(), //操作时间
Score = objRow[convcc_WorkStuRelation.Score] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convcc_WorkStuRelation.Score].ToString().Trim()), //得分
Comment = objRow[convcc_WorkStuRelation.Comment] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.Comment].ToString().Trim(), //批注
IsMarking = TransNullToBool(objRow[convcc_WorkStuRelation.IsMarking].ToString().Trim()), //是否批阅
MarkerId = objRow[convcc_WorkStuRelation.MarkerId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.MarkerId].ToString().Trim(), //打分者
MarkDate = objRow[convcc_WorkStuRelation.MarkDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.MarkDate].ToString().Trim(), //打分日期
IsSendBack = TransNullToBool(objRow[convcc_WorkStuRelation.IsSendBack].ToString().Trim()), //是否退回
IsInErrorQuestion = TransNullToBool(objRow[convcc_WorkStuRelation.IsInErrorQuestion].ToString().Trim()), //是否进入错题
WorkTypeId = objRow[convcc_WorkStuRelation.WorkTypeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.WorkTypeId].ToString().Trim(), //作业类型Id
AnswerIP = objRow[convcc_WorkStuRelation.AnswerIP] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerIP].ToString().Trim(), //回答IP
AnswerDate = objRow[convcc_WorkStuRelation.AnswerDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerDate].ToString().Trim(), //回答日期
AnswerTime = objRow[convcc_WorkStuRelation.AnswerTime] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerTime].ToString().Trim(), //回答时间
CourseExamPaperId = objRow[convcc_WorkStuRelation.CourseExamPaperId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseExamPaperId].ToString().Trim(), //考卷流水号
IsRight = TransNullToBool(objRow[convcc_WorkStuRelation.IsRight].ToString().Trim()), //是否正确
IsAccessKnowledge = TransNullToBool(objRow[convcc_WorkStuRelation.IsAccessKnowledge].ToString().Trim()), //是否处理知识点
IsNotProcessTimeout = TransNullToBool(objRow[convcc_WorkStuRelation.IsNotProcessTimeout].ToString().Trim()), //是否不处理超时
SchoolYear = objRow[convcc_WorkStuRelation.SchoolYear] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.SchoolYear].ToString().Trim(), //学年
SchoolTerm = objRow[convcc_WorkStuRelation.SchoolTerm] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.SchoolTerm].ToString().Trim(), //学期
ErrMsg = objRow[convcc_WorkStuRelation.ErrMsg] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ErrMsg].ToString().Trim(), //错误信息
UpdDate = objRow[convcc_WorkStuRelation.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[convcc_WorkStuRelation.UpdUserId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[convcc_WorkStuRelation.Memo] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.Memo].ToString().Trim() //备注
};
objvcc_WorkStuRelationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvcc_WorkStuRelationEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvcc_WorkStuRelationDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvcc_WorkStuRelationEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN = new clsvcc_WorkStuRelationEN();
try
{
objvcc_WorkStuRelationEN.IdWorkStuRelation = TransNullToInt(objRow[convcc_WorkStuRelation.IdWorkStuRelation].ToString().Trim()); //流水号
objvcc_WorkStuRelationEN.IdCurrEduCls = objRow[convcc_WorkStuRelation.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvcc_WorkStuRelationEN.IdWorkEduClsRela = objRow[convcc_WorkStuRelation.IdWorkEduClsRela] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convcc_WorkStuRelation.IdWorkEduClsRela].ToString().Trim()); //作业教学班关系流水号
objvcc_WorkStuRelationEN.QuestionId = objRow[convcc_WorkStuRelation.QuestionId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convcc_WorkStuRelation.QuestionId].ToString().Trim()); //题目Id
objvcc_WorkStuRelationEN.QuestionIndex = objRow[convcc_WorkStuRelation.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_WorkStuRelation.QuestionIndex].ToString().Trim()); //题目序号
objvcc_WorkStuRelationEN.QuestionName = objRow[convcc_WorkStuRelation.QuestionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionName].ToString().Trim(); //题目名称
objvcc_WorkStuRelationEN.QuestionContent = objRow[convcc_WorkStuRelation.QuestionContent] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionContent].ToString().Trim(); //题目内容
objvcc_WorkStuRelationEN.CourseId = objRow[convcc_WorkStuRelation.CourseId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseId].ToString().Trim(); //课程Id
objvcc_WorkStuRelationEN.CourseName = objRow[convcc_WorkStuRelation.CourseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseName].ToString().Trim(); //课程名称
objvcc_WorkStuRelationEN.CourseChapterId = objRow[convcc_WorkStuRelation.CourseChapterId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkStuRelationEN.CourseChapterName = objRow[convcc_WorkStuRelation.CourseChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkStuRelationEN.ChapterName = objRow[convcc_WorkStuRelation.ChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ChapterName].ToString().Trim(); //章名
objvcc_WorkStuRelationEN.SectionName = objRow[convcc_WorkStuRelation.SectionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.SectionName].ToString().Trim(); //节名
objvcc_WorkStuRelationEN.ChapterNameSim = objRow[convcc_WorkStuRelation.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkStuRelationEN.SectionNameSim = objRow[convcc_WorkStuRelation.SectionNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkStuRelationEN.ParentNodeId = objRow[convcc_WorkStuRelation.ParentNodeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_WorkStuRelationEN.CourseChapterReferred = objRow[convcc_WorkStuRelation.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkStuRelationEN.ParentNodeName = objRow[convcc_WorkStuRelation.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkStuRelationEN.ParentNodeReferred = objRow[convcc_WorkStuRelation.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkStuRelationEN.QuestionTypeId = objRow[convcc_WorkStuRelation.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_WorkStuRelationEN.QuestionTypeName = objRow[convcc_WorkStuRelation.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionTypeName].ToString().Trim(); //题目类型名
objvcc_WorkStuRelationEN.AnswerTypeId = objRow[convcc_WorkStuRelation.AnswerTypeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerTypeId].ToString().Trim(); //答案类型ID
objvcc_WorkStuRelationEN.DefaultValue = objRow[convcc_WorkStuRelation.DefaultValue] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.DefaultValue].ToString().Trim(); //缺省值
objvcc_WorkStuRelationEN.TextDirectId = objRow[convcc_WorkStuRelation.TextDirectId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.TextDirectId].ToString().Trim(); //文本方向ID
objvcc_WorkStuRelationEN.RelaEvent = objRow[convcc_WorkStuRelation.RelaEvent] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.RelaEvent].ToString().Trim(); //相关事件
objvcc_WorkStuRelationEN.CheckBoxLimitCount = objRow[convcc_WorkStuRelation.CheckBoxLimitCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_WorkStuRelation.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objvcc_WorkStuRelationEN.AnswerAttLimitSize = objRow[convcc_WorkStuRelation.AnswerAttLimitSize] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convcc_WorkStuRelation.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objvcc_WorkStuRelationEN.LimitedResourceType = objRow[convcc_WorkStuRelation.LimitedResourceType] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.LimitedResourceType].ToString().Trim(); //限制资源类型
objvcc_WorkStuRelationEN.QuestionTypeId4Course = objRow[convcc_WorkStuRelation.QuestionTypeId4Course] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvcc_WorkStuRelationEN.QuestionTypeName4Course = objRow[convcc_WorkStuRelation.QuestionTypeName4Course] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程
objvcc_WorkStuRelationEN.CurrEduClsId = objRow[convcc_WorkStuRelation.CurrEduClsId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CurrEduClsId].ToString().Trim(); //教学班Id
objvcc_WorkStuRelationEN.EduClsName = objRow[convcc_WorkStuRelation.EduClsName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.EduClsName].ToString().Trim(); //教学班名
objvcc_WorkStuRelationEN.TeacherId = objRow[convcc_WorkStuRelation.TeacherId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.TeacherId].ToString().Trim(); //教师工号
objvcc_WorkStuRelationEN.PubDate = objRow[convcc_WorkStuRelation.PubDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.PubDate].ToString().Trim(); //发布日期
objvcc_WorkStuRelationEN.IsCurrEduCls = TransNullToBool(objRow[convcc_WorkStuRelation.IsCurrEduCls].ToString().Trim()); //是否为教学班作业
objvcc_WorkStuRelationEN.IsGroupWork = TransNullToBool(objRow[convcc_WorkStuRelation.IsGroupWork].ToString().Trim()); //是否为小组作业
objvcc_WorkStuRelationEN.CourseStudentGroupId = objRow[convcc_WorkStuRelation.CourseStudentGroupId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convcc_WorkStuRelation.CourseStudentGroupId].ToString().Trim()); //学生分组表流水号
objvcc_WorkStuRelationEN.WorkTypeName = objRow[convcc_WorkStuRelation.WorkTypeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.WorkTypeName].ToString().Trim(); //作业类型名称
objvcc_WorkStuRelationEN.Scores = objRow[convcc_WorkStuRelation.Scores] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convcc_WorkStuRelation.Scores].ToString().Trim()); //分值
objvcc_WorkStuRelationEN.SpecifyCompletionDate = objRow[convcc_WorkStuRelation.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objvcc_WorkStuRelationEN.IdStudentInfo = objRow[convcc_WorkStuRelation.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_WorkStuRelationEN.StuId = objRow[convcc_WorkStuRelation.StuId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.StuId].ToString().Trim(); //学号
objvcc_WorkStuRelationEN.StuName = objRow[convcc_WorkStuRelation.StuName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.StuName].ToString().Trim(); //姓名
objvcc_WorkStuRelationEN.IdXzCollege = objRow[convcc_WorkStuRelation.IdXzCollege] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_WorkStuRelationEN.CollegeName = objRow[convcc_WorkStuRelation.CollegeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CollegeName].ToString().Trim(); //学院名称
objvcc_WorkStuRelationEN.CollegeNameA = objRow[convcc_WorkStuRelation.CollegeNameA] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_WorkStuRelationEN.IdXzMajor = objRow[convcc_WorkStuRelation.IdXzMajor] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_WorkStuRelationEN.MajorId = objRow[convcc_WorkStuRelation.MajorId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.MajorId].ToString().Trim(); //专业Id
objvcc_WorkStuRelationEN.MajorName = objRow[convcc_WorkStuRelation.MajorName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.MajorName].ToString().Trim(); //专业名称
objvcc_WorkStuRelationEN.IdGradeBase = objRow[convcc_WorkStuRelation.IdGradeBase] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.IdGradeBase].ToString().Trim(); //年级流水号
objvcc_WorkStuRelationEN.GradeBaseName = objRow[convcc_WorkStuRelation.GradeBaseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.GradeBaseName].ToString().Trim(); //年级名称
objvcc_WorkStuRelationEN.AdminClsName = objRow[convcc_WorkStuRelation.AdminClsName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AdminClsName].ToString().Trim(); //行政班名称
objvcc_WorkStuRelationEN.AdminClsId = objRow[convcc_WorkStuRelation.AdminClsId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AdminClsId].ToString().Trim(); //行政班代号
objvcc_WorkStuRelationEN.AnswerModeId = objRow[convcc_WorkStuRelation.AnswerModeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerModeId].ToString().Trim(); //答案模式Id
objvcc_WorkStuRelationEN.AnswerOptionId = objRow[convcc_WorkStuRelation.AnswerOptionId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerOptionId].ToString().Trim(); //回答选项Id
objvcc_WorkStuRelationEN.AnswerMultiOptions = objRow[convcc_WorkStuRelation.AnswerMultiOptions] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerMultiOptions].ToString().Trim(); //多选项答案
objvcc_WorkStuRelationEN.AnswerBoolResult = TransNullToBool(objRow[convcc_WorkStuRelation.AnswerBoolResult].ToString().Trim()); //答案布尔结果
objvcc_WorkStuRelationEN.StuAnswerText = objRow[convcc_WorkStuRelation.StuAnswerText] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.StuAnswerText].ToString().Trim(); //学生回答文本
objvcc_WorkStuRelationEN.IsPublish = TransNullToBool(objRow[convcc_WorkStuRelation.IsPublish].ToString().Trim()); //是否发布
objvcc_WorkStuRelationEN.IsLook = TransNullToBool(objRow[convcc_WorkStuRelation.IsLook].ToString().Trim()); //是否查看
objvcc_WorkStuRelationEN.IsSave = TransNullToBool(objRow[convcc_WorkStuRelation.IsSave].ToString().Trim()); //是否保存
objvcc_WorkStuRelationEN.IsSubmit = TransNullToBool(objRow[convcc_WorkStuRelation.IsSubmit].ToString().Trim()); //是否提交
objvcc_WorkStuRelationEN.ApplySendBackDate = objRow[convcc_WorkStuRelation.ApplySendBackDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ApplySendBackDate].ToString().Trim(); //申请退回日期
objvcc_WorkStuRelationEN.IsApplySendBack = TransNullToBool(objRow[convcc_WorkStuRelation.IsApplySendBack].ToString().Trim()); //是否申请退回
objvcc_WorkStuRelationEN.RealFinishDate = objRow[convcc_WorkStuRelation.RealFinishDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.RealFinishDate].ToString().Trim(); //实际完成日期
objvcc_WorkStuRelationEN.OperateTime = objRow[convcc_WorkStuRelation.OperateTime] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.OperateTime].ToString().Trim(); //操作时间
objvcc_WorkStuRelationEN.Score = objRow[convcc_WorkStuRelation.Score] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convcc_WorkStuRelation.Score].ToString().Trim()); //得分
objvcc_WorkStuRelationEN.Comment = objRow[convcc_WorkStuRelation.Comment] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.Comment].ToString().Trim(); //批注
objvcc_WorkStuRelationEN.IsMarking = TransNullToBool(objRow[convcc_WorkStuRelation.IsMarking].ToString().Trim()); //是否批阅
objvcc_WorkStuRelationEN.MarkerId = objRow[convcc_WorkStuRelation.MarkerId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.MarkerId].ToString().Trim(); //打分者
objvcc_WorkStuRelationEN.MarkDate = objRow[convcc_WorkStuRelation.MarkDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.MarkDate].ToString().Trim(); //打分日期
objvcc_WorkStuRelationEN.IsSendBack = TransNullToBool(objRow[convcc_WorkStuRelation.IsSendBack].ToString().Trim()); //是否退回
objvcc_WorkStuRelationEN.IsInErrorQuestion = TransNullToBool(objRow[convcc_WorkStuRelation.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objvcc_WorkStuRelationEN.WorkTypeId = objRow[convcc_WorkStuRelation.WorkTypeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.WorkTypeId].ToString().Trim(); //作业类型Id
objvcc_WorkStuRelationEN.AnswerIP = objRow[convcc_WorkStuRelation.AnswerIP] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerIP].ToString().Trim(); //回答IP
objvcc_WorkStuRelationEN.AnswerDate = objRow[convcc_WorkStuRelation.AnswerDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerDate].ToString().Trim(); //回答日期
objvcc_WorkStuRelationEN.AnswerTime = objRow[convcc_WorkStuRelation.AnswerTime] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerTime].ToString().Trim(); //回答时间
objvcc_WorkStuRelationEN.CourseExamPaperId = objRow[convcc_WorkStuRelation.CourseExamPaperId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_WorkStuRelationEN.IsRight = TransNullToBool(objRow[convcc_WorkStuRelation.IsRight].ToString().Trim()); //是否正确
objvcc_WorkStuRelationEN.IsAccessKnowledge = TransNullToBool(objRow[convcc_WorkStuRelation.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objvcc_WorkStuRelationEN.IsNotProcessTimeout = TransNullToBool(objRow[convcc_WorkStuRelation.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objvcc_WorkStuRelationEN.SchoolYear = objRow[convcc_WorkStuRelation.SchoolYear] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.SchoolYear].ToString().Trim(); //学年
objvcc_WorkStuRelationEN.SchoolTerm = objRow[convcc_WorkStuRelation.SchoolTerm] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.SchoolTerm].ToString().Trim(); //学期
objvcc_WorkStuRelationEN.ErrMsg = objRow[convcc_WorkStuRelation.ErrMsg] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ErrMsg].ToString().Trim(); //错误信息
objvcc_WorkStuRelationEN.UpdDate = objRow[convcc_WorkStuRelation.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkStuRelationEN.UpdUserId = objRow[convcc_WorkStuRelation.UpdUserId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_WorkStuRelationEN.Memo = objRow[convcc_WorkStuRelation.Memo] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvcc_WorkStuRelationDA: GetObjByDataRowvcc_WorkStuRelation)", objException.Message));
}
objvcc_WorkStuRelationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvcc_WorkStuRelationEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvcc_WorkStuRelationEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN = new clsvcc_WorkStuRelationEN();
try
{
objvcc_WorkStuRelationEN.IdWorkStuRelation = TransNullToInt(objRow[convcc_WorkStuRelation.IdWorkStuRelation].ToString().Trim()); //流水号
objvcc_WorkStuRelationEN.IdCurrEduCls = objRow[convcc_WorkStuRelation.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvcc_WorkStuRelationEN.IdWorkEduClsRela = objRow[convcc_WorkStuRelation.IdWorkEduClsRela] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convcc_WorkStuRelation.IdWorkEduClsRela].ToString().Trim()); //作业教学班关系流水号
objvcc_WorkStuRelationEN.QuestionId = objRow[convcc_WorkStuRelation.QuestionId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convcc_WorkStuRelation.QuestionId].ToString().Trim()); //题目Id
objvcc_WorkStuRelationEN.QuestionIndex = objRow[convcc_WorkStuRelation.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_WorkStuRelation.QuestionIndex].ToString().Trim()); //题目序号
objvcc_WorkStuRelationEN.QuestionName = objRow[convcc_WorkStuRelation.QuestionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionName].ToString().Trim(); //题目名称
objvcc_WorkStuRelationEN.QuestionContent = objRow[convcc_WorkStuRelation.QuestionContent] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionContent].ToString().Trim(); //题目内容
objvcc_WorkStuRelationEN.CourseId = objRow[convcc_WorkStuRelation.CourseId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseId].ToString().Trim(); //课程Id
objvcc_WorkStuRelationEN.CourseName = objRow[convcc_WorkStuRelation.CourseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseName].ToString().Trim(); //课程名称
objvcc_WorkStuRelationEN.CourseChapterId = objRow[convcc_WorkStuRelation.CourseChapterId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkStuRelationEN.CourseChapterName = objRow[convcc_WorkStuRelation.CourseChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkStuRelationEN.ChapterName = objRow[convcc_WorkStuRelation.ChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ChapterName].ToString().Trim(); //章名
objvcc_WorkStuRelationEN.SectionName = objRow[convcc_WorkStuRelation.SectionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.SectionName].ToString().Trim(); //节名
objvcc_WorkStuRelationEN.ChapterNameSim = objRow[convcc_WorkStuRelation.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkStuRelationEN.SectionNameSim = objRow[convcc_WorkStuRelation.SectionNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkStuRelationEN.ParentNodeId = objRow[convcc_WorkStuRelation.ParentNodeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_WorkStuRelationEN.CourseChapterReferred = objRow[convcc_WorkStuRelation.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkStuRelationEN.ParentNodeName = objRow[convcc_WorkStuRelation.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkStuRelationEN.ParentNodeReferred = objRow[convcc_WorkStuRelation.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkStuRelationEN.QuestionTypeId = objRow[convcc_WorkStuRelation.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_WorkStuRelationEN.QuestionTypeName = objRow[convcc_WorkStuRelation.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionTypeName].ToString().Trim(); //题目类型名
objvcc_WorkStuRelationEN.AnswerTypeId = objRow[convcc_WorkStuRelation.AnswerTypeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerTypeId].ToString().Trim(); //答案类型ID
objvcc_WorkStuRelationEN.DefaultValue = objRow[convcc_WorkStuRelation.DefaultValue] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.DefaultValue].ToString().Trim(); //缺省值
objvcc_WorkStuRelationEN.TextDirectId = objRow[convcc_WorkStuRelation.TextDirectId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.TextDirectId].ToString().Trim(); //文本方向ID
objvcc_WorkStuRelationEN.RelaEvent = objRow[convcc_WorkStuRelation.RelaEvent] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.RelaEvent].ToString().Trim(); //相关事件
objvcc_WorkStuRelationEN.CheckBoxLimitCount = objRow[convcc_WorkStuRelation.CheckBoxLimitCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_WorkStuRelation.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objvcc_WorkStuRelationEN.AnswerAttLimitSize = objRow[convcc_WorkStuRelation.AnswerAttLimitSize] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convcc_WorkStuRelation.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objvcc_WorkStuRelationEN.LimitedResourceType = objRow[convcc_WorkStuRelation.LimitedResourceType] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.LimitedResourceType].ToString().Trim(); //限制资源类型
objvcc_WorkStuRelationEN.QuestionTypeId4Course = objRow[convcc_WorkStuRelation.QuestionTypeId4Course] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvcc_WorkStuRelationEN.QuestionTypeName4Course = objRow[convcc_WorkStuRelation.QuestionTypeName4Course] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程
objvcc_WorkStuRelationEN.CurrEduClsId = objRow[convcc_WorkStuRelation.CurrEduClsId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CurrEduClsId].ToString().Trim(); //教学班Id
objvcc_WorkStuRelationEN.EduClsName = objRow[convcc_WorkStuRelation.EduClsName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.EduClsName].ToString().Trim(); //教学班名
objvcc_WorkStuRelationEN.TeacherId = objRow[convcc_WorkStuRelation.TeacherId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.TeacherId].ToString().Trim(); //教师工号
objvcc_WorkStuRelationEN.PubDate = objRow[convcc_WorkStuRelation.PubDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.PubDate].ToString().Trim(); //发布日期
objvcc_WorkStuRelationEN.IsCurrEduCls = TransNullToBool(objRow[convcc_WorkStuRelation.IsCurrEduCls].ToString().Trim()); //是否为教学班作业
objvcc_WorkStuRelationEN.IsGroupWork = TransNullToBool(objRow[convcc_WorkStuRelation.IsGroupWork].ToString().Trim()); //是否为小组作业
objvcc_WorkStuRelationEN.CourseStudentGroupId = objRow[convcc_WorkStuRelation.CourseStudentGroupId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convcc_WorkStuRelation.CourseStudentGroupId].ToString().Trim()); //学生分组表流水号
objvcc_WorkStuRelationEN.WorkTypeName = objRow[convcc_WorkStuRelation.WorkTypeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.WorkTypeName].ToString().Trim(); //作业类型名称
objvcc_WorkStuRelationEN.Scores = objRow[convcc_WorkStuRelation.Scores] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convcc_WorkStuRelation.Scores].ToString().Trim()); //分值
objvcc_WorkStuRelationEN.SpecifyCompletionDate = objRow[convcc_WorkStuRelation.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objvcc_WorkStuRelationEN.IdStudentInfo = objRow[convcc_WorkStuRelation.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_WorkStuRelationEN.StuId = objRow[convcc_WorkStuRelation.StuId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.StuId].ToString().Trim(); //学号
objvcc_WorkStuRelationEN.StuName = objRow[convcc_WorkStuRelation.StuName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.StuName].ToString().Trim(); //姓名
objvcc_WorkStuRelationEN.IdXzCollege = objRow[convcc_WorkStuRelation.IdXzCollege] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_WorkStuRelationEN.CollegeName = objRow[convcc_WorkStuRelation.CollegeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CollegeName].ToString().Trim(); //学院名称
objvcc_WorkStuRelationEN.CollegeNameA = objRow[convcc_WorkStuRelation.CollegeNameA] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_WorkStuRelationEN.IdXzMajor = objRow[convcc_WorkStuRelation.IdXzMajor] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_WorkStuRelationEN.MajorId = objRow[convcc_WorkStuRelation.MajorId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.MajorId].ToString().Trim(); //专业Id
objvcc_WorkStuRelationEN.MajorName = objRow[convcc_WorkStuRelation.MajorName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.MajorName].ToString().Trim(); //专业名称
objvcc_WorkStuRelationEN.IdGradeBase = objRow[convcc_WorkStuRelation.IdGradeBase] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.IdGradeBase].ToString().Trim(); //年级流水号
objvcc_WorkStuRelationEN.GradeBaseName = objRow[convcc_WorkStuRelation.GradeBaseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.GradeBaseName].ToString().Trim(); //年级名称
objvcc_WorkStuRelationEN.AdminClsName = objRow[convcc_WorkStuRelation.AdminClsName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AdminClsName].ToString().Trim(); //行政班名称
objvcc_WorkStuRelationEN.AdminClsId = objRow[convcc_WorkStuRelation.AdminClsId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AdminClsId].ToString().Trim(); //行政班代号
objvcc_WorkStuRelationEN.AnswerModeId = objRow[convcc_WorkStuRelation.AnswerModeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerModeId].ToString().Trim(); //答案模式Id
objvcc_WorkStuRelationEN.AnswerOptionId = objRow[convcc_WorkStuRelation.AnswerOptionId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerOptionId].ToString().Trim(); //回答选项Id
objvcc_WorkStuRelationEN.AnswerMultiOptions = objRow[convcc_WorkStuRelation.AnswerMultiOptions] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerMultiOptions].ToString().Trim(); //多选项答案
objvcc_WorkStuRelationEN.AnswerBoolResult = TransNullToBool(objRow[convcc_WorkStuRelation.AnswerBoolResult].ToString().Trim()); //答案布尔结果
objvcc_WorkStuRelationEN.StuAnswerText = objRow[convcc_WorkStuRelation.StuAnswerText] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.StuAnswerText].ToString().Trim(); //学生回答文本
objvcc_WorkStuRelationEN.IsPublish = TransNullToBool(objRow[convcc_WorkStuRelation.IsPublish].ToString().Trim()); //是否发布
objvcc_WorkStuRelationEN.IsLook = TransNullToBool(objRow[convcc_WorkStuRelation.IsLook].ToString().Trim()); //是否查看
objvcc_WorkStuRelationEN.IsSave = TransNullToBool(objRow[convcc_WorkStuRelation.IsSave].ToString().Trim()); //是否保存
objvcc_WorkStuRelationEN.IsSubmit = TransNullToBool(objRow[convcc_WorkStuRelation.IsSubmit].ToString().Trim()); //是否提交
objvcc_WorkStuRelationEN.ApplySendBackDate = objRow[convcc_WorkStuRelation.ApplySendBackDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ApplySendBackDate].ToString().Trim(); //申请退回日期
objvcc_WorkStuRelationEN.IsApplySendBack = TransNullToBool(objRow[convcc_WorkStuRelation.IsApplySendBack].ToString().Trim()); //是否申请退回
objvcc_WorkStuRelationEN.RealFinishDate = objRow[convcc_WorkStuRelation.RealFinishDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.RealFinishDate].ToString().Trim(); //实际完成日期
objvcc_WorkStuRelationEN.OperateTime = objRow[convcc_WorkStuRelation.OperateTime] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.OperateTime].ToString().Trim(); //操作时间
objvcc_WorkStuRelationEN.Score = objRow[convcc_WorkStuRelation.Score] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convcc_WorkStuRelation.Score].ToString().Trim()); //得分
objvcc_WorkStuRelationEN.Comment = objRow[convcc_WorkStuRelation.Comment] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.Comment].ToString().Trim(); //批注
objvcc_WorkStuRelationEN.IsMarking = TransNullToBool(objRow[convcc_WorkStuRelation.IsMarking].ToString().Trim()); //是否批阅
objvcc_WorkStuRelationEN.MarkerId = objRow[convcc_WorkStuRelation.MarkerId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.MarkerId].ToString().Trim(); //打分者
objvcc_WorkStuRelationEN.MarkDate = objRow[convcc_WorkStuRelation.MarkDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.MarkDate].ToString().Trim(); //打分日期
objvcc_WorkStuRelationEN.IsSendBack = TransNullToBool(objRow[convcc_WorkStuRelation.IsSendBack].ToString().Trim()); //是否退回
objvcc_WorkStuRelationEN.IsInErrorQuestion = TransNullToBool(objRow[convcc_WorkStuRelation.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objvcc_WorkStuRelationEN.WorkTypeId = objRow[convcc_WorkStuRelation.WorkTypeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.WorkTypeId].ToString().Trim(); //作业类型Id
objvcc_WorkStuRelationEN.AnswerIP = objRow[convcc_WorkStuRelation.AnswerIP] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerIP].ToString().Trim(); //回答IP
objvcc_WorkStuRelationEN.AnswerDate = objRow[convcc_WorkStuRelation.AnswerDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerDate].ToString().Trim(); //回答日期
objvcc_WorkStuRelationEN.AnswerTime = objRow[convcc_WorkStuRelation.AnswerTime] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerTime].ToString().Trim(); //回答时间
objvcc_WorkStuRelationEN.CourseExamPaperId = objRow[convcc_WorkStuRelation.CourseExamPaperId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_WorkStuRelationEN.IsRight = TransNullToBool(objRow[convcc_WorkStuRelation.IsRight].ToString().Trim()); //是否正确
objvcc_WorkStuRelationEN.IsAccessKnowledge = TransNullToBool(objRow[convcc_WorkStuRelation.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objvcc_WorkStuRelationEN.IsNotProcessTimeout = TransNullToBool(objRow[convcc_WorkStuRelation.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objvcc_WorkStuRelationEN.SchoolYear = objRow[convcc_WorkStuRelation.SchoolYear] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.SchoolYear].ToString().Trim(); //学年
objvcc_WorkStuRelationEN.SchoolTerm = objRow[convcc_WorkStuRelation.SchoolTerm] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.SchoolTerm].ToString().Trim(); //学期
objvcc_WorkStuRelationEN.ErrMsg = objRow[convcc_WorkStuRelation.ErrMsg] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ErrMsg].ToString().Trim(); //错误信息
objvcc_WorkStuRelationEN.UpdDate = objRow[convcc_WorkStuRelation.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkStuRelationEN.UpdUserId = objRow[convcc_WorkStuRelation.UpdUserId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_WorkStuRelationEN.Memo = objRow[convcc_WorkStuRelation.Memo] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvcc_WorkStuRelationDA: GetObjByDataRow)", objException.Message));
}
objvcc_WorkStuRelationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvcc_WorkStuRelationEN;
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
objSQL = clsvcc_WorkStuRelationDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvcc_WorkStuRelationEN._CurrTabName, convcc_WorkStuRelation.IdWorkStuRelation, 8, "");
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
objSQL = clsvcc_WorkStuRelationDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvcc_WorkStuRelationEN._CurrTabName, convcc_WorkStuRelation.IdWorkStuRelation, 8, strPrefix);
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
 objSQL = clsvcc_WorkStuRelationDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdWorkStuRelation from vcc_WorkStuRelation where " + strCondition;
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
 objSQL = clsvcc_WorkStuRelationDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdWorkStuRelation from vcc_WorkStuRelation where " + strCondition;
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
 /// <param name = "lngIdWorkStuRelation">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngIdWorkStuRelation)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkStuRelationDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vcc_WorkStuRelation", "IdWorkStuRelation = " + ""+ lngIdWorkStuRelation+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvcc_WorkStuRelationDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkStuRelationDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vcc_WorkStuRelation", strCondition))
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
objSQL = clsvcc_WorkStuRelationDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vcc_WorkStuRelation");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationENS">源对象</param>
 /// <param name = "objvcc_WorkStuRelationENT">目标对象</param>
public void CopyTo(clsvcc_WorkStuRelationEN objvcc_WorkStuRelationENS, clsvcc_WorkStuRelationEN objvcc_WorkStuRelationENT)
{
objvcc_WorkStuRelationENT.IdWorkStuRelation = objvcc_WorkStuRelationENS.IdWorkStuRelation; //流水号
objvcc_WorkStuRelationENT.IdCurrEduCls = objvcc_WorkStuRelationENS.IdCurrEduCls; //教学班流水号
objvcc_WorkStuRelationENT.IdWorkEduClsRela = objvcc_WorkStuRelationENS.IdWorkEduClsRela; //作业教学班关系流水号
objvcc_WorkStuRelationENT.QuestionId = objvcc_WorkStuRelationENS.QuestionId; //题目Id
objvcc_WorkStuRelationENT.QuestionIndex = objvcc_WorkStuRelationENS.QuestionIndex; //题目序号
objvcc_WorkStuRelationENT.QuestionName = objvcc_WorkStuRelationENS.QuestionName; //题目名称
objvcc_WorkStuRelationENT.QuestionContent = objvcc_WorkStuRelationENS.QuestionContent; //题目内容
objvcc_WorkStuRelationENT.CourseId = objvcc_WorkStuRelationENS.CourseId; //课程Id
objvcc_WorkStuRelationENT.CourseName = objvcc_WorkStuRelationENS.CourseName; //课程名称
objvcc_WorkStuRelationENT.CourseChapterId = objvcc_WorkStuRelationENS.CourseChapterId; //课程章节ID
objvcc_WorkStuRelationENT.CourseChapterName = objvcc_WorkStuRelationENS.CourseChapterName; //课程章节名称
objvcc_WorkStuRelationENT.ChapterName = objvcc_WorkStuRelationENS.ChapterName; //章名
objvcc_WorkStuRelationENT.SectionName = objvcc_WorkStuRelationENS.SectionName; //节名
objvcc_WorkStuRelationENT.ChapterNameSim = objvcc_WorkStuRelationENS.ChapterNameSim; //章名简称
objvcc_WorkStuRelationENT.SectionNameSim = objvcc_WorkStuRelationENS.SectionNameSim; //节名简称
objvcc_WorkStuRelationENT.ParentNodeId = objvcc_WorkStuRelationENS.ParentNodeId; //父节点编号
objvcc_WorkStuRelationENT.CourseChapterReferred = objvcc_WorkStuRelationENS.CourseChapterReferred; //节简称
objvcc_WorkStuRelationENT.ParentNodeName = objvcc_WorkStuRelationENS.ParentNodeName; //父节点名称
objvcc_WorkStuRelationENT.ParentNodeReferred = objvcc_WorkStuRelationENS.ParentNodeReferred; //章简称
objvcc_WorkStuRelationENT.QuestionTypeId = objvcc_WorkStuRelationENS.QuestionTypeId; //题目类型Id
objvcc_WorkStuRelationENT.QuestionTypeName = objvcc_WorkStuRelationENS.QuestionTypeName; //题目类型名
objvcc_WorkStuRelationENT.AnswerTypeId = objvcc_WorkStuRelationENS.AnswerTypeId; //答案类型ID
objvcc_WorkStuRelationENT.DefaultValue = objvcc_WorkStuRelationENS.DefaultValue; //缺省值
objvcc_WorkStuRelationENT.TextDirectId = objvcc_WorkStuRelationENS.TextDirectId; //文本方向ID
objvcc_WorkStuRelationENT.RelaEvent = objvcc_WorkStuRelationENS.RelaEvent; //相关事件
objvcc_WorkStuRelationENT.CheckBoxLimitCount = objvcc_WorkStuRelationENS.CheckBoxLimitCount; //复选框限制数
objvcc_WorkStuRelationENT.AnswerAttLimitSize = objvcc_WorkStuRelationENS.AnswerAttLimitSize; //回答附件限制大小
objvcc_WorkStuRelationENT.LimitedResourceType = objvcc_WorkStuRelationENS.LimitedResourceType; //限制资源类型
objvcc_WorkStuRelationENT.QuestionTypeId4Course = objvcc_WorkStuRelationENS.QuestionTypeId4Course; //题目类型Id4课程
objvcc_WorkStuRelationENT.QuestionTypeName4Course = objvcc_WorkStuRelationENS.QuestionTypeName4Course; //题目类型名4课程
objvcc_WorkStuRelationENT.CurrEduClsId = objvcc_WorkStuRelationENS.CurrEduClsId; //教学班Id
objvcc_WorkStuRelationENT.EduClsName = objvcc_WorkStuRelationENS.EduClsName; //教学班名
objvcc_WorkStuRelationENT.TeacherId = objvcc_WorkStuRelationENS.TeacherId; //教师工号
objvcc_WorkStuRelationENT.PubDate = objvcc_WorkStuRelationENS.PubDate; //发布日期
objvcc_WorkStuRelationENT.IsCurrEduCls = objvcc_WorkStuRelationENS.IsCurrEduCls; //是否为教学班作业
objvcc_WorkStuRelationENT.IsGroupWork = objvcc_WorkStuRelationENS.IsGroupWork; //是否为小组作业
objvcc_WorkStuRelationENT.CourseStudentGroupId = objvcc_WorkStuRelationENS.CourseStudentGroupId; //学生分组表流水号
objvcc_WorkStuRelationENT.WorkTypeName = objvcc_WorkStuRelationENS.WorkTypeName; //作业类型名称
objvcc_WorkStuRelationENT.Scores = objvcc_WorkStuRelationENS.Scores; //分值
objvcc_WorkStuRelationENT.SpecifyCompletionDate = objvcc_WorkStuRelationENS.SpecifyCompletionDate; //指定完成日期
objvcc_WorkStuRelationENT.IdStudentInfo = objvcc_WorkStuRelationENS.IdStudentInfo; //学生流水号
objvcc_WorkStuRelationENT.StuId = objvcc_WorkStuRelationENS.StuId; //学号
objvcc_WorkStuRelationENT.StuName = objvcc_WorkStuRelationENS.StuName; //姓名
objvcc_WorkStuRelationENT.IdXzCollege = objvcc_WorkStuRelationENS.IdXzCollege; //学院流水号
objvcc_WorkStuRelationENT.CollegeName = objvcc_WorkStuRelationENS.CollegeName; //学院名称
objvcc_WorkStuRelationENT.CollegeNameA = objvcc_WorkStuRelationENS.CollegeNameA; //学院名称简写
objvcc_WorkStuRelationENT.IdXzMajor = objvcc_WorkStuRelationENS.IdXzMajor; //专业流水号
objvcc_WorkStuRelationENT.MajorId = objvcc_WorkStuRelationENS.MajorId; //专业Id
objvcc_WorkStuRelationENT.MajorName = objvcc_WorkStuRelationENS.MajorName; //专业名称
objvcc_WorkStuRelationENT.IdGradeBase = objvcc_WorkStuRelationENS.IdGradeBase; //年级流水号
objvcc_WorkStuRelationENT.GradeBaseName = objvcc_WorkStuRelationENS.GradeBaseName; //年级名称
objvcc_WorkStuRelationENT.AdminClsName = objvcc_WorkStuRelationENS.AdminClsName; //行政班名称
objvcc_WorkStuRelationENT.AdminClsId = objvcc_WorkStuRelationENS.AdminClsId; //行政班代号
objvcc_WorkStuRelationENT.AnswerModeId = objvcc_WorkStuRelationENS.AnswerModeId; //答案模式Id
objvcc_WorkStuRelationENT.AnswerOptionId = objvcc_WorkStuRelationENS.AnswerOptionId; //回答选项Id
objvcc_WorkStuRelationENT.AnswerMultiOptions = objvcc_WorkStuRelationENS.AnswerMultiOptions; //多选项答案
objvcc_WorkStuRelationENT.AnswerBoolResult = objvcc_WorkStuRelationENS.AnswerBoolResult; //答案布尔结果
objvcc_WorkStuRelationENT.StuAnswerText = objvcc_WorkStuRelationENS.StuAnswerText; //学生回答文本
objvcc_WorkStuRelationENT.IsPublish = objvcc_WorkStuRelationENS.IsPublish; //是否发布
objvcc_WorkStuRelationENT.IsLook = objvcc_WorkStuRelationENS.IsLook; //是否查看
objvcc_WorkStuRelationENT.IsSave = objvcc_WorkStuRelationENS.IsSave; //是否保存
objvcc_WorkStuRelationENT.IsSubmit = objvcc_WorkStuRelationENS.IsSubmit; //是否提交
objvcc_WorkStuRelationENT.ApplySendBackDate = objvcc_WorkStuRelationENS.ApplySendBackDate; //申请退回日期
objvcc_WorkStuRelationENT.IsApplySendBack = objvcc_WorkStuRelationENS.IsApplySendBack; //是否申请退回
objvcc_WorkStuRelationENT.RealFinishDate = objvcc_WorkStuRelationENS.RealFinishDate; //实际完成日期
objvcc_WorkStuRelationENT.OperateTime = objvcc_WorkStuRelationENS.OperateTime; //操作时间
objvcc_WorkStuRelationENT.Score = objvcc_WorkStuRelationENS.Score; //得分
objvcc_WorkStuRelationENT.Comment = objvcc_WorkStuRelationENS.Comment; //批注
objvcc_WorkStuRelationENT.IsMarking = objvcc_WorkStuRelationENS.IsMarking; //是否批阅
objvcc_WorkStuRelationENT.MarkerId = objvcc_WorkStuRelationENS.MarkerId; //打分者
objvcc_WorkStuRelationENT.MarkDate = objvcc_WorkStuRelationENS.MarkDate; //打分日期
objvcc_WorkStuRelationENT.IsSendBack = objvcc_WorkStuRelationENS.IsSendBack; //是否退回
objvcc_WorkStuRelationENT.IsInErrorQuestion = objvcc_WorkStuRelationENS.IsInErrorQuestion; //是否进入错题
objvcc_WorkStuRelationENT.WorkTypeId = objvcc_WorkStuRelationENS.WorkTypeId; //作业类型Id
objvcc_WorkStuRelationENT.AnswerIP = objvcc_WorkStuRelationENS.AnswerIP; //回答IP
objvcc_WorkStuRelationENT.AnswerDate = objvcc_WorkStuRelationENS.AnswerDate; //回答日期
objvcc_WorkStuRelationENT.AnswerTime = objvcc_WorkStuRelationENS.AnswerTime; //回答时间
objvcc_WorkStuRelationENT.CourseExamPaperId = objvcc_WorkStuRelationENS.CourseExamPaperId; //考卷流水号
objvcc_WorkStuRelationENT.IsRight = objvcc_WorkStuRelationENS.IsRight; //是否正确
objvcc_WorkStuRelationENT.IsAccessKnowledge = objvcc_WorkStuRelationENS.IsAccessKnowledge; //是否处理知识点
objvcc_WorkStuRelationENT.IsNotProcessTimeout = objvcc_WorkStuRelationENS.IsNotProcessTimeout; //是否不处理超时
objvcc_WorkStuRelationENT.SchoolYear = objvcc_WorkStuRelationENS.SchoolYear; //学年
objvcc_WorkStuRelationENT.SchoolTerm = objvcc_WorkStuRelationENS.SchoolTerm; //学期
objvcc_WorkStuRelationENT.ErrMsg = objvcc_WorkStuRelationENS.ErrMsg; //错误信息
objvcc_WorkStuRelationENT.UpdDate = objvcc_WorkStuRelationENS.UpdDate; //修改日期
objvcc_WorkStuRelationENT.UpdUserId = objvcc_WorkStuRelationENS.UpdUserId; //修改用户Id
objvcc_WorkStuRelationENT.Memo = objvcc_WorkStuRelationENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelationEN.IdCurrEduCls, 8, convcc_WorkStuRelation.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelationEN.QuestionName, 500, convcc_WorkStuRelation.QuestionName);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelationEN.QuestionContent, 4000, convcc_WorkStuRelation.QuestionContent);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelationEN.CourseId, 8, convcc_WorkStuRelation.CourseId);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelationEN.CourseName, 100, convcc_WorkStuRelation.CourseName);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelationEN.CourseChapterId, 8, convcc_WorkStuRelation.CourseChapterId);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelationEN.CourseChapterName, 100, convcc_WorkStuRelation.CourseChapterName);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelationEN.ChapterName, 100, convcc_WorkStuRelation.ChapterName);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelationEN.SectionName, 100, convcc_WorkStuRelation.SectionName);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelationEN.ChapterNameSim, 10, convcc_WorkStuRelation.ChapterNameSim);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelationEN.SectionNameSim, 10, convcc_WorkStuRelation.SectionNameSim);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelationEN.ParentNodeId, 8, convcc_WorkStuRelation.ParentNodeId);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelationEN.CourseChapterReferred, 10, convcc_WorkStuRelation.CourseChapterReferred);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelationEN.ParentNodeName, 100, convcc_WorkStuRelation.ParentNodeName);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelationEN.ParentNodeReferred, 10, convcc_WorkStuRelation.ParentNodeReferred);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelationEN.QuestionTypeId, 2, convcc_WorkStuRelation.QuestionTypeId);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelationEN.QuestionTypeName, 20, convcc_WorkStuRelation.QuestionTypeName);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelationEN.AnswerTypeId, 2, convcc_WorkStuRelation.AnswerTypeId);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelationEN.DefaultValue, 50, convcc_WorkStuRelation.DefaultValue);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelationEN.TextDirectId, 4, convcc_WorkStuRelation.TextDirectId);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelationEN.RelaEvent, 4000, convcc_WorkStuRelation.RelaEvent);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelationEN.LimitedResourceType, 100, convcc_WorkStuRelation.LimitedResourceType);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelationEN.QuestionTypeId4Course, 8, convcc_WorkStuRelation.QuestionTypeId4Course);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelationEN.QuestionTypeName4Course, 30, convcc_WorkStuRelation.QuestionTypeName4Course);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelationEN.CurrEduClsId, 15, convcc_WorkStuRelation.CurrEduClsId);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelationEN.EduClsName, 100, convcc_WorkStuRelation.EduClsName);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelationEN.TeacherId, 12, convcc_WorkStuRelation.TeacherId);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelationEN.PubDate, 14, convcc_WorkStuRelation.PubDate);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelationEN.WorkTypeName, 30, convcc_WorkStuRelation.WorkTypeName);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelationEN.SpecifyCompletionDate, 14, convcc_WorkStuRelation.SpecifyCompletionDate);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelationEN.IdStudentInfo, 8, convcc_WorkStuRelation.IdStudentInfo);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelationEN.StuId, 20, convcc_WorkStuRelation.StuId);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelationEN.StuName, 50, convcc_WorkStuRelation.StuName);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelationEN.IdXzCollege, 4, convcc_WorkStuRelation.IdXzCollege);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelationEN.CollegeName, 100, convcc_WorkStuRelation.CollegeName);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelationEN.CollegeNameA, 12, convcc_WorkStuRelation.CollegeNameA);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelationEN.IdXzMajor, 8, convcc_WorkStuRelation.IdXzMajor);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelationEN.MajorId, 4, convcc_WorkStuRelation.MajorId);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelationEN.MajorName, 100, convcc_WorkStuRelation.MajorName);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelationEN.IdGradeBase, 4, convcc_WorkStuRelation.IdGradeBase);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelationEN.GradeBaseName, 50, convcc_WorkStuRelation.GradeBaseName);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelationEN.AdminClsName, 100, convcc_WorkStuRelation.AdminClsName);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelationEN.AdminClsId, 8, convcc_WorkStuRelation.AdminClsId);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelationEN.AnswerModeId, 4, convcc_WorkStuRelation.AnswerModeId);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelationEN.AnswerOptionId, 8, convcc_WorkStuRelation.AnswerOptionId);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelationEN.AnswerMultiOptions, 300, convcc_WorkStuRelation.AnswerMultiOptions);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelationEN.ApplySendBackDate, 14, convcc_WorkStuRelation.ApplySendBackDate);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelationEN.RealFinishDate, 14, convcc_WorkStuRelation.RealFinishDate);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelationEN.OperateTime, 14, convcc_WorkStuRelation.OperateTime);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelationEN.MarkerId, 20, convcc_WorkStuRelation.MarkerId);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelationEN.MarkDate, 14, convcc_WorkStuRelation.MarkDate);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelationEN.WorkTypeId, 2, convcc_WorkStuRelation.WorkTypeId);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelationEN.AnswerIP, 30, convcc_WorkStuRelation.AnswerIP);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelationEN.AnswerDate, 8, convcc_WorkStuRelation.AnswerDate);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelationEN.AnswerTime, 10, convcc_WorkStuRelation.AnswerTime);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelationEN.CourseExamPaperId, 8, convcc_WorkStuRelation.CourseExamPaperId);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelationEN.SchoolYear, 10, convcc_WorkStuRelation.SchoolYear);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelationEN.SchoolTerm, 1, convcc_WorkStuRelation.SchoolTerm);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelationEN.ErrMsg, 200, convcc_WorkStuRelation.ErrMsg);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelationEN.UpdDate, 20, convcc_WorkStuRelation.UpdDate);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelationEN.UpdUserId, 20, convcc_WorkStuRelation.UpdUserId);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelationEN.Memo, 1000, convcc_WorkStuRelation.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelationEN.IdCurrEduCls, convcc_WorkStuRelation.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelationEN.QuestionName, convcc_WorkStuRelation.QuestionName);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelationEN.QuestionContent, convcc_WorkStuRelation.QuestionContent);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelationEN.CourseId, convcc_WorkStuRelation.CourseId);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelationEN.CourseName, convcc_WorkStuRelation.CourseName);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelationEN.CourseChapterId, convcc_WorkStuRelation.CourseChapterId);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelationEN.CourseChapterName, convcc_WorkStuRelation.CourseChapterName);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelationEN.ChapterName, convcc_WorkStuRelation.ChapterName);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelationEN.SectionName, convcc_WorkStuRelation.SectionName);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelationEN.ChapterNameSim, convcc_WorkStuRelation.ChapterNameSim);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelationEN.SectionNameSim, convcc_WorkStuRelation.SectionNameSim);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelationEN.ParentNodeId, convcc_WorkStuRelation.ParentNodeId);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelationEN.CourseChapterReferred, convcc_WorkStuRelation.CourseChapterReferred);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelationEN.ParentNodeName, convcc_WorkStuRelation.ParentNodeName);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelationEN.ParentNodeReferred, convcc_WorkStuRelation.ParentNodeReferred);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelationEN.QuestionTypeId, convcc_WorkStuRelation.QuestionTypeId);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelationEN.QuestionTypeName, convcc_WorkStuRelation.QuestionTypeName);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelationEN.AnswerTypeId, convcc_WorkStuRelation.AnswerTypeId);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelationEN.DefaultValue, convcc_WorkStuRelation.DefaultValue);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelationEN.TextDirectId, convcc_WorkStuRelation.TextDirectId);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelationEN.RelaEvent, convcc_WorkStuRelation.RelaEvent);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelationEN.LimitedResourceType, convcc_WorkStuRelation.LimitedResourceType);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelationEN.QuestionTypeId4Course, convcc_WorkStuRelation.QuestionTypeId4Course);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelationEN.QuestionTypeName4Course, convcc_WorkStuRelation.QuestionTypeName4Course);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelationEN.CurrEduClsId, convcc_WorkStuRelation.CurrEduClsId);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelationEN.EduClsName, convcc_WorkStuRelation.EduClsName);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelationEN.TeacherId, convcc_WorkStuRelation.TeacherId);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelationEN.PubDate, convcc_WorkStuRelation.PubDate);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelationEN.WorkTypeName, convcc_WorkStuRelation.WorkTypeName);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelationEN.SpecifyCompletionDate, convcc_WorkStuRelation.SpecifyCompletionDate);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelationEN.IdStudentInfo, convcc_WorkStuRelation.IdStudentInfo);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelationEN.StuId, convcc_WorkStuRelation.StuId);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelationEN.StuName, convcc_WorkStuRelation.StuName);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelationEN.IdXzCollege, convcc_WorkStuRelation.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelationEN.CollegeName, convcc_WorkStuRelation.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelationEN.CollegeNameA, convcc_WorkStuRelation.CollegeNameA);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelationEN.IdXzMajor, convcc_WorkStuRelation.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelationEN.MajorId, convcc_WorkStuRelation.MajorId);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelationEN.MajorName, convcc_WorkStuRelation.MajorName);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelationEN.IdGradeBase, convcc_WorkStuRelation.IdGradeBase);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelationEN.GradeBaseName, convcc_WorkStuRelation.GradeBaseName);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelationEN.AdminClsName, convcc_WorkStuRelation.AdminClsName);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelationEN.AdminClsId, convcc_WorkStuRelation.AdminClsId);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelationEN.AnswerModeId, convcc_WorkStuRelation.AnswerModeId);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelationEN.AnswerOptionId, convcc_WorkStuRelation.AnswerOptionId);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelationEN.AnswerMultiOptions, convcc_WorkStuRelation.AnswerMultiOptions);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelationEN.ApplySendBackDate, convcc_WorkStuRelation.ApplySendBackDate);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelationEN.RealFinishDate, convcc_WorkStuRelation.RealFinishDate);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelationEN.OperateTime, convcc_WorkStuRelation.OperateTime);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelationEN.MarkerId, convcc_WorkStuRelation.MarkerId);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelationEN.MarkDate, convcc_WorkStuRelation.MarkDate);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelationEN.WorkTypeId, convcc_WorkStuRelation.WorkTypeId);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelationEN.AnswerIP, convcc_WorkStuRelation.AnswerIP);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelationEN.AnswerDate, convcc_WorkStuRelation.AnswerDate);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelationEN.AnswerTime, convcc_WorkStuRelation.AnswerTime);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelationEN.CourseExamPaperId, convcc_WorkStuRelation.CourseExamPaperId);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelationEN.SchoolYear, convcc_WorkStuRelation.SchoolYear);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelationEN.SchoolTerm, convcc_WorkStuRelation.SchoolTerm);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelationEN.ErrMsg, convcc_WorkStuRelation.ErrMsg);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelationEN.UpdDate, convcc_WorkStuRelation.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelationEN.UpdUserId, convcc_WorkStuRelation.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelationEN.Memo, convcc_WorkStuRelation.Memo);
//检查外键字段长度
 objvcc_WorkStuRelationEN._IsCheckProperty = true;
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
 objSQL = clsvcc_WorkStuRelationDA.GetSpecSQLObj();
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
 objSQL = clsvcc_WorkStuRelationDA.GetSpecSQLObj();
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
 objSQL = clsvcc_WorkStuRelationDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvcc_WorkStuRelationEN._CurrTabName);
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
 objSQL = clsvcc_WorkStuRelationDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvcc_WorkStuRelationEN._CurrTabName, strCondition);
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
 objSQL = clsvcc_WorkStuRelationDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}