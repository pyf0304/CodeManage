
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsqa_AnswerDA
 表名:qa_Answer(01120641)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:08:10
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
 /// 答疑回答(qa_Answer)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsqa_AnswerDA : clsCommBase4DA
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
 return clsqa_AnswerEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsqa_AnswerEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsqa_AnswerEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsqa_AnswerEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsqa_AnswerEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strAnswerId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strAnswerId)
{
strAnswerId = strAnswerId.Replace("'", "''");
if (strAnswerId.Length > 10)
{
throw new Exception("(errid:Data000001)在表:qa_Answer中,检查关键字,长度不正确!(clsqa_AnswerDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strAnswerId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:qa_Answer中,关键字不能为空 或 null!(clsqa_AnswerDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strAnswerId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsqa_AnswerDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsqa_AnswerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_AnswerDA.GetSpecSQLObj();
strSQL = "Select * from qa_Answer where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_qa_Answer(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsqa_AnswerDA: GetDataTable_qa_Answer)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_AnswerDA.GetSpecSQLObj();
strSQL = "Select * from qa_Answer where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsqa_AnswerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_AnswerDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsqa_AnswerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_AnswerDA.GetSpecSQLObj();
strSQL = "Select * from qa_Answer where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsqa_AnswerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_AnswerDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsqa_AnswerDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_AnswerDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from qa_Answer where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from qa_Answer where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsqa_AnswerDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_AnswerDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from qa_Answer where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsqa_AnswerDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_AnswerDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} qa_Answer.* from qa_Answer Left Join {1} on {2} where {3} and qa_Answer.AnswerId not in (Select top {5} qa_Answer.AnswerId from qa_Answer Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from qa_Answer where {1} and AnswerId not in (Select top {2} AnswerId from qa_Answer where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from qa_Answer where {1} and AnswerId not in (Select top {3} AnswerId from qa_Answer where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsqa_AnswerDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_AnswerDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} qa_Answer.* from qa_Answer Left Join {1} on {2} where {3} and qa_Answer.AnswerId not in (Select top {5} qa_Answer.AnswerId from qa_Answer Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from qa_Answer where {1} and AnswerId not in (Select top {2} AnswerId from qa_Answer where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from qa_Answer where {1} and AnswerId not in (Select top {3} AnswerId from qa_Answer where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsqa_AnswerEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsqa_AnswerDA:GetObjLst)", objException.Message));
}
List<clsqa_AnswerEN> arrObjLst = new List<clsqa_AnswerEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_AnswerDA.GetSpecSQLObj();
strSQL = "Select * from qa_Answer where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsqa_AnswerEN objqa_AnswerEN = new clsqa_AnswerEN();
try
{
objqa_AnswerEN.AnswerId = objRow[conqa_Answer.AnswerId].ToString().Trim(); //回答Id
objqa_AnswerEN.QuestionsId = objRow[conqa_Answer.QuestionsId].ToString().Trim(); //提问Id
objqa_AnswerEN.AnswerContent = objRow[conqa_Answer.AnswerContent] == DBNull.Value ? null : objRow[conqa_Answer.AnswerContent].ToString().Trim(); //答案内容
objqa_AnswerEN.Score = objRow[conqa_Answer.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conqa_Answer.Score].ToString().Trim()); //评分
objqa_AnswerEN.ScoreType = objRow[conqa_Answer.ScoreType] == DBNull.Value ? null : objRow[conqa_Answer.ScoreType].ToString().Trim(); //评分类型
objqa_AnswerEN.IsRight = TransNullToBool(objRow[conqa_Answer.IsRight].ToString().Trim()); //是否正确
objqa_AnswerEN.ParentId = objRow[conqa_Answer.ParentId] == DBNull.Value ? null : objRow[conqa_Answer.ParentId].ToString().Trim(); //父节点Id
objqa_AnswerEN.VoteCount = objRow[conqa_Answer.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conqa_Answer.VoteCount].ToString().Trim()); //点赞计数
objqa_AnswerEN.IsRecommend = TransNullToBool(objRow[conqa_Answer.IsRecommend].ToString().Trim()); //是否推荐
objqa_AnswerEN.TopicId = objRow[conqa_Answer.TopicId] == DBNull.Value ? null : objRow[conqa_Answer.TopicId].ToString().Trim(); //主题Id
objqa_AnswerEN.AnswerTypeId = objRow[conqa_Answer.AnswerTypeId] == DBNull.Value ? null : objRow[conqa_Answer.AnswerTypeId].ToString().Trim(); //答案类型ID
objqa_AnswerEN.IsSubmit = TransNullToBool(objRow[conqa_Answer.IsSubmit].ToString().Trim()); //是否提交
objqa_AnswerEN.AppraiseCount = objRow[conqa_Answer.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conqa_Answer.AppraiseCount].ToString().Trim()); //评论数
objqa_AnswerEN.StuScore = objRow[conqa_Answer.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conqa_Answer.StuScore].ToString().Trim()); //学生平均分
objqa_AnswerEN.TeaScore = objRow[conqa_Answer.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conqa_Answer.TeaScore].ToString().Trim()); //教师评分
objqa_AnswerEN.CreateDate = objRow[conqa_Answer.CreateDate] == DBNull.Value ? null : objRow[conqa_Answer.CreateDate].ToString().Trim(); //建立日期
objqa_AnswerEN.IdCurrEduCls = objRow[conqa_Answer.IdCurrEduCls] == DBNull.Value ? null : objRow[conqa_Answer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objqa_AnswerEN.UpdUser = objRow[conqa_Answer.UpdUser] == DBNull.Value ? null : objRow[conqa_Answer.UpdUser].ToString().Trim(); //修改人
objqa_AnswerEN.UpdDate = objRow[conqa_Answer.UpdDate] == DBNull.Value ? null : objRow[conqa_Answer.UpdDate].ToString().Trim(); //修改日期
objqa_AnswerEN.Memo = objRow[conqa_Answer.Memo] == DBNull.Value ? null : objRow[conqa_Answer.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsqa_AnswerDA: GetObjLst)", objException.Message));
}
objqa_AnswerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objqa_AnswerEN);
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
public List<clsqa_AnswerEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsqa_AnswerDA:GetObjLstByTabName)", objException.Message));
}
List<clsqa_AnswerEN> arrObjLst = new List<clsqa_AnswerEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_AnswerDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsqa_AnswerEN objqa_AnswerEN = new clsqa_AnswerEN();
try
{
objqa_AnswerEN.AnswerId = objRow[conqa_Answer.AnswerId].ToString().Trim(); //回答Id
objqa_AnswerEN.QuestionsId = objRow[conqa_Answer.QuestionsId].ToString().Trim(); //提问Id
objqa_AnswerEN.AnswerContent = objRow[conqa_Answer.AnswerContent] == DBNull.Value ? null : objRow[conqa_Answer.AnswerContent].ToString().Trim(); //答案内容
objqa_AnswerEN.Score = objRow[conqa_Answer.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conqa_Answer.Score].ToString().Trim()); //评分
objqa_AnswerEN.ScoreType = objRow[conqa_Answer.ScoreType] == DBNull.Value ? null : objRow[conqa_Answer.ScoreType].ToString().Trim(); //评分类型
objqa_AnswerEN.IsRight = TransNullToBool(objRow[conqa_Answer.IsRight].ToString().Trim()); //是否正确
objqa_AnswerEN.ParentId = objRow[conqa_Answer.ParentId] == DBNull.Value ? null : objRow[conqa_Answer.ParentId].ToString().Trim(); //父节点Id
objqa_AnswerEN.VoteCount = objRow[conqa_Answer.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conqa_Answer.VoteCount].ToString().Trim()); //点赞计数
objqa_AnswerEN.IsRecommend = TransNullToBool(objRow[conqa_Answer.IsRecommend].ToString().Trim()); //是否推荐
objqa_AnswerEN.TopicId = objRow[conqa_Answer.TopicId] == DBNull.Value ? null : objRow[conqa_Answer.TopicId].ToString().Trim(); //主题Id
objqa_AnswerEN.AnswerTypeId = objRow[conqa_Answer.AnswerTypeId] == DBNull.Value ? null : objRow[conqa_Answer.AnswerTypeId].ToString().Trim(); //答案类型ID
objqa_AnswerEN.IsSubmit = TransNullToBool(objRow[conqa_Answer.IsSubmit].ToString().Trim()); //是否提交
objqa_AnswerEN.AppraiseCount = objRow[conqa_Answer.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conqa_Answer.AppraiseCount].ToString().Trim()); //评论数
objqa_AnswerEN.StuScore = objRow[conqa_Answer.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conqa_Answer.StuScore].ToString().Trim()); //学生平均分
objqa_AnswerEN.TeaScore = objRow[conqa_Answer.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conqa_Answer.TeaScore].ToString().Trim()); //教师评分
objqa_AnswerEN.CreateDate = objRow[conqa_Answer.CreateDate] == DBNull.Value ? null : objRow[conqa_Answer.CreateDate].ToString().Trim(); //建立日期
objqa_AnswerEN.IdCurrEduCls = objRow[conqa_Answer.IdCurrEduCls] == DBNull.Value ? null : objRow[conqa_Answer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objqa_AnswerEN.UpdUser = objRow[conqa_Answer.UpdUser] == DBNull.Value ? null : objRow[conqa_Answer.UpdUser].ToString().Trim(); //修改人
objqa_AnswerEN.UpdDate = objRow[conqa_Answer.UpdDate] == DBNull.Value ? null : objRow[conqa_Answer.UpdDate].ToString().Trim(); //修改日期
objqa_AnswerEN.Memo = objRow[conqa_Answer.Memo] == DBNull.Value ? null : objRow[conqa_Answer.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsqa_AnswerDA: GetObjLst)", objException.Message));
}
objqa_AnswerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objqa_AnswerEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objqa_AnswerEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getqa_Answer(ref clsqa_AnswerEN objqa_AnswerEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_AnswerDA.GetSpecSQLObj();
strSQL = "Select * from qa_Answer where AnswerId = " + "'"+ objqa_AnswerEN.AnswerId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objqa_AnswerEN.AnswerId = objDT.Rows[0][conqa_Answer.AnswerId].ToString().Trim(); //回答Id(字段类型:char,字段长度:10,是否可空:False)
 objqa_AnswerEN.QuestionsId = objDT.Rows[0][conqa_Answer.QuestionsId].ToString().Trim(); //提问Id(字段类型:char,字段长度:8,是否可空:False)
 objqa_AnswerEN.AnswerContent = objDT.Rows[0][conqa_Answer.AnswerContent].ToString().Trim(); //答案内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objqa_AnswerEN.Score = TransNullToFloat(objDT.Rows[0][conqa_Answer.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objqa_AnswerEN.ScoreType = objDT.Rows[0][conqa_Answer.ScoreType].ToString().Trim(); //评分类型(字段类型:char,字段长度:1,是否可空:True)
 objqa_AnswerEN.IsRight = TransNullToBool(objDT.Rows[0][conqa_Answer.IsRight].ToString().Trim()); //是否正确(字段类型:bit,字段长度:1,是否可空:True)
 objqa_AnswerEN.ParentId = objDT.Rows[0][conqa_Answer.ParentId].ToString().Trim(); //父节点Id(字段类型:char,字段长度:10,是否可空:True)
 objqa_AnswerEN.VoteCount = TransNullToInt(objDT.Rows[0][conqa_Answer.VoteCount].ToString().Trim()); //点赞计数(字段类型:int,字段长度:4,是否可空:True)
 objqa_AnswerEN.IsRecommend = TransNullToBool(objDT.Rows[0][conqa_Answer.IsRecommend].ToString().Trim()); //是否推荐(字段类型:bit,字段长度:1,是否可空:True)
 objqa_AnswerEN.TopicId = objDT.Rows[0][conqa_Answer.TopicId].ToString().Trim(); //主题Id(字段类型:char,字段长度:8,是否可空:True)
 objqa_AnswerEN.AnswerTypeId = objDT.Rows[0][conqa_Answer.AnswerTypeId].ToString().Trim(); //答案类型ID(字段类型:char,字段长度:2,是否可空:True)
 objqa_AnswerEN.IsSubmit = TransNullToBool(objDT.Rows[0][conqa_Answer.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objqa_AnswerEN.AppraiseCount = TransNullToInt(objDT.Rows[0][conqa_Answer.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objqa_AnswerEN.StuScore = TransNullToFloat(objDT.Rows[0][conqa_Answer.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objqa_AnswerEN.TeaScore = TransNullToFloat(objDT.Rows[0][conqa_Answer.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objqa_AnswerEN.CreateDate = objDT.Rows[0][conqa_Answer.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objqa_AnswerEN.IdCurrEduCls = objDT.Rows[0][conqa_Answer.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objqa_AnswerEN.UpdUser = objDT.Rows[0][conqa_Answer.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objqa_AnswerEN.UpdDate = objDT.Rows[0][conqa_Answer.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objqa_AnswerEN.Memo = objDT.Rows[0][conqa_Answer.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsqa_AnswerDA: Getqa_Answer)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strAnswerId">表关键字</param>
 /// <returns>表对象</returns>
public clsqa_AnswerEN GetObjByAnswerId(string strAnswerId)
{
CheckPrimaryKey(strAnswerId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_AnswerDA.GetSpecSQLObj();
strSQL = "Select * from qa_Answer where AnswerId = " + "'"+ strAnswerId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsqa_AnswerEN objqa_AnswerEN = new clsqa_AnswerEN();
try
{
 objqa_AnswerEN.AnswerId = objRow[conqa_Answer.AnswerId].ToString().Trim(); //回答Id(字段类型:char,字段长度:10,是否可空:False)
 objqa_AnswerEN.QuestionsId = objRow[conqa_Answer.QuestionsId].ToString().Trim(); //提问Id(字段类型:char,字段长度:8,是否可空:False)
 objqa_AnswerEN.AnswerContent = objRow[conqa_Answer.AnswerContent] == DBNull.Value ? null : objRow[conqa_Answer.AnswerContent].ToString().Trim(); //答案内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objqa_AnswerEN.Score = objRow[conqa_Answer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conqa_Answer.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objqa_AnswerEN.ScoreType = objRow[conqa_Answer.ScoreType] == DBNull.Value ? null : objRow[conqa_Answer.ScoreType].ToString().Trim(); //评分类型(字段类型:char,字段长度:1,是否可空:True)
 objqa_AnswerEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[conqa_Answer.IsRight].ToString().Trim()); //是否正确(字段类型:bit,字段长度:1,是否可空:True)
 objqa_AnswerEN.ParentId = objRow[conqa_Answer.ParentId] == DBNull.Value ? null : objRow[conqa_Answer.ParentId].ToString().Trim(); //父节点Id(字段类型:char,字段长度:10,是否可空:True)
 objqa_AnswerEN.VoteCount = objRow[conqa_Answer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conqa_Answer.VoteCount].ToString().Trim()); //点赞计数(字段类型:int,字段长度:4,是否可空:True)
 objqa_AnswerEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conqa_Answer.IsRecommend].ToString().Trim()); //是否推荐(字段类型:bit,字段长度:1,是否可空:True)
 objqa_AnswerEN.TopicId = objRow[conqa_Answer.TopicId] == DBNull.Value ? null : objRow[conqa_Answer.TopicId].ToString().Trim(); //主题Id(字段类型:char,字段长度:8,是否可空:True)
 objqa_AnswerEN.AnswerTypeId = objRow[conqa_Answer.AnswerTypeId] == DBNull.Value ? null : objRow[conqa_Answer.AnswerTypeId].ToString().Trim(); //答案类型ID(字段类型:char,字段长度:2,是否可空:True)
 objqa_AnswerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conqa_Answer.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objqa_AnswerEN.AppraiseCount = objRow[conqa_Answer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conqa_Answer.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objqa_AnswerEN.StuScore = objRow[conqa_Answer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conqa_Answer.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objqa_AnswerEN.TeaScore = objRow[conqa_Answer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conqa_Answer.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objqa_AnswerEN.CreateDate = objRow[conqa_Answer.CreateDate] == DBNull.Value ? null : objRow[conqa_Answer.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objqa_AnswerEN.IdCurrEduCls = objRow[conqa_Answer.IdCurrEduCls] == DBNull.Value ? null : objRow[conqa_Answer.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objqa_AnswerEN.UpdUser = objRow[conqa_Answer.UpdUser] == DBNull.Value ? null : objRow[conqa_Answer.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objqa_AnswerEN.UpdDate = objRow[conqa_Answer.UpdDate] == DBNull.Value ? null : objRow[conqa_Answer.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objqa_AnswerEN.Memo = objRow[conqa_Answer.Memo] == DBNull.Value ? null : objRow[conqa_Answer.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsqa_AnswerDA: GetObjByAnswerId)", objException.Message));
}
return objqa_AnswerEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsqa_AnswerEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsqa_AnswerDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_AnswerDA.GetSpecSQLObj();
strSQL = "Select * from qa_Answer where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsqa_AnswerEN objqa_AnswerEN = new clsqa_AnswerEN()
{
AnswerId = objRow[conqa_Answer.AnswerId].ToString().Trim(), //回答Id
QuestionsId = objRow[conqa_Answer.QuestionsId].ToString().Trim(), //提问Id
AnswerContent = objRow[conqa_Answer.AnswerContent] == DBNull.Value ? null : objRow[conqa_Answer.AnswerContent].ToString().Trim(), //答案内容
Score = objRow[conqa_Answer.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conqa_Answer.Score].ToString().Trim()), //评分
ScoreType = objRow[conqa_Answer.ScoreType] == DBNull.Value ? null : objRow[conqa_Answer.ScoreType].ToString().Trim(), //评分类型
IsRight = TransNullToBool(objRow[conqa_Answer.IsRight].ToString().Trim()), //是否正确
ParentId = objRow[conqa_Answer.ParentId] == DBNull.Value ? null : objRow[conqa_Answer.ParentId].ToString().Trim(), //父节点Id
VoteCount = objRow[conqa_Answer.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conqa_Answer.VoteCount].ToString().Trim()), //点赞计数
IsRecommend = TransNullToBool(objRow[conqa_Answer.IsRecommend].ToString().Trim()), //是否推荐
TopicId = objRow[conqa_Answer.TopicId] == DBNull.Value ? null : objRow[conqa_Answer.TopicId].ToString().Trim(), //主题Id
AnswerTypeId = objRow[conqa_Answer.AnswerTypeId] == DBNull.Value ? null : objRow[conqa_Answer.AnswerTypeId].ToString().Trim(), //答案类型ID
IsSubmit = TransNullToBool(objRow[conqa_Answer.IsSubmit].ToString().Trim()), //是否提交
AppraiseCount = objRow[conqa_Answer.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conqa_Answer.AppraiseCount].ToString().Trim()), //评论数
StuScore = objRow[conqa_Answer.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conqa_Answer.StuScore].ToString().Trim()), //学生平均分
TeaScore = objRow[conqa_Answer.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conqa_Answer.TeaScore].ToString().Trim()), //教师评分
CreateDate = objRow[conqa_Answer.CreateDate] == DBNull.Value ? null : objRow[conqa_Answer.CreateDate].ToString().Trim(), //建立日期
IdCurrEduCls = objRow[conqa_Answer.IdCurrEduCls] == DBNull.Value ? null : objRow[conqa_Answer.IdCurrEduCls].ToString().Trim(), //教学班流水号
UpdUser = objRow[conqa_Answer.UpdUser] == DBNull.Value ? null : objRow[conqa_Answer.UpdUser].ToString().Trim(), //修改人
UpdDate = objRow[conqa_Answer.UpdDate] == DBNull.Value ? null : objRow[conqa_Answer.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[conqa_Answer.Memo] == DBNull.Value ? null : objRow[conqa_Answer.Memo].ToString().Trim() //备注
};
objqa_AnswerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objqa_AnswerEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsqa_AnswerDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsqa_AnswerEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsqa_AnswerEN objqa_AnswerEN = new clsqa_AnswerEN();
try
{
objqa_AnswerEN.AnswerId = objRow[conqa_Answer.AnswerId].ToString().Trim(); //回答Id
objqa_AnswerEN.QuestionsId = objRow[conqa_Answer.QuestionsId].ToString().Trim(); //提问Id
objqa_AnswerEN.AnswerContent = objRow[conqa_Answer.AnswerContent] == DBNull.Value ? null : objRow[conqa_Answer.AnswerContent].ToString().Trim(); //答案内容
objqa_AnswerEN.Score = objRow[conqa_Answer.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conqa_Answer.Score].ToString().Trim()); //评分
objqa_AnswerEN.ScoreType = objRow[conqa_Answer.ScoreType] == DBNull.Value ? null : objRow[conqa_Answer.ScoreType].ToString().Trim(); //评分类型
objqa_AnswerEN.IsRight = TransNullToBool(objRow[conqa_Answer.IsRight].ToString().Trim()); //是否正确
objqa_AnswerEN.ParentId = objRow[conqa_Answer.ParentId] == DBNull.Value ? null : objRow[conqa_Answer.ParentId].ToString().Trim(); //父节点Id
objqa_AnswerEN.VoteCount = objRow[conqa_Answer.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conqa_Answer.VoteCount].ToString().Trim()); //点赞计数
objqa_AnswerEN.IsRecommend = TransNullToBool(objRow[conqa_Answer.IsRecommend].ToString().Trim()); //是否推荐
objqa_AnswerEN.TopicId = objRow[conqa_Answer.TopicId] == DBNull.Value ? null : objRow[conqa_Answer.TopicId].ToString().Trim(); //主题Id
objqa_AnswerEN.AnswerTypeId = objRow[conqa_Answer.AnswerTypeId] == DBNull.Value ? null : objRow[conqa_Answer.AnswerTypeId].ToString().Trim(); //答案类型ID
objqa_AnswerEN.IsSubmit = TransNullToBool(objRow[conqa_Answer.IsSubmit].ToString().Trim()); //是否提交
objqa_AnswerEN.AppraiseCount = objRow[conqa_Answer.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conqa_Answer.AppraiseCount].ToString().Trim()); //评论数
objqa_AnswerEN.StuScore = objRow[conqa_Answer.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conqa_Answer.StuScore].ToString().Trim()); //学生平均分
objqa_AnswerEN.TeaScore = objRow[conqa_Answer.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conqa_Answer.TeaScore].ToString().Trim()); //教师评分
objqa_AnswerEN.CreateDate = objRow[conqa_Answer.CreateDate] == DBNull.Value ? null : objRow[conqa_Answer.CreateDate].ToString().Trim(); //建立日期
objqa_AnswerEN.IdCurrEduCls = objRow[conqa_Answer.IdCurrEduCls] == DBNull.Value ? null : objRow[conqa_Answer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objqa_AnswerEN.UpdUser = objRow[conqa_Answer.UpdUser] == DBNull.Value ? null : objRow[conqa_Answer.UpdUser].ToString().Trim(); //修改人
objqa_AnswerEN.UpdDate = objRow[conqa_Answer.UpdDate] == DBNull.Value ? null : objRow[conqa_Answer.UpdDate].ToString().Trim(); //修改日期
objqa_AnswerEN.Memo = objRow[conqa_Answer.Memo] == DBNull.Value ? null : objRow[conqa_Answer.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsqa_AnswerDA: GetObjByDataRowqa_Answer)", objException.Message));
}
objqa_AnswerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objqa_AnswerEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsqa_AnswerEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsqa_AnswerEN objqa_AnswerEN = new clsqa_AnswerEN();
try
{
objqa_AnswerEN.AnswerId = objRow[conqa_Answer.AnswerId].ToString().Trim(); //回答Id
objqa_AnswerEN.QuestionsId = objRow[conqa_Answer.QuestionsId].ToString().Trim(); //提问Id
objqa_AnswerEN.AnswerContent = objRow[conqa_Answer.AnswerContent] == DBNull.Value ? null : objRow[conqa_Answer.AnswerContent].ToString().Trim(); //答案内容
objqa_AnswerEN.Score = objRow[conqa_Answer.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conqa_Answer.Score].ToString().Trim()); //评分
objqa_AnswerEN.ScoreType = objRow[conqa_Answer.ScoreType] == DBNull.Value ? null : objRow[conqa_Answer.ScoreType].ToString().Trim(); //评分类型
objqa_AnswerEN.IsRight = TransNullToBool(objRow[conqa_Answer.IsRight].ToString().Trim()); //是否正确
objqa_AnswerEN.ParentId = objRow[conqa_Answer.ParentId] == DBNull.Value ? null : objRow[conqa_Answer.ParentId].ToString().Trim(); //父节点Id
objqa_AnswerEN.VoteCount = objRow[conqa_Answer.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conqa_Answer.VoteCount].ToString().Trim()); //点赞计数
objqa_AnswerEN.IsRecommend = TransNullToBool(objRow[conqa_Answer.IsRecommend].ToString().Trim()); //是否推荐
objqa_AnswerEN.TopicId = objRow[conqa_Answer.TopicId] == DBNull.Value ? null : objRow[conqa_Answer.TopicId].ToString().Trim(); //主题Id
objqa_AnswerEN.AnswerTypeId = objRow[conqa_Answer.AnswerTypeId] == DBNull.Value ? null : objRow[conqa_Answer.AnswerTypeId].ToString().Trim(); //答案类型ID
objqa_AnswerEN.IsSubmit = TransNullToBool(objRow[conqa_Answer.IsSubmit].ToString().Trim()); //是否提交
objqa_AnswerEN.AppraiseCount = objRow[conqa_Answer.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conqa_Answer.AppraiseCount].ToString().Trim()); //评论数
objqa_AnswerEN.StuScore = objRow[conqa_Answer.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conqa_Answer.StuScore].ToString().Trim()); //学生平均分
objqa_AnswerEN.TeaScore = objRow[conqa_Answer.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conqa_Answer.TeaScore].ToString().Trim()); //教师评分
objqa_AnswerEN.CreateDate = objRow[conqa_Answer.CreateDate] == DBNull.Value ? null : objRow[conqa_Answer.CreateDate].ToString().Trim(); //建立日期
objqa_AnswerEN.IdCurrEduCls = objRow[conqa_Answer.IdCurrEduCls] == DBNull.Value ? null : objRow[conqa_Answer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objqa_AnswerEN.UpdUser = objRow[conqa_Answer.UpdUser] == DBNull.Value ? null : objRow[conqa_Answer.UpdUser].ToString().Trim(); //修改人
objqa_AnswerEN.UpdDate = objRow[conqa_Answer.UpdDate] == DBNull.Value ? null : objRow[conqa_Answer.UpdDate].ToString().Trim(); //修改日期
objqa_AnswerEN.Memo = objRow[conqa_Answer.Memo] == DBNull.Value ? null : objRow[conqa_Answer.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsqa_AnswerDA: GetObjByDataRow)", objException.Message));
}
objqa_AnswerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objqa_AnswerEN;
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
objSQL = clsqa_AnswerDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsqa_AnswerEN._CurrTabName, conqa_Answer.AnswerId, 10, "");
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
objSQL = clsqa_AnswerDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsqa_AnswerEN._CurrTabName, conqa_Answer.AnswerId, 10, strPrefix);
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
 objSQL = clsqa_AnswerDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select AnswerId from qa_Answer where " + strCondition;
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
 objSQL = clsqa_AnswerDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select AnswerId from qa_Answer where " + strCondition;
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
 /// <param name = "strAnswerId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strAnswerId)
{
CheckPrimaryKey(strAnswerId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_AnswerDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("qa_Answer", "AnswerId = " + "'"+ strAnswerId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsqa_AnswerDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_AnswerDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("qa_Answer", strCondition))
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
objSQL = clsqa_AnswerDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("qa_Answer");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsqa_AnswerEN objqa_AnswerEN)
 {
 if (objqa_AnswerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objqa_AnswerEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_AnswerDA.GetSpecSQLObj();
strSQL = "Select * from qa_Answer where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "qa_Answer");
objRow = objDS.Tables["qa_Answer"].NewRow();
objRow[conqa_Answer.AnswerId] = objqa_AnswerEN.AnswerId; //回答Id
objRow[conqa_Answer.QuestionsId] = objqa_AnswerEN.QuestionsId; //提问Id
 if (objqa_AnswerEN.AnswerContent !=  "")
 {
objRow[conqa_Answer.AnswerContent] = objqa_AnswerEN.AnswerContent; //答案内容
 }
objRow[conqa_Answer.Score] = objqa_AnswerEN.Score; //评分
 if (objqa_AnswerEN.ScoreType !=  "")
 {
objRow[conqa_Answer.ScoreType] = objqa_AnswerEN.ScoreType; //评分类型
 }
objRow[conqa_Answer.IsRight] = objqa_AnswerEN.IsRight; //是否正确
 if (objqa_AnswerEN.ParentId !=  "")
 {
objRow[conqa_Answer.ParentId] = objqa_AnswerEN.ParentId; //父节点Id
 }
objRow[conqa_Answer.VoteCount] = objqa_AnswerEN.VoteCount; //点赞计数
objRow[conqa_Answer.IsRecommend] = objqa_AnswerEN.IsRecommend; //是否推荐
 if (objqa_AnswerEN.TopicId !=  "")
 {
objRow[conqa_Answer.TopicId] = objqa_AnswerEN.TopicId; //主题Id
 }
 if (objqa_AnswerEN.AnswerTypeId !=  "")
 {
objRow[conqa_Answer.AnswerTypeId] = objqa_AnswerEN.AnswerTypeId; //答案类型ID
 }
objRow[conqa_Answer.IsSubmit] = objqa_AnswerEN.IsSubmit; //是否提交
objRow[conqa_Answer.AppraiseCount] = objqa_AnswerEN.AppraiseCount; //评论数
objRow[conqa_Answer.StuScore] = objqa_AnswerEN.StuScore; //学生平均分
objRow[conqa_Answer.TeaScore] = objqa_AnswerEN.TeaScore; //教师评分
 if (objqa_AnswerEN.CreateDate !=  "")
 {
objRow[conqa_Answer.CreateDate] = objqa_AnswerEN.CreateDate; //建立日期
 }
 if (objqa_AnswerEN.IdCurrEduCls !=  "")
 {
objRow[conqa_Answer.IdCurrEduCls] = objqa_AnswerEN.IdCurrEduCls; //教学班流水号
 }
 if (objqa_AnswerEN.UpdUser !=  "")
 {
objRow[conqa_Answer.UpdUser] = objqa_AnswerEN.UpdUser; //修改人
 }
 if (objqa_AnswerEN.UpdDate !=  "")
 {
objRow[conqa_Answer.UpdDate] = objqa_AnswerEN.UpdDate; //修改日期
 }
 if (objqa_AnswerEN.Memo !=  "")
 {
objRow[conqa_Answer.Memo] = objqa_AnswerEN.Memo; //备注
 }
objDS.Tables[clsqa_AnswerEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsqa_AnswerEN._CurrTabName);
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
 /// <param name = "objqa_AnswerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsqa_AnswerEN objqa_AnswerEN)
{
 if (objqa_AnswerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objqa_AnswerEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objqa_AnswerEN.AnswerId !=  null)
 {
 arrFieldListForInsert.Add(conqa_Answer.AnswerId);
 var strAnswerId = objqa_AnswerEN.AnswerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerId + "'");
 }
 
 if (objqa_AnswerEN.QuestionsId !=  null)
 {
 arrFieldListForInsert.Add(conqa_Answer.QuestionsId);
 var strQuestionsId = objqa_AnswerEN.QuestionsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionsId + "'");
 }
 
 if (objqa_AnswerEN.AnswerContent !=  null)
 {
 arrFieldListForInsert.Add(conqa_Answer.AnswerContent);
 var strAnswerContent = objqa_AnswerEN.AnswerContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerContent + "'");
 }
 
 if (objqa_AnswerEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conqa_Answer.Score);
 arrValueListForInsert.Add(objqa_AnswerEN.Score.ToString());
 }
 
 if (objqa_AnswerEN.ScoreType !=  null)
 {
 arrFieldListForInsert.Add(conqa_Answer.ScoreType);
 var strScoreType = objqa_AnswerEN.ScoreType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strScoreType + "'");
 }
 
 arrFieldListForInsert.Add(conqa_Answer.IsRight);
 arrValueListForInsert.Add("'" + (objqa_AnswerEN.IsRight  ==  false ? "0" : "1") + "'");
 
 if (objqa_AnswerEN.ParentId !=  null)
 {
 arrFieldListForInsert.Add(conqa_Answer.ParentId);
 var strParentId = objqa_AnswerEN.ParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParentId + "'");
 }
 
 if (objqa_AnswerEN.VoteCount !=  null)
 {
 arrFieldListForInsert.Add(conqa_Answer.VoteCount);
 arrValueListForInsert.Add(objqa_AnswerEN.VoteCount.ToString());
 }
 
 arrFieldListForInsert.Add(conqa_Answer.IsRecommend);
 arrValueListForInsert.Add("'" + (objqa_AnswerEN.IsRecommend  ==  false ? "0" : "1") + "'");
 
 if (objqa_AnswerEN.TopicId !=  null)
 {
 arrFieldListForInsert.Add(conqa_Answer.TopicId);
 var strTopicId = objqa_AnswerEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicId + "'");
 }
 
 if (objqa_AnswerEN.AnswerTypeId !=  null)
 {
 arrFieldListForInsert.Add(conqa_Answer.AnswerTypeId);
 var strAnswerTypeId = objqa_AnswerEN.AnswerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conqa_Answer.IsSubmit);
 arrValueListForInsert.Add("'" + (objqa_AnswerEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objqa_AnswerEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conqa_Answer.AppraiseCount);
 arrValueListForInsert.Add(objqa_AnswerEN.AppraiseCount.ToString());
 }
 
 if (objqa_AnswerEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conqa_Answer.StuScore);
 arrValueListForInsert.Add(objqa_AnswerEN.StuScore.ToString());
 }
 
 if (objqa_AnswerEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conqa_Answer.TeaScore);
 arrValueListForInsert.Add(objqa_AnswerEN.TeaScore.ToString());
 }
 
 if (objqa_AnswerEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conqa_Answer.CreateDate);
 var strCreateDate = objqa_AnswerEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objqa_AnswerEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conqa_Answer.IdCurrEduCls);
 var strIdCurrEduCls = objqa_AnswerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objqa_AnswerEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conqa_Answer.UpdUser);
 var strUpdUser = objqa_AnswerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objqa_AnswerEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conqa_Answer.UpdDate);
 var strUpdDate = objqa_AnswerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objqa_AnswerEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conqa_Answer.Memo);
 var strMemo = objqa_AnswerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into qa_Answer");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_AnswerDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objqa_AnswerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsqa_AnswerEN objqa_AnswerEN)
{
 if (objqa_AnswerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objqa_AnswerEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objqa_AnswerEN.AnswerId !=  null)
 {
 arrFieldListForInsert.Add(conqa_Answer.AnswerId);
 var strAnswerId = objqa_AnswerEN.AnswerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerId + "'");
 }
 
 if (objqa_AnswerEN.QuestionsId !=  null)
 {
 arrFieldListForInsert.Add(conqa_Answer.QuestionsId);
 var strQuestionsId = objqa_AnswerEN.QuestionsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionsId + "'");
 }
 
 if (objqa_AnswerEN.AnswerContent !=  null)
 {
 arrFieldListForInsert.Add(conqa_Answer.AnswerContent);
 var strAnswerContent = objqa_AnswerEN.AnswerContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerContent + "'");
 }
 
 if (objqa_AnswerEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conqa_Answer.Score);
 arrValueListForInsert.Add(objqa_AnswerEN.Score.ToString());
 }
 
 if (objqa_AnswerEN.ScoreType !=  null)
 {
 arrFieldListForInsert.Add(conqa_Answer.ScoreType);
 var strScoreType = objqa_AnswerEN.ScoreType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strScoreType + "'");
 }
 
 arrFieldListForInsert.Add(conqa_Answer.IsRight);
 arrValueListForInsert.Add("'" + (objqa_AnswerEN.IsRight  ==  false ? "0" : "1") + "'");
 
 if (objqa_AnswerEN.ParentId !=  null)
 {
 arrFieldListForInsert.Add(conqa_Answer.ParentId);
 var strParentId = objqa_AnswerEN.ParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParentId + "'");
 }
 
 if (objqa_AnswerEN.VoteCount !=  null)
 {
 arrFieldListForInsert.Add(conqa_Answer.VoteCount);
 arrValueListForInsert.Add(objqa_AnswerEN.VoteCount.ToString());
 }
 
 arrFieldListForInsert.Add(conqa_Answer.IsRecommend);
 arrValueListForInsert.Add("'" + (objqa_AnswerEN.IsRecommend  ==  false ? "0" : "1") + "'");
 
 if (objqa_AnswerEN.TopicId !=  null)
 {
 arrFieldListForInsert.Add(conqa_Answer.TopicId);
 var strTopicId = objqa_AnswerEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicId + "'");
 }
 
 if (objqa_AnswerEN.AnswerTypeId !=  null)
 {
 arrFieldListForInsert.Add(conqa_Answer.AnswerTypeId);
 var strAnswerTypeId = objqa_AnswerEN.AnswerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conqa_Answer.IsSubmit);
 arrValueListForInsert.Add("'" + (objqa_AnswerEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objqa_AnswerEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conqa_Answer.AppraiseCount);
 arrValueListForInsert.Add(objqa_AnswerEN.AppraiseCount.ToString());
 }
 
 if (objqa_AnswerEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conqa_Answer.StuScore);
 arrValueListForInsert.Add(objqa_AnswerEN.StuScore.ToString());
 }
 
 if (objqa_AnswerEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conqa_Answer.TeaScore);
 arrValueListForInsert.Add(objqa_AnswerEN.TeaScore.ToString());
 }
 
 if (objqa_AnswerEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conqa_Answer.CreateDate);
 var strCreateDate = objqa_AnswerEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objqa_AnswerEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conqa_Answer.IdCurrEduCls);
 var strIdCurrEduCls = objqa_AnswerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objqa_AnswerEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conqa_Answer.UpdUser);
 var strUpdUser = objqa_AnswerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objqa_AnswerEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conqa_Answer.UpdDate);
 var strUpdDate = objqa_AnswerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objqa_AnswerEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conqa_Answer.Memo);
 var strMemo = objqa_AnswerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into qa_Answer");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_AnswerDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objqa_AnswerEN.AnswerId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objqa_AnswerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsqa_AnswerEN objqa_AnswerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objqa_AnswerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objqa_AnswerEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objqa_AnswerEN.AnswerId !=  null)
 {
 arrFieldListForInsert.Add(conqa_Answer.AnswerId);
 var strAnswerId = objqa_AnswerEN.AnswerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerId + "'");
 }
 
 if (objqa_AnswerEN.QuestionsId !=  null)
 {
 arrFieldListForInsert.Add(conqa_Answer.QuestionsId);
 var strQuestionsId = objqa_AnswerEN.QuestionsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionsId + "'");
 }
 
 if (objqa_AnswerEN.AnswerContent !=  null)
 {
 arrFieldListForInsert.Add(conqa_Answer.AnswerContent);
 var strAnswerContent = objqa_AnswerEN.AnswerContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerContent + "'");
 }
 
 if (objqa_AnswerEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conqa_Answer.Score);
 arrValueListForInsert.Add(objqa_AnswerEN.Score.ToString());
 }
 
 if (objqa_AnswerEN.ScoreType !=  null)
 {
 arrFieldListForInsert.Add(conqa_Answer.ScoreType);
 var strScoreType = objqa_AnswerEN.ScoreType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strScoreType + "'");
 }
 
 arrFieldListForInsert.Add(conqa_Answer.IsRight);
 arrValueListForInsert.Add("'" + (objqa_AnswerEN.IsRight  ==  false ? "0" : "1") + "'");
 
 if (objqa_AnswerEN.ParentId !=  null)
 {
 arrFieldListForInsert.Add(conqa_Answer.ParentId);
 var strParentId = objqa_AnswerEN.ParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParentId + "'");
 }
 
 if (objqa_AnswerEN.VoteCount !=  null)
 {
 arrFieldListForInsert.Add(conqa_Answer.VoteCount);
 arrValueListForInsert.Add(objqa_AnswerEN.VoteCount.ToString());
 }
 
 arrFieldListForInsert.Add(conqa_Answer.IsRecommend);
 arrValueListForInsert.Add("'" + (objqa_AnswerEN.IsRecommend  ==  false ? "0" : "1") + "'");
 
 if (objqa_AnswerEN.TopicId !=  null)
 {
 arrFieldListForInsert.Add(conqa_Answer.TopicId);
 var strTopicId = objqa_AnswerEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicId + "'");
 }
 
 if (objqa_AnswerEN.AnswerTypeId !=  null)
 {
 arrFieldListForInsert.Add(conqa_Answer.AnswerTypeId);
 var strAnswerTypeId = objqa_AnswerEN.AnswerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conqa_Answer.IsSubmit);
 arrValueListForInsert.Add("'" + (objqa_AnswerEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objqa_AnswerEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conqa_Answer.AppraiseCount);
 arrValueListForInsert.Add(objqa_AnswerEN.AppraiseCount.ToString());
 }
 
 if (objqa_AnswerEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conqa_Answer.StuScore);
 arrValueListForInsert.Add(objqa_AnswerEN.StuScore.ToString());
 }
 
 if (objqa_AnswerEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conqa_Answer.TeaScore);
 arrValueListForInsert.Add(objqa_AnswerEN.TeaScore.ToString());
 }
 
 if (objqa_AnswerEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conqa_Answer.CreateDate);
 var strCreateDate = objqa_AnswerEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objqa_AnswerEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conqa_Answer.IdCurrEduCls);
 var strIdCurrEduCls = objqa_AnswerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objqa_AnswerEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conqa_Answer.UpdUser);
 var strUpdUser = objqa_AnswerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objqa_AnswerEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conqa_Answer.UpdDate);
 var strUpdDate = objqa_AnswerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objqa_AnswerEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conqa_Answer.Memo);
 var strMemo = objqa_AnswerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into qa_Answer");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_AnswerDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objqa_AnswerEN.AnswerId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objqa_AnswerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsqa_AnswerEN objqa_AnswerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objqa_AnswerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objqa_AnswerEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objqa_AnswerEN.AnswerId !=  null)
 {
 arrFieldListForInsert.Add(conqa_Answer.AnswerId);
 var strAnswerId = objqa_AnswerEN.AnswerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerId + "'");
 }
 
 if (objqa_AnswerEN.QuestionsId !=  null)
 {
 arrFieldListForInsert.Add(conqa_Answer.QuestionsId);
 var strQuestionsId = objqa_AnswerEN.QuestionsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionsId + "'");
 }
 
 if (objqa_AnswerEN.AnswerContent !=  null)
 {
 arrFieldListForInsert.Add(conqa_Answer.AnswerContent);
 var strAnswerContent = objqa_AnswerEN.AnswerContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerContent + "'");
 }
 
 if (objqa_AnswerEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conqa_Answer.Score);
 arrValueListForInsert.Add(objqa_AnswerEN.Score.ToString());
 }
 
 if (objqa_AnswerEN.ScoreType !=  null)
 {
 arrFieldListForInsert.Add(conqa_Answer.ScoreType);
 var strScoreType = objqa_AnswerEN.ScoreType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strScoreType + "'");
 }
 
 arrFieldListForInsert.Add(conqa_Answer.IsRight);
 arrValueListForInsert.Add("'" + (objqa_AnswerEN.IsRight  ==  false ? "0" : "1") + "'");
 
 if (objqa_AnswerEN.ParentId !=  null)
 {
 arrFieldListForInsert.Add(conqa_Answer.ParentId);
 var strParentId = objqa_AnswerEN.ParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParentId + "'");
 }
 
 if (objqa_AnswerEN.VoteCount !=  null)
 {
 arrFieldListForInsert.Add(conqa_Answer.VoteCount);
 arrValueListForInsert.Add(objqa_AnswerEN.VoteCount.ToString());
 }
 
 arrFieldListForInsert.Add(conqa_Answer.IsRecommend);
 arrValueListForInsert.Add("'" + (objqa_AnswerEN.IsRecommend  ==  false ? "0" : "1") + "'");
 
 if (objqa_AnswerEN.TopicId !=  null)
 {
 arrFieldListForInsert.Add(conqa_Answer.TopicId);
 var strTopicId = objqa_AnswerEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicId + "'");
 }
 
 if (objqa_AnswerEN.AnswerTypeId !=  null)
 {
 arrFieldListForInsert.Add(conqa_Answer.AnswerTypeId);
 var strAnswerTypeId = objqa_AnswerEN.AnswerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conqa_Answer.IsSubmit);
 arrValueListForInsert.Add("'" + (objqa_AnswerEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objqa_AnswerEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conqa_Answer.AppraiseCount);
 arrValueListForInsert.Add(objqa_AnswerEN.AppraiseCount.ToString());
 }
 
 if (objqa_AnswerEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conqa_Answer.StuScore);
 arrValueListForInsert.Add(objqa_AnswerEN.StuScore.ToString());
 }
 
 if (objqa_AnswerEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conqa_Answer.TeaScore);
 arrValueListForInsert.Add(objqa_AnswerEN.TeaScore.ToString());
 }
 
 if (objqa_AnswerEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conqa_Answer.CreateDate);
 var strCreateDate = objqa_AnswerEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objqa_AnswerEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conqa_Answer.IdCurrEduCls);
 var strIdCurrEduCls = objqa_AnswerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objqa_AnswerEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conqa_Answer.UpdUser);
 var strUpdUser = objqa_AnswerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objqa_AnswerEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conqa_Answer.UpdDate);
 var strUpdDate = objqa_AnswerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objqa_AnswerEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conqa_Answer.Memo);
 var strMemo = objqa_AnswerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into qa_Answer");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_AnswerDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewqa_Answers(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_AnswerDA.GetSpecSQLObj();
