
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_PaperReportDA
 表名:vzx_PaperReport(01120832)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:13:53
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
 /// vzx_PaperReport(vzx_PaperReport)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvzx_PaperReportDA : clsCommBase4DA
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
 return clsvzx_PaperReportEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvzx_PaperReportEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvzx_PaperReportEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvzx_PaperReportEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvzx_PaperReportEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:vzx_PaperReport中,检查关键字,长度不正确!(clsvzx_PaperReportDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strzxReportId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vzx_PaperReport中,关键字不能为空 或 null!(clsvzx_PaperReportDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strzxReportId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvzx_PaperReportDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvzx_PaperReportDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_PaperReportDA.GetSpecSQLObj();
strSQL = "Select * from vzx_PaperReport where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vzx_PaperReport(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvzx_PaperReportDA: GetDataTable_vzx_PaperReport)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_PaperReportDA.GetSpecSQLObj();
strSQL = "Select * from vzx_PaperReport where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvzx_PaperReportDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_PaperReportDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvzx_PaperReportDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_PaperReportDA.GetSpecSQLObj();
strSQL = "Select * from vzx_PaperReport where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvzx_PaperReportDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_PaperReportDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvzx_PaperReportDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_PaperReportDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vzx_PaperReport where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vzx_PaperReport where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvzx_PaperReportDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_PaperReportDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vzx_PaperReport where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvzx_PaperReportDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_PaperReportDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vzx_PaperReport.* from vzx_PaperReport Left Join {1} on {2} where {3} and vzx_PaperReport.zxReportId not in (Select top {5} vzx_PaperReport.zxReportId from vzx_PaperReport Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vzx_PaperReport where {1} and zxReportId not in (Select top {2} zxReportId from vzx_PaperReport where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vzx_PaperReport where {1} and zxReportId not in (Select top {3} zxReportId from vzx_PaperReport where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvzx_PaperReportDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_PaperReportDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vzx_PaperReport.* from vzx_PaperReport Left Join {1} on {2} where {3} and vzx_PaperReport.zxReportId not in (Select top {5} vzx_PaperReport.zxReportId from vzx_PaperReport Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vzx_PaperReport where {1} and zxReportId not in (Select top {2} zxReportId from vzx_PaperReport where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vzx_PaperReport where {1} and zxReportId not in (Select top {3} zxReportId from vzx_PaperReport where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvzx_PaperReportEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvzx_PaperReportDA:GetObjLst)", objException.Message));
}
List<clsvzx_PaperReportEN> arrObjLst = new List<clsvzx_PaperReportEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_PaperReportDA.GetSpecSQLObj();
strSQL = "Select * from vzx_PaperReport where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_PaperReportEN objvzx_PaperReportEN = new clsvzx_PaperReportEN();
try
{
objvzx_PaperReportEN.TextTitle = objRow[convzx_PaperReport.TextTitle] == DBNull.Value ? null : objRow[convzx_PaperReport.TextTitle].ToString().Trim(); //TextTitle
objvzx_PaperReportEN.GroupTextName = objRow[convzx_PaperReport.GroupTextName] == DBNull.Value ? null : objRow[convzx_PaperReport.GroupTextName].ToString().Trim(); //小组名称
objvzx_PaperReportEN.IdCurrEduCls = objRow[convzx_PaperReport.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_PaperReport.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_PaperReportEN.zxReportId = objRow[convzx_PaperReport.zxReportId].ToString().Trim(); //汇报Id
objvzx_PaperReportEN.GroupTextId = objRow[convzx_PaperReport.GroupTextId] == DBNull.Value ? null : objRow[convzx_PaperReport.GroupTextId].ToString().Trim(); //小组Id
objvzx_PaperReportEN.UpdDate = objRow[convzx_PaperReport.UpdDate] == DBNull.Value ? null : objRow[convzx_PaperReport.UpdDate].ToString().Trim(); //修改日期
objvzx_PaperReportEN.PDFUrl = objRow[convzx_PaperReport.PDFUrl] == DBNull.Value ? null : objRow[convzx_PaperReport.PDFUrl].ToString().Trim(); //PDFUrl
objvzx_PaperReportEN.TeaScore = objRow[convzx_PaperReport.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_PaperReport.TeaScore].ToString().Trim()); //教师评分
objvzx_PaperReportEN.StuScore = objRow[convzx_PaperReport.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_PaperReport.StuScore].ToString().Trim()); //学生平均分
objvzx_PaperReportEN.Score = objRow[convzx_PaperReport.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_PaperReport.Score].ToString().Trim()); //评分
objvzx_PaperReportEN.OkCount = objRow[convzx_PaperReport.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperReport.OkCount].ToString().Trim()); //点赞统计
objvzx_PaperReportEN.VersionCount = objRow[convzx_PaperReport.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperReport.VersionCount].ToString().Trim()); //版本统计
objvzx_PaperReportEN.UpdUser = objRow[convzx_PaperReport.UpdUser] == DBNull.Value ? null : objRow[convzx_PaperReport.UpdUser].ToString().Trim(); //修改人
objvzx_PaperReportEN.ReportContent = objRow[convzx_PaperReport.ReportContent] == DBNull.Value ? null : objRow[convzx_PaperReport.ReportContent].ToString().Trim(); //汇报内容
objvzx_PaperReportEN.TextId = objRow[convzx_PaperReport.TextId] == DBNull.Value ? null : objRow[convzx_PaperReport.TextId].ToString().Trim(); //课件Id
objvzx_PaperReportEN.IsSubmit = TransNullToBool(objRow[convzx_PaperReport.IsSubmit].ToString().Trim()); //是否提交
objvzx_PaperReportEN.ReportUser = objRow[convzx_PaperReport.ReportUser] == DBNull.Value ? null : objRow[convzx_PaperReport.ReportUser].ToString().Trim(); //汇报用户
objvzx_PaperReportEN.ReportDate = objRow[convzx_PaperReport.ReportDate] == DBNull.Value ? null : objRow[convzx_PaperReport.ReportDate].ToString().Trim(); //汇报日期
objvzx_PaperReportEN.PPTUrl = objRow[convzx_PaperReport.PPTUrl] == DBNull.Value ? null : objRow[convzx_PaperReport.PPTUrl].ToString().Trim(); //PPTUrl
objvzx_PaperReportEN.Memo = objRow[convzx_PaperReport.Memo] == DBNull.Value ? null : objRow[convzx_PaperReport.Memo].ToString().Trim(); //备注
objvzx_PaperReportEN.Month = objRow[convzx_PaperReport.Month] == DBNull.Value ? null : objRow[convzx_PaperReport.Month].ToString().Trim(); //月
objvzx_PaperReportEN.Week = objRow[convzx_PaperReport.Week] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperReport.Week].ToString().Trim()); //周
objvzx_PaperReportEN.Year = objRow[convzx_PaperReport.Year] == DBNull.Value ? null : objRow[convzx_PaperReport.Year].ToString().Trim(); //年
objvzx_PaperReportEN.AppraiseCount = objRow[convzx_PaperReport.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperReport.AppraiseCount].ToString().Trim()); //评论数
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvzx_PaperReportDA: GetObjLst)", objException.Message));
}
objvzx_PaperReportEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvzx_PaperReportEN);
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
public List<clsvzx_PaperReportEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvzx_PaperReportDA:GetObjLstByTabName)", objException.Message));
}
List<clsvzx_PaperReportEN> arrObjLst = new List<clsvzx_PaperReportEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_PaperReportDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_PaperReportEN objvzx_PaperReportEN = new clsvzx_PaperReportEN();
try
{
objvzx_PaperReportEN.TextTitle = objRow[convzx_PaperReport.TextTitle] == DBNull.Value ? null : objRow[convzx_PaperReport.TextTitle].ToString().Trim(); //TextTitle
objvzx_PaperReportEN.GroupTextName = objRow[convzx_PaperReport.GroupTextName] == DBNull.Value ? null : objRow[convzx_PaperReport.GroupTextName].ToString().Trim(); //小组名称
objvzx_PaperReportEN.IdCurrEduCls = objRow[convzx_PaperReport.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_PaperReport.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_PaperReportEN.zxReportId = objRow[convzx_PaperReport.zxReportId].ToString().Trim(); //汇报Id
objvzx_PaperReportEN.GroupTextId = objRow[convzx_PaperReport.GroupTextId] == DBNull.Value ? null : objRow[convzx_PaperReport.GroupTextId].ToString().Trim(); //小组Id
objvzx_PaperReportEN.UpdDate = objRow[convzx_PaperReport.UpdDate] == DBNull.Value ? null : objRow[convzx_PaperReport.UpdDate].ToString().Trim(); //修改日期
objvzx_PaperReportEN.PDFUrl = objRow[convzx_PaperReport.PDFUrl] == DBNull.Value ? null : objRow[convzx_PaperReport.PDFUrl].ToString().Trim(); //PDFUrl
objvzx_PaperReportEN.TeaScore = objRow[convzx_PaperReport.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_PaperReport.TeaScore].ToString().Trim()); //教师评分
objvzx_PaperReportEN.StuScore = objRow[convzx_PaperReport.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_PaperReport.StuScore].ToString().Trim()); //学生平均分
objvzx_PaperReportEN.Score = objRow[convzx_PaperReport.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_PaperReport.Score].ToString().Trim()); //评分
objvzx_PaperReportEN.OkCount = objRow[convzx_PaperReport.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperReport.OkCount].ToString().Trim()); //点赞统计
objvzx_PaperReportEN.VersionCount = objRow[convzx_PaperReport.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperReport.VersionCount].ToString().Trim()); //版本统计
objvzx_PaperReportEN.UpdUser = objRow[convzx_PaperReport.UpdUser] == DBNull.Value ? null : objRow[convzx_PaperReport.UpdUser].ToString().Trim(); //修改人
objvzx_PaperReportEN.ReportContent = objRow[convzx_PaperReport.ReportContent] == DBNull.Value ? null : objRow[convzx_PaperReport.ReportContent].ToString().Trim(); //汇报内容
objvzx_PaperReportEN.TextId = objRow[convzx_PaperReport.TextId] == DBNull.Value ? null : objRow[convzx_PaperReport.TextId].ToString().Trim(); //课件Id
objvzx_PaperReportEN.IsSubmit = TransNullToBool(objRow[convzx_PaperReport.IsSubmit].ToString().Trim()); //是否提交
objvzx_PaperReportEN.ReportUser = objRow[convzx_PaperReport.ReportUser] == DBNull.Value ? null : objRow[convzx_PaperReport.ReportUser].ToString().Trim(); //汇报用户
objvzx_PaperReportEN.ReportDate = objRow[convzx_PaperReport.ReportDate] == DBNull.Value ? null : objRow[convzx_PaperReport.ReportDate].ToString().Trim(); //汇报日期
objvzx_PaperReportEN.PPTUrl = objRow[convzx_PaperReport.PPTUrl] == DBNull.Value ? null : objRow[convzx_PaperReport.PPTUrl].ToString().Trim(); //PPTUrl
objvzx_PaperReportEN.Memo = objRow[convzx_PaperReport.Memo] == DBNull.Value ? null : objRow[convzx_PaperReport.Memo].ToString().Trim(); //备注
objvzx_PaperReportEN.Month = objRow[convzx_PaperReport.Month] == DBNull.Value ? null : objRow[convzx_PaperReport.Month].ToString().Trim(); //月
objvzx_PaperReportEN.Week = objRow[convzx_PaperReport.Week] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperReport.Week].ToString().Trim()); //周
objvzx_PaperReportEN.Year = objRow[convzx_PaperReport.Year] == DBNull.Value ? null : objRow[convzx_PaperReport.Year].ToString().Trim(); //年
objvzx_PaperReportEN.AppraiseCount = objRow[convzx_PaperReport.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperReport.AppraiseCount].ToString().Trim()); //评论数
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvzx_PaperReportDA: GetObjLst)", objException.Message));
}
objvzx_PaperReportEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvzx_PaperReportEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvzx_PaperReportEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getvzx_PaperReport(ref clsvzx_PaperReportEN objvzx_PaperReportEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_PaperReportDA.GetSpecSQLObj();
strSQL = "Select * from vzx_PaperReport where zxReportId = " + "'"+ objvzx_PaperReportEN.zxReportId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvzx_PaperReportEN.TextTitle = objDT.Rows[0][convzx_PaperReport.TextTitle].ToString().Trim(); //TextTitle(字段类型:varchar,字段长度:500,是否可空:False)
 objvzx_PaperReportEN.GroupTextName = objDT.Rows[0][convzx_PaperReport.GroupTextName].ToString().Trim(); //小组名称(字段类型:varchar,字段长度:2000,是否可空:True)
 objvzx_PaperReportEN.IdCurrEduCls = objDT.Rows[0][convzx_PaperReport.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvzx_PaperReportEN.zxReportId = objDT.Rows[0][convzx_PaperReport.zxReportId].ToString().Trim(); //汇报Id(字段类型:char,字段长度:10,是否可空:False)
 objvzx_PaperReportEN.GroupTextId = objDT.Rows[0][convzx_PaperReport.GroupTextId].ToString().Trim(); //小组Id(字段类型:char,字段长度:8,是否可空:False)
 objvzx_PaperReportEN.UpdDate = objDT.Rows[0][convzx_PaperReport.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_PaperReportEN.PDFUrl = objDT.Rows[0][convzx_PaperReport.PDFUrl].ToString().Trim(); //PDFUrl(字段类型:varchar,字段长度:500,是否可空:True)
 objvzx_PaperReportEN.TeaScore = TransNullToFloat(objDT.Rows[0][convzx_PaperReport.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objvzx_PaperReportEN.StuScore = TransNullToFloat(objDT.Rows[0][convzx_PaperReport.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objvzx_PaperReportEN.Score = TransNullToFloat(objDT.Rows[0][convzx_PaperReport.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvzx_PaperReportEN.OkCount = TransNullToInt(objDT.Rows[0][convzx_PaperReport.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objvzx_PaperReportEN.VersionCount = TransNullToInt(objDT.Rows[0][convzx_PaperReport.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objvzx_PaperReportEN.UpdUser = objDT.Rows[0][convzx_PaperReport.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_PaperReportEN.ReportContent = objDT.Rows[0][convzx_PaperReport.ReportContent].ToString().Trim(); //汇报内容(字段类型:varchar,字段长度:5000,是否可空:True)
 objvzx_PaperReportEN.TextId = objDT.Rows[0][convzx_PaperReport.TextId].ToString().Trim(); //课件Id(字段类型:char,字段长度:8,是否可空:False)
 objvzx_PaperReportEN.IsSubmit = TransNullToBool(objDT.Rows[0][convzx_PaperReport.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvzx_PaperReportEN.ReportUser = objDT.Rows[0][convzx_PaperReport.ReportUser].ToString().Trim(); //汇报用户(字段类型:varchar,字段长度:500,是否可空:True)
 objvzx_PaperReportEN.ReportDate = objDT.Rows[0][convzx_PaperReport.ReportDate].ToString().Trim(); //汇报日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_PaperReportEN.PPTUrl = objDT.Rows[0][convzx_PaperReport.PPTUrl].ToString().Trim(); //PPTUrl(字段类型:varchar,字段长度:500,是否可空:True)
 objvzx_PaperReportEN.Memo = objDT.Rows[0][convzx_PaperReport.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_PaperReportEN.Month = objDT.Rows[0][convzx_PaperReport.Month].ToString().Trim(); //月(字段类型:char,字段长度:2,是否可空:True)
 objvzx_PaperReportEN.Week = TransNullToInt(objDT.Rows[0][convzx_PaperReport.Week].ToString().Trim()); //周(字段类型:int,字段长度:4,是否可空:True)
 objvzx_PaperReportEN.Year = objDT.Rows[0][convzx_PaperReport.Year].ToString().Trim(); //年(字段类型:char,字段长度:4,是否可空:True)
 objvzx_PaperReportEN.AppraiseCount = TransNullToInt(objDT.Rows[0][convzx_PaperReport.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvzx_PaperReportDA: Getvzx_PaperReport)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strzxReportId">表关键字</param>
 /// <returns>表对象</returns>
public clsvzx_PaperReportEN GetObjByzxReportId(string strzxReportId)
{
CheckPrimaryKey(strzxReportId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_PaperReportDA.GetSpecSQLObj();
strSQL = "Select * from vzx_PaperReport where zxReportId = " + "'"+ strzxReportId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvzx_PaperReportEN objvzx_PaperReportEN = new clsvzx_PaperReportEN();
try
{
 objvzx_PaperReportEN.TextTitle = objRow[convzx_PaperReport.TextTitle] == DBNull.Value ? null : objRow[convzx_PaperReport.TextTitle].ToString().Trim(); //TextTitle(字段类型:varchar,字段长度:500,是否可空:False)
 objvzx_PaperReportEN.GroupTextName = objRow[convzx_PaperReport.GroupTextName] == DBNull.Value ? null : objRow[convzx_PaperReport.GroupTextName].ToString().Trim(); //小组名称(字段类型:varchar,字段长度:2000,是否可空:True)
 objvzx_PaperReportEN.IdCurrEduCls = objRow[convzx_PaperReport.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_PaperReport.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvzx_PaperReportEN.zxReportId = objRow[convzx_PaperReport.zxReportId].ToString().Trim(); //汇报Id(字段类型:char,字段长度:10,是否可空:False)
 objvzx_PaperReportEN.GroupTextId = objRow[convzx_PaperReport.GroupTextId] == DBNull.Value ? null : objRow[convzx_PaperReport.GroupTextId].ToString().Trim(); //小组Id(字段类型:char,字段长度:8,是否可空:False)
 objvzx_PaperReportEN.UpdDate = objRow[convzx_PaperReport.UpdDate] == DBNull.Value ? null : objRow[convzx_PaperReport.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_PaperReportEN.PDFUrl = objRow[convzx_PaperReport.PDFUrl] == DBNull.Value ? null : objRow[convzx_PaperReport.PDFUrl].ToString().Trim(); //PDFUrl(字段类型:varchar,字段长度:500,是否可空:True)
 objvzx_PaperReportEN.TeaScore = objRow[convzx_PaperReport.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_PaperReport.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objvzx_PaperReportEN.StuScore = objRow[convzx_PaperReport.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_PaperReport.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objvzx_PaperReportEN.Score = objRow[convzx_PaperReport.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_PaperReport.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvzx_PaperReportEN.OkCount = objRow[convzx_PaperReport.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperReport.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objvzx_PaperReportEN.VersionCount = objRow[convzx_PaperReport.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperReport.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objvzx_PaperReportEN.UpdUser = objRow[convzx_PaperReport.UpdUser] == DBNull.Value ? null : objRow[convzx_PaperReport.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_PaperReportEN.ReportContent = objRow[convzx_PaperReport.ReportContent] == DBNull.Value ? null : objRow[convzx_PaperReport.ReportContent].ToString().Trim(); //汇报内容(字段类型:varchar,字段长度:5000,是否可空:True)
 objvzx_PaperReportEN.TextId = objRow[convzx_PaperReport.TextId] == DBNull.Value ? null : objRow[convzx_PaperReport.TextId].ToString().Trim(); //课件Id(字段类型:char,字段长度:8,是否可空:False)
 objvzx_PaperReportEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_PaperReport.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvzx_PaperReportEN.ReportUser = objRow[convzx_PaperReport.ReportUser] == DBNull.Value ? null : objRow[convzx_PaperReport.ReportUser].ToString().Trim(); //汇报用户(字段类型:varchar,字段长度:500,是否可空:True)
 objvzx_PaperReportEN.ReportDate = objRow[convzx_PaperReport.ReportDate] == DBNull.Value ? null : objRow[convzx_PaperReport.ReportDate].ToString().Trim(); //汇报日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_PaperReportEN.PPTUrl = objRow[convzx_PaperReport.PPTUrl] == DBNull.Value ? null : objRow[convzx_PaperReport.PPTUrl].ToString().Trim(); //PPTUrl(字段类型:varchar,字段长度:500,是否可空:True)
 objvzx_PaperReportEN.Memo = objRow[convzx_PaperReport.Memo] == DBNull.Value ? null : objRow[convzx_PaperReport.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_PaperReportEN.Month = objRow[convzx_PaperReport.Month] == DBNull.Value ? null : objRow[convzx_PaperReport.Month].ToString().Trim(); //月(字段类型:char,字段长度:2,是否可空:True)
 objvzx_PaperReportEN.Week = objRow[convzx_PaperReport.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperReport.Week].ToString().Trim()); //周(字段类型:int,字段长度:4,是否可空:True)
 objvzx_PaperReportEN.Year = objRow[convzx_PaperReport.Year] == DBNull.Value ? null : objRow[convzx_PaperReport.Year].ToString().Trim(); //年(字段类型:char,字段长度:4,是否可空:True)
 objvzx_PaperReportEN.AppraiseCount = objRow[convzx_PaperReport.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperReport.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvzx_PaperReportDA: GetObjByzxReportId)", objException.Message));
}
return objvzx_PaperReportEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvzx_PaperReportEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvzx_PaperReportDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_PaperReportDA.GetSpecSQLObj();
strSQL = "Select * from vzx_PaperReport where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvzx_PaperReportEN objvzx_PaperReportEN = new clsvzx_PaperReportEN()
{
TextTitle = objRow[convzx_PaperReport.TextTitle] == DBNull.Value ? null : objRow[convzx_PaperReport.TextTitle].ToString().Trim(), //TextTitle
GroupTextName = objRow[convzx_PaperReport.GroupTextName] == DBNull.Value ? null : objRow[convzx_PaperReport.GroupTextName].ToString().Trim(), //小组名称
IdCurrEduCls = objRow[convzx_PaperReport.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_PaperReport.IdCurrEduCls].ToString().Trim(), //教学班流水号
zxReportId = objRow[convzx_PaperReport.zxReportId].ToString().Trim(), //汇报Id
GroupTextId = objRow[convzx_PaperReport.GroupTextId] == DBNull.Value ? null : objRow[convzx_PaperReport.GroupTextId].ToString().Trim(), //小组Id
UpdDate = objRow[convzx_PaperReport.UpdDate] == DBNull.Value ? null : objRow[convzx_PaperReport.UpdDate].ToString().Trim(), //修改日期
PDFUrl = objRow[convzx_PaperReport.PDFUrl] == DBNull.Value ? null : objRow[convzx_PaperReport.PDFUrl].ToString().Trim(), //PDFUrl
TeaScore = objRow[convzx_PaperReport.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_PaperReport.TeaScore].ToString().Trim()), //教师评分
StuScore = objRow[convzx_PaperReport.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_PaperReport.StuScore].ToString().Trim()), //学生平均分
Score = objRow[convzx_PaperReport.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_PaperReport.Score].ToString().Trim()), //评分
OkCount = objRow[convzx_PaperReport.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperReport.OkCount].ToString().Trim()), //点赞统计
VersionCount = objRow[convzx_PaperReport.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperReport.VersionCount].ToString().Trim()), //版本统计
UpdUser = objRow[convzx_PaperReport.UpdUser] == DBNull.Value ? null : objRow[convzx_PaperReport.UpdUser].ToString().Trim(), //修改人
ReportContent = objRow[convzx_PaperReport.ReportContent] == DBNull.Value ? null : objRow[convzx_PaperReport.ReportContent].ToString().Trim(), //汇报内容
TextId = objRow[convzx_PaperReport.TextId] == DBNull.Value ? null : objRow[convzx_PaperReport.TextId].ToString().Trim(), //课件Id
IsSubmit = TransNullToBool(objRow[convzx_PaperReport.IsSubmit].ToString().Trim()), //是否提交
ReportUser = objRow[convzx_PaperReport.ReportUser] == DBNull.Value ? null : objRow[convzx_PaperReport.ReportUser].ToString().Trim(), //汇报用户
ReportDate = objRow[convzx_PaperReport.ReportDate] == DBNull.Value ? null : objRow[convzx_PaperReport.ReportDate].ToString().Trim(), //汇报日期
PPTUrl = objRow[convzx_PaperReport.PPTUrl] == DBNull.Value ? null : objRow[convzx_PaperReport.PPTUrl].ToString().Trim(), //PPTUrl
Memo = objRow[convzx_PaperReport.Memo] == DBNull.Value ? null : objRow[convzx_PaperReport.Memo].ToString().Trim(), //备注
Month = objRow[convzx_PaperReport.Month] == DBNull.Value ? null : objRow[convzx_PaperReport.Month].ToString().Trim(), //月
Week = objRow[convzx_PaperReport.Week] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperReport.Week].ToString().Trim()), //周
Year = objRow[convzx_PaperReport.Year] == DBNull.Value ? null : objRow[convzx_PaperReport.Year].ToString().Trim(), //年
AppraiseCount = objRow[convzx_PaperReport.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperReport.AppraiseCount].ToString().Trim()) //评论数
};
objvzx_PaperReportEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvzx_PaperReportEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvzx_PaperReportDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvzx_PaperReportEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvzx_PaperReportEN objvzx_PaperReportEN = new clsvzx_PaperReportEN();
try
{
objvzx_PaperReportEN.TextTitle = objRow[convzx_PaperReport.TextTitle] == DBNull.Value ? null : objRow[convzx_PaperReport.TextTitle].ToString().Trim(); //TextTitle
objvzx_PaperReportEN.GroupTextName = objRow[convzx_PaperReport.GroupTextName] == DBNull.Value ? null : objRow[convzx_PaperReport.GroupTextName].ToString().Trim(); //小组名称
objvzx_PaperReportEN.IdCurrEduCls = objRow[convzx_PaperReport.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_PaperReport.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_PaperReportEN.zxReportId = objRow[convzx_PaperReport.zxReportId].ToString().Trim(); //汇报Id
objvzx_PaperReportEN.GroupTextId = objRow[convzx_PaperReport.GroupTextId] == DBNull.Value ? null : objRow[convzx_PaperReport.GroupTextId].ToString().Trim(); //小组Id
objvzx_PaperReportEN.UpdDate = objRow[convzx_PaperReport.UpdDate] == DBNull.Value ? null : objRow[convzx_PaperReport.UpdDate].ToString().Trim(); //修改日期
objvzx_PaperReportEN.PDFUrl = objRow[convzx_PaperReport.PDFUrl] == DBNull.Value ? null : objRow[convzx_PaperReport.PDFUrl].ToString().Trim(); //PDFUrl
objvzx_PaperReportEN.TeaScore = objRow[convzx_PaperReport.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_PaperReport.TeaScore].ToString().Trim()); //教师评分
objvzx_PaperReportEN.StuScore = objRow[convzx_PaperReport.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_PaperReport.StuScore].ToString().Trim()); //学生平均分
objvzx_PaperReportEN.Score = objRow[convzx_PaperReport.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_PaperReport.Score].ToString().Trim()); //评分
objvzx_PaperReportEN.OkCount = objRow[convzx_PaperReport.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperReport.OkCount].ToString().Trim()); //点赞统计
objvzx_PaperReportEN.VersionCount = objRow[convzx_PaperReport.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperReport.VersionCount].ToString().Trim()); //版本统计
objvzx_PaperReportEN.UpdUser = objRow[convzx_PaperReport.UpdUser] == DBNull.Value ? null : objRow[convzx_PaperReport.UpdUser].ToString().Trim(); //修改人
objvzx_PaperReportEN.ReportContent = objRow[convzx_PaperReport.ReportContent] == DBNull.Value ? null : objRow[convzx_PaperReport.ReportContent].ToString().Trim(); //汇报内容
objvzx_PaperReportEN.TextId = objRow[convzx_PaperReport.TextId] == DBNull.Value ? null : objRow[convzx_PaperReport.TextId].ToString().Trim(); //课件Id
objvzx_PaperReportEN.IsSubmit = TransNullToBool(objRow[convzx_PaperReport.IsSubmit].ToString().Trim()); //是否提交
objvzx_PaperReportEN.ReportUser = objRow[convzx_PaperReport.ReportUser] == DBNull.Value ? null : objRow[convzx_PaperReport.ReportUser].ToString().Trim(); //汇报用户
objvzx_PaperReportEN.ReportDate = objRow[convzx_PaperReport.ReportDate] == DBNull.Value ? null : objRow[convzx_PaperReport.ReportDate].ToString().Trim(); //汇报日期
objvzx_PaperReportEN.PPTUrl = objRow[convzx_PaperReport.PPTUrl] == DBNull.Value ? null : objRow[convzx_PaperReport.PPTUrl].ToString().Trim(); //PPTUrl
objvzx_PaperReportEN.Memo = objRow[convzx_PaperReport.Memo] == DBNull.Value ? null : objRow[convzx_PaperReport.Memo].ToString().Trim(); //备注
objvzx_PaperReportEN.Month = objRow[convzx_PaperReport.Month] == DBNull.Value ? null : objRow[convzx_PaperReport.Month].ToString().Trim(); //月
objvzx_PaperReportEN.Week = objRow[convzx_PaperReport.Week] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperReport.Week].ToString().Trim()); //周
objvzx_PaperReportEN.Year = objRow[convzx_PaperReport.Year] == DBNull.Value ? null : objRow[convzx_PaperReport.Year].ToString().Trim(); //年
objvzx_PaperReportEN.AppraiseCount = objRow[convzx_PaperReport.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperReport.AppraiseCount].ToString().Trim()); //评论数
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvzx_PaperReportDA: GetObjByDataRowvzx_PaperReport)", objException.Message));
}
objvzx_PaperReportEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvzx_PaperReportEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvzx_PaperReportEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvzx_PaperReportEN objvzx_PaperReportEN = new clsvzx_PaperReportEN();
try
{
objvzx_PaperReportEN.TextTitle = objRow[convzx_PaperReport.TextTitle] == DBNull.Value ? null : objRow[convzx_PaperReport.TextTitle].ToString().Trim(); //TextTitle
objvzx_PaperReportEN.GroupTextName = objRow[convzx_PaperReport.GroupTextName] == DBNull.Value ? null : objRow[convzx_PaperReport.GroupTextName].ToString().Trim(); //小组名称
objvzx_PaperReportEN.IdCurrEduCls = objRow[convzx_PaperReport.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_PaperReport.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_PaperReportEN.zxReportId = objRow[convzx_PaperReport.zxReportId].ToString().Trim(); //汇报Id
objvzx_PaperReportEN.GroupTextId = objRow[convzx_PaperReport.GroupTextId] == DBNull.Value ? null : objRow[convzx_PaperReport.GroupTextId].ToString().Trim(); //小组Id
objvzx_PaperReportEN.UpdDate = objRow[convzx_PaperReport.UpdDate] == DBNull.Value ? null : objRow[convzx_PaperReport.UpdDate].ToString().Trim(); //修改日期
objvzx_PaperReportEN.PDFUrl = objRow[convzx_PaperReport.PDFUrl] == DBNull.Value ? null : objRow[convzx_PaperReport.PDFUrl].ToString().Trim(); //PDFUrl
objvzx_PaperReportEN.TeaScore = objRow[convzx_PaperReport.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_PaperReport.TeaScore].ToString().Trim()); //教师评分
objvzx_PaperReportEN.StuScore = objRow[convzx_PaperReport.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_PaperReport.StuScore].ToString().Trim()); //学生平均分
objvzx_PaperReportEN.Score = objRow[convzx_PaperReport.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_PaperReport.Score].ToString().Trim()); //评分
objvzx_PaperReportEN.OkCount = objRow[convzx_PaperReport.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperReport.OkCount].ToString().Trim()); //点赞统计
objvzx_PaperReportEN.VersionCount = objRow[convzx_PaperReport.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperReport.VersionCount].ToString().Trim()); //版本统计
objvzx_PaperReportEN.UpdUser = objRow[convzx_PaperReport.UpdUser] == DBNull.Value ? null : objRow[convzx_PaperReport.UpdUser].ToString().Trim(); //修改人
objvzx_PaperReportEN.ReportContent = objRow[convzx_PaperReport.ReportContent] == DBNull.Value ? null : objRow[convzx_PaperReport.ReportContent].ToString().Trim(); //汇报内容
objvzx_PaperReportEN.TextId = objRow[convzx_PaperReport.TextId] == DBNull.Value ? null : objRow[convzx_PaperReport.TextId].ToString().Trim(); //课件Id
objvzx_PaperReportEN.IsSubmit = TransNullToBool(objRow[convzx_PaperReport.IsSubmit].ToString().Trim()); //是否提交
objvzx_PaperReportEN.ReportUser = objRow[convzx_PaperReport.ReportUser] == DBNull.Value ? null : objRow[convzx_PaperReport.ReportUser].ToString().Trim(); //汇报用户
objvzx_PaperReportEN.ReportDate = objRow[convzx_PaperReport.ReportDate] == DBNull.Value ? null : objRow[convzx_PaperReport.ReportDate].ToString().Trim(); //汇报日期
objvzx_PaperReportEN.PPTUrl = objRow[convzx_PaperReport.PPTUrl] == DBNull.Value ? null : objRow[convzx_PaperReport.PPTUrl].ToString().Trim(); //PPTUrl
objvzx_PaperReportEN.Memo = objRow[convzx_PaperReport.Memo] == DBNull.Value ? null : objRow[convzx_PaperReport.Memo].ToString().Trim(); //备注
objvzx_PaperReportEN.Month = objRow[convzx_PaperReport.Month] == DBNull.Value ? null : objRow[convzx_PaperReport.Month].ToString().Trim(); //月
objvzx_PaperReportEN.Week = objRow[convzx_PaperReport.Week] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperReport.Week].ToString().Trim()); //周
objvzx_PaperReportEN.Year = objRow[convzx_PaperReport.Year] == DBNull.Value ? null : objRow[convzx_PaperReport.Year].ToString().Trim(); //年
objvzx_PaperReportEN.AppraiseCount = objRow[convzx_PaperReport.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperReport.AppraiseCount].ToString().Trim()); //评论数
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvzx_PaperReportDA: GetObjByDataRow)", objException.Message));
}
objvzx_PaperReportEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvzx_PaperReportEN;
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
objSQL = clsvzx_PaperReportDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvzx_PaperReportEN._CurrTabName, convzx_PaperReport.zxReportId, 10, "");
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
objSQL = clsvzx_PaperReportDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvzx_PaperReportEN._CurrTabName, convzx_PaperReport.zxReportId, 10, strPrefix);
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
 objSQL = clsvzx_PaperReportDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select zxReportId from vzx_PaperReport where " + strCondition;
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
 objSQL = clsvzx_PaperReportDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select zxReportId from vzx_PaperReport where " + strCondition;
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
 objSQL = clsvzx_PaperReportDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vzx_PaperReport", "zxReportId = " + "'"+ strzxReportId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvzx_PaperReportDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_PaperReportDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vzx_PaperReport", strCondition))
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
objSQL = clsvzx_PaperReportDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vzx_PaperReport");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvzx_PaperReportENS">源对象</param>
 /// <param name = "objvzx_PaperReportENT">目标对象</param>
public void CopyTo(clsvzx_PaperReportEN objvzx_PaperReportENS, clsvzx_PaperReportEN objvzx_PaperReportENT)
{
objvzx_PaperReportENT.TextTitle = objvzx_PaperReportENS.TextTitle; //TextTitle
objvzx_PaperReportENT.GroupTextName = objvzx_PaperReportENS.GroupTextName; //小组名称
objvzx_PaperReportENT.IdCurrEduCls = objvzx_PaperReportENS.IdCurrEduCls; //教学班流水号
objvzx_PaperReportENT.zxReportId = objvzx_PaperReportENS.zxReportId; //汇报Id
objvzx_PaperReportENT.GroupTextId = objvzx_PaperReportENS.GroupTextId; //小组Id
objvzx_PaperReportENT.UpdDate = objvzx_PaperReportENS.UpdDate; //修改日期
objvzx_PaperReportENT.PDFUrl = objvzx_PaperReportENS.PDFUrl; //PDFUrl
objvzx_PaperReportENT.TeaScore = objvzx_PaperReportENS.TeaScore; //教师评分
objvzx_PaperReportENT.StuScore = objvzx_PaperReportENS.StuScore; //学生平均分
objvzx_PaperReportENT.Score = objvzx_PaperReportENS.Score; //评分
objvzx_PaperReportENT.OkCount = objvzx_PaperReportENS.OkCount; //点赞统计
objvzx_PaperReportENT.VersionCount = objvzx_PaperReportENS.VersionCount; //版本统计
objvzx_PaperReportENT.UpdUser = objvzx_PaperReportENS.UpdUser; //修改人
objvzx_PaperReportENT.ReportContent = objvzx_PaperReportENS.ReportContent; //汇报内容
objvzx_PaperReportENT.TextId = objvzx_PaperReportENS.TextId; //课件Id
objvzx_PaperReportENT.IsSubmit = objvzx_PaperReportENS.IsSubmit; //是否提交
objvzx_PaperReportENT.ReportUser = objvzx_PaperReportENS.ReportUser; //汇报用户
objvzx_PaperReportENT.ReportDate = objvzx_PaperReportENS.ReportDate; //汇报日期
objvzx_PaperReportENT.PPTUrl = objvzx_PaperReportENS.PPTUrl; //PPTUrl
objvzx_PaperReportENT.Memo = objvzx_PaperReportENS.Memo; //备注
objvzx_PaperReportENT.Month = objvzx_PaperReportENS.Month; //月
objvzx_PaperReportENT.Week = objvzx_PaperReportENS.Week; //周
objvzx_PaperReportENT.Year = objvzx_PaperReportENS.Year; //年
objvzx_PaperReportENT.AppraiseCount = objvzx_PaperReportENS.AppraiseCount; //评论数
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvzx_PaperReportEN objvzx_PaperReportEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvzx_PaperReportEN.TextTitle, 500, convzx_PaperReport.TextTitle);
clsCheckSql.CheckFieldLen(objvzx_PaperReportEN.GroupTextName, 2000, convzx_PaperReport.GroupTextName);
clsCheckSql.CheckFieldLen(objvzx_PaperReportEN.IdCurrEduCls, 8, convzx_PaperReport.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objvzx_PaperReportEN.zxReportId, 10, convzx_PaperReport.zxReportId);
clsCheckSql.CheckFieldLen(objvzx_PaperReportEN.GroupTextId, 8, convzx_PaperReport.GroupTextId);
clsCheckSql.CheckFieldLen(objvzx_PaperReportEN.UpdDate, 20, convzx_PaperReport.UpdDate);
clsCheckSql.CheckFieldLen(objvzx_PaperReportEN.PDFUrl, 500, convzx_PaperReport.PDFUrl);
clsCheckSql.CheckFieldLen(objvzx_PaperReportEN.UpdUser, 20, convzx_PaperReport.UpdUser);
clsCheckSql.CheckFieldLen(objvzx_PaperReportEN.ReportContent, 5000, convzx_PaperReport.ReportContent);
clsCheckSql.CheckFieldLen(objvzx_PaperReportEN.TextId, 8, convzx_PaperReport.TextId);
clsCheckSql.CheckFieldLen(objvzx_PaperReportEN.ReportUser, 500, convzx_PaperReport.ReportUser);
clsCheckSql.CheckFieldLen(objvzx_PaperReportEN.ReportDate, 20, convzx_PaperReport.ReportDate);
clsCheckSql.CheckFieldLen(objvzx_PaperReportEN.PPTUrl, 500, convzx_PaperReport.PPTUrl);
clsCheckSql.CheckFieldLen(objvzx_PaperReportEN.Memo, 1000, convzx_PaperReport.Memo);
clsCheckSql.CheckFieldLen(objvzx_PaperReportEN.Month, 2, convzx_PaperReport.Month);
clsCheckSql.CheckFieldLen(objvzx_PaperReportEN.Year, 4, convzx_PaperReport.Year);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvzx_PaperReportEN.TextTitle, convzx_PaperReport.TextTitle);
clsCheckSql.CheckSqlInjection4Field(objvzx_PaperReportEN.GroupTextName, convzx_PaperReport.GroupTextName);
clsCheckSql.CheckSqlInjection4Field(objvzx_PaperReportEN.IdCurrEduCls, convzx_PaperReport.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objvzx_PaperReportEN.zxReportId, convzx_PaperReport.zxReportId);
clsCheckSql.CheckSqlInjection4Field(objvzx_PaperReportEN.GroupTextId, convzx_PaperReport.GroupTextId);
clsCheckSql.CheckSqlInjection4Field(objvzx_PaperReportEN.UpdDate, convzx_PaperReport.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvzx_PaperReportEN.PDFUrl, convzx_PaperReport.PDFUrl);
clsCheckSql.CheckSqlInjection4Field(objvzx_PaperReportEN.UpdUser, convzx_PaperReport.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvzx_PaperReportEN.ReportContent, convzx_PaperReport.ReportContent);
clsCheckSql.CheckSqlInjection4Field(objvzx_PaperReportEN.TextId, convzx_PaperReport.TextId);
clsCheckSql.CheckSqlInjection4Field(objvzx_PaperReportEN.ReportUser, convzx_PaperReport.ReportUser);
clsCheckSql.CheckSqlInjection4Field(objvzx_PaperReportEN.ReportDate, convzx_PaperReport.ReportDate);
clsCheckSql.CheckSqlInjection4Field(objvzx_PaperReportEN.PPTUrl, convzx_PaperReport.PPTUrl);
clsCheckSql.CheckSqlInjection4Field(objvzx_PaperReportEN.Memo, convzx_PaperReport.Memo);
clsCheckSql.CheckSqlInjection4Field(objvzx_PaperReportEN.Month, convzx_PaperReport.Month);
clsCheckSql.CheckSqlInjection4Field(objvzx_PaperReportEN.Year, convzx_PaperReport.Year);
//检查外键字段长度
 objvzx_PaperReportEN._IsCheckProperty = true;
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
 objSQL = clsvzx_PaperReportDA.GetSpecSQLObj();
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
 objSQL = clsvzx_PaperReportDA.GetSpecSQLObj();
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
 objSQL = clsvzx_PaperReportDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvzx_PaperReportEN._CurrTabName);
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
 objSQL = clsvzx_PaperReportDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvzx_PaperReportEN._CurrTabName, strCondition);
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
 objSQL = clsvzx_PaperReportDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}