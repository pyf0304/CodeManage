
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_ViewpointVerDA
 表名:zx_ViewpointVer(01120742)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 23:08:17
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
 /// 观点历史版本(zx_ViewpointVer)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clszx_ViewpointVerDA : clsCommBase4DA
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
 return clszx_ViewpointVerEN._CurrTabName;
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
if (string.IsNullOrEmpty(clszx_ViewpointVerEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clszx_ViewpointVerEN._ConnectString);
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
 if (string.IsNullOrEmpty(clszx_ViewpointVerEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clszx_ViewpointVerEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clszx_ViewpointVerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointVerDA.GetSpecSQLObj();
strSQL = "Select * from zx_ViewpointVer where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_zx_ViewpointVer(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clszx_ViewpointVerDA: GetDataTable_zx_ViewpointVer)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointVerDA.GetSpecSQLObj();
strSQL = "Select * from zx_ViewpointVer where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clszx_ViewpointVerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointVerDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clszx_ViewpointVerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointVerDA.GetSpecSQLObj();
strSQL = "Select * from zx_ViewpointVer where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clszx_ViewpointVerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointVerDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clszx_ViewpointVerDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointVerDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_ViewpointVer where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_ViewpointVer where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clszx_ViewpointVerDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointVerDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from zx_ViewpointVer where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clszx_ViewpointVerDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointVerDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} zx_ViewpointVer.* from zx_ViewpointVer Left Join {1} on {2} where {3} and zx_ViewpointVer.ViewpointVId not in (Select top {5} zx_ViewpointVer.ViewpointVId from zx_ViewpointVer Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_ViewpointVer where {1} and ViewpointVId not in (Select top {2} ViewpointVId from zx_ViewpointVer where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_ViewpointVer where {1} and ViewpointVId not in (Select top {3} ViewpointVId from zx_ViewpointVer where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clszx_ViewpointVerDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointVerDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} zx_ViewpointVer.* from zx_ViewpointVer Left Join {1} on {2} where {3} and zx_ViewpointVer.ViewpointVId not in (Select top {5} zx_ViewpointVer.ViewpointVId from zx_ViewpointVer Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_ViewpointVer where {1} and ViewpointVId not in (Select top {2} ViewpointVId from zx_ViewpointVer where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_ViewpointVer where {1} and ViewpointVId not in (Select top {3} ViewpointVId from zx_ViewpointVer where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clszx_ViewpointVerEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clszx_ViewpointVerDA:GetObjLst)", objException.Message));
}
List<clszx_ViewpointVerEN> arrObjLst = new List<clszx_ViewpointVerEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointVerDA.GetSpecSQLObj();
strSQL = "Select * from zx_ViewpointVer where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ViewpointVerEN objzx_ViewpointVerEN = new clszx_ViewpointVerEN();
try
{
objzx_ViewpointVerEN.ViewpointVId = TransNullToInt(objRow[conzx_ViewpointVer.ViewpointVId].ToString().Trim()); //ViewpointVId
objzx_ViewpointVerEN.zxViewpointId = objRow[conzx_ViewpointVer.zxViewpointId].ToString().Trim(); //观点Id
objzx_ViewpointVerEN.ViewpointName = objRow[conzx_ViewpointVer.ViewpointName] == DBNull.Value ? null : objRow[conzx_ViewpointVer.ViewpointName].ToString().Trim(); //观点名称
objzx_ViewpointVerEN.ViewpointContent = objRow[conzx_ViewpointVer.ViewpointContent] == DBNull.Value ? null : objRow[conzx_ViewpointVer.ViewpointContent].ToString().Trim(); //观点内容
objzx_ViewpointVerEN.zxViewpointTypeId = objRow[conzx_ViewpointVer.zxViewpointTypeId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.zxViewpointTypeId].ToString().Trim(); //观点类型Id
objzx_ViewpointVerEN.Reason = objRow[conzx_ViewpointVer.Reason] == DBNull.Value ? null : objRow[conzx_ViewpointVer.Reason].ToString().Trim(); //理由
objzx_ViewpointVerEN.Source = objRow[conzx_ViewpointVer.Source] == DBNull.Value ? null : objRow[conzx_ViewpointVer.Source].ToString().Trim(); //来源
objzx_ViewpointVerEN.VPProposePeople = objRow[conzx_ViewpointVer.VPProposePeople] == DBNull.Value ? null : objRow[conzx_ViewpointVer.VPProposePeople].ToString().Trim(); //观点提出人
objzx_ViewpointVerEN.IsSubmit = TransNullToBool(objRow[conzx_ViewpointVer.IsSubmit].ToString().Trim()); //是否提交
objzx_ViewpointVerEN.UserTypeId = objRow[conzx_ViewpointVer.UserTypeId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.UserTypeId].ToString().Trim(); //用户类型Id
objzx_ViewpointVerEN.TextId = objRow[conzx_ViewpointVer.TextId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.TextId].ToString().Trim(); //课件Id
objzx_ViewpointVerEN.VoteCount = objRow[conzx_ViewpointVer.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ViewpointVer.VoteCount].ToString().Trim()); //点赞计数
objzx_ViewpointVerEN.AppraiseCount = objRow[conzx_ViewpointVer.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ViewpointVer.AppraiseCount].ToString().Trim()); //评论数
objzx_ViewpointVerEN.Score = objRow[conzx_ViewpointVer.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_ViewpointVer.Score].ToString().Trim()); //评分
objzx_ViewpointVerEN.StuScore = objRow[conzx_ViewpointVer.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_ViewpointVer.StuScore].ToString().Trim()); //学生平均分
objzx_ViewpointVerEN.TeaScore = objRow[conzx_ViewpointVer.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_ViewpointVer.TeaScore].ToString().Trim()); //教师评分
objzx_ViewpointVerEN.UpdDate = objRow[conzx_ViewpointVer.UpdDate] == DBNull.Value ? null : objRow[conzx_ViewpointVer.UpdDate].ToString().Trim(); //修改日期
objzx_ViewpointVerEN.UpdUser = objRow[conzx_ViewpointVer.UpdUser] == DBNull.Value ? null : objRow[conzx_ViewpointVer.UpdUser].ToString().Trim(); //修改人
objzx_ViewpointVerEN.IdCurrEduCls = objRow[conzx_ViewpointVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_ViewpointVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_ViewpointVerEN.PdfContent = objRow[conzx_ViewpointVer.PdfContent] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfContent].ToString().Trim(); //Pdf内容
objzx_ViewpointVerEN.PdfPageNum = objRow[conzx_ViewpointVer.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ViewpointVer.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_ViewpointVerEN.CitationCount = objRow[conzx_ViewpointVer.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ViewpointVer.CitationCount].ToString().Trim()); //引用统计
objzx_ViewpointVerEN.VersionCount = objRow[conzx_ViewpointVer.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ViewpointVer.VersionCount].ToString().Trim()); //版本统计
objzx_ViewpointVerEN.CreateDate = objRow[conzx_ViewpointVer.CreateDate] == DBNull.Value ? null : objRow[conzx_ViewpointVer.CreateDate].ToString().Trim(); //建立日期
objzx_ViewpointVerEN.zxShareId = objRow[conzx_ViewpointVer.zxShareId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.zxShareId].ToString().Trim(); //分享Id
objzx_ViewpointVerEN.Memo = objRow[conzx_ViewpointVer.Memo] == DBNull.Value ? null : objRow[conzx_ViewpointVer.Memo].ToString().Trim(); //备注
objzx_ViewpointVerEN.TeammenberId = objRow[conzx_ViewpointVer.TeammenberId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.TeammenberId].ToString().Trim(); //主键
objzx_ViewpointVerEN.PdfDivLet = objRow[conzx_ViewpointVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_ViewpointVerEN.PdfDivTop = objRow[conzx_ViewpointVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_ViewpointVerEN.PdfPageNumIn = objRow[conzx_ViewpointVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_ViewpointVerEN.PdfPageTop = objRow[conzx_ViewpointVer.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ViewpointVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_ViewpointVerEN.PdfZoom = objRow[conzx_ViewpointVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfZoom].ToString().Trim(); //PdfZoom
objzx_ViewpointVerEN.GroupTextId = objRow[conzx_ViewpointVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.GroupTextId].ToString().Trim(); //小组Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clszx_ViewpointVerDA: GetObjLst)", objException.Message));
}
objzx_ViewpointVerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objzx_ViewpointVerEN);
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
public List<clszx_ViewpointVerEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clszx_ViewpointVerDA:GetObjLstByTabName)", objException.Message));
}
List<clszx_ViewpointVerEN> arrObjLst = new List<clszx_ViewpointVerEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointVerDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ViewpointVerEN objzx_ViewpointVerEN = new clszx_ViewpointVerEN();
try
{
objzx_ViewpointVerEN.ViewpointVId = TransNullToInt(objRow[conzx_ViewpointVer.ViewpointVId].ToString().Trim()); //ViewpointVId
objzx_ViewpointVerEN.zxViewpointId = objRow[conzx_ViewpointVer.zxViewpointId].ToString().Trim(); //观点Id
objzx_ViewpointVerEN.ViewpointName = objRow[conzx_ViewpointVer.ViewpointName] == DBNull.Value ? null : objRow[conzx_ViewpointVer.ViewpointName].ToString().Trim(); //观点名称
objzx_ViewpointVerEN.ViewpointContent = objRow[conzx_ViewpointVer.ViewpointContent] == DBNull.Value ? null : objRow[conzx_ViewpointVer.ViewpointContent].ToString().Trim(); //观点内容
objzx_ViewpointVerEN.zxViewpointTypeId = objRow[conzx_ViewpointVer.zxViewpointTypeId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.zxViewpointTypeId].ToString().Trim(); //观点类型Id
objzx_ViewpointVerEN.Reason = objRow[conzx_ViewpointVer.Reason] == DBNull.Value ? null : objRow[conzx_ViewpointVer.Reason].ToString().Trim(); //理由
objzx_ViewpointVerEN.Source = objRow[conzx_ViewpointVer.Source] == DBNull.Value ? null : objRow[conzx_ViewpointVer.Source].ToString().Trim(); //来源
objzx_ViewpointVerEN.VPProposePeople = objRow[conzx_ViewpointVer.VPProposePeople] == DBNull.Value ? null : objRow[conzx_ViewpointVer.VPProposePeople].ToString().Trim(); //观点提出人
objzx_ViewpointVerEN.IsSubmit = TransNullToBool(objRow[conzx_ViewpointVer.IsSubmit].ToString().Trim()); //是否提交
objzx_ViewpointVerEN.UserTypeId = objRow[conzx_ViewpointVer.UserTypeId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.UserTypeId].ToString().Trim(); //用户类型Id
objzx_ViewpointVerEN.TextId = objRow[conzx_ViewpointVer.TextId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.TextId].ToString().Trim(); //课件Id
objzx_ViewpointVerEN.VoteCount = objRow[conzx_ViewpointVer.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ViewpointVer.VoteCount].ToString().Trim()); //点赞计数
objzx_ViewpointVerEN.AppraiseCount = objRow[conzx_ViewpointVer.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ViewpointVer.AppraiseCount].ToString().Trim()); //评论数
objzx_ViewpointVerEN.Score = objRow[conzx_ViewpointVer.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_ViewpointVer.Score].ToString().Trim()); //评分
objzx_ViewpointVerEN.StuScore = objRow[conzx_ViewpointVer.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_ViewpointVer.StuScore].ToString().Trim()); //学生平均分
objzx_ViewpointVerEN.TeaScore = objRow[conzx_ViewpointVer.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_ViewpointVer.TeaScore].ToString().Trim()); //教师评分
objzx_ViewpointVerEN.UpdDate = objRow[conzx_ViewpointVer.UpdDate] == DBNull.Value ? null : objRow[conzx_ViewpointVer.UpdDate].ToString().Trim(); //修改日期
objzx_ViewpointVerEN.UpdUser = objRow[conzx_ViewpointVer.UpdUser] == DBNull.Value ? null : objRow[conzx_ViewpointVer.UpdUser].ToString().Trim(); //修改人
objzx_ViewpointVerEN.IdCurrEduCls = objRow[conzx_ViewpointVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_ViewpointVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_ViewpointVerEN.PdfContent = objRow[conzx_ViewpointVer.PdfContent] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfContent].ToString().Trim(); //Pdf内容
objzx_ViewpointVerEN.PdfPageNum = objRow[conzx_ViewpointVer.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ViewpointVer.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_ViewpointVerEN.CitationCount = objRow[conzx_ViewpointVer.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ViewpointVer.CitationCount].ToString().Trim()); //引用统计
objzx_ViewpointVerEN.VersionCount = objRow[conzx_ViewpointVer.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ViewpointVer.VersionCount].ToString().Trim()); //版本统计
objzx_ViewpointVerEN.CreateDate = objRow[conzx_ViewpointVer.CreateDate] == DBNull.Value ? null : objRow[conzx_ViewpointVer.CreateDate].ToString().Trim(); //建立日期
objzx_ViewpointVerEN.zxShareId = objRow[conzx_ViewpointVer.zxShareId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.zxShareId].ToString().Trim(); //分享Id
objzx_ViewpointVerEN.Memo = objRow[conzx_ViewpointVer.Memo] == DBNull.Value ? null : objRow[conzx_ViewpointVer.Memo].ToString().Trim(); //备注
objzx_ViewpointVerEN.TeammenberId = objRow[conzx_ViewpointVer.TeammenberId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.TeammenberId].ToString().Trim(); //主键
objzx_ViewpointVerEN.PdfDivLet = objRow[conzx_ViewpointVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_ViewpointVerEN.PdfDivTop = objRow[conzx_ViewpointVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_ViewpointVerEN.PdfPageNumIn = objRow[conzx_ViewpointVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_ViewpointVerEN.PdfPageTop = objRow[conzx_ViewpointVer.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ViewpointVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_ViewpointVerEN.PdfZoom = objRow[conzx_ViewpointVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfZoom].ToString().Trim(); //PdfZoom
objzx_ViewpointVerEN.GroupTextId = objRow[conzx_ViewpointVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.GroupTextId].ToString().Trim(); //小组Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clszx_ViewpointVerDA: GetObjLst)", objException.Message));
}
objzx_ViewpointVerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objzx_ViewpointVerEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objzx_ViewpointVerEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getzx_ViewpointVer(ref clszx_ViewpointVerEN objzx_ViewpointVerEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointVerDA.GetSpecSQLObj();
strSQL = "Select * from zx_ViewpointVer where ViewpointVId = " + ""+ objzx_ViewpointVerEN.ViewpointVId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objzx_ViewpointVerEN.ViewpointVId = TransNullToInt(objDT.Rows[0][conzx_ViewpointVer.ViewpointVId].ToString().Trim()); //ViewpointVId(字段类型:bigint,字段长度:8,是否可空:False)
 objzx_ViewpointVerEN.zxViewpointId = objDT.Rows[0][conzx_ViewpointVer.zxViewpointId].ToString().Trim(); //观点Id(字段类型:char,字段长度:8,是否可空:True)
 objzx_ViewpointVerEN.ViewpointName = objDT.Rows[0][conzx_ViewpointVer.ViewpointName].ToString().Trim(); //观点名称(字段类型:varchar,字段长度:500,是否可空:True)
 objzx_ViewpointVerEN.ViewpointContent = objDT.Rows[0][conzx_ViewpointVer.ViewpointContent].ToString().Trim(); //观点内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objzx_ViewpointVerEN.zxViewpointTypeId = objDT.Rows[0][conzx_ViewpointVer.zxViewpointTypeId].ToString().Trim(); //观点类型Id(字段类型:char,字段长度:4,是否可空:True)
 objzx_ViewpointVerEN.Reason = objDT.Rows[0][conzx_ViewpointVer.Reason].ToString().Trim(); //理由(字段类型:text,字段长度:2147483647,是否可空:True)
 objzx_ViewpointVerEN.Source = objDT.Rows[0][conzx_ViewpointVer.Source].ToString().Trim(); //来源(字段类型:varchar,字段长度:500,是否可空:True)
 objzx_ViewpointVerEN.VPProposePeople = objDT.Rows[0][conzx_ViewpointVer.VPProposePeople].ToString().Trim(); //观点提出人(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_ViewpointVerEN.IsSubmit = TransNullToBool(objDT.Rows[0][conzx_ViewpointVer.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objzx_ViewpointVerEN.UserTypeId = objDT.Rows[0][conzx_ViewpointVer.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objzx_ViewpointVerEN.TextId = objDT.Rows[0][conzx_ViewpointVer.TextId].ToString().Trim(); //课件Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_ViewpointVerEN.VoteCount = TransNullToInt(objDT.Rows[0][conzx_ViewpointVer.VoteCount].ToString().Trim()); //点赞计数(字段类型:int,字段长度:4,是否可空:True)
 objzx_ViewpointVerEN.AppraiseCount = TransNullToInt(objDT.Rows[0][conzx_ViewpointVer.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objzx_ViewpointVerEN.Score = TransNullToFloat(objDT.Rows[0][conzx_ViewpointVer.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objzx_ViewpointVerEN.StuScore = TransNullToFloat(objDT.Rows[0][conzx_ViewpointVer.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objzx_ViewpointVerEN.TeaScore = TransNullToFloat(objDT.Rows[0][conzx_ViewpointVer.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objzx_ViewpointVerEN.UpdDate = objDT.Rows[0][conzx_ViewpointVer.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_ViewpointVerEN.UpdUser = objDT.Rows[0][conzx_ViewpointVer.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_ViewpointVerEN.IdCurrEduCls = objDT.Rows[0][conzx_ViewpointVer.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objzx_ViewpointVerEN.PdfContent = objDT.Rows[0][conzx_ViewpointVer.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objzx_ViewpointVerEN.PdfPageNum = TransNullToInt(objDT.Rows[0][conzx_ViewpointVer.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objzx_ViewpointVerEN.CitationCount = TransNullToInt(objDT.Rows[0][conzx_ViewpointVer.CitationCount].ToString().Trim()); //引用统计(字段类型:int,字段长度:4,是否可空:True)
 objzx_ViewpointVerEN.VersionCount = TransNullToInt(objDT.Rows[0][conzx_ViewpointVer.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objzx_ViewpointVerEN.CreateDate = objDT.Rows[0][conzx_ViewpointVer.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_ViewpointVerEN.zxShareId = objDT.Rows[0][conzx_ViewpointVer.zxShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objzx_ViewpointVerEN.Memo = objDT.Rows[0][conzx_ViewpointVer.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_ViewpointVerEN.TeammenberId = objDT.Rows[0][conzx_ViewpointVer.TeammenberId].ToString().Trim(); //主键(字段类型:char,字段长度:8,是否可空:False)
 objzx_ViewpointVerEN.PdfDivLet = objDT.Rows[0][conzx_ViewpointVer.PdfDivLet].ToString().Trim(); //PdfDivLet(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_ViewpointVerEN.PdfDivTop = objDT.Rows[0][conzx_ViewpointVer.PdfDivTop].ToString().Trim(); //PdfDivTop(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_ViewpointVerEN.PdfPageNumIn = objDT.Rows[0][conzx_ViewpointVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_ViewpointVerEN.PdfPageTop = TransNullToInt(objDT.Rows[0][conzx_ViewpointVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置(字段类型:int,字段长度:4,是否可空:True)
 objzx_ViewpointVerEN.PdfZoom = objDT.Rows[0][conzx_ViewpointVer.PdfZoom].ToString().Trim(); //PdfZoom(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_ViewpointVerEN.GroupTextId = objDT.Rows[0][conzx_ViewpointVer.GroupTextId].ToString().Trim(); //小组Id(字段类型:char,字段长度:8,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clszx_ViewpointVerDA: Getzx_ViewpointVer)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngViewpointVId">表关键字</param>
 /// <returns>表对象</returns>
public clszx_ViewpointVerEN GetObjByViewpointVId(long lngViewpointVId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointVerDA.GetSpecSQLObj();
strSQL = "Select * from zx_ViewpointVer where ViewpointVId = " + ""+ lngViewpointVId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clszx_ViewpointVerEN objzx_ViewpointVerEN = new clszx_ViewpointVerEN();
try
{
 objzx_ViewpointVerEN.ViewpointVId = Int32.Parse(objRow[conzx_ViewpointVer.ViewpointVId].ToString().Trim()); //ViewpointVId(字段类型:bigint,字段长度:8,是否可空:False)
 objzx_ViewpointVerEN.zxViewpointId = objRow[conzx_ViewpointVer.zxViewpointId].ToString().Trim(); //观点Id(字段类型:char,字段长度:8,是否可空:True)
 objzx_ViewpointVerEN.ViewpointName = objRow[conzx_ViewpointVer.ViewpointName] == DBNull.Value ? null : objRow[conzx_ViewpointVer.ViewpointName].ToString().Trim(); //观点名称(字段类型:varchar,字段长度:500,是否可空:True)
 objzx_ViewpointVerEN.ViewpointContent = objRow[conzx_ViewpointVer.ViewpointContent] == DBNull.Value ? null : objRow[conzx_ViewpointVer.ViewpointContent].ToString().Trim(); //观点内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objzx_ViewpointVerEN.zxViewpointTypeId = objRow[conzx_ViewpointVer.zxViewpointTypeId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.zxViewpointTypeId].ToString().Trim(); //观点类型Id(字段类型:char,字段长度:4,是否可空:True)
 objzx_ViewpointVerEN.Reason = objRow[conzx_ViewpointVer.Reason] == DBNull.Value ? null : objRow[conzx_ViewpointVer.Reason].ToString().Trim(); //理由(字段类型:text,字段长度:2147483647,是否可空:True)
 objzx_ViewpointVerEN.Source = objRow[conzx_ViewpointVer.Source] == DBNull.Value ? null : objRow[conzx_ViewpointVer.Source].ToString().Trim(); //来源(字段类型:varchar,字段长度:500,是否可空:True)
 objzx_ViewpointVerEN.VPProposePeople = objRow[conzx_ViewpointVer.VPProposePeople] == DBNull.Value ? null : objRow[conzx_ViewpointVer.VPProposePeople].ToString().Trim(); //观点提出人(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_ViewpointVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_ViewpointVer.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objzx_ViewpointVerEN.UserTypeId = objRow[conzx_ViewpointVer.UserTypeId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objzx_ViewpointVerEN.TextId = objRow[conzx_ViewpointVer.TextId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.TextId].ToString().Trim(); //课件Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_ViewpointVerEN.VoteCount = objRow[conzx_ViewpointVer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewpointVer.VoteCount].ToString().Trim()); //点赞计数(字段类型:int,字段长度:4,是否可空:True)
 objzx_ViewpointVerEN.AppraiseCount = objRow[conzx_ViewpointVer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewpointVer.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objzx_ViewpointVerEN.Score = objRow[conzx_ViewpointVer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ViewpointVer.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objzx_ViewpointVerEN.StuScore = objRow[conzx_ViewpointVer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ViewpointVer.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objzx_ViewpointVerEN.TeaScore = objRow[conzx_ViewpointVer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ViewpointVer.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objzx_ViewpointVerEN.UpdDate = objRow[conzx_ViewpointVer.UpdDate] == DBNull.Value ? null : objRow[conzx_ViewpointVer.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_ViewpointVerEN.UpdUser = objRow[conzx_ViewpointVer.UpdUser] == DBNull.Value ? null : objRow[conzx_ViewpointVer.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_ViewpointVerEN.IdCurrEduCls = objRow[conzx_ViewpointVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_ViewpointVer.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objzx_ViewpointVerEN.PdfContent = objRow[conzx_ViewpointVer.PdfContent] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objzx_ViewpointVerEN.PdfPageNum = objRow[conzx_ViewpointVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewpointVer.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objzx_ViewpointVerEN.CitationCount = objRow[conzx_ViewpointVer.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewpointVer.CitationCount].ToString().Trim()); //引用统计(字段类型:int,字段长度:4,是否可空:True)
 objzx_ViewpointVerEN.VersionCount = objRow[conzx_ViewpointVer.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewpointVer.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objzx_ViewpointVerEN.CreateDate = objRow[conzx_ViewpointVer.CreateDate] == DBNull.Value ? null : objRow[conzx_ViewpointVer.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_ViewpointVerEN.zxShareId = objRow[conzx_ViewpointVer.zxShareId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.zxShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objzx_ViewpointVerEN.Memo = objRow[conzx_ViewpointVer.Memo] == DBNull.Value ? null : objRow[conzx_ViewpointVer.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_ViewpointVerEN.TeammenberId = objRow[conzx_ViewpointVer.TeammenberId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.TeammenberId].ToString().Trim(); //主键(字段类型:char,字段长度:8,是否可空:False)
 objzx_ViewpointVerEN.PdfDivLet = objRow[conzx_ViewpointVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfDivLet].ToString().Trim(); //PdfDivLet(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_ViewpointVerEN.PdfDivTop = objRow[conzx_ViewpointVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfDivTop].ToString().Trim(); //PdfDivTop(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_ViewpointVerEN.PdfPageNumIn = objRow[conzx_ViewpointVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_ViewpointVerEN.PdfPageTop = objRow[conzx_ViewpointVer.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewpointVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置(字段类型:int,字段长度:4,是否可空:True)
 objzx_ViewpointVerEN.PdfZoom = objRow[conzx_ViewpointVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfZoom].ToString().Trim(); //PdfZoom(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_ViewpointVerEN.GroupTextId = objRow[conzx_ViewpointVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.GroupTextId].ToString().Trim(); //小组Id(字段类型:char,字段长度:8,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clszx_ViewpointVerDA: GetObjByViewpointVId)", objException.Message));
}
return objzx_ViewpointVerEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clszx_ViewpointVerEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clszx_ViewpointVerDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointVerDA.GetSpecSQLObj();
strSQL = "Select * from zx_ViewpointVer where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clszx_ViewpointVerEN objzx_ViewpointVerEN = new clszx_ViewpointVerEN()
{
ViewpointVId = TransNullToInt(objRow[conzx_ViewpointVer.ViewpointVId].ToString().Trim()), //ViewpointVId
zxViewpointId = objRow[conzx_ViewpointVer.zxViewpointId].ToString().Trim(), //观点Id
ViewpointName = objRow[conzx_ViewpointVer.ViewpointName] == DBNull.Value ? null : objRow[conzx_ViewpointVer.ViewpointName].ToString().Trim(), //观点名称
ViewpointContent = objRow[conzx_ViewpointVer.ViewpointContent] == DBNull.Value ? null : objRow[conzx_ViewpointVer.ViewpointContent].ToString().Trim(), //观点内容
zxViewpointTypeId = objRow[conzx_ViewpointVer.zxViewpointTypeId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.zxViewpointTypeId].ToString().Trim(), //观点类型Id
Reason = objRow[conzx_ViewpointVer.Reason] == DBNull.Value ? null : objRow[conzx_ViewpointVer.Reason].ToString().Trim(), //理由
Source = objRow[conzx_ViewpointVer.Source] == DBNull.Value ? null : objRow[conzx_ViewpointVer.Source].ToString().Trim(), //来源
VPProposePeople = objRow[conzx_ViewpointVer.VPProposePeople] == DBNull.Value ? null : objRow[conzx_ViewpointVer.VPProposePeople].ToString().Trim(), //观点提出人
IsSubmit = TransNullToBool(objRow[conzx_ViewpointVer.IsSubmit].ToString().Trim()), //是否提交
UserTypeId = objRow[conzx_ViewpointVer.UserTypeId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.UserTypeId].ToString().Trim(), //用户类型Id
TextId = objRow[conzx_ViewpointVer.TextId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.TextId].ToString().Trim(), //课件Id
VoteCount = objRow[conzx_ViewpointVer.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ViewpointVer.VoteCount].ToString().Trim()), //点赞计数
AppraiseCount = objRow[conzx_ViewpointVer.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ViewpointVer.AppraiseCount].ToString().Trim()), //评论数
Score = objRow[conzx_ViewpointVer.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_ViewpointVer.Score].ToString().Trim()), //评分
StuScore = objRow[conzx_ViewpointVer.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_ViewpointVer.StuScore].ToString().Trim()), //学生平均分
TeaScore = objRow[conzx_ViewpointVer.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_ViewpointVer.TeaScore].ToString().Trim()), //教师评分
UpdDate = objRow[conzx_ViewpointVer.UpdDate] == DBNull.Value ? null : objRow[conzx_ViewpointVer.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conzx_ViewpointVer.UpdUser] == DBNull.Value ? null : objRow[conzx_ViewpointVer.UpdUser].ToString().Trim(), //修改人
IdCurrEduCls = objRow[conzx_ViewpointVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_ViewpointVer.IdCurrEduCls].ToString().Trim(), //教学班流水号
PdfContent = objRow[conzx_ViewpointVer.PdfContent] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfContent].ToString().Trim(), //Pdf内容
PdfPageNum = objRow[conzx_ViewpointVer.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ViewpointVer.PdfPageNum].ToString().Trim()), //Pdf页码
CitationCount = objRow[conzx_ViewpointVer.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ViewpointVer.CitationCount].ToString().Trim()), //引用统计
VersionCount = objRow[conzx_ViewpointVer.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ViewpointVer.VersionCount].ToString().Trim()), //版本统计
CreateDate = objRow[conzx_ViewpointVer.CreateDate] == DBNull.Value ? null : objRow[conzx_ViewpointVer.CreateDate].ToString().Trim(), //建立日期
zxShareId = objRow[conzx_ViewpointVer.zxShareId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.zxShareId].ToString().Trim(), //分享Id
Memo = objRow[conzx_ViewpointVer.Memo] == DBNull.Value ? null : objRow[conzx_ViewpointVer.Memo].ToString().Trim(), //备注
TeammenberId = objRow[conzx_ViewpointVer.TeammenberId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.TeammenberId].ToString().Trim(), //主键
PdfDivLet = objRow[conzx_ViewpointVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfDivLet].ToString().Trim(), //PdfDivLet
PdfDivTop = objRow[conzx_ViewpointVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfDivTop].ToString().Trim(), //PdfDivTop
PdfPageNumIn = objRow[conzx_ViewpointVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfPageNumIn].ToString().Trim(), //PdfPageNumIn
PdfPageTop = objRow[conzx_ViewpointVer.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ViewpointVer.PdfPageTop].ToString().Trim()), //pdf页面顶部位置
PdfZoom = objRow[conzx_ViewpointVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfZoom].ToString().Trim(), //PdfZoom
GroupTextId = objRow[conzx_ViewpointVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.GroupTextId].ToString().Trim() //小组Id
};
objzx_ViewpointVerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_ViewpointVerEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clszx_ViewpointVerDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clszx_ViewpointVerEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clszx_ViewpointVerEN objzx_ViewpointVerEN = new clszx_ViewpointVerEN();
try
{
objzx_ViewpointVerEN.ViewpointVId = TransNullToInt(objRow[conzx_ViewpointVer.ViewpointVId].ToString().Trim()); //ViewpointVId
objzx_ViewpointVerEN.zxViewpointId = objRow[conzx_ViewpointVer.zxViewpointId].ToString().Trim(); //观点Id
objzx_ViewpointVerEN.ViewpointName = objRow[conzx_ViewpointVer.ViewpointName] == DBNull.Value ? null : objRow[conzx_ViewpointVer.ViewpointName].ToString().Trim(); //观点名称
objzx_ViewpointVerEN.ViewpointContent = objRow[conzx_ViewpointVer.ViewpointContent] == DBNull.Value ? null : objRow[conzx_ViewpointVer.ViewpointContent].ToString().Trim(); //观点内容
objzx_ViewpointVerEN.zxViewpointTypeId = objRow[conzx_ViewpointVer.zxViewpointTypeId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.zxViewpointTypeId].ToString().Trim(); //观点类型Id
objzx_ViewpointVerEN.Reason = objRow[conzx_ViewpointVer.Reason] == DBNull.Value ? null : objRow[conzx_ViewpointVer.Reason].ToString().Trim(); //理由
objzx_ViewpointVerEN.Source = objRow[conzx_ViewpointVer.Source] == DBNull.Value ? null : objRow[conzx_ViewpointVer.Source].ToString().Trim(); //来源
objzx_ViewpointVerEN.VPProposePeople = objRow[conzx_ViewpointVer.VPProposePeople] == DBNull.Value ? null : objRow[conzx_ViewpointVer.VPProposePeople].ToString().Trim(); //观点提出人
objzx_ViewpointVerEN.IsSubmit = TransNullToBool(objRow[conzx_ViewpointVer.IsSubmit].ToString().Trim()); //是否提交
objzx_ViewpointVerEN.UserTypeId = objRow[conzx_ViewpointVer.UserTypeId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.UserTypeId].ToString().Trim(); //用户类型Id
objzx_ViewpointVerEN.TextId = objRow[conzx_ViewpointVer.TextId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.TextId].ToString().Trim(); //课件Id
objzx_ViewpointVerEN.VoteCount = objRow[conzx_ViewpointVer.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ViewpointVer.VoteCount].ToString().Trim()); //点赞计数
objzx_ViewpointVerEN.AppraiseCount = objRow[conzx_ViewpointVer.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ViewpointVer.AppraiseCount].ToString().Trim()); //评论数
objzx_ViewpointVerEN.Score = objRow[conzx_ViewpointVer.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_ViewpointVer.Score].ToString().Trim()); //评分
objzx_ViewpointVerEN.StuScore = objRow[conzx_ViewpointVer.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_ViewpointVer.StuScore].ToString().Trim()); //学生平均分
objzx_ViewpointVerEN.TeaScore = objRow[conzx_ViewpointVer.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_ViewpointVer.TeaScore].ToString().Trim()); //教师评分
objzx_ViewpointVerEN.UpdDate = objRow[conzx_ViewpointVer.UpdDate] == DBNull.Value ? null : objRow[conzx_ViewpointVer.UpdDate].ToString().Trim(); //修改日期
objzx_ViewpointVerEN.UpdUser = objRow[conzx_ViewpointVer.UpdUser] == DBNull.Value ? null : objRow[conzx_ViewpointVer.UpdUser].ToString().Trim(); //修改人
objzx_ViewpointVerEN.IdCurrEduCls = objRow[conzx_ViewpointVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_ViewpointVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_ViewpointVerEN.PdfContent = objRow[conzx_ViewpointVer.PdfContent] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfContent].ToString().Trim(); //Pdf内容
objzx_ViewpointVerEN.PdfPageNum = objRow[conzx_ViewpointVer.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ViewpointVer.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_ViewpointVerEN.CitationCount = objRow[conzx_ViewpointVer.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ViewpointVer.CitationCount].ToString().Trim()); //引用统计
objzx_ViewpointVerEN.VersionCount = objRow[conzx_ViewpointVer.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ViewpointVer.VersionCount].ToString().Trim()); //版本统计
objzx_ViewpointVerEN.CreateDate = objRow[conzx_ViewpointVer.CreateDate] == DBNull.Value ? null : objRow[conzx_ViewpointVer.CreateDate].ToString().Trim(); //建立日期
objzx_ViewpointVerEN.zxShareId = objRow[conzx_ViewpointVer.zxShareId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.zxShareId].ToString().Trim(); //分享Id
objzx_ViewpointVerEN.Memo = objRow[conzx_ViewpointVer.Memo] == DBNull.Value ? null : objRow[conzx_ViewpointVer.Memo].ToString().Trim(); //备注
objzx_ViewpointVerEN.TeammenberId = objRow[conzx_ViewpointVer.TeammenberId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.TeammenberId].ToString().Trim(); //主键
objzx_ViewpointVerEN.PdfDivLet = objRow[conzx_ViewpointVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_ViewpointVerEN.PdfDivTop = objRow[conzx_ViewpointVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_ViewpointVerEN.PdfPageNumIn = objRow[conzx_ViewpointVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_ViewpointVerEN.PdfPageTop = objRow[conzx_ViewpointVer.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ViewpointVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_ViewpointVerEN.PdfZoom = objRow[conzx_ViewpointVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfZoom].ToString().Trim(); //PdfZoom
objzx_ViewpointVerEN.GroupTextId = objRow[conzx_ViewpointVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.GroupTextId].ToString().Trim(); //小组Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clszx_ViewpointVerDA: GetObjByDataRowzx_ViewpointVer)", objException.Message));
}
objzx_ViewpointVerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_ViewpointVerEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clszx_ViewpointVerEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clszx_ViewpointVerEN objzx_ViewpointVerEN = new clszx_ViewpointVerEN();
try
{
objzx_ViewpointVerEN.ViewpointVId = TransNullToInt(objRow[conzx_ViewpointVer.ViewpointVId].ToString().Trim()); //ViewpointVId
objzx_ViewpointVerEN.zxViewpointId = objRow[conzx_ViewpointVer.zxViewpointId].ToString().Trim(); //观点Id
objzx_ViewpointVerEN.ViewpointName = objRow[conzx_ViewpointVer.ViewpointName] == DBNull.Value ? null : objRow[conzx_ViewpointVer.ViewpointName].ToString().Trim(); //观点名称
objzx_ViewpointVerEN.ViewpointContent = objRow[conzx_ViewpointVer.ViewpointContent] == DBNull.Value ? null : objRow[conzx_ViewpointVer.ViewpointContent].ToString().Trim(); //观点内容
objzx_ViewpointVerEN.zxViewpointTypeId = objRow[conzx_ViewpointVer.zxViewpointTypeId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.zxViewpointTypeId].ToString().Trim(); //观点类型Id
objzx_ViewpointVerEN.Reason = objRow[conzx_ViewpointVer.Reason] == DBNull.Value ? null : objRow[conzx_ViewpointVer.Reason].ToString().Trim(); //理由
objzx_ViewpointVerEN.Source = objRow[conzx_ViewpointVer.Source] == DBNull.Value ? null : objRow[conzx_ViewpointVer.Source].ToString().Trim(); //来源
objzx_ViewpointVerEN.VPProposePeople = objRow[conzx_ViewpointVer.VPProposePeople] == DBNull.Value ? null : objRow[conzx_ViewpointVer.VPProposePeople].ToString().Trim(); //观点提出人
objzx_ViewpointVerEN.IsSubmit = TransNullToBool(objRow[conzx_ViewpointVer.IsSubmit].ToString().Trim()); //是否提交
objzx_ViewpointVerEN.UserTypeId = objRow[conzx_ViewpointVer.UserTypeId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.UserTypeId].ToString().Trim(); //用户类型Id
objzx_ViewpointVerEN.TextId = objRow[conzx_ViewpointVer.TextId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.TextId].ToString().Trim(); //课件Id
objzx_ViewpointVerEN.VoteCount = objRow[conzx_ViewpointVer.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ViewpointVer.VoteCount].ToString().Trim()); //点赞计数
objzx_ViewpointVerEN.AppraiseCount = objRow[conzx_ViewpointVer.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ViewpointVer.AppraiseCount].ToString().Trim()); //评论数
objzx_ViewpointVerEN.Score = objRow[conzx_ViewpointVer.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_ViewpointVer.Score].ToString().Trim()); //评分
objzx_ViewpointVerEN.StuScore = objRow[conzx_ViewpointVer.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_ViewpointVer.StuScore].ToString().Trim()); //学生平均分
objzx_ViewpointVerEN.TeaScore = objRow[conzx_ViewpointVer.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_ViewpointVer.TeaScore].ToString().Trim()); //教师评分
objzx_ViewpointVerEN.UpdDate = objRow[conzx_ViewpointVer.UpdDate] == DBNull.Value ? null : objRow[conzx_ViewpointVer.UpdDate].ToString().Trim(); //修改日期
objzx_ViewpointVerEN.UpdUser = objRow[conzx_ViewpointVer.UpdUser] == DBNull.Value ? null : objRow[conzx_ViewpointVer.UpdUser].ToString().Trim(); //修改人
objzx_ViewpointVerEN.IdCurrEduCls = objRow[conzx_ViewpointVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_ViewpointVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_ViewpointVerEN.PdfContent = objRow[conzx_ViewpointVer.PdfContent] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfContent].ToString().Trim(); //Pdf内容
objzx_ViewpointVerEN.PdfPageNum = objRow[conzx_ViewpointVer.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ViewpointVer.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_ViewpointVerEN.CitationCount = objRow[conzx_ViewpointVer.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ViewpointVer.CitationCount].ToString().Trim()); //引用统计
objzx_ViewpointVerEN.VersionCount = objRow[conzx_ViewpointVer.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ViewpointVer.VersionCount].ToString().Trim()); //版本统计
objzx_ViewpointVerEN.CreateDate = objRow[conzx_ViewpointVer.CreateDate] == DBNull.Value ? null : objRow[conzx_ViewpointVer.CreateDate].ToString().Trim(); //建立日期
objzx_ViewpointVerEN.zxShareId = objRow[conzx_ViewpointVer.zxShareId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.zxShareId].ToString().Trim(); //分享Id
objzx_ViewpointVerEN.Memo = objRow[conzx_ViewpointVer.Memo] == DBNull.Value ? null : objRow[conzx_ViewpointVer.Memo].ToString().Trim(); //备注
objzx_ViewpointVerEN.TeammenberId = objRow[conzx_ViewpointVer.TeammenberId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.TeammenberId].ToString().Trim(); //主键
objzx_ViewpointVerEN.PdfDivLet = objRow[conzx_ViewpointVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_ViewpointVerEN.PdfDivTop = objRow[conzx_ViewpointVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_ViewpointVerEN.PdfPageNumIn = objRow[conzx_ViewpointVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_ViewpointVerEN.PdfPageTop = objRow[conzx_ViewpointVer.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ViewpointVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_ViewpointVerEN.PdfZoom = objRow[conzx_ViewpointVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfZoom].ToString().Trim(); //PdfZoom
objzx_ViewpointVerEN.GroupTextId = objRow[conzx_ViewpointVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.GroupTextId].ToString().Trim(); //小组Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clszx_ViewpointVerDA: GetObjByDataRow)", objException.Message));
}
objzx_ViewpointVerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_ViewpointVerEN;
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
objSQL = clszx_ViewpointVerDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clszx_ViewpointVerEN._CurrTabName, conzx_ViewpointVer.ViewpointVId, 8, "");
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
objSQL = clszx_ViewpointVerDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clszx_ViewpointVerEN._CurrTabName, conzx_ViewpointVer.ViewpointVId, 8, strPrefix);
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
 objSQL = clszx_ViewpointVerDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select ViewpointVId from zx_ViewpointVer where " + strCondition;
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
 objSQL = clszx_ViewpointVerDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select ViewpointVId from zx_ViewpointVer where " + strCondition;
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
 /// <param name = "lngViewpointVId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngViewpointVId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointVerDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("zx_ViewpointVer", "ViewpointVId = " + ""+ lngViewpointVId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clszx_ViewpointVerDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointVerDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("zx_ViewpointVer", strCondition))
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
objSQL = clszx_ViewpointVerDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("zx_ViewpointVer");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clszx_ViewpointVerEN objzx_ViewpointVerEN)
 {
 if (objzx_ViewpointVerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_ViewpointVerEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointVerDA.GetSpecSQLObj();
strSQL = "Select * from zx_ViewpointVer where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "zx_ViewpointVer");
objRow = objDS.Tables["zx_ViewpointVer"].NewRow();
objRow[conzx_ViewpointVer.zxViewpointId] = objzx_ViewpointVerEN.zxViewpointId; //观点Id
 if (objzx_ViewpointVerEN.ViewpointName !=  "")
 {
objRow[conzx_ViewpointVer.ViewpointName] = objzx_ViewpointVerEN.ViewpointName; //观点名称
 }
 if (objzx_ViewpointVerEN.ViewpointContent !=  "")
 {
objRow[conzx_ViewpointVer.ViewpointContent] = objzx_ViewpointVerEN.ViewpointContent; //观点内容
 }
 if (objzx_ViewpointVerEN.zxViewpointTypeId !=  "")
 {
objRow[conzx_ViewpointVer.zxViewpointTypeId] = objzx_ViewpointVerEN.zxViewpointTypeId; //观点类型Id
 }
 if (objzx_ViewpointVerEN.Reason !=  "")
 {
objRow[conzx_ViewpointVer.Reason] = objzx_ViewpointVerEN.Reason; //理由
 }
 if (objzx_ViewpointVerEN.Source !=  "")
 {
objRow[conzx_ViewpointVer.Source] = objzx_ViewpointVerEN.Source; //来源
 }
 if (objzx_ViewpointVerEN.VPProposePeople !=  "")
 {
objRow[conzx_ViewpointVer.VPProposePeople] = objzx_ViewpointVerEN.VPProposePeople; //观点提出人
 }
objRow[conzx_ViewpointVer.IsSubmit] = objzx_ViewpointVerEN.IsSubmit; //是否提交
 if (objzx_ViewpointVerEN.UserTypeId !=  "")
 {
objRow[conzx_ViewpointVer.UserTypeId] = objzx_ViewpointVerEN.UserTypeId; //用户类型Id
 }
 if (objzx_ViewpointVerEN.TextId !=  "")
 {
objRow[conzx_ViewpointVer.TextId] = objzx_ViewpointVerEN.TextId; //课件Id
 }
objRow[conzx_ViewpointVer.VoteCount] = objzx_ViewpointVerEN.VoteCount; //点赞计数
objRow[conzx_ViewpointVer.AppraiseCount] = objzx_ViewpointVerEN.AppraiseCount; //评论数
objRow[conzx_ViewpointVer.Score] = objzx_ViewpointVerEN.Score; //评分
objRow[conzx_ViewpointVer.StuScore] = objzx_ViewpointVerEN.StuScore; //学生平均分
objRow[conzx_ViewpointVer.TeaScore] = objzx_ViewpointVerEN.TeaScore; //教师评分
 if (objzx_ViewpointVerEN.UpdDate !=  "")
 {
objRow[conzx_ViewpointVer.UpdDate] = objzx_ViewpointVerEN.UpdDate; //修改日期
 }
 if (objzx_ViewpointVerEN.UpdUser !=  "")
 {
objRow[conzx_ViewpointVer.UpdUser] = objzx_ViewpointVerEN.UpdUser; //修改人
 }
 if (objzx_ViewpointVerEN.IdCurrEduCls !=  "")
 {
objRow[conzx_ViewpointVer.IdCurrEduCls] = objzx_ViewpointVerEN.IdCurrEduCls; //教学班流水号
 }
 if (objzx_ViewpointVerEN.PdfContent !=  "")
 {
objRow[conzx_ViewpointVer.PdfContent] = objzx_ViewpointVerEN.PdfContent; //Pdf内容
 }
objRow[conzx_ViewpointVer.PdfPageNum] = objzx_ViewpointVerEN.PdfPageNum; //Pdf页码
objRow[conzx_ViewpointVer.CitationCount] = objzx_ViewpointVerEN.CitationCount; //引用统计
objRow[conzx_ViewpointVer.VersionCount] = objzx_ViewpointVerEN.VersionCount; //版本统计
 if (objzx_ViewpointVerEN.CreateDate !=  "")
 {
objRow[conzx_ViewpointVer.CreateDate] = objzx_ViewpointVerEN.CreateDate; //建立日期
 }
 if (objzx_ViewpointVerEN.zxShareId !=  "")
 {
objRow[conzx_ViewpointVer.zxShareId] = objzx_ViewpointVerEN.zxShareId; //分享Id
 }
 if (objzx_ViewpointVerEN.Memo !=  "")
 {
objRow[conzx_ViewpointVer.Memo] = objzx_ViewpointVerEN.Memo; //备注
 }
 if (objzx_ViewpointVerEN.TeammenberId !=  "")
 {
objRow[conzx_ViewpointVer.TeammenberId] = objzx_ViewpointVerEN.TeammenberId; //主键
 }
 if (objzx_ViewpointVerEN.PdfDivLet !=  "")
 {
objRow[conzx_ViewpointVer.PdfDivLet] = objzx_ViewpointVerEN.PdfDivLet; //PdfDivLet
 }
 if (objzx_ViewpointVerEN.PdfDivTop !=  "")
 {
objRow[conzx_ViewpointVer.PdfDivTop] = objzx_ViewpointVerEN.PdfDivTop; //PdfDivTop
 }
 if (objzx_ViewpointVerEN.PdfPageNumIn !=  "")
 {
objRow[conzx_ViewpointVer.PdfPageNumIn] = objzx_ViewpointVerEN.PdfPageNumIn; //PdfPageNumIn
 }
objRow[conzx_ViewpointVer.PdfPageTop] = objzx_ViewpointVerEN.PdfPageTop; //pdf页面顶部位置
 if (objzx_ViewpointVerEN.PdfZoom !=  "")
 {
objRow[conzx_ViewpointVer.PdfZoom] = objzx_ViewpointVerEN.PdfZoom; //PdfZoom
 }
 if (objzx_ViewpointVerEN.GroupTextId !=  "")
 {
objRow[conzx_ViewpointVer.GroupTextId] = objzx_ViewpointVerEN.GroupTextId; //小组Id
 }
objDS.Tables[clszx_ViewpointVerEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clszx_ViewpointVerEN._CurrTabName);
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
 /// <param name = "objzx_ViewpointVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clszx_ViewpointVerEN objzx_ViewpointVerEN)
{
 if (objzx_ViewpointVerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_ViewpointVerEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objzx_ViewpointVerEN.zxViewpointId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.zxViewpointId);
 var strzxViewpointId = objzx_ViewpointVerEN.zxViewpointId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxViewpointId + "'");
 }
 
 if (objzx_ViewpointVerEN.ViewpointName !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.ViewpointName);
 var strViewpointName = objzx_ViewpointVerEN.ViewpointName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewpointName + "'");
 }
 
 if (objzx_ViewpointVerEN.ViewpointContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.ViewpointContent);
 var strViewpointContent = objzx_ViewpointVerEN.ViewpointContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewpointContent + "'");
 }
 
 if (objzx_ViewpointVerEN.zxViewpointTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.zxViewpointTypeId);
 var strzxViewpointTypeId = objzx_ViewpointVerEN.zxViewpointTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxViewpointTypeId + "'");
 }
 
 if (objzx_ViewpointVerEN.Reason !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.Reason);
 var strReason = objzx_ViewpointVerEN.Reason.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReason + "'");
 }
 
 if (objzx_ViewpointVerEN.Source !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.Source);
 var strSource = objzx_ViewpointVerEN.Source.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSource + "'");
 }
 
 if (objzx_ViewpointVerEN.VPProposePeople !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.VPProposePeople);
 var strVPProposePeople = objzx_ViewpointVerEN.VPProposePeople.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVPProposePeople + "'");
 }
 
 arrFieldListForInsert.Add(conzx_ViewpointVer.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_ViewpointVerEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_ViewpointVerEN.UserTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.UserTypeId);
 var strUserTypeId = objzx_ViewpointVerEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserTypeId + "'");
 }
 
 if (objzx_ViewpointVerEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.TextId);
 var strTextId = objzx_ViewpointVerEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 if (objzx_ViewpointVerEN.VoteCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.VoteCount);
 arrValueListForInsert.Add(objzx_ViewpointVerEN.VoteCount.ToString());
 }
 
 if (objzx_ViewpointVerEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.AppraiseCount);
 arrValueListForInsert.Add(objzx_ViewpointVerEN.AppraiseCount.ToString());
 }
 
 if (objzx_ViewpointVerEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.Score);
 arrValueListForInsert.Add(objzx_ViewpointVerEN.Score.ToString());
 }
 
 if (objzx_ViewpointVerEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.StuScore);
 arrValueListForInsert.Add(objzx_ViewpointVerEN.StuScore.ToString());
 }
 
 if (objzx_ViewpointVerEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.TeaScore);
 arrValueListForInsert.Add(objzx_ViewpointVerEN.TeaScore.ToString());
 }
 
 if (objzx_ViewpointVerEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.UpdDate);
 var strUpdDate = objzx_ViewpointVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_ViewpointVerEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.UpdUser);
 var strUpdUser = objzx_ViewpointVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_ViewpointVerEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.IdCurrEduCls);
 var strIdCurrEduCls = objzx_ViewpointVerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objzx_ViewpointVerEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.PdfContent);
 var strPdfContent = objzx_ViewpointVerEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objzx_ViewpointVerEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.PdfPageNum);
 arrValueListForInsert.Add(objzx_ViewpointVerEN.PdfPageNum.ToString());
 }
 
 if (objzx_ViewpointVerEN.CitationCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.CitationCount);
 arrValueListForInsert.Add(objzx_ViewpointVerEN.CitationCount.ToString());
 }
 
 if (objzx_ViewpointVerEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.VersionCount);
 arrValueListForInsert.Add(objzx_ViewpointVerEN.VersionCount.ToString());
 }
 
 if (objzx_ViewpointVerEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.CreateDate);
 var strCreateDate = objzx_ViewpointVerEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objzx_ViewpointVerEN.zxShareId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.zxShareId);
 var strzxShareId = objzx_ViewpointVerEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxShareId + "'");
 }
 
 if (objzx_ViewpointVerEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.Memo);
 var strMemo = objzx_ViewpointVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_ViewpointVerEN.TeammenberId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.TeammenberId);
 var strTeammenberId = objzx_ViewpointVerEN.TeammenberId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeammenberId + "'");
 }
 
 if (objzx_ViewpointVerEN.PdfDivLet !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.PdfDivLet);
 var strPdfDivLet = objzx_ViewpointVerEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivLet + "'");
 }
 
 if (objzx_ViewpointVerEN.PdfDivTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.PdfDivTop);
 var strPdfDivTop = objzx_ViewpointVerEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivTop + "'");
 }
 
 if (objzx_ViewpointVerEN.PdfPageNumIn !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.PdfPageNumIn);
 var strPdfPageNumIn = objzx_ViewpointVerEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfPageNumIn + "'");
 }
 
 if (objzx_ViewpointVerEN.PdfPageTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.PdfPageTop);
 arrValueListForInsert.Add(objzx_ViewpointVerEN.PdfPageTop.ToString());
 }
 
 if (objzx_ViewpointVerEN.PdfZoom !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.PdfZoom);
 var strPdfZoom = objzx_ViewpointVerEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfZoom + "'");
 }
 
 if (objzx_ViewpointVerEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.GroupTextId);
 var strGroupTextId = objzx_ViewpointVerEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_ViewpointVer");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointVerDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objzx_ViewpointVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clszx_ViewpointVerEN objzx_ViewpointVerEN)
{
 if (objzx_ViewpointVerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_ViewpointVerEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objzx_ViewpointVerEN.zxViewpointId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.zxViewpointId);
 var strzxViewpointId = objzx_ViewpointVerEN.zxViewpointId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxViewpointId + "'");
 }
 
 if (objzx_ViewpointVerEN.ViewpointName !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.ViewpointName);
 var strViewpointName = objzx_ViewpointVerEN.ViewpointName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewpointName + "'");
 }
 
 if (objzx_ViewpointVerEN.ViewpointContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.ViewpointContent);
 var strViewpointContent = objzx_ViewpointVerEN.ViewpointContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewpointContent + "'");
 }
 
 if (objzx_ViewpointVerEN.zxViewpointTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.zxViewpointTypeId);
 var strzxViewpointTypeId = objzx_ViewpointVerEN.zxViewpointTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxViewpointTypeId + "'");
 }
 
 if (objzx_ViewpointVerEN.Reason !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.Reason);
 var strReason = objzx_ViewpointVerEN.Reason.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReason + "'");
 }
 
 if (objzx_ViewpointVerEN.Source !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.Source);
 var strSource = objzx_ViewpointVerEN.Source.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSource + "'");
 }
 
 if (objzx_ViewpointVerEN.VPProposePeople !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.VPProposePeople);
 var strVPProposePeople = objzx_ViewpointVerEN.VPProposePeople.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVPProposePeople + "'");
 }
 
 arrFieldListForInsert.Add(conzx_ViewpointVer.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_ViewpointVerEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_ViewpointVerEN.UserTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.UserTypeId);
 var strUserTypeId = objzx_ViewpointVerEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserTypeId + "'");
 }
 
 if (objzx_ViewpointVerEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.TextId);
 var strTextId = objzx_ViewpointVerEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 if (objzx_ViewpointVerEN.VoteCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.VoteCount);
 arrValueListForInsert.Add(objzx_ViewpointVerEN.VoteCount.ToString());
 }
 
 if (objzx_ViewpointVerEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.AppraiseCount);
 arrValueListForInsert.Add(objzx_ViewpointVerEN.AppraiseCount.ToString());
 }
 
 if (objzx_ViewpointVerEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.Score);
 arrValueListForInsert.Add(objzx_ViewpointVerEN.Score.ToString());
 }
 
 if (objzx_ViewpointVerEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.StuScore);
 arrValueListForInsert.Add(objzx_ViewpointVerEN.StuScore.ToString());
 }
 
 if (objzx_ViewpointVerEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.TeaScore);
 arrValueListForInsert.Add(objzx_ViewpointVerEN.TeaScore.ToString());
 }
 
 if (objzx_ViewpointVerEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.UpdDate);
 var strUpdDate = objzx_ViewpointVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_ViewpointVerEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.UpdUser);
 var strUpdUser = objzx_ViewpointVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_ViewpointVerEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.IdCurrEduCls);
 var strIdCurrEduCls = objzx_ViewpointVerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objzx_ViewpointVerEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.PdfContent);
 var strPdfContent = objzx_ViewpointVerEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objzx_ViewpointVerEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.PdfPageNum);
 arrValueListForInsert.Add(objzx_ViewpointVerEN.PdfPageNum.ToString());
 }
 
 if (objzx_ViewpointVerEN.CitationCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.CitationCount);
 arrValueListForInsert.Add(objzx_ViewpointVerEN.CitationCount.ToString());
 }
 
 if (objzx_ViewpointVerEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.VersionCount);
 arrValueListForInsert.Add(objzx_ViewpointVerEN.VersionCount.ToString());
 }
 
 if (objzx_ViewpointVerEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.CreateDate);
 var strCreateDate = objzx_ViewpointVerEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objzx_ViewpointVerEN.zxShareId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.zxShareId);
 var strzxShareId = objzx_ViewpointVerEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxShareId + "'");
 }
 
 if (objzx_ViewpointVerEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.Memo);
 var strMemo = objzx_ViewpointVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_ViewpointVerEN.TeammenberId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.TeammenberId);
 var strTeammenberId = objzx_ViewpointVerEN.TeammenberId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeammenberId + "'");
 }
 
 if (objzx_ViewpointVerEN.PdfDivLet !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.PdfDivLet);
 var strPdfDivLet = objzx_ViewpointVerEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivLet + "'");
 }
 
 if (objzx_ViewpointVerEN.PdfDivTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.PdfDivTop);
 var strPdfDivTop = objzx_ViewpointVerEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivTop + "'");
 }
 
 if (objzx_ViewpointVerEN.PdfPageNumIn !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.PdfPageNumIn);
 var strPdfPageNumIn = objzx_ViewpointVerEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfPageNumIn + "'");
 }
 
 if (objzx_ViewpointVerEN.PdfPageTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.PdfPageTop);
 arrValueListForInsert.Add(objzx_ViewpointVerEN.PdfPageTop.ToString());
 }
 
 if (objzx_ViewpointVerEN.PdfZoom !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.PdfZoom);
 var strPdfZoom = objzx_ViewpointVerEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfZoom + "'");
 }
 
 if (objzx_ViewpointVerEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.GroupTextId);
 var strGroupTextId = objzx_ViewpointVerEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_ViewpointVer");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointVerDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objzx_ViewpointVerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clszx_ViewpointVerEN objzx_ViewpointVerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objzx_ViewpointVerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_ViewpointVerEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objzx_ViewpointVerEN.zxViewpointId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.zxViewpointId);
 var strzxViewpointId = objzx_ViewpointVerEN.zxViewpointId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxViewpointId + "'");
 }
 
 if (objzx_ViewpointVerEN.ViewpointName !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.ViewpointName);
 var strViewpointName = objzx_ViewpointVerEN.ViewpointName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewpointName + "'");
 }
 
 if (objzx_ViewpointVerEN.ViewpointContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.ViewpointContent);
 var strViewpointContent = objzx_ViewpointVerEN.ViewpointContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewpointContent + "'");
 }
 
 if (objzx_ViewpointVerEN.zxViewpointTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.zxViewpointTypeId);
 var strzxViewpointTypeId = objzx_ViewpointVerEN.zxViewpointTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxViewpointTypeId + "'");
 }
 
 if (objzx_ViewpointVerEN.Reason !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.Reason);
 var strReason = objzx_ViewpointVerEN.Reason.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReason + "'");
 }
 
 if (objzx_ViewpointVerEN.Source !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.Source);
 var strSource = objzx_ViewpointVerEN.Source.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSource + "'");
 }
 
 if (objzx_ViewpointVerEN.VPProposePeople !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.VPProposePeople);
 var strVPProposePeople = objzx_ViewpointVerEN.VPProposePeople.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVPProposePeople + "'");
 }
 
 arrFieldListForInsert.Add(conzx_ViewpointVer.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_ViewpointVerEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_ViewpointVerEN.UserTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.UserTypeId);
 var strUserTypeId = objzx_ViewpointVerEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserTypeId + "'");
 }
 
 if (objzx_ViewpointVerEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.TextId);
 var strTextId = objzx_ViewpointVerEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 if (objzx_ViewpointVerEN.VoteCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.VoteCount);
 arrValueListForInsert.Add(objzx_ViewpointVerEN.VoteCount.ToString());
 }
 
 if (objzx_ViewpointVerEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.AppraiseCount);
 arrValueListForInsert.Add(objzx_ViewpointVerEN.AppraiseCount.ToString());
 }
 
 if (objzx_ViewpointVerEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.Score);
 arrValueListForInsert.Add(objzx_ViewpointVerEN.Score.ToString());
 }
 
 if (objzx_ViewpointVerEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.StuScore);
 arrValueListForInsert.Add(objzx_ViewpointVerEN.StuScore.ToString());
 }
 
 if (objzx_ViewpointVerEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.TeaScore);
 arrValueListForInsert.Add(objzx_ViewpointVerEN.TeaScore.ToString());
 }
 
 if (objzx_ViewpointVerEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.UpdDate);
 var strUpdDate = objzx_ViewpointVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_ViewpointVerEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.UpdUser);
 var strUpdUser = objzx_ViewpointVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_ViewpointVerEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.IdCurrEduCls);
 var strIdCurrEduCls = objzx_ViewpointVerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objzx_ViewpointVerEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.PdfContent);
 var strPdfContent = objzx_ViewpointVerEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objzx_ViewpointVerEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.PdfPageNum);
 arrValueListForInsert.Add(objzx_ViewpointVerEN.PdfPageNum.ToString());
 }
 
 if (objzx_ViewpointVerEN.CitationCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.CitationCount);
 arrValueListForInsert.Add(objzx_ViewpointVerEN.CitationCount.ToString());
 }
 
 if (objzx_ViewpointVerEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.VersionCount);
 arrValueListForInsert.Add(objzx_ViewpointVerEN.VersionCount.ToString());
 }
 
 if (objzx_ViewpointVerEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.CreateDate);
 var strCreateDate = objzx_ViewpointVerEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objzx_ViewpointVerEN.zxShareId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.zxShareId);
 var strzxShareId = objzx_ViewpointVerEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxShareId + "'");
 }
 
 if (objzx_ViewpointVerEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.Memo);
 var strMemo = objzx_ViewpointVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_ViewpointVerEN.TeammenberId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.TeammenberId);
 var strTeammenberId = objzx_ViewpointVerEN.TeammenberId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeammenberId + "'");
 }
 
 if (objzx_ViewpointVerEN.PdfDivLet !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.PdfDivLet);
 var strPdfDivLet = objzx_ViewpointVerEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivLet + "'");
 }
 
 if (objzx_ViewpointVerEN.PdfDivTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.PdfDivTop);
 var strPdfDivTop = objzx_ViewpointVerEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivTop + "'");
 }
 
 if (objzx_ViewpointVerEN.PdfPageNumIn !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.PdfPageNumIn);
 var strPdfPageNumIn = objzx_ViewpointVerEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfPageNumIn + "'");
 }
 
 if (objzx_ViewpointVerEN.PdfPageTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.PdfPageTop);
 arrValueListForInsert.Add(objzx_ViewpointVerEN.PdfPageTop.ToString());
 }
 
 if (objzx_ViewpointVerEN.PdfZoom !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.PdfZoom);
 var strPdfZoom = objzx_ViewpointVerEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfZoom + "'");
 }
 
 if (objzx_ViewpointVerEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.GroupTextId);
 var strGroupTextId = objzx_ViewpointVerEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_ViewpointVer");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointVerDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objzx_ViewpointVerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clszx_ViewpointVerEN objzx_ViewpointVerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objzx_ViewpointVerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_ViewpointVerEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objzx_ViewpointVerEN.zxViewpointId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.zxViewpointId);
 var strzxViewpointId = objzx_ViewpointVerEN.zxViewpointId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxViewpointId + "'");
 }
 
 if (objzx_ViewpointVerEN.ViewpointName !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.ViewpointName);
 var strViewpointName = objzx_ViewpointVerEN.ViewpointName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewpointName + "'");
 }
 
 if (objzx_ViewpointVerEN.ViewpointContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.ViewpointContent);
 var strViewpointContent = objzx_ViewpointVerEN.ViewpointContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewpointContent + "'");
 }
 
 if (objzx_ViewpointVerEN.zxViewpointTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.zxViewpointTypeId);
 var strzxViewpointTypeId = objzx_ViewpointVerEN.zxViewpointTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxViewpointTypeId + "'");
 }
 
 if (objzx_ViewpointVerEN.Reason !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.Reason);
 var strReason = objzx_ViewpointVerEN.Reason.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReason + "'");
 }
 
 if (objzx_ViewpointVerEN.Source !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.Source);
 var strSource = objzx_ViewpointVerEN.Source.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSource + "'");
 }
 
 if (objzx_ViewpointVerEN.VPProposePeople !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.VPProposePeople);
 var strVPProposePeople = objzx_ViewpointVerEN.VPProposePeople.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVPProposePeople + "'");
 }
 
 arrFieldListForInsert.Add(conzx_ViewpointVer.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_ViewpointVerEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_ViewpointVerEN.UserTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.UserTypeId);
 var strUserTypeId = objzx_ViewpointVerEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserTypeId + "'");
 }
 
 if (objzx_ViewpointVerEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.TextId);
 var strTextId = objzx_ViewpointVerEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 if (objzx_ViewpointVerEN.VoteCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.VoteCount);
 arrValueListForInsert.Add(objzx_ViewpointVerEN.VoteCount.ToString());
 }
 
 if (objzx_ViewpointVerEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.AppraiseCount);
 arrValueListForInsert.Add(objzx_ViewpointVerEN.AppraiseCount.ToString());
 }
 
 if (objzx_ViewpointVerEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.Score);
 arrValueListForInsert.Add(objzx_ViewpointVerEN.Score.ToString());
 }
 
 if (objzx_ViewpointVerEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.StuScore);
 arrValueListForInsert.Add(objzx_ViewpointVerEN.StuScore.ToString());
 }
 
 if (objzx_ViewpointVerEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.TeaScore);
 arrValueListForInsert.Add(objzx_ViewpointVerEN.TeaScore.ToString());
 }
 
 if (objzx_ViewpointVerEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.UpdDate);
 var strUpdDate = objzx_ViewpointVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_ViewpointVerEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.UpdUser);
 var strUpdUser = objzx_ViewpointVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_ViewpointVerEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.IdCurrEduCls);
 var strIdCurrEduCls = objzx_ViewpointVerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objzx_ViewpointVerEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.PdfContent);
 var strPdfContent = objzx_ViewpointVerEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objzx_ViewpointVerEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.PdfPageNum);
 arrValueListForInsert.Add(objzx_ViewpointVerEN.PdfPageNum.ToString());
 }
 
 if (objzx_ViewpointVerEN.CitationCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.CitationCount);
 arrValueListForInsert.Add(objzx_ViewpointVerEN.CitationCount.ToString());
 }
 
 if (objzx_ViewpointVerEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.VersionCount);
 arrValueListForInsert.Add(objzx_ViewpointVerEN.VersionCount.ToString());
 }
 
 if (objzx_ViewpointVerEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.CreateDate);
 var strCreateDate = objzx_ViewpointVerEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objzx_ViewpointVerEN.zxShareId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.zxShareId);
 var strzxShareId = objzx_ViewpointVerEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxShareId + "'");
 }
 
 if (objzx_ViewpointVerEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.Memo);
 var strMemo = objzx_ViewpointVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_ViewpointVerEN.TeammenberId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.TeammenberId);
 var strTeammenberId = objzx_ViewpointVerEN.TeammenberId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeammenberId + "'");
 }
 
 if (objzx_ViewpointVerEN.PdfDivLet !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.PdfDivLet);
 var strPdfDivLet = objzx_ViewpointVerEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivLet + "'");
 }
 
 if (objzx_ViewpointVerEN.PdfDivTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.PdfDivTop);
 var strPdfDivTop = objzx_ViewpointVerEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivTop + "'");
 }
 
 if (objzx_ViewpointVerEN.PdfPageNumIn !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.PdfPageNumIn);
 var strPdfPageNumIn = objzx_ViewpointVerEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfPageNumIn + "'");
 }
 
 if (objzx_ViewpointVerEN.PdfPageTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.PdfPageTop);
 arrValueListForInsert.Add(objzx_ViewpointVerEN.PdfPageTop.ToString());
 }
 
 if (objzx_ViewpointVerEN.PdfZoom !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.PdfZoom);
 var strPdfZoom = objzx_ViewpointVerEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfZoom + "'");
 }
 
 if (objzx_ViewpointVerEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ViewpointVer.GroupTextId);
 var strGroupTextId = objzx_ViewpointVerEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_ViewpointVer");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointVerDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewzx_ViewpointVers(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointVerDA.GetSpecSQLObj();
