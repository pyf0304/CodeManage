
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_qa_PaperDA
 表名:vzx_qa_Paper(01120849)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:13:55
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理(InteractManage)
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
 /// vzx_qa_Paper(vzx_qa_Paper)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvzx_qa_PaperDA : clsCommBase4DA
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
 return clsvzx_qa_PaperEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvzx_qa_PaperEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvzx_qa_PaperEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvzx_qa_PaperEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvzx_qa_PaperEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strZxqaPaperId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strZxqaPaperId)
{
strZxqaPaperId = strZxqaPaperId.Replace("'", "''");
if (strZxqaPaperId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vzx_qa_Paper中,检查关键字,长度不正确!(clsvzx_qa_PaperDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strZxqaPaperId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vzx_qa_Paper中,关键字不能为空 或 null!(clsvzx_qa_PaperDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strZxqaPaperId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvzx_qa_PaperDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvzx_qa_PaperDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_qa_PaperDA.GetSpecSQLObj();
strSQL = "Select * from vzx_qa_Paper where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vzx_qa_Paper(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvzx_qa_PaperDA: GetDataTable_vzx_qa_Paper)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_qa_PaperDA.GetSpecSQLObj();
strSQL = "Select * from vzx_qa_Paper where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvzx_qa_PaperDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_qa_PaperDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvzx_qa_PaperDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_qa_PaperDA.GetSpecSQLObj();
strSQL = "Select * from vzx_qa_Paper where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvzx_qa_PaperDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_qa_PaperDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvzx_qa_PaperDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_qa_PaperDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vzx_qa_Paper where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vzx_qa_Paper where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvzx_qa_PaperDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_qa_PaperDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vzx_qa_Paper where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvzx_qa_PaperDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_qa_PaperDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vzx_qa_Paper.* from vzx_qa_Paper Left Join {1} on {2} where {3} and vzx_qa_Paper.ZxqaPaperId not in (Select top {5} vzx_qa_Paper.ZxqaPaperId from vzx_qa_Paper Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vzx_qa_Paper where {1} and ZxqaPaperId not in (Select top {2} ZxqaPaperId from vzx_qa_Paper where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vzx_qa_Paper where {1} and ZxqaPaperId not in (Select top {3} ZxqaPaperId from vzx_qa_Paper where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvzx_qa_PaperDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_qa_PaperDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vzx_qa_Paper.* from vzx_qa_Paper Left Join {1} on {2} where {3} and vzx_qa_Paper.ZxqaPaperId not in (Select top {5} vzx_qa_Paper.ZxqaPaperId from vzx_qa_Paper Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vzx_qa_Paper where {1} and ZxqaPaperId not in (Select top {2} ZxqaPaperId from vzx_qa_Paper where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vzx_qa_Paper where {1} and ZxqaPaperId not in (Select top {3} ZxqaPaperId from vzx_qa_Paper where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvzx_qa_PaperEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvzx_qa_PaperDA:GetObjLst)", objException.Message));
}
List<clsvzx_qa_PaperEN> arrObjLst = new List<clsvzx_qa_PaperEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_qa_PaperDA.GetSpecSQLObj();
strSQL = "Select * from vzx_qa_Paper where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_qa_PaperEN objvzx_qa_PaperEN = new clsvzx_qa_PaperEN();
try
{
objvzx_qa_PaperEN.UserName = objRow[convzx_qa_Paper.UserName] == DBNull.Value ? null : objRow[convzx_qa_Paper.UserName].ToString().Trim(); //用户名
objvzx_qa_PaperEN.IdXzMajor = objRow[convzx_qa_Paper.IdXzMajor] == DBNull.Value ? null : objRow[convzx_qa_Paper.IdXzMajor].ToString().Trim(); //专业流水号
objvzx_qa_PaperEN.MajorName = objRow[convzx_qa_Paper.MajorName] == DBNull.Value ? null : objRow[convzx_qa_Paper.MajorName].ToString().Trim(); //专业名称
objvzx_qa_PaperEN.TextTitle = objRow[convzx_qa_Paper.TextTitle] == DBNull.Value ? null : objRow[convzx_qa_Paper.TextTitle].ToString().Trim(); //TextTitle
objvzx_qa_PaperEN.TextContent = objRow[convzx_qa_Paper.TextContent] == DBNull.Value ? null : objRow[convzx_qa_Paper.TextContent].ToString().Trim(); //TextContent
objvzx_qa_PaperEN.Author = objRow[convzx_qa_Paper.Author] == DBNull.Value ? null : objRow[convzx_qa_Paper.Author].ToString().Trim(); //作者
objvzx_qa_PaperEN.ResearchQuestion = objRow[convzx_qa_Paper.ResearchQuestion] == DBNull.Value ? null : objRow[convzx_qa_Paper.ResearchQuestion].ToString().Trim(); //研究问题
objvzx_qa_PaperEN.LiteratureSources = objRow[convzx_qa_Paper.LiteratureSources] == DBNull.Value ? null : objRow[convzx_qa_Paper.LiteratureSources].ToString().Trim(); //文献来源
objvzx_qa_PaperEN.LiteratureLink = objRow[convzx_qa_Paper.LiteratureLink] == DBNull.Value ? null : objRow[convzx_qa_Paper.LiteratureLink].ToString().Trim(); //文献链接
objvzx_qa_PaperEN.UploadfileUrl = objRow[convzx_qa_Paper.UploadfileUrl] == DBNull.Value ? null : objRow[convzx_qa_Paper.UploadfileUrl].ToString().Trim(); //文件地址
objvzx_qa_PaperEN.AttachmentCount = objRow[convzx_qa_Paper.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_qa_Paper.AttachmentCount].ToString().Trim()); //附件计数
objvzx_qa_PaperEN.ZxqaPaperId = objRow[convzx_qa_Paper.ZxqaPaperId].ToString().Trim(); //论文答疑Id
objvzx_qa_PaperEN.QuestionsCount = objRow[convzx_qa_Paper.QuestionsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_qa_Paper.QuestionsCount].ToString().Trim()); //提问计数
objvzx_qa_PaperEN.TextId = objRow[convzx_qa_Paper.TextId] == DBNull.Value ? null : objRow[convzx_qa_Paper.TextId].ToString().Trim(); //课件Id
objvzx_qa_PaperEN.IsDelete = TransNullToBool(objRow[convzx_qa_Paper.IsDelete].ToString().Trim()); //是否删除
objvzx_qa_PaperEN.IsPublic = TransNullToBool(objRow[convzx_qa_Paper.IsPublic].ToString().Trim()); //是否公开
objvzx_qa_PaperEN.IsSubmit = TransNullToBool(objRow[convzx_qa_Paper.IsSubmit].ToString().Trim()); //是否提交
objvzx_qa_PaperEN.UpdDate = objRow[convzx_qa_Paper.UpdDate] == DBNull.Value ? null : objRow[convzx_qa_Paper.UpdDate].ToString().Trim(); //修改日期
objvzx_qa_PaperEN.UpdUser = objRow[convzx_qa_Paper.UpdUser] == DBNull.Value ? null : objRow[convzx_qa_Paper.UpdUser].ToString().Trim(); //修改人
objvzx_qa_PaperEN.Memo = objRow[convzx_qa_Paper.Memo] == DBNull.Value ? null : objRow[convzx_qa_Paper.Memo].ToString().Trim(); //备注
objvzx_qa_PaperEN.IdCurrEduCls = objRow[convzx_qa_Paper.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_qa_Paper.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_qa_PaperEN.AnswerCount = objRow[convzx_qa_Paper.AnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_qa_Paper.AnswerCount].ToString().Trim()); //回答计数
objvzx_qa_PaperEN.zxShareId = objRow[convzx_qa_Paper.zxShareId] == DBNull.Value ? null : objRow[convzx_qa_Paper.zxShareId].ToString().Trim(); //分享Id
objvzx_qa_PaperEN.TagsCount = objRow[convzx_qa_Paper.TagsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_qa_Paper.TagsCount].ToString().Trim()); //论文标注数
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvzx_qa_PaperDA: GetObjLst)", objException.Message));
}
objvzx_qa_PaperEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvzx_qa_PaperEN);
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
public List<clsvzx_qa_PaperEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvzx_qa_PaperDA:GetObjLstByTabName)", objException.Message));
}
List<clsvzx_qa_PaperEN> arrObjLst = new List<clsvzx_qa_PaperEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_qa_PaperDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_qa_PaperEN objvzx_qa_PaperEN = new clsvzx_qa_PaperEN();
try
{
objvzx_qa_PaperEN.UserName = objRow[convzx_qa_Paper.UserName] == DBNull.Value ? null : objRow[convzx_qa_Paper.UserName].ToString().Trim(); //用户名
objvzx_qa_PaperEN.IdXzMajor = objRow[convzx_qa_Paper.IdXzMajor] == DBNull.Value ? null : objRow[convzx_qa_Paper.IdXzMajor].ToString().Trim(); //专业流水号
objvzx_qa_PaperEN.MajorName = objRow[convzx_qa_Paper.MajorName] == DBNull.Value ? null : objRow[convzx_qa_Paper.MajorName].ToString().Trim(); //专业名称
objvzx_qa_PaperEN.TextTitle = objRow[convzx_qa_Paper.TextTitle] == DBNull.Value ? null : objRow[convzx_qa_Paper.TextTitle].ToString().Trim(); //TextTitle
objvzx_qa_PaperEN.TextContent = objRow[convzx_qa_Paper.TextContent] == DBNull.Value ? null : objRow[convzx_qa_Paper.TextContent].ToString().Trim(); //TextContent
objvzx_qa_PaperEN.Author = objRow[convzx_qa_Paper.Author] == DBNull.Value ? null : objRow[convzx_qa_Paper.Author].ToString().Trim(); //作者
objvzx_qa_PaperEN.ResearchQuestion = objRow[convzx_qa_Paper.ResearchQuestion] == DBNull.Value ? null : objRow[convzx_qa_Paper.ResearchQuestion].ToString().Trim(); //研究问题
objvzx_qa_PaperEN.LiteratureSources = objRow[convzx_qa_Paper.LiteratureSources] == DBNull.Value ? null : objRow[convzx_qa_Paper.LiteratureSources].ToString().Trim(); //文献来源
objvzx_qa_PaperEN.LiteratureLink = objRow[convzx_qa_Paper.LiteratureLink] == DBNull.Value ? null : objRow[convzx_qa_Paper.LiteratureLink].ToString().Trim(); //文献链接
objvzx_qa_PaperEN.UploadfileUrl = objRow[convzx_qa_Paper.UploadfileUrl] == DBNull.Value ? null : objRow[convzx_qa_Paper.UploadfileUrl].ToString().Trim(); //文件地址
objvzx_qa_PaperEN.AttachmentCount = objRow[convzx_qa_Paper.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_qa_Paper.AttachmentCount].ToString().Trim()); //附件计数
objvzx_qa_PaperEN.ZxqaPaperId = objRow[convzx_qa_Paper.ZxqaPaperId].ToString().Trim(); //论文答疑Id
objvzx_qa_PaperEN.QuestionsCount = objRow[convzx_qa_Paper.QuestionsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_qa_Paper.QuestionsCount].ToString().Trim()); //提问计数
objvzx_qa_PaperEN.TextId = objRow[convzx_qa_Paper.TextId] == DBNull.Value ? null : objRow[convzx_qa_Paper.TextId].ToString().Trim(); //课件Id
objvzx_qa_PaperEN.IsDelete = TransNullToBool(objRow[convzx_qa_Paper.IsDelete].ToString().Trim()); //是否删除
objvzx_qa_PaperEN.IsPublic = TransNullToBool(objRow[convzx_qa_Paper.IsPublic].ToString().Trim()); //是否公开
objvzx_qa_PaperEN.IsSubmit = TransNullToBool(objRow[convzx_qa_Paper.IsSubmit].ToString().Trim()); //是否提交
objvzx_qa_PaperEN.UpdDate = objRow[convzx_qa_Paper.UpdDate] == DBNull.Value ? null : objRow[convzx_qa_Paper.UpdDate].ToString().Trim(); //修改日期
objvzx_qa_PaperEN.UpdUser = objRow[convzx_qa_Paper.UpdUser] == DBNull.Value ? null : objRow[convzx_qa_Paper.UpdUser].ToString().Trim(); //修改人
objvzx_qa_PaperEN.Memo = objRow[convzx_qa_Paper.Memo] == DBNull.Value ? null : objRow[convzx_qa_Paper.Memo].ToString().Trim(); //备注
objvzx_qa_PaperEN.IdCurrEduCls = objRow[convzx_qa_Paper.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_qa_Paper.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_qa_PaperEN.AnswerCount = objRow[convzx_qa_Paper.AnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_qa_Paper.AnswerCount].ToString().Trim()); //回答计数
objvzx_qa_PaperEN.zxShareId = objRow[convzx_qa_Paper.zxShareId] == DBNull.Value ? null : objRow[convzx_qa_Paper.zxShareId].ToString().Trim(); //分享Id
objvzx_qa_PaperEN.TagsCount = objRow[convzx_qa_Paper.TagsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_qa_Paper.TagsCount].ToString().Trim()); //论文标注数
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvzx_qa_PaperDA: GetObjLst)", objException.Message));
}
objvzx_qa_PaperEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvzx_qa_PaperEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvzx_qa_PaperEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getvzx_qa_Paper(ref clsvzx_qa_PaperEN objvzx_qa_PaperEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_qa_PaperDA.GetSpecSQLObj();
strSQL = "Select * from vzx_qa_Paper where ZxqaPaperId = " + "'"+ objvzx_qa_PaperEN.ZxqaPaperId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvzx_qa_PaperEN.UserName = objDT.Rows[0][convzx_qa_Paper.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvzx_qa_PaperEN.IdXzMajor = objDT.Rows[0][convzx_qa_Paper.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvzx_qa_PaperEN.MajorName = objDT.Rows[0][convzx_qa_Paper.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvzx_qa_PaperEN.TextTitle = objDT.Rows[0][convzx_qa_Paper.TextTitle].ToString().Trim(); //TextTitle(字段类型:varchar,字段长度:500,是否可空:False)
 objvzx_qa_PaperEN.TextContent = objDT.Rows[0][convzx_qa_Paper.TextContent].ToString().Trim(); //TextContent(字段类型:text,字段长度:2147483647,是否可空:True)
 objvzx_qa_PaperEN.Author = objDT.Rows[0][convzx_qa_Paper.Author].ToString().Trim(); //作者(字段类型:varchar,字段长度:200,是否可空:True)
 objvzx_qa_PaperEN.ResearchQuestion = objDT.Rows[0][convzx_qa_Paper.ResearchQuestion].ToString().Trim(); //研究问题(字段类型:varchar,字段长度:2000,是否可空:True)
 objvzx_qa_PaperEN.LiteratureSources = objDT.Rows[0][convzx_qa_Paper.LiteratureSources].ToString().Trim(); //文献来源(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_qa_PaperEN.LiteratureLink = objDT.Rows[0][convzx_qa_Paper.LiteratureLink].ToString().Trim(); //文献链接(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_qa_PaperEN.UploadfileUrl = objDT.Rows[0][convzx_qa_Paper.UploadfileUrl].ToString().Trim(); //文件地址(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_qa_PaperEN.AttachmentCount = TransNullToInt(objDT.Rows[0][convzx_qa_Paper.AttachmentCount].ToString().Trim()); //附件计数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_qa_PaperEN.ZxqaPaperId = objDT.Rows[0][convzx_qa_Paper.ZxqaPaperId].ToString().Trim(); //论文答疑Id(字段类型:char,字段长度:8,是否可空:False)
 objvzx_qa_PaperEN.QuestionsCount = TransNullToInt(objDT.Rows[0][convzx_qa_Paper.QuestionsCount].ToString().Trim()); //提问计数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_qa_PaperEN.TextId = objDT.Rows[0][convzx_qa_Paper.TextId].ToString().Trim(); //课件Id(字段类型:char,字段长度:8,是否可空:False)
 objvzx_qa_PaperEN.IsDelete = TransNullToBool(objDT.Rows[0][convzx_qa_Paper.IsDelete].ToString().Trim()); //是否删除(字段类型:bit,字段长度:1,是否可空:True)
 objvzx_qa_PaperEN.IsPublic = TransNullToBool(objDT.Rows[0][convzx_qa_Paper.IsPublic].ToString().Trim()); //是否公开(字段类型:bit,字段长度:1,是否可空:True)
 objvzx_qa_PaperEN.IsSubmit = TransNullToBool(objDT.Rows[0][convzx_qa_Paper.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvzx_qa_PaperEN.UpdDate = objDT.Rows[0][convzx_qa_Paper.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_qa_PaperEN.UpdUser = objDT.Rows[0][convzx_qa_Paper.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_qa_PaperEN.Memo = objDT.Rows[0][convzx_qa_Paper.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_qa_PaperEN.IdCurrEduCls = objDT.Rows[0][convzx_qa_Paper.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvzx_qa_PaperEN.AnswerCount = TransNullToInt(objDT.Rows[0][convzx_qa_Paper.AnswerCount].ToString().Trim()); //回答计数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_qa_PaperEN.zxShareId = objDT.Rows[0][convzx_qa_Paper.zxShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objvzx_qa_PaperEN.TagsCount = TransNullToInt(objDT.Rows[0][convzx_qa_Paper.TagsCount].ToString().Trim()); //论文标注数(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvzx_qa_PaperDA: Getvzx_qa_Paper)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strZxqaPaperId">表关键字</param>
 /// <returns>表对象</returns>
public clsvzx_qa_PaperEN GetObjByZxqaPaperId(string strZxqaPaperId)
{
CheckPrimaryKey(strZxqaPaperId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_qa_PaperDA.GetSpecSQLObj();
strSQL = "Select * from vzx_qa_Paper where ZxqaPaperId = " + "'"+ strZxqaPaperId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvzx_qa_PaperEN objvzx_qa_PaperEN = new clsvzx_qa_PaperEN();
try
{
 objvzx_qa_PaperEN.UserName = objRow[convzx_qa_Paper.UserName] == DBNull.Value ? null : objRow[convzx_qa_Paper.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvzx_qa_PaperEN.IdXzMajor = objRow[convzx_qa_Paper.IdXzMajor] == DBNull.Value ? null : objRow[convzx_qa_Paper.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvzx_qa_PaperEN.MajorName = objRow[convzx_qa_Paper.MajorName] == DBNull.Value ? null : objRow[convzx_qa_Paper.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvzx_qa_PaperEN.TextTitle = objRow[convzx_qa_Paper.TextTitle] == DBNull.Value ? null : objRow[convzx_qa_Paper.TextTitle].ToString().Trim(); //TextTitle(字段类型:varchar,字段长度:500,是否可空:False)
 objvzx_qa_PaperEN.TextContent = objRow[convzx_qa_Paper.TextContent] == DBNull.Value ? null : objRow[convzx_qa_Paper.TextContent].ToString().Trim(); //TextContent(字段类型:text,字段长度:2147483647,是否可空:True)
 objvzx_qa_PaperEN.Author = objRow[convzx_qa_Paper.Author] == DBNull.Value ? null : objRow[convzx_qa_Paper.Author].ToString().Trim(); //作者(字段类型:varchar,字段长度:200,是否可空:True)
 objvzx_qa_PaperEN.ResearchQuestion = objRow[convzx_qa_Paper.ResearchQuestion] == DBNull.Value ? null : objRow[convzx_qa_Paper.ResearchQuestion].ToString().Trim(); //研究问题(字段类型:varchar,字段长度:2000,是否可空:True)
 objvzx_qa_PaperEN.LiteratureSources = objRow[convzx_qa_Paper.LiteratureSources] == DBNull.Value ? null : objRow[convzx_qa_Paper.LiteratureSources].ToString().Trim(); //文献来源(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_qa_PaperEN.LiteratureLink = objRow[convzx_qa_Paper.LiteratureLink] == DBNull.Value ? null : objRow[convzx_qa_Paper.LiteratureLink].ToString().Trim(); //文献链接(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_qa_PaperEN.UploadfileUrl = objRow[convzx_qa_Paper.UploadfileUrl] == DBNull.Value ? null : objRow[convzx_qa_Paper.UploadfileUrl].ToString().Trim(); //文件地址(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_qa_PaperEN.AttachmentCount = objRow[convzx_qa_Paper.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Paper.AttachmentCount].ToString().Trim()); //附件计数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_qa_PaperEN.ZxqaPaperId = objRow[convzx_qa_Paper.ZxqaPaperId].ToString().Trim(); //论文答疑Id(字段类型:char,字段长度:8,是否可空:False)
 objvzx_qa_PaperEN.QuestionsCount = objRow[convzx_qa_Paper.QuestionsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Paper.QuestionsCount].ToString().Trim()); //提问计数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_qa_PaperEN.TextId = objRow[convzx_qa_Paper.TextId] == DBNull.Value ? null : objRow[convzx_qa_Paper.TextId].ToString().Trim(); //课件Id(字段类型:char,字段长度:8,是否可空:False)
 objvzx_qa_PaperEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Paper.IsDelete].ToString().Trim()); //是否删除(字段类型:bit,字段长度:1,是否可空:True)
 objvzx_qa_PaperEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Paper.IsPublic].ToString().Trim()); //是否公开(字段类型:bit,字段长度:1,是否可空:True)
 objvzx_qa_PaperEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Paper.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvzx_qa_PaperEN.UpdDate = objRow[convzx_qa_Paper.UpdDate] == DBNull.Value ? null : objRow[convzx_qa_Paper.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_qa_PaperEN.UpdUser = objRow[convzx_qa_Paper.UpdUser] == DBNull.Value ? null : objRow[convzx_qa_Paper.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_qa_PaperEN.Memo = objRow[convzx_qa_Paper.Memo] == DBNull.Value ? null : objRow[convzx_qa_Paper.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_qa_PaperEN.IdCurrEduCls = objRow[convzx_qa_Paper.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_qa_Paper.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvzx_qa_PaperEN.AnswerCount = objRow[convzx_qa_Paper.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Paper.AnswerCount].ToString().Trim()); //回答计数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_qa_PaperEN.zxShareId = objRow[convzx_qa_Paper.zxShareId] == DBNull.Value ? null : objRow[convzx_qa_Paper.zxShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objvzx_qa_PaperEN.TagsCount = objRow[convzx_qa_Paper.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Paper.TagsCount].ToString().Trim()); //论文标注数(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvzx_qa_PaperDA: GetObjByZxqaPaperId)", objException.Message));
}
return objvzx_qa_PaperEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvzx_qa_PaperEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvzx_qa_PaperDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_qa_PaperDA.GetSpecSQLObj();
strSQL = "Select * from vzx_qa_Paper where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvzx_qa_PaperEN objvzx_qa_PaperEN = new clsvzx_qa_PaperEN()
{
UserName = objRow[convzx_qa_Paper.UserName] == DBNull.Value ? null : objRow[convzx_qa_Paper.UserName].ToString().Trim(), //用户名
IdXzMajor = objRow[convzx_qa_Paper.IdXzMajor] == DBNull.Value ? null : objRow[convzx_qa_Paper.IdXzMajor].ToString().Trim(), //专业流水号
MajorName = objRow[convzx_qa_Paper.MajorName] == DBNull.Value ? null : objRow[convzx_qa_Paper.MajorName].ToString().Trim(), //专业名称
TextTitle = objRow[convzx_qa_Paper.TextTitle] == DBNull.Value ? null : objRow[convzx_qa_Paper.TextTitle].ToString().Trim(), //TextTitle
TextContent = objRow[convzx_qa_Paper.TextContent] == DBNull.Value ? null : objRow[convzx_qa_Paper.TextContent].ToString().Trim(), //TextContent
Author = objRow[convzx_qa_Paper.Author] == DBNull.Value ? null : objRow[convzx_qa_Paper.Author].ToString().Trim(), //作者
ResearchQuestion = objRow[convzx_qa_Paper.ResearchQuestion] == DBNull.Value ? null : objRow[convzx_qa_Paper.ResearchQuestion].ToString().Trim(), //研究问题
LiteratureSources = objRow[convzx_qa_Paper.LiteratureSources] == DBNull.Value ? null : objRow[convzx_qa_Paper.LiteratureSources].ToString().Trim(), //文献来源
LiteratureLink = objRow[convzx_qa_Paper.LiteratureLink] == DBNull.Value ? null : objRow[convzx_qa_Paper.LiteratureLink].ToString().Trim(), //文献链接
UploadfileUrl = objRow[convzx_qa_Paper.UploadfileUrl] == DBNull.Value ? null : objRow[convzx_qa_Paper.UploadfileUrl].ToString().Trim(), //文件地址
AttachmentCount = objRow[convzx_qa_Paper.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_qa_Paper.AttachmentCount].ToString().Trim()), //附件计数
ZxqaPaperId = objRow[convzx_qa_Paper.ZxqaPaperId].ToString().Trim(), //论文答疑Id
QuestionsCount = objRow[convzx_qa_Paper.QuestionsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_qa_Paper.QuestionsCount].ToString().Trim()), //提问计数
TextId = objRow[convzx_qa_Paper.TextId] == DBNull.Value ? null : objRow[convzx_qa_Paper.TextId].ToString().Trim(), //课件Id
IsDelete = TransNullToBool(objRow[convzx_qa_Paper.IsDelete].ToString().Trim()), //是否删除
IsPublic = TransNullToBool(objRow[convzx_qa_Paper.IsPublic].ToString().Trim()), //是否公开
IsSubmit = TransNullToBool(objRow[convzx_qa_Paper.IsSubmit].ToString().Trim()), //是否提交
UpdDate = objRow[convzx_qa_Paper.UpdDate] == DBNull.Value ? null : objRow[convzx_qa_Paper.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convzx_qa_Paper.UpdUser] == DBNull.Value ? null : objRow[convzx_qa_Paper.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convzx_qa_Paper.Memo] == DBNull.Value ? null : objRow[convzx_qa_Paper.Memo].ToString().Trim(), //备注
IdCurrEduCls = objRow[convzx_qa_Paper.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_qa_Paper.IdCurrEduCls].ToString().Trim(), //教学班流水号
AnswerCount = objRow[convzx_qa_Paper.AnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_qa_Paper.AnswerCount].ToString().Trim()), //回答计数
zxShareId = objRow[convzx_qa_Paper.zxShareId] == DBNull.Value ? null : objRow[convzx_qa_Paper.zxShareId].ToString().Trim(), //分享Id
TagsCount = objRow[convzx_qa_Paper.TagsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_qa_Paper.TagsCount].ToString().Trim()) //论文标注数
};
objvzx_qa_PaperEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvzx_qa_PaperEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvzx_qa_PaperDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvzx_qa_PaperEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvzx_qa_PaperEN objvzx_qa_PaperEN = new clsvzx_qa_PaperEN();
try
{
objvzx_qa_PaperEN.UserName = objRow[convzx_qa_Paper.UserName] == DBNull.Value ? null : objRow[convzx_qa_Paper.UserName].ToString().Trim(); //用户名
objvzx_qa_PaperEN.IdXzMajor = objRow[convzx_qa_Paper.IdXzMajor] == DBNull.Value ? null : objRow[convzx_qa_Paper.IdXzMajor].ToString().Trim(); //专业流水号
objvzx_qa_PaperEN.MajorName = objRow[convzx_qa_Paper.MajorName] == DBNull.Value ? null : objRow[convzx_qa_Paper.MajorName].ToString().Trim(); //专业名称
objvzx_qa_PaperEN.TextTitle = objRow[convzx_qa_Paper.TextTitle] == DBNull.Value ? null : objRow[convzx_qa_Paper.TextTitle].ToString().Trim(); //TextTitle
objvzx_qa_PaperEN.TextContent = objRow[convzx_qa_Paper.TextContent] == DBNull.Value ? null : objRow[convzx_qa_Paper.TextContent].ToString().Trim(); //TextContent
objvzx_qa_PaperEN.Author = objRow[convzx_qa_Paper.Author] == DBNull.Value ? null : objRow[convzx_qa_Paper.Author].ToString().Trim(); //作者
objvzx_qa_PaperEN.ResearchQuestion = objRow[convzx_qa_Paper.ResearchQuestion] == DBNull.Value ? null : objRow[convzx_qa_Paper.ResearchQuestion].ToString().Trim(); //研究问题
objvzx_qa_PaperEN.LiteratureSources = objRow[convzx_qa_Paper.LiteratureSources] == DBNull.Value ? null : objRow[convzx_qa_Paper.LiteratureSources].ToString().Trim(); //文献来源
objvzx_qa_PaperEN.LiteratureLink = objRow[convzx_qa_Paper.LiteratureLink] == DBNull.Value ? null : objRow[convzx_qa_Paper.LiteratureLink].ToString().Trim(); //文献链接
objvzx_qa_PaperEN.UploadfileUrl = objRow[convzx_qa_Paper.UploadfileUrl] == DBNull.Value ? null : objRow[convzx_qa_Paper.UploadfileUrl].ToString().Trim(); //文件地址
objvzx_qa_PaperEN.AttachmentCount = objRow[convzx_qa_Paper.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_qa_Paper.AttachmentCount].ToString().Trim()); //附件计数
objvzx_qa_PaperEN.ZxqaPaperId = objRow[convzx_qa_Paper.ZxqaPaperId].ToString().Trim(); //论文答疑Id
objvzx_qa_PaperEN.QuestionsCount = objRow[convzx_qa_Paper.QuestionsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_qa_Paper.QuestionsCount].ToString().Trim()); //提问计数
objvzx_qa_PaperEN.TextId = objRow[convzx_qa_Paper.TextId] == DBNull.Value ? null : objRow[convzx_qa_Paper.TextId].ToString().Trim(); //课件Id
objvzx_qa_PaperEN.IsDelete = TransNullToBool(objRow[convzx_qa_Paper.IsDelete].ToString().Trim()); //是否删除
objvzx_qa_PaperEN.IsPublic = TransNullToBool(objRow[convzx_qa_Paper.IsPublic].ToString().Trim()); //是否公开
objvzx_qa_PaperEN.IsSubmit = TransNullToBool(objRow[convzx_qa_Paper.IsSubmit].ToString().Trim()); //是否提交
objvzx_qa_PaperEN.UpdDate = objRow[convzx_qa_Paper.UpdDate] == DBNull.Value ? null : objRow[convzx_qa_Paper.UpdDate].ToString().Trim(); //修改日期
objvzx_qa_PaperEN.UpdUser = objRow[convzx_qa_Paper.UpdUser] == DBNull.Value ? null : objRow[convzx_qa_Paper.UpdUser].ToString().Trim(); //修改人
objvzx_qa_PaperEN.Memo = objRow[convzx_qa_Paper.Memo] == DBNull.Value ? null : objRow[convzx_qa_Paper.Memo].ToString().Trim(); //备注
objvzx_qa_PaperEN.IdCurrEduCls = objRow[convzx_qa_Paper.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_qa_Paper.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_qa_PaperEN.AnswerCount = objRow[convzx_qa_Paper.AnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_qa_Paper.AnswerCount].ToString().Trim()); //回答计数
objvzx_qa_PaperEN.zxShareId = objRow[convzx_qa_Paper.zxShareId] == DBNull.Value ? null : objRow[convzx_qa_Paper.zxShareId].ToString().Trim(); //分享Id
objvzx_qa_PaperEN.TagsCount = objRow[convzx_qa_Paper.TagsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_qa_Paper.TagsCount].ToString().Trim()); //论文标注数
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvzx_qa_PaperDA: GetObjByDataRowvzx_qa_Paper)", objException.Message));
}
objvzx_qa_PaperEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvzx_qa_PaperEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvzx_qa_PaperEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvzx_qa_PaperEN objvzx_qa_PaperEN = new clsvzx_qa_PaperEN();
try
{
objvzx_qa_PaperEN.UserName = objRow[convzx_qa_Paper.UserName] == DBNull.Value ? null : objRow[convzx_qa_Paper.UserName].ToString().Trim(); //用户名
objvzx_qa_PaperEN.IdXzMajor = objRow[convzx_qa_Paper.IdXzMajor] == DBNull.Value ? null : objRow[convzx_qa_Paper.IdXzMajor].ToString().Trim(); //专业流水号
objvzx_qa_PaperEN.MajorName = objRow[convzx_qa_Paper.MajorName] == DBNull.Value ? null : objRow[convzx_qa_Paper.MajorName].ToString().Trim(); //专业名称
objvzx_qa_PaperEN.TextTitle = objRow[convzx_qa_Paper.TextTitle] == DBNull.Value ? null : objRow[convzx_qa_Paper.TextTitle].ToString().Trim(); //TextTitle
objvzx_qa_PaperEN.TextContent = objRow[convzx_qa_Paper.TextContent] == DBNull.Value ? null : objRow[convzx_qa_Paper.TextContent].ToString().Trim(); //TextContent
objvzx_qa_PaperEN.Author = objRow[convzx_qa_Paper.Author] == DBNull.Value ? null : objRow[convzx_qa_Paper.Author].ToString().Trim(); //作者
objvzx_qa_PaperEN.ResearchQuestion = objRow[convzx_qa_Paper.ResearchQuestion] == DBNull.Value ? null : objRow[convzx_qa_Paper.ResearchQuestion].ToString().Trim(); //研究问题
objvzx_qa_PaperEN.LiteratureSources = objRow[convzx_qa_Paper.LiteratureSources] == DBNull.Value ? null : objRow[convzx_qa_Paper.LiteratureSources].ToString().Trim(); //文献来源
objvzx_qa_PaperEN.LiteratureLink = objRow[convzx_qa_Paper.LiteratureLink] == DBNull.Value ? null : objRow[convzx_qa_Paper.LiteratureLink].ToString().Trim(); //文献链接
objvzx_qa_PaperEN.UploadfileUrl = objRow[convzx_qa_Paper.UploadfileUrl] == DBNull.Value ? null : objRow[convzx_qa_Paper.UploadfileUrl].ToString().Trim(); //文件地址
objvzx_qa_PaperEN.AttachmentCount = objRow[convzx_qa_Paper.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_qa_Paper.AttachmentCount].ToString().Trim()); //附件计数
objvzx_qa_PaperEN.ZxqaPaperId = objRow[convzx_qa_Paper.ZxqaPaperId].ToString().Trim(); //论文答疑Id
objvzx_qa_PaperEN.QuestionsCount = objRow[convzx_qa_Paper.QuestionsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_qa_Paper.QuestionsCount].ToString().Trim()); //提问计数
objvzx_qa_PaperEN.TextId = objRow[convzx_qa_Paper.TextId] == DBNull.Value ? null : objRow[convzx_qa_Paper.TextId].ToString().Trim(); //课件Id
objvzx_qa_PaperEN.IsDelete = TransNullToBool(objRow[convzx_qa_Paper.IsDelete].ToString().Trim()); //是否删除
objvzx_qa_PaperEN.IsPublic = TransNullToBool(objRow[convzx_qa_Paper.IsPublic].ToString().Trim()); //是否公开
objvzx_qa_PaperEN.IsSubmit = TransNullToBool(objRow[convzx_qa_Paper.IsSubmit].ToString().Trim()); //是否提交
objvzx_qa_PaperEN.UpdDate = objRow[convzx_qa_Paper.UpdDate] == DBNull.Value ? null : objRow[convzx_qa_Paper.UpdDate].ToString().Trim(); //修改日期
objvzx_qa_PaperEN.UpdUser = objRow[convzx_qa_Paper.UpdUser] == DBNull.Value ? null : objRow[convzx_qa_Paper.UpdUser].ToString().Trim(); //修改人
objvzx_qa_PaperEN.Memo = objRow[convzx_qa_Paper.Memo] == DBNull.Value ? null : objRow[convzx_qa_Paper.Memo].ToString().Trim(); //备注
objvzx_qa_PaperEN.IdCurrEduCls = objRow[convzx_qa_Paper.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_qa_Paper.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_qa_PaperEN.AnswerCount = objRow[convzx_qa_Paper.AnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_qa_Paper.AnswerCount].ToString().Trim()); //回答计数
objvzx_qa_PaperEN.zxShareId = objRow[convzx_qa_Paper.zxShareId] == DBNull.Value ? null : objRow[convzx_qa_Paper.zxShareId].ToString().Trim(); //分享Id
objvzx_qa_PaperEN.TagsCount = objRow[convzx_qa_Paper.TagsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_qa_Paper.TagsCount].ToString().Trim()); //论文标注数
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvzx_qa_PaperDA: GetObjByDataRow)", objException.Message));
}
objvzx_qa_PaperEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvzx_qa_PaperEN;
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
objSQL = clsvzx_qa_PaperDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvzx_qa_PaperEN._CurrTabName, convzx_qa_Paper.ZxqaPaperId, 8, "");
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
objSQL = clsvzx_qa_PaperDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvzx_qa_PaperEN._CurrTabName, convzx_qa_Paper.ZxqaPaperId, 8, strPrefix);
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
 objSQL = clsvzx_qa_PaperDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select ZxqaPaperId from vzx_qa_Paper where " + strCondition;
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
 objSQL = clsvzx_qa_PaperDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select ZxqaPaperId from vzx_qa_Paper where " + strCondition;
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
 /// <param name = "strZxqaPaperId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strZxqaPaperId)
{
CheckPrimaryKey(strZxqaPaperId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_qa_PaperDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vzx_qa_Paper", "ZxqaPaperId = " + "'"+ strZxqaPaperId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvzx_qa_PaperDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_qa_PaperDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vzx_qa_Paper", strCondition))
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
objSQL = clsvzx_qa_PaperDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vzx_qa_Paper");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvzx_qa_PaperENS">源对象</param>
 /// <param name = "objvzx_qa_PaperENT">目标对象</param>
public void CopyTo(clsvzx_qa_PaperEN objvzx_qa_PaperENS, clsvzx_qa_PaperEN objvzx_qa_PaperENT)
{
objvzx_qa_PaperENT.UserName = objvzx_qa_PaperENS.UserName; //用户名
objvzx_qa_PaperENT.IdXzMajor = objvzx_qa_PaperENS.IdXzMajor; //专业流水号
objvzx_qa_PaperENT.MajorName = objvzx_qa_PaperENS.MajorName; //专业名称
objvzx_qa_PaperENT.TextTitle = objvzx_qa_PaperENS.TextTitle; //TextTitle
objvzx_qa_PaperENT.TextContent = objvzx_qa_PaperENS.TextContent; //TextContent
objvzx_qa_PaperENT.Author = objvzx_qa_PaperENS.Author; //作者
objvzx_qa_PaperENT.ResearchQuestion = objvzx_qa_PaperENS.ResearchQuestion; //研究问题
objvzx_qa_PaperENT.LiteratureSources = objvzx_qa_PaperENS.LiteratureSources; //文献来源
objvzx_qa_PaperENT.LiteratureLink = objvzx_qa_PaperENS.LiteratureLink; //文献链接
objvzx_qa_PaperENT.UploadfileUrl = objvzx_qa_PaperENS.UploadfileUrl; //文件地址
objvzx_qa_PaperENT.AttachmentCount = objvzx_qa_PaperENS.AttachmentCount; //附件计数
objvzx_qa_PaperENT.ZxqaPaperId = objvzx_qa_PaperENS.ZxqaPaperId; //论文答疑Id
objvzx_qa_PaperENT.QuestionsCount = objvzx_qa_PaperENS.QuestionsCount; //提问计数
objvzx_qa_PaperENT.TextId = objvzx_qa_PaperENS.TextId; //课件Id
objvzx_qa_PaperENT.IsDelete = objvzx_qa_PaperENS.IsDelete; //是否删除
objvzx_qa_PaperENT.IsPublic = objvzx_qa_PaperENS.IsPublic; //是否公开
objvzx_qa_PaperENT.IsSubmit = objvzx_qa_PaperENS.IsSubmit; //是否提交
objvzx_qa_PaperENT.UpdDate = objvzx_qa_PaperENS.UpdDate; //修改日期
objvzx_qa_PaperENT.UpdUser = objvzx_qa_PaperENS.UpdUser; //修改人
objvzx_qa_PaperENT.Memo = objvzx_qa_PaperENS.Memo; //备注
objvzx_qa_PaperENT.IdCurrEduCls = objvzx_qa_PaperENS.IdCurrEduCls; //教学班流水号
objvzx_qa_PaperENT.AnswerCount = objvzx_qa_PaperENS.AnswerCount; //回答计数
objvzx_qa_PaperENT.zxShareId = objvzx_qa_PaperENS.zxShareId; //分享Id
objvzx_qa_PaperENT.TagsCount = objvzx_qa_PaperENS.TagsCount; //论文标注数
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvzx_qa_PaperEN objvzx_qa_PaperEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvzx_qa_PaperEN.UserName, 30, convzx_qa_Paper.UserName);
clsCheckSql.CheckFieldLen(objvzx_qa_PaperEN.IdXzMajor, 8, convzx_qa_Paper.IdXzMajor);
clsCheckSql.CheckFieldLen(objvzx_qa_PaperEN.MajorName, 100, convzx_qa_Paper.MajorName);
clsCheckSql.CheckFieldLen(objvzx_qa_PaperEN.TextTitle, 500, convzx_qa_Paper.TextTitle);
clsCheckSql.CheckFieldLen(objvzx_qa_PaperEN.Author, 200, convzx_qa_Paper.Author);
clsCheckSql.CheckFieldLen(objvzx_qa_PaperEN.ResearchQuestion, 2000, convzx_qa_Paper.ResearchQuestion);
clsCheckSql.CheckFieldLen(objvzx_qa_PaperEN.LiteratureSources, 1000, convzx_qa_Paper.LiteratureSources);
clsCheckSql.CheckFieldLen(objvzx_qa_PaperEN.LiteratureLink, 1000, convzx_qa_Paper.LiteratureLink);
clsCheckSql.CheckFieldLen(objvzx_qa_PaperEN.UploadfileUrl, 1000, convzx_qa_Paper.UploadfileUrl);
clsCheckSql.CheckFieldLen(objvzx_qa_PaperEN.ZxqaPaperId, 8, convzx_qa_Paper.ZxqaPaperId);
clsCheckSql.CheckFieldLen(objvzx_qa_PaperEN.TextId, 8, convzx_qa_Paper.TextId);
clsCheckSql.CheckFieldLen(objvzx_qa_PaperEN.UpdDate, 20, convzx_qa_Paper.UpdDate);
clsCheckSql.CheckFieldLen(objvzx_qa_PaperEN.UpdUser, 20, convzx_qa_Paper.UpdUser);
clsCheckSql.CheckFieldLen(objvzx_qa_PaperEN.Memo, 1000, convzx_qa_Paper.Memo);
clsCheckSql.CheckFieldLen(objvzx_qa_PaperEN.IdCurrEduCls, 8, convzx_qa_Paper.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objvzx_qa_PaperEN.zxShareId, 2, convzx_qa_Paper.zxShareId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvzx_qa_PaperEN.UserName, convzx_qa_Paper.UserName);
clsCheckSql.CheckSqlInjection4Field(objvzx_qa_PaperEN.IdXzMajor, convzx_qa_Paper.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objvzx_qa_PaperEN.MajorName, convzx_qa_Paper.MajorName);
clsCheckSql.CheckSqlInjection4Field(objvzx_qa_PaperEN.TextTitle, convzx_qa_Paper.TextTitle);
clsCheckSql.CheckSqlInjection4Field(objvzx_qa_PaperEN.Author, convzx_qa_Paper.Author);
clsCheckSql.CheckSqlInjection4Field(objvzx_qa_PaperEN.ResearchQuestion, convzx_qa_Paper.ResearchQuestion);
clsCheckSql.CheckSqlInjection4Field(objvzx_qa_PaperEN.LiteratureSources, convzx_qa_Paper.LiteratureSources);
clsCheckSql.CheckSqlInjection4Field(objvzx_qa_PaperEN.LiteratureLink, convzx_qa_Paper.LiteratureLink);
clsCheckSql.CheckSqlInjection4Field(objvzx_qa_PaperEN.UploadfileUrl, convzx_qa_Paper.UploadfileUrl);
clsCheckSql.CheckSqlInjection4Field(objvzx_qa_PaperEN.ZxqaPaperId, convzx_qa_Paper.ZxqaPaperId);
clsCheckSql.CheckSqlInjection4Field(objvzx_qa_PaperEN.TextId, convzx_qa_Paper.TextId);
clsCheckSql.CheckSqlInjection4Field(objvzx_qa_PaperEN.UpdDate, convzx_qa_Paper.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvzx_qa_PaperEN.UpdUser, convzx_qa_Paper.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvzx_qa_PaperEN.Memo, convzx_qa_Paper.Memo);
clsCheckSql.CheckSqlInjection4Field(objvzx_qa_PaperEN.IdCurrEduCls, convzx_qa_Paper.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objvzx_qa_PaperEN.zxShareId, convzx_qa_Paper.zxShareId);
//检查外键字段长度
 objvzx_qa_PaperEN._IsCheckProperty = true;
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
 objSQL = clsvzx_qa_PaperDA.GetSpecSQLObj();
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
 objSQL = clsvzx_qa_PaperDA.GetSpecSQLObj();
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
 objSQL = clsvzx_qa_PaperDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvzx_qa_PaperEN._CurrTabName);
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
 objSQL = clsvzx_qa_PaperDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvzx_qa_PaperEN._CurrTabName, strCondition);
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
 objSQL = clsvzx_qa_PaperDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}