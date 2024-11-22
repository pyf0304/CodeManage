
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvAnswerDA
 表名:vAnswer(01120017)
 * 版本:2024.11.08.1(服务器:WIN-SRV103-116)
 日期:2024/11/09 22:30:49
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
 /// v答案(vAnswer)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvAnswerDA : clsCommBase4DA
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
 return clsvAnswerEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvAnswerEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvAnswerEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvAnswerEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvAnswerEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvAnswerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvAnswerDA.GetSpecSQLObj();
strSQL = "Select * from vAnswer where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vAnswer(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvAnswerDA: GetDataTable_vAnswer)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvAnswerDA.GetSpecSQLObj();
strSQL = "Select * from vAnswer where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvAnswerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvAnswerDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvAnswerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvAnswerDA.GetSpecSQLObj();
strSQL = "Select * from vAnswer where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvAnswerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvAnswerDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvAnswerDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvAnswerDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vAnswer where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vAnswer where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvAnswerDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvAnswerDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vAnswer where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvAnswerDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvAnswerDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vAnswer.* from vAnswer Left Join {1} on {2} where {3} and vAnswer.AnswerId not in (Select top {5} vAnswer.AnswerId from vAnswer Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vAnswer where {1} and AnswerId not in (Select top {2} AnswerId from vAnswer where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vAnswer where {1} and AnswerId not in (Select top {3} AnswerId from vAnswer where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvAnswerDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvAnswerDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vAnswer.* from vAnswer Left Join {1} on {2} where {3} and vAnswer.AnswerId not in (Select top {5} vAnswer.AnswerId from vAnswer Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vAnswer where {1} and AnswerId not in (Select top {2} AnswerId from vAnswer where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vAnswer where {1} and AnswerId not in (Select top {3} AnswerId from vAnswer where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvAnswerEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvAnswerDA:GetObjLst)", objException.Message));
}
List<clsvAnswerEN> arrObjLst = new List<clsvAnswerEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvAnswerDA.GetSpecSQLObj();
strSQL = "Select * from vAnswer where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvAnswerEN objvAnswerEN = new clsvAnswerEN();
try
{
objvAnswerEN.AnswerContent = objRow[convAnswer.AnswerContent] == DBNull.Value ? null : objRow[convAnswer.AnswerContent].ToString().Trim(); //答案内容
objvAnswerEN.AnswerId = TransNullToInt(objRow[convAnswer.AnswerId].ToString().Trim()); //问答ID
objvAnswerEN.QuestionId = objRow[convAnswer.QuestionId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convAnswer.QuestionId].ToString().Trim()); //题目Id
objvAnswerEN.QuestionName = objRow[convAnswer.QuestionName] == DBNull.Value ? null : objRow[convAnswer.QuestionName].ToString().Trim(); //题目名称
objvAnswerEN.QuestionMemo = objRow[convAnswer.QuestionMemo] == DBNull.Value ? null : objRow[convAnswer.QuestionMemo].ToString().Trim(); //题目说明
objvAnswerEN.QuestionTypeId = objRow[convAnswer.QuestionTypeId] == DBNull.Value ? null : objRow[convAnswer.QuestionTypeId].ToString().Trim(); //题目类型Id
objvAnswerEN.QuestionTypeName = objRow[convAnswer.QuestionTypeName] == DBNull.Value ? null : objRow[convAnswer.QuestionTypeName].ToString().Trim(); //题目类型名
objvAnswerEN.AnswerTypeId = objRow[convAnswer.AnswerTypeId] == DBNull.Value ? null : objRow[convAnswer.AnswerTypeId].ToString().Trim(); //答案类型ID
objvAnswerEN.AnswerTypeName = objRow[convAnswer.AnswerTypeName] == DBNull.Value ? null : objRow[convAnswer.AnswerTypeName].ToString().Trim(); //答案类型名
objvAnswerEN.GridTitle = objRow[convAnswer.GridTitle] == DBNull.Value ? null : objRow[convAnswer.GridTitle].ToString().Trim(); //表格标题
objvAnswerEN.AnswerModeId = objRow[convAnswer.AnswerModeId] == DBNull.Value ? null : objRow[convAnswer.AnswerModeId].ToString().Trim(); //答案模式Id
objvAnswerEN.QuestionScore = objRow[convAnswer.QuestionScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convAnswer.QuestionScore].ToString().Trim()); //题目得分
objvAnswerEN.AnswerIndex = objRow[convAnswer.AnswerIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convAnswer.AnswerIndex].ToString().Trim()); //问答序号
objvAnswerEN.AnswerOptionId = objRow[convAnswer.AnswerOptionId] == DBNull.Value ? null : objRow[convAnswer.AnswerOptionId].ToString().Trim(); //回答选项Id
objvAnswerEN.OptionName = objRow[convAnswer.OptionName] == DBNull.Value ? null : objRow[convAnswer.OptionName].ToString().Trim(); //选项名称
objvAnswerEN.OptionTitle = objRow[convAnswer.OptionTitle] == DBNull.Value ? null : objRow[convAnswer.OptionTitle].ToString().Trim(); //选项标题
objvAnswerEN.AnswerMultiOptions = objRow[convAnswer.AnswerMultiOptions] == DBNull.Value ? null : objRow[convAnswer.AnswerMultiOptions].ToString().Trim(); //多选项答案
objvAnswerEN.IsAutoCorrect = TransNullToBool(objRow[convAnswer.IsAutoCorrect].ToString().Trim()); //是否支持自动批改
objvAnswerEN.AnswerFillInBlank = objRow[convAnswer.AnswerFillInBlank] == DBNull.Value ? null : objRow[convAnswer.AnswerFillInBlank].ToString().Trim(); //填空题答案
objvAnswerEN.AnswerTrueOrFalse = TransNullToBool(objRow[convAnswer.AnswerTrueOrFalse].ToString().Trim()); //判断题答案
objvAnswerEN.Provider = objRow[convAnswer.Provider] == DBNull.Value ? null : objRow[convAnswer.Provider].ToString().Trim(); //提供者
objvAnswerEN.Score = objRow[convAnswer.Score] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convAnswer.Score].ToString().Trim()); //得分
objvAnswerEN.IsShow = TransNullToBool(objRow[convAnswer.IsShow].ToString().Trim()); //是否启用
objvAnswerEN.CourseId = objRow[convAnswer.CourseId] == DBNull.Value ? null : objRow[convAnswer.CourseId].ToString().Trim(); //课程Id
objvAnswerEN.UpdDate = objRow[convAnswer.UpdDate].ToString().Trim(); //修改日期
objvAnswerEN.UpdUser = objRow[convAnswer.UpdUser].ToString().Trim(); //修改人
objvAnswerEN.Memo = objRow[convAnswer.Memo] == DBNull.Value ? null : objRow[convAnswer.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvAnswerDA: GetObjLst)", objException.Message));
}
objvAnswerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvAnswerEN);
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
public List<clsvAnswerEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvAnswerDA:GetObjLstByTabName)", objException.Message));
}
List<clsvAnswerEN> arrObjLst = new List<clsvAnswerEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvAnswerDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvAnswerEN objvAnswerEN = new clsvAnswerEN();
try
{
objvAnswerEN.AnswerContent = objRow[convAnswer.AnswerContent] == DBNull.Value ? null : objRow[convAnswer.AnswerContent].ToString().Trim(); //答案内容
objvAnswerEN.AnswerId = TransNullToInt(objRow[convAnswer.AnswerId].ToString().Trim()); //问答ID
objvAnswerEN.QuestionId = objRow[convAnswer.QuestionId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convAnswer.QuestionId].ToString().Trim()); //题目Id
objvAnswerEN.QuestionName = objRow[convAnswer.QuestionName] == DBNull.Value ? null : objRow[convAnswer.QuestionName].ToString().Trim(); //题目名称
objvAnswerEN.QuestionMemo = objRow[convAnswer.QuestionMemo] == DBNull.Value ? null : objRow[convAnswer.QuestionMemo].ToString().Trim(); //题目说明
objvAnswerEN.QuestionTypeId = objRow[convAnswer.QuestionTypeId] == DBNull.Value ? null : objRow[convAnswer.QuestionTypeId].ToString().Trim(); //题目类型Id
objvAnswerEN.QuestionTypeName = objRow[convAnswer.QuestionTypeName] == DBNull.Value ? null : objRow[convAnswer.QuestionTypeName].ToString().Trim(); //题目类型名
objvAnswerEN.AnswerTypeId = objRow[convAnswer.AnswerTypeId] == DBNull.Value ? null : objRow[convAnswer.AnswerTypeId].ToString().Trim(); //答案类型ID
objvAnswerEN.AnswerTypeName = objRow[convAnswer.AnswerTypeName] == DBNull.Value ? null : objRow[convAnswer.AnswerTypeName].ToString().Trim(); //答案类型名
objvAnswerEN.GridTitle = objRow[convAnswer.GridTitle] == DBNull.Value ? null : objRow[convAnswer.GridTitle].ToString().Trim(); //表格标题
objvAnswerEN.AnswerModeId = objRow[convAnswer.AnswerModeId] == DBNull.Value ? null : objRow[convAnswer.AnswerModeId].ToString().Trim(); //答案模式Id
objvAnswerEN.QuestionScore = objRow[convAnswer.QuestionScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convAnswer.QuestionScore].ToString().Trim()); //题目得分
objvAnswerEN.AnswerIndex = objRow[convAnswer.AnswerIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convAnswer.AnswerIndex].ToString().Trim()); //问答序号
objvAnswerEN.AnswerOptionId = objRow[convAnswer.AnswerOptionId] == DBNull.Value ? null : objRow[convAnswer.AnswerOptionId].ToString().Trim(); //回答选项Id
objvAnswerEN.OptionName = objRow[convAnswer.OptionName] == DBNull.Value ? null : objRow[convAnswer.OptionName].ToString().Trim(); //选项名称
objvAnswerEN.OptionTitle = objRow[convAnswer.OptionTitle] == DBNull.Value ? null : objRow[convAnswer.OptionTitle].ToString().Trim(); //选项标题
objvAnswerEN.AnswerMultiOptions = objRow[convAnswer.AnswerMultiOptions] == DBNull.Value ? null : objRow[convAnswer.AnswerMultiOptions].ToString().Trim(); //多选项答案
objvAnswerEN.IsAutoCorrect = TransNullToBool(objRow[convAnswer.IsAutoCorrect].ToString().Trim()); //是否支持自动批改
objvAnswerEN.AnswerFillInBlank = objRow[convAnswer.AnswerFillInBlank] == DBNull.Value ? null : objRow[convAnswer.AnswerFillInBlank].ToString().Trim(); //填空题答案
objvAnswerEN.AnswerTrueOrFalse = TransNullToBool(objRow[convAnswer.AnswerTrueOrFalse].ToString().Trim()); //判断题答案
objvAnswerEN.Provider = objRow[convAnswer.Provider] == DBNull.Value ? null : objRow[convAnswer.Provider].ToString().Trim(); //提供者
objvAnswerEN.Score = objRow[convAnswer.Score] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convAnswer.Score].ToString().Trim()); //得分
objvAnswerEN.IsShow = TransNullToBool(objRow[convAnswer.IsShow].ToString().Trim()); //是否启用
objvAnswerEN.CourseId = objRow[convAnswer.CourseId] == DBNull.Value ? null : objRow[convAnswer.CourseId].ToString().Trim(); //课程Id
objvAnswerEN.UpdDate = objRow[convAnswer.UpdDate].ToString().Trim(); //修改日期
objvAnswerEN.UpdUser = objRow[convAnswer.UpdUser].ToString().Trim(); //修改人
objvAnswerEN.Memo = objRow[convAnswer.Memo] == DBNull.Value ? null : objRow[convAnswer.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvAnswerDA: GetObjLst)", objException.Message));
}
objvAnswerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvAnswerEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvAnswerEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvAnswer(ref clsvAnswerEN objvAnswerEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvAnswerDA.GetSpecSQLObj();
strSQL = "Select * from vAnswer where AnswerId = " + ""+ objvAnswerEN.AnswerId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvAnswerEN.AnswerContent = objDT.Rows[0][convAnswer.AnswerContent].ToString().Trim(); //答案内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvAnswerEN.AnswerId = TransNullToInt(objDT.Rows[0][convAnswer.AnswerId].ToString().Trim()); //问答ID(字段类型:bigint,字段长度:8,是否可空:True)
 objvAnswerEN.QuestionId = TransNullToInt(objDT.Rows[0][convAnswer.QuestionId].ToString().Trim()); //题目Id(字段类型:bigint,字段长度:8,是否可空:True)
 objvAnswerEN.QuestionName = objDT.Rows[0][convAnswer.QuestionName].ToString().Trim(); //题目名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvAnswerEN.QuestionMemo = objDT.Rows[0][convAnswer.QuestionMemo].ToString().Trim(); //题目说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvAnswerEN.QuestionTypeId = objDT.Rows[0][convAnswer.QuestionTypeId].ToString().Trim(); //题目类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvAnswerEN.QuestionTypeName = objDT.Rows[0][convAnswer.QuestionTypeName].ToString().Trim(); //题目类型名(字段类型:varchar,字段长度:20,是否可空:True)
 objvAnswerEN.AnswerTypeId = objDT.Rows[0][convAnswer.AnswerTypeId].ToString().Trim(); //答案类型ID(字段类型:char,字段长度:2,是否可空:True)
 objvAnswerEN.AnswerTypeName = objDT.Rows[0][convAnswer.AnswerTypeName].ToString().Trim(); //答案类型名(字段类型:varchar,字段长度:50,是否可空:True)
 objvAnswerEN.GridTitle = objDT.Rows[0][convAnswer.GridTitle].ToString().Trim(); //表格标题(字段类型:varchar,字段长度:30,是否可空:True)
 objvAnswerEN.AnswerModeId = objDT.Rows[0][convAnswer.AnswerModeId].ToString().Trim(); //答案模式Id(字段类型:char,字段长度:4,是否可空:True)
 objvAnswerEN.QuestionScore = TransNullToFloat(objDT.Rows[0][convAnswer.QuestionScore].ToString().Trim()); //题目得分(字段类型:float,字段长度:8,是否可空:True)
 objvAnswerEN.AnswerIndex = TransNullToInt(objDT.Rows[0][convAnswer.AnswerIndex].ToString().Trim()); //问答序号(字段类型:int,字段长度:4,是否可空:True)
 objvAnswerEN.AnswerOptionId = objDT.Rows[0][convAnswer.AnswerOptionId].ToString().Trim(); //回答选项Id(字段类型:char,字段长度:8,是否可空:True)
 objvAnswerEN.OptionName = objDT.Rows[0][convAnswer.OptionName].ToString().Trim(); //选项名称(字段类型:varchar,字段长度:4000,是否可空:False)
 objvAnswerEN.OptionTitle = objDT.Rows[0][convAnswer.OptionTitle].ToString().Trim(); //选项标题(字段类型:varchar,字段长度:20,是否可空:True)
 objvAnswerEN.AnswerMultiOptions = objDT.Rows[0][convAnswer.AnswerMultiOptions].ToString().Trim(); //多选项答案(字段类型:varchar,字段长度:300,是否可空:True)
 objvAnswerEN.IsAutoCorrect = TransNullToBool(objDT.Rows[0][convAnswer.IsAutoCorrect].ToString().Trim()); //是否支持自动批改(字段类型:bit,字段长度:1,是否可空:True)
 objvAnswerEN.AnswerFillInBlank = objDT.Rows[0][convAnswer.AnswerFillInBlank].ToString().Trim(); //填空题答案(字段类型:varchar,字段长度:1000,是否可空:True)
 objvAnswerEN.AnswerTrueOrFalse = TransNullToBool(objDT.Rows[0][convAnswer.AnswerTrueOrFalse].ToString().Trim()); //判断题答案(字段类型:bit,字段长度:1,是否可空:True)
 objvAnswerEN.Provider = objDT.Rows[0][convAnswer.Provider].ToString().Trim(); //提供者(字段类型:varchar,字段长度:18,是否可空:True)
 objvAnswerEN.Score = TransNullToDouble(objDT.Rows[0][convAnswer.Score].ToString().Trim()); //得分(字段类型:decimal,字段长度:6,是否可空:True)
 objvAnswerEN.IsShow = TransNullToBool(objDT.Rows[0][convAnswer.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objvAnswerEN.CourseId = objDT.Rows[0][convAnswer.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvAnswerEN.UpdDate = objDT.Rows[0][convAnswer.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvAnswerEN.UpdUser = objDT.Rows[0][convAnswer.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvAnswerEN.Memo = objDT.Rows[0][convAnswer.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvAnswerDA: GetvAnswer)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngAnswerId">表关键字</param>
 /// <returns>表对象</returns>
public clsvAnswerEN GetObjByAnswerId(long lngAnswerId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvAnswerDA.GetSpecSQLObj();
strSQL = "Select * from vAnswer where AnswerId = " + ""+ lngAnswerId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvAnswerEN objvAnswerEN = new clsvAnswerEN();
try
{
 objvAnswerEN.AnswerContent = objRow[convAnswer.AnswerContent] == DBNull.Value ? null : objRow[convAnswer.AnswerContent].ToString().Trim(); //答案内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvAnswerEN.AnswerId = Int32.Parse(objRow[convAnswer.AnswerId].ToString().Trim()); //问答ID(字段类型:bigint,字段长度:8,是否可空:True)
 objvAnswerEN.QuestionId = objRow[convAnswer.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convAnswer.QuestionId].ToString().Trim()); //题目Id(字段类型:bigint,字段长度:8,是否可空:True)
 objvAnswerEN.QuestionName = objRow[convAnswer.QuestionName] == DBNull.Value ? null : objRow[convAnswer.QuestionName].ToString().Trim(); //题目名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvAnswerEN.QuestionMemo = objRow[convAnswer.QuestionMemo] == DBNull.Value ? null : objRow[convAnswer.QuestionMemo].ToString().Trim(); //题目说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvAnswerEN.QuestionTypeId = objRow[convAnswer.QuestionTypeId] == DBNull.Value ? null : objRow[convAnswer.QuestionTypeId].ToString().Trim(); //题目类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvAnswerEN.QuestionTypeName = objRow[convAnswer.QuestionTypeName] == DBNull.Value ? null : objRow[convAnswer.QuestionTypeName].ToString().Trim(); //题目类型名(字段类型:varchar,字段长度:20,是否可空:True)
 objvAnswerEN.AnswerTypeId = objRow[convAnswer.AnswerTypeId] == DBNull.Value ? null : objRow[convAnswer.AnswerTypeId].ToString().Trim(); //答案类型ID(字段类型:char,字段长度:2,是否可空:True)
 objvAnswerEN.AnswerTypeName = objRow[convAnswer.AnswerTypeName] == DBNull.Value ? null : objRow[convAnswer.AnswerTypeName].ToString().Trim(); //答案类型名(字段类型:varchar,字段长度:50,是否可空:True)
 objvAnswerEN.GridTitle = objRow[convAnswer.GridTitle] == DBNull.Value ? null : objRow[convAnswer.GridTitle].ToString().Trim(); //表格标题(字段类型:varchar,字段长度:30,是否可空:True)
 objvAnswerEN.AnswerModeId = objRow[convAnswer.AnswerModeId] == DBNull.Value ? null : objRow[convAnswer.AnswerModeId].ToString().Trim(); //答案模式Id(字段类型:char,字段长度:4,是否可空:True)
 objvAnswerEN.QuestionScore = objRow[convAnswer.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convAnswer.QuestionScore].ToString().Trim()); //题目得分(字段类型:float,字段长度:8,是否可空:True)
 objvAnswerEN.AnswerIndex = objRow[convAnswer.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convAnswer.AnswerIndex].ToString().Trim()); //问答序号(字段类型:int,字段长度:4,是否可空:True)
 objvAnswerEN.AnswerOptionId = objRow[convAnswer.AnswerOptionId] == DBNull.Value ? null : objRow[convAnswer.AnswerOptionId].ToString().Trim(); //回答选项Id(字段类型:char,字段长度:8,是否可空:True)
 objvAnswerEN.OptionName = objRow[convAnswer.OptionName] == DBNull.Value ? null : objRow[convAnswer.OptionName].ToString().Trim(); //选项名称(字段类型:varchar,字段长度:4000,是否可空:False)
 objvAnswerEN.OptionTitle = objRow[convAnswer.OptionTitle] == DBNull.Value ? null : objRow[convAnswer.OptionTitle].ToString().Trim(); //选项标题(字段类型:varchar,字段长度:20,是否可空:True)
 objvAnswerEN.AnswerMultiOptions = objRow[convAnswer.AnswerMultiOptions] == DBNull.Value ? null : objRow[convAnswer.AnswerMultiOptions].ToString().Trim(); //多选项答案(字段类型:varchar,字段长度:300,是否可空:True)
 objvAnswerEN.IsAutoCorrect = clsEntityBase2.TransNullToBool_S(objRow[convAnswer.IsAutoCorrect].ToString().Trim()); //是否支持自动批改(字段类型:bit,字段长度:1,是否可空:True)
 objvAnswerEN.AnswerFillInBlank = objRow[convAnswer.AnswerFillInBlank] == DBNull.Value ? null : objRow[convAnswer.AnswerFillInBlank].ToString().Trim(); //填空题答案(字段类型:varchar,字段长度:1000,是否可空:True)
 objvAnswerEN.AnswerTrueOrFalse = clsEntityBase2.TransNullToBool_S(objRow[convAnswer.AnswerTrueOrFalse].ToString().Trim()); //判断题答案(字段类型:bit,字段长度:1,是否可空:True)
 objvAnswerEN.Provider = objRow[convAnswer.Provider] == DBNull.Value ? null : objRow[convAnswer.Provider].ToString().Trim(); //提供者(字段类型:varchar,字段长度:18,是否可空:True)
 objvAnswerEN.Score = objRow[convAnswer.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convAnswer.Score].ToString().Trim()); //得分(字段类型:decimal,字段长度:6,是否可空:True)
 objvAnswerEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convAnswer.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objvAnswerEN.CourseId = objRow[convAnswer.CourseId] == DBNull.Value ? null : objRow[convAnswer.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvAnswerEN.UpdDate = objRow[convAnswer.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvAnswerEN.UpdUser = objRow[convAnswer.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvAnswerEN.Memo = objRow[convAnswer.Memo] == DBNull.Value ? null : objRow[convAnswer.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvAnswerDA: GetObjByAnswerId)", objException.Message));
}
return objvAnswerEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvAnswerEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvAnswerDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvAnswerDA.GetSpecSQLObj();
strSQL = "Select * from vAnswer where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvAnswerEN objvAnswerEN = new clsvAnswerEN()
{
AnswerContent = objRow[convAnswer.AnswerContent] == DBNull.Value ? null : objRow[convAnswer.AnswerContent].ToString().Trim(), //答案内容
AnswerId = TransNullToInt(objRow[convAnswer.AnswerId].ToString().Trim()), //问答ID
QuestionId = objRow[convAnswer.QuestionId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convAnswer.QuestionId].ToString().Trim()), //题目Id
QuestionName = objRow[convAnswer.QuestionName] == DBNull.Value ? null : objRow[convAnswer.QuestionName].ToString().Trim(), //题目名称
QuestionMemo = objRow[convAnswer.QuestionMemo] == DBNull.Value ? null : objRow[convAnswer.QuestionMemo].ToString().Trim(), //题目说明
QuestionTypeId = objRow[convAnswer.QuestionTypeId] == DBNull.Value ? null : objRow[convAnswer.QuestionTypeId].ToString().Trim(), //题目类型Id
QuestionTypeName = objRow[convAnswer.QuestionTypeName] == DBNull.Value ? null : objRow[convAnswer.QuestionTypeName].ToString().Trim(), //题目类型名
AnswerTypeId = objRow[convAnswer.AnswerTypeId] == DBNull.Value ? null : objRow[convAnswer.AnswerTypeId].ToString().Trim(), //答案类型ID
AnswerTypeName = objRow[convAnswer.AnswerTypeName] == DBNull.Value ? null : objRow[convAnswer.AnswerTypeName].ToString().Trim(), //答案类型名
GridTitle = objRow[convAnswer.GridTitle] == DBNull.Value ? null : objRow[convAnswer.GridTitle].ToString().Trim(), //表格标题
AnswerModeId = objRow[convAnswer.AnswerModeId] == DBNull.Value ? null : objRow[convAnswer.AnswerModeId].ToString().Trim(), //答案模式Id
QuestionScore = objRow[convAnswer.QuestionScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convAnswer.QuestionScore].ToString().Trim()), //题目得分
AnswerIndex = objRow[convAnswer.AnswerIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convAnswer.AnswerIndex].ToString().Trim()), //问答序号
AnswerOptionId = objRow[convAnswer.AnswerOptionId] == DBNull.Value ? null : objRow[convAnswer.AnswerOptionId].ToString().Trim(), //回答选项Id
OptionName = objRow[convAnswer.OptionName] == DBNull.Value ? null : objRow[convAnswer.OptionName].ToString().Trim(), //选项名称
OptionTitle = objRow[convAnswer.OptionTitle] == DBNull.Value ? null : objRow[convAnswer.OptionTitle].ToString().Trim(), //选项标题
AnswerMultiOptions = objRow[convAnswer.AnswerMultiOptions] == DBNull.Value ? null : objRow[convAnswer.AnswerMultiOptions].ToString().Trim(), //多选项答案
IsAutoCorrect = TransNullToBool(objRow[convAnswer.IsAutoCorrect].ToString().Trim()), //是否支持自动批改
AnswerFillInBlank = objRow[convAnswer.AnswerFillInBlank] == DBNull.Value ? null : objRow[convAnswer.AnswerFillInBlank].ToString().Trim(), //填空题答案
AnswerTrueOrFalse = TransNullToBool(objRow[convAnswer.AnswerTrueOrFalse].ToString().Trim()), //判断题答案
Provider = objRow[convAnswer.Provider] == DBNull.Value ? null : objRow[convAnswer.Provider].ToString().Trim(), //提供者
Score = objRow[convAnswer.Score] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convAnswer.Score].ToString().Trim()), //得分
IsShow = TransNullToBool(objRow[convAnswer.IsShow].ToString().Trim()), //是否启用
CourseId = objRow[convAnswer.CourseId] == DBNull.Value ? null : objRow[convAnswer.CourseId].ToString().Trim(), //课程Id
UpdDate = objRow[convAnswer.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convAnswer.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convAnswer.Memo] == DBNull.Value ? null : objRow[convAnswer.Memo].ToString().Trim() //备注
};
objvAnswerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvAnswerEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvAnswerDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvAnswerEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvAnswerEN objvAnswerEN = new clsvAnswerEN();
try
{
objvAnswerEN.AnswerContent = objRow[convAnswer.AnswerContent] == DBNull.Value ? null : objRow[convAnswer.AnswerContent].ToString().Trim(); //答案内容
objvAnswerEN.AnswerId = TransNullToInt(objRow[convAnswer.AnswerId].ToString().Trim()); //问答ID
objvAnswerEN.QuestionId = objRow[convAnswer.QuestionId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convAnswer.QuestionId].ToString().Trim()); //题目Id
objvAnswerEN.QuestionName = objRow[convAnswer.QuestionName] == DBNull.Value ? null : objRow[convAnswer.QuestionName].ToString().Trim(); //题目名称
objvAnswerEN.QuestionMemo = objRow[convAnswer.QuestionMemo] == DBNull.Value ? null : objRow[convAnswer.QuestionMemo].ToString().Trim(); //题目说明
objvAnswerEN.QuestionTypeId = objRow[convAnswer.QuestionTypeId] == DBNull.Value ? null : objRow[convAnswer.QuestionTypeId].ToString().Trim(); //题目类型Id
objvAnswerEN.QuestionTypeName = objRow[convAnswer.QuestionTypeName] == DBNull.Value ? null : objRow[convAnswer.QuestionTypeName].ToString().Trim(); //题目类型名
objvAnswerEN.AnswerTypeId = objRow[convAnswer.AnswerTypeId] == DBNull.Value ? null : objRow[convAnswer.AnswerTypeId].ToString().Trim(); //答案类型ID
objvAnswerEN.AnswerTypeName = objRow[convAnswer.AnswerTypeName] == DBNull.Value ? null : objRow[convAnswer.AnswerTypeName].ToString().Trim(); //答案类型名
objvAnswerEN.GridTitle = objRow[convAnswer.GridTitle] == DBNull.Value ? null : objRow[convAnswer.GridTitle].ToString().Trim(); //表格标题
objvAnswerEN.AnswerModeId = objRow[convAnswer.AnswerModeId] == DBNull.Value ? null : objRow[convAnswer.AnswerModeId].ToString().Trim(); //答案模式Id
objvAnswerEN.QuestionScore = objRow[convAnswer.QuestionScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convAnswer.QuestionScore].ToString().Trim()); //题目得分
objvAnswerEN.AnswerIndex = objRow[convAnswer.AnswerIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convAnswer.AnswerIndex].ToString().Trim()); //问答序号
objvAnswerEN.AnswerOptionId = objRow[convAnswer.AnswerOptionId] == DBNull.Value ? null : objRow[convAnswer.AnswerOptionId].ToString().Trim(); //回答选项Id
objvAnswerEN.OptionName = objRow[convAnswer.OptionName] == DBNull.Value ? null : objRow[convAnswer.OptionName].ToString().Trim(); //选项名称
objvAnswerEN.OptionTitle = objRow[convAnswer.OptionTitle] == DBNull.Value ? null : objRow[convAnswer.OptionTitle].ToString().Trim(); //选项标题
objvAnswerEN.AnswerMultiOptions = objRow[convAnswer.AnswerMultiOptions] == DBNull.Value ? null : objRow[convAnswer.AnswerMultiOptions].ToString().Trim(); //多选项答案
objvAnswerEN.IsAutoCorrect = TransNullToBool(objRow[convAnswer.IsAutoCorrect].ToString().Trim()); //是否支持自动批改
objvAnswerEN.AnswerFillInBlank = objRow[convAnswer.AnswerFillInBlank] == DBNull.Value ? null : objRow[convAnswer.AnswerFillInBlank].ToString().Trim(); //填空题答案
objvAnswerEN.AnswerTrueOrFalse = TransNullToBool(objRow[convAnswer.AnswerTrueOrFalse].ToString().Trim()); //判断题答案
objvAnswerEN.Provider = objRow[convAnswer.Provider] == DBNull.Value ? null : objRow[convAnswer.Provider].ToString().Trim(); //提供者
objvAnswerEN.Score = objRow[convAnswer.Score] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convAnswer.Score].ToString().Trim()); //得分
objvAnswerEN.IsShow = TransNullToBool(objRow[convAnswer.IsShow].ToString().Trim()); //是否启用
objvAnswerEN.CourseId = objRow[convAnswer.CourseId] == DBNull.Value ? null : objRow[convAnswer.CourseId].ToString().Trim(); //课程Id
objvAnswerEN.UpdDate = objRow[convAnswer.UpdDate].ToString().Trim(); //修改日期
objvAnswerEN.UpdUser = objRow[convAnswer.UpdUser].ToString().Trim(); //修改人
objvAnswerEN.Memo = objRow[convAnswer.Memo] == DBNull.Value ? null : objRow[convAnswer.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvAnswerDA: GetObjByDataRowvAnswer)", objException.Message));
}
objvAnswerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvAnswerEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvAnswerEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvAnswerEN objvAnswerEN = new clsvAnswerEN();
try
{
objvAnswerEN.AnswerContent = objRow[convAnswer.AnswerContent] == DBNull.Value ? null : objRow[convAnswer.AnswerContent].ToString().Trim(); //答案内容
objvAnswerEN.AnswerId = TransNullToInt(objRow[convAnswer.AnswerId].ToString().Trim()); //问答ID
objvAnswerEN.QuestionId = objRow[convAnswer.QuestionId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convAnswer.QuestionId].ToString().Trim()); //题目Id
objvAnswerEN.QuestionName = objRow[convAnswer.QuestionName] == DBNull.Value ? null : objRow[convAnswer.QuestionName].ToString().Trim(); //题目名称
objvAnswerEN.QuestionMemo = objRow[convAnswer.QuestionMemo] == DBNull.Value ? null : objRow[convAnswer.QuestionMemo].ToString().Trim(); //题目说明
objvAnswerEN.QuestionTypeId = objRow[convAnswer.QuestionTypeId] == DBNull.Value ? null : objRow[convAnswer.QuestionTypeId].ToString().Trim(); //题目类型Id
objvAnswerEN.QuestionTypeName = objRow[convAnswer.QuestionTypeName] == DBNull.Value ? null : objRow[convAnswer.QuestionTypeName].ToString().Trim(); //题目类型名
objvAnswerEN.AnswerTypeId = objRow[convAnswer.AnswerTypeId] == DBNull.Value ? null : objRow[convAnswer.AnswerTypeId].ToString().Trim(); //答案类型ID
objvAnswerEN.AnswerTypeName = objRow[convAnswer.AnswerTypeName] == DBNull.Value ? null : objRow[convAnswer.AnswerTypeName].ToString().Trim(); //答案类型名
objvAnswerEN.GridTitle = objRow[convAnswer.GridTitle] == DBNull.Value ? null : objRow[convAnswer.GridTitle].ToString().Trim(); //表格标题
objvAnswerEN.AnswerModeId = objRow[convAnswer.AnswerModeId] == DBNull.Value ? null : objRow[convAnswer.AnswerModeId].ToString().Trim(); //答案模式Id
objvAnswerEN.QuestionScore = objRow[convAnswer.QuestionScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convAnswer.QuestionScore].ToString().Trim()); //题目得分
objvAnswerEN.AnswerIndex = objRow[convAnswer.AnswerIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convAnswer.AnswerIndex].ToString().Trim()); //问答序号
objvAnswerEN.AnswerOptionId = objRow[convAnswer.AnswerOptionId] == DBNull.Value ? null : objRow[convAnswer.AnswerOptionId].ToString().Trim(); //回答选项Id
objvAnswerEN.OptionName = objRow[convAnswer.OptionName] == DBNull.Value ? null : objRow[convAnswer.OptionName].ToString().Trim(); //选项名称
objvAnswerEN.OptionTitle = objRow[convAnswer.OptionTitle] == DBNull.Value ? null : objRow[convAnswer.OptionTitle].ToString().Trim(); //选项标题
objvAnswerEN.AnswerMultiOptions = objRow[convAnswer.AnswerMultiOptions] == DBNull.Value ? null : objRow[convAnswer.AnswerMultiOptions].ToString().Trim(); //多选项答案
objvAnswerEN.IsAutoCorrect = TransNullToBool(objRow[convAnswer.IsAutoCorrect].ToString().Trim()); //是否支持自动批改
objvAnswerEN.AnswerFillInBlank = objRow[convAnswer.AnswerFillInBlank] == DBNull.Value ? null : objRow[convAnswer.AnswerFillInBlank].ToString().Trim(); //填空题答案
objvAnswerEN.AnswerTrueOrFalse = TransNullToBool(objRow[convAnswer.AnswerTrueOrFalse].ToString().Trim()); //判断题答案
objvAnswerEN.Provider = objRow[convAnswer.Provider] == DBNull.Value ? null : objRow[convAnswer.Provider].ToString().Trim(); //提供者
objvAnswerEN.Score = objRow[convAnswer.Score] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convAnswer.Score].ToString().Trim()); //得分
objvAnswerEN.IsShow = TransNullToBool(objRow[convAnswer.IsShow].ToString().Trim()); //是否启用
objvAnswerEN.CourseId = objRow[convAnswer.CourseId] == DBNull.Value ? null : objRow[convAnswer.CourseId].ToString().Trim(); //课程Id
objvAnswerEN.UpdDate = objRow[convAnswer.UpdDate].ToString().Trim(); //修改日期
objvAnswerEN.UpdUser = objRow[convAnswer.UpdUser].ToString().Trim(); //修改人
objvAnswerEN.Memo = objRow[convAnswer.Memo] == DBNull.Value ? null : objRow[convAnswer.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvAnswerDA: GetObjByDataRow)", objException.Message));
}
objvAnswerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvAnswerEN;
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
objSQL = clsvAnswerDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvAnswerEN._CurrTabName, convAnswer.AnswerId, 8, "");
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
objSQL = clsvAnswerDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvAnswerEN._CurrTabName, convAnswer.AnswerId, 8, strPrefix);
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
 objSQL = clsvAnswerDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select AnswerId from vAnswer where " + strCondition;
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
 objSQL = clsvAnswerDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select AnswerId from vAnswer where " + strCondition;
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
 objSQL = clsvAnswerDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vAnswer", "AnswerId = " + ""+ lngAnswerId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvAnswerDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvAnswerDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vAnswer", strCondition))
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
objSQL = clsvAnswerDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vAnswer");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvAnswerENS">源对象</param>
 /// <param name = "objvAnswerENT">目标对象</param>