strSQL = "Select * from zx_ViewpointVer where ViewpointVId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "zx_ViewpointVer");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngViewpointVId = TransNullToInt(oRow[conzx_ViewpointVer.ViewpointVId].ToString().Trim());
if (IsExist(lngViewpointVId))
{
 string strResult = "关键字变量值为:" + string.Format("ViewpointVId = {0}", lngViewpointVId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clszx_ViewpointVerEN._CurrTabName ].NewRow();
objRow[conzx_ViewpointVer.zxViewpointId] = oRow[conzx_ViewpointVer.zxViewpointId].ToString().Trim(); //观点Id
objRow[conzx_ViewpointVer.ViewpointName] = oRow[conzx_ViewpointVer.ViewpointName].ToString().Trim(); //观点名称
objRow[conzx_ViewpointVer.ViewpointContent] = oRow[conzx_ViewpointVer.ViewpointContent].ToString().Trim(); //观点内容
objRow[conzx_ViewpointVer.zxViewpointTypeId] = oRow[conzx_ViewpointVer.zxViewpointTypeId].ToString().Trim(); //观点类型Id
objRow[conzx_ViewpointVer.Reason] = oRow[conzx_ViewpointVer.Reason].ToString().Trim(); //理由
objRow[conzx_ViewpointVer.Source] = oRow[conzx_ViewpointVer.Source].ToString().Trim(); //来源
objRow[conzx_ViewpointVer.VPProposePeople] = oRow[conzx_ViewpointVer.VPProposePeople].ToString().Trim(); //观点提出人
objRow[conzx_ViewpointVer.IsSubmit] = oRow[conzx_ViewpointVer.IsSubmit].ToString().Trim(); //是否提交
objRow[conzx_ViewpointVer.UserTypeId] = oRow[conzx_ViewpointVer.UserTypeId].ToString().Trim(); //用户类型Id
objRow[conzx_ViewpointVer.TextId] = oRow[conzx_ViewpointVer.TextId].ToString().Trim(); //课件Id
objRow[conzx_ViewpointVer.VoteCount] = oRow[conzx_ViewpointVer.VoteCount].ToString().Trim(); //点赞计数
objRow[conzx_ViewpointVer.AppraiseCount] = oRow[conzx_ViewpointVer.AppraiseCount].ToString().Trim(); //评论数
objRow[conzx_ViewpointVer.Score] = oRow[conzx_ViewpointVer.Score].ToString().Trim(); //评分
objRow[conzx_ViewpointVer.StuScore] = oRow[conzx_ViewpointVer.StuScore].ToString().Trim(); //学生平均分
objRow[conzx_ViewpointVer.TeaScore] = oRow[conzx_ViewpointVer.TeaScore].ToString().Trim(); //教师评分
objRow[conzx_ViewpointVer.UpdDate] = oRow[conzx_ViewpointVer.UpdDate].ToString().Trim(); //修改日期
objRow[conzx_ViewpointVer.UpdUser] = oRow[conzx_ViewpointVer.UpdUser].ToString().Trim(); //修改人
objRow[conzx_ViewpointVer.IdCurrEduCls] = oRow[conzx_ViewpointVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objRow[conzx_ViewpointVer.PdfContent] = oRow[conzx_ViewpointVer.PdfContent].ToString().Trim(); //Pdf内容
objRow[conzx_ViewpointVer.PdfPageNum] = oRow[conzx_ViewpointVer.PdfPageNum].ToString().Trim(); //Pdf页码
objRow[conzx_ViewpointVer.CitationCount] = oRow[conzx_ViewpointVer.CitationCount].ToString().Trim(); //引用统计
objRow[conzx_ViewpointVer.VersionCount] = oRow[conzx_ViewpointVer.VersionCount].ToString().Trim(); //版本统计
objRow[conzx_ViewpointVer.CreateDate] = oRow[conzx_ViewpointVer.CreateDate].ToString().Trim(); //建立日期
objRow[conzx_ViewpointVer.zxShareId] = oRow[conzx_ViewpointVer.zxShareId].ToString().Trim(); //分享Id
objRow[conzx_ViewpointVer.Memo] = oRow[conzx_ViewpointVer.Memo].ToString().Trim(); //备注
objRow[conzx_ViewpointVer.TeammenberId] = oRow[conzx_ViewpointVer.TeammenberId].ToString().Trim(); //主键
objRow[conzx_ViewpointVer.PdfDivLet] = oRow[conzx_ViewpointVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objRow[conzx_ViewpointVer.PdfDivTop] = oRow[conzx_ViewpointVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objRow[conzx_ViewpointVer.PdfPageNumIn] = oRow[conzx_ViewpointVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objRow[conzx_ViewpointVer.PdfPageTop] = oRow[conzx_ViewpointVer.PdfPageTop].ToString().Trim(); //pdf页面顶部位置
objRow[conzx_ViewpointVer.PdfZoom] = oRow[conzx_ViewpointVer.PdfZoom].ToString().Trim(); //PdfZoom
objRow[conzx_ViewpointVer.GroupTextId] = oRow[conzx_ViewpointVer.GroupTextId].ToString().Trim(); //小组Id
 objDS.Tables[clszx_ViewpointVerEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clszx_ViewpointVerEN._CurrTabName);
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
 /// <param name = "objzx_ViewpointVerEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clszx_ViewpointVerEN objzx_ViewpointVerEN)
{
 if (objzx_ViewpointVerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_ViewpointVerEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointVerDA.GetSpecSQLObj();
strSQL = "Select * from zx_ViewpointVer where ViewpointVId = " + ""+ objzx_ViewpointVerEN.ViewpointVId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clszx_ViewpointVerEN._CurrTabName);
if (objDS.Tables[clszx_ViewpointVerEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:ViewpointVId = " + ""+ objzx_ViewpointVerEN.ViewpointVId+"");
return false;
}
objRow = objDS.Tables[clszx_ViewpointVerEN._CurrTabName].Rows[0];
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.zxViewpointId))
 {
objRow[conzx_ViewpointVer.zxViewpointId] = objzx_ViewpointVerEN.zxViewpointId; //观点Id
 }
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.ViewpointName))
 {
objRow[conzx_ViewpointVer.ViewpointName] = objzx_ViewpointVerEN.ViewpointName; //观点名称
 }
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.ViewpointContent))
 {
objRow[conzx_ViewpointVer.ViewpointContent] = objzx_ViewpointVerEN.ViewpointContent; //观点内容
 }
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.zxViewpointTypeId))
 {
objRow[conzx_ViewpointVer.zxViewpointTypeId] = objzx_ViewpointVerEN.zxViewpointTypeId; //观点类型Id
 }
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.Reason))
 {
objRow[conzx_ViewpointVer.Reason] = objzx_ViewpointVerEN.Reason; //理由
 }
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.Source))
 {
objRow[conzx_ViewpointVer.Source] = objzx_ViewpointVerEN.Source; //来源
 }
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.VPProposePeople))
 {
objRow[conzx_ViewpointVer.VPProposePeople] = objzx_ViewpointVerEN.VPProposePeople; //观点提出人
 }
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.IsSubmit))
 {
objRow[conzx_ViewpointVer.IsSubmit] = objzx_ViewpointVerEN.IsSubmit; //是否提交
 }
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.UserTypeId))
 {
objRow[conzx_ViewpointVer.UserTypeId] = objzx_ViewpointVerEN.UserTypeId; //用户类型Id
 }
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.TextId))
 {
objRow[conzx_ViewpointVer.TextId] = objzx_ViewpointVerEN.TextId; //课件Id
 }
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.VoteCount))
 {
objRow[conzx_ViewpointVer.VoteCount] = objzx_ViewpointVerEN.VoteCount; //点赞计数
 }
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.AppraiseCount))
 {
objRow[conzx_ViewpointVer.AppraiseCount] = objzx_ViewpointVerEN.AppraiseCount; //评论数
 }
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.Score))
 {
objRow[conzx_ViewpointVer.Score] = objzx_ViewpointVerEN.Score; //评分
 }
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.StuScore))
 {
objRow[conzx_ViewpointVer.StuScore] = objzx_ViewpointVerEN.StuScore; //学生平均分
 }
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.TeaScore))
 {
objRow[conzx_ViewpointVer.TeaScore] = objzx_ViewpointVerEN.TeaScore; //教师评分
 }
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.UpdDate))
 {
objRow[conzx_ViewpointVer.UpdDate] = objzx_ViewpointVerEN.UpdDate; //修改日期
 }
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.UpdUser))
 {
objRow[conzx_ViewpointVer.UpdUser] = objzx_ViewpointVerEN.UpdUser; //修改人
 }
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.IdCurrEduCls))
 {
objRow[conzx_ViewpointVer.IdCurrEduCls] = objzx_ViewpointVerEN.IdCurrEduCls; //教学班流水号
 }
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.PdfContent))
 {
objRow[conzx_ViewpointVer.PdfContent] = objzx_ViewpointVerEN.PdfContent; //Pdf内容
 }
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.PdfPageNum))
 {
objRow[conzx_ViewpointVer.PdfPageNum] = objzx_ViewpointVerEN.PdfPageNum; //Pdf页码
 }
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.CitationCount))
 {
objRow[conzx_ViewpointVer.CitationCount] = objzx_ViewpointVerEN.CitationCount; //引用统计
 }
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.VersionCount))
 {
objRow[conzx_ViewpointVer.VersionCount] = objzx_ViewpointVerEN.VersionCount; //版本统计
 }
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.CreateDate))
 {
objRow[conzx_ViewpointVer.CreateDate] = objzx_ViewpointVerEN.CreateDate; //建立日期
 }
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.zxShareId))
 {
objRow[conzx_ViewpointVer.zxShareId] = objzx_ViewpointVerEN.zxShareId; //分享Id
 }
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.Memo))
 {
objRow[conzx_ViewpointVer.Memo] = objzx_ViewpointVerEN.Memo; //备注
 }
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.TeammenberId))
 {
objRow[conzx_ViewpointVer.TeammenberId] = objzx_ViewpointVerEN.TeammenberId; //主键
 }
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.PdfDivLet))
 {
objRow[conzx_ViewpointVer.PdfDivLet] = objzx_ViewpointVerEN.PdfDivLet; //PdfDivLet
 }
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.PdfDivTop))
 {
objRow[conzx_ViewpointVer.PdfDivTop] = objzx_ViewpointVerEN.PdfDivTop; //PdfDivTop
 }
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.PdfPageNumIn))
 {
objRow[conzx_ViewpointVer.PdfPageNumIn] = objzx_ViewpointVerEN.PdfPageNumIn; //PdfPageNumIn
 }
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.PdfPageTop))
 {
objRow[conzx_ViewpointVer.PdfPageTop] = objzx_ViewpointVerEN.PdfPageTop; //pdf页面顶部位置
 }
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.PdfZoom))
 {
objRow[conzx_ViewpointVer.PdfZoom] = objzx_ViewpointVerEN.PdfZoom; //PdfZoom
 }
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.GroupTextId))
 {
objRow[conzx_ViewpointVer.GroupTextId] = objzx_ViewpointVerEN.GroupTextId; //小组Id
 }
