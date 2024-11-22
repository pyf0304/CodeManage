
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsResearchTopicDA
 表名:ResearchTopic(01120546)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:04:30
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
 /// 研究主题(ResearchTopic)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsResearchTopicDA : clsCommBase4DA
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
 return clsResearchTopicEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsResearchTopicEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsResearchTopicEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsResearchTopicEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsResearchTopicEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strTopicId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strTopicId)
{
strTopicId = strTopicId.Replace("'", "''");
if (strTopicId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:ResearchTopic中,检查关键字,长度不正确!(clsResearchTopicDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strTopicId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:ResearchTopic中,关键字不能为空 或 null!(clsResearchTopicDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTopicId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsResearchTopicDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsResearchTopicDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResearchTopicDA.GetSpecSQLObj();
strSQL = "Select * from ResearchTopic where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_ResearchTopic(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsResearchTopicDA: GetDataTable_ResearchTopic)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResearchTopicDA.GetSpecSQLObj();
strSQL = "Select * from ResearchTopic where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsResearchTopicDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResearchTopicDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsResearchTopicDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResearchTopicDA.GetSpecSQLObj();
strSQL = "Select * from ResearchTopic where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsResearchTopicDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResearchTopicDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsResearchTopicDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResearchTopicDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ResearchTopic where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ResearchTopic where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsResearchTopicDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResearchTopicDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from ResearchTopic where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsResearchTopicDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResearchTopicDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} ResearchTopic.* from ResearchTopic Left Join {1} on {2} where {3} and ResearchTopic.TopicId not in (Select top {5} ResearchTopic.TopicId from ResearchTopic Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ResearchTopic where {1} and TopicId not in (Select top {2} TopicId from ResearchTopic where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ResearchTopic where {1} and TopicId not in (Select top {3} TopicId from ResearchTopic where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsResearchTopicDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResearchTopicDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} ResearchTopic.* from ResearchTopic Left Join {1} on {2} where {3} and ResearchTopic.TopicId not in (Select top {5} ResearchTopic.TopicId from ResearchTopic Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ResearchTopic where {1} and TopicId not in (Select top {2} TopicId from ResearchTopic where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ResearchTopic where {1} and TopicId not in (Select top {3} TopicId from ResearchTopic where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsResearchTopicEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsResearchTopicDA:GetObjLst)", objException.Message));
}
List<clsResearchTopicEN> arrObjLst = new List<clsResearchTopicEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResearchTopicDA.GetSpecSQLObj();
strSQL = "Select * from ResearchTopic where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsResearchTopicEN objResearchTopicEN = new clsResearchTopicEN();
try
{
objResearchTopicEN.TopicId = objRow[conResearchTopic.TopicId].ToString().Trim(); //主题Id
objResearchTopicEN.TopicName = objRow[conResearchTopic.TopicName] == DBNull.Value ? null : objRow[conResearchTopic.TopicName].ToString().Trim(); //栏目主题
objResearchTopicEN.TopicContent = objRow[conResearchTopic.TopicContent] == DBNull.Value ? null : objRow[conResearchTopic.TopicContent].ToString().Trim(); //主题内容
objResearchTopicEN.TopicProposePeople = objRow[conResearchTopic.TopicProposePeople] == DBNull.Value ? null : objRow[conResearchTopic.TopicProposePeople].ToString().Trim(); //主题提出人
objResearchTopicEN.OrderNum = objRow[conResearchTopic.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conResearchTopic.OrderNum].ToString().Trim()); //序号
objResearchTopicEN.IsSubmit = TransNullToBool(objRow[conResearchTopic.IsSubmit].ToString().Trim()); //是否提交
objResearchTopicEN.IdCurrEduCls = objRow[conResearchTopic.IdCurrEduCls] == DBNull.Value ? null : objRow[conResearchTopic.IdCurrEduCls].ToString().Trim(); //教学班流水号
objResearchTopicEN.UpdDate = objRow[conResearchTopic.UpdDate] == DBNull.Value ? null : objRow[conResearchTopic.UpdDate].ToString().Trim(); //修改日期
objResearchTopicEN.ShareId = objRow[conResearchTopic.ShareId].ToString().Trim(); //分享Id
objResearchTopicEN.UpdUser = objRow[conResearchTopic.UpdUser] == DBNull.Value ? null : objRow[conResearchTopic.UpdUser].ToString().Trim(); //修改人
objResearchTopicEN.Memo = objRow[conResearchTopic.Memo] == DBNull.Value ? null : objRow[conResearchTopic.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsResearchTopicDA: GetObjLst)", objException.Message));
}
objResearchTopicEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objResearchTopicEN);
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
public List<clsResearchTopicEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsResearchTopicDA:GetObjLstByTabName)", objException.Message));
}
List<clsResearchTopicEN> arrObjLst = new List<clsResearchTopicEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResearchTopicDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsResearchTopicEN objResearchTopicEN = new clsResearchTopicEN();
try
{
objResearchTopicEN.TopicId = objRow[conResearchTopic.TopicId].ToString().Trim(); //主题Id
objResearchTopicEN.TopicName = objRow[conResearchTopic.TopicName] == DBNull.Value ? null : objRow[conResearchTopic.TopicName].ToString().Trim(); //栏目主题
objResearchTopicEN.TopicContent = objRow[conResearchTopic.TopicContent] == DBNull.Value ? null : objRow[conResearchTopic.TopicContent].ToString().Trim(); //主题内容
objResearchTopicEN.TopicProposePeople = objRow[conResearchTopic.TopicProposePeople] == DBNull.Value ? null : objRow[conResearchTopic.TopicProposePeople].ToString().Trim(); //主题提出人
objResearchTopicEN.OrderNum = objRow[conResearchTopic.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conResearchTopic.OrderNum].ToString().Trim()); //序号
objResearchTopicEN.IsSubmit = TransNullToBool(objRow[conResearchTopic.IsSubmit].ToString().Trim()); //是否提交
objResearchTopicEN.IdCurrEduCls = objRow[conResearchTopic.IdCurrEduCls] == DBNull.Value ? null : objRow[conResearchTopic.IdCurrEduCls].ToString().Trim(); //教学班流水号
objResearchTopicEN.UpdDate = objRow[conResearchTopic.UpdDate] == DBNull.Value ? null : objRow[conResearchTopic.UpdDate].ToString().Trim(); //修改日期
objResearchTopicEN.ShareId = objRow[conResearchTopic.ShareId].ToString().Trim(); //分享Id
objResearchTopicEN.UpdUser = objRow[conResearchTopic.UpdUser] == DBNull.Value ? null : objRow[conResearchTopic.UpdUser].ToString().Trim(); //修改人
objResearchTopicEN.Memo = objRow[conResearchTopic.Memo] == DBNull.Value ? null : objRow[conResearchTopic.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsResearchTopicDA: GetObjLst)", objException.Message));
}
objResearchTopicEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objResearchTopicEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objResearchTopicEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetResearchTopic(ref clsResearchTopicEN objResearchTopicEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResearchTopicDA.GetSpecSQLObj();
strSQL = "Select * from ResearchTopic where TopicId = " + "'"+ objResearchTopicEN.TopicId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objResearchTopicEN.TopicId = objDT.Rows[0][conResearchTopic.TopicId].ToString().Trim(); //主题Id(字段类型:char,字段长度:8,是否可空:True)
 objResearchTopicEN.TopicName = objDT.Rows[0][conResearchTopic.TopicName].ToString().Trim(); //栏目主题(字段类型:varchar,字段长度:200,是否可空:True)
 objResearchTopicEN.TopicContent = objDT.Rows[0][conResearchTopic.TopicContent].ToString().Trim(); //主题内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objResearchTopicEN.TopicProposePeople = objDT.Rows[0][conResearchTopic.TopicProposePeople].ToString().Trim(); //主题提出人(字段类型:varchar,字段长度:50,是否可空:True)
 objResearchTopicEN.OrderNum = TransNullToInt(objDT.Rows[0][conResearchTopic.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objResearchTopicEN.IsSubmit = TransNullToBool(objDT.Rows[0][conResearchTopic.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objResearchTopicEN.IdCurrEduCls = objDT.Rows[0][conResearchTopic.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objResearchTopicEN.UpdDate = objDT.Rows[0][conResearchTopic.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objResearchTopicEN.ShareId = objDT.Rows[0][conResearchTopic.ShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objResearchTopicEN.UpdUser = objDT.Rows[0][conResearchTopic.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objResearchTopicEN.Memo = objDT.Rows[0][conResearchTopic.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsResearchTopicDA: GetResearchTopic)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strTopicId">表关键字</param>
 /// <returns>表对象</returns>
public clsResearchTopicEN GetObjByTopicId(string strTopicId)
{
CheckPrimaryKey(strTopicId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResearchTopicDA.GetSpecSQLObj();
strSQL = "Select * from ResearchTopic where TopicId = " + "'"+ strTopicId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsResearchTopicEN objResearchTopicEN = new clsResearchTopicEN();
try
{
 objResearchTopicEN.TopicId = objRow[conResearchTopic.TopicId].ToString().Trim(); //主题Id(字段类型:char,字段长度:8,是否可空:True)
 objResearchTopicEN.TopicName = objRow[conResearchTopic.TopicName] == DBNull.Value ? null : objRow[conResearchTopic.TopicName].ToString().Trim(); //栏目主题(字段类型:varchar,字段长度:200,是否可空:True)
 objResearchTopicEN.TopicContent = objRow[conResearchTopic.TopicContent] == DBNull.Value ? null : objRow[conResearchTopic.TopicContent].ToString().Trim(); //主题内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objResearchTopicEN.TopicProposePeople = objRow[conResearchTopic.TopicProposePeople] == DBNull.Value ? null : objRow[conResearchTopic.TopicProposePeople].ToString().Trim(); //主题提出人(字段类型:varchar,字段长度:50,是否可空:True)
 objResearchTopicEN.OrderNum = objRow[conResearchTopic.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conResearchTopic.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objResearchTopicEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conResearchTopic.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objResearchTopicEN.IdCurrEduCls = objRow[conResearchTopic.IdCurrEduCls] == DBNull.Value ? null : objRow[conResearchTopic.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objResearchTopicEN.UpdDate = objRow[conResearchTopic.UpdDate] == DBNull.Value ? null : objRow[conResearchTopic.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objResearchTopicEN.ShareId = objRow[conResearchTopic.ShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objResearchTopicEN.UpdUser = objRow[conResearchTopic.UpdUser] == DBNull.Value ? null : objRow[conResearchTopic.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objResearchTopicEN.Memo = objRow[conResearchTopic.Memo] == DBNull.Value ? null : objRow[conResearchTopic.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsResearchTopicDA: GetObjByTopicId)", objException.Message));
}
return objResearchTopicEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsResearchTopicEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsResearchTopicDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResearchTopicDA.GetSpecSQLObj();
strSQL = "Select * from ResearchTopic where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsResearchTopicEN objResearchTopicEN = new clsResearchTopicEN()
{
TopicId = objRow[conResearchTopic.TopicId].ToString().Trim(), //主题Id
TopicName = objRow[conResearchTopic.TopicName] == DBNull.Value ? null : objRow[conResearchTopic.TopicName].ToString().Trim(), //栏目主题
TopicContent = objRow[conResearchTopic.TopicContent] == DBNull.Value ? null : objRow[conResearchTopic.TopicContent].ToString().Trim(), //主题内容
TopicProposePeople = objRow[conResearchTopic.TopicProposePeople] == DBNull.Value ? null : objRow[conResearchTopic.TopicProposePeople].ToString().Trim(), //主题提出人
OrderNum = objRow[conResearchTopic.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conResearchTopic.OrderNum].ToString().Trim()), //序号
IsSubmit = TransNullToBool(objRow[conResearchTopic.IsSubmit].ToString().Trim()), //是否提交
IdCurrEduCls = objRow[conResearchTopic.IdCurrEduCls] == DBNull.Value ? null : objRow[conResearchTopic.IdCurrEduCls].ToString().Trim(), //教学班流水号
UpdDate = objRow[conResearchTopic.UpdDate] == DBNull.Value ? null : objRow[conResearchTopic.UpdDate].ToString().Trim(), //修改日期
ShareId = objRow[conResearchTopic.ShareId].ToString().Trim(), //分享Id
UpdUser = objRow[conResearchTopic.UpdUser] == DBNull.Value ? null : objRow[conResearchTopic.UpdUser].ToString().Trim(), //修改人
Memo = objRow[conResearchTopic.Memo] == DBNull.Value ? null : objRow[conResearchTopic.Memo].ToString().Trim() //备注
};
objResearchTopicEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objResearchTopicEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsResearchTopicDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsResearchTopicEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsResearchTopicEN objResearchTopicEN = new clsResearchTopicEN();
try
{
objResearchTopicEN.TopicId = objRow[conResearchTopic.TopicId].ToString().Trim(); //主题Id
objResearchTopicEN.TopicName = objRow[conResearchTopic.TopicName] == DBNull.Value ? null : objRow[conResearchTopic.TopicName].ToString().Trim(); //栏目主题
objResearchTopicEN.TopicContent = objRow[conResearchTopic.TopicContent] == DBNull.Value ? null : objRow[conResearchTopic.TopicContent].ToString().Trim(); //主题内容
objResearchTopicEN.TopicProposePeople = objRow[conResearchTopic.TopicProposePeople] == DBNull.Value ? null : objRow[conResearchTopic.TopicProposePeople].ToString().Trim(); //主题提出人
objResearchTopicEN.OrderNum = objRow[conResearchTopic.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conResearchTopic.OrderNum].ToString().Trim()); //序号
objResearchTopicEN.IsSubmit = TransNullToBool(objRow[conResearchTopic.IsSubmit].ToString().Trim()); //是否提交
objResearchTopicEN.IdCurrEduCls = objRow[conResearchTopic.IdCurrEduCls] == DBNull.Value ? null : objRow[conResearchTopic.IdCurrEduCls].ToString().Trim(); //教学班流水号
objResearchTopicEN.UpdDate = objRow[conResearchTopic.UpdDate] == DBNull.Value ? null : objRow[conResearchTopic.UpdDate].ToString().Trim(); //修改日期
objResearchTopicEN.ShareId = objRow[conResearchTopic.ShareId].ToString().Trim(); //分享Id
objResearchTopicEN.UpdUser = objRow[conResearchTopic.UpdUser] == DBNull.Value ? null : objRow[conResearchTopic.UpdUser].ToString().Trim(); //修改人
objResearchTopicEN.Memo = objRow[conResearchTopic.Memo] == DBNull.Value ? null : objRow[conResearchTopic.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsResearchTopicDA: GetObjByDataRowResearchTopic)", objException.Message));
}
objResearchTopicEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objResearchTopicEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsResearchTopicEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsResearchTopicEN objResearchTopicEN = new clsResearchTopicEN();
try
{
objResearchTopicEN.TopicId = objRow[conResearchTopic.TopicId].ToString().Trim(); //主题Id
objResearchTopicEN.TopicName = objRow[conResearchTopic.TopicName] == DBNull.Value ? null : objRow[conResearchTopic.TopicName].ToString().Trim(); //栏目主题
objResearchTopicEN.TopicContent = objRow[conResearchTopic.TopicContent] == DBNull.Value ? null : objRow[conResearchTopic.TopicContent].ToString().Trim(); //主题内容
objResearchTopicEN.TopicProposePeople = objRow[conResearchTopic.TopicProposePeople] == DBNull.Value ? null : objRow[conResearchTopic.TopicProposePeople].ToString().Trim(); //主题提出人
objResearchTopicEN.OrderNum = objRow[conResearchTopic.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conResearchTopic.OrderNum].ToString().Trim()); //序号
objResearchTopicEN.IsSubmit = TransNullToBool(objRow[conResearchTopic.IsSubmit].ToString().Trim()); //是否提交
objResearchTopicEN.IdCurrEduCls = objRow[conResearchTopic.IdCurrEduCls] == DBNull.Value ? null : objRow[conResearchTopic.IdCurrEduCls].ToString().Trim(); //教学班流水号
objResearchTopicEN.UpdDate = objRow[conResearchTopic.UpdDate] == DBNull.Value ? null : objRow[conResearchTopic.UpdDate].ToString().Trim(); //修改日期
objResearchTopicEN.ShareId = objRow[conResearchTopic.ShareId].ToString().Trim(); //分享Id
objResearchTopicEN.UpdUser = objRow[conResearchTopic.UpdUser] == DBNull.Value ? null : objRow[conResearchTopic.UpdUser].ToString().Trim(); //修改人
objResearchTopicEN.Memo = objRow[conResearchTopic.Memo] == DBNull.Value ? null : objRow[conResearchTopic.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsResearchTopicDA: GetObjByDataRow)", objException.Message));
}
objResearchTopicEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objResearchTopicEN;
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
objSQL = clsResearchTopicDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsResearchTopicEN._CurrTabName, conResearchTopic.TopicId, 8, "");
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
objSQL = clsResearchTopicDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsResearchTopicEN._CurrTabName, conResearchTopic.TopicId, 8, strPrefix);
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
 objSQL = clsResearchTopicDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select TopicId from ResearchTopic where " + strCondition;
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
 objSQL = clsResearchTopicDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select TopicId from ResearchTopic where " + strCondition;
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
 /// <param name = "strTopicId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strTopicId)
{
CheckPrimaryKey(strTopicId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResearchTopicDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ResearchTopic", "TopicId = " + "'"+ strTopicId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsResearchTopicDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResearchTopicDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ResearchTopic", strCondition))
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
objSQL = clsResearchTopicDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("ResearchTopic");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsResearchTopicEN objResearchTopicEN)
 {
 objResearchTopicEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objResearchTopicEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objResearchTopicEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResearchTopicDA.GetSpecSQLObj();
strSQL = "Select * from ResearchTopic where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ResearchTopic");
objRow = objDS.Tables["ResearchTopic"].NewRow();
objRow[conResearchTopic.TopicId] = objResearchTopicEN.TopicId; //主题Id
 if (objResearchTopicEN.TopicName !=  "")
 {
objRow[conResearchTopic.TopicName] = objResearchTopicEN.TopicName; //栏目主题
 }
 if (objResearchTopicEN.TopicContent !=  "")
 {
objRow[conResearchTopic.TopicContent] = objResearchTopicEN.TopicContent; //主题内容
 }
 if (objResearchTopicEN.TopicProposePeople !=  "")
 {
objRow[conResearchTopic.TopicProposePeople] = objResearchTopicEN.TopicProposePeople; //主题提出人
 }
objRow[conResearchTopic.OrderNum] = objResearchTopicEN.OrderNum; //序号
objRow[conResearchTopic.IsSubmit] = objResearchTopicEN.IsSubmit; //是否提交
 if (objResearchTopicEN.IdCurrEduCls !=  "")
 {
objRow[conResearchTopic.IdCurrEduCls] = objResearchTopicEN.IdCurrEduCls; //教学班流水号
 }
 if (objResearchTopicEN.UpdDate !=  "")
 {
objRow[conResearchTopic.UpdDate] = objResearchTopicEN.UpdDate; //修改日期
 }
objRow[conResearchTopic.ShareId] = objResearchTopicEN.ShareId; //分享Id
 if (objResearchTopicEN.UpdUser !=  "")
 {
objRow[conResearchTopic.UpdUser] = objResearchTopicEN.UpdUser; //修改人
 }
 if (objResearchTopicEN.Memo !=  "")
 {
objRow[conResearchTopic.Memo] = objResearchTopicEN.Memo; //备注
 }
objDS.Tables[clsResearchTopicEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsResearchTopicEN._CurrTabName);
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
 /// <param name = "objResearchTopicEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsResearchTopicEN objResearchTopicEN)
{
 objResearchTopicEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objResearchTopicEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objResearchTopicEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objResearchTopicEN.TopicId !=  null)
 {
 arrFieldListForInsert.Add(conResearchTopic.TopicId);
 var strTopicId = objResearchTopicEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicId + "'");
 }
 
 if (objResearchTopicEN.TopicName !=  null)
 {
 arrFieldListForInsert.Add(conResearchTopic.TopicName);
 var strTopicName = objResearchTopicEN.TopicName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicName + "'");
 }
 
 if (objResearchTopicEN.TopicContent !=  null)
 {
 arrFieldListForInsert.Add(conResearchTopic.TopicContent);
 var strTopicContent = objResearchTopicEN.TopicContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicContent + "'");
 }
 
 if (objResearchTopicEN.TopicProposePeople !=  null)
 {
 arrFieldListForInsert.Add(conResearchTopic.TopicProposePeople);
 var strTopicProposePeople = objResearchTopicEN.TopicProposePeople.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicProposePeople + "'");
 }
 
 if (objResearchTopicEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conResearchTopic.OrderNum);
 arrValueListForInsert.Add(objResearchTopicEN.OrderNum.ToString());
 }
 
 arrFieldListForInsert.Add(conResearchTopic.IsSubmit);
 arrValueListForInsert.Add("'" + (objResearchTopicEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objResearchTopicEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conResearchTopic.IdCurrEduCls);
 var strIdCurrEduCls = objResearchTopicEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objResearchTopicEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conResearchTopic.UpdDate);
 var strUpdDate = objResearchTopicEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objResearchTopicEN.ShareId !=  null)
 {
 arrFieldListForInsert.Add(conResearchTopic.ShareId);
 var strShareId = objResearchTopicEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strShareId + "'");
 }
 
 if (objResearchTopicEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conResearchTopic.UpdUser);
 var strUpdUser = objResearchTopicEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objResearchTopicEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conResearchTopic.Memo);
 var strMemo = objResearchTopicEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ResearchTopic");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResearchTopicDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objResearchTopicEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsResearchTopicEN objResearchTopicEN)
{
 objResearchTopicEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objResearchTopicEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objResearchTopicEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objResearchTopicEN.TopicId !=  null)
 {
 arrFieldListForInsert.Add(conResearchTopic.TopicId);
 var strTopicId = objResearchTopicEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicId + "'");
 }
 
 if (objResearchTopicEN.TopicName !=  null)
 {
 arrFieldListForInsert.Add(conResearchTopic.TopicName);
 var strTopicName = objResearchTopicEN.TopicName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicName + "'");
 }
 
 if (objResearchTopicEN.TopicContent !=  null)
 {
 arrFieldListForInsert.Add(conResearchTopic.TopicContent);
 var strTopicContent = objResearchTopicEN.TopicContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicContent + "'");
 }
 
 if (objResearchTopicEN.TopicProposePeople !=  null)
 {
 arrFieldListForInsert.Add(conResearchTopic.TopicProposePeople);
 var strTopicProposePeople = objResearchTopicEN.TopicProposePeople.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicProposePeople + "'");
 }
 
 if (objResearchTopicEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conResearchTopic.OrderNum);
 arrValueListForInsert.Add(objResearchTopicEN.OrderNum.ToString());
 }
 
 arrFieldListForInsert.Add(conResearchTopic.IsSubmit);
 arrValueListForInsert.Add("'" + (objResearchTopicEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objResearchTopicEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conResearchTopic.IdCurrEduCls);
 var strIdCurrEduCls = objResearchTopicEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objResearchTopicEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conResearchTopic.UpdDate);
 var strUpdDate = objResearchTopicEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objResearchTopicEN.ShareId !=  null)
 {
 arrFieldListForInsert.Add(conResearchTopic.ShareId);
 var strShareId = objResearchTopicEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strShareId + "'");
 }
 
 if (objResearchTopicEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conResearchTopic.UpdUser);
 var strUpdUser = objResearchTopicEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objResearchTopicEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conResearchTopic.Memo);
 var strMemo = objResearchTopicEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ResearchTopic");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResearchTopicDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objResearchTopicEN.TopicId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objResearchTopicEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsResearchTopicEN objResearchTopicEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objResearchTopicEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objResearchTopicEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objResearchTopicEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objResearchTopicEN.TopicId !=  null)
 {
 arrFieldListForInsert.Add(conResearchTopic.TopicId);
 var strTopicId = objResearchTopicEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicId + "'");
 }
 
 if (objResearchTopicEN.TopicName !=  null)
 {
 arrFieldListForInsert.Add(conResearchTopic.TopicName);
 var strTopicName = objResearchTopicEN.TopicName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicName + "'");
 }
 
 if (objResearchTopicEN.TopicContent !=  null)
 {
 arrFieldListForInsert.Add(conResearchTopic.TopicContent);
 var strTopicContent = objResearchTopicEN.TopicContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicContent + "'");
 }
 
 if (objResearchTopicEN.TopicProposePeople !=  null)
 {
 arrFieldListForInsert.Add(conResearchTopic.TopicProposePeople);
 var strTopicProposePeople = objResearchTopicEN.TopicProposePeople.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicProposePeople + "'");
 }
 
 if (objResearchTopicEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conResearchTopic.OrderNum);
 arrValueListForInsert.Add(objResearchTopicEN.OrderNum.ToString());
 }
 
 arrFieldListForInsert.Add(conResearchTopic.IsSubmit);
 arrValueListForInsert.Add("'" + (objResearchTopicEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objResearchTopicEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conResearchTopic.IdCurrEduCls);
 var strIdCurrEduCls = objResearchTopicEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objResearchTopicEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conResearchTopic.UpdDate);
 var strUpdDate = objResearchTopicEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objResearchTopicEN.ShareId !=  null)
 {
 arrFieldListForInsert.Add(conResearchTopic.ShareId);
 var strShareId = objResearchTopicEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strShareId + "'");
 }
 
 if (objResearchTopicEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conResearchTopic.UpdUser);
 var strUpdUser = objResearchTopicEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objResearchTopicEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conResearchTopic.Memo);
 var strMemo = objResearchTopicEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ResearchTopic");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResearchTopicDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objResearchTopicEN.TopicId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objResearchTopicEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsResearchTopicEN objResearchTopicEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objResearchTopicEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objResearchTopicEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objResearchTopicEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objResearchTopicEN.TopicId !=  null)
 {
 arrFieldListForInsert.Add(conResearchTopic.TopicId);
 var strTopicId = objResearchTopicEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicId + "'");
 }
 
 if (objResearchTopicEN.TopicName !=  null)
 {
 arrFieldListForInsert.Add(conResearchTopic.TopicName);
 var strTopicName = objResearchTopicEN.TopicName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicName + "'");
 }
 
 if (objResearchTopicEN.TopicContent !=  null)
 {
 arrFieldListForInsert.Add(conResearchTopic.TopicContent);
 var strTopicContent = objResearchTopicEN.TopicContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicContent + "'");
 }
 
 if (objResearchTopicEN.TopicProposePeople !=  null)
 {
 arrFieldListForInsert.Add(conResearchTopic.TopicProposePeople);
 var strTopicProposePeople = objResearchTopicEN.TopicProposePeople.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicProposePeople + "'");
 }
 
 if (objResearchTopicEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conResearchTopic.OrderNum);
 arrValueListForInsert.Add(objResearchTopicEN.OrderNum.ToString());
 }
 
 arrFieldListForInsert.Add(conResearchTopic.IsSubmit);
 arrValueListForInsert.Add("'" + (objResearchTopicEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objResearchTopicEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conResearchTopic.IdCurrEduCls);
 var strIdCurrEduCls = objResearchTopicEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objResearchTopicEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conResearchTopic.UpdDate);
 var strUpdDate = objResearchTopicEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objResearchTopicEN.ShareId !=  null)
 {
 arrFieldListForInsert.Add(conResearchTopic.ShareId);
 var strShareId = objResearchTopicEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strShareId + "'");
 }
 
 if (objResearchTopicEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conResearchTopic.UpdUser);
 var strUpdUser = objResearchTopicEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objResearchTopicEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conResearchTopic.Memo);
 var strMemo = objResearchTopicEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ResearchTopic");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResearchTopicDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewResearchTopics(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResearchTopicDA.GetSpecSQLObj();
