
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_TopicObjectiveDA
 表名:vzx_TopicObjective(01120855)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:14:24
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
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
 /// vzx_TopicObjective(vzx_TopicObjective)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvzx_TopicObjectiveDA : clsCommBase4DA
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
 return clsvzx_TopicObjectiveEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvzx_TopicObjectiveEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvzx_TopicObjectiveEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvzx_TopicObjectiveEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvzx_TopicObjectiveEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strzxTopicObjectiveId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strzxTopicObjectiveId)
{
strzxTopicObjectiveId = strzxTopicObjectiveId.Replace("'", "''");
if (strzxTopicObjectiveId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vzx_TopicObjective中,检查关键字,长度不正确!(clsvzx_TopicObjectiveDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strzxTopicObjectiveId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vzx_TopicObjective中,关键字不能为空 或 null!(clsvzx_TopicObjectiveDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strzxTopicObjectiveId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvzx_TopicObjectiveDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvzx_TopicObjectiveDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TopicObjectiveDA.GetSpecSQLObj();
strSQL = "Select * from vzx_TopicObjective where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vzx_TopicObjective(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvzx_TopicObjectiveDA: GetDataTable_vzx_TopicObjective)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TopicObjectiveDA.GetSpecSQLObj();
strSQL = "Select * from vzx_TopicObjective where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvzx_TopicObjectiveDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TopicObjectiveDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvzx_TopicObjectiveDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TopicObjectiveDA.GetSpecSQLObj();
strSQL = "Select * from vzx_TopicObjective where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvzx_TopicObjectiveDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TopicObjectiveDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvzx_TopicObjectiveDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TopicObjectiveDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vzx_TopicObjective where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vzx_TopicObjective where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvzx_TopicObjectiveDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TopicObjectiveDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vzx_TopicObjective where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvzx_TopicObjectiveDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TopicObjectiveDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vzx_TopicObjective.* from vzx_TopicObjective Left Join {1} on {2} where {3} and vzx_TopicObjective.zxTopicObjectiveId not in (Select top {5} vzx_TopicObjective.zxTopicObjectiveId from vzx_TopicObjective Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vzx_TopicObjective where {1} and zxTopicObjectiveId not in (Select top {2} zxTopicObjectiveId from vzx_TopicObjective where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vzx_TopicObjective where {1} and zxTopicObjectiveId not in (Select top {3} zxTopicObjectiveId from vzx_TopicObjective where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvzx_TopicObjectiveDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TopicObjectiveDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vzx_TopicObjective.* from vzx_TopicObjective Left Join {1} on {2} where {3} and vzx_TopicObjective.zxTopicObjectiveId not in (Select top {5} vzx_TopicObjective.zxTopicObjectiveId from vzx_TopicObjective Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vzx_TopicObjective where {1} and zxTopicObjectiveId not in (Select top {2} zxTopicObjectiveId from vzx_TopicObjective where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vzx_TopicObjective where {1} and zxTopicObjectiveId not in (Select top {3} zxTopicObjectiveId from vzx_TopicObjective where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvzx_TopicObjectiveEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvzx_TopicObjectiveDA:GetObjLst)", objException.Message));
}
List<clsvzx_TopicObjectiveEN> arrObjLst = new List<clsvzx_TopicObjectiveEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TopicObjectiveDA.GetSpecSQLObj();
strSQL = "Select * from vzx_TopicObjective where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_TopicObjectiveEN objvzx_TopicObjectiveEN = new clsvzx_TopicObjectiveEN();
try
{
objvzx_TopicObjectiveEN.zxTopicObjectiveId = objRow[convzx_TopicObjective.zxTopicObjectiveId].ToString().Trim(); //客观Id
objvzx_TopicObjectiveEN.ObjectiveName = objRow[convzx_TopicObjective.ObjectiveName] == DBNull.Value ? null : objRow[convzx_TopicObjective.ObjectiveName].ToString().Trim(); //客观名称
objvzx_TopicObjectiveEN.ObjectiveContent = objRow[convzx_TopicObjective.ObjectiveContent] == DBNull.Value ? null : objRow[convzx_TopicObjective.ObjectiveContent].ToString().Trim(); //客观内容
objvzx_TopicObjectiveEN.ObjectiveType = objRow[convzx_TopicObjective.ObjectiveType] == DBNull.Value ? null : objRow[convzx_TopicObjective.ObjectiveType].ToString().Trim(); //客观类型
objvzx_TopicObjectiveEN.Conclusion = objRow[convzx_TopicObjective.Conclusion] == DBNull.Value ? null : objRow[convzx_TopicObjective.Conclusion].ToString().Trim(); //结论
objvzx_TopicObjectiveEN.TextId = objRow[convzx_TopicObjective.TextId] == DBNull.Value ? null : objRow[convzx_TopicObjective.TextId].ToString().Trim(); //课件Id
objvzx_TopicObjectiveEN.IsSubmit = TransNullToBool(objRow[convzx_TopicObjective.IsSubmit].ToString().Trim()); //是否提交
objvzx_TopicObjectiveEN.VoteCount = objRow[convzx_TopicObjective.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TopicObjective.VoteCount].ToString().Trim()); //点赞计数
objvzx_TopicObjectiveEN.AppraiseCount = objRow[convzx_TopicObjective.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TopicObjective.AppraiseCount].ToString().Trim()); //评论数
objvzx_TopicObjectiveEN.Score = objRow[convzx_TopicObjective.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_TopicObjective.Score].ToString().Trim()); //评分
objvzx_TopicObjectiveEN.StuScore = objRow[convzx_TopicObjective.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_TopicObjective.StuScore].ToString().Trim()); //学生平均分
objvzx_TopicObjectiveEN.TeaScore = objRow[convzx_TopicObjective.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_TopicObjective.TeaScore].ToString().Trim()); //教师评分
objvzx_TopicObjectiveEN.IdCurrEduCls = objRow[convzx_TopicObjective.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_TopicObjective.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TopicObjectiveEN.PdfContent = objRow[convzx_TopicObjective.PdfContent] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfContent].ToString().Trim(); //Pdf内容
objvzx_TopicObjectiveEN.PdfPageNum = objRow[convzx_TopicObjective.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TopicObjective.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_TopicObjectiveEN.CitationCount = objRow[convzx_TopicObjective.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TopicObjective.CitationCount].ToString().Trim()); //引用统计
objvzx_TopicObjectiveEN.VersionCount = objRow[convzx_TopicObjective.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TopicObjective.VersionCount].ToString().Trim()); //版本统计
objvzx_TopicObjectiveEN.zxShareId = objRow[convzx_TopicObjective.zxShareId] == DBNull.Value ? null : objRow[convzx_TopicObjective.zxShareId].ToString().Trim(); //分享Id
objvzx_TopicObjectiveEN.CreateDate = objRow[convzx_TopicObjective.CreateDate] == DBNull.Value ? null : objRow[convzx_TopicObjective.CreateDate].ToString().Trim(); //建立日期
objvzx_TopicObjectiveEN.UpdDate = objRow[convzx_TopicObjective.UpdDate] == DBNull.Value ? null : objRow[convzx_TopicObjective.UpdDate].ToString().Trim(); //修改日期
objvzx_TopicObjectiveEN.UpdUser = objRow[convzx_TopicObjective.UpdUser] == DBNull.Value ? null : objRow[convzx_TopicObjective.UpdUser].ToString().Trim(); //修改人
objvzx_TopicObjectiveEN.Memo = objRow[convzx_TopicObjective.Memo] == DBNull.Value ? null : objRow[convzx_TopicObjective.Memo].ToString().Trim(); //备注
objvzx_TopicObjectiveEN.PdfDivLet = objRow[convzx_TopicObjective.PdfDivLet] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_TopicObjectiveEN.PdfDivTop = objRow[convzx_TopicObjective.PdfDivTop] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_TopicObjectiveEN.PdfPageNumIn = objRow[convzx_TopicObjective.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_TopicObjectiveEN.PdfPageTop = objRow[convzx_TopicObjective.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TopicObjective.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_TopicObjectiveEN.PdfZoom = objRow[convzx_TopicObjective.PdfZoom] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_TopicObjectiveEN.GroupTextId = objRow[convzx_TopicObjective.GroupTextId] == DBNull.Value ? null : objRow[convzx_TopicObjective.GroupTextId].ToString().Trim(); //小组Id
objvzx_TopicObjectiveEN.TextTitle = objRow[convzx_TopicObjective.TextTitle] == DBNull.Value ? null : objRow[convzx_TopicObjective.TextTitle].ToString().Trim(); //TextTitle
objvzx_TopicObjectiveEN.TextContent = objRow[convzx_TopicObjective.TextContent] == DBNull.Value ? null : objRow[convzx_TopicObjective.TextContent].ToString().Trim(); //TextContent
objvzx_TopicObjectiveEN.Author = objRow[convzx_TopicObjective.Author] == DBNull.Value ? null : objRow[convzx_TopicObjective.Author].ToString().Trim(); //作者
objvzx_TopicObjectiveEN.Keyword = objRow[convzx_TopicObjective.Keyword] == DBNull.Value ? null : objRow[convzx_TopicObjective.Keyword].ToString().Trim(); //关键字
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvzx_TopicObjectiveDA: GetObjLst)", objException.Message));
}
objvzx_TopicObjectiveEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvzx_TopicObjectiveEN);
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
public List<clsvzx_TopicObjectiveEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvzx_TopicObjectiveDA:GetObjLstByTabName)", objException.Message));
}
List<clsvzx_TopicObjectiveEN> arrObjLst = new List<clsvzx_TopicObjectiveEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TopicObjectiveDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_TopicObjectiveEN objvzx_TopicObjectiveEN = new clsvzx_TopicObjectiveEN();
try
{
objvzx_TopicObjectiveEN.zxTopicObjectiveId = objRow[convzx_TopicObjective.zxTopicObjectiveId].ToString().Trim(); //客观Id
objvzx_TopicObjectiveEN.ObjectiveName = objRow[convzx_TopicObjective.ObjectiveName] == DBNull.Value ? null : objRow[convzx_TopicObjective.ObjectiveName].ToString().Trim(); //客观名称
objvzx_TopicObjectiveEN.ObjectiveContent = objRow[convzx_TopicObjective.ObjectiveContent] == DBNull.Value ? null : objRow[convzx_TopicObjective.ObjectiveContent].ToString().Trim(); //客观内容
objvzx_TopicObjectiveEN.ObjectiveType = objRow[convzx_TopicObjective.ObjectiveType] == DBNull.Value ? null : objRow[convzx_TopicObjective.ObjectiveType].ToString().Trim(); //客观类型
objvzx_TopicObjectiveEN.Conclusion = objRow[convzx_TopicObjective.Conclusion] == DBNull.Value ? null : objRow[convzx_TopicObjective.Conclusion].ToString().Trim(); //结论
objvzx_TopicObjectiveEN.TextId = objRow[convzx_TopicObjective.TextId] == DBNull.Value ? null : objRow[convzx_TopicObjective.TextId].ToString().Trim(); //课件Id
objvzx_TopicObjectiveEN.IsSubmit = TransNullToBool(objRow[convzx_TopicObjective.IsSubmit].ToString().Trim()); //是否提交
objvzx_TopicObjectiveEN.VoteCount = objRow[convzx_TopicObjective.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TopicObjective.VoteCount].ToString().Trim()); //点赞计数
objvzx_TopicObjectiveEN.AppraiseCount = objRow[convzx_TopicObjective.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TopicObjective.AppraiseCount].ToString().Trim()); //评论数
objvzx_TopicObjectiveEN.Score = objRow[convzx_TopicObjective.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_TopicObjective.Score].ToString().Trim()); //评分
objvzx_TopicObjectiveEN.StuScore = objRow[convzx_TopicObjective.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_TopicObjective.StuScore].ToString().Trim()); //学生平均分
objvzx_TopicObjectiveEN.TeaScore = objRow[convzx_TopicObjective.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_TopicObjective.TeaScore].ToString().Trim()); //教师评分
objvzx_TopicObjectiveEN.IdCurrEduCls = objRow[convzx_TopicObjective.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_TopicObjective.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TopicObjectiveEN.PdfContent = objRow[convzx_TopicObjective.PdfContent] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfContent].ToString().Trim(); //Pdf内容
objvzx_TopicObjectiveEN.PdfPageNum = objRow[convzx_TopicObjective.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TopicObjective.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_TopicObjectiveEN.CitationCount = objRow[convzx_TopicObjective.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TopicObjective.CitationCount].ToString().Trim()); //引用统计
objvzx_TopicObjectiveEN.VersionCount = objRow[convzx_TopicObjective.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TopicObjective.VersionCount].ToString().Trim()); //版本统计
objvzx_TopicObjectiveEN.zxShareId = objRow[convzx_TopicObjective.zxShareId] == DBNull.Value ? null : objRow[convzx_TopicObjective.zxShareId].ToString().Trim(); //分享Id
objvzx_TopicObjectiveEN.CreateDate = objRow[convzx_TopicObjective.CreateDate] == DBNull.Value ? null : objRow[convzx_TopicObjective.CreateDate].ToString().Trim(); //建立日期
objvzx_TopicObjectiveEN.UpdDate = objRow[convzx_TopicObjective.UpdDate] == DBNull.Value ? null : objRow[convzx_TopicObjective.UpdDate].ToString().Trim(); //修改日期
objvzx_TopicObjectiveEN.UpdUser = objRow[convzx_TopicObjective.UpdUser] == DBNull.Value ? null : objRow[convzx_TopicObjective.UpdUser].ToString().Trim(); //修改人
objvzx_TopicObjectiveEN.Memo = objRow[convzx_TopicObjective.Memo] == DBNull.Value ? null : objRow[convzx_TopicObjective.Memo].ToString().Trim(); //备注
objvzx_TopicObjectiveEN.PdfDivLet = objRow[convzx_TopicObjective.PdfDivLet] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_TopicObjectiveEN.PdfDivTop = objRow[convzx_TopicObjective.PdfDivTop] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_TopicObjectiveEN.PdfPageNumIn = objRow[convzx_TopicObjective.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_TopicObjectiveEN.PdfPageTop = objRow[convzx_TopicObjective.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TopicObjective.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_TopicObjectiveEN.PdfZoom = objRow[convzx_TopicObjective.PdfZoom] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_TopicObjectiveEN.GroupTextId = objRow[convzx_TopicObjective.GroupTextId] == DBNull.Value ? null : objRow[convzx_TopicObjective.GroupTextId].ToString().Trim(); //小组Id
objvzx_TopicObjectiveEN.TextTitle = objRow[convzx_TopicObjective.TextTitle] == DBNull.Value ? null : objRow[convzx_TopicObjective.TextTitle].ToString().Trim(); //TextTitle
objvzx_TopicObjectiveEN.TextContent = objRow[convzx_TopicObjective.TextContent] == DBNull.Value ? null : objRow[convzx_TopicObjective.TextContent].ToString().Trim(); //TextContent
objvzx_TopicObjectiveEN.Author = objRow[convzx_TopicObjective.Author] == DBNull.Value ? null : objRow[convzx_TopicObjective.Author].ToString().Trim(); //作者
objvzx_TopicObjectiveEN.Keyword = objRow[convzx_TopicObjective.Keyword] == DBNull.Value ? null : objRow[convzx_TopicObjective.Keyword].ToString().Trim(); //关键字
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvzx_TopicObjectiveDA: GetObjLst)", objException.Message));
}
objvzx_TopicObjectiveEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvzx_TopicObjectiveEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvzx_TopicObjectiveEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getvzx_TopicObjective(ref clsvzx_TopicObjectiveEN objvzx_TopicObjectiveEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TopicObjectiveDA.GetSpecSQLObj();
strSQL = "Select * from vzx_TopicObjective where zxTopicObjectiveId = " + "'"+ objvzx_TopicObjectiveEN.zxTopicObjectiveId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvzx_TopicObjectiveEN.zxTopicObjectiveId = objDT.Rows[0][convzx_TopicObjective.zxTopicObjectiveId].ToString().Trim(); //客观Id(字段类型:char,字段长度:8,是否可空:False)
 objvzx_TopicObjectiveEN.ObjectiveName = objDT.Rows[0][convzx_TopicObjective.ObjectiveName].ToString().Trim(); //客观名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvzx_TopicObjectiveEN.ObjectiveContent = objDT.Rows[0][convzx_TopicObjective.ObjectiveContent].ToString().Trim(); //客观内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvzx_TopicObjectiveEN.ObjectiveType = objDT.Rows[0][convzx_TopicObjective.ObjectiveType].ToString().Trim(); //客观类型(字段类型:char,字段长度:2,是否可空:True)
 objvzx_TopicObjectiveEN.Conclusion = objDT.Rows[0][convzx_TopicObjective.Conclusion].ToString().Trim(); //结论(字段类型:text,字段长度:2147483647,是否可空:True)
 objvzx_TopicObjectiveEN.TextId = objDT.Rows[0][convzx_TopicObjective.TextId].ToString().Trim(); //课件Id(字段类型:char,字段长度:8,是否可空:False)
 objvzx_TopicObjectiveEN.IsSubmit = TransNullToBool(objDT.Rows[0][convzx_TopicObjective.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvzx_TopicObjectiveEN.VoteCount = TransNullToInt(objDT.Rows[0][convzx_TopicObjective.VoteCount].ToString().Trim()); //点赞计数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_TopicObjectiveEN.AppraiseCount = TransNullToInt(objDT.Rows[0][convzx_TopicObjective.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_TopicObjectiveEN.Score = TransNullToFloat(objDT.Rows[0][convzx_TopicObjective.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvzx_TopicObjectiveEN.StuScore = TransNullToFloat(objDT.Rows[0][convzx_TopicObjective.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objvzx_TopicObjectiveEN.TeaScore = TransNullToFloat(objDT.Rows[0][convzx_TopicObjective.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objvzx_TopicObjectiveEN.IdCurrEduCls = objDT.Rows[0][convzx_TopicObjective.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvzx_TopicObjectiveEN.PdfContent = objDT.Rows[0][convzx_TopicObjective.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvzx_TopicObjectiveEN.PdfPageNum = TransNullToInt(objDT.Rows[0][convzx_TopicObjective.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objvzx_TopicObjectiveEN.CitationCount = TransNullToInt(objDT.Rows[0][convzx_TopicObjective.CitationCount].ToString().Trim()); //引用统计(字段类型:int,字段长度:4,是否可空:True)
 objvzx_TopicObjectiveEN.VersionCount = TransNullToInt(objDT.Rows[0][convzx_TopicObjective.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objvzx_TopicObjectiveEN.zxShareId = objDT.Rows[0][convzx_TopicObjective.zxShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objvzx_TopicObjectiveEN.CreateDate = objDT.Rows[0][convzx_TopicObjective.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_TopicObjectiveEN.UpdDate = objDT.Rows[0][convzx_TopicObjective.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_TopicObjectiveEN.UpdUser = objDT.Rows[0][convzx_TopicObjective.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_TopicObjectiveEN.Memo = objDT.Rows[0][convzx_TopicObjective.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_TopicObjectiveEN.PdfDivLet = objDT.Rows[0][convzx_TopicObjective.PdfDivLet].ToString().Trim(); //PdfDivLet(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_TopicObjectiveEN.PdfDivTop = objDT.Rows[0][convzx_TopicObjective.PdfDivTop].ToString().Trim(); //PdfDivTop(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_TopicObjectiveEN.PdfPageNumIn = objDT.Rows[0][convzx_TopicObjective.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_TopicObjectiveEN.PdfPageTop = TransNullToInt(objDT.Rows[0][convzx_TopicObjective.PdfPageTop].ToString().Trim()); //pdf页面顶部位置(字段类型:int,字段长度:4,是否可空:True)
 objvzx_TopicObjectiveEN.PdfZoom = objDT.Rows[0][convzx_TopicObjective.PdfZoom].ToString().Trim(); //PdfZoom(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_TopicObjectiveEN.GroupTextId = objDT.Rows[0][convzx_TopicObjective.GroupTextId].ToString().Trim(); //小组Id(字段类型:char,字段长度:8,是否可空:False)
 objvzx_TopicObjectiveEN.TextTitle = objDT.Rows[0][convzx_TopicObjective.TextTitle].ToString().Trim(); //TextTitle(字段类型:varchar,字段长度:500,是否可空:False)
 objvzx_TopicObjectiveEN.TextContent = objDT.Rows[0][convzx_TopicObjective.TextContent].ToString().Trim(); //TextContent(字段类型:text,字段长度:2147483647,是否可空:True)
 objvzx_TopicObjectiveEN.Author = objDT.Rows[0][convzx_TopicObjective.Author].ToString().Trim(); //作者(字段类型:varchar,字段长度:200,是否可空:True)
 objvzx_TopicObjectiveEN.Keyword = objDT.Rows[0][convzx_TopicObjective.Keyword].ToString().Trim(); //关键字(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvzx_TopicObjectiveDA: Getvzx_TopicObjective)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strzxTopicObjectiveId">表关键字</param>
 /// <returns>表对象</returns>
public clsvzx_TopicObjectiveEN GetObjByzxTopicObjectiveId(string strzxTopicObjectiveId)
{
CheckPrimaryKey(strzxTopicObjectiveId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TopicObjectiveDA.GetSpecSQLObj();
strSQL = "Select * from vzx_TopicObjective where zxTopicObjectiveId = " + "'"+ strzxTopicObjectiveId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvzx_TopicObjectiveEN objvzx_TopicObjectiveEN = new clsvzx_TopicObjectiveEN();
try
{
 objvzx_TopicObjectiveEN.zxTopicObjectiveId = objRow[convzx_TopicObjective.zxTopicObjectiveId].ToString().Trim(); //客观Id(字段类型:char,字段长度:8,是否可空:False)
 objvzx_TopicObjectiveEN.ObjectiveName = objRow[convzx_TopicObjective.ObjectiveName] == DBNull.Value ? null : objRow[convzx_TopicObjective.ObjectiveName].ToString().Trim(); //客观名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvzx_TopicObjectiveEN.ObjectiveContent = objRow[convzx_TopicObjective.ObjectiveContent] == DBNull.Value ? null : objRow[convzx_TopicObjective.ObjectiveContent].ToString().Trim(); //客观内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvzx_TopicObjectiveEN.ObjectiveType = objRow[convzx_TopicObjective.ObjectiveType] == DBNull.Value ? null : objRow[convzx_TopicObjective.ObjectiveType].ToString().Trim(); //客观类型(字段类型:char,字段长度:2,是否可空:True)
 objvzx_TopicObjectiveEN.Conclusion = objRow[convzx_TopicObjective.Conclusion] == DBNull.Value ? null : objRow[convzx_TopicObjective.Conclusion].ToString().Trim(); //结论(字段类型:text,字段长度:2147483647,是否可空:True)
 objvzx_TopicObjectiveEN.TextId = objRow[convzx_TopicObjective.TextId] == DBNull.Value ? null : objRow[convzx_TopicObjective.TextId].ToString().Trim(); //课件Id(字段类型:char,字段长度:8,是否可空:False)
 objvzx_TopicObjectiveEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_TopicObjective.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvzx_TopicObjectiveEN.VoteCount = objRow[convzx_TopicObjective.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TopicObjective.VoteCount].ToString().Trim()); //点赞计数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_TopicObjectiveEN.AppraiseCount = objRow[convzx_TopicObjective.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TopicObjective.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_TopicObjectiveEN.Score = objRow[convzx_TopicObjective.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TopicObjective.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvzx_TopicObjectiveEN.StuScore = objRow[convzx_TopicObjective.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TopicObjective.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objvzx_TopicObjectiveEN.TeaScore = objRow[convzx_TopicObjective.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TopicObjective.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objvzx_TopicObjectiveEN.IdCurrEduCls = objRow[convzx_TopicObjective.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_TopicObjective.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvzx_TopicObjectiveEN.PdfContent = objRow[convzx_TopicObjective.PdfContent] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvzx_TopicObjectiveEN.PdfPageNum = objRow[convzx_TopicObjective.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TopicObjective.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objvzx_TopicObjectiveEN.CitationCount = objRow[convzx_TopicObjective.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TopicObjective.CitationCount].ToString().Trim()); //引用统计(字段类型:int,字段长度:4,是否可空:True)
 objvzx_TopicObjectiveEN.VersionCount = objRow[convzx_TopicObjective.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TopicObjective.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objvzx_TopicObjectiveEN.zxShareId = objRow[convzx_TopicObjective.zxShareId] == DBNull.Value ? null : objRow[convzx_TopicObjective.zxShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objvzx_TopicObjectiveEN.CreateDate = objRow[convzx_TopicObjective.CreateDate] == DBNull.Value ? null : objRow[convzx_TopicObjective.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_TopicObjectiveEN.UpdDate = objRow[convzx_TopicObjective.UpdDate] == DBNull.Value ? null : objRow[convzx_TopicObjective.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_TopicObjectiveEN.UpdUser = objRow[convzx_TopicObjective.UpdUser] == DBNull.Value ? null : objRow[convzx_TopicObjective.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_TopicObjectiveEN.Memo = objRow[convzx_TopicObjective.Memo] == DBNull.Value ? null : objRow[convzx_TopicObjective.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_TopicObjectiveEN.PdfDivLet = objRow[convzx_TopicObjective.PdfDivLet] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfDivLet].ToString().Trim(); //PdfDivLet(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_TopicObjectiveEN.PdfDivTop = objRow[convzx_TopicObjective.PdfDivTop] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfDivTop].ToString().Trim(); //PdfDivTop(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_TopicObjectiveEN.PdfPageNumIn = objRow[convzx_TopicObjective.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_TopicObjectiveEN.PdfPageTop = objRow[convzx_TopicObjective.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TopicObjective.PdfPageTop].ToString().Trim()); //pdf页面顶部位置(字段类型:int,字段长度:4,是否可空:True)
 objvzx_TopicObjectiveEN.PdfZoom = objRow[convzx_TopicObjective.PdfZoom] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfZoom].ToString().Trim(); //PdfZoom(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_TopicObjectiveEN.GroupTextId = objRow[convzx_TopicObjective.GroupTextId] == DBNull.Value ? null : objRow[convzx_TopicObjective.GroupTextId].ToString().Trim(); //小组Id(字段类型:char,字段长度:8,是否可空:False)
 objvzx_TopicObjectiveEN.TextTitle = objRow[convzx_TopicObjective.TextTitle] == DBNull.Value ? null : objRow[convzx_TopicObjective.TextTitle].ToString().Trim(); //TextTitle(字段类型:varchar,字段长度:500,是否可空:False)
 objvzx_TopicObjectiveEN.TextContent = objRow[convzx_TopicObjective.TextContent] == DBNull.Value ? null : objRow[convzx_TopicObjective.TextContent].ToString().Trim(); //TextContent(字段类型:text,字段长度:2147483647,是否可空:True)
 objvzx_TopicObjectiveEN.Author = objRow[convzx_TopicObjective.Author] == DBNull.Value ? null : objRow[convzx_TopicObjective.Author].ToString().Trim(); //作者(字段类型:varchar,字段长度:200,是否可空:True)
 objvzx_TopicObjectiveEN.Keyword = objRow[convzx_TopicObjective.Keyword] == DBNull.Value ? null : objRow[convzx_TopicObjective.Keyword].ToString().Trim(); //关键字(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvzx_TopicObjectiveDA: GetObjByzxTopicObjectiveId)", objException.Message));
}
return objvzx_TopicObjectiveEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvzx_TopicObjectiveEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvzx_TopicObjectiveDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TopicObjectiveDA.GetSpecSQLObj();
strSQL = "Select * from vzx_TopicObjective where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvzx_TopicObjectiveEN objvzx_TopicObjectiveEN = new clsvzx_TopicObjectiveEN()
{
zxTopicObjectiveId = objRow[convzx_TopicObjective.zxTopicObjectiveId].ToString().Trim(), //客观Id
ObjectiveName = objRow[convzx_TopicObjective.ObjectiveName] == DBNull.Value ? null : objRow[convzx_TopicObjective.ObjectiveName].ToString().Trim(), //客观名称
ObjectiveContent = objRow[convzx_TopicObjective.ObjectiveContent] == DBNull.Value ? null : objRow[convzx_TopicObjective.ObjectiveContent].ToString().Trim(), //客观内容
ObjectiveType = objRow[convzx_TopicObjective.ObjectiveType] == DBNull.Value ? null : objRow[convzx_TopicObjective.ObjectiveType].ToString().Trim(), //客观类型
Conclusion = objRow[convzx_TopicObjective.Conclusion] == DBNull.Value ? null : objRow[convzx_TopicObjective.Conclusion].ToString().Trim(), //结论
TextId = objRow[convzx_TopicObjective.TextId] == DBNull.Value ? null : objRow[convzx_TopicObjective.TextId].ToString().Trim(), //课件Id
IsSubmit = TransNullToBool(objRow[convzx_TopicObjective.IsSubmit].ToString().Trim()), //是否提交
VoteCount = objRow[convzx_TopicObjective.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TopicObjective.VoteCount].ToString().Trim()), //点赞计数
AppraiseCount = objRow[convzx_TopicObjective.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TopicObjective.AppraiseCount].ToString().Trim()), //评论数
Score = objRow[convzx_TopicObjective.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_TopicObjective.Score].ToString().Trim()), //评分
StuScore = objRow[convzx_TopicObjective.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_TopicObjective.StuScore].ToString().Trim()), //学生平均分
TeaScore = objRow[convzx_TopicObjective.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_TopicObjective.TeaScore].ToString().Trim()), //教师评分
IdCurrEduCls = objRow[convzx_TopicObjective.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_TopicObjective.IdCurrEduCls].ToString().Trim(), //教学班流水号
PdfContent = objRow[convzx_TopicObjective.PdfContent] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfContent].ToString().Trim(), //Pdf内容
PdfPageNum = objRow[convzx_TopicObjective.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TopicObjective.PdfPageNum].ToString().Trim()), //Pdf页码
CitationCount = objRow[convzx_TopicObjective.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TopicObjective.CitationCount].ToString().Trim()), //引用统计
VersionCount = objRow[convzx_TopicObjective.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TopicObjective.VersionCount].ToString().Trim()), //版本统计
zxShareId = objRow[convzx_TopicObjective.zxShareId] == DBNull.Value ? null : objRow[convzx_TopicObjective.zxShareId].ToString().Trim(), //分享Id
CreateDate = objRow[convzx_TopicObjective.CreateDate] == DBNull.Value ? null : objRow[convzx_TopicObjective.CreateDate].ToString().Trim(), //建立日期
UpdDate = objRow[convzx_TopicObjective.UpdDate] == DBNull.Value ? null : objRow[convzx_TopicObjective.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convzx_TopicObjective.UpdUser] == DBNull.Value ? null : objRow[convzx_TopicObjective.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convzx_TopicObjective.Memo] == DBNull.Value ? null : objRow[convzx_TopicObjective.Memo].ToString().Trim(), //备注
PdfDivLet = objRow[convzx_TopicObjective.PdfDivLet] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfDivLet].ToString().Trim(), //PdfDivLet
PdfDivTop = objRow[convzx_TopicObjective.PdfDivTop] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfDivTop].ToString().Trim(), //PdfDivTop
PdfPageNumIn = objRow[convzx_TopicObjective.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfPageNumIn].ToString().Trim(), //PdfPageNumIn
PdfPageTop = objRow[convzx_TopicObjective.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TopicObjective.PdfPageTop].ToString().Trim()), //pdf页面顶部位置
PdfZoom = objRow[convzx_TopicObjective.PdfZoom] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfZoom].ToString().Trim(), //PdfZoom
GroupTextId = objRow[convzx_TopicObjective.GroupTextId] == DBNull.Value ? null : objRow[convzx_TopicObjective.GroupTextId].ToString().Trim(), //小组Id
TextTitle = objRow[convzx_TopicObjective.TextTitle] == DBNull.Value ? null : objRow[convzx_TopicObjective.TextTitle].ToString().Trim(), //TextTitle
TextContent = objRow[convzx_TopicObjective.TextContent] == DBNull.Value ? null : objRow[convzx_TopicObjective.TextContent].ToString().Trim(), //TextContent
Author = objRow[convzx_TopicObjective.Author] == DBNull.Value ? null : objRow[convzx_TopicObjective.Author].ToString().Trim(), //作者
Keyword = objRow[convzx_TopicObjective.Keyword] == DBNull.Value ? null : objRow[convzx_TopicObjective.Keyword].ToString().Trim() //关键字
};
objvzx_TopicObjectiveEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvzx_TopicObjectiveEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvzx_TopicObjectiveDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvzx_TopicObjectiveEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvzx_TopicObjectiveEN objvzx_TopicObjectiveEN = new clsvzx_TopicObjectiveEN();
try
{
objvzx_TopicObjectiveEN.zxTopicObjectiveId = objRow[convzx_TopicObjective.zxTopicObjectiveId].ToString().Trim(); //客观Id
objvzx_TopicObjectiveEN.ObjectiveName = objRow[convzx_TopicObjective.ObjectiveName] == DBNull.Value ? null : objRow[convzx_TopicObjective.ObjectiveName].ToString().Trim(); //客观名称
objvzx_TopicObjectiveEN.ObjectiveContent = objRow[convzx_TopicObjective.ObjectiveContent] == DBNull.Value ? null : objRow[convzx_TopicObjective.ObjectiveContent].ToString().Trim(); //客观内容
objvzx_TopicObjectiveEN.ObjectiveType = objRow[convzx_TopicObjective.ObjectiveType] == DBNull.Value ? null : objRow[convzx_TopicObjective.ObjectiveType].ToString().Trim(); //客观类型
objvzx_TopicObjectiveEN.Conclusion = objRow[convzx_TopicObjective.Conclusion] == DBNull.Value ? null : objRow[convzx_TopicObjective.Conclusion].ToString().Trim(); //结论
objvzx_TopicObjectiveEN.TextId = objRow[convzx_TopicObjective.TextId] == DBNull.Value ? null : objRow[convzx_TopicObjective.TextId].ToString().Trim(); //课件Id
objvzx_TopicObjectiveEN.IsSubmit = TransNullToBool(objRow[convzx_TopicObjective.IsSubmit].ToString().Trim()); //是否提交
objvzx_TopicObjectiveEN.VoteCount = objRow[convzx_TopicObjective.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TopicObjective.VoteCount].ToString().Trim()); //点赞计数
objvzx_TopicObjectiveEN.AppraiseCount = objRow[convzx_TopicObjective.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TopicObjective.AppraiseCount].ToString().Trim()); //评论数
objvzx_TopicObjectiveEN.Score = objRow[convzx_TopicObjective.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_TopicObjective.Score].ToString().Trim()); //评分
objvzx_TopicObjectiveEN.StuScore = objRow[convzx_TopicObjective.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_TopicObjective.StuScore].ToString().Trim()); //学生平均分
objvzx_TopicObjectiveEN.TeaScore = objRow[convzx_TopicObjective.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_TopicObjective.TeaScore].ToString().Trim()); //教师评分
objvzx_TopicObjectiveEN.IdCurrEduCls = objRow[convzx_TopicObjective.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_TopicObjective.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TopicObjectiveEN.PdfContent = objRow[convzx_TopicObjective.PdfContent] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfContent].ToString().Trim(); //Pdf内容
objvzx_TopicObjectiveEN.PdfPageNum = objRow[convzx_TopicObjective.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TopicObjective.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_TopicObjectiveEN.CitationCount = objRow[convzx_TopicObjective.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TopicObjective.CitationCount].ToString().Trim()); //引用统计
objvzx_TopicObjectiveEN.VersionCount = objRow[convzx_TopicObjective.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TopicObjective.VersionCount].ToString().Trim()); //版本统计
objvzx_TopicObjectiveEN.zxShareId = objRow[convzx_TopicObjective.zxShareId] == DBNull.Value ? null : objRow[convzx_TopicObjective.zxShareId].ToString().Trim(); //分享Id
objvzx_TopicObjectiveEN.CreateDate = objRow[convzx_TopicObjective.CreateDate] == DBNull.Value ? null : objRow[convzx_TopicObjective.CreateDate].ToString().Trim(); //建立日期
objvzx_TopicObjectiveEN.UpdDate = objRow[convzx_TopicObjective.UpdDate] == DBNull.Value ? null : objRow[convzx_TopicObjective.UpdDate].ToString().Trim(); //修改日期
objvzx_TopicObjectiveEN.UpdUser = objRow[convzx_TopicObjective.UpdUser] == DBNull.Value ? null : objRow[convzx_TopicObjective.UpdUser].ToString().Trim(); //修改人
objvzx_TopicObjectiveEN.Memo = objRow[convzx_TopicObjective.Memo] == DBNull.Value ? null : objRow[convzx_TopicObjective.Memo].ToString().Trim(); //备注
objvzx_TopicObjectiveEN.PdfDivLet = objRow[convzx_TopicObjective.PdfDivLet] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_TopicObjectiveEN.PdfDivTop = objRow[convzx_TopicObjective.PdfDivTop] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_TopicObjectiveEN.PdfPageNumIn = objRow[convzx_TopicObjective.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_TopicObjectiveEN.PdfPageTop = objRow[convzx_TopicObjective.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TopicObjective.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_TopicObjectiveEN.PdfZoom = objRow[convzx_TopicObjective.PdfZoom] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_TopicObjectiveEN.GroupTextId = objRow[convzx_TopicObjective.GroupTextId] == DBNull.Value ? null : objRow[convzx_TopicObjective.GroupTextId].ToString().Trim(); //小组Id
objvzx_TopicObjectiveEN.TextTitle = objRow[convzx_TopicObjective.TextTitle] == DBNull.Value ? null : objRow[convzx_TopicObjective.TextTitle].ToString().Trim(); //TextTitle
objvzx_TopicObjectiveEN.TextContent = objRow[convzx_TopicObjective.TextContent] == DBNull.Value ? null : objRow[convzx_TopicObjective.TextContent].ToString().Trim(); //TextContent
objvzx_TopicObjectiveEN.Author = objRow[convzx_TopicObjective.Author] == DBNull.Value ? null : objRow[convzx_TopicObjective.Author].ToString().Trim(); //作者
objvzx_TopicObjectiveEN.Keyword = objRow[convzx_TopicObjective.Keyword] == DBNull.Value ? null : objRow[convzx_TopicObjective.Keyword].ToString().Trim(); //关键字
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvzx_TopicObjectiveDA: GetObjByDataRowvzx_TopicObjective)", objException.Message));
}
objvzx_TopicObjectiveEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvzx_TopicObjectiveEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvzx_TopicObjectiveEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvzx_TopicObjectiveEN objvzx_TopicObjectiveEN = new clsvzx_TopicObjectiveEN();
try
{
objvzx_TopicObjectiveEN.zxTopicObjectiveId = objRow[convzx_TopicObjective.zxTopicObjectiveId].ToString().Trim(); //客观Id
objvzx_TopicObjectiveEN.ObjectiveName = objRow[convzx_TopicObjective.ObjectiveName] == DBNull.Value ? null : objRow[convzx_TopicObjective.ObjectiveName].ToString().Trim(); //客观名称
objvzx_TopicObjectiveEN.ObjectiveContent = objRow[convzx_TopicObjective.ObjectiveContent] == DBNull.Value ? null : objRow[convzx_TopicObjective.ObjectiveContent].ToString().Trim(); //客观内容
objvzx_TopicObjectiveEN.ObjectiveType = objRow[convzx_TopicObjective.ObjectiveType] == DBNull.Value ? null : objRow[convzx_TopicObjective.ObjectiveType].ToString().Trim(); //客观类型
objvzx_TopicObjectiveEN.Conclusion = objRow[convzx_TopicObjective.Conclusion] == DBNull.Value ? null : objRow[convzx_TopicObjective.Conclusion].ToString().Trim(); //结论
objvzx_TopicObjectiveEN.TextId = objRow[convzx_TopicObjective.TextId] == DBNull.Value ? null : objRow[convzx_TopicObjective.TextId].ToString().Trim(); //课件Id
objvzx_TopicObjectiveEN.IsSubmit = TransNullToBool(objRow[convzx_TopicObjective.IsSubmit].ToString().Trim()); //是否提交
objvzx_TopicObjectiveEN.VoteCount = objRow[convzx_TopicObjective.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TopicObjective.VoteCount].ToString().Trim()); //点赞计数
objvzx_TopicObjectiveEN.AppraiseCount = objRow[convzx_TopicObjective.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TopicObjective.AppraiseCount].ToString().Trim()); //评论数
objvzx_TopicObjectiveEN.Score = objRow[convzx_TopicObjective.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_TopicObjective.Score].ToString().Trim()); //评分
objvzx_TopicObjectiveEN.StuScore = objRow[convzx_TopicObjective.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_TopicObjective.StuScore].ToString().Trim()); //学生平均分
objvzx_TopicObjectiveEN.TeaScore = objRow[convzx_TopicObjective.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_TopicObjective.TeaScore].ToString().Trim()); //教师评分
objvzx_TopicObjectiveEN.IdCurrEduCls = objRow[convzx_TopicObjective.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_TopicObjective.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TopicObjectiveEN.PdfContent = objRow[convzx_TopicObjective.PdfContent] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfContent].ToString().Trim(); //Pdf内容
objvzx_TopicObjectiveEN.PdfPageNum = objRow[convzx_TopicObjective.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TopicObjective.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_TopicObjectiveEN.CitationCount = objRow[convzx_TopicObjective.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TopicObjective.CitationCount].ToString().Trim()); //引用统计
objvzx_TopicObjectiveEN.VersionCount = objRow[convzx_TopicObjective.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TopicObjective.VersionCount].ToString().Trim()); //版本统计
objvzx_TopicObjectiveEN.zxShareId = objRow[convzx_TopicObjective.zxShareId] == DBNull.Value ? null : objRow[convzx_TopicObjective.zxShareId].ToString().Trim(); //分享Id
objvzx_TopicObjectiveEN.CreateDate = objRow[convzx_TopicObjective.CreateDate] == DBNull.Value ? null : objRow[convzx_TopicObjective.CreateDate].ToString().Trim(); //建立日期
objvzx_TopicObjectiveEN.UpdDate = objRow[convzx_TopicObjective.UpdDate] == DBNull.Value ? null : objRow[convzx_TopicObjective.UpdDate].ToString().Trim(); //修改日期
objvzx_TopicObjectiveEN.UpdUser = objRow[convzx_TopicObjective.UpdUser] == DBNull.Value ? null : objRow[convzx_TopicObjective.UpdUser].ToString().Trim(); //修改人
objvzx_TopicObjectiveEN.Memo = objRow[convzx_TopicObjective.Memo] == DBNull.Value ? null : objRow[convzx_TopicObjective.Memo].ToString().Trim(); //备注
objvzx_TopicObjectiveEN.PdfDivLet = objRow[convzx_TopicObjective.PdfDivLet] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_TopicObjectiveEN.PdfDivTop = objRow[convzx_TopicObjective.PdfDivTop] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_TopicObjectiveEN.PdfPageNumIn = objRow[convzx_TopicObjective.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_TopicObjectiveEN.PdfPageTop = objRow[convzx_TopicObjective.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TopicObjective.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_TopicObjectiveEN.PdfZoom = objRow[convzx_TopicObjective.PdfZoom] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_TopicObjectiveEN.GroupTextId = objRow[convzx_TopicObjective.GroupTextId] == DBNull.Value ? null : objRow[convzx_TopicObjective.GroupTextId].ToString().Trim(); //小组Id
objvzx_TopicObjectiveEN.TextTitle = objRow[convzx_TopicObjective.TextTitle] == DBNull.Value ? null : objRow[convzx_TopicObjective.TextTitle].ToString().Trim(); //TextTitle
objvzx_TopicObjectiveEN.TextContent = objRow[convzx_TopicObjective.TextContent] == DBNull.Value ? null : objRow[convzx_TopicObjective.TextContent].ToString().Trim(); //TextContent
objvzx_TopicObjectiveEN.Author = objRow[convzx_TopicObjective.Author] == DBNull.Value ? null : objRow[convzx_TopicObjective.Author].ToString().Trim(); //作者
objvzx_TopicObjectiveEN.Keyword = objRow[convzx_TopicObjective.Keyword] == DBNull.Value ? null : objRow[convzx_TopicObjective.Keyword].ToString().Trim(); //关键字
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvzx_TopicObjectiveDA: GetObjByDataRow)", objException.Message));
}
objvzx_TopicObjectiveEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvzx_TopicObjectiveEN;
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
objSQL = clsvzx_TopicObjectiveDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvzx_TopicObjectiveEN._CurrTabName, convzx_TopicObjective.zxTopicObjectiveId, 8, "");
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
objSQL = clsvzx_TopicObjectiveDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvzx_TopicObjectiveEN._CurrTabName, convzx_TopicObjective.zxTopicObjectiveId, 8, strPrefix);
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
 objSQL = clsvzx_TopicObjectiveDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select zxTopicObjectiveId from vzx_TopicObjective where " + strCondition;
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
 objSQL = clsvzx_TopicObjectiveDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select zxTopicObjectiveId from vzx_TopicObjective where " + strCondition;
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
 /// <param name = "strzxTopicObjectiveId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strzxTopicObjectiveId)
{
CheckPrimaryKey(strzxTopicObjectiveId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TopicObjectiveDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vzx_TopicObjective", "zxTopicObjectiveId = " + "'"+ strzxTopicObjectiveId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvzx_TopicObjectiveDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TopicObjectiveDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vzx_TopicObjective", strCondition))
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
objSQL = clsvzx_TopicObjectiveDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vzx_TopicObjective");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvzx_TopicObjectiveENS">源对象</param>
 /// <param name = "objvzx_TopicObjectiveENT">目标对象</param>
public void CopyTo(clsvzx_TopicObjectiveEN objvzx_TopicObjectiveENS, clsvzx_TopicObjectiveEN objvzx_TopicObjectiveENT)
{
objvzx_TopicObjectiveENT.zxTopicObjectiveId = objvzx_TopicObjectiveENS.zxTopicObjectiveId; //客观Id
objvzx_TopicObjectiveENT.ObjectiveName = objvzx_TopicObjectiveENS.ObjectiveName; //客观名称
objvzx_TopicObjectiveENT.ObjectiveContent = objvzx_TopicObjectiveENS.ObjectiveContent; //客观内容
objvzx_TopicObjectiveENT.ObjectiveType = objvzx_TopicObjectiveENS.ObjectiveType; //客观类型
objvzx_TopicObjectiveENT.Conclusion = objvzx_TopicObjectiveENS.Conclusion; //结论
objvzx_TopicObjectiveENT.TextId = objvzx_TopicObjectiveENS.TextId; //课件Id
objvzx_TopicObjectiveENT.IsSubmit = objvzx_TopicObjectiveENS.IsSubmit; //是否提交
objvzx_TopicObjectiveENT.VoteCount = objvzx_TopicObjectiveENS.VoteCount; //点赞计数
objvzx_TopicObjectiveENT.AppraiseCount = objvzx_TopicObjectiveENS.AppraiseCount; //评论数
objvzx_TopicObjectiveENT.Score = objvzx_TopicObjectiveENS.Score; //评分
objvzx_TopicObjectiveENT.StuScore = objvzx_TopicObjectiveENS.StuScore; //学生平均分
objvzx_TopicObjectiveENT.TeaScore = objvzx_TopicObjectiveENS.TeaScore; //教师评分
objvzx_TopicObjectiveENT.IdCurrEduCls = objvzx_TopicObjectiveENS.IdCurrEduCls; //教学班流水号
objvzx_TopicObjectiveENT.PdfContent = objvzx_TopicObjectiveENS.PdfContent; //Pdf内容
objvzx_TopicObjectiveENT.PdfPageNum = objvzx_TopicObjectiveENS.PdfPageNum; //Pdf页码
objvzx_TopicObjectiveENT.CitationCount = objvzx_TopicObjectiveENS.CitationCount; //引用统计
objvzx_TopicObjectiveENT.VersionCount = objvzx_TopicObjectiveENS.VersionCount; //版本统计
objvzx_TopicObjectiveENT.zxShareId = objvzx_TopicObjectiveENS.zxShareId; //分享Id
objvzx_TopicObjectiveENT.CreateDate = objvzx_TopicObjectiveENS.CreateDate; //建立日期
objvzx_TopicObjectiveENT.UpdDate = objvzx_TopicObjectiveENS.UpdDate; //修改日期
objvzx_TopicObjectiveENT.UpdUser = objvzx_TopicObjectiveENS.UpdUser; //修改人
objvzx_TopicObjectiveENT.Memo = objvzx_TopicObjectiveENS.Memo; //备注
objvzx_TopicObjectiveENT.PdfDivLet = objvzx_TopicObjectiveENS.PdfDivLet; //PdfDivLet
objvzx_TopicObjectiveENT.PdfDivTop = objvzx_TopicObjectiveENS.PdfDivTop; //PdfDivTop
objvzx_TopicObjectiveENT.PdfPageNumIn = objvzx_TopicObjectiveENS.PdfPageNumIn; //PdfPageNumIn
objvzx_TopicObjectiveENT.PdfPageTop = objvzx_TopicObjectiveENS.PdfPageTop; //pdf页面顶部位置
objvzx_TopicObjectiveENT.PdfZoom = objvzx_TopicObjectiveENS.PdfZoom; //PdfZoom
objvzx_TopicObjectiveENT.GroupTextId = objvzx_TopicObjectiveENS.GroupTextId; //小组Id
objvzx_TopicObjectiveENT.TextTitle = objvzx_TopicObjectiveENS.TextTitle; //TextTitle
objvzx_TopicObjectiveENT.TextContent = objvzx_TopicObjectiveENS.TextContent; //TextContent
objvzx_TopicObjectiveENT.Author = objvzx_TopicObjectiveENS.Author; //作者
objvzx_TopicObjectiveENT.Keyword = objvzx_TopicObjectiveENS.Keyword; //关键字
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvzx_TopicObjectiveEN objvzx_TopicObjectiveEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvzx_TopicObjectiveEN.zxTopicObjectiveId, 8, convzx_TopicObjective.zxTopicObjectiveId);
clsCheckSql.CheckFieldLen(objvzx_TopicObjectiveEN.ObjectiveName, 500, convzx_TopicObjective.ObjectiveName);
clsCheckSql.CheckFieldLen(objvzx_TopicObjectiveEN.ObjectiveType, 2, convzx_TopicObjective.ObjectiveType);
clsCheckSql.CheckFieldLen(objvzx_TopicObjectiveEN.TextId, 8, convzx_TopicObjective.TextId);
clsCheckSql.CheckFieldLen(objvzx_TopicObjectiveEN.IdCurrEduCls, 8, convzx_TopicObjective.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objvzx_TopicObjectiveEN.PdfContent, 2000, convzx_TopicObjective.PdfContent);
clsCheckSql.CheckFieldLen(objvzx_TopicObjectiveEN.zxShareId, 2, convzx_TopicObjective.zxShareId);
clsCheckSql.CheckFieldLen(objvzx_TopicObjectiveEN.CreateDate, 20, convzx_TopicObjective.CreateDate);
clsCheckSql.CheckFieldLen(objvzx_TopicObjectiveEN.UpdDate, 20, convzx_TopicObjective.UpdDate);
clsCheckSql.CheckFieldLen(objvzx_TopicObjectiveEN.UpdUser, 20, convzx_TopicObjective.UpdUser);
clsCheckSql.CheckFieldLen(objvzx_TopicObjectiveEN.Memo, 1000, convzx_TopicObjective.Memo);
clsCheckSql.CheckFieldLen(objvzx_TopicObjectiveEN.PdfDivLet, 50, convzx_TopicObjective.PdfDivLet);
clsCheckSql.CheckFieldLen(objvzx_TopicObjectiveEN.PdfDivTop, 50, convzx_TopicObjective.PdfDivTop);
clsCheckSql.CheckFieldLen(objvzx_TopicObjectiveEN.PdfPageNumIn, 50, convzx_TopicObjective.PdfPageNumIn);
clsCheckSql.CheckFieldLen(objvzx_TopicObjectiveEN.PdfZoom, 50, convzx_TopicObjective.PdfZoom);
clsCheckSql.CheckFieldLen(objvzx_TopicObjectiveEN.GroupTextId, 8, convzx_TopicObjective.GroupTextId);
clsCheckSql.CheckFieldLen(objvzx_TopicObjectiveEN.TextTitle, 500, convzx_TopicObjective.TextTitle);
clsCheckSql.CheckFieldLen(objvzx_TopicObjectiveEN.Author, 200, convzx_TopicObjective.Author);
clsCheckSql.CheckFieldLen(objvzx_TopicObjectiveEN.Keyword, 1000, convzx_TopicObjective.Keyword);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvzx_TopicObjectiveEN.zxTopicObjectiveId, convzx_TopicObjective.zxTopicObjectiveId);
clsCheckSql.CheckSqlInjection4Field(objvzx_TopicObjectiveEN.ObjectiveName, convzx_TopicObjective.ObjectiveName);
clsCheckSql.CheckSqlInjection4Field(objvzx_TopicObjectiveEN.ObjectiveType, convzx_TopicObjective.ObjectiveType);
clsCheckSql.CheckSqlInjection4Field(objvzx_TopicObjectiveEN.TextId, convzx_TopicObjective.TextId);
clsCheckSql.CheckSqlInjection4Field(objvzx_TopicObjectiveEN.IdCurrEduCls, convzx_TopicObjective.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objvzx_TopicObjectiveEN.PdfContent, convzx_TopicObjective.PdfContent);
clsCheckSql.CheckSqlInjection4Field(objvzx_TopicObjectiveEN.zxShareId, convzx_TopicObjective.zxShareId);
clsCheckSql.CheckSqlInjection4Field(objvzx_TopicObjectiveEN.CreateDate, convzx_TopicObjective.CreateDate);
clsCheckSql.CheckSqlInjection4Field(objvzx_TopicObjectiveEN.UpdDate, convzx_TopicObjective.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvzx_TopicObjectiveEN.UpdUser, convzx_TopicObjective.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvzx_TopicObjectiveEN.Memo, convzx_TopicObjective.Memo);
clsCheckSql.CheckSqlInjection4Field(objvzx_TopicObjectiveEN.PdfDivLet, convzx_TopicObjective.PdfDivLet);
clsCheckSql.CheckSqlInjection4Field(objvzx_TopicObjectiveEN.PdfDivTop, convzx_TopicObjective.PdfDivTop);
clsCheckSql.CheckSqlInjection4Field(objvzx_TopicObjectiveEN.PdfPageNumIn, convzx_TopicObjective.PdfPageNumIn);
clsCheckSql.CheckSqlInjection4Field(objvzx_TopicObjectiveEN.PdfZoom, convzx_TopicObjective.PdfZoom);
clsCheckSql.CheckSqlInjection4Field(objvzx_TopicObjectiveEN.GroupTextId, convzx_TopicObjective.GroupTextId);
clsCheckSql.CheckSqlInjection4Field(objvzx_TopicObjectiveEN.TextTitle, convzx_TopicObjective.TextTitle);
clsCheckSql.CheckSqlInjection4Field(objvzx_TopicObjectiveEN.Author, convzx_TopicObjective.Author);
clsCheckSql.CheckSqlInjection4Field(objvzx_TopicObjectiveEN.Keyword, convzx_TopicObjective.Keyword);
//检查外键字段长度
 objvzx_TopicObjectiveEN._IsCheckProperty = true;
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
 objSQL = clsvzx_TopicObjectiveDA.GetSpecSQLObj();
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
 objSQL = clsvzx_TopicObjectiveDA.GetSpecSQLObj();
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
 objSQL = clsvzx_TopicObjectiveDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvzx_TopicObjectiveEN._CurrTabName);
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
 objSQL = clsvzx_TopicObjectiveDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvzx_TopicObjectiveEN._CurrTabName, strCondition);
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
 objSQL = clsvzx_TopicObjectiveDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}