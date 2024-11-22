
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsAnswerDA
 表名:Answer(01120002)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 05:59:59
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:问卷维护(QuestionaireEdit)
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
 /// 答案(Answer)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsAnswerDA : clsCommBase4DA
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
 return clsAnswerEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsAnswerEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsAnswerEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsAnswerEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsAnswerEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsAnswerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAnswerDA.GetSpecSQLObj();
strSQL = "Select * from Answer where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_Answer(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsAnswerDA: GetDataTable_Answer)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAnswerDA.GetSpecSQLObj();
strSQL = "Select * from Answer where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsAnswerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAnswerDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsAnswerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAnswerDA.GetSpecSQLObj();
strSQL = "Select * from Answer where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsAnswerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAnswerDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsAnswerDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAnswerDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from Answer where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from Answer where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsAnswerDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAnswerDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from Answer where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsAnswerDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAnswerDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} Answer.* from Answer Left Join {1} on {2} where {3} and Answer.AnswerId not in (Select top {5} Answer.AnswerId from Answer Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from Answer where {1} and AnswerId not in (Select top {2} AnswerId from Answer where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from Answer where {1} and AnswerId not in (Select top {3} AnswerId from Answer where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsAnswerDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAnswerDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} Answer.* from Answer Left Join {1} on {2} where {3} and Answer.AnswerId not in (Select top {5} Answer.AnswerId from Answer Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from Answer where {1} and AnswerId not in (Select top {2} AnswerId from Answer where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from Answer where {1} and AnswerId not in (Select top {3} AnswerId from Answer where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsAnswerEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsAnswerDA:GetObjLst)", objException.Message));
}
List<clsAnswerEN> arrObjLst = new List<clsAnswerEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAnswerDA.GetSpecSQLObj();
strSQL = "Select * from Answer where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAnswerEN objAnswerEN = new clsAnswerEN();
try
{
objAnswerEN.AnswerId = TransNullToInt(objRow[conAnswer.AnswerId].ToString().Trim()); //问答ID
objAnswerEN.QuestionId = TransNullToInt(objRow[conAnswer.QuestionId].ToString().Trim()); //题目Id
objAnswerEN.AnswerIndex = TransNullToInt(objRow[conAnswer.AnswerIndex].ToString().Trim()); //问答序号
objAnswerEN.AnswerOptionId = objRow[conAnswer.AnswerOptionId] == DBNull.Value ? null : objRow[conAnswer.AnswerOptionId].ToString().Trim(); //回答选项Id
objAnswerEN.AnswerMultiOptions = objRow[conAnswer.AnswerMultiOptions] == DBNull.Value ? null : objRow[conAnswer.AnswerMultiOptions].ToString().Trim(); //多选项答案
objAnswerEN.AnswerFillInBlank = objRow[conAnswer.AnswerFillInBlank] == DBNull.Value ? null : objRow[conAnswer.AnswerFillInBlank].ToString().Trim(); //填空题答案
objAnswerEN.AnswerTrueOrFalse = TransNullToBool(objRow[conAnswer.AnswerTrueOrFalse].ToString().Trim()); //判断题答案
objAnswerEN.AnswerContent = objRow[conAnswer.AnswerContent] == DBNull.Value ? null : objRow[conAnswer.AnswerContent].ToString().Trim(); //答案内容
objAnswerEN.IsAutoCorrect = TransNullToBool(objRow[conAnswer.IsAutoCorrect].ToString().Trim()); //是否支持自动批改
objAnswerEN.Provider = objRow[conAnswer.Provider] == DBNull.Value ? null : objRow[conAnswer.Provider].ToString().Trim(); //提供者
objAnswerEN.Score = TransNullToDouble(objRow[conAnswer.Score].ToString().Trim()); //得分
objAnswerEN.IsShow = TransNullToBool(objRow[conAnswer.IsShow].ToString().Trim()); //是否启用
objAnswerEN.CourseId = objRow[conAnswer.CourseId].ToString().Trim(); //课程Id
objAnswerEN.UpdDate = objRow[conAnswer.UpdDate].ToString().Trim(); //修改日期
objAnswerEN.UpdUser = objRow[conAnswer.UpdUser].ToString().Trim(); //修改人
objAnswerEN.Memo = objRow[conAnswer.Memo] == DBNull.Value ? null : objRow[conAnswer.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsAnswerDA: GetObjLst)", objException.Message));
}
objAnswerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objAnswerEN);
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
public List<clsAnswerEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsAnswerDA:GetObjLstByTabName)", objException.Message));
}
List<clsAnswerEN> arrObjLst = new List<clsAnswerEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAnswerDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAnswerEN objAnswerEN = new clsAnswerEN();
try
{
objAnswerEN.AnswerId = TransNullToInt(objRow[conAnswer.AnswerId].ToString().Trim()); //问答ID
objAnswerEN.QuestionId = TransNullToInt(objRow[conAnswer.QuestionId].ToString().Trim()); //题目Id
objAnswerEN.AnswerIndex = TransNullToInt(objRow[conAnswer.AnswerIndex].ToString().Trim()); //问答序号
objAnswerEN.AnswerOptionId = objRow[conAnswer.AnswerOptionId] == DBNull.Value ? null : objRow[conAnswer.AnswerOptionId].ToString().Trim(); //回答选项Id
objAnswerEN.AnswerMultiOptions = objRow[conAnswer.AnswerMultiOptions] == DBNull.Value ? null : objRow[conAnswer.AnswerMultiOptions].ToString().Trim(); //多选项答案
objAnswerEN.AnswerFillInBlank = objRow[conAnswer.AnswerFillInBlank] == DBNull.Value ? null : objRow[conAnswer.AnswerFillInBlank].ToString().Trim(); //填空题答案
objAnswerEN.AnswerTrueOrFalse = TransNullToBool(objRow[conAnswer.AnswerTrueOrFalse].ToString().Trim()); //判断题答案
objAnswerEN.AnswerContent = objRow[conAnswer.AnswerContent] == DBNull.Value ? null : objRow[conAnswer.AnswerContent].ToString().Trim(); //答案内容
objAnswerEN.IsAutoCorrect = TransNullToBool(objRow[conAnswer.IsAutoCorrect].ToString().Trim()); //是否支持自动批改
objAnswerEN.Provider = objRow[conAnswer.Provider] == DBNull.Value ? null : objRow[conAnswer.Provider].ToString().Trim(); //提供者
objAnswerEN.Score = TransNullToDouble(objRow[conAnswer.Score].ToString().Trim()); //得分
objAnswerEN.IsShow = TransNullToBool(objRow[conAnswer.IsShow].ToString().Trim()); //是否启用
objAnswerEN.CourseId = objRow[conAnswer.CourseId].ToString().Trim(); //课程Id
objAnswerEN.UpdDate = objRow[conAnswer.UpdDate].ToString().Trim(); //修改日期
objAnswerEN.UpdUser = objRow[conAnswer.UpdUser].ToString().Trim(); //修改人
objAnswerEN.Memo = objRow[conAnswer.Memo] == DBNull.Value ? null : objRow[conAnswer.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsAnswerDA: GetObjLst)", objException.Message));
}
objAnswerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objAnswerEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objAnswerEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetAnswer(ref clsAnswerEN objAnswerEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAnswerDA.GetSpecSQLObj();
strSQL = "Select * from Answer where AnswerId = " + ""+ objAnswerEN.AnswerId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objAnswerEN.AnswerId = TransNullToInt(objDT.Rows[0][conAnswer.AnswerId].ToString().Trim()); //问答ID(字段类型:bigint,字段长度:8,是否可空:True)
 objAnswerEN.QuestionId = TransNullToInt(objDT.Rows[0][conAnswer.QuestionId].ToString().Trim()); //题目Id(字段类型:bigint,字段长度:8,是否可空:True)
 objAnswerEN.AnswerIndex = TransNullToInt(objDT.Rows[0][conAnswer.AnswerIndex].ToString().Trim()); //问答序号(字段类型:int,字段长度:4,是否可空:True)
 objAnswerEN.AnswerOptionId = objDT.Rows[0][conAnswer.AnswerOptionId].ToString().Trim(); //回答选项Id(字段类型:char,字段长度:8,是否可空:True)
 objAnswerEN.AnswerMultiOptions = objDT.Rows[0][conAnswer.AnswerMultiOptions].ToString().Trim(); //多选项答案(字段类型:varchar,字段长度:300,是否可空:True)
 objAnswerEN.AnswerFillInBlank = objDT.Rows[0][conAnswer.AnswerFillInBlank].ToString().Trim(); //填空题答案(字段类型:varchar,字段长度:1000,是否可空:True)
 objAnswerEN.AnswerTrueOrFalse = TransNullToBool(objDT.Rows[0][conAnswer.AnswerTrueOrFalse].ToString().Trim()); //判断题答案(字段类型:bit,字段长度:1,是否可空:True)
 objAnswerEN.AnswerContent = objDT.Rows[0][conAnswer.AnswerContent].ToString().Trim(); //答案内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objAnswerEN.IsAutoCorrect = TransNullToBool(objDT.Rows[0][conAnswer.IsAutoCorrect].ToString().Trim()); //是否支持自动批改(字段类型:bit,字段长度:1,是否可空:True)
 objAnswerEN.Provider = objDT.Rows[0][conAnswer.Provider].ToString().Trim(); //提供者(字段类型:varchar,字段长度:18,是否可空:True)
 objAnswerEN.Score = TransNullToDouble(objDT.Rows[0][conAnswer.Score].ToString().Trim()); //得分(字段类型:decimal,字段长度:6,是否可空:True)
 objAnswerEN.IsShow = TransNullToBool(objDT.Rows[0][conAnswer.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objAnswerEN.CourseId = objDT.Rows[0][conAnswer.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objAnswerEN.UpdDate = objDT.Rows[0][conAnswer.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objAnswerEN.UpdUser = objDT.Rows[0][conAnswer.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objAnswerEN.Memo = objDT.Rows[0][conAnswer.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsAnswerDA: GetAnswer)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngAnswerId">表关键字</param>
 /// <returns>表对象</returns>
public clsAnswerEN GetObjByAnswerId(long lngAnswerId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAnswerDA.GetSpecSQLObj();
strSQL = "Select * from Answer where AnswerId = " + ""+ lngAnswerId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsAnswerEN objAnswerEN = new clsAnswerEN();
try
{
 objAnswerEN.AnswerId = Int32.Parse(objRow[conAnswer.AnswerId].ToString().Trim()); //问答ID(字段类型:bigint,字段长度:8,是否可空:True)
 objAnswerEN.QuestionId = Int32.Parse(objRow[conAnswer.QuestionId].ToString().Trim()); //题目Id(字段类型:bigint,字段长度:8,是否可空:True)
 objAnswerEN.AnswerIndex = Int32.Parse(objRow[conAnswer.AnswerIndex].ToString().Trim()); //问答序号(字段类型:int,字段长度:4,是否可空:True)
 objAnswerEN.AnswerOptionId = objRow[conAnswer.AnswerOptionId] == DBNull.Value ? null : objRow[conAnswer.AnswerOptionId].ToString().Trim(); //回答选项Id(字段类型:char,字段长度:8,是否可空:True)
 objAnswerEN.AnswerMultiOptions = objRow[conAnswer.AnswerMultiOptions] == DBNull.Value ? null : objRow[conAnswer.AnswerMultiOptions].ToString().Trim(); //多选项答案(字段类型:varchar,字段长度:300,是否可空:True)
 objAnswerEN.AnswerFillInBlank = objRow[conAnswer.AnswerFillInBlank] == DBNull.Value ? null : objRow[conAnswer.AnswerFillInBlank].ToString().Trim(); //填空题答案(字段类型:varchar,字段长度:1000,是否可空:True)
 objAnswerEN.AnswerTrueOrFalse = clsEntityBase2.TransNullToBool_S(objRow[conAnswer.AnswerTrueOrFalse].ToString().Trim()); //判断题答案(字段类型:bit,字段长度:1,是否可空:True)
 objAnswerEN.AnswerContent = objRow[conAnswer.AnswerContent] == DBNull.Value ? null : objRow[conAnswer.AnswerContent].ToString().Trim(); //答案内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objAnswerEN.IsAutoCorrect = clsEntityBase2.TransNullToBool_S(objRow[conAnswer.IsAutoCorrect].ToString().Trim()); //是否支持自动批改(字段类型:bit,字段长度:1,是否可空:True)
 objAnswerEN.Provider = objRow[conAnswer.Provider] == DBNull.Value ? null : objRow[conAnswer.Provider].ToString().Trim(); //提供者(字段类型:varchar,字段长度:18,是否可空:True)
 objAnswerEN.Score = Double.Parse(objRow[conAnswer.Score].ToString().Trim()); //得分(字段类型:decimal,字段长度:6,是否可空:True)
 objAnswerEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conAnswer.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objAnswerEN.CourseId = objRow[conAnswer.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objAnswerEN.UpdDate = objRow[conAnswer.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objAnswerEN.UpdUser = objRow[conAnswer.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objAnswerEN.Memo = objRow[conAnswer.Memo] == DBNull.Value ? null : objRow[conAnswer.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsAnswerDA: GetObjByAnswerId)", objException.Message));
}
return objAnswerEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsAnswerEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsAnswerDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAnswerDA.GetSpecSQLObj();
strSQL = "Select * from Answer where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsAnswerEN objAnswerEN = new clsAnswerEN()
{
AnswerId = TransNullToInt(objRow[conAnswer.AnswerId].ToString().Trim()), //问答ID
QuestionId = TransNullToInt(objRow[conAnswer.QuestionId].ToString().Trim()), //题目Id
AnswerIndex = TransNullToInt(objRow[conAnswer.AnswerIndex].ToString().Trim()), //问答序号
AnswerOptionId = objRow[conAnswer.AnswerOptionId] == DBNull.Value ? null : objRow[conAnswer.AnswerOptionId].ToString().Trim(), //回答选项Id
AnswerMultiOptions = objRow[conAnswer.AnswerMultiOptions] == DBNull.Value ? null : objRow[conAnswer.AnswerMultiOptions].ToString().Trim(), //多选项答案
AnswerFillInBlank = objRow[conAnswer.AnswerFillInBlank] == DBNull.Value ? null : objRow[conAnswer.AnswerFillInBlank].ToString().Trim(), //填空题答案
AnswerTrueOrFalse = TransNullToBool(objRow[conAnswer.AnswerTrueOrFalse].ToString().Trim()), //判断题答案
AnswerContent = objRow[conAnswer.AnswerContent] == DBNull.Value ? null : objRow[conAnswer.AnswerContent].ToString().Trim(), //答案内容
IsAutoCorrect = TransNullToBool(objRow[conAnswer.IsAutoCorrect].ToString().Trim()), //是否支持自动批改
Provider = objRow[conAnswer.Provider] == DBNull.Value ? null : objRow[conAnswer.Provider].ToString().Trim(), //提供者
Score = TransNullToDouble(objRow[conAnswer.Score].ToString().Trim()), //得分
IsShow = TransNullToBool(objRow[conAnswer.IsShow].ToString().Trim()), //是否启用
CourseId = objRow[conAnswer.CourseId].ToString().Trim(), //课程Id
UpdDate = objRow[conAnswer.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conAnswer.UpdUser].ToString().Trim(), //修改人
Memo = objRow[conAnswer.Memo] == DBNull.Value ? null : objRow[conAnswer.Memo].ToString().Trim() //备注
};
objAnswerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objAnswerEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsAnswerDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsAnswerEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsAnswerEN objAnswerEN = new clsAnswerEN();
try
{
objAnswerEN.AnswerId = TransNullToInt(objRow[conAnswer.AnswerId].ToString().Trim()); //问答ID
objAnswerEN.QuestionId = TransNullToInt(objRow[conAnswer.QuestionId].ToString().Trim()); //题目Id
objAnswerEN.AnswerIndex = TransNullToInt(objRow[conAnswer.AnswerIndex].ToString().Trim()); //问答序号
objAnswerEN.AnswerOptionId = objRow[conAnswer.AnswerOptionId] == DBNull.Value ? null : objRow[conAnswer.AnswerOptionId].ToString().Trim(); //回答选项Id
objAnswerEN.AnswerMultiOptions = objRow[conAnswer.AnswerMultiOptions] == DBNull.Value ? null : objRow[conAnswer.AnswerMultiOptions].ToString().Trim(); //多选项答案
objAnswerEN.AnswerFillInBlank = objRow[conAnswer.AnswerFillInBlank] == DBNull.Value ? null : objRow[conAnswer.AnswerFillInBlank].ToString().Trim(); //填空题答案
objAnswerEN.AnswerTrueOrFalse = TransNullToBool(objRow[conAnswer.AnswerTrueOrFalse].ToString().Trim()); //判断题答案
objAnswerEN.AnswerContent = objRow[conAnswer.AnswerContent] == DBNull.Value ? null : objRow[conAnswer.AnswerContent].ToString().Trim(); //答案内容
objAnswerEN.IsAutoCorrect = TransNullToBool(objRow[conAnswer.IsAutoCorrect].ToString().Trim()); //是否支持自动批改
objAnswerEN.Provider = objRow[conAnswer.Provider] == DBNull.Value ? null : objRow[conAnswer.Provider].ToString().Trim(); //提供者
objAnswerEN.Score = TransNullToDouble(objRow[conAnswer.Score].ToString().Trim()); //得分
objAnswerEN.IsShow = TransNullToBool(objRow[conAnswer.IsShow].ToString().Trim()); //是否启用
objAnswerEN.CourseId = objRow[conAnswer.CourseId].ToString().Trim(); //课程Id
objAnswerEN.UpdDate = objRow[conAnswer.UpdDate].ToString().Trim(); //修改日期
objAnswerEN.UpdUser = objRow[conAnswer.UpdUser].ToString().Trim(); //修改人
objAnswerEN.Memo = objRow[conAnswer.Memo] == DBNull.Value ? null : objRow[conAnswer.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsAnswerDA: GetObjByDataRowAnswer)", objException.Message));
}
objAnswerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objAnswerEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsAnswerEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsAnswerEN objAnswerEN = new clsAnswerEN();
try
{
objAnswerEN.AnswerId = TransNullToInt(objRow[conAnswer.AnswerId].ToString().Trim()); //问答ID
objAnswerEN.QuestionId = TransNullToInt(objRow[conAnswer.QuestionId].ToString().Trim()); //题目Id
objAnswerEN.AnswerIndex = TransNullToInt(objRow[conAnswer.AnswerIndex].ToString().Trim()); //问答序号
objAnswerEN.AnswerOptionId = objRow[conAnswer.AnswerOptionId] == DBNull.Value ? null : objRow[conAnswer.AnswerOptionId].ToString().Trim(); //回答选项Id
objAnswerEN.AnswerMultiOptions = objRow[conAnswer.AnswerMultiOptions] == DBNull.Value ? null : objRow[conAnswer.AnswerMultiOptions].ToString().Trim(); //多选项答案
objAnswerEN.AnswerFillInBlank = objRow[conAnswer.AnswerFillInBlank] == DBNull.Value ? null : objRow[conAnswer.AnswerFillInBlank].ToString().Trim(); //填空题答案
objAnswerEN.AnswerTrueOrFalse = TransNullToBool(objRow[conAnswer.AnswerTrueOrFalse].ToString().Trim()); //判断题答案
objAnswerEN.AnswerContent = objRow[conAnswer.AnswerContent] == DBNull.Value ? null : objRow[conAnswer.AnswerContent].ToString().Trim(); //答案内容
objAnswerEN.IsAutoCorrect = TransNullToBool(objRow[conAnswer.IsAutoCorrect].ToString().Trim()); //是否支持自动批改
objAnswerEN.Provider = objRow[conAnswer.Provider] == DBNull.Value ? null : objRow[conAnswer.Provider].ToString().Trim(); //提供者
objAnswerEN.Score = TransNullToDouble(objRow[conAnswer.Score].ToString().Trim()); //得分
objAnswerEN.IsShow = TransNullToBool(objRow[conAnswer.IsShow].ToString().Trim()); //是否启用
objAnswerEN.CourseId = objRow[conAnswer.CourseId].ToString().Trim(); //课程Id
objAnswerEN.UpdDate = objRow[conAnswer.UpdDate].ToString().Trim(); //修改日期
objAnswerEN.UpdUser = objRow[conAnswer.UpdUser].ToString().Trim(); //修改人
objAnswerEN.Memo = objRow[conAnswer.Memo] == DBNull.Value ? null : objRow[conAnswer.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsAnswerDA: GetObjByDataRow)", objException.Message));
}
objAnswerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objAnswerEN;
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
objSQL = clsAnswerDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsAnswerEN._CurrTabName, conAnswer.AnswerId, 8, "");
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
objSQL = clsAnswerDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsAnswerEN._CurrTabName, conAnswer.AnswerId, 8, strPrefix);
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
 objSQL = clsAnswerDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select AnswerId from Answer where " + strCondition;
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
 objSQL = clsAnswerDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select AnswerId from Answer where " + strCondition;
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
 /// <param name = "lngAnswerId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngAnswerId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAnswerDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("Answer", "AnswerId = " + ""+ lngAnswerId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsAnswerDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAnswerDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("Answer", strCondition))
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
objSQL = clsAnswerDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("Answer");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsAnswerEN objAnswerEN)
 {
 if (objAnswerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objAnswerEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAnswerDA.GetSpecSQLObj();
strSQL = "Select * from Answer where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "Answer");
objRow = objDS.Tables["Answer"].NewRow();
objRow[conAnswer.QuestionId] = objAnswerEN.QuestionId; //题目Id
objRow[conAnswer.AnswerIndex] = objAnswerEN.AnswerIndex; //问答序号
 if (objAnswerEN.AnswerOptionId !=  "")
 {
objRow[conAnswer.AnswerOptionId] = objAnswerEN.AnswerOptionId; //回答选项Id
 }
 if (objAnswerEN.AnswerMultiOptions !=  "")
 {
objRow[conAnswer.AnswerMultiOptions] = objAnswerEN.AnswerMultiOptions; //多选项答案
 }
 if (objAnswerEN.AnswerFillInBlank !=  "")
 {
objRow[conAnswer.AnswerFillInBlank] = objAnswerEN.AnswerFillInBlank; //填空题答案
 }
objRow[conAnswer.AnswerTrueOrFalse] = objAnswerEN.AnswerTrueOrFalse; //判断题答案
 if (objAnswerEN.AnswerContent !=  "")
 {
objRow[conAnswer.AnswerContent] = objAnswerEN.AnswerContent; //答案内容
 }
objRow[conAnswer.IsAutoCorrect] = objAnswerEN.IsAutoCorrect; //是否支持自动批改
 if (objAnswerEN.Provider !=  "")
 {
objRow[conAnswer.Provider] = objAnswerEN.Provider; //提供者
 }
objRow[conAnswer.Score] = objAnswerEN.Score; //得分
objRow[conAnswer.IsShow] = objAnswerEN.IsShow; //是否启用
objRow[conAnswer.CourseId] = objAnswerEN.CourseId; //课程Id
objRow[conAnswer.UpdDate] = objAnswerEN.UpdDate; //修改日期
objRow[conAnswer.UpdUser] = objAnswerEN.UpdUser; //修改人
 if (objAnswerEN.Memo !=  "")
 {
objRow[conAnswer.Memo] = objAnswerEN.Memo; //备注
 }
objDS.Tables[clsAnswerEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsAnswerEN._CurrTabName);
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
 /// <param name = "objAnswerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsAnswerEN objAnswerEN)
{
 if (objAnswerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objAnswerEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 arrFieldListForInsert.Add(conAnswer.QuestionId);
 arrValueListForInsert.Add(objAnswerEN.QuestionId.ToString());
 
 arrFieldListForInsert.Add(conAnswer.AnswerIndex);
 arrValueListForInsert.Add(objAnswerEN.AnswerIndex.ToString());
 
 if (objAnswerEN.AnswerOptionId !=  null)
 {
 arrFieldListForInsert.Add(conAnswer.AnswerOptionId);
 var strAnswerOptionId = objAnswerEN.AnswerOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerOptionId + "'");
 }
 
 if (objAnswerEN.AnswerMultiOptions !=  null)
 {
 arrFieldListForInsert.Add(conAnswer.AnswerMultiOptions);
 var strAnswerMultiOptions = objAnswerEN.AnswerMultiOptions.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerMultiOptions + "'");
 }
 
 if (objAnswerEN.AnswerFillInBlank !=  null)
 {
 arrFieldListForInsert.Add(conAnswer.AnswerFillInBlank);
 var strAnswerFillInBlank = objAnswerEN.AnswerFillInBlank.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerFillInBlank + "'");
 }
 
 arrFieldListForInsert.Add(conAnswer.AnswerTrueOrFalse);
 arrValueListForInsert.Add("'" + (objAnswerEN.AnswerTrueOrFalse  ==  false ? "0" : "1") + "'");
 
 if (objAnswerEN.AnswerContent !=  null)
 {
 arrFieldListForInsert.Add(conAnswer.AnswerContent);
 var strAnswerContent = objAnswerEN.AnswerContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerContent + "'");
 }
 
 arrFieldListForInsert.Add(conAnswer.IsAutoCorrect);
 arrValueListForInsert.Add("'" + (objAnswerEN.IsAutoCorrect  ==  false ? "0" : "1") + "'");
 
 if (objAnswerEN.Provider !=  null)
 {
 arrFieldListForInsert.Add(conAnswer.Provider);
 var strProvider = objAnswerEN.Provider.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProvider + "'");
 }
 
 arrFieldListForInsert.Add(conAnswer.Score);
 arrValueListForInsert.Add(objAnswerEN.Score.ToString());
 
 arrFieldListForInsert.Add(conAnswer.IsShow);
 arrValueListForInsert.Add("'" + (objAnswerEN.IsShow  ==  false ? "0" : "1") + "'");
 
 if (objAnswerEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conAnswer.CourseId);
 var strCourseId = objAnswerEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objAnswerEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conAnswer.UpdDate);
 var strUpdDate = objAnswerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objAnswerEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conAnswer.UpdUser);
 var strUpdUser = objAnswerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objAnswerEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conAnswer.Memo);
 var strMemo = objAnswerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Answer");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAnswerDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objAnswerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsAnswerEN objAnswerEN)
{
 if (objAnswerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objAnswerEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 arrFieldListForInsert.Add(conAnswer.QuestionId);
 arrValueListForInsert.Add(objAnswerEN.QuestionId.ToString());
 
 arrFieldListForInsert.Add(conAnswer.AnswerIndex);
 arrValueListForInsert.Add(objAnswerEN.AnswerIndex.ToString());
 
 if (objAnswerEN.AnswerOptionId !=  null)
 {
 arrFieldListForInsert.Add(conAnswer.AnswerOptionId);
 var strAnswerOptionId = objAnswerEN.AnswerOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerOptionId + "'");
 }
 
 if (objAnswerEN.AnswerMultiOptions !=  null)
 {
 arrFieldListForInsert.Add(conAnswer.AnswerMultiOptions);
 var strAnswerMultiOptions = objAnswerEN.AnswerMultiOptions.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerMultiOptions + "'");
 }
 
 if (objAnswerEN.AnswerFillInBlank !=  null)
 {
 arrFieldListForInsert.Add(conAnswer.AnswerFillInBlank);
 var strAnswerFillInBlank = objAnswerEN.AnswerFillInBlank.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerFillInBlank + "'");
 }
 
 arrFieldListForInsert.Add(conAnswer.AnswerTrueOrFalse);
 arrValueListForInsert.Add("'" + (objAnswerEN.AnswerTrueOrFalse  ==  false ? "0" : "1") + "'");
 
 if (objAnswerEN.AnswerContent !=  null)
 {
 arrFieldListForInsert.Add(conAnswer.AnswerContent);
 var strAnswerContent = objAnswerEN.AnswerContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerContent + "'");
 }
 
 arrFieldListForInsert.Add(conAnswer.IsAutoCorrect);
 arrValueListForInsert.Add("'" + (objAnswerEN.IsAutoCorrect  ==  false ? "0" : "1") + "'");
 
 if (objAnswerEN.Provider !=  null)
 {
 arrFieldListForInsert.Add(conAnswer.Provider);
 var strProvider = objAnswerEN.Provider.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProvider + "'");
 }
 
 arrFieldListForInsert.Add(conAnswer.Score);
 arrValueListForInsert.Add(objAnswerEN.Score.ToString());
 
 arrFieldListForInsert.Add(conAnswer.IsShow);
 arrValueListForInsert.Add("'" + (objAnswerEN.IsShow  ==  false ? "0" : "1") + "'");
 
 if (objAnswerEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conAnswer.CourseId);
 var strCourseId = objAnswerEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objAnswerEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conAnswer.UpdDate);
 var strUpdDate = objAnswerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objAnswerEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conAnswer.UpdUser);
 var strUpdUser = objAnswerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objAnswerEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conAnswer.Memo);
 var strMemo = objAnswerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Answer");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAnswerDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objAnswerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsAnswerEN objAnswerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objAnswerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objAnswerEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 arrFieldListForInsert.Add(conAnswer.QuestionId);
 arrValueListForInsert.Add(objAnswerEN.QuestionId.ToString());
 
 arrFieldListForInsert.Add(conAnswer.AnswerIndex);
 arrValueListForInsert.Add(objAnswerEN.AnswerIndex.ToString());
 
 if (objAnswerEN.AnswerOptionId !=  null)
 {
 arrFieldListForInsert.Add(conAnswer.AnswerOptionId);
 var strAnswerOptionId = objAnswerEN.AnswerOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerOptionId + "'");
 }
 
 if (objAnswerEN.AnswerMultiOptions !=  null)
 {
 arrFieldListForInsert.Add(conAnswer.AnswerMultiOptions);
 var strAnswerMultiOptions = objAnswerEN.AnswerMultiOptions.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerMultiOptions + "'");
 }
 
 if (objAnswerEN.AnswerFillInBlank !=  null)
 {
 arrFieldListForInsert.Add(conAnswer.AnswerFillInBlank);
 var strAnswerFillInBlank = objAnswerEN.AnswerFillInBlank.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerFillInBlank + "'");
 }
 
 arrFieldListForInsert.Add(conAnswer.AnswerTrueOrFalse);
 arrValueListForInsert.Add("'" + (objAnswerEN.AnswerTrueOrFalse  ==  false ? "0" : "1") + "'");
 
 if (objAnswerEN.AnswerContent !=  null)
 {
 arrFieldListForInsert.Add(conAnswer.AnswerContent);
 var strAnswerContent = objAnswerEN.AnswerContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerContent + "'");
 }
 
 arrFieldListForInsert.Add(conAnswer.IsAutoCorrect);
 arrValueListForInsert.Add("'" + (objAnswerEN.IsAutoCorrect  ==  false ? "0" : "1") + "'");
 
 if (objAnswerEN.Provider !=  null)
 {
 arrFieldListForInsert.Add(conAnswer.Provider);
 var strProvider = objAnswerEN.Provider.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProvider + "'");
 }
 
 arrFieldListForInsert.Add(conAnswer.Score);
 arrValueListForInsert.Add(objAnswerEN.Score.ToString());
 
 arrFieldListForInsert.Add(conAnswer.IsShow);
 arrValueListForInsert.Add("'" + (objAnswerEN.IsShow  ==  false ? "0" : "1") + "'");
 
 if (objAnswerEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conAnswer.CourseId);
 var strCourseId = objAnswerEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objAnswerEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conAnswer.UpdDate);
 var strUpdDate = objAnswerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objAnswerEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conAnswer.UpdUser);
 var strUpdUser = objAnswerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objAnswerEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conAnswer.Memo);
 var strMemo = objAnswerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Answer");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAnswerDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objAnswerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsAnswerEN objAnswerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objAnswerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objAnswerEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 arrFieldListForInsert.Add(conAnswer.QuestionId);
 arrValueListForInsert.Add(objAnswerEN.QuestionId.ToString());
 
 arrFieldListForInsert.Add(conAnswer.AnswerIndex);
 arrValueListForInsert.Add(objAnswerEN.AnswerIndex.ToString());
 
 if (objAnswerEN.AnswerOptionId !=  null)
 {
 arrFieldListForInsert.Add(conAnswer.AnswerOptionId);
 var strAnswerOptionId = objAnswerEN.AnswerOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerOptionId + "'");
 }
 
 if (objAnswerEN.AnswerMultiOptions !=  null)
 {
 arrFieldListForInsert.Add(conAnswer.AnswerMultiOptions);
 var strAnswerMultiOptions = objAnswerEN.AnswerMultiOptions.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerMultiOptions + "'");
 }
 
 if (objAnswerEN.AnswerFillInBlank !=  null)
 {
 arrFieldListForInsert.Add(conAnswer.AnswerFillInBlank);
 var strAnswerFillInBlank = objAnswerEN.AnswerFillInBlank.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerFillInBlank + "'");
 }
 
 arrFieldListForInsert.Add(conAnswer.AnswerTrueOrFalse);
 arrValueListForInsert.Add("'" + (objAnswerEN.AnswerTrueOrFalse  ==  false ? "0" : "1") + "'");
 
 if (objAnswerEN.AnswerContent !=  null)
 {
 arrFieldListForInsert.Add(conAnswer.AnswerContent);
 var strAnswerContent = objAnswerEN.AnswerContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerContent + "'");
 }
 
 arrFieldListForInsert.Add(conAnswer.IsAutoCorrect);
 arrValueListForInsert.Add("'" + (objAnswerEN.IsAutoCorrect  ==  false ? "0" : "1") + "'");
 
 if (objAnswerEN.Provider !=  null)
 {
 arrFieldListForInsert.Add(conAnswer.Provider);
 var strProvider = objAnswerEN.Provider.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProvider + "'");
 }
 
 arrFieldListForInsert.Add(conAnswer.Score);
 arrValueListForInsert.Add(objAnswerEN.Score.ToString());
 
 arrFieldListForInsert.Add(conAnswer.IsShow);
 arrValueListForInsert.Add("'" + (objAnswerEN.IsShow  ==  false ? "0" : "1") + "'");
 
 if (objAnswerEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conAnswer.CourseId);
 var strCourseId = objAnswerEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objAnswerEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conAnswer.UpdDate);
 var strUpdDate = objAnswerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objAnswerEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conAnswer.UpdUser);
 var strUpdUser = objAnswerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objAnswerEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conAnswer.Memo);
 var strMemo = objAnswerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Answer");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAnswerDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewAnswers(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAnswerDA.GetSpecSQLObj();
