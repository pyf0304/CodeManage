
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_ResearchResultDA
 表名:zx_ResearchResult(01120803)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:55:35
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
 /// 中学研究成果(zx_ResearchResult)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clszx_ResearchResultDA : clsCommBase4DA
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
 return clszx_ResearchResultEN._CurrTabName;
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
if (string.IsNullOrEmpty(clszx_ResearchResultEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clszx_ResearchResultEN._ConnectString);
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
 if (string.IsNullOrEmpty(clszx_ResearchResultEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clszx_ResearchResultEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strzxResultId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strzxResultId)
{
strzxResultId = strzxResultId.Replace("'", "''");
if (strzxResultId.Length > 10)
{
throw new Exception("(errid:Data000001)在表:zx_ResearchResult中,检查关键字,长度不正确!(clszx_ResearchResultDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strzxResultId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:zx_ResearchResult中,关键字不能为空 或 null!(clszx_ResearchResultDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strzxResultId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clszx_ResearchResultDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clszx_ResearchResultDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ResearchResultDA.GetSpecSQLObj();
strSQL = "Select * from zx_ResearchResult where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_zx_ResearchResult(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clszx_ResearchResultDA: GetDataTable_zx_ResearchResult)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ResearchResultDA.GetSpecSQLObj();
strSQL = "Select * from zx_ResearchResult where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clszx_ResearchResultDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ResearchResultDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clszx_ResearchResultDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ResearchResultDA.GetSpecSQLObj();
strSQL = "Select * from zx_ResearchResult where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clszx_ResearchResultDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ResearchResultDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clszx_ResearchResultDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ResearchResultDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_ResearchResult where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_ResearchResult where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clszx_ResearchResultDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ResearchResultDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from zx_ResearchResult where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clszx_ResearchResultDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ResearchResultDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} zx_ResearchResult.* from zx_ResearchResult Left Join {1} on {2} where {3} and zx_ResearchResult.zxResultId not in (Select top {5} zx_ResearchResult.zxResultId from zx_ResearchResult Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_ResearchResult where {1} and zxResultId not in (Select top {2} zxResultId from zx_ResearchResult where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_ResearchResult where {1} and zxResultId not in (Select top {3} zxResultId from zx_ResearchResult where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clszx_ResearchResultDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ResearchResultDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} zx_ResearchResult.* from zx_ResearchResult Left Join {1} on {2} where {3} and zx_ResearchResult.zxResultId not in (Select top {5} zx_ResearchResult.zxResultId from zx_ResearchResult Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_ResearchResult where {1} and zxResultId not in (Select top {2} zxResultId from zx_ResearchResult where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_ResearchResult where {1} and zxResultId not in (Select top {3} zxResultId from zx_ResearchResult where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clszx_ResearchResultEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clszx_ResearchResultDA:GetObjLst)", objException.Message));
}
List<clszx_ResearchResultEN> arrObjLst = new List<clszx_ResearchResultEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ResearchResultDA.GetSpecSQLObj();
strSQL = "Select * from zx_ResearchResult where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ResearchResultEN objzx_ResearchResultEN = new clszx_ResearchResultEN();
try
{
objzx_ResearchResultEN.zxResultId = objRow[conzx_ResearchResult.zxResultId].ToString().Trim(); //成果Id
objzx_ResearchResultEN.GroupTextId = objRow[conzx_ResearchResult.GroupTextId] == DBNull.Value ? null : objRow[conzx_ResearchResult.GroupTextId].ToString().Trim(); //小组Id
objzx_ResearchResultEN.TextId = objRow[conzx_ResearchResult.TextId] == DBNull.Value ? null : objRow[conzx_ResearchResult.TextId].ToString().Trim(); //课件Id
objzx_ResearchResultEN.ResultTypeId = objRow[conzx_ResearchResult.ResultTypeId] == DBNull.Value ? null : objRow[conzx_ResearchResult.ResultTypeId].ToString().Trim(); //成果类型Id
objzx_ResearchResultEN.ResultName = objRow[conzx_ResearchResult.ResultName] == DBNull.Value ? null : objRow[conzx_ResearchResult.ResultName].ToString().Trim(); //成果名称
objzx_ResearchResultEN.ResultContent = objRow[conzx_ResearchResult.ResultContent] == DBNull.Value ? null : objRow[conzx_ResearchResult.ResultContent].ToString().Trim(); //成果内容
objzx_ResearchResultEN.Author = objRow[conzx_ResearchResult.Author] == DBNull.Value ? null : objRow[conzx_ResearchResult.Author].ToString().Trim(); //作者
objzx_ResearchResultEN.Division = objRow[conzx_ResearchResult.Division] == DBNull.Value ? null : objRow[conzx_ResearchResult.Division].ToString().Trim(); //分工
objzx_ResearchResultEN.VersionCount = objRow[conzx_ResearchResult.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ResearchResult.VersionCount].ToString().Trim()); //版本统计
objzx_ResearchResultEN.OkCount = objRow[conzx_ResearchResult.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ResearchResult.OkCount].ToString().Trim()); //点赞统计
objzx_ResearchResultEN.AppraiseCount = objRow[conzx_ResearchResult.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ResearchResult.AppraiseCount].ToString().Trim()); //评论数
objzx_ResearchResultEN.Score = objRow[conzx_ResearchResult.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_ResearchResult.Score].ToString().Trim()); //评分
objzx_ResearchResultEN.StuScore = objRow[conzx_ResearchResult.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_ResearchResult.StuScore].ToString().Trim()); //学生平均分
objzx_ResearchResultEN.TeaScore = objRow[conzx_ResearchResult.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_ResearchResult.TeaScore].ToString().Trim()); //教师评分
objzx_ResearchResultEN.UpdDate = objRow[conzx_ResearchResult.UpdDate] == DBNull.Value ? null : objRow[conzx_ResearchResult.UpdDate].ToString().Trim(); //修改日期
objzx_ResearchResultEN.UpdUser = objRow[conzx_ResearchResult.UpdUser] == DBNull.Value ? null : objRow[conzx_ResearchResult.UpdUser].ToString().Trim(); //修改人
objzx_ResearchResultEN.Memo = objRow[conzx_ResearchResult.Memo] == DBNull.Value ? null : objRow[conzx_ResearchResult.Memo].ToString().Trim(); //备注
objzx_ResearchResultEN.IdCurrEduCls = objRow[conzx_ResearchResult.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clszx_ResearchResultDA: GetObjLst)", objException.Message));
}
objzx_ResearchResultEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objzx_ResearchResultEN);
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
public List<clszx_ResearchResultEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clszx_ResearchResultDA:GetObjLstByTabName)", objException.Message));
}
List<clszx_ResearchResultEN> arrObjLst = new List<clszx_ResearchResultEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ResearchResultDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ResearchResultEN objzx_ResearchResultEN = new clszx_ResearchResultEN();
try
{
objzx_ResearchResultEN.zxResultId = objRow[conzx_ResearchResult.zxResultId].ToString().Trim(); //成果Id
objzx_ResearchResultEN.GroupTextId = objRow[conzx_ResearchResult.GroupTextId] == DBNull.Value ? null : objRow[conzx_ResearchResult.GroupTextId].ToString().Trim(); //小组Id
objzx_ResearchResultEN.TextId = objRow[conzx_ResearchResult.TextId] == DBNull.Value ? null : objRow[conzx_ResearchResult.TextId].ToString().Trim(); //课件Id
objzx_ResearchResultEN.ResultTypeId = objRow[conzx_ResearchResult.ResultTypeId] == DBNull.Value ? null : objRow[conzx_ResearchResult.ResultTypeId].ToString().Trim(); //成果类型Id
objzx_ResearchResultEN.ResultName = objRow[conzx_ResearchResult.ResultName] == DBNull.Value ? null : objRow[conzx_ResearchResult.ResultName].ToString().Trim(); //成果名称
objzx_ResearchResultEN.ResultContent = objRow[conzx_ResearchResult.ResultContent] == DBNull.Value ? null : objRow[conzx_ResearchResult.ResultContent].ToString().Trim(); //成果内容
objzx_ResearchResultEN.Author = objRow[conzx_ResearchResult.Author] == DBNull.Value ? null : objRow[conzx_ResearchResult.Author].ToString().Trim(); //作者
objzx_ResearchResultEN.Division = objRow[conzx_ResearchResult.Division] == DBNull.Value ? null : objRow[conzx_ResearchResult.Division].ToString().Trim(); //分工
objzx_ResearchResultEN.VersionCount = objRow[conzx_ResearchResult.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ResearchResult.VersionCount].ToString().Trim()); //版本统计
objzx_ResearchResultEN.OkCount = objRow[conzx_ResearchResult.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ResearchResult.OkCount].ToString().Trim()); //点赞统计
objzx_ResearchResultEN.AppraiseCount = objRow[conzx_ResearchResult.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ResearchResult.AppraiseCount].ToString().Trim()); //评论数
objzx_ResearchResultEN.Score = objRow[conzx_ResearchResult.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_ResearchResult.Score].ToString().Trim()); //评分
objzx_ResearchResultEN.StuScore = objRow[conzx_ResearchResult.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_ResearchResult.StuScore].ToString().Trim()); //学生平均分
objzx_ResearchResultEN.TeaScore = objRow[conzx_ResearchResult.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_ResearchResult.TeaScore].ToString().Trim()); //教师评分
objzx_ResearchResultEN.UpdDate = objRow[conzx_ResearchResult.UpdDate] == DBNull.Value ? null : objRow[conzx_ResearchResult.UpdDate].ToString().Trim(); //修改日期
objzx_ResearchResultEN.UpdUser = objRow[conzx_ResearchResult.UpdUser] == DBNull.Value ? null : objRow[conzx_ResearchResult.UpdUser].ToString().Trim(); //修改人
objzx_ResearchResultEN.Memo = objRow[conzx_ResearchResult.Memo] == DBNull.Value ? null : objRow[conzx_ResearchResult.Memo].ToString().Trim(); //备注
objzx_ResearchResultEN.IdCurrEduCls = objRow[conzx_ResearchResult.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clszx_ResearchResultDA: GetObjLst)", objException.Message));
}
objzx_ResearchResultEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objzx_ResearchResultEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objzx_ResearchResultEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getzx_ResearchResult(ref clszx_ResearchResultEN objzx_ResearchResultEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ResearchResultDA.GetSpecSQLObj();
strSQL = "Select * from zx_ResearchResult where zxResultId = " + "'"+ objzx_ResearchResultEN.zxResultId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objzx_ResearchResultEN.zxResultId = objDT.Rows[0][conzx_ResearchResult.zxResultId].ToString().Trim(); //成果Id(字段类型:char,字段长度:10,是否可空:False)
 objzx_ResearchResultEN.GroupTextId = objDT.Rows[0][conzx_ResearchResult.GroupTextId].ToString().Trim(); //小组Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_ResearchResultEN.TextId = objDT.Rows[0][conzx_ResearchResult.TextId].ToString().Trim(); //课件Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_ResearchResultEN.ResultTypeId = objDT.Rows[0][conzx_ResearchResult.ResultTypeId].ToString().Trim(); //成果类型Id(字段类型:char,字段长度:2,是否可空:True)
 objzx_ResearchResultEN.ResultName = objDT.Rows[0][conzx_ResearchResult.ResultName].ToString().Trim(); //成果名称(字段类型:varchar,字段长度:500,是否可空:True)
 objzx_ResearchResultEN.ResultContent = objDT.Rows[0][conzx_ResearchResult.ResultContent].ToString().Trim(); //成果内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objzx_ResearchResultEN.Author = objDT.Rows[0][conzx_ResearchResult.Author].ToString().Trim(); //作者(字段类型:varchar,字段长度:200,是否可空:True)
 objzx_ResearchResultEN.Division = objDT.Rows[0][conzx_ResearchResult.Division].ToString().Trim(); //分工(字段类型:varchar,字段长度:500,是否可空:True)
 objzx_ResearchResultEN.VersionCount = TransNullToInt(objDT.Rows[0][conzx_ResearchResult.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objzx_ResearchResultEN.OkCount = TransNullToInt(objDT.Rows[0][conzx_ResearchResult.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objzx_ResearchResultEN.AppraiseCount = TransNullToInt(objDT.Rows[0][conzx_ResearchResult.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objzx_ResearchResultEN.Score = TransNullToFloat(objDT.Rows[0][conzx_ResearchResult.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objzx_ResearchResultEN.StuScore = TransNullToFloat(objDT.Rows[0][conzx_ResearchResult.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objzx_ResearchResultEN.TeaScore = TransNullToFloat(objDT.Rows[0][conzx_ResearchResult.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objzx_ResearchResultEN.UpdDate = objDT.Rows[0][conzx_ResearchResult.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_ResearchResultEN.UpdUser = objDT.Rows[0][conzx_ResearchResult.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_ResearchResultEN.Memo = objDT.Rows[0][conzx_ResearchResult.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_ResearchResultEN.IdCurrEduCls = objDT.Rows[0][conzx_ResearchResult.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clszx_ResearchResultDA: Getzx_ResearchResult)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strzxResultId">表关键字</param>
 /// <returns>表对象</returns>
public clszx_ResearchResultEN GetObjByzxResultId(string strzxResultId)
{
CheckPrimaryKey(strzxResultId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ResearchResultDA.GetSpecSQLObj();
strSQL = "Select * from zx_ResearchResult where zxResultId = " + "'"+ strzxResultId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clszx_ResearchResultEN objzx_ResearchResultEN = new clszx_ResearchResultEN();
try
{
 objzx_ResearchResultEN.zxResultId = objRow[conzx_ResearchResult.zxResultId].ToString().Trim(); //成果Id(字段类型:char,字段长度:10,是否可空:False)
 objzx_ResearchResultEN.GroupTextId = objRow[conzx_ResearchResult.GroupTextId] == DBNull.Value ? null : objRow[conzx_ResearchResult.GroupTextId].ToString().Trim(); //小组Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_ResearchResultEN.TextId = objRow[conzx_ResearchResult.TextId] == DBNull.Value ? null : objRow[conzx_ResearchResult.TextId].ToString().Trim(); //课件Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_ResearchResultEN.ResultTypeId = objRow[conzx_ResearchResult.ResultTypeId] == DBNull.Value ? null : objRow[conzx_ResearchResult.ResultTypeId].ToString().Trim(); //成果类型Id(字段类型:char,字段长度:2,是否可空:True)
 objzx_ResearchResultEN.ResultName = objRow[conzx_ResearchResult.ResultName] == DBNull.Value ? null : objRow[conzx_ResearchResult.ResultName].ToString().Trim(); //成果名称(字段类型:varchar,字段长度:500,是否可空:True)
 objzx_ResearchResultEN.ResultContent = objRow[conzx_ResearchResult.ResultContent] == DBNull.Value ? null : objRow[conzx_ResearchResult.ResultContent].ToString().Trim(); //成果内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objzx_ResearchResultEN.Author = objRow[conzx_ResearchResult.Author] == DBNull.Value ? null : objRow[conzx_ResearchResult.Author].ToString().Trim(); //作者(字段类型:varchar,字段长度:200,是否可空:True)
 objzx_ResearchResultEN.Division = objRow[conzx_ResearchResult.Division] == DBNull.Value ? null : objRow[conzx_ResearchResult.Division].ToString().Trim(); //分工(字段类型:varchar,字段长度:500,是否可空:True)
 objzx_ResearchResultEN.VersionCount = objRow[conzx_ResearchResult.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ResearchResult.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objzx_ResearchResultEN.OkCount = objRow[conzx_ResearchResult.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ResearchResult.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objzx_ResearchResultEN.AppraiseCount = objRow[conzx_ResearchResult.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ResearchResult.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objzx_ResearchResultEN.Score = objRow[conzx_ResearchResult.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ResearchResult.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objzx_ResearchResultEN.StuScore = objRow[conzx_ResearchResult.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ResearchResult.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objzx_ResearchResultEN.TeaScore = objRow[conzx_ResearchResult.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ResearchResult.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objzx_ResearchResultEN.UpdDate = objRow[conzx_ResearchResult.UpdDate] == DBNull.Value ? null : objRow[conzx_ResearchResult.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_ResearchResultEN.UpdUser = objRow[conzx_ResearchResult.UpdUser] == DBNull.Value ? null : objRow[conzx_ResearchResult.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_ResearchResultEN.Memo = objRow[conzx_ResearchResult.Memo] == DBNull.Value ? null : objRow[conzx_ResearchResult.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_ResearchResultEN.IdCurrEduCls = objRow[conzx_ResearchResult.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clszx_ResearchResultDA: GetObjByzxResultId)", objException.Message));
}
return objzx_ResearchResultEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clszx_ResearchResultEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clszx_ResearchResultDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ResearchResultDA.GetSpecSQLObj();
strSQL = "Select * from zx_ResearchResult where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clszx_ResearchResultEN objzx_ResearchResultEN = new clszx_ResearchResultEN()
{
zxResultId = objRow[conzx_ResearchResult.zxResultId].ToString().Trim(), //成果Id
GroupTextId = objRow[conzx_ResearchResult.GroupTextId] == DBNull.Value ? null : objRow[conzx_ResearchResult.GroupTextId].ToString().Trim(), //小组Id
TextId = objRow[conzx_ResearchResult.TextId] == DBNull.Value ? null : objRow[conzx_ResearchResult.TextId].ToString().Trim(), //课件Id
ResultTypeId = objRow[conzx_ResearchResult.ResultTypeId] == DBNull.Value ? null : objRow[conzx_ResearchResult.ResultTypeId].ToString().Trim(), //成果类型Id
ResultName = objRow[conzx_ResearchResult.ResultName] == DBNull.Value ? null : objRow[conzx_ResearchResult.ResultName].ToString().Trim(), //成果名称
ResultContent = objRow[conzx_ResearchResult.ResultContent] == DBNull.Value ? null : objRow[conzx_ResearchResult.ResultContent].ToString().Trim(), //成果内容
Author = objRow[conzx_ResearchResult.Author] == DBNull.Value ? null : objRow[conzx_ResearchResult.Author].ToString().Trim(), //作者
Division = objRow[conzx_ResearchResult.Division] == DBNull.Value ? null : objRow[conzx_ResearchResult.Division].ToString().Trim(), //分工
VersionCount = objRow[conzx_ResearchResult.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ResearchResult.VersionCount].ToString().Trim()), //版本统计
OkCount = objRow[conzx_ResearchResult.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ResearchResult.OkCount].ToString().Trim()), //点赞统计
AppraiseCount = objRow[conzx_ResearchResult.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ResearchResult.AppraiseCount].ToString().Trim()), //评论数
Score = objRow[conzx_ResearchResult.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_ResearchResult.Score].ToString().Trim()), //评分
StuScore = objRow[conzx_ResearchResult.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_ResearchResult.StuScore].ToString().Trim()), //学生平均分
TeaScore = objRow[conzx_ResearchResult.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_ResearchResult.TeaScore].ToString().Trim()), //教师评分
UpdDate = objRow[conzx_ResearchResult.UpdDate] == DBNull.Value ? null : objRow[conzx_ResearchResult.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conzx_ResearchResult.UpdUser] == DBNull.Value ? null : objRow[conzx_ResearchResult.UpdUser].ToString().Trim(), //修改人
Memo = objRow[conzx_ResearchResult.Memo] == DBNull.Value ? null : objRow[conzx_ResearchResult.Memo].ToString().Trim(), //备注
IdCurrEduCls = objRow[conzx_ResearchResult.IdCurrEduCls].ToString().Trim() //教学班流水号
};
objzx_ResearchResultEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_ResearchResultEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clszx_ResearchResultDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clszx_ResearchResultEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clszx_ResearchResultEN objzx_ResearchResultEN = new clszx_ResearchResultEN();
try
{
objzx_ResearchResultEN.zxResultId = objRow[conzx_ResearchResult.zxResultId].ToString().Trim(); //成果Id
objzx_ResearchResultEN.GroupTextId = objRow[conzx_ResearchResult.GroupTextId] == DBNull.Value ? null : objRow[conzx_ResearchResult.GroupTextId].ToString().Trim(); //小组Id
objzx_ResearchResultEN.TextId = objRow[conzx_ResearchResult.TextId] == DBNull.Value ? null : objRow[conzx_ResearchResult.TextId].ToString().Trim(); //课件Id
objzx_ResearchResultEN.ResultTypeId = objRow[conzx_ResearchResult.ResultTypeId] == DBNull.Value ? null : objRow[conzx_ResearchResult.ResultTypeId].ToString().Trim(); //成果类型Id
objzx_ResearchResultEN.ResultName = objRow[conzx_ResearchResult.ResultName] == DBNull.Value ? null : objRow[conzx_ResearchResult.ResultName].ToString().Trim(); //成果名称
objzx_ResearchResultEN.ResultContent = objRow[conzx_ResearchResult.ResultContent] == DBNull.Value ? null : objRow[conzx_ResearchResult.ResultContent].ToString().Trim(); //成果内容
objzx_ResearchResultEN.Author = objRow[conzx_ResearchResult.Author] == DBNull.Value ? null : objRow[conzx_ResearchResult.Author].ToString().Trim(); //作者
objzx_ResearchResultEN.Division = objRow[conzx_ResearchResult.Division] == DBNull.Value ? null : objRow[conzx_ResearchResult.Division].ToString().Trim(); //分工
objzx_ResearchResultEN.VersionCount = objRow[conzx_ResearchResult.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ResearchResult.VersionCount].ToString().Trim()); //版本统计
objzx_ResearchResultEN.OkCount = objRow[conzx_ResearchResult.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ResearchResult.OkCount].ToString().Trim()); //点赞统计
objzx_ResearchResultEN.AppraiseCount = objRow[conzx_ResearchResult.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ResearchResult.AppraiseCount].ToString().Trim()); //评论数
objzx_ResearchResultEN.Score = objRow[conzx_ResearchResult.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_ResearchResult.Score].ToString().Trim()); //评分
objzx_ResearchResultEN.StuScore = objRow[conzx_ResearchResult.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_ResearchResult.StuScore].ToString().Trim()); //学生平均分
objzx_ResearchResultEN.TeaScore = objRow[conzx_ResearchResult.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_ResearchResult.TeaScore].ToString().Trim()); //教师评分
objzx_ResearchResultEN.UpdDate = objRow[conzx_ResearchResult.UpdDate] == DBNull.Value ? null : objRow[conzx_ResearchResult.UpdDate].ToString().Trim(); //修改日期
objzx_ResearchResultEN.UpdUser = objRow[conzx_ResearchResult.UpdUser] == DBNull.Value ? null : objRow[conzx_ResearchResult.UpdUser].ToString().Trim(); //修改人
objzx_ResearchResultEN.Memo = objRow[conzx_ResearchResult.Memo] == DBNull.Value ? null : objRow[conzx_ResearchResult.Memo].ToString().Trim(); //备注
objzx_ResearchResultEN.IdCurrEduCls = objRow[conzx_ResearchResult.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clszx_ResearchResultDA: GetObjByDataRowzx_ResearchResult)", objException.Message));
}
objzx_ResearchResultEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_ResearchResultEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clszx_ResearchResultEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clszx_ResearchResultEN objzx_ResearchResultEN = new clszx_ResearchResultEN();
try
{
objzx_ResearchResultEN.zxResultId = objRow[conzx_ResearchResult.zxResultId].ToString().Trim(); //成果Id
objzx_ResearchResultEN.GroupTextId = objRow[conzx_ResearchResult.GroupTextId] == DBNull.Value ? null : objRow[conzx_ResearchResult.GroupTextId].ToString().Trim(); //小组Id
objzx_ResearchResultEN.TextId = objRow[conzx_ResearchResult.TextId] == DBNull.Value ? null : objRow[conzx_ResearchResult.TextId].ToString().Trim(); //课件Id
objzx_ResearchResultEN.ResultTypeId = objRow[conzx_ResearchResult.ResultTypeId] == DBNull.Value ? null : objRow[conzx_ResearchResult.ResultTypeId].ToString().Trim(); //成果类型Id
objzx_ResearchResultEN.ResultName = objRow[conzx_ResearchResult.ResultName] == DBNull.Value ? null : objRow[conzx_ResearchResult.ResultName].ToString().Trim(); //成果名称
objzx_ResearchResultEN.ResultContent = objRow[conzx_ResearchResult.ResultContent] == DBNull.Value ? null : objRow[conzx_ResearchResult.ResultContent].ToString().Trim(); //成果内容
objzx_ResearchResultEN.Author = objRow[conzx_ResearchResult.Author] == DBNull.Value ? null : objRow[conzx_ResearchResult.Author].ToString().Trim(); //作者
objzx_ResearchResultEN.Division = objRow[conzx_ResearchResult.Division] == DBNull.Value ? null : objRow[conzx_ResearchResult.Division].ToString().Trim(); //分工
objzx_ResearchResultEN.VersionCount = objRow[conzx_ResearchResult.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ResearchResult.VersionCount].ToString().Trim()); //版本统计
objzx_ResearchResultEN.OkCount = objRow[conzx_ResearchResult.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ResearchResult.OkCount].ToString().Trim()); //点赞统计
objzx_ResearchResultEN.AppraiseCount = objRow[conzx_ResearchResult.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ResearchResult.AppraiseCount].ToString().Trim()); //评论数
objzx_ResearchResultEN.Score = objRow[conzx_ResearchResult.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_ResearchResult.Score].ToString().Trim()); //评分
objzx_ResearchResultEN.StuScore = objRow[conzx_ResearchResult.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_ResearchResult.StuScore].ToString().Trim()); //学生平均分
objzx_ResearchResultEN.TeaScore = objRow[conzx_ResearchResult.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_ResearchResult.TeaScore].ToString().Trim()); //教师评分
objzx_ResearchResultEN.UpdDate = objRow[conzx_ResearchResult.UpdDate] == DBNull.Value ? null : objRow[conzx_ResearchResult.UpdDate].ToString().Trim(); //修改日期
objzx_ResearchResultEN.UpdUser = objRow[conzx_ResearchResult.UpdUser] == DBNull.Value ? null : objRow[conzx_ResearchResult.UpdUser].ToString().Trim(); //修改人
objzx_ResearchResultEN.Memo = objRow[conzx_ResearchResult.Memo] == DBNull.Value ? null : objRow[conzx_ResearchResult.Memo].ToString().Trim(); //备注
objzx_ResearchResultEN.IdCurrEduCls = objRow[conzx_ResearchResult.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clszx_ResearchResultDA: GetObjByDataRow)", objException.Message));
}
objzx_ResearchResultEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_ResearchResultEN;
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
objSQL = clszx_ResearchResultDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clszx_ResearchResultEN._CurrTabName, conzx_ResearchResult.zxResultId, 10, "");
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
objSQL = clszx_ResearchResultDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clszx_ResearchResultEN._CurrTabName, conzx_ResearchResult.zxResultId, 10, strPrefix);
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
 objSQL = clszx_ResearchResultDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select zxResultId from zx_ResearchResult where " + strCondition;
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
 objSQL = clszx_ResearchResultDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select zxResultId from zx_ResearchResult where " + strCondition;
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
 /// <param name = "strzxResultId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strzxResultId)
{
CheckPrimaryKey(strzxResultId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ResearchResultDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("zx_ResearchResult", "zxResultId = " + "'"+ strzxResultId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clszx_ResearchResultDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ResearchResultDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("zx_ResearchResult", strCondition))
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
objSQL = clszx_ResearchResultDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("zx_ResearchResult");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clszx_ResearchResultEN objzx_ResearchResultEN)
 {
 if (objzx_ResearchResultEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_ResearchResultEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ResearchResultDA.GetSpecSQLObj();
strSQL = "Select * from zx_ResearchResult where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "zx_ResearchResult");
objRow = objDS.Tables["zx_ResearchResult"].NewRow();
objRow[conzx_ResearchResult.zxResultId] = objzx_ResearchResultEN.zxResultId; //成果Id
 if (objzx_ResearchResultEN.GroupTextId !=  "")
 {
objRow[conzx_ResearchResult.GroupTextId] = objzx_ResearchResultEN.GroupTextId; //小组Id
 }
 if (objzx_ResearchResultEN.TextId !=  "")
 {
objRow[conzx_ResearchResult.TextId] = objzx_ResearchResultEN.TextId; //课件Id
 }
 if (objzx_ResearchResultEN.ResultTypeId !=  "")
 {
objRow[conzx_ResearchResult.ResultTypeId] = objzx_ResearchResultEN.ResultTypeId; //成果类型Id
 }
 if (objzx_ResearchResultEN.ResultName !=  "")
 {
objRow[conzx_ResearchResult.ResultName] = objzx_ResearchResultEN.ResultName; //成果名称
 }
 if (objzx_ResearchResultEN.ResultContent !=  "")
 {
objRow[conzx_ResearchResult.ResultContent] = objzx_ResearchResultEN.ResultContent; //成果内容
 }
 if (objzx_ResearchResultEN.Author !=  "")
 {
objRow[conzx_ResearchResult.Author] = objzx_ResearchResultEN.Author; //作者
 }
 if (objzx_ResearchResultEN.Division !=  "")
 {
objRow[conzx_ResearchResult.Division] = objzx_ResearchResultEN.Division; //分工
 }
objRow[conzx_ResearchResult.VersionCount] = objzx_ResearchResultEN.VersionCount; //版本统计
objRow[conzx_ResearchResult.OkCount] = objzx_ResearchResultEN.OkCount; //点赞统计
objRow[conzx_ResearchResult.AppraiseCount] = objzx_ResearchResultEN.AppraiseCount; //评论数
objRow[conzx_ResearchResult.Score] = objzx_ResearchResultEN.Score; //评分
objRow[conzx_ResearchResult.StuScore] = objzx_ResearchResultEN.StuScore; //学生平均分
objRow[conzx_ResearchResult.TeaScore] = objzx_ResearchResultEN.TeaScore; //教师评分
 if (objzx_ResearchResultEN.UpdDate !=  "")
 {
objRow[conzx_ResearchResult.UpdDate] = objzx_ResearchResultEN.UpdDate; //修改日期
 }
 if (objzx_ResearchResultEN.UpdUser !=  "")
 {
objRow[conzx_ResearchResult.UpdUser] = objzx_ResearchResultEN.UpdUser; //修改人
 }
 if (objzx_ResearchResultEN.Memo !=  "")
 {
objRow[conzx_ResearchResult.Memo] = objzx_ResearchResultEN.Memo; //备注
 }
objRow[conzx_ResearchResult.IdCurrEduCls] = objzx_ResearchResultEN.IdCurrEduCls; //教学班流水号
objDS.Tables[clszx_ResearchResultEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clszx_ResearchResultEN._CurrTabName);
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
 /// <param name = "objzx_ResearchResultEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clszx_ResearchResultEN objzx_ResearchResultEN)
{
 if (objzx_ResearchResultEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_ResearchResultEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_ResearchResultEN.zxResultId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchResult.zxResultId);
 var strzxResultId = objzx_ResearchResultEN.zxResultId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxResultId + "'");
 }
 
 if (objzx_ResearchResultEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchResult.GroupTextId);
 var strGroupTextId = objzx_ResearchResultEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 
 if (objzx_ResearchResultEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchResult.TextId);
 var strTextId = objzx_ResearchResultEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 if (objzx_ResearchResultEN.ResultTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchResult.ResultTypeId);
 var strResultTypeId = objzx_ResearchResultEN.ResultTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResultTypeId + "'");
 }
 
 if (objzx_ResearchResultEN.ResultName !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchResult.ResultName);
 var strResultName = objzx_ResearchResultEN.ResultName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResultName + "'");
 }
 
 if (objzx_ResearchResultEN.ResultContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchResult.ResultContent);
 var strResultContent = objzx_ResearchResultEN.ResultContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResultContent + "'");
 }
 
 if (objzx_ResearchResultEN.Author !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchResult.Author);
 var strAuthor = objzx_ResearchResultEN.Author.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAuthor + "'");
 }
 
 if (objzx_ResearchResultEN.Division !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchResult.Division);
 var strDivision = objzx_ResearchResultEN.Division.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDivision + "'");
 }
 
 if (objzx_ResearchResultEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchResult.VersionCount);
 arrValueListForInsert.Add(objzx_ResearchResultEN.VersionCount.ToString());
 }
 
 if (objzx_ResearchResultEN.OkCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchResult.OkCount);
 arrValueListForInsert.Add(objzx_ResearchResultEN.OkCount.ToString());
 }
 
 if (objzx_ResearchResultEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchResult.AppraiseCount);
 arrValueListForInsert.Add(objzx_ResearchResultEN.AppraiseCount.ToString());
 }
 
 if (objzx_ResearchResultEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchResult.Score);
 arrValueListForInsert.Add(objzx_ResearchResultEN.Score.ToString());
 }
 
 if (objzx_ResearchResultEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchResult.StuScore);
 arrValueListForInsert.Add(objzx_ResearchResultEN.StuScore.ToString());
 }
 
 if (objzx_ResearchResultEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchResult.TeaScore);
 arrValueListForInsert.Add(objzx_ResearchResultEN.TeaScore.ToString());
 }
 
 if (objzx_ResearchResultEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchResult.UpdDate);
 var strUpdDate = objzx_ResearchResultEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_ResearchResultEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchResult.UpdUser);
 var strUpdUser = objzx_ResearchResultEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_ResearchResultEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchResult.Memo);
 var strMemo = objzx_ResearchResultEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_ResearchResultEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchResult.IdCurrEduCls);
 var strIdCurrEduCls = objzx_ResearchResultEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_ResearchResult");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ResearchResultDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objzx_ResearchResultEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clszx_ResearchResultEN objzx_ResearchResultEN)
{
 if (objzx_ResearchResultEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_ResearchResultEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_ResearchResultEN.zxResultId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchResult.zxResultId);
 var strzxResultId = objzx_ResearchResultEN.zxResultId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxResultId + "'");
 }
 
 if (objzx_ResearchResultEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchResult.GroupTextId);
 var strGroupTextId = objzx_ResearchResultEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 
 if (objzx_ResearchResultEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchResult.TextId);
 var strTextId = objzx_ResearchResultEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 if (objzx_ResearchResultEN.ResultTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchResult.ResultTypeId);
 var strResultTypeId = objzx_ResearchResultEN.ResultTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResultTypeId + "'");
 }
 
 if (objzx_ResearchResultEN.ResultName !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchResult.ResultName);
 var strResultName = objzx_ResearchResultEN.ResultName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResultName + "'");
 }
 
 if (objzx_ResearchResultEN.ResultContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchResult.ResultContent);
 var strResultContent = objzx_ResearchResultEN.ResultContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResultContent + "'");
 }
 
 if (objzx_ResearchResultEN.Author !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchResult.Author);
 var strAuthor = objzx_ResearchResultEN.Author.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAuthor + "'");
 }
 
 if (objzx_ResearchResultEN.Division !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchResult.Division);
 var strDivision = objzx_ResearchResultEN.Division.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDivision + "'");
 }
 
 if (objzx_ResearchResultEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchResult.VersionCount);
 arrValueListForInsert.Add(objzx_ResearchResultEN.VersionCount.ToString());
 }
 
 if (objzx_ResearchResultEN.OkCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchResult.OkCount);
 arrValueListForInsert.Add(objzx_ResearchResultEN.OkCount.ToString());
 }
 
 if (objzx_ResearchResultEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchResult.AppraiseCount);
 arrValueListForInsert.Add(objzx_ResearchResultEN.AppraiseCount.ToString());
 }
 
 if (objzx_ResearchResultEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchResult.Score);
 arrValueListForInsert.Add(objzx_ResearchResultEN.Score.ToString());
 }
 
 if (objzx_ResearchResultEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchResult.StuScore);
 arrValueListForInsert.Add(objzx_ResearchResultEN.StuScore.ToString());
 }
 
 if (objzx_ResearchResultEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchResult.TeaScore);
 arrValueListForInsert.Add(objzx_ResearchResultEN.TeaScore.ToString());
 }
 
 if (objzx_ResearchResultEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchResult.UpdDate);
 var strUpdDate = objzx_ResearchResultEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_ResearchResultEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchResult.UpdUser);
 var strUpdUser = objzx_ResearchResultEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_ResearchResultEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchResult.Memo);
 var strMemo = objzx_ResearchResultEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_ResearchResultEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchResult.IdCurrEduCls);
 var strIdCurrEduCls = objzx_ResearchResultEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_ResearchResult");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ResearchResultDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objzx_ResearchResultEN.zxResultId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objzx_ResearchResultEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clszx_ResearchResultEN objzx_ResearchResultEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objzx_ResearchResultEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_ResearchResultEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_ResearchResultEN.zxResultId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchResult.zxResultId);
 var strzxResultId = objzx_ResearchResultEN.zxResultId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxResultId + "'");
 }
 
 if (objzx_ResearchResultEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchResult.GroupTextId);
 var strGroupTextId = objzx_ResearchResultEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 
 if (objzx_ResearchResultEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchResult.TextId);
 var strTextId = objzx_ResearchResultEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 if (objzx_ResearchResultEN.ResultTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchResult.ResultTypeId);
 var strResultTypeId = objzx_ResearchResultEN.ResultTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResultTypeId + "'");
 }
 
 if (objzx_ResearchResultEN.ResultName !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchResult.ResultName);
 var strResultName = objzx_ResearchResultEN.ResultName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResultName + "'");
 }
 
 if (objzx_ResearchResultEN.ResultContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchResult.ResultContent);
 var strResultContent = objzx_ResearchResultEN.ResultContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResultContent + "'");
 }
 
 if (objzx_ResearchResultEN.Author !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchResult.Author);
 var strAuthor = objzx_ResearchResultEN.Author.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAuthor + "'");
 }
 
 if (objzx_ResearchResultEN.Division !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchResult.Division);
 var strDivision = objzx_ResearchResultEN.Division.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDivision + "'");
 }
 
 if (objzx_ResearchResultEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchResult.VersionCount);
 arrValueListForInsert.Add(objzx_ResearchResultEN.VersionCount.ToString());
 }
 
 if (objzx_ResearchResultEN.OkCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchResult.OkCount);
 arrValueListForInsert.Add(objzx_ResearchResultEN.OkCount.ToString());
 }
 
 if (objzx_ResearchResultEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchResult.AppraiseCount);
 arrValueListForInsert.Add(objzx_ResearchResultEN.AppraiseCount.ToString());
 }
 
 if (objzx_ResearchResultEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchResult.Score);
 arrValueListForInsert.Add(objzx_ResearchResultEN.Score.ToString());
 }
 
 if (objzx_ResearchResultEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchResult.StuScore);
 arrValueListForInsert.Add(objzx_ResearchResultEN.StuScore.ToString());
 }
 
 if (objzx_ResearchResultEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchResult.TeaScore);
 arrValueListForInsert.Add(objzx_ResearchResultEN.TeaScore.ToString());
 }
 
 if (objzx_ResearchResultEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchResult.UpdDate);
 var strUpdDate = objzx_ResearchResultEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_ResearchResultEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchResult.UpdUser);
 var strUpdUser = objzx_ResearchResultEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_ResearchResultEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchResult.Memo);
 var strMemo = objzx_ResearchResultEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_ResearchResultEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchResult.IdCurrEduCls);
 var strIdCurrEduCls = objzx_ResearchResultEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_ResearchResult");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ResearchResultDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objzx_ResearchResultEN.zxResultId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objzx_ResearchResultEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clszx_ResearchResultEN objzx_ResearchResultEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objzx_ResearchResultEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_ResearchResultEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_ResearchResultEN.zxResultId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchResult.zxResultId);
 var strzxResultId = objzx_ResearchResultEN.zxResultId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxResultId + "'");
 }
 
 if (objzx_ResearchResultEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchResult.GroupTextId);
 var strGroupTextId = objzx_ResearchResultEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 
 if (objzx_ResearchResultEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchResult.TextId);
 var strTextId = objzx_ResearchResultEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 if (objzx_ResearchResultEN.ResultTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchResult.ResultTypeId);
 var strResultTypeId = objzx_ResearchResultEN.ResultTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResultTypeId + "'");
 }
 
 if (objzx_ResearchResultEN.ResultName !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchResult.ResultName);
 var strResultName = objzx_ResearchResultEN.ResultName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResultName + "'");
 }
 
 if (objzx_ResearchResultEN.ResultContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchResult.ResultContent);
 var strResultContent = objzx_ResearchResultEN.ResultContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResultContent + "'");
 }
 
 if (objzx_ResearchResultEN.Author !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchResult.Author);
 var strAuthor = objzx_ResearchResultEN.Author.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAuthor + "'");
 }
 
 if (objzx_ResearchResultEN.Division !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchResult.Division);
 var strDivision = objzx_ResearchResultEN.Division.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDivision + "'");
 }
 
 if (objzx_ResearchResultEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchResult.VersionCount);
 arrValueListForInsert.Add(objzx_ResearchResultEN.VersionCount.ToString());
 }
 
 if (objzx_ResearchResultEN.OkCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchResult.OkCount);
 arrValueListForInsert.Add(objzx_ResearchResultEN.OkCount.ToString());
 }
 
 if (objzx_ResearchResultEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchResult.AppraiseCount);
 arrValueListForInsert.Add(objzx_ResearchResultEN.AppraiseCount.ToString());
 }
 
 if (objzx_ResearchResultEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchResult.Score);
 arrValueListForInsert.Add(objzx_ResearchResultEN.Score.ToString());
 }
 
 if (objzx_ResearchResultEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchResult.StuScore);
 arrValueListForInsert.Add(objzx_ResearchResultEN.StuScore.ToString());
 }
 
 if (objzx_ResearchResultEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchResult.TeaScore);
 arrValueListForInsert.Add(objzx_ResearchResultEN.TeaScore.ToString());
 }
 
 if (objzx_ResearchResultEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchResult.UpdDate);
 var strUpdDate = objzx_ResearchResultEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_ResearchResultEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchResult.UpdUser);
 var strUpdUser = objzx_ResearchResultEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_ResearchResultEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchResult.Memo);
 var strMemo = objzx_ResearchResultEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_ResearchResultEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchResult.IdCurrEduCls);
 var strIdCurrEduCls = objzx_ResearchResultEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_ResearchResult");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ResearchResultDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewzx_ResearchResults(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ResearchResultDA.GetSpecSQLObj();
