
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvgs_ResearchResultDA
 表名:vgs_ResearchResult(01120778)
 * 版本:2023.10.02.1(服务器:WIN-SRV103-116)
 日期:2023/10/08 16:38:12
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培主题(GradEduTopic)
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
 /// 研究成果视图(vgs_ResearchResult)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvgs_ResearchResultDA : clsCommBase4DA
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
 return clsvgs_ResearchResultEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvgs_ResearchResultEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvgs_ResearchResultEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvgs_ResearchResultEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvgs_ResearchResultEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strResultId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strResultId)
{
strResultId = strResultId.Replace("'", "''");
if (strResultId.Length > 10)
{
throw new Exception("(errid:Data000001)在表:vgs_ResearchResult中,检查关键字,长度不正确!(clsvgs_ResearchResultDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strResultId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vgs_ResearchResult中,关键字不能为空 或 null!(clsvgs_ResearchResultDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strResultId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvgs_ResearchResultDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvgs_ResearchResultDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_ResearchResultDA.GetSpecSQLObj();
strSQL = "Select * from vgs_ResearchResult where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vgs_ResearchResult(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvgs_ResearchResultDA: GetDataTable_vgs_ResearchResult)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_ResearchResultDA.GetSpecSQLObj();
strSQL = "Select * from vgs_ResearchResult where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvgs_ResearchResultDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_ResearchResultDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvgs_ResearchResultDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_ResearchResultDA.GetSpecSQLObj();
strSQL = "Select * from vgs_ResearchResult where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvgs_ResearchResultDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_ResearchResultDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvgs_ResearchResultDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_ResearchResultDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vgs_ResearchResult where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vgs_ResearchResult where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvgs_ResearchResultDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_ResearchResultDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vgs_ResearchResult where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvgs_ResearchResultDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_ResearchResultDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vgs_ResearchResult.* from vgs_ResearchResult Left Join {1} on {2} where {3} and vgs_ResearchResult.ResultId not in (Select top {5} vgs_ResearchResult.ResultId from vgs_ResearchResult Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vgs_ResearchResult where {1} and ResultId not in (Select top {2} ResultId from vgs_ResearchResult where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vgs_ResearchResult where {1} and ResultId not in (Select top {3} ResultId from vgs_ResearchResult where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvgs_ResearchResultDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_ResearchResultDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vgs_ResearchResult.* from vgs_ResearchResult Left Join {1} on {2} where {3} and vgs_ResearchResult.ResultId not in (Select top {5} vgs_ResearchResult.ResultId from vgs_ResearchResult Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vgs_ResearchResult where {1} and ResultId not in (Select top {2} ResultId from vgs_ResearchResult where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vgs_ResearchResult where {1} and ResultId not in (Select top {3} ResultId from vgs_ResearchResult where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvgs_ResearchResultEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvgs_ResearchResultDA:GetObjLst)", objException.Message));
}
List<clsvgs_ResearchResultEN> arrObjLst = new List<clsvgs_ResearchResultEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_ResearchResultDA.GetSpecSQLObj();
strSQL = "Select * from vgs_ResearchResult where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_ResearchResultEN objvgs_ResearchResultEN = new clsvgs_ResearchResultEN();
try
{
objvgs_ResearchResultEN.ResultId = objRow[convgs_ResearchResult.ResultId].ToString().Trim(); //成果Id
objvgs_ResearchResultEN.TopicId = objRow[convgs_ResearchResult.TopicId] == DBNull.Value ? null : objRow[convgs_ResearchResult.TopicId].ToString().Trim(); //主题Id
objvgs_ResearchResultEN.TopicName = objRow[convgs_ResearchResult.TopicName] == DBNull.Value ? null : objRow[convgs_ResearchResult.TopicName].ToString().Trim(); //栏目主题
objvgs_ResearchResultEN.PaperId = objRow[convgs_ResearchResult.PaperId] == DBNull.Value ? null : objRow[convgs_ResearchResult.PaperId].ToString().Trim(); //论文Id
objvgs_ResearchResultEN.IdCurrEduCls = objRow[convgs_ResearchResult.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_ResearchResult.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_ResearchResultEN.ResultTypeId = objRow[convgs_ResearchResult.ResultTypeId] == DBNull.Value ? null : objRow[convgs_ResearchResult.ResultTypeId].ToString().Trim(); //成果类型Id
objvgs_ResearchResultEN.ResultName = objRow[convgs_ResearchResult.ResultName] == DBNull.Value ? null : objRow[convgs_ResearchResult.ResultName].ToString().Trim(); //成果名称
objvgs_ResearchResultEN.ResultContent = objRow[convgs_ResearchResult.ResultContent] == DBNull.Value ? null : objRow[convgs_ResearchResult.ResultContent].ToString().Trim(); //成果内容
objvgs_ResearchResultEN.Author = objRow[convgs_ResearchResult.Author] == DBNull.Value ? null : objRow[convgs_ResearchResult.Author].ToString().Trim(); //作者
objvgs_ResearchResultEN.Division = objRow[convgs_ResearchResult.Division] == DBNull.Value ? null : objRow[convgs_ResearchResult.Division].ToString().Trim(); //分工
objvgs_ResearchResultEN.VersionCount = objRow[convgs_ResearchResult.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_ResearchResult.VersionCount].ToString().Trim()); //版本统计
objvgs_ResearchResultEN.OkCount = objRow[convgs_ResearchResult.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_ResearchResult.OkCount].ToString().Trim()); //点赞统计
objvgs_ResearchResultEN.AppraiseCount = objRow[convgs_ResearchResult.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_ResearchResult.AppraiseCount].ToString().Trim()); //评论数
objvgs_ResearchResultEN.Score = objRow[convgs_ResearchResult.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_ResearchResult.Score].ToString().Trim()); //评分
objvgs_ResearchResultEN.StuScore = objRow[convgs_ResearchResult.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_ResearchResult.StuScore].ToString().Trim()); //学生平均分
objvgs_ResearchResultEN.TeaScore = objRow[convgs_ResearchResult.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_ResearchResult.TeaScore].ToString().Trim()); //教师评分
objvgs_ResearchResultEN.UpdDate = objRow[convgs_ResearchResult.UpdDate] == DBNull.Value ? null : objRow[convgs_ResearchResult.UpdDate].ToString().Trim(); //修改日期
objvgs_ResearchResultEN.UpdUser = objRow[convgs_ResearchResult.UpdUser] == DBNull.Value ? null : objRow[convgs_ResearchResult.UpdUser].ToString().Trim(); //修改人
objvgs_ResearchResultEN.Memo = objRow[convgs_ResearchResult.Memo] == DBNull.Value ? null : objRow[convgs_ResearchResult.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvgs_ResearchResultDA: GetObjLst)", objException.Message));
}
objvgs_ResearchResultEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvgs_ResearchResultEN);
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
public List<clsvgs_ResearchResultEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvgs_ResearchResultDA:GetObjLstByTabName)", objException.Message));
}
List<clsvgs_ResearchResultEN> arrObjLst = new List<clsvgs_ResearchResultEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_ResearchResultDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_ResearchResultEN objvgs_ResearchResultEN = new clsvgs_ResearchResultEN();
try
{
objvgs_ResearchResultEN.ResultId = objRow[convgs_ResearchResult.ResultId].ToString().Trim(); //成果Id
objvgs_ResearchResultEN.TopicId = objRow[convgs_ResearchResult.TopicId] == DBNull.Value ? null : objRow[convgs_ResearchResult.TopicId].ToString().Trim(); //主题Id
objvgs_ResearchResultEN.TopicName = objRow[convgs_ResearchResult.TopicName] == DBNull.Value ? null : objRow[convgs_ResearchResult.TopicName].ToString().Trim(); //栏目主题
objvgs_ResearchResultEN.PaperId = objRow[convgs_ResearchResult.PaperId] == DBNull.Value ? null : objRow[convgs_ResearchResult.PaperId].ToString().Trim(); //论文Id
objvgs_ResearchResultEN.IdCurrEduCls = objRow[convgs_ResearchResult.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_ResearchResult.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_ResearchResultEN.ResultTypeId = objRow[convgs_ResearchResult.ResultTypeId] == DBNull.Value ? null : objRow[convgs_ResearchResult.ResultTypeId].ToString().Trim(); //成果类型Id
objvgs_ResearchResultEN.ResultName = objRow[convgs_ResearchResult.ResultName] == DBNull.Value ? null : objRow[convgs_ResearchResult.ResultName].ToString().Trim(); //成果名称
objvgs_ResearchResultEN.ResultContent = objRow[convgs_ResearchResult.ResultContent] == DBNull.Value ? null : objRow[convgs_ResearchResult.ResultContent].ToString().Trim(); //成果内容
objvgs_ResearchResultEN.Author = objRow[convgs_ResearchResult.Author] == DBNull.Value ? null : objRow[convgs_ResearchResult.Author].ToString().Trim(); //作者
objvgs_ResearchResultEN.Division = objRow[convgs_ResearchResult.Division] == DBNull.Value ? null : objRow[convgs_ResearchResult.Division].ToString().Trim(); //分工
objvgs_ResearchResultEN.VersionCount = objRow[convgs_ResearchResult.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_ResearchResult.VersionCount].ToString().Trim()); //版本统计
objvgs_ResearchResultEN.OkCount = objRow[convgs_ResearchResult.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_ResearchResult.OkCount].ToString().Trim()); //点赞统计
objvgs_ResearchResultEN.AppraiseCount = objRow[convgs_ResearchResult.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_ResearchResult.AppraiseCount].ToString().Trim()); //评论数
objvgs_ResearchResultEN.Score = objRow[convgs_ResearchResult.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_ResearchResult.Score].ToString().Trim()); //评分
objvgs_ResearchResultEN.StuScore = objRow[convgs_ResearchResult.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_ResearchResult.StuScore].ToString().Trim()); //学生平均分
objvgs_ResearchResultEN.TeaScore = objRow[convgs_ResearchResult.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_ResearchResult.TeaScore].ToString().Trim()); //教师评分
objvgs_ResearchResultEN.UpdDate = objRow[convgs_ResearchResult.UpdDate] == DBNull.Value ? null : objRow[convgs_ResearchResult.UpdDate].ToString().Trim(); //修改日期
objvgs_ResearchResultEN.UpdUser = objRow[convgs_ResearchResult.UpdUser] == DBNull.Value ? null : objRow[convgs_ResearchResult.UpdUser].ToString().Trim(); //修改人
objvgs_ResearchResultEN.Memo = objRow[convgs_ResearchResult.Memo] == DBNull.Value ? null : objRow[convgs_ResearchResult.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvgs_ResearchResultDA: GetObjLst)", objException.Message));
}
objvgs_ResearchResultEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvgs_ResearchResultEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvgs_ResearchResultEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getvgs_ResearchResult(ref clsvgs_ResearchResultEN objvgs_ResearchResultEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_ResearchResultDA.GetSpecSQLObj();
strSQL = "Select * from vgs_ResearchResult where ResultId = " + "'"+ objvgs_ResearchResultEN.ResultId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvgs_ResearchResultEN.ResultId = objDT.Rows[0][convgs_ResearchResult.ResultId].ToString().Trim(); //成果Id(字段类型:char,字段长度:10,是否可空:False)
 objvgs_ResearchResultEN.TopicId = objDT.Rows[0][convgs_ResearchResult.TopicId].ToString().Trim(); //主题Id(字段类型:char,字段长度:8,是否可空:True)
 objvgs_ResearchResultEN.TopicName = objDT.Rows[0][convgs_ResearchResult.TopicName].ToString().Trim(); //栏目主题(字段类型:varchar,字段长度:200,是否可空:True)
 objvgs_ResearchResultEN.PaperId = objDT.Rows[0][convgs_ResearchResult.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objvgs_ResearchResultEN.IdCurrEduCls = objDT.Rows[0][convgs_ResearchResult.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvgs_ResearchResultEN.ResultTypeId = objDT.Rows[0][convgs_ResearchResult.ResultTypeId].ToString().Trim(); //成果类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvgs_ResearchResultEN.ResultName = objDT.Rows[0][convgs_ResearchResult.ResultName].ToString().Trim(); //成果名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvgs_ResearchResultEN.ResultContent = objDT.Rows[0][convgs_ResearchResult.ResultContent].ToString().Trim(); //成果内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvgs_ResearchResultEN.Author = objDT.Rows[0][convgs_ResearchResult.Author].ToString().Trim(); //作者(字段类型:varchar,字段长度:200,是否可空:True)
 objvgs_ResearchResultEN.Division = objDT.Rows[0][convgs_ResearchResult.Division].ToString().Trim(); //分工(字段类型:varchar,字段长度:500,是否可空:True)
 objvgs_ResearchResultEN.VersionCount = TransNullToInt(objDT.Rows[0][convgs_ResearchResult.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objvgs_ResearchResultEN.OkCount = TransNullToInt(objDT.Rows[0][convgs_ResearchResult.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objvgs_ResearchResultEN.AppraiseCount = TransNullToInt(objDT.Rows[0][convgs_ResearchResult.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objvgs_ResearchResultEN.Score = TransNullToFloat(objDT.Rows[0][convgs_ResearchResult.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvgs_ResearchResultEN.StuScore = TransNullToFloat(objDT.Rows[0][convgs_ResearchResult.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objvgs_ResearchResultEN.TeaScore = TransNullToFloat(objDT.Rows[0][convgs_ResearchResult.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objvgs_ResearchResultEN.UpdDate = objDT.Rows[0][convgs_ResearchResult.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_ResearchResultEN.UpdUser = objDT.Rows[0][convgs_ResearchResult.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_ResearchResultEN.Memo = objDT.Rows[0][convgs_ResearchResult.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvgs_ResearchResultDA: Getvgs_ResearchResult)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strResultId">表关键字</param>
 /// <returns>表对象</returns>
public clsvgs_ResearchResultEN GetObjByResultId(string strResultId)
{
CheckPrimaryKey(strResultId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_ResearchResultDA.GetSpecSQLObj();
strSQL = "Select * from vgs_ResearchResult where ResultId = " + "'"+ strResultId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvgs_ResearchResultEN objvgs_ResearchResultEN = new clsvgs_ResearchResultEN();
try
{
 objvgs_ResearchResultEN.ResultId = objRow[convgs_ResearchResult.ResultId].ToString().Trim(); //成果Id(字段类型:char,字段长度:10,是否可空:False)
 objvgs_ResearchResultEN.TopicId = objRow[convgs_ResearchResult.TopicId] == DBNull.Value ? null : objRow[convgs_ResearchResult.TopicId].ToString().Trim(); //主题Id(字段类型:char,字段长度:8,是否可空:True)
 objvgs_ResearchResultEN.TopicName = objRow[convgs_ResearchResult.TopicName] == DBNull.Value ? null : objRow[convgs_ResearchResult.TopicName].ToString().Trim(); //栏目主题(字段类型:varchar,字段长度:200,是否可空:True)
 objvgs_ResearchResultEN.PaperId = objRow[convgs_ResearchResult.PaperId] == DBNull.Value ? null : objRow[convgs_ResearchResult.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objvgs_ResearchResultEN.IdCurrEduCls = objRow[convgs_ResearchResult.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_ResearchResult.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvgs_ResearchResultEN.ResultTypeId = objRow[convgs_ResearchResult.ResultTypeId] == DBNull.Value ? null : objRow[convgs_ResearchResult.ResultTypeId].ToString().Trim(); //成果类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvgs_ResearchResultEN.ResultName = objRow[convgs_ResearchResult.ResultName] == DBNull.Value ? null : objRow[convgs_ResearchResult.ResultName].ToString().Trim(); //成果名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvgs_ResearchResultEN.ResultContent = objRow[convgs_ResearchResult.ResultContent] == DBNull.Value ? null : objRow[convgs_ResearchResult.ResultContent].ToString().Trim(); //成果内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvgs_ResearchResultEN.Author = objRow[convgs_ResearchResult.Author] == DBNull.Value ? null : objRow[convgs_ResearchResult.Author].ToString().Trim(); //作者(字段类型:varchar,字段长度:200,是否可空:True)
 objvgs_ResearchResultEN.Division = objRow[convgs_ResearchResult.Division] == DBNull.Value ? null : objRow[convgs_ResearchResult.Division].ToString().Trim(); //分工(字段类型:varchar,字段长度:500,是否可空:True)
 objvgs_ResearchResultEN.VersionCount = objRow[convgs_ResearchResult.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_ResearchResult.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objvgs_ResearchResultEN.OkCount = objRow[convgs_ResearchResult.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_ResearchResult.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objvgs_ResearchResultEN.AppraiseCount = objRow[convgs_ResearchResult.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_ResearchResult.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objvgs_ResearchResultEN.Score = objRow[convgs_ResearchResult.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_ResearchResult.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvgs_ResearchResultEN.StuScore = objRow[convgs_ResearchResult.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_ResearchResult.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objvgs_ResearchResultEN.TeaScore = objRow[convgs_ResearchResult.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_ResearchResult.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objvgs_ResearchResultEN.UpdDate = objRow[convgs_ResearchResult.UpdDate] == DBNull.Value ? null : objRow[convgs_ResearchResult.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_ResearchResultEN.UpdUser = objRow[convgs_ResearchResult.UpdUser] == DBNull.Value ? null : objRow[convgs_ResearchResult.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_ResearchResultEN.Memo = objRow[convgs_ResearchResult.Memo] == DBNull.Value ? null : objRow[convgs_ResearchResult.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvgs_ResearchResultDA: GetObjByResultId)", objException.Message));
}
return objvgs_ResearchResultEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvgs_ResearchResultEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvgs_ResearchResultDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_ResearchResultDA.GetSpecSQLObj();
strSQL = "Select * from vgs_ResearchResult where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvgs_ResearchResultEN objvgs_ResearchResultEN = new clsvgs_ResearchResultEN()
{
ResultId = objRow[convgs_ResearchResult.ResultId].ToString().Trim(), //成果Id
TopicId = objRow[convgs_ResearchResult.TopicId] == DBNull.Value ? null : objRow[convgs_ResearchResult.TopicId].ToString().Trim(), //主题Id
TopicName = objRow[convgs_ResearchResult.TopicName] == DBNull.Value ? null : objRow[convgs_ResearchResult.TopicName].ToString().Trim(), //栏目主题
PaperId = objRow[convgs_ResearchResult.PaperId] == DBNull.Value ? null : objRow[convgs_ResearchResult.PaperId].ToString().Trim(), //论文Id
IdCurrEduCls = objRow[convgs_ResearchResult.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_ResearchResult.IdCurrEduCls].ToString().Trim(), //教学班流水号
ResultTypeId = objRow[convgs_ResearchResult.ResultTypeId] == DBNull.Value ? null : objRow[convgs_ResearchResult.ResultTypeId].ToString().Trim(), //成果类型Id
ResultName = objRow[convgs_ResearchResult.ResultName] == DBNull.Value ? null : objRow[convgs_ResearchResult.ResultName].ToString().Trim(), //成果名称
ResultContent = objRow[convgs_ResearchResult.ResultContent] == DBNull.Value ? null : objRow[convgs_ResearchResult.ResultContent].ToString().Trim(), //成果内容
Author = objRow[convgs_ResearchResult.Author] == DBNull.Value ? null : objRow[convgs_ResearchResult.Author].ToString().Trim(), //作者
Division = objRow[convgs_ResearchResult.Division] == DBNull.Value ? null : objRow[convgs_ResearchResult.Division].ToString().Trim(), //分工
VersionCount = objRow[convgs_ResearchResult.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_ResearchResult.VersionCount].ToString().Trim()), //版本统计
OkCount = objRow[convgs_ResearchResult.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_ResearchResult.OkCount].ToString().Trim()), //点赞统计
AppraiseCount = objRow[convgs_ResearchResult.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_ResearchResult.AppraiseCount].ToString().Trim()), //评论数
Score = objRow[convgs_ResearchResult.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_ResearchResult.Score].ToString().Trim()), //评分
StuScore = objRow[convgs_ResearchResult.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_ResearchResult.StuScore].ToString().Trim()), //学生平均分
TeaScore = objRow[convgs_ResearchResult.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_ResearchResult.TeaScore].ToString().Trim()), //教师评分
UpdDate = objRow[convgs_ResearchResult.UpdDate] == DBNull.Value ? null : objRow[convgs_ResearchResult.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convgs_ResearchResult.UpdUser] == DBNull.Value ? null : objRow[convgs_ResearchResult.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convgs_ResearchResult.Memo] == DBNull.Value ? null : objRow[convgs_ResearchResult.Memo].ToString().Trim() //备注
};
objvgs_ResearchResultEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvgs_ResearchResultEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvgs_ResearchResultDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvgs_ResearchResultEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvgs_ResearchResultEN objvgs_ResearchResultEN = new clsvgs_ResearchResultEN();
try
{
objvgs_ResearchResultEN.ResultId = objRow[convgs_ResearchResult.ResultId].ToString().Trim(); //成果Id
objvgs_ResearchResultEN.TopicId = objRow[convgs_ResearchResult.TopicId] == DBNull.Value ? null : objRow[convgs_ResearchResult.TopicId].ToString().Trim(); //主题Id
objvgs_ResearchResultEN.TopicName = objRow[convgs_ResearchResult.TopicName] == DBNull.Value ? null : objRow[convgs_ResearchResult.TopicName].ToString().Trim(); //栏目主题
objvgs_ResearchResultEN.PaperId = objRow[convgs_ResearchResult.PaperId] == DBNull.Value ? null : objRow[convgs_ResearchResult.PaperId].ToString().Trim(); //论文Id
objvgs_ResearchResultEN.IdCurrEduCls = objRow[convgs_ResearchResult.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_ResearchResult.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_ResearchResultEN.ResultTypeId = objRow[convgs_ResearchResult.ResultTypeId] == DBNull.Value ? null : objRow[convgs_ResearchResult.ResultTypeId].ToString().Trim(); //成果类型Id
objvgs_ResearchResultEN.ResultName = objRow[convgs_ResearchResult.ResultName] == DBNull.Value ? null : objRow[convgs_ResearchResult.ResultName].ToString().Trim(); //成果名称
objvgs_ResearchResultEN.ResultContent = objRow[convgs_ResearchResult.ResultContent] == DBNull.Value ? null : objRow[convgs_ResearchResult.ResultContent].ToString().Trim(); //成果内容
objvgs_ResearchResultEN.Author = objRow[convgs_ResearchResult.Author] == DBNull.Value ? null : objRow[convgs_ResearchResult.Author].ToString().Trim(); //作者
objvgs_ResearchResultEN.Division = objRow[convgs_ResearchResult.Division] == DBNull.Value ? null : objRow[convgs_ResearchResult.Division].ToString().Trim(); //分工
objvgs_ResearchResultEN.VersionCount = objRow[convgs_ResearchResult.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_ResearchResult.VersionCount].ToString().Trim()); //版本统计
objvgs_ResearchResultEN.OkCount = objRow[convgs_ResearchResult.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_ResearchResult.OkCount].ToString().Trim()); //点赞统计
objvgs_ResearchResultEN.AppraiseCount = objRow[convgs_ResearchResult.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_ResearchResult.AppraiseCount].ToString().Trim()); //评论数
objvgs_ResearchResultEN.Score = objRow[convgs_ResearchResult.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_ResearchResult.Score].ToString().Trim()); //评分
objvgs_ResearchResultEN.StuScore = objRow[convgs_ResearchResult.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_ResearchResult.StuScore].ToString().Trim()); //学生平均分
objvgs_ResearchResultEN.TeaScore = objRow[convgs_ResearchResult.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_ResearchResult.TeaScore].ToString().Trim()); //教师评分
objvgs_ResearchResultEN.UpdDate = objRow[convgs_ResearchResult.UpdDate] == DBNull.Value ? null : objRow[convgs_ResearchResult.UpdDate].ToString().Trim(); //修改日期
objvgs_ResearchResultEN.UpdUser = objRow[convgs_ResearchResult.UpdUser] == DBNull.Value ? null : objRow[convgs_ResearchResult.UpdUser].ToString().Trim(); //修改人
objvgs_ResearchResultEN.Memo = objRow[convgs_ResearchResult.Memo] == DBNull.Value ? null : objRow[convgs_ResearchResult.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvgs_ResearchResultDA: GetObjByDataRowvgs_ResearchResult)", objException.Message));
}
objvgs_ResearchResultEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvgs_ResearchResultEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvgs_ResearchResultEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvgs_ResearchResultEN objvgs_ResearchResultEN = new clsvgs_ResearchResultEN();
try
{
objvgs_ResearchResultEN.ResultId = objRow[convgs_ResearchResult.ResultId].ToString().Trim(); //成果Id
objvgs_ResearchResultEN.TopicId = objRow[convgs_ResearchResult.TopicId] == DBNull.Value ? null : objRow[convgs_ResearchResult.TopicId].ToString().Trim(); //主题Id
objvgs_ResearchResultEN.TopicName = objRow[convgs_ResearchResult.TopicName] == DBNull.Value ? null : objRow[convgs_ResearchResult.TopicName].ToString().Trim(); //栏目主题
objvgs_ResearchResultEN.PaperId = objRow[convgs_ResearchResult.PaperId] == DBNull.Value ? null : objRow[convgs_ResearchResult.PaperId].ToString().Trim(); //论文Id
objvgs_ResearchResultEN.IdCurrEduCls = objRow[convgs_ResearchResult.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_ResearchResult.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_ResearchResultEN.ResultTypeId = objRow[convgs_ResearchResult.ResultTypeId] == DBNull.Value ? null : objRow[convgs_ResearchResult.ResultTypeId].ToString().Trim(); //成果类型Id
objvgs_ResearchResultEN.ResultName = objRow[convgs_ResearchResult.ResultName] == DBNull.Value ? null : objRow[convgs_ResearchResult.ResultName].ToString().Trim(); //成果名称
objvgs_ResearchResultEN.ResultContent = objRow[convgs_ResearchResult.ResultContent] == DBNull.Value ? null : objRow[convgs_ResearchResult.ResultContent].ToString().Trim(); //成果内容
objvgs_ResearchResultEN.Author = objRow[convgs_ResearchResult.Author] == DBNull.Value ? null : objRow[convgs_ResearchResult.Author].ToString().Trim(); //作者
objvgs_ResearchResultEN.Division = objRow[convgs_ResearchResult.Division] == DBNull.Value ? null : objRow[convgs_ResearchResult.Division].ToString().Trim(); //分工
objvgs_ResearchResultEN.VersionCount = objRow[convgs_ResearchResult.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_ResearchResult.VersionCount].ToString().Trim()); //版本统计
objvgs_ResearchResultEN.OkCount = objRow[convgs_ResearchResult.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_ResearchResult.OkCount].ToString().Trim()); //点赞统计
objvgs_ResearchResultEN.AppraiseCount = objRow[convgs_ResearchResult.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_ResearchResult.AppraiseCount].ToString().Trim()); //评论数
objvgs_ResearchResultEN.Score = objRow[convgs_ResearchResult.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_ResearchResult.Score].ToString().Trim()); //评分
objvgs_ResearchResultEN.StuScore = objRow[convgs_ResearchResult.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_ResearchResult.StuScore].ToString().Trim()); //学生平均分
objvgs_ResearchResultEN.TeaScore = objRow[convgs_ResearchResult.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_ResearchResult.TeaScore].ToString().Trim()); //教师评分
objvgs_ResearchResultEN.UpdDate = objRow[convgs_ResearchResult.UpdDate] == DBNull.Value ? null : objRow[convgs_ResearchResult.UpdDate].ToString().Trim(); //修改日期
objvgs_ResearchResultEN.UpdUser = objRow[convgs_ResearchResult.UpdUser] == DBNull.Value ? null : objRow[convgs_ResearchResult.UpdUser].ToString().Trim(); //修改人
objvgs_ResearchResultEN.Memo = objRow[convgs_ResearchResult.Memo] == DBNull.Value ? null : objRow[convgs_ResearchResult.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvgs_ResearchResultDA: GetObjByDataRow)", objException.Message));
}
objvgs_ResearchResultEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvgs_ResearchResultEN;
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
objSQL = clsvgs_ResearchResultDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvgs_ResearchResultEN._CurrTabName, convgs_ResearchResult.ResultId, 10, "");
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
objSQL = clsvgs_ResearchResultDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvgs_ResearchResultEN._CurrTabName, convgs_ResearchResult.ResultId, 10, strPrefix);
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
 objSQL = clsvgs_ResearchResultDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select ResultId from vgs_ResearchResult where " + strCondition;
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
 objSQL = clsvgs_ResearchResultDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select ResultId from vgs_ResearchResult where " + strCondition;
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
 /// <param name = "strResultId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strResultId)
{
CheckPrimaryKey(strResultId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_ResearchResultDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vgs_ResearchResult", "ResultId = " + "'"+ strResultId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvgs_ResearchResultDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_ResearchResultDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vgs_ResearchResult", strCondition))
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
objSQL = clsvgs_ResearchResultDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vgs_ResearchResult");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvgs_ResearchResultENS">源对象</param>
 /// <param name = "objvgs_ResearchResultENT">目标对象</param>
public void CopyTo(clsvgs_ResearchResultEN objvgs_ResearchResultENS, clsvgs_ResearchResultEN objvgs_ResearchResultENT)
{
objvgs_ResearchResultENT.ResultId = objvgs_ResearchResultENS.ResultId; //成果Id
objvgs_ResearchResultENT.TopicId = objvgs_ResearchResultENS.TopicId; //主题Id
objvgs_ResearchResultENT.TopicName = objvgs_ResearchResultENS.TopicName; //栏目主题
objvgs_ResearchResultENT.PaperId = objvgs_ResearchResultENS.PaperId; //论文Id
objvgs_ResearchResultENT.IdCurrEduCls = objvgs_ResearchResultENS.IdCurrEduCls; //教学班流水号
objvgs_ResearchResultENT.ResultTypeId = objvgs_ResearchResultENS.ResultTypeId; //成果类型Id
objvgs_ResearchResultENT.ResultName = objvgs_ResearchResultENS.ResultName; //成果名称
objvgs_ResearchResultENT.ResultContent = objvgs_ResearchResultENS.ResultContent; //成果内容
objvgs_ResearchResultENT.Author = objvgs_ResearchResultENS.Author; //作者
objvgs_ResearchResultENT.Division = objvgs_ResearchResultENS.Division; //分工
objvgs_ResearchResultENT.VersionCount = objvgs_ResearchResultENS.VersionCount; //版本统计
objvgs_ResearchResultENT.OkCount = objvgs_ResearchResultENS.OkCount; //点赞统计
objvgs_ResearchResultENT.AppraiseCount = objvgs_ResearchResultENS.AppraiseCount; //评论数
objvgs_ResearchResultENT.Score = objvgs_ResearchResultENS.Score; //评分
objvgs_ResearchResultENT.StuScore = objvgs_ResearchResultENS.StuScore; //学生平均分
objvgs_ResearchResultENT.TeaScore = objvgs_ResearchResultENS.TeaScore; //教师评分
objvgs_ResearchResultENT.UpdDate = objvgs_ResearchResultENS.UpdDate; //修改日期
objvgs_ResearchResultENT.UpdUser = objvgs_ResearchResultENS.UpdUser; //修改人
objvgs_ResearchResultENT.Memo = objvgs_ResearchResultENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvgs_ResearchResultEN objvgs_ResearchResultEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvgs_ResearchResultEN.ResultId, 10, convgs_ResearchResult.ResultId);
clsCheckSql.CheckFieldLen(objvgs_ResearchResultEN.TopicId, 8, convgs_ResearchResult.TopicId);
clsCheckSql.CheckFieldLen(objvgs_ResearchResultEN.TopicName, 200, convgs_ResearchResult.TopicName);
clsCheckSql.CheckFieldLen(objvgs_ResearchResultEN.PaperId, 8, convgs_ResearchResult.PaperId);
clsCheckSql.CheckFieldLen(objvgs_ResearchResultEN.IdCurrEduCls, 8, convgs_ResearchResult.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objvgs_ResearchResultEN.ResultTypeId, 2, convgs_ResearchResult.ResultTypeId);
clsCheckSql.CheckFieldLen(objvgs_ResearchResultEN.ResultName, 500, convgs_ResearchResult.ResultName);
clsCheckSql.CheckFieldLen(objvgs_ResearchResultEN.Author, 200, convgs_ResearchResult.Author);
clsCheckSql.CheckFieldLen(objvgs_ResearchResultEN.Division, 500, convgs_ResearchResult.Division);
clsCheckSql.CheckFieldLen(objvgs_ResearchResultEN.UpdDate, 20, convgs_ResearchResult.UpdDate);
clsCheckSql.CheckFieldLen(objvgs_ResearchResultEN.UpdUser, 20, convgs_ResearchResult.UpdUser);
clsCheckSql.CheckFieldLen(objvgs_ResearchResultEN.Memo, 1000, convgs_ResearchResult.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvgs_ResearchResultEN.ResultId, convgs_ResearchResult.ResultId);
clsCheckSql.CheckSqlInjection4Field(objvgs_ResearchResultEN.TopicId, convgs_ResearchResult.TopicId);
clsCheckSql.CheckSqlInjection4Field(objvgs_ResearchResultEN.TopicName, convgs_ResearchResult.TopicName);
clsCheckSql.CheckSqlInjection4Field(objvgs_ResearchResultEN.PaperId, convgs_ResearchResult.PaperId);
clsCheckSql.CheckSqlInjection4Field(objvgs_ResearchResultEN.IdCurrEduCls, convgs_ResearchResult.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objvgs_ResearchResultEN.ResultTypeId, convgs_ResearchResult.ResultTypeId);
clsCheckSql.CheckSqlInjection4Field(objvgs_ResearchResultEN.ResultName, convgs_ResearchResult.ResultName);
clsCheckSql.CheckSqlInjection4Field(objvgs_ResearchResultEN.Author, convgs_ResearchResult.Author);
clsCheckSql.CheckSqlInjection4Field(objvgs_ResearchResultEN.Division, convgs_ResearchResult.Division);
clsCheckSql.CheckSqlInjection4Field(objvgs_ResearchResultEN.UpdDate, convgs_ResearchResult.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvgs_ResearchResultEN.UpdUser, convgs_ResearchResult.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvgs_ResearchResultEN.Memo, convgs_ResearchResult.Memo);
//检查外键字段长度
 objvgs_ResearchResultEN._IsCheckProperty = true;
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
 objSQL = clsvgs_ResearchResultDA.GetSpecSQLObj();
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
 objSQL = clsvgs_ResearchResultDA.GetSpecSQLObj();
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
 objSQL = clsvgs_ResearchResultDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvgs_ResearchResultEN._CurrTabName);
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
 objSQL = clsvgs_ResearchResultDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvgs_ResearchResultEN._CurrTabName, strCondition);
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
 objSQL = clsvgs_ResearchResultDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}