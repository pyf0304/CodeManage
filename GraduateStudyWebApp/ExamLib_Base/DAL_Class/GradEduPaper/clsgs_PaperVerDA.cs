
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_PaperVerDA
 表名:gs_PaperVer(01120678)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:11:08
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培论文(GradEduPaper)
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
 /// 论文历史版本表(gs_PaperVer)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsgs_PaperVerDA : clsCommBase4DA
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
 return clsgs_PaperVerEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsgs_PaperVerEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsgs_PaperVerEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsgs_PaperVerEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsgs_PaperVerEN._ConnectString);
 }
 return objSQL;
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsgs_PaperVerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PaperVerDA.GetSpecSQLObj();
strSQL = "Select * from gs_PaperVer where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_gs_PaperVer(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsgs_PaperVerDA: GetDataTable_gs_PaperVer)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PaperVerDA.GetSpecSQLObj();
strSQL = "Select * from gs_PaperVer where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsgs_PaperVerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PaperVerDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsgs_PaperVerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PaperVerDA.GetSpecSQLObj();
strSQL = "Select * from gs_PaperVer where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsgs_PaperVerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PaperVerDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsgs_PaperVerDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PaperVerDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from gs_PaperVer where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from gs_PaperVer where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsgs_PaperVerDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PaperVerDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from gs_PaperVer where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsgs_PaperVerDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PaperVerDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} gs_PaperVer.* from gs_PaperVer Left Join {1} on {2} where {3} and gs_PaperVer.PaperVId not in (Select top {5} gs_PaperVer.PaperVId from gs_PaperVer Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from gs_PaperVer where {1} and PaperVId not in (Select top {2} PaperVId from gs_PaperVer where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from gs_PaperVer where {1} and PaperVId not in (Select top {3} PaperVId from gs_PaperVer where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsgs_PaperVerDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PaperVerDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} gs_PaperVer.* from gs_PaperVer Left Join {1} on {2} where {3} and gs_PaperVer.PaperVId not in (Select top {5} gs_PaperVer.PaperVId from gs_PaperVer Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from gs_PaperVer where {1} and PaperVId not in (Select top {2} PaperVId from gs_PaperVer where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from gs_PaperVer where {1} and PaperVId not in (Select top {3} PaperVId from gs_PaperVer where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsgs_PaperVerEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsgs_PaperVerDA:GetObjLst)", objException.Message));
}
List<clsgs_PaperVerEN> arrObjLst = new List<clsgs_PaperVerEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PaperVerDA.GetSpecSQLObj();
strSQL = "Select * from gs_PaperVer where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_PaperVerEN objgs_PaperVerEN = new clsgs_PaperVerEN();
try
{
objgs_PaperVerEN.PaperVId = TransNullToInt(objRow[congs_PaperVer.PaperVId].ToString().Trim()); //PaperVId
objgs_PaperVerEN.PaperId = objRow[congs_PaperVer.PaperId].ToString().Trim(); //论文Id
objgs_PaperVerEN.PaperTitle = objRow[congs_PaperVer.PaperTitle].ToString().Trim(); //论文标题
objgs_PaperVerEN.PaperContent = objRow[congs_PaperVer.PaperContent] == DBNull.Value ? null : objRow[congs_PaperVer.PaperContent].ToString().Trim(); //主题内容
objgs_PaperVerEN.Periodical = objRow[congs_PaperVer.Periodical] == DBNull.Value ? null : objRow[congs_PaperVer.Periodical].ToString().Trim(); //期刊
objgs_PaperVerEN.Author = objRow[congs_PaperVer.Author] == DBNull.Value ? null : objRow[congs_PaperVer.Author].ToString().Trim(); //作者
objgs_PaperVerEN.ResearchQuestion = objRow[congs_PaperVer.ResearchQuestion] == DBNull.Value ? null : objRow[congs_PaperVer.ResearchQuestion].ToString().Trim(); //研究问题
objgs_PaperVerEN.Keyword = objRow[congs_PaperVer.Keyword] == DBNull.Value ? null : objRow[congs_PaperVer.Keyword].ToString().Trim(); //关键字
objgs_PaperVerEN.LiteratureSources = objRow[congs_PaperVer.LiteratureSources] == DBNull.Value ? null : objRow[congs_PaperVer.LiteratureSources].ToString().Trim(); //文献来源
objgs_PaperVerEN.LiteratureLink = objRow[congs_PaperVer.LiteratureLink] == DBNull.Value ? null : objRow[congs_PaperVer.LiteratureLink].ToString().Trim(); //文献链接
objgs_PaperVerEN.UploadfileUrl = objRow[congs_PaperVer.UploadfileUrl] == DBNull.Value ? null : objRow[congs_PaperVer.UploadfileUrl].ToString().Trim(); //文件地址
objgs_PaperVerEN.IsQuotethesis = TransNullToBool(objRow[congs_PaperVer.IsQuotethesis].ToString().Trim()); //是否引用论文
objgs_PaperVerEN.IsSubmit = TransNullToBool(objRow[congs_PaperVer.IsSubmit].ToString().Trim()); //是否提交
objgs_PaperVerEN.IsChecked = TransNullToBool(objRow[congs_PaperVer.IsChecked].ToString().Trim()); //是否检查
objgs_PaperVerEN.QuoteId = objRow[congs_PaperVer.QuoteId] == DBNull.Value ? null : objRow[congs_PaperVer.QuoteId].ToString().Trim(); //引用Id
objgs_PaperVerEN.Checker = objRow[congs_PaperVer.Checker] == DBNull.Value ? null : objRow[congs_PaperVer.Checker].ToString().Trim(); //审核人
objgs_PaperVerEN.LiteratureTypeId = objRow[congs_PaperVer.LiteratureTypeId].ToString().Trim(); //文献类型Id
objgs_PaperVerEN.UpdUser = objRow[congs_PaperVer.UpdUser] == DBNull.Value ? null : objRow[congs_PaperVer.UpdUser].ToString().Trim(); //修改人
objgs_PaperVerEN.UpdDate = objRow[congs_PaperVer.UpdDate] == DBNull.Value ? null : objRow[congs_PaperVer.UpdDate].ToString().Trim(); //修改日期
objgs_PaperVerEN.IdCurrEduCls = objRow[congs_PaperVer.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_PaperVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_PaperVerEN.PaperTypeId = objRow[congs_PaperVer.PaperTypeId] == DBNull.Value ? null : objRow[congs_PaperVer.PaperTypeId].ToString().Trim(); //论文类型Id
objgs_PaperVerEN.PaperStatusId = objRow[congs_PaperVer.PaperStatusId] == DBNull.Value ? null : objRow[congs_PaperVer.PaperStatusId].ToString().Trim(); //论文状态Id
objgs_PaperVerEN.Memo = objRow[congs_PaperVer.Memo] == DBNull.Value ? null : objRow[congs_PaperVer.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsgs_PaperVerDA: GetObjLst)", objException.Message));
}
objgs_PaperVerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objgs_PaperVerEN);
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
public List<clsgs_PaperVerEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsgs_PaperVerDA:GetObjLstByTabName)", objException.Message));
}
List<clsgs_PaperVerEN> arrObjLst = new List<clsgs_PaperVerEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PaperVerDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_PaperVerEN objgs_PaperVerEN = new clsgs_PaperVerEN();
try
{
objgs_PaperVerEN.PaperVId = TransNullToInt(objRow[congs_PaperVer.PaperVId].ToString().Trim()); //PaperVId
objgs_PaperVerEN.PaperId = objRow[congs_PaperVer.PaperId].ToString().Trim(); //论文Id
objgs_PaperVerEN.PaperTitle = objRow[congs_PaperVer.PaperTitle].ToString().Trim(); //论文标题
objgs_PaperVerEN.PaperContent = objRow[congs_PaperVer.PaperContent] == DBNull.Value ? null : objRow[congs_PaperVer.PaperContent].ToString().Trim(); //主题内容
objgs_PaperVerEN.Periodical = objRow[congs_PaperVer.Periodical] == DBNull.Value ? null : objRow[congs_PaperVer.Periodical].ToString().Trim(); //期刊
objgs_PaperVerEN.Author = objRow[congs_PaperVer.Author] == DBNull.Value ? null : objRow[congs_PaperVer.Author].ToString().Trim(); //作者
objgs_PaperVerEN.ResearchQuestion = objRow[congs_PaperVer.ResearchQuestion] == DBNull.Value ? null : objRow[congs_PaperVer.ResearchQuestion].ToString().Trim(); //研究问题
objgs_PaperVerEN.Keyword = objRow[congs_PaperVer.Keyword] == DBNull.Value ? null : objRow[congs_PaperVer.Keyword].ToString().Trim(); //关键字
objgs_PaperVerEN.LiteratureSources = objRow[congs_PaperVer.LiteratureSources] == DBNull.Value ? null : objRow[congs_PaperVer.LiteratureSources].ToString().Trim(); //文献来源
objgs_PaperVerEN.LiteratureLink = objRow[congs_PaperVer.LiteratureLink] == DBNull.Value ? null : objRow[congs_PaperVer.LiteratureLink].ToString().Trim(); //文献链接
objgs_PaperVerEN.UploadfileUrl = objRow[congs_PaperVer.UploadfileUrl] == DBNull.Value ? null : objRow[congs_PaperVer.UploadfileUrl].ToString().Trim(); //文件地址
objgs_PaperVerEN.IsQuotethesis = TransNullToBool(objRow[congs_PaperVer.IsQuotethesis].ToString().Trim()); //是否引用论文
objgs_PaperVerEN.IsSubmit = TransNullToBool(objRow[congs_PaperVer.IsSubmit].ToString().Trim()); //是否提交
objgs_PaperVerEN.IsChecked = TransNullToBool(objRow[congs_PaperVer.IsChecked].ToString().Trim()); //是否检查
objgs_PaperVerEN.QuoteId = objRow[congs_PaperVer.QuoteId] == DBNull.Value ? null : objRow[congs_PaperVer.QuoteId].ToString().Trim(); //引用Id
objgs_PaperVerEN.Checker = objRow[congs_PaperVer.Checker] == DBNull.Value ? null : objRow[congs_PaperVer.Checker].ToString().Trim(); //审核人
objgs_PaperVerEN.LiteratureTypeId = objRow[congs_PaperVer.LiteratureTypeId].ToString().Trim(); //文献类型Id
objgs_PaperVerEN.UpdUser = objRow[congs_PaperVer.UpdUser] == DBNull.Value ? null : objRow[congs_PaperVer.UpdUser].ToString().Trim(); //修改人
objgs_PaperVerEN.UpdDate = objRow[congs_PaperVer.UpdDate] == DBNull.Value ? null : objRow[congs_PaperVer.UpdDate].ToString().Trim(); //修改日期
objgs_PaperVerEN.IdCurrEduCls = objRow[congs_PaperVer.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_PaperVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_PaperVerEN.PaperTypeId = objRow[congs_PaperVer.PaperTypeId] == DBNull.Value ? null : objRow[congs_PaperVer.PaperTypeId].ToString().Trim(); //论文类型Id
objgs_PaperVerEN.PaperStatusId = objRow[congs_PaperVer.PaperStatusId] == DBNull.Value ? null : objRow[congs_PaperVer.PaperStatusId].ToString().Trim(); //论文状态Id
objgs_PaperVerEN.Memo = objRow[congs_PaperVer.Memo] == DBNull.Value ? null : objRow[congs_PaperVer.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsgs_PaperVerDA: GetObjLst)", objException.Message));
}
objgs_PaperVerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objgs_PaperVerEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objgs_PaperVerEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getgs_PaperVer(ref clsgs_PaperVerEN objgs_PaperVerEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PaperVerDA.GetSpecSQLObj();
strSQL = "Select * from gs_PaperVer where PaperVId = " + ""+ objgs_PaperVerEN.PaperVId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objgs_PaperVerEN.PaperVId = TransNullToInt(objDT.Rows[0][congs_PaperVer.PaperVId].ToString().Trim()); //PaperVId(字段类型:bigint,字段长度:8,是否可空:False)
 objgs_PaperVerEN.PaperId = objDT.Rows[0][congs_PaperVer.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objgs_PaperVerEN.PaperTitle = objDT.Rows[0][congs_PaperVer.PaperTitle].ToString().Trim(); //论文标题(字段类型:varchar,字段长度:500,是否可空:False)
 objgs_PaperVerEN.PaperContent = objDT.Rows[0][congs_PaperVer.PaperContent].ToString().Trim(); //主题内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objgs_PaperVerEN.Periodical = objDT.Rows[0][congs_PaperVer.Periodical].ToString().Trim(); //期刊(字段类型:varchar,字段长度:100,是否可空:True)
 objgs_PaperVerEN.Author = objDT.Rows[0][congs_PaperVer.Author].ToString().Trim(); //作者(字段类型:varchar,字段长度:200,是否可空:True)
 objgs_PaperVerEN.ResearchQuestion = objDT.Rows[0][congs_PaperVer.ResearchQuestion].ToString().Trim(); //研究问题(字段类型:varchar,字段长度:2000,是否可空:True)
 objgs_PaperVerEN.Keyword = objDT.Rows[0][congs_PaperVer.Keyword].ToString().Trim(); //关键字(字段类型:varchar,字段长度:1000,是否可空:True)
 objgs_PaperVerEN.LiteratureSources = objDT.Rows[0][congs_PaperVer.LiteratureSources].ToString().Trim(); //文献来源(字段类型:varchar,字段长度:1000,是否可空:True)
 objgs_PaperVerEN.LiteratureLink = objDT.Rows[0][congs_PaperVer.LiteratureLink].ToString().Trim(); //文献链接(字段类型:varchar,字段长度:1000,是否可空:True)
 objgs_PaperVerEN.UploadfileUrl = objDT.Rows[0][congs_PaperVer.UploadfileUrl].ToString().Trim(); //文件地址(字段类型:varchar,字段长度:1000,是否可空:True)
 objgs_PaperVerEN.IsQuotethesis = TransNullToBool(objDT.Rows[0][congs_PaperVer.IsQuotethesis].ToString().Trim()); //是否引用论文(字段类型:bit,字段长度:1,是否可空:True)
 objgs_PaperVerEN.IsSubmit = TransNullToBool(objDT.Rows[0][congs_PaperVer.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objgs_PaperVerEN.IsChecked = TransNullToBool(objDT.Rows[0][congs_PaperVer.IsChecked].ToString().Trim()); //是否检查(字段类型:bit,字段长度:1,是否可空:True)
 objgs_PaperVerEN.QuoteId = objDT.Rows[0][congs_PaperVer.QuoteId].ToString().Trim(); //引用Id(字段类型:char,字段长度:8,是否可空:True)
 objgs_PaperVerEN.Checker = objDT.Rows[0][congs_PaperVer.Checker].ToString().Trim(); //审核人(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_PaperVerEN.LiteratureTypeId = objDT.Rows[0][congs_PaperVer.LiteratureTypeId].ToString().Trim(); //文献类型Id(字段类型:char,字段长度:2,是否可空:False)
 objgs_PaperVerEN.UpdUser = objDT.Rows[0][congs_PaperVer.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_PaperVerEN.UpdDate = objDT.Rows[0][congs_PaperVer.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_PaperVerEN.IdCurrEduCls = objDT.Rows[0][congs_PaperVer.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objgs_PaperVerEN.PaperTypeId = objDT.Rows[0][congs_PaperVer.PaperTypeId].ToString().Trim(); //论文类型Id(字段类型:char,字段长度:2,是否可空:True)
 objgs_PaperVerEN.PaperStatusId = objDT.Rows[0][congs_PaperVer.PaperStatusId].ToString().Trim(); //论文状态Id(字段类型:char,字段长度:2,是否可空:False)
 objgs_PaperVerEN.Memo = objDT.Rows[0][congs_PaperVer.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsgs_PaperVerDA: Getgs_PaperVer)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngPaperVId">表关键字</param>
 /// <returns>表对象</returns>
public clsgs_PaperVerEN GetObjByPaperVId(long lngPaperVId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PaperVerDA.GetSpecSQLObj();
strSQL = "Select * from gs_PaperVer where PaperVId = " + ""+ lngPaperVId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsgs_PaperVerEN objgs_PaperVerEN = new clsgs_PaperVerEN();
try
{
 objgs_PaperVerEN.PaperVId = Int32.Parse(objRow[congs_PaperVer.PaperVId].ToString().Trim()); //PaperVId(字段类型:bigint,字段长度:8,是否可空:False)
 objgs_PaperVerEN.PaperId = objRow[congs_PaperVer.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objgs_PaperVerEN.PaperTitle = objRow[congs_PaperVer.PaperTitle].ToString().Trim(); //论文标题(字段类型:varchar,字段长度:500,是否可空:False)
 objgs_PaperVerEN.PaperContent = objRow[congs_PaperVer.PaperContent] == DBNull.Value ? null : objRow[congs_PaperVer.PaperContent].ToString().Trim(); //主题内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objgs_PaperVerEN.Periodical = objRow[congs_PaperVer.Periodical] == DBNull.Value ? null : objRow[congs_PaperVer.Periodical].ToString().Trim(); //期刊(字段类型:varchar,字段长度:100,是否可空:True)
 objgs_PaperVerEN.Author = objRow[congs_PaperVer.Author] == DBNull.Value ? null : objRow[congs_PaperVer.Author].ToString().Trim(); //作者(字段类型:varchar,字段长度:200,是否可空:True)
 objgs_PaperVerEN.ResearchQuestion = objRow[congs_PaperVer.ResearchQuestion] == DBNull.Value ? null : objRow[congs_PaperVer.ResearchQuestion].ToString().Trim(); //研究问题(字段类型:varchar,字段长度:2000,是否可空:True)
 objgs_PaperVerEN.Keyword = objRow[congs_PaperVer.Keyword] == DBNull.Value ? null : objRow[congs_PaperVer.Keyword].ToString().Trim(); //关键字(字段类型:varchar,字段长度:1000,是否可空:True)
 objgs_PaperVerEN.LiteratureSources = objRow[congs_PaperVer.LiteratureSources] == DBNull.Value ? null : objRow[congs_PaperVer.LiteratureSources].ToString().Trim(); //文献来源(字段类型:varchar,字段长度:1000,是否可空:True)
 objgs_PaperVerEN.LiteratureLink = objRow[congs_PaperVer.LiteratureLink] == DBNull.Value ? null : objRow[congs_PaperVer.LiteratureLink].ToString().Trim(); //文献链接(字段类型:varchar,字段长度:1000,是否可空:True)
 objgs_PaperVerEN.UploadfileUrl = objRow[congs_PaperVer.UploadfileUrl] == DBNull.Value ? null : objRow[congs_PaperVer.UploadfileUrl].ToString().Trim(); //文件地址(字段类型:varchar,字段长度:1000,是否可空:True)
 objgs_PaperVerEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[congs_PaperVer.IsQuotethesis].ToString().Trim()); //是否引用论文(字段类型:bit,字段长度:1,是否可空:True)
 objgs_PaperVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[congs_PaperVer.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objgs_PaperVerEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[congs_PaperVer.IsChecked].ToString().Trim()); //是否检查(字段类型:bit,字段长度:1,是否可空:True)
 objgs_PaperVerEN.QuoteId = objRow[congs_PaperVer.QuoteId] == DBNull.Value ? null : objRow[congs_PaperVer.QuoteId].ToString().Trim(); //引用Id(字段类型:char,字段长度:8,是否可空:True)
 objgs_PaperVerEN.Checker = objRow[congs_PaperVer.Checker] == DBNull.Value ? null : objRow[congs_PaperVer.Checker].ToString().Trim(); //审核人(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_PaperVerEN.LiteratureTypeId = objRow[congs_PaperVer.LiteratureTypeId].ToString().Trim(); //文献类型Id(字段类型:char,字段长度:2,是否可空:False)
 objgs_PaperVerEN.UpdUser = objRow[congs_PaperVer.UpdUser] == DBNull.Value ? null : objRow[congs_PaperVer.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_PaperVerEN.UpdDate = objRow[congs_PaperVer.UpdDate] == DBNull.Value ? null : objRow[congs_PaperVer.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_PaperVerEN.IdCurrEduCls = objRow[congs_PaperVer.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_PaperVer.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objgs_PaperVerEN.PaperTypeId = objRow[congs_PaperVer.PaperTypeId] == DBNull.Value ? null : objRow[congs_PaperVer.PaperTypeId].ToString().Trim(); //论文类型Id(字段类型:char,字段长度:2,是否可空:True)
 objgs_PaperVerEN.PaperStatusId = objRow[congs_PaperVer.PaperStatusId] == DBNull.Value ? null : objRow[congs_PaperVer.PaperStatusId].ToString().Trim(); //论文状态Id(字段类型:char,字段长度:2,是否可空:False)
 objgs_PaperVerEN.Memo = objRow[congs_PaperVer.Memo] == DBNull.Value ? null : objRow[congs_PaperVer.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsgs_PaperVerDA: GetObjByPaperVId)", objException.Message));
}
return objgs_PaperVerEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsgs_PaperVerEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsgs_PaperVerDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PaperVerDA.GetSpecSQLObj();
strSQL = "Select * from gs_PaperVer where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsgs_PaperVerEN objgs_PaperVerEN = new clsgs_PaperVerEN()
{
PaperVId = TransNullToInt(objRow[congs_PaperVer.PaperVId].ToString().Trim()), //PaperVId
PaperId = objRow[congs_PaperVer.PaperId].ToString().Trim(), //论文Id
PaperTitle = objRow[congs_PaperVer.PaperTitle].ToString().Trim(), //论文标题
PaperContent = objRow[congs_PaperVer.PaperContent] == DBNull.Value ? null : objRow[congs_PaperVer.PaperContent].ToString().Trim(), //主题内容
Periodical = objRow[congs_PaperVer.Periodical] == DBNull.Value ? null : objRow[congs_PaperVer.Periodical].ToString().Trim(), //期刊
Author = objRow[congs_PaperVer.Author] == DBNull.Value ? null : objRow[congs_PaperVer.Author].ToString().Trim(), //作者
ResearchQuestion = objRow[congs_PaperVer.ResearchQuestion] == DBNull.Value ? null : objRow[congs_PaperVer.ResearchQuestion].ToString().Trim(), //研究问题
Keyword = objRow[congs_PaperVer.Keyword] == DBNull.Value ? null : objRow[congs_PaperVer.Keyword].ToString().Trim(), //关键字
LiteratureSources = objRow[congs_PaperVer.LiteratureSources] == DBNull.Value ? null : objRow[congs_PaperVer.LiteratureSources].ToString().Trim(), //文献来源
LiteratureLink = objRow[congs_PaperVer.LiteratureLink] == DBNull.Value ? null : objRow[congs_PaperVer.LiteratureLink].ToString().Trim(), //文献链接
UploadfileUrl = objRow[congs_PaperVer.UploadfileUrl] == DBNull.Value ? null : objRow[congs_PaperVer.UploadfileUrl].ToString().Trim(), //文件地址
IsQuotethesis = TransNullToBool(objRow[congs_PaperVer.IsQuotethesis].ToString().Trim()), //是否引用论文
IsSubmit = TransNullToBool(objRow[congs_PaperVer.IsSubmit].ToString().Trim()), //是否提交
IsChecked = TransNullToBool(objRow[congs_PaperVer.IsChecked].ToString().Trim()), //是否检查
QuoteId = objRow[congs_PaperVer.QuoteId] == DBNull.Value ? null : objRow[congs_PaperVer.QuoteId].ToString().Trim(), //引用Id
Checker = objRow[congs_PaperVer.Checker] == DBNull.Value ? null : objRow[congs_PaperVer.Checker].ToString().Trim(), //审核人
LiteratureTypeId = objRow[congs_PaperVer.LiteratureTypeId].ToString().Trim(), //文献类型Id
UpdUser = objRow[congs_PaperVer.UpdUser] == DBNull.Value ? null : objRow[congs_PaperVer.UpdUser].ToString().Trim(), //修改人
UpdDate = objRow[congs_PaperVer.UpdDate] == DBNull.Value ? null : objRow[congs_PaperVer.UpdDate].ToString().Trim(), //修改日期
IdCurrEduCls = objRow[congs_PaperVer.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_PaperVer.IdCurrEduCls].ToString().Trim(), //教学班流水号
PaperTypeId = objRow[congs_PaperVer.PaperTypeId] == DBNull.Value ? null : objRow[congs_PaperVer.PaperTypeId].ToString().Trim(), //论文类型Id
PaperStatusId = objRow[congs_PaperVer.PaperStatusId] == DBNull.Value ? null : objRow[congs_PaperVer.PaperStatusId].ToString().Trim(), //论文状态Id
Memo = objRow[congs_PaperVer.Memo] == DBNull.Value ? null : objRow[congs_PaperVer.Memo].ToString().Trim() //备注
};
objgs_PaperVerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objgs_PaperVerEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsgs_PaperVerDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsgs_PaperVerEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsgs_PaperVerEN objgs_PaperVerEN = new clsgs_PaperVerEN();
try
{
objgs_PaperVerEN.PaperVId = TransNullToInt(objRow[congs_PaperVer.PaperVId].ToString().Trim()); //PaperVId
objgs_PaperVerEN.PaperId = objRow[congs_PaperVer.PaperId].ToString().Trim(); //论文Id
objgs_PaperVerEN.PaperTitle = objRow[congs_PaperVer.PaperTitle].ToString().Trim(); //论文标题
objgs_PaperVerEN.PaperContent = objRow[congs_PaperVer.PaperContent] == DBNull.Value ? null : objRow[congs_PaperVer.PaperContent].ToString().Trim(); //主题内容
objgs_PaperVerEN.Periodical = objRow[congs_PaperVer.Periodical] == DBNull.Value ? null : objRow[congs_PaperVer.Periodical].ToString().Trim(); //期刊
objgs_PaperVerEN.Author = objRow[congs_PaperVer.Author] == DBNull.Value ? null : objRow[congs_PaperVer.Author].ToString().Trim(); //作者
objgs_PaperVerEN.ResearchQuestion = objRow[congs_PaperVer.ResearchQuestion] == DBNull.Value ? null : objRow[congs_PaperVer.ResearchQuestion].ToString().Trim(); //研究问题
objgs_PaperVerEN.Keyword = objRow[congs_PaperVer.Keyword] == DBNull.Value ? null : objRow[congs_PaperVer.Keyword].ToString().Trim(); //关键字
objgs_PaperVerEN.LiteratureSources = objRow[congs_PaperVer.LiteratureSources] == DBNull.Value ? null : objRow[congs_PaperVer.LiteratureSources].ToString().Trim(); //文献来源
objgs_PaperVerEN.LiteratureLink = objRow[congs_PaperVer.LiteratureLink] == DBNull.Value ? null : objRow[congs_PaperVer.LiteratureLink].ToString().Trim(); //文献链接
objgs_PaperVerEN.UploadfileUrl = objRow[congs_PaperVer.UploadfileUrl] == DBNull.Value ? null : objRow[congs_PaperVer.UploadfileUrl].ToString().Trim(); //文件地址
objgs_PaperVerEN.IsQuotethesis = TransNullToBool(objRow[congs_PaperVer.IsQuotethesis].ToString().Trim()); //是否引用论文
objgs_PaperVerEN.IsSubmit = TransNullToBool(objRow[congs_PaperVer.IsSubmit].ToString().Trim()); //是否提交
objgs_PaperVerEN.IsChecked = TransNullToBool(objRow[congs_PaperVer.IsChecked].ToString().Trim()); //是否检查
objgs_PaperVerEN.QuoteId = objRow[congs_PaperVer.QuoteId] == DBNull.Value ? null : objRow[congs_PaperVer.QuoteId].ToString().Trim(); //引用Id
objgs_PaperVerEN.Checker = objRow[congs_PaperVer.Checker] == DBNull.Value ? null : objRow[congs_PaperVer.Checker].ToString().Trim(); //审核人
objgs_PaperVerEN.LiteratureTypeId = objRow[congs_PaperVer.LiteratureTypeId].ToString().Trim(); //文献类型Id
objgs_PaperVerEN.UpdUser = objRow[congs_PaperVer.UpdUser] == DBNull.Value ? null : objRow[congs_PaperVer.UpdUser].ToString().Trim(); //修改人
objgs_PaperVerEN.UpdDate = objRow[congs_PaperVer.UpdDate] == DBNull.Value ? null : objRow[congs_PaperVer.UpdDate].ToString().Trim(); //修改日期
objgs_PaperVerEN.IdCurrEduCls = objRow[congs_PaperVer.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_PaperVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_PaperVerEN.PaperTypeId = objRow[congs_PaperVer.PaperTypeId] == DBNull.Value ? null : objRow[congs_PaperVer.PaperTypeId].ToString().Trim(); //论文类型Id
objgs_PaperVerEN.PaperStatusId = objRow[congs_PaperVer.PaperStatusId] == DBNull.Value ? null : objRow[congs_PaperVer.PaperStatusId].ToString().Trim(); //论文状态Id
objgs_PaperVerEN.Memo = objRow[congs_PaperVer.Memo] == DBNull.Value ? null : objRow[congs_PaperVer.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsgs_PaperVerDA: GetObjByDataRowgs_PaperVer)", objException.Message));
}
objgs_PaperVerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objgs_PaperVerEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsgs_PaperVerEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsgs_PaperVerEN objgs_PaperVerEN = new clsgs_PaperVerEN();
try
{
objgs_PaperVerEN.PaperVId = TransNullToInt(objRow[congs_PaperVer.PaperVId].ToString().Trim()); //PaperVId
objgs_PaperVerEN.PaperId = objRow[congs_PaperVer.PaperId].ToString().Trim(); //论文Id
objgs_PaperVerEN.PaperTitle = objRow[congs_PaperVer.PaperTitle].ToString().Trim(); //论文标题
objgs_PaperVerEN.PaperContent = objRow[congs_PaperVer.PaperContent] == DBNull.Value ? null : objRow[congs_PaperVer.PaperContent].ToString().Trim(); //主题内容
objgs_PaperVerEN.Periodical = objRow[congs_PaperVer.Periodical] == DBNull.Value ? null : objRow[congs_PaperVer.Periodical].ToString().Trim(); //期刊
objgs_PaperVerEN.Author = objRow[congs_PaperVer.Author] == DBNull.Value ? null : objRow[congs_PaperVer.Author].ToString().Trim(); //作者
objgs_PaperVerEN.ResearchQuestion = objRow[congs_PaperVer.ResearchQuestion] == DBNull.Value ? null : objRow[congs_PaperVer.ResearchQuestion].ToString().Trim(); //研究问题
objgs_PaperVerEN.Keyword = objRow[congs_PaperVer.Keyword] == DBNull.Value ? null : objRow[congs_PaperVer.Keyword].ToString().Trim(); //关键字
objgs_PaperVerEN.LiteratureSources = objRow[congs_PaperVer.LiteratureSources] == DBNull.Value ? null : objRow[congs_PaperVer.LiteratureSources].ToString().Trim(); //文献来源
objgs_PaperVerEN.LiteratureLink = objRow[congs_PaperVer.LiteratureLink] == DBNull.Value ? null : objRow[congs_PaperVer.LiteratureLink].ToString().Trim(); //文献链接
objgs_PaperVerEN.UploadfileUrl = objRow[congs_PaperVer.UploadfileUrl] == DBNull.Value ? null : objRow[congs_PaperVer.UploadfileUrl].ToString().Trim(); //文件地址
objgs_PaperVerEN.IsQuotethesis = TransNullToBool(objRow[congs_PaperVer.IsQuotethesis].ToString().Trim()); //是否引用论文
objgs_PaperVerEN.IsSubmit = TransNullToBool(objRow[congs_PaperVer.IsSubmit].ToString().Trim()); //是否提交
objgs_PaperVerEN.IsChecked = TransNullToBool(objRow[congs_PaperVer.IsChecked].ToString().Trim()); //是否检查
objgs_PaperVerEN.QuoteId = objRow[congs_PaperVer.QuoteId] == DBNull.Value ? null : objRow[congs_PaperVer.QuoteId].ToString().Trim(); //引用Id
objgs_PaperVerEN.Checker = objRow[congs_PaperVer.Checker] == DBNull.Value ? null : objRow[congs_PaperVer.Checker].ToString().Trim(); //审核人
objgs_PaperVerEN.LiteratureTypeId = objRow[congs_PaperVer.LiteratureTypeId].ToString().Trim(); //文献类型Id
objgs_PaperVerEN.UpdUser = objRow[congs_PaperVer.UpdUser] == DBNull.Value ? null : objRow[congs_PaperVer.UpdUser].ToString().Trim(); //修改人
objgs_PaperVerEN.UpdDate = objRow[congs_PaperVer.UpdDate] == DBNull.Value ? null : objRow[congs_PaperVer.UpdDate].ToString().Trim(); //修改日期
objgs_PaperVerEN.IdCurrEduCls = objRow[congs_PaperVer.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_PaperVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_PaperVerEN.PaperTypeId = objRow[congs_PaperVer.PaperTypeId] == DBNull.Value ? null : objRow[congs_PaperVer.PaperTypeId].ToString().Trim(); //论文类型Id
objgs_PaperVerEN.PaperStatusId = objRow[congs_PaperVer.PaperStatusId] == DBNull.Value ? null : objRow[congs_PaperVer.PaperStatusId].ToString().Trim(); //论文状态Id
objgs_PaperVerEN.Memo = objRow[congs_PaperVer.Memo] == DBNull.Value ? null : objRow[congs_PaperVer.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsgs_PaperVerDA: GetObjByDataRow)", objException.Message));
}
objgs_PaperVerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objgs_PaperVerEN;
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
objSQL = clsgs_PaperVerDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsgs_PaperVerEN._CurrTabName, congs_PaperVer.PaperVId, 8, "");
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
objSQL = clsgs_PaperVerDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsgs_PaperVerEN._CurrTabName, congs_PaperVer.PaperVId, 8, strPrefix);
return strMaxValue;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstID)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public long GetFirstID(string strCondition) 
{
string strSQL ;
 System.Data.DataTable objDT ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PaperVerDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select PaperVId from gs_PaperVer where " + strCondition;
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
return 0;
}
strKeyValue = objDT.Rows[0][0].ToString();
return long.Parse(strKeyValue);
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
 objSQL = clsgs_PaperVerDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select PaperVId from gs_PaperVer where " + strCondition;
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
 /// <param name = "lngPaperVId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngPaperVId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PaperVerDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("gs_PaperVer", "PaperVId = " + ""+ lngPaperVId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsgs_PaperVerDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PaperVerDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("gs_PaperVer", strCondition))
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
objSQL = clsgs_PaperVerDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("gs_PaperVer");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsgs_PaperVerEN objgs_PaperVerEN)
 {
 if (objgs_PaperVerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objgs_PaperVerEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PaperVerDA.GetSpecSQLObj();
strSQL = "Select * from gs_PaperVer where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "gs_PaperVer");
objRow = objDS.Tables["gs_PaperVer"].NewRow();
objRow[congs_PaperVer.PaperId] = objgs_PaperVerEN.PaperId; //论文Id
objRow[congs_PaperVer.PaperTitle] = objgs_PaperVerEN.PaperTitle; //论文标题
 if (objgs_PaperVerEN.PaperContent !=  "")
 {
objRow[congs_PaperVer.PaperContent] = objgs_PaperVerEN.PaperContent; //主题内容
 }
 if (objgs_PaperVerEN.Periodical !=  "")
 {
objRow[congs_PaperVer.Periodical] = objgs_PaperVerEN.Periodical; //期刊
 }
 if (objgs_PaperVerEN.Author !=  "")
 {
objRow[congs_PaperVer.Author] = objgs_PaperVerEN.Author; //作者
 }
 if (objgs_PaperVerEN.ResearchQuestion !=  "")
 {
objRow[congs_PaperVer.ResearchQuestion] = objgs_PaperVerEN.ResearchQuestion; //研究问题
 }
 if (objgs_PaperVerEN.Keyword !=  "")
 {
objRow[congs_PaperVer.Keyword] = objgs_PaperVerEN.Keyword; //关键字
 }
 if (objgs_PaperVerEN.LiteratureSources !=  "")
 {
objRow[congs_PaperVer.LiteratureSources] = objgs_PaperVerEN.LiteratureSources; //文献来源
 }
 if (objgs_PaperVerEN.LiteratureLink !=  "")
 {
objRow[congs_PaperVer.LiteratureLink] = objgs_PaperVerEN.LiteratureLink; //文献链接
 }
 if (objgs_PaperVerEN.UploadfileUrl !=  "")
 {
objRow[congs_PaperVer.UploadfileUrl] = objgs_PaperVerEN.UploadfileUrl; //文件地址
 }
objRow[congs_PaperVer.IsQuotethesis] = objgs_PaperVerEN.IsQuotethesis; //是否引用论文
objRow[congs_PaperVer.IsSubmit] = objgs_PaperVerEN.IsSubmit; //是否提交
objRow[congs_PaperVer.IsChecked] = objgs_PaperVerEN.IsChecked; //是否检查
 if (objgs_PaperVerEN.QuoteId !=  "")
 {
objRow[congs_PaperVer.QuoteId] = objgs_PaperVerEN.QuoteId; //引用Id
 }
 if (objgs_PaperVerEN.Checker !=  "")
 {
objRow[congs_PaperVer.Checker] = objgs_PaperVerEN.Checker; //审核人
 }
objRow[congs_PaperVer.LiteratureTypeId] = objgs_PaperVerEN.LiteratureTypeId; //文献类型Id
 if (objgs_PaperVerEN.UpdUser !=  "")
 {
objRow[congs_PaperVer.UpdUser] = objgs_PaperVerEN.UpdUser; //修改人
 }
 if (objgs_PaperVerEN.UpdDate !=  "")
 {
objRow[congs_PaperVer.UpdDate] = objgs_PaperVerEN.UpdDate; //修改日期
 }
 if (objgs_PaperVerEN.IdCurrEduCls !=  "")
 {
objRow[congs_PaperVer.IdCurrEduCls] = objgs_PaperVerEN.IdCurrEduCls; //教学班流水号
 }
 if (objgs_PaperVerEN.PaperTypeId !=  "")
 {
objRow[congs_PaperVer.PaperTypeId] = objgs_PaperVerEN.PaperTypeId; //论文类型Id
 }
 if (objgs_PaperVerEN.PaperStatusId !=  "")
 {
objRow[congs_PaperVer.PaperStatusId] = objgs_PaperVerEN.PaperStatusId; //论文状态Id
 }
 if (objgs_PaperVerEN.Memo !=  "")
 {
objRow[congs_PaperVer.Memo] = objgs_PaperVerEN.Memo; //备注
 }
objDS.Tables[clsgs_PaperVerEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsgs_PaperVerEN._CurrTabName);
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
 /// <param name = "objgs_PaperVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsgs_PaperVerEN objgs_PaperVerEN)
{
 if (objgs_PaperVerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objgs_PaperVerEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objgs_PaperVerEN.PaperId !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.PaperId);
 var strPaperId = objgs_PaperVerEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperId + "'");
 }
 
 if (objgs_PaperVerEN.PaperTitle !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.PaperTitle);
 var strPaperTitle = objgs_PaperVerEN.PaperTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperTitle + "'");
 }
 
 if (objgs_PaperVerEN.PaperContent !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.PaperContent);
 var strPaperContent = objgs_PaperVerEN.PaperContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperContent + "'");
 }
 
 if (objgs_PaperVerEN.Periodical !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.Periodical);
 var strPeriodical = objgs_PaperVerEN.Periodical.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPeriodical + "'");
 }
 
 if (objgs_PaperVerEN.Author !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.Author);
 var strAuthor = objgs_PaperVerEN.Author.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAuthor + "'");
 }
 
 if (objgs_PaperVerEN.ResearchQuestion !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.ResearchQuestion);
 var strResearchQuestion = objgs_PaperVerEN.ResearchQuestion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResearchQuestion + "'");
 }
 
 if (objgs_PaperVerEN.Keyword !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.Keyword);
 var strKeyword = objgs_PaperVerEN.Keyword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyword + "'");
 }
 
 if (objgs_PaperVerEN.LiteratureSources !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.LiteratureSources);
 var strLiteratureSources = objgs_PaperVerEN.LiteratureSources.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLiteratureSources + "'");
 }
 
 if (objgs_PaperVerEN.LiteratureLink !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.LiteratureLink);
 var strLiteratureLink = objgs_PaperVerEN.LiteratureLink.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLiteratureLink + "'");
 }
 
 if (objgs_PaperVerEN.UploadfileUrl !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.UploadfileUrl);
 var strUploadfileUrl = objgs_PaperVerEN.UploadfileUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUploadfileUrl + "'");
 }
 
 arrFieldListForInsert.Add(congs_PaperVer.IsQuotethesis);
 arrValueListForInsert.Add("'" + (objgs_PaperVerEN.IsQuotethesis  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(congs_PaperVer.IsSubmit);
 arrValueListForInsert.Add("'" + (objgs_PaperVerEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(congs_PaperVer.IsChecked);
 arrValueListForInsert.Add("'" + (objgs_PaperVerEN.IsChecked  ==  false ? "0" : "1") + "'");
 
 if (objgs_PaperVerEN.QuoteId !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.QuoteId);
 var strQuoteId = objgs_PaperVerEN.QuoteId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuoteId + "'");
 }
 
 if (objgs_PaperVerEN.Checker !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.Checker);
 var strChecker = objgs_PaperVerEN.Checker.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strChecker + "'");
 }
 
 if (objgs_PaperVerEN.LiteratureTypeId !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.LiteratureTypeId);
 var strLiteratureTypeId = objgs_PaperVerEN.LiteratureTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLiteratureTypeId + "'");
 }
 
 if (objgs_PaperVerEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.UpdUser);
 var strUpdUser = objgs_PaperVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objgs_PaperVerEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.UpdDate);
 var strUpdDate = objgs_PaperVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objgs_PaperVerEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.IdCurrEduCls);
 var strIdCurrEduCls = objgs_PaperVerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objgs_PaperVerEN.PaperTypeId !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.PaperTypeId);
 var strPaperTypeId = objgs_PaperVerEN.PaperTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperTypeId + "'");
 }
 
 if (objgs_PaperVerEN.PaperStatusId !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.PaperStatusId);
 var strPaperStatusId = objgs_PaperVerEN.PaperStatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperStatusId + "'");
 }
 
 if (objgs_PaperVerEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.Memo);
 var strMemo = objgs_PaperVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into gs_PaperVer");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PaperVerDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objgs_PaperVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsgs_PaperVerEN objgs_PaperVerEN)
{
 if (objgs_PaperVerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objgs_PaperVerEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objgs_PaperVerEN.PaperId !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.PaperId);
 var strPaperId = objgs_PaperVerEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperId + "'");
 }
 
 if (objgs_PaperVerEN.PaperTitle !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.PaperTitle);
 var strPaperTitle = objgs_PaperVerEN.PaperTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperTitle + "'");
 }
 
 if (objgs_PaperVerEN.PaperContent !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.PaperContent);
 var strPaperContent = objgs_PaperVerEN.PaperContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperContent + "'");
 }
 
 if (objgs_PaperVerEN.Periodical !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.Periodical);
 var strPeriodical = objgs_PaperVerEN.Periodical.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPeriodical + "'");
 }
 
 if (objgs_PaperVerEN.Author !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.Author);
 var strAuthor = objgs_PaperVerEN.Author.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAuthor + "'");
 }
 
 if (objgs_PaperVerEN.ResearchQuestion !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.ResearchQuestion);
 var strResearchQuestion = objgs_PaperVerEN.ResearchQuestion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResearchQuestion + "'");
 }
 
 if (objgs_PaperVerEN.Keyword !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.Keyword);
 var strKeyword = objgs_PaperVerEN.Keyword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyword + "'");
 }
 
 if (objgs_PaperVerEN.LiteratureSources !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.LiteratureSources);
 var strLiteratureSources = objgs_PaperVerEN.LiteratureSources.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLiteratureSources + "'");
 }
 
 if (objgs_PaperVerEN.LiteratureLink !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.LiteratureLink);
 var strLiteratureLink = objgs_PaperVerEN.LiteratureLink.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLiteratureLink + "'");
 }
 
 if (objgs_PaperVerEN.UploadfileUrl !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.UploadfileUrl);
 var strUploadfileUrl = objgs_PaperVerEN.UploadfileUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUploadfileUrl + "'");
 }
 
 arrFieldListForInsert.Add(congs_PaperVer.IsQuotethesis);
 arrValueListForInsert.Add("'" + (objgs_PaperVerEN.IsQuotethesis  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(congs_PaperVer.IsSubmit);
 arrValueListForInsert.Add("'" + (objgs_PaperVerEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(congs_PaperVer.IsChecked);
 arrValueListForInsert.Add("'" + (objgs_PaperVerEN.IsChecked  ==  false ? "0" : "1") + "'");
 
 if (objgs_PaperVerEN.QuoteId !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.QuoteId);
 var strQuoteId = objgs_PaperVerEN.QuoteId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuoteId + "'");
 }
 
 if (objgs_PaperVerEN.Checker !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.Checker);
 var strChecker = objgs_PaperVerEN.Checker.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strChecker + "'");
 }
 
 if (objgs_PaperVerEN.LiteratureTypeId !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.LiteratureTypeId);
 var strLiteratureTypeId = objgs_PaperVerEN.LiteratureTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLiteratureTypeId + "'");
 }
 
 if (objgs_PaperVerEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.UpdUser);
 var strUpdUser = objgs_PaperVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objgs_PaperVerEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.UpdDate);
 var strUpdDate = objgs_PaperVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objgs_PaperVerEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.IdCurrEduCls);
 var strIdCurrEduCls = objgs_PaperVerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objgs_PaperVerEN.PaperTypeId !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.PaperTypeId);
 var strPaperTypeId = objgs_PaperVerEN.PaperTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperTypeId + "'");
 }
 
 if (objgs_PaperVerEN.PaperStatusId !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.PaperStatusId);
 var strPaperStatusId = objgs_PaperVerEN.PaperStatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperStatusId + "'");
 }
 
 if (objgs_PaperVerEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.Memo);
 var strMemo = objgs_PaperVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into gs_PaperVer");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PaperVerDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objgs_PaperVerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsgs_PaperVerEN objgs_PaperVerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objgs_PaperVerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objgs_PaperVerEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objgs_PaperVerEN.PaperId !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.PaperId);
 var strPaperId = objgs_PaperVerEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperId + "'");
 }
 
 if (objgs_PaperVerEN.PaperTitle !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.PaperTitle);
 var strPaperTitle = objgs_PaperVerEN.PaperTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperTitle + "'");
 }
 
 if (objgs_PaperVerEN.PaperContent !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.PaperContent);
 var strPaperContent = objgs_PaperVerEN.PaperContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperContent + "'");
 }
 
 if (objgs_PaperVerEN.Periodical !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.Periodical);
 var strPeriodical = objgs_PaperVerEN.Periodical.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPeriodical + "'");
 }
 
 if (objgs_PaperVerEN.Author !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.Author);
 var strAuthor = objgs_PaperVerEN.Author.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAuthor + "'");
 }
 
 if (objgs_PaperVerEN.ResearchQuestion !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.ResearchQuestion);
 var strResearchQuestion = objgs_PaperVerEN.ResearchQuestion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResearchQuestion + "'");
 }
 
 if (objgs_PaperVerEN.Keyword !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.Keyword);
 var strKeyword = objgs_PaperVerEN.Keyword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyword + "'");
 }
 
 if (objgs_PaperVerEN.LiteratureSources !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.LiteratureSources);
 var strLiteratureSources = objgs_PaperVerEN.LiteratureSources.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLiteratureSources + "'");
 }
 
 if (objgs_PaperVerEN.LiteratureLink !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.LiteratureLink);
 var strLiteratureLink = objgs_PaperVerEN.LiteratureLink.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLiteratureLink + "'");
 }
 
 if (objgs_PaperVerEN.UploadfileUrl !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.UploadfileUrl);
 var strUploadfileUrl = objgs_PaperVerEN.UploadfileUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUploadfileUrl + "'");
 }
 
 arrFieldListForInsert.Add(congs_PaperVer.IsQuotethesis);
 arrValueListForInsert.Add("'" + (objgs_PaperVerEN.IsQuotethesis  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(congs_PaperVer.IsSubmit);
 arrValueListForInsert.Add("'" + (objgs_PaperVerEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(congs_PaperVer.IsChecked);
 arrValueListForInsert.Add("'" + (objgs_PaperVerEN.IsChecked  ==  false ? "0" : "1") + "'");
 
 if (objgs_PaperVerEN.QuoteId !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.QuoteId);
 var strQuoteId = objgs_PaperVerEN.QuoteId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuoteId + "'");
 }
 
 if (objgs_PaperVerEN.Checker !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.Checker);
 var strChecker = objgs_PaperVerEN.Checker.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strChecker + "'");
 }
 
 if (objgs_PaperVerEN.LiteratureTypeId !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.LiteratureTypeId);
 var strLiteratureTypeId = objgs_PaperVerEN.LiteratureTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLiteratureTypeId + "'");
 }
 
 if (objgs_PaperVerEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.UpdUser);
 var strUpdUser = objgs_PaperVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objgs_PaperVerEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.UpdDate);
 var strUpdDate = objgs_PaperVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objgs_PaperVerEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.IdCurrEduCls);
 var strIdCurrEduCls = objgs_PaperVerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objgs_PaperVerEN.PaperTypeId !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.PaperTypeId);
 var strPaperTypeId = objgs_PaperVerEN.PaperTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperTypeId + "'");
 }
 
 if (objgs_PaperVerEN.PaperStatusId !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.PaperStatusId);
 var strPaperStatusId = objgs_PaperVerEN.PaperStatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperStatusId + "'");
 }
 
 if (objgs_PaperVerEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.Memo);
 var strMemo = objgs_PaperVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into gs_PaperVer");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PaperVerDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objgs_PaperVerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsgs_PaperVerEN objgs_PaperVerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objgs_PaperVerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objgs_PaperVerEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objgs_PaperVerEN.PaperId !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.PaperId);
 var strPaperId = objgs_PaperVerEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperId + "'");
 }
 
 if (objgs_PaperVerEN.PaperTitle !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.PaperTitle);
 var strPaperTitle = objgs_PaperVerEN.PaperTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperTitle + "'");
 }
 
 if (objgs_PaperVerEN.PaperContent !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.PaperContent);
 var strPaperContent = objgs_PaperVerEN.PaperContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperContent + "'");
 }
 
 if (objgs_PaperVerEN.Periodical !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.Periodical);
 var strPeriodical = objgs_PaperVerEN.Periodical.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPeriodical + "'");
 }
 
 if (objgs_PaperVerEN.Author !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.Author);
 var strAuthor = objgs_PaperVerEN.Author.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAuthor + "'");
 }
 
 if (objgs_PaperVerEN.ResearchQuestion !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.ResearchQuestion);
 var strResearchQuestion = objgs_PaperVerEN.ResearchQuestion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResearchQuestion + "'");
 }
 
 if (objgs_PaperVerEN.Keyword !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.Keyword);
 var strKeyword = objgs_PaperVerEN.Keyword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyword + "'");
 }
 
 if (objgs_PaperVerEN.LiteratureSources !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.LiteratureSources);
 var strLiteratureSources = objgs_PaperVerEN.LiteratureSources.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLiteratureSources + "'");
 }
 
 if (objgs_PaperVerEN.LiteratureLink !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.LiteratureLink);
 var strLiteratureLink = objgs_PaperVerEN.LiteratureLink.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLiteratureLink + "'");
 }
 
 if (objgs_PaperVerEN.UploadfileUrl !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.UploadfileUrl);
 var strUploadfileUrl = objgs_PaperVerEN.UploadfileUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUploadfileUrl + "'");
 }
 
 arrFieldListForInsert.Add(congs_PaperVer.IsQuotethesis);
 arrValueListForInsert.Add("'" + (objgs_PaperVerEN.IsQuotethesis  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(congs_PaperVer.IsSubmit);
 arrValueListForInsert.Add("'" + (objgs_PaperVerEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(congs_PaperVer.IsChecked);
 arrValueListForInsert.Add("'" + (objgs_PaperVerEN.IsChecked  ==  false ? "0" : "1") + "'");
 
 if (objgs_PaperVerEN.QuoteId !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.QuoteId);
 var strQuoteId = objgs_PaperVerEN.QuoteId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuoteId + "'");
 }
 
 if (objgs_PaperVerEN.Checker !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.Checker);
 var strChecker = objgs_PaperVerEN.Checker.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strChecker + "'");
 }
 
 if (objgs_PaperVerEN.LiteratureTypeId !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.LiteratureTypeId);
 var strLiteratureTypeId = objgs_PaperVerEN.LiteratureTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLiteratureTypeId + "'");
 }
 
 if (objgs_PaperVerEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.UpdUser);
 var strUpdUser = objgs_PaperVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objgs_PaperVerEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.UpdDate);
 var strUpdDate = objgs_PaperVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objgs_PaperVerEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.IdCurrEduCls);
 var strIdCurrEduCls = objgs_PaperVerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objgs_PaperVerEN.PaperTypeId !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.PaperTypeId);
 var strPaperTypeId = objgs_PaperVerEN.PaperTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperTypeId + "'");
 }
 
 if (objgs_PaperVerEN.PaperStatusId !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.PaperStatusId);
 var strPaperStatusId = objgs_PaperVerEN.PaperStatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperStatusId + "'");
 }
 
 if (objgs_PaperVerEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperVer.Memo);
 var strMemo = objgs_PaperVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into gs_PaperVer");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PaperVerDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewgs_PaperVers(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PaperVerDA.GetSpecSQLObj();