strSQL = "Select * from zx_ResearchResult where zxResultId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "zx_ResearchResult");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strzxResultId = oRow[conzx_ResearchResult.zxResultId].ToString().Trim();
if (IsExist(strzxResultId))
{
 string strResult = "关键字变量值为:" + string.Format("zxResultId = {0}", strzxResultId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clszx_ResearchResultEN._CurrTabName ].NewRow();
objRow[conzx_ResearchResult.zxResultId] = oRow[conzx_ResearchResult.zxResultId].ToString().Trim(); //成果Id
objRow[conzx_ResearchResult.GroupTextId] = oRow[conzx_ResearchResult.GroupTextId].ToString().Trim(); //小组Id
objRow[conzx_ResearchResult.TextId] = oRow[conzx_ResearchResult.TextId].ToString().Trim(); //课件Id
objRow[conzx_ResearchResult.ResultTypeId] = oRow[conzx_ResearchResult.ResultTypeId].ToString().Trim(); //成果类型Id
objRow[conzx_ResearchResult.ResultName] = oRow[conzx_ResearchResult.ResultName].ToString().Trim(); //成果名称
objRow[conzx_ResearchResult.ResultContent] = oRow[conzx_ResearchResult.ResultContent].ToString().Trim(); //成果内容
objRow[conzx_ResearchResult.Author] = oRow[conzx_ResearchResult.Author].ToString().Trim(); //作者
objRow[conzx_ResearchResult.Division] = oRow[conzx_ResearchResult.Division].ToString().Trim(); //分工
objRow[conzx_ResearchResult.VersionCount] = oRow[conzx_ResearchResult.VersionCount].ToString().Trim(); //版本统计
objRow[conzx_ResearchResult.OkCount] = oRow[conzx_ResearchResult.OkCount].ToString().Trim(); //点赞统计
objRow[conzx_ResearchResult.AppraiseCount] = oRow[conzx_ResearchResult.AppraiseCount].ToString().Trim(); //评论数
objRow[conzx_ResearchResult.Score] = oRow[conzx_ResearchResult.Score].ToString().Trim(); //评分
objRow[conzx_ResearchResult.StuScore] = oRow[conzx_ResearchResult.StuScore].ToString().Trim(); //学生平均分
objRow[conzx_ResearchResult.TeaScore] = oRow[conzx_ResearchResult.TeaScore].ToString().Trim(); //教师评分
objRow[conzx_ResearchResult.UpdDate] = oRow[conzx_ResearchResult.UpdDate].ToString().Trim(); //修改日期
objRow[conzx_ResearchResult.UpdUser] = oRow[conzx_ResearchResult.UpdUser].ToString().Trim(); //修改人
objRow[conzx_ResearchResult.Memo] = oRow[conzx_ResearchResult.Memo].ToString().Trim(); //备注
objRow[conzx_ResearchResult.IdCurrEduCls] = oRow[conzx_ResearchResult.IdCurrEduCls].ToString().Trim(); //教学班流水号
 objDS.Tables[clszx_ResearchResultEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clszx_ResearchResultEN._CurrTabName);
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
 /// <param name = "objzx_ResearchResultEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clszx_ResearchResultEN objzx_ResearchResultEN)
{
 if (objzx_ResearchResultEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_ResearchResultEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ResearchResultDA.GetSpecSQLObj();
strSQL = "Select * from zx_ResearchResult where zxResultId = " + "'"+ objzx_ResearchResultEN.zxResultId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clszx_ResearchResultEN._CurrTabName);
if (objDS.Tables[clszx_ResearchResultEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:zxResultId = " + "'"+ objzx_ResearchResultEN.zxResultId+"'");
return false;
}
objRow = objDS.Tables[clszx_ResearchResultEN._CurrTabName].Rows[0];
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.zxResultId))
 {
objRow[conzx_ResearchResult.zxResultId] = objzx_ResearchResultEN.zxResultId; //成果Id
 }
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.GroupTextId))
 {
objRow[conzx_ResearchResult.GroupTextId] = objzx_ResearchResultEN.GroupTextId; //小组Id
 }
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.TextId))
 {
objRow[conzx_ResearchResult.TextId] = objzx_ResearchResultEN.TextId; //课件Id
 }
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.ResultTypeId))
 {
objRow[conzx_ResearchResult.ResultTypeId] = objzx_ResearchResultEN.ResultTypeId; //成果类型Id
 }
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.ResultName))
 {
objRow[conzx_ResearchResult.ResultName] = objzx_ResearchResultEN.ResultName; //成果名称
 }
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.ResultContent))
 {
objRow[conzx_ResearchResult.ResultContent] = objzx_ResearchResultEN.ResultContent; //成果内容
 }
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.Author))
 {
objRow[conzx_ResearchResult.Author] = objzx_ResearchResultEN.Author; //作者
 }
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.Division))
 {
objRow[conzx_ResearchResult.Division] = objzx_ResearchResultEN.Division; //分工
 }
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.VersionCount))
 {
objRow[conzx_ResearchResult.VersionCount] = objzx_ResearchResultEN.VersionCount; //版本统计
 }
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.OkCount))
 {
objRow[conzx_ResearchResult.OkCount] = objzx_ResearchResultEN.OkCount; //点赞统计
 }
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.AppraiseCount))
 {
objRow[conzx_ResearchResult.AppraiseCount] = objzx_ResearchResultEN.AppraiseCount; //评论数
 }
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.Score))
 {
objRow[conzx_ResearchResult.Score] = objzx_ResearchResultEN.Score; //评分
 }
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.StuScore))
 {
objRow[conzx_ResearchResult.StuScore] = objzx_ResearchResultEN.StuScore; //学生平均分
 }
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.TeaScore))
 {
objRow[conzx_ResearchResult.TeaScore] = objzx_ResearchResultEN.TeaScore; //教师评分
 }
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.UpdDate))
 {
objRow[conzx_ResearchResult.UpdDate] = objzx_ResearchResultEN.UpdDate; //修改日期
 }
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.UpdUser))
 {
objRow[conzx_ResearchResult.UpdUser] = objzx_ResearchResultEN.UpdUser; //修改人
 }
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.Memo))
 {
objRow[conzx_ResearchResult.Memo] = objzx_ResearchResultEN.Memo; //备注
 }
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.IdCurrEduCls))
 {
objRow[conzx_ResearchResult.IdCurrEduCls] = objzx_ResearchResultEN.IdCurrEduCls; //教学班流水号
 }
