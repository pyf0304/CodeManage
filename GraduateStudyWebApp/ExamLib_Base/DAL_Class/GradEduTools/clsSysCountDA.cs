
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSysCountDA
 表名:SysCount(01120625)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:08:59
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
 /// 统计数据(SysCount)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsSysCountDA : clsCommBase4DA
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
 return clsSysCountEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsSysCountEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsSysCountEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsSysCountEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsSysCountEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:SysCount中,检查关键字,长度不正确!(clsSysCountDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strCountId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:SysCount中,关键字不能为空 或 null!(clsSysCountDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCountId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsSysCountDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsSysCountDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysCountDA.GetSpecSQLObj();
strSQL = "Select * from SysCount where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_SysCount(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsSysCountDA: GetDataTable_SysCount)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysCountDA.GetSpecSQLObj();
strSQL = "Select * from SysCount where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsSysCountDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysCountDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsSysCountDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysCountDA.GetSpecSQLObj();
strSQL = "Select * from SysCount where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsSysCountDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysCountDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsSysCountDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysCountDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from SysCount where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from SysCount where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsSysCountDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysCountDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from SysCount where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsSysCountDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysCountDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} SysCount.* from SysCount Left Join {1} on {2} where {3} and SysCount.CountId not in (Select top {5} SysCount.CountId from SysCount Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from SysCount where {1} and CountId not in (Select top {2} CountId from SysCount where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from SysCount where {1} and CountId not in (Select top {3} CountId from SysCount where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsSysCountDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysCountDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} SysCount.* from SysCount Left Join {1} on {2} where {3} and SysCount.CountId not in (Select top {5} SysCount.CountId from SysCount Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from SysCount where {1} and CountId not in (Select top {2} CountId from SysCount where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from SysCount where {1} and CountId not in (Select top {3} CountId from SysCount where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsSysCountEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsSysCountDA:GetObjLst)", objException.Message));
}
List<clsSysCountEN> arrObjLst = new List<clsSysCountEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysCountDA.GetSpecSQLObj();
strSQL = "Select * from SysCount where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysCountEN objSysCountEN = new clsSysCountEN();
try
{
objSysCountEN.CountId = objRow[conSysCount.CountId].ToString().Trim(); //CountId
objSysCountEN.CountTypeId = objRow[conSysCount.CountTypeId] == DBNull.Value ? null : objRow[conSysCount.CountTypeId].ToString().Trim(); //CountTypeId
objSysCountEN.PaperRWCount = objRow[conSysCount.PaperRWCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysCount.PaperRWCount].ToString().Trim()); //PaperRWCount
objSysCountEN.OkCount = objRow[conSysCount.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysCount.OkCount].ToString().Trim()); //点赞统计
objSysCountEN.CollectionCount = objRow[conSysCount.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conSysCount.CollectionCount].ToString().Trim()); //收藏数量
objSysCountEN.DownloadCount = objRow[conSysCount.DownloadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysCount.DownloadCount].ToString().Trim()); //下载数
objSysCountEN.AttachmentCount = objRow[conSysCount.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysCount.AttachmentCount].ToString().Trim()); //附件计数
objSysCountEN.CommentCount = objRow[conSysCount.CommentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysCount.CommentCount].ToString().Trim()); //评论数
objSysCountEN.Score = objRow[conSysCount.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conSysCount.Score].ToString().Trim()); //评分
objSysCountEN.StuScore = objRow[conSysCount.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conSysCount.StuScore].ToString().Trim()); //学生平均分
objSysCountEN.TeaScore = objRow[conSysCount.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conSysCount.TeaScore].ToString().Trim()); //教师评分
objSysCountEN.TableKey = objRow[conSysCount.TableKey] == DBNull.Value ? null : objRow[conSysCount.TableKey].ToString().Trim(); //表主键
objSysCountEN.ParentId = objRow[conSysCount.ParentId] == DBNull.Value ? null : objRow[conSysCount.ParentId].ToString().Trim(); //父Id
objSysCountEN.UpdUser = objRow[conSysCount.UpdUser] == DBNull.Value ? null : objRow[conSysCount.UpdUser].ToString().Trim(); //修改人
objSysCountEN.UpdDate = objRow[conSysCount.UpdDate] == DBNull.Value ? null : objRow[conSysCount.UpdDate].ToString().Trim(); //修改日期
objSysCountEN.Memo = objRow[conSysCount.Memo] == DBNull.Value ? null : objRow[conSysCount.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsSysCountDA: GetObjLst)", objException.Message));
}
objSysCountEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objSysCountEN);
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
public List<clsSysCountEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsSysCountDA:GetObjLstByTabName)", objException.Message));
}
List<clsSysCountEN> arrObjLst = new List<clsSysCountEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysCountDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysCountEN objSysCountEN = new clsSysCountEN();
try
{
objSysCountEN.CountId = objRow[conSysCount.CountId].ToString().Trim(); //CountId
objSysCountEN.CountTypeId = objRow[conSysCount.CountTypeId] == DBNull.Value ? null : objRow[conSysCount.CountTypeId].ToString().Trim(); //CountTypeId
objSysCountEN.PaperRWCount = objRow[conSysCount.PaperRWCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysCount.PaperRWCount].ToString().Trim()); //PaperRWCount
objSysCountEN.OkCount = objRow[conSysCount.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysCount.OkCount].ToString().Trim()); //点赞统计
objSysCountEN.CollectionCount = objRow[conSysCount.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conSysCount.CollectionCount].ToString().Trim()); //收藏数量
objSysCountEN.DownloadCount = objRow[conSysCount.DownloadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysCount.DownloadCount].ToString().Trim()); //下载数
objSysCountEN.AttachmentCount = objRow[conSysCount.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysCount.AttachmentCount].ToString().Trim()); //附件计数
objSysCountEN.CommentCount = objRow[conSysCount.CommentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysCount.CommentCount].ToString().Trim()); //评论数
objSysCountEN.Score = objRow[conSysCount.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conSysCount.Score].ToString().Trim()); //评分
objSysCountEN.StuScore = objRow[conSysCount.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conSysCount.StuScore].ToString().Trim()); //学生平均分
objSysCountEN.TeaScore = objRow[conSysCount.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conSysCount.TeaScore].ToString().Trim()); //教师评分
objSysCountEN.TableKey = objRow[conSysCount.TableKey] == DBNull.Value ? null : objRow[conSysCount.TableKey].ToString().Trim(); //表主键
objSysCountEN.ParentId = objRow[conSysCount.ParentId] == DBNull.Value ? null : objRow[conSysCount.ParentId].ToString().Trim(); //父Id
objSysCountEN.UpdUser = objRow[conSysCount.UpdUser] == DBNull.Value ? null : objRow[conSysCount.UpdUser].ToString().Trim(); //修改人
objSysCountEN.UpdDate = objRow[conSysCount.UpdDate] == DBNull.Value ? null : objRow[conSysCount.UpdDate].ToString().Trim(); //修改日期
objSysCountEN.Memo = objRow[conSysCount.Memo] == DBNull.Value ? null : objRow[conSysCount.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsSysCountDA: GetObjLst)", objException.Message));
}
objSysCountEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objSysCountEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objSysCountEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetSysCount(ref clsSysCountEN objSysCountEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysCountDA.GetSpecSQLObj();
strSQL = "Select * from SysCount where CountId = " + "'"+ objSysCountEN.CountId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objSysCountEN.CountId = objDT.Rows[0][conSysCount.CountId].ToString().Trim(); //CountId(字段类型:char,字段长度:10,是否可空:False)
 objSysCountEN.CountTypeId = objDT.Rows[0][conSysCount.CountTypeId].ToString().Trim(); //CountTypeId(字段类型:char,字段长度:2,是否可空:True)
 objSysCountEN.PaperRWCount = TransNullToInt(objDT.Rows[0][conSysCount.PaperRWCount].ToString().Trim()); //PaperRWCount(字段类型:int,字段长度:4,是否可空:True)
 objSysCountEN.OkCount = TransNullToInt(objDT.Rows[0][conSysCount.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objSysCountEN.CollectionCount = TransNullToInt(objDT.Rows[0][conSysCount.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objSysCountEN.DownloadCount = TransNullToInt(objDT.Rows[0][conSysCount.DownloadCount].ToString().Trim()); //下载数(字段类型:int,字段长度:4,是否可空:True)
 objSysCountEN.AttachmentCount = TransNullToInt(objDT.Rows[0][conSysCount.AttachmentCount].ToString().Trim()); //附件计数(字段类型:int,字段长度:4,是否可空:True)
 objSysCountEN.CommentCount = TransNullToInt(objDT.Rows[0][conSysCount.CommentCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objSysCountEN.Score = TransNullToFloat(objDT.Rows[0][conSysCount.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objSysCountEN.StuScore = TransNullToFloat(objDT.Rows[0][conSysCount.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objSysCountEN.TeaScore = TransNullToFloat(objDT.Rows[0][conSysCount.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objSysCountEN.TableKey = objDT.Rows[0][conSysCount.TableKey].ToString().Trim(); //表主键(字段类型:varchar,字段长度:20,是否可空:True)
 objSysCountEN.ParentId = objDT.Rows[0][conSysCount.ParentId].ToString().Trim(); //父Id(字段类型:varchar,字段长度:20,是否可空:False)
 objSysCountEN.UpdUser = objDT.Rows[0][conSysCount.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objSysCountEN.UpdDate = objDT.Rows[0][conSysCount.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objSysCountEN.Memo = objDT.Rows[0][conSysCount.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsSysCountDA: GetSysCount)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strCountId">表关键字</param>
 /// <returns>表对象</returns>
public clsSysCountEN GetObjByCountId(string strCountId)
{
CheckPrimaryKey(strCountId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysCountDA.GetSpecSQLObj();
strSQL = "Select * from SysCount where CountId = " + "'"+ strCountId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsSysCountEN objSysCountEN = new clsSysCountEN();
try
{
 objSysCountEN.CountId = objRow[conSysCount.CountId].ToString().Trim(); //CountId(字段类型:char,字段长度:10,是否可空:False)
 objSysCountEN.CountTypeId = objRow[conSysCount.CountTypeId] == DBNull.Value ? null : objRow[conSysCount.CountTypeId].ToString().Trim(); //CountTypeId(字段类型:char,字段长度:2,是否可空:True)
 objSysCountEN.PaperRWCount = objRow[conSysCount.PaperRWCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysCount.PaperRWCount].ToString().Trim()); //PaperRWCount(字段类型:int,字段长度:4,是否可空:True)
 objSysCountEN.OkCount = objRow[conSysCount.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysCount.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objSysCountEN.CollectionCount = objRow[conSysCount.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysCount.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objSysCountEN.DownloadCount = objRow[conSysCount.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysCount.DownloadCount].ToString().Trim()); //下载数(字段类型:int,字段长度:4,是否可空:True)
 objSysCountEN.AttachmentCount = objRow[conSysCount.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysCount.AttachmentCount].ToString().Trim()); //附件计数(字段类型:int,字段长度:4,是否可空:True)
 objSysCountEN.CommentCount = objRow[conSysCount.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysCount.CommentCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objSysCountEN.Score = objRow[conSysCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysCount.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objSysCountEN.StuScore = objRow[conSysCount.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysCount.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objSysCountEN.TeaScore = objRow[conSysCount.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysCount.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objSysCountEN.TableKey = objRow[conSysCount.TableKey] == DBNull.Value ? null : objRow[conSysCount.TableKey].ToString().Trim(); //表主键(字段类型:varchar,字段长度:20,是否可空:True)
 objSysCountEN.ParentId = objRow[conSysCount.ParentId] == DBNull.Value ? null : objRow[conSysCount.ParentId].ToString().Trim(); //父Id(字段类型:varchar,字段长度:20,是否可空:False)
 objSysCountEN.UpdUser = objRow[conSysCount.UpdUser] == DBNull.Value ? null : objRow[conSysCount.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objSysCountEN.UpdDate = objRow[conSysCount.UpdDate] == DBNull.Value ? null : objRow[conSysCount.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objSysCountEN.Memo = objRow[conSysCount.Memo] == DBNull.Value ? null : objRow[conSysCount.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsSysCountDA: GetObjByCountId)", objException.Message));
}
return objSysCountEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsSysCountEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsSysCountDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysCountDA.GetSpecSQLObj();
strSQL = "Select * from SysCount where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsSysCountEN objSysCountEN = new clsSysCountEN()
{
CountId = objRow[conSysCount.CountId].ToString().Trim(), //CountId
CountTypeId = objRow[conSysCount.CountTypeId] == DBNull.Value ? null : objRow[conSysCount.CountTypeId].ToString().Trim(), //CountTypeId
PaperRWCount = objRow[conSysCount.PaperRWCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysCount.PaperRWCount].ToString().Trim()), //PaperRWCount
OkCount = objRow[conSysCount.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysCount.OkCount].ToString().Trim()), //点赞统计
CollectionCount = objRow[conSysCount.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conSysCount.CollectionCount].ToString().Trim()), //收藏数量
DownloadCount = objRow[conSysCount.DownloadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysCount.DownloadCount].ToString().Trim()), //下载数
AttachmentCount = objRow[conSysCount.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysCount.AttachmentCount].ToString().Trim()), //附件计数
CommentCount = objRow[conSysCount.CommentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysCount.CommentCount].ToString().Trim()), //评论数
Score = objRow[conSysCount.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conSysCount.Score].ToString().Trim()), //评分
StuScore = objRow[conSysCount.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conSysCount.StuScore].ToString().Trim()), //学生平均分
TeaScore = objRow[conSysCount.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conSysCount.TeaScore].ToString().Trim()), //教师评分
TableKey = objRow[conSysCount.TableKey] == DBNull.Value ? null : objRow[conSysCount.TableKey].ToString().Trim(), //表主键
ParentId = objRow[conSysCount.ParentId] == DBNull.Value ? null : objRow[conSysCount.ParentId].ToString().Trim(), //父Id
UpdUser = objRow[conSysCount.UpdUser] == DBNull.Value ? null : objRow[conSysCount.UpdUser].ToString().Trim(), //修改人
UpdDate = objRow[conSysCount.UpdDate] == DBNull.Value ? null : objRow[conSysCount.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[conSysCount.Memo] == DBNull.Value ? null : objRow[conSysCount.Memo].ToString().Trim() //备注
};
objSysCountEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objSysCountEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsSysCountDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsSysCountEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsSysCountEN objSysCountEN = new clsSysCountEN();
try
{
objSysCountEN.CountId = objRow[conSysCount.CountId].ToString().Trim(); //CountId
objSysCountEN.CountTypeId = objRow[conSysCount.CountTypeId] == DBNull.Value ? null : objRow[conSysCount.CountTypeId].ToString().Trim(); //CountTypeId
objSysCountEN.PaperRWCount = objRow[conSysCount.PaperRWCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysCount.PaperRWCount].ToString().Trim()); //PaperRWCount
objSysCountEN.OkCount = objRow[conSysCount.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysCount.OkCount].ToString().Trim()); //点赞统计
objSysCountEN.CollectionCount = objRow[conSysCount.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conSysCount.CollectionCount].ToString().Trim()); //收藏数量
objSysCountEN.DownloadCount = objRow[conSysCount.DownloadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysCount.DownloadCount].ToString().Trim()); //下载数
objSysCountEN.AttachmentCount = objRow[conSysCount.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysCount.AttachmentCount].ToString().Trim()); //附件计数
objSysCountEN.CommentCount = objRow[conSysCount.CommentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysCount.CommentCount].ToString().Trim()); //评论数
objSysCountEN.Score = objRow[conSysCount.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conSysCount.Score].ToString().Trim()); //评分
objSysCountEN.StuScore = objRow[conSysCount.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conSysCount.StuScore].ToString().Trim()); //学生平均分
objSysCountEN.TeaScore = objRow[conSysCount.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conSysCount.TeaScore].ToString().Trim()); //教师评分
objSysCountEN.TableKey = objRow[conSysCount.TableKey] == DBNull.Value ? null : objRow[conSysCount.TableKey].ToString().Trim(); //表主键
objSysCountEN.ParentId = objRow[conSysCount.ParentId] == DBNull.Value ? null : objRow[conSysCount.ParentId].ToString().Trim(); //父Id
objSysCountEN.UpdUser = objRow[conSysCount.UpdUser] == DBNull.Value ? null : objRow[conSysCount.UpdUser].ToString().Trim(); //修改人
objSysCountEN.UpdDate = objRow[conSysCount.UpdDate] == DBNull.Value ? null : objRow[conSysCount.UpdDate].ToString().Trim(); //修改日期
objSysCountEN.Memo = objRow[conSysCount.Memo] == DBNull.Value ? null : objRow[conSysCount.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsSysCountDA: GetObjByDataRowSysCount)", objException.Message));
}
objSysCountEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objSysCountEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsSysCountEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsSysCountEN objSysCountEN = new clsSysCountEN();
try
{
objSysCountEN.CountId = objRow[conSysCount.CountId].ToString().Trim(); //CountId
objSysCountEN.CountTypeId = objRow[conSysCount.CountTypeId] == DBNull.Value ? null : objRow[conSysCount.CountTypeId].ToString().Trim(); //CountTypeId
objSysCountEN.PaperRWCount = objRow[conSysCount.PaperRWCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysCount.PaperRWCount].ToString().Trim()); //PaperRWCount
objSysCountEN.OkCount = objRow[conSysCount.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysCount.OkCount].ToString().Trim()); //点赞统计
objSysCountEN.CollectionCount = objRow[conSysCount.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conSysCount.CollectionCount].ToString().Trim()); //收藏数量
objSysCountEN.DownloadCount = objRow[conSysCount.DownloadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysCount.DownloadCount].ToString().Trim()); //下载数
objSysCountEN.AttachmentCount = objRow[conSysCount.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysCount.AttachmentCount].ToString().Trim()); //附件计数
objSysCountEN.CommentCount = objRow[conSysCount.CommentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysCount.CommentCount].ToString().Trim()); //评论数
objSysCountEN.Score = objRow[conSysCount.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conSysCount.Score].ToString().Trim()); //评分
objSysCountEN.StuScore = objRow[conSysCount.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conSysCount.StuScore].ToString().Trim()); //学生平均分
objSysCountEN.TeaScore = objRow[conSysCount.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conSysCount.TeaScore].ToString().Trim()); //教师评分
objSysCountEN.TableKey = objRow[conSysCount.TableKey] == DBNull.Value ? null : objRow[conSysCount.TableKey].ToString().Trim(); //表主键
objSysCountEN.ParentId = objRow[conSysCount.ParentId] == DBNull.Value ? null : objRow[conSysCount.ParentId].ToString().Trim(); //父Id
objSysCountEN.UpdUser = objRow[conSysCount.UpdUser] == DBNull.Value ? null : objRow[conSysCount.UpdUser].ToString().Trim(); //修改人
objSysCountEN.UpdDate = objRow[conSysCount.UpdDate] == DBNull.Value ? null : objRow[conSysCount.UpdDate].ToString().Trim(); //修改日期
objSysCountEN.Memo = objRow[conSysCount.Memo] == DBNull.Value ? null : objRow[conSysCount.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsSysCountDA: GetObjByDataRow)", objException.Message));
}
objSysCountEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objSysCountEN;
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
objSQL = clsSysCountDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsSysCountEN._CurrTabName, conSysCount.CountId, 10, "");
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
objSQL = clsSysCountDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsSysCountEN._CurrTabName, conSysCount.CountId, 10, strPrefix);
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
 objSQL = clsSysCountDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select CountId from SysCount where " + strCondition;
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
 objSQL = clsSysCountDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select CountId from SysCount where " + strCondition;
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
 objSQL = clsSysCountDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("SysCount", "CountId = " + "'"+ strCountId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsSysCountDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysCountDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("SysCount", strCondition))
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
objSQL = clsSysCountDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("SysCount");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsSysCountEN objSysCountEN)
 {
 objSysCountEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSysCountEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSysCountEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysCountDA.GetSpecSQLObj();
strSQL = "Select * from SysCount where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "SysCount");
objRow = objDS.Tables["SysCount"].NewRow();
objRow[conSysCount.CountId] = objSysCountEN.CountId; //CountId
 if (objSysCountEN.CountTypeId !=  "")
 {
objRow[conSysCount.CountTypeId] = objSysCountEN.CountTypeId; //CountTypeId
 }
objRow[conSysCount.PaperRWCount] = objSysCountEN.PaperRWCount; //PaperRWCount
objRow[conSysCount.OkCount] = objSysCountEN.OkCount; //点赞统计
objRow[conSysCount.CollectionCount] = objSysCountEN.CollectionCount; //收藏数量
objRow[conSysCount.DownloadCount] = objSysCountEN.DownloadCount; //下载数
objRow[conSysCount.AttachmentCount] = objSysCountEN.AttachmentCount; //附件计数
objRow[conSysCount.CommentCount] = objSysCountEN.CommentCount; //评论数
objRow[conSysCount.Score] = objSysCountEN.Score; //评分
objRow[conSysCount.StuScore] = objSysCountEN.StuScore; //学生平均分
objRow[conSysCount.TeaScore] = objSysCountEN.TeaScore; //教师评分
 if (objSysCountEN.TableKey !=  "")
 {
objRow[conSysCount.TableKey] = objSysCountEN.TableKey; //表主键
 }
 if (objSysCountEN.ParentId !=  "")
 {
objRow[conSysCount.ParentId] = objSysCountEN.ParentId; //父Id
 }
 if (objSysCountEN.UpdUser !=  "")
 {
objRow[conSysCount.UpdUser] = objSysCountEN.UpdUser; //修改人
 }
 if (objSysCountEN.UpdDate !=  "")
 {
objRow[conSysCount.UpdDate] = objSysCountEN.UpdDate; //修改日期
 }
 if (objSysCountEN.Memo !=  "")
 {
objRow[conSysCount.Memo] = objSysCountEN.Memo; //备注
 }
objDS.Tables[clsSysCountEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsSysCountEN._CurrTabName);
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
 /// <param name = "objSysCountEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsSysCountEN objSysCountEN)
{
 objSysCountEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSysCountEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSysCountEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objSysCountEN.CountId !=  null)
 {
 arrFieldListForInsert.Add(conSysCount.CountId);
 var strCountId = objSysCountEN.CountId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCountId + "'");
 }
 
 if (objSysCountEN.CountTypeId !=  null)
 {
 arrFieldListForInsert.Add(conSysCount.CountTypeId);
 var strCountTypeId = objSysCountEN.CountTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCountTypeId + "'");
 }
 
 if (objSysCountEN.PaperRWCount !=  null)
 {
 arrFieldListForInsert.Add(conSysCount.PaperRWCount);
 arrValueListForInsert.Add(objSysCountEN.PaperRWCount.ToString());
 }
 
 if (objSysCountEN.OkCount !=  null)
 {
 arrFieldListForInsert.Add(conSysCount.OkCount);
 arrValueListForInsert.Add(objSysCountEN.OkCount.ToString());
 }
 
 if (objSysCountEN.CollectionCount !=  null)
 {
 arrFieldListForInsert.Add(conSysCount.CollectionCount);
 arrValueListForInsert.Add(objSysCountEN.CollectionCount.ToString());
 }
 
 if (objSysCountEN.DownloadCount !=  null)
 {
 arrFieldListForInsert.Add(conSysCount.DownloadCount);
 arrValueListForInsert.Add(objSysCountEN.DownloadCount.ToString());
 }
 
 if (objSysCountEN.AttachmentCount !=  null)
 {
 arrFieldListForInsert.Add(conSysCount.AttachmentCount);
 arrValueListForInsert.Add(objSysCountEN.AttachmentCount.ToString());
 }
 
 if (objSysCountEN.CommentCount !=  null)
 {
 arrFieldListForInsert.Add(conSysCount.CommentCount);
 arrValueListForInsert.Add(objSysCountEN.CommentCount.ToString());
 }
 
 if (objSysCountEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conSysCount.Score);
 arrValueListForInsert.Add(objSysCountEN.Score.ToString());
 }
 
 if (objSysCountEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conSysCount.StuScore);
 arrValueListForInsert.Add(objSysCountEN.StuScore.ToString());
 }
 
 if (objSysCountEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conSysCount.TeaScore);
 arrValueListForInsert.Add(objSysCountEN.TeaScore.ToString());
 }
 
 if (objSysCountEN.TableKey !=  null)
 {
 arrFieldListForInsert.Add(conSysCount.TableKey);
 var strTableKey = objSysCountEN.TableKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTableKey + "'");
 }
 
 if (objSysCountEN.ParentId !=  null)
 {
 arrFieldListForInsert.Add(conSysCount.ParentId);
 var strParentId = objSysCountEN.ParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParentId + "'");
 }
 
 if (objSysCountEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conSysCount.UpdUser);
 var strUpdUser = objSysCountEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objSysCountEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conSysCount.UpdDate);
 var strUpdDate = objSysCountEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objSysCountEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conSysCount.Memo);
 var strMemo = objSysCountEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SysCount");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysCountDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objSysCountEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsSysCountEN objSysCountEN)
{
 objSysCountEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSysCountEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSysCountEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objSysCountEN.CountId !=  null)
 {
 arrFieldListForInsert.Add(conSysCount.CountId);
 var strCountId = objSysCountEN.CountId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCountId + "'");
 }
 
 if (objSysCountEN.CountTypeId !=  null)
 {
 arrFieldListForInsert.Add(conSysCount.CountTypeId);
 var strCountTypeId = objSysCountEN.CountTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCountTypeId + "'");
 }
 
 if (objSysCountEN.PaperRWCount !=  null)
 {
 arrFieldListForInsert.Add(conSysCount.PaperRWCount);
 arrValueListForInsert.Add(objSysCountEN.PaperRWCount.ToString());
 }
 
 if (objSysCountEN.OkCount !=  null)
 {
 arrFieldListForInsert.Add(conSysCount.OkCount);
 arrValueListForInsert.Add(objSysCountEN.OkCount.ToString());
 }
 
 if (objSysCountEN.CollectionCount !=  null)
 {
 arrFieldListForInsert.Add(conSysCount.CollectionCount);
 arrValueListForInsert.Add(objSysCountEN.CollectionCount.ToString());
 }
 
 if (objSysCountEN.DownloadCount !=  null)
 {
 arrFieldListForInsert.Add(conSysCount.DownloadCount);
 arrValueListForInsert.Add(objSysCountEN.DownloadCount.ToString());
 }
 
 if (objSysCountEN.AttachmentCount !=  null)
 {
 arrFieldListForInsert.Add(conSysCount.AttachmentCount);
 arrValueListForInsert.Add(objSysCountEN.AttachmentCount.ToString());
 }
 
 if (objSysCountEN.CommentCount !=  null)
 {
 arrFieldListForInsert.Add(conSysCount.CommentCount);
 arrValueListForInsert.Add(objSysCountEN.CommentCount.ToString());
 }
 
 if (objSysCountEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conSysCount.Score);
 arrValueListForInsert.Add(objSysCountEN.Score.ToString());
 }
 
 if (objSysCountEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conSysCount.StuScore);
 arrValueListForInsert.Add(objSysCountEN.StuScore.ToString());
 }
 
 if (objSysCountEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conSysCount.TeaScore);
 arrValueListForInsert.Add(objSysCountEN.TeaScore.ToString());
 }
 
 if (objSysCountEN.TableKey !=  null)
 {
 arrFieldListForInsert.Add(conSysCount.TableKey);
 var strTableKey = objSysCountEN.TableKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTableKey + "'");
 }
 
 if (objSysCountEN.ParentId !=  null)
 {
 arrFieldListForInsert.Add(conSysCount.ParentId);
 var strParentId = objSysCountEN.ParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParentId + "'");
 }
 
 if (objSysCountEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conSysCount.UpdUser);
 var strUpdUser = objSysCountEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objSysCountEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conSysCount.UpdDate);
 var strUpdDate = objSysCountEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objSysCountEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conSysCount.Memo);
 var strMemo = objSysCountEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SysCount");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysCountDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objSysCountEN.CountId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objSysCountEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsSysCountEN objSysCountEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objSysCountEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSysCountEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSysCountEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objSysCountEN.CountId !=  null)
 {
 arrFieldListForInsert.Add(conSysCount.CountId);
 var strCountId = objSysCountEN.CountId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCountId + "'");
 }
 
 if (objSysCountEN.CountTypeId !=  null)
 {
 arrFieldListForInsert.Add(conSysCount.CountTypeId);
 var strCountTypeId = objSysCountEN.CountTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCountTypeId + "'");
 }
 
 if (objSysCountEN.PaperRWCount !=  null)
 {
 arrFieldListForInsert.Add(conSysCount.PaperRWCount);
 arrValueListForInsert.Add(objSysCountEN.PaperRWCount.ToString());
 }
 
 if (objSysCountEN.OkCount !=  null)
 {
 arrFieldListForInsert.Add(conSysCount.OkCount);
 arrValueListForInsert.Add(objSysCountEN.OkCount.ToString());
 }
 
 if (objSysCountEN.CollectionCount !=  null)
 {
 arrFieldListForInsert.Add(conSysCount.CollectionCount);
 arrValueListForInsert.Add(objSysCountEN.CollectionCount.ToString());
 }
 
 if (objSysCountEN.DownloadCount !=  null)
 {
 arrFieldListForInsert.Add(conSysCount.DownloadCount);
 arrValueListForInsert.Add(objSysCountEN.DownloadCount.ToString());
 }
 
 if (objSysCountEN.AttachmentCount !=  null)
 {
 arrFieldListForInsert.Add(conSysCount.AttachmentCount);
 arrValueListForInsert.Add(objSysCountEN.AttachmentCount.ToString());
 }
 
 if (objSysCountEN.CommentCount !=  null)
 {
 arrFieldListForInsert.Add(conSysCount.CommentCount);
 arrValueListForInsert.Add(objSysCountEN.CommentCount.ToString());
 }
 
 if (objSysCountEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conSysCount.Score);
 arrValueListForInsert.Add(objSysCountEN.Score.ToString());
 }
 
 if (objSysCountEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conSysCount.StuScore);
 arrValueListForInsert.Add(objSysCountEN.StuScore.ToString());
 }
 
 if (objSysCountEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conSysCount.TeaScore);
 arrValueListForInsert.Add(objSysCountEN.TeaScore.ToString());
 }
 
 if (objSysCountEN.TableKey !=  null)
 {
 arrFieldListForInsert.Add(conSysCount.TableKey);
 var strTableKey = objSysCountEN.TableKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTableKey + "'");
 }
 
 if (objSysCountEN.ParentId !=  null)
 {
 arrFieldListForInsert.Add(conSysCount.ParentId);
 var strParentId = objSysCountEN.ParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParentId + "'");
 }
 
 if (objSysCountEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conSysCount.UpdUser);
 var strUpdUser = objSysCountEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objSysCountEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conSysCount.UpdDate);
 var strUpdDate = objSysCountEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objSysCountEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conSysCount.Memo);
 var strMemo = objSysCountEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SysCount");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysCountDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objSysCountEN.CountId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objSysCountEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsSysCountEN objSysCountEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objSysCountEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSysCountEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSysCountEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objSysCountEN.CountId !=  null)
 {
 arrFieldListForInsert.Add(conSysCount.CountId);
 var strCountId = objSysCountEN.CountId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCountId + "'");
 }
 
 if (objSysCountEN.CountTypeId !=  null)
 {
 arrFieldListForInsert.Add(conSysCount.CountTypeId);
 var strCountTypeId = objSysCountEN.CountTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCountTypeId + "'");
 }
 
 if (objSysCountEN.PaperRWCount !=  null)
 {
 arrFieldListForInsert.Add(conSysCount.PaperRWCount);
 arrValueListForInsert.Add(objSysCountEN.PaperRWCount.ToString());
 }
 
 if (objSysCountEN.OkCount !=  null)
 {
 arrFieldListForInsert.Add(conSysCount.OkCount);
 arrValueListForInsert.Add(objSysCountEN.OkCount.ToString());
 }
 
 if (objSysCountEN.CollectionCount !=  null)
 {
 arrFieldListForInsert.Add(conSysCount.CollectionCount);
 arrValueListForInsert.Add(objSysCountEN.CollectionCount.ToString());
 }
 
 if (objSysCountEN.DownloadCount !=  null)
 {
 arrFieldListForInsert.Add(conSysCount.DownloadCount);
 arrValueListForInsert.Add(objSysCountEN.DownloadCount.ToString());
 }
 
 if (objSysCountEN.AttachmentCount !=  null)
 {
 arrFieldListForInsert.Add(conSysCount.AttachmentCount);
 arrValueListForInsert.Add(objSysCountEN.AttachmentCount.ToString());
 }
 
 if (objSysCountEN.CommentCount !=  null)
 {
 arrFieldListForInsert.Add(conSysCount.CommentCount);
 arrValueListForInsert.Add(objSysCountEN.CommentCount.ToString());
 }
 
 if (objSysCountEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conSysCount.Score);
 arrValueListForInsert.Add(objSysCountEN.Score.ToString());
 }
 
 if (objSysCountEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conSysCount.StuScore);
 arrValueListForInsert.Add(objSysCountEN.StuScore.ToString());
 }
 
 if (objSysCountEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conSysCount.TeaScore);
 arrValueListForInsert.Add(objSysCountEN.TeaScore.ToString());
 }
 
 if (objSysCountEN.TableKey !=  null)
 {
 arrFieldListForInsert.Add(conSysCount.TableKey);
 var strTableKey = objSysCountEN.TableKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTableKey + "'");
 }
 
 if (objSysCountEN.ParentId !=  null)
 {
 arrFieldListForInsert.Add(conSysCount.ParentId);
 var strParentId = objSysCountEN.ParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParentId + "'");
 }
 
 if (objSysCountEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conSysCount.UpdUser);
 var strUpdUser = objSysCountEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objSysCountEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conSysCount.UpdDate);
 var strUpdDate = objSysCountEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objSysCountEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conSysCount.Memo);
 var strMemo = objSysCountEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SysCount");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysCountDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewSysCounts(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysCountDA.GetSpecSQLObj();
