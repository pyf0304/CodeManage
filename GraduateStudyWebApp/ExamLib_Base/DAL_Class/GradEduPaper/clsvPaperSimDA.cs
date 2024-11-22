
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPaperSimDA
 表名:vPaperSim(01120597)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:48:27
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培论文(GradEduPaper)
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
 /// 论文简化视图(vPaperSim)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvPaperSimDA : clsCommBase4DA
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
 return clsvPaperSimEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvPaperSimEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvPaperSimEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvPaperSimEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvPaperSimEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strPaperId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strPaperId)
{
strPaperId = strPaperId.Replace("'", "''");
if (strPaperId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vPaperSim中,检查关键字,长度不正确!(clsvPaperSimDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strPaperId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vPaperSim中,关键字不能为空 或 null!(clsvPaperSimDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strPaperId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvPaperSimDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvPaperSimDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperSimDA.GetSpecSQLObj();
strSQL = "Select * from vPaperSim where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vPaperSim(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvPaperSimDA: GetDataTable_vPaperSim)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperSimDA.GetSpecSQLObj();
strSQL = "Select * from vPaperSim where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvPaperSimDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperSimDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvPaperSimDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperSimDA.GetSpecSQLObj();
strSQL = "Select * from vPaperSim where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvPaperSimDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperSimDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvPaperSimDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperSimDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPaperSim where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPaperSim where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvPaperSimDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperSimDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vPaperSim where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvPaperSimDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperSimDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vPaperSim.* from vPaperSim Left Join {1} on {2} where {3} and vPaperSim.PaperId not in (Select top {5} vPaperSim.PaperId from vPaperSim Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPaperSim where {1} and PaperId not in (Select top {2} PaperId from vPaperSim where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPaperSim where {1} and PaperId not in (Select top {3} PaperId from vPaperSim where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvPaperSimDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperSimDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vPaperSim.* from vPaperSim Left Join {1} on {2} where {3} and vPaperSim.PaperId not in (Select top {5} vPaperSim.PaperId from vPaperSim Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPaperSim where {1} and PaperId not in (Select top {2} PaperId from vPaperSim where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPaperSim where {1} and PaperId not in (Select top {3} PaperId from vPaperSim where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvPaperSimEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvPaperSimDA:GetObjLst)", objException.Message));
}
List<clsvPaperSimEN> arrObjLst = new List<clsvPaperSimEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperSimDA.GetSpecSQLObj();
strSQL = "Select * from vPaperSim where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperSimEN objvPaperSimEN = new clsvPaperSimEN();
try
{
objvPaperSimEN.PaperId = objRow[convPaperSim.PaperId].ToString().Trim(); //论文Id
objvPaperSimEN.PaperTitle = objRow[convPaperSim.PaperTitle].ToString().Trim(); //论文标题
objvPaperSimEN.PaperContent = objRow[convPaperSim.PaperContent] == DBNull.Value ? null : objRow[convPaperSim.PaperContent].ToString().Trim(); //主题内容
objvPaperSimEN.Periodical = objRow[convPaperSim.Periodical] == DBNull.Value ? null : objRow[convPaperSim.Periodical].ToString().Trim(); //期刊
objvPaperSimEN.Author = objRow[convPaperSim.Author] == DBNull.Value ? null : objRow[convPaperSim.Author].ToString().Trim(); //作者
objvPaperSimEN.ResearchQuestion = objRow[convPaperSim.ResearchQuestion] == DBNull.Value ? null : objRow[convPaperSim.ResearchQuestion].ToString().Trim(); //研究问题
objvPaperSimEN.UpdDate = objRow[convPaperSim.UpdDate].ToString().Trim(); //修改日期
objvPaperSimEN.UserName = objRow[convPaperSim.UserName] == DBNull.Value ? null : objRow[convPaperSim.UserName].ToString().Trim(); //用户名
objvPaperSimEN.IdXzCollege = objRow[convPaperSim.IdXzCollege] == DBNull.Value ? null : objRow[convPaperSim.IdXzCollege].ToString().Trim(); //学院流水号
objvPaperSimEN.CollegeName = objRow[convPaperSim.CollegeName] == DBNull.Value ? null : objRow[convPaperSim.CollegeName].ToString().Trim(); //学院名称
objvPaperSimEN.IdXzMajor = objRow[convPaperSim.IdXzMajor] == DBNull.Value ? null : objRow[convPaperSim.IdXzMajor].ToString().Trim(); //专业流水号
objvPaperSimEN.MajorName = objRow[convPaperSim.MajorName] == DBNull.Value ? null : objRow[convPaperSim.MajorName].ToString().Trim(); //专业名称
objvPaperSimEN.Keyword = objRow[convPaperSim.Keyword] == DBNull.Value ? null : objRow[convPaperSim.Keyword].ToString().Trim(); //关键字
objvPaperSimEN.LiteratureSources = objRow[convPaperSim.LiteratureSources] == DBNull.Value ? null : objRow[convPaperSim.LiteratureSources].ToString().Trim(); //文献来源
objvPaperSimEN.LiteratureLink = objRow[convPaperSim.LiteratureLink] == DBNull.Value ? null : objRow[convPaperSim.LiteratureLink].ToString().Trim(); //文献链接
objvPaperSimEN.UploadfileUrl = objRow[convPaperSim.UploadfileUrl] == DBNull.Value ? null : objRow[convPaperSim.UploadfileUrl].ToString().Trim(); //文件地址
objvPaperSimEN.IsQuotethesis = TransNullToBool(objRow[convPaperSim.IsQuotethesis].ToString().Trim()); //是否引用论文
objvPaperSimEN.QuoteId = objRow[convPaperSim.QuoteId] == DBNull.Value ? null : objRow[convPaperSim.QuoteId].ToString().Trim(); //引用Id
objvPaperSimEN.Checker = objRow[convPaperSim.Checker] == DBNull.Value ? null : objRow[convPaperSim.Checker].ToString().Trim(); //审核人
objvPaperSimEN.IsChecked = TransNullToBool(objRow[convPaperSim.IsChecked].ToString().Trim()); //是否检查
objvPaperSimEN.LiteratureTypeId = objRow[convPaperSim.LiteratureTypeId].ToString().Trim(); //作文类型Id
objvPaperSimEN.BrowseNumber = objRow[convPaperSim.BrowseNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSim.BrowseNumber].ToString().Trim()); //浏览量
objvPaperSimEN.LiteratureTypeName = objRow[convPaperSim.LiteratureTypeName] == DBNull.Value ? null : objRow[convPaperSim.LiteratureTypeName].ToString().Trim(); //作文类型名
objvPaperSimEN.IsSubmit = TransNullToBool(objRow[convPaperSim.IsSubmit].ToString().Trim()); //是否提交
objvPaperSimEN.AppraiseCount = objRow[convPaperSim.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSim.AppraiseCount].ToString().Trim()); //评论数
objvPaperSimEN.AttachmentCount = objRow[convPaperSim.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSim.AttachmentCount].ToString().Trim()); //附件计数
objvPaperSimEN.CollectionCount = objRow[convPaperSim.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convPaperSim.CollectionCount].ToString().Trim()); //收藏数量
objvPaperSimEN.DownloadCount = objRow[convPaperSim.DownloadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSim.DownloadCount].ToString().Trim()); //下载数
objvPaperSimEN.Memo = objRow[convPaperSim.Memo] == DBNull.Value ? null : objRow[convPaperSim.Memo].ToString().Trim(); //备注
objvPaperSimEN.OkCount = objRow[convPaperSim.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSim.OkCount].ToString().Trim()); //点赞统计
objvPaperSimEN.Pcount = objRow[convPaperSim.Pcount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSim.Pcount].ToString().Trim()); //读写数
objvPaperSimEN.Score = objRow[convPaperSim.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPaperSim.Score].ToString().Trim()); //评分
objvPaperSimEN.StuScore = objRow[convPaperSim.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPaperSim.StuScore].ToString().Trim()); //学生平均分
objvPaperSimEN.TeaScore = objRow[convPaperSim.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPaperSim.TeaScore].ToString().Trim()); //教师评分
objvPaperSimEN.PaperQCount = objRow[convPaperSim.PaperQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSim.PaperQCount].ToString().Trim()); //论文答疑数
objvPaperSimEN.SubVCount = objRow[convPaperSim.SubVCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSim.SubVCount].ToString().Trim()); //论文子观点数
objvPaperSimEN.TagsCount = objRow[convPaperSim.TagsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSim.TagsCount].ToString().Trim()); //论文标注数
objvPaperSimEN.TeaQCount = objRow[convPaperSim.TeaQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSim.TeaQCount].ToString().Trim()); //教师提问数
objvPaperSimEN.UpdUser = objRow[convPaperSim.UpdUser] == DBNull.Value ? null : objRow[convPaperSim.UpdUser].ToString().Trim(); //修改人
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvPaperSimDA: GetObjLst)", objException.Message));
}
objvPaperSimEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvPaperSimEN);
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
public List<clsvPaperSimEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvPaperSimDA:GetObjLstByTabName)", objException.Message));
}
List<clsvPaperSimEN> arrObjLst = new List<clsvPaperSimEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperSimDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperSimEN objvPaperSimEN = new clsvPaperSimEN();
try
{
objvPaperSimEN.PaperId = objRow[convPaperSim.PaperId].ToString().Trim(); //论文Id
objvPaperSimEN.PaperTitle = objRow[convPaperSim.PaperTitle].ToString().Trim(); //论文标题
objvPaperSimEN.PaperContent = objRow[convPaperSim.PaperContent] == DBNull.Value ? null : objRow[convPaperSim.PaperContent].ToString().Trim(); //主题内容
objvPaperSimEN.Periodical = objRow[convPaperSim.Periodical] == DBNull.Value ? null : objRow[convPaperSim.Periodical].ToString().Trim(); //期刊
objvPaperSimEN.Author = objRow[convPaperSim.Author] == DBNull.Value ? null : objRow[convPaperSim.Author].ToString().Trim(); //作者
objvPaperSimEN.ResearchQuestion = objRow[convPaperSim.ResearchQuestion] == DBNull.Value ? null : objRow[convPaperSim.ResearchQuestion].ToString().Trim(); //研究问题
objvPaperSimEN.UpdDate = objRow[convPaperSim.UpdDate].ToString().Trim(); //修改日期
objvPaperSimEN.UserName = objRow[convPaperSim.UserName] == DBNull.Value ? null : objRow[convPaperSim.UserName].ToString().Trim(); //用户名
objvPaperSimEN.IdXzCollege = objRow[convPaperSim.IdXzCollege] == DBNull.Value ? null : objRow[convPaperSim.IdXzCollege].ToString().Trim(); //学院流水号
objvPaperSimEN.CollegeName = objRow[convPaperSim.CollegeName] == DBNull.Value ? null : objRow[convPaperSim.CollegeName].ToString().Trim(); //学院名称
objvPaperSimEN.IdXzMajor = objRow[convPaperSim.IdXzMajor] == DBNull.Value ? null : objRow[convPaperSim.IdXzMajor].ToString().Trim(); //专业流水号
objvPaperSimEN.MajorName = objRow[convPaperSim.MajorName] == DBNull.Value ? null : objRow[convPaperSim.MajorName].ToString().Trim(); //专业名称
objvPaperSimEN.Keyword = objRow[convPaperSim.Keyword] == DBNull.Value ? null : objRow[convPaperSim.Keyword].ToString().Trim(); //关键字
objvPaperSimEN.LiteratureSources = objRow[convPaperSim.LiteratureSources] == DBNull.Value ? null : objRow[convPaperSim.LiteratureSources].ToString().Trim(); //文献来源
objvPaperSimEN.LiteratureLink = objRow[convPaperSim.LiteratureLink] == DBNull.Value ? null : objRow[convPaperSim.LiteratureLink].ToString().Trim(); //文献链接
objvPaperSimEN.UploadfileUrl = objRow[convPaperSim.UploadfileUrl] == DBNull.Value ? null : objRow[convPaperSim.UploadfileUrl].ToString().Trim(); //文件地址
objvPaperSimEN.IsQuotethesis = TransNullToBool(objRow[convPaperSim.IsQuotethesis].ToString().Trim()); //是否引用论文
objvPaperSimEN.QuoteId = objRow[convPaperSim.QuoteId] == DBNull.Value ? null : objRow[convPaperSim.QuoteId].ToString().Trim(); //引用Id
objvPaperSimEN.Checker = objRow[convPaperSim.Checker] == DBNull.Value ? null : objRow[convPaperSim.Checker].ToString().Trim(); //审核人
objvPaperSimEN.IsChecked = TransNullToBool(objRow[convPaperSim.IsChecked].ToString().Trim()); //是否检查
objvPaperSimEN.LiteratureTypeId = objRow[convPaperSim.LiteratureTypeId].ToString().Trim(); //作文类型Id
objvPaperSimEN.BrowseNumber = objRow[convPaperSim.BrowseNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSim.BrowseNumber].ToString().Trim()); //浏览量
objvPaperSimEN.LiteratureTypeName = objRow[convPaperSim.LiteratureTypeName] == DBNull.Value ? null : objRow[convPaperSim.LiteratureTypeName].ToString().Trim(); //作文类型名
objvPaperSimEN.IsSubmit = TransNullToBool(objRow[convPaperSim.IsSubmit].ToString().Trim()); //是否提交
objvPaperSimEN.AppraiseCount = objRow[convPaperSim.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSim.AppraiseCount].ToString().Trim()); //评论数
objvPaperSimEN.AttachmentCount = objRow[convPaperSim.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSim.AttachmentCount].ToString().Trim()); //附件计数
objvPaperSimEN.CollectionCount = objRow[convPaperSim.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convPaperSim.CollectionCount].ToString().Trim()); //收藏数量
objvPaperSimEN.DownloadCount = objRow[convPaperSim.DownloadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSim.DownloadCount].ToString().Trim()); //下载数
objvPaperSimEN.Memo = objRow[convPaperSim.Memo] == DBNull.Value ? null : objRow[convPaperSim.Memo].ToString().Trim(); //备注
objvPaperSimEN.OkCount = objRow[convPaperSim.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSim.OkCount].ToString().Trim()); //点赞统计
objvPaperSimEN.Pcount = objRow[convPaperSim.Pcount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSim.Pcount].ToString().Trim()); //读写数
objvPaperSimEN.Score = objRow[convPaperSim.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPaperSim.Score].ToString().Trim()); //评分
objvPaperSimEN.StuScore = objRow[convPaperSim.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPaperSim.StuScore].ToString().Trim()); //学生平均分
objvPaperSimEN.TeaScore = objRow[convPaperSim.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPaperSim.TeaScore].ToString().Trim()); //教师评分
objvPaperSimEN.PaperQCount = objRow[convPaperSim.PaperQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSim.PaperQCount].ToString().Trim()); //论文答疑数
objvPaperSimEN.SubVCount = objRow[convPaperSim.SubVCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSim.SubVCount].ToString().Trim()); //论文子观点数
objvPaperSimEN.TagsCount = objRow[convPaperSim.TagsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSim.TagsCount].ToString().Trim()); //论文标注数
objvPaperSimEN.TeaQCount = objRow[convPaperSim.TeaQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSim.TeaQCount].ToString().Trim()); //教师提问数
objvPaperSimEN.UpdUser = objRow[convPaperSim.UpdUser] == DBNull.Value ? null : objRow[convPaperSim.UpdUser].ToString().Trim(); //修改人
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvPaperSimDA: GetObjLst)", objException.Message));
}
objvPaperSimEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvPaperSimEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvPaperSim(ref clsvPaperSimEN objvPaperSimEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperSimDA.GetSpecSQLObj();
strSQL = "Select * from vPaperSim where PaperId = " + "'"+ objvPaperSimEN.PaperId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvPaperSimEN.PaperId = objDT.Rows[0][convPaperSim.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objvPaperSimEN.PaperTitle = objDT.Rows[0][convPaperSim.PaperTitle].ToString().Trim(); //论文标题(字段类型:varchar,字段长度:500,是否可空:False)
 objvPaperSimEN.PaperContent = objDT.Rows[0][convPaperSim.PaperContent].ToString().Trim(); //主题内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvPaperSimEN.Periodical = objDT.Rows[0][convPaperSim.Periodical].ToString().Trim(); //期刊(字段类型:varchar,字段长度:100,是否可空:True)
 objvPaperSimEN.Author = objDT.Rows[0][convPaperSim.Author].ToString().Trim(); //作者(字段类型:varchar,字段长度:200,是否可空:True)
 objvPaperSimEN.ResearchQuestion = objDT.Rows[0][convPaperSim.ResearchQuestion].ToString().Trim(); //研究问题(字段类型:varchar,字段长度:2000,是否可空:True)
 objvPaperSimEN.UpdDate = objDT.Rows[0][convPaperSim.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvPaperSimEN.UserName = objDT.Rows[0][convPaperSim.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvPaperSimEN.IdXzCollege = objDT.Rows[0][convPaperSim.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvPaperSimEN.CollegeName = objDT.Rows[0][convPaperSim.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvPaperSimEN.IdXzMajor = objDT.Rows[0][convPaperSim.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvPaperSimEN.MajorName = objDT.Rows[0][convPaperSim.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvPaperSimEN.Keyword = objDT.Rows[0][convPaperSim.Keyword].ToString().Trim(); //关键字(字段类型:varchar,字段长度:1000,是否可空:True)
 objvPaperSimEN.LiteratureSources = objDT.Rows[0][convPaperSim.LiteratureSources].ToString().Trim(); //文献来源(字段类型:varchar,字段长度:1000,是否可空:True)
 objvPaperSimEN.LiteratureLink = objDT.Rows[0][convPaperSim.LiteratureLink].ToString().Trim(); //文献链接(字段类型:varchar,字段长度:1000,是否可空:True)
 objvPaperSimEN.UploadfileUrl = objDT.Rows[0][convPaperSim.UploadfileUrl].ToString().Trim(); //文件地址(字段类型:varchar,字段长度:1000,是否可空:True)
 objvPaperSimEN.IsQuotethesis = TransNullToBool(objDT.Rows[0][convPaperSim.IsQuotethesis].ToString().Trim()); //是否引用论文(字段类型:bit,字段长度:1,是否可空:True)
 objvPaperSimEN.QuoteId = objDT.Rows[0][convPaperSim.QuoteId].ToString().Trim(); //引用Id(字段类型:char,字段长度:8,是否可空:True)
 objvPaperSimEN.Checker = objDT.Rows[0][convPaperSim.Checker].ToString().Trim(); //审核人(字段类型:varchar,字段长度:20,是否可空:True)
 objvPaperSimEN.IsChecked = TransNullToBool(objDT.Rows[0][convPaperSim.IsChecked].ToString().Trim()); //是否检查(字段类型:bit,字段长度:1,是否可空:True)
 objvPaperSimEN.LiteratureTypeId = objDT.Rows[0][convPaperSim.LiteratureTypeId].ToString().Trim(); //作文类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvPaperSimEN.BrowseNumber = TransNullToInt(objDT.Rows[0][convPaperSim.BrowseNumber].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvPaperSimEN.LiteratureTypeName = objDT.Rows[0][convPaperSim.LiteratureTypeName].ToString().Trim(); //作文类型名(字段类型:varchar,字段长度:100,是否可空:True)
 objvPaperSimEN.IsSubmit = TransNullToBool(objDT.Rows[0][convPaperSim.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvPaperSimEN.AppraiseCount = TransNullToInt(objDT.Rows[0][convPaperSim.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objvPaperSimEN.AttachmentCount = TransNullToInt(objDT.Rows[0][convPaperSim.AttachmentCount].ToString().Trim()); //附件计数(字段类型:int,字段长度:4,是否可空:True)
 objvPaperSimEN.CollectionCount = TransNullToInt(objDT.Rows[0][convPaperSim.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvPaperSimEN.DownloadCount = TransNullToInt(objDT.Rows[0][convPaperSim.DownloadCount].ToString().Trim()); //下载数(字段类型:int,字段长度:4,是否可空:True)
 objvPaperSimEN.Memo = objDT.Rows[0][convPaperSim.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvPaperSimEN.OkCount = TransNullToInt(objDT.Rows[0][convPaperSim.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objvPaperSimEN.Pcount = TransNullToInt(objDT.Rows[0][convPaperSim.Pcount].ToString().Trim()); //读写数(字段类型:int,字段长度:4,是否可空:True)
 objvPaperSimEN.Score = TransNullToFloat(objDT.Rows[0][convPaperSim.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvPaperSimEN.StuScore = TransNullToFloat(objDT.Rows[0][convPaperSim.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objvPaperSimEN.TeaScore = TransNullToFloat(objDT.Rows[0][convPaperSim.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objvPaperSimEN.PaperQCount = TransNullToInt(objDT.Rows[0][convPaperSim.PaperQCount].ToString().Trim()); //论文答疑数(字段类型:int,字段长度:4,是否可空:True)
 objvPaperSimEN.SubVCount = TransNullToInt(objDT.Rows[0][convPaperSim.SubVCount].ToString().Trim()); //论文子观点数(字段类型:int,字段长度:4,是否可空:True)
 objvPaperSimEN.TagsCount = TransNullToInt(objDT.Rows[0][convPaperSim.TagsCount].ToString().Trim()); //论文标注数(字段类型:int,字段长度:4,是否可空:True)
 objvPaperSimEN.TeaQCount = TransNullToInt(objDT.Rows[0][convPaperSim.TeaQCount].ToString().Trim()); //教师提问数(字段类型:int,字段长度:4,是否可空:True)
 objvPaperSimEN.UpdUser = objDT.Rows[0][convPaperSim.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvPaperSimDA: GetvPaperSim)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strPaperId">表关键字</param>
 /// <returns>表对象</returns>
public clsvPaperSimEN GetObjByPaperId(string strPaperId)
{
CheckPrimaryKey(strPaperId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperSimDA.GetSpecSQLObj();
strSQL = "Select * from vPaperSim where PaperId = " + "'"+ strPaperId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvPaperSimEN objvPaperSimEN = new clsvPaperSimEN();
try
{
 objvPaperSimEN.PaperId = objRow[convPaperSim.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objvPaperSimEN.PaperTitle = objRow[convPaperSim.PaperTitle].ToString().Trim(); //论文标题(字段类型:varchar,字段长度:500,是否可空:False)
 objvPaperSimEN.PaperContent = objRow[convPaperSim.PaperContent] == DBNull.Value ? null : objRow[convPaperSim.PaperContent].ToString().Trim(); //主题内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvPaperSimEN.Periodical = objRow[convPaperSim.Periodical] == DBNull.Value ? null : objRow[convPaperSim.Periodical].ToString().Trim(); //期刊(字段类型:varchar,字段长度:100,是否可空:True)
 objvPaperSimEN.Author = objRow[convPaperSim.Author] == DBNull.Value ? null : objRow[convPaperSim.Author].ToString().Trim(); //作者(字段类型:varchar,字段长度:200,是否可空:True)
 objvPaperSimEN.ResearchQuestion = objRow[convPaperSim.ResearchQuestion] == DBNull.Value ? null : objRow[convPaperSim.ResearchQuestion].ToString().Trim(); //研究问题(字段类型:varchar,字段长度:2000,是否可空:True)
 objvPaperSimEN.UpdDate = objRow[convPaperSim.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvPaperSimEN.UserName = objRow[convPaperSim.UserName] == DBNull.Value ? null : objRow[convPaperSim.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvPaperSimEN.IdXzCollege = objRow[convPaperSim.IdXzCollege] == DBNull.Value ? null : objRow[convPaperSim.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvPaperSimEN.CollegeName = objRow[convPaperSim.CollegeName] == DBNull.Value ? null : objRow[convPaperSim.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvPaperSimEN.IdXzMajor = objRow[convPaperSim.IdXzMajor] == DBNull.Value ? null : objRow[convPaperSim.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvPaperSimEN.MajorName = objRow[convPaperSim.MajorName] == DBNull.Value ? null : objRow[convPaperSim.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvPaperSimEN.Keyword = objRow[convPaperSim.Keyword] == DBNull.Value ? null : objRow[convPaperSim.Keyword].ToString().Trim(); //关键字(字段类型:varchar,字段长度:1000,是否可空:True)
 objvPaperSimEN.LiteratureSources = objRow[convPaperSim.LiteratureSources] == DBNull.Value ? null : objRow[convPaperSim.LiteratureSources].ToString().Trim(); //文献来源(字段类型:varchar,字段长度:1000,是否可空:True)
 objvPaperSimEN.LiteratureLink = objRow[convPaperSim.LiteratureLink] == DBNull.Value ? null : objRow[convPaperSim.LiteratureLink].ToString().Trim(); //文献链接(字段类型:varchar,字段长度:1000,是否可空:True)
 objvPaperSimEN.UploadfileUrl = objRow[convPaperSim.UploadfileUrl] == DBNull.Value ? null : objRow[convPaperSim.UploadfileUrl].ToString().Trim(); //文件地址(字段类型:varchar,字段长度:1000,是否可空:True)
 objvPaperSimEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[convPaperSim.IsQuotethesis].ToString().Trim()); //是否引用论文(字段类型:bit,字段长度:1,是否可空:True)
 objvPaperSimEN.QuoteId = objRow[convPaperSim.QuoteId] == DBNull.Value ? null : objRow[convPaperSim.QuoteId].ToString().Trim(); //引用Id(字段类型:char,字段长度:8,是否可空:True)
 objvPaperSimEN.Checker = objRow[convPaperSim.Checker] == DBNull.Value ? null : objRow[convPaperSim.Checker].ToString().Trim(); //审核人(字段类型:varchar,字段长度:20,是否可空:True)
 objvPaperSimEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convPaperSim.IsChecked].ToString().Trim()); //是否检查(字段类型:bit,字段长度:1,是否可空:True)
 objvPaperSimEN.LiteratureTypeId = objRow[convPaperSim.LiteratureTypeId].ToString().Trim(); //作文类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvPaperSimEN.BrowseNumber = objRow[convPaperSim.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.BrowseNumber].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvPaperSimEN.LiteratureTypeName = objRow[convPaperSim.LiteratureTypeName] == DBNull.Value ? null : objRow[convPaperSim.LiteratureTypeName].ToString().Trim(); //作文类型名(字段类型:varchar,字段长度:100,是否可空:True)
 objvPaperSimEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convPaperSim.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvPaperSimEN.AppraiseCount = objRow[convPaperSim.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objvPaperSimEN.AttachmentCount = objRow[convPaperSim.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.AttachmentCount].ToString().Trim()); //附件计数(字段类型:int,字段长度:4,是否可空:True)
 objvPaperSimEN.CollectionCount = objRow[convPaperSim.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvPaperSimEN.DownloadCount = objRow[convPaperSim.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.DownloadCount].ToString().Trim()); //下载数(字段类型:int,字段长度:4,是否可空:True)
 objvPaperSimEN.Memo = objRow[convPaperSim.Memo] == DBNull.Value ? null : objRow[convPaperSim.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvPaperSimEN.OkCount = objRow[convPaperSim.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objvPaperSimEN.Pcount = objRow[convPaperSim.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.Pcount].ToString().Trim()); //读写数(字段类型:int,字段长度:4,是否可空:True)
 objvPaperSimEN.Score = objRow[convPaperSim.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSim.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvPaperSimEN.StuScore = objRow[convPaperSim.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSim.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objvPaperSimEN.TeaScore = objRow[convPaperSim.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSim.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objvPaperSimEN.PaperQCount = objRow[convPaperSim.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.PaperQCount].ToString().Trim()); //论文答疑数(字段类型:int,字段长度:4,是否可空:True)
 objvPaperSimEN.SubVCount = objRow[convPaperSim.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.SubVCount].ToString().Trim()); //论文子观点数(字段类型:int,字段长度:4,是否可空:True)
 objvPaperSimEN.TagsCount = objRow[convPaperSim.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.TagsCount].ToString().Trim()); //论文标注数(字段类型:int,字段长度:4,是否可空:True)
 objvPaperSimEN.TeaQCount = objRow[convPaperSim.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.TeaQCount].ToString().Trim()); //教师提问数(字段类型:int,字段长度:4,是否可空:True)
 objvPaperSimEN.UpdUser = objRow[convPaperSim.UpdUser] == DBNull.Value ? null : objRow[convPaperSim.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvPaperSimDA: GetObjByPaperId)", objException.Message));
}
return objvPaperSimEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvPaperSimEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvPaperSimDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperSimDA.GetSpecSQLObj();
strSQL = "Select * from vPaperSim where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvPaperSimEN objvPaperSimEN = new clsvPaperSimEN()
{
PaperId = objRow[convPaperSim.PaperId].ToString().Trim(), //论文Id
PaperTitle = objRow[convPaperSim.PaperTitle].ToString().Trim(), //论文标题
PaperContent = objRow[convPaperSim.PaperContent] == DBNull.Value ? null : objRow[convPaperSim.PaperContent].ToString().Trim(), //主题内容
Periodical = objRow[convPaperSim.Periodical] == DBNull.Value ? null : objRow[convPaperSim.Periodical].ToString().Trim(), //期刊
Author = objRow[convPaperSim.Author] == DBNull.Value ? null : objRow[convPaperSim.Author].ToString().Trim(), //作者
ResearchQuestion = objRow[convPaperSim.ResearchQuestion] == DBNull.Value ? null : objRow[convPaperSim.ResearchQuestion].ToString().Trim(), //研究问题
UpdDate = objRow[convPaperSim.UpdDate].ToString().Trim(), //修改日期
UserName = objRow[convPaperSim.UserName] == DBNull.Value ? null : objRow[convPaperSim.UserName].ToString().Trim(), //用户名
IdXzCollege = objRow[convPaperSim.IdXzCollege] == DBNull.Value ? null : objRow[convPaperSim.IdXzCollege].ToString().Trim(), //学院流水号
CollegeName = objRow[convPaperSim.CollegeName] == DBNull.Value ? null : objRow[convPaperSim.CollegeName].ToString().Trim(), //学院名称
IdXzMajor = objRow[convPaperSim.IdXzMajor] == DBNull.Value ? null : objRow[convPaperSim.IdXzMajor].ToString().Trim(), //专业流水号
MajorName = objRow[convPaperSim.MajorName] == DBNull.Value ? null : objRow[convPaperSim.MajorName].ToString().Trim(), //专业名称
Keyword = objRow[convPaperSim.Keyword] == DBNull.Value ? null : objRow[convPaperSim.Keyword].ToString().Trim(), //关键字
LiteratureSources = objRow[convPaperSim.LiteratureSources] == DBNull.Value ? null : objRow[convPaperSim.LiteratureSources].ToString().Trim(), //文献来源
LiteratureLink = objRow[convPaperSim.LiteratureLink] == DBNull.Value ? null : objRow[convPaperSim.LiteratureLink].ToString().Trim(), //文献链接
UploadfileUrl = objRow[convPaperSim.UploadfileUrl] == DBNull.Value ? null : objRow[convPaperSim.UploadfileUrl].ToString().Trim(), //文件地址
IsQuotethesis = TransNullToBool(objRow[convPaperSim.IsQuotethesis].ToString().Trim()), //是否引用论文
QuoteId = objRow[convPaperSim.QuoteId] == DBNull.Value ? null : objRow[convPaperSim.QuoteId].ToString().Trim(), //引用Id
Checker = objRow[convPaperSim.Checker] == DBNull.Value ? null : objRow[convPaperSim.Checker].ToString().Trim(), //审核人
IsChecked = TransNullToBool(objRow[convPaperSim.IsChecked].ToString().Trim()), //是否检查
LiteratureTypeId = objRow[convPaperSim.LiteratureTypeId].ToString().Trim(), //作文类型Id
BrowseNumber = objRow[convPaperSim.BrowseNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSim.BrowseNumber].ToString().Trim()), //浏览量
LiteratureTypeName = objRow[convPaperSim.LiteratureTypeName] == DBNull.Value ? null : objRow[convPaperSim.LiteratureTypeName].ToString().Trim(), //作文类型名
IsSubmit = TransNullToBool(objRow[convPaperSim.IsSubmit].ToString().Trim()), //是否提交
AppraiseCount = objRow[convPaperSim.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSim.AppraiseCount].ToString().Trim()), //评论数
AttachmentCount = objRow[convPaperSim.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSim.AttachmentCount].ToString().Trim()), //附件计数
CollectionCount = objRow[convPaperSim.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convPaperSim.CollectionCount].ToString().Trim()), //收藏数量
DownloadCount = objRow[convPaperSim.DownloadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSim.DownloadCount].ToString().Trim()), //下载数
Memo = objRow[convPaperSim.Memo] == DBNull.Value ? null : objRow[convPaperSim.Memo].ToString().Trim(), //备注
OkCount = objRow[convPaperSim.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSim.OkCount].ToString().Trim()), //点赞统计
Pcount = objRow[convPaperSim.Pcount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSim.Pcount].ToString().Trim()), //读写数
Score = objRow[convPaperSim.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPaperSim.Score].ToString().Trim()), //评分
StuScore = objRow[convPaperSim.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPaperSim.StuScore].ToString().Trim()), //学生平均分
TeaScore = objRow[convPaperSim.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPaperSim.TeaScore].ToString().Trim()), //教师评分
PaperQCount = objRow[convPaperSim.PaperQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSim.PaperQCount].ToString().Trim()), //论文答疑数
SubVCount = objRow[convPaperSim.SubVCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSim.SubVCount].ToString().Trim()), //论文子观点数
TagsCount = objRow[convPaperSim.TagsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSim.TagsCount].ToString().Trim()), //论文标注数
TeaQCount = objRow[convPaperSim.TeaQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSim.TeaQCount].ToString().Trim()), //教师提问数
UpdUser = objRow[convPaperSim.UpdUser] == DBNull.Value ? null : objRow[convPaperSim.UpdUser].ToString().Trim() //修改人
};
objvPaperSimEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPaperSimEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvPaperSimDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvPaperSimEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvPaperSimEN objvPaperSimEN = new clsvPaperSimEN();
try
{
objvPaperSimEN.PaperId = objRow[convPaperSim.PaperId].ToString().Trim(); //论文Id
objvPaperSimEN.PaperTitle = objRow[convPaperSim.PaperTitle].ToString().Trim(); //论文标题
objvPaperSimEN.PaperContent = objRow[convPaperSim.PaperContent] == DBNull.Value ? null : objRow[convPaperSim.PaperContent].ToString().Trim(); //主题内容
objvPaperSimEN.Periodical = objRow[convPaperSim.Periodical] == DBNull.Value ? null : objRow[convPaperSim.Periodical].ToString().Trim(); //期刊
objvPaperSimEN.Author = objRow[convPaperSim.Author] == DBNull.Value ? null : objRow[convPaperSim.Author].ToString().Trim(); //作者
objvPaperSimEN.ResearchQuestion = objRow[convPaperSim.ResearchQuestion] == DBNull.Value ? null : objRow[convPaperSim.ResearchQuestion].ToString().Trim(); //研究问题
objvPaperSimEN.UpdDate = objRow[convPaperSim.UpdDate].ToString().Trim(); //修改日期
objvPaperSimEN.UserName = objRow[convPaperSim.UserName] == DBNull.Value ? null : objRow[convPaperSim.UserName].ToString().Trim(); //用户名
objvPaperSimEN.IdXzCollege = objRow[convPaperSim.IdXzCollege] == DBNull.Value ? null : objRow[convPaperSim.IdXzCollege].ToString().Trim(); //学院流水号
objvPaperSimEN.CollegeName = objRow[convPaperSim.CollegeName] == DBNull.Value ? null : objRow[convPaperSim.CollegeName].ToString().Trim(); //学院名称
objvPaperSimEN.IdXzMajor = objRow[convPaperSim.IdXzMajor] == DBNull.Value ? null : objRow[convPaperSim.IdXzMajor].ToString().Trim(); //专业流水号
objvPaperSimEN.MajorName = objRow[convPaperSim.MajorName] == DBNull.Value ? null : objRow[convPaperSim.MajorName].ToString().Trim(); //专业名称
objvPaperSimEN.Keyword = objRow[convPaperSim.Keyword] == DBNull.Value ? null : objRow[convPaperSim.Keyword].ToString().Trim(); //关键字
objvPaperSimEN.LiteratureSources = objRow[convPaperSim.LiteratureSources] == DBNull.Value ? null : objRow[convPaperSim.LiteratureSources].ToString().Trim(); //文献来源
objvPaperSimEN.LiteratureLink = objRow[convPaperSim.LiteratureLink] == DBNull.Value ? null : objRow[convPaperSim.LiteratureLink].ToString().Trim(); //文献链接
objvPaperSimEN.UploadfileUrl = objRow[convPaperSim.UploadfileUrl] == DBNull.Value ? null : objRow[convPaperSim.UploadfileUrl].ToString().Trim(); //文件地址
objvPaperSimEN.IsQuotethesis = TransNullToBool(objRow[convPaperSim.IsQuotethesis].ToString().Trim()); //是否引用论文
objvPaperSimEN.QuoteId = objRow[convPaperSim.QuoteId] == DBNull.Value ? null : objRow[convPaperSim.QuoteId].ToString().Trim(); //引用Id
objvPaperSimEN.Checker = objRow[convPaperSim.Checker] == DBNull.Value ? null : objRow[convPaperSim.Checker].ToString().Trim(); //审核人
objvPaperSimEN.IsChecked = TransNullToBool(objRow[convPaperSim.IsChecked].ToString().Trim()); //是否检查
objvPaperSimEN.LiteratureTypeId = objRow[convPaperSim.LiteratureTypeId].ToString().Trim(); //作文类型Id
objvPaperSimEN.BrowseNumber = objRow[convPaperSim.BrowseNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSim.BrowseNumber].ToString().Trim()); //浏览量
objvPaperSimEN.LiteratureTypeName = objRow[convPaperSim.LiteratureTypeName] == DBNull.Value ? null : objRow[convPaperSim.LiteratureTypeName].ToString().Trim(); //作文类型名
objvPaperSimEN.IsSubmit = TransNullToBool(objRow[convPaperSim.IsSubmit].ToString().Trim()); //是否提交
objvPaperSimEN.AppraiseCount = objRow[convPaperSim.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSim.AppraiseCount].ToString().Trim()); //评论数
objvPaperSimEN.AttachmentCount = objRow[convPaperSim.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSim.AttachmentCount].ToString().Trim()); //附件计数
objvPaperSimEN.CollectionCount = objRow[convPaperSim.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convPaperSim.CollectionCount].ToString().Trim()); //收藏数量
objvPaperSimEN.DownloadCount = objRow[convPaperSim.DownloadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSim.DownloadCount].ToString().Trim()); //下载数
objvPaperSimEN.Memo = objRow[convPaperSim.Memo] == DBNull.Value ? null : objRow[convPaperSim.Memo].ToString().Trim(); //备注
objvPaperSimEN.OkCount = objRow[convPaperSim.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSim.OkCount].ToString().Trim()); //点赞统计
objvPaperSimEN.Pcount = objRow[convPaperSim.Pcount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSim.Pcount].ToString().Trim()); //读写数
objvPaperSimEN.Score = objRow[convPaperSim.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPaperSim.Score].ToString().Trim()); //评分
objvPaperSimEN.StuScore = objRow[convPaperSim.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPaperSim.StuScore].ToString().Trim()); //学生平均分
objvPaperSimEN.TeaScore = objRow[convPaperSim.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPaperSim.TeaScore].ToString().Trim()); //教师评分
objvPaperSimEN.PaperQCount = objRow[convPaperSim.PaperQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSim.PaperQCount].ToString().Trim()); //论文答疑数
objvPaperSimEN.SubVCount = objRow[convPaperSim.SubVCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSim.SubVCount].ToString().Trim()); //论文子观点数
objvPaperSimEN.TagsCount = objRow[convPaperSim.TagsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSim.TagsCount].ToString().Trim()); //论文标注数
objvPaperSimEN.TeaQCount = objRow[convPaperSim.TeaQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSim.TeaQCount].ToString().Trim()); //教师提问数
objvPaperSimEN.UpdUser = objRow[convPaperSim.UpdUser] == DBNull.Value ? null : objRow[convPaperSim.UpdUser].ToString().Trim(); //修改人
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvPaperSimDA: GetObjByDataRowvPaperSim)", objException.Message));
}
objvPaperSimEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPaperSimEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvPaperSimEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvPaperSimEN objvPaperSimEN = new clsvPaperSimEN();
try
{
objvPaperSimEN.PaperId = objRow[convPaperSim.PaperId].ToString().Trim(); //论文Id
objvPaperSimEN.PaperTitle = objRow[convPaperSim.PaperTitle].ToString().Trim(); //论文标题
objvPaperSimEN.PaperContent = objRow[convPaperSim.PaperContent] == DBNull.Value ? null : objRow[convPaperSim.PaperContent].ToString().Trim(); //主题内容
objvPaperSimEN.Periodical = objRow[convPaperSim.Periodical] == DBNull.Value ? null : objRow[convPaperSim.Periodical].ToString().Trim(); //期刊
objvPaperSimEN.Author = objRow[convPaperSim.Author] == DBNull.Value ? null : objRow[convPaperSim.Author].ToString().Trim(); //作者
objvPaperSimEN.ResearchQuestion = objRow[convPaperSim.ResearchQuestion] == DBNull.Value ? null : objRow[convPaperSim.ResearchQuestion].ToString().Trim(); //研究问题
objvPaperSimEN.UpdDate = objRow[convPaperSim.UpdDate].ToString().Trim(); //修改日期
objvPaperSimEN.UserName = objRow[convPaperSim.UserName] == DBNull.Value ? null : objRow[convPaperSim.UserName].ToString().Trim(); //用户名
objvPaperSimEN.IdXzCollege = objRow[convPaperSim.IdXzCollege] == DBNull.Value ? null : objRow[convPaperSim.IdXzCollege].ToString().Trim(); //学院流水号
objvPaperSimEN.CollegeName = objRow[convPaperSim.CollegeName] == DBNull.Value ? null : objRow[convPaperSim.CollegeName].ToString().Trim(); //学院名称
objvPaperSimEN.IdXzMajor = objRow[convPaperSim.IdXzMajor] == DBNull.Value ? null : objRow[convPaperSim.IdXzMajor].ToString().Trim(); //专业流水号
objvPaperSimEN.MajorName = objRow[convPaperSim.MajorName] == DBNull.Value ? null : objRow[convPaperSim.MajorName].ToString().Trim(); //专业名称
objvPaperSimEN.Keyword = objRow[convPaperSim.Keyword] == DBNull.Value ? null : objRow[convPaperSim.Keyword].ToString().Trim(); //关键字
objvPaperSimEN.LiteratureSources = objRow[convPaperSim.LiteratureSources] == DBNull.Value ? null : objRow[convPaperSim.LiteratureSources].ToString().Trim(); //文献来源
objvPaperSimEN.LiteratureLink = objRow[convPaperSim.LiteratureLink] == DBNull.Value ? null : objRow[convPaperSim.LiteratureLink].ToString().Trim(); //文献链接
objvPaperSimEN.UploadfileUrl = objRow[convPaperSim.UploadfileUrl] == DBNull.Value ? null : objRow[convPaperSim.UploadfileUrl].ToString().Trim(); //文件地址
objvPaperSimEN.IsQuotethesis = TransNullToBool(objRow[convPaperSim.IsQuotethesis].ToString().Trim()); //是否引用论文
objvPaperSimEN.QuoteId = objRow[convPaperSim.QuoteId] == DBNull.Value ? null : objRow[convPaperSim.QuoteId].ToString().Trim(); //引用Id
objvPaperSimEN.Checker = objRow[convPaperSim.Checker] == DBNull.Value ? null : objRow[convPaperSim.Checker].ToString().Trim(); //审核人
objvPaperSimEN.IsChecked = TransNullToBool(objRow[convPaperSim.IsChecked].ToString().Trim()); //是否检查
objvPaperSimEN.LiteratureTypeId = objRow[convPaperSim.LiteratureTypeId].ToString().Trim(); //作文类型Id
objvPaperSimEN.BrowseNumber = objRow[convPaperSim.BrowseNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSim.BrowseNumber].ToString().Trim()); //浏览量
objvPaperSimEN.LiteratureTypeName = objRow[convPaperSim.LiteratureTypeName] == DBNull.Value ? null : objRow[convPaperSim.LiteratureTypeName].ToString().Trim(); //作文类型名
objvPaperSimEN.IsSubmit = TransNullToBool(objRow[convPaperSim.IsSubmit].ToString().Trim()); //是否提交
objvPaperSimEN.AppraiseCount = objRow[convPaperSim.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSim.AppraiseCount].ToString().Trim()); //评论数
objvPaperSimEN.AttachmentCount = objRow[convPaperSim.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSim.AttachmentCount].ToString().Trim()); //附件计数
objvPaperSimEN.CollectionCount = objRow[convPaperSim.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convPaperSim.CollectionCount].ToString().Trim()); //收藏数量
objvPaperSimEN.DownloadCount = objRow[convPaperSim.DownloadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSim.DownloadCount].ToString().Trim()); //下载数
objvPaperSimEN.Memo = objRow[convPaperSim.Memo] == DBNull.Value ? null : objRow[convPaperSim.Memo].ToString().Trim(); //备注
objvPaperSimEN.OkCount = objRow[convPaperSim.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSim.OkCount].ToString().Trim()); //点赞统计
objvPaperSimEN.Pcount = objRow[convPaperSim.Pcount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSim.Pcount].ToString().Trim()); //读写数
objvPaperSimEN.Score = objRow[convPaperSim.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPaperSim.Score].ToString().Trim()); //评分
objvPaperSimEN.StuScore = objRow[convPaperSim.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPaperSim.StuScore].ToString().Trim()); //学生平均分
objvPaperSimEN.TeaScore = objRow[convPaperSim.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPaperSim.TeaScore].ToString().Trim()); //教师评分
objvPaperSimEN.PaperQCount = objRow[convPaperSim.PaperQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSim.PaperQCount].ToString().Trim()); //论文答疑数
objvPaperSimEN.SubVCount = objRow[convPaperSim.SubVCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSim.SubVCount].ToString().Trim()); //论文子观点数
objvPaperSimEN.TagsCount = objRow[convPaperSim.TagsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSim.TagsCount].ToString().Trim()); //论文标注数
objvPaperSimEN.TeaQCount = objRow[convPaperSim.TeaQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperSim.TeaQCount].ToString().Trim()); //教师提问数
objvPaperSimEN.UpdUser = objRow[convPaperSim.UpdUser] == DBNull.Value ? null : objRow[convPaperSim.UpdUser].ToString().Trim(); //修改人
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvPaperSimDA: GetObjByDataRow)", objException.Message));
}
objvPaperSimEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPaperSimEN;
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
objSQL = clsvPaperSimDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvPaperSimEN._CurrTabName, convPaperSim.PaperId, 8, "");
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
objSQL = clsvPaperSimDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvPaperSimEN._CurrTabName, convPaperSim.PaperId, 8, strPrefix);
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
 objSQL = clsvPaperSimDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select PaperId from vPaperSim where " + strCondition;
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
 objSQL = clsvPaperSimDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select PaperId from vPaperSim where " + strCondition;
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
 /// <param name = "strPaperId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strPaperId)
{
CheckPrimaryKey(strPaperId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperSimDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vPaperSim", "PaperId = " + "'"+ strPaperId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvPaperSimDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperSimDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vPaperSim", strCondition))
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
objSQL = clsvPaperSimDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vPaperSim");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvPaperSimENS">源对象</param>
 /// <param name = "objvPaperSimENT">目标对象</param>
public void CopyTo(clsvPaperSimEN objvPaperSimENS, clsvPaperSimEN objvPaperSimENT)
{
objvPaperSimENT.PaperId = objvPaperSimENS.PaperId; //论文Id
objvPaperSimENT.PaperTitle = objvPaperSimENS.PaperTitle; //论文标题
objvPaperSimENT.PaperContent = objvPaperSimENS.PaperContent; //主题内容
objvPaperSimENT.Periodical = objvPaperSimENS.Periodical; //期刊
objvPaperSimENT.Author = objvPaperSimENS.Author; //作者
objvPaperSimENT.ResearchQuestion = objvPaperSimENS.ResearchQuestion; //研究问题
objvPaperSimENT.UpdDate = objvPaperSimENS.UpdDate; //修改日期
objvPaperSimENT.UserName = objvPaperSimENS.UserName; //用户名
objvPaperSimENT.IdXzCollege = objvPaperSimENS.IdXzCollege; //学院流水号
objvPaperSimENT.CollegeName = objvPaperSimENS.CollegeName; //学院名称
objvPaperSimENT.IdXzMajor = objvPaperSimENS.IdXzMajor; //专业流水号
objvPaperSimENT.MajorName = objvPaperSimENS.MajorName; //专业名称
objvPaperSimENT.Keyword = objvPaperSimENS.Keyword; //关键字
objvPaperSimENT.LiteratureSources = objvPaperSimENS.LiteratureSources; //文献来源
objvPaperSimENT.LiteratureLink = objvPaperSimENS.LiteratureLink; //文献链接
objvPaperSimENT.UploadfileUrl = objvPaperSimENS.UploadfileUrl; //文件地址
objvPaperSimENT.IsQuotethesis = objvPaperSimENS.IsQuotethesis; //是否引用论文
objvPaperSimENT.QuoteId = objvPaperSimENS.QuoteId; //引用Id
objvPaperSimENT.Checker = objvPaperSimENS.Checker; //审核人
objvPaperSimENT.IsChecked = objvPaperSimENS.IsChecked; //是否检查
objvPaperSimENT.LiteratureTypeId = objvPaperSimENS.LiteratureTypeId; //作文类型Id
objvPaperSimENT.BrowseNumber = objvPaperSimENS.BrowseNumber; //浏览量
objvPaperSimENT.LiteratureTypeName = objvPaperSimENS.LiteratureTypeName; //作文类型名
objvPaperSimENT.IsSubmit = objvPaperSimENS.IsSubmit; //是否提交
objvPaperSimENT.AppraiseCount = objvPaperSimENS.AppraiseCount; //评论数
objvPaperSimENT.AttachmentCount = objvPaperSimENS.AttachmentCount; //附件计数
objvPaperSimENT.CollectionCount = objvPaperSimENS.CollectionCount; //收藏数量
objvPaperSimENT.DownloadCount = objvPaperSimENS.DownloadCount; //下载数
objvPaperSimENT.Memo = objvPaperSimENS.Memo; //备注
objvPaperSimENT.OkCount = objvPaperSimENS.OkCount; //点赞统计
objvPaperSimENT.Pcount = objvPaperSimENS.Pcount; //读写数
objvPaperSimENT.Score = objvPaperSimENS.Score; //评分
objvPaperSimENT.StuScore = objvPaperSimENS.StuScore; //学生平均分
objvPaperSimENT.TeaScore = objvPaperSimENS.TeaScore; //教师评分
objvPaperSimENT.PaperQCount = objvPaperSimENS.PaperQCount; //论文答疑数
objvPaperSimENT.SubVCount = objvPaperSimENS.SubVCount; //论文子观点数
objvPaperSimENT.TagsCount = objvPaperSimENS.TagsCount; //论文标注数
objvPaperSimENT.TeaQCount = objvPaperSimENS.TeaQCount; //教师提问数
objvPaperSimENT.UpdUser = objvPaperSimENS.UpdUser; //修改人
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvPaperSimEN objvPaperSimEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvPaperSimEN.PaperId, 8, convPaperSim.PaperId);
clsCheckSql.CheckFieldLen(objvPaperSimEN.PaperTitle, 500, convPaperSim.PaperTitle);
clsCheckSql.CheckFieldLen(objvPaperSimEN.Periodical, 100, convPaperSim.Periodical);
clsCheckSql.CheckFieldLen(objvPaperSimEN.Author, 200, convPaperSim.Author);
clsCheckSql.CheckFieldLen(objvPaperSimEN.ResearchQuestion, 2000, convPaperSim.ResearchQuestion);
clsCheckSql.CheckFieldLen(objvPaperSimEN.UpdDate, 20, convPaperSim.UpdDate);
clsCheckSql.CheckFieldLen(objvPaperSimEN.UserName, 30, convPaperSim.UserName);
clsCheckSql.CheckFieldLen(objvPaperSimEN.IdXzCollege, 4, convPaperSim.IdXzCollege);
clsCheckSql.CheckFieldLen(objvPaperSimEN.CollegeName, 100, convPaperSim.CollegeName);
clsCheckSql.CheckFieldLen(objvPaperSimEN.IdXzMajor, 8, convPaperSim.IdXzMajor);
clsCheckSql.CheckFieldLen(objvPaperSimEN.MajorName, 100, convPaperSim.MajorName);
clsCheckSql.CheckFieldLen(objvPaperSimEN.Keyword, 1000, convPaperSim.Keyword);
clsCheckSql.CheckFieldLen(objvPaperSimEN.LiteratureSources, 1000, convPaperSim.LiteratureSources);
clsCheckSql.CheckFieldLen(objvPaperSimEN.LiteratureLink, 1000, convPaperSim.LiteratureLink);
clsCheckSql.CheckFieldLen(objvPaperSimEN.UploadfileUrl, 1000, convPaperSim.UploadfileUrl);
clsCheckSql.CheckFieldLen(objvPaperSimEN.QuoteId, 8, convPaperSim.QuoteId);
clsCheckSql.CheckFieldLen(objvPaperSimEN.Checker, 20, convPaperSim.Checker);
clsCheckSql.CheckFieldLen(objvPaperSimEN.LiteratureTypeId, 2, convPaperSim.LiteratureTypeId);
clsCheckSql.CheckFieldLen(objvPaperSimEN.LiteratureTypeName, 100, convPaperSim.LiteratureTypeName);
clsCheckSql.CheckFieldLen(objvPaperSimEN.Memo, 1000, convPaperSim.Memo);
clsCheckSql.CheckFieldLen(objvPaperSimEN.UpdUser, 20, convPaperSim.UpdUser);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvPaperSimEN.PaperId, convPaperSim.PaperId);
clsCheckSql.CheckSqlInjection4Field(objvPaperSimEN.PaperTitle, convPaperSim.PaperTitle);
clsCheckSql.CheckSqlInjection4Field(objvPaperSimEN.Periodical, convPaperSim.Periodical);
clsCheckSql.CheckSqlInjection4Field(objvPaperSimEN.Author, convPaperSim.Author);
clsCheckSql.CheckSqlInjection4Field(objvPaperSimEN.ResearchQuestion, convPaperSim.ResearchQuestion);
clsCheckSql.CheckSqlInjection4Field(objvPaperSimEN.UpdDate, convPaperSim.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvPaperSimEN.UserName, convPaperSim.UserName);
clsCheckSql.CheckSqlInjection4Field(objvPaperSimEN.IdXzCollege, convPaperSim.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvPaperSimEN.CollegeName, convPaperSim.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvPaperSimEN.IdXzMajor, convPaperSim.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objvPaperSimEN.MajorName, convPaperSim.MajorName);
clsCheckSql.CheckSqlInjection4Field(objvPaperSimEN.Keyword, convPaperSim.Keyword);
clsCheckSql.CheckSqlInjection4Field(objvPaperSimEN.LiteratureSources, convPaperSim.LiteratureSources);
clsCheckSql.CheckSqlInjection4Field(objvPaperSimEN.LiteratureLink, convPaperSim.LiteratureLink);
clsCheckSql.CheckSqlInjection4Field(objvPaperSimEN.UploadfileUrl, convPaperSim.UploadfileUrl);
clsCheckSql.CheckSqlInjection4Field(objvPaperSimEN.QuoteId, convPaperSim.QuoteId);
clsCheckSql.CheckSqlInjection4Field(objvPaperSimEN.Checker, convPaperSim.Checker);
clsCheckSql.CheckSqlInjection4Field(objvPaperSimEN.LiteratureTypeId, convPaperSim.LiteratureTypeId);
clsCheckSql.CheckSqlInjection4Field(objvPaperSimEN.LiteratureTypeName, convPaperSim.LiteratureTypeName);
clsCheckSql.CheckSqlInjection4Field(objvPaperSimEN.Memo, convPaperSim.Memo);
clsCheckSql.CheckSqlInjection4Field(objvPaperSimEN.UpdUser, convPaperSim.UpdUser);
//检查外键字段长度
 objvPaperSimEN._IsCheckProperty = true;
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
 objSQL = clsvPaperSimDA.GetSpecSQLObj();
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
 objSQL = clsvPaperSimDA.GetSpecSQLObj();
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
 objSQL = clsvPaperSimDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvPaperSimEN._CurrTabName);
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
 objSQL = clsvPaperSimDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvPaperSimEN._CurrTabName, strCondition);
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
 objSQL = clsvPaperSimDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}