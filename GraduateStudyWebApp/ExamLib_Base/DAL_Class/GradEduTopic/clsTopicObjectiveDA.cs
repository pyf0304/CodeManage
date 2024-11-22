
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTopicObjectiveDA
 表名:TopicObjective(01120613)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:05:46
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培主题(GradEduTopic)
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
 /// 主题客观表(TopicObjective)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsTopicObjectiveDA : clsCommBase4DA
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
 return clsTopicObjectiveEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsTopicObjectiveEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsTopicObjectiveEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsTopicObjectiveEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsTopicObjectiveEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strTopicObjectiveId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strTopicObjectiveId)
{
strTopicObjectiveId = strTopicObjectiveId.Replace("'", "''");
if (strTopicObjectiveId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:TopicObjective中,检查关键字,长度不正确!(clsTopicObjectiveDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strTopicObjectiveId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:TopicObjective中,关键字不能为空 或 null!(clsTopicObjectiveDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTopicObjectiveId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsTopicObjectiveDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsTopicObjectiveDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTopicObjectiveDA.GetSpecSQLObj();
strSQL = "Select * from TopicObjective where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_TopicObjective(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsTopicObjectiveDA: GetDataTable_TopicObjective)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTopicObjectiveDA.GetSpecSQLObj();
strSQL = "Select * from TopicObjective where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsTopicObjectiveDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTopicObjectiveDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsTopicObjectiveDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTopicObjectiveDA.GetSpecSQLObj();
strSQL = "Select * from TopicObjective where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsTopicObjectiveDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTopicObjectiveDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsTopicObjectiveDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTopicObjectiveDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from TopicObjective where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from TopicObjective where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsTopicObjectiveDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTopicObjectiveDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from TopicObjective where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsTopicObjectiveDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTopicObjectiveDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} TopicObjective.* from TopicObjective Left Join {1} on {2} where {3} and TopicObjective.TopicObjectiveId not in (Select top {5} TopicObjective.TopicObjectiveId from TopicObjective Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from TopicObjective where {1} and TopicObjectiveId not in (Select top {2} TopicObjectiveId from TopicObjective where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from TopicObjective where {1} and TopicObjectiveId not in (Select top {3} TopicObjectiveId from TopicObjective where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsTopicObjectiveDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTopicObjectiveDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} TopicObjective.* from TopicObjective Left Join {1} on {2} where {3} and TopicObjective.TopicObjectiveId not in (Select top {5} TopicObjective.TopicObjectiveId from TopicObjective Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from TopicObjective where {1} and TopicObjectiveId not in (Select top {2} TopicObjectiveId from TopicObjective where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from TopicObjective where {1} and TopicObjectiveId not in (Select top {3} TopicObjectiveId from TopicObjective where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsTopicObjectiveEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsTopicObjectiveDA:GetObjLst)", objException.Message));
}
List<clsTopicObjectiveEN> arrObjLst = new List<clsTopicObjectiveEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTopicObjectiveDA.GetSpecSQLObj();
strSQL = "Select * from TopicObjective where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTopicObjectiveEN objTopicObjectiveEN = new clsTopicObjectiveEN();
try
{
objTopicObjectiveEN.TopicObjectiveId = objRow[conTopicObjective.TopicObjectiveId].ToString().Trim(); //客观Id
objTopicObjectiveEN.ObjectiveName = objRow[conTopicObjective.ObjectiveName] == DBNull.Value ? null : objRow[conTopicObjective.ObjectiveName].ToString().Trim(); //客观名称
objTopicObjectiveEN.ObjectiveContent = objRow[conTopicObjective.ObjectiveContent] == DBNull.Value ? null : objRow[conTopicObjective.ObjectiveContent].ToString().Trim(); //客观内容
objTopicObjectiveEN.ObjectiveType = objRow[conTopicObjective.ObjectiveType] == DBNull.Value ? null : objRow[conTopicObjective.ObjectiveType].ToString().Trim(); //客观类型
objTopicObjectiveEN.SourceId = objRow[conTopicObjective.SourceId] == DBNull.Value ? null : objRow[conTopicObjective.SourceId].ToString().Trim(); //来源Id
objTopicObjectiveEN.Conclusion = objRow[conTopicObjective.Conclusion] == DBNull.Value ? null : objRow[conTopicObjective.Conclusion].ToString().Trim(); //结论
objTopicObjectiveEN.IsSubmit = TransNullToBool(objRow[conTopicObjective.IsSubmit].ToString().Trim()); //是否提交
objTopicObjectiveEN.AppraiseCount = objRow[conTopicObjective.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTopicObjective.AppraiseCount].ToString().Trim()); //评论数
objTopicObjectiveEN.OkCount = objRow[conTopicObjective.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTopicObjective.OkCount].ToString().Trim()); //点赞统计
objTopicObjectiveEN.Score = objRow[conTopicObjective.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conTopicObjective.Score].ToString().Trim()); //评分
objTopicObjectiveEN.StuScore = objRow[conTopicObjective.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conTopicObjective.StuScore].ToString().Trim()); //学生平均分
objTopicObjectiveEN.TeaScore = objRow[conTopicObjective.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conTopicObjective.TeaScore].ToString().Trim()); //教师评分
objTopicObjectiveEN.IdCurrEduCls = objRow[conTopicObjective.IdCurrEduCls] == DBNull.Value ? null : objRow[conTopicObjective.IdCurrEduCls].ToString().Trim(); //教学班流水号
objTopicObjectiveEN.PdfContent = objRow[conTopicObjective.PdfContent] == DBNull.Value ? null : objRow[conTopicObjective.PdfContent].ToString().Trim(); //Pdf内容
objTopicObjectiveEN.PdfPageNum = objRow[conTopicObjective.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTopicObjective.PdfPageNum].ToString().Trim()); //Pdf页码
objTopicObjectiveEN.CitationCount = objRow[conTopicObjective.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTopicObjective.CitationCount].ToString().Trim()); //引用统计
objTopicObjectiveEN.VersionCount = objRow[conTopicObjective.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTopicObjective.VersionCount].ToString().Trim()); //版本统计
objTopicObjectiveEN.CreateDate = objRow[conTopicObjective.CreateDate] == DBNull.Value ? null : objRow[conTopicObjective.CreateDate].ToString().Trim(); //建立日期
objTopicObjectiveEN.ShareId = objRow[conTopicObjective.ShareId] == DBNull.Value ? null : objRow[conTopicObjective.ShareId].ToString().Trim(); //分享Id
objTopicObjectiveEN.UpdUser = objRow[conTopicObjective.UpdUser] == DBNull.Value ? null : objRow[conTopicObjective.UpdUser].ToString().Trim(); //修改人
objTopicObjectiveEN.UpdDate = objRow[conTopicObjective.UpdDate] == DBNull.Value ? null : objRow[conTopicObjective.UpdDate].ToString().Trim(); //修改日期
objTopicObjectiveEN.Memo = objRow[conTopicObjective.Memo] == DBNull.Value ? null : objRow[conTopicObjective.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsTopicObjectiveDA: GetObjLst)", objException.Message));
}
objTopicObjectiveEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objTopicObjectiveEN);
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
public List<clsTopicObjectiveEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsTopicObjectiveDA:GetObjLstByTabName)", objException.Message));
}
List<clsTopicObjectiveEN> arrObjLst = new List<clsTopicObjectiveEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTopicObjectiveDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTopicObjectiveEN objTopicObjectiveEN = new clsTopicObjectiveEN();
try
{
objTopicObjectiveEN.TopicObjectiveId = objRow[conTopicObjective.TopicObjectiveId].ToString().Trim(); //客观Id
objTopicObjectiveEN.ObjectiveName = objRow[conTopicObjective.ObjectiveName] == DBNull.Value ? null : objRow[conTopicObjective.ObjectiveName].ToString().Trim(); //客观名称
objTopicObjectiveEN.ObjectiveContent = objRow[conTopicObjective.ObjectiveContent] == DBNull.Value ? null : objRow[conTopicObjective.ObjectiveContent].ToString().Trim(); //客观内容
objTopicObjectiveEN.ObjectiveType = objRow[conTopicObjective.ObjectiveType] == DBNull.Value ? null : objRow[conTopicObjective.ObjectiveType].ToString().Trim(); //客观类型
objTopicObjectiveEN.SourceId = objRow[conTopicObjective.SourceId] == DBNull.Value ? null : objRow[conTopicObjective.SourceId].ToString().Trim(); //来源Id
objTopicObjectiveEN.Conclusion = objRow[conTopicObjective.Conclusion] == DBNull.Value ? null : objRow[conTopicObjective.Conclusion].ToString().Trim(); //结论
objTopicObjectiveEN.IsSubmit = TransNullToBool(objRow[conTopicObjective.IsSubmit].ToString().Trim()); //是否提交
objTopicObjectiveEN.AppraiseCount = objRow[conTopicObjective.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTopicObjective.AppraiseCount].ToString().Trim()); //评论数
objTopicObjectiveEN.OkCount = objRow[conTopicObjective.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTopicObjective.OkCount].ToString().Trim()); //点赞统计
objTopicObjectiveEN.Score = objRow[conTopicObjective.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conTopicObjective.Score].ToString().Trim()); //评分
objTopicObjectiveEN.StuScore = objRow[conTopicObjective.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conTopicObjective.StuScore].ToString().Trim()); //学生平均分
objTopicObjectiveEN.TeaScore = objRow[conTopicObjective.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conTopicObjective.TeaScore].ToString().Trim()); //教师评分
objTopicObjectiveEN.IdCurrEduCls = objRow[conTopicObjective.IdCurrEduCls] == DBNull.Value ? null : objRow[conTopicObjective.IdCurrEduCls].ToString().Trim(); //教学班流水号
objTopicObjectiveEN.PdfContent = objRow[conTopicObjective.PdfContent] == DBNull.Value ? null : objRow[conTopicObjective.PdfContent].ToString().Trim(); //Pdf内容
objTopicObjectiveEN.PdfPageNum = objRow[conTopicObjective.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTopicObjective.PdfPageNum].ToString().Trim()); //Pdf页码
objTopicObjectiveEN.CitationCount = objRow[conTopicObjective.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTopicObjective.CitationCount].ToString().Trim()); //引用统计
objTopicObjectiveEN.VersionCount = objRow[conTopicObjective.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTopicObjective.VersionCount].ToString().Trim()); //版本统计
objTopicObjectiveEN.CreateDate = objRow[conTopicObjective.CreateDate] == DBNull.Value ? null : objRow[conTopicObjective.CreateDate].ToString().Trim(); //建立日期
objTopicObjectiveEN.ShareId = objRow[conTopicObjective.ShareId] == DBNull.Value ? null : objRow[conTopicObjective.ShareId].ToString().Trim(); //分享Id
objTopicObjectiveEN.UpdUser = objRow[conTopicObjective.UpdUser] == DBNull.Value ? null : objRow[conTopicObjective.UpdUser].ToString().Trim(); //修改人
objTopicObjectiveEN.UpdDate = objRow[conTopicObjective.UpdDate] == DBNull.Value ? null : objRow[conTopicObjective.UpdDate].ToString().Trim(); //修改日期
objTopicObjectiveEN.Memo = objRow[conTopicObjective.Memo] == DBNull.Value ? null : objRow[conTopicObjective.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsTopicObjectiveDA: GetObjLst)", objException.Message));
}
objTopicObjectiveEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objTopicObjectiveEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objTopicObjectiveEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetTopicObjective(ref clsTopicObjectiveEN objTopicObjectiveEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTopicObjectiveDA.GetSpecSQLObj();
strSQL = "Select * from TopicObjective where TopicObjectiveId = " + "'"+ objTopicObjectiveEN.TopicObjectiveId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objTopicObjectiveEN.TopicObjectiveId = objDT.Rows[0][conTopicObjective.TopicObjectiveId].ToString().Trim(); //客观Id(字段类型:char,字段长度:8,是否可空:False)
 objTopicObjectiveEN.ObjectiveName = objDT.Rows[0][conTopicObjective.ObjectiveName].ToString().Trim(); //客观名称(字段类型:varchar,字段长度:500,是否可空:True)
 objTopicObjectiveEN.ObjectiveContent = objDT.Rows[0][conTopicObjective.ObjectiveContent].ToString().Trim(); //客观内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objTopicObjectiveEN.ObjectiveType = objDT.Rows[0][conTopicObjective.ObjectiveType].ToString().Trim(); //客观类型(字段类型:char,字段长度:2,是否可空:True)
 objTopicObjectiveEN.SourceId = objDT.Rows[0][conTopicObjective.SourceId].ToString().Trim(); //来源Id(字段类型:char,字段长度:10,是否可空:True)
 objTopicObjectiveEN.Conclusion = objDT.Rows[0][conTopicObjective.Conclusion].ToString().Trim(); //结论(字段类型:varchar,字段长度:5000,是否可空:True)
 objTopicObjectiveEN.IsSubmit = TransNullToBool(objDT.Rows[0][conTopicObjective.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objTopicObjectiveEN.AppraiseCount = TransNullToInt(objDT.Rows[0][conTopicObjective.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objTopicObjectiveEN.OkCount = TransNullToInt(objDT.Rows[0][conTopicObjective.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objTopicObjectiveEN.Score = TransNullToFloat(objDT.Rows[0][conTopicObjective.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objTopicObjectiveEN.StuScore = TransNullToFloat(objDT.Rows[0][conTopicObjective.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objTopicObjectiveEN.TeaScore = TransNullToFloat(objDT.Rows[0][conTopicObjective.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objTopicObjectiveEN.IdCurrEduCls = objDT.Rows[0][conTopicObjective.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objTopicObjectiveEN.PdfContent = objDT.Rows[0][conTopicObjective.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objTopicObjectiveEN.PdfPageNum = TransNullToInt(objDT.Rows[0][conTopicObjective.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objTopicObjectiveEN.CitationCount = TransNullToInt(objDT.Rows[0][conTopicObjective.CitationCount].ToString().Trim()); //引用统计(字段类型:int,字段长度:4,是否可空:True)
 objTopicObjectiveEN.VersionCount = TransNullToInt(objDT.Rows[0][conTopicObjective.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objTopicObjectiveEN.CreateDate = objDT.Rows[0][conTopicObjective.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objTopicObjectiveEN.ShareId = objDT.Rows[0][conTopicObjective.ShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objTopicObjectiveEN.UpdUser = objDT.Rows[0][conTopicObjective.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objTopicObjectiveEN.UpdDate = objDT.Rows[0][conTopicObjective.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objTopicObjectiveEN.Memo = objDT.Rows[0][conTopicObjective.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsTopicObjectiveDA: GetTopicObjective)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strTopicObjectiveId">表关键字</param>
 /// <returns>表对象</returns>
public clsTopicObjectiveEN GetObjByTopicObjectiveId(string strTopicObjectiveId)
{
CheckPrimaryKey(strTopicObjectiveId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTopicObjectiveDA.GetSpecSQLObj();
strSQL = "Select * from TopicObjective where TopicObjectiveId = " + "'"+ strTopicObjectiveId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsTopicObjectiveEN objTopicObjectiveEN = new clsTopicObjectiveEN();
try
{
 objTopicObjectiveEN.TopicObjectiveId = objRow[conTopicObjective.TopicObjectiveId].ToString().Trim(); //客观Id(字段类型:char,字段长度:8,是否可空:False)
 objTopicObjectiveEN.ObjectiveName = objRow[conTopicObjective.ObjectiveName] == DBNull.Value ? null : objRow[conTopicObjective.ObjectiveName].ToString().Trim(); //客观名称(字段类型:varchar,字段长度:500,是否可空:True)
 objTopicObjectiveEN.ObjectiveContent = objRow[conTopicObjective.ObjectiveContent] == DBNull.Value ? null : objRow[conTopicObjective.ObjectiveContent].ToString().Trim(); //客观内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objTopicObjectiveEN.ObjectiveType = objRow[conTopicObjective.ObjectiveType] == DBNull.Value ? null : objRow[conTopicObjective.ObjectiveType].ToString().Trim(); //客观类型(字段类型:char,字段长度:2,是否可空:True)
 objTopicObjectiveEN.SourceId = objRow[conTopicObjective.SourceId] == DBNull.Value ? null : objRow[conTopicObjective.SourceId].ToString().Trim(); //来源Id(字段类型:char,字段长度:10,是否可空:True)
 objTopicObjectiveEN.Conclusion = objRow[conTopicObjective.Conclusion] == DBNull.Value ? null : objRow[conTopicObjective.Conclusion].ToString().Trim(); //结论(字段类型:varchar,字段长度:5000,是否可空:True)
 objTopicObjectiveEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conTopicObjective.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objTopicObjectiveEN.AppraiseCount = objRow[conTopicObjective.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTopicObjective.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objTopicObjectiveEN.OkCount = objRow[conTopicObjective.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTopicObjective.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objTopicObjectiveEN.Score = objRow[conTopicObjective.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conTopicObjective.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objTopicObjectiveEN.StuScore = objRow[conTopicObjective.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conTopicObjective.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objTopicObjectiveEN.TeaScore = objRow[conTopicObjective.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conTopicObjective.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objTopicObjectiveEN.IdCurrEduCls = objRow[conTopicObjective.IdCurrEduCls] == DBNull.Value ? null : objRow[conTopicObjective.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objTopicObjectiveEN.PdfContent = objRow[conTopicObjective.PdfContent] == DBNull.Value ? null : objRow[conTopicObjective.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objTopicObjectiveEN.PdfPageNum = objRow[conTopicObjective.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTopicObjective.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objTopicObjectiveEN.CitationCount = objRow[conTopicObjective.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTopicObjective.CitationCount].ToString().Trim()); //引用统计(字段类型:int,字段长度:4,是否可空:True)
 objTopicObjectiveEN.VersionCount = objRow[conTopicObjective.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTopicObjective.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objTopicObjectiveEN.CreateDate = objRow[conTopicObjective.CreateDate] == DBNull.Value ? null : objRow[conTopicObjective.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objTopicObjectiveEN.ShareId = objRow[conTopicObjective.ShareId] == DBNull.Value ? null : objRow[conTopicObjective.ShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objTopicObjectiveEN.UpdUser = objRow[conTopicObjective.UpdUser] == DBNull.Value ? null : objRow[conTopicObjective.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objTopicObjectiveEN.UpdDate = objRow[conTopicObjective.UpdDate] == DBNull.Value ? null : objRow[conTopicObjective.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objTopicObjectiveEN.Memo = objRow[conTopicObjective.Memo] == DBNull.Value ? null : objRow[conTopicObjective.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsTopicObjectiveDA: GetObjByTopicObjectiveId)", objException.Message));
}
return objTopicObjectiveEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsTopicObjectiveEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsTopicObjectiveDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTopicObjectiveDA.GetSpecSQLObj();
strSQL = "Select * from TopicObjective where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsTopicObjectiveEN objTopicObjectiveEN = new clsTopicObjectiveEN()
{
TopicObjectiveId = objRow[conTopicObjective.TopicObjectiveId].ToString().Trim(), //客观Id
ObjectiveName = objRow[conTopicObjective.ObjectiveName] == DBNull.Value ? null : objRow[conTopicObjective.ObjectiveName].ToString().Trim(), //客观名称
ObjectiveContent = objRow[conTopicObjective.ObjectiveContent] == DBNull.Value ? null : objRow[conTopicObjective.ObjectiveContent].ToString().Trim(), //客观内容
ObjectiveType = objRow[conTopicObjective.ObjectiveType] == DBNull.Value ? null : objRow[conTopicObjective.ObjectiveType].ToString().Trim(), //客观类型
SourceId = objRow[conTopicObjective.SourceId] == DBNull.Value ? null : objRow[conTopicObjective.SourceId].ToString().Trim(), //来源Id
Conclusion = objRow[conTopicObjective.Conclusion] == DBNull.Value ? null : objRow[conTopicObjective.Conclusion].ToString().Trim(), //结论
IsSubmit = TransNullToBool(objRow[conTopicObjective.IsSubmit].ToString().Trim()), //是否提交
AppraiseCount = objRow[conTopicObjective.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTopicObjective.AppraiseCount].ToString().Trim()), //评论数
OkCount = objRow[conTopicObjective.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTopicObjective.OkCount].ToString().Trim()), //点赞统计
Score = objRow[conTopicObjective.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conTopicObjective.Score].ToString().Trim()), //评分
StuScore = objRow[conTopicObjective.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conTopicObjective.StuScore].ToString().Trim()), //学生平均分
TeaScore = objRow[conTopicObjective.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conTopicObjective.TeaScore].ToString().Trim()), //教师评分
IdCurrEduCls = objRow[conTopicObjective.IdCurrEduCls] == DBNull.Value ? null : objRow[conTopicObjective.IdCurrEduCls].ToString().Trim(), //教学班流水号
PdfContent = objRow[conTopicObjective.PdfContent] == DBNull.Value ? null : objRow[conTopicObjective.PdfContent].ToString().Trim(), //Pdf内容
PdfPageNum = objRow[conTopicObjective.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTopicObjective.PdfPageNum].ToString().Trim()), //Pdf页码
CitationCount = objRow[conTopicObjective.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTopicObjective.CitationCount].ToString().Trim()), //引用统计
VersionCount = objRow[conTopicObjective.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTopicObjective.VersionCount].ToString().Trim()), //版本统计
CreateDate = objRow[conTopicObjective.CreateDate] == DBNull.Value ? null : objRow[conTopicObjective.CreateDate].ToString().Trim(), //建立日期
ShareId = objRow[conTopicObjective.ShareId] == DBNull.Value ? null : objRow[conTopicObjective.ShareId].ToString().Trim(), //分享Id
UpdUser = objRow[conTopicObjective.UpdUser] == DBNull.Value ? null : objRow[conTopicObjective.UpdUser].ToString().Trim(), //修改人
UpdDate = objRow[conTopicObjective.UpdDate] == DBNull.Value ? null : objRow[conTopicObjective.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[conTopicObjective.Memo] == DBNull.Value ? null : objRow[conTopicObjective.Memo].ToString().Trim() //备注
};
objTopicObjectiveEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objTopicObjectiveEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsTopicObjectiveDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsTopicObjectiveEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsTopicObjectiveEN objTopicObjectiveEN = new clsTopicObjectiveEN();
try
{
objTopicObjectiveEN.TopicObjectiveId = objRow[conTopicObjective.TopicObjectiveId].ToString().Trim(); //客观Id
objTopicObjectiveEN.ObjectiveName = objRow[conTopicObjective.ObjectiveName] == DBNull.Value ? null : objRow[conTopicObjective.ObjectiveName].ToString().Trim(); //客观名称
objTopicObjectiveEN.ObjectiveContent = objRow[conTopicObjective.ObjectiveContent] == DBNull.Value ? null : objRow[conTopicObjective.ObjectiveContent].ToString().Trim(); //客观内容
objTopicObjectiveEN.ObjectiveType = objRow[conTopicObjective.ObjectiveType] == DBNull.Value ? null : objRow[conTopicObjective.ObjectiveType].ToString().Trim(); //客观类型
objTopicObjectiveEN.SourceId = objRow[conTopicObjective.SourceId] == DBNull.Value ? null : objRow[conTopicObjective.SourceId].ToString().Trim(); //来源Id
objTopicObjectiveEN.Conclusion = objRow[conTopicObjective.Conclusion] == DBNull.Value ? null : objRow[conTopicObjective.Conclusion].ToString().Trim(); //结论
objTopicObjectiveEN.IsSubmit = TransNullToBool(objRow[conTopicObjective.IsSubmit].ToString().Trim()); //是否提交
objTopicObjectiveEN.AppraiseCount = objRow[conTopicObjective.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTopicObjective.AppraiseCount].ToString().Trim()); //评论数
objTopicObjectiveEN.OkCount = objRow[conTopicObjective.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTopicObjective.OkCount].ToString().Trim()); //点赞统计
objTopicObjectiveEN.Score = objRow[conTopicObjective.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conTopicObjective.Score].ToString().Trim()); //评分
objTopicObjectiveEN.StuScore = objRow[conTopicObjective.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conTopicObjective.StuScore].ToString().Trim()); //学生平均分
objTopicObjectiveEN.TeaScore = objRow[conTopicObjective.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conTopicObjective.TeaScore].ToString().Trim()); //教师评分
objTopicObjectiveEN.IdCurrEduCls = objRow[conTopicObjective.IdCurrEduCls] == DBNull.Value ? null : objRow[conTopicObjective.IdCurrEduCls].ToString().Trim(); //教学班流水号
objTopicObjectiveEN.PdfContent = objRow[conTopicObjective.PdfContent] == DBNull.Value ? null : objRow[conTopicObjective.PdfContent].ToString().Trim(); //Pdf内容
objTopicObjectiveEN.PdfPageNum = objRow[conTopicObjective.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTopicObjective.PdfPageNum].ToString().Trim()); //Pdf页码
objTopicObjectiveEN.CitationCount = objRow[conTopicObjective.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTopicObjective.CitationCount].ToString().Trim()); //引用统计
objTopicObjectiveEN.VersionCount = objRow[conTopicObjective.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTopicObjective.VersionCount].ToString().Trim()); //版本统计
objTopicObjectiveEN.CreateDate = objRow[conTopicObjective.CreateDate] == DBNull.Value ? null : objRow[conTopicObjective.CreateDate].ToString().Trim(); //建立日期
objTopicObjectiveEN.ShareId = objRow[conTopicObjective.ShareId] == DBNull.Value ? null : objRow[conTopicObjective.ShareId].ToString().Trim(); //分享Id
objTopicObjectiveEN.UpdUser = objRow[conTopicObjective.UpdUser] == DBNull.Value ? null : objRow[conTopicObjective.UpdUser].ToString().Trim(); //修改人
objTopicObjectiveEN.UpdDate = objRow[conTopicObjective.UpdDate] == DBNull.Value ? null : objRow[conTopicObjective.UpdDate].ToString().Trim(); //修改日期
objTopicObjectiveEN.Memo = objRow[conTopicObjective.Memo] == DBNull.Value ? null : objRow[conTopicObjective.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsTopicObjectiveDA: GetObjByDataRowTopicObjective)", objException.Message));
}
objTopicObjectiveEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objTopicObjectiveEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsTopicObjectiveEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsTopicObjectiveEN objTopicObjectiveEN = new clsTopicObjectiveEN();
try
{
objTopicObjectiveEN.TopicObjectiveId = objRow[conTopicObjective.TopicObjectiveId].ToString().Trim(); //客观Id
objTopicObjectiveEN.ObjectiveName = objRow[conTopicObjective.ObjectiveName] == DBNull.Value ? null : objRow[conTopicObjective.ObjectiveName].ToString().Trim(); //客观名称
objTopicObjectiveEN.ObjectiveContent = objRow[conTopicObjective.ObjectiveContent] == DBNull.Value ? null : objRow[conTopicObjective.ObjectiveContent].ToString().Trim(); //客观内容
objTopicObjectiveEN.ObjectiveType = objRow[conTopicObjective.ObjectiveType] == DBNull.Value ? null : objRow[conTopicObjective.ObjectiveType].ToString().Trim(); //客观类型
objTopicObjectiveEN.SourceId = objRow[conTopicObjective.SourceId] == DBNull.Value ? null : objRow[conTopicObjective.SourceId].ToString().Trim(); //来源Id
objTopicObjectiveEN.Conclusion = objRow[conTopicObjective.Conclusion] == DBNull.Value ? null : objRow[conTopicObjective.Conclusion].ToString().Trim(); //结论
objTopicObjectiveEN.IsSubmit = TransNullToBool(objRow[conTopicObjective.IsSubmit].ToString().Trim()); //是否提交
objTopicObjectiveEN.AppraiseCount = objRow[conTopicObjective.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTopicObjective.AppraiseCount].ToString().Trim()); //评论数
objTopicObjectiveEN.OkCount = objRow[conTopicObjective.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTopicObjective.OkCount].ToString().Trim()); //点赞统计
objTopicObjectiveEN.Score = objRow[conTopicObjective.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conTopicObjective.Score].ToString().Trim()); //评分
objTopicObjectiveEN.StuScore = objRow[conTopicObjective.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conTopicObjective.StuScore].ToString().Trim()); //学生平均分
objTopicObjectiveEN.TeaScore = objRow[conTopicObjective.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conTopicObjective.TeaScore].ToString().Trim()); //教师评分
objTopicObjectiveEN.IdCurrEduCls = objRow[conTopicObjective.IdCurrEduCls] == DBNull.Value ? null : objRow[conTopicObjective.IdCurrEduCls].ToString().Trim(); //教学班流水号
objTopicObjectiveEN.PdfContent = objRow[conTopicObjective.PdfContent] == DBNull.Value ? null : objRow[conTopicObjective.PdfContent].ToString().Trim(); //Pdf内容
objTopicObjectiveEN.PdfPageNum = objRow[conTopicObjective.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTopicObjective.PdfPageNum].ToString().Trim()); //Pdf页码
objTopicObjectiveEN.CitationCount = objRow[conTopicObjective.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTopicObjective.CitationCount].ToString().Trim()); //引用统计
objTopicObjectiveEN.VersionCount = objRow[conTopicObjective.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTopicObjective.VersionCount].ToString().Trim()); //版本统计
objTopicObjectiveEN.CreateDate = objRow[conTopicObjective.CreateDate] == DBNull.Value ? null : objRow[conTopicObjective.CreateDate].ToString().Trim(); //建立日期
objTopicObjectiveEN.ShareId = objRow[conTopicObjective.ShareId] == DBNull.Value ? null : objRow[conTopicObjective.ShareId].ToString().Trim(); //分享Id
objTopicObjectiveEN.UpdUser = objRow[conTopicObjective.UpdUser] == DBNull.Value ? null : objRow[conTopicObjective.UpdUser].ToString().Trim(); //修改人
objTopicObjectiveEN.UpdDate = objRow[conTopicObjective.UpdDate] == DBNull.Value ? null : objRow[conTopicObjective.UpdDate].ToString().Trim(); //修改日期
objTopicObjectiveEN.Memo = objRow[conTopicObjective.Memo] == DBNull.Value ? null : objRow[conTopicObjective.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsTopicObjectiveDA: GetObjByDataRow)", objException.Message));
}
objTopicObjectiveEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objTopicObjectiveEN;
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
objSQL = clsTopicObjectiveDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsTopicObjectiveEN._CurrTabName, conTopicObjective.TopicObjectiveId, 8, "");
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
objSQL = clsTopicObjectiveDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsTopicObjectiveEN._CurrTabName, conTopicObjective.TopicObjectiveId, 8, strPrefix);
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
 objSQL = clsTopicObjectiveDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select TopicObjectiveId from TopicObjective where " + strCondition;
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
 objSQL = clsTopicObjectiveDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select TopicObjectiveId from TopicObjective where " + strCondition;
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
 /// <param name = "strTopicObjectiveId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strTopicObjectiveId)
{
CheckPrimaryKey(strTopicObjectiveId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTopicObjectiveDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("TopicObjective", "TopicObjectiveId = " + "'"+ strTopicObjectiveId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsTopicObjectiveDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTopicObjectiveDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("TopicObjective", strCondition))
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
objSQL = clsTopicObjectiveDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("TopicObjective");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsTopicObjectiveEN objTopicObjectiveEN)
 {
 if (objTopicObjectiveEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTopicObjectiveEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTopicObjectiveDA.GetSpecSQLObj();
strSQL = "Select * from TopicObjective where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "TopicObjective");
objRow = objDS.Tables["TopicObjective"].NewRow();
objRow[conTopicObjective.TopicObjectiveId] = objTopicObjectiveEN.TopicObjectiveId; //客观Id
 if (objTopicObjectiveEN.ObjectiveName !=  "")
 {
objRow[conTopicObjective.ObjectiveName] = objTopicObjectiveEN.ObjectiveName; //客观名称
 }
 if (objTopicObjectiveEN.ObjectiveContent !=  "")
 {
objRow[conTopicObjective.ObjectiveContent] = objTopicObjectiveEN.ObjectiveContent; //客观内容
 }
 if (objTopicObjectiveEN.ObjectiveType !=  "")
 {
objRow[conTopicObjective.ObjectiveType] = objTopicObjectiveEN.ObjectiveType; //客观类型
 }
 if (objTopicObjectiveEN.SourceId !=  "")
 {
objRow[conTopicObjective.SourceId] = objTopicObjectiveEN.SourceId; //来源Id
 }
 if (objTopicObjectiveEN.Conclusion !=  "")
 {
objRow[conTopicObjective.Conclusion] = objTopicObjectiveEN.Conclusion; //结论
 }
objRow[conTopicObjective.IsSubmit] = objTopicObjectiveEN.IsSubmit; //是否提交
objRow[conTopicObjective.AppraiseCount] = objTopicObjectiveEN.AppraiseCount; //评论数
objRow[conTopicObjective.OkCount] = objTopicObjectiveEN.OkCount; //点赞统计
objRow[conTopicObjective.Score] = objTopicObjectiveEN.Score; //评分
objRow[conTopicObjective.StuScore] = objTopicObjectiveEN.StuScore; //学生平均分
objRow[conTopicObjective.TeaScore] = objTopicObjectiveEN.TeaScore; //教师评分
 if (objTopicObjectiveEN.IdCurrEduCls !=  "")
 {
objRow[conTopicObjective.IdCurrEduCls] = objTopicObjectiveEN.IdCurrEduCls; //教学班流水号
 }
 if (objTopicObjectiveEN.PdfContent !=  "")
 {
objRow[conTopicObjective.PdfContent] = objTopicObjectiveEN.PdfContent; //Pdf内容
 }
objRow[conTopicObjective.PdfPageNum] = objTopicObjectiveEN.PdfPageNum; //Pdf页码
objRow[conTopicObjective.CitationCount] = objTopicObjectiveEN.CitationCount; //引用统计
objRow[conTopicObjective.VersionCount] = objTopicObjectiveEN.VersionCount; //版本统计
 if (objTopicObjectiveEN.CreateDate !=  "")
 {
objRow[conTopicObjective.CreateDate] = objTopicObjectiveEN.CreateDate; //建立日期
 }
 if (objTopicObjectiveEN.ShareId !=  "")
 {
objRow[conTopicObjective.ShareId] = objTopicObjectiveEN.ShareId; //分享Id
 }
 if (objTopicObjectiveEN.UpdUser !=  "")
 {
objRow[conTopicObjective.UpdUser] = objTopicObjectiveEN.UpdUser; //修改人
 }
 if (objTopicObjectiveEN.UpdDate !=  "")
 {
objRow[conTopicObjective.UpdDate] = objTopicObjectiveEN.UpdDate; //修改日期
 }
 if (objTopicObjectiveEN.Memo !=  "")
 {
objRow[conTopicObjective.Memo] = objTopicObjectiveEN.Memo; //备注
 }
objDS.Tables[clsTopicObjectiveEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsTopicObjectiveEN._CurrTabName);
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
 /// <param name = "objTopicObjectiveEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsTopicObjectiveEN objTopicObjectiveEN)
{
 if (objTopicObjectiveEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTopicObjectiveEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objTopicObjectiveEN.TopicObjectiveId !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.TopicObjectiveId);
 var strTopicObjectiveId = objTopicObjectiveEN.TopicObjectiveId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicObjectiveId + "'");
 }
 
 if (objTopicObjectiveEN.ObjectiveName !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.ObjectiveName);
 var strObjectiveName = objTopicObjectiveEN.ObjectiveName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strObjectiveName + "'");
 }
 
 if (objTopicObjectiveEN.ObjectiveContent !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.ObjectiveContent);
 var strObjectiveContent = objTopicObjectiveEN.ObjectiveContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strObjectiveContent + "'");
 }
 
 if (objTopicObjectiveEN.ObjectiveType !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.ObjectiveType);
 var strObjectiveType = objTopicObjectiveEN.ObjectiveType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strObjectiveType + "'");
 }
 
 if (objTopicObjectiveEN.SourceId !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.SourceId);
 var strSourceId = objTopicObjectiveEN.SourceId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSourceId + "'");
 }
 
 if (objTopicObjectiveEN.Conclusion !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.Conclusion);
 var strConclusion = objTopicObjectiveEN.Conclusion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConclusion + "'");
 }
 
 arrFieldListForInsert.Add(conTopicObjective.IsSubmit);
 arrValueListForInsert.Add("'" + (objTopicObjectiveEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objTopicObjectiveEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.AppraiseCount);
 arrValueListForInsert.Add(objTopicObjectiveEN.AppraiseCount.ToString());
 }
 
 if (objTopicObjectiveEN.OkCount !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.OkCount);
 arrValueListForInsert.Add(objTopicObjectiveEN.OkCount.ToString());
 }
 
 if (objTopicObjectiveEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.Score);
 arrValueListForInsert.Add(objTopicObjectiveEN.Score.ToString());
 }
 
 if (objTopicObjectiveEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.StuScore);
 arrValueListForInsert.Add(objTopicObjectiveEN.StuScore.ToString());
 }
 
 if (objTopicObjectiveEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.TeaScore);
 arrValueListForInsert.Add(objTopicObjectiveEN.TeaScore.ToString());
 }
 
 if (objTopicObjectiveEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.IdCurrEduCls);
 var strIdCurrEduCls = objTopicObjectiveEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objTopicObjectiveEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.PdfContent);
 var strPdfContent = objTopicObjectiveEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objTopicObjectiveEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.PdfPageNum);
 arrValueListForInsert.Add(objTopicObjectiveEN.PdfPageNum.ToString());
 }
 
 if (objTopicObjectiveEN.CitationCount !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.CitationCount);
 arrValueListForInsert.Add(objTopicObjectiveEN.CitationCount.ToString());
 }
 
 if (objTopicObjectiveEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.VersionCount);
 arrValueListForInsert.Add(objTopicObjectiveEN.VersionCount.ToString());
 }
 
 if (objTopicObjectiveEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.CreateDate);
 var strCreateDate = objTopicObjectiveEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objTopicObjectiveEN.ShareId !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.ShareId);
 var strShareId = objTopicObjectiveEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strShareId + "'");
 }
 
 if (objTopicObjectiveEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.UpdUser);
 var strUpdUser = objTopicObjectiveEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objTopicObjectiveEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.UpdDate);
 var strUpdDate = objTopicObjectiveEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objTopicObjectiveEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.Memo);
 var strMemo = objTopicObjectiveEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into TopicObjective");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTopicObjectiveDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objTopicObjectiveEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsTopicObjectiveEN objTopicObjectiveEN)
{
 if (objTopicObjectiveEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTopicObjectiveEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objTopicObjectiveEN.TopicObjectiveId !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.TopicObjectiveId);
 var strTopicObjectiveId = objTopicObjectiveEN.TopicObjectiveId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicObjectiveId + "'");
 }
 
 if (objTopicObjectiveEN.ObjectiveName !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.ObjectiveName);
 var strObjectiveName = objTopicObjectiveEN.ObjectiveName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strObjectiveName + "'");
 }
 
 if (objTopicObjectiveEN.ObjectiveContent !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.ObjectiveContent);
 var strObjectiveContent = objTopicObjectiveEN.ObjectiveContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strObjectiveContent + "'");
 }
 
 if (objTopicObjectiveEN.ObjectiveType !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.ObjectiveType);
 var strObjectiveType = objTopicObjectiveEN.ObjectiveType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strObjectiveType + "'");
 }
 
 if (objTopicObjectiveEN.SourceId !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.SourceId);
 var strSourceId = objTopicObjectiveEN.SourceId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSourceId + "'");
 }
 
 if (objTopicObjectiveEN.Conclusion !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.Conclusion);
 var strConclusion = objTopicObjectiveEN.Conclusion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConclusion + "'");
 }
 
 arrFieldListForInsert.Add(conTopicObjective.IsSubmit);
 arrValueListForInsert.Add("'" + (objTopicObjectiveEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objTopicObjectiveEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.AppraiseCount);
 arrValueListForInsert.Add(objTopicObjectiveEN.AppraiseCount.ToString());
 }
 
 if (objTopicObjectiveEN.OkCount !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.OkCount);
 arrValueListForInsert.Add(objTopicObjectiveEN.OkCount.ToString());
 }
 
 if (objTopicObjectiveEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.Score);
 arrValueListForInsert.Add(objTopicObjectiveEN.Score.ToString());
 }
 
 if (objTopicObjectiveEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.StuScore);
 arrValueListForInsert.Add(objTopicObjectiveEN.StuScore.ToString());
 }
 
 if (objTopicObjectiveEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.TeaScore);
 arrValueListForInsert.Add(objTopicObjectiveEN.TeaScore.ToString());
 }
 
 if (objTopicObjectiveEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.IdCurrEduCls);
 var strIdCurrEduCls = objTopicObjectiveEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objTopicObjectiveEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.PdfContent);
 var strPdfContent = objTopicObjectiveEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objTopicObjectiveEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.PdfPageNum);
 arrValueListForInsert.Add(objTopicObjectiveEN.PdfPageNum.ToString());
 }
 
 if (objTopicObjectiveEN.CitationCount !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.CitationCount);
 arrValueListForInsert.Add(objTopicObjectiveEN.CitationCount.ToString());
 }
 
 if (objTopicObjectiveEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.VersionCount);
 arrValueListForInsert.Add(objTopicObjectiveEN.VersionCount.ToString());
 }
 
 if (objTopicObjectiveEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.CreateDate);
 var strCreateDate = objTopicObjectiveEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objTopicObjectiveEN.ShareId !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.ShareId);
 var strShareId = objTopicObjectiveEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strShareId + "'");
 }
 
 if (objTopicObjectiveEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.UpdUser);
 var strUpdUser = objTopicObjectiveEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objTopicObjectiveEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.UpdDate);
 var strUpdDate = objTopicObjectiveEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objTopicObjectiveEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.Memo);
 var strMemo = objTopicObjectiveEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into TopicObjective");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTopicObjectiveDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objTopicObjectiveEN.TopicObjectiveId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objTopicObjectiveEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsTopicObjectiveEN objTopicObjectiveEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objTopicObjectiveEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTopicObjectiveEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objTopicObjectiveEN.TopicObjectiveId !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.TopicObjectiveId);
 var strTopicObjectiveId = objTopicObjectiveEN.TopicObjectiveId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicObjectiveId + "'");
 }
 
 if (objTopicObjectiveEN.ObjectiveName !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.ObjectiveName);
 var strObjectiveName = objTopicObjectiveEN.ObjectiveName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strObjectiveName + "'");
 }
 
 if (objTopicObjectiveEN.ObjectiveContent !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.ObjectiveContent);
 var strObjectiveContent = objTopicObjectiveEN.ObjectiveContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strObjectiveContent + "'");
 }
 
 if (objTopicObjectiveEN.ObjectiveType !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.ObjectiveType);
 var strObjectiveType = objTopicObjectiveEN.ObjectiveType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strObjectiveType + "'");
 }
 
 if (objTopicObjectiveEN.SourceId !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.SourceId);
 var strSourceId = objTopicObjectiveEN.SourceId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSourceId + "'");
 }
 
 if (objTopicObjectiveEN.Conclusion !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.Conclusion);
 var strConclusion = objTopicObjectiveEN.Conclusion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConclusion + "'");
 }
 
 arrFieldListForInsert.Add(conTopicObjective.IsSubmit);
 arrValueListForInsert.Add("'" + (objTopicObjectiveEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objTopicObjectiveEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.AppraiseCount);
 arrValueListForInsert.Add(objTopicObjectiveEN.AppraiseCount.ToString());
 }
 
 if (objTopicObjectiveEN.OkCount !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.OkCount);
 arrValueListForInsert.Add(objTopicObjectiveEN.OkCount.ToString());
 }
 
 if (objTopicObjectiveEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.Score);
 arrValueListForInsert.Add(objTopicObjectiveEN.Score.ToString());
 }
 
 if (objTopicObjectiveEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.StuScore);
 arrValueListForInsert.Add(objTopicObjectiveEN.StuScore.ToString());
 }
 
 if (objTopicObjectiveEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.TeaScore);
 arrValueListForInsert.Add(objTopicObjectiveEN.TeaScore.ToString());
 }
 
 if (objTopicObjectiveEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.IdCurrEduCls);
 var strIdCurrEduCls = objTopicObjectiveEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objTopicObjectiveEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.PdfContent);
 var strPdfContent = objTopicObjectiveEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objTopicObjectiveEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.PdfPageNum);
 arrValueListForInsert.Add(objTopicObjectiveEN.PdfPageNum.ToString());
 }
 
 if (objTopicObjectiveEN.CitationCount !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.CitationCount);
 arrValueListForInsert.Add(objTopicObjectiveEN.CitationCount.ToString());
 }
 
 if (objTopicObjectiveEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.VersionCount);
 arrValueListForInsert.Add(objTopicObjectiveEN.VersionCount.ToString());
 }
 
 if (objTopicObjectiveEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.CreateDate);
 var strCreateDate = objTopicObjectiveEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objTopicObjectiveEN.ShareId !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.ShareId);
 var strShareId = objTopicObjectiveEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strShareId + "'");
 }
 
 if (objTopicObjectiveEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.UpdUser);
 var strUpdUser = objTopicObjectiveEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objTopicObjectiveEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.UpdDate);
 var strUpdDate = objTopicObjectiveEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objTopicObjectiveEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.Memo);
 var strMemo = objTopicObjectiveEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into TopicObjective");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTopicObjectiveDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objTopicObjectiveEN.TopicObjectiveId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objTopicObjectiveEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsTopicObjectiveEN objTopicObjectiveEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objTopicObjectiveEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTopicObjectiveEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objTopicObjectiveEN.TopicObjectiveId !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.TopicObjectiveId);
 var strTopicObjectiveId = objTopicObjectiveEN.TopicObjectiveId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicObjectiveId + "'");
 }
 
 if (objTopicObjectiveEN.ObjectiveName !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.ObjectiveName);
 var strObjectiveName = objTopicObjectiveEN.ObjectiveName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strObjectiveName + "'");
 }
 
 if (objTopicObjectiveEN.ObjectiveContent !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.ObjectiveContent);
 var strObjectiveContent = objTopicObjectiveEN.ObjectiveContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strObjectiveContent + "'");
 }
 
 if (objTopicObjectiveEN.ObjectiveType !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.ObjectiveType);
 var strObjectiveType = objTopicObjectiveEN.ObjectiveType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strObjectiveType + "'");
 }
 
 if (objTopicObjectiveEN.SourceId !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.SourceId);
 var strSourceId = objTopicObjectiveEN.SourceId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSourceId + "'");
 }
 
 if (objTopicObjectiveEN.Conclusion !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.Conclusion);
 var strConclusion = objTopicObjectiveEN.Conclusion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConclusion + "'");
 }
 
 arrFieldListForInsert.Add(conTopicObjective.IsSubmit);
 arrValueListForInsert.Add("'" + (objTopicObjectiveEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objTopicObjectiveEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.AppraiseCount);
 arrValueListForInsert.Add(objTopicObjectiveEN.AppraiseCount.ToString());
 }
 
 if (objTopicObjectiveEN.OkCount !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.OkCount);
 arrValueListForInsert.Add(objTopicObjectiveEN.OkCount.ToString());
 }
 
 if (objTopicObjectiveEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.Score);
 arrValueListForInsert.Add(objTopicObjectiveEN.Score.ToString());
 }
 
 if (objTopicObjectiveEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.StuScore);
 arrValueListForInsert.Add(objTopicObjectiveEN.StuScore.ToString());
 }
 
 if (objTopicObjectiveEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.TeaScore);
 arrValueListForInsert.Add(objTopicObjectiveEN.TeaScore.ToString());
 }
 
 if (objTopicObjectiveEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.IdCurrEduCls);
 var strIdCurrEduCls = objTopicObjectiveEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objTopicObjectiveEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.PdfContent);
 var strPdfContent = objTopicObjectiveEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objTopicObjectiveEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.PdfPageNum);
 arrValueListForInsert.Add(objTopicObjectiveEN.PdfPageNum.ToString());
 }
 
 if (objTopicObjectiveEN.CitationCount !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.CitationCount);
 arrValueListForInsert.Add(objTopicObjectiveEN.CitationCount.ToString());
 }
 
 if (objTopicObjectiveEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.VersionCount);
 arrValueListForInsert.Add(objTopicObjectiveEN.VersionCount.ToString());
 }
 
 if (objTopicObjectiveEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.CreateDate);
 var strCreateDate = objTopicObjectiveEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objTopicObjectiveEN.ShareId !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.ShareId);
 var strShareId = objTopicObjectiveEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strShareId + "'");
 }
 
 if (objTopicObjectiveEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.UpdUser);
 var strUpdUser = objTopicObjectiveEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objTopicObjectiveEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.UpdDate);
 var strUpdDate = objTopicObjectiveEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objTopicObjectiveEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjective.Memo);
 var strMemo = objTopicObjectiveEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into TopicObjective");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTopicObjectiveDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewTopicObjectives(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTopicObjectiveDA.GetSpecSQLObj();
