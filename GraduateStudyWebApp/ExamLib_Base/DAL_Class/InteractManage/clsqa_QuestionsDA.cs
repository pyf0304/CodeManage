
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsqa_QuestionsDA
 表名:qa_Questions(01120642)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:13:23
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
 /// 答疑提问表(qa_Questions)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsqa_QuestionsDA : clsCommBase4DA
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
 return clsqa_QuestionsEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsqa_QuestionsEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsqa_QuestionsEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsqa_QuestionsEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsqa_QuestionsEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strQuestionsId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strQuestionsId)
{
strQuestionsId = strQuestionsId.Replace("'", "''");
if (strQuestionsId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:qa_Questions中,检查关键字,长度不正确!(clsqa_QuestionsDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strQuestionsId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:qa_Questions中,关键字不能为空 或 null!(clsqa_QuestionsDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strQuestionsId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsqa_QuestionsDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsqa_QuestionsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_QuestionsDA.GetSpecSQLObj();
strSQL = "Select * from qa_Questions where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_qa_Questions(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsqa_QuestionsDA: GetDataTable_qa_Questions)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_QuestionsDA.GetSpecSQLObj();
strSQL = "Select * from qa_Questions where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsqa_QuestionsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_QuestionsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsqa_QuestionsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_QuestionsDA.GetSpecSQLObj();
strSQL = "Select * from qa_Questions where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsqa_QuestionsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_QuestionsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsqa_QuestionsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_QuestionsDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from qa_Questions where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from qa_Questions where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsqa_QuestionsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_QuestionsDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from qa_Questions where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsqa_QuestionsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_QuestionsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} qa_Questions.* from qa_Questions Left Join {1} on {2} where {3} and qa_Questions.QuestionsId not in (Select top {5} qa_Questions.QuestionsId from qa_Questions Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from qa_Questions where {1} and QuestionsId not in (Select top {2} QuestionsId from qa_Questions where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from qa_Questions where {1} and QuestionsId not in (Select top {3} QuestionsId from qa_Questions where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsqa_QuestionsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_QuestionsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} qa_Questions.* from qa_Questions Left Join {1} on {2} where {3} and qa_Questions.QuestionsId not in (Select top {5} qa_Questions.QuestionsId from qa_Questions Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from qa_Questions where {1} and QuestionsId not in (Select top {2} QuestionsId from qa_Questions where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from qa_Questions where {1} and QuestionsId not in (Select top {3} QuestionsId from qa_Questions where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsqa_QuestionsEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsqa_QuestionsDA:GetObjLst)", objException.Message));
}
List<clsqa_QuestionsEN> arrObjLst = new List<clsqa_QuestionsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_QuestionsDA.GetSpecSQLObj();
strSQL = "Select * from qa_Questions where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsqa_QuestionsEN objqa_QuestionsEN = new clsqa_QuestionsEN();
try
{
objqa_QuestionsEN.QuestionsId = objRow[conqa_Questions.QuestionsId].ToString().Trim(); //提问Id
objqa_QuestionsEN.QaPaperId = objRow[conqa_Questions.QaPaperId] == DBNull.Value ? null : objRow[conqa_Questions.QaPaperId].ToString().Trim(); //论文答疑Id
objqa_QuestionsEN.QuestionsContent = objRow[conqa_Questions.QuestionsContent] == DBNull.Value ? null : objRow[conqa_Questions.QuestionsContent].ToString().Trim(); //提问内容
objqa_QuestionsEN.PdfContent = objRow[conqa_Questions.PdfContent] == DBNull.Value ? null : objRow[conqa_Questions.PdfContent].ToString().Trim(); //Pdf内容
objqa_QuestionsEN.PdfPageNum = objRow[conqa_Questions.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conqa_Questions.PdfPageNum].ToString().Trim()); //Pdf页码
objqa_QuestionsEN.IsDelete = TransNullToBool(objRow[conqa_Questions.IsDelete].ToString().Trim()); //是否删除
objqa_QuestionsEN.IsPublic = TransNullToBool(objRow[conqa_Questions.IsPublic].ToString().Trim()); //是否公开
objqa_QuestionsEN.IsEnd = TransNullToBool(objRow[conqa_Questions.IsEnd].ToString().Trim()); //是否结束
objqa_QuestionsEN.VoteCount = objRow[conqa_Questions.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conqa_Questions.VoteCount].ToString().Trim()); //点赞计数
objqa_QuestionsEN.AnswerCount = objRow[conqa_Questions.AnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conqa_Questions.AnswerCount].ToString().Trim()); //回答计数
objqa_QuestionsEN.OrderNum = objRow[conqa_Questions.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conqa_Questions.OrderNum].ToString().Trim()); //序号
objqa_QuestionsEN.UpdUser = objRow[conqa_Questions.UpdUser] == DBNull.Value ? null : objRow[conqa_Questions.UpdUser].ToString().Trim(); //修改人
objqa_QuestionsEN.UpdDate = objRow[conqa_Questions.UpdDate] == DBNull.Value ? null : objRow[conqa_Questions.UpdDate].ToString().Trim(); //修改日期
objqa_QuestionsEN.Memo = objRow[conqa_Questions.Memo] == DBNull.Value ? null : objRow[conqa_Questions.Memo].ToString().Trim(); //备注
objqa_QuestionsEN.PdfDivLet = objRow[conqa_Questions.PdfDivLet] == DBNull.Value ? null : objRow[conqa_Questions.PdfDivLet].ToString().Trim(); //PdfDivLet
objqa_QuestionsEN.PdfDivTop = objRow[conqa_Questions.PdfDivTop] == DBNull.Value ? null : objRow[conqa_Questions.PdfDivTop].ToString().Trim(); //PdfDivTop
objqa_QuestionsEN.PdfPageNumIn = objRow[conqa_Questions.PdfPageNumIn] == DBNull.Value ? null : objRow[conqa_Questions.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objqa_QuestionsEN.PdfPageTop = objRow[conqa_Questions.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conqa_Questions.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objqa_QuestionsEN.PdfZoom = objRow[conqa_Questions.PdfZoom] == DBNull.Value ? null : objRow[conqa_Questions.PdfZoom].ToString().Trim(); //PdfZoom
objqa_QuestionsEN.PaperId = objRow[conqa_Questions.PaperId] == DBNull.Value ? null : objRow[conqa_Questions.PaperId].ToString().Trim(); //论文Id
objqa_QuestionsEN.UserId = objRow[conqa_Questions.UserId] == DBNull.Value ? null : objRow[conqa_Questions.UserId].ToString().Trim(); //用户ID
objqa_QuestionsEN.QuestionsTypeId = objRow[conqa_Questions.QuestionsTypeId] == DBNull.Value ? null : objRow[conqa_Questions.QuestionsTypeId].ToString().Trim(); //问题类型Id
objqa_QuestionsEN.DiscussCount = objRow[conqa_Questions.DiscussCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conqa_Questions.DiscussCount].ToString().Trim()); //DiscussCount
objqa_QuestionsEN.GroupDiscussCount = objRow[conqa_Questions.GroupDiscussCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conqa_Questions.GroupDiscussCount].ToString().Trim()); //GroupDiscussCount
objqa_QuestionsEN.RecommendAnswerCount = objRow[conqa_Questions.RecommendAnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conqa_Questions.RecommendAnswerCount].ToString().Trim()); //RecommendAnswerCount
objqa_QuestionsEN.CreateDate = objRow[conqa_Questions.CreateDate] == DBNull.Value ? null : objRow[conqa_Questions.CreateDate].ToString().Trim(); //建立日期
objqa_QuestionsEN.IdCurrEduCls = objRow[conqa_Questions.IdCurrEduCls] == DBNull.Value ? null : objRow[conqa_Questions.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsqa_QuestionsDA: GetObjLst)", objException.Message));
}
objqa_QuestionsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objqa_QuestionsEN);
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
public List<clsqa_QuestionsEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsqa_QuestionsDA:GetObjLstByTabName)", objException.Message));
}
List<clsqa_QuestionsEN> arrObjLst = new List<clsqa_QuestionsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_QuestionsDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsqa_QuestionsEN objqa_QuestionsEN = new clsqa_QuestionsEN();
try
{
objqa_QuestionsEN.QuestionsId = objRow[conqa_Questions.QuestionsId].ToString().Trim(); //提问Id
objqa_QuestionsEN.QaPaperId = objRow[conqa_Questions.QaPaperId] == DBNull.Value ? null : objRow[conqa_Questions.QaPaperId].ToString().Trim(); //论文答疑Id
objqa_QuestionsEN.QuestionsContent = objRow[conqa_Questions.QuestionsContent] == DBNull.Value ? null : objRow[conqa_Questions.QuestionsContent].ToString().Trim(); //提问内容
objqa_QuestionsEN.PdfContent = objRow[conqa_Questions.PdfContent] == DBNull.Value ? null : objRow[conqa_Questions.PdfContent].ToString().Trim(); //Pdf内容
objqa_QuestionsEN.PdfPageNum = objRow[conqa_Questions.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conqa_Questions.PdfPageNum].ToString().Trim()); //Pdf页码
objqa_QuestionsEN.IsDelete = TransNullToBool(objRow[conqa_Questions.IsDelete].ToString().Trim()); //是否删除
objqa_QuestionsEN.IsPublic = TransNullToBool(objRow[conqa_Questions.IsPublic].ToString().Trim()); //是否公开
objqa_QuestionsEN.IsEnd = TransNullToBool(objRow[conqa_Questions.IsEnd].ToString().Trim()); //是否结束
objqa_QuestionsEN.VoteCount = objRow[conqa_Questions.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conqa_Questions.VoteCount].ToString().Trim()); //点赞计数
objqa_QuestionsEN.AnswerCount = objRow[conqa_Questions.AnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conqa_Questions.AnswerCount].ToString().Trim()); //回答计数
objqa_QuestionsEN.OrderNum = objRow[conqa_Questions.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conqa_Questions.OrderNum].ToString().Trim()); //序号
objqa_QuestionsEN.UpdUser = objRow[conqa_Questions.UpdUser] == DBNull.Value ? null : objRow[conqa_Questions.UpdUser].ToString().Trim(); //修改人
objqa_QuestionsEN.UpdDate = objRow[conqa_Questions.UpdDate] == DBNull.Value ? null : objRow[conqa_Questions.UpdDate].ToString().Trim(); //修改日期
objqa_QuestionsEN.Memo = objRow[conqa_Questions.Memo] == DBNull.Value ? null : objRow[conqa_Questions.Memo].ToString().Trim(); //备注
objqa_QuestionsEN.PdfDivLet = objRow[conqa_Questions.PdfDivLet] == DBNull.Value ? null : objRow[conqa_Questions.PdfDivLet].ToString().Trim(); //PdfDivLet
objqa_QuestionsEN.PdfDivTop = objRow[conqa_Questions.PdfDivTop] == DBNull.Value ? null : objRow[conqa_Questions.PdfDivTop].ToString().Trim(); //PdfDivTop
objqa_QuestionsEN.PdfPageNumIn = objRow[conqa_Questions.PdfPageNumIn] == DBNull.Value ? null : objRow[conqa_Questions.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objqa_QuestionsEN.PdfPageTop = objRow[conqa_Questions.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conqa_Questions.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objqa_QuestionsEN.PdfZoom = objRow[conqa_Questions.PdfZoom] == DBNull.Value ? null : objRow[conqa_Questions.PdfZoom].ToString().Trim(); //PdfZoom
objqa_QuestionsEN.PaperId = objRow[conqa_Questions.PaperId] == DBNull.Value ? null : objRow[conqa_Questions.PaperId].ToString().Trim(); //论文Id
objqa_QuestionsEN.UserId = objRow[conqa_Questions.UserId] == DBNull.Value ? null : objRow[conqa_Questions.UserId].ToString().Trim(); //用户ID
objqa_QuestionsEN.QuestionsTypeId = objRow[conqa_Questions.QuestionsTypeId] == DBNull.Value ? null : objRow[conqa_Questions.QuestionsTypeId].ToString().Trim(); //问题类型Id
objqa_QuestionsEN.DiscussCount = objRow[conqa_Questions.DiscussCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conqa_Questions.DiscussCount].ToString().Trim()); //DiscussCount
objqa_QuestionsEN.GroupDiscussCount = objRow[conqa_Questions.GroupDiscussCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conqa_Questions.GroupDiscussCount].ToString().Trim()); //GroupDiscussCount
objqa_QuestionsEN.RecommendAnswerCount = objRow[conqa_Questions.RecommendAnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conqa_Questions.RecommendAnswerCount].ToString().Trim()); //RecommendAnswerCount
objqa_QuestionsEN.CreateDate = objRow[conqa_Questions.CreateDate] == DBNull.Value ? null : objRow[conqa_Questions.CreateDate].ToString().Trim(); //建立日期
objqa_QuestionsEN.IdCurrEduCls = objRow[conqa_Questions.IdCurrEduCls] == DBNull.Value ? null : objRow[conqa_Questions.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsqa_QuestionsDA: GetObjLst)", objException.Message));
}
objqa_QuestionsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objqa_QuestionsEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objqa_QuestionsEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getqa_Questions(ref clsqa_QuestionsEN objqa_QuestionsEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_QuestionsDA.GetSpecSQLObj();
strSQL = "Select * from qa_Questions where QuestionsId = " + "'"+ objqa_QuestionsEN.QuestionsId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objqa_QuestionsEN.QuestionsId = objDT.Rows[0][conqa_Questions.QuestionsId].ToString().Trim(); //提问Id(字段类型:char,字段长度:8,是否可空:False)
 objqa_QuestionsEN.QaPaperId = objDT.Rows[0][conqa_Questions.QaPaperId].ToString().Trim(); //论文答疑Id(字段类型:char,字段长度:8,是否可空:False)
 objqa_QuestionsEN.QuestionsContent = objDT.Rows[0][conqa_Questions.QuestionsContent].ToString().Trim(); //提问内容(字段类型:varchar,字段长度:1000,是否可空:True)
 objqa_QuestionsEN.PdfContent = objDT.Rows[0][conqa_Questions.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objqa_QuestionsEN.PdfPageNum = TransNullToInt(objDT.Rows[0][conqa_Questions.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objqa_QuestionsEN.IsDelete = TransNullToBool(objDT.Rows[0][conqa_Questions.IsDelete].ToString().Trim()); //是否删除(字段类型:bit,字段长度:1,是否可空:True)
 objqa_QuestionsEN.IsPublic = TransNullToBool(objDT.Rows[0][conqa_Questions.IsPublic].ToString().Trim()); //是否公开(字段类型:bit,字段长度:1,是否可空:True)
 objqa_QuestionsEN.IsEnd = TransNullToBool(objDT.Rows[0][conqa_Questions.IsEnd].ToString().Trim()); //是否结束(字段类型:bit,字段长度:1,是否可空:True)
 objqa_QuestionsEN.VoteCount = TransNullToInt(objDT.Rows[0][conqa_Questions.VoteCount].ToString().Trim()); //点赞计数(字段类型:int,字段长度:4,是否可空:True)
 objqa_QuestionsEN.AnswerCount = TransNullToInt(objDT.Rows[0][conqa_Questions.AnswerCount].ToString().Trim()); //回答计数(字段类型:int,字段长度:4,是否可空:True)
 objqa_QuestionsEN.OrderNum = TransNullToInt(objDT.Rows[0][conqa_Questions.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objqa_QuestionsEN.UpdUser = objDT.Rows[0][conqa_Questions.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objqa_QuestionsEN.UpdDate = objDT.Rows[0][conqa_Questions.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objqa_QuestionsEN.Memo = objDT.Rows[0][conqa_Questions.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objqa_QuestionsEN.PdfDivLet = objDT.Rows[0][conqa_Questions.PdfDivLet].ToString().Trim(); //PdfDivLet(字段类型:varchar,字段长度:50,是否可空:True)
 objqa_QuestionsEN.PdfDivTop = objDT.Rows[0][conqa_Questions.PdfDivTop].ToString().Trim(); //PdfDivTop(字段类型:varchar,字段长度:50,是否可空:True)
 objqa_QuestionsEN.PdfPageNumIn = objDT.Rows[0][conqa_Questions.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn(字段类型:varchar,字段长度:50,是否可空:True)
 objqa_QuestionsEN.PdfPageTop = TransNullToInt(objDT.Rows[0][conqa_Questions.PdfPageTop].ToString().Trim()); //pdf页面顶部位置(字段类型:int,字段长度:4,是否可空:True)
 objqa_QuestionsEN.PdfZoom = objDT.Rows[0][conqa_Questions.PdfZoom].ToString().Trim(); //PdfZoom(字段类型:varchar,字段长度:50,是否可空:True)
 objqa_QuestionsEN.PaperId = objDT.Rows[0][conqa_Questions.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objqa_QuestionsEN.UserId = objDT.Rows[0][conqa_Questions.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objqa_QuestionsEN.QuestionsTypeId = objDT.Rows[0][conqa_Questions.QuestionsTypeId].ToString().Trim(); //问题类型Id(字段类型:char,字段长度:2,是否可空:False)
 objqa_QuestionsEN.DiscussCount = TransNullToInt(objDT.Rows[0][conqa_Questions.DiscussCount].ToString().Trim()); //DiscussCount(字段类型:int,字段长度:4,是否可空:True)
 objqa_QuestionsEN.GroupDiscussCount = TransNullToInt(objDT.Rows[0][conqa_Questions.GroupDiscussCount].ToString().Trim()); //GroupDiscussCount(字段类型:int,字段长度:4,是否可空:True)
 objqa_QuestionsEN.RecommendAnswerCount = TransNullToInt(objDT.Rows[0][conqa_Questions.RecommendAnswerCount].ToString().Trim()); //RecommendAnswerCount(字段类型:int,字段长度:4,是否可空:True)
 objqa_QuestionsEN.CreateDate = objDT.Rows[0][conqa_Questions.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objqa_QuestionsEN.IdCurrEduCls = objDT.Rows[0][conqa_Questions.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsqa_QuestionsDA: Getqa_Questions)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strQuestionsId">表关键字</param>
 /// <returns>表对象</returns>
public clsqa_QuestionsEN GetObjByQuestionsId(string strQuestionsId)
{
CheckPrimaryKey(strQuestionsId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_QuestionsDA.GetSpecSQLObj();
strSQL = "Select * from qa_Questions where QuestionsId = " + "'"+ strQuestionsId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsqa_QuestionsEN objqa_QuestionsEN = new clsqa_QuestionsEN();
try
{
 objqa_QuestionsEN.QuestionsId = objRow[conqa_Questions.QuestionsId].ToString().Trim(); //提问Id(字段类型:char,字段长度:8,是否可空:False)
 objqa_QuestionsEN.QaPaperId = objRow[conqa_Questions.QaPaperId] == DBNull.Value ? null : objRow[conqa_Questions.QaPaperId].ToString().Trim(); //论文答疑Id(字段类型:char,字段长度:8,是否可空:False)
 objqa_QuestionsEN.QuestionsContent = objRow[conqa_Questions.QuestionsContent] == DBNull.Value ? null : objRow[conqa_Questions.QuestionsContent].ToString().Trim(); //提问内容(字段类型:varchar,字段长度:1000,是否可空:True)
 objqa_QuestionsEN.PdfContent = objRow[conqa_Questions.PdfContent] == DBNull.Value ? null : objRow[conqa_Questions.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objqa_QuestionsEN.PdfPageNum = objRow[conqa_Questions.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conqa_Questions.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objqa_QuestionsEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[conqa_Questions.IsDelete].ToString().Trim()); //是否删除(字段类型:bit,字段长度:1,是否可空:True)
 objqa_QuestionsEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conqa_Questions.IsPublic].ToString().Trim()); //是否公开(字段类型:bit,字段长度:1,是否可空:True)
 objqa_QuestionsEN.IsEnd = clsEntityBase2.TransNullToBool_S(objRow[conqa_Questions.IsEnd].ToString().Trim()); //是否结束(字段类型:bit,字段长度:1,是否可空:True)
 objqa_QuestionsEN.VoteCount = objRow[conqa_Questions.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conqa_Questions.VoteCount].ToString().Trim()); //点赞计数(字段类型:int,字段长度:4,是否可空:True)
 objqa_QuestionsEN.AnswerCount = objRow[conqa_Questions.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conqa_Questions.AnswerCount].ToString().Trim()); //回答计数(字段类型:int,字段长度:4,是否可空:True)
 objqa_QuestionsEN.OrderNum = objRow[conqa_Questions.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conqa_Questions.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objqa_QuestionsEN.UpdUser = objRow[conqa_Questions.UpdUser] == DBNull.Value ? null : objRow[conqa_Questions.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objqa_QuestionsEN.UpdDate = objRow[conqa_Questions.UpdDate] == DBNull.Value ? null : objRow[conqa_Questions.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objqa_QuestionsEN.Memo = objRow[conqa_Questions.Memo] == DBNull.Value ? null : objRow[conqa_Questions.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objqa_QuestionsEN.PdfDivLet = objRow[conqa_Questions.PdfDivLet] == DBNull.Value ? null : objRow[conqa_Questions.PdfDivLet].ToString().Trim(); //PdfDivLet(字段类型:varchar,字段长度:50,是否可空:True)
 objqa_QuestionsEN.PdfDivTop = objRow[conqa_Questions.PdfDivTop] == DBNull.Value ? null : objRow[conqa_Questions.PdfDivTop].ToString().Trim(); //PdfDivTop(字段类型:varchar,字段长度:50,是否可空:True)
 objqa_QuestionsEN.PdfPageNumIn = objRow[conqa_Questions.PdfPageNumIn] == DBNull.Value ? null : objRow[conqa_Questions.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn(字段类型:varchar,字段长度:50,是否可空:True)
 objqa_QuestionsEN.PdfPageTop = objRow[conqa_Questions.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conqa_Questions.PdfPageTop].ToString().Trim()); //pdf页面顶部位置(字段类型:int,字段长度:4,是否可空:True)
 objqa_QuestionsEN.PdfZoom = objRow[conqa_Questions.PdfZoom] == DBNull.Value ? null : objRow[conqa_Questions.PdfZoom].ToString().Trim(); //PdfZoom(字段类型:varchar,字段长度:50,是否可空:True)
 objqa_QuestionsEN.PaperId = objRow[conqa_Questions.PaperId] == DBNull.Value ? null : objRow[conqa_Questions.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objqa_QuestionsEN.UserId = objRow[conqa_Questions.UserId] == DBNull.Value ? null : objRow[conqa_Questions.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objqa_QuestionsEN.QuestionsTypeId = objRow[conqa_Questions.QuestionsTypeId] == DBNull.Value ? null : objRow[conqa_Questions.QuestionsTypeId].ToString().Trim(); //问题类型Id(字段类型:char,字段长度:2,是否可空:False)
 objqa_QuestionsEN.DiscussCount = objRow[conqa_Questions.DiscussCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conqa_Questions.DiscussCount].ToString().Trim()); //DiscussCount(字段类型:int,字段长度:4,是否可空:True)
 objqa_QuestionsEN.GroupDiscussCount = objRow[conqa_Questions.GroupDiscussCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conqa_Questions.GroupDiscussCount].ToString().Trim()); //GroupDiscussCount(字段类型:int,字段长度:4,是否可空:True)
 objqa_QuestionsEN.RecommendAnswerCount = objRow[conqa_Questions.RecommendAnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conqa_Questions.RecommendAnswerCount].ToString().Trim()); //RecommendAnswerCount(字段类型:int,字段长度:4,是否可空:True)
 objqa_QuestionsEN.CreateDate = objRow[conqa_Questions.CreateDate] == DBNull.Value ? null : objRow[conqa_Questions.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objqa_QuestionsEN.IdCurrEduCls = objRow[conqa_Questions.IdCurrEduCls] == DBNull.Value ? null : objRow[conqa_Questions.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsqa_QuestionsDA: GetObjByQuestionsId)", objException.Message));
}
return objqa_QuestionsEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsqa_QuestionsEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsqa_QuestionsDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_QuestionsDA.GetSpecSQLObj();
strSQL = "Select * from qa_Questions where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsqa_QuestionsEN objqa_QuestionsEN = new clsqa_QuestionsEN()
{
QuestionsId = objRow[conqa_Questions.QuestionsId].ToString().Trim(), //提问Id
QaPaperId = objRow[conqa_Questions.QaPaperId] == DBNull.Value ? null : objRow[conqa_Questions.QaPaperId].ToString().Trim(), //论文答疑Id
QuestionsContent = objRow[conqa_Questions.QuestionsContent] == DBNull.Value ? null : objRow[conqa_Questions.QuestionsContent].ToString().Trim(), //提问内容
PdfContent = objRow[conqa_Questions.PdfContent] == DBNull.Value ? null : objRow[conqa_Questions.PdfContent].ToString().Trim(), //Pdf内容
PdfPageNum = objRow[conqa_Questions.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conqa_Questions.PdfPageNum].ToString().Trim()), //Pdf页码
IsDelete = TransNullToBool(objRow[conqa_Questions.IsDelete].ToString().Trim()), //是否删除
IsPublic = TransNullToBool(objRow[conqa_Questions.IsPublic].ToString().Trim()), //是否公开
IsEnd = TransNullToBool(objRow[conqa_Questions.IsEnd].ToString().Trim()), //是否结束
VoteCount = objRow[conqa_Questions.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conqa_Questions.VoteCount].ToString().Trim()), //点赞计数
AnswerCount = objRow[conqa_Questions.AnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conqa_Questions.AnswerCount].ToString().Trim()), //回答计数
OrderNum = objRow[conqa_Questions.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conqa_Questions.OrderNum].ToString().Trim()), //序号
UpdUser = objRow[conqa_Questions.UpdUser] == DBNull.Value ? null : objRow[conqa_Questions.UpdUser].ToString().Trim(), //修改人
UpdDate = objRow[conqa_Questions.UpdDate] == DBNull.Value ? null : objRow[conqa_Questions.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[conqa_Questions.Memo] == DBNull.Value ? null : objRow[conqa_Questions.Memo].ToString().Trim(), //备注
PdfDivLet = objRow[conqa_Questions.PdfDivLet] == DBNull.Value ? null : objRow[conqa_Questions.PdfDivLet].ToString().Trim(), //PdfDivLet
PdfDivTop = objRow[conqa_Questions.PdfDivTop] == DBNull.Value ? null : objRow[conqa_Questions.PdfDivTop].ToString().Trim(), //PdfDivTop
PdfPageNumIn = objRow[conqa_Questions.PdfPageNumIn] == DBNull.Value ? null : objRow[conqa_Questions.PdfPageNumIn].ToString().Trim(), //PdfPageNumIn
PdfPageTop = objRow[conqa_Questions.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conqa_Questions.PdfPageTop].ToString().Trim()), //pdf页面顶部位置
PdfZoom = objRow[conqa_Questions.PdfZoom] == DBNull.Value ? null : objRow[conqa_Questions.PdfZoom].ToString().Trim(), //PdfZoom
PaperId = objRow[conqa_Questions.PaperId] == DBNull.Value ? null : objRow[conqa_Questions.PaperId].ToString().Trim(), //论文Id
UserId = objRow[conqa_Questions.UserId] == DBNull.Value ? null : objRow[conqa_Questions.UserId].ToString().Trim(), //用户ID
QuestionsTypeId = objRow[conqa_Questions.QuestionsTypeId] == DBNull.Value ? null : objRow[conqa_Questions.QuestionsTypeId].ToString().Trim(), //问题类型Id
DiscussCount = objRow[conqa_Questions.DiscussCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conqa_Questions.DiscussCount].ToString().Trim()), //DiscussCount
GroupDiscussCount = objRow[conqa_Questions.GroupDiscussCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conqa_Questions.GroupDiscussCount].ToString().Trim()), //GroupDiscussCount
RecommendAnswerCount = objRow[conqa_Questions.RecommendAnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conqa_Questions.RecommendAnswerCount].ToString().Trim()), //RecommendAnswerCount
CreateDate = objRow[conqa_Questions.CreateDate] == DBNull.Value ? null : objRow[conqa_Questions.CreateDate].ToString().Trim(), //建立日期
IdCurrEduCls = objRow[conqa_Questions.IdCurrEduCls] == DBNull.Value ? null : objRow[conqa_Questions.IdCurrEduCls].ToString().Trim() //教学班流水号
};
objqa_QuestionsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objqa_QuestionsEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsqa_QuestionsDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsqa_QuestionsEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsqa_QuestionsEN objqa_QuestionsEN = new clsqa_QuestionsEN();
try
{
objqa_QuestionsEN.QuestionsId = objRow[conqa_Questions.QuestionsId].ToString().Trim(); //提问Id
objqa_QuestionsEN.QaPaperId = objRow[conqa_Questions.QaPaperId] == DBNull.Value ? null : objRow[conqa_Questions.QaPaperId].ToString().Trim(); //论文答疑Id
objqa_QuestionsEN.QuestionsContent = objRow[conqa_Questions.QuestionsContent] == DBNull.Value ? null : objRow[conqa_Questions.QuestionsContent].ToString().Trim(); //提问内容
objqa_QuestionsEN.PdfContent = objRow[conqa_Questions.PdfContent] == DBNull.Value ? null : objRow[conqa_Questions.PdfContent].ToString().Trim(); //Pdf内容
objqa_QuestionsEN.PdfPageNum = objRow[conqa_Questions.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conqa_Questions.PdfPageNum].ToString().Trim()); //Pdf页码
objqa_QuestionsEN.IsDelete = TransNullToBool(objRow[conqa_Questions.IsDelete].ToString().Trim()); //是否删除
objqa_QuestionsEN.IsPublic = TransNullToBool(objRow[conqa_Questions.IsPublic].ToString().Trim()); //是否公开
objqa_QuestionsEN.IsEnd = TransNullToBool(objRow[conqa_Questions.IsEnd].ToString().Trim()); //是否结束
objqa_QuestionsEN.VoteCount = objRow[conqa_Questions.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conqa_Questions.VoteCount].ToString().Trim()); //点赞计数
objqa_QuestionsEN.AnswerCount = objRow[conqa_Questions.AnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conqa_Questions.AnswerCount].ToString().Trim()); //回答计数
objqa_QuestionsEN.OrderNum = objRow[conqa_Questions.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conqa_Questions.OrderNum].ToString().Trim()); //序号
objqa_QuestionsEN.UpdUser = objRow[conqa_Questions.UpdUser] == DBNull.Value ? null : objRow[conqa_Questions.UpdUser].ToString().Trim(); //修改人
objqa_QuestionsEN.UpdDate = objRow[conqa_Questions.UpdDate] == DBNull.Value ? null : objRow[conqa_Questions.UpdDate].ToString().Trim(); //修改日期
objqa_QuestionsEN.Memo = objRow[conqa_Questions.Memo] == DBNull.Value ? null : objRow[conqa_Questions.Memo].ToString().Trim(); //备注
objqa_QuestionsEN.PdfDivLet = objRow[conqa_Questions.PdfDivLet] == DBNull.Value ? null : objRow[conqa_Questions.PdfDivLet].ToString().Trim(); //PdfDivLet
objqa_QuestionsEN.PdfDivTop = objRow[conqa_Questions.PdfDivTop] == DBNull.Value ? null : objRow[conqa_Questions.PdfDivTop].ToString().Trim(); //PdfDivTop
objqa_QuestionsEN.PdfPageNumIn = objRow[conqa_Questions.PdfPageNumIn] == DBNull.Value ? null : objRow[conqa_Questions.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objqa_QuestionsEN.PdfPageTop = objRow[conqa_Questions.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conqa_Questions.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objqa_QuestionsEN.PdfZoom = objRow[conqa_Questions.PdfZoom] == DBNull.Value ? null : objRow[conqa_Questions.PdfZoom].ToString().Trim(); //PdfZoom
objqa_QuestionsEN.PaperId = objRow[conqa_Questions.PaperId] == DBNull.Value ? null : objRow[conqa_Questions.PaperId].ToString().Trim(); //论文Id
objqa_QuestionsEN.UserId = objRow[conqa_Questions.UserId] == DBNull.Value ? null : objRow[conqa_Questions.UserId].ToString().Trim(); //用户ID
objqa_QuestionsEN.QuestionsTypeId = objRow[conqa_Questions.QuestionsTypeId] == DBNull.Value ? null : objRow[conqa_Questions.QuestionsTypeId].ToString().Trim(); //问题类型Id
objqa_QuestionsEN.DiscussCount = objRow[conqa_Questions.DiscussCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conqa_Questions.DiscussCount].ToString().Trim()); //DiscussCount
objqa_QuestionsEN.GroupDiscussCount = objRow[conqa_Questions.GroupDiscussCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conqa_Questions.GroupDiscussCount].ToString().Trim()); //GroupDiscussCount
objqa_QuestionsEN.RecommendAnswerCount = objRow[conqa_Questions.RecommendAnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conqa_Questions.RecommendAnswerCount].ToString().Trim()); //RecommendAnswerCount
objqa_QuestionsEN.CreateDate = objRow[conqa_Questions.CreateDate] == DBNull.Value ? null : objRow[conqa_Questions.CreateDate].ToString().Trim(); //建立日期
objqa_QuestionsEN.IdCurrEduCls = objRow[conqa_Questions.IdCurrEduCls] == DBNull.Value ? null : objRow[conqa_Questions.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsqa_QuestionsDA: GetObjByDataRowqa_Questions)", objException.Message));
}
objqa_QuestionsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objqa_QuestionsEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsqa_QuestionsEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsqa_QuestionsEN objqa_QuestionsEN = new clsqa_QuestionsEN();
try
{
objqa_QuestionsEN.QuestionsId = objRow[conqa_Questions.QuestionsId].ToString().Trim(); //提问Id
objqa_QuestionsEN.QaPaperId = objRow[conqa_Questions.QaPaperId] == DBNull.Value ? null : objRow[conqa_Questions.QaPaperId].ToString().Trim(); //论文答疑Id
objqa_QuestionsEN.QuestionsContent = objRow[conqa_Questions.QuestionsContent] == DBNull.Value ? null : objRow[conqa_Questions.QuestionsContent].ToString().Trim(); //提问内容
objqa_QuestionsEN.PdfContent = objRow[conqa_Questions.PdfContent] == DBNull.Value ? null : objRow[conqa_Questions.PdfContent].ToString().Trim(); //Pdf内容
objqa_QuestionsEN.PdfPageNum = objRow[conqa_Questions.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conqa_Questions.PdfPageNum].ToString().Trim()); //Pdf页码
objqa_QuestionsEN.IsDelete = TransNullToBool(objRow[conqa_Questions.IsDelete].ToString().Trim()); //是否删除
objqa_QuestionsEN.IsPublic = TransNullToBool(objRow[conqa_Questions.IsPublic].ToString().Trim()); //是否公开
objqa_QuestionsEN.IsEnd = TransNullToBool(objRow[conqa_Questions.IsEnd].ToString().Trim()); //是否结束
objqa_QuestionsEN.VoteCount = objRow[conqa_Questions.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conqa_Questions.VoteCount].ToString().Trim()); //点赞计数
objqa_QuestionsEN.AnswerCount = objRow[conqa_Questions.AnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conqa_Questions.AnswerCount].ToString().Trim()); //回答计数
objqa_QuestionsEN.OrderNum = objRow[conqa_Questions.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conqa_Questions.OrderNum].ToString().Trim()); //序号
objqa_QuestionsEN.UpdUser = objRow[conqa_Questions.UpdUser] == DBNull.Value ? null : objRow[conqa_Questions.UpdUser].ToString().Trim(); //修改人
objqa_QuestionsEN.UpdDate = objRow[conqa_Questions.UpdDate] == DBNull.Value ? null : objRow[conqa_Questions.UpdDate].ToString().Trim(); //修改日期
objqa_QuestionsEN.Memo = objRow[conqa_Questions.Memo] == DBNull.Value ? null : objRow[conqa_Questions.Memo].ToString().Trim(); //备注
objqa_QuestionsEN.PdfDivLet = objRow[conqa_Questions.PdfDivLet] == DBNull.Value ? null : objRow[conqa_Questions.PdfDivLet].ToString().Trim(); //PdfDivLet
objqa_QuestionsEN.PdfDivTop = objRow[conqa_Questions.PdfDivTop] == DBNull.Value ? null : objRow[conqa_Questions.PdfDivTop].ToString().Trim(); //PdfDivTop
objqa_QuestionsEN.PdfPageNumIn = objRow[conqa_Questions.PdfPageNumIn] == DBNull.Value ? null : objRow[conqa_Questions.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objqa_QuestionsEN.PdfPageTop = objRow[conqa_Questions.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conqa_Questions.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objqa_QuestionsEN.PdfZoom = objRow[conqa_Questions.PdfZoom] == DBNull.Value ? null : objRow[conqa_Questions.PdfZoom].ToString().Trim(); //PdfZoom
objqa_QuestionsEN.PaperId = objRow[conqa_Questions.PaperId] == DBNull.Value ? null : objRow[conqa_Questions.PaperId].ToString().Trim(); //论文Id
objqa_QuestionsEN.UserId = objRow[conqa_Questions.UserId] == DBNull.Value ? null : objRow[conqa_Questions.UserId].ToString().Trim(); //用户ID
objqa_QuestionsEN.QuestionsTypeId = objRow[conqa_Questions.QuestionsTypeId] == DBNull.Value ? null : objRow[conqa_Questions.QuestionsTypeId].ToString().Trim(); //问题类型Id
objqa_QuestionsEN.DiscussCount = objRow[conqa_Questions.DiscussCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conqa_Questions.DiscussCount].ToString().Trim()); //DiscussCount
objqa_QuestionsEN.GroupDiscussCount = objRow[conqa_Questions.GroupDiscussCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conqa_Questions.GroupDiscussCount].ToString().Trim()); //GroupDiscussCount
objqa_QuestionsEN.RecommendAnswerCount = objRow[conqa_Questions.RecommendAnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conqa_Questions.RecommendAnswerCount].ToString().Trim()); //RecommendAnswerCount
objqa_QuestionsEN.CreateDate = objRow[conqa_Questions.CreateDate] == DBNull.Value ? null : objRow[conqa_Questions.CreateDate].ToString().Trim(); //建立日期
objqa_QuestionsEN.IdCurrEduCls = objRow[conqa_Questions.IdCurrEduCls] == DBNull.Value ? null : objRow[conqa_Questions.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsqa_QuestionsDA: GetObjByDataRow)", objException.Message));
}
objqa_QuestionsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objqa_QuestionsEN;
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
objSQL = clsqa_QuestionsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsqa_QuestionsEN._CurrTabName, conqa_Questions.QuestionsId, 8, "");
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
objSQL = clsqa_QuestionsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsqa_QuestionsEN._CurrTabName, conqa_Questions.QuestionsId, 8, strPrefix);
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
 objSQL = clsqa_QuestionsDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select QuestionsId from qa_Questions where " + strCondition;
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
 objSQL = clsqa_QuestionsDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select QuestionsId from qa_Questions where " + strCondition;
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
 /// <param name = "strQuestionsId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strQuestionsId)
{
CheckPrimaryKey(strQuestionsId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_QuestionsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("qa_Questions", "QuestionsId = " + "'"+ strQuestionsId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsqa_QuestionsDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_QuestionsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("qa_Questions", strCondition))
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
objSQL = clsqa_QuestionsDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("qa_Questions");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsqa_QuestionsEN objqa_QuestionsEN)
 {
 if (objqa_QuestionsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objqa_QuestionsEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_QuestionsDA.GetSpecSQLObj();
strSQL = "Select * from qa_Questions where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "qa_Questions");
objRow = objDS.Tables["qa_Questions"].NewRow();
objRow[conqa_Questions.QuestionsId] = objqa_QuestionsEN.QuestionsId; //提问Id
 if (objqa_QuestionsEN.QaPaperId !=  "")
 {
objRow[conqa_Questions.QaPaperId] = objqa_QuestionsEN.QaPaperId; //论文答疑Id
 }
 if (objqa_QuestionsEN.QuestionsContent !=  "")
 {
objRow[conqa_Questions.QuestionsContent] = objqa_QuestionsEN.QuestionsContent; //提问内容
 }
 if (objqa_QuestionsEN.PdfContent !=  "")
 {
objRow[conqa_Questions.PdfContent] = objqa_QuestionsEN.PdfContent; //Pdf内容
 }
objRow[conqa_Questions.PdfPageNum] = objqa_QuestionsEN.PdfPageNum; //Pdf页码
objRow[conqa_Questions.IsDelete] = objqa_QuestionsEN.IsDelete; //是否删除
objRow[conqa_Questions.IsPublic] = objqa_QuestionsEN.IsPublic; //是否公开
objRow[conqa_Questions.IsEnd] = objqa_QuestionsEN.IsEnd; //是否结束
objRow[conqa_Questions.VoteCount] = objqa_QuestionsEN.VoteCount; //点赞计数
objRow[conqa_Questions.AnswerCount] = objqa_QuestionsEN.AnswerCount; //回答计数
objRow[conqa_Questions.OrderNum] = objqa_QuestionsEN.OrderNum; //序号
 if (objqa_QuestionsEN.UpdUser !=  "")
 {
objRow[conqa_Questions.UpdUser] = objqa_QuestionsEN.UpdUser; //修改人
 }
 if (objqa_QuestionsEN.UpdDate !=  "")
 {
objRow[conqa_Questions.UpdDate] = objqa_QuestionsEN.UpdDate; //修改日期
 }
 if (objqa_QuestionsEN.Memo !=  "")
 {
objRow[conqa_Questions.Memo] = objqa_QuestionsEN.Memo; //备注
 }
 if (objqa_QuestionsEN.PdfDivLet !=  "")
 {
objRow[conqa_Questions.PdfDivLet] = objqa_QuestionsEN.PdfDivLet; //PdfDivLet
 }
 if (objqa_QuestionsEN.PdfDivTop !=  "")
 {
objRow[conqa_Questions.PdfDivTop] = objqa_QuestionsEN.PdfDivTop; //PdfDivTop
 }
 if (objqa_QuestionsEN.PdfPageNumIn !=  "")
 {
objRow[conqa_Questions.PdfPageNumIn] = objqa_QuestionsEN.PdfPageNumIn; //PdfPageNumIn
 }
objRow[conqa_Questions.PdfPageTop] = objqa_QuestionsEN.PdfPageTop; //pdf页面顶部位置
 if (objqa_QuestionsEN.PdfZoom !=  "")
 {
objRow[conqa_Questions.PdfZoom] = objqa_QuestionsEN.PdfZoom; //PdfZoom
 }
 if (objqa_QuestionsEN.PaperId !=  "")
 {
objRow[conqa_Questions.PaperId] = objqa_QuestionsEN.PaperId; //论文Id
 }
 if (objqa_QuestionsEN.UserId !=  "")
 {
objRow[conqa_Questions.UserId] = objqa_QuestionsEN.UserId; //用户ID
 }
 if (objqa_QuestionsEN.QuestionsTypeId !=  "")
 {
objRow[conqa_Questions.QuestionsTypeId] = objqa_QuestionsEN.QuestionsTypeId; //问题类型Id
 }
objRow[conqa_Questions.DiscussCount] = objqa_QuestionsEN.DiscussCount; //DiscussCount
objRow[conqa_Questions.GroupDiscussCount] = objqa_QuestionsEN.GroupDiscussCount; //GroupDiscussCount
objRow[conqa_Questions.RecommendAnswerCount] = objqa_QuestionsEN.RecommendAnswerCount; //RecommendAnswerCount
 if (objqa_QuestionsEN.CreateDate !=  "")
 {
objRow[conqa_Questions.CreateDate] = objqa_QuestionsEN.CreateDate; //建立日期
 }
 if (objqa_QuestionsEN.IdCurrEduCls !=  "")
 {
objRow[conqa_Questions.IdCurrEduCls] = objqa_QuestionsEN.IdCurrEduCls; //教学班流水号
 }
objDS.Tables[clsqa_QuestionsEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsqa_QuestionsEN._CurrTabName);
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
 /// <param name = "objqa_QuestionsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsqa_QuestionsEN objqa_QuestionsEN)
{
 if (objqa_QuestionsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objqa_QuestionsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objqa_QuestionsEN.QuestionsId !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.QuestionsId);
 var strQuestionsId = objqa_QuestionsEN.QuestionsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionsId + "'");
 }
 
 if (objqa_QuestionsEN.QaPaperId !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.QaPaperId);
 var strQaPaperId = objqa_QuestionsEN.QaPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQaPaperId + "'");
 }
 
 if (objqa_QuestionsEN.QuestionsContent !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.QuestionsContent);
 var strQuestionsContent = objqa_QuestionsEN.QuestionsContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionsContent + "'");
 }
 
 if (objqa_QuestionsEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.PdfContent);
 var strPdfContent = objqa_QuestionsEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objqa_QuestionsEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.PdfPageNum);
 arrValueListForInsert.Add(objqa_QuestionsEN.PdfPageNum.ToString());
 }
 
 arrFieldListForInsert.Add(conqa_Questions.IsDelete);
 arrValueListForInsert.Add("'" + (objqa_QuestionsEN.IsDelete  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conqa_Questions.IsPublic);
 arrValueListForInsert.Add("'" + (objqa_QuestionsEN.IsPublic  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conqa_Questions.IsEnd);
 arrValueListForInsert.Add("'" + (objqa_QuestionsEN.IsEnd  ==  false ? "0" : "1") + "'");
 
 if (objqa_QuestionsEN.VoteCount !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.VoteCount);
 arrValueListForInsert.Add(objqa_QuestionsEN.VoteCount.ToString());
 }
 
 if (objqa_QuestionsEN.AnswerCount !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.AnswerCount);
 arrValueListForInsert.Add(objqa_QuestionsEN.AnswerCount.ToString());
 }
 
 if (objqa_QuestionsEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.OrderNum);
 arrValueListForInsert.Add(objqa_QuestionsEN.OrderNum.ToString());
 }
 
 if (objqa_QuestionsEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.UpdUser);
 var strUpdUser = objqa_QuestionsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objqa_QuestionsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.UpdDate);
 var strUpdDate = objqa_QuestionsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objqa_QuestionsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.Memo);
 var strMemo = objqa_QuestionsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objqa_QuestionsEN.PdfDivLet !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.PdfDivLet);
 var strPdfDivLet = objqa_QuestionsEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivLet + "'");
 }
 
 if (objqa_QuestionsEN.PdfDivTop !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.PdfDivTop);
 var strPdfDivTop = objqa_QuestionsEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivTop + "'");
 }
 
 if (objqa_QuestionsEN.PdfPageNumIn !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.PdfPageNumIn);
 var strPdfPageNumIn = objqa_QuestionsEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfPageNumIn + "'");
 }
 
 if (objqa_QuestionsEN.PdfPageTop !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.PdfPageTop);
 arrValueListForInsert.Add(objqa_QuestionsEN.PdfPageTop.ToString());
 }
 
 if (objqa_QuestionsEN.PdfZoom !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.PdfZoom);
 var strPdfZoom = objqa_QuestionsEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfZoom + "'");
 }
 
 if (objqa_QuestionsEN.PaperId !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.PaperId);
 var strPaperId = objqa_QuestionsEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperId + "'");
 }
 
 if (objqa_QuestionsEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.UserId);
 var strUserId = objqa_QuestionsEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objqa_QuestionsEN.QuestionsTypeId !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.QuestionsTypeId);
 var strQuestionsTypeId = objqa_QuestionsEN.QuestionsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionsTypeId + "'");
 }
 
 if (objqa_QuestionsEN.DiscussCount !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.DiscussCount);
 arrValueListForInsert.Add(objqa_QuestionsEN.DiscussCount.ToString());
 }
 
 if (objqa_QuestionsEN.GroupDiscussCount !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.GroupDiscussCount);
 arrValueListForInsert.Add(objqa_QuestionsEN.GroupDiscussCount.ToString());
 }
 
 if (objqa_QuestionsEN.RecommendAnswerCount !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.RecommendAnswerCount);
 arrValueListForInsert.Add(objqa_QuestionsEN.RecommendAnswerCount.ToString());
 }
 
 if (objqa_QuestionsEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.CreateDate);
 var strCreateDate = objqa_QuestionsEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objqa_QuestionsEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.IdCurrEduCls);
 var strIdCurrEduCls = objqa_QuestionsEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into qa_Questions");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_QuestionsDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objqa_QuestionsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsqa_QuestionsEN objqa_QuestionsEN)
{
 if (objqa_QuestionsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objqa_QuestionsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objqa_QuestionsEN.QuestionsId !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.QuestionsId);
 var strQuestionsId = objqa_QuestionsEN.QuestionsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionsId + "'");
 }
 
 if (objqa_QuestionsEN.QaPaperId !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.QaPaperId);
 var strQaPaperId = objqa_QuestionsEN.QaPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQaPaperId + "'");
 }
 
 if (objqa_QuestionsEN.QuestionsContent !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.QuestionsContent);
 var strQuestionsContent = objqa_QuestionsEN.QuestionsContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionsContent + "'");
 }
 
 if (objqa_QuestionsEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.PdfContent);
 var strPdfContent = objqa_QuestionsEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objqa_QuestionsEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.PdfPageNum);
 arrValueListForInsert.Add(objqa_QuestionsEN.PdfPageNum.ToString());
 }
 
 arrFieldListForInsert.Add(conqa_Questions.IsDelete);
 arrValueListForInsert.Add("'" + (objqa_QuestionsEN.IsDelete  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conqa_Questions.IsPublic);
 arrValueListForInsert.Add("'" + (objqa_QuestionsEN.IsPublic  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conqa_Questions.IsEnd);
 arrValueListForInsert.Add("'" + (objqa_QuestionsEN.IsEnd  ==  false ? "0" : "1") + "'");
 
 if (objqa_QuestionsEN.VoteCount !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.VoteCount);
 arrValueListForInsert.Add(objqa_QuestionsEN.VoteCount.ToString());
 }
 
 if (objqa_QuestionsEN.AnswerCount !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.AnswerCount);
 arrValueListForInsert.Add(objqa_QuestionsEN.AnswerCount.ToString());
 }
 
 if (objqa_QuestionsEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.OrderNum);
 arrValueListForInsert.Add(objqa_QuestionsEN.OrderNum.ToString());
 }
 
 if (objqa_QuestionsEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.UpdUser);
 var strUpdUser = objqa_QuestionsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objqa_QuestionsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.UpdDate);
 var strUpdDate = objqa_QuestionsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objqa_QuestionsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.Memo);
 var strMemo = objqa_QuestionsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objqa_QuestionsEN.PdfDivLet !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.PdfDivLet);
 var strPdfDivLet = objqa_QuestionsEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivLet + "'");
 }
 
 if (objqa_QuestionsEN.PdfDivTop !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.PdfDivTop);
 var strPdfDivTop = objqa_QuestionsEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivTop + "'");
 }
 
 if (objqa_QuestionsEN.PdfPageNumIn !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.PdfPageNumIn);
 var strPdfPageNumIn = objqa_QuestionsEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfPageNumIn + "'");
 }
 
 if (objqa_QuestionsEN.PdfPageTop !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.PdfPageTop);
 arrValueListForInsert.Add(objqa_QuestionsEN.PdfPageTop.ToString());
 }
 
 if (objqa_QuestionsEN.PdfZoom !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.PdfZoom);
 var strPdfZoom = objqa_QuestionsEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfZoom + "'");
 }
 
 if (objqa_QuestionsEN.PaperId !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.PaperId);
 var strPaperId = objqa_QuestionsEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperId + "'");
 }
 
 if (objqa_QuestionsEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.UserId);
 var strUserId = objqa_QuestionsEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objqa_QuestionsEN.QuestionsTypeId !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.QuestionsTypeId);
 var strQuestionsTypeId = objqa_QuestionsEN.QuestionsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionsTypeId + "'");
 }
 
 if (objqa_QuestionsEN.DiscussCount !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.DiscussCount);
 arrValueListForInsert.Add(objqa_QuestionsEN.DiscussCount.ToString());
 }
 
 if (objqa_QuestionsEN.GroupDiscussCount !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.GroupDiscussCount);
 arrValueListForInsert.Add(objqa_QuestionsEN.GroupDiscussCount.ToString());
 }
 
 if (objqa_QuestionsEN.RecommendAnswerCount !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.RecommendAnswerCount);
 arrValueListForInsert.Add(objqa_QuestionsEN.RecommendAnswerCount.ToString());
 }
 
 if (objqa_QuestionsEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.CreateDate);
 var strCreateDate = objqa_QuestionsEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objqa_QuestionsEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.IdCurrEduCls);
 var strIdCurrEduCls = objqa_QuestionsEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into qa_Questions");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_QuestionsDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objqa_QuestionsEN.QuestionsId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objqa_QuestionsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsqa_QuestionsEN objqa_QuestionsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objqa_QuestionsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objqa_QuestionsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objqa_QuestionsEN.QuestionsId !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.QuestionsId);
 var strQuestionsId = objqa_QuestionsEN.QuestionsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionsId + "'");
 }
 
 if (objqa_QuestionsEN.QaPaperId !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.QaPaperId);
 var strQaPaperId = objqa_QuestionsEN.QaPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQaPaperId + "'");
 }
 
 if (objqa_QuestionsEN.QuestionsContent !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.QuestionsContent);
 var strQuestionsContent = objqa_QuestionsEN.QuestionsContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionsContent + "'");
 }
 
 if (objqa_QuestionsEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.PdfContent);
 var strPdfContent = objqa_QuestionsEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objqa_QuestionsEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.PdfPageNum);
 arrValueListForInsert.Add(objqa_QuestionsEN.PdfPageNum.ToString());
 }
 
 arrFieldListForInsert.Add(conqa_Questions.IsDelete);
 arrValueListForInsert.Add("'" + (objqa_QuestionsEN.IsDelete  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conqa_Questions.IsPublic);
 arrValueListForInsert.Add("'" + (objqa_QuestionsEN.IsPublic  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conqa_Questions.IsEnd);
 arrValueListForInsert.Add("'" + (objqa_QuestionsEN.IsEnd  ==  false ? "0" : "1") + "'");
 
 if (objqa_QuestionsEN.VoteCount !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.VoteCount);
 arrValueListForInsert.Add(objqa_QuestionsEN.VoteCount.ToString());
 }
 
 if (objqa_QuestionsEN.AnswerCount !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.AnswerCount);
 arrValueListForInsert.Add(objqa_QuestionsEN.AnswerCount.ToString());
 }
 
 if (objqa_QuestionsEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.OrderNum);
 arrValueListForInsert.Add(objqa_QuestionsEN.OrderNum.ToString());
 }
 
 if (objqa_QuestionsEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.UpdUser);
 var strUpdUser = objqa_QuestionsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objqa_QuestionsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.UpdDate);
 var strUpdDate = objqa_QuestionsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objqa_QuestionsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.Memo);
 var strMemo = objqa_QuestionsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objqa_QuestionsEN.PdfDivLet !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.PdfDivLet);
 var strPdfDivLet = objqa_QuestionsEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivLet + "'");
 }
 
 if (objqa_QuestionsEN.PdfDivTop !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.PdfDivTop);
 var strPdfDivTop = objqa_QuestionsEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivTop + "'");
 }
 
 if (objqa_QuestionsEN.PdfPageNumIn !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.PdfPageNumIn);
 var strPdfPageNumIn = objqa_QuestionsEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfPageNumIn + "'");
 }
 
 if (objqa_QuestionsEN.PdfPageTop !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.PdfPageTop);
 arrValueListForInsert.Add(objqa_QuestionsEN.PdfPageTop.ToString());
 }
 
 if (objqa_QuestionsEN.PdfZoom !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.PdfZoom);
 var strPdfZoom = objqa_QuestionsEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfZoom + "'");
 }
 
 if (objqa_QuestionsEN.PaperId !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.PaperId);
 var strPaperId = objqa_QuestionsEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperId + "'");
 }
 
 if (objqa_QuestionsEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.UserId);
 var strUserId = objqa_QuestionsEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objqa_QuestionsEN.QuestionsTypeId !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.QuestionsTypeId);
 var strQuestionsTypeId = objqa_QuestionsEN.QuestionsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionsTypeId + "'");
 }
 
 if (objqa_QuestionsEN.DiscussCount !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.DiscussCount);
 arrValueListForInsert.Add(objqa_QuestionsEN.DiscussCount.ToString());
 }
 
 if (objqa_QuestionsEN.GroupDiscussCount !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.GroupDiscussCount);
 arrValueListForInsert.Add(objqa_QuestionsEN.GroupDiscussCount.ToString());
 }
 
 if (objqa_QuestionsEN.RecommendAnswerCount !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.RecommendAnswerCount);
 arrValueListForInsert.Add(objqa_QuestionsEN.RecommendAnswerCount.ToString());
 }
 
 if (objqa_QuestionsEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.CreateDate);
 var strCreateDate = objqa_QuestionsEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objqa_QuestionsEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.IdCurrEduCls);
 var strIdCurrEduCls = objqa_QuestionsEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into qa_Questions");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_QuestionsDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objqa_QuestionsEN.QuestionsId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objqa_QuestionsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsqa_QuestionsEN objqa_QuestionsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objqa_QuestionsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objqa_QuestionsEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objqa_QuestionsEN.QuestionsId !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.QuestionsId);
 var strQuestionsId = objqa_QuestionsEN.QuestionsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionsId + "'");
 }
 
 if (objqa_QuestionsEN.QaPaperId !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.QaPaperId);
 var strQaPaperId = objqa_QuestionsEN.QaPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQaPaperId + "'");
 }
 
 if (objqa_QuestionsEN.QuestionsContent !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.QuestionsContent);
 var strQuestionsContent = objqa_QuestionsEN.QuestionsContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionsContent + "'");
 }
 
 if (objqa_QuestionsEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.PdfContent);
 var strPdfContent = objqa_QuestionsEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objqa_QuestionsEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.PdfPageNum);
 arrValueListForInsert.Add(objqa_QuestionsEN.PdfPageNum.ToString());
 }
 
 arrFieldListForInsert.Add(conqa_Questions.IsDelete);
 arrValueListForInsert.Add("'" + (objqa_QuestionsEN.IsDelete  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conqa_Questions.IsPublic);
 arrValueListForInsert.Add("'" + (objqa_QuestionsEN.IsPublic  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conqa_Questions.IsEnd);
 arrValueListForInsert.Add("'" + (objqa_QuestionsEN.IsEnd  ==  false ? "0" : "1") + "'");
 
 if (objqa_QuestionsEN.VoteCount !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.VoteCount);
 arrValueListForInsert.Add(objqa_QuestionsEN.VoteCount.ToString());
 }
 
 if (objqa_QuestionsEN.AnswerCount !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.AnswerCount);
 arrValueListForInsert.Add(objqa_QuestionsEN.AnswerCount.ToString());
 }
 
 if (objqa_QuestionsEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.OrderNum);
 arrValueListForInsert.Add(objqa_QuestionsEN.OrderNum.ToString());
 }
 
 if (objqa_QuestionsEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.UpdUser);
 var strUpdUser = objqa_QuestionsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objqa_QuestionsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.UpdDate);
 var strUpdDate = objqa_QuestionsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objqa_QuestionsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.Memo);
 var strMemo = objqa_QuestionsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objqa_QuestionsEN.PdfDivLet !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.PdfDivLet);
 var strPdfDivLet = objqa_QuestionsEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivLet + "'");
 }
 
 if (objqa_QuestionsEN.PdfDivTop !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.PdfDivTop);
 var strPdfDivTop = objqa_QuestionsEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivTop + "'");
 }
 
 if (objqa_QuestionsEN.PdfPageNumIn !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.PdfPageNumIn);
 var strPdfPageNumIn = objqa_QuestionsEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfPageNumIn + "'");
 }
 
 if (objqa_QuestionsEN.PdfPageTop !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.PdfPageTop);
 arrValueListForInsert.Add(objqa_QuestionsEN.PdfPageTop.ToString());
 }
 
 if (objqa_QuestionsEN.PdfZoom !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.PdfZoom);
 var strPdfZoom = objqa_QuestionsEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfZoom + "'");
 }
 
 if (objqa_QuestionsEN.PaperId !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.PaperId);
 var strPaperId = objqa_QuestionsEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperId + "'");
 }
 
 if (objqa_QuestionsEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.UserId);
 var strUserId = objqa_QuestionsEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objqa_QuestionsEN.QuestionsTypeId !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.QuestionsTypeId);
 var strQuestionsTypeId = objqa_QuestionsEN.QuestionsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionsTypeId + "'");
 }
 
 if (objqa_QuestionsEN.DiscussCount !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.DiscussCount);
 arrValueListForInsert.Add(objqa_QuestionsEN.DiscussCount.ToString());
 }
 
 if (objqa_QuestionsEN.GroupDiscussCount !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.GroupDiscussCount);
 arrValueListForInsert.Add(objqa_QuestionsEN.GroupDiscussCount.ToString());
 }
 
 if (objqa_QuestionsEN.RecommendAnswerCount !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.RecommendAnswerCount);
 arrValueListForInsert.Add(objqa_QuestionsEN.RecommendAnswerCount.ToString());
 }
 
 if (objqa_QuestionsEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.CreateDate);
 var strCreateDate = objqa_QuestionsEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objqa_QuestionsEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conqa_Questions.IdCurrEduCls);
 var strIdCurrEduCls = objqa_QuestionsEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into qa_Questions");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_QuestionsDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewqa_Questionss(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_QuestionsDA.GetSpecSQLObj();
