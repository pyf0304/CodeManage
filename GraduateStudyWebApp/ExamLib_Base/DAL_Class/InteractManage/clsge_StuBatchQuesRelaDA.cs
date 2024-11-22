
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsge_StuBatchQuesRelaDA
 表名:ge_StuBatchQuesRela(01120885)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:00:32
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
 /// 学生批次题目关系(ge_StuBatchQuesRela)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsge_StuBatchQuesRelaDA : clsCommBase4DA
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
 return clsge_StuBatchQuesRelaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsge_StuBatchQuesRelaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsge_StuBatchQuesRelaEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsge_StuBatchQuesRelaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsge_StuBatchQuesRelaEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsge_StuBatchQuesRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StuBatchQuesRelaDA.GetSpecSQLObj();
strSQL = "Select * from ge_StuBatchQuesRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_ge_StuBatchQuesRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsge_StuBatchQuesRelaDA: GetDataTable_ge_StuBatchQuesRela)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StuBatchQuesRelaDA.GetSpecSQLObj();
strSQL = "Select * from ge_StuBatchQuesRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsge_StuBatchQuesRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StuBatchQuesRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsge_StuBatchQuesRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StuBatchQuesRelaDA.GetSpecSQLObj();
strSQL = "Select * from ge_StuBatchQuesRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsge_StuBatchQuesRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StuBatchQuesRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsge_StuBatchQuesRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StuBatchQuesRelaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ge_StuBatchQuesRela where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ge_StuBatchQuesRela where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsge_StuBatchQuesRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StuBatchQuesRelaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from ge_StuBatchQuesRela where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsge_StuBatchQuesRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StuBatchQuesRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} ge_StuBatchQuesRela.* from ge_StuBatchQuesRela Left Join {1} on {2} where {3} and ge_StuBatchQuesRela.IdStuBatchQuesRela not in (Select top {5} ge_StuBatchQuesRela.IdStuBatchQuesRela from ge_StuBatchQuesRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ge_StuBatchQuesRela where {1} and IdStuBatchQuesRela not in (Select top {2} IdStuBatchQuesRela from ge_StuBatchQuesRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ge_StuBatchQuesRela where {1} and IdStuBatchQuesRela not in (Select top {3} IdStuBatchQuesRela from ge_StuBatchQuesRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsge_StuBatchQuesRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StuBatchQuesRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} ge_StuBatchQuesRela.* from ge_StuBatchQuesRela Left Join {1} on {2} where {3} and ge_StuBatchQuesRela.IdStuBatchQuesRela not in (Select top {5} ge_StuBatchQuesRela.IdStuBatchQuesRela from ge_StuBatchQuesRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ge_StuBatchQuesRela where {1} and IdStuBatchQuesRela not in (Select top {2} IdStuBatchQuesRela from ge_StuBatchQuesRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ge_StuBatchQuesRela where {1} and IdStuBatchQuesRela not in (Select top {3} IdStuBatchQuesRela from ge_StuBatchQuesRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsge_StuBatchQuesRelaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsge_StuBatchQuesRelaDA:GetObjLst)", objException.Message));
}
List<clsge_StuBatchQuesRelaEN> arrObjLst = new List<clsge_StuBatchQuesRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StuBatchQuesRelaDA.GetSpecSQLObj();
strSQL = "Select * from ge_StuBatchQuesRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN = new clsge_StuBatchQuesRelaEN();
try
{
objge_StuBatchQuesRelaEN.IdStuBatchQuesRela = TransNullToInt(objRow[conge_StuBatchQuesRela.IdStuBatchQuesRela].ToString().Trim()); //学生批次题目关系流水号
objge_StuBatchQuesRelaEN.ExamBatchNo = objRow[conge_StuBatchQuesRela.ExamBatchNo].ToString().Trim(); //学生批次号
objge_StuBatchQuesRelaEN.LevelNo = objRow[conge_StuBatchQuesRela.LevelNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conge_StuBatchQuesRela.LevelNo].ToString().Trim()); //学习关号2
objge_StuBatchQuesRelaEN.QuestionId = TransNullToInt(objRow[conge_StuBatchQuesRela.QuestionId].ToString().Trim()); //题目Id
objge_StuBatchQuesRelaEN.UserId = objRow[conge_StuBatchQuesRela.UserId].ToString().Trim(); //用户ID
objge_StuBatchQuesRelaEN.IdCurrEduCls = objRow[conge_StuBatchQuesRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objge_StuBatchQuesRelaEN.QuestionIndex4Batch = objRow[conge_StuBatchQuesRela.QuestionIndex4Batch] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conge_StuBatchQuesRela.QuestionIndex4Batch].ToString().Trim()); //题序号4批次
objge_StuBatchQuesRelaEN.GameLevelId = objRow[conge_StuBatchQuesRela.GameLevelId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.GameLevelId].ToString().Trim(); //游戏关卡Id
objge_StuBatchQuesRelaEN.Scores = objRow[conge_StuBatchQuesRela.Scores] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conge_StuBatchQuesRela.Scores].ToString().Trim()); //分值
objge_StuBatchQuesRelaEN.Score = objRow[conge_StuBatchQuesRela.Score] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conge_StuBatchQuesRela.Score].ToString().Trim()); //得分
objge_StuBatchQuesRelaEN.StuAnswerText = objRow[conge_StuBatchQuesRela.StuAnswerText] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.StuAnswerText].ToString().Trim(); //学生回答文本
objge_StuBatchQuesRelaEN.AnswerDate = objRow[conge_StuBatchQuesRela.AnswerDate] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerDate].ToString().Trim(); //回答日期
objge_StuBatchQuesRelaEN.AnswerIP = objRow[conge_StuBatchQuesRela.AnswerIP] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerIP].ToString().Trim(); //回答IP
objge_StuBatchQuesRelaEN.AnswerModeId = objRow[conge_StuBatchQuesRela.AnswerModeId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerModeId].ToString().Trim(); //答案模式Id
objge_StuBatchQuesRelaEN.AnswerMultiOptions = objRow[conge_StuBatchQuesRela.AnswerMultiOptions] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerMultiOptions].ToString().Trim(); //多选项答案
objge_StuBatchQuesRelaEN.AnswerOptionId = objRow[conge_StuBatchQuesRela.AnswerOptionId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerOptionId].ToString().Trim(); //回答选项Id
objge_StuBatchQuesRelaEN.AnswerTime = objRow[conge_StuBatchQuesRela.AnswerTime] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerTime].ToString().Trim(); //回答时间
objge_StuBatchQuesRelaEN.ApplySendBackDate = objRow[conge_StuBatchQuesRela.ApplySendBackDate] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.ApplySendBackDate].ToString().Trim(); //申请退回日期
objge_StuBatchQuesRelaEN.Comment = objRow[conge_StuBatchQuesRela.Comment] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.Comment].ToString().Trim(); //批注
objge_StuBatchQuesRelaEN.IsAccessKnowledge = TransNullToBool(objRow[conge_StuBatchQuesRela.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objge_StuBatchQuesRelaEN.IsApplySendBack = TransNullToBool(objRow[conge_StuBatchQuesRela.IsApplySendBack].ToString().Trim()); //是否申请退回
objge_StuBatchQuesRelaEN.IsInErrorQuestion = TransNullToBool(objRow[conge_StuBatchQuesRela.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objge_StuBatchQuesRelaEN.IsLook = TransNullToBool(objRow[conge_StuBatchQuesRela.IsLook].ToString().Trim()); //是否查看
objge_StuBatchQuesRelaEN.IsMarking = TransNullToBool(objRow[conge_StuBatchQuesRela.IsMarking].ToString().Trim()); //是否批阅
objge_StuBatchQuesRelaEN.IsNotProcessTimeout = TransNullToBool(objRow[conge_StuBatchQuesRela.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objge_StuBatchQuesRelaEN.IsHasAnswer = TransNullToBool(objRow[conge_StuBatchQuesRela.IsHasAnswer].ToString().Trim()); //是否有答案
objge_StuBatchQuesRelaEN.IsPublish = TransNullToBool(objRow[conge_StuBatchQuesRela.IsPublish].ToString().Trim()); //是否发布
objge_StuBatchQuesRelaEN.IsRight = TransNullToBool(objRow[conge_StuBatchQuesRela.IsRight].ToString().Trim()); //是否正确
objge_StuBatchQuesRelaEN.IsSave = TransNullToBool(objRow[conge_StuBatchQuesRela.IsSave].ToString().Trim()); //是否保存
objge_StuBatchQuesRelaEN.IsSendBack = TransNullToBool(objRow[conge_StuBatchQuesRela.IsSendBack].ToString().Trim()); //是否退回
objge_StuBatchQuesRelaEN.IsSubmit = TransNullToBool(objRow[conge_StuBatchQuesRela.IsSubmit].ToString().Trim()); //是否提交
objge_StuBatchQuesRelaEN.MarkDate = objRow[conge_StuBatchQuesRela.MarkDate] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.MarkDate].ToString().Trim(); //打分日期
objge_StuBatchQuesRelaEN.MarkerId = objRow[conge_StuBatchQuesRela.MarkerId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.MarkerId].ToString().Trim(); //打分者
objge_StuBatchQuesRelaEN.OperateTime = objRow[conge_StuBatchQuesRela.OperateTime] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.OperateTime].ToString().Trim(); //操作时间
objge_StuBatchQuesRelaEN.RealFinishDate = objRow[conge_StuBatchQuesRela.RealFinishDate] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.RealFinishDate].ToString().Trim(); //实际完成日期
objge_StuBatchQuesRelaEN.WorkTypeId = objRow[conge_StuBatchQuesRela.WorkTypeId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.WorkTypeId].ToString().Trim(); //作业类型Id
objge_StuBatchQuesRelaEN.SchoolYear = objRow[conge_StuBatchQuesRela.SchoolYear] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.SchoolYear].ToString().Trim(); //学年
objge_StuBatchQuesRelaEN.SchoolTerm = objRow[conge_StuBatchQuesRela.SchoolTerm] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.SchoolTerm].ToString().Trim(); //学期
objge_StuBatchQuesRelaEN.ErrMsg = objRow[conge_StuBatchQuesRela.ErrMsg] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.ErrMsg].ToString().Trim(); //错误信息
objge_StuBatchQuesRelaEN.IsRecommend = TransNullToBool(objRow[conge_StuBatchQuesRela.IsRecommend].ToString().Trim()); //是否推荐
objge_StuBatchQuesRelaEN.CourseId = objRow[conge_StuBatchQuesRela.CourseId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.CourseId].ToString().Trim(); //课程Id
objge_StuBatchQuesRelaEN.UpdDate = objRow[conge_StuBatchQuesRela.UpdDate].ToString().Trim(); //修改日期
objge_StuBatchQuesRelaEN.UpdUserId = objRow[conge_StuBatchQuesRela.UpdUserId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.UpdUserId].ToString().Trim(); //修改用户Id
objge_StuBatchQuesRelaEN.Memo = objRow[conge_StuBatchQuesRela.Memo] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsge_StuBatchQuesRelaDA: GetObjLst)", objException.Message));
}
objge_StuBatchQuesRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objge_StuBatchQuesRelaEN);
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
public List<clsge_StuBatchQuesRelaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsge_StuBatchQuesRelaDA:GetObjLstByTabName)", objException.Message));
}
List<clsge_StuBatchQuesRelaEN> arrObjLst = new List<clsge_StuBatchQuesRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StuBatchQuesRelaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN = new clsge_StuBatchQuesRelaEN();
try
{
objge_StuBatchQuesRelaEN.IdStuBatchQuesRela = TransNullToInt(objRow[conge_StuBatchQuesRela.IdStuBatchQuesRela].ToString().Trim()); //学生批次题目关系流水号
objge_StuBatchQuesRelaEN.ExamBatchNo = objRow[conge_StuBatchQuesRela.ExamBatchNo].ToString().Trim(); //学生批次号
objge_StuBatchQuesRelaEN.LevelNo = objRow[conge_StuBatchQuesRela.LevelNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conge_StuBatchQuesRela.LevelNo].ToString().Trim()); //学习关号2
objge_StuBatchQuesRelaEN.QuestionId = TransNullToInt(objRow[conge_StuBatchQuesRela.QuestionId].ToString().Trim()); //题目Id
objge_StuBatchQuesRelaEN.UserId = objRow[conge_StuBatchQuesRela.UserId].ToString().Trim(); //用户ID
objge_StuBatchQuesRelaEN.IdCurrEduCls = objRow[conge_StuBatchQuesRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objge_StuBatchQuesRelaEN.QuestionIndex4Batch = objRow[conge_StuBatchQuesRela.QuestionIndex4Batch] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conge_StuBatchQuesRela.QuestionIndex4Batch].ToString().Trim()); //题序号4批次
objge_StuBatchQuesRelaEN.GameLevelId = objRow[conge_StuBatchQuesRela.GameLevelId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.GameLevelId].ToString().Trim(); //游戏关卡Id
objge_StuBatchQuesRelaEN.Scores = objRow[conge_StuBatchQuesRela.Scores] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conge_StuBatchQuesRela.Scores].ToString().Trim()); //分值
objge_StuBatchQuesRelaEN.Score = objRow[conge_StuBatchQuesRela.Score] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conge_StuBatchQuesRela.Score].ToString().Trim()); //得分
objge_StuBatchQuesRelaEN.StuAnswerText = objRow[conge_StuBatchQuesRela.StuAnswerText] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.StuAnswerText].ToString().Trim(); //学生回答文本
objge_StuBatchQuesRelaEN.AnswerDate = objRow[conge_StuBatchQuesRela.AnswerDate] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerDate].ToString().Trim(); //回答日期
objge_StuBatchQuesRelaEN.AnswerIP = objRow[conge_StuBatchQuesRela.AnswerIP] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerIP].ToString().Trim(); //回答IP
objge_StuBatchQuesRelaEN.AnswerModeId = objRow[conge_StuBatchQuesRela.AnswerModeId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerModeId].ToString().Trim(); //答案模式Id
objge_StuBatchQuesRelaEN.AnswerMultiOptions = objRow[conge_StuBatchQuesRela.AnswerMultiOptions] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerMultiOptions].ToString().Trim(); //多选项答案
objge_StuBatchQuesRelaEN.AnswerOptionId = objRow[conge_StuBatchQuesRela.AnswerOptionId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerOptionId].ToString().Trim(); //回答选项Id
objge_StuBatchQuesRelaEN.AnswerTime = objRow[conge_StuBatchQuesRela.AnswerTime] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerTime].ToString().Trim(); //回答时间
objge_StuBatchQuesRelaEN.ApplySendBackDate = objRow[conge_StuBatchQuesRela.ApplySendBackDate] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.ApplySendBackDate].ToString().Trim(); //申请退回日期
objge_StuBatchQuesRelaEN.Comment = objRow[conge_StuBatchQuesRela.Comment] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.Comment].ToString().Trim(); //批注
objge_StuBatchQuesRelaEN.IsAccessKnowledge = TransNullToBool(objRow[conge_StuBatchQuesRela.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objge_StuBatchQuesRelaEN.IsApplySendBack = TransNullToBool(objRow[conge_StuBatchQuesRela.IsApplySendBack].ToString().Trim()); //是否申请退回
objge_StuBatchQuesRelaEN.IsInErrorQuestion = TransNullToBool(objRow[conge_StuBatchQuesRela.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objge_StuBatchQuesRelaEN.IsLook = TransNullToBool(objRow[conge_StuBatchQuesRela.IsLook].ToString().Trim()); //是否查看
objge_StuBatchQuesRelaEN.IsMarking = TransNullToBool(objRow[conge_StuBatchQuesRela.IsMarking].ToString().Trim()); //是否批阅
objge_StuBatchQuesRelaEN.IsNotProcessTimeout = TransNullToBool(objRow[conge_StuBatchQuesRela.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objge_StuBatchQuesRelaEN.IsHasAnswer = TransNullToBool(objRow[conge_StuBatchQuesRela.IsHasAnswer].ToString().Trim()); //是否有答案
objge_StuBatchQuesRelaEN.IsPublish = TransNullToBool(objRow[conge_StuBatchQuesRela.IsPublish].ToString().Trim()); //是否发布
objge_StuBatchQuesRelaEN.IsRight = TransNullToBool(objRow[conge_StuBatchQuesRela.IsRight].ToString().Trim()); //是否正确
objge_StuBatchQuesRelaEN.IsSave = TransNullToBool(objRow[conge_StuBatchQuesRela.IsSave].ToString().Trim()); //是否保存
objge_StuBatchQuesRelaEN.IsSendBack = TransNullToBool(objRow[conge_StuBatchQuesRela.IsSendBack].ToString().Trim()); //是否退回
objge_StuBatchQuesRelaEN.IsSubmit = TransNullToBool(objRow[conge_StuBatchQuesRela.IsSubmit].ToString().Trim()); //是否提交
objge_StuBatchQuesRelaEN.MarkDate = objRow[conge_StuBatchQuesRela.MarkDate] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.MarkDate].ToString().Trim(); //打分日期
objge_StuBatchQuesRelaEN.MarkerId = objRow[conge_StuBatchQuesRela.MarkerId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.MarkerId].ToString().Trim(); //打分者
objge_StuBatchQuesRelaEN.OperateTime = objRow[conge_StuBatchQuesRela.OperateTime] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.OperateTime].ToString().Trim(); //操作时间
objge_StuBatchQuesRelaEN.RealFinishDate = objRow[conge_StuBatchQuesRela.RealFinishDate] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.RealFinishDate].ToString().Trim(); //实际完成日期
objge_StuBatchQuesRelaEN.WorkTypeId = objRow[conge_StuBatchQuesRela.WorkTypeId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.WorkTypeId].ToString().Trim(); //作业类型Id
objge_StuBatchQuesRelaEN.SchoolYear = objRow[conge_StuBatchQuesRela.SchoolYear] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.SchoolYear].ToString().Trim(); //学年
objge_StuBatchQuesRelaEN.SchoolTerm = objRow[conge_StuBatchQuesRela.SchoolTerm] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.SchoolTerm].ToString().Trim(); //学期
objge_StuBatchQuesRelaEN.ErrMsg = objRow[conge_StuBatchQuesRela.ErrMsg] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.ErrMsg].ToString().Trim(); //错误信息
objge_StuBatchQuesRelaEN.IsRecommend = TransNullToBool(objRow[conge_StuBatchQuesRela.IsRecommend].ToString().Trim()); //是否推荐
objge_StuBatchQuesRelaEN.CourseId = objRow[conge_StuBatchQuesRela.CourseId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.CourseId].ToString().Trim(); //课程Id
objge_StuBatchQuesRelaEN.UpdDate = objRow[conge_StuBatchQuesRela.UpdDate].ToString().Trim(); //修改日期
objge_StuBatchQuesRelaEN.UpdUserId = objRow[conge_StuBatchQuesRela.UpdUserId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.UpdUserId].ToString().Trim(); //修改用户Id
objge_StuBatchQuesRelaEN.Memo = objRow[conge_StuBatchQuesRela.Memo] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsge_StuBatchQuesRelaDA: GetObjLst)", objException.Message));
}
objge_StuBatchQuesRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objge_StuBatchQuesRelaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objge_StuBatchQuesRelaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getge_StuBatchQuesRela(ref clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StuBatchQuesRelaDA.GetSpecSQLObj();
strSQL = "Select * from ge_StuBatchQuesRela where IdStuBatchQuesRela = " + ""+ objge_StuBatchQuesRelaEN.IdStuBatchQuesRela+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objge_StuBatchQuesRelaEN.IdStuBatchQuesRela = TransNullToInt(objDT.Rows[0][conge_StuBatchQuesRela.IdStuBatchQuesRela].ToString().Trim()); //学生批次题目关系流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objge_StuBatchQuesRelaEN.ExamBatchNo = objDT.Rows[0][conge_StuBatchQuesRela.ExamBatchNo].ToString().Trim(); //学生批次号(字段类型:varchar,字段长度:20,是否可空:False)
 objge_StuBatchQuesRelaEN.LevelNo = TransNullToInt(objDT.Rows[0][conge_StuBatchQuesRela.LevelNo].ToString().Trim()); //学习关号2(字段类型:int,字段长度:4,是否可空:True)
 objge_StuBatchQuesRelaEN.QuestionId = TransNullToInt(objDT.Rows[0][conge_StuBatchQuesRela.QuestionId].ToString().Trim()); //题目Id(字段类型:bigint,字段长度:8,是否可空:True)
 objge_StuBatchQuesRelaEN.UserId = objDT.Rows[0][conge_StuBatchQuesRela.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objge_StuBatchQuesRelaEN.IdCurrEduCls = objDT.Rows[0][conge_StuBatchQuesRela.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objge_StuBatchQuesRelaEN.QuestionIndex4Batch = TransNullToInt(objDT.Rows[0][conge_StuBatchQuesRela.QuestionIndex4Batch].ToString().Trim()); //题序号4批次(字段类型:int,字段长度:4,是否可空:True)
 objge_StuBatchQuesRelaEN.GameLevelId = objDT.Rows[0][conge_StuBatchQuesRela.GameLevelId].ToString().Trim(); //游戏关卡Id(字段类型:char,字段长度:8,是否可空:True)
 objge_StuBatchQuesRelaEN.Scores = TransNullToDouble(objDT.Rows[0][conge_StuBatchQuesRela.Scores].ToString().Trim()); //分值(字段类型:decimal,字段长度:8,是否可空:True)
 objge_StuBatchQuesRelaEN.Score = TransNullToDouble(objDT.Rows[0][conge_StuBatchQuesRela.Score].ToString().Trim()); //得分(字段类型:decimal,字段长度:6,是否可空:True)
 objge_StuBatchQuesRelaEN.StuAnswerText = objDT.Rows[0][conge_StuBatchQuesRela.StuAnswerText].ToString().Trim(); //学生回答文本(字段类型:text,字段长度:2147483647,是否可空:True)
 objge_StuBatchQuesRelaEN.AnswerDate = objDT.Rows[0][conge_StuBatchQuesRela.AnswerDate].ToString().Trim(); //回答日期(字段类型:varchar,字段长度:8,是否可空:True)
 objge_StuBatchQuesRelaEN.AnswerIP = objDT.Rows[0][conge_StuBatchQuesRela.AnswerIP].ToString().Trim(); //回答IP(字段类型:varchar,字段长度:30,是否可空:True)
 objge_StuBatchQuesRelaEN.AnswerModeId = objDT.Rows[0][conge_StuBatchQuesRela.AnswerModeId].ToString().Trim(); //答案模式Id(字段类型:char,字段长度:4,是否可空:True)
 objge_StuBatchQuesRelaEN.AnswerMultiOptions = objDT.Rows[0][conge_StuBatchQuesRela.AnswerMultiOptions].ToString().Trim(); //多选项答案(字段类型:varchar,字段长度:300,是否可空:True)
 objge_StuBatchQuesRelaEN.AnswerOptionId = objDT.Rows[0][conge_StuBatchQuesRela.AnswerOptionId].ToString().Trim(); //回答选项Id(字段类型:char,字段长度:8,是否可空:True)
 objge_StuBatchQuesRelaEN.AnswerTime = objDT.Rows[0][conge_StuBatchQuesRela.AnswerTime].ToString().Trim(); //回答时间(字段类型:varchar,字段长度:10,是否可空:True)
 objge_StuBatchQuesRelaEN.ApplySendBackDate = objDT.Rows[0][conge_StuBatchQuesRela.ApplySendBackDate].ToString().Trim(); //申请退回日期(字段类型:varchar,字段长度:14,是否可空:True)
 objge_StuBatchQuesRelaEN.Comment = objDT.Rows[0][conge_StuBatchQuesRela.Comment].ToString().Trim(); //批注(字段类型:text,字段长度:2147483647,是否可空:True)
 objge_StuBatchQuesRelaEN.IsAccessKnowledge = TransNullToBool(objDT.Rows[0][conge_StuBatchQuesRela.IsAccessKnowledge].ToString().Trim()); //是否处理知识点(字段类型:bit,字段长度:1,是否可空:True)
 objge_StuBatchQuesRelaEN.IsApplySendBack = TransNullToBool(objDT.Rows[0][conge_StuBatchQuesRela.IsApplySendBack].ToString().Trim()); //是否申请退回(字段类型:bit,字段长度:1,是否可空:True)
 objge_StuBatchQuesRelaEN.IsInErrorQuestion = TransNullToBool(objDT.Rows[0][conge_StuBatchQuesRela.IsInErrorQuestion].ToString().Trim()); //是否进入错题(字段类型:bit,字段长度:1,是否可空:True)
 objge_StuBatchQuesRelaEN.IsLook = TransNullToBool(objDT.Rows[0][conge_StuBatchQuesRela.IsLook].ToString().Trim()); //是否查看(字段类型:bit,字段长度:1,是否可空:True)
 objge_StuBatchQuesRelaEN.IsMarking = TransNullToBool(objDT.Rows[0][conge_StuBatchQuesRela.IsMarking].ToString().Trim()); //是否批阅(字段类型:bit,字段长度:1,是否可空:True)
 objge_StuBatchQuesRelaEN.IsNotProcessTimeout = TransNullToBool(objDT.Rows[0][conge_StuBatchQuesRela.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时(字段类型:bit,字段长度:1,是否可空:True)
 objge_StuBatchQuesRelaEN.IsHasAnswer = TransNullToBool(objDT.Rows[0][conge_StuBatchQuesRela.IsHasAnswer].ToString().Trim()); //是否有答案(字段类型:bit,字段长度:1,是否可空:True)
 objge_StuBatchQuesRelaEN.IsPublish = TransNullToBool(objDT.Rows[0][conge_StuBatchQuesRela.IsPublish].ToString().Trim()); //是否发布(字段类型:bit,字段长度:1,是否可空:True)
 objge_StuBatchQuesRelaEN.IsRight = TransNullToBool(objDT.Rows[0][conge_StuBatchQuesRela.IsRight].ToString().Trim()); //是否正确(字段类型:bit,字段长度:1,是否可空:True)
 objge_StuBatchQuesRelaEN.IsSave = TransNullToBool(objDT.Rows[0][conge_StuBatchQuesRela.IsSave].ToString().Trim()); //是否保存(字段类型:bit,字段长度:1,是否可空:True)
 objge_StuBatchQuesRelaEN.IsSendBack = TransNullToBool(objDT.Rows[0][conge_StuBatchQuesRela.IsSendBack].ToString().Trim()); //是否退回(字段类型:bit,字段长度:1,是否可空:True)
 objge_StuBatchQuesRelaEN.IsSubmit = TransNullToBool(objDT.Rows[0][conge_StuBatchQuesRela.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objge_StuBatchQuesRelaEN.MarkDate = objDT.Rows[0][conge_StuBatchQuesRela.MarkDate].ToString().Trim(); //打分日期(字段类型:varchar,字段长度:14,是否可空:True)
 objge_StuBatchQuesRelaEN.MarkerId = objDT.Rows[0][conge_StuBatchQuesRela.MarkerId].ToString().Trim(); //打分者(字段类型:varchar,字段长度:20,是否可空:True)
 objge_StuBatchQuesRelaEN.OperateTime = objDT.Rows[0][conge_StuBatchQuesRela.OperateTime].ToString().Trim(); //操作时间(字段类型:varchar,字段长度:14,是否可空:True)
 objge_StuBatchQuesRelaEN.RealFinishDate = objDT.Rows[0][conge_StuBatchQuesRela.RealFinishDate].ToString().Trim(); //实际完成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objge_StuBatchQuesRelaEN.WorkTypeId = objDT.Rows[0][conge_StuBatchQuesRela.WorkTypeId].ToString().Trim(); //作业类型Id(字段类型:char,字段长度:2,是否可空:False)
 objge_StuBatchQuesRelaEN.SchoolYear = objDT.Rows[0][conge_StuBatchQuesRela.SchoolYear].ToString().Trim(); //学年(字段类型:varchar,字段长度:10,是否可空:True)
 objge_StuBatchQuesRelaEN.SchoolTerm = objDT.Rows[0][conge_StuBatchQuesRela.SchoolTerm].ToString().Trim(); //学期(字段类型:char,字段长度:1,是否可空:True)
 objge_StuBatchQuesRelaEN.ErrMsg = objDT.Rows[0][conge_StuBatchQuesRela.ErrMsg].ToString().Trim(); //错误信息(字段类型:varchar,字段长度:200,是否可空:True)
 objge_StuBatchQuesRelaEN.IsRecommend = TransNullToBool(objDT.Rows[0][conge_StuBatchQuesRela.IsRecommend].ToString().Trim()); //是否推荐(字段类型:bit,字段长度:1,是否可空:True)
 objge_StuBatchQuesRelaEN.CourseId = objDT.Rows[0][conge_StuBatchQuesRela.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objge_StuBatchQuesRelaEN.UpdDate = objDT.Rows[0][conge_StuBatchQuesRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objge_StuBatchQuesRelaEN.UpdUserId = objDT.Rows[0][conge_StuBatchQuesRela.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objge_StuBatchQuesRelaEN.Memo = objDT.Rows[0][conge_StuBatchQuesRela.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsge_StuBatchQuesRelaDA: Getge_StuBatchQuesRela)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdStuBatchQuesRela">表关键字</param>
 /// <returns>表对象</returns>
public clsge_StuBatchQuesRelaEN GetObjByIdStuBatchQuesRela(long lngIdStuBatchQuesRela)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StuBatchQuesRelaDA.GetSpecSQLObj();
strSQL = "Select * from ge_StuBatchQuesRela where IdStuBatchQuesRela = " + ""+ lngIdStuBatchQuesRela+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN = new clsge_StuBatchQuesRelaEN();
try
{
 objge_StuBatchQuesRelaEN.IdStuBatchQuesRela = Int32.Parse(objRow[conge_StuBatchQuesRela.IdStuBatchQuesRela].ToString().Trim()); //学生批次题目关系流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objge_StuBatchQuesRelaEN.ExamBatchNo = objRow[conge_StuBatchQuesRela.ExamBatchNo].ToString().Trim(); //学生批次号(字段类型:varchar,字段长度:20,是否可空:False)
 objge_StuBatchQuesRelaEN.LevelNo = objRow[conge_StuBatchQuesRela.LevelNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_StuBatchQuesRela.LevelNo].ToString().Trim()); //学习关号2(字段类型:int,字段长度:4,是否可空:True)
 objge_StuBatchQuesRelaEN.QuestionId = Int32.Parse(objRow[conge_StuBatchQuesRela.QuestionId].ToString().Trim()); //题目Id(字段类型:bigint,字段长度:8,是否可空:True)
 objge_StuBatchQuesRelaEN.UserId = objRow[conge_StuBatchQuesRela.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objge_StuBatchQuesRelaEN.IdCurrEduCls = objRow[conge_StuBatchQuesRela.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objge_StuBatchQuesRelaEN.QuestionIndex4Batch = objRow[conge_StuBatchQuesRela.QuestionIndex4Batch] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_StuBatchQuesRela.QuestionIndex4Batch].ToString().Trim()); //题序号4批次(字段类型:int,字段长度:4,是否可空:True)
 objge_StuBatchQuesRelaEN.GameLevelId = objRow[conge_StuBatchQuesRela.GameLevelId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.GameLevelId].ToString().Trim(); //游戏关卡Id(字段类型:char,字段长度:8,是否可空:True)
 objge_StuBatchQuesRelaEN.Scores = objRow[conge_StuBatchQuesRela.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_StuBatchQuesRela.Scores].ToString().Trim()); //分值(字段类型:decimal,字段长度:8,是否可空:True)
 objge_StuBatchQuesRelaEN.Score = objRow[conge_StuBatchQuesRela.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_StuBatchQuesRela.Score].ToString().Trim()); //得分(字段类型:decimal,字段长度:6,是否可空:True)
 objge_StuBatchQuesRelaEN.StuAnswerText = objRow[conge_StuBatchQuesRela.StuAnswerText] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.StuAnswerText].ToString().Trim(); //学生回答文本(字段类型:text,字段长度:2147483647,是否可空:True)
 objge_StuBatchQuesRelaEN.AnswerDate = objRow[conge_StuBatchQuesRela.AnswerDate] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerDate].ToString().Trim(); //回答日期(字段类型:varchar,字段长度:8,是否可空:True)
 objge_StuBatchQuesRelaEN.AnswerIP = objRow[conge_StuBatchQuesRela.AnswerIP] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerIP].ToString().Trim(); //回答IP(字段类型:varchar,字段长度:30,是否可空:True)
 objge_StuBatchQuesRelaEN.AnswerModeId = objRow[conge_StuBatchQuesRela.AnswerModeId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerModeId].ToString().Trim(); //答案模式Id(字段类型:char,字段长度:4,是否可空:True)
 objge_StuBatchQuesRelaEN.AnswerMultiOptions = objRow[conge_StuBatchQuesRela.AnswerMultiOptions] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerMultiOptions].ToString().Trim(); //多选项答案(字段类型:varchar,字段长度:300,是否可空:True)
 objge_StuBatchQuesRelaEN.AnswerOptionId = objRow[conge_StuBatchQuesRela.AnswerOptionId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerOptionId].ToString().Trim(); //回答选项Id(字段类型:char,字段长度:8,是否可空:True)
 objge_StuBatchQuesRelaEN.AnswerTime = objRow[conge_StuBatchQuesRela.AnswerTime] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerTime].ToString().Trim(); //回答时间(字段类型:varchar,字段长度:10,是否可空:True)
 objge_StuBatchQuesRelaEN.ApplySendBackDate = objRow[conge_StuBatchQuesRela.ApplySendBackDate] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.ApplySendBackDate].ToString().Trim(); //申请退回日期(字段类型:varchar,字段长度:14,是否可空:True)
 objge_StuBatchQuesRelaEN.Comment = objRow[conge_StuBatchQuesRela.Comment] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.Comment].ToString().Trim(); //批注(字段类型:text,字段长度:2147483647,是否可空:True)
 objge_StuBatchQuesRelaEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsAccessKnowledge].ToString().Trim()); //是否处理知识点(字段类型:bit,字段长度:1,是否可空:True)
 objge_StuBatchQuesRelaEN.IsApplySendBack = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsApplySendBack].ToString().Trim()); //是否申请退回(字段类型:bit,字段长度:1,是否可空:True)
 objge_StuBatchQuesRelaEN.IsInErrorQuestion = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsInErrorQuestion].ToString().Trim()); //是否进入错题(字段类型:bit,字段长度:1,是否可空:True)
 objge_StuBatchQuesRelaEN.IsLook = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsLook].ToString().Trim()); //是否查看(字段类型:bit,字段长度:1,是否可空:True)
 objge_StuBatchQuesRelaEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsMarking].ToString().Trim()); //是否批阅(字段类型:bit,字段长度:1,是否可空:True)
 objge_StuBatchQuesRelaEN.IsNotProcessTimeout = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时(字段类型:bit,字段长度:1,是否可空:True)
 objge_StuBatchQuesRelaEN.IsHasAnswer = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsHasAnswer].ToString().Trim()); //是否有答案(字段类型:bit,字段长度:1,是否可空:True)
 objge_StuBatchQuesRelaEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsPublish].ToString().Trim()); //是否发布(字段类型:bit,字段长度:1,是否可空:True)
 objge_StuBatchQuesRelaEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsRight].ToString().Trim()); //是否正确(字段类型:bit,字段长度:1,是否可空:True)
 objge_StuBatchQuesRelaEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsSave].ToString().Trim()); //是否保存(字段类型:bit,字段长度:1,是否可空:True)
 objge_StuBatchQuesRelaEN.IsSendBack = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsSendBack].ToString().Trim()); //是否退回(字段类型:bit,字段长度:1,是否可空:True)
 objge_StuBatchQuesRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objge_StuBatchQuesRelaEN.MarkDate = objRow[conge_StuBatchQuesRela.MarkDate] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.MarkDate].ToString().Trim(); //打分日期(字段类型:varchar,字段长度:14,是否可空:True)
 objge_StuBatchQuesRelaEN.MarkerId = objRow[conge_StuBatchQuesRela.MarkerId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.MarkerId].ToString().Trim(); //打分者(字段类型:varchar,字段长度:20,是否可空:True)
 objge_StuBatchQuesRelaEN.OperateTime = objRow[conge_StuBatchQuesRela.OperateTime] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.OperateTime].ToString().Trim(); //操作时间(字段类型:varchar,字段长度:14,是否可空:True)
 objge_StuBatchQuesRelaEN.RealFinishDate = objRow[conge_StuBatchQuesRela.RealFinishDate] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.RealFinishDate].ToString().Trim(); //实际完成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objge_StuBatchQuesRelaEN.WorkTypeId = objRow[conge_StuBatchQuesRela.WorkTypeId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.WorkTypeId].ToString().Trim(); //作业类型Id(字段类型:char,字段长度:2,是否可空:False)
 objge_StuBatchQuesRelaEN.SchoolYear = objRow[conge_StuBatchQuesRela.SchoolYear] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.SchoolYear].ToString().Trim(); //学年(字段类型:varchar,字段长度:10,是否可空:True)
 objge_StuBatchQuesRelaEN.SchoolTerm = objRow[conge_StuBatchQuesRela.SchoolTerm] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.SchoolTerm].ToString().Trim(); //学期(字段类型:char,字段长度:1,是否可空:True)
 objge_StuBatchQuesRelaEN.ErrMsg = objRow[conge_StuBatchQuesRela.ErrMsg] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.ErrMsg].ToString().Trim(); //错误信息(字段类型:varchar,字段长度:200,是否可空:True)
 objge_StuBatchQuesRelaEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsRecommend].ToString().Trim()); //是否推荐(字段类型:bit,字段长度:1,是否可空:True)
 objge_StuBatchQuesRelaEN.CourseId = objRow[conge_StuBatchQuesRela.CourseId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objge_StuBatchQuesRelaEN.UpdDate = objRow[conge_StuBatchQuesRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objge_StuBatchQuesRelaEN.UpdUserId = objRow[conge_StuBatchQuesRela.UpdUserId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objge_StuBatchQuesRelaEN.Memo = objRow[conge_StuBatchQuesRela.Memo] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsge_StuBatchQuesRelaDA: GetObjByIdStuBatchQuesRela)", objException.Message));
}
return objge_StuBatchQuesRelaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsge_StuBatchQuesRelaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsge_StuBatchQuesRelaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StuBatchQuesRelaDA.GetSpecSQLObj();
strSQL = "Select * from ge_StuBatchQuesRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN = new clsge_StuBatchQuesRelaEN()
{
IdStuBatchQuesRela = TransNullToInt(objRow[conge_StuBatchQuesRela.IdStuBatchQuesRela].ToString().Trim()), //学生批次题目关系流水号
ExamBatchNo = objRow[conge_StuBatchQuesRela.ExamBatchNo].ToString().Trim(), //学生批次号
LevelNo = objRow[conge_StuBatchQuesRela.LevelNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conge_StuBatchQuesRela.LevelNo].ToString().Trim()), //学习关号2
QuestionId = TransNullToInt(objRow[conge_StuBatchQuesRela.QuestionId].ToString().Trim()), //题目Id
UserId = objRow[conge_StuBatchQuesRela.UserId].ToString().Trim(), //用户ID
IdCurrEduCls = objRow[conge_StuBatchQuesRela.IdCurrEduCls].ToString().Trim(), //教学班流水号
QuestionIndex4Batch = objRow[conge_StuBatchQuesRela.QuestionIndex4Batch] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conge_StuBatchQuesRela.QuestionIndex4Batch].ToString().Trim()), //题序号4批次
GameLevelId = objRow[conge_StuBatchQuesRela.GameLevelId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.GameLevelId].ToString().Trim(), //游戏关卡Id
Scores = objRow[conge_StuBatchQuesRela.Scores] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conge_StuBatchQuesRela.Scores].ToString().Trim()), //分值
Score = objRow[conge_StuBatchQuesRela.Score] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conge_StuBatchQuesRela.Score].ToString().Trim()), //得分
StuAnswerText = objRow[conge_StuBatchQuesRela.StuAnswerText] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.StuAnswerText].ToString().Trim(), //学生回答文本
AnswerDate = objRow[conge_StuBatchQuesRela.AnswerDate] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerDate].ToString().Trim(), //回答日期
AnswerIP = objRow[conge_StuBatchQuesRela.AnswerIP] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerIP].ToString().Trim(), //回答IP
AnswerModeId = objRow[conge_StuBatchQuesRela.AnswerModeId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerModeId].ToString().Trim(), //答案模式Id
AnswerMultiOptions = objRow[conge_StuBatchQuesRela.AnswerMultiOptions] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerMultiOptions].ToString().Trim(), //多选项答案
AnswerOptionId = objRow[conge_StuBatchQuesRela.AnswerOptionId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerOptionId].ToString().Trim(), //回答选项Id
AnswerTime = objRow[conge_StuBatchQuesRela.AnswerTime] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerTime].ToString().Trim(), //回答时间
ApplySendBackDate = objRow[conge_StuBatchQuesRela.ApplySendBackDate] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.ApplySendBackDate].ToString().Trim(), //申请退回日期
Comment = objRow[conge_StuBatchQuesRela.Comment] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.Comment].ToString().Trim(), //批注
IsAccessKnowledge = TransNullToBool(objRow[conge_StuBatchQuesRela.IsAccessKnowledge].ToString().Trim()), //是否处理知识点
IsApplySendBack = TransNullToBool(objRow[conge_StuBatchQuesRela.IsApplySendBack].ToString().Trim()), //是否申请退回
IsInErrorQuestion = TransNullToBool(objRow[conge_StuBatchQuesRela.IsInErrorQuestion].ToString().Trim()), //是否进入错题
IsLook = TransNullToBool(objRow[conge_StuBatchQuesRela.IsLook].ToString().Trim()), //是否查看
IsMarking = TransNullToBool(objRow[conge_StuBatchQuesRela.IsMarking].ToString().Trim()), //是否批阅
IsNotProcessTimeout = TransNullToBool(objRow[conge_StuBatchQuesRela.IsNotProcessTimeout].ToString().Trim()), //是否不处理超时
IsHasAnswer = TransNullToBool(objRow[conge_StuBatchQuesRela.IsHasAnswer].ToString().Trim()), //是否有答案
IsPublish = TransNullToBool(objRow[conge_StuBatchQuesRela.IsPublish].ToString().Trim()), //是否发布
IsRight = TransNullToBool(objRow[conge_StuBatchQuesRela.IsRight].ToString().Trim()), //是否正确
IsSave = TransNullToBool(objRow[conge_StuBatchQuesRela.IsSave].ToString().Trim()), //是否保存
IsSendBack = TransNullToBool(objRow[conge_StuBatchQuesRela.IsSendBack].ToString().Trim()), //是否退回
IsSubmit = TransNullToBool(objRow[conge_StuBatchQuesRela.IsSubmit].ToString().Trim()), //是否提交
MarkDate = objRow[conge_StuBatchQuesRela.MarkDate] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.MarkDate].ToString().Trim(), //打分日期
MarkerId = objRow[conge_StuBatchQuesRela.MarkerId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.MarkerId].ToString().Trim(), //打分者
OperateTime = objRow[conge_StuBatchQuesRela.OperateTime] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.OperateTime].ToString().Trim(), //操作时间
RealFinishDate = objRow[conge_StuBatchQuesRela.RealFinishDate] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.RealFinishDate].ToString().Trim(), //实际完成日期
WorkTypeId = objRow[conge_StuBatchQuesRela.WorkTypeId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.WorkTypeId].ToString().Trim(), //作业类型Id
SchoolYear = objRow[conge_StuBatchQuesRela.SchoolYear] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.SchoolYear].ToString().Trim(), //学年
SchoolTerm = objRow[conge_StuBatchQuesRela.SchoolTerm] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.SchoolTerm].ToString().Trim(), //学期
ErrMsg = objRow[conge_StuBatchQuesRela.ErrMsg] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.ErrMsg].ToString().Trim(), //错误信息
IsRecommend = TransNullToBool(objRow[conge_StuBatchQuesRela.IsRecommend].ToString().Trim()), //是否推荐
CourseId = objRow[conge_StuBatchQuesRela.CourseId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.CourseId].ToString().Trim(), //课程Id
UpdDate = objRow[conge_StuBatchQuesRela.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[conge_StuBatchQuesRela.UpdUserId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[conge_StuBatchQuesRela.Memo] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.Memo].ToString().Trim() //备注
};
objge_StuBatchQuesRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objge_StuBatchQuesRelaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsge_StuBatchQuesRelaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsge_StuBatchQuesRelaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN = new clsge_StuBatchQuesRelaEN();
try
{
objge_StuBatchQuesRelaEN.IdStuBatchQuesRela = TransNullToInt(objRow[conge_StuBatchQuesRela.IdStuBatchQuesRela].ToString().Trim()); //学生批次题目关系流水号
objge_StuBatchQuesRelaEN.ExamBatchNo = objRow[conge_StuBatchQuesRela.ExamBatchNo].ToString().Trim(); //学生批次号
objge_StuBatchQuesRelaEN.LevelNo = objRow[conge_StuBatchQuesRela.LevelNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conge_StuBatchQuesRela.LevelNo].ToString().Trim()); //学习关号2
objge_StuBatchQuesRelaEN.QuestionId = TransNullToInt(objRow[conge_StuBatchQuesRela.QuestionId].ToString().Trim()); //题目Id
objge_StuBatchQuesRelaEN.UserId = objRow[conge_StuBatchQuesRela.UserId].ToString().Trim(); //用户ID
objge_StuBatchQuesRelaEN.IdCurrEduCls = objRow[conge_StuBatchQuesRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objge_StuBatchQuesRelaEN.QuestionIndex4Batch = objRow[conge_StuBatchQuesRela.QuestionIndex4Batch] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conge_StuBatchQuesRela.QuestionIndex4Batch].ToString().Trim()); //题序号4批次
objge_StuBatchQuesRelaEN.GameLevelId = objRow[conge_StuBatchQuesRela.GameLevelId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.GameLevelId].ToString().Trim(); //游戏关卡Id
objge_StuBatchQuesRelaEN.Scores = objRow[conge_StuBatchQuesRela.Scores] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conge_StuBatchQuesRela.Scores].ToString().Trim()); //分值
objge_StuBatchQuesRelaEN.Score = objRow[conge_StuBatchQuesRela.Score] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conge_StuBatchQuesRela.Score].ToString().Trim()); //得分
objge_StuBatchQuesRelaEN.StuAnswerText = objRow[conge_StuBatchQuesRela.StuAnswerText] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.StuAnswerText].ToString().Trim(); //学生回答文本
objge_StuBatchQuesRelaEN.AnswerDate = objRow[conge_StuBatchQuesRela.AnswerDate] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerDate].ToString().Trim(); //回答日期
objge_StuBatchQuesRelaEN.AnswerIP = objRow[conge_StuBatchQuesRela.AnswerIP] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerIP].ToString().Trim(); //回答IP
objge_StuBatchQuesRelaEN.AnswerModeId = objRow[conge_StuBatchQuesRela.AnswerModeId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerModeId].ToString().Trim(); //答案模式Id
objge_StuBatchQuesRelaEN.AnswerMultiOptions = objRow[conge_StuBatchQuesRela.AnswerMultiOptions] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerMultiOptions].ToString().Trim(); //多选项答案
objge_StuBatchQuesRelaEN.AnswerOptionId = objRow[conge_StuBatchQuesRela.AnswerOptionId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerOptionId].ToString().Trim(); //回答选项Id
objge_StuBatchQuesRelaEN.AnswerTime = objRow[conge_StuBatchQuesRela.AnswerTime] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerTime].ToString().Trim(); //回答时间
objge_StuBatchQuesRelaEN.ApplySendBackDate = objRow[conge_StuBatchQuesRela.ApplySendBackDate] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.ApplySendBackDate].ToString().Trim(); //申请退回日期
objge_StuBatchQuesRelaEN.Comment = objRow[conge_StuBatchQuesRela.Comment] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.Comment].ToString().Trim(); //批注
objge_StuBatchQuesRelaEN.IsAccessKnowledge = TransNullToBool(objRow[conge_StuBatchQuesRela.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objge_StuBatchQuesRelaEN.IsApplySendBack = TransNullToBool(objRow[conge_StuBatchQuesRela.IsApplySendBack].ToString().Trim()); //是否申请退回
objge_StuBatchQuesRelaEN.IsInErrorQuestion = TransNullToBool(objRow[conge_StuBatchQuesRela.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objge_StuBatchQuesRelaEN.IsLook = TransNullToBool(objRow[conge_StuBatchQuesRela.IsLook].ToString().Trim()); //是否查看
objge_StuBatchQuesRelaEN.IsMarking = TransNullToBool(objRow[conge_StuBatchQuesRela.IsMarking].ToString().Trim()); //是否批阅
objge_StuBatchQuesRelaEN.IsNotProcessTimeout = TransNullToBool(objRow[conge_StuBatchQuesRela.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objge_StuBatchQuesRelaEN.IsHasAnswer = TransNullToBool(objRow[conge_StuBatchQuesRela.IsHasAnswer].ToString().Trim()); //是否有答案
objge_StuBatchQuesRelaEN.IsPublish = TransNullToBool(objRow[conge_StuBatchQuesRela.IsPublish].ToString().Trim()); //是否发布
objge_StuBatchQuesRelaEN.IsRight = TransNullToBool(objRow[conge_StuBatchQuesRela.IsRight].ToString().Trim()); //是否正确
objge_StuBatchQuesRelaEN.IsSave = TransNullToBool(objRow[conge_StuBatchQuesRela.IsSave].ToString().Trim()); //是否保存
objge_StuBatchQuesRelaEN.IsSendBack = TransNullToBool(objRow[conge_StuBatchQuesRela.IsSendBack].ToString().Trim()); //是否退回
objge_StuBatchQuesRelaEN.IsSubmit = TransNullToBool(objRow[conge_StuBatchQuesRela.IsSubmit].ToString().Trim()); //是否提交
objge_StuBatchQuesRelaEN.MarkDate = objRow[conge_StuBatchQuesRela.MarkDate] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.MarkDate].ToString().Trim(); //打分日期
objge_StuBatchQuesRelaEN.MarkerId = objRow[conge_StuBatchQuesRela.MarkerId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.MarkerId].ToString().Trim(); //打分者
objge_StuBatchQuesRelaEN.OperateTime = objRow[conge_StuBatchQuesRela.OperateTime] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.OperateTime].ToString().Trim(); //操作时间
objge_StuBatchQuesRelaEN.RealFinishDate = objRow[conge_StuBatchQuesRela.RealFinishDate] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.RealFinishDate].ToString().Trim(); //实际完成日期
objge_StuBatchQuesRelaEN.WorkTypeId = objRow[conge_StuBatchQuesRela.WorkTypeId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.WorkTypeId].ToString().Trim(); //作业类型Id
objge_StuBatchQuesRelaEN.SchoolYear = objRow[conge_StuBatchQuesRela.SchoolYear] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.SchoolYear].ToString().Trim(); //学年
objge_StuBatchQuesRelaEN.SchoolTerm = objRow[conge_StuBatchQuesRela.SchoolTerm] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.SchoolTerm].ToString().Trim(); //学期
objge_StuBatchQuesRelaEN.ErrMsg = objRow[conge_StuBatchQuesRela.ErrMsg] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.ErrMsg].ToString().Trim(); //错误信息
objge_StuBatchQuesRelaEN.IsRecommend = TransNullToBool(objRow[conge_StuBatchQuesRela.IsRecommend].ToString().Trim()); //是否推荐
objge_StuBatchQuesRelaEN.CourseId = objRow[conge_StuBatchQuesRela.CourseId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.CourseId].ToString().Trim(); //课程Id
objge_StuBatchQuesRelaEN.UpdDate = objRow[conge_StuBatchQuesRela.UpdDate].ToString().Trim(); //修改日期
objge_StuBatchQuesRelaEN.UpdUserId = objRow[conge_StuBatchQuesRela.UpdUserId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.UpdUserId].ToString().Trim(); //修改用户Id
objge_StuBatchQuesRelaEN.Memo = objRow[conge_StuBatchQuesRela.Memo] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsge_StuBatchQuesRelaDA: GetObjByDataRowge_StuBatchQuesRela)", objException.Message));
}
objge_StuBatchQuesRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objge_StuBatchQuesRelaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsge_StuBatchQuesRelaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN = new clsge_StuBatchQuesRelaEN();
try
{
objge_StuBatchQuesRelaEN.IdStuBatchQuesRela = TransNullToInt(objRow[conge_StuBatchQuesRela.IdStuBatchQuesRela].ToString().Trim()); //学生批次题目关系流水号
objge_StuBatchQuesRelaEN.ExamBatchNo = objRow[conge_StuBatchQuesRela.ExamBatchNo].ToString().Trim(); //学生批次号
objge_StuBatchQuesRelaEN.LevelNo = objRow[conge_StuBatchQuesRela.LevelNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conge_StuBatchQuesRela.LevelNo].ToString().Trim()); //学习关号2
objge_StuBatchQuesRelaEN.QuestionId = TransNullToInt(objRow[conge_StuBatchQuesRela.QuestionId].ToString().Trim()); //题目Id
objge_StuBatchQuesRelaEN.UserId = objRow[conge_StuBatchQuesRela.UserId].ToString().Trim(); //用户ID
objge_StuBatchQuesRelaEN.IdCurrEduCls = objRow[conge_StuBatchQuesRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objge_StuBatchQuesRelaEN.QuestionIndex4Batch = objRow[conge_StuBatchQuesRela.QuestionIndex4Batch] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conge_StuBatchQuesRela.QuestionIndex4Batch].ToString().Trim()); //题序号4批次
objge_StuBatchQuesRelaEN.GameLevelId = objRow[conge_StuBatchQuesRela.GameLevelId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.GameLevelId].ToString().Trim(); //游戏关卡Id
objge_StuBatchQuesRelaEN.Scores = objRow[conge_StuBatchQuesRela.Scores] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conge_StuBatchQuesRela.Scores].ToString().Trim()); //分值
objge_StuBatchQuesRelaEN.Score = objRow[conge_StuBatchQuesRela.Score] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conge_StuBatchQuesRela.Score].ToString().Trim()); //得分
objge_StuBatchQuesRelaEN.StuAnswerText = objRow[conge_StuBatchQuesRela.StuAnswerText] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.StuAnswerText].ToString().Trim(); //学生回答文本
objge_StuBatchQuesRelaEN.AnswerDate = objRow[conge_StuBatchQuesRela.AnswerDate] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerDate].ToString().Trim(); //回答日期
objge_StuBatchQuesRelaEN.AnswerIP = objRow[conge_StuBatchQuesRela.AnswerIP] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerIP].ToString().Trim(); //回答IP
objge_StuBatchQuesRelaEN.AnswerModeId = objRow[conge_StuBatchQuesRela.AnswerModeId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerModeId].ToString().Trim(); //答案模式Id
objge_StuBatchQuesRelaEN.AnswerMultiOptions = objRow[conge_StuBatchQuesRela.AnswerMultiOptions] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerMultiOptions].ToString().Trim(); //多选项答案
objge_StuBatchQuesRelaEN.AnswerOptionId = objRow[conge_StuBatchQuesRela.AnswerOptionId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerOptionId].ToString().Trim(); //回答选项Id
objge_StuBatchQuesRelaEN.AnswerTime = objRow[conge_StuBatchQuesRela.AnswerTime] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerTime].ToString().Trim(); //回答时间
objge_StuBatchQuesRelaEN.ApplySendBackDate = objRow[conge_StuBatchQuesRela.ApplySendBackDate] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.ApplySendBackDate].ToString().Trim(); //申请退回日期
objge_StuBatchQuesRelaEN.Comment = objRow[conge_StuBatchQuesRela.Comment] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.Comment].ToString().Trim(); //批注
objge_StuBatchQuesRelaEN.IsAccessKnowledge = TransNullToBool(objRow[conge_StuBatchQuesRela.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objge_StuBatchQuesRelaEN.IsApplySendBack = TransNullToBool(objRow[conge_StuBatchQuesRela.IsApplySendBack].ToString().Trim()); //是否申请退回
objge_StuBatchQuesRelaEN.IsInErrorQuestion = TransNullToBool(objRow[conge_StuBatchQuesRela.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objge_StuBatchQuesRelaEN.IsLook = TransNullToBool(objRow[conge_StuBatchQuesRela.IsLook].ToString().Trim()); //是否查看
objge_StuBatchQuesRelaEN.IsMarking = TransNullToBool(objRow[conge_StuBatchQuesRela.IsMarking].ToString().Trim()); //是否批阅
objge_StuBatchQuesRelaEN.IsNotProcessTimeout = TransNullToBool(objRow[conge_StuBatchQuesRela.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objge_StuBatchQuesRelaEN.IsHasAnswer = TransNullToBool(objRow[conge_StuBatchQuesRela.IsHasAnswer].ToString().Trim()); //是否有答案
objge_StuBatchQuesRelaEN.IsPublish = TransNullToBool(objRow[conge_StuBatchQuesRela.IsPublish].ToString().Trim()); //是否发布
objge_StuBatchQuesRelaEN.IsRight = TransNullToBool(objRow[conge_StuBatchQuesRela.IsRight].ToString().Trim()); //是否正确
objge_StuBatchQuesRelaEN.IsSave = TransNullToBool(objRow[conge_StuBatchQuesRela.IsSave].ToString().Trim()); //是否保存
objge_StuBatchQuesRelaEN.IsSendBack = TransNullToBool(objRow[conge_StuBatchQuesRela.IsSendBack].ToString().Trim()); //是否退回
objge_StuBatchQuesRelaEN.IsSubmit = TransNullToBool(objRow[conge_StuBatchQuesRela.IsSubmit].ToString().Trim()); //是否提交
objge_StuBatchQuesRelaEN.MarkDate = objRow[conge_StuBatchQuesRela.MarkDate] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.MarkDate].ToString().Trim(); //打分日期
objge_StuBatchQuesRelaEN.MarkerId = objRow[conge_StuBatchQuesRela.MarkerId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.MarkerId].ToString().Trim(); //打分者
objge_StuBatchQuesRelaEN.OperateTime = objRow[conge_StuBatchQuesRela.OperateTime] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.OperateTime].ToString().Trim(); //操作时间
objge_StuBatchQuesRelaEN.RealFinishDate = objRow[conge_StuBatchQuesRela.RealFinishDate] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.RealFinishDate].ToString().Trim(); //实际完成日期
objge_StuBatchQuesRelaEN.WorkTypeId = objRow[conge_StuBatchQuesRela.WorkTypeId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.WorkTypeId].ToString().Trim(); //作业类型Id
objge_StuBatchQuesRelaEN.SchoolYear = objRow[conge_StuBatchQuesRela.SchoolYear] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.SchoolYear].ToString().Trim(); //学年
objge_StuBatchQuesRelaEN.SchoolTerm = objRow[conge_StuBatchQuesRela.SchoolTerm] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.SchoolTerm].ToString().Trim(); //学期
objge_StuBatchQuesRelaEN.ErrMsg = objRow[conge_StuBatchQuesRela.ErrMsg] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.ErrMsg].ToString().Trim(); //错误信息
objge_StuBatchQuesRelaEN.IsRecommend = TransNullToBool(objRow[conge_StuBatchQuesRela.IsRecommend].ToString().Trim()); //是否推荐
objge_StuBatchQuesRelaEN.CourseId = objRow[conge_StuBatchQuesRela.CourseId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.CourseId].ToString().Trim(); //课程Id
objge_StuBatchQuesRelaEN.UpdDate = objRow[conge_StuBatchQuesRela.UpdDate].ToString().Trim(); //修改日期
objge_StuBatchQuesRelaEN.UpdUserId = objRow[conge_StuBatchQuesRela.UpdUserId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.UpdUserId].ToString().Trim(); //修改用户Id
objge_StuBatchQuesRelaEN.Memo = objRow[conge_StuBatchQuesRela.Memo] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsge_StuBatchQuesRelaDA: GetObjByDataRow)", objException.Message));
}
objge_StuBatchQuesRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objge_StuBatchQuesRelaEN;
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
objSQL = clsge_StuBatchQuesRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsge_StuBatchQuesRelaEN._CurrTabName, conge_StuBatchQuesRela.IdStuBatchQuesRela, 8, "");
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
objSQL = clsge_StuBatchQuesRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsge_StuBatchQuesRelaEN._CurrTabName, conge_StuBatchQuesRela.IdStuBatchQuesRela, 8, strPrefix);
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
 objSQL = clsge_StuBatchQuesRelaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdStuBatchQuesRela from ge_StuBatchQuesRela where " + strCondition;
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
 objSQL = clsge_StuBatchQuesRelaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdStuBatchQuesRela from ge_StuBatchQuesRela where " + strCondition;
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
 /// <param name = "lngIdStuBatchQuesRela">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngIdStuBatchQuesRela)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StuBatchQuesRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ge_StuBatchQuesRela", "IdStuBatchQuesRela = " + ""+ lngIdStuBatchQuesRela+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsge_StuBatchQuesRelaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StuBatchQuesRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ge_StuBatchQuesRela", strCondition))
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
objSQL = clsge_StuBatchQuesRelaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("ge_StuBatchQuesRela");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN)
 {
 objge_StuBatchQuesRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objge_StuBatchQuesRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objge_StuBatchQuesRelaEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StuBatchQuesRelaDA.GetSpecSQLObj();
strSQL = "Select * from ge_StuBatchQuesRela where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ge_StuBatchQuesRela");
objRow = objDS.Tables["ge_StuBatchQuesRela"].NewRow();
objRow[conge_StuBatchQuesRela.ExamBatchNo] = objge_StuBatchQuesRelaEN.ExamBatchNo; //学生批次号
objRow[conge_StuBatchQuesRela.LevelNo] = objge_StuBatchQuesRelaEN.LevelNo; //学习关号2
objRow[conge_StuBatchQuesRela.QuestionId] = objge_StuBatchQuesRelaEN.QuestionId; //题目Id
objRow[conge_StuBatchQuesRela.UserId] = objge_StuBatchQuesRelaEN.UserId; //用户ID
objRow[conge_StuBatchQuesRela.IdCurrEduCls] = objge_StuBatchQuesRelaEN.IdCurrEduCls; //教学班流水号
objRow[conge_StuBatchQuesRela.QuestionIndex4Batch] = objge_StuBatchQuesRelaEN.QuestionIndex4Batch; //题序号4批次
 if (objge_StuBatchQuesRelaEN.GameLevelId !=  "")
 {
objRow[conge_StuBatchQuesRela.GameLevelId] = objge_StuBatchQuesRelaEN.GameLevelId; //游戏关卡Id
 }
