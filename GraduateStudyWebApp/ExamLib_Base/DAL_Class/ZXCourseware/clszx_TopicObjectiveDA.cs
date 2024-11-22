
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_TopicObjectiveDA
 表名:zx_TopicObjective(01120708)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:56:21
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
 /// 中学客观事实数据(zx_TopicObjective)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clszx_TopicObjectiveDA : clsCommBase4DA
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
 return clszx_TopicObjectiveEN._CurrTabName;
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
if (string.IsNullOrEmpty(clszx_TopicObjectiveEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clszx_TopicObjectiveEN._ConnectString);
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
 if (string.IsNullOrEmpty(clszx_TopicObjectiveEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clszx_TopicObjectiveEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:zx_TopicObjective中,检查关键字,长度不正确!(clszx_TopicObjectiveDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strzxTopicObjectiveId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:zx_TopicObjective中,关键字不能为空 或 null!(clszx_TopicObjectiveDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strzxTopicObjectiveId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clszx_TopicObjectiveDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clszx_TopicObjectiveDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TopicObjectiveDA.GetSpecSQLObj();
strSQL = "Select * from zx_TopicObjective where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_zx_TopicObjective(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clszx_TopicObjectiveDA: GetDataTable_zx_TopicObjective)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TopicObjectiveDA.GetSpecSQLObj();
strSQL = "Select * from zx_TopicObjective where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clszx_TopicObjectiveDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TopicObjectiveDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clszx_TopicObjectiveDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TopicObjectiveDA.GetSpecSQLObj();
strSQL = "Select * from zx_TopicObjective where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clszx_TopicObjectiveDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TopicObjectiveDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clszx_TopicObjectiveDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TopicObjectiveDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_TopicObjective where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_TopicObjective where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clszx_TopicObjectiveDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TopicObjectiveDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from zx_TopicObjective where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clszx_TopicObjectiveDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TopicObjectiveDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} zx_TopicObjective.* from zx_TopicObjective Left Join {1} on {2} where {3} and zx_TopicObjective.zxTopicObjectiveId not in (Select top {5} zx_TopicObjective.zxTopicObjectiveId from zx_TopicObjective Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_TopicObjective where {1} and zxTopicObjectiveId not in (Select top {2} zxTopicObjectiveId from zx_TopicObjective where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_TopicObjective where {1} and zxTopicObjectiveId not in (Select top {3} zxTopicObjectiveId from zx_TopicObjective where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clszx_TopicObjectiveDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TopicObjectiveDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} zx_TopicObjective.* from zx_TopicObjective Left Join {1} on {2} where {3} and zx_TopicObjective.zxTopicObjectiveId not in (Select top {5} zx_TopicObjective.zxTopicObjectiveId from zx_TopicObjective Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_TopicObjective where {1} and zxTopicObjectiveId not in (Select top {2} zxTopicObjectiveId from zx_TopicObjective where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_TopicObjective where {1} and zxTopicObjectiveId not in (Select top {3} zxTopicObjectiveId from zx_TopicObjective where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clszx_TopicObjectiveEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clszx_TopicObjectiveDA:GetObjLst)", objException.Message));
}
List<clszx_TopicObjectiveEN> arrObjLst = new List<clszx_TopicObjectiveEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TopicObjectiveDA.GetSpecSQLObj();
strSQL = "Select * from zx_TopicObjective where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TopicObjectiveEN objzx_TopicObjectiveEN = new clszx_TopicObjectiveEN();
try
{
objzx_TopicObjectiveEN.zxTopicObjectiveId = objRow[conzx_TopicObjective.zxTopicObjectiveId].ToString().Trim(); //客观Id
objzx_TopicObjectiveEN.ObjectiveName = objRow[conzx_TopicObjective.ObjectiveName] == DBNull.Value ? null : objRow[conzx_TopicObjective.ObjectiveName].ToString().Trim(); //客观名称
objzx_TopicObjectiveEN.ObjectiveContent = objRow[conzx_TopicObjective.ObjectiveContent] == DBNull.Value ? null : objRow[conzx_TopicObjective.ObjectiveContent].ToString().Trim(); //客观内容
objzx_TopicObjectiveEN.ObjectiveType = objRow[conzx_TopicObjective.ObjectiveType] == DBNull.Value ? null : objRow[conzx_TopicObjective.ObjectiveType].ToString().Trim(); //客观类型
objzx_TopicObjectiveEN.Conclusion = objRow[conzx_TopicObjective.Conclusion] == DBNull.Value ? null : objRow[conzx_TopicObjective.Conclusion].ToString().Trim(); //结论
objzx_TopicObjectiveEN.TextId = objRow[conzx_TopicObjective.TextId] == DBNull.Value ? null : objRow[conzx_TopicObjective.TextId].ToString().Trim(); //课件Id
objzx_TopicObjectiveEN.IsSubmit = TransNullToBool(objRow[conzx_TopicObjective.IsSubmit].ToString().Trim()); //是否提交
objzx_TopicObjectiveEN.VoteCount = objRow[conzx_TopicObjective.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TopicObjective.VoteCount].ToString().Trim()); //点赞计数
objzx_TopicObjectiveEN.AppraiseCount = objRow[conzx_TopicObjective.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TopicObjective.AppraiseCount].ToString().Trim()); //评论数
objzx_TopicObjectiveEN.Score = objRow[conzx_TopicObjective.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_TopicObjective.Score].ToString().Trim()); //评分
objzx_TopicObjectiveEN.StuScore = objRow[conzx_TopicObjective.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_TopicObjective.StuScore].ToString().Trim()); //学生平均分
objzx_TopicObjectiveEN.TeaScore = objRow[conzx_TopicObjective.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_TopicObjective.TeaScore].ToString().Trim()); //教师评分
objzx_TopicObjectiveEN.IdCurrEduCls = objRow[conzx_TopicObjective.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_TopicObjective.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TopicObjectiveEN.PdfContent = objRow[conzx_TopicObjective.PdfContent] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfContent].ToString().Trim(); //Pdf内容
objzx_TopicObjectiveEN.PdfPageNum = objRow[conzx_TopicObjective.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TopicObjective.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_TopicObjectiveEN.CitationCount = objRow[conzx_TopicObjective.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TopicObjective.CitationCount].ToString().Trim()); //引用统计
objzx_TopicObjectiveEN.VersionCount = objRow[conzx_TopicObjective.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TopicObjective.VersionCount].ToString().Trim()); //版本统计
objzx_TopicObjectiveEN.zxShareId = objRow[conzx_TopicObjective.zxShareId] == DBNull.Value ? null : objRow[conzx_TopicObjective.zxShareId].ToString().Trim(); //分享Id
objzx_TopicObjectiveEN.CreateDate = objRow[conzx_TopicObjective.CreateDate] == DBNull.Value ? null : objRow[conzx_TopicObjective.CreateDate].ToString().Trim(); //建立日期
objzx_TopicObjectiveEN.UpdDate = objRow[conzx_TopicObjective.UpdDate] == DBNull.Value ? null : objRow[conzx_TopicObjective.UpdDate].ToString().Trim(); //修改日期
objzx_TopicObjectiveEN.UpdUser = objRow[conzx_TopicObjective.UpdUser] == DBNull.Value ? null : objRow[conzx_TopicObjective.UpdUser].ToString().Trim(); //修改人
objzx_TopicObjectiveEN.Memo = objRow[conzx_TopicObjective.Memo] == DBNull.Value ? null : objRow[conzx_TopicObjective.Memo].ToString().Trim(); //备注
objzx_TopicObjectiveEN.PdfDivLet = objRow[conzx_TopicObjective.PdfDivLet] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_TopicObjectiveEN.PdfDivTop = objRow[conzx_TopicObjective.PdfDivTop] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_TopicObjectiveEN.PdfPageNumIn = objRow[conzx_TopicObjective.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_TopicObjectiveEN.PdfPageTop = objRow[conzx_TopicObjective.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TopicObjective.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_TopicObjectiveEN.PdfZoom = objRow[conzx_TopicObjective.PdfZoom] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfZoom].ToString().Trim(); //PdfZoom
objzx_TopicObjectiveEN.GroupTextId = objRow[conzx_TopicObjective.GroupTextId] == DBNull.Value ? null : objRow[conzx_TopicObjective.GroupTextId].ToString().Trim(); //小组Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clszx_TopicObjectiveDA: GetObjLst)", objException.Message));
}
objzx_TopicObjectiveEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objzx_TopicObjectiveEN);
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
public List<clszx_TopicObjectiveEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clszx_TopicObjectiveDA:GetObjLstByTabName)", objException.Message));
}
List<clszx_TopicObjectiveEN> arrObjLst = new List<clszx_TopicObjectiveEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TopicObjectiveDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TopicObjectiveEN objzx_TopicObjectiveEN = new clszx_TopicObjectiveEN();
try
{
objzx_TopicObjectiveEN.zxTopicObjectiveId = objRow[conzx_TopicObjective.zxTopicObjectiveId].ToString().Trim(); //客观Id
objzx_TopicObjectiveEN.ObjectiveName = objRow[conzx_TopicObjective.ObjectiveName] == DBNull.Value ? null : objRow[conzx_TopicObjective.ObjectiveName].ToString().Trim(); //客观名称
objzx_TopicObjectiveEN.ObjectiveContent = objRow[conzx_TopicObjective.ObjectiveContent] == DBNull.Value ? null : objRow[conzx_TopicObjective.ObjectiveContent].ToString().Trim(); //客观内容
objzx_TopicObjectiveEN.ObjectiveType = objRow[conzx_TopicObjective.ObjectiveType] == DBNull.Value ? null : objRow[conzx_TopicObjective.ObjectiveType].ToString().Trim(); //客观类型
objzx_TopicObjectiveEN.Conclusion = objRow[conzx_TopicObjective.Conclusion] == DBNull.Value ? null : objRow[conzx_TopicObjective.Conclusion].ToString().Trim(); //结论
objzx_TopicObjectiveEN.TextId = objRow[conzx_TopicObjective.TextId] == DBNull.Value ? null : objRow[conzx_TopicObjective.TextId].ToString().Trim(); //课件Id
objzx_TopicObjectiveEN.IsSubmit = TransNullToBool(objRow[conzx_TopicObjective.IsSubmit].ToString().Trim()); //是否提交
objzx_TopicObjectiveEN.VoteCount = objRow[conzx_TopicObjective.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TopicObjective.VoteCount].ToString().Trim()); //点赞计数
objzx_TopicObjectiveEN.AppraiseCount = objRow[conzx_TopicObjective.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TopicObjective.AppraiseCount].ToString().Trim()); //评论数
objzx_TopicObjectiveEN.Score = objRow[conzx_TopicObjective.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_TopicObjective.Score].ToString().Trim()); //评分
objzx_TopicObjectiveEN.StuScore = objRow[conzx_TopicObjective.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_TopicObjective.StuScore].ToString().Trim()); //学生平均分
objzx_TopicObjectiveEN.TeaScore = objRow[conzx_TopicObjective.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_TopicObjective.TeaScore].ToString().Trim()); //教师评分
objzx_TopicObjectiveEN.IdCurrEduCls = objRow[conzx_TopicObjective.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_TopicObjective.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TopicObjectiveEN.PdfContent = objRow[conzx_TopicObjective.PdfContent] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfContent].ToString().Trim(); //Pdf内容
objzx_TopicObjectiveEN.PdfPageNum = objRow[conzx_TopicObjective.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TopicObjective.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_TopicObjectiveEN.CitationCount = objRow[conzx_TopicObjective.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TopicObjective.CitationCount].ToString().Trim()); //引用统计
objzx_TopicObjectiveEN.VersionCount = objRow[conzx_TopicObjective.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TopicObjective.VersionCount].ToString().Trim()); //版本统计
objzx_TopicObjectiveEN.zxShareId = objRow[conzx_TopicObjective.zxShareId] == DBNull.Value ? null : objRow[conzx_TopicObjective.zxShareId].ToString().Trim(); //分享Id
objzx_TopicObjectiveEN.CreateDate = objRow[conzx_TopicObjective.CreateDate] == DBNull.Value ? null : objRow[conzx_TopicObjective.CreateDate].ToString().Trim(); //建立日期
objzx_TopicObjectiveEN.UpdDate = objRow[conzx_TopicObjective.UpdDate] == DBNull.Value ? null : objRow[conzx_TopicObjective.UpdDate].ToString().Trim(); //修改日期
objzx_TopicObjectiveEN.UpdUser = objRow[conzx_TopicObjective.UpdUser] == DBNull.Value ? null : objRow[conzx_TopicObjective.UpdUser].ToString().Trim(); //修改人
objzx_TopicObjectiveEN.Memo = objRow[conzx_TopicObjective.Memo] == DBNull.Value ? null : objRow[conzx_TopicObjective.Memo].ToString().Trim(); //备注
objzx_TopicObjectiveEN.PdfDivLet = objRow[conzx_TopicObjective.PdfDivLet] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_TopicObjectiveEN.PdfDivTop = objRow[conzx_TopicObjective.PdfDivTop] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_TopicObjectiveEN.PdfPageNumIn = objRow[conzx_TopicObjective.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_TopicObjectiveEN.PdfPageTop = objRow[conzx_TopicObjective.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TopicObjective.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_TopicObjectiveEN.PdfZoom = objRow[conzx_TopicObjective.PdfZoom] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfZoom].ToString().Trim(); //PdfZoom
objzx_TopicObjectiveEN.GroupTextId = objRow[conzx_TopicObjective.GroupTextId] == DBNull.Value ? null : objRow[conzx_TopicObjective.GroupTextId].ToString().Trim(); //小组Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clszx_TopicObjectiveDA: GetObjLst)", objException.Message));
}
objzx_TopicObjectiveEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objzx_TopicObjectiveEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getzx_TopicObjective(ref clszx_TopicObjectiveEN objzx_TopicObjectiveEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TopicObjectiveDA.GetSpecSQLObj();
strSQL = "Select * from zx_TopicObjective where zxTopicObjectiveId = " + "'"+ objzx_TopicObjectiveEN.zxTopicObjectiveId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objzx_TopicObjectiveEN.zxTopicObjectiveId = objDT.Rows[0][conzx_TopicObjective.zxTopicObjectiveId].ToString().Trim(); //客观Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_TopicObjectiveEN.ObjectiveName = objDT.Rows[0][conzx_TopicObjective.ObjectiveName].ToString().Trim(); //客观名称(字段类型:varchar,字段长度:500,是否可空:True)
 objzx_TopicObjectiveEN.ObjectiveContent = objDT.Rows[0][conzx_TopicObjective.ObjectiveContent].ToString().Trim(); //客观内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objzx_TopicObjectiveEN.ObjectiveType = objDT.Rows[0][conzx_TopicObjective.ObjectiveType].ToString().Trim(); //客观类型(字段类型:char,字段长度:2,是否可空:True)
 objzx_TopicObjectiveEN.Conclusion = objDT.Rows[0][conzx_TopicObjective.Conclusion].ToString().Trim(); //结论(字段类型:text,字段长度:2147483647,是否可空:True)
 objzx_TopicObjectiveEN.TextId = objDT.Rows[0][conzx_TopicObjective.TextId].ToString().Trim(); //课件Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_TopicObjectiveEN.IsSubmit = TransNullToBool(objDT.Rows[0][conzx_TopicObjective.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objzx_TopicObjectiveEN.VoteCount = TransNullToInt(objDT.Rows[0][conzx_TopicObjective.VoteCount].ToString().Trim()); //点赞计数(字段类型:int,字段长度:4,是否可空:True)
 objzx_TopicObjectiveEN.AppraiseCount = TransNullToInt(objDT.Rows[0][conzx_TopicObjective.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objzx_TopicObjectiveEN.Score = TransNullToFloat(objDT.Rows[0][conzx_TopicObjective.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objzx_TopicObjectiveEN.StuScore = TransNullToFloat(objDT.Rows[0][conzx_TopicObjective.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objzx_TopicObjectiveEN.TeaScore = TransNullToFloat(objDT.Rows[0][conzx_TopicObjective.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objzx_TopicObjectiveEN.IdCurrEduCls = objDT.Rows[0][conzx_TopicObjective.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objzx_TopicObjectiveEN.PdfContent = objDT.Rows[0][conzx_TopicObjective.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objzx_TopicObjectiveEN.PdfPageNum = TransNullToInt(objDT.Rows[0][conzx_TopicObjective.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objzx_TopicObjectiveEN.CitationCount = TransNullToInt(objDT.Rows[0][conzx_TopicObjective.CitationCount].ToString().Trim()); //引用统计(字段类型:int,字段长度:4,是否可空:True)
 objzx_TopicObjectiveEN.VersionCount = TransNullToInt(objDT.Rows[0][conzx_TopicObjective.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objzx_TopicObjectiveEN.zxShareId = objDT.Rows[0][conzx_TopicObjective.zxShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objzx_TopicObjectiveEN.CreateDate = objDT.Rows[0][conzx_TopicObjective.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_TopicObjectiveEN.UpdDate = objDT.Rows[0][conzx_TopicObjective.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_TopicObjectiveEN.UpdUser = objDT.Rows[0][conzx_TopicObjective.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_TopicObjectiveEN.Memo = objDT.Rows[0][conzx_TopicObjective.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_TopicObjectiveEN.PdfDivLet = objDT.Rows[0][conzx_TopicObjective.PdfDivLet].ToString().Trim(); //PdfDivLet(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_TopicObjectiveEN.PdfDivTop = objDT.Rows[0][conzx_TopicObjective.PdfDivTop].ToString().Trim(); //PdfDivTop(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_TopicObjectiveEN.PdfPageNumIn = objDT.Rows[0][conzx_TopicObjective.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_TopicObjectiveEN.PdfPageTop = TransNullToInt(objDT.Rows[0][conzx_TopicObjective.PdfPageTop].ToString().Trim()); //pdf页面顶部位置(字段类型:int,字段长度:4,是否可空:True)
 objzx_TopicObjectiveEN.PdfZoom = objDT.Rows[0][conzx_TopicObjective.PdfZoom].ToString().Trim(); //PdfZoom(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_TopicObjectiveEN.GroupTextId = objDT.Rows[0][conzx_TopicObjective.GroupTextId].ToString().Trim(); //小组Id(字段类型:char,字段长度:8,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clszx_TopicObjectiveDA: Getzx_TopicObjective)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strzxTopicObjectiveId">表关键字</param>
 /// <returns>表对象</returns>
public clszx_TopicObjectiveEN GetObjByzxTopicObjectiveId(string strzxTopicObjectiveId)
{
CheckPrimaryKey(strzxTopicObjectiveId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TopicObjectiveDA.GetSpecSQLObj();
strSQL = "Select * from zx_TopicObjective where zxTopicObjectiveId = " + "'"+ strzxTopicObjectiveId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clszx_TopicObjectiveEN objzx_TopicObjectiveEN = new clszx_TopicObjectiveEN();
try
{
 objzx_TopicObjectiveEN.zxTopicObjectiveId = objRow[conzx_TopicObjective.zxTopicObjectiveId].ToString().Trim(); //客观Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_TopicObjectiveEN.ObjectiveName = objRow[conzx_TopicObjective.ObjectiveName] == DBNull.Value ? null : objRow[conzx_TopicObjective.ObjectiveName].ToString().Trim(); //客观名称(字段类型:varchar,字段长度:500,是否可空:True)
 objzx_TopicObjectiveEN.ObjectiveContent = objRow[conzx_TopicObjective.ObjectiveContent] == DBNull.Value ? null : objRow[conzx_TopicObjective.ObjectiveContent].ToString().Trim(); //客观内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objzx_TopicObjectiveEN.ObjectiveType = objRow[conzx_TopicObjective.ObjectiveType] == DBNull.Value ? null : objRow[conzx_TopicObjective.ObjectiveType].ToString().Trim(); //客观类型(字段类型:char,字段长度:2,是否可空:True)
 objzx_TopicObjectiveEN.Conclusion = objRow[conzx_TopicObjective.Conclusion] == DBNull.Value ? null : objRow[conzx_TopicObjective.Conclusion].ToString().Trim(); //结论(字段类型:text,字段长度:2147483647,是否可空:True)
 objzx_TopicObjectiveEN.TextId = objRow[conzx_TopicObjective.TextId] == DBNull.Value ? null : objRow[conzx_TopicObjective.TextId].ToString().Trim(); //课件Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_TopicObjectiveEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_TopicObjective.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objzx_TopicObjectiveEN.VoteCount = objRow[conzx_TopicObjective.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjective.VoteCount].ToString().Trim()); //点赞计数(字段类型:int,字段长度:4,是否可空:True)
 objzx_TopicObjectiveEN.AppraiseCount = objRow[conzx_TopicObjective.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjective.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objzx_TopicObjectiveEN.Score = objRow[conzx_TopicObjective.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TopicObjective.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objzx_TopicObjectiveEN.StuScore = objRow[conzx_TopicObjective.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TopicObjective.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objzx_TopicObjectiveEN.TeaScore = objRow[conzx_TopicObjective.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TopicObjective.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objzx_TopicObjectiveEN.IdCurrEduCls = objRow[conzx_TopicObjective.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_TopicObjective.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objzx_TopicObjectiveEN.PdfContent = objRow[conzx_TopicObjective.PdfContent] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objzx_TopicObjectiveEN.PdfPageNum = objRow[conzx_TopicObjective.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjective.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objzx_TopicObjectiveEN.CitationCount = objRow[conzx_TopicObjective.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjective.CitationCount].ToString().Trim()); //引用统计(字段类型:int,字段长度:4,是否可空:True)
 objzx_TopicObjectiveEN.VersionCount = objRow[conzx_TopicObjective.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjective.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objzx_TopicObjectiveEN.zxShareId = objRow[conzx_TopicObjective.zxShareId] == DBNull.Value ? null : objRow[conzx_TopicObjective.zxShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objzx_TopicObjectiveEN.CreateDate = objRow[conzx_TopicObjective.CreateDate] == DBNull.Value ? null : objRow[conzx_TopicObjective.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_TopicObjectiveEN.UpdDate = objRow[conzx_TopicObjective.UpdDate] == DBNull.Value ? null : objRow[conzx_TopicObjective.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_TopicObjectiveEN.UpdUser = objRow[conzx_TopicObjective.UpdUser] == DBNull.Value ? null : objRow[conzx_TopicObjective.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_TopicObjectiveEN.Memo = objRow[conzx_TopicObjective.Memo] == DBNull.Value ? null : objRow[conzx_TopicObjective.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_TopicObjectiveEN.PdfDivLet = objRow[conzx_TopicObjective.PdfDivLet] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfDivLet].ToString().Trim(); //PdfDivLet(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_TopicObjectiveEN.PdfDivTop = objRow[conzx_TopicObjective.PdfDivTop] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfDivTop].ToString().Trim(); //PdfDivTop(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_TopicObjectiveEN.PdfPageNumIn = objRow[conzx_TopicObjective.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_TopicObjectiveEN.PdfPageTop = objRow[conzx_TopicObjective.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjective.PdfPageTop].ToString().Trim()); //pdf页面顶部位置(字段类型:int,字段长度:4,是否可空:True)
 objzx_TopicObjectiveEN.PdfZoom = objRow[conzx_TopicObjective.PdfZoom] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfZoom].ToString().Trim(); //PdfZoom(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_TopicObjectiveEN.GroupTextId = objRow[conzx_TopicObjective.GroupTextId] == DBNull.Value ? null : objRow[conzx_TopicObjective.GroupTextId].ToString().Trim(); //小组Id(字段类型:char,字段长度:8,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clszx_TopicObjectiveDA: GetObjByzxTopicObjectiveId)", objException.Message));
}
return objzx_TopicObjectiveEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clszx_TopicObjectiveEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clszx_TopicObjectiveDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TopicObjectiveDA.GetSpecSQLObj();
strSQL = "Select * from zx_TopicObjective where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clszx_TopicObjectiveEN objzx_TopicObjectiveEN = new clszx_TopicObjectiveEN()
{
zxTopicObjectiveId = objRow[conzx_TopicObjective.zxTopicObjectiveId].ToString().Trim(), //客观Id
ObjectiveName = objRow[conzx_TopicObjective.ObjectiveName] == DBNull.Value ? null : objRow[conzx_TopicObjective.ObjectiveName].ToString().Trim(), //客观名称
ObjectiveContent = objRow[conzx_TopicObjective.ObjectiveContent] == DBNull.Value ? null : objRow[conzx_TopicObjective.ObjectiveContent].ToString().Trim(), //客观内容
ObjectiveType = objRow[conzx_TopicObjective.ObjectiveType] == DBNull.Value ? null : objRow[conzx_TopicObjective.ObjectiveType].ToString().Trim(), //客观类型
Conclusion = objRow[conzx_TopicObjective.Conclusion] == DBNull.Value ? null : objRow[conzx_TopicObjective.Conclusion].ToString().Trim(), //结论
TextId = objRow[conzx_TopicObjective.TextId] == DBNull.Value ? null : objRow[conzx_TopicObjective.TextId].ToString().Trim(), //课件Id
IsSubmit = TransNullToBool(objRow[conzx_TopicObjective.IsSubmit].ToString().Trim()), //是否提交
VoteCount = objRow[conzx_TopicObjective.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TopicObjective.VoteCount].ToString().Trim()), //点赞计数
AppraiseCount = objRow[conzx_TopicObjective.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TopicObjective.AppraiseCount].ToString().Trim()), //评论数
Score = objRow[conzx_TopicObjective.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_TopicObjective.Score].ToString().Trim()), //评分
StuScore = objRow[conzx_TopicObjective.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_TopicObjective.StuScore].ToString().Trim()), //学生平均分
TeaScore = objRow[conzx_TopicObjective.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_TopicObjective.TeaScore].ToString().Trim()), //教师评分
IdCurrEduCls = objRow[conzx_TopicObjective.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_TopicObjective.IdCurrEduCls].ToString().Trim(), //教学班流水号
PdfContent = objRow[conzx_TopicObjective.PdfContent] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfContent].ToString().Trim(), //Pdf内容
PdfPageNum = objRow[conzx_TopicObjective.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TopicObjective.PdfPageNum].ToString().Trim()), //Pdf页码
CitationCount = objRow[conzx_TopicObjective.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TopicObjective.CitationCount].ToString().Trim()), //引用统计
VersionCount = objRow[conzx_TopicObjective.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TopicObjective.VersionCount].ToString().Trim()), //版本统计
zxShareId = objRow[conzx_TopicObjective.zxShareId] == DBNull.Value ? null : objRow[conzx_TopicObjective.zxShareId].ToString().Trim(), //分享Id
CreateDate = objRow[conzx_TopicObjective.CreateDate] == DBNull.Value ? null : objRow[conzx_TopicObjective.CreateDate].ToString().Trim(), //建立日期
UpdDate = objRow[conzx_TopicObjective.UpdDate] == DBNull.Value ? null : objRow[conzx_TopicObjective.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conzx_TopicObjective.UpdUser] == DBNull.Value ? null : objRow[conzx_TopicObjective.UpdUser].ToString().Trim(), //修改人
Memo = objRow[conzx_TopicObjective.Memo] == DBNull.Value ? null : objRow[conzx_TopicObjective.Memo].ToString().Trim(), //备注
PdfDivLet = objRow[conzx_TopicObjective.PdfDivLet] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfDivLet].ToString().Trim(), //PdfDivLet
PdfDivTop = objRow[conzx_TopicObjective.PdfDivTop] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfDivTop].ToString().Trim(), //PdfDivTop
PdfPageNumIn = objRow[conzx_TopicObjective.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfPageNumIn].ToString().Trim(), //PdfPageNumIn
PdfPageTop = objRow[conzx_TopicObjective.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TopicObjective.PdfPageTop].ToString().Trim()), //pdf页面顶部位置
PdfZoom = objRow[conzx_TopicObjective.PdfZoom] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfZoom].ToString().Trim(), //PdfZoom
GroupTextId = objRow[conzx_TopicObjective.GroupTextId] == DBNull.Value ? null : objRow[conzx_TopicObjective.GroupTextId].ToString().Trim() //小组Id
};
objzx_TopicObjectiveEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_TopicObjectiveEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clszx_TopicObjectiveDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clszx_TopicObjectiveEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clszx_TopicObjectiveEN objzx_TopicObjectiveEN = new clszx_TopicObjectiveEN();
try
{
objzx_TopicObjectiveEN.zxTopicObjectiveId = objRow[conzx_TopicObjective.zxTopicObjectiveId].ToString().Trim(); //客观Id
objzx_TopicObjectiveEN.ObjectiveName = objRow[conzx_TopicObjective.ObjectiveName] == DBNull.Value ? null : objRow[conzx_TopicObjective.ObjectiveName].ToString().Trim(); //客观名称
objzx_TopicObjectiveEN.ObjectiveContent = objRow[conzx_TopicObjective.ObjectiveContent] == DBNull.Value ? null : objRow[conzx_TopicObjective.ObjectiveContent].ToString().Trim(); //客观内容
objzx_TopicObjectiveEN.ObjectiveType = objRow[conzx_TopicObjective.ObjectiveType] == DBNull.Value ? null : objRow[conzx_TopicObjective.ObjectiveType].ToString().Trim(); //客观类型
objzx_TopicObjectiveEN.Conclusion = objRow[conzx_TopicObjective.Conclusion] == DBNull.Value ? null : objRow[conzx_TopicObjective.Conclusion].ToString().Trim(); //结论
objzx_TopicObjectiveEN.TextId = objRow[conzx_TopicObjective.TextId] == DBNull.Value ? null : objRow[conzx_TopicObjective.TextId].ToString().Trim(); //课件Id
objzx_TopicObjectiveEN.IsSubmit = TransNullToBool(objRow[conzx_TopicObjective.IsSubmit].ToString().Trim()); //是否提交
objzx_TopicObjectiveEN.VoteCount = objRow[conzx_TopicObjective.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TopicObjective.VoteCount].ToString().Trim()); //点赞计数
objzx_TopicObjectiveEN.AppraiseCount = objRow[conzx_TopicObjective.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TopicObjective.AppraiseCount].ToString().Trim()); //评论数
objzx_TopicObjectiveEN.Score = objRow[conzx_TopicObjective.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_TopicObjective.Score].ToString().Trim()); //评分
objzx_TopicObjectiveEN.StuScore = objRow[conzx_TopicObjective.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_TopicObjective.StuScore].ToString().Trim()); //学生平均分
objzx_TopicObjectiveEN.TeaScore = objRow[conzx_TopicObjective.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_TopicObjective.TeaScore].ToString().Trim()); //教师评分
objzx_TopicObjectiveEN.IdCurrEduCls = objRow[conzx_TopicObjective.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_TopicObjective.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TopicObjectiveEN.PdfContent = objRow[conzx_TopicObjective.PdfContent] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfContent].ToString().Trim(); //Pdf内容
objzx_TopicObjectiveEN.PdfPageNum = objRow[conzx_TopicObjective.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TopicObjective.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_TopicObjectiveEN.CitationCount = objRow[conzx_TopicObjective.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TopicObjective.CitationCount].ToString().Trim()); //引用统计
objzx_TopicObjectiveEN.VersionCount = objRow[conzx_TopicObjective.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TopicObjective.VersionCount].ToString().Trim()); //版本统计
objzx_TopicObjectiveEN.zxShareId = objRow[conzx_TopicObjective.zxShareId] == DBNull.Value ? null : objRow[conzx_TopicObjective.zxShareId].ToString().Trim(); //分享Id
objzx_TopicObjectiveEN.CreateDate = objRow[conzx_TopicObjective.CreateDate] == DBNull.Value ? null : objRow[conzx_TopicObjective.CreateDate].ToString().Trim(); //建立日期
objzx_TopicObjectiveEN.UpdDate = objRow[conzx_TopicObjective.UpdDate] == DBNull.Value ? null : objRow[conzx_TopicObjective.UpdDate].ToString().Trim(); //修改日期
objzx_TopicObjectiveEN.UpdUser = objRow[conzx_TopicObjective.UpdUser] == DBNull.Value ? null : objRow[conzx_TopicObjective.UpdUser].ToString().Trim(); //修改人
objzx_TopicObjectiveEN.Memo = objRow[conzx_TopicObjective.Memo] == DBNull.Value ? null : objRow[conzx_TopicObjective.Memo].ToString().Trim(); //备注
objzx_TopicObjectiveEN.PdfDivLet = objRow[conzx_TopicObjective.PdfDivLet] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_TopicObjectiveEN.PdfDivTop = objRow[conzx_TopicObjective.PdfDivTop] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_TopicObjectiveEN.PdfPageNumIn = objRow[conzx_TopicObjective.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_TopicObjectiveEN.PdfPageTop = objRow[conzx_TopicObjective.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TopicObjective.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_TopicObjectiveEN.PdfZoom = objRow[conzx_TopicObjective.PdfZoom] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfZoom].ToString().Trim(); //PdfZoom
objzx_TopicObjectiveEN.GroupTextId = objRow[conzx_TopicObjective.GroupTextId] == DBNull.Value ? null : objRow[conzx_TopicObjective.GroupTextId].ToString().Trim(); //小组Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clszx_TopicObjectiveDA: GetObjByDataRowzx_TopicObjective)", objException.Message));
}
objzx_TopicObjectiveEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_TopicObjectiveEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clszx_TopicObjectiveEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clszx_TopicObjectiveEN objzx_TopicObjectiveEN = new clszx_TopicObjectiveEN();
try
{
objzx_TopicObjectiveEN.zxTopicObjectiveId = objRow[conzx_TopicObjective.zxTopicObjectiveId].ToString().Trim(); //客观Id
objzx_TopicObjectiveEN.ObjectiveName = objRow[conzx_TopicObjective.ObjectiveName] == DBNull.Value ? null : objRow[conzx_TopicObjective.ObjectiveName].ToString().Trim(); //客观名称
objzx_TopicObjectiveEN.ObjectiveContent = objRow[conzx_TopicObjective.ObjectiveContent] == DBNull.Value ? null : objRow[conzx_TopicObjective.ObjectiveContent].ToString().Trim(); //客观内容
objzx_TopicObjectiveEN.ObjectiveType = objRow[conzx_TopicObjective.ObjectiveType] == DBNull.Value ? null : objRow[conzx_TopicObjective.ObjectiveType].ToString().Trim(); //客观类型
objzx_TopicObjectiveEN.Conclusion = objRow[conzx_TopicObjective.Conclusion] == DBNull.Value ? null : objRow[conzx_TopicObjective.Conclusion].ToString().Trim(); //结论
objzx_TopicObjectiveEN.TextId = objRow[conzx_TopicObjective.TextId] == DBNull.Value ? null : objRow[conzx_TopicObjective.TextId].ToString().Trim(); //课件Id
objzx_TopicObjectiveEN.IsSubmit = TransNullToBool(objRow[conzx_TopicObjective.IsSubmit].ToString().Trim()); //是否提交
objzx_TopicObjectiveEN.VoteCount = objRow[conzx_TopicObjective.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TopicObjective.VoteCount].ToString().Trim()); //点赞计数
objzx_TopicObjectiveEN.AppraiseCount = objRow[conzx_TopicObjective.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TopicObjective.AppraiseCount].ToString().Trim()); //评论数
objzx_TopicObjectiveEN.Score = objRow[conzx_TopicObjective.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_TopicObjective.Score].ToString().Trim()); //评分
objzx_TopicObjectiveEN.StuScore = objRow[conzx_TopicObjective.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_TopicObjective.StuScore].ToString().Trim()); //学生平均分
objzx_TopicObjectiveEN.TeaScore = objRow[conzx_TopicObjective.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_TopicObjective.TeaScore].ToString().Trim()); //教师评分
objzx_TopicObjectiveEN.IdCurrEduCls = objRow[conzx_TopicObjective.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_TopicObjective.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TopicObjectiveEN.PdfContent = objRow[conzx_TopicObjective.PdfContent] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfContent].ToString().Trim(); //Pdf内容
objzx_TopicObjectiveEN.PdfPageNum = objRow[conzx_TopicObjective.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TopicObjective.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_TopicObjectiveEN.CitationCount = objRow[conzx_TopicObjective.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TopicObjective.CitationCount].ToString().Trim()); //引用统计
objzx_TopicObjectiveEN.VersionCount = objRow[conzx_TopicObjective.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TopicObjective.VersionCount].ToString().Trim()); //版本统计
objzx_TopicObjectiveEN.zxShareId = objRow[conzx_TopicObjective.zxShareId] == DBNull.Value ? null : objRow[conzx_TopicObjective.zxShareId].ToString().Trim(); //分享Id
objzx_TopicObjectiveEN.CreateDate = objRow[conzx_TopicObjective.CreateDate] == DBNull.Value ? null : objRow[conzx_TopicObjective.CreateDate].ToString().Trim(); //建立日期
objzx_TopicObjectiveEN.UpdDate = objRow[conzx_TopicObjective.UpdDate] == DBNull.Value ? null : objRow[conzx_TopicObjective.UpdDate].ToString().Trim(); //修改日期
objzx_TopicObjectiveEN.UpdUser = objRow[conzx_TopicObjective.UpdUser] == DBNull.Value ? null : objRow[conzx_TopicObjective.UpdUser].ToString().Trim(); //修改人
objzx_TopicObjectiveEN.Memo = objRow[conzx_TopicObjective.Memo] == DBNull.Value ? null : objRow[conzx_TopicObjective.Memo].ToString().Trim(); //备注
objzx_TopicObjectiveEN.PdfDivLet = objRow[conzx_TopicObjective.PdfDivLet] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_TopicObjectiveEN.PdfDivTop = objRow[conzx_TopicObjective.PdfDivTop] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_TopicObjectiveEN.PdfPageNumIn = objRow[conzx_TopicObjective.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_TopicObjectiveEN.PdfPageTop = objRow[conzx_TopicObjective.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TopicObjective.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_TopicObjectiveEN.PdfZoom = objRow[conzx_TopicObjective.PdfZoom] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfZoom].ToString().Trim(); //PdfZoom
objzx_TopicObjectiveEN.GroupTextId = objRow[conzx_TopicObjective.GroupTextId] == DBNull.Value ? null : objRow[conzx_TopicObjective.GroupTextId].ToString().Trim(); //小组Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clszx_TopicObjectiveDA: GetObjByDataRow)", objException.Message));
}
objzx_TopicObjectiveEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_TopicObjectiveEN;
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
objSQL = clszx_TopicObjectiveDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clszx_TopicObjectiveEN._CurrTabName, conzx_TopicObjective.zxTopicObjectiveId, 8, "");
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
objSQL = clszx_TopicObjectiveDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clszx_TopicObjectiveEN._CurrTabName, conzx_TopicObjective.zxTopicObjectiveId, 8, strPrefix);
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
 objSQL = clszx_TopicObjectiveDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select zxTopicObjectiveId from zx_TopicObjective where " + strCondition;
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
 objSQL = clszx_TopicObjectiveDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select zxTopicObjectiveId from zx_TopicObjective where " + strCondition;
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
 objSQL = clszx_TopicObjectiveDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("zx_TopicObjective", "zxTopicObjectiveId = " + "'"+ strzxTopicObjectiveId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clszx_TopicObjectiveDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TopicObjectiveDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("zx_TopicObjective", strCondition))
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
objSQL = clszx_TopicObjectiveDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("zx_TopicObjective");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clszx_TopicObjectiveEN objzx_TopicObjectiveEN)
 {
 if (objzx_TopicObjectiveEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_TopicObjectiveEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TopicObjectiveDA.GetSpecSQLObj();
strSQL = "Select * from zx_TopicObjective where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "zx_TopicObjective");
objRow = objDS.Tables["zx_TopicObjective"].NewRow();
objRow[conzx_TopicObjective.zxTopicObjectiveId] = objzx_TopicObjectiveEN.zxTopicObjectiveId; //客观Id
 if (objzx_TopicObjectiveEN.ObjectiveName !=  "")
 {
objRow[conzx_TopicObjective.ObjectiveName] = objzx_TopicObjectiveEN.ObjectiveName; //客观名称
 }
 if (objzx_TopicObjectiveEN.ObjectiveContent !=  "")
 {
objRow[conzx_TopicObjective.ObjectiveContent] = objzx_TopicObjectiveEN.ObjectiveContent; //客观内容
 }
 if (objzx_TopicObjectiveEN.ObjectiveType !=  "")
 {
objRow[conzx_TopicObjective.ObjectiveType] = objzx_TopicObjectiveEN.ObjectiveType; //客观类型
 }
 if (objzx_TopicObjectiveEN.Conclusion !=  "")
 {
objRow[conzx_TopicObjective.Conclusion] = objzx_TopicObjectiveEN.Conclusion; //结论
 }
 if (objzx_TopicObjectiveEN.TextId !=  "")
 {
objRow[conzx_TopicObjective.TextId] = objzx_TopicObjectiveEN.TextId; //课件Id
 }
objRow[conzx_TopicObjective.IsSubmit] = objzx_TopicObjectiveEN.IsSubmit; //是否提交
objRow[conzx_TopicObjective.VoteCount] = objzx_TopicObjectiveEN.VoteCount; //点赞计数
objRow[conzx_TopicObjective.AppraiseCount] = objzx_TopicObjectiveEN.AppraiseCount; //评论数
objRow[conzx_TopicObjective.Score] = objzx_TopicObjectiveEN.Score; //评分
objRow[conzx_TopicObjective.StuScore] = objzx_TopicObjectiveEN.StuScore; //学生平均分
objRow[conzx_TopicObjective.TeaScore] = objzx_TopicObjectiveEN.TeaScore; //教师评分
 if (objzx_TopicObjectiveEN.IdCurrEduCls !=  "")
 {
objRow[conzx_TopicObjective.IdCurrEduCls] = objzx_TopicObjectiveEN.IdCurrEduCls; //教学班流水号
 }
 if (objzx_TopicObjectiveEN.PdfContent !=  "")
 {
objRow[conzx_TopicObjective.PdfContent] = objzx_TopicObjectiveEN.PdfContent; //Pdf内容
 }
objRow[conzx_TopicObjective.PdfPageNum] = objzx_TopicObjectiveEN.PdfPageNum; //Pdf页码
objRow[conzx_TopicObjective.CitationCount] = objzx_TopicObjectiveEN.CitationCount; //引用统计
objRow[conzx_TopicObjective.VersionCount] = objzx_TopicObjectiveEN.VersionCount; //版本统计
 if (objzx_TopicObjectiveEN.zxShareId !=  "")
 {
objRow[conzx_TopicObjective.zxShareId] = objzx_TopicObjectiveEN.zxShareId; //分享Id
 }
 if (objzx_TopicObjectiveEN.CreateDate !=  "")
 {
objRow[conzx_TopicObjective.CreateDate] = objzx_TopicObjectiveEN.CreateDate; //建立日期
 }
 if (objzx_TopicObjectiveEN.UpdDate !=  "")
 {
objRow[conzx_TopicObjective.UpdDate] = objzx_TopicObjectiveEN.UpdDate; //修改日期
 }
 if (objzx_TopicObjectiveEN.UpdUser !=  "")
 {
objRow[conzx_TopicObjective.UpdUser] = objzx_TopicObjectiveEN.UpdUser; //修改人
 }
 if (objzx_TopicObjectiveEN.Memo !=  "")
 {
objRow[conzx_TopicObjective.Memo] = objzx_TopicObjectiveEN.Memo; //备注
 }
 if (objzx_TopicObjectiveEN.PdfDivLet !=  "")
 {
objRow[conzx_TopicObjective.PdfDivLet] = objzx_TopicObjectiveEN.PdfDivLet; //PdfDivLet
 }
 if (objzx_TopicObjectiveEN.PdfDivTop !=  "")
 {
objRow[conzx_TopicObjective.PdfDivTop] = objzx_TopicObjectiveEN.PdfDivTop; //PdfDivTop
 }
 if (objzx_TopicObjectiveEN.PdfPageNumIn !=  "")
 {
objRow[conzx_TopicObjective.PdfPageNumIn] = objzx_TopicObjectiveEN.PdfPageNumIn; //PdfPageNumIn
 }
objRow[conzx_TopicObjective.PdfPageTop] = objzx_TopicObjectiveEN.PdfPageTop; //pdf页面顶部位置
 if (objzx_TopicObjectiveEN.PdfZoom !=  "")
 {
objRow[conzx_TopicObjective.PdfZoom] = objzx_TopicObjectiveEN.PdfZoom; //PdfZoom
 }
 if (objzx_TopicObjectiveEN.GroupTextId !=  "")
 {
objRow[conzx_TopicObjective.GroupTextId] = objzx_TopicObjectiveEN.GroupTextId; //小组Id
 }
objDS.Tables[clszx_TopicObjectiveEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clszx_TopicObjectiveEN._CurrTabName);
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
 /// <param name = "objzx_TopicObjectiveEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clszx_TopicObjectiveEN objzx_TopicObjectiveEN)
{
 if (objzx_TopicObjectiveEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_TopicObjectiveEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_TopicObjectiveEN.zxTopicObjectiveId !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.zxTopicObjectiveId);
 var strzxTopicObjectiveId = objzx_TopicObjectiveEN.zxTopicObjectiveId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxTopicObjectiveId + "'");
 }
 
 if (objzx_TopicObjectiveEN.ObjectiveName !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.ObjectiveName);
 var strObjectiveName = objzx_TopicObjectiveEN.ObjectiveName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strObjectiveName + "'");
 }
 
 if (objzx_TopicObjectiveEN.ObjectiveContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.ObjectiveContent);
 var strObjectiveContent = objzx_TopicObjectiveEN.ObjectiveContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strObjectiveContent + "'");
 }
 
 if (objzx_TopicObjectiveEN.ObjectiveType !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.ObjectiveType);
 var strObjectiveType = objzx_TopicObjectiveEN.ObjectiveType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strObjectiveType + "'");
 }
 
 if (objzx_TopicObjectiveEN.Conclusion !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.Conclusion);
 var strConclusion = objzx_TopicObjectiveEN.Conclusion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConclusion + "'");
 }
 
 if (objzx_TopicObjectiveEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.TextId);
 var strTextId = objzx_TopicObjectiveEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 arrFieldListForInsert.Add(conzx_TopicObjective.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_TopicObjectiveEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_TopicObjectiveEN.VoteCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.VoteCount);
 arrValueListForInsert.Add(objzx_TopicObjectiveEN.VoteCount.ToString());
 }
 
 if (objzx_TopicObjectiveEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.AppraiseCount);
 arrValueListForInsert.Add(objzx_TopicObjectiveEN.AppraiseCount.ToString());
 }
 
 if (objzx_TopicObjectiveEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.Score);
 arrValueListForInsert.Add(objzx_TopicObjectiveEN.Score.ToString());
 }
 
 if (objzx_TopicObjectiveEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.StuScore);
 arrValueListForInsert.Add(objzx_TopicObjectiveEN.StuScore.ToString());
 }
 
 if (objzx_TopicObjectiveEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.TeaScore);
 arrValueListForInsert.Add(objzx_TopicObjectiveEN.TeaScore.ToString());
 }
 
 if (objzx_TopicObjectiveEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.IdCurrEduCls);
 var strIdCurrEduCls = objzx_TopicObjectiveEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objzx_TopicObjectiveEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.PdfContent);
 var strPdfContent = objzx_TopicObjectiveEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objzx_TopicObjectiveEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.PdfPageNum);
 arrValueListForInsert.Add(objzx_TopicObjectiveEN.PdfPageNum.ToString());
 }
 
 if (objzx_TopicObjectiveEN.CitationCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.CitationCount);
 arrValueListForInsert.Add(objzx_TopicObjectiveEN.CitationCount.ToString());
 }
 
 if (objzx_TopicObjectiveEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.VersionCount);
 arrValueListForInsert.Add(objzx_TopicObjectiveEN.VersionCount.ToString());
 }
 
 if (objzx_TopicObjectiveEN.zxShareId !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.zxShareId);
 var strzxShareId = objzx_TopicObjectiveEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxShareId + "'");
 }
 
 if (objzx_TopicObjectiveEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.CreateDate);
 var strCreateDate = objzx_TopicObjectiveEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objzx_TopicObjectiveEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.UpdDate);
 var strUpdDate = objzx_TopicObjectiveEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_TopicObjectiveEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.UpdUser);
 var strUpdUser = objzx_TopicObjectiveEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_TopicObjectiveEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.Memo);
 var strMemo = objzx_TopicObjectiveEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_TopicObjectiveEN.PdfDivLet !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.PdfDivLet);
 var strPdfDivLet = objzx_TopicObjectiveEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivLet + "'");
 }
 
 if (objzx_TopicObjectiveEN.PdfDivTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.PdfDivTop);
 var strPdfDivTop = objzx_TopicObjectiveEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivTop + "'");
 }
 
 if (objzx_TopicObjectiveEN.PdfPageNumIn !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.PdfPageNumIn);
 var strPdfPageNumIn = objzx_TopicObjectiveEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfPageNumIn + "'");
 }
 
 if (objzx_TopicObjectiveEN.PdfPageTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.PdfPageTop);
 arrValueListForInsert.Add(objzx_TopicObjectiveEN.PdfPageTop.ToString());
 }
 
 if (objzx_TopicObjectiveEN.PdfZoom !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.PdfZoom);
 var strPdfZoom = objzx_TopicObjectiveEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfZoom + "'");
 }
 
 if (objzx_TopicObjectiveEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.GroupTextId);
 var strGroupTextId = objzx_TopicObjectiveEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_TopicObjective");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TopicObjectiveDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clszx_TopicObjectiveEN objzx_TopicObjectiveEN)
{
 if (objzx_TopicObjectiveEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_TopicObjectiveEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_TopicObjectiveEN.zxTopicObjectiveId !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.zxTopicObjectiveId);
 var strzxTopicObjectiveId = objzx_TopicObjectiveEN.zxTopicObjectiveId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxTopicObjectiveId + "'");
 }
 
 if (objzx_TopicObjectiveEN.ObjectiveName !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.ObjectiveName);
 var strObjectiveName = objzx_TopicObjectiveEN.ObjectiveName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strObjectiveName + "'");
 }
 
 if (objzx_TopicObjectiveEN.ObjectiveContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.ObjectiveContent);
 var strObjectiveContent = objzx_TopicObjectiveEN.ObjectiveContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strObjectiveContent + "'");
 }
 
 if (objzx_TopicObjectiveEN.ObjectiveType !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.ObjectiveType);
 var strObjectiveType = objzx_TopicObjectiveEN.ObjectiveType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strObjectiveType + "'");
 }
 
 if (objzx_TopicObjectiveEN.Conclusion !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.Conclusion);
 var strConclusion = objzx_TopicObjectiveEN.Conclusion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConclusion + "'");
 }
 
 if (objzx_TopicObjectiveEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.TextId);
 var strTextId = objzx_TopicObjectiveEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 arrFieldListForInsert.Add(conzx_TopicObjective.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_TopicObjectiveEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_TopicObjectiveEN.VoteCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.VoteCount);
 arrValueListForInsert.Add(objzx_TopicObjectiveEN.VoteCount.ToString());
 }
 
 if (objzx_TopicObjectiveEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.AppraiseCount);
 arrValueListForInsert.Add(objzx_TopicObjectiveEN.AppraiseCount.ToString());
 }
 
 if (objzx_TopicObjectiveEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.Score);
 arrValueListForInsert.Add(objzx_TopicObjectiveEN.Score.ToString());
 }
 
 if (objzx_TopicObjectiveEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.StuScore);
 arrValueListForInsert.Add(objzx_TopicObjectiveEN.StuScore.ToString());
 }
 
 if (objzx_TopicObjectiveEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.TeaScore);
 arrValueListForInsert.Add(objzx_TopicObjectiveEN.TeaScore.ToString());
 }
 
 if (objzx_TopicObjectiveEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.IdCurrEduCls);
 var strIdCurrEduCls = objzx_TopicObjectiveEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objzx_TopicObjectiveEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.PdfContent);
 var strPdfContent = objzx_TopicObjectiveEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objzx_TopicObjectiveEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.PdfPageNum);
 arrValueListForInsert.Add(objzx_TopicObjectiveEN.PdfPageNum.ToString());
 }
 
 if (objzx_TopicObjectiveEN.CitationCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.CitationCount);
 arrValueListForInsert.Add(objzx_TopicObjectiveEN.CitationCount.ToString());
 }
 
 if (objzx_TopicObjectiveEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.VersionCount);
 arrValueListForInsert.Add(objzx_TopicObjectiveEN.VersionCount.ToString());
 }
 
 if (objzx_TopicObjectiveEN.zxShareId !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.zxShareId);
 var strzxShareId = objzx_TopicObjectiveEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxShareId + "'");
 }
 
 if (objzx_TopicObjectiveEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.CreateDate);
 var strCreateDate = objzx_TopicObjectiveEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objzx_TopicObjectiveEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.UpdDate);
 var strUpdDate = objzx_TopicObjectiveEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_TopicObjectiveEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.UpdUser);
 var strUpdUser = objzx_TopicObjectiveEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_TopicObjectiveEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.Memo);
 var strMemo = objzx_TopicObjectiveEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_TopicObjectiveEN.PdfDivLet !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.PdfDivLet);
 var strPdfDivLet = objzx_TopicObjectiveEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivLet + "'");
 }
 
 if (objzx_TopicObjectiveEN.PdfDivTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.PdfDivTop);
 var strPdfDivTop = objzx_TopicObjectiveEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivTop + "'");
 }
 
 if (objzx_TopicObjectiveEN.PdfPageNumIn !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.PdfPageNumIn);
 var strPdfPageNumIn = objzx_TopicObjectiveEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfPageNumIn + "'");
 }
 
 if (objzx_TopicObjectiveEN.PdfPageTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.PdfPageTop);
 arrValueListForInsert.Add(objzx_TopicObjectiveEN.PdfPageTop.ToString());
 }
 
 if (objzx_TopicObjectiveEN.PdfZoom !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.PdfZoom);
 var strPdfZoom = objzx_TopicObjectiveEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfZoom + "'");
 }
 
 if (objzx_TopicObjectiveEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.GroupTextId);
 var strGroupTextId = objzx_TopicObjectiveEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_TopicObjective");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TopicObjectiveDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objzx_TopicObjectiveEN.zxTopicObjectiveId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clszx_TopicObjectiveEN objzx_TopicObjectiveEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objzx_TopicObjectiveEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_TopicObjectiveEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_TopicObjectiveEN.zxTopicObjectiveId !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.zxTopicObjectiveId);
 var strzxTopicObjectiveId = objzx_TopicObjectiveEN.zxTopicObjectiveId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxTopicObjectiveId + "'");
 }
 
 if (objzx_TopicObjectiveEN.ObjectiveName !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.ObjectiveName);
 var strObjectiveName = objzx_TopicObjectiveEN.ObjectiveName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strObjectiveName + "'");
 }
 
 if (objzx_TopicObjectiveEN.ObjectiveContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.ObjectiveContent);
 var strObjectiveContent = objzx_TopicObjectiveEN.ObjectiveContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strObjectiveContent + "'");
 }
 
 if (objzx_TopicObjectiveEN.ObjectiveType !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.ObjectiveType);
 var strObjectiveType = objzx_TopicObjectiveEN.ObjectiveType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strObjectiveType + "'");
 }
 
 if (objzx_TopicObjectiveEN.Conclusion !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.Conclusion);
 var strConclusion = objzx_TopicObjectiveEN.Conclusion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConclusion + "'");
 }
 
 if (objzx_TopicObjectiveEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.TextId);
 var strTextId = objzx_TopicObjectiveEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 arrFieldListForInsert.Add(conzx_TopicObjective.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_TopicObjectiveEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_TopicObjectiveEN.VoteCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.VoteCount);
 arrValueListForInsert.Add(objzx_TopicObjectiveEN.VoteCount.ToString());
 }
 
 if (objzx_TopicObjectiveEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.AppraiseCount);
 arrValueListForInsert.Add(objzx_TopicObjectiveEN.AppraiseCount.ToString());
 }
 
 if (objzx_TopicObjectiveEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.Score);
 arrValueListForInsert.Add(objzx_TopicObjectiveEN.Score.ToString());
 }
 
 if (objzx_TopicObjectiveEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.StuScore);
 arrValueListForInsert.Add(objzx_TopicObjectiveEN.StuScore.ToString());
 }
 
 if (objzx_TopicObjectiveEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.TeaScore);
 arrValueListForInsert.Add(objzx_TopicObjectiveEN.TeaScore.ToString());
 }
 
 if (objzx_TopicObjectiveEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.IdCurrEduCls);
 var strIdCurrEduCls = objzx_TopicObjectiveEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objzx_TopicObjectiveEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.PdfContent);
 var strPdfContent = objzx_TopicObjectiveEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objzx_TopicObjectiveEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.PdfPageNum);
 arrValueListForInsert.Add(objzx_TopicObjectiveEN.PdfPageNum.ToString());
 }
 
 if (objzx_TopicObjectiveEN.CitationCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.CitationCount);
 arrValueListForInsert.Add(objzx_TopicObjectiveEN.CitationCount.ToString());
 }
 
 if (objzx_TopicObjectiveEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.VersionCount);
 arrValueListForInsert.Add(objzx_TopicObjectiveEN.VersionCount.ToString());
 }
 
 if (objzx_TopicObjectiveEN.zxShareId !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.zxShareId);
 var strzxShareId = objzx_TopicObjectiveEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxShareId + "'");
 }
 
 if (objzx_TopicObjectiveEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.CreateDate);
 var strCreateDate = objzx_TopicObjectiveEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objzx_TopicObjectiveEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.UpdDate);
 var strUpdDate = objzx_TopicObjectiveEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_TopicObjectiveEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.UpdUser);
 var strUpdUser = objzx_TopicObjectiveEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_TopicObjectiveEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.Memo);
 var strMemo = objzx_TopicObjectiveEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_TopicObjectiveEN.PdfDivLet !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.PdfDivLet);
 var strPdfDivLet = objzx_TopicObjectiveEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivLet + "'");
 }
 
 if (objzx_TopicObjectiveEN.PdfDivTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.PdfDivTop);
 var strPdfDivTop = objzx_TopicObjectiveEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivTop + "'");
 }
 
 if (objzx_TopicObjectiveEN.PdfPageNumIn !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.PdfPageNumIn);
 var strPdfPageNumIn = objzx_TopicObjectiveEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfPageNumIn + "'");
 }
 
 if (objzx_TopicObjectiveEN.PdfPageTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.PdfPageTop);
 arrValueListForInsert.Add(objzx_TopicObjectiveEN.PdfPageTop.ToString());
 }
 
 if (objzx_TopicObjectiveEN.PdfZoom !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.PdfZoom);
 var strPdfZoom = objzx_TopicObjectiveEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfZoom + "'");
 }
 
 if (objzx_TopicObjectiveEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.GroupTextId);
 var strGroupTextId = objzx_TopicObjectiveEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_TopicObjective");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TopicObjectiveDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objzx_TopicObjectiveEN.zxTopicObjectiveId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clszx_TopicObjectiveEN objzx_TopicObjectiveEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objzx_TopicObjectiveEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_TopicObjectiveEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_TopicObjectiveEN.zxTopicObjectiveId !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.zxTopicObjectiveId);
 var strzxTopicObjectiveId = objzx_TopicObjectiveEN.zxTopicObjectiveId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxTopicObjectiveId + "'");
 }
 
 if (objzx_TopicObjectiveEN.ObjectiveName !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.ObjectiveName);
 var strObjectiveName = objzx_TopicObjectiveEN.ObjectiveName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strObjectiveName + "'");
 }
 
 if (objzx_TopicObjectiveEN.ObjectiveContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.ObjectiveContent);
 var strObjectiveContent = objzx_TopicObjectiveEN.ObjectiveContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strObjectiveContent + "'");
 }
 
 if (objzx_TopicObjectiveEN.ObjectiveType !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.ObjectiveType);
 var strObjectiveType = objzx_TopicObjectiveEN.ObjectiveType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strObjectiveType + "'");
 }
 
 if (objzx_TopicObjectiveEN.Conclusion !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.Conclusion);
 var strConclusion = objzx_TopicObjectiveEN.Conclusion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConclusion + "'");
 }
 
 if (objzx_TopicObjectiveEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.TextId);
 var strTextId = objzx_TopicObjectiveEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 arrFieldListForInsert.Add(conzx_TopicObjective.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_TopicObjectiveEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_TopicObjectiveEN.VoteCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.VoteCount);
 arrValueListForInsert.Add(objzx_TopicObjectiveEN.VoteCount.ToString());
 }
 
 if (objzx_TopicObjectiveEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.AppraiseCount);
 arrValueListForInsert.Add(objzx_TopicObjectiveEN.AppraiseCount.ToString());
 }
 
 if (objzx_TopicObjectiveEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.Score);
 arrValueListForInsert.Add(objzx_TopicObjectiveEN.Score.ToString());
 }
 
 if (objzx_TopicObjectiveEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.StuScore);
 arrValueListForInsert.Add(objzx_TopicObjectiveEN.StuScore.ToString());
 }
 
 if (objzx_TopicObjectiveEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.TeaScore);
 arrValueListForInsert.Add(objzx_TopicObjectiveEN.TeaScore.ToString());
 }
 
 if (objzx_TopicObjectiveEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.IdCurrEduCls);
 var strIdCurrEduCls = objzx_TopicObjectiveEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objzx_TopicObjectiveEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.PdfContent);
 var strPdfContent = objzx_TopicObjectiveEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objzx_TopicObjectiveEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.PdfPageNum);
 arrValueListForInsert.Add(objzx_TopicObjectiveEN.PdfPageNum.ToString());
 }
 
 if (objzx_TopicObjectiveEN.CitationCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.CitationCount);
 arrValueListForInsert.Add(objzx_TopicObjectiveEN.CitationCount.ToString());
 }
 
 if (objzx_TopicObjectiveEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.VersionCount);
 arrValueListForInsert.Add(objzx_TopicObjectiveEN.VersionCount.ToString());
 }
 
 if (objzx_TopicObjectiveEN.zxShareId !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.zxShareId);
 var strzxShareId = objzx_TopicObjectiveEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxShareId + "'");
 }
 
 if (objzx_TopicObjectiveEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.CreateDate);
 var strCreateDate = objzx_TopicObjectiveEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objzx_TopicObjectiveEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.UpdDate);
 var strUpdDate = objzx_TopicObjectiveEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_TopicObjectiveEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.UpdUser);
 var strUpdUser = objzx_TopicObjectiveEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_TopicObjectiveEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.Memo);
 var strMemo = objzx_TopicObjectiveEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_TopicObjectiveEN.PdfDivLet !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.PdfDivLet);
 var strPdfDivLet = objzx_TopicObjectiveEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivLet + "'");
 }
 
 if (objzx_TopicObjectiveEN.PdfDivTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.PdfDivTop);
 var strPdfDivTop = objzx_TopicObjectiveEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivTop + "'");
 }
 
 if (objzx_TopicObjectiveEN.PdfPageNumIn !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.PdfPageNumIn);
 var strPdfPageNumIn = objzx_TopicObjectiveEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfPageNumIn + "'");
 }
 
 if (objzx_TopicObjectiveEN.PdfPageTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.PdfPageTop);
 arrValueListForInsert.Add(objzx_TopicObjectiveEN.PdfPageTop.ToString());
 }
 
 if (objzx_TopicObjectiveEN.PdfZoom !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.PdfZoom);
 var strPdfZoom = objzx_TopicObjectiveEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfZoom + "'");
 }
 
 if (objzx_TopicObjectiveEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjective.GroupTextId);
 var strGroupTextId = objzx_TopicObjectiveEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_TopicObjective");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TopicObjectiveDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewzx_TopicObjectives(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TopicObjectiveDA.GetSpecSQLObj();