strSQL = "Select * from qa_Questions where QuestionsId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "qa_Questions");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strQuestionsId = oRow[conqa_Questions.QuestionsId].ToString().Trim();
if (IsExist(strQuestionsId))
{
 string strResult = "关键字变量值为:" + string.Format("QuestionsId = {0}", strQuestionsId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsqa_QuestionsEN._CurrTabName ].NewRow();
objRow[conqa_Questions.QuestionsId] = oRow[conqa_Questions.QuestionsId].ToString().Trim(); //提问Id
objRow[conqa_Questions.QaPaperId] = oRow[conqa_Questions.QaPaperId].ToString().Trim(); //论文答疑Id
objRow[conqa_Questions.QuestionsContent] = oRow[conqa_Questions.QuestionsContent].ToString().Trim(); //提问内容
objRow[conqa_Questions.PdfContent] = oRow[conqa_Questions.PdfContent].ToString().Trim(); //Pdf内容
objRow[conqa_Questions.PdfPageNum] = oRow[conqa_Questions.PdfPageNum].ToString().Trim(); //Pdf页码
objRow[conqa_Questions.IsDelete] = oRow[conqa_Questions.IsDelete].ToString().Trim(); //是否删除
objRow[conqa_Questions.IsPublic] = oRow[conqa_Questions.IsPublic].ToString().Trim(); //是否公开
objRow[conqa_Questions.IsEnd] = oRow[conqa_Questions.IsEnd].ToString().Trim(); //是否结束
objRow[conqa_Questions.VoteCount] = oRow[conqa_Questions.VoteCount].ToString().Trim(); //点赞计数
objRow[conqa_Questions.AnswerCount] = oRow[conqa_Questions.AnswerCount].ToString().Trim(); //回答计数
objRow[conqa_Questions.OrderNum] = oRow[conqa_Questions.OrderNum].ToString().Trim(); //序号
objRow[conqa_Questions.UpdUser] = oRow[conqa_Questions.UpdUser].ToString().Trim(); //修改人
objRow[conqa_Questions.UpdDate] = oRow[conqa_Questions.UpdDate].ToString().Trim(); //修改日期
objRow[conqa_Questions.Memo] = oRow[conqa_Questions.Memo].ToString().Trim(); //备注
objRow[conqa_Questions.PdfDivLet] = oRow[conqa_Questions.PdfDivLet].ToString().Trim(); //PdfDivLet
objRow[conqa_Questions.PdfDivTop] = oRow[conqa_Questions.PdfDivTop].ToString().Trim(); //PdfDivTop
objRow[conqa_Questions.PdfPageNumIn] = oRow[conqa_Questions.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objRow[conqa_Questions.PdfPageTop] = oRow[conqa_Questions.PdfPageTop].ToString().Trim(); //pdf页面顶部位置
objRow[conqa_Questions.PdfZoom] = oRow[conqa_Questions.PdfZoom].ToString().Trim(); //PdfZoom
objRow[conqa_Questions.PaperId] = oRow[conqa_Questions.PaperId].ToString().Trim(); //论文Id
objRow[conqa_Questions.UserId] = oRow[conqa_Questions.UserId].ToString().Trim(); //用户ID
objRow[conqa_Questions.QuestionsTypeId] = oRow[conqa_Questions.QuestionsTypeId].ToString().Trim(); //问题类型Id
objRow[conqa_Questions.DiscussCount] = oRow[conqa_Questions.DiscussCount].ToString().Trim(); //DiscussCount
objRow[conqa_Questions.GroupDiscussCount] = oRow[conqa_Questions.GroupDiscussCount].ToString().Trim(); //GroupDiscussCount
objRow[conqa_Questions.RecommendAnswerCount] = oRow[conqa_Questions.RecommendAnswerCount].ToString().Trim(); //RecommendAnswerCount
objRow[conqa_Questions.CreateDate] = oRow[conqa_Questions.CreateDate].ToString().Trim(); //建立日期
objRow[conqa_Questions.IdCurrEduCls] = oRow[conqa_Questions.IdCurrEduCls].ToString().Trim(); //教学班流水号
 objDS.Tables[clsqa_QuestionsEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsqa_QuestionsEN._CurrTabName);
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
 /// <param name = "objqa_QuestionsEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsqa_QuestionsEN objqa_QuestionsEN)
{
 if (objqa_QuestionsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objqa_QuestionsEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_QuestionsDA.GetSpecSQLObj();
strSQL = "Select * from qa_Questions where QuestionsId = " + "'"+ objqa_QuestionsEN.QuestionsId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsqa_QuestionsEN._CurrTabName);
if (objDS.Tables[clsqa_QuestionsEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:QuestionsId = " + "'"+ objqa_QuestionsEN.QuestionsId+"'");
return false;
}
objRow = objDS.Tables[clsqa_QuestionsEN._CurrTabName].Rows[0];
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.QuestionsId))
 {
objRow[conqa_Questions.QuestionsId] = objqa_QuestionsEN.QuestionsId; //提问Id
 }
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.QaPaperId))
 {
objRow[conqa_Questions.QaPaperId] = objqa_QuestionsEN.QaPaperId; //论文答疑Id
 }
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.QuestionsContent))
 {
objRow[conqa_Questions.QuestionsContent] = objqa_QuestionsEN.QuestionsContent; //提问内容
 }
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.PdfContent))
 {
objRow[conqa_Questions.PdfContent] = objqa_QuestionsEN.PdfContent; //Pdf内容
 }
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.PdfPageNum))
 {
objRow[conqa_Questions.PdfPageNum] = objqa_QuestionsEN.PdfPageNum; //Pdf页码
 }
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.IsDelete))
 {
objRow[conqa_Questions.IsDelete] = objqa_QuestionsEN.IsDelete; //是否删除
 }
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.IsPublic))
 {
objRow[conqa_Questions.IsPublic] = objqa_QuestionsEN.IsPublic; //是否公开
 }
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.IsEnd))
 {
objRow[conqa_Questions.IsEnd] = objqa_QuestionsEN.IsEnd; //是否结束
 }
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.VoteCount))
 {
objRow[conqa_Questions.VoteCount] = objqa_QuestionsEN.VoteCount; //点赞计数
 }
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.AnswerCount))
 {
objRow[conqa_Questions.AnswerCount] = objqa_QuestionsEN.AnswerCount; //回答计数
 }
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.OrderNum))
 {
objRow[conqa_Questions.OrderNum] = objqa_QuestionsEN.OrderNum; //序号
 }
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.UpdUser))
 {
objRow[conqa_Questions.UpdUser] = objqa_QuestionsEN.UpdUser; //修改人
 }
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.UpdDate))
 {
objRow[conqa_Questions.UpdDate] = objqa_QuestionsEN.UpdDate; //修改日期
 }
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.Memo))
 {
objRow[conqa_Questions.Memo] = objqa_QuestionsEN.Memo; //备注
 }
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.PdfDivLet))
 {
objRow[conqa_Questions.PdfDivLet] = objqa_QuestionsEN.PdfDivLet; //PdfDivLet
 }
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.PdfDivTop))
 {
objRow[conqa_Questions.PdfDivTop] = objqa_QuestionsEN.PdfDivTop; //PdfDivTop
 }
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.PdfPageNumIn))
 {
objRow[conqa_Questions.PdfPageNumIn] = objqa_QuestionsEN.PdfPageNumIn; //PdfPageNumIn
 }
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.PdfPageTop))
 {
objRow[conqa_Questions.PdfPageTop] = objqa_QuestionsEN.PdfPageTop; //pdf页面顶部位置
 }
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.PdfZoom))
 {
objRow[conqa_Questions.PdfZoom] = objqa_QuestionsEN.PdfZoom; //PdfZoom
 }
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.PaperId))
 {
objRow[conqa_Questions.PaperId] = objqa_QuestionsEN.PaperId; //论文Id
 }
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.UserId))
 {
objRow[conqa_Questions.UserId] = objqa_QuestionsEN.UserId; //用户ID
 }
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.QuestionsTypeId))
 {
objRow[conqa_Questions.QuestionsTypeId] = objqa_QuestionsEN.QuestionsTypeId; //问题类型Id
 }
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.DiscussCount))
 {
objRow[conqa_Questions.DiscussCount] = objqa_QuestionsEN.DiscussCount; //DiscussCount
 }
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.GroupDiscussCount))
 {
objRow[conqa_Questions.GroupDiscussCount] = objqa_QuestionsEN.GroupDiscussCount; //GroupDiscussCount
 }
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.RecommendAnswerCount))
 {
objRow[conqa_Questions.RecommendAnswerCount] = objqa_QuestionsEN.RecommendAnswerCount; //RecommendAnswerCount
 }
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.CreateDate))
 {
objRow[conqa_Questions.CreateDate] = objqa_QuestionsEN.CreateDate; //建立日期
 }
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.IdCurrEduCls))
 {
objRow[conqa_Questions.IdCurrEduCls] = objqa_QuestionsEN.IdCurrEduCls; //教学班流水号
 }
