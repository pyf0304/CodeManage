
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_WorkStuRelationDA
 表名:cc_WorkStuRelation(01120145)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:00:40
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
 /// 作业与学生关系(cc_WorkStuRelation)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clscc_WorkStuRelationDA : clsCommBase4DA
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
 return clscc_WorkStuRelationEN._CurrTabName;
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
if (string.IsNullOrEmpty(clscc_WorkStuRelationEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clscc_WorkStuRelationEN._ConnectString);
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
 if (string.IsNullOrEmpty(clscc_WorkStuRelationEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clscc_WorkStuRelationEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clscc_WorkStuRelationDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkStuRelationDA.GetSpecSQLObj();
strSQL = "Select * from cc_WorkStuRelation where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_cc_WorkStuRelation(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clscc_WorkStuRelationDA: GetDataTable_cc_WorkStuRelation)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkStuRelationDA.GetSpecSQLObj();
strSQL = "Select * from cc_WorkStuRelation where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clscc_WorkStuRelationDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkStuRelationDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clscc_WorkStuRelationDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkStuRelationDA.GetSpecSQLObj();
strSQL = "Select * from cc_WorkStuRelation where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clscc_WorkStuRelationDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkStuRelationDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clscc_WorkStuRelationDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkStuRelationDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from cc_WorkStuRelation where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from cc_WorkStuRelation where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clscc_WorkStuRelationDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkStuRelationDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from cc_WorkStuRelation where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clscc_WorkStuRelationDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkStuRelationDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} cc_WorkStuRelation.* from cc_WorkStuRelation Left Join {1} on {2} where {3} and cc_WorkStuRelation.IdWorkStuRelation not in (Select top {5} cc_WorkStuRelation.IdWorkStuRelation from cc_WorkStuRelation Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from cc_WorkStuRelation where {1} and IdWorkStuRelation not in (Select top {2} IdWorkStuRelation from cc_WorkStuRelation where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from cc_WorkStuRelation where {1} and IdWorkStuRelation not in (Select top {3} IdWorkStuRelation from cc_WorkStuRelation where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clscc_WorkStuRelationDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkStuRelationDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} cc_WorkStuRelation.* from cc_WorkStuRelation Left Join {1} on {2} where {3} and cc_WorkStuRelation.IdWorkStuRelation not in (Select top {5} cc_WorkStuRelation.IdWorkStuRelation from cc_WorkStuRelation Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from cc_WorkStuRelation where {1} and IdWorkStuRelation not in (Select top {2} IdWorkStuRelation from cc_WorkStuRelation where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from cc_WorkStuRelation where {1} and IdWorkStuRelation not in (Select top {3} IdWorkStuRelation from cc_WorkStuRelation where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clscc_WorkStuRelationEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clscc_WorkStuRelationDA:GetObjLst)", objException.Message));
}
List<clscc_WorkStuRelationEN> arrObjLst = new List<clscc_WorkStuRelationEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkStuRelationDA.GetSpecSQLObj();
strSQL = "Select * from cc_WorkStuRelation where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_WorkStuRelationEN objcc_WorkStuRelationEN = new clscc_WorkStuRelationEN();
try
{
objcc_WorkStuRelationEN.IdWorkStuRelation = TransNullToInt(objRow[concc_WorkStuRelation.IdWorkStuRelation].ToString().Trim()); //流水号
objcc_WorkStuRelationEN.IdCurrEduCls = objRow[concc_WorkStuRelation.IdCurrEduCls].ToString().Trim(); //教学班流水号
objcc_WorkStuRelationEN.QuestionId = TransNullToInt(objRow[concc_WorkStuRelation.QuestionId].ToString().Trim()); //题目Id
objcc_WorkStuRelationEN.Scores = objRow[concc_WorkStuRelation.Scores] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_WorkStuRelation.Scores].ToString().Trim()); //分值
objcc_WorkStuRelationEN.SpecifyCompletionDate = objRow[concc_WorkStuRelation.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objcc_WorkStuRelationEN.IdStudentInfo = objRow[concc_WorkStuRelation.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_WorkStuRelationEN.AnswerModeId = objRow[concc_WorkStuRelation.AnswerModeId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerModeId].ToString().Trim(); //答案模式Id
objcc_WorkStuRelationEN.AnswerOptionId = objRow[concc_WorkStuRelation.AnswerOptionId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerOptionId].ToString().Trim(); //回答选项Id
objcc_WorkStuRelationEN.AnswerMultiOptions = objRow[concc_WorkStuRelation.AnswerMultiOptions] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerMultiOptions].ToString().Trim(); //多选项答案
objcc_WorkStuRelationEN.AnswerBoolResult = TransNullToBool(objRow[concc_WorkStuRelation.AnswerBoolResult].ToString().Trim()); //答案布尔结果
objcc_WorkStuRelationEN.StuAnswerText = objRow[concc_WorkStuRelation.StuAnswerText] == DBNull.Value ? null : objRow[concc_WorkStuRelation.StuAnswerText].ToString().Trim(); //学生回答文本
objcc_WorkStuRelationEN.IsPublish = TransNullToBool(objRow[concc_WorkStuRelation.IsPublish].ToString().Trim()); //是否发布
objcc_WorkStuRelationEN.IsLook = TransNullToBool(objRow[concc_WorkStuRelation.IsLook].ToString().Trim()); //是否查看
objcc_WorkStuRelationEN.IsSave = TransNullToBool(objRow[concc_WorkStuRelation.IsSave].ToString().Trim()); //是否保存
objcc_WorkStuRelationEN.IsSubmit = TransNullToBool(objRow[concc_WorkStuRelation.IsSubmit].ToString().Trim()); //是否提交
objcc_WorkStuRelationEN.ApplySendBackDate = objRow[concc_WorkStuRelation.ApplySendBackDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation.ApplySendBackDate].ToString().Trim(); //申请退回日期
objcc_WorkStuRelationEN.IsApplySendBack = TransNullToBool(objRow[concc_WorkStuRelation.IsApplySendBack].ToString().Trim()); //是否申请退回
objcc_WorkStuRelationEN.RealFinishDate = objRow[concc_WorkStuRelation.RealFinishDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation.RealFinishDate].ToString().Trim(); //实际完成日期
objcc_WorkStuRelationEN.OperateTime = objRow[concc_WorkStuRelation.OperateTime] == DBNull.Value ? null : objRow[concc_WorkStuRelation.OperateTime].ToString().Trim(); //操作时间
objcc_WorkStuRelationEN.Score = objRow[concc_WorkStuRelation.Score] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_WorkStuRelation.Score].ToString().Trim()); //得分
objcc_WorkStuRelationEN.Comment = objRow[concc_WorkStuRelation.Comment] == DBNull.Value ? null : objRow[concc_WorkStuRelation.Comment].ToString().Trim(); //批注
objcc_WorkStuRelationEN.IsMarking = TransNullToBool(objRow[concc_WorkStuRelation.IsMarking].ToString().Trim()); //是否批阅
objcc_WorkStuRelationEN.MarkerId = objRow[concc_WorkStuRelation.MarkerId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.MarkerId].ToString().Trim(); //打分者
objcc_WorkStuRelationEN.MarkDate = objRow[concc_WorkStuRelation.MarkDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation.MarkDate].ToString().Trim(); //打分日期
objcc_WorkStuRelationEN.IsSendBack = TransNullToBool(objRow[concc_WorkStuRelation.IsSendBack].ToString().Trim()); //是否退回
objcc_WorkStuRelationEN.IsInErrorQuestion = TransNullToBool(objRow[concc_WorkStuRelation.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objcc_WorkStuRelationEN.WorkTypeId = objRow[concc_WorkStuRelation.WorkTypeId].ToString().Trim(); //作业类型Id
objcc_WorkStuRelationEN.AnswerIP = objRow[concc_WorkStuRelation.AnswerIP] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerIP].ToString().Trim(); //回答IP
objcc_WorkStuRelationEN.AnswerDate = objRow[concc_WorkStuRelation.AnswerDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerDate].ToString().Trim(); //回答日期
objcc_WorkStuRelationEN.AnswerTime = objRow[concc_WorkStuRelation.AnswerTime] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerTime].ToString().Trim(); //回答时间
objcc_WorkStuRelationEN.CourseExamPaperId = objRow[concc_WorkStuRelation.CourseExamPaperId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_WorkStuRelationEN.IsRight = TransNullToBool(objRow[concc_WorkStuRelation.IsRight].ToString().Trim()); //是否正确
objcc_WorkStuRelationEN.IsAccessKnowledge = TransNullToBool(objRow[concc_WorkStuRelation.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objcc_WorkStuRelationEN.IsNotProcessTimeout = TransNullToBool(objRow[concc_WorkStuRelation.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objcc_WorkStuRelationEN.SchoolYear = objRow[concc_WorkStuRelation.SchoolYear] == DBNull.Value ? null : objRow[concc_WorkStuRelation.SchoolYear].ToString().Trim(); //学年
objcc_WorkStuRelationEN.SchoolTerm = objRow[concc_WorkStuRelation.SchoolTerm] == DBNull.Value ? null : objRow[concc_WorkStuRelation.SchoolTerm].ToString().Trim(); //学期
objcc_WorkStuRelationEN.ErrMsg = objRow[concc_WorkStuRelation.ErrMsg] == DBNull.Value ? null : objRow[concc_WorkStuRelation.ErrMsg].ToString().Trim(); //错误信息
objcc_WorkStuRelationEN.CourseId = objRow[concc_WorkStuRelation.CourseId].ToString().Trim(); //课程Id
objcc_WorkStuRelationEN.UpdDate = objRow[concc_WorkStuRelation.UpdDate].ToString().Trim(); //修改日期
objcc_WorkStuRelationEN.UpdUserId = objRow[concc_WorkStuRelation.UpdUserId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.UpdUserId].ToString().Trim(); //修改用户Id
objcc_WorkStuRelationEN.Memo = objRow[concc_WorkStuRelation.Memo] == DBNull.Value ? null : objRow[concc_WorkStuRelation.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clscc_WorkStuRelationDA: GetObjLst)", objException.Message));
}
objcc_WorkStuRelationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objcc_WorkStuRelationEN);
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
public List<clscc_WorkStuRelationEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clscc_WorkStuRelationDA:GetObjLstByTabName)", objException.Message));
}
List<clscc_WorkStuRelationEN> arrObjLst = new List<clscc_WorkStuRelationEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkStuRelationDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_WorkStuRelationEN objcc_WorkStuRelationEN = new clscc_WorkStuRelationEN();
try
{
objcc_WorkStuRelationEN.IdWorkStuRelation = TransNullToInt(objRow[concc_WorkStuRelation.IdWorkStuRelation].ToString().Trim()); //流水号
objcc_WorkStuRelationEN.IdCurrEduCls = objRow[concc_WorkStuRelation.IdCurrEduCls].ToString().Trim(); //教学班流水号
objcc_WorkStuRelationEN.QuestionId = TransNullToInt(objRow[concc_WorkStuRelation.QuestionId].ToString().Trim()); //题目Id
objcc_WorkStuRelationEN.Scores = objRow[concc_WorkStuRelation.Scores] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_WorkStuRelation.Scores].ToString().Trim()); //分值
objcc_WorkStuRelationEN.SpecifyCompletionDate = objRow[concc_WorkStuRelation.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objcc_WorkStuRelationEN.IdStudentInfo = objRow[concc_WorkStuRelation.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_WorkStuRelationEN.AnswerModeId = objRow[concc_WorkStuRelation.AnswerModeId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerModeId].ToString().Trim(); //答案模式Id
objcc_WorkStuRelationEN.AnswerOptionId = objRow[concc_WorkStuRelation.AnswerOptionId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerOptionId].ToString().Trim(); //回答选项Id
objcc_WorkStuRelationEN.AnswerMultiOptions = objRow[concc_WorkStuRelation.AnswerMultiOptions] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerMultiOptions].ToString().Trim(); //多选项答案
objcc_WorkStuRelationEN.AnswerBoolResult = TransNullToBool(objRow[concc_WorkStuRelation.AnswerBoolResult].ToString().Trim()); //答案布尔结果
objcc_WorkStuRelationEN.StuAnswerText = objRow[concc_WorkStuRelation.StuAnswerText] == DBNull.Value ? null : objRow[concc_WorkStuRelation.StuAnswerText].ToString().Trim(); //学生回答文本
objcc_WorkStuRelationEN.IsPublish = TransNullToBool(objRow[concc_WorkStuRelation.IsPublish].ToString().Trim()); //是否发布
objcc_WorkStuRelationEN.IsLook = TransNullToBool(objRow[concc_WorkStuRelation.IsLook].ToString().Trim()); //是否查看
objcc_WorkStuRelationEN.IsSave = TransNullToBool(objRow[concc_WorkStuRelation.IsSave].ToString().Trim()); //是否保存
objcc_WorkStuRelationEN.IsSubmit = TransNullToBool(objRow[concc_WorkStuRelation.IsSubmit].ToString().Trim()); //是否提交
objcc_WorkStuRelationEN.ApplySendBackDate = objRow[concc_WorkStuRelation.ApplySendBackDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation.ApplySendBackDate].ToString().Trim(); //申请退回日期
objcc_WorkStuRelationEN.IsApplySendBack = TransNullToBool(objRow[concc_WorkStuRelation.IsApplySendBack].ToString().Trim()); //是否申请退回
objcc_WorkStuRelationEN.RealFinishDate = objRow[concc_WorkStuRelation.RealFinishDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation.RealFinishDate].ToString().Trim(); //实际完成日期
objcc_WorkStuRelationEN.OperateTime = objRow[concc_WorkStuRelation.OperateTime] == DBNull.Value ? null : objRow[concc_WorkStuRelation.OperateTime].ToString().Trim(); //操作时间
objcc_WorkStuRelationEN.Score = objRow[concc_WorkStuRelation.Score] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_WorkStuRelation.Score].ToString().Trim()); //得分
objcc_WorkStuRelationEN.Comment = objRow[concc_WorkStuRelation.Comment] == DBNull.Value ? null : objRow[concc_WorkStuRelation.Comment].ToString().Trim(); //批注
objcc_WorkStuRelationEN.IsMarking = TransNullToBool(objRow[concc_WorkStuRelation.IsMarking].ToString().Trim()); //是否批阅
objcc_WorkStuRelationEN.MarkerId = objRow[concc_WorkStuRelation.MarkerId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.MarkerId].ToString().Trim(); //打分者
objcc_WorkStuRelationEN.MarkDate = objRow[concc_WorkStuRelation.MarkDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation.MarkDate].ToString().Trim(); //打分日期
objcc_WorkStuRelationEN.IsSendBack = TransNullToBool(objRow[concc_WorkStuRelation.IsSendBack].ToString().Trim()); //是否退回
objcc_WorkStuRelationEN.IsInErrorQuestion = TransNullToBool(objRow[concc_WorkStuRelation.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objcc_WorkStuRelationEN.WorkTypeId = objRow[concc_WorkStuRelation.WorkTypeId].ToString().Trim(); //作业类型Id
objcc_WorkStuRelationEN.AnswerIP = objRow[concc_WorkStuRelation.AnswerIP] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerIP].ToString().Trim(); //回答IP
objcc_WorkStuRelationEN.AnswerDate = objRow[concc_WorkStuRelation.AnswerDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerDate].ToString().Trim(); //回答日期
objcc_WorkStuRelationEN.AnswerTime = objRow[concc_WorkStuRelation.AnswerTime] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerTime].ToString().Trim(); //回答时间
objcc_WorkStuRelationEN.CourseExamPaperId = objRow[concc_WorkStuRelation.CourseExamPaperId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_WorkStuRelationEN.IsRight = TransNullToBool(objRow[concc_WorkStuRelation.IsRight].ToString().Trim()); //是否正确
objcc_WorkStuRelationEN.IsAccessKnowledge = TransNullToBool(objRow[concc_WorkStuRelation.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objcc_WorkStuRelationEN.IsNotProcessTimeout = TransNullToBool(objRow[concc_WorkStuRelation.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objcc_WorkStuRelationEN.SchoolYear = objRow[concc_WorkStuRelation.SchoolYear] == DBNull.Value ? null : objRow[concc_WorkStuRelation.SchoolYear].ToString().Trim(); //学年
objcc_WorkStuRelationEN.SchoolTerm = objRow[concc_WorkStuRelation.SchoolTerm] == DBNull.Value ? null : objRow[concc_WorkStuRelation.SchoolTerm].ToString().Trim(); //学期
objcc_WorkStuRelationEN.ErrMsg = objRow[concc_WorkStuRelation.ErrMsg] == DBNull.Value ? null : objRow[concc_WorkStuRelation.ErrMsg].ToString().Trim(); //错误信息
objcc_WorkStuRelationEN.CourseId = objRow[concc_WorkStuRelation.CourseId].ToString().Trim(); //课程Id
objcc_WorkStuRelationEN.UpdDate = objRow[concc_WorkStuRelation.UpdDate].ToString().Trim(); //修改日期
objcc_WorkStuRelationEN.UpdUserId = objRow[concc_WorkStuRelation.UpdUserId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.UpdUserId].ToString().Trim(); //修改用户Id
objcc_WorkStuRelationEN.Memo = objRow[concc_WorkStuRelation.Memo] == DBNull.Value ? null : objRow[concc_WorkStuRelation.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clscc_WorkStuRelationDA: GetObjLst)", objException.Message));
}
objcc_WorkStuRelationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objcc_WorkStuRelationEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getcc_WorkStuRelation(ref clscc_WorkStuRelationEN objcc_WorkStuRelationEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkStuRelationDA.GetSpecSQLObj();
strSQL = "Select * from cc_WorkStuRelation where IdWorkStuRelation = " + ""+ objcc_WorkStuRelationEN.IdWorkStuRelation+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objcc_WorkStuRelationEN.IdWorkStuRelation = TransNullToInt(objDT.Rows[0][concc_WorkStuRelation.IdWorkStuRelation].ToString().Trim()); //流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objcc_WorkStuRelationEN.IdCurrEduCls = objDT.Rows[0][concc_WorkStuRelation.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objcc_WorkStuRelationEN.QuestionId = TransNullToInt(objDT.Rows[0][concc_WorkStuRelation.QuestionId].ToString().Trim()); //题目Id(字段类型:bigint,字段长度:8,是否可空:True)
 objcc_WorkStuRelationEN.Scores = TransNullToDouble(objDT.Rows[0][concc_WorkStuRelation.Scores].ToString().Trim()); //分值(字段类型:decimal,字段长度:8,是否可空:True)
 objcc_WorkStuRelationEN.SpecifyCompletionDate = objDT.Rows[0][concc_WorkStuRelation.SpecifyCompletionDate].ToString().Trim(); //指定完成日期(字段类型:varchar,字段长度:14,是否可空:False)
 objcc_WorkStuRelationEN.IdStudentInfo = objDT.Rows[0][concc_WorkStuRelation.IdStudentInfo].ToString().Trim(); //学生流水号(字段类型:char,字段长度:8,是否可空:False)
 objcc_WorkStuRelationEN.AnswerModeId = objDT.Rows[0][concc_WorkStuRelation.AnswerModeId].ToString().Trim(); //答案模式Id(字段类型:char,字段长度:4,是否可空:True)
 objcc_WorkStuRelationEN.AnswerOptionId = objDT.Rows[0][concc_WorkStuRelation.AnswerOptionId].ToString().Trim(); //回答选项Id(字段类型:char,字段长度:8,是否可空:True)
 objcc_WorkStuRelationEN.AnswerMultiOptions = objDT.Rows[0][concc_WorkStuRelation.AnswerMultiOptions].ToString().Trim(); //多选项答案(字段类型:varchar,字段长度:300,是否可空:True)
 objcc_WorkStuRelationEN.AnswerBoolResult = TransNullToBool(objDT.Rows[0][concc_WorkStuRelation.AnswerBoolResult].ToString().Trim()); //答案布尔结果(字段类型:bit,字段长度:1,是否可空:True)
 objcc_WorkStuRelationEN.StuAnswerText = objDT.Rows[0][concc_WorkStuRelation.StuAnswerText].ToString().Trim(); //学生回答文本(字段类型:text,字段长度:2147483647,是否可空:True)
 objcc_WorkStuRelationEN.IsPublish = TransNullToBool(objDT.Rows[0][concc_WorkStuRelation.IsPublish].ToString().Trim()); //是否发布(字段类型:bit,字段长度:1,是否可空:True)
 objcc_WorkStuRelationEN.IsLook = TransNullToBool(objDT.Rows[0][concc_WorkStuRelation.IsLook].ToString().Trim()); //是否查看(字段类型:bit,字段长度:1,是否可空:True)
 objcc_WorkStuRelationEN.IsSave = TransNullToBool(objDT.Rows[0][concc_WorkStuRelation.IsSave].ToString().Trim()); //是否保存(字段类型:bit,字段长度:1,是否可空:True)
 objcc_WorkStuRelationEN.IsSubmit = TransNullToBool(objDT.Rows[0][concc_WorkStuRelation.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objcc_WorkStuRelationEN.ApplySendBackDate = objDT.Rows[0][concc_WorkStuRelation.ApplySendBackDate].ToString().Trim(); //申请退回日期(字段类型:varchar,字段长度:14,是否可空:True)
 objcc_WorkStuRelationEN.IsApplySendBack = TransNullToBool(objDT.Rows[0][concc_WorkStuRelation.IsApplySendBack].ToString().Trim()); //是否申请退回(字段类型:bit,字段长度:1,是否可空:True)
 objcc_WorkStuRelationEN.RealFinishDate = objDT.Rows[0][concc_WorkStuRelation.RealFinishDate].ToString().Trim(); //实际完成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objcc_WorkStuRelationEN.OperateTime = objDT.Rows[0][concc_WorkStuRelation.OperateTime].ToString().Trim(); //操作时间(字段类型:varchar,字段长度:14,是否可空:True)
 objcc_WorkStuRelationEN.Score = TransNullToDouble(objDT.Rows[0][concc_WorkStuRelation.Score].ToString().Trim()); //得分(字段类型:decimal,字段长度:6,是否可空:True)
 objcc_WorkStuRelationEN.Comment = objDT.Rows[0][concc_WorkStuRelation.Comment].ToString().Trim(); //批注(字段类型:text,字段长度:2147483647,是否可空:True)
 objcc_WorkStuRelationEN.IsMarking = TransNullToBool(objDT.Rows[0][concc_WorkStuRelation.IsMarking].ToString().Trim()); //是否批阅(字段类型:bit,字段长度:1,是否可空:True)
 objcc_WorkStuRelationEN.MarkerId = objDT.Rows[0][concc_WorkStuRelation.MarkerId].ToString().Trim(); //打分者(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_WorkStuRelationEN.MarkDate = objDT.Rows[0][concc_WorkStuRelation.MarkDate].ToString().Trim(); //打分日期(字段类型:varchar,字段长度:14,是否可空:True)
 objcc_WorkStuRelationEN.IsSendBack = TransNullToBool(objDT.Rows[0][concc_WorkStuRelation.IsSendBack].ToString().Trim()); //是否退回(字段类型:bit,字段长度:1,是否可空:True)
 objcc_WorkStuRelationEN.IsInErrorQuestion = TransNullToBool(objDT.Rows[0][concc_WorkStuRelation.IsInErrorQuestion].ToString().Trim()); //是否进入错题(字段类型:bit,字段长度:1,是否可空:True)
 objcc_WorkStuRelationEN.WorkTypeId = objDT.Rows[0][concc_WorkStuRelation.WorkTypeId].ToString().Trim(); //作业类型Id(字段类型:char,字段长度:2,是否可空:False)
 objcc_WorkStuRelationEN.AnswerIP = objDT.Rows[0][concc_WorkStuRelation.AnswerIP].ToString().Trim(); //回答IP(字段类型:varchar,字段长度:30,是否可空:True)
 objcc_WorkStuRelationEN.AnswerDate = objDT.Rows[0][concc_WorkStuRelation.AnswerDate].ToString().Trim(); //回答日期(字段类型:varchar,字段长度:8,是否可空:True)
 objcc_WorkStuRelationEN.AnswerTime = objDT.Rows[0][concc_WorkStuRelation.AnswerTime].ToString().Trim(); //回答时间(字段类型:varchar,字段长度:10,是否可空:True)
 objcc_WorkStuRelationEN.CourseExamPaperId = objDT.Rows[0][concc_WorkStuRelation.CourseExamPaperId].ToString().Trim(); //考卷流水号(字段类型:char,字段长度:8,是否可空:True)
 objcc_WorkStuRelationEN.IsRight = TransNullToBool(objDT.Rows[0][concc_WorkStuRelation.IsRight].ToString().Trim()); //是否正确(字段类型:bit,字段长度:1,是否可空:True)
 objcc_WorkStuRelationEN.IsAccessKnowledge = TransNullToBool(objDT.Rows[0][concc_WorkStuRelation.IsAccessKnowledge].ToString().Trim()); //是否处理知识点(字段类型:bit,字段长度:1,是否可空:True)
 objcc_WorkStuRelationEN.IsNotProcessTimeout = TransNullToBool(objDT.Rows[0][concc_WorkStuRelation.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时(字段类型:bit,字段长度:1,是否可空:True)
 objcc_WorkStuRelationEN.SchoolYear = objDT.Rows[0][concc_WorkStuRelation.SchoolYear].ToString().Trim(); //学年(字段类型:varchar,字段长度:10,是否可空:True)
 objcc_WorkStuRelationEN.SchoolTerm = objDT.Rows[0][concc_WorkStuRelation.SchoolTerm].ToString().Trim(); //学期(字段类型:char,字段长度:1,是否可空:True)
 objcc_WorkStuRelationEN.ErrMsg = objDT.Rows[0][concc_WorkStuRelation.ErrMsg].ToString().Trim(); //错误信息(字段类型:varchar,字段长度:200,是否可空:True)
 objcc_WorkStuRelationEN.CourseId = objDT.Rows[0][concc_WorkStuRelation.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objcc_WorkStuRelationEN.UpdDate = objDT.Rows[0][concc_WorkStuRelation.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_WorkStuRelationEN.UpdUserId = objDT.Rows[0][concc_WorkStuRelation.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_WorkStuRelationEN.Memo = objDT.Rows[0][concc_WorkStuRelation.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clscc_WorkStuRelationDA: Getcc_WorkStuRelation)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdWorkStuRelation">表关键字</param>
 /// <returns>表对象</returns>
public clscc_WorkStuRelationEN GetObjByIdWorkStuRelation(long lngIdWorkStuRelation)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkStuRelationDA.GetSpecSQLObj();
strSQL = "Select * from cc_WorkStuRelation where IdWorkStuRelation = " + ""+ lngIdWorkStuRelation+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clscc_WorkStuRelationEN objcc_WorkStuRelationEN = new clscc_WorkStuRelationEN();
try
{
 objcc_WorkStuRelationEN.IdWorkStuRelation = Int32.Parse(objRow[concc_WorkStuRelation.IdWorkStuRelation].ToString().Trim()); //流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objcc_WorkStuRelationEN.IdCurrEduCls = objRow[concc_WorkStuRelation.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objcc_WorkStuRelationEN.QuestionId = Int32.Parse(objRow[concc_WorkStuRelation.QuestionId].ToString().Trim()); //题目Id(字段类型:bigint,字段长度:8,是否可空:True)
 objcc_WorkStuRelationEN.Scores = objRow[concc_WorkStuRelation.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_WorkStuRelation.Scores].ToString().Trim()); //分值(字段类型:decimal,字段长度:8,是否可空:True)
 objcc_WorkStuRelationEN.SpecifyCompletionDate = objRow[concc_WorkStuRelation.SpecifyCompletionDate].ToString().Trim(); //指定完成日期(字段类型:varchar,字段长度:14,是否可空:False)
 objcc_WorkStuRelationEN.IdStudentInfo = objRow[concc_WorkStuRelation.IdStudentInfo].ToString().Trim(); //学生流水号(字段类型:char,字段长度:8,是否可空:False)
 objcc_WorkStuRelationEN.AnswerModeId = objRow[concc_WorkStuRelation.AnswerModeId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerModeId].ToString().Trim(); //答案模式Id(字段类型:char,字段长度:4,是否可空:True)
 objcc_WorkStuRelationEN.AnswerOptionId = objRow[concc_WorkStuRelation.AnswerOptionId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerOptionId].ToString().Trim(); //回答选项Id(字段类型:char,字段长度:8,是否可空:True)
 objcc_WorkStuRelationEN.AnswerMultiOptions = objRow[concc_WorkStuRelation.AnswerMultiOptions] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerMultiOptions].ToString().Trim(); //多选项答案(字段类型:varchar,字段长度:300,是否可空:True)
 objcc_WorkStuRelationEN.AnswerBoolResult = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.AnswerBoolResult].ToString().Trim()); //答案布尔结果(字段类型:bit,字段长度:1,是否可空:True)
 objcc_WorkStuRelationEN.StuAnswerText = objRow[concc_WorkStuRelation.StuAnswerText] == DBNull.Value ? null : objRow[concc_WorkStuRelation.StuAnswerText].ToString().Trim(); //学生回答文本(字段类型:text,字段长度:2147483647,是否可空:True)
 objcc_WorkStuRelationEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsPublish].ToString().Trim()); //是否发布(字段类型:bit,字段长度:1,是否可空:True)
 objcc_WorkStuRelationEN.IsLook = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsLook].ToString().Trim()); //是否查看(字段类型:bit,字段长度:1,是否可空:True)
 objcc_WorkStuRelationEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsSave].ToString().Trim()); //是否保存(字段类型:bit,字段长度:1,是否可空:True)
 objcc_WorkStuRelationEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objcc_WorkStuRelationEN.ApplySendBackDate = objRow[concc_WorkStuRelation.ApplySendBackDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation.ApplySendBackDate].ToString().Trim(); //申请退回日期(字段类型:varchar,字段长度:14,是否可空:True)
 objcc_WorkStuRelationEN.IsApplySendBack = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsApplySendBack].ToString().Trim()); //是否申请退回(字段类型:bit,字段长度:1,是否可空:True)
 objcc_WorkStuRelationEN.RealFinishDate = objRow[concc_WorkStuRelation.RealFinishDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation.RealFinishDate].ToString().Trim(); //实际完成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objcc_WorkStuRelationEN.OperateTime = objRow[concc_WorkStuRelation.OperateTime] == DBNull.Value ? null : objRow[concc_WorkStuRelation.OperateTime].ToString().Trim(); //操作时间(字段类型:varchar,字段长度:14,是否可空:True)
 objcc_WorkStuRelationEN.Score = objRow[concc_WorkStuRelation.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_WorkStuRelation.Score].ToString().Trim()); //得分(字段类型:decimal,字段长度:6,是否可空:True)
 objcc_WorkStuRelationEN.Comment = objRow[concc_WorkStuRelation.Comment] == DBNull.Value ? null : objRow[concc_WorkStuRelation.Comment].ToString().Trim(); //批注(字段类型:text,字段长度:2147483647,是否可空:True)
 objcc_WorkStuRelationEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsMarking].ToString().Trim()); //是否批阅(字段类型:bit,字段长度:1,是否可空:True)
 objcc_WorkStuRelationEN.MarkerId = objRow[concc_WorkStuRelation.MarkerId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.MarkerId].ToString().Trim(); //打分者(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_WorkStuRelationEN.MarkDate = objRow[concc_WorkStuRelation.MarkDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation.MarkDate].ToString().Trim(); //打分日期(字段类型:varchar,字段长度:14,是否可空:True)
 objcc_WorkStuRelationEN.IsSendBack = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsSendBack].ToString().Trim()); //是否退回(字段类型:bit,字段长度:1,是否可空:True)
 objcc_WorkStuRelationEN.IsInErrorQuestion = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsInErrorQuestion].ToString().Trim()); //是否进入错题(字段类型:bit,字段长度:1,是否可空:True)
 objcc_WorkStuRelationEN.WorkTypeId = objRow[concc_WorkStuRelation.WorkTypeId].ToString().Trim(); //作业类型Id(字段类型:char,字段长度:2,是否可空:False)
 objcc_WorkStuRelationEN.AnswerIP = objRow[concc_WorkStuRelation.AnswerIP] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerIP].ToString().Trim(); //回答IP(字段类型:varchar,字段长度:30,是否可空:True)
 objcc_WorkStuRelationEN.AnswerDate = objRow[concc_WorkStuRelation.AnswerDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerDate].ToString().Trim(); //回答日期(字段类型:varchar,字段长度:8,是否可空:True)
 objcc_WorkStuRelationEN.AnswerTime = objRow[concc_WorkStuRelation.AnswerTime] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerTime].ToString().Trim(); //回答时间(字段类型:varchar,字段长度:10,是否可空:True)
 objcc_WorkStuRelationEN.CourseExamPaperId = objRow[concc_WorkStuRelation.CourseExamPaperId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.CourseExamPaperId].ToString().Trim(); //考卷流水号(字段类型:char,字段长度:8,是否可空:True)
 objcc_WorkStuRelationEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsRight].ToString().Trim()); //是否正确(字段类型:bit,字段长度:1,是否可空:True)
 objcc_WorkStuRelationEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsAccessKnowledge].ToString().Trim()); //是否处理知识点(字段类型:bit,字段长度:1,是否可空:True)
 objcc_WorkStuRelationEN.IsNotProcessTimeout = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时(字段类型:bit,字段长度:1,是否可空:True)
 objcc_WorkStuRelationEN.SchoolYear = objRow[concc_WorkStuRelation.SchoolYear] == DBNull.Value ? null : objRow[concc_WorkStuRelation.SchoolYear].ToString().Trim(); //学年(字段类型:varchar,字段长度:10,是否可空:True)
 objcc_WorkStuRelationEN.SchoolTerm = objRow[concc_WorkStuRelation.SchoolTerm] == DBNull.Value ? null : objRow[concc_WorkStuRelation.SchoolTerm].ToString().Trim(); //学期(字段类型:char,字段长度:1,是否可空:True)
 objcc_WorkStuRelationEN.ErrMsg = objRow[concc_WorkStuRelation.ErrMsg] == DBNull.Value ? null : objRow[concc_WorkStuRelation.ErrMsg].ToString().Trim(); //错误信息(字段类型:varchar,字段长度:200,是否可空:True)
 objcc_WorkStuRelationEN.CourseId = objRow[concc_WorkStuRelation.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objcc_WorkStuRelationEN.UpdDate = objRow[concc_WorkStuRelation.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_WorkStuRelationEN.UpdUserId = objRow[concc_WorkStuRelation.UpdUserId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_WorkStuRelationEN.Memo = objRow[concc_WorkStuRelation.Memo] == DBNull.Value ? null : objRow[concc_WorkStuRelation.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clscc_WorkStuRelationDA: GetObjByIdWorkStuRelation)", objException.Message));
}
return objcc_WorkStuRelationEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clscc_WorkStuRelationEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clscc_WorkStuRelationDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkStuRelationDA.GetSpecSQLObj();
strSQL = "Select * from cc_WorkStuRelation where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clscc_WorkStuRelationEN objcc_WorkStuRelationEN = new clscc_WorkStuRelationEN()
{
IdWorkStuRelation = TransNullToInt(objRow[concc_WorkStuRelation.IdWorkStuRelation].ToString().Trim()), //流水号
IdCurrEduCls = objRow[concc_WorkStuRelation.IdCurrEduCls].ToString().Trim(), //教学班流水号
QuestionId = TransNullToInt(objRow[concc_WorkStuRelation.QuestionId].ToString().Trim()), //题目Id
Scores = objRow[concc_WorkStuRelation.Scores] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_WorkStuRelation.Scores].ToString().Trim()), //分值
SpecifyCompletionDate = objRow[concc_WorkStuRelation.SpecifyCompletionDate].ToString().Trim(), //指定完成日期
IdStudentInfo = objRow[concc_WorkStuRelation.IdStudentInfo].ToString().Trim(), //学生流水号
AnswerModeId = objRow[concc_WorkStuRelation.AnswerModeId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerModeId].ToString().Trim(), //答案模式Id
AnswerOptionId = objRow[concc_WorkStuRelation.AnswerOptionId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerOptionId].ToString().Trim(), //回答选项Id
AnswerMultiOptions = objRow[concc_WorkStuRelation.AnswerMultiOptions] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerMultiOptions].ToString().Trim(), //多选项答案
AnswerBoolResult = TransNullToBool(objRow[concc_WorkStuRelation.AnswerBoolResult].ToString().Trim()), //答案布尔结果
StuAnswerText = objRow[concc_WorkStuRelation.StuAnswerText] == DBNull.Value ? null : objRow[concc_WorkStuRelation.StuAnswerText].ToString().Trim(), //学生回答文本
IsPublish = TransNullToBool(objRow[concc_WorkStuRelation.IsPublish].ToString().Trim()), //是否发布
IsLook = TransNullToBool(objRow[concc_WorkStuRelation.IsLook].ToString().Trim()), //是否查看
IsSave = TransNullToBool(objRow[concc_WorkStuRelation.IsSave].ToString().Trim()), //是否保存
IsSubmit = TransNullToBool(objRow[concc_WorkStuRelation.IsSubmit].ToString().Trim()), //是否提交
ApplySendBackDate = objRow[concc_WorkStuRelation.ApplySendBackDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation.ApplySendBackDate].ToString().Trim(), //申请退回日期
IsApplySendBack = TransNullToBool(objRow[concc_WorkStuRelation.IsApplySendBack].ToString().Trim()), //是否申请退回
RealFinishDate = objRow[concc_WorkStuRelation.RealFinishDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation.RealFinishDate].ToString().Trim(), //实际完成日期
OperateTime = objRow[concc_WorkStuRelation.OperateTime] == DBNull.Value ? null : objRow[concc_WorkStuRelation.OperateTime].ToString().Trim(), //操作时间
Score = objRow[concc_WorkStuRelation.Score] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_WorkStuRelation.Score].ToString().Trim()), //得分
Comment = objRow[concc_WorkStuRelation.Comment] == DBNull.Value ? null : objRow[concc_WorkStuRelation.Comment].ToString().Trim(), //批注
IsMarking = TransNullToBool(objRow[concc_WorkStuRelation.IsMarking].ToString().Trim()), //是否批阅
MarkerId = objRow[concc_WorkStuRelation.MarkerId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.MarkerId].ToString().Trim(), //打分者
MarkDate = objRow[concc_WorkStuRelation.MarkDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation.MarkDate].ToString().Trim(), //打分日期
IsSendBack = TransNullToBool(objRow[concc_WorkStuRelation.IsSendBack].ToString().Trim()), //是否退回
IsInErrorQuestion = TransNullToBool(objRow[concc_WorkStuRelation.IsInErrorQuestion].ToString().Trim()), //是否进入错题
WorkTypeId = objRow[concc_WorkStuRelation.WorkTypeId].ToString().Trim(), //作业类型Id
AnswerIP = objRow[concc_WorkStuRelation.AnswerIP] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerIP].ToString().Trim(), //回答IP
AnswerDate = objRow[concc_WorkStuRelation.AnswerDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerDate].ToString().Trim(), //回答日期
AnswerTime = objRow[concc_WorkStuRelation.AnswerTime] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerTime].ToString().Trim(), //回答时间
CourseExamPaperId = objRow[concc_WorkStuRelation.CourseExamPaperId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.CourseExamPaperId].ToString().Trim(), //考卷流水号
IsRight = TransNullToBool(objRow[concc_WorkStuRelation.IsRight].ToString().Trim()), //是否正确
IsAccessKnowledge = TransNullToBool(objRow[concc_WorkStuRelation.IsAccessKnowledge].ToString().Trim()), //是否处理知识点
IsNotProcessTimeout = TransNullToBool(objRow[concc_WorkStuRelation.IsNotProcessTimeout].ToString().Trim()), //是否不处理超时
SchoolYear = objRow[concc_WorkStuRelation.SchoolYear] == DBNull.Value ? null : objRow[concc_WorkStuRelation.SchoolYear].ToString().Trim(), //学年
SchoolTerm = objRow[concc_WorkStuRelation.SchoolTerm] == DBNull.Value ? null : objRow[concc_WorkStuRelation.SchoolTerm].ToString().Trim(), //学期
ErrMsg = objRow[concc_WorkStuRelation.ErrMsg] == DBNull.Value ? null : objRow[concc_WorkStuRelation.ErrMsg].ToString().Trim(), //错误信息
CourseId = objRow[concc_WorkStuRelation.CourseId].ToString().Trim(), //课程Id
UpdDate = objRow[concc_WorkStuRelation.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[concc_WorkStuRelation.UpdUserId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[concc_WorkStuRelation.Memo] == DBNull.Value ? null : objRow[concc_WorkStuRelation.Memo].ToString().Trim() //备注
};
objcc_WorkStuRelationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcc_WorkStuRelationEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clscc_WorkStuRelationDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clscc_WorkStuRelationEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clscc_WorkStuRelationEN objcc_WorkStuRelationEN = new clscc_WorkStuRelationEN();
try
{
objcc_WorkStuRelationEN.IdWorkStuRelation = TransNullToInt(objRow[concc_WorkStuRelation.IdWorkStuRelation].ToString().Trim()); //流水号
objcc_WorkStuRelationEN.IdCurrEduCls = objRow[concc_WorkStuRelation.IdCurrEduCls].ToString().Trim(); //教学班流水号
objcc_WorkStuRelationEN.QuestionId = TransNullToInt(objRow[concc_WorkStuRelation.QuestionId].ToString().Trim()); //题目Id
objcc_WorkStuRelationEN.Scores = objRow[concc_WorkStuRelation.Scores] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_WorkStuRelation.Scores].ToString().Trim()); //分值
objcc_WorkStuRelationEN.SpecifyCompletionDate = objRow[concc_WorkStuRelation.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objcc_WorkStuRelationEN.IdStudentInfo = objRow[concc_WorkStuRelation.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_WorkStuRelationEN.AnswerModeId = objRow[concc_WorkStuRelation.AnswerModeId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerModeId].ToString().Trim(); //答案模式Id
objcc_WorkStuRelationEN.AnswerOptionId = objRow[concc_WorkStuRelation.AnswerOptionId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerOptionId].ToString().Trim(); //回答选项Id
objcc_WorkStuRelationEN.AnswerMultiOptions = objRow[concc_WorkStuRelation.AnswerMultiOptions] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerMultiOptions].ToString().Trim(); //多选项答案
objcc_WorkStuRelationEN.AnswerBoolResult = TransNullToBool(objRow[concc_WorkStuRelation.AnswerBoolResult].ToString().Trim()); //答案布尔结果
objcc_WorkStuRelationEN.StuAnswerText = objRow[concc_WorkStuRelation.StuAnswerText] == DBNull.Value ? null : objRow[concc_WorkStuRelation.StuAnswerText].ToString().Trim(); //学生回答文本
objcc_WorkStuRelationEN.IsPublish = TransNullToBool(objRow[concc_WorkStuRelation.IsPublish].ToString().Trim()); //是否发布
objcc_WorkStuRelationEN.IsLook = TransNullToBool(objRow[concc_WorkStuRelation.IsLook].ToString().Trim()); //是否查看
objcc_WorkStuRelationEN.IsSave = TransNullToBool(objRow[concc_WorkStuRelation.IsSave].ToString().Trim()); //是否保存
objcc_WorkStuRelationEN.IsSubmit = TransNullToBool(objRow[concc_WorkStuRelation.IsSubmit].ToString().Trim()); //是否提交
objcc_WorkStuRelationEN.ApplySendBackDate = objRow[concc_WorkStuRelation.ApplySendBackDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation.ApplySendBackDate].ToString().Trim(); //申请退回日期
objcc_WorkStuRelationEN.IsApplySendBack = TransNullToBool(objRow[concc_WorkStuRelation.IsApplySendBack].ToString().Trim()); //是否申请退回
objcc_WorkStuRelationEN.RealFinishDate = objRow[concc_WorkStuRelation.RealFinishDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation.RealFinishDate].ToString().Trim(); //实际完成日期
objcc_WorkStuRelationEN.OperateTime = objRow[concc_WorkStuRelation.OperateTime] == DBNull.Value ? null : objRow[concc_WorkStuRelation.OperateTime].ToString().Trim(); //操作时间
objcc_WorkStuRelationEN.Score = objRow[concc_WorkStuRelation.Score] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_WorkStuRelation.Score].ToString().Trim()); //得分
objcc_WorkStuRelationEN.Comment = objRow[concc_WorkStuRelation.Comment] == DBNull.Value ? null : objRow[concc_WorkStuRelation.Comment].ToString().Trim(); //批注
objcc_WorkStuRelationEN.IsMarking = TransNullToBool(objRow[concc_WorkStuRelation.IsMarking].ToString().Trim()); //是否批阅
objcc_WorkStuRelationEN.MarkerId = objRow[concc_WorkStuRelation.MarkerId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.MarkerId].ToString().Trim(); //打分者
objcc_WorkStuRelationEN.MarkDate = objRow[concc_WorkStuRelation.MarkDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation.MarkDate].ToString().Trim(); //打分日期
objcc_WorkStuRelationEN.IsSendBack = TransNullToBool(objRow[concc_WorkStuRelation.IsSendBack].ToString().Trim()); //是否退回
objcc_WorkStuRelationEN.IsInErrorQuestion = TransNullToBool(objRow[concc_WorkStuRelation.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objcc_WorkStuRelationEN.WorkTypeId = objRow[concc_WorkStuRelation.WorkTypeId].ToString().Trim(); //作业类型Id
objcc_WorkStuRelationEN.AnswerIP = objRow[concc_WorkStuRelation.AnswerIP] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerIP].ToString().Trim(); //回答IP
objcc_WorkStuRelationEN.AnswerDate = objRow[concc_WorkStuRelation.AnswerDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerDate].ToString().Trim(); //回答日期
objcc_WorkStuRelationEN.AnswerTime = objRow[concc_WorkStuRelation.AnswerTime] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerTime].ToString().Trim(); //回答时间
objcc_WorkStuRelationEN.CourseExamPaperId = objRow[concc_WorkStuRelation.CourseExamPaperId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_WorkStuRelationEN.IsRight = TransNullToBool(objRow[concc_WorkStuRelation.IsRight].ToString().Trim()); //是否正确
objcc_WorkStuRelationEN.IsAccessKnowledge = TransNullToBool(objRow[concc_WorkStuRelation.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objcc_WorkStuRelationEN.IsNotProcessTimeout = TransNullToBool(objRow[concc_WorkStuRelation.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objcc_WorkStuRelationEN.SchoolYear = objRow[concc_WorkStuRelation.SchoolYear] == DBNull.Value ? null : objRow[concc_WorkStuRelation.SchoolYear].ToString().Trim(); //学年
objcc_WorkStuRelationEN.SchoolTerm = objRow[concc_WorkStuRelation.SchoolTerm] == DBNull.Value ? null : objRow[concc_WorkStuRelation.SchoolTerm].ToString().Trim(); //学期
objcc_WorkStuRelationEN.ErrMsg = objRow[concc_WorkStuRelation.ErrMsg] == DBNull.Value ? null : objRow[concc_WorkStuRelation.ErrMsg].ToString().Trim(); //错误信息
objcc_WorkStuRelationEN.CourseId = objRow[concc_WorkStuRelation.CourseId].ToString().Trim(); //课程Id
objcc_WorkStuRelationEN.UpdDate = objRow[concc_WorkStuRelation.UpdDate].ToString().Trim(); //修改日期
objcc_WorkStuRelationEN.UpdUserId = objRow[concc_WorkStuRelation.UpdUserId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.UpdUserId].ToString().Trim(); //修改用户Id
objcc_WorkStuRelationEN.Memo = objRow[concc_WorkStuRelation.Memo] == DBNull.Value ? null : objRow[concc_WorkStuRelation.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clscc_WorkStuRelationDA: GetObjByDataRowcc_WorkStuRelation)", objException.Message));
}
objcc_WorkStuRelationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcc_WorkStuRelationEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clscc_WorkStuRelationEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clscc_WorkStuRelationEN objcc_WorkStuRelationEN = new clscc_WorkStuRelationEN();
try
{
objcc_WorkStuRelationEN.IdWorkStuRelation = TransNullToInt(objRow[concc_WorkStuRelation.IdWorkStuRelation].ToString().Trim()); //流水号
objcc_WorkStuRelationEN.IdCurrEduCls = objRow[concc_WorkStuRelation.IdCurrEduCls].ToString().Trim(); //教学班流水号
objcc_WorkStuRelationEN.QuestionId = TransNullToInt(objRow[concc_WorkStuRelation.QuestionId].ToString().Trim()); //题目Id
objcc_WorkStuRelationEN.Scores = objRow[concc_WorkStuRelation.Scores] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_WorkStuRelation.Scores].ToString().Trim()); //分值
objcc_WorkStuRelationEN.SpecifyCompletionDate = objRow[concc_WorkStuRelation.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objcc_WorkStuRelationEN.IdStudentInfo = objRow[concc_WorkStuRelation.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_WorkStuRelationEN.AnswerModeId = objRow[concc_WorkStuRelation.AnswerModeId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerModeId].ToString().Trim(); //答案模式Id
objcc_WorkStuRelationEN.AnswerOptionId = objRow[concc_WorkStuRelation.AnswerOptionId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerOptionId].ToString().Trim(); //回答选项Id
objcc_WorkStuRelationEN.AnswerMultiOptions = objRow[concc_WorkStuRelation.AnswerMultiOptions] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerMultiOptions].ToString().Trim(); //多选项答案
objcc_WorkStuRelationEN.AnswerBoolResult = TransNullToBool(objRow[concc_WorkStuRelation.AnswerBoolResult].ToString().Trim()); //答案布尔结果
objcc_WorkStuRelationEN.StuAnswerText = objRow[concc_WorkStuRelation.StuAnswerText] == DBNull.Value ? null : objRow[concc_WorkStuRelation.StuAnswerText].ToString().Trim(); //学生回答文本
objcc_WorkStuRelationEN.IsPublish = TransNullToBool(objRow[concc_WorkStuRelation.IsPublish].ToString().Trim()); //是否发布
objcc_WorkStuRelationEN.IsLook = TransNullToBool(objRow[concc_WorkStuRelation.IsLook].ToString().Trim()); //是否查看
objcc_WorkStuRelationEN.IsSave = TransNullToBool(objRow[concc_WorkStuRelation.IsSave].ToString().Trim()); //是否保存
objcc_WorkStuRelationEN.IsSubmit = TransNullToBool(objRow[concc_WorkStuRelation.IsSubmit].ToString().Trim()); //是否提交
objcc_WorkStuRelationEN.ApplySendBackDate = objRow[concc_WorkStuRelation.ApplySendBackDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation.ApplySendBackDate].ToString().Trim(); //申请退回日期
objcc_WorkStuRelationEN.IsApplySendBack = TransNullToBool(objRow[concc_WorkStuRelation.IsApplySendBack].ToString().Trim()); //是否申请退回
objcc_WorkStuRelationEN.RealFinishDate = objRow[concc_WorkStuRelation.RealFinishDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation.RealFinishDate].ToString().Trim(); //实际完成日期
objcc_WorkStuRelationEN.OperateTime = objRow[concc_WorkStuRelation.OperateTime] == DBNull.Value ? null : objRow[concc_WorkStuRelation.OperateTime].ToString().Trim(); //操作时间
objcc_WorkStuRelationEN.Score = objRow[concc_WorkStuRelation.Score] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_WorkStuRelation.Score].ToString().Trim()); //得分
objcc_WorkStuRelationEN.Comment = objRow[concc_WorkStuRelation.Comment] == DBNull.Value ? null : objRow[concc_WorkStuRelation.Comment].ToString().Trim(); //批注
objcc_WorkStuRelationEN.IsMarking = TransNullToBool(objRow[concc_WorkStuRelation.IsMarking].ToString().Trim()); //是否批阅
objcc_WorkStuRelationEN.MarkerId = objRow[concc_WorkStuRelation.MarkerId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.MarkerId].ToString().Trim(); //打分者
objcc_WorkStuRelationEN.MarkDate = objRow[concc_WorkStuRelation.MarkDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation.MarkDate].ToString().Trim(); //打分日期
objcc_WorkStuRelationEN.IsSendBack = TransNullToBool(objRow[concc_WorkStuRelation.IsSendBack].ToString().Trim()); //是否退回
objcc_WorkStuRelationEN.IsInErrorQuestion = TransNullToBool(objRow[concc_WorkStuRelation.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objcc_WorkStuRelationEN.WorkTypeId = objRow[concc_WorkStuRelation.WorkTypeId].ToString().Trim(); //作业类型Id
objcc_WorkStuRelationEN.AnswerIP = objRow[concc_WorkStuRelation.AnswerIP] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerIP].ToString().Trim(); //回答IP
objcc_WorkStuRelationEN.AnswerDate = objRow[concc_WorkStuRelation.AnswerDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerDate].ToString().Trim(); //回答日期
objcc_WorkStuRelationEN.AnswerTime = objRow[concc_WorkStuRelation.AnswerTime] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerTime].ToString().Trim(); //回答时间
objcc_WorkStuRelationEN.CourseExamPaperId = objRow[concc_WorkStuRelation.CourseExamPaperId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_WorkStuRelationEN.IsRight = TransNullToBool(objRow[concc_WorkStuRelation.IsRight].ToString().Trim()); //是否正确
objcc_WorkStuRelationEN.IsAccessKnowledge = TransNullToBool(objRow[concc_WorkStuRelation.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objcc_WorkStuRelationEN.IsNotProcessTimeout = TransNullToBool(objRow[concc_WorkStuRelation.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objcc_WorkStuRelationEN.SchoolYear = objRow[concc_WorkStuRelation.SchoolYear] == DBNull.Value ? null : objRow[concc_WorkStuRelation.SchoolYear].ToString().Trim(); //学年
objcc_WorkStuRelationEN.SchoolTerm = objRow[concc_WorkStuRelation.SchoolTerm] == DBNull.Value ? null : objRow[concc_WorkStuRelation.SchoolTerm].ToString().Trim(); //学期
objcc_WorkStuRelationEN.ErrMsg = objRow[concc_WorkStuRelation.ErrMsg] == DBNull.Value ? null : objRow[concc_WorkStuRelation.ErrMsg].ToString().Trim(); //错误信息
objcc_WorkStuRelationEN.CourseId = objRow[concc_WorkStuRelation.CourseId].ToString().Trim(); //课程Id
objcc_WorkStuRelationEN.UpdDate = objRow[concc_WorkStuRelation.UpdDate].ToString().Trim(); //修改日期
objcc_WorkStuRelationEN.UpdUserId = objRow[concc_WorkStuRelation.UpdUserId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.UpdUserId].ToString().Trim(); //修改用户Id
objcc_WorkStuRelationEN.Memo = objRow[concc_WorkStuRelation.Memo] == DBNull.Value ? null : objRow[concc_WorkStuRelation.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clscc_WorkStuRelationDA: GetObjByDataRow)", objException.Message));
}
objcc_WorkStuRelationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcc_WorkStuRelationEN;
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
objSQL = clscc_WorkStuRelationDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clscc_WorkStuRelationEN._CurrTabName, concc_WorkStuRelation.IdWorkStuRelation, 8, "");
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
objSQL = clscc_WorkStuRelationDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clscc_WorkStuRelationEN._CurrTabName, concc_WorkStuRelation.IdWorkStuRelation, 8, strPrefix);
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
 objSQL = clscc_WorkStuRelationDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdWorkStuRelation from cc_WorkStuRelation where " + strCondition;
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
 objSQL = clscc_WorkStuRelationDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdWorkStuRelation from cc_WorkStuRelation where " + strCondition;
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
 objSQL = clscc_WorkStuRelationDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("cc_WorkStuRelation", "IdWorkStuRelation = " + ""+ lngIdWorkStuRelation+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clscc_WorkStuRelationDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkStuRelationDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("cc_WorkStuRelation", strCondition))
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
objSQL = clscc_WorkStuRelationDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("cc_WorkStuRelation");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clscc_WorkStuRelationEN objcc_WorkStuRelationEN)
 {
 objcc_WorkStuRelationEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_WorkStuRelationEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_WorkStuRelationEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkStuRelationDA.GetSpecSQLObj();
strSQL = "Select * from cc_WorkStuRelation where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "cc_WorkStuRelation");
objRow = objDS.Tables["cc_WorkStuRelation"].NewRow();
objRow[concc_WorkStuRelation.IdCurrEduCls] = objcc_WorkStuRelationEN.IdCurrEduCls; //教学班流水号
objRow[concc_WorkStuRelation.QuestionId] = objcc_WorkStuRelationEN.QuestionId; //题目Id
objRow[concc_WorkStuRelation.Scores] = objcc_WorkStuRelationEN.Scores; //分值
objRow[concc_WorkStuRelation.SpecifyCompletionDate] = objcc_WorkStuRelationEN.SpecifyCompletionDate; //指定完成日期
objRow[concc_WorkStuRelation.IdStudentInfo] = objcc_WorkStuRelationEN.IdStudentInfo; //学生流水号
 if (objcc_WorkStuRelationEN.AnswerModeId !=  "")
 {
objRow[concc_WorkStuRelation.AnswerModeId] = objcc_WorkStuRelationEN.AnswerModeId; //答案模式Id
 }
 if (objcc_WorkStuRelationEN.AnswerOptionId !=  "")
 {
objRow[concc_WorkStuRelation.AnswerOptionId] = objcc_WorkStuRelationEN.AnswerOptionId; //回答选项Id
 }
 if (objcc_WorkStuRelationEN.AnswerMultiOptions !=  "")
 {
objRow[concc_WorkStuRelation.AnswerMultiOptions] = objcc_WorkStuRelationEN.AnswerMultiOptions; //多选项答案
 }
objRow[concc_WorkStuRelation.AnswerBoolResult] = objcc_WorkStuRelationEN.AnswerBoolResult; //答案布尔结果
 if (objcc_WorkStuRelationEN.StuAnswerText !=  "")
 {
objRow[concc_WorkStuRelation.StuAnswerText] = objcc_WorkStuRelationEN.StuAnswerText; //学生回答文本
 }
objRow[concc_WorkStuRelation.IsPublish] = objcc_WorkStuRelationEN.IsPublish; //是否发布
objRow[concc_WorkStuRelation.IsLook] = objcc_WorkStuRelationEN.IsLook; //是否查看
objRow[concc_WorkStuRelation.IsSave] = objcc_WorkStuRelationEN.IsSave; //是否保存
objRow[concc_WorkStuRelation.IsSubmit] = objcc_WorkStuRelationEN.IsSubmit; //是否提交
 if (objcc_WorkStuRelationEN.ApplySendBackDate !=  "")
 {
objRow[concc_WorkStuRelation.ApplySendBackDate] = objcc_WorkStuRelationEN.ApplySendBackDate; //申请退回日期
 }
objRow[concc_WorkStuRelation.IsApplySendBack] = objcc_WorkStuRelationEN.IsApplySendBack; //是否申请退回
 if (objcc_WorkStuRelationEN.RealFinishDate !=  "")
 {
objRow[concc_WorkStuRelation.RealFinishDate] = objcc_WorkStuRelationEN.RealFinishDate; //实际完成日期
 }
 if (objcc_WorkStuRelationEN.OperateTime !=  "")
 {
objRow[concc_WorkStuRelation.OperateTime] = objcc_WorkStuRelationEN.OperateTime; //操作时间
 }
objRow[concc_WorkStuRelation.Score] = objcc_WorkStuRelationEN.Score; //得分
 if (objcc_WorkStuRelationEN.Comment !=  "")
 {
objRow[concc_WorkStuRelation.Comment] = objcc_WorkStuRelationEN.Comment; //批注
 }
objRow[concc_WorkStuRelation.IsMarking] = objcc_WorkStuRelationEN.IsMarking; //是否批阅
 if (objcc_WorkStuRelationEN.MarkerId !=  "")
 {
objRow[concc_WorkStuRelation.MarkerId] = objcc_WorkStuRelationEN.MarkerId; //打分者
 }
 if (objcc_WorkStuRelationEN.MarkDate !=  "")
 {
objRow[concc_WorkStuRelation.MarkDate] = objcc_WorkStuRelationEN.MarkDate; //打分日期
 }
objRow[concc_WorkStuRelation.IsSendBack] = objcc_WorkStuRelationEN.IsSendBack; //是否退回
objRow[concc_WorkStuRelation.IsInErrorQuestion] = objcc_WorkStuRelationEN.IsInErrorQuestion; //是否进入错题
objRow[concc_WorkStuRelation.WorkTypeId] = objcc_WorkStuRelationEN.WorkTypeId; //作业类型Id
 if (objcc_WorkStuRelationEN.AnswerIP !=  "")
 {
objRow[concc_WorkStuRelation.AnswerIP] = objcc_WorkStuRelationEN.AnswerIP; //回答IP
 }
 if (objcc_WorkStuRelationEN.AnswerDate !=  "")
 {
objRow[concc_WorkStuRelation.AnswerDate] = objcc_WorkStuRelationEN.AnswerDate; //回答日期
 }
 if (objcc_WorkStuRelationEN.AnswerTime !=  "")
 {
objRow[concc_WorkStuRelation.AnswerTime] = objcc_WorkStuRelationEN.AnswerTime; //回答时间
 }
 if (objcc_WorkStuRelationEN.CourseExamPaperId !=  "")
 {
objRow[concc_WorkStuRelation.CourseExamPaperId] = objcc_WorkStuRelationEN.CourseExamPaperId; //考卷流水号
 }
objRow[concc_WorkStuRelation.IsRight] = objcc_WorkStuRelationEN.IsRight; //是否正确
objRow[concc_WorkStuRelation.IsAccessKnowledge] = objcc_WorkStuRelationEN.IsAccessKnowledge; //是否处理知识点
objRow[concc_WorkStuRelation.IsNotProcessTimeout] = objcc_WorkStuRelationEN.IsNotProcessTimeout; //是否不处理超时
 if (objcc_WorkStuRelationEN.SchoolYear !=  "")
 {
objRow[concc_WorkStuRelation.SchoolYear] = objcc_WorkStuRelationEN.SchoolYear; //学年
 }
 if (objcc_WorkStuRelationEN.SchoolTerm !=  "")
 {
objRow[concc_WorkStuRelation.SchoolTerm] = objcc_WorkStuRelationEN.SchoolTerm; //学期
 }
 if (objcc_WorkStuRelationEN.ErrMsg !=  "")
 {
objRow[concc_WorkStuRelation.ErrMsg] = objcc_WorkStuRelationEN.ErrMsg; //错误信息
 }
objRow[concc_WorkStuRelation.CourseId] = objcc_WorkStuRelationEN.CourseId; //课程Id
objRow[concc_WorkStuRelation.UpdDate] = objcc_WorkStuRelationEN.UpdDate; //修改日期
 if (objcc_WorkStuRelationEN.UpdUserId !=  "")
 {
objRow[concc_WorkStuRelation.UpdUserId] = objcc_WorkStuRelationEN.UpdUserId; //修改用户Id
 }
 if (objcc_WorkStuRelationEN.Memo !=  "")
 {
objRow[concc_WorkStuRelation.Memo] = objcc_WorkStuRelationEN.Memo; //备注
 }
objDS.Tables[clscc_WorkStuRelationEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clscc_WorkStuRelationEN._CurrTabName);
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
 /// <param name = "objcc_WorkStuRelationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clscc_WorkStuRelationEN objcc_WorkStuRelationEN)
{
 objcc_WorkStuRelationEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_WorkStuRelationEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_WorkStuRelationEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objcc_WorkStuRelationEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.IdCurrEduCls);
 var strIdCurrEduCls = objcc_WorkStuRelationEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 arrFieldListForInsert.Add(concc_WorkStuRelation.QuestionId);
 arrValueListForInsert.Add(objcc_WorkStuRelationEN.QuestionId.ToString());
 
 if (objcc_WorkStuRelationEN.Scores !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.Scores);
 arrValueListForInsert.Add(objcc_WorkStuRelationEN.Scores.ToString());
 }
 
 if (objcc_WorkStuRelationEN.SpecifyCompletionDate !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.SpecifyCompletionDate);
 var strSpecifyCompletionDate = objcc_WorkStuRelationEN.SpecifyCompletionDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSpecifyCompletionDate + "'");
 }
 
 if (objcc_WorkStuRelationEN.IdStudentInfo  ==  "")
 {
 objcc_WorkStuRelationEN.IdStudentInfo = null;
 }
 if (objcc_WorkStuRelationEN.IdStudentInfo !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.IdStudentInfo);
 var strIdStudentInfo = objcc_WorkStuRelationEN.IdStudentInfo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudentInfo + "'");
 }
 
 if (objcc_WorkStuRelationEN.AnswerModeId !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.AnswerModeId);
 var strAnswerModeId = objcc_WorkStuRelationEN.AnswerModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerModeId + "'");
 }
 
 if (objcc_WorkStuRelationEN.AnswerOptionId !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.AnswerOptionId);
 var strAnswerOptionId = objcc_WorkStuRelationEN.AnswerOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerOptionId + "'");
 }
 
 if (objcc_WorkStuRelationEN.AnswerMultiOptions !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.AnswerMultiOptions);
 var strAnswerMultiOptions = objcc_WorkStuRelationEN.AnswerMultiOptions.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerMultiOptions + "'");
 }
 
 arrFieldListForInsert.Add(concc_WorkStuRelation.AnswerBoolResult);
 arrValueListForInsert.Add("'" + (objcc_WorkStuRelationEN.AnswerBoolResult  ==  false ? "0" : "1") + "'");
 
 if (objcc_WorkStuRelationEN.StuAnswerText !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.StuAnswerText);
 var strStuAnswerText = objcc_WorkStuRelationEN.StuAnswerText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStuAnswerText + "'");
 }
 
 arrFieldListForInsert.Add(concc_WorkStuRelation.IsPublish);
 arrValueListForInsert.Add("'" + (objcc_WorkStuRelationEN.IsPublish  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_WorkStuRelation.IsLook);
 arrValueListForInsert.Add("'" + (objcc_WorkStuRelationEN.IsLook  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_WorkStuRelation.IsSave);
 arrValueListForInsert.Add("'" + (objcc_WorkStuRelationEN.IsSave  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_WorkStuRelation.IsSubmit);
 arrValueListForInsert.Add("'" + (objcc_WorkStuRelationEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objcc_WorkStuRelationEN.ApplySendBackDate !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.ApplySendBackDate);
 var strApplySendBackDate = objcc_WorkStuRelationEN.ApplySendBackDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strApplySendBackDate + "'");
 }
 
 arrFieldListForInsert.Add(concc_WorkStuRelation.IsApplySendBack);
 arrValueListForInsert.Add("'" + (objcc_WorkStuRelationEN.IsApplySendBack  ==  false ? "0" : "1") + "'");
 
 if (objcc_WorkStuRelationEN.RealFinishDate !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.RealFinishDate);
 var strRealFinishDate = objcc_WorkStuRelationEN.RealFinishDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRealFinishDate + "'");
 }
 
 if (objcc_WorkStuRelationEN.OperateTime !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.OperateTime);
 var strOperateTime = objcc_WorkStuRelationEN.OperateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOperateTime + "'");
 }
 
 if (objcc_WorkStuRelationEN.Score !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.Score);
 arrValueListForInsert.Add(objcc_WorkStuRelationEN.Score.ToString());
 }
 
 if (objcc_WorkStuRelationEN.Comment !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.Comment);
 var strComment = objcc_WorkStuRelationEN.Comment.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strComment + "'");
 }
 
 arrFieldListForInsert.Add(concc_WorkStuRelation.IsMarking);
 arrValueListForInsert.Add("'" + (objcc_WorkStuRelationEN.IsMarking  ==  false ? "0" : "1") + "'");
 
 if (objcc_WorkStuRelationEN.MarkerId !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.MarkerId);
 var strMarkerId = objcc_WorkStuRelationEN.MarkerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMarkerId + "'");
 }
 
 if (objcc_WorkStuRelationEN.MarkDate !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.MarkDate);
 var strMarkDate = objcc_WorkStuRelationEN.MarkDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMarkDate + "'");
 }
 
 arrFieldListForInsert.Add(concc_WorkStuRelation.IsSendBack);
 arrValueListForInsert.Add("'" + (objcc_WorkStuRelationEN.IsSendBack  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_WorkStuRelation.IsInErrorQuestion);
 arrValueListForInsert.Add("'" + (objcc_WorkStuRelationEN.IsInErrorQuestion  ==  false ? "0" : "1") + "'");
 
 if (objcc_WorkStuRelationEN.WorkTypeId !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.WorkTypeId);
 var strWorkTypeId = objcc_WorkStuRelationEN.WorkTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWorkTypeId + "'");
 }
 
 if (objcc_WorkStuRelationEN.AnswerIP !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.AnswerIP);
 var strAnswerIP = objcc_WorkStuRelationEN.AnswerIP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerIP + "'");
 }
 
 if (objcc_WorkStuRelationEN.AnswerDate !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.AnswerDate);
 var strAnswerDate = objcc_WorkStuRelationEN.AnswerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerDate + "'");
 }
 
 if (objcc_WorkStuRelationEN.AnswerTime !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.AnswerTime);
 var strAnswerTime = objcc_WorkStuRelationEN.AnswerTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerTime + "'");
 }
 
 if (objcc_WorkStuRelationEN.CourseExamPaperId !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.CourseExamPaperId);
 var strCourseExamPaperId = objcc_WorkStuRelationEN.CourseExamPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseExamPaperId + "'");
 }
 
 arrFieldListForInsert.Add(concc_WorkStuRelation.IsRight);
 arrValueListForInsert.Add("'" + (objcc_WorkStuRelationEN.IsRight  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_WorkStuRelation.IsAccessKnowledge);
 arrValueListForInsert.Add("'" + (objcc_WorkStuRelationEN.IsAccessKnowledge  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_WorkStuRelation.IsNotProcessTimeout);
 arrValueListForInsert.Add("'" + (objcc_WorkStuRelationEN.IsNotProcessTimeout  ==  false ? "0" : "1") + "'");
 
 if (objcc_WorkStuRelationEN.SchoolYear !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.SchoolYear);
 var strSchoolYear = objcc_WorkStuRelationEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolYear + "'");
 }
 
 if (objcc_WorkStuRelationEN.SchoolTerm !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.SchoolTerm);
 var strSchoolTerm = objcc_WorkStuRelationEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolTerm + "'");
 }
 
 if (objcc_WorkStuRelationEN.ErrMsg !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.ErrMsg);
 var strErrMsg = objcc_WorkStuRelationEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrMsg + "'");
 }
 
 if (objcc_WorkStuRelationEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.CourseId);
 var strCourseId = objcc_WorkStuRelationEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objcc_WorkStuRelationEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.UpdDate);
 var strUpdDate = objcc_WorkStuRelationEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcc_WorkStuRelationEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.UpdUserId);
 var strUpdUserId = objcc_WorkStuRelationEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objcc_WorkStuRelationEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.Memo);
 var strMemo = objcc_WorkStuRelationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_WorkStuRelation");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkStuRelationDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clscc_WorkStuRelationEN objcc_WorkStuRelationEN)
{
 objcc_WorkStuRelationEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_WorkStuRelationEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_WorkStuRelationEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objcc_WorkStuRelationEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.IdCurrEduCls);
 var strIdCurrEduCls = objcc_WorkStuRelationEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 arrFieldListForInsert.Add(concc_WorkStuRelation.QuestionId);
 arrValueListForInsert.Add(objcc_WorkStuRelationEN.QuestionId.ToString());
 
 if (objcc_WorkStuRelationEN.Scores !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.Scores);
 arrValueListForInsert.Add(objcc_WorkStuRelationEN.Scores.ToString());
 }
 
 if (objcc_WorkStuRelationEN.SpecifyCompletionDate !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.SpecifyCompletionDate);
 var strSpecifyCompletionDate = objcc_WorkStuRelationEN.SpecifyCompletionDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSpecifyCompletionDate + "'");
 }
 
 if (objcc_WorkStuRelationEN.IdStudentInfo  ==  "")
 {
 objcc_WorkStuRelationEN.IdStudentInfo = null;
 }
 if (objcc_WorkStuRelationEN.IdStudentInfo !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.IdStudentInfo);
 var strIdStudentInfo = objcc_WorkStuRelationEN.IdStudentInfo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudentInfo + "'");
 }
 
 if (objcc_WorkStuRelationEN.AnswerModeId !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.AnswerModeId);
 var strAnswerModeId = objcc_WorkStuRelationEN.AnswerModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerModeId + "'");
 }
 
 if (objcc_WorkStuRelationEN.AnswerOptionId !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.AnswerOptionId);
 var strAnswerOptionId = objcc_WorkStuRelationEN.AnswerOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerOptionId + "'");
 }
 
 if (objcc_WorkStuRelationEN.AnswerMultiOptions !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.AnswerMultiOptions);
 var strAnswerMultiOptions = objcc_WorkStuRelationEN.AnswerMultiOptions.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerMultiOptions + "'");
 }
 
 arrFieldListForInsert.Add(concc_WorkStuRelation.AnswerBoolResult);
 arrValueListForInsert.Add("'" + (objcc_WorkStuRelationEN.AnswerBoolResult  ==  false ? "0" : "1") + "'");
 
 if (objcc_WorkStuRelationEN.StuAnswerText !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.StuAnswerText);
 var strStuAnswerText = objcc_WorkStuRelationEN.StuAnswerText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStuAnswerText + "'");
 }
 
 arrFieldListForInsert.Add(concc_WorkStuRelation.IsPublish);
 arrValueListForInsert.Add("'" + (objcc_WorkStuRelationEN.IsPublish  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_WorkStuRelation.IsLook);
 arrValueListForInsert.Add("'" + (objcc_WorkStuRelationEN.IsLook  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_WorkStuRelation.IsSave);
 arrValueListForInsert.Add("'" + (objcc_WorkStuRelationEN.IsSave  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_WorkStuRelation.IsSubmit);
 arrValueListForInsert.Add("'" + (objcc_WorkStuRelationEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objcc_WorkStuRelationEN.ApplySendBackDate !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.ApplySendBackDate);
 var strApplySendBackDate = objcc_WorkStuRelationEN.ApplySendBackDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strApplySendBackDate + "'");
 }
 
 arrFieldListForInsert.Add(concc_WorkStuRelation.IsApplySendBack);
 arrValueListForInsert.Add("'" + (objcc_WorkStuRelationEN.IsApplySendBack  ==  false ? "0" : "1") + "'");
 
 if (objcc_WorkStuRelationEN.RealFinishDate !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.RealFinishDate);
 var strRealFinishDate = objcc_WorkStuRelationEN.RealFinishDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRealFinishDate + "'");
 }
 
 if (objcc_WorkStuRelationEN.OperateTime !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.OperateTime);
 var strOperateTime = objcc_WorkStuRelationEN.OperateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOperateTime + "'");
 }
 
 if (objcc_WorkStuRelationEN.Score !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.Score);
 arrValueListForInsert.Add(objcc_WorkStuRelationEN.Score.ToString());
 }
 
 if (objcc_WorkStuRelationEN.Comment !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.Comment);
 var strComment = objcc_WorkStuRelationEN.Comment.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strComment + "'");
 }
 
 arrFieldListForInsert.Add(concc_WorkStuRelation.IsMarking);
 arrValueListForInsert.Add("'" + (objcc_WorkStuRelationEN.IsMarking  ==  false ? "0" : "1") + "'");
 
 if (objcc_WorkStuRelationEN.MarkerId !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.MarkerId);
 var strMarkerId = objcc_WorkStuRelationEN.MarkerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMarkerId + "'");
 }
 
 if (objcc_WorkStuRelationEN.MarkDate !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.MarkDate);
 var strMarkDate = objcc_WorkStuRelationEN.MarkDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMarkDate + "'");
 }
 
 arrFieldListForInsert.Add(concc_WorkStuRelation.IsSendBack);
 arrValueListForInsert.Add("'" + (objcc_WorkStuRelationEN.IsSendBack  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_WorkStuRelation.IsInErrorQuestion);
 arrValueListForInsert.Add("'" + (objcc_WorkStuRelationEN.IsInErrorQuestion  ==  false ? "0" : "1") + "'");
 
 if (objcc_WorkStuRelationEN.WorkTypeId !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.WorkTypeId);
 var strWorkTypeId = objcc_WorkStuRelationEN.WorkTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWorkTypeId + "'");
 }
 
 if (objcc_WorkStuRelationEN.AnswerIP !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.AnswerIP);
 var strAnswerIP = objcc_WorkStuRelationEN.AnswerIP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerIP + "'");
 }
 
 if (objcc_WorkStuRelationEN.AnswerDate !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.AnswerDate);
 var strAnswerDate = objcc_WorkStuRelationEN.AnswerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerDate + "'");
 }
 
 if (objcc_WorkStuRelationEN.AnswerTime !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.AnswerTime);
 var strAnswerTime = objcc_WorkStuRelationEN.AnswerTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerTime + "'");
 }
 
 if (objcc_WorkStuRelationEN.CourseExamPaperId !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.CourseExamPaperId);
 var strCourseExamPaperId = objcc_WorkStuRelationEN.CourseExamPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseExamPaperId + "'");
 }
 
 arrFieldListForInsert.Add(concc_WorkStuRelation.IsRight);
 arrValueListForInsert.Add("'" + (objcc_WorkStuRelationEN.IsRight  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_WorkStuRelation.IsAccessKnowledge);
 arrValueListForInsert.Add("'" + (objcc_WorkStuRelationEN.IsAccessKnowledge  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_WorkStuRelation.IsNotProcessTimeout);
 arrValueListForInsert.Add("'" + (objcc_WorkStuRelationEN.IsNotProcessTimeout  ==  false ? "0" : "1") + "'");
 
 if (objcc_WorkStuRelationEN.SchoolYear !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.SchoolYear);
 var strSchoolYear = objcc_WorkStuRelationEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolYear + "'");
 }
 
 if (objcc_WorkStuRelationEN.SchoolTerm !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.SchoolTerm);
 var strSchoolTerm = objcc_WorkStuRelationEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolTerm + "'");
 }
 
 if (objcc_WorkStuRelationEN.ErrMsg !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.ErrMsg);
 var strErrMsg = objcc_WorkStuRelationEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrMsg + "'");
 }
 
 if (objcc_WorkStuRelationEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.CourseId);
 var strCourseId = objcc_WorkStuRelationEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objcc_WorkStuRelationEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.UpdDate);
 var strUpdDate = objcc_WorkStuRelationEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcc_WorkStuRelationEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.UpdUserId);
 var strUpdUserId = objcc_WorkStuRelationEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objcc_WorkStuRelationEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.Memo);
 var strMemo = objcc_WorkStuRelationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_WorkStuRelation");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkStuRelationDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clscc_WorkStuRelationEN objcc_WorkStuRelationEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objcc_WorkStuRelationEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_WorkStuRelationEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_WorkStuRelationEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objcc_WorkStuRelationEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.IdCurrEduCls);
 var strIdCurrEduCls = objcc_WorkStuRelationEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 arrFieldListForInsert.Add(concc_WorkStuRelation.QuestionId);
 arrValueListForInsert.Add(objcc_WorkStuRelationEN.QuestionId.ToString());
 
 if (objcc_WorkStuRelationEN.Scores !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.Scores);
 arrValueListForInsert.Add(objcc_WorkStuRelationEN.Scores.ToString());
 }
 
 if (objcc_WorkStuRelationEN.SpecifyCompletionDate !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.SpecifyCompletionDate);
 var strSpecifyCompletionDate = objcc_WorkStuRelationEN.SpecifyCompletionDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSpecifyCompletionDate + "'");
 }
 
 if (objcc_WorkStuRelationEN.IdStudentInfo  ==  "")
 {
 objcc_WorkStuRelationEN.IdStudentInfo = null;
 }
 if (objcc_WorkStuRelationEN.IdStudentInfo !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.IdStudentInfo);
 var strIdStudentInfo = objcc_WorkStuRelationEN.IdStudentInfo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudentInfo + "'");
 }
 
 if (objcc_WorkStuRelationEN.AnswerModeId !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.AnswerModeId);
 var strAnswerModeId = objcc_WorkStuRelationEN.AnswerModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerModeId + "'");
 }
 
 if (objcc_WorkStuRelationEN.AnswerOptionId !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.AnswerOptionId);
 var strAnswerOptionId = objcc_WorkStuRelationEN.AnswerOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerOptionId + "'");
 }
 
 if (objcc_WorkStuRelationEN.AnswerMultiOptions !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.AnswerMultiOptions);
 var strAnswerMultiOptions = objcc_WorkStuRelationEN.AnswerMultiOptions.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerMultiOptions + "'");
 }
 
 arrFieldListForInsert.Add(concc_WorkStuRelation.AnswerBoolResult);
 arrValueListForInsert.Add("'" + (objcc_WorkStuRelationEN.AnswerBoolResult  ==  false ? "0" : "1") + "'");
 
 if (objcc_WorkStuRelationEN.StuAnswerText !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.StuAnswerText);
 var strStuAnswerText = objcc_WorkStuRelationEN.StuAnswerText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStuAnswerText + "'");
 }
 
 arrFieldListForInsert.Add(concc_WorkStuRelation.IsPublish);
 arrValueListForInsert.Add("'" + (objcc_WorkStuRelationEN.IsPublish  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_WorkStuRelation.IsLook);
 arrValueListForInsert.Add("'" + (objcc_WorkStuRelationEN.IsLook  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_WorkStuRelation.IsSave);
 arrValueListForInsert.Add("'" + (objcc_WorkStuRelationEN.IsSave  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_WorkStuRelation.IsSubmit);
 arrValueListForInsert.Add("'" + (objcc_WorkStuRelationEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objcc_WorkStuRelationEN.ApplySendBackDate !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.ApplySendBackDate);
 var strApplySendBackDate = objcc_WorkStuRelationEN.ApplySendBackDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strApplySendBackDate + "'");
 }
 
 arrFieldListForInsert.Add(concc_WorkStuRelation.IsApplySendBack);
 arrValueListForInsert.Add("'" + (objcc_WorkStuRelationEN.IsApplySendBack  ==  false ? "0" : "1") + "'");
 
 if (objcc_WorkStuRelationEN.RealFinishDate !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.RealFinishDate);
 var strRealFinishDate = objcc_WorkStuRelationEN.RealFinishDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRealFinishDate + "'");
 }
 
 if (objcc_WorkStuRelationEN.OperateTime !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.OperateTime);
 var strOperateTime = objcc_WorkStuRelationEN.OperateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOperateTime + "'");
 }
 
 if (objcc_WorkStuRelationEN.Score !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.Score);
 arrValueListForInsert.Add(objcc_WorkStuRelationEN.Score.ToString());
 }
 
 if (objcc_WorkStuRelationEN.Comment !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.Comment);
 var strComment = objcc_WorkStuRelationEN.Comment.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strComment + "'");
 }
 
 arrFieldListForInsert.Add(concc_WorkStuRelation.IsMarking);
 arrValueListForInsert.Add("'" + (objcc_WorkStuRelationEN.IsMarking  ==  false ? "0" : "1") + "'");
 
 if (objcc_WorkStuRelationEN.MarkerId !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.MarkerId);
 var strMarkerId = objcc_WorkStuRelationEN.MarkerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMarkerId + "'");
 }
 
 if (objcc_WorkStuRelationEN.MarkDate !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.MarkDate);
 var strMarkDate = objcc_WorkStuRelationEN.MarkDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMarkDate + "'");
 }
 
 arrFieldListForInsert.Add(concc_WorkStuRelation.IsSendBack);
 arrValueListForInsert.Add("'" + (objcc_WorkStuRelationEN.IsSendBack  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_WorkStuRelation.IsInErrorQuestion);
 arrValueListForInsert.Add("'" + (objcc_WorkStuRelationEN.IsInErrorQuestion  ==  false ? "0" : "1") + "'");
 
 if (objcc_WorkStuRelationEN.WorkTypeId !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.WorkTypeId);
 var strWorkTypeId = objcc_WorkStuRelationEN.WorkTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWorkTypeId + "'");
 }
 
 if (objcc_WorkStuRelationEN.AnswerIP !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.AnswerIP);
 var strAnswerIP = objcc_WorkStuRelationEN.AnswerIP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerIP + "'");
 }
 
 if (objcc_WorkStuRelationEN.AnswerDate !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.AnswerDate);
 var strAnswerDate = objcc_WorkStuRelationEN.AnswerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerDate + "'");
 }
 
 if (objcc_WorkStuRelationEN.AnswerTime !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.AnswerTime);
 var strAnswerTime = objcc_WorkStuRelationEN.AnswerTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerTime + "'");
 }
 
 if (objcc_WorkStuRelationEN.CourseExamPaperId !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.CourseExamPaperId);
 var strCourseExamPaperId = objcc_WorkStuRelationEN.CourseExamPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseExamPaperId + "'");
 }
 
 arrFieldListForInsert.Add(concc_WorkStuRelation.IsRight);
 arrValueListForInsert.Add("'" + (objcc_WorkStuRelationEN.IsRight  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_WorkStuRelation.IsAccessKnowledge);
 arrValueListForInsert.Add("'" + (objcc_WorkStuRelationEN.IsAccessKnowledge  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_WorkStuRelation.IsNotProcessTimeout);
 arrValueListForInsert.Add("'" + (objcc_WorkStuRelationEN.IsNotProcessTimeout  ==  false ? "0" : "1") + "'");
 
 if (objcc_WorkStuRelationEN.SchoolYear !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.SchoolYear);
 var strSchoolYear = objcc_WorkStuRelationEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolYear + "'");
 }
 
 if (objcc_WorkStuRelationEN.SchoolTerm !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.SchoolTerm);
 var strSchoolTerm = objcc_WorkStuRelationEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolTerm + "'");
 }
 
 if (objcc_WorkStuRelationEN.ErrMsg !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.ErrMsg);
 var strErrMsg = objcc_WorkStuRelationEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrMsg + "'");
 }
 
 if (objcc_WorkStuRelationEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.CourseId);
 var strCourseId = objcc_WorkStuRelationEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objcc_WorkStuRelationEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.UpdDate);
 var strUpdDate = objcc_WorkStuRelationEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcc_WorkStuRelationEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.UpdUserId);
 var strUpdUserId = objcc_WorkStuRelationEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objcc_WorkStuRelationEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.Memo);
 var strMemo = objcc_WorkStuRelationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_WorkStuRelation");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkStuRelationDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clscc_WorkStuRelationEN objcc_WorkStuRelationEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objcc_WorkStuRelationEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_WorkStuRelationEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_WorkStuRelationEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objcc_WorkStuRelationEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.IdCurrEduCls);
 var strIdCurrEduCls = objcc_WorkStuRelationEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 arrFieldListForInsert.Add(concc_WorkStuRelation.QuestionId);
 arrValueListForInsert.Add(objcc_WorkStuRelationEN.QuestionId.ToString());
 
 if (objcc_WorkStuRelationEN.Scores !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.Scores);
 arrValueListForInsert.Add(objcc_WorkStuRelationEN.Scores.ToString());
 }
 
 if (objcc_WorkStuRelationEN.SpecifyCompletionDate !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.SpecifyCompletionDate);
 var strSpecifyCompletionDate = objcc_WorkStuRelationEN.SpecifyCompletionDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSpecifyCompletionDate + "'");
 }
 
 if (objcc_WorkStuRelationEN.IdStudentInfo  ==  "")
 {
 objcc_WorkStuRelationEN.IdStudentInfo = null;
 }
 if (objcc_WorkStuRelationEN.IdStudentInfo !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.IdStudentInfo);
 var strIdStudentInfo = objcc_WorkStuRelationEN.IdStudentInfo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudentInfo + "'");
 }
 
 if (objcc_WorkStuRelationEN.AnswerModeId !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.AnswerModeId);
 var strAnswerModeId = objcc_WorkStuRelationEN.AnswerModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerModeId + "'");
 }
 
 if (objcc_WorkStuRelationEN.AnswerOptionId !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.AnswerOptionId);
 var strAnswerOptionId = objcc_WorkStuRelationEN.AnswerOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerOptionId + "'");
 }
 
 if (objcc_WorkStuRelationEN.AnswerMultiOptions !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.AnswerMultiOptions);
 var strAnswerMultiOptions = objcc_WorkStuRelationEN.AnswerMultiOptions.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerMultiOptions + "'");
 }
 
 arrFieldListForInsert.Add(concc_WorkStuRelation.AnswerBoolResult);
 arrValueListForInsert.Add("'" + (objcc_WorkStuRelationEN.AnswerBoolResult  ==  false ? "0" : "1") + "'");
 
 if (objcc_WorkStuRelationEN.StuAnswerText !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.StuAnswerText);
 var strStuAnswerText = objcc_WorkStuRelationEN.StuAnswerText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStuAnswerText + "'");
 }
 
 arrFieldListForInsert.Add(concc_WorkStuRelation.IsPublish);
 arrValueListForInsert.Add("'" + (objcc_WorkStuRelationEN.IsPublish  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_WorkStuRelation.IsLook);
 arrValueListForInsert.Add("'" + (objcc_WorkStuRelationEN.IsLook  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_WorkStuRelation.IsSave);
 arrValueListForInsert.Add("'" + (objcc_WorkStuRelationEN.IsSave  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_WorkStuRelation.IsSubmit);
 arrValueListForInsert.Add("'" + (objcc_WorkStuRelationEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objcc_WorkStuRelationEN.ApplySendBackDate !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.ApplySendBackDate);
 var strApplySendBackDate = objcc_WorkStuRelationEN.ApplySendBackDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strApplySendBackDate + "'");
 }
 
 arrFieldListForInsert.Add(concc_WorkStuRelation.IsApplySendBack);
 arrValueListForInsert.Add("'" + (objcc_WorkStuRelationEN.IsApplySendBack  ==  false ? "0" : "1") + "'");
 
 if (objcc_WorkStuRelationEN.RealFinishDate !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.RealFinishDate);
 var strRealFinishDate = objcc_WorkStuRelationEN.RealFinishDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRealFinishDate + "'");
 }
 
 if (objcc_WorkStuRelationEN.OperateTime !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.OperateTime);
 var strOperateTime = objcc_WorkStuRelationEN.OperateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOperateTime + "'");
 }
 
 if (objcc_WorkStuRelationEN.Score !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.Score);
 arrValueListForInsert.Add(objcc_WorkStuRelationEN.Score.ToString());
 }
 
 if (objcc_WorkStuRelationEN.Comment !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.Comment);
 var strComment = objcc_WorkStuRelationEN.Comment.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strComment + "'");
 }
 
 arrFieldListForInsert.Add(concc_WorkStuRelation.IsMarking);
 arrValueListForInsert.Add("'" + (objcc_WorkStuRelationEN.IsMarking  ==  false ? "0" : "1") + "'");
 
 if (objcc_WorkStuRelationEN.MarkerId !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.MarkerId);
 var strMarkerId = objcc_WorkStuRelationEN.MarkerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMarkerId + "'");
 }
 
 if (objcc_WorkStuRelationEN.MarkDate !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.MarkDate);
 var strMarkDate = objcc_WorkStuRelationEN.MarkDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMarkDate + "'");
 }
 
 arrFieldListForInsert.Add(concc_WorkStuRelation.IsSendBack);
 arrValueListForInsert.Add("'" + (objcc_WorkStuRelationEN.IsSendBack  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_WorkStuRelation.IsInErrorQuestion);
 arrValueListForInsert.Add("'" + (objcc_WorkStuRelationEN.IsInErrorQuestion  ==  false ? "0" : "1") + "'");
 
 if (objcc_WorkStuRelationEN.WorkTypeId !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.WorkTypeId);
 var strWorkTypeId = objcc_WorkStuRelationEN.WorkTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWorkTypeId + "'");
 }
 
 if (objcc_WorkStuRelationEN.AnswerIP !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.AnswerIP);
 var strAnswerIP = objcc_WorkStuRelationEN.AnswerIP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerIP + "'");
 }
 
 if (objcc_WorkStuRelationEN.AnswerDate !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.AnswerDate);
 var strAnswerDate = objcc_WorkStuRelationEN.AnswerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerDate + "'");
 }
 
 if (objcc_WorkStuRelationEN.AnswerTime !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.AnswerTime);
 var strAnswerTime = objcc_WorkStuRelationEN.AnswerTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerTime + "'");
 }
 
 if (objcc_WorkStuRelationEN.CourseExamPaperId !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.CourseExamPaperId);
 var strCourseExamPaperId = objcc_WorkStuRelationEN.CourseExamPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseExamPaperId + "'");
 }
 
 arrFieldListForInsert.Add(concc_WorkStuRelation.IsRight);
 arrValueListForInsert.Add("'" + (objcc_WorkStuRelationEN.IsRight  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_WorkStuRelation.IsAccessKnowledge);
 arrValueListForInsert.Add("'" + (objcc_WorkStuRelationEN.IsAccessKnowledge  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_WorkStuRelation.IsNotProcessTimeout);
 arrValueListForInsert.Add("'" + (objcc_WorkStuRelationEN.IsNotProcessTimeout  ==  false ? "0" : "1") + "'");
 
 if (objcc_WorkStuRelationEN.SchoolYear !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.SchoolYear);
 var strSchoolYear = objcc_WorkStuRelationEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolYear + "'");
 }
 
 if (objcc_WorkStuRelationEN.SchoolTerm !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.SchoolTerm);
 var strSchoolTerm = objcc_WorkStuRelationEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolTerm + "'");
 }
 
 if (objcc_WorkStuRelationEN.ErrMsg !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.ErrMsg);
 var strErrMsg = objcc_WorkStuRelationEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrMsg + "'");
 }
 
 if (objcc_WorkStuRelationEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.CourseId);
 var strCourseId = objcc_WorkStuRelationEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objcc_WorkStuRelationEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.UpdDate);
 var strUpdDate = objcc_WorkStuRelationEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcc_WorkStuRelationEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.UpdUserId);
 var strUpdUserId = objcc_WorkStuRelationEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objcc_WorkStuRelationEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkStuRelation.Memo);
 var strMemo = objcc_WorkStuRelationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_WorkStuRelation");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkStuRelationDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewcc_WorkStuRelations(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkStuRelationDA.GetSpecSQLObj();