strSQL = "Select * from TopicObjective where TopicObjectiveId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "TopicObjective");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strTopicObjectiveId = oRow[conTopicObjective.TopicObjectiveId].ToString().Trim();
if (IsExist(strTopicObjectiveId))
{
 string strResult = "关键字变量值为:" + string.Format("TopicObjectiveId = {0}", strTopicObjectiveId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsTopicObjectiveEN._CurrTabName ].NewRow();
objRow[conTopicObjective.TopicObjectiveId] = oRow[conTopicObjective.TopicObjectiveId].ToString().Trim(); //客观Id
objRow[conTopicObjective.ObjectiveName] = oRow[conTopicObjective.ObjectiveName].ToString().Trim(); //客观名称
objRow[conTopicObjective.ObjectiveContent] = oRow[conTopicObjective.ObjectiveContent].ToString().Trim(); //客观内容
objRow[conTopicObjective.ObjectiveType] = oRow[conTopicObjective.ObjectiveType].ToString().Trim(); //客观类型
objRow[conTopicObjective.SourceId] = oRow[conTopicObjective.SourceId].ToString().Trim(); //来源Id
objRow[conTopicObjective.Conclusion] = oRow[conTopicObjective.Conclusion].ToString().Trim(); //结论
objRow[conTopicObjective.IsSubmit] = oRow[conTopicObjective.IsSubmit].ToString().Trim(); //是否提交
objRow[conTopicObjective.AppraiseCount] = oRow[conTopicObjective.AppraiseCount].ToString().Trim(); //评论数
objRow[conTopicObjective.OkCount] = oRow[conTopicObjective.OkCount].ToString().Trim(); //点赞统计
objRow[conTopicObjective.Score] = oRow[conTopicObjective.Score].ToString().Trim(); //评分
objRow[conTopicObjective.StuScore] = oRow[conTopicObjective.StuScore].ToString().Trim(); //学生平均分
objRow[conTopicObjective.TeaScore] = oRow[conTopicObjective.TeaScore].ToString().Trim(); //教师评分
objRow[conTopicObjective.IdCurrEduCls] = oRow[conTopicObjective.IdCurrEduCls].ToString().Trim(); //教学班流水号
objRow[conTopicObjective.PdfContent] = oRow[conTopicObjective.PdfContent].ToString().Trim(); //Pdf内容
objRow[conTopicObjective.PdfPageNum] = oRow[conTopicObjective.PdfPageNum].ToString().Trim(); //Pdf页码
objRow[conTopicObjective.CitationCount] = oRow[conTopicObjective.CitationCount].ToString().Trim(); //引用统计
objRow[conTopicObjective.VersionCount] = oRow[conTopicObjective.VersionCount].ToString().Trim(); //版本统计
objRow[conTopicObjective.CreateDate] = oRow[conTopicObjective.CreateDate].ToString().Trim(); //建立日期
objRow[conTopicObjective.ShareId] = oRow[conTopicObjective.ShareId].ToString().Trim(); //分享Id
objRow[conTopicObjective.UpdUser] = oRow[conTopicObjective.UpdUser].ToString().Trim(); //修改人
objRow[conTopicObjective.UpdDate] = oRow[conTopicObjective.UpdDate].ToString().Trim(); //修改日期
objRow[conTopicObjective.Memo] = oRow[conTopicObjective.Memo].ToString().Trim(); //备注
 objDS.Tables[clsTopicObjectiveEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsTopicObjectiveEN._CurrTabName);
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
 /// <param name = "objTopicObjectiveEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsTopicObjectiveEN objTopicObjectiveEN)
{
 if (objTopicObjectiveEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTopicObjectiveEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTopicObjectiveDA.GetSpecSQLObj();
strSQL = "Select * from TopicObjective where TopicObjectiveId = " + "'"+ objTopicObjectiveEN.TopicObjectiveId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsTopicObjectiveEN._CurrTabName);
if (objDS.Tables[clsTopicObjectiveEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:TopicObjectiveId = " + "'"+ objTopicObjectiveEN.TopicObjectiveId+"'");
return false;
}
objRow = objDS.Tables[clsTopicObjectiveEN._CurrTabName].Rows[0];
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.TopicObjectiveId))
 {
objRow[conTopicObjective.TopicObjectiveId] = objTopicObjectiveEN.TopicObjectiveId; //客观Id
 }
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.ObjectiveName))
 {
objRow[conTopicObjective.ObjectiveName] = objTopicObjectiveEN.ObjectiveName; //客观名称
 }
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.ObjectiveContent))
 {
objRow[conTopicObjective.ObjectiveContent] = objTopicObjectiveEN.ObjectiveContent; //客观内容
 }
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.ObjectiveType))
 {
objRow[conTopicObjective.ObjectiveType] = objTopicObjectiveEN.ObjectiveType; //客观类型
 }
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.SourceId))
 {
objRow[conTopicObjective.SourceId] = objTopicObjectiveEN.SourceId; //来源Id
 }
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.Conclusion))
 {
objRow[conTopicObjective.Conclusion] = objTopicObjectiveEN.Conclusion; //结论
 }
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.IsSubmit))
 {
objRow[conTopicObjective.IsSubmit] = objTopicObjectiveEN.IsSubmit; //是否提交
 }
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.AppraiseCount))
 {
objRow[conTopicObjective.AppraiseCount] = objTopicObjectiveEN.AppraiseCount; //评论数
 }
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.OkCount))
 {
objRow[conTopicObjective.OkCount] = objTopicObjectiveEN.OkCount; //点赞统计
 }
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.Score))
 {
objRow[conTopicObjective.Score] = objTopicObjectiveEN.Score; //评分
 }
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.StuScore))
 {
objRow[conTopicObjective.StuScore] = objTopicObjectiveEN.StuScore; //学生平均分
 }
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.TeaScore))
 {
objRow[conTopicObjective.TeaScore] = objTopicObjectiveEN.TeaScore; //教师评分
 }
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.IdCurrEduCls))
 {
objRow[conTopicObjective.IdCurrEduCls] = objTopicObjectiveEN.IdCurrEduCls; //教学班流水号
 }
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.PdfContent))
 {
objRow[conTopicObjective.PdfContent] = objTopicObjectiveEN.PdfContent; //Pdf内容
 }
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.PdfPageNum))
 {
objRow[conTopicObjective.PdfPageNum] = objTopicObjectiveEN.PdfPageNum; //Pdf页码
 }
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.CitationCount))
 {
objRow[conTopicObjective.CitationCount] = objTopicObjectiveEN.CitationCount; //引用统计
 }
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.VersionCount))
 {
objRow[conTopicObjective.VersionCount] = objTopicObjectiveEN.VersionCount; //版本统计
 }
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.CreateDate))
 {
objRow[conTopicObjective.CreateDate] = objTopicObjectiveEN.CreateDate; //建立日期
 }
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.ShareId))
 {
objRow[conTopicObjective.ShareId] = objTopicObjectiveEN.ShareId; //分享Id
 }
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.UpdUser))
 {
objRow[conTopicObjective.UpdUser] = objTopicObjectiveEN.UpdUser; //修改人
 }
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.UpdDate))
 {
objRow[conTopicObjective.UpdDate] = objTopicObjectiveEN.UpdDate; //修改日期
 }
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.Memo))
 {
objRow[conTopicObjective.Memo] = objTopicObjectiveEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsTopicObjectiveEN._CurrTabName);
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
 /// <param name = "objTopicObjectiveEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsTopicObjectiveEN objTopicObjectiveEN)
{
 if (objTopicObjectiveEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTopicObjectiveEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTopicObjectiveDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update TopicObjective Set ");
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.ObjectiveName))
 {
 if (objTopicObjectiveEN.ObjectiveName !=  null)
 {
 var strObjectiveName = objTopicObjectiveEN.ObjectiveName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strObjectiveName, conTopicObjective.ObjectiveName); //客观名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjective.ObjectiveName); //客观名称
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.ObjectiveContent))
 {
 if (objTopicObjectiveEN.ObjectiveContent !=  null)
 {
 var strObjectiveContent = objTopicObjectiveEN.ObjectiveContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strObjectiveContent, conTopicObjective.ObjectiveContent); //客观内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjective.ObjectiveContent); //客观内容
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.ObjectiveType))
 {
 if (objTopicObjectiveEN.ObjectiveType !=  null)
 {
 var strObjectiveType = objTopicObjectiveEN.ObjectiveType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strObjectiveType, conTopicObjective.ObjectiveType); //客观类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjective.ObjectiveType); //客观类型
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.SourceId))
 {
 if (objTopicObjectiveEN.SourceId !=  null)
 {
 var strSourceId = objTopicObjectiveEN.SourceId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSourceId, conTopicObjective.SourceId); //来源Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjective.SourceId); //来源Id
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.Conclusion))
 {
 if (objTopicObjectiveEN.Conclusion !=  null)
 {
 var strConclusion = objTopicObjectiveEN.Conclusion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strConclusion, conTopicObjective.Conclusion); //结论
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjective.Conclusion); //结论
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTopicObjectiveEN.IsSubmit == true?"1":"0", conTopicObjective.IsSubmit); //是否提交
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.AppraiseCount))
 {
 if (objTopicObjectiveEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTopicObjectiveEN.AppraiseCount, conTopicObjective.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjective.AppraiseCount); //评论数
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.OkCount))
 {
 if (objTopicObjectiveEN.OkCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTopicObjectiveEN.OkCount, conTopicObjective.OkCount); //点赞统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjective.OkCount); //点赞统计
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.Score))
 {
 if (objTopicObjectiveEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTopicObjectiveEN.Score, conTopicObjective.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjective.Score); //评分
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.StuScore))
 {
 if (objTopicObjectiveEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTopicObjectiveEN.StuScore, conTopicObjective.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjective.StuScore); //学生平均分
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.TeaScore))
 {
 if (objTopicObjectiveEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTopicObjectiveEN.TeaScore, conTopicObjective.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjective.TeaScore); //教师评分
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.IdCurrEduCls))
 {
 if (objTopicObjectiveEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objTopicObjectiveEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conTopicObjective.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjective.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.PdfContent))
 {
 if (objTopicObjectiveEN.PdfContent !=  null)
 {
 var strPdfContent = objTopicObjectiveEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfContent, conTopicObjective.PdfContent); //Pdf内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjective.PdfContent); //Pdf内容
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.PdfPageNum))
 {
 if (objTopicObjectiveEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTopicObjectiveEN.PdfPageNum, conTopicObjective.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjective.PdfPageNum); //Pdf页码
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.CitationCount))
 {
 if (objTopicObjectiveEN.CitationCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTopicObjectiveEN.CitationCount, conTopicObjective.CitationCount); //引用统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjective.CitationCount); //引用统计
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.VersionCount))
 {
 if (objTopicObjectiveEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTopicObjectiveEN.VersionCount, conTopicObjective.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjective.VersionCount); //版本统计
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.CreateDate))
 {
 if (objTopicObjectiveEN.CreateDate !=  null)
 {
 var strCreateDate = objTopicObjectiveEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateDate, conTopicObjective.CreateDate); //建立日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjective.CreateDate); //建立日期
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.ShareId))
 {
 if (objTopicObjectiveEN.ShareId !=  null)
 {
 var strShareId = objTopicObjectiveEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strShareId, conTopicObjective.ShareId); //分享Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjective.ShareId); //分享Id
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.UpdUser))
 {
 if (objTopicObjectiveEN.UpdUser !=  null)
 {
 var strUpdUser = objTopicObjectiveEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conTopicObjective.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjective.UpdUser); //修改人
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.UpdDate))
 {
 if (objTopicObjectiveEN.UpdDate !=  null)
 {
 var strUpdDate = objTopicObjectiveEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conTopicObjective.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjective.UpdDate); //修改日期
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.Memo))
 {
 if (objTopicObjectiveEN.Memo !=  null)
 {
 var strMemo = objTopicObjectiveEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conTopicObjective.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjective.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where TopicObjectiveId = '{0}'", objTopicObjectiveEN.TopicObjectiveId); 
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
 /// <param name = "objTopicObjectiveEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsTopicObjectiveEN objTopicObjectiveEN, string strCondition)
{
 if (objTopicObjectiveEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTopicObjectiveEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTopicObjectiveDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update TopicObjective Set ");
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.ObjectiveName))
 {
 if (objTopicObjectiveEN.ObjectiveName !=  null)
 {
 var strObjectiveName = objTopicObjectiveEN.ObjectiveName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ObjectiveName = '{0}',", strObjectiveName); //客观名称
 }
 else
 {
 sbSQL.Append(" ObjectiveName = null,"); //客观名称
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.ObjectiveContent))
 {
 if (objTopicObjectiveEN.ObjectiveContent !=  null)
 {
 var strObjectiveContent = objTopicObjectiveEN.ObjectiveContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ObjectiveContent = '{0}',", strObjectiveContent); //客观内容
 }
 else
 {
 sbSQL.Append(" ObjectiveContent = null,"); //客观内容
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.ObjectiveType))
 {
 if (objTopicObjectiveEN.ObjectiveType !=  null)
 {
 var strObjectiveType = objTopicObjectiveEN.ObjectiveType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ObjectiveType = '{0}',", strObjectiveType); //客观类型
 }
 else
 {
 sbSQL.Append(" ObjectiveType = null,"); //客观类型
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.SourceId))
 {
 if (objTopicObjectiveEN.SourceId !=  null)
 {
 var strSourceId = objTopicObjectiveEN.SourceId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SourceId = '{0}',", strSourceId); //来源Id
 }
 else
 {
 sbSQL.Append(" SourceId = null,"); //来源Id
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.Conclusion))
 {
 if (objTopicObjectiveEN.Conclusion !=  null)
 {
 var strConclusion = objTopicObjectiveEN.Conclusion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Conclusion = '{0}',", strConclusion); //结论
 }
 else
 {
 sbSQL.Append(" Conclusion = null,"); //结论
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objTopicObjectiveEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.AppraiseCount))
 {
 if (objTopicObjectiveEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTopicObjectiveEN.AppraiseCount, conTopicObjective.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjective.AppraiseCount); //评论数
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.OkCount))
 {
 if (objTopicObjectiveEN.OkCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTopicObjectiveEN.OkCount, conTopicObjective.OkCount); //点赞统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjective.OkCount); //点赞统计
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.Score))
 {
 if (objTopicObjectiveEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTopicObjectiveEN.Score, conTopicObjective.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjective.Score); //评分
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.StuScore))
 {
 if (objTopicObjectiveEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTopicObjectiveEN.StuScore, conTopicObjective.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjective.StuScore); //学生平均分
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.TeaScore))
 {
 if (objTopicObjectiveEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTopicObjectiveEN.TeaScore, conTopicObjective.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjective.TeaScore); //教师评分
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.IdCurrEduCls))
 {
 if (objTopicObjectiveEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objTopicObjectiveEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.PdfContent))
 {
 if (objTopicObjectiveEN.PdfContent !=  null)
 {
 var strPdfContent = objTopicObjectiveEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfContent = '{0}',", strPdfContent); //Pdf内容
 }
 else
 {
 sbSQL.Append(" PdfContent = null,"); //Pdf内容
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.PdfPageNum))
 {
 if (objTopicObjectiveEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTopicObjectiveEN.PdfPageNum, conTopicObjective.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjective.PdfPageNum); //Pdf页码
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.CitationCount))
 {
 if (objTopicObjectiveEN.CitationCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTopicObjectiveEN.CitationCount, conTopicObjective.CitationCount); //引用统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjective.CitationCount); //引用统计
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.VersionCount))
 {
 if (objTopicObjectiveEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTopicObjectiveEN.VersionCount, conTopicObjective.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjective.VersionCount); //版本统计
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.CreateDate))
 {
 if (objTopicObjectiveEN.CreateDate !=  null)
 {
 var strCreateDate = objTopicObjectiveEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateDate = '{0}',", strCreateDate); //建立日期
 }
 else
 {
 sbSQL.Append(" CreateDate = null,"); //建立日期
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.ShareId))
 {
 if (objTopicObjectiveEN.ShareId !=  null)
 {
 var strShareId = objTopicObjectiveEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ShareId = '{0}',", strShareId); //分享Id
 }
 else
 {
 sbSQL.Append(" ShareId = null,"); //分享Id
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.UpdUser))
 {
 if (objTopicObjectiveEN.UpdUser !=  null)
 {
 var strUpdUser = objTopicObjectiveEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.UpdDate))
 {
 if (objTopicObjectiveEN.UpdDate !=  null)
 {
 var strUpdDate = objTopicObjectiveEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.Memo))
 {
 if (objTopicObjectiveEN.Memo !=  null)
 {
 var strMemo = objTopicObjectiveEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objTopicObjectiveEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsTopicObjectiveEN objTopicObjectiveEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objTopicObjectiveEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTopicObjectiveEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTopicObjectiveDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update TopicObjective Set ");
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.ObjectiveName))
 {
 if (objTopicObjectiveEN.ObjectiveName !=  null)
 {
 var strObjectiveName = objTopicObjectiveEN.ObjectiveName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ObjectiveName = '{0}',", strObjectiveName); //客观名称
 }
 else
 {
 sbSQL.Append(" ObjectiveName = null,"); //客观名称
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.ObjectiveContent))
 {
 if (objTopicObjectiveEN.ObjectiveContent !=  null)
 {
 var strObjectiveContent = objTopicObjectiveEN.ObjectiveContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ObjectiveContent = '{0}',", strObjectiveContent); //客观内容
 }
 else
 {
 sbSQL.Append(" ObjectiveContent = null,"); //客观内容
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.ObjectiveType))
 {
 if (objTopicObjectiveEN.ObjectiveType !=  null)
 {
 var strObjectiveType = objTopicObjectiveEN.ObjectiveType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ObjectiveType = '{0}',", strObjectiveType); //客观类型
 }
 else
 {
 sbSQL.Append(" ObjectiveType = null,"); //客观类型
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.SourceId))
 {
 if (objTopicObjectiveEN.SourceId !=  null)
 {
 var strSourceId = objTopicObjectiveEN.SourceId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SourceId = '{0}',", strSourceId); //来源Id
 }
 else
 {
 sbSQL.Append(" SourceId = null,"); //来源Id
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.Conclusion))
 {
 if (objTopicObjectiveEN.Conclusion !=  null)
 {
 var strConclusion = objTopicObjectiveEN.Conclusion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Conclusion = '{0}',", strConclusion); //结论
 }
 else
 {
 sbSQL.Append(" Conclusion = null,"); //结论
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objTopicObjectiveEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.AppraiseCount))
 {
 if (objTopicObjectiveEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTopicObjectiveEN.AppraiseCount, conTopicObjective.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjective.AppraiseCount); //评论数
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.OkCount))
 {
 if (objTopicObjectiveEN.OkCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTopicObjectiveEN.OkCount, conTopicObjective.OkCount); //点赞统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjective.OkCount); //点赞统计
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.Score))
 {
 if (objTopicObjectiveEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTopicObjectiveEN.Score, conTopicObjective.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjective.Score); //评分
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.StuScore))
 {
 if (objTopicObjectiveEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTopicObjectiveEN.StuScore, conTopicObjective.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjective.StuScore); //学生平均分
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.TeaScore))
 {
 if (objTopicObjectiveEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTopicObjectiveEN.TeaScore, conTopicObjective.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjective.TeaScore); //教师评分
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.IdCurrEduCls))
 {
 if (objTopicObjectiveEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objTopicObjectiveEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.PdfContent))
 {
 if (objTopicObjectiveEN.PdfContent !=  null)
 {
 var strPdfContent = objTopicObjectiveEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfContent = '{0}',", strPdfContent); //Pdf内容
 }
 else
 {
 sbSQL.Append(" PdfContent = null,"); //Pdf内容
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.PdfPageNum))
 {
 if (objTopicObjectiveEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTopicObjectiveEN.PdfPageNum, conTopicObjective.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjective.PdfPageNum); //Pdf页码
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.CitationCount))
 {
 if (objTopicObjectiveEN.CitationCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTopicObjectiveEN.CitationCount, conTopicObjective.CitationCount); //引用统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjective.CitationCount); //引用统计
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.VersionCount))
 {
 if (objTopicObjectiveEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTopicObjectiveEN.VersionCount, conTopicObjective.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjective.VersionCount); //版本统计
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.CreateDate))
 {
 if (objTopicObjectiveEN.CreateDate !=  null)
 {
 var strCreateDate = objTopicObjectiveEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateDate = '{0}',", strCreateDate); //建立日期
 }
 else
 {
 sbSQL.Append(" CreateDate = null,"); //建立日期
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.ShareId))
 {
 if (objTopicObjectiveEN.ShareId !=  null)
 {
 var strShareId = objTopicObjectiveEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ShareId = '{0}',", strShareId); //分享Id
 }
 else
 {
 sbSQL.Append(" ShareId = null,"); //分享Id
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.UpdUser))
 {
 if (objTopicObjectiveEN.UpdUser !=  null)
 {
 var strUpdUser = objTopicObjectiveEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.UpdDate))
 {
 if (objTopicObjectiveEN.UpdDate !=  null)
 {
 var strUpdDate = objTopicObjectiveEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.Memo))
 {
 if (objTopicObjectiveEN.Memo !=  null)
 {
 var strMemo = objTopicObjectiveEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objTopicObjectiveEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsTopicObjectiveEN objTopicObjectiveEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objTopicObjectiveEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTopicObjectiveEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTopicObjectiveDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update TopicObjective Set ");
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.ObjectiveName))
 {
 if (objTopicObjectiveEN.ObjectiveName !=  null)
 {
 var strObjectiveName = objTopicObjectiveEN.ObjectiveName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strObjectiveName, conTopicObjective.ObjectiveName); //客观名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjective.ObjectiveName); //客观名称
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.ObjectiveContent))
 {
 if (objTopicObjectiveEN.ObjectiveContent !=  null)
 {
 var strObjectiveContent = objTopicObjectiveEN.ObjectiveContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strObjectiveContent, conTopicObjective.ObjectiveContent); //客观内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjective.ObjectiveContent); //客观内容
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.ObjectiveType))
 {
 if (objTopicObjectiveEN.ObjectiveType !=  null)
 {
 var strObjectiveType = objTopicObjectiveEN.ObjectiveType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strObjectiveType, conTopicObjective.ObjectiveType); //客观类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjective.ObjectiveType); //客观类型
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.SourceId))
 {
 if (objTopicObjectiveEN.SourceId !=  null)
 {
 var strSourceId = objTopicObjectiveEN.SourceId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSourceId, conTopicObjective.SourceId); //来源Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjective.SourceId); //来源Id
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.Conclusion))
 {
 if (objTopicObjectiveEN.Conclusion !=  null)
 {
 var strConclusion = objTopicObjectiveEN.Conclusion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strConclusion, conTopicObjective.Conclusion); //结论
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjective.Conclusion); //结论
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTopicObjectiveEN.IsSubmit == true?"1":"0", conTopicObjective.IsSubmit); //是否提交
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.AppraiseCount))
 {
 if (objTopicObjectiveEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTopicObjectiveEN.AppraiseCount, conTopicObjective.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjective.AppraiseCount); //评论数
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.OkCount))
 {
 if (objTopicObjectiveEN.OkCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTopicObjectiveEN.OkCount, conTopicObjective.OkCount); //点赞统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjective.OkCount); //点赞统计
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.Score))
 {
 if (objTopicObjectiveEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTopicObjectiveEN.Score, conTopicObjective.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjective.Score); //评分
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.StuScore))
 {
 if (objTopicObjectiveEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTopicObjectiveEN.StuScore, conTopicObjective.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjective.StuScore); //学生平均分
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.TeaScore))
 {
 if (objTopicObjectiveEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTopicObjectiveEN.TeaScore, conTopicObjective.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjective.TeaScore); //教师评分
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.IdCurrEduCls))
 {
 if (objTopicObjectiveEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objTopicObjectiveEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conTopicObjective.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjective.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.PdfContent))
 {
 if (objTopicObjectiveEN.PdfContent !=  null)
 {
 var strPdfContent = objTopicObjectiveEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfContent, conTopicObjective.PdfContent); //Pdf内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjective.PdfContent); //Pdf内容
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.PdfPageNum))
 {
 if (objTopicObjectiveEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTopicObjectiveEN.PdfPageNum, conTopicObjective.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjective.PdfPageNum); //Pdf页码
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.CitationCount))
 {
 if (objTopicObjectiveEN.CitationCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTopicObjectiveEN.CitationCount, conTopicObjective.CitationCount); //引用统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjective.CitationCount); //引用统计
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.VersionCount))
 {
 if (objTopicObjectiveEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTopicObjectiveEN.VersionCount, conTopicObjective.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjective.VersionCount); //版本统计
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.CreateDate))
 {
 if (objTopicObjectiveEN.CreateDate !=  null)
 {
 var strCreateDate = objTopicObjectiveEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateDate, conTopicObjective.CreateDate); //建立日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjective.CreateDate); //建立日期
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.ShareId))
 {
 if (objTopicObjectiveEN.ShareId !=  null)
 {
 var strShareId = objTopicObjectiveEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strShareId, conTopicObjective.ShareId); //分享Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjective.ShareId); //分享Id
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.UpdUser))
 {
 if (objTopicObjectiveEN.UpdUser !=  null)
 {
 var strUpdUser = objTopicObjectiveEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conTopicObjective.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjective.UpdUser); //修改人
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.UpdDate))
 {
 if (objTopicObjectiveEN.UpdDate !=  null)
 {
 var strUpdDate = objTopicObjectiveEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conTopicObjective.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjective.UpdDate); //修改日期
 }
 }
 
 if (objTopicObjectiveEN.IsUpdated(conTopicObjective.Memo))
 {
 if (objTopicObjectiveEN.Memo !=  null)
 {
 var strMemo = objTopicObjectiveEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conTopicObjective.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjective.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where TopicObjectiveId = '{0}'", objTopicObjectiveEN.TopicObjectiveId); 
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
 /// <param name = "strTopicObjectiveId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strTopicObjectiveId) 
{
CheckPrimaryKey(strTopicObjectiveId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTopicObjectiveDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strTopicObjectiveId,
};
 objSQL.ExecSP("TopicObjective_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strTopicObjectiveId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strTopicObjectiveId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strTopicObjectiveId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTopicObjectiveDA.GetSpecSQLObj();
//删除TopicObjective本表中与当前对象有关的记录
strSQL = strSQL + "Delete from TopicObjective where TopicObjectiveId = " + "'"+ strTopicObjectiveId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelTopicObjective(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTopicObjectiveDA.GetSpecSQLObj();
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
//删除TopicObjective本表中与当前对象有关的记录
strSQL = strSQL + "Delete from TopicObjective where TopicObjectiveId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strTopicObjectiveId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strTopicObjectiveId) 
{
CheckPrimaryKey(strTopicObjectiveId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTopicObjectiveDA.GetSpecSQLObj();
//删除TopicObjective本表中与当前对象有关的记录
strSQL = strSQL + "Delete from TopicObjective where TopicObjectiveId = " + "'"+ strTopicObjectiveId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelTopicObjective(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsTopicObjectiveDA: DelTopicObjective)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTopicObjectiveDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from TopicObjective where " + strCondition ;
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
public bool DelTopicObjectiveWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsTopicObjectiveDA: DelTopicObjectiveWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTopicObjectiveDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from TopicObjective where " + strCondition ;
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
 /// <param name = "objTopicObjectiveENS">源对象</param>
 /// <param name = "objTopicObjectiveENT">目标对象</param>
public void CopyTo(clsTopicObjectiveEN objTopicObjectiveENS, clsTopicObjectiveEN objTopicObjectiveENT)
{
objTopicObjectiveENT.TopicObjectiveId = objTopicObjectiveENS.TopicObjectiveId; //客观Id
objTopicObjectiveENT.ObjectiveName = objTopicObjectiveENS.ObjectiveName; //客观名称
objTopicObjectiveENT.ObjectiveContent = objTopicObjectiveENS.ObjectiveContent; //客观内容
objTopicObjectiveENT.ObjectiveType = objTopicObjectiveENS.ObjectiveType; //客观类型
objTopicObjectiveENT.SourceId = objTopicObjectiveENS.SourceId; //来源Id
objTopicObjectiveENT.Conclusion = objTopicObjectiveENS.Conclusion; //结论
objTopicObjectiveENT.IsSubmit = objTopicObjectiveENS.IsSubmit; //是否提交
objTopicObjectiveENT.AppraiseCount = objTopicObjectiveENS.AppraiseCount; //评论数
objTopicObjectiveENT.OkCount = objTopicObjectiveENS.OkCount; //点赞统计
objTopicObjectiveENT.Score = objTopicObjectiveENS.Score; //评分
objTopicObjectiveENT.StuScore = objTopicObjectiveENS.StuScore; //学生平均分
objTopicObjectiveENT.TeaScore = objTopicObjectiveENS.TeaScore; //教师评分
objTopicObjectiveENT.IdCurrEduCls = objTopicObjectiveENS.IdCurrEduCls; //教学班流水号
objTopicObjectiveENT.PdfContent = objTopicObjectiveENS.PdfContent; //Pdf内容
objTopicObjectiveENT.PdfPageNum = objTopicObjectiveENS.PdfPageNum; //Pdf页码
objTopicObjectiveENT.CitationCount = objTopicObjectiveENS.CitationCount; //引用统计
objTopicObjectiveENT.VersionCount = objTopicObjectiveENS.VersionCount; //版本统计
objTopicObjectiveENT.CreateDate = objTopicObjectiveENS.CreateDate; //建立日期
objTopicObjectiveENT.ShareId = objTopicObjectiveENS.ShareId; //分享Id
objTopicObjectiveENT.UpdUser = objTopicObjectiveENS.UpdUser; //修改人
objTopicObjectiveENT.UpdDate = objTopicObjectiveENS.UpdDate; //修改日期
objTopicObjectiveENT.Memo = objTopicObjectiveENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsTopicObjectiveEN objTopicObjectiveEN)
{
//检查字段不能为空(NULL)
//检查字段长度
clsCheckSql.CheckFieldLen(objTopicObjectiveEN.TopicObjectiveId, 8, conTopicObjective.TopicObjectiveId);
clsCheckSql.CheckFieldLen(objTopicObjectiveEN.ObjectiveName, 500, conTopicObjective.ObjectiveName);
clsCheckSql.CheckFieldLen(objTopicObjectiveEN.ObjectiveType, 2, conTopicObjective.ObjectiveType);
clsCheckSql.CheckFieldLen(objTopicObjectiveEN.SourceId, 10, conTopicObjective.SourceId);
clsCheckSql.CheckFieldLen(objTopicObjectiveEN.Conclusion, 5000, conTopicObjective.Conclusion);
clsCheckSql.CheckFieldLen(objTopicObjectiveEN.IdCurrEduCls, 8, conTopicObjective.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objTopicObjectiveEN.PdfContent, 2000, conTopicObjective.PdfContent);
clsCheckSql.CheckFieldLen(objTopicObjectiveEN.CreateDate, 20, conTopicObjective.CreateDate);
clsCheckSql.CheckFieldLen(objTopicObjectiveEN.ShareId, 2, conTopicObjective.ShareId);
clsCheckSql.CheckFieldLen(objTopicObjectiveEN.UpdUser, 20, conTopicObjective.UpdUser);
clsCheckSql.CheckFieldLen(objTopicObjectiveEN.UpdDate, 20, conTopicObjective.UpdDate);
clsCheckSql.CheckFieldLen(objTopicObjectiveEN.Memo, 1000, conTopicObjective.Memo);
//检查字段外键固定长度
 objTopicObjectiveEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsTopicObjectiveEN objTopicObjectiveEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objTopicObjectiveEN.ObjectiveName, 500, conTopicObjective.ObjectiveName);
clsCheckSql.CheckFieldLen(objTopicObjectiveEN.ObjectiveType, 2, conTopicObjective.ObjectiveType);
clsCheckSql.CheckFieldLen(objTopicObjectiveEN.SourceId, 10, conTopicObjective.SourceId);
clsCheckSql.CheckFieldLen(objTopicObjectiveEN.Conclusion, 5000, conTopicObjective.Conclusion);
clsCheckSql.CheckFieldLen(objTopicObjectiveEN.IdCurrEduCls, 8, conTopicObjective.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objTopicObjectiveEN.PdfContent, 2000, conTopicObjective.PdfContent);
clsCheckSql.CheckFieldLen(objTopicObjectiveEN.CreateDate, 20, conTopicObjective.CreateDate);
clsCheckSql.CheckFieldLen(objTopicObjectiveEN.ShareId, 2, conTopicObjective.ShareId);
clsCheckSql.CheckFieldLen(objTopicObjectiveEN.UpdUser, 20, conTopicObjective.UpdUser);
clsCheckSql.CheckFieldLen(objTopicObjectiveEN.UpdDate, 20, conTopicObjective.UpdDate);
clsCheckSql.CheckFieldLen(objTopicObjectiveEN.Memo, 1000, conTopicObjective.Memo);
//检查外键字段长度
 objTopicObjectiveEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsTopicObjectiveEN objTopicObjectiveEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objTopicObjectiveEN.TopicObjectiveId, 8, conTopicObjective.TopicObjectiveId);
clsCheckSql.CheckFieldLen(objTopicObjectiveEN.ObjectiveName, 500, conTopicObjective.ObjectiveName);
clsCheckSql.CheckFieldLen(objTopicObjectiveEN.ObjectiveType, 2, conTopicObjective.ObjectiveType);
clsCheckSql.CheckFieldLen(objTopicObjectiveEN.SourceId, 10, conTopicObjective.SourceId);
clsCheckSql.CheckFieldLen(objTopicObjectiveEN.Conclusion, 5000, conTopicObjective.Conclusion);
clsCheckSql.CheckFieldLen(objTopicObjectiveEN.IdCurrEduCls, 8, conTopicObjective.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objTopicObjectiveEN.PdfContent, 2000, conTopicObjective.PdfContent);
clsCheckSql.CheckFieldLen(objTopicObjectiveEN.CreateDate, 20, conTopicObjective.CreateDate);
clsCheckSql.CheckFieldLen(objTopicObjectiveEN.ShareId, 2, conTopicObjective.ShareId);
clsCheckSql.CheckFieldLen(objTopicObjectiveEN.UpdUser, 20, conTopicObjective.UpdUser);
clsCheckSql.CheckFieldLen(objTopicObjectiveEN.UpdDate, 20, conTopicObjective.UpdDate);
clsCheckSql.CheckFieldLen(objTopicObjectiveEN.Memo, 1000, conTopicObjective.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objTopicObjectiveEN.TopicObjectiveId, conTopicObjective.TopicObjectiveId);
clsCheckSql.CheckSqlInjection4Field(objTopicObjectiveEN.ObjectiveName, conTopicObjective.ObjectiveName);
clsCheckSql.CheckSqlInjection4Field(objTopicObjectiveEN.ObjectiveType, conTopicObjective.ObjectiveType);
clsCheckSql.CheckSqlInjection4Field(objTopicObjectiveEN.SourceId, conTopicObjective.SourceId);
clsCheckSql.CheckSqlInjection4Field(objTopicObjectiveEN.Conclusion, conTopicObjective.Conclusion);
clsCheckSql.CheckSqlInjection4Field(objTopicObjectiveEN.IdCurrEduCls, conTopicObjective.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objTopicObjectiveEN.PdfContent, conTopicObjective.PdfContent);
clsCheckSql.CheckSqlInjection4Field(objTopicObjectiveEN.CreateDate, conTopicObjective.CreateDate);
clsCheckSql.CheckSqlInjection4Field(objTopicObjectiveEN.ShareId, conTopicObjective.ShareId);
clsCheckSql.CheckSqlInjection4Field(objTopicObjectiveEN.UpdUser, conTopicObjective.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objTopicObjectiveEN.UpdDate, conTopicObjective.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objTopicObjectiveEN.Memo, conTopicObjective.Memo);
//检查外键字段长度
 objTopicObjectiveEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetTopicObjectiveId()
{
//获取某学院所有专业信息
string strSQL = "select TopicObjectiveId, ObjectiveName from TopicObjective ";
 clsSpecSQLforSql mySql = clsTopicObjectiveDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--TopicObjective(主题客观表),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objTopicObjectiveEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsTopicObjectiveEN objTopicObjectiveEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 if (objTopicObjectiveEN.ObjectiveName == null)
{
 sbCondition.AppendFormat(" and ObjectiveName is null");
}
else
{
 sbCondition.AppendFormat(" and ObjectiveName = '{0}'", objTopicObjectiveEN.ObjectiveName);
}
 if (objTopicObjectiveEN.IdCurrEduCls == null)
{
 sbCondition.AppendFormat(" and IdCurrEduCls is null");
}
else
{
 sbCondition.AppendFormat(" and IdCurrEduCls = '{0}'", objTopicObjectiveEN.IdCurrEduCls);
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
 objSQL = clsTopicObjectiveDA.GetSpecSQLObj();
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
 objSQL = clsTopicObjectiveDA.GetSpecSQLObj();
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
 objSQL = clsTopicObjectiveDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsTopicObjectiveEN._CurrTabName);
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
 objSQL = clsTopicObjectiveDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsTopicObjectiveEN._CurrTabName, strCondition);
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
 objSQL = clsTopicObjectiveDA.GetSpecSQLObj();
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
 objSQL = clsTopicObjectiveDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}