
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsXzPhotoNewsDA
 表名:XzPhotoNews(01120421)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:52:14
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:新闻公告(NewsAnn)
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
 /// 图片新闻(XzPhotoNews)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsXzPhotoNewsDA : clsCommBase4DA
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
 return clsXzPhotoNewsEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsXzPhotoNewsEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsXzPhotoNewsEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsXzPhotoNewsEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsXzPhotoNewsEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsXzPhotoNewsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzPhotoNewsDA.GetSpecSQLObj();
strSQL = "Select * from XzPhotoNews where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_XzPhotoNews(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsXzPhotoNewsDA: GetDataTable_XzPhotoNews)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzPhotoNewsDA.GetSpecSQLObj();
strSQL = "Select * from XzPhotoNews where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsXzPhotoNewsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzPhotoNewsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsXzPhotoNewsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzPhotoNewsDA.GetSpecSQLObj();
strSQL = "Select * from XzPhotoNews where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsXzPhotoNewsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzPhotoNewsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsXzPhotoNewsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzPhotoNewsDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from XzPhotoNews where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from XzPhotoNews where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsXzPhotoNewsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzPhotoNewsDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from XzPhotoNews where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsXzPhotoNewsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzPhotoNewsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} XzPhotoNews.* from XzPhotoNews Left Join {1} on {2} where {3} and XzPhotoNews.PhotoNewsId not in (Select top {5} XzPhotoNews.PhotoNewsId from XzPhotoNews Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from XzPhotoNews where {1} and PhotoNewsId not in (Select top {2} PhotoNewsId from XzPhotoNews where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from XzPhotoNews where {1} and PhotoNewsId not in (Select top {3} PhotoNewsId from XzPhotoNews where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsXzPhotoNewsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzPhotoNewsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} XzPhotoNews.* from XzPhotoNews Left Join {1} on {2} where {3} and XzPhotoNews.PhotoNewsId not in (Select top {5} XzPhotoNews.PhotoNewsId from XzPhotoNews Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from XzPhotoNews where {1} and PhotoNewsId not in (Select top {2} PhotoNewsId from XzPhotoNews where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from XzPhotoNews where {1} and PhotoNewsId not in (Select top {3} PhotoNewsId from XzPhotoNews where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsXzPhotoNewsEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsXzPhotoNewsDA:GetObjLst)", objException.Message));
}
List<clsXzPhotoNewsEN> arrObjLst = new List<clsXzPhotoNewsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzPhotoNewsDA.GetSpecSQLObj();
strSQL = "Select * from XzPhotoNews where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzPhotoNewsEN objXzPhotoNewsEN = new clsXzPhotoNewsEN();
try
{
objXzPhotoNewsEN.PhotoNewsId = TransNullToInt(objRow[conXzPhotoNews.PhotoNewsId].ToString().Trim()); //流水号
objXzPhotoNewsEN.PhotoNewsTitle = objRow[conXzPhotoNews.PhotoNewsTitle].ToString().Trim(); //标题
objXzPhotoNewsEN.ImageUrl = objRow[conXzPhotoNews.ImageUrl] == DBNull.Value ? null : objRow[conXzPhotoNews.ImageUrl].ToString().Trim(); //ImageUrl
objXzPhotoNewsEN.PhotoNewsContent = objRow[conXzPhotoNews.PhotoNewsContent] == DBNull.Value ? null : objRow[conXzPhotoNews.PhotoNewsContent].ToString().Trim(); //内容
objXzPhotoNewsEN.PhotoNewsDate = objRow[conXzPhotoNews.PhotoNewsDate] == DBNull.Value ? null : objRow[conXzPhotoNews.PhotoNewsDate].ToString().Trim(); //日期
objXzPhotoNewsEN.PhotoNewsUser = objRow[conXzPhotoNews.PhotoNewsUser] == DBNull.Value ? null : objRow[conXzPhotoNews.PhotoNewsUser].ToString().Trim(); //用户
objXzPhotoNewsEN.DepartmentID = objRow[conXzPhotoNews.DepartmentID].ToString().Trim(); //部门ID
objXzPhotoNewsEN.IdXzMajor = objRow[conXzPhotoNews.IdXzMajor] == DBNull.Value ? null : objRow[conXzPhotoNews.IdXzMajor].ToString().Trim(); //专业流水号
objXzPhotoNewsEN.Views = objRow[conXzPhotoNews.Views] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conXzPhotoNews.Views].ToString().Trim()); //浏览量
objXzPhotoNewsEN.IsTop = TransNullToBool(objRow[conXzPhotoNews.IsTop].ToString().Trim()); //是否置顶
objXzPhotoNewsEN.IsUrgent = TransNullToBool(objRow[conXzPhotoNews.IsUrgent].ToString().Trim()); //是否紧急
objXzPhotoNewsEN.Audit = objRow[conXzPhotoNews.Audit] == DBNull.Value ? null : objRow[conXzPhotoNews.Audit].ToString().Trim(); //审核
objXzPhotoNewsEN.Memo = objRow[conXzPhotoNews.Memo] == DBNull.Value ? null : objRow[conXzPhotoNews.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsXzPhotoNewsDA: GetObjLst)", objException.Message));
}
objXzPhotoNewsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objXzPhotoNewsEN);
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
public List<clsXzPhotoNewsEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsXzPhotoNewsDA:GetObjLstByTabName)", objException.Message));
}
List<clsXzPhotoNewsEN> arrObjLst = new List<clsXzPhotoNewsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzPhotoNewsDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzPhotoNewsEN objXzPhotoNewsEN = new clsXzPhotoNewsEN();
try
{
objXzPhotoNewsEN.PhotoNewsId = TransNullToInt(objRow[conXzPhotoNews.PhotoNewsId].ToString().Trim()); //流水号
objXzPhotoNewsEN.PhotoNewsTitle = objRow[conXzPhotoNews.PhotoNewsTitle].ToString().Trim(); //标题
objXzPhotoNewsEN.ImageUrl = objRow[conXzPhotoNews.ImageUrl] == DBNull.Value ? null : objRow[conXzPhotoNews.ImageUrl].ToString().Trim(); //ImageUrl
objXzPhotoNewsEN.PhotoNewsContent = objRow[conXzPhotoNews.PhotoNewsContent] == DBNull.Value ? null : objRow[conXzPhotoNews.PhotoNewsContent].ToString().Trim(); //内容
objXzPhotoNewsEN.PhotoNewsDate = objRow[conXzPhotoNews.PhotoNewsDate] == DBNull.Value ? null : objRow[conXzPhotoNews.PhotoNewsDate].ToString().Trim(); //日期
objXzPhotoNewsEN.PhotoNewsUser = objRow[conXzPhotoNews.PhotoNewsUser] == DBNull.Value ? null : objRow[conXzPhotoNews.PhotoNewsUser].ToString().Trim(); //用户
objXzPhotoNewsEN.DepartmentID = objRow[conXzPhotoNews.DepartmentID].ToString().Trim(); //部门ID
objXzPhotoNewsEN.IdXzMajor = objRow[conXzPhotoNews.IdXzMajor] == DBNull.Value ? null : objRow[conXzPhotoNews.IdXzMajor].ToString().Trim(); //专业流水号
objXzPhotoNewsEN.Views = objRow[conXzPhotoNews.Views] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conXzPhotoNews.Views].ToString().Trim()); //浏览量
objXzPhotoNewsEN.IsTop = TransNullToBool(objRow[conXzPhotoNews.IsTop].ToString().Trim()); //是否置顶
objXzPhotoNewsEN.IsUrgent = TransNullToBool(objRow[conXzPhotoNews.IsUrgent].ToString().Trim()); //是否紧急
objXzPhotoNewsEN.Audit = objRow[conXzPhotoNews.Audit] == DBNull.Value ? null : objRow[conXzPhotoNews.Audit].ToString().Trim(); //审核
objXzPhotoNewsEN.Memo = objRow[conXzPhotoNews.Memo] == DBNull.Value ? null : objRow[conXzPhotoNews.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsXzPhotoNewsDA: GetObjLst)", objException.Message));
}
objXzPhotoNewsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objXzPhotoNewsEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objXzPhotoNewsEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetXzPhotoNews(ref clsXzPhotoNewsEN objXzPhotoNewsEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzPhotoNewsDA.GetSpecSQLObj();
strSQL = "Select * from XzPhotoNews where PhotoNewsId = " + ""+ objXzPhotoNewsEN.PhotoNewsId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objXzPhotoNewsEN.PhotoNewsId = TransNullToInt(objDT.Rows[0][conXzPhotoNews.PhotoNewsId].ToString().Trim()); //流水号(字段类型:bigint,字段长度:8,是否可空:True)
 objXzPhotoNewsEN.PhotoNewsTitle = objDT.Rows[0][conXzPhotoNews.PhotoNewsTitle].ToString().Trim(); //标题(字段类型:varchar,字段长度:100,是否可空:True)
 objXzPhotoNewsEN.ImageUrl = objDT.Rows[0][conXzPhotoNews.ImageUrl].ToString().Trim(); //ImageUrl(字段类型:varchar,字段长度:100,是否可空:True)
 objXzPhotoNewsEN.PhotoNewsContent = objDT.Rows[0][conXzPhotoNews.PhotoNewsContent].ToString().Trim(); //内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objXzPhotoNewsEN.PhotoNewsDate = objDT.Rows[0][conXzPhotoNews.PhotoNewsDate].ToString().Trim(); //日期(字段类型:char,字段长度:16,是否可空:True)
 objXzPhotoNewsEN.PhotoNewsUser = objDT.Rows[0][conXzPhotoNews.PhotoNewsUser].ToString().Trim(); //用户(字段类型:varchar,字段长度:50,是否可空:True)
 objXzPhotoNewsEN.DepartmentID = objDT.Rows[0][conXzPhotoNews.DepartmentID].ToString().Trim(); //部门ID(字段类型:char,字段长度:8,是否可空:False)
 objXzPhotoNewsEN.IdXzMajor = objDT.Rows[0][conXzPhotoNews.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objXzPhotoNewsEN.Views = TransNullToInt(objDT.Rows[0][conXzPhotoNews.Views].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objXzPhotoNewsEN.IsTop = TransNullToBool(objDT.Rows[0][conXzPhotoNews.IsTop].ToString().Trim()); //是否置顶(字段类型:bit,字段长度:1,是否可空:True)
 objXzPhotoNewsEN.IsUrgent = TransNullToBool(objDT.Rows[0][conXzPhotoNews.IsUrgent].ToString().Trim()); //是否紧急(字段类型:bit,字段长度:1,是否可空:True)
 objXzPhotoNewsEN.Audit = objDT.Rows[0][conXzPhotoNews.Audit].ToString().Trim(); //审核(字段类型:char,字段长度:1,是否可空:True)
 objXzPhotoNewsEN.Memo = objDT.Rows[0][conXzPhotoNews.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsXzPhotoNewsDA: GetXzPhotoNews)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngPhotoNewsId">表关键字</param>
 /// <returns>表对象</returns>
public clsXzPhotoNewsEN GetObjByPhotoNewsId(long lngPhotoNewsId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzPhotoNewsDA.GetSpecSQLObj();
strSQL = "Select * from XzPhotoNews where PhotoNewsId = " + ""+ lngPhotoNewsId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsXzPhotoNewsEN objXzPhotoNewsEN = new clsXzPhotoNewsEN();
try
{
 objXzPhotoNewsEN.PhotoNewsId = Int32.Parse(objRow[conXzPhotoNews.PhotoNewsId].ToString().Trim()); //流水号(字段类型:bigint,字段长度:8,是否可空:True)
 objXzPhotoNewsEN.PhotoNewsTitle = objRow[conXzPhotoNews.PhotoNewsTitle].ToString().Trim(); //标题(字段类型:varchar,字段长度:100,是否可空:True)
 objXzPhotoNewsEN.ImageUrl = objRow[conXzPhotoNews.ImageUrl] == DBNull.Value ? null : objRow[conXzPhotoNews.ImageUrl].ToString().Trim(); //ImageUrl(字段类型:varchar,字段长度:100,是否可空:True)
 objXzPhotoNewsEN.PhotoNewsContent = objRow[conXzPhotoNews.PhotoNewsContent] == DBNull.Value ? null : objRow[conXzPhotoNews.PhotoNewsContent].ToString().Trim(); //内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objXzPhotoNewsEN.PhotoNewsDate = objRow[conXzPhotoNews.PhotoNewsDate] == DBNull.Value ? null : objRow[conXzPhotoNews.PhotoNewsDate].ToString().Trim(); //日期(字段类型:char,字段长度:16,是否可空:True)
 objXzPhotoNewsEN.PhotoNewsUser = objRow[conXzPhotoNews.PhotoNewsUser] == DBNull.Value ? null : objRow[conXzPhotoNews.PhotoNewsUser].ToString().Trim(); //用户(字段类型:varchar,字段长度:50,是否可空:True)
 objXzPhotoNewsEN.DepartmentID = objRow[conXzPhotoNews.DepartmentID].ToString().Trim(); //部门ID(字段类型:char,字段长度:8,是否可空:False)
 objXzPhotoNewsEN.IdXzMajor = objRow[conXzPhotoNews.IdXzMajor] == DBNull.Value ? null : objRow[conXzPhotoNews.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objXzPhotoNewsEN.Views = objRow[conXzPhotoNews.Views] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzPhotoNews.Views].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objXzPhotoNewsEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[conXzPhotoNews.IsTop].ToString().Trim()); //是否置顶(字段类型:bit,字段长度:1,是否可空:True)
 objXzPhotoNewsEN.IsUrgent = clsEntityBase2.TransNullToBool_S(objRow[conXzPhotoNews.IsUrgent].ToString().Trim()); //是否紧急(字段类型:bit,字段长度:1,是否可空:True)
 objXzPhotoNewsEN.Audit = objRow[conXzPhotoNews.Audit] == DBNull.Value ? null : objRow[conXzPhotoNews.Audit].ToString().Trim(); //审核(字段类型:char,字段长度:1,是否可空:True)
 objXzPhotoNewsEN.Memo = objRow[conXzPhotoNews.Memo] == DBNull.Value ? null : objRow[conXzPhotoNews.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsXzPhotoNewsDA: GetObjByPhotoNewsId)", objException.Message));
}
return objXzPhotoNewsEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsXzPhotoNewsEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsXzPhotoNewsDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzPhotoNewsDA.GetSpecSQLObj();
strSQL = "Select * from XzPhotoNews where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsXzPhotoNewsEN objXzPhotoNewsEN = new clsXzPhotoNewsEN()
{
PhotoNewsId = TransNullToInt(objRow[conXzPhotoNews.PhotoNewsId].ToString().Trim()), //流水号
PhotoNewsTitle = objRow[conXzPhotoNews.PhotoNewsTitle].ToString().Trim(), //标题
ImageUrl = objRow[conXzPhotoNews.ImageUrl] == DBNull.Value ? null : objRow[conXzPhotoNews.ImageUrl].ToString().Trim(), //ImageUrl
PhotoNewsContent = objRow[conXzPhotoNews.PhotoNewsContent] == DBNull.Value ? null : objRow[conXzPhotoNews.PhotoNewsContent].ToString().Trim(), //内容
PhotoNewsDate = objRow[conXzPhotoNews.PhotoNewsDate] == DBNull.Value ? null : objRow[conXzPhotoNews.PhotoNewsDate].ToString().Trim(), //日期
PhotoNewsUser = objRow[conXzPhotoNews.PhotoNewsUser] == DBNull.Value ? null : objRow[conXzPhotoNews.PhotoNewsUser].ToString().Trim(), //用户
DepartmentID = objRow[conXzPhotoNews.DepartmentID].ToString().Trim(), //部门ID
IdXzMajor = objRow[conXzPhotoNews.IdXzMajor] == DBNull.Value ? null : objRow[conXzPhotoNews.IdXzMajor].ToString().Trim(), //专业流水号
Views = objRow[conXzPhotoNews.Views] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conXzPhotoNews.Views].ToString().Trim()), //浏览量
IsTop = TransNullToBool(objRow[conXzPhotoNews.IsTop].ToString().Trim()), //是否置顶
IsUrgent = TransNullToBool(objRow[conXzPhotoNews.IsUrgent].ToString().Trim()), //是否紧急
Audit = objRow[conXzPhotoNews.Audit] == DBNull.Value ? null : objRow[conXzPhotoNews.Audit].ToString().Trim(), //审核
Memo = objRow[conXzPhotoNews.Memo] == DBNull.Value ? null : objRow[conXzPhotoNews.Memo].ToString().Trim() //备注
};
objXzPhotoNewsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objXzPhotoNewsEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsXzPhotoNewsDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsXzPhotoNewsEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsXzPhotoNewsEN objXzPhotoNewsEN = new clsXzPhotoNewsEN();
try
{
objXzPhotoNewsEN.PhotoNewsId = TransNullToInt(objRow[conXzPhotoNews.PhotoNewsId].ToString().Trim()); //流水号
objXzPhotoNewsEN.PhotoNewsTitle = objRow[conXzPhotoNews.PhotoNewsTitle].ToString().Trim(); //标题
objXzPhotoNewsEN.ImageUrl = objRow[conXzPhotoNews.ImageUrl] == DBNull.Value ? null : objRow[conXzPhotoNews.ImageUrl].ToString().Trim(); //ImageUrl
objXzPhotoNewsEN.PhotoNewsContent = objRow[conXzPhotoNews.PhotoNewsContent] == DBNull.Value ? null : objRow[conXzPhotoNews.PhotoNewsContent].ToString().Trim(); //内容
objXzPhotoNewsEN.PhotoNewsDate = objRow[conXzPhotoNews.PhotoNewsDate] == DBNull.Value ? null : objRow[conXzPhotoNews.PhotoNewsDate].ToString().Trim(); //日期
objXzPhotoNewsEN.PhotoNewsUser = objRow[conXzPhotoNews.PhotoNewsUser] == DBNull.Value ? null : objRow[conXzPhotoNews.PhotoNewsUser].ToString().Trim(); //用户
objXzPhotoNewsEN.DepartmentID = objRow[conXzPhotoNews.DepartmentID].ToString().Trim(); //部门ID
objXzPhotoNewsEN.IdXzMajor = objRow[conXzPhotoNews.IdXzMajor] == DBNull.Value ? null : objRow[conXzPhotoNews.IdXzMajor].ToString().Trim(); //专业流水号
objXzPhotoNewsEN.Views = objRow[conXzPhotoNews.Views] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conXzPhotoNews.Views].ToString().Trim()); //浏览量
objXzPhotoNewsEN.IsTop = TransNullToBool(objRow[conXzPhotoNews.IsTop].ToString().Trim()); //是否置顶
objXzPhotoNewsEN.IsUrgent = TransNullToBool(objRow[conXzPhotoNews.IsUrgent].ToString().Trim()); //是否紧急
objXzPhotoNewsEN.Audit = objRow[conXzPhotoNews.Audit] == DBNull.Value ? null : objRow[conXzPhotoNews.Audit].ToString().Trim(); //审核
objXzPhotoNewsEN.Memo = objRow[conXzPhotoNews.Memo] == DBNull.Value ? null : objRow[conXzPhotoNews.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsXzPhotoNewsDA: GetObjByDataRowXzPhotoNews)", objException.Message));
}
objXzPhotoNewsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objXzPhotoNewsEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsXzPhotoNewsEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsXzPhotoNewsEN objXzPhotoNewsEN = new clsXzPhotoNewsEN();
try
{
objXzPhotoNewsEN.PhotoNewsId = TransNullToInt(objRow[conXzPhotoNews.PhotoNewsId].ToString().Trim()); //流水号
objXzPhotoNewsEN.PhotoNewsTitle = objRow[conXzPhotoNews.PhotoNewsTitle].ToString().Trim(); //标题
objXzPhotoNewsEN.ImageUrl = objRow[conXzPhotoNews.ImageUrl] == DBNull.Value ? null : objRow[conXzPhotoNews.ImageUrl].ToString().Trim(); //ImageUrl
objXzPhotoNewsEN.PhotoNewsContent = objRow[conXzPhotoNews.PhotoNewsContent] == DBNull.Value ? null : objRow[conXzPhotoNews.PhotoNewsContent].ToString().Trim(); //内容
objXzPhotoNewsEN.PhotoNewsDate = objRow[conXzPhotoNews.PhotoNewsDate] == DBNull.Value ? null : objRow[conXzPhotoNews.PhotoNewsDate].ToString().Trim(); //日期
objXzPhotoNewsEN.PhotoNewsUser = objRow[conXzPhotoNews.PhotoNewsUser] == DBNull.Value ? null : objRow[conXzPhotoNews.PhotoNewsUser].ToString().Trim(); //用户
objXzPhotoNewsEN.DepartmentID = objRow[conXzPhotoNews.DepartmentID].ToString().Trim(); //部门ID
objXzPhotoNewsEN.IdXzMajor = objRow[conXzPhotoNews.IdXzMajor] == DBNull.Value ? null : objRow[conXzPhotoNews.IdXzMajor].ToString().Trim(); //专业流水号
objXzPhotoNewsEN.Views = objRow[conXzPhotoNews.Views] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conXzPhotoNews.Views].ToString().Trim()); //浏览量
objXzPhotoNewsEN.IsTop = TransNullToBool(objRow[conXzPhotoNews.IsTop].ToString().Trim()); //是否置顶
objXzPhotoNewsEN.IsUrgent = TransNullToBool(objRow[conXzPhotoNews.IsUrgent].ToString().Trim()); //是否紧急
objXzPhotoNewsEN.Audit = objRow[conXzPhotoNews.Audit] == DBNull.Value ? null : objRow[conXzPhotoNews.Audit].ToString().Trim(); //审核
objXzPhotoNewsEN.Memo = objRow[conXzPhotoNews.Memo] == DBNull.Value ? null : objRow[conXzPhotoNews.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsXzPhotoNewsDA: GetObjByDataRow)", objException.Message));
}
objXzPhotoNewsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objXzPhotoNewsEN;
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
objSQL = clsXzPhotoNewsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsXzPhotoNewsEN._CurrTabName, conXzPhotoNews.PhotoNewsId, 8, "");
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
objSQL = clsXzPhotoNewsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsXzPhotoNewsEN._CurrTabName, conXzPhotoNews.PhotoNewsId, 8, strPrefix);
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
 objSQL = clsXzPhotoNewsDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select PhotoNewsId from XzPhotoNews where " + strCondition;
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
 objSQL = clsXzPhotoNewsDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select PhotoNewsId from XzPhotoNews where " + strCondition;
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
 /// <param name = "lngPhotoNewsId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngPhotoNewsId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzPhotoNewsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("XzPhotoNews", "PhotoNewsId = " + ""+ lngPhotoNewsId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsXzPhotoNewsDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzPhotoNewsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("XzPhotoNews", strCondition))
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
objSQL = clsXzPhotoNewsDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("XzPhotoNews");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsXzPhotoNewsEN objXzPhotoNewsEN)
 {
 if (objXzPhotoNewsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objXzPhotoNewsEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzPhotoNewsDA.GetSpecSQLObj();
strSQL = "Select * from XzPhotoNews where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "XzPhotoNews");
objRow = objDS.Tables["XzPhotoNews"].NewRow();
objRow[conXzPhotoNews.PhotoNewsTitle] = objXzPhotoNewsEN.PhotoNewsTitle; //标题
 if (objXzPhotoNewsEN.ImageUrl !=  "")
 {
objRow[conXzPhotoNews.ImageUrl] = objXzPhotoNewsEN.ImageUrl; //ImageUrl
 }
 if (objXzPhotoNewsEN.PhotoNewsContent !=  "")
 {
objRow[conXzPhotoNews.PhotoNewsContent] = objXzPhotoNewsEN.PhotoNewsContent; //内容
 }
 if (objXzPhotoNewsEN.PhotoNewsDate !=  "")
 {
objRow[conXzPhotoNews.PhotoNewsDate] = objXzPhotoNewsEN.PhotoNewsDate; //日期
 }
 if (objXzPhotoNewsEN.PhotoNewsUser !=  "")
 {
objRow[conXzPhotoNews.PhotoNewsUser] = objXzPhotoNewsEN.PhotoNewsUser; //用户
 }
objRow[conXzPhotoNews.DepartmentID] = objXzPhotoNewsEN.DepartmentID; //部门ID
 if (objXzPhotoNewsEN.IdXzMajor !=  "")
 {
objRow[conXzPhotoNews.IdXzMajor] = objXzPhotoNewsEN.IdXzMajor; //专业流水号
 }
objRow[conXzPhotoNews.Views] = objXzPhotoNewsEN.Views; //浏览量
objRow[conXzPhotoNews.IsTop] = objXzPhotoNewsEN.IsTop; //是否置顶
objRow[conXzPhotoNews.IsUrgent] = objXzPhotoNewsEN.IsUrgent; //是否紧急
 if (objXzPhotoNewsEN.Audit !=  "")
 {
objRow[conXzPhotoNews.Audit] = objXzPhotoNewsEN.Audit; //审核
 }
 if (objXzPhotoNewsEN.Memo !=  "")
 {
objRow[conXzPhotoNews.Memo] = objXzPhotoNewsEN.Memo; //备注
 }
objDS.Tables[clsXzPhotoNewsEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsXzPhotoNewsEN._CurrTabName);
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
 /// <param name = "objXzPhotoNewsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsXzPhotoNewsEN objXzPhotoNewsEN)
{
 if (objXzPhotoNewsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objXzPhotoNewsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objXzPhotoNewsEN.PhotoNewsTitle !=  null)
 {
 arrFieldListForInsert.Add(conXzPhotoNews.PhotoNewsTitle);
 var strPhotoNewsTitle = objXzPhotoNewsEN.PhotoNewsTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPhotoNewsTitle + "'");
 }
 
 if (objXzPhotoNewsEN.ImageUrl !=  null)
 {
 arrFieldListForInsert.Add(conXzPhotoNews.ImageUrl);
 var strImageUrl = objXzPhotoNewsEN.ImageUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strImageUrl + "'");
 }
 
 if (objXzPhotoNewsEN.PhotoNewsContent !=  null)
 {
 arrFieldListForInsert.Add(conXzPhotoNews.PhotoNewsContent);
 var strPhotoNewsContent = objXzPhotoNewsEN.PhotoNewsContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPhotoNewsContent + "'");
 }
 
 if (objXzPhotoNewsEN.PhotoNewsDate !=  null)
 {
 arrFieldListForInsert.Add(conXzPhotoNews.PhotoNewsDate);
 var strPhotoNewsDate = objXzPhotoNewsEN.PhotoNewsDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPhotoNewsDate + "'");
 }
 
 if (objXzPhotoNewsEN.PhotoNewsUser !=  null)
 {
 arrFieldListForInsert.Add(conXzPhotoNews.PhotoNewsUser);
 var strPhotoNewsUser = objXzPhotoNewsEN.PhotoNewsUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPhotoNewsUser + "'");
 }
 
 if (objXzPhotoNewsEN.DepartmentID !=  null)
 {
 arrFieldListForInsert.Add(conXzPhotoNews.DepartmentID);
 var strDepartmentID = objXzPhotoNewsEN.DepartmentID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDepartmentID + "'");
 }
 
 if (objXzPhotoNewsEN.IdXzMajor !=  null)
 {
 arrFieldListForInsert.Add(conXzPhotoNews.IdXzMajor);
 var strIdXzMajor = objXzPhotoNewsEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzMajor + "'");
 }
 
 if (objXzPhotoNewsEN.Views !=  null)
 {
 arrFieldListForInsert.Add(conXzPhotoNews.Views);
 arrValueListForInsert.Add(objXzPhotoNewsEN.Views.ToString());
 }
 
 arrFieldListForInsert.Add(conXzPhotoNews.IsTop);
 arrValueListForInsert.Add("'" + (objXzPhotoNewsEN.IsTop  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conXzPhotoNews.IsUrgent);
 arrValueListForInsert.Add("'" + (objXzPhotoNewsEN.IsUrgent  ==  false ? "0" : "1") + "'");
 
 if (objXzPhotoNewsEN.Audit !=  null)
 {
 arrFieldListForInsert.Add(conXzPhotoNews.Audit);
 var strAudit = objXzPhotoNewsEN.Audit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAudit + "'");
 }
 
 if (objXzPhotoNewsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conXzPhotoNews.Memo);
 var strMemo = objXzPhotoNewsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into XzPhotoNews");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzPhotoNewsDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objXzPhotoNewsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsXzPhotoNewsEN objXzPhotoNewsEN)
{
 if (objXzPhotoNewsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objXzPhotoNewsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objXzPhotoNewsEN.PhotoNewsTitle !=  null)
 {
 arrFieldListForInsert.Add(conXzPhotoNews.PhotoNewsTitle);
 var strPhotoNewsTitle = objXzPhotoNewsEN.PhotoNewsTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPhotoNewsTitle + "'");
 }
 
 if (objXzPhotoNewsEN.ImageUrl !=  null)
 {
 arrFieldListForInsert.Add(conXzPhotoNews.ImageUrl);
 var strImageUrl = objXzPhotoNewsEN.ImageUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strImageUrl + "'");
 }
 
 if (objXzPhotoNewsEN.PhotoNewsContent !=  null)
 {
 arrFieldListForInsert.Add(conXzPhotoNews.PhotoNewsContent);
 var strPhotoNewsContent = objXzPhotoNewsEN.PhotoNewsContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPhotoNewsContent + "'");
 }
 
 if (objXzPhotoNewsEN.PhotoNewsDate !=  null)
 {
 arrFieldListForInsert.Add(conXzPhotoNews.PhotoNewsDate);
 var strPhotoNewsDate = objXzPhotoNewsEN.PhotoNewsDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPhotoNewsDate + "'");
 }
 
 if (objXzPhotoNewsEN.PhotoNewsUser !=  null)
 {
 arrFieldListForInsert.Add(conXzPhotoNews.PhotoNewsUser);
 var strPhotoNewsUser = objXzPhotoNewsEN.PhotoNewsUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPhotoNewsUser + "'");
 }
 
 if (objXzPhotoNewsEN.DepartmentID !=  null)
 {
 arrFieldListForInsert.Add(conXzPhotoNews.DepartmentID);
 var strDepartmentID = objXzPhotoNewsEN.DepartmentID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDepartmentID + "'");
 }
 
 if (objXzPhotoNewsEN.IdXzMajor !=  null)
 {
 arrFieldListForInsert.Add(conXzPhotoNews.IdXzMajor);
 var strIdXzMajor = objXzPhotoNewsEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzMajor + "'");
 }
 
 if (objXzPhotoNewsEN.Views !=  null)
 {
 arrFieldListForInsert.Add(conXzPhotoNews.Views);
 arrValueListForInsert.Add(objXzPhotoNewsEN.Views.ToString());
 }
 
 arrFieldListForInsert.Add(conXzPhotoNews.IsTop);
 arrValueListForInsert.Add("'" + (objXzPhotoNewsEN.IsTop  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conXzPhotoNews.IsUrgent);
 arrValueListForInsert.Add("'" + (objXzPhotoNewsEN.IsUrgent  ==  false ? "0" : "1") + "'");
 
 if (objXzPhotoNewsEN.Audit !=  null)
 {
 arrFieldListForInsert.Add(conXzPhotoNews.Audit);
 var strAudit = objXzPhotoNewsEN.Audit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAudit + "'");
 }
 
 if (objXzPhotoNewsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conXzPhotoNews.Memo);
 var strMemo = objXzPhotoNewsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into XzPhotoNews");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzPhotoNewsDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objXzPhotoNewsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsXzPhotoNewsEN objXzPhotoNewsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objXzPhotoNewsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objXzPhotoNewsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objXzPhotoNewsEN.PhotoNewsTitle !=  null)
 {
 arrFieldListForInsert.Add(conXzPhotoNews.PhotoNewsTitle);
 var strPhotoNewsTitle = objXzPhotoNewsEN.PhotoNewsTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPhotoNewsTitle + "'");
 }
 
 if (objXzPhotoNewsEN.ImageUrl !=  null)
 {
 arrFieldListForInsert.Add(conXzPhotoNews.ImageUrl);
 var strImageUrl = objXzPhotoNewsEN.ImageUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strImageUrl + "'");
 }
 
 if (objXzPhotoNewsEN.PhotoNewsContent !=  null)
 {
 arrFieldListForInsert.Add(conXzPhotoNews.PhotoNewsContent);
 var strPhotoNewsContent = objXzPhotoNewsEN.PhotoNewsContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPhotoNewsContent + "'");
 }
 
 if (objXzPhotoNewsEN.PhotoNewsDate !=  null)
 {
 arrFieldListForInsert.Add(conXzPhotoNews.PhotoNewsDate);
 var strPhotoNewsDate = objXzPhotoNewsEN.PhotoNewsDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPhotoNewsDate + "'");
 }
 
 if (objXzPhotoNewsEN.PhotoNewsUser !=  null)
 {
 arrFieldListForInsert.Add(conXzPhotoNews.PhotoNewsUser);
 var strPhotoNewsUser = objXzPhotoNewsEN.PhotoNewsUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPhotoNewsUser + "'");
 }
 
 if (objXzPhotoNewsEN.DepartmentID !=  null)
 {
 arrFieldListForInsert.Add(conXzPhotoNews.DepartmentID);
 var strDepartmentID = objXzPhotoNewsEN.DepartmentID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDepartmentID + "'");
 }
 
 if (objXzPhotoNewsEN.IdXzMajor !=  null)
 {
 arrFieldListForInsert.Add(conXzPhotoNews.IdXzMajor);
 var strIdXzMajor = objXzPhotoNewsEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzMajor + "'");
 }
 
 if (objXzPhotoNewsEN.Views !=  null)
 {
 arrFieldListForInsert.Add(conXzPhotoNews.Views);
 arrValueListForInsert.Add(objXzPhotoNewsEN.Views.ToString());
 }
 
 arrFieldListForInsert.Add(conXzPhotoNews.IsTop);
 arrValueListForInsert.Add("'" + (objXzPhotoNewsEN.IsTop  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conXzPhotoNews.IsUrgent);
 arrValueListForInsert.Add("'" + (objXzPhotoNewsEN.IsUrgent  ==  false ? "0" : "1") + "'");
 
 if (objXzPhotoNewsEN.Audit !=  null)
 {
 arrFieldListForInsert.Add(conXzPhotoNews.Audit);
 var strAudit = objXzPhotoNewsEN.Audit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAudit + "'");
 }
 
 if (objXzPhotoNewsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conXzPhotoNews.Memo);
 var strMemo = objXzPhotoNewsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into XzPhotoNews");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzPhotoNewsDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objXzPhotoNewsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsXzPhotoNewsEN objXzPhotoNewsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objXzPhotoNewsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objXzPhotoNewsEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objXzPhotoNewsEN.PhotoNewsTitle !=  null)
 {
 arrFieldListForInsert.Add(conXzPhotoNews.PhotoNewsTitle);
 var strPhotoNewsTitle = objXzPhotoNewsEN.PhotoNewsTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPhotoNewsTitle + "'");
 }
 
 if (objXzPhotoNewsEN.ImageUrl !=  null)
 {
 arrFieldListForInsert.Add(conXzPhotoNews.ImageUrl);
 var strImageUrl = objXzPhotoNewsEN.ImageUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strImageUrl + "'");
 }
 
 if (objXzPhotoNewsEN.PhotoNewsContent !=  null)
 {
 arrFieldListForInsert.Add(conXzPhotoNews.PhotoNewsContent);
 var strPhotoNewsContent = objXzPhotoNewsEN.PhotoNewsContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPhotoNewsContent + "'");
 }
 
 if (objXzPhotoNewsEN.PhotoNewsDate !=  null)
 {
 arrFieldListForInsert.Add(conXzPhotoNews.PhotoNewsDate);
 var strPhotoNewsDate = objXzPhotoNewsEN.PhotoNewsDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPhotoNewsDate + "'");
 }
 
 if (objXzPhotoNewsEN.PhotoNewsUser !=  null)
 {
 arrFieldListForInsert.Add(conXzPhotoNews.PhotoNewsUser);
 var strPhotoNewsUser = objXzPhotoNewsEN.PhotoNewsUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPhotoNewsUser + "'");
 }
 
 if (objXzPhotoNewsEN.DepartmentID !=  null)
 {
 arrFieldListForInsert.Add(conXzPhotoNews.DepartmentID);
 var strDepartmentID = objXzPhotoNewsEN.DepartmentID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDepartmentID + "'");
 }
 
 if (objXzPhotoNewsEN.IdXzMajor !=  null)
 {
 arrFieldListForInsert.Add(conXzPhotoNews.IdXzMajor);
 var strIdXzMajor = objXzPhotoNewsEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzMajor + "'");
 }
 
 if (objXzPhotoNewsEN.Views !=  null)
 {
 arrFieldListForInsert.Add(conXzPhotoNews.Views);
 arrValueListForInsert.Add(objXzPhotoNewsEN.Views.ToString());
 }
 
 arrFieldListForInsert.Add(conXzPhotoNews.IsTop);
 arrValueListForInsert.Add("'" + (objXzPhotoNewsEN.IsTop  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conXzPhotoNews.IsUrgent);
 arrValueListForInsert.Add("'" + (objXzPhotoNewsEN.IsUrgent  ==  false ? "0" : "1") + "'");
 
 if (objXzPhotoNewsEN.Audit !=  null)
 {
 arrFieldListForInsert.Add(conXzPhotoNews.Audit);
 var strAudit = objXzPhotoNewsEN.Audit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAudit + "'");
 }
 
 if (objXzPhotoNewsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conXzPhotoNews.Memo);
 var strMemo = objXzPhotoNewsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into XzPhotoNews");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzPhotoNewsDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewXzPhotoNewss(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzPhotoNewsDA.GetSpecSQLObj();