objRow[conge_StuBatchQuesRela.Scores] = objge_StuBatchQuesRelaEN.Scores; //分值
objRow[conge_StuBatchQuesRela.Score] = objge_StuBatchQuesRelaEN.Score; //得分
 if (objge_StuBatchQuesRelaEN.StuAnswerText !=  "")
 {
objRow[conge_StuBatchQuesRela.StuAnswerText] = objge_StuBatchQuesRelaEN.StuAnswerText; //学生回答文本
 }
 if (objge_StuBatchQuesRelaEN.AnswerDate !=  "")
 {
objRow[conge_StuBatchQuesRela.AnswerDate] = objge_StuBatchQuesRelaEN.AnswerDate; //回答日期
 }
 if (objge_StuBatchQuesRelaEN.AnswerIP !=  "")
 {
objRow[conge_StuBatchQuesRela.AnswerIP] = objge_StuBatchQuesRelaEN.AnswerIP; //回答IP
 }
 if (objge_StuBatchQuesRelaEN.AnswerModeId !=  "")
 {
objRow[conge_StuBatchQuesRela.AnswerModeId] = objge_StuBatchQuesRelaEN.AnswerModeId; //答案模式Id
 }
 if (objge_StuBatchQuesRelaEN.AnswerMultiOptions !=  "")
 {
objRow[conge_StuBatchQuesRela.AnswerMultiOptions] = objge_StuBatchQuesRelaEN.AnswerMultiOptions; //多选项答案
 }
 if (objge_StuBatchQuesRelaEN.AnswerOptionId !=  "")
 {
objRow[conge_StuBatchQuesRela.AnswerOptionId] = objge_StuBatchQuesRelaEN.AnswerOptionId; //回答选项Id
 }
 if (objge_StuBatchQuesRelaEN.AnswerTime !=  "")
 {
objRow[conge_StuBatchQuesRela.AnswerTime] = objge_StuBatchQuesRelaEN.AnswerTime; //回答时间
 }
 if (objge_StuBatchQuesRelaEN.ApplySendBackDate !=  "")
 {
objRow[conge_StuBatchQuesRela.ApplySendBackDate] = objge_StuBatchQuesRelaEN.ApplySendBackDate; //申请退回日期
 }
 if (objge_StuBatchQuesRelaEN.Comment !=  "")
 {
objRow[conge_StuBatchQuesRela.Comment] = objge_StuBatchQuesRelaEN.Comment; //批注
 }