try
{
objDA.Update(objDS, clszx_ResearchResultEN._CurrTabName);
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
 /// <param name = "objzx_ResearchResultEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clszx_ResearchResultEN objzx_ResearchResultEN)
{
 if (objzx_ResearchResultEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_ResearchResultEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ResearchResultDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update zx_ResearchResult Set ");
 
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.GroupTextId))
 {
 if (objzx_ResearchResultEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_ResearchResultEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGroupTextId, conzx_ResearchResult.GroupTextId); //小组Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ResearchResult.GroupTextId); //小组Id
 }
 }
 
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.TextId))
 {
 if (objzx_ResearchResultEN.TextId !=  null)
 {
 var strTextId = objzx_ResearchResultEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTextId, conzx_ResearchResult.TextId); //课件Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ResearchResult.TextId); //课件Id
 }
 }
 
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.ResultTypeId))
 {
 if (objzx_ResearchResultEN.ResultTypeId !=  null)
 {
 var strResultTypeId = objzx_ResearchResultEN.ResultTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResultTypeId, conzx_ResearchResult.ResultTypeId); //成果类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ResearchResult.ResultTypeId); //成果类型Id
 }
 }
 
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.ResultName))
 {
 if (objzx_ResearchResultEN.ResultName !=  null)
 {
 var strResultName = objzx_ResearchResultEN.ResultName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResultName, conzx_ResearchResult.ResultName); //成果名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ResearchResult.ResultName); //成果名称
 }
 }
 
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.ResultContent))
 {
 if (objzx_ResearchResultEN.ResultContent !=  null)
 {
 var strResultContent = objzx_ResearchResultEN.ResultContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResultContent, conzx_ResearchResult.ResultContent); //成果内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ResearchResult.ResultContent); //成果内容
 }
 }
 
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.Author))
 {
 if (objzx_ResearchResultEN.Author !=  null)
 {
 var strAuthor = objzx_ResearchResultEN.Author.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAuthor, conzx_ResearchResult.Author); //作者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ResearchResult.Author); //作者
 }
 }
 
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.Division))
 {
 if (objzx_ResearchResultEN.Division !=  null)
 {
 var strDivision = objzx_ResearchResultEN.Division.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDivision, conzx_ResearchResult.Division); //分工
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ResearchResult.Division); //分工
 }
 }
 
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.VersionCount))
 {
 if (objzx_ResearchResultEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ResearchResultEN.VersionCount, conzx_ResearchResult.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ResearchResult.VersionCount); //版本统计
 }
 }
 
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.OkCount))
 {
 if (objzx_ResearchResultEN.OkCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ResearchResultEN.OkCount, conzx_ResearchResult.OkCount); //点赞统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ResearchResult.OkCount); //点赞统计
 }
 }
 
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.AppraiseCount))
 {
 if (objzx_ResearchResultEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ResearchResultEN.AppraiseCount, conzx_ResearchResult.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ResearchResult.AppraiseCount); //评论数
 }
 }
 
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.Score))
 {
 if (objzx_ResearchResultEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ResearchResultEN.Score, conzx_ResearchResult.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ResearchResult.Score); //评分
 }
 }
 
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.StuScore))
 {
 if (objzx_ResearchResultEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ResearchResultEN.StuScore, conzx_ResearchResult.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ResearchResult.StuScore); //学生平均分
 }
 }
 
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.TeaScore))
 {
 if (objzx_ResearchResultEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ResearchResultEN.TeaScore, conzx_ResearchResult.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ResearchResult.TeaScore); //教师评分
 }
 }
 
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.UpdDate))
 {
 if (objzx_ResearchResultEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_ResearchResultEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conzx_ResearchResult.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ResearchResult.UpdDate); //修改日期
 }
 }
 
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.UpdUser))
 {
 if (objzx_ResearchResultEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_ResearchResultEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conzx_ResearchResult.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ResearchResult.UpdUser); //修改人
 }
 }
 
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.Memo))
 {
 if (objzx_ResearchResultEN.Memo !=  null)
 {
 var strMemo = objzx_ResearchResultEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conzx_ResearchResult.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ResearchResult.Memo); //备注
 }
 }
 
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.IdCurrEduCls))
 {
 if (objzx_ResearchResultEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_ResearchResultEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conzx_ResearchResult.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ResearchResult.IdCurrEduCls); //教学班流水号
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where zxResultId = '{0}'", objzx_ResearchResultEN.zxResultId); 
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
 /// <param name = "objzx_ResearchResultEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clszx_ResearchResultEN objzx_ResearchResultEN, string strCondition)
{
 if (objzx_ResearchResultEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_ResearchResultEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ResearchResultDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_ResearchResult Set ");
 
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.GroupTextId))
 {
 if (objzx_ResearchResultEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_ResearchResultEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GroupTextId = '{0}',", strGroupTextId); //小组Id
 }
 else
 {
 sbSQL.Append(" GroupTextId = null,"); //小组Id
 }
 }
 
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.TextId))
 {
 if (objzx_ResearchResultEN.TextId !=  null)
 {
 var strTextId = objzx_ResearchResultEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TextId = '{0}',", strTextId); //课件Id
 }
 else
 {
 sbSQL.Append(" TextId = null,"); //课件Id
 }
 }
 
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.ResultTypeId))
 {
 if (objzx_ResearchResultEN.ResultTypeId !=  null)
 {
 var strResultTypeId = objzx_ResearchResultEN.ResultTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResultTypeId = '{0}',", strResultTypeId); //成果类型Id
 }
 else
 {
 sbSQL.Append(" ResultTypeId = null,"); //成果类型Id
 }
 }
 
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.ResultName))
 {
 if (objzx_ResearchResultEN.ResultName !=  null)
 {
 var strResultName = objzx_ResearchResultEN.ResultName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResultName = '{0}',", strResultName); //成果名称
 }
 else
 {
 sbSQL.Append(" ResultName = null,"); //成果名称
 }
 }
 
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.ResultContent))
 {
 if (objzx_ResearchResultEN.ResultContent !=  null)
 {
 var strResultContent = objzx_ResearchResultEN.ResultContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResultContent = '{0}',", strResultContent); //成果内容
 }
 else
 {
 sbSQL.Append(" ResultContent = null,"); //成果内容
 }
 }
 
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.Author))
 {
 if (objzx_ResearchResultEN.Author !=  null)
 {
 var strAuthor = objzx_ResearchResultEN.Author.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Author = '{0}',", strAuthor); //作者
 }
 else
 {
 sbSQL.Append(" Author = null,"); //作者
 }
 }
 
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.Division))
 {
 if (objzx_ResearchResultEN.Division !=  null)
 {
 var strDivision = objzx_ResearchResultEN.Division.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Division = '{0}',", strDivision); //分工
 }
 else
 {
 sbSQL.Append(" Division = null,"); //分工
 }
 }
 
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.VersionCount))
 {
 if (objzx_ResearchResultEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ResearchResultEN.VersionCount, conzx_ResearchResult.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ResearchResult.VersionCount); //版本统计
 }
 }
 
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.OkCount))
 {
 if (objzx_ResearchResultEN.OkCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ResearchResultEN.OkCount, conzx_ResearchResult.OkCount); //点赞统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ResearchResult.OkCount); //点赞统计
 }
 }
 
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.AppraiseCount))
 {
 if (objzx_ResearchResultEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ResearchResultEN.AppraiseCount, conzx_ResearchResult.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ResearchResult.AppraiseCount); //评论数
 }
 }
 
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.Score))
 {
 if (objzx_ResearchResultEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ResearchResultEN.Score, conzx_ResearchResult.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ResearchResult.Score); //评分
 }
 }
 
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.StuScore))
 {
 if (objzx_ResearchResultEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ResearchResultEN.StuScore, conzx_ResearchResult.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ResearchResult.StuScore); //学生平均分
 }
 }
 
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.TeaScore))
 {
 if (objzx_ResearchResultEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ResearchResultEN.TeaScore, conzx_ResearchResult.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ResearchResult.TeaScore); //教师评分
 }
 }
 
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.UpdDate))
 {
 if (objzx_ResearchResultEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_ResearchResultEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.UpdUser))
 {
 if (objzx_ResearchResultEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_ResearchResultEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.Memo))
 {
 if (objzx_ResearchResultEN.Memo !=  null)
 {
 var strMemo = objzx_ResearchResultEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.IdCurrEduCls))
 {
 if (objzx_ResearchResultEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_ResearchResultEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
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
 /// <param name = "objzx_ResearchResultEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clszx_ResearchResultEN objzx_ResearchResultEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objzx_ResearchResultEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_ResearchResultEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ResearchResultDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_ResearchResult Set ");
 
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.GroupTextId))
 {
 if (objzx_ResearchResultEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_ResearchResultEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GroupTextId = '{0}',", strGroupTextId); //小组Id
 }
 else
 {
 sbSQL.Append(" GroupTextId = null,"); //小组Id
 }
 }
 
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.TextId))
 {
 if (objzx_ResearchResultEN.TextId !=  null)
 {
 var strTextId = objzx_ResearchResultEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TextId = '{0}',", strTextId); //课件Id
 }
 else
 {
 sbSQL.Append(" TextId = null,"); //课件Id
 }
 }
 
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.ResultTypeId))
 {
 if (objzx_ResearchResultEN.ResultTypeId !=  null)
 {
 var strResultTypeId = objzx_ResearchResultEN.ResultTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResultTypeId = '{0}',", strResultTypeId); //成果类型Id
 }
 else
 {
 sbSQL.Append(" ResultTypeId = null,"); //成果类型Id
 }
 }
 
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.ResultName))
 {
 if (objzx_ResearchResultEN.ResultName !=  null)
 {
 var strResultName = objzx_ResearchResultEN.ResultName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResultName = '{0}',", strResultName); //成果名称
 }
 else
 {
 sbSQL.Append(" ResultName = null,"); //成果名称
 }
 }
 
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.ResultContent))
 {
 if (objzx_ResearchResultEN.ResultContent !=  null)
 {
 var strResultContent = objzx_ResearchResultEN.ResultContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResultContent = '{0}',", strResultContent); //成果内容
 }
 else
 {
 sbSQL.Append(" ResultContent = null,"); //成果内容
 }
 }
 
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.Author))
 {
 if (objzx_ResearchResultEN.Author !=  null)
 {
 var strAuthor = objzx_ResearchResultEN.Author.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Author = '{0}',", strAuthor); //作者
 }
 else
 {
 sbSQL.Append(" Author = null,"); //作者
 }
 }
 
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.Division))
 {
 if (objzx_ResearchResultEN.Division !=  null)
 {
 var strDivision = objzx_ResearchResultEN.Division.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Division = '{0}',", strDivision); //分工
 }
 else
 {
 sbSQL.Append(" Division = null,"); //分工
 }
 }
 
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.VersionCount))
 {
 if (objzx_ResearchResultEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ResearchResultEN.VersionCount, conzx_ResearchResult.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ResearchResult.VersionCount); //版本统计
 }
 }
 
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.OkCount))
 {
 if (objzx_ResearchResultEN.OkCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ResearchResultEN.OkCount, conzx_ResearchResult.OkCount); //点赞统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ResearchResult.OkCount); //点赞统计
 }
 }
 
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.AppraiseCount))
 {
 if (objzx_ResearchResultEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ResearchResultEN.AppraiseCount, conzx_ResearchResult.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ResearchResult.AppraiseCount); //评论数
 }
 }
 
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.Score))
 {
 if (objzx_ResearchResultEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ResearchResultEN.Score, conzx_ResearchResult.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ResearchResult.Score); //评分
 }
 }
 
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.StuScore))
 {
 if (objzx_ResearchResultEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ResearchResultEN.StuScore, conzx_ResearchResult.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ResearchResult.StuScore); //学生平均分
 }
 }
 
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.TeaScore))
 {
 if (objzx_ResearchResultEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ResearchResultEN.TeaScore, conzx_ResearchResult.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ResearchResult.TeaScore); //教师评分
 }
 }
 
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.UpdDate))
 {
 if (objzx_ResearchResultEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_ResearchResultEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.UpdUser))
 {
 if (objzx_ResearchResultEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_ResearchResultEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.Memo))
 {
 if (objzx_ResearchResultEN.Memo !=  null)
 {
 var strMemo = objzx_ResearchResultEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.IdCurrEduCls))
 {
 if (objzx_ResearchResultEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_ResearchResultEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
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
 /// <param name = "objzx_ResearchResultEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clszx_ResearchResultEN objzx_ResearchResultEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objzx_ResearchResultEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_ResearchResultEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ResearchResultDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_ResearchResult Set ");
 
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.GroupTextId))
 {
 if (objzx_ResearchResultEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_ResearchResultEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGroupTextId, conzx_ResearchResult.GroupTextId); //小组Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ResearchResult.GroupTextId); //小组Id
 }
 }
 
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.TextId))
 {
 if (objzx_ResearchResultEN.TextId !=  null)
 {
 var strTextId = objzx_ResearchResultEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTextId, conzx_ResearchResult.TextId); //课件Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ResearchResult.TextId); //课件Id
 }
 }
 
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.ResultTypeId))
 {
 if (objzx_ResearchResultEN.ResultTypeId !=  null)
 {
 var strResultTypeId = objzx_ResearchResultEN.ResultTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResultTypeId, conzx_ResearchResult.ResultTypeId); //成果类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ResearchResult.ResultTypeId); //成果类型Id
 }
 }
 
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.ResultName))
 {
 if (objzx_ResearchResultEN.ResultName !=  null)
 {
 var strResultName = objzx_ResearchResultEN.ResultName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResultName, conzx_ResearchResult.ResultName); //成果名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ResearchResult.ResultName); //成果名称
 }
 }
 
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.ResultContent))
 {
 if (objzx_ResearchResultEN.ResultContent !=  null)
 {
 var strResultContent = objzx_ResearchResultEN.ResultContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResultContent, conzx_ResearchResult.ResultContent); //成果内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ResearchResult.ResultContent); //成果内容
 }
 }
 
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.Author))
 {
 if (objzx_ResearchResultEN.Author !=  null)
 {
 var strAuthor = objzx_ResearchResultEN.Author.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAuthor, conzx_ResearchResult.Author); //作者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ResearchResult.Author); //作者
 }
 }
 
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.Division))
 {
 if (objzx_ResearchResultEN.Division !=  null)
 {
 var strDivision = objzx_ResearchResultEN.Division.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDivision, conzx_ResearchResult.Division); //分工
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ResearchResult.Division); //分工
 }
 }
 
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.VersionCount))
 {
 if (objzx_ResearchResultEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ResearchResultEN.VersionCount, conzx_ResearchResult.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ResearchResult.VersionCount); //版本统计
 }
 }
 
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.OkCount))
 {
 if (objzx_ResearchResultEN.OkCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ResearchResultEN.OkCount, conzx_ResearchResult.OkCount); //点赞统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ResearchResult.OkCount); //点赞统计
 }
 }
 
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.AppraiseCount))
 {
 if (objzx_ResearchResultEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ResearchResultEN.AppraiseCount, conzx_ResearchResult.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ResearchResult.AppraiseCount); //评论数
 }
 }
 
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.Score))
 {
 if (objzx_ResearchResultEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ResearchResultEN.Score, conzx_ResearchResult.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ResearchResult.Score); //评分
 }
 }
 
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.StuScore))
 {
 if (objzx_ResearchResultEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ResearchResultEN.StuScore, conzx_ResearchResult.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ResearchResult.StuScore); //学生平均分
 }
 }
 
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.TeaScore))
 {
 if (objzx_ResearchResultEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ResearchResultEN.TeaScore, conzx_ResearchResult.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ResearchResult.TeaScore); //教师评分
 }
 }
 
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.UpdDate))
 {
 if (objzx_ResearchResultEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_ResearchResultEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conzx_ResearchResult.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ResearchResult.UpdDate); //修改日期
 }
 }
 
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.UpdUser))
 {
 if (objzx_ResearchResultEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_ResearchResultEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conzx_ResearchResult.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ResearchResult.UpdUser); //修改人
 }
 }
 
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.Memo))
 {
 if (objzx_ResearchResultEN.Memo !=  null)
 {
 var strMemo = objzx_ResearchResultEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conzx_ResearchResult.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ResearchResult.Memo); //备注
 }
 }
 
 if (objzx_ResearchResultEN.IsUpdated(conzx_ResearchResult.IdCurrEduCls))
 {
 if (objzx_ResearchResultEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_ResearchResultEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conzx_ResearchResult.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ResearchResult.IdCurrEduCls); //教学班流水号
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where zxResultId = '{0}'", objzx_ResearchResultEN.zxResultId); 
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
 /// <param name = "strzxResultId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strzxResultId) 
{
CheckPrimaryKey(strzxResultId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ResearchResultDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strzxResultId,
};
 objSQL.ExecSP("zx_ResearchResult_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strzxResultId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strzxResultId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strzxResultId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ResearchResultDA.GetSpecSQLObj();
//删除zx_ResearchResult本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_ResearchResult where zxResultId = " + "'"+ strzxResultId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delzx_ResearchResult(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ResearchResultDA.GetSpecSQLObj();
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
//删除zx_ResearchResult本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_ResearchResult where zxResultId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strzxResultId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strzxResultId) 
{
CheckPrimaryKey(strzxResultId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ResearchResultDA.GetSpecSQLObj();
//删除zx_ResearchResult本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_ResearchResult where zxResultId = " + "'"+ strzxResultId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delzx_ResearchResult(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clszx_ResearchResultDA: Delzx_ResearchResult)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ResearchResultDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from zx_ResearchResult where " + strCondition ;
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
public bool Delzx_ResearchResultWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clszx_ResearchResultDA: Delzx_ResearchResultWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ResearchResultDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from zx_ResearchResult where " + strCondition ;
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
 /// <param name = "objzx_ResearchResultENS">源对象</param>
 /// <param name = "objzx_ResearchResultENT">目标对象</param>
public void CopyTo(clszx_ResearchResultEN objzx_ResearchResultENS, clszx_ResearchResultEN objzx_ResearchResultENT)
{
objzx_ResearchResultENT.zxResultId = objzx_ResearchResultENS.zxResultId; //成果Id
objzx_ResearchResultENT.GroupTextId = objzx_ResearchResultENS.GroupTextId; //小组Id
objzx_ResearchResultENT.TextId = objzx_ResearchResultENS.TextId; //课件Id
objzx_ResearchResultENT.ResultTypeId = objzx_ResearchResultENS.ResultTypeId; //成果类型Id
objzx_ResearchResultENT.ResultName = objzx_ResearchResultENS.ResultName; //成果名称
objzx_ResearchResultENT.ResultContent = objzx_ResearchResultENS.ResultContent; //成果内容
objzx_ResearchResultENT.Author = objzx_ResearchResultENS.Author; //作者
objzx_ResearchResultENT.Division = objzx_ResearchResultENS.Division; //分工
objzx_ResearchResultENT.VersionCount = objzx_ResearchResultENS.VersionCount; //版本统计
objzx_ResearchResultENT.OkCount = objzx_ResearchResultENS.OkCount; //点赞统计
objzx_ResearchResultENT.AppraiseCount = objzx_ResearchResultENS.AppraiseCount; //评论数
objzx_ResearchResultENT.Score = objzx_ResearchResultENS.Score; //评分
objzx_ResearchResultENT.StuScore = objzx_ResearchResultENS.StuScore; //学生平均分
objzx_ResearchResultENT.TeaScore = objzx_ResearchResultENS.TeaScore; //教师评分
objzx_ResearchResultENT.UpdDate = objzx_ResearchResultENS.UpdDate; //修改日期
objzx_ResearchResultENT.UpdUser = objzx_ResearchResultENS.UpdUser; //修改人
objzx_ResearchResultENT.Memo = objzx_ResearchResultENS.Memo; //备注
objzx_ResearchResultENT.IdCurrEduCls = objzx_ResearchResultENS.IdCurrEduCls; //教学班流水号
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clszx_ResearchResultEN objzx_ResearchResultEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objzx_ResearchResultEN.IdCurrEduCls, conzx_ResearchResult.IdCurrEduCls);
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_ResearchResultEN.zxResultId, 10, conzx_ResearchResult.zxResultId);
clsCheckSql.CheckFieldLen(objzx_ResearchResultEN.GroupTextId, 8, conzx_ResearchResult.GroupTextId);
clsCheckSql.CheckFieldLen(objzx_ResearchResultEN.TextId, 8, conzx_ResearchResult.TextId);
clsCheckSql.CheckFieldLen(objzx_ResearchResultEN.ResultTypeId, 2, conzx_ResearchResult.ResultTypeId);
clsCheckSql.CheckFieldLen(objzx_ResearchResultEN.ResultName, 500, conzx_ResearchResult.ResultName);
clsCheckSql.CheckFieldLen(objzx_ResearchResultEN.Author, 200, conzx_ResearchResult.Author);
clsCheckSql.CheckFieldLen(objzx_ResearchResultEN.Division, 500, conzx_ResearchResult.Division);
clsCheckSql.CheckFieldLen(objzx_ResearchResultEN.UpdDate, 20, conzx_ResearchResult.UpdDate);
clsCheckSql.CheckFieldLen(objzx_ResearchResultEN.UpdUser, 20, conzx_ResearchResult.UpdUser);
clsCheckSql.CheckFieldLen(objzx_ResearchResultEN.Memo, 1000, conzx_ResearchResult.Memo);
clsCheckSql.CheckFieldLen(objzx_ResearchResultEN.IdCurrEduCls, 8, conzx_ResearchResult.IdCurrEduCls);
//检查字段外键固定长度
 objzx_ResearchResultEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clszx_ResearchResultEN objzx_ResearchResultEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_ResearchResultEN.GroupTextId, 8, conzx_ResearchResult.GroupTextId);
clsCheckSql.CheckFieldLen(objzx_ResearchResultEN.TextId, 8, conzx_ResearchResult.TextId);
clsCheckSql.CheckFieldLen(objzx_ResearchResultEN.ResultTypeId, 2, conzx_ResearchResult.ResultTypeId);
clsCheckSql.CheckFieldLen(objzx_ResearchResultEN.ResultName, 500, conzx_ResearchResult.ResultName);
clsCheckSql.CheckFieldLen(objzx_ResearchResultEN.Author, 200, conzx_ResearchResult.Author);
clsCheckSql.CheckFieldLen(objzx_ResearchResultEN.Division, 500, conzx_ResearchResult.Division);
clsCheckSql.CheckFieldLen(objzx_ResearchResultEN.UpdDate, 20, conzx_ResearchResult.UpdDate);
clsCheckSql.CheckFieldLen(objzx_ResearchResultEN.UpdUser, 20, conzx_ResearchResult.UpdUser);
clsCheckSql.CheckFieldLen(objzx_ResearchResultEN.Memo, 1000, conzx_ResearchResult.Memo);
clsCheckSql.CheckFieldLen(objzx_ResearchResultEN.IdCurrEduCls, 8, conzx_ResearchResult.IdCurrEduCls);
//检查外键字段长度
 objzx_ResearchResultEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clszx_ResearchResultEN objzx_ResearchResultEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_ResearchResultEN.zxResultId, 10, conzx_ResearchResult.zxResultId);
clsCheckSql.CheckFieldLen(objzx_ResearchResultEN.GroupTextId, 8, conzx_ResearchResult.GroupTextId);
clsCheckSql.CheckFieldLen(objzx_ResearchResultEN.TextId, 8, conzx_ResearchResult.TextId);
clsCheckSql.CheckFieldLen(objzx_ResearchResultEN.ResultTypeId, 2, conzx_ResearchResult.ResultTypeId);
clsCheckSql.CheckFieldLen(objzx_ResearchResultEN.ResultName, 500, conzx_ResearchResult.ResultName);
clsCheckSql.CheckFieldLen(objzx_ResearchResultEN.Author, 200, conzx_ResearchResult.Author);
clsCheckSql.CheckFieldLen(objzx_ResearchResultEN.Division, 500, conzx_ResearchResult.Division);
clsCheckSql.CheckFieldLen(objzx_ResearchResultEN.UpdDate, 20, conzx_ResearchResult.UpdDate);
clsCheckSql.CheckFieldLen(objzx_ResearchResultEN.UpdUser, 20, conzx_ResearchResult.UpdUser);
clsCheckSql.CheckFieldLen(objzx_ResearchResultEN.Memo, 1000, conzx_ResearchResult.Memo);
clsCheckSql.CheckFieldLen(objzx_ResearchResultEN.IdCurrEduCls, 8, conzx_ResearchResult.IdCurrEduCls);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objzx_ResearchResultEN.zxResultId, conzx_ResearchResult.zxResultId);
clsCheckSql.CheckSqlInjection4Field(objzx_ResearchResultEN.GroupTextId, conzx_ResearchResult.GroupTextId);
clsCheckSql.CheckSqlInjection4Field(objzx_ResearchResultEN.TextId, conzx_ResearchResult.TextId);
clsCheckSql.CheckSqlInjection4Field(objzx_ResearchResultEN.ResultTypeId, conzx_ResearchResult.ResultTypeId);
clsCheckSql.CheckSqlInjection4Field(objzx_ResearchResultEN.ResultName, conzx_ResearchResult.ResultName);
clsCheckSql.CheckSqlInjection4Field(objzx_ResearchResultEN.Author, conzx_ResearchResult.Author);
clsCheckSql.CheckSqlInjection4Field(objzx_ResearchResultEN.Division, conzx_ResearchResult.Division);
clsCheckSql.CheckSqlInjection4Field(objzx_ResearchResultEN.UpdDate, conzx_ResearchResult.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objzx_ResearchResultEN.UpdUser, conzx_ResearchResult.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objzx_ResearchResultEN.Memo, conzx_ResearchResult.Memo);
clsCheckSql.CheckSqlInjection4Field(objzx_ResearchResultEN.IdCurrEduCls, conzx_ResearchResult.IdCurrEduCls);
//检查外键字段长度
 objzx_ResearchResultEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--zx_ResearchResult(中学研究成果),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objzx_ResearchResultEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clszx_ResearchResultEN objzx_ResearchResultEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 if (objzx_ResearchResultEN.GroupTextId == null)
{
 sbCondition.AppendFormat(" and GroupTextId is null");
}
else
{
 sbCondition.AppendFormat(" and GroupTextId = '{0}'", objzx_ResearchResultEN.GroupTextId);
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
 objSQL = clszx_ResearchResultDA.GetSpecSQLObj();
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
 objSQL = clszx_ResearchResultDA.GetSpecSQLObj();
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
 objSQL = clszx_ResearchResultDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clszx_ResearchResultEN._CurrTabName);
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
 objSQL = clszx_ResearchResultDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clszx_ResearchResultEN._CurrTabName, strCondition);
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
 objSQL = clszx_ResearchResultDA.GetSpecSQLObj();
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
 objSQL = clszx_ResearchResultDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}