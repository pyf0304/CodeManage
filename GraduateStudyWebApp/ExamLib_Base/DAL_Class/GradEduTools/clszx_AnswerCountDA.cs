
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_AnswerCountDA
 表名:zx_AnswerCount(01120785)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:55:46
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
 /// z中学问题讨论回答统计(zx_AnswerCount)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clszx_AnswerCountDA : clsCommBase4DA
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
 return clszx_AnswerCountEN._CurrTabName;
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
if (string.IsNullOrEmpty(clszx_AnswerCountEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clszx_AnswerCountEN._ConnectString);
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
 if (string.IsNullOrEmpty(clszx_AnswerCountEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clszx_AnswerCountEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strAnswerCountId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strAnswerCountId)
{
strAnswerCountId = strAnswerCountId.Replace("'", "''");
if (strAnswerCountId.Length > 10)
{
throw new Exception("(errid:Data000001)在表:zx_AnswerCount中,检查关键字,长度不正确!(clszx_AnswerCountDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strAnswerCountId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:zx_AnswerCount中,关键字不能为空 或 null!(clszx_AnswerCountDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strAnswerCountId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clszx_AnswerCountDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clszx_AnswerCountDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_AnswerCountDA.GetSpecSQLObj();
strSQL = "Select * from zx_AnswerCount where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_zx_AnswerCount(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clszx_AnswerCountDA: GetDataTable_zx_AnswerCount)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_AnswerCountDA.GetSpecSQLObj();
strSQL = "Select * from zx_AnswerCount where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clszx_AnswerCountDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_AnswerCountDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clszx_AnswerCountDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_AnswerCountDA.GetSpecSQLObj();
strSQL = "Select * from zx_AnswerCount where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clszx_AnswerCountDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_AnswerCountDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clszx_AnswerCountDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_AnswerCountDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_AnswerCount where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_AnswerCount where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clszx_AnswerCountDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_AnswerCountDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from zx_AnswerCount where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clszx_AnswerCountDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_AnswerCountDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} zx_AnswerCount.* from zx_AnswerCount Left Join {1} on {2} where {3} and zx_AnswerCount.AnswerCountId not in (Select top {5} zx_AnswerCount.AnswerCountId from zx_AnswerCount Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_AnswerCount where {1} and AnswerCountId not in (Select top {2} AnswerCountId from zx_AnswerCount where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_AnswerCount where {1} and AnswerCountId not in (Select top {3} AnswerCountId from zx_AnswerCount where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clszx_AnswerCountDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_AnswerCountDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} zx_AnswerCount.* from zx_AnswerCount Left Join {1} on {2} where {3} and zx_AnswerCount.AnswerCountId not in (Select top {5} zx_AnswerCount.AnswerCountId from zx_AnswerCount Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_AnswerCount where {1} and AnswerCountId not in (Select top {2} AnswerCountId from zx_AnswerCount where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_AnswerCount where {1} and AnswerCountId not in (Select top {3} AnswerCountId from zx_AnswerCount where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clszx_AnswerCountEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clszx_AnswerCountDA:GetObjLst)", objException.Message));
}
List<clszx_AnswerCountEN> arrObjLst = new List<clszx_AnswerCountEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_AnswerCountDA.GetSpecSQLObj();
strSQL = "Select * from zx_AnswerCount where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_AnswerCountEN objzx_AnswerCountEN = new clszx_AnswerCountEN();
try
{
objzx_AnswerCountEN.Memo = objRow[conzx_AnswerCount.Memo] == DBNull.Value ? null : objRow[conzx_AnswerCount.Memo].ToString().Trim(); //备注
objzx_AnswerCountEN.AnswerCountId = objRow[conzx_AnswerCount.AnswerCountId].ToString().Trim(); //AnswerCountId
objzx_AnswerCountEN.DataUser = objRow[conzx_AnswerCount.DataUser] == DBNull.Value ? null : objRow[conzx_AnswerCount.DataUser].ToString().Trim(); //数据用户
objzx_AnswerCountEN.DataAddDate = objRow[conzx_AnswerCount.DataAddDate] == DBNull.Value ? null : objRow[conzx_AnswerCount.DataAddDate].ToString().Trim(); //数据添加日期
objzx_AnswerCountEN.Month = objRow[conzx_AnswerCount.Month] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_AnswerCount.Month].ToString().Trim()); //月
objzx_AnswerCountEN.Week = objRow[conzx_AnswerCount.Week] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_AnswerCount.Week].ToString().Trim()); //周
objzx_AnswerCountEN.WeekTimeRange = objRow[conzx_AnswerCount.WeekTimeRange] == DBNull.Value ? null : objRow[conzx_AnswerCount.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objzx_AnswerCountEN.IsRecommend = TransNullToBool(objRow[conzx_AnswerCount.IsRecommend].ToString().Trim()); //是否推荐
objzx_AnswerCountEN.zxAnswerId = objRow[conzx_AnswerCount.zxAnswerId] == DBNull.Value ? null : objRow[conzx_AnswerCount.zxAnswerId].ToString().Trim(); //回答Id
objzx_AnswerCountEN.AnswerTypeId = objRow[conzx_AnswerCount.AnswerTypeId] == DBNull.Value ? null : objRow[conzx_AnswerCount.AnswerTypeId].ToString().Trim(); //答案类型ID
objzx_AnswerCountEN.zxQuestionsId = objRow[conzx_AnswerCount.zxQuestionsId] == DBNull.Value ? null : objRow[conzx_AnswerCount.zxQuestionsId].ToString().Trim(); //提问Id
objzx_AnswerCountEN.GroupTextId = objRow[conzx_AnswerCount.GroupTextId] == DBNull.Value ? null : objRow[conzx_AnswerCount.GroupTextId].ToString().Trim(); //小组Id
objzx_AnswerCountEN.TextId = objRow[conzx_AnswerCount.TextId] == DBNull.Value ? null : objRow[conzx_AnswerCount.TextId].ToString().Trim(); //课件Id
objzx_AnswerCountEN.IdCurrEduCls = objRow[conzx_AnswerCount.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_AnswerCount.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_AnswerCountEN.AnswerContent = objRow[conzx_AnswerCount.AnswerContent] == DBNull.Value ? null : objRow[conzx_AnswerCount.AnswerContent].ToString().Trim(); //答案内容
objzx_AnswerCountEN.Score = objRow[conzx_AnswerCount.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_AnswerCount.Score].ToString().Trim()); //评分
objzx_AnswerCountEN.ScoreType = objRow[conzx_AnswerCount.ScoreType] == DBNull.Value ? null : objRow[conzx_AnswerCount.ScoreType].ToString().Trim(); //评分类型
objzx_AnswerCountEN.UpdUser = objRow[conzx_AnswerCount.UpdUser] == DBNull.Value ? null : objRow[conzx_AnswerCount.UpdUser].ToString().Trim(); //修改人
objzx_AnswerCountEN.UpdDate = objRow[conzx_AnswerCount.UpdDate] == DBNull.Value ? null : objRow[conzx_AnswerCount.UpdDate].ToString().Trim(); //修改日期
objzx_AnswerCountEN.UserName = objRow[conzx_AnswerCount.UserName] == DBNull.Value ? null : objRow[conzx_AnswerCount.UserName].ToString().Trim(); //用户名
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clszx_AnswerCountDA: GetObjLst)", objException.Message));
}
objzx_AnswerCountEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objzx_AnswerCountEN);
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
public List<clszx_AnswerCountEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clszx_AnswerCountDA:GetObjLstByTabName)", objException.Message));
}
List<clszx_AnswerCountEN> arrObjLst = new List<clszx_AnswerCountEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_AnswerCountDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_AnswerCountEN objzx_AnswerCountEN = new clszx_AnswerCountEN();
try
{
objzx_AnswerCountEN.Memo = objRow[conzx_AnswerCount.Memo] == DBNull.Value ? null : objRow[conzx_AnswerCount.Memo].ToString().Trim(); //备注
objzx_AnswerCountEN.AnswerCountId = objRow[conzx_AnswerCount.AnswerCountId].ToString().Trim(); //AnswerCountId
objzx_AnswerCountEN.DataUser = objRow[conzx_AnswerCount.DataUser] == DBNull.Value ? null : objRow[conzx_AnswerCount.DataUser].ToString().Trim(); //数据用户
objzx_AnswerCountEN.DataAddDate = objRow[conzx_AnswerCount.DataAddDate] == DBNull.Value ? null : objRow[conzx_AnswerCount.DataAddDate].ToString().Trim(); //数据添加日期
objzx_AnswerCountEN.Month = objRow[conzx_AnswerCount.Month] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_AnswerCount.Month].ToString().Trim()); //月
objzx_AnswerCountEN.Week = objRow[conzx_AnswerCount.Week] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_AnswerCount.Week].ToString().Trim()); //周
objzx_AnswerCountEN.WeekTimeRange = objRow[conzx_AnswerCount.WeekTimeRange] == DBNull.Value ? null : objRow[conzx_AnswerCount.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objzx_AnswerCountEN.IsRecommend = TransNullToBool(objRow[conzx_AnswerCount.IsRecommend].ToString().Trim()); //是否推荐
objzx_AnswerCountEN.zxAnswerId = objRow[conzx_AnswerCount.zxAnswerId] == DBNull.Value ? null : objRow[conzx_AnswerCount.zxAnswerId].ToString().Trim(); //回答Id
objzx_AnswerCountEN.AnswerTypeId = objRow[conzx_AnswerCount.AnswerTypeId] == DBNull.Value ? null : objRow[conzx_AnswerCount.AnswerTypeId].ToString().Trim(); //答案类型ID
objzx_AnswerCountEN.zxQuestionsId = objRow[conzx_AnswerCount.zxQuestionsId] == DBNull.Value ? null : objRow[conzx_AnswerCount.zxQuestionsId].ToString().Trim(); //提问Id
objzx_AnswerCountEN.GroupTextId = objRow[conzx_AnswerCount.GroupTextId] == DBNull.Value ? null : objRow[conzx_AnswerCount.GroupTextId].ToString().Trim(); //小组Id
objzx_AnswerCountEN.TextId = objRow[conzx_AnswerCount.TextId] == DBNull.Value ? null : objRow[conzx_AnswerCount.TextId].ToString().Trim(); //课件Id
objzx_AnswerCountEN.IdCurrEduCls = objRow[conzx_AnswerCount.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_AnswerCount.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_AnswerCountEN.AnswerContent = objRow[conzx_AnswerCount.AnswerContent] == DBNull.Value ? null : objRow[conzx_AnswerCount.AnswerContent].ToString().Trim(); //答案内容
objzx_AnswerCountEN.Score = objRow[conzx_AnswerCount.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_AnswerCount.Score].ToString().Trim()); //评分
objzx_AnswerCountEN.ScoreType = objRow[conzx_AnswerCount.ScoreType] == DBNull.Value ? null : objRow[conzx_AnswerCount.ScoreType].ToString().Trim(); //评分类型
objzx_AnswerCountEN.UpdUser = objRow[conzx_AnswerCount.UpdUser] == DBNull.Value ? null : objRow[conzx_AnswerCount.UpdUser].ToString().Trim(); //修改人
objzx_AnswerCountEN.UpdDate = objRow[conzx_AnswerCount.UpdDate] == DBNull.Value ? null : objRow[conzx_AnswerCount.UpdDate].ToString().Trim(); //修改日期
objzx_AnswerCountEN.UserName = objRow[conzx_AnswerCount.UserName] == DBNull.Value ? null : objRow[conzx_AnswerCount.UserName].ToString().Trim(); //用户名
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clszx_AnswerCountDA: GetObjLst)", objException.Message));
}
objzx_AnswerCountEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objzx_AnswerCountEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objzx_AnswerCountEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getzx_AnswerCount(ref clszx_AnswerCountEN objzx_AnswerCountEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_AnswerCountDA.GetSpecSQLObj();
strSQL = "Select * from zx_AnswerCount where AnswerCountId = " + "'"+ objzx_AnswerCountEN.AnswerCountId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objzx_AnswerCountEN.Memo = objDT.Rows[0][conzx_AnswerCount.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_AnswerCountEN.AnswerCountId = objDT.Rows[0][conzx_AnswerCount.AnswerCountId].ToString().Trim(); //AnswerCountId(字段类型:char,字段长度:10,是否可空:False)
 objzx_AnswerCountEN.DataUser = objDT.Rows[0][conzx_AnswerCount.DataUser].ToString().Trim(); //数据用户(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_AnswerCountEN.DataAddDate = objDT.Rows[0][conzx_AnswerCount.DataAddDate].ToString().Trim(); //数据添加日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_AnswerCountEN.Month = TransNullToInt(objDT.Rows[0][conzx_AnswerCount.Month].ToString().Trim()); //月(字段类型:int,字段长度:4,是否可空:True)
 objzx_AnswerCountEN.Week = TransNullToInt(objDT.Rows[0][conzx_AnswerCount.Week].ToString().Trim()); //周(字段类型:int,字段长度:4,是否可空:True)
 objzx_AnswerCountEN.WeekTimeRange = objDT.Rows[0][conzx_AnswerCount.WeekTimeRange].ToString().Trim(); //WeekTimeRange(字段类型:varchar,字段长度:100,是否可空:True)
 objzx_AnswerCountEN.IsRecommend = TransNullToBool(objDT.Rows[0][conzx_AnswerCount.IsRecommend].ToString().Trim()); //是否推荐(字段类型:bit,字段长度:1,是否可空:True)
 objzx_AnswerCountEN.zxAnswerId = objDT.Rows[0][conzx_AnswerCount.zxAnswerId].ToString().Trim(); //回答Id(字段类型:char,字段长度:10,是否可空:False)
 objzx_AnswerCountEN.AnswerTypeId = objDT.Rows[0][conzx_AnswerCount.AnswerTypeId].ToString().Trim(); //答案类型ID(字段类型:char,字段长度:2,是否可空:True)
 objzx_AnswerCountEN.zxQuestionsId = objDT.Rows[0][conzx_AnswerCount.zxQuestionsId].ToString().Trim(); //提问Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_AnswerCountEN.GroupTextId = objDT.Rows[0][conzx_AnswerCount.GroupTextId].ToString().Trim(); //小组Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_AnswerCountEN.TextId = objDT.Rows[0][conzx_AnswerCount.TextId].ToString().Trim(); //课件Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_AnswerCountEN.IdCurrEduCls = objDT.Rows[0][conzx_AnswerCount.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objzx_AnswerCountEN.AnswerContent = objDT.Rows[0][conzx_AnswerCount.AnswerContent].ToString().Trim(); //答案内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objzx_AnswerCountEN.Score = TransNullToFloat(objDT.Rows[0][conzx_AnswerCount.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objzx_AnswerCountEN.ScoreType = objDT.Rows[0][conzx_AnswerCount.ScoreType].ToString().Trim(); //评分类型(字段类型:char,字段长度:1,是否可空:True)
 objzx_AnswerCountEN.UpdUser = objDT.Rows[0][conzx_AnswerCount.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_AnswerCountEN.UpdDate = objDT.Rows[0][conzx_AnswerCount.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_AnswerCountEN.UserName = objDT.Rows[0][conzx_AnswerCount.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clszx_AnswerCountDA: Getzx_AnswerCount)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strAnswerCountId">表关键字</param>
 /// <returns>表对象</returns>
public clszx_AnswerCountEN GetObjByAnswerCountId(string strAnswerCountId)
{
CheckPrimaryKey(strAnswerCountId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_AnswerCountDA.GetSpecSQLObj();
strSQL = "Select * from zx_AnswerCount where AnswerCountId = " + "'"+ strAnswerCountId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clszx_AnswerCountEN objzx_AnswerCountEN = new clszx_AnswerCountEN();
try
{
 objzx_AnswerCountEN.Memo = objRow[conzx_AnswerCount.Memo] == DBNull.Value ? null : objRow[conzx_AnswerCount.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_AnswerCountEN.AnswerCountId = objRow[conzx_AnswerCount.AnswerCountId].ToString().Trim(); //AnswerCountId(字段类型:char,字段长度:10,是否可空:False)
 objzx_AnswerCountEN.DataUser = objRow[conzx_AnswerCount.DataUser] == DBNull.Value ? null : objRow[conzx_AnswerCount.DataUser].ToString().Trim(); //数据用户(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_AnswerCountEN.DataAddDate = objRow[conzx_AnswerCount.DataAddDate] == DBNull.Value ? null : objRow[conzx_AnswerCount.DataAddDate].ToString().Trim(); //数据添加日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_AnswerCountEN.Month = objRow[conzx_AnswerCount.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_AnswerCount.Month].ToString().Trim()); //月(字段类型:int,字段长度:4,是否可空:True)
 objzx_AnswerCountEN.Week = objRow[conzx_AnswerCount.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_AnswerCount.Week].ToString().Trim()); //周(字段类型:int,字段长度:4,是否可空:True)
 objzx_AnswerCountEN.WeekTimeRange = objRow[conzx_AnswerCount.WeekTimeRange] == DBNull.Value ? null : objRow[conzx_AnswerCount.WeekTimeRange].ToString().Trim(); //WeekTimeRange(字段类型:varchar,字段长度:100,是否可空:True)
 objzx_AnswerCountEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conzx_AnswerCount.IsRecommend].ToString().Trim()); //是否推荐(字段类型:bit,字段长度:1,是否可空:True)
 objzx_AnswerCountEN.zxAnswerId = objRow[conzx_AnswerCount.zxAnswerId] == DBNull.Value ? null : objRow[conzx_AnswerCount.zxAnswerId].ToString().Trim(); //回答Id(字段类型:char,字段长度:10,是否可空:False)
 objzx_AnswerCountEN.AnswerTypeId = objRow[conzx_AnswerCount.AnswerTypeId] == DBNull.Value ? null : objRow[conzx_AnswerCount.AnswerTypeId].ToString().Trim(); //答案类型ID(字段类型:char,字段长度:2,是否可空:True)
 objzx_AnswerCountEN.zxQuestionsId = objRow[conzx_AnswerCount.zxQuestionsId] == DBNull.Value ? null : objRow[conzx_AnswerCount.zxQuestionsId].ToString().Trim(); //提问Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_AnswerCountEN.GroupTextId = objRow[conzx_AnswerCount.GroupTextId] == DBNull.Value ? null : objRow[conzx_AnswerCount.GroupTextId].ToString().Trim(); //小组Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_AnswerCountEN.TextId = objRow[conzx_AnswerCount.TextId] == DBNull.Value ? null : objRow[conzx_AnswerCount.TextId].ToString().Trim(); //课件Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_AnswerCountEN.IdCurrEduCls = objRow[conzx_AnswerCount.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_AnswerCount.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objzx_AnswerCountEN.AnswerContent = objRow[conzx_AnswerCount.AnswerContent] == DBNull.Value ? null : objRow[conzx_AnswerCount.AnswerContent].ToString().Trim(); //答案内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objzx_AnswerCountEN.Score = objRow[conzx_AnswerCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_AnswerCount.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objzx_AnswerCountEN.ScoreType = objRow[conzx_AnswerCount.ScoreType] == DBNull.Value ? null : objRow[conzx_AnswerCount.ScoreType].ToString().Trim(); //评分类型(字段类型:char,字段长度:1,是否可空:True)
 objzx_AnswerCountEN.UpdUser = objRow[conzx_AnswerCount.UpdUser] == DBNull.Value ? null : objRow[conzx_AnswerCount.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_AnswerCountEN.UpdDate = objRow[conzx_AnswerCount.UpdDate] == DBNull.Value ? null : objRow[conzx_AnswerCount.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_AnswerCountEN.UserName = objRow[conzx_AnswerCount.UserName] == DBNull.Value ? null : objRow[conzx_AnswerCount.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clszx_AnswerCountDA: GetObjByAnswerCountId)", objException.Message));
}
return objzx_AnswerCountEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clszx_AnswerCountEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clszx_AnswerCountDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_AnswerCountDA.GetSpecSQLObj();
strSQL = "Select * from zx_AnswerCount where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clszx_AnswerCountEN objzx_AnswerCountEN = new clszx_AnswerCountEN()
{
Memo = objRow[conzx_AnswerCount.Memo] == DBNull.Value ? null : objRow[conzx_AnswerCount.Memo].ToString().Trim(), //备注
AnswerCountId = objRow[conzx_AnswerCount.AnswerCountId].ToString().Trim(), //AnswerCountId
DataUser = objRow[conzx_AnswerCount.DataUser] == DBNull.Value ? null : objRow[conzx_AnswerCount.DataUser].ToString().Trim(), //数据用户
DataAddDate = objRow[conzx_AnswerCount.DataAddDate] == DBNull.Value ? null : objRow[conzx_AnswerCount.DataAddDate].ToString().Trim(), //数据添加日期
Month = objRow[conzx_AnswerCount.Month] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_AnswerCount.Month].ToString().Trim()), //月
Week = objRow[conzx_AnswerCount.Week] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_AnswerCount.Week].ToString().Trim()), //周
WeekTimeRange = objRow[conzx_AnswerCount.WeekTimeRange] == DBNull.Value ? null : objRow[conzx_AnswerCount.WeekTimeRange].ToString().Trim(), //WeekTimeRange
IsRecommend = TransNullToBool(objRow[conzx_AnswerCount.IsRecommend].ToString().Trim()), //是否推荐
zxAnswerId = objRow[conzx_AnswerCount.zxAnswerId] == DBNull.Value ? null : objRow[conzx_AnswerCount.zxAnswerId].ToString().Trim(), //回答Id
AnswerTypeId = objRow[conzx_AnswerCount.AnswerTypeId] == DBNull.Value ? null : objRow[conzx_AnswerCount.AnswerTypeId].ToString().Trim(), //答案类型ID
zxQuestionsId = objRow[conzx_AnswerCount.zxQuestionsId] == DBNull.Value ? null : objRow[conzx_AnswerCount.zxQuestionsId].ToString().Trim(), //提问Id
GroupTextId = objRow[conzx_AnswerCount.GroupTextId] == DBNull.Value ? null : objRow[conzx_AnswerCount.GroupTextId].ToString().Trim(), //小组Id
TextId = objRow[conzx_AnswerCount.TextId] == DBNull.Value ? null : objRow[conzx_AnswerCount.TextId].ToString().Trim(), //课件Id
IdCurrEduCls = objRow[conzx_AnswerCount.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_AnswerCount.IdCurrEduCls].ToString().Trim(), //教学班流水号
AnswerContent = objRow[conzx_AnswerCount.AnswerContent] == DBNull.Value ? null : objRow[conzx_AnswerCount.AnswerContent].ToString().Trim(), //答案内容
Score = objRow[conzx_AnswerCount.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_AnswerCount.Score].ToString().Trim()), //评分
ScoreType = objRow[conzx_AnswerCount.ScoreType] == DBNull.Value ? null : objRow[conzx_AnswerCount.ScoreType].ToString().Trim(), //评分类型
UpdUser = objRow[conzx_AnswerCount.UpdUser] == DBNull.Value ? null : objRow[conzx_AnswerCount.UpdUser].ToString().Trim(), //修改人
UpdDate = objRow[conzx_AnswerCount.UpdDate] == DBNull.Value ? null : objRow[conzx_AnswerCount.UpdDate].ToString().Trim(), //修改日期
UserName = objRow[conzx_AnswerCount.UserName] == DBNull.Value ? null : objRow[conzx_AnswerCount.UserName].ToString().Trim() //用户名
};
objzx_AnswerCountEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_AnswerCountEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clszx_AnswerCountDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clszx_AnswerCountEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clszx_AnswerCountEN objzx_AnswerCountEN = new clszx_AnswerCountEN();
try
{
objzx_AnswerCountEN.Memo = objRow[conzx_AnswerCount.Memo] == DBNull.Value ? null : objRow[conzx_AnswerCount.Memo].ToString().Trim(); //备注
objzx_AnswerCountEN.AnswerCountId = objRow[conzx_AnswerCount.AnswerCountId].ToString().Trim(); //AnswerCountId
objzx_AnswerCountEN.DataUser = objRow[conzx_AnswerCount.DataUser] == DBNull.Value ? null : objRow[conzx_AnswerCount.DataUser].ToString().Trim(); //数据用户
objzx_AnswerCountEN.DataAddDate = objRow[conzx_AnswerCount.DataAddDate] == DBNull.Value ? null : objRow[conzx_AnswerCount.DataAddDate].ToString().Trim(); //数据添加日期
objzx_AnswerCountEN.Month = objRow[conzx_AnswerCount.Month] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_AnswerCount.Month].ToString().Trim()); //月
objzx_AnswerCountEN.Week = objRow[conzx_AnswerCount.Week] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_AnswerCount.Week].ToString().Trim()); //周
objzx_AnswerCountEN.WeekTimeRange = objRow[conzx_AnswerCount.WeekTimeRange] == DBNull.Value ? null : objRow[conzx_AnswerCount.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objzx_AnswerCountEN.IsRecommend = TransNullToBool(objRow[conzx_AnswerCount.IsRecommend].ToString().Trim()); //是否推荐
objzx_AnswerCountEN.zxAnswerId = objRow[conzx_AnswerCount.zxAnswerId] == DBNull.Value ? null : objRow[conzx_AnswerCount.zxAnswerId].ToString().Trim(); //回答Id
objzx_AnswerCountEN.AnswerTypeId = objRow[conzx_AnswerCount.AnswerTypeId] == DBNull.Value ? null : objRow[conzx_AnswerCount.AnswerTypeId].ToString().Trim(); //答案类型ID
objzx_AnswerCountEN.zxQuestionsId = objRow[conzx_AnswerCount.zxQuestionsId] == DBNull.Value ? null : objRow[conzx_AnswerCount.zxQuestionsId].ToString().Trim(); //提问Id
objzx_AnswerCountEN.GroupTextId = objRow[conzx_AnswerCount.GroupTextId] == DBNull.Value ? null : objRow[conzx_AnswerCount.GroupTextId].ToString().Trim(); //小组Id
objzx_AnswerCountEN.TextId = objRow[conzx_AnswerCount.TextId] == DBNull.Value ? null : objRow[conzx_AnswerCount.TextId].ToString().Trim(); //课件Id
objzx_AnswerCountEN.IdCurrEduCls = objRow[conzx_AnswerCount.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_AnswerCount.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_AnswerCountEN.AnswerContent = objRow[conzx_AnswerCount.AnswerContent] == DBNull.Value ? null : objRow[conzx_AnswerCount.AnswerContent].ToString().Trim(); //答案内容
objzx_AnswerCountEN.Score = objRow[conzx_AnswerCount.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_AnswerCount.Score].ToString().Trim()); //评分
objzx_AnswerCountEN.ScoreType = objRow[conzx_AnswerCount.ScoreType] == DBNull.Value ? null : objRow[conzx_AnswerCount.ScoreType].ToString().Trim(); //评分类型
objzx_AnswerCountEN.UpdUser = objRow[conzx_AnswerCount.UpdUser] == DBNull.Value ? null : objRow[conzx_AnswerCount.UpdUser].ToString().Trim(); //修改人
objzx_AnswerCountEN.UpdDate = objRow[conzx_AnswerCount.UpdDate] == DBNull.Value ? null : objRow[conzx_AnswerCount.UpdDate].ToString().Trim(); //修改日期
objzx_AnswerCountEN.UserName = objRow[conzx_AnswerCount.UserName] == DBNull.Value ? null : objRow[conzx_AnswerCount.UserName].ToString().Trim(); //用户名
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clszx_AnswerCountDA: GetObjByDataRowzx_AnswerCount)", objException.Message));
}
objzx_AnswerCountEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_AnswerCountEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clszx_AnswerCountEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clszx_AnswerCountEN objzx_AnswerCountEN = new clszx_AnswerCountEN();
try
{
objzx_AnswerCountEN.Memo = objRow[conzx_AnswerCount.Memo] == DBNull.Value ? null : objRow[conzx_AnswerCount.Memo].ToString().Trim(); //备注
objzx_AnswerCountEN.AnswerCountId = objRow[conzx_AnswerCount.AnswerCountId].ToString().Trim(); //AnswerCountId
objzx_AnswerCountEN.DataUser = objRow[conzx_AnswerCount.DataUser] == DBNull.Value ? null : objRow[conzx_AnswerCount.DataUser].ToString().Trim(); //数据用户
objzx_AnswerCountEN.DataAddDate = objRow[conzx_AnswerCount.DataAddDate] == DBNull.Value ? null : objRow[conzx_AnswerCount.DataAddDate].ToString().Trim(); //数据添加日期
objzx_AnswerCountEN.Month = objRow[conzx_AnswerCount.Month] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_AnswerCount.Month].ToString().Trim()); //月
objzx_AnswerCountEN.Week = objRow[conzx_AnswerCount.Week] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_AnswerCount.Week].ToString().Trim()); //周
objzx_AnswerCountEN.WeekTimeRange = objRow[conzx_AnswerCount.WeekTimeRange] == DBNull.Value ? null : objRow[conzx_AnswerCount.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objzx_AnswerCountEN.IsRecommend = TransNullToBool(objRow[conzx_AnswerCount.IsRecommend].ToString().Trim()); //是否推荐
objzx_AnswerCountEN.zxAnswerId = objRow[conzx_AnswerCount.zxAnswerId] == DBNull.Value ? null : objRow[conzx_AnswerCount.zxAnswerId].ToString().Trim(); //回答Id
objzx_AnswerCountEN.AnswerTypeId = objRow[conzx_AnswerCount.AnswerTypeId] == DBNull.Value ? null : objRow[conzx_AnswerCount.AnswerTypeId].ToString().Trim(); //答案类型ID
objzx_AnswerCountEN.zxQuestionsId = objRow[conzx_AnswerCount.zxQuestionsId] == DBNull.Value ? null : objRow[conzx_AnswerCount.zxQuestionsId].ToString().Trim(); //提问Id
objzx_AnswerCountEN.GroupTextId = objRow[conzx_AnswerCount.GroupTextId] == DBNull.Value ? null : objRow[conzx_AnswerCount.GroupTextId].ToString().Trim(); //小组Id
objzx_AnswerCountEN.TextId = objRow[conzx_AnswerCount.TextId] == DBNull.Value ? null : objRow[conzx_AnswerCount.TextId].ToString().Trim(); //课件Id
objzx_AnswerCountEN.IdCurrEduCls = objRow[conzx_AnswerCount.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_AnswerCount.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_AnswerCountEN.AnswerContent = objRow[conzx_AnswerCount.AnswerContent] == DBNull.Value ? null : objRow[conzx_AnswerCount.AnswerContent].ToString().Trim(); //答案内容
objzx_AnswerCountEN.Score = objRow[conzx_AnswerCount.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_AnswerCount.Score].ToString().Trim()); //评分
objzx_AnswerCountEN.ScoreType = objRow[conzx_AnswerCount.ScoreType] == DBNull.Value ? null : objRow[conzx_AnswerCount.ScoreType].ToString().Trim(); //评分类型
objzx_AnswerCountEN.UpdUser = objRow[conzx_AnswerCount.UpdUser] == DBNull.Value ? null : objRow[conzx_AnswerCount.UpdUser].ToString().Trim(); //修改人
objzx_AnswerCountEN.UpdDate = objRow[conzx_AnswerCount.UpdDate] == DBNull.Value ? null : objRow[conzx_AnswerCount.UpdDate].ToString().Trim(); //修改日期
objzx_AnswerCountEN.UserName = objRow[conzx_AnswerCount.UserName] == DBNull.Value ? null : objRow[conzx_AnswerCount.UserName].ToString().Trim(); //用户名
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clszx_AnswerCountDA: GetObjByDataRow)", objException.Message));
}
objzx_AnswerCountEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_AnswerCountEN;
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
objSQL = clszx_AnswerCountDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clszx_AnswerCountEN._CurrTabName, conzx_AnswerCount.AnswerCountId, 10, "");
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
objSQL = clszx_AnswerCountDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clszx_AnswerCountEN._CurrTabName, conzx_AnswerCount.AnswerCountId, 10, strPrefix);
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
 objSQL = clszx_AnswerCountDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select AnswerCountId from zx_AnswerCount where " + strCondition;
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
 objSQL = clszx_AnswerCountDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select AnswerCountId from zx_AnswerCount where " + strCondition;
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
 /// <param name = "strAnswerCountId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strAnswerCountId)
{
CheckPrimaryKey(strAnswerCountId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_AnswerCountDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("zx_AnswerCount", "AnswerCountId = " + "'"+ strAnswerCountId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clszx_AnswerCountDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_AnswerCountDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("zx_AnswerCount", strCondition))
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
objSQL = clszx_AnswerCountDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("zx_AnswerCount");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clszx_AnswerCountEN objzx_AnswerCountEN)
 {
 if (objzx_AnswerCountEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_AnswerCountEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_AnswerCountDA.GetSpecSQLObj();
strSQL = "Select * from zx_AnswerCount where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "zx_AnswerCount");
objRow = objDS.Tables["zx_AnswerCount"].NewRow();
 if (objzx_AnswerCountEN.Memo !=  "")
 {
objRow[conzx_AnswerCount.Memo] = objzx_AnswerCountEN.Memo; //备注
 }
objRow[conzx_AnswerCount.AnswerCountId] = objzx_AnswerCountEN.AnswerCountId; //AnswerCountId
 if (objzx_AnswerCountEN.DataUser !=  "")
 {
objRow[conzx_AnswerCount.DataUser] = objzx_AnswerCountEN.DataUser; //数据用户
 }
 if (objzx_AnswerCountEN.DataAddDate !=  "")
 {
objRow[conzx_AnswerCount.DataAddDate] = objzx_AnswerCountEN.DataAddDate; //数据添加日期
 }
objRow[conzx_AnswerCount.Month] = objzx_AnswerCountEN.Month; //月
objRow[conzx_AnswerCount.Week] = objzx_AnswerCountEN.Week; //周
 if (objzx_AnswerCountEN.WeekTimeRange !=  "")
 {
objRow[conzx_AnswerCount.WeekTimeRange] = objzx_AnswerCountEN.WeekTimeRange; //WeekTimeRange
 }
objRow[conzx_AnswerCount.IsRecommend] = objzx_AnswerCountEN.IsRecommend; //是否推荐
 if (objzx_AnswerCountEN.zxAnswerId !=  "")
 {
objRow[conzx_AnswerCount.zxAnswerId] = objzx_AnswerCountEN.zxAnswerId; //回答Id
 }
 if (objzx_AnswerCountEN.AnswerTypeId !=  "")
 {
objRow[conzx_AnswerCount.AnswerTypeId] = objzx_AnswerCountEN.AnswerTypeId; //答案类型ID
 }
 if (objzx_AnswerCountEN.zxQuestionsId !=  "")
 {
objRow[conzx_AnswerCount.zxQuestionsId] = objzx_AnswerCountEN.zxQuestionsId; //提问Id
 }
 if (objzx_AnswerCountEN.GroupTextId !=  "")
 {
objRow[conzx_AnswerCount.GroupTextId] = objzx_AnswerCountEN.GroupTextId; //小组Id
 }
 if (objzx_AnswerCountEN.TextId !=  "")
 {
objRow[conzx_AnswerCount.TextId] = objzx_AnswerCountEN.TextId; //课件Id
 }
 if (objzx_AnswerCountEN.IdCurrEduCls !=  "")
 {
objRow[conzx_AnswerCount.IdCurrEduCls] = objzx_AnswerCountEN.IdCurrEduCls; //教学班流水号
 }
 if (objzx_AnswerCountEN.AnswerContent !=  "")
 {
objRow[conzx_AnswerCount.AnswerContent] = objzx_AnswerCountEN.AnswerContent; //答案内容
 }
objRow[conzx_AnswerCount.Score] = objzx_AnswerCountEN.Score; //评分
 if (objzx_AnswerCountEN.ScoreType !=  "")
 {
objRow[conzx_AnswerCount.ScoreType] = objzx_AnswerCountEN.ScoreType; //评分类型
 }
 if (objzx_AnswerCountEN.UpdUser !=  "")
 {
objRow[conzx_AnswerCount.UpdUser] = objzx_AnswerCountEN.UpdUser; //修改人
 }
 if (objzx_AnswerCountEN.UpdDate !=  "")
 {
objRow[conzx_AnswerCount.UpdDate] = objzx_AnswerCountEN.UpdDate; //修改日期
 }
 if (objzx_AnswerCountEN.UserName !=  "")
 {
objRow[conzx_AnswerCount.UserName] = objzx_AnswerCountEN.UserName; //用户名
 }
objDS.Tables[clszx_AnswerCountEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clszx_AnswerCountEN._CurrTabName);
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
 /// <param name = "objzx_AnswerCountEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clszx_AnswerCountEN objzx_AnswerCountEN)
{
 if (objzx_AnswerCountEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_AnswerCountEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_AnswerCountEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.Memo);
 var strMemo = objzx_AnswerCountEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_AnswerCountEN.AnswerCountId !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.AnswerCountId);
 var strAnswerCountId = objzx_AnswerCountEN.AnswerCountId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerCountId + "'");
 }
 
 if (objzx_AnswerCountEN.DataUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.DataUser);
 var strDataUser = objzx_AnswerCountEN.DataUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataUser + "'");
 }
 
 if (objzx_AnswerCountEN.DataAddDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.DataAddDate);
 var strDataAddDate = objzx_AnswerCountEN.DataAddDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataAddDate + "'");
 }
 
 if (objzx_AnswerCountEN.Month !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.Month);
 arrValueListForInsert.Add(objzx_AnswerCountEN.Month.ToString());
 }
 
 if (objzx_AnswerCountEN.Week !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.Week);
 arrValueListForInsert.Add(objzx_AnswerCountEN.Week.ToString());
 }
 
 if (objzx_AnswerCountEN.WeekTimeRange !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.WeekTimeRange);
 var strWeekTimeRange = objzx_AnswerCountEN.WeekTimeRange.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWeekTimeRange + "'");
 }
 
 arrFieldListForInsert.Add(conzx_AnswerCount.IsRecommend);
 arrValueListForInsert.Add("'" + (objzx_AnswerCountEN.IsRecommend  ==  false ? "0" : "1") + "'");
 
 if (objzx_AnswerCountEN.zxAnswerId !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.zxAnswerId);
 var strzxAnswerId = objzx_AnswerCountEN.zxAnswerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxAnswerId + "'");
 }
 
 if (objzx_AnswerCountEN.AnswerTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.AnswerTypeId);
 var strAnswerTypeId = objzx_AnswerCountEN.AnswerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerTypeId + "'");
 }
 
 if (objzx_AnswerCountEN.zxQuestionsId !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.zxQuestionsId);
 var strzxQuestionsId = objzx_AnswerCountEN.zxQuestionsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxQuestionsId + "'");
 }
 
 if (objzx_AnswerCountEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.GroupTextId);
 var strGroupTextId = objzx_AnswerCountEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 
 if (objzx_AnswerCountEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.TextId);
 var strTextId = objzx_AnswerCountEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 if (objzx_AnswerCountEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.IdCurrEduCls);
 var strIdCurrEduCls = objzx_AnswerCountEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objzx_AnswerCountEN.AnswerContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.AnswerContent);
 var strAnswerContent = objzx_AnswerCountEN.AnswerContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerContent + "'");
 }
 
 if (objzx_AnswerCountEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.Score);
 arrValueListForInsert.Add(objzx_AnswerCountEN.Score.ToString());
 }
 
 if (objzx_AnswerCountEN.ScoreType !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.ScoreType);
 var strScoreType = objzx_AnswerCountEN.ScoreType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strScoreType + "'");
 }
 
 if (objzx_AnswerCountEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.UpdUser);
 var strUpdUser = objzx_AnswerCountEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_AnswerCountEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.UpdDate);
 var strUpdDate = objzx_AnswerCountEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_AnswerCountEN.UserName !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.UserName);
 var strUserName = objzx_AnswerCountEN.UserName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserName + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_AnswerCount");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_AnswerCountDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objzx_AnswerCountEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clszx_AnswerCountEN objzx_AnswerCountEN)
{
 if (objzx_AnswerCountEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_AnswerCountEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_AnswerCountEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.Memo);
 var strMemo = objzx_AnswerCountEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_AnswerCountEN.AnswerCountId !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.AnswerCountId);
 var strAnswerCountId = objzx_AnswerCountEN.AnswerCountId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerCountId + "'");
 }
 
 if (objzx_AnswerCountEN.DataUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.DataUser);
 var strDataUser = objzx_AnswerCountEN.DataUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataUser + "'");
 }
 
 if (objzx_AnswerCountEN.DataAddDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.DataAddDate);
 var strDataAddDate = objzx_AnswerCountEN.DataAddDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataAddDate + "'");
 }
 
 if (objzx_AnswerCountEN.Month !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.Month);
 arrValueListForInsert.Add(objzx_AnswerCountEN.Month.ToString());
 }
 
 if (objzx_AnswerCountEN.Week !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.Week);
 arrValueListForInsert.Add(objzx_AnswerCountEN.Week.ToString());
 }
 
 if (objzx_AnswerCountEN.WeekTimeRange !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.WeekTimeRange);
 var strWeekTimeRange = objzx_AnswerCountEN.WeekTimeRange.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWeekTimeRange + "'");
 }
 
 arrFieldListForInsert.Add(conzx_AnswerCount.IsRecommend);
 arrValueListForInsert.Add("'" + (objzx_AnswerCountEN.IsRecommend  ==  false ? "0" : "1") + "'");
 
 if (objzx_AnswerCountEN.zxAnswerId !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.zxAnswerId);
 var strzxAnswerId = objzx_AnswerCountEN.zxAnswerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxAnswerId + "'");
 }
 
 if (objzx_AnswerCountEN.AnswerTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.AnswerTypeId);
 var strAnswerTypeId = objzx_AnswerCountEN.AnswerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerTypeId + "'");
 }
 
 if (objzx_AnswerCountEN.zxQuestionsId !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.zxQuestionsId);
 var strzxQuestionsId = objzx_AnswerCountEN.zxQuestionsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxQuestionsId + "'");
 }
 
 if (objzx_AnswerCountEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.GroupTextId);
 var strGroupTextId = objzx_AnswerCountEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 
 if (objzx_AnswerCountEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.TextId);
 var strTextId = objzx_AnswerCountEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 if (objzx_AnswerCountEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.IdCurrEduCls);
 var strIdCurrEduCls = objzx_AnswerCountEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objzx_AnswerCountEN.AnswerContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.AnswerContent);
 var strAnswerContent = objzx_AnswerCountEN.AnswerContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerContent + "'");
 }
 
 if (objzx_AnswerCountEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.Score);
 arrValueListForInsert.Add(objzx_AnswerCountEN.Score.ToString());
 }
 
 if (objzx_AnswerCountEN.ScoreType !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.ScoreType);
 var strScoreType = objzx_AnswerCountEN.ScoreType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strScoreType + "'");
 }
 
 if (objzx_AnswerCountEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.UpdUser);
 var strUpdUser = objzx_AnswerCountEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_AnswerCountEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.UpdDate);
 var strUpdDate = objzx_AnswerCountEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_AnswerCountEN.UserName !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.UserName);
 var strUserName = objzx_AnswerCountEN.UserName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserName + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_AnswerCount");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_AnswerCountDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objzx_AnswerCountEN.AnswerCountId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objzx_AnswerCountEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clszx_AnswerCountEN objzx_AnswerCountEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objzx_AnswerCountEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_AnswerCountEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_AnswerCountEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.Memo);
 var strMemo = objzx_AnswerCountEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_AnswerCountEN.AnswerCountId !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.AnswerCountId);
 var strAnswerCountId = objzx_AnswerCountEN.AnswerCountId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerCountId + "'");
 }
 
 if (objzx_AnswerCountEN.DataUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.DataUser);
 var strDataUser = objzx_AnswerCountEN.DataUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataUser + "'");
 }
 
 if (objzx_AnswerCountEN.DataAddDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.DataAddDate);
 var strDataAddDate = objzx_AnswerCountEN.DataAddDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataAddDate + "'");
 }
 
 if (objzx_AnswerCountEN.Month !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.Month);
 arrValueListForInsert.Add(objzx_AnswerCountEN.Month.ToString());
 }
 
 if (objzx_AnswerCountEN.Week !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.Week);
 arrValueListForInsert.Add(objzx_AnswerCountEN.Week.ToString());
 }
 
 if (objzx_AnswerCountEN.WeekTimeRange !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.WeekTimeRange);
 var strWeekTimeRange = objzx_AnswerCountEN.WeekTimeRange.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWeekTimeRange + "'");
 }
 
 arrFieldListForInsert.Add(conzx_AnswerCount.IsRecommend);
 arrValueListForInsert.Add("'" + (objzx_AnswerCountEN.IsRecommend  ==  false ? "0" : "1") + "'");
 
 if (objzx_AnswerCountEN.zxAnswerId !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.zxAnswerId);
 var strzxAnswerId = objzx_AnswerCountEN.zxAnswerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxAnswerId + "'");
 }
 
 if (objzx_AnswerCountEN.AnswerTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.AnswerTypeId);
 var strAnswerTypeId = objzx_AnswerCountEN.AnswerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerTypeId + "'");
 }
 
 if (objzx_AnswerCountEN.zxQuestionsId !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.zxQuestionsId);
 var strzxQuestionsId = objzx_AnswerCountEN.zxQuestionsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxQuestionsId + "'");
 }
 
 if (objzx_AnswerCountEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.GroupTextId);
 var strGroupTextId = objzx_AnswerCountEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 
 if (objzx_AnswerCountEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.TextId);
 var strTextId = objzx_AnswerCountEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 if (objzx_AnswerCountEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.IdCurrEduCls);
 var strIdCurrEduCls = objzx_AnswerCountEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objzx_AnswerCountEN.AnswerContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.AnswerContent);
 var strAnswerContent = objzx_AnswerCountEN.AnswerContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerContent + "'");
 }
 
 if (objzx_AnswerCountEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.Score);
 arrValueListForInsert.Add(objzx_AnswerCountEN.Score.ToString());
 }
 
 if (objzx_AnswerCountEN.ScoreType !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.ScoreType);
 var strScoreType = objzx_AnswerCountEN.ScoreType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strScoreType + "'");
 }
 
 if (objzx_AnswerCountEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.UpdUser);
 var strUpdUser = objzx_AnswerCountEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_AnswerCountEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.UpdDate);
 var strUpdDate = objzx_AnswerCountEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_AnswerCountEN.UserName !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.UserName);
 var strUserName = objzx_AnswerCountEN.UserName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserName + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_AnswerCount");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_AnswerCountDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objzx_AnswerCountEN.AnswerCountId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objzx_AnswerCountEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clszx_AnswerCountEN objzx_AnswerCountEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objzx_AnswerCountEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_AnswerCountEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_AnswerCountEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.Memo);
 var strMemo = objzx_AnswerCountEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_AnswerCountEN.AnswerCountId !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.AnswerCountId);
 var strAnswerCountId = objzx_AnswerCountEN.AnswerCountId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerCountId + "'");
 }
 
 if (objzx_AnswerCountEN.DataUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.DataUser);
 var strDataUser = objzx_AnswerCountEN.DataUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataUser + "'");
 }
 
 if (objzx_AnswerCountEN.DataAddDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.DataAddDate);
 var strDataAddDate = objzx_AnswerCountEN.DataAddDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataAddDate + "'");
 }
 
 if (objzx_AnswerCountEN.Month !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.Month);
 arrValueListForInsert.Add(objzx_AnswerCountEN.Month.ToString());
 }
 
 if (objzx_AnswerCountEN.Week !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.Week);
 arrValueListForInsert.Add(objzx_AnswerCountEN.Week.ToString());
 }
 
 if (objzx_AnswerCountEN.WeekTimeRange !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.WeekTimeRange);
 var strWeekTimeRange = objzx_AnswerCountEN.WeekTimeRange.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWeekTimeRange + "'");
 }
 
 arrFieldListForInsert.Add(conzx_AnswerCount.IsRecommend);
 arrValueListForInsert.Add("'" + (objzx_AnswerCountEN.IsRecommend  ==  false ? "0" : "1") + "'");
 
 if (objzx_AnswerCountEN.zxAnswerId !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.zxAnswerId);
 var strzxAnswerId = objzx_AnswerCountEN.zxAnswerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxAnswerId + "'");
 }
 
 if (objzx_AnswerCountEN.AnswerTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.AnswerTypeId);
 var strAnswerTypeId = objzx_AnswerCountEN.AnswerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerTypeId + "'");
 }
 
 if (objzx_AnswerCountEN.zxQuestionsId !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.zxQuestionsId);
 var strzxQuestionsId = objzx_AnswerCountEN.zxQuestionsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxQuestionsId + "'");
 }
 
 if (objzx_AnswerCountEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.GroupTextId);
 var strGroupTextId = objzx_AnswerCountEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 
 if (objzx_AnswerCountEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.TextId);
 var strTextId = objzx_AnswerCountEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 if (objzx_AnswerCountEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.IdCurrEduCls);
 var strIdCurrEduCls = objzx_AnswerCountEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objzx_AnswerCountEN.AnswerContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.AnswerContent);
 var strAnswerContent = objzx_AnswerCountEN.AnswerContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerContent + "'");
 }
 
 if (objzx_AnswerCountEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.Score);
 arrValueListForInsert.Add(objzx_AnswerCountEN.Score.ToString());
 }
 
 if (objzx_AnswerCountEN.ScoreType !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.ScoreType);
 var strScoreType = objzx_AnswerCountEN.ScoreType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strScoreType + "'");
 }
 
 if (objzx_AnswerCountEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.UpdUser);
 var strUpdUser = objzx_AnswerCountEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_AnswerCountEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.UpdDate);
 var strUpdDate = objzx_AnswerCountEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_AnswerCountEN.UserName !=  null)
 {
 arrFieldListForInsert.Add(conzx_AnswerCount.UserName);
 var strUserName = objzx_AnswerCountEN.UserName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserName + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_AnswerCount");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_AnswerCountDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewzx_AnswerCounts(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_AnswerCountDA.GetSpecSQLObj();
strSQL = "Select * from zx_AnswerCount where AnswerCountId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "zx_AnswerCount");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strAnswerCountId = oRow[conzx_AnswerCount.AnswerCountId].ToString().Trim();
if (IsExist(strAnswerCountId))
{
 string strResult = "关键字变量值为:" + string.Format("AnswerCountId = {0}", strAnswerCountId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clszx_AnswerCountEN._CurrTabName ].NewRow();
objRow[conzx_AnswerCount.Memo] = oRow[conzx_AnswerCount.Memo].ToString().Trim(); //备注
objRow[conzx_AnswerCount.AnswerCountId] = oRow[conzx_AnswerCount.AnswerCountId].ToString().Trim(); //AnswerCountId
objRow[conzx_AnswerCount.DataUser] = oRow[conzx_AnswerCount.DataUser].ToString().Trim(); //数据用户
objRow[conzx_AnswerCount.DataAddDate] = oRow[conzx_AnswerCount.DataAddDate].ToString().Trim(); //数据添加日期
objRow[conzx_AnswerCount.Month] = oRow[conzx_AnswerCount.Month].ToString().Trim(); //月
objRow[conzx_AnswerCount.Week] = oRow[conzx_AnswerCount.Week].ToString().Trim(); //周
objRow[conzx_AnswerCount.WeekTimeRange] = oRow[conzx_AnswerCount.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objRow[conzx_AnswerCount.IsRecommend] = oRow[conzx_AnswerCount.IsRecommend].ToString().Trim(); //是否推荐
objRow[conzx_AnswerCount.zxAnswerId] = oRow[conzx_AnswerCount.zxAnswerId].ToString().Trim(); //回答Id
objRow[conzx_AnswerCount.AnswerTypeId] = oRow[conzx_AnswerCount.AnswerTypeId].ToString().Trim(); //答案类型ID
objRow[conzx_AnswerCount.zxQuestionsId] = oRow[conzx_AnswerCount.zxQuestionsId].ToString().Trim(); //提问Id
objRow[conzx_AnswerCount.GroupTextId] = oRow[conzx_AnswerCount.GroupTextId].ToString().Trim(); //小组Id
objRow[conzx_AnswerCount.TextId] = oRow[conzx_AnswerCount.TextId].ToString().Trim(); //课件Id
objRow[conzx_AnswerCount.IdCurrEduCls] = oRow[conzx_AnswerCount.IdCurrEduCls].ToString().Trim(); //教学班流水号
objRow[conzx_AnswerCount.AnswerContent] = oRow[conzx_AnswerCount.AnswerContent].ToString().Trim(); //答案内容
objRow[conzx_AnswerCount.Score] = oRow[conzx_AnswerCount.Score].ToString().Trim(); //评分
objRow[conzx_AnswerCount.ScoreType] = oRow[conzx_AnswerCount.ScoreType].ToString().Trim(); //评分类型
objRow[conzx_AnswerCount.UpdUser] = oRow[conzx_AnswerCount.UpdUser].ToString().Trim(); //修改人
objRow[conzx_AnswerCount.UpdDate] = oRow[conzx_AnswerCount.UpdDate].ToString().Trim(); //修改日期
objRow[conzx_AnswerCount.UserName] = oRow[conzx_AnswerCount.UserName].ToString().Trim(); //用户名
 objDS.Tables[clszx_AnswerCountEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clszx_AnswerCountEN._CurrTabName);
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
 /// <param name = "objzx_AnswerCountEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clszx_AnswerCountEN objzx_AnswerCountEN)
{
 if (objzx_AnswerCountEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_AnswerCountEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_AnswerCountDA.GetSpecSQLObj();
strSQL = "Select * from zx_AnswerCount where AnswerCountId = " + "'"+ objzx_AnswerCountEN.AnswerCountId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clszx_AnswerCountEN._CurrTabName);
if (objDS.Tables[clszx_AnswerCountEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:AnswerCountId = " + "'"+ objzx_AnswerCountEN.AnswerCountId+"'");
return false;
}
objRow = objDS.Tables[clszx_AnswerCountEN._CurrTabName].Rows[0];
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.Memo))
 {
objRow[conzx_AnswerCount.Memo] = objzx_AnswerCountEN.Memo; //备注
 }
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.AnswerCountId))
 {
objRow[conzx_AnswerCount.AnswerCountId] = objzx_AnswerCountEN.AnswerCountId; //AnswerCountId
 }
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.DataUser))
 {
objRow[conzx_AnswerCount.DataUser] = objzx_AnswerCountEN.DataUser; //数据用户
 }
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.DataAddDate))
 {
objRow[conzx_AnswerCount.DataAddDate] = objzx_AnswerCountEN.DataAddDate; //数据添加日期
 }
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.Month))
 {
objRow[conzx_AnswerCount.Month] = objzx_AnswerCountEN.Month; //月
 }
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.Week))
 {
objRow[conzx_AnswerCount.Week] = objzx_AnswerCountEN.Week; //周
 }
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.WeekTimeRange))
 {
objRow[conzx_AnswerCount.WeekTimeRange] = objzx_AnswerCountEN.WeekTimeRange; //WeekTimeRange
 }
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.IsRecommend))
 {
objRow[conzx_AnswerCount.IsRecommend] = objzx_AnswerCountEN.IsRecommend; //是否推荐
 }
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.zxAnswerId))
 {
objRow[conzx_AnswerCount.zxAnswerId] = objzx_AnswerCountEN.zxAnswerId; //回答Id
 }
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.AnswerTypeId))
 {
objRow[conzx_AnswerCount.AnswerTypeId] = objzx_AnswerCountEN.AnswerTypeId; //答案类型ID
 }
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.zxQuestionsId))
 {
objRow[conzx_AnswerCount.zxQuestionsId] = objzx_AnswerCountEN.zxQuestionsId; //提问Id
 }
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.GroupTextId))
 {
objRow[conzx_AnswerCount.GroupTextId] = objzx_AnswerCountEN.GroupTextId; //小组Id
 }
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.TextId))
 {
objRow[conzx_AnswerCount.TextId] = objzx_AnswerCountEN.TextId; //课件Id
 }
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.IdCurrEduCls))
 {
objRow[conzx_AnswerCount.IdCurrEduCls] = objzx_AnswerCountEN.IdCurrEduCls; //教学班流水号
 }
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.AnswerContent))
 {
objRow[conzx_AnswerCount.AnswerContent] = objzx_AnswerCountEN.AnswerContent; //答案内容
 }
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.Score))
 {
objRow[conzx_AnswerCount.Score] = objzx_AnswerCountEN.Score; //评分
 }
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.ScoreType))
 {
objRow[conzx_AnswerCount.ScoreType] = objzx_AnswerCountEN.ScoreType; //评分类型
 }
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.UpdUser))
 {
objRow[conzx_AnswerCount.UpdUser] = objzx_AnswerCountEN.UpdUser; //修改人
 }
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.UpdDate))
 {
objRow[conzx_AnswerCount.UpdDate] = objzx_AnswerCountEN.UpdDate; //修改日期
 }
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.UserName))
 {
objRow[conzx_AnswerCount.UserName] = objzx_AnswerCountEN.UserName; //用户名
 }