objRow[conge_StuBatchQuesRela.IsAccessKnowledge] = objge_StuBatchQuesRelaEN.IsAccessKnowledge; //是否处理知识点
objRow[conge_StuBatchQuesRela.IsApplySendBack] = objge_StuBatchQuesRelaEN.IsApplySendBack; //是否申请退回
objRow[conge_StuBatchQuesRela.IsInErrorQuestion] = objge_StuBatchQuesRelaEN.IsInErrorQuestion; //是否进入错题
objRow[conge_StuBatchQuesRela.IsLook] = objge_StuBatchQuesRelaEN.IsLook; //是否查看
objRow[conge_StuBatchQuesRela.IsMarking] = objge_StuBatchQuesRelaEN.IsMarking; //是否批阅
objRow[conge_StuBatchQuesRela.IsNotProcessTimeout] = objge_StuBatchQuesRelaEN.IsNotProcessTimeout; //是否不处理超时
objRow[conge_StuBatchQuesRela.IsHasAnswer] = objge_StuBatchQuesRelaEN.IsHasAnswer; //是否有答案
objRow[conge_StuBatchQuesRela.IsPublish] = objge_StuBatchQuesRelaEN.IsPublish; //是否发布
objRow[conge_StuBatchQuesRela.IsRight] = objge_StuBatchQuesRelaEN.IsRight; //是否正确
objRow[conge_StuBatchQuesRela.IsSave] = objge_StuBatchQuesRelaEN.IsSave; //是否保存
objRow[conge_StuBatchQuesRela.IsSendBack] = objge_StuBatchQuesRelaEN.IsSendBack; //是否退回
objRow[conge_StuBatchQuesRela.IsSubmit] = objge_StuBatchQuesRelaEN.IsSubmit; //是否提交
 if (objge_StuBatchQuesRelaEN.MarkDate !=  "")
 {
objRow[conge_StuBatchQuesRela.MarkDate] = objge_StuBatchQuesRelaEN.MarkDate; //打分日期
 }
 if (objge_StuBatchQuesRelaEN.MarkerId !=  "")
 {
objRow[conge_StuBatchQuesRela.MarkerId] = objge_StuBatchQuesRelaEN.MarkerId; //打分者
 }
 if (objge_StuBatchQuesRelaEN.OperateTime !=  "")
 {
objRow[conge_StuBatchQuesRela.OperateTime] = objge_StuBatchQuesRelaEN.OperateTime; //操作时间
 }
 if (objge_StuBatchQuesRelaEN.RealFinishDate !=  "")
 {
objRow[conge_StuBatchQuesRela.RealFinishDate] = objge_StuBatchQuesRelaEN.RealFinishDate; //实际完成日期
 }
 if (objge_StuBatchQuesRelaEN.WorkTypeId !=  "")
 {
objRow[conge_StuBatchQuesRela.WorkTypeId] = objge_StuBatchQuesRelaEN.WorkTypeId; //作业类型Id
 }
 if (objge_StuBatchQuesRelaEN.SchoolYear !=  "")
 {
objRow[conge_StuBatchQuesRela.SchoolYear] = objge_StuBatchQuesRelaEN.SchoolYear; //学年
 }
 if (objge_StuBatchQuesRelaEN.SchoolTerm !=  "")
 {
objRow[conge_StuBatchQuesRela.SchoolTerm] = objge_StuBatchQuesRelaEN.SchoolTerm; //学期
 }
 if (objge_StuBatchQuesRelaEN.ErrMsg !=  "")
 {
objRow[conge_StuBatchQuesRela.ErrMsg] = objge_StuBatchQuesRelaEN.ErrMsg; //错误信息
 }
objRow[conge_StuBatchQuesRela.IsRecommend] = objge_StuBatchQuesRelaEN.IsRecommend; //是否推荐
 if (objge_StuBatchQuesRelaEN.CourseId !=  "")
 {
objRow[conge_StuBatchQuesRela.CourseId] = objge_StuBatchQuesRelaEN.CourseId; //课程Id
 }
