
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvgs_PaperVerDA
 表名:vgs_PaperVer(01120677)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:01:33
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
 /// 论文历史版本视图(vgs_PaperVer)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvgs_PaperVerDA : clsCommBase4DA
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
 return clsvgs_PaperVerEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvgs_PaperVerEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvgs_PaperVerEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvgs_PaperVerEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvgs_PaperVerEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvgs_PaperVerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PaperVerDA.GetSpecSQLObj();
strSQL = "Select * from vgs_PaperVer where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vgs_PaperVer(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvgs_PaperVerDA: GetDataTable_vgs_PaperVer)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PaperVerDA.GetSpecSQLObj();
strSQL = "Select * from vgs_PaperVer where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvgs_PaperVerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PaperVerDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvgs_PaperVerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PaperVerDA.GetSpecSQLObj();
strSQL = "Select * from vgs_PaperVer where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvgs_PaperVerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PaperVerDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvgs_PaperVerDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PaperVerDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vgs_PaperVer where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vgs_PaperVer where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvgs_PaperVerDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PaperVerDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vgs_PaperVer where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvgs_PaperVerDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PaperVerDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vgs_PaperVer.* from vgs_PaperVer Left Join {1} on {2} where {3} and vgs_PaperVer.PaperVId not in (Select top {5} vgs_PaperVer.PaperVId from vgs_PaperVer Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vgs_PaperVer where {1} and PaperVId not in (Select top {2} PaperVId from vgs_PaperVer where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vgs_PaperVer where {1} and PaperVId not in (Select top {3} PaperVId from vgs_PaperVer where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvgs_PaperVerDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PaperVerDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vgs_PaperVer.* from vgs_PaperVer Left Join {1} on {2} where {3} and vgs_PaperVer.PaperVId not in (Select top {5} vgs_PaperVer.PaperVId from vgs_PaperVer Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vgs_PaperVer where {1} and PaperVId not in (Select top {2} PaperVId from vgs_PaperVer where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vgs_PaperVer where {1} and PaperVId not in (Select top {3} PaperVId from vgs_PaperVer where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvgs_PaperVerEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvgs_PaperVerDA:GetObjLst)", objException.Message));
}
List<clsvgs_PaperVerEN> arrObjLst = new List<clsvgs_PaperVerEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PaperVerDA.GetSpecSQLObj();
strSQL = "Select * from vgs_PaperVer where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PaperVerEN objvgs_PaperVerEN = new clsvgs_PaperVerEN();
try
{
objvgs_PaperVerEN.PaperVId = TransNullToInt(objRow[convgs_PaperVer.PaperVId].ToString().Trim()); //PaperVId
objvgs_PaperVerEN.PaperId = objRow[convgs_PaperVer.PaperId].ToString().Trim(); //论文Id
objvgs_PaperVerEN.PaperTitle = objRow[convgs_PaperVer.PaperTitle].ToString().Trim(); //论文标题
objvgs_PaperVerEN.PaperContent = objRow[convgs_PaperVer.PaperContent] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperContent].ToString().Trim(); //主题内容
objvgs_PaperVerEN.Periodical = objRow[convgs_PaperVer.Periodical] == DBNull.Value ? null : objRow[convgs_PaperVer.Periodical].ToString().Trim(); //期刊
objvgs_PaperVerEN.Author = objRow[convgs_PaperVer.Author] == DBNull.Value ? null : objRow[convgs_PaperVer.Author].ToString().Trim(); //作者
objvgs_PaperVerEN.ResearchQuestion = objRow[convgs_PaperVer.ResearchQuestion] == DBNull.Value ? null : objRow[convgs_PaperVer.ResearchQuestion].ToString().Trim(); //研究问题
objvgs_PaperVerEN.Keyword = objRow[convgs_PaperVer.Keyword] == DBNull.Value ? null : objRow[convgs_PaperVer.Keyword].ToString().Trim(); //关键字
objvgs_PaperVerEN.LiteratureSources = objRow[convgs_PaperVer.LiteratureSources] == DBNull.Value ? null : objRow[convgs_PaperVer.LiteratureSources].ToString().Trim(); //文献来源
objvgs_PaperVerEN.LiteratureLink = objRow[convgs_PaperVer.LiteratureLink] == DBNull.Value ? null : objRow[convgs_PaperVer.LiteratureLink].ToString().Trim(); //文献链接
objvgs_PaperVerEN.UploadfileUrl = objRow[convgs_PaperVer.UploadfileUrl] == DBNull.Value ? null : objRow[convgs_PaperVer.UploadfileUrl].ToString().Trim(); //文件地址
objvgs_PaperVerEN.IsQuotethesis = TransNullToBool(objRow[convgs_PaperVer.IsQuotethesis].ToString().Trim()); //是否引用论文
objvgs_PaperVerEN.IsSubmit = TransNullToBool(objRow[convgs_PaperVer.IsSubmit].ToString().Trim()); //是否提交
objvgs_PaperVerEN.IsChecked = TransNullToBool(objRow[convgs_PaperVer.IsChecked].ToString().Trim()); //是否检查
objvgs_PaperVerEN.QuoteId = objRow[convgs_PaperVer.QuoteId] == DBNull.Value ? null : objRow[convgs_PaperVer.QuoteId].ToString().Trim(); //引用Id
objvgs_PaperVerEN.Checker = objRow[convgs_PaperVer.Checker] == DBNull.Value ? null : objRow[convgs_PaperVer.Checker].ToString().Trim(); //审核人
objvgs_PaperVerEN.LiteratureTypeId = objRow[convgs_PaperVer.LiteratureTypeId].ToString().Trim(); //作文类型Id
objvgs_PaperVerEN.LiteratureTypeName = objRow[convgs_PaperVer.LiteratureTypeName] == DBNull.Value ? null : objRow[convgs_PaperVer.LiteratureTypeName].ToString().Trim(); //作文类型名
objvgs_PaperVerEN.UpdUser = objRow[convgs_PaperVer.UpdUser] == DBNull.Value ? null : objRow[convgs_PaperVer.UpdUser].ToString().Trim(); //修改人
objvgs_PaperVerEN.UpdDate = objRow[convgs_PaperVer.UpdDate] == DBNull.Value ? null : objRow[convgs_PaperVer.UpdDate].ToString().Trim(); //修改日期
objvgs_PaperVerEN.IdCurrEduCls = objRow[convgs_PaperVer.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_PaperVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_PaperVerEN.PaperTypeId = objRow[convgs_PaperVer.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PaperVerEN.PaperTypeName = objRow[convgs_PaperVer.PaperTypeName] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperTypeName].ToString().Trim(); //论文类型名
objvgs_PaperVerEN.PaperStatusId = objRow[convgs_PaperVer.PaperStatusId] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperStatusId].ToString().Trim(); //论文状态Id
objvgs_PaperVerEN.PaperStatusName = objRow[convgs_PaperVer.PaperStatusName] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperStatusName].ToString().Trim(); //论文状态名
objvgs_PaperVerEN.Memo = objRow[convgs_PaperVer.Memo] == DBNull.Value ? null : objRow[convgs_PaperVer.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvgs_PaperVerDA: GetObjLst)", objException.Message));
}
objvgs_PaperVerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvgs_PaperVerEN);
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
public List<clsvgs_PaperVerEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvgs_PaperVerDA:GetObjLstByTabName)", objException.Message));
}
List<clsvgs_PaperVerEN> arrObjLst = new List<clsvgs_PaperVerEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PaperVerDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PaperVerEN objvgs_PaperVerEN = new clsvgs_PaperVerEN();
try
{
objvgs_PaperVerEN.PaperVId = TransNullToInt(objRow[convgs_PaperVer.PaperVId].ToString().Trim()); //PaperVId
objvgs_PaperVerEN.PaperId = objRow[convgs_PaperVer.PaperId].ToString().Trim(); //论文Id
objvgs_PaperVerEN.PaperTitle = objRow[convgs_PaperVer.PaperTitle].ToString().Trim(); //论文标题
objvgs_PaperVerEN.PaperContent = objRow[convgs_PaperVer.PaperContent] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperContent].ToString().Trim(); //主题内容
objvgs_PaperVerEN.Periodical = objRow[convgs_PaperVer.Periodical] == DBNull.Value ? null : objRow[convgs_PaperVer.Periodical].ToString().Trim(); //期刊
objvgs_PaperVerEN.Author = objRow[convgs_PaperVer.Author] == DBNull.Value ? null : objRow[convgs_PaperVer.Author].ToString().Trim(); //作者
objvgs_PaperVerEN.ResearchQuestion = objRow[convgs_PaperVer.ResearchQuestion] == DBNull.Value ? null : objRow[convgs_PaperVer.ResearchQuestion].ToString().Trim(); //研究问题
objvgs_PaperVerEN.Keyword = objRow[convgs_PaperVer.Keyword] == DBNull.Value ? null : objRow[convgs_PaperVer.Keyword].ToString().Trim(); //关键字
objvgs_PaperVerEN.LiteratureSources = objRow[convgs_PaperVer.LiteratureSources] == DBNull.Value ? null : objRow[convgs_PaperVer.LiteratureSources].ToString().Trim(); //文献来源
objvgs_PaperVerEN.LiteratureLink = objRow[convgs_PaperVer.LiteratureLink] == DBNull.Value ? null : objRow[convgs_PaperVer.LiteratureLink].ToString().Trim(); //文献链接
objvgs_PaperVerEN.UploadfileUrl = objRow[convgs_PaperVer.UploadfileUrl] == DBNull.Value ? null : objRow[convgs_PaperVer.UploadfileUrl].ToString().Trim(); //文件地址
objvgs_PaperVerEN.IsQuotethesis = TransNullToBool(objRow[convgs_PaperVer.IsQuotethesis].ToString().Trim()); //是否引用论文
objvgs_PaperVerEN.IsSubmit = TransNullToBool(objRow[convgs_PaperVer.IsSubmit].ToString().Trim()); //是否提交
objvgs_PaperVerEN.IsChecked = TransNullToBool(objRow[convgs_PaperVer.IsChecked].ToString().Trim()); //是否检查
objvgs_PaperVerEN.QuoteId = objRow[convgs_PaperVer.QuoteId] == DBNull.Value ? null : objRow[convgs_PaperVer.QuoteId].ToString().Trim(); //引用Id
objvgs_PaperVerEN.Checker = objRow[convgs_PaperVer.Checker] == DBNull.Value ? null : objRow[convgs_PaperVer.Checker].ToString().Trim(); //审核人
objvgs_PaperVerEN.LiteratureTypeId = objRow[convgs_PaperVer.LiteratureTypeId].ToString().Trim(); //作文类型Id
objvgs_PaperVerEN.LiteratureTypeName = objRow[convgs_PaperVer.LiteratureTypeName] == DBNull.Value ? null : objRow[convgs_PaperVer.LiteratureTypeName].ToString().Trim(); //作文类型名
objvgs_PaperVerEN.UpdUser = objRow[convgs_PaperVer.UpdUser] == DBNull.Value ? null : objRow[convgs_PaperVer.UpdUser].ToString().Trim(); //修改人
objvgs_PaperVerEN.UpdDate = objRow[convgs_PaperVer.UpdDate] == DBNull.Value ? null : objRow[convgs_PaperVer.UpdDate].ToString().Trim(); //修改日期
objvgs_PaperVerEN.IdCurrEduCls = objRow[convgs_PaperVer.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_PaperVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_PaperVerEN.PaperTypeId = objRow[convgs_PaperVer.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PaperVerEN.PaperTypeName = objRow[convgs_PaperVer.PaperTypeName] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperTypeName].ToString().Trim(); //论文类型名
objvgs_PaperVerEN.PaperStatusId = objRow[convgs_PaperVer.PaperStatusId] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperStatusId].ToString().Trim(); //论文状态Id
objvgs_PaperVerEN.PaperStatusName = objRow[convgs_PaperVer.PaperStatusName] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperStatusName].ToString().Trim(); //论文状态名
objvgs_PaperVerEN.Memo = objRow[convgs_PaperVer.Memo] == DBNull.Value ? null : objRow[convgs_PaperVer.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvgs_PaperVerDA: GetObjLst)", objException.Message));
}
objvgs_PaperVerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvgs_PaperVerEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvgs_PaperVerEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getvgs_PaperVer(ref clsvgs_PaperVerEN objvgs_PaperVerEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PaperVerDA.GetSpecSQLObj();
strSQL = "Select * from vgs_PaperVer where PaperVId = " + ""+ objvgs_PaperVerEN.PaperVId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvgs_PaperVerEN.PaperVId = TransNullToInt(objDT.Rows[0][convgs_PaperVer.PaperVId].ToString().Trim()); //PaperVId(字段类型:bigint,字段长度:8,是否可空:False)
 objvgs_PaperVerEN.PaperId = objDT.Rows[0][convgs_PaperVer.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objvgs_PaperVerEN.PaperTitle = objDT.Rows[0][convgs_PaperVer.PaperTitle].ToString().Trim(); //论文标题(字段类型:varchar,字段长度:500,是否可空:False)
 objvgs_PaperVerEN.PaperContent = objDT.Rows[0][convgs_PaperVer.PaperContent].ToString().Trim(); //主题内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvgs_PaperVerEN.Periodical = objDT.Rows[0][convgs_PaperVer.Periodical].ToString().Trim(); //期刊(字段类型:varchar,字段长度:100,是否可空:True)
 objvgs_PaperVerEN.Author = objDT.Rows[0][convgs_PaperVer.Author].ToString().Trim(); //作者(字段类型:varchar,字段长度:200,是否可空:True)
 objvgs_PaperVerEN.ResearchQuestion = objDT.Rows[0][convgs_PaperVer.ResearchQuestion].ToString().Trim(); //研究问题(字段类型:varchar,字段长度:2000,是否可空:True)
 objvgs_PaperVerEN.Keyword = objDT.Rows[0][convgs_PaperVer.Keyword].ToString().Trim(); //关键字(字段类型:varchar,字段长度:1000,是否可空:True)
 objvgs_PaperVerEN.LiteratureSources = objDT.Rows[0][convgs_PaperVer.LiteratureSources].ToString().Trim(); //文献来源(字段类型:varchar,字段长度:1000,是否可空:True)
 objvgs_PaperVerEN.LiteratureLink = objDT.Rows[0][convgs_PaperVer.LiteratureLink].ToString().Trim(); //文献链接(字段类型:varchar,字段长度:1000,是否可空:True)
 objvgs_PaperVerEN.UploadfileUrl = objDT.Rows[0][convgs_PaperVer.UploadfileUrl].ToString().Trim(); //文件地址(字段类型:varchar,字段长度:1000,是否可空:True)
 objvgs_PaperVerEN.IsQuotethesis = TransNullToBool(objDT.Rows[0][convgs_PaperVer.IsQuotethesis].ToString().Trim()); //是否引用论文(字段类型:bit,字段长度:1,是否可空:True)
 objvgs_PaperVerEN.IsSubmit = TransNullToBool(objDT.Rows[0][convgs_PaperVer.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvgs_PaperVerEN.IsChecked = TransNullToBool(objDT.Rows[0][convgs_PaperVer.IsChecked].ToString().Trim()); //是否检查(字段类型:bit,字段长度:1,是否可空:True)
 objvgs_PaperVerEN.QuoteId = objDT.Rows[0][convgs_PaperVer.QuoteId].ToString().Trim(); //引用Id(字段类型:char,字段长度:8,是否可空:True)
 objvgs_PaperVerEN.Checker = objDT.Rows[0][convgs_PaperVer.Checker].ToString().Trim(); //审核人(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_PaperVerEN.LiteratureTypeId = objDT.Rows[0][convgs_PaperVer.LiteratureTypeId].ToString().Trim(); //作文类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvgs_PaperVerEN.LiteratureTypeName = objDT.Rows[0][convgs_PaperVer.LiteratureTypeName].ToString().Trim(); //作文类型名(字段类型:varchar,字段长度:100,是否可空:True)
 objvgs_PaperVerEN.UpdUser = objDT.Rows[0][convgs_PaperVer.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_PaperVerEN.UpdDate = objDT.Rows[0][convgs_PaperVer.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_PaperVerEN.IdCurrEduCls = objDT.Rows[0][convgs_PaperVer.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvgs_PaperVerEN.PaperTypeId = objDT.Rows[0][convgs_PaperVer.PaperTypeId].ToString().Trim(); //论文类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvgs_PaperVerEN.PaperTypeName = objDT.Rows[0][convgs_PaperVer.PaperTypeName].ToString().Trim(); //论文类型名(字段类型:varchar,字段长度:50,是否可空:True)
 objvgs_PaperVerEN.PaperStatusId = objDT.Rows[0][convgs_PaperVer.PaperStatusId].ToString().Trim(); //论文状态Id(字段类型:char,字段长度:2,是否可空:False)
 objvgs_PaperVerEN.PaperStatusName = objDT.Rows[0][convgs_PaperVer.PaperStatusName].ToString().Trim(); //论文状态名(字段类型:varchar,字段长度:50,是否可空:True)
 objvgs_PaperVerEN.Memo = objDT.Rows[0][convgs_PaperVer.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvgs_PaperVerDA: Getvgs_PaperVer)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngPaperVId">表关键字</param>
 /// <returns>表对象</returns>
public clsvgs_PaperVerEN GetObjByPaperVId(long lngPaperVId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PaperVerDA.GetSpecSQLObj();
strSQL = "Select * from vgs_PaperVer where PaperVId = " + ""+ lngPaperVId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvgs_PaperVerEN objvgs_PaperVerEN = new clsvgs_PaperVerEN();
try
{
 objvgs_PaperVerEN.PaperVId = Int32.Parse(objRow[convgs_PaperVer.PaperVId].ToString().Trim()); //PaperVId(字段类型:bigint,字段长度:8,是否可空:False)
 objvgs_PaperVerEN.PaperId = objRow[convgs_PaperVer.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objvgs_PaperVerEN.PaperTitle = objRow[convgs_PaperVer.PaperTitle].ToString().Trim(); //论文标题(字段类型:varchar,字段长度:500,是否可空:False)
 objvgs_PaperVerEN.PaperContent = objRow[convgs_PaperVer.PaperContent] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperContent].ToString().Trim(); //主题内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvgs_PaperVerEN.Periodical = objRow[convgs_PaperVer.Periodical] == DBNull.Value ? null : objRow[convgs_PaperVer.Periodical].ToString().Trim(); //期刊(字段类型:varchar,字段长度:100,是否可空:True)
 objvgs_PaperVerEN.Author = objRow[convgs_PaperVer.Author] == DBNull.Value ? null : objRow[convgs_PaperVer.Author].ToString().Trim(); //作者(字段类型:varchar,字段长度:200,是否可空:True)
 objvgs_PaperVerEN.ResearchQuestion = objRow[convgs_PaperVer.ResearchQuestion] == DBNull.Value ? null : objRow[convgs_PaperVer.ResearchQuestion].ToString().Trim(); //研究问题(字段类型:varchar,字段长度:2000,是否可空:True)
 objvgs_PaperVerEN.Keyword = objRow[convgs_PaperVer.Keyword] == DBNull.Value ? null : objRow[convgs_PaperVer.Keyword].ToString().Trim(); //关键字(字段类型:varchar,字段长度:1000,是否可空:True)
 objvgs_PaperVerEN.LiteratureSources = objRow[convgs_PaperVer.LiteratureSources] == DBNull.Value ? null : objRow[convgs_PaperVer.LiteratureSources].ToString().Trim(); //文献来源(字段类型:varchar,字段长度:1000,是否可空:True)
 objvgs_PaperVerEN.LiteratureLink = objRow[convgs_PaperVer.LiteratureLink] == DBNull.Value ? null : objRow[convgs_PaperVer.LiteratureLink].ToString().Trim(); //文献链接(字段类型:varchar,字段长度:1000,是否可空:True)
 objvgs_PaperVerEN.UploadfileUrl = objRow[convgs_PaperVer.UploadfileUrl] == DBNull.Value ? null : objRow[convgs_PaperVer.UploadfileUrl].ToString().Trim(); //文件地址(字段类型:varchar,字段长度:1000,是否可空:True)
 objvgs_PaperVerEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[convgs_PaperVer.IsQuotethesis].ToString().Trim()); //是否引用论文(字段类型:bit,字段长度:1,是否可空:True)
 objvgs_PaperVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PaperVer.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvgs_PaperVerEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convgs_PaperVer.IsChecked].ToString().Trim()); //是否检查(字段类型:bit,字段长度:1,是否可空:True)
 objvgs_PaperVerEN.QuoteId = objRow[convgs_PaperVer.QuoteId] == DBNull.Value ? null : objRow[convgs_PaperVer.QuoteId].ToString().Trim(); //引用Id(字段类型:char,字段长度:8,是否可空:True)
 objvgs_PaperVerEN.Checker = objRow[convgs_PaperVer.Checker] == DBNull.Value ? null : objRow[convgs_PaperVer.Checker].ToString().Trim(); //审核人(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_PaperVerEN.LiteratureTypeId = objRow[convgs_PaperVer.LiteratureTypeId].ToString().Trim(); //作文类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvgs_PaperVerEN.LiteratureTypeName = objRow[convgs_PaperVer.LiteratureTypeName] == DBNull.Value ? null : objRow[convgs_PaperVer.LiteratureTypeName].ToString().Trim(); //作文类型名(字段类型:varchar,字段长度:100,是否可空:True)
 objvgs_PaperVerEN.UpdUser = objRow[convgs_PaperVer.UpdUser] == DBNull.Value ? null : objRow[convgs_PaperVer.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_PaperVerEN.UpdDate = objRow[convgs_PaperVer.UpdDate] == DBNull.Value ? null : objRow[convgs_PaperVer.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_PaperVerEN.IdCurrEduCls = objRow[convgs_PaperVer.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_PaperVer.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvgs_PaperVerEN.PaperTypeId = objRow[convgs_PaperVer.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperTypeId].ToString().Trim(); //论文类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvgs_PaperVerEN.PaperTypeName = objRow[convgs_PaperVer.PaperTypeName] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperTypeName].ToString().Trim(); //论文类型名(字段类型:varchar,字段长度:50,是否可空:True)
 objvgs_PaperVerEN.PaperStatusId = objRow[convgs_PaperVer.PaperStatusId] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperStatusId].ToString().Trim(); //论文状态Id(字段类型:char,字段长度:2,是否可空:False)
 objvgs_PaperVerEN.PaperStatusName = objRow[convgs_PaperVer.PaperStatusName] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperStatusName].ToString().Trim(); //论文状态名(字段类型:varchar,字段长度:50,是否可空:True)
 objvgs_PaperVerEN.Memo = objRow[convgs_PaperVer.Memo] == DBNull.Value ? null : objRow[convgs_PaperVer.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvgs_PaperVerDA: GetObjByPaperVId)", objException.Message));
}
return objvgs_PaperVerEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvgs_PaperVerEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvgs_PaperVerDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PaperVerDA.GetSpecSQLObj();
strSQL = "Select * from vgs_PaperVer where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvgs_PaperVerEN objvgs_PaperVerEN = new clsvgs_PaperVerEN()
{
PaperVId = TransNullToInt(objRow[convgs_PaperVer.PaperVId].ToString().Trim()), //PaperVId
PaperId = objRow[convgs_PaperVer.PaperId].ToString().Trim(), //论文Id
PaperTitle = objRow[convgs_PaperVer.PaperTitle].ToString().Trim(), //论文标题
PaperContent = objRow[convgs_PaperVer.PaperContent] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperContent].ToString().Trim(), //主题内容
Periodical = objRow[convgs_PaperVer.Periodical] == DBNull.Value ? null : objRow[convgs_PaperVer.Periodical].ToString().Trim(), //期刊
Author = objRow[convgs_PaperVer.Author] == DBNull.Value ? null : objRow[convgs_PaperVer.Author].ToString().Trim(), //作者
ResearchQuestion = objRow[convgs_PaperVer.ResearchQuestion] == DBNull.Value ? null : objRow[convgs_PaperVer.ResearchQuestion].ToString().Trim(), //研究问题
Keyword = objRow[convgs_PaperVer.Keyword] == DBNull.Value ? null : objRow[convgs_PaperVer.Keyword].ToString().Trim(), //关键字
LiteratureSources = objRow[convgs_PaperVer.LiteratureSources] == DBNull.Value ? null : objRow[convgs_PaperVer.LiteratureSources].ToString().Trim(), //文献来源
LiteratureLink = objRow[convgs_PaperVer.LiteratureLink] == DBNull.Value ? null : objRow[convgs_PaperVer.LiteratureLink].ToString().Trim(), //文献链接
UploadfileUrl = objRow[convgs_PaperVer.UploadfileUrl] == DBNull.Value ? null : objRow[convgs_PaperVer.UploadfileUrl].ToString().Trim(), //文件地址
IsQuotethesis = TransNullToBool(objRow[convgs_PaperVer.IsQuotethesis].ToString().Trim()), //是否引用论文
IsSubmit = TransNullToBool(objRow[convgs_PaperVer.IsSubmit].ToString().Trim()), //是否提交
IsChecked = TransNullToBool(objRow[convgs_PaperVer.IsChecked].ToString().Trim()), //是否检查
QuoteId = objRow[convgs_PaperVer.QuoteId] == DBNull.Value ? null : objRow[convgs_PaperVer.QuoteId].ToString().Trim(), //引用Id
Checker = objRow[convgs_PaperVer.Checker] == DBNull.Value ? null : objRow[convgs_PaperVer.Checker].ToString().Trim(), //审核人
LiteratureTypeId = objRow[convgs_PaperVer.LiteratureTypeId].ToString().Trim(), //作文类型Id
LiteratureTypeName = objRow[convgs_PaperVer.LiteratureTypeName] == DBNull.Value ? null : objRow[convgs_PaperVer.LiteratureTypeName].ToString().Trim(), //作文类型名
UpdUser = objRow[convgs_PaperVer.UpdUser] == DBNull.Value ? null : objRow[convgs_PaperVer.UpdUser].ToString().Trim(), //修改人
UpdDate = objRow[convgs_PaperVer.UpdDate] == DBNull.Value ? null : objRow[convgs_PaperVer.UpdDate].ToString().Trim(), //修改日期
IdCurrEduCls = objRow[convgs_PaperVer.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_PaperVer.IdCurrEduCls].ToString().Trim(), //教学班流水号
PaperTypeId = objRow[convgs_PaperVer.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperTypeId].ToString().Trim(), //论文类型Id
PaperTypeName = objRow[convgs_PaperVer.PaperTypeName] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperTypeName].ToString().Trim(), //论文类型名
PaperStatusId = objRow[convgs_PaperVer.PaperStatusId] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperStatusId].ToString().Trim(), //论文状态Id
PaperStatusName = objRow[convgs_PaperVer.PaperStatusName] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperStatusName].ToString().Trim(), //论文状态名
Memo = objRow[convgs_PaperVer.Memo] == DBNull.Value ? null : objRow[convgs_PaperVer.Memo].ToString().Trim() //备注
};
objvgs_PaperVerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvgs_PaperVerEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvgs_PaperVerDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvgs_PaperVerEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvgs_PaperVerEN objvgs_PaperVerEN = new clsvgs_PaperVerEN();
try
{
objvgs_PaperVerEN.PaperVId = TransNullToInt(objRow[convgs_PaperVer.PaperVId].ToString().Trim()); //PaperVId
objvgs_PaperVerEN.PaperId = objRow[convgs_PaperVer.PaperId].ToString().Trim(); //论文Id
objvgs_PaperVerEN.PaperTitle = objRow[convgs_PaperVer.PaperTitle].ToString().Trim(); //论文标题
objvgs_PaperVerEN.PaperContent = objRow[convgs_PaperVer.PaperContent] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperContent].ToString().Trim(); //主题内容
objvgs_PaperVerEN.Periodical = objRow[convgs_PaperVer.Periodical] == DBNull.Value ? null : objRow[convgs_PaperVer.Periodical].ToString().Trim(); //期刊
objvgs_PaperVerEN.Author = objRow[convgs_PaperVer.Author] == DBNull.Value ? null : objRow[convgs_PaperVer.Author].ToString().Trim(); //作者
objvgs_PaperVerEN.ResearchQuestion = objRow[convgs_PaperVer.ResearchQuestion] == DBNull.Value ? null : objRow[convgs_PaperVer.ResearchQuestion].ToString().Trim(); //研究问题
objvgs_PaperVerEN.Keyword = objRow[convgs_PaperVer.Keyword] == DBNull.Value ? null : objRow[convgs_PaperVer.Keyword].ToString().Trim(); //关键字
objvgs_PaperVerEN.LiteratureSources = objRow[convgs_PaperVer.LiteratureSources] == DBNull.Value ? null : objRow[convgs_PaperVer.LiteratureSources].ToString().Trim(); //文献来源
objvgs_PaperVerEN.LiteratureLink = objRow[convgs_PaperVer.LiteratureLink] == DBNull.Value ? null : objRow[convgs_PaperVer.LiteratureLink].ToString().Trim(); //文献链接
objvgs_PaperVerEN.UploadfileUrl = objRow[convgs_PaperVer.UploadfileUrl] == DBNull.Value ? null : objRow[convgs_PaperVer.UploadfileUrl].ToString().Trim(); //文件地址
objvgs_PaperVerEN.IsQuotethesis = TransNullToBool(objRow[convgs_PaperVer.IsQuotethesis].ToString().Trim()); //是否引用论文
objvgs_PaperVerEN.IsSubmit = TransNullToBool(objRow[convgs_PaperVer.IsSubmit].ToString().Trim()); //是否提交
objvgs_PaperVerEN.IsChecked = TransNullToBool(objRow[convgs_PaperVer.IsChecked].ToString().Trim()); //是否检查
objvgs_PaperVerEN.QuoteId = objRow[convgs_PaperVer.QuoteId] == DBNull.Value ? null : objRow[convgs_PaperVer.QuoteId].ToString().Trim(); //引用Id
objvgs_PaperVerEN.Checker = objRow[convgs_PaperVer.Checker] == DBNull.Value ? null : objRow[convgs_PaperVer.Checker].ToString().Trim(); //审核人
objvgs_PaperVerEN.LiteratureTypeId = objRow[convgs_PaperVer.LiteratureTypeId].ToString().Trim(); //作文类型Id
objvgs_PaperVerEN.LiteratureTypeName = objRow[convgs_PaperVer.LiteratureTypeName] == DBNull.Value ? null : objRow[convgs_PaperVer.LiteratureTypeName].ToString().Trim(); //作文类型名
objvgs_PaperVerEN.UpdUser = objRow[convgs_PaperVer.UpdUser] == DBNull.Value ? null : objRow[convgs_PaperVer.UpdUser].ToString().Trim(); //修改人
objvgs_PaperVerEN.UpdDate = objRow[convgs_PaperVer.UpdDate] == DBNull.Value ? null : objRow[convgs_PaperVer.UpdDate].ToString().Trim(); //修改日期
objvgs_PaperVerEN.IdCurrEduCls = objRow[convgs_PaperVer.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_PaperVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_PaperVerEN.PaperTypeId = objRow[convgs_PaperVer.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PaperVerEN.PaperTypeName = objRow[convgs_PaperVer.PaperTypeName] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperTypeName].ToString().Trim(); //论文类型名
objvgs_PaperVerEN.PaperStatusId = objRow[convgs_PaperVer.PaperStatusId] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperStatusId].ToString().Trim(); //论文状态Id
objvgs_PaperVerEN.PaperStatusName = objRow[convgs_PaperVer.PaperStatusName] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperStatusName].ToString().Trim(); //论文状态名
objvgs_PaperVerEN.Memo = objRow[convgs_PaperVer.Memo] == DBNull.Value ? null : objRow[convgs_PaperVer.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvgs_PaperVerDA: GetObjByDataRowvgs_PaperVer)", objException.Message));
}
objvgs_PaperVerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvgs_PaperVerEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvgs_PaperVerEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvgs_PaperVerEN objvgs_PaperVerEN = new clsvgs_PaperVerEN();
try
{
objvgs_PaperVerEN.PaperVId = TransNullToInt(objRow[convgs_PaperVer.PaperVId].ToString().Trim()); //PaperVId
objvgs_PaperVerEN.PaperId = objRow[convgs_PaperVer.PaperId].ToString().Trim(); //论文Id
objvgs_PaperVerEN.PaperTitle = objRow[convgs_PaperVer.PaperTitle].ToString().Trim(); //论文标题
objvgs_PaperVerEN.PaperContent = objRow[convgs_PaperVer.PaperContent] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperContent].ToString().Trim(); //主题内容
objvgs_PaperVerEN.Periodical = objRow[convgs_PaperVer.Periodical] == DBNull.Value ? null : objRow[convgs_PaperVer.Periodical].ToString().Trim(); //期刊
objvgs_PaperVerEN.Author = objRow[convgs_PaperVer.Author] == DBNull.Value ? null : objRow[convgs_PaperVer.Author].ToString().Trim(); //作者
objvgs_PaperVerEN.ResearchQuestion = objRow[convgs_PaperVer.ResearchQuestion] == DBNull.Value ? null : objRow[convgs_PaperVer.ResearchQuestion].ToString().Trim(); //研究问题
objvgs_PaperVerEN.Keyword = objRow[convgs_PaperVer.Keyword] == DBNull.Value ? null : objRow[convgs_PaperVer.Keyword].ToString().Trim(); //关键字
objvgs_PaperVerEN.LiteratureSources = objRow[convgs_PaperVer.LiteratureSources] == DBNull.Value ? null : objRow[convgs_PaperVer.LiteratureSources].ToString().Trim(); //文献来源
objvgs_PaperVerEN.LiteratureLink = objRow[convgs_PaperVer.LiteratureLink] == DBNull.Value ? null : objRow[convgs_PaperVer.LiteratureLink].ToString().Trim(); //文献链接
objvgs_PaperVerEN.UploadfileUrl = objRow[convgs_PaperVer.UploadfileUrl] == DBNull.Value ? null : objRow[convgs_PaperVer.UploadfileUrl].ToString().Trim(); //文件地址
objvgs_PaperVerEN.IsQuotethesis = TransNullToBool(objRow[convgs_PaperVer.IsQuotethesis].ToString().Trim()); //是否引用论文
objvgs_PaperVerEN.IsSubmit = TransNullToBool(objRow[convgs_PaperVer.IsSubmit].ToString().Trim()); //是否提交
objvgs_PaperVerEN.IsChecked = TransNullToBool(objRow[convgs_PaperVer.IsChecked].ToString().Trim()); //是否检查
objvgs_PaperVerEN.QuoteId = objRow[convgs_PaperVer.QuoteId] == DBNull.Value ? null : objRow[convgs_PaperVer.QuoteId].ToString().Trim(); //引用Id
objvgs_PaperVerEN.Checker = objRow[convgs_PaperVer.Checker] == DBNull.Value ? null : objRow[convgs_PaperVer.Checker].ToString().Trim(); //审核人
objvgs_PaperVerEN.LiteratureTypeId = objRow[convgs_PaperVer.LiteratureTypeId].ToString().Trim(); //作文类型Id
objvgs_PaperVerEN.LiteratureTypeName = objRow[convgs_PaperVer.LiteratureTypeName] == DBNull.Value ? null : objRow[convgs_PaperVer.LiteratureTypeName].ToString().Trim(); //作文类型名
objvgs_PaperVerEN.UpdUser = objRow[convgs_PaperVer.UpdUser] == DBNull.Value ? null : objRow[convgs_PaperVer.UpdUser].ToString().Trim(); //修改人
objvgs_PaperVerEN.UpdDate = objRow[convgs_PaperVer.UpdDate] == DBNull.Value ? null : objRow[convgs_PaperVer.UpdDate].ToString().Trim(); //修改日期
objvgs_PaperVerEN.IdCurrEduCls = objRow[convgs_PaperVer.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_PaperVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_PaperVerEN.PaperTypeId = objRow[convgs_PaperVer.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PaperVerEN.PaperTypeName = objRow[convgs_PaperVer.PaperTypeName] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperTypeName].ToString().Trim(); //论文类型名
objvgs_PaperVerEN.PaperStatusId = objRow[convgs_PaperVer.PaperStatusId] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperStatusId].ToString().Trim(); //论文状态Id
objvgs_PaperVerEN.PaperStatusName = objRow[convgs_PaperVer.PaperStatusName] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperStatusName].ToString().Trim(); //论文状态名
objvgs_PaperVerEN.Memo = objRow[convgs_PaperVer.Memo] == DBNull.Value ? null : objRow[convgs_PaperVer.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvgs_PaperVerDA: GetObjByDataRow)", objException.Message));
}
objvgs_PaperVerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvgs_PaperVerEN;
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
objSQL = clsvgs_PaperVerDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvgs_PaperVerEN._CurrTabName, convgs_PaperVer.PaperVId, 8, "");
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
objSQL = clsvgs_PaperVerDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvgs_PaperVerEN._CurrTabName, convgs_PaperVer.PaperVId, 8, strPrefix);
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
 objSQL = clsvgs_PaperVerDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select PaperVId from vgs_PaperVer where " + strCondition;
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
 objSQL = clsvgs_PaperVerDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select PaperVId from vgs_PaperVer where " + strCondition;
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
 objSQL = clsvgs_PaperVerDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vgs_PaperVer", "PaperVId = " + ""+ lngPaperVId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvgs_PaperVerDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PaperVerDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vgs_PaperVer", strCondition))
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
objSQL = clsvgs_PaperVerDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vgs_PaperVer");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvgs_PaperVerENS">源对象</param>
 /// <param name = "objvgs_PaperVerENT">目标对象</param>