public void CopyTo(clsvAnswerEN objvAnswerENS, clsvAnswerEN objvAnswerENT)
{
objvAnswerENT.AnswerContent = objvAnswerENS.AnswerContent; //答案内容
objvAnswerENT.AnswerId = objvAnswerENS.AnswerId; //问答ID
objvAnswerENT.QuestionId = objvAnswerENS.QuestionId; //题目Id
objvAnswerENT.QuestionName = objvAnswerENS.QuestionName; //题目名称
objvAnswerENT.QuestionMemo = objvAnswerENS.QuestionMemo; //题目说明
objvAnswerENT.QuestionTypeId = objvAnswerENS.QuestionTypeId; //题目类型Id
objvAnswerENT.QuestionTypeName = objvAnswerENS.QuestionTypeName; //题目类型名
objvAnswerENT.AnswerTypeId = objvAnswerENS.AnswerTypeId; //答案类型ID
objvAnswerENT.AnswerTypeName = objvAnswerENS.AnswerTypeName; //答案类型名
objvAnswerENT.GridTitle = objvAnswerENS.GridTitle; //表格标题
objvAnswerENT.AnswerModeId = objvAnswerENS.AnswerModeId; //答案模式Id
objvAnswerENT.QuestionScore = objvAnswerENS.QuestionScore; //题目得分
objvAnswerENT.AnswerIndex = objvAnswerENS.AnswerIndex; //问答序号
objvAnswerENT.AnswerOptionId = objvAnswerENS.AnswerOptionId; //回答选项Id
objvAnswerENT.OptionName = objvAnswerENS.OptionName; //选项名称
objvAnswerENT.OptionTitle = objvAnswerENS.OptionTitle; //选项标题
objvAnswerENT.AnswerMultiOptions = objvAnswerENS.AnswerMultiOptions; //多选项答案
objvAnswerENT.IsAutoCorrect = objvAnswerENS.IsAutoCorrect; //是否支持自动批改
objvAnswerENT.AnswerFillInBlank = objvAnswerENS.AnswerFillInBlank; //填空题答案
objvAnswerENT.AnswerTrueOrFalse = objvAnswerENS.AnswerTrueOrFalse; //判断题答案
objvAnswerENT.Provider = objvAnswerENS.Provider; //提供者
objvAnswerENT.Score = objvAnswerENS.Score; //得分
objvAnswerENT.IsShow = objvAnswerENS.IsShow; //是否启用
objvAnswerENT.CourseId = objvAnswerENS.CourseId; //课程Id
objvAnswerENT.UpdDate = objvAnswerENS.UpdDate; //修改日期
objvAnswerENT.UpdUser = objvAnswerENS.UpdUser; //修改人
objvAnswerENT.Memo = objvAnswerENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvAnswerEN objvAnswerEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvAnswerEN.QuestionName, 500, convAnswer.QuestionName);
clsCheckSql.CheckFieldLen(objvAnswerEN.QuestionMemo, 1000, convAnswer.QuestionMemo);
clsCheckSql.CheckFieldLen(objvAnswerEN.QuestionTypeId, 2, convAnswer.QuestionTypeId);
clsCheckSql.CheckFieldLen(objvAnswerEN.QuestionTypeName, 20, convAnswer.QuestionTypeName);
clsCheckSql.CheckFieldLen(objvAnswerEN.AnswerTypeId, 2, convAnswer.AnswerTypeId);
clsCheckSql.CheckFieldLen(objvAnswerEN.AnswerTypeName, 50, convAnswer.AnswerTypeName);
clsCheckSql.CheckFieldLen(objvAnswerEN.GridTitle, 30, convAnswer.GridTitle);
clsCheckSql.CheckFieldLen(objvAnswerEN.AnswerModeId, 4, convAnswer.AnswerModeId);
clsCheckSql.CheckFieldLen(objvAnswerEN.AnswerOptionId, 8, convAnswer.AnswerOptionId);
clsCheckSql.CheckFieldLen(objvAnswerEN.OptionName, 4000, convAnswer.OptionName);
clsCheckSql.CheckFieldLen(objvAnswerEN.OptionTitle, 20, convAnswer.OptionTitle);
clsCheckSql.CheckFieldLen(objvAnswerEN.AnswerMultiOptions, 300, convAnswer.AnswerMultiOptions);
clsCheckSql.CheckFieldLen(objvAnswerEN.AnswerFillInBlank, 1000, convAnswer.AnswerFillInBlank);
clsCheckSql.CheckFieldLen(objvAnswerEN.Provider, 18, convAnswer.Provider);
clsCheckSql.CheckFieldLen(objvAnswerEN.CourseId, 8, convAnswer.CourseId);
clsCheckSql.CheckFieldLen(objvAnswerEN.UpdDate, 20, convAnswer.UpdDate);
clsCheckSql.CheckFieldLen(objvAnswerEN.UpdUser, 20, convAnswer.UpdUser);
clsCheckSql.CheckFieldLen(objvAnswerEN.Memo, 1000, convAnswer.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvAnswerEN.QuestionName, convAnswer.QuestionName);
clsCheckSql.CheckSqlInjection4Field(objvAnswerEN.QuestionMemo, convAnswer.QuestionMemo);
clsCheckSql.CheckSqlInjection4Field(objvAnswerEN.QuestionTypeId, convAnswer.QuestionTypeId);
clsCheckSql.CheckSqlInjection4Field(objvAnswerEN.QuestionTypeName, convAnswer.QuestionTypeName);
clsCheckSql.CheckSqlInjection4Field(objvAnswerEN.AnswerTypeId, convAnswer.AnswerTypeId);
clsCheckSql.CheckSqlInjection4Field(objvAnswerEN.AnswerTypeName, convAnswer.AnswerTypeName);
clsCheckSql.CheckSqlInjection4Field(objvAnswerEN.GridTitle, convAnswer.GridTitle);
clsCheckSql.CheckSqlInjection4Field(objvAnswerEN.AnswerModeId, convAnswer.AnswerModeId);
clsCheckSql.CheckSqlInjection4Field(objvAnswerEN.AnswerOptionId, convAnswer.AnswerOptionId);
clsCheckSql.CheckSqlInjection4Field(objvAnswerEN.OptionName, convAnswer.OptionName);
clsCheckSql.CheckSqlInjection4Field(objvAnswerEN.OptionTitle, convAnswer.OptionTitle);
clsCheckSql.CheckSqlInjection4Field(objvAnswerEN.AnswerMultiOptions, convAnswer.AnswerMultiOptions);
clsCheckSql.CheckSqlInjection4Field(objvAnswerEN.AnswerFillInBlank, convAnswer.AnswerFillInBlank);
clsCheckSql.CheckSqlInjection4Field(objvAnswerEN.Provider, convAnswer.Provider);
clsCheckSql.CheckSqlInjection4Field(objvAnswerEN.CourseId, convAnswer.CourseId);
clsCheckSql.CheckSqlInjection4Field(objvAnswerEN.UpdDate, convAnswer.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvAnswerEN.UpdUser, convAnswer.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvAnswerEN.Memo, convAnswer.Memo);
//检查外键字段长度
 objvAnswerEN._IsCheckProperty = true;
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
 objSQL = clsvAnswerDA.GetSpecSQLObj();
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
 objSQL = clsvAnswerDA.GetSpecSQLObj();
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
 objSQL = clsvAnswerDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvAnswerEN._CurrTabName);
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
 objSQL = clsvAnswerDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvAnswerEN._CurrTabName, strCondition);
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
 objSQL = clsvAnswerDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}