objRow[conge_StuBatchQuesRela.UpdDate] = objge_StuBatchQuesRelaEN.UpdDate; //修改日期
 if (objge_StuBatchQuesRelaEN.UpdUserId !=  "")
 {
objRow[conge_StuBatchQuesRela.UpdUserId] = objge_StuBatchQuesRelaEN.UpdUserId; //修改用户Id
 }
 if (objge_StuBatchQuesRelaEN.Memo !=  "")
 {
objRow[conge_StuBatchQuesRela.Memo] = objge_StuBatchQuesRelaEN.Memo; //备注
 }
objDS.Tables[clsge_StuBatchQuesRelaEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsge_StuBatchQuesRelaEN._CurrTabName);
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
 /// <param name = "objge_StuBatchQuesRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN)
{
 objge_StuBatchQuesRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objge_StuBatchQuesRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objge_StuBatchQuesRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objge_StuBatchQuesRelaEN.ExamBatchNo  ==  "")
 {
 objge_StuBatchQuesRelaEN.ExamBatchNo = null;
 }
 if (objge_StuBatchQuesRelaEN.ExamBatchNo !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.ExamBatchNo);
 var strExamBatchNo = objge_StuBatchQuesRelaEN.ExamBatchNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExamBatchNo + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.LevelNo !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.LevelNo);
 arrValueListForInsert.Add(objge_StuBatchQuesRelaEN.LevelNo.ToString());
 }
 
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.QuestionId);
 arrValueListForInsert.Add(objge_StuBatchQuesRelaEN.QuestionId.ToString());
 
 if (objge_StuBatchQuesRelaEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.UserId);
 var strUserId = objge_StuBatchQuesRelaEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.IdCurrEduCls  ==  "")
 {
 objge_StuBatchQuesRelaEN.IdCurrEduCls = null;
 }
 if (objge_StuBatchQuesRelaEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.IdCurrEduCls);
 var strIdCurrEduCls = objge_StuBatchQuesRelaEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.QuestionIndex4Batch !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.QuestionIndex4Batch);
 arrValueListForInsert.Add(objge_StuBatchQuesRelaEN.QuestionIndex4Batch.ToString());
 }
 
 if (objge_StuBatchQuesRelaEN.GameLevelId !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.GameLevelId);
 var strGameLevelId = objge_StuBatchQuesRelaEN.GameLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGameLevelId + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.Scores !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.Scores);
 arrValueListForInsert.Add(objge_StuBatchQuesRelaEN.Scores.ToString());
 }
 
 if (objge_StuBatchQuesRelaEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.Score);
 arrValueListForInsert.Add(objge_StuBatchQuesRelaEN.Score.ToString());
 }
 
 if (objge_StuBatchQuesRelaEN.StuAnswerText !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.StuAnswerText);
 var strStuAnswerText = objge_StuBatchQuesRelaEN.StuAnswerText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStuAnswerText + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.AnswerDate !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.AnswerDate);
 var strAnswerDate = objge_StuBatchQuesRelaEN.AnswerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerDate + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.AnswerIP !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.AnswerIP);
 var strAnswerIP = objge_StuBatchQuesRelaEN.AnswerIP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerIP + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.AnswerModeId !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.AnswerModeId);
 var strAnswerModeId = objge_StuBatchQuesRelaEN.AnswerModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerModeId + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.AnswerMultiOptions !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.AnswerMultiOptions);
 var strAnswerMultiOptions = objge_StuBatchQuesRelaEN.AnswerMultiOptions.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerMultiOptions + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.AnswerOptionId !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.AnswerOptionId);
 var strAnswerOptionId = objge_StuBatchQuesRelaEN.AnswerOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerOptionId + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.AnswerTime !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.AnswerTime);
 var strAnswerTime = objge_StuBatchQuesRelaEN.AnswerTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerTime + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.ApplySendBackDate !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.ApplySendBackDate);
 var strApplySendBackDate = objge_StuBatchQuesRelaEN.ApplySendBackDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strApplySendBackDate + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.Comment !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.Comment);
 var strComment = objge_StuBatchQuesRelaEN.Comment.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strComment + "'");
 }
 
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.IsAccessKnowledge);
 arrValueListForInsert.Add("'" + (objge_StuBatchQuesRelaEN.IsAccessKnowledge  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.IsApplySendBack);
 arrValueListForInsert.Add("'" + (objge_StuBatchQuesRelaEN.IsApplySendBack  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.IsInErrorQuestion);
 arrValueListForInsert.Add("'" + (objge_StuBatchQuesRelaEN.IsInErrorQuestion  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.IsLook);
 arrValueListForInsert.Add("'" + (objge_StuBatchQuesRelaEN.IsLook  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.IsMarking);
 arrValueListForInsert.Add("'" + (objge_StuBatchQuesRelaEN.IsMarking  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.IsNotProcessTimeout);
 arrValueListForInsert.Add("'" + (objge_StuBatchQuesRelaEN.IsNotProcessTimeout  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.IsHasAnswer);
 arrValueListForInsert.Add("'" + (objge_StuBatchQuesRelaEN.IsHasAnswer  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.IsPublish);
 arrValueListForInsert.Add("'" + (objge_StuBatchQuesRelaEN.IsPublish  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.IsRight);
 arrValueListForInsert.Add("'" + (objge_StuBatchQuesRelaEN.IsRight  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.IsSave);
 arrValueListForInsert.Add("'" + (objge_StuBatchQuesRelaEN.IsSave  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.IsSendBack);
 arrValueListForInsert.Add("'" + (objge_StuBatchQuesRelaEN.IsSendBack  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.IsSubmit);
 arrValueListForInsert.Add("'" + (objge_StuBatchQuesRelaEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objge_StuBatchQuesRelaEN.MarkDate !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.MarkDate);
 var strMarkDate = objge_StuBatchQuesRelaEN.MarkDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMarkDate + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.MarkerId !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.MarkerId);
 var strMarkerId = objge_StuBatchQuesRelaEN.MarkerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMarkerId + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.OperateTime !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.OperateTime);
 var strOperateTime = objge_StuBatchQuesRelaEN.OperateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOperateTime + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.RealFinishDate !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.RealFinishDate);
 var strRealFinishDate = objge_StuBatchQuesRelaEN.RealFinishDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRealFinishDate + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.WorkTypeId !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.WorkTypeId);
 var strWorkTypeId = objge_StuBatchQuesRelaEN.WorkTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWorkTypeId + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.SchoolYear !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.SchoolYear);
 var strSchoolYear = objge_StuBatchQuesRelaEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolYear + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.SchoolTerm !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.SchoolTerm);
 var strSchoolTerm = objge_StuBatchQuesRelaEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolTerm + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.ErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.ErrMsg);
 var strErrMsg = objge_StuBatchQuesRelaEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrMsg + "'");
 }
 
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.IsRecommend);
 arrValueListForInsert.Add("'" + (objge_StuBatchQuesRelaEN.IsRecommend  ==  false ? "0" : "1") + "'");
 
 if (objge_StuBatchQuesRelaEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.CourseId);
 var strCourseId = objge_StuBatchQuesRelaEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.UpdDate);
 var strUpdDate = objge_StuBatchQuesRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.UpdUserId);
 var strUpdUserId = objge_StuBatchQuesRelaEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.Memo);
 var strMemo = objge_StuBatchQuesRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ge_StuBatchQuesRela");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StuBatchQuesRelaDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objge_StuBatchQuesRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN)
{
 objge_StuBatchQuesRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objge_StuBatchQuesRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objge_StuBatchQuesRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objge_StuBatchQuesRelaEN.ExamBatchNo  ==  "")
 {
 objge_StuBatchQuesRelaEN.ExamBatchNo = null;
 }
 if (objge_StuBatchQuesRelaEN.ExamBatchNo !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.ExamBatchNo);
 var strExamBatchNo = objge_StuBatchQuesRelaEN.ExamBatchNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExamBatchNo + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.LevelNo !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.LevelNo);
 arrValueListForInsert.Add(objge_StuBatchQuesRelaEN.LevelNo.ToString());
 }
 
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.QuestionId);
 arrValueListForInsert.Add(objge_StuBatchQuesRelaEN.QuestionId.ToString());
 
 if (objge_StuBatchQuesRelaEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.UserId);
 var strUserId = objge_StuBatchQuesRelaEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.IdCurrEduCls  ==  "")
 {
 objge_StuBatchQuesRelaEN.IdCurrEduCls = null;
 }
 if (objge_StuBatchQuesRelaEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.IdCurrEduCls);
 var strIdCurrEduCls = objge_StuBatchQuesRelaEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.QuestionIndex4Batch !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.QuestionIndex4Batch);
 arrValueListForInsert.Add(objge_StuBatchQuesRelaEN.QuestionIndex4Batch.ToString());
 }
 
 if (objge_StuBatchQuesRelaEN.GameLevelId !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.GameLevelId);
 var strGameLevelId = objge_StuBatchQuesRelaEN.GameLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGameLevelId + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.Scores !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.Scores);
 arrValueListForInsert.Add(objge_StuBatchQuesRelaEN.Scores.ToString());
 }
 
 if (objge_StuBatchQuesRelaEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.Score);
 arrValueListForInsert.Add(objge_StuBatchQuesRelaEN.Score.ToString());
 }
 
 if (objge_StuBatchQuesRelaEN.StuAnswerText !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.StuAnswerText);
 var strStuAnswerText = objge_StuBatchQuesRelaEN.StuAnswerText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStuAnswerText + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.AnswerDate !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.AnswerDate);
 var strAnswerDate = objge_StuBatchQuesRelaEN.AnswerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerDate + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.AnswerIP !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.AnswerIP);
 var strAnswerIP = objge_StuBatchQuesRelaEN.AnswerIP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerIP + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.AnswerModeId !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.AnswerModeId);
 var strAnswerModeId = objge_StuBatchQuesRelaEN.AnswerModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerModeId + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.AnswerMultiOptions !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.AnswerMultiOptions);
 var strAnswerMultiOptions = objge_StuBatchQuesRelaEN.AnswerMultiOptions.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerMultiOptions + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.AnswerOptionId !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.AnswerOptionId);
 var strAnswerOptionId = objge_StuBatchQuesRelaEN.AnswerOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerOptionId + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.AnswerTime !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.AnswerTime);
 var strAnswerTime = objge_StuBatchQuesRelaEN.AnswerTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerTime + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.ApplySendBackDate !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.ApplySendBackDate);
 var strApplySendBackDate = objge_StuBatchQuesRelaEN.ApplySendBackDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strApplySendBackDate + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.Comment !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.Comment);
 var strComment = objge_StuBatchQuesRelaEN.Comment.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strComment + "'");
 }
 
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.IsAccessKnowledge);
 arrValueListForInsert.Add("'" + (objge_StuBatchQuesRelaEN.IsAccessKnowledge  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.IsApplySendBack);
 arrValueListForInsert.Add("'" + (objge_StuBatchQuesRelaEN.IsApplySendBack  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.IsInErrorQuestion);
 arrValueListForInsert.Add("'" + (objge_StuBatchQuesRelaEN.IsInErrorQuestion  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.IsLook);
 arrValueListForInsert.Add("'" + (objge_StuBatchQuesRelaEN.IsLook  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.IsMarking);
 arrValueListForInsert.Add("'" + (objge_StuBatchQuesRelaEN.IsMarking  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.IsNotProcessTimeout);
 arrValueListForInsert.Add("'" + (objge_StuBatchQuesRelaEN.IsNotProcessTimeout  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.IsHasAnswer);
 arrValueListForInsert.Add("'" + (objge_StuBatchQuesRelaEN.IsHasAnswer  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.IsPublish);
 arrValueListForInsert.Add("'" + (objge_StuBatchQuesRelaEN.IsPublish  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.IsRight);
 arrValueListForInsert.Add("'" + (objge_StuBatchQuesRelaEN.IsRight  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.IsSave);
 arrValueListForInsert.Add("'" + (objge_StuBatchQuesRelaEN.IsSave  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.IsSendBack);
 arrValueListForInsert.Add("'" + (objge_StuBatchQuesRelaEN.IsSendBack  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.IsSubmit);
 arrValueListForInsert.Add("'" + (objge_StuBatchQuesRelaEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objge_StuBatchQuesRelaEN.MarkDate !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.MarkDate);
 var strMarkDate = objge_StuBatchQuesRelaEN.MarkDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMarkDate + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.MarkerId !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.MarkerId);
 var strMarkerId = objge_StuBatchQuesRelaEN.MarkerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMarkerId + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.OperateTime !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.OperateTime);
 var strOperateTime = objge_StuBatchQuesRelaEN.OperateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOperateTime + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.RealFinishDate !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.RealFinishDate);
 var strRealFinishDate = objge_StuBatchQuesRelaEN.RealFinishDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRealFinishDate + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.WorkTypeId !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.WorkTypeId);
 var strWorkTypeId = objge_StuBatchQuesRelaEN.WorkTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWorkTypeId + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.SchoolYear !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.SchoolYear);
 var strSchoolYear = objge_StuBatchQuesRelaEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolYear + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.SchoolTerm !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.SchoolTerm);
 var strSchoolTerm = objge_StuBatchQuesRelaEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolTerm + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.ErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.ErrMsg);
 var strErrMsg = objge_StuBatchQuesRelaEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrMsg + "'");
 }
 
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.IsRecommend);
 arrValueListForInsert.Add("'" + (objge_StuBatchQuesRelaEN.IsRecommend  ==  false ? "0" : "1") + "'");
 
 if (objge_StuBatchQuesRelaEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.CourseId);
 var strCourseId = objge_StuBatchQuesRelaEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.UpdDate);
 var strUpdDate = objge_StuBatchQuesRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.UpdUserId);
 var strUpdUserId = objge_StuBatchQuesRelaEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.Memo);
 var strMemo = objge_StuBatchQuesRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ge_StuBatchQuesRela");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StuBatchQuesRelaDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objge_StuBatchQuesRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objge_StuBatchQuesRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objge_StuBatchQuesRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objge_StuBatchQuesRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objge_StuBatchQuesRelaEN.ExamBatchNo  ==  "")
 {
 objge_StuBatchQuesRelaEN.ExamBatchNo = null;
 }
 if (objge_StuBatchQuesRelaEN.ExamBatchNo !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.ExamBatchNo);
 var strExamBatchNo = objge_StuBatchQuesRelaEN.ExamBatchNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExamBatchNo + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.LevelNo !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.LevelNo);
 arrValueListForInsert.Add(objge_StuBatchQuesRelaEN.LevelNo.ToString());
 }
 
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.QuestionId);
 arrValueListForInsert.Add(objge_StuBatchQuesRelaEN.QuestionId.ToString());
 
 if (objge_StuBatchQuesRelaEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.UserId);
 var strUserId = objge_StuBatchQuesRelaEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.IdCurrEduCls  ==  "")
 {
 objge_StuBatchQuesRelaEN.IdCurrEduCls = null;
 }
 if (objge_StuBatchQuesRelaEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.IdCurrEduCls);
 var strIdCurrEduCls = objge_StuBatchQuesRelaEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.QuestionIndex4Batch !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.QuestionIndex4Batch);
 arrValueListForInsert.Add(objge_StuBatchQuesRelaEN.QuestionIndex4Batch.ToString());
 }
 
 if (objge_StuBatchQuesRelaEN.GameLevelId !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.GameLevelId);
 var strGameLevelId = objge_StuBatchQuesRelaEN.GameLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGameLevelId + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.Scores !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.Scores);
 arrValueListForInsert.Add(objge_StuBatchQuesRelaEN.Scores.ToString());
 }
 
 if (objge_StuBatchQuesRelaEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.Score);
 arrValueListForInsert.Add(objge_StuBatchQuesRelaEN.Score.ToString());
 }
 
 if (objge_StuBatchQuesRelaEN.StuAnswerText !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.StuAnswerText);
 var strStuAnswerText = objge_StuBatchQuesRelaEN.StuAnswerText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStuAnswerText + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.AnswerDate !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.AnswerDate);
 var strAnswerDate = objge_StuBatchQuesRelaEN.AnswerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerDate + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.AnswerIP !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.AnswerIP);
 var strAnswerIP = objge_StuBatchQuesRelaEN.AnswerIP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerIP + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.AnswerModeId !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.AnswerModeId);
 var strAnswerModeId = objge_StuBatchQuesRelaEN.AnswerModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerModeId + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.AnswerMultiOptions !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.AnswerMultiOptions);
 var strAnswerMultiOptions = objge_StuBatchQuesRelaEN.AnswerMultiOptions.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerMultiOptions + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.AnswerOptionId !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.AnswerOptionId);
 var strAnswerOptionId = objge_StuBatchQuesRelaEN.AnswerOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerOptionId + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.AnswerTime !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.AnswerTime);
 var strAnswerTime = objge_StuBatchQuesRelaEN.AnswerTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerTime + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.ApplySendBackDate !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.ApplySendBackDate);
 var strApplySendBackDate = objge_StuBatchQuesRelaEN.ApplySendBackDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strApplySendBackDate + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.Comment !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.Comment);
 var strComment = objge_StuBatchQuesRelaEN.Comment.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strComment + "'");
 }
 
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.IsAccessKnowledge);
 arrValueListForInsert.Add("'" + (objge_StuBatchQuesRelaEN.IsAccessKnowledge  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.IsApplySendBack);
 arrValueListForInsert.Add("'" + (objge_StuBatchQuesRelaEN.IsApplySendBack  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.IsInErrorQuestion);
 arrValueListForInsert.Add("'" + (objge_StuBatchQuesRelaEN.IsInErrorQuestion  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.IsLook);
 arrValueListForInsert.Add("'" + (objge_StuBatchQuesRelaEN.IsLook  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.IsMarking);
 arrValueListForInsert.Add("'" + (objge_StuBatchQuesRelaEN.IsMarking  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.IsNotProcessTimeout);
 arrValueListForInsert.Add("'" + (objge_StuBatchQuesRelaEN.IsNotProcessTimeout  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.IsHasAnswer);
 arrValueListForInsert.Add("'" + (objge_StuBatchQuesRelaEN.IsHasAnswer  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.IsPublish);
 arrValueListForInsert.Add("'" + (objge_StuBatchQuesRelaEN.IsPublish  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.IsRight);
 arrValueListForInsert.Add("'" + (objge_StuBatchQuesRelaEN.IsRight  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.IsSave);
 arrValueListForInsert.Add("'" + (objge_StuBatchQuesRelaEN.IsSave  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.IsSendBack);
 arrValueListForInsert.Add("'" + (objge_StuBatchQuesRelaEN.IsSendBack  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.IsSubmit);
 arrValueListForInsert.Add("'" + (objge_StuBatchQuesRelaEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objge_StuBatchQuesRelaEN.MarkDate !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.MarkDate);
 var strMarkDate = objge_StuBatchQuesRelaEN.MarkDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMarkDate + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.MarkerId !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.MarkerId);
 var strMarkerId = objge_StuBatchQuesRelaEN.MarkerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMarkerId + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.OperateTime !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.OperateTime);
 var strOperateTime = objge_StuBatchQuesRelaEN.OperateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOperateTime + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.RealFinishDate !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.RealFinishDate);
 var strRealFinishDate = objge_StuBatchQuesRelaEN.RealFinishDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRealFinishDate + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.WorkTypeId !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.WorkTypeId);
 var strWorkTypeId = objge_StuBatchQuesRelaEN.WorkTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWorkTypeId + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.SchoolYear !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.SchoolYear);
 var strSchoolYear = objge_StuBatchQuesRelaEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolYear + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.SchoolTerm !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.SchoolTerm);
 var strSchoolTerm = objge_StuBatchQuesRelaEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolTerm + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.ErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.ErrMsg);
 var strErrMsg = objge_StuBatchQuesRelaEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrMsg + "'");
 }
 
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.IsRecommend);
 arrValueListForInsert.Add("'" + (objge_StuBatchQuesRelaEN.IsRecommend  ==  false ? "0" : "1") + "'");
 
 if (objge_StuBatchQuesRelaEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.CourseId);
 var strCourseId = objge_StuBatchQuesRelaEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.UpdDate);
 var strUpdDate = objge_StuBatchQuesRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.UpdUserId);
 var strUpdUserId = objge_StuBatchQuesRelaEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.Memo);
 var strMemo = objge_StuBatchQuesRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ge_StuBatchQuesRela");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StuBatchQuesRelaDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objge_StuBatchQuesRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objge_StuBatchQuesRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objge_StuBatchQuesRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objge_StuBatchQuesRelaEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objge_StuBatchQuesRelaEN.ExamBatchNo  ==  "")
 {
 objge_StuBatchQuesRelaEN.ExamBatchNo = null;
 }
 if (objge_StuBatchQuesRelaEN.ExamBatchNo !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.ExamBatchNo);
 var strExamBatchNo = objge_StuBatchQuesRelaEN.ExamBatchNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExamBatchNo + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.LevelNo !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.LevelNo);
 arrValueListForInsert.Add(objge_StuBatchQuesRelaEN.LevelNo.ToString());
 }
 
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.QuestionId);
 arrValueListForInsert.Add(objge_StuBatchQuesRelaEN.QuestionId.ToString());
 
 if (objge_StuBatchQuesRelaEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.UserId);
 var strUserId = objge_StuBatchQuesRelaEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.IdCurrEduCls  ==  "")
 {
 objge_StuBatchQuesRelaEN.IdCurrEduCls = null;
 }
 if (objge_StuBatchQuesRelaEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.IdCurrEduCls);
 var strIdCurrEduCls = objge_StuBatchQuesRelaEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.QuestionIndex4Batch !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.QuestionIndex4Batch);
 arrValueListForInsert.Add(objge_StuBatchQuesRelaEN.QuestionIndex4Batch.ToString());
 }
 
 if (objge_StuBatchQuesRelaEN.GameLevelId !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.GameLevelId);
 var strGameLevelId = objge_StuBatchQuesRelaEN.GameLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGameLevelId + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.Scores !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.Scores);
 arrValueListForInsert.Add(objge_StuBatchQuesRelaEN.Scores.ToString());
 }
 
 if (objge_StuBatchQuesRelaEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.Score);
 arrValueListForInsert.Add(objge_StuBatchQuesRelaEN.Score.ToString());
 }
 
 if (objge_StuBatchQuesRelaEN.StuAnswerText !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.StuAnswerText);
 var strStuAnswerText = objge_StuBatchQuesRelaEN.StuAnswerText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStuAnswerText + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.AnswerDate !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.AnswerDate);
 var strAnswerDate = objge_StuBatchQuesRelaEN.AnswerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerDate + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.AnswerIP !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.AnswerIP);
 var strAnswerIP = objge_StuBatchQuesRelaEN.AnswerIP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerIP + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.AnswerModeId !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.AnswerModeId);
 var strAnswerModeId = objge_StuBatchQuesRelaEN.AnswerModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerModeId + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.AnswerMultiOptions !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.AnswerMultiOptions);
 var strAnswerMultiOptions = objge_StuBatchQuesRelaEN.AnswerMultiOptions.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerMultiOptions + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.AnswerOptionId !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.AnswerOptionId);
 var strAnswerOptionId = objge_StuBatchQuesRelaEN.AnswerOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerOptionId + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.AnswerTime !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.AnswerTime);
 var strAnswerTime = objge_StuBatchQuesRelaEN.AnswerTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerTime + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.ApplySendBackDate !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.ApplySendBackDate);
 var strApplySendBackDate = objge_StuBatchQuesRelaEN.ApplySendBackDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strApplySendBackDate + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.Comment !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.Comment);
 var strComment = objge_StuBatchQuesRelaEN.Comment.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strComment + "'");
 }
 
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.IsAccessKnowledge);
 arrValueListForInsert.Add("'" + (objge_StuBatchQuesRelaEN.IsAccessKnowledge  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.IsApplySendBack);
 arrValueListForInsert.Add("'" + (objge_StuBatchQuesRelaEN.IsApplySendBack  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.IsInErrorQuestion);
 arrValueListForInsert.Add("'" + (objge_StuBatchQuesRelaEN.IsInErrorQuestion  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.IsLook);
 arrValueListForInsert.Add("'" + (objge_StuBatchQuesRelaEN.IsLook  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.IsMarking);
 arrValueListForInsert.Add("'" + (objge_StuBatchQuesRelaEN.IsMarking  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.IsNotProcessTimeout);
 arrValueListForInsert.Add("'" + (objge_StuBatchQuesRelaEN.IsNotProcessTimeout  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.IsHasAnswer);
 arrValueListForInsert.Add("'" + (objge_StuBatchQuesRelaEN.IsHasAnswer  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.IsPublish);
 arrValueListForInsert.Add("'" + (objge_StuBatchQuesRelaEN.IsPublish  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.IsRight);
 arrValueListForInsert.Add("'" + (objge_StuBatchQuesRelaEN.IsRight  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.IsSave);
 arrValueListForInsert.Add("'" + (objge_StuBatchQuesRelaEN.IsSave  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.IsSendBack);
 arrValueListForInsert.Add("'" + (objge_StuBatchQuesRelaEN.IsSendBack  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.IsSubmit);
 arrValueListForInsert.Add("'" + (objge_StuBatchQuesRelaEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objge_StuBatchQuesRelaEN.MarkDate !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.MarkDate);
 var strMarkDate = objge_StuBatchQuesRelaEN.MarkDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMarkDate + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.MarkerId !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.MarkerId);
 var strMarkerId = objge_StuBatchQuesRelaEN.MarkerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMarkerId + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.OperateTime !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.OperateTime);
 var strOperateTime = objge_StuBatchQuesRelaEN.OperateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOperateTime + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.RealFinishDate !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.RealFinishDate);
 var strRealFinishDate = objge_StuBatchQuesRelaEN.RealFinishDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRealFinishDate + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.WorkTypeId !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.WorkTypeId);
 var strWorkTypeId = objge_StuBatchQuesRelaEN.WorkTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWorkTypeId + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.SchoolYear !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.SchoolYear);
 var strSchoolYear = objge_StuBatchQuesRelaEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolYear + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.SchoolTerm !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.SchoolTerm);
 var strSchoolTerm = objge_StuBatchQuesRelaEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolTerm + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.ErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.ErrMsg);
 var strErrMsg = objge_StuBatchQuesRelaEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrMsg + "'");
 }
 
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.IsRecommend);
 arrValueListForInsert.Add("'" + (objge_StuBatchQuesRelaEN.IsRecommend  ==  false ? "0" : "1") + "'");
 
 if (objge_StuBatchQuesRelaEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.CourseId);
 var strCourseId = objge_StuBatchQuesRelaEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.UpdDate);
 var strUpdDate = objge_StuBatchQuesRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.UpdUserId);
 var strUpdUserId = objge_StuBatchQuesRelaEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objge_StuBatchQuesRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conge_StuBatchQuesRela.Memo);
 var strMemo = objge_StuBatchQuesRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ge_StuBatchQuesRela");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StuBatchQuesRelaDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewge_StuBatchQuesRelas(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StuBatchQuesRelaDA.GetSpecSQLObj();
