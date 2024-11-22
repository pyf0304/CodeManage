
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_ExamPaperStuRelationDA
 表名:cc_ExamPaperStuRelation(01120235)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:13:40
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
 /// 考卷与学生关系(cc_ExamPaperStuRelation)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clscc_ExamPaperStuRelationDA : clsCommBase4DA
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
 return clscc_ExamPaperStuRelationEN._CurrTabName;
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
if (string.IsNullOrEmpty(clscc_ExamPaperStuRelationEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clscc_ExamPaperStuRelationEN._ConnectString);
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
 if (string.IsNullOrEmpty(clscc_ExamPaperStuRelationEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clscc_ExamPaperStuRelationEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clscc_ExamPaperStuRelationDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperStuRelationDA.GetSpecSQLObj();
strSQL = "Select * from cc_ExamPaperStuRelation where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_cc_ExamPaperStuRelation(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clscc_ExamPaperStuRelationDA: GetDataTable_cc_ExamPaperStuRelation)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperStuRelationDA.GetSpecSQLObj();
strSQL = "Select * from cc_ExamPaperStuRelation where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clscc_ExamPaperStuRelationDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperStuRelationDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clscc_ExamPaperStuRelationDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperStuRelationDA.GetSpecSQLObj();
strSQL = "Select * from cc_ExamPaperStuRelation where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clscc_ExamPaperStuRelationDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperStuRelationDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clscc_ExamPaperStuRelationDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperStuRelationDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from cc_ExamPaperStuRelation where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from cc_ExamPaperStuRelation where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clscc_ExamPaperStuRelationDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperStuRelationDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from cc_ExamPaperStuRelation where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clscc_ExamPaperStuRelationDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperStuRelationDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} cc_ExamPaperStuRelation.* from cc_ExamPaperStuRelation Left Join {1} on {2} where {3} and cc_ExamPaperStuRelation.IdExamPaperStuRelation not in (Select top {5} cc_ExamPaperStuRelation.IdExamPaperStuRelation from cc_ExamPaperStuRelation Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from cc_ExamPaperStuRelation where {1} and IdExamPaperStuRelation not in (Select top {2} IdExamPaperStuRelation from cc_ExamPaperStuRelation where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from cc_ExamPaperStuRelation where {1} and IdExamPaperStuRelation not in (Select top {3} IdExamPaperStuRelation from cc_ExamPaperStuRelation where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clscc_ExamPaperStuRelationDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperStuRelationDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} cc_ExamPaperStuRelation.* from cc_ExamPaperStuRelation Left Join {1} on {2} where {3} and cc_ExamPaperStuRelation.IdExamPaperStuRelation not in (Select top {5} cc_ExamPaperStuRelation.IdExamPaperStuRelation from cc_ExamPaperStuRelation Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from cc_ExamPaperStuRelation where {1} and IdExamPaperStuRelation not in (Select top {2} IdExamPaperStuRelation from cc_ExamPaperStuRelation where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from cc_ExamPaperStuRelation where {1} and IdExamPaperStuRelation not in (Select top {3} IdExamPaperStuRelation from cc_ExamPaperStuRelation where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clscc_ExamPaperStuRelationEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clscc_ExamPaperStuRelationDA:GetObjLst)", objException.Message));
}
List<clscc_ExamPaperStuRelationEN> arrObjLst = new List<clscc_ExamPaperStuRelationEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperStuRelationDA.GetSpecSQLObj();
strSQL = "Select * from cc_ExamPaperStuRelation where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN = new clscc_ExamPaperStuRelationEN();
try
{
objcc_ExamPaperStuRelationEN.IdExamPaperStuRelation = TransNullToInt(objRow[concc_ExamPaperStuRelation.IdExamPaperStuRelation].ToString().Trim()); //流水号
objcc_ExamPaperStuRelationEN.CourseExamPaperId = objRow[concc_ExamPaperStuRelation.CourseExamPaperId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_ExamPaperStuRelationEN.IdCurrEduCls = objRow[concc_ExamPaperStuRelation.IdCurrEduCls].ToString().Trim(); //教学班流水号
objcc_ExamPaperStuRelationEN.Scores = objRow[concc_ExamPaperStuRelation.Scores] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_ExamPaperStuRelation.Scores].ToString().Trim()); //分值
objcc_ExamPaperStuRelationEN.SpecifyCompletionDate = objRow[concc_ExamPaperStuRelation.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objcc_ExamPaperStuRelationEN.IdStudentInfo = objRow[concc_ExamPaperStuRelation.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_ExamPaperStuRelationEN.AnswerModeId = objRow[concc_ExamPaperStuRelation.AnswerModeId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerModeId].ToString().Trim(); //答案模式Id
objcc_ExamPaperStuRelationEN.AnswerOptionId = objRow[concc_ExamPaperStuRelation.AnswerOptionId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerOptionId].ToString().Trim(); //回答选项Id
objcc_ExamPaperStuRelationEN.AnswerMultiOptions = objRow[concc_ExamPaperStuRelation.AnswerMultiOptions] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerMultiOptions].ToString().Trim(); //多选项答案
objcc_ExamPaperStuRelationEN.StuAnswerText = objRow[concc_ExamPaperStuRelation.StuAnswerText] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.StuAnswerText].ToString().Trim(); //学生回答文本
objcc_ExamPaperStuRelationEN.IsPublish = TransNullToBool(objRow[concc_ExamPaperStuRelation.IsPublish].ToString().Trim()); //是否发布
objcc_ExamPaperStuRelationEN.IsLook = TransNullToBool(objRow[concc_ExamPaperStuRelation.IsLook].ToString().Trim()); //是否查看
objcc_ExamPaperStuRelationEN.IsSave = TransNullToBool(objRow[concc_ExamPaperStuRelation.IsSave].ToString().Trim()); //是否保存
objcc_ExamPaperStuRelationEN.IsSubmit = TransNullToBool(objRow[concc_ExamPaperStuRelation.IsSubmit].ToString().Trim()); //是否提交
objcc_ExamPaperStuRelationEN.ApplySendBackDate = objRow[concc_ExamPaperStuRelation.ApplySendBackDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.ApplySendBackDate].ToString().Trim(); //申请退回日期
objcc_ExamPaperStuRelationEN.IsApplySendBack = TransNullToBool(objRow[concc_ExamPaperStuRelation.IsApplySendBack].ToString().Trim()); //是否申请退回
objcc_ExamPaperStuRelationEN.RealFinishDate = objRow[concc_ExamPaperStuRelation.RealFinishDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.RealFinishDate].ToString().Trim(); //实际完成日期
objcc_ExamPaperStuRelationEN.OperateTime = objRow[concc_ExamPaperStuRelation.OperateTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.OperateTime].ToString().Trim(); //操作时间
objcc_ExamPaperStuRelationEN.Score = objRow[concc_ExamPaperStuRelation.Score] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_ExamPaperStuRelation.Score].ToString().Trim()); //得分
objcc_ExamPaperStuRelationEN.Comment = objRow[concc_ExamPaperStuRelation.Comment] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.Comment].ToString().Trim(); //批注
objcc_ExamPaperStuRelationEN.IsMarking = TransNullToBool(objRow[concc_ExamPaperStuRelation.IsMarking].ToString().Trim()); //是否批阅
objcc_ExamPaperStuRelationEN.MarkerId = objRow[concc_ExamPaperStuRelation.MarkerId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.MarkerId].ToString().Trim(); //打分者
objcc_ExamPaperStuRelationEN.MarkDate = objRow[concc_ExamPaperStuRelation.MarkDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.MarkDate].ToString().Trim(); //打分日期
objcc_ExamPaperStuRelationEN.IsSendBack = TransNullToBool(objRow[concc_ExamPaperStuRelation.IsSendBack].ToString().Trim()); //是否退回
objcc_ExamPaperStuRelationEN.IsInErrorQuestion = TransNullToBool(objRow[concc_ExamPaperStuRelation.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objcc_ExamPaperStuRelationEN.WorkTypeId = objRow[concc_ExamPaperStuRelation.WorkTypeId].ToString().Trim(); //作业类型Id
objcc_ExamPaperStuRelationEN.AnswerIP = objRow[concc_ExamPaperStuRelation.AnswerIP] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerIP].ToString().Trim(); //回答IP
objcc_ExamPaperStuRelationEN.AnswerDate = objRow[concc_ExamPaperStuRelation.AnswerDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerDate].ToString().Trim(); //回答日期
objcc_ExamPaperStuRelationEN.AnswerTime = objRow[concc_ExamPaperStuRelation.AnswerTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerTime].ToString().Trim(); //回答时间
objcc_ExamPaperStuRelationEN.IsRight = TransNullToBool(objRow[concc_ExamPaperStuRelation.IsRight].ToString().Trim()); //是否正确
objcc_ExamPaperStuRelationEN.IsAccessKnowledge = TransNullToBool(objRow[concc_ExamPaperStuRelation.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objcc_ExamPaperStuRelationEN.IsNotProcessTimeout = TransNullToBool(objRow[concc_ExamPaperStuRelation.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objcc_ExamPaperStuRelationEN.SchoolYear = objRow[concc_ExamPaperStuRelation.SchoolYear] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.SchoolYear].ToString().Trim(); //学年
objcc_ExamPaperStuRelationEN.SchoolTerm = objRow[concc_ExamPaperStuRelation.SchoolTerm] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.SchoolTerm].ToString().Trim(); //学期
objcc_ExamPaperStuRelationEN.UpdDate = objRow[concc_ExamPaperStuRelation.UpdDate].ToString().Trim(); //修改日期
objcc_ExamPaperStuRelationEN.UpdUserId = objRow[concc_ExamPaperStuRelation.UpdUserId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.UpdUserId].ToString().Trim(); //修改用户Id
objcc_ExamPaperStuRelationEN.Memo = objRow[concc_ExamPaperStuRelation.Memo] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clscc_ExamPaperStuRelationDA: GetObjLst)", objException.Message));
}
objcc_ExamPaperStuRelationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objcc_ExamPaperStuRelationEN);
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
public List<clscc_ExamPaperStuRelationEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clscc_ExamPaperStuRelationDA:GetObjLstByTabName)", objException.Message));
}
List<clscc_ExamPaperStuRelationEN> arrObjLst = new List<clscc_ExamPaperStuRelationEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperStuRelationDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN = new clscc_ExamPaperStuRelationEN();
try
{
objcc_ExamPaperStuRelationEN.IdExamPaperStuRelation = TransNullToInt(objRow[concc_ExamPaperStuRelation.IdExamPaperStuRelation].ToString().Trim()); //流水号
objcc_ExamPaperStuRelationEN.CourseExamPaperId = objRow[concc_ExamPaperStuRelation.CourseExamPaperId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_ExamPaperStuRelationEN.IdCurrEduCls = objRow[concc_ExamPaperStuRelation.IdCurrEduCls].ToString().Trim(); //教学班流水号
objcc_ExamPaperStuRelationEN.Scores = objRow[concc_ExamPaperStuRelation.Scores] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_ExamPaperStuRelation.Scores].ToString().Trim()); //分值
objcc_ExamPaperStuRelationEN.SpecifyCompletionDate = objRow[concc_ExamPaperStuRelation.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objcc_ExamPaperStuRelationEN.IdStudentInfo = objRow[concc_ExamPaperStuRelation.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_ExamPaperStuRelationEN.AnswerModeId = objRow[concc_ExamPaperStuRelation.AnswerModeId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerModeId].ToString().Trim(); //答案模式Id
objcc_ExamPaperStuRelationEN.AnswerOptionId = objRow[concc_ExamPaperStuRelation.AnswerOptionId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerOptionId].ToString().Trim(); //回答选项Id
objcc_ExamPaperStuRelationEN.AnswerMultiOptions = objRow[concc_ExamPaperStuRelation.AnswerMultiOptions] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerMultiOptions].ToString().Trim(); //多选项答案
objcc_ExamPaperStuRelationEN.StuAnswerText = objRow[concc_ExamPaperStuRelation.StuAnswerText] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.StuAnswerText].ToString().Trim(); //学生回答文本
objcc_ExamPaperStuRelationEN.IsPublish = TransNullToBool(objRow[concc_ExamPaperStuRelation.IsPublish].ToString().Trim()); //是否发布
objcc_ExamPaperStuRelationEN.IsLook = TransNullToBool(objRow[concc_ExamPaperStuRelation.IsLook].ToString().Trim()); //是否查看
objcc_ExamPaperStuRelationEN.IsSave = TransNullToBool(objRow[concc_ExamPaperStuRelation.IsSave].ToString().Trim()); //是否保存
objcc_ExamPaperStuRelationEN.IsSubmit = TransNullToBool(objRow[concc_ExamPaperStuRelation.IsSubmit].ToString().Trim()); //是否提交
objcc_ExamPaperStuRelationEN.ApplySendBackDate = objRow[concc_ExamPaperStuRelation.ApplySendBackDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.ApplySendBackDate].ToString().Trim(); //申请退回日期
objcc_ExamPaperStuRelationEN.IsApplySendBack = TransNullToBool(objRow[concc_ExamPaperStuRelation.IsApplySendBack].ToString().Trim()); //是否申请退回
objcc_ExamPaperStuRelationEN.RealFinishDate = objRow[concc_ExamPaperStuRelation.RealFinishDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.RealFinishDate].ToString().Trim(); //实际完成日期
objcc_ExamPaperStuRelationEN.OperateTime = objRow[concc_ExamPaperStuRelation.OperateTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.OperateTime].ToString().Trim(); //操作时间
objcc_ExamPaperStuRelationEN.Score = objRow[concc_ExamPaperStuRelation.Score] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_ExamPaperStuRelation.Score].ToString().Trim()); //得分
objcc_ExamPaperStuRelationEN.Comment = objRow[concc_ExamPaperStuRelation.Comment] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.Comment].ToString().Trim(); //批注
objcc_ExamPaperStuRelationEN.IsMarking = TransNullToBool(objRow[concc_ExamPaperStuRelation.IsMarking].ToString().Trim()); //是否批阅
objcc_ExamPaperStuRelationEN.MarkerId = objRow[concc_ExamPaperStuRelation.MarkerId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.MarkerId].ToString().Trim(); //打分者
objcc_ExamPaperStuRelationEN.MarkDate = objRow[concc_ExamPaperStuRelation.MarkDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.MarkDate].ToString().Trim(); //打分日期
objcc_ExamPaperStuRelationEN.IsSendBack = TransNullToBool(objRow[concc_ExamPaperStuRelation.IsSendBack].ToString().Trim()); //是否退回
objcc_ExamPaperStuRelationEN.IsInErrorQuestion = TransNullToBool(objRow[concc_ExamPaperStuRelation.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objcc_ExamPaperStuRelationEN.WorkTypeId = objRow[concc_ExamPaperStuRelation.WorkTypeId].ToString().Trim(); //作业类型Id
objcc_ExamPaperStuRelationEN.AnswerIP = objRow[concc_ExamPaperStuRelation.AnswerIP] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerIP].ToString().Trim(); //回答IP
objcc_ExamPaperStuRelationEN.AnswerDate = objRow[concc_ExamPaperStuRelation.AnswerDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerDate].ToString().Trim(); //回答日期
objcc_ExamPaperStuRelationEN.AnswerTime = objRow[concc_ExamPaperStuRelation.AnswerTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerTime].ToString().Trim(); //回答时间
objcc_ExamPaperStuRelationEN.IsRight = TransNullToBool(objRow[concc_ExamPaperStuRelation.IsRight].ToString().Trim()); //是否正确
objcc_ExamPaperStuRelationEN.IsAccessKnowledge = TransNullToBool(objRow[concc_ExamPaperStuRelation.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objcc_ExamPaperStuRelationEN.IsNotProcessTimeout = TransNullToBool(objRow[concc_ExamPaperStuRelation.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objcc_ExamPaperStuRelationEN.SchoolYear = objRow[concc_ExamPaperStuRelation.SchoolYear] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.SchoolYear].ToString().Trim(); //学年
objcc_ExamPaperStuRelationEN.SchoolTerm = objRow[concc_ExamPaperStuRelation.SchoolTerm] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.SchoolTerm].ToString().Trim(); //学期
objcc_ExamPaperStuRelationEN.UpdDate = objRow[concc_ExamPaperStuRelation.UpdDate].ToString().Trim(); //修改日期
objcc_ExamPaperStuRelationEN.UpdUserId = objRow[concc_ExamPaperStuRelation.UpdUserId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.UpdUserId].ToString().Trim(); //修改用户Id
objcc_ExamPaperStuRelationEN.Memo = objRow[concc_ExamPaperStuRelation.Memo] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clscc_ExamPaperStuRelationDA: GetObjLst)", objException.Message));
}
objcc_ExamPaperStuRelationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objcc_ExamPaperStuRelationEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getcc_ExamPaperStuRelation(ref clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperStuRelationDA.GetSpecSQLObj();
strSQL = "Select * from cc_ExamPaperStuRelation where IdExamPaperStuRelation = " + ""+ objcc_ExamPaperStuRelationEN.IdExamPaperStuRelation+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objcc_ExamPaperStuRelationEN.IdExamPaperStuRelation = TransNullToInt(objDT.Rows[0][concc_ExamPaperStuRelation.IdExamPaperStuRelation].ToString().Trim()); //流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objcc_ExamPaperStuRelationEN.CourseExamPaperId = objDT.Rows[0][concc_ExamPaperStuRelation.CourseExamPaperId].ToString().Trim(); //考卷流水号(字段类型:char,字段长度:8,是否可空:True)
 objcc_ExamPaperStuRelationEN.IdCurrEduCls = objDT.Rows[0][concc_ExamPaperStuRelation.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objcc_ExamPaperStuRelationEN.Scores = TransNullToDouble(objDT.Rows[0][concc_ExamPaperStuRelation.Scores].ToString().Trim()); //分值(字段类型:decimal,字段长度:8,是否可空:True)
 objcc_ExamPaperStuRelationEN.SpecifyCompletionDate = objDT.Rows[0][concc_ExamPaperStuRelation.SpecifyCompletionDate].ToString().Trim(); //指定完成日期(字段类型:varchar,字段长度:14,是否可空:False)
 objcc_ExamPaperStuRelationEN.IdStudentInfo = objDT.Rows[0][concc_ExamPaperStuRelation.IdStudentInfo].ToString().Trim(); //学生流水号(字段类型:char,字段长度:8,是否可空:False)
 objcc_ExamPaperStuRelationEN.AnswerModeId = objDT.Rows[0][concc_ExamPaperStuRelation.AnswerModeId].ToString().Trim(); //答案模式Id(字段类型:char,字段长度:4,是否可空:True)
 objcc_ExamPaperStuRelationEN.AnswerOptionId = objDT.Rows[0][concc_ExamPaperStuRelation.AnswerOptionId].ToString().Trim(); //回答选项Id(字段类型:char,字段长度:8,是否可空:True)
 objcc_ExamPaperStuRelationEN.AnswerMultiOptions = objDT.Rows[0][concc_ExamPaperStuRelation.AnswerMultiOptions].ToString().Trim(); //多选项答案(字段类型:varchar,字段长度:300,是否可空:True)
 objcc_ExamPaperStuRelationEN.StuAnswerText = objDT.Rows[0][concc_ExamPaperStuRelation.StuAnswerText].ToString().Trim(); //学生回答文本(字段类型:text,字段长度:2147483647,是否可空:True)
 objcc_ExamPaperStuRelationEN.IsPublish = TransNullToBool(objDT.Rows[0][concc_ExamPaperStuRelation.IsPublish].ToString().Trim()); //是否发布(字段类型:bit,字段长度:1,是否可空:True)
 objcc_ExamPaperStuRelationEN.IsLook = TransNullToBool(objDT.Rows[0][concc_ExamPaperStuRelation.IsLook].ToString().Trim()); //是否查看(字段类型:bit,字段长度:1,是否可空:True)
 objcc_ExamPaperStuRelationEN.IsSave = TransNullToBool(objDT.Rows[0][concc_ExamPaperStuRelation.IsSave].ToString().Trim()); //是否保存(字段类型:bit,字段长度:1,是否可空:True)
 objcc_ExamPaperStuRelationEN.IsSubmit = TransNullToBool(objDT.Rows[0][concc_ExamPaperStuRelation.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objcc_ExamPaperStuRelationEN.ApplySendBackDate = objDT.Rows[0][concc_ExamPaperStuRelation.ApplySendBackDate].ToString().Trim(); //申请退回日期(字段类型:varchar,字段长度:14,是否可空:True)
 objcc_ExamPaperStuRelationEN.IsApplySendBack = TransNullToBool(objDT.Rows[0][concc_ExamPaperStuRelation.IsApplySendBack].ToString().Trim()); //是否申请退回(字段类型:bit,字段长度:1,是否可空:True)
 objcc_ExamPaperStuRelationEN.RealFinishDate = objDT.Rows[0][concc_ExamPaperStuRelation.RealFinishDate].ToString().Trim(); //实际完成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objcc_ExamPaperStuRelationEN.OperateTime = objDT.Rows[0][concc_ExamPaperStuRelation.OperateTime].ToString().Trim(); //操作时间(字段类型:varchar,字段长度:14,是否可空:True)
 objcc_ExamPaperStuRelationEN.Score = TransNullToDouble(objDT.Rows[0][concc_ExamPaperStuRelation.Score].ToString().Trim()); //得分(字段类型:decimal,字段长度:6,是否可空:True)
 objcc_ExamPaperStuRelationEN.Comment = objDT.Rows[0][concc_ExamPaperStuRelation.Comment].ToString().Trim(); //批注(字段类型:text,字段长度:2147483647,是否可空:True)
 objcc_ExamPaperStuRelationEN.IsMarking = TransNullToBool(objDT.Rows[0][concc_ExamPaperStuRelation.IsMarking].ToString().Trim()); //是否批阅(字段类型:bit,字段长度:1,是否可空:True)
 objcc_ExamPaperStuRelationEN.MarkerId = objDT.Rows[0][concc_ExamPaperStuRelation.MarkerId].ToString().Trim(); //打分者(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_ExamPaperStuRelationEN.MarkDate = objDT.Rows[0][concc_ExamPaperStuRelation.MarkDate].ToString().Trim(); //打分日期(字段类型:varchar,字段长度:14,是否可空:True)
 objcc_ExamPaperStuRelationEN.IsSendBack = TransNullToBool(objDT.Rows[0][concc_ExamPaperStuRelation.IsSendBack].ToString().Trim()); //是否退回(字段类型:bit,字段长度:1,是否可空:True)
 objcc_ExamPaperStuRelationEN.IsInErrorQuestion = TransNullToBool(objDT.Rows[0][concc_ExamPaperStuRelation.IsInErrorQuestion].ToString().Trim()); //是否进入错题(字段类型:bit,字段长度:1,是否可空:True)
 objcc_ExamPaperStuRelationEN.WorkTypeId = objDT.Rows[0][concc_ExamPaperStuRelation.WorkTypeId].ToString().Trim(); //作业类型Id(字段类型:char,字段长度:2,是否可空:False)
 objcc_ExamPaperStuRelationEN.AnswerIP = objDT.Rows[0][concc_ExamPaperStuRelation.AnswerIP].ToString().Trim(); //回答IP(字段类型:varchar,字段长度:30,是否可空:True)
 objcc_ExamPaperStuRelationEN.AnswerDate = objDT.Rows[0][concc_ExamPaperStuRelation.AnswerDate].ToString().Trim(); //回答日期(字段类型:varchar,字段长度:8,是否可空:True)
 objcc_ExamPaperStuRelationEN.AnswerTime = objDT.Rows[0][concc_ExamPaperStuRelation.AnswerTime].ToString().Trim(); //回答时间(字段类型:varchar,字段长度:10,是否可空:True)
 objcc_ExamPaperStuRelationEN.IsRight = TransNullToBool(objDT.Rows[0][concc_ExamPaperStuRelation.IsRight].ToString().Trim()); //是否正确(字段类型:bit,字段长度:1,是否可空:True)
 objcc_ExamPaperStuRelationEN.IsAccessKnowledge = TransNullToBool(objDT.Rows[0][concc_ExamPaperStuRelation.IsAccessKnowledge].ToString().Trim()); //是否处理知识点(字段类型:bit,字段长度:1,是否可空:True)
 objcc_ExamPaperStuRelationEN.IsNotProcessTimeout = TransNullToBool(objDT.Rows[0][concc_ExamPaperStuRelation.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时(字段类型:bit,字段长度:1,是否可空:True)
 objcc_ExamPaperStuRelationEN.SchoolYear = objDT.Rows[0][concc_ExamPaperStuRelation.SchoolYear].ToString().Trim(); //学年(字段类型:varchar,字段长度:10,是否可空:True)
 objcc_ExamPaperStuRelationEN.SchoolTerm = objDT.Rows[0][concc_ExamPaperStuRelation.SchoolTerm].ToString().Trim(); //学期(字段类型:char,字段长度:1,是否可空:True)
 objcc_ExamPaperStuRelationEN.UpdDate = objDT.Rows[0][concc_ExamPaperStuRelation.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_ExamPaperStuRelationEN.UpdUserId = objDT.Rows[0][concc_ExamPaperStuRelation.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_ExamPaperStuRelationEN.Memo = objDT.Rows[0][concc_ExamPaperStuRelation.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clscc_ExamPaperStuRelationDA: Getcc_ExamPaperStuRelation)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdExamPaperStuRelation">表关键字</param>
 /// <returns>表对象</returns>
public clscc_ExamPaperStuRelationEN GetObjByIdExamPaperStuRelation(long lngIdExamPaperStuRelation)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperStuRelationDA.GetSpecSQLObj();
strSQL = "Select * from cc_ExamPaperStuRelation where IdExamPaperStuRelation = " + ""+ lngIdExamPaperStuRelation+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN = new clscc_ExamPaperStuRelationEN();
try
{
 objcc_ExamPaperStuRelationEN.IdExamPaperStuRelation = Int32.Parse(objRow[concc_ExamPaperStuRelation.IdExamPaperStuRelation].ToString().Trim()); //流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objcc_ExamPaperStuRelationEN.CourseExamPaperId = objRow[concc_ExamPaperStuRelation.CourseExamPaperId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.CourseExamPaperId].ToString().Trim(); //考卷流水号(字段类型:char,字段长度:8,是否可空:True)
 objcc_ExamPaperStuRelationEN.IdCurrEduCls = objRow[concc_ExamPaperStuRelation.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objcc_ExamPaperStuRelationEN.Scores = objRow[concc_ExamPaperStuRelation.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_ExamPaperStuRelation.Scores].ToString().Trim()); //分值(字段类型:decimal,字段长度:8,是否可空:True)
 objcc_ExamPaperStuRelationEN.SpecifyCompletionDate = objRow[concc_ExamPaperStuRelation.SpecifyCompletionDate].ToString().Trim(); //指定完成日期(字段类型:varchar,字段长度:14,是否可空:False)
 objcc_ExamPaperStuRelationEN.IdStudentInfo = objRow[concc_ExamPaperStuRelation.IdStudentInfo].ToString().Trim(); //学生流水号(字段类型:char,字段长度:8,是否可空:False)
 objcc_ExamPaperStuRelationEN.AnswerModeId = objRow[concc_ExamPaperStuRelation.AnswerModeId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerModeId].ToString().Trim(); //答案模式Id(字段类型:char,字段长度:4,是否可空:True)
 objcc_ExamPaperStuRelationEN.AnswerOptionId = objRow[concc_ExamPaperStuRelation.AnswerOptionId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerOptionId].ToString().Trim(); //回答选项Id(字段类型:char,字段长度:8,是否可空:True)
 objcc_ExamPaperStuRelationEN.AnswerMultiOptions = objRow[concc_ExamPaperStuRelation.AnswerMultiOptions] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerMultiOptions].ToString().Trim(); //多选项答案(字段类型:varchar,字段长度:300,是否可空:True)
 objcc_ExamPaperStuRelationEN.StuAnswerText = objRow[concc_ExamPaperStuRelation.StuAnswerText] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.StuAnswerText].ToString().Trim(); //学生回答文本(字段类型:text,字段长度:2147483647,是否可空:True)
 objcc_ExamPaperStuRelationEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsPublish].ToString().Trim()); //是否发布(字段类型:bit,字段长度:1,是否可空:True)
 objcc_ExamPaperStuRelationEN.IsLook = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsLook].ToString().Trim()); //是否查看(字段类型:bit,字段长度:1,是否可空:True)
 objcc_ExamPaperStuRelationEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsSave].ToString().Trim()); //是否保存(字段类型:bit,字段长度:1,是否可空:True)
 objcc_ExamPaperStuRelationEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objcc_ExamPaperStuRelationEN.ApplySendBackDate = objRow[concc_ExamPaperStuRelation.ApplySendBackDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.ApplySendBackDate].ToString().Trim(); //申请退回日期(字段类型:varchar,字段长度:14,是否可空:True)
 objcc_ExamPaperStuRelationEN.IsApplySendBack = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsApplySendBack].ToString().Trim()); //是否申请退回(字段类型:bit,字段长度:1,是否可空:True)
 objcc_ExamPaperStuRelationEN.RealFinishDate = objRow[concc_ExamPaperStuRelation.RealFinishDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.RealFinishDate].ToString().Trim(); //实际完成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objcc_ExamPaperStuRelationEN.OperateTime = objRow[concc_ExamPaperStuRelation.OperateTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.OperateTime].ToString().Trim(); //操作时间(字段类型:varchar,字段长度:14,是否可空:True)
 objcc_ExamPaperStuRelationEN.Score = objRow[concc_ExamPaperStuRelation.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_ExamPaperStuRelation.Score].ToString().Trim()); //得分(字段类型:decimal,字段长度:6,是否可空:True)
 objcc_ExamPaperStuRelationEN.Comment = objRow[concc_ExamPaperStuRelation.Comment] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.Comment].ToString().Trim(); //批注(字段类型:text,字段长度:2147483647,是否可空:True)
 objcc_ExamPaperStuRelationEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsMarking].ToString().Trim()); //是否批阅(字段类型:bit,字段长度:1,是否可空:True)
 objcc_ExamPaperStuRelationEN.MarkerId = objRow[concc_ExamPaperStuRelation.MarkerId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.MarkerId].ToString().Trim(); //打分者(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_ExamPaperStuRelationEN.MarkDate = objRow[concc_ExamPaperStuRelation.MarkDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.MarkDate].ToString().Trim(); //打分日期(字段类型:varchar,字段长度:14,是否可空:True)
 objcc_ExamPaperStuRelationEN.IsSendBack = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsSendBack].ToString().Trim()); //是否退回(字段类型:bit,字段长度:1,是否可空:True)
 objcc_ExamPaperStuRelationEN.IsInErrorQuestion = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsInErrorQuestion].ToString().Trim()); //是否进入错题(字段类型:bit,字段长度:1,是否可空:True)
 objcc_ExamPaperStuRelationEN.WorkTypeId = objRow[concc_ExamPaperStuRelation.WorkTypeId].ToString().Trim(); //作业类型Id(字段类型:char,字段长度:2,是否可空:False)
 objcc_ExamPaperStuRelationEN.AnswerIP = objRow[concc_ExamPaperStuRelation.AnswerIP] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerIP].ToString().Trim(); //回答IP(字段类型:varchar,字段长度:30,是否可空:True)
 objcc_ExamPaperStuRelationEN.AnswerDate = objRow[concc_ExamPaperStuRelation.AnswerDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerDate].ToString().Trim(); //回答日期(字段类型:varchar,字段长度:8,是否可空:True)
 objcc_ExamPaperStuRelationEN.AnswerTime = objRow[concc_ExamPaperStuRelation.AnswerTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerTime].ToString().Trim(); //回答时间(字段类型:varchar,字段长度:10,是否可空:True)
 objcc_ExamPaperStuRelationEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsRight].ToString().Trim()); //是否正确(字段类型:bit,字段长度:1,是否可空:True)
 objcc_ExamPaperStuRelationEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsAccessKnowledge].ToString().Trim()); //是否处理知识点(字段类型:bit,字段长度:1,是否可空:True)
 objcc_ExamPaperStuRelationEN.IsNotProcessTimeout = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时(字段类型:bit,字段长度:1,是否可空:True)
 objcc_ExamPaperStuRelationEN.SchoolYear = objRow[concc_ExamPaperStuRelation.SchoolYear] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.SchoolYear].ToString().Trim(); //学年(字段类型:varchar,字段长度:10,是否可空:True)
 objcc_ExamPaperStuRelationEN.SchoolTerm = objRow[concc_ExamPaperStuRelation.SchoolTerm] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.SchoolTerm].ToString().Trim(); //学期(字段类型:char,字段长度:1,是否可空:True)
 objcc_ExamPaperStuRelationEN.UpdDate = objRow[concc_ExamPaperStuRelation.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_ExamPaperStuRelationEN.UpdUserId = objRow[concc_ExamPaperStuRelation.UpdUserId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_ExamPaperStuRelationEN.Memo = objRow[concc_ExamPaperStuRelation.Memo] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clscc_ExamPaperStuRelationDA: GetObjByIdExamPaperStuRelation)", objException.Message));
}
return objcc_ExamPaperStuRelationEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clscc_ExamPaperStuRelationEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clscc_ExamPaperStuRelationDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperStuRelationDA.GetSpecSQLObj();
strSQL = "Select * from cc_ExamPaperStuRelation where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN = new clscc_ExamPaperStuRelationEN()
{
IdExamPaperStuRelation = TransNullToInt(objRow[concc_ExamPaperStuRelation.IdExamPaperStuRelation].ToString().Trim()), //流水号
CourseExamPaperId = objRow[concc_ExamPaperStuRelation.CourseExamPaperId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.CourseExamPaperId].ToString().Trim(), //考卷流水号
IdCurrEduCls = objRow[concc_ExamPaperStuRelation.IdCurrEduCls].ToString().Trim(), //教学班流水号
Scores = objRow[concc_ExamPaperStuRelation.Scores] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_ExamPaperStuRelation.Scores].ToString().Trim()), //分值
SpecifyCompletionDate = objRow[concc_ExamPaperStuRelation.SpecifyCompletionDate].ToString().Trim(), //指定完成日期
IdStudentInfo = objRow[concc_ExamPaperStuRelation.IdStudentInfo].ToString().Trim(), //学生流水号
AnswerModeId = objRow[concc_ExamPaperStuRelation.AnswerModeId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerModeId].ToString().Trim(), //答案模式Id
AnswerOptionId = objRow[concc_ExamPaperStuRelation.AnswerOptionId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerOptionId].ToString().Trim(), //回答选项Id
AnswerMultiOptions = objRow[concc_ExamPaperStuRelation.AnswerMultiOptions] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerMultiOptions].ToString().Trim(), //多选项答案
StuAnswerText = objRow[concc_ExamPaperStuRelation.StuAnswerText] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.StuAnswerText].ToString().Trim(), //学生回答文本
IsPublish = TransNullToBool(objRow[concc_ExamPaperStuRelation.IsPublish].ToString().Trim()), //是否发布
IsLook = TransNullToBool(objRow[concc_ExamPaperStuRelation.IsLook].ToString().Trim()), //是否查看
IsSave = TransNullToBool(objRow[concc_ExamPaperStuRelation.IsSave].ToString().Trim()), //是否保存
IsSubmit = TransNullToBool(objRow[concc_ExamPaperStuRelation.IsSubmit].ToString().Trim()), //是否提交
ApplySendBackDate = objRow[concc_ExamPaperStuRelation.ApplySendBackDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.ApplySendBackDate].ToString().Trim(), //申请退回日期
IsApplySendBack = TransNullToBool(objRow[concc_ExamPaperStuRelation.IsApplySendBack].ToString().Trim()), //是否申请退回
RealFinishDate = objRow[concc_ExamPaperStuRelation.RealFinishDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.RealFinishDate].ToString().Trim(), //实际完成日期
OperateTime = objRow[concc_ExamPaperStuRelation.OperateTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.OperateTime].ToString().Trim(), //操作时间
Score = objRow[concc_ExamPaperStuRelation.Score] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_ExamPaperStuRelation.Score].ToString().Trim()), //得分
Comment = objRow[concc_ExamPaperStuRelation.Comment] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.Comment].ToString().Trim(), //批注
IsMarking = TransNullToBool(objRow[concc_ExamPaperStuRelation.IsMarking].ToString().Trim()), //是否批阅
MarkerId = objRow[concc_ExamPaperStuRelation.MarkerId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.MarkerId].ToString().Trim(), //打分者
MarkDate = objRow[concc_ExamPaperStuRelation.MarkDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.MarkDate].ToString().Trim(), //打分日期
IsSendBack = TransNullToBool(objRow[concc_ExamPaperStuRelation.IsSendBack].ToString().Trim()), //是否退回
IsInErrorQuestion = TransNullToBool(objRow[concc_ExamPaperStuRelation.IsInErrorQuestion].ToString().Trim()), //是否进入错题
WorkTypeId = objRow[concc_ExamPaperStuRelation.WorkTypeId].ToString().Trim(), //作业类型Id
AnswerIP = objRow[concc_ExamPaperStuRelation.AnswerIP] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerIP].ToString().Trim(), //回答IP
AnswerDate = objRow[concc_ExamPaperStuRelation.AnswerDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerDate].ToString().Trim(), //回答日期
AnswerTime = objRow[concc_ExamPaperStuRelation.AnswerTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerTime].ToString().Trim(), //回答时间
IsRight = TransNullToBool(objRow[concc_ExamPaperStuRelation.IsRight].ToString().Trim()), //是否正确
IsAccessKnowledge = TransNullToBool(objRow[concc_ExamPaperStuRelation.IsAccessKnowledge].ToString().Trim()), //是否处理知识点
IsNotProcessTimeout = TransNullToBool(objRow[concc_ExamPaperStuRelation.IsNotProcessTimeout].ToString().Trim()), //是否不处理超时
SchoolYear = objRow[concc_ExamPaperStuRelation.SchoolYear] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.SchoolYear].ToString().Trim(), //学年
SchoolTerm = objRow[concc_ExamPaperStuRelation.SchoolTerm] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.SchoolTerm].ToString().Trim(), //学期
UpdDate = objRow[concc_ExamPaperStuRelation.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[concc_ExamPaperStuRelation.UpdUserId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[concc_ExamPaperStuRelation.Memo] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.Memo].ToString().Trim() //备注
};
objcc_ExamPaperStuRelationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcc_ExamPaperStuRelationEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clscc_ExamPaperStuRelationDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clscc_ExamPaperStuRelationEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN = new clscc_ExamPaperStuRelationEN();
try
{
objcc_ExamPaperStuRelationEN.IdExamPaperStuRelation = TransNullToInt(objRow[concc_ExamPaperStuRelation.IdExamPaperStuRelation].ToString().Trim()); //流水号
objcc_ExamPaperStuRelationEN.CourseExamPaperId = objRow[concc_ExamPaperStuRelation.CourseExamPaperId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_ExamPaperStuRelationEN.IdCurrEduCls = objRow[concc_ExamPaperStuRelation.IdCurrEduCls].ToString().Trim(); //教学班流水号
objcc_ExamPaperStuRelationEN.Scores = objRow[concc_ExamPaperStuRelation.Scores] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_ExamPaperStuRelation.Scores].ToString().Trim()); //分值
objcc_ExamPaperStuRelationEN.SpecifyCompletionDate = objRow[concc_ExamPaperStuRelation.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objcc_ExamPaperStuRelationEN.IdStudentInfo = objRow[concc_ExamPaperStuRelation.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_ExamPaperStuRelationEN.AnswerModeId = objRow[concc_ExamPaperStuRelation.AnswerModeId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerModeId].ToString().Trim(); //答案模式Id
objcc_ExamPaperStuRelationEN.AnswerOptionId = objRow[concc_ExamPaperStuRelation.AnswerOptionId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerOptionId].ToString().Trim(); //回答选项Id
objcc_ExamPaperStuRelationEN.AnswerMultiOptions = objRow[concc_ExamPaperStuRelation.AnswerMultiOptions] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerMultiOptions].ToString().Trim(); //多选项答案
objcc_ExamPaperStuRelationEN.StuAnswerText = objRow[concc_ExamPaperStuRelation.StuAnswerText] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.StuAnswerText].ToString().Trim(); //学生回答文本
objcc_ExamPaperStuRelationEN.IsPublish = TransNullToBool(objRow[concc_ExamPaperStuRelation.IsPublish].ToString().Trim()); //是否发布
objcc_ExamPaperStuRelationEN.IsLook = TransNullToBool(objRow[concc_ExamPaperStuRelation.IsLook].ToString().Trim()); //是否查看
objcc_ExamPaperStuRelationEN.IsSave = TransNullToBool(objRow[concc_ExamPaperStuRelation.IsSave].ToString().Trim()); //是否保存
objcc_ExamPaperStuRelationEN.IsSubmit = TransNullToBool(objRow[concc_ExamPaperStuRelation.IsSubmit].ToString().Trim()); //是否提交
objcc_ExamPaperStuRelationEN.ApplySendBackDate = objRow[concc_ExamPaperStuRelation.ApplySendBackDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.ApplySendBackDate].ToString().Trim(); //申请退回日期
objcc_ExamPaperStuRelationEN.IsApplySendBack = TransNullToBool(objRow[concc_ExamPaperStuRelation.IsApplySendBack].ToString().Trim()); //是否申请退回
objcc_ExamPaperStuRelationEN.RealFinishDate = objRow[concc_ExamPaperStuRelation.RealFinishDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.RealFinishDate].ToString().Trim(); //实际完成日期
objcc_ExamPaperStuRelationEN.OperateTime = objRow[concc_ExamPaperStuRelation.OperateTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.OperateTime].ToString().Trim(); //操作时间
objcc_ExamPaperStuRelationEN.Score = objRow[concc_ExamPaperStuRelation.Score] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_ExamPaperStuRelation.Score].ToString().Trim()); //得分
objcc_ExamPaperStuRelationEN.Comment = objRow[concc_ExamPaperStuRelation.Comment] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.Comment].ToString().Trim(); //批注
objcc_ExamPaperStuRelationEN.IsMarking = TransNullToBool(objRow[concc_ExamPaperStuRelation.IsMarking].ToString().Trim()); //是否批阅
objcc_ExamPaperStuRelationEN.MarkerId = objRow[concc_ExamPaperStuRelation.MarkerId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.MarkerId].ToString().Trim(); //打分者
objcc_ExamPaperStuRelationEN.MarkDate = objRow[concc_ExamPaperStuRelation.MarkDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.MarkDate].ToString().Trim(); //打分日期
objcc_ExamPaperStuRelationEN.IsSendBack = TransNullToBool(objRow[concc_ExamPaperStuRelation.IsSendBack].ToString().Trim()); //是否退回
objcc_ExamPaperStuRelationEN.IsInErrorQuestion = TransNullToBool(objRow[concc_ExamPaperStuRelation.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objcc_ExamPaperStuRelationEN.WorkTypeId = objRow[concc_ExamPaperStuRelation.WorkTypeId].ToString().Trim(); //作业类型Id
objcc_ExamPaperStuRelationEN.AnswerIP = objRow[concc_ExamPaperStuRelation.AnswerIP] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerIP].ToString().Trim(); //回答IP
objcc_ExamPaperStuRelationEN.AnswerDate = objRow[concc_ExamPaperStuRelation.AnswerDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerDate].ToString().Trim(); //回答日期
objcc_ExamPaperStuRelationEN.AnswerTime = objRow[concc_ExamPaperStuRelation.AnswerTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerTime].ToString().Trim(); //回答时间
objcc_ExamPaperStuRelationEN.IsRight = TransNullToBool(objRow[concc_ExamPaperStuRelation.IsRight].ToString().Trim()); //是否正确
objcc_ExamPaperStuRelationEN.IsAccessKnowledge = TransNullToBool(objRow[concc_ExamPaperStuRelation.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objcc_ExamPaperStuRelationEN.IsNotProcessTimeout = TransNullToBool(objRow[concc_ExamPaperStuRelation.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objcc_ExamPaperStuRelationEN.SchoolYear = objRow[concc_ExamPaperStuRelation.SchoolYear] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.SchoolYear].ToString().Trim(); //学年
objcc_ExamPaperStuRelationEN.SchoolTerm = objRow[concc_ExamPaperStuRelation.SchoolTerm] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.SchoolTerm].ToString().Trim(); //学期
objcc_ExamPaperStuRelationEN.UpdDate = objRow[concc_ExamPaperStuRelation.UpdDate].ToString().Trim(); //修改日期
objcc_ExamPaperStuRelationEN.UpdUserId = objRow[concc_ExamPaperStuRelation.UpdUserId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.UpdUserId].ToString().Trim(); //修改用户Id
objcc_ExamPaperStuRelationEN.Memo = objRow[concc_ExamPaperStuRelation.Memo] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clscc_ExamPaperStuRelationDA: GetObjByDataRowcc_ExamPaperStuRelation)", objException.Message));
}
objcc_ExamPaperStuRelationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcc_ExamPaperStuRelationEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clscc_ExamPaperStuRelationEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN = new clscc_ExamPaperStuRelationEN();
try
{
objcc_ExamPaperStuRelationEN.IdExamPaperStuRelation = TransNullToInt(objRow[concc_ExamPaperStuRelation.IdExamPaperStuRelation].ToString().Trim()); //流水号
objcc_ExamPaperStuRelationEN.CourseExamPaperId = objRow[concc_ExamPaperStuRelation.CourseExamPaperId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_ExamPaperStuRelationEN.IdCurrEduCls = objRow[concc_ExamPaperStuRelation.IdCurrEduCls].ToString().Trim(); //教学班流水号
objcc_ExamPaperStuRelationEN.Scores = objRow[concc_ExamPaperStuRelation.Scores] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_ExamPaperStuRelation.Scores].ToString().Trim()); //分值
objcc_ExamPaperStuRelationEN.SpecifyCompletionDate = objRow[concc_ExamPaperStuRelation.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objcc_ExamPaperStuRelationEN.IdStudentInfo = objRow[concc_ExamPaperStuRelation.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_ExamPaperStuRelationEN.AnswerModeId = objRow[concc_ExamPaperStuRelation.AnswerModeId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerModeId].ToString().Trim(); //答案模式Id
objcc_ExamPaperStuRelationEN.AnswerOptionId = objRow[concc_ExamPaperStuRelation.AnswerOptionId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerOptionId].ToString().Trim(); //回答选项Id
objcc_ExamPaperStuRelationEN.AnswerMultiOptions = objRow[concc_ExamPaperStuRelation.AnswerMultiOptions] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerMultiOptions].ToString().Trim(); //多选项答案
objcc_ExamPaperStuRelationEN.StuAnswerText = objRow[concc_ExamPaperStuRelation.StuAnswerText] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.StuAnswerText].ToString().Trim(); //学生回答文本
objcc_ExamPaperStuRelationEN.IsPublish = TransNullToBool(objRow[concc_ExamPaperStuRelation.IsPublish].ToString().Trim()); //是否发布
objcc_ExamPaperStuRelationEN.IsLook = TransNullToBool(objRow[concc_ExamPaperStuRelation.IsLook].ToString().Trim()); //是否查看
objcc_ExamPaperStuRelationEN.IsSave = TransNullToBool(objRow[concc_ExamPaperStuRelation.IsSave].ToString().Trim()); //是否保存
objcc_ExamPaperStuRelationEN.IsSubmit = TransNullToBool(objRow[concc_ExamPaperStuRelation.IsSubmit].ToString().Trim()); //是否提交
objcc_ExamPaperStuRelationEN.ApplySendBackDate = objRow[concc_ExamPaperStuRelation.ApplySendBackDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.ApplySendBackDate].ToString().Trim(); //申请退回日期
objcc_ExamPaperStuRelationEN.IsApplySendBack = TransNullToBool(objRow[concc_ExamPaperStuRelation.IsApplySendBack].ToString().Trim()); //是否申请退回
objcc_ExamPaperStuRelationEN.RealFinishDate = objRow[concc_ExamPaperStuRelation.RealFinishDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.RealFinishDate].ToString().Trim(); //实际完成日期
objcc_ExamPaperStuRelationEN.OperateTime = objRow[concc_ExamPaperStuRelation.OperateTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.OperateTime].ToString().Trim(); //操作时间
objcc_ExamPaperStuRelationEN.Score = objRow[concc_ExamPaperStuRelation.Score] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_ExamPaperStuRelation.Score].ToString().Trim()); //得分
objcc_ExamPaperStuRelationEN.Comment = objRow[concc_ExamPaperStuRelation.Comment] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.Comment].ToString().Trim(); //批注
objcc_ExamPaperStuRelationEN.IsMarking = TransNullToBool(objRow[concc_ExamPaperStuRelation.IsMarking].ToString().Trim()); //是否批阅
objcc_ExamPaperStuRelationEN.MarkerId = objRow[concc_ExamPaperStuRelation.MarkerId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.MarkerId].ToString().Trim(); //打分者
objcc_ExamPaperStuRelationEN.MarkDate = objRow[concc_ExamPaperStuRelation.MarkDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.MarkDate].ToString().Trim(); //打分日期
objcc_ExamPaperStuRelationEN.IsSendBack = TransNullToBool(objRow[concc_ExamPaperStuRelation.IsSendBack].ToString().Trim()); //是否退回
objcc_ExamPaperStuRelationEN.IsInErrorQuestion = TransNullToBool(objRow[concc_ExamPaperStuRelation.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objcc_ExamPaperStuRelationEN.WorkTypeId = objRow[concc_ExamPaperStuRelation.WorkTypeId].ToString().Trim(); //作业类型Id
objcc_ExamPaperStuRelationEN.AnswerIP = objRow[concc_ExamPaperStuRelation.AnswerIP] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerIP].ToString().Trim(); //回答IP
objcc_ExamPaperStuRelationEN.AnswerDate = objRow[concc_ExamPaperStuRelation.AnswerDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerDate].ToString().Trim(); //回答日期
objcc_ExamPaperStuRelationEN.AnswerTime = objRow[concc_ExamPaperStuRelation.AnswerTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerTime].ToString().Trim(); //回答时间
objcc_ExamPaperStuRelationEN.IsRight = TransNullToBool(objRow[concc_ExamPaperStuRelation.IsRight].ToString().Trim()); //是否正确
objcc_ExamPaperStuRelationEN.IsAccessKnowledge = TransNullToBool(objRow[concc_ExamPaperStuRelation.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objcc_ExamPaperStuRelationEN.IsNotProcessTimeout = TransNullToBool(objRow[concc_ExamPaperStuRelation.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objcc_ExamPaperStuRelationEN.SchoolYear = objRow[concc_ExamPaperStuRelation.SchoolYear] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.SchoolYear].ToString().Trim(); //学年
objcc_ExamPaperStuRelationEN.SchoolTerm = objRow[concc_ExamPaperStuRelation.SchoolTerm] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.SchoolTerm].ToString().Trim(); //学期
objcc_ExamPaperStuRelationEN.UpdDate = objRow[concc_ExamPaperStuRelation.UpdDate].ToString().Trim(); //修改日期
objcc_ExamPaperStuRelationEN.UpdUserId = objRow[concc_ExamPaperStuRelation.UpdUserId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.UpdUserId].ToString().Trim(); //修改用户Id
objcc_ExamPaperStuRelationEN.Memo = objRow[concc_ExamPaperStuRelation.Memo] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clscc_ExamPaperStuRelationDA: GetObjByDataRow)", objException.Message));
}
objcc_ExamPaperStuRelationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcc_ExamPaperStuRelationEN;
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
objSQL = clscc_ExamPaperStuRelationDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clscc_ExamPaperStuRelationEN._CurrTabName, concc_ExamPaperStuRelation.IdExamPaperStuRelation, 8, "");
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
objSQL = clscc_ExamPaperStuRelationDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clscc_ExamPaperStuRelationEN._CurrTabName, concc_ExamPaperStuRelation.IdExamPaperStuRelation, 8, strPrefix);
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
 objSQL = clscc_ExamPaperStuRelationDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdExamPaperStuRelation from cc_ExamPaperStuRelation where " + strCondition;
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
 objSQL = clscc_ExamPaperStuRelationDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdExamPaperStuRelation from cc_ExamPaperStuRelation where " + strCondition;
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
 /// <param name = "lngIdExamPaperStuRelation">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngIdExamPaperStuRelation)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperStuRelationDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("cc_ExamPaperStuRelation", "IdExamPaperStuRelation = " + ""+ lngIdExamPaperStuRelation+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clscc_ExamPaperStuRelationDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperStuRelationDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("cc_ExamPaperStuRelation", strCondition))
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
objSQL = clscc_ExamPaperStuRelationDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("cc_ExamPaperStuRelation");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN)
 {
 objcc_ExamPaperStuRelationEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_ExamPaperStuRelationEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_ExamPaperStuRelationEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperStuRelationDA.GetSpecSQLObj();
strSQL = "Select * from cc_ExamPaperStuRelation where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "cc_ExamPaperStuRelation");
objRow = objDS.Tables["cc_ExamPaperStuRelation"].NewRow();
 if (objcc_ExamPaperStuRelationEN.CourseExamPaperId !=  "")
 {
objRow[concc_ExamPaperStuRelation.CourseExamPaperId] = objcc_ExamPaperStuRelationEN.CourseExamPaperId; //考卷流水号
 }
objRow[concc_ExamPaperStuRelation.IdCurrEduCls] = objcc_ExamPaperStuRelationEN.IdCurrEduCls; //教学班流水号
objRow[concc_ExamPaperStuRelation.Scores] = objcc_ExamPaperStuRelationEN.Scores; //分值
objRow[concc_ExamPaperStuRelation.SpecifyCompletionDate] = objcc_ExamPaperStuRelationEN.SpecifyCompletionDate; //指定完成日期
objRow[concc_ExamPaperStuRelation.IdStudentInfo] = objcc_ExamPaperStuRelationEN.IdStudentInfo; //学生流水号
 if (objcc_ExamPaperStuRelationEN.AnswerModeId !=  "")
 {
objRow[concc_ExamPaperStuRelation.AnswerModeId] = objcc_ExamPaperStuRelationEN.AnswerModeId; //答案模式Id
 }
 if (objcc_ExamPaperStuRelationEN.AnswerOptionId !=  "")
 {
objRow[concc_ExamPaperStuRelation.AnswerOptionId] = objcc_ExamPaperStuRelationEN.AnswerOptionId; //回答选项Id
 }
 if (objcc_ExamPaperStuRelationEN.AnswerMultiOptions !=  "")
 {
objRow[concc_ExamPaperStuRelation.AnswerMultiOptions] = objcc_ExamPaperStuRelationEN.AnswerMultiOptions; //多选项答案
 }
 if (objcc_ExamPaperStuRelationEN.StuAnswerText !=  "")
 {
objRow[concc_ExamPaperStuRelation.StuAnswerText] = objcc_ExamPaperStuRelationEN.StuAnswerText; //学生回答文本
 }
objRow[concc_ExamPaperStuRelation.IsPublish] = objcc_ExamPaperStuRelationEN.IsPublish; //是否发布
objRow[concc_ExamPaperStuRelation.IsLook] = objcc_ExamPaperStuRelationEN.IsLook; //是否查看
objRow[concc_ExamPaperStuRelation.IsSave] = objcc_ExamPaperStuRelationEN.IsSave; //是否保存
objRow[concc_ExamPaperStuRelation.IsSubmit] = objcc_ExamPaperStuRelationEN.IsSubmit; //是否提交
 if (objcc_ExamPaperStuRelationEN.ApplySendBackDate !=  "")
 {
objRow[concc_ExamPaperStuRelation.ApplySendBackDate] = objcc_ExamPaperStuRelationEN.ApplySendBackDate; //申请退回日期
 }
objRow[concc_ExamPaperStuRelation.IsApplySendBack] = objcc_ExamPaperStuRelationEN.IsApplySendBack; //是否申请退回
 if (objcc_ExamPaperStuRelationEN.RealFinishDate !=  "")
 {
objRow[concc_ExamPaperStuRelation.RealFinishDate] = objcc_ExamPaperStuRelationEN.RealFinishDate; //实际完成日期
 }
 if (objcc_ExamPaperStuRelationEN.OperateTime !=  "")
 {
objRow[concc_ExamPaperStuRelation.OperateTime] = objcc_ExamPaperStuRelationEN.OperateTime; //操作时间
 }
objRow[concc_ExamPaperStuRelation.Score] = objcc_ExamPaperStuRelationEN.Score; //得分
 if (objcc_ExamPaperStuRelationEN.Comment !=  "")
 {
objRow[concc_ExamPaperStuRelation.Comment] = objcc_ExamPaperStuRelationEN.Comment; //批注
 }
objRow[concc_ExamPaperStuRelation.IsMarking] = objcc_ExamPaperStuRelationEN.IsMarking; //是否批阅
 if (objcc_ExamPaperStuRelationEN.MarkerId !=  "")
 {
objRow[concc_ExamPaperStuRelation.MarkerId] = objcc_ExamPaperStuRelationEN.MarkerId; //打分者
 }
 if (objcc_ExamPaperStuRelationEN.MarkDate !=  "")
 {
objRow[concc_ExamPaperStuRelation.MarkDate] = objcc_ExamPaperStuRelationEN.MarkDate; //打分日期
 }
objRow[concc_ExamPaperStuRelation.IsSendBack] = objcc_ExamPaperStuRelationEN.IsSendBack; //是否退回
objRow[concc_ExamPaperStuRelation.IsInErrorQuestion] = objcc_ExamPaperStuRelationEN.IsInErrorQuestion; //是否进入错题
objRow[concc_ExamPaperStuRelation.WorkTypeId] = objcc_ExamPaperStuRelationEN.WorkTypeId; //作业类型Id
 if (objcc_ExamPaperStuRelationEN.AnswerIP !=  "")
 {
objRow[concc_ExamPaperStuRelation.AnswerIP] = objcc_ExamPaperStuRelationEN.AnswerIP; //回答IP
 }
 if (objcc_ExamPaperStuRelationEN.AnswerDate !=  "")
 {
objRow[concc_ExamPaperStuRelation.AnswerDate] = objcc_ExamPaperStuRelationEN.AnswerDate; //回答日期
 }
 if (objcc_ExamPaperStuRelationEN.AnswerTime !=  "")
 {
objRow[concc_ExamPaperStuRelation.AnswerTime] = objcc_ExamPaperStuRelationEN.AnswerTime; //回答时间
 }
objRow[concc_ExamPaperStuRelation.IsRight] = objcc_ExamPaperStuRelationEN.IsRight; //是否正确
objRow[concc_ExamPaperStuRelation.IsAccessKnowledge] = objcc_ExamPaperStuRelationEN.IsAccessKnowledge; //是否处理知识点
objRow[concc_ExamPaperStuRelation.IsNotProcessTimeout] = objcc_ExamPaperStuRelationEN.IsNotProcessTimeout; //是否不处理超时
 if (objcc_ExamPaperStuRelationEN.SchoolYear !=  "")
 {
objRow[concc_ExamPaperStuRelation.SchoolYear] = objcc_ExamPaperStuRelationEN.SchoolYear; //学年
 }
 if (objcc_ExamPaperStuRelationEN.SchoolTerm !=  "")
 {
objRow[concc_ExamPaperStuRelation.SchoolTerm] = objcc_ExamPaperStuRelationEN.SchoolTerm; //学期
 }
objRow[concc_ExamPaperStuRelation.UpdDate] = objcc_ExamPaperStuRelationEN.UpdDate; //修改日期
 if (objcc_ExamPaperStuRelationEN.UpdUserId !=  "")
 {
objRow[concc_ExamPaperStuRelation.UpdUserId] = objcc_ExamPaperStuRelationEN.UpdUserId; //修改用户Id
 }
 if (objcc_ExamPaperStuRelationEN.Memo !=  "")
 {
objRow[concc_ExamPaperStuRelation.Memo] = objcc_ExamPaperStuRelationEN.Memo; //备注
 }
objDS.Tables[clscc_ExamPaperStuRelationEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clscc_ExamPaperStuRelationEN._CurrTabName);
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
 /// <param name = "objcc_ExamPaperStuRelationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN)
{
 objcc_ExamPaperStuRelationEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_ExamPaperStuRelationEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_ExamPaperStuRelationEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objcc_ExamPaperStuRelationEN.CourseExamPaperId  ==  "")
 {
 objcc_ExamPaperStuRelationEN.CourseExamPaperId = null;
 }
 if (objcc_ExamPaperStuRelationEN.CourseExamPaperId !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.CourseExamPaperId);
 var strCourseExamPaperId = objcc_ExamPaperStuRelationEN.CourseExamPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseExamPaperId + "'");
 }
 
 if (objcc_ExamPaperStuRelationEN.IdCurrEduCls  ==  "")
 {
 objcc_ExamPaperStuRelationEN.IdCurrEduCls = null;
 }
 if (objcc_ExamPaperStuRelationEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.IdCurrEduCls);
 var strIdCurrEduCls = objcc_ExamPaperStuRelationEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objcc_ExamPaperStuRelationEN.Scores !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.Scores);
 arrValueListForInsert.Add(objcc_ExamPaperStuRelationEN.Scores.ToString());
 }
 
 if (objcc_ExamPaperStuRelationEN.SpecifyCompletionDate !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.SpecifyCompletionDate);
 var strSpecifyCompletionDate = objcc_ExamPaperStuRelationEN.SpecifyCompletionDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSpecifyCompletionDate + "'");
 }
 
 if (objcc_ExamPaperStuRelationEN.IdStudentInfo  ==  "")
 {
 objcc_ExamPaperStuRelationEN.IdStudentInfo = null;
 }
 if (objcc_ExamPaperStuRelationEN.IdStudentInfo !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.IdStudentInfo);
 var strIdStudentInfo = objcc_ExamPaperStuRelationEN.IdStudentInfo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudentInfo + "'");
 }
 
 if (objcc_ExamPaperStuRelationEN.AnswerModeId !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.AnswerModeId);
 var strAnswerModeId = objcc_ExamPaperStuRelationEN.AnswerModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerModeId + "'");
 }
 
 if (objcc_ExamPaperStuRelationEN.AnswerOptionId !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.AnswerOptionId);
 var strAnswerOptionId = objcc_ExamPaperStuRelationEN.AnswerOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerOptionId + "'");
 }
 
 if (objcc_ExamPaperStuRelationEN.AnswerMultiOptions !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.AnswerMultiOptions);
 var strAnswerMultiOptions = objcc_ExamPaperStuRelationEN.AnswerMultiOptions.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerMultiOptions + "'");
 }
 
 if (objcc_ExamPaperStuRelationEN.StuAnswerText !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.StuAnswerText);
 var strStuAnswerText = objcc_ExamPaperStuRelationEN.StuAnswerText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStuAnswerText + "'");
 }
 
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.IsPublish);
 arrValueListForInsert.Add("'" + (objcc_ExamPaperStuRelationEN.IsPublish  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.IsLook);
 arrValueListForInsert.Add("'" + (objcc_ExamPaperStuRelationEN.IsLook  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.IsSave);
 arrValueListForInsert.Add("'" + (objcc_ExamPaperStuRelationEN.IsSave  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.IsSubmit);
 arrValueListForInsert.Add("'" + (objcc_ExamPaperStuRelationEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objcc_ExamPaperStuRelationEN.ApplySendBackDate !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.ApplySendBackDate);
 var strApplySendBackDate = objcc_ExamPaperStuRelationEN.ApplySendBackDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strApplySendBackDate + "'");
 }
 
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.IsApplySendBack);
 arrValueListForInsert.Add("'" + (objcc_ExamPaperStuRelationEN.IsApplySendBack  ==  false ? "0" : "1") + "'");
 
 if (objcc_ExamPaperStuRelationEN.RealFinishDate !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.RealFinishDate);
 var strRealFinishDate = objcc_ExamPaperStuRelationEN.RealFinishDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRealFinishDate + "'");
 }
 
 if (objcc_ExamPaperStuRelationEN.OperateTime !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.OperateTime);
 var strOperateTime = objcc_ExamPaperStuRelationEN.OperateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOperateTime + "'");
 }
 
 if (objcc_ExamPaperStuRelationEN.Score !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.Score);
 arrValueListForInsert.Add(objcc_ExamPaperStuRelationEN.Score.ToString());
 }
 
 if (objcc_ExamPaperStuRelationEN.Comment !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.Comment);
 var strComment = objcc_ExamPaperStuRelationEN.Comment.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strComment + "'");
 }
 
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.IsMarking);
 arrValueListForInsert.Add("'" + (objcc_ExamPaperStuRelationEN.IsMarking  ==  false ? "0" : "1") + "'");
 
 if (objcc_ExamPaperStuRelationEN.MarkerId !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.MarkerId);
 var strMarkerId = objcc_ExamPaperStuRelationEN.MarkerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMarkerId + "'");
 }
 
 if (objcc_ExamPaperStuRelationEN.MarkDate !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.MarkDate);
 var strMarkDate = objcc_ExamPaperStuRelationEN.MarkDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMarkDate + "'");
 }
 
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.IsSendBack);
 arrValueListForInsert.Add("'" + (objcc_ExamPaperStuRelationEN.IsSendBack  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.IsInErrorQuestion);
 arrValueListForInsert.Add("'" + (objcc_ExamPaperStuRelationEN.IsInErrorQuestion  ==  false ? "0" : "1") + "'");
 
 if (objcc_ExamPaperStuRelationEN.WorkTypeId !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.WorkTypeId);
 var strWorkTypeId = objcc_ExamPaperStuRelationEN.WorkTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWorkTypeId + "'");
 }
 
 if (objcc_ExamPaperStuRelationEN.AnswerIP !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.AnswerIP);
 var strAnswerIP = objcc_ExamPaperStuRelationEN.AnswerIP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerIP + "'");
 }
 
 if (objcc_ExamPaperStuRelationEN.AnswerDate !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.AnswerDate);
 var strAnswerDate = objcc_ExamPaperStuRelationEN.AnswerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerDate + "'");
 }
 
 if (objcc_ExamPaperStuRelationEN.AnswerTime !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.AnswerTime);
 var strAnswerTime = objcc_ExamPaperStuRelationEN.AnswerTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerTime + "'");
 }
 
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.IsRight);
 arrValueListForInsert.Add("'" + (objcc_ExamPaperStuRelationEN.IsRight  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.IsAccessKnowledge);
 arrValueListForInsert.Add("'" + (objcc_ExamPaperStuRelationEN.IsAccessKnowledge  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.IsNotProcessTimeout);
 arrValueListForInsert.Add("'" + (objcc_ExamPaperStuRelationEN.IsNotProcessTimeout  ==  false ? "0" : "1") + "'");
 
 if (objcc_ExamPaperStuRelationEN.SchoolYear !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.SchoolYear);
 var strSchoolYear = objcc_ExamPaperStuRelationEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolYear + "'");
 }
 
 if (objcc_ExamPaperStuRelationEN.SchoolTerm !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.SchoolTerm);
 var strSchoolTerm = objcc_ExamPaperStuRelationEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolTerm + "'");
 }
 
 if (objcc_ExamPaperStuRelationEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.UpdDate);
 var strUpdDate = objcc_ExamPaperStuRelationEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcc_ExamPaperStuRelationEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.UpdUserId);
 var strUpdUserId = objcc_ExamPaperStuRelationEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objcc_ExamPaperStuRelationEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.Memo);
 var strMemo = objcc_ExamPaperStuRelationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_ExamPaperStuRelation");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperStuRelationDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN)
{
 objcc_ExamPaperStuRelationEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_ExamPaperStuRelationEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_ExamPaperStuRelationEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objcc_ExamPaperStuRelationEN.CourseExamPaperId  ==  "")
 {
 objcc_ExamPaperStuRelationEN.CourseExamPaperId = null;
 }
 if (objcc_ExamPaperStuRelationEN.CourseExamPaperId !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.CourseExamPaperId);
 var strCourseExamPaperId = objcc_ExamPaperStuRelationEN.CourseExamPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseExamPaperId + "'");
 }
 
 if (objcc_ExamPaperStuRelationEN.IdCurrEduCls  ==  "")
 {
 objcc_ExamPaperStuRelationEN.IdCurrEduCls = null;
 }
 if (objcc_ExamPaperStuRelationEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.IdCurrEduCls);
 var strIdCurrEduCls = objcc_ExamPaperStuRelationEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objcc_ExamPaperStuRelationEN.Scores !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.Scores);
 arrValueListForInsert.Add(objcc_ExamPaperStuRelationEN.Scores.ToString());
 }
 
 if (objcc_ExamPaperStuRelationEN.SpecifyCompletionDate !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.SpecifyCompletionDate);
 var strSpecifyCompletionDate = objcc_ExamPaperStuRelationEN.SpecifyCompletionDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSpecifyCompletionDate + "'");
 }
 
 if (objcc_ExamPaperStuRelationEN.IdStudentInfo  ==  "")
 {
 objcc_ExamPaperStuRelationEN.IdStudentInfo = null;
 }
 if (objcc_ExamPaperStuRelationEN.IdStudentInfo !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.IdStudentInfo);
 var strIdStudentInfo = objcc_ExamPaperStuRelationEN.IdStudentInfo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudentInfo + "'");
 }
 
 if (objcc_ExamPaperStuRelationEN.AnswerModeId !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.AnswerModeId);
 var strAnswerModeId = objcc_ExamPaperStuRelationEN.AnswerModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerModeId + "'");
 }
 
 if (objcc_ExamPaperStuRelationEN.AnswerOptionId !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.AnswerOptionId);
 var strAnswerOptionId = objcc_ExamPaperStuRelationEN.AnswerOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerOptionId + "'");
 }
 
 if (objcc_ExamPaperStuRelationEN.AnswerMultiOptions !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.AnswerMultiOptions);
 var strAnswerMultiOptions = objcc_ExamPaperStuRelationEN.AnswerMultiOptions.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerMultiOptions + "'");
 }
 
 if (objcc_ExamPaperStuRelationEN.StuAnswerText !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.StuAnswerText);
 var strStuAnswerText = objcc_ExamPaperStuRelationEN.StuAnswerText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStuAnswerText + "'");
 }
 
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.IsPublish);
 arrValueListForInsert.Add("'" + (objcc_ExamPaperStuRelationEN.IsPublish  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.IsLook);
 arrValueListForInsert.Add("'" + (objcc_ExamPaperStuRelationEN.IsLook  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.IsSave);
 arrValueListForInsert.Add("'" + (objcc_ExamPaperStuRelationEN.IsSave  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.IsSubmit);
 arrValueListForInsert.Add("'" + (objcc_ExamPaperStuRelationEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objcc_ExamPaperStuRelationEN.ApplySendBackDate !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.ApplySendBackDate);
 var strApplySendBackDate = objcc_ExamPaperStuRelationEN.ApplySendBackDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strApplySendBackDate + "'");
 }
 
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.IsApplySendBack);
 arrValueListForInsert.Add("'" + (objcc_ExamPaperStuRelationEN.IsApplySendBack  ==  false ? "0" : "1") + "'");
 
 if (objcc_ExamPaperStuRelationEN.RealFinishDate !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.RealFinishDate);
 var strRealFinishDate = objcc_ExamPaperStuRelationEN.RealFinishDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRealFinishDate + "'");
 }
 
 if (objcc_ExamPaperStuRelationEN.OperateTime !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.OperateTime);
 var strOperateTime = objcc_ExamPaperStuRelationEN.OperateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOperateTime + "'");
 }
 
 if (objcc_ExamPaperStuRelationEN.Score !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.Score);
 arrValueListForInsert.Add(objcc_ExamPaperStuRelationEN.Score.ToString());
 }
 
 if (objcc_ExamPaperStuRelationEN.Comment !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.Comment);
 var strComment = objcc_ExamPaperStuRelationEN.Comment.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strComment + "'");
 }
 
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.IsMarking);
 arrValueListForInsert.Add("'" + (objcc_ExamPaperStuRelationEN.IsMarking  ==  false ? "0" : "1") + "'");
 
 if (objcc_ExamPaperStuRelationEN.MarkerId !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.MarkerId);
 var strMarkerId = objcc_ExamPaperStuRelationEN.MarkerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMarkerId + "'");
 }
 
 if (objcc_ExamPaperStuRelationEN.MarkDate !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.MarkDate);
 var strMarkDate = objcc_ExamPaperStuRelationEN.MarkDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMarkDate + "'");
 }
 
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.IsSendBack);
 arrValueListForInsert.Add("'" + (objcc_ExamPaperStuRelationEN.IsSendBack  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.IsInErrorQuestion);
 arrValueListForInsert.Add("'" + (objcc_ExamPaperStuRelationEN.IsInErrorQuestion  ==  false ? "0" : "1") + "'");
 
 if (objcc_ExamPaperStuRelationEN.WorkTypeId !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.WorkTypeId);
 var strWorkTypeId = objcc_ExamPaperStuRelationEN.WorkTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWorkTypeId + "'");
 }
 
 if (objcc_ExamPaperStuRelationEN.AnswerIP !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.AnswerIP);
 var strAnswerIP = objcc_ExamPaperStuRelationEN.AnswerIP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerIP + "'");
 }
 
 if (objcc_ExamPaperStuRelationEN.AnswerDate !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.AnswerDate);
 var strAnswerDate = objcc_ExamPaperStuRelationEN.AnswerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerDate + "'");
 }
 
 if (objcc_ExamPaperStuRelationEN.AnswerTime !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.AnswerTime);
 var strAnswerTime = objcc_ExamPaperStuRelationEN.AnswerTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerTime + "'");
 }
 
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.IsRight);
 arrValueListForInsert.Add("'" + (objcc_ExamPaperStuRelationEN.IsRight  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.IsAccessKnowledge);
 arrValueListForInsert.Add("'" + (objcc_ExamPaperStuRelationEN.IsAccessKnowledge  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.IsNotProcessTimeout);
 arrValueListForInsert.Add("'" + (objcc_ExamPaperStuRelationEN.IsNotProcessTimeout  ==  false ? "0" : "1") + "'");
 
 if (objcc_ExamPaperStuRelationEN.SchoolYear !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.SchoolYear);
 var strSchoolYear = objcc_ExamPaperStuRelationEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolYear + "'");
 }
 
 if (objcc_ExamPaperStuRelationEN.SchoolTerm !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.SchoolTerm);
 var strSchoolTerm = objcc_ExamPaperStuRelationEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolTerm + "'");
 }
 
 if (objcc_ExamPaperStuRelationEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.UpdDate);
 var strUpdDate = objcc_ExamPaperStuRelationEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcc_ExamPaperStuRelationEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.UpdUserId);
 var strUpdUserId = objcc_ExamPaperStuRelationEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objcc_ExamPaperStuRelationEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.Memo);
 var strMemo = objcc_ExamPaperStuRelationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_ExamPaperStuRelation");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperStuRelationDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objcc_ExamPaperStuRelationEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_ExamPaperStuRelationEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_ExamPaperStuRelationEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objcc_ExamPaperStuRelationEN.CourseExamPaperId  ==  "")
 {
 objcc_ExamPaperStuRelationEN.CourseExamPaperId = null;
 }
 if (objcc_ExamPaperStuRelationEN.CourseExamPaperId !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.CourseExamPaperId);
 var strCourseExamPaperId = objcc_ExamPaperStuRelationEN.CourseExamPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseExamPaperId + "'");
 }
 
 if (objcc_ExamPaperStuRelationEN.IdCurrEduCls  ==  "")
 {
 objcc_ExamPaperStuRelationEN.IdCurrEduCls = null;
 }
 if (objcc_ExamPaperStuRelationEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.IdCurrEduCls);
 var strIdCurrEduCls = objcc_ExamPaperStuRelationEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objcc_ExamPaperStuRelationEN.Scores !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.Scores);
 arrValueListForInsert.Add(objcc_ExamPaperStuRelationEN.Scores.ToString());
 }
 
 if (objcc_ExamPaperStuRelationEN.SpecifyCompletionDate !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.SpecifyCompletionDate);
 var strSpecifyCompletionDate = objcc_ExamPaperStuRelationEN.SpecifyCompletionDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSpecifyCompletionDate + "'");
 }
 
 if (objcc_ExamPaperStuRelationEN.IdStudentInfo  ==  "")
 {
 objcc_ExamPaperStuRelationEN.IdStudentInfo = null;
 }
 if (objcc_ExamPaperStuRelationEN.IdStudentInfo !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.IdStudentInfo);
 var strIdStudentInfo = objcc_ExamPaperStuRelationEN.IdStudentInfo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudentInfo + "'");
 }
 
 if (objcc_ExamPaperStuRelationEN.AnswerModeId !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.AnswerModeId);
 var strAnswerModeId = objcc_ExamPaperStuRelationEN.AnswerModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerModeId + "'");
 }
 
 if (objcc_ExamPaperStuRelationEN.AnswerOptionId !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.AnswerOptionId);
 var strAnswerOptionId = objcc_ExamPaperStuRelationEN.AnswerOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerOptionId + "'");
 }
 
 if (objcc_ExamPaperStuRelationEN.AnswerMultiOptions !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.AnswerMultiOptions);
 var strAnswerMultiOptions = objcc_ExamPaperStuRelationEN.AnswerMultiOptions.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerMultiOptions + "'");
 }
 
 if (objcc_ExamPaperStuRelationEN.StuAnswerText !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.StuAnswerText);
 var strStuAnswerText = objcc_ExamPaperStuRelationEN.StuAnswerText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStuAnswerText + "'");
 }
 
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.IsPublish);
 arrValueListForInsert.Add("'" + (objcc_ExamPaperStuRelationEN.IsPublish  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.IsLook);
 arrValueListForInsert.Add("'" + (objcc_ExamPaperStuRelationEN.IsLook  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.IsSave);
 arrValueListForInsert.Add("'" + (objcc_ExamPaperStuRelationEN.IsSave  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.IsSubmit);
 arrValueListForInsert.Add("'" + (objcc_ExamPaperStuRelationEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objcc_ExamPaperStuRelationEN.ApplySendBackDate !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.ApplySendBackDate);
 var strApplySendBackDate = objcc_ExamPaperStuRelationEN.ApplySendBackDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strApplySendBackDate + "'");
 }
 
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.IsApplySendBack);
 arrValueListForInsert.Add("'" + (objcc_ExamPaperStuRelationEN.IsApplySendBack  ==  false ? "0" : "1") + "'");
 
 if (objcc_ExamPaperStuRelationEN.RealFinishDate !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.RealFinishDate);
 var strRealFinishDate = objcc_ExamPaperStuRelationEN.RealFinishDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRealFinishDate + "'");
 }
 
 if (objcc_ExamPaperStuRelationEN.OperateTime !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.OperateTime);
 var strOperateTime = objcc_ExamPaperStuRelationEN.OperateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOperateTime + "'");
 }
 
 if (objcc_ExamPaperStuRelationEN.Score !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.Score);
 arrValueListForInsert.Add(objcc_ExamPaperStuRelationEN.Score.ToString());
 }
 
 if (objcc_ExamPaperStuRelationEN.Comment !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.Comment);
 var strComment = objcc_ExamPaperStuRelationEN.Comment.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strComment + "'");
 }
 
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.IsMarking);
 arrValueListForInsert.Add("'" + (objcc_ExamPaperStuRelationEN.IsMarking  ==  false ? "0" : "1") + "'");
 
 if (objcc_ExamPaperStuRelationEN.MarkerId !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.MarkerId);
 var strMarkerId = objcc_ExamPaperStuRelationEN.MarkerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMarkerId + "'");
 }
 
 if (objcc_ExamPaperStuRelationEN.MarkDate !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.MarkDate);
 var strMarkDate = objcc_ExamPaperStuRelationEN.MarkDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMarkDate + "'");
 }
 
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.IsSendBack);
 arrValueListForInsert.Add("'" + (objcc_ExamPaperStuRelationEN.IsSendBack  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.IsInErrorQuestion);
 arrValueListForInsert.Add("'" + (objcc_ExamPaperStuRelationEN.IsInErrorQuestion  ==  false ? "0" : "1") + "'");
 
 if (objcc_ExamPaperStuRelationEN.WorkTypeId !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.WorkTypeId);
 var strWorkTypeId = objcc_ExamPaperStuRelationEN.WorkTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWorkTypeId + "'");
 }
 
 if (objcc_ExamPaperStuRelationEN.AnswerIP !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.AnswerIP);
 var strAnswerIP = objcc_ExamPaperStuRelationEN.AnswerIP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerIP + "'");
 }
 
 if (objcc_ExamPaperStuRelationEN.AnswerDate !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.AnswerDate);
 var strAnswerDate = objcc_ExamPaperStuRelationEN.AnswerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerDate + "'");
 }
 
 if (objcc_ExamPaperStuRelationEN.AnswerTime !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.AnswerTime);
 var strAnswerTime = objcc_ExamPaperStuRelationEN.AnswerTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerTime + "'");
 }
 
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.IsRight);
 arrValueListForInsert.Add("'" + (objcc_ExamPaperStuRelationEN.IsRight  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.IsAccessKnowledge);
 arrValueListForInsert.Add("'" + (objcc_ExamPaperStuRelationEN.IsAccessKnowledge  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.IsNotProcessTimeout);
 arrValueListForInsert.Add("'" + (objcc_ExamPaperStuRelationEN.IsNotProcessTimeout  ==  false ? "0" : "1") + "'");
 
 if (objcc_ExamPaperStuRelationEN.SchoolYear !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.SchoolYear);
 var strSchoolYear = objcc_ExamPaperStuRelationEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolYear + "'");
 }
 
 if (objcc_ExamPaperStuRelationEN.SchoolTerm !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.SchoolTerm);
 var strSchoolTerm = objcc_ExamPaperStuRelationEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolTerm + "'");
 }
 
 if (objcc_ExamPaperStuRelationEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.UpdDate);
 var strUpdDate = objcc_ExamPaperStuRelationEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcc_ExamPaperStuRelationEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.UpdUserId);
 var strUpdUserId = objcc_ExamPaperStuRelationEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objcc_ExamPaperStuRelationEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.Memo);
 var strMemo = objcc_ExamPaperStuRelationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_ExamPaperStuRelation");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperStuRelationDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objcc_ExamPaperStuRelationEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_ExamPaperStuRelationEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_ExamPaperStuRelationEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objcc_ExamPaperStuRelationEN.CourseExamPaperId  ==  "")
 {
 objcc_ExamPaperStuRelationEN.CourseExamPaperId = null;
 }
 if (objcc_ExamPaperStuRelationEN.CourseExamPaperId !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.CourseExamPaperId);
 var strCourseExamPaperId = objcc_ExamPaperStuRelationEN.CourseExamPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseExamPaperId + "'");
 }
 
 if (objcc_ExamPaperStuRelationEN.IdCurrEduCls  ==  "")
 {
 objcc_ExamPaperStuRelationEN.IdCurrEduCls = null;
 }
 if (objcc_ExamPaperStuRelationEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.IdCurrEduCls);
 var strIdCurrEduCls = objcc_ExamPaperStuRelationEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objcc_ExamPaperStuRelationEN.Scores !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.Scores);
 arrValueListForInsert.Add(objcc_ExamPaperStuRelationEN.Scores.ToString());
 }
 
 if (objcc_ExamPaperStuRelationEN.SpecifyCompletionDate !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.SpecifyCompletionDate);
 var strSpecifyCompletionDate = objcc_ExamPaperStuRelationEN.SpecifyCompletionDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSpecifyCompletionDate + "'");
 }
 
 if (objcc_ExamPaperStuRelationEN.IdStudentInfo  ==  "")
 {
 objcc_ExamPaperStuRelationEN.IdStudentInfo = null;
 }
 if (objcc_ExamPaperStuRelationEN.IdStudentInfo !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.IdStudentInfo);
 var strIdStudentInfo = objcc_ExamPaperStuRelationEN.IdStudentInfo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudentInfo + "'");
 }
 
 if (objcc_ExamPaperStuRelationEN.AnswerModeId !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.AnswerModeId);
 var strAnswerModeId = objcc_ExamPaperStuRelationEN.AnswerModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerModeId + "'");
 }
 
 if (objcc_ExamPaperStuRelationEN.AnswerOptionId !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.AnswerOptionId);
 var strAnswerOptionId = objcc_ExamPaperStuRelationEN.AnswerOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerOptionId + "'");
 }
 
 if (objcc_ExamPaperStuRelationEN.AnswerMultiOptions !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.AnswerMultiOptions);
 var strAnswerMultiOptions = objcc_ExamPaperStuRelationEN.AnswerMultiOptions.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerMultiOptions + "'");
 }
 
 if (objcc_ExamPaperStuRelationEN.StuAnswerText !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.StuAnswerText);
 var strStuAnswerText = objcc_ExamPaperStuRelationEN.StuAnswerText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStuAnswerText + "'");
 }
 
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.IsPublish);
 arrValueListForInsert.Add("'" + (objcc_ExamPaperStuRelationEN.IsPublish  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.IsLook);
 arrValueListForInsert.Add("'" + (objcc_ExamPaperStuRelationEN.IsLook  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.IsSave);
 arrValueListForInsert.Add("'" + (objcc_ExamPaperStuRelationEN.IsSave  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.IsSubmit);
 arrValueListForInsert.Add("'" + (objcc_ExamPaperStuRelationEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objcc_ExamPaperStuRelationEN.ApplySendBackDate !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.ApplySendBackDate);
 var strApplySendBackDate = objcc_ExamPaperStuRelationEN.ApplySendBackDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strApplySendBackDate + "'");
 }
 
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.IsApplySendBack);
 arrValueListForInsert.Add("'" + (objcc_ExamPaperStuRelationEN.IsApplySendBack  ==  false ? "0" : "1") + "'");
 
 if (objcc_ExamPaperStuRelationEN.RealFinishDate !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.RealFinishDate);
 var strRealFinishDate = objcc_ExamPaperStuRelationEN.RealFinishDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRealFinishDate + "'");
 }
 
 if (objcc_ExamPaperStuRelationEN.OperateTime !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.OperateTime);
 var strOperateTime = objcc_ExamPaperStuRelationEN.OperateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOperateTime + "'");
 }
 
 if (objcc_ExamPaperStuRelationEN.Score !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.Score);
 arrValueListForInsert.Add(objcc_ExamPaperStuRelationEN.Score.ToString());
 }
 
 if (objcc_ExamPaperStuRelationEN.Comment !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.Comment);
 var strComment = objcc_ExamPaperStuRelationEN.Comment.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strComment + "'");
 }
 
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.IsMarking);
 arrValueListForInsert.Add("'" + (objcc_ExamPaperStuRelationEN.IsMarking  ==  false ? "0" : "1") + "'");
 
 if (objcc_ExamPaperStuRelationEN.MarkerId !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.MarkerId);
 var strMarkerId = objcc_ExamPaperStuRelationEN.MarkerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMarkerId + "'");
 }
 
 if (objcc_ExamPaperStuRelationEN.MarkDate !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.MarkDate);
 var strMarkDate = objcc_ExamPaperStuRelationEN.MarkDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMarkDate + "'");
 }
 
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.IsSendBack);
 arrValueListForInsert.Add("'" + (objcc_ExamPaperStuRelationEN.IsSendBack  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.IsInErrorQuestion);
 arrValueListForInsert.Add("'" + (objcc_ExamPaperStuRelationEN.IsInErrorQuestion  ==  false ? "0" : "1") + "'");
 
 if (objcc_ExamPaperStuRelationEN.WorkTypeId !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.WorkTypeId);
 var strWorkTypeId = objcc_ExamPaperStuRelationEN.WorkTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWorkTypeId + "'");
 }
 
 if (objcc_ExamPaperStuRelationEN.AnswerIP !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.AnswerIP);
 var strAnswerIP = objcc_ExamPaperStuRelationEN.AnswerIP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerIP + "'");
 }
 
 if (objcc_ExamPaperStuRelationEN.AnswerDate !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.AnswerDate);
 var strAnswerDate = objcc_ExamPaperStuRelationEN.AnswerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerDate + "'");
 }
 
 if (objcc_ExamPaperStuRelationEN.AnswerTime !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.AnswerTime);
 var strAnswerTime = objcc_ExamPaperStuRelationEN.AnswerTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerTime + "'");
 }
 
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.IsRight);
 arrValueListForInsert.Add("'" + (objcc_ExamPaperStuRelationEN.IsRight  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.IsAccessKnowledge);
 arrValueListForInsert.Add("'" + (objcc_ExamPaperStuRelationEN.IsAccessKnowledge  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.IsNotProcessTimeout);
 arrValueListForInsert.Add("'" + (objcc_ExamPaperStuRelationEN.IsNotProcessTimeout  ==  false ? "0" : "1") + "'");
 
 if (objcc_ExamPaperStuRelationEN.SchoolYear !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.SchoolYear);
 var strSchoolYear = objcc_ExamPaperStuRelationEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolYear + "'");
 }
 
 if (objcc_ExamPaperStuRelationEN.SchoolTerm !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.SchoolTerm);
 var strSchoolTerm = objcc_ExamPaperStuRelationEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolTerm + "'");
 }
 
 if (objcc_ExamPaperStuRelationEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.UpdDate);
 var strUpdDate = objcc_ExamPaperStuRelationEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcc_ExamPaperStuRelationEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.UpdUserId);
 var strUpdUserId = objcc_ExamPaperStuRelationEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objcc_ExamPaperStuRelationEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuRelation.Memo);
 var strMemo = objcc_ExamPaperStuRelationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_ExamPaperStuRelation");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperStuRelationDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewcc_ExamPaperStuRelations(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperStuRelationDA.GetSpecSQLObj();
