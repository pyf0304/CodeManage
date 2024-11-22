
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_WorkEduClsRelaDA
 表名:cc_WorkEduClsRela(01120164)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:00:43
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
 /// 作业教学班关系(cc_WorkEduClsRela)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clscc_WorkEduClsRelaDA : clsCommBase4DA
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
 return clscc_WorkEduClsRelaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clscc_WorkEduClsRelaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clscc_WorkEduClsRelaEN._ConnectString);
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
 if (string.IsNullOrEmpty(clscc_WorkEduClsRelaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clscc_WorkEduClsRelaEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clscc_WorkEduClsRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkEduClsRelaDA.GetSpecSQLObj();
strSQL = "Select * from cc_WorkEduClsRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_cc_WorkEduClsRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clscc_WorkEduClsRelaDA: GetDataTable_cc_WorkEduClsRela)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkEduClsRelaDA.GetSpecSQLObj();
strSQL = "Select * from cc_WorkEduClsRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clscc_WorkEduClsRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkEduClsRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clscc_WorkEduClsRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkEduClsRelaDA.GetSpecSQLObj();
strSQL = "Select * from cc_WorkEduClsRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clscc_WorkEduClsRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkEduClsRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clscc_WorkEduClsRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkEduClsRelaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from cc_WorkEduClsRela where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from cc_WorkEduClsRela where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clscc_WorkEduClsRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkEduClsRelaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from cc_WorkEduClsRela where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clscc_WorkEduClsRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkEduClsRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} cc_WorkEduClsRela.* from cc_WorkEduClsRela Left Join {1} on {2} where {3} and cc_WorkEduClsRela.IdWorkEduClsRela not in (Select top {5} cc_WorkEduClsRela.IdWorkEduClsRela from cc_WorkEduClsRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from cc_WorkEduClsRela where {1} and IdWorkEduClsRela not in (Select top {2} IdWorkEduClsRela from cc_WorkEduClsRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from cc_WorkEduClsRela where {1} and IdWorkEduClsRela not in (Select top {3} IdWorkEduClsRela from cc_WorkEduClsRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clscc_WorkEduClsRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkEduClsRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} cc_WorkEduClsRela.* from cc_WorkEduClsRela Left Join {1} on {2} where {3} and cc_WorkEduClsRela.IdWorkEduClsRela not in (Select top {5} cc_WorkEduClsRela.IdWorkEduClsRela from cc_WorkEduClsRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from cc_WorkEduClsRela where {1} and IdWorkEduClsRela not in (Select top {2} IdWorkEduClsRela from cc_WorkEduClsRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from cc_WorkEduClsRela where {1} and IdWorkEduClsRela not in (Select top {3} IdWorkEduClsRela from cc_WorkEduClsRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clscc_WorkEduClsRelaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clscc_WorkEduClsRelaDA:GetObjLst)", objException.Message));
}
List<clscc_WorkEduClsRelaEN> arrObjLst = new List<clscc_WorkEduClsRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkEduClsRelaDA.GetSpecSQLObj();
strSQL = "Select * from cc_WorkEduClsRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_WorkEduClsRelaEN objcc_WorkEduClsRelaEN = new clscc_WorkEduClsRelaEN();
try
{
objcc_WorkEduClsRelaEN.IdWorkEduClsRela = TransNullToInt(objRow[concc_WorkEduClsRela.IdWorkEduClsRela].ToString().Trim()); //作业教学班关系流水号
objcc_WorkEduClsRelaEN.QuestionId = TransNullToInt(objRow[concc_WorkEduClsRela.QuestionId].ToString().Trim()); //题目Id
objcc_WorkEduClsRelaEN.IdCurrEduCls = objRow[concc_WorkEduClsRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objcc_WorkEduClsRelaEN.Scores = objRow[concc_WorkEduClsRela.Scores] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_WorkEduClsRela.Scores].ToString().Trim()); //分值
objcc_WorkEduClsRelaEN.TeacherId = objRow[concc_WorkEduClsRela.TeacherId].ToString().Trim(); //教师工号
objcc_WorkEduClsRelaEN.IsPublish = TransNullToBool(objRow[concc_WorkEduClsRela.IsPublish].ToString().Trim()); //是否发布
objcc_WorkEduClsRelaEN.PubDate = objRow[concc_WorkEduClsRela.PubDate] == DBNull.Value ? null : objRow[concc_WorkEduClsRela.PubDate].ToString().Trim(); //发布日期
objcc_WorkEduClsRelaEN.publisher = objRow[concc_WorkEduClsRela.publisher] == DBNull.Value ? null : objRow[concc_WorkEduClsRela.publisher].ToString().Trim(); //发布者Id
objcc_WorkEduClsRelaEN.SpecifyCompletionDate = objRow[concc_WorkEduClsRela.SpecifyCompletionDate] == DBNull.Value ? null : objRow[concc_WorkEduClsRela.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objcc_WorkEduClsRelaEN.IsCurrEduCls = TransNullToBool(objRow[concc_WorkEduClsRela.IsCurrEduCls].ToString().Trim()); //是否为教学班作业
objcc_WorkEduClsRelaEN.IsGroupWork = TransNullToBool(objRow[concc_WorkEduClsRela.IsGroupWork].ToString().Trim()); //是否为小组作业
objcc_WorkEduClsRelaEN.CourseStudentGroupId = objRow[concc_WorkEduClsRela.CourseStudentGroupId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[concc_WorkEduClsRela.CourseStudentGroupId].ToString().Trim()); //学生分组表流水号
objcc_WorkEduClsRelaEN.WorkTypeId = objRow[concc_WorkEduClsRela.WorkTypeId].ToString().Trim(); //作业类型Id
objcc_WorkEduClsRelaEN.UpdDate = objRow[concc_WorkEduClsRela.UpdDate].ToString().Trim(); //修改日期
objcc_WorkEduClsRelaEN.UpdUserId = objRow[concc_WorkEduClsRela.UpdUserId] == DBNull.Value ? null : objRow[concc_WorkEduClsRela.UpdUserId].ToString().Trim(); //修改用户Id
objcc_WorkEduClsRelaEN.Memo = objRow[concc_WorkEduClsRela.Memo] == DBNull.Value ? null : objRow[concc_WorkEduClsRela.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clscc_WorkEduClsRelaDA: GetObjLst)", objException.Message));
}
objcc_WorkEduClsRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objcc_WorkEduClsRelaEN);
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
public List<clscc_WorkEduClsRelaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clscc_WorkEduClsRelaDA:GetObjLstByTabName)", objException.Message));
}
List<clscc_WorkEduClsRelaEN> arrObjLst = new List<clscc_WorkEduClsRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkEduClsRelaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_WorkEduClsRelaEN objcc_WorkEduClsRelaEN = new clscc_WorkEduClsRelaEN();
try
{
objcc_WorkEduClsRelaEN.IdWorkEduClsRela = TransNullToInt(objRow[concc_WorkEduClsRela.IdWorkEduClsRela].ToString().Trim()); //作业教学班关系流水号
objcc_WorkEduClsRelaEN.QuestionId = TransNullToInt(objRow[concc_WorkEduClsRela.QuestionId].ToString().Trim()); //题目Id
objcc_WorkEduClsRelaEN.IdCurrEduCls = objRow[concc_WorkEduClsRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objcc_WorkEduClsRelaEN.Scores = objRow[concc_WorkEduClsRela.Scores] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_WorkEduClsRela.Scores].ToString().Trim()); //分值
objcc_WorkEduClsRelaEN.TeacherId = objRow[concc_WorkEduClsRela.TeacherId].ToString().Trim(); //教师工号
objcc_WorkEduClsRelaEN.IsPublish = TransNullToBool(objRow[concc_WorkEduClsRela.IsPublish].ToString().Trim()); //是否发布
objcc_WorkEduClsRelaEN.PubDate = objRow[concc_WorkEduClsRela.PubDate] == DBNull.Value ? null : objRow[concc_WorkEduClsRela.PubDate].ToString().Trim(); //发布日期
objcc_WorkEduClsRelaEN.publisher = objRow[concc_WorkEduClsRela.publisher] == DBNull.Value ? null : objRow[concc_WorkEduClsRela.publisher].ToString().Trim(); //发布者Id
objcc_WorkEduClsRelaEN.SpecifyCompletionDate = objRow[concc_WorkEduClsRela.SpecifyCompletionDate] == DBNull.Value ? null : objRow[concc_WorkEduClsRela.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objcc_WorkEduClsRelaEN.IsCurrEduCls = TransNullToBool(objRow[concc_WorkEduClsRela.IsCurrEduCls].ToString().Trim()); //是否为教学班作业
objcc_WorkEduClsRelaEN.IsGroupWork = TransNullToBool(objRow[concc_WorkEduClsRela.IsGroupWork].ToString().Trim()); //是否为小组作业
objcc_WorkEduClsRelaEN.CourseStudentGroupId = objRow[concc_WorkEduClsRela.CourseStudentGroupId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[concc_WorkEduClsRela.CourseStudentGroupId].ToString().Trim()); //学生分组表流水号
objcc_WorkEduClsRelaEN.WorkTypeId = objRow[concc_WorkEduClsRela.WorkTypeId].ToString().Trim(); //作业类型Id
objcc_WorkEduClsRelaEN.UpdDate = objRow[concc_WorkEduClsRela.UpdDate].ToString().Trim(); //修改日期
objcc_WorkEduClsRelaEN.UpdUserId = objRow[concc_WorkEduClsRela.UpdUserId] == DBNull.Value ? null : objRow[concc_WorkEduClsRela.UpdUserId].ToString().Trim(); //修改用户Id
objcc_WorkEduClsRelaEN.Memo = objRow[concc_WorkEduClsRela.Memo] == DBNull.Value ? null : objRow[concc_WorkEduClsRela.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clscc_WorkEduClsRelaDA: GetObjLst)", objException.Message));
}
objcc_WorkEduClsRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objcc_WorkEduClsRelaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objcc_WorkEduClsRelaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getcc_WorkEduClsRela(ref clscc_WorkEduClsRelaEN objcc_WorkEduClsRelaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkEduClsRelaDA.GetSpecSQLObj();
strSQL = "Select * from cc_WorkEduClsRela where IdWorkEduClsRela = " + ""+ objcc_WorkEduClsRelaEN.IdWorkEduClsRela+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objcc_WorkEduClsRelaEN.IdWorkEduClsRela = TransNullToInt(objDT.Rows[0][concc_WorkEduClsRela.IdWorkEduClsRela].ToString().Trim()); //作业教学班关系流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objcc_WorkEduClsRelaEN.QuestionId = TransNullToInt(objDT.Rows[0][concc_WorkEduClsRela.QuestionId].ToString().Trim()); //题目Id(字段类型:bigint,字段长度:8,是否可空:True)
 objcc_WorkEduClsRelaEN.IdCurrEduCls = objDT.Rows[0][concc_WorkEduClsRela.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objcc_WorkEduClsRelaEN.Scores = TransNullToDouble(objDT.Rows[0][concc_WorkEduClsRela.Scores].ToString().Trim()); //分值(字段类型:decimal,字段长度:8,是否可空:True)
 objcc_WorkEduClsRelaEN.TeacherId = objDT.Rows[0][concc_WorkEduClsRela.TeacherId].ToString().Trim(); //教师工号(字段类型:varchar,字段长度:12,是否可空:False)
 objcc_WorkEduClsRelaEN.IsPublish = TransNullToBool(objDT.Rows[0][concc_WorkEduClsRela.IsPublish].ToString().Trim()); //是否发布(字段类型:bit,字段长度:1,是否可空:True)
 objcc_WorkEduClsRelaEN.PubDate = objDT.Rows[0][concc_WorkEduClsRela.PubDate].ToString().Trim(); //发布日期(字段类型:varchar,字段长度:14,是否可空:False)
 objcc_WorkEduClsRelaEN.publisher = objDT.Rows[0][concc_WorkEduClsRela.publisher].ToString().Trim(); //发布者Id(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_WorkEduClsRelaEN.SpecifyCompletionDate = objDT.Rows[0][concc_WorkEduClsRela.SpecifyCompletionDate].ToString().Trim(); //指定完成日期(字段类型:varchar,字段长度:14,是否可空:False)
 objcc_WorkEduClsRelaEN.IsCurrEduCls = TransNullToBool(objDT.Rows[0][concc_WorkEduClsRela.IsCurrEduCls].ToString().Trim()); //是否为教学班作业(字段类型:bit,字段长度:1,是否可空:True)
 objcc_WorkEduClsRelaEN.IsGroupWork = TransNullToBool(objDT.Rows[0][concc_WorkEduClsRela.IsGroupWork].ToString().Trim()); //是否为小组作业(字段类型:bit,字段长度:1,是否可空:True)
 objcc_WorkEduClsRelaEN.CourseStudentGroupId = TransNullToInt(objDT.Rows[0][concc_WorkEduClsRela.CourseStudentGroupId].ToString().Trim()); //学生分组表流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objcc_WorkEduClsRelaEN.WorkTypeId = objDT.Rows[0][concc_WorkEduClsRela.WorkTypeId].ToString().Trim(); //作业类型Id(字段类型:char,字段长度:2,是否可空:False)
 objcc_WorkEduClsRelaEN.UpdDate = objDT.Rows[0][concc_WorkEduClsRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_WorkEduClsRelaEN.UpdUserId = objDT.Rows[0][concc_WorkEduClsRela.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_WorkEduClsRelaEN.Memo = objDT.Rows[0][concc_WorkEduClsRela.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clscc_WorkEduClsRelaDA: Getcc_WorkEduClsRela)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdWorkEduClsRela">表关键字</param>
 /// <returns>表对象</returns>
public clscc_WorkEduClsRelaEN GetObjByIdWorkEduClsRela(long lngIdWorkEduClsRela)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkEduClsRelaDA.GetSpecSQLObj();
strSQL = "Select * from cc_WorkEduClsRela where IdWorkEduClsRela = " + ""+ lngIdWorkEduClsRela+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clscc_WorkEduClsRelaEN objcc_WorkEduClsRelaEN = new clscc_WorkEduClsRelaEN();
try
{
 objcc_WorkEduClsRelaEN.IdWorkEduClsRela = Int32.Parse(objRow[concc_WorkEduClsRela.IdWorkEduClsRela].ToString().Trim()); //作业教学班关系流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objcc_WorkEduClsRelaEN.QuestionId = Int32.Parse(objRow[concc_WorkEduClsRela.QuestionId].ToString().Trim()); //题目Id(字段类型:bigint,字段长度:8,是否可空:True)
 objcc_WorkEduClsRelaEN.IdCurrEduCls = objRow[concc_WorkEduClsRela.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objcc_WorkEduClsRelaEN.Scores = objRow[concc_WorkEduClsRela.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_WorkEduClsRela.Scores].ToString().Trim()); //分值(字段类型:decimal,字段长度:8,是否可空:True)
 objcc_WorkEduClsRelaEN.TeacherId = objRow[concc_WorkEduClsRela.TeacherId].ToString().Trim(); //教师工号(字段类型:varchar,字段长度:12,是否可空:False)
 objcc_WorkEduClsRelaEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkEduClsRela.IsPublish].ToString().Trim()); //是否发布(字段类型:bit,字段长度:1,是否可空:True)
 objcc_WorkEduClsRelaEN.PubDate = objRow[concc_WorkEduClsRela.PubDate] == DBNull.Value ? null : objRow[concc_WorkEduClsRela.PubDate].ToString().Trim(); //发布日期(字段类型:varchar,字段长度:14,是否可空:False)
 objcc_WorkEduClsRelaEN.publisher = objRow[concc_WorkEduClsRela.publisher] == DBNull.Value ? null : objRow[concc_WorkEduClsRela.publisher].ToString().Trim(); //发布者Id(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_WorkEduClsRelaEN.SpecifyCompletionDate = objRow[concc_WorkEduClsRela.SpecifyCompletionDate] == DBNull.Value ? null : objRow[concc_WorkEduClsRela.SpecifyCompletionDate].ToString().Trim(); //指定完成日期(字段类型:varchar,字段长度:14,是否可空:False)
 objcc_WorkEduClsRelaEN.IsCurrEduCls = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkEduClsRela.IsCurrEduCls].ToString().Trim()); //是否为教学班作业(字段类型:bit,字段长度:1,是否可空:True)
 objcc_WorkEduClsRelaEN.IsGroupWork = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkEduClsRela.IsGroupWork].ToString().Trim()); //是否为小组作业(字段类型:bit,字段长度:1,是否可空:True)
 objcc_WorkEduClsRelaEN.CourseStudentGroupId = objRow[concc_WorkEduClsRela.CourseStudentGroupId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkEduClsRela.CourseStudentGroupId].ToString().Trim()); //学生分组表流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objcc_WorkEduClsRelaEN.WorkTypeId = objRow[concc_WorkEduClsRela.WorkTypeId].ToString().Trim(); //作业类型Id(字段类型:char,字段长度:2,是否可空:False)
 objcc_WorkEduClsRelaEN.UpdDate = objRow[concc_WorkEduClsRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_WorkEduClsRelaEN.UpdUserId = objRow[concc_WorkEduClsRela.UpdUserId] == DBNull.Value ? null : objRow[concc_WorkEduClsRela.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_WorkEduClsRelaEN.Memo = objRow[concc_WorkEduClsRela.Memo] == DBNull.Value ? null : objRow[concc_WorkEduClsRela.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clscc_WorkEduClsRelaDA: GetObjByIdWorkEduClsRela)", objException.Message));
}
return objcc_WorkEduClsRelaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clscc_WorkEduClsRelaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clscc_WorkEduClsRelaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkEduClsRelaDA.GetSpecSQLObj();
strSQL = "Select * from cc_WorkEduClsRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clscc_WorkEduClsRelaEN objcc_WorkEduClsRelaEN = new clscc_WorkEduClsRelaEN()
{
IdWorkEduClsRela = TransNullToInt(objRow[concc_WorkEduClsRela.IdWorkEduClsRela].ToString().Trim()), //作业教学班关系流水号
QuestionId = TransNullToInt(objRow[concc_WorkEduClsRela.QuestionId].ToString().Trim()), //题目Id
IdCurrEduCls = objRow[concc_WorkEduClsRela.IdCurrEduCls].ToString().Trim(), //教学班流水号
Scores = objRow[concc_WorkEduClsRela.Scores] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_WorkEduClsRela.Scores].ToString().Trim()), //分值
TeacherId = objRow[concc_WorkEduClsRela.TeacherId].ToString().Trim(), //教师工号
IsPublish = TransNullToBool(objRow[concc_WorkEduClsRela.IsPublish].ToString().Trim()), //是否发布
PubDate = objRow[concc_WorkEduClsRela.PubDate] == DBNull.Value ? null : objRow[concc_WorkEduClsRela.PubDate].ToString().Trim(), //发布日期
publisher = objRow[concc_WorkEduClsRela.publisher] == DBNull.Value ? null : objRow[concc_WorkEduClsRela.publisher].ToString().Trim(), //发布者Id
SpecifyCompletionDate = objRow[concc_WorkEduClsRela.SpecifyCompletionDate] == DBNull.Value ? null : objRow[concc_WorkEduClsRela.SpecifyCompletionDate].ToString().Trim(), //指定完成日期
IsCurrEduCls = TransNullToBool(objRow[concc_WorkEduClsRela.IsCurrEduCls].ToString().Trim()), //是否为教学班作业
IsGroupWork = TransNullToBool(objRow[concc_WorkEduClsRela.IsGroupWork].ToString().Trim()), //是否为小组作业
CourseStudentGroupId = objRow[concc_WorkEduClsRela.CourseStudentGroupId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[concc_WorkEduClsRela.CourseStudentGroupId].ToString().Trim()), //学生分组表流水号
WorkTypeId = objRow[concc_WorkEduClsRela.WorkTypeId].ToString().Trim(), //作业类型Id
UpdDate = objRow[concc_WorkEduClsRela.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[concc_WorkEduClsRela.UpdUserId] == DBNull.Value ? null : objRow[concc_WorkEduClsRela.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[concc_WorkEduClsRela.Memo] == DBNull.Value ? null : objRow[concc_WorkEduClsRela.Memo].ToString().Trim() //备注
};
objcc_WorkEduClsRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcc_WorkEduClsRelaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clscc_WorkEduClsRelaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clscc_WorkEduClsRelaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clscc_WorkEduClsRelaEN objcc_WorkEduClsRelaEN = new clscc_WorkEduClsRelaEN();
try
{
objcc_WorkEduClsRelaEN.IdWorkEduClsRela = TransNullToInt(objRow[concc_WorkEduClsRela.IdWorkEduClsRela].ToString().Trim()); //作业教学班关系流水号
objcc_WorkEduClsRelaEN.QuestionId = TransNullToInt(objRow[concc_WorkEduClsRela.QuestionId].ToString().Trim()); //题目Id
objcc_WorkEduClsRelaEN.IdCurrEduCls = objRow[concc_WorkEduClsRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objcc_WorkEduClsRelaEN.Scores = objRow[concc_WorkEduClsRela.Scores] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_WorkEduClsRela.Scores].ToString().Trim()); //分值
objcc_WorkEduClsRelaEN.TeacherId = objRow[concc_WorkEduClsRela.TeacherId].ToString().Trim(); //教师工号
objcc_WorkEduClsRelaEN.IsPublish = TransNullToBool(objRow[concc_WorkEduClsRela.IsPublish].ToString().Trim()); //是否发布
objcc_WorkEduClsRelaEN.PubDate = objRow[concc_WorkEduClsRela.PubDate] == DBNull.Value ? null : objRow[concc_WorkEduClsRela.PubDate].ToString().Trim(); //发布日期
objcc_WorkEduClsRelaEN.publisher = objRow[concc_WorkEduClsRela.publisher] == DBNull.Value ? null : objRow[concc_WorkEduClsRela.publisher].ToString().Trim(); //发布者Id
objcc_WorkEduClsRelaEN.SpecifyCompletionDate = objRow[concc_WorkEduClsRela.SpecifyCompletionDate] == DBNull.Value ? null : objRow[concc_WorkEduClsRela.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objcc_WorkEduClsRelaEN.IsCurrEduCls = TransNullToBool(objRow[concc_WorkEduClsRela.IsCurrEduCls].ToString().Trim()); //是否为教学班作业
objcc_WorkEduClsRelaEN.IsGroupWork = TransNullToBool(objRow[concc_WorkEduClsRela.IsGroupWork].ToString().Trim()); //是否为小组作业
objcc_WorkEduClsRelaEN.CourseStudentGroupId = objRow[concc_WorkEduClsRela.CourseStudentGroupId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[concc_WorkEduClsRela.CourseStudentGroupId].ToString().Trim()); //学生分组表流水号
objcc_WorkEduClsRelaEN.WorkTypeId = objRow[concc_WorkEduClsRela.WorkTypeId].ToString().Trim(); //作业类型Id
objcc_WorkEduClsRelaEN.UpdDate = objRow[concc_WorkEduClsRela.UpdDate].ToString().Trim(); //修改日期
objcc_WorkEduClsRelaEN.UpdUserId = objRow[concc_WorkEduClsRela.UpdUserId] == DBNull.Value ? null : objRow[concc_WorkEduClsRela.UpdUserId].ToString().Trim(); //修改用户Id
objcc_WorkEduClsRelaEN.Memo = objRow[concc_WorkEduClsRela.Memo] == DBNull.Value ? null : objRow[concc_WorkEduClsRela.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clscc_WorkEduClsRelaDA: GetObjByDataRowcc_WorkEduClsRela)", objException.Message));
}
objcc_WorkEduClsRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcc_WorkEduClsRelaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clscc_WorkEduClsRelaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clscc_WorkEduClsRelaEN objcc_WorkEduClsRelaEN = new clscc_WorkEduClsRelaEN();
try
{
objcc_WorkEduClsRelaEN.IdWorkEduClsRela = TransNullToInt(objRow[concc_WorkEduClsRela.IdWorkEduClsRela].ToString().Trim()); //作业教学班关系流水号
objcc_WorkEduClsRelaEN.QuestionId = TransNullToInt(objRow[concc_WorkEduClsRela.QuestionId].ToString().Trim()); //题目Id
objcc_WorkEduClsRelaEN.IdCurrEduCls = objRow[concc_WorkEduClsRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objcc_WorkEduClsRelaEN.Scores = objRow[concc_WorkEduClsRela.Scores] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_WorkEduClsRela.Scores].ToString().Trim()); //分值
objcc_WorkEduClsRelaEN.TeacherId = objRow[concc_WorkEduClsRela.TeacherId].ToString().Trim(); //教师工号
objcc_WorkEduClsRelaEN.IsPublish = TransNullToBool(objRow[concc_WorkEduClsRela.IsPublish].ToString().Trim()); //是否发布
objcc_WorkEduClsRelaEN.PubDate = objRow[concc_WorkEduClsRela.PubDate] == DBNull.Value ? null : objRow[concc_WorkEduClsRela.PubDate].ToString().Trim(); //发布日期
objcc_WorkEduClsRelaEN.publisher = objRow[concc_WorkEduClsRela.publisher] == DBNull.Value ? null : objRow[concc_WorkEduClsRela.publisher].ToString().Trim(); //发布者Id
objcc_WorkEduClsRelaEN.SpecifyCompletionDate = objRow[concc_WorkEduClsRela.SpecifyCompletionDate] == DBNull.Value ? null : objRow[concc_WorkEduClsRela.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objcc_WorkEduClsRelaEN.IsCurrEduCls = TransNullToBool(objRow[concc_WorkEduClsRela.IsCurrEduCls].ToString().Trim()); //是否为教学班作业
objcc_WorkEduClsRelaEN.IsGroupWork = TransNullToBool(objRow[concc_WorkEduClsRela.IsGroupWork].ToString().Trim()); //是否为小组作业
objcc_WorkEduClsRelaEN.CourseStudentGroupId = objRow[concc_WorkEduClsRela.CourseStudentGroupId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[concc_WorkEduClsRela.CourseStudentGroupId].ToString().Trim()); //学生分组表流水号
objcc_WorkEduClsRelaEN.WorkTypeId = objRow[concc_WorkEduClsRela.WorkTypeId].ToString().Trim(); //作业类型Id
objcc_WorkEduClsRelaEN.UpdDate = objRow[concc_WorkEduClsRela.UpdDate].ToString().Trim(); //修改日期
objcc_WorkEduClsRelaEN.UpdUserId = objRow[concc_WorkEduClsRela.UpdUserId] == DBNull.Value ? null : objRow[concc_WorkEduClsRela.UpdUserId].ToString().Trim(); //修改用户Id
objcc_WorkEduClsRelaEN.Memo = objRow[concc_WorkEduClsRela.Memo] == DBNull.Value ? null : objRow[concc_WorkEduClsRela.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clscc_WorkEduClsRelaDA: GetObjByDataRow)", objException.Message));
}
objcc_WorkEduClsRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcc_WorkEduClsRelaEN;
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
objSQL = clscc_WorkEduClsRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clscc_WorkEduClsRelaEN._CurrTabName, concc_WorkEduClsRela.IdWorkEduClsRela, 8, "");
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
objSQL = clscc_WorkEduClsRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clscc_WorkEduClsRelaEN._CurrTabName, concc_WorkEduClsRela.IdWorkEduClsRela, 8, strPrefix);
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
 objSQL = clscc_WorkEduClsRelaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdWorkEduClsRela from cc_WorkEduClsRela where " + strCondition;
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
 objSQL = clscc_WorkEduClsRelaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdWorkEduClsRela from cc_WorkEduClsRela where " + strCondition;
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
 objSQL = clscc_WorkEduClsRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("cc_WorkEduClsRela", "IdWorkEduClsRela = " + ""+ lngIdWorkEduClsRela+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clscc_WorkEduClsRelaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkEduClsRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("cc_WorkEduClsRela", strCondition))
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
objSQL = clscc_WorkEduClsRelaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("cc_WorkEduClsRela");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clscc_WorkEduClsRelaEN objcc_WorkEduClsRelaEN)
 {
 objcc_WorkEduClsRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_WorkEduClsRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_WorkEduClsRelaEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkEduClsRelaDA.GetSpecSQLObj();
strSQL = "Select * from cc_WorkEduClsRela where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "cc_WorkEduClsRela");
objRow = objDS.Tables["cc_WorkEduClsRela"].NewRow();
objRow[concc_WorkEduClsRela.QuestionId] = objcc_WorkEduClsRelaEN.QuestionId; //题目Id
objRow[concc_WorkEduClsRela.IdCurrEduCls] = objcc_WorkEduClsRelaEN.IdCurrEduCls; //教学班流水号
objRow[concc_WorkEduClsRela.Scores] = objcc_WorkEduClsRelaEN.Scores; //分值
objRow[concc_WorkEduClsRela.TeacherId] = objcc_WorkEduClsRelaEN.TeacherId; //教师工号
objRow[concc_WorkEduClsRela.IsPublish] = objcc_WorkEduClsRelaEN.IsPublish; //是否发布
 if (objcc_WorkEduClsRelaEN.PubDate !=  "")
 {
objRow[concc_WorkEduClsRela.PubDate] = objcc_WorkEduClsRelaEN.PubDate; //发布日期
 }
 if (objcc_WorkEduClsRelaEN.publisher !=  "")
 {
objRow[concc_WorkEduClsRela.publisher] = objcc_WorkEduClsRelaEN.publisher; //发布者Id
 }
 if (objcc_WorkEduClsRelaEN.SpecifyCompletionDate !=  "")
 {
objRow[concc_WorkEduClsRela.SpecifyCompletionDate] = objcc_WorkEduClsRelaEN.SpecifyCompletionDate; //指定完成日期
 }
objRow[concc_WorkEduClsRela.IsCurrEduCls] = objcc_WorkEduClsRelaEN.IsCurrEduCls; //是否为教学班作业
objRow[concc_WorkEduClsRela.IsGroupWork] = objcc_WorkEduClsRelaEN.IsGroupWork; //是否为小组作业
objRow[concc_WorkEduClsRela.CourseStudentGroupId] = objcc_WorkEduClsRelaEN.CourseStudentGroupId; //学生分组表流水号
objRow[concc_WorkEduClsRela.WorkTypeId] = objcc_WorkEduClsRelaEN.WorkTypeId; //作业类型Id
objRow[concc_WorkEduClsRela.UpdDate] = objcc_WorkEduClsRelaEN.UpdDate; //修改日期
 if (objcc_WorkEduClsRelaEN.UpdUserId !=  "")
 {
objRow[concc_WorkEduClsRela.UpdUserId] = objcc_WorkEduClsRelaEN.UpdUserId; //修改用户Id
 }
 if (objcc_WorkEduClsRelaEN.Memo !=  "")
 {
objRow[concc_WorkEduClsRela.Memo] = objcc_WorkEduClsRelaEN.Memo; //备注
 }
objDS.Tables[clscc_WorkEduClsRelaEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clscc_WorkEduClsRelaEN._CurrTabName);
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
 /// <param name = "objcc_WorkEduClsRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clscc_WorkEduClsRelaEN objcc_WorkEduClsRelaEN)
{
 objcc_WorkEduClsRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_WorkEduClsRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_WorkEduClsRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 arrFieldListForInsert.Add(concc_WorkEduClsRela.QuestionId);
 arrValueListForInsert.Add(objcc_WorkEduClsRelaEN.QuestionId.ToString());
 
 if (objcc_WorkEduClsRelaEN.IdCurrEduCls  ==  "")
 {
 objcc_WorkEduClsRelaEN.IdCurrEduCls = null;
 }
 if (objcc_WorkEduClsRelaEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkEduClsRela.IdCurrEduCls);
 var strIdCurrEduCls = objcc_WorkEduClsRelaEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objcc_WorkEduClsRelaEN.Scores !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkEduClsRela.Scores);
 arrValueListForInsert.Add(objcc_WorkEduClsRelaEN.Scores.ToString());
 }
 
 if (objcc_WorkEduClsRelaEN.TeacherId !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkEduClsRela.TeacherId);
 var strTeacherId = objcc_WorkEduClsRelaEN.TeacherId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeacherId + "'");
 }
 
 arrFieldListForInsert.Add(concc_WorkEduClsRela.IsPublish);
 arrValueListForInsert.Add("'" + (objcc_WorkEduClsRelaEN.IsPublish  ==  false ? "0" : "1") + "'");
 
 if (objcc_WorkEduClsRelaEN.PubDate !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkEduClsRela.PubDate);
 var strPubDate = objcc_WorkEduClsRelaEN.PubDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubDate + "'");
 }
 
 if (objcc_WorkEduClsRelaEN.publisher !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkEduClsRela.publisher);
 var strpublisher = objcc_WorkEduClsRelaEN.publisher.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strpublisher + "'");
 }
 
 if (objcc_WorkEduClsRelaEN.SpecifyCompletionDate !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkEduClsRela.SpecifyCompletionDate);
 var strSpecifyCompletionDate = objcc_WorkEduClsRelaEN.SpecifyCompletionDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSpecifyCompletionDate + "'");
 }
 
 arrFieldListForInsert.Add(concc_WorkEduClsRela.IsCurrEduCls);
 arrValueListForInsert.Add("'" + (objcc_WorkEduClsRelaEN.IsCurrEduCls  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_WorkEduClsRela.IsGroupWork);
 arrValueListForInsert.Add("'" + (objcc_WorkEduClsRelaEN.IsGroupWork  ==  false ? "0" : "1") + "'");
 
 if (objcc_WorkEduClsRelaEN.CourseStudentGroupId !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkEduClsRela.CourseStudentGroupId);
 arrValueListForInsert.Add(objcc_WorkEduClsRelaEN.CourseStudentGroupId.ToString());
 }
 
 if (objcc_WorkEduClsRelaEN.WorkTypeId !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkEduClsRela.WorkTypeId);
 var strWorkTypeId = objcc_WorkEduClsRelaEN.WorkTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWorkTypeId + "'");
 }
 
 if (objcc_WorkEduClsRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkEduClsRela.UpdDate);
 var strUpdDate = objcc_WorkEduClsRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcc_WorkEduClsRelaEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkEduClsRela.UpdUserId);
 var strUpdUserId = objcc_WorkEduClsRelaEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objcc_WorkEduClsRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkEduClsRela.Memo);
 var strMemo = objcc_WorkEduClsRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_WorkEduClsRela");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkEduClsRelaDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objcc_WorkEduClsRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clscc_WorkEduClsRelaEN objcc_WorkEduClsRelaEN)
{
 objcc_WorkEduClsRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_WorkEduClsRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_WorkEduClsRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 arrFieldListForInsert.Add(concc_WorkEduClsRela.QuestionId);
 arrValueListForInsert.Add(objcc_WorkEduClsRelaEN.QuestionId.ToString());
 
 if (objcc_WorkEduClsRelaEN.IdCurrEduCls  ==  "")
 {
 objcc_WorkEduClsRelaEN.IdCurrEduCls = null;
 }
 if (objcc_WorkEduClsRelaEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkEduClsRela.IdCurrEduCls);
 var strIdCurrEduCls = objcc_WorkEduClsRelaEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objcc_WorkEduClsRelaEN.Scores !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkEduClsRela.Scores);
 arrValueListForInsert.Add(objcc_WorkEduClsRelaEN.Scores.ToString());
 }
 
 if (objcc_WorkEduClsRelaEN.TeacherId !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkEduClsRela.TeacherId);
 var strTeacherId = objcc_WorkEduClsRelaEN.TeacherId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeacherId + "'");
 }
 
 arrFieldListForInsert.Add(concc_WorkEduClsRela.IsPublish);
 arrValueListForInsert.Add("'" + (objcc_WorkEduClsRelaEN.IsPublish  ==  false ? "0" : "1") + "'");
 
 if (objcc_WorkEduClsRelaEN.PubDate !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkEduClsRela.PubDate);
 var strPubDate = objcc_WorkEduClsRelaEN.PubDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubDate + "'");
 }
 
 if (objcc_WorkEduClsRelaEN.publisher !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkEduClsRela.publisher);
 var strpublisher = objcc_WorkEduClsRelaEN.publisher.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strpublisher + "'");
 }
 
 if (objcc_WorkEduClsRelaEN.SpecifyCompletionDate !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkEduClsRela.SpecifyCompletionDate);
 var strSpecifyCompletionDate = objcc_WorkEduClsRelaEN.SpecifyCompletionDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSpecifyCompletionDate + "'");
 }
 
 arrFieldListForInsert.Add(concc_WorkEduClsRela.IsCurrEduCls);
 arrValueListForInsert.Add("'" + (objcc_WorkEduClsRelaEN.IsCurrEduCls  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_WorkEduClsRela.IsGroupWork);
 arrValueListForInsert.Add("'" + (objcc_WorkEduClsRelaEN.IsGroupWork  ==  false ? "0" : "1") + "'");
 
 if (objcc_WorkEduClsRelaEN.CourseStudentGroupId !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkEduClsRela.CourseStudentGroupId);
 arrValueListForInsert.Add(objcc_WorkEduClsRelaEN.CourseStudentGroupId.ToString());
 }
 
 if (objcc_WorkEduClsRelaEN.WorkTypeId !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkEduClsRela.WorkTypeId);
 var strWorkTypeId = objcc_WorkEduClsRelaEN.WorkTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWorkTypeId + "'");
 }
 
 if (objcc_WorkEduClsRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkEduClsRela.UpdDate);
 var strUpdDate = objcc_WorkEduClsRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcc_WorkEduClsRelaEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkEduClsRela.UpdUserId);
 var strUpdUserId = objcc_WorkEduClsRelaEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objcc_WorkEduClsRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkEduClsRela.Memo);
 var strMemo = objcc_WorkEduClsRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_WorkEduClsRela");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkEduClsRelaDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objcc_WorkEduClsRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clscc_WorkEduClsRelaEN objcc_WorkEduClsRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objcc_WorkEduClsRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_WorkEduClsRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_WorkEduClsRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 arrFieldListForInsert.Add(concc_WorkEduClsRela.QuestionId);
 arrValueListForInsert.Add(objcc_WorkEduClsRelaEN.QuestionId.ToString());
 
 if (objcc_WorkEduClsRelaEN.IdCurrEduCls  ==  "")
 {
 objcc_WorkEduClsRelaEN.IdCurrEduCls = null;
 }
 if (objcc_WorkEduClsRelaEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkEduClsRela.IdCurrEduCls);
 var strIdCurrEduCls = objcc_WorkEduClsRelaEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objcc_WorkEduClsRelaEN.Scores !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkEduClsRela.Scores);
 arrValueListForInsert.Add(objcc_WorkEduClsRelaEN.Scores.ToString());
 }
 
 if (objcc_WorkEduClsRelaEN.TeacherId !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkEduClsRela.TeacherId);
 var strTeacherId = objcc_WorkEduClsRelaEN.TeacherId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeacherId + "'");
 }
 
 arrFieldListForInsert.Add(concc_WorkEduClsRela.IsPublish);
 arrValueListForInsert.Add("'" + (objcc_WorkEduClsRelaEN.IsPublish  ==  false ? "0" : "1") + "'");
 
 if (objcc_WorkEduClsRelaEN.PubDate !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkEduClsRela.PubDate);
 var strPubDate = objcc_WorkEduClsRelaEN.PubDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubDate + "'");
 }
 
 if (objcc_WorkEduClsRelaEN.publisher !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkEduClsRela.publisher);
 var strpublisher = objcc_WorkEduClsRelaEN.publisher.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strpublisher + "'");
 }
 
 if (objcc_WorkEduClsRelaEN.SpecifyCompletionDate !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkEduClsRela.SpecifyCompletionDate);
 var strSpecifyCompletionDate = objcc_WorkEduClsRelaEN.SpecifyCompletionDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSpecifyCompletionDate + "'");
 }
 
 arrFieldListForInsert.Add(concc_WorkEduClsRela.IsCurrEduCls);
 arrValueListForInsert.Add("'" + (objcc_WorkEduClsRelaEN.IsCurrEduCls  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_WorkEduClsRela.IsGroupWork);
 arrValueListForInsert.Add("'" + (objcc_WorkEduClsRelaEN.IsGroupWork  ==  false ? "0" : "1") + "'");
 
 if (objcc_WorkEduClsRelaEN.CourseStudentGroupId !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkEduClsRela.CourseStudentGroupId);
 arrValueListForInsert.Add(objcc_WorkEduClsRelaEN.CourseStudentGroupId.ToString());
 }
 
 if (objcc_WorkEduClsRelaEN.WorkTypeId !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkEduClsRela.WorkTypeId);
 var strWorkTypeId = objcc_WorkEduClsRelaEN.WorkTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWorkTypeId + "'");
 }
 
 if (objcc_WorkEduClsRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkEduClsRela.UpdDate);
 var strUpdDate = objcc_WorkEduClsRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcc_WorkEduClsRelaEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkEduClsRela.UpdUserId);
 var strUpdUserId = objcc_WorkEduClsRelaEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objcc_WorkEduClsRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkEduClsRela.Memo);
 var strMemo = objcc_WorkEduClsRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_WorkEduClsRela");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkEduClsRelaDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objcc_WorkEduClsRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clscc_WorkEduClsRelaEN objcc_WorkEduClsRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objcc_WorkEduClsRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_WorkEduClsRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_WorkEduClsRelaEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 arrFieldListForInsert.Add(concc_WorkEduClsRela.QuestionId);
 arrValueListForInsert.Add(objcc_WorkEduClsRelaEN.QuestionId.ToString());
 
 if (objcc_WorkEduClsRelaEN.IdCurrEduCls  ==  "")
 {
 objcc_WorkEduClsRelaEN.IdCurrEduCls = null;
 }
 if (objcc_WorkEduClsRelaEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkEduClsRela.IdCurrEduCls);
 var strIdCurrEduCls = objcc_WorkEduClsRelaEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objcc_WorkEduClsRelaEN.Scores !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkEduClsRela.Scores);
 arrValueListForInsert.Add(objcc_WorkEduClsRelaEN.Scores.ToString());
 }
 
 if (objcc_WorkEduClsRelaEN.TeacherId !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkEduClsRela.TeacherId);
 var strTeacherId = objcc_WorkEduClsRelaEN.TeacherId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeacherId + "'");
 }
 
 arrFieldListForInsert.Add(concc_WorkEduClsRela.IsPublish);
 arrValueListForInsert.Add("'" + (objcc_WorkEduClsRelaEN.IsPublish  ==  false ? "0" : "1") + "'");
 
 if (objcc_WorkEduClsRelaEN.PubDate !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkEduClsRela.PubDate);
 var strPubDate = objcc_WorkEduClsRelaEN.PubDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubDate + "'");
 }
 
 if (objcc_WorkEduClsRelaEN.publisher !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkEduClsRela.publisher);
 var strpublisher = objcc_WorkEduClsRelaEN.publisher.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strpublisher + "'");
 }
 
 if (objcc_WorkEduClsRelaEN.SpecifyCompletionDate !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkEduClsRela.SpecifyCompletionDate);
 var strSpecifyCompletionDate = objcc_WorkEduClsRelaEN.SpecifyCompletionDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSpecifyCompletionDate + "'");
 }
 
 arrFieldListForInsert.Add(concc_WorkEduClsRela.IsCurrEduCls);
 arrValueListForInsert.Add("'" + (objcc_WorkEduClsRelaEN.IsCurrEduCls  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_WorkEduClsRela.IsGroupWork);
 arrValueListForInsert.Add("'" + (objcc_WorkEduClsRelaEN.IsGroupWork  ==  false ? "0" : "1") + "'");
 
 if (objcc_WorkEduClsRelaEN.CourseStudentGroupId !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkEduClsRela.CourseStudentGroupId);
 arrValueListForInsert.Add(objcc_WorkEduClsRelaEN.CourseStudentGroupId.ToString());
 }
 
 if (objcc_WorkEduClsRelaEN.WorkTypeId !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkEduClsRela.WorkTypeId);
 var strWorkTypeId = objcc_WorkEduClsRelaEN.WorkTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWorkTypeId + "'");
 }
 
 if (objcc_WorkEduClsRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkEduClsRela.UpdDate);
 var strUpdDate = objcc_WorkEduClsRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcc_WorkEduClsRelaEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkEduClsRela.UpdUserId);
 var strUpdUserId = objcc_WorkEduClsRelaEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objcc_WorkEduClsRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkEduClsRela.Memo);
 var strMemo = objcc_WorkEduClsRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_WorkEduClsRela");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkEduClsRelaDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewcc_WorkEduClsRelas(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkEduClsRelaDA.GetSpecSQLObj();