strSQL = "Select * from zx_TopicObjective where zxTopicObjectiveId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "zx_TopicObjective");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strzxTopicObjectiveId = oRow[conzx_TopicObjective.zxTopicObjectiveId].ToString().Trim();
if (IsExist(strzxTopicObjectiveId))
{
 string strResult = "关键字变量值为:" + string.Format("zxTopicObjectiveId = {0}", strzxTopicObjectiveId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clszx_TopicObjectiveEN._CurrTabName ].NewRow();
objRow[conzx_TopicObjective.zxTopicObjectiveId] = oRow[conzx_TopicObjective.zxTopicObjectiveId].ToString().Trim(); //客观Id
objRow[conzx_TopicObjective.ObjectiveName] = oRow[conzx_TopicObjective.ObjectiveName].ToString().Trim(); //客观名称
objRow[conzx_TopicObjective.ObjectiveContent] = oRow[conzx_TopicObjective.ObjectiveContent].ToString().Trim(); //客观内容
objRow[conzx_TopicObjective.ObjectiveType] = oRow[conzx_TopicObjective.ObjectiveType].ToString().Trim(); //客观类型
objRow[conzx_TopicObjective.Conclusion] = oRow[conzx_TopicObjective.Conclusion].ToString().Trim(); //结论
objRow[conzx_TopicObjective.TextId] = oRow[conzx_TopicObjective.TextId].ToString().Trim(); //课件Id
objRow[conzx_TopicObjective.IsSubmit] = oRow[conzx_TopicObjective.IsSubmit].ToString().Trim(); //是否提交
objRow[conzx_TopicObjective.VoteCount] = oRow[conzx_TopicObjective.VoteCount].ToString().Trim(); //点赞计数
objRow[conzx_TopicObjective.AppraiseCount] = oRow[conzx_TopicObjective.AppraiseCount].ToString().Trim(); //评论数
objRow[conzx_TopicObjective.Score] = oRow[conzx_TopicObjective.Score].ToString().Trim(); //评分
objRow[conzx_TopicObjective.StuScore] = oRow[conzx_TopicObjective.StuScore].ToString().Trim(); //学生平均分
objRow[conzx_TopicObjective.TeaScore] = oRow[conzx_TopicObjective.TeaScore].ToString().Trim(); //教师评分
objRow[conzx_TopicObjective.IdCurrEduCls] = oRow[conzx_TopicObjective.IdCurrEduCls].ToString().Trim(); //教学班流水号
objRow[conzx_TopicObjective.PdfContent] = oRow[conzx_TopicObjective.PdfContent].ToString().Trim(); //Pdf内容
objRow[conzx_TopicObjective.PdfPageNum] = oRow[conzx_TopicObjective.PdfPageNum].ToString().Trim(); //Pdf页码
objRow[conzx_TopicObjective.CitationCount] = oRow[conzx_TopicObjective.CitationCount].ToString().Trim(); //引用统计
objRow[conzx_TopicObjective.VersionCount] = oRow[conzx_TopicObjective.VersionCount].ToString().Trim(); //版本统计
objRow[conzx_TopicObjective.zxShareId] = oRow[conzx_TopicObjective.zxShareId].ToString().Trim(); //分享Id
objRow[conzx_TopicObjective.CreateDate] = oRow[conzx_TopicObjective.CreateDate].ToString().Trim(); //建立日期
objRow[conzx_TopicObjective.UpdDate] = oRow[conzx_TopicObjective.UpdDate].ToString().Trim(); //修改日期
objRow[conzx_TopicObjective.UpdUser] = oRow[conzx_TopicObjective.UpdUser].ToString().Trim(); //修改人
objRow[conzx_TopicObjective.Memo] = oRow[conzx_TopicObjective.Memo].ToString().Trim(); //备注
objRow[conzx_TopicObjective.PdfDivLet] = oRow[conzx_TopicObjective.PdfDivLet].ToString().Trim(); //PdfDivLet
objRow[conzx_TopicObjective.PdfDivTop] = oRow[conzx_TopicObjective.PdfDivTop].ToString().Trim(); //PdfDivTop
objRow[conzx_TopicObjective.PdfPageNumIn] = oRow[conzx_TopicObjective.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objRow[conzx_TopicObjective.PdfPageTop] = oRow[conzx_TopicObjective.PdfPageTop].ToString().Trim(); //pdf页面顶部位置
objRow[conzx_TopicObjective.PdfZoom] = oRow[conzx_TopicObjective.PdfZoom].ToString().Trim(); //PdfZoom
objRow[conzx_TopicObjective.GroupTextId] = oRow[conzx_TopicObjective.GroupTextId].ToString().Trim(); //小组Id
 objDS.Tables[clszx_TopicObjectiveEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clszx_TopicObjectiveEN._CurrTabName);
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
 /// <param name = "objzx_TopicObjectiveEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clszx_TopicObjectiveEN objzx_TopicObjectiveEN)
{
 if (objzx_TopicObjectiveEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_TopicObjectiveEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TopicObjectiveDA.GetSpecSQLObj();
strSQL = "Select * from zx_TopicObjective where zxTopicObjectiveId = " + "'"+ objzx_TopicObjectiveEN.zxTopicObjectiveId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clszx_TopicObjectiveEN._CurrTabName);
if (objDS.Tables[clszx_TopicObjectiveEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:zxTopicObjectiveId = " + "'"+ objzx_TopicObjectiveEN.zxTopicObjectiveId+"'");
return false;
}
objRow = objDS.Tables[clszx_TopicObjectiveEN._CurrTabName].Rows[0];
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.zxTopicObjectiveId))
 {
objRow[conzx_TopicObjective.zxTopicObjectiveId] = objzx_TopicObjectiveEN.zxTopicObjectiveId; //客观Id
 }
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.ObjectiveName))
 {
objRow[conzx_TopicObjective.ObjectiveName] = objzx_TopicObjectiveEN.ObjectiveName; //客观名称
 }
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.ObjectiveContent))
 {
objRow[conzx_TopicObjective.ObjectiveContent] = objzx_TopicObjectiveEN.ObjectiveContent; //客观内容
 }
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.ObjectiveType))
 {
objRow[conzx_TopicObjective.ObjectiveType] = objzx_TopicObjectiveEN.ObjectiveType; //客观类型
 }
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.Conclusion))
 {
objRow[conzx_TopicObjective.Conclusion] = objzx_TopicObjectiveEN.Conclusion; //结论
 }
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.TextId))
 {
objRow[conzx_TopicObjective.TextId] = objzx_TopicObjectiveEN.TextId; //课件Id
 }
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.IsSubmit))
 {
objRow[conzx_TopicObjective.IsSubmit] = objzx_TopicObjectiveEN.IsSubmit; //是否提交
 }
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.VoteCount))
 {
objRow[conzx_TopicObjective.VoteCount] = objzx_TopicObjectiveEN.VoteCount; //点赞计数
 }
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.AppraiseCount))
 {
objRow[conzx_TopicObjective.AppraiseCount] = objzx_TopicObjectiveEN.AppraiseCount; //评论数
 }
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.Score))
 {
objRow[conzx_TopicObjective.Score] = objzx_TopicObjectiveEN.Score; //评分
 }
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.StuScore))
 {
objRow[conzx_TopicObjective.StuScore] = objzx_TopicObjectiveEN.StuScore; //学生平均分
 }
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.TeaScore))
 {
objRow[conzx_TopicObjective.TeaScore] = objzx_TopicObjectiveEN.TeaScore; //教师评分
 }
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.IdCurrEduCls))
 {
objRow[conzx_TopicObjective.IdCurrEduCls] = objzx_TopicObjectiveEN.IdCurrEduCls; //教学班流水号
 }
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.PdfContent))
 {
objRow[conzx_TopicObjective.PdfContent] = objzx_TopicObjectiveEN.PdfContent; //Pdf内容
 }
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.PdfPageNum))
 {
objRow[conzx_TopicObjective.PdfPageNum] = objzx_TopicObjectiveEN.PdfPageNum; //Pdf页码
 }
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.CitationCount))
 {
objRow[conzx_TopicObjective.CitationCount] = objzx_TopicObjectiveEN.CitationCount; //引用统计
 }
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.VersionCount))
 {
objRow[conzx_TopicObjective.VersionCount] = objzx_TopicObjectiveEN.VersionCount; //版本统计
 }
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.zxShareId))
 {
objRow[conzx_TopicObjective.zxShareId] = objzx_TopicObjectiveEN.zxShareId; //分享Id
 }
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.CreateDate))
 {
objRow[conzx_TopicObjective.CreateDate] = objzx_TopicObjectiveEN.CreateDate; //建立日期
 }
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.UpdDate))
 {
objRow[conzx_TopicObjective.UpdDate] = objzx_TopicObjectiveEN.UpdDate; //修改日期
 }
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.UpdUser))
 {
objRow[conzx_TopicObjective.UpdUser] = objzx_TopicObjectiveEN.UpdUser; //修改人
 }
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.Memo))
 {
objRow[conzx_TopicObjective.Memo] = objzx_TopicObjectiveEN.Memo; //备注
 }
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.PdfDivLet))
 {
objRow[conzx_TopicObjective.PdfDivLet] = objzx_TopicObjectiveEN.PdfDivLet; //PdfDivLet
 }
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.PdfDivTop))
 {
objRow[conzx_TopicObjective.PdfDivTop] = objzx_TopicObjectiveEN.PdfDivTop; //PdfDivTop
 }
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.PdfPageNumIn))
 {
objRow[conzx_TopicObjective.PdfPageNumIn] = objzx_TopicObjectiveEN.PdfPageNumIn; //PdfPageNumIn
 }
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.PdfPageTop))
 {
objRow[conzx_TopicObjective.PdfPageTop] = objzx_TopicObjectiveEN.PdfPageTop; //pdf页面顶部位置
 }
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.PdfZoom))
 {
objRow[conzx_TopicObjective.PdfZoom] = objzx_TopicObjectiveEN.PdfZoom; //PdfZoom
 }
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.GroupTextId))
 {
objRow[conzx_TopicObjective.GroupTextId] = objzx_TopicObjectiveEN.GroupTextId; //小组Id
 }
