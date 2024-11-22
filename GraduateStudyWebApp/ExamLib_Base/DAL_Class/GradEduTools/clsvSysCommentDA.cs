
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSysCommentDA
 表名:vSysComment(01120624)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:03:33
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培设置(GradEduTools)
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
 /// v系统评论表(vSysComment)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvSysCommentDA : clsCommBase4DA
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
 return clsvSysCommentEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvSysCommentEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvSysCommentEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvSysCommentEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvSysCommentEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:vSysComment中,检查关键字,长度不正确!(clsvSysCommentDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strCommentId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vSysComment中,关键字不能为空 或 null!(clsvSysCommentDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCommentId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvSysCommentDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvSysCommentDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysCommentDA.GetSpecSQLObj();
strSQL = "Select * from vSysComment where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vSysComment(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvSysCommentDA: GetDataTable_vSysComment)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysCommentDA.GetSpecSQLObj();
strSQL = "Select * from vSysComment where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvSysCommentDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysCommentDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvSysCommentDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysCommentDA.GetSpecSQLObj();
strSQL = "Select * from vSysComment where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvSysCommentDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysCommentDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvSysCommentDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysCommentDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vSysComment where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vSysComment where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvSysCommentDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysCommentDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vSysComment where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvSysCommentDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysCommentDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vSysComment.* from vSysComment Left Join {1} on {2} where {3} and vSysComment.CommentId not in (Select top {5} vSysComment.CommentId from vSysComment Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vSysComment where {1} and CommentId not in (Select top {2} CommentId from vSysComment where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vSysComment where {1} and CommentId not in (Select top {3} CommentId from vSysComment where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvSysCommentDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysCommentDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vSysComment.* from vSysComment Left Join {1} on {2} where {3} and vSysComment.CommentId not in (Select top {5} vSysComment.CommentId from vSysComment Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vSysComment where {1} and CommentId not in (Select top {2} CommentId from vSysComment where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vSysComment where {1} and CommentId not in (Select top {3} CommentId from vSysComment where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvSysCommentEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvSysCommentDA:GetObjLst)", objException.Message));
}
List<clsvSysCommentEN> arrObjLst = new List<clsvSysCommentEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysCommentDA.GetSpecSQLObj();
strSQL = "Select * from vSysComment where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysCommentEN objvSysCommentEN = new clsvSysCommentEN();
try
{
objvSysCommentEN.CommentId = objRow[convSysComment.CommentId].ToString().Trim(); //评论Id
objvSysCommentEN.Comment = objRow[convSysComment.Comment] == DBNull.Value ? null : objRow[convSysComment.Comment].ToString().Trim(); //评论
objvSysCommentEN.Score = objRow[convSysComment.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convSysComment.Score].ToString().Trim()); //评分
objvSysCommentEN.CommentTypeId = objRow[convSysComment.CommentTypeId].ToString().Trim(); //评论类型Id
objvSysCommentEN.ScoreType = objRow[convSysComment.ScoreType] == DBNull.Value ? null : objRow[convSysComment.ScoreType].ToString().Trim(); //评分类型
objvSysCommentEN.ParentId = objRow[convSysComment.ParentId].ToString().Trim(); //父Id
objvSysCommentEN.TableKey = objRow[convSysComment.TableKey] == DBNull.Value ? null : objRow[convSysComment.TableKey].ToString().Trim(); //表主键
objvSysCommentEN.UpdUser = objRow[convSysComment.UpdUser] == DBNull.Value ? null : objRow[convSysComment.UpdUser].ToString().Trim(); //修改人
objvSysCommentEN.UpdDate = objRow[convSysComment.UpdDate] == DBNull.Value ? null : objRow[convSysComment.UpdDate].ToString().Trim(); //修改日期
objvSysCommentEN.Memo = objRow[convSysComment.Memo] == DBNull.Value ? null : objRow[convSysComment.Memo].ToString().Trim(); //备注
objvSysCommentEN.CommentTypeName = objRow[convSysComment.CommentTypeName] == DBNull.Value ? null : objRow[convSysComment.CommentTypeName].ToString().Trim(); //评论类型名
objvSysCommentEN.CommentTable = objRow[convSysComment.CommentTable] == DBNull.Value ? null : objRow[convSysComment.CommentTable].ToString().Trim(); //评论表
objvSysCommentEN.CommentTableId = objRow[convSysComment.CommentTableId] == DBNull.Value ? null : objRow[convSysComment.CommentTableId].ToString().Trim(); //评论表Id
objvSysCommentEN.OkCount = objRow[convSysComment.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSysComment.OkCount].ToString().Trim()); //点赞统计
objvSysCommentEN.PubParentId = objRow[convSysComment.PubParentId] == DBNull.Value ? null : objRow[convSysComment.PubParentId].ToString().Trim(); //公共父Id
objvSysCommentEN.IdCurrEduCls = objRow[convSysComment.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysCommentEN.UserId = objRow[convSysComment.UserId] == DBNull.Value ? null : objRow[convSysComment.UserId].ToString().Trim(); //用户ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvSysCommentDA: GetObjLst)", objException.Message));
}
objvSysCommentEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvSysCommentEN);
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
public List<clsvSysCommentEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvSysCommentDA:GetObjLstByTabName)", objException.Message));
}
List<clsvSysCommentEN> arrObjLst = new List<clsvSysCommentEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysCommentDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysCommentEN objvSysCommentEN = new clsvSysCommentEN();
try
{
objvSysCommentEN.CommentId = objRow[convSysComment.CommentId].ToString().Trim(); //评论Id
objvSysCommentEN.Comment = objRow[convSysComment.Comment] == DBNull.Value ? null : objRow[convSysComment.Comment].ToString().Trim(); //评论
objvSysCommentEN.Score = objRow[convSysComment.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convSysComment.Score].ToString().Trim()); //评分
objvSysCommentEN.CommentTypeId = objRow[convSysComment.CommentTypeId].ToString().Trim(); //评论类型Id
objvSysCommentEN.ScoreType = objRow[convSysComment.ScoreType] == DBNull.Value ? null : objRow[convSysComment.ScoreType].ToString().Trim(); //评分类型
objvSysCommentEN.ParentId = objRow[convSysComment.ParentId].ToString().Trim(); //父Id
objvSysCommentEN.TableKey = objRow[convSysComment.TableKey] == DBNull.Value ? null : objRow[convSysComment.TableKey].ToString().Trim(); //表主键
objvSysCommentEN.UpdUser = objRow[convSysComment.UpdUser] == DBNull.Value ? null : objRow[convSysComment.UpdUser].ToString().Trim(); //修改人
objvSysCommentEN.UpdDate = objRow[convSysComment.UpdDate] == DBNull.Value ? null : objRow[convSysComment.UpdDate].ToString().Trim(); //修改日期
objvSysCommentEN.Memo = objRow[convSysComment.Memo] == DBNull.Value ? null : objRow[convSysComment.Memo].ToString().Trim(); //备注
objvSysCommentEN.CommentTypeName = objRow[convSysComment.CommentTypeName] == DBNull.Value ? null : objRow[convSysComment.CommentTypeName].ToString().Trim(); //评论类型名
objvSysCommentEN.CommentTable = objRow[convSysComment.CommentTable] == DBNull.Value ? null : objRow[convSysComment.CommentTable].ToString().Trim(); //评论表
objvSysCommentEN.CommentTableId = objRow[convSysComment.CommentTableId] == DBNull.Value ? null : objRow[convSysComment.CommentTableId].ToString().Trim(); //评论表Id
objvSysCommentEN.OkCount = objRow[convSysComment.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSysComment.OkCount].ToString().Trim()); //点赞统计
objvSysCommentEN.PubParentId = objRow[convSysComment.PubParentId] == DBNull.Value ? null : objRow[convSysComment.PubParentId].ToString().Trim(); //公共父Id
objvSysCommentEN.IdCurrEduCls = objRow[convSysComment.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysCommentEN.UserId = objRow[convSysComment.UserId] == DBNull.Value ? null : objRow[convSysComment.UserId].ToString().Trim(); //用户ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvSysCommentDA: GetObjLst)", objException.Message));
}
objvSysCommentEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvSysCommentEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvSysCommentEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvSysComment(ref clsvSysCommentEN objvSysCommentEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysCommentDA.GetSpecSQLObj();
strSQL = "Select * from vSysComment where CommentId = " + "'"+ objvSysCommentEN.CommentId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvSysCommentEN.CommentId = objDT.Rows[0][convSysComment.CommentId].ToString().Trim(); //评论Id(字段类型:char,字段长度:10,是否可空:False)
 objvSysCommentEN.Comment = objDT.Rows[0][convSysComment.Comment].ToString().Trim(); //评论(字段类型:varchar,字段长度:2000,是否可空:True)
 objvSysCommentEN.Score = TransNullToFloat(objDT.Rows[0][convSysComment.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvSysCommentEN.CommentTypeId = objDT.Rows[0][convSysComment.CommentTypeId].ToString().Trim(); //评论类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvSysCommentEN.ScoreType = objDT.Rows[0][convSysComment.ScoreType].ToString().Trim(); //评分类型(字段类型:char,字段长度:1,是否可空:True)
 objvSysCommentEN.ParentId = objDT.Rows[0][convSysComment.ParentId].ToString().Trim(); //父Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvSysCommentEN.TableKey = objDT.Rows[0][convSysComment.TableKey].ToString().Trim(); //表主键(字段类型:varchar,字段长度:20,是否可空:True)
 objvSysCommentEN.UpdUser = objDT.Rows[0][convSysComment.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvSysCommentEN.UpdDate = objDT.Rows[0][convSysComment.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvSysCommentEN.Memo = objDT.Rows[0][convSysComment.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvSysCommentEN.CommentTypeName = objDT.Rows[0][convSysComment.CommentTypeName].ToString().Trim(); //评论类型名(字段类型:varchar,字段长度:50,是否可空:True)
 objvSysCommentEN.CommentTable = objDT.Rows[0][convSysComment.CommentTable].ToString().Trim(); //评论表(字段类型:varchar,字段长度:50,是否可空:True)
 objvSysCommentEN.CommentTableId = objDT.Rows[0][convSysComment.CommentTableId].ToString().Trim(); //评论表Id(字段类型:varchar,字段长度:50,是否可空:True)
 objvSysCommentEN.OkCount = TransNullToInt(objDT.Rows[0][convSysComment.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objvSysCommentEN.PubParentId = objDT.Rows[0][convSysComment.PubParentId].ToString().Trim(); //公共父Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvSysCommentEN.IdCurrEduCls = objDT.Rows[0][convSysComment.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvSysCommentEN.UserId = objDT.Rows[0][convSysComment.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvSysCommentDA: GetvSysComment)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strCommentId">表关键字</param>
 /// <returns>表对象</returns>
public clsvSysCommentEN GetObjByCommentId(string strCommentId)
{
CheckPrimaryKey(strCommentId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysCommentDA.GetSpecSQLObj();
strSQL = "Select * from vSysComment where CommentId = " + "'"+ strCommentId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvSysCommentEN objvSysCommentEN = new clsvSysCommentEN();
try
{
 objvSysCommentEN.CommentId = objRow[convSysComment.CommentId].ToString().Trim(); //评论Id(字段类型:char,字段长度:10,是否可空:False)
 objvSysCommentEN.Comment = objRow[convSysComment.Comment] == DBNull.Value ? null : objRow[convSysComment.Comment].ToString().Trim(); //评论(字段类型:varchar,字段长度:2000,是否可空:True)
 objvSysCommentEN.Score = objRow[convSysComment.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysComment.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvSysCommentEN.CommentTypeId = objRow[convSysComment.CommentTypeId].ToString().Trim(); //评论类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvSysCommentEN.ScoreType = objRow[convSysComment.ScoreType] == DBNull.Value ? null : objRow[convSysComment.ScoreType].ToString().Trim(); //评分类型(字段类型:char,字段长度:1,是否可空:True)
 objvSysCommentEN.ParentId = objRow[convSysComment.ParentId].ToString().Trim(); //父Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvSysCommentEN.TableKey = objRow[convSysComment.TableKey] == DBNull.Value ? null : objRow[convSysComment.TableKey].ToString().Trim(); //表主键(字段类型:varchar,字段长度:20,是否可空:True)
 objvSysCommentEN.UpdUser = objRow[convSysComment.UpdUser] == DBNull.Value ? null : objRow[convSysComment.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvSysCommentEN.UpdDate = objRow[convSysComment.UpdDate] == DBNull.Value ? null : objRow[convSysComment.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvSysCommentEN.Memo = objRow[convSysComment.Memo] == DBNull.Value ? null : objRow[convSysComment.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvSysCommentEN.CommentTypeName = objRow[convSysComment.CommentTypeName] == DBNull.Value ? null : objRow[convSysComment.CommentTypeName].ToString().Trim(); //评论类型名(字段类型:varchar,字段长度:50,是否可空:True)
 objvSysCommentEN.CommentTable = objRow[convSysComment.CommentTable] == DBNull.Value ? null : objRow[convSysComment.CommentTable].ToString().Trim(); //评论表(字段类型:varchar,字段长度:50,是否可空:True)
 objvSysCommentEN.CommentTableId = objRow[convSysComment.CommentTableId] == DBNull.Value ? null : objRow[convSysComment.CommentTableId].ToString().Trim(); //评论表Id(字段类型:varchar,字段长度:50,是否可空:True)
 objvSysCommentEN.OkCount = objRow[convSysComment.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysComment.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objvSysCommentEN.PubParentId = objRow[convSysComment.PubParentId] == DBNull.Value ? null : objRow[convSysComment.PubParentId].ToString().Trim(); //公共父Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvSysCommentEN.IdCurrEduCls = objRow[convSysComment.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvSysCommentEN.UserId = objRow[convSysComment.UserId] == DBNull.Value ? null : objRow[convSysComment.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvSysCommentDA: GetObjByCommentId)", objException.Message));
}
return objvSysCommentEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvSysCommentEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvSysCommentDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysCommentDA.GetSpecSQLObj();
strSQL = "Select * from vSysComment where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvSysCommentEN objvSysCommentEN = new clsvSysCommentEN()
{
CommentId = objRow[convSysComment.CommentId].ToString().Trim(), //评论Id
Comment = objRow[convSysComment.Comment] == DBNull.Value ? null : objRow[convSysComment.Comment].ToString().Trim(), //评论
Score = objRow[convSysComment.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convSysComment.Score].ToString().Trim()), //评分
CommentTypeId = objRow[convSysComment.CommentTypeId].ToString().Trim(), //评论类型Id
ScoreType = objRow[convSysComment.ScoreType] == DBNull.Value ? null : objRow[convSysComment.ScoreType].ToString().Trim(), //评分类型
ParentId = objRow[convSysComment.ParentId].ToString().Trim(), //父Id
TableKey = objRow[convSysComment.TableKey] == DBNull.Value ? null : objRow[convSysComment.TableKey].ToString().Trim(), //表主键
UpdUser = objRow[convSysComment.UpdUser] == DBNull.Value ? null : objRow[convSysComment.UpdUser].ToString().Trim(), //修改人
UpdDate = objRow[convSysComment.UpdDate] == DBNull.Value ? null : objRow[convSysComment.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[convSysComment.Memo] == DBNull.Value ? null : objRow[convSysComment.Memo].ToString().Trim(), //备注
CommentTypeName = objRow[convSysComment.CommentTypeName] == DBNull.Value ? null : objRow[convSysComment.CommentTypeName].ToString().Trim(), //评论类型名
CommentTable = objRow[convSysComment.CommentTable] == DBNull.Value ? null : objRow[convSysComment.CommentTable].ToString().Trim(), //评论表
CommentTableId = objRow[convSysComment.CommentTableId] == DBNull.Value ? null : objRow[convSysComment.CommentTableId].ToString().Trim(), //评论表Id
OkCount = objRow[convSysComment.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSysComment.OkCount].ToString().Trim()), //点赞统计
PubParentId = objRow[convSysComment.PubParentId] == DBNull.Value ? null : objRow[convSysComment.PubParentId].ToString().Trim(), //公共父Id
IdCurrEduCls = objRow[convSysComment.IdCurrEduCls].ToString().Trim(), //教学班流水号
UserId = objRow[convSysComment.UserId] == DBNull.Value ? null : objRow[convSysComment.UserId].ToString().Trim() //用户ID
};
objvSysCommentEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvSysCommentEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvSysCommentDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvSysCommentEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvSysCommentEN objvSysCommentEN = new clsvSysCommentEN();
try
{
objvSysCommentEN.CommentId = objRow[convSysComment.CommentId].ToString().Trim(); //评论Id
objvSysCommentEN.Comment = objRow[convSysComment.Comment] == DBNull.Value ? null : objRow[convSysComment.Comment].ToString().Trim(); //评论
objvSysCommentEN.Score = objRow[convSysComment.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convSysComment.Score].ToString().Trim()); //评分
objvSysCommentEN.CommentTypeId = objRow[convSysComment.CommentTypeId].ToString().Trim(); //评论类型Id
objvSysCommentEN.ScoreType = objRow[convSysComment.ScoreType] == DBNull.Value ? null : objRow[convSysComment.ScoreType].ToString().Trim(); //评分类型
objvSysCommentEN.ParentId = objRow[convSysComment.ParentId].ToString().Trim(); //父Id
objvSysCommentEN.TableKey = objRow[convSysComment.TableKey] == DBNull.Value ? null : objRow[convSysComment.TableKey].ToString().Trim(); //表主键
objvSysCommentEN.UpdUser = objRow[convSysComment.UpdUser] == DBNull.Value ? null : objRow[convSysComment.UpdUser].ToString().Trim(); //修改人
objvSysCommentEN.UpdDate = objRow[convSysComment.UpdDate] == DBNull.Value ? null : objRow[convSysComment.UpdDate].ToString().Trim(); //修改日期
objvSysCommentEN.Memo = objRow[convSysComment.Memo] == DBNull.Value ? null : objRow[convSysComment.Memo].ToString().Trim(); //备注
objvSysCommentEN.CommentTypeName = objRow[convSysComment.CommentTypeName] == DBNull.Value ? null : objRow[convSysComment.CommentTypeName].ToString().Trim(); //评论类型名
objvSysCommentEN.CommentTable = objRow[convSysComment.CommentTable] == DBNull.Value ? null : objRow[convSysComment.CommentTable].ToString().Trim(); //评论表
objvSysCommentEN.CommentTableId = objRow[convSysComment.CommentTableId] == DBNull.Value ? null : objRow[convSysComment.CommentTableId].ToString().Trim(); //评论表Id
objvSysCommentEN.OkCount = objRow[convSysComment.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSysComment.OkCount].ToString().Trim()); //点赞统计
objvSysCommentEN.PubParentId = objRow[convSysComment.PubParentId] == DBNull.Value ? null : objRow[convSysComment.PubParentId].ToString().Trim(); //公共父Id
objvSysCommentEN.IdCurrEduCls = objRow[convSysComment.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysCommentEN.UserId = objRow[convSysComment.UserId] == DBNull.Value ? null : objRow[convSysComment.UserId].ToString().Trim(); //用户ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvSysCommentDA: GetObjByDataRowvSysComment)", objException.Message));
}
objvSysCommentEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvSysCommentEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvSysCommentEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvSysCommentEN objvSysCommentEN = new clsvSysCommentEN();
try
{
objvSysCommentEN.CommentId = objRow[convSysComment.CommentId].ToString().Trim(); //评论Id
objvSysCommentEN.Comment = objRow[convSysComment.Comment] == DBNull.Value ? null : objRow[convSysComment.Comment].ToString().Trim(); //评论
objvSysCommentEN.Score = objRow[convSysComment.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convSysComment.Score].ToString().Trim()); //评分
objvSysCommentEN.CommentTypeId = objRow[convSysComment.CommentTypeId].ToString().Trim(); //评论类型Id
objvSysCommentEN.ScoreType = objRow[convSysComment.ScoreType] == DBNull.Value ? null : objRow[convSysComment.ScoreType].ToString().Trim(); //评分类型
objvSysCommentEN.ParentId = objRow[convSysComment.ParentId].ToString().Trim(); //父Id
objvSysCommentEN.TableKey = objRow[convSysComment.TableKey] == DBNull.Value ? null : objRow[convSysComment.TableKey].ToString().Trim(); //表主键
objvSysCommentEN.UpdUser = objRow[convSysComment.UpdUser] == DBNull.Value ? null : objRow[convSysComment.UpdUser].ToString().Trim(); //修改人
objvSysCommentEN.UpdDate = objRow[convSysComment.UpdDate] == DBNull.Value ? null : objRow[convSysComment.UpdDate].ToString().Trim(); //修改日期
objvSysCommentEN.Memo = objRow[convSysComment.Memo] == DBNull.Value ? null : objRow[convSysComment.Memo].ToString().Trim(); //备注
objvSysCommentEN.CommentTypeName = objRow[convSysComment.CommentTypeName] == DBNull.Value ? null : objRow[convSysComment.CommentTypeName].ToString().Trim(); //评论类型名
objvSysCommentEN.CommentTable = objRow[convSysComment.CommentTable] == DBNull.Value ? null : objRow[convSysComment.CommentTable].ToString().Trim(); //评论表
objvSysCommentEN.CommentTableId = objRow[convSysComment.CommentTableId] == DBNull.Value ? null : objRow[convSysComment.CommentTableId].ToString().Trim(); //评论表Id
objvSysCommentEN.OkCount = objRow[convSysComment.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSysComment.OkCount].ToString().Trim()); //点赞统计
objvSysCommentEN.PubParentId = objRow[convSysComment.PubParentId] == DBNull.Value ? null : objRow[convSysComment.PubParentId].ToString().Trim(); //公共父Id
objvSysCommentEN.IdCurrEduCls = objRow[convSysComment.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysCommentEN.UserId = objRow[convSysComment.UserId] == DBNull.Value ? null : objRow[convSysComment.UserId].ToString().Trim(); //用户ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvSysCommentDA: GetObjByDataRow)", objException.Message));
}
objvSysCommentEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvSysCommentEN;
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
objSQL = clsvSysCommentDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvSysCommentEN._CurrTabName, convSysComment.CommentId, 10, "");
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
objSQL = clsvSysCommentDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvSysCommentEN._CurrTabName, convSysComment.CommentId, 10, strPrefix);
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
 objSQL = clsvSysCommentDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select CommentId from vSysComment where " + strCondition;
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
 objSQL = clsvSysCommentDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select CommentId from vSysComment where " + strCondition;
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
 objSQL = clsvSysCommentDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vSysComment", "CommentId = " + "'"+ strCommentId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvSysCommentDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysCommentDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vSysComment", strCondition))
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
objSQL = clsvSysCommentDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vSysComment");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvSysCommentENS">源对象</param>
 /// <param name = "objvSysCommentENT">目标对象</param>
public void CopyTo(clsvSysCommentEN objvSysCommentENS, clsvSysCommentEN objvSysCommentENT)
{
objvSysCommentENT.CommentId = objvSysCommentENS.CommentId; //评论Id
objvSysCommentENT.Comment = objvSysCommentENS.Comment; //评论
objvSysCommentENT.Score = objvSysCommentENS.Score; //评分
objvSysCommentENT.CommentTypeId = objvSysCommentENS.CommentTypeId; //评论类型Id
objvSysCommentENT.ScoreType = objvSysCommentENS.ScoreType; //评分类型
objvSysCommentENT.ParentId = objvSysCommentENS.ParentId; //父Id
objvSysCommentENT.TableKey = objvSysCommentENS.TableKey; //表主键
objvSysCommentENT.UpdUser = objvSysCommentENS.UpdUser; //修改人
objvSysCommentENT.UpdDate = objvSysCommentENS.UpdDate; //修改日期
objvSysCommentENT.Memo = objvSysCommentENS.Memo; //备注
objvSysCommentENT.CommentTypeName = objvSysCommentENS.CommentTypeName; //评论类型名
objvSysCommentENT.CommentTable = objvSysCommentENS.CommentTable; //评论表
objvSysCommentENT.CommentTableId = objvSysCommentENS.CommentTableId; //评论表Id
objvSysCommentENT.OkCount = objvSysCommentENS.OkCount; //点赞统计
objvSysCommentENT.PubParentId = objvSysCommentENS.PubParentId; //公共父Id
objvSysCommentENT.IdCurrEduCls = objvSysCommentENS.IdCurrEduCls; //教学班流水号
objvSysCommentENT.UserId = objvSysCommentENS.UserId; //用户ID
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvSysCommentEN objvSysCommentEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvSysCommentEN.CommentId, 10, convSysComment.CommentId);
clsCheckSql.CheckFieldLen(objvSysCommentEN.Comment, 2000, convSysComment.Comment);
clsCheckSql.CheckFieldLen(objvSysCommentEN.CommentTypeId, 2, convSysComment.CommentTypeId);
clsCheckSql.CheckFieldLen(objvSysCommentEN.ScoreType, 1, convSysComment.ScoreType);
clsCheckSql.CheckFieldLen(objvSysCommentEN.ParentId, 20, convSysComment.ParentId);
clsCheckSql.CheckFieldLen(objvSysCommentEN.TableKey, 20, convSysComment.TableKey);
clsCheckSql.CheckFieldLen(objvSysCommentEN.UpdUser, 20, convSysComment.UpdUser);
clsCheckSql.CheckFieldLen(objvSysCommentEN.UpdDate, 20, convSysComment.UpdDate);
clsCheckSql.CheckFieldLen(objvSysCommentEN.Memo, 1000, convSysComment.Memo);
clsCheckSql.CheckFieldLen(objvSysCommentEN.CommentTypeName, 50, convSysComment.CommentTypeName);
clsCheckSql.CheckFieldLen(objvSysCommentEN.CommentTable, 50, convSysComment.CommentTable);
clsCheckSql.CheckFieldLen(objvSysCommentEN.CommentTableId, 50, convSysComment.CommentTableId);
clsCheckSql.CheckFieldLen(objvSysCommentEN.PubParentId, 20, convSysComment.PubParentId);
clsCheckSql.CheckFieldLen(objvSysCommentEN.IdCurrEduCls, 8, convSysComment.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objvSysCommentEN.UserId, 18, convSysComment.UserId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvSysCommentEN.CommentId, convSysComment.CommentId);
clsCheckSql.CheckSqlInjection4Field(objvSysCommentEN.Comment, convSysComment.Comment);
clsCheckSql.CheckSqlInjection4Field(objvSysCommentEN.CommentTypeId, convSysComment.CommentTypeId);
clsCheckSql.CheckSqlInjection4Field(objvSysCommentEN.ScoreType, convSysComment.ScoreType);
clsCheckSql.CheckSqlInjection4Field(objvSysCommentEN.ParentId, convSysComment.ParentId);
clsCheckSql.CheckSqlInjection4Field(objvSysCommentEN.TableKey, convSysComment.TableKey);
clsCheckSql.CheckSqlInjection4Field(objvSysCommentEN.UpdUser, convSysComment.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvSysCommentEN.UpdDate, convSysComment.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvSysCommentEN.Memo, convSysComment.Memo);
clsCheckSql.CheckSqlInjection4Field(objvSysCommentEN.CommentTypeName, convSysComment.CommentTypeName);
clsCheckSql.CheckSqlInjection4Field(objvSysCommentEN.CommentTable, convSysComment.CommentTable);
clsCheckSql.CheckSqlInjection4Field(objvSysCommentEN.CommentTableId, convSysComment.CommentTableId);
clsCheckSql.CheckSqlInjection4Field(objvSysCommentEN.PubParentId, convSysComment.PubParentId);
clsCheckSql.CheckSqlInjection4Field(objvSysCommentEN.IdCurrEduCls, convSysComment.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objvSysCommentEN.UserId, convSysComment.UserId);
//检查外键字段长度
 objvSysCommentEN._IsCheckProperty = true;
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
 objSQL = clsvSysCommentDA.GetSpecSQLObj();
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
 objSQL = clsvSysCommentDA.GetSpecSQLObj();
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
 objSQL = clsvSysCommentDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvSysCommentEN._CurrTabName);
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
 objSQL = clsvSysCommentDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvSysCommentEN._CurrTabName, strCondition);
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
 objSQL = clsvSysCommentDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}