strSQL = "Select * from cc_ExamPaperStuRelation where IdExamPaperStuRelation = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "cc_ExamPaperStuRelation");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngIdExamPaperStuRelation = TransNullToInt(oRow[concc_ExamPaperStuRelation.IdExamPaperStuRelation].ToString().Trim());
if (IsExist(lngIdExamPaperStuRelation))
{
 string strResult = "关键字变量值为:" + string.Format("IdExamPaperStuRelation = {0}", lngIdExamPaperStuRelation) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clscc_ExamPaperStuRelationEN._CurrTabName ].NewRow();
objRow[concc_ExamPaperStuRelation.CourseExamPaperId] = oRow[concc_ExamPaperStuRelation.CourseExamPaperId].ToString().Trim(); //考卷流水号
objRow[concc_ExamPaperStuRelation.IdCurrEduCls] = oRow[concc_ExamPaperStuRelation.IdCurrEduCls].ToString().Trim(); //教学班流水号
objRow[concc_ExamPaperStuRelation.Scores] = oRow[concc_ExamPaperStuRelation.Scores].ToString().Trim(); //分值
objRow[concc_ExamPaperStuRelation.SpecifyCompletionDate] = oRow[concc_ExamPaperStuRelation.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objRow[concc_ExamPaperStuRelation.IdStudentInfo] = oRow[concc_ExamPaperStuRelation.IdStudentInfo].ToString().Trim(); //学生流水号
objRow[concc_ExamPaperStuRelation.AnswerModeId] = oRow[concc_ExamPaperStuRelation.AnswerModeId].ToString().Trim(); //答案模式Id
objRow[concc_ExamPaperStuRelation.AnswerOptionId] = oRow[concc_ExamPaperStuRelation.AnswerOptionId].ToString().Trim(); //回答选项Id
objRow[concc_ExamPaperStuRelation.AnswerMultiOptions] = oRow[concc_ExamPaperStuRelation.AnswerMultiOptions].ToString().Trim(); //多选项答案
objRow[concc_ExamPaperStuRelation.StuAnswerText] = oRow[concc_ExamPaperStuRelation.StuAnswerText].ToString().Trim(); //学生回答文本
objRow[concc_ExamPaperStuRelation.IsPublish] = oRow[concc_ExamPaperStuRelation.IsPublish].ToString().Trim(); //是否发布
objRow[concc_ExamPaperStuRelation.IsLook] = oRow[concc_ExamPaperStuRelation.IsLook].ToString().Trim(); //是否查看
objRow[concc_ExamPaperStuRelation.IsSave] = oRow[concc_ExamPaperStuRelation.IsSave].ToString().Trim(); //是否保存
objRow[concc_ExamPaperStuRelation.IsSubmit] = oRow[concc_ExamPaperStuRelation.IsSubmit].ToString().Trim(); //是否提交
objRow[concc_ExamPaperStuRelation.ApplySendBackDate] = oRow[concc_ExamPaperStuRelation.ApplySendBackDate].ToString().Trim(); //申请退回日期
objRow[concc_ExamPaperStuRelation.IsApplySendBack] = oRow[concc_ExamPaperStuRelation.IsApplySendBack].ToString().Trim(); //是否申请退回
objRow[concc_ExamPaperStuRelation.RealFinishDate] = oRow[concc_ExamPaperStuRelation.RealFinishDate].ToString().Trim(); //实际完成日期
objRow[concc_ExamPaperStuRelation.OperateTime] = oRow[concc_ExamPaperStuRelation.OperateTime].ToString().Trim(); //操作时间
objRow[concc_ExamPaperStuRelation.Score] = oRow[concc_ExamPaperStuRelation.Score].ToString().Trim(); //得分
objRow[concc_ExamPaperStuRelation.Comment] = oRow[concc_ExamPaperStuRelation.Comment].ToString().Trim(); //批注
objRow[concc_ExamPaperStuRelation.IsMarking] = oRow[concc_ExamPaperStuRelation.IsMarking].ToString().Trim(); //是否批阅
objRow[concc_ExamPaperStuRelation.MarkerId] = oRow[concc_ExamPaperStuRelation.MarkerId].ToString().Trim(); //打分者
objRow[concc_ExamPaperStuRelation.MarkDate] = oRow[concc_ExamPaperStuRelation.MarkDate].ToString().Trim(); //打分日期
objRow[concc_ExamPaperStuRelation.IsSendBack] = oRow[concc_ExamPaperStuRelation.IsSendBack].ToString().Trim(); //是否退回
objRow[concc_ExamPaperStuRelation.IsInErrorQuestion] = oRow[concc_ExamPaperStuRelation.IsInErrorQuestion].ToString().Trim(); //是否进入错题
objRow[concc_ExamPaperStuRelation.WorkTypeId] = oRow[concc_ExamPaperStuRelation.WorkTypeId].ToString().Trim(); //作业类型Id
objRow[concc_ExamPaperStuRelation.AnswerIP] = oRow[concc_ExamPaperStuRelation.AnswerIP].ToString().Trim(); //回答IP
objRow[concc_ExamPaperStuRelation.AnswerDate] = oRow[concc_ExamPaperStuRelation.AnswerDate].ToString().Trim(); //回答日期
objRow[concc_ExamPaperStuRelation.AnswerTime] = oRow[concc_ExamPaperStuRelation.AnswerTime].ToString().Trim(); //回答时间
objRow[concc_ExamPaperStuRelation.IsRight] = oRow[concc_ExamPaperStuRelation.IsRight].ToString().Trim(); //是否正确
objRow[concc_ExamPaperStuRelation.IsAccessKnowledge] = oRow[concc_ExamPaperStuRelation.IsAccessKnowledge].ToString().Trim(); //是否处理知识点
objRow[concc_ExamPaperStuRelation.IsNotProcessTimeout] = oRow[concc_ExamPaperStuRelation.IsNotProcessTimeout].ToString().Trim(); //是否不处理超时
objRow[concc_ExamPaperStuRelation.SchoolYear] = oRow[concc_ExamPaperStuRelation.SchoolYear].ToString().Trim(); //学年
objRow[concc_ExamPaperStuRelation.SchoolTerm] = oRow[concc_ExamPaperStuRelation.SchoolTerm].ToString().Trim(); //学期
objRow[concc_ExamPaperStuRelation.UpdDate] = oRow[concc_ExamPaperStuRelation.UpdDate].ToString().Trim(); //修改日期
objRow[concc_ExamPaperStuRelation.UpdUserId] = oRow[concc_ExamPaperStuRelation.UpdUserId].ToString().Trim(); //修改用户Id
objRow[concc_ExamPaperStuRelation.Memo] = oRow[concc_ExamPaperStuRelation.Memo].ToString().Trim(); //备注
 objDS.Tables[clscc_ExamPaperStuRelationEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clscc_ExamPaperStuRelationEN._CurrTabName);
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
 /// <param name = "objcc_ExamPaperStuRelationEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN)
{
 objcc_ExamPaperStuRelationEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_ExamPaperStuRelationEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_ExamPaperStuRelationEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperStuRelationDA.GetSpecSQLObj();
strSQL = "Select * from cc_ExamPaperStuRelation where IdExamPaperStuRelation = " + ""+ objcc_ExamPaperStuRelationEN.IdExamPaperStuRelation+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clscc_ExamPaperStuRelationEN._CurrTabName);
if (objDS.Tables[clscc_ExamPaperStuRelationEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:IdExamPaperStuRelation = " + ""+ objcc_ExamPaperStuRelationEN.IdExamPaperStuRelation+"");
return false;
}
objRow = objDS.Tables[clscc_ExamPaperStuRelationEN._CurrTabName].Rows[0];
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.CourseExamPaperId))
 {
objRow[concc_ExamPaperStuRelation.CourseExamPaperId] = objcc_ExamPaperStuRelationEN.CourseExamPaperId; //考卷流水号
 }
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.IdCurrEduCls))
 {
objRow[concc_ExamPaperStuRelation.IdCurrEduCls] = objcc_ExamPaperStuRelationEN.IdCurrEduCls; //教学班流水号
 }
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.Scores))
 {
objRow[concc_ExamPaperStuRelation.Scores] = objcc_ExamPaperStuRelationEN.Scores; //分值
 }
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.SpecifyCompletionDate))
 {
objRow[concc_ExamPaperStuRelation.SpecifyCompletionDate] = objcc_ExamPaperStuRelationEN.SpecifyCompletionDate; //指定完成日期
 }
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.IdStudentInfo))
 {
objRow[concc_ExamPaperStuRelation.IdStudentInfo] = objcc_ExamPaperStuRelationEN.IdStudentInfo; //学生流水号
 }
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.AnswerModeId))
 {
objRow[concc_ExamPaperStuRelation.AnswerModeId] = objcc_ExamPaperStuRelationEN.AnswerModeId; //答案模式Id
 }
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.AnswerOptionId))
 {
objRow[concc_ExamPaperStuRelation.AnswerOptionId] = objcc_ExamPaperStuRelationEN.AnswerOptionId; //回答选项Id
 }
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.AnswerMultiOptions))
 {
objRow[concc_ExamPaperStuRelation.AnswerMultiOptions] = objcc_ExamPaperStuRelationEN.AnswerMultiOptions; //多选项答案
 }
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.StuAnswerText))
 {
objRow[concc_ExamPaperStuRelation.StuAnswerText] = objcc_ExamPaperStuRelationEN.StuAnswerText; //学生回答文本
 }
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.IsPublish))
 {
objRow[concc_ExamPaperStuRelation.IsPublish] = objcc_ExamPaperStuRelationEN.IsPublish; //是否发布
 }
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.IsLook))
 {
objRow[concc_ExamPaperStuRelation.IsLook] = objcc_ExamPaperStuRelationEN.IsLook; //是否查看
 }
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.IsSave))
 {
objRow[concc_ExamPaperStuRelation.IsSave] = objcc_ExamPaperStuRelationEN.IsSave; //是否保存
 }
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.IsSubmit))
 {
objRow[concc_ExamPaperStuRelation.IsSubmit] = objcc_ExamPaperStuRelationEN.IsSubmit; //是否提交
 }
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.ApplySendBackDate))
 {
objRow[concc_ExamPaperStuRelation.ApplySendBackDate] = objcc_ExamPaperStuRelationEN.ApplySendBackDate; //申请退回日期
 }
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.IsApplySendBack))
 {
objRow[concc_ExamPaperStuRelation.IsApplySendBack] = objcc_ExamPaperStuRelationEN.IsApplySendBack; //是否申请退回
 }
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.RealFinishDate))
 {
objRow[concc_ExamPaperStuRelation.RealFinishDate] = objcc_ExamPaperStuRelationEN.RealFinishDate; //实际完成日期
 }
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.OperateTime))
 {
objRow[concc_ExamPaperStuRelation.OperateTime] = objcc_ExamPaperStuRelationEN.OperateTime; //操作时间
 }
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.Score))
 {
objRow[concc_ExamPaperStuRelation.Score] = objcc_ExamPaperStuRelationEN.Score; //得分
 }
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.Comment))
 {
objRow[concc_ExamPaperStuRelation.Comment] = objcc_ExamPaperStuRelationEN.Comment; //批注
 }
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.IsMarking))
 {
objRow[concc_ExamPaperStuRelation.IsMarking] = objcc_ExamPaperStuRelationEN.IsMarking; //是否批阅
 }
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.MarkerId))
 {
objRow[concc_ExamPaperStuRelation.MarkerId] = objcc_ExamPaperStuRelationEN.MarkerId; //打分者
 }
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.MarkDate))
 {
objRow[concc_ExamPaperStuRelation.MarkDate] = objcc_ExamPaperStuRelationEN.MarkDate; //打分日期
 }
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.IsSendBack))
 {
objRow[concc_ExamPaperStuRelation.IsSendBack] = objcc_ExamPaperStuRelationEN.IsSendBack; //是否退回
 }
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.IsInErrorQuestion))
 {
objRow[concc_ExamPaperStuRelation.IsInErrorQuestion] = objcc_ExamPaperStuRelationEN.IsInErrorQuestion; //是否进入错题
 }
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.WorkTypeId))
 {
objRow[concc_ExamPaperStuRelation.WorkTypeId] = objcc_ExamPaperStuRelationEN.WorkTypeId; //作业类型Id
 }
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.AnswerIP))
 {
objRow[concc_ExamPaperStuRelation.AnswerIP] = objcc_ExamPaperStuRelationEN.AnswerIP; //回答IP
 }
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.AnswerDate))
 {
objRow[concc_ExamPaperStuRelation.AnswerDate] = objcc_ExamPaperStuRelationEN.AnswerDate; //回答日期
 }
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.AnswerTime))
 {
objRow[concc_ExamPaperStuRelation.AnswerTime] = objcc_ExamPaperStuRelationEN.AnswerTime; //回答时间
 }
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.IsRight))
 {
objRow[concc_ExamPaperStuRelation.IsRight] = objcc_ExamPaperStuRelationEN.IsRight; //是否正确
 }
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.IsAccessKnowledge))
 {
objRow[concc_ExamPaperStuRelation.IsAccessKnowledge] = objcc_ExamPaperStuRelationEN.IsAccessKnowledge; //是否处理知识点
 }
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.IsNotProcessTimeout))
 {
objRow[concc_ExamPaperStuRelation.IsNotProcessTimeout] = objcc_ExamPaperStuRelationEN.IsNotProcessTimeout; //是否不处理超时
 }
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.SchoolYear))
 {
objRow[concc_ExamPaperStuRelation.SchoolYear] = objcc_ExamPaperStuRelationEN.SchoolYear; //学年
 }
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.SchoolTerm))
 {
objRow[concc_ExamPaperStuRelation.SchoolTerm] = objcc_ExamPaperStuRelationEN.SchoolTerm; //学期
 }
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.UpdDate))
 {
objRow[concc_ExamPaperStuRelation.UpdDate] = objcc_ExamPaperStuRelationEN.UpdDate; //修改日期
 }
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.UpdUserId))
 {
objRow[concc_ExamPaperStuRelation.UpdUserId] = objcc_ExamPaperStuRelationEN.UpdUserId; //修改用户Id
 }
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.Memo))
 {
objRow[concc_ExamPaperStuRelation.Memo] = objcc_ExamPaperStuRelationEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clscc_ExamPaperStuRelationEN._CurrTabName);
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
 /// <param name = "objcc_ExamPaperStuRelationEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN)
{
 objcc_ExamPaperStuRelationEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_ExamPaperStuRelationEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_ExamPaperStuRelationEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperStuRelationDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update cc_ExamPaperStuRelation Set ");
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.CourseExamPaperId))
 {
 if (objcc_ExamPaperStuRelationEN.CourseExamPaperId  ==  "")
 {
 objcc_ExamPaperStuRelationEN.CourseExamPaperId = null;
 }
 if (objcc_ExamPaperStuRelationEN.CourseExamPaperId !=  null)
 {
 var strCourseExamPaperId = objcc_ExamPaperStuRelationEN.CourseExamPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseExamPaperId, concc_ExamPaperStuRelation.CourseExamPaperId); //考卷流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuRelation.CourseExamPaperId); //考卷流水号
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.IdCurrEduCls))
 {
 if (objcc_ExamPaperStuRelationEN.IdCurrEduCls  ==  "")
 {
 objcc_ExamPaperStuRelationEN.IdCurrEduCls = null;
 }
 if (objcc_ExamPaperStuRelationEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objcc_ExamPaperStuRelationEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, concc_ExamPaperStuRelation.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuRelation.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.Scores))
 {
 if (objcc_ExamPaperStuRelationEN.Scores !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_ExamPaperStuRelationEN.Scores, concc_ExamPaperStuRelation.Scores); //分值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuRelation.Scores); //分值
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.SpecifyCompletionDate))
 {
 if (objcc_ExamPaperStuRelationEN.SpecifyCompletionDate !=  null)
 {
 var strSpecifyCompletionDate = objcc_ExamPaperStuRelationEN.SpecifyCompletionDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSpecifyCompletionDate, concc_ExamPaperStuRelation.SpecifyCompletionDate); //指定完成日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuRelation.SpecifyCompletionDate); //指定完成日期
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.IdStudentInfo))
 {
 if (objcc_ExamPaperStuRelationEN.IdStudentInfo  ==  "")
 {
 objcc_ExamPaperStuRelationEN.IdStudentInfo = null;
 }
 if (objcc_ExamPaperStuRelationEN.IdStudentInfo !=  null)
 {
 var strIdStudentInfo = objcc_ExamPaperStuRelationEN.IdStudentInfo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdStudentInfo, concc_ExamPaperStuRelation.IdStudentInfo); //学生流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuRelation.IdStudentInfo); //学生流水号
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.AnswerModeId))
 {
 if (objcc_ExamPaperStuRelationEN.AnswerModeId !=  null)
 {
 var strAnswerModeId = objcc_ExamPaperStuRelationEN.AnswerModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerModeId, concc_ExamPaperStuRelation.AnswerModeId); //答案模式Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuRelation.AnswerModeId); //答案模式Id
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.AnswerOptionId))
 {
 if (objcc_ExamPaperStuRelationEN.AnswerOptionId !=  null)
 {
 var strAnswerOptionId = objcc_ExamPaperStuRelationEN.AnswerOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerOptionId, concc_ExamPaperStuRelation.AnswerOptionId); //回答选项Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuRelation.AnswerOptionId); //回答选项Id
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.AnswerMultiOptions))
 {
 if (objcc_ExamPaperStuRelationEN.AnswerMultiOptions !=  null)
 {
 var strAnswerMultiOptions = objcc_ExamPaperStuRelationEN.AnswerMultiOptions.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerMultiOptions, concc_ExamPaperStuRelation.AnswerMultiOptions); //多选项答案
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuRelation.AnswerMultiOptions); //多选项答案
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.StuAnswerText))
 {
 if (objcc_ExamPaperStuRelationEN.StuAnswerText !=  null)
 {
 var strStuAnswerText = objcc_ExamPaperStuRelationEN.StuAnswerText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStuAnswerText, concc_ExamPaperStuRelation.StuAnswerText); //学生回答文本
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuRelation.StuAnswerText); //学生回答文本
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.IsPublish))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_ExamPaperStuRelationEN.IsPublish == true?"1":"0", concc_ExamPaperStuRelation.IsPublish); //是否发布
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.IsLook))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_ExamPaperStuRelationEN.IsLook == true?"1":"0", concc_ExamPaperStuRelation.IsLook); //是否查看
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.IsSave))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_ExamPaperStuRelationEN.IsSave == true?"1":"0", concc_ExamPaperStuRelation.IsSave); //是否保存
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_ExamPaperStuRelationEN.IsSubmit == true?"1":"0", concc_ExamPaperStuRelation.IsSubmit); //是否提交
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.ApplySendBackDate))
 {
 if (objcc_ExamPaperStuRelationEN.ApplySendBackDate !=  null)
 {
 var strApplySendBackDate = objcc_ExamPaperStuRelationEN.ApplySendBackDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strApplySendBackDate, concc_ExamPaperStuRelation.ApplySendBackDate); //申请退回日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuRelation.ApplySendBackDate); //申请退回日期
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.IsApplySendBack))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_ExamPaperStuRelationEN.IsApplySendBack == true?"1":"0", concc_ExamPaperStuRelation.IsApplySendBack); //是否申请退回
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.RealFinishDate))
 {
 if (objcc_ExamPaperStuRelationEN.RealFinishDate !=  null)
 {
 var strRealFinishDate = objcc_ExamPaperStuRelationEN.RealFinishDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRealFinishDate, concc_ExamPaperStuRelation.RealFinishDate); //实际完成日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuRelation.RealFinishDate); //实际完成日期
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.OperateTime))
 {
 if (objcc_ExamPaperStuRelationEN.OperateTime !=  null)
 {
 var strOperateTime = objcc_ExamPaperStuRelationEN.OperateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOperateTime, concc_ExamPaperStuRelation.OperateTime); //操作时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuRelation.OperateTime); //操作时间
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.Score))
 {
 if (objcc_ExamPaperStuRelationEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_ExamPaperStuRelationEN.Score, concc_ExamPaperStuRelation.Score); //得分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuRelation.Score); //得分
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.Comment))
 {
 if (objcc_ExamPaperStuRelationEN.Comment !=  null)
 {
 var strComment = objcc_ExamPaperStuRelationEN.Comment.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strComment, concc_ExamPaperStuRelation.Comment); //批注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuRelation.Comment); //批注
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.IsMarking))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_ExamPaperStuRelationEN.IsMarking == true?"1":"0", concc_ExamPaperStuRelation.IsMarking); //是否批阅
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.MarkerId))
 {
 if (objcc_ExamPaperStuRelationEN.MarkerId !=  null)
 {
 var strMarkerId = objcc_ExamPaperStuRelationEN.MarkerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMarkerId, concc_ExamPaperStuRelation.MarkerId); //打分者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuRelation.MarkerId); //打分者
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.MarkDate))
 {
 if (objcc_ExamPaperStuRelationEN.MarkDate !=  null)
 {
 var strMarkDate = objcc_ExamPaperStuRelationEN.MarkDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMarkDate, concc_ExamPaperStuRelation.MarkDate); //打分日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuRelation.MarkDate); //打分日期
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.IsSendBack))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_ExamPaperStuRelationEN.IsSendBack == true?"1":"0", concc_ExamPaperStuRelation.IsSendBack); //是否退回
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.IsInErrorQuestion))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_ExamPaperStuRelationEN.IsInErrorQuestion == true?"1":"0", concc_ExamPaperStuRelation.IsInErrorQuestion); //是否进入错题
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.WorkTypeId))
 {
 if (objcc_ExamPaperStuRelationEN.WorkTypeId !=  null)
 {
 var strWorkTypeId = objcc_ExamPaperStuRelationEN.WorkTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWorkTypeId, concc_ExamPaperStuRelation.WorkTypeId); //作业类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuRelation.WorkTypeId); //作业类型Id
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.AnswerIP))
 {
 if (objcc_ExamPaperStuRelationEN.AnswerIP !=  null)
 {
 var strAnswerIP = objcc_ExamPaperStuRelationEN.AnswerIP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerIP, concc_ExamPaperStuRelation.AnswerIP); //回答IP
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuRelation.AnswerIP); //回答IP
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.AnswerDate))
 {
 if (objcc_ExamPaperStuRelationEN.AnswerDate !=  null)
 {
 var strAnswerDate = objcc_ExamPaperStuRelationEN.AnswerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerDate, concc_ExamPaperStuRelation.AnswerDate); //回答日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuRelation.AnswerDate); //回答日期
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.AnswerTime))
 {
 if (objcc_ExamPaperStuRelationEN.AnswerTime !=  null)
 {
 var strAnswerTime = objcc_ExamPaperStuRelationEN.AnswerTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerTime, concc_ExamPaperStuRelation.AnswerTime); //回答时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuRelation.AnswerTime); //回答时间
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.IsRight))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_ExamPaperStuRelationEN.IsRight == true?"1":"0", concc_ExamPaperStuRelation.IsRight); //是否正确
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.IsAccessKnowledge))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_ExamPaperStuRelationEN.IsAccessKnowledge == true?"1":"0", concc_ExamPaperStuRelation.IsAccessKnowledge); //是否处理知识点
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.IsNotProcessTimeout))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_ExamPaperStuRelationEN.IsNotProcessTimeout == true?"1":"0", concc_ExamPaperStuRelation.IsNotProcessTimeout); //是否不处理超时
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.SchoolYear))
 {
 if (objcc_ExamPaperStuRelationEN.SchoolYear !=  null)
 {
 var strSchoolYear = objcc_ExamPaperStuRelationEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchoolYear, concc_ExamPaperStuRelation.SchoolYear); //学年
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuRelation.SchoolYear); //学年
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.SchoolTerm))
 {
 if (objcc_ExamPaperStuRelationEN.SchoolTerm !=  null)
 {
 var strSchoolTerm = objcc_ExamPaperStuRelationEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchoolTerm, concc_ExamPaperStuRelation.SchoolTerm); //学期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuRelation.SchoolTerm); //学期
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.UpdDate))
 {
 if (objcc_ExamPaperStuRelationEN.UpdDate !=  null)
 {
 var strUpdDate = objcc_ExamPaperStuRelationEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, concc_ExamPaperStuRelation.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuRelation.UpdDate); //修改日期
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.UpdUserId))
 {
 if (objcc_ExamPaperStuRelationEN.UpdUserId !=  null)
 {
 var strUpdUserId = objcc_ExamPaperStuRelationEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, concc_ExamPaperStuRelation.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuRelation.UpdUserId); //修改用户Id
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.Memo))
 {
 if (objcc_ExamPaperStuRelationEN.Memo !=  null)
 {
 var strMemo = objcc_ExamPaperStuRelationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, concc_ExamPaperStuRelation.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuRelation.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdExamPaperStuRelation = {0}", objcc_ExamPaperStuRelationEN.IdExamPaperStuRelation); 
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
 /// <param name = "objcc_ExamPaperStuRelationEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, string strCondition)
{
 objcc_ExamPaperStuRelationEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_ExamPaperStuRelationEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_ExamPaperStuRelationEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperStuRelationDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update cc_ExamPaperStuRelation Set ");
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.CourseExamPaperId))
 {
 if (objcc_ExamPaperStuRelationEN.CourseExamPaperId  ==  "")
 {
 objcc_ExamPaperStuRelationEN.CourseExamPaperId = null;
 }
 if (objcc_ExamPaperStuRelationEN.CourseExamPaperId !=  null)
 {
 var strCourseExamPaperId = objcc_ExamPaperStuRelationEN.CourseExamPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseExamPaperId = '{0}',", strCourseExamPaperId); //考卷流水号
 }
 else
 {
 sbSQL.Append(" CourseExamPaperId = null,"); //考卷流水号
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.IdCurrEduCls))
 {
 if (objcc_ExamPaperStuRelationEN.IdCurrEduCls  ==  "")
 {
 objcc_ExamPaperStuRelationEN.IdCurrEduCls = null;
 }
 if (objcc_ExamPaperStuRelationEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objcc_ExamPaperStuRelationEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.Scores))
 {
 if (objcc_ExamPaperStuRelationEN.Scores !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_ExamPaperStuRelationEN.Scores, concc_ExamPaperStuRelation.Scores); //分值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuRelation.Scores); //分值
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.SpecifyCompletionDate))
 {
 if (objcc_ExamPaperStuRelationEN.SpecifyCompletionDate !=  null)
 {
 var strSpecifyCompletionDate = objcc_ExamPaperStuRelationEN.SpecifyCompletionDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SpecifyCompletionDate = '{0}',", strSpecifyCompletionDate); //指定完成日期
 }
 else
 {
 sbSQL.Append(" SpecifyCompletionDate = null,"); //指定完成日期
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.IdStudentInfo))
 {
 if (objcc_ExamPaperStuRelationEN.IdStudentInfo  ==  "")
 {
 objcc_ExamPaperStuRelationEN.IdStudentInfo = null;
 }
 if (objcc_ExamPaperStuRelationEN.IdStudentInfo !=  null)
 {
 var strIdStudentInfo = objcc_ExamPaperStuRelationEN.IdStudentInfo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdStudentInfo = '{0}',", strIdStudentInfo); //学生流水号
 }
 else
 {
 sbSQL.Append(" IdStudentInfo = null,"); //学生流水号
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.AnswerModeId))
 {
 if (objcc_ExamPaperStuRelationEN.AnswerModeId !=  null)
 {
 var strAnswerModeId = objcc_ExamPaperStuRelationEN.AnswerModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerModeId = '{0}',", strAnswerModeId); //答案模式Id
 }
 else
 {
 sbSQL.Append(" AnswerModeId = null,"); //答案模式Id
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.AnswerOptionId))
 {
 if (objcc_ExamPaperStuRelationEN.AnswerOptionId !=  null)
 {
 var strAnswerOptionId = objcc_ExamPaperStuRelationEN.AnswerOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerOptionId = '{0}',", strAnswerOptionId); //回答选项Id
 }
 else
 {
 sbSQL.Append(" AnswerOptionId = null,"); //回答选项Id
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.AnswerMultiOptions))
 {
 if (objcc_ExamPaperStuRelationEN.AnswerMultiOptions !=  null)
 {
 var strAnswerMultiOptions = objcc_ExamPaperStuRelationEN.AnswerMultiOptions.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerMultiOptions = '{0}',", strAnswerMultiOptions); //多选项答案
 }
 else
 {
 sbSQL.Append(" AnswerMultiOptions = null,"); //多选项答案
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.StuAnswerText))
 {
 if (objcc_ExamPaperStuRelationEN.StuAnswerText !=  null)
 {
 var strStuAnswerText = objcc_ExamPaperStuRelationEN.StuAnswerText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StuAnswerText = '{0}',", strStuAnswerText); //学生回答文本
 }
 else
 {
 sbSQL.Append(" StuAnswerText = null,"); //学生回答文本
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.IsPublish))
 {
 sbSQL.AppendFormat(" IsPublish = '{0}',", objcc_ExamPaperStuRelationEN.IsPublish == true?"1":"0"); //是否发布
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.IsLook))
 {
 sbSQL.AppendFormat(" IsLook = '{0}',", objcc_ExamPaperStuRelationEN.IsLook == true?"1":"0"); //是否查看
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.IsSave))
 {
 sbSQL.AppendFormat(" IsSave = '{0}',", objcc_ExamPaperStuRelationEN.IsSave == true?"1":"0"); //是否保存
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objcc_ExamPaperStuRelationEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.ApplySendBackDate))
 {
 if (objcc_ExamPaperStuRelationEN.ApplySendBackDate !=  null)
 {
 var strApplySendBackDate = objcc_ExamPaperStuRelationEN.ApplySendBackDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ApplySendBackDate = '{0}',", strApplySendBackDate); //申请退回日期
 }
 else
 {
 sbSQL.Append(" ApplySendBackDate = null,"); //申请退回日期
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.IsApplySendBack))
 {
 sbSQL.AppendFormat(" IsApplySendBack = '{0}',", objcc_ExamPaperStuRelationEN.IsApplySendBack == true?"1":"0"); //是否申请退回
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.RealFinishDate))
 {
 if (objcc_ExamPaperStuRelationEN.RealFinishDate !=  null)
 {
 var strRealFinishDate = objcc_ExamPaperStuRelationEN.RealFinishDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RealFinishDate = '{0}',", strRealFinishDate); //实际完成日期
 }
 else
 {
 sbSQL.Append(" RealFinishDate = null,"); //实际完成日期
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.OperateTime))
 {
 if (objcc_ExamPaperStuRelationEN.OperateTime !=  null)
 {
 var strOperateTime = objcc_ExamPaperStuRelationEN.OperateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OperateTime = '{0}',", strOperateTime); //操作时间
 }
 else
 {
 sbSQL.Append(" OperateTime = null,"); //操作时间
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.Score))
 {
 if (objcc_ExamPaperStuRelationEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_ExamPaperStuRelationEN.Score, concc_ExamPaperStuRelation.Score); //得分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuRelation.Score); //得分
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.Comment))
 {
 if (objcc_ExamPaperStuRelationEN.Comment !=  null)
 {
 var strComment = objcc_ExamPaperStuRelationEN.Comment.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Comment = '{0}',", strComment); //批注
 }
 else
 {
 sbSQL.Append(" Comment = null,"); //批注
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.IsMarking))
 {
 sbSQL.AppendFormat(" IsMarking = '{0}',", objcc_ExamPaperStuRelationEN.IsMarking == true?"1":"0"); //是否批阅
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.MarkerId))
 {
 if (objcc_ExamPaperStuRelationEN.MarkerId !=  null)
 {
 var strMarkerId = objcc_ExamPaperStuRelationEN.MarkerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MarkerId = '{0}',", strMarkerId); //打分者
 }
 else
 {
 sbSQL.Append(" MarkerId = null,"); //打分者
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.MarkDate))
 {
 if (objcc_ExamPaperStuRelationEN.MarkDate !=  null)
 {
 var strMarkDate = objcc_ExamPaperStuRelationEN.MarkDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MarkDate = '{0}',", strMarkDate); //打分日期
 }
 else
 {
 sbSQL.Append(" MarkDate = null,"); //打分日期
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.IsSendBack))
 {
 sbSQL.AppendFormat(" IsSendBack = '{0}',", objcc_ExamPaperStuRelationEN.IsSendBack == true?"1":"0"); //是否退回
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.IsInErrorQuestion))
 {
 sbSQL.AppendFormat(" IsInErrorQuestion = '{0}',", objcc_ExamPaperStuRelationEN.IsInErrorQuestion == true?"1":"0"); //是否进入错题
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.WorkTypeId))
 {
 if (objcc_ExamPaperStuRelationEN.WorkTypeId !=  null)
 {
 var strWorkTypeId = objcc_ExamPaperStuRelationEN.WorkTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WorkTypeId = '{0}',", strWorkTypeId); //作业类型Id
 }
 else
 {
 sbSQL.Append(" WorkTypeId = null,"); //作业类型Id
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.AnswerIP))
 {
 if (objcc_ExamPaperStuRelationEN.AnswerIP !=  null)
 {
 var strAnswerIP = objcc_ExamPaperStuRelationEN.AnswerIP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerIP = '{0}',", strAnswerIP); //回答IP
 }
 else
 {
 sbSQL.Append(" AnswerIP = null,"); //回答IP
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.AnswerDate))
 {
 if (objcc_ExamPaperStuRelationEN.AnswerDate !=  null)
 {
 var strAnswerDate = objcc_ExamPaperStuRelationEN.AnswerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerDate = '{0}',", strAnswerDate); //回答日期
 }
 else
 {
 sbSQL.Append(" AnswerDate = null,"); //回答日期
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.AnswerTime))
 {
 if (objcc_ExamPaperStuRelationEN.AnswerTime !=  null)
 {
 var strAnswerTime = objcc_ExamPaperStuRelationEN.AnswerTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerTime = '{0}',", strAnswerTime); //回答时间
 }
 else
 {
 sbSQL.Append(" AnswerTime = null,"); //回答时间
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.IsRight))
 {
 sbSQL.AppendFormat(" IsRight = '{0}',", objcc_ExamPaperStuRelationEN.IsRight == true?"1":"0"); //是否正确
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.IsAccessKnowledge))
 {
 sbSQL.AppendFormat(" IsAccessKnowledge = '{0}',", objcc_ExamPaperStuRelationEN.IsAccessKnowledge == true?"1":"0"); //是否处理知识点
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.IsNotProcessTimeout))
 {
 sbSQL.AppendFormat(" IsNotProcessTimeout = '{0}',", objcc_ExamPaperStuRelationEN.IsNotProcessTimeout == true?"1":"0"); //是否不处理超时
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.SchoolYear))
 {
 if (objcc_ExamPaperStuRelationEN.SchoolYear !=  null)
 {
 var strSchoolYear = objcc_ExamPaperStuRelationEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolYear = '{0}',", strSchoolYear); //学年
 }
 else
 {
 sbSQL.Append(" SchoolYear = null,"); //学年
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.SchoolTerm))
 {
 if (objcc_ExamPaperStuRelationEN.SchoolTerm !=  null)
 {
 var strSchoolTerm = objcc_ExamPaperStuRelationEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolTerm = '{0}',", strSchoolTerm); //学期
 }
 else
 {
 sbSQL.Append(" SchoolTerm = null,"); //学期
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.UpdDate))
 {
 if (objcc_ExamPaperStuRelationEN.UpdDate !=  null)
 {
 var strUpdDate = objcc_ExamPaperStuRelationEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.UpdUserId))
 {
 if (objcc_ExamPaperStuRelationEN.UpdUserId !=  null)
 {
 var strUpdUserId = objcc_ExamPaperStuRelationEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.Memo))
 {
 if (objcc_ExamPaperStuRelationEN.Memo !=  null)
 {
 var strMemo = objcc_ExamPaperStuRelationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objcc_ExamPaperStuRelationEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objcc_ExamPaperStuRelationEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_ExamPaperStuRelationEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_ExamPaperStuRelationEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperStuRelationDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update cc_ExamPaperStuRelation Set ");
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.CourseExamPaperId))
 {
 if (objcc_ExamPaperStuRelationEN.CourseExamPaperId  ==  "")
 {
 objcc_ExamPaperStuRelationEN.CourseExamPaperId = null;
 }
 if (objcc_ExamPaperStuRelationEN.CourseExamPaperId !=  null)
 {
 var strCourseExamPaperId = objcc_ExamPaperStuRelationEN.CourseExamPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseExamPaperId = '{0}',", strCourseExamPaperId); //考卷流水号
 }
 else
 {
 sbSQL.Append(" CourseExamPaperId = null,"); //考卷流水号
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.IdCurrEduCls))
 {
 if (objcc_ExamPaperStuRelationEN.IdCurrEduCls  ==  "")
 {
 objcc_ExamPaperStuRelationEN.IdCurrEduCls = null;
 }
 if (objcc_ExamPaperStuRelationEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objcc_ExamPaperStuRelationEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.Scores))
 {
 if (objcc_ExamPaperStuRelationEN.Scores !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_ExamPaperStuRelationEN.Scores, concc_ExamPaperStuRelation.Scores); //分值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuRelation.Scores); //分值
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.SpecifyCompletionDate))
 {
 if (objcc_ExamPaperStuRelationEN.SpecifyCompletionDate !=  null)
 {
 var strSpecifyCompletionDate = objcc_ExamPaperStuRelationEN.SpecifyCompletionDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SpecifyCompletionDate = '{0}',", strSpecifyCompletionDate); //指定完成日期
 }
 else
 {
 sbSQL.Append(" SpecifyCompletionDate = null,"); //指定完成日期
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.IdStudentInfo))
 {
 if (objcc_ExamPaperStuRelationEN.IdStudentInfo  ==  "")
 {
 objcc_ExamPaperStuRelationEN.IdStudentInfo = null;
 }
 if (objcc_ExamPaperStuRelationEN.IdStudentInfo !=  null)
 {
 var strIdStudentInfo = objcc_ExamPaperStuRelationEN.IdStudentInfo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdStudentInfo = '{0}',", strIdStudentInfo); //学生流水号
 }
 else
 {
 sbSQL.Append(" IdStudentInfo = null,"); //学生流水号
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.AnswerModeId))
 {
 if (objcc_ExamPaperStuRelationEN.AnswerModeId !=  null)
 {
 var strAnswerModeId = objcc_ExamPaperStuRelationEN.AnswerModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerModeId = '{0}',", strAnswerModeId); //答案模式Id
 }
 else
 {
 sbSQL.Append(" AnswerModeId = null,"); //答案模式Id
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.AnswerOptionId))
 {
 if (objcc_ExamPaperStuRelationEN.AnswerOptionId !=  null)
 {
 var strAnswerOptionId = objcc_ExamPaperStuRelationEN.AnswerOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerOptionId = '{0}',", strAnswerOptionId); //回答选项Id
 }
 else
 {
 sbSQL.Append(" AnswerOptionId = null,"); //回答选项Id
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.AnswerMultiOptions))
 {
 if (objcc_ExamPaperStuRelationEN.AnswerMultiOptions !=  null)
 {
 var strAnswerMultiOptions = objcc_ExamPaperStuRelationEN.AnswerMultiOptions.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerMultiOptions = '{0}',", strAnswerMultiOptions); //多选项答案
 }
 else
 {
 sbSQL.Append(" AnswerMultiOptions = null,"); //多选项答案
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.StuAnswerText))
 {
 if (objcc_ExamPaperStuRelationEN.StuAnswerText !=  null)
 {
 var strStuAnswerText = objcc_ExamPaperStuRelationEN.StuAnswerText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StuAnswerText = '{0}',", strStuAnswerText); //学生回答文本
 }
 else
 {
 sbSQL.Append(" StuAnswerText = null,"); //学生回答文本
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.IsPublish))
 {
 sbSQL.AppendFormat(" IsPublish = '{0}',", objcc_ExamPaperStuRelationEN.IsPublish == true?"1":"0"); //是否发布
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.IsLook))
 {
 sbSQL.AppendFormat(" IsLook = '{0}',", objcc_ExamPaperStuRelationEN.IsLook == true?"1":"0"); //是否查看
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.IsSave))
 {
 sbSQL.AppendFormat(" IsSave = '{0}',", objcc_ExamPaperStuRelationEN.IsSave == true?"1":"0"); //是否保存
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objcc_ExamPaperStuRelationEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.ApplySendBackDate))
 {
 if (objcc_ExamPaperStuRelationEN.ApplySendBackDate !=  null)
 {
 var strApplySendBackDate = objcc_ExamPaperStuRelationEN.ApplySendBackDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ApplySendBackDate = '{0}',", strApplySendBackDate); //申请退回日期
 }
 else
 {
 sbSQL.Append(" ApplySendBackDate = null,"); //申请退回日期
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.IsApplySendBack))
 {
 sbSQL.AppendFormat(" IsApplySendBack = '{0}',", objcc_ExamPaperStuRelationEN.IsApplySendBack == true?"1":"0"); //是否申请退回
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.RealFinishDate))
 {
 if (objcc_ExamPaperStuRelationEN.RealFinishDate !=  null)
 {
 var strRealFinishDate = objcc_ExamPaperStuRelationEN.RealFinishDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RealFinishDate = '{0}',", strRealFinishDate); //实际完成日期
 }
 else
 {
 sbSQL.Append(" RealFinishDate = null,"); //实际完成日期
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.OperateTime))
 {
 if (objcc_ExamPaperStuRelationEN.OperateTime !=  null)
 {
 var strOperateTime = objcc_ExamPaperStuRelationEN.OperateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OperateTime = '{0}',", strOperateTime); //操作时间
 }
 else
 {
 sbSQL.Append(" OperateTime = null,"); //操作时间
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.Score))
 {
 if (objcc_ExamPaperStuRelationEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_ExamPaperStuRelationEN.Score, concc_ExamPaperStuRelation.Score); //得分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuRelation.Score); //得分
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.Comment))
 {
 if (objcc_ExamPaperStuRelationEN.Comment !=  null)
 {
 var strComment = objcc_ExamPaperStuRelationEN.Comment.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Comment = '{0}',", strComment); //批注
 }
 else
 {
 sbSQL.Append(" Comment = null,"); //批注
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.IsMarking))
 {
 sbSQL.AppendFormat(" IsMarking = '{0}',", objcc_ExamPaperStuRelationEN.IsMarking == true?"1":"0"); //是否批阅
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.MarkerId))
 {
 if (objcc_ExamPaperStuRelationEN.MarkerId !=  null)
 {
 var strMarkerId = objcc_ExamPaperStuRelationEN.MarkerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MarkerId = '{0}',", strMarkerId); //打分者
 }
 else
 {
 sbSQL.Append(" MarkerId = null,"); //打分者
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.MarkDate))
 {
 if (objcc_ExamPaperStuRelationEN.MarkDate !=  null)
 {
 var strMarkDate = objcc_ExamPaperStuRelationEN.MarkDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MarkDate = '{0}',", strMarkDate); //打分日期
 }
 else
 {
 sbSQL.Append(" MarkDate = null,"); //打分日期
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.IsSendBack))
 {
 sbSQL.AppendFormat(" IsSendBack = '{0}',", objcc_ExamPaperStuRelationEN.IsSendBack == true?"1":"0"); //是否退回
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.IsInErrorQuestion))
 {
 sbSQL.AppendFormat(" IsInErrorQuestion = '{0}',", objcc_ExamPaperStuRelationEN.IsInErrorQuestion == true?"1":"0"); //是否进入错题
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.WorkTypeId))
 {
 if (objcc_ExamPaperStuRelationEN.WorkTypeId !=  null)
 {
 var strWorkTypeId = objcc_ExamPaperStuRelationEN.WorkTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WorkTypeId = '{0}',", strWorkTypeId); //作业类型Id
 }
 else
 {
 sbSQL.Append(" WorkTypeId = null,"); //作业类型Id
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.AnswerIP))
 {
 if (objcc_ExamPaperStuRelationEN.AnswerIP !=  null)
 {
 var strAnswerIP = objcc_ExamPaperStuRelationEN.AnswerIP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerIP = '{0}',", strAnswerIP); //回答IP
 }
 else
 {
 sbSQL.Append(" AnswerIP = null,"); //回答IP
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.AnswerDate))
 {
 if (objcc_ExamPaperStuRelationEN.AnswerDate !=  null)
 {
 var strAnswerDate = objcc_ExamPaperStuRelationEN.AnswerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerDate = '{0}',", strAnswerDate); //回答日期
 }
 else
 {
 sbSQL.Append(" AnswerDate = null,"); //回答日期
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.AnswerTime))
 {
 if (objcc_ExamPaperStuRelationEN.AnswerTime !=  null)
 {
 var strAnswerTime = objcc_ExamPaperStuRelationEN.AnswerTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerTime = '{0}',", strAnswerTime); //回答时间
 }
 else
 {
 sbSQL.Append(" AnswerTime = null,"); //回答时间
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.IsRight))
 {
 sbSQL.AppendFormat(" IsRight = '{0}',", objcc_ExamPaperStuRelationEN.IsRight == true?"1":"0"); //是否正确
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.IsAccessKnowledge))
 {
 sbSQL.AppendFormat(" IsAccessKnowledge = '{0}',", objcc_ExamPaperStuRelationEN.IsAccessKnowledge == true?"1":"0"); //是否处理知识点
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.IsNotProcessTimeout))
 {
 sbSQL.AppendFormat(" IsNotProcessTimeout = '{0}',", objcc_ExamPaperStuRelationEN.IsNotProcessTimeout == true?"1":"0"); //是否不处理超时
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.SchoolYear))
 {
 if (objcc_ExamPaperStuRelationEN.SchoolYear !=  null)
 {
 var strSchoolYear = objcc_ExamPaperStuRelationEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolYear = '{0}',", strSchoolYear); //学年
 }
 else
 {
 sbSQL.Append(" SchoolYear = null,"); //学年
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.SchoolTerm))
 {
 if (objcc_ExamPaperStuRelationEN.SchoolTerm !=  null)
 {
 var strSchoolTerm = objcc_ExamPaperStuRelationEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolTerm = '{0}',", strSchoolTerm); //学期
 }
 else
 {
 sbSQL.Append(" SchoolTerm = null,"); //学期
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.UpdDate))
 {
 if (objcc_ExamPaperStuRelationEN.UpdDate !=  null)
 {
 var strUpdDate = objcc_ExamPaperStuRelationEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.UpdUserId))
 {
 if (objcc_ExamPaperStuRelationEN.UpdUserId !=  null)
 {
 var strUpdUserId = objcc_ExamPaperStuRelationEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.Memo))
 {
 if (objcc_ExamPaperStuRelationEN.Memo !=  null)
 {
 var strMemo = objcc_ExamPaperStuRelationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objcc_ExamPaperStuRelationEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objcc_ExamPaperStuRelationEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_ExamPaperStuRelationEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_ExamPaperStuRelationEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperStuRelationDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update cc_ExamPaperStuRelation Set ");
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.CourseExamPaperId))
 {
 if (objcc_ExamPaperStuRelationEN.CourseExamPaperId  ==  "")
 {
 objcc_ExamPaperStuRelationEN.CourseExamPaperId = null;
 }
 if (objcc_ExamPaperStuRelationEN.CourseExamPaperId !=  null)
 {
 var strCourseExamPaperId = objcc_ExamPaperStuRelationEN.CourseExamPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseExamPaperId, concc_ExamPaperStuRelation.CourseExamPaperId); //考卷流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuRelation.CourseExamPaperId); //考卷流水号
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.IdCurrEduCls))
 {
 if (objcc_ExamPaperStuRelationEN.IdCurrEduCls  ==  "")
 {
 objcc_ExamPaperStuRelationEN.IdCurrEduCls = null;
 }
 if (objcc_ExamPaperStuRelationEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objcc_ExamPaperStuRelationEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, concc_ExamPaperStuRelation.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuRelation.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.Scores))
 {
 if (objcc_ExamPaperStuRelationEN.Scores !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_ExamPaperStuRelationEN.Scores, concc_ExamPaperStuRelation.Scores); //分值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuRelation.Scores); //分值
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.SpecifyCompletionDate))
 {
 if (objcc_ExamPaperStuRelationEN.SpecifyCompletionDate !=  null)
 {
 var strSpecifyCompletionDate = objcc_ExamPaperStuRelationEN.SpecifyCompletionDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSpecifyCompletionDate, concc_ExamPaperStuRelation.SpecifyCompletionDate); //指定完成日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuRelation.SpecifyCompletionDate); //指定完成日期
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.IdStudentInfo))
 {
 if (objcc_ExamPaperStuRelationEN.IdStudentInfo  ==  "")
 {
 objcc_ExamPaperStuRelationEN.IdStudentInfo = null;
 }
 if (objcc_ExamPaperStuRelationEN.IdStudentInfo !=  null)
 {
 var strIdStudentInfo = objcc_ExamPaperStuRelationEN.IdStudentInfo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdStudentInfo, concc_ExamPaperStuRelation.IdStudentInfo); //学生流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuRelation.IdStudentInfo); //学生流水号
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.AnswerModeId))
 {
 if (objcc_ExamPaperStuRelationEN.AnswerModeId !=  null)
 {
 var strAnswerModeId = objcc_ExamPaperStuRelationEN.AnswerModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerModeId, concc_ExamPaperStuRelation.AnswerModeId); //答案模式Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuRelation.AnswerModeId); //答案模式Id
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.AnswerOptionId))
 {
 if (objcc_ExamPaperStuRelationEN.AnswerOptionId !=  null)
 {
 var strAnswerOptionId = objcc_ExamPaperStuRelationEN.AnswerOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerOptionId, concc_ExamPaperStuRelation.AnswerOptionId); //回答选项Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuRelation.AnswerOptionId); //回答选项Id
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.AnswerMultiOptions))
 {
 if (objcc_ExamPaperStuRelationEN.AnswerMultiOptions !=  null)
 {
 var strAnswerMultiOptions = objcc_ExamPaperStuRelationEN.AnswerMultiOptions.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerMultiOptions, concc_ExamPaperStuRelation.AnswerMultiOptions); //多选项答案
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuRelation.AnswerMultiOptions); //多选项答案
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.StuAnswerText))
 {
 if (objcc_ExamPaperStuRelationEN.StuAnswerText !=  null)
 {
 var strStuAnswerText = objcc_ExamPaperStuRelationEN.StuAnswerText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStuAnswerText, concc_ExamPaperStuRelation.StuAnswerText); //学生回答文本
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuRelation.StuAnswerText); //学生回答文本
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.IsPublish))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_ExamPaperStuRelationEN.IsPublish == true?"1":"0", concc_ExamPaperStuRelation.IsPublish); //是否发布
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.IsLook))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_ExamPaperStuRelationEN.IsLook == true?"1":"0", concc_ExamPaperStuRelation.IsLook); //是否查看
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.IsSave))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_ExamPaperStuRelationEN.IsSave == true?"1":"0", concc_ExamPaperStuRelation.IsSave); //是否保存
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_ExamPaperStuRelationEN.IsSubmit == true?"1":"0", concc_ExamPaperStuRelation.IsSubmit); //是否提交
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.ApplySendBackDate))
 {
 if (objcc_ExamPaperStuRelationEN.ApplySendBackDate !=  null)
 {
 var strApplySendBackDate = objcc_ExamPaperStuRelationEN.ApplySendBackDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strApplySendBackDate, concc_ExamPaperStuRelation.ApplySendBackDate); //申请退回日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuRelation.ApplySendBackDate); //申请退回日期
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.IsApplySendBack))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_ExamPaperStuRelationEN.IsApplySendBack == true?"1":"0", concc_ExamPaperStuRelation.IsApplySendBack); //是否申请退回
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.RealFinishDate))
 {
 if (objcc_ExamPaperStuRelationEN.RealFinishDate !=  null)
 {
 var strRealFinishDate = objcc_ExamPaperStuRelationEN.RealFinishDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRealFinishDate, concc_ExamPaperStuRelation.RealFinishDate); //实际完成日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuRelation.RealFinishDate); //实际完成日期
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.OperateTime))
 {
 if (objcc_ExamPaperStuRelationEN.OperateTime !=  null)
 {
 var strOperateTime = objcc_ExamPaperStuRelationEN.OperateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOperateTime, concc_ExamPaperStuRelation.OperateTime); //操作时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuRelation.OperateTime); //操作时间
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.Score))
 {
 if (objcc_ExamPaperStuRelationEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_ExamPaperStuRelationEN.Score, concc_ExamPaperStuRelation.Score); //得分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuRelation.Score); //得分
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.Comment))
 {
 if (objcc_ExamPaperStuRelationEN.Comment !=  null)
 {
 var strComment = objcc_ExamPaperStuRelationEN.Comment.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strComment, concc_ExamPaperStuRelation.Comment); //批注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuRelation.Comment); //批注
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.IsMarking))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_ExamPaperStuRelationEN.IsMarking == true?"1":"0", concc_ExamPaperStuRelation.IsMarking); //是否批阅
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.MarkerId))
 {
 if (objcc_ExamPaperStuRelationEN.MarkerId !=  null)
 {
 var strMarkerId = objcc_ExamPaperStuRelationEN.MarkerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMarkerId, concc_ExamPaperStuRelation.MarkerId); //打分者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuRelation.MarkerId); //打分者
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.MarkDate))
 {
 if (objcc_ExamPaperStuRelationEN.MarkDate !=  null)
 {
 var strMarkDate = objcc_ExamPaperStuRelationEN.MarkDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMarkDate, concc_ExamPaperStuRelation.MarkDate); //打分日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuRelation.MarkDate); //打分日期
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.IsSendBack))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_ExamPaperStuRelationEN.IsSendBack == true?"1":"0", concc_ExamPaperStuRelation.IsSendBack); //是否退回
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.IsInErrorQuestion))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_ExamPaperStuRelationEN.IsInErrorQuestion == true?"1":"0", concc_ExamPaperStuRelation.IsInErrorQuestion); //是否进入错题
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.WorkTypeId))
 {
 if (objcc_ExamPaperStuRelationEN.WorkTypeId !=  null)
 {
 var strWorkTypeId = objcc_ExamPaperStuRelationEN.WorkTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWorkTypeId, concc_ExamPaperStuRelation.WorkTypeId); //作业类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuRelation.WorkTypeId); //作业类型Id
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.AnswerIP))
 {
 if (objcc_ExamPaperStuRelationEN.AnswerIP !=  null)
 {
 var strAnswerIP = objcc_ExamPaperStuRelationEN.AnswerIP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerIP, concc_ExamPaperStuRelation.AnswerIP); //回答IP
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuRelation.AnswerIP); //回答IP
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.AnswerDate))
 {
 if (objcc_ExamPaperStuRelationEN.AnswerDate !=  null)
 {
 var strAnswerDate = objcc_ExamPaperStuRelationEN.AnswerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerDate, concc_ExamPaperStuRelation.AnswerDate); //回答日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuRelation.AnswerDate); //回答日期
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.AnswerTime))
 {
 if (objcc_ExamPaperStuRelationEN.AnswerTime !=  null)
 {
 var strAnswerTime = objcc_ExamPaperStuRelationEN.AnswerTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerTime, concc_ExamPaperStuRelation.AnswerTime); //回答时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuRelation.AnswerTime); //回答时间
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.IsRight))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_ExamPaperStuRelationEN.IsRight == true?"1":"0", concc_ExamPaperStuRelation.IsRight); //是否正确
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.IsAccessKnowledge))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_ExamPaperStuRelationEN.IsAccessKnowledge == true?"1":"0", concc_ExamPaperStuRelation.IsAccessKnowledge); //是否处理知识点
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.IsNotProcessTimeout))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_ExamPaperStuRelationEN.IsNotProcessTimeout == true?"1":"0", concc_ExamPaperStuRelation.IsNotProcessTimeout); //是否不处理超时
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.SchoolYear))
 {
 if (objcc_ExamPaperStuRelationEN.SchoolYear !=  null)
 {
 var strSchoolYear = objcc_ExamPaperStuRelationEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchoolYear, concc_ExamPaperStuRelation.SchoolYear); //学年
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuRelation.SchoolYear); //学年
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.SchoolTerm))
 {
 if (objcc_ExamPaperStuRelationEN.SchoolTerm !=  null)
 {
 var strSchoolTerm = objcc_ExamPaperStuRelationEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchoolTerm, concc_ExamPaperStuRelation.SchoolTerm); //学期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuRelation.SchoolTerm); //学期
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.UpdDate))
 {
 if (objcc_ExamPaperStuRelationEN.UpdDate !=  null)
 {
 var strUpdDate = objcc_ExamPaperStuRelationEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, concc_ExamPaperStuRelation.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuRelation.UpdDate); //修改日期
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.UpdUserId))
 {
 if (objcc_ExamPaperStuRelationEN.UpdUserId !=  null)
 {
 var strUpdUserId = objcc_ExamPaperStuRelationEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, concc_ExamPaperStuRelation.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuRelation.UpdUserId); //修改用户Id
 }
 }
 
 if (objcc_ExamPaperStuRelationEN.IsUpdated(concc_ExamPaperStuRelation.Memo))
 {
 if (objcc_ExamPaperStuRelationEN.Memo !=  null)
 {
 var strMemo = objcc_ExamPaperStuRelationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, concc_ExamPaperStuRelation.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuRelation.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdExamPaperStuRelation = {0}", objcc_ExamPaperStuRelationEN.IdExamPaperStuRelation); 
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
 /// <param name = "lngIdExamPaperStuRelation">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngIdExamPaperStuRelation) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperStuRelationDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngIdExamPaperStuRelation,
};
 objSQL.ExecSP("cc_ExamPaperStuRelation_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngIdExamPaperStuRelation">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngIdExamPaperStuRelation, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperStuRelationDA.GetSpecSQLObj();
//删除cc_ExamPaperStuRelation本表中与当前对象有关的记录
strSQL = strSQL + "Delete from cc_ExamPaperStuRelation where IdExamPaperStuRelation = " + ""+ lngIdExamPaperStuRelation+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delcc_ExamPaperStuRelation(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperStuRelationDA.GetSpecSQLObj();
string strSQL;
string strKeyList;
if (lstKey.Count  == 0) return 0;
strKeyList = "";
for (int i = 0; i<lstKey.Count; i++)
{
if (i == 0) strKeyList = strKeyList + "" + lstKey[i].ToString() + "";
else strKeyList +=  "," + "" + lstKey[i].ToString() + "";
}
strSQL = "";
//删除cc_ExamPaperStuRelation本表中与当前对象有关的记录
strSQL = strSQL + "Delete from cc_ExamPaperStuRelation where IdExamPaperStuRelation in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngIdExamPaperStuRelation">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngIdExamPaperStuRelation) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperStuRelationDA.GetSpecSQLObj();
//删除cc_ExamPaperStuRelation本表中与当前对象有关的记录
strSQL = strSQL + "Delete from cc_ExamPaperStuRelation where IdExamPaperStuRelation = " + ""+ lngIdExamPaperStuRelation+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delcc_ExamPaperStuRelation(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clscc_ExamPaperStuRelationDA: Delcc_ExamPaperStuRelation)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperStuRelationDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from cc_ExamPaperStuRelation where " + strCondition ;
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
public bool Delcc_ExamPaperStuRelationWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clscc_ExamPaperStuRelationDA: Delcc_ExamPaperStuRelationWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperStuRelationDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from cc_ExamPaperStuRelation where " + strCondition ;
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
 /// <param name = "objcc_ExamPaperStuRelationENS">源对象</param>
 /// <param name = "objcc_ExamPaperStuRelationENT">目标对象</param>
public void CopyTo(clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationENS, clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationENT)
{
objcc_ExamPaperStuRelationENT.IdExamPaperStuRelation = objcc_ExamPaperStuRelationENS.IdExamPaperStuRelation; //流水号
objcc_ExamPaperStuRelationENT.CourseExamPaperId = objcc_ExamPaperStuRelationENS.CourseExamPaperId; //考卷流水号
objcc_ExamPaperStuRelationENT.IdCurrEduCls = objcc_ExamPaperStuRelationENS.IdCurrEduCls; //教学班流水号
objcc_ExamPaperStuRelationENT.Scores = objcc_ExamPaperStuRelationENS.Scores; //分值
objcc_ExamPaperStuRelationENT.SpecifyCompletionDate = objcc_ExamPaperStuRelationENS.SpecifyCompletionDate; //指定完成日期
objcc_ExamPaperStuRelationENT.IdStudentInfo = objcc_ExamPaperStuRelationENS.IdStudentInfo; //学生流水号
objcc_ExamPaperStuRelationENT.AnswerModeId = objcc_ExamPaperStuRelationENS.AnswerModeId; //答案模式Id
objcc_ExamPaperStuRelationENT.AnswerOptionId = objcc_ExamPaperStuRelationENS.AnswerOptionId; //回答选项Id
objcc_ExamPaperStuRelationENT.AnswerMultiOptions = objcc_ExamPaperStuRelationENS.AnswerMultiOptions; //多选项答案
objcc_ExamPaperStuRelationENT.StuAnswerText = objcc_ExamPaperStuRelationENS.StuAnswerText; //学生回答文本
objcc_ExamPaperStuRelationENT.IsPublish = objcc_ExamPaperStuRelationENS.IsPublish; //是否发布
objcc_ExamPaperStuRelationENT.IsLook = objcc_ExamPaperStuRelationENS.IsLook; //是否查看
objcc_ExamPaperStuRelationENT.IsSave = objcc_ExamPaperStuRelationENS.IsSave; //是否保存
objcc_ExamPaperStuRelationENT.IsSubmit = objcc_ExamPaperStuRelationENS.IsSubmit; //是否提交
objcc_ExamPaperStuRelationENT.ApplySendBackDate = objcc_ExamPaperStuRelationENS.ApplySendBackDate; //申请退回日期
objcc_ExamPaperStuRelationENT.IsApplySendBack = objcc_ExamPaperStuRelationENS.IsApplySendBack; //是否申请退回
objcc_ExamPaperStuRelationENT.RealFinishDate = objcc_ExamPaperStuRelationENS.RealFinishDate; //实际完成日期
objcc_ExamPaperStuRelationENT.OperateTime = objcc_ExamPaperStuRelationENS.OperateTime; //操作时间
objcc_ExamPaperStuRelationENT.Score = objcc_ExamPaperStuRelationENS.Score; //得分
objcc_ExamPaperStuRelationENT.Comment = objcc_ExamPaperStuRelationENS.Comment; //批注
objcc_ExamPaperStuRelationENT.IsMarking = objcc_ExamPaperStuRelationENS.IsMarking; //是否批阅
objcc_ExamPaperStuRelationENT.MarkerId = objcc_ExamPaperStuRelationENS.MarkerId; //打分者
objcc_ExamPaperStuRelationENT.MarkDate = objcc_ExamPaperStuRelationENS.MarkDate; //打分日期
objcc_ExamPaperStuRelationENT.IsSendBack = objcc_ExamPaperStuRelationENS.IsSendBack; //是否退回
objcc_ExamPaperStuRelationENT.IsInErrorQuestion = objcc_ExamPaperStuRelationENS.IsInErrorQuestion; //是否进入错题
objcc_ExamPaperStuRelationENT.WorkTypeId = objcc_ExamPaperStuRelationENS.WorkTypeId; //作业类型Id
objcc_ExamPaperStuRelationENT.AnswerIP = objcc_ExamPaperStuRelationENS.AnswerIP; //回答IP
objcc_ExamPaperStuRelationENT.AnswerDate = objcc_ExamPaperStuRelationENS.AnswerDate; //回答日期
objcc_ExamPaperStuRelationENT.AnswerTime = objcc_ExamPaperStuRelationENS.AnswerTime; //回答时间
objcc_ExamPaperStuRelationENT.IsRight = objcc_ExamPaperStuRelationENS.IsRight; //是否正确
objcc_ExamPaperStuRelationENT.IsAccessKnowledge = objcc_ExamPaperStuRelationENS.IsAccessKnowledge; //是否处理知识点
objcc_ExamPaperStuRelationENT.IsNotProcessTimeout = objcc_ExamPaperStuRelationENS.IsNotProcessTimeout; //是否不处理超时
objcc_ExamPaperStuRelationENT.SchoolYear = objcc_ExamPaperStuRelationENS.SchoolYear; //学年
objcc_ExamPaperStuRelationENT.SchoolTerm = objcc_ExamPaperStuRelationENS.SchoolTerm; //学期
objcc_ExamPaperStuRelationENT.UpdDate = objcc_ExamPaperStuRelationENS.UpdDate; //修改日期
objcc_ExamPaperStuRelationENT.UpdUserId = objcc_ExamPaperStuRelationENS.UpdUserId; //修改用户Id
objcc_ExamPaperStuRelationENT.Memo = objcc_ExamPaperStuRelationENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objcc_ExamPaperStuRelationEN.IdCurrEduCls, concc_ExamPaperStuRelation.IdCurrEduCls);
clsCheckSql.CheckFieldNotNull(objcc_ExamPaperStuRelationEN.SpecifyCompletionDate, concc_ExamPaperStuRelation.SpecifyCompletionDate);
clsCheckSql.CheckFieldNotNull(objcc_ExamPaperStuRelationEN.IdStudentInfo, concc_ExamPaperStuRelation.IdStudentInfo);
clsCheckSql.CheckFieldNotNull(objcc_ExamPaperStuRelationEN.WorkTypeId, concc_ExamPaperStuRelation.WorkTypeId);
clsCheckSql.CheckFieldNotNull(objcc_ExamPaperStuRelationEN.UpdDate, concc_ExamPaperStuRelation.UpdDate);
//检查字段长度
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuRelationEN.CourseExamPaperId, 8, concc_ExamPaperStuRelation.CourseExamPaperId);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuRelationEN.IdCurrEduCls, 8, concc_ExamPaperStuRelation.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuRelationEN.SpecifyCompletionDate, 14, concc_ExamPaperStuRelation.SpecifyCompletionDate);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuRelationEN.IdStudentInfo, 8, concc_ExamPaperStuRelation.IdStudentInfo);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuRelationEN.AnswerModeId, 4, concc_ExamPaperStuRelation.AnswerModeId);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuRelationEN.AnswerOptionId, 8, concc_ExamPaperStuRelation.AnswerOptionId);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuRelationEN.AnswerMultiOptions, 300, concc_ExamPaperStuRelation.AnswerMultiOptions);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuRelationEN.ApplySendBackDate, 14, concc_ExamPaperStuRelation.ApplySendBackDate);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuRelationEN.RealFinishDate, 14, concc_ExamPaperStuRelation.RealFinishDate);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuRelationEN.OperateTime, 14, concc_ExamPaperStuRelation.OperateTime);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuRelationEN.MarkerId, 20, concc_ExamPaperStuRelation.MarkerId);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuRelationEN.MarkDate, 14, concc_ExamPaperStuRelation.MarkDate);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuRelationEN.WorkTypeId, 2, concc_ExamPaperStuRelation.WorkTypeId);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuRelationEN.AnswerIP, 30, concc_ExamPaperStuRelation.AnswerIP);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuRelationEN.AnswerDate, 8, concc_ExamPaperStuRelation.AnswerDate);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuRelationEN.AnswerTime, 10, concc_ExamPaperStuRelation.AnswerTime);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuRelationEN.SchoolYear, 10, concc_ExamPaperStuRelation.SchoolYear);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuRelationEN.SchoolTerm, 1, concc_ExamPaperStuRelation.SchoolTerm);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuRelationEN.UpdDate, 20, concc_ExamPaperStuRelation.UpdDate);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuRelationEN.UpdUserId, 20, concc_ExamPaperStuRelation.UpdUserId);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuRelationEN.Memo, 1000, concc_ExamPaperStuRelation.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objcc_ExamPaperStuRelationEN.CourseExamPaperId, 8, concc_ExamPaperStuRelation.CourseExamPaperId);
clsCheckSql.CheckFieldForeignKey(objcc_ExamPaperStuRelationEN.IdCurrEduCls, 8, concc_ExamPaperStuRelation.IdCurrEduCls);
clsCheckSql.CheckFieldForeignKey(objcc_ExamPaperStuRelationEN.IdStudentInfo, 8, concc_ExamPaperStuRelation.IdStudentInfo);
 objcc_ExamPaperStuRelationEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuRelationEN.CourseExamPaperId, 8, concc_ExamPaperStuRelation.CourseExamPaperId);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuRelationEN.IdCurrEduCls, 8, concc_ExamPaperStuRelation.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuRelationEN.SpecifyCompletionDate, 14, concc_ExamPaperStuRelation.SpecifyCompletionDate);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuRelationEN.IdStudentInfo, 8, concc_ExamPaperStuRelation.IdStudentInfo);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuRelationEN.AnswerModeId, 4, concc_ExamPaperStuRelation.AnswerModeId);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuRelationEN.AnswerOptionId, 8, concc_ExamPaperStuRelation.AnswerOptionId);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuRelationEN.AnswerMultiOptions, 300, concc_ExamPaperStuRelation.AnswerMultiOptions);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuRelationEN.ApplySendBackDate, 14, concc_ExamPaperStuRelation.ApplySendBackDate);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuRelationEN.RealFinishDate, 14, concc_ExamPaperStuRelation.RealFinishDate);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuRelationEN.OperateTime, 14, concc_ExamPaperStuRelation.OperateTime);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuRelationEN.MarkerId, 20, concc_ExamPaperStuRelation.MarkerId);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuRelationEN.MarkDate, 14, concc_ExamPaperStuRelation.MarkDate);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuRelationEN.WorkTypeId, 2, concc_ExamPaperStuRelation.WorkTypeId);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuRelationEN.AnswerIP, 30, concc_ExamPaperStuRelation.AnswerIP);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuRelationEN.AnswerDate, 8, concc_ExamPaperStuRelation.AnswerDate);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuRelationEN.AnswerTime, 10, concc_ExamPaperStuRelation.AnswerTime);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuRelationEN.SchoolYear, 10, concc_ExamPaperStuRelation.SchoolYear);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuRelationEN.SchoolTerm, 1, concc_ExamPaperStuRelation.SchoolTerm);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuRelationEN.UpdDate, 20, concc_ExamPaperStuRelation.UpdDate);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuRelationEN.UpdUserId, 20, concc_ExamPaperStuRelation.UpdUserId);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuRelationEN.Memo, 1000, concc_ExamPaperStuRelation.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objcc_ExamPaperStuRelationEN.CourseExamPaperId, 8, concc_ExamPaperStuRelation.CourseExamPaperId);
