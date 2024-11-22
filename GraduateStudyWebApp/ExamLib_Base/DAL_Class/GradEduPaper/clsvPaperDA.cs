
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPaperDA
 表名:vPaper(01120549)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:48:08
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
 /// v论文表(vPaper)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvPaperDA : clsCommBase4DA
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
 return clsvPaperEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvPaperEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvPaperEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvPaperEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvPaperEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:vPaper中,检查关键字,长度不正确!(clsvPaperDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strPaperId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vPaper中,关键字不能为空 或 null!(clsvPaperDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strPaperId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvPaperDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvPaperDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperDA.GetSpecSQLObj();
strSQL = "Select * from vPaper where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vPaper(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvPaperDA: GetDataTable_vPaper)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperDA.GetSpecSQLObj();
strSQL = "Select * from vPaper where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvPaperDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvPaperDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperDA.GetSpecSQLObj();
strSQL = "Select * from vPaper where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvPaperDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvPaperDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPaper where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPaper where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvPaperDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vPaper where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvPaperDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vPaper.* from vPaper Left Join {1} on {2} where {3} and vPaper.PaperId not in (Select top {5} vPaper.PaperId from vPaper Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPaper where {1} and PaperId not in (Select top {2} PaperId from vPaper where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPaper where {1} and PaperId not in (Select top {3} PaperId from vPaper where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvPaperDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vPaper.* from vPaper Left Join {1} on {2} where {3} and vPaper.PaperId not in (Select top {5} vPaper.PaperId from vPaper Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPaper where {1} and PaperId not in (Select top {2} PaperId from vPaper where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPaper where {1} and PaperId not in (Select top {3} PaperId from vPaper where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvPaperEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvPaperDA:GetObjLst)", objException.Message));
}
List<clsvPaperEN> arrObjLst = new List<clsvPaperEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperDA.GetSpecSQLObj();
strSQL = "Select * from vPaper where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperEN objvPaperEN = new clsvPaperEN();
try
{
objvPaperEN.PaperId = objRow[convPaper.PaperId].ToString().Trim(); //论文Id
objvPaperEN.PaperTitle = objRow[convPaper.PaperTitle].ToString().Trim(); //论文标题
objvPaperEN.PaperContent = objRow[convPaper.PaperContent] == DBNull.Value ? null : objRow[convPaper.PaperContent].ToString().Trim(); //主题内容
objvPaperEN.Periodical = objRow[convPaper.Periodical] == DBNull.Value ? null : objRow[convPaper.Periodical].ToString().Trim(); //期刊
objvPaperEN.Author = objRow[convPaper.Author] == DBNull.Value ? null : objRow[convPaper.Author].ToString().Trim(); //作者
objvPaperEN.ResearchQuestion = objRow[convPaper.ResearchQuestion] == DBNull.Value ? null : objRow[convPaper.ResearchQuestion].ToString().Trim(); //研究问题
objvPaperEN.Keyword = objRow[convPaper.Keyword] == DBNull.Value ? null : objRow[convPaper.Keyword].ToString().Trim(); //关键字
objvPaperEN.LiteratureSources = objRow[convPaper.LiteratureSources] == DBNull.Value ? null : objRow[convPaper.LiteratureSources].ToString().Trim(); //文献来源
objvPaperEN.LiteratureLink = objRow[convPaper.LiteratureLink] == DBNull.Value ? null : objRow[convPaper.LiteratureLink].ToString().Trim(); //文献链接
objvPaperEN.UploadfileUrl = objRow[convPaper.UploadfileUrl] == DBNull.Value ? null : objRow[convPaper.UploadfileUrl].ToString().Trim(); //文件地址
objvPaperEN.IsQuotethesis = TransNullToBool(objRow[convPaper.IsQuotethesis].ToString().Trim()); //是否引用论文
objvPaperEN.QuoteId = objRow[convPaper.QuoteId] == DBNull.Value ? null : objRow[convPaper.QuoteId].ToString().Trim(); //引用Id
objvPaperEN.IsChecked = TransNullToBool(objRow[convPaper.IsChecked].ToString().Trim()); //是否检查
objvPaperEN.Checker = objRow[convPaper.Checker] == DBNull.Value ? null : objRow[convPaper.Checker].ToString().Trim(); //审核人
objvPaperEN.LiteratureTypeId = objRow[convPaper.LiteratureTypeId].ToString().Trim(); //作文类型Id
objvPaperEN.LiteratureTypeName = objRow[convPaper.LiteratureTypeName] == DBNull.Value ? null : objRow[convPaper.LiteratureTypeName].ToString().Trim(); //作文类型名
objvPaperEN.BrowseNumber = objRow[convPaper.BrowseNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaper.BrowseNumber].ToString().Trim()); //浏览量
objvPaperEN.IsSubmit = TransNullToBool(objRow[convPaper.IsSubmit].ToString().Trim()); //是否提交
objvPaperEN.AppraiseCount = objRow[convPaper.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaper.AppraiseCount].ToString().Trim()); //评论数
objvPaperEN.AttachmentCount = objRow[convPaper.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaper.AttachmentCount].ToString().Trim()); //附件计数
objvPaperEN.CollectionCount = objRow[convPaper.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convPaper.CollectionCount].ToString().Trim()); //收藏数量
objvPaperEN.DownloadCount = objRow[convPaper.DownloadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaper.DownloadCount].ToString().Trim()); //下载数
objvPaperEN.OkCount = objRow[convPaper.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaper.OkCount].ToString().Trim()); //点赞统计
objvPaperEN.Pcount = objRow[convPaper.Pcount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaper.Pcount].ToString().Trim()); //读写数
objvPaperEN.Score = objRow[convPaper.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPaper.Score].ToString().Trim()); //评分
objvPaperEN.StuScore = objRow[convPaper.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPaper.StuScore].ToString().Trim()); //学生平均分
objvPaperEN.TeaScore = objRow[convPaper.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPaper.TeaScore].ToString().Trim()); //教师评分
objvPaperEN.PaperTypeId = objRow[convPaper.PaperTypeId] == DBNull.Value ? null : objRow[convPaper.PaperTypeId].ToString().Trim(); //论文类型Id
objvPaperEN.PaperTypeName = objRow[convPaper.PaperTypeName] == DBNull.Value ? null : objRow[convPaper.PaperTypeName].ToString().Trim(); //论文类型名
objvPaperEN.PaperStatusId = objRow[convPaper.PaperStatusId] == DBNull.Value ? null : objRow[convPaper.PaperStatusId].ToString().Trim(); //论文状态Id
objvPaperEN.PaperStatusName = objRow[convPaper.PaperStatusName] == DBNull.Value ? null : objRow[convPaper.PaperStatusName].ToString().Trim(); //论文状态名
objvPaperEN.VersionCount = objRow[convPaper.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaper.VersionCount].ToString().Trim()); //版本统计
objvPaperEN.IsPublic = TransNullToBool(objRow[convPaper.IsPublic].ToString().Trim()); //是否公开
objvPaperEN.AskQuestion = objRow[convPaper.AskQuestion] == DBNull.Value ? null : objRow[convPaper.AskQuestion].ToString().Trim(); //问题提出
objvPaperEN.ResearchStatus = objRow[convPaper.ResearchStatus] == DBNull.Value ? null : objRow[convPaper.ResearchStatus].ToString().Trim(); //目前研究的现状
objvPaperEN.InnovationPoints = objRow[convPaper.InnovationPoints] == DBNull.Value ? null : objRow[convPaper.InnovationPoints].ToString().Trim(); //创新点
objvPaperEN.ResearchDesign = objRow[convPaper.ResearchDesign] == DBNull.Value ? null : objRow[convPaper.ResearchDesign].ToString().Trim(); //研究设计
objvPaperEN.DimensionDataProcess = objRow[convPaper.DimensionDataProcess] == DBNull.Value ? null : objRow[convPaper.DimensionDataProcess].ToString().Trim(); //数据处理的维度
objvPaperEN.ExpectedConclusion = objRow[convPaper.ExpectedConclusion] == DBNull.Value ? null : objRow[convPaper.ExpectedConclusion].ToString().Trim(); //预期结论
objvPaperEN.ShareId = objRow[convPaper.ShareId] == DBNull.Value ? null : objRow[convPaper.ShareId].ToString().Trim(); //分享Id
objvPaperEN.PaperQCount = objRow[convPaper.PaperQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaper.PaperQCount].ToString().Trim()); //论文答疑数
objvPaperEN.SubVCount = objRow[convPaper.SubVCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaper.SubVCount].ToString().Trim()); //论文子观点数
objvPaperEN.TagsCount = objRow[convPaper.TagsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaper.TagsCount].ToString().Trim()); //论文标注数
objvPaperEN.TeaQCount = objRow[convPaper.TeaQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaper.TeaQCount].ToString().Trim()); //教师提问数
objvPaperEN.CreateDate = objRow[convPaper.CreateDate] == DBNull.Value ? null : objRow[convPaper.CreateDate].ToString().Trim(); //建立日期
objvPaperEN.UpdUser = objRow[convPaper.UpdUser] == DBNull.Value ? null : objRow[convPaper.UpdUser].ToString().Trim(); //修改人
objvPaperEN.UserName = objRow[convPaper.UserName] == DBNull.Value ? null : objRow[convPaper.UserName].ToString().Trim(); //用户名
objvPaperEN.IdXzCollege = objRow[convPaper.IdXzCollege] == DBNull.Value ? null : objRow[convPaper.IdXzCollege].ToString().Trim(); //学院流水号
objvPaperEN.UpdDate = objRow[convPaper.UpdDate] == DBNull.Value ? null : objRow[convPaper.UpdDate].ToString().Trim(); //修改日期
objvPaperEN.Memo = objRow[convPaper.Memo] == DBNull.Value ? null : objRow[convPaper.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvPaperDA: GetObjLst)", objException.Message));
}
objvPaperEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvPaperEN);
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
public List<clsvPaperEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvPaperDA:GetObjLstByTabName)", objException.Message));
}
List<clsvPaperEN> arrObjLst = new List<clsvPaperEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperEN objvPaperEN = new clsvPaperEN();
try
{
objvPaperEN.PaperId = objRow[convPaper.PaperId].ToString().Trim(); //论文Id
objvPaperEN.PaperTitle = objRow[convPaper.PaperTitle].ToString().Trim(); //论文标题
objvPaperEN.PaperContent = objRow[convPaper.PaperContent] == DBNull.Value ? null : objRow[convPaper.PaperContent].ToString().Trim(); //主题内容
objvPaperEN.Periodical = objRow[convPaper.Periodical] == DBNull.Value ? null : objRow[convPaper.Periodical].ToString().Trim(); //期刊
objvPaperEN.Author = objRow[convPaper.Author] == DBNull.Value ? null : objRow[convPaper.Author].ToString().Trim(); //作者
objvPaperEN.ResearchQuestion = objRow[convPaper.ResearchQuestion] == DBNull.Value ? null : objRow[convPaper.ResearchQuestion].ToString().Trim(); //研究问题
objvPaperEN.Keyword = objRow[convPaper.Keyword] == DBNull.Value ? null : objRow[convPaper.Keyword].ToString().Trim(); //关键字
objvPaperEN.LiteratureSources = objRow[convPaper.LiteratureSources] == DBNull.Value ? null : objRow[convPaper.LiteratureSources].ToString().Trim(); //文献来源
objvPaperEN.LiteratureLink = objRow[convPaper.LiteratureLink] == DBNull.Value ? null : objRow[convPaper.LiteratureLink].ToString().Trim(); //文献链接
objvPaperEN.UploadfileUrl = objRow[convPaper.UploadfileUrl] == DBNull.Value ? null : objRow[convPaper.UploadfileUrl].ToString().Trim(); //文件地址
objvPaperEN.IsQuotethesis = TransNullToBool(objRow[convPaper.IsQuotethesis].ToString().Trim()); //是否引用论文
objvPaperEN.QuoteId = objRow[convPaper.QuoteId] == DBNull.Value ? null : objRow[convPaper.QuoteId].ToString().Trim(); //引用Id
objvPaperEN.IsChecked = TransNullToBool(objRow[convPaper.IsChecked].ToString().Trim()); //是否检查
objvPaperEN.Checker = objRow[convPaper.Checker] == DBNull.Value ? null : objRow[convPaper.Checker].ToString().Trim(); //审核人
objvPaperEN.LiteratureTypeId = objRow[convPaper.LiteratureTypeId].ToString().Trim(); //作文类型Id
objvPaperEN.LiteratureTypeName = objRow[convPaper.LiteratureTypeName] == DBNull.Value ? null : objRow[convPaper.LiteratureTypeName].ToString().Trim(); //作文类型名
objvPaperEN.BrowseNumber = objRow[convPaper.BrowseNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaper.BrowseNumber].ToString().Trim()); //浏览量
objvPaperEN.IsSubmit = TransNullToBool(objRow[convPaper.IsSubmit].ToString().Trim()); //是否提交
objvPaperEN.AppraiseCount = objRow[convPaper.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaper.AppraiseCount].ToString().Trim()); //评论数
objvPaperEN.AttachmentCount = objRow[convPaper.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaper.AttachmentCount].ToString().Trim()); //附件计数
objvPaperEN.CollectionCount = objRow[convPaper.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convPaper.CollectionCount].ToString().Trim()); //收藏数量
objvPaperEN.DownloadCount = objRow[convPaper.DownloadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaper.DownloadCount].ToString().Trim()); //下载数
objvPaperEN.OkCount = objRow[convPaper.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaper.OkCount].ToString().Trim()); //点赞统计
objvPaperEN.Pcount = objRow[convPaper.Pcount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaper.Pcount].ToString().Trim()); //读写数
objvPaperEN.Score = objRow[convPaper.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPaper.Score].ToString().Trim()); //评分
objvPaperEN.StuScore = objRow[convPaper.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPaper.StuScore].ToString().Trim()); //学生平均分
objvPaperEN.TeaScore = objRow[convPaper.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPaper.TeaScore].ToString().Trim()); //教师评分
objvPaperEN.PaperTypeId = objRow[convPaper.PaperTypeId] == DBNull.Value ? null : objRow[convPaper.PaperTypeId].ToString().Trim(); //论文类型Id
objvPaperEN.PaperTypeName = objRow[convPaper.PaperTypeName] == DBNull.Value ? null : objRow[convPaper.PaperTypeName].ToString().Trim(); //论文类型名
objvPaperEN.PaperStatusId = objRow[convPaper.PaperStatusId] == DBNull.Value ? null : objRow[convPaper.PaperStatusId].ToString().Trim(); //论文状态Id
objvPaperEN.PaperStatusName = objRow[convPaper.PaperStatusName] == DBNull.Value ? null : objRow[convPaper.PaperStatusName].ToString().Trim(); //论文状态名
objvPaperEN.VersionCount = objRow[convPaper.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaper.VersionCount].ToString().Trim()); //版本统计
objvPaperEN.IsPublic = TransNullToBool(objRow[convPaper.IsPublic].ToString().Trim()); //是否公开
objvPaperEN.AskQuestion = objRow[convPaper.AskQuestion] == DBNull.Value ? null : objRow[convPaper.AskQuestion].ToString().Trim(); //问题提出
objvPaperEN.ResearchStatus = objRow[convPaper.ResearchStatus] == DBNull.Value ? null : objRow[convPaper.ResearchStatus].ToString().Trim(); //目前研究的现状
objvPaperEN.InnovationPoints = objRow[convPaper.InnovationPoints] == DBNull.Value ? null : objRow[convPaper.InnovationPoints].ToString().Trim(); //创新点
objvPaperEN.ResearchDesign = objRow[convPaper.ResearchDesign] == DBNull.Value ? null : objRow[convPaper.ResearchDesign].ToString().Trim(); //研究设计
objvPaperEN.DimensionDataProcess = objRow[convPaper.DimensionDataProcess] == DBNull.Value ? null : objRow[convPaper.DimensionDataProcess].ToString().Trim(); //数据处理的维度
objvPaperEN.ExpectedConclusion = objRow[convPaper.ExpectedConclusion] == DBNull.Value ? null : objRow[convPaper.ExpectedConclusion].ToString().Trim(); //预期结论
objvPaperEN.ShareId = objRow[convPaper.ShareId] == DBNull.Value ? null : objRow[convPaper.ShareId].ToString().Trim(); //分享Id
objvPaperEN.PaperQCount = objRow[convPaper.PaperQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaper.PaperQCount].ToString().Trim()); //论文答疑数
objvPaperEN.SubVCount = objRow[convPaper.SubVCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaper.SubVCount].ToString().Trim()); //论文子观点数
objvPaperEN.TagsCount = objRow[convPaper.TagsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaper.TagsCount].ToString().Trim()); //论文标注数
objvPaperEN.TeaQCount = objRow[convPaper.TeaQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaper.TeaQCount].ToString().Trim()); //教师提问数
objvPaperEN.CreateDate = objRow[convPaper.CreateDate] == DBNull.Value ? null : objRow[convPaper.CreateDate].ToString().Trim(); //建立日期
objvPaperEN.UpdUser = objRow[convPaper.UpdUser] == DBNull.Value ? null : objRow[convPaper.UpdUser].ToString().Trim(); //修改人
objvPaperEN.UserName = objRow[convPaper.UserName] == DBNull.Value ? null : objRow[convPaper.UserName].ToString().Trim(); //用户名
objvPaperEN.IdXzCollege = objRow[convPaper.IdXzCollege] == DBNull.Value ? null : objRow[convPaper.IdXzCollege].ToString().Trim(); //学院流水号
objvPaperEN.UpdDate = objRow[convPaper.UpdDate] == DBNull.Value ? null : objRow[convPaper.UpdDate].ToString().Trim(); //修改日期
objvPaperEN.Memo = objRow[convPaper.Memo] == DBNull.Value ? null : objRow[convPaper.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvPaperDA: GetObjLst)", objException.Message));
}
objvPaperEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvPaperEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvPaperEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvPaper(ref clsvPaperEN objvPaperEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperDA.GetSpecSQLObj();
strSQL = "Select * from vPaper where PaperId = " + "'"+ objvPaperEN.PaperId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvPaperEN.PaperId = objDT.Rows[0][convPaper.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objvPaperEN.PaperTitle = objDT.Rows[0][convPaper.PaperTitle].ToString().Trim(); //论文标题(字段类型:varchar,字段长度:500,是否可空:False)
 objvPaperEN.PaperContent = objDT.Rows[0][convPaper.PaperContent].ToString().Trim(); //主题内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvPaperEN.Periodical = objDT.Rows[0][convPaper.Periodical].ToString().Trim(); //期刊(字段类型:varchar,字段长度:100,是否可空:True)
 objvPaperEN.Author = objDT.Rows[0][convPaper.Author].ToString().Trim(); //作者(字段类型:varchar,字段长度:200,是否可空:True)
 objvPaperEN.ResearchQuestion = objDT.Rows[0][convPaper.ResearchQuestion].ToString().Trim(); //研究问题(字段类型:varchar,字段长度:2000,是否可空:True)
 objvPaperEN.Keyword = objDT.Rows[0][convPaper.Keyword].ToString().Trim(); //关键字(字段类型:varchar,字段长度:1000,是否可空:True)
 objvPaperEN.LiteratureSources = objDT.Rows[0][convPaper.LiteratureSources].ToString().Trim(); //文献来源(字段类型:varchar,字段长度:1000,是否可空:True)
 objvPaperEN.LiteratureLink = objDT.Rows[0][convPaper.LiteratureLink].ToString().Trim(); //文献链接(字段类型:varchar,字段长度:1000,是否可空:True)
 objvPaperEN.UploadfileUrl = objDT.Rows[0][convPaper.UploadfileUrl].ToString().Trim(); //文件地址(字段类型:varchar,字段长度:1000,是否可空:True)
 objvPaperEN.IsQuotethesis = TransNullToBool(objDT.Rows[0][convPaper.IsQuotethesis].ToString().Trim()); //是否引用论文(字段类型:bit,字段长度:1,是否可空:True)
 objvPaperEN.QuoteId = objDT.Rows[0][convPaper.QuoteId].ToString().Trim(); //引用Id(字段类型:char,字段长度:8,是否可空:True)
 objvPaperEN.IsChecked = TransNullToBool(objDT.Rows[0][convPaper.IsChecked].ToString().Trim()); //是否检查(字段类型:bit,字段长度:1,是否可空:True)
 objvPaperEN.Checker = objDT.Rows[0][convPaper.Checker].ToString().Trim(); //审核人(字段类型:varchar,字段长度:20,是否可空:True)
 objvPaperEN.LiteratureTypeId = objDT.Rows[0][convPaper.LiteratureTypeId].ToString().Trim(); //作文类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvPaperEN.LiteratureTypeName = objDT.Rows[0][convPaper.LiteratureTypeName].ToString().Trim(); //作文类型名(字段类型:varchar,字段长度:100,是否可空:True)
 objvPaperEN.BrowseNumber = TransNullToInt(objDT.Rows[0][convPaper.BrowseNumber].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvPaperEN.IsSubmit = TransNullToBool(objDT.Rows[0][convPaper.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvPaperEN.AppraiseCount = TransNullToInt(objDT.Rows[0][convPaper.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objvPaperEN.AttachmentCount = TransNullToInt(objDT.Rows[0][convPaper.AttachmentCount].ToString().Trim()); //附件计数(字段类型:int,字段长度:4,是否可空:True)
 objvPaperEN.CollectionCount = TransNullToInt(objDT.Rows[0][convPaper.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvPaperEN.DownloadCount = TransNullToInt(objDT.Rows[0][convPaper.DownloadCount].ToString().Trim()); //下载数(字段类型:int,字段长度:4,是否可空:True)
 objvPaperEN.OkCount = TransNullToInt(objDT.Rows[0][convPaper.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objvPaperEN.Pcount = TransNullToInt(objDT.Rows[0][convPaper.Pcount].ToString().Trim()); //读写数(字段类型:int,字段长度:4,是否可空:True)
 objvPaperEN.Score = TransNullToFloat(objDT.Rows[0][convPaper.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvPaperEN.StuScore = TransNullToFloat(objDT.Rows[0][convPaper.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objvPaperEN.TeaScore = TransNullToFloat(objDT.Rows[0][convPaper.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objvPaperEN.PaperTypeId = objDT.Rows[0][convPaper.PaperTypeId].ToString().Trim(); //论文类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvPaperEN.PaperTypeName = objDT.Rows[0][convPaper.PaperTypeName].ToString().Trim(); //论文类型名(字段类型:varchar,字段长度:50,是否可空:True)
 objvPaperEN.PaperStatusId = objDT.Rows[0][convPaper.PaperStatusId].ToString().Trim(); //论文状态Id(字段类型:char,字段长度:2,是否可空:False)
 objvPaperEN.PaperStatusName = objDT.Rows[0][convPaper.PaperStatusName].ToString().Trim(); //论文状态名(字段类型:varchar,字段长度:50,是否可空:True)
 objvPaperEN.VersionCount = TransNullToInt(objDT.Rows[0][convPaper.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objvPaperEN.IsPublic = TransNullToBool(objDT.Rows[0][convPaper.IsPublic].ToString().Trim()); //是否公开(字段类型:bit,字段长度:1,是否可空:True)
 objvPaperEN.AskQuestion = objDT.Rows[0][convPaper.AskQuestion].ToString().Trim(); //问题提出(字段类型:varchar,字段长度:5000,是否可空:True)
 objvPaperEN.ResearchStatus = objDT.Rows[0][convPaper.ResearchStatus].ToString().Trim(); //目前研究的现状(字段类型:varchar,字段长度:5000,是否可空:True)
 objvPaperEN.InnovationPoints = objDT.Rows[0][convPaper.InnovationPoints].ToString().Trim(); //创新点(字段类型:varchar,字段长度:5000,是否可空:True)
 objvPaperEN.ResearchDesign = objDT.Rows[0][convPaper.ResearchDesign].ToString().Trim(); //研究设计(字段类型:varchar,字段长度:5000,是否可空:True)
 objvPaperEN.DimensionDataProcess = objDT.Rows[0][convPaper.DimensionDataProcess].ToString().Trim(); //数据处理的维度(字段类型:varchar,字段长度:5000,是否可空:True)
 objvPaperEN.ExpectedConclusion = objDT.Rows[0][convPaper.ExpectedConclusion].ToString().Trim(); //预期结论(字段类型:varchar,字段长度:5000,是否可空:True)
 objvPaperEN.ShareId = objDT.Rows[0][convPaper.ShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objvPaperEN.PaperQCount = TransNullToInt(objDT.Rows[0][convPaper.PaperQCount].ToString().Trim()); //论文答疑数(字段类型:int,字段长度:4,是否可空:True)
 objvPaperEN.SubVCount = TransNullToInt(objDT.Rows[0][convPaper.SubVCount].ToString().Trim()); //论文子观点数(字段类型:int,字段长度:4,是否可空:True)
 objvPaperEN.TagsCount = TransNullToInt(objDT.Rows[0][convPaper.TagsCount].ToString().Trim()); //论文标注数(字段类型:int,字段长度:4,是否可空:True)
 objvPaperEN.TeaQCount = TransNullToInt(objDT.Rows[0][convPaper.TeaQCount].ToString().Trim()); //教师提问数(字段类型:int,字段长度:4,是否可空:True)
 objvPaperEN.CreateDate = objDT.Rows[0][convPaper.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvPaperEN.UpdUser = objDT.Rows[0][convPaper.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvPaperEN.UserName = objDT.Rows[0][convPaper.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvPaperEN.IdXzCollege = objDT.Rows[0][convPaper.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvPaperEN.UpdDate = objDT.Rows[0][convPaper.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvPaperEN.Memo = objDT.Rows[0][convPaper.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvPaperDA: GetvPaper)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strPaperId">表关键字</param>
 /// <returns>表对象</returns>
public clsvPaperEN GetObjByPaperId(string strPaperId)
{
CheckPrimaryKey(strPaperId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperDA.GetSpecSQLObj();
strSQL = "Select * from vPaper where PaperId = " + "'"+ strPaperId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvPaperEN objvPaperEN = new clsvPaperEN();
try
{
 objvPaperEN.PaperId = objRow[convPaper.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objvPaperEN.PaperTitle = objRow[convPaper.PaperTitle].ToString().Trim(); //论文标题(字段类型:varchar,字段长度:500,是否可空:False)
 objvPaperEN.PaperContent = objRow[convPaper.PaperContent] == DBNull.Value ? null : objRow[convPaper.PaperContent].ToString().Trim(); //主题内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvPaperEN.Periodical = objRow[convPaper.Periodical] == DBNull.Value ? null : objRow[convPaper.Periodical].ToString().Trim(); //期刊(字段类型:varchar,字段长度:100,是否可空:True)
 objvPaperEN.Author = objRow[convPaper.Author] == DBNull.Value ? null : objRow[convPaper.Author].ToString().Trim(); //作者(字段类型:varchar,字段长度:200,是否可空:True)
 objvPaperEN.ResearchQuestion = objRow[convPaper.ResearchQuestion] == DBNull.Value ? null : objRow[convPaper.ResearchQuestion].ToString().Trim(); //研究问题(字段类型:varchar,字段长度:2000,是否可空:True)
 objvPaperEN.Keyword = objRow[convPaper.Keyword] == DBNull.Value ? null : objRow[convPaper.Keyword].ToString().Trim(); //关键字(字段类型:varchar,字段长度:1000,是否可空:True)
 objvPaperEN.LiteratureSources = objRow[convPaper.LiteratureSources] == DBNull.Value ? null : objRow[convPaper.LiteratureSources].ToString().Trim(); //文献来源(字段类型:varchar,字段长度:1000,是否可空:True)
 objvPaperEN.LiteratureLink = objRow[convPaper.LiteratureLink] == DBNull.Value ? null : objRow[convPaper.LiteratureLink].ToString().Trim(); //文献链接(字段类型:varchar,字段长度:1000,是否可空:True)
 objvPaperEN.UploadfileUrl = objRow[convPaper.UploadfileUrl] == DBNull.Value ? null : objRow[convPaper.UploadfileUrl].ToString().Trim(); //文件地址(字段类型:varchar,字段长度:1000,是否可空:True)
 objvPaperEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[convPaper.IsQuotethesis].ToString().Trim()); //是否引用论文(字段类型:bit,字段长度:1,是否可空:True)
 objvPaperEN.QuoteId = objRow[convPaper.QuoteId] == DBNull.Value ? null : objRow[convPaper.QuoteId].ToString().Trim(); //引用Id(字段类型:char,字段长度:8,是否可空:True)
 objvPaperEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convPaper.IsChecked].ToString().Trim()); //是否检查(字段类型:bit,字段长度:1,是否可空:True)
 objvPaperEN.Checker = objRow[convPaper.Checker] == DBNull.Value ? null : objRow[convPaper.Checker].ToString().Trim(); //审核人(字段类型:varchar,字段长度:20,是否可空:True)
 objvPaperEN.LiteratureTypeId = objRow[convPaper.LiteratureTypeId].ToString().Trim(); //作文类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvPaperEN.LiteratureTypeName = objRow[convPaper.LiteratureTypeName] == DBNull.Value ? null : objRow[convPaper.LiteratureTypeName].ToString().Trim(); //作文类型名(字段类型:varchar,字段长度:100,是否可空:True)
 objvPaperEN.BrowseNumber = objRow[convPaper.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.BrowseNumber].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvPaperEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convPaper.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvPaperEN.AppraiseCount = objRow[convPaper.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objvPaperEN.AttachmentCount = objRow[convPaper.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.AttachmentCount].ToString().Trim()); //附件计数(字段类型:int,字段长度:4,是否可空:True)
 objvPaperEN.CollectionCount = objRow[convPaper.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvPaperEN.DownloadCount = objRow[convPaper.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.DownloadCount].ToString().Trim()); //下载数(字段类型:int,字段长度:4,是否可空:True)
 objvPaperEN.OkCount = objRow[convPaper.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objvPaperEN.Pcount = objRow[convPaper.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.Pcount].ToString().Trim()); //读写数(字段类型:int,字段长度:4,是否可空:True)
 objvPaperEN.Score = objRow[convPaper.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaper.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvPaperEN.StuScore = objRow[convPaper.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaper.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objvPaperEN.TeaScore = objRow[convPaper.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaper.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objvPaperEN.PaperTypeId = objRow[convPaper.PaperTypeId] == DBNull.Value ? null : objRow[convPaper.PaperTypeId].ToString().Trim(); //论文类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvPaperEN.PaperTypeName = objRow[convPaper.PaperTypeName] == DBNull.Value ? null : objRow[convPaper.PaperTypeName].ToString().Trim(); //论文类型名(字段类型:varchar,字段长度:50,是否可空:True)
 objvPaperEN.PaperStatusId = objRow[convPaper.PaperStatusId] == DBNull.Value ? null : objRow[convPaper.PaperStatusId].ToString().Trim(); //论文状态Id(字段类型:char,字段长度:2,是否可空:False)
 objvPaperEN.PaperStatusName = objRow[convPaper.PaperStatusName] == DBNull.Value ? null : objRow[convPaper.PaperStatusName].ToString().Trim(); //论文状态名(字段类型:varchar,字段长度:50,是否可空:True)
 objvPaperEN.VersionCount = objRow[convPaper.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objvPaperEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convPaper.IsPublic].ToString().Trim()); //是否公开(字段类型:bit,字段长度:1,是否可空:True)
 objvPaperEN.AskQuestion = objRow[convPaper.AskQuestion] == DBNull.Value ? null : objRow[convPaper.AskQuestion].ToString().Trim(); //问题提出(字段类型:varchar,字段长度:5000,是否可空:True)
 objvPaperEN.ResearchStatus = objRow[convPaper.ResearchStatus] == DBNull.Value ? null : objRow[convPaper.ResearchStatus].ToString().Trim(); //目前研究的现状(字段类型:varchar,字段长度:5000,是否可空:True)
 objvPaperEN.InnovationPoints = objRow[convPaper.InnovationPoints] == DBNull.Value ? null : objRow[convPaper.InnovationPoints].ToString().Trim(); //创新点(字段类型:varchar,字段长度:5000,是否可空:True)
 objvPaperEN.ResearchDesign = objRow[convPaper.ResearchDesign] == DBNull.Value ? null : objRow[convPaper.ResearchDesign].ToString().Trim(); //研究设计(字段类型:varchar,字段长度:5000,是否可空:True)
 objvPaperEN.DimensionDataProcess = objRow[convPaper.DimensionDataProcess] == DBNull.Value ? null : objRow[convPaper.DimensionDataProcess].ToString().Trim(); //数据处理的维度(字段类型:varchar,字段长度:5000,是否可空:True)
 objvPaperEN.ExpectedConclusion = objRow[convPaper.ExpectedConclusion] == DBNull.Value ? null : objRow[convPaper.ExpectedConclusion].ToString().Trim(); //预期结论(字段类型:varchar,字段长度:5000,是否可空:True)
 objvPaperEN.ShareId = objRow[convPaper.ShareId] == DBNull.Value ? null : objRow[convPaper.ShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objvPaperEN.PaperQCount = objRow[convPaper.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.PaperQCount].ToString().Trim()); //论文答疑数(字段类型:int,字段长度:4,是否可空:True)
 objvPaperEN.SubVCount = objRow[convPaper.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.SubVCount].ToString().Trim()); //论文子观点数(字段类型:int,字段长度:4,是否可空:True)
 objvPaperEN.TagsCount = objRow[convPaper.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.TagsCount].ToString().Trim()); //论文标注数(字段类型:int,字段长度:4,是否可空:True)
 objvPaperEN.TeaQCount = objRow[convPaper.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.TeaQCount].ToString().Trim()); //教师提问数(字段类型:int,字段长度:4,是否可空:True)
 objvPaperEN.CreateDate = objRow[convPaper.CreateDate] == DBNull.Value ? null : objRow[convPaper.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvPaperEN.UpdUser = objRow[convPaper.UpdUser] == DBNull.Value ? null : objRow[convPaper.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvPaperEN.UserName = objRow[convPaper.UserName] == DBNull.Value ? null : objRow[convPaper.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvPaperEN.IdXzCollege = objRow[convPaper.IdXzCollege] == DBNull.Value ? null : objRow[convPaper.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvPaperEN.UpdDate = objRow[convPaper.UpdDate] == DBNull.Value ? null : objRow[convPaper.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvPaperEN.Memo = objRow[convPaper.Memo] == DBNull.Value ? null : objRow[convPaper.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvPaperDA: GetObjByPaperId)", objException.Message));
}
return objvPaperEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvPaperEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvPaperDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperDA.GetSpecSQLObj();
strSQL = "Select * from vPaper where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvPaperEN objvPaperEN = new clsvPaperEN()
{
PaperId = objRow[convPaper.PaperId].ToString().Trim(), //论文Id
PaperTitle = objRow[convPaper.PaperTitle].ToString().Trim(), //论文标题
PaperContent = objRow[convPaper.PaperContent] == DBNull.Value ? null : objRow[convPaper.PaperContent].ToString().Trim(), //主题内容
Periodical = objRow[convPaper.Periodical] == DBNull.Value ? null : objRow[convPaper.Periodical].ToString().Trim(), //期刊
Author = objRow[convPaper.Author] == DBNull.Value ? null : objRow[convPaper.Author].ToString().Trim(), //作者
ResearchQuestion = objRow[convPaper.ResearchQuestion] == DBNull.Value ? null : objRow[convPaper.ResearchQuestion].ToString().Trim(), //研究问题
Keyword = objRow[convPaper.Keyword] == DBNull.Value ? null : objRow[convPaper.Keyword].ToString().Trim(), //关键字
LiteratureSources = objRow[convPaper.LiteratureSources] == DBNull.Value ? null : objRow[convPaper.LiteratureSources].ToString().Trim(), //文献来源
LiteratureLink = objRow[convPaper.LiteratureLink] == DBNull.Value ? null : objRow[convPaper.LiteratureLink].ToString().Trim(), //文献链接
UploadfileUrl = objRow[convPaper.UploadfileUrl] == DBNull.Value ? null : objRow[convPaper.UploadfileUrl].ToString().Trim(), //文件地址
IsQuotethesis = TransNullToBool(objRow[convPaper.IsQuotethesis].ToString().Trim()), //是否引用论文
QuoteId = objRow[convPaper.QuoteId] == DBNull.Value ? null : objRow[convPaper.QuoteId].ToString().Trim(), //引用Id
IsChecked = TransNullToBool(objRow[convPaper.IsChecked].ToString().Trim()), //是否检查
Checker = objRow[convPaper.Checker] == DBNull.Value ? null : objRow[convPaper.Checker].ToString().Trim(), //审核人
LiteratureTypeId = objRow[convPaper.LiteratureTypeId].ToString().Trim(), //作文类型Id
LiteratureTypeName = objRow[convPaper.LiteratureTypeName] == DBNull.Value ? null : objRow[convPaper.LiteratureTypeName].ToString().Trim(), //作文类型名
BrowseNumber = objRow[convPaper.BrowseNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaper.BrowseNumber].ToString().Trim()), //浏览量
IsSubmit = TransNullToBool(objRow[convPaper.IsSubmit].ToString().Trim()), //是否提交
AppraiseCount = objRow[convPaper.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaper.AppraiseCount].ToString().Trim()), //评论数
AttachmentCount = objRow[convPaper.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaper.AttachmentCount].ToString().Trim()), //附件计数
CollectionCount = objRow[convPaper.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convPaper.CollectionCount].ToString().Trim()), //收藏数量
DownloadCount = objRow[convPaper.DownloadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaper.DownloadCount].ToString().Trim()), //下载数
OkCount = objRow[convPaper.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaper.OkCount].ToString().Trim()), //点赞统计
Pcount = objRow[convPaper.Pcount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaper.Pcount].ToString().Trim()), //读写数
Score = objRow[convPaper.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPaper.Score].ToString().Trim()), //评分
StuScore = objRow[convPaper.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPaper.StuScore].ToString().Trim()), //学生平均分
TeaScore = objRow[convPaper.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPaper.TeaScore].ToString().Trim()), //教师评分
PaperTypeId = objRow[convPaper.PaperTypeId] == DBNull.Value ? null : objRow[convPaper.PaperTypeId].ToString().Trim(), //论文类型Id
PaperTypeName = objRow[convPaper.PaperTypeName] == DBNull.Value ? null : objRow[convPaper.PaperTypeName].ToString().Trim(), //论文类型名
PaperStatusId = objRow[convPaper.PaperStatusId] == DBNull.Value ? null : objRow[convPaper.PaperStatusId].ToString().Trim(), //论文状态Id
PaperStatusName = objRow[convPaper.PaperStatusName] == DBNull.Value ? null : objRow[convPaper.PaperStatusName].ToString().Trim(), //论文状态名
VersionCount = objRow[convPaper.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaper.VersionCount].ToString().Trim()), //版本统计
IsPublic = TransNullToBool(objRow[convPaper.IsPublic].ToString().Trim()), //是否公开
AskQuestion = objRow[convPaper.AskQuestion] == DBNull.Value ? null : objRow[convPaper.AskQuestion].ToString().Trim(), //问题提出
ResearchStatus = objRow[convPaper.ResearchStatus] == DBNull.Value ? null : objRow[convPaper.ResearchStatus].ToString().Trim(), //目前研究的现状
InnovationPoints = objRow[convPaper.InnovationPoints] == DBNull.Value ? null : objRow[convPaper.InnovationPoints].ToString().Trim(), //创新点
ResearchDesign = objRow[convPaper.ResearchDesign] == DBNull.Value ? null : objRow[convPaper.ResearchDesign].ToString().Trim(), //研究设计
DimensionDataProcess = objRow[convPaper.DimensionDataProcess] == DBNull.Value ? null : objRow[convPaper.DimensionDataProcess].ToString().Trim(), //数据处理的维度
ExpectedConclusion = objRow[convPaper.ExpectedConclusion] == DBNull.Value ? null : objRow[convPaper.ExpectedConclusion].ToString().Trim(), //预期结论
ShareId = objRow[convPaper.ShareId] == DBNull.Value ? null : objRow[convPaper.ShareId].ToString().Trim(), //分享Id
PaperQCount = objRow[convPaper.PaperQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaper.PaperQCount].ToString().Trim()), //论文答疑数
SubVCount = objRow[convPaper.SubVCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaper.SubVCount].ToString().Trim()), //论文子观点数
TagsCount = objRow[convPaper.TagsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaper.TagsCount].ToString().Trim()), //论文标注数
TeaQCount = objRow[convPaper.TeaQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaper.TeaQCount].ToString().Trim()), //教师提问数
CreateDate = objRow[convPaper.CreateDate] == DBNull.Value ? null : objRow[convPaper.CreateDate].ToString().Trim(), //建立日期
UpdUser = objRow[convPaper.UpdUser] == DBNull.Value ? null : objRow[convPaper.UpdUser].ToString().Trim(), //修改人
UserName = objRow[convPaper.UserName] == DBNull.Value ? null : objRow[convPaper.UserName].ToString().Trim(), //用户名
IdXzCollege = objRow[convPaper.IdXzCollege] == DBNull.Value ? null : objRow[convPaper.IdXzCollege].ToString().Trim(), //学院流水号
UpdDate = objRow[convPaper.UpdDate] == DBNull.Value ? null : objRow[convPaper.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[convPaper.Memo] == DBNull.Value ? null : objRow[convPaper.Memo].ToString().Trim() //备注
};
objvPaperEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPaperEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvPaperDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvPaperEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvPaperEN objvPaperEN = new clsvPaperEN();
try
{
objvPaperEN.PaperId = objRow[convPaper.PaperId].ToString().Trim(); //论文Id
objvPaperEN.PaperTitle = objRow[convPaper.PaperTitle].ToString().Trim(); //论文标题
objvPaperEN.PaperContent = objRow[convPaper.PaperContent] == DBNull.Value ? null : objRow[convPaper.PaperContent].ToString().Trim(); //主题内容
objvPaperEN.Periodical = objRow[convPaper.Periodical] == DBNull.Value ? null : objRow[convPaper.Periodical].ToString().Trim(); //期刊
objvPaperEN.Author = objRow[convPaper.Author] == DBNull.Value ? null : objRow[convPaper.Author].ToString().Trim(); //作者
objvPaperEN.ResearchQuestion = objRow[convPaper.ResearchQuestion] == DBNull.Value ? null : objRow[convPaper.ResearchQuestion].ToString().Trim(); //研究问题
objvPaperEN.Keyword = objRow[convPaper.Keyword] == DBNull.Value ? null : objRow[convPaper.Keyword].ToString().Trim(); //关键字
objvPaperEN.LiteratureSources = objRow[convPaper.LiteratureSources] == DBNull.Value ? null : objRow[convPaper.LiteratureSources].ToString().Trim(); //文献来源
objvPaperEN.LiteratureLink = objRow[convPaper.LiteratureLink] == DBNull.Value ? null : objRow[convPaper.LiteratureLink].ToString().Trim(); //文献链接
objvPaperEN.UploadfileUrl = objRow[convPaper.UploadfileUrl] == DBNull.Value ? null : objRow[convPaper.UploadfileUrl].ToString().Trim(); //文件地址
objvPaperEN.IsQuotethesis = TransNullToBool(objRow[convPaper.IsQuotethesis].ToString().Trim()); //是否引用论文
objvPaperEN.QuoteId = objRow[convPaper.QuoteId] == DBNull.Value ? null : objRow[convPaper.QuoteId].ToString().Trim(); //引用Id
objvPaperEN.IsChecked = TransNullToBool(objRow[convPaper.IsChecked].ToString().Trim()); //是否检查
objvPaperEN.Checker = objRow[convPaper.Checker] == DBNull.Value ? null : objRow[convPaper.Checker].ToString().Trim(); //审核人
objvPaperEN.LiteratureTypeId = objRow[convPaper.LiteratureTypeId].ToString().Trim(); //作文类型Id
objvPaperEN.LiteratureTypeName = objRow[convPaper.LiteratureTypeName] == DBNull.Value ? null : objRow[convPaper.LiteratureTypeName].ToString().Trim(); //作文类型名
objvPaperEN.BrowseNumber = objRow[convPaper.BrowseNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaper.BrowseNumber].ToString().Trim()); //浏览量
objvPaperEN.IsSubmit = TransNullToBool(objRow[convPaper.IsSubmit].ToString().Trim()); //是否提交
objvPaperEN.AppraiseCount = objRow[convPaper.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaper.AppraiseCount].ToString().Trim()); //评论数
objvPaperEN.AttachmentCount = objRow[convPaper.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaper.AttachmentCount].ToString().Trim()); //附件计数
objvPaperEN.CollectionCount = objRow[convPaper.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convPaper.CollectionCount].ToString().Trim()); //收藏数量
objvPaperEN.DownloadCount = objRow[convPaper.DownloadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaper.DownloadCount].ToString().Trim()); //下载数
objvPaperEN.OkCount = objRow[convPaper.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaper.OkCount].ToString().Trim()); //点赞统计
objvPaperEN.Pcount = objRow[convPaper.Pcount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaper.Pcount].ToString().Trim()); //读写数
objvPaperEN.Score = objRow[convPaper.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPaper.Score].ToString().Trim()); //评分
objvPaperEN.StuScore = objRow[convPaper.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPaper.StuScore].ToString().Trim()); //学生平均分
objvPaperEN.TeaScore = objRow[convPaper.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPaper.TeaScore].ToString().Trim()); //教师评分
objvPaperEN.PaperTypeId = objRow[convPaper.PaperTypeId] == DBNull.Value ? null : objRow[convPaper.PaperTypeId].ToString().Trim(); //论文类型Id
objvPaperEN.PaperTypeName = objRow[convPaper.PaperTypeName] == DBNull.Value ? null : objRow[convPaper.PaperTypeName].ToString().Trim(); //论文类型名
objvPaperEN.PaperStatusId = objRow[convPaper.PaperStatusId] == DBNull.Value ? null : objRow[convPaper.PaperStatusId].ToString().Trim(); //论文状态Id
objvPaperEN.PaperStatusName = objRow[convPaper.PaperStatusName] == DBNull.Value ? null : objRow[convPaper.PaperStatusName].ToString().Trim(); //论文状态名
objvPaperEN.VersionCount = objRow[convPaper.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaper.VersionCount].ToString().Trim()); //版本统计
objvPaperEN.IsPublic = TransNullToBool(objRow[convPaper.IsPublic].ToString().Trim()); //是否公开
objvPaperEN.AskQuestion = objRow[convPaper.AskQuestion] == DBNull.Value ? null : objRow[convPaper.AskQuestion].ToString().Trim(); //问题提出
objvPaperEN.ResearchStatus = objRow[convPaper.ResearchStatus] == DBNull.Value ? null : objRow[convPaper.ResearchStatus].ToString().Trim(); //目前研究的现状
objvPaperEN.InnovationPoints = objRow[convPaper.InnovationPoints] == DBNull.Value ? null : objRow[convPaper.InnovationPoints].ToString().Trim(); //创新点
objvPaperEN.ResearchDesign = objRow[convPaper.ResearchDesign] == DBNull.Value ? null : objRow[convPaper.ResearchDesign].ToString().Trim(); //研究设计
objvPaperEN.DimensionDataProcess = objRow[convPaper.DimensionDataProcess] == DBNull.Value ? null : objRow[convPaper.DimensionDataProcess].ToString().Trim(); //数据处理的维度
objvPaperEN.ExpectedConclusion = objRow[convPaper.ExpectedConclusion] == DBNull.Value ? null : objRow[convPaper.ExpectedConclusion].ToString().Trim(); //预期结论
objvPaperEN.ShareId = objRow[convPaper.ShareId] == DBNull.Value ? null : objRow[convPaper.ShareId].ToString().Trim(); //分享Id
objvPaperEN.PaperQCount = objRow[convPaper.PaperQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaper.PaperQCount].ToString().Trim()); //论文答疑数
objvPaperEN.SubVCount = objRow[convPaper.SubVCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaper.SubVCount].ToString().Trim()); //论文子观点数
objvPaperEN.TagsCount = objRow[convPaper.TagsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaper.TagsCount].ToString().Trim()); //论文标注数
objvPaperEN.TeaQCount = objRow[convPaper.TeaQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaper.TeaQCount].ToString().Trim()); //教师提问数
objvPaperEN.CreateDate = objRow[convPaper.CreateDate] == DBNull.Value ? null : objRow[convPaper.CreateDate].ToString().Trim(); //建立日期
objvPaperEN.UpdUser = objRow[convPaper.UpdUser] == DBNull.Value ? null : objRow[convPaper.UpdUser].ToString().Trim(); //修改人
objvPaperEN.UserName = objRow[convPaper.UserName] == DBNull.Value ? null : objRow[convPaper.UserName].ToString().Trim(); //用户名
objvPaperEN.IdXzCollege = objRow[convPaper.IdXzCollege] == DBNull.Value ? null : objRow[convPaper.IdXzCollege].ToString().Trim(); //学院流水号
objvPaperEN.UpdDate = objRow[convPaper.UpdDate] == DBNull.Value ? null : objRow[convPaper.UpdDate].ToString().Trim(); //修改日期
objvPaperEN.Memo = objRow[convPaper.Memo] == DBNull.Value ? null : objRow[convPaper.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvPaperDA: GetObjByDataRowvPaper)", objException.Message));
}
objvPaperEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPaperEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvPaperEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvPaperEN objvPaperEN = new clsvPaperEN();
try
{
objvPaperEN.PaperId = objRow[convPaper.PaperId].ToString().Trim(); //论文Id
objvPaperEN.PaperTitle = objRow[convPaper.PaperTitle].ToString().Trim(); //论文标题
objvPaperEN.PaperContent = objRow[convPaper.PaperContent] == DBNull.Value ? null : objRow[convPaper.PaperContent].ToString().Trim(); //主题内容
objvPaperEN.Periodical = objRow[convPaper.Periodical] == DBNull.Value ? null : objRow[convPaper.Periodical].ToString().Trim(); //期刊
objvPaperEN.Author = objRow[convPaper.Author] == DBNull.Value ? null : objRow[convPaper.Author].ToString().Trim(); //作者
objvPaperEN.ResearchQuestion = objRow[convPaper.ResearchQuestion] == DBNull.Value ? null : objRow[convPaper.ResearchQuestion].ToString().Trim(); //研究问题
objvPaperEN.Keyword = objRow[convPaper.Keyword] == DBNull.Value ? null : objRow[convPaper.Keyword].ToString().Trim(); //关键字
objvPaperEN.LiteratureSources = objRow[convPaper.LiteratureSources] == DBNull.Value ? null : objRow[convPaper.LiteratureSources].ToString().Trim(); //文献来源
objvPaperEN.LiteratureLink = objRow[convPaper.LiteratureLink] == DBNull.Value ? null : objRow[convPaper.LiteratureLink].ToString().Trim(); //文献链接
objvPaperEN.UploadfileUrl = objRow[convPaper.UploadfileUrl] == DBNull.Value ? null : objRow[convPaper.UploadfileUrl].ToString().Trim(); //文件地址
objvPaperEN.IsQuotethesis = TransNullToBool(objRow[convPaper.IsQuotethesis].ToString().Trim()); //是否引用论文
objvPaperEN.QuoteId = objRow[convPaper.QuoteId] == DBNull.Value ? null : objRow[convPaper.QuoteId].ToString().Trim(); //引用Id
objvPaperEN.IsChecked = TransNullToBool(objRow[convPaper.IsChecked].ToString().Trim()); //是否检查
objvPaperEN.Checker = objRow[convPaper.Checker] == DBNull.Value ? null : objRow[convPaper.Checker].ToString().Trim(); //审核人
objvPaperEN.LiteratureTypeId = objRow[convPaper.LiteratureTypeId].ToString().Trim(); //作文类型Id
objvPaperEN.LiteratureTypeName = objRow[convPaper.LiteratureTypeName] == DBNull.Value ? null : objRow[convPaper.LiteratureTypeName].ToString().Trim(); //作文类型名
objvPaperEN.BrowseNumber = objRow[convPaper.BrowseNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaper.BrowseNumber].ToString().Trim()); //浏览量
objvPaperEN.IsSubmit = TransNullToBool(objRow[convPaper.IsSubmit].ToString().Trim()); //是否提交
objvPaperEN.AppraiseCount = objRow[convPaper.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaper.AppraiseCount].ToString().Trim()); //评论数
objvPaperEN.AttachmentCount = objRow[convPaper.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaper.AttachmentCount].ToString().Trim()); //附件计数
objvPaperEN.CollectionCount = objRow[convPaper.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convPaper.CollectionCount].ToString().Trim()); //收藏数量
objvPaperEN.DownloadCount = objRow[convPaper.DownloadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaper.DownloadCount].ToString().Trim()); //下载数
objvPaperEN.OkCount = objRow[convPaper.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaper.OkCount].ToString().Trim()); //点赞统计
objvPaperEN.Pcount = objRow[convPaper.Pcount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaper.Pcount].ToString().Trim()); //读写数
objvPaperEN.Score = objRow[convPaper.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPaper.Score].ToString().Trim()); //评分
objvPaperEN.StuScore = objRow[convPaper.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPaper.StuScore].ToString().Trim()); //学生平均分
objvPaperEN.TeaScore = objRow[convPaper.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPaper.TeaScore].ToString().Trim()); //教师评分
objvPaperEN.PaperTypeId = objRow[convPaper.PaperTypeId] == DBNull.Value ? null : objRow[convPaper.PaperTypeId].ToString().Trim(); //论文类型Id
objvPaperEN.PaperTypeName = objRow[convPaper.PaperTypeName] == DBNull.Value ? null : objRow[convPaper.PaperTypeName].ToString().Trim(); //论文类型名
objvPaperEN.PaperStatusId = objRow[convPaper.PaperStatusId] == DBNull.Value ? null : objRow[convPaper.PaperStatusId].ToString().Trim(); //论文状态Id
objvPaperEN.PaperStatusName = objRow[convPaper.PaperStatusName] == DBNull.Value ? null : objRow[convPaper.PaperStatusName].ToString().Trim(); //论文状态名
objvPaperEN.VersionCount = objRow[convPaper.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaper.VersionCount].ToString().Trim()); //版本统计
objvPaperEN.IsPublic = TransNullToBool(objRow[convPaper.IsPublic].ToString().Trim()); //是否公开
objvPaperEN.AskQuestion = objRow[convPaper.AskQuestion] == DBNull.Value ? null : objRow[convPaper.AskQuestion].ToString().Trim(); //问题提出
objvPaperEN.ResearchStatus = objRow[convPaper.ResearchStatus] == DBNull.Value ? null : objRow[convPaper.ResearchStatus].ToString().Trim(); //目前研究的现状
objvPaperEN.InnovationPoints = objRow[convPaper.InnovationPoints] == DBNull.Value ? null : objRow[convPaper.InnovationPoints].ToString().Trim(); //创新点
objvPaperEN.ResearchDesign = objRow[convPaper.ResearchDesign] == DBNull.Value ? null : objRow[convPaper.ResearchDesign].ToString().Trim(); //研究设计
objvPaperEN.DimensionDataProcess = objRow[convPaper.DimensionDataProcess] == DBNull.Value ? null : objRow[convPaper.DimensionDataProcess].ToString().Trim(); //数据处理的维度
objvPaperEN.ExpectedConclusion = objRow[convPaper.ExpectedConclusion] == DBNull.Value ? null : objRow[convPaper.ExpectedConclusion].ToString().Trim(); //预期结论
objvPaperEN.ShareId = objRow[convPaper.ShareId] == DBNull.Value ? null : objRow[convPaper.ShareId].ToString().Trim(); //分享Id
objvPaperEN.PaperQCount = objRow[convPaper.PaperQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaper.PaperQCount].ToString().Trim()); //论文答疑数
objvPaperEN.SubVCount = objRow[convPaper.SubVCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaper.SubVCount].ToString().Trim()); //论文子观点数
objvPaperEN.TagsCount = objRow[convPaper.TagsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaper.TagsCount].ToString().Trim()); //论文标注数
objvPaperEN.TeaQCount = objRow[convPaper.TeaQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaper.TeaQCount].ToString().Trim()); //教师提问数
objvPaperEN.CreateDate = objRow[convPaper.CreateDate] == DBNull.Value ? null : objRow[convPaper.CreateDate].ToString().Trim(); //建立日期
objvPaperEN.UpdUser = objRow[convPaper.UpdUser] == DBNull.Value ? null : objRow[convPaper.UpdUser].ToString().Trim(); //修改人
objvPaperEN.UserName = objRow[convPaper.UserName] == DBNull.Value ? null : objRow[convPaper.UserName].ToString().Trim(); //用户名
objvPaperEN.IdXzCollege = objRow[convPaper.IdXzCollege] == DBNull.Value ? null : objRow[convPaper.IdXzCollege].ToString().Trim(); //学院流水号
objvPaperEN.UpdDate = objRow[convPaper.UpdDate] == DBNull.Value ? null : objRow[convPaper.UpdDate].ToString().Trim(); //修改日期
objvPaperEN.Memo = objRow[convPaper.Memo] == DBNull.Value ? null : objRow[convPaper.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvPaperDA: GetObjByDataRow)", objException.Message));
}
objvPaperEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPaperEN;
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
objSQL = clsvPaperDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvPaperEN._CurrTabName, convPaper.PaperId, 8, "");
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
objSQL = clsvPaperDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvPaperEN._CurrTabName, convPaper.PaperId, 8, strPrefix);
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
 objSQL = clsvPaperDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select PaperId from vPaper where " + strCondition;
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
 objSQL = clsvPaperDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select PaperId from vPaper where " + strCondition;
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
 objSQL = clsvPaperDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vPaper", "PaperId = " + "'"+ strPaperId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvPaperDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vPaper", strCondition))
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
objSQL = clsvPaperDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vPaper");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvPaperENS">源对象</param>
 /// <param name = "objvPaperENT">目标对象</param>
