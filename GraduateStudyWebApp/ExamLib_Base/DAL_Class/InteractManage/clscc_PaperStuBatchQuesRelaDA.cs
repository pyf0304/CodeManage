
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_PaperStuBatchQuesRelaDA
 表名:cc_PaperStuBatchQuesRela(01120240)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:00:55
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
 /// 学生批次题目关系(cc_PaperStuBatchQuesRela)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clscc_PaperStuBatchQuesRelaDA : clsCommBase4DA
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
 return clscc_PaperStuBatchQuesRelaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clscc_PaperStuBatchQuesRelaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clscc_PaperStuBatchQuesRelaEN._ConnectString);
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
 if (string.IsNullOrEmpty(clscc_PaperStuBatchQuesRelaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clscc_PaperStuBatchQuesRelaEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clscc_PaperStuBatchQuesRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PaperStuBatchQuesRelaDA.GetSpecSQLObj();
strSQL = "Select * from cc_PaperStuBatchQuesRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_cc_PaperStuBatchQuesRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clscc_PaperStuBatchQuesRelaDA: GetDataTable_cc_PaperStuBatchQuesRela)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PaperStuBatchQuesRelaDA.GetSpecSQLObj();
strSQL = "Select * from cc_PaperStuBatchQuesRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clscc_PaperStuBatchQuesRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PaperStuBatchQuesRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clscc_PaperStuBatchQuesRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PaperStuBatchQuesRelaDA.GetSpecSQLObj();
strSQL = "Select * from cc_PaperStuBatchQuesRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clscc_PaperStuBatchQuesRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PaperStuBatchQuesRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clscc_PaperStuBatchQuesRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PaperStuBatchQuesRelaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from cc_PaperStuBatchQuesRela where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from cc_PaperStuBatchQuesRela where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clscc_PaperStuBatchQuesRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PaperStuBatchQuesRelaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from cc_PaperStuBatchQuesRela where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clscc_PaperStuBatchQuesRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PaperStuBatchQuesRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} cc_PaperStuBatchQuesRela.* from cc_PaperStuBatchQuesRela Left Join {1} on {2} where {3} and cc_PaperStuBatchQuesRela.IdPaperStuBatchQuesRela not in (Select top {5} cc_PaperStuBatchQuesRela.IdPaperStuBatchQuesRela from cc_PaperStuBatchQuesRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from cc_PaperStuBatchQuesRela where {1} and IdPaperStuBatchQuesRela not in (Select top {2} IdPaperStuBatchQuesRela from cc_PaperStuBatchQuesRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from cc_PaperStuBatchQuesRela where {1} and IdPaperStuBatchQuesRela not in (Select top {3} IdPaperStuBatchQuesRela from cc_PaperStuBatchQuesRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clscc_PaperStuBatchQuesRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PaperStuBatchQuesRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} cc_PaperStuBatchQuesRela.* from cc_PaperStuBatchQuesRela Left Join {1} on {2} where {3} and cc_PaperStuBatchQuesRela.IdPaperStuBatchQuesRela not in (Select top {5} cc_PaperStuBatchQuesRela.IdPaperStuBatchQuesRela from cc_PaperStuBatchQuesRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from cc_PaperStuBatchQuesRela where {1} and IdPaperStuBatchQuesRela not in (Select top {2} IdPaperStuBatchQuesRela from cc_PaperStuBatchQuesRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from cc_PaperStuBatchQuesRela where {1} and IdPaperStuBatchQuesRela not in (Select top {3} IdPaperStuBatchQuesRela from cc_PaperStuBatchQuesRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clscc_PaperStuBatchQuesRelaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clscc_PaperStuBatchQuesRelaDA:GetObjLst)", objException.Message));
}
List<clscc_PaperStuBatchQuesRelaEN> arrObjLst = new List<clscc_PaperStuBatchQuesRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PaperStuBatchQuesRelaDA.GetSpecSQLObj();
strSQL = "Select * from cc_PaperStuBatchQuesRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN = new clscc_PaperStuBatchQuesRelaEN();
try
{
objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatchQuesRela = TransNullToInt(objRow[concc_PaperStuBatchQuesRela.IdPaperStuBatchQuesRela].ToString().Trim()); //学生批次题目关系流水号
objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatch = objRow[concc_PaperStuBatchQuesRela.IdPaperStuBatch].ToString().Trim(); //学生试卷批次流水号
objcc_PaperStuBatchQuesRelaEN.QuestionId = objRow[concc_PaperStuBatchQuesRela.QuestionId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[concc_PaperStuBatchQuesRela.QuestionId].ToString().Trim()); //题目Id
objcc_PaperStuBatchQuesRelaEN.QuestionIndex4Batch = objRow[concc_PaperStuBatchQuesRela.QuestionIndex4Batch] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_PaperStuBatchQuesRela.QuestionIndex4Batch].ToString().Trim()); //题序号4批次
objcc_PaperStuBatchQuesRelaEN.Scores = objRow[concc_PaperStuBatchQuesRela.Scores] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_PaperStuBatchQuesRela.Scores].ToString().Trim()); //分值
objcc_PaperStuBatchQuesRelaEN.Score = objRow[concc_PaperStuBatchQuesRela.Score] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_PaperStuBatchQuesRela.Score].ToString().Trim()); //得分
objcc_PaperStuBatchQuesRelaEN.StuAnswerText = objRow[concc_PaperStuBatchQuesRela.StuAnswerText] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.StuAnswerText].ToString().Trim(); //学生回答文本
objcc_PaperStuBatchQuesRelaEN.AnswerDate = objRow[concc_PaperStuBatchQuesRela.AnswerDate] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerDate].ToString().Trim(); //回答日期
objcc_PaperStuBatchQuesRelaEN.AnswerIP = objRow[concc_PaperStuBatchQuesRela.AnswerIP] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerIP].ToString().Trim(); //回答IP
objcc_PaperStuBatchQuesRelaEN.AnswerModeId = objRow[concc_PaperStuBatchQuesRela.AnswerModeId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerModeId].ToString().Trim(); //答案模式Id
objcc_PaperStuBatchQuesRelaEN.AnswerMultiOptions = objRow[concc_PaperStuBatchQuesRela.AnswerMultiOptions] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerMultiOptions].ToString().Trim(); //多选项答案
objcc_PaperStuBatchQuesRelaEN.AnswerOptionId = objRow[concc_PaperStuBatchQuesRela.AnswerOptionId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerOptionId].ToString().Trim(); //回答选项Id
objcc_PaperStuBatchQuesRelaEN.AnswerTime = objRow[concc_PaperStuBatchQuesRela.AnswerTime] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerTime].ToString().Trim(); //回答时间
objcc_PaperStuBatchQuesRelaEN.ApplySendBackDate = objRow[concc_PaperStuBatchQuesRela.ApplySendBackDate] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.ApplySendBackDate].ToString().Trim(); //申请退回日期
objcc_PaperStuBatchQuesRelaEN.Comment = objRow[concc_PaperStuBatchQuesRela.Comment] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.Comment].ToString().Trim(); //批注
objcc_PaperStuBatchQuesRelaEN.IsAccessKnowledge = TransNullToBool(objRow[concc_PaperStuBatchQuesRela.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objcc_PaperStuBatchQuesRelaEN.IsApplySendBack = TransNullToBool(objRow[concc_PaperStuBatchQuesRela.IsApplySendBack].ToString().Trim()); //是否申请退回
objcc_PaperStuBatchQuesRelaEN.IsInErrorQuestion = TransNullToBool(objRow[concc_PaperStuBatchQuesRela.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objcc_PaperStuBatchQuesRelaEN.IsLook = TransNullToBool(objRow[concc_PaperStuBatchQuesRela.IsLook].ToString().Trim()); //是否查看
objcc_PaperStuBatchQuesRelaEN.IsMarking = TransNullToBool(objRow[concc_PaperStuBatchQuesRela.IsMarking].ToString().Trim()); //是否批阅
objcc_PaperStuBatchQuesRelaEN.IsNotProcessTimeout = TransNullToBool(objRow[concc_PaperStuBatchQuesRela.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objcc_PaperStuBatchQuesRelaEN.IsPublish = TransNullToBool(objRow[concc_PaperStuBatchQuesRela.IsPublish].ToString().Trim()); //是否发布
objcc_PaperStuBatchQuesRelaEN.IsRight = TransNullToBool(objRow[concc_PaperStuBatchQuesRela.IsRight].ToString().Trim()); //是否正确
objcc_PaperStuBatchQuesRelaEN.IsSave = TransNullToBool(objRow[concc_PaperStuBatchQuesRela.IsSave].ToString().Trim()); //是否保存
objcc_PaperStuBatchQuesRelaEN.IsSendBack = TransNullToBool(objRow[concc_PaperStuBatchQuesRela.IsSendBack].ToString().Trim()); //是否退回
objcc_PaperStuBatchQuesRelaEN.IsSubmit = TransNullToBool(objRow[concc_PaperStuBatchQuesRela.IsSubmit].ToString().Trim()); //是否提交
objcc_PaperStuBatchQuesRelaEN.MarkDate = objRow[concc_PaperStuBatchQuesRela.MarkDate] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.MarkDate].ToString().Trim(); //打分日期
objcc_PaperStuBatchQuesRelaEN.MarkerId = objRow[concc_PaperStuBatchQuesRela.MarkerId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.MarkerId].ToString().Trim(); //打分者
objcc_PaperStuBatchQuesRelaEN.OperateTime = objRow[concc_PaperStuBatchQuesRela.OperateTime] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.OperateTime].ToString().Trim(); //操作时间
objcc_PaperStuBatchQuesRelaEN.RealFinishDate = objRow[concc_PaperStuBatchQuesRela.RealFinishDate] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.RealFinishDate].ToString().Trim(); //实际完成日期
objcc_PaperStuBatchQuesRelaEN.WorkTypeId = objRow[concc_PaperStuBatchQuesRela.WorkTypeId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.WorkTypeId].ToString().Trim(); //作业类型Id
objcc_PaperStuBatchQuesRelaEN.SchoolYear = objRow[concc_PaperStuBatchQuesRela.SchoolYear] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.SchoolYear].ToString().Trim(); //学年
objcc_PaperStuBatchQuesRelaEN.SchoolTerm = objRow[concc_PaperStuBatchQuesRela.SchoolTerm] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.SchoolTerm].ToString().Trim(); //学期
objcc_PaperStuBatchQuesRelaEN.ErrMsg = objRow[concc_PaperStuBatchQuesRela.ErrMsg] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.ErrMsg].ToString().Trim(); //错误信息
objcc_PaperStuBatchQuesRelaEN.CourseId = objRow[concc_PaperStuBatchQuesRela.CourseId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.CourseId].ToString().Trim(); //课程Id
objcc_PaperStuBatchQuesRelaEN.UpdDate = objRow[concc_PaperStuBatchQuesRela.UpdDate].ToString().Trim(); //修改日期
objcc_PaperStuBatchQuesRelaEN.UpdUserId = objRow[concc_PaperStuBatchQuesRela.UpdUserId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.UpdUserId].ToString().Trim(); //修改用户Id
objcc_PaperStuBatchQuesRelaEN.Memo = objRow[concc_PaperStuBatchQuesRela.Memo] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clscc_PaperStuBatchQuesRelaDA: GetObjLst)", objException.Message));
}
objcc_PaperStuBatchQuesRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objcc_PaperStuBatchQuesRelaEN);
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
public List<clscc_PaperStuBatchQuesRelaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clscc_PaperStuBatchQuesRelaDA:GetObjLstByTabName)", objException.Message));
}
List<clscc_PaperStuBatchQuesRelaEN> arrObjLst = new List<clscc_PaperStuBatchQuesRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PaperStuBatchQuesRelaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN = new clscc_PaperStuBatchQuesRelaEN();
try
{
objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatchQuesRela = TransNullToInt(objRow[concc_PaperStuBatchQuesRela.IdPaperStuBatchQuesRela].ToString().Trim()); //学生批次题目关系流水号
objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatch = objRow[concc_PaperStuBatchQuesRela.IdPaperStuBatch].ToString().Trim(); //学生试卷批次流水号
objcc_PaperStuBatchQuesRelaEN.QuestionId = objRow[concc_PaperStuBatchQuesRela.QuestionId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[concc_PaperStuBatchQuesRela.QuestionId].ToString().Trim()); //题目Id
objcc_PaperStuBatchQuesRelaEN.QuestionIndex4Batch = objRow[concc_PaperStuBatchQuesRela.QuestionIndex4Batch] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_PaperStuBatchQuesRela.QuestionIndex4Batch].ToString().Trim()); //题序号4批次
objcc_PaperStuBatchQuesRelaEN.Scores = objRow[concc_PaperStuBatchQuesRela.Scores] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_PaperStuBatchQuesRela.Scores].ToString().Trim()); //分值
objcc_PaperStuBatchQuesRelaEN.Score = objRow[concc_PaperStuBatchQuesRela.Score] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_PaperStuBatchQuesRela.Score].ToString().Trim()); //得分
objcc_PaperStuBatchQuesRelaEN.StuAnswerText = objRow[concc_PaperStuBatchQuesRela.StuAnswerText] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.StuAnswerText].ToString().Trim(); //学生回答文本
objcc_PaperStuBatchQuesRelaEN.AnswerDate = objRow[concc_PaperStuBatchQuesRela.AnswerDate] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerDate].ToString().Trim(); //回答日期
objcc_PaperStuBatchQuesRelaEN.AnswerIP = objRow[concc_PaperStuBatchQuesRela.AnswerIP] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerIP].ToString().Trim(); //回答IP
objcc_PaperStuBatchQuesRelaEN.AnswerModeId = objRow[concc_PaperStuBatchQuesRela.AnswerModeId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerModeId].ToString().Trim(); //答案模式Id
objcc_PaperStuBatchQuesRelaEN.AnswerMultiOptions = objRow[concc_PaperStuBatchQuesRela.AnswerMultiOptions] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerMultiOptions].ToString().Trim(); //多选项答案
objcc_PaperStuBatchQuesRelaEN.AnswerOptionId = objRow[concc_PaperStuBatchQuesRela.AnswerOptionId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerOptionId].ToString().Trim(); //回答选项Id
objcc_PaperStuBatchQuesRelaEN.AnswerTime = objRow[concc_PaperStuBatchQuesRela.AnswerTime] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerTime].ToString().Trim(); //回答时间
objcc_PaperStuBatchQuesRelaEN.ApplySendBackDate = objRow[concc_PaperStuBatchQuesRela.ApplySendBackDate] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.ApplySendBackDate].ToString().Trim(); //申请退回日期
objcc_PaperStuBatchQuesRelaEN.Comment = objRow[concc_PaperStuBatchQuesRela.Comment] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.Comment].ToString().Trim(); //批注
objcc_PaperStuBatchQuesRelaEN.IsAccessKnowledge = TransNullToBool(objRow[concc_PaperStuBatchQuesRela.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objcc_PaperStuBatchQuesRelaEN.IsApplySendBack = TransNullToBool(objRow[concc_PaperStuBatchQuesRela.IsApplySendBack].ToString().Trim()); //是否申请退回
objcc_PaperStuBatchQuesRelaEN.IsInErrorQuestion = TransNullToBool(objRow[concc_PaperStuBatchQuesRela.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objcc_PaperStuBatchQuesRelaEN.IsLook = TransNullToBool(objRow[concc_PaperStuBatchQuesRela.IsLook].ToString().Trim()); //是否查看
objcc_PaperStuBatchQuesRelaEN.IsMarking = TransNullToBool(objRow[concc_PaperStuBatchQuesRela.IsMarking].ToString().Trim()); //是否批阅
objcc_PaperStuBatchQuesRelaEN.IsNotProcessTimeout = TransNullToBool(objRow[concc_PaperStuBatchQuesRela.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objcc_PaperStuBatchQuesRelaEN.IsPublish = TransNullToBool(objRow[concc_PaperStuBatchQuesRela.IsPublish].ToString().Trim()); //是否发布
objcc_PaperStuBatchQuesRelaEN.IsRight = TransNullToBool(objRow[concc_PaperStuBatchQuesRela.IsRight].ToString().Trim()); //是否正确
objcc_PaperStuBatchQuesRelaEN.IsSave = TransNullToBool(objRow[concc_PaperStuBatchQuesRela.IsSave].ToString().Trim()); //是否保存
objcc_PaperStuBatchQuesRelaEN.IsSendBack = TransNullToBool(objRow[concc_PaperStuBatchQuesRela.IsSendBack].ToString().Trim()); //是否退回
objcc_PaperStuBatchQuesRelaEN.IsSubmit = TransNullToBool(objRow[concc_PaperStuBatchQuesRela.IsSubmit].ToString().Trim()); //是否提交
objcc_PaperStuBatchQuesRelaEN.MarkDate = objRow[concc_PaperStuBatchQuesRela.MarkDate] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.MarkDate].ToString().Trim(); //打分日期
objcc_PaperStuBatchQuesRelaEN.MarkerId = objRow[concc_PaperStuBatchQuesRela.MarkerId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.MarkerId].ToString().Trim(); //打分者
objcc_PaperStuBatchQuesRelaEN.OperateTime = objRow[concc_PaperStuBatchQuesRela.OperateTime] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.OperateTime].ToString().Trim(); //操作时间
objcc_PaperStuBatchQuesRelaEN.RealFinishDate = objRow[concc_PaperStuBatchQuesRela.RealFinishDate] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.RealFinishDate].ToString().Trim(); //实际完成日期
objcc_PaperStuBatchQuesRelaEN.WorkTypeId = objRow[concc_PaperStuBatchQuesRela.WorkTypeId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.WorkTypeId].ToString().Trim(); //作业类型Id
objcc_PaperStuBatchQuesRelaEN.SchoolYear = objRow[concc_PaperStuBatchQuesRela.SchoolYear] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.SchoolYear].ToString().Trim(); //学年
objcc_PaperStuBatchQuesRelaEN.SchoolTerm = objRow[concc_PaperStuBatchQuesRela.SchoolTerm] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.SchoolTerm].ToString().Trim(); //学期
objcc_PaperStuBatchQuesRelaEN.ErrMsg = objRow[concc_PaperStuBatchQuesRela.ErrMsg] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.ErrMsg].ToString().Trim(); //错误信息
objcc_PaperStuBatchQuesRelaEN.CourseId = objRow[concc_PaperStuBatchQuesRela.CourseId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.CourseId].ToString().Trim(); //课程Id
objcc_PaperStuBatchQuesRelaEN.UpdDate = objRow[concc_PaperStuBatchQuesRela.UpdDate].ToString().Trim(); //修改日期
objcc_PaperStuBatchQuesRelaEN.UpdUserId = objRow[concc_PaperStuBatchQuesRela.UpdUserId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.UpdUserId].ToString().Trim(); //修改用户Id
objcc_PaperStuBatchQuesRelaEN.Memo = objRow[concc_PaperStuBatchQuesRela.Memo] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clscc_PaperStuBatchQuesRelaDA: GetObjLst)", objException.Message));
}
objcc_PaperStuBatchQuesRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objcc_PaperStuBatchQuesRelaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getcc_PaperStuBatchQuesRela(ref clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PaperStuBatchQuesRelaDA.GetSpecSQLObj();
strSQL = "Select * from cc_PaperStuBatchQuesRela where IdPaperStuBatchQuesRela = " + ""+ objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatchQuesRela+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatchQuesRela = TransNullToInt(objDT.Rows[0][concc_PaperStuBatchQuesRela.IdPaperStuBatchQuesRela].ToString().Trim()); //学生批次题目关系流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatch = objDT.Rows[0][concc_PaperStuBatchQuesRela.IdPaperStuBatch].ToString().Trim(); //学生试卷批次流水号(字段类型:char,字段长度:10,是否可空:False)
 objcc_PaperStuBatchQuesRelaEN.QuestionId = TransNullToInt(objDT.Rows[0][concc_PaperStuBatchQuesRela.QuestionId].ToString().Trim()); //题目Id(字段类型:bigint,字段长度:8,是否可空:True)
 objcc_PaperStuBatchQuesRelaEN.QuestionIndex4Batch = TransNullToInt(objDT.Rows[0][concc_PaperStuBatchQuesRela.QuestionIndex4Batch].ToString().Trim()); //题序号4批次(字段类型:int,字段长度:4,是否可空:True)
 objcc_PaperStuBatchQuesRelaEN.Scores = TransNullToDouble(objDT.Rows[0][concc_PaperStuBatchQuesRela.Scores].ToString().Trim()); //分值(字段类型:decimal,字段长度:8,是否可空:True)
 objcc_PaperStuBatchQuesRelaEN.Score = TransNullToDouble(objDT.Rows[0][concc_PaperStuBatchQuesRela.Score].ToString().Trim()); //得分(字段类型:decimal,字段长度:6,是否可空:True)
 objcc_PaperStuBatchQuesRelaEN.StuAnswerText = objDT.Rows[0][concc_PaperStuBatchQuesRela.StuAnswerText].ToString().Trim(); //学生回答文本(字段类型:text,字段长度:2147483647,是否可空:True)
 objcc_PaperStuBatchQuesRelaEN.AnswerDate = objDT.Rows[0][concc_PaperStuBatchQuesRela.AnswerDate].ToString().Trim(); //回答日期(字段类型:varchar,字段长度:8,是否可空:True)
 objcc_PaperStuBatchQuesRelaEN.AnswerIP = objDT.Rows[0][concc_PaperStuBatchQuesRela.AnswerIP].ToString().Trim(); //回答IP(字段类型:varchar,字段长度:30,是否可空:True)
 objcc_PaperStuBatchQuesRelaEN.AnswerModeId = objDT.Rows[0][concc_PaperStuBatchQuesRela.AnswerModeId].ToString().Trim(); //答案模式Id(字段类型:char,字段长度:4,是否可空:True)
 objcc_PaperStuBatchQuesRelaEN.AnswerMultiOptions = objDT.Rows[0][concc_PaperStuBatchQuesRela.AnswerMultiOptions].ToString().Trim(); //多选项答案(字段类型:varchar,字段长度:300,是否可空:True)
 objcc_PaperStuBatchQuesRelaEN.AnswerOptionId = objDT.Rows[0][concc_PaperStuBatchQuesRela.AnswerOptionId].ToString().Trim(); //回答选项Id(字段类型:char,字段长度:8,是否可空:True)
 objcc_PaperStuBatchQuesRelaEN.AnswerTime = objDT.Rows[0][concc_PaperStuBatchQuesRela.AnswerTime].ToString().Trim(); //回答时间(字段类型:varchar,字段长度:10,是否可空:True)
 objcc_PaperStuBatchQuesRelaEN.ApplySendBackDate = objDT.Rows[0][concc_PaperStuBatchQuesRela.ApplySendBackDate].ToString().Trim(); //申请退回日期(字段类型:varchar,字段长度:14,是否可空:True)
 objcc_PaperStuBatchQuesRelaEN.Comment = objDT.Rows[0][concc_PaperStuBatchQuesRela.Comment].ToString().Trim(); //批注(字段类型:text,字段长度:2147483647,是否可空:True)
 objcc_PaperStuBatchQuesRelaEN.IsAccessKnowledge = TransNullToBool(objDT.Rows[0][concc_PaperStuBatchQuesRela.IsAccessKnowledge].ToString().Trim()); //是否处理知识点(字段类型:bit,字段长度:1,是否可空:True)
 objcc_PaperStuBatchQuesRelaEN.IsApplySendBack = TransNullToBool(objDT.Rows[0][concc_PaperStuBatchQuesRela.IsApplySendBack].ToString().Trim()); //是否申请退回(字段类型:bit,字段长度:1,是否可空:True)
 objcc_PaperStuBatchQuesRelaEN.IsInErrorQuestion = TransNullToBool(objDT.Rows[0][concc_PaperStuBatchQuesRela.IsInErrorQuestion].ToString().Trim()); //是否进入错题(字段类型:bit,字段长度:1,是否可空:True)
 objcc_PaperStuBatchQuesRelaEN.IsLook = TransNullToBool(objDT.Rows[0][concc_PaperStuBatchQuesRela.IsLook].ToString().Trim()); //是否查看(字段类型:bit,字段长度:1,是否可空:True)
 objcc_PaperStuBatchQuesRelaEN.IsMarking = TransNullToBool(objDT.Rows[0][concc_PaperStuBatchQuesRela.IsMarking].ToString().Trim()); //是否批阅(字段类型:bit,字段长度:1,是否可空:True)
 objcc_PaperStuBatchQuesRelaEN.IsNotProcessTimeout = TransNullToBool(objDT.Rows[0][concc_PaperStuBatchQuesRela.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时(字段类型:bit,字段长度:1,是否可空:True)
 objcc_PaperStuBatchQuesRelaEN.IsPublish = TransNullToBool(objDT.Rows[0][concc_PaperStuBatchQuesRela.IsPublish].ToString().Trim()); //是否发布(字段类型:bit,字段长度:1,是否可空:True)
 objcc_PaperStuBatchQuesRelaEN.IsRight = TransNullToBool(objDT.Rows[0][concc_PaperStuBatchQuesRela.IsRight].ToString().Trim()); //是否正确(字段类型:bit,字段长度:1,是否可空:True)
 objcc_PaperStuBatchQuesRelaEN.IsSave = TransNullToBool(objDT.Rows[0][concc_PaperStuBatchQuesRela.IsSave].ToString().Trim()); //是否保存(字段类型:bit,字段长度:1,是否可空:True)
 objcc_PaperStuBatchQuesRelaEN.IsSendBack = TransNullToBool(objDT.Rows[0][concc_PaperStuBatchQuesRela.IsSendBack].ToString().Trim()); //是否退回(字段类型:bit,字段长度:1,是否可空:True)
 objcc_PaperStuBatchQuesRelaEN.IsSubmit = TransNullToBool(objDT.Rows[0][concc_PaperStuBatchQuesRela.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objcc_PaperStuBatchQuesRelaEN.MarkDate = objDT.Rows[0][concc_PaperStuBatchQuesRela.MarkDate].ToString().Trim(); //打分日期(字段类型:varchar,字段长度:14,是否可空:True)
 objcc_PaperStuBatchQuesRelaEN.MarkerId = objDT.Rows[0][concc_PaperStuBatchQuesRela.MarkerId].ToString().Trim(); //打分者(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_PaperStuBatchQuesRelaEN.OperateTime = objDT.Rows[0][concc_PaperStuBatchQuesRela.OperateTime].ToString().Trim(); //操作时间(字段类型:varchar,字段长度:14,是否可空:True)
 objcc_PaperStuBatchQuesRelaEN.RealFinishDate = objDT.Rows[0][concc_PaperStuBatchQuesRela.RealFinishDate].ToString().Trim(); //实际完成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objcc_PaperStuBatchQuesRelaEN.WorkTypeId = objDT.Rows[0][concc_PaperStuBatchQuesRela.WorkTypeId].ToString().Trim(); //作业类型Id(字段类型:char,字段长度:2,是否可空:False)
 objcc_PaperStuBatchQuesRelaEN.SchoolYear = objDT.Rows[0][concc_PaperStuBatchQuesRela.SchoolYear].ToString().Trim(); //学年(字段类型:varchar,字段长度:10,是否可空:True)
 objcc_PaperStuBatchQuesRelaEN.SchoolTerm = objDT.Rows[0][concc_PaperStuBatchQuesRela.SchoolTerm].ToString().Trim(); //学期(字段类型:char,字段长度:1,是否可空:True)
 objcc_PaperStuBatchQuesRelaEN.ErrMsg = objDT.Rows[0][concc_PaperStuBatchQuesRela.ErrMsg].ToString().Trim(); //错误信息(字段类型:varchar,字段长度:200,是否可空:True)
 objcc_PaperStuBatchQuesRelaEN.CourseId = objDT.Rows[0][concc_PaperStuBatchQuesRela.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objcc_PaperStuBatchQuesRelaEN.UpdDate = objDT.Rows[0][concc_PaperStuBatchQuesRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_PaperStuBatchQuesRelaEN.UpdUserId = objDT.Rows[0][concc_PaperStuBatchQuesRela.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_PaperStuBatchQuesRelaEN.Memo = objDT.Rows[0][concc_PaperStuBatchQuesRela.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clscc_PaperStuBatchQuesRelaDA: Getcc_PaperStuBatchQuesRela)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdPaperStuBatchQuesRela">表关键字</param>
 /// <returns>表对象</returns>
public clscc_PaperStuBatchQuesRelaEN GetObjByIdPaperStuBatchQuesRela(long lngIdPaperStuBatchQuesRela)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PaperStuBatchQuesRelaDA.GetSpecSQLObj();
strSQL = "Select * from cc_PaperStuBatchQuesRela where IdPaperStuBatchQuesRela = " + ""+ lngIdPaperStuBatchQuesRela+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN = new clscc_PaperStuBatchQuesRelaEN();
try
{
 objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatchQuesRela = Int32.Parse(objRow[concc_PaperStuBatchQuesRela.IdPaperStuBatchQuesRela].ToString().Trim()); //学生批次题目关系流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatch = objRow[concc_PaperStuBatchQuesRela.IdPaperStuBatch].ToString().Trim(); //学生试卷批次流水号(字段类型:char,字段长度:10,是否可空:False)
 objcc_PaperStuBatchQuesRelaEN.QuestionId = objRow[concc_PaperStuBatchQuesRela.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela.QuestionId].ToString().Trim()); //题目Id(字段类型:bigint,字段长度:8,是否可空:True)
 objcc_PaperStuBatchQuesRelaEN.QuestionIndex4Batch = objRow[concc_PaperStuBatchQuesRela.QuestionIndex4Batch] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela.QuestionIndex4Batch].ToString().Trim()); //题序号4批次(字段类型:int,字段长度:4,是否可空:True)
 objcc_PaperStuBatchQuesRelaEN.Scores = objRow[concc_PaperStuBatchQuesRela.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_PaperStuBatchQuesRela.Scores].ToString().Trim()); //分值(字段类型:decimal,字段长度:8,是否可空:True)
 objcc_PaperStuBatchQuesRelaEN.Score = objRow[concc_PaperStuBatchQuesRela.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_PaperStuBatchQuesRela.Score].ToString().Trim()); //得分(字段类型:decimal,字段长度:6,是否可空:True)
 objcc_PaperStuBatchQuesRelaEN.StuAnswerText = objRow[concc_PaperStuBatchQuesRela.StuAnswerText] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.StuAnswerText].ToString().Trim(); //学生回答文本(字段类型:text,字段长度:2147483647,是否可空:True)
 objcc_PaperStuBatchQuesRelaEN.AnswerDate = objRow[concc_PaperStuBatchQuesRela.AnswerDate] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerDate].ToString().Trim(); //回答日期(字段类型:varchar,字段长度:8,是否可空:True)
 objcc_PaperStuBatchQuesRelaEN.AnswerIP = objRow[concc_PaperStuBatchQuesRela.AnswerIP] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerIP].ToString().Trim(); //回答IP(字段类型:varchar,字段长度:30,是否可空:True)
 objcc_PaperStuBatchQuesRelaEN.AnswerModeId = objRow[concc_PaperStuBatchQuesRela.AnswerModeId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerModeId].ToString().Trim(); //答案模式Id(字段类型:char,字段长度:4,是否可空:True)
 objcc_PaperStuBatchQuesRelaEN.AnswerMultiOptions = objRow[concc_PaperStuBatchQuesRela.AnswerMultiOptions] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerMultiOptions].ToString().Trim(); //多选项答案(字段类型:varchar,字段长度:300,是否可空:True)
 objcc_PaperStuBatchQuesRelaEN.AnswerOptionId = objRow[concc_PaperStuBatchQuesRela.AnswerOptionId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerOptionId].ToString().Trim(); //回答选项Id(字段类型:char,字段长度:8,是否可空:True)
 objcc_PaperStuBatchQuesRelaEN.AnswerTime = objRow[concc_PaperStuBatchQuesRela.AnswerTime] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerTime].ToString().Trim(); //回答时间(字段类型:varchar,字段长度:10,是否可空:True)
 objcc_PaperStuBatchQuesRelaEN.ApplySendBackDate = objRow[concc_PaperStuBatchQuesRela.ApplySendBackDate] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.ApplySendBackDate].ToString().Trim(); //申请退回日期(字段类型:varchar,字段长度:14,是否可空:True)
 objcc_PaperStuBatchQuesRelaEN.Comment = objRow[concc_PaperStuBatchQuesRela.Comment] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.Comment].ToString().Trim(); //批注(字段类型:text,字段长度:2147483647,是否可空:True)
 objcc_PaperStuBatchQuesRelaEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsAccessKnowledge].ToString().Trim()); //是否处理知识点(字段类型:bit,字段长度:1,是否可空:True)
 objcc_PaperStuBatchQuesRelaEN.IsApplySendBack = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsApplySendBack].ToString().Trim()); //是否申请退回(字段类型:bit,字段长度:1,是否可空:True)
 objcc_PaperStuBatchQuesRelaEN.IsInErrorQuestion = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsInErrorQuestion].ToString().Trim()); //是否进入错题(字段类型:bit,字段长度:1,是否可空:True)
 objcc_PaperStuBatchQuesRelaEN.IsLook = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsLook].ToString().Trim()); //是否查看(字段类型:bit,字段长度:1,是否可空:True)
 objcc_PaperStuBatchQuesRelaEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsMarking].ToString().Trim()); //是否批阅(字段类型:bit,字段长度:1,是否可空:True)
 objcc_PaperStuBatchQuesRelaEN.IsNotProcessTimeout = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时(字段类型:bit,字段长度:1,是否可空:True)
 objcc_PaperStuBatchQuesRelaEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsPublish].ToString().Trim()); //是否发布(字段类型:bit,字段长度:1,是否可空:True)
 objcc_PaperStuBatchQuesRelaEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsRight].ToString().Trim()); //是否正确(字段类型:bit,字段长度:1,是否可空:True)
 objcc_PaperStuBatchQuesRelaEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsSave].ToString().Trim()); //是否保存(字段类型:bit,字段长度:1,是否可空:True)
 objcc_PaperStuBatchQuesRelaEN.IsSendBack = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsSendBack].ToString().Trim()); //是否退回(字段类型:bit,字段长度:1,是否可空:True)
 objcc_PaperStuBatchQuesRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objcc_PaperStuBatchQuesRelaEN.MarkDate = objRow[concc_PaperStuBatchQuesRela.MarkDate] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.MarkDate].ToString().Trim(); //打分日期(字段类型:varchar,字段长度:14,是否可空:True)
 objcc_PaperStuBatchQuesRelaEN.MarkerId = objRow[concc_PaperStuBatchQuesRela.MarkerId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.MarkerId].ToString().Trim(); //打分者(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_PaperStuBatchQuesRelaEN.OperateTime = objRow[concc_PaperStuBatchQuesRela.OperateTime] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.OperateTime].ToString().Trim(); //操作时间(字段类型:varchar,字段长度:14,是否可空:True)
 objcc_PaperStuBatchQuesRelaEN.RealFinishDate = objRow[concc_PaperStuBatchQuesRela.RealFinishDate] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.RealFinishDate].ToString().Trim(); //实际完成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objcc_PaperStuBatchQuesRelaEN.WorkTypeId = objRow[concc_PaperStuBatchQuesRela.WorkTypeId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.WorkTypeId].ToString().Trim(); //作业类型Id(字段类型:char,字段长度:2,是否可空:False)
 objcc_PaperStuBatchQuesRelaEN.SchoolYear = objRow[concc_PaperStuBatchQuesRela.SchoolYear] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.SchoolYear].ToString().Trim(); //学年(字段类型:varchar,字段长度:10,是否可空:True)
 objcc_PaperStuBatchQuesRelaEN.SchoolTerm = objRow[concc_PaperStuBatchQuesRela.SchoolTerm] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.SchoolTerm].ToString().Trim(); //学期(字段类型:char,字段长度:1,是否可空:True)
 objcc_PaperStuBatchQuesRelaEN.ErrMsg = objRow[concc_PaperStuBatchQuesRela.ErrMsg] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.ErrMsg].ToString().Trim(); //错误信息(字段类型:varchar,字段长度:200,是否可空:True)
 objcc_PaperStuBatchQuesRelaEN.CourseId = objRow[concc_PaperStuBatchQuesRela.CourseId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objcc_PaperStuBatchQuesRelaEN.UpdDate = objRow[concc_PaperStuBatchQuesRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_PaperStuBatchQuesRelaEN.UpdUserId = objRow[concc_PaperStuBatchQuesRela.UpdUserId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_PaperStuBatchQuesRelaEN.Memo = objRow[concc_PaperStuBatchQuesRela.Memo] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clscc_PaperStuBatchQuesRelaDA: GetObjByIdPaperStuBatchQuesRela)", objException.Message));
}
return objcc_PaperStuBatchQuesRelaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clscc_PaperStuBatchQuesRelaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clscc_PaperStuBatchQuesRelaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PaperStuBatchQuesRelaDA.GetSpecSQLObj();
strSQL = "Select * from cc_PaperStuBatchQuesRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN = new clscc_PaperStuBatchQuesRelaEN()
{
IdPaperStuBatchQuesRela = TransNullToInt(objRow[concc_PaperStuBatchQuesRela.IdPaperStuBatchQuesRela].ToString().Trim()), //学生批次题目关系流水号
IdPaperStuBatch = objRow[concc_PaperStuBatchQuesRela.IdPaperStuBatch].ToString().Trim(), //学生试卷批次流水号
QuestionId = objRow[concc_PaperStuBatchQuesRela.QuestionId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[concc_PaperStuBatchQuesRela.QuestionId].ToString().Trim()), //题目Id
QuestionIndex4Batch = objRow[concc_PaperStuBatchQuesRela.QuestionIndex4Batch] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_PaperStuBatchQuesRela.QuestionIndex4Batch].ToString().Trim()), //题序号4批次
Scores = objRow[concc_PaperStuBatchQuesRela.Scores] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_PaperStuBatchQuesRela.Scores].ToString().Trim()), //分值
Score = objRow[concc_PaperStuBatchQuesRela.Score] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_PaperStuBatchQuesRela.Score].ToString().Trim()), //得分
StuAnswerText = objRow[concc_PaperStuBatchQuesRela.StuAnswerText] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.StuAnswerText].ToString().Trim(), //学生回答文本
AnswerDate = objRow[concc_PaperStuBatchQuesRela.AnswerDate] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerDate].ToString().Trim(), //回答日期
AnswerIP = objRow[concc_PaperStuBatchQuesRela.AnswerIP] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerIP].ToString().Trim(), //回答IP
AnswerModeId = objRow[concc_PaperStuBatchQuesRela.AnswerModeId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerModeId].ToString().Trim(), //答案模式Id
AnswerMultiOptions = objRow[concc_PaperStuBatchQuesRela.AnswerMultiOptions] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerMultiOptions].ToString().Trim(), //多选项答案
AnswerOptionId = objRow[concc_PaperStuBatchQuesRela.AnswerOptionId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerOptionId].ToString().Trim(), //回答选项Id
AnswerTime = objRow[concc_PaperStuBatchQuesRela.AnswerTime] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerTime].ToString().Trim(), //回答时间
ApplySendBackDate = objRow[concc_PaperStuBatchQuesRela.ApplySendBackDate] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.ApplySendBackDate].ToString().Trim(), //申请退回日期
Comment = objRow[concc_PaperStuBatchQuesRela.Comment] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.Comment].ToString().Trim(), //批注
IsAccessKnowledge = TransNullToBool(objRow[concc_PaperStuBatchQuesRela.IsAccessKnowledge].ToString().Trim()), //是否处理知识点
IsApplySendBack = TransNullToBool(objRow[concc_PaperStuBatchQuesRela.IsApplySendBack].ToString().Trim()), //是否申请退回
IsInErrorQuestion = TransNullToBool(objRow[concc_PaperStuBatchQuesRela.IsInErrorQuestion].ToString().Trim()), //是否进入错题
IsLook = TransNullToBool(objRow[concc_PaperStuBatchQuesRela.IsLook].ToString().Trim()), //是否查看
IsMarking = TransNullToBool(objRow[concc_PaperStuBatchQuesRela.IsMarking].ToString().Trim()), //是否批阅
IsNotProcessTimeout = TransNullToBool(objRow[concc_PaperStuBatchQuesRela.IsNotProcessTimeout].ToString().Trim()), //是否不处理超时
IsPublish = TransNullToBool(objRow[concc_PaperStuBatchQuesRela.IsPublish].ToString().Trim()), //是否发布
IsRight = TransNullToBool(objRow[concc_PaperStuBatchQuesRela.IsRight].ToString().Trim()), //是否正确
IsSave = TransNullToBool(objRow[concc_PaperStuBatchQuesRela.IsSave].ToString().Trim()), //是否保存
IsSendBack = TransNullToBool(objRow[concc_PaperStuBatchQuesRela.IsSendBack].ToString().Trim()), //是否退回
IsSubmit = TransNullToBool(objRow[concc_PaperStuBatchQuesRela.IsSubmit].ToString().Trim()), //是否提交
MarkDate = objRow[concc_PaperStuBatchQuesRela.MarkDate] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.MarkDate].ToString().Trim(), //打分日期
MarkerId = objRow[concc_PaperStuBatchQuesRela.MarkerId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.MarkerId].ToString().Trim(), //打分者
OperateTime = objRow[concc_PaperStuBatchQuesRela.OperateTime] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.OperateTime].ToString().Trim(), //操作时间
RealFinishDate = objRow[concc_PaperStuBatchQuesRela.RealFinishDate] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.RealFinishDate].ToString().Trim(), //实际完成日期
WorkTypeId = objRow[concc_PaperStuBatchQuesRela.WorkTypeId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.WorkTypeId].ToString().Trim(), //作业类型Id
SchoolYear = objRow[concc_PaperStuBatchQuesRela.SchoolYear] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.SchoolYear].ToString().Trim(), //学年
SchoolTerm = objRow[concc_PaperStuBatchQuesRela.SchoolTerm] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.SchoolTerm].ToString().Trim(), //学期
ErrMsg = objRow[concc_PaperStuBatchQuesRela.ErrMsg] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.ErrMsg].ToString().Trim(), //错误信息
CourseId = objRow[concc_PaperStuBatchQuesRela.CourseId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.CourseId].ToString().Trim(), //课程Id
UpdDate = objRow[concc_PaperStuBatchQuesRela.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[concc_PaperStuBatchQuesRela.UpdUserId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[concc_PaperStuBatchQuesRela.Memo] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.Memo].ToString().Trim() //备注
};
objcc_PaperStuBatchQuesRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcc_PaperStuBatchQuesRelaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clscc_PaperStuBatchQuesRelaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clscc_PaperStuBatchQuesRelaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN = new clscc_PaperStuBatchQuesRelaEN();
try
{
objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatchQuesRela = TransNullToInt(objRow[concc_PaperStuBatchQuesRela.IdPaperStuBatchQuesRela].ToString().Trim()); //学生批次题目关系流水号
objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatch = objRow[concc_PaperStuBatchQuesRela.IdPaperStuBatch].ToString().Trim(); //学生试卷批次流水号
objcc_PaperStuBatchQuesRelaEN.QuestionId = objRow[concc_PaperStuBatchQuesRela.QuestionId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[concc_PaperStuBatchQuesRela.QuestionId].ToString().Trim()); //题目Id
objcc_PaperStuBatchQuesRelaEN.QuestionIndex4Batch = objRow[concc_PaperStuBatchQuesRela.QuestionIndex4Batch] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_PaperStuBatchQuesRela.QuestionIndex4Batch].ToString().Trim()); //题序号4批次
objcc_PaperStuBatchQuesRelaEN.Scores = objRow[concc_PaperStuBatchQuesRela.Scores] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_PaperStuBatchQuesRela.Scores].ToString().Trim()); //分值
objcc_PaperStuBatchQuesRelaEN.Score = objRow[concc_PaperStuBatchQuesRela.Score] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_PaperStuBatchQuesRela.Score].ToString().Trim()); //得分
objcc_PaperStuBatchQuesRelaEN.StuAnswerText = objRow[concc_PaperStuBatchQuesRela.StuAnswerText] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.StuAnswerText].ToString().Trim(); //学生回答文本
objcc_PaperStuBatchQuesRelaEN.AnswerDate = objRow[concc_PaperStuBatchQuesRela.AnswerDate] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerDate].ToString().Trim(); //回答日期
objcc_PaperStuBatchQuesRelaEN.AnswerIP = objRow[concc_PaperStuBatchQuesRela.AnswerIP] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerIP].ToString().Trim(); //回答IP
objcc_PaperStuBatchQuesRelaEN.AnswerModeId = objRow[concc_PaperStuBatchQuesRela.AnswerModeId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerModeId].ToString().Trim(); //答案模式Id
objcc_PaperStuBatchQuesRelaEN.AnswerMultiOptions = objRow[concc_PaperStuBatchQuesRela.AnswerMultiOptions] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerMultiOptions].ToString().Trim(); //多选项答案
objcc_PaperStuBatchQuesRelaEN.AnswerOptionId = objRow[concc_PaperStuBatchQuesRela.AnswerOptionId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerOptionId].ToString().Trim(); //回答选项Id
objcc_PaperStuBatchQuesRelaEN.AnswerTime = objRow[concc_PaperStuBatchQuesRela.AnswerTime] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerTime].ToString().Trim(); //回答时间
objcc_PaperStuBatchQuesRelaEN.ApplySendBackDate = objRow[concc_PaperStuBatchQuesRela.ApplySendBackDate] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.ApplySendBackDate].ToString().Trim(); //申请退回日期
objcc_PaperStuBatchQuesRelaEN.Comment = objRow[concc_PaperStuBatchQuesRela.Comment] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.Comment].ToString().Trim(); //批注
objcc_PaperStuBatchQuesRelaEN.IsAccessKnowledge = TransNullToBool(objRow[concc_PaperStuBatchQuesRela.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objcc_PaperStuBatchQuesRelaEN.IsApplySendBack = TransNullToBool(objRow[concc_PaperStuBatchQuesRela.IsApplySendBack].ToString().Trim()); //是否申请退回
objcc_PaperStuBatchQuesRelaEN.IsInErrorQuestion = TransNullToBool(objRow[concc_PaperStuBatchQuesRela.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objcc_PaperStuBatchQuesRelaEN.IsLook = TransNullToBool(objRow[concc_PaperStuBatchQuesRela.IsLook].ToString().Trim()); //是否查看
objcc_PaperStuBatchQuesRelaEN.IsMarking = TransNullToBool(objRow[concc_PaperStuBatchQuesRela.IsMarking].ToString().Trim()); //是否批阅
objcc_PaperStuBatchQuesRelaEN.IsNotProcessTimeout = TransNullToBool(objRow[concc_PaperStuBatchQuesRela.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objcc_PaperStuBatchQuesRelaEN.IsPublish = TransNullToBool(objRow[concc_PaperStuBatchQuesRela.IsPublish].ToString().Trim()); //是否发布
objcc_PaperStuBatchQuesRelaEN.IsRight = TransNullToBool(objRow[concc_PaperStuBatchQuesRela.IsRight].ToString().Trim()); //是否正确
objcc_PaperStuBatchQuesRelaEN.IsSave = TransNullToBool(objRow[concc_PaperStuBatchQuesRela.IsSave].ToString().Trim()); //是否保存
objcc_PaperStuBatchQuesRelaEN.IsSendBack = TransNullToBool(objRow[concc_PaperStuBatchQuesRela.IsSendBack].ToString().Trim()); //是否退回
objcc_PaperStuBatchQuesRelaEN.IsSubmit = TransNullToBool(objRow[concc_PaperStuBatchQuesRela.IsSubmit].ToString().Trim()); //是否提交
objcc_PaperStuBatchQuesRelaEN.MarkDate = objRow[concc_PaperStuBatchQuesRela.MarkDate] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.MarkDate].ToString().Trim(); //打分日期
objcc_PaperStuBatchQuesRelaEN.MarkerId = objRow[concc_PaperStuBatchQuesRela.MarkerId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.MarkerId].ToString().Trim(); //打分者
objcc_PaperStuBatchQuesRelaEN.OperateTime = objRow[concc_PaperStuBatchQuesRela.OperateTime] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.OperateTime].ToString().Trim(); //操作时间
objcc_PaperStuBatchQuesRelaEN.RealFinishDate = objRow[concc_PaperStuBatchQuesRela.RealFinishDate] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.RealFinishDate].ToString().Trim(); //实际完成日期
objcc_PaperStuBatchQuesRelaEN.WorkTypeId = objRow[concc_PaperStuBatchQuesRela.WorkTypeId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.WorkTypeId].ToString().Trim(); //作业类型Id
objcc_PaperStuBatchQuesRelaEN.SchoolYear = objRow[concc_PaperStuBatchQuesRela.SchoolYear] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.SchoolYear].ToString().Trim(); //学年
objcc_PaperStuBatchQuesRelaEN.SchoolTerm = objRow[concc_PaperStuBatchQuesRela.SchoolTerm] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.SchoolTerm].ToString().Trim(); //学期
objcc_PaperStuBatchQuesRelaEN.ErrMsg = objRow[concc_PaperStuBatchQuesRela.ErrMsg] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.ErrMsg].ToString().Trim(); //错误信息
objcc_PaperStuBatchQuesRelaEN.CourseId = objRow[concc_PaperStuBatchQuesRela.CourseId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.CourseId].ToString().Trim(); //课程Id
objcc_PaperStuBatchQuesRelaEN.UpdDate = objRow[concc_PaperStuBatchQuesRela.UpdDate].ToString().Trim(); //修改日期
objcc_PaperStuBatchQuesRelaEN.UpdUserId = objRow[concc_PaperStuBatchQuesRela.UpdUserId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.UpdUserId].ToString().Trim(); //修改用户Id
objcc_PaperStuBatchQuesRelaEN.Memo = objRow[concc_PaperStuBatchQuesRela.Memo] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clscc_PaperStuBatchQuesRelaDA: GetObjByDataRowcc_PaperStuBatchQuesRela)", objException.Message));
}
objcc_PaperStuBatchQuesRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcc_PaperStuBatchQuesRelaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clscc_PaperStuBatchQuesRelaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN = new clscc_PaperStuBatchQuesRelaEN();
try
{
objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatchQuesRela = TransNullToInt(objRow[concc_PaperStuBatchQuesRela.IdPaperStuBatchQuesRela].ToString().Trim()); //学生批次题目关系流水号
objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatch = objRow[concc_PaperStuBatchQuesRela.IdPaperStuBatch].ToString().Trim(); //学生试卷批次流水号
objcc_PaperStuBatchQuesRelaEN.QuestionId = objRow[concc_PaperStuBatchQuesRela.QuestionId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[concc_PaperStuBatchQuesRela.QuestionId].ToString().Trim()); //题目Id
objcc_PaperStuBatchQuesRelaEN.QuestionIndex4Batch = objRow[concc_PaperStuBatchQuesRela.QuestionIndex4Batch] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_PaperStuBatchQuesRela.QuestionIndex4Batch].ToString().Trim()); //题序号4批次
objcc_PaperStuBatchQuesRelaEN.Scores = objRow[concc_PaperStuBatchQuesRela.Scores] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_PaperStuBatchQuesRela.Scores].ToString().Trim()); //分值
objcc_PaperStuBatchQuesRelaEN.Score = objRow[concc_PaperStuBatchQuesRela.Score] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_PaperStuBatchQuesRela.Score].ToString().Trim()); //得分
objcc_PaperStuBatchQuesRelaEN.StuAnswerText = objRow[concc_PaperStuBatchQuesRela.StuAnswerText] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.StuAnswerText].ToString().Trim(); //学生回答文本
objcc_PaperStuBatchQuesRelaEN.AnswerDate = objRow[concc_PaperStuBatchQuesRela.AnswerDate] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerDate].ToString().Trim(); //回答日期
objcc_PaperStuBatchQuesRelaEN.AnswerIP = objRow[concc_PaperStuBatchQuesRela.AnswerIP] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerIP].ToString().Trim(); //回答IP
objcc_PaperStuBatchQuesRelaEN.AnswerModeId = objRow[concc_PaperStuBatchQuesRela.AnswerModeId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerModeId].ToString().Trim(); //答案模式Id
objcc_PaperStuBatchQuesRelaEN.AnswerMultiOptions = objRow[concc_PaperStuBatchQuesRela.AnswerMultiOptions] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerMultiOptions].ToString().Trim(); //多选项答案
objcc_PaperStuBatchQuesRelaEN.AnswerOptionId = objRow[concc_PaperStuBatchQuesRela.AnswerOptionId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerOptionId].ToString().Trim(); //回答选项Id
objcc_PaperStuBatchQuesRelaEN.AnswerTime = objRow[concc_PaperStuBatchQuesRela.AnswerTime] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerTime].ToString().Trim(); //回答时间
objcc_PaperStuBatchQuesRelaEN.ApplySendBackDate = objRow[concc_PaperStuBatchQuesRela.ApplySendBackDate] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.ApplySendBackDate].ToString().Trim(); //申请退回日期
objcc_PaperStuBatchQuesRelaEN.Comment = objRow[concc_PaperStuBatchQuesRela.Comment] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.Comment].ToString().Trim(); //批注
objcc_PaperStuBatchQuesRelaEN.IsAccessKnowledge = TransNullToBool(objRow[concc_PaperStuBatchQuesRela.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objcc_PaperStuBatchQuesRelaEN.IsApplySendBack = TransNullToBool(objRow[concc_PaperStuBatchQuesRela.IsApplySendBack].ToString().Trim()); //是否申请退回
objcc_PaperStuBatchQuesRelaEN.IsInErrorQuestion = TransNullToBool(objRow[concc_PaperStuBatchQuesRela.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objcc_PaperStuBatchQuesRelaEN.IsLook = TransNullToBool(objRow[concc_PaperStuBatchQuesRela.IsLook].ToString().Trim()); //是否查看
objcc_PaperStuBatchQuesRelaEN.IsMarking = TransNullToBool(objRow[concc_PaperStuBatchQuesRela.IsMarking].ToString().Trim()); //是否批阅
objcc_PaperStuBatchQuesRelaEN.IsNotProcessTimeout = TransNullToBool(objRow[concc_PaperStuBatchQuesRela.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objcc_PaperStuBatchQuesRelaEN.IsPublish = TransNullToBool(objRow[concc_PaperStuBatchQuesRela.IsPublish].ToString().Trim()); //是否发布
objcc_PaperStuBatchQuesRelaEN.IsRight = TransNullToBool(objRow[concc_PaperStuBatchQuesRela.IsRight].ToString().Trim()); //是否正确
objcc_PaperStuBatchQuesRelaEN.IsSave = TransNullToBool(objRow[concc_PaperStuBatchQuesRela.IsSave].ToString().Trim()); //是否保存
objcc_PaperStuBatchQuesRelaEN.IsSendBack = TransNullToBool(objRow[concc_PaperStuBatchQuesRela.IsSendBack].ToString().Trim()); //是否退回
objcc_PaperStuBatchQuesRelaEN.IsSubmit = TransNullToBool(objRow[concc_PaperStuBatchQuesRela.IsSubmit].ToString().Trim()); //是否提交
objcc_PaperStuBatchQuesRelaEN.MarkDate = objRow[concc_PaperStuBatchQuesRela.MarkDate] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.MarkDate].ToString().Trim(); //打分日期
objcc_PaperStuBatchQuesRelaEN.MarkerId = objRow[concc_PaperStuBatchQuesRela.MarkerId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.MarkerId].ToString().Trim(); //打分者
objcc_PaperStuBatchQuesRelaEN.OperateTime = objRow[concc_PaperStuBatchQuesRela.OperateTime] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.OperateTime].ToString().Trim(); //操作时间
objcc_PaperStuBatchQuesRelaEN.RealFinishDate = objRow[concc_PaperStuBatchQuesRela.RealFinishDate] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.RealFinishDate].ToString().Trim(); //实际完成日期
objcc_PaperStuBatchQuesRelaEN.WorkTypeId = objRow[concc_PaperStuBatchQuesRela.WorkTypeId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.WorkTypeId].ToString().Trim(); //作业类型Id
objcc_PaperStuBatchQuesRelaEN.SchoolYear = objRow[concc_PaperStuBatchQuesRela.SchoolYear] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.SchoolYear].ToString().Trim(); //学年
objcc_PaperStuBatchQuesRelaEN.SchoolTerm = objRow[concc_PaperStuBatchQuesRela.SchoolTerm] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.SchoolTerm].ToString().Trim(); //学期
objcc_PaperStuBatchQuesRelaEN.ErrMsg = objRow[concc_PaperStuBatchQuesRela.ErrMsg] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.ErrMsg].ToString().Trim(); //错误信息
objcc_PaperStuBatchQuesRelaEN.CourseId = objRow[concc_PaperStuBatchQuesRela.CourseId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.CourseId].ToString().Trim(); //课程Id
objcc_PaperStuBatchQuesRelaEN.UpdDate = objRow[concc_PaperStuBatchQuesRela.UpdDate].ToString().Trim(); //修改日期
objcc_PaperStuBatchQuesRelaEN.UpdUserId = objRow[concc_PaperStuBatchQuesRela.UpdUserId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.UpdUserId].ToString().Trim(); //修改用户Id
objcc_PaperStuBatchQuesRelaEN.Memo = objRow[concc_PaperStuBatchQuesRela.Memo] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clscc_PaperStuBatchQuesRelaDA: GetObjByDataRow)", objException.Message));
}
objcc_PaperStuBatchQuesRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcc_PaperStuBatchQuesRelaEN;
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
objSQL = clscc_PaperStuBatchQuesRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clscc_PaperStuBatchQuesRelaEN._CurrTabName, concc_PaperStuBatchQuesRela.IdPaperStuBatchQuesRela, 8, "");
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
objSQL = clscc_PaperStuBatchQuesRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clscc_PaperStuBatchQuesRelaEN._CurrTabName, concc_PaperStuBatchQuesRela.IdPaperStuBatchQuesRela, 8, strPrefix);
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
 objSQL = clscc_PaperStuBatchQuesRelaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdPaperStuBatchQuesRela from cc_PaperStuBatchQuesRela where " + strCondition;
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
 objSQL = clscc_PaperStuBatchQuesRelaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdPaperStuBatchQuesRela from cc_PaperStuBatchQuesRela where " + strCondition;
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
 /// <param name = "lngIdPaperStuBatchQuesRela">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngIdPaperStuBatchQuesRela)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PaperStuBatchQuesRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("cc_PaperStuBatchQuesRela", "IdPaperStuBatchQuesRela = " + ""+ lngIdPaperStuBatchQuesRela+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clscc_PaperStuBatchQuesRelaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PaperStuBatchQuesRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("cc_PaperStuBatchQuesRela", strCondition))
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
objSQL = clscc_PaperStuBatchQuesRelaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("cc_PaperStuBatchQuesRela");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN)
 {
 objcc_PaperStuBatchQuesRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_PaperStuBatchQuesRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_PaperStuBatchQuesRelaEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PaperStuBatchQuesRelaDA.GetSpecSQLObj();
strSQL = "Select * from cc_PaperStuBatchQuesRela where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "cc_PaperStuBatchQuesRela");
objRow = objDS.Tables["cc_PaperStuBatchQuesRela"].NewRow();
objRow[concc_PaperStuBatchQuesRela.IdPaperStuBatch] = objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatch; //学生试卷批次流水号
objRow[concc_PaperStuBatchQuesRela.QuestionId] = objcc_PaperStuBatchQuesRelaEN.QuestionId; //题目Id
objRow[concc_PaperStuBatchQuesRela.QuestionIndex4Batch] = objcc_PaperStuBatchQuesRelaEN.QuestionIndex4Batch; //题序号4批次
objRow[concc_PaperStuBatchQuesRela.Scores] = objcc_PaperStuBatchQuesRelaEN.Scores; //分值
objRow[concc_PaperStuBatchQuesRela.Score] = objcc_PaperStuBatchQuesRelaEN.Score; //得分
 if (objcc_PaperStuBatchQuesRelaEN.StuAnswerText !=  "")
 {
objRow[concc_PaperStuBatchQuesRela.StuAnswerText] = objcc_PaperStuBatchQuesRelaEN.StuAnswerText; //学生回答文本
 }
 if (objcc_PaperStuBatchQuesRelaEN.AnswerDate !=  "")
 {
objRow[concc_PaperStuBatchQuesRela.AnswerDate] = objcc_PaperStuBatchQuesRelaEN.AnswerDate; //回答日期
 }
 if (objcc_PaperStuBatchQuesRelaEN.AnswerIP !=  "")
 {
objRow[concc_PaperStuBatchQuesRela.AnswerIP] = objcc_PaperStuBatchQuesRelaEN.AnswerIP; //回答IP
 }
 if (objcc_PaperStuBatchQuesRelaEN.AnswerModeId !=  "")
 {
objRow[concc_PaperStuBatchQuesRela.AnswerModeId] = objcc_PaperStuBatchQuesRelaEN.AnswerModeId; //答案模式Id
 }
 if (objcc_PaperStuBatchQuesRelaEN.AnswerMultiOptions !=  "")
 {
objRow[concc_PaperStuBatchQuesRela.AnswerMultiOptions] = objcc_PaperStuBatchQuesRelaEN.AnswerMultiOptions; //多选项答案
 }
 if (objcc_PaperStuBatchQuesRelaEN.AnswerOptionId !=  "")
 {
objRow[concc_PaperStuBatchQuesRela.AnswerOptionId] = objcc_PaperStuBatchQuesRelaEN.AnswerOptionId; //回答选项Id
 }
 if (objcc_PaperStuBatchQuesRelaEN.AnswerTime !=  "")
 {
objRow[concc_PaperStuBatchQuesRela.AnswerTime] = objcc_PaperStuBatchQuesRelaEN.AnswerTime; //回答时间
 }
 if (objcc_PaperStuBatchQuesRelaEN.ApplySendBackDate !=  "")
 {
objRow[concc_PaperStuBatchQuesRela.ApplySendBackDate] = objcc_PaperStuBatchQuesRelaEN.ApplySendBackDate; //申请退回日期
 }
 if (objcc_PaperStuBatchQuesRelaEN.Comment !=  "")
 {
objRow[concc_PaperStuBatchQuesRela.Comment] = objcc_PaperStuBatchQuesRelaEN.Comment; //批注
 }
objRow[concc_PaperStuBatchQuesRela.IsAccessKnowledge] = objcc_PaperStuBatchQuesRelaEN.IsAccessKnowledge; //是否处理知识点
objRow[concc_PaperStuBatchQuesRela.IsApplySendBack] = objcc_PaperStuBatchQuesRelaEN.IsApplySendBack; //是否申请退回
objRow[concc_PaperStuBatchQuesRela.IsInErrorQuestion] = objcc_PaperStuBatchQuesRelaEN.IsInErrorQuestion; //是否进入错题
objRow[concc_PaperStuBatchQuesRela.IsLook] = objcc_PaperStuBatchQuesRelaEN.IsLook; //是否查看
objRow[concc_PaperStuBatchQuesRela.IsMarking] = objcc_PaperStuBatchQuesRelaEN.IsMarking; //是否批阅
objRow[concc_PaperStuBatchQuesRela.IsNotProcessTimeout] = objcc_PaperStuBatchQuesRelaEN.IsNotProcessTimeout; //是否不处理超时
objRow[concc_PaperStuBatchQuesRela.IsPublish] = objcc_PaperStuBatchQuesRelaEN.IsPublish; //是否发布
objRow[concc_PaperStuBatchQuesRela.IsRight] = objcc_PaperStuBatchQuesRelaEN.IsRight; //是否正确
objRow[concc_PaperStuBatchQuesRela.IsSave] = objcc_PaperStuBatchQuesRelaEN.IsSave; //是否保存
objRow[concc_PaperStuBatchQuesRela.IsSendBack] = objcc_PaperStuBatchQuesRelaEN.IsSendBack; //是否退回
objRow[concc_PaperStuBatchQuesRela.IsSubmit] = objcc_PaperStuBatchQuesRelaEN.IsSubmit; //是否提交
 if (objcc_PaperStuBatchQuesRelaEN.MarkDate !=  "")
 {
objRow[concc_PaperStuBatchQuesRela.MarkDate] = objcc_PaperStuBatchQuesRelaEN.MarkDate; //打分日期
 }
 if (objcc_PaperStuBatchQuesRelaEN.MarkerId !=  "")
 {
objRow[concc_PaperStuBatchQuesRela.MarkerId] = objcc_PaperStuBatchQuesRelaEN.MarkerId; //打分者
 }
 if (objcc_PaperStuBatchQuesRelaEN.OperateTime !=  "")
 {
objRow[concc_PaperStuBatchQuesRela.OperateTime] = objcc_PaperStuBatchQuesRelaEN.OperateTime; //操作时间
 }
 if (objcc_PaperStuBatchQuesRelaEN.RealFinishDate !=  "")
 {
objRow[concc_PaperStuBatchQuesRela.RealFinishDate] = objcc_PaperStuBatchQuesRelaEN.RealFinishDate; //实际完成日期
 }
 if (objcc_PaperStuBatchQuesRelaEN.WorkTypeId !=  "")
 {
objRow[concc_PaperStuBatchQuesRela.WorkTypeId] = objcc_PaperStuBatchQuesRelaEN.WorkTypeId; //作业类型Id
 }
 if (objcc_PaperStuBatchQuesRelaEN.SchoolYear !=  "")
 {
objRow[concc_PaperStuBatchQuesRela.SchoolYear] = objcc_PaperStuBatchQuesRelaEN.SchoolYear; //学年
 }
 if (objcc_PaperStuBatchQuesRelaEN.SchoolTerm !=  "")
 {
objRow[concc_PaperStuBatchQuesRela.SchoolTerm] = objcc_PaperStuBatchQuesRelaEN.SchoolTerm; //学期
 }
 if (objcc_PaperStuBatchQuesRelaEN.ErrMsg !=  "")
 {
objRow[concc_PaperStuBatchQuesRela.ErrMsg] = objcc_PaperStuBatchQuesRelaEN.ErrMsg; //错误信息
 }
 if (objcc_PaperStuBatchQuesRelaEN.CourseId !=  "")
 {
objRow[concc_PaperStuBatchQuesRela.CourseId] = objcc_PaperStuBatchQuesRelaEN.CourseId; //课程Id
 }
objRow[concc_PaperStuBatchQuesRela.UpdDate] = objcc_PaperStuBatchQuesRelaEN.UpdDate; //修改日期
 if (objcc_PaperStuBatchQuesRelaEN.UpdUserId !=  "")
 {
objRow[concc_PaperStuBatchQuesRela.UpdUserId] = objcc_PaperStuBatchQuesRelaEN.UpdUserId; //修改用户Id
 }
 if (objcc_PaperStuBatchQuesRelaEN.Memo !=  "")
 {
objRow[concc_PaperStuBatchQuesRela.Memo] = objcc_PaperStuBatchQuesRelaEN.Memo; //备注
 }
objDS.Tables[clscc_PaperStuBatchQuesRelaEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clscc_PaperStuBatchQuesRelaEN._CurrTabName);
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
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN)
{
 objcc_PaperStuBatchQuesRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_PaperStuBatchQuesRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_PaperStuBatchQuesRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatch  ==  "")
 {
 objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatch = null;
 }
 if (objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatch !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.IdPaperStuBatch);
 var strIdPaperStuBatch = objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatch.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdPaperStuBatch + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.QuestionId !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.QuestionId);
 arrValueListForInsert.Add(objcc_PaperStuBatchQuesRelaEN.QuestionId.ToString());
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.QuestionIndex4Batch !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.QuestionIndex4Batch);
 arrValueListForInsert.Add(objcc_PaperStuBatchQuesRelaEN.QuestionIndex4Batch.ToString());
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.Scores !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.Scores);
 arrValueListForInsert.Add(objcc_PaperStuBatchQuesRelaEN.Scores.ToString());
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.Score !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.Score);
 arrValueListForInsert.Add(objcc_PaperStuBatchQuesRelaEN.Score.ToString());
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.StuAnswerText !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.StuAnswerText);
 var strStuAnswerText = objcc_PaperStuBatchQuesRelaEN.StuAnswerText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStuAnswerText + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.AnswerDate !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.AnswerDate);
 var strAnswerDate = objcc_PaperStuBatchQuesRelaEN.AnswerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerDate + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.AnswerIP !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.AnswerIP);
 var strAnswerIP = objcc_PaperStuBatchQuesRelaEN.AnswerIP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerIP + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.AnswerModeId !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.AnswerModeId);
 var strAnswerModeId = objcc_PaperStuBatchQuesRelaEN.AnswerModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerModeId + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.AnswerMultiOptions !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.AnswerMultiOptions);
 var strAnswerMultiOptions = objcc_PaperStuBatchQuesRelaEN.AnswerMultiOptions.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerMultiOptions + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.AnswerOptionId !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.AnswerOptionId);
 var strAnswerOptionId = objcc_PaperStuBatchQuesRelaEN.AnswerOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerOptionId + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.AnswerTime !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.AnswerTime);
 var strAnswerTime = objcc_PaperStuBatchQuesRelaEN.AnswerTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerTime + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.ApplySendBackDate !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.ApplySendBackDate);
 var strApplySendBackDate = objcc_PaperStuBatchQuesRelaEN.ApplySendBackDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strApplySendBackDate + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.Comment !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.Comment);
 var strComment = objcc_PaperStuBatchQuesRelaEN.Comment.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strComment + "'");
 }
 
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.IsAccessKnowledge);
 arrValueListForInsert.Add("'" + (objcc_PaperStuBatchQuesRelaEN.IsAccessKnowledge  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.IsApplySendBack);
 arrValueListForInsert.Add("'" + (objcc_PaperStuBatchQuesRelaEN.IsApplySendBack  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.IsInErrorQuestion);
 arrValueListForInsert.Add("'" + (objcc_PaperStuBatchQuesRelaEN.IsInErrorQuestion  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.IsLook);
 arrValueListForInsert.Add("'" + (objcc_PaperStuBatchQuesRelaEN.IsLook  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.IsMarking);
 arrValueListForInsert.Add("'" + (objcc_PaperStuBatchQuesRelaEN.IsMarking  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.IsNotProcessTimeout);
 arrValueListForInsert.Add("'" + (objcc_PaperStuBatchQuesRelaEN.IsNotProcessTimeout  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.IsPublish);
 arrValueListForInsert.Add("'" + (objcc_PaperStuBatchQuesRelaEN.IsPublish  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.IsRight);
 arrValueListForInsert.Add("'" + (objcc_PaperStuBatchQuesRelaEN.IsRight  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.IsSave);
 arrValueListForInsert.Add("'" + (objcc_PaperStuBatchQuesRelaEN.IsSave  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.IsSendBack);
 arrValueListForInsert.Add("'" + (objcc_PaperStuBatchQuesRelaEN.IsSendBack  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.IsSubmit);
 arrValueListForInsert.Add("'" + (objcc_PaperStuBatchQuesRelaEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objcc_PaperStuBatchQuesRelaEN.MarkDate !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.MarkDate);
 var strMarkDate = objcc_PaperStuBatchQuesRelaEN.MarkDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMarkDate + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.MarkerId !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.MarkerId);
 var strMarkerId = objcc_PaperStuBatchQuesRelaEN.MarkerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMarkerId + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.OperateTime !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.OperateTime);
 var strOperateTime = objcc_PaperStuBatchQuesRelaEN.OperateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOperateTime + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.RealFinishDate !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.RealFinishDate);
 var strRealFinishDate = objcc_PaperStuBatchQuesRelaEN.RealFinishDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRealFinishDate + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.WorkTypeId !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.WorkTypeId);
 var strWorkTypeId = objcc_PaperStuBatchQuesRelaEN.WorkTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWorkTypeId + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.SchoolYear !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.SchoolYear);
 var strSchoolYear = objcc_PaperStuBatchQuesRelaEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolYear + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.SchoolTerm !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.SchoolTerm);
 var strSchoolTerm = objcc_PaperStuBatchQuesRelaEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolTerm + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.ErrMsg !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.ErrMsg);
 var strErrMsg = objcc_PaperStuBatchQuesRelaEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrMsg + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.CourseId);
 var strCourseId = objcc_PaperStuBatchQuesRelaEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.UpdDate);
 var strUpdDate = objcc_PaperStuBatchQuesRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.UpdUserId);
 var strUpdUserId = objcc_PaperStuBatchQuesRelaEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.Memo);
 var strMemo = objcc_PaperStuBatchQuesRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_PaperStuBatchQuesRela");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PaperStuBatchQuesRelaDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN)
{
 objcc_PaperStuBatchQuesRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_PaperStuBatchQuesRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_PaperStuBatchQuesRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatch  ==  "")
 {
 objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatch = null;
 }
 if (objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatch !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.IdPaperStuBatch);
 var strIdPaperStuBatch = objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatch.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdPaperStuBatch + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.QuestionId !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.QuestionId);
 arrValueListForInsert.Add(objcc_PaperStuBatchQuesRelaEN.QuestionId.ToString());
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.QuestionIndex4Batch !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.QuestionIndex4Batch);
 arrValueListForInsert.Add(objcc_PaperStuBatchQuesRelaEN.QuestionIndex4Batch.ToString());
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.Scores !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.Scores);
 arrValueListForInsert.Add(objcc_PaperStuBatchQuesRelaEN.Scores.ToString());
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.Score !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.Score);
 arrValueListForInsert.Add(objcc_PaperStuBatchQuesRelaEN.Score.ToString());
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.StuAnswerText !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.StuAnswerText);
 var strStuAnswerText = objcc_PaperStuBatchQuesRelaEN.StuAnswerText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStuAnswerText + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.AnswerDate !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.AnswerDate);
 var strAnswerDate = objcc_PaperStuBatchQuesRelaEN.AnswerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerDate + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.AnswerIP !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.AnswerIP);
 var strAnswerIP = objcc_PaperStuBatchQuesRelaEN.AnswerIP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerIP + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.AnswerModeId !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.AnswerModeId);
 var strAnswerModeId = objcc_PaperStuBatchQuesRelaEN.AnswerModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerModeId + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.AnswerMultiOptions !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.AnswerMultiOptions);
 var strAnswerMultiOptions = objcc_PaperStuBatchQuesRelaEN.AnswerMultiOptions.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerMultiOptions + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.AnswerOptionId !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.AnswerOptionId);
 var strAnswerOptionId = objcc_PaperStuBatchQuesRelaEN.AnswerOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerOptionId + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.AnswerTime !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.AnswerTime);
 var strAnswerTime = objcc_PaperStuBatchQuesRelaEN.AnswerTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerTime + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.ApplySendBackDate !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.ApplySendBackDate);
 var strApplySendBackDate = objcc_PaperStuBatchQuesRelaEN.ApplySendBackDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strApplySendBackDate + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.Comment !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.Comment);
 var strComment = objcc_PaperStuBatchQuesRelaEN.Comment.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strComment + "'");
 }
 
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.IsAccessKnowledge);
 arrValueListForInsert.Add("'" + (objcc_PaperStuBatchQuesRelaEN.IsAccessKnowledge  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.IsApplySendBack);
 arrValueListForInsert.Add("'" + (objcc_PaperStuBatchQuesRelaEN.IsApplySendBack  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.IsInErrorQuestion);
 arrValueListForInsert.Add("'" + (objcc_PaperStuBatchQuesRelaEN.IsInErrorQuestion  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.IsLook);
 arrValueListForInsert.Add("'" + (objcc_PaperStuBatchQuesRelaEN.IsLook  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.IsMarking);
 arrValueListForInsert.Add("'" + (objcc_PaperStuBatchQuesRelaEN.IsMarking  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.IsNotProcessTimeout);
 arrValueListForInsert.Add("'" + (objcc_PaperStuBatchQuesRelaEN.IsNotProcessTimeout  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.IsPublish);
 arrValueListForInsert.Add("'" + (objcc_PaperStuBatchQuesRelaEN.IsPublish  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.IsRight);
 arrValueListForInsert.Add("'" + (objcc_PaperStuBatchQuesRelaEN.IsRight  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.IsSave);
 arrValueListForInsert.Add("'" + (objcc_PaperStuBatchQuesRelaEN.IsSave  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.IsSendBack);
 arrValueListForInsert.Add("'" + (objcc_PaperStuBatchQuesRelaEN.IsSendBack  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.IsSubmit);
 arrValueListForInsert.Add("'" + (objcc_PaperStuBatchQuesRelaEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objcc_PaperStuBatchQuesRelaEN.MarkDate !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.MarkDate);
 var strMarkDate = objcc_PaperStuBatchQuesRelaEN.MarkDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMarkDate + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.MarkerId !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.MarkerId);
 var strMarkerId = objcc_PaperStuBatchQuesRelaEN.MarkerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMarkerId + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.OperateTime !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.OperateTime);
 var strOperateTime = objcc_PaperStuBatchQuesRelaEN.OperateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOperateTime + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.RealFinishDate !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.RealFinishDate);
 var strRealFinishDate = objcc_PaperStuBatchQuesRelaEN.RealFinishDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRealFinishDate + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.WorkTypeId !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.WorkTypeId);
 var strWorkTypeId = objcc_PaperStuBatchQuesRelaEN.WorkTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWorkTypeId + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.SchoolYear !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.SchoolYear);
 var strSchoolYear = objcc_PaperStuBatchQuesRelaEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolYear + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.SchoolTerm !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.SchoolTerm);
 var strSchoolTerm = objcc_PaperStuBatchQuesRelaEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolTerm + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.ErrMsg !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.ErrMsg);
 var strErrMsg = objcc_PaperStuBatchQuesRelaEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrMsg + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.CourseId);
 var strCourseId = objcc_PaperStuBatchQuesRelaEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.UpdDate);
 var strUpdDate = objcc_PaperStuBatchQuesRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.UpdUserId);
 var strUpdUserId = objcc_PaperStuBatchQuesRelaEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.Memo);
 var strMemo = objcc_PaperStuBatchQuesRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_PaperStuBatchQuesRela");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PaperStuBatchQuesRelaDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objcc_PaperStuBatchQuesRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_PaperStuBatchQuesRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_PaperStuBatchQuesRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatch  ==  "")
 {
 objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatch = null;
 }
 if (objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatch !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.IdPaperStuBatch);
 var strIdPaperStuBatch = objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatch.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdPaperStuBatch + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.QuestionId !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.QuestionId);
 arrValueListForInsert.Add(objcc_PaperStuBatchQuesRelaEN.QuestionId.ToString());
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.QuestionIndex4Batch !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.QuestionIndex4Batch);
 arrValueListForInsert.Add(objcc_PaperStuBatchQuesRelaEN.QuestionIndex4Batch.ToString());
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.Scores !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.Scores);
 arrValueListForInsert.Add(objcc_PaperStuBatchQuesRelaEN.Scores.ToString());
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.Score !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.Score);
 arrValueListForInsert.Add(objcc_PaperStuBatchQuesRelaEN.Score.ToString());
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.StuAnswerText !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.StuAnswerText);
 var strStuAnswerText = objcc_PaperStuBatchQuesRelaEN.StuAnswerText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStuAnswerText + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.AnswerDate !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.AnswerDate);
 var strAnswerDate = objcc_PaperStuBatchQuesRelaEN.AnswerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerDate + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.AnswerIP !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.AnswerIP);
 var strAnswerIP = objcc_PaperStuBatchQuesRelaEN.AnswerIP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerIP + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.AnswerModeId !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.AnswerModeId);
 var strAnswerModeId = objcc_PaperStuBatchQuesRelaEN.AnswerModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerModeId + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.AnswerMultiOptions !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.AnswerMultiOptions);
 var strAnswerMultiOptions = objcc_PaperStuBatchQuesRelaEN.AnswerMultiOptions.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerMultiOptions + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.AnswerOptionId !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.AnswerOptionId);
 var strAnswerOptionId = objcc_PaperStuBatchQuesRelaEN.AnswerOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerOptionId + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.AnswerTime !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.AnswerTime);
 var strAnswerTime = objcc_PaperStuBatchQuesRelaEN.AnswerTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerTime + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.ApplySendBackDate !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.ApplySendBackDate);
 var strApplySendBackDate = objcc_PaperStuBatchQuesRelaEN.ApplySendBackDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strApplySendBackDate + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.Comment !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.Comment);
 var strComment = objcc_PaperStuBatchQuesRelaEN.Comment.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strComment + "'");
 }
 
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.IsAccessKnowledge);
 arrValueListForInsert.Add("'" + (objcc_PaperStuBatchQuesRelaEN.IsAccessKnowledge  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.IsApplySendBack);
 arrValueListForInsert.Add("'" + (objcc_PaperStuBatchQuesRelaEN.IsApplySendBack  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.IsInErrorQuestion);
 arrValueListForInsert.Add("'" + (objcc_PaperStuBatchQuesRelaEN.IsInErrorQuestion  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.IsLook);
 arrValueListForInsert.Add("'" + (objcc_PaperStuBatchQuesRelaEN.IsLook  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.IsMarking);
 arrValueListForInsert.Add("'" + (objcc_PaperStuBatchQuesRelaEN.IsMarking  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.IsNotProcessTimeout);
 arrValueListForInsert.Add("'" + (objcc_PaperStuBatchQuesRelaEN.IsNotProcessTimeout  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.IsPublish);
 arrValueListForInsert.Add("'" + (objcc_PaperStuBatchQuesRelaEN.IsPublish  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.IsRight);
 arrValueListForInsert.Add("'" + (objcc_PaperStuBatchQuesRelaEN.IsRight  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.IsSave);
 arrValueListForInsert.Add("'" + (objcc_PaperStuBatchQuesRelaEN.IsSave  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.IsSendBack);
 arrValueListForInsert.Add("'" + (objcc_PaperStuBatchQuesRelaEN.IsSendBack  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.IsSubmit);
 arrValueListForInsert.Add("'" + (objcc_PaperStuBatchQuesRelaEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objcc_PaperStuBatchQuesRelaEN.MarkDate !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.MarkDate);
 var strMarkDate = objcc_PaperStuBatchQuesRelaEN.MarkDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMarkDate + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.MarkerId !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.MarkerId);
 var strMarkerId = objcc_PaperStuBatchQuesRelaEN.MarkerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMarkerId + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.OperateTime !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.OperateTime);
 var strOperateTime = objcc_PaperStuBatchQuesRelaEN.OperateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOperateTime + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.RealFinishDate !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.RealFinishDate);
 var strRealFinishDate = objcc_PaperStuBatchQuesRelaEN.RealFinishDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRealFinishDate + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.WorkTypeId !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.WorkTypeId);
 var strWorkTypeId = objcc_PaperStuBatchQuesRelaEN.WorkTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWorkTypeId + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.SchoolYear !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.SchoolYear);
 var strSchoolYear = objcc_PaperStuBatchQuesRelaEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolYear + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.SchoolTerm !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.SchoolTerm);
 var strSchoolTerm = objcc_PaperStuBatchQuesRelaEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolTerm + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.ErrMsg !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.ErrMsg);
 var strErrMsg = objcc_PaperStuBatchQuesRelaEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrMsg + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.CourseId);
 var strCourseId = objcc_PaperStuBatchQuesRelaEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.UpdDate);
 var strUpdDate = objcc_PaperStuBatchQuesRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.UpdUserId);
 var strUpdUserId = objcc_PaperStuBatchQuesRelaEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.Memo);
 var strMemo = objcc_PaperStuBatchQuesRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_PaperStuBatchQuesRela");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PaperStuBatchQuesRelaDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objcc_PaperStuBatchQuesRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_PaperStuBatchQuesRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_PaperStuBatchQuesRelaEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatch  ==  "")
 {
 objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatch = null;
 }
 if (objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatch !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.IdPaperStuBatch);
 var strIdPaperStuBatch = objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatch.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdPaperStuBatch + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.QuestionId !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.QuestionId);
 arrValueListForInsert.Add(objcc_PaperStuBatchQuesRelaEN.QuestionId.ToString());
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.QuestionIndex4Batch !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.QuestionIndex4Batch);
 arrValueListForInsert.Add(objcc_PaperStuBatchQuesRelaEN.QuestionIndex4Batch.ToString());
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.Scores !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.Scores);
 arrValueListForInsert.Add(objcc_PaperStuBatchQuesRelaEN.Scores.ToString());
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.Score !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.Score);
 arrValueListForInsert.Add(objcc_PaperStuBatchQuesRelaEN.Score.ToString());
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.StuAnswerText !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.StuAnswerText);
 var strStuAnswerText = objcc_PaperStuBatchQuesRelaEN.StuAnswerText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStuAnswerText + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.AnswerDate !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.AnswerDate);
 var strAnswerDate = objcc_PaperStuBatchQuesRelaEN.AnswerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerDate + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.AnswerIP !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.AnswerIP);
 var strAnswerIP = objcc_PaperStuBatchQuesRelaEN.AnswerIP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerIP + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.AnswerModeId !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.AnswerModeId);
 var strAnswerModeId = objcc_PaperStuBatchQuesRelaEN.AnswerModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerModeId + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.AnswerMultiOptions !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.AnswerMultiOptions);
 var strAnswerMultiOptions = objcc_PaperStuBatchQuesRelaEN.AnswerMultiOptions.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerMultiOptions + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.AnswerOptionId !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.AnswerOptionId);
 var strAnswerOptionId = objcc_PaperStuBatchQuesRelaEN.AnswerOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerOptionId + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.AnswerTime !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.AnswerTime);
 var strAnswerTime = objcc_PaperStuBatchQuesRelaEN.AnswerTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerTime + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.ApplySendBackDate !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.ApplySendBackDate);
 var strApplySendBackDate = objcc_PaperStuBatchQuesRelaEN.ApplySendBackDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strApplySendBackDate + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.Comment !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.Comment);
 var strComment = objcc_PaperStuBatchQuesRelaEN.Comment.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strComment + "'");
 }
 
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.IsAccessKnowledge);
 arrValueListForInsert.Add("'" + (objcc_PaperStuBatchQuesRelaEN.IsAccessKnowledge  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.IsApplySendBack);
 arrValueListForInsert.Add("'" + (objcc_PaperStuBatchQuesRelaEN.IsApplySendBack  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.IsInErrorQuestion);
 arrValueListForInsert.Add("'" + (objcc_PaperStuBatchQuesRelaEN.IsInErrorQuestion  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.IsLook);
 arrValueListForInsert.Add("'" + (objcc_PaperStuBatchQuesRelaEN.IsLook  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.IsMarking);
 arrValueListForInsert.Add("'" + (objcc_PaperStuBatchQuesRelaEN.IsMarking  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.IsNotProcessTimeout);
 arrValueListForInsert.Add("'" + (objcc_PaperStuBatchQuesRelaEN.IsNotProcessTimeout  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.IsPublish);
 arrValueListForInsert.Add("'" + (objcc_PaperStuBatchQuesRelaEN.IsPublish  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.IsRight);
 arrValueListForInsert.Add("'" + (objcc_PaperStuBatchQuesRelaEN.IsRight  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.IsSave);
 arrValueListForInsert.Add("'" + (objcc_PaperStuBatchQuesRelaEN.IsSave  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.IsSendBack);
 arrValueListForInsert.Add("'" + (objcc_PaperStuBatchQuesRelaEN.IsSendBack  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.IsSubmit);
 arrValueListForInsert.Add("'" + (objcc_PaperStuBatchQuesRelaEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objcc_PaperStuBatchQuesRelaEN.MarkDate !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.MarkDate);
 var strMarkDate = objcc_PaperStuBatchQuesRelaEN.MarkDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMarkDate + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.MarkerId !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.MarkerId);
 var strMarkerId = objcc_PaperStuBatchQuesRelaEN.MarkerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMarkerId + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.OperateTime !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.OperateTime);
 var strOperateTime = objcc_PaperStuBatchQuesRelaEN.OperateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOperateTime + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.RealFinishDate !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.RealFinishDate);
 var strRealFinishDate = objcc_PaperStuBatchQuesRelaEN.RealFinishDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRealFinishDate + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.WorkTypeId !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.WorkTypeId);
 var strWorkTypeId = objcc_PaperStuBatchQuesRelaEN.WorkTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWorkTypeId + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.SchoolYear !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.SchoolYear);
 var strSchoolYear = objcc_PaperStuBatchQuesRelaEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolYear + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.SchoolTerm !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.SchoolTerm);
 var strSchoolTerm = objcc_PaperStuBatchQuesRelaEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolTerm + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.ErrMsg !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.ErrMsg);
 var strErrMsg = objcc_PaperStuBatchQuesRelaEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrMsg + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.CourseId);
 var strCourseId = objcc_PaperStuBatchQuesRelaEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.UpdDate);
 var strUpdDate = objcc_PaperStuBatchQuesRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.UpdUserId);
 var strUpdUserId = objcc_PaperStuBatchQuesRelaEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela.Memo);
 var strMemo = objcc_PaperStuBatchQuesRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_PaperStuBatchQuesRela");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PaperStuBatchQuesRelaDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewcc_PaperStuBatchQuesRelas(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PaperStuBatchQuesRelaDA.GetSpecSQLObj();