strSQL = "Select * from cc_WorkStuRelation where IdWorkStuRelation = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "cc_WorkStuRelation");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngIdWorkStuRelation = TransNullToInt(oRow[concc_WorkStuRelation.IdWorkStuRelation].ToString().Trim());
if (IsExist(lngIdWorkStuRelation))
{
 string strResult = "关键字变量值为:" + string.Format("IdWorkStuRelation = {0}", lngIdWorkStuRelation) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clscc_WorkStuRelationEN._CurrTabName ].NewRow();
objRow[concc_WorkStuRelation.IdCurrEduCls] = oRow[concc_WorkStuRelation.IdCurrEduCls].ToString().Trim(); //教学班流水号
objRow[concc_WorkStuRelation.QuestionId] = oRow[concc_WorkStuRelation.QuestionId].ToString().Trim(); //题目Id
objRow[concc_WorkStuRelation.Scores] = oRow[concc_WorkStuRelation.Scores].ToString().Trim(); //分值
objRow[concc_WorkStuRelation.SpecifyCompletionDate] = oRow[concc_WorkStuRelation.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objRow[concc_WorkStuRelation.IdStudentInfo] = oRow[concc_WorkStuRelation.IdStudentInfo].ToString().Trim(); //学生流水号
objRow[concc_WorkStuRelation.AnswerModeId] = oRow[concc_WorkStuRelation.AnswerModeId].ToString().Trim(); //答案模式Id
objRow[concc_WorkStuRelation.AnswerOptionId] = oRow[concc_WorkStuRelation.AnswerOptionId].ToString().Trim(); //回答选项Id
objRow[concc_WorkStuRelation.AnswerMultiOptions] = oRow[concc_WorkStuRelation.AnswerMultiOptions].ToString().Trim(); //多选项答案
objRow[concc_WorkStuRelation.AnswerBoolResult] = oRow[concc_WorkStuRelation.AnswerBoolResult].ToString().Trim(); //答案布尔结果
objRow[concc_WorkStuRelation.StuAnswerText] = oRow[concc_WorkStuRelation.StuAnswerText].ToString().Trim(); //学生回答文本
objRow[concc_WorkStuRelation.IsPublish] = oRow[concc_WorkStuRelation.IsPublish].ToString().Trim(); //是否发布
objRow[concc_WorkStuRelation.IsLook] = oRow[concc_WorkStuRelation.IsLook].ToString().Trim(); //是否查看
objRow[concc_WorkStuRelation.IsSave] = oRow[concc_WorkStuRelation.IsSave].ToString().Trim(); //是否保存
objRow[concc_WorkStuRelation.IsSubmit] = oRow[concc_WorkStuRelation.IsSubmit].ToString().Trim(); //是否提交
objRow[concc_WorkStuRelation.ApplySendBackDate] = oRow[concc_WorkStuRelation.ApplySendBackDate].ToString().Trim(); //申请退回日期
objRow[concc_WorkStuRelation.IsApplySendBack] = oRow[concc_WorkStuRelation.IsApplySendBack].ToString().Trim(); //是否申请退回
objRow[concc_WorkStuRelation.RealFinishDate] = oRow[concc_WorkStuRelation.RealFinishDate].ToString().Trim(); //实际完成日期
objRow[concc_WorkStuRelation.OperateTime] = oRow[concc_WorkStuRelation.OperateTime].ToString().Trim(); //操作时间
objRow[concc_WorkStuRelation.Score] = oRow[concc_WorkStuRelation.Score].ToString().Trim(); //得分
objRow[concc_WorkStuRelation.Comment] = oRow[concc_WorkStuRelation.Comment].ToString().Trim(); //批注
objRow[concc_WorkStuRelation.IsMarking] = oRow[concc_WorkStuRelation.IsMarking].ToString().Trim(); //是否批阅
objRow[concc_WorkStuRelation.MarkerId] = oRow[concc_WorkStuRelation.MarkerId].ToString().Trim(); //打分者
objRow[concc_WorkStuRelation.MarkDate] = oRow[concc_WorkStuRelation.MarkDate].ToString().Trim(); //打分日期
objRow[concc_WorkStuRelation.IsSendBack] = oRow[concc_WorkStuRelation.IsSendBack].ToString().Trim(); //是否退回
objRow[concc_WorkStuRelation.IsInErrorQuestion] = oRow[concc_WorkStuRelation.IsInErrorQuestion].ToString().Trim(); //是否进入错题
objRow[concc_WorkStuRelation.WorkTypeId] = oRow[concc_WorkStuRelation.WorkTypeId].ToString().Trim(); //作业类型Id
objRow[concc_WorkStuRelation.AnswerIP] = oRow[concc_WorkStuRelation.AnswerIP].ToString().Trim(); //回答IP
objRow[concc_WorkStuRelation.AnswerDate] = oRow[concc_WorkStuRelation.AnswerDate].ToString().Trim(); //回答日期
objRow[concc_WorkStuRelation.AnswerTime] = oRow[concc_WorkStuRelation.AnswerTime].ToString().Trim(); //回答时间
objRow[concc_WorkStuRelation.CourseExamPaperId] = oRow[concc_WorkStuRelation.CourseExamPaperId].ToString().Trim(); //考卷流水号
objRow[concc_WorkStuRelation.IsRight] = oRow[concc_WorkStuRelation.IsRight].ToString().Trim(); //是否正确
objRow[concc_WorkStuRelation.IsAccessKnowledge] = oRow[concc_WorkStuRelation.IsAccessKnowledge].ToString().Trim(); //是否处理知识点
objRow[concc_WorkStuRelation.IsNotProcessTimeout] = oRow[concc_WorkStuRelation.IsNotProcessTimeout].ToString().Trim(); //是否不处理超时
objRow[concc_WorkStuRelation.SchoolYear] = oRow[concc_WorkStuRelation.SchoolYear].ToString().Trim(); //学年
objRow[concc_WorkStuRelation.SchoolTerm] = oRow[concc_WorkStuRelation.SchoolTerm].ToString().Trim(); //学期
objRow[concc_WorkStuRelation.ErrMsg] = oRow[concc_WorkStuRelation.ErrMsg].ToString().Trim(); //错误信息
objRow[concc_WorkStuRelation.CourseId] = oRow[concc_WorkStuRelation.CourseId].ToString().Trim(); //课程Id
objRow[concc_WorkStuRelation.UpdDate] = oRow[concc_WorkStuRelation.UpdDate].ToString().Trim(); //修改日期
objRow[concc_WorkStuRelation.UpdUserId] = oRow[concc_WorkStuRelation.UpdUserId].ToString().Trim(); //修改用户Id
objRow[concc_WorkStuRelation.Memo] = oRow[concc_WorkStuRelation.Memo].ToString().Trim(); //备注
 objDS.Tables[clscc_WorkStuRelationEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clscc_WorkStuRelationEN._CurrTabName);
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
 /// <param name = "objcc_WorkStuRelationEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clscc_WorkStuRelationEN objcc_WorkStuRelationEN)
{
 objcc_WorkStuRelationEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_WorkStuRelationEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_WorkStuRelationEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkStuRelationDA.GetSpecSQLObj();
strSQL = "Select * from cc_WorkStuRelation where IdWorkStuRelation = " + ""+ objcc_WorkStuRelationEN.IdWorkStuRelation+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clscc_WorkStuRelationEN._CurrTabName);
if (objDS.Tables[clscc_WorkStuRelationEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:IdWorkStuRelation = " + ""+ objcc_WorkStuRelationEN.IdWorkStuRelation+"");
return false;
}
objRow = objDS.Tables[clscc_WorkStuRelationEN._CurrTabName].Rows[0];
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.IdCurrEduCls))
 {
objRow[concc_WorkStuRelation.IdCurrEduCls] = objcc_WorkStuRelationEN.IdCurrEduCls; //教学班流水号
 }
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.QuestionId))
 {
objRow[concc_WorkStuRelation.QuestionId] = objcc_WorkStuRelationEN.QuestionId; //题目Id
 }
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.Scores))
 {
objRow[concc_WorkStuRelation.Scores] = objcc_WorkStuRelationEN.Scores; //分值
 }
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.SpecifyCompletionDate))
 {
objRow[concc_WorkStuRelation.SpecifyCompletionDate] = objcc_WorkStuRelationEN.SpecifyCompletionDate; //指定完成日期
 }
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.IdStudentInfo))
 {
objRow[concc_WorkStuRelation.IdStudentInfo] = objcc_WorkStuRelationEN.IdStudentInfo; //学生流水号
 }
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.AnswerModeId))
 {
objRow[concc_WorkStuRelation.AnswerModeId] = objcc_WorkStuRelationEN.AnswerModeId; //答案模式Id
 }
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.AnswerOptionId))
 {
objRow[concc_WorkStuRelation.AnswerOptionId] = objcc_WorkStuRelationEN.AnswerOptionId; //回答选项Id
 }
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.AnswerMultiOptions))
 {
objRow[concc_WorkStuRelation.AnswerMultiOptions] = objcc_WorkStuRelationEN.AnswerMultiOptions; //多选项答案
 }
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.AnswerBoolResult))
 {
objRow[concc_WorkStuRelation.AnswerBoolResult] = objcc_WorkStuRelationEN.AnswerBoolResult; //答案布尔结果
 }
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.StuAnswerText))
 {
objRow[concc_WorkStuRelation.StuAnswerText] = objcc_WorkStuRelationEN.StuAnswerText; //学生回答文本
 }
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.IsPublish))
 {
objRow[concc_WorkStuRelation.IsPublish] = objcc_WorkStuRelationEN.IsPublish; //是否发布
 }
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.IsLook))
 {
objRow[concc_WorkStuRelation.IsLook] = objcc_WorkStuRelationEN.IsLook; //是否查看
 }
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.IsSave))
 {
objRow[concc_WorkStuRelation.IsSave] = objcc_WorkStuRelationEN.IsSave; //是否保存
 }
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.IsSubmit))
 {
objRow[concc_WorkStuRelation.IsSubmit] = objcc_WorkStuRelationEN.IsSubmit; //是否提交
 }
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.ApplySendBackDate))
 {
objRow[concc_WorkStuRelation.ApplySendBackDate] = objcc_WorkStuRelationEN.ApplySendBackDate; //申请退回日期
 }
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.IsApplySendBack))
 {
objRow[concc_WorkStuRelation.IsApplySendBack] = objcc_WorkStuRelationEN.IsApplySendBack; //是否申请退回
 }
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.RealFinishDate))
 {
objRow[concc_WorkStuRelation.RealFinishDate] = objcc_WorkStuRelationEN.RealFinishDate; //实际完成日期
 }
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.OperateTime))
 {
objRow[concc_WorkStuRelation.OperateTime] = objcc_WorkStuRelationEN.OperateTime; //操作时间
 }
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.Score))
 {
objRow[concc_WorkStuRelation.Score] = objcc_WorkStuRelationEN.Score; //得分
 }
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.Comment))
 {
objRow[concc_WorkStuRelation.Comment] = objcc_WorkStuRelationEN.Comment; //批注
 }
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.IsMarking))
 {
objRow[concc_WorkStuRelation.IsMarking] = objcc_WorkStuRelationEN.IsMarking; //是否批阅
 }
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.MarkerId))
 {
objRow[concc_WorkStuRelation.MarkerId] = objcc_WorkStuRelationEN.MarkerId; //打分者
 }
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.MarkDate))
 {
objRow[concc_WorkStuRelation.MarkDate] = objcc_WorkStuRelationEN.MarkDate; //打分日期
 }
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.IsSendBack))
 {
objRow[concc_WorkStuRelation.IsSendBack] = objcc_WorkStuRelationEN.IsSendBack; //是否退回
 }
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.IsInErrorQuestion))
 {
objRow[concc_WorkStuRelation.IsInErrorQuestion] = objcc_WorkStuRelationEN.IsInErrorQuestion; //是否进入错题
 }
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.WorkTypeId))
 {
objRow[concc_WorkStuRelation.WorkTypeId] = objcc_WorkStuRelationEN.WorkTypeId; //作业类型Id
 }
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.AnswerIP))
 {
objRow[concc_WorkStuRelation.AnswerIP] = objcc_WorkStuRelationEN.AnswerIP; //回答IP
 }
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.AnswerDate))
 {
objRow[concc_WorkStuRelation.AnswerDate] = objcc_WorkStuRelationEN.AnswerDate; //回答日期
 }
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.AnswerTime))
 {
objRow[concc_WorkStuRelation.AnswerTime] = objcc_WorkStuRelationEN.AnswerTime; //回答时间
 }
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.CourseExamPaperId))
 {
objRow[concc_WorkStuRelation.CourseExamPaperId] = objcc_WorkStuRelationEN.CourseExamPaperId; //考卷流水号
 }
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.IsRight))
 {
objRow[concc_WorkStuRelation.IsRight] = objcc_WorkStuRelationEN.IsRight; //是否正确
 }
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.IsAccessKnowledge))
 {
objRow[concc_WorkStuRelation.IsAccessKnowledge] = objcc_WorkStuRelationEN.IsAccessKnowledge; //是否处理知识点
 }
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.IsNotProcessTimeout))
 {
objRow[concc_WorkStuRelation.IsNotProcessTimeout] = objcc_WorkStuRelationEN.IsNotProcessTimeout; //是否不处理超时
 }
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.SchoolYear))
 {
objRow[concc_WorkStuRelation.SchoolYear] = objcc_WorkStuRelationEN.SchoolYear; //学年
 }
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.SchoolTerm))
 {
objRow[concc_WorkStuRelation.SchoolTerm] = objcc_WorkStuRelationEN.SchoolTerm; //学期
 }
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.ErrMsg))
 {
objRow[concc_WorkStuRelation.ErrMsg] = objcc_WorkStuRelationEN.ErrMsg; //错误信息
 }
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.CourseId))
 {
objRow[concc_WorkStuRelation.CourseId] = objcc_WorkStuRelationEN.CourseId; //课程Id
 }
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.UpdDate))
 {
objRow[concc_WorkStuRelation.UpdDate] = objcc_WorkStuRelationEN.UpdDate; //修改日期
 }
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.UpdUserId))
 {
objRow[concc_WorkStuRelation.UpdUserId] = objcc_WorkStuRelationEN.UpdUserId; //修改用户Id
 }
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.Memo))
 {
objRow[concc_WorkStuRelation.Memo] = objcc_WorkStuRelationEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clscc_WorkStuRelationEN._CurrTabName);
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
 /// <param name = "objcc_WorkStuRelationEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clscc_WorkStuRelationEN objcc_WorkStuRelationEN)
{
 objcc_WorkStuRelationEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_WorkStuRelationEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_WorkStuRelationEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkStuRelationDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update cc_WorkStuRelation Set ");
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.IdCurrEduCls))
 {
 if (objcc_WorkStuRelationEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objcc_WorkStuRelationEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, concc_WorkStuRelation.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.QuestionId))
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_WorkStuRelationEN.QuestionId, concc_WorkStuRelation.QuestionId); //题目Id
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.Scores))
 {
 if (objcc_WorkStuRelationEN.Scores !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_WorkStuRelationEN.Scores, concc_WorkStuRelation.Scores); //分值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation.Scores); //分值
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.SpecifyCompletionDate))
 {
 if (objcc_WorkStuRelationEN.SpecifyCompletionDate !=  null)
 {
 var strSpecifyCompletionDate = objcc_WorkStuRelationEN.SpecifyCompletionDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSpecifyCompletionDate, concc_WorkStuRelation.SpecifyCompletionDate); //指定完成日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation.SpecifyCompletionDate); //指定完成日期
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.IdStudentInfo))
 {
 if (objcc_WorkStuRelationEN.IdStudentInfo  ==  "")
 {
 objcc_WorkStuRelationEN.IdStudentInfo = null;
 }
 if (objcc_WorkStuRelationEN.IdStudentInfo !=  null)
 {
 var strIdStudentInfo = objcc_WorkStuRelationEN.IdStudentInfo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdStudentInfo, concc_WorkStuRelation.IdStudentInfo); //学生流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation.IdStudentInfo); //学生流水号
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.AnswerModeId))
 {
 if (objcc_WorkStuRelationEN.AnswerModeId !=  null)
 {
 var strAnswerModeId = objcc_WorkStuRelationEN.AnswerModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerModeId, concc_WorkStuRelation.AnswerModeId); //答案模式Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation.AnswerModeId); //答案模式Id
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.AnswerOptionId))
 {
 if (objcc_WorkStuRelationEN.AnswerOptionId !=  null)
 {
 var strAnswerOptionId = objcc_WorkStuRelationEN.AnswerOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerOptionId, concc_WorkStuRelation.AnswerOptionId); //回答选项Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation.AnswerOptionId); //回答选项Id
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.AnswerMultiOptions))
 {
 if (objcc_WorkStuRelationEN.AnswerMultiOptions !=  null)
 {
 var strAnswerMultiOptions = objcc_WorkStuRelationEN.AnswerMultiOptions.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerMultiOptions, concc_WorkStuRelation.AnswerMultiOptions); //多选项答案
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation.AnswerMultiOptions); //多选项答案
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.AnswerBoolResult))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_WorkStuRelationEN.AnswerBoolResult == true?"1":"0", concc_WorkStuRelation.AnswerBoolResult); //答案布尔结果
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.StuAnswerText))
 {
 if (objcc_WorkStuRelationEN.StuAnswerText !=  null)
 {
 var strStuAnswerText = objcc_WorkStuRelationEN.StuAnswerText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStuAnswerText, concc_WorkStuRelation.StuAnswerText); //学生回答文本
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation.StuAnswerText); //学生回答文本
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.IsPublish))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_WorkStuRelationEN.IsPublish == true?"1":"0", concc_WorkStuRelation.IsPublish); //是否发布
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.IsLook))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_WorkStuRelationEN.IsLook == true?"1":"0", concc_WorkStuRelation.IsLook); //是否查看
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.IsSave))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_WorkStuRelationEN.IsSave == true?"1":"0", concc_WorkStuRelation.IsSave); //是否保存
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_WorkStuRelationEN.IsSubmit == true?"1":"0", concc_WorkStuRelation.IsSubmit); //是否提交
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.ApplySendBackDate))
 {
 if (objcc_WorkStuRelationEN.ApplySendBackDate !=  null)
 {
 var strApplySendBackDate = objcc_WorkStuRelationEN.ApplySendBackDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strApplySendBackDate, concc_WorkStuRelation.ApplySendBackDate); //申请退回日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation.ApplySendBackDate); //申请退回日期
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.IsApplySendBack))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_WorkStuRelationEN.IsApplySendBack == true?"1":"0", concc_WorkStuRelation.IsApplySendBack); //是否申请退回
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.RealFinishDate))
 {
 if (objcc_WorkStuRelationEN.RealFinishDate !=  null)
 {
 var strRealFinishDate = objcc_WorkStuRelationEN.RealFinishDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRealFinishDate, concc_WorkStuRelation.RealFinishDate); //实际完成日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation.RealFinishDate); //实际完成日期
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.OperateTime))
 {
 if (objcc_WorkStuRelationEN.OperateTime !=  null)
 {
 var strOperateTime = objcc_WorkStuRelationEN.OperateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOperateTime, concc_WorkStuRelation.OperateTime); //操作时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation.OperateTime); //操作时间
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.Score))
 {
 if (objcc_WorkStuRelationEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_WorkStuRelationEN.Score, concc_WorkStuRelation.Score); //得分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation.Score); //得分
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.Comment))
 {
 if (objcc_WorkStuRelationEN.Comment !=  null)
 {
 var strComment = objcc_WorkStuRelationEN.Comment.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strComment, concc_WorkStuRelation.Comment); //批注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation.Comment); //批注
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.IsMarking))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_WorkStuRelationEN.IsMarking == true?"1":"0", concc_WorkStuRelation.IsMarking); //是否批阅
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.MarkerId))
 {
 if (objcc_WorkStuRelationEN.MarkerId !=  null)
 {
 var strMarkerId = objcc_WorkStuRelationEN.MarkerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMarkerId, concc_WorkStuRelation.MarkerId); //打分者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation.MarkerId); //打分者
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.MarkDate))
 {
 if (objcc_WorkStuRelationEN.MarkDate !=  null)
 {
 var strMarkDate = objcc_WorkStuRelationEN.MarkDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMarkDate, concc_WorkStuRelation.MarkDate); //打分日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation.MarkDate); //打分日期
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.IsSendBack))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_WorkStuRelationEN.IsSendBack == true?"1":"0", concc_WorkStuRelation.IsSendBack); //是否退回
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.IsInErrorQuestion))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_WorkStuRelationEN.IsInErrorQuestion == true?"1":"0", concc_WorkStuRelation.IsInErrorQuestion); //是否进入错题
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.WorkTypeId))
 {
 if (objcc_WorkStuRelationEN.WorkTypeId !=  null)
 {
 var strWorkTypeId = objcc_WorkStuRelationEN.WorkTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWorkTypeId, concc_WorkStuRelation.WorkTypeId); //作业类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation.WorkTypeId); //作业类型Id
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.AnswerIP))
 {
 if (objcc_WorkStuRelationEN.AnswerIP !=  null)
 {
 var strAnswerIP = objcc_WorkStuRelationEN.AnswerIP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerIP, concc_WorkStuRelation.AnswerIP); //回答IP
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation.AnswerIP); //回答IP
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.AnswerDate))
 {
 if (objcc_WorkStuRelationEN.AnswerDate !=  null)
 {
 var strAnswerDate = objcc_WorkStuRelationEN.AnswerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerDate, concc_WorkStuRelation.AnswerDate); //回答日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation.AnswerDate); //回答日期
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.AnswerTime))
 {
 if (objcc_WorkStuRelationEN.AnswerTime !=  null)
 {
 var strAnswerTime = objcc_WorkStuRelationEN.AnswerTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerTime, concc_WorkStuRelation.AnswerTime); //回答时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation.AnswerTime); //回答时间
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.CourseExamPaperId))
 {
 if (objcc_WorkStuRelationEN.CourseExamPaperId !=  null)
 {
 var strCourseExamPaperId = objcc_WorkStuRelationEN.CourseExamPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseExamPaperId, concc_WorkStuRelation.CourseExamPaperId); //考卷流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation.CourseExamPaperId); //考卷流水号
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.IsRight))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_WorkStuRelationEN.IsRight == true?"1":"0", concc_WorkStuRelation.IsRight); //是否正确
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.IsAccessKnowledge))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_WorkStuRelationEN.IsAccessKnowledge == true?"1":"0", concc_WorkStuRelation.IsAccessKnowledge); //是否处理知识点
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.IsNotProcessTimeout))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_WorkStuRelationEN.IsNotProcessTimeout == true?"1":"0", concc_WorkStuRelation.IsNotProcessTimeout); //是否不处理超时
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.SchoolYear))
 {
 if (objcc_WorkStuRelationEN.SchoolYear !=  null)
 {
 var strSchoolYear = objcc_WorkStuRelationEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchoolYear, concc_WorkStuRelation.SchoolYear); //学年
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation.SchoolYear); //学年
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.SchoolTerm))
 {
 if (objcc_WorkStuRelationEN.SchoolTerm !=  null)
 {
 var strSchoolTerm = objcc_WorkStuRelationEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchoolTerm, concc_WorkStuRelation.SchoolTerm); //学期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation.SchoolTerm); //学期
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.ErrMsg))
 {
 if (objcc_WorkStuRelationEN.ErrMsg !=  null)
 {
 var strErrMsg = objcc_WorkStuRelationEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strErrMsg, concc_WorkStuRelation.ErrMsg); //错误信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation.ErrMsg); //错误信息
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.CourseId))
 {
 if (objcc_WorkStuRelationEN.CourseId !=  null)
 {
 var strCourseId = objcc_WorkStuRelationEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, concc_WorkStuRelation.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation.CourseId); //课程Id
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.UpdDate))
 {
 if (objcc_WorkStuRelationEN.UpdDate !=  null)
 {
 var strUpdDate = objcc_WorkStuRelationEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, concc_WorkStuRelation.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation.UpdDate); //修改日期
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.UpdUserId))
 {
 if (objcc_WorkStuRelationEN.UpdUserId !=  null)
 {
 var strUpdUserId = objcc_WorkStuRelationEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, concc_WorkStuRelation.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation.UpdUserId); //修改用户Id
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.Memo))
 {
 if (objcc_WorkStuRelationEN.Memo !=  null)
 {
 var strMemo = objcc_WorkStuRelationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, concc_WorkStuRelation.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdWorkStuRelation = {0}", objcc_WorkStuRelationEN.IdWorkStuRelation); 
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
 /// <param name = "objcc_WorkStuRelationEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clscc_WorkStuRelationEN objcc_WorkStuRelationEN, string strCondition)
{
 objcc_WorkStuRelationEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_WorkStuRelationEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_WorkStuRelationEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkStuRelationDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update cc_WorkStuRelation Set ");
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.IdCurrEduCls))
 {
 if (objcc_WorkStuRelationEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objcc_WorkStuRelationEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.QuestionId))
 {
 sbSQL.AppendFormat(" QuestionId = {0},", objcc_WorkStuRelationEN.QuestionId); //题目Id
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.Scores))
 {
 if (objcc_WorkStuRelationEN.Scores !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_WorkStuRelationEN.Scores, concc_WorkStuRelation.Scores); //分值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation.Scores); //分值
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.SpecifyCompletionDate))
 {
 if (objcc_WorkStuRelationEN.SpecifyCompletionDate !=  null)
 {
 var strSpecifyCompletionDate = objcc_WorkStuRelationEN.SpecifyCompletionDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SpecifyCompletionDate = '{0}',", strSpecifyCompletionDate); //指定完成日期
 }
 else
 {
 sbSQL.Append(" SpecifyCompletionDate = null,"); //指定完成日期
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.IdStudentInfo))
 {
 if (objcc_WorkStuRelationEN.IdStudentInfo  ==  "")
 {
 objcc_WorkStuRelationEN.IdStudentInfo = null;
 }
 if (objcc_WorkStuRelationEN.IdStudentInfo !=  null)
 {
 var strIdStudentInfo = objcc_WorkStuRelationEN.IdStudentInfo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdStudentInfo = '{0}',", strIdStudentInfo); //学生流水号
 }
 else
 {
 sbSQL.Append(" IdStudentInfo = null,"); //学生流水号
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.AnswerModeId))
 {
 if (objcc_WorkStuRelationEN.AnswerModeId !=  null)
 {
 var strAnswerModeId = objcc_WorkStuRelationEN.AnswerModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerModeId = '{0}',", strAnswerModeId); //答案模式Id
 }
 else
 {
 sbSQL.Append(" AnswerModeId = null,"); //答案模式Id
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.AnswerOptionId))
 {
 if (objcc_WorkStuRelationEN.AnswerOptionId !=  null)
 {
 var strAnswerOptionId = objcc_WorkStuRelationEN.AnswerOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerOptionId = '{0}',", strAnswerOptionId); //回答选项Id
 }
 else
 {
 sbSQL.Append(" AnswerOptionId = null,"); //回答选项Id
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.AnswerMultiOptions))
 {
 if (objcc_WorkStuRelationEN.AnswerMultiOptions !=  null)
 {
 var strAnswerMultiOptions = objcc_WorkStuRelationEN.AnswerMultiOptions.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerMultiOptions = '{0}',", strAnswerMultiOptions); //多选项答案
 }
 else
 {
 sbSQL.Append(" AnswerMultiOptions = null,"); //多选项答案
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.AnswerBoolResult))
 {
 sbSQL.AppendFormat(" AnswerBoolResult = '{0}',", objcc_WorkStuRelationEN.AnswerBoolResult == true?"1":"0"); //答案布尔结果
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.StuAnswerText))
 {
 if (objcc_WorkStuRelationEN.StuAnswerText !=  null)
 {
 var strStuAnswerText = objcc_WorkStuRelationEN.StuAnswerText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StuAnswerText = '{0}',", strStuAnswerText); //学生回答文本
 }
 else
 {
 sbSQL.Append(" StuAnswerText = null,"); //学生回答文本
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.IsPublish))
 {
 sbSQL.AppendFormat(" IsPublish = '{0}',", objcc_WorkStuRelationEN.IsPublish == true?"1":"0"); //是否发布
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.IsLook))
 {
 sbSQL.AppendFormat(" IsLook = '{0}',", objcc_WorkStuRelationEN.IsLook == true?"1":"0"); //是否查看
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.IsSave))
 {
 sbSQL.AppendFormat(" IsSave = '{0}',", objcc_WorkStuRelationEN.IsSave == true?"1":"0"); //是否保存
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objcc_WorkStuRelationEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.ApplySendBackDate))
 {
 if (objcc_WorkStuRelationEN.ApplySendBackDate !=  null)
 {
 var strApplySendBackDate = objcc_WorkStuRelationEN.ApplySendBackDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ApplySendBackDate = '{0}',", strApplySendBackDate); //申请退回日期
 }
 else
 {
 sbSQL.Append(" ApplySendBackDate = null,"); //申请退回日期
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.IsApplySendBack))
 {
 sbSQL.AppendFormat(" IsApplySendBack = '{0}',", objcc_WorkStuRelationEN.IsApplySendBack == true?"1":"0"); //是否申请退回
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.RealFinishDate))
 {
 if (objcc_WorkStuRelationEN.RealFinishDate !=  null)
 {
 var strRealFinishDate = objcc_WorkStuRelationEN.RealFinishDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RealFinishDate = '{0}',", strRealFinishDate); //实际完成日期
 }
 else
 {
 sbSQL.Append(" RealFinishDate = null,"); //实际完成日期
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.OperateTime))
 {
 if (objcc_WorkStuRelationEN.OperateTime !=  null)
 {
 var strOperateTime = objcc_WorkStuRelationEN.OperateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OperateTime = '{0}',", strOperateTime); //操作时间
 }
 else
 {
 sbSQL.Append(" OperateTime = null,"); //操作时间
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.Score))
 {
 if (objcc_WorkStuRelationEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_WorkStuRelationEN.Score, concc_WorkStuRelation.Score); //得分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation.Score); //得分
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.Comment))
 {
 if (objcc_WorkStuRelationEN.Comment !=  null)
 {
 var strComment = objcc_WorkStuRelationEN.Comment.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Comment = '{0}',", strComment); //批注
 }
 else
 {
 sbSQL.Append(" Comment = null,"); //批注
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.IsMarking))
 {
 sbSQL.AppendFormat(" IsMarking = '{0}',", objcc_WorkStuRelationEN.IsMarking == true?"1":"0"); //是否批阅
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.MarkerId))
 {
 if (objcc_WorkStuRelationEN.MarkerId !=  null)
 {
 var strMarkerId = objcc_WorkStuRelationEN.MarkerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MarkerId = '{0}',", strMarkerId); //打分者
 }
 else
 {
 sbSQL.Append(" MarkerId = null,"); //打分者
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.MarkDate))
 {
 if (objcc_WorkStuRelationEN.MarkDate !=  null)
 {
 var strMarkDate = objcc_WorkStuRelationEN.MarkDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MarkDate = '{0}',", strMarkDate); //打分日期
 }
 else
 {
 sbSQL.Append(" MarkDate = null,"); //打分日期
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.IsSendBack))
 {
 sbSQL.AppendFormat(" IsSendBack = '{0}',", objcc_WorkStuRelationEN.IsSendBack == true?"1":"0"); //是否退回
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.IsInErrorQuestion))
 {
 sbSQL.AppendFormat(" IsInErrorQuestion = '{0}',", objcc_WorkStuRelationEN.IsInErrorQuestion == true?"1":"0"); //是否进入错题
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.WorkTypeId))
 {
 if (objcc_WorkStuRelationEN.WorkTypeId !=  null)
 {
 var strWorkTypeId = objcc_WorkStuRelationEN.WorkTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WorkTypeId = '{0}',", strWorkTypeId); //作业类型Id
 }
 else
 {
 sbSQL.Append(" WorkTypeId = null,"); //作业类型Id
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.AnswerIP))
 {
 if (objcc_WorkStuRelationEN.AnswerIP !=  null)
 {
 var strAnswerIP = objcc_WorkStuRelationEN.AnswerIP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerIP = '{0}',", strAnswerIP); //回答IP
 }
 else
 {
 sbSQL.Append(" AnswerIP = null,"); //回答IP
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.AnswerDate))
 {
 if (objcc_WorkStuRelationEN.AnswerDate !=  null)
 {
 var strAnswerDate = objcc_WorkStuRelationEN.AnswerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerDate = '{0}',", strAnswerDate); //回答日期
 }
 else
 {
 sbSQL.Append(" AnswerDate = null,"); //回答日期
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.AnswerTime))
 {
 if (objcc_WorkStuRelationEN.AnswerTime !=  null)
 {
 var strAnswerTime = objcc_WorkStuRelationEN.AnswerTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerTime = '{0}',", strAnswerTime); //回答时间
 }
 else
 {
 sbSQL.Append(" AnswerTime = null,"); //回答时间
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.CourseExamPaperId))
 {
 if (objcc_WorkStuRelationEN.CourseExamPaperId !=  null)
 {
 var strCourseExamPaperId = objcc_WorkStuRelationEN.CourseExamPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseExamPaperId = '{0}',", strCourseExamPaperId); //考卷流水号
 }
 else
 {
 sbSQL.Append(" CourseExamPaperId = null,"); //考卷流水号
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.IsRight))
 {
 sbSQL.AppendFormat(" IsRight = '{0}',", objcc_WorkStuRelationEN.IsRight == true?"1":"0"); //是否正确
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.IsAccessKnowledge))
 {
 sbSQL.AppendFormat(" IsAccessKnowledge = '{0}',", objcc_WorkStuRelationEN.IsAccessKnowledge == true?"1":"0"); //是否处理知识点
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.IsNotProcessTimeout))
 {
 sbSQL.AppendFormat(" IsNotProcessTimeout = '{0}',", objcc_WorkStuRelationEN.IsNotProcessTimeout == true?"1":"0"); //是否不处理超时
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.SchoolYear))
 {
 if (objcc_WorkStuRelationEN.SchoolYear !=  null)
 {
 var strSchoolYear = objcc_WorkStuRelationEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolYear = '{0}',", strSchoolYear); //学年
 }
 else
 {
 sbSQL.Append(" SchoolYear = null,"); //学年
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.SchoolTerm))
 {
 if (objcc_WorkStuRelationEN.SchoolTerm !=  null)
 {
 var strSchoolTerm = objcc_WorkStuRelationEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolTerm = '{0}',", strSchoolTerm); //学期
 }
 else
 {
 sbSQL.Append(" SchoolTerm = null,"); //学期
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.ErrMsg))
 {
 if (objcc_WorkStuRelationEN.ErrMsg !=  null)
 {
 var strErrMsg = objcc_WorkStuRelationEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ErrMsg = '{0}',", strErrMsg); //错误信息
 }
 else
 {
 sbSQL.Append(" ErrMsg = null,"); //错误信息
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.CourseId))
 {
 if (objcc_WorkStuRelationEN.CourseId !=  null)
 {
 var strCourseId = objcc_WorkStuRelationEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.UpdDate))
 {
 if (objcc_WorkStuRelationEN.UpdDate !=  null)
 {
 var strUpdDate = objcc_WorkStuRelationEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.UpdUserId))
 {
 if (objcc_WorkStuRelationEN.UpdUserId !=  null)
 {
 var strUpdUserId = objcc_WorkStuRelationEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.Memo))
 {
 if (objcc_WorkStuRelationEN.Memo !=  null)
 {
 var strMemo = objcc_WorkStuRelationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objcc_WorkStuRelationEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clscc_WorkStuRelationEN objcc_WorkStuRelationEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objcc_WorkStuRelationEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_WorkStuRelationEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_WorkStuRelationEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkStuRelationDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update cc_WorkStuRelation Set ");
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.IdCurrEduCls))
 {
 if (objcc_WorkStuRelationEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objcc_WorkStuRelationEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.QuestionId))
 {
 sbSQL.AppendFormat(" QuestionId = {0},", objcc_WorkStuRelationEN.QuestionId); //题目Id
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.Scores))
 {
 if (objcc_WorkStuRelationEN.Scores !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_WorkStuRelationEN.Scores, concc_WorkStuRelation.Scores); //分值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation.Scores); //分值
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.SpecifyCompletionDate))
 {
 if (objcc_WorkStuRelationEN.SpecifyCompletionDate !=  null)
 {
 var strSpecifyCompletionDate = objcc_WorkStuRelationEN.SpecifyCompletionDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SpecifyCompletionDate = '{0}',", strSpecifyCompletionDate); //指定完成日期
 }
 else
 {
 sbSQL.Append(" SpecifyCompletionDate = null,"); //指定完成日期
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.IdStudentInfo))
 {
 if (objcc_WorkStuRelationEN.IdStudentInfo  ==  "")
 {
 objcc_WorkStuRelationEN.IdStudentInfo = null;
 }
 if (objcc_WorkStuRelationEN.IdStudentInfo !=  null)
 {
 var strIdStudentInfo = objcc_WorkStuRelationEN.IdStudentInfo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdStudentInfo = '{0}',", strIdStudentInfo); //学生流水号
 }
 else
 {
 sbSQL.Append(" IdStudentInfo = null,"); //学生流水号
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.AnswerModeId))
 {
 if (objcc_WorkStuRelationEN.AnswerModeId !=  null)
 {
 var strAnswerModeId = objcc_WorkStuRelationEN.AnswerModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerModeId = '{0}',", strAnswerModeId); //答案模式Id
 }
 else
 {
 sbSQL.Append(" AnswerModeId = null,"); //答案模式Id
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.AnswerOptionId))
 {
 if (objcc_WorkStuRelationEN.AnswerOptionId !=  null)
 {
 var strAnswerOptionId = objcc_WorkStuRelationEN.AnswerOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerOptionId = '{0}',", strAnswerOptionId); //回答选项Id
 }
 else
 {
 sbSQL.Append(" AnswerOptionId = null,"); //回答选项Id
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.AnswerMultiOptions))
 {
 if (objcc_WorkStuRelationEN.AnswerMultiOptions !=  null)
 {
 var strAnswerMultiOptions = objcc_WorkStuRelationEN.AnswerMultiOptions.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerMultiOptions = '{0}',", strAnswerMultiOptions); //多选项答案
 }
 else
 {
 sbSQL.Append(" AnswerMultiOptions = null,"); //多选项答案
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.AnswerBoolResult))
 {
 sbSQL.AppendFormat(" AnswerBoolResult = '{0}',", objcc_WorkStuRelationEN.AnswerBoolResult == true?"1":"0"); //答案布尔结果
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.StuAnswerText))
 {
 if (objcc_WorkStuRelationEN.StuAnswerText !=  null)
 {
 var strStuAnswerText = objcc_WorkStuRelationEN.StuAnswerText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StuAnswerText = '{0}',", strStuAnswerText); //学生回答文本
 }
 else
 {
 sbSQL.Append(" StuAnswerText = null,"); //学生回答文本
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.IsPublish))
 {
 sbSQL.AppendFormat(" IsPublish = '{0}',", objcc_WorkStuRelationEN.IsPublish == true?"1":"0"); //是否发布
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.IsLook))
 {
 sbSQL.AppendFormat(" IsLook = '{0}',", objcc_WorkStuRelationEN.IsLook == true?"1":"0"); //是否查看
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.IsSave))
 {
 sbSQL.AppendFormat(" IsSave = '{0}',", objcc_WorkStuRelationEN.IsSave == true?"1":"0"); //是否保存
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objcc_WorkStuRelationEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.ApplySendBackDate))
 {
 if (objcc_WorkStuRelationEN.ApplySendBackDate !=  null)
 {
 var strApplySendBackDate = objcc_WorkStuRelationEN.ApplySendBackDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ApplySendBackDate = '{0}',", strApplySendBackDate); //申请退回日期
 }
 else
 {
 sbSQL.Append(" ApplySendBackDate = null,"); //申请退回日期
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.IsApplySendBack))
 {
 sbSQL.AppendFormat(" IsApplySendBack = '{0}',", objcc_WorkStuRelationEN.IsApplySendBack == true?"1":"0"); //是否申请退回
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.RealFinishDate))
 {
 if (objcc_WorkStuRelationEN.RealFinishDate !=  null)
 {
 var strRealFinishDate = objcc_WorkStuRelationEN.RealFinishDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RealFinishDate = '{0}',", strRealFinishDate); //实际完成日期
 }
 else
 {
 sbSQL.Append(" RealFinishDate = null,"); //实际完成日期
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.OperateTime))
 {
 if (objcc_WorkStuRelationEN.OperateTime !=  null)
 {
 var strOperateTime = objcc_WorkStuRelationEN.OperateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OperateTime = '{0}',", strOperateTime); //操作时间
 }
 else
 {
 sbSQL.Append(" OperateTime = null,"); //操作时间
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.Score))
 {
 if (objcc_WorkStuRelationEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_WorkStuRelationEN.Score, concc_WorkStuRelation.Score); //得分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation.Score); //得分
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.Comment))
 {
 if (objcc_WorkStuRelationEN.Comment !=  null)
 {
 var strComment = objcc_WorkStuRelationEN.Comment.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Comment = '{0}',", strComment); //批注
 }
 else
 {
 sbSQL.Append(" Comment = null,"); //批注
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.IsMarking))
 {
 sbSQL.AppendFormat(" IsMarking = '{0}',", objcc_WorkStuRelationEN.IsMarking == true?"1":"0"); //是否批阅
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.MarkerId))
 {
 if (objcc_WorkStuRelationEN.MarkerId !=  null)
 {
 var strMarkerId = objcc_WorkStuRelationEN.MarkerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MarkerId = '{0}',", strMarkerId); //打分者
 }
 else
 {
 sbSQL.Append(" MarkerId = null,"); //打分者
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.MarkDate))
 {
 if (objcc_WorkStuRelationEN.MarkDate !=  null)
 {
 var strMarkDate = objcc_WorkStuRelationEN.MarkDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MarkDate = '{0}',", strMarkDate); //打分日期
 }
 else
 {
 sbSQL.Append(" MarkDate = null,"); //打分日期
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.IsSendBack))
 {
 sbSQL.AppendFormat(" IsSendBack = '{0}',", objcc_WorkStuRelationEN.IsSendBack == true?"1":"0"); //是否退回
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.IsInErrorQuestion))
 {
 sbSQL.AppendFormat(" IsInErrorQuestion = '{0}',", objcc_WorkStuRelationEN.IsInErrorQuestion == true?"1":"0"); //是否进入错题
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.WorkTypeId))
 {
 if (objcc_WorkStuRelationEN.WorkTypeId !=  null)
 {
 var strWorkTypeId = objcc_WorkStuRelationEN.WorkTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WorkTypeId = '{0}',", strWorkTypeId); //作业类型Id
 }
 else
 {
 sbSQL.Append(" WorkTypeId = null,"); //作业类型Id
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.AnswerIP))
 {
 if (objcc_WorkStuRelationEN.AnswerIP !=  null)
 {
 var strAnswerIP = objcc_WorkStuRelationEN.AnswerIP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerIP = '{0}',", strAnswerIP); //回答IP
 }
 else
 {
 sbSQL.Append(" AnswerIP = null,"); //回答IP
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.AnswerDate))
 {
 if (objcc_WorkStuRelationEN.AnswerDate !=  null)
 {
 var strAnswerDate = objcc_WorkStuRelationEN.AnswerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerDate = '{0}',", strAnswerDate); //回答日期
 }
 else
 {
 sbSQL.Append(" AnswerDate = null,"); //回答日期
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.AnswerTime))
 {
 if (objcc_WorkStuRelationEN.AnswerTime !=  null)
 {
 var strAnswerTime = objcc_WorkStuRelationEN.AnswerTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerTime = '{0}',", strAnswerTime); //回答时间
 }
 else
 {
 sbSQL.Append(" AnswerTime = null,"); //回答时间
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.CourseExamPaperId))
 {
 if (objcc_WorkStuRelationEN.CourseExamPaperId !=  null)
 {
 var strCourseExamPaperId = objcc_WorkStuRelationEN.CourseExamPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseExamPaperId = '{0}',", strCourseExamPaperId); //考卷流水号
 }
 else
 {
 sbSQL.Append(" CourseExamPaperId = null,"); //考卷流水号
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.IsRight))
 {
 sbSQL.AppendFormat(" IsRight = '{0}',", objcc_WorkStuRelationEN.IsRight == true?"1":"0"); //是否正确
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.IsAccessKnowledge))
 {
 sbSQL.AppendFormat(" IsAccessKnowledge = '{0}',", objcc_WorkStuRelationEN.IsAccessKnowledge == true?"1":"0"); //是否处理知识点
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.IsNotProcessTimeout))
 {
 sbSQL.AppendFormat(" IsNotProcessTimeout = '{0}',", objcc_WorkStuRelationEN.IsNotProcessTimeout == true?"1":"0"); //是否不处理超时
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.SchoolYear))
 {
 if (objcc_WorkStuRelationEN.SchoolYear !=  null)
 {
 var strSchoolYear = objcc_WorkStuRelationEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolYear = '{0}',", strSchoolYear); //学年
 }
 else
 {
 sbSQL.Append(" SchoolYear = null,"); //学年
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.SchoolTerm))
 {
 if (objcc_WorkStuRelationEN.SchoolTerm !=  null)
 {
 var strSchoolTerm = objcc_WorkStuRelationEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolTerm = '{0}',", strSchoolTerm); //学期
 }
 else
 {
 sbSQL.Append(" SchoolTerm = null,"); //学期
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.ErrMsg))
 {
 if (objcc_WorkStuRelationEN.ErrMsg !=  null)
 {
 var strErrMsg = objcc_WorkStuRelationEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ErrMsg = '{0}',", strErrMsg); //错误信息
 }
 else
 {
 sbSQL.Append(" ErrMsg = null,"); //错误信息
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.CourseId))
 {
 if (objcc_WorkStuRelationEN.CourseId !=  null)
 {
 var strCourseId = objcc_WorkStuRelationEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.UpdDate))
 {
 if (objcc_WorkStuRelationEN.UpdDate !=  null)
 {
 var strUpdDate = objcc_WorkStuRelationEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.UpdUserId))
 {
 if (objcc_WorkStuRelationEN.UpdUserId !=  null)
 {
 var strUpdUserId = objcc_WorkStuRelationEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.Memo))
 {
 if (objcc_WorkStuRelationEN.Memo !=  null)
 {
 var strMemo = objcc_WorkStuRelationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objcc_WorkStuRelationEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clscc_WorkStuRelationEN objcc_WorkStuRelationEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objcc_WorkStuRelationEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_WorkStuRelationEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_WorkStuRelationEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkStuRelationDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update cc_WorkStuRelation Set ");
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.IdCurrEduCls))
 {
 if (objcc_WorkStuRelationEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objcc_WorkStuRelationEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, concc_WorkStuRelation.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.QuestionId))
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_WorkStuRelationEN.QuestionId, concc_WorkStuRelation.QuestionId); //题目Id
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.Scores))
 {
 if (objcc_WorkStuRelationEN.Scores !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_WorkStuRelationEN.Scores, concc_WorkStuRelation.Scores); //分值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation.Scores); //分值
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.SpecifyCompletionDate))
 {
 if (objcc_WorkStuRelationEN.SpecifyCompletionDate !=  null)
 {
 var strSpecifyCompletionDate = objcc_WorkStuRelationEN.SpecifyCompletionDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSpecifyCompletionDate, concc_WorkStuRelation.SpecifyCompletionDate); //指定完成日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation.SpecifyCompletionDate); //指定完成日期
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.IdStudentInfo))
 {
 if (objcc_WorkStuRelationEN.IdStudentInfo  ==  "")
 {
 objcc_WorkStuRelationEN.IdStudentInfo = null;
 }
 if (objcc_WorkStuRelationEN.IdStudentInfo !=  null)
 {
 var strIdStudentInfo = objcc_WorkStuRelationEN.IdStudentInfo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdStudentInfo, concc_WorkStuRelation.IdStudentInfo); //学生流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation.IdStudentInfo); //学生流水号
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.AnswerModeId))
 {
 if (objcc_WorkStuRelationEN.AnswerModeId !=  null)
 {
 var strAnswerModeId = objcc_WorkStuRelationEN.AnswerModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerModeId, concc_WorkStuRelation.AnswerModeId); //答案模式Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation.AnswerModeId); //答案模式Id
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.AnswerOptionId))
 {
 if (objcc_WorkStuRelationEN.AnswerOptionId !=  null)
 {
 var strAnswerOptionId = objcc_WorkStuRelationEN.AnswerOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerOptionId, concc_WorkStuRelation.AnswerOptionId); //回答选项Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation.AnswerOptionId); //回答选项Id
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.AnswerMultiOptions))
 {
 if (objcc_WorkStuRelationEN.AnswerMultiOptions !=  null)
 {
 var strAnswerMultiOptions = objcc_WorkStuRelationEN.AnswerMultiOptions.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerMultiOptions, concc_WorkStuRelation.AnswerMultiOptions); //多选项答案
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation.AnswerMultiOptions); //多选项答案
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.AnswerBoolResult))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_WorkStuRelationEN.AnswerBoolResult == true?"1":"0", concc_WorkStuRelation.AnswerBoolResult); //答案布尔结果
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.StuAnswerText))
 {
 if (objcc_WorkStuRelationEN.StuAnswerText !=  null)
 {
 var strStuAnswerText = objcc_WorkStuRelationEN.StuAnswerText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStuAnswerText, concc_WorkStuRelation.StuAnswerText); //学生回答文本
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation.StuAnswerText); //学生回答文本
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.IsPublish))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_WorkStuRelationEN.IsPublish == true?"1":"0", concc_WorkStuRelation.IsPublish); //是否发布
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.IsLook))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_WorkStuRelationEN.IsLook == true?"1":"0", concc_WorkStuRelation.IsLook); //是否查看
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.IsSave))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_WorkStuRelationEN.IsSave == true?"1":"0", concc_WorkStuRelation.IsSave); //是否保存
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_WorkStuRelationEN.IsSubmit == true?"1":"0", concc_WorkStuRelation.IsSubmit); //是否提交
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.ApplySendBackDate))
 {
 if (objcc_WorkStuRelationEN.ApplySendBackDate !=  null)
 {
 var strApplySendBackDate = objcc_WorkStuRelationEN.ApplySendBackDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strApplySendBackDate, concc_WorkStuRelation.ApplySendBackDate); //申请退回日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation.ApplySendBackDate); //申请退回日期
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.IsApplySendBack))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_WorkStuRelationEN.IsApplySendBack == true?"1":"0", concc_WorkStuRelation.IsApplySendBack); //是否申请退回
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.RealFinishDate))
 {
 if (objcc_WorkStuRelationEN.RealFinishDate !=  null)
 {
 var strRealFinishDate = objcc_WorkStuRelationEN.RealFinishDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRealFinishDate, concc_WorkStuRelation.RealFinishDate); //实际完成日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation.RealFinishDate); //实际完成日期
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.OperateTime))
 {
 if (objcc_WorkStuRelationEN.OperateTime !=  null)
 {
 var strOperateTime = objcc_WorkStuRelationEN.OperateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOperateTime, concc_WorkStuRelation.OperateTime); //操作时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation.OperateTime); //操作时间
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.Score))
 {
 if (objcc_WorkStuRelationEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_WorkStuRelationEN.Score, concc_WorkStuRelation.Score); //得分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation.Score); //得分
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.Comment))
 {
 if (objcc_WorkStuRelationEN.Comment !=  null)
 {
 var strComment = objcc_WorkStuRelationEN.Comment.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strComment, concc_WorkStuRelation.Comment); //批注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation.Comment); //批注
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.IsMarking))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_WorkStuRelationEN.IsMarking == true?"1":"0", concc_WorkStuRelation.IsMarking); //是否批阅
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.MarkerId))
 {
 if (objcc_WorkStuRelationEN.MarkerId !=  null)
 {
 var strMarkerId = objcc_WorkStuRelationEN.MarkerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMarkerId, concc_WorkStuRelation.MarkerId); //打分者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation.MarkerId); //打分者
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.MarkDate))
 {
 if (objcc_WorkStuRelationEN.MarkDate !=  null)
 {
 var strMarkDate = objcc_WorkStuRelationEN.MarkDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMarkDate, concc_WorkStuRelation.MarkDate); //打分日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation.MarkDate); //打分日期
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.IsSendBack))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_WorkStuRelationEN.IsSendBack == true?"1":"0", concc_WorkStuRelation.IsSendBack); //是否退回
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.IsInErrorQuestion))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_WorkStuRelationEN.IsInErrorQuestion == true?"1":"0", concc_WorkStuRelation.IsInErrorQuestion); //是否进入错题
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.WorkTypeId))
 {
 if (objcc_WorkStuRelationEN.WorkTypeId !=  null)
 {
 var strWorkTypeId = objcc_WorkStuRelationEN.WorkTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWorkTypeId, concc_WorkStuRelation.WorkTypeId); //作业类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation.WorkTypeId); //作业类型Id
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.AnswerIP))
 {
 if (objcc_WorkStuRelationEN.AnswerIP !=  null)
 {
 var strAnswerIP = objcc_WorkStuRelationEN.AnswerIP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerIP, concc_WorkStuRelation.AnswerIP); //回答IP
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation.AnswerIP); //回答IP
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.AnswerDate))
 {
 if (objcc_WorkStuRelationEN.AnswerDate !=  null)
 {
 var strAnswerDate = objcc_WorkStuRelationEN.AnswerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerDate, concc_WorkStuRelation.AnswerDate); //回答日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation.AnswerDate); //回答日期
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.AnswerTime))
 {
 if (objcc_WorkStuRelationEN.AnswerTime !=  null)
 {
 var strAnswerTime = objcc_WorkStuRelationEN.AnswerTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerTime, concc_WorkStuRelation.AnswerTime); //回答时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation.AnswerTime); //回答时间
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.CourseExamPaperId))
 {
 if (objcc_WorkStuRelationEN.CourseExamPaperId !=  null)
 {
 var strCourseExamPaperId = objcc_WorkStuRelationEN.CourseExamPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseExamPaperId, concc_WorkStuRelation.CourseExamPaperId); //考卷流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation.CourseExamPaperId); //考卷流水号
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.IsRight))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_WorkStuRelationEN.IsRight == true?"1":"0", concc_WorkStuRelation.IsRight); //是否正确
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.IsAccessKnowledge))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_WorkStuRelationEN.IsAccessKnowledge == true?"1":"0", concc_WorkStuRelation.IsAccessKnowledge); //是否处理知识点
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.IsNotProcessTimeout))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_WorkStuRelationEN.IsNotProcessTimeout == true?"1":"0", concc_WorkStuRelation.IsNotProcessTimeout); //是否不处理超时
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.SchoolYear))
 {
 if (objcc_WorkStuRelationEN.SchoolYear !=  null)
 {
 var strSchoolYear = objcc_WorkStuRelationEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchoolYear, concc_WorkStuRelation.SchoolYear); //学年
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation.SchoolYear); //学年
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.SchoolTerm))
 {
 if (objcc_WorkStuRelationEN.SchoolTerm !=  null)
 {
 var strSchoolTerm = objcc_WorkStuRelationEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchoolTerm, concc_WorkStuRelation.SchoolTerm); //学期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation.SchoolTerm); //学期
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.ErrMsg))
 {
 if (objcc_WorkStuRelationEN.ErrMsg !=  null)
 {
 var strErrMsg = objcc_WorkStuRelationEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strErrMsg, concc_WorkStuRelation.ErrMsg); //错误信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation.ErrMsg); //错误信息
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.CourseId))
 {
 if (objcc_WorkStuRelationEN.CourseId !=  null)
 {
 var strCourseId = objcc_WorkStuRelationEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, concc_WorkStuRelation.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation.CourseId); //课程Id
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.UpdDate))
 {
 if (objcc_WorkStuRelationEN.UpdDate !=  null)
 {
 var strUpdDate = objcc_WorkStuRelationEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, concc_WorkStuRelation.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation.UpdDate); //修改日期
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.UpdUserId))
 {
 if (objcc_WorkStuRelationEN.UpdUserId !=  null)
 {
 var strUpdUserId = objcc_WorkStuRelationEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, concc_WorkStuRelation.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation.UpdUserId); //修改用户Id
 }
 }
 
 if (objcc_WorkStuRelationEN.IsUpdated(concc_WorkStuRelation.Memo))
 {
 if (objcc_WorkStuRelationEN.Memo !=  null)
 {
 var strMemo = objcc_WorkStuRelationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, concc_WorkStuRelation.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkStuRelation.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdWorkStuRelation = {0}", objcc_WorkStuRelationEN.IdWorkStuRelation); 
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
 /// <param name = "lngIdWorkStuRelation">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngIdWorkStuRelation) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkStuRelationDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngIdWorkStuRelation,
};
 objSQL.ExecSP("cc_WorkStuRelation_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngIdWorkStuRelation">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngIdWorkStuRelation, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkStuRelationDA.GetSpecSQLObj();
//删除cc_WorkStuRelation本表中与当前对象有关的记录
strSQL = strSQL + "Delete from cc_WorkStuRelation where IdWorkStuRelation = " + ""+ lngIdWorkStuRelation+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delcc_WorkStuRelation(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkStuRelationDA.GetSpecSQLObj();
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
//删除cc_WorkStuRelation本表中与当前对象有关的记录
strSQL = strSQL + "Delete from cc_WorkStuRelation where IdWorkStuRelation in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngIdWorkStuRelation">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngIdWorkStuRelation) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkStuRelationDA.GetSpecSQLObj();
//删除cc_WorkStuRelation本表中与当前对象有关的记录
strSQL = strSQL + "Delete from cc_WorkStuRelation where IdWorkStuRelation = " + ""+ lngIdWorkStuRelation+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delcc_WorkStuRelation(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clscc_WorkStuRelationDA: Delcc_WorkStuRelation)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkStuRelationDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from cc_WorkStuRelation where " + strCondition ;
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
public bool Delcc_WorkStuRelationWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clscc_WorkStuRelationDA: Delcc_WorkStuRelationWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkStuRelationDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from cc_WorkStuRelation where " + strCondition ;
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
 /// <param name = "objcc_WorkStuRelationENS">源对象</param>
 /// <param name = "objcc_WorkStuRelationENT">目标对象</param>
public void CopyTo(clscc_WorkStuRelationEN objcc_WorkStuRelationENS, clscc_WorkStuRelationEN objcc_WorkStuRelationENT)
{
objcc_WorkStuRelationENT.IdWorkStuRelation = objcc_WorkStuRelationENS.IdWorkStuRelation; //流水号
objcc_WorkStuRelationENT.IdCurrEduCls = objcc_WorkStuRelationENS.IdCurrEduCls; //教学班流水号
objcc_WorkStuRelationENT.QuestionId = objcc_WorkStuRelationENS.QuestionId; //题目Id
objcc_WorkStuRelationENT.Scores = objcc_WorkStuRelationENS.Scores; //分值
objcc_WorkStuRelationENT.SpecifyCompletionDate = objcc_WorkStuRelationENS.SpecifyCompletionDate; //指定完成日期
objcc_WorkStuRelationENT.IdStudentInfo = objcc_WorkStuRelationENS.IdStudentInfo; //学生流水号
objcc_WorkStuRelationENT.AnswerModeId = objcc_WorkStuRelationENS.AnswerModeId; //答案模式Id
objcc_WorkStuRelationENT.AnswerOptionId = objcc_WorkStuRelationENS.AnswerOptionId; //回答选项Id
objcc_WorkStuRelationENT.AnswerMultiOptions = objcc_WorkStuRelationENS.AnswerMultiOptions; //多选项答案
objcc_WorkStuRelationENT.AnswerBoolResult = objcc_WorkStuRelationENS.AnswerBoolResult; //答案布尔结果
objcc_WorkStuRelationENT.StuAnswerText = objcc_WorkStuRelationENS.StuAnswerText; //学生回答文本
objcc_WorkStuRelationENT.IsPublish = objcc_WorkStuRelationENS.IsPublish; //是否发布
objcc_WorkStuRelationENT.IsLook = objcc_WorkStuRelationENS.IsLook; //是否查看
objcc_WorkStuRelationENT.IsSave = objcc_WorkStuRelationENS.IsSave; //是否保存
objcc_WorkStuRelationENT.IsSubmit = objcc_WorkStuRelationENS.IsSubmit; //是否提交
objcc_WorkStuRelationENT.ApplySendBackDate = objcc_WorkStuRelationENS.ApplySendBackDate; //申请退回日期
objcc_WorkStuRelationENT.IsApplySendBack = objcc_WorkStuRelationENS.IsApplySendBack; //是否申请退回
objcc_WorkStuRelationENT.RealFinishDate = objcc_WorkStuRelationENS.RealFinishDate; //实际完成日期
objcc_WorkStuRelationENT.OperateTime = objcc_WorkStuRelationENS.OperateTime; //操作时间
objcc_WorkStuRelationENT.Score = objcc_WorkStuRelationENS.Score; //得分
objcc_WorkStuRelationENT.Comment = objcc_WorkStuRelationENS.Comment; //批注
objcc_WorkStuRelationENT.IsMarking = objcc_WorkStuRelationENS.IsMarking; //是否批阅
objcc_WorkStuRelationENT.MarkerId = objcc_WorkStuRelationENS.MarkerId; //打分者
objcc_WorkStuRelationENT.MarkDate = objcc_WorkStuRelationENS.MarkDate; //打分日期
objcc_WorkStuRelationENT.IsSendBack = objcc_WorkStuRelationENS.IsSendBack; //是否退回
objcc_WorkStuRelationENT.IsInErrorQuestion = objcc_WorkStuRelationENS.IsInErrorQuestion; //是否进入错题
objcc_WorkStuRelationENT.WorkTypeId = objcc_WorkStuRelationENS.WorkTypeId; //作业类型Id
objcc_WorkStuRelationENT.AnswerIP = objcc_WorkStuRelationENS.AnswerIP; //回答IP
objcc_WorkStuRelationENT.AnswerDate = objcc_WorkStuRelationENS.AnswerDate; //回答日期
objcc_WorkStuRelationENT.AnswerTime = objcc_WorkStuRelationENS.AnswerTime; //回答时间
objcc_WorkStuRelationENT.CourseExamPaperId = objcc_WorkStuRelationENS.CourseExamPaperId; //考卷流水号
objcc_WorkStuRelationENT.IsRight = objcc_WorkStuRelationENS.IsRight; //是否正确
objcc_WorkStuRelationENT.IsAccessKnowledge = objcc_WorkStuRelationENS.IsAccessKnowledge; //是否处理知识点
objcc_WorkStuRelationENT.IsNotProcessTimeout = objcc_WorkStuRelationENS.IsNotProcessTimeout; //是否不处理超时
objcc_WorkStuRelationENT.SchoolYear = objcc_WorkStuRelationENS.SchoolYear; //学年
objcc_WorkStuRelationENT.SchoolTerm = objcc_WorkStuRelationENS.SchoolTerm; //学期
objcc_WorkStuRelationENT.ErrMsg = objcc_WorkStuRelationENS.ErrMsg; //错误信息
objcc_WorkStuRelationENT.CourseId = objcc_WorkStuRelationENS.CourseId; //课程Id
objcc_WorkStuRelationENT.UpdDate = objcc_WorkStuRelationENS.UpdDate; //修改日期
objcc_WorkStuRelationENT.UpdUserId = objcc_WorkStuRelationENS.UpdUserId; //修改用户Id
objcc_WorkStuRelationENT.Memo = objcc_WorkStuRelationENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clscc_WorkStuRelationEN objcc_WorkStuRelationEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objcc_WorkStuRelationEN.IdCurrEduCls, concc_WorkStuRelation.IdCurrEduCls);
clsCheckSql.CheckFieldNotNull(objcc_WorkStuRelationEN.QuestionId, concc_WorkStuRelation.QuestionId);
clsCheckSql.CheckFieldNotNull(objcc_WorkStuRelationEN.SpecifyCompletionDate, concc_WorkStuRelation.SpecifyCompletionDate);
clsCheckSql.CheckFieldNotNull(objcc_WorkStuRelationEN.IdStudentInfo, concc_WorkStuRelation.IdStudentInfo);
clsCheckSql.CheckFieldNotNull(objcc_WorkStuRelationEN.WorkTypeId, concc_WorkStuRelation.WorkTypeId);
clsCheckSql.CheckFieldNotNull(objcc_WorkStuRelationEN.CourseId, concc_WorkStuRelation.CourseId);
clsCheckSql.CheckFieldNotNull(objcc_WorkStuRelationEN.UpdDate, concc_WorkStuRelation.UpdDate);
//检查字段长度
clsCheckSql.CheckFieldLen(objcc_WorkStuRelationEN.IdCurrEduCls, 8, concc_WorkStuRelation.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelationEN.SpecifyCompletionDate, 14, concc_WorkStuRelation.SpecifyCompletionDate);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelationEN.IdStudentInfo, 8, concc_WorkStuRelation.IdStudentInfo);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelationEN.AnswerModeId, 4, concc_WorkStuRelation.AnswerModeId);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelationEN.AnswerOptionId, 8, concc_WorkStuRelation.AnswerOptionId);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelationEN.AnswerMultiOptions, 300, concc_WorkStuRelation.AnswerMultiOptions);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelationEN.ApplySendBackDate, 14, concc_WorkStuRelation.ApplySendBackDate);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelationEN.RealFinishDate, 14, concc_WorkStuRelation.RealFinishDate);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelationEN.OperateTime, 14, concc_WorkStuRelation.OperateTime);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelationEN.MarkerId, 20, concc_WorkStuRelation.MarkerId);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelationEN.MarkDate, 14, concc_WorkStuRelation.MarkDate);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelationEN.WorkTypeId, 2, concc_WorkStuRelation.WorkTypeId);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelationEN.AnswerIP, 30, concc_WorkStuRelation.AnswerIP);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelationEN.AnswerDate, 8, concc_WorkStuRelation.AnswerDate);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelationEN.AnswerTime, 10, concc_WorkStuRelation.AnswerTime);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelationEN.CourseExamPaperId, 8, concc_WorkStuRelation.CourseExamPaperId);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelationEN.SchoolYear, 10, concc_WorkStuRelation.SchoolYear);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelationEN.SchoolTerm, 1, concc_WorkStuRelation.SchoolTerm);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelationEN.ErrMsg, 200, concc_WorkStuRelation.ErrMsg);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelationEN.CourseId, 8, concc_WorkStuRelation.CourseId);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelationEN.UpdDate, 20, concc_WorkStuRelation.UpdDate);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelationEN.UpdUserId, 20, concc_WorkStuRelation.UpdUserId);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelationEN.Memo, 1000, concc_WorkStuRelation.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objcc_WorkStuRelationEN.IdStudentInfo, 8, concc_WorkStuRelation.IdStudentInfo);
 objcc_WorkStuRelationEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clscc_WorkStuRelationEN objcc_WorkStuRelationEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objcc_WorkStuRelationEN.IdCurrEduCls, 8, concc_WorkStuRelation.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelationEN.SpecifyCompletionDate, 14, concc_WorkStuRelation.SpecifyCompletionDate);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelationEN.IdStudentInfo, 8, concc_WorkStuRelation.IdStudentInfo);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelationEN.AnswerModeId, 4, concc_WorkStuRelation.AnswerModeId);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelationEN.AnswerOptionId, 8, concc_WorkStuRelation.AnswerOptionId);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelationEN.AnswerMultiOptions, 300, concc_WorkStuRelation.AnswerMultiOptions);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelationEN.ApplySendBackDate, 14, concc_WorkStuRelation.ApplySendBackDate);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelationEN.RealFinishDate, 14, concc_WorkStuRelation.RealFinishDate);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelationEN.OperateTime, 14, concc_WorkStuRelation.OperateTime);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelationEN.MarkerId, 20, concc_WorkStuRelation.MarkerId);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelationEN.MarkDate, 14, concc_WorkStuRelation.MarkDate);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelationEN.WorkTypeId, 2, concc_WorkStuRelation.WorkTypeId);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelationEN.AnswerIP, 30, concc_WorkStuRelation.AnswerIP);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelationEN.AnswerDate, 8, concc_WorkStuRelation.AnswerDate);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelationEN.AnswerTime, 10, concc_WorkStuRelation.AnswerTime);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelationEN.CourseExamPaperId, 8, concc_WorkStuRelation.CourseExamPaperId);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelationEN.SchoolYear, 10, concc_WorkStuRelation.SchoolYear);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelationEN.SchoolTerm, 1, concc_WorkStuRelation.SchoolTerm);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelationEN.ErrMsg, 200, concc_WorkStuRelation.ErrMsg);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelationEN.CourseId, 8, concc_WorkStuRelation.CourseId);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelationEN.UpdDate, 20, concc_WorkStuRelation.UpdDate);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelationEN.UpdUserId, 20, concc_WorkStuRelation.UpdUserId);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelationEN.Memo, 1000, concc_WorkStuRelation.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objcc_WorkStuRelationEN.IdStudentInfo, 8, concc_WorkStuRelation.IdStudentInfo);
 objcc_WorkStuRelationEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clscc_WorkStuRelationEN objcc_WorkStuRelationEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objcc_WorkStuRelationEN.IdCurrEduCls, 8, concc_WorkStuRelation.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelationEN.SpecifyCompletionDate, 14, concc_WorkStuRelation.SpecifyCompletionDate);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelationEN.IdStudentInfo, 8, concc_WorkStuRelation.IdStudentInfo);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelationEN.AnswerModeId, 4, concc_WorkStuRelation.AnswerModeId);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelationEN.AnswerOptionId, 8, concc_WorkStuRelation.AnswerOptionId);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelationEN.AnswerMultiOptions, 300, concc_WorkStuRelation.AnswerMultiOptions);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelationEN.ApplySendBackDate, 14, concc_WorkStuRelation.ApplySendBackDate);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelationEN.RealFinishDate, 14, concc_WorkStuRelation.RealFinishDate);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelationEN.OperateTime, 14, concc_WorkStuRelation.OperateTime);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelationEN.MarkerId, 20, concc_WorkStuRelation.MarkerId);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelationEN.MarkDate, 14, concc_WorkStuRelation.MarkDate);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelationEN.WorkTypeId, 2, concc_WorkStuRelation.WorkTypeId);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelationEN.AnswerIP, 30, concc_WorkStuRelation.AnswerIP);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelationEN.AnswerDate, 8, concc_WorkStuRelation.AnswerDate);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelationEN.AnswerTime, 10, concc_WorkStuRelation.AnswerTime);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelationEN.CourseExamPaperId, 8, concc_WorkStuRelation.CourseExamPaperId);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelationEN.SchoolYear, 10, concc_WorkStuRelation.SchoolYear);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelationEN.SchoolTerm, 1, concc_WorkStuRelation.SchoolTerm);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelationEN.ErrMsg, 200, concc_WorkStuRelation.ErrMsg);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelationEN.CourseId, 8, concc_WorkStuRelation.CourseId);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelationEN.UpdDate, 20, concc_WorkStuRelation.UpdDate);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelationEN.UpdUserId, 20, concc_WorkStuRelation.UpdUserId);