try
{
objDA.Update(objDS, clsqa_QuestionsEN._CurrTabName);
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
 /// <param name = "objqa_QuestionsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsqa_QuestionsEN objqa_QuestionsEN)
{
 if (objqa_QuestionsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objqa_QuestionsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_QuestionsDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update qa_Questions Set ");
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.QaPaperId))
 {
 if (objqa_QuestionsEN.QaPaperId !=  null)
 {
 var strQaPaperId = objqa_QuestionsEN.QaPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQaPaperId, conqa_Questions.QaPaperId); //论文答疑Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Questions.QaPaperId); //论文答疑Id
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.QuestionsContent))
 {
 if (objqa_QuestionsEN.QuestionsContent !=  null)
 {
 var strQuestionsContent = objqa_QuestionsEN.QuestionsContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionsContent, conqa_Questions.QuestionsContent); //提问内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Questions.QuestionsContent); //提问内容
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.PdfContent))
 {
 if (objqa_QuestionsEN.PdfContent !=  null)
 {
 var strPdfContent = objqa_QuestionsEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfContent, conqa_Questions.PdfContent); //Pdf内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Questions.PdfContent); //Pdf内容
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.PdfPageNum))
 {
 if (objqa_QuestionsEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objqa_QuestionsEN.PdfPageNum, conqa_Questions.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Questions.PdfPageNum); //Pdf页码
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.IsDelete))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objqa_QuestionsEN.IsDelete == true?"1":"0", conqa_Questions.IsDelete); //是否删除
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.IsPublic))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objqa_QuestionsEN.IsPublic == true?"1":"0", conqa_Questions.IsPublic); //是否公开
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.IsEnd))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objqa_QuestionsEN.IsEnd == true?"1":"0", conqa_Questions.IsEnd); //是否结束
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.VoteCount))
 {
 if (objqa_QuestionsEN.VoteCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objqa_QuestionsEN.VoteCount, conqa_Questions.VoteCount); //点赞计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Questions.VoteCount); //点赞计数
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.AnswerCount))
 {
 if (objqa_QuestionsEN.AnswerCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objqa_QuestionsEN.AnswerCount, conqa_Questions.AnswerCount); //回答计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Questions.AnswerCount); //回答计数
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.OrderNum))
 {
 if (objqa_QuestionsEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objqa_QuestionsEN.OrderNum, conqa_Questions.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Questions.OrderNum); //序号
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.UpdUser))
 {
 if (objqa_QuestionsEN.UpdUser !=  null)
 {
 var strUpdUser = objqa_QuestionsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conqa_Questions.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Questions.UpdUser); //修改人
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.UpdDate))
 {
 if (objqa_QuestionsEN.UpdDate !=  null)
 {
 var strUpdDate = objqa_QuestionsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conqa_Questions.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Questions.UpdDate); //修改日期
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.Memo))
 {
 if (objqa_QuestionsEN.Memo !=  null)
 {
 var strMemo = objqa_QuestionsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conqa_Questions.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Questions.Memo); //备注
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.PdfDivLet))
 {
 if (objqa_QuestionsEN.PdfDivLet !=  null)
 {
 var strPdfDivLet = objqa_QuestionsEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfDivLet, conqa_Questions.PdfDivLet); //PdfDivLet
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Questions.PdfDivLet); //PdfDivLet
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.PdfDivTop))
 {
 if (objqa_QuestionsEN.PdfDivTop !=  null)
 {
 var strPdfDivTop = objqa_QuestionsEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfDivTop, conqa_Questions.PdfDivTop); //PdfDivTop
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Questions.PdfDivTop); //PdfDivTop
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.PdfPageNumIn))
 {
 if (objqa_QuestionsEN.PdfPageNumIn !=  null)
 {
 var strPdfPageNumIn = objqa_QuestionsEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfPageNumIn, conqa_Questions.PdfPageNumIn); //PdfPageNumIn
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Questions.PdfPageNumIn); //PdfPageNumIn
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.PdfPageTop))
 {
 if (objqa_QuestionsEN.PdfPageTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objqa_QuestionsEN.PdfPageTop, conqa_Questions.PdfPageTop); //pdf页面顶部位置
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Questions.PdfPageTop); //pdf页面顶部位置
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.PdfZoom))
 {
 if (objqa_QuestionsEN.PdfZoom !=  null)
 {
 var strPdfZoom = objqa_QuestionsEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfZoom, conqa_Questions.PdfZoom); //PdfZoom
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Questions.PdfZoom); //PdfZoom
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.PaperId))
 {
 if (objqa_QuestionsEN.PaperId !=  null)
 {
 var strPaperId = objqa_QuestionsEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPaperId, conqa_Questions.PaperId); //论文Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Questions.PaperId); //论文Id
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.UserId))
 {
 if (objqa_QuestionsEN.UserId !=  null)
 {
 var strUserId = objqa_QuestionsEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conqa_Questions.UserId); //用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Questions.UserId); //用户ID
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.QuestionsTypeId))
 {
 if (objqa_QuestionsEN.QuestionsTypeId !=  null)
 {
 var strQuestionsTypeId = objqa_QuestionsEN.QuestionsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionsTypeId, conqa_Questions.QuestionsTypeId); //问题类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Questions.QuestionsTypeId); //问题类型Id
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.DiscussCount))
 {
 if (objqa_QuestionsEN.DiscussCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objqa_QuestionsEN.DiscussCount, conqa_Questions.DiscussCount); //DiscussCount
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Questions.DiscussCount); //DiscussCount
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.GroupDiscussCount))
 {
 if (objqa_QuestionsEN.GroupDiscussCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objqa_QuestionsEN.GroupDiscussCount, conqa_Questions.GroupDiscussCount); //GroupDiscussCount
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Questions.GroupDiscussCount); //GroupDiscussCount
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.RecommendAnswerCount))
 {
 if (objqa_QuestionsEN.RecommendAnswerCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objqa_QuestionsEN.RecommendAnswerCount, conqa_Questions.RecommendAnswerCount); //RecommendAnswerCount
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Questions.RecommendAnswerCount); //RecommendAnswerCount
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.CreateDate))
 {
 if (objqa_QuestionsEN.CreateDate !=  null)
 {
 var strCreateDate = objqa_QuestionsEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateDate, conqa_Questions.CreateDate); //建立日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Questions.CreateDate); //建立日期
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.IdCurrEduCls))
 {
 if (objqa_QuestionsEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objqa_QuestionsEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conqa_Questions.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Questions.IdCurrEduCls); //教学班流水号
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where QuestionsId = '{0}'", objqa_QuestionsEN.QuestionsId); 
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
 /// <param name = "objqa_QuestionsEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsqa_QuestionsEN objqa_QuestionsEN, string strCondition)
{
 if (objqa_QuestionsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objqa_QuestionsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_QuestionsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update qa_Questions Set ");
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.QaPaperId))
 {
 if (objqa_QuestionsEN.QaPaperId !=  null)
 {
 var strQaPaperId = objqa_QuestionsEN.QaPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QaPaperId = '{0}',", strQaPaperId); //论文答疑Id
 }
 else
 {
 sbSQL.Append(" QaPaperId = null,"); //论文答疑Id
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.QuestionsContent))
 {
 if (objqa_QuestionsEN.QuestionsContent !=  null)
 {
 var strQuestionsContent = objqa_QuestionsEN.QuestionsContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionsContent = '{0}',", strQuestionsContent); //提问内容
 }
 else
 {
 sbSQL.Append(" QuestionsContent = null,"); //提问内容
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.PdfContent))
 {
 if (objqa_QuestionsEN.PdfContent !=  null)
 {
 var strPdfContent = objqa_QuestionsEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfContent = '{0}',", strPdfContent); //Pdf内容
 }
 else
 {
 sbSQL.Append(" PdfContent = null,"); //Pdf内容
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.PdfPageNum))
 {
 if (objqa_QuestionsEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objqa_QuestionsEN.PdfPageNum, conqa_Questions.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Questions.PdfPageNum); //Pdf页码
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.IsDelete))
 {
 sbSQL.AppendFormat(" IsDelete = '{0}',", objqa_QuestionsEN.IsDelete == true?"1":"0"); //是否删除
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.IsPublic))
 {
 sbSQL.AppendFormat(" IsPublic = '{0}',", objqa_QuestionsEN.IsPublic == true?"1":"0"); //是否公开
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.IsEnd))
 {
 sbSQL.AppendFormat(" IsEnd = '{0}',", objqa_QuestionsEN.IsEnd == true?"1":"0"); //是否结束
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.VoteCount))
 {
 if (objqa_QuestionsEN.VoteCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objqa_QuestionsEN.VoteCount, conqa_Questions.VoteCount); //点赞计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Questions.VoteCount); //点赞计数
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.AnswerCount))
 {
 if (objqa_QuestionsEN.AnswerCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objqa_QuestionsEN.AnswerCount, conqa_Questions.AnswerCount); //回答计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Questions.AnswerCount); //回答计数
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.OrderNum))
 {
 if (objqa_QuestionsEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objqa_QuestionsEN.OrderNum, conqa_Questions.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Questions.OrderNum); //序号
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.UpdUser))
 {
 if (objqa_QuestionsEN.UpdUser !=  null)
 {
 var strUpdUser = objqa_QuestionsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.UpdDate))
 {
 if (objqa_QuestionsEN.UpdDate !=  null)
 {
 var strUpdDate = objqa_QuestionsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.Memo))
 {
 if (objqa_QuestionsEN.Memo !=  null)
 {
 var strMemo = objqa_QuestionsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.PdfDivLet))
 {
 if (objqa_QuestionsEN.PdfDivLet !=  null)
 {
 var strPdfDivLet = objqa_QuestionsEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfDivLet = '{0}',", strPdfDivLet); //PdfDivLet
 }
 else
 {
 sbSQL.Append(" PdfDivLet = null,"); //PdfDivLet
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.PdfDivTop))
 {
 if (objqa_QuestionsEN.PdfDivTop !=  null)
 {
 var strPdfDivTop = objqa_QuestionsEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfDivTop = '{0}',", strPdfDivTop); //PdfDivTop
 }
 else
 {
 sbSQL.Append(" PdfDivTop = null,"); //PdfDivTop
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.PdfPageNumIn))
 {
 if (objqa_QuestionsEN.PdfPageNumIn !=  null)
 {
 var strPdfPageNumIn = objqa_QuestionsEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfPageNumIn = '{0}',", strPdfPageNumIn); //PdfPageNumIn
 }
 else
 {
 sbSQL.Append(" PdfPageNumIn = null,"); //PdfPageNumIn
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.PdfPageTop))
 {
 if (objqa_QuestionsEN.PdfPageTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objqa_QuestionsEN.PdfPageTop, conqa_Questions.PdfPageTop); //pdf页面顶部位置
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Questions.PdfPageTop); //pdf页面顶部位置
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.PdfZoom))
 {
 if (objqa_QuestionsEN.PdfZoom !=  null)
 {
 var strPdfZoom = objqa_QuestionsEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfZoom = '{0}',", strPdfZoom); //PdfZoom
 }
 else
 {
 sbSQL.Append(" PdfZoom = null,"); //PdfZoom
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.PaperId))
 {
 if (objqa_QuestionsEN.PaperId !=  null)
 {
 var strPaperId = objqa_QuestionsEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PaperId = '{0}',", strPaperId); //论文Id
 }
 else
 {
 sbSQL.Append(" PaperId = null,"); //论文Id
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.UserId))
 {
 if (objqa_QuestionsEN.UserId !=  null)
 {
 var strUserId = objqa_QuestionsEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户ID
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户ID
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.QuestionsTypeId))
 {
 if (objqa_QuestionsEN.QuestionsTypeId !=  null)
 {
 var strQuestionsTypeId = objqa_QuestionsEN.QuestionsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionsTypeId = '{0}',", strQuestionsTypeId); //问题类型Id
 }
 else
 {
 sbSQL.Append(" QuestionsTypeId = null,"); //问题类型Id
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.DiscussCount))
 {
 if (objqa_QuestionsEN.DiscussCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objqa_QuestionsEN.DiscussCount, conqa_Questions.DiscussCount); //DiscussCount
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Questions.DiscussCount); //DiscussCount
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.GroupDiscussCount))
 {
 if (objqa_QuestionsEN.GroupDiscussCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objqa_QuestionsEN.GroupDiscussCount, conqa_Questions.GroupDiscussCount); //GroupDiscussCount
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Questions.GroupDiscussCount); //GroupDiscussCount
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.RecommendAnswerCount))
 {
 if (objqa_QuestionsEN.RecommendAnswerCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objqa_QuestionsEN.RecommendAnswerCount, conqa_Questions.RecommendAnswerCount); //RecommendAnswerCount
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Questions.RecommendAnswerCount); //RecommendAnswerCount
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.CreateDate))
 {
 if (objqa_QuestionsEN.CreateDate !=  null)
 {
 var strCreateDate = objqa_QuestionsEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateDate = '{0}',", strCreateDate); //建立日期
 }
 else
 {
 sbSQL.Append(" CreateDate = null,"); //建立日期
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.IdCurrEduCls))
 {
 if (objqa_QuestionsEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objqa_QuestionsEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
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
 /// <param name = "objqa_QuestionsEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsqa_QuestionsEN objqa_QuestionsEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objqa_QuestionsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objqa_QuestionsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_QuestionsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update qa_Questions Set ");
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.QaPaperId))
 {
 if (objqa_QuestionsEN.QaPaperId !=  null)
 {
 var strQaPaperId = objqa_QuestionsEN.QaPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QaPaperId = '{0}',", strQaPaperId); //论文答疑Id
 }
 else
 {
 sbSQL.Append(" QaPaperId = null,"); //论文答疑Id
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.QuestionsContent))
 {
 if (objqa_QuestionsEN.QuestionsContent !=  null)
 {
 var strQuestionsContent = objqa_QuestionsEN.QuestionsContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionsContent = '{0}',", strQuestionsContent); //提问内容
 }
 else
 {
 sbSQL.Append(" QuestionsContent = null,"); //提问内容
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.PdfContent))
 {
 if (objqa_QuestionsEN.PdfContent !=  null)
 {
 var strPdfContent = objqa_QuestionsEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfContent = '{0}',", strPdfContent); //Pdf内容
 }
 else
 {
 sbSQL.Append(" PdfContent = null,"); //Pdf内容
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.PdfPageNum))
 {
 if (objqa_QuestionsEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objqa_QuestionsEN.PdfPageNum, conqa_Questions.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Questions.PdfPageNum); //Pdf页码
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.IsDelete))
 {
 sbSQL.AppendFormat(" IsDelete = '{0}',", objqa_QuestionsEN.IsDelete == true?"1":"0"); //是否删除
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.IsPublic))
 {
 sbSQL.AppendFormat(" IsPublic = '{0}',", objqa_QuestionsEN.IsPublic == true?"1":"0"); //是否公开
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.IsEnd))
 {
 sbSQL.AppendFormat(" IsEnd = '{0}',", objqa_QuestionsEN.IsEnd == true?"1":"0"); //是否结束
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.VoteCount))
 {
 if (objqa_QuestionsEN.VoteCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objqa_QuestionsEN.VoteCount, conqa_Questions.VoteCount); //点赞计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Questions.VoteCount); //点赞计数
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.AnswerCount))
 {
 if (objqa_QuestionsEN.AnswerCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objqa_QuestionsEN.AnswerCount, conqa_Questions.AnswerCount); //回答计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Questions.AnswerCount); //回答计数
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.OrderNum))
 {
 if (objqa_QuestionsEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objqa_QuestionsEN.OrderNum, conqa_Questions.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Questions.OrderNum); //序号
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.UpdUser))
 {
 if (objqa_QuestionsEN.UpdUser !=  null)
 {
 var strUpdUser = objqa_QuestionsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.UpdDate))
 {
 if (objqa_QuestionsEN.UpdDate !=  null)
 {
 var strUpdDate = objqa_QuestionsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.Memo))
 {
 if (objqa_QuestionsEN.Memo !=  null)
 {
 var strMemo = objqa_QuestionsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.PdfDivLet))
 {
 if (objqa_QuestionsEN.PdfDivLet !=  null)
 {
 var strPdfDivLet = objqa_QuestionsEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfDivLet = '{0}',", strPdfDivLet); //PdfDivLet
 }
 else
 {
 sbSQL.Append(" PdfDivLet = null,"); //PdfDivLet
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.PdfDivTop))
 {
 if (objqa_QuestionsEN.PdfDivTop !=  null)
 {
 var strPdfDivTop = objqa_QuestionsEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfDivTop = '{0}',", strPdfDivTop); //PdfDivTop
 }
 else
 {
 sbSQL.Append(" PdfDivTop = null,"); //PdfDivTop
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.PdfPageNumIn))
 {
 if (objqa_QuestionsEN.PdfPageNumIn !=  null)
 {
 var strPdfPageNumIn = objqa_QuestionsEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfPageNumIn = '{0}',", strPdfPageNumIn); //PdfPageNumIn
 }
 else
 {
 sbSQL.Append(" PdfPageNumIn = null,"); //PdfPageNumIn
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.PdfPageTop))
 {
 if (objqa_QuestionsEN.PdfPageTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objqa_QuestionsEN.PdfPageTop, conqa_Questions.PdfPageTop); //pdf页面顶部位置
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Questions.PdfPageTop); //pdf页面顶部位置
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.PdfZoom))
 {
 if (objqa_QuestionsEN.PdfZoom !=  null)
 {
 var strPdfZoom = objqa_QuestionsEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfZoom = '{0}',", strPdfZoom); //PdfZoom
 }
 else
 {
 sbSQL.Append(" PdfZoom = null,"); //PdfZoom
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.PaperId))
 {
 if (objqa_QuestionsEN.PaperId !=  null)
 {
 var strPaperId = objqa_QuestionsEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PaperId = '{0}',", strPaperId); //论文Id
 }
 else
 {
 sbSQL.Append(" PaperId = null,"); //论文Id
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.UserId))
 {
 if (objqa_QuestionsEN.UserId !=  null)
 {
 var strUserId = objqa_QuestionsEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户ID
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户ID
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.QuestionsTypeId))
 {
 if (objqa_QuestionsEN.QuestionsTypeId !=  null)
 {
 var strQuestionsTypeId = objqa_QuestionsEN.QuestionsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionsTypeId = '{0}',", strQuestionsTypeId); //问题类型Id
 }
 else
 {
 sbSQL.Append(" QuestionsTypeId = null,"); //问题类型Id
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.DiscussCount))
 {
 if (objqa_QuestionsEN.DiscussCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objqa_QuestionsEN.DiscussCount, conqa_Questions.DiscussCount); //DiscussCount
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Questions.DiscussCount); //DiscussCount
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.GroupDiscussCount))
 {
 if (objqa_QuestionsEN.GroupDiscussCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objqa_QuestionsEN.GroupDiscussCount, conqa_Questions.GroupDiscussCount); //GroupDiscussCount
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Questions.GroupDiscussCount); //GroupDiscussCount
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.RecommendAnswerCount))
 {
 if (objqa_QuestionsEN.RecommendAnswerCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objqa_QuestionsEN.RecommendAnswerCount, conqa_Questions.RecommendAnswerCount); //RecommendAnswerCount
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Questions.RecommendAnswerCount); //RecommendAnswerCount
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.CreateDate))
 {
 if (objqa_QuestionsEN.CreateDate !=  null)
 {
 var strCreateDate = objqa_QuestionsEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateDate = '{0}',", strCreateDate); //建立日期
 }
 else
 {
 sbSQL.Append(" CreateDate = null,"); //建立日期
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.IdCurrEduCls))
 {
 if (objqa_QuestionsEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objqa_QuestionsEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
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
 /// <param name = "objqa_QuestionsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsqa_QuestionsEN objqa_QuestionsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objqa_QuestionsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objqa_QuestionsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_QuestionsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update qa_Questions Set ");
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.QaPaperId))
 {
 if (objqa_QuestionsEN.QaPaperId !=  null)
 {
 var strQaPaperId = objqa_QuestionsEN.QaPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQaPaperId, conqa_Questions.QaPaperId); //论文答疑Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Questions.QaPaperId); //论文答疑Id
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.QuestionsContent))
 {
 if (objqa_QuestionsEN.QuestionsContent !=  null)
 {
 var strQuestionsContent = objqa_QuestionsEN.QuestionsContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionsContent, conqa_Questions.QuestionsContent); //提问内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Questions.QuestionsContent); //提问内容
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.PdfContent))
 {
 if (objqa_QuestionsEN.PdfContent !=  null)
 {
 var strPdfContent = objqa_QuestionsEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfContent, conqa_Questions.PdfContent); //Pdf内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Questions.PdfContent); //Pdf内容
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.PdfPageNum))
 {
 if (objqa_QuestionsEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objqa_QuestionsEN.PdfPageNum, conqa_Questions.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Questions.PdfPageNum); //Pdf页码
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.IsDelete))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objqa_QuestionsEN.IsDelete == true?"1":"0", conqa_Questions.IsDelete); //是否删除
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.IsPublic))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objqa_QuestionsEN.IsPublic == true?"1":"0", conqa_Questions.IsPublic); //是否公开
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.IsEnd))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objqa_QuestionsEN.IsEnd == true?"1":"0", conqa_Questions.IsEnd); //是否结束
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.VoteCount))
 {
 if (objqa_QuestionsEN.VoteCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objqa_QuestionsEN.VoteCount, conqa_Questions.VoteCount); //点赞计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Questions.VoteCount); //点赞计数
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.AnswerCount))
 {
 if (objqa_QuestionsEN.AnswerCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objqa_QuestionsEN.AnswerCount, conqa_Questions.AnswerCount); //回答计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Questions.AnswerCount); //回答计数
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.OrderNum))
 {
 if (objqa_QuestionsEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objqa_QuestionsEN.OrderNum, conqa_Questions.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Questions.OrderNum); //序号
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.UpdUser))
 {
 if (objqa_QuestionsEN.UpdUser !=  null)
 {
 var strUpdUser = objqa_QuestionsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conqa_Questions.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Questions.UpdUser); //修改人
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.UpdDate))
 {
 if (objqa_QuestionsEN.UpdDate !=  null)
 {
 var strUpdDate = objqa_QuestionsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conqa_Questions.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Questions.UpdDate); //修改日期
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.Memo))
 {
 if (objqa_QuestionsEN.Memo !=  null)
 {
 var strMemo = objqa_QuestionsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conqa_Questions.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Questions.Memo); //备注
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.PdfDivLet))
 {
 if (objqa_QuestionsEN.PdfDivLet !=  null)
 {
 var strPdfDivLet = objqa_QuestionsEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfDivLet, conqa_Questions.PdfDivLet); //PdfDivLet
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Questions.PdfDivLet); //PdfDivLet
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.PdfDivTop))
 {
 if (objqa_QuestionsEN.PdfDivTop !=  null)
 {
 var strPdfDivTop = objqa_QuestionsEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfDivTop, conqa_Questions.PdfDivTop); //PdfDivTop
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Questions.PdfDivTop); //PdfDivTop
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.PdfPageNumIn))
 {
 if (objqa_QuestionsEN.PdfPageNumIn !=  null)
 {
 var strPdfPageNumIn = objqa_QuestionsEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfPageNumIn, conqa_Questions.PdfPageNumIn); //PdfPageNumIn
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Questions.PdfPageNumIn); //PdfPageNumIn
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.PdfPageTop))
 {
 if (objqa_QuestionsEN.PdfPageTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objqa_QuestionsEN.PdfPageTop, conqa_Questions.PdfPageTop); //pdf页面顶部位置
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Questions.PdfPageTop); //pdf页面顶部位置
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.PdfZoom))
 {
 if (objqa_QuestionsEN.PdfZoom !=  null)
 {
 var strPdfZoom = objqa_QuestionsEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfZoom, conqa_Questions.PdfZoom); //PdfZoom
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Questions.PdfZoom); //PdfZoom
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.PaperId))
 {
 if (objqa_QuestionsEN.PaperId !=  null)
 {
 var strPaperId = objqa_QuestionsEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPaperId, conqa_Questions.PaperId); //论文Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Questions.PaperId); //论文Id
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.UserId))
 {
 if (objqa_QuestionsEN.UserId !=  null)
 {
 var strUserId = objqa_QuestionsEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conqa_Questions.UserId); //用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Questions.UserId); //用户ID
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.QuestionsTypeId))
 {
 if (objqa_QuestionsEN.QuestionsTypeId !=  null)
 {
 var strQuestionsTypeId = objqa_QuestionsEN.QuestionsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionsTypeId, conqa_Questions.QuestionsTypeId); //问题类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Questions.QuestionsTypeId); //问题类型Id
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.DiscussCount))
 {
 if (objqa_QuestionsEN.DiscussCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objqa_QuestionsEN.DiscussCount, conqa_Questions.DiscussCount); //DiscussCount
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Questions.DiscussCount); //DiscussCount
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.GroupDiscussCount))
 {
 if (objqa_QuestionsEN.GroupDiscussCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objqa_QuestionsEN.GroupDiscussCount, conqa_Questions.GroupDiscussCount); //GroupDiscussCount
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Questions.GroupDiscussCount); //GroupDiscussCount
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.RecommendAnswerCount))
 {
 if (objqa_QuestionsEN.RecommendAnswerCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objqa_QuestionsEN.RecommendAnswerCount, conqa_Questions.RecommendAnswerCount); //RecommendAnswerCount
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Questions.RecommendAnswerCount); //RecommendAnswerCount
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.CreateDate))
 {
 if (objqa_QuestionsEN.CreateDate !=  null)
 {
 var strCreateDate = objqa_QuestionsEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateDate, conqa_Questions.CreateDate); //建立日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Questions.CreateDate); //建立日期
 }
 }
 
 if (objqa_QuestionsEN.IsUpdated(conqa_Questions.IdCurrEduCls))
 {
 if (objqa_QuestionsEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objqa_QuestionsEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conqa_Questions.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_Questions.IdCurrEduCls); //教学班流水号
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where QuestionsId = '{0}'", objqa_QuestionsEN.QuestionsId); 
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
 /// <param name = "strQuestionsId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strQuestionsId) 
{
CheckPrimaryKey(strQuestionsId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_QuestionsDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strQuestionsId,
};
 objSQL.ExecSP("qa_Questions_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strQuestionsId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strQuestionsId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strQuestionsId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_QuestionsDA.GetSpecSQLObj();
//删除qa_Questions本表中与当前对象有关的记录
strSQL = strSQL + "Delete from qa_Questions where QuestionsId = " + "'"+ strQuestionsId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delqa_Questions(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_QuestionsDA.GetSpecSQLObj();
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
//删除qa_Questions本表中与当前对象有关的记录
strSQL = strSQL + "Delete from qa_Questions where QuestionsId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strQuestionsId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strQuestionsId) 
{
CheckPrimaryKey(strQuestionsId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_QuestionsDA.GetSpecSQLObj();
//删除qa_Questions本表中与当前对象有关的记录
strSQL = strSQL + "Delete from qa_Questions where QuestionsId = " + "'"+ strQuestionsId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delqa_Questions(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsqa_QuestionsDA: Delqa_Questions)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_QuestionsDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from qa_Questions where " + strCondition ;
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
public bool Delqa_QuestionsWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsqa_QuestionsDA: Delqa_QuestionsWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_QuestionsDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from qa_Questions where " + strCondition ;
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
 /// <param name = "objqa_QuestionsENS">源对象</param>
 /// <param name = "objqa_QuestionsENT">目标对象</param>
public void CopyTo(clsqa_QuestionsEN objqa_QuestionsENS, clsqa_QuestionsEN objqa_QuestionsENT)
{
objqa_QuestionsENT.QuestionsId = objqa_QuestionsENS.QuestionsId; //提问Id
objqa_QuestionsENT.QaPaperId = objqa_QuestionsENS.QaPaperId; //论文答疑Id
objqa_QuestionsENT.QuestionsContent = objqa_QuestionsENS.QuestionsContent; //提问内容
objqa_QuestionsENT.PdfContent = objqa_QuestionsENS.PdfContent; //Pdf内容
objqa_QuestionsENT.PdfPageNum = objqa_QuestionsENS.PdfPageNum; //Pdf页码
objqa_QuestionsENT.IsDelete = objqa_QuestionsENS.IsDelete; //是否删除
objqa_QuestionsENT.IsPublic = objqa_QuestionsENS.IsPublic; //是否公开
objqa_QuestionsENT.IsEnd = objqa_QuestionsENS.IsEnd; //是否结束
objqa_QuestionsENT.VoteCount = objqa_QuestionsENS.VoteCount; //点赞计数
objqa_QuestionsENT.AnswerCount = objqa_QuestionsENS.AnswerCount; //回答计数
objqa_QuestionsENT.OrderNum = objqa_QuestionsENS.OrderNum; //序号
objqa_QuestionsENT.UpdUser = objqa_QuestionsENS.UpdUser; //修改人
objqa_QuestionsENT.UpdDate = objqa_QuestionsENS.UpdDate; //修改日期
objqa_QuestionsENT.Memo = objqa_QuestionsENS.Memo; //备注
objqa_QuestionsENT.PdfDivLet = objqa_QuestionsENS.PdfDivLet; //PdfDivLet
objqa_QuestionsENT.PdfDivTop = objqa_QuestionsENS.PdfDivTop; //PdfDivTop
objqa_QuestionsENT.PdfPageNumIn = objqa_QuestionsENS.PdfPageNumIn; //PdfPageNumIn
objqa_QuestionsENT.PdfPageTop = objqa_QuestionsENS.PdfPageTop; //pdf页面顶部位置
objqa_QuestionsENT.PdfZoom = objqa_QuestionsENS.PdfZoom; //PdfZoom
objqa_QuestionsENT.PaperId = objqa_QuestionsENS.PaperId; //论文Id
objqa_QuestionsENT.UserId = objqa_QuestionsENS.UserId; //用户ID
objqa_QuestionsENT.QuestionsTypeId = objqa_QuestionsENS.QuestionsTypeId; //问题类型Id
objqa_QuestionsENT.DiscussCount = objqa_QuestionsENS.DiscussCount; //DiscussCount
objqa_QuestionsENT.GroupDiscussCount = objqa_QuestionsENS.GroupDiscussCount; //GroupDiscussCount
objqa_QuestionsENT.RecommendAnswerCount = objqa_QuestionsENS.RecommendAnswerCount; //RecommendAnswerCount
objqa_QuestionsENT.CreateDate = objqa_QuestionsENS.CreateDate; //建立日期
objqa_QuestionsENT.IdCurrEduCls = objqa_QuestionsENS.IdCurrEduCls; //教学班流水号
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsqa_QuestionsEN objqa_QuestionsEN)
{
//检查字段不能为空(NULL)
//检查字段长度
clsCheckSql.CheckFieldLen(objqa_QuestionsEN.QuestionsId, 8, conqa_Questions.QuestionsId);
clsCheckSql.CheckFieldLen(objqa_QuestionsEN.QaPaperId, 8, conqa_Questions.QaPaperId);
clsCheckSql.CheckFieldLen(objqa_QuestionsEN.QuestionsContent, 1000, conqa_Questions.QuestionsContent);
clsCheckSql.CheckFieldLen(objqa_QuestionsEN.PdfContent, 2000, conqa_Questions.PdfContent);
clsCheckSql.CheckFieldLen(objqa_QuestionsEN.UpdUser, 20, conqa_Questions.UpdUser);
clsCheckSql.CheckFieldLen(objqa_QuestionsEN.UpdDate, 20, conqa_Questions.UpdDate);
clsCheckSql.CheckFieldLen(objqa_QuestionsEN.Memo, 1000, conqa_Questions.Memo);
clsCheckSql.CheckFieldLen(objqa_QuestionsEN.PdfDivLet, 50, conqa_Questions.PdfDivLet);
clsCheckSql.CheckFieldLen(objqa_QuestionsEN.PdfDivTop, 50, conqa_Questions.PdfDivTop);
clsCheckSql.CheckFieldLen(objqa_QuestionsEN.PdfPageNumIn, 50, conqa_Questions.PdfPageNumIn);
clsCheckSql.CheckFieldLen(objqa_QuestionsEN.PdfZoom, 50, conqa_Questions.PdfZoom);
clsCheckSql.CheckFieldLen(objqa_QuestionsEN.PaperId, 8, conqa_Questions.PaperId);
clsCheckSql.CheckFieldLen(objqa_QuestionsEN.UserId, 18, conqa_Questions.UserId);
clsCheckSql.CheckFieldLen(objqa_QuestionsEN.QuestionsTypeId, 2, conqa_Questions.QuestionsTypeId);
clsCheckSql.CheckFieldLen(objqa_QuestionsEN.CreateDate, 20, conqa_Questions.CreateDate);
clsCheckSql.CheckFieldLen(objqa_QuestionsEN.IdCurrEduCls, 8, conqa_Questions.IdCurrEduCls);
//检查字段外键固定长度
 objqa_QuestionsEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsqa_QuestionsEN objqa_QuestionsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objqa_QuestionsEN.QaPaperId, 8, conqa_Questions.QaPaperId);
clsCheckSql.CheckFieldLen(objqa_QuestionsEN.QuestionsContent, 1000, conqa_Questions.QuestionsContent);
clsCheckSql.CheckFieldLen(objqa_QuestionsEN.PdfContent, 2000, conqa_Questions.PdfContent);
clsCheckSql.CheckFieldLen(objqa_QuestionsEN.UpdUser, 20, conqa_Questions.UpdUser);
clsCheckSql.CheckFieldLen(objqa_QuestionsEN.UpdDate, 20, conqa_Questions.UpdDate);
clsCheckSql.CheckFieldLen(objqa_QuestionsEN.Memo, 1000, conqa_Questions.Memo);
clsCheckSql.CheckFieldLen(objqa_QuestionsEN.PdfDivLet, 50, conqa_Questions.PdfDivLet);
clsCheckSql.CheckFieldLen(objqa_QuestionsEN.PdfDivTop, 50, conqa_Questions.PdfDivTop);
clsCheckSql.CheckFieldLen(objqa_QuestionsEN.PdfPageNumIn, 50, conqa_Questions.PdfPageNumIn);
clsCheckSql.CheckFieldLen(objqa_QuestionsEN.PdfZoom, 50, conqa_Questions.PdfZoom);
clsCheckSql.CheckFieldLen(objqa_QuestionsEN.PaperId, 8, conqa_Questions.PaperId);
clsCheckSql.CheckFieldLen(objqa_QuestionsEN.UserId, 18, conqa_Questions.UserId);
clsCheckSql.CheckFieldLen(objqa_QuestionsEN.QuestionsTypeId, 2, conqa_Questions.QuestionsTypeId);
clsCheckSql.CheckFieldLen(objqa_QuestionsEN.CreateDate, 20, conqa_Questions.CreateDate);
clsCheckSql.CheckFieldLen(objqa_QuestionsEN.IdCurrEduCls, 8, conqa_Questions.IdCurrEduCls);
//检查外键字段长度
 objqa_QuestionsEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsqa_QuestionsEN objqa_QuestionsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objqa_QuestionsEN.QuestionsId, 8, conqa_Questions.QuestionsId);
clsCheckSql.CheckFieldLen(objqa_QuestionsEN.QaPaperId, 8, conqa_Questions.QaPaperId);
clsCheckSql.CheckFieldLen(objqa_QuestionsEN.QuestionsContent, 1000, conqa_Questions.QuestionsContent);
clsCheckSql.CheckFieldLen(objqa_QuestionsEN.PdfContent, 2000, conqa_Questions.PdfContent);
clsCheckSql.CheckFieldLen(objqa_QuestionsEN.UpdUser, 20, conqa_Questions.UpdUser);
clsCheckSql.CheckFieldLen(objqa_QuestionsEN.UpdDate, 20, conqa_Questions.UpdDate);
clsCheckSql.CheckFieldLen(objqa_QuestionsEN.Memo, 1000, conqa_Questions.Memo);
clsCheckSql.CheckFieldLen(objqa_QuestionsEN.PdfDivLet, 50, conqa_Questions.PdfDivLet);
clsCheckSql.CheckFieldLen(objqa_QuestionsEN.PdfDivTop, 50, conqa_Questions.PdfDivTop);
clsCheckSql.CheckFieldLen(objqa_QuestionsEN.PdfPageNumIn, 50, conqa_Questions.PdfPageNumIn);
clsCheckSql.CheckFieldLen(objqa_QuestionsEN.PdfZoom, 50, conqa_Questions.PdfZoom);
clsCheckSql.CheckFieldLen(objqa_QuestionsEN.PaperId, 8, conqa_Questions.PaperId);
clsCheckSql.CheckFieldLen(objqa_QuestionsEN.UserId, 18, conqa_Questions.UserId);
clsCheckSql.CheckFieldLen(objqa_QuestionsEN.QuestionsTypeId, 2, conqa_Questions.QuestionsTypeId);
clsCheckSql.CheckFieldLen(objqa_QuestionsEN.CreateDate, 20, conqa_Questions.CreateDate);
clsCheckSql.CheckFieldLen(objqa_QuestionsEN.IdCurrEduCls, 8, conqa_Questions.IdCurrEduCls);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objqa_QuestionsEN.QuestionsId, conqa_Questions.QuestionsId);
clsCheckSql.CheckSqlInjection4Field(objqa_QuestionsEN.QaPaperId, conqa_Questions.QaPaperId);
clsCheckSql.CheckSqlInjection4Field(objqa_QuestionsEN.QuestionsContent, conqa_Questions.QuestionsContent);
clsCheckSql.CheckSqlInjection4Field(objqa_QuestionsEN.PdfContent, conqa_Questions.PdfContent);
clsCheckSql.CheckSqlInjection4Field(objqa_QuestionsEN.UpdUser, conqa_Questions.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objqa_QuestionsEN.UpdDate, conqa_Questions.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objqa_QuestionsEN.Memo, conqa_Questions.Memo);
clsCheckSql.CheckSqlInjection4Field(objqa_QuestionsEN.PdfDivLet, conqa_Questions.PdfDivLet);
clsCheckSql.CheckSqlInjection4Field(objqa_QuestionsEN.PdfDivTop, conqa_Questions.PdfDivTop);
clsCheckSql.CheckSqlInjection4Field(objqa_QuestionsEN.PdfPageNumIn, conqa_Questions.PdfPageNumIn);
clsCheckSql.CheckSqlInjection4Field(objqa_QuestionsEN.PdfZoom, conqa_Questions.PdfZoom);
clsCheckSql.CheckSqlInjection4Field(objqa_QuestionsEN.PaperId, conqa_Questions.PaperId);
clsCheckSql.CheckSqlInjection4Field(objqa_QuestionsEN.UserId, conqa_Questions.UserId);
clsCheckSql.CheckSqlInjection4Field(objqa_QuestionsEN.QuestionsTypeId, conqa_Questions.QuestionsTypeId);
clsCheckSql.CheckSqlInjection4Field(objqa_QuestionsEN.CreateDate, conqa_Questions.CreateDate);
clsCheckSql.CheckSqlInjection4Field(objqa_QuestionsEN.IdCurrEduCls, conqa_Questions.IdCurrEduCls);
//检查外键字段长度
 objqa_QuestionsEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--qa_Questions(答疑提问表),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objqa_QuestionsEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsqa_QuestionsEN objqa_QuestionsEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and QuestionsId = '{0}'", objqa_QuestionsEN.QuestionsId);
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
 objSQL = clsqa_QuestionsDA.GetSpecSQLObj();
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
 objSQL = clsqa_QuestionsDA.GetSpecSQLObj();
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
 objSQL = clsqa_QuestionsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsqa_QuestionsEN._CurrTabName);
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
 objSQL = clsqa_QuestionsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsqa_QuestionsEN._CurrTabName, strCondition);
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
 objSQL = clsqa_QuestionsDA.GetSpecSQLObj();
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
 objSQL = clsqa_QuestionsDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}