strSQL = "Select * from cc_WorkEduClsRela where IdWorkEduClsRela = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "cc_WorkEduClsRela");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngIdWorkEduClsRela = TransNullToInt(oRow[concc_WorkEduClsRela.IdWorkEduClsRela].ToString().Trim());
if (IsExist(lngIdWorkEduClsRela))
{
 string strResult = "关键字变量值为:" + string.Format("IdWorkEduClsRela = {0}", lngIdWorkEduClsRela) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clscc_WorkEduClsRelaEN._CurrTabName ].NewRow();
objRow[concc_WorkEduClsRela.QuestionId] = oRow[concc_WorkEduClsRela.QuestionId].ToString().Trim(); //题目Id
objRow[concc_WorkEduClsRela.IdCurrEduCls] = oRow[concc_WorkEduClsRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objRow[concc_WorkEduClsRela.Scores] = oRow[concc_WorkEduClsRela.Scores].ToString().Trim(); //分值
objRow[concc_WorkEduClsRela.TeacherId] = oRow[concc_WorkEduClsRela.TeacherId].ToString().Trim(); //教师工号
objRow[concc_WorkEduClsRela.IsPublish] = oRow[concc_WorkEduClsRela.IsPublish].ToString().Trim(); //是否发布
objRow[concc_WorkEduClsRela.PubDate] = oRow[concc_WorkEduClsRela.PubDate].ToString().Trim(); //发布日期
objRow[concc_WorkEduClsRela.publisher] = oRow[concc_WorkEduClsRela.publisher].ToString().Trim(); //发布者Id
objRow[concc_WorkEduClsRela.SpecifyCompletionDate] = oRow[concc_WorkEduClsRela.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objRow[concc_WorkEduClsRela.IsCurrEduCls] = oRow[concc_WorkEduClsRela.IsCurrEduCls].ToString().Trim(); //是否为教学班作业
objRow[concc_WorkEduClsRela.IsGroupWork] = oRow[concc_WorkEduClsRela.IsGroupWork].ToString().Trim(); //是否为小组作业
objRow[concc_WorkEduClsRela.CourseStudentGroupId] = oRow[concc_WorkEduClsRela.CourseStudentGroupId].ToString().Trim(); //学生分组表流水号
objRow[concc_WorkEduClsRela.WorkTypeId] = oRow[concc_WorkEduClsRela.WorkTypeId].ToString().Trim(); //作业类型Id
objRow[concc_WorkEduClsRela.UpdDate] = oRow[concc_WorkEduClsRela.UpdDate].ToString().Trim(); //修改日期
objRow[concc_WorkEduClsRela.UpdUserId] = oRow[concc_WorkEduClsRela.UpdUserId].ToString().Trim(); //修改用户Id
objRow[concc_WorkEduClsRela.Memo] = oRow[concc_WorkEduClsRela.Memo].ToString().Trim(); //备注
 objDS.Tables[clscc_WorkEduClsRelaEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clscc_WorkEduClsRelaEN._CurrTabName);
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
 /// <param name = "objcc_WorkEduClsRelaEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clscc_WorkEduClsRelaEN objcc_WorkEduClsRelaEN)
{
 objcc_WorkEduClsRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_WorkEduClsRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_WorkEduClsRelaEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkEduClsRelaDA.GetSpecSQLObj();
strSQL = "Select * from cc_WorkEduClsRela where IdWorkEduClsRela = " + ""+ objcc_WorkEduClsRelaEN.IdWorkEduClsRela+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clscc_WorkEduClsRelaEN._CurrTabName);
if (objDS.Tables[clscc_WorkEduClsRelaEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:IdWorkEduClsRela = " + ""+ objcc_WorkEduClsRelaEN.IdWorkEduClsRela+"");
return false;
}
objRow = objDS.Tables[clscc_WorkEduClsRelaEN._CurrTabName].Rows[0];
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.QuestionId))
 {
objRow[concc_WorkEduClsRela.QuestionId] = objcc_WorkEduClsRelaEN.QuestionId; //题目Id
 }
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.IdCurrEduCls))
 {
objRow[concc_WorkEduClsRela.IdCurrEduCls] = objcc_WorkEduClsRelaEN.IdCurrEduCls; //教学班流水号
 }
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.Scores))
 {
objRow[concc_WorkEduClsRela.Scores] = objcc_WorkEduClsRelaEN.Scores; //分值
 }
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.TeacherId))
 {
objRow[concc_WorkEduClsRela.TeacherId] = objcc_WorkEduClsRelaEN.TeacherId; //教师工号
 }
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.IsPublish))
 {
objRow[concc_WorkEduClsRela.IsPublish] = objcc_WorkEduClsRelaEN.IsPublish; //是否发布
 }
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.PubDate))
 {
objRow[concc_WorkEduClsRela.PubDate] = objcc_WorkEduClsRelaEN.PubDate; //发布日期
 }
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.publisher))
 {
objRow[concc_WorkEduClsRela.publisher] = objcc_WorkEduClsRelaEN.publisher; //发布者Id
 }
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.SpecifyCompletionDate))
 {
objRow[concc_WorkEduClsRela.SpecifyCompletionDate] = objcc_WorkEduClsRelaEN.SpecifyCompletionDate; //指定完成日期
 }
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.IsCurrEduCls))
 {
objRow[concc_WorkEduClsRela.IsCurrEduCls] = objcc_WorkEduClsRelaEN.IsCurrEduCls; //是否为教学班作业
 }
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.IsGroupWork))
 {
objRow[concc_WorkEduClsRela.IsGroupWork] = objcc_WorkEduClsRelaEN.IsGroupWork; //是否为小组作业
 }
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.CourseStudentGroupId))
 {
objRow[concc_WorkEduClsRela.CourseStudentGroupId] = objcc_WorkEduClsRelaEN.CourseStudentGroupId; //学生分组表流水号
 }
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.WorkTypeId))
 {
objRow[concc_WorkEduClsRela.WorkTypeId] = objcc_WorkEduClsRelaEN.WorkTypeId; //作业类型Id
 }
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.UpdDate))
 {
objRow[concc_WorkEduClsRela.UpdDate] = objcc_WorkEduClsRelaEN.UpdDate; //修改日期
 }
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.UpdUserId))
 {
objRow[concc_WorkEduClsRela.UpdUserId] = objcc_WorkEduClsRelaEN.UpdUserId; //修改用户Id
 }
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.Memo))
 {
objRow[concc_WorkEduClsRela.Memo] = objcc_WorkEduClsRelaEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clscc_WorkEduClsRelaEN._CurrTabName);
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
 /// <param name = "objcc_WorkEduClsRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clscc_WorkEduClsRelaEN objcc_WorkEduClsRelaEN)
{
 objcc_WorkEduClsRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_WorkEduClsRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_WorkEduClsRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkEduClsRelaDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update cc_WorkEduClsRela Set ");
 
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.QuestionId))
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_WorkEduClsRelaEN.QuestionId, concc_WorkEduClsRela.QuestionId); //题目Id
 }
 
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.IdCurrEduCls))
 {
 if (objcc_WorkEduClsRelaEN.IdCurrEduCls  ==  "")
 {
 objcc_WorkEduClsRelaEN.IdCurrEduCls = null;
 }
 if (objcc_WorkEduClsRelaEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objcc_WorkEduClsRelaEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, concc_WorkEduClsRela.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkEduClsRela.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.Scores))
 {
 if (objcc_WorkEduClsRelaEN.Scores !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_WorkEduClsRelaEN.Scores, concc_WorkEduClsRela.Scores); //分值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkEduClsRela.Scores); //分值
 }
 }
 
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.TeacherId))
 {
 if (objcc_WorkEduClsRelaEN.TeacherId !=  null)
 {
 var strTeacherId = objcc_WorkEduClsRelaEN.TeacherId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeacherId, concc_WorkEduClsRela.TeacherId); //教师工号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkEduClsRela.TeacherId); //教师工号
 }
 }
 
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.IsPublish))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_WorkEduClsRelaEN.IsPublish == true?"1":"0", concc_WorkEduClsRela.IsPublish); //是否发布
 }
 
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.PubDate))
 {
 if (objcc_WorkEduClsRelaEN.PubDate !=  null)
 {
 var strPubDate = objcc_WorkEduClsRelaEN.PubDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPubDate, concc_WorkEduClsRela.PubDate); //发布日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkEduClsRela.PubDate); //发布日期
 }
 }
 
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.publisher))
 {
 if (objcc_WorkEduClsRelaEN.publisher !=  null)
 {
 var strpublisher = objcc_WorkEduClsRelaEN.publisher.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strpublisher, concc_WorkEduClsRela.publisher); //发布者Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkEduClsRela.publisher); //发布者Id
 }
 }
 
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.SpecifyCompletionDate))
 {
 if (objcc_WorkEduClsRelaEN.SpecifyCompletionDate !=  null)
 {
 var strSpecifyCompletionDate = objcc_WorkEduClsRelaEN.SpecifyCompletionDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSpecifyCompletionDate, concc_WorkEduClsRela.SpecifyCompletionDate); //指定完成日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkEduClsRela.SpecifyCompletionDate); //指定完成日期
 }
 }
 
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.IsCurrEduCls))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_WorkEduClsRelaEN.IsCurrEduCls == true?"1":"0", concc_WorkEduClsRela.IsCurrEduCls); //是否为教学班作业
 }
 
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.IsGroupWork))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_WorkEduClsRelaEN.IsGroupWork == true?"1":"0", concc_WorkEduClsRela.IsGroupWork); //是否为小组作业
 }
 
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.CourseStudentGroupId))
 {
 if (objcc_WorkEduClsRelaEN.CourseStudentGroupId !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_WorkEduClsRelaEN.CourseStudentGroupId, concc_WorkEduClsRela.CourseStudentGroupId); //学生分组表流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkEduClsRela.CourseStudentGroupId); //学生分组表流水号
 }
 }
 
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.WorkTypeId))
 {
 if (objcc_WorkEduClsRelaEN.WorkTypeId !=  null)
 {
 var strWorkTypeId = objcc_WorkEduClsRelaEN.WorkTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWorkTypeId, concc_WorkEduClsRela.WorkTypeId); //作业类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkEduClsRela.WorkTypeId); //作业类型Id
 }
 }
 
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.UpdDate))
 {
 if (objcc_WorkEduClsRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objcc_WorkEduClsRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, concc_WorkEduClsRela.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkEduClsRela.UpdDate); //修改日期
 }
 }
 
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.UpdUserId))
 {
 if (objcc_WorkEduClsRelaEN.UpdUserId !=  null)
 {
 var strUpdUserId = objcc_WorkEduClsRelaEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, concc_WorkEduClsRela.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkEduClsRela.UpdUserId); //修改用户Id
 }
 }
 
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.Memo))
 {
 if (objcc_WorkEduClsRelaEN.Memo !=  null)
 {
 var strMemo = objcc_WorkEduClsRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, concc_WorkEduClsRela.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkEduClsRela.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdWorkEduClsRela = {0}", objcc_WorkEduClsRelaEN.IdWorkEduClsRela); 
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
 /// <param name = "objcc_WorkEduClsRelaEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clscc_WorkEduClsRelaEN objcc_WorkEduClsRelaEN, string strCondition)
{
 objcc_WorkEduClsRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_WorkEduClsRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_WorkEduClsRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkEduClsRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update cc_WorkEduClsRela Set ");
 
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.QuestionId))
 {
 sbSQL.AppendFormat(" QuestionId = {0},", objcc_WorkEduClsRelaEN.QuestionId); //题目Id
 }
 
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.IdCurrEduCls))
 {
 if (objcc_WorkEduClsRelaEN.IdCurrEduCls  ==  "")
 {
 objcc_WorkEduClsRelaEN.IdCurrEduCls = null;
 }
 if (objcc_WorkEduClsRelaEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objcc_WorkEduClsRelaEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.Scores))
 {
 if (objcc_WorkEduClsRelaEN.Scores !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_WorkEduClsRelaEN.Scores, concc_WorkEduClsRela.Scores); //分值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkEduClsRela.Scores); //分值
 }
 }
 
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.TeacherId))
 {
 if (objcc_WorkEduClsRelaEN.TeacherId !=  null)
 {
 var strTeacherId = objcc_WorkEduClsRelaEN.TeacherId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeacherId = '{0}',", strTeacherId); //教师工号
 }
 else
 {
 sbSQL.Append(" TeacherId = null,"); //教师工号
 }
 }
 
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.IsPublish))
 {
 sbSQL.AppendFormat(" IsPublish = '{0}',", objcc_WorkEduClsRelaEN.IsPublish == true?"1":"0"); //是否发布
 }
 
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.PubDate))
 {
 if (objcc_WorkEduClsRelaEN.PubDate !=  null)
 {
 var strPubDate = objcc_WorkEduClsRelaEN.PubDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PubDate = '{0}',", strPubDate); //发布日期
 }
 else
 {
 sbSQL.Append(" PubDate = null,"); //发布日期
 }
 }
 
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.publisher))
 {
 if (objcc_WorkEduClsRelaEN.publisher !=  null)
 {
 var strpublisher = objcc_WorkEduClsRelaEN.publisher.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" publisher = '{0}',", strpublisher); //发布者Id
 }
 else
 {
 sbSQL.Append(" publisher = null,"); //发布者Id
 }
 }
 
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.SpecifyCompletionDate))
 {
 if (objcc_WorkEduClsRelaEN.SpecifyCompletionDate !=  null)
 {
 var strSpecifyCompletionDate = objcc_WorkEduClsRelaEN.SpecifyCompletionDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SpecifyCompletionDate = '{0}',", strSpecifyCompletionDate); //指定完成日期
 }
 else
 {
 sbSQL.Append(" SpecifyCompletionDate = null,"); //指定完成日期
 }
 }
 
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.IsCurrEduCls))
 {
 sbSQL.AppendFormat(" IsCurrEduCls = '{0}',", objcc_WorkEduClsRelaEN.IsCurrEduCls == true?"1":"0"); //是否为教学班作业
 }
 
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.IsGroupWork))
 {
 sbSQL.AppendFormat(" IsGroupWork = '{0}',", objcc_WorkEduClsRelaEN.IsGroupWork == true?"1":"0"); //是否为小组作业
 }
 
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.CourseStudentGroupId))
 {
 if (objcc_WorkEduClsRelaEN.CourseStudentGroupId !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_WorkEduClsRelaEN.CourseStudentGroupId, concc_WorkEduClsRela.CourseStudentGroupId); //学生分组表流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkEduClsRela.CourseStudentGroupId); //学生分组表流水号
 }
 }
 
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.WorkTypeId))
 {
 if (objcc_WorkEduClsRelaEN.WorkTypeId !=  null)
 {
 var strWorkTypeId = objcc_WorkEduClsRelaEN.WorkTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WorkTypeId = '{0}',", strWorkTypeId); //作业类型Id
 }
 else
 {
 sbSQL.Append(" WorkTypeId = null,"); //作业类型Id
 }
 }
 
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.UpdDate))
 {
 if (objcc_WorkEduClsRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objcc_WorkEduClsRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.UpdUserId))
 {
 if (objcc_WorkEduClsRelaEN.UpdUserId !=  null)
 {
 var strUpdUserId = objcc_WorkEduClsRelaEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.Memo))
 {
 if (objcc_WorkEduClsRelaEN.Memo !=  null)
 {
 var strMemo = objcc_WorkEduClsRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objcc_WorkEduClsRelaEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clscc_WorkEduClsRelaEN objcc_WorkEduClsRelaEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objcc_WorkEduClsRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_WorkEduClsRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_WorkEduClsRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkEduClsRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update cc_WorkEduClsRela Set ");
 
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.QuestionId))
 {
 sbSQL.AppendFormat(" QuestionId = {0},", objcc_WorkEduClsRelaEN.QuestionId); //题目Id
 }
 
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.IdCurrEduCls))
 {
 if (objcc_WorkEduClsRelaEN.IdCurrEduCls  ==  "")
 {
 objcc_WorkEduClsRelaEN.IdCurrEduCls = null;
 }
 if (objcc_WorkEduClsRelaEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objcc_WorkEduClsRelaEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.Scores))
 {
 if (objcc_WorkEduClsRelaEN.Scores !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_WorkEduClsRelaEN.Scores, concc_WorkEduClsRela.Scores); //分值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkEduClsRela.Scores); //分值
 }
 }
 
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.TeacherId))
 {
 if (objcc_WorkEduClsRelaEN.TeacherId !=  null)
 {
 var strTeacherId = objcc_WorkEduClsRelaEN.TeacherId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeacherId = '{0}',", strTeacherId); //教师工号
 }
 else
 {
 sbSQL.Append(" TeacherId = null,"); //教师工号
 }
 }
 
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.IsPublish))
 {
 sbSQL.AppendFormat(" IsPublish = '{0}',", objcc_WorkEduClsRelaEN.IsPublish == true?"1":"0"); //是否发布
 }
 
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.PubDate))
 {
 if (objcc_WorkEduClsRelaEN.PubDate !=  null)
 {
 var strPubDate = objcc_WorkEduClsRelaEN.PubDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PubDate = '{0}',", strPubDate); //发布日期
 }
 else
 {
 sbSQL.Append(" PubDate = null,"); //发布日期
 }
 }
 
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.publisher))
 {
 if (objcc_WorkEduClsRelaEN.publisher !=  null)
 {
 var strpublisher = objcc_WorkEduClsRelaEN.publisher.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" publisher = '{0}',", strpublisher); //发布者Id
 }
 else
 {
 sbSQL.Append(" publisher = null,"); //发布者Id
 }
 }
 
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.SpecifyCompletionDate))
 {
 if (objcc_WorkEduClsRelaEN.SpecifyCompletionDate !=  null)
 {
 var strSpecifyCompletionDate = objcc_WorkEduClsRelaEN.SpecifyCompletionDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SpecifyCompletionDate = '{0}',", strSpecifyCompletionDate); //指定完成日期
 }
 else
 {
 sbSQL.Append(" SpecifyCompletionDate = null,"); //指定完成日期
 }
 }
 
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.IsCurrEduCls))
 {
 sbSQL.AppendFormat(" IsCurrEduCls = '{0}',", objcc_WorkEduClsRelaEN.IsCurrEduCls == true?"1":"0"); //是否为教学班作业
 }
 
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.IsGroupWork))
 {
 sbSQL.AppendFormat(" IsGroupWork = '{0}',", objcc_WorkEduClsRelaEN.IsGroupWork == true?"1":"0"); //是否为小组作业
 }
 
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.CourseStudentGroupId))
 {
 if (objcc_WorkEduClsRelaEN.CourseStudentGroupId !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_WorkEduClsRelaEN.CourseStudentGroupId, concc_WorkEduClsRela.CourseStudentGroupId); //学生分组表流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkEduClsRela.CourseStudentGroupId); //学生分组表流水号
 }
 }
 
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.WorkTypeId))
 {
 if (objcc_WorkEduClsRelaEN.WorkTypeId !=  null)
 {
 var strWorkTypeId = objcc_WorkEduClsRelaEN.WorkTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WorkTypeId = '{0}',", strWorkTypeId); //作业类型Id
 }
 else
 {
 sbSQL.Append(" WorkTypeId = null,"); //作业类型Id
 }
 }
 
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.UpdDate))
 {
 if (objcc_WorkEduClsRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objcc_WorkEduClsRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.UpdUserId))
 {
 if (objcc_WorkEduClsRelaEN.UpdUserId !=  null)
 {
 var strUpdUserId = objcc_WorkEduClsRelaEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.Memo))
 {
 if (objcc_WorkEduClsRelaEN.Memo !=  null)
 {
 var strMemo = objcc_WorkEduClsRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objcc_WorkEduClsRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clscc_WorkEduClsRelaEN objcc_WorkEduClsRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objcc_WorkEduClsRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_WorkEduClsRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_WorkEduClsRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkEduClsRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update cc_WorkEduClsRela Set ");
 
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.QuestionId))
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_WorkEduClsRelaEN.QuestionId, concc_WorkEduClsRela.QuestionId); //题目Id
 }
 
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.IdCurrEduCls))
 {
 if (objcc_WorkEduClsRelaEN.IdCurrEduCls  ==  "")
 {
 objcc_WorkEduClsRelaEN.IdCurrEduCls = null;
 }
 if (objcc_WorkEduClsRelaEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objcc_WorkEduClsRelaEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, concc_WorkEduClsRela.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkEduClsRela.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.Scores))
 {
 if (objcc_WorkEduClsRelaEN.Scores !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_WorkEduClsRelaEN.Scores, concc_WorkEduClsRela.Scores); //分值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkEduClsRela.Scores); //分值
 }
 }
 
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.TeacherId))
 {
 if (objcc_WorkEduClsRelaEN.TeacherId !=  null)
 {
 var strTeacherId = objcc_WorkEduClsRelaEN.TeacherId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeacherId, concc_WorkEduClsRela.TeacherId); //教师工号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkEduClsRela.TeacherId); //教师工号
 }
 }
 
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.IsPublish))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_WorkEduClsRelaEN.IsPublish == true?"1":"0", concc_WorkEduClsRela.IsPublish); //是否发布
 }
 
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.PubDate))
 {
 if (objcc_WorkEduClsRelaEN.PubDate !=  null)
 {
 var strPubDate = objcc_WorkEduClsRelaEN.PubDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPubDate, concc_WorkEduClsRela.PubDate); //发布日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkEduClsRela.PubDate); //发布日期
 }
 }
 
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.publisher))
 {
 if (objcc_WorkEduClsRelaEN.publisher !=  null)
 {
 var strpublisher = objcc_WorkEduClsRelaEN.publisher.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strpublisher, concc_WorkEduClsRela.publisher); //发布者Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkEduClsRela.publisher); //发布者Id
 }
 }
 
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.SpecifyCompletionDate))
 {
 if (objcc_WorkEduClsRelaEN.SpecifyCompletionDate !=  null)
 {
 var strSpecifyCompletionDate = objcc_WorkEduClsRelaEN.SpecifyCompletionDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSpecifyCompletionDate, concc_WorkEduClsRela.SpecifyCompletionDate); //指定完成日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkEduClsRela.SpecifyCompletionDate); //指定完成日期
 }
 }
 
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.IsCurrEduCls))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_WorkEduClsRelaEN.IsCurrEduCls == true?"1":"0", concc_WorkEduClsRela.IsCurrEduCls); //是否为教学班作业
 }
 
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.IsGroupWork))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_WorkEduClsRelaEN.IsGroupWork == true?"1":"0", concc_WorkEduClsRela.IsGroupWork); //是否为小组作业
 }
 
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.CourseStudentGroupId))
 {
 if (objcc_WorkEduClsRelaEN.CourseStudentGroupId !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_WorkEduClsRelaEN.CourseStudentGroupId, concc_WorkEduClsRela.CourseStudentGroupId); //学生分组表流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkEduClsRela.CourseStudentGroupId); //学生分组表流水号
 }
 }
 
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.WorkTypeId))
 {
 if (objcc_WorkEduClsRelaEN.WorkTypeId !=  null)
 {
 var strWorkTypeId = objcc_WorkEduClsRelaEN.WorkTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWorkTypeId, concc_WorkEduClsRela.WorkTypeId); //作业类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkEduClsRela.WorkTypeId); //作业类型Id
 }
 }
 
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.UpdDate))
 {
 if (objcc_WorkEduClsRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objcc_WorkEduClsRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, concc_WorkEduClsRela.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkEduClsRela.UpdDate); //修改日期
 }
 }
 
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.UpdUserId))
 {
 if (objcc_WorkEduClsRelaEN.UpdUserId !=  null)
 {
 var strUpdUserId = objcc_WorkEduClsRelaEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, concc_WorkEduClsRela.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkEduClsRela.UpdUserId); //修改用户Id
 }
 }
 
 if (objcc_WorkEduClsRelaEN.IsUpdated(concc_WorkEduClsRela.Memo))
 {
 if (objcc_WorkEduClsRelaEN.Memo !=  null)
 {
 var strMemo = objcc_WorkEduClsRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, concc_WorkEduClsRela.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkEduClsRela.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdWorkEduClsRela = {0}", objcc_WorkEduClsRelaEN.IdWorkEduClsRela); 
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
 /// <param name = "lngIdWorkEduClsRela">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngIdWorkEduClsRela) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkEduClsRelaDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngIdWorkEduClsRela,
};
 objSQL.ExecSP("cc_WorkEduClsRela_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngIdWorkEduClsRela">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngIdWorkEduClsRela, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkEduClsRelaDA.GetSpecSQLObj();
//删除cc_WorkEduClsRela本表中与当前对象有关的记录
strSQL = strSQL + "Delete from cc_WorkEduClsRela where IdWorkEduClsRela = " + ""+ lngIdWorkEduClsRela+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delcc_WorkEduClsRela(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkEduClsRelaDA.GetSpecSQLObj();
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
//删除cc_WorkEduClsRela本表中与当前对象有关的记录
strSQL = strSQL + "Delete from cc_WorkEduClsRela where IdWorkEduClsRela in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngIdWorkEduClsRela">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngIdWorkEduClsRela) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkEduClsRelaDA.GetSpecSQLObj();
//删除cc_WorkEduClsRela本表中与当前对象有关的记录
strSQL = strSQL + "Delete from cc_WorkEduClsRela where IdWorkEduClsRela = " + ""+ lngIdWorkEduClsRela+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delcc_WorkEduClsRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clscc_WorkEduClsRelaDA: Delcc_WorkEduClsRela)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkEduClsRelaDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from cc_WorkEduClsRela where " + strCondition ;
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
public bool Delcc_WorkEduClsRelaWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clscc_WorkEduClsRelaDA: Delcc_WorkEduClsRelaWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkEduClsRelaDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from cc_WorkEduClsRela where " + strCondition ;
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
 /// <param name = "objcc_WorkEduClsRelaENS">源对象</param>
 /// <param name = "objcc_WorkEduClsRelaENT">目标对象</param>
public void CopyTo(clscc_WorkEduClsRelaEN objcc_WorkEduClsRelaENS, clscc_WorkEduClsRelaEN objcc_WorkEduClsRelaENT)
{
objcc_WorkEduClsRelaENT.IdWorkEduClsRela = objcc_WorkEduClsRelaENS.IdWorkEduClsRela; //作业教学班关系流水号
objcc_WorkEduClsRelaENT.QuestionId = objcc_WorkEduClsRelaENS.QuestionId; //题目Id
objcc_WorkEduClsRelaENT.IdCurrEduCls = objcc_WorkEduClsRelaENS.IdCurrEduCls; //教学班流水号
objcc_WorkEduClsRelaENT.Scores = objcc_WorkEduClsRelaENS.Scores; //分值
objcc_WorkEduClsRelaENT.TeacherId = objcc_WorkEduClsRelaENS.TeacherId; //教师工号
objcc_WorkEduClsRelaENT.IsPublish = objcc_WorkEduClsRelaENS.IsPublish; //是否发布
objcc_WorkEduClsRelaENT.PubDate = objcc_WorkEduClsRelaENS.PubDate; //发布日期
objcc_WorkEduClsRelaENT.publisher = objcc_WorkEduClsRelaENS.publisher; //发布者Id
objcc_WorkEduClsRelaENT.SpecifyCompletionDate = objcc_WorkEduClsRelaENS.SpecifyCompletionDate; //指定完成日期
objcc_WorkEduClsRelaENT.IsCurrEduCls = objcc_WorkEduClsRelaENS.IsCurrEduCls; //是否为教学班作业
objcc_WorkEduClsRelaENT.IsGroupWork = objcc_WorkEduClsRelaENS.IsGroupWork; //是否为小组作业
objcc_WorkEduClsRelaENT.CourseStudentGroupId = objcc_WorkEduClsRelaENS.CourseStudentGroupId; //学生分组表流水号
objcc_WorkEduClsRelaENT.WorkTypeId = objcc_WorkEduClsRelaENS.WorkTypeId; //作业类型Id
objcc_WorkEduClsRelaENT.UpdDate = objcc_WorkEduClsRelaENS.UpdDate; //修改日期
objcc_WorkEduClsRelaENT.UpdUserId = objcc_WorkEduClsRelaENS.UpdUserId; //修改用户Id
objcc_WorkEduClsRelaENT.Memo = objcc_WorkEduClsRelaENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clscc_WorkEduClsRelaEN objcc_WorkEduClsRelaEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objcc_WorkEduClsRelaEN.QuestionId, concc_WorkEduClsRela.QuestionId);
clsCheckSql.CheckFieldNotNull(objcc_WorkEduClsRelaEN.IdCurrEduCls, concc_WorkEduClsRela.IdCurrEduCls);
clsCheckSql.CheckFieldNotNull(objcc_WorkEduClsRelaEN.TeacherId, concc_WorkEduClsRela.TeacherId);
clsCheckSql.CheckFieldNotNull(objcc_WorkEduClsRelaEN.WorkTypeId, concc_WorkEduClsRela.WorkTypeId);
clsCheckSql.CheckFieldNotNull(objcc_WorkEduClsRelaEN.UpdDate, concc_WorkEduClsRela.UpdDate);
//检查字段长度
clsCheckSql.CheckFieldLen(objcc_WorkEduClsRelaEN.IdCurrEduCls, 8, concc_WorkEduClsRela.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objcc_WorkEduClsRelaEN.TeacherId, 12, concc_WorkEduClsRela.TeacherId);
clsCheckSql.CheckFieldLen(objcc_WorkEduClsRelaEN.PubDate, 14, concc_WorkEduClsRela.PubDate);
clsCheckSql.CheckFieldLen(objcc_WorkEduClsRelaEN.publisher, 20, concc_WorkEduClsRela.publisher);
clsCheckSql.CheckFieldLen(objcc_WorkEduClsRelaEN.SpecifyCompletionDate, 14, concc_WorkEduClsRela.SpecifyCompletionDate);
clsCheckSql.CheckFieldLen(objcc_WorkEduClsRelaEN.WorkTypeId, 2, concc_WorkEduClsRela.WorkTypeId);
clsCheckSql.CheckFieldLen(objcc_WorkEduClsRelaEN.UpdDate, 20, concc_WorkEduClsRela.UpdDate);
clsCheckSql.CheckFieldLen(objcc_WorkEduClsRelaEN.UpdUserId, 20, concc_WorkEduClsRela.UpdUserId);
clsCheckSql.CheckFieldLen(objcc_WorkEduClsRelaEN.Memo, 1000, concc_WorkEduClsRela.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objcc_WorkEduClsRelaEN.IdCurrEduCls, 8, concc_WorkEduClsRela.IdCurrEduCls);
 objcc_WorkEduClsRelaEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clscc_WorkEduClsRelaEN objcc_WorkEduClsRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objcc_WorkEduClsRelaEN.IdCurrEduCls, 8, concc_WorkEduClsRela.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objcc_WorkEduClsRelaEN.TeacherId, 12, concc_WorkEduClsRela.TeacherId);
