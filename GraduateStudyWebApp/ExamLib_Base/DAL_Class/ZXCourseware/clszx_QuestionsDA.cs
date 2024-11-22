
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_QuestionsDA
 表名:zx_Questions(01120722)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:56:47
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学生课件管理(ZXCourseware)
 框架-层名:数据处理层(CS)(DALCode)
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
 /// zx_Questions(zx_Questions)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clszx_QuestionsDA : clsCommBase4DA
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
 return clszx_QuestionsEN._CurrTabName;
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
if (string.IsNullOrEmpty(clszx_QuestionsEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clszx_QuestionsEN._ConnectString);
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
 if (string.IsNullOrEmpty(clszx_QuestionsEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clszx_QuestionsEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strzxQuestionsId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strzxQuestionsId)
{
strzxQuestionsId = strzxQuestionsId.Replace("'", "''");
if (strzxQuestionsId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:zx_Questions中,检查关键字,长度不正确!(clszx_QuestionsDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strzxQuestionsId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:zx_Questions中,关键字不能为空 或 null!(clszx_QuestionsDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strzxQuestionsId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clszx_QuestionsDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clszx_QuestionsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_QuestionsDA.GetSpecSQLObj();
strSQL = "Select * from zx_Questions where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_zx_Questions(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clszx_QuestionsDA: GetDataTable_zx_Questions)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_QuestionsDA.GetSpecSQLObj();
strSQL = "Select * from zx_Questions where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clszx_QuestionsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_QuestionsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clszx_QuestionsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_QuestionsDA.GetSpecSQLObj();
strSQL = "Select * from zx_Questions where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clszx_QuestionsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_QuestionsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clszx_QuestionsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_QuestionsDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_Questions where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_Questions where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clszx_QuestionsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_QuestionsDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from zx_Questions where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clszx_QuestionsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_QuestionsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} zx_Questions.* from zx_Questions Left Join {1} on {2} where {3} and zx_Questions.zxQuestionsId not in (Select top {5} zx_Questions.zxQuestionsId from zx_Questions Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_Questions where {1} and zxQuestionsId not in (Select top {2} zxQuestionsId from zx_Questions where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_Questions where {1} and zxQuestionsId not in (Select top {3} zxQuestionsId from zx_Questions where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clszx_QuestionsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_QuestionsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} zx_Questions.* from zx_Questions Left Join {1} on {2} where {3} and zx_Questions.zxQuestionsId not in (Select top {5} zx_Questions.zxQuestionsId from zx_Questions Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_Questions where {1} and zxQuestionsId not in (Select top {2} zxQuestionsId from zx_Questions where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_Questions where {1} and zxQuestionsId not in (Select top {3} zxQuestionsId from zx_Questions where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clszx_QuestionsEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clszx_QuestionsDA:GetObjLst)", objException.Message));
}
List<clszx_QuestionsEN> arrObjLst = new List<clszx_QuestionsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_QuestionsDA.GetSpecSQLObj();
strSQL = "Select * from zx_Questions where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_QuestionsEN objzx_QuestionsEN = new clszx_QuestionsEN();
try
{
objzx_QuestionsEN.zxQuestionsId = objRow[conzx_Questions.zxQuestionsId].ToString().Trim(); //提问Id
objzx_QuestionsEN.TextId = objRow[conzx_Questions.TextId] == DBNull.Value ? null : objRow[conzx_Questions.TextId].ToString().Trim(); //课件Id
objzx_QuestionsEN.QuestionsContent = objRow[conzx_Questions.QuestionsContent] == DBNull.Value ? null : objRow[conzx_Questions.QuestionsContent].ToString().Trim(); //提问内容
objzx_QuestionsEN.PdfPageNum = objRow[conzx_Questions.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Questions.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_QuestionsEN.PdfContent = objRow[conzx_Questions.PdfContent] == DBNull.Value ? null : objRow[conzx_Questions.PdfContent].ToString().Trim(); //Pdf内容
objzx_QuestionsEN.IsDelete = TransNullToBool(objRow[conzx_Questions.IsDelete].ToString().Trim()); //是否删除
objzx_QuestionsEN.IsPublic = TransNullToBool(objRow[conzx_Questions.IsPublic].ToString().Trim()); //是否公开
objzx_QuestionsEN.IsEnd = TransNullToBool(objRow[conzx_Questions.IsEnd].ToString().Trim()); //是否结束
objzx_QuestionsEN.VoteCount = objRow[conzx_Questions.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Questions.VoteCount].ToString().Trim()); //点赞计数
objzx_QuestionsEN.AnswerCount = objRow[conzx_Questions.AnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Questions.AnswerCount].ToString().Trim()); //回答计数
objzx_QuestionsEN.OrderNum = objRow[conzx_Questions.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Questions.OrderNum].ToString().Trim()); //序号
objzx_QuestionsEN.PdfPageTop = objRow[conzx_Questions.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Questions.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_QuestionsEN.PdfPageNumIn = objRow[conzx_Questions.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Questions.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_QuestionsEN.PdfDivTop = objRow[conzx_Questions.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Questions.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_QuestionsEN.PdfDivLet = objRow[conzx_Questions.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Questions.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_QuestionsEN.PdfZoom = objRow[conzx_Questions.PdfZoom] == DBNull.Value ? null : objRow[conzx_Questions.PdfZoom].ToString().Trim(); //PdfZoom
objzx_QuestionsEN.UpdUser = objRow[conzx_Questions.UpdUser] == DBNull.Value ? null : objRow[conzx_Questions.UpdUser].ToString().Trim(); //修改人
objzx_QuestionsEN.UpdDate = objRow[conzx_Questions.UpdDate] == DBNull.Value ? null : objRow[conzx_Questions.UpdDate].ToString().Trim(); //修改日期
objzx_QuestionsEN.Memo = objRow[conzx_Questions.Memo] == DBNull.Value ? null : objRow[conzx_Questions.Memo].ToString().Trim(); //备注
objzx_QuestionsEN.ZxqaPaperId = objRow[conzx_Questions.ZxqaPaperId].ToString().Trim(); //论文答疑Id
objzx_QuestionsEN.UserId = objRow[conzx_Questions.UserId] == DBNull.Value ? null : objRow[conzx_Questions.UserId].ToString().Trim(); //用户ID
objzx_QuestionsEN.zxQuestionsTypeId = objRow[conzx_Questions.zxQuestionsTypeId].ToString().Trim(); //问题类型Id
objzx_QuestionsEN.DiscussCount = objRow[conzx_Questions.DiscussCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Questions.DiscussCount].ToString().Trim()); //DiscussCount
objzx_QuestionsEN.GroupDiscussCount = objRow[conzx_Questions.GroupDiscussCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Questions.GroupDiscussCount].ToString().Trim()); //GroupDiscussCount
objzx_QuestionsEN.RecommendAnswerCount = objRow[conzx_Questions.RecommendAnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Questions.RecommendAnswerCount].ToString().Trim()); //RecommendAnswerCount
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clszx_QuestionsDA: GetObjLst)", objException.Message));
}
objzx_QuestionsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objzx_QuestionsEN);
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
public List<clszx_QuestionsEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clszx_QuestionsDA:GetObjLstByTabName)", objException.Message));
}
List<clszx_QuestionsEN> arrObjLst = new List<clszx_QuestionsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_QuestionsDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_QuestionsEN objzx_QuestionsEN = new clszx_QuestionsEN();
try
{
objzx_QuestionsEN.zxQuestionsId = objRow[conzx_Questions.zxQuestionsId].ToString().Trim(); //提问Id
objzx_QuestionsEN.TextId = objRow[conzx_Questions.TextId] == DBNull.Value ? null : objRow[conzx_Questions.TextId].ToString().Trim(); //课件Id
objzx_QuestionsEN.QuestionsContent = objRow[conzx_Questions.QuestionsContent] == DBNull.Value ? null : objRow[conzx_Questions.QuestionsContent].ToString().Trim(); //提问内容
objzx_QuestionsEN.PdfPageNum = objRow[conzx_Questions.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Questions.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_QuestionsEN.PdfContent = objRow[conzx_Questions.PdfContent] == DBNull.Value ? null : objRow[conzx_Questions.PdfContent].ToString().Trim(); //Pdf内容
objzx_QuestionsEN.IsDelete = TransNullToBool(objRow[conzx_Questions.IsDelete].ToString().Trim()); //是否删除
objzx_QuestionsEN.IsPublic = TransNullToBool(objRow[conzx_Questions.IsPublic].ToString().Trim()); //是否公开
objzx_QuestionsEN.IsEnd = TransNullToBool(objRow[conzx_Questions.IsEnd].ToString().Trim()); //是否结束
objzx_QuestionsEN.VoteCount = objRow[conzx_Questions.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Questions.VoteCount].ToString().Trim()); //点赞计数
objzx_QuestionsEN.AnswerCount = objRow[conzx_Questions.AnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Questions.AnswerCount].ToString().Trim()); //回答计数
objzx_QuestionsEN.OrderNum = objRow[conzx_Questions.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Questions.OrderNum].ToString().Trim()); //序号
objzx_QuestionsEN.PdfPageTop = objRow[conzx_Questions.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Questions.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_QuestionsEN.PdfPageNumIn = objRow[conzx_Questions.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Questions.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_QuestionsEN.PdfDivTop = objRow[conzx_Questions.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Questions.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_QuestionsEN.PdfDivLet = objRow[conzx_Questions.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Questions.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_QuestionsEN.PdfZoom = objRow[conzx_Questions.PdfZoom] == DBNull.Value ? null : objRow[conzx_Questions.PdfZoom].ToString().Trim(); //PdfZoom
objzx_QuestionsEN.UpdUser = objRow[conzx_Questions.UpdUser] == DBNull.Value ? null : objRow[conzx_Questions.UpdUser].ToString().Trim(); //修改人
objzx_QuestionsEN.UpdDate = objRow[conzx_Questions.UpdDate] == DBNull.Value ? null : objRow[conzx_Questions.UpdDate].ToString().Trim(); //修改日期
objzx_QuestionsEN.Memo = objRow[conzx_Questions.Memo] == DBNull.Value ? null : objRow[conzx_Questions.Memo].ToString().Trim(); //备注
objzx_QuestionsEN.ZxqaPaperId = objRow[conzx_Questions.ZxqaPaperId].ToString().Trim(); //论文答疑Id
objzx_QuestionsEN.UserId = objRow[conzx_Questions.UserId] == DBNull.Value ? null : objRow[conzx_Questions.UserId].ToString().Trim(); //用户ID
objzx_QuestionsEN.zxQuestionsTypeId = objRow[conzx_Questions.zxQuestionsTypeId].ToString().Trim(); //问题类型Id
objzx_QuestionsEN.DiscussCount = objRow[conzx_Questions.DiscussCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Questions.DiscussCount].ToString().Trim()); //DiscussCount
objzx_QuestionsEN.GroupDiscussCount = objRow[conzx_Questions.GroupDiscussCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Questions.GroupDiscussCount].ToString().Trim()); //GroupDiscussCount
objzx_QuestionsEN.RecommendAnswerCount = objRow[conzx_Questions.RecommendAnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Questions.RecommendAnswerCount].ToString().Trim()); //RecommendAnswerCount
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clszx_QuestionsDA: GetObjLst)", objException.Message));
}
objzx_QuestionsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objzx_QuestionsEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objzx_QuestionsEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getzx_Questions(ref clszx_QuestionsEN objzx_QuestionsEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_QuestionsDA.GetSpecSQLObj();
strSQL = "Select * from zx_Questions where zxQuestionsId = " + "'"+ objzx_QuestionsEN.zxQuestionsId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objzx_QuestionsEN.zxQuestionsId = objDT.Rows[0][conzx_Questions.zxQuestionsId].ToString().Trim(); //提问Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_QuestionsEN.TextId = objDT.Rows[0][conzx_Questions.TextId].ToString().Trim(); //课件Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_QuestionsEN.QuestionsContent = objDT.Rows[0][conzx_Questions.QuestionsContent].ToString().Trim(); //提问内容(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_QuestionsEN.PdfPageNum = TransNullToInt(objDT.Rows[0][conzx_Questions.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objzx_QuestionsEN.PdfContent = objDT.Rows[0][conzx_Questions.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objzx_QuestionsEN.IsDelete = TransNullToBool(objDT.Rows[0][conzx_Questions.IsDelete].ToString().Trim()); //是否删除(字段类型:bit,字段长度:1,是否可空:True)
 objzx_QuestionsEN.IsPublic = TransNullToBool(objDT.Rows[0][conzx_Questions.IsPublic].ToString().Trim()); //是否公开(字段类型:bit,字段长度:1,是否可空:True)
 objzx_QuestionsEN.IsEnd = TransNullToBool(objDT.Rows[0][conzx_Questions.IsEnd].ToString().Trim()); //是否结束(字段类型:bit,字段长度:1,是否可空:True)
 objzx_QuestionsEN.VoteCount = TransNullToInt(objDT.Rows[0][conzx_Questions.VoteCount].ToString().Trim()); //点赞计数(字段类型:int,字段长度:4,是否可空:True)
 objzx_QuestionsEN.AnswerCount = TransNullToInt(objDT.Rows[0][conzx_Questions.AnswerCount].ToString().Trim()); //回答计数(字段类型:int,字段长度:4,是否可空:True)
 objzx_QuestionsEN.OrderNum = TransNullToInt(objDT.Rows[0][conzx_Questions.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objzx_QuestionsEN.PdfPageTop = TransNullToInt(objDT.Rows[0][conzx_Questions.PdfPageTop].ToString().Trim()); //pdf页面顶部位置(字段类型:int,字段长度:4,是否可空:True)
 objzx_QuestionsEN.PdfPageNumIn = objDT.Rows[0][conzx_Questions.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_QuestionsEN.PdfDivTop = objDT.Rows[0][conzx_Questions.PdfDivTop].ToString().Trim(); //PdfDivTop(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_QuestionsEN.PdfDivLet = objDT.Rows[0][conzx_Questions.PdfDivLet].ToString().Trim(); //PdfDivLet(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_QuestionsEN.PdfZoom = objDT.Rows[0][conzx_Questions.PdfZoom].ToString().Trim(); //PdfZoom(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_QuestionsEN.UpdUser = objDT.Rows[0][conzx_Questions.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_QuestionsEN.UpdDate = objDT.Rows[0][conzx_Questions.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_QuestionsEN.Memo = objDT.Rows[0][conzx_Questions.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_QuestionsEN.ZxqaPaperId = objDT.Rows[0][conzx_Questions.ZxqaPaperId].ToString().Trim(); //论文答疑Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_QuestionsEN.UserId = objDT.Rows[0][conzx_Questions.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objzx_QuestionsEN.zxQuestionsTypeId = objDT.Rows[0][conzx_Questions.zxQuestionsTypeId].ToString().Trim(); //问题类型Id(字段类型:char,字段长度:2,是否可空:False)
 objzx_QuestionsEN.DiscussCount = TransNullToInt(objDT.Rows[0][conzx_Questions.DiscussCount].ToString().Trim()); //DiscussCount(字段类型:int,字段长度:4,是否可空:True)
 objzx_QuestionsEN.GroupDiscussCount = TransNullToInt(objDT.Rows[0][conzx_Questions.GroupDiscussCount].ToString().Trim()); //GroupDiscussCount(字段类型:int,字段长度:4,是否可空:True)
 objzx_QuestionsEN.RecommendAnswerCount = TransNullToInt(objDT.Rows[0][conzx_Questions.RecommendAnswerCount].ToString().Trim()); //RecommendAnswerCount(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clszx_QuestionsDA: Getzx_Questions)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strzxQuestionsId">表关键字</param>
 /// <returns>表对象</returns>
public clszx_QuestionsEN GetObjByzxQuestionsId(string strzxQuestionsId)
{
CheckPrimaryKey(strzxQuestionsId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_QuestionsDA.GetSpecSQLObj();
strSQL = "Select * from zx_Questions where zxQuestionsId = " + "'"+ strzxQuestionsId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clszx_QuestionsEN objzx_QuestionsEN = new clszx_QuestionsEN();
try
{
 objzx_QuestionsEN.zxQuestionsId = objRow[conzx_Questions.zxQuestionsId].ToString().Trim(); //提问Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_QuestionsEN.TextId = objRow[conzx_Questions.TextId] == DBNull.Value ? null : objRow[conzx_Questions.TextId].ToString().Trim(); //课件Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_QuestionsEN.QuestionsContent = objRow[conzx_Questions.QuestionsContent] == DBNull.Value ? null : objRow[conzx_Questions.QuestionsContent].ToString().Trim(); //提问内容(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_QuestionsEN.PdfPageNum = objRow[conzx_Questions.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objzx_QuestionsEN.PdfContent = objRow[conzx_Questions.PdfContent] == DBNull.Value ? null : objRow[conzx_Questions.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objzx_QuestionsEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[conzx_Questions.IsDelete].ToString().Trim()); //是否删除(字段类型:bit,字段长度:1,是否可空:True)
 objzx_QuestionsEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conzx_Questions.IsPublic].ToString().Trim()); //是否公开(字段类型:bit,字段长度:1,是否可空:True)
 objzx_QuestionsEN.IsEnd = clsEntityBase2.TransNullToBool_S(objRow[conzx_Questions.IsEnd].ToString().Trim()); //是否结束(字段类型:bit,字段长度:1,是否可空:True)
 objzx_QuestionsEN.VoteCount = objRow[conzx_Questions.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.VoteCount].ToString().Trim()); //点赞计数(字段类型:int,字段长度:4,是否可空:True)
 objzx_QuestionsEN.AnswerCount = objRow[conzx_Questions.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.AnswerCount].ToString().Trim()); //回答计数(字段类型:int,字段长度:4,是否可空:True)
 objzx_QuestionsEN.OrderNum = objRow[conzx_Questions.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objzx_QuestionsEN.PdfPageTop = objRow[conzx_Questions.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.PdfPageTop].ToString().Trim()); //pdf页面顶部位置(字段类型:int,字段长度:4,是否可空:True)
 objzx_QuestionsEN.PdfPageNumIn = objRow[conzx_Questions.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Questions.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_QuestionsEN.PdfDivTop = objRow[conzx_Questions.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Questions.PdfDivTop].ToString().Trim(); //PdfDivTop(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_QuestionsEN.PdfDivLet = objRow[conzx_Questions.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Questions.PdfDivLet].ToString().Trim(); //PdfDivLet(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_QuestionsEN.PdfZoom = objRow[conzx_Questions.PdfZoom] == DBNull.Value ? null : objRow[conzx_Questions.PdfZoom].ToString().Trim(); //PdfZoom(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_QuestionsEN.UpdUser = objRow[conzx_Questions.UpdUser] == DBNull.Value ? null : objRow[conzx_Questions.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_QuestionsEN.UpdDate = objRow[conzx_Questions.UpdDate] == DBNull.Value ? null : objRow[conzx_Questions.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_QuestionsEN.Memo = objRow[conzx_Questions.Memo] == DBNull.Value ? null : objRow[conzx_Questions.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_QuestionsEN.ZxqaPaperId = objRow[conzx_Questions.ZxqaPaperId].ToString().Trim(); //论文答疑Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_QuestionsEN.UserId = objRow[conzx_Questions.UserId] == DBNull.Value ? null : objRow[conzx_Questions.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objzx_QuestionsEN.zxQuestionsTypeId = objRow[conzx_Questions.zxQuestionsTypeId].ToString().Trim(); //问题类型Id(字段类型:char,字段长度:2,是否可空:False)
 objzx_QuestionsEN.DiscussCount = objRow[conzx_Questions.DiscussCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.DiscussCount].ToString().Trim()); //DiscussCount(字段类型:int,字段长度:4,是否可空:True)
 objzx_QuestionsEN.GroupDiscussCount = objRow[conzx_Questions.GroupDiscussCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.GroupDiscussCount].ToString().Trim()); //GroupDiscussCount(字段类型:int,字段长度:4,是否可空:True)
 objzx_QuestionsEN.RecommendAnswerCount = objRow[conzx_Questions.RecommendAnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Questions.RecommendAnswerCount].ToString().Trim()); //RecommendAnswerCount(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clszx_QuestionsDA: GetObjByzxQuestionsId)", objException.Message));
}
return objzx_QuestionsEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clszx_QuestionsEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clszx_QuestionsDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_QuestionsDA.GetSpecSQLObj();
strSQL = "Select * from zx_Questions where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clszx_QuestionsEN objzx_QuestionsEN = new clszx_QuestionsEN()
{
zxQuestionsId = objRow[conzx_Questions.zxQuestionsId].ToString().Trim(), //提问Id
TextId = objRow[conzx_Questions.TextId] == DBNull.Value ? null : objRow[conzx_Questions.TextId].ToString().Trim(), //课件Id
QuestionsContent = objRow[conzx_Questions.QuestionsContent] == DBNull.Value ? null : objRow[conzx_Questions.QuestionsContent].ToString().Trim(), //提问内容
PdfPageNum = objRow[conzx_Questions.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Questions.PdfPageNum].ToString().Trim()), //Pdf页码
PdfContent = objRow[conzx_Questions.PdfContent] == DBNull.Value ? null : objRow[conzx_Questions.PdfContent].ToString().Trim(), //Pdf内容
IsDelete = TransNullToBool(objRow[conzx_Questions.IsDelete].ToString().Trim()), //是否删除
IsPublic = TransNullToBool(objRow[conzx_Questions.IsPublic].ToString().Trim()), //是否公开
IsEnd = TransNullToBool(objRow[conzx_Questions.IsEnd].ToString().Trim()), //是否结束
VoteCount = objRow[conzx_Questions.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Questions.VoteCount].ToString().Trim()), //点赞计数
AnswerCount = objRow[conzx_Questions.AnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Questions.AnswerCount].ToString().Trim()), //回答计数
OrderNum = objRow[conzx_Questions.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Questions.OrderNum].ToString().Trim()), //序号
PdfPageTop = objRow[conzx_Questions.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Questions.PdfPageTop].ToString().Trim()), //pdf页面顶部位置
PdfPageNumIn = objRow[conzx_Questions.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Questions.PdfPageNumIn].ToString().Trim(), //PdfPageNumIn
PdfDivTop = objRow[conzx_Questions.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Questions.PdfDivTop].ToString().Trim(), //PdfDivTop
PdfDivLet = objRow[conzx_Questions.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Questions.PdfDivLet].ToString().Trim(), //PdfDivLet
PdfZoom = objRow[conzx_Questions.PdfZoom] == DBNull.Value ? null : objRow[conzx_Questions.PdfZoom].ToString().Trim(), //PdfZoom
UpdUser = objRow[conzx_Questions.UpdUser] == DBNull.Value ? null : objRow[conzx_Questions.UpdUser].ToString().Trim(), //修改人
UpdDate = objRow[conzx_Questions.UpdDate] == DBNull.Value ? null : objRow[conzx_Questions.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[conzx_Questions.Memo] == DBNull.Value ? null : objRow[conzx_Questions.Memo].ToString().Trim(), //备注
ZxqaPaperId = objRow[conzx_Questions.ZxqaPaperId].ToString().Trim(), //论文答疑Id
UserId = objRow[conzx_Questions.UserId] == DBNull.Value ? null : objRow[conzx_Questions.UserId].ToString().Trim(), //用户ID
zxQuestionsTypeId = objRow[conzx_Questions.zxQuestionsTypeId].ToString().Trim(), //问题类型Id
DiscussCount = objRow[conzx_Questions.DiscussCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Questions.DiscussCount].ToString().Trim()), //DiscussCount
GroupDiscussCount = objRow[conzx_Questions.GroupDiscussCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Questions.GroupDiscussCount].ToString().Trim()), //GroupDiscussCount
RecommendAnswerCount = objRow[conzx_Questions.RecommendAnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Questions.RecommendAnswerCount].ToString().Trim()) //RecommendAnswerCount
};
objzx_QuestionsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_QuestionsEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clszx_QuestionsDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clszx_QuestionsEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clszx_QuestionsEN objzx_QuestionsEN = new clszx_QuestionsEN();
try
{
objzx_QuestionsEN.zxQuestionsId = objRow[conzx_Questions.zxQuestionsId].ToString().Trim(); //提问Id
objzx_QuestionsEN.TextId = objRow[conzx_Questions.TextId] == DBNull.Value ? null : objRow[conzx_Questions.TextId].ToString().Trim(); //课件Id
objzx_QuestionsEN.QuestionsContent = objRow[conzx_Questions.QuestionsContent] == DBNull.Value ? null : objRow[conzx_Questions.QuestionsContent].ToString().Trim(); //提问内容
objzx_QuestionsEN.PdfPageNum = objRow[conzx_Questions.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Questions.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_QuestionsEN.PdfContent = objRow[conzx_Questions.PdfContent] == DBNull.Value ? null : objRow[conzx_Questions.PdfContent].ToString().Trim(); //Pdf内容
objzx_QuestionsEN.IsDelete = TransNullToBool(objRow[conzx_Questions.IsDelete].ToString().Trim()); //是否删除
objzx_QuestionsEN.IsPublic = TransNullToBool(objRow[conzx_Questions.IsPublic].ToString().Trim()); //是否公开
objzx_QuestionsEN.IsEnd = TransNullToBool(objRow[conzx_Questions.IsEnd].ToString().Trim()); //是否结束
objzx_QuestionsEN.VoteCount = objRow[conzx_Questions.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Questions.VoteCount].ToString().Trim()); //点赞计数
objzx_QuestionsEN.AnswerCount = objRow[conzx_Questions.AnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Questions.AnswerCount].ToString().Trim()); //回答计数
objzx_QuestionsEN.OrderNum = objRow[conzx_Questions.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Questions.OrderNum].ToString().Trim()); //序号
objzx_QuestionsEN.PdfPageTop = objRow[conzx_Questions.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Questions.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_QuestionsEN.PdfPageNumIn = objRow[conzx_Questions.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Questions.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_QuestionsEN.PdfDivTop = objRow[conzx_Questions.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Questions.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_QuestionsEN.PdfDivLet = objRow[conzx_Questions.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Questions.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_QuestionsEN.PdfZoom = objRow[conzx_Questions.PdfZoom] == DBNull.Value ? null : objRow[conzx_Questions.PdfZoom].ToString().Trim(); //PdfZoom
objzx_QuestionsEN.UpdUser = objRow[conzx_Questions.UpdUser] == DBNull.Value ? null : objRow[conzx_Questions.UpdUser].ToString().Trim(); //修改人
objzx_QuestionsEN.UpdDate = objRow[conzx_Questions.UpdDate] == DBNull.Value ? null : objRow[conzx_Questions.UpdDate].ToString().Trim(); //修改日期
objzx_QuestionsEN.Memo = objRow[conzx_Questions.Memo] == DBNull.Value ? null : objRow[conzx_Questions.Memo].ToString().Trim(); //备注
objzx_QuestionsEN.ZxqaPaperId = objRow[conzx_Questions.ZxqaPaperId].ToString().Trim(); //论文答疑Id
objzx_QuestionsEN.UserId = objRow[conzx_Questions.UserId] == DBNull.Value ? null : objRow[conzx_Questions.UserId].ToString().Trim(); //用户ID
objzx_QuestionsEN.zxQuestionsTypeId = objRow[conzx_Questions.zxQuestionsTypeId].ToString().Trim(); //问题类型Id
objzx_QuestionsEN.DiscussCount = objRow[conzx_Questions.DiscussCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Questions.DiscussCount].ToString().Trim()); //DiscussCount
objzx_QuestionsEN.GroupDiscussCount = objRow[conzx_Questions.GroupDiscussCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Questions.GroupDiscussCount].ToString().Trim()); //GroupDiscussCount
objzx_QuestionsEN.RecommendAnswerCount = objRow[conzx_Questions.RecommendAnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Questions.RecommendAnswerCount].ToString().Trim()); //RecommendAnswerCount
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clszx_QuestionsDA: GetObjByDataRowzx_Questions)", objException.Message));
}
objzx_QuestionsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_QuestionsEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clszx_QuestionsEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clszx_QuestionsEN objzx_QuestionsEN = new clszx_QuestionsEN();
try
{
objzx_QuestionsEN.zxQuestionsId = objRow[conzx_Questions.zxQuestionsId].ToString().Trim(); //提问Id
objzx_QuestionsEN.TextId = objRow[conzx_Questions.TextId] == DBNull.Value ? null : objRow[conzx_Questions.TextId].ToString().Trim(); //课件Id
objzx_QuestionsEN.QuestionsContent = objRow[conzx_Questions.QuestionsContent] == DBNull.Value ? null : objRow[conzx_Questions.QuestionsContent].ToString().Trim(); //提问内容
objzx_QuestionsEN.PdfPageNum = objRow[conzx_Questions.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Questions.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_QuestionsEN.PdfContent = objRow[conzx_Questions.PdfContent] == DBNull.Value ? null : objRow[conzx_Questions.PdfContent].ToString().Trim(); //Pdf内容
objzx_QuestionsEN.IsDelete = TransNullToBool(objRow[conzx_Questions.IsDelete].ToString().Trim()); //是否删除
objzx_QuestionsEN.IsPublic = TransNullToBool(objRow[conzx_Questions.IsPublic].ToString().Trim()); //是否公开
objzx_QuestionsEN.IsEnd = TransNullToBool(objRow[conzx_Questions.IsEnd].ToString().Trim()); //是否结束
objzx_QuestionsEN.VoteCount = objRow[conzx_Questions.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Questions.VoteCount].ToString().Trim()); //点赞计数
objzx_QuestionsEN.AnswerCount = objRow[conzx_Questions.AnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Questions.AnswerCount].ToString().Trim()); //回答计数
objzx_QuestionsEN.OrderNum = objRow[conzx_Questions.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Questions.OrderNum].ToString().Trim()); //序号
objzx_QuestionsEN.PdfPageTop = objRow[conzx_Questions.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Questions.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_QuestionsEN.PdfPageNumIn = objRow[conzx_Questions.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Questions.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_QuestionsEN.PdfDivTop = objRow[conzx_Questions.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Questions.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_QuestionsEN.PdfDivLet = objRow[conzx_Questions.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Questions.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_QuestionsEN.PdfZoom = objRow[conzx_Questions.PdfZoom] == DBNull.Value ? null : objRow[conzx_Questions.PdfZoom].ToString().Trim(); //PdfZoom
objzx_QuestionsEN.UpdUser = objRow[conzx_Questions.UpdUser] == DBNull.Value ? null : objRow[conzx_Questions.UpdUser].ToString().Trim(); //修改人
objzx_QuestionsEN.UpdDate = objRow[conzx_Questions.UpdDate] == DBNull.Value ? null : objRow[conzx_Questions.UpdDate].ToString().Trim(); //修改日期
objzx_QuestionsEN.Memo = objRow[conzx_Questions.Memo] == DBNull.Value ? null : objRow[conzx_Questions.Memo].ToString().Trim(); //备注
objzx_QuestionsEN.ZxqaPaperId = objRow[conzx_Questions.ZxqaPaperId].ToString().Trim(); //论文答疑Id
objzx_QuestionsEN.UserId = objRow[conzx_Questions.UserId] == DBNull.Value ? null : objRow[conzx_Questions.UserId].ToString().Trim(); //用户ID
objzx_QuestionsEN.zxQuestionsTypeId = objRow[conzx_Questions.zxQuestionsTypeId].ToString().Trim(); //问题类型Id
objzx_QuestionsEN.DiscussCount = objRow[conzx_Questions.DiscussCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Questions.DiscussCount].ToString().Trim()); //DiscussCount
objzx_QuestionsEN.GroupDiscussCount = objRow[conzx_Questions.GroupDiscussCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Questions.GroupDiscussCount].ToString().Trim()); //GroupDiscussCount
objzx_QuestionsEN.RecommendAnswerCount = objRow[conzx_Questions.RecommendAnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Questions.RecommendAnswerCount].ToString().Trim()); //RecommendAnswerCount
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clszx_QuestionsDA: GetObjByDataRow)", objException.Message));
}
objzx_QuestionsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_QuestionsEN;
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
objSQL = clszx_QuestionsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clszx_QuestionsEN._CurrTabName, conzx_Questions.zxQuestionsId, 8, "");
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
objSQL = clszx_QuestionsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clszx_QuestionsEN._CurrTabName, conzx_Questions.zxQuestionsId, 8, strPrefix);
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
 objSQL = clszx_QuestionsDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select zxQuestionsId from zx_Questions where " + strCondition;
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
 objSQL = clszx_QuestionsDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select zxQuestionsId from zx_Questions where " + strCondition;
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
 /// <param name = "strzxQuestionsId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strzxQuestionsId)
{
CheckPrimaryKey(strzxQuestionsId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_QuestionsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("zx_Questions", "zxQuestionsId = " + "'"+ strzxQuestionsId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clszx_QuestionsDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_QuestionsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("zx_Questions", strCondition))
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
objSQL = clszx_QuestionsDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("zx_Questions");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clszx_QuestionsEN objzx_QuestionsEN)
 {
 if (objzx_QuestionsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_QuestionsEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_QuestionsDA.GetSpecSQLObj();
strSQL = "Select * from zx_Questions where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "zx_Questions");
objRow = objDS.Tables["zx_Questions"].NewRow();
objRow[conzx_Questions.zxQuestionsId] = objzx_QuestionsEN.zxQuestionsId; //提问Id
 if (objzx_QuestionsEN.TextId !=  "")
 {
objRow[conzx_Questions.TextId] = objzx_QuestionsEN.TextId; //课件Id
 }
 if (objzx_QuestionsEN.QuestionsContent !=  "")
 {
objRow[conzx_Questions.QuestionsContent] = objzx_QuestionsEN.QuestionsContent; //提问内容
 }
objRow[conzx_Questions.PdfPageNum] = objzx_QuestionsEN.PdfPageNum; //Pdf页码
 if (objzx_QuestionsEN.PdfContent !=  "")
 {
objRow[conzx_Questions.PdfContent] = objzx_QuestionsEN.PdfContent; //Pdf内容
 }
objRow[conzx_Questions.IsDelete] = objzx_QuestionsEN.IsDelete; //是否删除
objRow[conzx_Questions.IsPublic] = objzx_QuestionsEN.IsPublic; //是否公开
objRow[conzx_Questions.IsEnd] = objzx_QuestionsEN.IsEnd; //是否结束
objRow[conzx_Questions.VoteCount] = objzx_QuestionsEN.VoteCount; //点赞计数
objRow[conzx_Questions.AnswerCount] = objzx_QuestionsEN.AnswerCount; //回答计数
objRow[conzx_Questions.OrderNum] = objzx_QuestionsEN.OrderNum; //序号
objRow[conzx_Questions.PdfPageTop] = objzx_QuestionsEN.PdfPageTop; //pdf页面顶部位置
 if (objzx_QuestionsEN.PdfPageNumIn !=  "")
 {
objRow[conzx_Questions.PdfPageNumIn] = objzx_QuestionsEN.PdfPageNumIn; //PdfPageNumIn
 }
 if (objzx_QuestionsEN.PdfDivTop !=  "")
 {
objRow[conzx_Questions.PdfDivTop] = objzx_QuestionsEN.PdfDivTop; //PdfDivTop
 }
 if (objzx_QuestionsEN.PdfDivLet !=  "")
 {
objRow[conzx_Questions.PdfDivLet] = objzx_QuestionsEN.PdfDivLet; //PdfDivLet
 }
 if (objzx_QuestionsEN.PdfZoom !=  "")
 {
objRow[conzx_Questions.PdfZoom] = objzx_QuestionsEN.PdfZoom; //PdfZoom
 }
 if (objzx_QuestionsEN.UpdUser !=  "")
 {
objRow[conzx_Questions.UpdUser] = objzx_QuestionsEN.UpdUser; //修改人
 }
 if (objzx_QuestionsEN.UpdDate !=  "")
 {
objRow[conzx_Questions.UpdDate] = objzx_QuestionsEN.UpdDate; //修改日期
 }
 if (objzx_QuestionsEN.Memo !=  "")
 {
objRow[conzx_Questions.Memo] = objzx_QuestionsEN.Memo; //备注
 }
objRow[conzx_Questions.ZxqaPaperId] = objzx_QuestionsEN.ZxqaPaperId; //论文答疑Id
 if (objzx_QuestionsEN.UserId !=  "")
 {
objRow[conzx_Questions.UserId] = objzx_QuestionsEN.UserId; //用户ID
 }
objRow[conzx_Questions.zxQuestionsTypeId] = objzx_QuestionsEN.zxQuestionsTypeId; //问题类型Id
objRow[conzx_Questions.DiscussCount] = objzx_QuestionsEN.DiscussCount; //DiscussCount
objRow[conzx_Questions.GroupDiscussCount] = objzx_QuestionsEN.GroupDiscussCount; //GroupDiscussCount
objRow[conzx_Questions.RecommendAnswerCount] = objzx_QuestionsEN.RecommendAnswerCount; //RecommendAnswerCount
objDS.Tables[clszx_QuestionsEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clszx_QuestionsEN._CurrTabName);
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
 /// <param name = "objzx_QuestionsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clszx_QuestionsEN objzx_QuestionsEN)
{
 if (objzx_QuestionsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_QuestionsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_QuestionsEN.zxQuestionsId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.zxQuestionsId);
 var strzxQuestionsId = objzx_QuestionsEN.zxQuestionsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxQuestionsId + "'");
 }
 
 if (objzx_QuestionsEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.TextId);
 var strTextId = objzx_QuestionsEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 if (objzx_QuestionsEN.QuestionsContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.QuestionsContent);
 var strQuestionsContent = objzx_QuestionsEN.QuestionsContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionsContent + "'");
 }
 
 if (objzx_QuestionsEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.PdfPageNum);
 arrValueListForInsert.Add(objzx_QuestionsEN.PdfPageNum.ToString());
 }
 
 if (objzx_QuestionsEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.PdfContent);
 var strPdfContent = objzx_QuestionsEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 arrFieldListForInsert.Add(conzx_Questions.IsDelete);
 arrValueListForInsert.Add("'" + (objzx_QuestionsEN.IsDelete  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conzx_Questions.IsPublic);
 arrValueListForInsert.Add("'" + (objzx_QuestionsEN.IsPublic  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conzx_Questions.IsEnd);
 arrValueListForInsert.Add("'" + (objzx_QuestionsEN.IsEnd  ==  false ? "0" : "1") + "'");
 
 if (objzx_QuestionsEN.VoteCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.VoteCount);
 arrValueListForInsert.Add(objzx_QuestionsEN.VoteCount.ToString());
 }
 
 if (objzx_QuestionsEN.AnswerCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.AnswerCount);
 arrValueListForInsert.Add(objzx_QuestionsEN.AnswerCount.ToString());
 }
 
 if (objzx_QuestionsEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.OrderNum);
 arrValueListForInsert.Add(objzx_QuestionsEN.OrderNum.ToString());
 }
 
 if (objzx_QuestionsEN.PdfPageTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.PdfPageTop);
 arrValueListForInsert.Add(objzx_QuestionsEN.PdfPageTop.ToString());
 }
 
 if (objzx_QuestionsEN.PdfPageNumIn !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.PdfPageNumIn);
 var strPdfPageNumIn = objzx_QuestionsEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfPageNumIn + "'");
 }
 
 if (objzx_QuestionsEN.PdfDivTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.PdfDivTop);
 var strPdfDivTop = objzx_QuestionsEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivTop + "'");
 }
 
 if (objzx_QuestionsEN.PdfDivLet !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.PdfDivLet);
 var strPdfDivLet = objzx_QuestionsEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivLet + "'");
 }
 
 if (objzx_QuestionsEN.PdfZoom !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.PdfZoom);
 var strPdfZoom = objzx_QuestionsEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfZoom + "'");
 }
 
 if (objzx_QuestionsEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.UpdUser);
 var strUpdUser = objzx_QuestionsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_QuestionsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.UpdDate);
 var strUpdDate = objzx_QuestionsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_QuestionsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.Memo);
 var strMemo = objzx_QuestionsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_QuestionsEN.ZxqaPaperId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.ZxqaPaperId);
 var strZxqaPaperId = objzx_QuestionsEN.ZxqaPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strZxqaPaperId + "'");
 }
 
 if (objzx_QuestionsEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.UserId);
 var strUserId = objzx_QuestionsEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objzx_QuestionsEN.zxQuestionsTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.zxQuestionsTypeId);
 var strzxQuestionsTypeId = objzx_QuestionsEN.zxQuestionsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxQuestionsTypeId + "'");
 }
 
 if (objzx_QuestionsEN.DiscussCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.DiscussCount);
 arrValueListForInsert.Add(objzx_QuestionsEN.DiscussCount.ToString());
 }
 
 if (objzx_QuestionsEN.GroupDiscussCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.GroupDiscussCount);
 arrValueListForInsert.Add(objzx_QuestionsEN.GroupDiscussCount.ToString());
 }
 
 if (objzx_QuestionsEN.RecommendAnswerCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.RecommendAnswerCount);
 arrValueListForInsert.Add(objzx_QuestionsEN.RecommendAnswerCount.ToString());
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_Questions");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_QuestionsDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objzx_QuestionsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clszx_QuestionsEN objzx_QuestionsEN)
{
 if (objzx_QuestionsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_QuestionsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_QuestionsEN.zxQuestionsId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.zxQuestionsId);
 var strzxQuestionsId = objzx_QuestionsEN.zxQuestionsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxQuestionsId + "'");
 }
 
 if (objzx_QuestionsEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.TextId);
 var strTextId = objzx_QuestionsEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 if (objzx_QuestionsEN.QuestionsContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.QuestionsContent);
 var strQuestionsContent = objzx_QuestionsEN.QuestionsContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionsContent + "'");
 }
 
 if (objzx_QuestionsEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.PdfPageNum);
 arrValueListForInsert.Add(objzx_QuestionsEN.PdfPageNum.ToString());
 }
 
 if (objzx_QuestionsEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.PdfContent);
 var strPdfContent = objzx_QuestionsEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 arrFieldListForInsert.Add(conzx_Questions.IsDelete);
 arrValueListForInsert.Add("'" + (objzx_QuestionsEN.IsDelete  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conzx_Questions.IsPublic);
 arrValueListForInsert.Add("'" + (objzx_QuestionsEN.IsPublic  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conzx_Questions.IsEnd);
 arrValueListForInsert.Add("'" + (objzx_QuestionsEN.IsEnd  ==  false ? "0" : "1") + "'");
 
 if (objzx_QuestionsEN.VoteCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.VoteCount);
 arrValueListForInsert.Add(objzx_QuestionsEN.VoteCount.ToString());
 }
 
 if (objzx_QuestionsEN.AnswerCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.AnswerCount);
 arrValueListForInsert.Add(objzx_QuestionsEN.AnswerCount.ToString());
 }
 
 if (objzx_QuestionsEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.OrderNum);
 arrValueListForInsert.Add(objzx_QuestionsEN.OrderNum.ToString());
 }
 
 if (objzx_QuestionsEN.PdfPageTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.PdfPageTop);
 arrValueListForInsert.Add(objzx_QuestionsEN.PdfPageTop.ToString());
 }
 
 if (objzx_QuestionsEN.PdfPageNumIn !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.PdfPageNumIn);
 var strPdfPageNumIn = objzx_QuestionsEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfPageNumIn + "'");
 }
 
 if (objzx_QuestionsEN.PdfDivTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.PdfDivTop);
 var strPdfDivTop = objzx_QuestionsEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivTop + "'");
 }
 
 if (objzx_QuestionsEN.PdfDivLet !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.PdfDivLet);
 var strPdfDivLet = objzx_QuestionsEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivLet + "'");
 }
 
 if (objzx_QuestionsEN.PdfZoom !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.PdfZoom);
 var strPdfZoom = objzx_QuestionsEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfZoom + "'");
 }
 
 if (objzx_QuestionsEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.UpdUser);
 var strUpdUser = objzx_QuestionsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_QuestionsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.UpdDate);
 var strUpdDate = objzx_QuestionsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_QuestionsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.Memo);
 var strMemo = objzx_QuestionsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_QuestionsEN.ZxqaPaperId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.ZxqaPaperId);
 var strZxqaPaperId = objzx_QuestionsEN.ZxqaPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strZxqaPaperId + "'");
 }
 
 if (objzx_QuestionsEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.UserId);
 var strUserId = objzx_QuestionsEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objzx_QuestionsEN.zxQuestionsTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.zxQuestionsTypeId);
 var strzxQuestionsTypeId = objzx_QuestionsEN.zxQuestionsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxQuestionsTypeId + "'");
 }
 
 if (objzx_QuestionsEN.DiscussCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.DiscussCount);
 arrValueListForInsert.Add(objzx_QuestionsEN.DiscussCount.ToString());
 }
 
 if (objzx_QuestionsEN.GroupDiscussCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.GroupDiscussCount);
 arrValueListForInsert.Add(objzx_QuestionsEN.GroupDiscussCount.ToString());
 }
 
 if (objzx_QuestionsEN.RecommendAnswerCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.RecommendAnswerCount);
 arrValueListForInsert.Add(objzx_QuestionsEN.RecommendAnswerCount.ToString());
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_Questions");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_QuestionsDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objzx_QuestionsEN.zxQuestionsId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objzx_QuestionsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clszx_QuestionsEN objzx_QuestionsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objzx_QuestionsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_QuestionsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_QuestionsEN.zxQuestionsId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.zxQuestionsId);
 var strzxQuestionsId = objzx_QuestionsEN.zxQuestionsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxQuestionsId + "'");
 }
 
 if (objzx_QuestionsEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.TextId);
 var strTextId = objzx_QuestionsEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 if (objzx_QuestionsEN.QuestionsContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.QuestionsContent);
 var strQuestionsContent = objzx_QuestionsEN.QuestionsContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionsContent + "'");
 }
 
 if (objzx_QuestionsEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.PdfPageNum);
 arrValueListForInsert.Add(objzx_QuestionsEN.PdfPageNum.ToString());
 }
 
 if (objzx_QuestionsEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.PdfContent);
 var strPdfContent = objzx_QuestionsEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 arrFieldListForInsert.Add(conzx_Questions.IsDelete);
 arrValueListForInsert.Add("'" + (objzx_QuestionsEN.IsDelete  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conzx_Questions.IsPublic);
 arrValueListForInsert.Add("'" + (objzx_QuestionsEN.IsPublic  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conzx_Questions.IsEnd);
 arrValueListForInsert.Add("'" + (objzx_QuestionsEN.IsEnd  ==  false ? "0" : "1") + "'");
 
 if (objzx_QuestionsEN.VoteCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.VoteCount);
 arrValueListForInsert.Add(objzx_QuestionsEN.VoteCount.ToString());
 }
 
 if (objzx_QuestionsEN.AnswerCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.AnswerCount);
 arrValueListForInsert.Add(objzx_QuestionsEN.AnswerCount.ToString());
 }
 
 if (objzx_QuestionsEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.OrderNum);
 arrValueListForInsert.Add(objzx_QuestionsEN.OrderNum.ToString());
 }
 
 if (objzx_QuestionsEN.PdfPageTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.PdfPageTop);
 arrValueListForInsert.Add(objzx_QuestionsEN.PdfPageTop.ToString());
 }
 
 if (objzx_QuestionsEN.PdfPageNumIn !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.PdfPageNumIn);
 var strPdfPageNumIn = objzx_QuestionsEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfPageNumIn + "'");
 }
 
 if (objzx_QuestionsEN.PdfDivTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.PdfDivTop);
 var strPdfDivTop = objzx_QuestionsEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivTop + "'");
 }
 
 if (objzx_QuestionsEN.PdfDivLet !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.PdfDivLet);
 var strPdfDivLet = objzx_QuestionsEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivLet + "'");
 }
 
 if (objzx_QuestionsEN.PdfZoom !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.PdfZoom);
 var strPdfZoom = objzx_QuestionsEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfZoom + "'");
 }
 
 if (objzx_QuestionsEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.UpdUser);
 var strUpdUser = objzx_QuestionsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_QuestionsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.UpdDate);
 var strUpdDate = objzx_QuestionsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_QuestionsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.Memo);
 var strMemo = objzx_QuestionsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_QuestionsEN.ZxqaPaperId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.ZxqaPaperId);
 var strZxqaPaperId = objzx_QuestionsEN.ZxqaPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strZxqaPaperId + "'");
 }
 
 if (objzx_QuestionsEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.UserId);
 var strUserId = objzx_QuestionsEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objzx_QuestionsEN.zxQuestionsTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.zxQuestionsTypeId);
 var strzxQuestionsTypeId = objzx_QuestionsEN.zxQuestionsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxQuestionsTypeId + "'");
 }
 
 if (objzx_QuestionsEN.DiscussCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.DiscussCount);
 arrValueListForInsert.Add(objzx_QuestionsEN.DiscussCount.ToString());
 }
 
 if (objzx_QuestionsEN.GroupDiscussCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.GroupDiscussCount);
 arrValueListForInsert.Add(objzx_QuestionsEN.GroupDiscussCount.ToString());
 }
 
 if (objzx_QuestionsEN.RecommendAnswerCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.RecommendAnswerCount);
 arrValueListForInsert.Add(objzx_QuestionsEN.RecommendAnswerCount.ToString());
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_Questions");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_QuestionsDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objzx_QuestionsEN.zxQuestionsId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objzx_QuestionsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clszx_QuestionsEN objzx_QuestionsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objzx_QuestionsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_QuestionsEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_QuestionsEN.zxQuestionsId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.zxQuestionsId);
 var strzxQuestionsId = objzx_QuestionsEN.zxQuestionsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxQuestionsId + "'");
 }
 
 if (objzx_QuestionsEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.TextId);
 var strTextId = objzx_QuestionsEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 if (objzx_QuestionsEN.QuestionsContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.QuestionsContent);
 var strQuestionsContent = objzx_QuestionsEN.QuestionsContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionsContent + "'");
 }
 
 if (objzx_QuestionsEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.PdfPageNum);
 arrValueListForInsert.Add(objzx_QuestionsEN.PdfPageNum.ToString());
 }
 
 if (objzx_QuestionsEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.PdfContent);
 var strPdfContent = objzx_QuestionsEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 arrFieldListForInsert.Add(conzx_Questions.IsDelete);
 arrValueListForInsert.Add("'" + (objzx_QuestionsEN.IsDelete  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conzx_Questions.IsPublic);
 arrValueListForInsert.Add("'" + (objzx_QuestionsEN.IsPublic  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conzx_Questions.IsEnd);
 arrValueListForInsert.Add("'" + (objzx_QuestionsEN.IsEnd  ==  false ? "0" : "1") + "'");
 
 if (objzx_QuestionsEN.VoteCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.VoteCount);
 arrValueListForInsert.Add(objzx_QuestionsEN.VoteCount.ToString());
 }
 
 if (objzx_QuestionsEN.AnswerCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.AnswerCount);
 arrValueListForInsert.Add(objzx_QuestionsEN.AnswerCount.ToString());
 }
 
 if (objzx_QuestionsEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.OrderNum);
 arrValueListForInsert.Add(objzx_QuestionsEN.OrderNum.ToString());
 }
 
 if (objzx_QuestionsEN.PdfPageTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.PdfPageTop);
 arrValueListForInsert.Add(objzx_QuestionsEN.PdfPageTop.ToString());
 }
 
 if (objzx_QuestionsEN.PdfPageNumIn !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.PdfPageNumIn);
 var strPdfPageNumIn = objzx_QuestionsEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfPageNumIn + "'");
 }
 
 if (objzx_QuestionsEN.PdfDivTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.PdfDivTop);
 var strPdfDivTop = objzx_QuestionsEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivTop + "'");
 }
 
 if (objzx_QuestionsEN.PdfDivLet !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.PdfDivLet);
 var strPdfDivLet = objzx_QuestionsEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivLet + "'");
 }
 
 if (objzx_QuestionsEN.PdfZoom !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.PdfZoom);
 var strPdfZoom = objzx_QuestionsEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfZoom + "'");
 }
 
 if (objzx_QuestionsEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.UpdUser);
 var strUpdUser = objzx_QuestionsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_QuestionsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.UpdDate);
 var strUpdDate = objzx_QuestionsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_QuestionsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.Memo);
 var strMemo = objzx_QuestionsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_QuestionsEN.ZxqaPaperId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.ZxqaPaperId);
 var strZxqaPaperId = objzx_QuestionsEN.ZxqaPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strZxqaPaperId + "'");
 }
 
 if (objzx_QuestionsEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.UserId);
 var strUserId = objzx_QuestionsEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objzx_QuestionsEN.zxQuestionsTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.zxQuestionsTypeId);
 var strzxQuestionsTypeId = objzx_QuestionsEN.zxQuestionsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxQuestionsTypeId + "'");
 }
 
 if (objzx_QuestionsEN.DiscussCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.DiscussCount);
 arrValueListForInsert.Add(objzx_QuestionsEN.DiscussCount.ToString());
 }
 
 if (objzx_QuestionsEN.GroupDiscussCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.GroupDiscussCount);
 arrValueListForInsert.Add(objzx_QuestionsEN.GroupDiscussCount.ToString());
 }
 
 if (objzx_QuestionsEN.RecommendAnswerCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Questions.RecommendAnswerCount);
 arrValueListForInsert.Add(objzx_QuestionsEN.RecommendAnswerCount.ToString());
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_Questions");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_QuestionsDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewzx_Questionss(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_QuestionsDA.GetSpecSQLObj();
strSQL = "Select * from zx_Questions where zxQuestionsId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "zx_Questions");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strzxQuestionsId = oRow[conzx_Questions.zxQuestionsId].ToString().Trim();
if (IsExist(strzxQuestionsId))
{
 string strResult = "关键字变量值为:" + string.Format("zxQuestionsId = {0}", strzxQuestionsId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clszx_QuestionsEN._CurrTabName ].NewRow();
objRow[conzx_Questions.zxQuestionsId] = oRow[conzx_Questions.zxQuestionsId].ToString().Trim(); //提问Id
objRow[conzx_Questions.TextId] = oRow[conzx_Questions.TextId].ToString().Trim(); //课件Id
objRow[conzx_Questions.QuestionsContent] = oRow[conzx_Questions.QuestionsContent].ToString().Trim(); //提问内容
objRow[conzx_Questions.PdfPageNum] = oRow[conzx_Questions.PdfPageNum].ToString().Trim(); //Pdf页码
objRow[conzx_Questions.PdfContent] = oRow[conzx_Questions.PdfContent].ToString().Trim(); //Pdf内容
objRow[conzx_Questions.IsDelete] = oRow[conzx_Questions.IsDelete].ToString().Trim(); //是否删除
objRow[conzx_Questions.IsPublic] = oRow[conzx_Questions.IsPublic].ToString().Trim(); //是否公开
objRow[conzx_Questions.IsEnd] = oRow[conzx_Questions.IsEnd].ToString().Trim(); //是否结束
objRow[conzx_Questions.VoteCount] = oRow[conzx_Questions.VoteCount].ToString().Trim(); //点赞计数
objRow[conzx_Questions.AnswerCount] = oRow[conzx_Questions.AnswerCount].ToString().Trim(); //回答计数
objRow[conzx_Questions.OrderNum] = oRow[conzx_Questions.OrderNum].ToString().Trim(); //序号
objRow[conzx_Questions.PdfPageTop] = oRow[conzx_Questions.PdfPageTop].ToString().Trim(); //pdf页面顶部位置
objRow[conzx_Questions.PdfPageNumIn] = oRow[conzx_Questions.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objRow[conzx_Questions.PdfDivTop] = oRow[conzx_Questions.PdfDivTop].ToString().Trim(); //PdfDivTop
objRow[conzx_Questions.PdfDivLet] = oRow[conzx_Questions.PdfDivLet].ToString().Trim(); //PdfDivLet
objRow[conzx_Questions.PdfZoom] = oRow[conzx_Questions.PdfZoom].ToString().Trim(); //PdfZoom
objRow[conzx_Questions.UpdUser] = oRow[conzx_Questions.UpdUser].ToString().Trim(); //修改人
objRow[conzx_Questions.UpdDate] = oRow[conzx_Questions.UpdDate].ToString().Trim(); //修改日期
objRow[conzx_Questions.Memo] = oRow[conzx_Questions.Memo].ToString().Trim(); //备注
objRow[conzx_Questions.ZxqaPaperId] = oRow[conzx_Questions.ZxqaPaperId].ToString().Trim(); //论文答疑Id
objRow[conzx_Questions.UserId] = oRow[conzx_Questions.UserId].ToString().Trim(); //用户ID
objRow[conzx_Questions.zxQuestionsTypeId] = oRow[conzx_Questions.zxQuestionsTypeId].ToString().Trim(); //问题类型Id
objRow[conzx_Questions.DiscussCount] = oRow[conzx_Questions.DiscussCount].ToString().Trim(); //DiscussCount
objRow[conzx_Questions.GroupDiscussCount] = oRow[conzx_Questions.GroupDiscussCount].ToString().Trim(); //GroupDiscussCount
objRow[conzx_Questions.RecommendAnswerCount] = oRow[conzx_Questions.RecommendAnswerCount].ToString().Trim(); //RecommendAnswerCount
 objDS.Tables[clszx_QuestionsEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clszx_QuestionsEN._CurrTabName);
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
 /// <param name = "objzx_QuestionsEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clszx_QuestionsEN objzx_QuestionsEN)
{
 if (objzx_QuestionsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_QuestionsEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_QuestionsDA.GetSpecSQLObj();
strSQL = "Select * from zx_Questions where zxQuestionsId = " + "'"+ objzx_QuestionsEN.zxQuestionsId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clszx_QuestionsEN._CurrTabName);
if (objDS.Tables[clszx_QuestionsEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:zxQuestionsId = " + "'"+ objzx_QuestionsEN.zxQuestionsId+"'");
return false;
}
objRow = objDS.Tables[clszx_QuestionsEN._CurrTabName].Rows[0];
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.zxQuestionsId))
 {
objRow[conzx_Questions.zxQuestionsId] = objzx_QuestionsEN.zxQuestionsId; //提问Id
 }
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.TextId))
 {
objRow[conzx_Questions.TextId] = objzx_QuestionsEN.TextId; //课件Id
 }
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.QuestionsContent))
 {
objRow[conzx_Questions.QuestionsContent] = objzx_QuestionsEN.QuestionsContent; //提问内容
 }
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.PdfPageNum))
 {
objRow[conzx_Questions.PdfPageNum] = objzx_QuestionsEN.PdfPageNum; //Pdf页码
 }
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.PdfContent))
 {
objRow[conzx_Questions.PdfContent] = objzx_QuestionsEN.PdfContent; //Pdf内容
 }
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.IsDelete))
 {
objRow[conzx_Questions.IsDelete] = objzx_QuestionsEN.IsDelete; //是否删除
 }
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.IsPublic))
 {
objRow[conzx_Questions.IsPublic] = objzx_QuestionsEN.IsPublic; //是否公开
 }
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.IsEnd))
 {
objRow[conzx_Questions.IsEnd] = objzx_QuestionsEN.IsEnd; //是否结束
 }
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.VoteCount))
 {
objRow[conzx_Questions.VoteCount] = objzx_QuestionsEN.VoteCount; //点赞计数
 }
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.AnswerCount))
 {
objRow[conzx_Questions.AnswerCount] = objzx_QuestionsEN.AnswerCount; //回答计数
 }
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.OrderNum))
 {
objRow[conzx_Questions.OrderNum] = objzx_QuestionsEN.OrderNum; //序号
 }
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.PdfPageTop))
 {
objRow[conzx_Questions.PdfPageTop] = objzx_QuestionsEN.PdfPageTop; //pdf页面顶部位置
 }
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.PdfPageNumIn))
 {
objRow[conzx_Questions.PdfPageNumIn] = objzx_QuestionsEN.PdfPageNumIn; //PdfPageNumIn
 }
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.PdfDivTop))
 {
objRow[conzx_Questions.PdfDivTop] = objzx_QuestionsEN.PdfDivTop; //PdfDivTop
 }
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.PdfDivLet))
 {
objRow[conzx_Questions.PdfDivLet] = objzx_QuestionsEN.PdfDivLet; //PdfDivLet
 }
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.PdfZoom))
 {
objRow[conzx_Questions.PdfZoom] = objzx_QuestionsEN.PdfZoom; //PdfZoom
 }
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.UpdUser))
 {
objRow[conzx_Questions.UpdUser] = objzx_QuestionsEN.UpdUser; //修改人
 }
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.UpdDate))
 {
objRow[conzx_Questions.UpdDate] = objzx_QuestionsEN.UpdDate; //修改日期
 }
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.Memo))
 {
objRow[conzx_Questions.Memo] = objzx_QuestionsEN.Memo; //备注
 }
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.ZxqaPaperId))
 {
objRow[conzx_Questions.ZxqaPaperId] = objzx_QuestionsEN.ZxqaPaperId; //论文答疑Id
 }
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.UserId))
 {
objRow[conzx_Questions.UserId] = objzx_QuestionsEN.UserId; //用户ID
 }
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.zxQuestionsTypeId))
 {
objRow[conzx_Questions.zxQuestionsTypeId] = objzx_QuestionsEN.zxQuestionsTypeId; //问题类型Id
 }
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.DiscussCount))
 {
objRow[conzx_Questions.DiscussCount] = objzx_QuestionsEN.DiscussCount; //DiscussCount
 }
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.GroupDiscussCount))
 {
objRow[conzx_Questions.GroupDiscussCount] = objzx_QuestionsEN.GroupDiscussCount; //GroupDiscussCount
 }
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.RecommendAnswerCount))
 {
objRow[conzx_Questions.RecommendAnswerCount] = objzx_QuestionsEN.RecommendAnswerCount; //RecommendAnswerCount
 }
