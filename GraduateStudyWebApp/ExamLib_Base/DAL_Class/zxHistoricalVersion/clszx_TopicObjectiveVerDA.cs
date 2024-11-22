
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_TopicObjectiveVerDA
 表名:zx_TopicObjectiveVer(01120741)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 23:08:13
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学历史版本(zxHistoricalVersion)
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
 /// 客观数据历史(zx_TopicObjectiveVer)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clszx_TopicObjectiveVerDA : clsCommBase4DA
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
 return clszx_TopicObjectiveVerEN._CurrTabName;
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
if (string.IsNullOrEmpty(clszx_TopicObjectiveVerEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clszx_TopicObjectiveVerEN._ConnectString);
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
 if (string.IsNullOrEmpty(clszx_TopicObjectiveVerEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clszx_TopicObjectiveVerEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clszx_TopicObjectiveVerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TopicObjectiveVerDA.GetSpecSQLObj();
strSQL = "Select * from zx_TopicObjectiveVer where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_zx_TopicObjectiveVer(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clszx_TopicObjectiveVerDA: GetDataTable_zx_TopicObjectiveVer)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TopicObjectiveVerDA.GetSpecSQLObj();
strSQL = "Select * from zx_TopicObjectiveVer where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clszx_TopicObjectiveVerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TopicObjectiveVerDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clszx_TopicObjectiveVerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TopicObjectiveVerDA.GetSpecSQLObj();
strSQL = "Select * from zx_TopicObjectiveVer where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clszx_TopicObjectiveVerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TopicObjectiveVerDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clszx_TopicObjectiveVerDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TopicObjectiveVerDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_TopicObjectiveVer where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_TopicObjectiveVer where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clszx_TopicObjectiveVerDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TopicObjectiveVerDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from zx_TopicObjectiveVer where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clszx_TopicObjectiveVerDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TopicObjectiveVerDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} zx_TopicObjectiveVer.* from zx_TopicObjectiveVer Left Join {1} on {2} where {3} and zx_TopicObjectiveVer.TopicObjectiveVId not in (Select top {5} zx_TopicObjectiveVer.TopicObjectiveVId from zx_TopicObjectiveVer Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_TopicObjectiveVer where {1} and TopicObjectiveVId not in (Select top {2} TopicObjectiveVId from zx_TopicObjectiveVer where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_TopicObjectiveVer where {1} and TopicObjectiveVId not in (Select top {3} TopicObjectiveVId from zx_TopicObjectiveVer where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clszx_TopicObjectiveVerDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TopicObjectiveVerDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} zx_TopicObjectiveVer.* from zx_TopicObjectiveVer Left Join {1} on {2} where {3} and zx_TopicObjectiveVer.TopicObjectiveVId not in (Select top {5} zx_TopicObjectiveVer.TopicObjectiveVId from zx_TopicObjectiveVer Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_TopicObjectiveVer where {1} and TopicObjectiveVId not in (Select top {2} TopicObjectiveVId from zx_TopicObjectiveVer where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_TopicObjectiveVer where {1} and TopicObjectiveVId not in (Select top {3} TopicObjectiveVId from zx_TopicObjectiveVer where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clszx_TopicObjectiveVerEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clszx_TopicObjectiveVerDA:GetObjLst)", objException.Message));
}
List<clszx_TopicObjectiveVerEN> arrObjLst = new List<clszx_TopicObjectiveVerEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TopicObjectiveVerDA.GetSpecSQLObj();
strSQL = "Select * from zx_TopicObjectiveVer where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN = new clszx_TopicObjectiveVerEN();
try
{
objzx_TopicObjectiveVerEN.TopicObjectiveVId = TransNullToInt(objRow[conzx_TopicObjectiveVer.TopicObjectiveVId].ToString().Trim()); //主题客观版本Id
objzx_TopicObjectiveVerEN.zxTopicObjectiveId = objRow[conzx_TopicObjectiveVer.zxTopicObjectiveId].ToString().Trim(); //客观Id
objzx_TopicObjectiveVerEN.ObjectiveName = objRow[conzx_TopicObjectiveVer.ObjectiveName] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.ObjectiveName].ToString().Trim(); //客观名称
objzx_TopicObjectiveVerEN.ObjectiveContent = objRow[conzx_TopicObjectiveVer.ObjectiveContent] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.ObjectiveContent].ToString().Trim(); //客观内容
objzx_TopicObjectiveVerEN.ObjectiveType = objRow[conzx_TopicObjectiveVer.ObjectiveType] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.ObjectiveType].ToString().Trim(); //客观类型
objzx_TopicObjectiveVerEN.Conclusion = objRow[conzx_TopicObjectiveVer.Conclusion] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.Conclusion].ToString().Trim(); //结论
objzx_TopicObjectiveVerEN.TextId = objRow[conzx_TopicObjectiveVer.TextId] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.TextId].ToString().Trim(); //课件Id
objzx_TopicObjectiveVerEN.IsSubmit = TransNullToBool(objRow[conzx_TopicObjectiveVer.IsSubmit].ToString().Trim()); //是否提交
objzx_TopicObjectiveVerEN.VoteCount = objRow[conzx_TopicObjectiveVer.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TopicObjectiveVer.VoteCount].ToString().Trim()); //点赞计数
objzx_TopicObjectiveVerEN.AppraiseCount = objRow[conzx_TopicObjectiveVer.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TopicObjectiveVer.AppraiseCount].ToString().Trim()); //评论数
objzx_TopicObjectiveVerEN.Score = objRow[conzx_TopicObjectiveVer.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_TopicObjectiveVer.Score].ToString().Trim()); //评分
objzx_TopicObjectiveVerEN.StuScore = objRow[conzx_TopicObjectiveVer.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_TopicObjectiveVer.StuScore].ToString().Trim()); //学生平均分
objzx_TopicObjectiveVerEN.TeaScore = objRow[conzx_TopicObjectiveVer.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_TopicObjectiveVer.TeaScore].ToString().Trim()); //教师评分
objzx_TopicObjectiveVerEN.CreateDate = objRow[conzx_TopicObjectiveVer.CreateDate] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.CreateDate].ToString().Trim(); //建立日期
objzx_TopicObjectiveVerEN.UpdDate = objRow[conzx_TopicObjectiveVer.UpdDate] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.UpdDate].ToString().Trim(); //修改日期
objzx_TopicObjectiveVerEN.UpdUser = objRow[conzx_TopicObjectiveVer.UpdUser] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.UpdUser].ToString().Trim(); //修改人
objzx_TopicObjectiveVerEN.IdCurrEduCls = objRow[conzx_TopicObjectiveVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TopicObjectiveVerEN.PdfContent = objRow[conzx_TopicObjectiveVer.PdfContent] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfContent].ToString().Trim(); //Pdf内容
objzx_TopicObjectiveVerEN.PdfPageNum = objRow[conzx_TopicObjectiveVer.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TopicObjectiveVer.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_TopicObjectiveVerEN.CitationCount = objRow[conzx_TopicObjectiveVer.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TopicObjectiveVer.CitationCount].ToString().Trim()); //引用统计
objzx_TopicObjectiveVerEN.VersionCount = objRow[conzx_TopicObjectiveVer.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TopicObjectiveVer.VersionCount].ToString().Trim()); //版本统计
objzx_TopicObjectiveVerEN.zxShareId = objRow[conzx_TopicObjectiveVer.zxShareId] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.zxShareId].ToString().Trim(); //分享Id
objzx_TopicObjectiveVerEN.Memo = objRow[conzx_TopicObjectiveVer.Memo] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.Memo].ToString().Trim(); //备注
objzx_TopicObjectiveVerEN.PdfDivLet = objRow[conzx_TopicObjectiveVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_TopicObjectiveVerEN.PdfDivTop = objRow[conzx_TopicObjectiveVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_TopicObjectiveVerEN.PdfPageNumIn = objRow[conzx_TopicObjectiveVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_TopicObjectiveVerEN.PdfPageTop = objRow[conzx_TopicObjectiveVer.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TopicObjectiveVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_TopicObjectiveVerEN.PdfZoom = objRow[conzx_TopicObjectiveVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfZoom].ToString().Trim(); //PdfZoom
objzx_TopicObjectiveVerEN.GroupTextId = objRow[conzx_TopicObjectiveVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.GroupTextId].ToString().Trim(); //小组Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clszx_TopicObjectiveVerDA: GetObjLst)", objException.Message));
}
objzx_TopicObjectiveVerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objzx_TopicObjectiveVerEN);
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
public List<clszx_TopicObjectiveVerEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clszx_TopicObjectiveVerDA:GetObjLstByTabName)", objException.Message));
}
List<clszx_TopicObjectiveVerEN> arrObjLst = new List<clszx_TopicObjectiveVerEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TopicObjectiveVerDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN = new clszx_TopicObjectiveVerEN();
try
{
objzx_TopicObjectiveVerEN.TopicObjectiveVId = TransNullToInt(objRow[conzx_TopicObjectiveVer.TopicObjectiveVId].ToString().Trim()); //主题客观版本Id
objzx_TopicObjectiveVerEN.zxTopicObjectiveId = objRow[conzx_TopicObjectiveVer.zxTopicObjectiveId].ToString().Trim(); //客观Id
objzx_TopicObjectiveVerEN.ObjectiveName = objRow[conzx_TopicObjectiveVer.ObjectiveName] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.ObjectiveName].ToString().Trim(); //客观名称
objzx_TopicObjectiveVerEN.ObjectiveContent = objRow[conzx_TopicObjectiveVer.ObjectiveContent] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.ObjectiveContent].ToString().Trim(); //客观内容
objzx_TopicObjectiveVerEN.ObjectiveType = objRow[conzx_TopicObjectiveVer.ObjectiveType] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.ObjectiveType].ToString().Trim(); //客观类型
objzx_TopicObjectiveVerEN.Conclusion = objRow[conzx_TopicObjectiveVer.Conclusion] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.Conclusion].ToString().Trim(); //结论
objzx_TopicObjectiveVerEN.TextId = objRow[conzx_TopicObjectiveVer.TextId] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.TextId].ToString().Trim(); //课件Id
objzx_TopicObjectiveVerEN.IsSubmit = TransNullToBool(objRow[conzx_TopicObjectiveVer.IsSubmit].ToString().Trim()); //是否提交
objzx_TopicObjectiveVerEN.VoteCount = objRow[conzx_TopicObjectiveVer.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TopicObjectiveVer.VoteCount].ToString().Trim()); //点赞计数
objzx_TopicObjectiveVerEN.AppraiseCount = objRow[conzx_TopicObjectiveVer.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TopicObjectiveVer.AppraiseCount].ToString().Trim()); //评论数
objzx_TopicObjectiveVerEN.Score = objRow[conzx_TopicObjectiveVer.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_TopicObjectiveVer.Score].ToString().Trim()); //评分
objzx_TopicObjectiveVerEN.StuScore = objRow[conzx_TopicObjectiveVer.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_TopicObjectiveVer.StuScore].ToString().Trim()); //学生平均分
objzx_TopicObjectiveVerEN.TeaScore = objRow[conzx_TopicObjectiveVer.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_TopicObjectiveVer.TeaScore].ToString().Trim()); //教师评分
objzx_TopicObjectiveVerEN.CreateDate = objRow[conzx_TopicObjectiveVer.CreateDate] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.CreateDate].ToString().Trim(); //建立日期
objzx_TopicObjectiveVerEN.UpdDate = objRow[conzx_TopicObjectiveVer.UpdDate] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.UpdDate].ToString().Trim(); //修改日期
objzx_TopicObjectiveVerEN.UpdUser = objRow[conzx_TopicObjectiveVer.UpdUser] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.UpdUser].ToString().Trim(); //修改人
objzx_TopicObjectiveVerEN.IdCurrEduCls = objRow[conzx_TopicObjectiveVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TopicObjectiveVerEN.PdfContent = objRow[conzx_TopicObjectiveVer.PdfContent] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfContent].ToString().Trim(); //Pdf内容
objzx_TopicObjectiveVerEN.PdfPageNum = objRow[conzx_TopicObjectiveVer.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TopicObjectiveVer.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_TopicObjectiveVerEN.CitationCount = objRow[conzx_TopicObjectiveVer.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TopicObjectiveVer.CitationCount].ToString().Trim()); //引用统计
objzx_TopicObjectiveVerEN.VersionCount = objRow[conzx_TopicObjectiveVer.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TopicObjectiveVer.VersionCount].ToString().Trim()); //版本统计
objzx_TopicObjectiveVerEN.zxShareId = objRow[conzx_TopicObjectiveVer.zxShareId] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.zxShareId].ToString().Trim(); //分享Id
objzx_TopicObjectiveVerEN.Memo = objRow[conzx_TopicObjectiveVer.Memo] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.Memo].ToString().Trim(); //备注
objzx_TopicObjectiveVerEN.PdfDivLet = objRow[conzx_TopicObjectiveVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_TopicObjectiveVerEN.PdfDivTop = objRow[conzx_TopicObjectiveVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_TopicObjectiveVerEN.PdfPageNumIn = objRow[conzx_TopicObjectiveVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_TopicObjectiveVerEN.PdfPageTop = objRow[conzx_TopicObjectiveVer.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TopicObjectiveVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_TopicObjectiveVerEN.PdfZoom = objRow[conzx_TopicObjectiveVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfZoom].ToString().Trim(); //PdfZoom
objzx_TopicObjectiveVerEN.GroupTextId = objRow[conzx_TopicObjectiveVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.GroupTextId].ToString().Trim(); //小组Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clszx_TopicObjectiveVerDA: GetObjLst)", objException.Message));
}
objzx_TopicObjectiveVerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objzx_TopicObjectiveVerEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveVerEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getzx_TopicObjectiveVer(ref clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TopicObjectiveVerDA.GetSpecSQLObj();
strSQL = "Select * from zx_TopicObjectiveVer where TopicObjectiveVId = " + ""+ objzx_TopicObjectiveVerEN.TopicObjectiveVId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objzx_TopicObjectiveVerEN.TopicObjectiveVId = TransNullToInt(objDT.Rows[0][conzx_TopicObjectiveVer.TopicObjectiveVId].ToString().Trim()); //主题客观版本Id(字段类型:bigint,字段长度:8,是否可空:False)
 objzx_TopicObjectiveVerEN.zxTopicObjectiveId = objDT.Rows[0][conzx_TopicObjectiveVer.zxTopicObjectiveId].ToString().Trim(); //客观Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_TopicObjectiveVerEN.ObjectiveName = objDT.Rows[0][conzx_TopicObjectiveVer.ObjectiveName].ToString().Trim(); //客观名称(字段类型:varchar,字段长度:500,是否可空:True)
 objzx_TopicObjectiveVerEN.ObjectiveContent = objDT.Rows[0][conzx_TopicObjectiveVer.ObjectiveContent].ToString().Trim(); //客观内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objzx_TopicObjectiveVerEN.ObjectiveType = objDT.Rows[0][conzx_TopicObjectiveVer.ObjectiveType].ToString().Trim(); //客观类型(字段类型:char,字段长度:2,是否可空:True)
 objzx_TopicObjectiveVerEN.Conclusion = objDT.Rows[0][conzx_TopicObjectiveVer.Conclusion].ToString().Trim(); //结论(字段类型:text,字段长度:2147483647,是否可空:True)
 objzx_TopicObjectiveVerEN.TextId = objDT.Rows[0][conzx_TopicObjectiveVer.TextId].ToString().Trim(); //课件Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_TopicObjectiveVerEN.IsSubmit = TransNullToBool(objDT.Rows[0][conzx_TopicObjectiveVer.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objzx_TopicObjectiveVerEN.VoteCount = TransNullToInt(objDT.Rows[0][conzx_TopicObjectiveVer.VoteCount].ToString().Trim()); //点赞计数(字段类型:int,字段长度:4,是否可空:True)
 objzx_TopicObjectiveVerEN.AppraiseCount = TransNullToInt(objDT.Rows[0][conzx_TopicObjectiveVer.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objzx_TopicObjectiveVerEN.Score = TransNullToFloat(objDT.Rows[0][conzx_TopicObjectiveVer.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objzx_TopicObjectiveVerEN.StuScore = TransNullToFloat(objDT.Rows[0][conzx_TopicObjectiveVer.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objzx_TopicObjectiveVerEN.TeaScore = TransNullToFloat(objDT.Rows[0][conzx_TopicObjectiveVer.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objzx_TopicObjectiveVerEN.CreateDate = objDT.Rows[0][conzx_TopicObjectiveVer.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_TopicObjectiveVerEN.UpdDate = objDT.Rows[0][conzx_TopicObjectiveVer.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_TopicObjectiveVerEN.UpdUser = objDT.Rows[0][conzx_TopicObjectiveVer.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_TopicObjectiveVerEN.IdCurrEduCls = objDT.Rows[0][conzx_TopicObjectiveVer.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objzx_TopicObjectiveVerEN.PdfContent = objDT.Rows[0][conzx_TopicObjectiveVer.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objzx_TopicObjectiveVerEN.PdfPageNum = TransNullToInt(objDT.Rows[0][conzx_TopicObjectiveVer.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objzx_TopicObjectiveVerEN.CitationCount = TransNullToInt(objDT.Rows[0][conzx_TopicObjectiveVer.CitationCount].ToString().Trim()); //引用统计(字段类型:int,字段长度:4,是否可空:True)
 objzx_TopicObjectiveVerEN.VersionCount = TransNullToInt(objDT.Rows[0][conzx_TopicObjectiveVer.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objzx_TopicObjectiveVerEN.zxShareId = objDT.Rows[0][conzx_TopicObjectiveVer.zxShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objzx_TopicObjectiveVerEN.Memo = objDT.Rows[0][conzx_TopicObjectiveVer.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_TopicObjectiveVerEN.PdfDivLet = objDT.Rows[0][conzx_TopicObjectiveVer.PdfDivLet].ToString().Trim(); //PdfDivLet(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_TopicObjectiveVerEN.PdfDivTop = objDT.Rows[0][conzx_TopicObjectiveVer.PdfDivTop].ToString().Trim(); //PdfDivTop(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_TopicObjectiveVerEN.PdfPageNumIn = objDT.Rows[0][conzx_TopicObjectiveVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_TopicObjectiveVerEN.PdfPageTop = TransNullToInt(objDT.Rows[0][conzx_TopicObjectiveVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置(字段类型:int,字段长度:4,是否可空:True)
 objzx_TopicObjectiveVerEN.PdfZoom = objDT.Rows[0][conzx_TopicObjectiveVer.PdfZoom].ToString().Trim(); //PdfZoom(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_TopicObjectiveVerEN.GroupTextId = objDT.Rows[0][conzx_TopicObjectiveVer.GroupTextId].ToString().Trim(); //小组Id(字段类型:char,字段长度:8,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clszx_TopicObjectiveVerDA: Getzx_TopicObjectiveVer)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngTopicObjectiveVId">表关键字</param>
 /// <returns>表对象</returns>
public clszx_TopicObjectiveVerEN GetObjByTopicObjectiveVId(long lngTopicObjectiveVId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TopicObjectiveVerDA.GetSpecSQLObj();
strSQL = "Select * from zx_TopicObjectiveVer where TopicObjectiveVId = " + ""+ lngTopicObjectiveVId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN = new clszx_TopicObjectiveVerEN();
try
{
 objzx_TopicObjectiveVerEN.TopicObjectiveVId = Int32.Parse(objRow[conzx_TopicObjectiveVer.TopicObjectiveVId].ToString().Trim()); //主题客观版本Id(字段类型:bigint,字段长度:8,是否可空:False)
 objzx_TopicObjectiveVerEN.zxTopicObjectiveId = objRow[conzx_TopicObjectiveVer.zxTopicObjectiveId].ToString().Trim(); //客观Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_TopicObjectiveVerEN.ObjectiveName = objRow[conzx_TopicObjectiveVer.ObjectiveName] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.ObjectiveName].ToString().Trim(); //客观名称(字段类型:varchar,字段长度:500,是否可空:True)
 objzx_TopicObjectiveVerEN.ObjectiveContent = objRow[conzx_TopicObjectiveVer.ObjectiveContent] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.ObjectiveContent].ToString().Trim(); //客观内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objzx_TopicObjectiveVerEN.ObjectiveType = objRow[conzx_TopicObjectiveVer.ObjectiveType] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.ObjectiveType].ToString().Trim(); //客观类型(字段类型:char,字段长度:2,是否可空:True)
 objzx_TopicObjectiveVerEN.Conclusion = objRow[conzx_TopicObjectiveVer.Conclusion] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.Conclusion].ToString().Trim(); //结论(字段类型:text,字段长度:2147483647,是否可空:True)
 objzx_TopicObjectiveVerEN.TextId = objRow[conzx_TopicObjectiveVer.TextId] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.TextId].ToString().Trim(); //课件Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_TopicObjectiveVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_TopicObjectiveVer.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objzx_TopicObjectiveVerEN.VoteCount = objRow[conzx_TopicObjectiveVer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjectiveVer.VoteCount].ToString().Trim()); //点赞计数(字段类型:int,字段长度:4,是否可空:True)
 objzx_TopicObjectiveVerEN.AppraiseCount = objRow[conzx_TopicObjectiveVer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjectiveVer.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objzx_TopicObjectiveVerEN.Score = objRow[conzx_TopicObjectiveVer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TopicObjectiveVer.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objzx_TopicObjectiveVerEN.StuScore = objRow[conzx_TopicObjectiveVer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TopicObjectiveVer.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objzx_TopicObjectiveVerEN.TeaScore = objRow[conzx_TopicObjectiveVer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TopicObjectiveVer.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objzx_TopicObjectiveVerEN.CreateDate = objRow[conzx_TopicObjectiveVer.CreateDate] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_TopicObjectiveVerEN.UpdDate = objRow[conzx_TopicObjectiveVer.UpdDate] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_TopicObjectiveVerEN.UpdUser = objRow[conzx_TopicObjectiveVer.UpdUser] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_TopicObjectiveVerEN.IdCurrEduCls = objRow[conzx_TopicObjectiveVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objzx_TopicObjectiveVerEN.PdfContent = objRow[conzx_TopicObjectiveVer.PdfContent] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objzx_TopicObjectiveVerEN.PdfPageNum = objRow[conzx_TopicObjectiveVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjectiveVer.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objzx_TopicObjectiveVerEN.CitationCount = objRow[conzx_TopicObjectiveVer.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjectiveVer.CitationCount].ToString().Trim()); //引用统计(字段类型:int,字段长度:4,是否可空:True)
 objzx_TopicObjectiveVerEN.VersionCount = objRow[conzx_TopicObjectiveVer.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjectiveVer.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objzx_TopicObjectiveVerEN.zxShareId = objRow[conzx_TopicObjectiveVer.zxShareId] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.zxShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objzx_TopicObjectiveVerEN.Memo = objRow[conzx_TopicObjectiveVer.Memo] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_TopicObjectiveVerEN.PdfDivLet = objRow[conzx_TopicObjectiveVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfDivLet].ToString().Trim(); //PdfDivLet(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_TopicObjectiveVerEN.PdfDivTop = objRow[conzx_TopicObjectiveVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfDivTop].ToString().Trim(); //PdfDivTop(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_TopicObjectiveVerEN.PdfPageNumIn = objRow[conzx_TopicObjectiveVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_TopicObjectiveVerEN.PdfPageTop = objRow[conzx_TopicObjectiveVer.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjectiveVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置(字段类型:int,字段长度:4,是否可空:True)
 objzx_TopicObjectiveVerEN.PdfZoom = objRow[conzx_TopicObjectiveVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfZoom].ToString().Trim(); //PdfZoom(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_TopicObjectiveVerEN.GroupTextId = objRow[conzx_TopicObjectiveVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.GroupTextId].ToString().Trim(); //小组Id(字段类型:char,字段长度:8,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clszx_TopicObjectiveVerDA: GetObjByTopicObjectiveVId)", objException.Message));
}
return objzx_TopicObjectiveVerEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clszx_TopicObjectiveVerEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clszx_TopicObjectiveVerDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TopicObjectiveVerDA.GetSpecSQLObj();
strSQL = "Select * from zx_TopicObjectiveVer where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN = new clszx_TopicObjectiveVerEN()
{
TopicObjectiveVId = TransNullToInt(objRow[conzx_TopicObjectiveVer.TopicObjectiveVId].ToString().Trim()), //主题客观版本Id
zxTopicObjectiveId = objRow[conzx_TopicObjectiveVer.zxTopicObjectiveId].ToString().Trim(), //客观Id
ObjectiveName = objRow[conzx_TopicObjectiveVer.ObjectiveName] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.ObjectiveName].ToString().Trim(), //客观名称
ObjectiveContent = objRow[conzx_TopicObjectiveVer.ObjectiveContent] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.ObjectiveContent].ToString().Trim(), //客观内容
ObjectiveType = objRow[conzx_TopicObjectiveVer.ObjectiveType] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.ObjectiveType].ToString().Trim(), //客观类型
Conclusion = objRow[conzx_TopicObjectiveVer.Conclusion] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.Conclusion].ToString().Trim(), //结论
TextId = objRow[conzx_TopicObjectiveVer.TextId] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.TextId].ToString().Trim(), //课件Id
IsSubmit = TransNullToBool(objRow[conzx_TopicObjectiveVer.IsSubmit].ToString().Trim()), //是否提交
VoteCount = objRow[conzx_TopicObjectiveVer.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TopicObjectiveVer.VoteCount].ToString().Trim()), //点赞计数
AppraiseCount = objRow[conzx_TopicObjectiveVer.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TopicObjectiveVer.AppraiseCount].ToString().Trim()), //评论数
Score = objRow[conzx_TopicObjectiveVer.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_TopicObjectiveVer.Score].ToString().Trim()), //评分
StuScore = objRow[conzx_TopicObjectiveVer.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_TopicObjectiveVer.StuScore].ToString().Trim()), //学生平均分
TeaScore = objRow[conzx_TopicObjectiveVer.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_TopicObjectiveVer.TeaScore].ToString().Trim()), //教师评分
CreateDate = objRow[conzx_TopicObjectiveVer.CreateDate] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.CreateDate].ToString().Trim(), //建立日期
UpdDate = objRow[conzx_TopicObjectiveVer.UpdDate] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conzx_TopicObjectiveVer.UpdUser] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.UpdUser].ToString().Trim(), //修改人
IdCurrEduCls = objRow[conzx_TopicObjectiveVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.IdCurrEduCls].ToString().Trim(), //教学班流水号
PdfContent = objRow[conzx_TopicObjectiveVer.PdfContent] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfContent].ToString().Trim(), //Pdf内容
PdfPageNum = objRow[conzx_TopicObjectiveVer.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TopicObjectiveVer.PdfPageNum].ToString().Trim()), //Pdf页码
CitationCount = objRow[conzx_TopicObjectiveVer.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TopicObjectiveVer.CitationCount].ToString().Trim()), //引用统计
VersionCount = objRow[conzx_TopicObjectiveVer.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TopicObjectiveVer.VersionCount].ToString().Trim()), //版本统计
zxShareId = objRow[conzx_TopicObjectiveVer.zxShareId] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.zxShareId].ToString().Trim(), //分享Id
Memo = objRow[conzx_TopicObjectiveVer.Memo] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.Memo].ToString().Trim(), //备注
PdfDivLet = objRow[conzx_TopicObjectiveVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfDivLet].ToString().Trim(), //PdfDivLet
PdfDivTop = objRow[conzx_TopicObjectiveVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfDivTop].ToString().Trim(), //PdfDivTop
PdfPageNumIn = objRow[conzx_TopicObjectiveVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfPageNumIn].ToString().Trim(), //PdfPageNumIn
PdfPageTop = objRow[conzx_TopicObjectiveVer.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TopicObjectiveVer.PdfPageTop].ToString().Trim()), //pdf页面顶部位置
PdfZoom = objRow[conzx_TopicObjectiveVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfZoom].ToString().Trim(), //PdfZoom
GroupTextId = objRow[conzx_TopicObjectiveVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.GroupTextId].ToString().Trim() //小组Id
};
objzx_TopicObjectiveVerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_TopicObjectiveVerEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clszx_TopicObjectiveVerDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clszx_TopicObjectiveVerEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN = new clszx_TopicObjectiveVerEN();
try
{
objzx_TopicObjectiveVerEN.TopicObjectiveVId = TransNullToInt(objRow[conzx_TopicObjectiveVer.TopicObjectiveVId].ToString().Trim()); //主题客观版本Id
objzx_TopicObjectiveVerEN.zxTopicObjectiveId = objRow[conzx_TopicObjectiveVer.zxTopicObjectiveId].ToString().Trim(); //客观Id
objzx_TopicObjectiveVerEN.ObjectiveName = objRow[conzx_TopicObjectiveVer.ObjectiveName] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.ObjectiveName].ToString().Trim(); //客观名称
objzx_TopicObjectiveVerEN.ObjectiveContent = objRow[conzx_TopicObjectiveVer.ObjectiveContent] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.ObjectiveContent].ToString().Trim(); //客观内容
objzx_TopicObjectiveVerEN.ObjectiveType = objRow[conzx_TopicObjectiveVer.ObjectiveType] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.ObjectiveType].ToString().Trim(); //客观类型
objzx_TopicObjectiveVerEN.Conclusion = objRow[conzx_TopicObjectiveVer.Conclusion] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.Conclusion].ToString().Trim(); //结论
objzx_TopicObjectiveVerEN.TextId = objRow[conzx_TopicObjectiveVer.TextId] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.TextId].ToString().Trim(); //课件Id
objzx_TopicObjectiveVerEN.IsSubmit = TransNullToBool(objRow[conzx_TopicObjectiveVer.IsSubmit].ToString().Trim()); //是否提交
objzx_TopicObjectiveVerEN.VoteCount = objRow[conzx_TopicObjectiveVer.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TopicObjectiveVer.VoteCount].ToString().Trim()); //点赞计数
objzx_TopicObjectiveVerEN.AppraiseCount = objRow[conzx_TopicObjectiveVer.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TopicObjectiveVer.AppraiseCount].ToString().Trim()); //评论数
objzx_TopicObjectiveVerEN.Score = objRow[conzx_TopicObjectiveVer.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_TopicObjectiveVer.Score].ToString().Trim()); //评分
objzx_TopicObjectiveVerEN.StuScore = objRow[conzx_TopicObjectiveVer.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_TopicObjectiveVer.StuScore].ToString().Trim()); //学生平均分
objzx_TopicObjectiveVerEN.TeaScore = objRow[conzx_TopicObjectiveVer.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_TopicObjectiveVer.TeaScore].ToString().Trim()); //教师评分
objzx_TopicObjectiveVerEN.CreateDate = objRow[conzx_TopicObjectiveVer.CreateDate] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.CreateDate].ToString().Trim(); //建立日期
objzx_TopicObjectiveVerEN.UpdDate = objRow[conzx_TopicObjectiveVer.UpdDate] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.UpdDate].ToString().Trim(); //修改日期
objzx_TopicObjectiveVerEN.UpdUser = objRow[conzx_TopicObjectiveVer.UpdUser] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.UpdUser].ToString().Trim(); //修改人
objzx_TopicObjectiveVerEN.IdCurrEduCls = objRow[conzx_TopicObjectiveVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TopicObjectiveVerEN.PdfContent = objRow[conzx_TopicObjectiveVer.PdfContent] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfContent].ToString().Trim(); //Pdf内容
objzx_TopicObjectiveVerEN.PdfPageNum = objRow[conzx_TopicObjectiveVer.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TopicObjectiveVer.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_TopicObjectiveVerEN.CitationCount = objRow[conzx_TopicObjectiveVer.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TopicObjectiveVer.CitationCount].ToString().Trim()); //引用统计
objzx_TopicObjectiveVerEN.VersionCount = objRow[conzx_TopicObjectiveVer.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TopicObjectiveVer.VersionCount].ToString().Trim()); //版本统计
objzx_TopicObjectiveVerEN.zxShareId = objRow[conzx_TopicObjectiveVer.zxShareId] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.zxShareId].ToString().Trim(); //分享Id
objzx_TopicObjectiveVerEN.Memo = objRow[conzx_TopicObjectiveVer.Memo] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.Memo].ToString().Trim(); //备注
objzx_TopicObjectiveVerEN.PdfDivLet = objRow[conzx_TopicObjectiveVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_TopicObjectiveVerEN.PdfDivTop = objRow[conzx_TopicObjectiveVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_TopicObjectiveVerEN.PdfPageNumIn = objRow[conzx_TopicObjectiveVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_TopicObjectiveVerEN.PdfPageTop = objRow[conzx_TopicObjectiveVer.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TopicObjectiveVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_TopicObjectiveVerEN.PdfZoom = objRow[conzx_TopicObjectiveVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfZoom].ToString().Trim(); //PdfZoom
objzx_TopicObjectiveVerEN.GroupTextId = objRow[conzx_TopicObjectiveVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.GroupTextId].ToString().Trim(); //小组Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clszx_TopicObjectiveVerDA: GetObjByDataRowzx_TopicObjectiveVer)", objException.Message));
}
objzx_TopicObjectiveVerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_TopicObjectiveVerEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clszx_TopicObjectiveVerEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN = new clszx_TopicObjectiveVerEN();
try
{
objzx_TopicObjectiveVerEN.TopicObjectiveVId = TransNullToInt(objRow[conzx_TopicObjectiveVer.TopicObjectiveVId].ToString().Trim()); //主题客观版本Id
objzx_TopicObjectiveVerEN.zxTopicObjectiveId = objRow[conzx_TopicObjectiveVer.zxTopicObjectiveId].ToString().Trim(); //客观Id
objzx_TopicObjectiveVerEN.ObjectiveName = objRow[conzx_TopicObjectiveVer.ObjectiveName] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.ObjectiveName].ToString().Trim(); //客观名称
objzx_TopicObjectiveVerEN.ObjectiveContent = objRow[conzx_TopicObjectiveVer.ObjectiveContent] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.ObjectiveContent].ToString().Trim(); //客观内容
objzx_TopicObjectiveVerEN.ObjectiveType = objRow[conzx_TopicObjectiveVer.ObjectiveType] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.ObjectiveType].ToString().Trim(); //客观类型
objzx_TopicObjectiveVerEN.Conclusion = objRow[conzx_TopicObjectiveVer.Conclusion] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.Conclusion].ToString().Trim(); //结论
objzx_TopicObjectiveVerEN.TextId = objRow[conzx_TopicObjectiveVer.TextId] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.TextId].ToString().Trim(); //课件Id
objzx_TopicObjectiveVerEN.IsSubmit = TransNullToBool(objRow[conzx_TopicObjectiveVer.IsSubmit].ToString().Trim()); //是否提交
objzx_TopicObjectiveVerEN.VoteCount = objRow[conzx_TopicObjectiveVer.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TopicObjectiveVer.VoteCount].ToString().Trim()); //点赞计数
objzx_TopicObjectiveVerEN.AppraiseCount = objRow[conzx_TopicObjectiveVer.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TopicObjectiveVer.AppraiseCount].ToString().Trim()); //评论数
objzx_TopicObjectiveVerEN.Score = objRow[conzx_TopicObjectiveVer.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_TopicObjectiveVer.Score].ToString().Trim()); //评分
objzx_TopicObjectiveVerEN.StuScore = objRow[conzx_TopicObjectiveVer.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_TopicObjectiveVer.StuScore].ToString().Trim()); //学生平均分
objzx_TopicObjectiveVerEN.TeaScore = objRow[conzx_TopicObjectiveVer.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_TopicObjectiveVer.TeaScore].ToString().Trim()); //教师评分
objzx_TopicObjectiveVerEN.CreateDate = objRow[conzx_TopicObjectiveVer.CreateDate] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.CreateDate].ToString().Trim(); //建立日期
objzx_TopicObjectiveVerEN.UpdDate = objRow[conzx_TopicObjectiveVer.UpdDate] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.UpdDate].ToString().Trim(); //修改日期
objzx_TopicObjectiveVerEN.UpdUser = objRow[conzx_TopicObjectiveVer.UpdUser] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.UpdUser].ToString().Trim(); //修改人
objzx_TopicObjectiveVerEN.IdCurrEduCls = objRow[conzx_TopicObjectiveVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TopicObjectiveVerEN.PdfContent = objRow[conzx_TopicObjectiveVer.PdfContent] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfContent].ToString().Trim(); //Pdf内容
objzx_TopicObjectiveVerEN.PdfPageNum = objRow[conzx_TopicObjectiveVer.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TopicObjectiveVer.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_TopicObjectiveVerEN.CitationCount = objRow[conzx_TopicObjectiveVer.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TopicObjectiveVer.CitationCount].ToString().Trim()); //引用统计
objzx_TopicObjectiveVerEN.VersionCount = objRow[conzx_TopicObjectiveVer.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TopicObjectiveVer.VersionCount].ToString().Trim()); //版本统计
objzx_TopicObjectiveVerEN.zxShareId = objRow[conzx_TopicObjectiveVer.zxShareId] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.zxShareId].ToString().Trim(); //分享Id
objzx_TopicObjectiveVerEN.Memo = objRow[conzx_TopicObjectiveVer.Memo] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.Memo].ToString().Trim(); //备注
objzx_TopicObjectiveVerEN.PdfDivLet = objRow[conzx_TopicObjectiveVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_TopicObjectiveVerEN.PdfDivTop = objRow[conzx_TopicObjectiveVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_TopicObjectiveVerEN.PdfPageNumIn = objRow[conzx_TopicObjectiveVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_TopicObjectiveVerEN.PdfPageTop = objRow[conzx_TopicObjectiveVer.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TopicObjectiveVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_TopicObjectiveVerEN.PdfZoom = objRow[conzx_TopicObjectiveVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfZoom].ToString().Trim(); //PdfZoom
objzx_TopicObjectiveVerEN.GroupTextId = objRow[conzx_TopicObjectiveVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.GroupTextId].ToString().Trim(); //小组Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clszx_TopicObjectiveVerDA: GetObjByDataRow)", objException.Message));
}
objzx_TopicObjectiveVerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_TopicObjectiveVerEN;
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
objSQL = clszx_TopicObjectiveVerDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clszx_TopicObjectiveVerEN._CurrTabName, conzx_TopicObjectiveVer.TopicObjectiveVId, 8, "");
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
objSQL = clszx_TopicObjectiveVerDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clszx_TopicObjectiveVerEN._CurrTabName, conzx_TopicObjectiveVer.TopicObjectiveVId, 8, strPrefix);
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
 objSQL = clszx_TopicObjectiveVerDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select TopicObjectiveVId from zx_TopicObjectiveVer where " + strCondition;
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
 objSQL = clszx_TopicObjectiveVerDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select TopicObjectiveVId from zx_TopicObjectiveVer where " + strCondition;
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
 /// <param name = "lngTopicObjectiveVId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngTopicObjectiveVId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TopicObjectiveVerDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("zx_TopicObjectiveVer", "TopicObjectiveVId = " + ""+ lngTopicObjectiveVId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clszx_TopicObjectiveVerDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TopicObjectiveVerDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("zx_TopicObjectiveVer", strCondition))
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
objSQL = clszx_TopicObjectiveVerDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("zx_TopicObjectiveVer");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN)
 {
 if (objzx_TopicObjectiveVerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_TopicObjectiveVerEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TopicObjectiveVerDA.GetSpecSQLObj();
strSQL = "Select * from zx_TopicObjectiveVer where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "zx_TopicObjectiveVer");
objRow = objDS.Tables["zx_TopicObjectiveVer"].NewRow();
objRow[conzx_TopicObjectiveVer.zxTopicObjectiveId] = objzx_TopicObjectiveVerEN.zxTopicObjectiveId; //客观Id
 if (objzx_TopicObjectiveVerEN.ObjectiveName !=  "")
 {
objRow[conzx_TopicObjectiveVer.ObjectiveName] = objzx_TopicObjectiveVerEN.ObjectiveName; //客观名称
 }
 if (objzx_TopicObjectiveVerEN.ObjectiveContent !=  "")
 {
objRow[conzx_TopicObjectiveVer.ObjectiveContent] = objzx_TopicObjectiveVerEN.ObjectiveContent; //客观内容
 }
 if (objzx_TopicObjectiveVerEN.ObjectiveType !=  "")
 {
objRow[conzx_TopicObjectiveVer.ObjectiveType] = objzx_TopicObjectiveVerEN.ObjectiveType; //客观类型
 }
 if (objzx_TopicObjectiveVerEN.Conclusion !=  "")
 {
objRow[conzx_TopicObjectiveVer.Conclusion] = objzx_TopicObjectiveVerEN.Conclusion; //结论
 }
 if (objzx_TopicObjectiveVerEN.TextId !=  "")
 {
objRow[conzx_TopicObjectiveVer.TextId] = objzx_TopicObjectiveVerEN.TextId; //课件Id
 }
objRow[conzx_TopicObjectiveVer.IsSubmit] = objzx_TopicObjectiveVerEN.IsSubmit; //是否提交
objRow[conzx_TopicObjectiveVer.VoteCount] = objzx_TopicObjectiveVerEN.VoteCount; //点赞计数
objRow[conzx_TopicObjectiveVer.AppraiseCount] = objzx_TopicObjectiveVerEN.AppraiseCount; //评论数
objRow[conzx_TopicObjectiveVer.Score] = objzx_TopicObjectiveVerEN.Score; //评分
objRow[conzx_TopicObjectiveVer.StuScore] = objzx_TopicObjectiveVerEN.StuScore; //学生平均分
objRow[conzx_TopicObjectiveVer.TeaScore] = objzx_TopicObjectiveVerEN.TeaScore; //教师评分
 if (objzx_TopicObjectiveVerEN.CreateDate !=  "")
 {
objRow[conzx_TopicObjectiveVer.CreateDate] = objzx_TopicObjectiveVerEN.CreateDate; //建立日期
 }
 if (objzx_TopicObjectiveVerEN.UpdDate !=  "")
 {
objRow[conzx_TopicObjectiveVer.UpdDate] = objzx_TopicObjectiveVerEN.UpdDate; //修改日期
 }
 if (objzx_TopicObjectiveVerEN.UpdUser !=  "")
 {
objRow[conzx_TopicObjectiveVer.UpdUser] = objzx_TopicObjectiveVerEN.UpdUser; //修改人
 }
 if (objzx_TopicObjectiveVerEN.IdCurrEduCls !=  "")
 {
objRow[conzx_TopicObjectiveVer.IdCurrEduCls] = objzx_TopicObjectiveVerEN.IdCurrEduCls; //教学班流水号
 }
 if (objzx_TopicObjectiveVerEN.PdfContent !=  "")
 {
objRow[conzx_TopicObjectiveVer.PdfContent] = objzx_TopicObjectiveVerEN.PdfContent; //Pdf内容
 }
objRow[conzx_TopicObjectiveVer.PdfPageNum] = objzx_TopicObjectiveVerEN.PdfPageNum; //Pdf页码
objRow[conzx_TopicObjectiveVer.CitationCount] = objzx_TopicObjectiveVerEN.CitationCount; //引用统计
objRow[conzx_TopicObjectiveVer.VersionCount] = objzx_TopicObjectiveVerEN.VersionCount; //版本统计
 if (objzx_TopicObjectiveVerEN.zxShareId !=  "")
 {
objRow[conzx_TopicObjectiveVer.zxShareId] = objzx_TopicObjectiveVerEN.zxShareId; //分享Id
 }
 if (objzx_TopicObjectiveVerEN.Memo !=  "")
 {
objRow[conzx_TopicObjectiveVer.Memo] = objzx_TopicObjectiveVerEN.Memo; //备注
 }
 if (objzx_TopicObjectiveVerEN.PdfDivLet !=  "")
 {
objRow[conzx_TopicObjectiveVer.PdfDivLet] = objzx_TopicObjectiveVerEN.PdfDivLet; //PdfDivLet
 }
 if (objzx_TopicObjectiveVerEN.PdfDivTop !=  "")
 {
objRow[conzx_TopicObjectiveVer.PdfDivTop] = objzx_TopicObjectiveVerEN.PdfDivTop; //PdfDivTop
 }
 if (objzx_TopicObjectiveVerEN.PdfPageNumIn !=  "")
 {
objRow[conzx_TopicObjectiveVer.PdfPageNumIn] = objzx_TopicObjectiveVerEN.PdfPageNumIn; //PdfPageNumIn
 }
objRow[conzx_TopicObjectiveVer.PdfPageTop] = objzx_TopicObjectiveVerEN.PdfPageTop; //pdf页面顶部位置
 if (objzx_TopicObjectiveVerEN.PdfZoom !=  "")
 {
objRow[conzx_TopicObjectiveVer.PdfZoom] = objzx_TopicObjectiveVerEN.PdfZoom; //PdfZoom
 }
 if (objzx_TopicObjectiveVerEN.GroupTextId !=  "")
 {
objRow[conzx_TopicObjectiveVer.GroupTextId] = objzx_TopicObjectiveVerEN.GroupTextId; //小组Id
 }
objDS.Tables[clszx_TopicObjectiveVerEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clszx_TopicObjectiveVerEN._CurrTabName);
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
 /// <param name = "objzx_TopicObjectiveVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN)
{
 if (objzx_TopicObjectiveVerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_TopicObjectiveVerEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objzx_TopicObjectiveVerEN.zxTopicObjectiveId !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.zxTopicObjectiveId);
 var strzxTopicObjectiveId = objzx_TopicObjectiveVerEN.zxTopicObjectiveId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxTopicObjectiveId + "'");
 }
 
 if (objzx_TopicObjectiveVerEN.ObjectiveName !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.ObjectiveName);
 var strObjectiveName = objzx_TopicObjectiveVerEN.ObjectiveName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strObjectiveName + "'");
 }
 
 if (objzx_TopicObjectiveVerEN.ObjectiveContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.ObjectiveContent);
 var strObjectiveContent = objzx_TopicObjectiveVerEN.ObjectiveContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strObjectiveContent + "'");
 }
 
 if (objzx_TopicObjectiveVerEN.ObjectiveType !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.ObjectiveType);
 var strObjectiveType = objzx_TopicObjectiveVerEN.ObjectiveType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strObjectiveType + "'");
 }
 
 if (objzx_TopicObjectiveVerEN.Conclusion !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.Conclusion);
 var strConclusion = objzx_TopicObjectiveVerEN.Conclusion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConclusion + "'");
 }
 
 if (objzx_TopicObjectiveVerEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.TextId);
 var strTextId = objzx_TopicObjectiveVerEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_TopicObjectiveVerEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_TopicObjectiveVerEN.VoteCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.VoteCount);
 arrValueListForInsert.Add(objzx_TopicObjectiveVerEN.VoteCount.ToString());
 }
 
 if (objzx_TopicObjectiveVerEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.AppraiseCount);
 arrValueListForInsert.Add(objzx_TopicObjectiveVerEN.AppraiseCount.ToString());
 }
 
 if (objzx_TopicObjectiveVerEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.Score);
 arrValueListForInsert.Add(objzx_TopicObjectiveVerEN.Score.ToString());
 }
 
 if (objzx_TopicObjectiveVerEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.StuScore);
 arrValueListForInsert.Add(objzx_TopicObjectiveVerEN.StuScore.ToString());
 }
 
 if (objzx_TopicObjectiveVerEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.TeaScore);
 arrValueListForInsert.Add(objzx_TopicObjectiveVerEN.TeaScore.ToString());
 }
 
 if (objzx_TopicObjectiveVerEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.CreateDate);
 var strCreateDate = objzx_TopicObjectiveVerEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objzx_TopicObjectiveVerEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.UpdDate);
 var strUpdDate = objzx_TopicObjectiveVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_TopicObjectiveVerEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.UpdUser);
 var strUpdUser = objzx_TopicObjectiveVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_TopicObjectiveVerEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.IdCurrEduCls);
 var strIdCurrEduCls = objzx_TopicObjectiveVerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objzx_TopicObjectiveVerEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.PdfContent);
 var strPdfContent = objzx_TopicObjectiveVerEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objzx_TopicObjectiveVerEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.PdfPageNum);
 arrValueListForInsert.Add(objzx_TopicObjectiveVerEN.PdfPageNum.ToString());
 }
 
 if (objzx_TopicObjectiveVerEN.CitationCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.CitationCount);
 arrValueListForInsert.Add(objzx_TopicObjectiveVerEN.CitationCount.ToString());
 }
 
 if (objzx_TopicObjectiveVerEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.VersionCount);
 arrValueListForInsert.Add(objzx_TopicObjectiveVerEN.VersionCount.ToString());
 }
 
 if (objzx_TopicObjectiveVerEN.zxShareId !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.zxShareId);
 var strzxShareId = objzx_TopicObjectiveVerEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxShareId + "'");
 }
 
 if (objzx_TopicObjectiveVerEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.Memo);
 var strMemo = objzx_TopicObjectiveVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_TopicObjectiveVerEN.PdfDivLet !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.PdfDivLet);
 var strPdfDivLet = objzx_TopicObjectiveVerEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivLet + "'");
 }
 
 if (objzx_TopicObjectiveVerEN.PdfDivTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.PdfDivTop);
 var strPdfDivTop = objzx_TopicObjectiveVerEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivTop + "'");
 }
 
 if (objzx_TopicObjectiveVerEN.PdfPageNumIn !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.PdfPageNumIn);
 var strPdfPageNumIn = objzx_TopicObjectiveVerEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfPageNumIn + "'");
 }
 
 if (objzx_TopicObjectiveVerEN.PdfPageTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.PdfPageTop);
 arrValueListForInsert.Add(objzx_TopicObjectiveVerEN.PdfPageTop.ToString());
 }
 
 if (objzx_TopicObjectiveVerEN.PdfZoom !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.PdfZoom);
 var strPdfZoom = objzx_TopicObjectiveVerEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfZoom + "'");
 }
 
 if (objzx_TopicObjectiveVerEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.GroupTextId);
 var strGroupTextId = objzx_TopicObjectiveVerEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_TopicObjectiveVer");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TopicObjectiveVerDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN)
{
 if (objzx_TopicObjectiveVerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_TopicObjectiveVerEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objzx_TopicObjectiveVerEN.zxTopicObjectiveId !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.zxTopicObjectiveId);
 var strzxTopicObjectiveId = objzx_TopicObjectiveVerEN.zxTopicObjectiveId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxTopicObjectiveId + "'");
 }
 
 if (objzx_TopicObjectiveVerEN.ObjectiveName !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.ObjectiveName);
 var strObjectiveName = objzx_TopicObjectiveVerEN.ObjectiveName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strObjectiveName + "'");
 }
 
 if (objzx_TopicObjectiveVerEN.ObjectiveContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.ObjectiveContent);
 var strObjectiveContent = objzx_TopicObjectiveVerEN.ObjectiveContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strObjectiveContent + "'");
 }
 
 if (objzx_TopicObjectiveVerEN.ObjectiveType !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.ObjectiveType);
 var strObjectiveType = objzx_TopicObjectiveVerEN.ObjectiveType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strObjectiveType + "'");
 }
 
 if (objzx_TopicObjectiveVerEN.Conclusion !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.Conclusion);
 var strConclusion = objzx_TopicObjectiveVerEN.Conclusion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConclusion + "'");
 }
 
 if (objzx_TopicObjectiveVerEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.TextId);
 var strTextId = objzx_TopicObjectiveVerEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_TopicObjectiveVerEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_TopicObjectiveVerEN.VoteCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.VoteCount);
 arrValueListForInsert.Add(objzx_TopicObjectiveVerEN.VoteCount.ToString());
 }
 
 if (objzx_TopicObjectiveVerEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.AppraiseCount);
 arrValueListForInsert.Add(objzx_TopicObjectiveVerEN.AppraiseCount.ToString());
 }
 
 if (objzx_TopicObjectiveVerEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.Score);
 arrValueListForInsert.Add(objzx_TopicObjectiveVerEN.Score.ToString());
 }
 
 if (objzx_TopicObjectiveVerEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.StuScore);
 arrValueListForInsert.Add(objzx_TopicObjectiveVerEN.StuScore.ToString());
 }
 
 if (objzx_TopicObjectiveVerEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.TeaScore);
 arrValueListForInsert.Add(objzx_TopicObjectiveVerEN.TeaScore.ToString());
 }
 
 if (objzx_TopicObjectiveVerEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.CreateDate);
 var strCreateDate = objzx_TopicObjectiveVerEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objzx_TopicObjectiveVerEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.UpdDate);
 var strUpdDate = objzx_TopicObjectiveVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_TopicObjectiveVerEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.UpdUser);
 var strUpdUser = objzx_TopicObjectiveVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_TopicObjectiveVerEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.IdCurrEduCls);
 var strIdCurrEduCls = objzx_TopicObjectiveVerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objzx_TopicObjectiveVerEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.PdfContent);
 var strPdfContent = objzx_TopicObjectiveVerEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objzx_TopicObjectiveVerEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.PdfPageNum);
 arrValueListForInsert.Add(objzx_TopicObjectiveVerEN.PdfPageNum.ToString());
 }
 
 if (objzx_TopicObjectiveVerEN.CitationCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.CitationCount);
 arrValueListForInsert.Add(objzx_TopicObjectiveVerEN.CitationCount.ToString());
 }
 
 if (objzx_TopicObjectiveVerEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.VersionCount);
 arrValueListForInsert.Add(objzx_TopicObjectiveVerEN.VersionCount.ToString());
 }
 
 if (objzx_TopicObjectiveVerEN.zxShareId !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.zxShareId);
 var strzxShareId = objzx_TopicObjectiveVerEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxShareId + "'");
 }
 
 if (objzx_TopicObjectiveVerEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.Memo);
 var strMemo = objzx_TopicObjectiveVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_TopicObjectiveVerEN.PdfDivLet !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.PdfDivLet);
 var strPdfDivLet = objzx_TopicObjectiveVerEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivLet + "'");
 }
 
 if (objzx_TopicObjectiveVerEN.PdfDivTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.PdfDivTop);
 var strPdfDivTop = objzx_TopicObjectiveVerEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivTop + "'");
 }
 
 if (objzx_TopicObjectiveVerEN.PdfPageNumIn !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.PdfPageNumIn);
 var strPdfPageNumIn = objzx_TopicObjectiveVerEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfPageNumIn + "'");
 }
 
 if (objzx_TopicObjectiveVerEN.PdfPageTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.PdfPageTop);
 arrValueListForInsert.Add(objzx_TopicObjectiveVerEN.PdfPageTop.ToString());
 }
 
 if (objzx_TopicObjectiveVerEN.PdfZoom !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.PdfZoom);
 var strPdfZoom = objzx_TopicObjectiveVerEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfZoom + "'");
 }
 
 if (objzx_TopicObjectiveVerEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.GroupTextId);
 var strGroupTextId = objzx_TopicObjectiveVerEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_TopicObjectiveVer");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TopicObjectiveVerDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveVerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objzx_TopicObjectiveVerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_TopicObjectiveVerEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objzx_TopicObjectiveVerEN.zxTopicObjectiveId !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.zxTopicObjectiveId);
 var strzxTopicObjectiveId = objzx_TopicObjectiveVerEN.zxTopicObjectiveId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxTopicObjectiveId + "'");
 }
 
 if (objzx_TopicObjectiveVerEN.ObjectiveName !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.ObjectiveName);
 var strObjectiveName = objzx_TopicObjectiveVerEN.ObjectiveName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strObjectiveName + "'");
 }
 
 if (objzx_TopicObjectiveVerEN.ObjectiveContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.ObjectiveContent);
 var strObjectiveContent = objzx_TopicObjectiveVerEN.ObjectiveContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strObjectiveContent + "'");
 }
 
 if (objzx_TopicObjectiveVerEN.ObjectiveType !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.ObjectiveType);
 var strObjectiveType = objzx_TopicObjectiveVerEN.ObjectiveType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strObjectiveType + "'");
 }
 
 if (objzx_TopicObjectiveVerEN.Conclusion !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.Conclusion);
 var strConclusion = objzx_TopicObjectiveVerEN.Conclusion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConclusion + "'");
 }
 
 if (objzx_TopicObjectiveVerEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.TextId);
 var strTextId = objzx_TopicObjectiveVerEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_TopicObjectiveVerEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_TopicObjectiveVerEN.VoteCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.VoteCount);
 arrValueListForInsert.Add(objzx_TopicObjectiveVerEN.VoteCount.ToString());
 }
 
 if (objzx_TopicObjectiveVerEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.AppraiseCount);
 arrValueListForInsert.Add(objzx_TopicObjectiveVerEN.AppraiseCount.ToString());
 }
 
 if (objzx_TopicObjectiveVerEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.Score);
 arrValueListForInsert.Add(objzx_TopicObjectiveVerEN.Score.ToString());
 }
 
 if (objzx_TopicObjectiveVerEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.StuScore);
 arrValueListForInsert.Add(objzx_TopicObjectiveVerEN.StuScore.ToString());
 }
 
 if (objzx_TopicObjectiveVerEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.TeaScore);
 arrValueListForInsert.Add(objzx_TopicObjectiveVerEN.TeaScore.ToString());
 }
 
 if (objzx_TopicObjectiveVerEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.CreateDate);
 var strCreateDate = objzx_TopicObjectiveVerEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objzx_TopicObjectiveVerEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.UpdDate);
 var strUpdDate = objzx_TopicObjectiveVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_TopicObjectiveVerEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.UpdUser);
 var strUpdUser = objzx_TopicObjectiveVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_TopicObjectiveVerEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.IdCurrEduCls);
 var strIdCurrEduCls = objzx_TopicObjectiveVerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objzx_TopicObjectiveVerEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.PdfContent);
 var strPdfContent = objzx_TopicObjectiveVerEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objzx_TopicObjectiveVerEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.PdfPageNum);
 arrValueListForInsert.Add(objzx_TopicObjectiveVerEN.PdfPageNum.ToString());
 }
 
 if (objzx_TopicObjectiveVerEN.CitationCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.CitationCount);
 arrValueListForInsert.Add(objzx_TopicObjectiveVerEN.CitationCount.ToString());
 }
 
 if (objzx_TopicObjectiveVerEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.VersionCount);
 arrValueListForInsert.Add(objzx_TopicObjectiveVerEN.VersionCount.ToString());
 }
 
 if (objzx_TopicObjectiveVerEN.zxShareId !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.zxShareId);
 var strzxShareId = objzx_TopicObjectiveVerEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxShareId + "'");
 }
 
 if (objzx_TopicObjectiveVerEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.Memo);
 var strMemo = objzx_TopicObjectiveVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_TopicObjectiveVerEN.PdfDivLet !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.PdfDivLet);
 var strPdfDivLet = objzx_TopicObjectiveVerEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivLet + "'");
 }
 
 if (objzx_TopicObjectiveVerEN.PdfDivTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.PdfDivTop);
 var strPdfDivTop = objzx_TopicObjectiveVerEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivTop + "'");
 }
 
 if (objzx_TopicObjectiveVerEN.PdfPageNumIn !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.PdfPageNumIn);
 var strPdfPageNumIn = objzx_TopicObjectiveVerEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfPageNumIn + "'");
 }
 
 if (objzx_TopicObjectiveVerEN.PdfPageTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.PdfPageTop);
 arrValueListForInsert.Add(objzx_TopicObjectiveVerEN.PdfPageTop.ToString());
 }
 
 if (objzx_TopicObjectiveVerEN.PdfZoom !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.PdfZoom);
 var strPdfZoom = objzx_TopicObjectiveVerEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfZoom + "'");
 }
 
 if (objzx_TopicObjectiveVerEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.GroupTextId);
 var strGroupTextId = objzx_TopicObjectiveVerEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_TopicObjectiveVer");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TopicObjectiveVerDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveVerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objzx_TopicObjectiveVerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_TopicObjectiveVerEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objzx_TopicObjectiveVerEN.zxTopicObjectiveId !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.zxTopicObjectiveId);
 var strzxTopicObjectiveId = objzx_TopicObjectiveVerEN.zxTopicObjectiveId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxTopicObjectiveId + "'");
 }
 
 if (objzx_TopicObjectiveVerEN.ObjectiveName !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.ObjectiveName);
 var strObjectiveName = objzx_TopicObjectiveVerEN.ObjectiveName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strObjectiveName + "'");
 }
 
 if (objzx_TopicObjectiveVerEN.ObjectiveContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.ObjectiveContent);
 var strObjectiveContent = objzx_TopicObjectiveVerEN.ObjectiveContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strObjectiveContent + "'");
 }
 
 if (objzx_TopicObjectiveVerEN.ObjectiveType !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.ObjectiveType);
 var strObjectiveType = objzx_TopicObjectiveVerEN.ObjectiveType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strObjectiveType + "'");
 }
 
 if (objzx_TopicObjectiveVerEN.Conclusion !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.Conclusion);
 var strConclusion = objzx_TopicObjectiveVerEN.Conclusion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConclusion + "'");
 }
 
 if (objzx_TopicObjectiveVerEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.TextId);
 var strTextId = objzx_TopicObjectiveVerEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_TopicObjectiveVerEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_TopicObjectiveVerEN.VoteCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.VoteCount);
 arrValueListForInsert.Add(objzx_TopicObjectiveVerEN.VoteCount.ToString());
 }
 
 if (objzx_TopicObjectiveVerEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.AppraiseCount);
 arrValueListForInsert.Add(objzx_TopicObjectiveVerEN.AppraiseCount.ToString());
 }
 
 if (objzx_TopicObjectiveVerEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.Score);
 arrValueListForInsert.Add(objzx_TopicObjectiveVerEN.Score.ToString());
 }
 
 if (objzx_TopicObjectiveVerEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.StuScore);
 arrValueListForInsert.Add(objzx_TopicObjectiveVerEN.StuScore.ToString());
 }
 
 if (objzx_TopicObjectiveVerEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.TeaScore);
 arrValueListForInsert.Add(objzx_TopicObjectiveVerEN.TeaScore.ToString());
 }
 
 if (objzx_TopicObjectiveVerEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.CreateDate);
 var strCreateDate = objzx_TopicObjectiveVerEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objzx_TopicObjectiveVerEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.UpdDate);
 var strUpdDate = objzx_TopicObjectiveVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_TopicObjectiveVerEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.UpdUser);
 var strUpdUser = objzx_TopicObjectiveVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_TopicObjectiveVerEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.IdCurrEduCls);
 var strIdCurrEduCls = objzx_TopicObjectiveVerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objzx_TopicObjectiveVerEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.PdfContent);
 var strPdfContent = objzx_TopicObjectiveVerEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objzx_TopicObjectiveVerEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.PdfPageNum);
 arrValueListForInsert.Add(objzx_TopicObjectiveVerEN.PdfPageNum.ToString());
 }
 
 if (objzx_TopicObjectiveVerEN.CitationCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.CitationCount);
 arrValueListForInsert.Add(objzx_TopicObjectiveVerEN.CitationCount.ToString());
 }
 
 if (objzx_TopicObjectiveVerEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.VersionCount);
 arrValueListForInsert.Add(objzx_TopicObjectiveVerEN.VersionCount.ToString());
 }
 
 if (objzx_TopicObjectiveVerEN.zxShareId !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.zxShareId);
 var strzxShareId = objzx_TopicObjectiveVerEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxShareId + "'");
 }
 
 if (objzx_TopicObjectiveVerEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.Memo);
 var strMemo = objzx_TopicObjectiveVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_TopicObjectiveVerEN.PdfDivLet !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.PdfDivLet);
 var strPdfDivLet = objzx_TopicObjectiveVerEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivLet + "'");
 }
 
 if (objzx_TopicObjectiveVerEN.PdfDivTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.PdfDivTop);
 var strPdfDivTop = objzx_TopicObjectiveVerEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivTop + "'");
 }
 
 if (objzx_TopicObjectiveVerEN.PdfPageNumIn !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.PdfPageNumIn);
 var strPdfPageNumIn = objzx_TopicObjectiveVerEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfPageNumIn + "'");
 }
 
 if (objzx_TopicObjectiveVerEN.PdfPageTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.PdfPageTop);
 arrValueListForInsert.Add(objzx_TopicObjectiveVerEN.PdfPageTop.ToString());
 }
 
 if (objzx_TopicObjectiveVerEN.PdfZoom !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.PdfZoom);
 var strPdfZoom = objzx_TopicObjectiveVerEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfZoom + "'");
 }
 
 if (objzx_TopicObjectiveVerEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_TopicObjectiveVer.GroupTextId);
 var strGroupTextId = objzx_TopicObjectiveVerEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_TopicObjectiveVer");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TopicObjectiveVerDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewzx_TopicObjectiveVers(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TopicObjectiveVerDA.GetSpecSQLObj();
