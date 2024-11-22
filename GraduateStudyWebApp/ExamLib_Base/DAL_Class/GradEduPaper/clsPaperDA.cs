
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPaperDA
 表名:Paper(01120535)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:02:35
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
 /// 论文表(Paper)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsPaperDA : clsCommBase4DA
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
 return clsPaperEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsPaperEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsPaperEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsPaperEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsPaperEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:Paper中,检查关键字,长度不正确!(clsPaperDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strPaperId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:Paper中,关键字不能为空 或 null!(clsPaperDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strPaperId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsPaperDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsPaperDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperDA.GetSpecSQLObj();
strSQL = "Select * from Paper where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_Paper(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsPaperDA: GetDataTable_Paper)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperDA.GetSpecSQLObj();
strSQL = "Select * from Paper where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsPaperDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsPaperDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperDA.GetSpecSQLObj();
strSQL = "Select * from Paper where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsPaperDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsPaperDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from Paper where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from Paper where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsPaperDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from Paper where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsPaperDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} Paper.* from Paper Left Join {1} on {2} where {3} and Paper.PaperId not in (Select top {5} Paper.PaperId from Paper Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from Paper where {1} and PaperId not in (Select top {2} PaperId from Paper where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from Paper where {1} and PaperId not in (Select top {3} PaperId from Paper where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsPaperDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} Paper.* from Paper Left Join {1} on {2} where {3} and Paper.PaperId not in (Select top {5} Paper.PaperId from Paper Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from Paper where {1} and PaperId not in (Select top {2} PaperId from Paper where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from Paper where {1} and PaperId not in (Select top {3} PaperId from Paper where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsPaperEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsPaperDA:GetObjLst)", objException.Message));
}
List<clsPaperEN> arrObjLst = new List<clsPaperEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperDA.GetSpecSQLObj();
strSQL = "Select * from Paper where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperEN objPaperEN = new clsPaperEN();
try
{
objPaperEN.PaperId = objRow[conPaper.PaperId].ToString().Trim(); //论文Id
objPaperEN.PaperTitle = objRow[conPaper.PaperTitle].ToString().Trim(); //论文标题
objPaperEN.PaperContent = objRow[conPaper.PaperContent] == DBNull.Value ? null : objRow[conPaper.PaperContent].ToString().Trim(); //主题内容
objPaperEN.Periodical = objRow[conPaper.Periodical] == DBNull.Value ? null : objRow[conPaper.Periodical].ToString().Trim(); //期刊
objPaperEN.Author = objRow[conPaper.Author] == DBNull.Value ? null : objRow[conPaper.Author].ToString().Trim(); //作者
objPaperEN.ResearchQuestion = objRow[conPaper.ResearchQuestion] == DBNull.Value ? null : objRow[conPaper.ResearchQuestion].ToString().Trim(); //研究问题
objPaperEN.Keyword = objRow[conPaper.Keyword] == DBNull.Value ? null : objRow[conPaper.Keyword].ToString().Trim(); //关键字
objPaperEN.LiteratureSources = objRow[conPaper.LiteratureSources] == DBNull.Value ? null : objRow[conPaper.LiteratureSources].ToString().Trim(); //文献来源
objPaperEN.LiteratureLink = objRow[conPaper.LiteratureLink] == DBNull.Value ? null : objRow[conPaper.LiteratureLink].ToString().Trim(); //文献链接
objPaperEN.UploadfileUrl = objRow[conPaper.UploadfileUrl] == DBNull.Value ? null : objRow[conPaper.UploadfileUrl].ToString().Trim(); //文件地址
objPaperEN.IsQuotethesis = TransNullToBool(objRow[conPaper.IsQuotethesis].ToString().Trim()); //是否引用论文
objPaperEN.QuoteId = objRow[conPaper.QuoteId] == DBNull.Value ? null : objRow[conPaper.QuoteId].ToString().Trim(); //引用Id
objPaperEN.IsChecked = TransNullToBool(objRow[conPaper.IsChecked].ToString().Trim()); //是否检查
objPaperEN.Checker = objRow[conPaper.Checker] == DBNull.Value ? null : objRow[conPaper.Checker].ToString().Trim(); //审核人
objPaperEN.LiteratureTypeId = objRow[conPaper.LiteratureTypeId].ToString().Trim(); //文献类型Id
objPaperEN.BrowseNumber = objRow[conPaper.BrowseNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaper.BrowseNumber].ToString().Trim()); //浏览量
objPaperEN.IsSubmit = TransNullToBool(objRow[conPaper.IsSubmit].ToString().Trim()); //是否提交
objPaperEN.AppraiseCount = objRow[conPaper.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaper.AppraiseCount].ToString().Trim()); //评论数
objPaperEN.AttachmentCount = objRow[conPaper.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaper.AttachmentCount].ToString().Trim()); //附件计数
objPaperEN.CollectionCount = objRow[conPaper.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conPaper.CollectionCount].ToString().Trim()); //收藏数量
objPaperEN.DownloadCount = objRow[conPaper.DownloadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaper.DownloadCount].ToString().Trim()); //下载数
objPaperEN.OkCount = objRow[conPaper.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaper.OkCount].ToString().Trim()); //点赞统计
objPaperEN.Pcount = objRow[conPaper.Pcount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaper.Pcount].ToString().Trim()); //读写数
objPaperEN.Score = objRow[conPaper.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conPaper.Score].ToString().Trim()); //评分
objPaperEN.StuScore = objRow[conPaper.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conPaper.StuScore].ToString().Trim()); //学生平均分
objPaperEN.TeaScore = objRow[conPaper.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conPaper.TeaScore].ToString().Trim()); //教师评分
objPaperEN.PaperTypeId = objRow[conPaper.PaperTypeId] == DBNull.Value ? null : objRow[conPaper.PaperTypeId].ToString().Trim(); //论文类型Id
objPaperEN.PaperStatusId = objRow[conPaper.PaperStatusId] == DBNull.Value ? null : objRow[conPaper.PaperStatusId].ToString().Trim(); //论文状态Id
objPaperEN.VersionCount = objRow[conPaper.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaper.VersionCount].ToString().Trim()); //版本统计
objPaperEN.IsPublic = TransNullToBool(objRow[conPaper.IsPublic].ToString().Trim()); //是否公开
objPaperEN.AskQuestion = objRow[conPaper.AskQuestion] == DBNull.Value ? null : objRow[conPaper.AskQuestion].ToString().Trim(); //问题提出
objPaperEN.ResearchStatus = objRow[conPaper.ResearchStatus] == DBNull.Value ? null : objRow[conPaper.ResearchStatus].ToString().Trim(); //目前研究的现状
objPaperEN.InnovationPoints = objRow[conPaper.InnovationPoints] == DBNull.Value ? null : objRow[conPaper.InnovationPoints].ToString().Trim(); //创新点
objPaperEN.ResearchDesign = objRow[conPaper.ResearchDesign] == DBNull.Value ? null : objRow[conPaper.ResearchDesign].ToString().Trim(); //研究设计
objPaperEN.DimensionDataProcess = objRow[conPaper.DimensionDataProcess] == DBNull.Value ? null : objRow[conPaper.DimensionDataProcess].ToString().Trim(); //数据处理的维度
objPaperEN.ExpectedConclusion = objRow[conPaper.ExpectedConclusion] == DBNull.Value ? null : objRow[conPaper.ExpectedConclusion].ToString().Trim(); //预期结论
objPaperEN.ShareId = objRow[conPaper.ShareId] == DBNull.Value ? null : objRow[conPaper.ShareId].ToString().Trim(); //分享Id
objPaperEN.PaperQCount = objRow[conPaper.PaperQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaper.PaperQCount].ToString().Trim()); //论文答疑数
objPaperEN.SubVCount = objRow[conPaper.SubVCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaper.SubVCount].ToString().Trim()); //论文子观点数
objPaperEN.TagsCount = objRow[conPaper.TagsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaper.TagsCount].ToString().Trim()); //论文标注数
objPaperEN.TeaQCount = objRow[conPaper.TeaQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaper.TeaQCount].ToString().Trim()); //教师提问数
objPaperEN.IdStudyLevel = objRow[conPaper.IdStudyLevel] == DBNull.Value ? null : objRow[conPaper.IdStudyLevel].ToString().Trim(); //学段流水号
objPaperEN.IdGrade = objRow[conPaper.IdGrade] == DBNull.Value ? null : objRow[conPaper.IdGrade].ToString().Trim(); //年级流水号
objPaperEN.CreateDate = objRow[conPaper.CreateDate] == DBNull.Value ? null : objRow[conPaper.CreateDate].ToString().Trim(); //建立日期
objPaperEN.UpdUser = objRow[conPaper.UpdUser] == DBNull.Value ? null : objRow[conPaper.UpdUser].ToString().Trim(); //修改人
objPaperEN.UpdDate = objRow[conPaper.UpdDate] == DBNull.Value ? null : objRow[conPaper.UpdDate].ToString().Trim(); //修改日期
objPaperEN.Memo = objRow[conPaper.Memo] == DBNull.Value ? null : objRow[conPaper.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsPaperDA: GetObjLst)", objException.Message));
}
objPaperEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objPaperEN);
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
public List<clsPaperEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsPaperDA:GetObjLstByTabName)", objException.Message));
}
List<clsPaperEN> arrObjLst = new List<clsPaperEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperEN objPaperEN = new clsPaperEN();
try
{
objPaperEN.PaperId = objRow[conPaper.PaperId].ToString().Trim(); //论文Id
objPaperEN.PaperTitle = objRow[conPaper.PaperTitle].ToString().Trim(); //论文标题
objPaperEN.PaperContent = objRow[conPaper.PaperContent] == DBNull.Value ? null : objRow[conPaper.PaperContent].ToString().Trim(); //主题内容
objPaperEN.Periodical = objRow[conPaper.Periodical] == DBNull.Value ? null : objRow[conPaper.Periodical].ToString().Trim(); //期刊
objPaperEN.Author = objRow[conPaper.Author] == DBNull.Value ? null : objRow[conPaper.Author].ToString().Trim(); //作者
objPaperEN.ResearchQuestion = objRow[conPaper.ResearchQuestion] == DBNull.Value ? null : objRow[conPaper.ResearchQuestion].ToString().Trim(); //研究问题
objPaperEN.Keyword = objRow[conPaper.Keyword] == DBNull.Value ? null : objRow[conPaper.Keyword].ToString().Trim(); //关键字
objPaperEN.LiteratureSources = objRow[conPaper.LiteratureSources] == DBNull.Value ? null : objRow[conPaper.LiteratureSources].ToString().Trim(); //文献来源
objPaperEN.LiteratureLink = objRow[conPaper.LiteratureLink] == DBNull.Value ? null : objRow[conPaper.LiteratureLink].ToString().Trim(); //文献链接
objPaperEN.UploadfileUrl = objRow[conPaper.UploadfileUrl] == DBNull.Value ? null : objRow[conPaper.UploadfileUrl].ToString().Trim(); //文件地址
objPaperEN.IsQuotethesis = TransNullToBool(objRow[conPaper.IsQuotethesis].ToString().Trim()); //是否引用论文
objPaperEN.QuoteId = objRow[conPaper.QuoteId] == DBNull.Value ? null : objRow[conPaper.QuoteId].ToString().Trim(); //引用Id
objPaperEN.IsChecked = TransNullToBool(objRow[conPaper.IsChecked].ToString().Trim()); //是否检查
objPaperEN.Checker = objRow[conPaper.Checker] == DBNull.Value ? null : objRow[conPaper.Checker].ToString().Trim(); //审核人
objPaperEN.LiteratureTypeId = objRow[conPaper.LiteratureTypeId].ToString().Trim(); //文献类型Id
objPaperEN.BrowseNumber = objRow[conPaper.BrowseNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaper.BrowseNumber].ToString().Trim()); //浏览量
objPaperEN.IsSubmit = TransNullToBool(objRow[conPaper.IsSubmit].ToString().Trim()); //是否提交
objPaperEN.AppraiseCount = objRow[conPaper.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaper.AppraiseCount].ToString().Trim()); //评论数
objPaperEN.AttachmentCount = objRow[conPaper.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaper.AttachmentCount].ToString().Trim()); //附件计数
objPaperEN.CollectionCount = objRow[conPaper.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conPaper.CollectionCount].ToString().Trim()); //收藏数量
objPaperEN.DownloadCount = objRow[conPaper.DownloadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaper.DownloadCount].ToString().Trim()); //下载数
objPaperEN.OkCount = objRow[conPaper.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaper.OkCount].ToString().Trim()); //点赞统计
objPaperEN.Pcount = objRow[conPaper.Pcount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaper.Pcount].ToString().Trim()); //读写数
objPaperEN.Score = objRow[conPaper.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conPaper.Score].ToString().Trim()); //评分
objPaperEN.StuScore = objRow[conPaper.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conPaper.StuScore].ToString().Trim()); //学生平均分
objPaperEN.TeaScore = objRow[conPaper.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conPaper.TeaScore].ToString().Trim()); //教师评分
objPaperEN.PaperTypeId = objRow[conPaper.PaperTypeId] == DBNull.Value ? null : objRow[conPaper.PaperTypeId].ToString().Trim(); //论文类型Id
objPaperEN.PaperStatusId = objRow[conPaper.PaperStatusId] == DBNull.Value ? null : objRow[conPaper.PaperStatusId].ToString().Trim(); //论文状态Id
objPaperEN.VersionCount = objRow[conPaper.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaper.VersionCount].ToString().Trim()); //版本统计
objPaperEN.IsPublic = TransNullToBool(objRow[conPaper.IsPublic].ToString().Trim()); //是否公开
objPaperEN.AskQuestion = objRow[conPaper.AskQuestion] == DBNull.Value ? null : objRow[conPaper.AskQuestion].ToString().Trim(); //问题提出
objPaperEN.ResearchStatus = objRow[conPaper.ResearchStatus] == DBNull.Value ? null : objRow[conPaper.ResearchStatus].ToString().Trim(); //目前研究的现状
objPaperEN.InnovationPoints = objRow[conPaper.InnovationPoints] == DBNull.Value ? null : objRow[conPaper.InnovationPoints].ToString().Trim(); //创新点
objPaperEN.ResearchDesign = objRow[conPaper.ResearchDesign] == DBNull.Value ? null : objRow[conPaper.ResearchDesign].ToString().Trim(); //研究设计
objPaperEN.DimensionDataProcess = objRow[conPaper.DimensionDataProcess] == DBNull.Value ? null : objRow[conPaper.DimensionDataProcess].ToString().Trim(); //数据处理的维度
objPaperEN.ExpectedConclusion = objRow[conPaper.ExpectedConclusion] == DBNull.Value ? null : objRow[conPaper.ExpectedConclusion].ToString().Trim(); //预期结论
objPaperEN.ShareId = objRow[conPaper.ShareId] == DBNull.Value ? null : objRow[conPaper.ShareId].ToString().Trim(); //分享Id
objPaperEN.PaperQCount = objRow[conPaper.PaperQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaper.PaperQCount].ToString().Trim()); //论文答疑数
objPaperEN.SubVCount = objRow[conPaper.SubVCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaper.SubVCount].ToString().Trim()); //论文子观点数
objPaperEN.TagsCount = objRow[conPaper.TagsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaper.TagsCount].ToString().Trim()); //论文标注数
objPaperEN.TeaQCount = objRow[conPaper.TeaQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaper.TeaQCount].ToString().Trim()); //教师提问数
objPaperEN.IdStudyLevel = objRow[conPaper.IdStudyLevel] == DBNull.Value ? null : objRow[conPaper.IdStudyLevel].ToString().Trim(); //学段流水号
objPaperEN.IdGrade = objRow[conPaper.IdGrade] == DBNull.Value ? null : objRow[conPaper.IdGrade].ToString().Trim(); //年级流水号
objPaperEN.CreateDate = objRow[conPaper.CreateDate] == DBNull.Value ? null : objRow[conPaper.CreateDate].ToString().Trim(); //建立日期
objPaperEN.UpdUser = objRow[conPaper.UpdUser] == DBNull.Value ? null : objRow[conPaper.UpdUser].ToString().Trim(); //修改人
objPaperEN.UpdDate = objRow[conPaper.UpdDate] == DBNull.Value ? null : objRow[conPaper.UpdDate].ToString().Trim(); //修改日期
objPaperEN.Memo = objRow[conPaper.Memo] == DBNull.Value ? null : objRow[conPaper.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsPaperDA: GetObjLst)", objException.Message));
}
objPaperEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objPaperEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objPaperEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetPaper(ref clsPaperEN objPaperEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperDA.GetSpecSQLObj();
strSQL = "Select * from Paper where PaperId = " + "'"+ objPaperEN.PaperId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objPaperEN.PaperId = objDT.Rows[0][conPaper.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objPaperEN.PaperTitle = objDT.Rows[0][conPaper.PaperTitle].ToString().Trim(); //论文标题(字段类型:varchar,字段长度:500,是否可空:False)
 objPaperEN.PaperContent = objDT.Rows[0][conPaper.PaperContent].ToString().Trim(); //主题内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objPaperEN.Periodical = objDT.Rows[0][conPaper.Periodical].ToString().Trim(); //期刊(字段类型:varchar,字段长度:100,是否可空:True)
 objPaperEN.Author = objDT.Rows[0][conPaper.Author].ToString().Trim(); //作者(字段类型:varchar,字段长度:200,是否可空:True)
 objPaperEN.ResearchQuestion = objDT.Rows[0][conPaper.ResearchQuestion].ToString().Trim(); //研究问题(字段类型:varchar,字段长度:2000,是否可空:True)
 objPaperEN.Keyword = objDT.Rows[0][conPaper.Keyword].ToString().Trim(); //关键字(字段类型:varchar,字段长度:1000,是否可空:True)
 objPaperEN.LiteratureSources = objDT.Rows[0][conPaper.LiteratureSources].ToString().Trim(); //文献来源(字段类型:varchar,字段长度:1000,是否可空:True)
 objPaperEN.LiteratureLink = objDT.Rows[0][conPaper.LiteratureLink].ToString().Trim(); //文献链接(字段类型:varchar,字段长度:1000,是否可空:True)
 objPaperEN.UploadfileUrl = objDT.Rows[0][conPaper.UploadfileUrl].ToString().Trim(); //文件地址(字段类型:varchar,字段长度:1000,是否可空:True)
 objPaperEN.IsQuotethesis = TransNullToBool(objDT.Rows[0][conPaper.IsQuotethesis].ToString().Trim()); //是否引用论文(字段类型:bit,字段长度:1,是否可空:True)
 objPaperEN.QuoteId = objDT.Rows[0][conPaper.QuoteId].ToString().Trim(); //引用Id(字段类型:char,字段长度:8,是否可空:True)
 objPaperEN.IsChecked = TransNullToBool(objDT.Rows[0][conPaper.IsChecked].ToString().Trim()); //是否检查(字段类型:bit,字段长度:1,是否可空:True)
 objPaperEN.Checker = objDT.Rows[0][conPaper.Checker].ToString().Trim(); //审核人(字段类型:varchar,字段长度:20,是否可空:True)
 objPaperEN.LiteratureTypeId = objDT.Rows[0][conPaper.LiteratureTypeId].ToString().Trim(); //文献类型Id(字段类型:char,字段长度:2,是否可空:False)
 objPaperEN.BrowseNumber = TransNullToInt(objDT.Rows[0][conPaper.BrowseNumber].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objPaperEN.IsSubmit = TransNullToBool(objDT.Rows[0][conPaper.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objPaperEN.AppraiseCount = TransNullToInt(objDT.Rows[0][conPaper.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objPaperEN.AttachmentCount = TransNullToInt(objDT.Rows[0][conPaper.AttachmentCount].ToString().Trim()); //附件计数(字段类型:int,字段长度:4,是否可空:True)
 objPaperEN.CollectionCount = TransNullToInt(objDT.Rows[0][conPaper.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objPaperEN.DownloadCount = TransNullToInt(objDT.Rows[0][conPaper.DownloadCount].ToString().Trim()); //下载数(字段类型:int,字段长度:4,是否可空:True)
 objPaperEN.OkCount = TransNullToInt(objDT.Rows[0][conPaper.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objPaperEN.Pcount = TransNullToInt(objDT.Rows[0][conPaper.Pcount].ToString().Trim()); //读写数(字段类型:int,字段长度:4,是否可空:True)
 objPaperEN.Score = TransNullToFloat(objDT.Rows[0][conPaper.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objPaperEN.StuScore = TransNullToFloat(objDT.Rows[0][conPaper.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objPaperEN.TeaScore = TransNullToFloat(objDT.Rows[0][conPaper.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objPaperEN.PaperTypeId = objDT.Rows[0][conPaper.PaperTypeId].ToString().Trim(); //论文类型Id(字段类型:char,字段长度:2,是否可空:True)
 objPaperEN.PaperStatusId = objDT.Rows[0][conPaper.PaperStatusId].ToString().Trim(); //论文状态Id(字段类型:char,字段长度:2,是否可空:False)
 objPaperEN.VersionCount = TransNullToInt(objDT.Rows[0][conPaper.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objPaperEN.IsPublic = TransNullToBool(objDT.Rows[0][conPaper.IsPublic].ToString().Trim()); //是否公开(字段类型:bit,字段长度:1,是否可空:True)
 objPaperEN.AskQuestion = objDT.Rows[0][conPaper.AskQuestion].ToString().Trim(); //问题提出(字段类型:varchar,字段长度:5000,是否可空:True)
 objPaperEN.ResearchStatus = objDT.Rows[0][conPaper.ResearchStatus].ToString().Trim(); //目前研究的现状(字段类型:varchar,字段长度:5000,是否可空:True)
 objPaperEN.InnovationPoints = objDT.Rows[0][conPaper.InnovationPoints].ToString().Trim(); //创新点(字段类型:varchar,字段长度:5000,是否可空:True)
 objPaperEN.ResearchDesign = objDT.Rows[0][conPaper.ResearchDesign].ToString().Trim(); //研究设计(字段类型:varchar,字段长度:5000,是否可空:True)
 objPaperEN.DimensionDataProcess = objDT.Rows[0][conPaper.DimensionDataProcess].ToString().Trim(); //数据处理的维度(字段类型:varchar,字段长度:5000,是否可空:True)
 objPaperEN.ExpectedConclusion = objDT.Rows[0][conPaper.ExpectedConclusion].ToString().Trim(); //预期结论(字段类型:varchar,字段长度:5000,是否可空:True)
 objPaperEN.ShareId = objDT.Rows[0][conPaper.ShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objPaperEN.PaperQCount = TransNullToInt(objDT.Rows[0][conPaper.PaperQCount].ToString().Trim()); //论文答疑数(字段类型:int,字段长度:4,是否可空:True)
 objPaperEN.SubVCount = TransNullToInt(objDT.Rows[0][conPaper.SubVCount].ToString().Trim()); //论文子观点数(字段类型:int,字段长度:4,是否可空:True)
 objPaperEN.TagsCount = TransNullToInt(objDT.Rows[0][conPaper.TagsCount].ToString().Trim()); //论文标注数(字段类型:int,字段长度:4,是否可空:True)
 objPaperEN.TeaQCount = TransNullToInt(objDT.Rows[0][conPaper.TeaQCount].ToString().Trim()); //教师提问数(字段类型:int,字段长度:4,是否可空:True)
 objPaperEN.IdStudyLevel = objDT.Rows[0][conPaper.IdStudyLevel].ToString().Trim(); //学段流水号(字段类型:char,字段长度:4,是否可空:True)
 objPaperEN.IdGrade = objDT.Rows[0][conPaper.IdGrade].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:False)
 objPaperEN.CreateDate = objDT.Rows[0][conPaper.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objPaperEN.UpdUser = objDT.Rows[0][conPaper.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objPaperEN.UpdDate = objDT.Rows[0][conPaper.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objPaperEN.Memo = objDT.Rows[0][conPaper.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsPaperDA: GetPaper)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strPaperId">表关键字</param>
 /// <returns>表对象</returns>
public clsPaperEN GetObjByPaperId(string strPaperId)
{
CheckPrimaryKey(strPaperId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperDA.GetSpecSQLObj();
strSQL = "Select * from Paper where PaperId = " + "'"+ strPaperId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsPaperEN objPaperEN = new clsPaperEN();
try
{
 objPaperEN.PaperId = objRow[conPaper.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objPaperEN.PaperTitle = objRow[conPaper.PaperTitle].ToString().Trim(); //论文标题(字段类型:varchar,字段长度:500,是否可空:False)
 objPaperEN.PaperContent = objRow[conPaper.PaperContent] == DBNull.Value ? null : objRow[conPaper.PaperContent].ToString().Trim(); //主题内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objPaperEN.Periodical = objRow[conPaper.Periodical] == DBNull.Value ? null : objRow[conPaper.Periodical].ToString().Trim(); //期刊(字段类型:varchar,字段长度:100,是否可空:True)
 objPaperEN.Author = objRow[conPaper.Author] == DBNull.Value ? null : objRow[conPaper.Author].ToString().Trim(); //作者(字段类型:varchar,字段长度:200,是否可空:True)
 objPaperEN.ResearchQuestion = objRow[conPaper.ResearchQuestion] == DBNull.Value ? null : objRow[conPaper.ResearchQuestion].ToString().Trim(); //研究问题(字段类型:varchar,字段长度:2000,是否可空:True)
 objPaperEN.Keyword = objRow[conPaper.Keyword] == DBNull.Value ? null : objRow[conPaper.Keyword].ToString().Trim(); //关键字(字段类型:varchar,字段长度:1000,是否可空:True)
 objPaperEN.LiteratureSources = objRow[conPaper.LiteratureSources] == DBNull.Value ? null : objRow[conPaper.LiteratureSources].ToString().Trim(); //文献来源(字段类型:varchar,字段长度:1000,是否可空:True)
 objPaperEN.LiteratureLink = objRow[conPaper.LiteratureLink] == DBNull.Value ? null : objRow[conPaper.LiteratureLink].ToString().Trim(); //文献链接(字段类型:varchar,字段长度:1000,是否可空:True)
 objPaperEN.UploadfileUrl = objRow[conPaper.UploadfileUrl] == DBNull.Value ? null : objRow[conPaper.UploadfileUrl].ToString().Trim(); //文件地址(字段类型:varchar,字段长度:1000,是否可空:True)
 objPaperEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[conPaper.IsQuotethesis].ToString().Trim()); //是否引用论文(字段类型:bit,字段长度:1,是否可空:True)
 objPaperEN.QuoteId = objRow[conPaper.QuoteId] == DBNull.Value ? null : objRow[conPaper.QuoteId].ToString().Trim(); //引用Id(字段类型:char,字段长度:8,是否可空:True)
 objPaperEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[conPaper.IsChecked].ToString().Trim()); //是否检查(字段类型:bit,字段长度:1,是否可空:True)
 objPaperEN.Checker = objRow[conPaper.Checker] == DBNull.Value ? null : objRow[conPaper.Checker].ToString().Trim(); //审核人(字段类型:varchar,字段长度:20,是否可空:True)
 objPaperEN.LiteratureTypeId = objRow[conPaper.LiteratureTypeId].ToString().Trim(); //文献类型Id(字段类型:char,字段长度:2,是否可空:False)
 objPaperEN.BrowseNumber = objRow[conPaper.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.BrowseNumber].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objPaperEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conPaper.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objPaperEN.AppraiseCount = objRow[conPaper.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objPaperEN.AttachmentCount = objRow[conPaper.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.AttachmentCount].ToString().Trim()); //附件计数(字段类型:int,字段长度:4,是否可空:True)
 objPaperEN.CollectionCount = objRow[conPaper.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objPaperEN.DownloadCount = objRow[conPaper.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.DownloadCount].ToString().Trim()); //下载数(字段类型:int,字段长度:4,是否可空:True)
 objPaperEN.OkCount = objRow[conPaper.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objPaperEN.Pcount = objRow[conPaper.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.Pcount].ToString().Trim()); //读写数(字段类型:int,字段长度:4,是否可空:True)
 objPaperEN.Score = objRow[conPaper.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaper.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objPaperEN.StuScore = objRow[conPaper.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaper.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objPaperEN.TeaScore = objRow[conPaper.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaper.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objPaperEN.PaperTypeId = objRow[conPaper.PaperTypeId] == DBNull.Value ? null : objRow[conPaper.PaperTypeId].ToString().Trim(); //论文类型Id(字段类型:char,字段长度:2,是否可空:True)
 objPaperEN.PaperStatusId = objRow[conPaper.PaperStatusId] == DBNull.Value ? null : objRow[conPaper.PaperStatusId].ToString().Trim(); //论文状态Id(字段类型:char,字段长度:2,是否可空:False)
 objPaperEN.VersionCount = objRow[conPaper.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objPaperEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conPaper.IsPublic].ToString().Trim()); //是否公开(字段类型:bit,字段长度:1,是否可空:True)
 objPaperEN.AskQuestion = objRow[conPaper.AskQuestion] == DBNull.Value ? null : objRow[conPaper.AskQuestion].ToString().Trim(); //问题提出(字段类型:varchar,字段长度:5000,是否可空:True)
 objPaperEN.ResearchStatus = objRow[conPaper.ResearchStatus] == DBNull.Value ? null : objRow[conPaper.ResearchStatus].ToString().Trim(); //目前研究的现状(字段类型:varchar,字段长度:5000,是否可空:True)
 objPaperEN.InnovationPoints = objRow[conPaper.InnovationPoints] == DBNull.Value ? null : objRow[conPaper.InnovationPoints].ToString().Trim(); //创新点(字段类型:varchar,字段长度:5000,是否可空:True)
 objPaperEN.ResearchDesign = objRow[conPaper.ResearchDesign] == DBNull.Value ? null : objRow[conPaper.ResearchDesign].ToString().Trim(); //研究设计(字段类型:varchar,字段长度:5000,是否可空:True)
 objPaperEN.DimensionDataProcess = objRow[conPaper.DimensionDataProcess] == DBNull.Value ? null : objRow[conPaper.DimensionDataProcess].ToString().Trim(); //数据处理的维度(字段类型:varchar,字段长度:5000,是否可空:True)
 objPaperEN.ExpectedConclusion = objRow[conPaper.ExpectedConclusion] == DBNull.Value ? null : objRow[conPaper.ExpectedConclusion].ToString().Trim(); //预期结论(字段类型:varchar,字段长度:5000,是否可空:True)
 objPaperEN.ShareId = objRow[conPaper.ShareId] == DBNull.Value ? null : objRow[conPaper.ShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objPaperEN.PaperQCount = objRow[conPaper.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.PaperQCount].ToString().Trim()); //论文答疑数(字段类型:int,字段长度:4,是否可空:True)
 objPaperEN.SubVCount = objRow[conPaper.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.SubVCount].ToString().Trim()); //论文子观点数(字段类型:int,字段长度:4,是否可空:True)
 objPaperEN.TagsCount = objRow[conPaper.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.TagsCount].ToString().Trim()); //论文标注数(字段类型:int,字段长度:4,是否可空:True)
 objPaperEN.TeaQCount = objRow[conPaper.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.TeaQCount].ToString().Trim()); //教师提问数(字段类型:int,字段长度:4,是否可空:True)
 objPaperEN.IdStudyLevel = objRow[conPaper.IdStudyLevel] == DBNull.Value ? null : objRow[conPaper.IdStudyLevel].ToString().Trim(); //学段流水号(字段类型:char,字段长度:4,是否可空:True)
 objPaperEN.IdGrade = objRow[conPaper.IdGrade] == DBNull.Value ? null : objRow[conPaper.IdGrade].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:False)
 objPaperEN.CreateDate = objRow[conPaper.CreateDate] == DBNull.Value ? null : objRow[conPaper.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objPaperEN.UpdUser = objRow[conPaper.UpdUser] == DBNull.Value ? null : objRow[conPaper.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objPaperEN.UpdDate = objRow[conPaper.UpdDate] == DBNull.Value ? null : objRow[conPaper.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objPaperEN.Memo = objRow[conPaper.Memo] == DBNull.Value ? null : objRow[conPaper.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsPaperDA: GetObjByPaperId)", objException.Message));
}
return objPaperEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsPaperEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsPaperDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperDA.GetSpecSQLObj();
strSQL = "Select * from Paper where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsPaperEN objPaperEN = new clsPaperEN()
{
PaperId = objRow[conPaper.PaperId].ToString().Trim(), //论文Id
PaperTitle = objRow[conPaper.PaperTitle].ToString().Trim(), //论文标题
PaperContent = objRow[conPaper.PaperContent] == DBNull.Value ? null : objRow[conPaper.PaperContent].ToString().Trim(), //主题内容
Periodical = objRow[conPaper.Periodical] == DBNull.Value ? null : objRow[conPaper.Periodical].ToString().Trim(), //期刊
Author = objRow[conPaper.Author] == DBNull.Value ? null : objRow[conPaper.Author].ToString().Trim(), //作者
ResearchQuestion = objRow[conPaper.ResearchQuestion] == DBNull.Value ? null : objRow[conPaper.ResearchQuestion].ToString().Trim(), //研究问题
Keyword = objRow[conPaper.Keyword] == DBNull.Value ? null : objRow[conPaper.Keyword].ToString().Trim(), //关键字
LiteratureSources = objRow[conPaper.LiteratureSources] == DBNull.Value ? null : objRow[conPaper.LiteratureSources].ToString().Trim(), //文献来源
LiteratureLink = objRow[conPaper.LiteratureLink] == DBNull.Value ? null : objRow[conPaper.LiteratureLink].ToString().Trim(), //文献链接
UploadfileUrl = objRow[conPaper.UploadfileUrl] == DBNull.Value ? null : objRow[conPaper.UploadfileUrl].ToString().Trim(), //文件地址
IsQuotethesis = TransNullToBool(objRow[conPaper.IsQuotethesis].ToString().Trim()), //是否引用论文
QuoteId = objRow[conPaper.QuoteId] == DBNull.Value ? null : objRow[conPaper.QuoteId].ToString().Trim(), //引用Id
IsChecked = TransNullToBool(objRow[conPaper.IsChecked].ToString().Trim()), //是否检查
Checker = objRow[conPaper.Checker] == DBNull.Value ? null : objRow[conPaper.Checker].ToString().Trim(), //审核人
LiteratureTypeId = objRow[conPaper.LiteratureTypeId].ToString().Trim(), //文献类型Id
BrowseNumber = objRow[conPaper.BrowseNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaper.BrowseNumber].ToString().Trim()), //浏览量
IsSubmit = TransNullToBool(objRow[conPaper.IsSubmit].ToString().Trim()), //是否提交
AppraiseCount = objRow[conPaper.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaper.AppraiseCount].ToString().Trim()), //评论数
AttachmentCount = objRow[conPaper.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaper.AttachmentCount].ToString().Trim()), //附件计数
CollectionCount = objRow[conPaper.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conPaper.CollectionCount].ToString().Trim()), //收藏数量
DownloadCount = objRow[conPaper.DownloadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaper.DownloadCount].ToString().Trim()), //下载数
OkCount = objRow[conPaper.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaper.OkCount].ToString().Trim()), //点赞统计
Pcount = objRow[conPaper.Pcount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaper.Pcount].ToString().Trim()), //读写数
Score = objRow[conPaper.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conPaper.Score].ToString().Trim()), //评分
StuScore = objRow[conPaper.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conPaper.StuScore].ToString().Trim()), //学生平均分
TeaScore = objRow[conPaper.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conPaper.TeaScore].ToString().Trim()), //教师评分
PaperTypeId = objRow[conPaper.PaperTypeId] == DBNull.Value ? null : objRow[conPaper.PaperTypeId].ToString().Trim(), //论文类型Id
PaperStatusId = objRow[conPaper.PaperStatusId] == DBNull.Value ? null : objRow[conPaper.PaperStatusId].ToString().Trim(), //论文状态Id
VersionCount = objRow[conPaper.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaper.VersionCount].ToString().Trim()), //版本统计
IsPublic = TransNullToBool(objRow[conPaper.IsPublic].ToString().Trim()), //是否公开
AskQuestion = objRow[conPaper.AskQuestion] == DBNull.Value ? null : objRow[conPaper.AskQuestion].ToString().Trim(), //问题提出
ResearchStatus = objRow[conPaper.ResearchStatus] == DBNull.Value ? null : objRow[conPaper.ResearchStatus].ToString().Trim(), //目前研究的现状
InnovationPoints = objRow[conPaper.InnovationPoints] == DBNull.Value ? null : objRow[conPaper.InnovationPoints].ToString().Trim(), //创新点
ResearchDesign = objRow[conPaper.ResearchDesign] == DBNull.Value ? null : objRow[conPaper.ResearchDesign].ToString().Trim(), //研究设计
DimensionDataProcess = objRow[conPaper.DimensionDataProcess] == DBNull.Value ? null : objRow[conPaper.DimensionDataProcess].ToString().Trim(), //数据处理的维度
ExpectedConclusion = objRow[conPaper.ExpectedConclusion] == DBNull.Value ? null : objRow[conPaper.ExpectedConclusion].ToString().Trim(), //预期结论
ShareId = objRow[conPaper.ShareId] == DBNull.Value ? null : objRow[conPaper.ShareId].ToString().Trim(), //分享Id
PaperQCount = objRow[conPaper.PaperQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaper.PaperQCount].ToString().Trim()), //论文答疑数
SubVCount = objRow[conPaper.SubVCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaper.SubVCount].ToString().Trim()), //论文子观点数
TagsCount = objRow[conPaper.TagsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaper.TagsCount].ToString().Trim()), //论文标注数
TeaQCount = objRow[conPaper.TeaQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaper.TeaQCount].ToString().Trim()), //教师提问数
IdStudyLevel = objRow[conPaper.IdStudyLevel] == DBNull.Value ? null : objRow[conPaper.IdStudyLevel].ToString().Trim(), //学段流水号
IdGrade = objRow[conPaper.IdGrade] == DBNull.Value ? null : objRow[conPaper.IdGrade].ToString().Trim(), //年级流水号
CreateDate = objRow[conPaper.CreateDate] == DBNull.Value ? null : objRow[conPaper.CreateDate].ToString().Trim(), //建立日期
UpdUser = objRow[conPaper.UpdUser] == DBNull.Value ? null : objRow[conPaper.UpdUser].ToString().Trim(), //修改人
UpdDate = objRow[conPaper.UpdDate] == DBNull.Value ? null : objRow[conPaper.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[conPaper.Memo] == DBNull.Value ? null : objRow[conPaper.Memo].ToString().Trim() //备注
};
objPaperEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objPaperEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsPaperDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsPaperEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsPaperEN objPaperEN = new clsPaperEN();
try
{
objPaperEN.PaperId = objRow[conPaper.PaperId].ToString().Trim(); //论文Id
objPaperEN.PaperTitle = objRow[conPaper.PaperTitle].ToString().Trim(); //论文标题
objPaperEN.PaperContent = objRow[conPaper.PaperContent] == DBNull.Value ? null : objRow[conPaper.PaperContent].ToString().Trim(); //主题内容
objPaperEN.Periodical = objRow[conPaper.Periodical] == DBNull.Value ? null : objRow[conPaper.Periodical].ToString().Trim(); //期刊
objPaperEN.Author = objRow[conPaper.Author] == DBNull.Value ? null : objRow[conPaper.Author].ToString().Trim(); //作者
objPaperEN.ResearchQuestion = objRow[conPaper.ResearchQuestion] == DBNull.Value ? null : objRow[conPaper.ResearchQuestion].ToString().Trim(); //研究问题
objPaperEN.Keyword = objRow[conPaper.Keyword] == DBNull.Value ? null : objRow[conPaper.Keyword].ToString().Trim(); //关键字
objPaperEN.LiteratureSources = objRow[conPaper.LiteratureSources] == DBNull.Value ? null : objRow[conPaper.LiteratureSources].ToString().Trim(); //文献来源
objPaperEN.LiteratureLink = objRow[conPaper.LiteratureLink] == DBNull.Value ? null : objRow[conPaper.LiteratureLink].ToString().Trim(); //文献链接
objPaperEN.UploadfileUrl = objRow[conPaper.UploadfileUrl] == DBNull.Value ? null : objRow[conPaper.UploadfileUrl].ToString().Trim(); //文件地址
objPaperEN.IsQuotethesis = TransNullToBool(objRow[conPaper.IsQuotethesis].ToString().Trim()); //是否引用论文
objPaperEN.QuoteId = objRow[conPaper.QuoteId] == DBNull.Value ? null : objRow[conPaper.QuoteId].ToString().Trim(); //引用Id
objPaperEN.IsChecked = TransNullToBool(objRow[conPaper.IsChecked].ToString().Trim()); //是否检查
objPaperEN.Checker = objRow[conPaper.Checker] == DBNull.Value ? null : objRow[conPaper.Checker].ToString().Trim(); //审核人
objPaperEN.LiteratureTypeId = objRow[conPaper.LiteratureTypeId].ToString().Trim(); //文献类型Id
objPaperEN.BrowseNumber = objRow[conPaper.BrowseNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaper.BrowseNumber].ToString().Trim()); //浏览量
objPaperEN.IsSubmit = TransNullToBool(objRow[conPaper.IsSubmit].ToString().Trim()); //是否提交
objPaperEN.AppraiseCount = objRow[conPaper.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaper.AppraiseCount].ToString().Trim()); //评论数
objPaperEN.AttachmentCount = objRow[conPaper.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaper.AttachmentCount].ToString().Trim()); //附件计数
objPaperEN.CollectionCount = objRow[conPaper.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conPaper.CollectionCount].ToString().Trim()); //收藏数量
objPaperEN.DownloadCount = objRow[conPaper.DownloadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaper.DownloadCount].ToString().Trim()); //下载数
objPaperEN.OkCount = objRow[conPaper.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaper.OkCount].ToString().Trim()); //点赞统计
objPaperEN.Pcount = objRow[conPaper.Pcount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaper.Pcount].ToString().Trim()); //读写数
objPaperEN.Score = objRow[conPaper.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conPaper.Score].ToString().Trim()); //评分
objPaperEN.StuScore = objRow[conPaper.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conPaper.StuScore].ToString().Trim()); //学生平均分
objPaperEN.TeaScore = objRow[conPaper.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conPaper.TeaScore].ToString().Trim()); //教师评分
objPaperEN.PaperTypeId = objRow[conPaper.PaperTypeId] == DBNull.Value ? null : objRow[conPaper.PaperTypeId].ToString().Trim(); //论文类型Id
objPaperEN.PaperStatusId = objRow[conPaper.PaperStatusId] == DBNull.Value ? null : objRow[conPaper.PaperStatusId].ToString().Trim(); //论文状态Id
objPaperEN.VersionCount = objRow[conPaper.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaper.VersionCount].ToString().Trim()); //版本统计
objPaperEN.IsPublic = TransNullToBool(objRow[conPaper.IsPublic].ToString().Trim()); //是否公开
objPaperEN.AskQuestion = objRow[conPaper.AskQuestion] == DBNull.Value ? null : objRow[conPaper.AskQuestion].ToString().Trim(); //问题提出
objPaperEN.ResearchStatus = objRow[conPaper.ResearchStatus] == DBNull.Value ? null : objRow[conPaper.ResearchStatus].ToString().Trim(); //目前研究的现状
objPaperEN.InnovationPoints = objRow[conPaper.InnovationPoints] == DBNull.Value ? null : objRow[conPaper.InnovationPoints].ToString().Trim(); //创新点
objPaperEN.ResearchDesign = objRow[conPaper.ResearchDesign] == DBNull.Value ? null : objRow[conPaper.ResearchDesign].ToString().Trim(); //研究设计
objPaperEN.DimensionDataProcess = objRow[conPaper.DimensionDataProcess] == DBNull.Value ? null : objRow[conPaper.DimensionDataProcess].ToString().Trim(); //数据处理的维度
objPaperEN.ExpectedConclusion = objRow[conPaper.ExpectedConclusion] == DBNull.Value ? null : objRow[conPaper.ExpectedConclusion].ToString().Trim(); //预期结论
objPaperEN.ShareId = objRow[conPaper.ShareId] == DBNull.Value ? null : objRow[conPaper.ShareId].ToString().Trim(); //分享Id
objPaperEN.PaperQCount = objRow[conPaper.PaperQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaper.PaperQCount].ToString().Trim()); //论文答疑数
objPaperEN.SubVCount = objRow[conPaper.SubVCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaper.SubVCount].ToString().Trim()); //论文子观点数
objPaperEN.TagsCount = objRow[conPaper.TagsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaper.TagsCount].ToString().Trim()); //论文标注数
objPaperEN.TeaQCount = objRow[conPaper.TeaQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaper.TeaQCount].ToString().Trim()); //教师提问数
objPaperEN.IdStudyLevel = objRow[conPaper.IdStudyLevel] == DBNull.Value ? null : objRow[conPaper.IdStudyLevel].ToString().Trim(); //学段流水号
objPaperEN.IdGrade = objRow[conPaper.IdGrade] == DBNull.Value ? null : objRow[conPaper.IdGrade].ToString().Trim(); //年级流水号
objPaperEN.CreateDate = objRow[conPaper.CreateDate] == DBNull.Value ? null : objRow[conPaper.CreateDate].ToString().Trim(); //建立日期
objPaperEN.UpdUser = objRow[conPaper.UpdUser] == DBNull.Value ? null : objRow[conPaper.UpdUser].ToString().Trim(); //修改人
objPaperEN.UpdDate = objRow[conPaper.UpdDate] == DBNull.Value ? null : objRow[conPaper.UpdDate].ToString().Trim(); //修改日期
objPaperEN.Memo = objRow[conPaper.Memo] == DBNull.Value ? null : objRow[conPaper.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsPaperDA: GetObjByDataRowPaper)", objException.Message));
}
objPaperEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objPaperEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsPaperEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsPaperEN objPaperEN = new clsPaperEN();
try
{
objPaperEN.PaperId = objRow[conPaper.PaperId].ToString().Trim(); //论文Id
objPaperEN.PaperTitle = objRow[conPaper.PaperTitle].ToString().Trim(); //论文标题
objPaperEN.PaperContent = objRow[conPaper.PaperContent] == DBNull.Value ? null : objRow[conPaper.PaperContent].ToString().Trim(); //主题内容
objPaperEN.Periodical = objRow[conPaper.Periodical] == DBNull.Value ? null : objRow[conPaper.Periodical].ToString().Trim(); //期刊
objPaperEN.Author = objRow[conPaper.Author] == DBNull.Value ? null : objRow[conPaper.Author].ToString().Trim(); //作者
objPaperEN.ResearchQuestion = objRow[conPaper.ResearchQuestion] == DBNull.Value ? null : objRow[conPaper.ResearchQuestion].ToString().Trim(); //研究问题
objPaperEN.Keyword = objRow[conPaper.Keyword] == DBNull.Value ? null : objRow[conPaper.Keyword].ToString().Trim(); //关键字
objPaperEN.LiteratureSources = objRow[conPaper.LiteratureSources] == DBNull.Value ? null : objRow[conPaper.LiteratureSources].ToString().Trim(); //文献来源
objPaperEN.LiteratureLink = objRow[conPaper.LiteratureLink] == DBNull.Value ? null : objRow[conPaper.LiteratureLink].ToString().Trim(); //文献链接
objPaperEN.UploadfileUrl = objRow[conPaper.UploadfileUrl] == DBNull.Value ? null : objRow[conPaper.UploadfileUrl].ToString().Trim(); //文件地址
objPaperEN.IsQuotethesis = TransNullToBool(objRow[conPaper.IsQuotethesis].ToString().Trim()); //是否引用论文
objPaperEN.QuoteId = objRow[conPaper.QuoteId] == DBNull.Value ? null : objRow[conPaper.QuoteId].ToString().Trim(); //引用Id
objPaperEN.IsChecked = TransNullToBool(objRow[conPaper.IsChecked].ToString().Trim()); //是否检查
objPaperEN.Checker = objRow[conPaper.Checker] == DBNull.Value ? null : objRow[conPaper.Checker].ToString().Trim(); //审核人
objPaperEN.LiteratureTypeId = objRow[conPaper.LiteratureTypeId].ToString().Trim(); //文献类型Id
objPaperEN.BrowseNumber = objRow[conPaper.BrowseNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaper.BrowseNumber].ToString().Trim()); //浏览量
objPaperEN.IsSubmit = TransNullToBool(objRow[conPaper.IsSubmit].ToString().Trim()); //是否提交
objPaperEN.AppraiseCount = objRow[conPaper.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaper.AppraiseCount].ToString().Trim()); //评论数
objPaperEN.AttachmentCount = objRow[conPaper.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaper.AttachmentCount].ToString().Trim()); //附件计数
objPaperEN.CollectionCount = objRow[conPaper.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conPaper.CollectionCount].ToString().Trim()); //收藏数量
objPaperEN.DownloadCount = objRow[conPaper.DownloadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaper.DownloadCount].ToString().Trim()); //下载数
objPaperEN.OkCount = objRow[conPaper.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaper.OkCount].ToString().Trim()); //点赞统计
objPaperEN.Pcount = objRow[conPaper.Pcount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaper.Pcount].ToString().Trim()); //读写数
objPaperEN.Score = objRow[conPaper.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conPaper.Score].ToString().Trim()); //评分
objPaperEN.StuScore = objRow[conPaper.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conPaper.StuScore].ToString().Trim()); //学生平均分
objPaperEN.TeaScore = objRow[conPaper.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conPaper.TeaScore].ToString().Trim()); //教师评分
objPaperEN.PaperTypeId = objRow[conPaper.PaperTypeId] == DBNull.Value ? null : objRow[conPaper.PaperTypeId].ToString().Trim(); //论文类型Id
objPaperEN.PaperStatusId = objRow[conPaper.PaperStatusId] == DBNull.Value ? null : objRow[conPaper.PaperStatusId].ToString().Trim(); //论文状态Id
objPaperEN.VersionCount = objRow[conPaper.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaper.VersionCount].ToString().Trim()); //版本统计
objPaperEN.IsPublic = TransNullToBool(objRow[conPaper.IsPublic].ToString().Trim()); //是否公开
objPaperEN.AskQuestion = objRow[conPaper.AskQuestion] == DBNull.Value ? null : objRow[conPaper.AskQuestion].ToString().Trim(); //问题提出
objPaperEN.ResearchStatus = objRow[conPaper.ResearchStatus] == DBNull.Value ? null : objRow[conPaper.ResearchStatus].ToString().Trim(); //目前研究的现状
objPaperEN.InnovationPoints = objRow[conPaper.InnovationPoints] == DBNull.Value ? null : objRow[conPaper.InnovationPoints].ToString().Trim(); //创新点
objPaperEN.ResearchDesign = objRow[conPaper.ResearchDesign] == DBNull.Value ? null : objRow[conPaper.ResearchDesign].ToString().Trim(); //研究设计
objPaperEN.DimensionDataProcess = objRow[conPaper.DimensionDataProcess] == DBNull.Value ? null : objRow[conPaper.DimensionDataProcess].ToString().Trim(); //数据处理的维度
objPaperEN.ExpectedConclusion = objRow[conPaper.ExpectedConclusion] == DBNull.Value ? null : objRow[conPaper.ExpectedConclusion].ToString().Trim(); //预期结论
objPaperEN.ShareId = objRow[conPaper.ShareId] == DBNull.Value ? null : objRow[conPaper.ShareId].ToString().Trim(); //分享Id
objPaperEN.PaperQCount = objRow[conPaper.PaperQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaper.PaperQCount].ToString().Trim()); //论文答疑数
objPaperEN.SubVCount = objRow[conPaper.SubVCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaper.SubVCount].ToString().Trim()); //论文子观点数
objPaperEN.TagsCount = objRow[conPaper.TagsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaper.TagsCount].ToString().Trim()); //论文标注数
objPaperEN.TeaQCount = objRow[conPaper.TeaQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaper.TeaQCount].ToString().Trim()); //教师提问数
objPaperEN.IdStudyLevel = objRow[conPaper.IdStudyLevel] == DBNull.Value ? null : objRow[conPaper.IdStudyLevel].ToString().Trim(); //学段流水号
objPaperEN.IdGrade = objRow[conPaper.IdGrade] == DBNull.Value ? null : objRow[conPaper.IdGrade].ToString().Trim(); //年级流水号
objPaperEN.CreateDate = objRow[conPaper.CreateDate] == DBNull.Value ? null : objRow[conPaper.CreateDate].ToString().Trim(); //建立日期
objPaperEN.UpdUser = objRow[conPaper.UpdUser] == DBNull.Value ? null : objRow[conPaper.UpdUser].ToString().Trim(); //修改人
objPaperEN.UpdDate = objRow[conPaper.UpdDate] == DBNull.Value ? null : objRow[conPaper.UpdDate].ToString().Trim(); //修改日期
objPaperEN.Memo = objRow[conPaper.Memo] == DBNull.Value ? null : objRow[conPaper.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsPaperDA: GetObjByDataRow)", objException.Message));
}
objPaperEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objPaperEN;
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
objSQL = clsPaperDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsPaperEN._CurrTabName, conPaper.PaperId, 8, "");
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
objSQL = clsPaperDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsPaperEN._CurrTabName, conPaper.PaperId, 8, strPrefix);
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
 objSQL = clsPaperDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select PaperId from Paper where " + strCondition;
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
 objSQL = clsPaperDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select PaperId from Paper where " + strCondition;
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
 objSQL = clsPaperDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("Paper", "PaperId = " + "'"+ strPaperId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsPaperDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("Paper", strCondition))
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
objSQL = clsPaperDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("Paper");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsPaperEN objPaperEN)
 {
 if (objPaperEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPaperEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperDA.GetSpecSQLObj();
strSQL = "Select * from Paper where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "Paper");
objRow = objDS.Tables["Paper"].NewRow();
objRow[conPaper.PaperId] = objPaperEN.PaperId; //论文Id
objRow[conPaper.PaperTitle] = objPaperEN.PaperTitle; //论文标题
 if (objPaperEN.PaperContent !=  "")
 {
objRow[conPaper.PaperContent] = objPaperEN.PaperContent; //主题内容
 }
 if (objPaperEN.Periodical !=  "")
 {
objRow[conPaper.Periodical] = objPaperEN.Periodical; //期刊
 }
 if (objPaperEN.Author !=  "")
 {
objRow[conPaper.Author] = objPaperEN.Author; //作者
 }
 if (objPaperEN.ResearchQuestion !=  "")
 {
objRow[conPaper.ResearchQuestion] = objPaperEN.ResearchQuestion; //研究问题
 }
 if (objPaperEN.Keyword !=  "")
 {
objRow[conPaper.Keyword] = objPaperEN.Keyword; //关键字
 }
 if (objPaperEN.LiteratureSources !=  "")
 {
objRow[conPaper.LiteratureSources] = objPaperEN.LiteratureSources; //文献来源
 }
 if (objPaperEN.LiteratureLink !=  "")
 {
objRow[conPaper.LiteratureLink] = objPaperEN.LiteratureLink; //文献链接
 }
 if (objPaperEN.UploadfileUrl !=  "")
 {
objRow[conPaper.UploadfileUrl] = objPaperEN.UploadfileUrl; //文件地址
 }
objRow[conPaper.IsQuotethesis] = objPaperEN.IsQuotethesis; //是否引用论文
 if (objPaperEN.QuoteId !=  "")
 {
objRow[conPaper.QuoteId] = objPaperEN.QuoteId; //引用Id
 }
objRow[conPaper.IsChecked] = objPaperEN.IsChecked; //是否检查
 if (objPaperEN.Checker !=  "")
 {
objRow[conPaper.Checker] = objPaperEN.Checker; //审核人
 }
objRow[conPaper.LiteratureTypeId] = objPaperEN.LiteratureTypeId; //文献类型Id
objRow[conPaper.BrowseNumber] = objPaperEN.BrowseNumber; //浏览量
objRow[conPaper.IsSubmit] = objPaperEN.IsSubmit; //是否提交
objRow[conPaper.AppraiseCount] = objPaperEN.AppraiseCount; //评论数
objRow[conPaper.AttachmentCount] = objPaperEN.AttachmentCount; //附件计数
objRow[conPaper.CollectionCount] = objPaperEN.CollectionCount; //收藏数量
objRow[conPaper.DownloadCount] = objPaperEN.DownloadCount; //下载数
objRow[conPaper.OkCount] = objPaperEN.OkCount; //点赞统计
objRow[conPaper.Pcount] = objPaperEN.Pcount; //读写数
objRow[conPaper.Score] = objPaperEN.Score; //评分
objRow[conPaper.StuScore] = objPaperEN.StuScore; //学生平均分
objRow[conPaper.TeaScore] = objPaperEN.TeaScore; //教师评分
 if (objPaperEN.PaperTypeId !=  "")
 {
objRow[conPaper.PaperTypeId] = objPaperEN.PaperTypeId; //论文类型Id
 }
 if (objPaperEN.PaperStatusId !=  "")
 {
objRow[conPaper.PaperStatusId] = objPaperEN.PaperStatusId; //论文状态Id
 }
objRow[conPaper.VersionCount] = objPaperEN.VersionCount; //版本统计
objRow[conPaper.IsPublic] = objPaperEN.IsPublic; //是否公开
 if (objPaperEN.AskQuestion !=  "")
 {
objRow[conPaper.AskQuestion] = objPaperEN.AskQuestion; //问题提出
 }
 if (objPaperEN.ResearchStatus !=  "")
 {
objRow[conPaper.ResearchStatus] = objPaperEN.ResearchStatus; //目前研究的现状
 }
 if (objPaperEN.InnovationPoints !=  "")
 {
objRow[conPaper.InnovationPoints] = objPaperEN.InnovationPoints; //创新点
 }
 if (objPaperEN.ResearchDesign !=  "")
 {
objRow[conPaper.ResearchDesign] = objPaperEN.ResearchDesign; //研究设计
 }
 if (objPaperEN.DimensionDataProcess !=  "")
 {
objRow[conPaper.DimensionDataProcess] = objPaperEN.DimensionDataProcess; //数据处理的维度
 }
 if (objPaperEN.ExpectedConclusion !=  "")
 {
objRow[conPaper.ExpectedConclusion] = objPaperEN.ExpectedConclusion; //预期结论
 }
 if (objPaperEN.ShareId !=  "")
 {
objRow[conPaper.ShareId] = objPaperEN.ShareId; //分享Id
 }
objRow[conPaper.PaperQCount] = objPaperEN.PaperQCount; //论文答疑数
objRow[conPaper.SubVCount] = objPaperEN.SubVCount; //论文子观点数
objRow[conPaper.TagsCount] = objPaperEN.TagsCount; //论文标注数
objRow[conPaper.TeaQCount] = objPaperEN.TeaQCount; //教师提问数
 if (objPaperEN.IdStudyLevel !=  "")
 {
objRow[conPaper.IdStudyLevel] = objPaperEN.IdStudyLevel; //学段流水号
 }
 if (objPaperEN.IdGrade !=  "")
 {
objRow[conPaper.IdGrade] = objPaperEN.IdGrade; //年级流水号
 }
 if (objPaperEN.CreateDate !=  "")
 {
objRow[conPaper.CreateDate] = objPaperEN.CreateDate; //建立日期
 }
 if (objPaperEN.UpdUser !=  "")
 {
objRow[conPaper.UpdUser] = objPaperEN.UpdUser; //修改人
 }
 if (objPaperEN.UpdDate !=  "")
 {
objRow[conPaper.UpdDate] = objPaperEN.UpdDate; //修改日期
 }
 if (objPaperEN.Memo !=  "")
 {
objRow[conPaper.Memo] = objPaperEN.Memo; //备注
 }
objDS.Tables[clsPaperEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsPaperEN._CurrTabName);
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
 /// <param name = "objPaperEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsPaperEN objPaperEN)
{
 if (objPaperEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPaperEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objPaperEN.PaperId !=  null)
 {
 arrFieldListForInsert.Add(conPaper.PaperId);
 var strPaperId = objPaperEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperId + "'");
 }
 
 if (objPaperEN.PaperTitle !=  null)
 {
 arrFieldListForInsert.Add(conPaper.PaperTitle);
 var strPaperTitle = objPaperEN.PaperTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperTitle + "'");
 }
 
 if (objPaperEN.PaperContent !=  null)
 {
 arrFieldListForInsert.Add(conPaper.PaperContent);
 var strPaperContent = objPaperEN.PaperContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperContent + "'");
 }
 
 if (objPaperEN.Periodical !=  null)
 {
 arrFieldListForInsert.Add(conPaper.Periodical);
 var strPeriodical = objPaperEN.Periodical.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPeriodical + "'");
 }
 
 if (objPaperEN.Author !=  null)
 {
 arrFieldListForInsert.Add(conPaper.Author);
 var strAuthor = objPaperEN.Author.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAuthor + "'");
 }
 
 if (objPaperEN.ResearchQuestion !=  null)
 {
 arrFieldListForInsert.Add(conPaper.ResearchQuestion);
 var strResearchQuestion = objPaperEN.ResearchQuestion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResearchQuestion + "'");
 }
 
 if (objPaperEN.Keyword !=  null)
 {
 arrFieldListForInsert.Add(conPaper.Keyword);
 var strKeyword = objPaperEN.Keyword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyword + "'");
 }
 
 if (objPaperEN.LiteratureSources !=  null)
 {
 arrFieldListForInsert.Add(conPaper.LiteratureSources);
 var strLiteratureSources = objPaperEN.LiteratureSources.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLiteratureSources + "'");
 }
 
 if (objPaperEN.LiteratureLink !=  null)
 {
 arrFieldListForInsert.Add(conPaper.LiteratureLink);
 var strLiteratureLink = objPaperEN.LiteratureLink.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLiteratureLink + "'");
 }
 
 if (objPaperEN.UploadfileUrl !=  null)
 {
 arrFieldListForInsert.Add(conPaper.UploadfileUrl);
 var strUploadfileUrl = objPaperEN.UploadfileUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUploadfileUrl + "'");
 }
 
 arrFieldListForInsert.Add(conPaper.IsQuotethesis);
 arrValueListForInsert.Add("'" + (objPaperEN.IsQuotethesis  ==  false ? "0" : "1") + "'");
 
 if (objPaperEN.QuoteId !=  null)
 {
 arrFieldListForInsert.Add(conPaper.QuoteId);
 var strQuoteId = objPaperEN.QuoteId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuoteId + "'");
 }
 
 arrFieldListForInsert.Add(conPaper.IsChecked);
 arrValueListForInsert.Add("'" + (objPaperEN.IsChecked  ==  false ? "0" : "1") + "'");
 
 if (objPaperEN.Checker !=  null)
 {
 arrFieldListForInsert.Add(conPaper.Checker);
 var strChecker = objPaperEN.Checker.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strChecker + "'");
 }
 
 if (objPaperEN.LiteratureTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPaper.LiteratureTypeId);
 var strLiteratureTypeId = objPaperEN.LiteratureTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLiteratureTypeId + "'");
 }
 
 if (objPaperEN.BrowseNumber !=  null)
 {
 arrFieldListForInsert.Add(conPaper.BrowseNumber);
 arrValueListForInsert.Add(objPaperEN.BrowseNumber.ToString());
 }
 
 arrFieldListForInsert.Add(conPaper.IsSubmit);
 arrValueListForInsert.Add("'" + (objPaperEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objPaperEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conPaper.AppraiseCount);
 arrValueListForInsert.Add(objPaperEN.AppraiseCount.ToString());
 }
 
 if (objPaperEN.AttachmentCount !=  null)
 {
 arrFieldListForInsert.Add(conPaper.AttachmentCount);
 arrValueListForInsert.Add(objPaperEN.AttachmentCount.ToString());
 }
 
 if (objPaperEN.CollectionCount !=  null)
 {
 arrFieldListForInsert.Add(conPaper.CollectionCount);
 arrValueListForInsert.Add(objPaperEN.CollectionCount.ToString());
 }
 
 if (objPaperEN.DownloadCount !=  null)
 {
 arrFieldListForInsert.Add(conPaper.DownloadCount);
 arrValueListForInsert.Add(objPaperEN.DownloadCount.ToString());
 }
 
 if (objPaperEN.OkCount !=  null)
 {
 arrFieldListForInsert.Add(conPaper.OkCount);
 arrValueListForInsert.Add(objPaperEN.OkCount.ToString());
 }
 
 if (objPaperEN.Pcount !=  null)
 {
 arrFieldListForInsert.Add(conPaper.Pcount);
 arrValueListForInsert.Add(objPaperEN.Pcount.ToString());
 }
 
 if (objPaperEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conPaper.Score);
 arrValueListForInsert.Add(objPaperEN.Score.ToString());
 }
 
 if (objPaperEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conPaper.StuScore);
 arrValueListForInsert.Add(objPaperEN.StuScore.ToString());
 }
 
 if (objPaperEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conPaper.TeaScore);
 arrValueListForInsert.Add(objPaperEN.TeaScore.ToString());
 }
 
 if (objPaperEN.PaperTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPaper.PaperTypeId);
 var strPaperTypeId = objPaperEN.PaperTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperTypeId + "'");
 }
 
 if (objPaperEN.PaperStatusId !=  null)
 {
 arrFieldListForInsert.Add(conPaper.PaperStatusId);
 var strPaperStatusId = objPaperEN.PaperStatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperStatusId + "'");
 }
 
 if (objPaperEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conPaper.VersionCount);
 arrValueListForInsert.Add(objPaperEN.VersionCount.ToString());
 }
 
 arrFieldListForInsert.Add(conPaper.IsPublic);
 arrValueListForInsert.Add("'" + (objPaperEN.IsPublic  ==  false ? "0" : "1") + "'");
 
 if (objPaperEN.AskQuestion !=  null)
 {
 arrFieldListForInsert.Add(conPaper.AskQuestion);
 var strAskQuestion = objPaperEN.AskQuestion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAskQuestion + "'");
 }
 
 if (objPaperEN.ResearchStatus !=  null)
 {
 arrFieldListForInsert.Add(conPaper.ResearchStatus);
 var strResearchStatus = objPaperEN.ResearchStatus.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResearchStatus + "'");
 }
 
 if (objPaperEN.InnovationPoints !=  null)
 {
 arrFieldListForInsert.Add(conPaper.InnovationPoints);
 var strInnovationPoints = objPaperEN.InnovationPoints.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strInnovationPoints + "'");
 }
 
 if (objPaperEN.ResearchDesign !=  null)
 {
 arrFieldListForInsert.Add(conPaper.ResearchDesign);
 var strResearchDesign = objPaperEN.ResearchDesign.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResearchDesign + "'");
 }
 
 if (objPaperEN.DimensionDataProcess !=  null)
 {
 arrFieldListForInsert.Add(conPaper.DimensionDataProcess);
 var strDimensionDataProcess = objPaperEN.DimensionDataProcess.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDimensionDataProcess + "'");
 }
 
 if (objPaperEN.ExpectedConclusion !=  null)
 {
 arrFieldListForInsert.Add(conPaper.ExpectedConclusion);
 var strExpectedConclusion = objPaperEN.ExpectedConclusion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExpectedConclusion + "'");
 }
 
 if (objPaperEN.ShareId !=  null)
 {
 arrFieldListForInsert.Add(conPaper.ShareId);
 var strShareId = objPaperEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strShareId + "'");
 }
 
 if (objPaperEN.PaperQCount !=  null)
 {
 arrFieldListForInsert.Add(conPaper.PaperQCount);
 arrValueListForInsert.Add(objPaperEN.PaperQCount.ToString());
 }
 
 if (objPaperEN.SubVCount !=  null)
 {
 arrFieldListForInsert.Add(conPaper.SubVCount);
 arrValueListForInsert.Add(objPaperEN.SubVCount.ToString());
 }
 
 if (objPaperEN.TagsCount !=  null)
 {
 arrFieldListForInsert.Add(conPaper.TagsCount);
 arrValueListForInsert.Add(objPaperEN.TagsCount.ToString());
 }
 
 if (objPaperEN.TeaQCount !=  null)
 {
 arrFieldListForInsert.Add(conPaper.TeaQCount);
 arrValueListForInsert.Add(objPaperEN.TeaQCount.ToString());
 }
 
 if (objPaperEN.IdStudyLevel !=  null)
 {
 arrFieldListForInsert.Add(conPaper.IdStudyLevel);
 var strIdStudyLevel = objPaperEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudyLevel + "'");
 }
 
 if (objPaperEN.IdGrade !=  null)
 {
 arrFieldListForInsert.Add(conPaper.IdGrade);
 var strIdGrade = objPaperEN.IdGrade.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdGrade + "'");
 }
 
 if (objPaperEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conPaper.CreateDate);
 var strCreateDate = objPaperEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objPaperEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conPaper.UpdUser);
 var strUpdUser = objPaperEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objPaperEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conPaper.UpdDate);
 var strUpdDate = objPaperEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objPaperEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conPaper.Memo);
 var strMemo = objPaperEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Paper");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objPaperEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsPaperEN objPaperEN)
{
 if (objPaperEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPaperEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objPaperEN.PaperId !=  null)
 {
 arrFieldListForInsert.Add(conPaper.PaperId);
 var strPaperId = objPaperEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperId + "'");
 }
 
 if (objPaperEN.PaperTitle !=  null)
 {
 arrFieldListForInsert.Add(conPaper.PaperTitle);
 var strPaperTitle = objPaperEN.PaperTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperTitle + "'");
 }
 
 if (objPaperEN.PaperContent !=  null)
 {
 arrFieldListForInsert.Add(conPaper.PaperContent);
 var strPaperContent = objPaperEN.PaperContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperContent + "'");
 }
 
 if (objPaperEN.Periodical !=  null)
 {
 arrFieldListForInsert.Add(conPaper.Periodical);
 var strPeriodical = objPaperEN.Periodical.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPeriodical + "'");
 }
 
 if (objPaperEN.Author !=  null)
 {
 arrFieldListForInsert.Add(conPaper.Author);
 var strAuthor = objPaperEN.Author.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAuthor + "'");
 }
 
 if (objPaperEN.ResearchQuestion !=  null)
 {
 arrFieldListForInsert.Add(conPaper.ResearchQuestion);
 var strResearchQuestion = objPaperEN.ResearchQuestion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResearchQuestion + "'");
 }
 
 if (objPaperEN.Keyword !=  null)
 {
 arrFieldListForInsert.Add(conPaper.Keyword);
 var strKeyword = objPaperEN.Keyword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyword + "'");
 }
 
 if (objPaperEN.LiteratureSources !=  null)
 {
 arrFieldListForInsert.Add(conPaper.LiteratureSources);
 var strLiteratureSources = objPaperEN.LiteratureSources.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLiteratureSources + "'");
 }
 
 if (objPaperEN.LiteratureLink !=  null)
 {
 arrFieldListForInsert.Add(conPaper.LiteratureLink);
 var strLiteratureLink = objPaperEN.LiteratureLink.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLiteratureLink + "'");
 }
 
 if (objPaperEN.UploadfileUrl !=  null)
 {
 arrFieldListForInsert.Add(conPaper.UploadfileUrl);
 var strUploadfileUrl = objPaperEN.UploadfileUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUploadfileUrl + "'");
 }
 
 arrFieldListForInsert.Add(conPaper.IsQuotethesis);
 arrValueListForInsert.Add("'" + (objPaperEN.IsQuotethesis  ==  false ? "0" : "1") + "'");
 
 if (objPaperEN.QuoteId !=  null)
 {
 arrFieldListForInsert.Add(conPaper.QuoteId);
 var strQuoteId = objPaperEN.QuoteId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuoteId + "'");
 }
 
 arrFieldListForInsert.Add(conPaper.IsChecked);
 arrValueListForInsert.Add("'" + (objPaperEN.IsChecked  ==  false ? "0" : "1") + "'");
 
 if (objPaperEN.Checker !=  null)
 {
 arrFieldListForInsert.Add(conPaper.Checker);
 var strChecker = objPaperEN.Checker.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strChecker + "'");
 }
 
 if (objPaperEN.LiteratureTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPaper.LiteratureTypeId);
 var strLiteratureTypeId = objPaperEN.LiteratureTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLiteratureTypeId + "'");
 }
 
 if (objPaperEN.BrowseNumber !=  null)
 {
 arrFieldListForInsert.Add(conPaper.BrowseNumber);
 arrValueListForInsert.Add(objPaperEN.BrowseNumber.ToString());
 }
 
 arrFieldListForInsert.Add(conPaper.IsSubmit);
 arrValueListForInsert.Add("'" + (objPaperEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objPaperEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conPaper.AppraiseCount);
 arrValueListForInsert.Add(objPaperEN.AppraiseCount.ToString());
 }
 
 if (objPaperEN.AttachmentCount !=  null)
 {
 arrFieldListForInsert.Add(conPaper.AttachmentCount);
 arrValueListForInsert.Add(objPaperEN.AttachmentCount.ToString());
 }
 
 if (objPaperEN.CollectionCount !=  null)
 {
 arrFieldListForInsert.Add(conPaper.CollectionCount);
 arrValueListForInsert.Add(objPaperEN.CollectionCount.ToString());
 }
 
 if (objPaperEN.DownloadCount !=  null)
 {
 arrFieldListForInsert.Add(conPaper.DownloadCount);
 arrValueListForInsert.Add(objPaperEN.DownloadCount.ToString());
 }
 
 if (objPaperEN.OkCount !=  null)
 {
 arrFieldListForInsert.Add(conPaper.OkCount);
 arrValueListForInsert.Add(objPaperEN.OkCount.ToString());
 }
 
 if (objPaperEN.Pcount !=  null)
 {
 arrFieldListForInsert.Add(conPaper.Pcount);
 arrValueListForInsert.Add(objPaperEN.Pcount.ToString());
 }
 
 if (objPaperEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conPaper.Score);
 arrValueListForInsert.Add(objPaperEN.Score.ToString());
 }
 
 if (objPaperEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conPaper.StuScore);
 arrValueListForInsert.Add(objPaperEN.StuScore.ToString());
 }
 
 if (objPaperEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conPaper.TeaScore);
 arrValueListForInsert.Add(objPaperEN.TeaScore.ToString());
 }
 
 if (objPaperEN.PaperTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPaper.PaperTypeId);
 var strPaperTypeId = objPaperEN.PaperTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperTypeId + "'");
 }
 
 if (objPaperEN.PaperStatusId !=  null)
 {
 arrFieldListForInsert.Add(conPaper.PaperStatusId);
 var strPaperStatusId = objPaperEN.PaperStatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperStatusId + "'");
 }
 
 if (objPaperEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conPaper.VersionCount);
 arrValueListForInsert.Add(objPaperEN.VersionCount.ToString());
 }
 
 arrFieldListForInsert.Add(conPaper.IsPublic);
 arrValueListForInsert.Add("'" + (objPaperEN.IsPublic  ==  false ? "0" : "1") + "'");
 
 if (objPaperEN.AskQuestion !=  null)
 {
 arrFieldListForInsert.Add(conPaper.AskQuestion);
 var strAskQuestion = objPaperEN.AskQuestion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAskQuestion + "'");
 }
 
 if (objPaperEN.ResearchStatus !=  null)
 {
 arrFieldListForInsert.Add(conPaper.ResearchStatus);
 var strResearchStatus = objPaperEN.ResearchStatus.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResearchStatus + "'");
 }
 
 if (objPaperEN.InnovationPoints !=  null)
 {
 arrFieldListForInsert.Add(conPaper.InnovationPoints);
 var strInnovationPoints = objPaperEN.InnovationPoints.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strInnovationPoints + "'");
 }
 
 if (objPaperEN.ResearchDesign !=  null)
 {
 arrFieldListForInsert.Add(conPaper.ResearchDesign);
 var strResearchDesign = objPaperEN.ResearchDesign.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResearchDesign + "'");
 }
 
 if (objPaperEN.DimensionDataProcess !=  null)
 {
 arrFieldListForInsert.Add(conPaper.DimensionDataProcess);
 var strDimensionDataProcess = objPaperEN.DimensionDataProcess.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDimensionDataProcess + "'");
 }
 
 if (objPaperEN.ExpectedConclusion !=  null)
 {
 arrFieldListForInsert.Add(conPaper.ExpectedConclusion);
 var strExpectedConclusion = objPaperEN.ExpectedConclusion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExpectedConclusion + "'");
 }
 
 if (objPaperEN.ShareId !=  null)
 {
 arrFieldListForInsert.Add(conPaper.ShareId);
 var strShareId = objPaperEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strShareId + "'");
 }
 
 if (objPaperEN.PaperQCount !=  null)
 {
 arrFieldListForInsert.Add(conPaper.PaperQCount);
 arrValueListForInsert.Add(objPaperEN.PaperQCount.ToString());
 }
 
 if (objPaperEN.SubVCount !=  null)
 {
 arrFieldListForInsert.Add(conPaper.SubVCount);
 arrValueListForInsert.Add(objPaperEN.SubVCount.ToString());
 }
 
 if (objPaperEN.TagsCount !=  null)
 {
 arrFieldListForInsert.Add(conPaper.TagsCount);
 arrValueListForInsert.Add(objPaperEN.TagsCount.ToString());
 }
 
 if (objPaperEN.TeaQCount !=  null)
 {
 arrFieldListForInsert.Add(conPaper.TeaQCount);
 arrValueListForInsert.Add(objPaperEN.TeaQCount.ToString());
 }
 
 if (objPaperEN.IdStudyLevel !=  null)
 {
 arrFieldListForInsert.Add(conPaper.IdStudyLevel);
 var strIdStudyLevel = objPaperEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudyLevel + "'");
 }
 
 if (objPaperEN.IdGrade !=  null)
 {
 arrFieldListForInsert.Add(conPaper.IdGrade);
 var strIdGrade = objPaperEN.IdGrade.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdGrade + "'");
 }
 
 if (objPaperEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conPaper.CreateDate);
 var strCreateDate = objPaperEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objPaperEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conPaper.UpdUser);
 var strUpdUser = objPaperEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objPaperEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conPaper.UpdDate);
 var strUpdDate = objPaperEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objPaperEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conPaper.Memo);
 var strMemo = objPaperEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Paper");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objPaperEN.PaperId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objPaperEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsPaperEN objPaperEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objPaperEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPaperEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objPaperEN.PaperId !=  null)
 {
 arrFieldListForInsert.Add(conPaper.PaperId);
 var strPaperId = objPaperEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperId + "'");
 }
 
 if (objPaperEN.PaperTitle !=  null)
 {
 arrFieldListForInsert.Add(conPaper.PaperTitle);
 var strPaperTitle = objPaperEN.PaperTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperTitle + "'");
 }
 
 if (objPaperEN.PaperContent !=  null)
 {
 arrFieldListForInsert.Add(conPaper.PaperContent);
 var strPaperContent = objPaperEN.PaperContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperContent + "'");
 }
 
 if (objPaperEN.Periodical !=  null)
 {
 arrFieldListForInsert.Add(conPaper.Periodical);
 var strPeriodical = objPaperEN.Periodical.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPeriodical + "'");
 }
 
 if (objPaperEN.Author !=  null)
 {
 arrFieldListForInsert.Add(conPaper.Author);
 var strAuthor = objPaperEN.Author.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAuthor + "'");
 }
 
 if (objPaperEN.ResearchQuestion !=  null)
 {
 arrFieldListForInsert.Add(conPaper.ResearchQuestion);
 var strResearchQuestion = objPaperEN.ResearchQuestion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResearchQuestion + "'");
 }
 
 if (objPaperEN.Keyword !=  null)
 {
 arrFieldListForInsert.Add(conPaper.Keyword);
 var strKeyword = objPaperEN.Keyword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyword + "'");
 }
 
 if (objPaperEN.LiteratureSources !=  null)
 {
 arrFieldListForInsert.Add(conPaper.LiteratureSources);
 var strLiteratureSources = objPaperEN.LiteratureSources.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLiteratureSources + "'");
 }
 
 if (objPaperEN.LiteratureLink !=  null)
 {
 arrFieldListForInsert.Add(conPaper.LiteratureLink);
 var strLiteratureLink = objPaperEN.LiteratureLink.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLiteratureLink + "'");
 }
 
 if (objPaperEN.UploadfileUrl !=  null)
 {
 arrFieldListForInsert.Add(conPaper.UploadfileUrl);
 var strUploadfileUrl = objPaperEN.UploadfileUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUploadfileUrl + "'");
 }
 
 arrFieldListForInsert.Add(conPaper.IsQuotethesis);
 arrValueListForInsert.Add("'" + (objPaperEN.IsQuotethesis  ==  false ? "0" : "1") + "'");
 
 if (objPaperEN.QuoteId !=  null)
 {
 arrFieldListForInsert.Add(conPaper.QuoteId);
 var strQuoteId = objPaperEN.QuoteId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuoteId + "'");
 }
 
 arrFieldListForInsert.Add(conPaper.IsChecked);
 arrValueListForInsert.Add("'" + (objPaperEN.IsChecked  ==  false ? "0" : "1") + "'");
 
 if (objPaperEN.Checker !=  null)
 {
 arrFieldListForInsert.Add(conPaper.Checker);
 var strChecker = objPaperEN.Checker.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strChecker + "'");
 }
 
 if (objPaperEN.LiteratureTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPaper.LiteratureTypeId);
 var strLiteratureTypeId = objPaperEN.LiteratureTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLiteratureTypeId + "'");
 }
 
 if (objPaperEN.BrowseNumber !=  null)
 {
 arrFieldListForInsert.Add(conPaper.BrowseNumber);
 arrValueListForInsert.Add(objPaperEN.BrowseNumber.ToString());
 }
 
 arrFieldListForInsert.Add(conPaper.IsSubmit);
 arrValueListForInsert.Add("'" + (objPaperEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objPaperEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conPaper.AppraiseCount);
 arrValueListForInsert.Add(objPaperEN.AppraiseCount.ToString());
 }
 
 if (objPaperEN.AttachmentCount !=  null)
 {
 arrFieldListForInsert.Add(conPaper.AttachmentCount);
 arrValueListForInsert.Add(objPaperEN.AttachmentCount.ToString());
 }
 
 if (objPaperEN.CollectionCount !=  null)
 {
 arrFieldListForInsert.Add(conPaper.CollectionCount);
 arrValueListForInsert.Add(objPaperEN.CollectionCount.ToString());
 }
 
 if (objPaperEN.DownloadCount !=  null)
 {
 arrFieldListForInsert.Add(conPaper.DownloadCount);
 arrValueListForInsert.Add(objPaperEN.DownloadCount.ToString());
 }
 
 if (objPaperEN.OkCount !=  null)
 {
 arrFieldListForInsert.Add(conPaper.OkCount);
 arrValueListForInsert.Add(objPaperEN.OkCount.ToString());
 }
 
 if (objPaperEN.Pcount !=  null)
 {
 arrFieldListForInsert.Add(conPaper.Pcount);
 arrValueListForInsert.Add(objPaperEN.Pcount.ToString());
 }
 
 if (objPaperEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conPaper.Score);
 arrValueListForInsert.Add(objPaperEN.Score.ToString());
 }
 
 if (objPaperEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conPaper.StuScore);
 arrValueListForInsert.Add(objPaperEN.StuScore.ToString());
 }
 
 if (objPaperEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conPaper.TeaScore);
 arrValueListForInsert.Add(objPaperEN.TeaScore.ToString());
 }
 
 if (objPaperEN.PaperTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPaper.PaperTypeId);
 var strPaperTypeId = objPaperEN.PaperTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperTypeId + "'");
 }
 
 if (objPaperEN.PaperStatusId !=  null)
 {
 arrFieldListForInsert.Add(conPaper.PaperStatusId);
 var strPaperStatusId = objPaperEN.PaperStatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperStatusId + "'");
 }
 
 if (objPaperEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conPaper.VersionCount);
 arrValueListForInsert.Add(objPaperEN.VersionCount.ToString());
 }
 
 arrFieldListForInsert.Add(conPaper.IsPublic);
 arrValueListForInsert.Add("'" + (objPaperEN.IsPublic  ==  false ? "0" : "1") + "'");
 
 if (objPaperEN.AskQuestion !=  null)
 {
 arrFieldListForInsert.Add(conPaper.AskQuestion);
 var strAskQuestion = objPaperEN.AskQuestion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAskQuestion + "'");
 }
 
 if (objPaperEN.ResearchStatus !=  null)
 {
 arrFieldListForInsert.Add(conPaper.ResearchStatus);
 var strResearchStatus = objPaperEN.ResearchStatus.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResearchStatus + "'");
 }
 
 if (objPaperEN.InnovationPoints !=  null)
 {
 arrFieldListForInsert.Add(conPaper.InnovationPoints);
 var strInnovationPoints = objPaperEN.InnovationPoints.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strInnovationPoints + "'");
 }
 
 if (objPaperEN.ResearchDesign !=  null)
 {
 arrFieldListForInsert.Add(conPaper.ResearchDesign);
 var strResearchDesign = objPaperEN.ResearchDesign.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResearchDesign + "'");
 }
 
 if (objPaperEN.DimensionDataProcess !=  null)
 {
 arrFieldListForInsert.Add(conPaper.DimensionDataProcess);
 var strDimensionDataProcess = objPaperEN.DimensionDataProcess.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDimensionDataProcess + "'");
 }
 
 if (objPaperEN.ExpectedConclusion !=  null)
 {
 arrFieldListForInsert.Add(conPaper.ExpectedConclusion);
 var strExpectedConclusion = objPaperEN.ExpectedConclusion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExpectedConclusion + "'");
 }
 
 if (objPaperEN.ShareId !=  null)
 {
 arrFieldListForInsert.Add(conPaper.ShareId);
 var strShareId = objPaperEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strShareId + "'");
 }
 
 if (objPaperEN.PaperQCount !=  null)
 {
 arrFieldListForInsert.Add(conPaper.PaperQCount);
 arrValueListForInsert.Add(objPaperEN.PaperQCount.ToString());
 }
 
 if (objPaperEN.SubVCount !=  null)
 {
 arrFieldListForInsert.Add(conPaper.SubVCount);
 arrValueListForInsert.Add(objPaperEN.SubVCount.ToString());
 }
 
 if (objPaperEN.TagsCount !=  null)
 {
 arrFieldListForInsert.Add(conPaper.TagsCount);
 arrValueListForInsert.Add(objPaperEN.TagsCount.ToString());
 }
 
 if (objPaperEN.TeaQCount !=  null)
 {
 arrFieldListForInsert.Add(conPaper.TeaQCount);
 arrValueListForInsert.Add(objPaperEN.TeaQCount.ToString());
 }
 
 if (objPaperEN.IdStudyLevel !=  null)
 {
 arrFieldListForInsert.Add(conPaper.IdStudyLevel);
 var strIdStudyLevel = objPaperEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudyLevel + "'");
 }
 
 if (objPaperEN.IdGrade !=  null)
 {
 arrFieldListForInsert.Add(conPaper.IdGrade);
 var strIdGrade = objPaperEN.IdGrade.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdGrade + "'");
 }
 
 if (objPaperEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conPaper.CreateDate);
 var strCreateDate = objPaperEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objPaperEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conPaper.UpdUser);
 var strUpdUser = objPaperEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objPaperEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conPaper.UpdDate);
 var strUpdDate = objPaperEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objPaperEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conPaper.Memo);
 var strMemo = objPaperEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Paper");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objPaperEN.PaperId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objPaperEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsPaperEN objPaperEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objPaperEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPaperEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objPaperEN.PaperId !=  null)
 {
 arrFieldListForInsert.Add(conPaper.PaperId);
 var strPaperId = objPaperEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperId + "'");
 }
 
 if (objPaperEN.PaperTitle !=  null)
 {
 arrFieldListForInsert.Add(conPaper.PaperTitle);
 var strPaperTitle = objPaperEN.PaperTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperTitle + "'");
 }
 
 if (objPaperEN.PaperContent !=  null)
 {
 arrFieldListForInsert.Add(conPaper.PaperContent);
 var strPaperContent = objPaperEN.PaperContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperContent + "'");
 }
 
 if (objPaperEN.Periodical !=  null)
 {
 arrFieldListForInsert.Add(conPaper.Periodical);
 var strPeriodical = objPaperEN.Periodical.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPeriodical + "'");
 }
 
 if (objPaperEN.Author !=  null)
 {
 arrFieldListForInsert.Add(conPaper.Author);
 var strAuthor = objPaperEN.Author.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAuthor + "'");
 }
 
 if (objPaperEN.ResearchQuestion !=  null)
 {
 arrFieldListForInsert.Add(conPaper.ResearchQuestion);
 var strResearchQuestion = objPaperEN.ResearchQuestion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResearchQuestion + "'");
 }
 
 if (objPaperEN.Keyword !=  null)
 {
 arrFieldListForInsert.Add(conPaper.Keyword);
 var strKeyword = objPaperEN.Keyword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyword + "'");
 }
 
 if (objPaperEN.LiteratureSources !=  null)
 {
 arrFieldListForInsert.Add(conPaper.LiteratureSources);
 var strLiteratureSources = objPaperEN.LiteratureSources.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLiteratureSources + "'");
 }
 
 if (objPaperEN.LiteratureLink !=  null)
 {
 arrFieldListForInsert.Add(conPaper.LiteratureLink);
 var strLiteratureLink = objPaperEN.LiteratureLink.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLiteratureLink + "'");
 }
 
 if (objPaperEN.UploadfileUrl !=  null)
 {
 arrFieldListForInsert.Add(conPaper.UploadfileUrl);
 var strUploadfileUrl = objPaperEN.UploadfileUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUploadfileUrl + "'");
 }
 
 arrFieldListForInsert.Add(conPaper.IsQuotethesis);
 arrValueListForInsert.Add("'" + (objPaperEN.IsQuotethesis  ==  false ? "0" : "1") + "'");
 
 if (objPaperEN.QuoteId !=  null)
 {
 arrFieldListForInsert.Add(conPaper.QuoteId);
 var strQuoteId = objPaperEN.QuoteId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuoteId + "'");
 }
 
 arrFieldListForInsert.Add(conPaper.IsChecked);
 arrValueListForInsert.Add("'" + (objPaperEN.IsChecked  ==  false ? "0" : "1") + "'");
 
 if (objPaperEN.Checker !=  null)
 {
 arrFieldListForInsert.Add(conPaper.Checker);
 var strChecker = objPaperEN.Checker.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strChecker + "'");
 }
 
 if (objPaperEN.LiteratureTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPaper.LiteratureTypeId);
 var strLiteratureTypeId = objPaperEN.LiteratureTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLiteratureTypeId + "'");
 }
 
 if (objPaperEN.BrowseNumber !=  null)
 {
 arrFieldListForInsert.Add(conPaper.BrowseNumber);
 arrValueListForInsert.Add(objPaperEN.BrowseNumber.ToString());
 }
 
 arrFieldListForInsert.Add(conPaper.IsSubmit);
 arrValueListForInsert.Add("'" + (objPaperEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objPaperEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conPaper.AppraiseCount);
 arrValueListForInsert.Add(objPaperEN.AppraiseCount.ToString());
 }
 
 if (objPaperEN.AttachmentCount !=  null)
 {
 arrFieldListForInsert.Add(conPaper.AttachmentCount);
 arrValueListForInsert.Add(objPaperEN.AttachmentCount.ToString());
 }
 
 if (objPaperEN.CollectionCount !=  null)
 {
 arrFieldListForInsert.Add(conPaper.CollectionCount);
 arrValueListForInsert.Add(objPaperEN.CollectionCount.ToString());
 }
 
 if (objPaperEN.DownloadCount !=  null)
 {
 arrFieldListForInsert.Add(conPaper.DownloadCount);
 arrValueListForInsert.Add(objPaperEN.DownloadCount.ToString());
 }
 
 if (objPaperEN.OkCount !=  null)
 {
 arrFieldListForInsert.Add(conPaper.OkCount);
 arrValueListForInsert.Add(objPaperEN.OkCount.ToString());
 }
 
 if (objPaperEN.Pcount !=  null)
 {
 arrFieldListForInsert.Add(conPaper.Pcount);
 arrValueListForInsert.Add(objPaperEN.Pcount.ToString());
 }
 
 if (objPaperEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conPaper.Score);
 arrValueListForInsert.Add(objPaperEN.Score.ToString());
 }
 
 if (objPaperEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conPaper.StuScore);
 arrValueListForInsert.Add(objPaperEN.StuScore.ToString());
 }
 
 if (objPaperEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conPaper.TeaScore);
 arrValueListForInsert.Add(objPaperEN.TeaScore.ToString());
 }
 
 if (objPaperEN.PaperTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPaper.PaperTypeId);
 var strPaperTypeId = objPaperEN.PaperTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperTypeId + "'");
 }
 
 if (objPaperEN.PaperStatusId !=  null)
 {
 arrFieldListForInsert.Add(conPaper.PaperStatusId);
 var strPaperStatusId = objPaperEN.PaperStatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperStatusId + "'");
 }
 
 if (objPaperEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conPaper.VersionCount);
 arrValueListForInsert.Add(objPaperEN.VersionCount.ToString());
 }
 
 arrFieldListForInsert.Add(conPaper.IsPublic);
 arrValueListForInsert.Add("'" + (objPaperEN.IsPublic  ==  false ? "0" : "1") + "'");
 
 if (objPaperEN.AskQuestion !=  null)
 {
 arrFieldListForInsert.Add(conPaper.AskQuestion);
 var strAskQuestion = objPaperEN.AskQuestion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAskQuestion + "'");
 }
 
 if (objPaperEN.ResearchStatus !=  null)
 {
 arrFieldListForInsert.Add(conPaper.ResearchStatus);
 var strResearchStatus = objPaperEN.ResearchStatus.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResearchStatus + "'");
 }
 
 if (objPaperEN.InnovationPoints !=  null)
 {
 arrFieldListForInsert.Add(conPaper.InnovationPoints);
 var strInnovationPoints = objPaperEN.InnovationPoints.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strInnovationPoints + "'");
 }
 
 if (objPaperEN.ResearchDesign !=  null)
 {
 arrFieldListForInsert.Add(conPaper.ResearchDesign);
 var strResearchDesign = objPaperEN.ResearchDesign.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResearchDesign + "'");
 }
 
 if (objPaperEN.DimensionDataProcess !=  null)
 {
 arrFieldListForInsert.Add(conPaper.DimensionDataProcess);
 var strDimensionDataProcess = objPaperEN.DimensionDataProcess.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDimensionDataProcess + "'");
 }
 
 if (objPaperEN.ExpectedConclusion !=  null)
 {
 arrFieldListForInsert.Add(conPaper.ExpectedConclusion);
 var strExpectedConclusion = objPaperEN.ExpectedConclusion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExpectedConclusion + "'");
 }
 
 if (objPaperEN.ShareId !=  null)
 {
 arrFieldListForInsert.Add(conPaper.ShareId);
 var strShareId = objPaperEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strShareId + "'");
 }
 
 if (objPaperEN.PaperQCount !=  null)
 {
 arrFieldListForInsert.Add(conPaper.PaperQCount);
 arrValueListForInsert.Add(objPaperEN.PaperQCount.ToString());
 }
 
 if (objPaperEN.SubVCount !=  null)
 {
 arrFieldListForInsert.Add(conPaper.SubVCount);
 arrValueListForInsert.Add(objPaperEN.SubVCount.ToString());
 }
 
 if (objPaperEN.TagsCount !=  null)
 {
 arrFieldListForInsert.Add(conPaper.TagsCount);
 arrValueListForInsert.Add(objPaperEN.TagsCount.ToString());
 }
 
 if (objPaperEN.TeaQCount !=  null)
 {
 arrFieldListForInsert.Add(conPaper.TeaQCount);
 arrValueListForInsert.Add(objPaperEN.TeaQCount.ToString());
 }
 
 if (objPaperEN.IdStudyLevel !=  null)
 {
 arrFieldListForInsert.Add(conPaper.IdStudyLevel);
 var strIdStudyLevel = objPaperEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudyLevel + "'");
 }
 
 if (objPaperEN.IdGrade !=  null)
 {
 arrFieldListForInsert.Add(conPaper.IdGrade);
 var strIdGrade = objPaperEN.IdGrade.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdGrade + "'");
 }
 
 if (objPaperEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conPaper.CreateDate);
 var strCreateDate = objPaperEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objPaperEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conPaper.UpdUser);
 var strUpdUser = objPaperEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objPaperEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conPaper.UpdDate);
 var strUpdDate = objPaperEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objPaperEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conPaper.Memo);
 var strMemo = objPaperEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Paper");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewPapers(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperDA.GetSpecSQLObj();
