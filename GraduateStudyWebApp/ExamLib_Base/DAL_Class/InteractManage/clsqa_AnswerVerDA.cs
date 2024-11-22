
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsqa_AnswerVerDA
 表名:qa_AnswerVer(01120756)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:13:17
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
 /// 答疑回答历史V(qa_AnswerVer)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsqa_AnswerVerDA : clsCommBase4DA
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
 return clsqa_AnswerVerEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsqa_AnswerVerEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsqa_AnswerVerEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsqa_AnswerVerEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsqa_AnswerVerEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsqa_AnswerVerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_AnswerVerDA.GetSpecSQLObj();
strSQL = "Select * from qa_AnswerVer where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_qa_AnswerVer(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsqa_AnswerVerDA: GetDataTable_qa_AnswerVer)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_AnswerVerDA.GetSpecSQLObj();
strSQL = "Select * from qa_AnswerVer where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsqa_AnswerVerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_AnswerVerDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsqa_AnswerVerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_AnswerVerDA.GetSpecSQLObj();
strSQL = "Select * from qa_AnswerVer where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsqa_AnswerVerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_AnswerVerDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsqa_AnswerVerDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_AnswerVerDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from qa_AnswerVer where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from qa_AnswerVer where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsqa_AnswerVerDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_AnswerVerDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from qa_AnswerVer where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsqa_AnswerVerDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_AnswerVerDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} qa_AnswerVer.* from qa_AnswerVer Left Join {1} on {2} where {3} and qa_AnswerVer.AnswerVId not in (Select top {5} qa_AnswerVer.AnswerVId from qa_AnswerVer Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from qa_AnswerVer where {1} and AnswerVId not in (Select top {2} AnswerVId from qa_AnswerVer where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from qa_AnswerVer where {1} and AnswerVId not in (Select top {3} AnswerVId from qa_AnswerVer where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsqa_AnswerVerDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_AnswerVerDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} qa_AnswerVer.* from qa_AnswerVer Left Join {1} on {2} where {3} and qa_AnswerVer.AnswerVId not in (Select top {5} qa_AnswerVer.AnswerVId from qa_AnswerVer Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from qa_AnswerVer where {1} and AnswerVId not in (Select top {2} AnswerVId from qa_AnswerVer where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from qa_AnswerVer where {1} and AnswerVId not in (Select top {3} AnswerVId from qa_AnswerVer where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsqa_AnswerVerEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsqa_AnswerVerDA:GetObjLst)", objException.Message));
}
List<clsqa_AnswerVerEN> arrObjLst = new List<clsqa_AnswerVerEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_AnswerVerDA.GetSpecSQLObj();
strSQL = "Select * from qa_AnswerVer where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsqa_AnswerVerEN objqa_AnswerVerEN = new clsqa_AnswerVerEN();
try
{
objqa_AnswerVerEN.AnswerVId = TransNullToInt(objRow[conqa_AnswerVer.AnswerVId].ToString().Trim()); //问答历史主键
objqa_AnswerVerEN.AnswerId = objRow[conqa_AnswerVer.AnswerId].ToString().Trim(); //回答Id
objqa_AnswerVerEN.QuestionsId = objRow[conqa_AnswerVer.QuestionsId].ToString().Trim(); //提问Id
objqa_AnswerVerEN.AnswerContent = objRow[conqa_AnswerVer.AnswerContent] == DBNull.Value ? null : objRow[conqa_AnswerVer.AnswerContent].ToString().Trim(); //答案内容
objqa_AnswerVerEN.Score = objRow[conqa_AnswerVer.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conqa_AnswerVer.Score].ToString().Trim()); //评分
objqa_AnswerVerEN.ScoreType = objRow[conqa_AnswerVer.ScoreType] == DBNull.Value ? null : objRow[conqa_AnswerVer.ScoreType].ToString().Trim(); //评分类型
objqa_AnswerVerEN.IsRight = TransNullToBool(objRow[conqa_AnswerVer.IsRight].ToString().Trim()); //是否正确
objqa_AnswerVerEN.ParentId = objRow[conqa_AnswerVer.ParentId] == DBNull.Value ? null : objRow[conqa_AnswerVer.ParentId].ToString().Trim(); //父节点Id
objqa_AnswerVerEN.VoteCount = objRow[conqa_AnswerVer.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conqa_AnswerVer.VoteCount].ToString().Trim()); //点赞计数
objqa_AnswerVerEN.IsRecommend = TransNullToBool(objRow[conqa_AnswerVer.IsRecommend].ToString().Trim()); //是否推荐
objqa_AnswerVerEN.TopicId = objRow[conqa_AnswerVer.TopicId] == DBNull.Value ? null : objRow[conqa_AnswerVer.TopicId].ToString().Trim(); //主题Id
objqa_AnswerVerEN.AnswerTypeId = objRow[conqa_AnswerVer.AnswerTypeId] == DBNull.Value ? null : objRow[conqa_AnswerVer.AnswerTypeId].ToString().Trim(); //答案类型ID
objqa_AnswerVerEN.IsSubmit = TransNullToBool(objRow[conqa_AnswerVer.IsSubmit].ToString().Trim()); //是否提交
objqa_AnswerVerEN.UpdUser = objRow[conqa_AnswerVer.UpdUser] == DBNull.Value ? null : objRow[conqa_AnswerVer.UpdUser].ToString().Trim(); //修改人
objqa_AnswerVerEN.UpdDate = objRow[conqa_AnswerVer.UpdDate] == DBNull.Value ? null : objRow[conqa_AnswerVer.UpdDate].ToString().Trim(); //修改日期
objqa_AnswerVerEN.Memo = objRow[conqa_AnswerVer.Memo] == DBNull.Value ? null : objRow[conqa_AnswerVer.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsqa_AnswerVerDA: GetObjLst)", objException.Message));
}
objqa_AnswerVerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objqa_AnswerVerEN);
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
public List<clsqa_AnswerVerEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsqa_AnswerVerDA:GetObjLstByTabName)", objException.Message));
}
List<clsqa_AnswerVerEN> arrObjLst = new List<clsqa_AnswerVerEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_AnswerVerDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsqa_AnswerVerEN objqa_AnswerVerEN = new clsqa_AnswerVerEN();
try
{
objqa_AnswerVerEN.AnswerVId = TransNullToInt(objRow[conqa_AnswerVer.AnswerVId].ToString().Trim()); //问答历史主键
objqa_AnswerVerEN.AnswerId = objRow[conqa_AnswerVer.AnswerId].ToString().Trim(); //回答Id
objqa_AnswerVerEN.QuestionsId = objRow[conqa_AnswerVer.QuestionsId].ToString().Trim(); //提问Id
objqa_AnswerVerEN.AnswerContent = objRow[conqa_AnswerVer.AnswerContent] == DBNull.Value ? null : objRow[conqa_AnswerVer.AnswerContent].ToString().Trim(); //答案内容
objqa_AnswerVerEN.Score = objRow[conqa_AnswerVer.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conqa_AnswerVer.Score].ToString().Trim()); //评分
objqa_AnswerVerEN.ScoreType = objRow[conqa_AnswerVer.ScoreType] == DBNull.Value ? null : objRow[conqa_AnswerVer.ScoreType].ToString().Trim(); //评分类型
objqa_AnswerVerEN.IsRight = TransNullToBool(objRow[conqa_AnswerVer.IsRight].ToString().Trim()); //是否正确
objqa_AnswerVerEN.ParentId = objRow[conqa_AnswerVer.ParentId] == DBNull.Value ? null : objRow[conqa_AnswerVer.ParentId].ToString().Trim(); //父节点Id
objqa_AnswerVerEN.VoteCount = objRow[conqa_AnswerVer.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conqa_AnswerVer.VoteCount].ToString().Trim()); //点赞计数
objqa_AnswerVerEN.IsRecommend = TransNullToBool(objRow[conqa_AnswerVer.IsRecommend].ToString().Trim()); //是否推荐
objqa_AnswerVerEN.TopicId = objRow[conqa_AnswerVer.TopicId] == DBNull.Value ? null : objRow[conqa_AnswerVer.TopicId].ToString().Trim(); //主题Id
objqa_AnswerVerEN.AnswerTypeId = objRow[conqa_AnswerVer.AnswerTypeId] == DBNull.Value ? null : objRow[conqa_AnswerVer.AnswerTypeId].ToString().Trim(); //答案类型ID
objqa_AnswerVerEN.IsSubmit = TransNullToBool(objRow[conqa_AnswerVer.IsSubmit].ToString().Trim()); //是否提交
objqa_AnswerVerEN.UpdUser = objRow[conqa_AnswerVer.UpdUser] == DBNull.Value ? null : objRow[conqa_AnswerVer.UpdUser].ToString().Trim(); //修改人
objqa_AnswerVerEN.UpdDate = objRow[conqa_AnswerVer.UpdDate] == DBNull.Value ? null : objRow[conqa_AnswerVer.UpdDate].ToString().Trim(); //修改日期
objqa_AnswerVerEN.Memo = objRow[conqa_AnswerVer.Memo] == DBNull.Value ? null : objRow[conqa_AnswerVer.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsqa_AnswerVerDA: GetObjLst)", objException.Message));
}
objqa_AnswerVerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objqa_AnswerVerEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objqa_AnswerVerEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getqa_AnswerVer(ref clsqa_AnswerVerEN objqa_AnswerVerEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_AnswerVerDA.GetSpecSQLObj();
strSQL = "Select * from qa_AnswerVer where AnswerVId = " + ""+ objqa_AnswerVerEN.AnswerVId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objqa_AnswerVerEN.AnswerVId = TransNullToInt(objDT.Rows[0][conqa_AnswerVer.AnswerVId].ToString().Trim()); //问答历史主键(字段类型:bigint,字段长度:8,是否可空:False)
 objqa_AnswerVerEN.AnswerId = objDT.Rows[0][conqa_AnswerVer.AnswerId].ToString().Trim(); //回答Id(字段类型:char,字段长度:10,是否可空:False)
 objqa_AnswerVerEN.QuestionsId = objDT.Rows[0][conqa_AnswerVer.QuestionsId].ToString().Trim(); //提问Id(字段类型:char,字段长度:8,是否可空:False)
 objqa_AnswerVerEN.AnswerContent = objDT.Rows[0][conqa_AnswerVer.AnswerContent].ToString().Trim(); //答案内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objqa_AnswerVerEN.Score = TransNullToFloat(objDT.Rows[0][conqa_AnswerVer.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objqa_AnswerVerEN.ScoreType = objDT.Rows[0][conqa_AnswerVer.ScoreType].ToString().Trim(); //评分类型(字段类型:char,字段长度:1,是否可空:True)
 objqa_AnswerVerEN.IsRight = TransNullToBool(objDT.Rows[0][conqa_AnswerVer.IsRight].ToString().Trim()); //是否正确(字段类型:bit,字段长度:1,是否可空:True)
 objqa_AnswerVerEN.ParentId = objDT.Rows[0][conqa_AnswerVer.ParentId].ToString().Trim(); //父节点Id(字段类型:char,字段长度:10,是否可空:True)
 objqa_AnswerVerEN.VoteCount = TransNullToInt(objDT.Rows[0][conqa_AnswerVer.VoteCount].ToString().Trim()); //点赞计数(字段类型:int,字段长度:4,是否可空:True)
 objqa_AnswerVerEN.IsRecommend = TransNullToBool(objDT.Rows[0][conqa_AnswerVer.IsRecommend].ToString().Trim()); //是否推荐(字段类型:bit,字段长度:1,是否可空:True)
 objqa_AnswerVerEN.TopicId = objDT.Rows[0][conqa_AnswerVer.TopicId].ToString().Trim(); //主题Id(字段类型:char,字段长度:8,是否可空:True)
 objqa_AnswerVerEN.AnswerTypeId = objDT.Rows[0][conqa_AnswerVer.AnswerTypeId].ToString().Trim(); //答案类型ID(字段类型:char,字段长度:2,是否可空:True)
 objqa_AnswerVerEN.IsSubmit = TransNullToBool(objDT.Rows[0][conqa_AnswerVer.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objqa_AnswerVerEN.UpdUser = objDT.Rows[0][conqa_AnswerVer.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objqa_AnswerVerEN.UpdDate = objDT.Rows[0][conqa_AnswerVer.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objqa_AnswerVerEN.Memo = objDT.Rows[0][conqa_AnswerVer.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsqa_AnswerVerDA: Getqa_AnswerVer)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngAnswerVId">表关键字</param>
 /// <returns>表对象</returns>
public clsqa_AnswerVerEN GetObjByAnswerVId(long lngAnswerVId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_AnswerVerDA.GetSpecSQLObj();
strSQL = "Select * from qa_AnswerVer where AnswerVId = " + ""+ lngAnswerVId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsqa_AnswerVerEN objqa_AnswerVerEN = new clsqa_AnswerVerEN();
try
{
 objqa_AnswerVerEN.AnswerVId = Int32.Parse(objRow[conqa_AnswerVer.AnswerVId].ToString().Trim()); //问答历史主键(字段类型:bigint,字段长度:8,是否可空:False)
 objqa_AnswerVerEN.AnswerId = objRow[conqa_AnswerVer.AnswerId].ToString().Trim(); //回答Id(字段类型:char,字段长度:10,是否可空:False)
 objqa_AnswerVerEN.QuestionsId = objRow[conqa_AnswerVer.QuestionsId].ToString().Trim(); //提问Id(字段类型:char,字段长度:8,是否可空:False)
 objqa_AnswerVerEN.AnswerContent = objRow[conqa_AnswerVer.AnswerContent] == DBNull.Value ? null : objRow[conqa_AnswerVer.AnswerContent].ToString().Trim(); //答案内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objqa_AnswerVerEN.Score = objRow[conqa_AnswerVer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conqa_AnswerVer.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objqa_AnswerVerEN.ScoreType = objRow[conqa_AnswerVer.ScoreType] == DBNull.Value ? null : objRow[conqa_AnswerVer.ScoreType].ToString().Trim(); //评分类型(字段类型:char,字段长度:1,是否可空:True)
 objqa_AnswerVerEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[conqa_AnswerVer.IsRight].ToString().Trim()); //是否正确(字段类型:bit,字段长度:1,是否可空:True)
 objqa_AnswerVerEN.ParentId = objRow[conqa_AnswerVer.ParentId] == DBNull.Value ? null : objRow[conqa_AnswerVer.ParentId].ToString().Trim(); //父节点Id(字段类型:char,字段长度:10,是否可空:True)
 objqa_AnswerVerEN.VoteCount = objRow[conqa_AnswerVer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conqa_AnswerVer.VoteCount].ToString().Trim()); //点赞计数(字段类型:int,字段长度:4,是否可空:True)
 objqa_AnswerVerEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conqa_AnswerVer.IsRecommend].ToString().Trim()); //是否推荐(字段类型:bit,字段长度:1,是否可空:True)
 objqa_AnswerVerEN.TopicId = objRow[conqa_AnswerVer.TopicId] == DBNull.Value ? null : objRow[conqa_AnswerVer.TopicId].ToString().Trim(); //主题Id(字段类型:char,字段长度:8,是否可空:True)
 objqa_AnswerVerEN.AnswerTypeId = objRow[conqa_AnswerVer.AnswerTypeId] == DBNull.Value ? null : objRow[conqa_AnswerVer.AnswerTypeId].ToString().Trim(); //答案类型ID(字段类型:char,字段长度:2,是否可空:True)
 objqa_AnswerVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conqa_AnswerVer.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objqa_AnswerVerEN.UpdUser = objRow[conqa_AnswerVer.UpdUser] == DBNull.Value ? null : objRow[conqa_AnswerVer.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objqa_AnswerVerEN.UpdDate = objRow[conqa_AnswerVer.UpdDate] == DBNull.Value ? null : objRow[conqa_AnswerVer.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objqa_AnswerVerEN.Memo = objRow[conqa_AnswerVer.Memo] == DBNull.Value ? null : objRow[conqa_AnswerVer.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsqa_AnswerVerDA: GetObjByAnswerVId)", objException.Message));
}
return objqa_AnswerVerEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsqa_AnswerVerEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsqa_AnswerVerDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_AnswerVerDA.GetSpecSQLObj();
strSQL = "Select * from qa_AnswerVer where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsqa_AnswerVerEN objqa_AnswerVerEN = new clsqa_AnswerVerEN()
{
AnswerVId = TransNullToInt(objRow[conqa_AnswerVer.AnswerVId].ToString().Trim()), //问答历史主键
AnswerId = objRow[conqa_AnswerVer.AnswerId].ToString().Trim(), //回答Id
QuestionsId = objRow[conqa_AnswerVer.QuestionsId].ToString().Trim(), //提问Id
AnswerContent = objRow[conqa_AnswerVer.AnswerContent] == DBNull.Value ? null : objRow[conqa_AnswerVer.AnswerContent].ToString().Trim(), //答案内容
Score = objRow[conqa_AnswerVer.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conqa_AnswerVer.Score].ToString().Trim()), //评分
ScoreType = objRow[conqa_AnswerVer.ScoreType] == DBNull.Value ? null : objRow[conqa_AnswerVer.ScoreType].ToString().Trim(), //评分类型
IsRight = TransNullToBool(objRow[conqa_AnswerVer.IsRight].ToString().Trim()), //是否正确
ParentId = objRow[conqa_AnswerVer.ParentId] == DBNull.Value ? null : objRow[conqa_AnswerVer.ParentId].ToString().Trim(), //父节点Id
VoteCount = objRow[conqa_AnswerVer.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conqa_AnswerVer.VoteCount].ToString().Trim()), //点赞计数
IsRecommend = TransNullToBool(objRow[conqa_AnswerVer.IsRecommend].ToString().Trim()), //是否推荐
TopicId = objRow[conqa_AnswerVer.TopicId] == DBNull.Value ? null : objRow[conqa_AnswerVer.TopicId].ToString().Trim(), //主题Id
AnswerTypeId = objRow[conqa_AnswerVer.AnswerTypeId] == DBNull.Value ? null : objRow[conqa_AnswerVer.AnswerTypeId].ToString().Trim(), //答案类型ID
IsSubmit = TransNullToBool(objRow[conqa_AnswerVer.IsSubmit].ToString().Trim()), //是否提交
UpdUser = objRow[conqa_AnswerVer.UpdUser] == DBNull.Value ? null : objRow[conqa_AnswerVer.UpdUser].ToString().Trim(), //修改人
UpdDate = objRow[conqa_AnswerVer.UpdDate] == DBNull.Value ? null : objRow[conqa_AnswerVer.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[conqa_AnswerVer.Memo] == DBNull.Value ? null : objRow[conqa_AnswerVer.Memo].ToString().Trim() //备注
};
objqa_AnswerVerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objqa_AnswerVerEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsqa_AnswerVerDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsqa_AnswerVerEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsqa_AnswerVerEN objqa_AnswerVerEN = new clsqa_AnswerVerEN();
try
{
objqa_AnswerVerEN.AnswerVId = TransNullToInt(objRow[conqa_AnswerVer.AnswerVId].ToString().Trim()); //问答历史主键
objqa_AnswerVerEN.AnswerId = objRow[conqa_AnswerVer.AnswerId].ToString().Trim(); //回答Id
objqa_AnswerVerEN.QuestionsId = objRow[conqa_AnswerVer.QuestionsId].ToString().Trim(); //提问Id
objqa_AnswerVerEN.AnswerContent = objRow[conqa_AnswerVer.AnswerContent] == DBNull.Value ? null : objRow[conqa_AnswerVer.AnswerContent].ToString().Trim(); //答案内容
objqa_AnswerVerEN.Score = objRow[conqa_AnswerVer.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conqa_AnswerVer.Score].ToString().Trim()); //评分
objqa_AnswerVerEN.ScoreType = objRow[conqa_AnswerVer.ScoreType] == DBNull.Value ? null : objRow[conqa_AnswerVer.ScoreType].ToString().Trim(); //评分类型
objqa_AnswerVerEN.IsRight = TransNullToBool(objRow[conqa_AnswerVer.IsRight].ToString().Trim()); //是否正确
objqa_AnswerVerEN.ParentId = objRow[conqa_AnswerVer.ParentId] == DBNull.Value ? null : objRow[conqa_AnswerVer.ParentId].ToString().Trim(); //父节点Id
objqa_AnswerVerEN.VoteCount = objRow[conqa_AnswerVer.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conqa_AnswerVer.VoteCount].ToString().Trim()); //点赞计数
objqa_AnswerVerEN.IsRecommend = TransNullToBool(objRow[conqa_AnswerVer.IsRecommend].ToString().Trim()); //是否推荐
objqa_AnswerVerEN.TopicId = objRow[conqa_AnswerVer.TopicId] == DBNull.Value ? null : objRow[conqa_AnswerVer.TopicId].ToString().Trim(); //主题Id
objqa_AnswerVerEN.AnswerTypeId = objRow[conqa_AnswerVer.AnswerTypeId] == DBNull.Value ? null : objRow[conqa_AnswerVer.AnswerTypeId].ToString().Trim(); //答案类型ID
objqa_AnswerVerEN.IsSubmit = TransNullToBool(objRow[conqa_AnswerVer.IsSubmit].ToString().Trim()); //是否提交
objqa_AnswerVerEN.UpdUser = objRow[conqa_AnswerVer.UpdUser] == DBNull.Value ? null : objRow[conqa_AnswerVer.UpdUser].ToString().Trim(); //修改人
objqa_AnswerVerEN.UpdDate = objRow[conqa_AnswerVer.UpdDate] == DBNull.Value ? null : objRow[conqa_AnswerVer.UpdDate].ToString().Trim(); //修改日期
objqa_AnswerVerEN.Memo = objRow[conqa_AnswerVer.Memo] == DBNull.Value ? null : objRow[conqa_AnswerVer.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsqa_AnswerVerDA: GetObjByDataRowqa_AnswerVer)", objException.Message));
}
objqa_AnswerVerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objqa_AnswerVerEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsqa_AnswerVerEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsqa_AnswerVerEN objqa_AnswerVerEN = new clsqa_AnswerVerEN();
try
{
objqa_AnswerVerEN.AnswerVId = TransNullToInt(objRow[conqa_AnswerVer.AnswerVId].ToString().Trim()); //问答历史主键
objqa_AnswerVerEN.AnswerId = objRow[conqa_AnswerVer.AnswerId].ToString().Trim(); //回答Id
objqa_AnswerVerEN.QuestionsId = objRow[conqa_AnswerVer.QuestionsId].ToString().Trim(); //提问Id
objqa_AnswerVerEN.AnswerContent = objRow[conqa_AnswerVer.AnswerContent] == DBNull.Value ? null : objRow[conqa_AnswerVer.AnswerContent].ToString().Trim(); //答案内容
objqa_AnswerVerEN.Score = objRow[conqa_AnswerVer.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conqa_AnswerVer.Score].ToString().Trim()); //评分
objqa_AnswerVerEN.ScoreType = objRow[conqa_AnswerVer.ScoreType] == DBNull.Value ? null : objRow[conqa_AnswerVer.ScoreType].ToString().Trim(); //评分类型
objqa_AnswerVerEN.IsRight = TransNullToBool(objRow[conqa_AnswerVer.IsRight].ToString().Trim()); //是否正确
objqa_AnswerVerEN.ParentId = objRow[conqa_AnswerVer.ParentId] == DBNull.Value ? null : objRow[conqa_AnswerVer.ParentId].ToString().Trim(); //父节点Id
objqa_AnswerVerEN.VoteCount = objRow[conqa_AnswerVer.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conqa_AnswerVer.VoteCount].ToString().Trim()); //点赞计数
objqa_AnswerVerEN.IsRecommend = TransNullToBool(objRow[conqa_AnswerVer.IsRecommend].ToString().Trim()); //是否推荐
objqa_AnswerVerEN.TopicId = objRow[conqa_AnswerVer.TopicId] == DBNull.Value ? null : objRow[conqa_AnswerVer.TopicId].ToString().Trim(); //主题Id
objqa_AnswerVerEN.AnswerTypeId = objRow[conqa_AnswerVer.AnswerTypeId] == DBNull.Value ? null : objRow[conqa_AnswerVer.AnswerTypeId].ToString().Trim(); //答案类型ID
objqa_AnswerVerEN.IsSubmit = TransNullToBool(objRow[conqa_AnswerVer.IsSubmit].ToString().Trim()); //是否提交
objqa_AnswerVerEN.UpdUser = objRow[conqa_AnswerVer.UpdUser] == DBNull.Value ? null : objRow[conqa_AnswerVer.UpdUser].ToString().Trim(); //修改人
objqa_AnswerVerEN.UpdDate = objRow[conqa_AnswerVer.UpdDate] == DBNull.Value ? null : objRow[conqa_AnswerVer.UpdDate].ToString().Trim(); //修改日期
objqa_AnswerVerEN.Memo = objRow[conqa_AnswerVer.Memo] == DBNull.Value ? null : objRow[conqa_AnswerVer.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsqa_AnswerVerDA: GetObjByDataRow)", objException.Message));
}
objqa_AnswerVerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objqa_AnswerVerEN;
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
objSQL = clsqa_AnswerVerDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsqa_AnswerVerEN._CurrTabName, conqa_AnswerVer.AnswerVId, 8, "");
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
objSQL = clsqa_AnswerVerDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsqa_AnswerVerEN._CurrTabName, conqa_AnswerVer.AnswerVId, 8, strPrefix);
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
 objSQL = clsqa_AnswerVerDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select AnswerVId from qa_AnswerVer where " + strCondition;
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
 objSQL = clsqa_AnswerVerDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select AnswerVId from qa_AnswerVer where " + strCondition;
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
 /// <param name = "lngAnswerVId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngAnswerVId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_AnswerVerDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("qa_AnswerVer", "AnswerVId = " + ""+ lngAnswerVId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsqa_AnswerVerDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_AnswerVerDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("qa_AnswerVer", strCondition))
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
objSQL = clsqa_AnswerVerDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("qa_AnswerVer");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsqa_AnswerVerEN objqa_AnswerVerEN)
 {
 if (objqa_AnswerVerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objqa_AnswerVerEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_AnswerVerDA.GetSpecSQLObj();
strSQL = "Select * from qa_AnswerVer where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "qa_AnswerVer");
objRow = objDS.Tables["qa_AnswerVer"].NewRow();
objRow[conqa_AnswerVer.AnswerId] = objqa_AnswerVerEN.AnswerId; //回答Id
objRow[conqa_AnswerVer.QuestionsId] = objqa_AnswerVerEN.QuestionsId; //提问Id
 if (objqa_AnswerVerEN.AnswerContent !=  "")
 {
objRow[conqa_AnswerVer.AnswerContent] = objqa_AnswerVerEN.AnswerContent; //答案内容
 }
objRow[conqa_AnswerVer.Score] = objqa_AnswerVerEN.Score; //评分
 if (objqa_AnswerVerEN.ScoreType !=  "")
 {
objRow[conqa_AnswerVer.ScoreType] = objqa_AnswerVerEN.ScoreType; //评分类型
 }
objRow[conqa_AnswerVer.IsRight] = objqa_AnswerVerEN.IsRight; //是否正确
 if (objqa_AnswerVerEN.ParentId !=  "")
 {
objRow[conqa_AnswerVer.ParentId] = objqa_AnswerVerEN.ParentId; //父节点Id
 }
objRow[conqa_AnswerVer.VoteCount] = objqa_AnswerVerEN.VoteCount; //点赞计数
objRow[conqa_AnswerVer.IsRecommend] = objqa_AnswerVerEN.IsRecommend; //是否推荐
 if (objqa_AnswerVerEN.TopicId !=  "")
 {
objRow[conqa_AnswerVer.TopicId] = objqa_AnswerVerEN.TopicId; //主题Id
 }
 if (objqa_AnswerVerEN.AnswerTypeId !=  "")
 {
objRow[conqa_AnswerVer.AnswerTypeId] = objqa_AnswerVerEN.AnswerTypeId; //答案类型ID
 }
objRow[conqa_AnswerVer.IsSubmit] = objqa_AnswerVerEN.IsSubmit; //是否提交
 if (objqa_AnswerVerEN.UpdUser !=  "")
 {
objRow[conqa_AnswerVer.UpdUser] = objqa_AnswerVerEN.UpdUser; //修改人
 }
 if (objqa_AnswerVerEN.UpdDate !=  "")
 {
objRow[conqa_AnswerVer.UpdDate] = objqa_AnswerVerEN.UpdDate; //修改日期
 }
 if (objqa_AnswerVerEN.Memo !=  "")
 {
objRow[conqa_AnswerVer.Memo] = objqa_AnswerVerEN.Memo; //备注
 }
objDS.Tables[clsqa_AnswerVerEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsqa_AnswerVerEN._CurrTabName);
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
 /// <param name = "objqa_AnswerVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsqa_AnswerVerEN objqa_AnswerVerEN)
{
 if (objqa_AnswerVerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objqa_AnswerVerEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objqa_AnswerVerEN.AnswerId !=  null)
 {
 arrFieldListForInsert.Add(conqa_AnswerVer.AnswerId);
 var strAnswerId = objqa_AnswerVerEN.AnswerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerId + "'");
 }
 
 if (objqa_AnswerVerEN.QuestionsId !=  null)
 {
 arrFieldListForInsert.Add(conqa_AnswerVer.QuestionsId);
 var strQuestionsId = objqa_AnswerVerEN.QuestionsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionsId + "'");
 }
 
 if (objqa_AnswerVerEN.AnswerContent !=  null)
 {
 arrFieldListForInsert.Add(conqa_AnswerVer.AnswerContent);
 var strAnswerContent = objqa_AnswerVerEN.AnswerContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerContent + "'");
 }
 
 if (objqa_AnswerVerEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conqa_AnswerVer.Score);
 arrValueListForInsert.Add(objqa_AnswerVerEN.Score.ToString());
 }
 
 if (objqa_AnswerVerEN.ScoreType !=  null)
 {
 arrFieldListForInsert.Add(conqa_AnswerVer.ScoreType);
 var strScoreType = objqa_AnswerVerEN.ScoreType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strScoreType + "'");
 }
 
 arrFieldListForInsert.Add(conqa_AnswerVer.IsRight);
 arrValueListForInsert.Add("'" + (objqa_AnswerVerEN.IsRight  ==  false ? "0" : "1") + "'");
 
 if (objqa_AnswerVerEN.ParentId !=  null)
 {
 arrFieldListForInsert.Add(conqa_AnswerVer.ParentId);
 var strParentId = objqa_AnswerVerEN.ParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParentId + "'");
 }
 
 if (objqa_AnswerVerEN.VoteCount !=  null)
 {
 arrFieldListForInsert.Add(conqa_AnswerVer.VoteCount);
 arrValueListForInsert.Add(objqa_AnswerVerEN.VoteCount.ToString());
 }
 
 arrFieldListForInsert.Add(conqa_AnswerVer.IsRecommend);
 arrValueListForInsert.Add("'" + (objqa_AnswerVerEN.IsRecommend  ==  false ? "0" : "1") + "'");
 
 if (objqa_AnswerVerEN.TopicId !=  null)
 {
 arrFieldListForInsert.Add(conqa_AnswerVer.TopicId);
 var strTopicId = objqa_AnswerVerEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicId + "'");
 }
 
 if (objqa_AnswerVerEN.AnswerTypeId !=  null)
 {
 arrFieldListForInsert.Add(conqa_AnswerVer.AnswerTypeId);
 var strAnswerTypeId = objqa_AnswerVerEN.AnswerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conqa_AnswerVer.IsSubmit);
 arrValueListForInsert.Add("'" + (objqa_AnswerVerEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objqa_AnswerVerEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conqa_AnswerVer.UpdUser);
 var strUpdUser = objqa_AnswerVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objqa_AnswerVerEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conqa_AnswerVer.UpdDate);
 var strUpdDate = objqa_AnswerVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objqa_AnswerVerEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conqa_AnswerVer.Memo);
 var strMemo = objqa_AnswerVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into qa_AnswerVer");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_AnswerVerDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objqa_AnswerVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsqa_AnswerVerEN objqa_AnswerVerEN)
{
 if (objqa_AnswerVerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objqa_AnswerVerEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objqa_AnswerVerEN.AnswerId !=  null)
 {
 arrFieldListForInsert.Add(conqa_AnswerVer.AnswerId);
 var strAnswerId = objqa_AnswerVerEN.AnswerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerId + "'");
 }
 
 if (objqa_AnswerVerEN.QuestionsId !=  null)
 {
 arrFieldListForInsert.Add(conqa_AnswerVer.QuestionsId);
 var strQuestionsId = objqa_AnswerVerEN.QuestionsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionsId + "'");
 }
 
 if (objqa_AnswerVerEN.AnswerContent !=  null)
 {
 arrFieldListForInsert.Add(conqa_AnswerVer.AnswerContent);
 var strAnswerContent = objqa_AnswerVerEN.AnswerContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerContent + "'");
 }
 
 if (objqa_AnswerVerEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conqa_AnswerVer.Score);
 arrValueListForInsert.Add(objqa_AnswerVerEN.Score.ToString());
 }
 
 if (objqa_AnswerVerEN.ScoreType !=  null)
 {
 arrFieldListForInsert.Add(conqa_AnswerVer.ScoreType);
 var strScoreType = objqa_AnswerVerEN.ScoreType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strScoreType + "'");
 }
 
 arrFieldListForInsert.Add(conqa_AnswerVer.IsRight);
 arrValueListForInsert.Add("'" + (objqa_AnswerVerEN.IsRight  ==  false ? "0" : "1") + "'");
 
 if (objqa_AnswerVerEN.ParentId !=  null)
 {
 arrFieldListForInsert.Add(conqa_AnswerVer.ParentId);
 var strParentId = objqa_AnswerVerEN.ParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParentId + "'");
 }
 
 if (objqa_AnswerVerEN.VoteCount !=  null)
 {
 arrFieldListForInsert.Add(conqa_AnswerVer.VoteCount);
 arrValueListForInsert.Add(objqa_AnswerVerEN.VoteCount.ToString());
 }
 
 arrFieldListForInsert.Add(conqa_AnswerVer.IsRecommend);
 arrValueListForInsert.Add("'" + (objqa_AnswerVerEN.IsRecommend  ==  false ? "0" : "1") + "'");
 
 if (objqa_AnswerVerEN.TopicId !=  null)
 {
 arrFieldListForInsert.Add(conqa_AnswerVer.TopicId);
 var strTopicId = objqa_AnswerVerEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicId + "'");
 }
 
 if (objqa_AnswerVerEN.AnswerTypeId !=  null)
 {
 arrFieldListForInsert.Add(conqa_AnswerVer.AnswerTypeId);
 var strAnswerTypeId = objqa_AnswerVerEN.AnswerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conqa_AnswerVer.IsSubmit);
 arrValueListForInsert.Add("'" + (objqa_AnswerVerEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objqa_AnswerVerEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conqa_AnswerVer.UpdUser);
 var strUpdUser = objqa_AnswerVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objqa_AnswerVerEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conqa_AnswerVer.UpdDate);
 var strUpdDate = objqa_AnswerVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objqa_AnswerVerEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conqa_AnswerVer.Memo);
 var strMemo = objqa_AnswerVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into qa_AnswerVer");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_AnswerVerDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objqa_AnswerVerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsqa_AnswerVerEN objqa_AnswerVerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objqa_AnswerVerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objqa_AnswerVerEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objqa_AnswerVerEN.AnswerId !=  null)
 {
 arrFieldListForInsert.Add(conqa_AnswerVer.AnswerId);
 var strAnswerId = objqa_AnswerVerEN.AnswerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerId + "'");
 }
 
 if (objqa_AnswerVerEN.QuestionsId !=  null)
 {
 arrFieldListForInsert.Add(conqa_AnswerVer.QuestionsId);
 var strQuestionsId = objqa_AnswerVerEN.QuestionsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionsId + "'");
 }
 
 if (objqa_AnswerVerEN.AnswerContent !=  null)
 {
 arrFieldListForInsert.Add(conqa_AnswerVer.AnswerContent);
 var strAnswerContent = objqa_AnswerVerEN.AnswerContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerContent + "'");
 }
 
 if (objqa_AnswerVerEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conqa_AnswerVer.Score);
 arrValueListForInsert.Add(objqa_AnswerVerEN.Score.ToString());
 }
 
 if (objqa_AnswerVerEN.ScoreType !=  null)
 {
 arrFieldListForInsert.Add(conqa_AnswerVer.ScoreType);
 var strScoreType = objqa_AnswerVerEN.ScoreType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strScoreType + "'");
 }
 
 arrFieldListForInsert.Add(conqa_AnswerVer.IsRight);
 arrValueListForInsert.Add("'" + (objqa_AnswerVerEN.IsRight  ==  false ? "0" : "1") + "'");
 
 if (objqa_AnswerVerEN.ParentId !=  null)
 {
 arrFieldListForInsert.Add(conqa_AnswerVer.ParentId);
 var strParentId = objqa_AnswerVerEN.ParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParentId + "'");
 }
 
 if (objqa_AnswerVerEN.VoteCount !=  null)
 {
 arrFieldListForInsert.Add(conqa_AnswerVer.VoteCount);
 arrValueListForInsert.Add(objqa_AnswerVerEN.VoteCount.ToString());
 }
 
 arrFieldListForInsert.Add(conqa_AnswerVer.IsRecommend);
 arrValueListForInsert.Add("'" + (objqa_AnswerVerEN.IsRecommend  ==  false ? "0" : "1") + "'");
 
 if (objqa_AnswerVerEN.TopicId !=  null)
 {
 arrFieldListForInsert.Add(conqa_AnswerVer.TopicId);
 var strTopicId = objqa_AnswerVerEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicId + "'");
 }
 
 if (objqa_AnswerVerEN.AnswerTypeId !=  null)
 {
 arrFieldListForInsert.Add(conqa_AnswerVer.AnswerTypeId);
 var strAnswerTypeId = objqa_AnswerVerEN.AnswerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conqa_AnswerVer.IsSubmit);
 arrValueListForInsert.Add("'" + (objqa_AnswerVerEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objqa_AnswerVerEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conqa_AnswerVer.UpdUser);
 var strUpdUser = objqa_AnswerVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objqa_AnswerVerEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conqa_AnswerVer.UpdDate);
 var strUpdDate = objqa_AnswerVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objqa_AnswerVerEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conqa_AnswerVer.Memo);
 var strMemo = objqa_AnswerVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into qa_AnswerVer");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_AnswerVerDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objqa_AnswerVerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsqa_AnswerVerEN objqa_AnswerVerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objqa_AnswerVerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objqa_AnswerVerEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objqa_AnswerVerEN.AnswerId !=  null)
 {
 arrFieldListForInsert.Add(conqa_AnswerVer.AnswerId);
 var strAnswerId = objqa_AnswerVerEN.AnswerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerId + "'");
 }
 
 if (objqa_AnswerVerEN.QuestionsId !=  null)
 {
 arrFieldListForInsert.Add(conqa_AnswerVer.QuestionsId);
 var strQuestionsId = objqa_AnswerVerEN.QuestionsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionsId + "'");
 }
 
 if (objqa_AnswerVerEN.AnswerContent !=  null)
 {
 arrFieldListForInsert.Add(conqa_AnswerVer.AnswerContent);
 var strAnswerContent = objqa_AnswerVerEN.AnswerContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerContent + "'");
 }
 
 if (objqa_AnswerVerEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conqa_AnswerVer.Score);
 arrValueListForInsert.Add(objqa_AnswerVerEN.Score.ToString());
 }
 
 if (objqa_AnswerVerEN.ScoreType !=  null)
 {
 arrFieldListForInsert.Add(conqa_AnswerVer.ScoreType);
 var strScoreType = objqa_AnswerVerEN.ScoreType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strScoreType + "'");
 }
 
 arrFieldListForInsert.Add(conqa_AnswerVer.IsRight);
 arrValueListForInsert.Add("'" + (objqa_AnswerVerEN.IsRight  ==  false ? "0" : "1") + "'");
 
 if (objqa_AnswerVerEN.ParentId !=  null)
 {
 arrFieldListForInsert.Add(conqa_AnswerVer.ParentId);
 var strParentId = objqa_AnswerVerEN.ParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParentId + "'");
 }
 
 if (objqa_AnswerVerEN.VoteCount !=  null)
 {
 arrFieldListForInsert.Add(conqa_AnswerVer.VoteCount);
 arrValueListForInsert.Add(objqa_AnswerVerEN.VoteCount.ToString());
 }
 
 arrFieldListForInsert.Add(conqa_AnswerVer.IsRecommend);
 arrValueListForInsert.Add("'" + (objqa_AnswerVerEN.IsRecommend  ==  false ? "0" : "1") + "'");
 
 if (objqa_AnswerVerEN.TopicId !=  null)
 {
 arrFieldListForInsert.Add(conqa_AnswerVer.TopicId);
 var strTopicId = objqa_AnswerVerEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicId + "'");
 }
 
 if (objqa_AnswerVerEN.AnswerTypeId !=  null)
 {
 arrFieldListForInsert.Add(conqa_AnswerVer.AnswerTypeId);
 var strAnswerTypeId = objqa_AnswerVerEN.AnswerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conqa_AnswerVer.IsSubmit);
 arrValueListForInsert.Add("'" + (objqa_AnswerVerEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objqa_AnswerVerEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conqa_AnswerVer.UpdUser);
 var strUpdUser = objqa_AnswerVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objqa_AnswerVerEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conqa_AnswerVer.UpdDate);
 var strUpdDate = objqa_AnswerVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objqa_AnswerVerEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conqa_AnswerVer.Memo);
 var strMemo = objqa_AnswerVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into qa_AnswerVer");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_AnswerVerDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewqa_AnswerVers(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_AnswerVerDA.GetSpecSQLObj();
