
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_SysCountDA
 表名:zx_SysCount(01120797)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:53:24
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
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
 /// 中学统计数据(zx_SysCount)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clszx_SysCountDA : clsCommBase4DA
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
 return clszx_SysCountEN._CurrTabName;
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
if (string.IsNullOrEmpty(clszx_SysCountEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clszx_SysCountEN._ConnectString);
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
 if (string.IsNullOrEmpty(clszx_SysCountEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clszx_SysCountEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strzxCountId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strzxCountId)
{
strzxCountId = strzxCountId.Replace("'", "''");
if (strzxCountId.Length > 10)
{
throw new Exception("(errid:Data000001)在表:zx_SysCount中,检查关键字,长度不正确!(clszx_SysCountDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strzxCountId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:zx_SysCount中,关键字不能为空 或 null!(clszx_SysCountDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strzxCountId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clszx_SysCountDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clszx_SysCountDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SysCountDA.GetSpecSQLObj();
strSQL = "Select * from zx_SysCount where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_zx_SysCount(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clszx_SysCountDA: GetDataTable_zx_SysCount)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SysCountDA.GetSpecSQLObj();
strSQL = "Select * from zx_SysCount where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clszx_SysCountDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SysCountDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clszx_SysCountDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SysCountDA.GetSpecSQLObj();
strSQL = "Select * from zx_SysCount where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clszx_SysCountDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SysCountDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clszx_SysCountDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SysCountDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_SysCount where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_SysCount where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clszx_SysCountDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SysCountDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from zx_SysCount where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clszx_SysCountDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SysCountDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} zx_SysCount.* from zx_SysCount Left Join {1} on {2} where {3} and zx_SysCount.zxCountId not in (Select top {5} zx_SysCount.zxCountId from zx_SysCount Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_SysCount where {1} and zxCountId not in (Select top {2} zxCountId from zx_SysCount where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_SysCount where {1} and zxCountId not in (Select top {3} zxCountId from zx_SysCount where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clszx_SysCountDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SysCountDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} zx_SysCount.* from zx_SysCount Left Join {1} on {2} where {3} and zx_SysCount.zxCountId not in (Select top {5} zx_SysCount.zxCountId from zx_SysCount Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_SysCount where {1} and zxCountId not in (Select top {2} zxCountId from zx_SysCount where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_SysCount where {1} and zxCountId not in (Select top {3} zxCountId from zx_SysCount where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clszx_SysCountEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clszx_SysCountDA:GetObjLst)", objException.Message));
}
List<clszx_SysCountEN> arrObjLst = new List<clszx_SysCountEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SysCountDA.GetSpecSQLObj();
strSQL = "Select * from zx_SysCount where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_SysCountEN objzx_SysCountEN = new clszx_SysCountEN();
try
{
objzx_SysCountEN.zxCountId = objRow[conzx_SysCount.zxCountId].ToString().Trim(); //CountId
objzx_SysCountEN.CountTypeId = objRow[conzx_SysCount.CountTypeId] == DBNull.Value ? null : objRow[conzx_SysCount.CountTypeId].ToString().Trim(); //CountTypeId
objzx_SysCountEN.PaperRWCount = objRow[conzx_SysCount.PaperRWCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SysCount.PaperRWCount].ToString().Trim()); //PaperRWCount
objzx_SysCountEN.OkCount = objRow[conzx_SysCount.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SysCount.OkCount].ToString().Trim()); //点赞统计
objzx_SysCountEN.CollectionCount = objRow[conzx_SysCount.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conzx_SysCount.CollectionCount].ToString().Trim()); //收藏数量
objzx_SysCountEN.DownloadCount = objRow[conzx_SysCount.DownloadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SysCount.DownloadCount].ToString().Trim()); //下载数
objzx_SysCountEN.AttachmentCount = objRow[conzx_SysCount.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SysCount.AttachmentCount].ToString().Trim()); //附件计数
objzx_SysCountEN.CommentCount = objRow[conzx_SysCount.CommentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SysCount.CommentCount].ToString().Trim()); //评论数
objzx_SysCountEN.Score = objRow[conzx_SysCount.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_SysCount.Score].ToString().Trim()); //评分
objzx_SysCountEN.StuScore = objRow[conzx_SysCount.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_SysCount.StuScore].ToString().Trim()); //学生平均分
objzx_SysCountEN.TeaScore = objRow[conzx_SysCount.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_SysCount.TeaScore].ToString().Trim()); //教师评分
objzx_SysCountEN.TableKey = objRow[conzx_SysCount.TableKey] == DBNull.Value ? null : objRow[conzx_SysCount.TableKey].ToString().Trim(); //表主键
objzx_SysCountEN.ParentId = objRow[conzx_SysCount.ParentId] == DBNull.Value ? null : objRow[conzx_SysCount.ParentId].ToString().Trim(); //父Id
objzx_SysCountEN.UpdUser = objRow[conzx_SysCount.UpdUser] == DBNull.Value ? null : objRow[conzx_SysCount.UpdUser].ToString().Trim(); //修改人
objzx_SysCountEN.UpdDate = objRow[conzx_SysCount.UpdDate] == DBNull.Value ? null : objRow[conzx_SysCount.UpdDate].ToString().Trim(); //修改日期
objzx_SysCountEN.Memo = objRow[conzx_SysCount.Memo] == DBNull.Value ? null : objRow[conzx_SysCount.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clszx_SysCountDA: GetObjLst)", objException.Message));
}
objzx_SysCountEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objzx_SysCountEN);
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
public List<clszx_SysCountEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clszx_SysCountDA:GetObjLstByTabName)", objException.Message));
}
List<clszx_SysCountEN> arrObjLst = new List<clszx_SysCountEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SysCountDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_SysCountEN objzx_SysCountEN = new clszx_SysCountEN();
try
{
objzx_SysCountEN.zxCountId = objRow[conzx_SysCount.zxCountId].ToString().Trim(); //CountId
objzx_SysCountEN.CountTypeId = objRow[conzx_SysCount.CountTypeId] == DBNull.Value ? null : objRow[conzx_SysCount.CountTypeId].ToString().Trim(); //CountTypeId
objzx_SysCountEN.PaperRWCount = objRow[conzx_SysCount.PaperRWCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SysCount.PaperRWCount].ToString().Trim()); //PaperRWCount
objzx_SysCountEN.OkCount = objRow[conzx_SysCount.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SysCount.OkCount].ToString().Trim()); //点赞统计
objzx_SysCountEN.CollectionCount = objRow[conzx_SysCount.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conzx_SysCount.CollectionCount].ToString().Trim()); //收藏数量
objzx_SysCountEN.DownloadCount = objRow[conzx_SysCount.DownloadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SysCount.DownloadCount].ToString().Trim()); //下载数
objzx_SysCountEN.AttachmentCount = objRow[conzx_SysCount.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SysCount.AttachmentCount].ToString().Trim()); //附件计数
objzx_SysCountEN.CommentCount = objRow[conzx_SysCount.CommentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SysCount.CommentCount].ToString().Trim()); //评论数
objzx_SysCountEN.Score = objRow[conzx_SysCount.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_SysCount.Score].ToString().Trim()); //评分
objzx_SysCountEN.StuScore = objRow[conzx_SysCount.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_SysCount.StuScore].ToString().Trim()); //学生平均分
objzx_SysCountEN.TeaScore = objRow[conzx_SysCount.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_SysCount.TeaScore].ToString().Trim()); //教师评分
objzx_SysCountEN.TableKey = objRow[conzx_SysCount.TableKey] == DBNull.Value ? null : objRow[conzx_SysCount.TableKey].ToString().Trim(); //表主键
objzx_SysCountEN.ParentId = objRow[conzx_SysCount.ParentId] == DBNull.Value ? null : objRow[conzx_SysCount.ParentId].ToString().Trim(); //父Id
objzx_SysCountEN.UpdUser = objRow[conzx_SysCount.UpdUser] == DBNull.Value ? null : objRow[conzx_SysCount.UpdUser].ToString().Trim(); //修改人
objzx_SysCountEN.UpdDate = objRow[conzx_SysCount.UpdDate] == DBNull.Value ? null : objRow[conzx_SysCount.UpdDate].ToString().Trim(); //修改日期
objzx_SysCountEN.Memo = objRow[conzx_SysCount.Memo] == DBNull.Value ? null : objRow[conzx_SysCount.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clszx_SysCountDA: GetObjLst)", objException.Message));
}
objzx_SysCountEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objzx_SysCountEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objzx_SysCountEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getzx_SysCount(ref clszx_SysCountEN objzx_SysCountEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SysCountDA.GetSpecSQLObj();
strSQL = "Select * from zx_SysCount where zxCountId = " + "'"+ objzx_SysCountEN.zxCountId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objzx_SysCountEN.zxCountId = objDT.Rows[0][conzx_SysCount.zxCountId].ToString().Trim(); //CountId(字段类型:char,字段长度:10,是否可空:False)
 objzx_SysCountEN.CountTypeId = objDT.Rows[0][conzx_SysCount.CountTypeId].ToString().Trim(); //CountTypeId(字段类型:char,字段长度:2,是否可空:True)
 objzx_SysCountEN.PaperRWCount = TransNullToInt(objDT.Rows[0][conzx_SysCount.PaperRWCount].ToString().Trim()); //PaperRWCount(字段类型:int,字段长度:4,是否可空:True)
 objzx_SysCountEN.OkCount = TransNullToInt(objDT.Rows[0][conzx_SysCount.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objzx_SysCountEN.CollectionCount = TransNullToInt(objDT.Rows[0][conzx_SysCount.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objzx_SysCountEN.DownloadCount = TransNullToInt(objDT.Rows[0][conzx_SysCount.DownloadCount].ToString().Trim()); //下载数(字段类型:int,字段长度:4,是否可空:True)
 objzx_SysCountEN.AttachmentCount = TransNullToInt(objDT.Rows[0][conzx_SysCount.AttachmentCount].ToString().Trim()); //附件计数(字段类型:int,字段长度:4,是否可空:True)
 objzx_SysCountEN.CommentCount = TransNullToInt(objDT.Rows[0][conzx_SysCount.CommentCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objzx_SysCountEN.Score = TransNullToFloat(objDT.Rows[0][conzx_SysCount.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objzx_SysCountEN.StuScore = TransNullToFloat(objDT.Rows[0][conzx_SysCount.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objzx_SysCountEN.TeaScore = TransNullToFloat(objDT.Rows[0][conzx_SysCount.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objzx_SysCountEN.TableKey = objDT.Rows[0][conzx_SysCount.TableKey].ToString().Trim(); //表主键(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_SysCountEN.ParentId = objDT.Rows[0][conzx_SysCount.ParentId].ToString().Trim(); //父Id(字段类型:varchar,字段长度:20,是否可空:False)
 objzx_SysCountEN.UpdUser = objDT.Rows[0][conzx_SysCount.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_SysCountEN.UpdDate = objDT.Rows[0][conzx_SysCount.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_SysCountEN.Memo = objDT.Rows[0][conzx_SysCount.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clszx_SysCountDA: Getzx_SysCount)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strzxCountId">表关键字</param>
 /// <returns>表对象</returns>
public clszx_SysCountEN GetObjByzxCountId(string strzxCountId)
{
CheckPrimaryKey(strzxCountId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SysCountDA.GetSpecSQLObj();
strSQL = "Select * from zx_SysCount where zxCountId = " + "'"+ strzxCountId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clszx_SysCountEN objzx_SysCountEN = new clszx_SysCountEN();
try
{
 objzx_SysCountEN.zxCountId = objRow[conzx_SysCount.zxCountId].ToString().Trim(); //CountId(字段类型:char,字段长度:10,是否可空:False)
 objzx_SysCountEN.CountTypeId = objRow[conzx_SysCount.CountTypeId] == DBNull.Value ? null : objRow[conzx_SysCount.CountTypeId].ToString().Trim(); //CountTypeId(字段类型:char,字段长度:2,是否可空:True)
 objzx_SysCountEN.PaperRWCount = objRow[conzx_SysCount.PaperRWCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SysCount.PaperRWCount].ToString().Trim()); //PaperRWCount(字段类型:int,字段长度:4,是否可空:True)
 objzx_SysCountEN.OkCount = objRow[conzx_SysCount.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SysCount.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objzx_SysCountEN.CollectionCount = objRow[conzx_SysCount.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SysCount.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objzx_SysCountEN.DownloadCount = objRow[conzx_SysCount.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SysCount.DownloadCount].ToString().Trim()); //下载数(字段类型:int,字段长度:4,是否可空:True)
 objzx_SysCountEN.AttachmentCount = objRow[conzx_SysCount.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SysCount.AttachmentCount].ToString().Trim()); //附件计数(字段类型:int,字段长度:4,是否可空:True)
 objzx_SysCountEN.CommentCount = objRow[conzx_SysCount.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SysCount.CommentCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objzx_SysCountEN.Score = objRow[conzx_SysCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SysCount.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objzx_SysCountEN.StuScore = objRow[conzx_SysCount.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SysCount.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objzx_SysCountEN.TeaScore = objRow[conzx_SysCount.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SysCount.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objzx_SysCountEN.TableKey = objRow[conzx_SysCount.TableKey] == DBNull.Value ? null : objRow[conzx_SysCount.TableKey].ToString().Trim(); //表主键(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_SysCountEN.ParentId = objRow[conzx_SysCount.ParentId] == DBNull.Value ? null : objRow[conzx_SysCount.ParentId].ToString().Trim(); //父Id(字段类型:varchar,字段长度:20,是否可空:False)
 objzx_SysCountEN.UpdUser = objRow[conzx_SysCount.UpdUser] == DBNull.Value ? null : objRow[conzx_SysCount.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_SysCountEN.UpdDate = objRow[conzx_SysCount.UpdDate] == DBNull.Value ? null : objRow[conzx_SysCount.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_SysCountEN.Memo = objRow[conzx_SysCount.Memo] == DBNull.Value ? null : objRow[conzx_SysCount.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clszx_SysCountDA: GetObjByzxCountId)", objException.Message));
}
return objzx_SysCountEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clszx_SysCountEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clszx_SysCountDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SysCountDA.GetSpecSQLObj();
strSQL = "Select * from zx_SysCount where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clszx_SysCountEN objzx_SysCountEN = new clszx_SysCountEN()
{
zxCountId = objRow[conzx_SysCount.zxCountId].ToString().Trim(), //CountId
CountTypeId = objRow[conzx_SysCount.CountTypeId] == DBNull.Value ? null : objRow[conzx_SysCount.CountTypeId].ToString().Trim(), //CountTypeId
PaperRWCount = objRow[conzx_SysCount.PaperRWCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SysCount.PaperRWCount].ToString().Trim()), //PaperRWCount
OkCount = objRow[conzx_SysCount.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SysCount.OkCount].ToString().Trim()), //点赞统计
CollectionCount = objRow[conzx_SysCount.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conzx_SysCount.CollectionCount].ToString().Trim()), //收藏数量
DownloadCount = objRow[conzx_SysCount.DownloadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SysCount.DownloadCount].ToString().Trim()), //下载数
AttachmentCount = objRow[conzx_SysCount.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SysCount.AttachmentCount].ToString().Trim()), //附件计数
CommentCount = objRow[conzx_SysCount.CommentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SysCount.CommentCount].ToString().Trim()), //评论数
Score = objRow[conzx_SysCount.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_SysCount.Score].ToString().Trim()), //评分
StuScore = objRow[conzx_SysCount.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_SysCount.StuScore].ToString().Trim()), //学生平均分
TeaScore = objRow[conzx_SysCount.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_SysCount.TeaScore].ToString().Trim()), //教师评分
TableKey = objRow[conzx_SysCount.TableKey] == DBNull.Value ? null : objRow[conzx_SysCount.TableKey].ToString().Trim(), //表主键
ParentId = objRow[conzx_SysCount.ParentId] == DBNull.Value ? null : objRow[conzx_SysCount.ParentId].ToString().Trim(), //父Id
UpdUser = objRow[conzx_SysCount.UpdUser] == DBNull.Value ? null : objRow[conzx_SysCount.UpdUser].ToString().Trim(), //修改人
UpdDate = objRow[conzx_SysCount.UpdDate] == DBNull.Value ? null : objRow[conzx_SysCount.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[conzx_SysCount.Memo] == DBNull.Value ? null : objRow[conzx_SysCount.Memo].ToString().Trim() //备注
};
objzx_SysCountEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_SysCountEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clszx_SysCountDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clszx_SysCountEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clszx_SysCountEN objzx_SysCountEN = new clszx_SysCountEN();
try
{
objzx_SysCountEN.zxCountId = objRow[conzx_SysCount.zxCountId].ToString().Trim(); //CountId
objzx_SysCountEN.CountTypeId = objRow[conzx_SysCount.CountTypeId] == DBNull.Value ? null : objRow[conzx_SysCount.CountTypeId].ToString().Trim(); //CountTypeId
objzx_SysCountEN.PaperRWCount = objRow[conzx_SysCount.PaperRWCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SysCount.PaperRWCount].ToString().Trim()); //PaperRWCount
objzx_SysCountEN.OkCount = objRow[conzx_SysCount.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SysCount.OkCount].ToString().Trim()); //点赞统计
objzx_SysCountEN.CollectionCount = objRow[conzx_SysCount.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conzx_SysCount.CollectionCount].ToString().Trim()); //收藏数量
objzx_SysCountEN.DownloadCount = objRow[conzx_SysCount.DownloadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SysCount.DownloadCount].ToString().Trim()); //下载数
objzx_SysCountEN.AttachmentCount = objRow[conzx_SysCount.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SysCount.AttachmentCount].ToString().Trim()); //附件计数
objzx_SysCountEN.CommentCount = objRow[conzx_SysCount.CommentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SysCount.CommentCount].ToString().Trim()); //评论数
objzx_SysCountEN.Score = objRow[conzx_SysCount.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_SysCount.Score].ToString().Trim()); //评分
objzx_SysCountEN.StuScore = objRow[conzx_SysCount.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_SysCount.StuScore].ToString().Trim()); //学生平均分
objzx_SysCountEN.TeaScore = objRow[conzx_SysCount.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_SysCount.TeaScore].ToString().Trim()); //教师评分
objzx_SysCountEN.TableKey = objRow[conzx_SysCount.TableKey] == DBNull.Value ? null : objRow[conzx_SysCount.TableKey].ToString().Trim(); //表主键
objzx_SysCountEN.ParentId = objRow[conzx_SysCount.ParentId] == DBNull.Value ? null : objRow[conzx_SysCount.ParentId].ToString().Trim(); //父Id
objzx_SysCountEN.UpdUser = objRow[conzx_SysCount.UpdUser] == DBNull.Value ? null : objRow[conzx_SysCount.UpdUser].ToString().Trim(); //修改人
objzx_SysCountEN.UpdDate = objRow[conzx_SysCount.UpdDate] == DBNull.Value ? null : objRow[conzx_SysCount.UpdDate].ToString().Trim(); //修改日期
objzx_SysCountEN.Memo = objRow[conzx_SysCount.Memo] == DBNull.Value ? null : objRow[conzx_SysCount.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clszx_SysCountDA: GetObjByDataRowzx_SysCount)", objException.Message));
}
objzx_SysCountEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_SysCountEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clszx_SysCountEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clszx_SysCountEN objzx_SysCountEN = new clszx_SysCountEN();
try
{
objzx_SysCountEN.zxCountId = objRow[conzx_SysCount.zxCountId].ToString().Trim(); //CountId
objzx_SysCountEN.CountTypeId = objRow[conzx_SysCount.CountTypeId] == DBNull.Value ? null : objRow[conzx_SysCount.CountTypeId].ToString().Trim(); //CountTypeId
objzx_SysCountEN.PaperRWCount = objRow[conzx_SysCount.PaperRWCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SysCount.PaperRWCount].ToString().Trim()); //PaperRWCount
objzx_SysCountEN.OkCount = objRow[conzx_SysCount.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SysCount.OkCount].ToString().Trim()); //点赞统计
objzx_SysCountEN.CollectionCount = objRow[conzx_SysCount.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conzx_SysCount.CollectionCount].ToString().Trim()); //收藏数量
objzx_SysCountEN.DownloadCount = objRow[conzx_SysCount.DownloadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SysCount.DownloadCount].ToString().Trim()); //下载数
objzx_SysCountEN.AttachmentCount = objRow[conzx_SysCount.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SysCount.AttachmentCount].ToString().Trim()); //附件计数
objzx_SysCountEN.CommentCount = objRow[conzx_SysCount.CommentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SysCount.CommentCount].ToString().Trim()); //评论数
objzx_SysCountEN.Score = objRow[conzx_SysCount.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_SysCount.Score].ToString().Trim()); //评分
objzx_SysCountEN.StuScore = objRow[conzx_SysCount.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_SysCount.StuScore].ToString().Trim()); //学生平均分
objzx_SysCountEN.TeaScore = objRow[conzx_SysCount.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_SysCount.TeaScore].ToString().Trim()); //教师评分
objzx_SysCountEN.TableKey = objRow[conzx_SysCount.TableKey] == DBNull.Value ? null : objRow[conzx_SysCount.TableKey].ToString().Trim(); //表主键
objzx_SysCountEN.ParentId = objRow[conzx_SysCount.ParentId] == DBNull.Value ? null : objRow[conzx_SysCount.ParentId].ToString().Trim(); //父Id
objzx_SysCountEN.UpdUser = objRow[conzx_SysCount.UpdUser] == DBNull.Value ? null : objRow[conzx_SysCount.UpdUser].ToString().Trim(); //修改人
objzx_SysCountEN.UpdDate = objRow[conzx_SysCount.UpdDate] == DBNull.Value ? null : objRow[conzx_SysCount.UpdDate].ToString().Trim(); //修改日期
objzx_SysCountEN.Memo = objRow[conzx_SysCount.Memo] == DBNull.Value ? null : objRow[conzx_SysCount.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clszx_SysCountDA: GetObjByDataRow)", objException.Message));
}
objzx_SysCountEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_SysCountEN;
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
objSQL = clszx_SysCountDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clszx_SysCountEN._CurrTabName, conzx_SysCount.zxCountId, 10, "");
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
objSQL = clszx_SysCountDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clszx_SysCountEN._CurrTabName, conzx_SysCount.zxCountId, 10, strPrefix);
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
 objSQL = clszx_SysCountDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select zxCountId from zx_SysCount where " + strCondition;
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
 objSQL = clszx_SysCountDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select zxCountId from zx_SysCount where " + strCondition;
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
 /// <param name = "strzxCountId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strzxCountId)
{
CheckPrimaryKey(strzxCountId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SysCountDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("zx_SysCount", "zxCountId = " + "'"+ strzxCountId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clszx_SysCountDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SysCountDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("zx_SysCount", strCondition))
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
objSQL = clszx_SysCountDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("zx_SysCount");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clszx_SysCountEN objzx_SysCountEN)
 {
 objzx_SysCountEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objzx_SysCountEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_SysCountEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SysCountDA.GetSpecSQLObj();
strSQL = "Select * from zx_SysCount where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "zx_SysCount");
objRow = objDS.Tables["zx_SysCount"].NewRow();
objRow[conzx_SysCount.zxCountId] = objzx_SysCountEN.zxCountId; //CountId
 if (objzx_SysCountEN.CountTypeId !=  "")
 {
objRow[conzx_SysCount.CountTypeId] = objzx_SysCountEN.CountTypeId; //CountTypeId
 }
objRow[conzx_SysCount.PaperRWCount] = objzx_SysCountEN.PaperRWCount; //PaperRWCount
objRow[conzx_SysCount.OkCount] = objzx_SysCountEN.OkCount; //点赞统计
objRow[conzx_SysCount.CollectionCount] = objzx_SysCountEN.CollectionCount; //收藏数量
objRow[conzx_SysCount.DownloadCount] = objzx_SysCountEN.DownloadCount; //下载数
objRow[conzx_SysCount.AttachmentCount] = objzx_SysCountEN.AttachmentCount; //附件计数
objRow[conzx_SysCount.CommentCount] = objzx_SysCountEN.CommentCount; //评论数
objRow[conzx_SysCount.Score] = objzx_SysCountEN.Score; //评分
objRow[conzx_SysCount.StuScore] = objzx_SysCountEN.StuScore; //学生平均分
objRow[conzx_SysCount.TeaScore] = objzx_SysCountEN.TeaScore; //教师评分
 if (objzx_SysCountEN.TableKey !=  "")
 {
objRow[conzx_SysCount.TableKey] = objzx_SysCountEN.TableKey; //表主键
 }
 if (objzx_SysCountEN.ParentId !=  "")
 {
objRow[conzx_SysCount.ParentId] = objzx_SysCountEN.ParentId; //父Id
 }
 if (objzx_SysCountEN.UpdUser !=  "")
 {
objRow[conzx_SysCount.UpdUser] = objzx_SysCountEN.UpdUser; //修改人
 }
 if (objzx_SysCountEN.UpdDate !=  "")
 {
objRow[conzx_SysCount.UpdDate] = objzx_SysCountEN.UpdDate; //修改日期
 }
 if (objzx_SysCountEN.Memo !=  "")
 {
objRow[conzx_SysCount.Memo] = objzx_SysCountEN.Memo; //备注
 }
objDS.Tables[clszx_SysCountEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clszx_SysCountEN._CurrTabName);
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
 /// <param name = "objzx_SysCountEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clszx_SysCountEN objzx_SysCountEN)
{
 objzx_SysCountEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objzx_SysCountEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_SysCountEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_SysCountEN.zxCountId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysCount.zxCountId);
 var strzxCountId = objzx_SysCountEN.zxCountId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxCountId + "'");
 }
 
 if (objzx_SysCountEN.CountTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysCount.CountTypeId);
 var strCountTypeId = objzx_SysCountEN.CountTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCountTypeId + "'");
 }
 
 if (objzx_SysCountEN.PaperRWCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysCount.PaperRWCount);
 arrValueListForInsert.Add(objzx_SysCountEN.PaperRWCount.ToString());
 }
 
 if (objzx_SysCountEN.OkCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysCount.OkCount);
 arrValueListForInsert.Add(objzx_SysCountEN.OkCount.ToString());
 }
 
 if (objzx_SysCountEN.CollectionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysCount.CollectionCount);
 arrValueListForInsert.Add(objzx_SysCountEN.CollectionCount.ToString());
 }
 
 if (objzx_SysCountEN.DownloadCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysCount.DownloadCount);
 arrValueListForInsert.Add(objzx_SysCountEN.DownloadCount.ToString());
 }
 
 if (objzx_SysCountEN.AttachmentCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysCount.AttachmentCount);
 arrValueListForInsert.Add(objzx_SysCountEN.AttachmentCount.ToString());
 }
 
 if (objzx_SysCountEN.CommentCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysCount.CommentCount);
 arrValueListForInsert.Add(objzx_SysCountEN.CommentCount.ToString());
 }
 
 if (objzx_SysCountEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysCount.Score);
 arrValueListForInsert.Add(objzx_SysCountEN.Score.ToString());
 }
 
 if (objzx_SysCountEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysCount.StuScore);
 arrValueListForInsert.Add(objzx_SysCountEN.StuScore.ToString());
 }
 
 if (objzx_SysCountEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysCount.TeaScore);
 arrValueListForInsert.Add(objzx_SysCountEN.TeaScore.ToString());
 }
 
 if (objzx_SysCountEN.TableKey !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysCount.TableKey);
 var strTableKey = objzx_SysCountEN.TableKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTableKey + "'");
 }
 
 if (objzx_SysCountEN.ParentId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysCount.ParentId);
 var strParentId = objzx_SysCountEN.ParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParentId + "'");
 }
 
 if (objzx_SysCountEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysCount.UpdUser);
 var strUpdUser = objzx_SysCountEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_SysCountEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysCount.UpdDate);
 var strUpdDate = objzx_SysCountEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_SysCountEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysCount.Memo);
 var strMemo = objzx_SysCountEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_SysCount");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SysCountDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objzx_SysCountEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clszx_SysCountEN objzx_SysCountEN)
{
 objzx_SysCountEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objzx_SysCountEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_SysCountEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_SysCountEN.zxCountId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysCount.zxCountId);
 var strzxCountId = objzx_SysCountEN.zxCountId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxCountId + "'");
 }
 
 if (objzx_SysCountEN.CountTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysCount.CountTypeId);
 var strCountTypeId = objzx_SysCountEN.CountTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCountTypeId + "'");
 }
 
 if (objzx_SysCountEN.PaperRWCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysCount.PaperRWCount);
 arrValueListForInsert.Add(objzx_SysCountEN.PaperRWCount.ToString());
 }
 
 if (objzx_SysCountEN.OkCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysCount.OkCount);
 arrValueListForInsert.Add(objzx_SysCountEN.OkCount.ToString());
 }
 
 if (objzx_SysCountEN.CollectionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysCount.CollectionCount);
 arrValueListForInsert.Add(objzx_SysCountEN.CollectionCount.ToString());
 }
 
 if (objzx_SysCountEN.DownloadCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysCount.DownloadCount);
 arrValueListForInsert.Add(objzx_SysCountEN.DownloadCount.ToString());
 }
 
 if (objzx_SysCountEN.AttachmentCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysCount.AttachmentCount);
 arrValueListForInsert.Add(objzx_SysCountEN.AttachmentCount.ToString());
 }
 
 if (objzx_SysCountEN.CommentCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysCount.CommentCount);
 arrValueListForInsert.Add(objzx_SysCountEN.CommentCount.ToString());
 }
 
 if (objzx_SysCountEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysCount.Score);
 arrValueListForInsert.Add(objzx_SysCountEN.Score.ToString());
 }
 
 if (objzx_SysCountEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysCount.StuScore);
 arrValueListForInsert.Add(objzx_SysCountEN.StuScore.ToString());
 }
 
 if (objzx_SysCountEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysCount.TeaScore);
 arrValueListForInsert.Add(objzx_SysCountEN.TeaScore.ToString());
 }
 
 if (objzx_SysCountEN.TableKey !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysCount.TableKey);
 var strTableKey = objzx_SysCountEN.TableKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTableKey + "'");
 }
 
 if (objzx_SysCountEN.ParentId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysCount.ParentId);
 var strParentId = objzx_SysCountEN.ParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParentId + "'");
 }
 
 if (objzx_SysCountEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysCount.UpdUser);
 var strUpdUser = objzx_SysCountEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_SysCountEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysCount.UpdDate);
 var strUpdDate = objzx_SysCountEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_SysCountEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysCount.Memo);
 var strMemo = objzx_SysCountEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_SysCount");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SysCountDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objzx_SysCountEN.zxCountId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objzx_SysCountEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clszx_SysCountEN objzx_SysCountEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objzx_SysCountEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objzx_SysCountEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_SysCountEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_SysCountEN.zxCountId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysCount.zxCountId);
 var strzxCountId = objzx_SysCountEN.zxCountId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxCountId + "'");
 }
 
 if (objzx_SysCountEN.CountTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysCount.CountTypeId);
 var strCountTypeId = objzx_SysCountEN.CountTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCountTypeId + "'");
 }
 
 if (objzx_SysCountEN.PaperRWCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysCount.PaperRWCount);
 arrValueListForInsert.Add(objzx_SysCountEN.PaperRWCount.ToString());
 }
 
 if (objzx_SysCountEN.OkCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysCount.OkCount);
 arrValueListForInsert.Add(objzx_SysCountEN.OkCount.ToString());
 }
 
 if (objzx_SysCountEN.CollectionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysCount.CollectionCount);
 arrValueListForInsert.Add(objzx_SysCountEN.CollectionCount.ToString());
 }
 
 if (objzx_SysCountEN.DownloadCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysCount.DownloadCount);
 arrValueListForInsert.Add(objzx_SysCountEN.DownloadCount.ToString());
 }
 
 if (objzx_SysCountEN.AttachmentCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysCount.AttachmentCount);
 arrValueListForInsert.Add(objzx_SysCountEN.AttachmentCount.ToString());
 }
 
 if (objzx_SysCountEN.CommentCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysCount.CommentCount);
 arrValueListForInsert.Add(objzx_SysCountEN.CommentCount.ToString());
 }
 
 if (objzx_SysCountEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysCount.Score);
 arrValueListForInsert.Add(objzx_SysCountEN.Score.ToString());
 }
 
 if (objzx_SysCountEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysCount.StuScore);
 arrValueListForInsert.Add(objzx_SysCountEN.StuScore.ToString());
 }
 
 if (objzx_SysCountEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysCount.TeaScore);
 arrValueListForInsert.Add(objzx_SysCountEN.TeaScore.ToString());
 }
 
 if (objzx_SysCountEN.TableKey !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysCount.TableKey);
 var strTableKey = objzx_SysCountEN.TableKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTableKey + "'");
 }
 
 if (objzx_SysCountEN.ParentId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysCount.ParentId);
 var strParentId = objzx_SysCountEN.ParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParentId + "'");
 }
 
 if (objzx_SysCountEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysCount.UpdUser);
 var strUpdUser = objzx_SysCountEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_SysCountEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysCount.UpdDate);
 var strUpdDate = objzx_SysCountEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_SysCountEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysCount.Memo);
 var strMemo = objzx_SysCountEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_SysCount");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SysCountDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objzx_SysCountEN.zxCountId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objzx_SysCountEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clszx_SysCountEN objzx_SysCountEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objzx_SysCountEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objzx_SysCountEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_SysCountEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_SysCountEN.zxCountId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysCount.zxCountId);
 var strzxCountId = objzx_SysCountEN.zxCountId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxCountId + "'");
 }
 
 if (objzx_SysCountEN.CountTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysCount.CountTypeId);
 var strCountTypeId = objzx_SysCountEN.CountTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCountTypeId + "'");
 }
 
 if (objzx_SysCountEN.PaperRWCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysCount.PaperRWCount);
 arrValueListForInsert.Add(objzx_SysCountEN.PaperRWCount.ToString());
 }
 
 if (objzx_SysCountEN.OkCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysCount.OkCount);
 arrValueListForInsert.Add(objzx_SysCountEN.OkCount.ToString());
 }
 
 if (objzx_SysCountEN.CollectionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysCount.CollectionCount);
 arrValueListForInsert.Add(objzx_SysCountEN.CollectionCount.ToString());
 }
 
 if (objzx_SysCountEN.DownloadCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysCount.DownloadCount);
 arrValueListForInsert.Add(objzx_SysCountEN.DownloadCount.ToString());
 }
 
 if (objzx_SysCountEN.AttachmentCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysCount.AttachmentCount);
 arrValueListForInsert.Add(objzx_SysCountEN.AttachmentCount.ToString());
 }
 
 if (objzx_SysCountEN.CommentCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysCount.CommentCount);
 arrValueListForInsert.Add(objzx_SysCountEN.CommentCount.ToString());
 }
 
 if (objzx_SysCountEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysCount.Score);
 arrValueListForInsert.Add(objzx_SysCountEN.Score.ToString());
 }
 
 if (objzx_SysCountEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysCount.StuScore);
 arrValueListForInsert.Add(objzx_SysCountEN.StuScore.ToString());
 }
 
 if (objzx_SysCountEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysCount.TeaScore);
 arrValueListForInsert.Add(objzx_SysCountEN.TeaScore.ToString());
 }
 
 if (objzx_SysCountEN.TableKey !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysCount.TableKey);
 var strTableKey = objzx_SysCountEN.TableKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTableKey + "'");
 }
 
 if (objzx_SysCountEN.ParentId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysCount.ParentId);
 var strParentId = objzx_SysCountEN.ParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParentId + "'");
 }
 
 if (objzx_SysCountEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysCount.UpdUser);
 var strUpdUser = objzx_SysCountEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_SysCountEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysCount.UpdDate);
 var strUpdDate = objzx_SysCountEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_SysCountEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysCount.Memo);
 var strMemo = objzx_SysCountEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_SysCount");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SysCountDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewzx_SysCounts(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SysCountDA.GetSpecSQLObj();