strSQL = "Select * from ge_StuBatchQuesRela where IdStuBatchQuesRela = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ge_StuBatchQuesRela");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngIdStuBatchQuesRela = TransNullToInt(oRow[conge_StuBatchQuesRela.IdStuBatchQuesRela].ToString().Trim());
if (IsExist(lngIdStuBatchQuesRela))
{
 string strResult = "关键字变量值为:" + string.Format("IdStuBatchQuesRela = {0}", lngIdStuBatchQuesRela) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsge_StuBatchQuesRelaEN._CurrTabName ].NewRow();
objRow[conge_StuBatchQuesRela.ExamBatchNo] = oRow[conge_StuBatchQuesRela.ExamBatchNo].ToString().Trim(); //学生批次号
objRow[conge_StuBatchQuesRela.LevelNo] = oRow[conge_StuBatchQuesRela.LevelNo].ToString().Trim(); //学习关号2
objRow[conge_StuBatchQuesRela.QuestionId] = oRow[conge_StuBatchQuesRela.QuestionId].ToString().Trim(); //题目Id
objRow[conge_StuBatchQuesRela.UserId] = oRow[conge_StuBatchQuesRela.UserId].ToString().Trim(); //用户ID
objRow[conge_StuBatchQuesRela.IdCurrEduCls] = oRow[conge_StuBatchQuesRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objRow[conge_StuBatchQuesRela.QuestionIndex4Batch] = oRow[conge_StuBatchQuesRela.QuestionIndex4Batch].ToString().Trim(); //题序号4批次
objRow[conge_StuBatchQuesRela.GameLevelId] = oRow[conge_StuBatchQuesRela.GameLevelId].ToString().Trim(); //游戏关卡Id
objRow[conge_StuBatchQuesRela.Scores] = oRow[conge_StuBatchQuesRela.Scores].ToString().Trim(); //分值
objRow[conge_StuBatchQuesRela.Score] = oRow[conge_StuBatchQuesRela.Score].ToString().Trim(); //得分
objRow[conge_StuBatchQuesRela.StuAnswerText] = oRow[conge_StuBatchQuesRela.StuAnswerText].ToString().Trim(); //学生回答文本
objRow[conge_StuBatchQuesRela.AnswerDate] = oRow[conge_StuBatchQuesRela.AnswerDate].ToString().Trim(); //回答日期
objRow[conge_StuBatchQuesRela.AnswerIP] = oRow[conge_StuBatchQuesRela.AnswerIP].ToString().Trim(); //回答IP
objRow[conge_StuBatchQuesRela.AnswerModeId] = oRow[conge_StuBatchQuesRela.AnswerModeId].ToString().Trim(); //答案模式Id
objRow[conge_StuBatchQuesRela.AnswerMultiOptions] = oRow[conge_StuBatchQuesRela.AnswerMultiOptions].ToString().Trim(); //多选项答案
objRow[conge_StuBatchQuesRela.AnswerOptionId] = oRow[conge_StuBatchQuesRela.AnswerOptionId].ToString().Trim(); //回答选项Id
objRow[conge_StuBatchQuesRela.AnswerTime] = oRow[conge_StuBatchQuesRela.AnswerTime].ToString().Trim(); //回答时间
objRow[conge_StuBatchQuesRela.ApplySendBackDate] = oRow[conge_StuBatchQuesRela.ApplySendBackDate].ToString().Trim(); //申请退回日期
objRow[conge_StuBatchQuesRela.Comment] = oRow[conge_StuBatchQuesRela.Comment].ToString().Trim(); //批注
objRow[conge_StuBatchQuesRela.IsAccessKnowledge] = oRow[conge_StuBatchQuesRela.IsAccessKnowledge].ToString().Trim(); //是否处理知识点
objRow[conge_StuBatchQuesRela.IsApplySendBack] = oRow[conge_StuBatchQuesRela.IsApplySendBack].ToString().Trim(); //是否申请退回
objRow[conge_StuBatchQuesRela.IsInErrorQuestion] = oRow[conge_StuBatchQuesRela.IsInErrorQuestion].ToString().Trim(); //是否进入错题
objRow[conge_StuBatchQuesRela.IsLook] = oRow[conge_StuBatchQuesRela.IsLook].ToString().Trim(); //是否查看
objRow[conge_StuBatchQuesRela.IsMarking] = oRow[conge_StuBatchQuesRela.IsMarking].ToString().Trim(); //是否批阅
objRow[conge_StuBatchQuesRela.IsNotProcessTimeout] = oRow[conge_StuBatchQuesRela.IsNotProcessTimeout].ToString().Trim(); //是否不处理超时
objRow[conge_StuBatchQuesRela.IsHasAnswer] = oRow[conge_StuBatchQuesRela.IsHasAnswer].ToString().Trim(); //是否有答案
objRow[conge_StuBatchQuesRela.IsPublish] = oRow[conge_StuBatchQuesRela.IsPublish].ToString().Trim(); //是否发布
objRow[conge_StuBatchQuesRela.IsRight] = oRow[conge_StuBatchQuesRela.IsRight].ToString().Trim(); //是否正确
objRow[conge_StuBatchQuesRela.IsSave] = oRow[conge_StuBatchQuesRela.IsSave].ToString().Trim(); //是否保存
objRow[conge_StuBatchQuesRela.IsSendBack] = oRow[conge_StuBatchQuesRela.IsSendBack].ToString().Trim(); //是否退回
objRow[conge_StuBatchQuesRela.IsSubmit] = oRow[conge_StuBatchQuesRela.IsSubmit].ToString().Trim(); //是否提交
objRow[conge_StuBatchQuesRela.MarkDate] = oRow[conge_StuBatchQuesRela.MarkDate].ToString().Trim(); //打分日期
objRow[conge_StuBatchQuesRela.MarkerId] = oRow[conge_StuBatchQuesRela.MarkerId].ToString().Trim(); //打分者
objRow[conge_StuBatchQuesRela.OperateTime] = oRow[conge_StuBatchQuesRela.OperateTime].ToString().Trim(); //操作时间
objRow[conge_StuBatchQuesRela.RealFinishDate] = oRow[conge_StuBatchQuesRela.RealFinishDate].ToString().Trim(); //实际完成日期
objRow[conge_StuBatchQuesRela.WorkTypeId] = oRow[conge_StuBatchQuesRela.WorkTypeId].ToString().Trim(); //作业类型Id
objRow[conge_StuBatchQuesRela.SchoolYear] = oRow[conge_StuBatchQuesRela.SchoolYear].ToString().Trim(); //学年
objRow[conge_StuBatchQuesRela.SchoolTerm] = oRow[conge_StuBatchQuesRela.SchoolTerm].ToString().Trim(); //学期
objRow[conge_StuBatchQuesRela.ErrMsg] = oRow[conge_StuBatchQuesRela.ErrMsg].ToString().Trim(); //错误信息
objRow[conge_StuBatchQuesRela.IsRecommend] = oRow[conge_StuBatchQuesRela.IsRecommend].ToString().Trim(); //是否推荐
objRow[conge_StuBatchQuesRela.CourseId] = oRow[conge_StuBatchQuesRela.CourseId].ToString().Trim(); //课程Id
objRow[conge_StuBatchQuesRela.UpdDate] = oRow[conge_StuBatchQuesRela.UpdDate].ToString().Trim(); //修改日期
objRow[conge_StuBatchQuesRela.UpdUserId] = oRow[conge_StuBatchQuesRela.UpdUserId].ToString().Trim(); //修改用户Id
objRow[conge_StuBatchQuesRela.Memo] = oRow[conge_StuBatchQuesRela.Memo].ToString().Trim(); //备注
 objDS.Tables[clsge_StuBatchQuesRelaEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsge_StuBatchQuesRelaEN._CurrTabName);
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
 /// <param name = "objge_StuBatchQuesRelaEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN)
{
 objge_StuBatchQuesRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objge_StuBatchQuesRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objge_StuBatchQuesRelaEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StuBatchQuesRelaDA.GetSpecSQLObj();
strSQL = "Select * from ge_StuBatchQuesRela where IdStuBatchQuesRela = " + ""+ objge_StuBatchQuesRelaEN.IdStuBatchQuesRela+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsge_StuBatchQuesRelaEN._CurrTabName);
if (objDS.Tables[clsge_StuBatchQuesRelaEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:IdStuBatchQuesRela = " + ""+ objge_StuBatchQuesRelaEN.IdStuBatchQuesRela+"");
return false;
}
objRow = objDS.Tables[clsge_StuBatchQuesRelaEN._CurrTabName].Rows[0];
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.ExamBatchNo))
 {
objRow[conge_StuBatchQuesRela.ExamBatchNo] = objge_StuBatchQuesRelaEN.ExamBatchNo; //学生批次号
 }
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.LevelNo))
 {
objRow[conge_StuBatchQuesRela.LevelNo] = objge_StuBatchQuesRelaEN.LevelNo; //学习关号2
 }
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.QuestionId))
 {
objRow[conge_StuBatchQuesRela.QuestionId] = objge_StuBatchQuesRelaEN.QuestionId; //题目Id
 }
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.UserId))
 {
objRow[conge_StuBatchQuesRela.UserId] = objge_StuBatchQuesRelaEN.UserId; //用户ID
 }
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.IdCurrEduCls))
 {
objRow[conge_StuBatchQuesRela.IdCurrEduCls] = objge_StuBatchQuesRelaEN.IdCurrEduCls; //教学班流水号
 }
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.QuestionIndex4Batch))
 {
objRow[conge_StuBatchQuesRela.QuestionIndex4Batch] = objge_StuBatchQuesRelaEN.QuestionIndex4Batch; //题序号4批次
 }
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.GameLevelId))
 {
objRow[conge_StuBatchQuesRela.GameLevelId] = objge_StuBatchQuesRelaEN.GameLevelId; //游戏关卡Id
 }
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.Scores))
 {
objRow[conge_StuBatchQuesRela.Scores] = objge_StuBatchQuesRelaEN.Scores; //分值
 }
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.Score))
 {
objRow[conge_StuBatchQuesRela.Score] = objge_StuBatchQuesRelaEN.Score; //得分
 }
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.StuAnswerText))
 {
objRow[conge_StuBatchQuesRela.StuAnswerText] = objge_StuBatchQuesRelaEN.StuAnswerText; //学生回答文本
 }
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.AnswerDate))
 {
objRow[conge_StuBatchQuesRela.AnswerDate] = objge_StuBatchQuesRelaEN.AnswerDate; //回答日期
 }
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.AnswerIP))
 {
objRow[conge_StuBatchQuesRela.AnswerIP] = objge_StuBatchQuesRelaEN.AnswerIP; //回答IP
 }
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.AnswerModeId))
 {
objRow[conge_StuBatchQuesRela.AnswerModeId] = objge_StuBatchQuesRelaEN.AnswerModeId; //答案模式Id
 }
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.AnswerMultiOptions))
 {
objRow[conge_StuBatchQuesRela.AnswerMultiOptions] = objge_StuBatchQuesRelaEN.AnswerMultiOptions; //多选项答案
 }
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.AnswerOptionId))
 {
objRow[conge_StuBatchQuesRela.AnswerOptionId] = objge_StuBatchQuesRelaEN.AnswerOptionId; //回答选项Id
 }
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.AnswerTime))
 {
objRow[conge_StuBatchQuesRela.AnswerTime] = objge_StuBatchQuesRelaEN.AnswerTime; //回答时间
 }
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.ApplySendBackDate))
 {
objRow[conge_StuBatchQuesRela.ApplySendBackDate] = objge_StuBatchQuesRelaEN.ApplySendBackDate; //申请退回日期
 }
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.Comment))
 {
objRow[conge_StuBatchQuesRela.Comment] = objge_StuBatchQuesRelaEN.Comment; //批注
 }
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.IsAccessKnowledge))
 {
objRow[conge_StuBatchQuesRela.IsAccessKnowledge] = objge_StuBatchQuesRelaEN.IsAccessKnowledge; //是否处理知识点
 }
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.IsApplySendBack))
 {
objRow[conge_StuBatchQuesRela.IsApplySendBack] = objge_StuBatchQuesRelaEN.IsApplySendBack; //是否申请退回
 }
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.IsInErrorQuestion))
 {
objRow[conge_StuBatchQuesRela.IsInErrorQuestion] = objge_StuBatchQuesRelaEN.IsInErrorQuestion; //是否进入错题
 }
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.IsLook))
 {
objRow[conge_StuBatchQuesRela.IsLook] = objge_StuBatchQuesRelaEN.IsLook; //是否查看
 }
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.IsMarking))
 {
objRow[conge_StuBatchQuesRela.IsMarking] = objge_StuBatchQuesRelaEN.IsMarking; //是否批阅
 }
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.IsNotProcessTimeout))
 {
objRow[conge_StuBatchQuesRela.IsNotProcessTimeout] = objge_StuBatchQuesRelaEN.IsNotProcessTimeout; //是否不处理超时
 }
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.IsHasAnswer))
 {
objRow[conge_StuBatchQuesRela.IsHasAnswer] = objge_StuBatchQuesRelaEN.IsHasAnswer; //是否有答案
 }
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.IsPublish))
 {
objRow[conge_StuBatchQuesRela.IsPublish] = objge_StuBatchQuesRelaEN.IsPublish; //是否发布
 }
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.IsRight))
 {
objRow[conge_StuBatchQuesRela.IsRight] = objge_StuBatchQuesRelaEN.IsRight; //是否正确
 }
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.IsSave))
 {
objRow[conge_StuBatchQuesRela.IsSave] = objge_StuBatchQuesRelaEN.IsSave; //是否保存
 }
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.IsSendBack))
 {
objRow[conge_StuBatchQuesRela.IsSendBack] = objge_StuBatchQuesRelaEN.IsSendBack; //是否退回
 }
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.IsSubmit))
 {
objRow[conge_StuBatchQuesRela.IsSubmit] = objge_StuBatchQuesRelaEN.IsSubmit; //是否提交
 }
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.MarkDate))
 {
objRow[conge_StuBatchQuesRela.MarkDate] = objge_StuBatchQuesRelaEN.MarkDate; //打分日期
 }
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.MarkerId))
 {
objRow[conge_StuBatchQuesRela.MarkerId] = objge_StuBatchQuesRelaEN.MarkerId; //打分者
 }
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.OperateTime))
 {
objRow[conge_StuBatchQuesRela.OperateTime] = objge_StuBatchQuesRelaEN.OperateTime; //操作时间
 }
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.RealFinishDate))
 {
objRow[conge_StuBatchQuesRela.RealFinishDate] = objge_StuBatchQuesRelaEN.RealFinishDate; //实际完成日期
 }
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.WorkTypeId))
 {
objRow[conge_StuBatchQuesRela.WorkTypeId] = objge_StuBatchQuesRelaEN.WorkTypeId; //作业类型Id
 }
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.SchoolYear))
 {
objRow[conge_StuBatchQuesRela.SchoolYear] = objge_StuBatchQuesRelaEN.SchoolYear; //学年
 }
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.SchoolTerm))
 {
objRow[conge_StuBatchQuesRela.SchoolTerm] = objge_StuBatchQuesRelaEN.SchoolTerm; //学期
 }
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.ErrMsg))
 {
objRow[conge_StuBatchQuesRela.ErrMsg] = objge_StuBatchQuesRelaEN.ErrMsg; //错误信息
 }
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.IsRecommend))
 {
objRow[conge_StuBatchQuesRela.IsRecommend] = objge_StuBatchQuesRelaEN.IsRecommend; //是否推荐
 }
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.CourseId))
 {
objRow[conge_StuBatchQuesRela.CourseId] = objge_StuBatchQuesRelaEN.CourseId; //课程Id
 }
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.UpdDate))
 {
objRow[conge_StuBatchQuesRela.UpdDate] = objge_StuBatchQuesRelaEN.UpdDate; //修改日期
 }
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.UpdUserId))
 {
objRow[conge_StuBatchQuesRela.UpdUserId] = objge_StuBatchQuesRelaEN.UpdUserId; //修改用户Id
 }
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.Memo))
 {
objRow[conge_StuBatchQuesRela.Memo] = objge_StuBatchQuesRelaEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsge_StuBatchQuesRelaEN._CurrTabName);
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
 /// <param name = "objge_StuBatchQuesRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN)
{
 objge_StuBatchQuesRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objge_StuBatchQuesRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objge_StuBatchQuesRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StuBatchQuesRelaDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update ge_StuBatchQuesRela Set ");
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.ExamBatchNo))
 {
 if (objge_StuBatchQuesRelaEN.ExamBatchNo  ==  "")
 {
 objge_StuBatchQuesRelaEN.ExamBatchNo = null;
 }
 if (objge_StuBatchQuesRelaEN.ExamBatchNo !=  null)
 {
 var strExamBatchNo = objge_StuBatchQuesRelaEN.ExamBatchNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExamBatchNo, conge_StuBatchQuesRela.ExamBatchNo); //学生批次号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuBatchQuesRela.ExamBatchNo); //学生批次号
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.LevelNo))
 {
 if (objge_StuBatchQuesRelaEN.LevelNo !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_StuBatchQuesRelaEN.LevelNo, conge_StuBatchQuesRela.LevelNo); //学习关号2
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuBatchQuesRela.LevelNo); //学习关号2
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.QuestionId))
 {
 sbSQL.AppendFormat("{1} = {0},",objge_StuBatchQuesRelaEN.QuestionId, conge_StuBatchQuesRela.QuestionId); //题目Id
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.UserId))
 {
 if (objge_StuBatchQuesRelaEN.UserId !=  null)
 {
 var strUserId = objge_StuBatchQuesRelaEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conge_StuBatchQuesRela.UserId); //用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuBatchQuesRela.UserId); //用户ID
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.IdCurrEduCls))
 {
 if (objge_StuBatchQuesRelaEN.IdCurrEduCls  ==  "")
 {
 objge_StuBatchQuesRelaEN.IdCurrEduCls = null;
 }
 if (objge_StuBatchQuesRelaEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objge_StuBatchQuesRelaEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conge_StuBatchQuesRela.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuBatchQuesRela.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.QuestionIndex4Batch))
 {
 if (objge_StuBatchQuesRelaEN.QuestionIndex4Batch !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_StuBatchQuesRelaEN.QuestionIndex4Batch, conge_StuBatchQuesRela.QuestionIndex4Batch); //题序号4批次
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuBatchQuesRela.QuestionIndex4Batch); //题序号4批次
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.GameLevelId))
 {
 if (objge_StuBatchQuesRelaEN.GameLevelId !=  null)
 {
 var strGameLevelId = objge_StuBatchQuesRelaEN.GameLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGameLevelId, conge_StuBatchQuesRela.GameLevelId); //游戏关卡Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuBatchQuesRela.GameLevelId); //游戏关卡Id
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.Scores))
 {
 if (objge_StuBatchQuesRelaEN.Scores !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_StuBatchQuesRelaEN.Scores, conge_StuBatchQuesRela.Scores); //分值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuBatchQuesRela.Scores); //分值
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.Score))
 {
 if (objge_StuBatchQuesRelaEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_StuBatchQuesRelaEN.Score, conge_StuBatchQuesRela.Score); //得分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuBatchQuesRela.Score); //得分
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.StuAnswerText))
 {
 if (objge_StuBatchQuesRelaEN.StuAnswerText !=  null)
 {
 var strStuAnswerText = objge_StuBatchQuesRelaEN.StuAnswerText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStuAnswerText, conge_StuBatchQuesRela.StuAnswerText); //学生回答文本
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuBatchQuesRela.StuAnswerText); //学生回答文本
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.AnswerDate))
 {
 if (objge_StuBatchQuesRelaEN.AnswerDate !=  null)
 {
 var strAnswerDate = objge_StuBatchQuesRelaEN.AnswerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerDate, conge_StuBatchQuesRela.AnswerDate); //回答日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuBatchQuesRela.AnswerDate); //回答日期
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.AnswerIP))
 {
 if (objge_StuBatchQuesRelaEN.AnswerIP !=  null)
 {
 var strAnswerIP = objge_StuBatchQuesRelaEN.AnswerIP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerIP, conge_StuBatchQuesRela.AnswerIP); //回答IP
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuBatchQuesRela.AnswerIP); //回答IP
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.AnswerModeId))
 {
 if (objge_StuBatchQuesRelaEN.AnswerModeId !=  null)
 {
 var strAnswerModeId = objge_StuBatchQuesRelaEN.AnswerModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerModeId, conge_StuBatchQuesRela.AnswerModeId); //答案模式Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuBatchQuesRela.AnswerModeId); //答案模式Id
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.AnswerMultiOptions))
 {
 if (objge_StuBatchQuesRelaEN.AnswerMultiOptions !=  null)
 {
 var strAnswerMultiOptions = objge_StuBatchQuesRelaEN.AnswerMultiOptions.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerMultiOptions, conge_StuBatchQuesRela.AnswerMultiOptions); //多选项答案
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuBatchQuesRela.AnswerMultiOptions); //多选项答案
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.AnswerOptionId))
 {
 if (objge_StuBatchQuesRelaEN.AnswerOptionId !=  null)
 {
 var strAnswerOptionId = objge_StuBatchQuesRelaEN.AnswerOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerOptionId, conge_StuBatchQuesRela.AnswerOptionId); //回答选项Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuBatchQuesRela.AnswerOptionId); //回答选项Id
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.AnswerTime))
 {
 if (objge_StuBatchQuesRelaEN.AnswerTime !=  null)
 {
 var strAnswerTime = objge_StuBatchQuesRelaEN.AnswerTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerTime, conge_StuBatchQuesRela.AnswerTime); //回答时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuBatchQuesRela.AnswerTime); //回答时间
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.ApplySendBackDate))
 {
 if (objge_StuBatchQuesRelaEN.ApplySendBackDate !=  null)
 {
 var strApplySendBackDate = objge_StuBatchQuesRelaEN.ApplySendBackDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strApplySendBackDate, conge_StuBatchQuesRela.ApplySendBackDate); //申请退回日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuBatchQuesRela.ApplySendBackDate); //申请退回日期
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.Comment))
 {
 if (objge_StuBatchQuesRelaEN.Comment !=  null)
 {
 var strComment = objge_StuBatchQuesRelaEN.Comment.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strComment, conge_StuBatchQuesRela.Comment); //批注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuBatchQuesRela.Comment); //批注
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.IsAccessKnowledge))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objge_StuBatchQuesRelaEN.IsAccessKnowledge == true?"1":"0", conge_StuBatchQuesRela.IsAccessKnowledge); //是否处理知识点
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.IsApplySendBack))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objge_StuBatchQuesRelaEN.IsApplySendBack == true?"1":"0", conge_StuBatchQuesRela.IsApplySendBack); //是否申请退回
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.IsInErrorQuestion))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objge_StuBatchQuesRelaEN.IsInErrorQuestion == true?"1":"0", conge_StuBatchQuesRela.IsInErrorQuestion); //是否进入错题
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.IsLook))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objge_StuBatchQuesRelaEN.IsLook == true?"1":"0", conge_StuBatchQuesRela.IsLook); //是否查看
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.IsMarking))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objge_StuBatchQuesRelaEN.IsMarking == true?"1":"0", conge_StuBatchQuesRela.IsMarking); //是否批阅
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.IsNotProcessTimeout))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objge_StuBatchQuesRelaEN.IsNotProcessTimeout == true?"1":"0", conge_StuBatchQuesRela.IsNotProcessTimeout); //是否不处理超时
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.IsHasAnswer))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objge_StuBatchQuesRelaEN.IsHasAnswer == true?"1":"0", conge_StuBatchQuesRela.IsHasAnswer); //是否有答案
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.IsPublish))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objge_StuBatchQuesRelaEN.IsPublish == true?"1":"0", conge_StuBatchQuesRela.IsPublish); //是否发布
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.IsRight))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objge_StuBatchQuesRelaEN.IsRight == true?"1":"0", conge_StuBatchQuesRela.IsRight); //是否正确
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.IsSave))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objge_StuBatchQuesRelaEN.IsSave == true?"1":"0", conge_StuBatchQuesRela.IsSave); //是否保存
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.IsSendBack))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objge_StuBatchQuesRelaEN.IsSendBack == true?"1":"0", conge_StuBatchQuesRela.IsSendBack); //是否退回
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objge_StuBatchQuesRelaEN.IsSubmit == true?"1":"0", conge_StuBatchQuesRela.IsSubmit); //是否提交
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.MarkDate))
 {
 if (objge_StuBatchQuesRelaEN.MarkDate !=  null)
 {
 var strMarkDate = objge_StuBatchQuesRelaEN.MarkDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMarkDate, conge_StuBatchQuesRela.MarkDate); //打分日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuBatchQuesRela.MarkDate); //打分日期
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.MarkerId))
 {
 if (objge_StuBatchQuesRelaEN.MarkerId !=  null)
 {
 var strMarkerId = objge_StuBatchQuesRelaEN.MarkerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMarkerId, conge_StuBatchQuesRela.MarkerId); //打分者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuBatchQuesRela.MarkerId); //打分者
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.OperateTime))
 {
 if (objge_StuBatchQuesRelaEN.OperateTime !=  null)
 {
 var strOperateTime = objge_StuBatchQuesRelaEN.OperateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOperateTime, conge_StuBatchQuesRela.OperateTime); //操作时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuBatchQuesRela.OperateTime); //操作时间
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.RealFinishDate))
 {
 if (objge_StuBatchQuesRelaEN.RealFinishDate !=  null)
 {
 var strRealFinishDate = objge_StuBatchQuesRelaEN.RealFinishDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRealFinishDate, conge_StuBatchQuesRela.RealFinishDate); //实际完成日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuBatchQuesRela.RealFinishDate); //实际完成日期
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.WorkTypeId))
 {
 if (objge_StuBatchQuesRelaEN.WorkTypeId !=  null)
 {
 var strWorkTypeId = objge_StuBatchQuesRelaEN.WorkTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWorkTypeId, conge_StuBatchQuesRela.WorkTypeId); //作业类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuBatchQuesRela.WorkTypeId); //作业类型Id
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.SchoolYear))
 {
 if (objge_StuBatchQuesRelaEN.SchoolYear !=  null)
 {
 var strSchoolYear = objge_StuBatchQuesRelaEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchoolYear, conge_StuBatchQuesRela.SchoolYear); //学年
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuBatchQuesRela.SchoolYear); //学年
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.SchoolTerm))
 {
 if (objge_StuBatchQuesRelaEN.SchoolTerm !=  null)
 {
 var strSchoolTerm = objge_StuBatchQuesRelaEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchoolTerm, conge_StuBatchQuesRela.SchoolTerm); //学期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuBatchQuesRela.SchoolTerm); //学期
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.ErrMsg))
 {
 if (objge_StuBatchQuesRelaEN.ErrMsg !=  null)
 {
 var strErrMsg = objge_StuBatchQuesRelaEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strErrMsg, conge_StuBatchQuesRela.ErrMsg); //错误信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuBatchQuesRela.ErrMsg); //错误信息
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.IsRecommend))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objge_StuBatchQuesRelaEN.IsRecommend == true?"1":"0", conge_StuBatchQuesRela.IsRecommend); //是否推荐
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.CourseId))
 {
 if (objge_StuBatchQuesRelaEN.CourseId !=  null)
 {
 var strCourseId = objge_StuBatchQuesRelaEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, conge_StuBatchQuesRela.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuBatchQuesRela.CourseId); //课程Id
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.UpdDate))
 {
 if (objge_StuBatchQuesRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objge_StuBatchQuesRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conge_StuBatchQuesRela.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuBatchQuesRela.UpdDate); //修改日期
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.UpdUserId))
 {
 if (objge_StuBatchQuesRelaEN.UpdUserId !=  null)
 {
 var strUpdUserId = objge_StuBatchQuesRelaEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conge_StuBatchQuesRela.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuBatchQuesRela.UpdUserId); //修改用户Id
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.Memo))
 {
 if (objge_StuBatchQuesRelaEN.Memo !=  null)
 {
 var strMemo = objge_StuBatchQuesRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conge_StuBatchQuesRela.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuBatchQuesRela.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdStuBatchQuesRela = {0}", objge_StuBatchQuesRelaEN.IdStuBatchQuesRela); 
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
 /// <param name = "objge_StuBatchQuesRelaEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN, string strCondition)
{
 objge_StuBatchQuesRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objge_StuBatchQuesRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objge_StuBatchQuesRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StuBatchQuesRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ge_StuBatchQuesRela Set ");
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.ExamBatchNo))
 {
 if (objge_StuBatchQuesRelaEN.ExamBatchNo  ==  "")
 {
 objge_StuBatchQuesRelaEN.ExamBatchNo = null;
 }
 if (objge_StuBatchQuesRelaEN.ExamBatchNo !=  null)
 {
 var strExamBatchNo = objge_StuBatchQuesRelaEN.ExamBatchNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ExamBatchNo = '{0}',", strExamBatchNo); //学生批次号
 }
 else
 {
 sbSQL.Append(" ExamBatchNo = null,"); //学生批次号
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.LevelNo))
 {
 if (objge_StuBatchQuesRelaEN.LevelNo !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_StuBatchQuesRelaEN.LevelNo, conge_StuBatchQuesRela.LevelNo); //学习关号2
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuBatchQuesRela.LevelNo); //学习关号2
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.QuestionId))
 {
 sbSQL.AppendFormat(" QuestionId = {0},", objge_StuBatchQuesRelaEN.QuestionId); //题目Id
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.UserId))
 {
 if (objge_StuBatchQuesRelaEN.UserId !=  null)
 {
 var strUserId = objge_StuBatchQuesRelaEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户ID
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户ID
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.IdCurrEduCls))
 {
 if (objge_StuBatchQuesRelaEN.IdCurrEduCls  ==  "")
 {
 objge_StuBatchQuesRelaEN.IdCurrEduCls = null;
 }
 if (objge_StuBatchQuesRelaEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objge_StuBatchQuesRelaEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.QuestionIndex4Batch))
 {
 if (objge_StuBatchQuesRelaEN.QuestionIndex4Batch !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_StuBatchQuesRelaEN.QuestionIndex4Batch, conge_StuBatchQuesRela.QuestionIndex4Batch); //题序号4批次
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuBatchQuesRela.QuestionIndex4Batch); //题序号4批次
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.GameLevelId))
 {
 if (objge_StuBatchQuesRelaEN.GameLevelId !=  null)
 {
 var strGameLevelId = objge_StuBatchQuesRelaEN.GameLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GameLevelId = '{0}',", strGameLevelId); //游戏关卡Id
 }
 else
 {
 sbSQL.Append(" GameLevelId = null,"); //游戏关卡Id
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.Scores))
 {
 if (objge_StuBatchQuesRelaEN.Scores !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_StuBatchQuesRelaEN.Scores, conge_StuBatchQuesRela.Scores); //分值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuBatchQuesRela.Scores); //分值
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.Score))
 {
 if (objge_StuBatchQuesRelaEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_StuBatchQuesRelaEN.Score, conge_StuBatchQuesRela.Score); //得分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuBatchQuesRela.Score); //得分
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.StuAnswerText))
 {
 if (objge_StuBatchQuesRelaEN.StuAnswerText !=  null)
 {
 var strStuAnswerText = objge_StuBatchQuesRelaEN.StuAnswerText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StuAnswerText = '{0}',", strStuAnswerText); //学生回答文本
 }
 else
 {
 sbSQL.Append(" StuAnswerText = null,"); //学生回答文本
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.AnswerDate))
 {
 if (objge_StuBatchQuesRelaEN.AnswerDate !=  null)
 {
 var strAnswerDate = objge_StuBatchQuesRelaEN.AnswerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerDate = '{0}',", strAnswerDate); //回答日期
 }
 else
 {
 sbSQL.Append(" AnswerDate = null,"); //回答日期
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.AnswerIP))
 {
 if (objge_StuBatchQuesRelaEN.AnswerIP !=  null)
 {
 var strAnswerIP = objge_StuBatchQuesRelaEN.AnswerIP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerIP = '{0}',", strAnswerIP); //回答IP
 }
 else
 {
 sbSQL.Append(" AnswerIP = null,"); //回答IP
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.AnswerModeId))
 {
 if (objge_StuBatchQuesRelaEN.AnswerModeId !=  null)
 {
 var strAnswerModeId = objge_StuBatchQuesRelaEN.AnswerModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerModeId = '{0}',", strAnswerModeId); //答案模式Id
 }
 else
 {
 sbSQL.Append(" AnswerModeId = null,"); //答案模式Id
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.AnswerMultiOptions))
 {
 if (objge_StuBatchQuesRelaEN.AnswerMultiOptions !=  null)
 {
 var strAnswerMultiOptions = objge_StuBatchQuesRelaEN.AnswerMultiOptions.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerMultiOptions = '{0}',", strAnswerMultiOptions); //多选项答案
 }
 else
 {
 sbSQL.Append(" AnswerMultiOptions = null,"); //多选项答案
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.AnswerOptionId))
 {
 if (objge_StuBatchQuesRelaEN.AnswerOptionId !=  null)
 {
 var strAnswerOptionId = objge_StuBatchQuesRelaEN.AnswerOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerOptionId = '{0}',", strAnswerOptionId); //回答选项Id
 }
 else
 {
 sbSQL.Append(" AnswerOptionId = null,"); //回答选项Id
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.AnswerTime))
 {
 if (objge_StuBatchQuesRelaEN.AnswerTime !=  null)
 {
 var strAnswerTime = objge_StuBatchQuesRelaEN.AnswerTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerTime = '{0}',", strAnswerTime); //回答时间
 }
 else
 {
 sbSQL.Append(" AnswerTime = null,"); //回答时间
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.ApplySendBackDate))
 {
 if (objge_StuBatchQuesRelaEN.ApplySendBackDate !=  null)
 {
 var strApplySendBackDate = objge_StuBatchQuesRelaEN.ApplySendBackDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ApplySendBackDate = '{0}',", strApplySendBackDate); //申请退回日期
 }
 else
 {
 sbSQL.Append(" ApplySendBackDate = null,"); //申请退回日期
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.Comment))
 {
 if (objge_StuBatchQuesRelaEN.Comment !=  null)
 {
 var strComment = objge_StuBatchQuesRelaEN.Comment.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Comment = '{0}',", strComment); //批注
 }
 else
 {
 sbSQL.Append(" Comment = null,"); //批注
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.IsAccessKnowledge))
 {
 sbSQL.AppendFormat(" IsAccessKnowledge = '{0}',", objge_StuBatchQuesRelaEN.IsAccessKnowledge == true?"1":"0"); //是否处理知识点
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.IsApplySendBack))
 {
 sbSQL.AppendFormat(" IsApplySendBack = '{0}',", objge_StuBatchQuesRelaEN.IsApplySendBack == true?"1":"0"); //是否申请退回
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.IsInErrorQuestion))
 {
 sbSQL.AppendFormat(" IsInErrorQuestion = '{0}',", objge_StuBatchQuesRelaEN.IsInErrorQuestion == true?"1":"0"); //是否进入错题
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.IsLook))
 {
 sbSQL.AppendFormat(" IsLook = '{0}',", objge_StuBatchQuesRelaEN.IsLook == true?"1":"0"); //是否查看
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.IsMarking))
 {
 sbSQL.AppendFormat(" IsMarking = '{0}',", objge_StuBatchQuesRelaEN.IsMarking == true?"1":"0"); //是否批阅
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.IsNotProcessTimeout))
 {
 sbSQL.AppendFormat(" IsNotProcessTimeout = '{0}',", objge_StuBatchQuesRelaEN.IsNotProcessTimeout == true?"1":"0"); //是否不处理超时
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.IsHasAnswer))
 {
 sbSQL.AppendFormat(" IsHasAnswer = '{0}',", objge_StuBatchQuesRelaEN.IsHasAnswer == true?"1":"0"); //是否有答案
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.IsPublish))
 {
 sbSQL.AppendFormat(" IsPublish = '{0}',", objge_StuBatchQuesRelaEN.IsPublish == true?"1":"0"); //是否发布
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.IsRight))
 {
 sbSQL.AppendFormat(" IsRight = '{0}',", objge_StuBatchQuesRelaEN.IsRight == true?"1":"0"); //是否正确
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.IsSave))
 {
 sbSQL.AppendFormat(" IsSave = '{0}',", objge_StuBatchQuesRelaEN.IsSave == true?"1":"0"); //是否保存
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.IsSendBack))
 {
 sbSQL.AppendFormat(" IsSendBack = '{0}',", objge_StuBatchQuesRelaEN.IsSendBack == true?"1":"0"); //是否退回
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objge_StuBatchQuesRelaEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.MarkDate))
 {
 if (objge_StuBatchQuesRelaEN.MarkDate !=  null)
 {
 var strMarkDate = objge_StuBatchQuesRelaEN.MarkDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MarkDate = '{0}',", strMarkDate); //打分日期
 }
 else
 {
 sbSQL.Append(" MarkDate = null,"); //打分日期
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.MarkerId))
 {
 if (objge_StuBatchQuesRelaEN.MarkerId !=  null)
 {
 var strMarkerId = objge_StuBatchQuesRelaEN.MarkerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MarkerId = '{0}',", strMarkerId); //打分者
 }
 else
 {
 sbSQL.Append(" MarkerId = null,"); //打分者
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.OperateTime))
 {
 if (objge_StuBatchQuesRelaEN.OperateTime !=  null)
 {
 var strOperateTime = objge_StuBatchQuesRelaEN.OperateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OperateTime = '{0}',", strOperateTime); //操作时间
 }
 else
 {
 sbSQL.Append(" OperateTime = null,"); //操作时间
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.RealFinishDate))
 {
 if (objge_StuBatchQuesRelaEN.RealFinishDate !=  null)
 {
 var strRealFinishDate = objge_StuBatchQuesRelaEN.RealFinishDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RealFinishDate = '{0}',", strRealFinishDate); //实际完成日期
 }
 else
 {
 sbSQL.Append(" RealFinishDate = null,"); //实际完成日期
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.WorkTypeId))
 {
 if (objge_StuBatchQuesRelaEN.WorkTypeId !=  null)
 {
 var strWorkTypeId = objge_StuBatchQuesRelaEN.WorkTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WorkTypeId = '{0}',", strWorkTypeId); //作业类型Id
 }
 else
 {
 sbSQL.Append(" WorkTypeId = null,"); //作业类型Id
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.SchoolYear))
 {
 if (objge_StuBatchQuesRelaEN.SchoolYear !=  null)
 {
 var strSchoolYear = objge_StuBatchQuesRelaEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolYear = '{0}',", strSchoolYear); //学年
 }
 else
 {
 sbSQL.Append(" SchoolYear = null,"); //学年
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.SchoolTerm))
 {
 if (objge_StuBatchQuesRelaEN.SchoolTerm !=  null)
 {
 var strSchoolTerm = objge_StuBatchQuesRelaEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolTerm = '{0}',", strSchoolTerm); //学期
 }
 else
 {
 sbSQL.Append(" SchoolTerm = null,"); //学期
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.ErrMsg))
 {
 if (objge_StuBatchQuesRelaEN.ErrMsg !=  null)
 {
 var strErrMsg = objge_StuBatchQuesRelaEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ErrMsg = '{0}',", strErrMsg); //错误信息
 }
 else
 {
 sbSQL.Append(" ErrMsg = null,"); //错误信息
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.IsRecommend))
 {
 sbSQL.AppendFormat(" IsRecommend = '{0}',", objge_StuBatchQuesRelaEN.IsRecommend == true?"1":"0"); //是否推荐
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.CourseId))
 {
 if (objge_StuBatchQuesRelaEN.CourseId !=  null)
 {
 var strCourseId = objge_StuBatchQuesRelaEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.UpdDate))
 {
 if (objge_StuBatchQuesRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objge_StuBatchQuesRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.UpdUserId))
 {
 if (objge_StuBatchQuesRelaEN.UpdUserId !=  null)
 {
 var strUpdUserId = objge_StuBatchQuesRelaEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.Memo))
 {
 if (objge_StuBatchQuesRelaEN.Memo !=  null)
 {
 var strMemo = objge_StuBatchQuesRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objge_StuBatchQuesRelaEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objge_StuBatchQuesRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objge_StuBatchQuesRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objge_StuBatchQuesRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StuBatchQuesRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ge_StuBatchQuesRela Set ");
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.ExamBatchNo))
 {
 if (objge_StuBatchQuesRelaEN.ExamBatchNo  ==  "")
 {
 objge_StuBatchQuesRelaEN.ExamBatchNo = null;
 }
 if (objge_StuBatchQuesRelaEN.ExamBatchNo !=  null)
 {
 var strExamBatchNo = objge_StuBatchQuesRelaEN.ExamBatchNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ExamBatchNo = '{0}',", strExamBatchNo); //学生批次号
 }
 else
 {
 sbSQL.Append(" ExamBatchNo = null,"); //学生批次号
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.LevelNo))
 {
 if (objge_StuBatchQuesRelaEN.LevelNo !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_StuBatchQuesRelaEN.LevelNo, conge_StuBatchQuesRela.LevelNo); //学习关号2
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuBatchQuesRela.LevelNo); //学习关号2
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.QuestionId))
 {
 sbSQL.AppendFormat(" QuestionId = {0},", objge_StuBatchQuesRelaEN.QuestionId); //题目Id
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.UserId))
 {
 if (objge_StuBatchQuesRelaEN.UserId !=  null)
 {
 var strUserId = objge_StuBatchQuesRelaEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户ID
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户ID
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.IdCurrEduCls))
 {
 if (objge_StuBatchQuesRelaEN.IdCurrEduCls  ==  "")
 {
 objge_StuBatchQuesRelaEN.IdCurrEduCls = null;
 }
 if (objge_StuBatchQuesRelaEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objge_StuBatchQuesRelaEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.QuestionIndex4Batch))
 {
 if (objge_StuBatchQuesRelaEN.QuestionIndex4Batch !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_StuBatchQuesRelaEN.QuestionIndex4Batch, conge_StuBatchQuesRela.QuestionIndex4Batch); //题序号4批次
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuBatchQuesRela.QuestionIndex4Batch); //题序号4批次
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.GameLevelId))
 {
 if (objge_StuBatchQuesRelaEN.GameLevelId !=  null)
 {
 var strGameLevelId = objge_StuBatchQuesRelaEN.GameLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GameLevelId = '{0}',", strGameLevelId); //游戏关卡Id
 }
 else
 {
 sbSQL.Append(" GameLevelId = null,"); //游戏关卡Id
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.Scores))
 {
 if (objge_StuBatchQuesRelaEN.Scores !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_StuBatchQuesRelaEN.Scores, conge_StuBatchQuesRela.Scores); //分值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuBatchQuesRela.Scores); //分值
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.Score))
 {
 if (objge_StuBatchQuesRelaEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_StuBatchQuesRelaEN.Score, conge_StuBatchQuesRela.Score); //得分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuBatchQuesRela.Score); //得分
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.StuAnswerText))
 {
 if (objge_StuBatchQuesRelaEN.StuAnswerText !=  null)
 {
 var strStuAnswerText = objge_StuBatchQuesRelaEN.StuAnswerText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StuAnswerText = '{0}',", strStuAnswerText); //学生回答文本
 }
 else
 {
 sbSQL.Append(" StuAnswerText = null,"); //学生回答文本
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.AnswerDate))
 {
 if (objge_StuBatchQuesRelaEN.AnswerDate !=  null)
 {
 var strAnswerDate = objge_StuBatchQuesRelaEN.AnswerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerDate = '{0}',", strAnswerDate); //回答日期
 }
 else
 {
 sbSQL.Append(" AnswerDate = null,"); //回答日期
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.AnswerIP))
 {
 if (objge_StuBatchQuesRelaEN.AnswerIP !=  null)
 {
 var strAnswerIP = objge_StuBatchQuesRelaEN.AnswerIP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerIP = '{0}',", strAnswerIP); //回答IP
 }
 else
 {
 sbSQL.Append(" AnswerIP = null,"); //回答IP
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.AnswerModeId))
 {
 if (objge_StuBatchQuesRelaEN.AnswerModeId !=  null)
 {
 var strAnswerModeId = objge_StuBatchQuesRelaEN.AnswerModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerModeId = '{0}',", strAnswerModeId); //答案模式Id
 }
 else
 {
 sbSQL.Append(" AnswerModeId = null,"); //答案模式Id
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.AnswerMultiOptions))
 {
 if (objge_StuBatchQuesRelaEN.AnswerMultiOptions !=  null)
 {
 var strAnswerMultiOptions = objge_StuBatchQuesRelaEN.AnswerMultiOptions.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerMultiOptions = '{0}',", strAnswerMultiOptions); //多选项答案
 }
 else
 {
 sbSQL.Append(" AnswerMultiOptions = null,"); //多选项答案
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.AnswerOptionId))
 {
 if (objge_StuBatchQuesRelaEN.AnswerOptionId !=  null)
 {
 var strAnswerOptionId = objge_StuBatchQuesRelaEN.AnswerOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerOptionId = '{0}',", strAnswerOptionId); //回答选项Id
 }
 else
 {
 sbSQL.Append(" AnswerOptionId = null,"); //回答选项Id
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.AnswerTime))
 {
 if (objge_StuBatchQuesRelaEN.AnswerTime !=  null)
 {
 var strAnswerTime = objge_StuBatchQuesRelaEN.AnswerTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerTime = '{0}',", strAnswerTime); //回答时间
 }
 else
 {
 sbSQL.Append(" AnswerTime = null,"); //回答时间
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.ApplySendBackDate))
 {
 if (objge_StuBatchQuesRelaEN.ApplySendBackDate !=  null)
 {
 var strApplySendBackDate = objge_StuBatchQuesRelaEN.ApplySendBackDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ApplySendBackDate = '{0}',", strApplySendBackDate); //申请退回日期
 }
 else
 {
 sbSQL.Append(" ApplySendBackDate = null,"); //申请退回日期
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.Comment))
 {
 if (objge_StuBatchQuesRelaEN.Comment !=  null)
 {
 var strComment = objge_StuBatchQuesRelaEN.Comment.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Comment = '{0}',", strComment); //批注
 }
 else
 {
 sbSQL.Append(" Comment = null,"); //批注
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.IsAccessKnowledge))
 {
 sbSQL.AppendFormat(" IsAccessKnowledge = '{0}',", objge_StuBatchQuesRelaEN.IsAccessKnowledge == true?"1":"0"); //是否处理知识点
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.IsApplySendBack))
 {
 sbSQL.AppendFormat(" IsApplySendBack = '{0}',", objge_StuBatchQuesRelaEN.IsApplySendBack == true?"1":"0"); //是否申请退回
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.IsInErrorQuestion))
 {
 sbSQL.AppendFormat(" IsInErrorQuestion = '{0}',", objge_StuBatchQuesRelaEN.IsInErrorQuestion == true?"1":"0"); //是否进入错题
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.IsLook))
 {
 sbSQL.AppendFormat(" IsLook = '{0}',", objge_StuBatchQuesRelaEN.IsLook == true?"1":"0"); //是否查看
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.IsMarking))
 {
 sbSQL.AppendFormat(" IsMarking = '{0}',", objge_StuBatchQuesRelaEN.IsMarking == true?"1":"0"); //是否批阅
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.IsNotProcessTimeout))
 {
 sbSQL.AppendFormat(" IsNotProcessTimeout = '{0}',", objge_StuBatchQuesRelaEN.IsNotProcessTimeout == true?"1":"0"); //是否不处理超时
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.IsHasAnswer))
 {
 sbSQL.AppendFormat(" IsHasAnswer = '{0}',", objge_StuBatchQuesRelaEN.IsHasAnswer == true?"1":"0"); //是否有答案
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.IsPublish))
 {
 sbSQL.AppendFormat(" IsPublish = '{0}',", objge_StuBatchQuesRelaEN.IsPublish == true?"1":"0"); //是否发布
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.IsRight))
 {
 sbSQL.AppendFormat(" IsRight = '{0}',", objge_StuBatchQuesRelaEN.IsRight == true?"1":"0"); //是否正确
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.IsSave))
 {
 sbSQL.AppendFormat(" IsSave = '{0}',", objge_StuBatchQuesRelaEN.IsSave == true?"1":"0"); //是否保存
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.IsSendBack))
 {
 sbSQL.AppendFormat(" IsSendBack = '{0}',", objge_StuBatchQuesRelaEN.IsSendBack == true?"1":"0"); //是否退回
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objge_StuBatchQuesRelaEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.MarkDate))
 {
 if (objge_StuBatchQuesRelaEN.MarkDate !=  null)
 {
 var strMarkDate = objge_StuBatchQuesRelaEN.MarkDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MarkDate = '{0}',", strMarkDate); //打分日期
 }
 else
 {
 sbSQL.Append(" MarkDate = null,"); //打分日期
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.MarkerId))
 {
 if (objge_StuBatchQuesRelaEN.MarkerId !=  null)
 {
 var strMarkerId = objge_StuBatchQuesRelaEN.MarkerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MarkerId = '{0}',", strMarkerId); //打分者
 }
 else
 {
 sbSQL.Append(" MarkerId = null,"); //打分者
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.OperateTime))
 {
 if (objge_StuBatchQuesRelaEN.OperateTime !=  null)
 {
 var strOperateTime = objge_StuBatchQuesRelaEN.OperateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OperateTime = '{0}',", strOperateTime); //操作时间
 }
 else
 {
 sbSQL.Append(" OperateTime = null,"); //操作时间
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.RealFinishDate))
 {
 if (objge_StuBatchQuesRelaEN.RealFinishDate !=  null)
 {
 var strRealFinishDate = objge_StuBatchQuesRelaEN.RealFinishDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RealFinishDate = '{0}',", strRealFinishDate); //实际完成日期
 }
 else
 {
 sbSQL.Append(" RealFinishDate = null,"); //实际完成日期
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.WorkTypeId))
 {
 if (objge_StuBatchQuesRelaEN.WorkTypeId !=  null)
 {
 var strWorkTypeId = objge_StuBatchQuesRelaEN.WorkTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WorkTypeId = '{0}',", strWorkTypeId); //作业类型Id
 }
 else
 {
 sbSQL.Append(" WorkTypeId = null,"); //作业类型Id
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.SchoolYear))
 {
 if (objge_StuBatchQuesRelaEN.SchoolYear !=  null)
 {
 var strSchoolYear = objge_StuBatchQuesRelaEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolYear = '{0}',", strSchoolYear); //学年
 }
 else
 {
 sbSQL.Append(" SchoolYear = null,"); //学年
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.SchoolTerm))
 {
 if (objge_StuBatchQuesRelaEN.SchoolTerm !=  null)
 {
 var strSchoolTerm = objge_StuBatchQuesRelaEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolTerm = '{0}',", strSchoolTerm); //学期
 }
 else
 {
 sbSQL.Append(" SchoolTerm = null,"); //学期
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.ErrMsg))
 {
 if (objge_StuBatchQuesRelaEN.ErrMsg !=  null)
 {
 var strErrMsg = objge_StuBatchQuesRelaEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ErrMsg = '{0}',", strErrMsg); //错误信息
 }
 else
 {
 sbSQL.Append(" ErrMsg = null,"); //错误信息
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.IsRecommend))
 {
 sbSQL.AppendFormat(" IsRecommend = '{0}',", objge_StuBatchQuesRelaEN.IsRecommend == true?"1":"0"); //是否推荐
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.CourseId))
 {
 if (objge_StuBatchQuesRelaEN.CourseId !=  null)
 {
 var strCourseId = objge_StuBatchQuesRelaEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.UpdDate))
 {
 if (objge_StuBatchQuesRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objge_StuBatchQuesRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.UpdUserId))
 {
 if (objge_StuBatchQuesRelaEN.UpdUserId !=  null)
 {
 var strUpdUserId = objge_StuBatchQuesRelaEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.Memo))
 {
 if (objge_StuBatchQuesRelaEN.Memo !=  null)
 {
 var strMemo = objge_StuBatchQuesRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objge_StuBatchQuesRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objge_StuBatchQuesRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objge_StuBatchQuesRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objge_StuBatchQuesRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StuBatchQuesRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ge_StuBatchQuesRela Set ");
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.ExamBatchNo))
 {
 if (objge_StuBatchQuesRelaEN.ExamBatchNo  ==  "")
 {
 objge_StuBatchQuesRelaEN.ExamBatchNo = null;
 }
 if (objge_StuBatchQuesRelaEN.ExamBatchNo !=  null)
 {
 var strExamBatchNo = objge_StuBatchQuesRelaEN.ExamBatchNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExamBatchNo, conge_StuBatchQuesRela.ExamBatchNo); //学生批次号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuBatchQuesRela.ExamBatchNo); //学生批次号
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.LevelNo))
 {
 if (objge_StuBatchQuesRelaEN.LevelNo !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_StuBatchQuesRelaEN.LevelNo, conge_StuBatchQuesRela.LevelNo); //学习关号2
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuBatchQuesRela.LevelNo); //学习关号2
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.QuestionId))
 {
 sbSQL.AppendFormat("{1} = {0},",objge_StuBatchQuesRelaEN.QuestionId, conge_StuBatchQuesRela.QuestionId); //题目Id
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.UserId))
 {
 if (objge_StuBatchQuesRelaEN.UserId !=  null)
 {
 var strUserId = objge_StuBatchQuesRelaEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conge_StuBatchQuesRela.UserId); //用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuBatchQuesRela.UserId); //用户ID
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.IdCurrEduCls))
 {
 if (objge_StuBatchQuesRelaEN.IdCurrEduCls  ==  "")
 {
 objge_StuBatchQuesRelaEN.IdCurrEduCls = null;
 }
 if (objge_StuBatchQuesRelaEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objge_StuBatchQuesRelaEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conge_StuBatchQuesRela.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuBatchQuesRela.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.QuestionIndex4Batch))
 {
 if (objge_StuBatchQuesRelaEN.QuestionIndex4Batch !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_StuBatchQuesRelaEN.QuestionIndex4Batch, conge_StuBatchQuesRela.QuestionIndex4Batch); //题序号4批次
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuBatchQuesRela.QuestionIndex4Batch); //题序号4批次
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.GameLevelId))
 {
 if (objge_StuBatchQuesRelaEN.GameLevelId !=  null)
 {
 var strGameLevelId = objge_StuBatchQuesRelaEN.GameLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGameLevelId, conge_StuBatchQuesRela.GameLevelId); //游戏关卡Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuBatchQuesRela.GameLevelId); //游戏关卡Id
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.Scores))
 {
 if (objge_StuBatchQuesRelaEN.Scores !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_StuBatchQuesRelaEN.Scores, conge_StuBatchQuesRela.Scores); //分值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuBatchQuesRela.Scores); //分值
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.Score))
 {
 if (objge_StuBatchQuesRelaEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_StuBatchQuesRelaEN.Score, conge_StuBatchQuesRela.Score); //得分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuBatchQuesRela.Score); //得分
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.StuAnswerText))
 {
 if (objge_StuBatchQuesRelaEN.StuAnswerText !=  null)
 {
 var strStuAnswerText = objge_StuBatchQuesRelaEN.StuAnswerText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStuAnswerText, conge_StuBatchQuesRela.StuAnswerText); //学生回答文本
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuBatchQuesRela.StuAnswerText); //学生回答文本
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.AnswerDate))
 {
 if (objge_StuBatchQuesRelaEN.AnswerDate !=  null)
 {
 var strAnswerDate = objge_StuBatchQuesRelaEN.AnswerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerDate, conge_StuBatchQuesRela.AnswerDate); //回答日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuBatchQuesRela.AnswerDate); //回答日期
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.AnswerIP))
 {
 if (objge_StuBatchQuesRelaEN.AnswerIP !=  null)
 {
 var strAnswerIP = objge_StuBatchQuesRelaEN.AnswerIP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerIP, conge_StuBatchQuesRela.AnswerIP); //回答IP
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuBatchQuesRela.AnswerIP); //回答IP
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.AnswerModeId))
 {
 if (objge_StuBatchQuesRelaEN.AnswerModeId !=  null)
 {
 var strAnswerModeId = objge_StuBatchQuesRelaEN.AnswerModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerModeId, conge_StuBatchQuesRela.AnswerModeId); //答案模式Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuBatchQuesRela.AnswerModeId); //答案模式Id
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.AnswerMultiOptions))
 {
 if (objge_StuBatchQuesRelaEN.AnswerMultiOptions !=  null)
 {
 var strAnswerMultiOptions = objge_StuBatchQuesRelaEN.AnswerMultiOptions.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerMultiOptions, conge_StuBatchQuesRela.AnswerMultiOptions); //多选项答案
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuBatchQuesRela.AnswerMultiOptions); //多选项答案
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.AnswerOptionId))
 {
 if (objge_StuBatchQuesRelaEN.AnswerOptionId !=  null)
 {
 var strAnswerOptionId = objge_StuBatchQuesRelaEN.AnswerOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerOptionId, conge_StuBatchQuesRela.AnswerOptionId); //回答选项Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuBatchQuesRela.AnswerOptionId); //回答选项Id
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.AnswerTime))
 {
 if (objge_StuBatchQuesRelaEN.AnswerTime !=  null)
 {
 var strAnswerTime = objge_StuBatchQuesRelaEN.AnswerTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerTime, conge_StuBatchQuesRela.AnswerTime); //回答时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuBatchQuesRela.AnswerTime); //回答时间
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.ApplySendBackDate))
 {
 if (objge_StuBatchQuesRelaEN.ApplySendBackDate !=  null)
 {
 var strApplySendBackDate = objge_StuBatchQuesRelaEN.ApplySendBackDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strApplySendBackDate, conge_StuBatchQuesRela.ApplySendBackDate); //申请退回日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuBatchQuesRela.ApplySendBackDate); //申请退回日期
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.Comment))
 {
 if (objge_StuBatchQuesRelaEN.Comment !=  null)
 {
 var strComment = objge_StuBatchQuesRelaEN.Comment.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strComment, conge_StuBatchQuesRela.Comment); //批注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuBatchQuesRela.Comment); //批注
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.IsAccessKnowledge))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objge_StuBatchQuesRelaEN.IsAccessKnowledge == true?"1":"0", conge_StuBatchQuesRela.IsAccessKnowledge); //是否处理知识点
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.IsApplySendBack))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objge_StuBatchQuesRelaEN.IsApplySendBack == true?"1":"0", conge_StuBatchQuesRela.IsApplySendBack); //是否申请退回
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.IsInErrorQuestion))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objge_StuBatchQuesRelaEN.IsInErrorQuestion == true?"1":"0", conge_StuBatchQuesRela.IsInErrorQuestion); //是否进入错题
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.IsLook))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objge_StuBatchQuesRelaEN.IsLook == true?"1":"0", conge_StuBatchQuesRela.IsLook); //是否查看
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.IsMarking))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objge_StuBatchQuesRelaEN.IsMarking == true?"1":"0", conge_StuBatchQuesRela.IsMarking); //是否批阅
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.IsNotProcessTimeout))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objge_StuBatchQuesRelaEN.IsNotProcessTimeout == true?"1":"0", conge_StuBatchQuesRela.IsNotProcessTimeout); //是否不处理超时
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.IsHasAnswer))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objge_StuBatchQuesRelaEN.IsHasAnswer == true?"1":"0", conge_StuBatchQuesRela.IsHasAnswer); //是否有答案
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.IsPublish))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objge_StuBatchQuesRelaEN.IsPublish == true?"1":"0", conge_StuBatchQuesRela.IsPublish); //是否发布
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.IsRight))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objge_StuBatchQuesRelaEN.IsRight == true?"1":"0", conge_StuBatchQuesRela.IsRight); //是否正确
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.IsSave))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objge_StuBatchQuesRelaEN.IsSave == true?"1":"0", conge_StuBatchQuesRela.IsSave); //是否保存
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.IsSendBack))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objge_StuBatchQuesRelaEN.IsSendBack == true?"1":"0", conge_StuBatchQuesRela.IsSendBack); //是否退回
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objge_StuBatchQuesRelaEN.IsSubmit == true?"1":"0", conge_StuBatchQuesRela.IsSubmit); //是否提交
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.MarkDate))
 {
 if (objge_StuBatchQuesRelaEN.MarkDate !=  null)
 {
 var strMarkDate = objge_StuBatchQuesRelaEN.MarkDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMarkDate, conge_StuBatchQuesRela.MarkDate); //打分日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuBatchQuesRela.MarkDate); //打分日期
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.MarkerId))
 {
 if (objge_StuBatchQuesRelaEN.MarkerId !=  null)
 {
 var strMarkerId = objge_StuBatchQuesRelaEN.MarkerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMarkerId, conge_StuBatchQuesRela.MarkerId); //打分者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuBatchQuesRela.MarkerId); //打分者
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.OperateTime))
 {
 if (objge_StuBatchQuesRelaEN.OperateTime !=  null)
 {
 var strOperateTime = objge_StuBatchQuesRelaEN.OperateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOperateTime, conge_StuBatchQuesRela.OperateTime); //操作时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuBatchQuesRela.OperateTime); //操作时间
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.RealFinishDate))
 {
 if (objge_StuBatchQuesRelaEN.RealFinishDate !=  null)
 {
 var strRealFinishDate = objge_StuBatchQuesRelaEN.RealFinishDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRealFinishDate, conge_StuBatchQuesRela.RealFinishDate); //实际完成日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuBatchQuesRela.RealFinishDate); //实际完成日期
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.WorkTypeId))
 {
 if (objge_StuBatchQuesRelaEN.WorkTypeId !=  null)
 {
 var strWorkTypeId = objge_StuBatchQuesRelaEN.WorkTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWorkTypeId, conge_StuBatchQuesRela.WorkTypeId); //作业类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuBatchQuesRela.WorkTypeId); //作业类型Id
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.SchoolYear))
 {
 if (objge_StuBatchQuesRelaEN.SchoolYear !=  null)
 {
 var strSchoolYear = objge_StuBatchQuesRelaEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchoolYear, conge_StuBatchQuesRela.SchoolYear); //学年
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuBatchQuesRela.SchoolYear); //学年
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.SchoolTerm))
 {
 if (objge_StuBatchQuesRelaEN.SchoolTerm !=  null)
 {
 var strSchoolTerm = objge_StuBatchQuesRelaEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchoolTerm, conge_StuBatchQuesRela.SchoolTerm); //学期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuBatchQuesRela.SchoolTerm); //学期
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.ErrMsg))
 {
 if (objge_StuBatchQuesRelaEN.ErrMsg !=  null)
 {
 var strErrMsg = objge_StuBatchQuesRelaEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strErrMsg, conge_StuBatchQuesRela.ErrMsg); //错误信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuBatchQuesRela.ErrMsg); //错误信息
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.IsRecommend))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objge_StuBatchQuesRelaEN.IsRecommend == true?"1":"0", conge_StuBatchQuesRela.IsRecommend); //是否推荐
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.CourseId))
 {
 if (objge_StuBatchQuesRelaEN.CourseId !=  null)
 {
 var strCourseId = objge_StuBatchQuesRelaEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, conge_StuBatchQuesRela.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuBatchQuesRela.CourseId); //课程Id
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.UpdDate))
 {
 if (objge_StuBatchQuesRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objge_StuBatchQuesRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conge_StuBatchQuesRela.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuBatchQuesRela.UpdDate); //修改日期
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.UpdUserId))
 {
 if (objge_StuBatchQuesRelaEN.UpdUserId !=  null)
 {
 var strUpdUserId = objge_StuBatchQuesRelaEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conge_StuBatchQuesRela.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuBatchQuesRela.UpdUserId); //修改用户Id
 }
 }
 
 if (objge_StuBatchQuesRelaEN.IsUpdated(conge_StuBatchQuesRela.Memo))
 {
 if (objge_StuBatchQuesRelaEN.Memo !=  null)
 {
 var strMemo = objge_StuBatchQuesRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conge_StuBatchQuesRela.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuBatchQuesRela.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdStuBatchQuesRela = {0}", objge_StuBatchQuesRelaEN.IdStuBatchQuesRela); 
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
 /// <param name = "lngIdStuBatchQuesRela">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngIdStuBatchQuesRela) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StuBatchQuesRelaDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngIdStuBatchQuesRela,
};
 objSQL.ExecSP("ge_StuBatchQuesRela_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngIdStuBatchQuesRela">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngIdStuBatchQuesRela, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StuBatchQuesRelaDA.GetSpecSQLObj();
//删除ge_StuBatchQuesRela本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ge_StuBatchQuesRela where IdStuBatchQuesRela = " + ""+ lngIdStuBatchQuesRela+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delge_StuBatchQuesRela(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StuBatchQuesRelaDA.GetSpecSQLObj();
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
//删除ge_StuBatchQuesRela本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ge_StuBatchQuesRela where IdStuBatchQuesRela in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngIdStuBatchQuesRela">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngIdStuBatchQuesRela) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StuBatchQuesRelaDA.GetSpecSQLObj();
//删除ge_StuBatchQuesRela本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ge_StuBatchQuesRela where IdStuBatchQuesRela = " + ""+ lngIdStuBatchQuesRela+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delge_StuBatchQuesRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsge_StuBatchQuesRelaDA: Delge_StuBatchQuesRela)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StuBatchQuesRelaDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ge_StuBatchQuesRela where " + strCondition ;
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
public bool Delge_StuBatchQuesRelaWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsge_StuBatchQuesRelaDA: Delge_StuBatchQuesRelaWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StuBatchQuesRelaDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ge_StuBatchQuesRela where " + strCondition ;
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
 /// <param name = "objge_StuBatchQuesRelaENS">源对象</param>
 /// <param name = "objge_StuBatchQuesRelaENT">目标对象</param>
public void CopyTo(clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaENS, clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaENT)
{
objge_StuBatchQuesRelaENT.IdStuBatchQuesRela = objge_StuBatchQuesRelaENS.IdStuBatchQuesRela; //学生批次题目关系流水号
objge_StuBatchQuesRelaENT.ExamBatchNo = objge_StuBatchQuesRelaENS.ExamBatchNo; //学生批次号
objge_StuBatchQuesRelaENT.LevelNo = objge_StuBatchQuesRelaENS.LevelNo; //学习关号2
objge_StuBatchQuesRelaENT.QuestionId = objge_StuBatchQuesRelaENS.QuestionId; //题目Id
objge_StuBatchQuesRelaENT.UserId = objge_StuBatchQuesRelaENS.UserId; //用户ID
objge_StuBatchQuesRelaENT.IdCurrEduCls = objge_StuBatchQuesRelaENS.IdCurrEduCls; //教学班流水号
objge_StuBatchQuesRelaENT.QuestionIndex4Batch = objge_StuBatchQuesRelaENS.QuestionIndex4Batch; //题序号4批次
objge_StuBatchQuesRelaENT.GameLevelId = objge_StuBatchQuesRelaENS.GameLevelId; //游戏关卡Id
objge_StuBatchQuesRelaENT.Scores = objge_StuBatchQuesRelaENS.Scores; //分值
objge_StuBatchQuesRelaENT.Score = objge_StuBatchQuesRelaENS.Score; //得分
objge_StuBatchQuesRelaENT.StuAnswerText = objge_StuBatchQuesRelaENS.StuAnswerText; //学生回答文本
objge_StuBatchQuesRelaENT.AnswerDate = objge_StuBatchQuesRelaENS.AnswerDate; //回答日期
objge_StuBatchQuesRelaENT.AnswerIP = objge_StuBatchQuesRelaENS.AnswerIP; //回答IP
objge_StuBatchQuesRelaENT.AnswerModeId = objge_StuBatchQuesRelaENS.AnswerModeId; //答案模式Id
objge_StuBatchQuesRelaENT.AnswerMultiOptions = objge_StuBatchQuesRelaENS.AnswerMultiOptions; //多选项答案
objge_StuBatchQuesRelaENT.AnswerOptionId = objge_StuBatchQuesRelaENS.AnswerOptionId; //回答选项Id
objge_StuBatchQuesRelaENT.AnswerTime = objge_StuBatchQuesRelaENS.AnswerTime; //回答时间
objge_StuBatchQuesRelaENT.ApplySendBackDate = objge_StuBatchQuesRelaENS.ApplySendBackDate; //申请退回日期
objge_StuBatchQuesRelaENT.Comment = objge_StuBatchQuesRelaENS.Comment; //批注
objge_StuBatchQuesRelaENT.IsAccessKnowledge = objge_StuBatchQuesRelaENS.IsAccessKnowledge; //是否处理知识点
objge_StuBatchQuesRelaENT.IsApplySendBack = objge_StuBatchQuesRelaENS.IsApplySendBack; //是否申请退回
objge_StuBatchQuesRelaENT.IsInErrorQuestion = objge_StuBatchQuesRelaENS.IsInErrorQuestion; //是否进入错题
objge_StuBatchQuesRelaENT.IsLook = objge_StuBatchQuesRelaENS.IsLook; //是否查看
objge_StuBatchQuesRelaENT.IsMarking = objge_StuBatchQuesRelaENS.IsMarking; //是否批阅
objge_StuBatchQuesRelaENT.IsNotProcessTimeout = objge_StuBatchQuesRelaENS.IsNotProcessTimeout; //是否不处理超时
objge_StuBatchQuesRelaENT.IsHasAnswer = objge_StuBatchQuesRelaENS.IsHasAnswer; //是否有答案
objge_StuBatchQuesRelaENT.IsPublish = objge_StuBatchQuesRelaENS.IsPublish; //是否发布
objge_StuBatchQuesRelaENT.IsRight = objge_StuBatchQuesRelaENS.IsRight; //是否正确
objge_StuBatchQuesRelaENT.IsSave = objge_StuBatchQuesRelaENS.IsSave; //是否保存
objge_StuBatchQuesRelaENT.IsSendBack = objge_StuBatchQuesRelaENS.IsSendBack; //是否退回
objge_StuBatchQuesRelaENT.IsSubmit = objge_StuBatchQuesRelaENS.IsSubmit; //是否提交
objge_StuBatchQuesRelaENT.MarkDate = objge_StuBatchQuesRelaENS.MarkDate; //打分日期
objge_StuBatchQuesRelaENT.MarkerId = objge_StuBatchQuesRelaENS.MarkerId; //打分者
objge_StuBatchQuesRelaENT.OperateTime = objge_StuBatchQuesRelaENS.OperateTime; //操作时间
objge_StuBatchQuesRelaENT.RealFinishDate = objge_StuBatchQuesRelaENS.RealFinishDate; //实际完成日期
objge_StuBatchQuesRelaENT.WorkTypeId = objge_StuBatchQuesRelaENS.WorkTypeId; //作业类型Id
objge_StuBatchQuesRelaENT.SchoolYear = objge_StuBatchQuesRelaENS.SchoolYear; //学年
objge_StuBatchQuesRelaENT.SchoolTerm = objge_StuBatchQuesRelaENS.SchoolTerm; //学期
objge_StuBatchQuesRelaENT.ErrMsg = objge_StuBatchQuesRelaENS.ErrMsg; //错误信息
objge_StuBatchQuesRelaENT.IsRecommend = objge_StuBatchQuesRelaENS.IsRecommend; //是否推荐
objge_StuBatchQuesRelaENT.CourseId = objge_StuBatchQuesRelaENS.CourseId; //课程Id
objge_StuBatchQuesRelaENT.UpdDate = objge_StuBatchQuesRelaENS.UpdDate; //修改日期
objge_StuBatchQuesRelaENT.UpdUserId = objge_StuBatchQuesRelaENS.UpdUserId; //修改用户Id
objge_StuBatchQuesRelaENT.Memo = objge_StuBatchQuesRelaENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objge_StuBatchQuesRelaEN.ExamBatchNo, conge_StuBatchQuesRela.ExamBatchNo);
clsCheckSql.CheckFieldNotNull(objge_StuBatchQuesRelaEN.QuestionId, conge_StuBatchQuesRela.QuestionId);
clsCheckSql.CheckFieldNotNull(objge_StuBatchQuesRelaEN.UserId, conge_StuBatchQuesRela.UserId);
clsCheckSql.CheckFieldNotNull(objge_StuBatchQuesRelaEN.IdCurrEduCls, conge_StuBatchQuesRela.IdCurrEduCls);
clsCheckSql.CheckFieldNotNull(objge_StuBatchQuesRelaEN.UpdDate, conge_StuBatchQuesRela.UpdDate);
//检查字段长度
clsCheckSql.CheckFieldLen(objge_StuBatchQuesRelaEN.ExamBatchNo, 20, conge_StuBatchQuesRela.ExamBatchNo);
clsCheckSql.CheckFieldLen(objge_StuBatchQuesRelaEN.UserId, 18, conge_StuBatchQuesRela.UserId);
clsCheckSql.CheckFieldLen(objge_StuBatchQuesRelaEN.IdCurrEduCls, 8, conge_StuBatchQuesRela.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objge_StuBatchQuesRelaEN.GameLevelId, 8, conge_StuBatchQuesRela.GameLevelId);
clsCheckSql.CheckFieldLen(objge_StuBatchQuesRelaEN.AnswerDate, 8, conge_StuBatchQuesRela.AnswerDate);
clsCheckSql.CheckFieldLen(objge_StuBatchQuesRelaEN.AnswerIP, 30, conge_StuBatchQuesRela.AnswerIP);
clsCheckSql.CheckFieldLen(objge_StuBatchQuesRelaEN.AnswerModeId, 4, conge_StuBatchQuesRela.AnswerModeId);
clsCheckSql.CheckFieldLen(objge_StuBatchQuesRelaEN.AnswerMultiOptions, 300, conge_StuBatchQuesRela.AnswerMultiOptions);
clsCheckSql.CheckFieldLen(objge_StuBatchQuesRelaEN.AnswerOptionId, 8, conge_StuBatchQuesRela.AnswerOptionId);
clsCheckSql.CheckFieldLen(objge_StuBatchQuesRelaEN.AnswerTime, 10, conge_StuBatchQuesRela.AnswerTime);
clsCheckSql.CheckFieldLen(objge_StuBatchQuesRelaEN.ApplySendBackDate, 14, conge_StuBatchQuesRela.ApplySendBackDate);
clsCheckSql.CheckFieldLen(objge_StuBatchQuesRelaEN.MarkDate, 14, conge_StuBatchQuesRela.MarkDate);
clsCheckSql.CheckFieldLen(objge_StuBatchQuesRelaEN.MarkerId, 20, conge_StuBatchQuesRela.MarkerId);
clsCheckSql.CheckFieldLen(objge_StuBatchQuesRelaEN.OperateTime, 14, conge_StuBatchQuesRela.OperateTime);
clsCheckSql.CheckFieldLen(objge_StuBatchQuesRelaEN.RealFinishDate, 14, conge_StuBatchQuesRela.RealFinishDate);
clsCheckSql.CheckFieldLen(objge_StuBatchQuesRelaEN.WorkTypeId, 2, conge_StuBatchQuesRela.WorkTypeId);
clsCheckSql.CheckFieldLen(objge_StuBatchQuesRelaEN.SchoolYear, 10, conge_StuBatchQuesRela.SchoolYear);
clsCheckSql.CheckFieldLen(objge_StuBatchQuesRelaEN.SchoolTerm, 1, conge_StuBatchQuesRela.SchoolTerm);
clsCheckSql.CheckFieldLen(objge_StuBatchQuesRelaEN.ErrMsg, 200, conge_StuBatchQuesRela.ErrMsg);
clsCheckSql.CheckFieldLen(objge_StuBatchQuesRelaEN.CourseId, 8, conge_StuBatchQuesRela.CourseId);
clsCheckSql.CheckFieldLen(objge_StuBatchQuesRelaEN.UpdDate, 20, conge_StuBatchQuesRela.UpdDate);
clsCheckSql.CheckFieldLen(objge_StuBatchQuesRelaEN.UpdUserId, 20, conge_StuBatchQuesRela.UpdUserId);
clsCheckSql.CheckFieldLen(objge_StuBatchQuesRelaEN.Memo, 1000, conge_StuBatchQuesRela.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objge_StuBatchQuesRelaEN.IdCurrEduCls, 8, conge_StuBatchQuesRela.IdCurrEduCls);
 objge_StuBatchQuesRelaEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objge_StuBatchQuesRelaEN.ExamBatchNo, 20, conge_StuBatchQuesRela.ExamBatchNo);
clsCheckSql.CheckFieldLen(objge_StuBatchQuesRelaEN.UserId, 18, conge_StuBatchQuesRela.UserId);
clsCheckSql.CheckFieldLen(objge_StuBatchQuesRelaEN.IdCurrEduCls, 8, conge_StuBatchQuesRela.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objge_StuBatchQuesRelaEN.GameLevelId, 8, conge_StuBatchQuesRela.GameLevelId);
clsCheckSql.CheckFieldLen(objge_StuBatchQuesRelaEN.AnswerDate, 8, conge_StuBatchQuesRela.AnswerDate);
clsCheckSql.CheckFieldLen(objge_StuBatchQuesRelaEN.AnswerIP, 30, conge_StuBatchQuesRela.AnswerIP);
clsCheckSql.CheckFieldLen(objge_StuBatchQuesRelaEN.AnswerModeId, 4, conge_StuBatchQuesRela.AnswerModeId);
clsCheckSql.CheckFieldLen(objge_StuBatchQuesRelaEN.AnswerMultiOptions, 300, conge_StuBatchQuesRela.AnswerMultiOptions);
clsCheckSql.CheckFieldLen(objge_StuBatchQuesRelaEN.AnswerOptionId, 8, conge_StuBatchQuesRela.AnswerOptionId);
clsCheckSql.CheckFieldLen(objge_StuBatchQuesRelaEN.AnswerTime, 10, conge_StuBatchQuesRela.AnswerTime);
clsCheckSql.CheckFieldLen(objge_StuBatchQuesRelaEN.ApplySendBackDate, 14, conge_StuBatchQuesRela.ApplySendBackDate);
clsCheckSql.CheckFieldLen(objge_StuBatchQuesRelaEN.MarkDate, 14, conge_StuBatchQuesRela.MarkDate);
clsCheckSql.CheckFieldLen(objge_StuBatchQuesRelaEN.MarkerId, 20, conge_StuBatchQuesRela.MarkerId);
clsCheckSql.CheckFieldLen(objge_StuBatchQuesRelaEN.OperateTime, 14, conge_StuBatchQuesRela.OperateTime);
clsCheckSql.CheckFieldLen(objge_StuBatchQuesRelaEN.RealFinishDate, 14, conge_StuBatchQuesRela.RealFinishDate);
clsCheckSql.CheckFieldLen(objge_StuBatchQuesRelaEN.WorkTypeId, 2, conge_StuBatchQuesRela.WorkTypeId);
clsCheckSql.CheckFieldLen(objge_StuBatchQuesRelaEN.SchoolYear, 10, conge_StuBatchQuesRela.SchoolYear);
clsCheckSql.CheckFieldLen(objge_StuBatchQuesRelaEN.SchoolTerm, 1, conge_StuBatchQuesRela.SchoolTerm);
clsCheckSql.CheckFieldLen(objge_StuBatchQuesRelaEN.ErrMsg, 200, conge_StuBatchQuesRela.ErrMsg);
clsCheckSql.CheckFieldLen(objge_StuBatchQuesRelaEN.CourseId, 8, conge_StuBatchQuesRela.CourseId);
clsCheckSql.CheckFieldLen(objge_StuBatchQuesRelaEN.UpdDate, 20, conge_StuBatchQuesRela.UpdDate);
clsCheckSql.CheckFieldLen(objge_StuBatchQuesRelaEN.UpdUserId, 20, conge_StuBatchQuesRela.UpdUserId);
clsCheckSql.CheckFieldLen(objge_StuBatchQuesRelaEN.Memo, 1000, conge_StuBatchQuesRela.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objge_StuBatchQuesRelaEN.IdCurrEduCls, 8, conge_StuBatchQuesRela.IdCurrEduCls);
 objge_StuBatchQuesRelaEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objge_StuBatchQuesRelaEN.ExamBatchNo, 20, conge_StuBatchQuesRela.ExamBatchNo);
