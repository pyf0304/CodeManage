
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvqa_QuestionsDA
 表名:vqa_Questions(01120636)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:06:36
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理(InteractManage)
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
 /// v答疑提问(vqa_Questions)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvqa_QuestionsDA : clsCommBase4DA
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
 return clsvqa_QuestionsEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvqa_QuestionsEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvqa_QuestionsEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvqa_QuestionsEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvqa_QuestionsEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:vqa_Questions中,检查关键字,长度不正确!(clsvqa_QuestionsDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strQuestionsId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vqa_Questions中,关键字不能为空 或 null!(clsvqa_QuestionsDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strQuestionsId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvqa_QuestionsDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvqa_QuestionsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvqa_QuestionsDA.GetSpecSQLObj();
strSQL = "Select * from vqa_Questions where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vqa_Questions(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvqa_QuestionsDA: GetDataTable_vqa_Questions)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvqa_QuestionsDA.GetSpecSQLObj();
strSQL = "Select * from vqa_Questions where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvqa_QuestionsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvqa_QuestionsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvqa_QuestionsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvqa_QuestionsDA.GetSpecSQLObj();
strSQL = "Select * from vqa_Questions where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvqa_QuestionsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvqa_QuestionsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvqa_QuestionsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvqa_QuestionsDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vqa_Questions where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vqa_Questions where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvqa_QuestionsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvqa_QuestionsDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vqa_Questions where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvqa_QuestionsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvqa_QuestionsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vqa_Questions.* from vqa_Questions Left Join {1} on {2} where {3} and vqa_Questions.QuestionsId not in (Select top {5} vqa_Questions.QuestionsId from vqa_Questions Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vqa_Questions where {1} and QuestionsId not in (Select top {2} QuestionsId from vqa_Questions where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vqa_Questions where {1} and QuestionsId not in (Select top {3} QuestionsId from vqa_Questions where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvqa_QuestionsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvqa_QuestionsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vqa_Questions.* from vqa_Questions Left Join {1} on {2} where {3} and vqa_Questions.QuestionsId not in (Select top {5} vqa_Questions.QuestionsId from vqa_Questions Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vqa_Questions where {1} and QuestionsId not in (Select top {2} QuestionsId from vqa_Questions where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vqa_Questions where {1} and QuestionsId not in (Select top {3} QuestionsId from vqa_Questions where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvqa_QuestionsEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvqa_QuestionsDA:GetObjLst)", objException.Message));
}
List<clsvqa_QuestionsEN> arrObjLst = new List<clsvqa_QuestionsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvqa_QuestionsDA.GetSpecSQLObj();
strSQL = "Select * from vqa_Questions where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvqa_QuestionsEN objvqa_QuestionsEN = new clsvqa_QuestionsEN();
try
{
objvqa_QuestionsEN.QuestionsId = objRow[convqa_Questions.QuestionsId].ToString().Trim(); //提问Id
objvqa_QuestionsEN.PaperId = objRow[convqa_Questions.PaperId] == DBNull.Value ? null : objRow[convqa_Questions.PaperId].ToString().Trim(); //论文Id
objvqa_QuestionsEN.IsSubmit = TransNullToBool(objRow[convqa_Questions.IsSubmit].ToString().Trim()); //是否提交
objvqa_QuestionsEN.QaPaperId = objRow[convqa_Questions.QaPaperId].ToString().Trim(); //论文答疑Id
objvqa_QuestionsEN.QuestionsContent = objRow[convqa_Questions.QuestionsContent] == DBNull.Value ? null : objRow[convqa_Questions.QuestionsContent].ToString().Trim(); //提问内容
objvqa_QuestionsEN.PdfContent = objRow[convqa_Questions.PdfContent] == DBNull.Value ? null : objRow[convqa_Questions.PdfContent].ToString().Trim(); //Pdf内容
objvqa_QuestionsEN.PdfPageNum = objRow[convqa_Questions.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Questions.PdfPageNum].ToString().Trim()); //Pdf页码
objvqa_QuestionsEN.IsDelete = TransNullToBool(objRow[convqa_Questions.IsDelete].ToString().Trim()); //是否删除
objvqa_QuestionsEN.IsPublic = TransNullToBool(objRow[convqa_Questions.IsPublic].ToString().Trim()); //是否公开
objvqa_QuestionsEN.IsEnd = TransNullToBool(objRow[convqa_Questions.IsEnd].ToString().Trim()); //是否结束
objvqa_QuestionsEN.VoteCount = objRow[convqa_Questions.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Questions.VoteCount].ToString().Trim()); //点赞计数
objvqa_QuestionsEN.AnswerCount = objRow[convqa_Questions.AnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Questions.AnswerCount].ToString().Trim()); //回答计数
objvqa_QuestionsEN.OrderNum = objRow[convqa_Questions.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Questions.OrderNum].ToString().Trim()); //序号
objvqa_QuestionsEN.UpdUser = objRow[convqa_Questions.UpdUser] == DBNull.Value ? null : objRow[convqa_Questions.UpdUser].ToString().Trim(); //修改人
objvqa_QuestionsEN.UpdDate = objRow[convqa_Questions.UpdDate] == DBNull.Value ? null : objRow[convqa_Questions.UpdDate].ToString().Trim(); //修改日期
objvqa_QuestionsEN.Memo = objRow[convqa_Questions.Memo] == DBNull.Value ? null : objRow[convqa_Questions.Memo].ToString().Trim(); //备注
objvqa_QuestionsEN.UserName = objRow[convqa_Questions.UserName] == DBNull.Value ? null : objRow[convqa_Questions.UserName].ToString().Trim(); //用户名
objvqa_QuestionsEN.IdCurrEduCls = objRow[convqa_Questions.IdCurrEduCls] == DBNull.Value ? null : objRow[convqa_Questions.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvqa_QuestionsEN.PaperTitle = objRow[convqa_Questions.PaperTitle] == DBNull.Value ? null : objRow[convqa_Questions.PaperTitle].ToString().Trim(); //论文标题
objvqa_QuestionsEN.PdfDivLet = objRow[convqa_Questions.PdfDivLet] == DBNull.Value ? null : objRow[convqa_Questions.PdfDivLet].ToString().Trim(); //PdfDivLet
objvqa_QuestionsEN.PdfDivTop = objRow[convqa_Questions.PdfDivTop] == DBNull.Value ? null : objRow[convqa_Questions.PdfDivTop].ToString().Trim(); //PdfDivTop
objvqa_QuestionsEN.PdfPageNumIn = objRow[convqa_Questions.PdfPageNumIn] == DBNull.Value ? null : objRow[convqa_Questions.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvqa_QuestionsEN.PdfPageTop = objRow[convqa_Questions.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Questions.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvqa_QuestionsEN.PdfZoom = objRow[convqa_Questions.PdfZoom] == DBNull.Value ? null : objRow[convqa_Questions.PdfZoom].ToString().Trim(); //PdfZoom
objvqa_QuestionsEN.UserId = objRow[convqa_Questions.UserId] == DBNull.Value ? null : objRow[convqa_Questions.UserId].ToString().Trim(); //用户ID
objvqa_QuestionsEN.QuestionsTypeId = objRow[convqa_Questions.QuestionsTypeId] == DBNull.Value ? null : objRow[convqa_Questions.QuestionsTypeId].ToString().Trim(); //问题类型Id
objvqa_QuestionsEN.QuestionsTypeName = objRow[convqa_Questions.QuestionsTypeName] == DBNull.Value ? null : objRow[convqa_Questions.QuestionsTypeName].ToString().Trim(); //问题类型名称
objvqa_QuestionsEN.DiscussCount = objRow[convqa_Questions.DiscussCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Questions.DiscussCount].ToString().Trim()); //DiscussCount
objvqa_QuestionsEN.GroupDiscussCount = objRow[convqa_Questions.GroupDiscussCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Questions.GroupDiscussCount].ToString().Trim()); //GroupDiscussCount
objvqa_QuestionsEN.RecommendAnswerCount = objRow[convqa_Questions.RecommendAnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Questions.RecommendAnswerCount].ToString().Trim()); //RecommendAnswerCount
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvqa_QuestionsDA: GetObjLst)", objException.Message));
}
objvqa_QuestionsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvqa_QuestionsEN);
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
public List<clsvqa_QuestionsEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvqa_QuestionsDA:GetObjLstByTabName)", objException.Message));
}
List<clsvqa_QuestionsEN> arrObjLst = new List<clsvqa_QuestionsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvqa_QuestionsDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvqa_QuestionsEN objvqa_QuestionsEN = new clsvqa_QuestionsEN();
try
{
objvqa_QuestionsEN.QuestionsId = objRow[convqa_Questions.QuestionsId].ToString().Trim(); //提问Id
objvqa_QuestionsEN.PaperId = objRow[convqa_Questions.PaperId] == DBNull.Value ? null : objRow[convqa_Questions.PaperId].ToString().Trim(); //论文Id
objvqa_QuestionsEN.IsSubmit = TransNullToBool(objRow[convqa_Questions.IsSubmit].ToString().Trim()); //是否提交
objvqa_QuestionsEN.QaPaperId = objRow[convqa_Questions.QaPaperId].ToString().Trim(); //论文答疑Id
objvqa_QuestionsEN.QuestionsContent = objRow[convqa_Questions.QuestionsContent] == DBNull.Value ? null : objRow[convqa_Questions.QuestionsContent].ToString().Trim(); //提问内容
objvqa_QuestionsEN.PdfContent = objRow[convqa_Questions.PdfContent] == DBNull.Value ? null : objRow[convqa_Questions.PdfContent].ToString().Trim(); //Pdf内容
objvqa_QuestionsEN.PdfPageNum = objRow[convqa_Questions.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Questions.PdfPageNum].ToString().Trim()); //Pdf页码
objvqa_QuestionsEN.IsDelete = TransNullToBool(objRow[convqa_Questions.IsDelete].ToString().Trim()); //是否删除
objvqa_QuestionsEN.IsPublic = TransNullToBool(objRow[convqa_Questions.IsPublic].ToString().Trim()); //是否公开
objvqa_QuestionsEN.IsEnd = TransNullToBool(objRow[convqa_Questions.IsEnd].ToString().Trim()); //是否结束
objvqa_QuestionsEN.VoteCount = objRow[convqa_Questions.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Questions.VoteCount].ToString().Trim()); //点赞计数
objvqa_QuestionsEN.AnswerCount = objRow[convqa_Questions.AnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Questions.AnswerCount].ToString().Trim()); //回答计数
objvqa_QuestionsEN.OrderNum = objRow[convqa_Questions.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Questions.OrderNum].ToString().Trim()); //序号
objvqa_QuestionsEN.UpdUser = objRow[convqa_Questions.UpdUser] == DBNull.Value ? null : objRow[convqa_Questions.UpdUser].ToString().Trim(); //修改人
objvqa_QuestionsEN.UpdDate = objRow[convqa_Questions.UpdDate] == DBNull.Value ? null : objRow[convqa_Questions.UpdDate].ToString().Trim(); //修改日期
objvqa_QuestionsEN.Memo = objRow[convqa_Questions.Memo] == DBNull.Value ? null : objRow[convqa_Questions.Memo].ToString().Trim(); //备注
objvqa_QuestionsEN.UserName = objRow[convqa_Questions.UserName] == DBNull.Value ? null : objRow[convqa_Questions.UserName].ToString().Trim(); //用户名
objvqa_QuestionsEN.IdCurrEduCls = objRow[convqa_Questions.IdCurrEduCls] == DBNull.Value ? null : objRow[convqa_Questions.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvqa_QuestionsEN.PaperTitle = objRow[convqa_Questions.PaperTitle] == DBNull.Value ? null : objRow[convqa_Questions.PaperTitle].ToString().Trim(); //论文标题
objvqa_QuestionsEN.PdfDivLet = objRow[convqa_Questions.PdfDivLet] == DBNull.Value ? null : objRow[convqa_Questions.PdfDivLet].ToString().Trim(); //PdfDivLet
objvqa_QuestionsEN.PdfDivTop = objRow[convqa_Questions.PdfDivTop] == DBNull.Value ? null : objRow[convqa_Questions.PdfDivTop].ToString().Trim(); //PdfDivTop
objvqa_QuestionsEN.PdfPageNumIn = objRow[convqa_Questions.PdfPageNumIn] == DBNull.Value ? null : objRow[convqa_Questions.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvqa_QuestionsEN.PdfPageTop = objRow[convqa_Questions.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Questions.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvqa_QuestionsEN.PdfZoom = objRow[convqa_Questions.PdfZoom] == DBNull.Value ? null : objRow[convqa_Questions.PdfZoom].ToString().Trim(); //PdfZoom
objvqa_QuestionsEN.UserId = objRow[convqa_Questions.UserId] == DBNull.Value ? null : objRow[convqa_Questions.UserId].ToString().Trim(); //用户ID
objvqa_QuestionsEN.QuestionsTypeId = objRow[convqa_Questions.QuestionsTypeId] == DBNull.Value ? null : objRow[convqa_Questions.QuestionsTypeId].ToString().Trim(); //问题类型Id
objvqa_QuestionsEN.QuestionsTypeName = objRow[convqa_Questions.QuestionsTypeName] == DBNull.Value ? null : objRow[convqa_Questions.QuestionsTypeName].ToString().Trim(); //问题类型名称
objvqa_QuestionsEN.DiscussCount = objRow[convqa_Questions.DiscussCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Questions.DiscussCount].ToString().Trim()); //DiscussCount
objvqa_QuestionsEN.GroupDiscussCount = objRow[convqa_Questions.GroupDiscussCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Questions.GroupDiscussCount].ToString().Trim()); //GroupDiscussCount
objvqa_QuestionsEN.RecommendAnswerCount = objRow[convqa_Questions.RecommendAnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Questions.RecommendAnswerCount].ToString().Trim()); //RecommendAnswerCount
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvqa_QuestionsDA: GetObjLst)", objException.Message));
}
objvqa_QuestionsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvqa_QuestionsEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvqa_QuestionsEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getvqa_Questions(ref clsvqa_QuestionsEN objvqa_QuestionsEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvqa_QuestionsDA.GetSpecSQLObj();
strSQL = "Select * from vqa_Questions where QuestionsId = " + "'"+ objvqa_QuestionsEN.QuestionsId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvqa_QuestionsEN.QuestionsId = objDT.Rows[0][convqa_Questions.QuestionsId].ToString().Trim(); //提问Id(字段类型:char,字段长度:8,是否可空:False)
 objvqa_QuestionsEN.PaperId = objDT.Rows[0][convqa_Questions.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objvqa_QuestionsEN.IsSubmit = TransNullToBool(objDT.Rows[0][convqa_Questions.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvqa_QuestionsEN.QaPaperId = objDT.Rows[0][convqa_Questions.QaPaperId].ToString().Trim(); //论文答疑Id(字段类型:char,字段长度:8,是否可空:False)
 objvqa_QuestionsEN.QuestionsContent = objDT.Rows[0][convqa_Questions.QuestionsContent].ToString().Trim(); //提问内容(字段类型:varchar,字段长度:1000,是否可空:True)
 objvqa_QuestionsEN.PdfContent = objDT.Rows[0][convqa_Questions.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvqa_QuestionsEN.PdfPageNum = TransNullToInt(objDT.Rows[0][convqa_Questions.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objvqa_QuestionsEN.IsDelete = TransNullToBool(objDT.Rows[0][convqa_Questions.IsDelete].ToString().Trim()); //是否删除(字段类型:bit,字段长度:1,是否可空:True)
 objvqa_QuestionsEN.IsPublic = TransNullToBool(objDT.Rows[0][convqa_Questions.IsPublic].ToString().Trim()); //是否公开(字段类型:bit,字段长度:1,是否可空:True)
 objvqa_QuestionsEN.IsEnd = TransNullToBool(objDT.Rows[0][convqa_Questions.IsEnd].ToString().Trim()); //是否结束(字段类型:bit,字段长度:1,是否可空:True)
 objvqa_QuestionsEN.VoteCount = TransNullToInt(objDT.Rows[0][convqa_Questions.VoteCount].ToString().Trim()); //点赞计数(字段类型:int,字段长度:4,是否可空:True)
 objvqa_QuestionsEN.AnswerCount = TransNullToInt(objDT.Rows[0][convqa_Questions.AnswerCount].ToString().Trim()); //回答计数(字段类型:int,字段长度:4,是否可空:True)
 objvqa_QuestionsEN.OrderNum = TransNullToInt(objDT.Rows[0][convqa_Questions.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvqa_QuestionsEN.UpdUser = objDT.Rows[0][convqa_Questions.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvqa_QuestionsEN.UpdDate = objDT.Rows[0][convqa_Questions.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvqa_QuestionsEN.Memo = objDT.Rows[0][convqa_Questions.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvqa_QuestionsEN.UserName = objDT.Rows[0][convqa_Questions.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvqa_QuestionsEN.IdCurrEduCls = objDT.Rows[0][convqa_Questions.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvqa_QuestionsEN.PaperTitle = objDT.Rows[0][convqa_Questions.PaperTitle].ToString().Trim(); //论文标题(字段类型:varchar,字段长度:500,是否可空:False)
 objvqa_QuestionsEN.PdfDivLet = objDT.Rows[0][convqa_Questions.PdfDivLet].ToString().Trim(); //PdfDivLet(字段类型:varchar,字段长度:50,是否可空:True)
 objvqa_QuestionsEN.PdfDivTop = objDT.Rows[0][convqa_Questions.PdfDivTop].ToString().Trim(); //PdfDivTop(字段类型:varchar,字段长度:50,是否可空:True)
 objvqa_QuestionsEN.PdfPageNumIn = objDT.Rows[0][convqa_Questions.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn(字段类型:varchar,字段长度:50,是否可空:True)
 objvqa_QuestionsEN.PdfPageTop = TransNullToInt(objDT.Rows[0][convqa_Questions.PdfPageTop].ToString().Trim()); //pdf页面顶部位置(字段类型:int,字段长度:4,是否可空:True)
 objvqa_QuestionsEN.PdfZoom = objDT.Rows[0][convqa_Questions.PdfZoom].ToString().Trim(); //PdfZoom(字段类型:varchar,字段长度:50,是否可空:True)
 objvqa_QuestionsEN.UserId = objDT.Rows[0][convqa_Questions.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvqa_QuestionsEN.QuestionsTypeId = objDT.Rows[0][convqa_Questions.QuestionsTypeId].ToString().Trim(); //问题类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvqa_QuestionsEN.QuestionsTypeName = objDT.Rows[0][convqa_Questions.QuestionsTypeName].ToString().Trim(); //问题类型名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvqa_QuestionsEN.DiscussCount = TransNullToInt(objDT.Rows[0][convqa_Questions.DiscussCount].ToString().Trim()); //DiscussCount(字段类型:int,字段长度:4,是否可空:True)
 objvqa_QuestionsEN.GroupDiscussCount = TransNullToInt(objDT.Rows[0][convqa_Questions.GroupDiscussCount].ToString().Trim()); //GroupDiscussCount(字段类型:int,字段长度:4,是否可空:True)
 objvqa_QuestionsEN.RecommendAnswerCount = TransNullToInt(objDT.Rows[0][convqa_Questions.RecommendAnswerCount].ToString().Trim()); //RecommendAnswerCount(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvqa_QuestionsDA: Getvqa_Questions)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strQuestionsId">表关键字</param>
 /// <returns>表对象</returns>
public clsvqa_QuestionsEN GetObjByQuestionsId(string strQuestionsId)
{
CheckPrimaryKey(strQuestionsId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvqa_QuestionsDA.GetSpecSQLObj();
strSQL = "Select * from vqa_Questions where QuestionsId = " + "'"+ strQuestionsId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvqa_QuestionsEN objvqa_QuestionsEN = new clsvqa_QuestionsEN();
try
{
 objvqa_QuestionsEN.QuestionsId = objRow[convqa_Questions.QuestionsId].ToString().Trim(); //提问Id(字段类型:char,字段长度:8,是否可空:False)
 objvqa_QuestionsEN.PaperId = objRow[convqa_Questions.PaperId] == DBNull.Value ? null : objRow[convqa_Questions.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objvqa_QuestionsEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convqa_Questions.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvqa_QuestionsEN.QaPaperId = objRow[convqa_Questions.QaPaperId].ToString().Trim(); //论文答疑Id(字段类型:char,字段长度:8,是否可空:False)
 objvqa_QuestionsEN.QuestionsContent = objRow[convqa_Questions.QuestionsContent] == DBNull.Value ? null : objRow[convqa_Questions.QuestionsContent].ToString().Trim(); //提问内容(字段类型:varchar,字段长度:1000,是否可空:True)
 objvqa_QuestionsEN.PdfContent = objRow[convqa_Questions.PdfContent] == DBNull.Value ? null : objRow[convqa_Questions.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvqa_QuestionsEN.PdfPageNum = objRow[convqa_Questions.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objvqa_QuestionsEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convqa_Questions.IsDelete].ToString().Trim()); //是否删除(字段类型:bit,字段长度:1,是否可空:True)
 objvqa_QuestionsEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convqa_Questions.IsPublic].ToString().Trim()); //是否公开(字段类型:bit,字段长度:1,是否可空:True)
 objvqa_QuestionsEN.IsEnd = clsEntityBase2.TransNullToBool_S(objRow[convqa_Questions.IsEnd].ToString().Trim()); //是否结束(字段类型:bit,字段长度:1,是否可空:True)
 objvqa_QuestionsEN.VoteCount = objRow[convqa_Questions.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.VoteCount].ToString().Trim()); //点赞计数(字段类型:int,字段长度:4,是否可空:True)
 objvqa_QuestionsEN.AnswerCount = objRow[convqa_Questions.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.AnswerCount].ToString().Trim()); //回答计数(字段类型:int,字段长度:4,是否可空:True)
 objvqa_QuestionsEN.OrderNum = objRow[convqa_Questions.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvqa_QuestionsEN.UpdUser = objRow[convqa_Questions.UpdUser] == DBNull.Value ? null : objRow[convqa_Questions.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvqa_QuestionsEN.UpdDate = objRow[convqa_Questions.UpdDate] == DBNull.Value ? null : objRow[convqa_Questions.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvqa_QuestionsEN.Memo = objRow[convqa_Questions.Memo] == DBNull.Value ? null : objRow[convqa_Questions.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvqa_QuestionsEN.UserName = objRow[convqa_Questions.UserName] == DBNull.Value ? null : objRow[convqa_Questions.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvqa_QuestionsEN.IdCurrEduCls = objRow[convqa_Questions.IdCurrEduCls] == DBNull.Value ? null : objRow[convqa_Questions.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvqa_QuestionsEN.PaperTitle = objRow[convqa_Questions.PaperTitle] == DBNull.Value ? null : objRow[convqa_Questions.PaperTitle].ToString().Trim(); //论文标题(字段类型:varchar,字段长度:500,是否可空:False)
 objvqa_QuestionsEN.PdfDivLet = objRow[convqa_Questions.PdfDivLet] == DBNull.Value ? null : objRow[convqa_Questions.PdfDivLet].ToString().Trim(); //PdfDivLet(字段类型:varchar,字段长度:50,是否可空:True)
 objvqa_QuestionsEN.PdfDivTop = objRow[convqa_Questions.PdfDivTop] == DBNull.Value ? null : objRow[convqa_Questions.PdfDivTop].ToString().Trim(); //PdfDivTop(字段类型:varchar,字段长度:50,是否可空:True)
 objvqa_QuestionsEN.PdfPageNumIn = objRow[convqa_Questions.PdfPageNumIn] == DBNull.Value ? null : objRow[convqa_Questions.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn(字段类型:varchar,字段长度:50,是否可空:True)
 objvqa_QuestionsEN.PdfPageTop = objRow[convqa_Questions.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.PdfPageTop].ToString().Trim()); //pdf页面顶部位置(字段类型:int,字段长度:4,是否可空:True)
 objvqa_QuestionsEN.PdfZoom = objRow[convqa_Questions.PdfZoom] == DBNull.Value ? null : objRow[convqa_Questions.PdfZoom].ToString().Trim(); //PdfZoom(字段类型:varchar,字段长度:50,是否可空:True)
 objvqa_QuestionsEN.UserId = objRow[convqa_Questions.UserId] == DBNull.Value ? null : objRow[convqa_Questions.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvqa_QuestionsEN.QuestionsTypeId = objRow[convqa_Questions.QuestionsTypeId] == DBNull.Value ? null : objRow[convqa_Questions.QuestionsTypeId].ToString().Trim(); //问题类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvqa_QuestionsEN.QuestionsTypeName = objRow[convqa_Questions.QuestionsTypeName] == DBNull.Value ? null : objRow[convqa_Questions.QuestionsTypeName].ToString().Trim(); //问题类型名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvqa_QuestionsEN.DiscussCount = objRow[convqa_Questions.DiscussCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.DiscussCount].ToString().Trim()); //DiscussCount(字段类型:int,字段长度:4,是否可空:True)
 objvqa_QuestionsEN.GroupDiscussCount = objRow[convqa_Questions.GroupDiscussCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.GroupDiscussCount].ToString().Trim()); //GroupDiscussCount(字段类型:int,字段长度:4,是否可空:True)
 objvqa_QuestionsEN.RecommendAnswerCount = objRow[convqa_Questions.RecommendAnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.RecommendAnswerCount].ToString().Trim()); //RecommendAnswerCount(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvqa_QuestionsDA: GetObjByQuestionsId)", objException.Message));
}
return objvqa_QuestionsEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvqa_QuestionsEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvqa_QuestionsDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvqa_QuestionsDA.GetSpecSQLObj();
strSQL = "Select * from vqa_Questions where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvqa_QuestionsEN objvqa_QuestionsEN = new clsvqa_QuestionsEN()
{
QuestionsId = objRow[convqa_Questions.QuestionsId].ToString().Trim(), //提问Id
PaperId = objRow[convqa_Questions.PaperId] == DBNull.Value ? null : objRow[convqa_Questions.PaperId].ToString().Trim(), //论文Id
IsSubmit = TransNullToBool(objRow[convqa_Questions.IsSubmit].ToString().Trim()), //是否提交
QaPaperId = objRow[convqa_Questions.QaPaperId].ToString().Trim(), //论文答疑Id
QuestionsContent = objRow[convqa_Questions.QuestionsContent] == DBNull.Value ? null : objRow[convqa_Questions.QuestionsContent].ToString().Trim(), //提问内容
PdfContent = objRow[convqa_Questions.PdfContent] == DBNull.Value ? null : objRow[convqa_Questions.PdfContent].ToString().Trim(), //Pdf内容
PdfPageNum = objRow[convqa_Questions.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Questions.PdfPageNum].ToString().Trim()), //Pdf页码
IsDelete = TransNullToBool(objRow[convqa_Questions.IsDelete].ToString().Trim()), //是否删除
IsPublic = TransNullToBool(objRow[convqa_Questions.IsPublic].ToString().Trim()), //是否公开
IsEnd = TransNullToBool(objRow[convqa_Questions.IsEnd].ToString().Trim()), //是否结束
VoteCount = objRow[convqa_Questions.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Questions.VoteCount].ToString().Trim()), //点赞计数
AnswerCount = objRow[convqa_Questions.AnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Questions.AnswerCount].ToString().Trim()), //回答计数
OrderNum = objRow[convqa_Questions.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Questions.OrderNum].ToString().Trim()), //序号
UpdUser = objRow[convqa_Questions.UpdUser] == DBNull.Value ? null : objRow[convqa_Questions.UpdUser].ToString().Trim(), //修改人
UpdDate = objRow[convqa_Questions.UpdDate] == DBNull.Value ? null : objRow[convqa_Questions.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[convqa_Questions.Memo] == DBNull.Value ? null : objRow[convqa_Questions.Memo].ToString().Trim(), //备注
UserName = objRow[convqa_Questions.UserName] == DBNull.Value ? null : objRow[convqa_Questions.UserName].ToString().Trim(), //用户名
IdCurrEduCls = objRow[convqa_Questions.IdCurrEduCls] == DBNull.Value ? null : objRow[convqa_Questions.IdCurrEduCls].ToString().Trim(), //教学班流水号
PaperTitle = objRow[convqa_Questions.PaperTitle] == DBNull.Value ? null : objRow[convqa_Questions.PaperTitle].ToString().Trim(), //论文标题
PdfDivLet = objRow[convqa_Questions.PdfDivLet] == DBNull.Value ? null : objRow[convqa_Questions.PdfDivLet].ToString().Trim(), //PdfDivLet
PdfDivTop = objRow[convqa_Questions.PdfDivTop] == DBNull.Value ? null : objRow[convqa_Questions.PdfDivTop].ToString().Trim(), //PdfDivTop
PdfPageNumIn = objRow[convqa_Questions.PdfPageNumIn] == DBNull.Value ? null : objRow[convqa_Questions.PdfPageNumIn].ToString().Trim(), //PdfPageNumIn
PdfPageTop = objRow[convqa_Questions.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Questions.PdfPageTop].ToString().Trim()), //pdf页面顶部位置
PdfZoom = objRow[convqa_Questions.PdfZoom] == DBNull.Value ? null : objRow[convqa_Questions.PdfZoom].ToString().Trim(), //PdfZoom
UserId = objRow[convqa_Questions.UserId] == DBNull.Value ? null : objRow[convqa_Questions.UserId].ToString().Trim(), //用户ID
QuestionsTypeId = objRow[convqa_Questions.QuestionsTypeId] == DBNull.Value ? null : objRow[convqa_Questions.QuestionsTypeId].ToString().Trim(), //问题类型Id
QuestionsTypeName = objRow[convqa_Questions.QuestionsTypeName] == DBNull.Value ? null : objRow[convqa_Questions.QuestionsTypeName].ToString().Trim(), //问题类型名称
DiscussCount = objRow[convqa_Questions.DiscussCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Questions.DiscussCount].ToString().Trim()), //DiscussCount
GroupDiscussCount = objRow[convqa_Questions.GroupDiscussCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Questions.GroupDiscussCount].ToString().Trim()), //GroupDiscussCount
RecommendAnswerCount = objRow[convqa_Questions.RecommendAnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Questions.RecommendAnswerCount].ToString().Trim()) //RecommendAnswerCount
};
objvqa_QuestionsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvqa_QuestionsEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvqa_QuestionsDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvqa_QuestionsEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvqa_QuestionsEN objvqa_QuestionsEN = new clsvqa_QuestionsEN();
try
{
objvqa_QuestionsEN.QuestionsId = objRow[convqa_Questions.QuestionsId].ToString().Trim(); //提问Id
objvqa_QuestionsEN.PaperId = objRow[convqa_Questions.PaperId] == DBNull.Value ? null : objRow[convqa_Questions.PaperId].ToString().Trim(); //论文Id
objvqa_QuestionsEN.IsSubmit = TransNullToBool(objRow[convqa_Questions.IsSubmit].ToString().Trim()); //是否提交
objvqa_QuestionsEN.QaPaperId = objRow[convqa_Questions.QaPaperId].ToString().Trim(); //论文答疑Id
objvqa_QuestionsEN.QuestionsContent = objRow[convqa_Questions.QuestionsContent] == DBNull.Value ? null : objRow[convqa_Questions.QuestionsContent].ToString().Trim(); //提问内容
objvqa_QuestionsEN.PdfContent = objRow[convqa_Questions.PdfContent] == DBNull.Value ? null : objRow[convqa_Questions.PdfContent].ToString().Trim(); //Pdf内容
objvqa_QuestionsEN.PdfPageNum = objRow[convqa_Questions.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Questions.PdfPageNum].ToString().Trim()); //Pdf页码
objvqa_QuestionsEN.IsDelete = TransNullToBool(objRow[convqa_Questions.IsDelete].ToString().Trim()); //是否删除
objvqa_QuestionsEN.IsPublic = TransNullToBool(objRow[convqa_Questions.IsPublic].ToString().Trim()); //是否公开
objvqa_QuestionsEN.IsEnd = TransNullToBool(objRow[convqa_Questions.IsEnd].ToString().Trim()); //是否结束
objvqa_QuestionsEN.VoteCount = objRow[convqa_Questions.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Questions.VoteCount].ToString().Trim()); //点赞计数
objvqa_QuestionsEN.AnswerCount = objRow[convqa_Questions.AnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Questions.AnswerCount].ToString().Trim()); //回答计数
objvqa_QuestionsEN.OrderNum = objRow[convqa_Questions.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Questions.OrderNum].ToString().Trim()); //序号
objvqa_QuestionsEN.UpdUser = objRow[convqa_Questions.UpdUser] == DBNull.Value ? null : objRow[convqa_Questions.UpdUser].ToString().Trim(); //修改人
objvqa_QuestionsEN.UpdDate = objRow[convqa_Questions.UpdDate] == DBNull.Value ? null : objRow[convqa_Questions.UpdDate].ToString().Trim(); //修改日期
objvqa_QuestionsEN.Memo = objRow[convqa_Questions.Memo] == DBNull.Value ? null : objRow[convqa_Questions.Memo].ToString().Trim(); //备注
objvqa_QuestionsEN.UserName = objRow[convqa_Questions.UserName] == DBNull.Value ? null : objRow[convqa_Questions.UserName].ToString().Trim(); //用户名
objvqa_QuestionsEN.IdCurrEduCls = objRow[convqa_Questions.IdCurrEduCls] == DBNull.Value ? null : objRow[convqa_Questions.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvqa_QuestionsEN.PaperTitle = objRow[convqa_Questions.PaperTitle] == DBNull.Value ? null : objRow[convqa_Questions.PaperTitle].ToString().Trim(); //论文标题
objvqa_QuestionsEN.PdfDivLet = objRow[convqa_Questions.PdfDivLet] == DBNull.Value ? null : objRow[convqa_Questions.PdfDivLet].ToString().Trim(); //PdfDivLet
objvqa_QuestionsEN.PdfDivTop = objRow[convqa_Questions.PdfDivTop] == DBNull.Value ? null : objRow[convqa_Questions.PdfDivTop].ToString().Trim(); //PdfDivTop
objvqa_QuestionsEN.PdfPageNumIn = objRow[convqa_Questions.PdfPageNumIn] == DBNull.Value ? null : objRow[convqa_Questions.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvqa_QuestionsEN.PdfPageTop = objRow[convqa_Questions.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Questions.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvqa_QuestionsEN.PdfZoom = objRow[convqa_Questions.PdfZoom] == DBNull.Value ? null : objRow[convqa_Questions.PdfZoom].ToString().Trim(); //PdfZoom
objvqa_QuestionsEN.UserId = objRow[convqa_Questions.UserId] == DBNull.Value ? null : objRow[convqa_Questions.UserId].ToString().Trim(); //用户ID
objvqa_QuestionsEN.QuestionsTypeId = objRow[convqa_Questions.QuestionsTypeId] == DBNull.Value ? null : objRow[convqa_Questions.QuestionsTypeId].ToString().Trim(); //问题类型Id
objvqa_QuestionsEN.QuestionsTypeName = objRow[convqa_Questions.QuestionsTypeName] == DBNull.Value ? null : objRow[convqa_Questions.QuestionsTypeName].ToString().Trim(); //问题类型名称
objvqa_QuestionsEN.DiscussCount = objRow[convqa_Questions.DiscussCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Questions.DiscussCount].ToString().Trim()); //DiscussCount
objvqa_QuestionsEN.GroupDiscussCount = objRow[convqa_Questions.GroupDiscussCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Questions.GroupDiscussCount].ToString().Trim()); //GroupDiscussCount
objvqa_QuestionsEN.RecommendAnswerCount = objRow[convqa_Questions.RecommendAnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Questions.RecommendAnswerCount].ToString().Trim()); //RecommendAnswerCount
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvqa_QuestionsDA: GetObjByDataRowvqa_Questions)", objException.Message));
}
objvqa_QuestionsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvqa_QuestionsEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvqa_QuestionsEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvqa_QuestionsEN objvqa_QuestionsEN = new clsvqa_QuestionsEN();
try
{
objvqa_QuestionsEN.QuestionsId = objRow[convqa_Questions.QuestionsId].ToString().Trim(); //提问Id
objvqa_QuestionsEN.PaperId = objRow[convqa_Questions.PaperId] == DBNull.Value ? null : objRow[convqa_Questions.PaperId].ToString().Trim(); //论文Id
objvqa_QuestionsEN.IsSubmit = TransNullToBool(objRow[convqa_Questions.IsSubmit].ToString().Trim()); //是否提交
objvqa_QuestionsEN.QaPaperId = objRow[convqa_Questions.QaPaperId].ToString().Trim(); //论文答疑Id
objvqa_QuestionsEN.QuestionsContent = objRow[convqa_Questions.QuestionsContent] == DBNull.Value ? null : objRow[convqa_Questions.QuestionsContent].ToString().Trim(); //提问内容
objvqa_QuestionsEN.PdfContent = objRow[convqa_Questions.PdfContent] == DBNull.Value ? null : objRow[convqa_Questions.PdfContent].ToString().Trim(); //Pdf内容
objvqa_QuestionsEN.PdfPageNum = objRow[convqa_Questions.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Questions.PdfPageNum].ToString().Trim()); //Pdf页码
objvqa_QuestionsEN.IsDelete = TransNullToBool(objRow[convqa_Questions.IsDelete].ToString().Trim()); //是否删除
objvqa_QuestionsEN.IsPublic = TransNullToBool(objRow[convqa_Questions.IsPublic].ToString().Trim()); //是否公开
objvqa_QuestionsEN.IsEnd = TransNullToBool(objRow[convqa_Questions.IsEnd].ToString().Trim()); //是否结束
objvqa_QuestionsEN.VoteCount = objRow[convqa_Questions.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Questions.VoteCount].ToString().Trim()); //点赞计数
objvqa_QuestionsEN.AnswerCount = objRow[convqa_Questions.AnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Questions.AnswerCount].ToString().Trim()); //回答计数
objvqa_QuestionsEN.OrderNum = objRow[convqa_Questions.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Questions.OrderNum].ToString().Trim()); //序号
objvqa_QuestionsEN.UpdUser = objRow[convqa_Questions.UpdUser] == DBNull.Value ? null : objRow[convqa_Questions.UpdUser].ToString().Trim(); //修改人
objvqa_QuestionsEN.UpdDate = objRow[convqa_Questions.UpdDate] == DBNull.Value ? null : objRow[convqa_Questions.UpdDate].ToString().Trim(); //修改日期
objvqa_QuestionsEN.Memo = objRow[convqa_Questions.Memo] == DBNull.Value ? null : objRow[convqa_Questions.Memo].ToString().Trim(); //备注
objvqa_QuestionsEN.UserName = objRow[convqa_Questions.UserName] == DBNull.Value ? null : objRow[convqa_Questions.UserName].ToString().Trim(); //用户名
objvqa_QuestionsEN.IdCurrEduCls = objRow[convqa_Questions.IdCurrEduCls] == DBNull.Value ? null : objRow[convqa_Questions.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvqa_QuestionsEN.PaperTitle = objRow[convqa_Questions.PaperTitle] == DBNull.Value ? null : objRow[convqa_Questions.PaperTitle].ToString().Trim(); //论文标题
objvqa_QuestionsEN.PdfDivLet = objRow[convqa_Questions.PdfDivLet] == DBNull.Value ? null : objRow[convqa_Questions.PdfDivLet].ToString().Trim(); //PdfDivLet
objvqa_QuestionsEN.PdfDivTop = objRow[convqa_Questions.PdfDivTop] == DBNull.Value ? null : objRow[convqa_Questions.PdfDivTop].ToString().Trim(); //PdfDivTop
objvqa_QuestionsEN.PdfPageNumIn = objRow[convqa_Questions.PdfPageNumIn] == DBNull.Value ? null : objRow[convqa_Questions.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvqa_QuestionsEN.PdfPageTop = objRow[convqa_Questions.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Questions.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvqa_QuestionsEN.PdfZoom = objRow[convqa_Questions.PdfZoom] == DBNull.Value ? null : objRow[convqa_Questions.PdfZoom].ToString().Trim(); //PdfZoom
objvqa_QuestionsEN.UserId = objRow[convqa_Questions.UserId] == DBNull.Value ? null : objRow[convqa_Questions.UserId].ToString().Trim(); //用户ID
objvqa_QuestionsEN.QuestionsTypeId = objRow[convqa_Questions.QuestionsTypeId] == DBNull.Value ? null : objRow[convqa_Questions.QuestionsTypeId].ToString().Trim(); //问题类型Id
objvqa_QuestionsEN.QuestionsTypeName = objRow[convqa_Questions.QuestionsTypeName] == DBNull.Value ? null : objRow[convqa_Questions.QuestionsTypeName].ToString().Trim(); //问题类型名称
objvqa_QuestionsEN.DiscussCount = objRow[convqa_Questions.DiscussCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Questions.DiscussCount].ToString().Trim()); //DiscussCount
objvqa_QuestionsEN.GroupDiscussCount = objRow[convqa_Questions.GroupDiscussCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Questions.GroupDiscussCount].ToString().Trim()); //GroupDiscussCount
objvqa_QuestionsEN.RecommendAnswerCount = objRow[convqa_Questions.RecommendAnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Questions.RecommendAnswerCount].ToString().Trim()); //RecommendAnswerCount
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvqa_QuestionsDA: GetObjByDataRow)", objException.Message));
}
objvqa_QuestionsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvqa_QuestionsEN;
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
objSQL = clsvqa_QuestionsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvqa_QuestionsEN._CurrTabName, convqa_Questions.QuestionsId, 8, "");
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
objSQL = clsvqa_QuestionsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvqa_QuestionsEN._CurrTabName, convqa_Questions.QuestionsId, 8, strPrefix);
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
 objSQL = clsvqa_QuestionsDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select QuestionsId from vqa_Questions where " + strCondition;
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
 objSQL = clsvqa_QuestionsDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select QuestionsId from vqa_Questions where " + strCondition;
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
 objSQL = clsvqa_QuestionsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vqa_Questions", "QuestionsId = " + "'"+ strQuestionsId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvqa_QuestionsDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvqa_QuestionsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vqa_Questions", strCondition))
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
objSQL = clsvqa_QuestionsDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vqa_Questions");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvqa_QuestionsENS">源对象</param>
 /// <param name = "objvqa_QuestionsENT">目标对象</param>
public void CopyTo(clsvqa_QuestionsEN objvqa_QuestionsENS, clsvqa_QuestionsEN objvqa_QuestionsENT)
{
objvqa_QuestionsENT.QuestionsId = objvqa_QuestionsENS.QuestionsId; //提问Id
objvqa_QuestionsENT.PaperId = objvqa_QuestionsENS.PaperId; //论文Id
objvqa_QuestionsENT.IsSubmit = objvqa_QuestionsENS.IsSubmit; //是否提交
objvqa_QuestionsENT.QaPaperId = objvqa_QuestionsENS.QaPaperId; //论文答疑Id
objvqa_QuestionsENT.QuestionsContent = objvqa_QuestionsENS.QuestionsContent; //提问内容
objvqa_QuestionsENT.PdfContent = objvqa_QuestionsENS.PdfContent; //Pdf内容
objvqa_QuestionsENT.PdfPageNum = objvqa_QuestionsENS.PdfPageNum; //Pdf页码
objvqa_QuestionsENT.IsDelete = objvqa_QuestionsENS.IsDelete; //是否删除
objvqa_QuestionsENT.IsPublic = objvqa_QuestionsENS.IsPublic; //是否公开
objvqa_QuestionsENT.IsEnd = objvqa_QuestionsENS.IsEnd; //是否结束
objvqa_QuestionsENT.VoteCount = objvqa_QuestionsENS.VoteCount; //点赞计数
objvqa_QuestionsENT.AnswerCount = objvqa_QuestionsENS.AnswerCount; //回答计数
objvqa_QuestionsENT.OrderNum = objvqa_QuestionsENS.OrderNum; //序号
objvqa_QuestionsENT.UpdUser = objvqa_QuestionsENS.UpdUser; //修改人
objvqa_QuestionsENT.UpdDate = objvqa_QuestionsENS.UpdDate; //修改日期
objvqa_QuestionsENT.Memo = objvqa_QuestionsENS.Memo; //备注
objvqa_QuestionsENT.UserName = objvqa_QuestionsENS.UserName; //用户名
objvqa_QuestionsENT.IdCurrEduCls = objvqa_QuestionsENS.IdCurrEduCls; //教学班流水号
objvqa_QuestionsENT.PaperTitle = objvqa_QuestionsENS.PaperTitle; //论文标题
objvqa_QuestionsENT.PdfDivLet = objvqa_QuestionsENS.PdfDivLet; //PdfDivLet
objvqa_QuestionsENT.PdfDivTop = objvqa_QuestionsENS.PdfDivTop; //PdfDivTop
objvqa_QuestionsENT.PdfPageNumIn = objvqa_QuestionsENS.PdfPageNumIn; //PdfPageNumIn
objvqa_QuestionsENT.PdfPageTop = objvqa_QuestionsENS.PdfPageTop; //pdf页面顶部位置
objvqa_QuestionsENT.PdfZoom = objvqa_QuestionsENS.PdfZoom; //PdfZoom
objvqa_QuestionsENT.UserId = objvqa_QuestionsENS.UserId; //用户ID
objvqa_QuestionsENT.QuestionsTypeId = objvqa_QuestionsENS.QuestionsTypeId; //问题类型Id
objvqa_QuestionsENT.QuestionsTypeName = objvqa_QuestionsENS.QuestionsTypeName; //问题类型名称
objvqa_QuestionsENT.DiscussCount = objvqa_QuestionsENS.DiscussCount; //DiscussCount
objvqa_QuestionsENT.GroupDiscussCount = objvqa_QuestionsENS.GroupDiscussCount; //GroupDiscussCount
objvqa_QuestionsENT.RecommendAnswerCount = objvqa_QuestionsENS.RecommendAnswerCount; //RecommendAnswerCount
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvqa_QuestionsEN objvqa_QuestionsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvqa_QuestionsEN.QuestionsId, 8, convqa_Questions.QuestionsId);
clsCheckSql.CheckFieldLen(objvqa_QuestionsEN.PaperId, 8, convqa_Questions.PaperId);
clsCheckSql.CheckFieldLen(objvqa_QuestionsEN.QaPaperId, 8, convqa_Questions.QaPaperId);
clsCheckSql.CheckFieldLen(objvqa_QuestionsEN.QuestionsContent, 1000, convqa_Questions.QuestionsContent);
clsCheckSql.CheckFieldLen(objvqa_QuestionsEN.PdfContent, 2000, convqa_Questions.PdfContent);
clsCheckSql.CheckFieldLen(objvqa_QuestionsEN.UpdUser, 20, convqa_Questions.UpdUser);
clsCheckSql.CheckFieldLen(objvqa_QuestionsEN.UpdDate, 20, convqa_Questions.UpdDate);
clsCheckSql.CheckFieldLen(objvqa_QuestionsEN.Memo, 1000, convqa_Questions.Memo);
clsCheckSql.CheckFieldLen(objvqa_QuestionsEN.UserName, 30, convqa_Questions.UserName);
clsCheckSql.CheckFieldLen(objvqa_QuestionsEN.IdCurrEduCls, 8, convqa_Questions.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objvqa_QuestionsEN.PaperTitle, 500, convqa_Questions.PaperTitle);
clsCheckSql.CheckFieldLen(objvqa_QuestionsEN.PdfDivLet, 50, convqa_Questions.PdfDivLet);
clsCheckSql.CheckFieldLen(objvqa_QuestionsEN.PdfDivTop, 50, convqa_Questions.PdfDivTop);
clsCheckSql.CheckFieldLen(objvqa_QuestionsEN.PdfPageNumIn, 50, convqa_Questions.PdfPageNumIn);
clsCheckSql.CheckFieldLen(objvqa_QuestionsEN.PdfZoom, 50, convqa_Questions.PdfZoom);
clsCheckSql.CheckFieldLen(objvqa_QuestionsEN.UserId, 18, convqa_Questions.UserId);
clsCheckSql.CheckFieldLen(objvqa_QuestionsEN.QuestionsTypeId, 2, convqa_Questions.QuestionsTypeId);
clsCheckSql.CheckFieldLen(objvqa_QuestionsEN.QuestionsTypeName, 50, convqa_Questions.QuestionsTypeName);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvqa_QuestionsEN.QuestionsId, convqa_Questions.QuestionsId);
clsCheckSql.CheckSqlInjection4Field(objvqa_QuestionsEN.PaperId, convqa_Questions.PaperId);
clsCheckSql.CheckSqlInjection4Field(objvqa_QuestionsEN.QaPaperId, convqa_Questions.QaPaperId);
clsCheckSql.CheckSqlInjection4Field(objvqa_QuestionsEN.QuestionsContent, convqa_Questions.QuestionsContent);
clsCheckSql.CheckSqlInjection4Field(objvqa_QuestionsEN.PdfContent, convqa_Questions.PdfContent);
clsCheckSql.CheckSqlInjection4Field(objvqa_QuestionsEN.UpdUser, convqa_Questions.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvqa_QuestionsEN.UpdDate, convqa_Questions.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvqa_QuestionsEN.Memo, convqa_Questions.Memo);
clsCheckSql.CheckSqlInjection4Field(objvqa_QuestionsEN.UserName, convqa_Questions.UserName);
clsCheckSql.CheckSqlInjection4Field(objvqa_QuestionsEN.IdCurrEduCls, convqa_Questions.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objvqa_QuestionsEN.PaperTitle, convqa_Questions.PaperTitle);
clsCheckSql.CheckSqlInjection4Field(objvqa_QuestionsEN.PdfDivLet, convqa_Questions.PdfDivLet);
clsCheckSql.CheckSqlInjection4Field(objvqa_QuestionsEN.PdfDivTop, convqa_Questions.PdfDivTop);
clsCheckSql.CheckSqlInjection4Field(objvqa_QuestionsEN.PdfPageNumIn, convqa_Questions.PdfPageNumIn);
clsCheckSql.CheckSqlInjection4Field(objvqa_QuestionsEN.PdfZoom, convqa_Questions.PdfZoom);
clsCheckSql.CheckSqlInjection4Field(objvqa_QuestionsEN.UserId, convqa_Questions.UserId);
clsCheckSql.CheckSqlInjection4Field(objvqa_QuestionsEN.QuestionsTypeId, convqa_Questions.QuestionsTypeId);
clsCheckSql.CheckSqlInjection4Field(objvqa_QuestionsEN.QuestionsTypeName, convqa_Questions.QuestionsTypeName);
//检查外键字段长度
 objvqa_QuestionsEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--vqa_Questions(v答疑提问),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objvqa_QuestionsEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsvqa_QuestionsEN objvqa_QuestionsEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and QuestionsId = '{0}'", objvqa_QuestionsEN.QuestionsId);
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
 objSQL = clsvqa_QuestionsDA.GetSpecSQLObj();
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
 objSQL = clsvqa_QuestionsDA.GetSpecSQLObj();
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
 objSQL = clsvqa_QuestionsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvqa_QuestionsEN._CurrTabName);
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
 objSQL = clsvqa_QuestionsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvqa_QuestionsEN._CurrTabName, strCondition);
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
 objSQL = clsvqa_QuestionsDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}