try
{
objDA.Update(objDS, clszx_TopicObjectiveEN._CurrTabName);
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
 /// <param name = "objzx_TopicObjectiveEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clszx_TopicObjectiveEN objzx_TopicObjectiveEN)
{
 if (objzx_TopicObjectiveEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_TopicObjectiveEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TopicObjectiveDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update zx_TopicObjective Set ");
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.ObjectiveName))
 {
 if (objzx_TopicObjectiveEN.ObjectiveName !=  null)
 {
 var strObjectiveName = objzx_TopicObjectiveEN.ObjectiveName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strObjectiveName, conzx_TopicObjective.ObjectiveName); //客观名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjective.ObjectiveName); //客观名称
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.ObjectiveContent))
 {
 if (objzx_TopicObjectiveEN.ObjectiveContent !=  null)
 {
 var strObjectiveContent = objzx_TopicObjectiveEN.ObjectiveContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strObjectiveContent, conzx_TopicObjective.ObjectiveContent); //客观内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjective.ObjectiveContent); //客观内容
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.ObjectiveType))
 {
 if (objzx_TopicObjectiveEN.ObjectiveType !=  null)
 {
 var strObjectiveType = objzx_TopicObjectiveEN.ObjectiveType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strObjectiveType, conzx_TopicObjective.ObjectiveType); //客观类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjective.ObjectiveType); //客观类型
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.Conclusion))
 {
 if (objzx_TopicObjectiveEN.Conclusion !=  null)
 {
 var strConclusion = objzx_TopicObjectiveEN.Conclusion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strConclusion, conzx_TopicObjective.Conclusion); //结论
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjective.Conclusion); //结论
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.TextId))
 {
 if (objzx_TopicObjectiveEN.TextId !=  null)
 {
 var strTextId = objzx_TopicObjectiveEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTextId, conzx_TopicObjective.TextId); //课件Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjective.TextId); //课件Id
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objzx_TopicObjectiveEN.IsSubmit == true?"1":"0", conzx_TopicObjective.IsSubmit); //是否提交
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.VoteCount))
 {
 if (objzx_TopicObjectiveEN.VoteCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TopicObjectiveEN.VoteCount, conzx_TopicObjective.VoteCount); //点赞计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjective.VoteCount); //点赞计数
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.AppraiseCount))
 {
 if (objzx_TopicObjectiveEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TopicObjectiveEN.AppraiseCount, conzx_TopicObjective.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjective.AppraiseCount); //评论数
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.Score))
 {
 if (objzx_TopicObjectiveEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TopicObjectiveEN.Score, conzx_TopicObjective.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjective.Score); //评分
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.StuScore))
 {
 if (objzx_TopicObjectiveEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TopicObjectiveEN.StuScore, conzx_TopicObjective.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjective.StuScore); //学生平均分
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.TeaScore))
 {
 if (objzx_TopicObjectiveEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TopicObjectiveEN.TeaScore, conzx_TopicObjective.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjective.TeaScore); //教师评分
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.IdCurrEduCls))
 {
 if (objzx_TopicObjectiveEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_TopicObjectiveEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conzx_TopicObjective.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjective.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.PdfContent))
 {
 if (objzx_TopicObjectiveEN.PdfContent !=  null)
 {
 var strPdfContent = objzx_TopicObjectiveEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfContent, conzx_TopicObjective.PdfContent); //Pdf内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjective.PdfContent); //Pdf内容
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.PdfPageNum))
 {
 if (objzx_TopicObjectiveEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TopicObjectiveEN.PdfPageNum, conzx_TopicObjective.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjective.PdfPageNum); //Pdf页码
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.CitationCount))
 {
 if (objzx_TopicObjectiveEN.CitationCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TopicObjectiveEN.CitationCount, conzx_TopicObjective.CitationCount); //引用统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjective.CitationCount); //引用统计
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.VersionCount))
 {
 if (objzx_TopicObjectiveEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TopicObjectiveEN.VersionCount, conzx_TopicObjective.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjective.VersionCount); //版本统计
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.zxShareId))
 {
 if (objzx_TopicObjectiveEN.zxShareId !=  null)
 {
 var strzxShareId = objzx_TopicObjectiveEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxShareId, conzx_TopicObjective.zxShareId); //分享Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjective.zxShareId); //分享Id
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.CreateDate))
 {
 if (objzx_TopicObjectiveEN.CreateDate !=  null)
 {
 var strCreateDate = objzx_TopicObjectiveEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateDate, conzx_TopicObjective.CreateDate); //建立日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjective.CreateDate); //建立日期
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.UpdDate))
 {
 if (objzx_TopicObjectiveEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_TopicObjectiveEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conzx_TopicObjective.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjective.UpdDate); //修改日期
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.UpdUser))
 {
 if (objzx_TopicObjectiveEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_TopicObjectiveEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conzx_TopicObjective.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjective.UpdUser); //修改人
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.Memo))
 {
 if (objzx_TopicObjectiveEN.Memo !=  null)
 {
 var strMemo = objzx_TopicObjectiveEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conzx_TopicObjective.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjective.Memo); //备注
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.PdfDivLet))
 {
 if (objzx_TopicObjectiveEN.PdfDivLet !=  null)
 {
 var strPdfDivLet = objzx_TopicObjectiveEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfDivLet, conzx_TopicObjective.PdfDivLet); //PdfDivLet
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjective.PdfDivLet); //PdfDivLet
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.PdfDivTop))
 {
 if (objzx_TopicObjectiveEN.PdfDivTop !=  null)
 {
 var strPdfDivTop = objzx_TopicObjectiveEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfDivTop, conzx_TopicObjective.PdfDivTop); //PdfDivTop
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjective.PdfDivTop); //PdfDivTop
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.PdfPageNumIn))
 {
 if (objzx_TopicObjectiveEN.PdfPageNumIn !=  null)
 {
 var strPdfPageNumIn = objzx_TopicObjectiveEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfPageNumIn, conzx_TopicObjective.PdfPageNumIn); //PdfPageNumIn
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjective.PdfPageNumIn); //PdfPageNumIn
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.PdfPageTop))
 {
 if (objzx_TopicObjectiveEN.PdfPageTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TopicObjectiveEN.PdfPageTop, conzx_TopicObjective.PdfPageTop); //pdf页面顶部位置
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjective.PdfPageTop); //pdf页面顶部位置
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.PdfZoom))
 {
 if (objzx_TopicObjectiveEN.PdfZoom !=  null)
 {
 var strPdfZoom = objzx_TopicObjectiveEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfZoom, conzx_TopicObjective.PdfZoom); //PdfZoom
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjective.PdfZoom); //PdfZoom
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.GroupTextId))
 {
 if (objzx_TopicObjectiveEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_TopicObjectiveEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGroupTextId, conzx_TopicObjective.GroupTextId); //小组Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjective.GroupTextId); //小组Id
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where zxTopicObjectiveId = '{0}'", objzx_TopicObjectiveEN.zxTopicObjectiveId); 
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
 /// <param name = "objzx_TopicObjectiveEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clszx_TopicObjectiveEN objzx_TopicObjectiveEN, string strCondition)
{
 if (objzx_TopicObjectiveEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_TopicObjectiveEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TopicObjectiveDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_TopicObjective Set ");
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.ObjectiveName))
 {
 if (objzx_TopicObjectiveEN.ObjectiveName !=  null)
 {
 var strObjectiveName = objzx_TopicObjectiveEN.ObjectiveName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ObjectiveName = '{0}',", strObjectiveName); //客观名称
 }
 else
 {
 sbSQL.Append(" ObjectiveName = null,"); //客观名称
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.ObjectiveContent))
 {
 if (objzx_TopicObjectiveEN.ObjectiveContent !=  null)
 {
 var strObjectiveContent = objzx_TopicObjectiveEN.ObjectiveContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ObjectiveContent = '{0}',", strObjectiveContent); //客观内容
 }
 else
 {
 sbSQL.Append(" ObjectiveContent = null,"); //客观内容
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.ObjectiveType))
 {
 if (objzx_TopicObjectiveEN.ObjectiveType !=  null)
 {
 var strObjectiveType = objzx_TopicObjectiveEN.ObjectiveType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ObjectiveType = '{0}',", strObjectiveType); //客观类型
 }
 else
 {
 sbSQL.Append(" ObjectiveType = null,"); //客观类型
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.Conclusion))
 {
 if (objzx_TopicObjectiveEN.Conclusion !=  null)
 {
 var strConclusion = objzx_TopicObjectiveEN.Conclusion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Conclusion = '{0}',", strConclusion); //结论
 }
 else
 {
 sbSQL.Append(" Conclusion = null,"); //结论
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.TextId))
 {
 if (objzx_TopicObjectiveEN.TextId !=  null)
 {
 var strTextId = objzx_TopicObjectiveEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TextId = '{0}',", strTextId); //课件Id
 }
 else
 {
 sbSQL.Append(" TextId = null,"); //课件Id
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objzx_TopicObjectiveEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.VoteCount))
 {
 if (objzx_TopicObjectiveEN.VoteCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TopicObjectiveEN.VoteCount, conzx_TopicObjective.VoteCount); //点赞计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjective.VoteCount); //点赞计数
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.AppraiseCount))
 {
 if (objzx_TopicObjectiveEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TopicObjectiveEN.AppraiseCount, conzx_TopicObjective.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjective.AppraiseCount); //评论数
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.Score))
 {
 if (objzx_TopicObjectiveEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TopicObjectiveEN.Score, conzx_TopicObjective.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjective.Score); //评分
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.StuScore))
 {
 if (objzx_TopicObjectiveEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TopicObjectiveEN.StuScore, conzx_TopicObjective.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjective.StuScore); //学生平均分
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.TeaScore))
 {
 if (objzx_TopicObjectiveEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TopicObjectiveEN.TeaScore, conzx_TopicObjective.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjective.TeaScore); //教师评分
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.IdCurrEduCls))
 {
 if (objzx_TopicObjectiveEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_TopicObjectiveEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.PdfContent))
 {
 if (objzx_TopicObjectiveEN.PdfContent !=  null)
 {
 var strPdfContent = objzx_TopicObjectiveEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfContent = '{0}',", strPdfContent); //Pdf内容
 }
 else
 {
 sbSQL.Append(" PdfContent = null,"); //Pdf内容
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.PdfPageNum))
 {
 if (objzx_TopicObjectiveEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TopicObjectiveEN.PdfPageNum, conzx_TopicObjective.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjective.PdfPageNum); //Pdf页码
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.CitationCount))
 {
 if (objzx_TopicObjectiveEN.CitationCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TopicObjectiveEN.CitationCount, conzx_TopicObjective.CitationCount); //引用统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjective.CitationCount); //引用统计
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.VersionCount))
 {
 if (objzx_TopicObjectiveEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TopicObjectiveEN.VersionCount, conzx_TopicObjective.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjective.VersionCount); //版本统计
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.zxShareId))
 {
 if (objzx_TopicObjectiveEN.zxShareId !=  null)
 {
 var strzxShareId = objzx_TopicObjectiveEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxShareId = '{0}',", strzxShareId); //分享Id
 }
 else
 {
 sbSQL.Append(" zxShareId = null,"); //分享Id
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.CreateDate))
 {
 if (objzx_TopicObjectiveEN.CreateDate !=  null)
 {
 var strCreateDate = objzx_TopicObjectiveEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateDate = '{0}',", strCreateDate); //建立日期
 }
 else
 {
 sbSQL.Append(" CreateDate = null,"); //建立日期
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.UpdDate))
 {
 if (objzx_TopicObjectiveEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_TopicObjectiveEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.UpdUser))
 {
 if (objzx_TopicObjectiveEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_TopicObjectiveEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.Memo))
 {
 if (objzx_TopicObjectiveEN.Memo !=  null)
 {
 var strMemo = objzx_TopicObjectiveEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.PdfDivLet))
 {
 if (objzx_TopicObjectiveEN.PdfDivLet !=  null)
 {
 var strPdfDivLet = objzx_TopicObjectiveEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfDivLet = '{0}',", strPdfDivLet); //PdfDivLet
 }
 else
 {
 sbSQL.Append(" PdfDivLet = null,"); //PdfDivLet
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.PdfDivTop))
 {
 if (objzx_TopicObjectiveEN.PdfDivTop !=  null)
 {
 var strPdfDivTop = objzx_TopicObjectiveEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfDivTop = '{0}',", strPdfDivTop); //PdfDivTop
 }
 else
 {
 sbSQL.Append(" PdfDivTop = null,"); //PdfDivTop
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.PdfPageNumIn))
 {
 if (objzx_TopicObjectiveEN.PdfPageNumIn !=  null)
 {
 var strPdfPageNumIn = objzx_TopicObjectiveEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfPageNumIn = '{0}',", strPdfPageNumIn); //PdfPageNumIn
 }
 else
 {
 sbSQL.Append(" PdfPageNumIn = null,"); //PdfPageNumIn
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.PdfPageTop))
 {
 if (objzx_TopicObjectiveEN.PdfPageTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TopicObjectiveEN.PdfPageTop, conzx_TopicObjective.PdfPageTop); //pdf页面顶部位置
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjective.PdfPageTop); //pdf页面顶部位置
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.PdfZoom))
 {
 if (objzx_TopicObjectiveEN.PdfZoom !=  null)
 {
 var strPdfZoom = objzx_TopicObjectiveEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfZoom = '{0}',", strPdfZoom); //PdfZoom
 }
 else
 {
 sbSQL.Append(" PdfZoom = null,"); //PdfZoom
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.GroupTextId))
 {
 if (objzx_TopicObjectiveEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_TopicObjectiveEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GroupTextId = '{0}',", strGroupTextId); //小组Id
 }
 else
 {
 sbSQL.Append(" GroupTextId = null,"); //小组Id
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
 /// <param name = "objzx_TopicObjectiveEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clszx_TopicObjectiveEN objzx_TopicObjectiveEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objzx_TopicObjectiveEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_TopicObjectiveEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TopicObjectiveDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_TopicObjective Set ");
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.ObjectiveName))
 {
 if (objzx_TopicObjectiveEN.ObjectiveName !=  null)
 {
 var strObjectiveName = objzx_TopicObjectiveEN.ObjectiveName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ObjectiveName = '{0}',", strObjectiveName); //客观名称
 }
 else
 {
 sbSQL.Append(" ObjectiveName = null,"); //客观名称
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.ObjectiveContent))
 {
 if (objzx_TopicObjectiveEN.ObjectiveContent !=  null)
 {
 var strObjectiveContent = objzx_TopicObjectiveEN.ObjectiveContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ObjectiveContent = '{0}',", strObjectiveContent); //客观内容
 }
 else
 {
 sbSQL.Append(" ObjectiveContent = null,"); //客观内容
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.ObjectiveType))
 {
 if (objzx_TopicObjectiveEN.ObjectiveType !=  null)
 {
 var strObjectiveType = objzx_TopicObjectiveEN.ObjectiveType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ObjectiveType = '{0}',", strObjectiveType); //客观类型
 }
 else
 {
 sbSQL.Append(" ObjectiveType = null,"); //客观类型
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.Conclusion))
 {
 if (objzx_TopicObjectiveEN.Conclusion !=  null)
 {
 var strConclusion = objzx_TopicObjectiveEN.Conclusion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Conclusion = '{0}',", strConclusion); //结论
 }
 else
 {
 sbSQL.Append(" Conclusion = null,"); //结论
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.TextId))
 {
 if (objzx_TopicObjectiveEN.TextId !=  null)
 {
 var strTextId = objzx_TopicObjectiveEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TextId = '{0}',", strTextId); //课件Id
 }
 else
 {
 sbSQL.Append(" TextId = null,"); //课件Id
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objzx_TopicObjectiveEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.VoteCount))
 {
 if (objzx_TopicObjectiveEN.VoteCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TopicObjectiveEN.VoteCount, conzx_TopicObjective.VoteCount); //点赞计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjective.VoteCount); //点赞计数
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.AppraiseCount))
 {
 if (objzx_TopicObjectiveEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TopicObjectiveEN.AppraiseCount, conzx_TopicObjective.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjective.AppraiseCount); //评论数
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.Score))
 {
 if (objzx_TopicObjectiveEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TopicObjectiveEN.Score, conzx_TopicObjective.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjective.Score); //评分
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.StuScore))
 {
 if (objzx_TopicObjectiveEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TopicObjectiveEN.StuScore, conzx_TopicObjective.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjective.StuScore); //学生平均分
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.TeaScore))
 {
 if (objzx_TopicObjectiveEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TopicObjectiveEN.TeaScore, conzx_TopicObjective.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjective.TeaScore); //教师评分
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.IdCurrEduCls))
 {
 if (objzx_TopicObjectiveEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_TopicObjectiveEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.PdfContent))
 {
 if (objzx_TopicObjectiveEN.PdfContent !=  null)
 {
 var strPdfContent = objzx_TopicObjectiveEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfContent = '{0}',", strPdfContent); //Pdf内容
 }
 else
 {
 sbSQL.Append(" PdfContent = null,"); //Pdf内容
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.PdfPageNum))
 {
 if (objzx_TopicObjectiveEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TopicObjectiveEN.PdfPageNum, conzx_TopicObjective.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjective.PdfPageNum); //Pdf页码
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.CitationCount))
 {
 if (objzx_TopicObjectiveEN.CitationCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TopicObjectiveEN.CitationCount, conzx_TopicObjective.CitationCount); //引用统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjective.CitationCount); //引用统计
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.VersionCount))
 {
 if (objzx_TopicObjectiveEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TopicObjectiveEN.VersionCount, conzx_TopicObjective.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjective.VersionCount); //版本统计
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.zxShareId))
 {
 if (objzx_TopicObjectiveEN.zxShareId !=  null)
 {
 var strzxShareId = objzx_TopicObjectiveEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxShareId = '{0}',", strzxShareId); //分享Id
 }
 else
 {
 sbSQL.Append(" zxShareId = null,"); //分享Id
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.CreateDate))
 {
 if (objzx_TopicObjectiveEN.CreateDate !=  null)
 {
 var strCreateDate = objzx_TopicObjectiveEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateDate = '{0}',", strCreateDate); //建立日期
 }
 else
 {
 sbSQL.Append(" CreateDate = null,"); //建立日期
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.UpdDate))
 {
 if (objzx_TopicObjectiveEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_TopicObjectiveEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.UpdUser))
 {
 if (objzx_TopicObjectiveEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_TopicObjectiveEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.Memo))
 {
 if (objzx_TopicObjectiveEN.Memo !=  null)
 {
 var strMemo = objzx_TopicObjectiveEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.PdfDivLet))
 {
 if (objzx_TopicObjectiveEN.PdfDivLet !=  null)
 {
 var strPdfDivLet = objzx_TopicObjectiveEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfDivLet = '{0}',", strPdfDivLet); //PdfDivLet
 }
 else
 {
 sbSQL.Append(" PdfDivLet = null,"); //PdfDivLet
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.PdfDivTop))
 {
 if (objzx_TopicObjectiveEN.PdfDivTop !=  null)
 {
 var strPdfDivTop = objzx_TopicObjectiveEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfDivTop = '{0}',", strPdfDivTop); //PdfDivTop
 }
 else
 {
 sbSQL.Append(" PdfDivTop = null,"); //PdfDivTop
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.PdfPageNumIn))
 {
 if (objzx_TopicObjectiveEN.PdfPageNumIn !=  null)
 {
 var strPdfPageNumIn = objzx_TopicObjectiveEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfPageNumIn = '{0}',", strPdfPageNumIn); //PdfPageNumIn
 }
 else
 {
 sbSQL.Append(" PdfPageNumIn = null,"); //PdfPageNumIn
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.PdfPageTop))
 {
 if (objzx_TopicObjectiveEN.PdfPageTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TopicObjectiveEN.PdfPageTop, conzx_TopicObjective.PdfPageTop); //pdf页面顶部位置
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjective.PdfPageTop); //pdf页面顶部位置
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.PdfZoom))
 {
 if (objzx_TopicObjectiveEN.PdfZoom !=  null)
 {
 var strPdfZoom = objzx_TopicObjectiveEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfZoom = '{0}',", strPdfZoom); //PdfZoom
 }
 else
 {
 sbSQL.Append(" PdfZoom = null,"); //PdfZoom
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.GroupTextId))
 {
 if (objzx_TopicObjectiveEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_TopicObjectiveEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GroupTextId = '{0}',", strGroupTextId); //小组Id
 }
 else
 {
 sbSQL.Append(" GroupTextId = null,"); //小组Id
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
 /// <param name = "objzx_TopicObjectiveEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clszx_TopicObjectiveEN objzx_TopicObjectiveEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objzx_TopicObjectiveEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_TopicObjectiveEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TopicObjectiveDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_TopicObjective Set ");
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.ObjectiveName))
 {
 if (objzx_TopicObjectiveEN.ObjectiveName !=  null)
 {
 var strObjectiveName = objzx_TopicObjectiveEN.ObjectiveName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strObjectiveName, conzx_TopicObjective.ObjectiveName); //客观名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjective.ObjectiveName); //客观名称
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.ObjectiveContent))
 {
 if (objzx_TopicObjectiveEN.ObjectiveContent !=  null)
 {
 var strObjectiveContent = objzx_TopicObjectiveEN.ObjectiveContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strObjectiveContent, conzx_TopicObjective.ObjectiveContent); //客观内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjective.ObjectiveContent); //客观内容
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.ObjectiveType))
 {
 if (objzx_TopicObjectiveEN.ObjectiveType !=  null)
 {
 var strObjectiveType = objzx_TopicObjectiveEN.ObjectiveType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strObjectiveType, conzx_TopicObjective.ObjectiveType); //客观类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjective.ObjectiveType); //客观类型
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.Conclusion))
 {
 if (objzx_TopicObjectiveEN.Conclusion !=  null)
 {
 var strConclusion = objzx_TopicObjectiveEN.Conclusion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strConclusion, conzx_TopicObjective.Conclusion); //结论
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjective.Conclusion); //结论
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.TextId))
 {
 if (objzx_TopicObjectiveEN.TextId !=  null)
 {
 var strTextId = objzx_TopicObjectiveEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTextId, conzx_TopicObjective.TextId); //课件Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjective.TextId); //课件Id
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objzx_TopicObjectiveEN.IsSubmit == true?"1":"0", conzx_TopicObjective.IsSubmit); //是否提交
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.VoteCount))
 {
 if (objzx_TopicObjectiveEN.VoteCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TopicObjectiveEN.VoteCount, conzx_TopicObjective.VoteCount); //点赞计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjective.VoteCount); //点赞计数
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.AppraiseCount))
 {
 if (objzx_TopicObjectiveEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TopicObjectiveEN.AppraiseCount, conzx_TopicObjective.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjective.AppraiseCount); //评论数
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.Score))
 {
 if (objzx_TopicObjectiveEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TopicObjectiveEN.Score, conzx_TopicObjective.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjective.Score); //评分
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.StuScore))
 {
 if (objzx_TopicObjectiveEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TopicObjectiveEN.StuScore, conzx_TopicObjective.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjective.StuScore); //学生平均分
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.TeaScore))
 {
 if (objzx_TopicObjectiveEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TopicObjectiveEN.TeaScore, conzx_TopicObjective.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjective.TeaScore); //教师评分
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.IdCurrEduCls))
 {
 if (objzx_TopicObjectiveEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_TopicObjectiveEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conzx_TopicObjective.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjective.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.PdfContent))
 {
 if (objzx_TopicObjectiveEN.PdfContent !=  null)
 {
 var strPdfContent = objzx_TopicObjectiveEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfContent, conzx_TopicObjective.PdfContent); //Pdf内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjective.PdfContent); //Pdf内容
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.PdfPageNum))
 {
 if (objzx_TopicObjectiveEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TopicObjectiveEN.PdfPageNum, conzx_TopicObjective.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjective.PdfPageNum); //Pdf页码
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.CitationCount))
 {
 if (objzx_TopicObjectiveEN.CitationCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TopicObjectiveEN.CitationCount, conzx_TopicObjective.CitationCount); //引用统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjective.CitationCount); //引用统计
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.VersionCount))
 {
 if (objzx_TopicObjectiveEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TopicObjectiveEN.VersionCount, conzx_TopicObjective.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjective.VersionCount); //版本统计
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.zxShareId))
 {
 if (objzx_TopicObjectiveEN.zxShareId !=  null)
 {
 var strzxShareId = objzx_TopicObjectiveEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxShareId, conzx_TopicObjective.zxShareId); //分享Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjective.zxShareId); //分享Id
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.CreateDate))
 {
 if (objzx_TopicObjectiveEN.CreateDate !=  null)
 {
 var strCreateDate = objzx_TopicObjectiveEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateDate, conzx_TopicObjective.CreateDate); //建立日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjective.CreateDate); //建立日期
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.UpdDate))
 {
 if (objzx_TopicObjectiveEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_TopicObjectiveEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conzx_TopicObjective.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjective.UpdDate); //修改日期
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.UpdUser))
 {
 if (objzx_TopicObjectiveEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_TopicObjectiveEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conzx_TopicObjective.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjective.UpdUser); //修改人
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.Memo))
 {
 if (objzx_TopicObjectiveEN.Memo !=  null)
 {
 var strMemo = objzx_TopicObjectiveEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conzx_TopicObjective.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjective.Memo); //备注
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.PdfDivLet))
 {
 if (objzx_TopicObjectiveEN.PdfDivLet !=  null)
 {
 var strPdfDivLet = objzx_TopicObjectiveEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfDivLet, conzx_TopicObjective.PdfDivLet); //PdfDivLet
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjective.PdfDivLet); //PdfDivLet
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.PdfDivTop))
 {
 if (objzx_TopicObjectiveEN.PdfDivTop !=  null)
 {
 var strPdfDivTop = objzx_TopicObjectiveEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfDivTop, conzx_TopicObjective.PdfDivTop); //PdfDivTop
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjective.PdfDivTop); //PdfDivTop
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.PdfPageNumIn))
 {
 if (objzx_TopicObjectiveEN.PdfPageNumIn !=  null)
 {
 var strPdfPageNumIn = objzx_TopicObjectiveEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfPageNumIn, conzx_TopicObjective.PdfPageNumIn); //PdfPageNumIn
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjective.PdfPageNumIn); //PdfPageNumIn
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.PdfPageTop))
 {
 if (objzx_TopicObjectiveEN.PdfPageTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TopicObjectiveEN.PdfPageTop, conzx_TopicObjective.PdfPageTop); //pdf页面顶部位置
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjective.PdfPageTop); //pdf页面顶部位置
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.PdfZoom))
 {
 if (objzx_TopicObjectiveEN.PdfZoom !=  null)
 {
 var strPdfZoom = objzx_TopicObjectiveEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfZoom, conzx_TopicObjective.PdfZoom); //PdfZoom
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjective.PdfZoom); //PdfZoom
 }
 }
 
 if (objzx_TopicObjectiveEN.IsUpdated(conzx_TopicObjective.GroupTextId))
 {
 if (objzx_TopicObjectiveEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_TopicObjectiveEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGroupTextId, conzx_TopicObjective.GroupTextId); //小组Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjective.GroupTextId); //小组Id
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where zxTopicObjectiveId = '{0}'", objzx_TopicObjectiveEN.zxTopicObjectiveId); 
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
 /// <param name = "strzxTopicObjectiveId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strzxTopicObjectiveId) 
{
CheckPrimaryKey(strzxTopicObjectiveId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TopicObjectiveDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strzxTopicObjectiveId,
};
 objSQL.ExecSP("zx_TopicObjective_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strzxTopicObjectiveId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strzxTopicObjectiveId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strzxTopicObjectiveId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TopicObjectiveDA.GetSpecSQLObj();
//删除zx_TopicObjective本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_TopicObjective where zxTopicObjectiveId = " + "'"+ strzxTopicObjectiveId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delzx_TopicObjective(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TopicObjectiveDA.GetSpecSQLObj();
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
//删除zx_TopicObjective本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_TopicObjective where zxTopicObjectiveId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strzxTopicObjectiveId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strzxTopicObjectiveId) 
{
CheckPrimaryKey(strzxTopicObjectiveId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TopicObjectiveDA.GetSpecSQLObj();
//删除zx_TopicObjective本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_TopicObjective where zxTopicObjectiveId = " + "'"+ strzxTopicObjectiveId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delzx_TopicObjective(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clszx_TopicObjectiveDA: Delzx_TopicObjective)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TopicObjectiveDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from zx_TopicObjective where " + strCondition ;
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
public bool Delzx_TopicObjectiveWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clszx_TopicObjectiveDA: Delzx_TopicObjectiveWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TopicObjectiveDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from zx_TopicObjective where " + strCondition ;
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
 /// <param name = "objzx_TopicObjectiveENS">源对象</param>
 /// <param name = "objzx_TopicObjectiveENT">目标对象</param>
public void CopyTo(clszx_TopicObjectiveEN objzx_TopicObjectiveENS, clszx_TopicObjectiveEN objzx_TopicObjectiveENT)
{
objzx_TopicObjectiveENT.zxTopicObjectiveId = objzx_TopicObjectiveENS.zxTopicObjectiveId; //客观Id
objzx_TopicObjectiveENT.ObjectiveName = objzx_TopicObjectiveENS.ObjectiveName; //客观名称
objzx_TopicObjectiveENT.ObjectiveContent = objzx_TopicObjectiveENS.ObjectiveContent; //客观内容
objzx_TopicObjectiveENT.ObjectiveType = objzx_TopicObjectiveENS.ObjectiveType; //客观类型
objzx_TopicObjectiveENT.Conclusion = objzx_TopicObjectiveENS.Conclusion; //结论
objzx_TopicObjectiveENT.TextId = objzx_TopicObjectiveENS.TextId; //课件Id
objzx_TopicObjectiveENT.IsSubmit = objzx_TopicObjectiveENS.IsSubmit; //是否提交
objzx_TopicObjectiveENT.VoteCount = objzx_TopicObjectiveENS.VoteCount; //点赞计数
objzx_TopicObjectiveENT.AppraiseCount = objzx_TopicObjectiveENS.AppraiseCount; //评论数
objzx_TopicObjectiveENT.Score = objzx_TopicObjectiveENS.Score; //评分
objzx_TopicObjectiveENT.StuScore = objzx_TopicObjectiveENS.StuScore; //学生平均分
objzx_TopicObjectiveENT.TeaScore = objzx_TopicObjectiveENS.TeaScore; //教师评分
objzx_TopicObjectiveENT.IdCurrEduCls = objzx_TopicObjectiveENS.IdCurrEduCls; //教学班流水号
objzx_TopicObjectiveENT.PdfContent = objzx_TopicObjectiveENS.PdfContent; //Pdf内容
objzx_TopicObjectiveENT.PdfPageNum = objzx_TopicObjectiveENS.PdfPageNum; //Pdf页码
objzx_TopicObjectiveENT.CitationCount = objzx_TopicObjectiveENS.CitationCount; //引用统计
objzx_TopicObjectiveENT.VersionCount = objzx_TopicObjectiveENS.VersionCount; //版本统计
objzx_TopicObjectiveENT.zxShareId = objzx_TopicObjectiveENS.zxShareId; //分享Id
objzx_TopicObjectiveENT.CreateDate = objzx_TopicObjectiveENS.CreateDate; //建立日期
objzx_TopicObjectiveENT.UpdDate = objzx_TopicObjectiveENS.UpdDate; //修改日期
objzx_TopicObjectiveENT.UpdUser = objzx_TopicObjectiveENS.UpdUser; //修改人
objzx_TopicObjectiveENT.Memo = objzx_TopicObjectiveENS.Memo; //备注
objzx_TopicObjectiveENT.PdfDivLet = objzx_TopicObjectiveENS.PdfDivLet; //PdfDivLet
objzx_TopicObjectiveENT.PdfDivTop = objzx_TopicObjectiveENS.PdfDivTop; //PdfDivTop
objzx_TopicObjectiveENT.PdfPageNumIn = objzx_TopicObjectiveENS.PdfPageNumIn; //PdfPageNumIn
objzx_TopicObjectiveENT.PdfPageTop = objzx_TopicObjectiveENS.PdfPageTop; //pdf页面顶部位置
objzx_TopicObjectiveENT.PdfZoom = objzx_TopicObjectiveENS.PdfZoom; //PdfZoom
objzx_TopicObjectiveENT.GroupTextId = objzx_TopicObjectiveENS.GroupTextId; //小组Id
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clszx_TopicObjectiveEN objzx_TopicObjectiveEN)
{
//检查字段不能为空(NULL)
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveEN.zxTopicObjectiveId, 8, conzx_TopicObjective.zxTopicObjectiveId);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveEN.ObjectiveName, 500, conzx_TopicObjective.ObjectiveName);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveEN.ObjectiveType, 2, conzx_TopicObjective.ObjectiveType);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveEN.TextId, 8, conzx_TopicObjective.TextId);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveEN.IdCurrEduCls, 8, conzx_TopicObjective.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveEN.PdfContent, 2000, conzx_TopicObjective.PdfContent);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveEN.zxShareId, 2, conzx_TopicObjective.zxShareId);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveEN.CreateDate, 20, conzx_TopicObjective.CreateDate);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveEN.UpdDate, 20, conzx_TopicObjective.UpdDate);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveEN.UpdUser, 20, conzx_TopicObjective.UpdUser);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveEN.Memo, 1000, conzx_TopicObjective.Memo);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveEN.PdfDivLet, 50, conzx_TopicObjective.PdfDivLet);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveEN.PdfDivTop, 50, conzx_TopicObjective.PdfDivTop);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveEN.PdfPageNumIn, 50, conzx_TopicObjective.PdfPageNumIn);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveEN.PdfZoom, 50, conzx_TopicObjective.PdfZoom);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveEN.GroupTextId, 8, conzx_TopicObjective.GroupTextId);
//检查字段外键固定长度
 objzx_TopicObjectiveEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clszx_TopicObjectiveEN objzx_TopicObjectiveEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveEN.ObjectiveName, 500, conzx_TopicObjective.ObjectiveName);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveEN.ObjectiveType, 2, conzx_TopicObjective.ObjectiveType);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveEN.TextId, 8, conzx_TopicObjective.TextId);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveEN.IdCurrEduCls, 8, conzx_TopicObjective.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveEN.PdfContent, 2000, conzx_TopicObjective.PdfContent);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveEN.zxShareId, 2, conzx_TopicObjective.zxShareId);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveEN.CreateDate, 20, conzx_TopicObjective.CreateDate);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveEN.UpdDate, 20, conzx_TopicObjective.UpdDate);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveEN.UpdUser, 20, conzx_TopicObjective.UpdUser);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveEN.Memo, 1000, conzx_TopicObjective.Memo);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveEN.PdfDivLet, 50, conzx_TopicObjective.PdfDivLet);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveEN.PdfDivTop, 50, conzx_TopicObjective.PdfDivTop);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveEN.PdfPageNumIn, 50, conzx_TopicObjective.PdfPageNumIn);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveEN.PdfZoom, 50, conzx_TopicObjective.PdfZoom);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveEN.GroupTextId, 8, conzx_TopicObjective.GroupTextId);
