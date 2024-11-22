
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSysCountDA
 表名:vSysCount(01120626)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:49:45
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
 /// 数据统计视图(vSysCount)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvSysCountDA : clsCommBase4DA
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
 return clsvSysCountEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvSysCountEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvSysCountEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvSysCountEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvSysCountEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strCountId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strCountId)
{
strCountId = strCountId.Replace("'", "''");
if (strCountId.Length > 10)
{
throw new Exception("(errid:Data000001)在表:vSysCount中,检查关键字,长度不正确!(clsvSysCountDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strCountId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vSysCount中,关键字不能为空 或 null!(clsvSysCountDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCountId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvSysCountDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvSysCountDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysCountDA.GetSpecSQLObj();
strSQL = "Select * from vSysCount where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vSysCount(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvSysCountDA: GetDataTable_vSysCount)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysCountDA.GetSpecSQLObj();
strSQL = "Select * from vSysCount where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvSysCountDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysCountDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvSysCountDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysCountDA.GetSpecSQLObj();
strSQL = "Select * from vSysCount where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvSysCountDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysCountDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvSysCountDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysCountDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vSysCount where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vSysCount where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvSysCountDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysCountDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vSysCount where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvSysCountDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysCountDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vSysCount.* from vSysCount Left Join {1} on {2} where {3} and vSysCount.CountId not in (Select top {5} vSysCount.CountId from vSysCount Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vSysCount where {1} and CountId not in (Select top {2} CountId from vSysCount where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vSysCount where {1} and CountId not in (Select top {3} CountId from vSysCount where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvSysCountDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysCountDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vSysCount.* from vSysCount Left Join {1} on {2} where {3} and vSysCount.CountId not in (Select top {5} vSysCount.CountId from vSysCount Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vSysCount where {1} and CountId not in (Select top {2} CountId from vSysCount where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vSysCount where {1} and CountId not in (Select top {3} CountId from vSysCount where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvSysCountEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvSysCountDA:GetObjLst)", objException.Message));
}
List<clsvSysCountEN> arrObjLst = new List<clsvSysCountEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysCountDA.GetSpecSQLObj();
strSQL = "Select * from vSysCount where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysCountEN objvSysCountEN = new clsvSysCountEN();
try
{
objvSysCountEN.CountId = objRow[convSysCount.CountId].ToString().Trim(); //CountId
objvSysCountEN.CountTypeId = objRow[convSysCount.CountTypeId] == DBNull.Value ? null : objRow[convSysCount.CountTypeId].ToString().Trim(); //CountTypeId
objvSysCountEN.CommentTypeName = objRow[convSysCount.CommentTypeName] == DBNull.Value ? null : objRow[convSysCount.CommentTypeName].ToString().Trim(); //评论类型名
objvSysCountEN.CommentTable = objRow[convSysCount.CommentTable] == DBNull.Value ? null : objRow[convSysCount.CommentTable].ToString().Trim(); //评论表
objvSysCountEN.OkCount = objRow[convSysCount.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSysCount.OkCount].ToString().Trim()); //点赞统计
objvSysCountEN.CommentTableId = objRow[convSysCount.CommentTableId] == DBNull.Value ? null : objRow[convSysCount.CommentTableId].ToString().Trim(); //评论表Id
objvSysCountEN.CollectionCount = objRow[convSysCount.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convSysCount.CollectionCount].ToString().Trim()); //收藏数量
objvSysCountEN.DownloadCount = objRow[convSysCount.DownloadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSysCount.DownloadCount].ToString().Trim()); //下载数
objvSysCountEN.AttachmentCount = objRow[convSysCount.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSysCount.AttachmentCount].ToString().Trim()); //附件计数
objvSysCountEN.CommentCount = objRow[convSysCount.CommentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSysCount.CommentCount].ToString().Trim()); //评论数
objvSysCountEN.Score = objRow[convSysCount.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convSysCount.Score].ToString().Trim()); //评分
objvSysCountEN.StuScore = objRow[convSysCount.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convSysCount.StuScore].ToString().Trim()); //学生平均分
objvSysCountEN.TeaScore = objRow[convSysCount.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convSysCount.TeaScore].ToString().Trim()); //教师评分
objvSysCountEN.TableKey = objRow[convSysCount.TableKey] == DBNull.Value ? null : objRow[convSysCount.TableKey].ToString().Trim(); //表主键
objvSysCountEN.ParentId = objRow[convSysCount.ParentId] == DBNull.Value ? null : objRow[convSysCount.ParentId].ToString().Trim(); //父Id
objvSysCountEN.UpdUser = objRow[convSysCount.UpdUser] == DBNull.Value ? null : objRow[convSysCount.UpdUser].ToString().Trim(); //修改人
objvSysCountEN.UpdDate = objRow[convSysCount.UpdDate] == DBNull.Value ? null : objRow[convSysCount.UpdDate].ToString().Trim(); //修改日期
objvSysCountEN.Memo = objRow[convSysCount.Memo] == DBNull.Value ? null : objRow[convSysCount.Memo].ToString().Trim(); //备注
objvSysCountEN.PaperRWCount = objRow[convSysCount.PaperRWCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSysCount.PaperRWCount].ToString().Trim()); //PaperRWCount
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvSysCountDA: GetObjLst)", objException.Message));
}
objvSysCountEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvSysCountEN);
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
public List<clsvSysCountEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvSysCountDA:GetObjLstByTabName)", objException.Message));
}
List<clsvSysCountEN> arrObjLst = new List<clsvSysCountEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysCountDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysCountEN objvSysCountEN = new clsvSysCountEN();
try
{
objvSysCountEN.CountId = objRow[convSysCount.CountId].ToString().Trim(); //CountId
objvSysCountEN.CountTypeId = objRow[convSysCount.CountTypeId] == DBNull.Value ? null : objRow[convSysCount.CountTypeId].ToString().Trim(); //CountTypeId
objvSysCountEN.CommentTypeName = objRow[convSysCount.CommentTypeName] == DBNull.Value ? null : objRow[convSysCount.CommentTypeName].ToString().Trim(); //评论类型名
objvSysCountEN.CommentTable = objRow[convSysCount.CommentTable] == DBNull.Value ? null : objRow[convSysCount.CommentTable].ToString().Trim(); //评论表
objvSysCountEN.OkCount = objRow[convSysCount.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSysCount.OkCount].ToString().Trim()); //点赞统计
objvSysCountEN.CommentTableId = objRow[convSysCount.CommentTableId] == DBNull.Value ? null : objRow[convSysCount.CommentTableId].ToString().Trim(); //评论表Id
objvSysCountEN.CollectionCount = objRow[convSysCount.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convSysCount.CollectionCount].ToString().Trim()); //收藏数量
objvSysCountEN.DownloadCount = objRow[convSysCount.DownloadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSysCount.DownloadCount].ToString().Trim()); //下载数
objvSysCountEN.AttachmentCount = objRow[convSysCount.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSysCount.AttachmentCount].ToString().Trim()); //附件计数
objvSysCountEN.CommentCount = objRow[convSysCount.CommentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSysCount.CommentCount].ToString().Trim()); //评论数
objvSysCountEN.Score = objRow[convSysCount.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convSysCount.Score].ToString().Trim()); //评分
objvSysCountEN.StuScore = objRow[convSysCount.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convSysCount.StuScore].ToString().Trim()); //学生平均分
objvSysCountEN.TeaScore = objRow[convSysCount.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convSysCount.TeaScore].ToString().Trim()); //教师评分
objvSysCountEN.TableKey = objRow[convSysCount.TableKey] == DBNull.Value ? null : objRow[convSysCount.TableKey].ToString().Trim(); //表主键
objvSysCountEN.ParentId = objRow[convSysCount.ParentId] == DBNull.Value ? null : objRow[convSysCount.ParentId].ToString().Trim(); //父Id
objvSysCountEN.UpdUser = objRow[convSysCount.UpdUser] == DBNull.Value ? null : objRow[convSysCount.UpdUser].ToString().Trim(); //修改人
objvSysCountEN.UpdDate = objRow[convSysCount.UpdDate] == DBNull.Value ? null : objRow[convSysCount.UpdDate].ToString().Trim(); //修改日期
objvSysCountEN.Memo = objRow[convSysCount.Memo] == DBNull.Value ? null : objRow[convSysCount.Memo].ToString().Trim(); //备注
objvSysCountEN.PaperRWCount = objRow[convSysCount.PaperRWCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSysCount.PaperRWCount].ToString().Trim()); //PaperRWCount
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvSysCountDA: GetObjLst)", objException.Message));
}
objvSysCountEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvSysCountEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvSysCountEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvSysCount(ref clsvSysCountEN objvSysCountEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysCountDA.GetSpecSQLObj();
strSQL = "Select * from vSysCount where CountId = " + "'"+ objvSysCountEN.CountId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvSysCountEN.CountId = objDT.Rows[0][convSysCount.CountId].ToString().Trim(); //CountId(字段类型:char,字段长度:10,是否可空:False)
 objvSysCountEN.CountTypeId = objDT.Rows[0][convSysCount.CountTypeId].ToString().Trim(); //CountTypeId(字段类型:char,字段长度:2,是否可空:True)
 objvSysCountEN.CommentTypeName = objDT.Rows[0][convSysCount.CommentTypeName].ToString().Trim(); //评论类型名(字段类型:varchar,字段长度:50,是否可空:True)
 objvSysCountEN.CommentTable = objDT.Rows[0][convSysCount.CommentTable].ToString().Trim(); //评论表(字段类型:varchar,字段长度:50,是否可空:True)
 objvSysCountEN.OkCount = TransNullToInt(objDT.Rows[0][convSysCount.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objvSysCountEN.CommentTableId = objDT.Rows[0][convSysCount.CommentTableId].ToString().Trim(); //评论表Id(字段类型:varchar,字段长度:50,是否可空:True)
 objvSysCountEN.CollectionCount = TransNullToInt(objDT.Rows[0][convSysCount.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvSysCountEN.DownloadCount = TransNullToInt(objDT.Rows[0][convSysCount.DownloadCount].ToString().Trim()); //下载数(字段类型:int,字段长度:4,是否可空:True)
 objvSysCountEN.AttachmentCount = TransNullToInt(objDT.Rows[0][convSysCount.AttachmentCount].ToString().Trim()); //附件计数(字段类型:int,字段长度:4,是否可空:True)
 objvSysCountEN.CommentCount = TransNullToInt(objDT.Rows[0][convSysCount.CommentCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objvSysCountEN.Score = TransNullToFloat(objDT.Rows[0][convSysCount.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvSysCountEN.StuScore = TransNullToFloat(objDT.Rows[0][convSysCount.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objvSysCountEN.TeaScore = TransNullToFloat(objDT.Rows[0][convSysCount.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objvSysCountEN.TableKey = objDT.Rows[0][convSysCount.TableKey].ToString().Trim(); //表主键(字段类型:varchar,字段长度:20,是否可空:True)
 objvSysCountEN.ParentId = objDT.Rows[0][convSysCount.ParentId].ToString().Trim(); //父Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvSysCountEN.UpdUser = objDT.Rows[0][convSysCount.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvSysCountEN.UpdDate = objDT.Rows[0][convSysCount.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvSysCountEN.Memo = objDT.Rows[0][convSysCount.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvSysCountEN.PaperRWCount = TransNullToInt(objDT.Rows[0][convSysCount.PaperRWCount].ToString().Trim()); //PaperRWCount(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvSysCountDA: GetvSysCount)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strCountId">表关键字</param>
 /// <returns>表对象</returns>
public clsvSysCountEN GetObjByCountId(string strCountId)
{
CheckPrimaryKey(strCountId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysCountDA.GetSpecSQLObj();
strSQL = "Select * from vSysCount where CountId = " + "'"+ strCountId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvSysCountEN objvSysCountEN = new clsvSysCountEN();
try
{
 objvSysCountEN.CountId = objRow[convSysCount.CountId].ToString().Trim(); //CountId(字段类型:char,字段长度:10,是否可空:False)
 objvSysCountEN.CountTypeId = objRow[convSysCount.CountTypeId] == DBNull.Value ? null : objRow[convSysCount.CountTypeId].ToString().Trim(); //CountTypeId(字段类型:char,字段长度:2,是否可空:True)
 objvSysCountEN.CommentTypeName = objRow[convSysCount.CommentTypeName] == DBNull.Value ? null : objRow[convSysCount.CommentTypeName].ToString().Trim(); //评论类型名(字段类型:varchar,字段长度:50,是否可空:True)
 objvSysCountEN.CommentTable = objRow[convSysCount.CommentTable] == DBNull.Value ? null : objRow[convSysCount.CommentTable].ToString().Trim(); //评论表(字段类型:varchar,字段长度:50,是否可空:True)
 objvSysCountEN.OkCount = objRow[convSysCount.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysCount.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objvSysCountEN.CommentTableId = objRow[convSysCount.CommentTableId] == DBNull.Value ? null : objRow[convSysCount.CommentTableId].ToString().Trim(); //评论表Id(字段类型:varchar,字段长度:50,是否可空:True)
 objvSysCountEN.CollectionCount = objRow[convSysCount.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysCount.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvSysCountEN.DownloadCount = objRow[convSysCount.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysCount.DownloadCount].ToString().Trim()); //下载数(字段类型:int,字段长度:4,是否可空:True)
 objvSysCountEN.AttachmentCount = objRow[convSysCount.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysCount.AttachmentCount].ToString().Trim()); //附件计数(字段类型:int,字段长度:4,是否可空:True)
 objvSysCountEN.CommentCount = objRow[convSysCount.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysCount.CommentCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objvSysCountEN.Score = objRow[convSysCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysCount.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvSysCountEN.StuScore = objRow[convSysCount.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysCount.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objvSysCountEN.TeaScore = objRow[convSysCount.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysCount.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objvSysCountEN.TableKey = objRow[convSysCount.TableKey] == DBNull.Value ? null : objRow[convSysCount.TableKey].ToString().Trim(); //表主键(字段类型:varchar,字段长度:20,是否可空:True)
 objvSysCountEN.ParentId = objRow[convSysCount.ParentId] == DBNull.Value ? null : objRow[convSysCount.ParentId].ToString().Trim(); //父Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvSysCountEN.UpdUser = objRow[convSysCount.UpdUser] == DBNull.Value ? null : objRow[convSysCount.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvSysCountEN.UpdDate = objRow[convSysCount.UpdDate] == DBNull.Value ? null : objRow[convSysCount.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvSysCountEN.Memo = objRow[convSysCount.Memo] == DBNull.Value ? null : objRow[convSysCount.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvSysCountEN.PaperRWCount = objRow[convSysCount.PaperRWCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysCount.PaperRWCount].ToString().Trim()); //PaperRWCount(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvSysCountDA: GetObjByCountId)", objException.Message));
}
return objvSysCountEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvSysCountEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvSysCountDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysCountDA.GetSpecSQLObj();
strSQL = "Select * from vSysCount where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvSysCountEN objvSysCountEN = new clsvSysCountEN()
{
CountId = objRow[convSysCount.CountId].ToString().Trim(), //CountId
CountTypeId = objRow[convSysCount.CountTypeId] == DBNull.Value ? null : objRow[convSysCount.CountTypeId].ToString().Trim(), //CountTypeId
CommentTypeName = objRow[convSysCount.CommentTypeName] == DBNull.Value ? null : objRow[convSysCount.CommentTypeName].ToString().Trim(), //评论类型名
CommentTable = objRow[convSysCount.CommentTable] == DBNull.Value ? null : objRow[convSysCount.CommentTable].ToString().Trim(), //评论表
OkCount = objRow[convSysCount.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSysCount.OkCount].ToString().Trim()), //点赞统计
CommentTableId = objRow[convSysCount.CommentTableId] == DBNull.Value ? null : objRow[convSysCount.CommentTableId].ToString().Trim(), //评论表Id
CollectionCount = objRow[convSysCount.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convSysCount.CollectionCount].ToString().Trim()), //收藏数量
DownloadCount = objRow[convSysCount.DownloadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSysCount.DownloadCount].ToString().Trim()), //下载数
AttachmentCount = objRow[convSysCount.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSysCount.AttachmentCount].ToString().Trim()), //附件计数
CommentCount = objRow[convSysCount.CommentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSysCount.CommentCount].ToString().Trim()), //评论数
Score = objRow[convSysCount.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convSysCount.Score].ToString().Trim()), //评分
StuScore = objRow[convSysCount.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convSysCount.StuScore].ToString().Trim()), //学生平均分
TeaScore = objRow[convSysCount.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convSysCount.TeaScore].ToString().Trim()), //教师评分
TableKey = objRow[convSysCount.TableKey] == DBNull.Value ? null : objRow[convSysCount.TableKey].ToString().Trim(), //表主键
ParentId = objRow[convSysCount.ParentId] == DBNull.Value ? null : objRow[convSysCount.ParentId].ToString().Trim(), //父Id
UpdUser = objRow[convSysCount.UpdUser] == DBNull.Value ? null : objRow[convSysCount.UpdUser].ToString().Trim(), //修改人
UpdDate = objRow[convSysCount.UpdDate] == DBNull.Value ? null : objRow[convSysCount.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[convSysCount.Memo] == DBNull.Value ? null : objRow[convSysCount.Memo].ToString().Trim(), //备注
PaperRWCount = objRow[convSysCount.PaperRWCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSysCount.PaperRWCount].ToString().Trim()) //PaperRWCount
};
objvSysCountEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvSysCountEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvSysCountDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvSysCountEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvSysCountEN objvSysCountEN = new clsvSysCountEN();
try
{
objvSysCountEN.CountId = objRow[convSysCount.CountId].ToString().Trim(); //CountId
objvSysCountEN.CountTypeId = objRow[convSysCount.CountTypeId] == DBNull.Value ? null : objRow[convSysCount.CountTypeId].ToString().Trim(); //CountTypeId
objvSysCountEN.CommentTypeName = objRow[convSysCount.CommentTypeName] == DBNull.Value ? null : objRow[convSysCount.CommentTypeName].ToString().Trim(); //评论类型名
objvSysCountEN.CommentTable = objRow[convSysCount.CommentTable] == DBNull.Value ? null : objRow[convSysCount.CommentTable].ToString().Trim(); //评论表
objvSysCountEN.OkCount = objRow[convSysCount.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSysCount.OkCount].ToString().Trim()); //点赞统计
objvSysCountEN.CommentTableId = objRow[convSysCount.CommentTableId] == DBNull.Value ? null : objRow[convSysCount.CommentTableId].ToString().Trim(); //评论表Id
objvSysCountEN.CollectionCount = objRow[convSysCount.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convSysCount.CollectionCount].ToString().Trim()); //收藏数量
objvSysCountEN.DownloadCount = objRow[convSysCount.DownloadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSysCount.DownloadCount].ToString().Trim()); //下载数
objvSysCountEN.AttachmentCount = objRow[convSysCount.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSysCount.AttachmentCount].ToString().Trim()); //附件计数
objvSysCountEN.CommentCount = objRow[convSysCount.CommentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSysCount.CommentCount].ToString().Trim()); //评论数
objvSysCountEN.Score = objRow[convSysCount.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convSysCount.Score].ToString().Trim()); //评分
objvSysCountEN.StuScore = objRow[convSysCount.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convSysCount.StuScore].ToString().Trim()); //学生平均分
objvSysCountEN.TeaScore = objRow[convSysCount.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convSysCount.TeaScore].ToString().Trim()); //教师评分
objvSysCountEN.TableKey = objRow[convSysCount.TableKey] == DBNull.Value ? null : objRow[convSysCount.TableKey].ToString().Trim(); //表主键
objvSysCountEN.ParentId = objRow[convSysCount.ParentId] == DBNull.Value ? null : objRow[convSysCount.ParentId].ToString().Trim(); //父Id
objvSysCountEN.UpdUser = objRow[convSysCount.UpdUser] == DBNull.Value ? null : objRow[convSysCount.UpdUser].ToString().Trim(); //修改人
objvSysCountEN.UpdDate = objRow[convSysCount.UpdDate] == DBNull.Value ? null : objRow[convSysCount.UpdDate].ToString().Trim(); //修改日期
objvSysCountEN.Memo = objRow[convSysCount.Memo] == DBNull.Value ? null : objRow[convSysCount.Memo].ToString().Trim(); //备注
objvSysCountEN.PaperRWCount = objRow[convSysCount.PaperRWCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSysCount.PaperRWCount].ToString().Trim()); //PaperRWCount
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvSysCountDA: GetObjByDataRowvSysCount)", objException.Message));
}
objvSysCountEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvSysCountEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvSysCountEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvSysCountEN objvSysCountEN = new clsvSysCountEN();
try
{
objvSysCountEN.CountId = objRow[convSysCount.CountId].ToString().Trim(); //CountId
objvSysCountEN.CountTypeId = objRow[convSysCount.CountTypeId] == DBNull.Value ? null : objRow[convSysCount.CountTypeId].ToString().Trim(); //CountTypeId
objvSysCountEN.CommentTypeName = objRow[convSysCount.CommentTypeName] == DBNull.Value ? null : objRow[convSysCount.CommentTypeName].ToString().Trim(); //评论类型名
objvSysCountEN.CommentTable = objRow[convSysCount.CommentTable] == DBNull.Value ? null : objRow[convSysCount.CommentTable].ToString().Trim(); //评论表
objvSysCountEN.OkCount = objRow[convSysCount.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSysCount.OkCount].ToString().Trim()); //点赞统计
objvSysCountEN.CommentTableId = objRow[convSysCount.CommentTableId] == DBNull.Value ? null : objRow[convSysCount.CommentTableId].ToString().Trim(); //评论表Id
objvSysCountEN.CollectionCount = objRow[convSysCount.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convSysCount.CollectionCount].ToString().Trim()); //收藏数量
objvSysCountEN.DownloadCount = objRow[convSysCount.DownloadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSysCount.DownloadCount].ToString().Trim()); //下载数
objvSysCountEN.AttachmentCount = objRow[convSysCount.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSysCount.AttachmentCount].ToString().Trim()); //附件计数
objvSysCountEN.CommentCount = objRow[convSysCount.CommentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSysCount.CommentCount].ToString().Trim()); //评论数
objvSysCountEN.Score = objRow[convSysCount.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convSysCount.Score].ToString().Trim()); //评分
objvSysCountEN.StuScore = objRow[convSysCount.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convSysCount.StuScore].ToString().Trim()); //学生平均分
objvSysCountEN.TeaScore = objRow[convSysCount.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convSysCount.TeaScore].ToString().Trim()); //教师评分
objvSysCountEN.TableKey = objRow[convSysCount.TableKey] == DBNull.Value ? null : objRow[convSysCount.TableKey].ToString().Trim(); //表主键
objvSysCountEN.ParentId = objRow[convSysCount.ParentId] == DBNull.Value ? null : objRow[convSysCount.ParentId].ToString().Trim(); //父Id
objvSysCountEN.UpdUser = objRow[convSysCount.UpdUser] == DBNull.Value ? null : objRow[convSysCount.UpdUser].ToString().Trim(); //修改人
objvSysCountEN.UpdDate = objRow[convSysCount.UpdDate] == DBNull.Value ? null : objRow[convSysCount.UpdDate].ToString().Trim(); //修改日期
objvSysCountEN.Memo = objRow[convSysCount.Memo] == DBNull.Value ? null : objRow[convSysCount.Memo].ToString().Trim(); //备注
objvSysCountEN.PaperRWCount = objRow[convSysCount.PaperRWCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSysCount.PaperRWCount].ToString().Trim()); //PaperRWCount
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvSysCountDA: GetObjByDataRow)", objException.Message));
}
objvSysCountEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvSysCountEN;
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
objSQL = clsvSysCountDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvSysCountEN._CurrTabName, convSysCount.CountId, 10, "");
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
objSQL = clsvSysCountDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvSysCountEN._CurrTabName, convSysCount.CountId, 10, strPrefix);
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
 objSQL = clsvSysCountDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select CountId from vSysCount where " + strCondition;
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
 objSQL = clsvSysCountDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select CountId from vSysCount where " + strCondition;
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
 /// <param name = "strCountId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strCountId)
{
CheckPrimaryKey(strCountId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysCountDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vSysCount", "CountId = " + "'"+ strCountId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvSysCountDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysCountDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vSysCount", strCondition))
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
objSQL = clsvSysCountDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vSysCount");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvSysCountENS">源对象</param>
 /// <param name = "objvSysCountENT">目标对象</param>
public void CopyTo(clsvSysCountEN objvSysCountENS, clsvSysCountEN objvSysCountENT)
{
objvSysCountENT.CountId = objvSysCountENS.CountId; //CountId
objvSysCountENT.CountTypeId = objvSysCountENS.CountTypeId; //CountTypeId
objvSysCountENT.CommentTypeName = objvSysCountENS.CommentTypeName; //评论类型名
objvSysCountENT.CommentTable = objvSysCountENS.CommentTable; //评论表
objvSysCountENT.OkCount = objvSysCountENS.OkCount; //点赞统计
objvSysCountENT.CommentTableId = objvSysCountENS.CommentTableId; //评论表Id
objvSysCountENT.CollectionCount = objvSysCountENS.CollectionCount; //收藏数量
objvSysCountENT.DownloadCount = objvSysCountENS.DownloadCount; //下载数
objvSysCountENT.AttachmentCount = objvSysCountENS.AttachmentCount; //附件计数
objvSysCountENT.CommentCount = objvSysCountENS.CommentCount; //评论数
objvSysCountENT.Score = objvSysCountENS.Score; //评分
objvSysCountENT.StuScore = objvSysCountENS.StuScore; //学生平均分
objvSysCountENT.TeaScore = objvSysCountENS.TeaScore; //教师评分
objvSysCountENT.TableKey = objvSysCountENS.TableKey; //表主键
objvSysCountENT.ParentId = objvSysCountENS.ParentId; //父Id
objvSysCountENT.UpdUser = objvSysCountENS.UpdUser; //修改人
objvSysCountENT.UpdDate = objvSysCountENS.UpdDate; //修改日期
objvSysCountENT.Memo = objvSysCountENS.Memo; //备注
objvSysCountENT.PaperRWCount = objvSysCountENS.PaperRWCount; //PaperRWCount
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvSysCountEN objvSysCountEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvSysCountEN.CountId, 10, convSysCount.CountId);
clsCheckSql.CheckFieldLen(objvSysCountEN.CountTypeId, 2, convSysCount.CountTypeId);
clsCheckSql.CheckFieldLen(objvSysCountEN.CommentTypeName, 50, convSysCount.CommentTypeName);
clsCheckSql.CheckFieldLen(objvSysCountEN.CommentTable, 50, convSysCount.CommentTable);
clsCheckSql.CheckFieldLen(objvSysCountEN.CommentTableId, 50, convSysCount.CommentTableId);
clsCheckSql.CheckFieldLen(objvSysCountEN.TableKey, 20, convSysCount.TableKey);
clsCheckSql.CheckFieldLen(objvSysCountEN.ParentId, 20, convSysCount.ParentId);
clsCheckSql.CheckFieldLen(objvSysCountEN.UpdUser, 20, convSysCount.UpdUser);
clsCheckSql.CheckFieldLen(objvSysCountEN.UpdDate, 20, convSysCount.UpdDate);
clsCheckSql.CheckFieldLen(objvSysCountEN.Memo, 1000, convSysCount.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvSysCountEN.CountId, convSysCount.CountId);
clsCheckSql.CheckSqlInjection4Field(objvSysCountEN.CountTypeId, convSysCount.CountTypeId);
clsCheckSql.CheckSqlInjection4Field(objvSysCountEN.CommentTypeName, convSysCount.CommentTypeName);
clsCheckSql.CheckSqlInjection4Field(objvSysCountEN.CommentTable, convSysCount.CommentTable);
clsCheckSql.CheckSqlInjection4Field(objvSysCountEN.CommentTableId, convSysCount.CommentTableId);
clsCheckSql.CheckSqlInjection4Field(objvSysCountEN.TableKey, convSysCount.TableKey);
clsCheckSql.CheckSqlInjection4Field(objvSysCountEN.ParentId, convSysCount.ParentId);
clsCheckSql.CheckSqlInjection4Field(objvSysCountEN.UpdUser, convSysCount.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvSysCountEN.UpdDate, convSysCount.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvSysCountEN.Memo, convSysCount.Memo);
//检查外键字段长度
 objvSysCountEN._IsCheckProperty = true;
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
 objSQL = clsvSysCountDA.GetSpecSQLObj();
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
 objSQL = clsvSysCountDA.GetSpecSQLObj();
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
 objSQL = clsvSysCountDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvSysCountEN._CurrTabName);
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
 objSQL = clsvSysCountDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvSysCountEN._CurrTabName, strCondition);
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
 objSQL = clsvSysCountDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}