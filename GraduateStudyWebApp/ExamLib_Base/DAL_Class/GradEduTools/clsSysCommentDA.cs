
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSysCommentDA
 表名:SysComment(01120622)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:16:37
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培设置(GradEduTools)
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
 /// 系统评论表(SysComment)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsSysCommentDA : clsCommBase4DA
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
 return clsSysCommentEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsSysCommentEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsSysCommentEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsSysCommentEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsSysCommentEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strCommentId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strCommentId)
{
strCommentId = strCommentId.Replace("'", "''");
if (strCommentId.Length > 10)
{
throw new Exception("(errid:Data000001)在表:SysComment中,检查关键字,长度不正确!(clsSysCommentDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strCommentId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:SysComment中,关键字不能为空 或 null!(clsSysCommentDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCommentId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsSysCommentDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsSysCommentDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysCommentDA.GetSpecSQLObj();
strSQL = "Select * from SysComment where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_SysComment(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsSysCommentDA: GetDataTable_SysComment)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysCommentDA.GetSpecSQLObj();
strSQL = "Select * from SysComment where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsSysCommentDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysCommentDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsSysCommentDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysCommentDA.GetSpecSQLObj();
strSQL = "Select * from SysComment where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsSysCommentDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysCommentDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsSysCommentDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysCommentDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from SysComment where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from SysComment where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsSysCommentDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysCommentDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from SysComment where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsSysCommentDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysCommentDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} SysComment.* from SysComment Left Join {1} on {2} where {3} and SysComment.CommentId not in (Select top {5} SysComment.CommentId from SysComment Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from SysComment where {1} and CommentId not in (Select top {2} CommentId from SysComment where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from SysComment where {1} and CommentId not in (Select top {3} CommentId from SysComment where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsSysCommentDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysCommentDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} SysComment.* from SysComment Left Join {1} on {2} where {3} and SysComment.CommentId not in (Select top {5} SysComment.CommentId from SysComment Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from SysComment where {1} and CommentId not in (Select top {2} CommentId from SysComment where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from SysComment where {1} and CommentId not in (Select top {3} CommentId from SysComment where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsSysCommentEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsSysCommentDA:GetObjLst)", objException.Message));
}
List<clsSysCommentEN> arrObjLst = new List<clsSysCommentEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysCommentDA.GetSpecSQLObj();
strSQL = "Select * from SysComment where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysCommentEN objSysCommentEN = new clsSysCommentEN();
try
{
objSysCommentEN.CommentId = objRow[conSysComment.CommentId].ToString().Trim(); //评论Id
objSysCommentEN.Comment = objRow[conSysComment.Comment] == DBNull.Value ? null : objRow[conSysComment.Comment].ToString().Trim(); //评论
objSysCommentEN.Score = objRow[conSysComment.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conSysComment.Score].ToString().Trim()); //评分
objSysCommentEN.CommentTypeId = objRow[conSysComment.CommentTypeId].ToString().Trim(); //评论类型Id
objSysCommentEN.ScoreType = objRow[conSysComment.ScoreType] == DBNull.Value ? null : objRow[conSysComment.ScoreType].ToString().Trim(); //评分类型
objSysCommentEN.ParentId = objRow[conSysComment.ParentId].ToString().Trim(); //父Id
objSysCommentEN.TableKey = objRow[conSysComment.TableKey] == DBNull.Value ? null : objRow[conSysComment.TableKey].ToString().Trim(); //表主键
objSysCommentEN.OkCount = objRow[conSysComment.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysComment.OkCount].ToString().Trim()); //点赞统计
objSysCommentEN.PubParentId = objRow[conSysComment.PubParentId] == DBNull.Value ? null : objRow[conSysComment.PubParentId].ToString().Trim(); //公共父Id
objSysCommentEN.IdCurrEduCls = objRow[conSysComment.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysComment.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysCommentEN.UserId = objRow[conSysComment.UserId] == DBNull.Value ? null : objRow[conSysComment.UserId].ToString().Trim(); //用户ID
objSysCommentEN.Month = objRow[conSysComment.Month] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysComment.Month].ToString().Trim()); //月
objSysCommentEN.Week = objRow[conSysComment.Week] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysComment.Week].ToString().Trim()); //周
objSysCommentEN.WeekTimeRange = objRow[conSysComment.WeekTimeRange] == DBNull.Value ? null : objRow[conSysComment.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objSysCommentEN.UpdUser = objRow[conSysComment.UpdUser] == DBNull.Value ? null : objRow[conSysComment.UpdUser].ToString().Trim(); //修改人
objSysCommentEN.UpdDate = objRow[conSysComment.UpdDate] == DBNull.Value ? null : objRow[conSysComment.UpdDate].ToString().Trim(); //修改日期
objSysCommentEN.Memo = objRow[conSysComment.Memo] == DBNull.Value ? null : objRow[conSysComment.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsSysCommentDA: GetObjLst)", objException.Message));
}
objSysCommentEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objSysCommentEN);
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
public List<clsSysCommentEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsSysCommentDA:GetObjLstByTabName)", objException.Message));
}
List<clsSysCommentEN> arrObjLst = new List<clsSysCommentEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysCommentDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysCommentEN objSysCommentEN = new clsSysCommentEN();
try
{
objSysCommentEN.CommentId = objRow[conSysComment.CommentId].ToString().Trim(); //评论Id
objSysCommentEN.Comment = objRow[conSysComment.Comment] == DBNull.Value ? null : objRow[conSysComment.Comment].ToString().Trim(); //评论
objSysCommentEN.Score = objRow[conSysComment.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conSysComment.Score].ToString().Trim()); //评分
objSysCommentEN.CommentTypeId = objRow[conSysComment.CommentTypeId].ToString().Trim(); //评论类型Id
objSysCommentEN.ScoreType = objRow[conSysComment.ScoreType] == DBNull.Value ? null : objRow[conSysComment.ScoreType].ToString().Trim(); //评分类型
objSysCommentEN.ParentId = objRow[conSysComment.ParentId].ToString().Trim(); //父Id
objSysCommentEN.TableKey = objRow[conSysComment.TableKey] == DBNull.Value ? null : objRow[conSysComment.TableKey].ToString().Trim(); //表主键
objSysCommentEN.OkCount = objRow[conSysComment.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysComment.OkCount].ToString().Trim()); //点赞统计
objSysCommentEN.PubParentId = objRow[conSysComment.PubParentId] == DBNull.Value ? null : objRow[conSysComment.PubParentId].ToString().Trim(); //公共父Id
objSysCommentEN.IdCurrEduCls = objRow[conSysComment.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysComment.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysCommentEN.UserId = objRow[conSysComment.UserId] == DBNull.Value ? null : objRow[conSysComment.UserId].ToString().Trim(); //用户ID
objSysCommentEN.Month = objRow[conSysComment.Month] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysComment.Month].ToString().Trim()); //月
objSysCommentEN.Week = objRow[conSysComment.Week] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysComment.Week].ToString().Trim()); //周
objSysCommentEN.WeekTimeRange = objRow[conSysComment.WeekTimeRange] == DBNull.Value ? null : objRow[conSysComment.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objSysCommentEN.UpdUser = objRow[conSysComment.UpdUser] == DBNull.Value ? null : objRow[conSysComment.UpdUser].ToString().Trim(); //修改人
objSysCommentEN.UpdDate = objRow[conSysComment.UpdDate] == DBNull.Value ? null : objRow[conSysComment.UpdDate].ToString().Trim(); //修改日期
objSysCommentEN.Memo = objRow[conSysComment.Memo] == DBNull.Value ? null : objRow[conSysComment.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsSysCommentDA: GetObjLst)", objException.Message));
}
objSysCommentEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objSysCommentEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objSysCommentEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetSysComment(ref clsSysCommentEN objSysCommentEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysCommentDA.GetSpecSQLObj();
strSQL = "Select * from SysComment where CommentId = " + "'"+ objSysCommentEN.CommentId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objSysCommentEN.CommentId = objDT.Rows[0][conSysComment.CommentId].ToString().Trim(); //评论Id(字段类型:char,字段长度:10,是否可空:False)
 objSysCommentEN.Comment = objDT.Rows[0][conSysComment.Comment].ToString().Trim(); //评论(字段类型:varchar,字段长度:2000,是否可空:True)
 objSysCommentEN.Score = TransNullToFloat(objDT.Rows[0][conSysComment.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objSysCommentEN.CommentTypeId = objDT.Rows[0][conSysComment.CommentTypeId].ToString().Trim(); //评论类型Id(字段类型:char,字段长度:2,是否可空:False)
 objSysCommentEN.ScoreType = objDT.Rows[0][conSysComment.ScoreType].ToString().Trim(); //评分类型(字段类型:char,字段长度:1,是否可空:True)
 objSysCommentEN.ParentId = objDT.Rows[0][conSysComment.ParentId].ToString().Trim(); //父Id(字段类型:varchar,字段长度:20,是否可空:False)
 objSysCommentEN.TableKey = objDT.Rows[0][conSysComment.TableKey].ToString().Trim(); //表主键(字段类型:varchar,字段长度:20,是否可空:True)
 objSysCommentEN.OkCount = TransNullToInt(objDT.Rows[0][conSysComment.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objSysCommentEN.PubParentId = objDT.Rows[0][conSysComment.PubParentId].ToString().Trim(); //公共父Id(字段类型:varchar,字段长度:20,是否可空:True)
 objSysCommentEN.IdCurrEduCls = objDT.Rows[0][conSysComment.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objSysCommentEN.UserId = objDT.Rows[0][conSysComment.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objSysCommentEN.Month = TransNullToInt(objDT.Rows[0][conSysComment.Month].ToString().Trim()); //月(字段类型:int,字段长度:4,是否可空:True)
 objSysCommentEN.Week = TransNullToInt(objDT.Rows[0][conSysComment.Week].ToString().Trim()); //周(字段类型:int,字段长度:4,是否可空:True)
 objSysCommentEN.WeekTimeRange = objDT.Rows[0][conSysComment.WeekTimeRange].ToString().Trim(); //WeekTimeRange(字段类型:varchar,字段长度:100,是否可空:True)
 objSysCommentEN.UpdUser = objDT.Rows[0][conSysComment.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objSysCommentEN.UpdDate = objDT.Rows[0][conSysComment.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objSysCommentEN.Memo = objDT.Rows[0][conSysComment.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsSysCommentDA: GetSysComment)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strCommentId">表关键字</param>
 /// <returns>表对象</returns>
public clsSysCommentEN GetObjByCommentId(string strCommentId)
{
CheckPrimaryKey(strCommentId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysCommentDA.GetSpecSQLObj();
strSQL = "Select * from SysComment where CommentId = " + "'"+ strCommentId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsSysCommentEN objSysCommentEN = new clsSysCommentEN();
try
{
 objSysCommentEN.CommentId = objRow[conSysComment.CommentId].ToString().Trim(); //评论Id(字段类型:char,字段长度:10,是否可空:False)
 objSysCommentEN.Comment = objRow[conSysComment.Comment] == DBNull.Value ? null : objRow[conSysComment.Comment].ToString().Trim(); //评论(字段类型:varchar,字段长度:2000,是否可空:True)
 objSysCommentEN.Score = objRow[conSysComment.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysComment.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objSysCommentEN.CommentTypeId = objRow[conSysComment.CommentTypeId].ToString().Trim(); //评论类型Id(字段类型:char,字段长度:2,是否可空:False)
 objSysCommentEN.ScoreType = objRow[conSysComment.ScoreType] == DBNull.Value ? null : objRow[conSysComment.ScoreType].ToString().Trim(); //评分类型(字段类型:char,字段长度:1,是否可空:True)
 objSysCommentEN.ParentId = objRow[conSysComment.ParentId].ToString().Trim(); //父Id(字段类型:varchar,字段长度:20,是否可空:False)
 objSysCommentEN.TableKey = objRow[conSysComment.TableKey] == DBNull.Value ? null : objRow[conSysComment.TableKey].ToString().Trim(); //表主键(字段类型:varchar,字段长度:20,是否可空:True)
 objSysCommentEN.OkCount = objRow[conSysComment.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysComment.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objSysCommentEN.PubParentId = objRow[conSysComment.PubParentId] == DBNull.Value ? null : objRow[conSysComment.PubParentId].ToString().Trim(); //公共父Id(字段类型:varchar,字段长度:20,是否可空:True)
 objSysCommentEN.IdCurrEduCls = objRow[conSysComment.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysComment.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objSysCommentEN.UserId = objRow[conSysComment.UserId] == DBNull.Value ? null : objRow[conSysComment.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objSysCommentEN.Month = objRow[conSysComment.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysComment.Month].ToString().Trim()); //月(字段类型:int,字段长度:4,是否可空:True)
 objSysCommentEN.Week = objRow[conSysComment.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysComment.Week].ToString().Trim()); //周(字段类型:int,字段长度:4,是否可空:True)
 objSysCommentEN.WeekTimeRange = objRow[conSysComment.WeekTimeRange] == DBNull.Value ? null : objRow[conSysComment.WeekTimeRange].ToString().Trim(); //WeekTimeRange(字段类型:varchar,字段长度:100,是否可空:True)
 objSysCommentEN.UpdUser = objRow[conSysComment.UpdUser] == DBNull.Value ? null : objRow[conSysComment.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objSysCommentEN.UpdDate = objRow[conSysComment.UpdDate] == DBNull.Value ? null : objRow[conSysComment.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objSysCommentEN.Memo = objRow[conSysComment.Memo] == DBNull.Value ? null : objRow[conSysComment.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsSysCommentDA: GetObjByCommentId)", objException.Message));
}
return objSysCommentEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsSysCommentEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsSysCommentDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysCommentDA.GetSpecSQLObj();
strSQL = "Select * from SysComment where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsSysCommentEN objSysCommentEN = new clsSysCommentEN()
{
CommentId = objRow[conSysComment.CommentId].ToString().Trim(), //评论Id
Comment = objRow[conSysComment.Comment] == DBNull.Value ? null : objRow[conSysComment.Comment].ToString().Trim(), //评论
Score = objRow[conSysComment.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conSysComment.Score].ToString().Trim()), //评分
CommentTypeId = objRow[conSysComment.CommentTypeId].ToString().Trim(), //评论类型Id
ScoreType = objRow[conSysComment.ScoreType] == DBNull.Value ? null : objRow[conSysComment.ScoreType].ToString().Trim(), //评分类型
ParentId = objRow[conSysComment.ParentId].ToString().Trim(), //父Id
TableKey = objRow[conSysComment.TableKey] == DBNull.Value ? null : objRow[conSysComment.TableKey].ToString().Trim(), //表主键
OkCount = objRow[conSysComment.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysComment.OkCount].ToString().Trim()), //点赞统计
PubParentId = objRow[conSysComment.PubParentId] == DBNull.Value ? null : objRow[conSysComment.PubParentId].ToString().Trim(), //公共父Id
IdCurrEduCls = objRow[conSysComment.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysComment.IdCurrEduCls].ToString().Trim(), //教学班流水号
UserId = objRow[conSysComment.UserId] == DBNull.Value ? null : objRow[conSysComment.UserId].ToString().Trim(), //用户ID
Month = objRow[conSysComment.Month] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysComment.Month].ToString().Trim()), //月
Week = objRow[conSysComment.Week] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysComment.Week].ToString().Trim()), //周
WeekTimeRange = objRow[conSysComment.WeekTimeRange] == DBNull.Value ? null : objRow[conSysComment.WeekTimeRange].ToString().Trim(), //WeekTimeRange
UpdUser = objRow[conSysComment.UpdUser] == DBNull.Value ? null : objRow[conSysComment.UpdUser].ToString().Trim(), //修改人
UpdDate = objRow[conSysComment.UpdDate] == DBNull.Value ? null : objRow[conSysComment.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[conSysComment.Memo] == DBNull.Value ? null : objRow[conSysComment.Memo].ToString().Trim() //备注
};
objSysCommentEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objSysCommentEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsSysCommentDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsSysCommentEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsSysCommentEN objSysCommentEN = new clsSysCommentEN();
try
{
objSysCommentEN.CommentId = objRow[conSysComment.CommentId].ToString().Trim(); //评论Id
objSysCommentEN.Comment = objRow[conSysComment.Comment] == DBNull.Value ? null : objRow[conSysComment.Comment].ToString().Trim(); //评论
objSysCommentEN.Score = objRow[conSysComment.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conSysComment.Score].ToString().Trim()); //评分
objSysCommentEN.CommentTypeId = objRow[conSysComment.CommentTypeId].ToString().Trim(); //评论类型Id
objSysCommentEN.ScoreType = objRow[conSysComment.ScoreType] == DBNull.Value ? null : objRow[conSysComment.ScoreType].ToString().Trim(); //评分类型
objSysCommentEN.ParentId = objRow[conSysComment.ParentId].ToString().Trim(); //父Id
objSysCommentEN.TableKey = objRow[conSysComment.TableKey] == DBNull.Value ? null : objRow[conSysComment.TableKey].ToString().Trim(); //表主键
objSysCommentEN.OkCount = objRow[conSysComment.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysComment.OkCount].ToString().Trim()); //点赞统计
objSysCommentEN.PubParentId = objRow[conSysComment.PubParentId] == DBNull.Value ? null : objRow[conSysComment.PubParentId].ToString().Trim(); //公共父Id
objSysCommentEN.IdCurrEduCls = objRow[conSysComment.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysComment.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysCommentEN.UserId = objRow[conSysComment.UserId] == DBNull.Value ? null : objRow[conSysComment.UserId].ToString().Trim(); //用户ID
objSysCommentEN.Month = objRow[conSysComment.Month] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysComment.Month].ToString().Trim()); //月
objSysCommentEN.Week = objRow[conSysComment.Week] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysComment.Week].ToString().Trim()); //周
objSysCommentEN.WeekTimeRange = objRow[conSysComment.WeekTimeRange] == DBNull.Value ? null : objRow[conSysComment.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objSysCommentEN.UpdUser = objRow[conSysComment.UpdUser] == DBNull.Value ? null : objRow[conSysComment.UpdUser].ToString().Trim(); //修改人
objSysCommentEN.UpdDate = objRow[conSysComment.UpdDate] == DBNull.Value ? null : objRow[conSysComment.UpdDate].ToString().Trim(); //修改日期
objSysCommentEN.Memo = objRow[conSysComment.Memo] == DBNull.Value ? null : objRow[conSysComment.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsSysCommentDA: GetObjByDataRowSysComment)", objException.Message));
}
objSysCommentEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objSysCommentEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsSysCommentEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsSysCommentEN objSysCommentEN = new clsSysCommentEN();
try
{
objSysCommentEN.CommentId = objRow[conSysComment.CommentId].ToString().Trim(); //评论Id
objSysCommentEN.Comment = objRow[conSysComment.Comment] == DBNull.Value ? null : objRow[conSysComment.Comment].ToString().Trim(); //评论
objSysCommentEN.Score = objRow[conSysComment.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conSysComment.Score].ToString().Trim()); //评分
objSysCommentEN.CommentTypeId = objRow[conSysComment.CommentTypeId].ToString().Trim(); //评论类型Id
objSysCommentEN.ScoreType = objRow[conSysComment.ScoreType] == DBNull.Value ? null : objRow[conSysComment.ScoreType].ToString().Trim(); //评分类型
objSysCommentEN.ParentId = objRow[conSysComment.ParentId].ToString().Trim(); //父Id
objSysCommentEN.TableKey = objRow[conSysComment.TableKey] == DBNull.Value ? null : objRow[conSysComment.TableKey].ToString().Trim(); //表主键
objSysCommentEN.OkCount = objRow[conSysComment.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysComment.OkCount].ToString().Trim()); //点赞统计
objSysCommentEN.PubParentId = objRow[conSysComment.PubParentId] == DBNull.Value ? null : objRow[conSysComment.PubParentId].ToString().Trim(); //公共父Id
objSysCommentEN.IdCurrEduCls = objRow[conSysComment.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysComment.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysCommentEN.UserId = objRow[conSysComment.UserId] == DBNull.Value ? null : objRow[conSysComment.UserId].ToString().Trim(); //用户ID
objSysCommentEN.Month = objRow[conSysComment.Month] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysComment.Month].ToString().Trim()); //月
objSysCommentEN.Week = objRow[conSysComment.Week] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysComment.Week].ToString().Trim()); //周
objSysCommentEN.WeekTimeRange = objRow[conSysComment.WeekTimeRange] == DBNull.Value ? null : objRow[conSysComment.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objSysCommentEN.UpdUser = objRow[conSysComment.UpdUser] == DBNull.Value ? null : objRow[conSysComment.UpdUser].ToString().Trim(); //修改人
objSysCommentEN.UpdDate = objRow[conSysComment.UpdDate] == DBNull.Value ? null : objRow[conSysComment.UpdDate].ToString().Trim(); //修改日期
objSysCommentEN.Memo = objRow[conSysComment.Memo] == DBNull.Value ? null : objRow[conSysComment.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsSysCommentDA: GetObjByDataRow)", objException.Message));
}
objSysCommentEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objSysCommentEN;
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
objSQL = clsSysCommentDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsSysCommentEN._CurrTabName, conSysComment.CommentId, 10, "");
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
objSQL = clsSysCommentDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsSysCommentEN._CurrTabName, conSysComment.CommentId, 10, strPrefix);
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
 objSQL = clsSysCommentDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select CommentId from SysComment where " + strCondition;
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
 objSQL = clsSysCommentDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select CommentId from SysComment where " + strCondition;
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
 /// <param name = "strCommentId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strCommentId)
{
CheckPrimaryKey(strCommentId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysCommentDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("SysComment", "CommentId = " + "'"+ strCommentId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsSysCommentDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysCommentDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("SysComment", strCondition))
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
objSQL = clsSysCommentDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("SysComment");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsSysCommentEN objSysCommentEN)
 {
 if (objSysCommentEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSysCommentEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysCommentDA.GetSpecSQLObj();
strSQL = "Select * from SysComment where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "SysComment");
objRow = objDS.Tables["SysComment"].NewRow();
objRow[conSysComment.CommentId] = objSysCommentEN.CommentId; //评论Id
 if (objSysCommentEN.Comment !=  "")
 {
objRow[conSysComment.Comment] = objSysCommentEN.Comment; //评论
 }
objRow[conSysComment.Score] = objSysCommentEN.Score; //评分
objRow[conSysComment.CommentTypeId] = objSysCommentEN.CommentTypeId; //评论类型Id
 if (objSysCommentEN.ScoreType !=  "")
 {
objRow[conSysComment.ScoreType] = objSysCommentEN.ScoreType; //评分类型
 }
objRow[conSysComment.ParentId] = objSysCommentEN.ParentId; //父Id
 if (objSysCommentEN.TableKey !=  "")
 {
objRow[conSysComment.TableKey] = objSysCommentEN.TableKey; //表主键
 }
objRow[conSysComment.OkCount] = objSysCommentEN.OkCount; //点赞统计
 if (objSysCommentEN.PubParentId !=  "")
 {
objRow[conSysComment.PubParentId] = objSysCommentEN.PubParentId; //公共父Id
 }
 if (objSysCommentEN.IdCurrEduCls !=  "")
 {
objRow[conSysComment.IdCurrEduCls] = objSysCommentEN.IdCurrEduCls; //教学班流水号
 }
 if (objSysCommentEN.UserId !=  "")
 {
objRow[conSysComment.UserId] = objSysCommentEN.UserId; //用户ID
 }
objRow[conSysComment.Month] = objSysCommentEN.Month; //月
objRow[conSysComment.Week] = objSysCommentEN.Week; //周
 if (objSysCommentEN.WeekTimeRange !=  "")
 {
objRow[conSysComment.WeekTimeRange] = objSysCommentEN.WeekTimeRange; //WeekTimeRange
 }
 if (objSysCommentEN.UpdUser !=  "")
 {
objRow[conSysComment.UpdUser] = objSysCommentEN.UpdUser; //修改人
 }
 if (objSysCommentEN.UpdDate !=  "")
 {
objRow[conSysComment.UpdDate] = objSysCommentEN.UpdDate; //修改日期
 }
 if (objSysCommentEN.Memo !=  "")
 {
objRow[conSysComment.Memo] = objSysCommentEN.Memo; //备注
 }
objDS.Tables[clsSysCommentEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsSysCommentEN._CurrTabName);
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
 /// <param name = "objSysCommentEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsSysCommentEN objSysCommentEN)
{
 if (objSysCommentEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSysCommentEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objSysCommentEN.CommentId !=  null)
 {
 arrFieldListForInsert.Add(conSysComment.CommentId);
 var strCommentId = objSysCommentEN.CommentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCommentId + "'");
 }
 
 if (objSysCommentEN.Comment !=  null)
 {
 arrFieldListForInsert.Add(conSysComment.Comment);
 var strComment = objSysCommentEN.Comment.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strComment + "'");
 }
 
 if (objSysCommentEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conSysComment.Score);
 arrValueListForInsert.Add(objSysCommentEN.Score.ToString());
 }
 
 if (objSysCommentEN.CommentTypeId !=  null)
 {
 arrFieldListForInsert.Add(conSysComment.CommentTypeId);
 var strCommentTypeId = objSysCommentEN.CommentTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCommentTypeId + "'");
 }
 
 if (objSysCommentEN.ScoreType !=  null)
 {
 arrFieldListForInsert.Add(conSysComment.ScoreType);
 var strScoreType = objSysCommentEN.ScoreType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strScoreType + "'");
 }
 
 if (objSysCommentEN.ParentId !=  null)
 {
 arrFieldListForInsert.Add(conSysComment.ParentId);
 var strParentId = objSysCommentEN.ParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParentId + "'");
 }
 
 if (objSysCommentEN.TableKey !=  null)
 {
 arrFieldListForInsert.Add(conSysComment.TableKey);
 var strTableKey = objSysCommentEN.TableKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTableKey + "'");
 }
 
 if (objSysCommentEN.OkCount !=  null)
 {
 arrFieldListForInsert.Add(conSysComment.OkCount);
 arrValueListForInsert.Add(objSysCommentEN.OkCount.ToString());
 }
 
 if (objSysCommentEN.PubParentId !=  null)
 {
 arrFieldListForInsert.Add(conSysComment.PubParentId);
 var strPubParentId = objSysCommentEN.PubParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubParentId + "'");
 }
 
 if (objSysCommentEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conSysComment.IdCurrEduCls);
 var strIdCurrEduCls = objSysCommentEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objSysCommentEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conSysComment.UserId);
 var strUserId = objSysCommentEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objSysCommentEN.Month !=  null)
 {
 arrFieldListForInsert.Add(conSysComment.Month);
 arrValueListForInsert.Add(objSysCommentEN.Month.ToString());
 }
 
 if (objSysCommentEN.Week !=  null)
 {
 arrFieldListForInsert.Add(conSysComment.Week);
 arrValueListForInsert.Add(objSysCommentEN.Week.ToString());
 }
 
 if (objSysCommentEN.WeekTimeRange !=  null)
 {
 arrFieldListForInsert.Add(conSysComment.WeekTimeRange);
 var strWeekTimeRange = objSysCommentEN.WeekTimeRange.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWeekTimeRange + "'");
 }
 
 if (objSysCommentEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conSysComment.UpdUser);
 var strUpdUser = objSysCommentEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objSysCommentEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conSysComment.UpdDate);
 var strUpdDate = objSysCommentEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objSysCommentEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conSysComment.Memo);
 var strMemo = objSysCommentEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SysComment");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysCommentDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objSysCommentEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsSysCommentEN objSysCommentEN)
{
 if (objSysCommentEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSysCommentEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objSysCommentEN.CommentId !=  null)
 {
 arrFieldListForInsert.Add(conSysComment.CommentId);
 var strCommentId = objSysCommentEN.CommentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCommentId + "'");
 }
 
 if (objSysCommentEN.Comment !=  null)
 {
 arrFieldListForInsert.Add(conSysComment.Comment);
 var strComment = objSysCommentEN.Comment.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strComment + "'");
 }
 
 if (objSysCommentEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conSysComment.Score);
 arrValueListForInsert.Add(objSysCommentEN.Score.ToString());
 }
 
 if (objSysCommentEN.CommentTypeId !=  null)
 {
 arrFieldListForInsert.Add(conSysComment.CommentTypeId);
 var strCommentTypeId = objSysCommentEN.CommentTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCommentTypeId + "'");
 }
 
 if (objSysCommentEN.ScoreType !=  null)
 {
 arrFieldListForInsert.Add(conSysComment.ScoreType);
 var strScoreType = objSysCommentEN.ScoreType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strScoreType + "'");
 }
 
 if (objSysCommentEN.ParentId !=  null)
 {
 arrFieldListForInsert.Add(conSysComment.ParentId);
 var strParentId = objSysCommentEN.ParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParentId + "'");
 }
 
 if (objSysCommentEN.TableKey !=  null)
 {
 arrFieldListForInsert.Add(conSysComment.TableKey);
 var strTableKey = objSysCommentEN.TableKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTableKey + "'");
 }
 
 if (objSysCommentEN.OkCount !=  null)
 {
 arrFieldListForInsert.Add(conSysComment.OkCount);
 arrValueListForInsert.Add(objSysCommentEN.OkCount.ToString());
 }
 
 if (objSysCommentEN.PubParentId !=  null)
 {
 arrFieldListForInsert.Add(conSysComment.PubParentId);
 var strPubParentId = objSysCommentEN.PubParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubParentId + "'");
 }
 
 if (objSysCommentEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conSysComment.IdCurrEduCls);
 var strIdCurrEduCls = objSysCommentEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objSysCommentEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conSysComment.UserId);
 var strUserId = objSysCommentEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objSysCommentEN.Month !=  null)
 {
 arrFieldListForInsert.Add(conSysComment.Month);
 arrValueListForInsert.Add(objSysCommentEN.Month.ToString());
 }
 
 if (objSysCommentEN.Week !=  null)
 {
 arrFieldListForInsert.Add(conSysComment.Week);
 arrValueListForInsert.Add(objSysCommentEN.Week.ToString());
 }
 
 if (objSysCommentEN.WeekTimeRange !=  null)
 {
 arrFieldListForInsert.Add(conSysComment.WeekTimeRange);
 var strWeekTimeRange = objSysCommentEN.WeekTimeRange.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWeekTimeRange + "'");
 }
 
 if (objSysCommentEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conSysComment.UpdUser);
 var strUpdUser = objSysCommentEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objSysCommentEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conSysComment.UpdDate);
 var strUpdDate = objSysCommentEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objSysCommentEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conSysComment.Memo);
 var strMemo = objSysCommentEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SysComment");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysCommentDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objSysCommentEN.CommentId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objSysCommentEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsSysCommentEN objSysCommentEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objSysCommentEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSysCommentEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objSysCommentEN.CommentId !=  null)
 {
 arrFieldListForInsert.Add(conSysComment.CommentId);
 var strCommentId = objSysCommentEN.CommentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCommentId + "'");
 }
 
 if (objSysCommentEN.Comment !=  null)
 {
 arrFieldListForInsert.Add(conSysComment.Comment);
 var strComment = objSysCommentEN.Comment.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strComment + "'");
 }
 
 if (objSysCommentEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conSysComment.Score);
 arrValueListForInsert.Add(objSysCommentEN.Score.ToString());
 }
 
 if (objSysCommentEN.CommentTypeId !=  null)
 {
 arrFieldListForInsert.Add(conSysComment.CommentTypeId);
 var strCommentTypeId = objSysCommentEN.CommentTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCommentTypeId + "'");
 }
 
 if (objSysCommentEN.ScoreType !=  null)
 {
 arrFieldListForInsert.Add(conSysComment.ScoreType);
 var strScoreType = objSysCommentEN.ScoreType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strScoreType + "'");
 }
 
 if (objSysCommentEN.ParentId !=  null)
 {
 arrFieldListForInsert.Add(conSysComment.ParentId);
 var strParentId = objSysCommentEN.ParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParentId + "'");
 }
 
 if (objSysCommentEN.TableKey !=  null)
 {
 arrFieldListForInsert.Add(conSysComment.TableKey);
 var strTableKey = objSysCommentEN.TableKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTableKey + "'");
 }
 
 if (objSysCommentEN.OkCount !=  null)
 {
 arrFieldListForInsert.Add(conSysComment.OkCount);
 arrValueListForInsert.Add(objSysCommentEN.OkCount.ToString());
 }
 
 if (objSysCommentEN.PubParentId !=  null)
 {
 arrFieldListForInsert.Add(conSysComment.PubParentId);
 var strPubParentId = objSysCommentEN.PubParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubParentId + "'");
 }
 
 if (objSysCommentEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conSysComment.IdCurrEduCls);
 var strIdCurrEduCls = objSysCommentEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objSysCommentEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conSysComment.UserId);
 var strUserId = objSysCommentEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objSysCommentEN.Month !=  null)
 {
 arrFieldListForInsert.Add(conSysComment.Month);
 arrValueListForInsert.Add(objSysCommentEN.Month.ToString());
 }
 
 if (objSysCommentEN.Week !=  null)
 {
 arrFieldListForInsert.Add(conSysComment.Week);
 arrValueListForInsert.Add(objSysCommentEN.Week.ToString());
 }
 
 if (objSysCommentEN.WeekTimeRange !=  null)
 {
 arrFieldListForInsert.Add(conSysComment.WeekTimeRange);
 var strWeekTimeRange = objSysCommentEN.WeekTimeRange.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWeekTimeRange + "'");
 }
 
 if (objSysCommentEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conSysComment.UpdUser);
 var strUpdUser = objSysCommentEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objSysCommentEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conSysComment.UpdDate);
 var strUpdDate = objSysCommentEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objSysCommentEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conSysComment.Memo);
 var strMemo = objSysCommentEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SysComment");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysCommentDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objSysCommentEN.CommentId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objSysCommentEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsSysCommentEN objSysCommentEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objSysCommentEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSysCommentEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objSysCommentEN.CommentId !=  null)
 {
 arrFieldListForInsert.Add(conSysComment.CommentId);
 var strCommentId = objSysCommentEN.CommentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCommentId + "'");
 }
 
 if (objSysCommentEN.Comment !=  null)
 {
 arrFieldListForInsert.Add(conSysComment.Comment);
 var strComment = objSysCommentEN.Comment.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strComment + "'");
 }
 
 if (objSysCommentEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conSysComment.Score);
 arrValueListForInsert.Add(objSysCommentEN.Score.ToString());
 }
 
 if (objSysCommentEN.CommentTypeId !=  null)
 {
 arrFieldListForInsert.Add(conSysComment.CommentTypeId);
 var strCommentTypeId = objSysCommentEN.CommentTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCommentTypeId + "'");
 }
 
 if (objSysCommentEN.ScoreType !=  null)
 {
 arrFieldListForInsert.Add(conSysComment.ScoreType);
 var strScoreType = objSysCommentEN.ScoreType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strScoreType + "'");
 }
 
 if (objSysCommentEN.ParentId !=  null)
 {
 arrFieldListForInsert.Add(conSysComment.ParentId);
 var strParentId = objSysCommentEN.ParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParentId + "'");
 }
 
 if (objSysCommentEN.TableKey !=  null)
 {
 arrFieldListForInsert.Add(conSysComment.TableKey);
 var strTableKey = objSysCommentEN.TableKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTableKey + "'");
 }
 
 if (objSysCommentEN.OkCount !=  null)
 {
 arrFieldListForInsert.Add(conSysComment.OkCount);
 arrValueListForInsert.Add(objSysCommentEN.OkCount.ToString());
 }
 
 if (objSysCommentEN.PubParentId !=  null)
 {
 arrFieldListForInsert.Add(conSysComment.PubParentId);
 var strPubParentId = objSysCommentEN.PubParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubParentId + "'");
 }
 
 if (objSysCommentEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conSysComment.IdCurrEduCls);
 var strIdCurrEduCls = objSysCommentEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objSysCommentEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conSysComment.UserId);
 var strUserId = objSysCommentEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objSysCommentEN.Month !=  null)
 {
 arrFieldListForInsert.Add(conSysComment.Month);
 arrValueListForInsert.Add(objSysCommentEN.Month.ToString());
 }
 
 if (objSysCommentEN.Week !=  null)
 {
 arrFieldListForInsert.Add(conSysComment.Week);
 arrValueListForInsert.Add(objSysCommentEN.Week.ToString());
 }
 
 if (objSysCommentEN.WeekTimeRange !=  null)
 {
 arrFieldListForInsert.Add(conSysComment.WeekTimeRange);
 var strWeekTimeRange = objSysCommentEN.WeekTimeRange.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWeekTimeRange + "'");
 }
 
 if (objSysCommentEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conSysComment.UpdUser);
 var strUpdUser = objSysCommentEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objSysCommentEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conSysComment.UpdDate);
 var strUpdDate = objSysCommentEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objSysCommentEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conSysComment.Memo);
 var strMemo = objSysCommentEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SysComment");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysCommentDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewSysComments(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysCommentDA.GetSpecSQLObj();