strSQL = "Select * from zx_TopicObjectiveVer where TopicObjectiveVId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "zx_TopicObjectiveVer");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngTopicObjectiveVId = TransNullToInt(oRow[conzx_TopicObjectiveVer.TopicObjectiveVId].ToString().Trim());
if (IsExist(lngTopicObjectiveVId))
{
 string strResult = "关键字变量值为:" + string.Format("TopicObjectiveVId = {0}", lngTopicObjectiveVId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clszx_TopicObjectiveVerEN._CurrTabName ].NewRow();
objRow[conzx_TopicObjectiveVer.zxTopicObjectiveId] = oRow[conzx_TopicObjectiveVer.zxTopicObjectiveId].ToString().Trim(); //客观Id
objRow[conzx_TopicObjectiveVer.ObjectiveName] = oRow[conzx_TopicObjectiveVer.ObjectiveName].ToString().Trim(); //客观名称
objRow[conzx_TopicObjectiveVer.ObjectiveContent] = oRow[conzx_TopicObjectiveVer.ObjectiveContent].ToString().Trim(); //客观内容
objRow[conzx_TopicObjectiveVer.ObjectiveType] = oRow[conzx_TopicObjectiveVer.ObjectiveType].ToString().Trim(); //客观类型
objRow[conzx_TopicObjectiveVer.Conclusion] = oRow[conzx_TopicObjectiveVer.Conclusion].ToString().Trim(); //结论
objRow[conzx_TopicObjectiveVer.TextId] = oRow[conzx_TopicObjectiveVer.TextId].ToString().Trim(); //课件Id
objRow[conzx_TopicObjectiveVer.IsSubmit] = oRow[conzx_TopicObjectiveVer.IsSubmit].ToString().Trim(); //是否提交
objRow[conzx_TopicObjectiveVer.VoteCount] = oRow[conzx_TopicObjectiveVer.VoteCount].ToString().Trim(); //点赞计数
objRow[conzx_TopicObjectiveVer.AppraiseCount] = oRow[conzx_TopicObjectiveVer.AppraiseCount].ToString().Trim(); //评论数
objRow[conzx_TopicObjectiveVer.Score] = oRow[conzx_TopicObjectiveVer.Score].ToString().Trim(); //评分
objRow[conzx_TopicObjectiveVer.StuScore] = oRow[conzx_TopicObjectiveVer.StuScore].ToString().Trim(); //学生平均分
objRow[conzx_TopicObjectiveVer.TeaScore] = oRow[conzx_TopicObjectiveVer.TeaScore].ToString().Trim(); //教师评分
objRow[conzx_TopicObjectiveVer.CreateDate] = oRow[conzx_TopicObjectiveVer.CreateDate].ToString().Trim(); //建立日期
objRow[conzx_TopicObjectiveVer.UpdDate] = oRow[conzx_TopicObjectiveVer.UpdDate].ToString().Trim(); //修改日期
objRow[conzx_TopicObjectiveVer.UpdUser] = oRow[conzx_TopicObjectiveVer.UpdUser].ToString().Trim(); //修改人
objRow[conzx_TopicObjectiveVer.IdCurrEduCls] = oRow[conzx_TopicObjectiveVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objRow[conzx_TopicObjectiveVer.PdfContent] = oRow[conzx_TopicObjectiveVer.PdfContent].ToString().Trim(); //Pdf内容
objRow[conzx_TopicObjectiveVer.PdfPageNum] = oRow[conzx_TopicObjectiveVer.PdfPageNum].ToString().Trim(); //Pdf页码
objRow[conzx_TopicObjectiveVer.CitationCount] = oRow[conzx_TopicObjectiveVer.CitationCount].ToString().Trim(); //引用统计
objRow[conzx_TopicObjectiveVer.VersionCount] = oRow[conzx_TopicObjectiveVer.VersionCount].ToString().Trim(); //版本统计
objRow[conzx_TopicObjectiveVer.zxShareId] = oRow[conzx_TopicObjectiveVer.zxShareId].ToString().Trim(); //分享Id
objRow[conzx_TopicObjectiveVer.Memo] = oRow[conzx_TopicObjectiveVer.Memo].ToString().Trim(); //备注
objRow[conzx_TopicObjectiveVer.PdfDivLet] = oRow[conzx_TopicObjectiveVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objRow[conzx_TopicObjectiveVer.PdfDivTop] = oRow[conzx_TopicObjectiveVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objRow[conzx_TopicObjectiveVer.PdfPageNumIn] = oRow[conzx_TopicObjectiveVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objRow[conzx_TopicObjectiveVer.PdfPageTop] = oRow[conzx_TopicObjectiveVer.PdfPageTop].ToString().Trim(); //pdf页面顶部位置
objRow[conzx_TopicObjectiveVer.PdfZoom] = oRow[conzx_TopicObjectiveVer.PdfZoom].ToString().Trim(); //PdfZoom
objRow[conzx_TopicObjectiveVer.GroupTextId] = oRow[conzx_TopicObjectiveVer.GroupTextId].ToString().Trim(); //小组Id
 objDS.Tables[clszx_TopicObjectiveVerEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clszx_TopicObjectiveVerEN._CurrTabName);
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
 /// <param name = "objzx_TopicObjectiveVerEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN)
{
 if (objzx_TopicObjectiveVerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_TopicObjectiveVerEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TopicObjectiveVerDA.GetSpecSQLObj();
strSQL = "Select * from zx_TopicObjectiveVer where TopicObjectiveVId = " + ""+ objzx_TopicObjectiveVerEN.TopicObjectiveVId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clszx_TopicObjectiveVerEN._CurrTabName);
if (objDS.Tables[clszx_TopicObjectiveVerEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:TopicObjectiveVId = " + ""+ objzx_TopicObjectiveVerEN.TopicObjectiveVId+"");
return false;
}
objRow = objDS.Tables[clszx_TopicObjectiveVerEN._CurrTabName].Rows[0];
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.zxTopicObjectiveId))
 {
objRow[conzx_TopicObjectiveVer.zxTopicObjectiveId] = objzx_TopicObjectiveVerEN.zxTopicObjectiveId; //客观Id
 }
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.ObjectiveName))
 {
objRow[conzx_TopicObjectiveVer.ObjectiveName] = objzx_TopicObjectiveVerEN.ObjectiveName; //客观名称
 }
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.ObjectiveContent))
 {
objRow[conzx_TopicObjectiveVer.ObjectiveContent] = objzx_TopicObjectiveVerEN.ObjectiveContent; //客观内容
 }
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.ObjectiveType))
 {
objRow[conzx_TopicObjectiveVer.ObjectiveType] = objzx_TopicObjectiveVerEN.ObjectiveType; //客观类型
 }
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.Conclusion))
 {
objRow[conzx_TopicObjectiveVer.Conclusion] = objzx_TopicObjectiveVerEN.Conclusion; //结论
 }
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.TextId))
 {
objRow[conzx_TopicObjectiveVer.TextId] = objzx_TopicObjectiveVerEN.TextId; //课件Id
 }
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.IsSubmit))
 {
objRow[conzx_TopicObjectiveVer.IsSubmit] = objzx_TopicObjectiveVerEN.IsSubmit; //是否提交
 }
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.VoteCount))
 {
objRow[conzx_TopicObjectiveVer.VoteCount] = objzx_TopicObjectiveVerEN.VoteCount; //点赞计数
 }
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.AppraiseCount))
 {
objRow[conzx_TopicObjectiveVer.AppraiseCount] = objzx_TopicObjectiveVerEN.AppraiseCount; //评论数
 }
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.Score))
 {
objRow[conzx_TopicObjectiveVer.Score] = objzx_TopicObjectiveVerEN.Score; //评分
 }
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.StuScore))
 {
objRow[conzx_TopicObjectiveVer.StuScore] = objzx_TopicObjectiveVerEN.StuScore; //学生平均分
 }
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.TeaScore))
 {
objRow[conzx_TopicObjectiveVer.TeaScore] = objzx_TopicObjectiveVerEN.TeaScore; //教师评分
 }
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.CreateDate))
 {
objRow[conzx_TopicObjectiveVer.CreateDate] = objzx_TopicObjectiveVerEN.CreateDate; //建立日期
 }
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.UpdDate))
 {
objRow[conzx_TopicObjectiveVer.UpdDate] = objzx_TopicObjectiveVerEN.UpdDate; //修改日期
 }
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.UpdUser))
 {
objRow[conzx_TopicObjectiveVer.UpdUser] = objzx_TopicObjectiveVerEN.UpdUser; //修改人
 }
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.IdCurrEduCls))
 {
objRow[conzx_TopicObjectiveVer.IdCurrEduCls] = objzx_TopicObjectiveVerEN.IdCurrEduCls; //教学班流水号
 }
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.PdfContent))
 {
objRow[conzx_TopicObjectiveVer.PdfContent] = objzx_TopicObjectiveVerEN.PdfContent; //Pdf内容
 }
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.PdfPageNum))
 {
objRow[conzx_TopicObjectiveVer.PdfPageNum] = objzx_TopicObjectiveVerEN.PdfPageNum; //Pdf页码
 }
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.CitationCount))
 {
objRow[conzx_TopicObjectiveVer.CitationCount] = objzx_TopicObjectiveVerEN.CitationCount; //引用统计
 }
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.VersionCount))
 {
objRow[conzx_TopicObjectiveVer.VersionCount] = objzx_TopicObjectiveVerEN.VersionCount; //版本统计
 }
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.zxShareId))
 {
objRow[conzx_TopicObjectiveVer.zxShareId] = objzx_TopicObjectiveVerEN.zxShareId; //分享Id
 }
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.Memo))
 {
objRow[conzx_TopicObjectiveVer.Memo] = objzx_TopicObjectiveVerEN.Memo; //备注
 }
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.PdfDivLet))
 {
objRow[conzx_TopicObjectiveVer.PdfDivLet] = objzx_TopicObjectiveVerEN.PdfDivLet; //PdfDivLet
 }
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.PdfDivTop))
 {
objRow[conzx_TopicObjectiveVer.PdfDivTop] = objzx_TopicObjectiveVerEN.PdfDivTop; //PdfDivTop
 }
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.PdfPageNumIn))
 {
objRow[conzx_TopicObjectiveVer.PdfPageNumIn] = objzx_TopicObjectiveVerEN.PdfPageNumIn; //PdfPageNumIn
 }
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.PdfPageTop))
 {
objRow[conzx_TopicObjectiveVer.PdfPageTop] = objzx_TopicObjectiveVerEN.PdfPageTop; //pdf页面顶部位置
 }
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.PdfZoom))
 {
objRow[conzx_TopicObjectiveVer.PdfZoom] = objzx_TopicObjectiveVerEN.PdfZoom; //PdfZoom
 }
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.GroupTextId))
 {
objRow[conzx_TopicObjectiveVer.GroupTextId] = objzx_TopicObjectiveVerEN.GroupTextId; //小组Id
 }