clsCheckSql.CheckFieldForeignKey(objcc_ExamPaperStuRelationEN.IdCurrEduCls, 8, concc_ExamPaperStuRelation.IdCurrEduCls);
clsCheckSql.CheckFieldForeignKey(objcc_ExamPaperStuRelationEN.IdStudentInfo, 8, concc_ExamPaperStuRelation.IdStudentInfo);
 objcc_ExamPaperStuRelationEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuRelationEN.CourseExamPaperId, 8, concc_ExamPaperStuRelation.CourseExamPaperId);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuRelationEN.IdCurrEduCls, 8, concc_ExamPaperStuRelation.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuRelationEN.SpecifyCompletionDate, 14, concc_ExamPaperStuRelation.SpecifyCompletionDate);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuRelationEN.IdStudentInfo, 8, concc_ExamPaperStuRelation.IdStudentInfo);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuRelationEN.AnswerModeId, 4, concc_ExamPaperStuRelation.AnswerModeId);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuRelationEN.AnswerOptionId, 8, concc_ExamPaperStuRelation.AnswerOptionId);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuRelationEN.AnswerMultiOptions, 300, concc_ExamPaperStuRelation.AnswerMultiOptions);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuRelationEN.ApplySendBackDate, 14, concc_ExamPaperStuRelation.ApplySendBackDate);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuRelationEN.RealFinishDate, 14, concc_ExamPaperStuRelation.RealFinishDate);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuRelationEN.OperateTime, 14, concc_ExamPaperStuRelation.OperateTime);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuRelationEN.MarkerId, 20, concc_ExamPaperStuRelation.MarkerId);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuRelationEN.MarkDate, 14, concc_ExamPaperStuRelation.MarkDate);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuRelationEN.WorkTypeId, 2, concc_ExamPaperStuRelation.WorkTypeId);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuRelationEN.AnswerIP, 30, concc_ExamPaperStuRelation.AnswerIP);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuRelationEN.AnswerDate, 8, concc_ExamPaperStuRelation.AnswerDate);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuRelationEN.AnswerTime, 10, concc_ExamPaperStuRelation.AnswerTime);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuRelationEN.SchoolYear, 10, concc_ExamPaperStuRelation.SchoolYear);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuRelationEN.SchoolTerm, 1, concc_ExamPaperStuRelation.SchoolTerm);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuRelationEN.UpdDate, 20, concc_ExamPaperStuRelation.UpdDate);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuRelationEN.UpdUserId, 20, concc_ExamPaperStuRelation.UpdUserId);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuRelationEN.Memo, 1000, concc_ExamPaperStuRelation.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objcc_ExamPaperStuRelationEN.CourseExamPaperId, concc_ExamPaperStuRelation.CourseExamPaperId);