strSQL = "Select * from SysCount where CountId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "SysCount");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strCountId = oRow[conSysCount.CountId].ToString().Trim();
if (IsExist(strCountId))
{
 string strResult = "关键字变量值为:" + string.Format("CountId = {0}", strCountId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsSysCountEN._CurrTabName ].NewRow();
objRow[conSysCount.CountId] = oRow[conSysCount.CountId].ToString().Trim(); //CountId
objRow[conSysCount.CountTypeId] = oRow[conSysCount.CountTypeId].ToString().Trim(); //CountTypeId
objRow[conSysCount.PaperRWCount] = oRow[conSysCount.PaperRWCount].ToString().Trim(); //PaperRWCount
objRow[conSysCount.OkCount] = oRow[conSysCount.OkCount].ToString().Trim(); //点赞统计
objRow[conSysCount.CollectionCount] = oRow[conSysCount.CollectionCount].ToString().Trim(); //收藏数量
objRow[conSysCount.DownloadCount] = oRow[conSysCount.DownloadCount].ToString().Trim(); //下载数
objRow[conSysCount.AttachmentCount] = oRow[conSysCount.AttachmentCount].ToString().Trim(); //附件计数
objRow[conSysCount.CommentCount] = oRow[conSysCount.CommentCount].ToString().Trim(); //评论数
objRow[conSysCount.Score] = oRow[conSysCount.Score].ToString().Trim(); //评分
objRow[conSysCount.StuScore] = oRow[conSysCount.StuScore].ToString().Trim(); //学生平均分
objRow[conSysCount.TeaScore] = oRow[conSysCount.TeaScore].ToString().Trim(); //教师评分
objRow[conSysCount.TableKey] = oRow[conSysCount.TableKey].ToString().Trim(); //表主键
objRow[conSysCount.ParentId] = oRow[conSysCount.ParentId].ToString().Trim(); //父Id
objRow[conSysCount.UpdUser] = oRow[conSysCount.UpdUser].ToString().Trim(); //修改人
objRow[conSysCount.UpdDate] = oRow[conSysCount.UpdDate].ToString().Trim(); //修改日期
objRow[conSysCount.Memo] = oRow[conSysCount.Memo].ToString().Trim(); //备注
 objDS.Tables[clsSysCountEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsSysCountEN._CurrTabName);
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
 /// <param name = "objSysCountEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsSysCountEN objSysCountEN)
{
 objSysCountEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSysCountEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSysCountEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysCountDA.GetSpecSQLObj();
strSQL = "Select * from SysCount where CountId = " + "'"+ objSysCountEN.CountId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsSysCountEN._CurrTabName);
if (objDS.Tables[clsSysCountEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:CountId = " + "'"+ objSysCountEN.CountId+"'");
return false;
}
objRow = objDS.Tables[clsSysCountEN._CurrTabName].Rows[0];
 if (objSysCountEN.IsUpdated(conSysCount.CountId))
 {
objRow[conSysCount.CountId] = objSysCountEN.CountId; //CountId
 }
 if (objSysCountEN.IsUpdated(conSysCount.CountTypeId))
 {
objRow[conSysCount.CountTypeId] = objSysCountEN.CountTypeId; //CountTypeId
 }
 if (objSysCountEN.IsUpdated(conSysCount.PaperRWCount))
 {
objRow[conSysCount.PaperRWCount] = objSysCountEN.PaperRWCount; //PaperRWCount
 }
 if (objSysCountEN.IsUpdated(conSysCount.OkCount))
 {
objRow[conSysCount.OkCount] = objSysCountEN.OkCount; //点赞统计
 }
 if (objSysCountEN.IsUpdated(conSysCount.CollectionCount))
 {
objRow[conSysCount.CollectionCount] = objSysCountEN.CollectionCount; //收藏数量
 }
 if (objSysCountEN.IsUpdated(conSysCount.DownloadCount))
 {
objRow[conSysCount.DownloadCount] = objSysCountEN.DownloadCount; //下载数
 }
 if (objSysCountEN.IsUpdated(conSysCount.AttachmentCount))
 {
objRow[conSysCount.AttachmentCount] = objSysCountEN.AttachmentCount; //附件计数
 }
 if (objSysCountEN.IsUpdated(conSysCount.CommentCount))
 {
objRow[conSysCount.CommentCount] = objSysCountEN.CommentCount; //评论数
 }
 if (objSysCountEN.IsUpdated(conSysCount.Score))
 {
objRow[conSysCount.Score] = objSysCountEN.Score; //评分
 }
 if (objSysCountEN.IsUpdated(conSysCount.StuScore))
 {
objRow[conSysCount.StuScore] = objSysCountEN.StuScore; //学生平均分
 }
 if (objSysCountEN.IsUpdated(conSysCount.TeaScore))
 {
objRow[conSysCount.TeaScore] = objSysCountEN.TeaScore; //教师评分
 }
 if (objSysCountEN.IsUpdated(conSysCount.TableKey))
 {
objRow[conSysCount.TableKey] = objSysCountEN.TableKey; //表主键
 }
 if (objSysCountEN.IsUpdated(conSysCount.ParentId))
 {
objRow[conSysCount.ParentId] = objSysCountEN.ParentId; //父Id
 }
 if (objSysCountEN.IsUpdated(conSysCount.UpdUser))
 {
objRow[conSysCount.UpdUser] = objSysCountEN.UpdUser; //修改人
 }
 if (objSysCountEN.IsUpdated(conSysCount.UpdDate))
 {
objRow[conSysCount.UpdDate] = objSysCountEN.UpdDate; //修改日期
 }
 if (objSysCountEN.IsUpdated(conSysCount.Memo))
 {
objRow[conSysCount.Memo] = objSysCountEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsSysCountEN._CurrTabName);
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
 /// <param name = "objSysCountEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsSysCountEN objSysCountEN)
{
 objSysCountEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSysCountEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSysCountEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysCountDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update SysCount Set ");
 
 if (objSysCountEN.IsUpdated(conSysCount.CountTypeId))
 {
 if (objSysCountEN.CountTypeId !=  null)
 {
 var strCountTypeId = objSysCountEN.CountTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCountTypeId, conSysCount.CountTypeId); //CountTypeId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysCount.CountTypeId); //CountTypeId
 }
 }
 
 if (objSysCountEN.IsUpdated(conSysCount.PaperRWCount))
 {
 if (objSysCountEN.PaperRWCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysCountEN.PaperRWCount, conSysCount.PaperRWCount); //PaperRWCount
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysCount.PaperRWCount); //PaperRWCount
 }
 }
 
 if (objSysCountEN.IsUpdated(conSysCount.OkCount))
 {
 if (objSysCountEN.OkCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysCountEN.OkCount, conSysCount.OkCount); //点赞统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysCount.OkCount); //点赞统计
 }
 }
 
 if (objSysCountEN.IsUpdated(conSysCount.CollectionCount))
 {
 if (objSysCountEN.CollectionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysCountEN.CollectionCount, conSysCount.CollectionCount); //收藏数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysCount.CollectionCount); //收藏数量
 }
 }
 
 if (objSysCountEN.IsUpdated(conSysCount.DownloadCount))
 {
 if (objSysCountEN.DownloadCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysCountEN.DownloadCount, conSysCount.DownloadCount); //下载数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysCount.DownloadCount); //下载数
 }
 }
 
 if (objSysCountEN.IsUpdated(conSysCount.AttachmentCount))
 {
 if (objSysCountEN.AttachmentCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysCountEN.AttachmentCount, conSysCount.AttachmentCount); //附件计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysCount.AttachmentCount); //附件计数
 }
 }
 
 if (objSysCountEN.IsUpdated(conSysCount.CommentCount))
 {
 if (objSysCountEN.CommentCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysCountEN.CommentCount, conSysCount.CommentCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysCount.CommentCount); //评论数
 }
 }
 
 if (objSysCountEN.IsUpdated(conSysCount.Score))
 {
 if (objSysCountEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysCountEN.Score, conSysCount.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysCount.Score); //评分
 }
 }
 
 if (objSysCountEN.IsUpdated(conSysCount.StuScore))
 {
 if (objSysCountEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysCountEN.StuScore, conSysCount.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysCount.StuScore); //学生平均分
 }
 }
 
 if (objSysCountEN.IsUpdated(conSysCount.TeaScore))
 {
 if (objSysCountEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysCountEN.TeaScore, conSysCount.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysCount.TeaScore); //教师评分
 }
 }
 
 if (objSysCountEN.IsUpdated(conSysCount.TableKey))
 {
 if (objSysCountEN.TableKey !=  null)
 {
 var strTableKey = objSysCountEN.TableKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTableKey, conSysCount.TableKey); //表主键
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysCount.TableKey); //表主键
 }
 }
 
 if (objSysCountEN.IsUpdated(conSysCount.ParentId))
 {
 if (objSysCountEN.ParentId !=  null)
 {
 var strParentId = objSysCountEN.ParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParentId, conSysCount.ParentId); //父Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysCount.ParentId); //父Id
 }
 }
 
 if (objSysCountEN.IsUpdated(conSysCount.UpdUser))
 {
 if (objSysCountEN.UpdUser !=  null)
 {
 var strUpdUser = objSysCountEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conSysCount.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysCount.UpdUser); //修改人
 }
 }
 
 if (objSysCountEN.IsUpdated(conSysCount.UpdDate))
 {
 if (objSysCountEN.UpdDate !=  null)
 {
 var strUpdDate = objSysCountEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conSysCount.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysCount.UpdDate); //修改日期
 }
 }
 
 if (objSysCountEN.IsUpdated(conSysCount.Memo))
 {
 if (objSysCountEN.Memo !=  null)
 {
 var strMemo = objSysCountEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conSysCount.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysCount.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where CountId = '{0}'", objSysCountEN.CountId); 
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
 /// <param name = "objSysCountEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsSysCountEN objSysCountEN, string strCondition)
{
 objSysCountEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSysCountEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSysCountEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysCountDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update SysCount Set ");
 
 if (objSysCountEN.IsUpdated(conSysCount.CountTypeId))
 {
 if (objSysCountEN.CountTypeId !=  null)
 {
 var strCountTypeId = objSysCountEN.CountTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CountTypeId = '{0}',", strCountTypeId); //CountTypeId
 }
 else
 {
 sbSQL.Append(" CountTypeId = null,"); //CountTypeId
 }
 }
 
 if (objSysCountEN.IsUpdated(conSysCount.PaperRWCount))
 {
 if (objSysCountEN.PaperRWCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysCountEN.PaperRWCount, conSysCount.PaperRWCount); //PaperRWCount
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysCount.PaperRWCount); //PaperRWCount
 }
 }
 
 if (objSysCountEN.IsUpdated(conSysCount.OkCount))
 {
 if (objSysCountEN.OkCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysCountEN.OkCount, conSysCount.OkCount); //点赞统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysCount.OkCount); //点赞统计
 }
 }
 
 if (objSysCountEN.IsUpdated(conSysCount.CollectionCount))
 {
 if (objSysCountEN.CollectionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysCountEN.CollectionCount, conSysCount.CollectionCount); //收藏数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysCount.CollectionCount); //收藏数量
 }
 }
 
 if (objSysCountEN.IsUpdated(conSysCount.DownloadCount))
 {
 if (objSysCountEN.DownloadCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysCountEN.DownloadCount, conSysCount.DownloadCount); //下载数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysCount.DownloadCount); //下载数
 }
 }
 
 if (objSysCountEN.IsUpdated(conSysCount.AttachmentCount))
 {
 if (objSysCountEN.AttachmentCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysCountEN.AttachmentCount, conSysCount.AttachmentCount); //附件计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysCount.AttachmentCount); //附件计数
 }
 }
 
 if (objSysCountEN.IsUpdated(conSysCount.CommentCount))
 {
 if (objSysCountEN.CommentCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysCountEN.CommentCount, conSysCount.CommentCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysCount.CommentCount); //评论数
 }
 }
 
 if (objSysCountEN.IsUpdated(conSysCount.Score))
 {
 if (objSysCountEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysCountEN.Score, conSysCount.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysCount.Score); //评分
 }
 }
 
 if (objSysCountEN.IsUpdated(conSysCount.StuScore))
 {
 if (objSysCountEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysCountEN.StuScore, conSysCount.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysCount.StuScore); //学生平均分
 }
 }
 
 if (objSysCountEN.IsUpdated(conSysCount.TeaScore))
 {
 if (objSysCountEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysCountEN.TeaScore, conSysCount.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysCount.TeaScore); //教师评分
 }
 }
 
 if (objSysCountEN.IsUpdated(conSysCount.TableKey))
 {
 if (objSysCountEN.TableKey !=  null)
 {
 var strTableKey = objSysCountEN.TableKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TableKey = '{0}',", strTableKey); //表主键
 }
 else
 {
 sbSQL.Append(" TableKey = null,"); //表主键
 }
 }
 
 if (objSysCountEN.IsUpdated(conSysCount.ParentId))
 {
 if (objSysCountEN.ParentId !=  null)
 {
 var strParentId = objSysCountEN.ParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParentId = '{0}',", strParentId); //父Id
 }
 else
 {
 sbSQL.Append(" ParentId = null,"); //父Id
 }
 }
 
 if (objSysCountEN.IsUpdated(conSysCount.UpdUser))
 {
 if (objSysCountEN.UpdUser !=  null)
 {
 var strUpdUser = objSysCountEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objSysCountEN.IsUpdated(conSysCount.UpdDate))
 {
 if (objSysCountEN.UpdDate !=  null)
 {
 var strUpdDate = objSysCountEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objSysCountEN.IsUpdated(conSysCount.Memo))
 {
 if (objSysCountEN.Memo !=  null)
 {
 var strMemo = objSysCountEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objSysCountEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsSysCountEN objSysCountEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objSysCountEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSysCountEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSysCountEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysCountDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update SysCount Set ");
 
 if (objSysCountEN.IsUpdated(conSysCount.CountTypeId))
 {
 if (objSysCountEN.CountTypeId !=  null)
 {
 var strCountTypeId = objSysCountEN.CountTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CountTypeId = '{0}',", strCountTypeId); //CountTypeId
 }
 else
 {
 sbSQL.Append(" CountTypeId = null,"); //CountTypeId
 }
 }
 
 if (objSysCountEN.IsUpdated(conSysCount.PaperRWCount))
 {
 if (objSysCountEN.PaperRWCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysCountEN.PaperRWCount, conSysCount.PaperRWCount); //PaperRWCount
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysCount.PaperRWCount); //PaperRWCount
 }
 }
 
 if (objSysCountEN.IsUpdated(conSysCount.OkCount))
 {
 if (objSysCountEN.OkCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysCountEN.OkCount, conSysCount.OkCount); //点赞统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysCount.OkCount); //点赞统计
 }
 }
 
 if (objSysCountEN.IsUpdated(conSysCount.CollectionCount))
 {
 if (objSysCountEN.CollectionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysCountEN.CollectionCount, conSysCount.CollectionCount); //收藏数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysCount.CollectionCount); //收藏数量
 }
 }
 
 if (objSysCountEN.IsUpdated(conSysCount.DownloadCount))
 {
 if (objSysCountEN.DownloadCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysCountEN.DownloadCount, conSysCount.DownloadCount); //下载数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysCount.DownloadCount); //下载数
 }
 }
 
 if (objSysCountEN.IsUpdated(conSysCount.AttachmentCount))
 {
 if (objSysCountEN.AttachmentCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysCountEN.AttachmentCount, conSysCount.AttachmentCount); //附件计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysCount.AttachmentCount); //附件计数
 }
 }
 
 if (objSysCountEN.IsUpdated(conSysCount.CommentCount))
 {
 if (objSysCountEN.CommentCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysCountEN.CommentCount, conSysCount.CommentCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysCount.CommentCount); //评论数
 }
 }
 
 if (objSysCountEN.IsUpdated(conSysCount.Score))
 {
 if (objSysCountEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysCountEN.Score, conSysCount.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysCount.Score); //评分
 }
 }
 
 if (objSysCountEN.IsUpdated(conSysCount.StuScore))
 {
 if (objSysCountEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysCountEN.StuScore, conSysCount.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysCount.StuScore); //学生平均分
 }
 }
 
 if (objSysCountEN.IsUpdated(conSysCount.TeaScore))
 {
 if (objSysCountEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysCountEN.TeaScore, conSysCount.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysCount.TeaScore); //教师评分
 }
 }
 
 if (objSysCountEN.IsUpdated(conSysCount.TableKey))
 {
 if (objSysCountEN.TableKey !=  null)
 {
 var strTableKey = objSysCountEN.TableKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TableKey = '{0}',", strTableKey); //表主键
 }
 else
 {
 sbSQL.Append(" TableKey = null,"); //表主键
 }
 }
 
 if (objSysCountEN.IsUpdated(conSysCount.ParentId))
 {
 if (objSysCountEN.ParentId !=  null)
 {
 var strParentId = objSysCountEN.ParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParentId = '{0}',", strParentId); //父Id
 }
 else
 {
 sbSQL.Append(" ParentId = null,"); //父Id
 }
 }
 
 if (objSysCountEN.IsUpdated(conSysCount.UpdUser))
 {
 if (objSysCountEN.UpdUser !=  null)
 {
 var strUpdUser = objSysCountEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objSysCountEN.IsUpdated(conSysCount.UpdDate))
 {
 if (objSysCountEN.UpdDate !=  null)
 {
 var strUpdDate = objSysCountEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objSysCountEN.IsUpdated(conSysCount.Memo))
 {
 if (objSysCountEN.Memo !=  null)
 {
 var strMemo = objSysCountEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objSysCountEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsSysCountEN objSysCountEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objSysCountEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSysCountEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSysCountEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysCountDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update SysCount Set ");
 
 if (objSysCountEN.IsUpdated(conSysCount.CountTypeId))
 {
 if (objSysCountEN.CountTypeId !=  null)
 {
 var strCountTypeId = objSysCountEN.CountTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCountTypeId, conSysCount.CountTypeId); //CountTypeId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysCount.CountTypeId); //CountTypeId
 }
 }
 
 if (objSysCountEN.IsUpdated(conSysCount.PaperRWCount))
 {
 if (objSysCountEN.PaperRWCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysCountEN.PaperRWCount, conSysCount.PaperRWCount); //PaperRWCount
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysCount.PaperRWCount); //PaperRWCount
 }
 }
 
 if (objSysCountEN.IsUpdated(conSysCount.OkCount))
 {
 if (objSysCountEN.OkCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysCountEN.OkCount, conSysCount.OkCount); //点赞统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysCount.OkCount); //点赞统计
 }
 }
 
 if (objSysCountEN.IsUpdated(conSysCount.CollectionCount))
 {
 if (objSysCountEN.CollectionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysCountEN.CollectionCount, conSysCount.CollectionCount); //收藏数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysCount.CollectionCount); //收藏数量
 }
 }
 
 if (objSysCountEN.IsUpdated(conSysCount.DownloadCount))
 {
 if (objSysCountEN.DownloadCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysCountEN.DownloadCount, conSysCount.DownloadCount); //下载数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysCount.DownloadCount); //下载数
 }
 }
 
 if (objSysCountEN.IsUpdated(conSysCount.AttachmentCount))
 {
 if (objSysCountEN.AttachmentCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysCountEN.AttachmentCount, conSysCount.AttachmentCount); //附件计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysCount.AttachmentCount); //附件计数
 }
 }
 
 if (objSysCountEN.IsUpdated(conSysCount.CommentCount))
 {
 if (objSysCountEN.CommentCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysCountEN.CommentCount, conSysCount.CommentCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysCount.CommentCount); //评论数
 }
 }
 
 if (objSysCountEN.IsUpdated(conSysCount.Score))
 {
 if (objSysCountEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysCountEN.Score, conSysCount.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysCount.Score); //评分
 }
 }
 
 if (objSysCountEN.IsUpdated(conSysCount.StuScore))
 {
 if (objSysCountEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysCountEN.StuScore, conSysCount.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysCount.StuScore); //学生平均分
 }
 }
 
 if (objSysCountEN.IsUpdated(conSysCount.TeaScore))
 {
 if (objSysCountEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysCountEN.TeaScore, conSysCount.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysCount.TeaScore); //教师评分
 }
 }
 
 if (objSysCountEN.IsUpdated(conSysCount.TableKey))
 {
 if (objSysCountEN.TableKey !=  null)
 {
 var strTableKey = objSysCountEN.TableKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTableKey, conSysCount.TableKey); //表主键
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysCount.TableKey); //表主键
 }
 }
 
 if (objSysCountEN.IsUpdated(conSysCount.ParentId))
 {
 if (objSysCountEN.ParentId !=  null)
 {
 var strParentId = objSysCountEN.ParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParentId, conSysCount.ParentId); //父Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysCount.ParentId); //父Id
 }
 }
 
 if (objSysCountEN.IsUpdated(conSysCount.UpdUser))
 {
 if (objSysCountEN.UpdUser !=  null)
 {
 var strUpdUser = objSysCountEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conSysCount.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysCount.UpdUser); //修改人
 }
 }
 
 if (objSysCountEN.IsUpdated(conSysCount.UpdDate))
 {
 if (objSysCountEN.UpdDate !=  null)
 {
 var strUpdDate = objSysCountEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conSysCount.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysCount.UpdDate); //修改日期
 }
 }
 
 if (objSysCountEN.IsUpdated(conSysCount.Memo))
 {
 if (objSysCountEN.Memo !=  null)
 {
 var strMemo = objSysCountEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conSysCount.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysCount.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where CountId = '{0}'", objSysCountEN.CountId); 
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
 /// <param name = "strCountId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strCountId) 
{
CheckPrimaryKey(strCountId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysCountDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strCountId,
};
 objSQL.ExecSP("SysCount_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strCountId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strCountId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strCountId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysCountDA.GetSpecSQLObj();
//删除SysCount本表中与当前对象有关的记录
strSQL = strSQL + "Delete from SysCount where CountId = " + "'"+ strCountId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelSysCount(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysCountDA.GetSpecSQLObj();
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
//删除SysCount本表中与当前对象有关的记录
strSQL = strSQL + "Delete from SysCount where CountId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strCountId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strCountId) 
{
CheckPrimaryKey(strCountId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysCountDA.GetSpecSQLObj();
//删除SysCount本表中与当前对象有关的记录
strSQL = strSQL + "Delete from SysCount where CountId = " + "'"+ strCountId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelSysCount(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsSysCountDA: DelSysCount)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysCountDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from SysCount where " + strCondition ;
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
public bool DelSysCountWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsSysCountDA: DelSysCountWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysCountDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from SysCount where " + strCondition ;
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
 /// <param name = "objSysCountENS">源对象</param>
 /// <param name = "objSysCountENT">目标对象</param>
public void CopyTo(clsSysCountEN objSysCountENS, clsSysCountEN objSysCountENT)
{
objSysCountENT.CountId = objSysCountENS.CountId; //CountId
objSysCountENT.CountTypeId = objSysCountENS.CountTypeId; //CountTypeId
objSysCountENT.PaperRWCount = objSysCountENS.PaperRWCount; //PaperRWCount
objSysCountENT.OkCount = objSysCountENS.OkCount; //点赞统计
objSysCountENT.CollectionCount = objSysCountENS.CollectionCount; //收藏数量
objSysCountENT.DownloadCount = objSysCountENS.DownloadCount; //下载数
objSysCountENT.AttachmentCount = objSysCountENS.AttachmentCount; //附件计数
objSysCountENT.CommentCount = objSysCountENS.CommentCount; //评论数
objSysCountENT.Score = objSysCountENS.Score; //评分
objSysCountENT.StuScore = objSysCountENS.StuScore; //学生平均分
objSysCountENT.TeaScore = objSysCountENS.TeaScore; //教师评分
objSysCountENT.TableKey = objSysCountENS.TableKey; //表主键
objSysCountENT.ParentId = objSysCountENS.ParentId; //父Id
objSysCountENT.UpdUser = objSysCountENS.UpdUser; //修改人
objSysCountENT.UpdDate = objSysCountENS.UpdDate; //修改日期
objSysCountENT.Memo = objSysCountENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsSysCountEN objSysCountEN)
{
//检查字段不能为空(NULL)
//检查字段长度
clsCheckSql.CheckFieldLen(objSysCountEN.CountId, 10, conSysCount.CountId);
clsCheckSql.CheckFieldLen(objSysCountEN.CountTypeId, 2, conSysCount.CountTypeId);
clsCheckSql.CheckFieldLen(objSysCountEN.TableKey, 20, conSysCount.TableKey);
clsCheckSql.CheckFieldLen(objSysCountEN.ParentId, 20, conSysCount.ParentId);
clsCheckSql.CheckFieldLen(objSysCountEN.UpdUser, 20, conSysCount.UpdUser);
clsCheckSql.CheckFieldLen(objSysCountEN.UpdDate, 20, conSysCount.UpdDate);
clsCheckSql.CheckFieldLen(objSysCountEN.Memo, 1000, conSysCount.Memo);
//检查字段外键固定长度
 objSysCountEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsSysCountEN objSysCountEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objSysCountEN.CountTypeId, 2, conSysCount.CountTypeId);
clsCheckSql.CheckFieldLen(objSysCountEN.TableKey, 20, conSysCount.TableKey);
clsCheckSql.CheckFieldLen(objSysCountEN.ParentId, 20, conSysCount.ParentId);
clsCheckSql.CheckFieldLen(objSysCountEN.UpdUser, 20, conSysCount.UpdUser);
clsCheckSql.CheckFieldLen(objSysCountEN.UpdDate, 20, conSysCount.UpdDate);
clsCheckSql.CheckFieldLen(objSysCountEN.Memo, 1000, conSysCount.Memo);
//检查外键字段长度
 objSysCountEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsSysCountEN objSysCountEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objSysCountEN.CountId, 10, conSysCount.CountId);
clsCheckSql.CheckFieldLen(objSysCountEN.CountTypeId, 2, conSysCount.CountTypeId);
clsCheckSql.CheckFieldLen(objSysCountEN.TableKey, 20, conSysCount.TableKey);
clsCheckSql.CheckFieldLen(objSysCountEN.ParentId, 20, conSysCount.ParentId);
clsCheckSql.CheckFieldLen(objSysCountEN.UpdUser, 20, conSysCount.UpdUser);
clsCheckSql.CheckFieldLen(objSysCountEN.UpdDate, 20, conSysCount.UpdDate);
clsCheckSql.CheckFieldLen(objSysCountEN.Memo, 1000, conSysCount.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objSysCountEN.CountId, conSysCount.CountId);
clsCheckSql.CheckSqlInjection4Field(objSysCountEN.CountTypeId, conSysCount.CountTypeId);
clsCheckSql.CheckSqlInjection4Field(objSysCountEN.TableKey, conSysCount.TableKey);
clsCheckSql.CheckSqlInjection4Field(objSysCountEN.ParentId, conSysCount.ParentId);
clsCheckSql.CheckSqlInjection4Field(objSysCountEN.UpdUser, conSysCount.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objSysCountEN.UpdDate, conSysCount.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objSysCountEN.Memo, conSysCount.Memo);
//检查外键字段长度
 objSysCountEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--SysCount(统计数据),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objSysCountEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsSysCountEN objSysCountEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 if (objSysCountEN.CountTypeId == null)
{
 sbCondition.AppendFormat(" and CountTypeId is null");
}
else
{
 sbCondition.AppendFormat(" and CountTypeId = '{0}'", objSysCountEN.CountTypeId);
}
 if (objSysCountEN.TableKey == null)
{
 sbCondition.AppendFormat(" and TableKey is null");
}
else
{
 sbCondition.AppendFormat(" and TableKey = '{0}'", objSysCountEN.TableKey);
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
 objSQL = clsSysCountDA.GetSpecSQLObj();
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
 objSQL = clsSysCountDA.GetSpecSQLObj();
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
 objSQL = clsSysCountDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsSysCountEN._CurrTabName);
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
 objSQL = clsSysCountDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsSysCountEN._CurrTabName, strCondition);
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
 objSQL = clsSysCountDA.GetSpecSQLObj();
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
 objSQL = clsSysCountDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}