public void CopyTo(clsvPaperEN objvPaperENS, clsvPaperEN objvPaperENT)
{
objvPaperENT.PaperId = objvPaperENS.PaperId; //论文Id
objvPaperENT.PaperTitle = objvPaperENS.PaperTitle; //论文标题
objvPaperENT.PaperContent = objvPaperENS.PaperContent; //主题内容
objvPaperENT.Periodical = objvPaperENS.Periodical; //期刊
objvPaperENT.Author = objvPaperENS.Author; //作者
objvPaperENT.ResearchQuestion = objvPaperENS.ResearchQuestion; //研究问题
objvPaperENT.Keyword = objvPaperENS.Keyword; //关键字
objvPaperENT.LiteratureSources = objvPaperENS.LiteratureSources; //文献来源
objvPaperENT.LiteratureLink = objvPaperENS.LiteratureLink; //文献链接
objvPaperENT.UploadfileUrl = objvPaperENS.UploadfileUrl; //文件地址
objvPaperENT.IsQuotethesis = objvPaperENS.IsQuotethesis; //是否引用论文
objvPaperENT.QuoteId = objvPaperENS.QuoteId; //引用Id
objvPaperENT.IsChecked = objvPaperENS.IsChecked; //是否检查
objvPaperENT.Checker = objvPaperENS.Checker; //审核人
objvPaperENT.LiteratureTypeId = objvPaperENS.LiteratureTypeId; //作文类型Id
objvPaperENT.LiteratureTypeName = objvPaperENS.LiteratureTypeName; //作文类型名
objvPaperENT.BrowseNumber = objvPaperENS.BrowseNumber; //浏览量
objvPaperENT.IsSubmit = objvPaperENS.IsSubmit; //是否提交
objvPaperENT.AppraiseCount = objvPaperENS.AppraiseCount; //评论数
objvPaperENT.AttachmentCount = objvPaperENS.AttachmentCount; //附件计数
objvPaperENT.CollectionCount = objvPaperENS.CollectionCount; //收藏数量
objvPaperENT.DownloadCount = objvPaperENS.DownloadCount; //下载数
objvPaperENT.OkCount = objvPaperENS.OkCount; //点赞统计
objvPaperENT.Pcount = objvPaperENS.Pcount; //读写数
objvPaperENT.Score = objvPaperENS.Score; //评分
objvPaperENT.StuScore = objvPaperENS.StuScore; //学生平均分
objvPaperENT.TeaScore = objvPaperENS.TeaScore; //教师评分
objvPaperENT.PaperTypeId = objvPaperENS.PaperTypeId; //论文类型Id
objvPaperENT.PaperTypeName = objvPaperENS.PaperTypeName; //论文类型名
objvPaperENT.PaperStatusId = objvPaperENS.PaperStatusId; //论文状态Id
objvPaperENT.PaperStatusName = objvPaperENS.PaperStatusName; //论文状态名
objvPaperENT.VersionCount = objvPaperENS.VersionCount; //版本统计
objvPaperENT.IsPublic = objvPaperENS.IsPublic; //是否公开
objvPaperENT.AskQuestion = objvPaperENS.AskQuestion; //问题提出
objvPaperENT.ResearchStatus = objvPaperENS.ResearchStatus; //目前研究的现状
objvPaperENT.InnovationPoints = objvPaperENS.InnovationPoints; //创新点
objvPaperENT.ResearchDesign = objvPaperENS.ResearchDesign; //研究设计
objvPaperENT.DimensionDataProcess = objvPaperENS.DimensionDataProcess; //数据处理的维度
objvPaperENT.ExpectedConclusion = objvPaperENS.ExpectedConclusion; //预期结论
objvPaperENT.ShareId = objvPaperENS.ShareId; //分享Id
objvPaperENT.PaperQCount = objvPaperENS.PaperQCount; //论文答疑数
objvPaperENT.SubVCount = objvPaperENS.SubVCount; //论文子观点数
objvPaperENT.TagsCount = objvPaperENS.TagsCount; //论文标注数
objvPaperENT.TeaQCount = objvPaperENS.TeaQCount; //教师提问数
objvPaperENT.CreateDate = objvPaperENS.CreateDate; //建立日期
objvPaperENT.UpdUser = objvPaperENS.UpdUser; //修改人
objvPaperENT.UserName = objvPaperENS.UserName; //用户名
objvPaperENT.IdXzCollege = objvPaperENS.IdXzCollege; //学院流水号
objvPaperENT.UpdDate = objvPaperENS.UpdDate; //修改日期
objvPaperENT.Memo = objvPaperENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvPaperEN objvPaperEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvPaperEN.PaperId, 8, convPaper.PaperId);
clsCheckSql.CheckFieldLen(objvPaperEN.PaperTitle, 500, convPaper.PaperTitle);
clsCheckSql.CheckFieldLen(objvPaperEN.Periodical, 100, convPaper.Periodical);
clsCheckSql.CheckFieldLen(objvPaperEN.Author, 200, convPaper.Author);
clsCheckSql.CheckFieldLen(objvPaperEN.ResearchQuestion, 2000, convPaper.ResearchQuestion);
clsCheckSql.CheckFieldLen(objvPaperEN.Keyword, 1000, convPaper.Keyword);
clsCheckSql.CheckFieldLen(objvPaperEN.LiteratureSources, 1000, convPaper.LiteratureSources);
clsCheckSql.CheckFieldLen(objvPaperEN.LiteratureLink, 1000, convPaper.LiteratureLink);
clsCheckSql.CheckFieldLen(objvPaperEN.UploadfileUrl, 1000, convPaper.UploadfileUrl);
clsCheckSql.CheckFieldLen(objvPaperEN.QuoteId, 8, convPaper.QuoteId);
clsCheckSql.CheckFieldLen(objvPaperEN.Checker, 20, convPaper.Checker);
clsCheckSql.CheckFieldLen(objvPaperEN.LiteratureTypeId, 2, convPaper.LiteratureTypeId);
clsCheckSql.CheckFieldLen(objvPaperEN.LiteratureTypeName, 100, convPaper.LiteratureTypeName);
clsCheckSql.CheckFieldLen(objvPaperEN.PaperTypeId, 2, convPaper.PaperTypeId);
clsCheckSql.CheckFieldLen(objvPaperEN.PaperTypeName, 50, convPaper.PaperTypeName);
clsCheckSql.CheckFieldLen(objvPaperEN.PaperStatusId, 2, convPaper.PaperStatusId);
clsCheckSql.CheckFieldLen(objvPaperEN.PaperStatusName, 50, convPaper.PaperStatusName);
clsCheckSql.CheckFieldLen(objvPaperEN.AskQuestion, 5000, convPaper.AskQuestion);
clsCheckSql.CheckFieldLen(objvPaperEN.ResearchStatus, 5000, convPaper.ResearchStatus);
clsCheckSql.CheckFieldLen(objvPaperEN.InnovationPoints, 5000, convPaper.InnovationPoints);
clsCheckSql.CheckFieldLen(objvPaperEN.ResearchDesign, 5000, convPaper.ResearchDesign);
clsCheckSql.CheckFieldLen(objvPaperEN.DimensionDataProcess, 5000, convPaper.DimensionDataProcess);
clsCheckSql.CheckFieldLen(objvPaperEN.ExpectedConclusion, 5000, convPaper.ExpectedConclusion);
clsCheckSql.CheckFieldLen(objvPaperEN.ShareId, 2, convPaper.ShareId);
clsCheckSql.CheckFieldLen(objvPaperEN.CreateDate, 20, convPaper.CreateDate);
clsCheckSql.CheckFieldLen(objvPaperEN.UpdUser, 20, convPaper.UpdUser);
clsCheckSql.CheckFieldLen(objvPaperEN.UserName, 30, convPaper.UserName);
clsCheckSql.CheckFieldLen(objvPaperEN.IdXzCollege, 4, convPaper.IdXzCollege);
clsCheckSql.CheckFieldLen(objvPaperEN.UpdDate, 20, convPaper.UpdDate);
clsCheckSql.CheckFieldLen(objvPaperEN.Memo, 1000, convPaper.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvPaperEN.PaperId, convPaper.PaperId);
clsCheckSql.CheckSqlInjection4Field(objvPaperEN.PaperTitle, convPaper.PaperTitle);
clsCheckSql.CheckSqlInjection4Field(objvPaperEN.Periodical, convPaper.Periodical);
clsCheckSql.CheckSqlInjection4Field(objvPaperEN.Author, convPaper.Author);
clsCheckSql.CheckSqlInjection4Field(objvPaperEN.ResearchQuestion, convPaper.ResearchQuestion);
clsCheckSql.CheckSqlInjection4Field(objvPaperEN.Keyword, convPaper.Keyword);
clsCheckSql.CheckSqlInjection4Field(objvPaperEN.LiteratureSources, convPaper.LiteratureSources);
clsCheckSql.CheckSqlInjection4Field(objvPaperEN.LiteratureLink, convPaper.LiteratureLink);
clsCheckSql.CheckSqlInjection4Field(objvPaperEN.UploadfileUrl, convPaper.UploadfileUrl);
clsCheckSql.CheckSqlInjection4Field(objvPaperEN.QuoteId, convPaper.QuoteId);
clsCheckSql.CheckSqlInjection4Field(objvPaperEN.Checker, convPaper.Checker);
clsCheckSql.CheckSqlInjection4Field(objvPaperEN.LiteratureTypeId, convPaper.LiteratureTypeId);
clsCheckSql.CheckSqlInjection4Field(objvPaperEN.LiteratureTypeName, convPaper.LiteratureTypeName);
clsCheckSql.CheckSqlInjection4Field(objvPaperEN.PaperTypeId, convPaper.PaperTypeId);
clsCheckSql.CheckSqlInjection4Field(objvPaperEN.PaperTypeName, convPaper.PaperTypeName);
clsCheckSql.CheckSqlInjection4Field(objvPaperEN.PaperStatusId, convPaper.PaperStatusId);
clsCheckSql.CheckSqlInjection4Field(objvPaperEN.PaperStatusName, convPaper.PaperStatusName);
clsCheckSql.CheckSqlInjection4Field(objvPaperEN.AskQuestion, convPaper.AskQuestion);
clsCheckSql.CheckSqlInjection4Field(objvPaperEN.ResearchStatus, convPaper.ResearchStatus);
clsCheckSql.CheckSqlInjection4Field(objvPaperEN.InnovationPoints, convPaper.InnovationPoints);
clsCheckSql.CheckSqlInjection4Field(objvPaperEN.ResearchDesign, convPaper.ResearchDesign);
clsCheckSql.CheckSqlInjection4Field(objvPaperEN.DimensionDataProcess, convPaper.DimensionDataProcess);
clsCheckSql.CheckSqlInjection4Field(objvPaperEN.ExpectedConclusion, convPaper.ExpectedConclusion);
clsCheckSql.CheckSqlInjection4Field(objvPaperEN.ShareId, convPaper.ShareId);
clsCheckSql.CheckSqlInjection4Field(objvPaperEN.CreateDate, convPaper.CreateDate);
clsCheckSql.CheckSqlInjection4Field(objvPaperEN.UpdUser, convPaper.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvPaperEN.UserName, convPaper.UserName);
clsCheckSql.CheckSqlInjection4Field(objvPaperEN.IdXzCollege, convPaper.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvPaperEN.UpdDate, convPaper.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvPaperEN.Memo, convPaper.Memo);
//检查外键字段长度
 objvPaperEN._IsCheckProperty = true;
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
 objSQL = clsvPaperDA.GetSpecSQLObj();
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
 objSQL = clsvPaperDA.GetSpecSQLObj();
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
 objSQL = clsvPaperDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvPaperEN._CurrTabName);
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
 objSQL = clsvPaperDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvPaperEN._CurrTabName, strCondition);
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
 objSQL = clsvPaperDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}