try
{
objDA.Update(objDS, clszx_TopicObjectiveVerEN._CurrTabName);
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
 /// <param name = "objzx_TopicObjectiveVerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN)
{
 if (objzx_TopicObjectiveVerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_TopicObjectiveVerEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TopicObjectiveVerDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update zx_TopicObjectiveVer Set ");
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.zxTopicObjectiveId))
 {
 if (objzx_TopicObjectiveVerEN.zxTopicObjectiveId !=  null)
 {
 var strzxTopicObjectiveId = objzx_TopicObjectiveVerEN.zxTopicObjectiveId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxTopicObjectiveId, conzx_TopicObjectiveVer.zxTopicObjectiveId); //客观Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjectiveVer.zxTopicObjectiveId); //客观Id
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.ObjectiveName))
 {
 if (objzx_TopicObjectiveVerEN.ObjectiveName !=  null)
 {
 var strObjectiveName = objzx_TopicObjectiveVerEN.ObjectiveName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strObjectiveName, conzx_TopicObjectiveVer.ObjectiveName); //客观名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjectiveVer.ObjectiveName); //客观名称
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.ObjectiveContent))
 {
 if (objzx_TopicObjectiveVerEN.ObjectiveContent !=  null)
 {
 var strObjectiveContent = objzx_TopicObjectiveVerEN.ObjectiveContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strObjectiveContent, conzx_TopicObjectiveVer.ObjectiveContent); //客观内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjectiveVer.ObjectiveContent); //客观内容
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.ObjectiveType))
 {
 if (objzx_TopicObjectiveVerEN.ObjectiveType !=  null)
 {
 var strObjectiveType = objzx_TopicObjectiveVerEN.ObjectiveType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strObjectiveType, conzx_TopicObjectiveVer.ObjectiveType); //客观类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjectiveVer.ObjectiveType); //客观类型
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.Conclusion))
 {
 if (objzx_TopicObjectiveVerEN.Conclusion !=  null)
 {
 var strConclusion = objzx_TopicObjectiveVerEN.Conclusion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strConclusion, conzx_TopicObjectiveVer.Conclusion); //结论
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjectiveVer.Conclusion); //结论
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.TextId))
 {
 if (objzx_TopicObjectiveVerEN.TextId !=  null)
 {
 var strTextId = objzx_TopicObjectiveVerEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTextId, conzx_TopicObjectiveVer.TextId); //课件Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjectiveVer.TextId); //课件Id
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objzx_TopicObjectiveVerEN.IsSubmit == true?"1":"0", conzx_TopicObjectiveVer.IsSubmit); //是否提交
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.VoteCount))
 {
 if (objzx_TopicObjectiveVerEN.VoteCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TopicObjectiveVerEN.VoteCount, conzx_TopicObjectiveVer.VoteCount); //点赞计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjectiveVer.VoteCount); //点赞计数
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.AppraiseCount))
 {
 if (objzx_TopicObjectiveVerEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TopicObjectiveVerEN.AppraiseCount, conzx_TopicObjectiveVer.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjectiveVer.AppraiseCount); //评论数
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.Score))
 {
 if (objzx_TopicObjectiveVerEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TopicObjectiveVerEN.Score, conzx_TopicObjectiveVer.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjectiveVer.Score); //评分
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.StuScore))
 {
 if (objzx_TopicObjectiveVerEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TopicObjectiveVerEN.StuScore, conzx_TopicObjectiveVer.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjectiveVer.StuScore); //学生平均分
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.TeaScore))
 {
 if (objzx_TopicObjectiveVerEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TopicObjectiveVerEN.TeaScore, conzx_TopicObjectiveVer.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjectiveVer.TeaScore); //教师评分
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.CreateDate))
 {
 if (objzx_TopicObjectiveVerEN.CreateDate !=  null)
 {
 var strCreateDate = objzx_TopicObjectiveVerEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateDate, conzx_TopicObjectiveVer.CreateDate); //建立日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjectiveVer.CreateDate); //建立日期
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.UpdDate))
 {
 if (objzx_TopicObjectiveVerEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_TopicObjectiveVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conzx_TopicObjectiveVer.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjectiveVer.UpdDate); //修改日期
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.UpdUser))
 {
 if (objzx_TopicObjectiveVerEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_TopicObjectiveVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conzx_TopicObjectiveVer.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjectiveVer.UpdUser); //修改人
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.IdCurrEduCls))
 {
 if (objzx_TopicObjectiveVerEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_TopicObjectiveVerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conzx_TopicObjectiveVer.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjectiveVer.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.PdfContent))
 {
 if (objzx_TopicObjectiveVerEN.PdfContent !=  null)
 {
 var strPdfContent = objzx_TopicObjectiveVerEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfContent, conzx_TopicObjectiveVer.PdfContent); //Pdf内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjectiveVer.PdfContent); //Pdf内容
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.PdfPageNum))
 {
 if (objzx_TopicObjectiveVerEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TopicObjectiveVerEN.PdfPageNum, conzx_TopicObjectiveVer.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjectiveVer.PdfPageNum); //Pdf页码
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.CitationCount))
 {
 if (objzx_TopicObjectiveVerEN.CitationCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TopicObjectiveVerEN.CitationCount, conzx_TopicObjectiveVer.CitationCount); //引用统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjectiveVer.CitationCount); //引用统计
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.VersionCount))
 {
 if (objzx_TopicObjectiveVerEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TopicObjectiveVerEN.VersionCount, conzx_TopicObjectiveVer.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjectiveVer.VersionCount); //版本统计
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.zxShareId))
 {
 if (objzx_TopicObjectiveVerEN.zxShareId !=  null)
 {
 var strzxShareId = objzx_TopicObjectiveVerEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxShareId, conzx_TopicObjectiveVer.zxShareId); //分享Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjectiveVer.zxShareId); //分享Id
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.Memo))
 {
 if (objzx_TopicObjectiveVerEN.Memo !=  null)
 {
 var strMemo = objzx_TopicObjectiveVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conzx_TopicObjectiveVer.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjectiveVer.Memo); //备注
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.PdfDivLet))
 {
 if (objzx_TopicObjectiveVerEN.PdfDivLet !=  null)
 {
 var strPdfDivLet = objzx_TopicObjectiveVerEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfDivLet, conzx_TopicObjectiveVer.PdfDivLet); //PdfDivLet
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjectiveVer.PdfDivLet); //PdfDivLet
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.PdfDivTop))
 {
 if (objzx_TopicObjectiveVerEN.PdfDivTop !=  null)
 {
 var strPdfDivTop = objzx_TopicObjectiveVerEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfDivTop, conzx_TopicObjectiveVer.PdfDivTop); //PdfDivTop
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjectiveVer.PdfDivTop); //PdfDivTop
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.PdfPageNumIn))
 {
 if (objzx_TopicObjectiveVerEN.PdfPageNumIn !=  null)
 {
 var strPdfPageNumIn = objzx_TopicObjectiveVerEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfPageNumIn, conzx_TopicObjectiveVer.PdfPageNumIn); //PdfPageNumIn
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjectiveVer.PdfPageNumIn); //PdfPageNumIn
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.PdfPageTop))
 {
 if (objzx_TopicObjectiveVerEN.PdfPageTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TopicObjectiveVerEN.PdfPageTop, conzx_TopicObjectiveVer.PdfPageTop); //pdf页面顶部位置
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjectiveVer.PdfPageTop); //pdf页面顶部位置
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.PdfZoom))
 {
 if (objzx_TopicObjectiveVerEN.PdfZoom !=  null)
 {
 var strPdfZoom = objzx_TopicObjectiveVerEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfZoom, conzx_TopicObjectiveVer.PdfZoom); //PdfZoom
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjectiveVer.PdfZoom); //PdfZoom
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.GroupTextId))
 {
 if (objzx_TopicObjectiveVerEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_TopicObjectiveVerEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGroupTextId, conzx_TopicObjectiveVer.GroupTextId); //小组Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjectiveVer.GroupTextId); //小组Id
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where TopicObjectiveVId = {0}", objzx_TopicObjectiveVerEN.TopicObjectiveVId); 
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
 /// <param name = "objzx_TopicObjectiveVerEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN, string strCondition)
{
 if (objzx_TopicObjectiveVerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_TopicObjectiveVerEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TopicObjectiveVerDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_TopicObjectiveVer Set ");
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.zxTopicObjectiveId))
 {
 if (objzx_TopicObjectiveVerEN.zxTopicObjectiveId !=  null)
 {
 var strzxTopicObjectiveId = objzx_TopicObjectiveVerEN.zxTopicObjectiveId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxTopicObjectiveId = '{0}',", strzxTopicObjectiveId); //客观Id
 }
 else
 {
 sbSQL.Append(" zxTopicObjectiveId = null,"); //客观Id
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.ObjectiveName))
 {
 if (objzx_TopicObjectiveVerEN.ObjectiveName !=  null)
 {
 var strObjectiveName = objzx_TopicObjectiveVerEN.ObjectiveName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ObjectiveName = '{0}',", strObjectiveName); //客观名称
 }
 else
 {
 sbSQL.Append(" ObjectiveName = null,"); //客观名称
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.ObjectiveContent))
 {
 if (objzx_TopicObjectiveVerEN.ObjectiveContent !=  null)
 {
 var strObjectiveContent = objzx_TopicObjectiveVerEN.ObjectiveContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ObjectiveContent = '{0}',", strObjectiveContent); //客观内容
 }
 else
 {
 sbSQL.Append(" ObjectiveContent = null,"); //客观内容
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.ObjectiveType))
 {
 if (objzx_TopicObjectiveVerEN.ObjectiveType !=  null)
 {
 var strObjectiveType = objzx_TopicObjectiveVerEN.ObjectiveType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ObjectiveType = '{0}',", strObjectiveType); //客观类型
 }
 else
 {
 sbSQL.Append(" ObjectiveType = null,"); //客观类型
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.Conclusion))
 {
 if (objzx_TopicObjectiveVerEN.Conclusion !=  null)
 {
 var strConclusion = objzx_TopicObjectiveVerEN.Conclusion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Conclusion = '{0}',", strConclusion); //结论
 }
 else
 {
 sbSQL.Append(" Conclusion = null,"); //结论
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.TextId))
 {
 if (objzx_TopicObjectiveVerEN.TextId !=  null)
 {
 var strTextId = objzx_TopicObjectiveVerEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TextId = '{0}',", strTextId); //课件Id
 }
 else
 {
 sbSQL.Append(" TextId = null,"); //课件Id
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objzx_TopicObjectiveVerEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.VoteCount))
 {
 if (objzx_TopicObjectiveVerEN.VoteCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TopicObjectiveVerEN.VoteCount, conzx_TopicObjectiveVer.VoteCount); //点赞计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjectiveVer.VoteCount); //点赞计数
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.AppraiseCount))
 {
 if (objzx_TopicObjectiveVerEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TopicObjectiveVerEN.AppraiseCount, conzx_TopicObjectiveVer.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjectiveVer.AppraiseCount); //评论数
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.Score))
 {
 if (objzx_TopicObjectiveVerEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TopicObjectiveVerEN.Score, conzx_TopicObjectiveVer.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjectiveVer.Score); //评分
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.StuScore))
 {
 if (objzx_TopicObjectiveVerEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TopicObjectiveVerEN.StuScore, conzx_TopicObjectiveVer.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjectiveVer.StuScore); //学生平均分
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.TeaScore))
 {
 if (objzx_TopicObjectiveVerEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TopicObjectiveVerEN.TeaScore, conzx_TopicObjectiveVer.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjectiveVer.TeaScore); //教师评分
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.CreateDate))
 {
 if (objzx_TopicObjectiveVerEN.CreateDate !=  null)
 {
 var strCreateDate = objzx_TopicObjectiveVerEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateDate = '{0}',", strCreateDate); //建立日期
 }
 else
 {
 sbSQL.Append(" CreateDate = null,"); //建立日期
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.UpdDate))
 {
 if (objzx_TopicObjectiveVerEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_TopicObjectiveVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.UpdUser))
 {
 if (objzx_TopicObjectiveVerEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_TopicObjectiveVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.IdCurrEduCls))
 {
 if (objzx_TopicObjectiveVerEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_TopicObjectiveVerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.PdfContent))
 {
 if (objzx_TopicObjectiveVerEN.PdfContent !=  null)
 {
 var strPdfContent = objzx_TopicObjectiveVerEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfContent = '{0}',", strPdfContent); //Pdf内容
 }
 else
 {
 sbSQL.Append(" PdfContent = null,"); //Pdf内容
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.PdfPageNum))
 {
 if (objzx_TopicObjectiveVerEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TopicObjectiveVerEN.PdfPageNum, conzx_TopicObjectiveVer.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjectiveVer.PdfPageNum); //Pdf页码
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.CitationCount))
 {
 if (objzx_TopicObjectiveVerEN.CitationCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TopicObjectiveVerEN.CitationCount, conzx_TopicObjectiveVer.CitationCount); //引用统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjectiveVer.CitationCount); //引用统计
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.VersionCount))
 {
 if (objzx_TopicObjectiveVerEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TopicObjectiveVerEN.VersionCount, conzx_TopicObjectiveVer.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjectiveVer.VersionCount); //版本统计
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.zxShareId))
 {
 if (objzx_TopicObjectiveVerEN.zxShareId !=  null)
 {
 var strzxShareId = objzx_TopicObjectiveVerEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxShareId = '{0}',", strzxShareId); //分享Id
 }
 else
 {
 sbSQL.Append(" zxShareId = null,"); //分享Id
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.Memo))
 {
 if (objzx_TopicObjectiveVerEN.Memo !=  null)
 {
 var strMemo = objzx_TopicObjectiveVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.PdfDivLet))
 {
 if (objzx_TopicObjectiveVerEN.PdfDivLet !=  null)
 {
 var strPdfDivLet = objzx_TopicObjectiveVerEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfDivLet = '{0}',", strPdfDivLet); //PdfDivLet
 }
 else
 {
 sbSQL.Append(" PdfDivLet = null,"); //PdfDivLet
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.PdfDivTop))
 {
 if (objzx_TopicObjectiveVerEN.PdfDivTop !=  null)
 {
 var strPdfDivTop = objzx_TopicObjectiveVerEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfDivTop = '{0}',", strPdfDivTop); //PdfDivTop
 }
 else
 {
 sbSQL.Append(" PdfDivTop = null,"); //PdfDivTop
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.PdfPageNumIn))
 {
 if (objzx_TopicObjectiveVerEN.PdfPageNumIn !=  null)
 {
 var strPdfPageNumIn = objzx_TopicObjectiveVerEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfPageNumIn = '{0}',", strPdfPageNumIn); //PdfPageNumIn
 }
 else
 {
 sbSQL.Append(" PdfPageNumIn = null,"); //PdfPageNumIn
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.PdfPageTop))
 {
 if (objzx_TopicObjectiveVerEN.PdfPageTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TopicObjectiveVerEN.PdfPageTop, conzx_TopicObjectiveVer.PdfPageTop); //pdf页面顶部位置
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjectiveVer.PdfPageTop); //pdf页面顶部位置
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.PdfZoom))
 {
 if (objzx_TopicObjectiveVerEN.PdfZoom !=  null)
 {
 var strPdfZoom = objzx_TopicObjectiveVerEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfZoom = '{0}',", strPdfZoom); //PdfZoom
 }
 else
 {
 sbSQL.Append(" PdfZoom = null,"); //PdfZoom
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.GroupTextId))
 {
 if (objzx_TopicObjectiveVerEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_TopicObjectiveVerEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objzx_TopicObjectiveVerEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objzx_TopicObjectiveVerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_TopicObjectiveVerEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TopicObjectiveVerDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_TopicObjectiveVer Set ");
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.zxTopicObjectiveId))
 {
 if (objzx_TopicObjectiveVerEN.zxTopicObjectiveId !=  null)
 {
 var strzxTopicObjectiveId = objzx_TopicObjectiveVerEN.zxTopicObjectiveId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxTopicObjectiveId = '{0}',", strzxTopicObjectiveId); //客观Id
 }
 else
 {
 sbSQL.Append(" zxTopicObjectiveId = null,"); //客观Id
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.ObjectiveName))
 {
 if (objzx_TopicObjectiveVerEN.ObjectiveName !=  null)
 {
 var strObjectiveName = objzx_TopicObjectiveVerEN.ObjectiveName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ObjectiveName = '{0}',", strObjectiveName); //客观名称
 }
 else
 {
 sbSQL.Append(" ObjectiveName = null,"); //客观名称
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.ObjectiveContent))
 {
 if (objzx_TopicObjectiveVerEN.ObjectiveContent !=  null)
 {
 var strObjectiveContent = objzx_TopicObjectiveVerEN.ObjectiveContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ObjectiveContent = '{0}',", strObjectiveContent); //客观内容
 }
 else
 {
 sbSQL.Append(" ObjectiveContent = null,"); //客观内容
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.ObjectiveType))
 {
 if (objzx_TopicObjectiveVerEN.ObjectiveType !=  null)
 {
 var strObjectiveType = objzx_TopicObjectiveVerEN.ObjectiveType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ObjectiveType = '{0}',", strObjectiveType); //客观类型
 }
 else
 {
 sbSQL.Append(" ObjectiveType = null,"); //客观类型
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.Conclusion))
 {
 if (objzx_TopicObjectiveVerEN.Conclusion !=  null)
 {
 var strConclusion = objzx_TopicObjectiveVerEN.Conclusion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Conclusion = '{0}',", strConclusion); //结论
 }
 else
 {
 sbSQL.Append(" Conclusion = null,"); //结论
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.TextId))
 {
 if (objzx_TopicObjectiveVerEN.TextId !=  null)
 {
 var strTextId = objzx_TopicObjectiveVerEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TextId = '{0}',", strTextId); //课件Id
 }
 else
 {
 sbSQL.Append(" TextId = null,"); //课件Id
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objzx_TopicObjectiveVerEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.VoteCount))
 {
 if (objzx_TopicObjectiveVerEN.VoteCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TopicObjectiveVerEN.VoteCount, conzx_TopicObjectiveVer.VoteCount); //点赞计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjectiveVer.VoteCount); //点赞计数
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.AppraiseCount))
 {
 if (objzx_TopicObjectiveVerEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TopicObjectiveVerEN.AppraiseCount, conzx_TopicObjectiveVer.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjectiveVer.AppraiseCount); //评论数
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.Score))
 {
 if (objzx_TopicObjectiveVerEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TopicObjectiveVerEN.Score, conzx_TopicObjectiveVer.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjectiveVer.Score); //评分
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.StuScore))
 {
 if (objzx_TopicObjectiveVerEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TopicObjectiveVerEN.StuScore, conzx_TopicObjectiveVer.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjectiveVer.StuScore); //学生平均分
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.TeaScore))
 {
 if (objzx_TopicObjectiveVerEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TopicObjectiveVerEN.TeaScore, conzx_TopicObjectiveVer.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjectiveVer.TeaScore); //教师评分
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.CreateDate))
 {
 if (objzx_TopicObjectiveVerEN.CreateDate !=  null)
 {
 var strCreateDate = objzx_TopicObjectiveVerEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateDate = '{0}',", strCreateDate); //建立日期
 }
 else
 {
 sbSQL.Append(" CreateDate = null,"); //建立日期
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.UpdDate))
 {
 if (objzx_TopicObjectiveVerEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_TopicObjectiveVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.UpdUser))
 {
 if (objzx_TopicObjectiveVerEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_TopicObjectiveVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.IdCurrEduCls))
 {
 if (objzx_TopicObjectiveVerEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_TopicObjectiveVerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.PdfContent))
 {
 if (objzx_TopicObjectiveVerEN.PdfContent !=  null)
 {
 var strPdfContent = objzx_TopicObjectiveVerEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfContent = '{0}',", strPdfContent); //Pdf内容
 }
 else
 {
 sbSQL.Append(" PdfContent = null,"); //Pdf内容
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.PdfPageNum))
 {
 if (objzx_TopicObjectiveVerEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TopicObjectiveVerEN.PdfPageNum, conzx_TopicObjectiveVer.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjectiveVer.PdfPageNum); //Pdf页码
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.CitationCount))
 {
 if (objzx_TopicObjectiveVerEN.CitationCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TopicObjectiveVerEN.CitationCount, conzx_TopicObjectiveVer.CitationCount); //引用统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjectiveVer.CitationCount); //引用统计
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.VersionCount))
 {
 if (objzx_TopicObjectiveVerEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TopicObjectiveVerEN.VersionCount, conzx_TopicObjectiveVer.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjectiveVer.VersionCount); //版本统计
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.zxShareId))
 {
 if (objzx_TopicObjectiveVerEN.zxShareId !=  null)
 {
 var strzxShareId = objzx_TopicObjectiveVerEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxShareId = '{0}',", strzxShareId); //分享Id
 }
 else
 {
 sbSQL.Append(" zxShareId = null,"); //分享Id
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.Memo))
 {
 if (objzx_TopicObjectiveVerEN.Memo !=  null)
 {
 var strMemo = objzx_TopicObjectiveVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.PdfDivLet))
 {
 if (objzx_TopicObjectiveVerEN.PdfDivLet !=  null)
 {
 var strPdfDivLet = objzx_TopicObjectiveVerEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfDivLet = '{0}',", strPdfDivLet); //PdfDivLet
 }
 else
 {
 sbSQL.Append(" PdfDivLet = null,"); //PdfDivLet
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.PdfDivTop))
 {
 if (objzx_TopicObjectiveVerEN.PdfDivTop !=  null)
 {
 var strPdfDivTop = objzx_TopicObjectiveVerEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfDivTop = '{0}',", strPdfDivTop); //PdfDivTop
 }
 else
 {
 sbSQL.Append(" PdfDivTop = null,"); //PdfDivTop
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.PdfPageNumIn))
 {
 if (objzx_TopicObjectiveVerEN.PdfPageNumIn !=  null)
 {
 var strPdfPageNumIn = objzx_TopicObjectiveVerEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfPageNumIn = '{0}',", strPdfPageNumIn); //PdfPageNumIn
 }
 else
 {
 sbSQL.Append(" PdfPageNumIn = null,"); //PdfPageNumIn
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.PdfPageTop))
 {
 if (objzx_TopicObjectiveVerEN.PdfPageTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TopicObjectiveVerEN.PdfPageTop, conzx_TopicObjectiveVer.PdfPageTop); //pdf页面顶部位置
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjectiveVer.PdfPageTop); //pdf页面顶部位置
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.PdfZoom))
 {
 if (objzx_TopicObjectiveVerEN.PdfZoom !=  null)
 {
 var strPdfZoom = objzx_TopicObjectiveVerEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfZoom = '{0}',", strPdfZoom); //PdfZoom
 }
 else
 {
 sbSQL.Append(" PdfZoom = null,"); //PdfZoom
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.GroupTextId))
 {
 if (objzx_TopicObjectiveVerEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_TopicObjectiveVerEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objzx_TopicObjectiveVerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objzx_TopicObjectiveVerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_TopicObjectiveVerEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TopicObjectiveVerDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_TopicObjectiveVer Set ");
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.zxTopicObjectiveId))
 {
 if (objzx_TopicObjectiveVerEN.zxTopicObjectiveId !=  null)
 {
 var strzxTopicObjectiveId = objzx_TopicObjectiveVerEN.zxTopicObjectiveId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxTopicObjectiveId, conzx_TopicObjectiveVer.zxTopicObjectiveId); //客观Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjectiveVer.zxTopicObjectiveId); //客观Id
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.ObjectiveName))
 {
 if (objzx_TopicObjectiveVerEN.ObjectiveName !=  null)
 {
 var strObjectiveName = objzx_TopicObjectiveVerEN.ObjectiveName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strObjectiveName, conzx_TopicObjectiveVer.ObjectiveName); //客观名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjectiveVer.ObjectiveName); //客观名称
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.ObjectiveContent))
 {
 if (objzx_TopicObjectiveVerEN.ObjectiveContent !=  null)
 {
 var strObjectiveContent = objzx_TopicObjectiveVerEN.ObjectiveContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strObjectiveContent, conzx_TopicObjectiveVer.ObjectiveContent); //客观内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjectiveVer.ObjectiveContent); //客观内容
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.ObjectiveType))
 {
 if (objzx_TopicObjectiveVerEN.ObjectiveType !=  null)
 {
 var strObjectiveType = objzx_TopicObjectiveVerEN.ObjectiveType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strObjectiveType, conzx_TopicObjectiveVer.ObjectiveType); //客观类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjectiveVer.ObjectiveType); //客观类型
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.Conclusion))
 {
 if (objzx_TopicObjectiveVerEN.Conclusion !=  null)
 {
 var strConclusion = objzx_TopicObjectiveVerEN.Conclusion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strConclusion, conzx_TopicObjectiveVer.Conclusion); //结论
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjectiveVer.Conclusion); //结论
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.TextId))
 {
 if (objzx_TopicObjectiveVerEN.TextId !=  null)
 {
 var strTextId = objzx_TopicObjectiveVerEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTextId, conzx_TopicObjectiveVer.TextId); //课件Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjectiveVer.TextId); //课件Id
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objzx_TopicObjectiveVerEN.IsSubmit == true?"1":"0", conzx_TopicObjectiveVer.IsSubmit); //是否提交
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.VoteCount))
 {
 if (objzx_TopicObjectiveVerEN.VoteCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TopicObjectiveVerEN.VoteCount, conzx_TopicObjectiveVer.VoteCount); //点赞计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjectiveVer.VoteCount); //点赞计数
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.AppraiseCount))
 {
 if (objzx_TopicObjectiveVerEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TopicObjectiveVerEN.AppraiseCount, conzx_TopicObjectiveVer.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjectiveVer.AppraiseCount); //评论数
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.Score))
 {
 if (objzx_TopicObjectiveVerEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TopicObjectiveVerEN.Score, conzx_TopicObjectiveVer.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjectiveVer.Score); //评分
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.StuScore))
 {
 if (objzx_TopicObjectiveVerEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TopicObjectiveVerEN.StuScore, conzx_TopicObjectiveVer.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjectiveVer.StuScore); //学生平均分
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.TeaScore))
 {
 if (objzx_TopicObjectiveVerEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TopicObjectiveVerEN.TeaScore, conzx_TopicObjectiveVer.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjectiveVer.TeaScore); //教师评分
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.CreateDate))
 {
 if (objzx_TopicObjectiveVerEN.CreateDate !=  null)
 {
 var strCreateDate = objzx_TopicObjectiveVerEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateDate, conzx_TopicObjectiveVer.CreateDate); //建立日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjectiveVer.CreateDate); //建立日期
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.UpdDate))
 {
 if (objzx_TopicObjectiveVerEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_TopicObjectiveVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conzx_TopicObjectiveVer.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjectiveVer.UpdDate); //修改日期
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.UpdUser))
 {
 if (objzx_TopicObjectiveVerEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_TopicObjectiveVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conzx_TopicObjectiveVer.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjectiveVer.UpdUser); //修改人
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.IdCurrEduCls))
 {
 if (objzx_TopicObjectiveVerEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_TopicObjectiveVerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conzx_TopicObjectiveVer.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjectiveVer.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.PdfContent))
 {
 if (objzx_TopicObjectiveVerEN.PdfContent !=  null)
 {
 var strPdfContent = objzx_TopicObjectiveVerEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfContent, conzx_TopicObjectiveVer.PdfContent); //Pdf内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjectiveVer.PdfContent); //Pdf内容
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.PdfPageNum))
 {
 if (objzx_TopicObjectiveVerEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TopicObjectiveVerEN.PdfPageNum, conzx_TopicObjectiveVer.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjectiveVer.PdfPageNum); //Pdf页码
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.CitationCount))
 {
 if (objzx_TopicObjectiveVerEN.CitationCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TopicObjectiveVerEN.CitationCount, conzx_TopicObjectiveVer.CitationCount); //引用统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjectiveVer.CitationCount); //引用统计
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.VersionCount))
 {
 if (objzx_TopicObjectiveVerEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TopicObjectiveVerEN.VersionCount, conzx_TopicObjectiveVer.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjectiveVer.VersionCount); //版本统计
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.zxShareId))
 {
 if (objzx_TopicObjectiveVerEN.zxShareId !=  null)
 {
 var strzxShareId = objzx_TopicObjectiveVerEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxShareId, conzx_TopicObjectiveVer.zxShareId); //分享Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjectiveVer.zxShareId); //分享Id
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.Memo))
 {
 if (objzx_TopicObjectiveVerEN.Memo !=  null)
 {
 var strMemo = objzx_TopicObjectiveVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conzx_TopicObjectiveVer.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjectiveVer.Memo); //备注
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.PdfDivLet))
 {
 if (objzx_TopicObjectiveVerEN.PdfDivLet !=  null)
 {
 var strPdfDivLet = objzx_TopicObjectiveVerEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfDivLet, conzx_TopicObjectiveVer.PdfDivLet); //PdfDivLet
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjectiveVer.PdfDivLet); //PdfDivLet
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.PdfDivTop))
 {
 if (objzx_TopicObjectiveVerEN.PdfDivTop !=  null)
 {
 var strPdfDivTop = objzx_TopicObjectiveVerEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfDivTop, conzx_TopicObjectiveVer.PdfDivTop); //PdfDivTop
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjectiveVer.PdfDivTop); //PdfDivTop
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.PdfPageNumIn))
 {
 if (objzx_TopicObjectiveVerEN.PdfPageNumIn !=  null)
 {
 var strPdfPageNumIn = objzx_TopicObjectiveVerEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfPageNumIn, conzx_TopicObjectiveVer.PdfPageNumIn); //PdfPageNumIn
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjectiveVer.PdfPageNumIn); //PdfPageNumIn
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.PdfPageTop))
 {
 if (objzx_TopicObjectiveVerEN.PdfPageTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TopicObjectiveVerEN.PdfPageTop, conzx_TopicObjectiveVer.PdfPageTop); //pdf页面顶部位置
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjectiveVer.PdfPageTop); //pdf页面顶部位置
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.PdfZoom))
 {
 if (objzx_TopicObjectiveVerEN.PdfZoom !=  null)
 {
 var strPdfZoom = objzx_TopicObjectiveVerEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfZoom, conzx_TopicObjectiveVer.PdfZoom); //PdfZoom
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjectiveVer.PdfZoom); //PdfZoom
 }
 }
 
 if (objzx_TopicObjectiveVerEN.IsUpdated(conzx_TopicObjectiveVer.GroupTextId))
 {
 if (objzx_TopicObjectiveVerEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_TopicObjectiveVerEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGroupTextId, conzx_TopicObjectiveVer.GroupTextId); //小组Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TopicObjectiveVer.GroupTextId); //小组Id
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where TopicObjectiveVId = {0}", objzx_TopicObjectiveVerEN.TopicObjectiveVId); 
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
 /// <param name = "lngTopicObjectiveVId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngTopicObjectiveVId) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TopicObjectiveVerDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngTopicObjectiveVId,
};
 objSQL.ExecSP("zx_TopicObjectiveVer_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngTopicObjectiveVId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngTopicObjectiveVId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TopicObjectiveVerDA.GetSpecSQLObj();
//删除zx_TopicObjectiveVer本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_TopicObjectiveVer where TopicObjectiveVId = " + ""+ lngTopicObjectiveVId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delzx_TopicObjectiveVer(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TopicObjectiveVerDA.GetSpecSQLObj();
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
//删除zx_TopicObjectiveVer本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_TopicObjectiveVer where TopicObjectiveVId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngTopicObjectiveVId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngTopicObjectiveVId) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TopicObjectiveVerDA.GetSpecSQLObj();
//删除zx_TopicObjectiveVer本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_TopicObjectiveVer where TopicObjectiveVId = " + ""+ lngTopicObjectiveVId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delzx_TopicObjectiveVer(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clszx_TopicObjectiveVerDA: Delzx_TopicObjectiveVer)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TopicObjectiveVerDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from zx_TopicObjectiveVer where " + strCondition ;
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
public bool Delzx_TopicObjectiveVerWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clszx_TopicObjectiveVerDA: Delzx_TopicObjectiveVerWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TopicObjectiveVerDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from zx_TopicObjectiveVer where " + strCondition ;
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
 /// <param name = "objzx_TopicObjectiveVerENS">源对象</param>
 /// <param name = "objzx_TopicObjectiveVerENT">目标对象</param>
public void CopyTo(clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerENS, clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerENT)
{
objzx_TopicObjectiveVerENT.TopicObjectiveVId = objzx_TopicObjectiveVerENS.TopicObjectiveVId; //主题客观版本Id
objzx_TopicObjectiveVerENT.zxTopicObjectiveId = objzx_TopicObjectiveVerENS.zxTopicObjectiveId; //客观Id
objzx_TopicObjectiveVerENT.ObjectiveName = objzx_TopicObjectiveVerENS.ObjectiveName; //客观名称
objzx_TopicObjectiveVerENT.ObjectiveContent = objzx_TopicObjectiveVerENS.ObjectiveContent; //客观内容
objzx_TopicObjectiveVerENT.ObjectiveType = objzx_TopicObjectiveVerENS.ObjectiveType; //客观类型
objzx_TopicObjectiveVerENT.Conclusion = objzx_TopicObjectiveVerENS.Conclusion; //结论
objzx_TopicObjectiveVerENT.TextId = objzx_TopicObjectiveVerENS.TextId; //课件Id
objzx_TopicObjectiveVerENT.IsSubmit = objzx_TopicObjectiveVerENS.IsSubmit; //是否提交
objzx_TopicObjectiveVerENT.VoteCount = objzx_TopicObjectiveVerENS.VoteCount; //点赞计数
objzx_TopicObjectiveVerENT.AppraiseCount = objzx_TopicObjectiveVerENS.AppraiseCount; //评论数
objzx_TopicObjectiveVerENT.Score = objzx_TopicObjectiveVerENS.Score; //评分
objzx_TopicObjectiveVerENT.StuScore = objzx_TopicObjectiveVerENS.StuScore; //学生平均分
objzx_TopicObjectiveVerENT.TeaScore = objzx_TopicObjectiveVerENS.TeaScore; //教师评分
objzx_TopicObjectiveVerENT.CreateDate = objzx_TopicObjectiveVerENS.CreateDate; //建立日期
objzx_TopicObjectiveVerENT.UpdDate = objzx_TopicObjectiveVerENS.UpdDate; //修改日期
objzx_TopicObjectiveVerENT.UpdUser = objzx_TopicObjectiveVerENS.UpdUser; //修改人
objzx_TopicObjectiveVerENT.IdCurrEduCls = objzx_TopicObjectiveVerENS.IdCurrEduCls; //教学班流水号
objzx_TopicObjectiveVerENT.PdfContent = objzx_TopicObjectiveVerENS.PdfContent; //Pdf内容
objzx_TopicObjectiveVerENT.PdfPageNum = objzx_TopicObjectiveVerENS.PdfPageNum; //Pdf页码
objzx_TopicObjectiveVerENT.CitationCount = objzx_TopicObjectiveVerENS.CitationCount; //引用统计
objzx_TopicObjectiveVerENT.VersionCount = objzx_TopicObjectiveVerENS.VersionCount; //版本统计
objzx_TopicObjectiveVerENT.zxShareId = objzx_TopicObjectiveVerENS.zxShareId; //分享Id
objzx_TopicObjectiveVerENT.Memo = objzx_TopicObjectiveVerENS.Memo; //备注
objzx_TopicObjectiveVerENT.PdfDivLet = objzx_TopicObjectiveVerENS.PdfDivLet; //PdfDivLet
objzx_TopicObjectiveVerENT.PdfDivTop = objzx_TopicObjectiveVerENS.PdfDivTop; //PdfDivTop
objzx_TopicObjectiveVerENT.PdfPageNumIn = objzx_TopicObjectiveVerENS.PdfPageNumIn; //PdfPageNumIn
objzx_TopicObjectiveVerENT.PdfPageTop = objzx_TopicObjectiveVerENS.PdfPageTop; //pdf页面顶部位置
objzx_TopicObjectiveVerENT.PdfZoom = objzx_TopicObjectiveVerENS.PdfZoom; //PdfZoom
objzx_TopicObjectiveVerENT.GroupTextId = objzx_TopicObjectiveVerENS.GroupTextId; //小组Id
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objzx_TopicObjectiveVerEN.zxTopicObjectiveId, conzx_TopicObjectiveVer.zxTopicObjectiveId);
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveVerEN.zxTopicObjectiveId, 8, conzx_TopicObjectiveVer.zxTopicObjectiveId);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveVerEN.ObjectiveName, 500, conzx_TopicObjectiveVer.ObjectiveName);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveVerEN.ObjectiveType, 2, conzx_TopicObjectiveVer.ObjectiveType);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveVerEN.TextId, 8, conzx_TopicObjectiveVer.TextId);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveVerEN.CreateDate, 20, conzx_TopicObjectiveVer.CreateDate);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveVerEN.UpdDate, 20, conzx_TopicObjectiveVer.UpdDate);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveVerEN.UpdUser, 20, conzx_TopicObjectiveVer.UpdUser);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveVerEN.IdCurrEduCls, 8, conzx_TopicObjectiveVer.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveVerEN.PdfContent, 2000, conzx_TopicObjectiveVer.PdfContent);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveVerEN.zxShareId, 2, conzx_TopicObjectiveVer.zxShareId);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveVerEN.Memo, 1000, conzx_TopicObjectiveVer.Memo);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveVerEN.PdfDivLet, 50, conzx_TopicObjectiveVer.PdfDivLet);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveVerEN.PdfDivTop, 50, conzx_TopicObjectiveVer.PdfDivTop);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveVerEN.PdfPageNumIn, 50, conzx_TopicObjectiveVer.PdfPageNumIn);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveVerEN.PdfZoom, 50, conzx_TopicObjectiveVer.PdfZoom);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveVerEN.GroupTextId, 8, conzx_TopicObjectiveVer.GroupTextId);
//检查字段外键固定长度
 objzx_TopicObjectiveVerEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveVerEN.zxTopicObjectiveId, 8, conzx_TopicObjectiveVer.zxTopicObjectiveId);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveVerEN.ObjectiveName, 500, conzx_TopicObjectiveVer.ObjectiveName);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveVerEN.ObjectiveType, 2, conzx_TopicObjectiveVer.ObjectiveType);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveVerEN.TextId, 8, conzx_TopicObjectiveVer.TextId);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveVerEN.CreateDate, 20, conzx_TopicObjectiveVer.CreateDate);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveVerEN.UpdDate, 20, conzx_TopicObjectiveVer.UpdDate);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveVerEN.UpdUser, 20, conzx_TopicObjectiveVer.UpdUser);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveVerEN.IdCurrEduCls, 8, conzx_TopicObjectiveVer.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveVerEN.PdfContent, 2000, conzx_TopicObjectiveVer.PdfContent);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveVerEN.zxShareId, 2, conzx_TopicObjectiveVer.zxShareId);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveVerEN.Memo, 1000, conzx_TopicObjectiveVer.Memo);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveVerEN.PdfDivLet, 50, conzx_TopicObjectiveVer.PdfDivLet);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveVerEN.PdfDivTop, 50, conzx_TopicObjectiveVer.PdfDivTop);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveVerEN.PdfPageNumIn, 50, conzx_TopicObjectiveVer.PdfPageNumIn);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveVerEN.PdfZoom, 50, conzx_TopicObjectiveVer.PdfZoom);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveVerEN.GroupTextId, 8, conzx_TopicObjectiveVer.GroupTextId);