strSQL = "Select * from qa_AnswerVer where AnswerVId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "qa_AnswerVer");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngAnswerVId = TransNullToInt(oRow[conqa_AnswerVer.AnswerVId].ToString().Trim());
if (IsExist(lngAnswerVId))
{
 string strResult = "关键字变量值为:" + string.Format("AnswerVId = {0}", lngAnswerVId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsqa_AnswerVerEN._CurrTabName ].NewRow();
objRow[conqa_AnswerVer.AnswerId] = oRow[conqa_AnswerVer.AnswerId].ToString().Trim(); //回答Id
objRow[conqa_AnswerVer.QuestionsId] = oRow[conqa_AnswerVer.QuestionsId].ToString().Trim(); //提问Id
objRow[conqa_AnswerVer.AnswerContent] = oRow[conqa_AnswerVer.AnswerContent].ToString().Trim(); //答案内容
objRow[conqa_AnswerVer.Score] = oRow[conqa_AnswerVer.Score].ToString().Trim(); //评分
objRow[conqa_AnswerVer.ScoreType] = oRow[conqa_AnswerVer.ScoreType].ToString().Trim(); //评分类型
objRow[conqa_AnswerVer.IsRight] = oRow[conqa_AnswerVer.IsRight].ToString().Trim(); //是否正确
objRow[conqa_AnswerVer.ParentId] = oRow[conqa_AnswerVer.ParentId].ToString().Trim(); //父节点Id
objRow[conqa_AnswerVer.VoteCount] = oRow[conqa_AnswerVer.VoteCount].ToString().Trim(); //点赞计数
objRow[conqa_AnswerVer.IsRecommend] = oRow[conqa_AnswerVer.IsRecommend].ToString().Trim(); //是否推荐
objRow[conqa_AnswerVer.TopicId] = oRow[conqa_AnswerVer.TopicId].ToString().Trim(); //主题Id
objRow[conqa_AnswerVer.AnswerTypeId] = oRow[conqa_AnswerVer.AnswerTypeId].ToString().Trim(); //答案类型ID
objRow[conqa_AnswerVer.IsSubmit] = oRow[conqa_AnswerVer.IsSubmit].ToString().Trim(); //是否提交
objRow[conqa_AnswerVer.UpdUser] = oRow[conqa_AnswerVer.UpdUser].ToString().Trim(); //修改人
objRow[conqa_AnswerVer.UpdDate] = oRow[conqa_AnswerVer.UpdDate].ToString().Trim(); //修改日期
objRow[conqa_AnswerVer.Memo] = oRow[conqa_AnswerVer.Memo].ToString().Trim(); //备注
 objDS.Tables[clsqa_AnswerVerEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsqa_AnswerVerEN._CurrTabName);
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
 /// <param name = "objqa_AnswerVerEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsqa_AnswerVerEN objqa_AnswerVerEN)
{
 if (objqa_AnswerVerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objqa_AnswerVerEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_AnswerVerDA.GetSpecSQLObj();
strSQL = "Select * from qa_AnswerVer where AnswerVId = " + ""+ objqa_AnswerVerEN.AnswerVId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsqa_AnswerVerEN._CurrTabName);
if (objDS.Tables[clsqa_AnswerVerEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:AnswerVId = " + ""+ objqa_AnswerVerEN.AnswerVId+"");
return false;
}
objRow = objDS.Tables[clsqa_AnswerVerEN._CurrTabName].Rows[0];
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.AnswerId))
 {
objRow[conqa_AnswerVer.AnswerId] = objqa_AnswerVerEN.AnswerId; //回答Id
 }
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.QuestionsId))
 {
objRow[conqa_AnswerVer.QuestionsId] = objqa_AnswerVerEN.QuestionsId; //提问Id
 }
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.AnswerContent))
 {
objRow[conqa_AnswerVer.AnswerContent] = objqa_AnswerVerEN.AnswerContent; //答案内容
 }
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.Score))
 {
objRow[conqa_AnswerVer.Score] = objqa_AnswerVerEN.Score; //评分
 }
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.ScoreType))
 {
objRow[conqa_AnswerVer.ScoreType] = objqa_AnswerVerEN.ScoreType; //评分类型
 }
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.IsRight))
 {
objRow[conqa_AnswerVer.IsRight] = objqa_AnswerVerEN.IsRight; //是否正确
 }
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.ParentId))
 {
objRow[conqa_AnswerVer.ParentId] = objqa_AnswerVerEN.ParentId; //父节点Id
 }
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.VoteCount))
 {
objRow[conqa_AnswerVer.VoteCount] = objqa_AnswerVerEN.VoteCount; //点赞计数
 }
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.IsRecommend))
 {
objRow[conqa_AnswerVer.IsRecommend] = objqa_AnswerVerEN.IsRecommend; //是否推荐
 }
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.TopicId))
 {
objRow[conqa_AnswerVer.TopicId] = objqa_AnswerVerEN.TopicId; //主题Id
 }
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.AnswerTypeId))
 {
objRow[conqa_AnswerVer.AnswerTypeId] = objqa_AnswerVerEN.AnswerTypeId; //答案类型ID
 }
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.IsSubmit))
 {
objRow[conqa_AnswerVer.IsSubmit] = objqa_AnswerVerEN.IsSubmit; //是否提交
 }
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.UpdUser))
 {
objRow[conqa_AnswerVer.UpdUser] = objqa_AnswerVerEN.UpdUser; //修改人
 }
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.UpdDate))
 {
objRow[conqa_AnswerVer.UpdDate] = objqa_AnswerVerEN.UpdDate; //修改日期
 }
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.Memo))
 {
objRow[conqa_AnswerVer.Memo] = objqa_AnswerVerEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsqa_AnswerVerEN._CurrTabName);
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
 /// <param name = "objqa_AnswerVerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsqa_AnswerVerEN objqa_AnswerVerEN)
{
 if (objqa_AnswerVerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objqa_AnswerVerEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_AnswerVerDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update qa_AnswerVer Set ");
 
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.AnswerId))
 {
 if (objqa_AnswerVerEN.AnswerId !=  null)
 {
 var strAnswerId = objqa_AnswerVerEN.AnswerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerId, conqa_AnswerVer.AnswerId); //回答Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_AnswerVer.AnswerId); //回答Id
 }
 }
 
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.QuestionsId))
 {
 if (objqa_AnswerVerEN.QuestionsId !=  null)
 {
 var strQuestionsId = objqa_AnswerVerEN.QuestionsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionsId, conqa_AnswerVer.QuestionsId); //提问Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_AnswerVer.QuestionsId); //提问Id
 }
 }
 
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.AnswerContent))
 {
 if (objqa_AnswerVerEN.AnswerContent !=  null)
 {
 var strAnswerContent = objqa_AnswerVerEN.AnswerContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerContent, conqa_AnswerVer.AnswerContent); //答案内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_AnswerVer.AnswerContent); //答案内容
 }
 }
 
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.Score))
 {
 if (objqa_AnswerVerEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objqa_AnswerVerEN.Score, conqa_AnswerVer.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_AnswerVer.Score); //评分
 }
 }
 
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.ScoreType))
 {
 if (objqa_AnswerVerEN.ScoreType !=  null)
 {
 var strScoreType = objqa_AnswerVerEN.ScoreType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strScoreType, conqa_AnswerVer.ScoreType); //评分类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_AnswerVer.ScoreType); //评分类型
 }
 }
 
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.IsRight))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objqa_AnswerVerEN.IsRight == true?"1":"0", conqa_AnswerVer.IsRight); //是否正确
 }
 
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.ParentId))
 {
 if (objqa_AnswerVerEN.ParentId !=  null)
 {
 var strParentId = objqa_AnswerVerEN.ParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParentId, conqa_AnswerVer.ParentId); //父节点Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_AnswerVer.ParentId); //父节点Id
 }
 }
 
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.VoteCount))
 {
 if (objqa_AnswerVerEN.VoteCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objqa_AnswerVerEN.VoteCount, conqa_AnswerVer.VoteCount); //点赞计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_AnswerVer.VoteCount); //点赞计数
 }
 }
 
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.IsRecommend))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objqa_AnswerVerEN.IsRecommend == true?"1":"0", conqa_AnswerVer.IsRecommend); //是否推荐
 }
 
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.TopicId))
 {
 if (objqa_AnswerVerEN.TopicId !=  null)
 {
 var strTopicId = objqa_AnswerVerEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTopicId, conqa_AnswerVer.TopicId); //主题Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_AnswerVer.TopicId); //主题Id
 }
 }
 
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.AnswerTypeId))
 {
 if (objqa_AnswerVerEN.AnswerTypeId !=  null)
 {
 var strAnswerTypeId = objqa_AnswerVerEN.AnswerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerTypeId, conqa_AnswerVer.AnswerTypeId); //答案类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_AnswerVer.AnswerTypeId); //答案类型ID
 }
 }
 
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objqa_AnswerVerEN.IsSubmit == true?"1":"0", conqa_AnswerVer.IsSubmit); //是否提交
 }
 
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.UpdUser))
 {
 if (objqa_AnswerVerEN.UpdUser !=  null)
 {
 var strUpdUser = objqa_AnswerVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conqa_AnswerVer.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_AnswerVer.UpdUser); //修改人
 }
 }
 
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.UpdDate))
 {
 if (objqa_AnswerVerEN.UpdDate !=  null)
 {
 var strUpdDate = objqa_AnswerVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conqa_AnswerVer.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_AnswerVer.UpdDate); //修改日期
 }
 }
 
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.Memo))
 {
 if (objqa_AnswerVerEN.Memo !=  null)
 {
 var strMemo = objqa_AnswerVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conqa_AnswerVer.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_AnswerVer.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where AnswerVId = {0}", objqa_AnswerVerEN.AnswerVId); 
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
 /// <param name = "objqa_AnswerVerEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsqa_AnswerVerEN objqa_AnswerVerEN, string strCondition)
{
 if (objqa_AnswerVerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objqa_AnswerVerEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_AnswerVerDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update qa_AnswerVer Set ");
 
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.AnswerId))
 {
 if (objqa_AnswerVerEN.AnswerId !=  null)
 {
 var strAnswerId = objqa_AnswerVerEN.AnswerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerId = '{0}',", strAnswerId); //回答Id
 }
 else
 {
 sbSQL.Append(" AnswerId = null,"); //回答Id
 }
 }
 
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.QuestionsId))
 {
 if (objqa_AnswerVerEN.QuestionsId !=  null)
 {
 var strQuestionsId = objqa_AnswerVerEN.QuestionsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionsId = '{0}',", strQuestionsId); //提问Id
 }
 else
 {
 sbSQL.Append(" QuestionsId = null,"); //提问Id
 }
 }
 
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.AnswerContent))
 {
 if (objqa_AnswerVerEN.AnswerContent !=  null)
 {
 var strAnswerContent = objqa_AnswerVerEN.AnswerContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerContent = '{0}',", strAnswerContent); //答案内容
 }
 else
 {
 sbSQL.Append(" AnswerContent = null,"); //答案内容
 }
 }
 
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.Score))
 {
 if (objqa_AnswerVerEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objqa_AnswerVerEN.Score, conqa_AnswerVer.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_AnswerVer.Score); //评分
 }
 }
 
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.ScoreType))
 {
 if (objqa_AnswerVerEN.ScoreType !=  null)
 {
 var strScoreType = objqa_AnswerVerEN.ScoreType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ScoreType = '{0}',", strScoreType); //评分类型
 }
 else
 {
 sbSQL.Append(" ScoreType = null,"); //评分类型
 }
 }
 
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.IsRight))
 {
 sbSQL.AppendFormat(" IsRight = '{0}',", objqa_AnswerVerEN.IsRight == true?"1":"0"); //是否正确
 }
 
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.ParentId))
 {
 if (objqa_AnswerVerEN.ParentId !=  null)
 {
 var strParentId = objqa_AnswerVerEN.ParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParentId = '{0}',", strParentId); //父节点Id
 }
 else
 {
 sbSQL.Append(" ParentId = null,"); //父节点Id
 }
 }
 
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.VoteCount))
 {
 if (objqa_AnswerVerEN.VoteCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objqa_AnswerVerEN.VoteCount, conqa_AnswerVer.VoteCount); //点赞计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_AnswerVer.VoteCount); //点赞计数
 }
 }
 
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.IsRecommend))
 {
 sbSQL.AppendFormat(" IsRecommend = '{0}',", objqa_AnswerVerEN.IsRecommend == true?"1":"0"); //是否推荐
 }
 
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.TopicId))
 {
 if (objqa_AnswerVerEN.TopicId !=  null)
 {
 var strTopicId = objqa_AnswerVerEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TopicId = '{0}',", strTopicId); //主题Id
 }
 else
 {
 sbSQL.Append(" TopicId = null,"); //主题Id
 }
 }
 
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.AnswerTypeId))
 {
 if (objqa_AnswerVerEN.AnswerTypeId !=  null)
 {
 var strAnswerTypeId = objqa_AnswerVerEN.AnswerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerTypeId = '{0}',", strAnswerTypeId); //答案类型ID
 }
 else
 {
 sbSQL.Append(" AnswerTypeId = null,"); //答案类型ID
 }
 }
 
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objqa_AnswerVerEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.UpdUser))
 {
 if (objqa_AnswerVerEN.UpdUser !=  null)
 {
 var strUpdUser = objqa_AnswerVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.UpdDate))
 {
 if (objqa_AnswerVerEN.UpdDate !=  null)
 {
 var strUpdDate = objqa_AnswerVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.Memo))
 {
 if (objqa_AnswerVerEN.Memo !=  null)
 {
 var strMemo = objqa_AnswerVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objqa_AnswerVerEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsqa_AnswerVerEN objqa_AnswerVerEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objqa_AnswerVerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objqa_AnswerVerEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_AnswerVerDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update qa_AnswerVer Set ");
 
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.AnswerId))
 {
 if (objqa_AnswerVerEN.AnswerId !=  null)
 {
 var strAnswerId = objqa_AnswerVerEN.AnswerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerId = '{0}',", strAnswerId); //回答Id
 }
 else
 {
 sbSQL.Append(" AnswerId = null,"); //回答Id
 }
 }
 
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.QuestionsId))
 {
 if (objqa_AnswerVerEN.QuestionsId !=  null)
 {
 var strQuestionsId = objqa_AnswerVerEN.QuestionsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionsId = '{0}',", strQuestionsId); //提问Id
 }
 else
 {
 sbSQL.Append(" QuestionsId = null,"); //提问Id
 }
 }
 
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.AnswerContent))
 {
 if (objqa_AnswerVerEN.AnswerContent !=  null)
 {
 var strAnswerContent = objqa_AnswerVerEN.AnswerContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerContent = '{0}',", strAnswerContent); //答案内容
 }
 else
 {
 sbSQL.Append(" AnswerContent = null,"); //答案内容
 }
 }
 
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.Score))
 {
 if (objqa_AnswerVerEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objqa_AnswerVerEN.Score, conqa_AnswerVer.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_AnswerVer.Score); //评分
 }
 }
 
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.ScoreType))
 {
 if (objqa_AnswerVerEN.ScoreType !=  null)
 {
 var strScoreType = objqa_AnswerVerEN.ScoreType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ScoreType = '{0}',", strScoreType); //评分类型
 }
 else
 {
 sbSQL.Append(" ScoreType = null,"); //评分类型
 }
 }
 
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.IsRight))
 {
 sbSQL.AppendFormat(" IsRight = '{0}',", objqa_AnswerVerEN.IsRight == true?"1":"0"); //是否正确
 }
 
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.ParentId))
 {
 if (objqa_AnswerVerEN.ParentId !=  null)
 {
 var strParentId = objqa_AnswerVerEN.ParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParentId = '{0}',", strParentId); //父节点Id
 }
 else
 {
 sbSQL.Append(" ParentId = null,"); //父节点Id
 }
 }
 
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.VoteCount))
 {
 if (objqa_AnswerVerEN.VoteCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objqa_AnswerVerEN.VoteCount, conqa_AnswerVer.VoteCount); //点赞计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_AnswerVer.VoteCount); //点赞计数
 }
 }
 
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.IsRecommend))
 {
 sbSQL.AppendFormat(" IsRecommend = '{0}',", objqa_AnswerVerEN.IsRecommend == true?"1":"0"); //是否推荐
 }
 
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.TopicId))
 {
 if (objqa_AnswerVerEN.TopicId !=  null)
 {
 var strTopicId = objqa_AnswerVerEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TopicId = '{0}',", strTopicId); //主题Id
 }
 else
 {
 sbSQL.Append(" TopicId = null,"); //主题Id
 }
 }
 
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.AnswerTypeId))
 {
 if (objqa_AnswerVerEN.AnswerTypeId !=  null)
 {
 var strAnswerTypeId = objqa_AnswerVerEN.AnswerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerTypeId = '{0}',", strAnswerTypeId); //答案类型ID
 }
 else
 {
 sbSQL.Append(" AnswerTypeId = null,"); //答案类型ID
 }
 }
 
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objqa_AnswerVerEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.UpdUser))
 {
 if (objqa_AnswerVerEN.UpdUser !=  null)
 {
 var strUpdUser = objqa_AnswerVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.UpdDate))
 {
 if (objqa_AnswerVerEN.UpdDate !=  null)
 {
 var strUpdDate = objqa_AnswerVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.Memo))
 {
 if (objqa_AnswerVerEN.Memo !=  null)
 {
 var strMemo = objqa_AnswerVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objqa_AnswerVerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsqa_AnswerVerEN objqa_AnswerVerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objqa_AnswerVerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objqa_AnswerVerEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_AnswerVerDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update qa_AnswerVer Set ");
 
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.AnswerId))
 {
 if (objqa_AnswerVerEN.AnswerId !=  null)
 {
 var strAnswerId = objqa_AnswerVerEN.AnswerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerId, conqa_AnswerVer.AnswerId); //回答Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_AnswerVer.AnswerId); //回答Id
 }
 }
 
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.QuestionsId))
 {
 if (objqa_AnswerVerEN.QuestionsId !=  null)
 {
 var strQuestionsId = objqa_AnswerVerEN.QuestionsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionsId, conqa_AnswerVer.QuestionsId); //提问Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_AnswerVer.QuestionsId); //提问Id
 }
 }
 
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.AnswerContent))
 {
 if (objqa_AnswerVerEN.AnswerContent !=  null)
 {
 var strAnswerContent = objqa_AnswerVerEN.AnswerContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerContent, conqa_AnswerVer.AnswerContent); //答案内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_AnswerVer.AnswerContent); //答案内容
 }
 }
 
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.Score))
 {
 if (objqa_AnswerVerEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objqa_AnswerVerEN.Score, conqa_AnswerVer.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_AnswerVer.Score); //评分
 }
 }
 
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.ScoreType))
 {
 if (objqa_AnswerVerEN.ScoreType !=  null)
 {
 var strScoreType = objqa_AnswerVerEN.ScoreType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strScoreType, conqa_AnswerVer.ScoreType); //评分类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_AnswerVer.ScoreType); //评分类型
 }
 }
 
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.IsRight))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objqa_AnswerVerEN.IsRight == true?"1":"0", conqa_AnswerVer.IsRight); //是否正确
 }
 
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.ParentId))
 {
 if (objqa_AnswerVerEN.ParentId !=  null)
 {
 var strParentId = objqa_AnswerVerEN.ParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParentId, conqa_AnswerVer.ParentId); //父节点Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_AnswerVer.ParentId); //父节点Id
 }
 }
 
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.VoteCount))
 {
 if (objqa_AnswerVerEN.VoteCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objqa_AnswerVerEN.VoteCount, conqa_AnswerVer.VoteCount); //点赞计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_AnswerVer.VoteCount); //点赞计数
 }
 }
 
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.IsRecommend))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objqa_AnswerVerEN.IsRecommend == true?"1":"0", conqa_AnswerVer.IsRecommend); //是否推荐
 }
 
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.TopicId))
 {
 if (objqa_AnswerVerEN.TopicId !=  null)
 {
 var strTopicId = objqa_AnswerVerEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTopicId, conqa_AnswerVer.TopicId); //主题Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_AnswerVer.TopicId); //主题Id
 }
 }
 
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.AnswerTypeId))
 {
 if (objqa_AnswerVerEN.AnswerTypeId !=  null)
 {
 var strAnswerTypeId = objqa_AnswerVerEN.AnswerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerTypeId, conqa_AnswerVer.AnswerTypeId); //答案类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_AnswerVer.AnswerTypeId); //答案类型ID
 }
 }
 
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objqa_AnswerVerEN.IsSubmit == true?"1":"0", conqa_AnswerVer.IsSubmit); //是否提交
 }
 
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.UpdUser))
 {
 if (objqa_AnswerVerEN.UpdUser !=  null)
 {
 var strUpdUser = objqa_AnswerVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conqa_AnswerVer.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_AnswerVer.UpdUser); //修改人
 }
 }
 
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.UpdDate))
 {
 if (objqa_AnswerVerEN.UpdDate !=  null)
 {
 var strUpdDate = objqa_AnswerVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conqa_AnswerVer.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_AnswerVer.UpdDate); //修改日期
 }
 }
 
 if (objqa_AnswerVerEN.IsUpdated(conqa_AnswerVer.Memo))
 {
 if (objqa_AnswerVerEN.Memo !=  null)
 {
 var strMemo = objqa_AnswerVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conqa_AnswerVer.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conqa_AnswerVer.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where AnswerVId = {0}", objqa_AnswerVerEN.AnswerVId); 
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
 /// <param name = "lngAnswerVId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngAnswerVId) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_AnswerVerDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngAnswerVId,
};
 objSQL.ExecSP("qa_AnswerVer_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngAnswerVId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngAnswerVId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_AnswerVerDA.GetSpecSQLObj();
//删除qa_AnswerVer本表中与当前对象有关的记录
strSQL = strSQL + "Delete from qa_AnswerVer where AnswerVId = " + ""+ lngAnswerVId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delqa_AnswerVer(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_AnswerVerDA.GetSpecSQLObj();
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
//删除qa_AnswerVer本表中与当前对象有关的记录
strSQL = strSQL + "Delete from qa_AnswerVer where AnswerVId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngAnswerVId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngAnswerVId) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_AnswerVerDA.GetSpecSQLObj();
//删除qa_AnswerVer本表中与当前对象有关的记录
strSQL = strSQL + "Delete from qa_AnswerVer where AnswerVId = " + ""+ lngAnswerVId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delqa_AnswerVer(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsqa_AnswerVerDA: Delqa_AnswerVer)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_AnswerVerDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from qa_AnswerVer where " + strCondition ;
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
public bool Delqa_AnswerVerWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsqa_AnswerVerDA: Delqa_AnswerVerWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsqa_AnswerVerDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from qa_AnswerVer where " + strCondition ;
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
 /// <param name = "objqa_AnswerVerENS">源对象</param>
 /// <param name = "objqa_AnswerVerENT">目标对象</param>
public void CopyTo(clsqa_AnswerVerEN objqa_AnswerVerENS, clsqa_AnswerVerEN objqa_AnswerVerENT)
{
objqa_AnswerVerENT.AnswerVId = objqa_AnswerVerENS.AnswerVId; //问答历史主键
objqa_AnswerVerENT.AnswerId = objqa_AnswerVerENS.AnswerId; //回答Id
objqa_AnswerVerENT.QuestionsId = objqa_AnswerVerENS.QuestionsId; //提问Id
objqa_AnswerVerENT.AnswerContent = objqa_AnswerVerENS.AnswerContent; //答案内容
objqa_AnswerVerENT.Score = objqa_AnswerVerENS.Score; //评分
objqa_AnswerVerENT.ScoreType = objqa_AnswerVerENS.ScoreType; //评分类型
objqa_AnswerVerENT.IsRight = objqa_AnswerVerENS.IsRight; //是否正确
objqa_AnswerVerENT.ParentId = objqa_AnswerVerENS.ParentId; //父节点Id
objqa_AnswerVerENT.VoteCount = objqa_AnswerVerENS.VoteCount; //点赞计数
objqa_AnswerVerENT.IsRecommend = objqa_AnswerVerENS.IsRecommend; //是否推荐
objqa_AnswerVerENT.TopicId = objqa_AnswerVerENS.TopicId; //主题Id
objqa_AnswerVerENT.AnswerTypeId = objqa_AnswerVerENS.AnswerTypeId; //答案类型ID
objqa_AnswerVerENT.IsSubmit = objqa_AnswerVerENS.IsSubmit; //是否提交
objqa_AnswerVerENT.UpdUser = objqa_AnswerVerENS.UpdUser; //修改人
objqa_AnswerVerENT.UpdDate = objqa_AnswerVerENS.UpdDate; //修改日期
objqa_AnswerVerENT.Memo = objqa_AnswerVerENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsqa_AnswerVerEN objqa_AnswerVerEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objqa_AnswerVerEN.AnswerId, conqa_AnswerVer.AnswerId);
clsCheckSql.CheckFieldNotNull(objqa_AnswerVerEN.QuestionsId, conqa_AnswerVer.QuestionsId);
//检查字段长度
clsCheckSql.CheckFieldLen(objqa_AnswerVerEN.AnswerId, 10, conqa_AnswerVer.AnswerId);
clsCheckSql.CheckFieldLen(objqa_AnswerVerEN.QuestionsId, 8, conqa_AnswerVer.QuestionsId);
clsCheckSql.CheckFieldLen(objqa_AnswerVerEN.ScoreType, 1, conqa_AnswerVer.ScoreType);
clsCheckSql.CheckFieldLen(objqa_AnswerVerEN.ParentId, 10, conqa_AnswerVer.ParentId);
clsCheckSql.CheckFieldLen(objqa_AnswerVerEN.TopicId, 8, conqa_AnswerVer.TopicId);
clsCheckSql.CheckFieldLen(objqa_AnswerVerEN.AnswerTypeId, 2, conqa_AnswerVer.AnswerTypeId);
clsCheckSql.CheckFieldLen(objqa_AnswerVerEN.UpdUser, 20, conqa_AnswerVer.UpdUser);
clsCheckSql.CheckFieldLen(objqa_AnswerVerEN.UpdDate, 20, conqa_AnswerVer.UpdDate);
clsCheckSql.CheckFieldLen(objqa_AnswerVerEN.Memo, 1000, conqa_AnswerVer.Memo);
//检查字段外键固定长度
 objqa_AnswerVerEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsqa_AnswerVerEN objqa_AnswerVerEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objqa_AnswerVerEN.AnswerId, 10, conqa_AnswerVer.AnswerId);
clsCheckSql.CheckFieldLen(objqa_AnswerVerEN.QuestionsId, 8, conqa_AnswerVer.QuestionsId);
clsCheckSql.CheckFieldLen(objqa_AnswerVerEN.ScoreType, 1, conqa_AnswerVer.ScoreType);
clsCheckSql.CheckFieldLen(objqa_AnswerVerEN.ParentId, 10, conqa_AnswerVer.ParentId);
clsCheckSql.CheckFieldLen(objqa_AnswerVerEN.TopicId, 8, conqa_AnswerVer.TopicId);
clsCheckSql.CheckFieldLen(objqa_AnswerVerEN.AnswerTypeId, 2, conqa_AnswerVer.AnswerTypeId);
clsCheckSql.CheckFieldLen(objqa_AnswerVerEN.UpdUser, 20, conqa_AnswerVer.UpdUser);
clsCheckSql.CheckFieldLen(objqa_AnswerVerEN.UpdDate, 20, conqa_AnswerVer.UpdDate);
clsCheckSql.CheckFieldLen(objqa_AnswerVerEN.Memo, 1000, conqa_AnswerVer.Memo);
//检查外键字段长度
 objqa_AnswerVerEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsqa_AnswerVerEN objqa_AnswerVerEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objqa_AnswerVerEN.AnswerId, 10, conqa_AnswerVer.AnswerId);
clsCheckSql.CheckFieldLen(objqa_AnswerVerEN.QuestionsId, 8, conqa_AnswerVer.QuestionsId);
clsCheckSql.CheckFieldLen(objqa_AnswerVerEN.ScoreType, 1, conqa_AnswerVer.ScoreType);
clsCheckSql.CheckFieldLen(objqa_AnswerVerEN.ParentId, 10, conqa_AnswerVer.ParentId);
clsCheckSql.CheckFieldLen(objqa_AnswerVerEN.TopicId, 8, conqa_AnswerVer.TopicId);
clsCheckSql.CheckFieldLen(objqa_AnswerVerEN.AnswerTypeId, 2, conqa_AnswerVer.AnswerTypeId);
clsCheckSql.CheckFieldLen(objqa_AnswerVerEN.UpdUser, 20, conqa_AnswerVer.UpdUser);
clsCheckSql.CheckFieldLen(objqa_AnswerVerEN.UpdDate, 20, conqa_AnswerVer.UpdDate);
clsCheckSql.CheckFieldLen(objqa_AnswerVerEN.Memo, 1000, conqa_AnswerVer.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objqa_AnswerVerEN.AnswerId, conqa_AnswerVer.AnswerId);
clsCheckSql.CheckSqlInjection4Field(objqa_AnswerVerEN.QuestionsId, conqa_AnswerVer.QuestionsId);
clsCheckSql.CheckSqlInjection4Field(objqa_AnswerVerEN.ScoreType, conqa_AnswerVer.ScoreType);
clsCheckSql.CheckSqlInjection4Field(objqa_AnswerVerEN.ParentId, conqa_AnswerVer.ParentId);
clsCheckSql.CheckSqlInjection4Field(objqa_AnswerVerEN.TopicId, conqa_AnswerVer.TopicId);
clsCheckSql.CheckSqlInjection4Field(objqa_AnswerVerEN.AnswerTypeId, conqa_AnswerVer.AnswerTypeId);
clsCheckSql.CheckSqlInjection4Field(objqa_AnswerVerEN.UpdUser, conqa_AnswerVer.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objqa_AnswerVerEN.UpdDate, conqa_AnswerVer.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objqa_AnswerVerEN.Memo, conqa_AnswerVer.Memo);
//检查外键字段长度
 objqa_AnswerVerEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--qa_AnswerVer(答疑回答历史V),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objqa_AnswerVerEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsqa_AnswerVerEN objqa_AnswerVerEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and AnswerVId = '{0}'", objqa_AnswerVerEN.AnswerVId);
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
 objSQL = clsqa_AnswerVerDA.GetSpecSQLObj();
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
 objSQL = clsqa_AnswerVerDA.GetSpecSQLObj();
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
 objSQL = clsqa_AnswerVerDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsqa_AnswerVerEN._CurrTabName);
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
 objSQL = clsqa_AnswerVerDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsqa_AnswerVerEN._CurrTabName, strCondition);
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
 objSQL = clsqa_AnswerVerDA.GetSpecSQLObj();
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
 objSQL = clsqa_AnswerVerDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}