strSQL = "Select * from qa_Answer where AnswerId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "qa_Answer");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strAnswerId = oRow[conqa_Answer.AnswerId].ToString().Trim();
if (IsExist(strAnswerId))
{
 string strResult = "关键字变量值为:" + string.Format("AnswerId = {0}", strAnswerId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsqa_AnswerEN._CurrTabName ].NewRow();
objRow[conqa_Answer.AnswerId] = oRow[conqa_Answer.AnswerId].ToString().Trim(); //回答Id
objRow[conqa_Answer.QuestionsId] = oRow[conqa_Answer.QuestionsId].ToString().Trim(); //提问Id
objRow[conqa_Answer.AnswerContent] = oRow[conqa_Answer.AnswerContent].ToString().Trim(); //答案内容
objRow[conqa_Answer.Score] = oRow[conqa_Answer.Score].ToString().Trim(); //评分
objRow[conqa_Answer.ScoreType] = oRow[conqa_Answer.ScoreType].ToString().Trim(); //评分类型
objRow[conqa_Answer.IsRight] = oRow[conqa_Answer.IsRight].ToString().Trim(); //是否正确
objRow[conqa_Answer.ParentId] = oRow[conqa_Answer.ParentId].ToString().Trim(); //父节点Id
objRow[conqa_Answer.VoteCount] = oRow[conqa_Answer.VoteCount].ToString().Trim(); //点赞计数
objRow[conqa_Answer.IsRecommend] = oRow[conqa_Answer.IsRecommend].ToString().Trim(); //是否推荐
objRow[conqa_Answer.TopicId] = oRow[conqa_Answer.TopicId].ToString().Trim(); //主题Id
objRow[conqa_Answer.AnswerTypeId] = oRow[conqa_Answer.AnswerTypeId].ToString().Trim(); //答案类型ID
objRow[conqa_Answer.IsSubmit] = oRow[conqa_Answer.IsSubmit].ToString().Trim(); //是否提交
objRow[conqa_Answer.AppraiseCount] = oRow[conqa_Answer.AppraiseCount].ToString().Trim(); //评论数
objRow[conqa_Answer.StuScore] = oRow[conqa_Answer.StuScore].ToString().Trim(); //学生平均分
objRow[conqa_Answer.TeaScore] = oRow[conqa_Answer.TeaScore].ToString().Trim(); //教师评分
objRow[conqa_Answer.CreateDate] = oRow[conqa_Answer.CreateDate].ToString().Trim(); //建立日期
objRow[conqa_Answer.IdCurrEduCls] = oRow[conqa_Answer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objRow[conqa_Answer.UpdUser] = oRow[conqa_Answer.UpdUser].ToString().Trim(); //修改人
objRow[conqa_Answer.UpdDate] = oRow[conqa_Answer.UpdDate].ToString().Trim(); //修改日期
objRow[conqa_Answer.Memo] = oRow[conqa_Answer.Memo].ToString().Trim(); //备注
 objDS.Tables[clsqa_AnswerEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsqa_AnswerEN._CurrTabName);
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
 /// <param name = "objqa_AnswerEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsqa_AnswerEN objqa_AnswerEN)
{
 if (objqa_AnswerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objqa_AnswerEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_AnswerDA.GetSpecSQLObj();
strSQL = "Select * from qa_Answer where AnswerId = " + "'"+ objqa_AnswerEN.AnswerId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsqa_AnswerEN._CurrTabName);
if (objDS.Tables[clsqa_AnswerEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:AnswerId = " + "'"+ objqa_AnswerEN.AnswerId+"'");
return false;
}
objRow = objDS.Tables[clsqa_AnswerEN._CurrTabName].Rows[0];
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.AnswerId))
 {
objRow[conqa_Answer.AnswerId] = objqa_AnswerEN.AnswerId; //回答Id
 }
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.QuestionsId))
 {
objRow[conqa_Answer.QuestionsId] = objqa_AnswerEN.QuestionsId; //提问Id
 }
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.AnswerContent))
 {
objRow[conqa_Answer.AnswerContent] = objqa_AnswerEN.AnswerContent; //答案内容
 }
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.Score))
 {
objRow[conqa_Answer.Score] = objqa_AnswerEN.Score; //评分
 }
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.ScoreType))
 {
objRow[conqa_Answer.ScoreType] = objqa_AnswerEN.ScoreType; //评分类型
 }
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.IsRight))
 {
objRow[conqa_Answer.IsRight] = objqa_AnswerEN.IsRight; //是否正确
 }
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.ParentId))
 {
objRow[conqa_Answer.ParentId] = objqa_AnswerEN.ParentId; //父节点Id
 }
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.VoteCount))
 {
objRow[conqa_Answer.VoteCount] = objqa_AnswerEN.VoteCount; //点赞计数
 }
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.IsRecommend))
 {
objRow[conqa_Answer.IsRecommend] = objqa_AnswerEN.IsRecommend; //是否推荐
 }
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.TopicId))
 {
objRow[conqa_Answer.TopicId] = objqa_AnswerEN.TopicId; //主题Id
 }
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.AnswerTypeId))
 {
objRow[conqa_Answer.AnswerTypeId] = objqa_AnswerEN.AnswerTypeId; //答案类型ID
 }
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.IsSubmit))
 {
objRow[conqa_Answer.IsSubmit] = objqa_AnswerEN.IsSubmit; //是否提交
 }
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.AppraiseCount))
 {
objRow[conqa_Answer.AppraiseCount] = objqa_AnswerEN.AppraiseCount; //评论数
 }
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.StuScore))
 {
objRow[conqa_Answer.StuScore] = objqa_AnswerEN.StuScore; //学生平均分
 }
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.TeaScore))
 {
objRow[conqa_Answer.TeaScore] = objqa_AnswerEN.TeaScore; //教师评分
 }
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.CreateDate))
 {
objRow[conqa_Answer.CreateDate] = objqa_AnswerEN.CreateDate; //建立日期
 }
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.IdCurrEduCls))
 {
objRow[conqa_Answer.IdCurrEduCls] = objqa_AnswerEN.IdCurrEduCls; //教学班流水号
 }
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.UpdUser))
 {
objRow[conqa_Answer.UpdUser] = objqa_AnswerEN.UpdUser; //修改人
 }
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.UpdDate))
 {
objRow[conqa_Answer.UpdDate] = objqa_AnswerEN.UpdDate; //修改日期
 }
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.Memo))
 {
objRow[conqa_Answer.Memo] = objqa_AnswerEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsqa_AnswerEN._CurrTabName);
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
 /// <param name = "objqa_AnswerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsqa_AnswerEN objqa_AnswerEN)
{
 if (objqa_AnswerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objqa_AnswerEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_AnswerDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update qa_Answer Set ");
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.QuestionsId))
 {
 if (objqa_AnswerEN.QuestionsId !=  null)
 {
 var strQuestionsId = objqa_AnswerEN.QuestionsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionsId, conqa_Answer.QuestionsId); //提问Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Answer.QuestionsId); //提问Id
 }
 }
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.AnswerContent))
 {
 if (objqa_AnswerEN.AnswerContent !=  null)
 {
 var strAnswerContent = objqa_AnswerEN.AnswerContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerContent, conqa_Answer.AnswerContent); //答案内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Answer.AnswerContent); //答案内容
 }
 }
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.Score))
 {
 if (objqa_AnswerEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objqa_AnswerEN.Score, conqa_Answer.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Answer.Score); //评分
 }
 }
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.ScoreType))
 {
 if (objqa_AnswerEN.ScoreType !=  null)
 {
 var strScoreType = objqa_AnswerEN.ScoreType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strScoreType, conqa_Answer.ScoreType); //评分类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Answer.ScoreType); //评分类型
 }
 }
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.IsRight))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objqa_AnswerEN.IsRight == true?"1":"0", conqa_Answer.IsRight); //是否正确
 }
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.ParentId))
 {
 if (objqa_AnswerEN.ParentId !=  null)
 {
 var strParentId = objqa_AnswerEN.ParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParentId, conqa_Answer.ParentId); //父节点Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Answer.ParentId); //父节点Id
 }
 }
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.VoteCount))
 {
 if (objqa_AnswerEN.VoteCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objqa_AnswerEN.VoteCount, conqa_Answer.VoteCount); //点赞计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Answer.VoteCount); //点赞计数
 }
 }
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.IsRecommend))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objqa_AnswerEN.IsRecommend == true?"1":"0", conqa_Answer.IsRecommend); //是否推荐
 }
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.TopicId))
 {
 if (objqa_AnswerEN.TopicId !=  null)
 {
 var strTopicId = objqa_AnswerEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTopicId, conqa_Answer.TopicId); //主题Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Answer.TopicId); //主题Id
 }
 }
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.AnswerTypeId))
 {
 if (objqa_AnswerEN.AnswerTypeId !=  null)
 {
 var strAnswerTypeId = objqa_AnswerEN.AnswerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerTypeId, conqa_Answer.AnswerTypeId); //答案类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Answer.AnswerTypeId); //答案类型ID
 }
 }
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objqa_AnswerEN.IsSubmit == true?"1":"0", conqa_Answer.IsSubmit); //是否提交
 }
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.AppraiseCount))
 {
 if (objqa_AnswerEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objqa_AnswerEN.AppraiseCount, conqa_Answer.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Answer.AppraiseCount); //评论数
 }
 }
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.StuScore))
 {
 if (objqa_AnswerEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objqa_AnswerEN.StuScore, conqa_Answer.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Answer.StuScore); //学生平均分
 }
 }
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.TeaScore))
 {
 if (objqa_AnswerEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objqa_AnswerEN.TeaScore, conqa_Answer.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Answer.TeaScore); //教师评分
 }
 }
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.CreateDate))
 {
 if (objqa_AnswerEN.CreateDate !=  null)
 {
 var strCreateDate = objqa_AnswerEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateDate, conqa_Answer.CreateDate); //建立日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Answer.CreateDate); //建立日期
 }
 }
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.IdCurrEduCls))
 {
 if (objqa_AnswerEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objqa_AnswerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conqa_Answer.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Answer.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.UpdUser))
 {
 if (objqa_AnswerEN.UpdUser !=  null)
 {
 var strUpdUser = objqa_AnswerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conqa_Answer.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Answer.UpdUser); //修改人
 }
 }
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.UpdDate))
 {
 if (objqa_AnswerEN.UpdDate !=  null)
 {
 var strUpdDate = objqa_AnswerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conqa_Answer.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Answer.UpdDate); //修改日期
 }
 }
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.Memo))
 {
 if (objqa_AnswerEN.Memo !=  null)
 {
 var strMemo = objqa_AnswerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conqa_Answer.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Answer.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where AnswerId = '{0}'", objqa_AnswerEN.AnswerId); 
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
 /// <param name = "objqa_AnswerEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsqa_AnswerEN objqa_AnswerEN, string strCondition)
{
 if (objqa_AnswerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objqa_AnswerEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_AnswerDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update qa_Answer Set ");
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.QuestionsId))
 {
 if (objqa_AnswerEN.QuestionsId !=  null)
 {
 var strQuestionsId = objqa_AnswerEN.QuestionsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionsId = '{0}',", strQuestionsId); //提问Id
 }
 else
 {
 sbSQL.Append(" QuestionsId = null,"); //提问Id
 }
 }
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.AnswerContent))
 {
 if (objqa_AnswerEN.AnswerContent !=  null)
 {
 var strAnswerContent = objqa_AnswerEN.AnswerContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerContent = '{0}',", strAnswerContent); //答案内容
 }
 else
 {
 sbSQL.Append(" AnswerContent = null,"); //答案内容
 }
 }
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.Score))
 {
 if (objqa_AnswerEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objqa_AnswerEN.Score, conqa_Answer.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Answer.Score); //评分
 }
 }
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.ScoreType))
 {
 if (objqa_AnswerEN.ScoreType !=  null)
 {
 var strScoreType = objqa_AnswerEN.ScoreType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ScoreType = '{0}',", strScoreType); //评分类型
 }
 else
 {
 sbSQL.Append(" ScoreType = null,"); //评分类型
 }
 }
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.IsRight))
 {
 sbSQL.AppendFormat(" IsRight = '{0}',", objqa_AnswerEN.IsRight == true?"1":"0"); //是否正确
 }
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.ParentId))
 {
 if (objqa_AnswerEN.ParentId !=  null)
 {
 var strParentId = objqa_AnswerEN.ParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParentId = '{0}',", strParentId); //父节点Id
 }
 else
 {
 sbSQL.Append(" ParentId = null,"); //父节点Id
 }
 }
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.VoteCount))
 {
 if (objqa_AnswerEN.VoteCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objqa_AnswerEN.VoteCount, conqa_Answer.VoteCount); //点赞计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Answer.VoteCount); //点赞计数
 }
 }
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.IsRecommend))
 {
 sbSQL.AppendFormat(" IsRecommend = '{0}',", objqa_AnswerEN.IsRecommend == true?"1":"0"); //是否推荐
 }
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.TopicId))
 {
 if (objqa_AnswerEN.TopicId !=  null)
 {
 var strTopicId = objqa_AnswerEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TopicId = '{0}',", strTopicId); //主题Id
 }
 else
 {
 sbSQL.Append(" TopicId = null,"); //主题Id
 }
 }
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.AnswerTypeId))
 {
 if (objqa_AnswerEN.AnswerTypeId !=  null)
 {
 var strAnswerTypeId = objqa_AnswerEN.AnswerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerTypeId = '{0}',", strAnswerTypeId); //答案类型ID
 }
 else
 {
 sbSQL.Append(" AnswerTypeId = null,"); //答案类型ID
 }
 }
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objqa_AnswerEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.AppraiseCount))
 {
 if (objqa_AnswerEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objqa_AnswerEN.AppraiseCount, conqa_Answer.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Answer.AppraiseCount); //评论数
 }
 }
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.StuScore))
 {
 if (objqa_AnswerEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objqa_AnswerEN.StuScore, conqa_Answer.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Answer.StuScore); //学生平均分
 }
 }
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.TeaScore))
 {
 if (objqa_AnswerEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objqa_AnswerEN.TeaScore, conqa_Answer.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Answer.TeaScore); //教师评分
 }
 }
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.CreateDate))
 {
 if (objqa_AnswerEN.CreateDate !=  null)
 {
 var strCreateDate = objqa_AnswerEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateDate = '{0}',", strCreateDate); //建立日期
 }
 else
 {
 sbSQL.Append(" CreateDate = null,"); //建立日期
 }
 }
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.IdCurrEduCls))
 {
 if (objqa_AnswerEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objqa_AnswerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.UpdUser))
 {
 if (objqa_AnswerEN.UpdUser !=  null)
 {
 var strUpdUser = objqa_AnswerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.UpdDate))
 {
 if (objqa_AnswerEN.UpdDate !=  null)
 {
 var strUpdDate = objqa_AnswerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.Memo))
 {
 if (objqa_AnswerEN.Memo !=  null)
 {
 var strMemo = objqa_AnswerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objqa_AnswerEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsqa_AnswerEN objqa_AnswerEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objqa_AnswerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objqa_AnswerEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_AnswerDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update qa_Answer Set ");
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.QuestionsId))
 {
 if (objqa_AnswerEN.QuestionsId !=  null)
 {
 var strQuestionsId = objqa_AnswerEN.QuestionsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionsId = '{0}',", strQuestionsId); //提问Id
 }
 else
 {
 sbSQL.Append(" QuestionsId = null,"); //提问Id
 }
 }
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.AnswerContent))
 {
 if (objqa_AnswerEN.AnswerContent !=  null)
 {
 var strAnswerContent = objqa_AnswerEN.AnswerContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerContent = '{0}',", strAnswerContent); //答案内容
 }
 else
 {
 sbSQL.Append(" AnswerContent = null,"); //答案内容
 }
 }
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.Score))
 {
 if (objqa_AnswerEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objqa_AnswerEN.Score, conqa_Answer.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Answer.Score); //评分
 }
 }
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.ScoreType))
 {
 if (objqa_AnswerEN.ScoreType !=  null)
 {
 var strScoreType = objqa_AnswerEN.ScoreType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ScoreType = '{0}',", strScoreType); //评分类型
 }
 else
 {
 sbSQL.Append(" ScoreType = null,"); //评分类型
 }
 }
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.IsRight))
 {
 sbSQL.AppendFormat(" IsRight = '{0}',", objqa_AnswerEN.IsRight == true?"1":"0"); //是否正确
 }
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.ParentId))
 {
 if (objqa_AnswerEN.ParentId !=  null)
 {
 var strParentId = objqa_AnswerEN.ParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParentId = '{0}',", strParentId); //父节点Id
 }
 else
 {
 sbSQL.Append(" ParentId = null,"); //父节点Id
 }
 }
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.VoteCount))
 {
 if (objqa_AnswerEN.VoteCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objqa_AnswerEN.VoteCount, conqa_Answer.VoteCount); //点赞计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Answer.VoteCount); //点赞计数
 }
 }
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.IsRecommend))
 {
 sbSQL.AppendFormat(" IsRecommend = '{0}',", objqa_AnswerEN.IsRecommend == true?"1":"0"); //是否推荐
 }
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.TopicId))
 {
 if (objqa_AnswerEN.TopicId !=  null)
 {
 var strTopicId = objqa_AnswerEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TopicId = '{0}',", strTopicId); //主题Id
 }
 else
 {
 sbSQL.Append(" TopicId = null,"); //主题Id
 }
 }
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.AnswerTypeId))
 {
 if (objqa_AnswerEN.AnswerTypeId !=  null)
 {
 var strAnswerTypeId = objqa_AnswerEN.AnswerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerTypeId = '{0}',", strAnswerTypeId); //答案类型ID
 }
 else
 {
 sbSQL.Append(" AnswerTypeId = null,"); //答案类型ID
 }
 }
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objqa_AnswerEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.AppraiseCount))
 {
 if (objqa_AnswerEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objqa_AnswerEN.AppraiseCount, conqa_Answer.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Answer.AppraiseCount); //评论数
 }
 }
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.StuScore))
 {
 if (objqa_AnswerEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objqa_AnswerEN.StuScore, conqa_Answer.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Answer.StuScore); //学生平均分
 }
 }
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.TeaScore))
 {
 if (objqa_AnswerEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objqa_AnswerEN.TeaScore, conqa_Answer.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Answer.TeaScore); //教师评分
 }
 }
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.CreateDate))
 {
 if (objqa_AnswerEN.CreateDate !=  null)
 {
 var strCreateDate = objqa_AnswerEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateDate = '{0}',", strCreateDate); //建立日期
 }
 else
 {
 sbSQL.Append(" CreateDate = null,"); //建立日期
 }
 }
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.IdCurrEduCls))
 {
 if (objqa_AnswerEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objqa_AnswerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.UpdUser))
 {
 if (objqa_AnswerEN.UpdUser !=  null)
 {
 var strUpdUser = objqa_AnswerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.UpdDate))
 {
 if (objqa_AnswerEN.UpdDate !=  null)
 {
 var strUpdDate = objqa_AnswerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.Memo))
 {
 if (objqa_AnswerEN.Memo !=  null)
 {
 var strMemo = objqa_AnswerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objqa_AnswerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsqa_AnswerEN objqa_AnswerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objqa_AnswerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objqa_AnswerEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_AnswerDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update qa_Answer Set ");
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.QuestionsId))
 {
 if (objqa_AnswerEN.QuestionsId !=  null)
 {
 var strQuestionsId = objqa_AnswerEN.QuestionsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionsId, conqa_Answer.QuestionsId); //提问Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Answer.QuestionsId); //提问Id
 }
 }
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.AnswerContent))
 {
 if (objqa_AnswerEN.AnswerContent !=  null)
 {
 var strAnswerContent = objqa_AnswerEN.AnswerContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerContent, conqa_Answer.AnswerContent); //答案内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Answer.AnswerContent); //答案内容
 }
 }
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.Score))
 {
 if (objqa_AnswerEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objqa_AnswerEN.Score, conqa_Answer.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Answer.Score); //评分
 }
 }
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.ScoreType))
 {
 if (objqa_AnswerEN.ScoreType !=  null)
 {
 var strScoreType = objqa_AnswerEN.ScoreType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strScoreType, conqa_Answer.ScoreType); //评分类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Answer.ScoreType); //评分类型
 }
 }
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.IsRight))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objqa_AnswerEN.IsRight == true?"1":"0", conqa_Answer.IsRight); //是否正确
 }
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.ParentId))
 {
 if (objqa_AnswerEN.ParentId !=  null)
 {
 var strParentId = objqa_AnswerEN.ParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParentId, conqa_Answer.ParentId); //父节点Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Answer.ParentId); //父节点Id
 }
 }
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.VoteCount))
 {
 if (objqa_AnswerEN.VoteCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objqa_AnswerEN.VoteCount, conqa_Answer.VoteCount); //点赞计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Answer.VoteCount); //点赞计数
 }
 }
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.IsRecommend))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objqa_AnswerEN.IsRecommend == true?"1":"0", conqa_Answer.IsRecommend); //是否推荐
 }
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.TopicId))
 {
 if (objqa_AnswerEN.TopicId !=  null)
 {
 var strTopicId = objqa_AnswerEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTopicId, conqa_Answer.TopicId); //主题Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Answer.TopicId); //主题Id
 }
 }
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.AnswerTypeId))
 {
 if (objqa_AnswerEN.AnswerTypeId !=  null)
 {
 var strAnswerTypeId = objqa_AnswerEN.AnswerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerTypeId, conqa_Answer.AnswerTypeId); //答案类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Answer.AnswerTypeId); //答案类型ID
 }
 }
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objqa_AnswerEN.IsSubmit == true?"1":"0", conqa_Answer.IsSubmit); //是否提交
 }
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.AppraiseCount))
 {
 if (objqa_AnswerEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objqa_AnswerEN.AppraiseCount, conqa_Answer.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Answer.AppraiseCount); //评论数
 }
 }
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.StuScore))
 {
 if (objqa_AnswerEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objqa_AnswerEN.StuScore, conqa_Answer.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Answer.StuScore); //学生平均分
 }
 }
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.TeaScore))
 {
 if (objqa_AnswerEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objqa_AnswerEN.TeaScore, conqa_Answer.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Answer.TeaScore); //教师评分
 }
 }
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.CreateDate))
 {
 if (objqa_AnswerEN.CreateDate !=  null)
 {
 var strCreateDate = objqa_AnswerEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateDate, conqa_Answer.CreateDate); //建立日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Answer.CreateDate); //建立日期
 }
 }
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.IdCurrEduCls))
 {
 if (objqa_AnswerEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objqa_AnswerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conqa_Answer.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Answer.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.UpdUser))
 {
 if (objqa_AnswerEN.UpdUser !=  null)
 {
 var strUpdUser = objqa_AnswerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conqa_Answer.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Answer.UpdUser); //修改人
 }
 }
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.UpdDate))
 {
 if (objqa_AnswerEN.UpdDate !=  null)
 {
 var strUpdDate = objqa_AnswerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conqa_Answer.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Answer.UpdDate); //修改日期
 }
 }
 
 if (objqa_AnswerEN.IsUpdated(conqa_Answer.Memo))
 {
 if (objqa_AnswerEN.Memo !=  null)
 {
 var strMemo = objqa_AnswerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conqa_Answer.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Answer.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where AnswerId = '{0}'", objqa_AnswerEN.AnswerId); 
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
 /// <param name = "strAnswerId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strAnswerId) 
{
CheckPrimaryKey(strAnswerId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_AnswerDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strAnswerId,
};
 objSQL.ExecSP("qa_Answer_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strAnswerId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strAnswerId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strAnswerId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_AnswerDA.GetSpecSQLObj();
//删除qa_Answer本表中与当前对象有关的记录
strSQL = strSQL + "Delete from qa_Answer where AnswerId = " + "'"+ strAnswerId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delqa_Answer(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_AnswerDA.GetSpecSQLObj();
string strSQL;
string strKeyList;
if (lstKey.Count  == 0) return 0;
strKeyList = "";
for (int i = 0; i<lstKey.Count; i++)
{
if (i == 0) strKeyList = strKeyList + "'" + lstKey[i].ToString() + "'";
else strKeyList +=  "," + "'" + lstKey[i].ToString() + "'";
}
strSQL = "";
//删除qa_Answer本表中与当前对象有关的记录
strSQL = strSQL + "Delete from qa_Answer where AnswerId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strAnswerId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strAnswerId) 
{
CheckPrimaryKey(strAnswerId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_AnswerDA.GetSpecSQLObj();
//删除qa_Answer本表中与当前对象有关的记录
strSQL = strSQL + "Delete from qa_Answer where AnswerId = " + "'"+ strAnswerId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delqa_Answer(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsqa_AnswerDA: Delqa_Answer)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_AnswerDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from qa_Answer where " + strCondition ;
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
public bool Delqa_AnswerWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsqa_AnswerDA: Delqa_AnswerWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_AnswerDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from qa_Answer where " + strCondition ;
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
 /// <param name = "objqa_AnswerENS">源对象</param>
 /// <param name = "objqa_AnswerENT">目标对象</param>
public void CopyTo(clsqa_AnswerEN objqa_AnswerENS, clsqa_AnswerEN objqa_AnswerENT)
{
objqa_AnswerENT.AnswerId = objqa_AnswerENS.AnswerId; //回答Id
objqa_AnswerENT.QuestionsId = objqa_AnswerENS.QuestionsId; //提问Id
objqa_AnswerENT.AnswerContent = objqa_AnswerENS.AnswerContent; //答案内容
objqa_AnswerENT.Score = objqa_AnswerENS.Score; //评分
objqa_AnswerENT.ScoreType = objqa_AnswerENS.ScoreType; //评分类型
objqa_AnswerENT.IsRight = objqa_AnswerENS.IsRight; //是否正确
objqa_AnswerENT.ParentId = objqa_AnswerENS.ParentId; //父节点Id
objqa_AnswerENT.VoteCount = objqa_AnswerENS.VoteCount; //点赞计数
objqa_AnswerENT.IsRecommend = objqa_AnswerENS.IsRecommend; //是否推荐
objqa_AnswerENT.TopicId = objqa_AnswerENS.TopicId; //主题Id
objqa_AnswerENT.AnswerTypeId = objqa_AnswerENS.AnswerTypeId; //答案类型ID
objqa_AnswerENT.IsSubmit = objqa_AnswerENS.IsSubmit; //是否提交
objqa_AnswerENT.AppraiseCount = objqa_AnswerENS.AppraiseCount; //评论数
objqa_AnswerENT.StuScore = objqa_AnswerENS.StuScore; //学生平均分
objqa_AnswerENT.TeaScore = objqa_AnswerENS.TeaScore; //教师评分
objqa_AnswerENT.CreateDate = objqa_AnswerENS.CreateDate; //建立日期
objqa_AnswerENT.IdCurrEduCls = objqa_AnswerENS.IdCurrEduCls; //教学班流水号
objqa_AnswerENT.UpdUser = objqa_AnswerENS.UpdUser; //修改人
objqa_AnswerENT.UpdDate = objqa_AnswerENS.UpdDate; //修改日期
objqa_AnswerENT.Memo = objqa_AnswerENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsqa_AnswerEN objqa_AnswerEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objqa_AnswerEN.QuestionsId, conqa_Answer.QuestionsId);
//检查字段长度
clsCheckSql.CheckFieldLen(objqa_AnswerEN.AnswerId, 10, conqa_Answer.AnswerId);
clsCheckSql.CheckFieldLen(objqa_AnswerEN.QuestionsId, 8, conqa_Answer.QuestionsId);
clsCheckSql.CheckFieldLen(objqa_AnswerEN.ScoreType, 1, conqa_Answer.ScoreType);
clsCheckSql.CheckFieldLen(objqa_AnswerEN.ParentId, 10, conqa_Answer.ParentId);
clsCheckSql.CheckFieldLen(objqa_AnswerEN.TopicId, 8, conqa_Answer.TopicId);
clsCheckSql.CheckFieldLen(objqa_AnswerEN.AnswerTypeId, 2, conqa_Answer.AnswerTypeId);
clsCheckSql.CheckFieldLen(objqa_AnswerEN.CreateDate, 20, conqa_Answer.CreateDate);
clsCheckSql.CheckFieldLen(objqa_AnswerEN.IdCurrEduCls, 8, conqa_Answer.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objqa_AnswerEN.UpdUser, 20, conqa_Answer.UpdUser);
clsCheckSql.CheckFieldLen(objqa_AnswerEN.UpdDate, 20, conqa_Answer.UpdDate);
clsCheckSql.CheckFieldLen(objqa_AnswerEN.Memo, 1000, conqa_Answer.Memo);
//检查字段外键固定长度
 objqa_AnswerEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsqa_AnswerEN objqa_AnswerEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objqa_AnswerEN.QuestionsId, 8, conqa_Answer.QuestionsId);
clsCheckSql.CheckFieldLen(objqa_AnswerEN.ScoreType, 1, conqa_Answer.ScoreType);
clsCheckSql.CheckFieldLen(objqa_AnswerEN.ParentId, 10, conqa_Answer.ParentId);
clsCheckSql.CheckFieldLen(objqa_AnswerEN.TopicId, 8, conqa_Answer.TopicId);
clsCheckSql.CheckFieldLen(objqa_AnswerEN.AnswerTypeId, 2, conqa_Answer.AnswerTypeId);
clsCheckSql.CheckFieldLen(objqa_AnswerEN.CreateDate, 20, conqa_Answer.CreateDate);
clsCheckSql.CheckFieldLen(objqa_AnswerEN.IdCurrEduCls, 8, conqa_Answer.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objqa_AnswerEN.UpdUser, 20, conqa_Answer.UpdUser);
clsCheckSql.CheckFieldLen(objqa_AnswerEN.UpdDate, 20, conqa_Answer.UpdDate);
clsCheckSql.CheckFieldLen(objqa_AnswerEN.Memo, 1000, conqa_Answer.Memo);
//检查外键字段长度
 objqa_AnswerEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsqa_AnswerEN objqa_AnswerEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objqa_AnswerEN.AnswerId, 10, conqa_Answer.AnswerId);
clsCheckSql.CheckFieldLen(objqa_AnswerEN.QuestionsId, 8, conqa_Answer.QuestionsId);
clsCheckSql.CheckFieldLen(objqa_AnswerEN.ScoreType, 1, conqa_Answer.ScoreType);
clsCheckSql.CheckFieldLen(objqa_AnswerEN.ParentId, 10, conqa_Answer.ParentId);
clsCheckSql.CheckFieldLen(objqa_AnswerEN.TopicId, 8, conqa_Answer.TopicId);
clsCheckSql.CheckFieldLen(objqa_AnswerEN.AnswerTypeId, 2, conqa_Answer.AnswerTypeId);
clsCheckSql.CheckFieldLen(objqa_AnswerEN.CreateDate, 20, conqa_Answer.CreateDate);
clsCheckSql.CheckFieldLen(objqa_AnswerEN.IdCurrEduCls, 8, conqa_Answer.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objqa_AnswerEN.UpdUser, 20, conqa_Answer.UpdUser);
clsCheckSql.CheckFieldLen(objqa_AnswerEN.UpdDate, 20, conqa_Answer.UpdDate);
clsCheckSql.CheckFieldLen(objqa_AnswerEN.Memo, 1000, conqa_Answer.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objqa_AnswerEN.AnswerId, conqa_Answer.AnswerId);
clsCheckSql.CheckSqlInjection4Field(objqa_AnswerEN.QuestionsId, conqa_Answer.QuestionsId);
clsCheckSql.CheckSqlInjection4Field(objqa_AnswerEN.ScoreType, conqa_Answer.ScoreType);
clsCheckSql.CheckSqlInjection4Field(objqa_AnswerEN.ParentId, conqa_Answer.ParentId);
clsCheckSql.CheckSqlInjection4Field(objqa_AnswerEN.TopicId, conqa_Answer.TopicId);
clsCheckSql.CheckSqlInjection4Field(objqa_AnswerEN.AnswerTypeId, conqa_Answer.AnswerTypeId);
clsCheckSql.CheckSqlInjection4Field(objqa_AnswerEN.CreateDate, conqa_Answer.CreateDate);
clsCheckSql.CheckSqlInjection4Field(objqa_AnswerEN.IdCurrEduCls, conqa_Answer.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objqa_AnswerEN.UpdUser, conqa_Answer.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objqa_AnswerEN.UpdDate, conqa_Answer.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objqa_AnswerEN.Memo, conqa_Answer.Memo);
//检查外键字段长度
 objqa_AnswerEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--qa_Answer(答疑回答),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objqa_AnswerEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsqa_AnswerEN objqa_AnswerEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 if (objqa_AnswerEN.AnswerContent == null)
{
 sbCondition.AppendFormat(" and AnswerContent is null");
}
else
{
 sbCondition.AppendFormat(" and AnswerContent = '{0}'", objqa_AnswerEN.AnswerContent);
}
 sbCondition.AppendFormat(" and QuestionsId = '{0}'", objqa_AnswerEN.QuestionsId);
 if (objqa_AnswerEN.UpdUser == null)
{
 sbCondition.AppendFormat(" and UpdUser is null");
}
else
{
 sbCondition.AppendFormat(" and UpdUser = '{0}'", objqa_AnswerEN.UpdUser);
}
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
 objSQL = clsqa_AnswerDA.GetSpecSQLObj();
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
 objSQL = clsqa_AnswerDA.GetSpecSQLObj();
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
 objSQL = clsqa_AnswerDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsqa_AnswerEN._CurrTabName);
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
 objSQL = clsqa_AnswerDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsqa_AnswerEN._CurrTabName, strCondition);
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
 objSQL = clsqa_AnswerDA.GetSpecSQLObj();
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
 objSQL = clsqa_AnswerDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}