//检查外键字段长度
 objzx_TopicObjectiveVerEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveVerEN.zxTopicObjectiveId, 8, conzx_TopicObjectiveVer.zxTopicObjectiveId);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveVerEN.ObjectiveName, 500, conzx_TopicObjectiveVer.ObjectiveName);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveVerEN.ObjectiveType, 2, conzx_TopicObjectiveVer.ObjectiveType);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveVerEN.TextId, 8, conzx_TopicObjectiveVer.TextId);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveVerEN.CreateDate, 20, conzx_TopicObjectiveVer.CreateDate);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveVerEN.UpdDate, 20, conzx_TopicObjectiveVer.UpdDate);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveVerEN.UpdUser, 20, conzx_TopicObjectiveVer.UpdUser);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveVerEN.IdCurrEduCls, 8, conzx_TopicObjectiveVer.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveVerEN.PdfContent, 2000, conzx_TopicObjectiveVer.PdfContent);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveVerEN.zxShareId, 2, conzx_TopicObjectiveVer.zxShareId);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveVerEN.Memo, 1000, conzx_TopicObjectiveVer.Memo);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveVerEN.PdfDivLet, 50, conzx_TopicObjectiveVer.PdfDivLet);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveVerEN.PdfDivTop, 50, conzx_TopicObjectiveVer.PdfDivTop);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveVerEN.PdfPageNumIn, 50, conzx_TopicObjectiveVer.PdfPageNumIn);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveVerEN.PdfZoom, 50, conzx_TopicObjectiveVer.PdfZoom);
