
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPaperCountDA
 表名:vPaperCount(01120595)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:48:13
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
 /// vPaperCount(vPaperCount)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvPaperCountDA : clsCommBase4DA
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
 return clsvPaperCountEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvPaperCountEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvPaperCountEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvPaperCountEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvPaperCountEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:vPaperCount中,检查关键字,长度不正确!(clsvPaperCountDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strPaperId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vPaperCount中,关键字不能为空 或 null!(clsvPaperCountDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strPaperId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvPaperCountDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvPaperCountDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperCountDA.GetSpecSQLObj();
strSQL = "Select * from vPaperCount where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vPaperCount(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvPaperCountDA: GetDataTable_vPaperCount)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperCountDA.GetSpecSQLObj();
strSQL = "Select * from vPaperCount where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvPaperCountDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperCountDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvPaperCountDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperCountDA.GetSpecSQLObj();
strSQL = "Select * from vPaperCount where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvPaperCountDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperCountDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvPaperCountDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperCountDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPaperCount where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPaperCount where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvPaperCountDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperCountDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vPaperCount where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvPaperCountDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperCountDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vPaperCount.* from vPaperCount Left Join {1} on {2} where {3} and vPaperCount.PaperId not in (Select top {5} vPaperCount.PaperId from vPaperCount Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPaperCount where {1} and PaperId not in (Select top {2} PaperId from vPaperCount where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPaperCount where {1} and PaperId not in (Select top {3} PaperId from vPaperCount where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvPaperCountDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperCountDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vPaperCount.* from vPaperCount Left Join {1} on {2} where {3} and vPaperCount.PaperId not in (Select top {5} vPaperCount.PaperId from vPaperCount Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPaperCount where {1} and PaperId not in (Select top {2} PaperId from vPaperCount where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPaperCount where {1} and PaperId not in (Select top {3} PaperId from vPaperCount where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvPaperCountEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvPaperCountDA:GetObjLst)", objException.Message));
}
List<clsvPaperCountEN> arrObjLst = new List<clsvPaperCountEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperCountDA.GetSpecSQLObj();
strSQL = "Select * from vPaperCount where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperCountEN objvPaperCountEN = new clsvPaperCountEN();
try
{
objvPaperCountEN.PaperId = objRow[convPaperCount.PaperId].ToString().Trim(); //论文Id
objvPaperCountEN.AppraiseCount = objRow[convPaperCount.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount.AppraiseCount].ToString().Trim()); //评论数
objvPaperCountEN.AttachmentCount = objRow[convPaperCount.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount.AttachmentCount].ToString().Trim()); //附件计数
objvPaperCountEN.CollectionCount = objRow[convPaperCount.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convPaperCount.CollectionCount].ToString().Trim()); //收藏数量
objvPaperCountEN.DownloadCount = objRow[convPaperCount.DownloadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount.DownloadCount].ToString().Trim()); //下载数
objvPaperCountEN.OkCount = objRow[convPaperCount.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount.OkCount].ToString().Trim()); //点赞统计
objvPaperCountEN.Pcount = objRow[convPaperCount.Pcount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount.Pcount].ToString().Trim()); //读写数
objvPaperCountEN.Score = objRow[convPaperCount.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPaperCount.Score].ToString().Trim()); //评分
objvPaperCountEN.StuScore = objRow[convPaperCount.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPaperCount.StuScore].ToString().Trim()); //学生平均分
objvPaperCountEN.TeaScore = objRow[convPaperCount.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPaperCount.TeaScore].ToString().Trim()); //教师评分
objvPaperCountEN.BrowseNumber = objRow[convPaperCount.BrowseNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount.BrowseNumber].ToString().Trim()); //浏览量
objvPaperCountEN.UpdDate = objRow[convPaperCount.UpdDate] == DBNull.Value ? null : objRow[convPaperCount.UpdDate].ToString().Trim(); //修改日期
objvPaperCountEN.PaperTitle = objRow[convPaperCount.PaperTitle].ToString().Trim(); //论文标题
objvPaperCountEN.UpdUser = objRow[convPaperCount.UpdUser] == DBNull.Value ? null : objRow[convPaperCount.UpdUser].ToString().Trim(); //修改人
objvPaperCountEN.PaperQCount = objRow[convPaperCount.PaperQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount.PaperQCount].ToString().Trim()); //论文答疑数
objvPaperCountEN.SubVCount = objRow[convPaperCount.SubVCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount.SubVCount].ToString().Trim()); //论文子观点数
objvPaperCountEN.TagsCount = objRow[convPaperCount.TagsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount.TagsCount].ToString().Trim()); //论文标注数
objvPaperCountEN.TeaQCount = objRow[convPaperCount.TeaQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount.TeaQCount].ToString().Trim()); //教师提问数
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvPaperCountDA: GetObjLst)", objException.Message));
}
objvPaperCountEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvPaperCountEN);
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
public List<clsvPaperCountEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvPaperCountDA:GetObjLstByTabName)", objException.Message));
}
List<clsvPaperCountEN> arrObjLst = new List<clsvPaperCountEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperCountDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperCountEN objvPaperCountEN = new clsvPaperCountEN();
try
{
objvPaperCountEN.PaperId = objRow[convPaperCount.PaperId].ToString().Trim(); //论文Id
objvPaperCountEN.AppraiseCount = objRow[convPaperCount.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount.AppraiseCount].ToString().Trim()); //评论数
objvPaperCountEN.AttachmentCount = objRow[convPaperCount.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount.AttachmentCount].ToString().Trim()); //附件计数
objvPaperCountEN.CollectionCount = objRow[convPaperCount.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convPaperCount.CollectionCount].ToString().Trim()); //收藏数量
objvPaperCountEN.DownloadCount = objRow[convPaperCount.DownloadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount.DownloadCount].ToString().Trim()); //下载数
objvPaperCountEN.OkCount = objRow[convPaperCount.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount.OkCount].ToString().Trim()); //点赞统计
objvPaperCountEN.Pcount = objRow[convPaperCount.Pcount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount.Pcount].ToString().Trim()); //读写数
objvPaperCountEN.Score = objRow[convPaperCount.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPaperCount.Score].ToString().Trim()); //评分
objvPaperCountEN.StuScore = objRow[convPaperCount.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPaperCount.StuScore].ToString().Trim()); //学生平均分
objvPaperCountEN.TeaScore = objRow[convPaperCount.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPaperCount.TeaScore].ToString().Trim()); //教师评分
objvPaperCountEN.BrowseNumber = objRow[convPaperCount.BrowseNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount.BrowseNumber].ToString().Trim()); //浏览量
objvPaperCountEN.UpdDate = objRow[convPaperCount.UpdDate] == DBNull.Value ? null : objRow[convPaperCount.UpdDate].ToString().Trim(); //修改日期
objvPaperCountEN.PaperTitle = objRow[convPaperCount.PaperTitle].ToString().Trim(); //论文标题
objvPaperCountEN.UpdUser = objRow[convPaperCount.UpdUser] == DBNull.Value ? null : objRow[convPaperCount.UpdUser].ToString().Trim(); //修改人
objvPaperCountEN.PaperQCount = objRow[convPaperCount.PaperQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount.PaperQCount].ToString().Trim()); //论文答疑数
objvPaperCountEN.SubVCount = objRow[convPaperCount.SubVCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount.SubVCount].ToString().Trim()); //论文子观点数
objvPaperCountEN.TagsCount = objRow[convPaperCount.TagsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount.TagsCount].ToString().Trim()); //论文标注数
objvPaperCountEN.TeaQCount = objRow[convPaperCount.TeaQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount.TeaQCount].ToString().Trim()); //教师提问数
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvPaperCountDA: GetObjLst)", objException.Message));
}
objvPaperCountEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvPaperCountEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvPaperCountEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvPaperCount(ref clsvPaperCountEN objvPaperCountEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperCountDA.GetSpecSQLObj();
strSQL = "Select * from vPaperCount where PaperId = " + "'"+ objvPaperCountEN.PaperId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvPaperCountEN.PaperId = objDT.Rows[0][convPaperCount.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objvPaperCountEN.AppraiseCount = TransNullToInt(objDT.Rows[0][convPaperCount.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objvPaperCountEN.AttachmentCount = TransNullToInt(objDT.Rows[0][convPaperCount.AttachmentCount].ToString().Trim()); //附件计数(字段类型:int,字段长度:4,是否可空:True)
 objvPaperCountEN.CollectionCount = TransNullToInt(objDT.Rows[0][convPaperCount.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvPaperCountEN.DownloadCount = TransNullToInt(objDT.Rows[0][convPaperCount.DownloadCount].ToString().Trim()); //下载数(字段类型:int,字段长度:4,是否可空:True)
 objvPaperCountEN.OkCount = TransNullToInt(objDT.Rows[0][convPaperCount.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objvPaperCountEN.Pcount = TransNullToInt(objDT.Rows[0][convPaperCount.Pcount].ToString().Trim()); //读写数(字段类型:int,字段长度:4,是否可空:True)
 objvPaperCountEN.Score = TransNullToFloat(objDT.Rows[0][convPaperCount.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvPaperCountEN.StuScore = TransNullToFloat(objDT.Rows[0][convPaperCount.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objvPaperCountEN.TeaScore = TransNullToFloat(objDT.Rows[0][convPaperCount.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objvPaperCountEN.BrowseNumber = TransNullToInt(objDT.Rows[0][convPaperCount.BrowseNumber].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvPaperCountEN.UpdDate = objDT.Rows[0][convPaperCount.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvPaperCountEN.PaperTitle = objDT.Rows[0][convPaperCount.PaperTitle].ToString().Trim(); //论文标题(字段类型:varchar,字段长度:500,是否可空:False)
 objvPaperCountEN.UpdUser = objDT.Rows[0][convPaperCount.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvPaperCountEN.PaperQCount = TransNullToInt(objDT.Rows[0][convPaperCount.PaperQCount].ToString().Trim()); //论文答疑数(字段类型:int,字段长度:4,是否可空:True)
 objvPaperCountEN.SubVCount = TransNullToInt(objDT.Rows[0][convPaperCount.SubVCount].ToString().Trim()); //论文子观点数(字段类型:int,字段长度:4,是否可空:True)
 objvPaperCountEN.TagsCount = TransNullToInt(objDT.Rows[0][convPaperCount.TagsCount].ToString().Trim()); //论文标注数(字段类型:int,字段长度:4,是否可空:True)
 objvPaperCountEN.TeaQCount = TransNullToInt(objDT.Rows[0][convPaperCount.TeaQCount].ToString().Trim()); //教师提问数(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvPaperCountDA: GetvPaperCount)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strPaperId">表关键字</param>
 /// <returns>表对象</returns>
public clsvPaperCountEN GetObjByPaperId(string strPaperId)
{
CheckPrimaryKey(strPaperId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperCountDA.GetSpecSQLObj();
strSQL = "Select * from vPaperCount where PaperId = " + "'"+ strPaperId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvPaperCountEN objvPaperCountEN = new clsvPaperCountEN();
try
{
 objvPaperCountEN.PaperId = objRow[convPaperCount.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objvPaperCountEN.AppraiseCount = objRow[convPaperCount.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objvPaperCountEN.AttachmentCount = objRow[convPaperCount.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.AttachmentCount].ToString().Trim()); //附件计数(字段类型:int,字段长度:4,是否可空:True)
 objvPaperCountEN.CollectionCount = objRow[convPaperCount.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvPaperCountEN.DownloadCount = objRow[convPaperCount.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.DownloadCount].ToString().Trim()); //下载数(字段类型:int,字段长度:4,是否可空:True)
 objvPaperCountEN.OkCount = objRow[convPaperCount.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objvPaperCountEN.Pcount = objRow[convPaperCount.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.Pcount].ToString().Trim()); //读写数(字段类型:int,字段长度:4,是否可空:True)
 objvPaperCountEN.Score = objRow[convPaperCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperCount.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvPaperCountEN.StuScore = objRow[convPaperCount.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperCount.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objvPaperCountEN.TeaScore = objRow[convPaperCount.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperCount.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objvPaperCountEN.BrowseNumber = objRow[convPaperCount.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.BrowseNumber].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvPaperCountEN.UpdDate = objRow[convPaperCount.UpdDate] == DBNull.Value ? null : objRow[convPaperCount.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvPaperCountEN.PaperTitle = objRow[convPaperCount.PaperTitle].ToString().Trim(); //论文标题(字段类型:varchar,字段长度:500,是否可空:False)
 objvPaperCountEN.UpdUser = objRow[convPaperCount.UpdUser] == DBNull.Value ? null : objRow[convPaperCount.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvPaperCountEN.PaperQCount = objRow[convPaperCount.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.PaperQCount].ToString().Trim()); //论文答疑数(字段类型:int,字段长度:4,是否可空:True)
 objvPaperCountEN.SubVCount = objRow[convPaperCount.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.SubVCount].ToString().Trim()); //论文子观点数(字段类型:int,字段长度:4,是否可空:True)
 objvPaperCountEN.TagsCount = objRow[convPaperCount.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.TagsCount].ToString().Trim()); //论文标注数(字段类型:int,字段长度:4,是否可空:True)
 objvPaperCountEN.TeaQCount = objRow[convPaperCount.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.TeaQCount].ToString().Trim()); //教师提问数(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvPaperCountDA: GetObjByPaperId)", objException.Message));
}
return objvPaperCountEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvPaperCountEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvPaperCountDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperCountDA.GetSpecSQLObj();
strSQL = "Select * from vPaperCount where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvPaperCountEN objvPaperCountEN = new clsvPaperCountEN()
{
PaperId = objRow[convPaperCount.PaperId].ToString().Trim(), //论文Id
AppraiseCount = objRow[convPaperCount.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount.AppraiseCount].ToString().Trim()), //评论数
AttachmentCount = objRow[convPaperCount.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount.AttachmentCount].ToString().Trim()), //附件计数
CollectionCount = objRow[convPaperCount.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convPaperCount.CollectionCount].ToString().Trim()), //收藏数量
DownloadCount = objRow[convPaperCount.DownloadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount.DownloadCount].ToString().Trim()), //下载数
OkCount = objRow[convPaperCount.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount.OkCount].ToString().Trim()), //点赞统计
Pcount = objRow[convPaperCount.Pcount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount.Pcount].ToString().Trim()), //读写数
Score = objRow[convPaperCount.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPaperCount.Score].ToString().Trim()), //评分
StuScore = objRow[convPaperCount.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPaperCount.StuScore].ToString().Trim()), //学生平均分
TeaScore = objRow[convPaperCount.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPaperCount.TeaScore].ToString().Trim()), //教师评分
BrowseNumber = objRow[convPaperCount.BrowseNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount.BrowseNumber].ToString().Trim()), //浏览量
UpdDate = objRow[convPaperCount.UpdDate] == DBNull.Value ? null : objRow[convPaperCount.UpdDate].ToString().Trim(), //修改日期
PaperTitle = objRow[convPaperCount.PaperTitle].ToString().Trim(), //论文标题
UpdUser = objRow[convPaperCount.UpdUser] == DBNull.Value ? null : objRow[convPaperCount.UpdUser].ToString().Trim(), //修改人
PaperQCount = objRow[convPaperCount.PaperQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount.PaperQCount].ToString().Trim()), //论文答疑数
SubVCount = objRow[convPaperCount.SubVCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount.SubVCount].ToString().Trim()), //论文子观点数
TagsCount = objRow[convPaperCount.TagsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount.TagsCount].ToString().Trim()), //论文标注数
TeaQCount = objRow[convPaperCount.TeaQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount.TeaQCount].ToString().Trim()) //教师提问数
};
objvPaperCountEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPaperCountEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvPaperCountDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvPaperCountEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvPaperCountEN objvPaperCountEN = new clsvPaperCountEN();
try
{
objvPaperCountEN.PaperId = objRow[convPaperCount.PaperId].ToString().Trim(); //论文Id
objvPaperCountEN.AppraiseCount = objRow[convPaperCount.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount.AppraiseCount].ToString().Trim()); //评论数
objvPaperCountEN.AttachmentCount = objRow[convPaperCount.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount.AttachmentCount].ToString().Trim()); //附件计数
objvPaperCountEN.CollectionCount = objRow[convPaperCount.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convPaperCount.CollectionCount].ToString().Trim()); //收藏数量
objvPaperCountEN.DownloadCount = objRow[convPaperCount.DownloadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount.DownloadCount].ToString().Trim()); //下载数
objvPaperCountEN.OkCount = objRow[convPaperCount.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount.OkCount].ToString().Trim()); //点赞统计
objvPaperCountEN.Pcount = objRow[convPaperCount.Pcount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount.Pcount].ToString().Trim()); //读写数
objvPaperCountEN.Score = objRow[convPaperCount.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPaperCount.Score].ToString().Trim()); //评分
objvPaperCountEN.StuScore = objRow[convPaperCount.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPaperCount.StuScore].ToString().Trim()); //学生平均分
objvPaperCountEN.TeaScore = objRow[convPaperCount.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPaperCount.TeaScore].ToString().Trim()); //教师评分
objvPaperCountEN.BrowseNumber = objRow[convPaperCount.BrowseNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount.BrowseNumber].ToString().Trim()); //浏览量
objvPaperCountEN.UpdDate = objRow[convPaperCount.UpdDate] == DBNull.Value ? null : objRow[convPaperCount.UpdDate].ToString().Trim(); //修改日期
objvPaperCountEN.PaperTitle = objRow[convPaperCount.PaperTitle].ToString().Trim(); //论文标题
objvPaperCountEN.UpdUser = objRow[convPaperCount.UpdUser] == DBNull.Value ? null : objRow[convPaperCount.UpdUser].ToString().Trim(); //修改人
objvPaperCountEN.PaperQCount = objRow[convPaperCount.PaperQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount.PaperQCount].ToString().Trim()); //论文答疑数
objvPaperCountEN.SubVCount = objRow[convPaperCount.SubVCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount.SubVCount].ToString().Trim()); //论文子观点数
objvPaperCountEN.TagsCount = objRow[convPaperCount.TagsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount.TagsCount].ToString().Trim()); //论文标注数
objvPaperCountEN.TeaQCount = objRow[convPaperCount.TeaQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount.TeaQCount].ToString().Trim()); //教师提问数
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvPaperCountDA: GetObjByDataRowvPaperCount)", objException.Message));
}
objvPaperCountEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPaperCountEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvPaperCountEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvPaperCountEN objvPaperCountEN = new clsvPaperCountEN();
try
{
objvPaperCountEN.PaperId = objRow[convPaperCount.PaperId].ToString().Trim(); //论文Id
objvPaperCountEN.AppraiseCount = objRow[convPaperCount.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount.AppraiseCount].ToString().Trim()); //评论数
objvPaperCountEN.AttachmentCount = objRow[convPaperCount.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount.AttachmentCount].ToString().Trim()); //附件计数
objvPaperCountEN.CollectionCount = objRow[convPaperCount.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convPaperCount.CollectionCount].ToString().Trim()); //收藏数量
objvPaperCountEN.DownloadCount = objRow[convPaperCount.DownloadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount.DownloadCount].ToString().Trim()); //下载数
objvPaperCountEN.OkCount = objRow[convPaperCount.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount.OkCount].ToString().Trim()); //点赞统计
objvPaperCountEN.Pcount = objRow[convPaperCount.Pcount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount.Pcount].ToString().Trim()); //读写数
objvPaperCountEN.Score = objRow[convPaperCount.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPaperCount.Score].ToString().Trim()); //评分
objvPaperCountEN.StuScore = objRow[convPaperCount.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPaperCount.StuScore].ToString().Trim()); //学生平均分
objvPaperCountEN.TeaScore = objRow[convPaperCount.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPaperCount.TeaScore].ToString().Trim()); //教师评分
objvPaperCountEN.BrowseNumber = objRow[convPaperCount.BrowseNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount.BrowseNumber].ToString().Trim()); //浏览量
objvPaperCountEN.UpdDate = objRow[convPaperCount.UpdDate] == DBNull.Value ? null : objRow[convPaperCount.UpdDate].ToString().Trim(); //修改日期
objvPaperCountEN.PaperTitle = objRow[convPaperCount.PaperTitle].ToString().Trim(); //论文标题
objvPaperCountEN.UpdUser = objRow[convPaperCount.UpdUser] == DBNull.Value ? null : objRow[convPaperCount.UpdUser].ToString().Trim(); //修改人
objvPaperCountEN.PaperQCount = objRow[convPaperCount.PaperQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount.PaperQCount].ToString().Trim()); //论文答疑数
objvPaperCountEN.SubVCount = objRow[convPaperCount.SubVCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount.SubVCount].ToString().Trim()); //论文子观点数
objvPaperCountEN.TagsCount = objRow[convPaperCount.TagsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount.TagsCount].ToString().Trim()); //论文标注数
objvPaperCountEN.TeaQCount = objRow[convPaperCount.TeaQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount.TeaQCount].ToString().Trim()); //教师提问数
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvPaperCountDA: GetObjByDataRow)", objException.Message));
}
objvPaperCountEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPaperCountEN;
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
objSQL = clsvPaperCountDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvPaperCountEN._CurrTabName, convPaperCount.PaperId, 8, "");
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
objSQL = clsvPaperCountDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvPaperCountEN._CurrTabName, convPaperCount.PaperId, 8, strPrefix);
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
 objSQL = clsvPaperCountDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select PaperId from vPaperCount where " + strCondition;
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
 objSQL = clsvPaperCountDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select PaperId from vPaperCount where " + strCondition;
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
 objSQL = clsvPaperCountDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vPaperCount", "PaperId = " + "'"+ strPaperId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvPaperCountDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperCountDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vPaperCount", strCondition))
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
objSQL = clsvPaperCountDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vPaperCount");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvPaperCountENS">源对象</param>
 /// <param name = "objvPaperCountENT">目标对象</param>