try
{
objDA.Update(objDS, clszx_ViewpointVerEN._CurrTabName);
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
 /// <param name = "objzx_ViewpointVerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clszx_ViewpointVerEN objzx_ViewpointVerEN)
{
 if (objzx_ViewpointVerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_ViewpointVerEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointVerDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update zx_ViewpointVer Set ");
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.zxViewpointId))
 {
 if (objzx_ViewpointVerEN.zxViewpointId !=  null)
 {
 var strzxViewpointId = objzx_ViewpointVerEN.zxViewpointId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxViewpointId, conzx_ViewpointVer.zxViewpointId); //观点Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.zxViewpointId); //观点Id
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.ViewpointName))
 {
 if (objzx_ViewpointVerEN.ViewpointName !=  null)
 {
 var strViewpointName = objzx_ViewpointVerEN.ViewpointName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewpointName, conzx_ViewpointVer.ViewpointName); //观点名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.ViewpointName); //观点名称
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.ViewpointContent))
 {
 if (objzx_ViewpointVerEN.ViewpointContent !=  null)
 {
 var strViewpointContent = objzx_ViewpointVerEN.ViewpointContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewpointContent, conzx_ViewpointVer.ViewpointContent); //观点内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.ViewpointContent); //观点内容
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.zxViewpointTypeId))
 {
 if (objzx_ViewpointVerEN.zxViewpointTypeId !=  null)
 {
 var strzxViewpointTypeId = objzx_ViewpointVerEN.zxViewpointTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxViewpointTypeId, conzx_ViewpointVer.zxViewpointTypeId); //观点类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.zxViewpointTypeId); //观点类型Id
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.Reason))
 {
 if (objzx_ViewpointVerEN.Reason !=  null)
 {
 var strReason = objzx_ViewpointVerEN.Reason.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReason, conzx_ViewpointVer.Reason); //理由
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.Reason); //理由
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.Source))
 {
 if (objzx_ViewpointVerEN.Source !=  null)
 {
 var strSource = objzx_ViewpointVerEN.Source.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSource, conzx_ViewpointVer.Source); //来源
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.Source); //来源
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.VPProposePeople))
 {
 if (objzx_ViewpointVerEN.VPProposePeople !=  null)
 {
 var strVPProposePeople = objzx_ViewpointVerEN.VPProposePeople.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVPProposePeople, conzx_ViewpointVer.VPProposePeople); //观点提出人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.VPProposePeople); //观点提出人
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objzx_ViewpointVerEN.IsSubmit == true?"1":"0", conzx_ViewpointVer.IsSubmit); //是否提交
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.UserTypeId))
 {
 if (objzx_ViewpointVerEN.UserTypeId !=  null)
 {
 var strUserTypeId = objzx_ViewpointVerEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserTypeId, conzx_ViewpointVer.UserTypeId); //用户类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.UserTypeId); //用户类型Id
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.TextId))
 {
 if (objzx_ViewpointVerEN.TextId !=  null)
 {
 var strTextId = objzx_ViewpointVerEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTextId, conzx_ViewpointVer.TextId); //课件Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.TextId); //课件Id
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.VoteCount))
 {
 if (objzx_ViewpointVerEN.VoteCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ViewpointVerEN.VoteCount, conzx_ViewpointVer.VoteCount); //点赞计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.VoteCount); //点赞计数
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.AppraiseCount))
 {
 if (objzx_ViewpointVerEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ViewpointVerEN.AppraiseCount, conzx_ViewpointVer.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.AppraiseCount); //评论数
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.Score))
 {
 if (objzx_ViewpointVerEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ViewpointVerEN.Score, conzx_ViewpointVer.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.Score); //评分
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.StuScore))
 {
 if (objzx_ViewpointVerEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ViewpointVerEN.StuScore, conzx_ViewpointVer.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.StuScore); //学生平均分
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.TeaScore))
 {
 if (objzx_ViewpointVerEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ViewpointVerEN.TeaScore, conzx_ViewpointVer.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.TeaScore); //教师评分
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.UpdDate))
 {
 if (objzx_ViewpointVerEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_ViewpointVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conzx_ViewpointVer.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.UpdDate); //修改日期
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.UpdUser))
 {
 if (objzx_ViewpointVerEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_ViewpointVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conzx_ViewpointVer.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.UpdUser); //修改人
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.IdCurrEduCls))
 {
 if (objzx_ViewpointVerEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_ViewpointVerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conzx_ViewpointVer.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.PdfContent))
 {
 if (objzx_ViewpointVerEN.PdfContent !=  null)
 {
 var strPdfContent = objzx_ViewpointVerEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfContent, conzx_ViewpointVer.PdfContent); //Pdf内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.PdfContent); //Pdf内容
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.PdfPageNum))
 {
 if (objzx_ViewpointVerEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ViewpointVerEN.PdfPageNum, conzx_ViewpointVer.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.PdfPageNum); //Pdf页码
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.CitationCount))
 {
 if (objzx_ViewpointVerEN.CitationCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ViewpointVerEN.CitationCount, conzx_ViewpointVer.CitationCount); //引用统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.CitationCount); //引用统计
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.VersionCount))
 {
 if (objzx_ViewpointVerEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ViewpointVerEN.VersionCount, conzx_ViewpointVer.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.VersionCount); //版本统计
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.CreateDate))
 {
 if (objzx_ViewpointVerEN.CreateDate !=  null)
 {
 var strCreateDate = objzx_ViewpointVerEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateDate, conzx_ViewpointVer.CreateDate); //建立日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.CreateDate); //建立日期
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.zxShareId))
 {
 if (objzx_ViewpointVerEN.zxShareId !=  null)
 {
 var strzxShareId = objzx_ViewpointVerEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxShareId, conzx_ViewpointVer.zxShareId); //分享Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.zxShareId); //分享Id
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.Memo))
 {
 if (objzx_ViewpointVerEN.Memo !=  null)
 {
 var strMemo = objzx_ViewpointVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conzx_ViewpointVer.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.Memo); //备注
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.TeammenberId))
 {
 if (objzx_ViewpointVerEN.TeammenberId !=  null)
 {
 var strTeammenberId = objzx_ViewpointVerEN.TeammenberId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeammenberId, conzx_ViewpointVer.TeammenberId); //主键
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.TeammenberId); //主键
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.PdfDivLet))
 {
 if (objzx_ViewpointVerEN.PdfDivLet !=  null)
 {
 var strPdfDivLet = objzx_ViewpointVerEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfDivLet, conzx_ViewpointVer.PdfDivLet); //PdfDivLet
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.PdfDivLet); //PdfDivLet
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.PdfDivTop))
 {
 if (objzx_ViewpointVerEN.PdfDivTop !=  null)
 {
 var strPdfDivTop = objzx_ViewpointVerEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfDivTop, conzx_ViewpointVer.PdfDivTop); //PdfDivTop
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.PdfDivTop); //PdfDivTop
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.PdfPageNumIn))
 {
 if (objzx_ViewpointVerEN.PdfPageNumIn !=  null)
 {
 var strPdfPageNumIn = objzx_ViewpointVerEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfPageNumIn, conzx_ViewpointVer.PdfPageNumIn); //PdfPageNumIn
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.PdfPageNumIn); //PdfPageNumIn
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.PdfPageTop))
 {
 if (objzx_ViewpointVerEN.PdfPageTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ViewpointVerEN.PdfPageTop, conzx_ViewpointVer.PdfPageTop); //pdf页面顶部位置
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.PdfPageTop); //pdf页面顶部位置
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.PdfZoom))
 {
 if (objzx_ViewpointVerEN.PdfZoom !=  null)
 {
 var strPdfZoom = objzx_ViewpointVerEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfZoom, conzx_ViewpointVer.PdfZoom); //PdfZoom
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.PdfZoom); //PdfZoom
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.GroupTextId))
 {
 if (objzx_ViewpointVerEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_ViewpointVerEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGroupTextId, conzx_ViewpointVer.GroupTextId); //小组Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.GroupTextId); //小组Id
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ViewpointVId = {0}", objzx_ViewpointVerEN.ViewpointVId); 
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
 /// <param name = "objzx_ViewpointVerEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clszx_ViewpointVerEN objzx_ViewpointVerEN, string strCondition)
{
 if (objzx_ViewpointVerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_ViewpointVerEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointVerDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_ViewpointVer Set ");
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.zxViewpointId))
 {
 if (objzx_ViewpointVerEN.zxViewpointId !=  null)
 {
 var strzxViewpointId = objzx_ViewpointVerEN.zxViewpointId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxViewpointId = '{0}',", strzxViewpointId); //观点Id
 }
 else
 {
 sbSQL.Append(" zxViewpointId = null,"); //观点Id
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.ViewpointName))
 {
 if (objzx_ViewpointVerEN.ViewpointName !=  null)
 {
 var strViewpointName = objzx_ViewpointVerEN.ViewpointName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewpointName = '{0}',", strViewpointName); //观点名称
 }
 else
 {
 sbSQL.Append(" ViewpointName = null,"); //观点名称
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.ViewpointContent))
 {
 if (objzx_ViewpointVerEN.ViewpointContent !=  null)
 {
 var strViewpointContent = objzx_ViewpointVerEN.ViewpointContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewpointContent = '{0}',", strViewpointContent); //观点内容
 }
 else
 {
 sbSQL.Append(" ViewpointContent = null,"); //观点内容
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.zxViewpointTypeId))
 {
 if (objzx_ViewpointVerEN.zxViewpointTypeId !=  null)
 {
 var strzxViewpointTypeId = objzx_ViewpointVerEN.zxViewpointTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxViewpointTypeId = '{0}',", strzxViewpointTypeId); //观点类型Id
 }
 else
 {
 sbSQL.Append(" zxViewpointTypeId = null,"); //观点类型Id
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.Reason))
 {
 if (objzx_ViewpointVerEN.Reason !=  null)
 {
 var strReason = objzx_ViewpointVerEN.Reason.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Reason = '{0}',", strReason); //理由
 }
 else
 {
 sbSQL.Append(" Reason = null,"); //理由
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.Source))
 {
 if (objzx_ViewpointVerEN.Source !=  null)
 {
 var strSource = objzx_ViewpointVerEN.Source.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Source = '{0}',", strSource); //来源
 }
 else
 {
 sbSQL.Append(" Source = null,"); //来源
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.VPProposePeople))
 {
 if (objzx_ViewpointVerEN.VPProposePeople !=  null)
 {
 var strVPProposePeople = objzx_ViewpointVerEN.VPProposePeople.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VPProposePeople = '{0}',", strVPProposePeople); //观点提出人
 }
 else
 {
 sbSQL.Append(" VPProposePeople = null,"); //观点提出人
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objzx_ViewpointVerEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.UserTypeId))
 {
 if (objzx_ViewpointVerEN.UserTypeId !=  null)
 {
 var strUserTypeId = objzx_ViewpointVerEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserTypeId = '{0}',", strUserTypeId); //用户类型Id
 }
 else
 {
 sbSQL.Append(" UserTypeId = null,"); //用户类型Id
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.TextId))
 {
 if (objzx_ViewpointVerEN.TextId !=  null)
 {
 var strTextId = objzx_ViewpointVerEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TextId = '{0}',", strTextId); //课件Id
 }
 else
 {
 sbSQL.Append(" TextId = null,"); //课件Id
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.VoteCount))
 {
 if (objzx_ViewpointVerEN.VoteCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ViewpointVerEN.VoteCount, conzx_ViewpointVer.VoteCount); //点赞计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.VoteCount); //点赞计数
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.AppraiseCount))
 {
 if (objzx_ViewpointVerEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ViewpointVerEN.AppraiseCount, conzx_ViewpointVer.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.AppraiseCount); //评论数
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.Score))
 {
 if (objzx_ViewpointVerEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ViewpointVerEN.Score, conzx_ViewpointVer.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.Score); //评分
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.StuScore))
 {
 if (objzx_ViewpointVerEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ViewpointVerEN.StuScore, conzx_ViewpointVer.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.StuScore); //学生平均分
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.TeaScore))
 {
 if (objzx_ViewpointVerEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ViewpointVerEN.TeaScore, conzx_ViewpointVer.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.TeaScore); //教师评分
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.UpdDate))
 {
 if (objzx_ViewpointVerEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_ViewpointVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.UpdUser))
 {
 if (objzx_ViewpointVerEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_ViewpointVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.IdCurrEduCls))
 {
 if (objzx_ViewpointVerEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_ViewpointVerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.PdfContent))
 {
 if (objzx_ViewpointVerEN.PdfContent !=  null)
 {
 var strPdfContent = objzx_ViewpointVerEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfContent = '{0}',", strPdfContent); //Pdf内容
 }
 else
 {
 sbSQL.Append(" PdfContent = null,"); //Pdf内容
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.PdfPageNum))
 {
 if (objzx_ViewpointVerEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ViewpointVerEN.PdfPageNum, conzx_ViewpointVer.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.PdfPageNum); //Pdf页码
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.CitationCount))
 {
 if (objzx_ViewpointVerEN.CitationCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ViewpointVerEN.CitationCount, conzx_ViewpointVer.CitationCount); //引用统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.CitationCount); //引用统计
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.VersionCount))
 {
 if (objzx_ViewpointVerEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ViewpointVerEN.VersionCount, conzx_ViewpointVer.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.VersionCount); //版本统计
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.CreateDate))
 {
 if (objzx_ViewpointVerEN.CreateDate !=  null)
 {
 var strCreateDate = objzx_ViewpointVerEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateDate = '{0}',", strCreateDate); //建立日期
 }
 else
 {
 sbSQL.Append(" CreateDate = null,"); //建立日期
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.zxShareId))
 {
 if (objzx_ViewpointVerEN.zxShareId !=  null)
 {
 var strzxShareId = objzx_ViewpointVerEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxShareId = '{0}',", strzxShareId); //分享Id
 }
 else
 {
 sbSQL.Append(" zxShareId = null,"); //分享Id
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.Memo))
 {
 if (objzx_ViewpointVerEN.Memo !=  null)
 {
 var strMemo = objzx_ViewpointVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.TeammenberId))
 {
 if (objzx_ViewpointVerEN.TeammenberId !=  null)
 {
 var strTeammenberId = objzx_ViewpointVerEN.TeammenberId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeammenberId = '{0}',", strTeammenberId); //主键
 }
 else
 {
 sbSQL.Append(" TeammenberId = null,"); //主键
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.PdfDivLet))
 {
 if (objzx_ViewpointVerEN.PdfDivLet !=  null)
 {
 var strPdfDivLet = objzx_ViewpointVerEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfDivLet = '{0}',", strPdfDivLet); //PdfDivLet
 }
 else
 {
 sbSQL.Append(" PdfDivLet = null,"); //PdfDivLet
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.PdfDivTop))
 {
 if (objzx_ViewpointVerEN.PdfDivTop !=  null)
 {
 var strPdfDivTop = objzx_ViewpointVerEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfDivTop = '{0}',", strPdfDivTop); //PdfDivTop
 }
 else
 {
 sbSQL.Append(" PdfDivTop = null,"); //PdfDivTop
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.PdfPageNumIn))
 {
 if (objzx_ViewpointVerEN.PdfPageNumIn !=  null)
 {
 var strPdfPageNumIn = objzx_ViewpointVerEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfPageNumIn = '{0}',", strPdfPageNumIn); //PdfPageNumIn
 }
 else
 {
 sbSQL.Append(" PdfPageNumIn = null,"); //PdfPageNumIn
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.PdfPageTop))
 {
 if (objzx_ViewpointVerEN.PdfPageTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ViewpointVerEN.PdfPageTop, conzx_ViewpointVer.PdfPageTop); //pdf页面顶部位置
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.PdfPageTop); //pdf页面顶部位置
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.PdfZoom))
 {
 if (objzx_ViewpointVerEN.PdfZoom !=  null)
 {
 var strPdfZoom = objzx_ViewpointVerEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfZoom = '{0}',", strPdfZoom); //PdfZoom
 }
 else
 {
 sbSQL.Append(" PdfZoom = null,"); //PdfZoom
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.GroupTextId))
 {
 if (objzx_ViewpointVerEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_ViewpointVerEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objzx_ViewpointVerEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clszx_ViewpointVerEN objzx_ViewpointVerEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objzx_ViewpointVerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_ViewpointVerEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointVerDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_ViewpointVer Set ");
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.zxViewpointId))
 {
 if (objzx_ViewpointVerEN.zxViewpointId !=  null)
 {
 var strzxViewpointId = objzx_ViewpointVerEN.zxViewpointId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxViewpointId = '{0}',", strzxViewpointId); //观点Id
 }
 else
 {
 sbSQL.Append(" zxViewpointId = null,"); //观点Id
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.ViewpointName))
 {
 if (objzx_ViewpointVerEN.ViewpointName !=  null)
 {
 var strViewpointName = objzx_ViewpointVerEN.ViewpointName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewpointName = '{0}',", strViewpointName); //观点名称
 }
 else
 {
 sbSQL.Append(" ViewpointName = null,"); //观点名称
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.ViewpointContent))
 {
 if (objzx_ViewpointVerEN.ViewpointContent !=  null)
 {
 var strViewpointContent = objzx_ViewpointVerEN.ViewpointContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewpointContent = '{0}',", strViewpointContent); //观点内容
 }
 else
 {
 sbSQL.Append(" ViewpointContent = null,"); //观点内容
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.zxViewpointTypeId))
 {
 if (objzx_ViewpointVerEN.zxViewpointTypeId !=  null)
 {
 var strzxViewpointTypeId = objzx_ViewpointVerEN.zxViewpointTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxViewpointTypeId = '{0}',", strzxViewpointTypeId); //观点类型Id
 }
 else
 {
 sbSQL.Append(" zxViewpointTypeId = null,"); //观点类型Id
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.Reason))
 {
 if (objzx_ViewpointVerEN.Reason !=  null)
 {
 var strReason = objzx_ViewpointVerEN.Reason.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Reason = '{0}',", strReason); //理由
 }
 else
 {
 sbSQL.Append(" Reason = null,"); //理由
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.Source))
 {
 if (objzx_ViewpointVerEN.Source !=  null)
 {
 var strSource = objzx_ViewpointVerEN.Source.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Source = '{0}',", strSource); //来源
 }
 else
 {
 sbSQL.Append(" Source = null,"); //来源
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.VPProposePeople))
 {
 if (objzx_ViewpointVerEN.VPProposePeople !=  null)
 {
 var strVPProposePeople = objzx_ViewpointVerEN.VPProposePeople.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VPProposePeople = '{0}',", strVPProposePeople); //观点提出人
 }
 else
 {
 sbSQL.Append(" VPProposePeople = null,"); //观点提出人
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objzx_ViewpointVerEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.UserTypeId))
 {
 if (objzx_ViewpointVerEN.UserTypeId !=  null)
 {
 var strUserTypeId = objzx_ViewpointVerEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserTypeId = '{0}',", strUserTypeId); //用户类型Id
 }
 else
 {
 sbSQL.Append(" UserTypeId = null,"); //用户类型Id
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.TextId))
 {
 if (objzx_ViewpointVerEN.TextId !=  null)
 {
 var strTextId = objzx_ViewpointVerEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TextId = '{0}',", strTextId); //课件Id
 }
 else
 {
 sbSQL.Append(" TextId = null,"); //课件Id
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.VoteCount))
 {
 if (objzx_ViewpointVerEN.VoteCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ViewpointVerEN.VoteCount, conzx_ViewpointVer.VoteCount); //点赞计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.VoteCount); //点赞计数
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.AppraiseCount))
 {
 if (objzx_ViewpointVerEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ViewpointVerEN.AppraiseCount, conzx_ViewpointVer.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.AppraiseCount); //评论数
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.Score))
 {
 if (objzx_ViewpointVerEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ViewpointVerEN.Score, conzx_ViewpointVer.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.Score); //评分
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.StuScore))
 {
 if (objzx_ViewpointVerEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ViewpointVerEN.StuScore, conzx_ViewpointVer.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.StuScore); //学生平均分
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.TeaScore))
 {
 if (objzx_ViewpointVerEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ViewpointVerEN.TeaScore, conzx_ViewpointVer.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.TeaScore); //教师评分
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.UpdDate))
 {
 if (objzx_ViewpointVerEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_ViewpointVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.UpdUser))
 {
 if (objzx_ViewpointVerEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_ViewpointVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.IdCurrEduCls))
 {
 if (objzx_ViewpointVerEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_ViewpointVerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.PdfContent))
 {
 if (objzx_ViewpointVerEN.PdfContent !=  null)
 {
 var strPdfContent = objzx_ViewpointVerEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfContent = '{0}',", strPdfContent); //Pdf内容
 }
 else
 {
 sbSQL.Append(" PdfContent = null,"); //Pdf内容
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.PdfPageNum))
 {
 if (objzx_ViewpointVerEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ViewpointVerEN.PdfPageNum, conzx_ViewpointVer.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.PdfPageNum); //Pdf页码
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.CitationCount))
 {
 if (objzx_ViewpointVerEN.CitationCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ViewpointVerEN.CitationCount, conzx_ViewpointVer.CitationCount); //引用统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.CitationCount); //引用统计
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.VersionCount))
 {
 if (objzx_ViewpointVerEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ViewpointVerEN.VersionCount, conzx_ViewpointVer.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.VersionCount); //版本统计
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.CreateDate))
 {
 if (objzx_ViewpointVerEN.CreateDate !=  null)
 {
 var strCreateDate = objzx_ViewpointVerEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateDate = '{0}',", strCreateDate); //建立日期
 }
 else
 {
 sbSQL.Append(" CreateDate = null,"); //建立日期
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.zxShareId))
 {
 if (objzx_ViewpointVerEN.zxShareId !=  null)
 {
 var strzxShareId = objzx_ViewpointVerEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxShareId = '{0}',", strzxShareId); //分享Id
 }
 else
 {
 sbSQL.Append(" zxShareId = null,"); //分享Id
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.Memo))
 {
 if (objzx_ViewpointVerEN.Memo !=  null)
 {
 var strMemo = objzx_ViewpointVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.TeammenberId))
 {
 if (objzx_ViewpointVerEN.TeammenberId !=  null)
 {
 var strTeammenberId = objzx_ViewpointVerEN.TeammenberId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeammenberId = '{0}',", strTeammenberId); //主键
 }
 else
 {
 sbSQL.Append(" TeammenberId = null,"); //主键
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.PdfDivLet))
 {
 if (objzx_ViewpointVerEN.PdfDivLet !=  null)
 {
 var strPdfDivLet = objzx_ViewpointVerEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfDivLet = '{0}',", strPdfDivLet); //PdfDivLet
 }
 else
 {
 sbSQL.Append(" PdfDivLet = null,"); //PdfDivLet
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.PdfDivTop))
 {
 if (objzx_ViewpointVerEN.PdfDivTop !=  null)
 {
 var strPdfDivTop = objzx_ViewpointVerEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfDivTop = '{0}',", strPdfDivTop); //PdfDivTop
 }
 else
 {
 sbSQL.Append(" PdfDivTop = null,"); //PdfDivTop
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.PdfPageNumIn))
 {
 if (objzx_ViewpointVerEN.PdfPageNumIn !=  null)
 {
 var strPdfPageNumIn = objzx_ViewpointVerEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfPageNumIn = '{0}',", strPdfPageNumIn); //PdfPageNumIn
 }
 else
 {
 sbSQL.Append(" PdfPageNumIn = null,"); //PdfPageNumIn
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.PdfPageTop))
 {
 if (objzx_ViewpointVerEN.PdfPageTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ViewpointVerEN.PdfPageTop, conzx_ViewpointVer.PdfPageTop); //pdf页面顶部位置
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.PdfPageTop); //pdf页面顶部位置
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.PdfZoom))
 {
 if (objzx_ViewpointVerEN.PdfZoom !=  null)
 {
 var strPdfZoom = objzx_ViewpointVerEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfZoom = '{0}',", strPdfZoom); //PdfZoom
 }
 else
 {
 sbSQL.Append(" PdfZoom = null,"); //PdfZoom
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.GroupTextId))
 {
 if (objzx_ViewpointVerEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_ViewpointVerEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objzx_ViewpointVerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clszx_ViewpointVerEN objzx_ViewpointVerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objzx_ViewpointVerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_ViewpointVerEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointVerDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_ViewpointVer Set ");
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.zxViewpointId))
 {
 if (objzx_ViewpointVerEN.zxViewpointId !=  null)
 {
 var strzxViewpointId = objzx_ViewpointVerEN.zxViewpointId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxViewpointId, conzx_ViewpointVer.zxViewpointId); //观点Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.zxViewpointId); //观点Id
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.ViewpointName))
 {
 if (objzx_ViewpointVerEN.ViewpointName !=  null)
 {
 var strViewpointName = objzx_ViewpointVerEN.ViewpointName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewpointName, conzx_ViewpointVer.ViewpointName); //观点名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.ViewpointName); //观点名称
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.ViewpointContent))
 {
 if (objzx_ViewpointVerEN.ViewpointContent !=  null)
 {
 var strViewpointContent = objzx_ViewpointVerEN.ViewpointContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewpointContent, conzx_ViewpointVer.ViewpointContent); //观点内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.ViewpointContent); //观点内容
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.zxViewpointTypeId))
 {
 if (objzx_ViewpointVerEN.zxViewpointTypeId !=  null)
 {
 var strzxViewpointTypeId = objzx_ViewpointVerEN.zxViewpointTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxViewpointTypeId, conzx_ViewpointVer.zxViewpointTypeId); //观点类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.zxViewpointTypeId); //观点类型Id
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.Reason))
 {
 if (objzx_ViewpointVerEN.Reason !=  null)
 {
 var strReason = objzx_ViewpointVerEN.Reason.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReason, conzx_ViewpointVer.Reason); //理由
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.Reason); //理由
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.Source))
 {
 if (objzx_ViewpointVerEN.Source !=  null)
 {
 var strSource = objzx_ViewpointVerEN.Source.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSource, conzx_ViewpointVer.Source); //来源
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.Source); //来源
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.VPProposePeople))
 {
 if (objzx_ViewpointVerEN.VPProposePeople !=  null)
 {
 var strVPProposePeople = objzx_ViewpointVerEN.VPProposePeople.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVPProposePeople, conzx_ViewpointVer.VPProposePeople); //观点提出人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.VPProposePeople); //观点提出人
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objzx_ViewpointVerEN.IsSubmit == true?"1":"0", conzx_ViewpointVer.IsSubmit); //是否提交
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.UserTypeId))
 {
 if (objzx_ViewpointVerEN.UserTypeId !=  null)
 {
 var strUserTypeId = objzx_ViewpointVerEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserTypeId, conzx_ViewpointVer.UserTypeId); //用户类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.UserTypeId); //用户类型Id
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.TextId))
 {
 if (objzx_ViewpointVerEN.TextId !=  null)
 {
 var strTextId = objzx_ViewpointVerEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTextId, conzx_ViewpointVer.TextId); //课件Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.TextId); //课件Id
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.VoteCount))
 {
 if (objzx_ViewpointVerEN.VoteCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ViewpointVerEN.VoteCount, conzx_ViewpointVer.VoteCount); //点赞计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.VoteCount); //点赞计数
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.AppraiseCount))
 {
 if (objzx_ViewpointVerEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ViewpointVerEN.AppraiseCount, conzx_ViewpointVer.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.AppraiseCount); //评论数
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.Score))
 {
 if (objzx_ViewpointVerEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ViewpointVerEN.Score, conzx_ViewpointVer.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.Score); //评分
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.StuScore))
 {
 if (objzx_ViewpointVerEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ViewpointVerEN.StuScore, conzx_ViewpointVer.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.StuScore); //学生平均分
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.TeaScore))
 {
 if (objzx_ViewpointVerEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ViewpointVerEN.TeaScore, conzx_ViewpointVer.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.TeaScore); //教师评分
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.UpdDate))
 {
 if (objzx_ViewpointVerEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_ViewpointVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conzx_ViewpointVer.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.UpdDate); //修改日期
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.UpdUser))
 {
 if (objzx_ViewpointVerEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_ViewpointVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conzx_ViewpointVer.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.UpdUser); //修改人
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.IdCurrEduCls))
 {
 if (objzx_ViewpointVerEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_ViewpointVerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conzx_ViewpointVer.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.PdfContent))
 {
 if (objzx_ViewpointVerEN.PdfContent !=  null)
 {
 var strPdfContent = objzx_ViewpointVerEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfContent, conzx_ViewpointVer.PdfContent); //Pdf内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.PdfContent); //Pdf内容
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.PdfPageNum))
 {
 if (objzx_ViewpointVerEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ViewpointVerEN.PdfPageNum, conzx_ViewpointVer.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.PdfPageNum); //Pdf页码
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.CitationCount))
 {
 if (objzx_ViewpointVerEN.CitationCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ViewpointVerEN.CitationCount, conzx_ViewpointVer.CitationCount); //引用统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.CitationCount); //引用统计
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.VersionCount))
 {
 if (objzx_ViewpointVerEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ViewpointVerEN.VersionCount, conzx_ViewpointVer.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.VersionCount); //版本统计
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.CreateDate))
 {
 if (objzx_ViewpointVerEN.CreateDate !=  null)
 {
 var strCreateDate = objzx_ViewpointVerEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateDate, conzx_ViewpointVer.CreateDate); //建立日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.CreateDate); //建立日期
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.zxShareId))
 {
 if (objzx_ViewpointVerEN.zxShareId !=  null)
 {
 var strzxShareId = objzx_ViewpointVerEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxShareId, conzx_ViewpointVer.zxShareId); //分享Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.zxShareId); //分享Id
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.Memo))
 {
 if (objzx_ViewpointVerEN.Memo !=  null)
 {
 var strMemo = objzx_ViewpointVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conzx_ViewpointVer.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.Memo); //备注
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.TeammenberId))
 {
 if (objzx_ViewpointVerEN.TeammenberId !=  null)
 {
 var strTeammenberId = objzx_ViewpointVerEN.TeammenberId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeammenberId, conzx_ViewpointVer.TeammenberId); //主键
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.TeammenberId); //主键
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.PdfDivLet))
 {
 if (objzx_ViewpointVerEN.PdfDivLet !=  null)
 {
 var strPdfDivLet = objzx_ViewpointVerEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfDivLet, conzx_ViewpointVer.PdfDivLet); //PdfDivLet
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.PdfDivLet); //PdfDivLet
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.PdfDivTop))
 {
 if (objzx_ViewpointVerEN.PdfDivTop !=  null)
 {
 var strPdfDivTop = objzx_ViewpointVerEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfDivTop, conzx_ViewpointVer.PdfDivTop); //PdfDivTop
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.PdfDivTop); //PdfDivTop
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.PdfPageNumIn))
 {
 if (objzx_ViewpointVerEN.PdfPageNumIn !=  null)
 {
 var strPdfPageNumIn = objzx_ViewpointVerEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfPageNumIn, conzx_ViewpointVer.PdfPageNumIn); //PdfPageNumIn
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.PdfPageNumIn); //PdfPageNumIn
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.PdfPageTop))
 {
 if (objzx_ViewpointVerEN.PdfPageTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ViewpointVerEN.PdfPageTop, conzx_ViewpointVer.PdfPageTop); //pdf页面顶部位置
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.PdfPageTop); //pdf页面顶部位置
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.PdfZoom))
 {
 if (objzx_ViewpointVerEN.PdfZoom !=  null)
 {
 var strPdfZoom = objzx_ViewpointVerEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfZoom, conzx_ViewpointVer.PdfZoom); //PdfZoom
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.PdfZoom); //PdfZoom
 }
 }
 
 if (objzx_ViewpointVerEN.IsUpdated(conzx_ViewpointVer.GroupTextId))
 {
 if (objzx_ViewpointVerEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_ViewpointVerEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGroupTextId, conzx_ViewpointVer.GroupTextId); //小组Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ViewpointVer.GroupTextId); //小组Id
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ViewpointVId = {0}", objzx_ViewpointVerEN.ViewpointVId); 
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
 /// <param name = "lngViewpointVId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngViewpointVId) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointVerDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngViewpointVId,
};
 objSQL.ExecSP("zx_ViewpointVer_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngViewpointVId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngViewpointVId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointVerDA.GetSpecSQLObj();
//删除zx_ViewpointVer本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_ViewpointVer where ViewpointVId = " + ""+ lngViewpointVId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delzx_ViewpointVer(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointVerDA.GetSpecSQLObj();
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
//删除zx_ViewpointVer本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_ViewpointVer where ViewpointVId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngViewpointVId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngViewpointVId) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointVerDA.GetSpecSQLObj();
//删除zx_ViewpointVer本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_ViewpointVer where ViewpointVId = " + ""+ lngViewpointVId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delzx_ViewpointVer(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clszx_ViewpointVerDA: Delzx_ViewpointVer)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointVerDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from zx_ViewpointVer where " + strCondition ;
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
public bool Delzx_ViewpointVerWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clszx_ViewpointVerDA: Delzx_ViewpointVerWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointVerDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from zx_ViewpointVer where " + strCondition ;
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
 /// <param name = "objzx_ViewpointVerENS">源对象</param>
 /// <param name = "objzx_ViewpointVerENT">目标对象</param>
public void CopyTo(clszx_ViewpointVerEN objzx_ViewpointVerENS, clszx_ViewpointVerEN objzx_ViewpointVerENT)
{
objzx_ViewpointVerENT.ViewpointVId = objzx_ViewpointVerENS.ViewpointVId; //ViewpointVId
objzx_ViewpointVerENT.zxViewpointId = objzx_ViewpointVerENS.zxViewpointId; //观点Id
objzx_ViewpointVerENT.ViewpointName = objzx_ViewpointVerENS.ViewpointName; //观点名称
objzx_ViewpointVerENT.ViewpointContent = objzx_ViewpointVerENS.ViewpointContent; //观点内容
objzx_ViewpointVerENT.zxViewpointTypeId = objzx_ViewpointVerENS.zxViewpointTypeId; //观点类型Id
objzx_ViewpointVerENT.Reason = objzx_ViewpointVerENS.Reason; //理由
objzx_ViewpointVerENT.Source = objzx_ViewpointVerENS.Source; //来源
objzx_ViewpointVerENT.VPProposePeople = objzx_ViewpointVerENS.VPProposePeople; //观点提出人
objzx_ViewpointVerENT.IsSubmit = objzx_ViewpointVerENS.IsSubmit; //是否提交
objzx_ViewpointVerENT.UserTypeId = objzx_ViewpointVerENS.UserTypeId; //用户类型Id
objzx_ViewpointVerENT.TextId = objzx_ViewpointVerENS.TextId; //课件Id
objzx_ViewpointVerENT.VoteCount = objzx_ViewpointVerENS.VoteCount; //点赞计数
objzx_ViewpointVerENT.AppraiseCount = objzx_ViewpointVerENS.AppraiseCount; //评论数
objzx_ViewpointVerENT.Score = objzx_ViewpointVerENS.Score; //评分
objzx_ViewpointVerENT.StuScore = objzx_ViewpointVerENS.StuScore; //学生平均分
objzx_ViewpointVerENT.TeaScore = objzx_ViewpointVerENS.TeaScore; //教师评分
objzx_ViewpointVerENT.UpdDate = objzx_ViewpointVerENS.UpdDate; //修改日期
objzx_ViewpointVerENT.UpdUser = objzx_ViewpointVerENS.UpdUser; //修改人
objzx_ViewpointVerENT.IdCurrEduCls = objzx_ViewpointVerENS.IdCurrEduCls; //教学班流水号
objzx_ViewpointVerENT.PdfContent = objzx_ViewpointVerENS.PdfContent; //Pdf内容
objzx_ViewpointVerENT.PdfPageNum = objzx_ViewpointVerENS.PdfPageNum; //Pdf页码
objzx_ViewpointVerENT.CitationCount = objzx_ViewpointVerENS.CitationCount; //引用统计
objzx_ViewpointVerENT.VersionCount = objzx_ViewpointVerENS.VersionCount; //版本统计
objzx_ViewpointVerENT.CreateDate = objzx_ViewpointVerENS.CreateDate; //建立日期
objzx_ViewpointVerENT.zxShareId = objzx_ViewpointVerENS.zxShareId; //分享Id
objzx_ViewpointVerENT.Memo = objzx_ViewpointVerENS.Memo; //备注
objzx_ViewpointVerENT.TeammenberId = objzx_ViewpointVerENS.TeammenberId; //主键
objzx_ViewpointVerENT.PdfDivLet = objzx_ViewpointVerENS.PdfDivLet; //PdfDivLet
objzx_ViewpointVerENT.PdfDivTop = objzx_ViewpointVerENS.PdfDivTop; //PdfDivTop
objzx_ViewpointVerENT.PdfPageNumIn = objzx_ViewpointVerENS.PdfPageNumIn; //PdfPageNumIn
objzx_ViewpointVerENT.PdfPageTop = objzx_ViewpointVerENS.PdfPageTop; //pdf页面顶部位置
objzx_ViewpointVerENT.PdfZoom = objzx_ViewpointVerENS.PdfZoom; //PdfZoom
objzx_ViewpointVerENT.GroupTextId = objzx_ViewpointVerENS.GroupTextId; //小组Id
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clszx_ViewpointVerEN objzx_ViewpointVerEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objzx_ViewpointVerEN.zxViewpointId, conzx_ViewpointVer.zxViewpointId);
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_ViewpointVerEN.zxViewpointId, 8, conzx_ViewpointVer.zxViewpointId);
clsCheckSql.CheckFieldLen(objzx_ViewpointVerEN.ViewpointName, 500, conzx_ViewpointVer.ViewpointName);
clsCheckSql.CheckFieldLen(objzx_ViewpointVerEN.zxViewpointTypeId, 4, conzx_ViewpointVer.zxViewpointTypeId);
clsCheckSql.CheckFieldLen(objzx_ViewpointVerEN.Source, 500, conzx_ViewpointVer.Source);
clsCheckSql.CheckFieldLen(objzx_ViewpointVerEN.VPProposePeople, 50, conzx_ViewpointVer.VPProposePeople);
clsCheckSql.CheckFieldLen(objzx_ViewpointVerEN.UserTypeId, 2, conzx_ViewpointVer.UserTypeId);
clsCheckSql.CheckFieldLen(objzx_ViewpointVerEN.TextId, 8, conzx_ViewpointVer.TextId);
clsCheckSql.CheckFieldLen(objzx_ViewpointVerEN.UpdDate, 20, conzx_ViewpointVer.UpdDate);
clsCheckSql.CheckFieldLen(objzx_ViewpointVerEN.UpdUser, 20, conzx_ViewpointVer.UpdUser);
clsCheckSql.CheckFieldLen(objzx_ViewpointVerEN.IdCurrEduCls, 8, conzx_ViewpointVer.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objzx_ViewpointVerEN.PdfContent, 2000, conzx_ViewpointVer.PdfContent);
clsCheckSql.CheckFieldLen(objzx_ViewpointVerEN.CreateDate, 20, conzx_ViewpointVer.CreateDate);
clsCheckSql.CheckFieldLen(objzx_ViewpointVerEN.zxShareId, 2, conzx_ViewpointVer.zxShareId);
clsCheckSql.CheckFieldLen(objzx_ViewpointVerEN.Memo, 1000, conzx_ViewpointVer.Memo);
clsCheckSql.CheckFieldLen(objzx_ViewpointVerEN.TeammenberId, 8, conzx_ViewpointVer.TeammenberId);
clsCheckSql.CheckFieldLen(objzx_ViewpointVerEN.PdfDivLet, 50, conzx_ViewpointVer.PdfDivLet);
clsCheckSql.CheckFieldLen(objzx_ViewpointVerEN.PdfDivTop, 50, conzx_ViewpointVer.PdfDivTop);
clsCheckSql.CheckFieldLen(objzx_ViewpointVerEN.PdfPageNumIn, 50, conzx_ViewpointVer.PdfPageNumIn);
clsCheckSql.CheckFieldLen(objzx_ViewpointVerEN.PdfZoom, 50, conzx_ViewpointVer.PdfZoom);
clsCheckSql.CheckFieldLen(objzx_ViewpointVerEN.GroupTextId, 8, conzx_ViewpointVer.GroupTextId);
//检查字段外键固定长度
 objzx_ViewpointVerEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clszx_ViewpointVerEN objzx_ViewpointVerEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_ViewpointVerEN.zxViewpointId, 8, conzx_ViewpointVer.zxViewpointId);