//检查外键字段长度
 objzx_TopicObjectiveEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clszx_TopicObjectiveEN objzx_TopicObjectiveEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveEN.zxTopicObjectiveId, 8, conzx_TopicObjective.zxTopicObjectiveId);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveEN.ObjectiveName, 500, conzx_TopicObjective.ObjectiveName);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveEN.ObjectiveType, 2, conzx_TopicObjective.ObjectiveType);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveEN.TextId, 8, conzx_TopicObjective.TextId);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveEN.IdCurrEduCls, 8, conzx_TopicObjective.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveEN.PdfContent, 2000, conzx_TopicObjective.PdfContent);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveEN.zxShareId, 2, conzx_TopicObjective.zxShareId);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveEN.CreateDate, 20, conzx_TopicObjective.CreateDate);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveEN.UpdDate, 20, conzx_TopicObjective.UpdDate);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveEN.UpdUser, 20, conzx_TopicObjective.UpdUser);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveEN.Memo, 1000, conzx_TopicObjective.Memo);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveEN.PdfDivLet, 50, conzx_TopicObjective.PdfDivLet);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveEN.PdfDivTop, 50, conzx_TopicObjective.PdfDivTop);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveEN.PdfPageNumIn, 50, conzx_TopicObjective.PdfPageNumIn);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveEN.PdfZoom, 50, conzx_TopicObjective.PdfZoom);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveEN.GroupTextId, 8, conzx_TopicObjective.GroupTextId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objzx_TopicObjectiveEN.zxTopicObjectiveId, conzx_TopicObjective.zxTopicObjectiveId);