strSQL = "Select * from SysComment where CommentId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "SysComment");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strCommentId = oRow[conSysComment.CommentId].ToString().Trim();
if (IsExist(strCommentId))
{
 string strResult = "关键字变量值为:" + string.Format("CommentId = {0}", strCommentId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsSysCommentEN._CurrTabName ].NewRow();
objRow[conSysComment.CommentId] = oRow[conSysComment.CommentId].ToString().Trim(); //评论Id
objRow[conSysComment.Comment] = oRow[conSysComment.Comment].ToString().Trim(); //评论
objRow[conSysComment.Score] = oRow[conSysComment.Score].ToString().Trim(); //评分
objRow[conSysComment.CommentTypeId] = oRow[conSysComment.CommentTypeId].ToString().Trim(); //评论类型Id
objRow[conSysComment.ScoreType] = oRow[conSysComment.ScoreType].ToString().Trim(); //评分类型
objRow[conSysComment.ParentId] = oRow[conSysComment.ParentId].ToString().Trim(); //父Id
objRow[conSysComment.TableKey] = oRow[conSysComment.TableKey].ToString().Trim(); //表主键
objRow[conSysComment.OkCount] = oRow[conSysComment.OkCount].ToString().Trim(); //点赞统计
objRow[conSysComment.PubParentId] = oRow[conSysComment.PubParentId].ToString().Trim(); //公共父Id
objRow[conSysComment.IdCurrEduCls] = oRow[conSysComment.IdCurrEduCls].ToString().Trim(); //教学班流水号
objRow[conSysComment.UserId] = oRow[conSysComment.UserId].ToString().Trim(); //用户ID
objRow[conSysComment.Month] = oRow[conSysComment.Month].ToString().Trim(); //月
objRow[conSysComment.Week] = oRow[conSysComment.Week].ToString().Trim(); //周
objRow[conSysComment.WeekTimeRange] = oRow[conSysComment.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objRow[conSysComment.UpdUser] = oRow[conSysComment.UpdUser].ToString().Trim(); //修改人
objRow[conSysComment.UpdDate] = oRow[conSysComment.UpdDate].ToString().Trim(); //修改日期
objRow[conSysComment.Memo] = oRow[conSysComment.Memo].ToString().Trim(); //备注
 objDS.Tables[clsSysCommentEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsSysCommentEN._CurrTabName);
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
 /// <param name = "objSysCommentEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsSysCommentEN objSysCommentEN)
{
 if (objSysCommentEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSysCommentEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysCommentDA.GetSpecSQLObj();
strSQL = "Select * from SysComment where CommentId = " + "'"+ objSysCommentEN.CommentId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsSysCommentEN._CurrTabName);
if (objDS.Tables[clsSysCommentEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:CommentId = " + "'"+ objSysCommentEN.CommentId+"'");
return false;
}
objRow = objDS.Tables[clsSysCommentEN._CurrTabName].Rows[0];
 if (objSysCommentEN.IsUpdated(conSysComment.CommentId))
 {
objRow[conSysComment.CommentId] = objSysCommentEN.CommentId; //评论Id
 }
 if (objSysCommentEN.IsUpdated(conSysComment.Comment))
 {
objRow[conSysComment.Comment] = objSysCommentEN.Comment; //评论
 }
 if (objSysCommentEN.IsUpdated(conSysComment.Score))
 {
objRow[conSysComment.Score] = objSysCommentEN.Score; //评分
 }
 if (objSysCommentEN.IsUpdated(conSysComment.CommentTypeId))
 {
objRow[conSysComment.CommentTypeId] = objSysCommentEN.CommentTypeId; //评论类型Id
 }
 if (objSysCommentEN.IsUpdated(conSysComment.ScoreType))
 {
objRow[conSysComment.ScoreType] = objSysCommentEN.ScoreType; //评分类型
 }
 if (objSysCommentEN.IsUpdated(conSysComment.ParentId))
 {
objRow[conSysComment.ParentId] = objSysCommentEN.ParentId; //父Id
 }
 if (objSysCommentEN.IsUpdated(conSysComment.TableKey))
 {
objRow[conSysComment.TableKey] = objSysCommentEN.TableKey; //表主键
 }
 if (objSysCommentEN.IsUpdated(conSysComment.OkCount))
 {
objRow[conSysComment.OkCount] = objSysCommentEN.OkCount; //点赞统计
 }
 if (objSysCommentEN.IsUpdated(conSysComment.PubParentId))
 {
objRow[conSysComment.PubParentId] = objSysCommentEN.PubParentId; //公共父Id
 }
 if (objSysCommentEN.IsUpdated(conSysComment.IdCurrEduCls))
 {
objRow[conSysComment.IdCurrEduCls] = objSysCommentEN.IdCurrEduCls; //教学班流水号
 }
 if (objSysCommentEN.IsUpdated(conSysComment.UserId))
 {
objRow[conSysComment.UserId] = objSysCommentEN.UserId; //用户ID
 }
 if (objSysCommentEN.IsUpdated(conSysComment.Month))
 {
objRow[conSysComment.Month] = objSysCommentEN.Month; //月
 }
 if (objSysCommentEN.IsUpdated(conSysComment.Week))
 {
objRow[conSysComment.Week] = objSysCommentEN.Week; //周
 }
 if (objSysCommentEN.IsUpdated(conSysComment.WeekTimeRange))
 {
objRow[conSysComment.WeekTimeRange] = objSysCommentEN.WeekTimeRange; //WeekTimeRange
 }
 if (objSysCommentEN.IsUpdated(conSysComment.UpdUser))
 {
objRow[conSysComment.UpdUser] = objSysCommentEN.UpdUser; //修改人
 }
 if (objSysCommentEN.IsUpdated(conSysComment.UpdDate))
 {
objRow[conSysComment.UpdDate] = objSysCommentEN.UpdDate; //修改日期
 }
 if (objSysCommentEN.IsUpdated(conSysComment.Memo))
 {
objRow[conSysComment.Memo] = objSysCommentEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsSysCommentEN._CurrTabName);
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
 /// <param name = "objSysCommentEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsSysCommentEN objSysCommentEN)
{
 if (objSysCommentEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSysCommentEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysCommentDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update SysComment Set ");
 
 if (objSysCommentEN.IsUpdated(conSysComment.Comment))
 {
 if (objSysCommentEN.Comment !=  null)
 {
 var strComment = objSysCommentEN.Comment.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strComment, conSysComment.Comment); //评论
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysComment.Comment); //评论
 }
 }
 
 if (objSysCommentEN.IsUpdated(conSysComment.Score))
 {
 if (objSysCommentEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysCommentEN.Score, conSysComment.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysComment.Score); //评分
 }
 }
 
 if (objSysCommentEN.IsUpdated(conSysComment.CommentTypeId))
 {
 if (objSysCommentEN.CommentTypeId !=  null)
 {
 var strCommentTypeId = objSysCommentEN.CommentTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCommentTypeId, conSysComment.CommentTypeId); //评论类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysComment.CommentTypeId); //评论类型Id
 }
 }
 
 if (objSysCommentEN.IsUpdated(conSysComment.ScoreType))
 {
 if (objSysCommentEN.ScoreType !=  null)
 {
 var strScoreType = objSysCommentEN.ScoreType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strScoreType, conSysComment.ScoreType); //评分类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysComment.ScoreType); //评分类型
 }
 }
 
 if (objSysCommentEN.IsUpdated(conSysComment.ParentId))
 {
 if (objSysCommentEN.ParentId !=  null)
 {
 var strParentId = objSysCommentEN.ParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParentId, conSysComment.ParentId); //父Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysComment.ParentId); //父Id
 }
 }
 
 if (objSysCommentEN.IsUpdated(conSysComment.TableKey))
 {
 if (objSysCommentEN.TableKey !=  null)
 {
 var strTableKey = objSysCommentEN.TableKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTableKey, conSysComment.TableKey); //表主键
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysComment.TableKey); //表主键
 }
 }
 
 if (objSysCommentEN.IsUpdated(conSysComment.OkCount))
 {
 if (objSysCommentEN.OkCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysCommentEN.OkCount, conSysComment.OkCount); //点赞统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysComment.OkCount); //点赞统计
 }
 }
 
 if (objSysCommentEN.IsUpdated(conSysComment.PubParentId))
 {
 if (objSysCommentEN.PubParentId !=  null)
 {
 var strPubParentId = objSysCommentEN.PubParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPubParentId, conSysComment.PubParentId); //公共父Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysComment.PubParentId); //公共父Id
 }
 }
 
 if (objSysCommentEN.IsUpdated(conSysComment.IdCurrEduCls))
 {
 if (objSysCommentEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objSysCommentEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conSysComment.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysComment.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objSysCommentEN.IsUpdated(conSysComment.UserId))
 {
 if (objSysCommentEN.UserId !=  null)
 {
 var strUserId = objSysCommentEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conSysComment.UserId); //用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysComment.UserId); //用户ID
 }
 }
 
 if (objSysCommentEN.IsUpdated(conSysComment.Month))
 {
 if (objSysCommentEN.Month !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysCommentEN.Month, conSysComment.Month); //月
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysComment.Month); //月
 }
 }
 
 if (objSysCommentEN.IsUpdated(conSysComment.Week))
 {
 if (objSysCommentEN.Week !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysCommentEN.Week, conSysComment.Week); //周
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysComment.Week); //周
 }
 }
 
 if (objSysCommentEN.IsUpdated(conSysComment.WeekTimeRange))
 {
 if (objSysCommentEN.WeekTimeRange !=  null)
 {
 var strWeekTimeRange = objSysCommentEN.WeekTimeRange.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWeekTimeRange, conSysComment.WeekTimeRange); //WeekTimeRange
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysComment.WeekTimeRange); //WeekTimeRange
 }
 }
 
 if (objSysCommentEN.IsUpdated(conSysComment.UpdUser))
 {
 if (objSysCommentEN.UpdUser !=  null)
 {
 var strUpdUser = objSysCommentEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conSysComment.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysComment.UpdUser); //修改人
 }
 }
 
 if (objSysCommentEN.IsUpdated(conSysComment.UpdDate))
 {
 if (objSysCommentEN.UpdDate !=  null)
 {
 var strUpdDate = objSysCommentEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conSysComment.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysComment.UpdDate); //修改日期
 }
 }
 
 if (objSysCommentEN.IsUpdated(conSysComment.Memo))
 {
 if (objSysCommentEN.Memo !=  null)
 {
 var strMemo = objSysCommentEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conSysComment.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysComment.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where CommentId = '{0}'", objSysCommentEN.CommentId); 
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
 /// <param name = "objSysCommentEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsSysCommentEN objSysCommentEN, string strCondition)
{
 if (objSysCommentEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSysCommentEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysCommentDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update SysComment Set ");
 
 if (objSysCommentEN.IsUpdated(conSysComment.Comment))
 {
 if (objSysCommentEN.Comment !=  null)
 {
 var strComment = objSysCommentEN.Comment.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Comment = '{0}',", strComment); //评论
 }
 else
 {
 sbSQL.Append(" Comment = null,"); //评论
 }
 }
 
 if (objSysCommentEN.IsUpdated(conSysComment.Score))
 {
 if (objSysCommentEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysCommentEN.Score, conSysComment.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysComment.Score); //评分
 }
 }
 
 if (objSysCommentEN.IsUpdated(conSysComment.CommentTypeId))
 {
 if (objSysCommentEN.CommentTypeId !=  null)
 {
 var strCommentTypeId = objSysCommentEN.CommentTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CommentTypeId = '{0}',", strCommentTypeId); //评论类型Id
 }
 else
 {
 sbSQL.Append(" CommentTypeId = null,"); //评论类型Id
 }
 }
 
 if (objSysCommentEN.IsUpdated(conSysComment.ScoreType))
 {
 if (objSysCommentEN.ScoreType !=  null)
 {
 var strScoreType = objSysCommentEN.ScoreType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ScoreType = '{0}',", strScoreType); //评分类型
 }
 else
 {
 sbSQL.Append(" ScoreType = null,"); //评分类型
 }
 }
 
 if (objSysCommentEN.IsUpdated(conSysComment.ParentId))
 {
 if (objSysCommentEN.ParentId !=  null)
 {
 var strParentId = objSysCommentEN.ParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParentId = '{0}',", strParentId); //父Id
 }
 else
 {
 sbSQL.Append(" ParentId = null,"); //父Id
 }
 }
 
 if (objSysCommentEN.IsUpdated(conSysComment.TableKey))
 {
 if (objSysCommentEN.TableKey !=  null)
 {
 var strTableKey = objSysCommentEN.TableKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TableKey = '{0}',", strTableKey); //表主键
 }
 else
 {
 sbSQL.Append(" TableKey = null,"); //表主键
 }
 }
 
 if (objSysCommentEN.IsUpdated(conSysComment.OkCount))
 {
 if (objSysCommentEN.OkCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysCommentEN.OkCount, conSysComment.OkCount); //点赞统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysComment.OkCount); //点赞统计
 }
 }
 
 if (objSysCommentEN.IsUpdated(conSysComment.PubParentId))
 {
 if (objSysCommentEN.PubParentId !=  null)
 {
 var strPubParentId = objSysCommentEN.PubParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PubParentId = '{0}',", strPubParentId); //公共父Id
 }
 else
 {
 sbSQL.Append(" PubParentId = null,"); //公共父Id
 }
 }
 
 if (objSysCommentEN.IsUpdated(conSysComment.IdCurrEduCls))
 {
 if (objSysCommentEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objSysCommentEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objSysCommentEN.IsUpdated(conSysComment.UserId))
 {
 if (objSysCommentEN.UserId !=  null)
 {
 var strUserId = objSysCommentEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户ID
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户ID
 }
 }
 
 if (objSysCommentEN.IsUpdated(conSysComment.Month))
 {
 if (objSysCommentEN.Month !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysCommentEN.Month, conSysComment.Month); //月
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysComment.Month); //月
 }
 }
 
 if (objSysCommentEN.IsUpdated(conSysComment.Week))
 {
 if (objSysCommentEN.Week !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysCommentEN.Week, conSysComment.Week); //周
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysComment.Week); //周
 }
 }
 
 if (objSysCommentEN.IsUpdated(conSysComment.WeekTimeRange))
 {
 if (objSysCommentEN.WeekTimeRange !=  null)
 {
 var strWeekTimeRange = objSysCommentEN.WeekTimeRange.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WeekTimeRange = '{0}',", strWeekTimeRange); //WeekTimeRange
 }
 else
 {
 sbSQL.Append(" WeekTimeRange = null,"); //WeekTimeRange
 }
 }
 
 if (objSysCommentEN.IsUpdated(conSysComment.UpdUser))
 {
 if (objSysCommentEN.UpdUser !=  null)
 {
 var strUpdUser = objSysCommentEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objSysCommentEN.IsUpdated(conSysComment.UpdDate))
 {
 if (objSysCommentEN.UpdDate !=  null)
 {
 var strUpdDate = objSysCommentEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objSysCommentEN.IsUpdated(conSysComment.Memo))
 {
 if (objSysCommentEN.Memo !=  null)
 {
 var strMemo = objSysCommentEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objSysCommentEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsSysCommentEN objSysCommentEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objSysCommentEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSysCommentEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysCommentDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update SysComment Set ");
 
 if (objSysCommentEN.IsUpdated(conSysComment.Comment))
 {
 if (objSysCommentEN.Comment !=  null)
 {
 var strComment = objSysCommentEN.Comment.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Comment = '{0}',", strComment); //评论
 }
 else
 {
 sbSQL.Append(" Comment = null,"); //评论
 }
 }
 
 if (objSysCommentEN.IsUpdated(conSysComment.Score))
 {
 if (objSysCommentEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysCommentEN.Score, conSysComment.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysComment.Score); //评分
 }
 }
 
 if (objSysCommentEN.IsUpdated(conSysComment.CommentTypeId))
 {
 if (objSysCommentEN.CommentTypeId !=  null)
 {
 var strCommentTypeId = objSysCommentEN.CommentTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CommentTypeId = '{0}',", strCommentTypeId); //评论类型Id
 }
 else
 {
 sbSQL.Append(" CommentTypeId = null,"); //评论类型Id
 }
 }
 
 if (objSysCommentEN.IsUpdated(conSysComment.ScoreType))
 {
 if (objSysCommentEN.ScoreType !=  null)
 {
 var strScoreType = objSysCommentEN.ScoreType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ScoreType = '{0}',", strScoreType); //评分类型
 }
 else
 {
 sbSQL.Append(" ScoreType = null,"); //评分类型
 }
 }
 
 if (objSysCommentEN.IsUpdated(conSysComment.ParentId))
 {
 if (objSysCommentEN.ParentId !=  null)
 {
 var strParentId = objSysCommentEN.ParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParentId = '{0}',", strParentId); //父Id
 }
 else
 {
 sbSQL.Append(" ParentId = null,"); //父Id
 }
 }
 
 if (objSysCommentEN.IsUpdated(conSysComment.TableKey))
 {
 if (objSysCommentEN.TableKey !=  null)
 {
 var strTableKey = objSysCommentEN.TableKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TableKey = '{0}',", strTableKey); //表主键
 }
 else
 {
 sbSQL.Append(" TableKey = null,"); //表主键
 }
 }
 
 if (objSysCommentEN.IsUpdated(conSysComment.OkCount))
 {
 if (objSysCommentEN.OkCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysCommentEN.OkCount, conSysComment.OkCount); //点赞统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysComment.OkCount); //点赞统计
 }
 }
 
 if (objSysCommentEN.IsUpdated(conSysComment.PubParentId))
 {
 if (objSysCommentEN.PubParentId !=  null)
 {
 var strPubParentId = objSysCommentEN.PubParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PubParentId = '{0}',", strPubParentId); //公共父Id
 }
 else
 {
 sbSQL.Append(" PubParentId = null,"); //公共父Id
 }
 }
 
 if (objSysCommentEN.IsUpdated(conSysComment.IdCurrEduCls))
 {
 if (objSysCommentEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objSysCommentEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objSysCommentEN.IsUpdated(conSysComment.UserId))
 {
 if (objSysCommentEN.UserId !=  null)
 {
 var strUserId = objSysCommentEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户ID
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户ID
 }
 }
 
 if (objSysCommentEN.IsUpdated(conSysComment.Month))
 {
 if (objSysCommentEN.Month !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysCommentEN.Month, conSysComment.Month); //月
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysComment.Month); //月
 }
 }
 
 if (objSysCommentEN.IsUpdated(conSysComment.Week))
 {
 if (objSysCommentEN.Week !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysCommentEN.Week, conSysComment.Week); //周
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysComment.Week); //周
 }
 }
 
 if (objSysCommentEN.IsUpdated(conSysComment.WeekTimeRange))
 {
 if (objSysCommentEN.WeekTimeRange !=  null)
 {
 var strWeekTimeRange = objSysCommentEN.WeekTimeRange.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WeekTimeRange = '{0}',", strWeekTimeRange); //WeekTimeRange
 }
 else
 {
 sbSQL.Append(" WeekTimeRange = null,"); //WeekTimeRange
 }
 }
 
 if (objSysCommentEN.IsUpdated(conSysComment.UpdUser))
 {
 if (objSysCommentEN.UpdUser !=  null)
 {
 var strUpdUser = objSysCommentEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objSysCommentEN.IsUpdated(conSysComment.UpdDate))
 {
 if (objSysCommentEN.UpdDate !=  null)
 {
 var strUpdDate = objSysCommentEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objSysCommentEN.IsUpdated(conSysComment.Memo))
 {
 if (objSysCommentEN.Memo !=  null)
 {
 var strMemo = objSysCommentEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objSysCommentEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsSysCommentEN objSysCommentEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objSysCommentEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSysCommentEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysCommentDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update SysComment Set ");
 
 if (objSysCommentEN.IsUpdated(conSysComment.Comment))
 {
 if (objSysCommentEN.Comment !=  null)
 {
 var strComment = objSysCommentEN.Comment.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strComment, conSysComment.Comment); //评论
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysComment.Comment); //评论
 }
 }
 
 if (objSysCommentEN.IsUpdated(conSysComment.Score))
 {
 if (objSysCommentEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysCommentEN.Score, conSysComment.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysComment.Score); //评分
 }
 }
 
 if (objSysCommentEN.IsUpdated(conSysComment.CommentTypeId))
 {
 if (objSysCommentEN.CommentTypeId !=  null)
 {
 var strCommentTypeId = objSysCommentEN.CommentTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCommentTypeId, conSysComment.CommentTypeId); //评论类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysComment.CommentTypeId); //评论类型Id
 }
 }
 
 if (objSysCommentEN.IsUpdated(conSysComment.ScoreType))
 {
 if (objSysCommentEN.ScoreType !=  null)
 {
 var strScoreType = objSysCommentEN.ScoreType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strScoreType, conSysComment.ScoreType); //评分类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysComment.ScoreType); //评分类型
 }
 }
 
 if (objSysCommentEN.IsUpdated(conSysComment.ParentId))
 {
 if (objSysCommentEN.ParentId !=  null)
 {
 var strParentId = objSysCommentEN.ParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParentId, conSysComment.ParentId); //父Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysComment.ParentId); //父Id
 }
 }
 
 if (objSysCommentEN.IsUpdated(conSysComment.TableKey))
 {
 if (objSysCommentEN.TableKey !=  null)
 {
 var strTableKey = objSysCommentEN.TableKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTableKey, conSysComment.TableKey); //表主键
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysComment.TableKey); //表主键
 }
 }
 
 if (objSysCommentEN.IsUpdated(conSysComment.OkCount))
 {
 if (objSysCommentEN.OkCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysCommentEN.OkCount, conSysComment.OkCount); //点赞统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysComment.OkCount); //点赞统计
 }
 }
 
 if (objSysCommentEN.IsUpdated(conSysComment.PubParentId))
 {
 if (objSysCommentEN.PubParentId !=  null)
 {
 var strPubParentId = objSysCommentEN.PubParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPubParentId, conSysComment.PubParentId); //公共父Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysComment.PubParentId); //公共父Id
 }
 }
 
 if (objSysCommentEN.IsUpdated(conSysComment.IdCurrEduCls))
 {
 if (objSysCommentEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objSysCommentEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conSysComment.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysComment.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objSysCommentEN.IsUpdated(conSysComment.UserId))
 {
 if (objSysCommentEN.UserId !=  null)
 {
 var strUserId = objSysCommentEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conSysComment.UserId); //用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysComment.UserId); //用户ID
 }
 }
 
 if (objSysCommentEN.IsUpdated(conSysComment.Month))
 {
 if (objSysCommentEN.Month !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysCommentEN.Month, conSysComment.Month); //月
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysComment.Month); //月
 }
 }
 
 if (objSysCommentEN.IsUpdated(conSysComment.Week))
 {
 if (objSysCommentEN.Week !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysCommentEN.Week, conSysComment.Week); //周
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysComment.Week); //周
 }
 }
 
 if (objSysCommentEN.IsUpdated(conSysComment.WeekTimeRange))
 {
 if (objSysCommentEN.WeekTimeRange !=  null)
 {
 var strWeekTimeRange = objSysCommentEN.WeekTimeRange.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWeekTimeRange, conSysComment.WeekTimeRange); //WeekTimeRange
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysComment.WeekTimeRange); //WeekTimeRange
 }
 }
 
 if (objSysCommentEN.IsUpdated(conSysComment.UpdUser))
 {
 if (objSysCommentEN.UpdUser !=  null)
 {
 var strUpdUser = objSysCommentEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conSysComment.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysComment.UpdUser); //修改人
 }
 }
 
 if (objSysCommentEN.IsUpdated(conSysComment.UpdDate))
 {
 if (objSysCommentEN.UpdDate !=  null)
 {
 var strUpdDate = objSysCommentEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conSysComment.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysComment.UpdDate); //修改日期
 }
 }
 
 if (objSysCommentEN.IsUpdated(conSysComment.Memo))
 {
 if (objSysCommentEN.Memo !=  null)
 {
 var strMemo = objSysCommentEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conSysComment.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysComment.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where CommentId = '{0}'", objSysCommentEN.CommentId); 
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
 /// <param name = "strCommentId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strCommentId) 
{
CheckPrimaryKey(strCommentId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysCommentDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strCommentId,
};
 objSQL.ExecSP("SysComment_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strCommentId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strCommentId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strCommentId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysCommentDA.GetSpecSQLObj();
//删除SysComment本表中与当前对象有关的记录
strSQL = strSQL + "Delete from SysComment where CommentId = " + "'"+ strCommentId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelSysComment(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysCommentDA.GetSpecSQLObj();
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
//删除SysComment本表中与当前对象有关的记录
strSQL = strSQL + "Delete from SysComment where CommentId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strCommentId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strCommentId) 
{
CheckPrimaryKey(strCommentId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysCommentDA.GetSpecSQLObj();
//删除SysComment本表中与当前对象有关的记录
strSQL = strSQL + "Delete from SysComment where CommentId = " + "'"+ strCommentId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelSysComment(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsSysCommentDA: DelSysComment)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysCommentDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from SysComment where " + strCondition ;
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
public bool DelSysCommentWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsSysCommentDA: DelSysCommentWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysCommentDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from SysComment where " + strCondition ;
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
 /// <param name = "objSysCommentENS">源对象</param>
 /// <param name = "objSysCommentENT">目标对象</param>
public void CopyTo(clsSysCommentEN objSysCommentENS, clsSysCommentEN objSysCommentENT)
{
objSysCommentENT.CommentId = objSysCommentENS.CommentId; //评论Id
objSysCommentENT.Comment = objSysCommentENS.Comment; //评论
objSysCommentENT.Score = objSysCommentENS.Score; //评分
objSysCommentENT.CommentTypeId = objSysCommentENS.CommentTypeId; //评论类型Id
objSysCommentENT.ScoreType = objSysCommentENS.ScoreType; //评分类型
objSysCommentENT.ParentId = objSysCommentENS.ParentId; //父Id
objSysCommentENT.TableKey = objSysCommentENS.TableKey; //表主键
objSysCommentENT.OkCount = objSysCommentENS.OkCount; //点赞统计
objSysCommentENT.PubParentId = objSysCommentENS.PubParentId; //公共父Id
objSysCommentENT.IdCurrEduCls = objSysCommentENS.IdCurrEduCls; //教学班流水号
objSysCommentENT.UserId = objSysCommentENS.UserId; //用户ID
objSysCommentENT.Month = objSysCommentENS.Month; //月
objSysCommentENT.Week = objSysCommentENS.Week; //周
objSysCommentENT.WeekTimeRange = objSysCommentENS.WeekTimeRange; //WeekTimeRange
objSysCommentENT.UpdUser = objSysCommentENS.UpdUser; //修改人
objSysCommentENT.UpdDate = objSysCommentENS.UpdDate; //修改日期
objSysCommentENT.Memo = objSysCommentENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsSysCommentEN objSysCommentEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objSysCommentEN.CommentTypeId, conSysComment.CommentTypeId);
clsCheckSql.CheckFieldNotNull(objSysCommentEN.ParentId, conSysComment.ParentId);
//检查字段长度
clsCheckSql.CheckFieldLen(objSysCommentEN.CommentId, 10, conSysComment.CommentId);
clsCheckSql.CheckFieldLen(objSysCommentEN.Comment, 2000, conSysComment.Comment);
clsCheckSql.CheckFieldLen(objSysCommentEN.CommentTypeId, 2, conSysComment.CommentTypeId);
clsCheckSql.CheckFieldLen(objSysCommentEN.ScoreType, 1, conSysComment.ScoreType);
clsCheckSql.CheckFieldLen(objSysCommentEN.ParentId, 20, conSysComment.ParentId);
clsCheckSql.CheckFieldLen(objSysCommentEN.TableKey, 20, conSysComment.TableKey);
clsCheckSql.CheckFieldLen(objSysCommentEN.PubParentId, 20, conSysComment.PubParentId);
clsCheckSql.CheckFieldLen(objSysCommentEN.IdCurrEduCls, 8, conSysComment.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objSysCommentEN.UserId, 18, conSysComment.UserId);
clsCheckSql.CheckFieldLen(objSysCommentEN.WeekTimeRange, 100, conSysComment.WeekTimeRange);
clsCheckSql.CheckFieldLen(objSysCommentEN.UpdUser, 20, conSysComment.UpdUser);
clsCheckSql.CheckFieldLen(objSysCommentEN.UpdDate, 20, conSysComment.UpdDate);
clsCheckSql.CheckFieldLen(objSysCommentEN.Memo, 1000, conSysComment.Memo);
//检查字段外键固定长度
 objSysCommentEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsSysCommentEN objSysCommentEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objSysCommentEN.Comment, 2000, conSysComment.Comment);
clsCheckSql.CheckFieldLen(objSysCommentEN.CommentTypeId, 2, conSysComment.CommentTypeId);
clsCheckSql.CheckFieldLen(objSysCommentEN.ScoreType, 1, conSysComment.ScoreType);
clsCheckSql.CheckFieldLen(objSysCommentEN.ParentId, 20, conSysComment.ParentId);
clsCheckSql.CheckFieldLen(objSysCommentEN.TableKey, 20, conSysComment.TableKey);
clsCheckSql.CheckFieldLen(objSysCommentEN.PubParentId, 20, conSysComment.PubParentId);
clsCheckSql.CheckFieldLen(objSysCommentEN.IdCurrEduCls, 8, conSysComment.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objSysCommentEN.UserId, 18, conSysComment.UserId);
clsCheckSql.CheckFieldLen(objSysCommentEN.WeekTimeRange, 100, conSysComment.WeekTimeRange);
clsCheckSql.CheckFieldLen(objSysCommentEN.UpdUser, 20, conSysComment.UpdUser);
clsCheckSql.CheckFieldLen(objSysCommentEN.UpdDate, 20, conSysComment.UpdDate);
clsCheckSql.CheckFieldLen(objSysCommentEN.Memo, 1000, conSysComment.Memo);
//检查外键字段长度
 objSysCommentEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsSysCommentEN objSysCommentEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objSysCommentEN.CommentId, 10, conSysComment.CommentId);
clsCheckSql.CheckFieldLen(objSysCommentEN.Comment, 2000, conSysComment.Comment);
clsCheckSql.CheckFieldLen(objSysCommentEN.CommentTypeId, 2, conSysComment.CommentTypeId);
clsCheckSql.CheckFieldLen(objSysCommentEN.ScoreType, 1, conSysComment.ScoreType);
clsCheckSql.CheckFieldLen(objSysCommentEN.ParentId, 20, conSysComment.ParentId);
clsCheckSql.CheckFieldLen(objSysCommentEN.TableKey, 20, conSysComment.TableKey);
clsCheckSql.CheckFieldLen(objSysCommentEN.PubParentId, 20, conSysComment.PubParentId);
clsCheckSql.CheckFieldLen(objSysCommentEN.IdCurrEduCls, 8, conSysComment.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objSysCommentEN.UserId, 18, conSysComment.UserId);
clsCheckSql.CheckFieldLen(objSysCommentEN.WeekTimeRange, 100, conSysComment.WeekTimeRange);
clsCheckSql.CheckFieldLen(objSysCommentEN.UpdUser, 20, conSysComment.UpdUser);
clsCheckSql.CheckFieldLen(objSysCommentEN.UpdDate, 20, conSysComment.UpdDate);
clsCheckSql.CheckFieldLen(objSysCommentEN.Memo, 1000, conSysComment.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objSysCommentEN.CommentId, conSysComment.CommentId);
clsCheckSql.CheckSqlInjection4Field(objSysCommentEN.Comment, conSysComment.Comment);
clsCheckSql.CheckSqlInjection4Field(objSysCommentEN.CommentTypeId, conSysComment.CommentTypeId);
clsCheckSql.CheckSqlInjection4Field(objSysCommentEN.ScoreType, conSysComment.ScoreType);
clsCheckSql.CheckSqlInjection4Field(objSysCommentEN.ParentId, conSysComment.ParentId);
clsCheckSql.CheckSqlInjection4Field(objSysCommentEN.TableKey, conSysComment.TableKey);
clsCheckSql.CheckSqlInjection4Field(objSysCommentEN.PubParentId, conSysComment.PubParentId);
clsCheckSql.CheckSqlInjection4Field(objSysCommentEN.IdCurrEduCls, conSysComment.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objSysCommentEN.UserId, conSysComment.UserId);
clsCheckSql.CheckSqlInjection4Field(objSysCommentEN.WeekTimeRange, conSysComment.WeekTimeRange);
clsCheckSql.CheckSqlInjection4Field(objSysCommentEN.UpdUser, conSysComment.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objSysCommentEN.UpdDate, conSysComment.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objSysCommentEN.Memo, conSysComment.Memo);
//检查外键字段长度
 objSysCommentEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--SysComment(系统评论表),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objSysCommentEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsSysCommentEN objSysCommentEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CommentId = '{0}'", objSysCommentEN.CommentId);
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
 objSQL = clsSysCommentDA.GetSpecSQLObj();
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
 objSQL = clsSysCommentDA.GetSpecSQLObj();
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
 objSQL = clsSysCommentDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsSysCommentEN._CurrTabName);
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
 objSQL = clsSysCommentDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsSysCommentEN._CurrTabName, strCondition);
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
 objSQL = clsSysCommentDA.GetSpecSQLObj();
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
 objSQL = clsSysCommentDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}