try
{
objDA.Update(objDS, clszx_AnswerCountEN._CurrTabName);
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
 /// <param name = "objzx_AnswerCountEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clszx_AnswerCountEN objzx_AnswerCountEN)
{
 if (objzx_AnswerCountEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_AnswerCountEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_AnswerCountDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update zx_AnswerCount Set ");
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.Memo))
 {
 if (objzx_AnswerCountEN.Memo !=  null)
 {
 var strMemo = objzx_AnswerCountEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conzx_AnswerCount.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_AnswerCount.Memo); //备注
 }
 }
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.DataUser))
 {
 if (objzx_AnswerCountEN.DataUser !=  null)
 {
 var strDataUser = objzx_AnswerCountEN.DataUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDataUser, conzx_AnswerCount.DataUser); //数据用户
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_AnswerCount.DataUser); //数据用户
 }
 }
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.DataAddDate))
 {
 if (objzx_AnswerCountEN.DataAddDate !=  null)
 {
 var strDataAddDate = objzx_AnswerCountEN.DataAddDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDataAddDate, conzx_AnswerCount.DataAddDate); //数据添加日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_AnswerCount.DataAddDate); //数据添加日期
 }
 }
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.Month))
 {
 if (objzx_AnswerCountEN.Month !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_AnswerCountEN.Month, conzx_AnswerCount.Month); //月
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_AnswerCount.Month); //月
 }
 }
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.Week))
 {
 if (objzx_AnswerCountEN.Week !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_AnswerCountEN.Week, conzx_AnswerCount.Week); //周
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_AnswerCount.Week); //周
 }
 }
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.WeekTimeRange))
 {
 if (objzx_AnswerCountEN.WeekTimeRange !=  null)
 {
 var strWeekTimeRange = objzx_AnswerCountEN.WeekTimeRange.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWeekTimeRange, conzx_AnswerCount.WeekTimeRange); //WeekTimeRange
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_AnswerCount.WeekTimeRange); //WeekTimeRange
 }
 }
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.IsRecommend))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objzx_AnswerCountEN.IsRecommend == true?"1":"0", conzx_AnswerCount.IsRecommend); //是否推荐
 }
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.zxAnswerId))
 {
 if (objzx_AnswerCountEN.zxAnswerId !=  null)
 {
 var strzxAnswerId = objzx_AnswerCountEN.zxAnswerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxAnswerId, conzx_AnswerCount.zxAnswerId); //回答Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_AnswerCount.zxAnswerId); //回答Id
 }
 }
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.AnswerTypeId))
 {
 if (objzx_AnswerCountEN.AnswerTypeId !=  null)
 {
 var strAnswerTypeId = objzx_AnswerCountEN.AnswerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerTypeId, conzx_AnswerCount.AnswerTypeId); //答案类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_AnswerCount.AnswerTypeId); //答案类型ID
 }
 }
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.zxQuestionsId))
 {
 if (objzx_AnswerCountEN.zxQuestionsId !=  null)
 {
 var strzxQuestionsId = objzx_AnswerCountEN.zxQuestionsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxQuestionsId, conzx_AnswerCount.zxQuestionsId); //提问Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_AnswerCount.zxQuestionsId); //提问Id
 }
 }
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.GroupTextId))
 {
 if (objzx_AnswerCountEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_AnswerCountEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGroupTextId, conzx_AnswerCount.GroupTextId); //小组Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_AnswerCount.GroupTextId); //小组Id
 }
 }
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.TextId))
 {
 if (objzx_AnswerCountEN.TextId !=  null)
 {
 var strTextId = objzx_AnswerCountEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTextId, conzx_AnswerCount.TextId); //课件Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_AnswerCount.TextId); //课件Id
 }
 }
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.IdCurrEduCls))
 {
 if (objzx_AnswerCountEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_AnswerCountEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conzx_AnswerCount.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_AnswerCount.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.AnswerContent))
 {
 if (objzx_AnswerCountEN.AnswerContent !=  null)
 {
 var strAnswerContent = objzx_AnswerCountEN.AnswerContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerContent, conzx_AnswerCount.AnswerContent); //答案内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_AnswerCount.AnswerContent); //答案内容
 }
 }
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.Score))
 {
 if (objzx_AnswerCountEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_AnswerCountEN.Score, conzx_AnswerCount.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_AnswerCount.Score); //评分
 }
 }
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.ScoreType))
 {
 if (objzx_AnswerCountEN.ScoreType !=  null)
 {
 var strScoreType = objzx_AnswerCountEN.ScoreType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strScoreType, conzx_AnswerCount.ScoreType); //评分类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_AnswerCount.ScoreType); //评分类型
 }
 }
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.UpdUser))
 {
 if (objzx_AnswerCountEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_AnswerCountEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conzx_AnswerCount.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_AnswerCount.UpdUser); //修改人
 }
 }
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.UpdDate))
 {
 if (objzx_AnswerCountEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_AnswerCountEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conzx_AnswerCount.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_AnswerCount.UpdDate); //修改日期
 }
 }
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.UserName))
 {
 if (objzx_AnswerCountEN.UserName !=  null)
 {
 var strUserName = objzx_AnswerCountEN.UserName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserName, conzx_AnswerCount.UserName); //用户名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_AnswerCount.UserName); //用户名
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where AnswerCountId = '{0}'", objzx_AnswerCountEN.AnswerCountId); 
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
 /// <param name = "objzx_AnswerCountEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clszx_AnswerCountEN objzx_AnswerCountEN, string strCondition)
{
 if (objzx_AnswerCountEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_AnswerCountEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_AnswerCountDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_AnswerCount Set ");
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.Memo))
 {
 if (objzx_AnswerCountEN.Memo !=  null)
 {
 var strMemo = objzx_AnswerCountEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.DataUser))
 {
 if (objzx_AnswerCountEN.DataUser !=  null)
 {
 var strDataUser = objzx_AnswerCountEN.DataUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataUser = '{0}',", strDataUser); //数据用户
 }
 else
 {
 sbSQL.Append(" DataUser = null,"); //数据用户
 }
 }
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.DataAddDate))
 {
 if (objzx_AnswerCountEN.DataAddDate !=  null)
 {
 var strDataAddDate = objzx_AnswerCountEN.DataAddDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataAddDate = '{0}',", strDataAddDate); //数据添加日期
 }
 else
 {
 sbSQL.Append(" DataAddDate = null,"); //数据添加日期
 }
 }
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.Month))
 {
 if (objzx_AnswerCountEN.Month !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_AnswerCountEN.Month, conzx_AnswerCount.Month); //月
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_AnswerCount.Month); //月
 }
 }
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.Week))
 {
 if (objzx_AnswerCountEN.Week !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_AnswerCountEN.Week, conzx_AnswerCount.Week); //周
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_AnswerCount.Week); //周
 }
 }
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.WeekTimeRange))
 {
 if (objzx_AnswerCountEN.WeekTimeRange !=  null)
 {
 var strWeekTimeRange = objzx_AnswerCountEN.WeekTimeRange.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WeekTimeRange = '{0}',", strWeekTimeRange); //WeekTimeRange
 }
 else
 {
 sbSQL.Append(" WeekTimeRange = null,"); //WeekTimeRange
 }
 }
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.IsRecommend))
 {
 sbSQL.AppendFormat(" IsRecommend = '{0}',", objzx_AnswerCountEN.IsRecommend == true?"1":"0"); //是否推荐
 }
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.zxAnswerId))
 {
 if (objzx_AnswerCountEN.zxAnswerId !=  null)
 {
 var strzxAnswerId = objzx_AnswerCountEN.zxAnswerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxAnswerId = '{0}',", strzxAnswerId); //回答Id
 }
 else
 {
 sbSQL.Append(" zxAnswerId = null,"); //回答Id
 }
 }
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.AnswerTypeId))
 {
 if (objzx_AnswerCountEN.AnswerTypeId !=  null)
 {
 var strAnswerTypeId = objzx_AnswerCountEN.AnswerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerTypeId = '{0}',", strAnswerTypeId); //答案类型ID
 }
 else
 {
 sbSQL.Append(" AnswerTypeId = null,"); //答案类型ID
 }
 }
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.zxQuestionsId))
 {
 if (objzx_AnswerCountEN.zxQuestionsId !=  null)
 {
 var strzxQuestionsId = objzx_AnswerCountEN.zxQuestionsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxQuestionsId = '{0}',", strzxQuestionsId); //提问Id
 }
 else
 {
 sbSQL.Append(" zxQuestionsId = null,"); //提问Id
 }
 }
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.GroupTextId))
 {
 if (objzx_AnswerCountEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_AnswerCountEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GroupTextId = '{0}',", strGroupTextId); //小组Id
 }
 else
 {
 sbSQL.Append(" GroupTextId = null,"); //小组Id
 }
 }
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.TextId))
 {
 if (objzx_AnswerCountEN.TextId !=  null)
 {
 var strTextId = objzx_AnswerCountEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TextId = '{0}',", strTextId); //课件Id
 }
 else
 {
 sbSQL.Append(" TextId = null,"); //课件Id
 }
 }
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.IdCurrEduCls))
 {
 if (objzx_AnswerCountEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_AnswerCountEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.AnswerContent))
 {
 if (objzx_AnswerCountEN.AnswerContent !=  null)
 {
 var strAnswerContent = objzx_AnswerCountEN.AnswerContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerContent = '{0}',", strAnswerContent); //答案内容
 }
 else
 {
 sbSQL.Append(" AnswerContent = null,"); //答案内容
 }
 }
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.Score))
 {
 if (objzx_AnswerCountEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_AnswerCountEN.Score, conzx_AnswerCount.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_AnswerCount.Score); //评分
 }
 }
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.ScoreType))
 {
 if (objzx_AnswerCountEN.ScoreType !=  null)
 {
 var strScoreType = objzx_AnswerCountEN.ScoreType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ScoreType = '{0}',", strScoreType); //评分类型
 }
 else
 {
 sbSQL.Append(" ScoreType = null,"); //评分类型
 }
 }
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.UpdUser))
 {
 if (objzx_AnswerCountEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_AnswerCountEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.UpdDate))
 {
 if (objzx_AnswerCountEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_AnswerCountEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.UserName))
 {
 if (objzx_AnswerCountEN.UserName !=  null)
 {
 var strUserName = objzx_AnswerCountEN.UserName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserName = '{0}',", strUserName); //用户名
 }
 else
 {
 sbSQL.Append(" UserName = null,"); //用户名
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
 /// <param name = "objzx_AnswerCountEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clszx_AnswerCountEN objzx_AnswerCountEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objzx_AnswerCountEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_AnswerCountEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_AnswerCountDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_AnswerCount Set ");
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.Memo))
 {
 if (objzx_AnswerCountEN.Memo !=  null)
 {
 var strMemo = objzx_AnswerCountEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.DataUser))
 {
 if (objzx_AnswerCountEN.DataUser !=  null)
 {
 var strDataUser = objzx_AnswerCountEN.DataUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataUser = '{0}',", strDataUser); //数据用户
 }
 else
 {
 sbSQL.Append(" DataUser = null,"); //数据用户
 }
 }
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.DataAddDate))
 {
 if (objzx_AnswerCountEN.DataAddDate !=  null)
 {
 var strDataAddDate = objzx_AnswerCountEN.DataAddDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataAddDate = '{0}',", strDataAddDate); //数据添加日期
 }
 else
 {
 sbSQL.Append(" DataAddDate = null,"); //数据添加日期
 }
 }
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.Month))
 {
 if (objzx_AnswerCountEN.Month !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_AnswerCountEN.Month, conzx_AnswerCount.Month); //月
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_AnswerCount.Month); //月
 }
 }
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.Week))
 {
 if (objzx_AnswerCountEN.Week !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_AnswerCountEN.Week, conzx_AnswerCount.Week); //周
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_AnswerCount.Week); //周
 }
 }
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.WeekTimeRange))
 {
 if (objzx_AnswerCountEN.WeekTimeRange !=  null)
 {
 var strWeekTimeRange = objzx_AnswerCountEN.WeekTimeRange.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WeekTimeRange = '{0}',", strWeekTimeRange); //WeekTimeRange
 }
 else
 {
 sbSQL.Append(" WeekTimeRange = null,"); //WeekTimeRange
 }
 }
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.IsRecommend))
 {
 sbSQL.AppendFormat(" IsRecommend = '{0}',", objzx_AnswerCountEN.IsRecommend == true?"1":"0"); //是否推荐
 }
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.zxAnswerId))
 {
 if (objzx_AnswerCountEN.zxAnswerId !=  null)
 {
 var strzxAnswerId = objzx_AnswerCountEN.zxAnswerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxAnswerId = '{0}',", strzxAnswerId); //回答Id
 }
 else
 {
 sbSQL.Append(" zxAnswerId = null,"); //回答Id
 }
 }
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.AnswerTypeId))
 {
 if (objzx_AnswerCountEN.AnswerTypeId !=  null)
 {
 var strAnswerTypeId = objzx_AnswerCountEN.AnswerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerTypeId = '{0}',", strAnswerTypeId); //答案类型ID
 }
 else
 {
 sbSQL.Append(" AnswerTypeId = null,"); //答案类型ID
 }
 }
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.zxQuestionsId))
 {
 if (objzx_AnswerCountEN.zxQuestionsId !=  null)
 {
 var strzxQuestionsId = objzx_AnswerCountEN.zxQuestionsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxQuestionsId = '{0}',", strzxQuestionsId); //提问Id
 }
 else
 {
 sbSQL.Append(" zxQuestionsId = null,"); //提问Id
 }
 }
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.GroupTextId))
 {
 if (objzx_AnswerCountEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_AnswerCountEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GroupTextId = '{0}',", strGroupTextId); //小组Id
 }
 else
 {
 sbSQL.Append(" GroupTextId = null,"); //小组Id
 }
 }
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.TextId))
 {
 if (objzx_AnswerCountEN.TextId !=  null)
 {
 var strTextId = objzx_AnswerCountEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TextId = '{0}',", strTextId); //课件Id
 }
 else
 {
 sbSQL.Append(" TextId = null,"); //课件Id
 }
 }
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.IdCurrEduCls))
 {
 if (objzx_AnswerCountEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_AnswerCountEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.AnswerContent))
 {
 if (objzx_AnswerCountEN.AnswerContent !=  null)
 {
 var strAnswerContent = objzx_AnswerCountEN.AnswerContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerContent = '{0}',", strAnswerContent); //答案内容
 }
 else
 {
 sbSQL.Append(" AnswerContent = null,"); //答案内容
 }
 }
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.Score))
 {
 if (objzx_AnswerCountEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_AnswerCountEN.Score, conzx_AnswerCount.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_AnswerCount.Score); //评分
 }
 }
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.ScoreType))
 {
 if (objzx_AnswerCountEN.ScoreType !=  null)
 {
 var strScoreType = objzx_AnswerCountEN.ScoreType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ScoreType = '{0}',", strScoreType); //评分类型
 }
 else
 {
 sbSQL.Append(" ScoreType = null,"); //评分类型
 }
 }
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.UpdUser))
 {
 if (objzx_AnswerCountEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_AnswerCountEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.UpdDate))
 {
 if (objzx_AnswerCountEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_AnswerCountEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.UserName))
 {
 if (objzx_AnswerCountEN.UserName !=  null)
 {
 var strUserName = objzx_AnswerCountEN.UserName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserName = '{0}',", strUserName); //用户名
 }
 else
 {
 sbSQL.Append(" UserName = null,"); //用户名
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
 /// <param name = "objzx_AnswerCountEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clszx_AnswerCountEN objzx_AnswerCountEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objzx_AnswerCountEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_AnswerCountEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_AnswerCountDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_AnswerCount Set ");
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.Memo))
 {
 if (objzx_AnswerCountEN.Memo !=  null)
 {
 var strMemo = objzx_AnswerCountEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conzx_AnswerCount.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_AnswerCount.Memo); //备注
 }
 }
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.DataUser))
 {
 if (objzx_AnswerCountEN.DataUser !=  null)
 {
 var strDataUser = objzx_AnswerCountEN.DataUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDataUser, conzx_AnswerCount.DataUser); //数据用户
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_AnswerCount.DataUser); //数据用户
 }
 }
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.DataAddDate))
 {
 if (objzx_AnswerCountEN.DataAddDate !=  null)
 {
 var strDataAddDate = objzx_AnswerCountEN.DataAddDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDataAddDate, conzx_AnswerCount.DataAddDate); //数据添加日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_AnswerCount.DataAddDate); //数据添加日期
 }
 }
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.Month))
 {
 if (objzx_AnswerCountEN.Month !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_AnswerCountEN.Month, conzx_AnswerCount.Month); //月
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_AnswerCount.Month); //月
 }
 }
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.Week))
 {
 if (objzx_AnswerCountEN.Week !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_AnswerCountEN.Week, conzx_AnswerCount.Week); //周
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_AnswerCount.Week); //周
 }
 }
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.WeekTimeRange))
 {
 if (objzx_AnswerCountEN.WeekTimeRange !=  null)
 {
 var strWeekTimeRange = objzx_AnswerCountEN.WeekTimeRange.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWeekTimeRange, conzx_AnswerCount.WeekTimeRange); //WeekTimeRange
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_AnswerCount.WeekTimeRange); //WeekTimeRange
 }
 }
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.IsRecommend))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objzx_AnswerCountEN.IsRecommend == true?"1":"0", conzx_AnswerCount.IsRecommend); //是否推荐
 }
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.zxAnswerId))
 {
 if (objzx_AnswerCountEN.zxAnswerId !=  null)
 {
 var strzxAnswerId = objzx_AnswerCountEN.zxAnswerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxAnswerId, conzx_AnswerCount.zxAnswerId); //回答Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_AnswerCount.zxAnswerId); //回答Id
 }
 }
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.AnswerTypeId))
 {
 if (objzx_AnswerCountEN.AnswerTypeId !=  null)
 {
 var strAnswerTypeId = objzx_AnswerCountEN.AnswerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerTypeId, conzx_AnswerCount.AnswerTypeId); //答案类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_AnswerCount.AnswerTypeId); //答案类型ID
 }
 }
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.zxQuestionsId))
 {
 if (objzx_AnswerCountEN.zxQuestionsId !=  null)
 {
 var strzxQuestionsId = objzx_AnswerCountEN.zxQuestionsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxQuestionsId, conzx_AnswerCount.zxQuestionsId); //提问Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_AnswerCount.zxQuestionsId); //提问Id
 }
 }
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.GroupTextId))
 {
 if (objzx_AnswerCountEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_AnswerCountEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGroupTextId, conzx_AnswerCount.GroupTextId); //小组Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_AnswerCount.GroupTextId); //小组Id
 }
 }
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.TextId))
 {
 if (objzx_AnswerCountEN.TextId !=  null)
 {
 var strTextId = objzx_AnswerCountEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTextId, conzx_AnswerCount.TextId); //课件Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_AnswerCount.TextId); //课件Id
 }
 }
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.IdCurrEduCls))
 {
 if (objzx_AnswerCountEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_AnswerCountEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conzx_AnswerCount.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_AnswerCount.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.AnswerContent))
 {
 if (objzx_AnswerCountEN.AnswerContent !=  null)
 {
 var strAnswerContent = objzx_AnswerCountEN.AnswerContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerContent, conzx_AnswerCount.AnswerContent); //答案内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_AnswerCount.AnswerContent); //答案内容
 }
 }
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.Score))
 {
 if (objzx_AnswerCountEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_AnswerCountEN.Score, conzx_AnswerCount.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_AnswerCount.Score); //评分
 }
 }
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.ScoreType))
 {
 if (objzx_AnswerCountEN.ScoreType !=  null)
 {
 var strScoreType = objzx_AnswerCountEN.ScoreType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strScoreType, conzx_AnswerCount.ScoreType); //评分类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_AnswerCount.ScoreType); //评分类型
 }
 }
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.UpdUser))
 {
 if (objzx_AnswerCountEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_AnswerCountEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conzx_AnswerCount.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_AnswerCount.UpdUser); //修改人
 }
 }
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.UpdDate))
 {
 if (objzx_AnswerCountEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_AnswerCountEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conzx_AnswerCount.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_AnswerCount.UpdDate); //修改日期
 }
 }
 
 if (objzx_AnswerCountEN.IsUpdated(conzx_AnswerCount.UserName))
 {
 if (objzx_AnswerCountEN.UserName !=  null)
 {
 var strUserName = objzx_AnswerCountEN.UserName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserName, conzx_AnswerCount.UserName); //用户名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_AnswerCount.UserName); //用户名
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where AnswerCountId = '{0}'", objzx_AnswerCountEN.AnswerCountId); 
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
 /// <param name = "strAnswerCountId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strAnswerCountId) 
{
CheckPrimaryKey(strAnswerCountId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_AnswerCountDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strAnswerCountId,
};
 objSQL.ExecSP("zx_AnswerCount_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strAnswerCountId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strAnswerCountId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strAnswerCountId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_AnswerCountDA.GetSpecSQLObj();
//删除zx_AnswerCount本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_AnswerCount where AnswerCountId = " + "'"+ strAnswerCountId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delzx_AnswerCount(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_AnswerCountDA.GetSpecSQLObj();
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
//删除zx_AnswerCount本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_AnswerCount where AnswerCountId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strAnswerCountId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strAnswerCountId) 
{
CheckPrimaryKey(strAnswerCountId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_AnswerCountDA.GetSpecSQLObj();
//删除zx_AnswerCount本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_AnswerCount where AnswerCountId = " + "'"+ strAnswerCountId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delzx_AnswerCount(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clszx_AnswerCountDA: Delzx_AnswerCount)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_AnswerCountDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from zx_AnswerCount where " + strCondition ;
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
public bool Delzx_AnswerCountWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clszx_AnswerCountDA: Delzx_AnswerCountWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_AnswerCountDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from zx_AnswerCount where " + strCondition ;
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
 /// <param name = "objzx_AnswerCountENS">源对象</param>
 /// <param name = "objzx_AnswerCountENT">目标对象</param>
public void CopyTo(clszx_AnswerCountEN objzx_AnswerCountENS, clszx_AnswerCountEN objzx_AnswerCountENT)
{
objzx_AnswerCountENT.Memo = objzx_AnswerCountENS.Memo; //备注
objzx_AnswerCountENT.AnswerCountId = objzx_AnswerCountENS.AnswerCountId; //AnswerCountId
objzx_AnswerCountENT.DataUser = objzx_AnswerCountENS.DataUser; //数据用户
objzx_AnswerCountENT.DataAddDate = objzx_AnswerCountENS.DataAddDate; //数据添加日期
objzx_AnswerCountENT.Month = objzx_AnswerCountENS.Month; //月
objzx_AnswerCountENT.Week = objzx_AnswerCountENS.Week; //周
objzx_AnswerCountENT.WeekTimeRange = objzx_AnswerCountENS.WeekTimeRange; //WeekTimeRange
objzx_AnswerCountENT.IsRecommend = objzx_AnswerCountENS.IsRecommend; //是否推荐
objzx_AnswerCountENT.zxAnswerId = objzx_AnswerCountENS.zxAnswerId; //回答Id
objzx_AnswerCountENT.AnswerTypeId = objzx_AnswerCountENS.AnswerTypeId; //答案类型ID
objzx_AnswerCountENT.zxQuestionsId = objzx_AnswerCountENS.zxQuestionsId; //提问Id
objzx_AnswerCountENT.GroupTextId = objzx_AnswerCountENS.GroupTextId; //小组Id
objzx_AnswerCountENT.TextId = objzx_AnswerCountENS.TextId; //课件Id
objzx_AnswerCountENT.IdCurrEduCls = objzx_AnswerCountENS.IdCurrEduCls; //教学班流水号
objzx_AnswerCountENT.AnswerContent = objzx_AnswerCountENS.AnswerContent; //答案内容
objzx_AnswerCountENT.Score = objzx_AnswerCountENS.Score; //评分
objzx_AnswerCountENT.ScoreType = objzx_AnswerCountENS.ScoreType; //评分类型
objzx_AnswerCountENT.UpdUser = objzx_AnswerCountENS.UpdUser; //修改人
objzx_AnswerCountENT.UpdDate = objzx_AnswerCountENS.UpdDate; //修改日期
objzx_AnswerCountENT.UserName = objzx_AnswerCountENS.UserName; //用户名
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clszx_AnswerCountEN objzx_AnswerCountEN)
{
//检查字段不能为空(NULL)
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_AnswerCountEN.Memo, 1000, conzx_AnswerCount.Memo);
clsCheckSql.CheckFieldLen(objzx_AnswerCountEN.AnswerCountId, 10, conzx_AnswerCount.AnswerCountId);
clsCheckSql.CheckFieldLen(objzx_AnswerCountEN.DataUser, 20, conzx_AnswerCount.DataUser);
clsCheckSql.CheckFieldLen(objzx_AnswerCountEN.DataAddDate, 20, conzx_AnswerCount.DataAddDate);
clsCheckSql.CheckFieldLen(objzx_AnswerCountEN.WeekTimeRange, 100, conzx_AnswerCount.WeekTimeRange);
clsCheckSql.CheckFieldLen(objzx_AnswerCountEN.zxAnswerId, 10, conzx_AnswerCount.zxAnswerId);
clsCheckSql.CheckFieldLen(objzx_AnswerCountEN.AnswerTypeId, 2, conzx_AnswerCount.AnswerTypeId);
clsCheckSql.CheckFieldLen(objzx_AnswerCountEN.zxQuestionsId, 8, conzx_AnswerCount.zxQuestionsId);
clsCheckSql.CheckFieldLen(objzx_AnswerCountEN.GroupTextId, 8, conzx_AnswerCount.GroupTextId);
clsCheckSql.CheckFieldLen(objzx_AnswerCountEN.TextId, 8, conzx_AnswerCount.TextId);
clsCheckSql.CheckFieldLen(objzx_AnswerCountEN.IdCurrEduCls, 8, conzx_AnswerCount.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objzx_AnswerCountEN.ScoreType, 1, conzx_AnswerCount.ScoreType);
clsCheckSql.CheckFieldLen(objzx_AnswerCountEN.UpdUser, 20, conzx_AnswerCount.UpdUser);
clsCheckSql.CheckFieldLen(objzx_AnswerCountEN.UpdDate, 20, conzx_AnswerCount.UpdDate);
clsCheckSql.CheckFieldLen(objzx_AnswerCountEN.UserName, 30, conzx_AnswerCount.UserName);
//检查字段外键固定长度
 objzx_AnswerCountEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clszx_AnswerCountEN objzx_AnswerCountEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_AnswerCountEN.Memo, 1000, conzx_AnswerCount.Memo);
clsCheckSql.CheckFieldLen(objzx_AnswerCountEN.DataUser, 20, conzx_AnswerCount.DataUser);
clsCheckSql.CheckFieldLen(objzx_AnswerCountEN.DataAddDate, 20, conzx_AnswerCount.DataAddDate);
clsCheckSql.CheckFieldLen(objzx_AnswerCountEN.WeekTimeRange, 100, conzx_AnswerCount.WeekTimeRange);
clsCheckSql.CheckFieldLen(objzx_AnswerCountEN.zxAnswerId, 10, conzx_AnswerCount.zxAnswerId);
clsCheckSql.CheckFieldLen(objzx_AnswerCountEN.AnswerTypeId, 2, conzx_AnswerCount.AnswerTypeId);
clsCheckSql.CheckFieldLen(objzx_AnswerCountEN.zxQuestionsId, 8, conzx_AnswerCount.zxQuestionsId);
clsCheckSql.CheckFieldLen(objzx_AnswerCountEN.GroupTextId, 8, conzx_AnswerCount.GroupTextId);
clsCheckSql.CheckFieldLen(objzx_AnswerCountEN.TextId, 8, conzx_AnswerCount.TextId);
clsCheckSql.CheckFieldLen(objzx_AnswerCountEN.IdCurrEduCls, 8, conzx_AnswerCount.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objzx_AnswerCountEN.ScoreType, 1, conzx_AnswerCount.ScoreType);
clsCheckSql.CheckFieldLen(objzx_AnswerCountEN.UpdUser, 20, conzx_AnswerCount.UpdUser);
clsCheckSql.CheckFieldLen(objzx_AnswerCountEN.UpdDate, 20, conzx_AnswerCount.UpdDate);
clsCheckSql.CheckFieldLen(objzx_AnswerCountEN.UserName, 30, conzx_AnswerCount.UserName);
//检查外键字段长度
 objzx_AnswerCountEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clszx_AnswerCountEN objzx_AnswerCountEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_AnswerCountEN.Memo, 1000, conzx_AnswerCount.Memo);
clsCheckSql.CheckFieldLen(objzx_AnswerCountEN.AnswerCountId, 10, conzx_AnswerCount.AnswerCountId);
clsCheckSql.CheckFieldLen(objzx_AnswerCountEN.DataUser, 20, conzx_AnswerCount.DataUser);
clsCheckSql.CheckFieldLen(objzx_AnswerCountEN.DataAddDate, 20, conzx_AnswerCount.DataAddDate);
clsCheckSql.CheckFieldLen(objzx_AnswerCountEN.WeekTimeRange, 100, conzx_AnswerCount.WeekTimeRange);
clsCheckSql.CheckFieldLen(objzx_AnswerCountEN.zxAnswerId, 10, conzx_AnswerCount.zxAnswerId);
clsCheckSql.CheckFieldLen(objzx_AnswerCountEN.AnswerTypeId, 2, conzx_AnswerCount.AnswerTypeId);
clsCheckSql.CheckFieldLen(objzx_AnswerCountEN.zxQuestionsId, 8, conzx_AnswerCount.zxQuestionsId);
clsCheckSql.CheckFieldLen(objzx_AnswerCountEN.GroupTextId, 8, conzx_AnswerCount.GroupTextId);
clsCheckSql.CheckFieldLen(objzx_AnswerCountEN.TextId, 8, conzx_AnswerCount.TextId);
clsCheckSql.CheckFieldLen(objzx_AnswerCountEN.IdCurrEduCls, 8, conzx_AnswerCount.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objzx_AnswerCountEN.ScoreType, 1, conzx_AnswerCount.ScoreType);
clsCheckSql.CheckFieldLen(objzx_AnswerCountEN.UpdUser, 20, conzx_AnswerCount.UpdUser);
clsCheckSql.CheckFieldLen(objzx_AnswerCountEN.UpdDate, 20, conzx_AnswerCount.UpdDate);
clsCheckSql.CheckFieldLen(objzx_AnswerCountEN.UserName, 30, conzx_AnswerCount.UserName);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objzx_AnswerCountEN.Memo, conzx_AnswerCount.Memo);
clsCheckSql.CheckSqlInjection4Field(objzx_AnswerCountEN.AnswerCountId, conzx_AnswerCount.AnswerCountId);
clsCheckSql.CheckSqlInjection4Field(objzx_AnswerCountEN.DataUser, conzx_AnswerCount.DataUser);
clsCheckSql.CheckSqlInjection4Field(objzx_AnswerCountEN.DataAddDate, conzx_AnswerCount.DataAddDate);
clsCheckSql.CheckSqlInjection4Field(objzx_AnswerCountEN.WeekTimeRange, conzx_AnswerCount.WeekTimeRange);
clsCheckSql.CheckSqlInjection4Field(objzx_AnswerCountEN.zxAnswerId, conzx_AnswerCount.zxAnswerId);
clsCheckSql.CheckSqlInjection4Field(objzx_AnswerCountEN.AnswerTypeId, conzx_AnswerCount.AnswerTypeId);
clsCheckSql.CheckSqlInjection4Field(objzx_AnswerCountEN.zxQuestionsId, conzx_AnswerCount.zxQuestionsId);
clsCheckSql.CheckSqlInjection4Field(objzx_AnswerCountEN.GroupTextId, conzx_AnswerCount.GroupTextId);
clsCheckSql.CheckSqlInjection4Field(objzx_AnswerCountEN.TextId, conzx_AnswerCount.TextId);
clsCheckSql.CheckSqlInjection4Field(objzx_AnswerCountEN.IdCurrEduCls, conzx_AnswerCount.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objzx_AnswerCountEN.ScoreType, conzx_AnswerCount.ScoreType);
clsCheckSql.CheckSqlInjection4Field(objzx_AnswerCountEN.UpdUser, conzx_AnswerCount.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objzx_AnswerCountEN.UpdDate, conzx_AnswerCount.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objzx_AnswerCountEN.UserName, conzx_AnswerCount.UserName);
//检查外键字段长度
 objzx_AnswerCountEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--zx_AnswerCount(z中学问题讨论回答统计),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objzx_AnswerCountEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clszx_AnswerCountEN objzx_AnswerCountEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and AnswerCountId = '{0}'", objzx_AnswerCountEN.AnswerCountId);
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
 objSQL = clszx_AnswerCountDA.GetSpecSQLObj();
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
 objSQL = clszx_AnswerCountDA.GetSpecSQLObj();
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
 objSQL = clszx_AnswerCountDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clszx_AnswerCountEN._CurrTabName);
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
 objSQL = clszx_AnswerCountDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clszx_AnswerCountEN._CurrTabName, strCondition);
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
 objSQL = clszx_AnswerCountDA.GetSpecSQLObj();
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
 objSQL = clszx_AnswerCountDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}