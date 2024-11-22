
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_PaperReportDA
 表名:zx_PaperReport(01120801)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:59:29
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
 /// 中学论文汇报表(zx_PaperReport)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clszx_PaperReportDA : clsCommBase4DA
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
 return clszx_PaperReportEN._CurrTabName;
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
if (string.IsNullOrEmpty(clszx_PaperReportEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clszx_PaperReportEN._ConnectString);
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
 if (string.IsNullOrEmpty(clszx_PaperReportEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clszx_PaperReportEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strzxReportId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strzxReportId)
{
strzxReportId = strzxReportId.Replace("'", "''");
if (strzxReportId.Length > 10)
{
throw new Exception("(errid:Data000001)在表:zx_PaperReport中,检查关键字,长度不正确!(clszx_PaperReportDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strzxReportId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:zx_PaperReport中,关键字不能为空 或 null!(clszx_PaperReportDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strzxReportId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clszx_PaperReportDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clszx_PaperReportDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_PaperReportDA.GetSpecSQLObj();
strSQL = "Select * from zx_PaperReport where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_zx_PaperReport(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clszx_PaperReportDA: GetDataTable_zx_PaperReport)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_PaperReportDA.GetSpecSQLObj();
strSQL = "Select * from zx_PaperReport where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clszx_PaperReportDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_PaperReportDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clszx_PaperReportDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_PaperReportDA.GetSpecSQLObj();
strSQL = "Select * from zx_PaperReport where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clszx_PaperReportDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_PaperReportDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clszx_PaperReportDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_PaperReportDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_PaperReport where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_PaperReport where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clszx_PaperReportDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_PaperReportDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from zx_PaperReport where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clszx_PaperReportDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_PaperReportDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} zx_PaperReport.* from zx_PaperReport Left Join {1} on {2} where {3} and zx_PaperReport.zxReportId not in (Select top {5} zx_PaperReport.zxReportId from zx_PaperReport Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_PaperReport where {1} and zxReportId not in (Select top {2} zxReportId from zx_PaperReport where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_PaperReport where {1} and zxReportId not in (Select top {3} zxReportId from zx_PaperReport where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clszx_PaperReportDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_PaperReportDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} zx_PaperReport.* from zx_PaperReport Left Join {1} on {2} where {3} and zx_PaperReport.zxReportId not in (Select top {5} zx_PaperReport.zxReportId from zx_PaperReport Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_PaperReport where {1} and zxReportId not in (Select top {2} zxReportId from zx_PaperReport where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_PaperReport where {1} and zxReportId not in (Select top {3} zxReportId from zx_PaperReport where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clszx_PaperReportEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clszx_PaperReportDA:GetObjLst)", objException.Message));
}
List<clszx_PaperReportEN> arrObjLst = new List<clszx_PaperReportEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_PaperReportDA.GetSpecSQLObj();
strSQL = "Select * from zx_PaperReport where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_PaperReportEN objzx_PaperReportEN = new clszx_PaperReportEN();
try
{
objzx_PaperReportEN.zxReportId = objRow[conzx_PaperReport.zxReportId].ToString().Trim(); //汇报Id
objzx_PaperReportEN.UpdDate = objRow[conzx_PaperReport.UpdDate] == DBNull.Value ? null : objRow[conzx_PaperReport.UpdDate].ToString().Trim(); //修改日期
objzx_PaperReportEN.GroupTextId = objRow[conzx_PaperReport.GroupTextId] == DBNull.Value ? null : objRow[conzx_PaperReport.GroupTextId].ToString().Trim(); //小组Id
objzx_PaperReportEN.TextId = objRow[conzx_PaperReport.TextId] == DBNull.Value ? null : objRow[conzx_PaperReport.TextId].ToString().Trim(); //课件Id
objzx_PaperReportEN.ReportContent = objRow[conzx_PaperReport.ReportContent] == DBNull.Value ? null : objRow[conzx_PaperReport.ReportContent].ToString().Trim(); //汇报内容
objzx_PaperReportEN.IsSubmit = TransNullToBool(objRow[conzx_PaperReport.IsSubmit].ToString().Trim()); //是否提交
objzx_PaperReportEN.ReportUser = objRow[conzx_PaperReport.ReportUser] == DBNull.Value ? null : objRow[conzx_PaperReport.ReportUser].ToString().Trim(); //汇报用户
objzx_PaperReportEN.ReportDate = objRow[conzx_PaperReport.ReportDate] == DBNull.Value ? null : objRow[conzx_PaperReport.ReportDate].ToString().Trim(); //汇报日期
objzx_PaperReportEN.UpdUser = objRow[conzx_PaperReport.UpdUser] == DBNull.Value ? null : objRow[conzx_PaperReport.UpdUser].ToString().Trim(); //修改人
objzx_PaperReportEN.VersionCount = objRow[conzx_PaperReport.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_PaperReport.VersionCount].ToString().Trim()); //版本统计
objzx_PaperReportEN.OkCount = objRow[conzx_PaperReport.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_PaperReport.OkCount].ToString().Trim()); //点赞统计
objzx_PaperReportEN.AppraiseCount = objRow[conzx_PaperReport.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_PaperReport.AppraiseCount].ToString().Trim()); //评论数
objzx_PaperReportEN.Score = objRow[conzx_PaperReport.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_PaperReport.Score].ToString().Trim()); //评分
objzx_PaperReportEN.StuScore = objRow[conzx_PaperReport.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_PaperReport.StuScore].ToString().Trim()); //学生平均分
objzx_PaperReportEN.TeaScore = objRow[conzx_PaperReport.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_PaperReport.TeaScore].ToString().Trim()); //教师评分
objzx_PaperReportEN.PDFUrl = objRow[conzx_PaperReport.PDFUrl] == DBNull.Value ? null : objRow[conzx_PaperReport.PDFUrl].ToString().Trim(); //PDFUrl
objzx_PaperReportEN.PPTUrl = objRow[conzx_PaperReport.PPTUrl] == DBNull.Value ? null : objRow[conzx_PaperReport.PPTUrl].ToString().Trim(); //PPTUrl
objzx_PaperReportEN.Memo = objRow[conzx_PaperReport.Memo] == DBNull.Value ? null : objRow[conzx_PaperReport.Memo].ToString().Trim(); //备注
objzx_PaperReportEN.Month = objRow[conzx_PaperReport.Month] == DBNull.Value ? null : objRow[conzx_PaperReport.Month].ToString().Trim(); //月
objzx_PaperReportEN.Week = objRow[conzx_PaperReport.Week] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_PaperReport.Week].ToString().Trim()); //周
objzx_PaperReportEN.Year = objRow[conzx_PaperReport.Year] == DBNull.Value ? null : objRow[conzx_PaperReport.Year].ToString().Trim(); //年
objzx_PaperReportEN.IdCurrEduCls = objRow[conzx_PaperReport.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clszx_PaperReportDA: GetObjLst)", objException.Message));
}
objzx_PaperReportEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objzx_PaperReportEN);
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
public List<clszx_PaperReportEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clszx_PaperReportDA:GetObjLstByTabName)", objException.Message));
}
List<clszx_PaperReportEN> arrObjLst = new List<clszx_PaperReportEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_PaperReportDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_PaperReportEN objzx_PaperReportEN = new clszx_PaperReportEN();
try
{
objzx_PaperReportEN.zxReportId = objRow[conzx_PaperReport.zxReportId].ToString().Trim(); //汇报Id
objzx_PaperReportEN.UpdDate = objRow[conzx_PaperReport.UpdDate] == DBNull.Value ? null : objRow[conzx_PaperReport.UpdDate].ToString().Trim(); //修改日期
objzx_PaperReportEN.GroupTextId = objRow[conzx_PaperReport.GroupTextId] == DBNull.Value ? null : objRow[conzx_PaperReport.GroupTextId].ToString().Trim(); //小组Id
objzx_PaperReportEN.TextId = objRow[conzx_PaperReport.TextId] == DBNull.Value ? null : objRow[conzx_PaperReport.TextId].ToString().Trim(); //课件Id
objzx_PaperReportEN.ReportContent = objRow[conzx_PaperReport.ReportContent] == DBNull.Value ? null : objRow[conzx_PaperReport.ReportContent].ToString().Trim(); //汇报内容
objzx_PaperReportEN.IsSubmit = TransNullToBool(objRow[conzx_PaperReport.IsSubmit].ToString().Trim()); //是否提交
objzx_PaperReportEN.ReportUser = objRow[conzx_PaperReport.ReportUser] == DBNull.Value ? null : objRow[conzx_PaperReport.ReportUser].ToString().Trim(); //汇报用户
objzx_PaperReportEN.ReportDate = objRow[conzx_PaperReport.ReportDate] == DBNull.Value ? null : objRow[conzx_PaperReport.ReportDate].ToString().Trim(); //汇报日期
objzx_PaperReportEN.UpdUser = objRow[conzx_PaperReport.UpdUser] == DBNull.Value ? null : objRow[conzx_PaperReport.UpdUser].ToString().Trim(); //修改人
objzx_PaperReportEN.VersionCount = objRow[conzx_PaperReport.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_PaperReport.VersionCount].ToString().Trim()); //版本统计
objzx_PaperReportEN.OkCount = objRow[conzx_PaperReport.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_PaperReport.OkCount].ToString().Trim()); //点赞统计
objzx_PaperReportEN.AppraiseCount = objRow[conzx_PaperReport.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_PaperReport.AppraiseCount].ToString().Trim()); //评论数
objzx_PaperReportEN.Score = objRow[conzx_PaperReport.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_PaperReport.Score].ToString().Trim()); //评分
objzx_PaperReportEN.StuScore = objRow[conzx_PaperReport.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_PaperReport.StuScore].ToString().Trim()); //学生平均分
objzx_PaperReportEN.TeaScore = objRow[conzx_PaperReport.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_PaperReport.TeaScore].ToString().Trim()); //教师评分
objzx_PaperReportEN.PDFUrl = objRow[conzx_PaperReport.PDFUrl] == DBNull.Value ? null : objRow[conzx_PaperReport.PDFUrl].ToString().Trim(); //PDFUrl
objzx_PaperReportEN.PPTUrl = objRow[conzx_PaperReport.PPTUrl] == DBNull.Value ? null : objRow[conzx_PaperReport.PPTUrl].ToString().Trim(); //PPTUrl
objzx_PaperReportEN.Memo = objRow[conzx_PaperReport.Memo] == DBNull.Value ? null : objRow[conzx_PaperReport.Memo].ToString().Trim(); //备注
objzx_PaperReportEN.Month = objRow[conzx_PaperReport.Month] == DBNull.Value ? null : objRow[conzx_PaperReport.Month].ToString().Trim(); //月
objzx_PaperReportEN.Week = objRow[conzx_PaperReport.Week] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_PaperReport.Week].ToString().Trim()); //周
objzx_PaperReportEN.Year = objRow[conzx_PaperReport.Year] == DBNull.Value ? null : objRow[conzx_PaperReport.Year].ToString().Trim(); //年
objzx_PaperReportEN.IdCurrEduCls = objRow[conzx_PaperReport.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clszx_PaperReportDA: GetObjLst)", objException.Message));
}
objzx_PaperReportEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objzx_PaperReportEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objzx_PaperReportEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getzx_PaperReport(ref clszx_PaperReportEN objzx_PaperReportEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_PaperReportDA.GetSpecSQLObj();
strSQL = "Select * from zx_PaperReport where zxReportId = " + "'"+ objzx_PaperReportEN.zxReportId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objzx_PaperReportEN.zxReportId = objDT.Rows[0][conzx_PaperReport.zxReportId].ToString().Trim(); //汇报Id(字段类型:char,字段长度:10,是否可空:False)
 objzx_PaperReportEN.UpdDate = objDT.Rows[0][conzx_PaperReport.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_PaperReportEN.GroupTextId = objDT.Rows[0][conzx_PaperReport.GroupTextId].ToString().Trim(); //小组Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_PaperReportEN.TextId = objDT.Rows[0][conzx_PaperReport.TextId].ToString().Trim(); //课件Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_PaperReportEN.ReportContent = objDT.Rows[0][conzx_PaperReport.ReportContent].ToString().Trim(); //汇报内容(字段类型:varchar,字段长度:5000,是否可空:True)
 objzx_PaperReportEN.IsSubmit = TransNullToBool(objDT.Rows[0][conzx_PaperReport.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objzx_PaperReportEN.ReportUser = objDT.Rows[0][conzx_PaperReport.ReportUser].ToString().Trim(); //汇报用户(字段类型:varchar,字段长度:500,是否可空:True)
 objzx_PaperReportEN.ReportDate = objDT.Rows[0][conzx_PaperReport.ReportDate].ToString().Trim(); //汇报日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_PaperReportEN.UpdUser = objDT.Rows[0][conzx_PaperReport.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_PaperReportEN.VersionCount = TransNullToInt(objDT.Rows[0][conzx_PaperReport.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objzx_PaperReportEN.OkCount = TransNullToInt(objDT.Rows[0][conzx_PaperReport.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objzx_PaperReportEN.AppraiseCount = TransNullToInt(objDT.Rows[0][conzx_PaperReport.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objzx_PaperReportEN.Score = TransNullToFloat(objDT.Rows[0][conzx_PaperReport.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objzx_PaperReportEN.StuScore = TransNullToFloat(objDT.Rows[0][conzx_PaperReport.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objzx_PaperReportEN.TeaScore = TransNullToFloat(objDT.Rows[0][conzx_PaperReport.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objzx_PaperReportEN.PDFUrl = objDT.Rows[0][conzx_PaperReport.PDFUrl].ToString().Trim(); //PDFUrl(字段类型:varchar,字段长度:500,是否可空:True)
 objzx_PaperReportEN.PPTUrl = objDT.Rows[0][conzx_PaperReport.PPTUrl].ToString().Trim(); //PPTUrl(字段类型:varchar,字段长度:500,是否可空:True)
 objzx_PaperReportEN.Memo = objDT.Rows[0][conzx_PaperReport.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_PaperReportEN.Month = objDT.Rows[0][conzx_PaperReport.Month].ToString().Trim(); //月(字段类型:char,字段长度:2,是否可空:True)
 objzx_PaperReportEN.Week = TransNullToInt(objDT.Rows[0][conzx_PaperReport.Week].ToString().Trim()); //周(字段类型:int,字段长度:4,是否可空:True)
 objzx_PaperReportEN.Year = objDT.Rows[0][conzx_PaperReport.Year].ToString().Trim(); //年(字段类型:char,字段长度:4,是否可空:True)
 objzx_PaperReportEN.IdCurrEduCls = objDT.Rows[0][conzx_PaperReport.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clszx_PaperReportDA: Getzx_PaperReport)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strzxReportId">表关键字</param>
 /// <returns>表对象</returns>
public clszx_PaperReportEN GetObjByzxReportId(string strzxReportId)
{
CheckPrimaryKey(strzxReportId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_PaperReportDA.GetSpecSQLObj();
strSQL = "Select * from zx_PaperReport where zxReportId = " + "'"+ strzxReportId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clszx_PaperReportEN objzx_PaperReportEN = new clszx_PaperReportEN();
try
{
 objzx_PaperReportEN.zxReportId = objRow[conzx_PaperReport.zxReportId].ToString().Trim(); //汇报Id(字段类型:char,字段长度:10,是否可空:False)
 objzx_PaperReportEN.UpdDate = objRow[conzx_PaperReport.UpdDate] == DBNull.Value ? null : objRow[conzx_PaperReport.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_PaperReportEN.GroupTextId = objRow[conzx_PaperReport.GroupTextId] == DBNull.Value ? null : objRow[conzx_PaperReport.GroupTextId].ToString().Trim(); //小组Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_PaperReportEN.TextId = objRow[conzx_PaperReport.TextId] == DBNull.Value ? null : objRow[conzx_PaperReport.TextId].ToString().Trim(); //课件Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_PaperReportEN.ReportContent = objRow[conzx_PaperReport.ReportContent] == DBNull.Value ? null : objRow[conzx_PaperReport.ReportContent].ToString().Trim(); //汇报内容(字段类型:varchar,字段长度:5000,是否可空:True)
 objzx_PaperReportEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_PaperReport.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objzx_PaperReportEN.ReportUser = objRow[conzx_PaperReport.ReportUser] == DBNull.Value ? null : objRow[conzx_PaperReport.ReportUser].ToString().Trim(); //汇报用户(字段类型:varchar,字段长度:500,是否可空:True)
 objzx_PaperReportEN.ReportDate = objRow[conzx_PaperReport.ReportDate] == DBNull.Value ? null : objRow[conzx_PaperReport.ReportDate].ToString().Trim(); //汇报日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_PaperReportEN.UpdUser = objRow[conzx_PaperReport.UpdUser] == DBNull.Value ? null : objRow[conzx_PaperReport.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_PaperReportEN.VersionCount = objRow[conzx_PaperReport.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_PaperReport.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objzx_PaperReportEN.OkCount = objRow[conzx_PaperReport.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_PaperReport.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objzx_PaperReportEN.AppraiseCount = objRow[conzx_PaperReport.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_PaperReport.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objzx_PaperReportEN.Score = objRow[conzx_PaperReport.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_PaperReport.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objzx_PaperReportEN.StuScore = objRow[conzx_PaperReport.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_PaperReport.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objzx_PaperReportEN.TeaScore = objRow[conzx_PaperReport.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_PaperReport.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objzx_PaperReportEN.PDFUrl = objRow[conzx_PaperReport.PDFUrl] == DBNull.Value ? null : objRow[conzx_PaperReport.PDFUrl].ToString().Trim(); //PDFUrl(字段类型:varchar,字段长度:500,是否可空:True)
 objzx_PaperReportEN.PPTUrl = objRow[conzx_PaperReport.PPTUrl] == DBNull.Value ? null : objRow[conzx_PaperReport.PPTUrl].ToString().Trim(); //PPTUrl(字段类型:varchar,字段长度:500,是否可空:True)
 objzx_PaperReportEN.Memo = objRow[conzx_PaperReport.Memo] == DBNull.Value ? null : objRow[conzx_PaperReport.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_PaperReportEN.Month = objRow[conzx_PaperReport.Month] == DBNull.Value ? null : objRow[conzx_PaperReport.Month].ToString().Trim(); //月(字段类型:char,字段长度:2,是否可空:True)
 objzx_PaperReportEN.Week = objRow[conzx_PaperReport.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_PaperReport.Week].ToString().Trim()); //周(字段类型:int,字段长度:4,是否可空:True)
 objzx_PaperReportEN.Year = objRow[conzx_PaperReport.Year] == DBNull.Value ? null : objRow[conzx_PaperReport.Year].ToString().Trim(); //年(字段类型:char,字段长度:4,是否可空:True)
 objzx_PaperReportEN.IdCurrEduCls = objRow[conzx_PaperReport.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clszx_PaperReportDA: GetObjByzxReportId)", objException.Message));
}
return objzx_PaperReportEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clszx_PaperReportEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clszx_PaperReportDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_PaperReportDA.GetSpecSQLObj();
strSQL = "Select * from zx_PaperReport where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clszx_PaperReportEN objzx_PaperReportEN = new clszx_PaperReportEN()
{
zxReportId = objRow[conzx_PaperReport.zxReportId].ToString().Trim(), //汇报Id
UpdDate = objRow[conzx_PaperReport.UpdDate] == DBNull.Value ? null : objRow[conzx_PaperReport.UpdDate].ToString().Trim(), //修改日期
GroupTextId = objRow[conzx_PaperReport.GroupTextId] == DBNull.Value ? null : objRow[conzx_PaperReport.GroupTextId].ToString().Trim(), //小组Id
TextId = objRow[conzx_PaperReport.TextId] == DBNull.Value ? null : objRow[conzx_PaperReport.TextId].ToString().Trim(), //课件Id
ReportContent = objRow[conzx_PaperReport.ReportContent] == DBNull.Value ? null : objRow[conzx_PaperReport.ReportContent].ToString().Trim(), //汇报内容
IsSubmit = TransNullToBool(objRow[conzx_PaperReport.IsSubmit].ToString().Trim()), //是否提交
ReportUser = objRow[conzx_PaperReport.ReportUser] == DBNull.Value ? null : objRow[conzx_PaperReport.ReportUser].ToString().Trim(), //汇报用户
ReportDate = objRow[conzx_PaperReport.ReportDate] == DBNull.Value ? null : objRow[conzx_PaperReport.ReportDate].ToString().Trim(), //汇报日期
UpdUser = objRow[conzx_PaperReport.UpdUser] == DBNull.Value ? null : objRow[conzx_PaperReport.UpdUser].ToString().Trim(), //修改人
VersionCount = objRow[conzx_PaperReport.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_PaperReport.VersionCount].ToString().Trim()), //版本统计
OkCount = objRow[conzx_PaperReport.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_PaperReport.OkCount].ToString().Trim()), //点赞统计
AppraiseCount = objRow[conzx_PaperReport.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_PaperReport.AppraiseCount].ToString().Trim()), //评论数
Score = objRow[conzx_PaperReport.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_PaperReport.Score].ToString().Trim()), //评分
StuScore = objRow[conzx_PaperReport.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_PaperReport.StuScore].ToString().Trim()), //学生平均分
TeaScore = objRow[conzx_PaperReport.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_PaperReport.TeaScore].ToString().Trim()), //教师评分
PDFUrl = objRow[conzx_PaperReport.PDFUrl] == DBNull.Value ? null : objRow[conzx_PaperReport.PDFUrl].ToString().Trim(), //PDFUrl
PPTUrl = objRow[conzx_PaperReport.PPTUrl] == DBNull.Value ? null : objRow[conzx_PaperReport.PPTUrl].ToString().Trim(), //PPTUrl
Memo = objRow[conzx_PaperReport.Memo] == DBNull.Value ? null : objRow[conzx_PaperReport.Memo].ToString().Trim(), //备注
Month = objRow[conzx_PaperReport.Month] == DBNull.Value ? null : objRow[conzx_PaperReport.Month].ToString().Trim(), //月
Week = objRow[conzx_PaperReport.Week] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_PaperReport.Week].ToString().Trim()), //周
Year = objRow[conzx_PaperReport.Year] == DBNull.Value ? null : objRow[conzx_PaperReport.Year].ToString().Trim(), //年
IdCurrEduCls = objRow[conzx_PaperReport.IdCurrEduCls].ToString().Trim() //教学班流水号
};
objzx_PaperReportEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_PaperReportEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clszx_PaperReportDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clszx_PaperReportEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clszx_PaperReportEN objzx_PaperReportEN = new clszx_PaperReportEN();
try
{
objzx_PaperReportEN.zxReportId = objRow[conzx_PaperReport.zxReportId].ToString().Trim(); //汇报Id
objzx_PaperReportEN.UpdDate = objRow[conzx_PaperReport.UpdDate] == DBNull.Value ? null : objRow[conzx_PaperReport.UpdDate].ToString().Trim(); //修改日期
objzx_PaperReportEN.GroupTextId = objRow[conzx_PaperReport.GroupTextId] == DBNull.Value ? null : objRow[conzx_PaperReport.GroupTextId].ToString().Trim(); //小组Id
objzx_PaperReportEN.TextId = objRow[conzx_PaperReport.TextId] == DBNull.Value ? null : objRow[conzx_PaperReport.TextId].ToString().Trim(); //课件Id
objzx_PaperReportEN.ReportContent = objRow[conzx_PaperReport.ReportContent] == DBNull.Value ? null : objRow[conzx_PaperReport.ReportContent].ToString().Trim(); //汇报内容
objzx_PaperReportEN.IsSubmit = TransNullToBool(objRow[conzx_PaperReport.IsSubmit].ToString().Trim()); //是否提交
objzx_PaperReportEN.ReportUser = objRow[conzx_PaperReport.ReportUser] == DBNull.Value ? null : objRow[conzx_PaperReport.ReportUser].ToString().Trim(); //汇报用户
objzx_PaperReportEN.ReportDate = objRow[conzx_PaperReport.ReportDate] == DBNull.Value ? null : objRow[conzx_PaperReport.ReportDate].ToString().Trim(); //汇报日期
objzx_PaperReportEN.UpdUser = objRow[conzx_PaperReport.UpdUser] == DBNull.Value ? null : objRow[conzx_PaperReport.UpdUser].ToString().Trim(); //修改人
objzx_PaperReportEN.VersionCount = objRow[conzx_PaperReport.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_PaperReport.VersionCount].ToString().Trim()); //版本统计
objzx_PaperReportEN.OkCount = objRow[conzx_PaperReport.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_PaperReport.OkCount].ToString().Trim()); //点赞统计
objzx_PaperReportEN.AppraiseCount = objRow[conzx_PaperReport.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_PaperReport.AppraiseCount].ToString().Trim()); //评论数
objzx_PaperReportEN.Score = objRow[conzx_PaperReport.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_PaperReport.Score].ToString().Trim()); //评分
objzx_PaperReportEN.StuScore = objRow[conzx_PaperReport.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_PaperReport.StuScore].ToString().Trim()); //学生平均分
objzx_PaperReportEN.TeaScore = objRow[conzx_PaperReport.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_PaperReport.TeaScore].ToString().Trim()); //教师评分
objzx_PaperReportEN.PDFUrl = objRow[conzx_PaperReport.PDFUrl] == DBNull.Value ? null : objRow[conzx_PaperReport.PDFUrl].ToString().Trim(); //PDFUrl
objzx_PaperReportEN.PPTUrl = objRow[conzx_PaperReport.PPTUrl] == DBNull.Value ? null : objRow[conzx_PaperReport.PPTUrl].ToString().Trim(); //PPTUrl
objzx_PaperReportEN.Memo = objRow[conzx_PaperReport.Memo] == DBNull.Value ? null : objRow[conzx_PaperReport.Memo].ToString().Trim(); //备注
objzx_PaperReportEN.Month = objRow[conzx_PaperReport.Month] == DBNull.Value ? null : objRow[conzx_PaperReport.Month].ToString().Trim(); //月
objzx_PaperReportEN.Week = objRow[conzx_PaperReport.Week] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_PaperReport.Week].ToString().Trim()); //周
objzx_PaperReportEN.Year = objRow[conzx_PaperReport.Year] == DBNull.Value ? null : objRow[conzx_PaperReport.Year].ToString().Trim(); //年
objzx_PaperReportEN.IdCurrEduCls = objRow[conzx_PaperReport.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clszx_PaperReportDA: GetObjByDataRowzx_PaperReport)", objException.Message));
}
objzx_PaperReportEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_PaperReportEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clszx_PaperReportEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clszx_PaperReportEN objzx_PaperReportEN = new clszx_PaperReportEN();
try
{
objzx_PaperReportEN.zxReportId = objRow[conzx_PaperReport.zxReportId].ToString().Trim(); //汇报Id
objzx_PaperReportEN.UpdDate = objRow[conzx_PaperReport.UpdDate] == DBNull.Value ? null : objRow[conzx_PaperReport.UpdDate].ToString().Trim(); //修改日期
objzx_PaperReportEN.GroupTextId = objRow[conzx_PaperReport.GroupTextId] == DBNull.Value ? null : objRow[conzx_PaperReport.GroupTextId].ToString().Trim(); //小组Id
objzx_PaperReportEN.TextId = objRow[conzx_PaperReport.TextId] == DBNull.Value ? null : objRow[conzx_PaperReport.TextId].ToString().Trim(); //课件Id
objzx_PaperReportEN.ReportContent = objRow[conzx_PaperReport.ReportContent] == DBNull.Value ? null : objRow[conzx_PaperReport.ReportContent].ToString().Trim(); //汇报内容
objzx_PaperReportEN.IsSubmit = TransNullToBool(objRow[conzx_PaperReport.IsSubmit].ToString().Trim()); //是否提交
objzx_PaperReportEN.ReportUser = objRow[conzx_PaperReport.ReportUser] == DBNull.Value ? null : objRow[conzx_PaperReport.ReportUser].ToString().Trim(); //汇报用户
objzx_PaperReportEN.ReportDate = objRow[conzx_PaperReport.ReportDate] == DBNull.Value ? null : objRow[conzx_PaperReport.ReportDate].ToString().Trim(); //汇报日期
objzx_PaperReportEN.UpdUser = objRow[conzx_PaperReport.UpdUser] == DBNull.Value ? null : objRow[conzx_PaperReport.UpdUser].ToString().Trim(); //修改人
objzx_PaperReportEN.VersionCount = objRow[conzx_PaperReport.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_PaperReport.VersionCount].ToString().Trim()); //版本统计
objzx_PaperReportEN.OkCount = objRow[conzx_PaperReport.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_PaperReport.OkCount].ToString().Trim()); //点赞统计
objzx_PaperReportEN.AppraiseCount = objRow[conzx_PaperReport.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_PaperReport.AppraiseCount].ToString().Trim()); //评论数
objzx_PaperReportEN.Score = objRow[conzx_PaperReport.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_PaperReport.Score].ToString().Trim()); //评分
objzx_PaperReportEN.StuScore = objRow[conzx_PaperReport.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_PaperReport.StuScore].ToString().Trim()); //学生平均分
objzx_PaperReportEN.TeaScore = objRow[conzx_PaperReport.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_PaperReport.TeaScore].ToString().Trim()); //教师评分
objzx_PaperReportEN.PDFUrl = objRow[conzx_PaperReport.PDFUrl] == DBNull.Value ? null : objRow[conzx_PaperReport.PDFUrl].ToString().Trim(); //PDFUrl
objzx_PaperReportEN.PPTUrl = objRow[conzx_PaperReport.PPTUrl] == DBNull.Value ? null : objRow[conzx_PaperReport.PPTUrl].ToString().Trim(); //PPTUrl
objzx_PaperReportEN.Memo = objRow[conzx_PaperReport.Memo] == DBNull.Value ? null : objRow[conzx_PaperReport.Memo].ToString().Trim(); //备注
objzx_PaperReportEN.Month = objRow[conzx_PaperReport.Month] == DBNull.Value ? null : objRow[conzx_PaperReport.Month].ToString().Trim(); //月
objzx_PaperReportEN.Week = objRow[conzx_PaperReport.Week] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_PaperReport.Week].ToString().Trim()); //周
objzx_PaperReportEN.Year = objRow[conzx_PaperReport.Year] == DBNull.Value ? null : objRow[conzx_PaperReport.Year].ToString().Trim(); //年
objzx_PaperReportEN.IdCurrEduCls = objRow[conzx_PaperReport.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clszx_PaperReportDA: GetObjByDataRow)", objException.Message));
}
objzx_PaperReportEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_PaperReportEN;
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
objSQL = clszx_PaperReportDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clszx_PaperReportEN._CurrTabName, conzx_PaperReport.zxReportId, 10, "");
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
objSQL = clszx_PaperReportDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clszx_PaperReportEN._CurrTabName, conzx_PaperReport.zxReportId, 10, strPrefix);
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
 objSQL = clszx_PaperReportDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select zxReportId from zx_PaperReport where " + strCondition;
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
 objSQL = clszx_PaperReportDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select zxReportId from zx_PaperReport where " + strCondition;
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
 /// <param name = "strzxReportId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strzxReportId)
{
CheckPrimaryKey(strzxReportId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_PaperReportDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("zx_PaperReport", "zxReportId = " + "'"+ strzxReportId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clszx_PaperReportDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_PaperReportDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("zx_PaperReport", strCondition))
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
objSQL = clszx_PaperReportDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("zx_PaperReport");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clszx_PaperReportEN objzx_PaperReportEN)
 {
 if (objzx_PaperReportEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_PaperReportEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_PaperReportDA.GetSpecSQLObj();
strSQL = "Select * from zx_PaperReport where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "zx_PaperReport");
objRow = objDS.Tables["zx_PaperReport"].NewRow();
objRow[conzx_PaperReport.zxReportId] = objzx_PaperReportEN.zxReportId; //汇报Id
 if (objzx_PaperReportEN.UpdDate !=  "")
 {
objRow[conzx_PaperReport.UpdDate] = objzx_PaperReportEN.UpdDate; //修改日期
 }
 if (objzx_PaperReportEN.GroupTextId !=  "")
 {
objRow[conzx_PaperReport.GroupTextId] = objzx_PaperReportEN.GroupTextId; //小组Id
 }
 if (objzx_PaperReportEN.TextId !=  "")
 {
objRow[conzx_PaperReport.TextId] = objzx_PaperReportEN.TextId; //课件Id
 }
 if (objzx_PaperReportEN.ReportContent !=  "")
 {
objRow[conzx_PaperReport.ReportContent] = objzx_PaperReportEN.ReportContent; //汇报内容
 }
objRow[conzx_PaperReport.IsSubmit] = objzx_PaperReportEN.IsSubmit; //是否提交
 if (objzx_PaperReportEN.ReportUser !=  "")
 {
objRow[conzx_PaperReport.ReportUser] = objzx_PaperReportEN.ReportUser; //汇报用户
 }
 if (objzx_PaperReportEN.ReportDate !=  "")
 {
objRow[conzx_PaperReport.ReportDate] = objzx_PaperReportEN.ReportDate; //汇报日期
 }
 if (objzx_PaperReportEN.UpdUser !=  "")
 {
objRow[conzx_PaperReport.UpdUser] = objzx_PaperReportEN.UpdUser; //修改人
 }
objRow[conzx_PaperReport.VersionCount] = objzx_PaperReportEN.VersionCount; //版本统计
objRow[conzx_PaperReport.OkCount] = objzx_PaperReportEN.OkCount; //点赞统计
objRow[conzx_PaperReport.AppraiseCount] = objzx_PaperReportEN.AppraiseCount; //评论数
objRow[conzx_PaperReport.Score] = objzx_PaperReportEN.Score; //评分
objRow[conzx_PaperReport.StuScore] = objzx_PaperReportEN.StuScore; //学生平均分
objRow[conzx_PaperReport.TeaScore] = objzx_PaperReportEN.TeaScore; //教师评分
 if (objzx_PaperReportEN.PDFUrl !=  "")
 {
objRow[conzx_PaperReport.PDFUrl] = objzx_PaperReportEN.PDFUrl; //PDFUrl
 }
 if (objzx_PaperReportEN.PPTUrl !=  "")
 {
objRow[conzx_PaperReport.PPTUrl] = objzx_PaperReportEN.PPTUrl; //PPTUrl
 }
 if (objzx_PaperReportEN.Memo !=  "")
 {
objRow[conzx_PaperReport.Memo] = objzx_PaperReportEN.Memo; //备注
 }
 if (objzx_PaperReportEN.Month !=  "")
 {
objRow[conzx_PaperReport.Month] = objzx_PaperReportEN.Month; //月
 }
objRow[conzx_PaperReport.Week] = objzx_PaperReportEN.Week; //周
 if (objzx_PaperReportEN.Year !=  "")
 {
objRow[conzx_PaperReport.Year] = objzx_PaperReportEN.Year; //年
 }
objRow[conzx_PaperReport.IdCurrEduCls] = objzx_PaperReportEN.IdCurrEduCls; //教学班流水号
objDS.Tables[clszx_PaperReportEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clszx_PaperReportEN._CurrTabName);
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
 /// <param name = "objzx_PaperReportEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clszx_PaperReportEN objzx_PaperReportEN)
{
 if (objzx_PaperReportEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_PaperReportEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_PaperReportEN.zxReportId !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.zxReportId);
 var strzxReportId = objzx_PaperReportEN.zxReportId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxReportId + "'");
 }
 
 if (objzx_PaperReportEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.UpdDate);
 var strUpdDate = objzx_PaperReportEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_PaperReportEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.GroupTextId);
 var strGroupTextId = objzx_PaperReportEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 
 if (objzx_PaperReportEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.TextId);
 var strTextId = objzx_PaperReportEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 if (objzx_PaperReportEN.ReportContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.ReportContent);
 var strReportContent = objzx_PaperReportEN.ReportContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReportContent + "'");
 }
 
 arrFieldListForInsert.Add(conzx_PaperReport.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_PaperReportEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_PaperReportEN.ReportUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.ReportUser);
 var strReportUser = objzx_PaperReportEN.ReportUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReportUser + "'");
 }
 
 if (objzx_PaperReportEN.ReportDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.ReportDate);
 var strReportDate = objzx_PaperReportEN.ReportDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReportDate + "'");
 }
 
 if (objzx_PaperReportEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.UpdUser);
 var strUpdUser = objzx_PaperReportEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_PaperReportEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.VersionCount);
 arrValueListForInsert.Add(objzx_PaperReportEN.VersionCount.ToString());
 }
 
 if (objzx_PaperReportEN.OkCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.OkCount);
 arrValueListForInsert.Add(objzx_PaperReportEN.OkCount.ToString());
 }
 
 if (objzx_PaperReportEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.AppraiseCount);
 arrValueListForInsert.Add(objzx_PaperReportEN.AppraiseCount.ToString());
 }
 
 if (objzx_PaperReportEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.Score);
 arrValueListForInsert.Add(objzx_PaperReportEN.Score.ToString());
 }
 
 if (objzx_PaperReportEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.StuScore);
 arrValueListForInsert.Add(objzx_PaperReportEN.StuScore.ToString());
 }
 
 if (objzx_PaperReportEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.TeaScore);
 arrValueListForInsert.Add(objzx_PaperReportEN.TeaScore.ToString());
 }
 
 if (objzx_PaperReportEN.PDFUrl !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.PDFUrl);
 var strPDFUrl = objzx_PaperReportEN.PDFUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPDFUrl + "'");
 }
 
 if (objzx_PaperReportEN.PPTUrl !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.PPTUrl);
 var strPPTUrl = objzx_PaperReportEN.PPTUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPPTUrl + "'");
 }
 
 if (objzx_PaperReportEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.Memo);
 var strMemo = objzx_PaperReportEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_PaperReportEN.Month !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.Month);
 var strMonth = objzx_PaperReportEN.Month.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMonth + "'");
 }
 
 if (objzx_PaperReportEN.Week !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.Week);
 arrValueListForInsert.Add(objzx_PaperReportEN.Week.ToString());
 }
 
 if (objzx_PaperReportEN.Year !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.Year);
 var strYear = objzx_PaperReportEN.Year.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strYear + "'");
 }
 
 if (objzx_PaperReportEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.IdCurrEduCls);
 var strIdCurrEduCls = objzx_PaperReportEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_PaperReport");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_PaperReportDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objzx_PaperReportEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clszx_PaperReportEN objzx_PaperReportEN)
{
 if (objzx_PaperReportEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_PaperReportEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_PaperReportEN.zxReportId !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.zxReportId);
 var strzxReportId = objzx_PaperReportEN.zxReportId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxReportId + "'");
 }
 
 if (objzx_PaperReportEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.UpdDate);
 var strUpdDate = objzx_PaperReportEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_PaperReportEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.GroupTextId);
 var strGroupTextId = objzx_PaperReportEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 
 if (objzx_PaperReportEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.TextId);
 var strTextId = objzx_PaperReportEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 if (objzx_PaperReportEN.ReportContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.ReportContent);
 var strReportContent = objzx_PaperReportEN.ReportContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReportContent + "'");
 }
 
 arrFieldListForInsert.Add(conzx_PaperReport.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_PaperReportEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_PaperReportEN.ReportUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.ReportUser);
 var strReportUser = objzx_PaperReportEN.ReportUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReportUser + "'");
 }
 
 if (objzx_PaperReportEN.ReportDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.ReportDate);
 var strReportDate = objzx_PaperReportEN.ReportDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReportDate + "'");
 }
 
 if (objzx_PaperReportEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.UpdUser);
 var strUpdUser = objzx_PaperReportEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_PaperReportEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.VersionCount);
 arrValueListForInsert.Add(objzx_PaperReportEN.VersionCount.ToString());
 }
 
 if (objzx_PaperReportEN.OkCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.OkCount);
 arrValueListForInsert.Add(objzx_PaperReportEN.OkCount.ToString());
 }
 
 if (objzx_PaperReportEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.AppraiseCount);
 arrValueListForInsert.Add(objzx_PaperReportEN.AppraiseCount.ToString());
 }
 
 if (objzx_PaperReportEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.Score);
 arrValueListForInsert.Add(objzx_PaperReportEN.Score.ToString());
 }
 
 if (objzx_PaperReportEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.StuScore);
 arrValueListForInsert.Add(objzx_PaperReportEN.StuScore.ToString());
 }
 
 if (objzx_PaperReportEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.TeaScore);
 arrValueListForInsert.Add(objzx_PaperReportEN.TeaScore.ToString());
 }
 
 if (objzx_PaperReportEN.PDFUrl !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.PDFUrl);
 var strPDFUrl = objzx_PaperReportEN.PDFUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPDFUrl + "'");
 }
 
 if (objzx_PaperReportEN.PPTUrl !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.PPTUrl);
 var strPPTUrl = objzx_PaperReportEN.PPTUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPPTUrl + "'");
 }
 
 if (objzx_PaperReportEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.Memo);
 var strMemo = objzx_PaperReportEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_PaperReportEN.Month !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.Month);
 var strMonth = objzx_PaperReportEN.Month.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMonth + "'");
 }
 
 if (objzx_PaperReportEN.Week !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.Week);
 arrValueListForInsert.Add(objzx_PaperReportEN.Week.ToString());
 }
 
 if (objzx_PaperReportEN.Year !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.Year);
 var strYear = objzx_PaperReportEN.Year.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strYear + "'");
 }
 
 if (objzx_PaperReportEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.IdCurrEduCls);
 var strIdCurrEduCls = objzx_PaperReportEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_PaperReport");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_PaperReportDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objzx_PaperReportEN.zxReportId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objzx_PaperReportEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clszx_PaperReportEN objzx_PaperReportEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objzx_PaperReportEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_PaperReportEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_PaperReportEN.zxReportId !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.zxReportId);
 var strzxReportId = objzx_PaperReportEN.zxReportId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxReportId + "'");
 }
 
 if (objzx_PaperReportEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.UpdDate);
 var strUpdDate = objzx_PaperReportEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_PaperReportEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.GroupTextId);
 var strGroupTextId = objzx_PaperReportEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 
 if (objzx_PaperReportEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.TextId);
 var strTextId = objzx_PaperReportEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 if (objzx_PaperReportEN.ReportContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.ReportContent);
 var strReportContent = objzx_PaperReportEN.ReportContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReportContent + "'");
 }
 
 arrFieldListForInsert.Add(conzx_PaperReport.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_PaperReportEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_PaperReportEN.ReportUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.ReportUser);
 var strReportUser = objzx_PaperReportEN.ReportUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReportUser + "'");
 }
 
 if (objzx_PaperReportEN.ReportDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.ReportDate);
 var strReportDate = objzx_PaperReportEN.ReportDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReportDate + "'");
 }
 
 if (objzx_PaperReportEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.UpdUser);
 var strUpdUser = objzx_PaperReportEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_PaperReportEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.VersionCount);
 arrValueListForInsert.Add(objzx_PaperReportEN.VersionCount.ToString());
 }
 
 if (objzx_PaperReportEN.OkCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.OkCount);
 arrValueListForInsert.Add(objzx_PaperReportEN.OkCount.ToString());
 }
 
 if (objzx_PaperReportEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.AppraiseCount);
 arrValueListForInsert.Add(objzx_PaperReportEN.AppraiseCount.ToString());
 }
 
 if (objzx_PaperReportEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.Score);
 arrValueListForInsert.Add(objzx_PaperReportEN.Score.ToString());
 }
 
 if (objzx_PaperReportEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.StuScore);
 arrValueListForInsert.Add(objzx_PaperReportEN.StuScore.ToString());
 }
 
 if (objzx_PaperReportEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.TeaScore);
 arrValueListForInsert.Add(objzx_PaperReportEN.TeaScore.ToString());
 }
 
 if (objzx_PaperReportEN.PDFUrl !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.PDFUrl);
 var strPDFUrl = objzx_PaperReportEN.PDFUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPDFUrl + "'");
 }
 
 if (objzx_PaperReportEN.PPTUrl !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.PPTUrl);
 var strPPTUrl = objzx_PaperReportEN.PPTUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPPTUrl + "'");
 }
 
 if (objzx_PaperReportEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.Memo);
 var strMemo = objzx_PaperReportEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_PaperReportEN.Month !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.Month);
 var strMonth = objzx_PaperReportEN.Month.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMonth + "'");
 }
 
 if (objzx_PaperReportEN.Week !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.Week);
 arrValueListForInsert.Add(objzx_PaperReportEN.Week.ToString());
 }
 
 if (objzx_PaperReportEN.Year !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.Year);
 var strYear = objzx_PaperReportEN.Year.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strYear + "'");
 }
 
 if (objzx_PaperReportEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.IdCurrEduCls);
 var strIdCurrEduCls = objzx_PaperReportEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_PaperReport");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_PaperReportDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objzx_PaperReportEN.zxReportId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objzx_PaperReportEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clszx_PaperReportEN objzx_PaperReportEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objzx_PaperReportEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_PaperReportEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_PaperReportEN.zxReportId !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.zxReportId);
 var strzxReportId = objzx_PaperReportEN.zxReportId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxReportId + "'");
 }
 
 if (objzx_PaperReportEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.UpdDate);
 var strUpdDate = objzx_PaperReportEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_PaperReportEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.GroupTextId);
 var strGroupTextId = objzx_PaperReportEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 
 if (objzx_PaperReportEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.TextId);
 var strTextId = objzx_PaperReportEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 if (objzx_PaperReportEN.ReportContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.ReportContent);
 var strReportContent = objzx_PaperReportEN.ReportContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReportContent + "'");
 }
 
 arrFieldListForInsert.Add(conzx_PaperReport.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_PaperReportEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_PaperReportEN.ReportUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.ReportUser);
 var strReportUser = objzx_PaperReportEN.ReportUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReportUser + "'");
 }
 
 if (objzx_PaperReportEN.ReportDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.ReportDate);
 var strReportDate = objzx_PaperReportEN.ReportDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReportDate + "'");
 }
 
 if (objzx_PaperReportEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.UpdUser);
 var strUpdUser = objzx_PaperReportEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_PaperReportEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.VersionCount);
 arrValueListForInsert.Add(objzx_PaperReportEN.VersionCount.ToString());
 }
 
 if (objzx_PaperReportEN.OkCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.OkCount);
 arrValueListForInsert.Add(objzx_PaperReportEN.OkCount.ToString());
 }
 
 if (objzx_PaperReportEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.AppraiseCount);
 arrValueListForInsert.Add(objzx_PaperReportEN.AppraiseCount.ToString());
 }
 
 if (objzx_PaperReportEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.Score);
 arrValueListForInsert.Add(objzx_PaperReportEN.Score.ToString());
 }
 
 if (objzx_PaperReportEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.StuScore);
 arrValueListForInsert.Add(objzx_PaperReportEN.StuScore.ToString());
 }
 
 if (objzx_PaperReportEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.TeaScore);
 arrValueListForInsert.Add(objzx_PaperReportEN.TeaScore.ToString());
 }
 
 if (objzx_PaperReportEN.PDFUrl !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.PDFUrl);
 var strPDFUrl = objzx_PaperReportEN.PDFUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPDFUrl + "'");
 }
 
 if (objzx_PaperReportEN.PPTUrl !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.PPTUrl);
 var strPPTUrl = objzx_PaperReportEN.PPTUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPPTUrl + "'");
 }
 
 if (objzx_PaperReportEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.Memo);
 var strMemo = objzx_PaperReportEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_PaperReportEN.Month !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.Month);
 var strMonth = objzx_PaperReportEN.Month.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMonth + "'");
 }
 
 if (objzx_PaperReportEN.Week !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.Week);
 arrValueListForInsert.Add(objzx_PaperReportEN.Week.ToString());
 }
 
 if (objzx_PaperReportEN.Year !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.Year);
 var strYear = objzx_PaperReportEN.Year.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strYear + "'");
 }
 
 if (objzx_PaperReportEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperReport.IdCurrEduCls);
 var strIdCurrEduCls = objzx_PaperReportEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_PaperReport");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_PaperReportDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewzx_PaperReports(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_PaperReportDA.GetSpecSQLObj();