clsCheckSql.CheckSqlInjection4Field(objzx_TopicObjectiveEN.ObjectiveName, conzx_TopicObjective.ObjectiveName);
clsCheckSql.CheckSqlInjection4Field(objzx_TopicObjectiveEN.ObjectiveType, conzx_TopicObjective.ObjectiveType);
clsCheckSql.CheckSqlInjection4Field(objzx_TopicObjectiveEN.TextId, conzx_TopicObjective.TextId);
clsCheckSql.CheckSqlInjection4Field(objzx_TopicObjectiveEN.IdCurrEduCls, conzx_TopicObjective.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objzx_TopicObjectiveEN.PdfContent, conzx_TopicObjective.PdfContent);
clsCheckSql.CheckSqlInjection4Field(objzx_TopicObjectiveEN.zxShareId, conzx_TopicObjective.zxShareId);
clsCheckSql.CheckSqlInjection4Field(objzx_TopicObjectiveEN.CreateDate, conzx_TopicObjective.CreateDate);
clsCheckSql.CheckSqlInjection4Field(objzx_TopicObjectiveEN.UpdDate, conzx_TopicObjective.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objzx_TopicObjectiveEN.UpdUser, conzx_TopicObjective.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objzx_TopicObjectiveEN.Memo, conzx_TopicObjective.Memo);
clsCheckSql.CheckSqlInjection4Field(objzx_TopicObjectiveEN.PdfDivLet, conzx_TopicObjective.PdfDivLet);
clsCheckSql.CheckSqlInjection4Field(objzx_TopicObjectiveEN.PdfDivTop, conzx_TopicObjective.PdfDivTop);
clsCheckSql.CheckSqlInjection4Field(objzx_TopicObjectiveEN.PdfPageNumIn, conzx_TopicObjective.PdfPageNumIn);
clsCheckSql.CheckSqlInjection4Field(objzx_TopicObjectiveEN.PdfZoom, conzx_TopicObjective.PdfZoom);
clsCheckSql.CheckSqlInjection4Field(objzx_TopicObjectiveEN.GroupTextId, conzx_TopicObjective.GroupTextId);
//检查外键字段长度
 objzx_TopicObjectiveEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--zx_TopicObjective(中学客观事实数据),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clszx_TopicObjectiveEN objzx_TopicObjectiveEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 if (objzx_TopicObjectiveEN.TextId == null)
{
 sbCondition.AppendFormat(" and TextId is null");
}
else
{
 sbCondition.AppendFormat(" and TextId = '{0}'", objzx_TopicObjectiveEN.TextId);
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
 objSQL = clszx_TopicObjectiveDA.GetSpecSQLObj();
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
 objSQL = clszx_TopicObjectiveDA.GetSpecSQLObj();
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
 objSQL = clszx_TopicObjectiveDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clszx_TopicObjectiveEN._CurrTabName);
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
 objSQL = clszx_TopicObjectiveDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clszx_TopicObjectiveEN._CurrTabName, strCondition);
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
 objSQL = clszx_TopicObjectiveDA.GetSpecSQLObj();
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
 objSQL = clszx_TopicObjectiveDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}