public void CopyTo(clsvgs_PaperVerEN objvgs_PaperVerENS, clsvgs_PaperVerEN objvgs_PaperVerENT)
{
objvgs_PaperVerENT.PaperVId = objvgs_PaperVerENS.PaperVId; //PaperVId
objvgs_PaperVerENT.PaperId = objvgs_PaperVerENS.PaperId; //论文Id
objvgs_PaperVerENT.PaperTitle = objvgs_PaperVerENS.PaperTitle; //论文标题
objvgs_PaperVerENT.PaperContent = objvgs_PaperVerENS.PaperContent; //主题内容
objvgs_PaperVerENT.Periodical = objvgs_PaperVerENS.Periodical; //期刊
objvgs_PaperVerENT.Author = objvgs_PaperVerENS.Author; //作者
objvgs_PaperVerENT.ResearchQuestion = objvgs_PaperVerENS.ResearchQuestion; //研究问题
objvgs_PaperVerENT.Keyword = objvgs_PaperVerENS.Keyword; //关键字
objvgs_PaperVerENT.LiteratureSources = objvgs_PaperVerENS.LiteratureSources; //文献来源
objvgs_PaperVerENT.LiteratureLink = objvgs_PaperVerENS.LiteratureLink; //文献链接
objvgs_PaperVerENT.UploadfileUrl = objvgs_PaperVerENS.UploadfileUrl; //文件地址
objvgs_PaperVerENT.IsQuotethesis = objvgs_PaperVerENS.IsQuotethesis; //是否引用论文
objvgs_PaperVerENT.IsSubmit = objvgs_PaperVerENS.IsSubmit; //是否提交
objvgs_PaperVerENT.IsChecked = objvgs_PaperVerENS.IsChecked; //是否检查
objvgs_PaperVerENT.QuoteId = objvgs_PaperVerENS.QuoteId; //引用Id
objvgs_PaperVerENT.Checker = objvgs_PaperVerENS.Checker; //审核人
objvgs_PaperVerENT.LiteratureTypeId = objvgs_PaperVerENS.LiteratureTypeId; //作文类型Id
objvgs_PaperVerENT.LiteratureTypeName = objvgs_PaperVerENS.LiteratureTypeName; //作文类型名
objvgs_PaperVerENT.UpdUser = objvgs_PaperVerENS.UpdUser; //修改人
objvgs_PaperVerENT.UpdDate = objvgs_PaperVerENS.UpdDate; //修改日期
objvgs_PaperVerENT.IdCurrEduCls = objvgs_PaperVerENS.IdCurrEduCls; //教学班流水号
objvgs_PaperVerENT.PaperTypeId = objvgs_PaperVerENS.PaperTypeId; //论文类型Id
objvgs_PaperVerENT.PaperTypeName = objvgs_PaperVerENS.PaperTypeName; //论文类型名
objvgs_PaperVerENT.PaperStatusId = objvgs_PaperVerENS.PaperStatusId; //论文状态Id
objvgs_PaperVerENT.PaperStatusName = objvgs_PaperVerENS.PaperStatusName; //论文状态名
objvgs_PaperVerENT.Memo = objvgs_PaperVerENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvgs_PaperVerEN objvgs_PaperVerEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvgs_PaperVerEN.PaperId, 8, convgs_PaperVer.PaperId);
clsCheckSql.CheckFieldLen(objvgs_PaperVerEN.PaperTitle, 500, convgs_PaperVer.PaperTitle);
clsCheckSql.CheckFieldLen(objvgs_PaperVerEN.Periodical, 100, convgs_PaperVer.Periodical);
clsCheckSql.CheckFieldLen(objvgs_PaperVerEN.Author, 200, convgs_PaperVer.Author);
clsCheckSql.CheckFieldLen(objvgs_PaperVerEN.ResearchQuestion, 2000, convgs_PaperVer.ResearchQuestion);
clsCheckSql.CheckFieldLen(objvgs_PaperVerEN.Keyword, 1000, convgs_PaperVer.Keyword);
clsCheckSql.CheckFieldLen(objvgs_PaperVerEN.LiteratureSources, 1000, convgs_PaperVer.LiteratureSources);
clsCheckSql.CheckFieldLen(objvgs_PaperVerEN.LiteratureLink, 1000, convgs_PaperVer.LiteratureLink);
clsCheckSql.CheckFieldLen(objvgs_PaperVerEN.UploadfileUrl, 1000, convgs_PaperVer.UploadfileUrl);
clsCheckSql.CheckFieldLen(objvgs_PaperVerEN.QuoteId, 8, convgs_PaperVer.QuoteId);
clsCheckSql.CheckFieldLen(objvgs_PaperVerEN.Checker, 20, convgs_PaperVer.Checker);
clsCheckSql.CheckFieldLen(objvgs_PaperVerEN.LiteratureTypeId, 2, convgs_PaperVer.LiteratureTypeId);
clsCheckSql.CheckFieldLen(objvgs_PaperVerEN.LiteratureTypeName, 100, convgs_PaperVer.LiteratureTypeName);
clsCheckSql.CheckFieldLen(objvgs_PaperVerEN.UpdUser, 20, convgs_PaperVer.UpdUser);
clsCheckSql.CheckFieldLen(objvgs_PaperVerEN.UpdDate, 20, convgs_PaperVer.UpdDate);
clsCheckSql.CheckFieldLen(objvgs_PaperVerEN.IdCurrEduCls, 8, convgs_PaperVer.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objvgs_PaperVerEN.PaperTypeId, 2, convgs_PaperVer.PaperTypeId);
clsCheckSql.CheckFieldLen(objvgs_PaperVerEN.PaperTypeName, 50, convgs_PaperVer.PaperTypeName);
clsCheckSql.CheckFieldLen(objvgs_PaperVerEN.PaperStatusId, 2, convgs_PaperVer.PaperStatusId);
clsCheckSql.CheckFieldLen(objvgs_PaperVerEN.PaperStatusName, 50, convgs_PaperVer.PaperStatusName);
clsCheckSql.CheckFieldLen(objvgs_PaperVerEN.Memo, 1000, convgs_PaperVer.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvgs_PaperVerEN.PaperId, convgs_PaperVer.PaperId);
clsCheckSql.CheckSqlInjection4Field(objvgs_PaperVerEN.PaperTitle, convgs_PaperVer.PaperTitle);
clsCheckSql.CheckSqlInjection4Field(objvgs_PaperVerEN.Periodical, convgs_PaperVer.Periodical);
clsCheckSql.CheckSqlInjection4Field(objvgs_PaperVerEN.Author, convgs_PaperVer.Author);
clsCheckSql.CheckSqlInjection4Field(objvgs_PaperVerEN.ResearchQuestion, convgs_PaperVer.ResearchQuestion);
clsCheckSql.CheckSqlInjection4Field(objvgs_PaperVerEN.Keyword, convgs_PaperVer.Keyword);
clsCheckSql.CheckSqlInjection4Field(objvgs_PaperVerEN.LiteratureSources, convgs_PaperVer.LiteratureSources);
clsCheckSql.CheckSqlInjection4Field(objvgs_PaperVerEN.LiteratureLink, convgs_PaperVer.LiteratureLink);
clsCheckSql.CheckSqlInjection4Field(objvgs_PaperVerEN.UploadfileUrl, convgs_PaperVer.UploadfileUrl);
clsCheckSql.CheckSqlInjection4Field(objvgs_PaperVerEN.QuoteId, convgs_PaperVer.QuoteId);
clsCheckSql.CheckSqlInjection4Field(objvgs_PaperVerEN.Checker, convgs_PaperVer.Checker);
clsCheckSql.CheckSqlInjection4Field(objvgs_PaperVerEN.LiteratureTypeId, convgs_PaperVer.LiteratureTypeId);
clsCheckSql.CheckSqlInjection4Field(objvgs_PaperVerEN.LiteratureTypeName, convgs_PaperVer.LiteratureTypeName);
clsCheckSql.CheckSqlInjection4Field(objvgs_PaperVerEN.UpdUser, convgs_PaperVer.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvgs_PaperVerEN.UpdDate, convgs_PaperVer.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvgs_PaperVerEN.IdCurrEduCls, convgs_PaperVer.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objvgs_PaperVerEN.PaperTypeId, convgs_PaperVer.PaperTypeId);
clsCheckSql.CheckSqlInjection4Field(objvgs_PaperVerEN.PaperTypeName, convgs_PaperVer.PaperTypeName);
clsCheckSql.CheckSqlInjection4Field(objvgs_PaperVerEN.PaperStatusId, convgs_PaperVer.PaperStatusId);
clsCheckSql.CheckSqlInjection4Field(objvgs_PaperVerEN.PaperStatusName, convgs_PaperVer.PaperStatusName);
clsCheckSql.CheckSqlInjection4Field(objvgs_PaperVerEN.Memo, convgs_PaperVer.Memo);
//检查外键字段长度
 objvgs_PaperVerEN._IsCheckProperty = true;
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
 objSQL = clsvgs_PaperVerDA.GetSpecSQLObj();
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
 objSQL = clsvgs_PaperVerDA.GetSpecSQLObj();
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
 objSQL = clsvgs_PaperVerDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvgs_PaperVerEN._CurrTabName);
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
 objSQL = clsvgs_PaperVerDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvgs_PaperVerEN._CurrTabName, strCondition);
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
 objSQL = clsvgs_PaperVerDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}