clsCheckSql.CheckFieldLen(objcc_WorkEduClsRelaEN.PubDate, 14, concc_WorkEduClsRela.PubDate);
clsCheckSql.CheckFieldLen(objcc_WorkEduClsRelaEN.publisher, 20, concc_WorkEduClsRela.publisher);
clsCheckSql.CheckFieldLen(objcc_WorkEduClsRelaEN.SpecifyCompletionDate, 14, concc_WorkEduClsRela.SpecifyCompletionDate);
clsCheckSql.CheckFieldLen(objcc_WorkEduClsRelaEN.WorkTypeId, 2, concc_WorkEduClsRela.WorkTypeId);
clsCheckSql.CheckFieldLen(objcc_WorkEduClsRelaEN.UpdDate, 20, concc_WorkEduClsRela.UpdDate);
clsCheckSql.CheckFieldLen(objcc_WorkEduClsRelaEN.UpdUserId, 20, concc_WorkEduClsRela.UpdUserId);
clsCheckSql.CheckFieldLen(objcc_WorkEduClsRelaEN.Memo, 1000, concc_WorkEduClsRela.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objcc_WorkEduClsRelaEN.IdCurrEduCls, 8, concc_WorkEduClsRela.IdCurrEduCls);
 objcc_WorkEduClsRelaEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clscc_WorkEduClsRelaEN objcc_WorkEduClsRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objcc_WorkEduClsRelaEN.IdCurrEduCls, 8, concc_WorkEduClsRela.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objcc_WorkEduClsRelaEN.TeacherId, 12, concc_WorkEduClsRela.TeacherId);