strSQL = "Select * from ResearchTopic where TopicId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ResearchTopic");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strTopicId = oRow[conResearchTopic.TopicId].ToString().Trim();
if (IsExist(strTopicId))
{
 string strResult = "关键字变量值为:" + string.Format("TopicId = {0}", strTopicId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsResearchTopicEN._CurrTabName ].NewRow();
objRow[conResearchTopic.TopicId] = oRow[conResearchTopic.TopicId].ToString().Trim(); //主题Id
objRow[conResearchTopic.TopicName] = oRow[conResearchTopic.TopicName].ToString().Trim(); //栏目主题
objRow[conResearchTopic.TopicContent] = oRow[conResearchTopic.TopicContent].ToString().Trim(); //主题内容
objRow[conResearchTopic.TopicProposePeople] = oRow[conResearchTopic.TopicProposePeople].ToString().Trim(); //主题提出人
objRow[conResearchTopic.OrderNum] = oRow[conResearchTopic.OrderNum].ToString().Trim(); //序号
objRow[conResearchTopic.IsSubmit] = oRow[conResearchTopic.IsSubmit].ToString().Trim(); //是否提交
objRow[conResearchTopic.IdCurrEduCls] = oRow[conResearchTopic.IdCurrEduCls].ToString().Trim(); //教学班流水号
objRow[conResearchTopic.UpdDate] = oRow[conResearchTopic.UpdDate].ToString().Trim(); //修改日期
objRow[conResearchTopic.ShareId] = oRow[conResearchTopic.ShareId].ToString().Trim(); //分享Id
objRow[conResearchTopic.UpdUser] = oRow[conResearchTopic.UpdUser].ToString().Trim(); //修改人
objRow[conResearchTopic.Memo] = oRow[conResearchTopic.Memo].ToString().Trim(); //备注
 objDS.Tables[clsResearchTopicEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsResearchTopicEN._CurrTabName);
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
 /// <param name = "objResearchTopicEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsResearchTopicEN objResearchTopicEN)
{
 objResearchTopicEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objResearchTopicEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objResearchTopicEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResearchTopicDA.GetSpecSQLObj();
strSQL = "Select * from ResearchTopic where TopicId = " + "'"+ objResearchTopicEN.TopicId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsResearchTopicEN._CurrTabName);
if (objDS.Tables[clsResearchTopicEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:TopicId = " + "'"+ objResearchTopicEN.TopicId+"'");
return false;
}
objRow = objDS.Tables[clsResearchTopicEN._CurrTabName].Rows[0];
 if (objResearchTopicEN.IsUpdated(conResearchTopic.TopicId))
 {
objRow[conResearchTopic.TopicId] = objResearchTopicEN.TopicId; //主题Id
 }
 if (objResearchTopicEN.IsUpdated(conResearchTopic.TopicName))
 {
objRow[conResearchTopic.TopicName] = objResearchTopicEN.TopicName; //栏目主题
 }
 if (objResearchTopicEN.IsUpdated(conResearchTopic.TopicContent))
 {
objRow[conResearchTopic.TopicContent] = objResearchTopicEN.TopicContent; //主题内容
 }
 if (objResearchTopicEN.IsUpdated(conResearchTopic.TopicProposePeople))
 {
objRow[conResearchTopic.TopicProposePeople] = objResearchTopicEN.TopicProposePeople; //主题提出人
 }
 if (objResearchTopicEN.IsUpdated(conResearchTopic.OrderNum))
 {
objRow[conResearchTopic.OrderNum] = objResearchTopicEN.OrderNum; //序号
 }
 if (objResearchTopicEN.IsUpdated(conResearchTopic.IsSubmit))
 {
objRow[conResearchTopic.IsSubmit] = objResearchTopicEN.IsSubmit; //是否提交
 }
 if (objResearchTopicEN.IsUpdated(conResearchTopic.IdCurrEduCls))
 {
objRow[conResearchTopic.IdCurrEduCls] = objResearchTopicEN.IdCurrEduCls; //教学班流水号
 }
 if (objResearchTopicEN.IsUpdated(conResearchTopic.UpdDate))
 {
objRow[conResearchTopic.UpdDate] = objResearchTopicEN.UpdDate; //修改日期
 }
 if (objResearchTopicEN.IsUpdated(conResearchTopic.ShareId))
 {
objRow[conResearchTopic.ShareId] = objResearchTopicEN.ShareId; //分享Id
 }
 if (objResearchTopicEN.IsUpdated(conResearchTopic.UpdUser))
 {
objRow[conResearchTopic.UpdUser] = objResearchTopicEN.UpdUser; //修改人
 }
 if (objResearchTopicEN.IsUpdated(conResearchTopic.Memo))
 {
objRow[conResearchTopic.Memo] = objResearchTopicEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsResearchTopicEN._CurrTabName);
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
 /// <param name = "objResearchTopicEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsResearchTopicEN objResearchTopicEN)
{
 objResearchTopicEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objResearchTopicEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objResearchTopicEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResearchTopicDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update ResearchTopic Set ");
 
 if (objResearchTopicEN.IsUpdated(conResearchTopic.TopicName))
 {
 if (objResearchTopicEN.TopicName !=  null)
 {
 var strTopicName = objResearchTopicEN.TopicName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTopicName, conResearchTopic.TopicName); //栏目主题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conResearchTopic.TopicName); //栏目主题
 }
 }
 
 if (objResearchTopicEN.IsUpdated(conResearchTopic.TopicContent))
 {
 if (objResearchTopicEN.TopicContent !=  null)
 {
 var strTopicContent = objResearchTopicEN.TopicContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTopicContent, conResearchTopic.TopicContent); //主题内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conResearchTopic.TopicContent); //主题内容
 }
 }
 
 if (objResearchTopicEN.IsUpdated(conResearchTopic.TopicProposePeople))
 {
 if (objResearchTopicEN.TopicProposePeople !=  null)
 {
 var strTopicProposePeople = objResearchTopicEN.TopicProposePeople.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTopicProposePeople, conResearchTopic.TopicProposePeople); //主题提出人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conResearchTopic.TopicProposePeople); //主题提出人
 }
 }
 
 if (objResearchTopicEN.IsUpdated(conResearchTopic.OrderNum))
 {
 if (objResearchTopicEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objResearchTopicEN.OrderNum, conResearchTopic.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conResearchTopic.OrderNum); //序号
 }
 }
 
 if (objResearchTopicEN.IsUpdated(conResearchTopic.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objResearchTopicEN.IsSubmit == true?"1":"0", conResearchTopic.IsSubmit); //是否提交
 }
 
 if (objResearchTopicEN.IsUpdated(conResearchTopic.IdCurrEduCls))
 {
 if (objResearchTopicEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objResearchTopicEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conResearchTopic.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conResearchTopic.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objResearchTopicEN.IsUpdated(conResearchTopic.UpdDate))
 {
 if (objResearchTopicEN.UpdDate !=  null)
 {
 var strUpdDate = objResearchTopicEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conResearchTopic.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conResearchTopic.UpdDate); //修改日期
 }
 }
 
 if (objResearchTopicEN.IsUpdated(conResearchTopic.ShareId))
 {
 if (objResearchTopicEN.ShareId !=  null)
 {
 var strShareId = objResearchTopicEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strShareId, conResearchTopic.ShareId); //分享Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conResearchTopic.ShareId); //分享Id
 }
 }
 
 if (objResearchTopicEN.IsUpdated(conResearchTopic.UpdUser))
 {
 if (objResearchTopicEN.UpdUser !=  null)
 {
 var strUpdUser = objResearchTopicEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conResearchTopic.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conResearchTopic.UpdUser); //修改人
 }
 }
 
 if (objResearchTopicEN.IsUpdated(conResearchTopic.Memo))
 {
 if (objResearchTopicEN.Memo !=  null)
 {
 var strMemo = objResearchTopicEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conResearchTopic.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conResearchTopic.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where TopicId = '{0}'", objResearchTopicEN.TopicId); 
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
 /// <param name = "objResearchTopicEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsResearchTopicEN objResearchTopicEN, string strCondition)
{
 objResearchTopicEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objResearchTopicEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objResearchTopicEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResearchTopicDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ResearchTopic Set ");
 
 if (objResearchTopicEN.IsUpdated(conResearchTopic.TopicName))
 {
 if (objResearchTopicEN.TopicName !=  null)
 {
 var strTopicName = objResearchTopicEN.TopicName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TopicName = '{0}',", strTopicName); //栏目主题
 }
 else
 {
 sbSQL.Append(" TopicName = null,"); //栏目主题
 }
 }
 
 if (objResearchTopicEN.IsUpdated(conResearchTopic.TopicContent))
 {
 if (objResearchTopicEN.TopicContent !=  null)
 {
 var strTopicContent = objResearchTopicEN.TopicContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TopicContent = '{0}',", strTopicContent); //主题内容
 }
 else
 {
 sbSQL.Append(" TopicContent = null,"); //主题内容
 }
 }
 
 if (objResearchTopicEN.IsUpdated(conResearchTopic.TopicProposePeople))
 {
 if (objResearchTopicEN.TopicProposePeople !=  null)
 {
 var strTopicProposePeople = objResearchTopicEN.TopicProposePeople.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TopicProposePeople = '{0}',", strTopicProposePeople); //主题提出人
 }
 else
 {
 sbSQL.Append(" TopicProposePeople = null,"); //主题提出人
 }
 }
 
 if (objResearchTopicEN.IsUpdated(conResearchTopic.OrderNum))
 {
 if (objResearchTopicEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objResearchTopicEN.OrderNum, conResearchTopic.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conResearchTopic.OrderNum); //序号
 }
 }
 
 if (objResearchTopicEN.IsUpdated(conResearchTopic.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objResearchTopicEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objResearchTopicEN.IsUpdated(conResearchTopic.IdCurrEduCls))
 {
 if (objResearchTopicEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objResearchTopicEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objResearchTopicEN.IsUpdated(conResearchTopic.UpdDate))
 {
 if (objResearchTopicEN.UpdDate !=  null)
 {
 var strUpdDate = objResearchTopicEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objResearchTopicEN.IsUpdated(conResearchTopic.ShareId))
 {
 if (objResearchTopicEN.ShareId !=  null)
 {
 var strShareId = objResearchTopicEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ShareId = '{0}',", strShareId); //分享Id
 }
 else
 {
 sbSQL.Append(" ShareId = null,"); //分享Id
 }
 }
 
 if (objResearchTopicEN.IsUpdated(conResearchTopic.UpdUser))
 {
 if (objResearchTopicEN.UpdUser !=  null)
 {
 var strUpdUser = objResearchTopicEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objResearchTopicEN.IsUpdated(conResearchTopic.Memo))
 {
 if (objResearchTopicEN.Memo !=  null)
 {
 var strMemo = objResearchTopicEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objResearchTopicEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsResearchTopicEN objResearchTopicEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objResearchTopicEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objResearchTopicEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objResearchTopicEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResearchTopicDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ResearchTopic Set ");
 
 if (objResearchTopicEN.IsUpdated(conResearchTopic.TopicName))
 {
 if (objResearchTopicEN.TopicName !=  null)
 {
 var strTopicName = objResearchTopicEN.TopicName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TopicName = '{0}',", strTopicName); //栏目主题
 }
 else
 {
 sbSQL.Append(" TopicName = null,"); //栏目主题
 }
 }
 
 if (objResearchTopicEN.IsUpdated(conResearchTopic.TopicContent))
 {
 if (objResearchTopicEN.TopicContent !=  null)
 {
 var strTopicContent = objResearchTopicEN.TopicContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TopicContent = '{0}',", strTopicContent); //主题内容
 }
 else
 {
 sbSQL.Append(" TopicContent = null,"); //主题内容
 }
 }
 
 if (objResearchTopicEN.IsUpdated(conResearchTopic.TopicProposePeople))
 {
 if (objResearchTopicEN.TopicProposePeople !=  null)
 {
 var strTopicProposePeople = objResearchTopicEN.TopicProposePeople.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TopicProposePeople = '{0}',", strTopicProposePeople); //主题提出人
 }
 else
 {
 sbSQL.Append(" TopicProposePeople = null,"); //主题提出人
 }
 }
 
 if (objResearchTopicEN.IsUpdated(conResearchTopic.OrderNum))
 {
 if (objResearchTopicEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objResearchTopicEN.OrderNum, conResearchTopic.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conResearchTopic.OrderNum); //序号
 }
 }
 
 if (objResearchTopicEN.IsUpdated(conResearchTopic.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objResearchTopicEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objResearchTopicEN.IsUpdated(conResearchTopic.IdCurrEduCls))
 {
 if (objResearchTopicEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objResearchTopicEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objResearchTopicEN.IsUpdated(conResearchTopic.UpdDate))
 {
 if (objResearchTopicEN.UpdDate !=  null)
 {
 var strUpdDate = objResearchTopicEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objResearchTopicEN.IsUpdated(conResearchTopic.ShareId))
 {
 if (objResearchTopicEN.ShareId !=  null)
 {
 var strShareId = objResearchTopicEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ShareId = '{0}',", strShareId); //分享Id
 }
 else
 {
 sbSQL.Append(" ShareId = null,"); //分享Id
 }
 }
 
 if (objResearchTopicEN.IsUpdated(conResearchTopic.UpdUser))
 {
 if (objResearchTopicEN.UpdUser !=  null)
 {
 var strUpdUser = objResearchTopicEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objResearchTopicEN.IsUpdated(conResearchTopic.Memo))
 {
 if (objResearchTopicEN.Memo !=  null)
 {
 var strMemo = objResearchTopicEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objResearchTopicEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsResearchTopicEN objResearchTopicEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objResearchTopicEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objResearchTopicEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objResearchTopicEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResearchTopicDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ResearchTopic Set ");
 
 if (objResearchTopicEN.IsUpdated(conResearchTopic.TopicName))
 {
 if (objResearchTopicEN.TopicName !=  null)
 {
 var strTopicName = objResearchTopicEN.TopicName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTopicName, conResearchTopic.TopicName); //栏目主题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conResearchTopic.TopicName); //栏目主题
 }
 }
 
 if (objResearchTopicEN.IsUpdated(conResearchTopic.TopicContent))
 {
 if (objResearchTopicEN.TopicContent !=  null)
 {
 var strTopicContent = objResearchTopicEN.TopicContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTopicContent, conResearchTopic.TopicContent); //主题内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conResearchTopic.TopicContent); //主题内容
 }
 }
 
 if (objResearchTopicEN.IsUpdated(conResearchTopic.TopicProposePeople))
 {
 if (objResearchTopicEN.TopicProposePeople !=  null)
 {
 var strTopicProposePeople = objResearchTopicEN.TopicProposePeople.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTopicProposePeople, conResearchTopic.TopicProposePeople); //主题提出人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conResearchTopic.TopicProposePeople); //主题提出人
 }
 }
 
 if (objResearchTopicEN.IsUpdated(conResearchTopic.OrderNum))
 {
 if (objResearchTopicEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objResearchTopicEN.OrderNum, conResearchTopic.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conResearchTopic.OrderNum); //序号
 }
 }
 
 if (objResearchTopicEN.IsUpdated(conResearchTopic.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objResearchTopicEN.IsSubmit == true?"1":"0", conResearchTopic.IsSubmit); //是否提交
 }
 
 if (objResearchTopicEN.IsUpdated(conResearchTopic.IdCurrEduCls))
 {
 if (objResearchTopicEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objResearchTopicEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conResearchTopic.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conResearchTopic.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objResearchTopicEN.IsUpdated(conResearchTopic.UpdDate))
 {
 if (objResearchTopicEN.UpdDate !=  null)
 {
 var strUpdDate = objResearchTopicEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conResearchTopic.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conResearchTopic.UpdDate); //修改日期
 }
 }
 
 if (objResearchTopicEN.IsUpdated(conResearchTopic.ShareId))
 {
 if (objResearchTopicEN.ShareId !=  null)
 {
 var strShareId = objResearchTopicEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strShareId, conResearchTopic.ShareId); //分享Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conResearchTopic.ShareId); //分享Id
 }
 }
 
 if (objResearchTopicEN.IsUpdated(conResearchTopic.UpdUser))
 {
 if (objResearchTopicEN.UpdUser !=  null)
 {
 var strUpdUser = objResearchTopicEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conResearchTopic.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conResearchTopic.UpdUser); //修改人
 }
 }
 
 if (objResearchTopicEN.IsUpdated(conResearchTopic.Memo))
 {
 if (objResearchTopicEN.Memo !=  null)
 {
 var strMemo = objResearchTopicEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conResearchTopic.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conResearchTopic.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where TopicId = '{0}'", objResearchTopicEN.TopicId); 
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
 /// <param name = "strTopicId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strTopicId) 
{
CheckPrimaryKey(strTopicId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResearchTopicDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strTopicId,
};
 objSQL.ExecSP("ResearchTopic_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strTopicId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strTopicId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strTopicId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResearchTopicDA.GetSpecSQLObj();
//删除ResearchTopic本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ResearchTopic where TopicId = " + "'"+ strTopicId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelResearchTopic(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResearchTopicDA.GetSpecSQLObj();
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
//删除ResearchTopic本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ResearchTopic where TopicId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strTopicId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strTopicId) 
{
CheckPrimaryKey(strTopicId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResearchTopicDA.GetSpecSQLObj();
//删除ResearchTopic本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ResearchTopic where TopicId = " + "'"+ strTopicId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelResearchTopic(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsResearchTopicDA: DelResearchTopic)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResearchTopicDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ResearchTopic where " + strCondition ;
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
public bool DelResearchTopicWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsResearchTopicDA: DelResearchTopicWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResearchTopicDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ResearchTopic where " + strCondition ;
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
 /// <param name = "objResearchTopicENS">源对象</param>
 /// <param name = "objResearchTopicENT">目标对象</param>
public void CopyTo(clsResearchTopicEN objResearchTopicENS, clsResearchTopicEN objResearchTopicENT)
{
objResearchTopicENT.TopicId = objResearchTopicENS.TopicId; //主题Id
objResearchTopicENT.TopicName = objResearchTopicENS.TopicName; //栏目主题
objResearchTopicENT.TopicContent = objResearchTopicENS.TopicContent; //主题内容
objResearchTopicENT.TopicProposePeople = objResearchTopicENS.TopicProposePeople; //主题提出人
objResearchTopicENT.OrderNum = objResearchTopicENS.OrderNum; //序号
objResearchTopicENT.IsSubmit = objResearchTopicENS.IsSubmit; //是否提交
objResearchTopicENT.IdCurrEduCls = objResearchTopicENS.IdCurrEduCls; //教学班流水号
objResearchTopicENT.UpdDate = objResearchTopicENS.UpdDate; //修改日期
objResearchTopicENT.ShareId = objResearchTopicENS.ShareId; //分享Id
objResearchTopicENT.UpdUser = objResearchTopicENS.UpdUser; //修改人
objResearchTopicENT.Memo = objResearchTopicENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsResearchTopicEN objResearchTopicEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objResearchTopicEN.ShareId, conResearchTopic.ShareId);
//检查字段长度
clsCheckSql.CheckFieldLen(objResearchTopicEN.TopicId, 8, conResearchTopic.TopicId);
clsCheckSql.CheckFieldLen(objResearchTopicEN.TopicName, 200, conResearchTopic.TopicName);
clsCheckSql.CheckFieldLen(objResearchTopicEN.TopicProposePeople, 50, conResearchTopic.TopicProposePeople);
clsCheckSql.CheckFieldLen(objResearchTopicEN.IdCurrEduCls, 8, conResearchTopic.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objResearchTopicEN.UpdDate, 20, conResearchTopic.UpdDate);
clsCheckSql.CheckFieldLen(objResearchTopicEN.ShareId, 2, conResearchTopic.ShareId);
clsCheckSql.CheckFieldLen(objResearchTopicEN.UpdUser, 20, conResearchTopic.UpdUser);
clsCheckSql.CheckFieldLen(objResearchTopicEN.Memo, 1000, conResearchTopic.Memo);
//检查字段外键固定长度
 objResearchTopicEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsResearchTopicEN objResearchTopicEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objResearchTopicEN.TopicName, 200, conResearchTopic.TopicName);
clsCheckSql.CheckFieldLen(objResearchTopicEN.TopicProposePeople, 50, conResearchTopic.TopicProposePeople);
clsCheckSql.CheckFieldLen(objResearchTopicEN.IdCurrEduCls, 8, conResearchTopic.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objResearchTopicEN.UpdDate, 20, conResearchTopic.UpdDate);
clsCheckSql.CheckFieldLen(objResearchTopicEN.ShareId, 2, conResearchTopic.ShareId);
clsCheckSql.CheckFieldLen(objResearchTopicEN.UpdUser, 20, conResearchTopic.UpdUser);
clsCheckSql.CheckFieldLen(objResearchTopicEN.Memo, 1000, conResearchTopic.Memo);
//检查外键字段长度
 objResearchTopicEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsResearchTopicEN objResearchTopicEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objResearchTopicEN.TopicId, 8, conResearchTopic.TopicId);
clsCheckSql.CheckFieldLen(objResearchTopicEN.TopicName, 200, conResearchTopic.TopicName);
clsCheckSql.CheckFieldLen(objResearchTopicEN.TopicProposePeople, 50, conResearchTopic.TopicProposePeople);
clsCheckSql.CheckFieldLen(objResearchTopicEN.IdCurrEduCls, 8, conResearchTopic.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objResearchTopicEN.UpdDate, 20, conResearchTopic.UpdDate);
clsCheckSql.CheckFieldLen(objResearchTopicEN.ShareId, 2, conResearchTopic.ShareId);
clsCheckSql.CheckFieldLen(objResearchTopicEN.UpdUser, 20, conResearchTopic.UpdUser);
clsCheckSql.CheckFieldLen(objResearchTopicEN.Memo, 1000, conResearchTopic.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objResearchTopicEN.TopicId, conResearchTopic.TopicId);
clsCheckSql.CheckSqlInjection4Field(objResearchTopicEN.TopicName, conResearchTopic.TopicName);
clsCheckSql.CheckSqlInjection4Field(objResearchTopicEN.TopicProposePeople, conResearchTopic.TopicProposePeople);
clsCheckSql.CheckSqlInjection4Field(objResearchTopicEN.IdCurrEduCls, conResearchTopic.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objResearchTopicEN.UpdDate, conResearchTopic.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objResearchTopicEN.ShareId, conResearchTopic.ShareId);
clsCheckSql.CheckSqlInjection4Field(objResearchTopicEN.UpdUser, conResearchTopic.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objResearchTopicEN.Memo, conResearchTopic.Memo);
//检查外键字段长度
 objResearchTopicEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetTopicId()
{
//获取某学院所有专业信息
string strSQL = "select TopicId, TopicName from ResearchTopic ";
 clsSpecSQLforSql mySql = clsResearchTopicDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--ResearchTopic(研究主题),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objResearchTopicEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsResearchTopicEN objResearchTopicEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TopicId = '{0}'", objResearchTopicEN.TopicId);
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
 objSQL = clsResearchTopicDA.GetSpecSQLObj();
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
 objSQL = clsResearchTopicDA.GetSpecSQLObj();
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
 objSQL = clsResearchTopicDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsResearchTopicEN._CurrTabName);
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
 objSQL = clsResearchTopicDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsResearchTopicEN._CurrTabName, strCondition);
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
 objSQL = clsResearchTopicDA.GetSpecSQLObj();
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
 objSQL = clsResearchTopicDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}