clsCheckSql.CheckSqlInjection4Field(objcc_ExamPaperStuRelationEN.IdCurrEduCls, concc_ExamPaperStuRelation.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objcc_ExamPaperStuRelationEN.SpecifyCompletionDate, concc_ExamPaperStuRelation.SpecifyCompletionDate);
clsCheckSql.CheckSqlInjection4Field(objcc_ExamPaperStuRelationEN.IdStudentInfo, concc_ExamPaperStuRelation.IdStudentInfo);
clsCheckSql.CheckSqlInjection4Field(objcc_ExamPaperStuRelationEN.AnswerModeId, concc_ExamPaperStuRelation.AnswerModeId);
clsCheckSql.CheckSqlInjection4Field(objcc_ExamPaperStuRelationEN.AnswerOptionId, concc_ExamPaperStuRelation.AnswerOptionId);
clsCheckSql.CheckSqlInjection4Field(objcc_ExamPaperStuRelationEN.AnswerMultiOptions, concc_ExamPaperStuRelation.AnswerMultiOptions);
clsCheckSql.CheckSqlInjection4Field(objcc_ExamPaperStuRelationEN.ApplySendBackDate, concc_ExamPaperStuRelation.ApplySendBackDate);
clsCheckSql.CheckSqlInjection4Field(objcc_ExamPaperStuRelationEN.RealFinishDate, concc_ExamPaperStuRelation.RealFinishDate);
clsCheckSql.CheckSqlInjection4Field(objcc_ExamPaperStuRelationEN.OperateTime, concc_ExamPaperStuRelation.OperateTime);
clsCheckSql.CheckSqlInjection4Field(objcc_ExamPaperStuRelationEN.MarkerId, concc_ExamPaperStuRelation.MarkerId);
clsCheckSql.CheckSqlInjection4Field(objcc_ExamPaperStuRelationEN.MarkDate, concc_ExamPaperStuRelation.MarkDate);
clsCheckSql.CheckSqlInjection4Field(objcc_ExamPaperStuRelationEN.WorkTypeId, concc_ExamPaperStuRelation.WorkTypeId);
clsCheckSql.CheckSqlInjection4Field(objcc_ExamPaperStuRelationEN.AnswerIP, concc_ExamPaperStuRelation.AnswerIP);
clsCheckSql.CheckSqlInjection4Field(objcc_ExamPaperStuRelationEN.AnswerDate, concc_ExamPaperStuRelation.AnswerDate);
clsCheckSql.CheckSqlInjection4Field(objcc_ExamPaperStuRelationEN.AnswerTime, concc_ExamPaperStuRelation.AnswerTime);
clsCheckSql.CheckSqlInjection4Field(objcc_ExamPaperStuRelationEN.SchoolYear, concc_ExamPaperStuRelation.SchoolYear);
clsCheckSql.CheckSqlInjection4Field(objcc_ExamPaperStuRelationEN.SchoolTerm, concc_ExamPaperStuRelation.SchoolTerm);
clsCheckSql.CheckSqlInjection4Field(objcc_ExamPaperStuRelationEN.UpdDate, concc_ExamPaperStuRelation.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objcc_ExamPaperStuRelationEN.UpdUserId, concc_ExamPaperStuRelation.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objcc_ExamPaperStuRelationEN.Memo, concc_ExamPaperStuRelation.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objcc_ExamPaperStuRelationEN.CourseExamPaperId, 8, concc_ExamPaperStuRelation.CourseExamPaperId);
clsCheckSql.CheckFieldForeignKey(objcc_ExamPaperStuRelationEN.IdCurrEduCls, 8, concc_ExamPaperStuRelation.IdCurrEduCls);
clsCheckSql.CheckFieldForeignKey(objcc_ExamPaperStuRelationEN.IdStudentInfo, 8, concc_ExamPaperStuRelation.IdStudentInfo);
 objcc_ExamPaperStuRelationEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--cc_ExamPaperStuRelation(考卷与学生关系),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 if (objcc_ExamPaperStuRelationEN.CourseExamPaperId == null)
{
 sbCondition.AppendFormat(" and CourseExamPaperId is null");
}
else
{
 sbCondition.AppendFormat(" and CourseExamPaperId = '{0}'", objcc_ExamPaperStuRelationEN.CourseExamPaperId);
}
 sbCondition.AppendFormat(" and IdStudentInfo = '{0}'", objcc_ExamPaperStuRelationEN.IdStudentInfo);
 sbCondition.AppendFormat(" and IdCurrEduCls = '{0}'", objcc_ExamPaperStuRelationEN.IdCurrEduCls);
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
 objSQL = clscc_ExamPaperStuRelationDA.GetSpecSQLObj();
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
 objSQL = clscc_ExamPaperStuRelationDA.GetSpecSQLObj();
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
 objSQL = clscc_ExamPaperStuRelationDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clscc_ExamPaperStuRelationEN._CurrTabName);
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
 objSQL = clscc_ExamPaperStuRelationDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clscc_ExamPaperStuRelationEN._CurrTabName, strCondition);
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
 objSQL = clscc_ExamPaperStuRelationDA.GetSpecSQLObj();
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
 objSQL = clscc_ExamPaperStuRelationDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}