strSQL = "Select * from zx_PaperReport where zxReportId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "zx_PaperReport");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strzxReportId = oRow[conzx_PaperReport.zxReportId].ToString().Trim();
if (IsExist(strzxReportId))
{
 string strResult = "关键字变量值为:" + string.Format("zxReportId = {0}", strzxReportId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clszx_PaperReportEN._CurrTabName ].NewRow();
objRow[conzx_PaperReport.zxReportId] = oRow[conzx_PaperReport.zxReportId].ToString().Trim(); //汇报Id
objRow[conzx_PaperReport.UpdDate] = oRow[conzx_PaperReport.UpdDate].ToString().Trim(); //修改日期
objRow[conzx_PaperReport.GroupTextId] = oRow[conzx_PaperReport.GroupTextId].ToString().Trim(); //小组Id
objRow[conzx_PaperReport.TextId] = oRow[conzx_PaperReport.TextId].ToString().Trim(); //课件Id
objRow[conzx_PaperReport.ReportContent] = oRow[conzx_PaperReport.ReportContent].ToString().Trim(); //汇报内容
objRow[conzx_PaperReport.IsSubmit] = oRow[conzx_PaperReport.IsSubmit].ToString().Trim(); //是否提交
objRow[conzx_PaperReport.ReportUser] = oRow[conzx_PaperReport.ReportUser].ToString().Trim(); //汇报用户
objRow[conzx_PaperReport.ReportDate] = oRow[conzx_PaperReport.ReportDate].ToString().Trim(); //汇报日期
objRow[conzx_PaperReport.UpdUser] = oRow[conzx_PaperReport.UpdUser].ToString().Trim(); //修改人
objRow[conzx_PaperReport.VersionCount] = oRow[conzx_PaperReport.VersionCount].ToString().Trim(); //版本统计
objRow[conzx_PaperReport.OkCount] = oRow[conzx_PaperReport.OkCount].ToString().Trim(); //点赞统计
objRow[conzx_PaperReport.AppraiseCount] = oRow[conzx_PaperReport.AppraiseCount].ToString().Trim(); //评论数
objRow[conzx_PaperReport.Score] = oRow[conzx_PaperReport.Score].ToString().Trim(); //评分
objRow[conzx_PaperReport.StuScore] = oRow[conzx_PaperReport.StuScore].ToString().Trim(); //学生平均分
objRow[conzx_PaperReport.TeaScore] = oRow[conzx_PaperReport.TeaScore].ToString().Trim(); //教师评分
objRow[conzx_PaperReport.PDFUrl] = oRow[conzx_PaperReport.PDFUrl].ToString().Trim(); //PDFUrl
objRow[conzx_PaperReport.PPTUrl] = oRow[conzx_PaperReport.PPTUrl].ToString().Trim(); //PPTUrl
objRow[conzx_PaperReport.Memo] = oRow[conzx_PaperReport.Memo].ToString().Trim(); //备注
objRow[conzx_PaperReport.Month] = oRow[conzx_PaperReport.Month].ToString().Trim(); //月
objRow[conzx_PaperReport.Week] = oRow[conzx_PaperReport.Week].ToString().Trim(); //周
objRow[conzx_PaperReport.Year] = oRow[conzx_PaperReport.Year].ToString().Trim(); //年
objRow[conzx_PaperReport.IdCurrEduCls] = oRow[conzx_PaperReport.IdCurrEduCls].ToString().Trim(); //教学班流水号
 objDS.Tables[clszx_PaperReportEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clszx_PaperReportEN._CurrTabName);
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
 /// <param name = "objzx_PaperReportEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clszx_PaperReportEN objzx_PaperReportEN)
{
 if (objzx_PaperReportEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_PaperReportEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_PaperReportDA.GetSpecSQLObj();
strSQL = "Select * from zx_PaperReport where zxReportId = " + "'"+ objzx_PaperReportEN.zxReportId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clszx_PaperReportEN._CurrTabName);
if (objDS.Tables[clszx_PaperReportEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:zxReportId = " + "'"+ objzx_PaperReportEN.zxReportId+"'");
return false;
}
objRow = objDS.Tables[clszx_PaperReportEN._CurrTabName].Rows[0];
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.zxReportId))
 {
objRow[conzx_PaperReport.zxReportId] = objzx_PaperReportEN.zxReportId; //汇报Id
 }
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.UpdDate))
 {
objRow[conzx_PaperReport.UpdDate] = objzx_PaperReportEN.UpdDate; //修改日期
 }
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.GroupTextId))
 {
objRow[conzx_PaperReport.GroupTextId] = objzx_PaperReportEN.GroupTextId; //小组Id
 }
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.TextId))
 {
objRow[conzx_PaperReport.TextId] = objzx_PaperReportEN.TextId; //课件Id
 }
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.ReportContent))
 {
objRow[conzx_PaperReport.ReportContent] = objzx_PaperReportEN.ReportContent; //汇报内容
 }
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.IsSubmit))
 {
objRow[conzx_PaperReport.IsSubmit] = objzx_PaperReportEN.IsSubmit; //是否提交
 }
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.ReportUser))
 {
objRow[conzx_PaperReport.ReportUser] = objzx_PaperReportEN.ReportUser; //汇报用户
 }
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.ReportDate))
 {
objRow[conzx_PaperReport.ReportDate] = objzx_PaperReportEN.ReportDate; //汇报日期
 }
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.UpdUser))
 {
objRow[conzx_PaperReport.UpdUser] = objzx_PaperReportEN.UpdUser; //修改人
 }
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.VersionCount))
 {
objRow[conzx_PaperReport.VersionCount] = objzx_PaperReportEN.VersionCount; //版本统计
 }
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.OkCount))
 {
objRow[conzx_PaperReport.OkCount] = objzx_PaperReportEN.OkCount; //点赞统计
 }
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.AppraiseCount))
 {
objRow[conzx_PaperReport.AppraiseCount] = objzx_PaperReportEN.AppraiseCount; //评论数
 }
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.Score))
 {
objRow[conzx_PaperReport.Score] = objzx_PaperReportEN.Score; //评分
 }
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.StuScore))
 {
objRow[conzx_PaperReport.StuScore] = objzx_PaperReportEN.StuScore; //学生平均分
 }
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.TeaScore))
 {
objRow[conzx_PaperReport.TeaScore] = objzx_PaperReportEN.TeaScore; //教师评分
 }
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.PDFUrl))
 {
objRow[conzx_PaperReport.PDFUrl] = objzx_PaperReportEN.PDFUrl; //PDFUrl
 }
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.PPTUrl))
 {
objRow[conzx_PaperReport.PPTUrl] = objzx_PaperReportEN.PPTUrl; //PPTUrl
 }
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.Memo))
 {
objRow[conzx_PaperReport.Memo] = objzx_PaperReportEN.Memo; //备注
 }
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.Month))
 {
objRow[conzx_PaperReport.Month] = objzx_PaperReportEN.Month; //月
 }
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.Week))
 {
objRow[conzx_PaperReport.Week] = objzx_PaperReportEN.Week; //周
 }
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.Year))
 {
objRow[conzx_PaperReport.Year] = objzx_PaperReportEN.Year; //年
 }
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.IdCurrEduCls))
 {
objRow[conzx_PaperReport.IdCurrEduCls] = objzx_PaperReportEN.IdCurrEduCls; //教学班流水号
 }
