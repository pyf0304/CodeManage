
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvgs_PaperReportDA
 表名:vgs_PaperReport(01120771)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:52:47
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
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
 /// 论文汇报视图(vgs_PaperReport)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvgs_PaperReportDA : clsCommBase4DA
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
 return clsvgs_PaperReportEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvgs_PaperReportEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvgs_PaperReportEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvgs_PaperReportEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvgs_PaperReportEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strReportId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strReportId)
{
strReportId = strReportId.Replace("'", "''");
if (strReportId.Length > 10)
{
throw new Exception("(errid:Data000001)在表:vgs_PaperReport中,检查关键字,长度不正确!(clsvgs_PaperReportDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strReportId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vgs_PaperReport中,关键字不能为空 或 null!(clsvgs_PaperReportDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strReportId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvgs_PaperReportDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvgs_PaperReportDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PaperReportDA.GetSpecSQLObj();
strSQL = "Select * from vgs_PaperReport where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vgs_PaperReport(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvgs_PaperReportDA: GetDataTable_vgs_PaperReport)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PaperReportDA.GetSpecSQLObj();
strSQL = "Select * from vgs_PaperReport where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvgs_PaperReportDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PaperReportDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvgs_PaperReportDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PaperReportDA.GetSpecSQLObj();
strSQL = "Select * from vgs_PaperReport where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvgs_PaperReportDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PaperReportDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvgs_PaperReportDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PaperReportDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vgs_PaperReport where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vgs_PaperReport where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvgs_PaperReportDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PaperReportDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vgs_PaperReport where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvgs_PaperReportDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PaperReportDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vgs_PaperReport.* from vgs_PaperReport Left Join {1} on {2} where {3} and vgs_PaperReport.ReportId not in (Select top {5} vgs_PaperReport.ReportId from vgs_PaperReport Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vgs_PaperReport where {1} and ReportId not in (Select top {2} ReportId from vgs_PaperReport where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vgs_PaperReport where {1} and ReportId not in (Select top {3} ReportId from vgs_PaperReport where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvgs_PaperReportDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PaperReportDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vgs_PaperReport.* from vgs_PaperReport Left Join {1} on {2} where {3} and vgs_PaperReport.ReportId not in (Select top {5} vgs_PaperReport.ReportId from vgs_PaperReport Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vgs_PaperReport where {1} and ReportId not in (Select top {2} ReportId from vgs_PaperReport where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vgs_PaperReport where {1} and ReportId not in (Select top {3} ReportId from vgs_PaperReport where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvgs_PaperReportEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvgs_PaperReportDA:GetObjLst)", objException.Message));
}
List<clsvgs_PaperReportEN> arrObjLst = new List<clsvgs_PaperReportEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PaperReportDA.GetSpecSQLObj();
strSQL = "Select * from vgs_PaperReport where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PaperReportEN objvgs_PaperReportEN = new clsvgs_PaperReportEN();
try
{
objvgs_PaperReportEN.Memo = objRow[convgs_PaperReport.Memo] == DBNull.Value ? null : objRow[convgs_PaperReport.Memo].ToString().Trim(); //备注
objvgs_PaperReportEN.ReportId = objRow[convgs_PaperReport.ReportId].ToString().Trim(); //汇报Id
objvgs_PaperReportEN.UpdDate = objRow[convgs_PaperReport.UpdDate] == DBNull.Value ? null : objRow[convgs_PaperReport.UpdDate].ToString().Trim(); //修改日期
objvgs_PaperReportEN.TopicName = objRow[convgs_PaperReport.TopicName] == DBNull.Value ? null : objRow[convgs_PaperReport.TopicName].ToString().Trim(); //栏目主题
objvgs_PaperReportEN.TopicId = objRow[convgs_PaperReport.TopicId] == DBNull.Value ? null : objRow[convgs_PaperReport.TopicId].ToString().Trim(); //主题Id
objvgs_PaperReportEN.PaperId = objRow[convgs_PaperReport.PaperId] == DBNull.Value ? null : objRow[convgs_PaperReport.PaperId].ToString().Trim(); //论文Id
objvgs_PaperReportEN.PaperTitle = objRow[convgs_PaperReport.PaperTitle] == DBNull.Value ? null : objRow[convgs_PaperReport.PaperTitle].ToString().Trim(); //论文标题
objvgs_PaperReportEN.ReportContent = objRow[convgs_PaperReport.ReportContent] == DBNull.Value ? null : objRow[convgs_PaperReport.ReportContent].ToString().Trim(); //汇报内容
objvgs_PaperReportEN.IdCurrEduCls = objRow[convgs_PaperReport.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_PaperReport.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_PaperReportEN.IsSubmit = TransNullToBool(objRow[convgs_PaperReport.IsSubmit].ToString().Trim()); //是否提交
objvgs_PaperReportEN.ReportUser = objRow[convgs_PaperReport.ReportUser] == DBNull.Value ? null : objRow[convgs_PaperReport.ReportUser].ToString().Trim(); //汇报用户
objvgs_PaperReportEN.ReportDate = objRow[convgs_PaperReport.ReportDate] == DBNull.Value ? null : objRow[convgs_PaperReport.ReportDate].ToString().Trim(); //汇报日期
objvgs_PaperReportEN.UpdUser = objRow[convgs_PaperReport.UpdUser] == DBNull.Value ? null : objRow[convgs_PaperReport.UpdUser].ToString().Trim(); //修改人
objvgs_PaperReportEN.VersionCount = objRow[convgs_PaperReport.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PaperReport.VersionCount].ToString().Trim()); //版本统计
objvgs_PaperReportEN.OkCount = objRow[convgs_PaperReport.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PaperReport.OkCount].ToString().Trim()); //点赞统计
objvgs_PaperReportEN.AppraiseCount = objRow[convgs_PaperReport.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PaperReport.AppraiseCount].ToString().Trim()); //评论数
objvgs_PaperReportEN.Score = objRow[convgs_PaperReport.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PaperReport.Score].ToString().Trim()); //评分
objvgs_PaperReportEN.StuScore = objRow[convgs_PaperReport.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PaperReport.StuScore].ToString().Trim()); //学生平均分
objvgs_PaperReportEN.TeaScore = objRow[convgs_PaperReport.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PaperReport.TeaScore].ToString().Trim()); //教师评分
objvgs_PaperReportEN.PDFUrl = objRow[convgs_PaperReport.PDFUrl] == DBNull.Value ? null : objRow[convgs_PaperReport.PDFUrl].ToString().Trim(); //PDFUrl
objvgs_PaperReportEN.PPTUrl = objRow[convgs_PaperReport.PPTUrl] == DBNull.Value ? null : objRow[convgs_PaperReport.PPTUrl].ToString().Trim(); //PPTUrl
objvgs_PaperReportEN.Month = objRow[convgs_PaperReport.Month] == DBNull.Value ? null : objRow[convgs_PaperReport.Month].ToString().Trim(); //月
objvgs_PaperReportEN.Week = objRow[convgs_PaperReport.Week] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PaperReport.Week].ToString().Trim()); //周
objvgs_PaperReportEN.Year = objRow[convgs_PaperReport.Year] == DBNull.Value ? null : objRow[convgs_PaperReport.Year].ToString().Trim(); //年
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvgs_PaperReportDA: GetObjLst)", objException.Message));
}
objvgs_PaperReportEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvgs_PaperReportEN);
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
public List<clsvgs_PaperReportEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvgs_PaperReportDA:GetObjLstByTabName)", objException.Message));
}
List<clsvgs_PaperReportEN> arrObjLst = new List<clsvgs_PaperReportEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PaperReportDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PaperReportEN objvgs_PaperReportEN = new clsvgs_PaperReportEN();
try
{
objvgs_PaperReportEN.Memo = objRow[convgs_PaperReport.Memo] == DBNull.Value ? null : objRow[convgs_PaperReport.Memo].ToString().Trim(); //备注
objvgs_PaperReportEN.ReportId = objRow[convgs_PaperReport.ReportId].ToString().Trim(); //汇报Id
objvgs_PaperReportEN.UpdDate = objRow[convgs_PaperReport.UpdDate] == DBNull.Value ? null : objRow[convgs_PaperReport.UpdDate].ToString().Trim(); //修改日期
objvgs_PaperReportEN.TopicName = objRow[convgs_PaperReport.TopicName] == DBNull.Value ? null : objRow[convgs_PaperReport.TopicName].ToString().Trim(); //栏目主题
objvgs_PaperReportEN.TopicId = objRow[convgs_PaperReport.TopicId] == DBNull.Value ? null : objRow[convgs_PaperReport.TopicId].ToString().Trim(); //主题Id
objvgs_PaperReportEN.PaperId = objRow[convgs_PaperReport.PaperId] == DBNull.Value ? null : objRow[convgs_PaperReport.PaperId].ToString().Trim(); //论文Id
objvgs_PaperReportEN.PaperTitle = objRow[convgs_PaperReport.PaperTitle] == DBNull.Value ? null : objRow[convgs_PaperReport.PaperTitle].ToString().Trim(); //论文标题
objvgs_PaperReportEN.ReportContent = objRow[convgs_PaperReport.ReportContent] == DBNull.Value ? null : objRow[convgs_PaperReport.ReportContent].ToString().Trim(); //汇报内容
objvgs_PaperReportEN.IdCurrEduCls = objRow[convgs_PaperReport.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_PaperReport.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_PaperReportEN.IsSubmit = TransNullToBool(objRow[convgs_PaperReport.IsSubmit].ToString().Trim()); //是否提交
objvgs_PaperReportEN.ReportUser = objRow[convgs_PaperReport.ReportUser] == DBNull.Value ? null : objRow[convgs_PaperReport.ReportUser].ToString().Trim(); //汇报用户
objvgs_PaperReportEN.ReportDate = objRow[convgs_PaperReport.ReportDate] == DBNull.Value ? null : objRow[convgs_PaperReport.ReportDate].ToString().Trim(); //汇报日期
objvgs_PaperReportEN.UpdUser = objRow[convgs_PaperReport.UpdUser] == DBNull.Value ? null : objRow[convgs_PaperReport.UpdUser].ToString().Trim(); //修改人
objvgs_PaperReportEN.VersionCount = objRow[convgs_PaperReport.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PaperReport.VersionCount].ToString().Trim()); //版本统计
objvgs_PaperReportEN.OkCount = objRow[convgs_PaperReport.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PaperReport.OkCount].ToString().Trim()); //点赞统计
objvgs_PaperReportEN.AppraiseCount = objRow[convgs_PaperReport.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PaperReport.AppraiseCount].ToString().Trim()); //评论数
objvgs_PaperReportEN.Score = objRow[convgs_PaperReport.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PaperReport.Score].ToString().Trim()); //评分
objvgs_PaperReportEN.StuScore = objRow[convgs_PaperReport.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PaperReport.StuScore].ToString().Trim()); //学生平均分
objvgs_PaperReportEN.TeaScore = objRow[convgs_PaperReport.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PaperReport.TeaScore].ToString().Trim()); //教师评分
objvgs_PaperReportEN.PDFUrl = objRow[convgs_PaperReport.PDFUrl] == DBNull.Value ? null : objRow[convgs_PaperReport.PDFUrl].ToString().Trim(); //PDFUrl
objvgs_PaperReportEN.PPTUrl = objRow[convgs_PaperReport.PPTUrl] == DBNull.Value ? null : objRow[convgs_PaperReport.PPTUrl].ToString().Trim(); //PPTUrl
objvgs_PaperReportEN.Month = objRow[convgs_PaperReport.Month] == DBNull.Value ? null : objRow[convgs_PaperReport.Month].ToString().Trim(); //月
objvgs_PaperReportEN.Week = objRow[convgs_PaperReport.Week] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PaperReport.Week].ToString().Trim()); //周
objvgs_PaperReportEN.Year = objRow[convgs_PaperReport.Year] == DBNull.Value ? null : objRow[convgs_PaperReport.Year].ToString().Trim(); //年
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvgs_PaperReportDA: GetObjLst)", objException.Message));
}
objvgs_PaperReportEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvgs_PaperReportEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvgs_PaperReportEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getvgs_PaperReport(ref clsvgs_PaperReportEN objvgs_PaperReportEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PaperReportDA.GetSpecSQLObj();
strSQL = "Select * from vgs_PaperReport where ReportId = " + "'"+ objvgs_PaperReportEN.ReportId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvgs_PaperReportEN.Memo = objDT.Rows[0][convgs_PaperReport.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvgs_PaperReportEN.ReportId = objDT.Rows[0][convgs_PaperReport.ReportId].ToString().Trim(); //汇报Id(字段类型:char,字段长度:10,是否可空:False)
 objvgs_PaperReportEN.UpdDate = objDT.Rows[0][convgs_PaperReport.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_PaperReportEN.TopicName = objDT.Rows[0][convgs_PaperReport.TopicName].ToString().Trim(); //栏目主题(字段类型:varchar,字段长度:200,是否可空:True)
 objvgs_PaperReportEN.TopicId = objDT.Rows[0][convgs_PaperReport.TopicId].ToString().Trim(); //主题Id(字段类型:char,字段长度:8,是否可空:True)
 objvgs_PaperReportEN.PaperId = objDT.Rows[0][convgs_PaperReport.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objvgs_PaperReportEN.PaperTitle = objDT.Rows[0][convgs_PaperReport.PaperTitle].ToString().Trim(); //论文标题(字段类型:varchar,字段长度:500,是否可空:False)
 objvgs_PaperReportEN.ReportContent = objDT.Rows[0][convgs_PaperReport.ReportContent].ToString().Trim(); //汇报内容(字段类型:varchar,字段长度:5000,是否可空:True)
 objvgs_PaperReportEN.IdCurrEduCls = objDT.Rows[0][convgs_PaperReport.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvgs_PaperReportEN.IsSubmit = TransNullToBool(objDT.Rows[0][convgs_PaperReport.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvgs_PaperReportEN.ReportUser = objDT.Rows[0][convgs_PaperReport.ReportUser].ToString().Trim(); //汇报用户(字段类型:varchar,字段长度:500,是否可空:True)
 objvgs_PaperReportEN.ReportDate = objDT.Rows[0][convgs_PaperReport.ReportDate].ToString().Trim(); //汇报日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_PaperReportEN.UpdUser = objDT.Rows[0][convgs_PaperReport.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_PaperReportEN.VersionCount = TransNullToInt(objDT.Rows[0][convgs_PaperReport.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objvgs_PaperReportEN.OkCount = TransNullToInt(objDT.Rows[0][convgs_PaperReport.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objvgs_PaperReportEN.AppraiseCount = TransNullToInt(objDT.Rows[0][convgs_PaperReport.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objvgs_PaperReportEN.Score = TransNullToFloat(objDT.Rows[0][convgs_PaperReport.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvgs_PaperReportEN.StuScore = TransNullToFloat(objDT.Rows[0][convgs_PaperReport.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objvgs_PaperReportEN.TeaScore = TransNullToFloat(objDT.Rows[0][convgs_PaperReport.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objvgs_PaperReportEN.PDFUrl = objDT.Rows[0][convgs_PaperReport.PDFUrl].ToString().Trim(); //PDFUrl(字段类型:varchar,字段长度:500,是否可空:True)
 objvgs_PaperReportEN.PPTUrl = objDT.Rows[0][convgs_PaperReport.PPTUrl].ToString().Trim(); //PPTUrl(字段类型:varchar,字段长度:500,是否可空:True)
 objvgs_PaperReportEN.Month = objDT.Rows[0][convgs_PaperReport.Month].ToString().Trim(); //月(字段类型:char,字段长度:2,是否可空:True)
 objvgs_PaperReportEN.Week = TransNullToInt(objDT.Rows[0][convgs_PaperReport.Week].ToString().Trim()); //周(字段类型:int,字段长度:4,是否可空:True)
 objvgs_PaperReportEN.Year = objDT.Rows[0][convgs_PaperReport.Year].ToString().Trim(); //年(字段类型:char,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvgs_PaperReportDA: Getvgs_PaperReport)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strReportId">表关键字</param>
 /// <returns>表对象</returns>
public clsvgs_PaperReportEN GetObjByReportId(string strReportId)
{
CheckPrimaryKey(strReportId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PaperReportDA.GetSpecSQLObj();
strSQL = "Select * from vgs_PaperReport where ReportId = " + "'"+ strReportId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvgs_PaperReportEN objvgs_PaperReportEN = new clsvgs_PaperReportEN();
try
{
 objvgs_PaperReportEN.Memo = objRow[convgs_PaperReport.Memo] == DBNull.Value ? null : objRow[convgs_PaperReport.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvgs_PaperReportEN.ReportId = objRow[convgs_PaperReport.ReportId].ToString().Trim(); //汇报Id(字段类型:char,字段长度:10,是否可空:False)
 objvgs_PaperReportEN.UpdDate = objRow[convgs_PaperReport.UpdDate] == DBNull.Value ? null : objRow[convgs_PaperReport.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_PaperReportEN.TopicName = objRow[convgs_PaperReport.TopicName] == DBNull.Value ? null : objRow[convgs_PaperReport.TopicName].ToString().Trim(); //栏目主题(字段类型:varchar,字段长度:200,是否可空:True)
 objvgs_PaperReportEN.TopicId = objRow[convgs_PaperReport.TopicId] == DBNull.Value ? null : objRow[convgs_PaperReport.TopicId].ToString().Trim(); //主题Id(字段类型:char,字段长度:8,是否可空:True)
 objvgs_PaperReportEN.PaperId = objRow[convgs_PaperReport.PaperId] == DBNull.Value ? null : objRow[convgs_PaperReport.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objvgs_PaperReportEN.PaperTitle = objRow[convgs_PaperReport.PaperTitle] == DBNull.Value ? null : objRow[convgs_PaperReport.PaperTitle].ToString().Trim(); //论文标题(字段类型:varchar,字段长度:500,是否可空:False)
 objvgs_PaperReportEN.ReportContent = objRow[convgs_PaperReport.ReportContent] == DBNull.Value ? null : objRow[convgs_PaperReport.ReportContent].ToString().Trim(); //汇报内容(字段类型:varchar,字段长度:5000,是否可空:True)
 objvgs_PaperReportEN.IdCurrEduCls = objRow[convgs_PaperReport.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_PaperReport.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvgs_PaperReportEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PaperReport.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvgs_PaperReportEN.ReportUser = objRow[convgs_PaperReport.ReportUser] == DBNull.Value ? null : objRow[convgs_PaperReport.ReportUser].ToString().Trim(); //汇报用户(字段类型:varchar,字段长度:500,是否可空:True)
 objvgs_PaperReportEN.ReportDate = objRow[convgs_PaperReport.ReportDate] == DBNull.Value ? null : objRow[convgs_PaperReport.ReportDate].ToString().Trim(); //汇报日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_PaperReportEN.UpdUser = objRow[convgs_PaperReport.UpdUser] == DBNull.Value ? null : objRow[convgs_PaperReport.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_PaperReportEN.VersionCount = objRow[convgs_PaperReport.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperReport.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objvgs_PaperReportEN.OkCount = objRow[convgs_PaperReport.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperReport.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objvgs_PaperReportEN.AppraiseCount = objRow[convgs_PaperReport.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperReport.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objvgs_PaperReportEN.Score = objRow[convgs_PaperReport.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PaperReport.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvgs_PaperReportEN.StuScore = objRow[convgs_PaperReport.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PaperReport.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objvgs_PaperReportEN.TeaScore = objRow[convgs_PaperReport.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PaperReport.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objvgs_PaperReportEN.PDFUrl = objRow[convgs_PaperReport.PDFUrl] == DBNull.Value ? null : objRow[convgs_PaperReport.PDFUrl].ToString().Trim(); //PDFUrl(字段类型:varchar,字段长度:500,是否可空:True)
 objvgs_PaperReportEN.PPTUrl = objRow[convgs_PaperReport.PPTUrl] == DBNull.Value ? null : objRow[convgs_PaperReport.PPTUrl].ToString().Trim(); //PPTUrl(字段类型:varchar,字段长度:500,是否可空:True)
 objvgs_PaperReportEN.Month = objRow[convgs_PaperReport.Month] == DBNull.Value ? null : objRow[convgs_PaperReport.Month].ToString().Trim(); //月(字段类型:char,字段长度:2,是否可空:True)
 objvgs_PaperReportEN.Week = objRow[convgs_PaperReport.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperReport.Week].ToString().Trim()); //周(字段类型:int,字段长度:4,是否可空:True)
 objvgs_PaperReportEN.Year = objRow[convgs_PaperReport.Year] == DBNull.Value ? null : objRow[convgs_PaperReport.Year].ToString().Trim(); //年(字段类型:char,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvgs_PaperReportDA: GetObjByReportId)", objException.Message));
}
return objvgs_PaperReportEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvgs_PaperReportEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvgs_PaperReportDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PaperReportDA.GetSpecSQLObj();
strSQL = "Select * from vgs_PaperReport where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvgs_PaperReportEN objvgs_PaperReportEN = new clsvgs_PaperReportEN()
{
Memo = objRow[convgs_PaperReport.Memo] == DBNull.Value ? null : objRow[convgs_PaperReport.Memo].ToString().Trim(), //备注
ReportId = objRow[convgs_PaperReport.ReportId].ToString().Trim(), //汇报Id
UpdDate = objRow[convgs_PaperReport.UpdDate] == DBNull.Value ? null : objRow[convgs_PaperReport.UpdDate].ToString().Trim(), //修改日期
TopicName = objRow[convgs_PaperReport.TopicName] == DBNull.Value ? null : objRow[convgs_PaperReport.TopicName].ToString().Trim(), //栏目主题
TopicId = objRow[convgs_PaperReport.TopicId] == DBNull.Value ? null : objRow[convgs_PaperReport.TopicId].ToString().Trim(), //主题Id
PaperId = objRow[convgs_PaperReport.PaperId] == DBNull.Value ? null : objRow[convgs_PaperReport.PaperId].ToString().Trim(), //论文Id
PaperTitle = objRow[convgs_PaperReport.PaperTitle] == DBNull.Value ? null : objRow[convgs_PaperReport.PaperTitle].ToString().Trim(), //论文标题
ReportContent = objRow[convgs_PaperReport.ReportContent] == DBNull.Value ? null : objRow[convgs_PaperReport.ReportContent].ToString().Trim(), //汇报内容
IdCurrEduCls = objRow[convgs_PaperReport.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_PaperReport.IdCurrEduCls].ToString().Trim(), //教学班流水号
IsSubmit = TransNullToBool(objRow[convgs_PaperReport.IsSubmit].ToString().Trim()), //是否提交
ReportUser = objRow[convgs_PaperReport.ReportUser] == DBNull.Value ? null : objRow[convgs_PaperReport.ReportUser].ToString().Trim(), //汇报用户
ReportDate = objRow[convgs_PaperReport.ReportDate] == DBNull.Value ? null : objRow[convgs_PaperReport.ReportDate].ToString().Trim(), //汇报日期
UpdUser = objRow[convgs_PaperReport.UpdUser] == DBNull.Value ? null : objRow[convgs_PaperReport.UpdUser].ToString().Trim(), //修改人
VersionCount = objRow[convgs_PaperReport.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PaperReport.VersionCount].ToString().Trim()), //版本统计
OkCount = objRow[convgs_PaperReport.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PaperReport.OkCount].ToString().Trim()), //点赞统计
AppraiseCount = objRow[convgs_PaperReport.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PaperReport.AppraiseCount].ToString().Trim()), //评论数
Score = objRow[convgs_PaperReport.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PaperReport.Score].ToString().Trim()), //评分
StuScore = objRow[convgs_PaperReport.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PaperReport.StuScore].ToString().Trim()), //学生平均分
TeaScore = objRow[convgs_PaperReport.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PaperReport.TeaScore].ToString().Trim()), //教师评分
PDFUrl = objRow[convgs_PaperReport.PDFUrl] == DBNull.Value ? null : objRow[convgs_PaperReport.PDFUrl].ToString().Trim(), //PDFUrl
PPTUrl = objRow[convgs_PaperReport.PPTUrl] == DBNull.Value ? null : objRow[convgs_PaperReport.PPTUrl].ToString().Trim(), //PPTUrl
Month = objRow[convgs_PaperReport.Month] == DBNull.Value ? null : objRow[convgs_PaperReport.Month].ToString().Trim(), //月
Week = objRow[convgs_PaperReport.Week] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PaperReport.Week].ToString().Trim()), //周
Year = objRow[convgs_PaperReport.Year] == DBNull.Value ? null : objRow[convgs_PaperReport.Year].ToString().Trim() //年
};
objvgs_PaperReportEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvgs_PaperReportEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvgs_PaperReportDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvgs_PaperReportEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvgs_PaperReportEN objvgs_PaperReportEN = new clsvgs_PaperReportEN();
try
{
objvgs_PaperReportEN.Memo = objRow[convgs_PaperReport.Memo] == DBNull.Value ? null : objRow[convgs_PaperReport.Memo].ToString().Trim(); //备注
objvgs_PaperReportEN.ReportId = objRow[convgs_PaperReport.ReportId].ToString().Trim(); //汇报Id
objvgs_PaperReportEN.UpdDate = objRow[convgs_PaperReport.UpdDate] == DBNull.Value ? null : objRow[convgs_PaperReport.UpdDate].ToString().Trim(); //修改日期
objvgs_PaperReportEN.TopicName = objRow[convgs_PaperReport.TopicName] == DBNull.Value ? null : objRow[convgs_PaperReport.TopicName].ToString().Trim(); //栏目主题
objvgs_PaperReportEN.TopicId = objRow[convgs_PaperReport.TopicId] == DBNull.Value ? null : objRow[convgs_PaperReport.TopicId].ToString().Trim(); //主题Id
objvgs_PaperReportEN.PaperId = objRow[convgs_PaperReport.PaperId] == DBNull.Value ? null : objRow[convgs_PaperReport.PaperId].ToString().Trim(); //论文Id
objvgs_PaperReportEN.PaperTitle = objRow[convgs_PaperReport.PaperTitle] == DBNull.Value ? null : objRow[convgs_PaperReport.PaperTitle].ToString().Trim(); //论文标题
objvgs_PaperReportEN.ReportContent = objRow[convgs_PaperReport.ReportContent] == DBNull.Value ? null : objRow[convgs_PaperReport.ReportContent].ToString().Trim(); //汇报内容
objvgs_PaperReportEN.IdCurrEduCls = objRow[convgs_PaperReport.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_PaperReport.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_PaperReportEN.IsSubmit = TransNullToBool(objRow[convgs_PaperReport.IsSubmit].ToString().Trim()); //是否提交
objvgs_PaperReportEN.ReportUser = objRow[convgs_PaperReport.ReportUser] == DBNull.Value ? null : objRow[convgs_PaperReport.ReportUser].ToString().Trim(); //汇报用户
objvgs_PaperReportEN.ReportDate = objRow[convgs_PaperReport.ReportDate] == DBNull.Value ? null : objRow[convgs_PaperReport.ReportDate].ToString().Trim(); //汇报日期
objvgs_PaperReportEN.UpdUser = objRow[convgs_PaperReport.UpdUser] == DBNull.Value ? null : objRow[convgs_PaperReport.UpdUser].ToString().Trim(); //修改人
objvgs_PaperReportEN.VersionCount = objRow[convgs_PaperReport.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PaperReport.VersionCount].ToString().Trim()); //版本统计
objvgs_PaperReportEN.OkCount = objRow[convgs_PaperReport.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PaperReport.OkCount].ToString().Trim()); //点赞统计
objvgs_PaperReportEN.AppraiseCount = objRow[convgs_PaperReport.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PaperReport.AppraiseCount].ToString().Trim()); //评论数
objvgs_PaperReportEN.Score = objRow[convgs_PaperReport.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PaperReport.Score].ToString().Trim()); //评分
objvgs_PaperReportEN.StuScore = objRow[convgs_PaperReport.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PaperReport.StuScore].ToString().Trim()); //学生平均分
objvgs_PaperReportEN.TeaScore = objRow[convgs_PaperReport.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PaperReport.TeaScore].ToString().Trim()); //教师评分
objvgs_PaperReportEN.PDFUrl = objRow[convgs_PaperReport.PDFUrl] == DBNull.Value ? null : objRow[convgs_PaperReport.PDFUrl].ToString().Trim(); //PDFUrl
objvgs_PaperReportEN.PPTUrl = objRow[convgs_PaperReport.PPTUrl] == DBNull.Value ? null : objRow[convgs_PaperReport.PPTUrl].ToString().Trim(); //PPTUrl
objvgs_PaperReportEN.Month = objRow[convgs_PaperReport.Month] == DBNull.Value ? null : objRow[convgs_PaperReport.Month].ToString().Trim(); //月
objvgs_PaperReportEN.Week = objRow[convgs_PaperReport.Week] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PaperReport.Week].ToString().Trim()); //周
objvgs_PaperReportEN.Year = objRow[convgs_PaperReport.Year] == DBNull.Value ? null : objRow[convgs_PaperReport.Year].ToString().Trim(); //年
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvgs_PaperReportDA: GetObjByDataRowvgs_PaperReport)", objException.Message));
}
objvgs_PaperReportEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvgs_PaperReportEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvgs_PaperReportEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvgs_PaperReportEN objvgs_PaperReportEN = new clsvgs_PaperReportEN();
try
{
objvgs_PaperReportEN.Memo = objRow[convgs_PaperReport.Memo] == DBNull.Value ? null : objRow[convgs_PaperReport.Memo].ToString().Trim(); //备注
objvgs_PaperReportEN.ReportId = objRow[convgs_PaperReport.ReportId].ToString().Trim(); //汇报Id
objvgs_PaperReportEN.UpdDate = objRow[convgs_PaperReport.UpdDate] == DBNull.Value ? null : objRow[convgs_PaperReport.UpdDate].ToString().Trim(); //修改日期
objvgs_PaperReportEN.TopicName = objRow[convgs_PaperReport.TopicName] == DBNull.Value ? null : objRow[convgs_PaperReport.TopicName].ToString().Trim(); //栏目主题
objvgs_PaperReportEN.TopicId = objRow[convgs_PaperReport.TopicId] == DBNull.Value ? null : objRow[convgs_PaperReport.TopicId].ToString().Trim(); //主题Id
objvgs_PaperReportEN.PaperId = objRow[convgs_PaperReport.PaperId] == DBNull.Value ? null : objRow[convgs_PaperReport.PaperId].ToString().Trim(); //论文Id
objvgs_PaperReportEN.PaperTitle = objRow[convgs_PaperReport.PaperTitle] == DBNull.Value ? null : objRow[convgs_PaperReport.PaperTitle].ToString().Trim(); //论文标题
objvgs_PaperReportEN.ReportContent = objRow[convgs_PaperReport.ReportContent] == DBNull.Value ? null : objRow[convgs_PaperReport.ReportContent].ToString().Trim(); //汇报内容
objvgs_PaperReportEN.IdCurrEduCls = objRow[convgs_PaperReport.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_PaperReport.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_PaperReportEN.IsSubmit = TransNullToBool(objRow[convgs_PaperReport.IsSubmit].ToString().Trim()); //是否提交
objvgs_PaperReportEN.ReportUser = objRow[convgs_PaperReport.ReportUser] == DBNull.Value ? null : objRow[convgs_PaperReport.ReportUser].ToString().Trim(); //汇报用户
objvgs_PaperReportEN.ReportDate = objRow[convgs_PaperReport.ReportDate] == DBNull.Value ? null : objRow[convgs_PaperReport.ReportDate].ToString().Trim(); //汇报日期
objvgs_PaperReportEN.UpdUser = objRow[convgs_PaperReport.UpdUser] == DBNull.Value ? null : objRow[convgs_PaperReport.UpdUser].ToString().Trim(); //修改人
objvgs_PaperReportEN.VersionCount = objRow[convgs_PaperReport.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PaperReport.VersionCount].ToString().Trim()); //版本统计
objvgs_PaperReportEN.OkCount = objRow[convgs_PaperReport.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PaperReport.OkCount].ToString().Trim()); //点赞统计
objvgs_PaperReportEN.AppraiseCount = objRow[convgs_PaperReport.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PaperReport.AppraiseCount].ToString().Trim()); //评论数
objvgs_PaperReportEN.Score = objRow[convgs_PaperReport.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PaperReport.Score].ToString().Trim()); //评分
objvgs_PaperReportEN.StuScore = objRow[convgs_PaperReport.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PaperReport.StuScore].ToString().Trim()); //学生平均分
objvgs_PaperReportEN.TeaScore = objRow[convgs_PaperReport.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PaperReport.TeaScore].ToString().Trim()); //教师评分
objvgs_PaperReportEN.PDFUrl = objRow[convgs_PaperReport.PDFUrl] == DBNull.Value ? null : objRow[convgs_PaperReport.PDFUrl].ToString().Trim(); //PDFUrl
objvgs_PaperReportEN.PPTUrl = objRow[convgs_PaperReport.PPTUrl] == DBNull.Value ? null : objRow[convgs_PaperReport.PPTUrl].ToString().Trim(); //PPTUrl
objvgs_PaperReportEN.Month = objRow[convgs_PaperReport.Month] == DBNull.Value ? null : objRow[convgs_PaperReport.Month].ToString().Trim(); //月
objvgs_PaperReportEN.Week = objRow[convgs_PaperReport.Week] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PaperReport.Week].ToString().Trim()); //周
objvgs_PaperReportEN.Year = objRow[convgs_PaperReport.Year] == DBNull.Value ? null : objRow[convgs_PaperReport.Year].ToString().Trim(); //年
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvgs_PaperReportDA: GetObjByDataRow)", objException.Message));
}
objvgs_PaperReportEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvgs_PaperReportEN;
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
objSQL = clsvgs_PaperReportDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvgs_PaperReportEN._CurrTabName, convgs_PaperReport.ReportId, 10, "");
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
objSQL = clsvgs_PaperReportDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvgs_PaperReportEN._CurrTabName, convgs_PaperReport.ReportId, 10, strPrefix);
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
 objSQL = clsvgs_PaperReportDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select ReportId from vgs_PaperReport where " + strCondition;
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
 objSQL = clsvgs_PaperReportDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select ReportId from vgs_PaperReport where " + strCondition;
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
 /// <param name = "strReportId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strReportId)
{
CheckPrimaryKey(strReportId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PaperReportDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vgs_PaperReport", "ReportId = " + "'"+ strReportId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvgs_PaperReportDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PaperReportDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vgs_PaperReport", strCondition))
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
objSQL = clsvgs_PaperReportDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vgs_PaperReport");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvgs_PaperReportENS">源对象</param>
 /// <param name = "objvgs_PaperReportENT">目标对象</param>
public void CopyTo(clsvgs_PaperReportEN objvgs_PaperReportENS, clsvgs_PaperReportEN objvgs_PaperReportENT)
{
objvgs_PaperReportENT.Memo = objvgs_PaperReportENS.Memo; //备注
objvgs_PaperReportENT.ReportId = objvgs_PaperReportENS.ReportId; //汇报Id
objvgs_PaperReportENT.UpdDate = objvgs_PaperReportENS.UpdDate; //修改日期
objvgs_PaperReportENT.TopicName = objvgs_PaperReportENS.TopicName; //栏目主题
objvgs_PaperReportENT.TopicId = objvgs_PaperReportENS.TopicId; //主题Id
objvgs_PaperReportENT.PaperId = objvgs_PaperReportENS.PaperId; //论文Id
objvgs_PaperReportENT.PaperTitle = objvgs_PaperReportENS.PaperTitle; //论文标题
objvgs_PaperReportENT.ReportContent = objvgs_PaperReportENS.ReportContent; //汇报内容
objvgs_PaperReportENT.IdCurrEduCls = objvgs_PaperReportENS.IdCurrEduCls; //教学班流水号
objvgs_PaperReportENT.IsSubmit = objvgs_PaperReportENS.IsSubmit; //是否提交
objvgs_PaperReportENT.ReportUser = objvgs_PaperReportENS.ReportUser; //汇报用户
objvgs_PaperReportENT.ReportDate = objvgs_PaperReportENS.ReportDate; //汇报日期
objvgs_PaperReportENT.UpdUser = objvgs_PaperReportENS.UpdUser; //修改人
objvgs_PaperReportENT.VersionCount = objvgs_PaperReportENS.VersionCount; //版本统计
objvgs_PaperReportENT.OkCount = objvgs_PaperReportENS.OkCount; //点赞统计
objvgs_PaperReportENT.AppraiseCount = objvgs_PaperReportENS.AppraiseCount; //评论数
objvgs_PaperReportENT.Score = objvgs_PaperReportENS.Score; //评分
objvgs_PaperReportENT.StuScore = objvgs_PaperReportENS.StuScore; //学生平均分
objvgs_PaperReportENT.TeaScore = objvgs_PaperReportENS.TeaScore; //教师评分
objvgs_PaperReportENT.PDFUrl = objvgs_PaperReportENS.PDFUrl; //PDFUrl
objvgs_PaperReportENT.PPTUrl = objvgs_PaperReportENS.PPTUrl; //PPTUrl
objvgs_PaperReportENT.Month = objvgs_PaperReportENS.Month; //月
objvgs_PaperReportENT.Week = objvgs_PaperReportENS.Week; //周
objvgs_PaperReportENT.Year = objvgs_PaperReportENS.Year; //年
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvgs_PaperReportEN objvgs_PaperReportEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvgs_PaperReportEN.Memo, 1000, convgs_PaperReport.Memo);
clsCheckSql.CheckFieldLen(objvgs_PaperReportEN.ReportId, 10, convgs_PaperReport.ReportId);
clsCheckSql.CheckFieldLen(objvgs_PaperReportEN.UpdDate, 20, convgs_PaperReport.UpdDate);
clsCheckSql.CheckFieldLen(objvgs_PaperReportEN.TopicName, 200, convgs_PaperReport.TopicName);
clsCheckSql.CheckFieldLen(objvgs_PaperReportEN.TopicId, 8, convgs_PaperReport.TopicId);
clsCheckSql.CheckFieldLen(objvgs_PaperReportEN.PaperId, 8, convgs_PaperReport.PaperId);
clsCheckSql.CheckFieldLen(objvgs_PaperReportEN.PaperTitle, 500, convgs_PaperReport.PaperTitle);
clsCheckSql.CheckFieldLen(objvgs_PaperReportEN.ReportContent, 5000, convgs_PaperReport.ReportContent);
clsCheckSql.CheckFieldLen(objvgs_PaperReportEN.IdCurrEduCls, 8, convgs_PaperReport.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objvgs_PaperReportEN.ReportUser, 500, convgs_PaperReport.ReportUser);
clsCheckSql.CheckFieldLen(objvgs_PaperReportEN.ReportDate, 20, convgs_PaperReport.ReportDate);
clsCheckSql.CheckFieldLen(objvgs_PaperReportEN.UpdUser, 20, convgs_PaperReport.UpdUser);
clsCheckSql.CheckFieldLen(objvgs_PaperReportEN.PDFUrl, 500, convgs_PaperReport.PDFUrl);
clsCheckSql.CheckFieldLen(objvgs_PaperReportEN.PPTUrl, 500, convgs_PaperReport.PPTUrl);
clsCheckSql.CheckFieldLen(objvgs_PaperReportEN.Month, 2, convgs_PaperReport.Month);
clsCheckSql.CheckFieldLen(objvgs_PaperReportEN.Year, 4, convgs_PaperReport.Year);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvgs_PaperReportEN.Memo, convgs_PaperReport.Memo);
clsCheckSql.CheckSqlInjection4Field(objvgs_PaperReportEN.ReportId, convgs_PaperReport.ReportId);
clsCheckSql.CheckSqlInjection4Field(objvgs_PaperReportEN.UpdDate, convgs_PaperReport.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvgs_PaperReportEN.TopicName, convgs_PaperReport.TopicName);
clsCheckSql.CheckSqlInjection4Field(objvgs_PaperReportEN.TopicId, convgs_PaperReport.TopicId);
clsCheckSql.CheckSqlInjection4Field(objvgs_PaperReportEN.PaperId, convgs_PaperReport.PaperId);
clsCheckSql.CheckSqlInjection4Field(objvgs_PaperReportEN.PaperTitle, convgs_PaperReport.PaperTitle);
clsCheckSql.CheckSqlInjection4Field(objvgs_PaperReportEN.ReportContent, convgs_PaperReport.ReportContent);
clsCheckSql.CheckSqlInjection4Field(objvgs_PaperReportEN.IdCurrEduCls, convgs_PaperReport.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objvgs_PaperReportEN.ReportUser, convgs_PaperReport.ReportUser);
clsCheckSql.CheckSqlInjection4Field(objvgs_PaperReportEN.ReportDate, convgs_PaperReport.ReportDate);
clsCheckSql.CheckSqlInjection4Field(objvgs_PaperReportEN.UpdUser, convgs_PaperReport.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvgs_PaperReportEN.PDFUrl, convgs_PaperReport.PDFUrl);
clsCheckSql.CheckSqlInjection4Field(objvgs_PaperReportEN.PPTUrl, convgs_PaperReport.PPTUrl);
clsCheckSql.CheckSqlInjection4Field(objvgs_PaperReportEN.Month, convgs_PaperReport.Month);
clsCheckSql.CheckSqlInjection4Field(objvgs_PaperReportEN.Year, convgs_PaperReport.Year);
//检查外键字段长度
 objvgs_PaperReportEN._IsCheckProperty = true;
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
 objSQL = clsvgs_PaperReportDA.GetSpecSQLObj();
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
 objSQL = clsvgs_PaperReportDA.GetSpecSQLObj();
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
 objSQL = clsvgs_PaperReportDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvgs_PaperReportEN._CurrTabName);
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
 objSQL = clsvgs_PaperReportDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvgs_PaperReportEN._CurrTabName, strCondition);
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
 objSQL = clsvgs_PaperReportDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}