strSQL = "Select * from gs_PaperVer where PaperVId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "gs_PaperVer");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngPaperVId = TransNullToInt(oRow[congs_PaperVer.PaperVId].ToString().Trim());
if (IsExist(lngPaperVId))
{
 string strResult = "关键字变量值为:" + string.Format("PaperVId = {0}", lngPaperVId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsgs_PaperVerEN._CurrTabName ].NewRow();
objRow[congs_PaperVer.PaperId] = oRow[congs_PaperVer.PaperId].ToString().Trim(); //论文Id
objRow[congs_PaperVer.PaperTitle] = oRow[congs_PaperVer.PaperTitle].ToString().Trim(); //论文标题
objRow[congs_PaperVer.PaperContent] = oRow[congs_PaperVer.PaperContent].ToString().Trim(); //主题内容
objRow[congs_PaperVer.Periodical] = oRow[congs_PaperVer.Periodical].ToString().Trim(); //期刊
objRow[congs_PaperVer.Author] = oRow[congs_PaperVer.Author].ToString().Trim(); //作者
objRow[congs_PaperVer.ResearchQuestion] = oRow[congs_PaperVer.ResearchQuestion].ToString().Trim(); //研究问题
objRow[congs_PaperVer.Keyword] = oRow[congs_PaperVer.Keyword].ToString().Trim(); //关键字
objRow[congs_PaperVer.LiteratureSources] = oRow[congs_PaperVer.LiteratureSources].ToString().Trim(); //文献来源
objRow[congs_PaperVer.LiteratureLink] = oRow[congs_PaperVer.LiteratureLink].ToString().Trim(); //文献链接
objRow[congs_PaperVer.UploadfileUrl] = oRow[congs_PaperVer.UploadfileUrl].ToString().Trim(); //文件地址
objRow[congs_PaperVer.IsQuotethesis] = oRow[congs_PaperVer.IsQuotethesis].ToString().Trim(); //是否引用论文
objRow[congs_PaperVer.IsSubmit] = oRow[congs_PaperVer.IsSubmit].ToString().Trim(); //是否提交
objRow[congs_PaperVer.IsChecked] = oRow[congs_PaperVer.IsChecked].ToString().Trim(); //是否检查
objRow[congs_PaperVer.QuoteId] = oRow[congs_PaperVer.QuoteId].ToString().Trim(); //引用Id
objRow[congs_PaperVer.Checker] = oRow[congs_PaperVer.Checker].ToString().Trim(); //审核人
objRow[congs_PaperVer.LiteratureTypeId] = oRow[congs_PaperVer.LiteratureTypeId].ToString().Trim(); //文献类型Id
objRow[congs_PaperVer.UpdUser] = oRow[congs_PaperVer.UpdUser].ToString().Trim(); //修改人
objRow[congs_PaperVer.UpdDate] = oRow[congs_PaperVer.UpdDate].ToString().Trim(); //修改日期
objRow[congs_PaperVer.IdCurrEduCls] = oRow[congs_PaperVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objRow[congs_PaperVer.PaperTypeId] = oRow[congs_PaperVer.PaperTypeId].ToString().Trim(); //论文类型Id
objRow[congs_PaperVer.PaperStatusId] = oRow[congs_PaperVer.PaperStatusId].ToString().Trim(); //论文状态Id
objRow[congs_PaperVer.Memo] = oRow[congs_PaperVer.Memo].ToString().Trim(); //备注
 objDS.Tables[clsgs_PaperVerEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsgs_PaperVerEN._CurrTabName);
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
 /// <param name = "objgs_PaperVerEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsgs_PaperVerEN objgs_PaperVerEN)
{
 if (objgs_PaperVerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objgs_PaperVerEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PaperVerDA.GetSpecSQLObj();
strSQL = "Select * from gs_PaperVer where PaperVId = " + ""+ objgs_PaperVerEN.PaperVId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsgs_PaperVerEN._CurrTabName);
if (objDS.Tables[clsgs_PaperVerEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:PaperVId = " + ""+ objgs_PaperVerEN.PaperVId+"");
return false;
}
objRow = objDS.Tables[clsgs_PaperVerEN._CurrTabName].Rows[0];
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.PaperId))
 {
objRow[congs_PaperVer.PaperId] = objgs_PaperVerEN.PaperId; //论文Id
 }
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.PaperTitle))
 {
objRow[congs_PaperVer.PaperTitle] = objgs_PaperVerEN.PaperTitle; //论文标题
 }
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.PaperContent))
 {
objRow[congs_PaperVer.PaperContent] = objgs_PaperVerEN.PaperContent; //主题内容
 }
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.Periodical))
 {
objRow[congs_PaperVer.Periodical] = objgs_PaperVerEN.Periodical; //期刊
 }
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.Author))
 {
objRow[congs_PaperVer.Author] = objgs_PaperVerEN.Author; //作者
 }
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.ResearchQuestion))
 {
objRow[congs_PaperVer.ResearchQuestion] = objgs_PaperVerEN.ResearchQuestion; //研究问题
 }
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.Keyword))
 {
objRow[congs_PaperVer.Keyword] = objgs_PaperVerEN.Keyword; //关键字
 }
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.LiteratureSources))
 {
objRow[congs_PaperVer.LiteratureSources] = objgs_PaperVerEN.LiteratureSources; //文献来源
 }
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.LiteratureLink))
 {
objRow[congs_PaperVer.LiteratureLink] = objgs_PaperVerEN.LiteratureLink; //文献链接
 }
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.UploadfileUrl))
 {
objRow[congs_PaperVer.UploadfileUrl] = objgs_PaperVerEN.UploadfileUrl; //文件地址
 }
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.IsQuotethesis))
 {
objRow[congs_PaperVer.IsQuotethesis] = objgs_PaperVerEN.IsQuotethesis; //是否引用论文
 }
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.IsSubmit))
 {
objRow[congs_PaperVer.IsSubmit] = objgs_PaperVerEN.IsSubmit; //是否提交
 }
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.IsChecked))
 {
objRow[congs_PaperVer.IsChecked] = objgs_PaperVerEN.IsChecked; //是否检查
 }
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.QuoteId))
 {
objRow[congs_PaperVer.QuoteId] = objgs_PaperVerEN.QuoteId; //引用Id
 }
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.Checker))
 {
objRow[congs_PaperVer.Checker] = objgs_PaperVerEN.Checker; //审核人
 }
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.LiteratureTypeId))
 {
objRow[congs_PaperVer.LiteratureTypeId] = objgs_PaperVerEN.LiteratureTypeId; //文献类型Id
 }
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.UpdUser))
 {
objRow[congs_PaperVer.UpdUser] = objgs_PaperVerEN.UpdUser; //修改人
 }
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.UpdDate))
 {
objRow[congs_PaperVer.UpdDate] = objgs_PaperVerEN.UpdDate; //修改日期
 }
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.IdCurrEduCls))
 {
objRow[congs_PaperVer.IdCurrEduCls] = objgs_PaperVerEN.IdCurrEduCls; //教学班流水号
 }
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.PaperTypeId))
 {
objRow[congs_PaperVer.PaperTypeId] = objgs_PaperVerEN.PaperTypeId; //论文类型Id
 }
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.PaperStatusId))
 {
objRow[congs_PaperVer.PaperStatusId] = objgs_PaperVerEN.PaperStatusId; //论文状态Id
 }
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.Memo))
 {
objRow[congs_PaperVer.Memo] = objgs_PaperVerEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsgs_PaperVerEN._CurrTabName);
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
 /// <param name = "objgs_PaperVerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsgs_PaperVerEN objgs_PaperVerEN)
{
 if (objgs_PaperVerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objgs_PaperVerEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PaperVerDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update gs_PaperVer Set ");
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.PaperId))
 {
 if (objgs_PaperVerEN.PaperId !=  null)
 {
 var strPaperId = objgs_PaperVerEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPaperId, congs_PaperVer.PaperId); //论文Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperVer.PaperId); //论文Id
 }
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.PaperTitle))
 {
 if (objgs_PaperVerEN.PaperTitle !=  null)
 {
 var strPaperTitle = objgs_PaperVerEN.PaperTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPaperTitle, congs_PaperVer.PaperTitle); //论文标题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperVer.PaperTitle); //论文标题
 }
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.PaperContent))
 {
 if (objgs_PaperVerEN.PaperContent !=  null)
 {
 var strPaperContent = objgs_PaperVerEN.PaperContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPaperContent, congs_PaperVer.PaperContent); //主题内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperVer.PaperContent); //主题内容
 }
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.Periodical))
 {
 if (objgs_PaperVerEN.Periodical !=  null)
 {
 var strPeriodical = objgs_PaperVerEN.Periodical.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPeriodical, congs_PaperVer.Periodical); //期刊
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperVer.Periodical); //期刊
 }
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.Author))
 {
 if (objgs_PaperVerEN.Author !=  null)
 {
 var strAuthor = objgs_PaperVerEN.Author.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAuthor, congs_PaperVer.Author); //作者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperVer.Author); //作者
 }
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.ResearchQuestion))
 {
 if (objgs_PaperVerEN.ResearchQuestion !=  null)
 {
 var strResearchQuestion = objgs_PaperVerEN.ResearchQuestion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResearchQuestion, congs_PaperVer.ResearchQuestion); //研究问题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperVer.ResearchQuestion); //研究问题
 }
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.Keyword))
 {
 if (objgs_PaperVerEN.Keyword !=  null)
 {
 var strKeyword = objgs_PaperVerEN.Keyword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strKeyword, congs_PaperVer.Keyword); //关键字
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperVer.Keyword); //关键字
 }
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.LiteratureSources))
 {
 if (objgs_PaperVerEN.LiteratureSources !=  null)
 {
 var strLiteratureSources = objgs_PaperVerEN.LiteratureSources.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLiteratureSources, congs_PaperVer.LiteratureSources); //文献来源
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperVer.LiteratureSources); //文献来源
 }
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.LiteratureLink))
 {
 if (objgs_PaperVerEN.LiteratureLink !=  null)
 {
 var strLiteratureLink = objgs_PaperVerEN.LiteratureLink.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLiteratureLink, congs_PaperVer.LiteratureLink); //文献链接
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperVer.LiteratureLink); //文献链接
 }
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.UploadfileUrl))
 {
 if (objgs_PaperVerEN.UploadfileUrl !=  null)
 {
 var strUploadfileUrl = objgs_PaperVerEN.UploadfileUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUploadfileUrl, congs_PaperVer.UploadfileUrl); //文件地址
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperVer.UploadfileUrl); //文件地址
 }
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.IsQuotethesis))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objgs_PaperVerEN.IsQuotethesis == true?"1":"0", congs_PaperVer.IsQuotethesis); //是否引用论文
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objgs_PaperVerEN.IsSubmit == true?"1":"0", congs_PaperVer.IsSubmit); //是否提交
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.IsChecked))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objgs_PaperVerEN.IsChecked == true?"1":"0", congs_PaperVer.IsChecked); //是否检查
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.QuoteId))
 {
 if (objgs_PaperVerEN.QuoteId !=  null)
 {
 var strQuoteId = objgs_PaperVerEN.QuoteId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuoteId, congs_PaperVer.QuoteId); //引用Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperVer.QuoteId); //引用Id
 }
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.Checker))
 {
 if (objgs_PaperVerEN.Checker !=  null)
 {
 var strChecker = objgs_PaperVerEN.Checker.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strChecker, congs_PaperVer.Checker); //审核人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperVer.Checker); //审核人
 }
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.LiteratureTypeId))
 {
 if (objgs_PaperVerEN.LiteratureTypeId !=  null)
 {
 var strLiteratureTypeId = objgs_PaperVerEN.LiteratureTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLiteratureTypeId, congs_PaperVer.LiteratureTypeId); //文献类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperVer.LiteratureTypeId); //文献类型Id
 }
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.UpdUser))
 {
 if (objgs_PaperVerEN.UpdUser !=  null)
 {
 var strUpdUser = objgs_PaperVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, congs_PaperVer.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperVer.UpdUser); //修改人
 }
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.UpdDate))
 {
 if (objgs_PaperVerEN.UpdDate !=  null)
 {
 var strUpdDate = objgs_PaperVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, congs_PaperVer.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperVer.UpdDate); //修改日期
 }
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.IdCurrEduCls))
 {
 if (objgs_PaperVerEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objgs_PaperVerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, congs_PaperVer.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperVer.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.PaperTypeId))
 {
 if (objgs_PaperVerEN.PaperTypeId !=  null)
 {
 var strPaperTypeId = objgs_PaperVerEN.PaperTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPaperTypeId, congs_PaperVer.PaperTypeId); //论文类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperVer.PaperTypeId); //论文类型Id
 }
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.PaperStatusId))
 {
 if (objgs_PaperVerEN.PaperStatusId !=  null)
 {
 var strPaperStatusId = objgs_PaperVerEN.PaperStatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPaperStatusId, congs_PaperVer.PaperStatusId); //论文状态Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperVer.PaperStatusId); //论文状态Id
 }
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.Memo))
 {
 if (objgs_PaperVerEN.Memo !=  null)
 {
 var strMemo = objgs_PaperVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, congs_PaperVer.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperVer.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where PaperVId = {0}", objgs_PaperVerEN.PaperVId); 
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
 /// <param name = "objgs_PaperVerEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsgs_PaperVerEN objgs_PaperVerEN, string strCondition)
{
 if (objgs_PaperVerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objgs_PaperVerEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PaperVerDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update gs_PaperVer Set ");
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.PaperId))
 {
 if (objgs_PaperVerEN.PaperId !=  null)
 {
 var strPaperId = objgs_PaperVerEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PaperId = '{0}',", strPaperId); //论文Id
 }
 else
 {
 sbSQL.Append(" PaperId = null,"); //论文Id
 }
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.PaperTitle))
 {
 if (objgs_PaperVerEN.PaperTitle !=  null)
 {
 var strPaperTitle = objgs_PaperVerEN.PaperTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PaperTitle = '{0}',", strPaperTitle); //论文标题
 }
 else
 {
 sbSQL.Append(" PaperTitle = null,"); //论文标题
 }
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.PaperContent))
 {
 if (objgs_PaperVerEN.PaperContent !=  null)
 {
 var strPaperContent = objgs_PaperVerEN.PaperContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PaperContent = '{0}',", strPaperContent); //主题内容
 }
 else
 {
 sbSQL.Append(" PaperContent = null,"); //主题内容
 }
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.Periodical))
 {
 if (objgs_PaperVerEN.Periodical !=  null)
 {
 var strPeriodical = objgs_PaperVerEN.Periodical.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Periodical = '{0}',", strPeriodical); //期刊
 }
 else
 {
 sbSQL.Append(" Periodical = null,"); //期刊
 }
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.Author))
 {
 if (objgs_PaperVerEN.Author !=  null)
 {
 var strAuthor = objgs_PaperVerEN.Author.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Author = '{0}',", strAuthor); //作者
 }
 else
 {
 sbSQL.Append(" Author = null,"); //作者
 }
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.ResearchQuestion))
 {
 if (objgs_PaperVerEN.ResearchQuestion !=  null)
 {
 var strResearchQuestion = objgs_PaperVerEN.ResearchQuestion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResearchQuestion = '{0}',", strResearchQuestion); //研究问题
 }
 else
 {
 sbSQL.Append(" ResearchQuestion = null,"); //研究问题
 }
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.Keyword))
 {
 if (objgs_PaperVerEN.Keyword !=  null)
 {
 var strKeyword = objgs_PaperVerEN.Keyword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Keyword = '{0}',", strKeyword); //关键字
 }
 else
 {
 sbSQL.Append(" Keyword = null,"); //关键字
 }
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.LiteratureSources))
 {
 if (objgs_PaperVerEN.LiteratureSources !=  null)
 {
 var strLiteratureSources = objgs_PaperVerEN.LiteratureSources.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LiteratureSources = '{0}',", strLiteratureSources); //文献来源
 }
 else
 {
 sbSQL.Append(" LiteratureSources = null,"); //文献来源
 }
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.LiteratureLink))
 {
 if (objgs_PaperVerEN.LiteratureLink !=  null)
 {
 var strLiteratureLink = objgs_PaperVerEN.LiteratureLink.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LiteratureLink = '{0}',", strLiteratureLink); //文献链接
 }
 else
 {
 sbSQL.Append(" LiteratureLink = null,"); //文献链接
 }
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.UploadfileUrl))
 {
 if (objgs_PaperVerEN.UploadfileUrl !=  null)
 {
 var strUploadfileUrl = objgs_PaperVerEN.UploadfileUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UploadfileUrl = '{0}',", strUploadfileUrl); //文件地址
 }
 else
 {
 sbSQL.Append(" UploadfileUrl = null,"); //文件地址
 }
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.IsQuotethesis))
 {
 sbSQL.AppendFormat(" IsQuotethesis = '{0}',", objgs_PaperVerEN.IsQuotethesis == true?"1":"0"); //是否引用论文
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objgs_PaperVerEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.IsChecked))
 {
 sbSQL.AppendFormat(" IsChecked = '{0}',", objgs_PaperVerEN.IsChecked == true?"1":"0"); //是否检查
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.QuoteId))
 {
 if (objgs_PaperVerEN.QuoteId !=  null)
 {
 var strQuoteId = objgs_PaperVerEN.QuoteId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuoteId = '{0}',", strQuoteId); //引用Id
 }
 else
 {
 sbSQL.Append(" QuoteId = null,"); //引用Id
 }
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.Checker))
 {
 if (objgs_PaperVerEN.Checker !=  null)
 {
 var strChecker = objgs_PaperVerEN.Checker.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Checker = '{0}',", strChecker); //审核人
 }
 else
 {
 sbSQL.Append(" Checker = null,"); //审核人
 }
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.LiteratureTypeId))
 {
 if (objgs_PaperVerEN.LiteratureTypeId !=  null)
 {
 var strLiteratureTypeId = objgs_PaperVerEN.LiteratureTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LiteratureTypeId = '{0}',", strLiteratureTypeId); //文献类型Id
 }
 else
 {
 sbSQL.Append(" LiteratureTypeId = null,"); //文献类型Id
 }
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.UpdUser))
 {
 if (objgs_PaperVerEN.UpdUser !=  null)
 {
 var strUpdUser = objgs_PaperVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.UpdDate))
 {
 if (objgs_PaperVerEN.UpdDate !=  null)
 {
 var strUpdDate = objgs_PaperVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.IdCurrEduCls))
 {
 if (objgs_PaperVerEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objgs_PaperVerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.PaperTypeId))
 {
 if (objgs_PaperVerEN.PaperTypeId !=  null)
 {
 var strPaperTypeId = objgs_PaperVerEN.PaperTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PaperTypeId = '{0}',", strPaperTypeId); //论文类型Id
 }
 else
 {
 sbSQL.Append(" PaperTypeId = null,"); //论文类型Id
 }
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.PaperStatusId))
 {
 if (objgs_PaperVerEN.PaperStatusId !=  null)
 {
 var strPaperStatusId = objgs_PaperVerEN.PaperStatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PaperStatusId = '{0}',", strPaperStatusId); //论文状态Id
 }
 else
 {
 sbSQL.Append(" PaperStatusId = null,"); //论文状态Id
 }
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.Memo))
 {
 if (objgs_PaperVerEN.Memo !=  null)
 {
 var strMemo = objgs_PaperVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objgs_PaperVerEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsgs_PaperVerEN objgs_PaperVerEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objgs_PaperVerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objgs_PaperVerEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PaperVerDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update gs_PaperVer Set ");
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.PaperId))
 {
 if (objgs_PaperVerEN.PaperId !=  null)
 {
 var strPaperId = objgs_PaperVerEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PaperId = '{0}',", strPaperId); //论文Id
 }
 else
 {
 sbSQL.Append(" PaperId = null,"); //论文Id
 }
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.PaperTitle))
 {
 if (objgs_PaperVerEN.PaperTitle !=  null)
 {
 var strPaperTitle = objgs_PaperVerEN.PaperTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PaperTitle = '{0}',", strPaperTitle); //论文标题
 }
 else
 {
 sbSQL.Append(" PaperTitle = null,"); //论文标题
 }
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.PaperContent))
 {
 if (objgs_PaperVerEN.PaperContent !=  null)
 {
 var strPaperContent = objgs_PaperVerEN.PaperContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PaperContent = '{0}',", strPaperContent); //主题内容
 }
 else
 {
 sbSQL.Append(" PaperContent = null,"); //主题内容
 }
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.Periodical))
 {
 if (objgs_PaperVerEN.Periodical !=  null)
 {
 var strPeriodical = objgs_PaperVerEN.Periodical.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Periodical = '{0}',", strPeriodical); //期刊
 }
 else
 {
 sbSQL.Append(" Periodical = null,"); //期刊
 }
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.Author))
 {
 if (objgs_PaperVerEN.Author !=  null)
 {
 var strAuthor = objgs_PaperVerEN.Author.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Author = '{0}',", strAuthor); //作者
 }
 else
 {
 sbSQL.Append(" Author = null,"); //作者
 }
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.ResearchQuestion))
 {
 if (objgs_PaperVerEN.ResearchQuestion !=  null)
 {
 var strResearchQuestion = objgs_PaperVerEN.ResearchQuestion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResearchQuestion = '{0}',", strResearchQuestion); //研究问题
 }
 else
 {
 sbSQL.Append(" ResearchQuestion = null,"); //研究问题
 }
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.Keyword))
 {
 if (objgs_PaperVerEN.Keyword !=  null)
 {
 var strKeyword = objgs_PaperVerEN.Keyword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Keyword = '{0}',", strKeyword); //关键字
 }
 else
 {
 sbSQL.Append(" Keyword = null,"); //关键字
 }
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.LiteratureSources))
 {
 if (objgs_PaperVerEN.LiteratureSources !=  null)
 {
 var strLiteratureSources = objgs_PaperVerEN.LiteratureSources.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LiteratureSources = '{0}',", strLiteratureSources); //文献来源
 }
 else
 {
 sbSQL.Append(" LiteratureSources = null,"); //文献来源
 }
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.LiteratureLink))
 {
 if (objgs_PaperVerEN.LiteratureLink !=  null)
 {
 var strLiteratureLink = objgs_PaperVerEN.LiteratureLink.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LiteratureLink = '{0}',", strLiteratureLink); //文献链接
 }
 else
 {
 sbSQL.Append(" LiteratureLink = null,"); //文献链接
 }
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.UploadfileUrl))
 {
 if (objgs_PaperVerEN.UploadfileUrl !=  null)
 {
 var strUploadfileUrl = objgs_PaperVerEN.UploadfileUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UploadfileUrl = '{0}',", strUploadfileUrl); //文件地址
 }
 else
 {
 sbSQL.Append(" UploadfileUrl = null,"); //文件地址
 }
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.IsQuotethesis))
 {
 sbSQL.AppendFormat(" IsQuotethesis = '{0}',", objgs_PaperVerEN.IsQuotethesis == true?"1":"0"); //是否引用论文
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objgs_PaperVerEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.IsChecked))
 {
 sbSQL.AppendFormat(" IsChecked = '{0}',", objgs_PaperVerEN.IsChecked == true?"1":"0"); //是否检查
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.QuoteId))
 {
 if (objgs_PaperVerEN.QuoteId !=  null)
 {
 var strQuoteId = objgs_PaperVerEN.QuoteId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuoteId = '{0}',", strQuoteId); //引用Id
 }
 else
 {
 sbSQL.Append(" QuoteId = null,"); //引用Id
 }
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.Checker))
 {
 if (objgs_PaperVerEN.Checker !=  null)
 {
 var strChecker = objgs_PaperVerEN.Checker.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Checker = '{0}',", strChecker); //审核人
 }
 else
 {
 sbSQL.Append(" Checker = null,"); //审核人
 }
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.LiteratureTypeId))
 {
 if (objgs_PaperVerEN.LiteratureTypeId !=  null)
 {
 var strLiteratureTypeId = objgs_PaperVerEN.LiteratureTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LiteratureTypeId = '{0}',", strLiteratureTypeId); //文献类型Id
 }
 else
 {
 sbSQL.Append(" LiteratureTypeId = null,"); //文献类型Id
 }
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.UpdUser))
 {
 if (objgs_PaperVerEN.UpdUser !=  null)
 {
 var strUpdUser = objgs_PaperVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.UpdDate))
 {
 if (objgs_PaperVerEN.UpdDate !=  null)
 {
 var strUpdDate = objgs_PaperVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.IdCurrEduCls))
 {
 if (objgs_PaperVerEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objgs_PaperVerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.PaperTypeId))
 {
 if (objgs_PaperVerEN.PaperTypeId !=  null)
 {
 var strPaperTypeId = objgs_PaperVerEN.PaperTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PaperTypeId = '{0}',", strPaperTypeId); //论文类型Id
 }
 else
 {
 sbSQL.Append(" PaperTypeId = null,"); //论文类型Id
 }
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.PaperStatusId))
 {
 if (objgs_PaperVerEN.PaperStatusId !=  null)
 {
 var strPaperStatusId = objgs_PaperVerEN.PaperStatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PaperStatusId = '{0}',", strPaperStatusId); //论文状态Id
 }
 else
 {
 sbSQL.Append(" PaperStatusId = null,"); //论文状态Id
 }
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.Memo))
 {
 if (objgs_PaperVerEN.Memo !=  null)
 {
 var strMemo = objgs_PaperVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objgs_PaperVerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsgs_PaperVerEN objgs_PaperVerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objgs_PaperVerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objgs_PaperVerEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PaperVerDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update gs_PaperVer Set ");
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.PaperId))
 {
 if (objgs_PaperVerEN.PaperId !=  null)
 {
 var strPaperId = objgs_PaperVerEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPaperId, congs_PaperVer.PaperId); //论文Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperVer.PaperId); //论文Id
 }
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.PaperTitle))
 {
 if (objgs_PaperVerEN.PaperTitle !=  null)
 {
 var strPaperTitle = objgs_PaperVerEN.PaperTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPaperTitle, congs_PaperVer.PaperTitle); //论文标题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperVer.PaperTitle); //论文标题
 }
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.PaperContent))
 {
 if (objgs_PaperVerEN.PaperContent !=  null)
 {
 var strPaperContent = objgs_PaperVerEN.PaperContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPaperContent, congs_PaperVer.PaperContent); //主题内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperVer.PaperContent); //主题内容
 }
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.Periodical))
 {
 if (objgs_PaperVerEN.Periodical !=  null)
 {
 var strPeriodical = objgs_PaperVerEN.Periodical.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPeriodical, congs_PaperVer.Periodical); //期刊
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperVer.Periodical); //期刊
 }
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.Author))
 {
 if (objgs_PaperVerEN.Author !=  null)
 {
 var strAuthor = objgs_PaperVerEN.Author.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAuthor, congs_PaperVer.Author); //作者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperVer.Author); //作者
 }
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.ResearchQuestion))
 {
 if (objgs_PaperVerEN.ResearchQuestion !=  null)
 {
 var strResearchQuestion = objgs_PaperVerEN.ResearchQuestion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResearchQuestion, congs_PaperVer.ResearchQuestion); //研究问题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperVer.ResearchQuestion); //研究问题
 }
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.Keyword))
 {
 if (objgs_PaperVerEN.Keyword !=  null)
 {
 var strKeyword = objgs_PaperVerEN.Keyword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strKeyword, congs_PaperVer.Keyword); //关键字
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperVer.Keyword); //关键字
 }
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.LiteratureSources))
 {
 if (objgs_PaperVerEN.LiteratureSources !=  null)
 {
 var strLiteratureSources = objgs_PaperVerEN.LiteratureSources.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLiteratureSources, congs_PaperVer.LiteratureSources); //文献来源
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperVer.LiteratureSources); //文献来源
 }
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.LiteratureLink))
 {
 if (objgs_PaperVerEN.LiteratureLink !=  null)
 {
 var strLiteratureLink = objgs_PaperVerEN.LiteratureLink.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLiteratureLink, congs_PaperVer.LiteratureLink); //文献链接
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperVer.LiteratureLink); //文献链接
 }
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.UploadfileUrl))
 {
 if (objgs_PaperVerEN.UploadfileUrl !=  null)
 {
 var strUploadfileUrl = objgs_PaperVerEN.UploadfileUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUploadfileUrl, congs_PaperVer.UploadfileUrl); //文件地址
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperVer.UploadfileUrl); //文件地址
 }
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.IsQuotethesis))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objgs_PaperVerEN.IsQuotethesis == true?"1":"0", congs_PaperVer.IsQuotethesis); //是否引用论文
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objgs_PaperVerEN.IsSubmit == true?"1":"0", congs_PaperVer.IsSubmit); //是否提交
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.IsChecked))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objgs_PaperVerEN.IsChecked == true?"1":"0", congs_PaperVer.IsChecked); //是否检查
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.QuoteId))
 {
 if (objgs_PaperVerEN.QuoteId !=  null)
 {
 var strQuoteId = objgs_PaperVerEN.QuoteId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuoteId, congs_PaperVer.QuoteId); //引用Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperVer.QuoteId); //引用Id
 }
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.Checker))
 {
 if (objgs_PaperVerEN.Checker !=  null)
 {
 var strChecker = objgs_PaperVerEN.Checker.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strChecker, congs_PaperVer.Checker); //审核人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperVer.Checker); //审核人
 }
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.LiteratureTypeId))
 {
 if (objgs_PaperVerEN.LiteratureTypeId !=  null)
 {
 var strLiteratureTypeId = objgs_PaperVerEN.LiteratureTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLiteratureTypeId, congs_PaperVer.LiteratureTypeId); //文献类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperVer.LiteratureTypeId); //文献类型Id
 }
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.UpdUser))
 {
 if (objgs_PaperVerEN.UpdUser !=  null)
 {
 var strUpdUser = objgs_PaperVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, congs_PaperVer.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperVer.UpdUser); //修改人
 }
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.UpdDate))
 {
 if (objgs_PaperVerEN.UpdDate !=  null)
 {
 var strUpdDate = objgs_PaperVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, congs_PaperVer.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperVer.UpdDate); //修改日期
 }
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.IdCurrEduCls))
 {
 if (objgs_PaperVerEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objgs_PaperVerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, congs_PaperVer.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperVer.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.PaperTypeId))
 {
 if (objgs_PaperVerEN.PaperTypeId !=  null)
 {
 var strPaperTypeId = objgs_PaperVerEN.PaperTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPaperTypeId, congs_PaperVer.PaperTypeId); //论文类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperVer.PaperTypeId); //论文类型Id
 }
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.PaperStatusId))
 {
 if (objgs_PaperVerEN.PaperStatusId !=  null)
 {
 var strPaperStatusId = objgs_PaperVerEN.PaperStatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPaperStatusId, congs_PaperVer.PaperStatusId); //论文状态Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperVer.PaperStatusId); //论文状态Id
 }
 }
 
 if (objgs_PaperVerEN.IsUpdated(congs_PaperVer.Memo))
 {
 if (objgs_PaperVerEN.Memo !=  null)
 {
 var strMemo = objgs_PaperVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, congs_PaperVer.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperVer.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where PaperVId = {0}", objgs_PaperVerEN.PaperVId); 
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
 /// <param name = "lngPaperVId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngPaperVId) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PaperVerDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngPaperVId,
};
 objSQL.ExecSP("gs_PaperVer_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngPaperVId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngPaperVId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PaperVerDA.GetSpecSQLObj();
//删除gs_PaperVer本表中与当前对象有关的记录
strSQL = strSQL + "Delete from gs_PaperVer where PaperVId = " + ""+ lngPaperVId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delgs_PaperVer(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PaperVerDA.GetSpecSQLObj();
string strSQL;
string strKeyList;
if (lstKey.Count  == 0) return 0;
strKeyList = "";
for (int i = 0; i<lstKey.Count; i++)
{
if (i == 0) strKeyList = strKeyList + "" + lstKey[i].ToString() + "";
else strKeyList +=  "," + "" + lstKey[i].ToString() + "";
}
strSQL = "";
//删除gs_PaperVer本表中与当前对象有关的记录
strSQL = strSQL + "Delete from gs_PaperVer where PaperVId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngPaperVId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngPaperVId) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PaperVerDA.GetSpecSQLObj();
//删除gs_PaperVer本表中与当前对象有关的记录
strSQL = strSQL + "Delete from gs_PaperVer where PaperVId = " + ""+ lngPaperVId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delgs_PaperVer(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsgs_PaperVerDA: Delgs_PaperVer)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PaperVerDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from gs_PaperVer where " + strCondition ;
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
public bool Delgs_PaperVerWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsgs_PaperVerDA: Delgs_PaperVerWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PaperVerDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from gs_PaperVer where " + strCondition ;
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
 /// <param name = "objgs_PaperVerENS">源对象</param>
 /// <param name = "objgs_PaperVerENT">目标对象</param>
public void CopyTo(clsgs_PaperVerEN objgs_PaperVerENS, clsgs_PaperVerEN objgs_PaperVerENT)
{
objgs_PaperVerENT.PaperVId = objgs_PaperVerENS.PaperVId; //PaperVId
objgs_PaperVerENT.PaperId = objgs_PaperVerENS.PaperId; //论文Id
objgs_PaperVerENT.PaperTitle = objgs_PaperVerENS.PaperTitle; //论文标题
objgs_PaperVerENT.PaperContent = objgs_PaperVerENS.PaperContent; //主题内容
objgs_PaperVerENT.Periodical = objgs_PaperVerENS.Periodical; //期刊
objgs_PaperVerENT.Author = objgs_PaperVerENS.Author; //作者
objgs_PaperVerENT.ResearchQuestion = objgs_PaperVerENS.ResearchQuestion; //研究问题
objgs_PaperVerENT.Keyword = objgs_PaperVerENS.Keyword; //关键字
objgs_PaperVerENT.LiteratureSources = objgs_PaperVerENS.LiteratureSources; //文献来源
objgs_PaperVerENT.LiteratureLink = objgs_PaperVerENS.LiteratureLink; //文献链接
objgs_PaperVerENT.UploadfileUrl = objgs_PaperVerENS.UploadfileUrl; //文件地址
objgs_PaperVerENT.IsQuotethesis = objgs_PaperVerENS.IsQuotethesis; //是否引用论文
objgs_PaperVerENT.IsSubmit = objgs_PaperVerENS.IsSubmit; //是否提交
objgs_PaperVerENT.IsChecked = objgs_PaperVerENS.IsChecked; //是否检查
objgs_PaperVerENT.QuoteId = objgs_PaperVerENS.QuoteId; //引用Id
objgs_PaperVerENT.Checker = objgs_PaperVerENS.Checker; //审核人
objgs_PaperVerENT.LiteratureTypeId = objgs_PaperVerENS.LiteratureTypeId; //文献类型Id
objgs_PaperVerENT.UpdUser = objgs_PaperVerENS.UpdUser; //修改人
objgs_PaperVerENT.UpdDate = objgs_PaperVerENS.UpdDate; //修改日期
objgs_PaperVerENT.IdCurrEduCls = objgs_PaperVerENS.IdCurrEduCls; //教学班流水号
objgs_PaperVerENT.PaperTypeId = objgs_PaperVerENS.PaperTypeId; //论文类型Id
objgs_PaperVerENT.PaperStatusId = objgs_PaperVerENS.PaperStatusId; //论文状态Id
objgs_PaperVerENT.Memo = objgs_PaperVerENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsgs_PaperVerEN objgs_PaperVerEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objgs_PaperVerEN.PaperId, congs_PaperVer.PaperId);
clsCheckSql.CheckFieldNotNull(objgs_PaperVerEN.PaperTitle, congs_PaperVer.PaperTitle);
clsCheckSql.CheckFieldNotNull(objgs_PaperVerEN.LiteratureTypeId, congs_PaperVer.LiteratureTypeId);
//检查字段长度
clsCheckSql.CheckFieldLen(objgs_PaperVerEN.PaperId, 8, congs_PaperVer.PaperId);
clsCheckSql.CheckFieldLen(objgs_PaperVerEN.PaperTitle, 500, congs_PaperVer.PaperTitle);
clsCheckSql.CheckFieldLen(objgs_PaperVerEN.Periodical, 100, congs_PaperVer.Periodical);
clsCheckSql.CheckFieldLen(objgs_PaperVerEN.Author, 200, congs_PaperVer.Author);
clsCheckSql.CheckFieldLen(objgs_PaperVerEN.ResearchQuestion, 2000, congs_PaperVer.ResearchQuestion);
clsCheckSql.CheckFieldLen(objgs_PaperVerEN.Keyword, 1000, congs_PaperVer.Keyword);
clsCheckSql.CheckFieldLen(objgs_PaperVerEN.LiteratureSources, 1000, congs_PaperVer.LiteratureSources);
clsCheckSql.CheckFieldLen(objgs_PaperVerEN.LiteratureLink, 1000, congs_PaperVer.LiteratureLink);
clsCheckSql.CheckFieldLen(objgs_PaperVerEN.UploadfileUrl, 1000, congs_PaperVer.UploadfileUrl);
clsCheckSql.CheckFieldLen(objgs_PaperVerEN.QuoteId, 8, congs_PaperVer.QuoteId);
clsCheckSql.CheckFieldLen(objgs_PaperVerEN.Checker, 20, congs_PaperVer.Checker);
clsCheckSql.CheckFieldLen(objgs_PaperVerEN.LiteratureTypeId, 2, congs_PaperVer.LiteratureTypeId);
clsCheckSql.CheckFieldLen(objgs_PaperVerEN.UpdUser, 20, congs_PaperVer.UpdUser);
clsCheckSql.CheckFieldLen(objgs_PaperVerEN.UpdDate, 20, congs_PaperVer.UpdDate);
clsCheckSql.CheckFieldLen(objgs_PaperVerEN.IdCurrEduCls, 8, congs_PaperVer.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objgs_PaperVerEN.PaperTypeId, 2, congs_PaperVer.PaperTypeId);
clsCheckSql.CheckFieldLen(objgs_PaperVerEN.PaperStatusId, 2, congs_PaperVer.PaperStatusId);
clsCheckSql.CheckFieldLen(objgs_PaperVerEN.Memo, 1000, congs_PaperVer.Memo);
//检查字段外键固定长度
 objgs_PaperVerEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsgs_PaperVerEN objgs_PaperVerEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objgs_PaperVerEN.PaperId, 8, congs_PaperVer.PaperId);
clsCheckSql.CheckFieldLen(objgs_PaperVerEN.PaperTitle, 500, congs_PaperVer.PaperTitle);
clsCheckSql.CheckFieldLen(objgs_PaperVerEN.Periodical, 100, congs_PaperVer.Periodical);
clsCheckSql.CheckFieldLen(objgs_PaperVerEN.Author, 200, congs_PaperVer.Author);
clsCheckSql.CheckFieldLen(objgs_PaperVerEN.ResearchQuestion, 2000, congs_PaperVer.ResearchQuestion);
clsCheckSql.CheckFieldLen(objgs_PaperVerEN.Keyword, 1000, congs_PaperVer.Keyword);
clsCheckSql.CheckFieldLen(objgs_PaperVerEN.LiteratureSources, 1000, congs_PaperVer.LiteratureSources);
clsCheckSql.CheckFieldLen(objgs_PaperVerEN.LiteratureLink, 1000, congs_PaperVer.LiteratureLink);
clsCheckSql.CheckFieldLen(objgs_PaperVerEN.UploadfileUrl, 1000, congs_PaperVer.UploadfileUrl);
clsCheckSql.CheckFieldLen(objgs_PaperVerEN.QuoteId, 8, congs_PaperVer.QuoteId);
clsCheckSql.CheckFieldLen(objgs_PaperVerEN.Checker, 20, congs_PaperVer.Checker);
clsCheckSql.CheckFieldLen(objgs_PaperVerEN.LiteratureTypeId, 2, congs_PaperVer.LiteratureTypeId);
clsCheckSql.CheckFieldLen(objgs_PaperVerEN.UpdUser, 20, congs_PaperVer.UpdUser);
clsCheckSql.CheckFieldLen(objgs_PaperVerEN.UpdDate, 20, congs_PaperVer.UpdDate);
clsCheckSql.CheckFieldLen(objgs_PaperVerEN.IdCurrEduCls, 8, congs_PaperVer.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objgs_PaperVerEN.PaperTypeId, 2, congs_PaperVer.PaperTypeId);
clsCheckSql.CheckFieldLen(objgs_PaperVerEN.PaperStatusId, 2, congs_PaperVer.PaperStatusId);
clsCheckSql.CheckFieldLen(objgs_PaperVerEN.Memo, 1000, congs_PaperVer.Memo);
//检查外键字段长度
 objgs_PaperVerEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsgs_PaperVerEN objgs_PaperVerEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objgs_PaperVerEN.PaperId, 8, congs_PaperVer.PaperId);
clsCheckSql.CheckFieldLen(objgs_PaperVerEN.PaperTitle, 500, congs_PaperVer.PaperTitle);
clsCheckSql.CheckFieldLen(objgs_PaperVerEN.Periodical, 100, congs_PaperVer.Periodical);
clsCheckSql.CheckFieldLen(objgs_PaperVerEN.Author, 200, congs_PaperVer.Author);
clsCheckSql.CheckFieldLen(objgs_PaperVerEN.ResearchQuestion, 2000, congs_PaperVer.ResearchQuestion);
clsCheckSql.CheckFieldLen(objgs_PaperVerEN.Keyword, 1000, congs_PaperVer.Keyword);
clsCheckSql.CheckFieldLen(objgs_PaperVerEN.LiteratureSources, 1000, congs_PaperVer.LiteratureSources);
clsCheckSql.CheckFieldLen(objgs_PaperVerEN.LiteratureLink, 1000, congs_PaperVer.LiteratureLink);
clsCheckSql.CheckFieldLen(objgs_PaperVerEN.UploadfileUrl, 1000, congs_PaperVer.UploadfileUrl);
clsCheckSql.CheckFieldLen(objgs_PaperVerEN.QuoteId, 8, congs_PaperVer.QuoteId);
clsCheckSql.CheckFieldLen(objgs_PaperVerEN.Checker, 20, congs_PaperVer.Checker);
clsCheckSql.CheckFieldLen(objgs_PaperVerEN.LiteratureTypeId, 2, congs_PaperVer.LiteratureTypeId);
clsCheckSql.CheckFieldLen(objgs_PaperVerEN.UpdUser, 20, congs_PaperVer.UpdUser);
clsCheckSql.CheckFieldLen(objgs_PaperVerEN.UpdDate, 20, congs_PaperVer.UpdDate);
clsCheckSql.CheckFieldLen(objgs_PaperVerEN.IdCurrEduCls, 8, congs_PaperVer.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objgs_PaperVerEN.PaperTypeId, 2, congs_PaperVer.PaperTypeId);
clsCheckSql.CheckFieldLen(objgs_PaperVerEN.PaperStatusId, 2, congs_PaperVer.PaperStatusId);
clsCheckSql.CheckFieldLen(objgs_PaperVerEN.Memo, 1000, congs_PaperVer.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objgs_PaperVerEN.PaperId, congs_PaperVer.PaperId);
clsCheckSql.CheckSqlInjection4Field(objgs_PaperVerEN.PaperTitle, congs_PaperVer.PaperTitle);
clsCheckSql.CheckSqlInjection4Field(objgs_PaperVerEN.Periodical, congs_PaperVer.Periodical);
clsCheckSql.CheckSqlInjection4Field(objgs_PaperVerEN.Author, congs_PaperVer.Author);
clsCheckSql.CheckSqlInjection4Field(objgs_PaperVerEN.ResearchQuestion, congs_PaperVer.ResearchQuestion);
clsCheckSql.CheckSqlInjection4Field(objgs_PaperVerEN.Keyword, congs_PaperVer.Keyword);
clsCheckSql.CheckSqlInjection4Field(objgs_PaperVerEN.LiteratureSources, congs_PaperVer.LiteratureSources);
clsCheckSql.CheckSqlInjection4Field(objgs_PaperVerEN.LiteratureLink, congs_PaperVer.LiteratureLink);
clsCheckSql.CheckSqlInjection4Field(objgs_PaperVerEN.UploadfileUrl, congs_PaperVer.UploadfileUrl);
clsCheckSql.CheckSqlInjection4Field(objgs_PaperVerEN.QuoteId, congs_PaperVer.QuoteId);
clsCheckSql.CheckSqlInjection4Field(objgs_PaperVerEN.Checker, congs_PaperVer.Checker);
clsCheckSql.CheckSqlInjection4Field(objgs_PaperVerEN.LiteratureTypeId, congs_PaperVer.LiteratureTypeId);
clsCheckSql.CheckSqlInjection4Field(objgs_PaperVerEN.UpdUser, congs_PaperVer.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objgs_PaperVerEN.UpdDate, congs_PaperVer.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objgs_PaperVerEN.IdCurrEduCls, congs_PaperVer.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objgs_PaperVerEN.PaperTypeId, congs_PaperVer.PaperTypeId);
clsCheckSql.CheckSqlInjection4Field(objgs_PaperVerEN.PaperStatusId, congs_PaperVer.PaperStatusId);
clsCheckSql.CheckSqlInjection4Field(objgs_PaperVerEN.Memo, congs_PaperVer.Memo);
//检查外键字段长度
 objgs_PaperVerEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--gs_PaperVer(论文历史版本表),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objgs_PaperVerEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsgs_PaperVerEN objgs_PaperVerEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PaperVId = '{0}'", objgs_PaperVerEN.PaperVId);
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
 objSQL = clsgs_PaperVerDA.GetSpecSQLObj();
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
 objSQL = clsgs_PaperVerDA.GetSpecSQLObj();
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
 objSQL = clsgs_PaperVerDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsgs_PaperVerEN._CurrTabName);
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
 objSQL = clsgs_PaperVerDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsgs_PaperVerEN._CurrTabName, strCondition);
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
 objSQL = clsgs_PaperVerDA.GetSpecSQLObj();
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
 objSQL = clsgs_PaperVerDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}