clsCheckSql.CheckFieldLen(objge_StuBatchQuesRelaEN.UserId, 18, conge_StuBatchQuesRela.UserId);
clsCheckSql.CheckFieldLen(objge_StuBatchQuesRelaEN.IdCurrEduCls, 8, conge_StuBatchQuesRela.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objge_StuBatchQuesRelaEN.GameLevelId, 8, conge_StuBatchQuesRela.GameLevelId);
clsCheckSql.CheckFieldLen(objge_StuBatchQuesRelaEN.AnswerDate, 8, conge_StuBatchQuesRela.AnswerDate);
clsCheckSql.CheckFieldLen(objge_StuBatchQuesRelaEN.AnswerIP, 30, conge_StuBatchQuesRela.AnswerIP);
clsCheckSql.CheckFieldLen(objge_StuBatchQuesRelaEN.AnswerModeId, 4, conge_StuBatchQuesRela.AnswerModeId);
clsCheckSql.CheckFieldLen(objge_StuBatchQuesRelaEN.AnswerMultiOptions, 300, conge_StuBatchQuesRela.AnswerMultiOptions);
clsCheckSql.CheckFieldLen(objge_StuBatchQuesRelaEN.AnswerOptionId, 8, conge_StuBatchQuesRela.AnswerOptionId);
clsCheckSql.CheckFieldLen(objge_StuBatchQuesRelaEN.AnswerTime, 10, conge_StuBatchQuesRela.AnswerTime);
clsCheckSql.CheckFieldLen(objge_StuBatchQuesRelaEN.ApplySendBackDate, 14, conge_StuBatchQuesRela.ApplySendBackDate);
clsCheckSql.CheckFieldLen(objge_StuBatchQuesRelaEN.MarkDate, 14, conge_StuBatchQuesRela.MarkDate);
clsCheckSql.CheckFieldLen(objge_StuBatchQuesRelaEN.MarkerId, 20, conge_StuBatchQuesRela.MarkerId);
clsCheckSql.CheckFieldLen(objge_StuBatchQuesRelaEN.OperateTime, 14, conge_StuBatchQuesRela.OperateTime);
clsCheckSql.CheckFieldLen(objge_StuBatchQuesRelaEN.RealFinishDate, 14, conge_StuBatchQuesRela.RealFinishDate);
clsCheckSql.CheckFieldLen(objge_StuBatchQuesRelaEN.WorkTypeId, 2, conge_StuBatchQuesRela.WorkTypeId);
clsCheckSql.CheckFieldLen(objge_StuBatchQuesRelaEN.SchoolYear, 10, conge_StuBatchQuesRela.SchoolYear);
clsCheckSql.CheckFieldLen(objge_StuBatchQuesRelaEN.SchoolTerm, 1, conge_StuBatchQuesRela.SchoolTerm);
clsCheckSql.CheckFieldLen(objge_StuBatchQuesRelaEN.ErrMsg, 200, conge_StuBatchQuesRela.ErrMsg);
clsCheckSql.CheckFieldLen(objge_StuBatchQuesRelaEN.CourseId, 8, conge_StuBatchQuesRela.CourseId);
clsCheckSql.CheckFieldLen(objge_StuBatchQuesRelaEN.UpdDate, 20, conge_StuBatchQuesRela.UpdDate);
clsCheckSql.CheckFieldLen(objge_StuBatchQuesRelaEN.UpdUserId, 20, conge_StuBatchQuesRela.UpdUserId);
clsCheckSql.CheckFieldLen(objge_StuBatchQuesRelaEN.Memo, 1000, conge_StuBatchQuesRela.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objge_StuBatchQuesRelaEN.ExamBatchNo, conge_StuBatchQuesRela.ExamBatchNo);
clsCheckSql.CheckSqlInjection4Field(objge_StuBatchQuesRelaEN.UserId, conge_StuBatchQuesRela.UserId);
clsCheckSql.CheckSqlInjection4Field(objge_StuBatchQuesRelaEN.IdCurrEduCls, conge_StuBatchQuesRela.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objge_StuBatchQuesRelaEN.GameLevelId, conge_StuBatchQuesRela.GameLevelId);
clsCheckSql.CheckSqlInjection4Field(objge_StuBatchQuesRelaEN.AnswerDate, conge_StuBatchQuesRela.AnswerDate);
clsCheckSql.CheckSqlInjection4Field(objge_StuBatchQuesRelaEN.AnswerIP, conge_StuBatchQuesRela.AnswerIP);
clsCheckSql.CheckSqlInjection4Field(objge_StuBatchQuesRelaEN.AnswerModeId, conge_StuBatchQuesRela.AnswerModeId);
clsCheckSql.CheckSqlInjection4Field(objge_StuBatchQuesRelaEN.AnswerMultiOptions, conge_StuBatchQuesRela.AnswerMultiOptions);
clsCheckSql.CheckSqlInjection4Field(objge_StuBatchQuesRelaEN.AnswerOptionId, conge_StuBatchQuesRela.AnswerOptionId);
clsCheckSql.CheckSqlInjection4Field(objge_StuBatchQuesRelaEN.AnswerTime, conge_StuBatchQuesRela.AnswerTime);
clsCheckSql.CheckSqlInjection4Field(objge_StuBatchQuesRelaEN.ApplySendBackDate, conge_StuBatchQuesRela.ApplySendBackDate);
clsCheckSql.CheckSqlInjection4Field(objge_StuBatchQuesRelaEN.MarkDate, conge_StuBatchQuesRela.MarkDate);
clsCheckSql.CheckSqlInjection4Field(objge_StuBatchQuesRelaEN.MarkerId, conge_StuBatchQuesRela.MarkerId);
clsCheckSql.CheckSqlInjection4Field(objge_StuBatchQuesRelaEN.OperateTime, conge_StuBatchQuesRela.OperateTime);
clsCheckSql.CheckSqlInjection4Field(objge_StuBatchQuesRelaEN.RealFinishDate, conge_StuBatchQuesRela.RealFinishDate);
clsCheckSql.CheckSqlInjection4Field(objge_StuBatchQuesRelaEN.WorkTypeId, conge_StuBatchQuesRela.WorkTypeId);
clsCheckSql.CheckSqlInjection4Field(objge_StuBatchQuesRelaEN.SchoolYear, conge_StuBatchQuesRela.SchoolYear);
clsCheckSql.CheckSqlInjection4Field(objge_StuBatchQuesRelaEN.SchoolTerm, conge_StuBatchQuesRela.SchoolTerm);
clsCheckSql.CheckSqlInjection4Field(objge_StuBatchQuesRelaEN.ErrMsg, conge_StuBatchQuesRela.ErrMsg);
clsCheckSql.CheckSqlInjection4Field(objge_StuBatchQuesRelaEN.CourseId, conge_StuBatchQuesRela.CourseId);
clsCheckSql.CheckSqlInjection4Field(objge_StuBatchQuesRelaEN.UpdDate, conge_StuBatchQuesRela.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objge_StuBatchQuesRelaEN.UpdUserId, conge_StuBatchQuesRela.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objge_StuBatchQuesRelaEN.Memo, conge_StuBatchQuesRela.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objge_StuBatchQuesRelaEN.IdCurrEduCls, 8, conge_StuBatchQuesRela.IdCurrEduCls);
 objge_StuBatchQuesRelaEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--ge_StuBatchQuesRela(学生批次题目关系),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objge_StuBatchQuesRelaEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ExamBatchNo = '{0}'", objge_StuBatchQuesRelaEN.ExamBatchNo);
 sbCondition.AppendFormat(" and UserId = '{0}'", objge_StuBatchQuesRelaEN.UserId);
 sbCondition.AppendFormat(" and QuestionId = '{0}'", objge_StuBatchQuesRelaEN.QuestionId);
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
 objSQL = clsge_StuBatchQuesRelaDA.GetSpecSQLObj();
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
 objSQL = clsge_StuBatchQuesRelaDA.GetSpecSQLObj();
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
 objSQL = clsge_StuBatchQuesRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsge_StuBatchQuesRelaEN._CurrTabName);
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
 objSQL = clsge_StuBatchQuesRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsge_StuBatchQuesRelaEN._CurrTabName, strCondition);
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
 objSQL = clsge_StuBatchQuesRelaDA.GetSpecSQLObj();
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
 objSQL = clsge_StuBatchQuesRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}