strSQL = "Select * from cc_PaperStuBatchQuesRela where IdPaperStuBatchQuesRela = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "cc_PaperStuBatchQuesRela");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngIdPaperStuBatchQuesRela = TransNullToInt(oRow[concc_PaperStuBatchQuesRela.IdPaperStuBatchQuesRela].ToString().Trim());
if (IsExist(lngIdPaperStuBatchQuesRela))
{
 string strResult = "关键字变量值为:" + string.Format("IdPaperStuBatchQuesRela = {0}", lngIdPaperStuBatchQuesRela) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clscc_PaperStuBatchQuesRelaEN._CurrTabName ].NewRow();
objRow[concc_PaperStuBatchQuesRela.IdPaperStuBatch] = oRow[concc_PaperStuBatchQuesRela.IdPaperStuBatch].ToString().Trim(); //学生试卷批次流水号
objRow[concc_PaperStuBatchQuesRela.QuestionId] = oRow[concc_PaperStuBatchQuesRela.QuestionId].ToString().Trim(); //题目Id
objRow[concc_PaperStuBatchQuesRela.QuestionIndex4Batch] = oRow[concc_PaperStuBatchQuesRela.QuestionIndex4Batch].ToString().Trim(); //题序号4批次
objRow[concc_PaperStuBatchQuesRela.Scores] = oRow[concc_PaperStuBatchQuesRela.Scores].ToString().Trim(); //分值
objRow[concc_PaperStuBatchQuesRela.Score] = oRow[concc_PaperStuBatchQuesRela.Score].ToString().Trim(); //得分
objRow[concc_PaperStuBatchQuesRela.StuAnswerText] = oRow[concc_PaperStuBatchQuesRela.StuAnswerText].ToString().Trim(); //学生回答文本
objRow[concc_PaperStuBatchQuesRela.AnswerDate] = oRow[concc_PaperStuBatchQuesRela.AnswerDate].ToString().Trim(); //回答日期
objRow[concc_PaperStuBatchQuesRela.AnswerIP] = oRow[concc_PaperStuBatchQuesRela.AnswerIP].ToString().Trim(); //回答IP
objRow[concc_PaperStuBatchQuesRela.AnswerModeId] = oRow[concc_PaperStuBatchQuesRela.AnswerModeId].ToString().Trim(); //答案模式Id
objRow[concc_PaperStuBatchQuesRela.AnswerMultiOptions] = oRow[concc_PaperStuBatchQuesRela.AnswerMultiOptions].ToString().Trim(); //多选项答案
objRow[concc_PaperStuBatchQuesRela.AnswerOptionId] = oRow[concc_PaperStuBatchQuesRela.AnswerOptionId].ToString().Trim(); //回答选项Id
objRow[concc_PaperStuBatchQuesRela.AnswerTime] = oRow[concc_PaperStuBatchQuesRela.AnswerTime].ToString().Trim(); //回答时间
objRow[concc_PaperStuBatchQuesRela.ApplySendBackDate] = oRow[concc_PaperStuBatchQuesRela.ApplySendBackDate].ToString().Trim(); //申请退回日期
objRow[concc_PaperStuBatchQuesRela.Comment] = oRow[concc_PaperStuBatchQuesRela.Comment].ToString().Trim(); //批注
objRow[concc_PaperStuBatchQuesRela.IsAccessKnowledge] = oRow[concc_PaperStuBatchQuesRela.IsAccessKnowledge].ToString().Trim(); //是否处理知识点
objRow[concc_PaperStuBatchQuesRela.IsApplySendBack] = oRow[concc_PaperStuBatchQuesRela.IsApplySendBack].ToString().Trim(); //是否申请退回
objRow[concc_PaperStuBatchQuesRela.IsInErrorQuestion] = oRow[concc_PaperStuBatchQuesRela.IsInErrorQuestion].ToString().Trim(); //是否进入错题
objRow[concc_PaperStuBatchQuesRela.IsLook] = oRow[concc_PaperStuBatchQuesRela.IsLook].ToString().Trim(); //是否查看
objRow[concc_PaperStuBatchQuesRela.IsMarking] = oRow[concc_PaperStuBatchQuesRela.IsMarking].ToString().Trim(); //是否批阅
objRow[concc_PaperStuBatchQuesRela.IsNotProcessTimeout] = oRow[concc_PaperStuBatchQuesRela.IsNotProcessTimeout].ToString().Trim(); //是否不处理超时
objRow[concc_PaperStuBatchQuesRela.IsPublish] = oRow[concc_PaperStuBatchQuesRela.IsPublish].ToString().Trim(); //是否发布
objRow[concc_PaperStuBatchQuesRela.IsRight] = oRow[concc_PaperStuBatchQuesRela.IsRight].ToString().Trim(); //是否正确
objRow[concc_PaperStuBatchQuesRela.IsSave] = oRow[concc_PaperStuBatchQuesRela.IsSave].ToString().Trim(); //是否保存
objRow[concc_PaperStuBatchQuesRela.IsSendBack] = oRow[concc_PaperStuBatchQuesRela.IsSendBack].ToString().Trim(); //是否退回
objRow[concc_PaperStuBatchQuesRela.IsSubmit] = oRow[concc_PaperStuBatchQuesRela.IsSubmit].ToString().Trim(); //是否提交
objRow[concc_PaperStuBatchQuesRela.MarkDate] = oRow[concc_PaperStuBatchQuesRela.MarkDate].ToString().Trim(); //打分日期
objRow[concc_PaperStuBatchQuesRela.MarkerId] = oRow[concc_PaperStuBatchQuesRela.MarkerId].ToString().Trim(); //打分者
objRow[concc_PaperStuBatchQuesRela.OperateTime] = oRow[concc_PaperStuBatchQuesRela.OperateTime].ToString().Trim(); //操作时间
objRow[concc_PaperStuBatchQuesRela.RealFinishDate] = oRow[concc_PaperStuBatchQuesRela.RealFinishDate].ToString().Trim(); //实际完成日期
objRow[concc_PaperStuBatchQuesRela.WorkTypeId] = oRow[concc_PaperStuBatchQuesRela.WorkTypeId].ToString().Trim(); //作业类型Id
objRow[concc_PaperStuBatchQuesRela.SchoolYear] = oRow[concc_PaperStuBatchQuesRela.SchoolYear].ToString().Trim(); //学年
objRow[concc_PaperStuBatchQuesRela.SchoolTerm] = oRow[concc_PaperStuBatchQuesRela.SchoolTerm].ToString().Trim(); //学期
objRow[concc_PaperStuBatchQuesRela.ErrMsg] = oRow[concc_PaperStuBatchQuesRela.ErrMsg].ToString().Trim(); //错误信息
objRow[concc_PaperStuBatchQuesRela.CourseId] = oRow[concc_PaperStuBatchQuesRela.CourseId].ToString().Trim(); //课程Id
objRow[concc_PaperStuBatchQuesRela.UpdDate] = oRow[concc_PaperStuBatchQuesRela.UpdDate].ToString().Trim(); //修改日期
objRow[concc_PaperStuBatchQuesRela.UpdUserId] = oRow[concc_PaperStuBatchQuesRela.UpdUserId].ToString().Trim(); //修改用户Id
objRow[concc_PaperStuBatchQuesRela.Memo] = oRow[concc_PaperStuBatchQuesRela.Memo].ToString().Trim(); //备注
 objDS.Tables[clscc_PaperStuBatchQuesRelaEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clscc_PaperStuBatchQuesRelaEN._CurrTabName);
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
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN)
{
 objcc_PaperStuBatchQuesRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_PaperStuBatchQuesRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_PaperStuBatchQuesRelaEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PaperStuBatchQuesRelaDA.GetSpecSQLObj();
strSQL = "Select * from cc_PaperStuBatchQuesRela where IdPaperStuBatchQuesRela = " + ""+ objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatchQuesRela+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clscc_PaperStuBatchQuesRelaEN._CurrTabName);
if (objDS.Tables[clscc_PaperStuBatchQuesRelaEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:IdPaperStuBatchQuesRela = " + ""+ objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatchQuesRela+"");
return false;
}
objRow = objDS.Tables[clscc_PaperStuBatchQuesRelaEN._CurrTabName].Rows[0];
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.IdPaperStuBatch))
 {
objRow[concc_PaperStuBatchQuesRela.IdPaperStuBatch] = objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatch; //学生试卷批次流水号
 }
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.QuestionId))
 {
objRow[concc_PaperStuBatchQuesRela.QuestionId] = objcc_PaperStuBatchQuesRelaEN.QuestionId; //题目Id
 }
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.QuestionIndex4Batch))
 {
objRow[concc_PaperStuBatchQuesRela.QuestionIndex4Batch] = objcc_PaperStuBatchQuesRelaEN.QuestionIndex4Batch; //题序号4批次
 }
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.Scores))
 {
objRow[concc_PaperStuBatchQuesRela.Scores] = objcc_PaperStuBatchQuesRelaEN.Scores; //分值
 }
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.Score))
 {
objRow[concc_PaperStuBatchQuesRela.Score] = objcc_PaperStuBatchQuesRelaEN.Score; //得分
 }
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.StuAnswerText))
 {
objRow[concc_PaperStuBatchQuesRela.StuAnswerText] = objcc_PaperStuBatchQuesRelaEN.StuAnswerText; //学生回答文本
 }
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.AnswerDate))
 {
objRow[concc_PaperStuBatchQuesRela.AnswerDate] = objcc_PaperStuBatchQuesRelaEN.AnswerDate; //回答日期
 }
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.AnswerIP))
 {
objRow[concc_PaperStuBatchQuesRela.AnswerIP] = objcc_PaperStuBatchQuesRelaEN.AnswerIP; //回答IP
 }
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.AnswerModeId))
 {
objRow[concc_PaperStuBatchQuesRela.AnswerModeId] = objcc_PaperStuBatchQuesRelaEN.AnswerModeId; //答案模式Id
 }
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.AnswerMultiOptions))
 {
objRow[concc_PaperStuBatchQuesRela.AnswerMultiOptions] = objcc_PaperStuBatchQuesRelaEN.AnswerMultiOptions; //多选项答案
 }
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.AnswerOptionId))
 {
objRow[concc_PaperStuBatchQuesRela.AnswerOptionId] = objcc_PaperStuBatchQuesRelaEN.AnswerOptionId; //回答选项Id
 }
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.AnswerTime))
 {
objRow[concc_PaperStuBatchQuesRela.AnswerTime] = objcc_PaperStuBatchQuesRelaEN.AnswerTime; //回答时间
 }
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.ApplySendBackDate))
 {
objRow[concc_PaperStuBatchQuesRela.ApplySendBackDate] = objcc_PaperStuBatchQuesRelaEN.ApplySendBackDate; //申请退回日期
 }
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.Comment))
 {
objRow[concc_PaperStuBatchQuesRela.Comment] = objcc_PaperStuBatchQuesRelaEN.Comment; //批注
 }
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.IsAccessKnowledge))
 {
objRow[concc_PaperStuBatchQuesRela.IsAccessKnowledge] = objcc_PaperStuBatchQuesRelaEN.IsAccessKnowledge; //是否处理知识点
 }
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.IsApplySendBack))
 {
objRow[concc_PaperStuBatchQuesRela.IsApplySendBack] = objcc_PaperStuBatchQuesRelaEN.IsApplySendBack; //是否申请退回
 }
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.IsInErrorQuestion))
 {
objRow[concc_PaperStuBatchQuesRela.IsInErrorQuestion] = objcc_PaperStuBatchQuesRelaEN.IsInErrorQuestion; //是否进入错题
 }
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.IsLook))
 {
objRow[concc_PaperStuBatchQuesRela.IsLook] = objcc_PaperStuBatchQuesRelaEN.IsLook; //是否查看
 }
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.IsMarking))
 {
objRow[concc_PaperStuBatchQuesRela.IsMarking] = objcc_PaperStuBatchQuesRelaEN.IsMarking; //是否批阅
 }
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.IsNotProcessTimeout))
 {
objRow[concc_PaperStuBatchQuesRela.IsNotProcessTimeout] = objcc_PaperStuBatchQuesRelaEN.IsNotProcessTimeout; //是否不处理超时
 }
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.IsPublish))
 {
objRow[concc_PaperStuBatchQuesRela.IsPublish] = objcc_PaperStuBatchQuesRelaEN.IsPublish; //是否发布
 }
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.IsRight))
 {
objRow[concc_PaperStuBatchQuesRela.IsRight] = objcc_PaperStuBatchQuesRelaEN.IsRight; //是否正确
 }
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.IsSave))
 {
objRow[concc_PaperStuBatchQuesRela.IsSave] = objcc_PaperStuBatchQuesRelaEN.IsSave; //是否保存
 }
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.IsSendBack))
 {
objRow[concc_PaperStuBatchQuesRela.IsSendBack] = objcc_PaperStuBatchQuesRelaEN.IsSendBack; //是否退回
 }
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.IsSubmit))
 {
objRow[concc_PaperStuBatchQuesRela.IsSubmit] = objcc_PaperStuBatchQuesRelaEN.IsSubmit; //是否提交
 }
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.MarkDate))
 {
objRow[concc_PaperStuBatchQuesRela.MarkDate] = objcc_PaperStuBatchQuesRelaEN.MarkDate; //打分日期
 }
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.MarkerId))
 {
objRow[concc_PaperStuBatchQuesRela.MarkerId] = objcc_PaperStuBatchQuesRelaEN.MarkerId; //打分者
 }
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.OperateTime))
 {
objRow[concc_PaperStuBatchQuesRela.OperateTime] = objcc_PaperStuBatchQuesRelaEN.OperateTime; //操作时间
 }
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.RealFinishDate))
 {
objRow[concc_PaperStuBatchQuesRela.RealFinishDate] = objcc_PaperStuBatchQuesRelaEN.RealFinishDate; //实际完成日期
 }
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.WorkTypeId))
 {
objRow[concc_PaperStuBatchQuesRela.WorkTypeId] = objcc_PaperStuBatchQuesRelaEN.WorkTypeId; //作业类型Id
 }
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.SchoolYear))
 {
objRow[concc_PaperStuBatchQuesRela.SchoolYear] = objcc_PaperStuBatchQuesRelaEN.SchoolYear; //学年
 }
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.SchoolTerm))
 {
objRow[concc_PaperStuBatchQuesRela.SchoolTerm] = objcc_PaperStuBatchQuesRelaEN.SchoolTerm; //学期
 }
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.ErrMsg))
 {
objRow[concc_PaperStuBatchQuesRela.ErrMsg] = objcc_PaperStuBatchQuesRelaEN.ErrMsg; //错误信息
 }
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.CourseId))
 {
objRow[concc_PaperStuBatchQuesRela.CourseId] = objcc_PaperStuBatchQuesRelaEN.CourseId; //课程Id
 }
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.UpdDate))
 {
objRow[concc_PaperStuBatchQuesRela.UpdDate] = objcc_PaperStuBatchQuesRelaEN.UpdDate; //修改日期
 }
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.UpdUserId))
 {
objRow[concc_PaperStuBatchQuesRela.UpdUserId] = objcc_PaperStuBatchQuesRelaEN.UpdUserId; //修改用户Id
 }
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.Memo))
 {
objRow[concc_PaperStuBatchQuesRela.Memo] = objcc_PaperStuBatchQuesRelaEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clscc_PaperStuBatchQuesRelaEN._CurrTabName);
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
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN)
{
 objcc_PaperStuBatchQuesRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_PaperStuBatchQuesRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_PaperStuBatchQuesRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PaperStuBatchQuesRelaDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update cc_PaperStuBatchQuesRela Set ");
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.IdPaperStuBatch))
 {
 if (objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatch  ==  "")
 {
 objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatch = null;
 }
 if (objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatch !=  null)
 {
 var strIdPaperStuBatch = objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatch.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdPaperStuBatch, concc_PaperStuBatchQuesRela.IdPaperStuBatch); //学生试卷批次流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela.IdPaperStuBatch); //学生试卷批次流水号
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.QuestionId))
 {
 if (objcc_PaperStuBatchQuesRelaEN.QuestionId !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_PaperStuBatchQuesRelaEN.QuestionId, concc_PaperStuBatchQuesRela.QuestionId); //题目Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela.QuestionId); //题目Id
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.QuestionIndex4Batch))
 {
 if (objcc_PaperStuBatchQuesRelaEN.QuestionIndex4Batch !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_PaperStuBatchQuesRelaEN.QuestionIndex4Batch, concc_PaperStuBatchQuesRela.QuestionIndex4Batch); //题序号4批次
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela.QuestionIndex4Batch); //题序号4批次
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.Scores))
 {
 if (objcc_PaperStuBatchQuesRelaEN.Scores !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_PaperStuBatchQuesRelaEN.Scores, concc_PaperStuBatchQuesRela.Scores); //分值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela.Scores); //分值
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.Score))
 {
 if (objcc_PaperStuBatchQuesRelaEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_PaperStuBatchQuesRelaEN.Score, concc_PaperStuBatchQuesRela.Score); //得分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela.Score); //得分
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.StuAnswerText))
 {
 if (objcc_PaperStuBatchQuesRelaEN.StuAnswerText !=  null)
 {
 var strStuAnswerText = objcc_PaperStuBatchQuesRelaEN.StuAnswerText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStuAnswerText, concc_PaperStuBatchQuesRela.StuAnswerText); //学生回答文本
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela.StuAnswerText); //学生回答文本
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.AnswerDate))
 {
 if (objcc_PaperStuBatchQuesRelaEN.AnswerDate !=  null)
 {
 var strAnswerDate = objcc_PaperStuBatchQuesRelaEN.AnswerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerDate, concc_PaperStuBatchQuesRela.AnswerDate); //回答日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela.AnswerDate); //回答日期
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.AnswerIP))
 {
 if (objcc_PaperStuBatchQuesRelaEN.AnswerIP !=  null)
 {
 var strAnswerIP = objcc_PaperStuBatchQuesRelaEN.AnswerIP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerIP, concc_PaperStuBatchQuesRela.AnswerIP); //回答IP
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela.AnswerIP); //回答IP
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.AnswerModeId))
 {
 if (objcc_PaperStuBatchQuesRelaEN.AnswerModeId !=  null)
 {
 var strAnswerModeId = objcc_PaperStuBatchQuesRelaEN.AnswerModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerModeId, concc_PaperStuBatchQuesRela.AnswerModeId); //答案模式Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela.AnswerModeId); //答案模式Id
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.AnswerMultiOptions))
 {
 if (objcc_PaperStuBatchQuesRelaEN.AnswerMultiOptions !=  null)
 {
 var strAnswerMultiOptions = objcc_PaperStuBatchQuesRelaEN.AnswerMultiOptions.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerMultiOptions, concc_PaperStuBatchQuesRela.AnswerMultiOptions); //多选项答案
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela.AnswerMultiOptions); //多选项答案
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.AnswerOptionId))
 {
 if (objcc_PaperStuBatchQuesRelaEN.AnswerOptionId !=  null)
 {
 var strAnswerOptionId = objcc_PaperStuBatchQuesRelaEN.AnswerOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerOptionId, concc_PaperStuBatchQuesRela.AnswerOptionId); //回答选项Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela.AnswerOptionId); //回答选项Id
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.AnswerTime))
 {
 if (objcc_PaperStuBatchQuesRelaEN.AnswerTime !=  null)
 {
 var strAnswerTime = objcc_PaperStuBatchQuesRelaEN.AnswerTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerTime, concc_PaperStuBatchQuesRela.AnswerTime); //回答时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela.AnswerTime); //回答时间
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.ApplySendBackDate))
 {
 if (objcc_PaperStuBatchQuesRelaEN.ApplySendBackDate !=  null)
 {
 var strApplySendBackDate = objcc_PaperStuBatchQuesRelaEN.ApplySendBackDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strApplySendBackDate, concc_PaperStuBatchQuesRela.ApplySendBackDate); //申请退回日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela.ApplySendBackDate); //申请退回日期
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.Comment))
 {
 if (objcc_PaperStuBatchQuesRelaEN.Comment !=  null)
 {
 var strComment = objcc_PaperStuBatchQuesRelaEN.Comment.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strComment, concc_PaperStuBatchQuesRela.Comment); //批注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela.Comment); //批注
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.IsAccessKnowledge))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_PaperStuBatchQuesRelaEN.IsAccessKnowledge == true?"1":"0", concc_PaperStuBatchQuesRela.IsAccessKnowledge); //是否处理知识点
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.IsApplySendBack))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_PaperStuBatchQuesRelaEN.IsApplySendBack == true?"1":"0", concc_PaperStuBatchQuesRela.IsApplySendBack); //是否申请退回
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.IsInErrorQuestion))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_PaperStuBatchQuesRelaEN.IsInErrorQuestion == true?"1":"0", concc_PaperStuBatchQuesRela.IsInErrorQuestion); //是否进入错题
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.IsLook))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_PaperStuBatchQuesRelaEN.IsLook == true?"1":"0", concc_PaperStuBatchQuesRela.IsLook); //是否查看
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.IsMarking))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_PaperStuBatchQuesRelaEN.IsMarking == true?"1":"0", concc_PaperStuBatchQuesRela.IsMarking); //是否批阅
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.IsNotProcessTimeout))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_PaperStuBatchQuesRelaEN.IsNotProcessTimeout == true?"1":"0", concc_PaperStuBatchQuesRela.IsNotProcessTimeout); //是否不处理超时
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.IsPublish))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_PaperStuBatchQuesRelaEN.IsPublish == true?"1":"0", concc_PaperStuBatchQuesRela.IsPublish); //是否发布
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.IsRight))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_PaperStuBatchQuesRelaEN.IsRight == true?"1":"0", concc_PaperStuBatchQuesRela.IsRight); //是否正确
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.IsSave))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_PaperStuBatchQuesRelaEN.IsSave == true?"1":"0", concc_PaperStuBatchQuesRela.IsSave); //是否保存
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.IsSendBack))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_PaperStuBatchQuesRelaEN.IsSendBack == true?"1":"0", concc_PaperStuBatchQuesRela.IsSendBack); //是否退回
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_PaperStuBatchQuesRelaEN.IsSubmit == true?"1":"0", concc_PaperStuBatchQuesRela.IsSubmit); //是否提交
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.MarkDate))
 {
 if (objcc_PaperStuBatchQuesRelaEN.MarkDate !=  null)
 {
 var strMarkDate = objcc_PaperStuBatchQuesRelaEN.MarkDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMarkDate, concc_PaperStuBatchQuesRela.MarkDate); //打分日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela.MarkDate); //打分日期
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.MarkerId))
 {
 if (objcc_PaperStuBatchQuesRelaEN.MarkerId !=  null)
 {
 var strMarkerId = objcc_PaperStuBatchQuesRelaEN.MarkerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMarkerId, concc_PaperStuBatchQuesRela.MarkerId); //打分者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela.MarkerId); //打分者
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.OperateTime))
 {
 if (objcc_PaperStuBatchQuesRelaEN.OperateTime !=  null)
 {
 var strOperateTime = objcc_PaperStuBatchQuesRelaEN.OperateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOperateTime, concc_PaperStuBatchQuesRela.OperateTime); //操作时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela.OperateTime); //操作时间
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.RealFinishDate))
 {
 if (objcc_PaperStuBatchQuesRelaEN.RealFinishDate !=  null)
 {
 var strRealFinishDate = objcc_PaperStuBatchQuesRelaEN.RealFinishDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRealFinishDate, concc_PaperStuBatchQuesRela.RealFinishDate); //实际完成日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela.RealFinishDate); //实际完成日期
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.WorkTypeId))
 {
 if (objcc_PaperStuBatchQuesRelaEN.WorkTypeId !=  null)
 {
 var strWorkTypeId = objcc_PaperStuBatchQuesRelaEN.WorkTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWorkTypeId, concc_PaperStuBatchQuesRela.WorkTypeId); //作业类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela.WorkTypeId); //作业类型Id
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.SchoolYear))
 {
 if (objcc_PaperStuBatchQuesRelaEN.SchoolYear !=  null)
 {
 var strSchoolYear = objcc_PaperStuBatchQuesRelaEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchoolYear, concc_PaperStuBatchQuesRela.SchoolYear); //学年
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela.SchoolYear); //学年
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.SchoolTerm))
 {
 if (objcc_PaperStuBatchQuesRelaEN.SchoolTerm !=  null)
 {
 var strSchoolTerm = objcc_PaperStuBatchQuesRelaEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchoolTerm, concc_PaperStuBatchQuesRela.SchoolTerm); //学期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela.SchoolTerm); //学期
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.ErrMsg))
 {
 if (objcc_PaperStuBatchQuesRelaEN.ErrMsg !=  null)
 {
 var strErrMsg = objcc_PaperStuBatchQuesRelaEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strErrMsg, concc_PaperStuBatchQuesRela.ErrMsg); //错误信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela.ErrMsg); //错误信息
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.CourseId))
 {
 if (objcc_PaperStuBatchQuesRelaEN.CourseId !=  null)
 {
 var strCourseId = objcc_PaperStuBatchQuesRelaEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, concc_PaperStuBatchQuesRela.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela.CourseId); //课程Id
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.UpdDate))
 {
 if (objcc_PaperStuBatchQuesRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objcc_PaperStuBatchQuesRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, concc_PaperStuBatchQuesRela.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela.UpdDate); //修改日期
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.UpdUserId))
 {
 if (objcc_PaperStuBatchQuesRelaEN.UpdUserId !=  null)
 {
 var strUpdUserId = objcc_PaperStuBatchQuesRelaEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, concc_PaperStuBatchQuesRela.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela.UpdUserId); //修改用户Id
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.Memo))
 {
 if (objcc_PaperStuBatchQuesRelaEN.Memo !=  null)
 {
 var strMemo = objcc_PaperStuBatchQuesRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, concc_PaperStuBatchQuesRela.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdPaperStuBatchQuesRela = {0}", objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatchQuesRela); 
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
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, string strCondition)
{
 objcc_PaperStuBatchQuesRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_PaperStuBatchQuesRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_PaperStuBatchQuesRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PaperStuBatchQuesRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update cc_PaperStuBatchQuesRela Set ");
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.IdPaperStuBatch))
 {
 if (objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatch  ==  "")
 {
 objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatch = null;
 }
 if (objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatch !=  null)
 {
 var strIdPaperStuBatch = objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatch.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdPaperStuBatch = '{0}',", strIdPaperStuBatch); //学生试卷批次流水号
 }
 else
 {
 sbSQL.Append(" IdPaperStuBatch = null,"); //学生试卷批次流水号
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.QuestionId))
 {
 if (objcc_PaperStuBatchQuesRelaEN.QuestionId !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_PaperStuBatchQuesRelaEN.QuestionId, concc_PaperStuBatchQuesRela.QuestionId); //题目Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela.QuestionId); //题目Id
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.QuestionIndex4Batch))
 {
 if (objcc_PaperStuBatchQuesRelaEN.QuestionIndex4Batch !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_PaperStuBatchQuesRelaEN.QuestionIndex4Batch, concc_PaperStuBatchQuesRela.QuestionIndex4Batch); //题序号4批次
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela.QuestionIndex4Batch); //题序号4批次
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.Scores))
 {
 if (objcc_PaperStuBatchQuesRelaEN.Scores !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_PaperStuBatchQuesRelaEN.Scores, concc_PaperStuBatchQuesRela.Scores); //分值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela.Scores); //分值
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.Score))
 {
 if (objcc_PaperStuBatchQuesRelaEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_PaperStuBatchQuesRelaEN.Score, concc_PaperStuBatchQuesRela.Score); //得分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela.Score); //得分
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.StuAnswerText))
 {
 if (objcc_PaperStuBatchQuesRelaEN.StuAnswerText !=  null)
 {
 var strStuAnswerText = objcc_PaperStuBatchQuesRelaEN.StuAnswerText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StuAnswerText = '{0}',", strStuAnswerText); //学生回答文本
 }
 else
 {
 sbSQL.Append(" StuAnswerText = null,"); //学生回答文本
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.AnswerDate))
 {
 if (objcc_PaperStuBatchQuesRelaEN.AnswerDate !=  null)
 {
 var strAnswerDate = objcc_PaperStuBatchQuesRelaEN.AnswerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerDate = '{0}',", strAnswerDate); //回答日期
 }
 else
 {
 sbSQL.Append(" AnswerDate = null,"); //回答日期
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.AnswerIP))
 {
 if (objcc_PaperStuBatchQuesRelaEN.AnswerIP !=  null)
 {
 var strAnswerIP = objcc_PaperStuBatchQuesRelaEN.AnswerIP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerIP = '{0}',", strAnswerIP); //回答IP
 }
 else
 {
 sbSQL.Append(" AnswerIP = null,"); //回答IP
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.AnswerModeId))
 {
 if (objcc_PaperStuBatchQuesRelaEN.AnswerModeId !=  null)
 {
 var strAnswerModeId = objcc_PaperStuBatchQuesRelaEN.AnswerModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerModeId = '{0}',", strAnswerModeId); //答案模式Id
 }
 else
 {
 sbSQL.Append(" AnswerModeId = null,"); //答案模式Id
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.AnswerMultiOptions))
 {
 if (objcc_PaperStuBatchQuesRelaEN.AnswerMultiOptions !=  null)
 {
 var strAnswerMultiOptions = objcc_PaperStuBatchQuesRelaEN.AnswerMultiOptions.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerMultiOptions = '{0}',", strAnswerMultiOptions); //多选项答案
 }
 else
 {
 sbSQL.Append(" AnswerMultiOptions = null,"); //多选项答案
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.AnswerOptionId))
 {
 if (objcc_PaperStuBatchQuesRelaEN.AnswerOptionId !=  null)
 {
 var strAnswerOptionId = objcc_PaperStuBatchQuesRelaEN.AnswerOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerOptionId = '{0}',", strAnswerOptionId); //回答选项Id
 }
 else
 {
 sbSQL.Append(" AnswerOptionId = null,"); //回答选项Id
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.AnswerTime))
 {
 if (objcc_PaperStuBatchQuesRelaEN.AnswerTime !=  null)
 {
 var strAnswerTime = objcc_PaperStuBatchQuesRelaEN.AnswerTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerTime = '{0}',", strAnswerTime); //回答时间
 }
 else
 {
 sbSQL.Append(" AnswerTime = null,"); //回答时间
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.ApplySendBackDate))
 {
 if (objcc_PaperStuBatchQuesRelaEN.ApplySendBackDate !=  null)
 {
 var strApplySendBackDate = objcc_PaperStuBatchQuesRelaEN.ApplySendBackDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ApplySendBackDate = '{0}',", strApplySendBackDate); //申请退回日期
 }
 else
 {
 sbSQL.Append(" ApplySendBackDate = null,"); //申请退回日期
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.Comment))
 {
 if (objcc_PaperStuBatchQuesRelaEN.Comment !=  null)
 {
 var strComment = objcc_PaperStuBatchQuesRelaEN.Comment.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Comment = '{0}',", strComment); //批注
 }
 else
 {
 sbSQL.Append(" Comment = null,"); //批注
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.IsAccessKnowledge))
 {
 sbSQL.AppendFormat(" IsAccessKnowledge = '{0}',", objcc_PaperStuBatchQuesRelaEN.IsAccessKnowledge == true?"1":"0"); //是否处理知识点
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.IsApplySendBack))
 {
 sbSQL.AppendFormat(" IsApplySendBack = '{0}',", objcc_PaperStuBatchQuesRelaEN.IsApplySendBack == true?"1":"0"); //是否申请退回
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.IsInErrorQuestion))
 {
 sbSQL.AppendFormat(" IsInErrorQuestion = '{0}',", objcc_PaperStuBatchQuesRelaEN.IsInErrorQuestion == true?"1":"0"); //是否进入错题
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.IsLook))
 {
 sbSQL.AppendFormat(" IsLook = '{0}',", objcc_PaperStuBatchQuesRelaEN.IsLook == true?"1":"0"); //是否查看
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.IsMarking))
 {
 sbSQL.AppendFormat(" IsMarking = '{0}',", objcc_PaperStuBatchQuesRelaEN.IsMarking == true?"1":"0"); //是否批阅
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.IsNotProcessTimeout))
 {
 sbSQL.AppendFormat(" IsNotProcessTimeout = '{0}',", objcc_PaperStuBatchQuesRelaEN.IsNotProcessTimeout == true?"1":"0"); //是否不处理超时
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.IsPublish))
 {
 sbSQL.AppendFormat(" IsPublish = '{0}',", objcc_PaperStuBatchQuesRelaEN.IsPublish == true?"1":"0"); //是否发布
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.IsRight))
 {
 sbSQL.AppendFormat(" IsRight = '{0}',", objcc_PaperStuBatchQuesRelaEN.IsRight == true?"1":"0"); //是否正确
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.IsSave))
 {
 sbSQL.AppendFormat(" IsSave = '{0}',", objcc_PaperStuBatchQuesRelaEN.IsSave == true?"1":"0"); //是否保存
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.IsSendBack))
 {
 sbSQL.AppendFormat(" IsSendBack = '{0}',", objcc_PaperStuBatchQuesRelaEN.IsSendBack == true?"1":"0"); //是否退回
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objcc_PaperStuBatchQuesRelaEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.MarkDate))
 {
 if (objcc_PaperStuBatchQuesRelaEN.MarkDate !=  null)
 {
 var strMarkDate = objcc_PaperStuBatchQuesRelaEN.MarkDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MarkDate = '{0}',", strMarkDate); //打分日期
 }
 else
 {
 sbSQL.Append(" MarkDate = null,"); //打分日期
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.MarkerId))
 {
 if (objcc_PaperStuBatchQuesRelaEN.MarkerId !=  null)
 {
 var strMarkerId = objcc_PaperStuBatchQuesRelaEN.MarkerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MarkerId = '{0}',", strMarkerId); //打分者
 }
 else
 {
 sbSQL.Append(" MarkerId = null,"); //打分者
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.OperateTime))
 {
 if (objcc_PaperStuBatchQuesRelaEN.OperateTime !=  null)
 {
 var strOperateTime = objcc_PaperStuBatchQuesRelaEN.OperateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OperateTime = '{0}',", strOperateTime); //操作时间
 }
 else
 {
 sbSQL.Append(" OperateTime = null,"); //操作时间
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.RealFinishDate))
 {
 if (objcc_PaperStuBatchQuesRelaEN.RealFinishDate !=  null)
 {
 var strRealFinishDate = objcc_PaperStuBatchQuesRelaEN.RealFinishDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RealFinishDate = '{0}',", strRealFinishDate); //实际完成日期
 }
 else
 {
 sbSQL.Append(" RealFinishDate = null,"); //实际完成日期
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.WorkTypeId))
 {
 if (objcc_PaperStuBatchQuesRelaEN.WorkTypeId !=  null)
 {
 var strWorkTypeId = objcc_PaperStuBatchQuesRelaEN.WorkTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WorkTypeId = '{0}',", strWorkTypeId); //作业类型Id
 }
 else
 {
 sbSQL.Append(" WorkTypeId = null,"); //作业类型Id
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.SchoolYear))
 {
 if (objcc_PaperStuBatchQuesRelaEN.SchoolYear !=  null)
 {
 var strSchoolYear = objcc_PaperStuBatchQuesRelaEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolYear = '{0}',", strSchoolYear); //学年
 }
 else
 {
 sbSQL.Append(" SchoolYear = null,"); //学年
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.SchoolTerm))
 {
 if (objcc_PaperStuBatchQuesRelaEN.SchoolTerm !=  null)
 {
 var strSchoolTerm = objcc_PaperStuBatchQuesRelaEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolTerm = '{0}',", strSchoolTerm); //学期
 }
 else
 {
 sbSQL.Append(" SchoolTerm = null,"); //学期
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.ErrMsg))
 {
 if (objcc_PaperStuBatchQuesRelaEN.ErrMsg !=  null)
 {
 var strErrMsg = objcc_PaperStuBatchQuesRelaEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ErrMsg = '{0}',", strErrMsg); //错误信息
 }
 else
 {
 sbSQL.Append(" ErrMsg = null,"); //错误信息
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.CourseId))
 {
 if (objcc_PaperStuBatchQuesRelaEN.CourseId !=  null)
 {
 var strCourseId = objcc_PaperStuBatchQuesRelaEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.UpdDate))
 {
 if (objcc_PaperStuBatchQuesRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objcc_PaperStuBatchQuesRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.UpdUserId))
 {
 if (objcc_PaperStuBatchQuesRelaEN.UpdUserId !=  null)
 {
 var strUpdUserId = objcc_PaperStuBatchQuesRelaEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.Memo))
 {
 if (objcc_PaperStuBatchQuesRelaEN.Memo !=  null)
 {
 var strMemo = objcc_PaperStuBatchQuesRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objcc_PaperStuBatchQuesRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_PaperStuBatchQuesRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_PaperStuBatchQuesRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PaperStuBatchQuesRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update cc_PaperStuBatchQuesRela Set ");
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.IdPaperStuBatch))
 {
 if (objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatch  ==  "")
 {
 objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatch = null;
 }
 if (objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatch !=  null)
 {
 var strIdPaperStuBatch = objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatch.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdPaperStuBatch = '{0}',", strIdPaperStuBatch); //学生试卷批次流水号
 }
 else
 {
 sbSQL.Append(" IdPaperStuBatch = null,"); //学生试卷批次流水号
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.QuestionId))
 {
 if (objcc_PaperStuBatchQuesRelaEN.QuestionId !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_PaperStuBatchQuesRelaEN.QuestionId, concc_PaperStuBatchQuesRela.QuestionId); //题目Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela.QuestionId); //题目Id
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.QuestionIndex4Batch))
 {
 if (objcc_PaperStuBatchQuesRelaEN.QuestionIndex4Batch !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_PaperStuBatchQuesRelaEN.QuestionIndex4Batch, concc_PaperStuBatchQuesRela.QuestionIndex4Batch); //题序号4批次
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela.QuestionIndex4Batch); //题序号4批次
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.Scores))
 {
 if (objcc_PaperStuBatchQuesRelaEN.Scores !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_PaperStuBatchQuesRelaEN.Scores, concc_PaperStuBatchQuesRela.Scores); //分值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela.Scores); //分值
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.Score))
 {
 if (objcc_PaperStuBatchQuesRelaEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_PaperStuBatchQuesRelaEN.Score, concc_PaperStuBatchQuesRela.Score); //得分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela.Score); //得分
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.StuAnswerText))
 {
 if (objcc_PaperStuBatchQuesRelaEN.StuAnswerText !=  null)
 {
 var strStuAnswerText = objcc_PaperStuBatchQuesRelaEN.StuAnswerText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StuAnswerText = '{0}',", strStuAnswerText); //学生回答文本
 }
 else
 {
 sbSQL.Append(" StuAnswerText = null,"); //学生回答文本
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.AnswerDate))
 {
 if (objcc_PaperStuBatchQuesRelaEN.AnswerDate !=  null)
 {
 var strAnswerDate = objcc_PaperStuBatchQuesRelaEN.AnswerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerDate = '{0}',", strAnswerDate); //回答日期
 }
 else
 {
 sbSQL.Append(" AnswerDate = null,"); //回答日期
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.AnswerIP))
 {
 if (objcc_PaperStuBatchQuesRelaEN.AnswerIP !=  null)
 {
 var strAnswerIP = objcc_PaperStuBatchQuesRelaEN.AnswerIP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerIP = '{0}',", strAnswerIP); //回答IP
 }
 else
 {
 sbSQL.Append(" AnswerIP = null,"); //回答IP
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.AnswerModeId))
 {
 if (objcc_PaperStuBatchQuesRelaEN.AnswerModeId !=  null)
 {
 var strAnswerModeId = objcc_PaperStuBatchQuesRelaEN.AnswerModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerModeId = '{0}',", strAnswerModeId); //答案模式Id
 }
 else
 {
 sbSQL.Append(" AnswerModeId = null,"); //答案模式Id
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.AnswerMultiOptions))
 {
 if (objcc_PaperStuBatchQuesRelaEN.AnswerMultiOptions !=  null)
 {
 var strAnswerMultiOptions = objcc_PaperStuBatchQuesRelaEN.AnswerMultiOptions.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerMultiOptions = '{0}',", strAnswerMultiOptions); //多选项答案
 }
 else
 {
 sbSQL.Append(" AnswerMultiOptions = null,"); //多选项答案
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.AnswerOptionId))
 {
 if (objcc_PaperStuBatchQuesRelaEN.AnswerOptionId !=  null)
 {
 var strAnswerOptionId = objcc_PaperStuBatchQuesRelaEN.AnswerOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerOptionId = '{0}',", strAnswerOptionId); //回答选项Id
 }
 else
 {
 sbSQL.Append(" AnswerOptionId = null,"); //回答选项Id
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.AnswerTime))
 {
 if (objcc_PaperStuBatchQuesRelaEN.AnswerTime !=  null)
 {
 var strAnswerTime = objcc_PaperStuBatchQuesRelaEN.AnswerTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerTime = '{0}',", strAnswerTime); //回答时间
 }
 else
 {
 sbSQL.Append(" AnswerTime = null,"); //回答时间
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.ApplySendBackDate))
 {
 if (objcc_PaperStuBatchQuesRelaEN.ApplySendBackDate !=  null)
 {
 var strApplySendBackDate = objcc_PaperStuBatchQuesRelaEN.ApplySendBackDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ApplySendBackDate = '{0}',", strApplySendBackDate); //申请退回日期
 }
 else
 {
 sbSQL.Append(" ApplySendBackDate = null,"); //申请退回日期
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.Comment))
 {
 if (objcc_PaperStuBatchQuesRelaEN.Comment !=  null)
 {
 var strComment = objcc_PaperStuBatchQuesRelaEN.Comment.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Comment = '{0}',", strComment); //批注
 }
 else
 {
 sbSQL.Append(" Comment = null,"); //批注
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.IsAccessKnowledge))
 {
 sbSQL.AppendFormat(" IsAccessKnowledge = '{0}',", objcc_PaperStuBatchQuesRelaEN.IsAccessKnowledge == true?"1":"0"); //是否处理知识点
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.IsApplySendBack))
 {
 sbSQL.AppendFormat(" IsApplySendBack = '{0}',", objcc_PaperStuBatchQuesRelaEN.IsApplySendBack == true?"1":"0"); //是否申请退回
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.IsInErrorQuestion))
 {
 sbSQL.AppendFormat(" IsInErrorQuestion = '{0}',", objcc_PaperStuBatchQuesRelaEN.IsInErrorQuestion == true?"1":"0"); //是否进入错题
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.IsLook))
 {
 sbSQL.AppendFormat(" IsLook = '{0}',", objcc_PaperStuBatchQuesRelaEN.IsLook == true?"1":"0"); //是否查看
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.IsMarking))
 {
 sbSQL.AppendFormat(" IsMarking = '{0}',", objcc_PaperStuBatchQuesRelaEN.IsMarking == true?"1":"0"); //是否批阅
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.IsNotProcessTimeout))
 {
 sbSQL.AppendFormat(" IsNotProcessTimeout = '{0}',", objcc_PaperStuBatchQuesRelaEN.IsNotProcessTimeout == true?"1":"0"); //是否不处理超时
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.IsPublish))
 {
 sbSQL.AppendFormat(" IsPublish = '{0}',", objcc_PaperStuBatchQuesRelaEN.IsPublish == true?"1":"0"); //是否发布
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.IsRight))
 {
 sbSQL.AppendFormat(" IsRight = '{0}',", objcc_PaperStuBatchQuesRelaEN.IsRight == true?"1":"0"); //是否正确
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.IsSave))
 {
 sbSQL.AppendFormat(" IsSave = '{0}',", objcc_PaperStuBatchQuesRelaEN.IsSave == true?"1":"0"); //是否保存
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.IsSendBack))
 {
 sbSQL.AppendFormat(" IsSendBack = '{0}',", objcc_PaperStuBatchQuesRelaEN.IsSendBack == true?"1":"0"); //是否退回
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objcc_PaperStuBatchQuesRelaEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.MarkDate))
 {
 if (objcc_PaperStuBatchQuesRelaEN.MarkDate !=  null)
 {
 var strMarkDate = objcc_PaperStuBatchQuesRelaEN.MarkDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MarkDate = '{0}',", strMarkDate); //打分日期
 }
 else
 {
 sbSQL.Append(" MarkDate = null,"); //打分日期
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.MarkerId))
 {
 if (objcc_PaperStuBatchQuesRelaEN.MarkerId !=  null)
 {
 var strMarkerId = objcc_PaperStuBatchQuesRelaEN.MarkerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MarkerId = '{0}',", strMarkerId); //打分者
 }
 else
 {
 sbSQL.Append(" MarkerId = null,"); //打分者
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.OperateTime))
 {
 if (objcc_PaperStuBatchQuesRelaEN.OperateTime !=  null)
 {
 var strOperateTime = objcc_PaperStuBatchQuesRelaEN.OperateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OperateTime = '{0}',", strOperateTime); //操作时间
 }
 else
 {
 sbSQL.Append(" OperateTime = null,"); //操作时间
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.RealFinishDate))
 {
 if (objcc_PaperStuBatchQuesRelaEN.RealFinishDate !=  null)
 {
 var strRealFinishDate = objcc_PaperStuBatchQuesRelaEN.RealFinishDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RealFinishDate = '{0}',", strRealFinishDate); //实际完成日期
 }
 else
 {
 sbSQL.Append(" RealFinishDate = null,"); //实际完成日期
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.WorkTypeId))
 {
 if (objcc_PaperStuBatchQuesRelaEN.WorkTypeId !=  null)
 {
 var strWorkTypeId = objcc_PaperStuBatchQuesRelaEN.WorkTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WorkTypeId = '{0}',", strWorkTypeId); //作业类型Id
 }
 else
 {
 sbSQL.Append(" WorkTypeId = null,"); //作业类型Id
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.SchoolYear))
 {
 if (objcc_PaperStuBatchQuesRelaEN.SchoolYear !=  null)
 {
 var strSchoolYear = objcc_PaperStuBatchQuesRelaEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolYear = '{0}',", strSchoolYear); //学年
 }
 else
 {
 sbSQL.Append(" SchoolYear = null,"); //学年
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.SchoolTerm))
 {
 if (objcc_PaperStuBatchQuesRelaEN.SchoolTerm !=  null)
 {
 var strSchoolTerm = objcc_PaperStuBatchQuesRelaEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolTerm = '{0}',", strSchoolTerm); //学期
 }
 else
 {
 sbSQL.Append(" SchoolTerm = null,"); //学期
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.ErrMsg))
 {
 if (objcc_PaperStuBatchQuesRelaEN.ErrMsg !=  null)
 {
 var strErrMsg = objcc_PaperStuBatchQuesRelaEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ErrMsg = '{0}',", strErrMsg); //错误信息
 }
 else
 {
 sbSQL.Append(" ErrMsg = null,"); //错误信息
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.CourseId))
 {
 if (objcc_PaperStuBatchQuesRelaEN.CourseId !=  null)
 {
 var strCourseId = objcc_PaperStuBatchQuesRelaEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.UpdDate))
 {
 if (objcc_PaperStuBatchQuesRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objcc_PaperStuBatchQuesRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.UpdUserId))
 {
 if (objcc_PaperStuBatchQuesRelaEN.UpdUserId !=  null)
 {
 var strUpdUserId = objcc_PaperStuBatchQuesRelaEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.Memo))
 {
 if (objcc_PaperStuBatchQuesRelaEN.Memo !=  null)
 {
 var strMemo = objcc_PaperStuBatchQuesRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objcc_PaperStuBatchQuesRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_PaperStuBatchQuesRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_PaperStuBatchQuesRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PaperStuBatchQuesRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update cc_PaperStuBatchQuesRela Set ");
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.IdPaperStuBatch))
 {
 if (objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatch  ==  "")
 {
 objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatch = null;
 }
 if (objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatch !=  null)
 {
 var strIdPaperStuBatch = objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatch.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdPaperStuBatch, concc_PaperStuBatchQuesRela.IdPaperStuBatch); //学生试卷批次流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela.IdPaperStuBatch); //学生试卷批次流水号
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.QuestionId))
 {
 if (objcc_PaperStuBatchQuesRelaEN.QuestionId !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_PaperStuBatchQuesRelaEN.QuestionId, concc_PaperStuBatchQuesRela.QuestionId); //题目Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela.QuestionId); //题目Id
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.QuestionIndex4Batch))
 {
 if (objcc_PaperStuBatchQuesRelaEN.QuestionIndex4Batch !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_PaperStuBatchQuesRelaEN.QuestionIndex4Batch, concc_PaperStuBatchQuesRela.QuestionIndex4Batch); //题序号4批次
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela.QuestionIndex4Batch); //题序号4批次
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.Scores))
 {
 if (objcc_PaperStuBatchQuesRelaEN.Scores !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_PaperStuBatchQuesRelaEN.Scores, concc_PaperStuBatchQuesRela.Scores); //分值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela.Scores); //分值
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.Score))
 {
 if (objcc_PaperStuBatchQuesRelaEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_PaperStuBatchQuesRelaEN.Score, concc_PaperStuBatchQuesRela.Score); //得分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela.Score); //得分
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.StuAnswerText))
 {
 if (objcc_PaperStuBatchQuesRelaEN.StuAnswerText !=  null)
 {
 var strStuAnswerText = objcc_PaperStuBatchQuesRelaEN.StuAnswerText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStuAnswerText, concc_PaperStuBatchQuesRela.StuAnswerText); //学生回答文本
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela.StuAnswerText); //学生回答文本
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.AnswerDate))
 {
 if (objcc_PaperStuBatchQuesRelaEN.AnswerDate !=  null)
 {
 var strAnswerDate = objcc_PaperStuBatchQuesRelaEN.AnswerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerDate, concc_PaperStuBatchQuesRela.AnswerDate); //回答日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela.AnswerDate); //回答日期
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.AnswerIP))
 {
 if (objcc_PaperStuBatchQuesRelaEN.AnswerIP !=  null)
 {
 var strAnswerIP = objcc_PaperStuBatchQuesRelaEN.AnswerIP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerIP, concc_PaperStuBatchQuesRela.AnswerIP); //回答IP
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela.AnswerIP); //回答IP
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.AnswerModeId))
 {
 if (objcc_PaperStuBatchQuesRelaEN.AnswerModeId !=  null)
 {
 var strAnswerModeId = objcc_PaperStuBatchQuesRelaEN.AnswerModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerModeId, concc_PaperStuBatchQuesRela.AnswerModeId); //答案模式Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela.AnswerModeId); //答案模式Id
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.AnswerMultiOptions))
 {
 if (objcc_PaperStuBatchQuesRelaEN.AnswerMultiOptions !=  null)
 {
 var strAnswerMultiOptions = objcc_PaperStuBatchQuesRelaEN.AnswerMultiOptions.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerMultiOptions, concc_PaperStuBatchQuesRela.AnswerMultiOptions); //多选项答案
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela.AnswerMultiOptions); //多选项答案
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.AnswerOptionId))
 {
 if (objcc_PaperStuBatchQuesRelaEN.AnswerOptionId !=  null)
 {
 var strAnswerOptionId = objcc_PaperStuBatchQuesRelaEN.AnswerOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerOptionId, concc_PaperStuBatchQuesRela.AnswerOptionId); //回答选项Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela.AnswerOptionId); //回答选项Id
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.AnswerTime))
 {
 if (objcc_PaperStuBatchQuesRelaEN.AnswerTime !=  null)
 {
 var strAnswerTime = objcc_PaperStuBatchQuesRelaEN.AnswerTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerTime, concc_PaperStuBatchQuesRela.AnswerTime); //回答时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela.AnswerTime); //回答时间
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.ApplySendBackDate))
 {
 if (objcc_PaperStuBatchQuesRelaEN.ApplySendBackDate !=  null)
 {
 var strApplySendBackDate = objcc_PaperStuBatchQuesRelaEN.ApplySendBackDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strApplySendBackDate, concc_PaperStuBatchQuesRela.ApplySendBackDate); //申请退回日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela.ApplySendBackDate); //申请退回日期
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.Comment))
 {
 if (objcc_PaperStuBatchQuesRelaEN.Comment !=  null)
 {
 var strComment = objcc_PaperStuBatchQuesRelaEN.Comment.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strComment, concc_PaperStuBatchQuesRela.Comment); //批注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela.Comment); //批注
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.IsAccessKnowledge))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_PaperStuBatchQuesRelaEN.IsAccessKnowledge == true?"1":"0", concc_PaperStuBatchQuesRela.IsAccessKnowledge); //是否处理知识点
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.IsApplySendBack))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_PaperStuBatchQuesRelaEN.IsApplySendBack == true?"1":"0", concc_PaperStuBatchQuesRela.IsApplySendBack); //是否申请退回
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.IsInErrorQuestion))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_PaperStuBatchQuesRelaEN.IsInErrorQuestion == true?"1":"0", concc_PaperStuBatchQuesRela.IsInErrorQuestion); //是否进入错题
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.IsLook))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_PaperStuBatchQuesRelaEN.IsLook == true?"1":"0", concc_PaperStuBatchQuesRela.IsLook); //是否查看
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.IsMarking))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_PaperStuBatchQuesRelaEN.IsMarking == true?"1":"0", concc_PaperStuBatchQuesRela.IsMarking); //是否批阅
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.IsNotProcessTimeout))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_PaperStuBatchQuesRelaEN.IsNotProcessTimeout == true?"1":"0", concc_PaperStuBatchQuesRela.IsNotProcessTimeout); //是否不处理超时
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.IsPublish))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_PaperStuBatchQuesRelaEN.IsPublish == true?"1":"0", concc_PaperStuBatchQuesRela.IsPublish); //是否发布
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.IsRight))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_PaperStuBatchQuesRelaEN.IsRight == true?"1":"0", concc_PaperStuBatchQuesRela.IsRight); //是否正确
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.IsSave))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_PaperStuBatchQuesRelaEN.IsSave == true?"1":"0", concc_PaperStuBatchQuesRela.IsSave); //是否保存
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.IsSendBack))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_PaperStuBatchQuesRelaEN.IsSendBack == true?"1":"0", concc_PaperStuBatchQuesRela.IsSendBack); //是否退回
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_PaperStuBatchQuesRelaEN.IsSubmit == true?"1":"0", concc_PaperStuBatchQuesRela.IsSubmit); //是否提交
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.MarkDate))
 {
 if (objcc_PaperStuBatchQuesRelaEN.MarkDate !=  null)
 {
 var strMarkDate = objcc_PaperStuBatchQuesRelaEN.MarkDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMarkDate, concc_PaperStuBatchQuesRela.MarkDate); //打分日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela.MarkDate); //打分日期
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.MarkerId))
 {
 if (objcc_PaperStuBatchQuesRelaEN.MarkerId !=  null)
 {
 var strMarkerId = objcc_PaperStuBatchQuesRelaEN.MarkerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMarkerId, concc_PaperStuBatchQuesRela.MarkerId); //打分者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela.MarkerId); //打分者
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.OperateTime))
 {
 if (objcc_PaperStuBatchQuesRelaEN.OperateTime !=  null)
 {
 var strOperateTime = objcc_PaperStuBatchQuesRelaEN.OperateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOperateTime, concc_PaperStuBatchQuesRela.OperateTime); //操作时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela.OperateTime); //操作时间
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.RealFinishDate))
 {
 if (objcc_PaperStuBatchQuesRelaEN.RealFinishDate !=  null)
 {
 var strRealFinishDate = objcc_PaperStuBatchQuesRelaEN.RealFinishDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRealFinishDate, concc_PaperStuBatchQuesRela.RealFinishDate); //实际完成日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela.RealFinishDate); //实际完成日期
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.WorkTypeId))
 {
 if (objcc_PaperStuBatchQuesRelaEN.WorkTypeId !=  null)
 {
 var strWorkTypeId = objcc_PaperStuBatchQuesRelaEN.WorkTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWorkTypeId, concc_PaperStuBatchQuesRela.WorkTypeId); //作业类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela.WorkTypeId); //作业类型Id
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.SchoolYear))
 {
 if (objcc_PaperStuBatchQuesRelaEN.SchoolYear !=  null)
 {
 var strSchoolYear = objcc_PaperStuBatchQuesRelaEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchoolYear, concc_PaperStuBatchQuesRela.SchoolYear); //学年
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela.SchoolYear); //学年
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.SchoolTerm))
 {
 if (objcc_PaperStuBatchQuesRelaEN.SchoolTerm !=  null)
 {
 var strSchoolTerm = objcc_PaperStuBatchQuesRelaEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchoolTerm, concc_PaperStuBatchQuesRela.SchoolTerm); //学期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela.SchoolTerm); //学期
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.ErrMsg))
 {
 if (objcc_PaperStuBatchQuesRelaEN.ErrMsg !=  null)
 {
 var strErrMsg = objcc_PaperStuBatchQuesRelaEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strErrMsg, concc_PaperStuBatchQuesRela.ErrMsg); //错误信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela.ErrMsg); //错误信息
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.CourseId))
 {
 if (objcc_PaperStuBatchQuesRelaEN.CourseId !=  null)
 {
 var strCourseId = objcc_PaperStuBatchQuesRelaEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, concc_PaperStuBatchQuesRela.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela.CourseId); //课程Id
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.UpdDate))
 {
 if (objcc_PaperStuBatchQuesRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objcc_PaperStuBatchQuesRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, concc_PaperStuBatchQuesRela.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela.UpdDate); //修改日期
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.UpdUserId))
 {
 if (objcc_PaperStuBatchQuesRelaEN.UpdUserId !=  null)
 {
 var strUpdUserId = objcc_PaperStuBatchQuesRelaEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, concc_PaperStuBatchQuesRela.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela.UpdUserId); //修改用户Id
 }
 }
 
 if (objcc_PaperStuBatchQuesRelaEN.IsUpdated(concc_PaperStuBatchQuesRela.Memo))
 {
 if (objcc_PaperStuBatchQuesRelaEN.Memo !=  null)
 {
 var strMemo = objcc_PaperStuBatchQuesRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, concc_PaperStuBatchQuesRela.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdPaperStuBatchQuesRela = {0}", objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatchQuesRela); 
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
 /// <param name = "lngIdPaperStuBatchQuesRela">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngIdPaperStuBatchQuesRela) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PaperStuBatchQuesRelaDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngIdPaperStuBatchQuesRela,
};
 objSQL.ExecSP("cc_PaperStuBatchQuesRela_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngIdPaperStuBatchQuesRela">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngIdPaperStuBatchQuesRela, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PaperStuBatchQuesRelaDA.GetSpecSQLObj();
//删除cc_PaperStuBatchQuesRela本表中与当前对象有关的记录
strSQL = strSQL + "Delete from cc_PaperStuBatchQuesRela where IdPaperStuBatchQuesRela = " + ""+ lngIdPaperStuBatchQuesRela+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delcc_PaperStuBatchQuesRela(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PaperStuBatchQuesRelaDA.GetSpecSQLObj();
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
//删除cc_PaperStuBatchQuesRela本表中与当前对象有关的记录
strSQL = strSQL + "Delete from cc_PaperStuBatchQuesRela where IdPaperStuBatchQuesRela in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngIdPaperStuBatchQuesRela">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngIdPaperStuBatchQuesRela) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PaperStuBatchQuesRelaDA.GetSpecSQLObj();
//删除cc_PaperStuBatchQuesRela本表中与当前对象有关的记录
strSQL = strSQL + "Delete from cc_PaperStuBatchQuesRela where IdPaperStuBatchQuesRela = " + ""+ lngIdPaperStuBatchQuesRela+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delcc_PaperStuBatchQuesRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clscc_PaperStuBatchQuesRelaDA: Delcc_PaperStuBatchQuesRela)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PaperStuBatchQuesRelaDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from cc_PaperStuBatchQuesRela where " + strCondition ;
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
public bool Delcc_PaperStuBatchQuesRelaWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clscc_PaperStuBatchQuesRelaDA: Delcc_PaperStuBatchQuesRelaWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PaperStuBatchQuesRelaDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from cc_PaperStuBatchQuesRela where " + strCondition ;
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
 /// <param name = "objcc_PaperStuBatchQuesRelaENS">源对象</param>
 /// <param name = "objcc_PaperStuBatchQuesRelaENT">目标对象</param>
public void CopyTo(clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaENS, clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaENT)
{
objcc_PaperStuBatchQuesRelaENT.IdPaperStuBatchQuesRela = objcc_PaperStuBatchQuesRelaENS.IdPaperStuBatchQuesRela; //学生批次题目关系流水号
objcc_PaperStuBatchQuesRelaENT.IdPaperStuBatch = objcc_PaperStuBatchQuesRelaENS.IdPaperStuBatch; //学生试卷批次流水号
objcc_PaperStuBatchQuesRelaENT.QuestionId = objcc_PaperStuBatchQuesRelaENS.QuestionId; //题目Id
objcc_PaperStuBatchQuesRelaENT.QuestionIndex4Batch = objcc_PaperStuBatchQuesRelaENS.QuestionIndex4Batch; //题序号4批次
objcc_PaperStuBatchQuesRelaENT.Scores = objcc_PaperStuBatchQuesRelaENS.Scores; //分值
objcc_PaperStuBatchQuesRelaENT.Score = objcc_PaperStuBatchQuesRelaENS.Score; //得分
objcc_PaperStuBatchQuesRelaENT.StuAnswerText = objcc_PaperStuBatchQuesRelaENS.StuAnswerText; //学生回答文本
objcc_PaperStuBatchQuesRelaENT.AnswerDate = objcc_PaperStuBatchQuesRelaENS.AnswerDate; //回答日期
objcc_PaperStuBatchQuesRelaENT.AnswerIP = objcc_PaperStuBatchQuesRelaENS.AnswerIP; //回答IP
objcc_PaperStuBatchQuesRelaENT.AnswerModeId = objcc_PaperStuBatchQuesRelaENS.AnswerModeId; //答案模式Id
objcc_PaperStuBatchQuesRelaENT.AnswerMultiOptions = objcc_PaperStuBatchQuesRelaENS.AnswerMultiOptions; //多选项答案
objcc_PaperStuBatchQuesRelaENT.AnswerOptionId = objcc_PaperStuBatchQuesRelaENS.AnswerOptionId; //回答选项Id
objcc_PaperStuBatchQuesRelaENT.AnswerTime = objcc_PaperStuBatchQuesRelaENS.AnswerTime; //回答时间
objcc_PaperStuBatchQuesRelaENT.ApplySendBackDate = objcc_PaperStuBatchQuesRelaENS.ApplySendBackDate; //申请退回日期
objcc_PaperStuBatchQuesRelaENT.Comment = objcc_PaperStuBatchQuesRelaENS.Comment; //批注
objcc_PaperStuBatchQuesRelaENT.IsAccessKnowledge = objcc_PaperStuBatchQuesRelaENS.IsAccessKnowledge; //是否处理知识点
objcc_PaperStuBatchQuesRelaENT.IsApplySendBack = objcc_PaperStuBatchQuesRelaENS.IsApplySendBack; //是否申请退回
objcc_PaperStuBatchQuesRelaENT.IsInErrorQuestion = objcc_PaperStuBatchQuesRelaENS.IsInErrorQuestion; //是否进入错题
objcc_PaperStuBatchQuesRelaENT.IsLook = objcc_PaperStuBatchQuesRelaENS.IsLook; //是否查看
objcc_PaperStuBatchQuesRelaENT.IsMarking = objcc_PaperStuBatchQuesRelaENS.IsMarking; //是否批阅
objcc_PaperStuBatchQuesRelaENT.IsNotProcessTimeout = objcc_PaperStuBatchQuesRelaENS.IsNotProcessTimeout; //是否不处理超时
objcc_PaperStuBatchQuesRelaENT.IsPublish = objcc_PaperStuBatchQuesRelaENS.IsPublish; //是否发布
objcc_PaperStuBatchQuesRelaENT.IsRight = objcc_PaperStuBatchQuesRelaENS.IsRight; //是否正确
objcc_PaperStuBatchQuesRelaENT.IsSave = objcc_PaperStuBatchQuesRelaENS.IsSave; //是否保存
objcc_PaperStuBatchQuesRelaENT.IsSendBack = objcc_PaperStuBatchQuesRelaENS.IsSendBack; //是否退回
objcc_PaperStuBatchQuesRelaENT.IsSubmit = objcc_PaperStuBatchQuesRelaENS.IsSubmit; //是否提交
objcc_PaperStuBatchQuesRelaENT.MarkDate = objcc_PaperStuBatchQuesRelaENS.MarkDate; //打分日期
objcc_PaperStuBatchQuesRelaENT.MarkerId = objcc_PaperStuBatchQuesRelaENS.MarkerId; //打分者
objcc_PaperStuBatchQuesRelaENT.OperateTime = objcc_PaperStuBatchQuesRelaENS.OperateTime; //操作时间
objcc_PaperStuBatchQuesRelaENT.RealFinishDate = objcc_PaperStuBatchQuesRelaENS.RealFinishDate; //实际完成日期
objcc_PaperStuBatchQuesRelaENT.WorkTypeId = objcc_PaperStuBatchQuesRelaENS.WorkTypeId; //作业类型Id
objcc_PaperStuBatchQuesRelaENT.SchoolYear = objcc_PaperStuBatchQuesRelaENS.SchoolYear; //学年
objcc_PaperStuBatchQuesRelaENT.SchoolTerm = objcc_PaperStuBatchQuesRelaENS.SchoolTerm; //学期
objcc_PaperStuBatchQuesRelaENT.ErrMsg = objcc_PaperStuBatchQuesRelaENS.ErrMsg; //错误信息
objcc_PaperStuBatchQuesRelaENT.CourseId = objcc_PaperStuBatchQuesRelaENS.CourseId; //课程Id
objcc_PaperStuBatchQuesRelaENT.UpdDate = objcc_PaperStuBatchQuesRelaENS.UpdDate; //修改日期
objcc_PaperStuBatchQuesRelaENT.UpdUserId = objcc_PaperStuBatchQuesRelaENS.UpdUserId; //修改用户Id
objcc_PaperStuBatchQuesRelaENT.Memo = objcc_PaperStuBatchQuesRelaENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatch, concc_PaperStuBatchQuesRela.IdPaperStuBatch);
clsCheckSql.CheckFieldNotNull(objcc_PaperStuBatchQuesRelaEN.UpdDate, concc_PaperStuBatchQuesRela.UpdDate);
//检查字段长度
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatch, 10, concc_PaperStuBatchQuesRela.IdPaperStuBatch);
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRelaEN.AnswerDate, 8, concc_PaperStuBatchQuesRela.AnswerDate);
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRelaEN.AnswerIP, 30, concc_PaperStuBatchQuesRela.AnswerIP);
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRelaEN.AnswerModeId, 4, concc_PaperStuBatchQuesRela.AnswerModeId);
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRelaEN.AnswerMultiOptions, 300, concc_PaperStuBatchQuesRela.AnswerMultiOptions);
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRelaEN.AnswerOptionId, 8, concc_PaperStuBatchQuesRela.AnswerOptionId);
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRelaEN.AnswerTime, 10, concc_PaperStuBatchQuesRela.AnswerTime);
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRelaEN.ApplySendBackDate, 14, concc_PaperStuBatchQuesRela.ApplySendBackDate);
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRelaEN.MarkDate, 14, concc_PaperStuBatchQuesRela.MarkDate);
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRelaEN.MarkerId, 20, concc_PaperStuBatchQuesRela.MarkerId);
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRelaEN.OperateTime, 14, concc_PaperStuBatchQuesRela.OperateTime);
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRelaEN.RealFinishDate, 14, concc_PaperStuBatchQuesRela.RealFinishDate);
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRelaEN.WorkTypeId, 2, concc_PaperStuBatchQuesRela.WorkTypeId);
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRelaEN.SchoolYear, 10, concc_PaperStuBatchQuesRela.SchoolYear);
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRelaEN.SchoolTerm, 1, concc_PaperStuBatchQuesRela.SchoolTerm);
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRelaEN.ErrMsg, 200, concc_PaperStuBatchQuesRela.ErrMsg);
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRelaEN.CourseId, 8, concc_PaperStuBatchQuesRela.CourseId);
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRelaEN.UpdDate, 20, concc_PaperStuBatchQuesRela.UpdDate);
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRelaEN.UpdUserId, 20, concc_PaperStuBatchQuesRela.UpdUserId);
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRelaEN.Memo, 1000, concc_PaperStuBatchQuesRela.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatch, 10, concc_PaperStuBatchQuesRela.IdPaperStuBatch);
 objcc_PaperStuBatchQuesRelaEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatch, 10, concc_PaperStuBatchQuesRela.IdPaperStuBatch);
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRelaEN.AnswerDate, 8, concc_PaperStuBatchQuesRela.AnswerDate);
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRelaEN.AnswerIP, 30, concc_PaperStuBatchQuesRela.AnswerIP);
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRelaEN.AnswerModeId, 4, concc_PaperStuBatchQuesRela.AnswerModeId);
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRelaEN.AnswerMultiOptions, 300, concc_PaperStuBatchQuesRela.AnswerMultiOptions);
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRelaEN.AnswerOptionId, 8, concc_PaperStuBatchQuesRela.AnswerOptionId);
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRelaEN.AnswerTime, 10, concc_PaperStuBatchQuesRela.AnswerTime);
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRelaEN.ApplySendBackDate, 14, concc_PaperStuBatchQuesRela.ApplySendBackDate);
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRelaEN.MarkDate, 14, concc_PaperStuBatchQuesRela.MarkDate);
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRelaEN.MarkerId, 20, concc_PaperStuBatchQuesRela.MarkerId);
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRelaEN.OperateTime, 14, concc_PaperStuBatchQuesRela.OperateTime);
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRelaEN.RealFinishDate, 14, concc_PaperStuBatchQuesRela.RealFinishDate);
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRelaEN.WorkTypeId, 2, concc_PaperStuBatchQuesRela.WorkTypeId);
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRelaEN.SchoolYear, 10, concc_PaperStuBatchQuesRela.SchoolYear);
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRelaEN.SchoolTerm, 1, concc_PaperStuBatchQuesRela.SchoolTerm);
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRelaEN.ErrMsg, 200, concc_PaperStuBatchQuesRela.ErrMsg);
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRelaEN.CourseId, 8, concc_PaperStuBatchQuesRela.CourseId);
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRelaEN.UpdDate, 20, concc_PaperStuBatchQuesRela.UpdDate);
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRelaEN.UpdUserId, 20, concc_PaperStuBatchQuesRela.UpdUserId);
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRelaEN.Memo, 1000, concc_PaperStuBatchQuesRela.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatch, 10, concc_PaperStuBatchQuesRela.IdPaperStuBatch);
 objcc_PaperStuBatchQuesRelaEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatch, 10, concc_PaperStuBatchQuesRela.IdPaperStuBatch);
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRelaEN.AnswerDate, 8, concc_PaperStuBatchQuesRela.AnswerDate);
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRelaEN.AnswerIP, 30, concc_PaperStuBatchQuesRela.AnswerIP);
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRelaEN.AnswerModeId, 4, concc_PaperStuBatchQuesRela.AnswerModeId);
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRelaEN.AnswerMultiOptions, 300, concc_PaperStuBatchQuesRela.AnswerMultiOptions);
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRelaEN.AnswerOptionId, 8, concc_PaperStuBatchQuesRela.AnswerOptionId);
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRelaEN.AnswerTime, 10, concc_PaperStuBatchQuesRela.AnswerTime);
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRelaEN.ApplySendBackDate, 14, concc_PaperStuBatchQuesRela.ApplySendBackDate);
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRelaEN.MarkDate, 14, concc_PaperStuBatchQuesRela.MarkDate);
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRelaEN.MarkerId, 20, concc_PaperStuBatchQuesRela.MarkerId);
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRelaEN.OperateTime, 14, concc_PaperStuBatchQuesRela.OperateTime);
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRelaEN.RealFinishDate, 14, concc_PaperStuBatchQuesRela.RealFinishDate);
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRelaEN.WorkTypeId, 2, concc_PaperStuBatchQuesRela.WorkTypeId);
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRelaEN.SchoolYear, 10, concc_PaperStuBatchQuesRela.SchoolYear);
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRelaEN.SchoolTerm, 1, concc_PaperStuBatchQuesRela.SchoolTerm);
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRelaEN.ErrMsg, 200, concc_PaperStuBatchQuesRela.ErrMsg);
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRelaEN.CourseId, 8, concc_PaperStuBatchQuesRela.CourseId);
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRelaEN.UpdDate, 20, concc_PaperStuBatchQuesRela.UpdDate);
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRelaEN.UpdUserId, 20, concc_PaperStuBatchQuesRela.UpdUserId);
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRelaEN.Memo, 1000, concc_PaperStuBatchQuesRela.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatch, concc_PaperStuBatchQuesRela.IdPaperStuBatch);
clsCheckSql.CheckSqlInjection4Field(objcc_PaperStuBatchQuesRelaEN.AnswerDate, concc_PaperStuBatchQuesRela.AnswerDate);
clsCheckSql.CheckSqlInjection4Field(objcc_PaperStuBatchQuesRelaEN.AnswerIP, concc_PaperStuBatchQuesRela.AnswerIP);
clsCheckSql.CheckSqlInjection4Field(objcc_PaperStuBatchQuesRelaEN.AnswerModeId, concc_PaperStuBatchQuesRela.AnswerModeId);
clsCheckSql.CheckSqlInjection4Field(objcc_PaperStuBatchQuesRelaEN.AnswerMultiOptions, concc_PaperStuBatchQuesRela.AnswerMultiOptions);
clsCheckSql.CheckSqlInjection4Field(objcc_PaperStuBatchQuesRelaEN.AnswerOptionId, concc_PaperStuBatchQuesRela.AnswerOptionId);
clsCheckSql.CheckSqlInjection4Field(objcc_PaperStuBatchQuesRelaEN.AnswerTime, concc_PaperStuBatchQuesRela.AnswerTime);
clsCheckSql.CheckSqlInjection4Field(objcc_PaperStuBatchQuesRelaEN.ApplySendBackDate, concc_PaperStuBatchQuesRela.ApplySendBackDate);
clsCheckSql.CheckSqlInjection4Field(objcc_PaperStuBatchQuesRelaEN.MarkDate, concc_PaperStuBatchQuesRela.MarkDate);
clsCheckSql.CheckSqlInjection4Field(objcc_PaperStuBatchQuesRelaEN.MarkerId, concc_PaperStuBatchQuesRela.MarkerId);
clsCheckSql.CheckSqlInjection4Field(objcc_PaperStuBatchQuesRelaEN.OperateTime, concc_PaperStuBatchQuesRela.OperateTime);
clsCheckSql.CheckSqlInjection4Field(objcc_PaperStuBatchQuesRelaEN.RealFinishDate, concc_PaperStuBatchQuesRela.RealFinishDate);
clsCheckSql.CheckSqlInjection4Field(objcc_PaperStuBatchQuesRelaEN.WorkTypeId, concc_PaperStuBatchQuesRela.WorkTypeId);
clsCheckSql.CheckSqlInjection4Field(objcc_PaperStuBatchQuesRelaEN.SchoolYear, concc_PaperStuBatchQuesRela.SchoolYear);
clsCheckSql.CheckSqlInjection4Field(objcc_PaperStuBatchQuesRelaEN.SchoolTerm, concc_PaperStuBatchQuesRela.SchoolTerm);
clsCheckSql.CheckSqlInjection4Field(objcc_PaperStuBatchQuesRelaEN.ErrMsg, concc_PaperStuBatchQuesRela.ErrMsg);
clsCheckSql.CheckSqlInjection4Field(objcc_PaperStuBatchQuesRelaEN.CourseId, concc_PaperStuBatchQuesRela.CourseId);
clsCheckSql.CheckSqlInjection4Field(objcc_PaperStuBatchQuesRelaEN.UpdDate, concc_PaperStuBatchQuesRela.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objcc_PaperStuBatchQuesRelaEN.UpdUserId, concc_PaperStuBatchQuesRela.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objcc_PaperStuBatchQuesRelaEN.Memo, concc_PaperStuBatchQuesRela.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatch, 10, concc_PaperStuBatchQuesRela.IdPaperStuBatch);
 objcc_PaperStuBatchQuesRelaEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--cc_PaperStuBatchQuesRela(学生批次题目关系),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 if (objcc_PaperStuBatchQuesRelaEN.QuestionId == null)
{
 sbCondition.AppendFormat(" and QuestionId is null");
}
else
{
 sbCondition.AppendFormat(" and QuestionId = '{0}'", objcc_PaperStuBatchQuesRelaEN.QuestionId);
}
 sbCondition.AppendFormat(" and IdPaperStuBatch = '{0}'", objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatch);
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
 objSQL = clscc_PaperStuBatchQuesRelaDA.GetSpecSQLObj();
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
 objSQL = clscc_PaperStuBatchQuesRelaDA.GetSpecSQLObj();
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
 objSQL = clscc_PaperStuBatchQuesRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clscc_PaperStuBatchQuesRelaEN._CurrTabName);
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
 objSQL = clscc_PaperStuBatchQuesRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clscc_PaperStuBatchQuesRelaEN._CurrTabName, strCondition);
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
 objSQL = clscc_PaperStuBatchQuesRelaDA.GetSpecSQLObj();
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
 objSQL = clscc_PaperStuBatchQuesRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}