strSQL = "Select * from zx_SysCount where zxCountId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "zx_SysCount");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strzxCountId = oRow[conzx_SysCount.zxCountId].ToString().Trim();
if (IsExist(strzxCountId))
{
 string strResult = "关键字变量值为:" + string.Format("zxCountId = {0}", strzxCountId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clszx_SysCountEN._CurrTabName ].NewRow();
objRow[conzx_SysCount.zxCountId] = oRow[conzx_SysCount.zxCountId].ToString().Trim(); //CountId
objRow[conzx_SysCount.CountTypeId] = oRow[conzx_SysCount.CountTypeId].ToString().Trim(); //CountTypeId
objRow[conzx_SysCount.PaperRWCount] = oRow[conzx_SysCount.PaperRWCount].ToString().Trim(); //PaperRWCount
objRow[conzx_SysCount.OkCount] = oRow[conzx_SysCount.OkCount].ToString().Trim(); //点赞统计
objRow[conzx_SysCount.CollectionCount] = oRow[conzx_SysCount.CollectionCount].ToString().Trim(); //收藏数量
objRow[conzx_SysCount.DownloadCount] = oRow[conzx_SysCount.DownloadCount].ToString().Trim(); //下载数
objRow[conzx_SysCount.AttachmentCount] = oRow[conzx_SysCount.AttachmentCount].ToString().Trim(); //附件计数
objRow[conzx_SysCount.CommentCount] = oRow[conzx_SysCount.CommentCount].ToString().Trim(); //评论数
objRow[conzx_SysCount.Score] = oRow[conzx_SysCount.Score].ToString().Trim(); //评分
objRow[conzx_SysCount.StuScore] = oRow[conzx_SysCount.StuScore].ToString().Trim(); //学生平均分
objRow[conzx_SysCount.TeaScore] = oRow[conzx_SysCount.TeaScore].ToString().Trim(); //教师评分
objRow[conzx_SysCount.TableKey] = oRow[conzx_SysCount.TableKey].ToString().Trim(); //表主键
objRow[conzx_SysCount.ParentId] = oRow[conzx_SysCount.ParentId].ToString().Trim(); //父Id
objRow[conzx_SysCount.UpdUser] = oRow[conzx_SysCount.UpdUser].ToString().Trim(); //修改人
objRow[conzx_SysCount.UpdDate] = oRow[conzx_SysCount.UpdDate].ToString().Trim(); //修改日期
objRow[conzx_SysCount.Memo] = oRow[conzx_SysCount.Memo].ToString().Trim(); //备注
 objDS.Tables[clszx_SysCountEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clszx_SysCountEN._CurrTabName);
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
 /// <param name = "objzx_SysCountEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clszx_SysCountEN objzx_SysCountEN)
{
 objzx_SysCountEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objzx_SysCountEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_SysCountEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SysCountDA.GetSpecSQLObj();
strSQL = "Select * from zx_SysCount where zxCountId = " + "'"+ objzx_SysCountEN.zxCountId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clszx_SysCountEN._CurrTabName);
if (objDS.Tables[clszx_SysCountEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:zxCountId = " + "'"+ objzx_SysCountEN.zxCountId+"'");
return false;
}
objRow = objDS.Tables[clszx_SysCountEN._CurrTabName].Rows[0];
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.zxCountId))
 {
objRow[conzx_SysCount.zxCountId] = objzx_SysCountEN.zxCountId; //CountId
 }
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.CountTypeId))
 {
objRow[conzx_SysCount.CountTypeId] = objzx_SysCountEN.CountTypeId; //CountTypeId
 }
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.PaperRWCount))
 {
objRow[conzx_SysCount.PaperRWCount] = objzx_SysCountEN.PaperRWCount; //PaperRWCount
 }
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.OkCount))
 {
objRow[conzx_SysCount.OkCount] = objzx_SysCountEN.OkCount; //点赞统计
 }
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.CollectionCount))
 {
objRow[conzx_SysCount.CollectionCount] = objzx_SysCountEN.CollectionCount; //收藏数量
 }
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.DownloadCount))
 {
objRow[conzx_SysCount.DownloadCount] = objzx_SysCountEN.DownloadCount; //下载数
 }
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.AttachmentCount))
 {
objRow[conzx_SysCount.AttachmentCount] = objzx_SysCountEN.AttachmentCount; //附件计数
 }
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.CommentCount))
 {
objRow[conzx_SysCount.CommentCount] = objzx_SysCountEN.CommentCount; //评论数
 }
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.Score))
 {
objRow[conzx_SysCount.Score] = objzx_SysCountEN.Score; //评分
 }
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.StuScore))
 {
objRow[conzx_SysCount.StuScore] = objzx_SysCountEN.StuScore; //学生平均分
 }
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.TeaScore))
 {
objRow[conzx_SysCount.TeaScore] = objzx_SysCountEN.TeaScore; //教师评分
 }
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.TableKey))
 {
objRow[conzx_SysCount.TableKey] = objzx_SysCountEN.TableKey; //表主键
 }
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.ParentId))
 {
objRow[conzx_SysCount.ParentId] = objzx_SysCountEN.ParentId; //父Id
 }
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.UpdUser))
 {
objRow[conzx_SysCount.UpdUser] = objzx_SysCountEN.UpdUser; //修改人
 }
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.UpdDate))
 {
objRow[conzx_SysCount.UpdDate] = objzx_SysCountEN.UpdDate; //修改日期
 }
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.Memo))
 {
objRow[conzx_SysCount.Memo] = objzx_SysCountEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clszx_SysCountEN._CurrTabName);
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
 /// <param name = "objzx_SysCountEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clszx_SysCountEN objzx_SysCountEN)
{
 objzx_SysCountEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objzx_SysCountEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_SysCountEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SysCountDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update zx_SysCount Set ");
 
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.CountTypeId))
 {
 if (objzx_SysCountEN.CountTypeId !=  null)
 {
 var strCountTypeId = objzx_SysCountEN.CountTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCountTypeId, conzx_SysCount.CountTypeId); //CountTypeId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SysCount.CountTypeId); //CountTypeId
 }
 }
 
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.PaperRWCount))
 {
 if (objzx_SysCountEN.PaperRWCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SysCountEN.PaperRWCount, conzx_SysCount.PaperRWCount); //PaperRWCount
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SysCount.PaperRWCount); //PaperRWCount
 }
 }
 
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.OkCount))
 {
 if (objzx_SysCountEN.OkCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SysCountEN.OkCount, conzx_SysCount.OkCount); //点赞统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SysCount.OkCount); //点赞统计
 }
 }
 
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.CollectionCount))
 {
 if (objzx_SysCountEN.CollectionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SysCountEN.CollectionCount, conzx_SysCount.CollectionCount); //收藏数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SysCount.CollectionCount); //收藏数量
 }
 }
 
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.DownloadCount))
 {
 if (objzx_SysCountEN.DownloadCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SysCountEN.DownloadCount, conzx_SysCount.DownloadCount); //下载数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SysCount.DownloadCount); //下载数
 }
 }
 
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.AttachmentCount))
 {
 if (objzx_SysCountEN.AttachmentCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SysCountEN.AttachmentCount, conzx_SysCount.AttachmentCount); //附件计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SysCount.AttachmentCount); //附件计数
 }
 }
 
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.CommentCount))
 {
 if (objzx_SysCountEN.CommentCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SysCountEN.CommentCount, conzx_SysCount.CommentCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SysCount.CommentCount); //评论数
 }
 }
 
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.Score))
 {
 if (objzx_SysCountEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SysCountEN.Score, conzx_SysCount.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SysCount.Score); //评分
 }
 }
 
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.StuScore))
 {
 if (objzx_SysCountEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SysCountEN.StuScore, conzx_SysCount.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SysCount.StuScore); //学生平均分
 }
 }
 
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.TeaScore))
 {
 if (objzx_SysCountEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SysCountEN.TeaScore, conzx_SysCount.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SysCount.TeaScore); //教师评分
 }
 }
 
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.TableKey))
 {
 if (objzx_SysCountEN.TableKey !=  null)
 {
 var strTableKey = objzx_SysCountEN.TableKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTableKey, conzx_SysCount.TableKey); //表主键
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SysCount.TableKey); //表主键
 }
 }
 
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.ParentId))
 {
 if (objzx_SysCountEN.ParentId !=  null)
 {
 var strParentId = objzx_SysCountEN.ParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParentId, conzx_SysCount.ParentId); //父Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SysCount.ParentId); //父Id
 }
 }
 
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.UpdUser))
 {
 if (objzx_SysCountEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_SysCountEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conzx_SysCount.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SysCount.UpdUser); //修改人
 }
 }
 
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.UpdDate))
 {
 if (objzx_SysCountEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_SysCountEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conzx_SysCount.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SysCount.UpdDate); //修改日期
 }
 }
 
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.Memo))
 {
 if (objzx_SysCountEN.Memo !=  null)
 {
 var strMemo = objzx_SysCountEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conzx_SysCount.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SysCount.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where zxCountId = '{0}'", objzx_SysCountEN.zxCountId); 
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
 /// <param name = "objzx_SysCountEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clszx_SysCountEN objzx_SysCountEN, string strCondition)
{
 objzx_SysCountEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objzx_SysCountEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_SysCountEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SysCountDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_SysCount Set ");
 
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.CountTypeId))
 {
 if (objzx_SysCountEN.CountTypeId !=  null)
 {
 var strCountTypeId = objzx_SysCountEN.CountTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CountTypeId = '{0}',", strCountTypeId); //CountTypeId
 }
 else
 {
 sbSQL.Append(" CountTypeId = null,"); //CountTypeId
 }
 }
 
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.PaperRWCount))
 {
 if (objzx_SysCountEN.PaperRWCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SysCountEN.PaperRWCount, conzx_SysCount.PaperRWCount); //PaperRWCount
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SysCount.PaperRWCount); //PaperRWCount
 }
 }
 
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.OkCount))
 {
 if (objzx_SysCountEN.OkCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SysCountEN.OkCount, conzx_SysCount.OkCount); //点赞统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SysCount.OkCount); //点赞统计
 }
 }
 
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.CollectionCount))
 {
 if (objzx_SysCountEN.CollectionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SysCountEN.CollectionCount, conzx_SysCount.CollectionCount); //收藏数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SysCount.CollectionCount); //收藏数量
 }
 }
 
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.DownloadCount))
 {
 if (objzx_SysCountEN.DownloadCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SysCountEN.DownloadCount, conzx_SysCount.DownloadCount); //下载数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SysCount.DownloadCount); //下载数
 }
 }
 
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.AttachmentCount))
 {
 if (objzx_SysCountEN.AttachmentCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SysCountEN.AttachmentCount, conzx_SysCount.AttachmentCount); //附件计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SysCount.AttachmentCount); //附件计数
 }
 }
 
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.CommentCount))
 {
 if (objzx_SysCountEN.CommentCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SysCountEN.CommentCount, conzx_SysCount.CommentCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SysCount.CommentCount); //评论数
 }
 }
 
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.Score))
 {
 if (objzx_SysCountEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SysCountEN.Score, conzx_SysCount.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SysCount.Score); //评分
 }
 }
 
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.StuScore))
 {
 if (objzx_SysCountEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SysCountEN.StuScore, conzx_SysCount.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SysCount.StuScore); //学生平均分
 }
 }
 
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.TeaScore))
 {
 if (objzx_SysCountEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SysCountEN.TeaScore, conzx_SysCount.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SysCount.TeaScore); //教师评分
 }
 }
 
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.TableKey))
 {
 if (objzx_SysCountEN.TableKey !=  null)
 {
 var strTableKey = objzx_SysCountEN.TableKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TableKey = '{0}',", strTableKey); //表主键
 }
 else
 {
 sbSQL.Append(" TableKey = null,"); //表主键
 }
 }
 
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.ParentId))
 {
 if (objzx_SysCountEN.ParentId !=  null)
 {
 var strParentId = objzx_SysCountEN.ParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParentId = '{0}',", strParentId); //父Id
 }
 else
 {
 sbSQL.Append(" ParentId = null,"); //父Id
 }
 }
 
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.UpdUser))
 {
 if (objzx_SysCountEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_SysCountEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.UpdDate))
 {
 if (objzx_SysCountEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_SysCountEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.Memo))
 {
 if (objzx_SysCountEN.Memo !=  null)
 {
 var strMemo = objzx_SysCountEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objzx_SysCountEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clszx_SysCountEN objzx_SysCountEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objzx_SysCountEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objzx_SysCountEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_SysCountEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SysCountDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_SysCount Set ");
 
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.CountTypeId))
 {
 if (objzx_SysCountEN.CountTypeId !=  null)
 {
 var strCountTypeId = objzx_SysCountEN.CountTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CountTypeId = '{0}',", strCountTypeId); //CountTypeId
 }
 else
 {
 sbSQL.Append(" CountTypeId = null,"); //CountTypeId
 }
 }
 
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.PaperRWCount))
 {
 if (objzx_SysCountEN.PaperRWCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SysCountEN.PaperRWCount, conzx_SysCount.PaperRWCount); //PaperRWCount
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SysCount.PaperRWCount); //PaperRWCount
 }
 }
 
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.OkCount))
 {
 if (objzx_SysCountEN.OkCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SysCountEN.OkCount, conzx_SysCount.OkCount); //点赞统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SysCount.OkCount); //点赞统计
 }
 }
 
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.CollectionCount))
 {
 if (objzx_SysCountEN.CollectionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SysCountEN.CollectionCount, conzx_SysCount.CollectionCount); //收藏数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SysCount.CollectionCount); //收藏数量
 }
 }
 
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.DownloadCount))
 {
 if (objzx_SysCountEN.DownloadCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SysCountEN.DownloadCount, conzx_SysCount.DownloadCount); //下载数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SysCount.DownloadCount); //下载数
 }
 }
 
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.AttachmentCount))
 {
 if (objzx_SysCountEN.AttachmentCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SysCountEN.AttachmentCount, conzx_SysCount.AttachmentCount); //附件计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SysCount.AttachmentCount); //附件计数
 }
 }
 
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.CommentCount))
 {
 if (objzx_SysCountEN.CommentCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SysCountEN.CommentCount, conzx_SysCount.CommentCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SysCount.CommentCount); //评论数
 }
 }
 
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.Score))
 {
 if (objzx_SysCountEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SysCountEN.Score, conzx_SysCount.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SysCount.Score); //评分
 }
 }
 
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.StuScore))
 {
 if (objzx_SysCountEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SysCountEN.StuScore, conzx_SysCount.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SysCount.StuScore); //学生平均分
 }
 }
 
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.TeaScore))
 {
 if (objzx_SysCountEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SysCountEN.TeaScore, conzx_SysCount.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SysCount.TeaScore); //教师评分
 }
 }
 
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.TableKey))
 {
 if (objzx_SysCountEN.TableKey !=  null)
 {
 var strTableKey = objzx_SysCountEN.TableKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TableKey = '{0}',", strTableKey); //表主键
 }
 else
 {
 sbSQL.Append(" TableKey = null,"); //表主键
 }
 }
 
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.ParentId))
 {
 if (objzx_SysCountEN.ParentId !=  null)
 {
 var strParentId = objzx_SysCountEN.ParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParentId = '{0}',", strParentId); //父Id
 }
 else
 {
 sbSQL.Append(" ParentId = null,"); //父Id
 }
 }
 
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.UpdUser))
 {
 if (objzx_SysCountEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_SysCountEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.UpdDate))
 {
 if (objzx_SysCountEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_SysCountEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.Memo))
 {
 if (objzx_SysCountEN.Memo !=  null)
 {
 var strMemo = objzx_SysCountEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objzx_SysCountEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clszx_SysCountEN objzx_SysCountEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objzx_SysCountEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objzx_SysCountEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_SysCountEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SysCountDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_SysCount Set ");
 
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.CountTypeId))
 {
 if (objzx_SysCountEN.CountTypeId !=  null)
 {
 var strCountTypeId = objzx_SysCountEN.CountTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCountTypeId, conzx_SysCount.CountTypeId); //CountTypeId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SysCount.CountTypeId); //CountTypeId
 }
 }
 
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.PaperRWCount))
 {
 if (objzx_SysCountEN.PaperRWCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SysCountEN.PaperRWCount, conzx_SysCount.PaperRWCount); //PaperRWCount
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SysCount.PaperRWCount); //PaperRWCount
 }
 }
 
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.OkCount))
 {
 if (objzx_SysCountEN.OkCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SysCountEN.OkCount, conzx_SysCount.OkCount); //点赞统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SysCount.OkCount); //点赞统计
 }
 }
 
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.CollectionCount))
 {
 if (objzx_SysCountEN.CollectionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SysCountEN.CollectionCount, conzx_SysCount.CollectionCount); //收藏数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SysCount.CollectionCount); //收藏数量
 }
 }
 
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.DownloadCount))
 {
 if (objzx_SysCountEN.DownloadCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SysCountEN.DownloadCount, conzx_SysCount.DownloadCount); //下载数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SysCount.DownloadCount); //下载数
 }
 }
 
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.AttachmentCount))
 {
 if (objzx_SysCountEN.AttachmentCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SysCountEN.AttachmentCount, conzx_SysCount.AttachmentCount); //附件计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SysCount.AttachmentCount); //附件计数
 }
 }
 
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.CommentCount))
 {
 if (objzx_SysCountEN.CommentCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SysCountEN.CommentCount, conzx_SysCount.CommentCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SysCount.CommentCount); //评论数
 }
 }
 
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.Score))
 {
 if (objzx_SysCountEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SysCountEN.Score, conzx_SysCount.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SysCount.Score); //评分
 }
 }
 
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.StuScore))
 {
 if (objzx_SysCountEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SysCountEN.StuScore, conzx_SysCount.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SysCount.StuScore); //学生平均分
 }
 }
 
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.TeaScore))
 {
 if (objzx_SysCountEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SysCountEN.TeaScore, conzx_SysCount.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SysCount.TeaScore); //教师评分
 }
 }
 
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.TableKey))
 {
 if (objzx_SysCountEN.TableKey !=  null)
 {
 var strTableKey = objzx_SysCountEN.TableKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTableKey, conzx_SysCount.TableKey); //表主键
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SysCount.TableKey); //表主键
 }
 }
 
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.ParentId))
 {
 if (objzx_SysCountEN.ParentId !=  null)
 {
 var strParentId = objzx_SysCountEN.ParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParentId, conzx_SysCount.ParentId); //父Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SysCount.ParentId); //父Id
 }
 }
 
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.UpdUser))
 {
 if (objzx_SysCountEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_SysCountEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conzx_SysCount.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SysCount.UpdUser); //修改人
 }
 }
 
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.UpdDate))
 {
 if (objzx_SysCountEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_SysCountEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conzx_SysCount.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SysCount.UpdDate); //修改日期
 }
 }
 
 if (objzx_SysCountEN.IsUpdated(conzx_SysCount.Memo))
 {
 if (objzx_SysCountEN.Memo !=  null)
 {
 var strMemo = objzx_SysCountEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conzx_SysCount.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SysCount.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where zxCountId = '{0}'", objzx_SysCountEN.zxCountId); 
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
 /// <param name = "strzxCountId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strzxCountId) 
{
CheckPrimaryKey(strzxCountId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SysCountDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strzxCountId,
};
 objSQL.ExecSP("zx_SysCount_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strzxCountId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strzxCountId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strzxCountId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SysCountDA.GetSpecSQLObj();
//删除zx_SysCount本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_SysCount where zxCountId = " + "'"+ strzxCountId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delzx_SysCount(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SysCountDA.GetSpecSQLObj();
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
//删除zx_SysCount本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_SysCount where zxCountId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strzxCountId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strzxCountId) 
{
CheckPrimaryKey(strzxCountId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SysCountDA.GetSpecSQLObj();
//删除zx_SysCount本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_SysCount where zxCountId = " + "'"+ strzxCountId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delzx_SysCount(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clszx_SysCountDA: Delzx_SysCount)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SysCountDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from zx_SysCount where " + strCondition ;
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
public bool Delzx_SysCountWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clszx_SysCountDA: Delzx_SysCountWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SysCountDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from zx_SysCount where " + strCondition ;
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
 /// <param name = "objzx_SysCountENS">源对象</param>
 /// <param name = "objzx_SysCountENT">目标对象</param>
public void CopyTo(clszx_SysCountEN objzx_SysCountENS, clszx_SysCountEN objzx_SysCountENT)
{
objzx_SysCountENT.zxCountId = objzx_SysCountENS.zxCountId; //CountId
objzx_SysCountENT.CountTypeId = objzx_SysCountENS.CountTypeId; //CountTypeId
objzx_SysCountENT.PaperRWCount = objzx_SysCountENS.PaperRWCount; //PaperRWCount
objzx_SysCountENT.OkCount = objzx_SysCountENS.OkCount; //点赞统计
objzx_SysCountENT.CollectionCount = objzx_SysCountENS.CollectionCount; //收藏数量
objzx_SysCountENT.DownloadCount = objzx_SysCountENS.DownloadCount; //下载数
objzx_SysCountENT.AttachmentCount = objzx_SysCountENS.AttachmentCount; //附件计数
objzx_SysCountENT.CommentCount = objzx_SysCountENS.CommentCount; //评论数
objzx_SysCountENT.Score = objzx_SysCountENS.Score; //评分
objzx_SysCountENT.StuScore = objzx_SysCountENS.StuScore; //学生平均分
objzx_SysCountENT.TeaScore = objzx_SysCountENS.TeaScore; //教师评分
objzx_SysCountENT.TableKey = objzx_SysCountENS.TableKey; //表主键
objzx_SysCountENT.ParentId = objzx_SysCountENS.ParentId; //父Id
objzx_SysCountENT.UpdUser = objzx_SysCountENS.UpdUser; //修改人
objzx_SysCountENT.UpdDate = objzx_SysCountENS.UpdDate; //修改日期
objzx_SysCountENT.Memo = objzx_SysCountENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clszx_SysCountEN objzx_SysCountEN)
{
//检查字段不能为空(NULL)
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_SysCountEN.zxCountId, 10, conzx_SysCount.zxCountId);
clsCheckSql.CheckFieldLen(objzx_SysCountEN.CountTypeId, 2, conzx_SysCount.CountTypeId);
clsCheckSql.CheckFieldLen(objzx_SysCountEN.TableKey, 20, conzx_SysCount.TableKey);
clsCheckSql.CheckFieldLen(objzx_SysCountEN.ParentId, 20, conzx_SysCount.ParentId);
clsCheckSql.CheckFieldLen(objzx_SysCountEN.UpdUser, 20, conzx_SysCount.UpdUser);
clsCheckSql.CheckFieldLen(objzx_SysCountEN.UpdDate, 20, conzx_SysCount.UpdDate);
clsCheckSql.CheckFieldLen(objzx_SysCountEN.Memo, 1000, conzx_SysCount.Memo);
//检查字段外键固定长度
 objzx_SysCountEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clszx_SysCountEN objzx_SysCountEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_SysCountEN.CountTypeId, 2, conzx_SysCount.CountTypeId);
clsCheckSql.CheckFieldLen(objzx_SysCountEN.TableKey, 20, conzx_SysCount.TableKey);
clsCheckSql.CheckFieldLen(objzx_SysCountEN.ParentId, 20, conzx_SysCount.ParentId);
clsCheckSql.CheckFieldLen(objzx_SysCountEN.UpdUser, 20, conzx_SysCount.UpdUser);
clsCheckSql.CheckFieldLen(objzx_SysCountEN.UpdDate, 20, conzx_SysCount.UpdDate);
clsCheckSql.CheckFieldLen(objzx_SysCountEN.Memo, 1000, conzx_SysCount.Memo);
//检查外键字段长度
 objzx_SysCountEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clszx_SysCountEN objzx_SysCountEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_SysCountEN.zxCountId, 10, conzx_SysCount.zxCountId);
clsCheckSql.CheckFieldLen(objzx_SysCountEN.CountTypeId, 2, conzx_SysCount.CountTypeId);
clsCheckSql.CheckFieldLen(objzx_SysCountEN.TableKey, 20, conzx_SysCount.TableKey);
clsCheckSql.CheckFieldLen(objzx_SysCountEN.ParentId, 20, conzx_SysCount.ParentId);
clsCheckSql.CheckFieldLen(objzx_SysCountEN.UpdUser, 20, conzx_SysCount.UpdUser);
clsCheckSql.CheckFieldLen(objzx_SysCountEN.UpdDate, 20, conzx_SysCount.UpdDate);
clsCheckSql.CheckFieldLen(objzx_SysCountEN.Memo, 1000, conzx_SysCount.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objzx_SysCountEN.zxCountId, conzx_SysCount.zxCountId);
clsCheckSql.CheckSqlInjection4Field(objzx_SysCountEN.CountTypeId, conzx_SysCount.CountTypeId);
clsCheckSql.CheckSqlInjection4Field(objzx_SysCountEN.TableKey, conzx_SysCount.TableKey);
clsCheckSql.CheckSqlInjection4Field(objzx_SysCountEN.ParentId, conzx_SysCount.ParentId);
clsCheckSql.CheckSqlInjection4Field(objzx_SysCountEN.UpdUser, conzx_SysCount.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objzx_SysCountEN.UpdDate, conzx_SysCount.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objzx_SysCountEN.Memo, conzx_SysCount.Memo);
//检查外键字段长度
 objzx_SysCountEN._IsCheckProperty = true;
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
 objSQL = clszx_SysCountDA.GetSpecSQLObj();
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
 objSQL = clszx_SysCountDA.GetSpecSQLObj();
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
 objSQL = clszx_SysCountDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clszx_SysCountEN._CurrTabName);
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
 objSQL = clszx_SysCountDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clszx_SysCountEN._CurrTabName, strCondition);
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
 objSQL = clszx_SysCountDA.GetSpecSQLObj();
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
 objSQL = clszx_SysCountDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}