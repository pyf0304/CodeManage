
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvXzPhotoNewsDA
 表名:vXzPhotoNews(01120420)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:51:18
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
 /// v图片新闻(vXzPhotoNews)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvXzPhotoNewsDA : clsCommBase4DA
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
 return clsvXzPhotoNewsEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvXzPhotoNewsEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvXzPhotoNewsEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvXzPhotoNewsEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvXzPhotoNewsEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvXzPhotoNewsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzPhotoNewsDA.GetSpecSQLObj();
strSQL = "Select * from vXzPhotoNews where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vXzPhotoNews(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvXzPhotoNewsDA: GetDataTable_vXzPhotoNews)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzPhotoNewsDA.GetSpecSQLObj();
strSQL = "Select * from vXzPhotoNews where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvXzPhotoNewsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzPhotoNewsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvXzPhotoNewsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzPhotoNewsDA.GetSpecSQLObj();
strSQL = "Select * from vXzPhotoNews where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvXzPhotoNewsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzPhotoNewsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvXzPhotoNewsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzPhotoNewsDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vXzPhotoNews where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vXzPhotoNews where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvXzPhotoNewsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzPhotoNewsDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vXzPhotoNews where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvXzPhotoNewsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzPhotoNewsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vXzPhotoNews.* from vXzPhotoNews Left Join {1} on {2} where {3} and vXzPhotoNews.PhotoNewsId not in (Select top {5} vXzPhotoNews.PhotoNewsId from vXzPhotoNews Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vXzPhotoNews where {1} and PhotoNewsId not in (Select top {2} PhotoNewsId from vXzPhotoNews where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vXzPhotoNews where {1} and PhotoNewsId not in (Select top {3} PhotoNewsId from vXzPhotoNews where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvXzPhotoNewsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzPhotoNewsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vXzPhotoNews.* from vXzPhotoNews Left Join {1} on {2} where {3} and vXzPhotoNews.PhotoNewsId not in (Select top {5} vXzPhotoNews.PhotoNewsId from vXzPhotoNews Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vXzPhotoNews where {1} and PhotoNewsId not in (Select top {2} PhotoNewsId from vXzPhotoNews where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vXzPhotoNews where {1} and PhotoNewsId not in (Select top {3} PhotoNewsId from vXzPhotoNews where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvXzPhotoNewsEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvXzPhotoNewsDA:GetObjLst)", objException.Message));
}
List<clsvXzPhotoNewsEN> arrObjLst = new List<clsvXzPhotoNewsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzPhotoNewsDA.GetSpecSQLObj();
strSQL = "Select * from vXzPhotoNews where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzPhotoNewsEN objvXzPhotoNewsEN = new clsvXzPhotoNewsEN();
try
{
objvXzPhotoNewsEN.PhotoNewsId = TransNullToInt(objRow[convXzPhotoNews.PhotoNewsId].ToString().Trim()); //流水号
objvXzPhotoNewsEN.DepartmentID = objRow[convXzPhotoNews.DepartmentID].ToString().Trim(); //部门ID
objvXzPhotoNewsEN.Views = objRow[convXzPhotoNews.Views] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convXzPhotoNews.Views].ToString().Trim()); //浏览量
objvXzPhotoNewsEN.IsTop = TransNullToBool(objRow[convXzPhotoNews.IsTop].ToString().Trim()); //是否置顶
objvXzPhotoNewsEN.IsUrgent = TransNullToBool(objRow[convXzPhotoNews.IsUrgent].ToString().Trim()); //是否紧急
objvXzPhotoNewsEN.Audit = objRow[convXzPhotoNews.Audit] == DBNull.Value ? null : objRow[convXzPhotoNews.Audit].ToString().Trim(); //审核
objvXzPhotoNewsEN.PhotoNewsTitle = objRow[convXzPhotoNews.PhotoNewsTitle].ToString().Trim(); //标题
objvXzPhotoNewsEN.ImageUrl = objRow[convXzPhotoNews.ImageUrl] == DBNull.Value ? null : objRow[convXzPhotoNews.ImageUrl].ToString().Trim(); //ImageUrl
objvXzPhotoNewsEN.PhotoNewsContent = objRow[convXzPhotoNews.PhotoNewsContent] == DBNull.Value ? null : objRow[convXzPhotoNews.PhotoNewsContent].ToString().Trim(); //内容
objvXzPhotoNewsEN.PhotoNewsDate = objRow[convXzPhotoNews.PhotoNewsDate].ToString().Trim(); //日期
objvXzPhotoNewsEN.PhotoNewsUser = objRow[convXzPhotoNews.PhotoNewsUser].ToString().Trim(); //用户
objvXzPhotoNewsEN.Memo = objRow[convXzPhotoNews.Memo] == DBNull.Value ? null : objRow[convXzPhotoNews.Memo].ToString().Trim(); //备注
objvXzPhotoNewsEN.CollegeName = objRow[convXzPhotoNews.CollegeName] == DBNull.Value ? null : objRow[convXzPhotoNews.CollegeName].ToString().Trim(); //学院名称
objvXzPhotoNewsEN.IdXzCollege = objRow[convXzPhotoNews.IdXzCollege] == DBNull.Value ? null : objRow[convXzPhotoNews.IdXzCollege].ToString().Trim(); //学院流水号
objvXzPhotoNewsEN.IdXzMajor = objRow[convXzPhotoNews.IdXzMajor].ToString().Trim(); //专业流水号
objvXzPhotoNewsEN.MajorID = objRow[convXzPhotoNews.MajorID] == DBNull.Value ? null : objRow[convXzPhotoNews.MajorID].ToString().Trim(); //专业ID
objvXzPhotoNewsEN.MajorName = objRow[convXzPhotoNews.MajorName] == DBNull.Value ? null : objRow[convXzPhotoNews.MajorName].ToString().Trim(); //专业名称
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvXzPhotoNewsDA: GetObjLst)", objException.Message));
}
objvXzPhotoNewsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvXzPhotoNewsEN);
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
public List<clsvXzPhotoNewsEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvXzPhotoNewsDA:GetObjLstByTabName)", objException.Message));
}
List<clsvXzPhotoNewsEN> arrObjLst = new List<clsvXzPhotoNewsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzPhotoNewsDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzPhotoNewsEN objvXzPhotoNewsEN = new clsvXzPhotoNewsEN();
try
{
objvXzPhotoNewsEN.PhotoNewsId = TransNullToInt(objRow[convXzPhotoNews.PhotoNewsId].ToString().Trim()); //流水号
objvXzPhotoNewsEN.DepartmentID = objRow[convXzPhotoNews.DepartmentID].ToString().Trim(); //部门ID
objvXzPhotoNewsEN.Views = objRow[convXzPhotoNews.Views] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convXzPhotoNews.Views].ToString().Trim()); //浏览量
objvXzPhotoNewsEN.IsTop = TransNullToBool(objRow[convXzPhotoNews.IsTop].ToString().Trim()); //是否置顶
objvXzPhotoNewsEN.IsUrgent = TransNullToBool(objRow[convXzPhotoNews.IsUrgent].ToString().Trim()); //是否紧急
objvXzPhotoNewsEN.Audit = objRow[convXzPhotoNews.Audit] == DBNull.Value ? null : objRow[convXzPhotoNews.Audit].ToString().Trim(); //审核
objvXzPhotoNewsEN.PhotoNewsTitle = objRow[convXzPhotoNews.PhotoNewsTitle].ToString().Trim(); //标题
objvXzPhotoNewsEN.ImageUrl = objRow[convXzPhotoNews.ImageUrl] == DBNull.Value ? null : objRow[convXzPhotoNews.ImageUrl].ToString().Trim(); //ImageUrl
objvXzPhotoNewsEN.PhotoNewsContent = objRow[convXzPhotoNews.PhotoNewsContent] == DBNull.Value ? null : objRow[convXzPhotoNews.PhotoNewsContent].ToString().Trim(); //内容
objvXzPhotoNewsEN.PhotoNewsDate = objRow[convXzPhotoNews.PhotoNewsDate].ToString().Trim(); //日期
objvXzPhotoNewsEN.PhotoNewsUser = objRow[convXzPhotoNews.PhotoNewsUser].ToString().Trim(); //用户
objvXzPhotoNewsEN.Memo = objRow[convXzPhotoNews.Memo] == DBNull.Value ? null : objRow[convXzPhotoNews.Memo].ToString().Trim(); //备注
objvXzPhotoNewsEN.CollegeName = objRow[convXzPhotoNews.CollegeName] == DBNull.Value ? null : objRow[convXzPhotoNews.CollegeName].ToString().Trim(); //学院名称
objvXzPhotoNewsEN.IdXzCollege = objRow[convXzPhotoNews.IdXzCollege] == DBNull.Value ? null : objRow[convXzPhotoNews.IdXzCollege].ToString().Trim(); //学院流水号
objvXzPhotoNewsEN.IdXzMajor = objRow[convXzPhotoNews.IdXzMajor].ToString().Trim(); //专业流水号
objvXzPhotoNewsEN.MajorID = objRow[convXzPhotoNews.MajorID] == DBNull.Value ? null : objRow[convXzPhotoNews.MajorID].ToString().Trim(); //专业ID
objvXzPhotoNewsEN.MajorName = objRow[convXzPhotoNews.MajorName] == DBNull.Value ? null : objRow[convXzPhotoNews.MajorName].ToString().Trim(); //专业名称
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvXzPhotoNewsDA: GetObjLst)", objException.Message));
}
objvXzPhotoNewsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvXzPhotoNewsEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvXzPhotoNewsEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvXzPhotoNews(ref clsvXzPhotoNewsEN objvXzPhotoNewsEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzPhotoNewsDA.GetSpecSQLObj();
strSQL = "Select * from vXzPhotoNews where PhotoNewsId = " + ""+ objvXzPhotoNewsEN.PhotoNewsId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvXzPhotoNewsEN.PhotoNewsId = TransNullToInt(objDT.Rows[0][convXzPhotoNews.PhotoNewsId].ToString().Trim()); //流水号(字段类型:bigint,字段长度:8,是否可空:True)
 objvXzPhotoNewsEN.DepartmentID = objDT.Rows[0][convXzPhotoNews.DepartmentID].ToString().Trim(); //部门ID(字段类型:char,字段长度:8,是否可空:False)
 objvXzPhotoNewsEN.Views = TransNullToInt(objDT.Rows[0][convXzPhotoNews.Views].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvXzPhotoNewsEN.IsTop = TransNullToBool(objDT.Rows[0][convXzPhotoNews.IsTop].ToString().Trim()); //是否置顶(字段类型:bit,字段长度:1,是否可空:True)
 objvXzPhotoNewsEN.IsUrgent = TransNullToBool(objDT.Rows[0][convXzPhotoNews.IsUrgent].ToString().Trim()); //是否紧急(字段类型:bit,字段长度:1,是否可空:True)
 objvXzPhotoNewsEN.Audit = objDT.Rows[0][convXzPhotoNews.Audit].ToString().Trim(); //审核(字段类型:char,字段长度:1,是否可空:True)
 objvXzPhotoNewsEN.PhotoNewsTitle = objDT.Rows[0][convXzPhotoNews.PhotoNewsTitle].ToString().Trim(); //标题(字段类型:varchar,字段长度:100,是否可空:True)
 objvXzPhotoNewsEN.ImageUrl = objDT.Rows[0][convXzPhotoNews.ImageUrl].ToString().Trim(); //ImageUrl(字段类型:varchar,字段长度:100,是否可空:True)
 objvXzPhotoNewsEN.PhotoNewsContent = objDT.Rows[0][convXzPhotoNews.PhotoNewsContent].ToString().Trim(); //内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvXzPhotoNewsEN.PhotoNewsDate = objDT.Rows[0][convXzPhotoNews.PhotoNewsDate].ToString().Trim(); //日期(字段类型:char,字段长度:16,是否可空:True)
 objvXzPhotoNewsEN.PhotoNewsUser = objDT.Rows[0][convXzPhotoNews.PhotoNewsUser].ToString().Trim(); //用户(字段类型:varchar,字段长度:50,是否可空:True)
 objvXzPhotoNewsEN.Memo = objDT.Rows[0][convXzPhotoNews.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvXzPhotoNewsEN.CollegeName = objDT.Rows[0][convXzPhotoNews.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvXzPhotoNewsEN.IdXzCollege = objDT.Rows[0][convXzPhotoNews.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvXzPhotoNewsEN.IdXzMajor = objDT.Rows[0][convXzPhotoNews.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvXzPhotoNewsEN.MajorID = objDT.Rows[0][convXzPhotoNews.MajorID].ToString().Trim(); //专业ID(字段类型:char,字段长度:4,是否可空:False)
 objvXzPhotoNewsEN.MajorName = objDT.Rows[0][convXzPhotoNews.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvXzPhotoNewsDA: GetvXzPhotoNews)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngPhotoNewsId">表关键字</param>
 /// <returns>表对象</returns>
public clsvXzPhotoNewsEN GetObjByPhotoNewsId(long lngPhotoNewsId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzPhotoNewsDA.GetSpecSQLObj();
strSQL = "Select * from vXzPhotoNews where PhotoNewsId = " + ""+ lngPhotoNewsId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvXzPhotoNewsEN objvXzPhotoNewsEN = new clsvXzPhotoNewsEN();
try
{
 objvXzPhotoNewsEN.PhotoNewsId = Int32.Parse(objRow[convXzPhotoNews.PhotoNewsId].ToString().Trim()); //流水号(字段类型:bigint,字段长度:8,是否可空:True)
 objvXzPhotoNewsEN.DepartmentID = objRow[convXzPhotoNews.DepartmentID].ToString().Trim(); //部门ID(字段类型:char,字段长度:8,是否可空:False)
 objvXzPhotoNewsEN.Views = objRow[convXzPhotoNews.Views] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzPhotoNews.Views].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvXzPhotoNewsEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[convXzPhotoNews.IsTop].ToString().Trim()); //是否置顶(字段类型:bit,字段长度:1,是否可空:True)
 objvXzPhotoNewsEN.IsUrgent = clsEntityBase2.TransNullToBool_S(objRow[convXzPhotoNews.IsUrgent].ToString().Trim()); //是否紧急(字段类型:bit,字段长度:1,是否可空:True)
 objvXzPhotoNewsEN.Audit = objRow[convXzPhotoNews.Audit] == DBNull.Value ? null : objRow[convXzPhotoNews.Audit].ToString().Trim(); //审核(字段类型:char,字段长度:1,是否可空:True)
 objvXzPhotoNewsEN.PhotoNewsTitle = objRow[convXzPhotoNews.PhotoNewsTitle].ToString().Trim(); //标题(字段类型:varchar,字段长度:100,是否可空:True)
 objvXzPhotoNewsEN.ImageUrl = objRow[convXzPhotoNews.ImageUrl] == DBNull.Value ? null : objRow[convXzPhotoNews.ImageUrl].ToString().Trim(); //ImageUrl(字段类型:varchar,字段长度:100,是否可空:True)
 objvXzPhotoNewsEN.PhotoNewsContent = objRow[convXzPhotoNews.PhotoNewsContent] == DBNull.Value ? null : objRow[convXzPhotoNews.PhotoNewsContent].ToString().Trim(); //内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvXzPhotoNewsEN.PhotoNewsDate = objRow[convXzPhotoNews.PhotoNewsDate].ToString().Trim(); //日期(字段类型:char,字段长度:16,是否可空:True)
 objvXzPhotoNewsEN.PhotoNewsUser = objRow[convXzPhotoNews.PhotoNewsUser].ToString().Trim(); //用户(字段类型:varchar,字段长度:50,是否可空:True)
 objvXzPhotoNewsEN.Memo = objRow[convXzPhotoNews.Memo] == DBNull.Value ? null : objRow[convXzPhotoNews.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvXzPhotoNewsEN.CollegeName = objRow[convXzPhotoNews.CollegeName] == DBNull.Value ? null : objRow[convXzPhotoNews.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvXzPhotoNewsEN.IdXzCollege = objRow[convXzPhotoNews.IdXzCollege] == DBNull.Value ? null : objRow[convXzPhotoNews.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvXzPhotoNewsEN.IdXzMajor = objRow[convXzPhotoNews.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvXzPhotoNewsEN.MajorID = objRow[convXzPhotoNews.MajorID] == DBNull.Value ? null : objRow[convXzPhotoNews.MajorID].ToString().Trim(); //专业ID(字段类型:char,字段长度:4,是否可空:False)
 objvXzPhotoNewsEN.MajorName = objRow[convXzPhotoNews.MajorName] == DBNull.Value ? null : objRow[convXzPhotoNews.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvXzPhotoNewsDA: GetObjByPhotoNewsId)", objException.Message));
}
return objvXzPhotoNewsEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvXzPhotoNewsEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvXzPhotoNewsDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzPhotoNewsDA.GetSpecSQLObj();
strSQL = "Select * from vXzPhotoNews where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvXzPhotoNewsEN objvXzPhotoNewsEN = new clsvXzPhotoNewsEN()
{
PhotoNewsId = TransNullToInt(objRow[convXzPhotoNews.PhotoNewsId].ToString().Trim()), //流水号
DepartmentID = objRow[convXzPhotoNews.DepartmentID].ToString().Trim(), //部门ID
Views = objRow[convXzPhotoNews.Views] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convXzPhotoNews.Views].ToString().Trim()), //浏览量
IsTop = TransNullToBool(objRow[convXzPhotoNews.IsTop].ToString().Trim()), //是否置顶
IsUrgent = TransNullToBool(objRow[convXzPhotoNews.IsUrgent].ToString().Trim()), //是否紧急
Audit = objRow[convXzPhotoNews.Audit] == DBNull.Value ? null : objRow[convXzPhotoNews.Audit].ToString().Trim(), //审核
PhotoNewsTitle = objRow[convXzPhotoNews.PhotoNewsTitle].ToString().Trim(), //标题
ImageUrl = objRow[convXzPhotoNews.ImageUrl] == DBNull.Value ? null : objRow[convXzPhotoNews.ImageUrl].ToString().Trim(), //ImageUrl
PhotoNewsContent = objRow[convXzPhotoNews.PhotoNewsContent] == DBNull.Value ? null : objRow[convXzPhotoNews.PhotoNewsContent].ToString().Trim(), //内容
PhotoNewsDate = objRow[convXzPhotoNews.PhotoNewsDate].ToString().Trim(), //日期
PhotoNewsUser = objRow[convXzPhotoNews.PhotoNewsUser].ToString().Trim(), //用户
Memo = objRow[convXzPhotoNews.Memo] == DBNull.Value ? null : objRow[convXzPhotoNews.Memo].ToString().Trim(), //备注
CollegeName = objRow[convXzPhotoNews.CollegeName] == DBNull.Value ? null : objRow[convXzPhotoNews.CollegeName].ToString().Trim(), //学院名称
IdXzCollege = objRow[convXzPhotoNews.IdXzCollege] == DBNull.Value ? null : objRow[convXzPhotoNews.IdXzCollege].ToString().Trim(), //学院流水号
IdXzMajor = objRow[convXzPhotoNews.IdXzMajor].ToString().Trim(), //专业流水号
MajorID = objRow[convXzPhotoNews.MajorID] == DBNull.Value ? null : objRow[convXzPhotoNews.MajorID].ToString().Trim(), //专业ID
MajorName = objRow[convXzPhotoNews.MajorName] == DBNull.Value ? null : objRow[convXzPhotoNews.MajorName].ToString().Trim() //专业名称
};
objvXzPhotoNewsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvXzPhotoNewsEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvXzPhotoNewsDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvXzPhotoNewsEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvXzPhotoNewsEN objvXzPhotoNewsEN = new clsvXzPhotoNewsEN();
try
{
objvXzPhotoNewsEN.PhotoNewsId = TransNullToInt(objRow[convXzPhotoNews.PhotoNewsId].ToString().Trim()); //流水号
objvXzPhotoNewsEN.DepartmentID = objRow[convXzPhotoNews.DepartmentID].ToString().Trim(); //部门ID
objvXzPhotoNewsEN.Views = objRow[convXzPhotoNews.Views] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convXzPhotoNews.Views].ToString().Trim()); //浏览量
objvXzPhotoNewsEN.IsTop = TransNullToBool(objRow[convXzPhotoNews.IsTop].ToString().Trim()); //是否置顶
objvXzPhotoNewsEN.IsUrgent = TransNullToBool(objRow[convXzPhotoNews.IsUrgent].ToString().Trim()); //是否紧急
objvXzPhotoNewsEN.Audit = objRow[convXzPhotoNews.Audit] == DBNull.Value ? null : objRow[convXzPhotoNews.Audit].ToString().Trim(); //审核
objvXzPhotoNewsEN.PhotoNewsTitle = objRow[convXzPhotoNews.PhotoNewsTitle].ToString().Trim(); //标题
objvXzPhotoNewsEN.ImageUrl = objRow[convXzPhotoNews.ImageUrl] == DBNull.Value ? null : objRow[convXzPhotoNews.ImageUrl].ToString().Trim(); //ImageUrl
objvXzPhotoNewsEN.PhotoNewsContent = objRow[convXzPhotoNews.PhotoNewsContent] == DBNull.Value ? null : objRow[convXzPhotoNews.PhotoNewsContent].ToString().Trim(); //内容
objvXzPhotoNewsEN.PhotoNewsDate = objRow[convXzPhotoNews.PhotoNewsDate].ToString().Trim(); //日期
objvXzPhotoNewsEN.PhotoNewsUser = objRow[convXzPhotoNews.PhotoNewsUser].ToString().Trim(); //用户
objvXzPhotoNewsEN.Memo = objRow[convXzPhotoNews.Memo] == DBNull.Value ? null : objRow[convXzPhotoNews.Memo].ToString().Trim(); //备注
objvXzPhotoNewsEN.CollegeName = objRow[convXzPhotoNews.CollegeName] == DBNull.Value ? null : objRow[convXzPhotoNews.CollegeName].ToString().Trim(); //学院名称
objvXzPhotoNewsEN.IdXzCollege = objRow[convXzPhotoNews.IdXzCollege] == DBNull.Value ? null : objRow[convXzPhotoNews.IdXzCollege].ToString().Trim(); //学院流水号
objvXzPhotoNewsEN.IdXzMajor = objRow[convXzPhotoNews.IdXzMajor].ToString().Trim(); //专业流水号
objvXzPhotoNewsEN.MajorID = objRow[convXzPhotoNews.MajorID] == DBNull.Value ? null : objRow[convXzPhotoNews.MajorID].ToString().Trim(); //专业ID
objvXzPhotoNewsEN.MajorName = objRow[convXzPhotoNews.MajorName] == DBNull.Value ? null : objRow[convXzPhotoNews.MajorName].ToString().Trim(); //专业名称
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvXzPhotoNewsDA: GetObjByDataRowvXzPhotoNews)", objException.Message));
}
objvXzPhotoNewsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvXzPhotoNewsEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvXzPhotoNewsEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvXzPhotoNewsEN objvXzPhotoNewsEN = new clsvXzPhotoNewsEN();
try
{
objvXzPhotoNewsEN.PhotoNewsId = TransNullToInt(objRow[convXzPhotoNews.PhotoNewsId].ToString().Trim()); //流水号
objvXzPhotoNewsEN.DepartmentID = objRow[convXzPhotoNews.DepartmentID].ToString().Trim(); //部门ID
objvXzPhotoNewsEN.Views = objRow[convXzPhotoNews.Views] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convXzPhotoNews.Views].ToString().Trim()); //浏览量
objvXzPhotoNewsEN.IsTop = TransNullToBool(objRow[convXzPhotoNews.IsTop].ToString().Trim()); //是否置顶
objvXzPhotoNewsEN.IsUrgent = TransNullToBool(objRow[convXzPhotoNews.IsUrgent].ToString().Trim()); //是否紧急
objvXzPhotoNewsEN.Audit = objRow[convXzPhotoNews.Audit] == DBNull.Value ? null : objRow[convXzPhotoNews.Audit].ToString().Trim(); //审核
objvXzPhotoNewsEN.PhotoNewsTitle = objRow[convXzPhotoNews.PhotoNewsTitle].ToString().Trim(); //标题
objvXzPhotoNewsEN.ImageUrl = objRow[convXzPhotoNews.ImageUrl] == DBNull.Value ? null : objRow[convXzPhotoNews.ImageUrl].ToString().Trim(); //ImageUrl
objvXzPhotoNewsEN.PhotoNewsContent = objRow[convXzPhotoNews.PhotoNewsContent] == DBNull.Value ? null : objRow[convXzPhotoNews.PhotoNewsContent].ToString().Trim(); //内容
objvXzPhotoNewsEN.PhotoNewsDate = objRow[convXzPhotoNews.PhotoNewsDate].ToString().Trim(); //日期
objvXzPhotoNewsEN.PhotoNewsUser = objRow[convXzPhotoNews.PhotoNewsUser].ToString().Trim(); //用户
objvXzPhotoNewsEN.Memo = objRow[convXzPhotoNews.Memo] == DBNull.Value ? null : objRow[convXzPhotoNews.Memo].ToString().Trim(); //备注
objvXzPhotoNewsEN.CollegeName = objRow[convXzPhotoNews.CollegeName] == DBNull.Value ? null : objRow[convXzPhotoNews.CollegeName].ToString().Trim(); //学院名称
objvXzPhotoNewsEN.IdXzCollege = objRow[convXzPhotoNews.IdXzCollege] == DBNull.Value ? null : objRow[convXzPhotoNews.IdXzCollege].ToString().Trim(); //学院流水号
objvXzPhotoNewsEN.IdXzMajor = objRow[convXzPhotoNews.IdXzMajor].ToString().Trim(); //专业流水号
objvXzPhotoNewsEN.MajorID = objRow[convXzPhotoNews.MajorID] == DBNull.Value ? null : objRow[convXzPhotoNews.MajorID].ToString().Trim(); //专业ID
objvXzPhotoNewsEN.MajorName = objRow[convXzPhotoNews.MajorName] == DBNull.Value ? null : objRow[convXzPhotoNews.MajorName].ToString().Trim(); //专业名称
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvXzPhotoNewsDA: GetObjByDataRow)", objException.Message));
}
objvXzPhotoNewsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvXzPhotoNewsEN;
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
objSQL = clsvXzPhotoNewsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvXzPhotoNewsEN._CurrTabName, convXzPhotoNews.PhotoNewsId, 8, "");
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
objSQL = clsvXzPhotoNewsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvXzPhotoNewsEN._CurrTabName, convXzPhotoNews.PhotoNewsId, 8, strPrefix);
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
 objSQL = clsvXzPhotoNewsDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select PhotoNewsId from vXzPhotoNews where " + strCondition;
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
 objSQL = clsvXzPhotoNewsDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select PhotoNewsId from vXzPhotoNews where " + strCondition;
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
 objSQL = clsvXzPhotoNewsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vXzPhotoNews", "PhotoNewsId = " + ""+ lngPhotoNewsId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvXzPhotoNewsDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzPhotoNewsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vXzPhotoNews", strCondition))
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
objSQL = clsvXzPhotoNewsDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vXzPhotoNews");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvXzPhotoNewsENS">源对象</param>
 /// <param name = "objvXzPhotoNewsENT">目标对象</param>