clsCheckSql.CheckFieldLen(objzx_ViewpointVerEN.ViewpointName, 500, conzx_ViewpointVer.ViewpointName);
clsCheckSql.CheckFieldLen(objzx_ViewpointVerEN.zxViewpointTypeId, 4, conzx_ViewpointVer.zxViewpointTypeId);
clsCheckSql.CheckFieldLen(objzx_ViewpointVerEN.Source, 500, conzx_ViewpointVer.Source);
clsCheckSql.CheckFieldLen(objzx_ViewpointVerEN.VPProposePeople, 50, conzx_ViewpointVer.VPProposePeople);
clsCheckSql.CheckFieldLen(objzx_ViewpointVerEN.UserTypeId, 2, conzx_ViewpointVer.UserTypeId);
clsCheckSql.CheckFieldLen(objzx_ViewpointVerEN.TextId, 8, conzx_ViewpointVer.TextId);
clsCheckSql.CheckFieldLen(objzx_ViewpointVerEN.UpdDate, 20, conzx_ViewpointVer.UpdDate);
clsCheckSql.CheckFieldLen(objzx_ViewpointVerEN.UpdUser, 20, conzx_ViewpointVer.UpdUser);
clsCheckSql.CheckFieldLen(objzx_ViewpointVerEN.IdCurrEduCls, 8, conzx_ViewpointVer.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objzx_ViewpointVerEN.PdfContent, 2000, conzx_ViewpointVer.PdfContent);
clsCheckSql.CheckFieldLen(objzx_ViewpointVerEN.CreateDate, 20, conzx_ViewpointVer.CreateDate);
clsCheckSql.CheckFieldLen(objzx_ViewpointVerEN.zxShareId, 2, conzx_ViewpointVer.zxShareId);
clsCheckSql.CheckFieldLen(objzx_ViewpointVerEN.Memo, 1000, conzx_ViewpointVer.Memo);
clsCheckSql.CheckFieldLen(objzx_ViewpointVerEN.TeammenberId, 8, conzx_ViewpointVer.TeammenberId);
clsCheckSql.CheckFieldLen(objzx_ViewpointVerEN.PdfDivLet, 50, conzx_ViewpointVer.PdfDivLet);
clsCheckSql.CheckFieldLen(objzx_ViewpointVerEN.PdfDivTop, 50, conzx_ViewpointVer.PdfDivTop);
clsCheckSql.CheckFieldLen(objzx_ViewpointVerEN.PdfPageNumIn, 50, conzx_ViewpointVer.PdfPageNumIn);
clsCheckSql.CheckFieldLen(objzx_ViewpointVerEN.PdfZoom, 50, conzx_ViewpointVer.PdfZoom);
clsCheckSql.CheckFieldLen(objzx_ViewpointVerEN.GroupTextId, 8, conzx_ViewpointVer.GroupTextId);
//检查外键字段长度
 objzx_ViewpointVerEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clszx_ViewpointVerEN objzx_ViewpointVerEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_ViewpointVerEN.zxViewpointId, 8, conzx_ViewpointVer.zxViewpointId);
