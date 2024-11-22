
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQuestionnaireBatchDA
 表名:QuestionnaireBatch(01120006)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:02:03
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
 /// 问卷批次(QuestionnaireBatch)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsQuestionnaireBatchDA : clsCommBase4DA
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
 return clsQuestionnaireBatchEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsQuestionnaireBatchEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsQuestionnaireBatchEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsQuestionnaireBatchEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsQuestionnaireBatchEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strBatchId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strBatchId)
{
strBatchId = strBatchId.Replace("'", "''");
if (strBatchId.Length > 4)
{
throw new Exception("(errid:Data000001)在表:QuestionnaireBatch中,检查关键字,长度不正确!(clsQuestionnaireBatchDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strBatchId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:QuestionnaireBatch中,关键字不能为空 或 null!(clsQuestionnaireBatchDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strBatchId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsQuestionnaireBatchDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsQuestionnaireBatchDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireBatchDA.GetSpecSQLObj();
strSQL = "Select * from QuestionnaireBatch where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_QuestionnaireBatch(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsQuestionnaireBatchDA: GetDataTable_QuestionnaireBatch)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireBatchDA.GetSpecSQLObj();
strSQL = "Select * from QuestionnaireBatch where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsQuestionnaireBatchDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireBatchDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsQuestionnaireBatchDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireBatchDA.GetSpecSQLObj();
strSQL = "Select * from QuestionnaireBatch where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsQuestionnaireBatchDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireBatchDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsQuestionnaireBatchDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireBatchDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QuestionnaireBatch where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QuestionnaireBatch where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsQuestionnaireBatchDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireBatchDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QuestionnaireBatch where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsQuestionnaireBatchDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireBatchDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QuestionnaireBatch.* from QuestionnaireBatch Left Join {1} on {2} where {3} and QuestionnaireBatch.BatchId not in (Select top {5} QuestionnaireBatch.BatchId from QuestionnaireBatch Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QuestionnaireBatch where {1} and BatchId not in (Select top {2} BatchId from QuestionnaireBatch where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QuestionnaireBatch where {1} and BatchId not in (Select top {3} BatchId from QuestionnaireBatch where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsQuestionnaireBatchDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireBatchDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QuestionnaireBatch.* from QuestionnaireBatch Left Join {1} on {2} where {3} and QuestionnaireBatch.BatchId not in (Select top {5} QuestionnaireBatch.BatchId from QuestionnaireBatch Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QuestionnaireBatch where {1} and BatchId not in (Select top {2} BatchId from QuestionnaireBatch where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QuestionnaireBatch where {1} and BatchId not in (Select top {3} BatchId from QuestionnaireBatch where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsQuestionnaireBatchEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsQuestionnaireBatchDA:GetObjLst)", objException.Message));
}
List<clsQuestionnaireBatchEN> arrObjLst = new List<clsQuestionnaireBatchEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireBatchDA.GetSpecSQLObj();
strSQL = "Select * from QuestionnaireBatch where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionnaireBatchEN objQuestionnaireBatchEN = new clsQuestionnaireBatchEN();
try
{
objQuestionnaireBatchEN.BatchId = objRow[conQuestionnaireBatch.BatchId].ToString().Trim(); //批次ID
objQuestionnaireBatchEN.BatchName = objRow[conQuestionnaireBatch.BatchName].ToString().Trim(); //批次名称
objQuestionnaireBatchEN.RoleId = objRow[conQuestionnaireBatch.RoleId] == DBNull.Value ? null : objRow[conQuestionnaireBatch.RoleId].ToString().Trim(); //角色Id
objQuestionnaireBatchEN.QuestionnaireSetId = objRow[conQuestionnaireBatch.QuestionnaireSetId] == DBNull.Value ? null : objRow[conQuestionnaireBatch.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objQuestionnaireBatchEN.IsDefault = TransNullToBool(objRow[conQuestionnaireBatch.IsDefault].ToString().Trim()); //是否默认
objQuestionnaireBatchEN.IsDefaultUser = TransNullToBool(objRow[conQuestionnaireBatch.IsDefaultUser].ToString().Trim()); //是否默认用户
objQuestionnaireBatchEN.CreateDate = objRow[conQuestionnaireBatch.CreateDate].ToString().Trim(); //建立日期
objQuestionnaireBatchEN.CreateUser = objRow[conQuestionnaireBatch.CreateUser].ToString().Trim(); //建立用户
objQuestionnaireBatchEN.PageName = objRow[conQuestionnaireBatch.PageName] == DBNull.Value ? null : objRow[conQuestionnaireBatch.PageName].ToString().Trim(); //页面名称
objQuestionnaireBatchEN.IsRandomSelSet = TransNullToBool(objRow[conQuestionnaireBatch.IsRandomSelSet].ToString().Trim()); //是否随机选问卷集
objQuestionnaireBatchEN.UpdDate = objRow[conQuestionnaireBatch.UpdDate].ToString().Trim(); //修改日期
objQuestionnaireBatchEN.UpdUser = objRow[conQuestionnaireBatch.UpdUser].ToString().Trim(); //修改人
objQuestionnaireBatchEN.Memo = objRow[conQuestionnaireBatch.Memo] == DBNull.Value ? null : objRow[conQuestionnaireBatch.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsQuestionnaireBatchDA: GetObjLst)", objException.Message));
}
objQuestionnaireBatchEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQuestionnaireBatchEN);
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
public List<clsQuestionnaireBatchEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsQuestionnaireBatchDA:GetObjLstByTabName)", objException.Message));
}
List<clsQuestionnaireBatchEN> arrObjLst = new List<clsQuestionnaireBatchEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireBatchDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionnaireBatchEN objQuestionnaireBatchEN = new clsQuestionnaireBatchEN();
try
{
objQuestionnaireBatchEN.BatchId = objRow[conQuestionnaireBatch.BatchId].ToString().Trim(); //批次ID
objQuestionnaireBatchEN.BatchName = objRow[conQuestionnaireBatch.BatchName].ToString().Trim(); //批次名称
objQuestionnaireBatchEN.RoleId = objRow[conQuestionnaireBatch.RoleId] == DBNull.Value ? null : objRow[conQuestionnaireBatch.RoleId].ToString().Trim(); //角色Id
objQuestionnaireBatchEN.QuestionnaireSetId = objRow[conQuestionnaireBatch.QuestionnaireSetId] == DBNull.Value ? null : objRow[conQuestionnaireBatch.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objQuestionnaireBatchEN.IsDefault = TransNullToBool(objRow[conQuestionnaireBatch.IsDefault].ToString().Trim()); //是否默认
objQuestionnaireBatchEN.IsDefaultUser = TransNullToBool(objRow[conQuestionnaireBatch.IsDefaultUser].ToString().Trim()); //是否默认用户
objQuestionnaireBatchEN.CreateDate = objRow[conQuestionnaireBatch.CreateDate].ToString().Trim(); //建立日期
objQuestionnaireBatchEN.CreateUser = objRow[conQuestionnaireBatch.CreateUser].ToString().Trim(); //建立用户
objQuestionnaireBatchEN.PageName = objRow[conQuestionnaireBatch.PageName] == DBNull.Value ? null : objRow[conQuestionnaireBatch.PageName].ToString().Trim(); //页面名称
objQuestionnaireBatchEN.IsRandomSelSet = TransNullToBool(objRow[conQuestionnaireBatch.IsRandomSelSet].ToString().Trim()); //是否随机选问卷集
objQuestionnaireBatchEN.UpdDate = objRow[conQuestionnaireBatch.UpdDate].ToString().Trim(); //修改日期
objQuestionnaireBatchEN.UpdUser = objRow[conQuestionnaireBatch.UpdUser].ToString().Trim(); //修改人
objQuestionnaireBatchEN.Memo = objRow[conQuestionnaireBatch.Memo] == DBNull.Value ? null : objRow[conQuestionnaireBatch.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsQuestionnaireBatchDA: GetObjLst)", objException.Message));
}
objQuestionnaireBatchEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQuestionnaireBatchEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objQuestionnaireBatchEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetQuestionnaireBatch(ref clsQuestionnaireBatchEN objQuestionnaireBatchEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireBatchDA.GetSpecSQLObj();
strSQL = "Select * from QuestionnaireBatch where BatchId = " + "'"+ objQuestionnaireBatchEN.BatchId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objQuestionnaireBatchEN.BatchId = objDT.Rows[0][conQuestionnaireBatch.BatchId].ToString().Trim(); //批次ID(字段类型:char,字段长度:4,是否可空:True)
 objQuestionnaireBatchEN.BatchName = objDT.Rows[0][conQuestionnaireBatch.BatchName].ToString().Trim(); //批次名称(字段类型:varchar,字段长度:50,是否可空:True)
 objQuestionnaireBatchEN.RoleId = objDT.Rows[0][conQuestionnaireBatch.RoleId].ToString().Trim(); //角色Id(字段类型:char,字段长度:8,是否可空:True)
 objQuestionnaireBatchEN.QuestionnaireSetId = objDT.Rows[0][conQuestionnaireBatch.QuestionnaireSetId].ToString().Trim(); //问卷集ID(字段类型:char,字段长度:4,是否可空:True)
 objQuestionnaireBatchEN.IsDefault = TransNullToBool(objDT.Rows[0][conQuestionnaireBatch.IsDefault].ToString().Trim()); //是否默认(字段类型:bit,字段长度:1,是否可空:True)
 objQuestionnaireBatchEN.IsDefaultUser = TransNullToBool(objDT.Rows[0][conQuestionnaireBatch.IsDefaultUser].ToString().Trim()); //是否默认用户(字段类型:bit,字段长度:1,是否可空:False)
 objQuestionnaireBatchEN.CreateDate = objDT.Rows[0][conQuestionnaireBatch.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objQuestionnaireBatchEN.CreateUser = objDT.Rows[0][conQuestionnaireBatch.CreateUser].ToString().Trim(); //建立用户(字段类型:varchar,字段长度:50,是否可空:True)
 objQuestionnaireBatchEN.PageName = objDT.Rows[0][conQuestionnaireBatch.PageName].ToString().Trim(); //页面名称(字段类型:varchar,字段长度:100,是否可空:True)
 objQuestionnaireBatchEN.IsRandomSelSet = TransNullToBool(objDT.Rows[0][conQuestionnaireBatch.IsRandomSelSet].ToString().Trim()); //是否随机选问卷集(字段类型:bit,字段长度:1,是否可空:True)
 objQuestionnaireBatchEN.UpdDate = objDT.Rows[0][conQuestionnaireBatch.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objQuestionnaireBatchEN.UpdUser = objDT.Rows[0][conQuestionnaireBatch.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objQuestionnaireBatchEN.Memo = objDT.Rows[0][conQuestionnaireBatch.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsQuestionnaireBatchDA: GetQuestionnaireBatch)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strBatchId">表关键字</param>
 /// <returns>表对象</returns>
public clsQuestionnaireBatchEN GetObjByBatchId(string strBatchId)
{
CheckPrimaryKey(strBatchId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireBatchDA.GetSpecSQLObj();
strSQL = "Select * from QuestionnaireBatch where BatchId = " + "'"+ strBatchId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsQuestionnaireBatchEN objQuestionnaireBatchEN = new clsQuestionnaireBatchEN();
try
{
 objQuestionnaireBatchEN.BatchId = objRow[conQuestionnaireBatch.BatchId].ToString().Trim(); //批次ID(字段类型:char,字段长度:4,是否可空:True)
 objQuestionnaireBatchEN.BatchName = objRow[conQuestionnaireBatch.BatchName].ToString().Trim(); //批次名称(字段类型:varchar,字段长度:50,是否可空:True)
 objQuestionnaireBatchEN.RoleId = objRow[conQuestionnaireBatch.RoleId] == DBNull.Value ? null : objRow[conQuestionnaireBatch.RoleId].ToString().Trim(); //角色Id(字段类型:char,字段长度:8,是否可空:True)
 objQuestionnaireBatchEN.QuestionnaireSetId = objRow[conQuestionnaireBatch.QuestionnaireSetId] == DBNull.Value ? null : objRow[conQuestionnaireBatch.QuestionnaireSetId].ToString().Trim(); //问卷集ID(字段类型:char,字段长度:4,是否可空:True)
 objQuestionnaireBatchEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireBatch.IsDefault].ToString().Trim()); //是否默认(字段类型:bit,字段长度:1,是否可空:True)
 objQuestionnaireBatchEN.IsDefaultUser = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireBatch.IsDefaultUser].ToString().Trim()); //是否默认用户(字段类型:bit,字段长度:1,是否可空:False)
 objQuestionnaireBatchEN.CreateDate = objRow[conQuestionnaireBatch.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objQuestionnaireBatchEN.CreateUser = objRow[conQuestionnaireBatch.CreateUser].ToString().Trim(); //建立用户(字段类型:varchar,字段长度:50,是否可空:True)
 objQuestionnaireBatchEN.PageName = objRow[conQuestionnaireBatch.PageName] == DBNull.Value ? null : objRow[conQuestionnaireBatch.PageName].ToString().Trim(); //页面名称(字段类型:varchar,字段长度:100,是否可空:True)
 objQuestionnaireBatchEN.IsRandomSelSet = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireBatch.IsRandomSelSet].ToString().Trim()); //是否随机选问卷集(字段类型:bit,字段长度:1,是否可空:True)
 objQuestionnaireBatchEN.UpdDate = objRow[conQuestionnaireBatch.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objQuestionnaireBatchEN.UpdUser = objRow[conQuestionnaireBatch.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objQuestionnaireBatchEN.Memo = objRow[conQuestionnaireBatch.Memo] == DBNull.Value ? null : objRow[conQuestionnaireBatch.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsQuestionnaireBatchDA: GetObjByBatchId)", objException.Message));
}
return objQuestionnaireBatchEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsQuestionnaireBatchEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsQuestionnaireBatchDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireBatchDA.GetSpecSQLObj();
strSQL = "Select * from QuestionnaireBatch where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsQuestionnaireBatchEN objQuestionnaireBatchEN = new clsQuestionnaireBatchEN()
{
BatchId = objRow[conQuestionnaireBatch.BatchId].ToString().Trim(), //批次ID
BatchName = objRow[conQuestionnaireBatch.BatchName].ToString().Trim(), //批次名称
RoleId = objRow[conQuestionnaireBatch.RoleId] == DBNull.Value ? null : objRow[conQuestionnaireBatch.RoleId].ToString().Trim(), //角色Id
QuestionnaireSetId = objRow[conQuestionnaireBatch.QuestionnaireSetId] == DBNull.Value ? null : objRow[conQuestionnaireBatch.QuestionnaireSetId].ToString().Trim(), //问卷集ID
IsDefault = TransNullToBool(objRow[conQuestionnaireBatch.IsDefault].ToString().Trim()), //是否默认
IsDefaultUser = TransNullToBool(objRow[conQuestionnaireBatch.IsDefaultUser].ToString().Trim()), //是否默认用户
CreateDate = objRow[conQuestionnaireBatch.CreateDate].ToString().Trim(), //建立日期
CreateUser = objRow[conQuestionnaireBatch.CreateUser].ToString().Trim(), //建立用户
PageName = objRow[conQuestionnaireBatch.PageName] == DBNull.Value ? null : objRow[conQuestionnaireBatch.PageName].ToString().Trim(), //页面名称
IsRandomSelSet = TransNullToBool(objRow[conQuestionnaireBatch.IsRandomSelSet].ToString().Trim()), //是否随机选问卷集
UpdDate = objRow[conQuestionnaireBatch.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conQuestionnaireBatch.UpdUser].ToString().Trim(), //修改人
Memo = objRow[conQuestionnaireBatch.Memo] == DBNull.Value ? null : objRow[conQuestionnaireBatch.Memo].ToString().Trim() //备注
};
objQuestionnaireBatchEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQuestionnaireBatchEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsQuestionnaireBatchDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsQuestionnaireBatchEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsQuestionnaireBatchEN objQuestionnaireBatchEN = new clsQuestionnaireBatchEN();
try
{
objQuestionnaireBatchEN.BatchId = objRow[conQuestionnaireBatch.BatchId].ToString().Trim(); //批次ID
objQuestionnaireBatchEN.BatchName = objRow[conQuestionnaireBatch.BatchName].ToString().Trim(); //批次名称
objQuestionnaireBatchEN.RoleId = objRow[conQuestionnaireBatch.RoleId] == DBNull.Value ? null : objRow[conQuestionnaireBatch.RoleId].ToString().Trim(); //角色Id
objQuestionnaireBatchEN.QuestionnaireSetId = objRow[conQuestionnaireBatch.QuestionnaireSetId] == DBNull.Value ? null : objRow[conQuestionnaireBatch.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objQuestionnaireBatchEN.IsDefault = TransNullToBool(objRow[conQuestionnaireBatch.IsDefault].ToString().Trim()); //是否默认
objQuestionnaireBatchEN.IsDefaultUser = TransNullToBool(objRow[conQuestionnaireBatch.IsDefaultUser].ToString().Trim()); //是否默认用户
objQuestionnaireBatchEN.CreateDate = objRow[conQuestionnaireBatch.CreateDate].ToString().Trim(); //建立日期
objQuestionnaireBatchEN.CreateUser = objRow[conQuestionnaireBatch.CreateUser].ToString().Trim(); //建立用户
objQuestionnaireBatchEN.PageName = objRow[conQuestionnaireBatch.PageName] == DBNull.Value ? null : objRow[conQuestionnaireBatch.PageName].ToString().Trim(); //页面名称
objQuestionnaireBatchEN.IsRandomSelSet = TransNullToBool(objRow[conQuestionnaireBatch.IsRandomSelSet].ToString().Trim()); //是否随机选问卷集
objQuestionnaireBatchEN.UpdDate = objRow[conQuestionnaireBatch.UpdDate].ToString().Trim(); //修改日期
objQuestionnaireBatchEN.UpdUser = objRow[conQuestionnaireBatch.UpdUser].ToString().Trim(); //修改人
objQuestionnaireBatchEN.Memo = objRow[conQuestionnaireBatch.Memo] == DBNull.Value ? null : objRow[conQuestionnaireBatch.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsQuestionnaireBatchDA: GetObjByDataRowQuestionnaireBatch)", objException.Message));
}
objQuestionnaireBatchEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQuestionnaireBatchEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsQuestionnaireBatchEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsQuestionnaireBatchEN objQuestionnaireBatchEN = new clsQuestionnaireBatchEN();
try
{
objQuestionnaireBatchEN.BatchId = objRow[conQuestionnaireBatch.BatchId].ToString().Trim(); //批次ID
objQuestionnaireBatchEN.BatchName = objRow[conQuestionnaireBatch.BatchName].ToString().Trim(); //批次名称
objQuestionnaireBatchEN.RoleId = objRow[conQuestionnaireBatch.RoleId] == DBNull.Value ? null : objRow[conQuestionnaireBatch.RoleId].ToString().Trim(); //角色Id
objQuestionnaireBatchEN.QuestionnaireSetId = objRow[conQuestionnaireBatch.QuestionnaireSetId] == DBNull.Value ? null : objRow[conQuestionnaireBatch.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objQuestionnaireBatchEN.IsDefault = TransNullToBool(objRow[conQuestionnaireBatch.IsDefault].ToString().Trim()); //是否默认
objQuestionnaireBatchEN.IsDefaultUser = TransNullToBool(objRow[conQuestionnaireBatch.IsDefaultUser].ToString().Trim()); //是否默认用户
objQuestionnaireBatchEN.CreateDate = objRow[conQuestionnaireBatch.CreateDate].ToString().Trim(); //建立日期
objQuestionnaireBatchEN.CreateUser = objRow[conQuestionnaireBatch.CreateUser].ToString().Trim(); //建立用户
objQuestionnaireBatchEN.PageName = objRow[conQuestionnaireBatch.PageName] == DBNull.Value ? null : objRow[conQuestionnaireBatch.PageName].ToString().Trim(); //页面名称
objQuestionnaireBatchEN.IsRandomSelSet = TransNullToBool(objRow[conQuestionnaireBatch.IsRandomSelSet].ToString().Trim()); //是否随机选问卷集
objQuestionnaireBatchEN.UpdDate = objRow[conQuestionnaireBatch.UpdDate].ToString().Trim(); //修改日期
objQuestionnaireBatchEN.UpdUser = objRow[conQuestionnaireBatch.UpdUser].ToString().Trim(); //修改人
objQuestionnaireBatchEN.Memo = objRow[conQuestionnaireBatch.Memo] == DBNull.Value ? null : objRow[conQuestionnaireBatch.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsQuestionnaireBatchDA: GetObjByDataRow)", objException.Message));
}
objQuestionnaireBatchEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQuestionnaireBatchEN;
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
objSQL = clsQuestionnaireBatchDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsQuestionnaireBatchEN._CurrTabName, conQuestionnaireBatch.BatchId, 4, "");
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
objSQL = clsQuestionnaireBatchDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsQuestionnaireBatchEN._CurrTabName, conQuestionnaireBatch.BatchId, 4, strPrefix);
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
 objSQL = clsQuestionnaireBatchDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select BatchId from QuestionnaireBatch where " + strCondition;
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
 objSQL = clsQuestionnaireBatchDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select BatchId from QuestionnaireBatch where " + strCondition;
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
 /// <param name = "strBatchId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strBatchId)
{
CheckPrimaryKey(strBatchId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireBatchDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("QuestionnaireBatch", "BatchId = " + "'"+ strBatchId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsQuestionnaireBatchDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireBatchDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("QuestionnaireBatch", strCondition))
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
objSQL = clsQuestionnaireBatchDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("QuestionnaireBatch");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsQuestionnaireBatchEN objQuestionnaireBatchEN)
 {
 objQuestionnaireBatchEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQuestionnaireBatchEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQuestionnaireBatchEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireBatchDA.GetSpecSQLObj();
strSQL = "Select * from QuestionnaireBatch where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "QuestionnaireBatch");
objRow = objDS.Tables["QuestionnaireBatch"].NewRow();
objRow[conQuestionnaireBatch.BatchId] = objQuestionnaireBatchEN.BatchId; //批次ID
objRow[conQuestionnaireBatch.BatchName] = objQuestionnaireBatchEN.BatchName; //批次名称
 if (objQuestionnaireBatchEN.RoleId !=  "")
 {
objRow[conQuestionnaireBatch.RoleId] = objQuestionnaireBatchEN.RoleId; //角色Id
 }
 if (objQuestionnaireBatchEN.QuestionnaireSetId !=  "")
 {
objRow[conQuestionnaireBatch.QuestionnaireSetId] = objQuestionnaireBatchEN.QuestionnaireSetId; //问卷集ID
 }
objRow[conQuestionnaireBatch.IsDefault] = objQuestionnaireBatchEN.IsDefault; //是否默认
objRow[conQuestionnaireBatch.IsDefaultUser] = objQuestionnaireBatchEN.IsDefaultUser; //是否默认用户
objRow[conQuestionnaireBatch.CreateDate] = objQuestionnaireBatchEN.CreateDate; //建立日期
objRow[conQuestionnaireBatch.CreateUser] = objQuestionnaireBatchEN.CreateUser; //建立用户
 if (objQuestionnaireBatchEN.PageName !=  "")
 {
objRow[conQuestionnaireBatch.PageName] = objQuestionnaireBatchEN.PageName; //页面名称
 }
objRow[conQuestionnaireBatch.IsRandomSelSet] = objQuestionnaireBatchEN.IsRandomSelSet; //是否随机选问卷集
objRow[conQuestionnaireBatch.UpdDate] = objQuestionnaireBatchEN.UpdDate; //修改日期
objRow[conQuestionnaireBatch.UpdUser] = objQuestionnaireBatchEN.UpdUser; //修改人
 if (objQuestionnaireBatchEN.Memo !=  "")
 {
objRow[conQuestionnaireBatch.Memo] = objQuestionnaireBatchEN.Memo; //备注
 }
objDS.Tables[clsQuestionnaireBatchEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsQuestionnaireBatchEN._CurrTabName);
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
 /// <param name = "objQuestionnaireBatchEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsQuestionnaireBatchEN objQuestionnaireBatchEN)
{
 objQuestionnaireBatchEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQuestionnaireBatchEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQuestionnaireBatchEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objQuestionnaireBatchEN.BatchId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireBatch.BatchId);
 var strBatchId = objQuestionnaireBatchEN.BatchId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strBatchId + "'");
 }
 
 if (objQuestionnaireBatchEN.BatchName !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireBatch.BatchName);
 var strBatchName = objQuestionnaireBatchEN.BatchName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strBatchName + "'");
 }
 
 if (objQuestionnaireBatchEN.RoleId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireBatch.RoleId);
 var strRoleId = objQuestionnaireBatchEN.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRoleId + "'");
 }
 
 if (objQuestionnaireBatchEN.QuestionnaireSetId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireBatch.QuestionnaireSetId);
 var strQuestionnaireSetId = objQuestionnaireBatchEN.QuestionnaireSetId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionnaireSetId + "'");
 }
 
 arrFieldListForInsert.Add(conQuestionnaireBatch.IsDefault);
 arrValueListForInsert.Add("'" + (objQuestionnaireBatchEN.IsDefault  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conQuestionnaireBatch.IsDefaultUser);
 arrValueListForInsert.Add("'" + (objQuestionnaireBatchEN.IsDefaultUser  ==  false ? "0" : "1") + "'");
 
 if (objQuestionnaireBatchEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireBatch.CreateDate);
 var strCreateDate = objQuestionnaireBatchEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objQuestionnaireBatchEN.CreateUser !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireBatch.CreateUser);
 var strCreateUser = objQuestionnaireBatchEN.CreateUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateUser + "'");
 }
 
 if (objQuestionnaireBatchEN.PageName !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireBatch.PageName);
 var strPageName = objQuestionnaireBatchEN.PageName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPageName + "'");
 }
 
 arrFieldListForInsert.Add(conQuestionnaireBatch.IsRandomSelSet);
 arrValueListForInsert.Add("'" + (objQuestionnaireBatchEN.IsRandomSelSet  ==  false ? "0" : "1") + "'");
 
 if (objQuestionnaireBatchEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireBatch.UpdDate);
 var strUpdDate = objQuestionnaireBatchEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQuestionnaireBatchEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireBatch.UpdUser);
 var strUpdUser = objQuestionnaireBatchEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objQuestionnaireBatchEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireBatch.Memo);
 var strMemo = objQuestionnaireBatchEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QuestionnaireBatch");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireBatchDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objQuestionnaireBatchEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsQuestionnaireBatchEN objQuestionnaireBatchEN)
{
 objQuestionnaireBatchEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQuestionnaireBatchEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQuestionnaireBatchEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objQuestionnaireBatchEN.BatchId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireBatch.BatchId);
 var strBatchId = objQuestionnaireBatchEN.BatchId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strBatchId + "'");
 }
 
 if (objQuestionnaireBatchEN.BatchName !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireBatch.BatchName);
 var strBatchName = objQuestionnaireBatchEN.BatchName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strBatchName + "'");
 }
 
 if (objQuestionnaireBatchEN.RoleId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireBatch.RoleId);
 var strRoleId = objQuestionnaireBatchEN.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRoleId + "'");
 }
 
 if (objQuestionnaireBatchEN.QuestionnaireSetId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireBatch.QuestionnaireSetId);
 var strQuestionnaireSetId = objQuestionnaireBatchEN.QuestionnaireSetId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionnaireSetId + "'");
 }
 
 arrFieldListForInsert.Add(conQuestionnaireBatch.IsDefault);
 arrValueListForInsert.Add("'" + (objQuestionnaireBatchEN.IsDefault  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conQuestionnaireBatch.IsDefaultUser);
 arrValueListForInsert.Add("'" + (objQuestionnaireBatchEN.IsDefaultUser  ==  false ? "0" : "1") + "'");
 
 if (objQuestionnaireBatchEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireBatch.CreateDate);
 var strCreateDate = objQuestionnaireBatchEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objQuestionnaireBatchEN.CreateUser !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireBatch.CreateUser);
 var strCreateUser = objQuestionnaireBatchEN.CreateUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateUser + "'");
 }
 
 if (objQuestionnaireBatchEN.PageName !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireBatch.PageName);
 var strPageName = objQuestionnaireBatchEN.PageName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPageName + "'");
 }
 
 arrFieldListForInsert.Add(conQuestionnaireBatch.IsRandomSelSet);
 arrValueListForInsert.Add("'" + (objQuestionnaireBatchEN.IsRandomSelSet  ==  false ? "0" : "1") + "'");
 
 if (objQuestionnaireBatchEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireBatch.UpdDate);
 var strUpdDate = objQuestionnaireBatchEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQuestionnaireBatchEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireBatch.UpdUser);
 var strUpdUser = objQuestionnaireBatchEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objQuestionnaireBatchEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireBatch.Memo);
 var strMemo = objQuestionnaireBatchEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QuestionnaireBatch");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireBatchDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objQuestionnaireBatchEN.BatchId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objQuestionnaireBatchEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsQuestionnaireBatchEN objQuestionnaireBatchEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objQuestionnaireBatchEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQuestionnaireBatchEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQuestionnaireBatchEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objQuestionnaireBatchEN.BatchId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireBatch.BatchId);
 var strBatchId = objQuestionnaireBatchEN.BatchId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strBatchId + "'");
 }
 
 if (objQuestionnaireBatchEN.BatchName !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireBatch.BatchName);
 var strBatchName = objQuestionnaireBatchEN.BatchName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strBatchName + "'");
 }
 
 if (objQuestionnaireBatchEN.RoleId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireBatch.RoleId);
 var strRoleId = objQuestionnaireBatchEN.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRoleId + "'");
 }
 
 if (objQuestionnaireBatchEN.QuestionnaireSetId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireBatch.QuestionnaireSetId);
 var strQuestionnaireSetId = objQuestionnaireBatchEN.QuestionnaireSetId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionnaireSetId + "'");
 }
 
 arrFieldListForInsert.Add(conQuestionnaireBatch.IsDefault);
 arrValueListForInsert.Add("'" + (objQuestionnaireBatchEN.IsDefault  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conQuestionnaireBatch.IsDefaultUser);
 arrValueListForInsert.Add("'" + (objQuestionnaireBatchEN.IsDefaultUser  ==  false ? "0" : "1") + "'");
 
 if (objQuestionnaireBatchEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireBatch.CreateDate);
 var strCreateDate = objQuestionnaireBatchEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objQuestionnaireBatchEN.CreateUser !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireBatch.CreateUser);
 var strCreateUser = objQuestionnaireBatchEN.CreateUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateUser + "'");
 }
 
 if (objQuestionnaireBatchEN.PageName !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireBatch.PageName);
 var strPageName = objQuestionnaireBatchEN.PageName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPageName + "'");
 }
 
 arrFieldListForInsert.Add(conQuestionnaireBatch.IsRandomSelSet);
 arrValueListForInsert.Add("'" + (objQuestionnaireBatchEN.IsRandomSelSet  ==  false ? "0" : "1") + "'");
 
 if (objQuestionnaireBatchEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireBatch.UpdDate);
 var strUpdDate = objQuestionnaireBatchEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQuestionnaireBatchEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireBatch.UpdUser);
 var strUpdUser = objQuestionnaireBatchEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objQuestionnaireBatchEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireBatch.Memo);
 var strMemo = objQuestionnaireBatchEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QuestionnaireBatch");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireBatchDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objQuestionnaireBatchEN.BatchId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objQuestionnaireBatchEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsQuestionnaireBatchEN objQuestionnaireBatchEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objQuestionnaireBatchEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQuestionnaireBatchEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQuestionnaireBatchEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objQuestionnaireBatchEN.BatchId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireBatch.BatchId);
 var strBatchId = objQuestionnaireBatchEN.BatchId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strBatchId + "'");
 }
 
 if (objQuestionnaireBatchEN.BatchName !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireBatch.BatchName);
 var strBatchName = objQuestionnaireBatchEN.BatchName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strBatchName + "'");
 }
 
 if (objQuestionnaireBatchEN.RoleId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireBatch.RoleId);
 var strRoleId = objQuestionnaireBatchEN.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRoleId + "'");
 }
 
 if (objQuestionnaireBatchEN.QuestionnaireSetId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireBatch.QuestionnaireSetId);
 var strQuestionnaireSetId = objQuestionnaireBatchEN.QuestionnaireSetId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionnaireSetId + "'");
 }
 
 arrFieldListForInsert.Add(conQuestionnaireBatch.IsDefault);
 arrValueListForInsert.Add("'" + (objQuestionnaireBatchEN.IsDefault  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conQuestionnaireBatch.IsDefaultUser);
 arrValueListForInsert.Add("'" + (objQuestionnaireBatchEN.IsDefaultUser  ==  false ? "0" : "1") + "'");
 
 if (objQuestionnaireBatchEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireBatch.CreateDate);
 var strCreateDate = objQuestionnaireBatchEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objQuestionnaireBatchEN.CreateUser !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireBatch.CreateUser);
 var strCreateUser = objQuestionnaireBatchEN.CreateUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateUser + "'");
 }
 
 if (objQuestionnaireBatchEN.PageName !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireBatch.PageName);
 var strPageName = objQuestionnaireBatchEN.PageName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPageName + "'");
 }
 
 arrFieldListForInsert.Add(conQuestionnaireBatch.IsRandomSelSet);
 arrValueListForInsert.Add("'" + (objQuestionnaireBatchEN.IsRandomSelSet  ==  false ? "0" : "1") + "'");
 
 if (objQuestionnaireBatchEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireBatch.UpdDate);
 var strUpdDate = objQuestionnaireBatchEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQuestionnaireBatchEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireBatch.UpdUser);
 var strUpdUser = objQuestionnaireBatchEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objQuestionnaireBatchEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireBatch.Memo);
 var strMemo = objQuestionnaireBatchEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QuestionnaireBatch");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireBatchDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewQuestionnaireBatchs(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireBatchDA.GetSpecSQLObj();