clsCheckSql.CheckFieldLen(objcc_WorkEduClsRelaEN.PubDate, 14, concc_WorkEduClsRela.PubDate);
clsCheckSql.CheckFieldLen(objcc_WorkEduClsRelaEN.publisher, 20, concc_WorkEduClsRela.publisher);
clsCheckSql.CheckFieldLen(objcc_WorkEduClsRelaEN.SpecifyCompletionDate, 14, concc_WorkEduClsRela.SpecifyCompletionDate);
clsCheckSql.CheckFieldLen(objcc_WorkEduClsRelaEN.WorkTypeId, 2, concc_WorkEduClsRela.WorkTypeId);
clsCheckSql.CheckFieldLen(objcc_WorkEduClsRelaEN.UpdDate, 20, concc_WorkEduClsRela.UpdDate);
clsCheckSql.CheckFieldLen(objcc_WorkEduClsRelaEN.UpdUserId, 20, concc_WorkEduClsRela.UpdUserId);
clsCheckSql.CheckFieldLen(objcc_WorkEduClsRelaEN.Memo, 1000, concc_WorkEduClsRela.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objcc_WorkEduClsRelaEN.IdCurrEduCls, concc_WorkEduClsRela.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objcc_WorkEduClsRelaEN.TeacherId, concc_WorkEduClsRela.TeacherId);
clsCheckSql.CheckSqlInjection4Field(objcc_WorkEduClsRelaEN.PubDate, concc_WorkEduClsRela.PubDate);
clsCheckSql.CheckSqlInjection4Field(objcc_WorkEduClsRelaEN.publisher, concc_WorkEduClsRela.publisher);
clsCheckSql.CheckSqlInjection4Field(objcc_WorkEduClsRelaEN.SpecifyCompletionDate, concc_WorkEduClsRela.SpecifyCompletionDate);
clsCheckSql.CheckSqlInjection4Field(objcc_WorkEduClsRelaEN.WorkTypeId, concc_WorkEduClsRela.WorkTypeId);
clsCheckSql.CheckSqlInjection4Field(objcc_WorkEduClsRelaEN.UpdDate, concc_WorkEduClsRela.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objcc_WorkEduClsRelaEN.UpdUserId, concc_WorkEduClsRela.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objcc_WorkEduClsRelaEN.Memo, concc_WorkEduClsRela.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objcc_WorkEduClsRelaEN.IdCurrEduCls, 8, concc_WorkEduClsRela.IdCurrEduCls);
 objcc_WorkEduClsRelaEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--cc_WorkEduClsRela(作业教学班关系),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objcc_WorkEduClsRelaEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clscc_WorkEduClsRelaEN objcc_WorkEduClsRelaEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and QuestionId = '{0}'", objcc_WorkEduClsRelaEN.QuestionId);
 sbCondition.AppendFormat(" and IdCurrEduCls = '{0}'", objcc_WorkEduClsRelaEN.IdCurrEduCls);
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
 objSQL = clscc_WorkEduClsRelaDA.GetSpecSQLObj();
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
 objSQL = clscc_WorkEduClsRelaDA.GetSpecSQLObj();
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
 objSQL = clscc_WorkEduClsRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clscc_WorkEduClsRelaEN._CurrTabName);
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
 objSQL = clscc_WorkEduClsRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clscc_WorkEduClsRelaEN._CurrTabName, strCondition);
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
 objSQL = clscc_WorkEduClsRelaDA.GetSpecSQLObj();
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
 objSQL = clscc_WorkEduClsRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}