clsCheckSql.CheckFieldLen(objcc_WorkStuRelationEN.Memo, 1000, concc_WorkStuRelation.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objcc_WorkStuRelationEN.IdCurrEduCls, concc_WorkStuRelation.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objcc_WorkStuRelationEN.SpecifyCompletionDate, concc_WorkStuRelation.SpecifyCompletionDate);
clsCheckSql.CheckSqlInjection4Field(objcc_WorkStuRelationEN.IdStudentInfo, concc_WorkStuRelation.IdStudentInfo);
clsCheckSql.CheckSqlInjection4Field(objcc_WorkStuRelationEN.AnswerModeId, concc_WorkStuRelation.AnswerModeId);
clsCheckSql.CheckSqlInjection4Field(objcc_WorkStuRelationEN.AnswerOptionId, concc_WorkStuRelation.AnswerOptionId);
clsCheckSql.CheckSqlInjection4Field(objcc_WorkStuRelationEN.AnswerMultiOptions, concc_WorkStuRelation.AnswerMultiOptions);
clsCheckSql.CheckSqlInjection4Field(objcc_WorkStuRelationEN.ApplySendBackDate, concc_WorkStuRelation.ApplySendBackDate);
clsCheckSql.CheckSqlInjection4Field(objcc_WorkStuRelationEN.RealFinishDate, concc_WorkStuRelation.RealFinishDate);
clsCheckSql.CheckSqlInjection4Field(objcc_WorkStuRelationEN.OperateTime, concc_WorkStuRelation.OperateTime);
clsCheckSql.CheckSqlInjection4Field(objcc_WorkStuRelationEN.MarkerId, concc_WorkStuRelation.MarkerId);
clsCheckSql.CheckSqlInjection4Field(objcc_WorkStuRelationEN.MarkDate, concc_WorkStuRelation.MarkDate);
clsCheckSql.CheckSqlInjection4Field(objcc_WorkStuRelationEN.WorkTypeId, concc_WorkStuRelation.WorkTypeId);
clsCheckSql.CheckSqlInjection4Field(objcc_WorkStuRelationEN.AnswerIP, concc_WorkStuRelation.AnswerIP);
clsCheckSql.CheckSqlInjection4Field(objcc_WorkStuRelationEN.AnswerDate, concc_WorkStuRelation.AnswerDate);
clsCheckSql.CheckSqlInjection4Field(objcc_WorkStuRelationEN.AnswerTime, concc_WorkStuRelation.AnswerTime);
clsCheckSql.CheckSqlInjection4Field(objcc_WorkStuRelationEN.CourseExamPaperId, concc_WorkStuRelation.CourseExamPaperId);
clsCheckSql.CheckSqlInjection4Field(objcc_WorkStuRelationEN.SchoolYear, concc_WorkStuRelation.SchoolYear);
clsCheckSql.CheckSqlInjection4Field(objcc_WorkStuRelationEN.SchoolTerm, concc_WorkStuRelation.SchoolTerm);
clsCheckSql.CheckSqlInjection4Field(objcc_WorkStuRelationEN.ErrMsg, concc_WorkStuRelation.ErrMsg);
clsCheckSql.CheckSqlInjection4Field(objcc_WorkStuRelationEN.CourseId, concc_WorkStuRelation.CourseId);
clsCheckSql.CheckSqlInjection4Field(objcc_WorkStuRelationEN.UpdDate, concc_WorkStuRelation.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objcc_WorkStuRelationEN.UpdUserId, concc_WorkStuRelation.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objcc_WorkStuRelationEN.Memo, concc_WorkStuRelation.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objcc_WorkStuRelationEN.IdStudentInfo, 8, concc_WorkStuRelation.IdStudentInfo);
 objcc_WorkStuRelationEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--cc_WorkStuRelation(作业与学生关系),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clscc_WorkStuRelationEN objcc_WorkStuRelationEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and IdCurrEduCls = '{0}'", objcc_WorkStuRelationEN.IdCurrEduCls);
 sbCondition.AppendFormat(" and QuestionId = '{0}'", objcc_WorkStuRelationEN.QuestionId);
 sbCondition.AppendFormat(" and IdStudentInfo = '{0}'", objcc_WorkStuRelationEN.IdStudentInfo);
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
 objSQL = clscc_WorkStuRelationDA.GetSpecSQLObj();
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
 objSQL = clscc_WorkStuRelationDA.GetSpecSQLObj();
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
 objSQL = clscc_WorkStuRelationDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clscc_WorkStuRelationEN._CurrTabName);
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
 objSQL = clscc_WorkStuRelationDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clscc_WorkStuRelationEN._CurrTabName, strCondition);
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
 objSQL = clscc_WorkStuRelationDA.GetSpecSQLObj();
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
 objSQL = clscc_WorkStuRelationDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}