strSQL = "Select * from QuestionnaireBatch where BatchId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "QuestionnaireBatch");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strBatchId = oRow[conQuestionnaireBatch.BatchId].ToString().Trim();
if (IsExist(strBatchId))
{
 string strResult = "关键字变量值为:" + string.Format("BatchId = {0}", strBatchId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsQuestionnaireBatchEN._CurrTabName ].NewRow();
objRow[conQuestionnaireBatch.BatchId] = oRow[conQuestionnaireBatch.BatchId].ToString().Trim(); //批次ID
objRow[conQuestionnaireBatch.BatchName] = oRow[conQuestionnaireBatch.BatchName].ToString().Trim(); //批次名称
objRow[conQuestionnaireBatch.RoleId] = oRow[conQuestionnaireBatch.RoleId].ToString().Trim(); //角色Id
objRow[conQuestionnaireBatch.QuestionnaireSetId] = oRow[conQuestionnaireBatch.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objRow[conQuestionnaireBatch.IsDefault] = oRow[conQuestionnaireBatch.IsDefault].ToString().Trim(); //是否默认
objRow[conQuestionnaireBatch.IsDefaultUser] = oRow[conQuestionnaireBatch.IsDefaultUser].ToString().Trim(); //是否默认用户
objRow[conQuestionnaireBatch.CreateDate] = oRow[conQuestionnaireBatch.CreateDate].ToString().Trim(); //建立日期
objRow[conQuestionnaireBatch.CreateUser] = oRow[conQuestionnaireBatch.CreateUser].ToString().Trim(); //建立用户
objRow[conQuestionnaireBatch.PageName] = oRow[conQuestionnaireBatch.PageName].ToString().Trim(); //页面名称
objRow[conQuestionnaireBatch.IsRandomSelSet] = oRow[conQuestionnaireBatch.IsRandomSelSet].ToString().Trim(); //是否随机选问卷集
objRow[conQuestionnaireBatch.UpdDate] = oRow[conQuestionnaireBatch.UpdDate].ToString().Trim(); //修改日期
objRow[conQuestionnaireBatch.UpdUser] = oRow[conQuestionnaireBatch.UpdUser].ToString().Trim(); //修改人
objRow[conQuestionnaireBatch.Memo] = oRow[conQuestionnaireBatch.Memo].ToString().Trim(); //备注
 objDS.Tables[clsQuestionnaireBatchEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsQuestionnaireBatchEN._CurrTabName);
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
 /// <param name = "objQuestionnaireBatchEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsQuestionnaireBatchEN objQuestionnaireBatchEN)
{
 objQuestionnaireBatchEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQuestionnaireBatchEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQuestionnaireBatchEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireBatchDA.GetSpecSQLObj();
strSQL = "Select * from QuestionnaireBatch where BatchId = " + "'"+ objQuestionnaireBatchEN.BatchId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsQuestionnaireBatchEN._CurrTabName);
if (objDS.Tables[clsQuestionnaireBatchEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:BatchId = " + "'"+ objQuestionnaireBatchEN.BatchId+"'");
return false;
}
objRow = objDS.Tables[clsQuestionnaireBatchEN._CurrTabName].Rows[0];
 if (objQuestionnaireBatchEN.IsUpdated(conQuestionnaireBatch.BatchId))
 {
objRow[conQuestionnaireBatch.BatchId] = objQuestionnaireBatchEN.BatchId; //批次ID
 }
 if (objQuestionnaireBatchEN.IsUpdated(conQuestionnaireBatch.BatchName))
 {
objRow[conQuestionnaireBatch.BatchName] = objQuestionnaireBatchEN.BatchName; //批次名称
 }
 if (objQuestionnaireBatchEN.IsUpdated(conQuestionnaireBatch.RoleId))
 {
objRow[conQuestionnaireBatch.RoleId] = objQuestionnaireBatchEN.RoleId; //角色Id
 }
 if (objQuestionnaireBatchEN.IsUpdated(conQuestionnaireBatch.QuestionnaireSetId))
 {
objRow[conQuestionnaireBatch.QuestionnaireSetId] = objQuestionnaireBatchEN.QuestionnaireSetId; //问卷集ID
 }
 if (objQuestionnaireBatchEN.IsUpdated(conQuestionnaireBatch.IsDefault))
 {
objRow[conQuestionnaireBatch.IsDefault] = objQuestionnaireBatchEN.IsDefault; //是否默认
 }
 if (objQuestionnaireBatchEN.IsUpdated(conQuestionnaireBatch.IsDefaultUser))
 {
objRow[conQuestionnaireBatch.IsDefaultUser] = objQuestionnaireBatchEN.IsDefaultUser; //是否默认用户
 }
 if (objQuestionnaireBatchEN.IsUpdated(conQuestionnaireBatch.CreateDate))
 {
objRow[conQuestionnaireBatch.CreateDate] = objQuestionnaireBatchEN.CreateDate; //建立日期
 }
 if (objQuestionnaireBatchEN.IsUpdated(conQuestionnaireBatch.CreateUser))
 {
objRow[conQuestionnaireBatch.CreateUser] = objQuestionnaireBatchEN.CreateUser; //建立用户
 }
 if (objQuestionnaireBatchEN.IsUpdated(conQuestionnaireBatch.PageName))
 {
objRow[conQuestionnaireBatch.PageName] = objQuestionnaireBatchEN.PageName; //页面名称
 }
 if (objQuestionnaireBatchEN.IsUpdated(conQuestionnaireBatch.IsRandomSelSet))
 {
objRow[conQuestionnaireBatch.IsRandomSelSet] = objQuestionnaireBatchEN.IsRandomSelSet; //是否随机选问卷集
 }
 if (objQuestionnaireBatchEN.IsUpdated(conQuestionnaireBatch.UpdDate))
 {
objRow[conQuestionnaireBatch.UpdDate] = objQuestionnaireBatchEN.UpdDate; //修改日期
 }
 if (objQuestionnaireBatchEN.IsUpdated(conQuestionnaireBatch.UpdUser))
 {
objRow[conQuestionnaireBatch.UpdUser] = objQuestionnaireBatchEN.UpdUser; //修改人
 }
 if (objQuestionnaireBatchEN.IsUpdated(conQuestionnaireBatch.Memo))
 {
objRow[conQuestionnaireBatch.Memo] = objQuestionnaireBatchEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsQuestionnaireBatchEN._CurrTabName);
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
 /// <param name = "objQuestionnaireBatchEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsQuestionnaireBatchEN objQuestionnaireBatchEN)
{
 objQuestionnaireBatchEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQuestionnaireBatchEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQuestionnaireBatchEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireBatchDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update QuestionnaireBatch Set ");
 
 if (objQuestionnaireBatchEN.IsUpdated(conQuestionnaireBatch.BatchName))
 {
 if (objQuestionnaireBatchEN.BatchName !=  null)
 {
 var strBatchName = objQuestionnaireBatchEN.BatchName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strBatchName, conQuestionnaireBatch.BatchName); //批次名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireBatch.BatchName); //批次名称
 }
 }
 
 if (objQuestionnaireBatchEN.IsUpdated(conQuestionnaireBatch.RoleId))
 {
 if (objQuestionnaireBatchEN.RoleId !=  null)
 {
 var strRoleId = objQuestionnaireBatchEN.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRoleId, conQuestionnaireBatch.RoleId); //角色Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireBatch.RoleId); //角色Id
 }
 }
 
 if (objQuestionnaireBatchEN.IsUpdated(conQuestionnaireBatch.QuestionnaireSetId))
 {
 if (objQuestionnaireBatchEN.QuestionnaireSetId !=  null)
 {
 var strQuestionnaireSetId = objQuestionnaireBatchEN.QuestionnaireSetId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionnaireSetId, conQuestionnaireBatch.QuestionnaireSetId); //问卷集ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireBatch.QuestionnaireSetId); //问卷集ID
 }
 }
 
 if (objQuestionnaireBatchEN.IsUpdated(conQuestionnaireBatch.IsDefault))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQuestionnaireBatchEN.IsDefault == true?"1":"0", conQuestionnaireBatch.IsDefault); //是否默认
 }
 
 if (objQuestionnaireBatchEN.IsUpdated(conQuestionnaireBatch.IsDefaultUser))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQuestionnaireBatchEN.IsDefaultUser == true?"1":"0", conQuestionnaireBatch.IsDefaultUser); //是否默认用户
 }
 
 if (objQuestionnaireBatchEN.IsUpdated(conQuestionnaireBatch.CreateDate))
 {
 if (objQuestionnaireBatchEN.CreateDate !=  null)
 {
 var strCreateDate = objQuestionnaireBatchEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateDate, conQuestionnaireBatch.CreateDate); //建立日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireBatch.CreateDate); //建立日期
 }
 }
 
 if (objQuestionnaireBatchEN.IsUpdated(conQuestionnaireBatch.CreateUser))
 {
 if (objQuestionnaireBatchEN.CreateUser !=  null)
 {
 var strCreateUser = objQuestionnaireBatchEN.CreateUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateUser, conQuestionnaireBatch.CreateUser); //建立用户
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireBatch.CreateUser); //建立用户
 }
 }
 
 if (objQuestionnaireBatchEN.IsUpdated(conQuestionnaireBatch.PageName))
 {
 if (objQuestionnaireBatchEN.PageName !=  null)
 {
 var strPageName = objQuestionnaireBatchEN.PageName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPageName, conQuestionnaireBatch.PageName); //页面名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireBatch.PageName); //页面名称
 }
 }
 
 if (objQuestionnaireBatchEN.IsUpdated(conQuestionnaireBatch.IsRandomSelSet))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQuestionnaireBatchEN.IsRandomSelSet == true?"1":"0", conQuestionnaireBatch.IsRandomSelSet); //是否随机选问卷集
 }
 
 if (objQuestionnaireBatchEN.IsUpdated(conQuestionnaireBatch.UpdDate))
 {
 if (objQuestionnaireBatchEN.UpdDate !=  null)
 {
 var strUpdDate = objQuestionnaireBatchEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conQuestionnaireBatch.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireBatch.UpdDate); //修改日期
 }
 }
 
 if (objQuestionnaireBatchEN.IsUpdated(conQuestionnaireBatch.UpdUser))
 {
 if (objQuestionnaireBatchEN.UpdUser !=  null)
 {
 var strUpdUser = objQuestionnaireBatchEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conQuestionnaireBatch.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireBatch.UpdUser); //修改人
 }
 }
 
 if (objQuestionnaireBatchEN.IsUpdated(conQuestionnaireBatch.Memo))
 {
 if (objQuestionnaireBatchEN.Memo !=  null)
 {
 var strMemo = objQuestionnaireBatchEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conQuestionnaireBatch.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireBatch.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where BatchId = '{0}'", objQuestionnaireBatchEN.BatchId); 
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
 /// <param name = "objQuestionnaireBatchEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsQuestionnaireBatchEN objQuestionnaireBatchEN, string strCondition)
{
 objQuestionnaireBatchEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQuestionnaireBatchEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQuestionnaireBatchEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireBatchDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QuestionnaireBatch Set ");
 
 if (objQuestionnaireBatchEN.IsUpdated(conQuestionnaireBatch.BatchName))
 {
 if (objQuestionnaireBatchEN.BatchName !=  null)
 {
 var strBatchName = objQuestionnaireBatchEN.BatchName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" BatchName = '{0}',", strBatchName); //批次名称
 }
 else
 {
 sbSQL.Append(" BatchName = null,"); //批次名称
 }
 }
 
 if (objQuestionnaireBatchEN.IsUpdated(conQuestionnaireBatch.RoleId))
 {
 if (objQuestionnaireBatchEN.RoleId !=  null)
 {
 var strRoleId = objQuestionnaireBatchEN.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RoleId = '{0}',", strRoleId); //角色Id
 }
 else
 {
 sbSQL.Append(" RoleId = null,"); //角色Id
 }
 }
 
 if (objQuestionnaireBatchEN.IsUpdated(conQuestionnaireBatch.QuestionnaireSetId))
 {
 if (objQuestionnaireBatchEN.QuestionnaireSetId !=  null)
 {
 var strQuestionnaireSetId = objQuestionnaireBatchEN.QuestionnaireSetId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionnaireSetId = '{0}',", strQuestionnaireSetId); //问卷集ID
 }
 else
 {
 sbSQL.Append(" QuestionnaireSetId = null,"); //问卷集ID
 }
 }
 
 if (objQuestionnaireBatchEN.IsUpdated(conQuestionnaireBatch.IsDefault))
 {
 sbSQL.AppendFormat(" IsDefault = '{0}',", objQuestionnaireBatchEN.IsDefault == true?"1":"0"); //是否默认
 }
 
 if (objQuestionnaireBatchEN.IsUpdated(conQuestionnaireBatch.IsDefaultUser))
 {
 sbSQL.AppendFormat(" IsDefaultUser = '{0}',", objQuestionnaireBatchEN.IsDefaultUser == true?"1":"0"); //是否默认用户
 }
 
 if (objQuestionnaireBatchEN.IsUpdated(conQuestionnaireBatch.CreateDate))
 {
 if (objQuestionnaireBatchEN.CreateDate !=  null)
 {
 var strCreateDate = objQuestionnaireBatchEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateDate = '{0}',", strCreateDate); //建立日期
 }
 else
 {
 sbSQL.Append(" CreateDate = null,"); //建立日期
 }
 }
 
 if (objQuestionnaireBatchEN.IsUpdated(conQuestionnaireBatch.CreateUser))
 {
 if (objQuestionnaireBatchEN.CreateUser !=  null)
 {
 var strCreateUser = objQuestionnaireBatchEN.CreateUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateUser = '{0}',", strCreateUser); //建立用户
 }
 else
 {
 sbSQL.Append(" CreateUser = null,"); //建立用户
 }
 }
 
 if (objQuestionnaireBatchEN.IsUpdated(conQuestionnaireBatch.PageName))
 {
 if (objQuestionnaireBatchEN.PageName !=  null)
 {
 var strPageName = objQuestionnaireBatchEN.PageName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PageName = '{0}',", strPageName); //页面名称
 }
 else
 {
 sbSQL.Append(" PageName = null,"); //页面名称
 }
 }
 
 if (objQuestionnaireBatchEN.IsUpdated(conQuestionnaireBatch.IsRandomSelSet))
 {
 sbSQL.AppendFormat(" IsRandomSelSet = '{0}',", objQuestionnaireBatchEN.IsRandomSelSet == true?"1":"0"); //是否随机选问卷集
 }
 
 if (objQuestionnaireBatchEN.IsUpdated(conQuestionnaireBatch.UpdDate))
 {
 if (objQuestionnaireBatchEN.UpdDate !=  null)
 {
 var strUpdDate = objQuestionnaireBatchEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objQuestionnaireBatchEN.IsUpdated(conQuestionnaireBatch.UpdUser))
 {
 if (objQuestionnaireBatchEN.UpdUser !=  null)
 {
 var strUpdUser = objQuestionnaireBatchEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objQuestionnaireBatchEN.IsUpdated(conQuestionnaireBatch.Memo))
 {
 if (objQuestionnaireBatchEN.Memo !=  null)
 {
 var strMemo = objQuestionnaireBatchEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objQuestionnaireBatchEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsQuestionnaireBatchEN objQuestionnaireBatchEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objQuestionnaireBatchEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQuestionnaireBatchEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQuestionnaireBatchEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireBatchDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QuestionnaireBatch Set ");
 
 if (objQuestionnaireBatchEN.IsUpdated(conQuestionnaireBatch.BatchName))
 {
 if (objQuestionnaireBatchEN.BatchName !=  null)
 {
 var strBatchName = objQuestionnaireBatchEN.BatchName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" BatchName = '{0}',", strBatchName); //批次名称
 }
 else
 {
 sbSQL.Append(" BatchName = null,"); //批次名称
 }
 }
 
 if (objQuestionnaireBatchEN.IsUpdated(conQuestionnaireBatch.RoleId))
 {
 if (objQuestionnaireBatchEN.RoleId !=  null)
 {
 var strRoleId = objQuestionnaireBatchEN.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RoleId = '{0}',", strRoleId); //角色Id
 }
 else
 {
 sbSQL.Append(" RoleId = null,"); //角色Id
 }
 }
 
 if (objQuestionnaireBatchEN.IsUpdated(conQuestionnaireBatch.QuestionnaireSetId))
 {
 if (objQuestionnaireBatchEN.QuestionnaireSetId !=  null)
 {
 var strQuestionnaireSetId = objQuestionnaireBatchEN.QuestionnaireSetId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionnaireSetId = '{0}',", strQuestionnaireSetId); //问卷集ID
 }
 else
 {
 sbSQL.Append(" QuestionnaireSetId = null,"); //问卷集ID
 }
 }
 
 if (objQuestionnaireBatchEN.IsUpdated(conQuestionnaireBatch.IsDefault))
 {
 sbSQL.AppendFormat(" IsDefault = '{0}',", objQuestionnaireBatchEN.IsDefault == true?"1":"0"); //是否默认
 }
 
 if (objQuestionnaireBatchEN.IsUpdated(conQuestionnaireBatch.IsDefaultUser))
 {
 sbSQL.AppendFormat(" IsDefaultUser = '{0}',", objQuestionnaireBatchEN.IsDefaultUser == true?"1":"0"); //是否默认用户
 }
 
 if (objQuestionnaireBatchEN.IsUpdated(conQuestionnaireBatch.CreateDate))
 {
 if (objQuestionnaireBatchEN.CreateDate !=  null)
 {
 var strCreateDate = objQuestionnaireBatchEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateDate = '{0}',", strCreateDate); //建立日期
 }
 else
 {
 sbSQL.Append(" CreateDate = null,"); //建立日期
 }
 }
 
 if (objQuestionnaireBatchEN.IsUpdated(conQuestionnaireBatch.CreateUser))
 {
 if (objQuestionnaireBatchEN.CreateUser !=  null)
 {
 var strCreateUser = objQuestionnaireBatchEN.CreateUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateUser = '{0}',", strCreateUser); //建立用户
 }
 else
 {
 sbSQL.Append(" CreateUser = null,"); //建立用户
 }
 }
 
 if (objQuestionnaireBatchEN.IsUpdated(conQuestionnaireBatch.PageName))
 {
 if (objQuestionnaireBatchEN.PageName !=  null)
 {
 var strPageName = objQuestionnaireBatchEN.PageName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PageName = '{0}',", strPageName); //页面名称
 }
 else
 {
 sbSQL.Append(" PageName = null,"); //页面名称
 }
 }
 
 if (objQuestionnaireBatchEN.IsUpdated(conQuestionnaireBatch.IsRandomSelSet))
 {
 sbSQL.AppendFormat(" IsRandomSelSet = '{0}',", objQuestionnaireBatchEN.IsRandomSelSet == true?"1":"0"); //是否随机选问卷集
 }
 
 if (objQuestionnaireBatchEN.IsUpdated(conQuestionnaireBatch.UpdDate))
 {
 if (objQuestionnaireBatchEN.UpdDate !=  null)
 {
 var strUpdDate = objQuestionnaireBatchEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objQuestionnaireBatchEN.IsUpdated(conQuestionnaireBatch.UpdUser))
 {
 if (objQuestionnaireBatchEN.UpdUser !=  null)
 {
 var strUpdUser = objQuestionnaireBatchEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objQuestionnaireBatchEN.IsUpdated(conQuestionnaireBatch.Memo))
 {
 if (objQuestionnaireBatchEN.Memo !=  null)
 {
 var strMemo = objQuestionnaireBatchEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objQuestionnaireBatchEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsQuestionnaireBatchEN objQuestionnaireBatchEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objQuestionnaireBatchEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQuestionnaireBatchEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQuestionnaireBatchEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireBatchDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QuestionnaireBatch Set ");
 
 if (objQuestionnaireBatchEN.IsUpdated(conQuestionnaireBatch.BatchName))
 {
 if (objQuestionnaireBatchEN.BatchName !=  null)
 {
 var strBatchName = objQuestionnaireBatchEN.BatchName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strBatchName, conQuestionnaireBatch.BatchName); //批次名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireBatch.BatchName); //批次名称
 }
 }
 
 if (objQuestionnaireBatchEN.IsUpdated(conQuestionnaireBatch.RoleId))
 {
 if (objQuestionnaireBatchEN.RoleId !=  null)
 {
 var strRoleId = objQuestionnaireBatchEN.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRoleId, conQuestionnaireBatch.RoleId); //角色Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireBatch.RoleId); //角色Id
 }
 }
 
 if (objQuestionnaireBatchEN.IsUpdated(conQuestionnaireBatch.QuestionnaireSetId))
 {
 if (objQuestionnaireBatchEN.QuestionnaireSetId !=  null)
 {
 var strQuestionnaireSetId = objQuestionnaireBatchEN.QuestionnaireSetId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionnaireSetId, conQuestionnaireBatch.QuestionnaireSetId); //问卷集ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireBatch.QuestionnaireSetId); //问卷集ID
 }
 }
 
 if (objQuestionnaireBatchEN.IsUpdated(conQuestionnaireBatch.IsDefault))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQuestionnaireBatchEN.IsDefault == true?"1":"0", conQuestionnaireBatch.IsDefault); //是否默认
 }
 
 if (objQuestionnaireBatchEN.IsUpdated(conQuestionnaireBatch.IsDefaultUser))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQuestionnaireBatchEN.IsDefaultUser == true?"1":"0", conQuestionnaireBatch.IsDefaultUser); //是否默认用户
 }
 
 if (objQuestionnaireBatchEN.IsUpdated(conQuestionnaireBatch.CreateDate))
 {
 if (objQuestionnaireBatchEN.CreateDate !=  null)
 {
 var strCreateDate = objQuestionnaireBatchEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateDate, conQuestionnaireBatch.CreateDate); //建立日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireBatch.CreateDate); //建立日期
 }
 }
 
 if (objQuestionnaireBatchEN.IsUpdated(conQuestionnaireBatch.CreateUser))
 {
 if (objQuestionnaireBatchEN.CreateUser !=  null)
 {
 var strCreateUser = objQuestionnaireBatchEN.CreateUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateUser, conQuestionnaireBatch.CreateUser); //建立用户
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireBatch.CreateUser); //建立用户
 }
 }
 
 if (objQuestionnaireBatchEN.IsUpdated(conQuestionnaireBatch.PageName))
 {
 if (objQuestionnaireBatchEN.PageName !=  null)
 {
 var strPageName = objQuestionnaireBatchEN.PageName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPageName, conQuestionnaireBatch.PageName); //页面名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireBatch.PageName); //页面名称
 }
 }
 
 if (objQuestionnaireBatchEN.IsUpdated(conQuestionnaireBatch.IsRandomSelSet))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQuestionnaireBatchEN.IsRandomSelSet == true?"1":"0", conQuestionnaireBatch.IsRandomSelSet); //是否随机选问卷集
 }
 
 if (objQuestionnaireBatchEN.IsUpdated(conQuestionnaireBatch.UpdDate))
 {
 if (objQuestionnaireBatchEN.UpdDate !=  null)
 {
 var strUpdDate = objQuestionnaireBatchEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conQuestionnaireBatch.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireBatch.UpdDate); //修改日期
 }
 }
 
 if (objQuestionnaireBatchEN.IsUpdated(conQuestionnaireBatch.UpdUser))
 {
 if (objQuestionnaireBatchEN.UpdUser !=  null)
 {
 var strUpdUser = objQuestionnaireBatchEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conQuestionnaireBatch.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireBatch.UpdUser); //修改人
 }
 }
 
 if (objQuestionnaireBatchEN.IsUpdated(conQuestionnaireBatch.Memo))
 {
 if (objQuestionnaireBatchEN.Memo !=  null)
 {
 var strMemo = objQuestionnaireBatchEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conQuestionnaireBatch.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireBatch.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where BatchId = '{0}'", objQuestionnaireBatchEN.BatchId); 
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
 /// <param name = "strBatchId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strBatchId) 
{
CheckPrimaryKey(strBatchId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireBatchDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strBatchId,
};
 objSQL.ExecSP("QuestionnaireBatch_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strBatchId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strBatchId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strBatchId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireBatchDA.GetSpecSQLObj();
//删除QuestionnaireBatch本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QuestionnaireBatch where BatchId = " + "'"+ strBatchId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelQuestionnaireBatch(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireBatchDA.GetSpecSQLObj();
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
//删除QuestionnaireBatch本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QuestionnaireBatch where BatchId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strBatchId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strBatchId) 
{
CheckPrimaryKey(strBatchId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireBatchDA.GetSpecSQLObj();
//删除QuestionnaireBatch本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QuestionnaireBatch where BatchId = " + "'"+ strBatchId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelQuestionnaireBatch(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsQuestionnaireBatchDA: DelQuestionnaireBatch)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireBatchDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from QuestionnaireBatch where " + strCondition ;
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
public bool DelQuestionnaireBatchWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsQuestionnaireBatchDA: DelQuestionnaireBatchWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireBatchDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from QuestionnaireBatch where " + strCondition ;
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
 /// <param name = "objQuestionnaireBatchENS">源对象</param>
 /// <param name = "objQuestionnaireBatchENT">目标对象</param>
public void CopyTo(clsQuestionnaireBatchEN objQuestionnaireBatchENS, clsQuestionnaireBatchEN objQuestionnaireBatchENT)
{
objQuestionnaireBatchENT.BatchId = objQuestionnaireBatchENS.BatchId; //批次ID
objQuestionnaireBatchENT.BatchName = objQuestionnaireBatchENS.BatchName; //批次名称
objQuestionnaireBatchENT.RoleId = objQuestionnaireBatchENS.RoleId; //角色Id
objQuestionnaireBatchENT.QuestionnaireSetId = objQuestionnaireBatchENS.QuestionnaireSetId; //问卷集ID
objQuestionnaireBatchENT.IsDefault = objQuestionnaireBatchENS.IsDefault; //是否默认
objQuestionnaireBatchENT.IsDefaultUser = objQuestionnaireBatchENS.IsDefaultUser; //是否默认用户
objQuestionnaireBatchENT.CreateDate = objQuestionnaireBatchENS.CreateDate; //建立日期
objQuestionnaireBatchENT.CreateUser = objQuestionnaireBatchENS.CreateUser; //建立用户
objQuestionnaireBatchENT.PageName = objQuestionnaireBatchENS.PageName; //页面名称
objQuestionnaireBatchENT.IsRandomSelSet = objQuestionnaireBatchENS.IsRandomSelSet; //是否随机选问卷集
objQuestionnaireBatchENT.UpdDate = objQuestionnaireBatchENS.UpdDate; //修改日期
objQuestionnaireBatchENT.UpdUser = objQuestionnaireBatchENS.UpdUser; //修改人
objQuestionnaireBatchENT.Memo = objQuestionnaireBatchENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsQuestionnaireBatchEN objQuestionnaireBatchEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objQuestionnaireBatchEN.BatchName, conQuestionnaireBatch.BatchName);
clsCheckSql.CheckFieldNotNull(objQuestionnaireBatchEN.IsDefaultUser, conQuestionnaireBatch.IsDefaultUser);
clsCheckSql.CheckFieldNotNull(objQuestionnaireBatchEN.CreateDate, conQuestionnaireBatch.CreateDate);
clsCheckSql.CheckFieldNotNull(objQuestionnaireBatchEN.CreateUser, conQuestionnaireBatch.CreateUser);
clsCheckSql.CheckFieldNotNull(objQuestionnaireBatchEN.UpdDate, conQuestionnaireBatch.UpdDate);
clsCheckSql.CheckFieldNotNull(objQuestionnaireBatchEN.UpdUser, conQuestionnaireBatch.UpdUser);
//检查字段长度
clsCheckSql.CheckFieldLen(objQuestionnaireBatchEN.BatchId, 4, conQuestionnaireBatch.BatchId);
clsCheckSql.CheckFieldLen(objQuestionnaireBatchEN.BatchName, 50, conQuestionnaireBatch.BatchName);
clsCheckSql.CheckFieldLen(objQuestionnaireBatchEN.RoleId, 8, conQuestionnaireBatch.RoleId);
clsCheckSql.CheckFieldLen(objQuestionnaireBatchEN.QuestionnaireSetId, 4, conQuestionnaireBatch.QuestionnaireSetId);
clsCheckSql.CheckFieldLen(objQuestionnaireBatchEN.CreateDate, 20, conQuestionnaireBatch.CreateDate);
clsCheckSql.CheckFieldLen(objQuestionnaireBatchEN.CreateUser, 50, conQuestionnaireBatch.CreateUser);
clsCheckSql.CheckFieldLen(objQuestionnaireBatchEN.PageName, 100, conQuestionnaireBatch.PageName);
clsCheckSql.CheckFieldLen(objQuestionnaireBatchEN.UpdDate, 20, conQuestionnaireBatch.UpdDate);
clsCheckSql.CheckFieldLen(objQuestionnaireBatchEN.UpdUser, 20, conQuestionnaireBatch.UpdUser);
clsCheckSql.CheckFieldLen(objQuestionnaireBatchEN.Memo, 1000, conQuestionnaireBatch.Memo);
//检查字段外键固定长度
 objQuestionnaireBatchEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsQuestionnaireBatchEN objQuestionnaireBatchEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objQuestionnaireBatchEN.BatchName, 50, conQuestionnaireBatch.BatchName);
clsCheckSql.CheckFieldLen(objQuestionnaireBatchEN.RoleId, 8, conQuestionnaireBatch.RoleId);
clsCheckSql.CheckFieldLen(objQuestionnaireBatchEN.QuestionnaireSetId, 4, conQuestionnaireBatch.QuestionnaireSetId);
clsCheckSql.CheckFieldLen(objQuestionnaireBatchEN.CreateDate, 20, conQuestionnaireBatch.CreateDate);
clsCheckSql.CheckFieldLen(objQuestionnaireBatchEN.CreateUser, 50, conQuestionnaireBatch.CreateUser);
clsCheckSql.CheckFieldLen(objQuestionnaireBatchEN.PageName, 100, conQuestionnaireBatch.PageName);
clsCheckSql.CheckFieldLen(objQuestionnaireBatchEN.UpdDate, 20, conQuestionnaireBatch.UpdDate);
clsCheckSql.CheckFieldLen(objQuestionnaireBatchEN.UpdUser, 20, conQuestionnaireBatch.UpdUser);
clsCheckSql.CheckFieldLen(objQuestionnaireBatchEN.Memo, 1000, conQuestionnaireBatch.Memo);
//检查外键字段长度
 objQuestionnaireBatchEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsQuestionnaireBatchEN objQuestionnaireBatchEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objQuestionnaireBatchEN.BatchId, 4, conQuestionnaireBatch.BatchId);
clsCheckSql.CheckFieldLen(objQuestionnaireBatchEN.BatchName, 50, conQuestionnaireBatch.BatchName);
clsCheckSql.CheckFieldLen(objQuestionnaireBatchEN.RoleId, 8, conQuestionnaireBatch.RoleId);
clsCheckSql.CheckFieldLen(objQuestionnaireBatchEN.QuestionnaireSetId, 4, conQuestionnaireBatch.QuestionnaireSetId);
clsCheckSql.CheckFieldLen(objQuestionnaireBatchEN.CreateDate, 20, conQuestionnaireBatch.CreateDate);
clsCheckSql.CheckFieldLen(objQuestionnaireBatchEN.CreateUser, 50, conQuestionnaireBatch.CreateUser);
clsCheckSql.CheckFieldLen(objQuestionnaireBatchEN.PageName, 100, conQuestionnaireBatch.PageName);
clsCheckSql.CheckFieldLen(objQuestionnaireBatchEN.UpdDate, 20, conQuestionnaireBatch.UpdDate);
clsCheckSql.CheckFieldLen(objQuestionnaireBatchEN.UpdUser, 20, conQuestionnaireBatch.UpdUser);
clsCheckSql.CheckFieldLen(objQuestionnaireBatchEN.Memo, 1000, conQuestionnaireBatch.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireBatchEN.BatchId, conQuestionnaireBatch.BatchId);
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireBatchEN.BatchName, conQuestionnaireBatch.BatchName);
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireBatchEN.RoleId, conQuestionnaireBatch.RoleId);
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireBatchEN.QuestionnaireSetId, conQuestionnaireBatch.QuestionnaireSetId);
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireBatchEN.CreateDate, conQuestionnaireBatch.CreateDate);
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireBatchEN.CreateUser, conQuestionnaireBatch.CreateUser);
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireBatchEN.PageName, conQuestionnaireBatch.PageName);
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireBatchEN.UpdDate, conQuestionnaireBatch.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireBatchEN.UpdUser, conQuestionnaireBatch.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireBatchEN.Memo, conQuestionnaireBatch.Memo);
//检查外键字段长度
 objQuestionnaireBatchEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetBatchId()
{
//获取某学院所有专业信息
string strSQL = "select BatchId, BatchName from QuestionnaireBatch ";
 clsSpecSQLforSql mySql = clsQuestionnaireBatchDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--QuestionnaireBatch(问卷批次),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objQuestionnaireBatchEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsQuestionnaireBatchEN objQuestionnaireBatchEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 if (objQuestionnaireBatchEN.QuestionnaireSetId == null)
{
 sbCondition.AppendFormat(" and QuestionnaireSetId is null");
}
else
{
 sbCondition.AppendFormat(" and QuestionnaireSetId = '{0}'", objQuestionnaireBatchEN.QuestionnaireSetId);
}
 sbCondition.AppendFormat(" and BatchName = '{0}'", objQuestionnaireBatchEN.BatchName);
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
 objSQL = clsQuestionnaireBatchDA.GetSpecSQLObj();
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
 objSQL = clsQuestionnaireBatchDA.GetSpecSQLObj();
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
 objSQL = clsQuestionnaireBatchDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsQuestionnaireBatchEN._CurrTabName);
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
 objSQL = clsQuestionnaireBatchDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsQuestionnaireBatchEN._CurrTabName, strCondition);
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
 objSQL = clsQuestionnaireBatchDA.GetSpecSQLObj();
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
 objSQL = clsQuestionnaireBatchDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}