strSQL = "Select * from XzPhotoNews where PhotoNewsId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "XzPhotoNews");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngPhotoNewsId = TransNullToInt(oRow[conXzPhotoNews.PhotoNewsId].ToString().Trim());
if (IsExist(lngPhotoNewsId))
{
 string strResult = "关键字变量值为:" + string.Format("PhotoNewsId = {0}", lngPhotoNewsId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsXzPhotoNewsEN._CurrTabName ].NewRow();
objRow[conXzPhotoNews.PhotoNewsTitle] = oRow[conXzPhotoNews.PhotoNewsTitle].ToString().Trim(); //标题
objRow[conXzPhotoNews.ImageUrl] = oRow[conXzPhotoNews.ImageUrl].ToString().Trim(); //ImageUrl
objRow[conXzPhotoNews.PhotoNewsContent] = oRow[conXzPhotoNews.PhotoNewsContent].ToString().Trim(); //内容
objRow[conXzPhotoNews.PhotoNewsDate] = oRow[conXzPhotoNews.PhotoNewsDate].ToString().Trim(); //日期
objRow[conXzPhotoNews.PhotoNewsUser] = oRow[conXzPhotoNews.PhotoNewsUser].ToString().Trim(); //用户
objRow[conXzPhotoNews.DepartmentID] = oRow[conXzPhotoNews.DepartmentID].ToString().Trim(); //部门ID
objRow[conXzPhotoNews.IdXzMajor] = oRow[conXzPhotoNews.IdXzMajor].ToString().Trim(); //专业流水号
objRow[conXzPhotoNews.Views] = oRow[conXzPhotoNews.Views].ToString().Trim(); //浏览量
objRow[conXzPhotoNews.IsTop] = oRow[conXzPhotoNews.IsTop].ToString().Trim(); //是否置顶
objRow[conXzPhotoNews.IsUrgent] = oRow[conXzPhotoNews.IsUrgent].ToString().Trim(); //是否紧急
objRow[conXzPhotoNews.Audit] = oRow[conXzPhotoNews.Audit].ToString().Trim(); //审核
objRow[conXzPhotoNews.Memo] = oRow[conXzPhotoNews.Memo].ToString().Trim(); //备注
 objDS.Tables[clsXzPhotoNewsEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsXzPhotoNewsEN._CurrTabName);
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
 /// <param name = "objXzPhotoNewsEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsXzPhotoNewsEN objXzPhotoNewsEN)
{
 if (objXzPhotoNewsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objXzPhotoNewsEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzPhotoNewsDA.GetSpecSQLObj();
strSQL = "Select * from XzPhotoNews where PhotoNewsId = " + ""+ objXzPhotoNewsEN.PhotoNewsId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsXzPhotoNewsEN._CurrTabName);
if (objDS.Tables[clsXzPhotoNewsEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:PhotoNewsId = " + ""+ objXzPhotoNewsEN.PhotoNewsId+"");
return false;
}
objRow = objDS.Tables[clsXzPhotoNewsEN._CurrTabName].Rows[0];
 if (objXzPhotoNewsEN.IsUpdated(conXzPhotoNews.PhotoNewsTitle))
 {
objRow[conXzPhotoNews.PhotoNewsTitle] = objXzPhotoNewsEN.PhotoNewsTitle; //标题
 }
 if (objXzPhotoNewsEN.IsUpdated(conXzPhotoNews.ImageUrl))
 {
objRow[conXzPhotoNews.ImageUrl] = objXzPhotoNewsEN.ImageUrl; //ImageUrl
 }
 if (objXzPhotoNewsEN.IsUpdated(conXzPhotoNews.PhotoNewsContent))
 {
objRow[conXzPhotoNews.PhotoNewsContent] = objXzPhotoNewsEN.PhotoNewsContent; //内容
 }
 if (objXzPhotoNewsEN.IsUpdated(conXzPhotoNews.PhotoNewsDate))
 {
objRow[conXzPhotoNews.PhotoNewsDate] = objXzPhotoNewsEN.PhotoNewsDate; //日期
 }
 if (objXzPhotoNewsEN.IsUpdated(conXzPhotoNews.PhotoNewsUser))
 {
objRow[conXzPhotoNews.PhotoNewsUser] = objXzPhotoNewsEN.PhotoNewsUser; //用户
 }
 if (objXzPhotoNewsEN.IsUpdated(conXzPhotoNews.DepartmentID))
 {
objRow[conXzPhotoNews.DepartmentID] = objXzPhotoNewsEN.DepartmentID; //部门ID
 }
 if (objXzPhotoNewsEN.IsUpdated(conXzPhotoNews.IdXzMajor))
 {
objRow[conXzPhotoNews.IdXzMajor] = objXzPhotoNewsEN.IdXzMajor; //专业流水号
 }
 if (objXzPhotoNewsEN.IsUpdated(conXzPhotoNews.Views))
 {
objRow[conXzPhotoNews.Views] = objXzPhotoNewsEN.Views; //浏览量
 }
 if (objXzPhotoNewsEN.IsUpdated(conXzPhotoNews.IsTop))
 {
objRow[conXzPhotoNews.IsTop] = objXzPhotoNewsEN.IsTop; //是否置顶
 }
 if (objXzPhotoNewsEN.IsUpdated(conXzPhotoNews.IsUrgent))
 {
objRow[conXzPhotoNews.IsUrgent] = objXzPhotoNewsEN.IsUrgent; //是否紧急
 }
 if (objXzPhotoNewsEN.IsUpdated(conXzPhotoNews.Audit))
 {
objRow[conXzPhotoNews.Audit] = objXzPhotoNewsEN.Audit; //审核
 }
 if (objXzPhotoNewsEN.IsUpdated(conXzPhotoNews.Memo))
 {
objRow[conXzPhotoNews.Memo] = objXzPhotoNewsEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsXzPhotoNewsEN._CurrTabName);
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
 /// <param name = "objXzPhotoNewsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsXzPhotoNewsEN objXzPhotoNewsEN)
{
 if (objXzPhotoNewsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objXzPhotoNewsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzPhotoNewsDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update XzPhotoNews Set ");
 
 if (objXzPhotoNewsEN.IsUpdated(conXzPhotoNews.PhotoNewsTitle))
 {
 if (objXzPhotoNewsEN.PhotoNewsTitle !=  null)
 {
 var strPhotoNewsTitle = objXzPhotoNewsEN.PhotoNewsTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPhotoNewsTitle, conXzPhotoNews.PhotoNewsTitle); //标题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzPhotoNews.PhotoNewsTitle); //标题
 }
 }
 
 if (objXzPhotoNewsEN.IsUpdated(conXzPhotoNews.ImageUrl))
 {
 if (objXzPhotoNewsEN.ImageUrl !=  null)
 {
 var strImageUrl = objXzPhotoNewsEN.ImageUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strImageUrl, conXzPhotoNews.ImageUrl); //ImageUrl
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzPhotoNews.ImageUrl); //ImageUrl
 }
 }
 
 if (objXzPhotoNewsEN.IsUpdated(conXzPhotoNews.PhotoNewsContent))
 {
 if (objXzPhotoNewsEN.PhotoNewsContent !=  null)
 {
 var strPhotoNewsContent = objXzPhotoNewsEN.PhotoNewsContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPhotoNewsContent, conXzPhotoNews.PhotoNewsContent); //内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzPhotoNews.PhotoNewsContent); //内容
 }
 }
 
 if (objXzPhotoNewsEN.IsUpdated(conXzPhotoNews.PhotoNewsDate))
 {
 if (objXzPhotoNewsEN.PhotoNewsDate !=  null)
 {
 var strPhotoNewsDate = objXzPhotoNewsEN.PhotoNewsDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPhotoNewsDate, conXzPhotoNews.PhotoNewsDate); //日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzPhotoNews.PhotoNewsDate); //日期
 }
 }
 
 if (objXzPhotoNewsEN.IsUpdated(conXzPhotoNews.PhotoNewsUser))
 {
 if (objXzPhotoNewsEN.PhotoNewsUser !=  null)
 {
 var strPhotoNewsUser = objXzPhotoNewsEN.PhotoNewsUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPhotoNewsUser, conXzPhotoNews.PhotoNewsUser); //用户
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzPhotoNews.PhotoNewsUser); //用户
 }
 }
 
 if (objXzPhotoNewsEN.IsUpdated(conXzPhotoNews.DepartmentID))
 {
 if (objXzPhotoNewsEN.DepartmentID !=  null)
 {
 var strDepartmentID = objXzPhotoNewsEN.DepartmentID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDepartmentID, conXzPhotoNews.DepartmentID); //部门ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzPhotoNews.DepartmentID); //部门ID
 }
 }
 
 if (objXzPhotoNewsEN.IsUpdated(conXzPhotoNews.IdXzMajor))
 {
 if (objXzPhotoNewsEN.IdXzMajor !=  null)
 {
 var strIdXzMajor = objXzPhotoNewsEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdXzMajor, conXzPhotoNews.IdXzMajor); //专业流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzPhotoNews.IdXzMajor); //专业流水号
 }
 }
 
 if (objXzPhotoNewsEN.IsUpdated(conXzPhotoNews.Views))
 {
 if (objXzPhotoNewsEN.Views !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objXzPhotoNewsEN.Views, conXzPhotoNews.Views); //浏览量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzPhotoNews.Views); //浏览量
 }
 }
 
 if (objXzPhotoNewsEN.IsUpdated(conXzPhotoNews.IsTop))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objXzPhotoNewsEN.IsTop == true?"1":"0", conXzPhotoNews.IsTop); //是否置顶
 }
 
 if (objXzPhotoNewsEN.IsUpdated(conXzPhotoNews.IsUrgent))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objXzPhotoNewsEN.IsUrgent == true?"1":"0", conXzPhotoNews.IsUrgent); //是否紧急
 }
 
 if (objXzPhotoNewsEN.IsUpdated(conXzPhotoNews.Audit))
 {
 if (objXzPhotoNewsEN.Audit !=  null)
 {
 var strAudit = objXzPhotoNewsEN.Audit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAudit, conXzPhotoNews.Audit); //审核
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzPhotoNews.Audit); //审核
 }
 }
 
 if (objXzPhotoNewsEN.IsUpdated(conXzPhotoNews.Memo))
 {
 if (objXzPhotoNewsEN.Memo !=  null)
 {
 var strMemo = objXzPhotoNewsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conXzPhotoNews.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzPhotoNews.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where PhotoNewsId = {0}", objXzPhotoNewsEN.PhotoNewsId); 
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
 /// <param name = "objXzPhotoNewsEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsXzPhotoNewsEN objXzPhotoNewsEN, string strCondition)
{
 if (objXzPhotoNewsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objXzPhotoNewsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzPhotoNewsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update XzPhotoNews Set ");
 
 if (objXzPhotoNewsEN.IsUpdated(conXzPhotoNews.PhotoNewsTitle))
 {
 if (objXzPhotoNewsEN.PhotoNewsTitle !=  null)
 {
 var strPhotoNewsTitle = objXzPhotoNewsEN.PhotoNewsTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PhotoNewsTitle = '{0}',", strPhotoNewsTitle); //标题
 }
 else
 {
 sbSQL.Append(" PhotoNewsTitle = null,"); //标题
 }
 }
 
 if (objXzPhotoNewsEN.IsUpdated(conXzPhotoNews.ImageUrl))
 {
 if (objXzPhotoNewsEN.ImageUrl !=  null)
 {
 var strImageUrl = objXzPhotoNewsEN.ImageUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ImageUrl = '{0}',", strImageUrl); //ImageUrl
 }
 else
 {
 sbSQL.Append(" ImageUrl = null,"); //ImageUrl
 }
 }
 
 if (objXzPhotoNewsEN.IsUpdated(conXzPhotoNews.PhotoNewsContent))
 {
 if (objXzPhotoNewsEN.PhotoNewsContent !=  null)
 {
 var strPhotoNewsContent = objXzPhotoNewsEN.PhotoNewsContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PhotoNewsContent = '{0}',", strPhotoNewsContent); //内容
 }
 else
 {
 sbSQL.Append(" PhotoNewsContent = null,"); //内容
 }
 }
 
 if (objXzPhotoNewsEN.IsUpdated(conXzPhotoNews.PhotoNewsDate))
 {
 if (objXzPhotoNewsEN.PhotoNewsDate !=  null)
 {
 var strPhotoNewsDate = objXzPhotoNewsEN.PhotoNewsDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PhotoNewsDate = '{0}',", strPhotoNewsDate); //日期
 }
 else
 {
 sbSQL.Append(" PhotoNewsDate = null,"); //日期
 }
 }
 
 if (objXzPhotoNewsEN.IsUpdated(conXzPhotoNews.PhotoNewsUser))
 {
 if (objXzPhotoNewsEN.PhotoNewsUser !=  null)
 {
 var strPhotoNewsUser = objXzPhotoNewsEN.PhotoNewsUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PhotoNewsUser = '{0}',", strPhotoNewsUser); //用户
 }
 else
 {
 sbSQL.Append(" PhotoNewsUser = null,"); //用户
 }
 }
 
 if (objXzPhotoNewsEN.IsUpdated(conXzPhotoNews.DepartmentID))
 {
 if (objXzPhotoNewsEN.DepartmentID !=  null)
 {
 var strDepartmentID = objXzPhotoNewsEN.DepartmentID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DepartmentID = '{0}',", strDepartmentID); //部门ID
 }
 else
 {
 sbSQL.Append(" DepartmentID = null,"); //部门ID
 }
 }
 
 if (objXzPhotoNewsEN.IsUpdated(conXzPhotoNews.IdXzMajor))
 {
 if (objXzPhotoNewsEN.IdXzMajor !=  null)
 {
 var strIdXzMajor = objXzPhotoNewsEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdXzMajor = '{0}',", strIdXzMajor); //专业流水号
 }
 else
 {
 sbSQL.Append(" IdXzMajor = null,"); //专业流水号
 }
 }
 
 if (objXzPhotoNewsEN.IsUpdated(conXzPhotoNews.Views))
 {
 sbSQL.AppendFormat(" Views = {0},", objXzPhotoNewsEN.Views); //浏览量
 }
 
 if (objXzPhotoNewsEN.IsUpdated(conXzPhotoNews.IsTop))
 {
 sbSQL.AppendFormat(" IsTop = '{0}',", objXzPhotoNewsEN.IsTop == true?"1":"0"); //是否置顶
 }
 
 if (objXzPhotoNewsEN.IsUpdated(conXzPhotoNews.IsUrgent))
 {
 sbSQL.AppendFormat(" IsUrgent = '{0}',", objXzPhotoNewsEN.IsUrgent == true?"1":"0"); //是否紧急
 }
 
 if (objXzPhotoNewsEN.IsUpdated(conXzPhotoNews.Audit))
 {
 if (objXzPhotoNewsEN.Audit !=  null)
 {
 var strAudit = objXzPhotoNewsEN.Audit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Audit = '{0}',", strAudit); //审核
 }
 else
 {
 sbSQL.Append(" Audit = null,"); //审核
 }
 }
 
 if (objXzPhotoNewsEN.IsUpdated(conXzPhotoNews.Memo))
 {
 if (objXzPhotoNewsEN.Memo !=  null)
 {
 var strMemo = objXzPhotoNewsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objXzPhotoNewsEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsXzPhotoNewsEN objXzPhotoNewsEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objXzPhotoNewsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objXzPhotoNewsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzPhotoNewsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update XzPhotoNews Set ");
 
 if (objXzPhotoNewsEN.IsUpdated(conXzPhotoNews.PhotoNewsTitle))
 {
 if (objXzPhotoNewsEN.PhotoNewsTitle !=  null)
 {
 var strPhotoNewsTitle = objXzPhotoNewsEN.PhotoNewsTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PhotoNewsTitle = '{0}',", strPhotoNewsTitle); //标题
 }
 else
 {
 sbSQL.Append(" PhotoNewsTitle = null,"); //标题
 }
 }
 
 if (objXzPhotoNewsEN.IsUpdated(conXzPhotoNews.ImageUrl))
 {
 if (objXzPhotoNewsEN.ImageUrl !=  null)
 {
 var strImageUrl = objXzPhotoNewsEN.ImageUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ImageUrl = '{0}',", strImageUrl); //ImageUrl
 }
 else
 {
 sbSQL.Append(" ImageUrl = null,"); //ImageUrl
 }
 }
 
 if (objXzPhotoNewsEN.IsUpdated(conXzPhotoNews.PhotoNewsContent))
 {
 if (objXzPhotoNewsEN.PhotoNewsContent !=  null)
 {
 var strPhotoNewsContent = objXzPhotoNewsEN.PhotoNewsContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PhotoNewsContent = '{0}',", strPhotoNewsContent); //内容
 }
 else
 {
 sbSQL.Append(" PhotoNewsContent = null,"); //内容
 }
 }
 
 if (objXzPhotoNewsEN.IsUpdated(conXzPhotoNews.PhotoNewsDate))
 {
 if (objXzPhotoNewsEN.PhotoNewsDate !=  null)
 {
 var strPhotoNewsDate = objXzPhotoNewsEN.PhotoNewsDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PhotoNewsDate = '{0}',", strPhotoNewsDate); //日期
 }
 else
 {
 sbSQL.Append(" PhotoNewsDate = null,"); //日期
 }
 }
 
 if (objXzPhotoNewsEN.IsUpdated(conXzPhotoNews.PhotoNewsUser))
 {
 if (objXzPhotoNewsEN.PhotoNewsUser !=  null)
 {
 var strPhotoNewsUser = objXzPhotoNewsEN.PhotoNewsUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PhotoNewsUser = '{0}',", strPhotoNewsUser); //用户
 }
 else
 {
 sbSQL.Append(" PhotoNewsUser = null,"); //用户
 }
 }
 
 if (objXzPhotoNewsEN.IsUpdated(conXzPhotoNews.DepartmentID))
 {
 if (objXzPhotoNewsEN.DepartmentID !=  null)
 {
 var strDepartmentID = objXzPhotoNewsEN.DepartmentID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DepartmentID = '{0}',", strDepartmentID); //部门ID
 }
 else
 {
 sbSQL.Append(" DepartmentID = null,"); //部门ID
 }
 }
 
 if (objXzPhotoNewsEN.IsUpdated(conXzPhotoNews.IdXzMajor))
 {
 if (objXzPhotoNewsEN.IdXzMajor !=  null)
 {
 var strIdXzMajor = objXzPhotoNewsEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdXzMajor = '{0}',", strIdXzMajor); //专业流水号
 }
 else
 {
 sbSQL.Append(" IdXzMajor = null,"); //专业流水号
 }
 }
 
 if (objXzPhotoNewsEN.IsUpdated(conXzPhotoNews.Views))
 {
 sbSQL.AppendFormat(" Views = {0},", objXzPhotoNewsEN.Views); //浏览量
 }
 
 if (objXzPhotoNewsEN.IsUpdated(conXzPhotoNews.IsTop))
 {
 sbSQL.AppendFormat(" IsTop = '{0}',", objXzPhotoNewsEN.IsTop == true?"1":"0"); //是否置顶
 }
 
 if (objXzPhotoNewsEN.IsUpdated(conXzPhotoNews.IsUrgent))
 {
 sbSQL.AppendFormat(" IsUrgent = '{0}',", objXzPhotoNewsEN.IsUrgent == true?"1":"0"); //是否紧急
 }
 
 if (objXzPhotoNewsEN.IsUpdated(conXzPhotoNews.Audit))
 {
 if (objXzPhotoNewsEN.Audit !=  null)
 {
 var strAudit = objXzPhotoNewsEN.Audit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Audit = '{0}',", strAudit); //审核
 }
 else
 {
 sbSQL.Append(" Audit = null,"); //审核
 }
 }
 
 if (objXzPhotoNewsEN.IsUpdated(conXzPhotoNews.Memo))
 {
 if (objXzPhotoNewsEN.Memo !=  null)
 {
 var strMemo = objXzPhotoNewsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objXzPhotoNewsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsXzPhotoNewsEN objXzPhotoNewsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objXzPhotoNewsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objXzPhotoNewsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzPhotoNewsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update XzPhotoNews Set ");
 
 if (objXzPhotoNewsEN.IsUpdated(conXzPhotoNews.PhotoNewsTitle))
 {
 if (objXzPhotoNewsEN.PhotoNewsTitle !=  null)
 {
 var strPhotoNewsTitle = objXzPhotoNewsEN.PhotoNewsTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPhotoNewsTitle, conXzPhotoNews.PhotoNewsTitle); //标题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzPhotoNews.PhotoNewsTitle); //标题
 }
 }
 
 if (objXzPhotoNewsEN.IsUpdated(conXzPhotoNews.ImageUrl))
 {
 if (objXzPhotoNewsEN.ImageUrl !=  null)
 {
 var strImageUrl = objXzPhotoNewsEN.ImageUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strImageUrl, conXzPhotoNews.ImageUrl); //ImageUrl
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzPhotoNews.ImageUrl); //ImageUrl
 }
 }
 
 if (objXzPhotoNewsEN.IsUpdated(conXzPhotoNews.PhotoNewsContent))
 {
 if (objXzPhotoNewsEN.PhotoNewsContent !=  null)
 {
 var strPhotoNewsContent = objXzPhotoNewsEN.PhotoNewsContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPhotoNewsContent, conXzPhotoNews.PhotoNewsContent); //内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzPhotoNews.PhotoNewsContent); //内容
 }
 }
 
 if (objXzPhotoNewsEN.IsUpdated(conXzPhotoNews.PhotoNewsDate))
 {
 if (objXzPhotoNewsEN.PhotoNewsDate !=  null)
 {
 var strPhotoNewsDate = objXzPhotoNewsEN.PhotoNewsDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPhotoNewsDate, conXzPhotoNews.PhotoNewsDate); //日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzPhotoNews.PhotoNewsDate); //日期
 }
 }
 
 if (objXzPhotoNewsEN.IsUpdated(conXzPhotoNews.PhotoNewsUser))
 {
 if (objXzPhotoNewsEN.PhotoNewsUser !=  null)
 {
 var strPhotoNewsUser = objXzPhotoNewsEN.PhotoNewsUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPhotoNewsUser, conXzPhotoNews.PhotoNewsUser); //用户
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzPhotoNews.PhotoNewsUser); //用户
 }
 }
 
 if (objXzPhotoNewsEN.IsUpdated(conXzPhotoNews.DepartmentID))
 {
 if (objXzPhotoNewsEN.DepartmentID !=  null)
 {
 var strDepartmentID = objXzPhotoNewsEN.DepartmentID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDepartmentID, conXzPhotoNews.DepartmentID); //部门ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzPhotoNews.DepartmentID); //部门ID
 }
 }
 
 if (objXzPhotoNewsEN.IsUpdated(conXzPhotoNews.IdXzMajor))
 {
 if (objXzPhotoNewsEN.IdXzMajor !=  null)
 {
 var strIdXzMajor = objXzPhotoNewsEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdXzMajor, conXzPhotoNews.IdXzMajor); //专业流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzPhotoNews.IdXzMajor); //专业流水号
 }
 }
 
 if (objXzPhotoNewsEN.IsUpdated(conXzPhotoNews.Views))
 {
 if (objXzPhotoNewsEN.Views !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objXzPhotoNewsEN.Views, conXzPhotoNews.Views); //浏览量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzPhotoNews.Views); //浏览量
 }
 }
 
 if (objXzPhotoNewsEN.IsUpdated(conXzPhotoNews.IsTop))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objXzPhotoNewsEN.IsTop == true?"1":"0", conXzPhotoNews.IsTop); //是否置顶
 }
 
 if (objXzPhotoNewsEN.IsUpdated(conXzPhotoNews.IsUrgent))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objXzPhotoNewsEN.IsUrgent == true?"1":"0", conXzPhotoNews.IsUrgent); //是否紧急
 }
 
 if (objXzPhotoNewsEN.IsUpdated(conXzPhotoNews.Audit))
 {
 if (objXzPhotoNewsEN.Audit !=  null)
 {
 var strAudit = objXzPhotoNewsEN.Audit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAudit, conXzPhotoNews.Audit); //审核
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzPhotoNews.Audit); //审核
 }
 }
 
 if (objXzPhotoNewsEN.IsUpdated(conXzPhotoNews.Memo))
 {
 if (objXzPhotoNewsEN.Memo !=  null)
 {
 var strMemo = objXzPhotoNewsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conXzPhotoNews.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzPhotoNews.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where PhotoNewsId = {0}", objXzPhotoNewsEN.PhotoNewsId); 
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
 /// <param name = "lngPhotoNewsId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngPhotoNewsId) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzPhotoNewsDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngPhotoNewsId,
};
 objSQL.ExecSP("XzPhotoNews_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngPhotoNewsId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngPhotoNewsId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzPhotoNewsDA.GetSpecSQLObj();
//删除XzPhotoNews本表中与当前对象有关的记录
strSQL = strSQL + "Delete from XzPhotoNews where PhotoNewsId = " + ""+ lngPhotoNewsId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelXzPhotoNews(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzPhotoNewsDA.GetSpecSQLObj();
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
//删除XzPhotoNews本表中与当前对象有关的记录
strSQL = strSQL + "Delete from XzPhotoNews where PhotoNewsId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngPhotoNewsId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngPhotoNewsId) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzPhotoNewsDA.GetSpecSQLObj();
//删除XzPhotoNews本表中与当前对象有关的记录
strSQL = strSQL + "Delete from XzPhotoNews where PhotoNewsId = " + ""+ lngPhotoNewsId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelXzPhotoNews(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsXzPhotoNewsDA: DelXzPhotoNews)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzPhotoNewsDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from XzPhotoNews where " + strCondition ;
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
public bool DelXzPhotoNewsWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsXzPhotoNewsDA: DelXzPhotoNewsWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzPhotoNewsDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from XzPhotoNews where " + strCondition ;
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
 /// <param name = "objXzPhotoNewsENS">源对象</param>
 /// <param name = "objXzPhotoNewsENT">目标对象</param>
public void CopyTo(clsXzPhotoNewsEN objXzPhotoNewsENS, clsXzPhotoNewsEN objXzPhotoNewsENT)
{
objXzPhotoNewsENT.PhotoNewsId = objXzPhotoNewsENS.PhotoNewsId; //流水号
objXzPhotoNewsENT.PhotoNewsTitle = objXzPhotoNewsENS.PhotoNewsTitle; //标题
objXzPhotoNewsENT.ImageUrl = objXzPhotoNewsENS.ImageUrl; //ImageUrl
objXzPhotoNewsENT.PhotoNewsContent = objXzPhotoNewsENS.PhotoNewsContent; //内容
objXzPhotoNewsENT.PhotoNewsDate = objXzPhotoNewsENS.PhotoNewsDate; //日期
objXzPhotoNewsENT.PhotoNewsUser = objXzPhotoNewsENS.PhotoNewsUser; //用户
objXzPhotoNewsENT.DepartmentID = objXzPhotoNewsENS.DepartmentID; //部门ID
objXzPhotoNewsENT.IdXzMajor = objXzPhotoNewsENS.IdXzMajor; //专业流水号
objXzPhotoNewsENT.Views = objXzPhotoNewsENS.Views; //浏览量
objXzPhotoNewsENT.IsTop = objXzPhotoNewsENS.IsTop; //是否置顶
objXzPhotoNewsENT.IsUrgent = objXzPhotoNewsENS.IsUrgent; //是否紧急
objXzPhotoNewsENT.Audit = objXzPhotoNewsENS.Audit; //审核
objXzPhotoNewsENT.Memo = objXzPhotoNewsENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsXzPhotoNewsEN objXzPhotoNewsEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objXzPhotoNewsEN.PhotoNewsTitle, conXzPhotoNews.PhotoNewsTitle);
clsCheckSql.CheckFieldNotNull(objXzPhotoNewsEN.DepartmentID, conXzPhotoNews.DepartmentID);
//检查字段长度
clsCheckSql.CheckFieldLen(objXzPhotoNewsEN.PhotoNewsTitle, 100, conXzPhotoNews.PhotoNewsTitle);
clsCheckSql.CheckFieldLen(objXzPhotoNewsEN.ImageUrl, 100, conXzPhotoNews.ImageUrl);
clsCheckSql.CheckFieldLen(objXzPhotoNewsEN.PhotoNewsDate, 16, conXzPhotoNews.PhotoNewsDate);
clsCheckSql.CheckFieldLen(objXzPhotoNewsEN.PhotoNewsUser, 50, conXzPhotoNews.PhotoNewsUser);
clsCheckSql.CheckFieldLen(objXzPhotoNewsEN.DepartmentID, 8, conXzPhotoNews.DepartmentID);
clsCheckSql.CheckFieldLen(objXzPhotoNewsEN.IdXzMajor, 8, conXzPhotoNews.IdXzMajor);
clsCheckSql.CheckFieldLen(objXzPhotoNewsEN.Audit, 1, conXzPhotoNews.Audit);
clsCheckSql.CheckFieldLen(objXzPhotoNewsEN.Memo, 1000, conXzPhotoNews.Memo);
//检查字段外键固定长度
 objXzPhotoNewsEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsXzPhotoNewsEN objXzPhotoNewsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objXzPhotoNewsEN.PhotoNewsTitle, 100, conXzPhotoNews.PhotoNewsTitle);
clsCheckSql.CheckFieldLen(objXzPhotoNewsEN.ImageUrl, 100, conXzPhotoNews.ImageUrl);
clsCheckSql.CheckFieldLen(objXzPhotoNewsEN.PhotoNewsDate, 16, conXzPhotoNews.PhotoNewsDate);
clsCheckSql.CheckFieldLen(objXzPhotoNewsEN.PhotoNewsUser, 50, conXzPhotoNews.PhotoNewsUser);
clsCheckSql.CheckFieldLen(objXzPhotoNewsEN.DepartmentID, 8, conXzPhotoNews.DepartmentID);
clsCheckSql.CheckFieldLen(objXzPhotoNewsEN.IdXzMajor, 8, conXzPhotoNews.IdXzMajor);
clsCheckSql.CheckFieldLen(objXzPhotoNewsEN.Audit, 1, conXzPhotoNews.Audit);
clsCheckSql.CheckFieldLen(objXzPhotoNewsEN.Memo, 1000, conXzPhotoNews.Memo);
//检查外键字段长度
 objXzPhotoNewsEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsXzPhotoNewsEN objXzPhotoNewsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objXzPhotoNewsEN.PhotoNewsTitle, 100, conXzPhotoNews.PhotoNewsTitle);
clsCheckSql.CheckFieldLen(objXzPhotoNewsEN.ImageUrl, 100, conXzPhotoNews.ImageUrl);
clsCheckSql.CheckFieldLen(objXzPhotoNewsEN.PhotoNewsDate, 16, conXzPhotoNews.PhotoNewsDate);
clsCheckSql.CheckFieldLen(objXzPhotoNewsEN.PhotoNewsUser, 50, conXzPhotoNews.PhotoNewsUser);
clsCheckSql.CheckFieldLen(objXzPhotoNewsEN.DepartmentID, 8, conXzPhotoNews.DepartmentID);
clsCheckSql.CheckFieldLen(objXzPhotoNewsEN.IdXzMajor, 8, conXzPhotoNews.IdXzMajor);
clsCheckSql.CheckFieldLen(objXzPhotoNewsEN.Audit, 1, conXzPhotoNews.Audit);
clsCheckSql.CheckFieldLen(objXzPhotoNewsEN.Memo, 1000, conXzPhotoNews.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objXzPhotoNewsEN.PhotoNewsTitle, conXzPhotoNews.PhotoNewsTitle);
clsCheckSql.CheckSqlInjection4Field(objXzPhotoNewsEN.ImageUrl, conXzPhotoNews.ImageUrl);
clsCheckSql.CheckSqlInjection4Field(objXzPhotoNewsEN.PhotoNewsDate, conXzPhotoNews.PhotoNewsDate);
clsCheckSql.CheckSqlInjection4Field(objXzPhotoNewsEN.PhotoNewsUser, conXzPhotoNews.PhotoNewsUser);
clsCheckSql.CheckSqlInjection4Field(objXzPhotoNewsEN.DepartmentID, conXzPhotoNews.DepartmentID);
clsCheckSql.CheckSqlInjection4Field(objXzPhotoNewsEN.IdXzMajor, conXzPhotoNews.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objXzPhotoNewsEN.Audit, conXzPhotoNews.Audit);
clsCheckSql.CheckSqlInjection4Field(objXzPhotoNewsEN.Memo, conXzPhotoNews.Memo);
//检查外键字段长度
 objXzPhotoNewsEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--XzPhotoNews(图片新闻),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objXzPhotoNewsEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsXzPhotoNewsEN objXzPhotoNewsEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PhotoNewsTitle = '{0}'", objXzPhotoNewsEN.PhotoNewsTitle);
 if (objXzPhotoNewsEN.PhotoNewsUser == null)
{
 sbCondition.AppendFormat(" and PhotoNewsUser is null");
}
else
{
 sbCondition.AppendFormat(" and PhotoNewsUser = '{0}'", objXzPhotoNewsEN.PhotoNewsUser);
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
 objSQL = clsXzPhotoNewsDA.GetSpecSQLObj();
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
 objSQL = clsXzPhotoNewsDA.GetSpecSQLObj();
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
 objSQL = clsXzPhotoNewsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsXzPhotoNewsEN._CurrTabName);
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
 objSQL = clsXzPhotoNewsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsXzPhotoNewsEN._CurrTabName, strCondition);
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
 objSQL = clsXzPhotoNewsDA.GetSpecSQLObj();
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
 objSQL = clsXzPhotoNewsDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}