public void CopyTo(clsvPaperCountEN objvPaperCountENS, clsvPaperCountEN objvPaperCountENT)
{
objvPaperCountENT.PaperId = objvPaperCountENS.PaperId; //论文Id
objvPaperCountENT.AppraiseCount = objvPaperCountENS.AppraiseCount; //评论数
objvPaperCountENT.AttachmentCount = objvPaperCountENS.AttachmentCount; //附件计数
objvPaperCountENT.CollectionCount = objvPaperCountENS.CollectionCount; //收藏数量
objvPaperCountENT.DownloadCount = objvPaperCountENS.DownloadCount; //下载数
objvPaperCountENT.OkCount = objvPaperCountENS.OkCount; //点赞统计
objvPaperCountENT.Pcount = objvPaperCountENS.Pcount; //读写数
objvPaperCountENT.Score = objvPaperCountENS.Score; //评分
objvPaperCountENT.StuScore = objvPaperCountENS.StuScore; //学生平均分
objvPaperCountENT.TeaScore = objvPaperCountENS.TeaScore; //教师评分
objvPaperCountENT.BrowseNumber = objvPaperCountENS.BrowseNumber; //浏览量
objvPaperCountENT.UpdDate = objvPaperCountENS.UpdDate; //修改日期
objvPaperCountENT.PaperTitle = objvPaperCountENS.PaperTitle; //论文标题
objvPaperCountENT.UpdUser = objvPaperCountENS.UpdUser; //修改人
objvPaperCountENT.PaperQCount = objvPaperCountENS.PaperQCount; //论文答疑数
objvPaperCountENT.SubVCount = objvPaperCountENS.SubVCount; //论文子观点数
objvPaperCountENT.TagsCount = objvPaperCountENS.TagsCount; //论文标注数
objvPaperCountENT.TeaQCount = objvPaperCountENS.TeaQCount; //教师提问数
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvPaperCountEN objvPaperCountEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvPaperCountEN.PaperId, 8, convPaperCount.PaperId);
clsCheckSql.CheckFieldLen(objvPaperCountEN.UpdDate, 20, convPaperCount.UpdDate);
clsCheckSql.CheckFieldLen(objvPaperCountEN.PaperTitle, 500, convPaperCount.PaperTitle);
clsCheckSql.CheckFieldLen(objvPaperCountEN.UpdUser, 20, convPaperCount.UpdUser);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvPaperCountEN.PaperId, convPaperCount.PaperId);
clsCheckSql.CheckSqlInjection4Field(objvPaperCountEN.UpdDate, convPaperCount.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvPaperCountEN.PaperTitle, convPaperCount.PaperTitle);
clsCheckSql.CheckSqlInjection4Field(objvPaperCountEN.UpdUser, convPaperCount.UpdUser);
//检查外键字段长度
 objvPaperCountEN._IsCheckProperty = true;
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
 objSQL = clsvPaperCountDA.GetSpecSQLObj();
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
 objSQL = clsvPaperCountDA.GetSpecSQLObj();
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
 objSQL = clsvPaperCountDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvPaperCountEN._CurrTabName);
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
 objSQL = clsvPaperCountDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvPaperCountEN._CurrTabName, strCondition);
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
 objSQL = clsvPaperCountDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}