clsCheckSql.CheckFieldLen(objzx_TopicObjectiveVerEN.GroupTextId, 8, conzx_TopicObjectiveVer.GroupTextId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objzx_TopicObjectiveVerEN.zxTopicObjectiveId, conzx_TopicObjectiveVer.zxTopicObjectiveId);
clsCheckSql.CheckSqlInjection4Field(objzx_TopicObjectiveVerEN.ObjectiveName, conzx_TopicObjectiveVer.ObjectiveName);
clsCheckSql.CheckSqlInjection4Field(objzx_TopicObjectiveVerEN.ObjectiveType, conzx_TopicObjectiveVer.ObjectiveType);
clsCheckSql.CheckSqlInjection4Field(objzx_TopicObjectiveVerEN.TextId, conzx_TopicObjectiveVer.TextId);
clsCheckSql.CheckSqlInjection4Field(objzx_TopicObjectiveVerEN.CreateDate, conzx_TopicObjectiveVer.CreateDate);
clsCheckSql.CheckSqlInjection4Field(objzx_TopicObjectiveVerEN.UpdDate, conzx_TopicObjectiveVer.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objzx_TopicObjectiveVerEN.UpdUser, conzx_TopicObjectiveVer.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objzx_TopicObjectiveVerEN.IdCurrEduCls, conzx_TopicObjectiveVer.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objzx_TopicObjectiveVerEN.PdfContent, conzx_TopicObjectiveVer.PdfContent);
clsCheckSql.CheckSqlInjection4Field(objzx_TopicObjectiveVerEN.zxShareId, conzx_TopicObjectiveVer.zxShareId);
clsCheckSql.CheckSqlInjection4Field(objzx_TopicObjectiveVerEN.Memo, conzx_TopicObjectiveVer.Memo);
clsCheckSql.CheckSqlInjection4Field(objzx_TopicObjectiveVerEN.PdfDivLet, conzx_TopicObjectiveVer.PdfDivLet);
clsCheckSql.CheckSqlInjection4Field(objzx_TopicObjectiveVerEN.PdfDivTop, conzx_TopicObjectiveVer.PdfDivTop);
clsCheckSql.CheckSqlInjection4Field(objzx_TopicObjectiveVerEN.PdfPageNumIn, conzx_TopicObjectiveVer.PdfPageNumIn);
clsCheckSql.CheckSqlInjection4Field(objzx_TopicObjectiveVerEN.PdfZoom, conzx_TopicObjectiveVer.PdfZoom);
clsCheckSql.CheckSqlInjection4Field(objzx_TopicObjectiveVerEN.GroupTextId, conzx_TopicObjectiveVer.GroupTextId);
//检查外键字段长度
 objzx_TopicObjectiveVerEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--zx_TopicObjectiveVer(客观数据历史),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveVerEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TopicObjectiveVId = '{0}'", objzx_TopicObjectiveVerEN.TopicObjectiveVId);
 sbCondition.AppendFormat(" and zxTopicObjectiveId = '{0}'", objzx_TopicObjectiveVerEN.zxTopicObjectiveId);
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
 objSQL = clszx_TopicObjectiveVerDA.GetSpecSQLObj();
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
 objSQL = clszx_TopicObjectiveVerDA.GetSpecSQLObj();
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
 objSQL = clszx_TopicObjectiveVerDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clszx_TopicObjectiveVerEN._CurrTabName);
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
 objSQL = clszx_TopicObjectiveVerDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clszx_TopicObjectiveVerEN._CurrTabName, strCondition);
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
 objSQL = clszx_TopicObjectiveVerDA.GetSpecSQLObj();
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
 objSQL = clszx_TopicObjectiveVerDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}