strSQL = "Select * from Paper where PaperId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "Paper");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strPaperId = oRow[conPaper.PaperId].ToString().Trim();
if (IsExist(strPaperId))
{
 string strResult = "关键字变量值为:" + string.Format("PaperId = {0}", strPaperId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsPaperEN._CurrTabName ].NewRow();
objRow[conPaper.PaperId] = oRow[conPaper.PaperId].ToString().Trim(); //论文Id
objRow[conPaper.PaperTitle] = oRow[conPaper.PaperTitle].ToString().Trim(); //论文标题
objRow[conPaper.PaperContent] = oRow[conPaper.PaperContent].ToString().Trim(); //主题内容
objRow[conPaper.Periodical] = oRow[conPaper.Periodical].ToString().Trim(); //期刊
objRow[conPaper.Author] = oRow[conPaper.Author].ToString().Trim(); //作者
objRow[conPaper.ResearchQuestion] = oRow[conPaper.ResearchQuestion].ToString().Trim(); //研究问题
objRow[conPaper.Keyword] = oRow[conPaper.Keyword].ToString().Trim(); //关键字
objRow[conPaper.LiteratureSources] = oRow[conPaper.LiteratureSources].ToString().Trim(); //文献来源
objRow[conPaper.LiteratureLink] = oRow[conPaper.LiteratureLink].ToString().Trim(); //文献链接
objRow[conPaper.UploadfileUrl] = oRow[conPaper.UploadfileUrl].ToString().Trim(); //文件地址
objRow[conPaper.IsQuotethesis] = oRow[conPaper.IsQuotethesis].ToString().Trim(); //是否引用论文
objRow[conPaper.QuoteId] = oRow[conPaper.QuoteId].ToString().Trim(); //引用Id
objRow[conPaper.IsChecked] = oRow[conPaper.IsChecked].ToString().Trim(); //是否检查
objRow[conPaper.Checker] = oRow[conPaper.Checker].ToString().Trim(); //审核人
objRow[conPaper.LiteratureTypeId] = oRow[conPaper.LiteratureTypeId].ToString().Trim(); //文献类型Id
objRow[conPaper.BrowseNumber] = oRow[conPaper.BrowseNumber].ToString().Trim(); //浏览量
objRow[conPaper.IsSubmit] = oRow[conPaper.IsSubmit].ToString().Trim(); //是否提交
objRow[conPaper.AppraiseCount] = oRow[conPaper.AppraiseCount].ToString().Trim(); //评论数
objRow[conPaper.AttachmentCount] = oRow[conPaper.AttachmentCount].ToString().Trim(); //附件计数
objRow[conPaper.CollectionCount] = oRow[conPaper.CollectionCount].ToString().Trim(); //收藏数量
objRow[conPaper.DownloadCount] = oRow[conPaper.DownloadCount].ToString().Trim(); //下载数
objRow[conPaper.OkCount] = oRow[conPaper.OkCount].ToString().Trim(); //点赞统计
objRow[conPaper.Pcount] = oRow[conPaper.Pcount].ToString().Trim(); //读写数
objRow[conPaper.Score] = oRow[conPaper.Score].ToString().Trim(); //评分
objRow[conPaper.StuScore] = oRow[conPaper.StuScore].ToString().Trim(); //学生平均分
objRow[conPaper.TeaScore] = oRow[conPaper.TeaScore].ToString().Trim(); //教师评分
objRow[conPaper.PaperTypeId] = oRow[conPaper.PaperTypeId].ToString().Trim(); //论文类型Id
objRow[conPaper.PaperStatusId] = oRow[conPaper.PaperStatusId].ToString().Trim(); //论文状态Id
objRow[conPaper.VersionCount] = oRow[conPaper.VersionCount].ToString().Trim(); //版本统计
objRow[conPaper.IsPublic] = oRow[conPaper.IsPublic].ToString().Trim(); //是否公开
objRow[conPaper.AskQuestion] = oRow[conPaper.AskQuestion].ToString().Trim(); //问题提出
objRow[conPaper.ResearchStatus] = oRow[conPaper.ResearchStatus].ToString().Trim(); //目前研究的现状
objRow[conPaper.InnovationPoints] = oRow[conPaper.InnovationPoints].ToString().Trim(); //创新点
objRow[conPaper.ResearchDesign] = oRow[conPaper.ResearchDesign].ToString().Trim(); //研究设计
objRow[conPaper.DimensionDataProcess] = oRow[conPaper.DimensionDataProcess].ToString().Trim(); //数据处理的维度
objRow[conPaper.ExpectedConclusion] = oRow[conPaper.ExpectedConclusion].ToString().Trim(); //预期结论
objRow[conPaper.ShareId] = oRow[conPaper.ShareId].ToString().Trim(); //分享Id
objRow[conPaper.PaperQCount] = oRow[conPaper.PaperQCount].ToString().Trim(); //论文答疑数
objRow[conPaper.SubVCount] = oRow[conPaper.SubVCount].ToString().Trim(); //论文子观点数
objRow[conPaper.TagsCount] = oRow[conPaper.TagsCount].ToString().Trim(); //论文标注数
objRow[conPaper.TeaQCount] = oRow[conPaper.TeaQCount].ToString().Trim(); //教师提问数
objRow[conPaper.IdStudyLevel] = oRow[conPaper.IdStudyLevel].ToString().Trim(); //学段流水号
objRow[conPaper.IdGrade] = oRow[conPaper.IdGrade].ToString().Trim(); //年级流水号
objRow[conPaper.CreateDate] = oRow[conPaper.CreateDate].ToString().Trim(); //建立日期
objRow[conPaper.UpdUser] = oRow[conPaper.UpdUser].ToString().Trim(); //修改人
objRow[conPaper.UpdDate] = oRow[conPaper.UpdDate].ToString().Trim(); //修改日期
objRow[conPaper.Memo] = oRow[conPaper.Memo].ToString().Trim(); //备注
 objDS.Tables[clsPaperEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsPaperEN._CurrTabName);
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
 /// <param name = "objPaperEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsPaperEN objPaperEN)
{
 if (objPaperEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPaperEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperDA.GetSpecSQLObj();
strSQL = "Select * from Paper where PaperId = " + "'"+ objPaperEN.PaperId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsPaperEN._CurrTabName);
if (objDS.Tables[clsPaperEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:PaperId = " + "'"+ objPaperEN.PaperId+"'");
return false;
}
objRow = objDS.Tables[clsPaperEN._CurrTabName].Rows[0];
 if (objPaperEN.IsUpdated(conPaper.PaperId))
 {
objRow[conPaper.PaperId] = objPaperEN.PaperId; //论文Id
 }
 if (objPaperEN.IsUpdated(conPaper.PaperTitle))
 {
objRow[conPaper.PaperTitle] = objPaperEN.PaperTitle; //论文标题
 }
 if (objPaperEN.IsUpdated(conPaper.PaperContent))
 {
objRow[conPaper.PaperContent] = objPaperEN.PaperContent; //主题内容
 }
 if (objPaperEN.IsUpdated(conPaper.Periodical))
 {
objRow[conPaper.Periodical] = objPaperEN.Periodical; //期刊
 }
 if (objPaperEN.IsUpdated(conPaper.Author))
 {
objRow[conPaper.Author] = objPaperEN.Author; //作者
 }
 if (objPaperEN.IsUpdated(conPaper.ResearchQuestion))
 {
objRow[conPaper.ResearchQuestion] = objPaperEN.ResearchQuestion; //研究问题
 }
 if (objPaperEN.IsUpdated(conPaper.Keyword))
 {
objRow[conPaper.Keyword] = objPaperEN.Keyword; //关键字
 }
 if (objPaperEN.IsUpdated(conPaper.LiteratureSources))
 {
objRow[conPaper.LiteratureSources] = objPaperEN.LiteratureSources; //文献来源
 }
 if (objPaperEN.IsUpdated(conPaper.LiteratureLink))
 {
objRow[conPaper.LiteratureLink] = objPaperEN.LiteratureLink; //文献链接
 }
 if (objPaperEN.IsUpdated(conPaper.UploadfileUrl))
 {
objRow[conPaper.UploadfileUrl] = objPaperEN.UploadfileUrl; //文件地址
 }
 if (objPaperEN.IsUpdated(conPaper.IsQuotethesis))
 {
objRow[conPaper.IsQuotethesis] = objPaperEN.IsQuotethesis; //是否引用论文
 }
 if (objPaperEN.IsUpdated(conPaper.QuoteId))
 {
objRow[conPaper.QuoteId] = objPaperEN.QuoteId; //引用Id
 }
 if (objPaperEN.IsUpdated(conPaper.IsChecked))
 {
objRow[conPaper.IsChecked] = objPaperEN.IsChecked; //是否检查
 }
 if (objPaperEN.IsUpdated(conPaper.Checker))
 {
objRow[conPaper.Checker] = objPaperEN.Checker; //审核人
 }
 if (objPaperEN.IsUpdated(conPaper.LiteratureTypeId))
 {
objRow[conPaper.LiteratureTypeId] = objPaperEN.LiteratureTypeId; //文献类型Id
 }
 if (objPaperEN.IsUpdated(conPaper.BrowseNumber))
 {
objRow[conPaper.BrowseNumber] = objPaperEN.BrowseNumber; //浏览量
 }
 if (objPaperEN.IsUpdated(conPaper.IsSubmit))
 {
objRow[conPaper.IsSubmit] = objPaperEN.IsSubmit; //是否提交
 }
 if (objPaperEN.IsUpdated(conPaper.AppraiseCount))
 {
objRow[conPaper.AppraiseCount] = objPaperEN.AppraiseCount; //评论数
 }
 if (objPaperEN.IsUpdated(conPaper.AttachmentCount))
 {
objRow[conPaper.AttachmentCount] = objPaperEN.AttachmentCount; //附件计数
 }
 if (objPaperEN.IsUpdated(conPaper.CollectionCount))
 {
objRow[conPaper.CollectionCount] = objPaperEN.CollectionCount; //收藏数量
 }
 if (objPaperEN.IsUpdated(conPaper.DownloadCount))
 {
objRow[conPaper.DownloadCount] = objPaperEN.DownloadCount; //下载数
 }
 if (objPaperEN.IsUpdated(conPaper.OkCount))
 {
objRow[conPaper.OkCount] = objPaperEN.OkCount; //点赞统计
 }
 if (objPaperEN.IsUpdated(conPaper.Pcount))
 {
objRow[conPaper.Pcount] = objPaperEN.Pcount; //读写数
 }
 if (objPaperEN.IsUpdated(conPaper.Score))
 {
objRow[conPaper.Score] = objPaperEN.Score; //评分
 }
 if (objPaperEN.IsUpdated(conPaper.StuScore))
 {
objRow[conPaper.StuScore] = objPaperEN.StuScore; //学生平均分
 }
 if (objPaperEN.IsUpdated(conPaper.TeaScore))
 {
objRow[conPaper.TeaScore] = objPaperEN.TeaScore; //教师评分
 }
 if (objPaperEN.IsUpdated(conPaper.PaperTypeId))
 {
objRow[conPaper.PaperTypeId] = objPaperEN.PaperTypeId; //论文类型Id
 }
 if (objPaperEN.IsUpdated(conPaper.PaperStatusId))
 {
objRow[conPaper.PaperStatusId] = objPaperEN.PaperStatusId; //论文状态Id
 }
 if (objPaperEN.IsUpdated(conPaper.VersionCount))
 {
objRow[conPaper.VersionCount] = objPaperEN.VersionCount; //版本统计
 }
 if (objPaperEN.IsUpdated(conPaper.IsPublic))
 {
objRow[conPaper.IsPublic] = objPaperEN.IsPublic; //是否公开
 }
 if (objPaperEN.IsUpdated(conPaper.AskQuestion))
 {
objRow[conPaper.AskQuestion] = objPaperEN.AskQuestion; //问题提出
 }
 if (objPaperEN.IsUpdated(conPaper.ResearchStatus))
 {
objRow[conPaper.ResearchStatus] = objPaperEN.ResearchStatus; //目前研究的现状
 }
 if (objPaperEN.IsUpdated(conPaper.InnovationPoints))
 {
objRow[conPaper.InnovationPoints] = objPaperEN.InnovationPoints; //创新点
 }
 if (objPaperEN.IsUpdated(conPaper.ResearchDesign))
 {
objRow[conPaper.ResearchDesign] = objPaperEN.ResearchDesign; //研究设计
 }
 if (objPaperEN.IsUpdated(conPaper.DimensionDataProcess))
 {
objRow[conPaper.DimensionDataProcess] = objPaperEN.DimensionDataProcess; //数据处理的维度
 }
 if (objPaperEN.IsUpdated(conPaper.ExpectedConclusion))
 {
objRow[conPaper.ExpectedConclusion] = objPaperEN.ExpectedConclusion; //预期结论
 }
 if (objPaperEN.IsUpdated(conPaper.ShareId))
 {
objRow[conPaper.ShareId] = objPaperEN.ShareId; //分享Id
 }
 if (objPaperEN.IsUpdated(conPaper.PaperQCount))
 {
objRow[conPaper.PaperQCount] = objPaperEN.PaperQCount; //论文答疑数
 }
 if (objPaperEN.IsUpdated(conPaper.SubVCount))
 {
objRow[conPaper.SubVCount] = objPaperEN.SubVCount; //论文子观点数
 }
 if (objPaperEN.IsUpdated(conPaper.TagsCount))
 {
objRow[conPaper.TagsCount] = objPaperEN.TagsCount; //论文标注数
 }
 if (objPaperEN.IsUpdated(conPaper.TeaQCount))
 {
objRow[conPaper.TeaQCount] = objPaperEN.TeaQCount; //教师提问数
 }
 if (objPaperEN.IsUpdated(conPaper.IdStudyLevel))
 {
objRow[conPaper.IdStudyLevel] = objPaperEN.IdStudyLevel; //学段流水号
 }
 if (objPaperEN.IsUpdated(conPaper.IdGrade))
 {
objRow[conPaper.IdGrade] = objPaperEN.IdGrade; //年级流水号
 }
 if (objPaperEN.IsUpdated(conPaper.CreateDate))
 {
objRow[conPaper.CreateDate] = objPaperEN.CreateDate; //建立日期
 }
 if (objPaperEN.IsUpdated(conPaper.UpdUser))
 {
objRow[conPaper.UpdUser] = objPaperEN.UpdUser; //修改人
 }
 if (objPaperEN.IsUpdated(conPaper.UpdDate))
 {
objRow[conPaper.UpdDate] = objPaperEN.UpdDate; //修改日期
 }
 if (objPaperEN.IsUpdated(conPaper.Memo))
 {
objRow[conPaper.Memo] = objPaperEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsPaperEN._CurrTabName);
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
 /// <param name = "objPaperEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsPaperEN objPaperEN)
{
 if (objPaperEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPaperEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update Paper Set ");
 
 if (objPaperEN.IsUpdated(conPaper.PaperTitle))
 {
 if (objPaperEN.PaperTitle !=  null)
 {
 var strPaperTitle = objPaperEN.PaperTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPaperTitle, conPaper.PaperTitle); //论文标题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.PaperTitle); //论文标题
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.PaperContent))
 {
 if (objPaperEN.PaperContent !=  null)
 {
 var strPaperContent = objPaperEN.PaperContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPaperContent, conPaper.PaperContent); //主题内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.PaperContent); //主题内容
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.Periodical))
 {
 if (objPaperEN.Periodical !=  null)
 {
 var strPeriodical = objPaperEN.Periodical.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPeriodical, conPaper.Periodical); //期刊
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.Periodical); //期刊
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.Author))
 {
 if (objPaperEN.Author !=  null)
 {
 var strAuthor = objPaperEN.Author.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAuthor, conPaper.Author); //作者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.Author); //作者
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.ResearchQuestion))
 {
 if (objPaperEN.ResearchQuestion !=  null)
 {
 var strResearchQuestion = objPaperEN.ResearchQuestion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResearchQuestion, conPaper.ResearchQuestion); //研究问题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.ResearchQuestion); //研究问题
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.Keyword))
 {
 if (objPaperEN.Keyword !=  null)
 {
 var strKeyword = objPaperEN.Keyword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strKeyword, conPaper.Keyword); //关键字
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.Keyword); //关键字
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.LiteratureSources))
 {
 if (objPaperEN.LiteratureSources !=  null)
 {
 var strLiteratureSources = objPaperEN.LiteratureSources.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLiteratureSources, conPaper.LiteratureSources); //文献来源
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.LiteratureSources); //文献来源
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.LiteratureLink))
 {
 if (objPaperEN.LiteratureLink !=  null)
 {
 var strLiteratureLink = objPaperEN.LiteratureLink.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLiteratureLink, conPaper.LiteratureLink); //文献链接
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.LiteratureLink); //文献链接
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.UploadfileUrl))
 {
 if (objPaperEN.UploadfileUrl !=  null)
 {
 var strUploadfileUrl = objPaperEN.UploadfileUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUploadfileUrl, conPaper.UploadfileUrl); //文件地址
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.UploadfileUrl); //文件地址
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.IsQuotethesis))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPaperEN.IsQuotethesis == true?"1":"0", conPaper.IsQuotethesis); //是否引用论文
 }
 
 if (objPaperEN.IsUpdated(conPaper.QuoteId))
 {
 if (objPaperEN.QuoteId !=  null)
 {
 var strQuoteId = objPaperEN.QuoteId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuoteId, conPaper.QuoteId); //引用Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.QuoteId); //引用Id
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.IsChecked))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPaperEN.IsChecked == true?"1":"0", conPaper.IsChecked); //是否检查
 }
 
 if (objPaperEN.IsUpdated(conPaper.Checker))
 {
 if (objPaperEN.Checker !=  null)
 {
 var strChecker = objPaperEN.Checker.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strChecker, conPaper.Checker); //审核人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.Checker); //审核人
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.LiteratureTypeId))
 {
 if (objPaperEN.LiteratureTypeId !=  null)
 {
 var strLiteratureTypeId = objPaperEN.LiteratureTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLiteratureTypeId, conPaper.LiteratureTypeId); //文献类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.LiteratureTypeId); //文献类型Id
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.BrowseNumber))
 {
 if (objPaperEN.BrowseNumber !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperEN.BrowseNumber, conPaper.BrowseNumber); //浏览量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.BrowseNumber); //浏览量
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPaperEN.IsSubmit == true?"1":"0", conPaper.IsSubmit); //是否提交
 }
 
 if (objPaperEN.IsUpdated(conPaper.AppraiseCount))
 {
 if (objPaperEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperEN.AppraiseCount, conPaper.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.AppraiseCount); //评论数
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.AttachmentCount))
 {
 if (objPaperEN.AttachmentCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperEN.AttachmentCount, conPaper.AttachmentCount); //附件计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.AttachmentCount); //附件计数
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.CollectionCount))
 {
 if (objPaperEN.CollectionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperEN.CollectionCount, conPaper.CollectionCount); //收藏数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.CollectionCount); //收藏数量
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.DownloadCount))
 {
 if (objPaperEN.DownloadCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperEN.DownloadCount, conPaper.DownloadCount); //下载数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.DownloadCount); //下载数
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.OkCount))
 {
 if (objPaperEN.OkCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperEN.OkCount, conPaper.OkCount); //点赞统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.OkCount); //点赞统计
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.Pcount))
 {
 if (objPaperEN.Pcount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperEN.Pcount, conPaper.Pcount); //读写数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.Pcount); //读写数
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.Score))
 {
 if (objPaperEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperEN.Score, conPaper.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.Score); //评分
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.StuScore))
 {
 if (objPaperEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperEN.StuScore, conPaper.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.StuScore); //学生平均分
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.TeaScore))
 {
 if (objPaperEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperEN.TeaScore, conPaper.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.TeaScore); //教师评分
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.PaperTypeId))
 {
 if (objPaperEN.PaperTypeId !=  null)
 {
 var strPaperTypeId = objPaperEN.PaperTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPaperTypeId, conPaper.PaperTypeId); //论文类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.PaperTypeId); //论文类型Id
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.PaperStatusId))
 {
 if (objPaperEN.PaperStatusId !=  null)
 {
 var strPaperStatusId = objPaperEN.PaperStatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPaperStatusId, conPaper.PaperStatusId); //论文状态Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.PaperStatusId); //论文状态Id
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.VersionCount))
 {
 if (objPaperEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperEN.VersionCount, conPaper.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.VersionCount); //版本统计
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.IsPublic))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPaperEN.IsPublic == true?"1":"0", conPaper.IsPublic); //是否公开
 }
 
 if (objPaperEN.IsUpdated(conPaper.AskQuestion))
 {
 if (objPaperEN.AskQuestion !=  null)
 {
 var strAskQuestion = objPaperEN.AskQuestion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAskQuestion, conPaper.AskQuestion); //问题提出
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.AskQuestion); //问题提出
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.ResearchStatus))
 {
 if (objPaperEN.ResearchStatus !=  null)
 {
 var strResearchStatus = objPaperEN.ResearchStatus.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResearchStatus, conPaper.ResearchStatus); //目前研究的现状
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.ResearchStatus); //目前研究的现状
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.InnovationPoints))
 {
 if (objPaperEN.InnovationPoints !=  null)
 {
 var strInnovationPoints = objPaperEN.InnovationPoints.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strInnovationPoints, conPaper.InnovationPoints); //创新点
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.InnovationPoints); //创新点
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.ResearchDesign))
 {
 if (objPaperEN.ResearchDesign !=  null)
 {
 var strResearchDesign = objPaperEN.ResearchDesign.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResearchDesign, conPaper.ResearchDesign); //研究设计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.ResearchDesign); //研究设计
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.DimensionDataProcess))
 {
 if (objPaperEN.DimensionDataProcess !=  null)
 {
 var strDimensionDataProcess = objPaperEN.DimensionDataProcess.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDimensionDataProcess, conPaper.DimensionDataProcess); //数据处理的维度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.DimensionDataProcess); //数据处理的维度
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.ExpectedConclusion))
 {
 if (objPaperEN.ExpectedConclusion !=  null)
 {
 var strExpectedConclusion = objPaperEN.ExpectedConclusion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExpectedConclusion, conPaper.ExpectedConclusion); //预期结论
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.ExpectedConclusion); //预期结论
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.ShareId))
 {
 if (objPaperEN.ShareId !=  null)
 {
 var strShareId = objPaperEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strShareId, conPaper.ShareId); //分享Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.ShareId); //分享Id
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.PaperQCount))
 {
 if (objPaperEN.PaperQCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperEN.PaperQCount, conPaper.PaperQCount); //论文答疑数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.PaperQCount); //论文答疑数
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.SubVCount))
 {
 if (objPaperEN.SubVCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperEN.SubVCount, conPaper.SubVCount); //论文子观点数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.SubVCount); //论文子观点数
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.TagsCount))
 {
 if (objPaperEN.TagsCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperEN.TagsCount, conPaper.TagsCount); //论文标注数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.TagsCount); //论文标注数
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.TeaQCount))
 {
 if (objPaperEN.TeaQCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperEN.TeaQCount, conPaper.TeaQCount); //教师提问数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.TeaQCount); //教师提问数
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.IdStudyLevel))
 {
 if (objPaperEN.IdStudyLevel !=  null)
 {
 var strIdStudyLevel = objPaperEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdStudyLevel, conPaper.IdStudyLevel); //学段流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.IdStudyLevel); //学段流水号
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.IdGrade))
 {
 if (objPaperEN.IdGrade !=  null)
 {
 var strIdGrade = objPaperEN.IdGrade.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdGrade, conPaper.IdGrade); //年级流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.IdGrade); //年级流水号
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.CreateDate))
 {
 if (objPaperEN.CreateDate !=  null)
 {
 var strCreateDate = objPaperEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateDate, conPaper.CreateDate); //建立日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.CreateDate); //建立日期
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.UpdUser))
 {
 if (objPaperEN.UpdUser !=  null)
 {
 var strUpdUser = objPaperEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conPaper.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.UpdUser); //修改人
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.UpdDate))
 {
 if (objPaperEN.UpdDate !=  null)
 {
 var strUpdDate = objPaperEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conPaper.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.UpdDate); //修改日期
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.Memo))
 {
 if (objPaperEN.Memo !=  null)
 {
 var strMemo = objPaperEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conPaper.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where PaperId = '{0}'", objPaperEN.PaperId); 
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
 /// <param name = "objPaperEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsPaperEN objPaperEN, string strCondition)
{
 if (objPaperEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPaperEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update Paper Set ");
 
 if (objPaperEN.IsUpdated(conPaper.PaperTitle))
 {
 if (objPaperEN.PaperTitle !=  null)
 {
 var strPaperTitle = objPaperEN.PaperTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PaperTitle = '{0}',", strPaperTitle); //论文标题
 }
 else
 {
 sbSQL.Append(" PaperTitle = null,"); //论文标题
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.PaperContent))
 {
 if (objPaperEN.PaperContent !=  null)
 {
 var strPaperContent = objPaperEN.PaperContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PaperContent = '{0}',", strPaperContent); //主题内容
 }
 else
 {
 sbSQL.Append(" PaperContent = null,"); //主题内容
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.Periodical))
 {
 if (objPaperEN.Periodical !=  null)
 {
 var strPeriodical = objPaperEN.Periodical.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Periodical = '{0}',", strPeriodical); //期刊
 }
 else
 {
 sbSQL.Append(" Periodical = null,"); //期刊
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.Author))
 {
 if (objPaperEN.Author !=  null)
 {
 var strAuthor = objPaperEN.Author.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Author = '{0}',", strAuthor); //作者
 }
 else
 {
 sbSQL.Append(" Author = null,"); //作者
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.ResearchQuestion))
 {
 if (objPaperEN.ResearchQuestion !=  null)
 {
 var strResearchQuestion = objPaperEN.ResearchQuestion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResearchQuestion = '{0}',", strResearchQuestion); //研究问题
 }
 else
 {
 sbSQL.Append(" ResearchQuestion = null,"); //研究问题
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.Keyword))
 {
 if (objPaperEN.Keyword !=  null)
 {
 var strKeyword = objPaperEN.Keyword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Keyword = '{0}',", strKeyword); //关键字
 }
 else
 {
 sbSQL.Append(" Keyword = null,"); //关键字
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.LiteratureSources))
 {
 if (objPaperEN.LiteratureSources !=  null)
 {
 var strLiteratureSources = objPaperEN.LiteratureSources.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LiteratureSources = '{0}',", strLiteratureSources); //文献来源
 }
 else
 {
 sbSQL.Append(" LiteratureSources = null,"); //文献来源
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.LiteratureLink))
 {
 if (objPaperEN.LiteratureLink !=  null)
 {
 var strLiteratureLink = objPaperEN.LiteratureLink.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LiteratureLink = '{0}',", strLiteratureLink); //文献链接
 }
 else
 {
 sbSQL.Append(" LiteratureLink = null,"); //文献链接
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.UploadfileUrl))
 {
 if (objPaperEN.UploadfileUrl !=  null)
 {
 var strUploadfileUrl = objPaperEN.UploadfileUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UploadfileUrl = '{0}',", strUploadfileUrl); //文件地址
 }
 else
 {
 sbSQL.Append(" UploadfileUrl = null,"); //文件地址
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.IsQuotethesis))
 {
 sbSQL.AppendFormat(" IsQuotethesis = '{0}',", objPaperEN.IsQuotethesis == true?"1":"0"); //是否引用论文
 }
 
 if (objPaperEN.IsUpdated(conPaper.QuoteId))
 {
 if (objPaperEN.QuoteId !=  null)
 {
 var strQuoteId = objPaperEN.QuoteId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuoteId = '{0}',", strQuoteId); //引用Id
 }
 else
 {
 sbSQL.Append(" QuoteId = null,"); //引用Id
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.IsChecked))
 {
 sbSQL.AppendFormat(" IsChecked = '{0}',", objPaperEN.IsChecked == true?"1":"0"); //是否检查
 }
 
 if (objPaperEN.IsUpdated(conPaper.Checker))
 {
 if (objPaperEN.Checker !=  null)
 {
 var strChecker = objPaperEN.Checker.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Checker = '{0}',", strChecker); //审核人
 }
 else
 {
 sbSQL.Append(" Checker = null,"); //审核人
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.LiteratureTypeId))
 {
 if (objPaperEN.LiteratureTypeId !=  null)
 {
 var strLiteratureTypeId = objPaperEN.LiteratureTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LiteratureTypeId = '{0}',", strLiteratureTypeId); //文献类型Id
 }
 else
 {
 sbSQL.Append(" LiteratureTypeId = null,"); //文献类型Id
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.BrowseNumber))
 {
 if (objPaperEN.BrowseNumber !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperEN.BrowseNumber, conPaper.BrowseNumber); //浏览量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.BrowseNumber); //浏览量
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objPaperEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objPaperEN.IsUpdated(conPaper.AppraiseCount))
 {
 if (objPaperEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperEN.AppraiseCount, conPaper.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.AppraiseCount); //评论数
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.AttachmentCount))
 {
 if (objPaperEN.AttachmentCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperEN.AttachmentCount, conPaper.AttachmentCount); //附件计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.AttachmentCount); //附件计数
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.CollectionCount))
 {
 if (objPaperEN.CollectionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperEN.CollectionCount, conPaper.CollectionCount); //收藏数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.CollectionCount); //收藏数量
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.DownloadCount))
 {
 if (objPaperEN.DownloadCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperEN.DownloadCount, conPaper.DownloadCount); //下载数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.DownloadCount); //下载数
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.OkCount))
 {
 if (objPaperEN.OkCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperEN.OkCount, conPaper.OkCount); //点赞统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.OkCount); //点赞统计
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.Pcount))
 {
 if (objPaperEN.Pcount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperEN.Pcount, conPaper.Pcount); //读写数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.Pcount); //读写数
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.Score))
 {
 if (objPaperEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperEN.Score, conPaper.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.Score); //评分
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.StuScore))
 {
 if (objPaperEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperEN.StuScore, conPaper.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.StuScore); //学生平均分
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.TeaScore))
 {
 if (objPaperEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperEN.TeaScore, conPaper.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.TeaScore); //教师评分
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.PaperTypeId))
 {
 if (objPaperEN.PaperTypeId !=  null)
 {
 var strPaperTypeId = objPaperEN.PaperTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PaperTypeId = '{0}',", strPaperTypeId); //论文类型Id
 }
 else
 {
 sbSQL.Append(" PaperTypeId = null,"); //论文类型Id
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.PaperStatusId))
 {
 if (objPaperEN.PaperStatusId !=  null)
 {
 var strPaperStatusId = objPaperEN.PaperStatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PaperStatusId = '{0}',", strPaperStatusId); //论文状态Id
 }
 else
 {
 sbSQL.Append(" PaperStatusId = null,"); //论文状态Id
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.VersionCount))
 {
 if (objPaperEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperEN.VersionCount, conPaper.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.VersionCount); //版本统计
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.IsPublic))
 {
 sbSQL.AppendFormat(" IsPublic = '{0}',", objPaperEN.IsPublic == true?"1":"0"); //是否公开
 }
 
 if (objPaperEN.IsUpdated(conPaper.AskQuestion))
 {
 if (objPaperEN.AskQuestion !=  null)
 {
 var strAskQuestion = objPaperEN.AskQuestion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AskQuestion = '{0}',", strAskQuestion); //问题提出
 }
 else
 {
 sbSQL.Append(" AskQuestion = null,"); //问题提出
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.ResearchStatus))
 {
 if (objPaperEN.ResearchStatus !=  null)
 {
 var strResearchStatus = objPaperEN.ResearchStatus.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResearchStatus = '{0}',", strResearchStatus); //目前研究的现状
 }
 else
 {
 sbSQL.Append(" ResearchStatus = null,"); //目前研究的现状
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.InnovationPoints))
 {
 if (objPaperEN.InnovationPoints !=  null)
 {
 var strInnovationPoints = objPaperEN.InnovationPoints.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" InnovationPoints = '{0}',", strInnovationPoints); //创新点
 }
 else
 {
 sbSQL.Append(" InnovationPoints = null,"); //创新点
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.ResearchDesign))
 {
 if (objPaperEN.ResearchDesign !=  null)
 {
 var strResearchDesign = objPaperEN.ResearchDesign.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResearchDesign = '{0}',", strResearchDesign); //研究设计
 }
 else
 {
 sbSQL.Append(" ResearchDesign = null,"); //研究设计
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.DimensionDataProcess))
 {
 if (objPaperEN.DimensionDataProcess !=  null)
 {
 var strDimensionDataProcess = objPaperEN.DimensionDataProcess.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DimensionDataProcess = '{0}',", strDimensionDataProcess); //数据处理的维度
 }
 else
 {
 sbSQL.Append(" DimensionDataProcess = null,"); //数据处理的维度
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.ExpectedConclusion))
 {
 if (objPaperEN.ExpectedConclusion !=  null)
 {
 var strExpectedConclusion = objPaperEN.ExpectedConclusion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ExpectedConclusion = '{0}',", strExpectedConclusion); //预期结论
 }
 else
 {
 sbSQL.Append(" ExpectedConclusion = null,"); //预期结论
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.ShareId))
 {
 if (objPaperEN.ShareId !=  null)
 {
 var strShareId = objPaperEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ShareId = '{0}',", strShareId); //分享Id
 }
 else
 {
 sbSQL.Append(" ShareId = null,"); //分享Id
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.PaperQCount))
 {
 if (objPaperEN.PaperQCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperEN.PaperQCount, conPaper.PaperQCount); //论文答疑数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.PaperQCount); //论文答疑数
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.SubVCount))
 {
 if (objPaperEN.SubVCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperEN.SubVCount, conPaper.SubVCount); //论文子观点数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.SubVCount); //论文子观点数
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.TagsCount))
 {
 if (objPaperEN.TagsCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperEN.TagsCount, conPaper.TagsCount); //论文标注数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.TagsCount); //论文标注数
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.TeaQCount))
 {
 if (objPaperEN.TeaQCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperEN.TeaQCount, conPaper.TeaQCount); //教师提问数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.TeaQCount); //教师提问数
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.IdStudyLevel))
 {
 if (objPaperEN.IdStudyLevel !=  null)
 {
 var strIdStudyLevel = objPaperEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdStudyLevel = '{0}',", strIdStudyLevel); //学段流水号
 }
 else
 {
 sbSQL.Append(" IdStudyLevel = null,"); //学段流水号
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.IdGrade))
 {
 if (objPaperEN.IdGrade !=  null)
 {
 var strIdGrade = objPaperEN.IdGrade.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdGrade = '{0}',", strIdGrade); //年级流水号
 }
 else
 {
 sbSQL.Append(" IdGrade = null,"); //年级流水号
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.CreateDate))
 {
 if (objPaperEN.CreateDate !=  null)
 {
 var strCreateDate = objPaperEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateDate = '{0}',", strCreateDate); //建立日期
 }
 else
 {
 sbSQL.Append(" CreateDate = null,"); //建立日期
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.UpdUser))
 {
 if (objPaperEN.UpdUser !=  null)
 {
 var strUpdUser = objPaperEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.UpdDate))
 {
 if (objPaperEN.UpdDate !=  null)
 {
 var strUpdDate = objPaperEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.Memo))
 {
 if (objPaperEN.Memo !=  null)
 {
 var strMemo = objPaperEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objPaperEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsPaperEN objPaperEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objPaperEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPaperEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update Paper Set ");
 
 if (objPaperEN.IsUpdated(conPaper.PaperTitle))
 {
 if (objPaperEN.PaperTitle !=  null)
 {
 var strPaperTitle = objPaperEN.PaperTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PaperTitle = '{0}',", strPaperTitle); //论文标题
 }
 else
 {
 sbSQL.Append(" PaperTitle = null,"); //论文标题
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.PaperContent))
 {
 if (objPaperEN.PaperContent !=  null)
 {
 var strPaperContent = objPaperEN.PaperContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PaperContent = '{0}',", strPaperContent); //主题内容
 }
 else
 {
 sbSQL.Append(" PaperContent = null,"); //主题内容
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.Periodical))
 {
 if (objPaperEN.Periodical !=  null)
 {
 var strPeriodical = objPaperEN.Periodical.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Periodical = '{0}',", strPeriodical); //期刊
 }
 else
 {
 sbSQL.Append(" Periodical = null,"); //期刊
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.Author))
 {
 if (objPaperEN.Author !=  null)
 {
 var strAuthor = objPaperEN.Author.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Author = '{0}',", strAuthor); //作者
 }
 else
 {
 sbSQL.Append(" Author = null,"); //作者
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.ResearchQuestion))
 {
 if (objPaperEN.ResearchQuestion !=  null)
 {
 var strResearchQuestion = objPaperEN.ResearchQuestion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResearchQuestion = '{0}',", strResearchQuestion); //研究问题
 }
 else
 {
 sbSQL.Append(" ResearchQuestion = null,"); //研究问题
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.Keyword))
 {
 if (objPaperEN.Keyword !=  null)
 {
 var strKeyword = objPaperEN.Keyword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Keyword = '{0}',", strKeyword); //关键字
 }
 else
 {
 sbSQL.Append(" Keyword = null,"); //关键字
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.LiteratureSources))
 {
 if (objPaperEN.LiteratureSources !=  null)
 {
 var strLiteratureSources = objPaperEN.LiteratureSources.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LiteratureSources = '{0}',", strLiteratureSources); //文献来源
 }
 else
 {
 sbSQL.Append(" LiteratureSources = null,"); //文献来源
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.LiteratureLink))
 {
 if (objPaperEN.LiteratureLink !=  null)
 {
 var strLiteratureLink = objPaperEN.LiteratureLink.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LiteratureLink = '{0}',", strLiteratureLink); //文献链接
 }
 else
 {
 sbSQL.Append(" LiteratureLink = null,"); //文献链接
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.UploadfileUrl))
 {
 if (objPaperEN.UploadfileUrl !=  null)
 {
 var strUploadfileUrl = objPaperEN.UploadfileUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UploadfileUrl = '{0}',", strUploadfileUrl); //文件地址
 }
 else
 {
 sbSQL.Append(" UploadfileUrl = null,"); //文件地址
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.IsQuotethesis))
 {
 sbSQL.AppendFormat(" IsQuotethesis = '{0}',", objPaperEN.IsQuotethesis == true?"1":"0"); //是否引用论文
 }
 
 if (objPaperEN.IsUpdated(conPaper.QuoteId))
 {
 if (objPaperEN.QuoteId !=  null)
 {
 var strQuoteId = objPaperEN.QuoteId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuoteId = '{0}',", strQuoteId); //引用Id
 }
 else
 {
 sbSQL.Append(" QuoteId = null,"); //引用Id
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.IsChecked))
 {
 sbSQL.AppendFormat(" IsChecked = '{0}',", objPaperEN.IsChecked == true?"1":"0"); //是否检查
 }
 
 if (objPaperEN.IsUpdated(conPaper.Checker))
 {
 if (objPaperEN.Checker !=  null)
 {
 var strChecker = objPaperEN.Checker.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Checker = '{0}',", strChecker); //审核人
 }
 else
 {
 sbSQL.Append(" Checker = null,"); //审核人
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.LiteratureTypeId))
 {
 if (objPaperEN.LiteratureTypeId !=  null)
 {
 var strLiteratureTypeId = objPaperEN.LiteratureTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LiteratureTypeId = '{0}',", strLiteratureTypeId); //文献类型Id
 }
 else
 {
 sbSQL.Append(" LiteratureTypeId = null,"); //文献类型Id
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.BrowseNumber))
 {
 if (objPaperEN.BrowseNumber !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperEN.BrowseNumber, conPaper.BrowseNumber); //浏览量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.BrowseNumber); //浏览量
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objPaperEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objPaperEN.IsUpdated(conPaper.AppraiseCount))
 {
 if (objPaperEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperEN.AppraiseCount, conPaper.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.AppraiseCount); //评论数
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.AttachmentCount))
 {
 if (objPaperEN.AttachmentCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperEN.AttachmentCount, conPaper.AttachmentCount); //附件计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.AttachmentCount); //附件计数
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.CollectionCount))
 {
 if (objPaperEN.CollectionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperEN.CollectionCount, conPaper.CollectionCount); //收藏数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.CollectionCount); //收藏数量
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.DownloadCount))
 {
 if (objPaperEN.DownloadCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperEN.DownloadCount, conPaper.DownloadCount); //下载数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.DownloadCount); //下载数
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.OkCount))
 {
 if (objPaperEN.OkCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperEN.OkCount, conPaper.OkCount); //点赞统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.OkCount); //点赞统计
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.Pcount))
 {
 if (objPaperEN.Pcount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperEN.Pcount, conPaper.Pcount); //读写数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.Pcount); //读写数
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.Score))
 {
 if (objPaperEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperEN.Score, conPaper.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.Score); //评分
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.StuScore))
 {
 if (objPaperEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperEN.StuScore, conPaper.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.StuScore); //学生平均分
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.TeaScore))
 {
 if (objPaperEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperEN.TeaScore, conPaper.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.TeaScore); //教师评分
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.PaperTypeId))
 {
 if (objPaperEN.PaperTypeId !=  null)
 {
 var strPaperTypeId = objPaperEN.PaperTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PaperTypeId = '{0}',", strPaperTypeId); //论文类型Id
 }
 else
 {
 sbSQL.Append(" PaperTypeId = null,"); //论文类型Id
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.PaperStatusId))
 {
 if (objPaperEN.PaperStatusId !=  null)
 {
 var strPaperStatusId = objPaperEN.PaperStatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PaperStatusId = '{0}',", strPaperStatusId); //论文状态Id
 }
 else
 {
 sbSQL.Append(" PaperStatusId = null,"); //论文状态Id
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.VersionCount))
 {
 if (objPaperEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperEN.VersionCount, conPaper.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.VersionCount); //版本统计
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.IsPublic))
 {
 sbSQL.AppendFormat(" IsPublic = '{0}',", objPaperEN.IsPublic == true?"1":"0"); //是否公开
 }
 
 if (objPaperEN.IsUpdated(conPaper.AskQuestion))
 {
 if (objPaperEN.AskQuestion !=  null)
 {
 var strAskQuestion = objPaperEN.AskQuestion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AskQuestion = '{0}',", strAskQuestion); //问题提出
 }
 else
 {
 sbSQL.Append(" AskQuestion = null,"); //问题提出
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.ResearchStatus))
 {
 if (objPaperEN.ResearchStatus !=  null)
 {
 var strResearchStatus = objPaperEN.ResearchStatus.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResearchStatus = '{0}',", strResearchStatus); //目前研究的现状
 }
 else
 {
 sbSQL.Append(" ResearchStatus = null,"); //目前研究的现状
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.InnovationPoints))
 {
 if (objPaperEN.InnovationPoints !=  null)
 {
 var strInnovationPoints = objPaperEN.InnovationPoints.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" InnovationPoints = '{0}',", strInnovationPoints); //创新点
 }
 else
 {
 sbSQL.Append(" InnovationPoints = null,"); //创新点
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.ResearchDesign))
 {
 if (objPaperEN.ResearchDesign !=  null)
 {
 var strResearchDesign = objPaperEN.ResearchDesign.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResearchDesign = '{0}',", strResearchDesign); //研究设计
 }
 else
 {
 sbSQL.Append(" ResearchDesign = null,"); //研究设计
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.DimensionDataProcess))
 {
 if (objPaperEN.DimensionDataProcess !=  null)
 {
 var strDimensionDataProcess = objPaperEN.DimensionDataProcess.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DimensionDataProcess = '{0}',", strDimensionDataProcess); //数据处理的维度
 }
 else
 {
 sbSQL.Append(" DimensionDataProcess = null,"); //数据处理的维度
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.ExpectedConclusion))
 {
 if (objPaperEN.ExpectedConclusion !=  null)
 {
 var strExpectedConclusion = objPaperEN.ExpectedConclusion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ExpectedConclusion = '{0}',", strExpectedConclusion); //预期结论
 }
 else
 {
 sbSQL.Append(" ExpectedConclusion = null,"); //预期结论
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.ShareId))
 {
 if (objPaperEN.ShareId !=  null)
 {
 var strShareId = objPaperEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ShareId = '{0}',", strShareId); //分享Id
 }
 else
 {
 sbSQL.Append(" ShareId = null,"); //分享Id
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.PaperQCount))
 {
 if (objPaperEN.PaperQCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperEN.PaperQCount, conPaper.PaperQCount); //论文答疑数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.PaperQCount); //论文答疑数
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.SubVCount))
 {
 if (objPaperEN.SubVCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperEN.SubVCount, conPaper.SubVCount); //论文子观点数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.SubVCount); //论文子观点数
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.TagsCount))
 {
 if (objPaperEN.TagsCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperEN.TagsCount, conPaper.TagsCount); //论文标注数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.TagsCount); //论文标注数
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.TeaQCount))
 {
 if (objPaperEN.TeaQCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperEN.TeaQCount, conPaper.TeaQCount); //教师提问数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.TeaQCount); //教师提问数
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.IdStudyLevel))
 {
 if (objPaperEN.IdStudyLevel !=  null)
 {
 var strIdStudyLevel = objPaperEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdStudyLevel = '{0}',", strIdStudyLevel); //学段流水号
 }
 else
 {
 sbSQL.Append(" IdStudyLevel = null,"); //学段流水号
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.IdGrade))
 {
 if (objPaperEN.IdGrade !=  null)
 {
 var strIdGrade = objPaperEN.IdGrade.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdGrade = '{0}',", strIdGrade); //年级流水号
 }
 else
 {
 sbSQL.Append(" IdGrade = null,"); //年级流水号
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.CreateDate))
 {
 if (objPaperEN.CreateDate !=  null)
 {
 var strCreateDate = objPaperEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateDate = '{0}',", strCreateDate); //建立日期
 }
 else
 {
 sbSQL.Append(" CreateDate = null,"); //建立日期
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.UpdUser))
 {
 if (objPaperEN.UpdUser !=  null)
 {
 var strUpdUser = objPaperEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.UpdDate))
 {
 if (objPaperEN.UpdDate !=  null)
 {
 var strUpdDate = objPaperEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.Memo))
 {
 if (objPaperEN.Memo !=  null)
 {
 var strMemo = objPaperEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objPaperEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsPaperEN objPaperEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objPaperEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPaperEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update Paper Set ");
 
 if (objPaperEN.IsUpdated(conPaper.PaperTitle))
 {
 if (objPaperEN.PaperTitle !=  null)
 {
 var strPaperTitle = objPaperEN.PaperTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPaperTitle, conPaper.PaperTitle); //论文标题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.PaperTitle); //论文标题
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.PaperContent))
 {
 if (objPaperEN.PaperContent !=  null)
 {
 var strPaperContent = objPaperEN.PaperContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPaperContent, conPaper.PaperContent); //主题内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.PaperContent); //主题内容
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.Periodical))
 {
 if (objPaperEN.Periodical !=  null)
 {
 var strPeriodical = objPaperEN.Periodical.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPeriodical, conPaper.Periodical); //期刊
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.Periodical); //期刊
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.Author))
 {
 if (objPaperEN.Author !=  null)
 {
 var strAuthor = objPaperEN.Author.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAuthor, conPaper.Author); //作者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.Author); //作者
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.ResearchQuestion))
 {
 if (objPaperEN.ResearchQuestion !=  null)
 {
 var strResearchQuestion = objPaperEN.ResearchQuestion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResearchQuestion, conPaper.ResearchQuestion); //研究问题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.ResearchQuestion); //研究问题
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.Keyword))
 {
 if (objPaperEN.Keyword !=  null)
 {
 var strKeyword = objPaperEN.Keyword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strKeyword, conPaper.Keyword); //关键字
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.Keyword); //关键字
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.LiteratureSources))
 {
 if (objPaperEN.LiteratureSources !=  null)
 {
 var strLiteratureSources = objPaperEN.LiteratureSources.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLiteratureSources, conPaper.LiteratureSources); //文献来源
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.LiteratureSources); //文献来源
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.LiteratureLink))
 {
 if (objPaperEN.LiteratureLink !=  null)
 {
 var strLiteratureLink = objPaperEN.LiteratureLink.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLiteratureLink, conPaper.LiteratureLink); //文献链接
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.LiteratureLink); //文献链接
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.UploadfileUrl))
 {
 if (objPaperEN.UploadfileUrl !=  null)
 {
 var strUploadfileUrl = objPaperEN.UploadfileUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUploadfileUrl, conPaper.UploadfileUrl); //文件地址
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.UploadfileUrl); //文件地址
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.IsQuotethesis))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPaperEN.IsQuotethesis == true?"1":"0", conPaper.IsQuotethesis); //是否引用论文
 }
 
 if (objPaperEN.IsUpdated(conPaper.QuoteId))
 {
 if (objPaperEN.QuoteId !=  null)
 {
 var strQuoteId = objPaperEN.QuoteId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuoteId, conPaper.QuoteId); //引用Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.QuoteId); //引用Id
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.IsChecked))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPaperEN.IsChecked == true?"1":"0", conPaper.IsChecked); //是否检查
 }
 
 if (objPaperEN.IsUpdated(conPaper.Checker))
 {
 if (objPaperEN.Checker !=  null)
 {
 var strChecker = objPaperEN.Checker.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strChecker, conPaper.Checker); //审核人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.Checker); //审核人
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.LiteratureTypeId))
 {
 if (objPaperEN.LiteratureTypeId !=  null)
 {
 var strLiteratureTypeId = objPaperEN.LiteratureTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLiteratureTypeId, conPaper.LiteratureTypeId); //文献类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.LiteratureTypeId); //文献类型Id
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.BrowseNumber))
 {
 if (objPaperEN.BrowseNumber !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperEN.BrowseNumber, conPaper.BrowseNumber); //浏览量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.BrowseNumber); //浏览量
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPaperEN.IsSubmit == true?"1":"0", conPaper.IsSubmit); //是否提交
 }
 
 if (objPaperEN.IsUpdated(conPaper.AppraiseCount))
 {
 if (objPaperEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperEN.AppraiseCount, conPaper.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.AppraiseCount); //评论数
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.AttachmentCount))
 {
 if (objPaperEN.AttachmentCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperEN.AttachmentCount, conPaper.AttachmentCount); //附件计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.AttachmentCount); //附件计数
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.CollectionCount))
 {
 if (objPaperEN.CollectionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperEN.CollectionCount, conPaper.CollectionCount); //收藏数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.CollectionCount); //收藏数量
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.DownloadCount))
 {
 if (objPaperEN.DownloadCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperEN.DownloadCount, conPaper.DownloadCount); //下载数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.DownloadCount); //下载数
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.OkCount))
 {
 if (objPaperEN.OkCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperEN.OkCount, conPaper.OkCount); //点赞统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.OkCount); //点赞统计
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.Pcount))
 {
 if (objPaperEN.Pcount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperEN.Pcount, conPaper.Pcount); //读写数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.Pcount); //读写数
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.Score))
 {
 if (objPaperEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperEN.Score, conPaper.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.Score); //评分
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.StuScore))
 {
 if (objPaperEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperEN.StuScore, conPaper.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.StuScore); //学生平均分
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.TeaScore))
 {
 if (objPaperEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperEN.TeaScore, conPaper.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.TeaScore); //教师评分
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.PaperTypeId))
 {
 if (objPaperEN.PaperTypeId !=  null)
 {
 var strPaperTypeId = objPaperEN.PaperTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPaperTypeId, conPaper.PaperTypeId); //论文类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.PaperTypeId); //论文类型Id
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.PaperStatusId))
 {
 if (objPaperEN.PaperStatusId !=  null)
 {
 var strPaperStatusId = objPaperEN.PaperStatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPaperStatusId, conPaper.PaperStatusId); //论文状态Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.PaperStatusId); //论文状态Id
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.VersionCount))
 {
 if (objPaperEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperEN.VersionCount, conPaper.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.VersionCount); //版本统计
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.IsPublic))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPaperEN.IsPublic == true?"1":"0", conPaper.IsPublic); //是否公开
 }
 
 if (objPaperEN.IsUpdated(conPaper.AskQuestion))
 {
 if (objPaperEN.AskQuestion !=  null)
 {
 var strAskQuestion = objPaperEN.AskQuestion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAskQuestion, conPaper.AskQuestion); //问题提出
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.AskQuestion); //问题提出
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.ResearchStatus))
 {
 if (objPaperEN.ResearchStatus !=  null)
 {
 var strResearchStatus = objPaperEN.ResearchStatus.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResearchStatus, conPaper.ResearchStatus); //目前研究的现状
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.ResearchStatus); //目前研究的现状
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.InnovationPoints))
 {
 if (objPaperEN.InnovationPoints !=  null)
 {
 var strInnovationPoints = objPaperEN.InnovationPoints.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strInnovationPoints, conPaper.InnovationPoints); //创新点
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.InnovationPoints); //创新点
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.ResearchDesign))
 {
 if (objPaperEN.ResearchDesign !=  null)
 {
 var strResearchDesign = objPaperEN.ResearchDesign.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResearchDesign, conPaper.ResearchDesign); //研究设计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.ResearchDesign); //研究设计
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.DimensionDataProcess))
 {
 if (objPaperEN.DimensionDataProcess !=  null)
 {
 var strDimensionDataProcess = objPaperEN.DimensionDataProcess.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDimensionDataProcess, conPaper.DimensionDataProcess); //数据处理的维度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.DimensionDataProcess); //数据处理的维度
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.ExpectedConclusion))
 {
 if (objPaperEN.ExpectedConclusion !=  null)
 {
 var strExpectedConclusion = objPaperEN.ExpectedConclusion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExpectedConclusion, conPaper.ExpectedConclusion); //预期结论
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.ExpectedConclusion); //预期结论
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.ShareId))
 {
 if (objPaperEN.ShareId !=  null)
 {
 var strShareId = objPaperEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strShareId, conPaper.ShareId); //分享Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.ShareId); //分享Id
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.PaperQCount))
 {
 if (objPaperEN.PaperQCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperEN.PaperQCount, conPaper.PaperQCount); //论文答疑数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.PaperQCount); //论文答疑数
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.SubVCount))
 {
 if (objPaperEN.SubVCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperEN.SubVCount, conPaper.SubVCount); //论文子观点数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.SubVCount); //论文子观点数
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.TagsCount))
 {
 if (objPaperEN.TagsCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperEN.TagsCount, conPaper.TagsCount); //论文标注数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.TagsCount); //论文标注数
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.TeaQCount))
 {
 if (objPaperEN.TeaQCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperEN.TeaQCount, conPaper.TeaQCount); //教师提问数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.TeaQCount); //教师提问数
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.IdStudyLevel))
 {
 if (objPaperEN.IdStudyLevel !=  null)
 {
 var strIdStudyLevel = objPaperEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdStudyLevel, conPaper.IdStudyLevel); //学段流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.IdStudyLevel); //学段流水号
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.IdGrade))
 {
 if (objPaperEN.IdGrade !=  null)
 {
 var strIdGrade = objPaperEN.IdGrade.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdGrade, conPaper.IdGrade); //年级流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.IdGrade); //年级流水号
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.CreateDate))
 {
 if (objPaperEN.CreateDate !=  null)
 {
 var strCreateDate = objPaperEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateDate, conPaper.CreateDate); //建立日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.CreateDate); //建立日期
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.UpdUser))
 {
 if (objPaperEN.UpdUser !=  null)
 {
 var strUpdUser = objPaperEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conPaper.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.UpdUser); //修改人
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.UpdDate))
 {
 if (objPaperEN.UpdDate !=  null)
 {
 var strUpdDate = objPaperEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conPaper.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.UpdDate); //修改日期
 }
 }
 
 if (objPaperEN.IsUpdated(conPaper.Memo))
 {
 if (objPaperEN.Memo !=  null)
 {
 var strMemo = objPaperEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conPaper.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaper.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where PaperId = '{0}'", objPaperEN.PaperId); 
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
 /// <param name = "strPaperId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strPaperId) 
{
CheckPrimaryKey(strPaperId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strPaperId,
};
 objSQL.ExecSP("Paper_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strPaperId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strPaperId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strPaperId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperDA.GetSpecSQLObj();
//删除Paper本表中与当前对象有关的记录
strSQL = strSQL + "Delete from Paper where PaperId = " + "'"+ strPaperId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelPaper(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperDA.GetSpecSQLObj();
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
//删除Paper本表中与当前对象有关的记录
strSQL = strSQL + "Delete from Paper where PaperId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strPaperId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strPaperId) 
{
CheckPrimaryKey(strPaperId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperDA.GetSpecSQLObj();
//删除Paper本表中与当前对象有关的记录
strSQL = strSQL + "Delete from Paper where PaperId = " + "'"+ strPaperId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelPaper(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsPaperDA: DelPaper)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from Paper where " + strCondition ;
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
public bool DelPaperWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsPaperDA: DelPaperWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from Paper where " + strCondition ;
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
 /// <param name = "objPaperENS">源对象</param>
 /// <param name = "objPaperENT">目标对象</param>
public void CopyTo(clsPaperEN objPaperENS, clsPaperEN objPaperENT)
{
objPaperENT.PaperId = objPaperENS.PaperId; //论文Id
objPaperENT.PaperTitle = objPaperENS.PaperTitle; //论文标题
objPaperENT.PaperContent = objPaperENS.PaperContent; //主题内容
objPaperENT.Periodical = objPaperENS.Periodical; //期刊
objPaperENT.Author = objPaperENS.Author; //作者
objPaperENT.ResearchQuestion = objPaperENS.ResearchQuestion; //研究问题
objPaperENT.Keyword = objPaperENS.Keyword; //关键字
objPaperENT.LiteratureSources = objPaperENS.LiteratureSources; //文献来源
objPaperENT.LiteratureLink = objPaperENS.LiteratureLink; //文献链接
objPaperENT.UploadfileUrl = objPaperENS.UploadfileUrl; //文件地址
objPaperENT.IsQuotethesis = objPaperENS.IsQuotethesis; //是否引用论文
objPaperENT.QuoteId = objPaperENS.QuoteId; //引用Id
objPaperENT.IsChecked = objPaperENS.IsChecked; //是否检查
objPaperENT.Checker = objPaperENS.Checker; //审核人
objPaperENT.LiteratureTypeId = objPaperENS.LiteratureTypeId; //文献类型Id
objPaperENT.BrowseNumber = objPaperENS.BrowseNumber; //浏览量
objPaperENT.IsSubmit = objPaperENS.IsSubmit; //是否提交
objPaperENT.AppraiseCount = objPaperENS.AppraiseCount; //评论数
objPaperENT.AttachmentCount = objPaperENS.AttachmentCount; //附件计数
objPaperENT.CollectionCount = objPaperENS.CollectionCount; //收藏数量
objPaperENT.DownloadCount = objPaperENS.DownloadCount; //下载数
objPaperENT.OkCount = objPaperENS.OkCount; //点赞统计
objPaperENT.Pcount = objPaperENS.Pcount; //读写数
objPaperENT.Score = objPaperENS.Score; //评分
objPaperENT.StuScore = objPaperENS.StuScore; //学生平均分
objPaperENT.TeaScore = objPaperENS.TeaScore; //教师评分
objPaperENT.PaperTypeId = objPaperENS.PaperTypeId; //论文类型Id
objPaperENT.PaperStatusId = objPaperENS.PaperStatusId; //论文状态Id
objPaperENT.VersionCount = objPaperENS.VersionCount; //版本统计
objPaperENT.IsPublic = objPaperENS.IsPublic; //是否公开
objPaperENT.AskQuestion = objPaperENS.AskQuestion; //问题提出
objPaperENT.ResearchStatus = objPaperENS.ResearchStatus; //目前研究的现状
objPaperENT.InnovationPoints = objPaperENS.InnovationPoints; //创新点
objPaperENT.ResearchDesign = objPaperENS.ResearchDesign; //研究设计
objPaperENT.DimensionDataProcess = objPaperENS.DimensionDataProcess; //数据处理的维度
objPaperENT.ExpectedConclusion = objPaperENS.ExpectedConclusion; //预期结论
objPaperENT.ShareId = objPaperENS.ShareId; //分享Id
objPaperENT.PaperQCount = objPaperENS.PaperQCount; //论文答疑数
objPaperENT.SubVCount = objPaperENS.SubVCount; //论文子观点数
objPaperENT.TagsCount = objPaperENS.TagsCount; //论文标注数
objPaperENT.TeaQCount = objPaperENS.TeaQCount; //教师提问数
objPaperENT.IdStudyLevel = objPaperENS.IdStudyLevel; //学段流水号
objPaperENT.IdGrade = objPaperENS.IdGrade; //年级流水号
objPaperENT.CreateDate = objPaperENS.CreateDate; //建立日期
objPaperENT.UpdUser = objPaperENS.UpdUser; //修改人
objPaperENT.UpdDate = objPaperENS.UpdDate; //修改日期
objPaperENT.Memo = objPaperENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsPaperEN objPaperEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objPaperEN.PaperTitle, conPaper.PaperTitle);
clsCheckSql.CheckFieldNotNull(objPaperEN.LiteratureTypeId, conPaper.LiteratureTypeId);
//检查字段长度
clsCheckSql.CheckFieldLen(objPaperEN.PaperId, 8, conPaper.PaperId);
clsCheckSql.CheckFieldLen(objPaperEN.PaperTitle, 500, conPaper.PaperTitle);
clsCheckSql.CheckFieldLen(objPaperEN.Periodical, 100, conPaper.Periodical);
clsCheckSql.CheckFieldLen(objPaperEN.Author, 200, conPaper.Author);
clsCheckSql.CheckFieldLen(objPaperEN.ResearchQuestion, 2000, conPaper.ResearchQuestion);
clsCheckSql.CheckFieldLen(objPaperEN.Keyword, 1000, conPaper.Keyword);
clsCheckSql.CheckFieldLen(objPaperEN.LiteratureSources, 1000, conPaper.LiteratureSources);
clsCheckSql.CheckFieldLen(objPaperEN.LiteratureLink, 1000, conPaper.LiteratureLink);
clsCheckSql.CheckFieldLen(objPaperEN.UploadfileUrl, 1000, conPaper.UploadfileUrl);
clsCheckSql.CheckFieldLen(objPaperEN.QuoteId, 8, conPaper.QuoteId);
clsCheckSql.CheckFieldLen(objPaperEN.Checker, 20, conPaper.Checker);
clsCheckSql.CheckFieldLen(objPaperEN.LiteratureTypeId, 2, conPaper.LiteratureTypeId);
clsCheckSql.CheckFieldLen(objPaperEN.PaperTypeId, 2, conPaper.PaperTypeId);
clsCheckSql.CheckFieldLen(objPaperEN.PaperStatusId, 2, conPaper.PaperStatusId);
clsCheckSql.CheckFieldLen(objPaperEN.AskQuestion, 5000, conPaper.AskQuestion);
clsCheckSql.CheckFieldLen(objPaperEN.ResearchStatus, 5000, conPaper.ResearchStatus);
clsCheckSql.CheckFieldLen(objPaperEN.InnovationPoints, 5000, conPaper.InnovationPoints);
clsCheckSql.CheckFieldLen(objPaperEN.ResearchDesign, 5000, conPaper.ResearchDesign);
clsCheckSql.CheckFieldLen(objPaperEN.DimensionDataProcess, 5000, conPaper.DimensionDataProcess);
clsCheckSql.CheckFieldLen(objPaperEN.ExpectedConclusion, 5000, conPaper.ExpectedConclusion);
clsCheckSql.CheckFieldLen(objPaperEN.ShareId, 2, conPaper.ShareId);
clsCheckSql.CheckFieldLen(objPaperEN.IdStudyLevel, 4, conPaper.IdStudyLevel);
clsCheckSql.CheckFieldLen(objPaperEN.IdGrade, 4, conPaper.IdGrade);
clsCheckSql.CheckFieldLen(objPaperEN.CreateDate, 20, conPaper.CreateDate);
clsCheckSql.CheckFieldLen(objPaperEN.UpdUser, 20, conPaper.UpdUser);
clsCheckSql.CheckFieldLen(objPaperEN.UpdDate, 20, conPaper.UpdDate);
clsCheckSql.CheckFieldLen(objPaperEN.Memo, 1000, conPaper.Memo);
//检查字段外键固定长度
 objPaperEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsPaperEN objPaperEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objPaperEN.PaperTitle, 500, conPaper.PaperTitle);
clsCheckSql.CheckFieldLen(objPaperEN.Periodical, 100, conPaper.Periodical);
clsCheckSql.CheckFieldLen(objPaperEN.Author, 200, conPaper.Author);
clsCheckSql.CheckFieldLen(objPaperEN.ResearchQuestion, 2000, conPaper.ResearchQuestion);
clsCheckSql.CheckFieldLen(objPaperEN.Keyword, 1000, conPaper.Keyword);
clsCheckSql.CheckFieldLen(objPaperEN.LiteratureSources, 1000, conPaper.LiteratureSources);
clsCheckSql.CheckFieldLen(objPaperEN.LiteratureLink, 1000, conPaper.LiteratureLink);
clsCheckSql.CheckFieldLen(objPaperEN.UploadfileUrl, 1000, conPaper.UploadfileUrl);
clsCheckSql.CheckFieldLen(objPaperEN.QuoteId, 8, conPaper.QuoteId);
clsCheckSql.CheckFieldLen(objPaperEN.Checker, 20, conPaper.Checker);
clsCheckSql.CheckFieldLen(objPaperEN.LiteratureTypeId, 2, conPaper.LiteratureTypeId);
clsCheckSql.CheckFieldLen(objPaperEN.PaperTypeId, 2, conPaper.PaperTypeId);
clsCheckSql.CheckFieldLen(objPaperEN.PaperStatusId, 2, conPaper.PaperStatusId);
clsCheckSql.CheckFieldLen(objPaperEN.AskQuestion, 5000, conPaper.AskQuestion);
clsCheckSql.CheckFieldLen(objPaperEN.ResearchStatus, 5000, conPaper.ResearchStatus);
clsCheckSql.CheckFieldLen(objPaperEN.InnovationPoints, 5000, conPaper.InnovationPoints);
clsCheckSql.CheckFieldLen(objPaperEN.ResearchDesign, 5000, conPaper.ResearchDesign);
clsCheckSql.CheckFieldLen(objPaperEN.DimensionDataProcess, 5000, conPaper.DimensionDataProcess);
clsCheckSql.CheckFieldLen(objPaperEN.ExpectedConclusion, 5000, conPaper.ExpectedConclusion);
clsCheckSql.CheckFieldLen(objPaperEN.ShareId, 2, conPaper.ShareId);
clsCheckSql.CheckFieldLen(objPaperEN.IdStudyLevel, 4, conPaper.IdStudyLevel);
clsCheckSql.CheckFieldLen(objPaperEN.IdGrade, 4, conPaper.IdGrade);
clsCheckSql.CheckFieldLen(objPaperEN.CreateDate, 20, conPaper.CreateDate);
clsCheckSql.CheckFieldLen(objPaperEN.UpdUser, 20, conPaper.UpdUser);
clsCheckSql.CheckFieldLen(objPaperEN.UpdDate, 20, conPaper.UpdDate);
clsCheckSql.CheckFieldLen(objPaperEN.Memo, 1000, conPaper.Memo);
//检查外键字段长度
 objPaperEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsPaperEN objPaperEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objPaperEN.PaperId, 8, conPaper.PaperId);
clsCheckSql.CheckFieldLen(objPaperEN.PaperTitle, 500, conPaper.PaperTitle);
clsCheckSql.CheckFieldLen(objPaperEN.Periodical, 100, conPaper.Periodical);
clsCheckSql.CheckFieldLen(objPaperEN.Author, 200, conPaper.Author);
clsCheckSql.CheckFieldLen(objPaperEN.ResearchQuestion, 2000, conPaper.ResearchQuestion);
clsCheckSql.CheckFieldLen(objPaperEN.Keyword, 1000, conPaper.Keyword);
clsCheckSql.CheckFieldLen(objPaperEN.LiteratureSources, 1000, conPaper.LiteratureSources);
clsCheckSql.CheckFieldLen(objPaperEN.LiteratureLink, 1000, conPaper.LiteratureLink);
clsCheckSql.CheckFieldLen(objPaperEN.UploadfileUrl, 1000, conPaper.UploadfileUrl);
clsCheckSql.CheckFieldLen(objPaperEN.QuoteId, 8, conPaper.QuoteId);
clsCheckSql.CheckFieldLen(objPaperEN.Checker, 20, conPaper.Checker);
clsCheckSql.CheckFieldLen(objPaperEN.LiteratureTypeId, 2, conPaper.LiteratureTypeId);
clsCheckSql.CheckFieldLen(objPaperEN.PaperTypeId, 2, conPaper.PaperTypeId);
clsCheckSql.CheckFieldLen(objPaperEN.PaperStatusId, 2, conPaper.PaperStatusId);
clsCheckSql.CheckFieldLen(objPaperEN.AskQuestion, 5000, conPaper.AskQuestion);
clsCheckSql.CheckFieldLen(objPaperEN.ResearchStatus, 5000, conPaper.ResearchStatus);
clsCheckSql.CheckFieldLen(objPaperEN.InnovationPoints, 5000, conPaper.InnovationPoints);
clsCheckSql.CheckFieldLen(objPaperEN.ResearchDesign, 5000, conPaper.ResearchDesign);
clsCheckSql.CheckFieldLen(objPaperEN.DimensionDataProcess, 5000, conPaper.DimensionDataProcess);
clsCheckSql.CheckFieldLen(objPaperEN.ExpectedConclusion, 5000, conPaper.ExpectedConclusion);
clsCheckSql.CheckFieldLen(objPaperEN.ShareId, 2, conPaper.ShareId);
clsCheckSql.CheckFieldLen(objPaperEN.IdStudyLevel, 4, conPaper.IdStudyLevel);
clsCheckSql.CheckFieldLen(objPaperEN.IdGrade, 4, conPaper.IdGrade);
clsCheckSql.CheckFieldLen(objPaperEN.CreateDate, 20, conPaper.CreateDate);
clsCheckSql.CheckFieldLen(objPaperEN.UpdUser, 20, conPaper.UpdUser);
clsCheckSql.CheckFieldLen(objPaperEN.UpdDate, 20, conPaper.UpdDate);
clsCheckSql.CheckFieldLen(objPaperEN.Memo, 1000, conPaper.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objPaperEN.PaperId, conPaper.PaperId);
clsCheckSql.CheckSqlInjection4Field(objPaperEN.PaperTitle, conPaper.PaperTitle);
clsCheckSql.CheckSqlInjection4Field(objPaperEN.Periodical, conPaper.Periodical);
clsCheckSql.CheckSqlInjection4Field(objPaperEN.Author, conPaper.Author);
clsCheckSql.CheckSqlInjection4Field(objPaperEN.ResearchQuestion, conPaper.ResearchQuestion);
clsCheckSql.CheckSqlInjection4Field(objPaperEN.Keyword, conPaper.Keyword);
clsCheckSql.CheckSqlInjection4Field(objPaperEN.LiteratureSources, conPaper.LiteratureSources);
clsCheckSql.CheckSqlInjection4Field(objPaperEN.LiteratureLink, conPaper.LiteratureLink);
clsCheckSql.CheckSqlInjection4Field(objPaperEN.UploadfileUrl, conPaper.UploadfileUrl);
clsCheckSql.CheckSqlInjection4Field(objPaperEN.QuoteId, conPaper.QuoteId);
clsCheckSql.CheckSqlInjection4Field(objPaperEN.Checker, conPaper.Checker);
clsCheckSql.CheckSqlInjection4Field(objPaperEN.LiteratureTypeId, conPaper.LiteratureTypeId);
clsCheckSql.CheckSqlInjection4Field(objPaperEN.PaperTypeId, conPaper.PaperTypeId);
clsCheckSql.CheckSqlInjection4Field(objPaperEN.PaperStatusId, conPaper.PaperStatusId);
clsCheckSql.CheckSqlInjection4Field(objPaperEN.AskQuestion, conPaper.AskQuestion);
clsCheckSql.CheckSqlInjection4Field(objPaperEN.ResearchStatus, conPaper.ResearchStatus);
clsCheckSql.CheckSqlInjection4Field(objPaperEN.InnovationPoints, conPaper.InnovationPoints);
clsCheckSql.CheckSqlInjection4Field(objPaperEN.ResearchDesign, conPaper.ResearchDesign);
clsCheckSql.CheckSqlInjection4Field(objPaperEN.DimensionDataProcess, conPaper.DimensionDataProcess);
clsCheckSql.CheckSqlInjection4Field(objPaperEN.ExpectedConclusion, conPaper.ExpectedConclusion);
clsCheckSql.CheckSqlInjection4Field(objPaperEN.ShareId, conPaper.ShareId);
clsCheckSql.CheckSqlInjection4Field(objPaperEN.IdStudyLevel, conPaper.IdStudyLevel);
clsCheckSql.CheckSqlInjection4Field(objPaperEN.IdGrade, conPaper.IdGrade);
clsCheckSql.CheckSqlInjection4Field(objPaperEN.CreateDate, conPaper.CreateDate);
clsCheckSql.CheckSqlInjection4Field(objPaperEN.UpdUser, conPaper.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objPaperEN.UpdDate, conPaper.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objPaperEN.Memo, conPaper.Memo);
//检查外键字段长度
 objPaperEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--Paper(论文表),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objPaperEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsPaperEN objPaperEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PaperTitle = '{0}'", objPaperEN.PaperTitle);
 if (objPaperEN.Author == null)
{
 sbCondition.AppendFormat(" and Author is null");
}
else
{
 sbCondition.AppendFormat(" and Author = '{0}'", objPaperEN.Author);
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
 objSQL = clsPaperDA.GetSpecSQLObj();
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
 objSQL = clsPaperDA.GetSpecSQLObj();
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
 objSQL = clsPaperDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsPaperEN._CurrTabName);
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
 objSQL = clsPaperDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsPaperEN._CurrTabName, strCondition);
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
 objSQL = clsPaperDA.GetSpecSQLObj();
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
 objSQL = clsPaperDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}