
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvqa_AnswerDA
 表名:vqa_Answer(01120635)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:03:23
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
 /// v答疑回答(vqa_Answer)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvqa_AnswerDA : clsCommBase4DA
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
 return clsvqa_AnswerEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvqa_AnswerEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvqa_AnswerEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvqa_AnswerEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvqa_AnswerEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:vqa_Answer中,检查关键字,长度不正确!(clsvqa_AnswerDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strAnswerId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vqa_Answer中,关键字不能为空 或 null!(clsvqa_AnswerDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strAnswerId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvqa_AnswerDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvqa_AnswerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvqa_AnswerDA.GetSpecSQLObj();
strSQL = "Select * from vqa_Answer where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vqa_Answer(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvqa_AnswerDA: GetDataTable_vqa_Answer)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvqa_AnswerDA.GetSpecSQLObj();
strSQL = "Select * from vqa_Answer where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvqa_AnswerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvqa_AnswerDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvqa_AnswerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvqa_AnswerDA.GetSpecSQLObj();
strSQL = "Select * from vqa_Answer where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvqa_AnswerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvqa_AnswerDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvqa_AnswerDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvqa_AnswerDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vqa_Answer where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vqa_Answer where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvqa_AnswerDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvqa_AnswerDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vqa_Answer where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvqa_AnswerDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvqa_AnswerDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vqa_Answer.* from vqa_Answer Left Join {1} on {2} where {3} and vqa_Answer.AnswerId not in (Select top {5} vqa_Answer.AnswerId from vqa_Answer Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vqa_Answer where {1} and AnswerId not in (Select top {2} AnswerId from vqa_Answer where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vqa_Answer where {1} and AnswerId not in (Select top {3} AnswerId from vqa_Answer where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvqa_AnswerDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvqa_AnswerDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vqa_Answer.* from vqa_Answer Left Join {1} on {2} where {3} and vqa_Answer.AnswerId not in (Select top {5} vqa_Answer.AnswerId from vqa_Answer Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vqa_Answer where {1} and AnswerId not in (Select top {2} AnswerId from vqa_Answer where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vqa_Answer where {1} and AnswerId not in (Select top {3} AnswerId from vqa_Answer where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvqa_AnswerEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvqa_AnswerDA:GetObjLst)", objException.Message));
}
List<clsvqa_AnswerEN> arrObjLst = new List<clsvqa_AnswerEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvqa_AnswerDA.GetSpecSQLObj();
strSQL = "Select * from vqa_Answer where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvqa_AnswerEN objvqa_AnswerEN = new clsvqa_AnswerEN();
try
{
objvqa_AnswerEN.AnswerId = objRow[convqa_Answer.AnswerId].ToString().Trim(); //回答Id
objvqa_AnswerEN.QuestionsId = objRow[convqa_Answer.QuestionsId].ToString().Trim(); //提问Id
objvqa_AnswerEN.AnswerContent = objRow[convqa_Answer.AnswerContent] == DBNull.Value ? null : objRow[convqa_Answer.AnswerContent].ToString().Trim(); //答案内容
objvqa_AnswerEN.Score = objRow[convqa_Answer.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convqa_Answer.Score].ToString().Trim()); //评分
objvqa_AnswerEN.ScoreType = objRow[convqa_Answer.ScoreType] == DBNull.Value ? null : objRow[convqa_Answer.ScoreType].ToString().Trim(); //评分类型
objvqa_AnswerEN.IsRight = TransNullToBool(objRow[convqa_Answer.IsRight].ToString().Trim()); //是否正确
objvqa_AnswerEN.ParentId = objRow[convqa_Answer.ParentId] == DBNull.Value ? null : objRow[convqa_Answer.ParentId].ToString().Trim(); //父节点Id
objvqa_AnswerEN.VoteCount = objRow[convqa_Answer.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Answer.VoteCount].ToString().Trim()); //点赞计数
objvqa_AnswerEN.UpdUser = objRow[convqa_Answer.UpdUser] == DBNull.Value ? null : objRow[convqa_Answer.UpdUser].ToString().Trim(); //修改人
objvqa_AnswerEN.UserName = objRow[convqa_Answer.UserName] == DBNull.Value ? null : objRow[convqa_Answer.UserName].ToString().Trim(); //用户名
objvqa_AnswerEN.UpdDate = objRow[convqa_Answer.UpdDate] == DBNull.Value ? null : objRow[convqa_Answer.UpdDate].ToString().Trim(); //修改日期
objvqa_AnswerEN.Memo = objRow[convqa_Answer.Memo] == DBNull.Value ? null : objRow[convqa_Answer.Memo].ToString().Trim(); //备注
objvqa_AnswerEN.QaPaperId = objRow[convqa_Answer.QaPaperId] == DBNull.Value ? null : objRow[convqa_Answer.QaPaperId].ToString().Trim(); //论文答疑Id
objvqa_AnswerEN.QuestionsContent = objRow[convqa_Answer.QuestionsContent] == DBNull.Value ? null : objRow[convqa_Answer.QuestionsContent].ToString().Trim(); //提问内容
objvqa_AnswerEN.PaperId = objRow[convqa_Answer.PaperId] == DBNull.Value ? null : objRow[convqa_Answer.PaperId].ToString().Trim(); //论文Id
objvqa_AnswerEN.QuestionsTypeId = objRow[convqa_Answer.QuestionsTypeId] == DBNull.Value ? null : objRow[convqa_Answer.QuestionsTypeId].ToString().Trim(); //问题类型Id
objvqa_AnswerEN.QuestionsTypeName = objRow[convqa_Answer.QuestionsTypeName] == DBNull.Value ? null : objRow[convqa_Answer.QuestionsTypeName].ToString().Trim(); //问题类型名称
objvqa_AnswerEN.IsRecommend = TransNullToBool(objRow[convqa_Answer.IsRecommend].ToString().Trim()); //是否推荐
objvqa_AnswerEN.TopicId = objRow[convqa_Answer.TopicId] == DBNull.Value ? null : objRow[convqa_Answer.TopicId].ToString().Trim(); //主题Id
objvqa_AnswerEN.AnswerTypeId = objRow[convqa_Answer.AnswerTypeId] == DBNull.Value ? null : objRow[convqa_Answer.AnswerTypeId].ToString().Trim(); //答案类型ID
objvqa_AnswerEN.IsSubmit = TransNullToBool(objRow[convqa_Answer.IsSubmit].ToString().Trim()); //是否提交
objvqa_AnswerEN.AnswerCount = objRow[convqa_Answer.AnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Answer.AnswerCount].ToString().Trim()); //回答计数
objvqa_AnswerEN.PaperTitle = objRow[convqa_Answer.PaperTitle] == DBNull.Value ? null : objRow[convqa_Answer.PaperTitle].ToString().Trim(); //论文标题
objvqa_AnswerEN.QuestUserName = objRow[convqa_Answer.QuestUserName] == DBNull.Value ? null : objRow[convqa_Answer.QuestUserName].ToString().Trim(); //QuestUserName
objvqa_AnswerEN.AppraiseCount = objRow[convqa_Answer.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Answer.AppraiseCount].ToString().Trim()); //评论数
objvqa_AnswerEN.StuScore = objRow[convqa_Answer.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convqa_Answer.StuScore].ToString().Trim()); //学生平均分
objvqa_AnswerEN.TeaScore = objRow[convqa_Answer.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convqa_Answer.TeaScore].ToString().Trim()); //教师评分
objvqa_AnswerEN.UserId = objRow[convqa_Answer.UserId] == DBNull.Value ? null : objRow[convqa_Answer.UserId].ToString().Trim(); //用户ID
objvqa_AnswerEN.IdCurrEduCls = objRow[convqa_Answer.IdCurrEduCls] == DBNull.Value ? null : objRow[convqa_Answer.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvqa_AnswerDA: GetObjLst)", objException.Message));
}
objvqa_AnswerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvqa_AnswerEN);
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
public List<clsvqa_AnswerEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvqa_AnswerDA:GetObjLstByTabName)", objException.Message));
}
List<clsvqa_AnswerEN> arrObjLst = new List<clsvqa_AnswerEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvqa_AnswerDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvqa_AnswerEN objvqa_AnswerEN = new clsvqa_AnswerEN();
try
{
objvqa_AnswerEN.AnswerId = objRow[convqa_Answer.AnswerId].ToString().Trim(); //回答Id
objvqa_AnswerEN.QuestionsId = objRow[convqa_Answer.QuestionsId].ToString().Trim(); //提问Id
objvqa_AnswerEN.AnswerContent = objRow[convqa_Answer.AnswerContent] == DBNull.Value ? null : objRow[convqa_Answer.AnswerContent].ToString().Trim(); //答案内容
objvqa_AnswerEN.Score = objRow[convqa_Answer.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convqa_Answer.Score].ToString().Trim()); //评分
objvqa_AnswerEN.ScoreType = objRow[convqa_Answer.ScoreType] == DBNull.Value ? null : objRow[convqa_Answer.ScoreType].ToString().Trim(); //评分类型
objvqa_AnswerEN.IsRight = TransNullToBool(objRow[convqa_Answer.IsRight].ToString().Trim()); //是否正确
objvqa_AnswerEN.ParentId = objRow[convqa_Answer.ParentId] == DBNull.Value ? null : objRow[convqa_Answer.ParentId].ToString().Trim(); //父节点Id
objvqa_AnswerEN.VoteCount = objRow[convqa_Answer.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Answer.VoteCount].ToString().Trim()); //点赞计数
objvqa_AnswerEN.UpdUser = objRow[convqa_Answer.UpdUser] == DBNull.Value ? null : objRow[convqa_Answer.UpdUser].ToString().Trim(); //修改人
objvqa_AnswerEN.UserName = objRow[convqa_Answer.UserName] == DBNull.Value ? null : objRow[convqa_Answer.UserName].ToString().Trim(); //用户名
objvqa_AnswerEN.UpdDate = objRow[convqa_Answer.UpdDate] == DBNull.Value ? null : objRow[convqa_Answer.UpdDate].ToString().Trim(); //修改日期
objvqa_AnswerEN.Memo = objRow[convqa_Answer.Memo] == DBNull.Value ? null : objRow[convqa_Answer.Memo].ToString().Trim(); //备注
objvqa_AnswerEN.QaPaperId = objRow[convqa_Answer.QaPaperId] == DBNull.Value ? null : objRow[convqa_Answer.QaPaperId].ToString().Trim(); //论文答疑Id
objvqa_AnswerEN.QuestionsContent = objRow[convqa_Answer.QuestionsContent] == DBNull.Value ? null : objRow[convqa_Answer.QuestionsContent].ToString().Trim(); //提问内容
objvqa_AnswerEN.PaperId = objRow[convqa_Answer.PaperId] == DBNull.Value ? null : objRow[convqa_Answer.PaperId].ToString().Trim(); //论文Id
objvqa_AnswerEN.QuestionsTypeId = objRow[convqa_Answer.QuestionsTypeId] == DBNull.Value ? null : objRow[convqa_Answer.QuestionsTypeId].ToString().Trim(); //问题类型Id
objvqa_AnswerEN.QuestionsTypeName = objRow[convqa_Answer.QuestionsTypeName] == DBNull.Value ? null : objRow[convqa_Answer.QuestionsTypeName].ToString().Trim(); //问题类型名称
objvqa_AnswerEN.IsRecommend = TransNullToBool(objRow[convqa_Answer.IsRecommend].ToString().Trim()); //是否推荐
objvqa_AnswerEN.TopicId = objRow[convqa_Answer.TopicId] == DBNull.Value ? null : objRow[convqa_Answer.TopicId].ToString().Trim(); //主题Id
objvqa_AnswerEN.AnswerTypeId = objRow[convqa_Answer.AnswerTypeId] == DBNull.Value ? null : objRow[convqa_Answer.AnswerTypeId].ToString().Trim(); //答案类型ID
objvqa_AnswerEN.IsSubmit = TransNullToBool(objRow[convqa_Answer.IsSubmit].ToString().Trim()); //是否提交
objvqa_AnswerEN.AnswerCount = objRow[convqa_Answer.AnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Answer.AnswerCount].ToString().Trim()); //回答计数
objvqa_AnswerEN.PaperTitle = objRow[convqa_Answer.PaperTitle] == DBNull.Value ? null : objRow[convqa_Answer.PaperTitle].ToString().Trim(); //论文标题
objvqa_AnswerEN.QuestUserName = objRow[convqa_Answer.QuestUserName] == DBNull.Value ? null : objRow[convqa_Answer.QuestUserName].ToString().Trim(); //QuestUserName
objvqa_AnswerEN.AppraiseCount = objRow[convqa_Answer.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Answer.AppraiseCount].ToString().Trim()); //评论数
objvqa_AnswerEN.StuScore = objRow[convqa_Answer.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convqa_Answer.StuScore].ToString().Trim()); //学生平均分
objvqa_AnswerEN.TeaScore = objRow[convqa_Answer.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convqa_Answer.TeaScore].ToString().Trim()); //教师评分
objvqa_AnswerEN.UserId = objRow[convqa_Answer.UserId] == DBNull.Value ? null : objRow[convqa_Answer.UserId].ToString().Trim(); //用户ID
objvqa_AnswerEN.IdCurrEduCls = objRow[convqa_Answer.IdCurrEduCls] == DBNull.Value ? null : objRow[convqa_Answer.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvqa_AnswerDA: GetObjLst)", objException.Message));
}
objvqa_AnswerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvqa_AnswerEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvqa_AnswerEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getvqa_Answer(ref clsvqa_AnswerEN objvqa_AnswerEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvqa_AnswerDA.GetSpecSQLObj();
strSQL = "Select * from vqa_Answer where AnswerId = " + "'"+ objvqa_AnswerEN.AnswerId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvqa_AnswerEN.AnswerId = objDT.Rows[0][convqa_Answer.AnswerId].ToString().Trim(); //回答Id(字段类型:char,字段长度:10,是否可空:False)
 objvqa_AnswerEN.QuestionsId = objDT.Rows[0][convqa_Answer.QuestionsId].ToString().Trim(); //提问Id(字段类型:char,字段长度:8,是否可空:False)
 objvqa_AnswerEN.AnswerContent = objDT.Rows[0][convqa_Answer.AnswerContent].ToString().Trim(); //答案内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvqa_AnswerEN.Score = TransNullToFloat(objDT.Rows[0][convqa_Answer.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvqa_AnswerEN.ScoreType = objDT.Rows[0][convqa_Answer.ScoreType].ToString().Trim(); //评分类型(字段类型:char,字段长度:1,是否可空:True)
 objvqa_AnswerEN.IsRight = TransNullToBool(objDT.Rows[0][convqa_Answer.IsRight].ToString().Trim()); //是否正确(字段类型:bit,字段长度:1,是否可空:True)
 objvqa_AnswerEN.ParentId = objDT.Rows[0][convqa_Answer.ParentId].ToString().Trim(); //父节点Id(字段类型:char,字段长度:10,是否可空:True)
 objvqa_AnswerEN.VoteCount = TransNullToInt(objDT.Rows[0][convqa_Answer.VoteCount].ToString().Trim()); //点赞计数(字段类型:int,字段长度:4,是否可空:True)
 objvqa_AnswerEN.UpdUser = objDT.Rows[0][convqa_Answer.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvqa_AnswerEN.UserName = objDT.Rows[0][convqa_Answer.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvqa_AnswerEN.UpdDate = objDT.Rows[0][convqa_Answer.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvqa_AnswerEN.Memo = objDT.Rows[0][convqa_Answer.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvqa_AnswerEN.QaPaperId = objDT.Rows[0][convqa_Answer.QaPaperId].ToString().Trim(); //论文答疑Id(字段类型:char,字段长度:8,是否可空:False)
 objvqa_AnswerEN.QuestionsContent = objDT.Rows[0][convqa_Answer.QuestionsContent].ToString().Trim(); //提问内容(字段类型:varchar,字段长度:1000,是否可空:True)
 objvqa_AnswerEN.PaperId = objDT.Rows[0][convqa_Answer.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objvqa_AnswerEN.QuestionsTypeId = objDT.Rows[0][convqa_Answer.QuestionsTypeId].ToString().Trim(); //问题类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvqa_AnswerEN.QuestionsTypeName = objDT.Rows[0][convqa_Answer.QuestionsTypeName].ToString().Trim(); //问题类型名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvqa_AnswerEN.IsRecommend = TransNullToBool(objDT.Rows[0][convqa_Answer.IsRecommend].ToString().Trim()); //是否推荐(字段类型:bit,字段长度:1,是否可空:True)
 objvqa_AnswerEN.TopicId = objDT.Rows[0][convqa_Answer.TopicId].ToString().Trim(); //主题Id(字段类型:char,字段长度:8,是否可空:True)
 objvqa_AnswerEN.AnswerTypeId = objDT.Rows[0][convqa_Answer.AnswerTypeId].ToString().Trim(); //答案类型ID(字段类型:char,字段长度:2,是否可空:True)
 objvqa_AnswerEN.IsSubmit = TransNullToBool(objDT.Rows[0][convqa_Answer.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvqa_AnswerEN.AnswerCount = TransNullToInt(objDT.Rows[0][convqa_Answer.AnswerCount].ToString().Trim()); //回答计数(字段类型:int,字段长度:4,是否可空:True)
 objvqa_AnswerEN.PaperTitle = objDT.Rows[0][convqa_Answer.PaperTitle].ToString().Trim(); //论文标题(字段类型:varchar,字段长度:500,是否可空:False)
 objvqa_AnswerEN.QuestUserName = objDT.Rows[0][convqa_Answer.QuestUserName].ToString().Trim(); //QuestUserName(字段类型:varchar,字段长度:30,是否可空:True)
 objvqa_AnswerEN.AppraiseCount = TransNullToInt(objDT.Rows[0][convqa_Answer.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objvqa_AnswerEN.StuScore = TransNullToFloat(objDT.Rows[0][convqa_Answer.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objvqa_AnswerEN.TeaScore = TransNullToFloat(objDT.Rows[0][convqa_Answer.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objvqa_AnswerEN.UserId = objDT.Rows[0][convqa_Answer.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvqa_AnswerEN.IdCurrEduCls = objDT.Rows[0][convqa_Answer.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvqa_AnswerDA: Getvqa_Answer)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strAnswerId">表关键字</param>
 /// <returns>表对象</returns>
public clsvqa_AnswerEN GetObjByAnswerId(string strAnswerId)
{
CheckPrimaryKey(strAnswerId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvqa_AnswerDA.GetSpecSQLObj();
strSQL = "Select * from vqa_Answer where AnswerId = " + "'"+ strAnswerId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvqa_AnswerEN objvqa_AnswerEN = new clsvqa_AnswerEN();
try
{
 objvqa_AnswerEN.AnswerId = objRow[convqa_Answer.AnswerId].ToString().Trim(); //回答Id(字段类型:char,字段长度:10,是否可空:False)
 objvqa_AnswerEN.QuestionsId = objRow[convqa_Answer.QuestionsId].ToString().Trim(); //提问Id(字段类型:char,字段长度:8,是否可空:False)
 objvqa_AnswerEN.AnswerContent = objRow[convqa_Answer.AnswerContent] == DBNull.Value ? null : objRow[convqa_Answer.AnswerContent].ToString().Trim(); //答案内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvqa_AnswerEN.Score = objRow[convqa_Answer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convqa_Answer.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvqa_AnswerEN.ScoreType = objRow[convqa_Answer.ScoreType] == DBNull.Value ? null : objRow[convqa_Answer.ScoreType].ToString().Trim(); //评分类型(字段类型:char,字段长度:1,是否可空:True)
 objvqa_AnswerEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[convqa_Answer.IsRight].ToString().Trim()); //是否正确(字段类型:bit,字段长度:1,是否可空:True)
 objvqa_AnswerEN.ParentId = objRow[convqa_Answer.ParentId] == DBNull.Value ? null : objRow[convqa_Answer.ParentId].ToString().Trim(); //父节点Id(字段类型:char,字段长度:10,是否可空:True)
 objvqa_AnswerEN.VoteCount = objRow[convqa_Answer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Answer.VoteCount].ToString().Trim()); //点赞计数(字段类型:int,字段长度:4,是否可空:True)
 objvqa_AnswerEN.UpdUser = objRow[convqa_Answer.UpdUser] == DBNull.Value ? null : objRow[convqa_Answer.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvqa_AnswerEN.UserName = objRow[convqa_Answer.UserName] == DBNull.Value ? null : objRow[convqa_Answer.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvqa_AnswerEN.UpdDate = objRow[convqa_Answer.UpdDate] == DBNull.Value ? null : objRow[convqa_Answer.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvqa_AnswerEN.Memo = objRow[convqa_Answer.Memo] == DBNull.Value ? null : objRow[convqa_Answer.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvqa_AnswerEN.QaPaperId = objRow[convqa_Answer.QaPaperId] == DBNull.Value ? null : objRow[convqa_Answer.QaPaperId].ToString().Trim(); //论文答疑Id(字段类型:char,字段长度:8,是否可空:False)
 objvqa_AnswerEN.QuestionsContent = objRow[convqa_Answer.QuestionsContent] == DBNull.Value ? null : objRow[convqa_Answer.QuestionsContent].ToString().Trim(); //提问内容(字段类型:varchar,字段长度:1000,是否可空:True)
 objvqa_AnswerEN.PaperId = objRow[convqa_Answer.PaperId] == DBNull.Value ? null : objRow[convqa_Answer.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objvqa_AnswerEN.QuestionsTypeId = objRow[convqa_Answer.QuestionsTypeId] == DBNull.Value ? null : objRow[convqa_Answer.QuestionsTypeId].ToString().Trim(); //问题类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvqa_AnswerEN.QuestionsTypeName = objRow[convqa_Answer.QuestionsTypeName] == DBNull.Value ? null : objRow[convqa_Answer.QuestionsTypeName].ToString().Trim(); //问题类型名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvqa_AnswerEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[convqa_Answer.IsRecommend].ToString().Trim()); //是否推荐(字段类型:bit,字段长度:1,是否可空:True)
 objvqa_AnswerEN.TopicId = objRow[convqa_Answer.TopicId] == DBNull.Value ? null : objRow[convqa_Answer.TopicId].ToString().Trim(); //主题Id(字段类型:char,字段长度:8,是否可空:True)
 objvqa_AnswerEN.AnswerTypeId = objRow[convqa_Answer.AnswerTypeId] == DBNull.Value ? null : objRow[convqa_Answer.AnswerTypeId].ToString().Trim(); //答案类型ID(字段类型:char,字段长度:2,是否可空:True)
 objvqa_AnswerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convqa_Answer.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvqa_AnswerEN.AnswerCount = objRow[convqa_Answer.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Answer.AnswerCount].ToString().Trim()); //回答计数(字段类型:int,字段长度:4,是否可空:True)
 objvqa_AnswerEN.PaperTitle = objRow[convqa_Answer.PaperTitle] == DBNull.Value ? null : objRow[convqa_Answer.PaperTitle].ToString().Trim(); //论文标题(字段类型:varchar,字段长度:500,是否可空:False)
 objvqa_AnswerEN.QuestUserName = objRow[convqa_Answer.QuestUserName] == DBNull.Value ? null : objRow[convqa_Answer.QuestUserName].ToString().Trim(); //QuestUserName(字段类型:varchar,字段长度:30,是否可空:True)
 objvqa_AnswerEN.AppraiseCount = objRow[convqa_Answer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Answer.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objvqa_AnswerEN.StuScore = objRow[convqa_Answer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convqa_Answer.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objvqa_AnswerEN.TeaScore = objRow[convqa_Answer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convqa_Answer.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objvqa_AnswerEN.UserId = objRow[convqa_Answer.UserId] == DBNull.Value ? null : objRow[convqa_Answer.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvqa_AnswerEN.IdCurrEduCls = objRow[convqa_Answer.IdCurrEduCls] == DBNull.Value ? null : objRow[convqa_Answer.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvqa_AnswerDA: GetObjByAnswerId)", objException.Message));
}
return objvqa_AnswerEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvqa_AnswerEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvqa_AnswerDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvqa_AnswerDA.GetSpecSQLObj();
strSQL = "Select * from vqa_Answer where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvqa_AnswerEN objvqa_AnswerEN = new clsvqa_AnswerEN()
{
AnswerId = objRow[convqa_Answer.AnswerId].ToString().Trim(), //回答Id
QuestionsId = objRow[convqa_Answer.QuestionsId].ToString().Trim(), //提问Id
AnswerContent = objRow[convqa_Answer.AnswerContent] == DBNull.Value ? null : objRow[convqa_Answer.AnswerContent].ToString().Trim(), //答案内容
Score = objRow[convqa_Answer.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convqa_Answer.Score].ToString().Trim()), //评分
ScoreType = objRow[convqa_Answer.ScoreType] == DBNull.Value ? null : objRow[convqa_Answer.ScoreType].ToString().Trim(), //评分类型
IsRight = TransNullToBool(objRow[convqa_Answer.IsRight].ToString().Trim()), //是否正确
ParentId = objRow[convqa_Answer.ParentId] == DBNull.Value ? null : objRow[convqa_Answer.ParentId].ToString().Trim(), //父节点Id
VoteCount = objRow[convqa_Answer.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Answer.VoteCount].ToString().Trim()), //点赞计数
UpdUser = objRow[convqa_Answer.UpdUser] == DBNull.Value ? null : objRow[convqa_Answer.UpdUser].ToString().Trim(), //修改人
UserName = objRow[convqa_Answer.UserName] == DBNull.Value ? null : objRow[convqa_Answer.UserName].ToString().Trim(), //用户名
UpdDate = objRow[convqa_Answer.UpdDate] == DBNull.Value ? null : objRow[convqa_Answer.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[convqa_Answer.Memo] == DBNull.Value ? null : objRow[convqa_Answer.Memo].ToString().Trim(), //备注
QaPaperId = objRow[convqa_Answer.QaPaperId] == DBNull.Value ? null : objRow[convqa_Answer.QaPaperId].ToString().Trim(), //论文答疑Id
QuestionsContent = objRow[convqa_Answer.QuestionsContent] == DBNull.Value ? null : objRow[convqa_Answer.QuestionsContent].ToString().Trim(), //提问内容
PaperId = objRow[convqa_Answer.PaperId] == DBNull.Value ? null : objRow[convqa_Answer.PaperId].ToString().Trim(), //论文Id
QuestionsTypeId = objRow[convqa_Answer.QuestionsTypeId] == DBNull.Value ? null : objRow[convqa_Answer.QuestionsTypeId].ToString().Trim(), //问题类型Id
QuestionsTypeName = objRow[convqa_Answer.QuestionsTypeName] == DBNull.Value ? null : objRow[convqa_Answer.QuestionsTypeName].ToString().Trim(), //问题类型名称
IsRecommend = TransNullToBool(objRow[convqa_Answer.IsRecommend].ToString().Trim()), //是否推荐
TopicId = objRow[convqa_Answer.TopicId] == DBNull.Value ? null : objRow[convqa_Answer.TopicId].ToString().Trim(), //主题Id
AnswerTypeId = objRow[convqa_Answer.AnswerTypeId] == DBNull.Value ? null : objRow[convqa_Answer.AnswerTypeId].ToString().Trim(), //答案类型ID
IsSubmit = TransNullToBool(objRow[convqa_Answer.IsSubmit].ToString().Trim()), //是否提交
AnswerCount = objRow[convqa_Answer.AnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Answer.AnswerCount].ToString().Trim()), //回答计数
PaperTitle = objRow[convqa_Answer.PaperTitle] == DBNull.Value ? null : objRow[convqa_Answer.PaperTitle].ToString().Trim(), //论文标题
QuestUserName = objRow[convqa_Answer.QuestUserName] == DBNull.Value ? null : objRow[convqa_Answer.QuestUserName].ToString().Trim(), //QuestUserName
AppraiseCount = objRow[convqa_Answer.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Answer.AppraiseCount].ToString().Trim()), //评论数
StuScore = objRow[convqa_Answer.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convqa_Answer.StuScore].ToString().Trim()), //学生平均分
TeaScore = objRow[convqa_Answer.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convqa_Answer.TeaScore].ToString().Trim()), //教师评分
UserId = objRow[convqa_Answer.UserId] == DBNull.Value ? null : objRow[convqa_Answer.UserId].ToString().Trim(), //用户ID
IdCurrEduCls = objRow[convqa_Answer.IdCurrEduCls] == DBNull.Value ? null : objRow[convqa_Answer.IdCurrEduCls].ToString().Trim() //教学班流水号
};
objvqa_AnswerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvqa_AnswerEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvqa_AnswerDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvqa_AnswerEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvqa_AnswerEN objvqa_AnswerEN = new clsvqa_AnswerEN();
try
{
objvqa_AnswerEN.AnswerId = objRow[convqa_Answer.AnswerId].ToString().Trim(); //回答Id
objvqa_AnswerEN.QuestionsId = objRow[convqa_Answer.QuestionsId].ToString().Trim(); //提问Id
objvqa_AnswerEN.AnswerContent = objRow[convqa_Answer.AnswerContent] == DBNull.Value ? null : objRow[convqa_Answer.AnswerContent].ToString().Trim(); //答案内容
objvqa_AnswerEN.Score = objRow[convqa_Answer.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convqa_Answer.Score].ToString().Trim()); //评分
objvqa_AnswerEN.ScoreType = objRow[convqa_Answer.ScoreType] == DBNull.Value ? null : objRow[convqa_Answer.ScoreType].ToString().Trim(); //评分类型
objvqa_AnswerEN.IsRight = TransNullToBool(objRow[convqa_Answer.IsRight].ToString().Trim()); //是否正确
objvqa_AnswerEN.ParentId = objRow[convqa_Answer.ParentId] == DBNull.Value ? null : objRow[convqa_Answer.ParentId].ToString().Trim(); //父节点Id
objvqa_AnswerEN.VoteCount = objRow[convqa_Answer.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Answer.VoteCount].ToString().Trim()); //点赞计数
objvqa_AnswerEN.UpdUser = objRow[convqa_Answer.UpdUser] == DBNull.Value ? null : objRow[convqa_Answer.UpdUser].ToString().Trim(); //修改人
objvqa_AnswerEN.UserName = objRow[convqa_Answer.UserName] == DBNull.Value ? null : objRow[convqa_Answer.UserName].ToString().Trim(); //用户名
objvqa_AnswerEN.UpdDate = objRow[convqa_Answer.UpdDate] == DBNull.Value ? null : objRow[convqa_Answer.UpdDate].ToString().Trim(); //修改日期
objvqa_AnswerEN.Memo = objRow[convqa_Answer.Memo] == DBNull.Value ? null : objRow[convqa_Answer.Memo].ToString().Trim(); //备注
objvqa_AnswerEN.QaPaperId = objRow[convqa_Answer.QaPaperId] == DBNull.Value ? null : objRow[convqa_Answer.QaPaperId].ToString().Trim(); //论文答疑Id
objvqa_AnswerEN.QuestionsContent = objRow[convqa_Answer.QuestionsContent] == DBNull.Value ? null : objRow[convqa_Answer.QuestionsContent].ToString().Trim(); //提问内容
objvqa_AnswerEN.PaperId = objRow[convqa_Answer.PaperId] == DBNull.Value ? null : objRow[convqa_Answer.PaperId].ToString().Trim(); //论文Id
objvqa_AnswerEN.QuestionsTypeId = objRow[convqa_Answer.QuestionsTypeId] == DBNull.Value ? null : objRow[convqa_Answer.QuestionsTypeId].ToString().Trim(); //问题类型Id
objvqa_AnswerEN.QuestionsTypeName = objRow[convqa_Answer.QuestionsTypeName] == DBNull.Value ? null : objRow[convqa_Answer.QuestionsTypeName].ToString().Trim(); //问题类型名称
objvqa_AnswerEN.IsRecommend = TransNullToBool(objRow[convqa_Answer.IsRecommend].ToString().Trim()); //是否推荐
objvqa_AnswerEN.TopicId = objRow[convqa_Answer.TopicId] == DBNull.Value ? null : objRow[convqa_Answer.TopicId].ToString().Trim(); //主题Id
objvqa_AnswerEN.AnswerTypeId = objRow[convqa_Answer.AnswerTypeId] == DBNull.Value ? null : objRow[convqa_Answer.AnswerTypeId].ToString().Trim(); //答案类型ID
objvqa_AnswerEN.IsSubmit = TransNullToBool(objRow[convqa_Answer.IsSubmit].ToString().Trim()); //是否提交
objvqa_AnswerEN.AnswerCount = objRow[convqa_Answer.AnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Answer.AnswerCount].ToString().Trim()); //回答计数
objvqa_AnswerEN.PaperTitle = objRow[convqa_Answer.PaperTitle] == DBNull.Value ? null : objRow[convqa_Answer.PaperTitle].ToString().Trim(); //论文标题
objvqa_AnswerEN.QuestUserName = objRow[convqa_Answer.QuestUserName] == DBNull.Value ? null : objRow[convqa_Answer.QuestUserName].ToString().Trim(); //QuestUserName
objvqa_AnswerEN.AppraiseCount = objRow[convqa_Answer.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Answer.AppraiseCount].ToString().Trim()); //评论数
objvqa_AnswerEN.StuScore = objRow[convqa_Answer.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convqa_Answer.StuScore].ToString().Trim()); //学生平均分
objvqa_AnswerEN.TeaScore = objRow[convqa_Answer.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convqa_Answer.TeaScore].ToString().Trim()); //教师评分
objvqa_AnswerEN.UserId = objRow[convqa_Answer.UserId] == DBNull.Value ? null : objRow[convqa_Answer.UserId].ToString().Trim(); //用户ID
objvqa_AnswerEN.IdCurrEduCls = objRow[convqa_Answer.IdCurrEduCls] == DBNull.Value ? null : objRow[convqa_Answer.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvqa_AnswerDA: GetObjByDataRowvqa_Answer)", objException.Message));
}
objvqa_AnswerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvqa_AnswerEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvqa_AnswerEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvqa_AnswerEN objvqa_AnswerEN = new clsvqa_AnswerEN();
try
{
objvqa_AnswerEN.AnswerId = objRow[convqa_Answer.AnswerId].ToString().Trim(); //回答Id
objvqa_AnswerEN.QuestionsId = objRow[convqa_Answer.QuestionsId].ToString().Trim(); //提问Id
objvqa_AnswerEN.AnswerContent = objRow[convqa_Answer.AnswerContent] == DBNull.Value ? null : objRow[convqa_Answer.AnswerContent].ToString().Trim(); //答案内容
objvqa_AnswerEN.Score = objRow[convqa_Answer.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convqa_Answer.Score].ToString().Trim()); //评分
objvqa_AnswerEN.ScoreType = objRow[convqa_Answer.ScoreType] == DBNull.Value ? null : objRow[convqa_Answer.ScoreType].ToString().Trim(); //评分类型
objvqa_AnswerEN.IsRight = TransNullToBool(objRow[convqa_Answer.IsRight].ToString().Trim()); //是否正确
objvqa_AnswerEN.ParentId = objRow[convqa_Answer.ParentId] == DBNull.Value ? null : objRow[convqa_Answer.ParentId].ToString().Trim(); //父节点Id
objvqa_AnswerEN.VoteCount = objRow[convqa_Answer.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Answer.VoteCount].ToString().Trim()); //点赞计数
objvqa_AnswerEN.UpdUser = objRow[convqa_Answer.UpdUser] == DBNull.Value ? null : objRow[convqa_Answer.UpdUser].ToString().Trim(); //修改人
objvqa_AnswerEN.UserName = objRow[convqa_Answer.UserName] == DBNull.Value ? null : objRow[convqa_Answer.UserName].ToString().Trim(); //用户名
objvqa_AnswerEN.UpdDate = objRow[convqa_Answer.UpdDate] == DBNull.Value ? null : objRow[convqa_Answer.UpdDate].ToString().Trim(); //修改日期
objvqa_AnswerEN.Memo = objRow[convqa_Answer.Memo] == DBNull.Value ? null : objRow[convqa_Answer.Memo].ToString().Trim(); //备注
objvqa_AnswerEN.QaPaperId = objRow[convqa_Answer.QaPaperId] == DBNull.Value ? null : objRow[convqa_Answer.QaPaperId].ToString().Trim(); //论文答疑Id
objvqa_AnswerEN.QuestionsContent = objRow[convqa_Answer.QuestionsContent] == DBNull.Value ? null : objRow[convqa_Answer.QuestionsContent].ToString().Trim(); //提问内容
objvqa_AnswerEN.PaperId = objRow[convqa_Answer.PaperId] == DBNull.Value ? null : objRow[convqa_Answer.PaperId].ToString().Trim(); //论文Id
objvqa_AnswerEN.QuestionsTypeId = objRow[convqa_Answer.QuestionsTypeId] == DBNull.Value ? null : objRow[convqa_Answer.QuestionsTypeId].ToString().Trim(); //问题类型Id
objvqa_AnswerEN.QuestionsTypeName = objRow[convqa_Answer.QuestionsTypeName] == DBNull.Value ? null : objRow[convqa_Answer.QuestionsTypeName].ToString().Trim(); //问题类型名称
objvqa_AnswerEN.IsRecommend = TransNullToBool(objRow[convqa_Answer.IsRecommend].ToString().Trim()); //是否推荐
objvqa_AnswerEN.TopicId = objRow[convqa_Answer.TopicId] == DBNull.Value ? null : objRow[convqa_Answer.TopicId].ToString().Trim(); //主题Id
objvqa_AnswerEN.AnswerTypeId = objRow[convqa_Answer.AnswerTypeId] == DBNull.Value ? null : objRow[convqa_Answer.AnswerTypeId].ToString().Trim(); //答案类型ID
objvqa_AnswerEN.IsSubmit = TransNullToBool(objRow[convqa_Answer.IsSubmit].ToString().Trim()); //是否提交
objvqa_AnswerEN.AnswerCount = objRow[convqa_Answer.AnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Answer.AnswerCount].ToString().Trim()); //回答计数
objvqa_AnswerEN.PaperTitle = objRow[convqa_Answer.PaperTitle] == DBNull.Value ? null : objRow[convqa_Answer.PaperTitle].ToString().Trim(); //论文标题
objvqa_AnswerEN.QuestUserName = objRow[convqa_Answer.QuestUserName] == DBNull.Value ? null : objRow[convqa_Answer.QuestUserName].ToString().Trim(); //QuestUserName
objvqa_AnswerEN.AppraiseCount = objRow[convqa_Answer.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Answer.AppraiseCount].ToString().Trim()); //评论数
objvqa_AnswerEN.StuScore = objRow[convqa_Answer.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convqa_Answer.StuScore].ToString().Trim()); //学生平均分
objvqa_AnswerEN.TeaScore = objRow[convqa_Answer.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convqa_Answer.TeaScore].ToString().Trim()); //教师评分
objvqa_AnswerEN.UserId = objRow[convqa_Answer.UserId] == DBNull.Value ? null : objRow[convqa_Answer.UserId].ToString().Trim(); //用户ID
objvqa_AnswerEN.IdCurrEduCls = objRow[convqa_Answer.IdCurrEduCls] == DBNull.Value ? null : objRow[convqa_Answer.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvqa_AnswerDA: GetObjByDataRow)", objException.Message));
}
objvqa_AnswerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvqa_AnswerEN;
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
objSQL = clsvqa_AnswerDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvqa_AnswerEN._CurrTabName, convqa_Answer.AnswerId, 10, "");
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
objSQL = clsvqa_AnswerDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvqa_AnswerEN._CurrTabName, convqa_Answer.AnswerId, 10, strPrefix);
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
 objSQL = clsvqa_AnswerDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select AnswerId from vqa_Answer where " + strCondition;
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
 objSQL = clsvqa_AnswerDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select AnswerId from vqa_Answer where " + strCondition;
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
 objSQL = clsvqa_AnswerDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vqa_Answer", "AnswerId = " + "'"+ strAnswerId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvqa_AnswerDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvqa_AnswerDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vqa_Answer", strCondition))
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
objSQL = clsvqa_AnswerDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vqa_Answer");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvqa_AnswerENS">源对象</param>
 /// <param name = "objvqa_AnswerENT">目标对象</param>
public void CopyTo(clsvqa_AnswerEN objvqa_AnswerENS, clsvqa_AnswerEN objvqa_AnswerENT)
{
objvqa_AnswerENT.AnswerId = objvqa_AnswerENS.AnswerId; //回答Id
objvqa_AnswerENT.QuestionsId = objvqa_AnswerENS.QuestionsId; //提问Id
objvqa_AnswerENT.AnswerContent = objvqa_AnswerENS.AnswerContent; //答案内容
objvqa_AnswerENT.Score = objvqa_AnswerENS.Score; //评分
objvqa_AnswerENT.ScoreType = objvqa_AnswerENS.ScoreType; //评分类型
objvqa_AnswerENT.IsRight = objvqa_AnswerENS.IsRight; //是否正确
objvqa_AnswerENT.ParentId = objvqa_AnswerENS.ParentId; //父节点Id
objvqa_AnswerENT.VoteCount = objvqa_AnswerENS.VoteCount; //点赞计数
objvqa_AnswerENT.UpdUser = objvqa_AnswerENS.UpdUser; //修改人
objvqa_AnswerENT.UserName = objvqa_AnswerENS.UserName; //用户名
objvqa_AnswerENT.UpdDate = objvqa_AnswerENS.UpdDate; //修改日期
objvqa_AnswerENT.Memo = objvqa_AnswerENS.Memo; //备注
objvqa_AnswerENT.QaPaperId = objvqa_AnswerENS.QaPaperId; //论文答疑Id
objvqa_AnswerENT.QuestionsContent = objvqa_AnswerENS.QuestionsContent; //提问内容
objvqa_AnswerENT.PaperId = objvqa_AnswerENS.PaperId; //论文Id
objvqa_AnswerENT.QuestionsTypeId = objvqa_AnswerENS.QuestionsTypeId; //问题类型Id
objvqa_AnswerENT.QuestionsTypeName = objvqa_AnswerENS.QuestionsTypeName; //问题类型名称
objvqa_AnswerENT.IsRecommend = objvqa_AnswerENS.IsRecommend; //是否推荐
objvqa_AnswerENT.TopicId = objvqa_AnswerENS.TopicId; //主题Id
objvqa_AnswerENT.AnswerTypeId = objvqa_AnswerENS.AnswerTypeId; //答案类型ID
objvqa_AnswerENT.IsSubmit = objvqa_AnswerENS.IsSubmit; //是否提交
objvqa_AnswerENT.AnswerCount = objvqa_AnswerENS.AnswerCount; //回答计数
objvqa_AnswerENT.PaperTitle = objvqa_AnswerENS.PaperTitle; //论文标题
objvqa_AnswerENT.QuestUserName = objvqa_AnswerENS.QuestUserName; //QuestUserName
objvqa_AnswerENT.AppraiseCount = objvqa_AnswerENS.AppraiseCount; //评论数
objvqa_AnswerENT.StuScore = objvqa_AnswerENS.StuScore; //学生平均分
objvqa_AnswerENT.TeaScore = objvqa_AnswerENS.TeaScore; //教师评分
objvqa_AnswerENT.UserId = objvqa_AnswerENS.UserId; //用户ID
objvqa_AnswerENT.IdCurrEduCls = objvqa_AnswerENS.IdCurrEduCls; //教学班流水号
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvqa_AnswerEN objvqa_AnswerEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvqa_AnswerEN.AnswerId, 10, convqa_Answer.AnswerId);
clsCheckSql.CheckFieldLen(objvqa_AnswerEN.QuestionsId, 8, convqa_Answer.QuestionsId);
clsCheckSql.CheckFieldLen(objvqa_AnswerEN.ScoreType, 1, convqa_Answer.ScoreType);
clsCheckSql.CheckFieldLen(objvqa_AnswerEN.ParentId, 10, convqa_Answer.ParentId);
clsCheckSql.CheckFieldLen(objvqa_AnswerEN.UpdUser, 20, convqa_Answer.UpdUser);
clsCheckSql.CheckFieldLen(objvqa_AnswerEN.UserName, 30, convqa_Answer.UserName);
clsCheckSql.CheckFieldLen(objvqa_AnswerEN.UpdDate, 20, convqa_Answer.UpdDate);
clsCheckSql.CheckFieldLen(objvqa_AnswerEN.Memo, 1000, convqa_Answer.Memo);
clsCheckSql.CheckFieldLen(objvqa_AnswerEN.QaPaperId, 8, convqa_Answer.QaPaperId);
clsCheckSql.CheckFieldLen(objvqa_AnswerEN.QuestionsContent, 1000, convqa_Answer.QuestionsContent);
clsCheckSql.CheckFieldLen(objvqa_AnswerEN.PaperId, 8, convqa_Answer.PaperId);
clsCheckSql.CheckFieldLen(objvqa_AnswerEN.QuestionsTypeId, 2, convqa_Answer.QuestionsTypeId);
clsCheckSql.CheckFieldLen(objvqa_AnswerEN.QuestionsTypeName, 50, convqa_Answer.QuestionsTypeName);
clsCheckSql.CheckFieldLen(objvqa_AnswerEN.TopicId, 8, convqa_Answer.TopicId);
clsCheckSql.CheckFieldLen(objvqa_AnswerEN.AnswerTypeId, 2, convqa_Answer.AnswerTypeId);
clsCheckSql.CheckFieldLen(objvqa_AnswerEN.PaperTitle, 500, convqa_Answer.PaperTitle);
clsCheckSql.CheckFieldLen(objvqa_AnswerEN.QuestUserName, 30, convqa_Answer.QuestUserName);
clsCheckSql.CheckFieldLen(objvqa_AnswerEN.UserId, 18, convqa_Answer.UserId);
clsCheckSql.CheckFieldLen(objvqa_AnswerEN.IdCurrEduCls, 8, convqa_Answer.IdCurrEduCls);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvqa_AnswerEN.AnswerId, convqa_Answer.AnswerId);
clsCheckSql.CheckSqlInjection4Field(objvqa_AnswerEN.QuestionsId, convqa_Answer.QuestionsId);
clsCheckSql.CheckSqlInjection4Field(objvqa_AnswerEN.ScoreType, convqa_Answer.ScoreType);
clsCheckSql.CheckSqlInjection4Field(objvqa_AnswerEN.ParentId, convqa_Answer.ParentId);
clsCheckSql.CheckSqlInjection4Field(objvqa_AnswerEN.UpdUser, convqa_Answer.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvqa_AnswerEN.UserName, convqa_Answer.UserName);
clsCheckSql.CheckSqlInjection4Field(objvqa_AnswerEN.UpdDate, convqa_Answer.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvqa_AnswerEN.Memo, convqa_Answer.Memo);
clsCheckSql.CheckSqlInjection4Field(objvqa_AnswerEN.QaPaperId, convqa_Answer.QaPaperId);
clsCheckSql.CheckSqlInjection4Field(objvqa_AnswerEN.QuestionsContent, convqa_Answer.QuestionsContent);
clsCheckSql.CheckSqlInjection4Field(objvqa_AnswerEN.PaperId, convqa_Answer.PaperId);
clsCheckSql.CheckSqlInjection4Field(objvqa_AnswerEN.QuestionsTypeId, convqa_Answer.QuestionsTypeId);
clsCheckSql.CheckSqlInjection4Field(objvqa_AnswerEN.QuestionsTypeName, convqa_Answer.QuestionsTypeName);
clsCheckSql.CheckSqlInjection4Field(objvqa_AnswerEN.TopicId, convqa_Answer.TopicId);
clsCheckSql.CheckSqlInjection4Field(objvqa_AnswerEN.AnswerTypeId, convqa_Answer.AnswerTypeId);
clsCheckSql.CheckSqlInjection4Field(objvqa_AnswerEN.PaperTitle, convqa_Answer.PaperTitle);
clsCheckSql.CheckSqlInjection4Field(objvqa_AnswerEN.QuestUserName, convqa_Answer.QuestUserName);
clsCheckSql.CheckSqlInjection4Field(objvqa_AnswerEN.UserId, convqa_Answer.UserId);
clsCheckSql.CheckSqlInjection4Field(objvqa_AnswerEN.IdCurrEduCls, convqa_Answer.IdCurrEduCls);
//检查外键字段长度
 objvqa_AnswerEN._IsCheckProperty = true;
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
 objSQL = clsvqa_AnswerDA.GetSpecSQLObj();
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
 objSQL = clsvqa_AnswerDA.GetSpecSQLObj();
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
 objSQL = clsvqa_AnswerDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvqa_AnswerEN._CurrTabName);
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
 objSQL = clsvqa_AnswerDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvqa_AnswerEN._CurrTabName, strCondition);
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
 objSQL = clsvqa_AnswerDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}