public void CopyTo(clsvXzPhotoNewsEN objvXzPhotoNewsENS, clsvXzPhotoNewsEN objvXzPhotoNewsENT)
{
objvXzPhotoNewsENT.PhotoNewsId = objvXzPhotoNewsENS.PhotoNewsId; //流水号
objvXzPhotoNewsENT.DepartmentID = objvXzPhotoNewsENS.DepartmentID; //部门ID
objvXzPhotoNewsENT.Views = objvXzPhotoNewsENS.Views; //浏览量
objvXzPhotoNewsENT.IsTop = objvXzPhotoNewsENS.IsTop; //是否置顶
objvXzPhotoNewsENT.IsUrgent = objvXzPhotoNewsENS.IsUrgent; //是否紧急
objvXzPhotoNewsENT.Audit = objvXzPhotoNewsENS.Audit; //审核
objvXzPhotoNewsENT.PhotoNewsTitle = objvXzPhotoNewsENS.PhotoNewsTitle; //标题
objvXzPhotoNewsENT.ImageUrl = objvXzPhotoNewsENS.ImageUrl; //ImageUrl
objvXzPhotoNewsENT.PhotoNewsContent = objvXzPhotoNewsENS.PhotoNewsContent; //内容
objvXzPhotoNewsENT.PhotoNewsDate = objvXzPhotoNewsENS.PhotoNewsDate; //日期
objvXzPhotoNewsENT.PhotoNewsUser = objvXzPhotoNewsENS.PhotoNewsUser; //用户
objvXzPhotoNewsENT.Memo = objvXzPhotoNewsENS.Memo; //备注
objvXzPhotoNewsENT.CollegeName = objvXzPhotoNewsENS.CollegeName; //学院名称
objvXzPhotoNewsENT.IdXzCollege = objvXzPhotoNewsENS.IdXzCollege; //学院流水号
objvXzPhotoNewsENT.IdXzMajor = objvXzPhotoNewsENS.IdXzMajor; //专业流水号
objvXzPhotoNewsENT.MajorID = objvXzPhotoNewsENS.MajorID; //专业ID
objvXzPhotoNewsENT.MajorName = objvXzPhotoNewsENS.MajorName; //专业名称
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvXzPhotoNewsEN objvXzPhotoNewsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvXzPhotoNewsEN.DepartmentID, 8, convXzPhotoNews.DepartmentID);
clsCheckSql.CheckFieldLen(objvXzPhotoNewsEN.Audit, 1, convXzPhotoNews.Audit);
clsCheckSql.CheckFieldLen(objvXzPhotoNewsEN.PhotoNewsTitle, 100, convXzPhotoNews.PhotoNewsTitle);
clsCheckSql.CheckFieldLen(objvXzPhotoNewsEN.ImageUrl, 100, convXzPhotoNews.ImageUrl);
clsCheckSql.CheckFieldLen(objvXzPhotoNewsEN.PhotoNewsDate, 16, convXzPhotoNews.PhotoNewsDate);
clsCheckSql.CheckFieldLen(objvXzPhotoNewsEN.PhotoNewsUser, 50, convXzPhotoNews.PhotoNewsUser);
clsCheckSql.CheckFieldLen(objvXzPhotoNewsEN.Memo, 1000, convXzPhotoNews.Memo);
clsCheckSql.CheckFieldLen(objvXzPhotoNewsEN.CollegeName, 100, convXzPhotoNews.CollegeName);
clsCheckSql.CheckFieldLen(objvXzPhotoNewsEN.IdXzCollege, 4, convXzPhotoNews.IdXzCollege);
clsCheckSql.CheckFieldLen(objvXzPhotoNewsEN.IdXzMajor, 8, convXzPhotoNews.IdXzMajor);
clsCheckSql.CheckFieldLen(objvXzPhotoNewsEN.MajorID, 4, convXzPhotoNews.MajorID);
clsCheckSql.CheckFieldLen(objvXzPhotoNewsEN.MajorName, 100, convXzPhotoNews.MajorName);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvXzPhotoNewsEN.DepartmentID, convXzPhotoNews.DepartmentID);
clsCheckSql.CheckSqlInjection4Field(objvXzPhotoNewsEN.Audit, convXzPhotoNews.Audit);
clsCheckSql.CheckSqlInjection4Field(objvXzPhotoNewsEN.PhotoNewsTitle, convXzPhotoNews.PhotoNewsTitle);
clsCheckSql.CheckSqlInjection4Field(objvXzPhotoNewsEN.ImageUrl, convXzPhotoNews.ImageUrl);
clsCheckSql.CheckSqlInjection4Field(objvXzPhotoNewsEN.PhotoNewsDate, convXzPhotoNews.PhotoNewsDate);
clsCheckSql.CheckSqlInjection4Field(objvXzPhotoNewsEN.PhotoNewsUser, convXzPhotoNews.PhotoNewsUser);
clsCheckSql.CheckSqlInjection4Field(objvXzPhotoNewsEN.Memo, convXzPhotoNews.Memo);
clsCheckSql.CheckSqlInjection4Field(objvXzPhotoNewsEN.CollegeName, convXzPhotoNews.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvXzPhotoNewsEN.IdXzCollege, convXzPhotoNews.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvXzPhotoNewsEN.IdXzMajor, convXzPhotoNews.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objvXzPhotoNewsEN.MajorID, convXzPhotoNews.MajorID);
clsCheckSql.CheckSqlInjection4Field(objvXzPhotoNewsEN.MajorName, convXzPhotoNews.MajorName);
//检查外键字段长度
 objvXzPhotoNewsEN._IsCheckProperty = true;
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
 objSQL = clsvXzPhotoNewsDA.GetSpecSQLObj();
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
 objSQL = clsvXzPhotoNewsDA.GetSpecSQLObj();
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
 objSQL = clsvXzPhotoNewsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvXzPhotoNewsEN._CurrTabName);
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
 objSQL = clsvXzPhotoNewsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvXzPhotoNewsEN._CurrTabName, strCondition);
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
 objSQL = clsvXzPhotoNewsDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}