try
{
objDA.Update(objDS, clszx_PaperReportEN._CurrTabName);
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
 /// <param name = "objzx_PaperReportEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clszx_PaperReportEN objzx_PaperReportEN)
{
 if (objzx_PaperReportEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_PaperReportEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_PaperReportDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update zx_PaperReport Set ");
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.UpdDate))
 {
 if (objzx_PaperReportEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_PaperReportEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conzx_PaperReport.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_PaperReport.UpdDate); //修改日期
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.GroupTextId))
 {
 if (objzx_PaperReportEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_PaperReportEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGroupTextId, conzx_PaperReport.GroupTextId); //小组Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_PaperReport.GroupTextId); //小组Id
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.TextId))
 {
 if (objzx_PaperReportEN.TextId !=  null)
 {
 var strTextId = objzx_PaperReportEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTextId, conzx_PaperReport.TextId); //课件Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_PaperReport.TextId); //课件Id
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.ReportContent))
 {
 if (objzx_PaperReportEN.ReportContent !=  null)
 {
 var strReportContent = objzx_PaperReportEN.ReportContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReportContent, conzx_PaperReport.ReportContent); //汇报内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_PaperReport.ReportContent); //汇报内容
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objzx_PaperReportEN.IsSubmit == true?"1":"0", conzx_PaperReport.IsSubmit); //是否提交
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.ReportUser))
 {
 if (objzx_PaperReportEN.ReportUser !=  null)
 {
 var strReportUser = objzx_PaperReportEN.ReportUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReportUser, conzx_PaperReport.ReportUser); //汇报用户
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_PaperReport.ReportUser); //汇报用户
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.ReportDate))
 {
 if (objzx_PaperReportEN.ReportDate !=  null)
 {
 var strReportDate = objzx_PaperReportEN.ReportDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReportDate, conzx_PaperReport.ReportDate); //汇报日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_PaperReport.ReportDate); //汇报日期
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.UpdUser))
 {
 if (objzx_PaperReportEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_PaperReportEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conzx_PaperReport.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_PaperReport.UpdUser); //修改人
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.VersionCount))
 {
 if (objzx_PaperReportEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_PaperReportEN.VersionCount, conzx_PaperReport.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_PaperReport.VersionCount); //版本统计
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.OkCount))
 {
 if (objzx_PaperReportEN.OkCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_PaperReportEN.OkCount, conzx_PaperReport.OkCount); //点赞统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_PaperReport.OkCount); //点赞统计
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.AppraiseCount))
 {
 if (objzx_PaperReportEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_PaperReportEN.AppraiseCount, conzx_PaperReport.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_PaperReport.AppraiseCount); //评论数
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.Score))
 {
 if (objzx_PaperReportEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_PaperReportEN.Score, conzx_PaperReport.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_PaperReport.Score); //评分
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.StuScore))
 {
 if (objzx_PaperReportEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_PaperReportEN.StuScore, conzx_PaperReport.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_PaperReport.StuScore); //学生平均分
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.TeaScore))
 {
 if (objzx_PaperReportEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_PaperReportEN.TeaScore, conzx_PaperReport.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_PaperReport.TeaScore); //教师评分
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.PDFUrl))
 {
 if (objzx_PaperReportEN.PDFUrl !=  null)
 {
 var strPDFUrl = objzx_PaperReportEN.PDFUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPDFUrl, conzx_PaperReport.PDFUrl); //PDFUrl
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_PaperReport.PDFUrl); //PDFUrl
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.PPTUrl))
 {
 if (objzx_PaperReportEN.PPTUrl !=  null)
 {
 var strPPTUrl = objzx_PaperReportEN.PPTUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPPTUrl, conzx_PaperReport.PPTUrl); //PPTUrl
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_PaperReport.PPTUrl); //PPTUrl
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.Memo))
 {
 if (objzx_PaperReportEN.Memo !=  null)
 {
 var strMemo = objzx_PaperReportEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conzx_PaperReport.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_PaperReport.Memo); //备注
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.Month))
 {
 if (objzx_PaperReportEN.Month !=  null)
 {
 var strMonth = objzx_PaperReportEN.Month.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMonth, conzx_PaperReport.Month); //月
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_PaperReport.Month); //月
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.Week))
 {
 if (objzx_PaperReportEN.Week !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_PaperReportEN.Week, conzx_PaperReport.Week); //周
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_PaperReport.Week); //周
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.Year))
 {
 if (objzx_PaperReportEN.Year !=  null)
 {
 var strYear = objzx_PaperReportEN.Year.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strYear, conzx_PaperReport.Year); //年
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_PaperReport.Year); //年
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.IdCurrEduCls))
 {
 if (objzx_PaperReportEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_PaperReportEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conzx_PaperReport.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_PaperReport.IdCurrEduCls); //教学班流水号
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where zxReportId = '{0}'", objzx_PaperReportEN.zxReportId); 
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
 /// <param name = "objzx_PaperReportEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clszx_PaperReportEN objzx_PaperReportEN, string strCondition)
{
 if (objzx_PaperReportEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_PaperReportEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_PaperReportDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_PaperReport Set ");
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.UpdDate))
 {
 if (objzx_PaperReportEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_PaperReportEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.GroupTextId))
 {
 if (objzx_PaperReportEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_PaperReportEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GroupTextId = '{0}',", strGroupTextId); //小组Id
 }
 else
 {
 sbSQL.Append(" GroupTextId = null,"); //小组Id
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.TextId))
 {
 if (objzx_PaperReportEN.TextId !=  null)
 {
 var strTextId = objzx_PaperReportEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TextId = '{0}',", strTextId); //课件Id
 }
 else
 {
 sbSQL.Append(" TextId = null,"); //课件Id
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.ReportContent))
 {
 if (objzx_PaperReportEN.ReportContent !=  null)
 {
 var strReportContent = objzx_PaperReportEN.ReportContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ReportContent = '{0}',", strReportContent); //汇报内容
 }
 else
 {
 sbSQL.Append(" ReportContent = null,"); //汇报内容
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objzx_PaperReportEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.ReportUser))
 {
 if (objzx_PaperReportEN.ReportUser !=  null)
 {
 var strReportUser = objzx_PaperReportEN.ReportUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ReportUser = '{0}',", strReportUser); //汇报用户
 }
 else
 {
 sbSQL.Append(" ReportUser = null,"); //汇报用户
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.ReportDate))
 {
 if (objzx_PaperReportEN.ReportDate !=  null)
 {
 var strReportDate = objzx_PaperReportEN.ReportDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ReportDate = '{0}',", strReportDate); //汇报日期
 }
 else
 {
 sbSQL.Append(" ReportDate = null,"); //汇报日期
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.UpdUser))
 {
 if (objzx_PaperReportEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_PaperReportEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.VersionCount))
 {
 if (objzx_PaperReportEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_PaperReportEN.VersionCount, conzx_PaperReport.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_PaperReport.VersionCount); //版本统计
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.OkCount))
 {
 if (objzx_PaperReportEN.OkCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_PaperReportEN.OkCount, conzx_PaperReport.OkCount); //点赞统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_PaperReport.OkCount); //点赞统计
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.AppraiseCount))
 {
 if (objzx_PaperReportEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_PaperReportEN.AppraiseCount, conzx_PaperReport.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_PaperReport.AppraiseCount); //评论数
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.Score))
 {
 if (objzx_PaperReportEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_PaperReportEN.Score, conzx_PaperReport.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_PaperReport.Score); //评分
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.StuScore))
 {
 if (objzx_PaperReportEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_PaperReportEN.StuScore, conzx_PaperReport.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_PaperReport.StuScore); //学生平均分
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.TeaScore))
 {
 if (objzx_PaperReportEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_PaperReportEN.TeaScore, conzx_PaperReport.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_PaperReport.TeaScore); //教师评分
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.PDFUrl))
 {
 if (objzx_PaperReportEN.PDFUrl !=  null)
 {
 var strPDFUrl = objzx_PaperReportEN.PDFUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PDFUrl = '{0}',", strPDFUrl); //PDFUrl
 }
 else
 {
 sbSQL.Append(" PDFUrl = null,"); //PDFUrl
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.PPTUrl))
 {
 if (objzx_PaperReportEN.PPTUrl !=  null)
 {
 var strPPTUrl = objzx_PaperReportEN.PPTUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PPTUrl = '{0}',", strPPTUrl); //PPTUrl
 }
 else
 {
 sbSQL.Append(" PPTUrl = null,"); //PPTUrl
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.Memo))
 {
 if (objzx_PaperReportEN.Memo !=  null)
 {
 var strMemo = objzx_PaperReportEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.Month))
 {
 if (objzx_PaperReportEN.Month !=  null)
 {
 var strMonth = objzx_PaperReportEN.Month.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Month = '{0}',", strMonth); //月
 }
 else
 {
 sbSQL.Append(" Month = null,"); //月
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.Week))
 {
 if (objzx_PaperReportEN.Week !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_PaperReportEN.Week, conzx_PaperReport.Week); //周
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_PaperReport.Week); //周
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.Year))
 {
 if (objzx_PaperReportEN.Year !=  null)
 {
 var strYear = objzx_PaperReportEN.Year.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Year = '{0}',", strYear); //年
 }
 else
 {
 sbSQL.Append(" Year = null,"); //年
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.IdCurrEduCls))
 {
 if (objzx_PaperReportEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_PaperReportEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objzx_PaperReportEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clszx_PaperReportEN objzx_PaperReportEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objzx_PaperReportEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_PaperReportEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_PaperReportDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_PaperReport Set ");
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.UpdDate))
 {
 if (objzx_PaperReportEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_PaperReportEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.GroupTextId))
 {
 if (objzx_PaperReportEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_PaperReportEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GroupTextId = '{0}',", strGroupTextId); //小组Id
 }
 else
 {
 sbSQL.Append(" GroupTextId = null,"); //小组Id
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.TextId))
 {
 if (objzx_PaperReportEN.TextId !=  null)
 {
 var strTextId = objzx_PaperReportEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TextId = '{0}',", strTextId); //课件Id
 }
 else
 {
 sbSQL.Append(" TextId = null,"); //课件Id
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.ReportContent))
 {
 if (objzx_PaperReportEN.ReportContent !=  null)
 {
 var strReportContent = objzx_PaperReportEN.ReportContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ReportContent = '{0}',", strReportContent); //汇报内容
 }
 else
 {
 sbSQL.Append(" ReportContent = null,"); //汇报内容
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objzx_PaperReportEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.ReportUser))
 {
 if (objzx_PaperReportEN.ReportUser !=  null)
 {
 var strReportUser = objzx_PaperReportEN.ReportUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ReportUser = '{0}',", strReportUser); //汇报用户
 }
 else
 {
 sbSQL.Append(" ReportUser = null,"); //汇报用户
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.ReportDate))
 {
 if (objzx_PaperReportEN.ReportDate !=  null)
 {
 var strReportDate = objzx_PaperReportEN.ReportDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ReportDate = '{0}',", strReportDate); //汇报日期
 }
 else
 {
 sbSQL.Append(" ReportDate = null,"); //汇报日期
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.UpdUser))
 {
 if (objzx_PaperReportEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_PaperReportEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.VersionCount))
 {
 if (objzx_PaperReportEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_PaperReportEN.VersionCount, conzx_PaperReport.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_PaperReport.VersionCount); //版本统计
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.OkCount))
 {
 if (objzx_PaperReportEN.OkCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_PaperReportEN.OkCount, conzx_PaperReport.OkCount); //点赞统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_PaperReport.OkCount); //点赞统计
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.AppraiseCount))
 {
 if (objzx_PaperReportEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_PaperReportEN.AppraiseCount, conzx_PaperReport.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_PaperReport.AppraiseCount); //评论数
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.Score))
 {
 if (objzx_PaperReportEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_PaperReportEN.Score, conzx_PaperReport.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_PaperReport.Score); //评分
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.StuScore))
 {
 if (objzx_PaperReportEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_PaperReportEN.StuScore, conzx_PaperReport.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_PaperReport.StuScore); //学生平均分
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.TeaScore))
 {
 if (objzx_PaperReportEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_PaperReportEN.TeaScore, conzx_PaperReport.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_PaperReport.TeaScore); //教师评分
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.PDFUrl))
 {
 if (objzx_PaperReportEN.PDFUrl !=  null)
 {
 var strPDFUrl = objzx_PaperReportEN.PDFUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PDFUrl = '{0}',", strPDFUrl); //PDFUrl
 }
 else
 {
 sbSQL.Append(" PDFUrl = null,"); //PDFUrl
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.PPTUrl))
 {
 if (objzx_PaperReportEN.PPTUrl !=  null)
 {
 var strPPTUrl = objzx_PaperReportEN.PPTUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PPTUrl = '{0}',", strPPTUrl); //PPTUrl
 }
 else
 {
 sbSQL.Append(" PPTUrl = null,"); //PPTUrl
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.Memo))
 {
 if (objzx_PaperReportEN.Memo !=  null)
 {
 var strMemo = objzx_PaperReportEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.Month))
 {
 if (objzx_PaperReportEN.Month !=  null)
 {
 var strMonth = objzx_PaperReportEN.Month.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Month = '{0}',", strMonth); //月
 }
 else
 {
 sbSQL.Append(" Month = null,"); //月
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.Week))
 {
 if (objzx_PaperReportEN.Week !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_PaperReportEN.Week, conzx_PaperReport.Week); //周
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_PaperReport.Week); //周
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.Year))
 {
 if (objzx_PaperReportEN.Year !=  null)
 {
 var strYear = objzx_PaperReportEN.Year.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Year = '{0}',", strYear); //年
 }
 else
 {
 sbSQL.Append(" Year = null,"); //年
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.IdCurrEduCls))
 {
 if (objzx_PaperReportEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_PaperReportEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objzx_PaperReportEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clszx_PaperReportEN objzx_PaperReportEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objzx_PaperReportEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_PaperReportEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_PaperReportDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_PaperReport Set ");
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.UpdDate))
 {
 if (objzx_PaperReportEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_PaperReportEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conzx_PaperReport.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_PaperReport.UpdDate); //修改日期
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.GroupTextId))
 {
 if (objzx_PaperReportEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_PaperReportEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGroupTextId, conzx_PaperReport.GroupTextId); //小组Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_PaperReport.GroupTextId); //小组Id
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.TextId))
 {
 if (objzx_PaperReportEN.TextId !=  null)
 {
 var strTextId = objzx_PaperReportEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTextId, conzx_PaperReport.TextId); //课件Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_PaperReport.TextId); //课件Id
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.ReportContent))
 {
 if (objzx_PaperReportEN.ReportContent !=  null)
 {
 var strReportContent = objzx_PaperReportEN.ReportContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReportContent, conzx_PaperReport.ReportContent); //汇报内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_PaperReport.ReportContent); //汇报内容
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objzx_PaperReportEN.IsSubmit == true?"1":"0", conzx_PaperReport.IsSubmit); //是否提交
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.ReportUser))
 {
 if (objzx_PaperReportEN.ReportUser !=  null)
 {
 var strReportUser = objzx_PaperReportEN.ReportUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReportUser, conzx_PaperReport.ReportUser); //汇报用户
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_PaperReport.ReportUser); //汇报用户
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.ReportDate))
 {
 if (objzx_PaperReportEN.ReportDate !=  null)
 {
 var strReportDate = objzx_PaperReportEN.ReportDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReportDate, conzx_PaperReport.ReportDate); //汇报日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_PaperReport.ReportDate); //汇报日期
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.UpdUser))
 {
 if (objzx_PaperReportEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_PaperReportEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conzx_PaperReport.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_PaperReport.UpdUser); //修改人
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.VersionCount))
 {
 if (objzx_PaperReportEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_PaperReportEN.VersionCount, conzx_PaperReport.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_PaperReport.VersionCount); //版本统计
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.OkCount))
 {
 if (objzx_PaperReportEN.OkCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_PaperReportEN.OkCount, conzx_PaperReport.OkCount); //点赞统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_PaperReport.OkCount); //点赞统计
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.AppraiseCount))
 {
 if (objzx_PaperReportEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_PaperReportEN.AppraiseCount, conzx_PaperReport.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_PaperReport.AppraiseCount); //评论数
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.Score))
 {
 if (objzx_PaperReportEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_PaperReportEN.Score, conzx_PaperReport.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_PaperReport.Score); //评分
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.StuScore))
 {
 if (objzx_PaperReportEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_PaperReportEN.StuScore, conzx_PaperReport.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_PaperReport.StuScore); //学生平均分
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.TeaScore))
 {
 if (objzx_PaperReportEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_PaperReportEN.TeaScore, conzx_PaperReport.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_PaperReport.TeaScore); //教师评分
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.PDFUrl))
 {
 if (objzx_PaperReportEN.PDFUrl !=  null)
 {
 var strPDFUrl = objzx_PaperReportEN.PDFUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPDFUrl, conzx_PaperReport.PDFUrl); //PDFUrl
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_PaperReport.PDFUrl); //PDFUrl
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.PPTUrl))
 {
 if (objzx_PaperReportEN.PPTUrl !=  null)
 {
 var strPPTUrl = objzx_PaperReportEN.PPTUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPPTUrl, conzx_PaperReport.PPTUrl); //PPTUrl
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_PaperReport.PPTUrl); //PPTUrl
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.Memo))
 {
 if (objzx_PaperReportEN.Memo !=  null)
 {
 var strMemo = objzx_PaperReportEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conzx_PaperReport.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_PaperReport.Memo); //备注
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.Month))
 {
 if (objzx_PaperReportEN.Month !=  null)
 {
 var strMonth = objzx_PaperReportEN.Month.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMonth, conzx_PaperReport.Month); //月
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_PaperReport.Month); //月
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.Week))
 {
 if (objzx_PaperReportEN.Week !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_PaperReportEN.Week, conzx_PaperReport.Week); //周
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_PaperReport.Week); //周
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.Year))
 {
 if (objzx_PaperReportEN.Year !=  null)
 {
 var strYear = objzx_PaperReportEN.Year.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strYear, conzx_PaperReport.Year); //年
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_PaperReport.Year); //年
 }
 }
 
 if (objzx_PaperReportEN.IsUpdated(conzx_PaperReport.IdCurrEduCls))
 {
 if (objzx_PaperReportEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_PaperReportEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conzx_PaperReport.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_PaperReport.IdCurrEduCls); //教学班流水号
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where zxReportId = '{0}'", objzx_PaperReportEN.zxReportId); 
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
 /// <param name = "strzxReportId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strzxReportId) 
{
CheckPrimaryKey(strzxReportId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_PaperReportDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strzxReportId,
};
 objSQL.ExecSP("zx_PaperReport_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strzxReportId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strzxReportId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strzxReportId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_PaperReportDA.GetSpecSQLObj();
//删除zx_PaperReport本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_PaperReport where zxReportId = " + "'"+ strzxReportId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delzx_PaperReport(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_PaperReportDA.GetSpecSQLObj();
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
//删除zx_PaperReport本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_PaperReport where zxReportId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strzxReportId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strzxReportId) 
{
CheckPrimaryKey(strzxReportId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_PaperReportDA.GetSpecSQLObj();
//删除zx_PaperReport本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_PaperReport where zxReportId = " + "'"+ strzxReportId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delzx_PaperReport(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clszx_PaperReportDA: Delzx_PaperReport)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_PaperReportDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from zx_PaperReport where " + strCondition ;
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
public bool Delzx_PaperReportWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clszx_PaperReportDA: Delzx_PaperReportWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_PaperReportDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from zx_PaperReport where " + strCondition ;
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
 /// <param name = "objzx_PaperReportENS">源对象</param>
 /// <param name = "objzx_PaperReportENT">目标对象</param>
public void CopyTo(clszx_PaperReportEN objzx_PaperReportENS, clszx_PaperReportEN objzx_PaperReportENT)
{
objzx_PaperReportENT.zxReportId = objzx_PaperReportENS.zxReportId; //汇报Id
objzx_PaperReportENT.UpdDate = objzx_PaperReportENS.UpdDate; //修改日期
objzx_PaperReportENT.GroupTextId = objzx_PaperReportENS.GroupTextId; //小组Id
objzx_PaperReportENT.TextId = objzx_PaperReportENS.TextId; //课件Id
objzx_PaperReportENT.ReportContent = objzx_PaperReportENS.ReportContent; //汇报内容
objzx_PaperReportENT.IsSubmit = objzx_PaperReportENS.IsSubmit; //是否提交
objzx_PaperReportENT.ReportUser = objzx_PaperReportENS.ReportUser; //汇报用户
objzx_PaperReportENT.ReportDate = objzx_PaperReportENS.ReportDate; //汇报日期
objzx_PaperReportENT.UpdUser = objzx_PaperReportENS.UpdUser; //修改人
objzx_PaperReportENT.VersionCount = objzx_PaperReportENS.VersionCount; //版本统计
objzx_PaperReportENT.OkCount = objzx_PaperReportENS.OkCount; //点赞统计
objzx_PaperReportENT.AppraiseCount = objzx_PaperReportENS.AppraiseCount; //评论数
objzx_PaperReportENT.Score = objzx_PaperReportENS.Score; //评分
objzx_PaperReportENT.StuScore = objzx_PaperReportENS.StuScore; //学生平均分
objzx_PaperReportENT.TeaScore = objzx_PaperReportENS.TeaScore; //教师评分
objzx_PaperReportENT.PDFUrl = objzx_PaperReportENS.PDFUrl; //PDFUrl
objzx_PaperReportENT.PPTUrl = objzx_PaperReportENS.PPTUrl; //PPTUrl
objzx_PaperReportENT.Memo = objzx_PaperReportENS.Memo; //备注
objzx_PaperReportENT.Month = objzx_PaperReportENS.Month; //月
objzx_PaperReportENT.Week = objzx_PaperReportENS.Week; //周
objzx_PaperReportENT.Year = objzx_PaperReportENS.Year; //年
objzx_PaperReportENT.IdCurrEduCls = objzx_PaperReportENS.IdCurrEduCls; //教学班流水号
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clszx_PaperReportEN objzx_PaperReportEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objzx_PaperReportEN.IdCurrEduCls, conzx_PaperReport.IdCurrEduCls);
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_PaperReportEN.zxReportId, 10, conzx_PaperReport.zxReportId);
clsCheckSql.CheckFieldLen(objzx_PaperReportEN.UpdDate, 20, conzx_PaperReport.UpdDate);
clsCheckSql.CheckFieldLen(objzx_PaperReportEN.GroupTextId, 8, conzx_PaperReport.GroupTextId);
clsCheckSql.CheckFieldLen(objzx_PaperReportEN.TextId, 8, conzx_PaperReport.TextId);
clsCheckSql.CheckFieldLen(objzx_PaperReportEN.ReportContent, 5000, conzx_PaperReport.ReportContent);
clsCheckSql.CheckFieldLen(objzx_PaperReportEN.ReportUser, 500, conzx_PaperReport.ReportUser);
clsCheckSql.CheckFieldLen(objzx_PaperReportEN.ReportDate, 20, conzx_PaperReport.ReportDate);
clsCheckSql.CheckFieldLen(objzx_PaperReportEN.UpdUser, 20, conzx_PaperReport.UpdUser);
clsCheckSql.CheckFieldLen(objzx_PaperReportEN.PDFUrl, 500, conzx_PaperReport.PDFUrl);
clsCheckSql.CheckFieldLen(objzx_PaperReportEN.PPTUrl, 500, conzx_PaperReport.PPTUrl);
clsCheckSql.CheckFieldLen(objzx_PaperReportEN.Memo, 1000, conzx_PaperReport.Memo);
clsCheckSql.CheckFieldLen(objzx_PaperReportEN.Month, 2, conzx_PaperReport.Month);
clsCheckSql.CheckFieldLen(objzx_PaperReportEN.Year, 4, conzx_PaperReport.Year);
clsCheckSql.CheckFieldLen(objzx_PaperReportEN.IdCurrEduCls, 8, conzx_PaperReport.IdCurrEduCls);
//检查字段外键固定长度
 objzx_PaperReportEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clszx_PaperReportEN objzx_PaperReportEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_PaperReportEN.UpdDate, 20, conzx_PaperReport.UpdDate);
clsCheckSql.CheckFieldLen(objzx_PaperReportEN.GroupTextId, 8, conzx_PaperReport.GroupTextId);
clsCheckSql.CheckFieldLen(objzx_PaperReportEN.TextId, 8, conzx_PaperReport.TextId);
clsCheckSql.CheckFieldLen(objzx_PaperReportEN.ReportContent, 5000, conzx_PaperReport.ReportContent);
clsCheckSql.CheckFieldLen(objzx_PaperReportEN.ReportUser, 500, conzx_PaperReport.ReportUser);
clsCheckSql.CheckFieldLen(objzx_PaperReportEN.ReportDate, 20, conzx_PaperReport.ReportDate);
clsCheckSql.CheckFieldLen(objzx_PaperReportEN.UpdUser, 20, conzx_PaperReport.UpdUser);
clsCheckSql.CheckFieldLen(objzx_PaperReportEN.PDFUrl, 500, conzx_PaperReport.PDFUrl);
clsCheckSql.CheckFieldLen(objzx_PaperReportEN.PPTUrl, 500, conzx_PaperReport.PPTUrl);
clsCheckSql.CheckFieldLen(objzx_PaperReportEN.Memo, 1000, conzx_PaperReport.Memo);
clsCheckSql.CheckFieldLen(objzx_PaperReportEN.Month, 2, conzx_PaperReport.Month);
clsCheckSql.CheckFieldLen(objzx_PaperReportEN.Year, 4, conzx_PaperReport.Year);
clsCheckSql.CheckFieldLen(objzx_PaperReportEN.IdCurrEduCls, 8, conzx_PaperReport.IdCurrEduCls);
//检查外键字段长度
 objzx_PaperReportEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clszx_PaperReportEN objzx_PaperReportEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_PaperReportEN.zxReportId, 10, conzx_PaperReport.zxReportId);
clsCheckSql.CheckFieldLen(objzx_PaperReportEN.UpdDate, 20, conzx_PaperReport.UpdDate);
clsCheckSql.CheckFieldLen(objzx_PaperReportEN.GroupTextId, 8, conzx_PaperReport.GroupTextId);
clsCheckSql.CheckFieldLen(objzx_PaperReportEN.TextId, 8, conzx_PaperReport.TextId);
clsCheckSql.CheckFieldLen(objzx_PaperReportEN.ReportContent, 5000, conzx_PaperReport.ReportContent);
clsCheckSql.CheckFieldLen(objzx_PaperReportEN.ReportUser, 500, conzx_PaperReport.ReportUser);
clsCheckSql.CheckFieldLen(objzx_PaperReportEN.ReportDate, 20, conzx_PaperReport.ReportDate);
clsCheckSql.CheckFieldLen(objzx_PaperReportEN.UpdUser, 20, conzx_PaperReport.UpdUser);
clsCheckSql.CheckFieldLen(objzx_PaperReportEN.PDFUrl, 500, conzx_PaperReport.PDFUrl);
clsCheckSql.CheckFieldLen(objzx_PaperReportEN.PPTUrl, 500, conzx_PaperReport.PPTUrl);
clsCheckSql.CheckFieldLen(objzx_PaperReportEN.Memo, 1000, conzx_PaperReport.Memo);
clsCheckSql.CheckFieldLen(objzx_PaperReportEN.Month, 2, conzx_PaperReport.Month);
clsCheckSql.CheckFieldLen(objzx_PaperReportEN.Year, 4, conzx_PaperReport.Year);
clsCheckSql.CheckFieldLen(objzx_PaperReportEN.IdCurrEduCls, 8, conzx_PaperReport.IdCurrEduCls);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objzx_PaperReportEN.zxReportId, conzx_PaperReport.zxReportId);
clsCheckSql.CheckSqlInjection4Field(objzx_PaperReportEN.UpdDate, conzx_PaperReport.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objzx_PaperReportEN.GroupTextId, conzx_PaperReport.GroupTextId);
clsCheckSql.CheckSqlInjection4Field(objzx_PaperReportEN.TextId, conzx_PaperReport.TextId);
clsCheckSql.CheckSqlInjection4Field(objzx_PaperReportEN.ReportContent, conzx_PaperReport.ReportContent);
clsCheckSql.CheckSqlInjection4Field(objzx_PaperReportEN.ReportUser, conzx_PaperReport.ReportUser);
clsCheckSql.CheckSqlInjection4Field(objzx_PaperReportEN.ReportDate, conzx_PaperReport.ReportDate);
clsCheckSql.CheckSqlInjection4Field(objzx_PaperReportEN.UpdUser, conzx_PaperReport.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objzx_PaperReportEN.PDFUrl, conzx_PaperReport.PDFUrl);
clsCheckSql.CheckSqlInjection4Field(objzx_PaperReportEN.PPTUrl, conzx_PaperReport.PPTUrl);
clsCheckSql.CheckSqlInjection4Field(objzx_PaperReportEN.Memo, conzx_PaperReport.Memo);
clsCheckSql.CheckSqlInjection4Field(objzx_PaperReportEN.Month, conzx_PaperReport.Month);
clsCheckSql.CheckSqlInjection4Field(objzx_PaperReportEN.Year, conzx_PaperReport.Year);
clsCheckSql.CheckSqlInjection4Field(objzx_PaperReportEN.IdCurrEduCls, conzx_PaperReport.IdCurrEduCls);
//检查外键字段长度
 objzx_PaperReportEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--zx_PaperReport(中学论文汇报表),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objzx_PaperReportEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clszx_PaperReportEN objzx_PaperReportEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 if (objzx_PaperReportEN.GroupTextId == null)
{
 sbCondition.AppendFormat(" and GroupTextId is null");
}
else
{
 sbCondition.AppendFormat(" and GroupTextId = '{0}'", objzx_PaperReportEN.GroupTextId);
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
 objSQL = clszx_PaperReportDA.GetSpecSQLObj();
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
 objSQL = clszx_PaperReportDA.GetSpecSQLObj();
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
 objSQL = clszx_PaperReportDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clszx_PaperReportEN._CurrTabName);
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
 objSQL = clszx_PaperReportDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clszx_PaperReportEN._CurrTabName, strCondition);
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
 objSQL = clszx_PaperReportDA.GetSpecSQLObj();
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
 objSQL = clszx_PaperReportDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}