try
{
objDA.Update(objDS, clszx_QuestionsEN._CurrTabName);
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
 /// <param name = "objzx_QuestionsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clszx_QuestionsEN objzx_QuestionsEN)
{
 if (objzx_QuestionsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_QuestionsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_QuestionsDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update zx_Questions Set ");
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.TextId))
 {
 if (objzx_QuestionsEN.TextId !=  null)
 {
 var strTextId = objzx_QuestionsEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTextId, conzx_Questions.TextId); //课件Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Questions.TextId); //课件Id
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.QuestionsContent))
 {
 if (objzx_QuestionsEN.QuestionsContent !=  null)
 {
 var strQuestionsContent = objzx_QuestionsEN.QuestionsContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionsContent, conzx_Questions.QuestionsContent); //提问内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Questions.QuestionsContent); //提问内容
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.PdfPageNum))
 {
 if (objzx_QuestionsEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_QuestionsEN.PdfPageNum, conzx_Questions.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Questions.PdfPageNum); //Pdf页码
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.PdfContent))
 {
 if (objzx_QuestionsEN.PdfContent !=  null)
 {
 var strPdfContent = objzx_QuestionsEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfContent, conzx_Questions.PdfContent); //Pdf内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Questions.PdfContent); //Pdf内容
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.IsDelete))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objzx_QuestionsEN.IsDelete == true?"1":"0", conzx_Questions.IsDelete); //是否删除
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.IsPublic))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objzx_QuestionsEN.IsPublic == true?"1":"0", conzx_Questions.IsPublic); //是否公开
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.IsEnd))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objzx_QuestionsEN.IsEnd == true?"1":"0", conzx_Questions.IsEnd); //是否结束
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.VoteCount))
 {
 if (objzx_QuestionsEN.VoteCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_QuestionsEN.VoteCount, conzx_Questions.VoteCount); //点赞计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Questions.VoteCount); //点赞计数
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.AnswerCount))
 {
 if (objzx_QuestionsEN.AnswerCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_QuestionsEN.AnswerCount, conzx_Questions.AnswerCount); //回答计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Questions.AnswerCount); //回答计数
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.OrderNum))
 {
 if (objzx_QuestionsEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_QuestionsEN.OrderNum, conzx_Questions.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Questions.OrderNum); //序号
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.PdfPageTop))
 {
 if (objzx_QuestionsEN.PdfPageTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_QuestionsEN.PdfPageTop, conzx_Questions.PdfPageTop); //pdf页面顶部位置
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Questions.PdfPageTop); //pdf页面顶部位置
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.PdfPageNumIn))
 {
 if (objzx_QuestionsEN.PdfPageNumIn !=  null)
 {
 var strPdfPageNumIn = objzx_QuestionsEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfPageNumIn, conzx_Questions.PdfPageNumIn); //PdfPageNumIn
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Questions.PdfPageNumIn); //PdfPageNumIn
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.PdfDivTop))
 {
 if (objzx_QuestionsEN.PdfDivTop !=  null)
 {
 var strPdfDivTop = objzx_QuestionsEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfDivTop, conzx_Questions.PdfDivTop); //PdfDivTop
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Questions.PdfDivTop); //PdfDivTop
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.PdfDivLet))
 {
 if (objzx_QuestionsEN.PdfDivLet !=  null)
 {
 var strPdfDivLet = objzx_QuestionsEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfDivLet, conzx_Questions.PdfDivLet); //PdfDivLet
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Questions.PdfDivLet); //PdfDivLet
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.PdfZoom))
 {
 if (objzx_QuestionsEN.PdfZoom !=  null)
 {
 var strPdfZoom = objzx_QuestionsEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfZoom, conzx_Questions.PdfZoom); //PdfZoom
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Questions.PdfZoom); //PdfZoom
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.UpdUser))
 {
 if (objzx_QuestionsEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_QuestionsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conzx_Questions.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Questions.UpdUser); //修改人
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.UpdDate))
 {
 if (objzx_QuestionsEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_QuestionsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conzx_Questions.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Questions.UpdDate); //修改日期
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.Memo))
 {
 if (objzx_QuestionsEN.Memo !=  null)
 {
 var strMemo = objzx_QuestionsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conzx_Questions.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Questions.Memo); //备注
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.ZxqaPaperId))
 {
 if (objzx_QuestionsEN.ZxqaPaperId !=  null)
 {
 var strZxqaPaperId = objzx_QuestionsEN.ZxqaPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strZxqaPaperId, conzx_Questions.ZxqaPaperId); //论文答疑Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Questions.ZxqaPaperId); //论文答疑Id
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.UserId))
 {
 if (objzx_QuestionsEN.UserId !=  null)
 {
 var strUserId = objzx_QuestionsEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conzx_Questions.UserId); //用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Questions.UserId); //用户ID
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.zxQuestionsTypeId))
 {
 if (objzx_QuestionsEN.zxQuestionsTypeId !=  null)
 {
 var strzxQuestionsTypeId = objzx_QuestionsEN.zxQuestionsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxQuestionsTypeId, conzx_Questions.zxQuestionsTypeId); //问题类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Questions.zxQuestionsTypeId); //问题类型Id
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.DiscussCount))
 {
 if (objzx_QuestionsEN.DiscussCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_QuestionsEN.DiscussCount, conzx_Questions.DiscussCount); //DiscussCount
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Questions.DiscussCount); //DiscussCount
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.GroupDiscussCount))
 {
 if (objzx_QuestionsEN.GroupDiscussCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_QuestionsEN.GroupDiscussCount, conzx_Questions.GroupDiscussCount); //GroupDiscussCount
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Questions.GroupDiscussCount); //GroupDiscussCount
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.RecommendAnswerCount))
 {
 if (objzx_QuestionsEN.RecommendAnswerCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_QuestionsEN.RecommendAnswerCount, conzx_Questions.RecommendAnswerCount); //RecommendAnswerCount
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Questions.RecommendAnswerCount); //RecommendAnswerCount
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where zxQuestionsId = '{0}'", objzx_QuestionsEN.zxQuestionsId); 
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
 /// <param name = "objzx_QuestionsEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clszx_QuestionsEN objzx_QuestionsEN, string strCondition)
{
 if (objzx_QuestionsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_QuestionsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_QuestionsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_Questions Set ");
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.TextId))
 {
 if (objzx_QuestionsEN.TextId !=  null)
 {
 var strTextId = objzx_QuestionsEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TextId = '{0}',", strTextId); //课件Id
 }
 else
 {
 sbSQL.Append(" TextId = null,"); //课件Id
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.QuestionsContent))
 {
 if (objzx_QuestionsEN.QuestionsContent !=  null)
 {
 var strQuestionsContent = objzx_QuestionsEN.QuestionsContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionsContent = '{0}',", strQuestionsContent); //提问内容
 }
 else
 {
 sbSQL.Append(" QuestionsContent = null,"); //提问内容
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.PdfPageNum))
 {
 if (objzx_QuestionsEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_QuestionsEN.PdfPageNum, conzx_Questions.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Questions.PdfPageNum); //Pdf页码
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.PdfContent))
 {
 if (objzx_QuestionsEN.PdfContent !=  null)
 {
 var strPdfContent = objzx_QuestionsEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfContent = '{0}',", strPdfContent); //Pdf内容
 }
 else
 {
 sbSQL.Append(" PdfContent = null,"); //Pdf内容
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.IsDelete))
 {
 sbSQL.AppendFormat(" IsDelete = '{0}',", objzx_QuestionsEN.IsDelete == true?"1":"0"); //是否删除
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.IsPublic))
 {
 sbSQL.AppendFormat(" IsPublic = '{0}',", objzx_QuestionsEN.IsPublic == true?"1":"0"); //是否公开
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.IsEnd))
 {
 sbSQL.AppendFormat(" IsEnd = '{0}',", objzx_QuestionsEN.IsEnd == true?"1":"0"); //是否结束
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.VoteCount))
 {
 if (objzx_QuestionsEN.VoteCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_QuestionsEN.VoteCount, conzx_Questions.VoteCount); //点赞计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Questions.VoteCount); //点赞计数
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.AnswerCount))
 {
 if (objzx_QuestionsEN.AnswerCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_QuestionsEN.AnswerCount, conzx_Questions.AnswerCount); //回答计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Questions.AnswerCount); //回答计数
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.OrderNum))
 {
 if (objzx_QuestionsEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_QuestionsEN.OrderNum, conzx_Questions.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Questions.OrderNum); //序号
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.PdfPageTop))
 {
 if (objzx_QuestionsEN.PdfPageTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_QuestionsEN.PdfPageTop, conzx_Questions.PdfPageTop); //pdf页面顶部位置
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Questions.PdfPageTop); //pdf页面顶部位置
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.PdfPageNumIn))
 {
 if (objzx_QuestionsEN.PdfPageNumIn !=  null)
 {
 var strPdfPageNumIn = objzx_QuestionsEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfPageNumIn = '{0}',", strPdfPageNumIn); //PdfPageNumIn
 }
 else
 {
 sbSQL.Append(" PdfPageNumIn = null,"); //PdfPageNumIn
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.PdfDivTop))
 {
 if (objzx_QuestionsEN.PdfDivTop !=  null)
 {
 var strPdfDivTop = objzx_QuestionsEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfDivTop = '{0}',", strPdfDivTop); //PdfDivTop
 }
 else
 {
 sbSQL.Append(" PdfDivTop = null,"); //PdfDivTop
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.PdfDivLet))
 {
 if (objzx_QuestionsEN.PdfDivLet !=  null)
 {
 var strPdfDivLet = objzx_QuestionsEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfDivLet = '{0}',", strPdfDivLet); //PdfDivLet
 }
 else
 {
 sbSQL.Append(" PdfDivLet = null,"); //PdfDivLet
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.PdfZoom))
 {
 if (objzx_QuestionsEN.PdfZoom !=  null)
 {
 var strPdfZoom = objzx_QuestionsEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfZoom = '{0}',", strPdfZoom); //PdfZoom
 }
 else
 {
 sbSQL.Append(" PdfZoom = null,"); //PdfZoom
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.UpdUser))
 {
 if (objzx_QuestionsEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_QuestionsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.UpdDate))
 {
 if (objzx_QuestionsEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_QuestionsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.Memo))
 {
 if (objzx_QuestionsEN.Memo !=  null)
 {
 var strMemo = objzx_QuestionsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.ZxqaPaperId))
 {
 if (objzx_QuestionsEN.ZxqaPaperId !=  null)
 {
 var strZxqaPaperId = objzx_QuestionsEN.ZxqaPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ZxqaPaperId = '{0}',", strZxqaPaperId); //论文答疑Id
 }
 else
 {
 sbSQL.Append(" ZxqaPaperId = null,"); //论文答疑Id
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.UserId))
 {
 if (objzx_QuestionsEN.UserId !=  null)
 {
 var strUserId = objzx_QuestionsEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户ID
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户ID
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.zxQuestionsTypeId))
 {
 if (objzx_QuestionsEN.zxQuestionsTypeId !=  null)
 {
 var strzxQuestionsTypeId = objzx_QuestionsEN.zxQuestionsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxQuestionsTypeId = '{0}',", strzxQuestionsTypeId); //问题类型Id
 }
 else
 {
 sbSQL.Append(" zxQuestionsTypeId = null,"); //问题类型Id
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.DiscussCount))
 {
 if (objzx_QuestionsEN.DiscussCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_QuestionsEN.DiscussCount, conzx_Questions.DiscussCount); //DiscussCount
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Questions.DiscussCount); //DiscussCount
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.GroupDiscussCount))
 {
 if (objzx_QuestionsEN.GroupDiscussCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_QuestionsEN.GroupDiscussCount, conzx_Questions.GroupDiscussCount); //GroupDiscussCount
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Questions.GroupDiscussCount); //GroupDiscussCount
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.RecommendAnswerCount))
 {
 if (objzx_QuestionsEN.RecommendAnswerCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_QuestionsEN.RecommendAnswerCount, conzx_Questions.RecommendAnswerCount); //RecommendAnswerCount
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Questions.RecommendAnswerCount); //RecommendAnswerCount
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
 /// <param name = "objzx_QuestionsEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clszx_QuestionsEN objzx_QuestionsEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objzx_QuestionsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_QuestionsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_QuestionsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_Questions Set ");
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.TextId))
 {
 if (objzx_QuestionsEN.TextId !=  null)
 {
 var strTextId = objzx_QuestionsEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TextId = '{0}',", strTextId); //课件Id
 }
 else
 {
 sbSQL.Append(" TextId = null,"); //课件Id
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.QuestionsContent))
 {
 if (objzx_QuestionsEN.QuestionsContent !=  null)
 {
 var strQuestionsContent = objzx_QuestionsEN.QuestionsContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionsContent = '{0}',", strQuestionsContent); //提问内容
 }
 else
 {
 sbSQL.Append(" QuestionsContent = null,"); //提问内容
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.PdfPageNum))
 {
 if (objzx_QuestionsEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_QuestionsEN.PdfPageNum, conzx_Questions.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Questions.PdfPageNum); //Pdf页码
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.PdfContent))
 {
 if (objzx_QuestionsEN.PdfContent !=  null)
 {
 var strPdfContent = objzx_QuestionsEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfContent = '{0}',", strPdfContent); //Pdf内容
 }
 else
 {
 sbSQL.Append(" PdfContent = null,"); //Pdf内容
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.IsDelete))
 {
 sbSQL.AppendFormat(" IsDelete = '{0}',", objzx_QuestionsEN.IsDelete == true?"1":"0"); //是否删除
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.IsPublic))
 {
 sbSQL.AppendFormat(" IsPublic = '{0}',", objzx_QuestionsEN.IsPublic == true?"1":"0"); //是否公开
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.IsEnd))
 {
 sbSQL.AppendFormat(" IsEnd = '{0}',", objzx_QuestionsEN.IsEnd == true?"1":"0"); //是否结束
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.VoteCount))
 {
 if (objzx_QuestionsEN.VoteCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_QuestionsEN.VoteCount, conzx_Questions.VoteCount); //点赞计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Questions.VoteCount); //点赞计数
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.AnswerCount))
 {
 if (objzx_QuestionsEN.AnswerCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_QuestionsEN.AnswerCount, conzx_Questions.AnswerCount); //回答计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Questions.AnswerCount); //回答计数
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.OrderNum))
 {
 if (objzx_QuestionsEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_QuestionsEN.OrderNum, conzx_Questions.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Questions.OrderNum); //序号
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.PdfPageTop))
 {
 if (objzx_QuestionsEN.PdfPageTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_QuestionsEN.PdfPageTop, conzx_Questions.PdfPageTop); //pdf页面顶部位置
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Questions.PdfPageTop); //pdf页面顶部位置
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.PdfPageNumIn))
 {
 if (objzx_QuestionsEN.PdfPageNumIn !=  null)
 {
 var strPdfPageNumIn = objzx_QuestionsEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfPageNumIn = '{0}',", strPdfPageNumIn); //PdfPageNumIn
 }
 else
 {
 sbSQL.Append(" PdfPageNumIn = null,"); //PdfPageNumIn
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.PdfDivTop))
 {
 if (objzx_QuestionsEN.PdfDivTop !=  null)
 {
 var strPdfDivTop = objzx_QuestionsEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfDivTop = '{0}',", strPdfDivTop); //PdfDivTop
 }
 else
 {
 sbSQL.Append(" PdfDivTop = null,"); //PdfDivTop
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.PdfDivLet))
 {
 if (objzx_QuestionsEN.PdfDivLet !=  null)
 {
 var strPdfDivLet = objzx_QuestionsEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfDivLet = '{0}',", strPdfDivLet); //PdfDivLet
 }
 else
 {
 sbSQL.Append(" PdfDivLet = null,"); //PdfDivLet
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.PdfZoom))
 {
 if (objzx_QuestionsEN.PdfZoom !=  null)
 {
 var strPdfZoom = objzx_QuestionsEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfZoom = '{0}',", strPdfZoom); //PdfZoom
 }
 else
 {
 sbSQL.Append(" PdfZoom = null,"); //PdfZoom
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.UpdUser))
 {
 if (objzx_QuestionsEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_QuestionsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.UpdDate))
 {
 if (objzx_QuestionsEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_QuestionsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.Memo))
 {
 if (objzx_QuestionsEN.Memo !=  null)
 {
 var strMemo = objzx_QuestionsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.ZxqaPaperId))
 {
 if (objzx_QuestionsEN.ZxqaPaperId !=  null)
 {
 var strZxqaPaperId = objzx_QuestionsEN.ZxqaPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ZxqaPaperId = '{0}',", strZxqaPaperId); //论文答疑Id
 }
 else
 {
 sbSQL.Append(" ZxqaPaperId = null,"); //论文答疑Id
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.UserId))
 {
 if (objzx_QuestionsEN.UserId !=  null)
 {
 var strUserId = objzx_QuestionsEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户ID
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户ID
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.zxQuestionsTypeId))
 {
 if (objzx_QuestionsEN.zxQuestionsTypeId !=  null)
 {
 var strzxQuestionsTypeId = objzx_QuestionsEN.zxQuestionsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxQuestionsTypeId = '{0}',", strzxQuestionsTypeId); //问题类型Id
 }
 else
 {
 sbSQL.Append(" zxQuestionsTypeId = null,"); //问题类型Id
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.DiscussCount))
 {
 if (objzx_QuestionsEN.DiscussCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_QuestionsEN.DiscussCount, conzx_Questions.DiscussCount); //DiscussCount
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Questions.DiscussCount); //DiscussCount
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.GroupDiscussCount))
 {
 if (objzx_QuestionsEN.GroupDiscussCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_QuestionsEN.GroupDiscussCount, conzx_Questions.GroupDiscussCount); //GroupDiscussCount
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Questions.GroupDiscussCount); //GroupDiscussCount
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.RecommendAnswerCount))
 {
 if (objzx_QuestionsEN.RecommendAnswerCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_QuestionsEN.RecommendAnswerCount, conzx_Questions.RecommendAnswerCount); //RecommendAnswerCount
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Questions.RecommendAnswerCount); //RecommendAnswerCount
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
 /// <param name = "objzx_QuestionsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clszx_QuestionsEN objzx_QuestionsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objzx_QuestionsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_QuestionsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_QuestionsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_Questions Set ");
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.TextId))
 {
 if (objzx_QuestionsEN.TextId !=  null)
 {
 var strTextId = objzx_QuestionsEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTextId, conzx_Questions.TextId); //课件Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Questions.TextId); //课件Id
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.QuestionsContent))
 {
 if (objzx_QuestionsEN.QuestionsContent !=  null)
 {
 var strQuestionsContent = objzx_QuestionsEN.QuestionsContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionsContent, conzx_Questions.QuestionsContent); //提问内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Questions.QuestionsContent); //提问内容
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.PdfPageNum))
 {
 if (objzx_QuestionsEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_QuestionsEN.PdfPageNum, conzx_Questions.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Questions.PdfPageNum); //Pdf页码
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.PdfContent))
 {
 if (objzx_QuestionsEN.PdfContent !=  null)
 {
 var strPdfContent = objzx_QuestionsEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfContent, conzx_Questions.PdfContent); //Pdf内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Questions.PdfContent); //Pdf内容
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.IsDelete))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objzx_QuestionsEN.IsDelete == true?"1":"0", conzx_Questions.IsDelete); //是否删除
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.IsPublic))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objzx_QuestionsEN.IsPublic == true?"1":"0", conzx_Questions.IsPublic); //是否公开
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.IsEnd))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objzx_QuestionsEN.IsEnd == true?"1":"0", conzx_Questions.IsEnd); //是否结束
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.VoteCount))
 {
 if (objzx_QuestionsEN.VoteCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_QuestionsEN.VoteCount, conzx_Questions.VoteCount); //点赞计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Questions.VoteCount); //点赞计数
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.AnswerCount))
 {
 if (objzx_QuestionsEN.AnswerCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_QuestionsEN.AnswerCount, conzx_Questions.AnswerCount); //回答计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Questions.AnswerCount); //回答计数
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.OrderNum))
 {
 if (objzx_QuestionsEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_QuestionsEN.OrderNum, conzx_Questions.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Questions.OrderNum); //序号
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.PdfPageTop))
 {
 if (objzx_QuestionsEN.PdfPageTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_QuestionsEN.PdfPageTop, conzx_Questions.PdfPageTop); //pdf页面顶部位置
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Questions.PdfPageTop); //pdf页面顶部位置
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.PdfPageNumIn))
 {
 if (objzx_QuestionsEN.PdfPageNumIn !=  null)
 {
 var strPdfPageNumIn = objzx_QuestionsEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfPageNumIn, conzx_Questions.PdfPageNumIn); //PdfPageNumIn
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Questions.PdfPageNumIn); //PdfPageNumIn
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.PdfDivTop))
 {
 if (objzx_QuestionsEN.PdfDivTop !=  null)
 {
 var strPdfDivTop = objzx_QuestionsEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfDivTop, conzx_Questions.PdfDivTop); //PdfDivTop
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Questions.PdfDivTop); //PdfDivTop
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.PdfDivLet))
 {
 if (objzx_QuestionsEN.PdfDivLet !=  null)
 {
 var strPdfDivLet = objzx_QuestionsEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfDivLet, conzx_Questions.PdfDivLet); //PdfDivLet
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Questions.PdfDivLet); //PdfDivLet
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.PdfZoom))
 {
 if (objzx_QuestionsEN.PdfZoom !=  null)
 {
 var strPdfZoom = objzx_QuestionsEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfZoom, conzx_Questions.PdfZoom); //PdfZoom
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Questions.PdfZoom); //PdfZoom
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.UpdUser))
 {
 if (objzx_QuestionsEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_QuestionsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conzx_Questions.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Questions.UpdUser); //修改人
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.UpdDate))
 {
 if (objzx_QuestionsEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_QuestionsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conzx_Questions.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Questions.UpdDate); //修改日期
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.Memo))
 {
 if (objzx_QuestionsEN.Memo !=  null)
 {
 var strMemo = objzx_QuestionsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conzx_Questions.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Questions.Memo); //备注
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.ZxqaPaperId))
 {
 if (objzx_QuestionsEN.ZxqaPaperId !=  null)
 {
 var strZxqaPaperId = objzx_QuestionsEN.ZxqaPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strZxqaPaperId, conzx_Questions.ZxqaPaperId); //论文答疑Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Questions.ZxqaPaperId); //论文答疑Id
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.UserId))
 {
 if (objzx_QuestionsEN.UserId !=  null)
 {
 var strUserId = objzx_QuestionsEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conzx_Questions.UserId); //用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Questions.UserId); //用户ID
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.zxQuestionsTypeId))
 {
 if (objzx_QuestionsEN.zxQuestionsTypeId !=  null)
 {
 var strzxQuestionsTypeId = objzx_QuestionsEN.zxQuestionsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxQuestionsTypeId, conzx_Questions.zxQuestionsTypeId); //问题类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Questions.zxQuestionsTypeId); //问题类型Id
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.DiscussCount))
 {
 if (objzx_QuestionsEN.DiscussCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_QuestionsEN.DiscussCount, conzx_Questions.DiscussCount); //DiscussCount
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Questions.DiscussCount); //DiscussCount
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.GroupDiscussCount))
 {
 if (objzx_QuestionsEN.GroupDiscussCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_QuestionsEN.GroupDiscussCount, conzx_Questions.GroupDiscussCount); //GroupDiscussCount
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Questions.GroupDiscussCount); //GroupDiscussCount
 }
 }
 
 if (objzx_QuestionsEN.IsUpdated(conzx_Questions.RecommendAnswerCount))
 {
 if (objzx_QuestionsEN.RecommendAnswerCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_QuestionsEN.RecommendAnswerCount, conzx_Questions.RecommendAnswerCount); //RecommendAnswerCount
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Questions.RecommendAnswerCount); //RecommendAnswerCount
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where zxQuestionsId = '{0}'", objzx_QuestionsEN.zxQuestionsId); 
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
 /// <param name = "strzxQuestionsId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strzxQuestionsId) 
{
CheckPrimaryKey(strzxQuestionsId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_QuestionsDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strzxQuestionsId,
};
 objSQL.ExecSP("zx_Questions_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strzxQuestionsId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strzxQuestionsId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strzxQuestionsId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_QuestionsDA.GetSpecSQLObj();
//删除zx_Questions本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_Questions where zxQuestionsId = " + "'"+ strzxQuestionsId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delzx_Questions(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_QuestionsDA.GetSpecSQLObj();
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
//删除zx_Questions本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_Questions where zxQuestionsId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strzxQuestionsId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strzxQuestionsId) 
{
CheckPrimaryKey(strzxQuestionsId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_QuestionsDA.GetSpecSQLObj();
//删除zx_Questions本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_Questions where zxQuestionsId = " + "'"+ strzxQuestionsId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delzx_Questions(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clszx_QuestionsDA: Delzx_Questions)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_QuestionsDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from zx_Questions where " + strCondition ;
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
public bool Delzx_QuestionsWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clszx_QuestionsDA: Delzx_QuestionsWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_QuestionsDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from zx_Questions where " + strCondition ;
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
 /// <param name = "objzx_QuestionsENS">源对象</param>
 /// <param name = "objzx_QuestionsENT">目标对象</param>
public void CopyTo(clszx_QuestionsEN objzx_QuestionsENS, clszx_QuestionsEN objzx_QuestionsENT)
{
objzx_QuestionsENT.zxQuestionsId = objzx_QuestionsENS.zxQuestionsId; //提问Id
objzx_QuestionsENT.TextId = objzx_QuestionsENS.TextId; //课件Id
objzx_QuestionsENT.QuestionsContent = objzx_QuestionsENS.QuestionsContent; //提问内容
objzx_QuestionsENT.PdfPageNum = objzx_QuestionsENS.PdfPageNum; //Pdf页码
objzx_QuestionsENT.PdfContent = objzx_QuestionsENS.PdfContent; //Pdf内容
objzx_QuestionsENT.IsDelete = objzx_QuestionsENS.IsDelete; //是否删除
objzx_QuestionsENT.IsPublic = objzx_QuestionsENS.IsPublic; //是否公开
objzx_QuestionsENT.IsEnd = objzx_QuestionsENS.IsEnd; //是否结束
objzx_QuestionsENT.VoteCount = objzx_QuestionsENS.VoteCount; //点赞计数
objzx_QuestionsENT.AnswerCount = objzx_QuestionsENS.AnswerCount; //回答计数
objzx_QuestionsENT.OrderNum = objzx_QuestionsENS.OrderNum; //序号
objzx_QuestionsENT.PdfPageTop = objzx_QuestionsENS.PdfPageTop; //pdf页面顶部位置
objzx_QuestionsENT.PdfPageNumIn = objzx_QuestionsENS.PdfPageNumIn; //PdfPageNumIn
objzx_QuestionsENT.PdfDivTop = objzx_QuestionsENS.PdfDivTop; //PdfDivTop
objzx_QuestionsENT.PdfDivLet = objzx_QuestionsENS.PdfDivLet; //PdfDivLet
objzx_QuestionsENT.PdfZoom = objzx_QuestionsENS.PdfZoom; //PdfZoom
objzx_QuestionsENT.UpdUser = objzx_QuestionsENS.UpdUser; //修改人
objzx_QuestionsENT.UpdDate = objzx_QuestionsENS.UpdDate; //修改日期
objzx_QuestionsENT.Memo = objzx_QuestionsENS.Memo; //备注
objzx_QuestionsENT.ZxqaPaperId = objzx_QuestionsENS.ZxqaPaperId; //论文答疑Id
objzx_QuestionsENT.UserId = objzx_QuestionsENS.UserId; //用户ID
objzx_QuestionsENT.zxQuestionsTypeId = objzx_QuestionsENS.zxQuestionsTypeId; //问题类型Id
objzx_QuestionsENT.DiscussCount = objzx_QuestionsENS.DiscussCount; //DiscussCount
objzx_QuestionsENT.GroupDiscussCount = objzx_QuestionsENS.GroupDiscussCount; //GroupDiscussCount
objzx_QuestionsENT.RecommendAnswerCount = objzx_QuestionsENS.RecommendAnswerCount; //RecommendAnswerCount
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clszx_QuestionsEN objzx_QuestionsEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objzx_QuestionsEN.ZxqaPaperId, conzx_Questions.ZxqaPaperId);
clsCheckSql.CheckFieldNotNull(objzx_QuestionsEN.zxQuestionsTypeId, conzx_Questions.zxQuestionsTypeId);
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_QuestionsEN.zxQuestionsId, 8, conzx_Questions.zxQuestionsId);
clsCheckSql.CheckFieldLen(objzx_QuestionsEN.TextId, 8, conzx_Questions.TextId);
clsCheckSql.CheckFieldLen(objzx_QuestionsEN.QuestionsContent, 1000, conzx_Questions.QuestionsContent);
clsCheckSql.CheckFieldLen(objzx_QuestionsEN.PdfContent, 2000, conzx_Questions.PdfContent);
clsCheckSql.CheckFieldLen(objzx_QuestionsEN.PdfPageNumIn, 50, conzx_Questions.PdfPageNumIn);
clsCheckSql.CheckFieldLen(objzx_QuestionsEN.PdfDivTop, 50, conzx_Questions.PdfDivTop);
clsCheckSql.CheckFieldLen(objzx_QuestionsEN.PdfDivLet, 50, conzx_Questions.PdfDivLet);
clsCheckSql.CheckFieldLen(objzx_QuestionsEN.PdfZoom, 50, conzx_Questions.PdfZoom);
clsCheckSql.CheckFieldLen(objzx_QuestionsEN.UpdUser, 20, conzx_Questions.UpdUser);
clsCheckSql.CheckFieldLen(objzx_QuestionsEN.UpdDate, 20, conzx_Questions.UpdDate);
clsCheckSql.CheckFieldLen(objzx_QuestionsEN.Memo, 1000, conzx_Questions.Memo);
clsCheckSql.CheckFieldLen(objzx_QuestionsEN.ZxqaPaperId, 8, conzx_Questions.ZxqaPaperId);
clsCheckSql.CheckFieldLen(objzx_QuestionsEN.UserId, 18, conzx_Questions.UserId);
clsCheckSql.CheckFieldLen(objzx_QuestionsEN.zxQuestionsTypeId, 2, conzx_Questions.zxQuestionsTypeId);
//检查字段外键固定长度
 objzx_QuestionsEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clszx_QuestionsEN objzx_QuestionsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_QuestionsEN.TextId, 8, conzx_Questions.TextId);
clsCheckSql.CheckFieldLen(objzx_QuestionsEN.QuestionsContent, 1000, conzx_Questions.QuestionsContent);
clsCheckSql.CheckFieldLen(objzx_QuestionsEN.PdfContent, 2000, conzx_Questions.PdfContent);
clsCheckSql.CheckFieldLen(objzx_QuestionsEN.PdfPageNumIn, 50, conzx_Questions.PdfPageNumIn);
clsCheckSql.CheckFieldLen(objzx_QuestionsEN.PdfDivTop, 50, conzx_Questions.PdfDivTop);
clsCheckSql.CheckFieldLen(objzx_QuestionsEN.PdfDivLet, 50, conzx_Questions.PdfDivLet);
clsCheckSql.CheckFieldLen(objzx_QuestionsEN.PdfZoom, 50, conzx_Questions.PdfZoom);
clsCheckSql.CheckFieldLen(objzx_QuestionsEN.UpdUser, 20, conzx_Questions.UpdUser);
clsCheckSql.CheckFieldLen(objzx_QuestionsEN.UpdDate, 20, conzx_Questions.UpdDate);
clsCheckSql.CheckFieldLen(objzx_QuestionsEN.Memo, 1000, conzx_Questions.Memo);
clsCheckSql.CheckFieldLen(objzx_QuestionsEN.ZxqaPaperId, 8, conzx_Questions.ZxqaPaperId);
clsCheckSql.CheckFieldLen(objzx_QuestionsEN.UserId, 18, conzx_Questions.UserId);
clsCheckSql.CheckFieldLen(objzx_QuestionsEN.zxQuestionsTypeId, 2, conzx_Questions.zxQuestionsTypeId);
//检查外键字段长度
 objzx_QuestionsEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clszx_QuestionsEN objzx_QuestionsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_QuestionsEN.zxQuestionsId, 8, conzx_Questions.zxQuestionsId);
clsCheckSql.CheckFieldLen(objzx_QuestionsEN.TextId, 8, conzx_Questions.TextId);
clsCheckSql.CheckFieldLen(objzx_QuestionsEN.QuestionsContent, 1000, conzx_Questions.QuestionsContent);
clsCheckSql.CheckFieldLen(objzx_QuestionsEN.PdfContent, 2000, conzx_Questions.PdfContent);
clsCheckSql.CheckFieldLen(objzx_QuestionsEN.PdfPageNumIn, 50, conzx_Questions.PdfPageNumIn);
clsCheckSql.CheckFieldLen(objzx_QuestionsEN.PdfDivTop, 50, conzx_Questions.PdfDivTop);
clsCheckSql.CheckFieldLen(objzx_QuestionsEN.PdfDivLet, 50, conzx_Questions.PdfDivLet);
clsCheckSql.CheckFieldLen(objzx_QuestionsEN.PdfZoom, 50, conzx_Questions.PdfZoom);
clsCheckSql.CheckFieldLen(objzx_QuestionsEN.UpdUser, 20, conzx_Questions.UpdUser);
clsCheckSql.CheckFieldLen(objzx_QuestionsEN.UpdDate, 20, conzx_Questions.UpdDate);
clsCheckSql.CheckFieldLen(objzx_QuestionsEN.Memo, 1000, conzx_Questions.Memo);
clsCheckSql.CheckFieldLen(objzx_QuestionsEN.ZxqaPaperId, 8, conzx_Questions.ZxqaPaperId);
clsCheckSql.CheckFieldLen(objzx_QuestionsEN.UserId, 18, conzx_Questions.UserId);
clsCheckSql.CheckFieldLen(objzx_QuestionsEN.zxQuestionsTypeId, 2, conzx_Questions.zxQuestionsTypeId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objzx_QuestionsEN.zxQuestionsId, conzx_Questions.zxQuestionsId);
clsCheckSql.CheckSqlInjection4Field(objzx_QuestionsEN.TextId, conzx_Questions.TextId);
clsCheckSql.CheckSqlInjection4Field(objzx_QuestionsEN.QuestionsContent, conzx_Questions.QuestionsContent);
clsCheckSql.CheckSqlInjection4Field(objzx_QuestionsEN.PdfContent, conzx_Questions.PdfContent);
clsCheckSql.CheckSqlInjection4Field(objzx_QuestionsEN.PdfPageNumIn, conzx_Questions.PdfPageNumIn);
clsCheckSql.CheckSqlInjection4Field(objzx_QuestionsEN.PdfDivTop, conzx_Questions.PdfDivTop);
clsCheckSql.CheckSqlInjection4Field(objzx_QuestionsEN.PdfDivLet, conzx_Questions.PdfDivLet);
clsCheckSql.CheckSqlInjection4Field(objzx_QuestionsEN.PdfZoom, conzx_Questions.PdfZoom);
clsCheckSql.CheckSqlInjection4Field(objzx_QuestionsEN.UpdUser, conzx_Questions.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objzx_QuestionsEN.UpdDate, conzx_Questions.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objzx_QuestionsEN.Memo, conzx_Questions.Memo);
clsCheckSql.CheckSqlInjection4Field(objzx_QuestionsEN.ZxqaPaperId, conzx_Questions.ZxqaPaperId);
clsCheckSql.CheckSqlInjection4Field(objzx_QuestionsEN.UserId, conzx_Questions.UserId);
clsCheckSql.CheckSqlInjection4Field(objzx_QuestionsEN.zxQuestionsTypeId, conzx_Questions.zxQuestionsTypeId);
//检查外键字段长度
 objzx_QuestionsEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--zx_Questions(zx_Questions),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objzx_QuestionsEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clszx_QuestionsEN objzx_QuestionsEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 if (objzx_QuestionsEN.TextId == null)
{
 sbCondition.AppendFormat(" and TextId is null");
}
else
{
 sbCondition.AppendFormat(" and TextId = '{0}'", objzx_QuestionsEN.TextId);
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
 objSQL = clszx_QuestionsDA.GetSpecSQLObj();
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
 objSQL = clszx_QuestionsDA.GetSpecSQLObj();
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
 objSQL = clszx_QuestionsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clszx_QuestionsEN._CurrTabName);
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
 objSQL = clszx_QuestionsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clszx_QuestionsEN._CurrTabName, strCondition);
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
 objSQL = clszx_QuestionsDA.GetSpecSQLObj();
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
 objSQL = clszx_QuestionsDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}