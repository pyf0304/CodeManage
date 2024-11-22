
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_SysCommentDA
 表名:vzx_SysComment(01120836)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:14:13
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
 /// vzx_SysComment(vzx_SysComment)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvzx_SysCommentDA : clsCommBase4DA
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
 return clsvzx_SysCommentEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvzx_SysCommentEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvzx_SysCommentEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvzx_SysCommentEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvzx_SysCommentEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strzxCommentId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strzxCommentId)
{
strzxCommentId = strzxCommentId.Replace("'", "''");
if (strzxCommentId.Length > 10)
{
throw new Exception("(errid:Data000001)在表:vzx_SysComment中,检查关键字,长度不正确!(clsvzx_SysCommentDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strzxCommentId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vzx_SysComment中,关键字不能为空 或 null!(clsvzx_SysCommentDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strzxCommentId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvzx_SysCommentDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvzx_SysCommentDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SysCommentDA.GetSpecSQLObj();
strSQL = "Select * from vzx_SysComment where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vzx_SysComment(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvzx_SysCommentDA: GetDataTable_vzx_SysComment)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SysCommentDA.GetSpecSQLObj();
strSQL = "Select * from vzx_SysComment where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvzx_SysCommentDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SysCommentDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvzx_SysCommentDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SysCommentDA.GetSpecSQLObj();
strSQL = "Select * from vzx_SysComment where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvzx_SysCommentDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SysCommentDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvzx_SysCommentDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SysCommentDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vzx_SysComment where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vzx_SysComment where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvzx_SysCommentDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SysCommentDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vzx_SysComment where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvzx_SysCommentDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SysCommentDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vzx_SysComment.* from vzx_SysComment Left Join {1} on {2} where {3} and vzx_SysComment.zxCommentId not in (Select top {5} vzx_SysComment.zxCommentId from vzx_SysComment Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vzx_SysComment where {1} and zxCommentId not in (Select top {2} zxCommentId from vzx_SysComment where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vzx_SysComment where {1} and zxCommentId not in (Select top {3} zxCommentId from vzx_SysComment where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvzx_SysCommentDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SysCommentDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vzx_SysComment.* from vzx_SysComment Left Join {1} on {2} where {3} and vzx_SysComment.zxCommentId not in (Select top {5} vzx_SysComment.zxCommentId from vzx_SysComment Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vzx_SysComment where {1} and zxCommentId not in (Select top {2} zxCommentId from vzx_SysComment where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vzx_SysComment where {1} and zxCommentId not in (Select top {3} zxCommentId from vzx_SysComment where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvzx_SysCommentEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvzx_SysCommentDA:GetObjLst)", objException.Message));
}
List<clsvzx_SysCommentEN> arrObjLst = new List<clsvzx_SysCommentEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SysCommentDA.GetSpecSQLObj();
strSQL = "Select * from vzx_SysComment where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_SysCommentEN objvzx_SysCommentEN = new clsvzx_SysCommentEN();
try
{
objvzx_SysCommentEN.CommentTypeName = objRow[convzx_SysComment.CommentTypeName] == DBNull.Value ? null : objRow[convzx_SysComment.CommentTypeName].ToString().Trim(); //评论类型名
objvzx_SysCommentEN.zxCommentId = objRow[convzx_SysComment.zxCommentId].ToString().Trim(); //评论Id
objvzx_SysCommentEN.CommentTable = objRow[convzx_SysComment.CommentTable] == DBNull.Value ? null : objRow[convzx_SysComment.CommentTable].ToString().Trim(); //评论表
objvzx_SysCommentEN.Comment = objRow[convzx_SysComment.Comment] == DBNull.Value ? null : objRow[convzx_SysComment.Comment].ToString().Trim(); //评论
objvzx_SysCommentEN.CommentTableId = objRow[convzx_SysComment.CommentTableId] == DBNull.Value ? null : objRow[convzx_SysComment.CommentTableId].ToString().Trim(); //评论表Id
objvzx_SysCommentEN.Score = objRow[convzx_SysComment.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_SysComment.Score].ToString().Trim()); //评分
objvzx_SysCommentEN.zxCommentTypeId = objRow[convzx_SysComment.zxCommentTypeId].ToString().Trim(); //评论类型Id
objvzx_SysCommentEN.ScoreType = objRow[convzx_SysComment.ScoreType] == DBNull.Value ? null : objRow[convzx_SysComment.ScoreType].ToString().Trim(); //评分类型
objvzx_SysCommentEN.ParentId = objRow[convzx_SysComment.ParentId].ToString().Trim(); //父Id
objvzx_SysCommentEN.TableKey = objRow[convzx_SysComment.TableKey] == DBNull.Value ? null : objRow[convzx_SysComment.TableKey].ToString().Trim(); //表主键
objvzx_SysCommentEN.UpdUser = objRow[convzx_SysComment.UpdUser] == DBNull.Value ? null : objRow[convzx_SysComment.UpdUser].ToString().Trim(); //修改人
objvzx_SysCommentEN.UpdDate = objRow[convzx_SysComment.UpdDate] == DBNull.Value ? null : objRow[convzx_SysComment.UpdDate].ToString().Trim(); //修改日期
objvzx_SysCommentEN.Memo = objRow[convzx_SysComment.Memo] == DBNull.Value ? null : objRow[convzx_SysComment.Memo].ToString().Trim(); //备注
objvzx_SysCommentEN.OkCount = objRow[convzx_SysComment.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_SysComment.OkCount].ToString().Trim()); //点赞统计
objvzx_SysCommentEN.PubParentId = objRow[convzx_SysComment.PubParentId] == DBNull.Value ? null : objRow[convzx_SysComment.PubParentId].ToString().Trim(); //公共父Id
objvzx_SysCommentEN.IdCurrEduCls = objRow[convzx_SysComment.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_SysComment.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_SysCommentEN.UserId = objRow[convzx_SysComment.UserId] == DBNull.Value ? null : objRow[convzx_SysComment.UserId].ToString().Trim(); //用户ID
objvzx_SysCommentEN.Month = objRow[convzx_SysComment.Month] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_SysComment.Month].ToString().Trim()); //月
objvzx_SysCommentEN.Week = objRow[convzx_SysComment.Week] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_SysComment.Week].ToString().Trim()); //周
objvzx_SysCommentEN.WeekTimeRange = objRow[convzx_SysComment.WeekTimeRange] == DBNull.Value ? null : objRow[convzx_SysComment.WeekTimeRange].ToString().Trim(); //WeekTimeRange
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvzx_SysCommentDA: GetObjLst)", objException.Message));
}
objvzx_SysCommentEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvzx_SysCommentEN);
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
public List<clsvzx_SysCommentEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvzx_SysCommentDA:GetObjLstByTabName)", objException.Message));
}
List<clsvzx_SysCommentEN> arrObjLst = new List<clsvzx_SysCommentEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SysCommentDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_SysCommentEN objvzx_SysCommentEN = new clsvzx_SysCommentEN();
try
{
objvzx_SysCommentEN.CommentTypeName = objRow[convzx_SysComment.CommentTypeName] == DBNull.Value ? null : objRow[convzx_SysComment.CommentTypeName].ToString().Trim(); //评论类型名
objvzx_SysCommentEN.zxCommentId = objRow[convzx_SysComment.zxCommentId].ToString().Trim(); //评论Id
objvzx_SysCommentEN.CommentTable = objRow[convzx_SysComment.CommentTable] == DBNull.Value ? null : objRow[convzx_SysComment.CommentTable].ToString().Trim(); //评论表
objvzx_SysCommentEN.Comment = objRow[convzx_SysComment.Comment] == DBNull.Value ? null : objRow[convzx_SysComment.Comment].ToString().Trim(); //评论
objvzx_SysCommentEN.CommentTableId = objRow[convzx_SysComment.CommentTableId] == DBNull.Value ? null : objRow[convzx_SysComment.CommentTableId].ToString().Trim(); //评论表Id
objvzx_SysCommentEN.Score = objRow[convzx_SysComment.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_SysComment.Score].ToString().Trim()); //评分
objvzx_SysCommentEN.zxCommentTypeId = objRow[convzx_SysComment.zxCommentTypeId].ToString().Trim(); //评论类型Id
objvzx_SysCommentEN.ScoreType = objRow[convzx_SysComment.ScoreType] == DBNull.Value ? null : objRow[convzx_SysComment.ScoreType].ToString().Trim(); //评分类型
objvzx_SysCommentEN.ParentId = objRow[convzx_SysComment.ParentId].ToString().Trim(); //父Id
objvzx_SysCommentEN.TableKey = objRow[convzx_SysComment.TableKey] == DBNull.Value ? null : objRow[convzx_SysComment.TableKey].ToString().Trim(); //表主键
objvzx_SysCommentEN.UpdUser = objRow[convzx_SysComment.UpdUser] == DBNull.Value ? null : objRow[convzx_SysComment.UpdUser].ToString().Trim(); //修改人
objvzx_SysCommentEN.UpdDate = objRow[convzx_SysComment.UpdDate] == DBNull.Value ? null : objRow[convzx_SysComment.UpdDate].ToString().Trim(); //修改日期
objvzx_SysCommentEN.Memo = objRow[convzx_SysComment.Memo] == DBNull.Value ? null : objRow[convzx_SysComment.Memo].ToString().Trim(); //备注
objvzx_SysCommentEN.OkCount = objRow[convzx_SysComment.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_SysComment.OkCount].ToString().Trim()); //点赞统计
objvzx_SysCommentEN.PubParentId = objRow[convzx_SysComment.PubParentId] == DBNull.Value ? null : objRow[convzx_SysComment.PubParentId].ToString().Trim(); //公共父Id
objvzx_SysCommentEN.IdCurrEduCls = objRow[convzx_SysComment.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_SysComment.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_SysCommentEN.UserId = objRow[convzx_SysComment.UserId] == DBNull.Value ? null : objRow[convzx_SysComment.UserId].ToString().Trim(); //用户ID
objvzx_SysCommentEN.Month = objRow[convzx_SysComment.Month] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_SysComment.Month].ToString().Trim()); //月
objvzx_SysCommentEN.Week = objRow[convzx_SysComment.Week] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_SysComment.Week].ToString().Trim()); //周
objvzx_SysCommentEN.WeekTimeRange = objRow[convzx_SysComment.WeekTimeRange] == DBNull.Value ? null : objRow[convzx_SysComment.WeekTimeRange].ToString().Trim(); //WeekTimeRange
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvzx_SysCommentDA: GetObjLst)", objException.Message));
}
objvzx_SysCommentEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvzx_SysCommentEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvzx_SysCommentEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getvzx_SysComment(ref clsvzx_SysCommentEN objvzx_SysCommentEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SysCommentDA.GetSpecSQLObj();
strSQL = "Select * from vzx_SysComment where zxCommentId = " + "'"+ objvzx_SysCommentEN.zxCommentId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvzx_SysCommentEN.CommentTypeName = objDT.Rows[0][convzx_SysComment.CommentTypeName].ToString().Trim(); //评论类型名(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_SysCommentEN.zxCommentId = objDT.Rows[0][convzx_SysComment.zxCommentId].ToString().Trim(); //评论Id(字段类型:char,字段长度:10,是否可空:False)
 objvzx_SysCommentEN.CommentTable = objDT.Rows[0][convzx_SysComment.CommentTable].ToString().Trim(); //评论表(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_SysCommentEN.Comment = objDT.Rows[0][convzx_SysComment.Comment].ToString().Trim(); //评论(字段类型:varchar,字段长度:2000,是否可空:True)
 objvzx_SysCommentEN.CommentTableId = objDT.Rows[0][convzx_SysComment.CommentTableId].ToString().Trim(); //评论表Id(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_SysCommentEN.Score = TransNullToFloat(objDT.Rows[0][convzx_SysComment.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvzx_SysCommentEN.zxCommentTypeId = objDT.Rows[0][convzx_SysComment.zxCommentTypeId].ToString().Trim(); //评论类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvzx_SysCommentEN.ScoreType = objDT.Rows[0][convzx_SysComment.ScoreType].ToString().Trim(); //评分类型(字段类型:char,字段长度:1,是否可空:True)
 objvzx_SysCommentEN.ParentId = objDT.Rows[0][convzx_SysComment.ParentId].ToString().Trim(); //父Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvzx_SysCommentEN.TableKey = objDT.Rows[0][convzx_SysComment.TableKey].ToString().Trim(); //表主键(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_SysCommentEN.UpdUser = objDT.Rows[0][convzx_SysComment.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_SysCommentEN.UpdDate = objDT.Rows[0][convzx_SysComment.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_SysCommentEN.Memo = objDT.Rows[0][convzx_SysComment.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_SysCommentEN.OkCount = TransNullToInt(objDT.Rows[0][convzx_SysComment.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objvzx_SysCommentEN.PubParentId = objDT.Rows[0][convzx_SysComment.PubParentId].ToString().Trim(); //公共父Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_SysCommentEN.IdCurrEduCls = objDT.Rows[0][convzx_SysComment.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvzx_SysCommentEN.UserId = objDT.Rows[0][convzx_SysComment.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvzx_SysCommentEN.Month = TransNullToInt(objDT.Rows[0][convzx_SysComment.Month].ToString().Trim()); //月(字段类型:int,字段长度:4,是否可空:True)
 objvzx_SysCommentEN.Week = TransNullToInt(objDT.Rows[0][convzx_SysComment.Week].ToString().Trim()); //周(字段类型:int,字段长度:4,是否可空:True)
 objvzx_SysCommentEN.WeekTimeRange = objDT.Rows[0][convzx_SysComment.WeekTimeRange].ToString().Trim(); //WeekTimeRange(字段类型:varchar,字段长度:100,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvzx_SysCommentDA: Getvzx_SysComment)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strzxCommentId">表关键字</param>
 /// <returns>表对象</returns>
public clsvzx_SysCommentEN GetObjByzxCommentId(string strzxCommentId)
{
CheckPrimaryKey(strzxCommentId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SysCommentDA.GetSpecSQLObj();
strSQL = "Select * from vzx_SysComment where zxCommentId = " + "'"+ strzxCommentId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvzx_SysCommentEN objvzx_SysCommentEN = new clsvzx_SysCommentEN();
try
{
 objvzx_SysCommentEN.CommentTypeName = objRow[convzx_SysComment.CommentTypeName] == DBNull.Value ? null : objRow[convzx_SysComment.CommentTypeName].ToString().Trim(); //评论类型名(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_SysCommentEN.zxCommentId = objRow[convzx_SysComment.zxCommentId].ToString().Trim(); //评论Id(字段类型:char,字段长度:10,是否可空:False)
 objvzx_SysCommentEN.CommentTable = objRow[convzx_SysComment.CommentTable] == DBNull.Value ? null : objRow[convzx_SysComment.CommentTable].ToString().Trim(); //评论表(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_SysCommentEN.Comment = objRow[convzx_SysComment.Comment] == DBNull.Value ? null : objRow[convzx_SysComment.Comment].ToString().Trim(); //评论(字段类型:varchar,字段长度:2000,是否可空:True)
 objvzx_SysCommentEN.CommentTableId = objRow[convzx_SysComment.CommentTableId] == DBNull.Value ? null : objRow[convzx_SysComment.CommentTableId].ToString().Trim(); //评论表Id(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_SysCommentEN.Score = objRow[convzx_SysComment.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SysComment.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvzx_SysCommentEN.zxCommentTypeId = objRow[convzx_SysComment.zxCommentTypeId].ToString().Trim(); //评论类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvzx_SysCommentEN.ScoreType = objRow[convzx_SysComment.ScoreType] == DBNull.Value ? null : objRow[convzx_SysComment.ScoreType].ToString().Trim(); //评分类型(字段类型:char,字段长度:1,是否可空:True)
 objvzx_SysCommentEN.ParentId = objRow[convzx_SysComment.ParentId].ToString().Trim(); //父Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvzx_SysCommentEN.TableKey = objRow[convzx_SysComment.TableKey] == DBNull.Value ? null : objRow[convzx_SysComment.TableKey].ToString().Trim(); //表主键(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_SysCommentEN.UpdUser = objRow[convzx_SysComment.UpdUser] == DBNull.Value ? null : objRow[convzx_SysComment.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_SysCommentEN.UpdDate = objRow[convzx_SysComment.UpdDate] == DBNull.Value ? null : objRow[convzx_SysComment.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_SysCommentEN.Memo = objRow[convzx_SysComment.Memo] == DBNull.Value ? null : objRow[convzx_SysComment.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_SysCommentEN.OkCount = objRow[convzx_SysComment.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysComment.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objvzx_SysCommentEN.PubParentId = objRow[convzx_SysComment.PubParentId] == DBNull.Value ? null : objRow[convzx_SysComment.PubParentId].ToString().Trim(); //公共父Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_SysCommentEN.IdCurrEduCls = objRow[convzx_SysComment.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_SysComment.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvzx_SysCommentEN.UserId = objRow[convzx_SysComment.UserId] == DBNull.Value ? null : objRow[convzx_SysComment.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvzx_SysCommentEN.Month = objRow[convzx_SysComment.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysComment.Month].ToString().Trim()); //月(字段类型:int,字段长度:4,是否可空:True)
 objvzx_SysCommentEN.Week = objRow[convzx_SysComment.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysComment.Week].ToString().Trim()); //周(字段类型:int,字段长度:4,是否可空:True)
 objvzx_SysCommentEN.WeekTimeRange = objRow[convzx_SysComment.WeekTimeRange] == DBNull.Value ? null : objRow[convzx_SysComment.WeekTimeRange].ToString().Trim(); //WeekTimeRange(字段类型:varchar,字段长度:100,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvzx_SysCommentDA: GetObjByzxCommentId)", objException.Message));
}
return objvzx_SysCommentEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvzx_SysCommentEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvzx_SysCommentDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SysCommentDA.GetSpecSQLObj();
strSQL = "Select * from vzx_SysComment where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvzx_SysCommentEN objvzx_SysCommentEN = new clsvzx_SysCommentEN()
{
CommentTypeName = objRow[convzx_SysComment.CommentTypeName] == DBNull.Value ? null : objRow[convzx_SysComment.CommentTypeName].ToString().Trim(), //评论类型名
zxCommentId = objRow[convzx_SysComment.zxCommentId].ToString().Trim(), //评论Id
CommentTable = objRow[convzx_SysComment.CommentTable] == DBNull.Value ? null : objRow[convzx_SysComment.CommentTable].ToString().Trim(), //评论表
Comment = objRow[convzx_SysComment.Comment] == DBNull.Value ? null : objRow[convzx_SysComment.Comment].ToString().Trim(), //评论
CommentTableId = objRow[convzx_SysComment.CommentTableId] == DBNull.Value ? null : objRow[convzx_SysComment.CommentTableId].ToString().Trim(), //评论表Id
Score = objRow[convzx_SysComment.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_SysComment.Score].ToString().Trim()), //评分
zxCommentTypeId = objRow[convzx_SysComment.zxCommentTypeId].ToString().Trim(), //评论类型Id
ScoreType = objRow[convzx_SysComment.ScoreType] == DBNull.Value ? null : objRow[convzx_SysComment.ScoreType].ToString().Trim(), //评分类型
ParentId = objRow[convzx_SysComment.ParentId].ToString().Trim(), //父Id
TableKey = objRow[convzx_SysComment.TableKey] == DBNull.Value ? null : objRow[convzx_SysComment.TableKey].ToString().Trim(), //表主键
UpdUser = objRow[convzx_SysComment.UpdUser] == DBNull.Value ? null : objRow[convzx_SysComment.UpdUser].ToString().Trim(), //修改人
UpdDate = objRow[convzx_SysComment.UpdDate] == DBNull.Value ? null : objRow[convzx_SysComment.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[convzx_SysComment.Memo] == DBNull.Value ? null : objRow[convzx_SysComment.Memo].ToString().Trim(), //备注
OkCount = objRow[convzx_SysComment.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_SysComment.OkCount].ToString().Trim()), //点赞统计
PubParentId = objRow[convzx_SysComment.PubParentId] == DBNull.Value ? null : objRow[convzx_SysComment.PubParentId].ToString().Trim(), //公共父Id
IdCurrEduCls = objRow[convzx_SysComment.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_SysComment.IdCurrEduCls].ToString().Trim(), //教学班流水号
UserId = objRow[convzx_SysComment.UserId] == DBNull.Value ? null : objRow[convzx_SysComment.UserId].ToString().Trim(), //用户ID
Month = objRow[convzx_SysComment.Month] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_SysComment.Month].ToString().Trim()), //月
Week = objRow[convzx_SysComment.Week] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_SysComment.Week].ToString().Trim()), //周
WeekTimeRange = objRow[convzx_SysComment.WeekTimeRange] == DBNull.Value ? null : objRow[convzx_SysComment.WeekTimeRange].ToString().Trim() //WeekTimeRange
};
objvzx_SysCommentEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvzx_SysCommentEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvzx_SysCommentDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvzx_SysCommentEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvzx_SysCommentEN objvzx_SysCommentEN = new clsvzx_SysCommentEN();
try
{
objvzx_SysCommentEN.CommentTypeName = objRow[convzx_SysComment.CommentTypeName] == DBNull.Value ? null : objRow[convzx_SysComment.CommentTypeName].ToString().Trim(); //评论类型名
objvzx_SysCommentEN.zxCommentId = objRow[convzx_SysComment.zxCommentId].ToString().Trim(); //评论Id
objvzx_SysCommentEN.CommentTable = objRow[convzx_SysComment.CommentTable] == DBNull.Value ? null : objRow[convzx_SysComment.CommentTable].ToString().Trim(); //评论表
objvzx_SysCommentEN.Comment = objRow[convzx_SysComment.Comment] == DBNull.Value ? null : objRow[convzx_SysComment.Comment].ToString().Trim(); //评论
objvzx_SysCommentEN.CommentTableId = objRow[convzx_SysComment.CommentTableId] == DBNull.Value ? null : objRow[convzx_SysComment.CommentTableId].ToString().Trim(); //评论表Id
objvzx_SysCommentEN.Score = objRow[convzx_SysComment.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_SysComment.Score].ToString().Trim()); //评分
objvzx_SysCommentEN.zxCommentTypeId = objRow[convzx_SysComment.zxCommentTypeId].ToString().Trim(); //评论类型Id
objvzx_SysCommentEN.ScoreType = objRow[convzx_SysComment.ScoreType] == DBNull.Value ? null : objRow[convzx_SysComment.ScoreType].ToString().Trim(); //评分类型
objvzx_SysCommentEN.ParentId = objRow[convzx_SysComment.ParentId].ToString().Trim(); //父Id
objvzx_SysCommentEN.TableKey = objRow[convzx_SysComment.TableKey] == DBNull.Value ? null : objRow[convzx_SysComment.TableKey].ToString().Trim(); //表主键
objvzx_SysCommentEN.UpdUser = objRow[convzx_SysComment.UpdUser] == DBNull.Value ? null : objRow[convzx_SysComment.UpdUser].ToString().Trim(); //修改人
objvzx_SysCommentEN.UpdDate = objRow[convzx_SysComment.UpdDate] == DBNull.Value ? null : objRow[convzx_SysComment.UpdDate].ToString().Trim(); //修改日期
objvzx_SysCommentEN.Memo = objRow[convzx_SysComment.Memo] == DBNull.Value ? null : objRow[convzx_SysComment.Memo].ToString().Trim(); //备注
objvzx_SysCommentEN.OkCount = objRow[convzx_SysComment.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_SysComment.OkCount].ToString().Trim()); //点赞统计
objvzx_SysCommentEN.PubParentId = objRow[convzx_SysComment.PubParentId] == DBNull.Value ? null : objRow[convzx_SysComment.PubParentId].ToString().Trim(); //公共父Id
objvzx_SysCommentEN.IdCurrEduCls = objRow[convzx_SysComment.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_SysComment.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_SysCommentEN.UserId = objRow[convzx_SysComment.UserId] == DBNull.Value ? null : objRow[convzx_SysComment.UserId].ToString().Trim(); //用户ID
objvzx_SysCommentEN.Month = objRow[convzx_SysComment.Month] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_SysComment.Month].ToString().Trim()); //月
objvzx_SysCommentEN.Week = objRow[convzx_SysComment.Week] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_SysComment.Week].ToString().Trim()); //周
objvzx_SysCommentEN.WeekTimeRange = objRow[convzx_SysComment.WeekTimeRange] == DBNull.Value ? null : objRow[convzx_SysComment.WeekTimeRange].ToString().Trim(); //WeekTimeRange
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvzx_SysCommentDA: GetObjByDataRowvzx_SysComment)", objException.Message));
}
objvzx_SysCommentEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvzx_SysCommentEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvzx_SysCommentEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvzx_SysCommentEN objvzx_SysCommentEN = new clsvzx_SysCommentEN();
try
{
objvzx_SysCommentEN.CommentTypeName = objRow[convzx_SysComment.CommentTypeName] == DBNull.Value ? null : objRow[convzx_SysComment.CommentTypeName].ToString().Trim(); //评论类型名
objvzx_SysCommentEN.zxCommentId = objRow[convzx_SysComment.zxCommentId].ToString().Trim(); //评论Id
objvzx_SysCommentEN.CommentTable = objRow[convzx_SysComment.CommentTable] == DBNull.Value ? null : objRow[convzx_SysComment.CommentTable].ToString().Trim(); //评论表
objvzx_SysCommentEN.Comment = objRow[convzx_SysComment.Comment] == DBNull.Value ? null : objRow[convzx_SysComment.Comment].ToString().Trim(); //评论
objvzx_SysCommentEN.CommentTableId = objRow[convzx_SysComment.CommentTableId] == DBNull.Value ? null : objRow[convzx_SysComment.CommentTableId].ToString().Trim(); //评论表Id
objvzx_SysCommentEN.Score = objRow[convzx_SysComment.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_SysComment.Score].ToString().Trim()); //评分
objvzx_SysCommentEN.zxCommentTypeId = objRow[convzx_SysComment.zxCommentTypeId].ToString().Trim(); //评论类型Id
objvzx_SysCommentEN.ScoreType = objRow[convzx_SysComment.ScoreType] == DBNull.Value ? null : objRow[convzx_SysComment.ScoreType].ToString().Trim(); //评分类型
objvzx_SysCommentEN.ParentId = objRow[convzx_SysComment.ParentId].ToString().Trim(); //父Id
objvzx_SysCommentEN.TableKey = objRow[convzx_SysComment.TableKey] == DBNull.Value ? null : objRow[convzx_SysComment.TableKey].ToString().Trim(); //表主键
objvzx_SysCommentEN.UpdUser = objRow[convzx_SysComment.UpdUser] == DBNull.Value ? null : objRow[convzx_SysComment.UpdUser].ToString().Trim(); //修改人
objvzx_SysCommentEN.UpdDate = objRow[convzx_SysComment.UpdDate] == DBNull.Value ? null : objRow[convzx_SysComment.UpdDate].ToString().Trim(); //修改日期
objvzx_SysCommentEN.Memo = objRow[convzx_SysComment.Memo] == DBNull.Value ? null : objRow[convzx_SysComment.Memo].ToString().Trim(); //备注
objvzx_SysCommentEN.OkCount = objRow[convzx_SysComment.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_SysComment.OkCount].ToString().Trim()); //点赞统计
objvzx_SysCommentEN.PubParentId = objRow[convzx_SysComment.PubParentId] == DBNull.Value ? null : objRow[convzx_SysComment.PubParentId].ToString().Trim(); //公共父Id
objvzx_SysCommentEN.IdCurrEduCls = objRow[convzx_SysComment.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_SysComment.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_SysCommentEN.UserId = objRow[convzx_SysComment.UserId] == DBNull.Value ? null : objRow[convzx_SysComment.UserId].ToString().Trim(); //用户ID
objvzx_SysCommentEN.Month = objRow[convzx_SysComment.Month] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_SysComment.Month].ToString().Trim()); //月
objvzx_SysCommentEN.Week = objRow[convzx_SysComment.Week] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_SysComment.Week].ToString().Trim()); //周
objvzx_SysCommentEN.WeekTimeRange = objRow[convzx_SysComment.WeekTimeRange] == DBNull.Value ? null : objRow[convzx_SysComment.WeekTimeRange].ToString().Trim(); //WeekTimeRange
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvzx_SysCommentDA: GetObjByDataRow)", objException.Message));
}
objvzx_SysCommentEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvzx_SysCommentEN;
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
objSQL = clsvzx_SysCommentDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvzx_SysCommentEN._CurrTabName, convzx_SysComment.zxCommentId, 10, "");
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
objSQL = clsvzx_SysCommentDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvzx_SysCommentEN._CurrTabName, convzx_SysComment.zxCommentId, 10, strPrefix);
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
 objSQL = clsvzx_SysCommentDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select zxCommentId from vzx_SysComment where " + strCondition;
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
 objSQL = clsvzx_SysCommentDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select zxCommentId from vzx_SysComment where " + strCondition;
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
 /// <param name = "strzxCommentId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strzxCommentId)
{
CheckPrimaryKey(strzxCommentId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SysCommentDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vzx_SysComment", "zxCommentId = " + "'"+ strzxCommentId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvzx_SysCommentDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SysCommentDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vzx_SysComment", strCondition))
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
objSQL = clsvzx_SysCommentDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vzx_SysComment");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvzx_SysCommentENS">源对象</param>
 /// <param name = "objvzx_SysCommentENT">目标对象</param>
public void CopyTo(clsvzx_SysCommentEN objvzx_SysCommentENS, clsvzx_SysCommentEN objvzx_SysCommentENT)
{
objvzx_SysCommentENT.CommentTypeName = objvzx_SysCommentENS.CommentTypeName; //评论类型名
objvzx_SysCommentENT.zxCommentId = objvzx_SysCommentENS.zxCommentId; //评论Id
objvzx_SysCommentENT.CommentTable = objvzx_SysCommentENS.CommentTable; //评论表
objvzx_SysCommentENT.Comment = objvzx_SysCommentENS.Comment; //评论
objvzx_SysCommentENT.CommentTableId = objvzx_SysCommentENS.CommentTableId; //评论表Id
objvzx_SysCommentENT.Score = objvzx_SysCommentENS.Score; //评分
objvzx_SysCommentENT.zxCommentTypeId = objvzx_SysCommentENS.zxCommentTypeId; //评论类型Id
objvzx_SysCommentENT.ScoreType = objvzx_SysCommentENS.ScoreType; //评分类型
objvzx_SysCommentENT.ParentId = objvzx_SysCommentENS.ParentId; //父Id
objvzx_SysCommentENT.TableKey = objvzx_SysCommentENS.TableKey; //表主键
objvzx_SysCommentENT.UpdUser = objvzx_SysCommentENS.UpdUser; //修改人
objvzx_SysCommentENT.UpdDate = objvzx_SysCommentENS.UpdDate; //修改日期
objvzx_SysCommentENT.Memo = objvzx_SysCommentENS.Memo; //备注
objvzx_SysCommentENT.OkCount = objvzx_SysCommentENS.OkCount; //点赞统计
objvzx_SysCommentENT.PubParentId = objvzx_SysCommentENS.PubParentId; //公共父Id
objvzx_SysCommentENT.IdCurrEduCls = objvzx_SysCommentENS.IdCurrEduCls; //教学班流水号
objvzx_SysCommentENT.UserId = objvzx_SysCommentENS.UserId; //用户ID
objvzx_SysCommentENT.Month = objvzx_SysCommentENS.Month; //月
objvzx_SysCommentENT.Week = objvzx_SysCommentENS.Week; //周
objvzx_SysCommentENT.WeekTimeRange = objvzx_SysCommentENS.WeekTimeRange; //WeekTimeRange
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvzx_SysCommentEN objvzx_SysCommentEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvzx_SysCommentEN.CommentTypeName, 50, convzx_SysComment.CommentTypeName);
clsCheckSql.CheckFieldLen(objvzx_SysCommentEN.zxCommentId, 10, convzx_SysComment.zxCommentId);
clsCheckSql.CheckFieldLen(objvzx_SysCommentEN.CommentTable, 50, convzx_SysComment.CommentTable);
clsCheckSql.CheckFieldLen(objvzx_SysCommentEN.Comment, 2000, convzx_SysComment.Comment);
clsCheckSql.CheckFieldLen(objvzx_SysCommentEN.CommentTableId, 50, convzx_SysComment.CommentTableId);
clsCheckSql.CheckFieldLen(objvzx_SysCommentEN.zxCommentTypeId, 2, convzx_SysComment.zxCommentTypeId);
clsCheckSql.CheckFieldLen(objvzx_SysCommentEN.ScoreType, 1, convzx_SysComment.ScoreType);
clsCheckSql.CheckFieldLen(objvzx_SysCommentEN.ParentId, 20, convzx_SysComment.ParentId);
clsCheckSql.CheckFieldLen(objvzx_SysCommentEN.TableKey, 20, convzx_SysComment.TableKey);
clsCheckSql.CheckFieldLen(objvzx_SysCommentEN.UpdUser, 20, convzx_SysComment.UpdUser);
clsCheckSql.CheckFieldLen(objvzx_SysCommentEN.UpdDate, 20, convzx_SysComment.UpdDate);
clsCheckSql.CheckFieldLen(objvzx_SysCommentEN.Memo, 1000, convzx_SysComment.Memo);
clsCheckSql.CheckFieldLen(objvzx_SysCommentEN.PubParentId, 20, convzx_SysComment.PubParentId);
clsCheckSql.CheckFieldLen(objvzx_SysCommentEN.IdCurrEduCls, 8, convzx_SysComment.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objvzx_SysCommentEN.UserId, 18, convzx_SysComment.UserId);
clsCheckSql.CheckFieldLen(objvzx_SysCommentEN.WeekTimeRange, 100, convzx_SysComment.WeekTimeRange);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvzx_SysCommentEN.CommentTypeName, convzx_SysComment.CommentTypeName);
clsCheckSql.CheckSqlInjection4Field(objvzx_SysCommentEN.zxCommentId, convzx_SysComment.zxCommentId);
clsCheckSql.CheckSqlInjection4Field(objvzx_SysCommentEN.CommentTable, convzx_SysComment.CommentTable);
clsCheckSql.CheckSqlInjection4Field(objvzx_SysCommentEN.Comment, convzx_SysComment.Comment);
clsCheckSql.CheckSqlInjection4Field(objvzx_SysCommentEN.CommentTableId, convzx_SysComment.CommentTableId);
clsCheckSql.CheckSqlInjection4Field(objvzx_SysCommentEN.zxCommentTypeId, convzx_SysComment.zxCommentTypeId);
clsCheckSql.CheckSqlInjection4Field(objvzx_SysCommentEN.ScoreType, convzx_SysComment.ScoreType);
clsCheckSql.CheckSqlInjection4Field(objvzx_SysCommentEN.ParentId, convzx_SysComment.ParentId);
clsCheckSql.CheckSqlInjection4Field(objvzx_SysCommentEN.TableKey, convzx_SysComment.TableKey);
clsCheckSql.CheckSqlInjection4Field(objvzx_SysCommentEN.UpdUser, convzx_SysComment.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvzx_SysCommentEN.UpdDate, convzx_SysComment.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvzx_SysCommentEN.Memo, convzx_SysComment.Memo);
clsCheckSql.CheckSqlInjection4Field(objvzx_SysCommentEN.PubParentId, convzx_SysComment.PubParentId);
clsCheckSql.CheckSqlInjection4Field(objvzx_SysCommentEN.IdCurrEduCls, convzx_SysComment.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objvzx_SysCommentEN.UserId, convzx_SysComment.UserId);
clsCheckSql.CheckSqlInjection4Field(objvzx_SysCommentEN.WeekTimeRange, convzx_SysComment.WeekTimeRange);
//检查外键字段长度
 objvzx_SysCommentEN._IsCheckProperty = true;
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
 objSQL = clsvzx_SysCommentDA.GetSpecSQLObj();
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
 objSQL = clsvzx_SysCommentDA.GetSpecSQLObj();
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
 objSQL = clsvzx_SysCommentDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvzx_SysCommentEN._CurrTabName);
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
 objSQL = clsvzx_SysCommentDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvzx_SysCommentEN._CurrTabName, strCondition);
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
 objSQL = clsvzx_SysCommentDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}