strSQL = "Select * from Answer where AnswerId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "Answer");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngAnswerId = TransNullToInt(oRow[conAnswer.AnswerId].ToString().Trim());
if (IsExist(lngAnswerId))
{
 string strResult = "关键字变量值为:" + string.Format("AnswerId = {0}", lngAnswerId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsAnswerEN._CurrTabName ].NewRow();
objRow[conAnswer.QuestionId] = oRow[conAnswer.QuestionId].ToString().Trim(); //题目Id
objRow[conAnswer.AnswerIndex] = oRow[conAnswer.AnswerIndex].ToString().Trim(); //问答序号
objRow[conAnswer.AnswerOptionId] = oRow[conAnswer.AnswerOptionId].ToString().Trim(); //回答选项Id
objRow[conAnswer.AnswerMultiOptions] = oRow[conAnswer.AnswerMultiOptions].ToString().Trim(); //多选项答案
objRow[conAnswer.AnswerFillInBlank] = oRow[conAnswer.AnswerFillInBlank].ToString().Trim(); //填空题答案
objRow[conAnswer.AnswerTrueOrFalse] = oRow[conAnswer.AnswerTrueOrFalse].ToString().Trim(); //判断题答案
objRow[conAnswer.AnswerContent] = oRow[conAnswer.AnswerContent].ToString().Trim(); //答案内容
objRow[conAnswer.IsAutoCorrect] = oRow[conAnswer.IsAutoCorrect].ToString().Trim(); //是否支持自动批改
objRow[conAnswer.Provider] = oRow[conAnswer.Provider].ToString().Trim(); //提供者
objRow[conAnswer.Score] = oRow[conAnswer.Score].ToString().Trim(); //得分
objRow[conAnswer.IsShow] = oRow[conAnswer.IsShow].ToString().Trim(); //是否启用
objRow[conAnswer.CourseId] = oRow[conAnswer.CourseId].ToString().Trim(); //课程Id
objRow[conAnswer.UpdDate] = oRow[conAnswer.UpdDate].ToString().Trim(); //修改日期
objRow[conAnswer.UpdUser] = oRow[conAnswer.UpdUser].ToString().Trim(); //修改人
objRow[conAnswer.Memo] = oRow[conAnswer.Memo].ToString().Trim(); //备注
 objDS.Tables[clsAnswerEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsAnswerEN._CurrTabName);
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
 /// <param name = "objAnswerEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsAnswerEN objAnswerEN)
{
 if (objAnswerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objAnswerEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAnswerDA.GetSpecSQLObj();
strSQL = "Select * from Answer where AnswerId = " + ""+ objAnswerEN.AnswerId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsAnswerEN._CurrTabName);
if (objDS.Tables[clsAnswerEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:AnswerId = " + ""+ objAnswerEN.AnswerId+"");
return false;
}
objRow = objDS.Tables[clsAnswerEN._CurrTabName].Rows[0];
 if (objAnswerEN.IsUpdated(conAnswer.QuestionId))
 {
objRow[conAnswer.QuestionId] = objAnswerEN.QuestionId; //题目Id
 }
 if (objAnswerEN.IsUpdated(conAnswer.AnswerIndex))
 {
objRow[conAnswer.AnswerIndex] = objAnswerEN.AnswerIndex; //问答序号
 }
 if (objAnswerEN.IsUpdated(conAnswer.AnswerOptionId))
 {
objRow[conAnswer.AnswerOptionId] = objAnswerEN.AnswerOptionId; //回答选项Id
 }
 if (objAnswerEN.IsUpdated(conAnswer.AnswerMultiOptions))
 {
objRow[conAnswer.AnswerMultiOptions] = objAnswerEN.AnswerMultiOptions; //多选项答案
 }
 if (objAnswerEN.IsUpdated(conAnswer.AnswerFillInBlank))
 {
objRow[conAnswer.AnswerFillInBlank] = objAnswerEN.AnswerFillInBlank; //填空题答案
 }
 if (objAnswerEN.IsUpdated(conAnswer.AnswerTrueOrFalse))
 {
objRow[conAnswer.AnswerTrueOrFalse] = objAnswerEN.AnswerTrueOrFalse; //判断题答案
 }
 if (objAnswerEN.IsUpdated(conAnswer.AnswerContent))
 {
objRow[conAnswer.AnswerContent] = objAnswerEN.AnswerContent; //答案内容
 }
 if (objAnswerEN.IsUpdated(conAnswer.IsAutoCorrect))
 {
objRow[conAnswer.IsAutoCorrect] = objAnswerEN.IsAutoCorrect; //是否支持自动批改
 }
 if (objAnswerEN.IsUpdated(conAnswer.Provider))
 {
objRow[conAnswer.Provider] = objAnswerEN.Provider; //提供者
 }
 if (objAnswerEN.IsUpdated(conAnswer.Score))
 {
objRow[conAnswer.Score] = objAnswerEN.Score; //得分
 }
 if (objAnswerEN.IsUpdated(conAnswer.IsShow))
 {
objRow[conAnswer.IsShow] = objAnswerEN.IsShow; //是否启用
 }
 if (objAnswerEN.IsUpdated(conAnswer.CourseId))
 {
objRow[conAnswer.CourseId] = objAnswerEN.CourseId; //课程Id
 }
 if (objAnswerEN.IsUpdated(conAnswer.UpdDate))
 {
objRow[conAnswer.UpdDate] = objAnswerEN.UpdDate; //修改日期
 }
 if (objAnswerEN.IsUpdated(conAnswer.UpdUser))
 {
objRow[conAnswer.UpdUser] = objAnswerEN.UpdUser; //修改人
 }
 if (objAnswerEN.IsUpdated(conAnswer.Memo))
 {
objRow[conAnswer.Memo] = objAnswerEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsAnswerEN._CurrTabName);
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
 /// <param name = "objAnswerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsAnswerEN objAnswerEN)
{
 if (objAnswerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objAnswerEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAnswerDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update Answer Set ");
 
 if (objAnswerEN.IsUpdated(conAnswer.QuestionId))
 {
 sbSQL.AppendFormat("{1} = {0},",objAnswerEN.QuestionId, conAnswer.QuestionId); //题目Id
 }
 
 if (objAnswerEN.IsUpdated(conAnswer.AnswerIndex))
 {
 sbSQL.AppendFormat("{1} = {0},",objAnswerEN.AnswerIndex, conAnswer.AnswerIndex); //问答序号
 }
 
 if (objAnswerEN.IsUpdated(conAnswer.AnswerOptionId))
 {
 if (objAnswerEN.AnswerOptionId !=  null)
 {
 var strAnswerOptionId = objAnswerEN.AnswerOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerOptionId, conAnswer.AnswerOptionId); //回答选项Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAnswer.AnswerOptionId); //回答选项Id
 }
 }
 
 if (objAnswerEN.IsUpdated(conAnswer.AnswerMultiOptions))
 {
 if (objAnswerEN.AnswerMultiOptions !=  null)
 {
 var strAnswerMultiOptions = objAnswerEN.AnswerMultiOptions.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerMultiOptions, conAnswer.AnswerMultiOptions); //多选项答案
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAnswer.AnswerMultiOptions); //多选项答案
 }
 }
 
 if (objAnswerEN.IsUpdated(conAnswer.AnswerFillInBlank))
 {
 if (objAnswerEN.AnswerFillInBlank !=  null)
 {
 var strAnswerFillInBlank = objAnswerEN.AnswerFillInBlank.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerFillInBlank, conAnswer.AnswerFillInBlank); //填空题答案
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAnswer.AnswerFillInBlank); //填空题答案
 }
 }
 
 if (objAnswerEN.IsUpdated(conAnswer.AnswerTrueOrFalse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objAnswerEN.AnswerTrueOrFalse == true?"1":"0", conAnswer.AnswerTrueOrFalse); //判断题答案
 }
 
 if (objAnswerEN.IsUpdated(conAnswer.AnswerContent))
 {
 if (objAnswerEN.AnswerContent !=  null)
 {
 var strAnswerContent = objAnswerEN.AnswerContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerContent, conAnswer.AnswerContent); //答案内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAnswer.AnswerContent); //答案内容
 }
 }
 
 if (objAnswerEN.IsUpdated(conAnswer.IsAutoCorrect))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objAnswerEN.IsAutoCorrect == true?"1":"0", conAnswer.IsAutoCorrect); //是否支持自动批改
 }
 
 if (objAnswerEN.IsUpdated(conAnswer.Provider))
 {
 if (objAnswerEN.Provider !=  null)
 {
 var strProvider = objAnswerEN.Provider.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProvider, conAnswer.Provider); //提供者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAnswer.Provider); //提供者
 }
 }
 
 if (objAnswerEN.IsUpdated(conAnswer.Score))
 {
 sbSQL.AppendFormat("{1} = {0},",objAnswerEN.Score, conAnswer.Score); //得分
 }
 
 if (objAnswerEN.IsUpdated(conAnswer.IsShow))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objAnswerEN.IsShow == true?"1":"0", conAnswer.IsShow); //是否启用
 }
 
 if (objAnswerEN.IsUpdated(conAnswer.CourseId))
 {
 if (objAnswerEN.CourseId !=  null)
 {
 var strCourseId = objAnswerEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, conAnswer.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAnswer.CourseId); //课程Id
 }
 }
 
 if (objAnswerEN.IsUpdated(conAnswer.UpdDate))
 {
 if (objAnswerEN.UpdDate !=  null)
 {
 var strUpdDate = objAnswerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conAnswer.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAnswer.UpdDate); //修改日期
 }
 }
 
 if (objAnswerEN.IsUpdated(conAnswer.UpdUser))
 {
 if (objAnswerEN.UpdUser !=  null)
 {
 var strUpdUser = objAnswerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conAnswer.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAnswer.UpdUser); //修改人
 }
 }
 
 if (objAnswerEN.IsUpdated(conAnswer.Memo))
 {
 if (objAnswerEN.Memo !=  null)
 {
 var strMemo = objAnswerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conAnswer.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAnswer.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where AnswerId = {0}", objAnswerEN.AnswerId); 
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
 /// <param name = "objAnswerEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsAnswerEN objAnswerEN, string strCondition)
{
 if (objAnswerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objAnswerEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAnswerDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update Answer Set ");
 
 if (objAnswerEN.IsUpdated(conAnswer.QuestionId))
 {
 sbSQL.AppendFormat(" QuestionId = {0},", objAnswerEN.QuestionId); //题目Id
 }
 
 if (objAnswerEN.IsUpdated(conAnswer.AnswerIndex))
 {
 sbSQL.AppendFormat(" AnswerIndex = {0},", objAnswerEN.AnswerIndex); //问答序号
 }
 
 if (objAnswerEN.IsUpdated(conAnswer.AnswerOptionId))
 {
 if (objAnswerEN.AnswerOptionId !=  null)
 {
 var strAnswerOptionId = objAnswerEN.AnswerOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerOptionId = '{0}',", strAnswerOptionId); //回答选项Id
 }
 else
 {
 sbSQL.Append(" AnswerOptionId = null,"); //回答选项Id
 }
 }
 
 if (objAnswerEN.IsUpdated(conAnswer.AnswerMultiOptions))
 {
 if (objAnswerEN.AnswerMultiOptions !=  null)
 {
 var strAnswerMultiOptions = objAnswerEN.AnswerMultiOptions.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerMultiOptions = '{0}',", strAnswerMultiOptions); //多选项答案
 }
 else
 {
 sbSQL.Append(" AnswerMultiOptions = null,"); //多选项答案
 }
 }
 
 if (objAnswerEN.IsUpdated(conAnswer.AnswerFillInBlank))
 {
 if (objAnswerEN.AnswerFillInBlank !=  null)
 {
 var strAnswerFillInBlank = objAnswerEN.AnswerFillInBlank.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerFillInBlank = '{0}',", strAnswerFillInBlank); //填空题答案
 }
 else
 {
 sbSQL.Append(" AnswerFillInBlank = null,"); //填空题答案
 }
 }
 
 if (objAnswerEN.IsUpdated(conAnswer.AnswerTrueOrFalse))
 {
 sbSQL.AppendFormat(" AnswerTrueOrFalse = '{0}',", objAnswerEN.AnswerTrueOrFalse == true?"1":"0"); //判断题答案
 }
 
 if (objAnswerEN.IsUpdated(conAnswer.AnswerContent))
 {
 if (objAnswerEN.AnswerContent !=  null)
 {
 var strAnswerContent = objAnswerEN.AnswerContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerContent = '{0}',", strAnswerContent); //答案内容
 }
 else
 {
 sbSQL.Append(" AnswerContent = null,"); //答案内容
 }
 }
 
 if (objAnswerEN.IsUpdated(conAnswer.IsAutoCorrect))
 {
 sbSQL.AppendFormat(" IsAutoCorrect = '{0}',", objAnswerEN.IsAutoCorrect == true?"1":"0"); //是否支持自动批改
 }
 
 if (objAnswerEN.IsUpdated(conAnswer.Provider))
 {
 if (objAnswerEN.Provider !=  null)
 {
 var strProvider = objAnswerEN.Provider.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Provider = '{0}',", strProvider); //提供者
 }
 else
 {
 sbSQL.Append(" Provider = null,"); //提供者
 }
 }
 
 if (objAnswerEN.IsUpdated(conAnswer.Score))
 {
 sbSQL.AppendFormat(" Score = {0},", objAnswerEN.Score); //得分
 }
 
 if (objAnswerEN.IsUpdated(conAnswer.IsShow))
 {
 sbSQL.AppendFormat(" IsShow = '{0}',", objAnswerEN.IsShow == true?"1":"0"); //是否启用
 }
 
 if (objAnswerEN.IsUpdated(conAnswer.CourseId))
 {
 if (objAnswerEN.CourseId !=  null)
 {
 var strCourseId = objAnswerEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objAnswerEN.IsUpdated(conAnswer.UpdDate))
 {
 if (objAnswerEN.UpdDate !=  null)
 {
 var strUpdDate = objAnswerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objAnswerEN.IsUpdated(conAnswer.UpdUser))
 {
 if (objAnswerEN.UpdUser !=  null)
 {
 var strUpdUser = objAnswerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objAnswerEN.IsUpdated(conAnswer.Memo))
 {
 if (objAnswerEN.Memo !=  null)
 {
 var strMemo = objAnswerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objAnswerEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsAnswerEN objAnswerEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objAnswerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objAnswerEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAnswerDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update Answer Set ");
 
 if (objAnswerEN.IsUpdated(conAnswer.QuestionId))
 {
 sbSQL.AppendFormat(" QuestionId = {0},", objAnswerEN.QuestionId); //题目Id
 }
 
 if (objAnswerEN.IsUpdated(conAnswer.AnswerIndex))
 {
 sbSQL.AppendFormat(" AnswerIndex = {0},", objAnswerEN.AnswerIndex); //问答序号
 }
 
 if (objAnswerEN.IsUpdated(conAnswer.AnswerOptionId))
 {
 if (objAnswerEN.AnswerOptionId !=  null)
 {
 var strAnswerOptionId = objAnswerEN.AnswerOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerOptionId = '{0}',", strAnswerOptionId); //回答选项Id
 }
 else
 {
 sbSQL.Append(" AnswerOptionId = null,"); //回答选项Id
 }
 }
 
 if (objAnswerEN.IsUpdated(conAnswer.AnswerMultiOptions))
 {
 if (objAnswerEN.AnswerMultiOptions !=  null)
 {
 var strAnswerMultiOptions = objAnswerEN.AnswerMultiOptions.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerMultiOptions = '{0}',", strAnswerMultiOptions); //多选项答案
 }
 else
 {
 sbSQL.Append(" AnswerMultiOptions = null,"); //多选项答案
 }
 }
 
 if (objAnswerEN.IsUpdated(conAnswer.AnswerFillInBlank))
 {
 if (objAnswerEN.AnswerFillInBlank !=  null)
 {
 var strAnswerFillInBlank = objAnswerEN.AnswerFillInBlank.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerFillInBlank = '{0}',", strAnswerFillInBlank); //填空题答案
 }
 else
 {
 sbSQL.Append(" AnswerFillInBlank = null,"); //填空题答案
 }
 }
 
 if (objAnswerEN.IsUpdated(conAnswer.AnswerTrueOrFalse))
 {
 sbSQL.AppendFormat(" AnswerTrueOrFalse = '{0}',", objAnswerEN.AnswerTrueOrFalse == true?"1":"0"); //判断题答案
 }
 
 if (objAnswerEN.IsUpdated(conAnswer.AnswerContent))
 {
 if (objAnswerEN.AnswerContent !=  null)
 {
 var strAnswerContent = objAnswerEN.AnswerContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerContent = '{0}',", strAnswerContent); //答案内容
 }
 else
 {
 sbSQL.Append(" AnswerContent = null,"); //答案内容
 }
 }
 
 if (objAnswerEN.IsUpdated(conAnswer.IsAutoCorrect))
 {
 sbSQL.AppendFormat(" IsAutoCorrect = '{0}',", objAnswerEN.IsAutoCorrect == true?"1":"0"); //是否支持自动批改
 }
 
 if (objAnswerEN.IsUpdated(conAnswer.Provider))
 {
 if (objAnswerEN.Provider !=  null)
 {
 var strProvider = objAnswerEN.Provider.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Provider = '{0}',", strProvider); //提供者
 }
 else
 {
 sbSQL.Append(" Provider = null,"); //提供者
 }
 }
 
 if (objAnswerEN.IsUpdated(conAnswer.Score))
 {
 sbSQL.AppendFormat(" Score = {0},", objAnswerEN.Score); //得分
 }
 
 if (objAnswerEN.IsUpdated(conAnswer.IsShow))
 {
 sbSQL.AppendFormat(" IsShow = '{0}',", objAnswerEN.IsShow == true?"1":"0"); //是否启用
 }
 
 if (objAnswerEN.IsUpdated(conAnswer.CourseId))
 {
 if (objAnswerEN.CourseId !=  null)
 {
 var strCourseId = objAnswerEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objAnswerEN.IsUpdated(conAnswer.UpdDate))
 {
 if (objAnswerEN.UpdDate !=  null)
 {
 var strUpdDate = objAnswerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objAnswerEN.IsUpdated(conAnswer.UpdUser))
 {
 if (objAnswerEN.UpdUser !=  null)
 {
 var strUpdUser = objAnswerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objAnswerEN.IsUpdated(conAnswer.Memo))
 {
 if (objAnswerEN.Memo !=  null)
 {
 var strMemo = objAnswerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objAnswerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsAnswerEN objAnswerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objAnswerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objAnswerEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAnswerDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update Answer Set ");
 
 if (objAnswerEN.IsUpdated(conAnswer.QuestionId))
 {
 sbSQL.AppendFormat("{1} = {0},",objAnswerEN.QuestionId, conAnswer.QuestionId); //题目Id
 }
 
 if (objAnswerEN.IsUpdated(conAnswer.AnswerIndex))
 {
 sbSQL.AppendFormat("{1} = {0},",objAnswerEN.AnswerIndex, conAnswer.AnswerIndex); //问答序号
 }
 
 if (objAnswerEN.IsUpdated(conAnswer.AnswerOptionId))
 {
 if (objAnswerEN.AnswerOptionId !=  null)
 {
 var strAnswerOptionId = objAnswerEN.AnswerOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerOptionId, conAnswer.AnswerOptionId); //回答选项Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAnswer.AnswerOptionId); //回答选项Id
 }
 }
 
 if (objAnswerEN.IsUpdated(conAnswer.AnswerMultiOptions))
 {
 if (objAnswerEN.AnswerMultiOptions !=  null)
 {
 var strAnswerMultiOptions = objAnswerEN.AnswerMultiOptions.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerMultiOptions, conAnswer.AnswerMultiOptions); //多选项答案
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAnswer.AnswerMultiOptions); //多选项答案
 }
 }
 
 if (objAnswerEN.IsUpdated(conAnswer.AnswerFillInBlank))
 {
 if (objAnswerEN.AnswerFillInBlank !=  null)
 {
 var strAnswerFillInBlank = objAnswerEN.AnswerFillInBlank.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerFillInBlank, conAnswer.AnswerFillInBlank); //填空题答案
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAnswer.AnswerFillInBlank); //填空题答案
 }
 }
 
 if (objAnswerEN.IsUpdated(conAnswer.AnswerTrueOrFalse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objAnswerEN.AnswerTrueOrFalse == true?"1":"0", conAnswer.AnswerTrueOrFalse); //判断题答案
 }
 
 if (objAnswerEN.IsUpdated(conAnswer.AnswerContent))
 {
 if (objAnswerEN.AnswerContent !=  null)
 {
 var strAnswerContent = objAnswerEN.AnswerContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerContent, conAnswer.AnswerContent); //答案内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAnswer.AnswerContent); //答案内容
 }
 }
 
 if (objAnswerEN.IsUpdated(conAnswer.IsAutoCorrect))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objAnswerEN.IsAutoCorrect == true?"1":"0", conAnswer.IsAutoCorrect); //是否支持自动批改
 }
 
 if (objAnswerEN.IsUpdated(conAnswer.Provider))
 {
 if (objAnswerEN.Provider !=  null)
 {
 var strProvider = objAnswerEN.Provider.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProvider, conAnswer.Provider); //提供者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAnswer.Provider); //提供者
 }
 }
 
 if (objAnswerEN.IsUpdated(conAnswer.Score))
 {
 sbSQL.AppendFormat("{1} = {0},",objAnswerEN.Score, conAnswer.Score); //得分
 }
 
 if (objAnswerEN.IsUpdated(conAnswer.IsShow))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objAnswerEN.IsShow == true?"1":"0", conAnswer.IsShow); //是否启用
 }
 
 if (objAnswerEN.IsUpdated(conAnswer.CourseId))
 {
 if (objAnswerEN.CourseId !=  null)
 {
 var strCourseId = objAnswerEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, conAnswer.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAnswer.CourseId); //课程Id
 }
 }
 
 if (objAnswerEN.IsUpdated(conAnswer.UpdDate))
 {
 if (objAnswerEN.UpdDate !=  null)
 {
 var strUpdDate = objAnswerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conAnswer.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAnswer.UpdDate); //修改日期
 }
 }
 
 if (objAnswerEN.IsUpdated(conAnswer.UpdUser))
 {
 if (objAnswerEN.UpdUser !=  null)
 {
 var strUpdUser = objAnswerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conAnswer.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAnswer.UpdUser); //修改人
 }
 }
 
 if (objAnswerEN.IsUpdated(conAnswer.Memo))
 {
 if (objAnswerEN.Memo !=  null)
 {
 var strMemo = objAnswerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conAnswer.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAnswer.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where AnswerId = {0}", objAnswerEN.AnswerId); 
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
 /// <param name = "lngAnswerId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngAnswerId) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAnswerDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngAnswerId,
};
 objSQL.ExecSP("Answer_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngAnswerId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngAnswerId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAnswerDA.GetSpecSQLObj();
//删除Answer本表中与当前对象有关的记录
strSQL = strSQL + "Delete from Answer where AnswerId = " + ""+ lngAnswerId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelAnswer(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAnswerDA.GetSpecSQLObj();
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
//删除Answer本表中与当前对象有关的记录
strSQL = strSQL + "Delete from Answer where AnswerId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngAnswerId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngAnswerId) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAnswerDA.GetSpecSQLObj();
//删除Answer本表中与当前对象有关的记录
strSQL = strSQL + "Delete from Answer where AnswerId = " + ""+ lngAnswerId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelAnswer(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsAnswerDA: DelAnswer)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAnswerDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from Answer where " + strCondition ;
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
public bool DelAnswerWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsAnswerDA: DelAnswerWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAnswerDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from Answer where " + strCondition ;
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
 /// <param name = "objAnswerENS">源对象</param>
 /// <param name = "objAnswerENT">目标对象</param>
public void CopyTo(clsAnswerEN objAnswerENS, clsAnswerEN objAnswerENT)
{
objAnswerENT.AnswerId = objAnswerENS.AnswerId; //问答ID
objAnswerENT.QuestionId = objAnswerENS.QuestionId; //题目Id
objAnswerENT.AnswerIndex = objAnswerENS.AnswerIndex; //问答序号
objAnswerENT.AnswerOptionId = objAnswerENS.AnswerOptionId; //回答选项Id
objAnswerENT.AnswerMultiOptions = objAnswerENS.AnswerMultiOptions; //多选项答案
objAnswerENT.AnswerFillInBlank = objAnswerENS.AnswerFillInBlank; //填空题答案
objAnswerENT.AnswerTrueOrFalse = objAnswerENS.AnswerTrueOrFalse; //判断题答案
objAnswerENT.AnswerContent = objAnswerENS.AnswerContent; //答案内容
objAnswerENT.IsAutoCorrect = objAnswerENS.IsAutoCorrect; //是否支持自动批改
objAnswerENT.Provider = objAnswerENS.Provider; //提供者
objAnswerENT.Score = objAnswerENS.Score; //得分
objAnswerENT.IsShow = objAnswerENS.IsShow; //是否启用
objAnswerENT.CourseId = objAnswerENS.CourseId; //课程Id
objAnswerENT.UpdDate = objAnswerENS.UpdDate; //修改日期
objAnswerENT.UpdUser = objAnswerENS.UpdUser; //修改人
objAnswerENT.Memo = objAnswerENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsAnswerEN objAnswerEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objAnswerEN.QuestionId, conAnswer.QuestionId);
clsCheckSql.CheckFieldNotNull(objAnswerEN.AnswerIndex, conAnswer.AnswerIndex);
clsCheckSql.CheckFieldNotNull(objAnswerEN.Score, conAnswer.Score);
clsCheckSql.CheckFieldNotNull(objAnswerEN.CourseId, conAnswer.CourseId);
clsCheckSql.CheckFieldNotNull(objAnswerEN.UpdDate, conAnswer.UpdDate);
clsCheckSql.CheckFieldNotNull(objAnswerEN.UpdUser, conAnswer.UpdUser);
//检查字段长度
clsCheckSql.CheckFieldLen(objAnswerEN.AnswerOptionId, 8, conAnswer.AnswerOptionId);
clsCheckSql.CheckFieldLen(objAnswerEN.AnswerMultiOptions, 300, conAnswer.AnswerMultiOptions);
clsCheckSql.CheckFieldLen(objAnswerEN.AnswerFillInBlank, 1000, conAnswer.AnswerFillInBlank);
clsCheckSql.CheckFieldLen(objAnswerEN.AnswerContent, 8000, conAnswer.AnswerContent);
clsCheckSql.CheckFieldLen(objAnswerEN.Provider, 18, conAnswer.Provider);
clsCheckSql.CheckFieldLen(objAnswerEN.CourseId, 8, conAnswer.CourseId);
clsCheckSql.CheckFieldLen(objAnswerEN.UpdDate, 20, conAnswer.UpdDate);
clsCheckSql.CheckFieldLen(objAnswerEN.UpdUser, 20, conAnswer.UpdUser);
clsCheckSql.CheckFieldLen(objAnswerEN.Memo, 1000, conAnswer.Memo);
//检查字段外键固定长度
 objAnswerEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsAnswerEN objAnswerEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objAnswerEN.AnswerOptionId, 8, conAnswer.AnswerOptionId);
clsCheckSql.CheckFieldLen(objAnswerEN.AnswerMultiOptions, 300, conAnswer.AnswerMultiOptions);
clsCheckSql.CheckFieldLen(objAnswerEN.AnswerFillInBlank, 1000, conAnswer.AnswerFillInBlank);
clsCheckSql.CheckFieldLen(objAnswerEN.AnswerContent, 8000, conAnswer.AnswerContent);
clsCheckSql.CheckFieldLen(objAnswerEN.Provider, 18, conAnswer.Provider);
clsCheckSql.CheckFieldLen(objAnswerEN.CourseId, 8, conAnswer.CourseId);
clsCheckSql.CheckFieldLen(objAnswerEN.UpdDate, 20, conAnswer.UpdDate);
clsCheckSql.CheckFieldLen(objAnswerEN.UpdUser, 20, conAnswer.UpdUser);
clsCheckSql.CheckFieldLen(objAnswerEN.Memo, 1000, conAnswer.Memo);
//检查外键字段长度
 objAnswerEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsAnswerEN objAnswerEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objAnswerEN.AnswerOptionId, 8, conAnswer.AnswerOptionId);
clsCheckSql.CheckFieldLen(objAnswerEN.AnswerMultiOptions, 300, conAnswer.AnswerMultiOptions);
clsCheckSql.CheckFieldLen(objAnswerEN.AnswerFillInBlank, 1000, conAnswer.AnswerFillInBlank);
clsCheckSql.CheckFieldLen(objAnswerEN.AnswerContent, 8000, conAnswer.AnswerContent);
clsCheckSql.CheckFieldLen(objAnswerEN.Provider, 18, conAnswer.Provider);
clsCheckSql.CheckFieldLen(objAnswerEN.CourseId, 8, conAnswer.CourseId);
clsCheckSql.CheckFieldLen(objAnswerEN.UpdDate, 20, conAnswer.UpdDate);
clsCheckSql.CheckFieldLen(objAnswerEN.UpdUser, 20, conAnswer.UpdUser);
clsCheckSql.CheckFieldLen(objAnswerEN.Memo, 1000, conAnswer.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objAnswerEN.AnswerOptionId, conAnswer.AnswerOptionId);
clsCheckSql.CheckSqlInjection4Field(objAnswerEN.AnswerMultiOptions, conAnswer.AnswerMultiOptions);
clsCheckSql.CheckSqlInjection4Field(objAnswerEN.AnswerFillInBlank, conAnswer.AnswerFillInBlank);
clsCheckSql.CheckSqlInjection4Field(objAnswerEN.AnswerContent, conAnswer.AnswerContent);
clsCheckSql.CheckSqlInjection4Field(objAnswerEN.Provider, conAnswer.Provider);
clsCheckSql.CheckSqlInjection4Field(objAnswerEN.CourseId, conAnswer.CourseId);
clsCheckSql.CheckSqlInjection4Field(objAnswerEN.UpdDate, conAnswer.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objAnswerEN.UpdUser, conAnswer.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objAnswerEN.Memo, conAnswer.Memo);
//检查外键字段长度
 objAnswerEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--Answer(答案),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objAnswerEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsAnswerEN objAnswerEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and QuestionId = '{0}'", objAnswerEN.QuestionId);
 sbCondition.AppendFormat(" and AnswerIndex = '{0}'", objAnswerEN.AnswerIndex);
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
 objSQL = clsAnswerDA.GetSpecSQLObj();
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
 objSQL = clsAnswerDA.GetSpecSQLObj();
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
 objSQL = clsAnswerDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsAnswerEN._CurrTabName);
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
 objSQL = clsAnswerDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsAnswerEN._CurrTabName, strCondition);
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
 objSQL = clsAnswerDA.GetSpecSQLObj();
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
 objSQL = clsAnswerDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}