clsCheckSql.CheckFieldLen(objzx_ViewpointVerEN.ViewpointName, 500, conzx_ViewpointVer.ViewpointName);
clsCheckSql.CheckFieldLen(objzx_ViewpointVerEN.zxViewpointTypeId, 4, conzx_ViewpointVer.zxViewpointTypeId);
clsCheckSql.CheckFieldLen(objzx_ViewpointVerEN.Source, 500, conzx_ViewpointVer.Source);
clsCheckSql.CheckFieldLen(objzx_ViewpointVerEN.VPProposePeople, 50, conzx_ViewpointVer.VPProposePeople);
clsCheckSql.CheckFieldLen(objzx_ViewpointVerEN.UserTypeId, 2, conzx_ViewpointVer.UserTypeId);
clsCheckSql.CheckFieldLen(objzx_ViewpointVerEN.TextId, 8, conzx_ViewpointVer.TextId);
clsCheckSql.CheckFieldLen(objzx_ViewpointVerEN.UpdDate, 20, conzx_ViewpointVer.UpdDate);
clsCheckSql.CheckFieldLen(objzx_ViewpointVerEN.UpdUser, 20, conzx_ViewpointVer.UpdUser);
clsCheckSql.CheckFieldLen(objzx_ViewpointVerEN.IdCurrEduCls, 8, conzx_ViewpointVer.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objzx_ViewpointVerEN.PdfContent, 2000, conzx_ViewpointVer.PdfContent);
clsCheckSql.CheckFieldLen(objzx_ViewpointVerEN.CreateDate, 20, conzx_ViewpointVer.CreateDate);
clsCheckSql.CheckFieldLen(objzx_ViewpointVerEN.zxShareId, 2, conzx_ViewpointVer.zxShareId);
clsCheckSql.CheckFieldLen(objzx_ViewpointVerEN.Memo, 1000, conzx_ViewpointVer.Memo);
clsCheckSql.CheckFieldLen(objzx_ViewpointVerEN.TeammenberId, 8, conzx_ViewpointVer.TeammenberId);
clsCheckSql.CheckFieldLen(objzx_ViewpointVerEN.PdfDivLet, 50, conzx_ViewpointVer.PdfDivLet);
clsCheckSql.CheckFieldLen(objzx_ViewpointVerEN.PdfDivTop, 50, conzx_ViewpointVer.PdfDivTop);
clsCheckSql.CheckFieldLen(objzx_ViewpointVerEN.PdfPageNumIn, 50, conzx_ViewpointVer.PdfPageNumIn);
clsCheckSql.CheckFieldLen(objzx_ViewpointVerEN.PdfZoom, 50, conzx_ViewpointVer.PdfZoom);
clsCheckSql.CheckFieldLen(objzx_ViewpointVerEN.GroupTextId, 8, conzx_ViewpointVer.GroupTextId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objzx_ViewpointVerEN.zxViewpointId, conzx_ViewpointVer.zxViewpointId);
clsCheckSql.CheckSqlInjection4Field(objzx_ViewpointVerEN.ViewpointName, conzx_ViewpointVer.ViewpointName);
clsCheckSql.CheckSqlInjection4Field(objzx_ViewpointVerEN.zxViewpointTypeId, conzx_ViewpointVer.zxViewpointTypeId);
clsCheckSql.CheckSqlInjection4Field(objzx_ViewpointVerEN.Source, conzx_ViewpointVer.Source);
clsCheckSql.CheckSqlInjection4Field(objzx_ViewpointVerEN.VPProposePeople, conzx_ViewpointVer.VPProposePeople);
clsCheckSql.CheckSqlInjection4Field(objzx_ViewpointVerEN.UserTypeId, conzx_ViewpointVer.UserTypeId);
clsCheckSql.CheckSqlInjection4Field(objzx_ViewpointVerEN.TextId, conzx_ViewpointVer.TextId);
clsCheckSql.CheckSqlInjection4Field(objzx_ViewpointVerEN.UpdDate, conzx_ViewpointVer.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objzx_ViewpointVerEN.UpdUser, conzx_ViewpointVer.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objzx_ViewpointVerEN.IdCurrEduCls, conzx_ViewpointVer.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objzx_ViewpointVerEN.PdfContent, conzx_ViewpointVer.PdfContent);
clsCheckSql.CheckSqlInjection4Field(objzx_ViewpointVerEN.CreateDate, conzx_ViewpointVer.CreateDate);
clsCheckSql.CheckSqlInjection4Field(objzx_ViewpointVerEN.zxShareId, conzx_ViewpointVer.zxShareId);
clsCheckSql.CheckSqlInjection4Field(objzx_ViewpointVerEN.Memo, conzx_ViewpointVer.Memo);
clsCheckSql.CheckSqlInjection4Field(objzx_ViewpointVerEN.TeammenberId, conzx_ViewpointVer.TeammenberId);
clsCheckSql.CheckSqlInjection4Field(objzx_ViewpointVerEN.PdfDivLet, conzx_ViewpointVer.PdfDivLet);
clsCheckSql.CheckSqlInjection4Field(objzx_ViewpointVerEN.PdfDivTop, conzx_ViewpointVer.PdfDivTop);
clsCheckSql.CheckSqlInjection4Field(objzx_ViewpointVerEN.PdfPageNumIn, conzx_ViewpointVer.PdfPageNumIn);
clsCheckSql.CheckSqlInjection4Field(objzx_ViewpointVerEN.PdfZoom, conzx_ViewpointVer.PdfZoom);
clsCheckSql.CheckSqlInjection4Field(objzx_ViewpointVerEN.GroupTextId, conzx_ViewpointVer.GroupTextId);
//检查外键字段长度
 objzx_ViewpointVerEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--zx_ViewpointVer(观点历史版本),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objzx_ViewpointVerEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clszx_ViewpointVerEN objzx_ViewpointVerEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and zxViewpointId = '{0}'", objzx_ViewpointVerEN.zxViewpointId);
 if (objzx_ViewpointVerEN.GroupTextId == null)
{
 sbCondition.AppendFormat(" and GroupTextId is null");
}
else
{
 sbCondition.AppendFormat(" and GroupTextId = '{0}'", objzx_ViewpointVerEN.GroupTextId);
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
 objSQL = clszx_ViewpointVerDA.GetSpecSQLObj();
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
 objSQL = clszx_ViewpointVerDA.GetSpecSQLObj();
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
 objSQL = clszx_ViewpointVerDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clszx_ViewpointVerEN._CurrTabName);
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
 objSQL = clszx_ViewpointVerDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clszx_ViewpointVerEN._CurrTabName, strCondition);
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
 objSQL = clszx_ViewpointVerDA.GetSpecSQLObj();
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
 objSQL = clszx_ViewpointVerDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}