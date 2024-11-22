
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_SysCountDA
 表名:vzx_SysCount(01120837)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:51:37
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培设置(GradEduTools)
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
 /// vzx_SysCount(vzx_SysCount)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvzx_SysCountDA : clsCommBase4DA
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
 return clsvzx_SysCountEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvzx_SysCountEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvzx_SysCountEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvzx_SysCountEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvzx_SysCountEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strzxCountId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strzxCountId)
{
strzxCountId = strzxCountId.Replace("'", "''");
if (strzxCountId.Length > 10)
{
throw new Exception("(errid:Data000001)在表:vzx_SysCount中,检查关键字,长度不正确!(clsvzx_SysCountDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strzxCountId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vzx_SysCount中,关键字不能为空 或 null!(clsvzx_SysCountDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strzxCountId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvzx_SysCountDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvzx_SysCountDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SysCountDA.GetSpecSQLObj();
strSQL = "Select * from vzx_SysCount where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vzx_SysCount(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvzx_SysCountDA: GetDataTable_vzx_SysCount)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SysCountDA.GetSpecSQLObj();
strSQL = "Select * from vzx_SysCount where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvzx_SysCountDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SysCountDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvzx_SysCountDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SysCountDA.GetSpecSQLObj();
strSQL = "Select * from vzx_SysCount where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvzx_SysCountDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SysCountDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvzx_SysCountDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SysCountDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vzx_SysCount where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vzx_SysCount where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvzx_SysCountDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SysCountDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vzx_SysCount where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvzx_SysCountDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SysCountDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vzx_SysCount.* from vzx_SysCount Left Join {1} on {2} where {3} and vzx_SysCount.zxCountId not in (Select top {5} vzx_SysCount.zxCountId from vzx_SysCount Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vzx_SysCount where {1} and zxCountId not in (Select top {2} zxCountId from vzx_SysCount where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vzx_SysCount where {1} and zxCountId not in (Select top {3} zxCountId from vzx_SysCount where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvzx_SysCountDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SysCountDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vzx_SysCount.* from vzx_SysCount Left Join {1} on {2} where {3} and vzx_SysCount.zxCountId not in (Select top {5} vzx_SysCount.zxCountId from vzx_SysCount Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vzx_SysCount where {1} and zxCountId not in (Select top {2} zxCountId from vzx_SysCount where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vzx_SysCount where {1} and zxCountId not in (Select top {3} zxCountId from vzx_SysCount where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvzx_SysCountEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvzx_SysCountDA:GetObjLst)", objException.Message));
}
List<clsvzx_SysCountEN> arrObjLst = new List<clsvzx_SysCountEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SysCountDA.GetSpecSQLObj();
strSQL = "Select * from vzx_SysCount where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_SysCountEN objvzx_SysCountEN = new clsvzx_SysCountEN();
try
{
objvzx_SysCountEN.CommentTypeName = objRow[convzx_SysCount.CommentTypeName] == DBNull.Value ? null : objRow[convzx_SysCount.CommentTypeName].ToString().Trim(); //评论类型名
objvzx_SysCountEN.CommentTable = objRow[convzx_SysCount.CommentTable] == DBNull.Value ? null : objRow[convzx_SysCount.CommentTable].ToString().Trim(); //评论表
objvzx_SysCountEN.zxCountId = objRow[convzx_SysCount.zxCountId].ToString().Trim(); //CountId
objvzx_SysCountEN.CommentTableId = objRow[convzx_SysCount.CommentTableId] == DBNull.Value ? null : objRow[convzx_SysCount.CommentTableId].ToString().Trim(); //评论表Id
objvzx_SysCountEN.CountTypeId = objRow[convzx_SysCount.CountTypeId] == DBNull.Value ? null : objRow[convzx_SysCount.CountTypeId].ToString().Trim(); //CountTypeId
objvzx_SysCountEN.PaperRWCount = objRow[convzx_SysCount.PaperRWCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_SysCount.PaperRWCount].ToString().Trim()); //PaperRWCount
objvzx_SysCountEN.OkCount = objRow[convzx_SysCount.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_SysCount.OkCount].ToString().Trim()); //点赞统计
objvzx_SysCountEN.CollectionCount = objRow[convzx_SysCount.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convzx_SysCount.CollectionCount].ToString().Trim()); //收藏数量
objvzx_SysCountEN.DownloadCount = objRow[convzx_SysCount.DownloadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_SysCount.DownloadCount].ToString().Trim()); //下载数
objvzx_SysCountEN.AttachmentCount = objRow[convzx_SysCount.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_SysCount.AttachmentCount].ToString().Trim()); //附件计数
objvzx_SysCountEN.CommentCount = objRow[convzx_SysCount.CommentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_SysCount.CommentCount].ToString().Trim()); //评论数
objvzx_SysCountEN.Score = objRow[convzx_SysCount.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_SysCount.Score].ToString().Trim()); //评分
objvzx_SysCountEN.StuScore = objRow[convzx_SysCount.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_SysCount.StuScore].ToString().Trim()); //学生平均分
objvzx_SysCountEN.TeaScore = objRow[convzx_SysCount.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_SysCount.TeaScore].ToString().Trim()); //教师评分
objvzx_SysCountEN.TableKey = objRow[convzx_SysCount.TableKey] == DBNull.Value ? null : objRow[convzx_SysCount.TableKey].ToString().Trim(); //表主键
objvzx_SysCountEN.ParentId = objRow[convzx_SysCount.ParentId] == DBNull.Value ? null : objRow[convzx_SysCount.ParentId].ToString().Trim(); //父Id
objvzx_SysCountEN.UpdUser = objRow[convzx_SysCount.UpdUser] == DBNull.Value ? null : objRow[convzx_SysCount.UpdUser].ToString().Trim(); //修改人
objvzx_SysCountEN.UpdDate = objRow[convzx_SysCount.UpdDate] == DBNull.Value ? null : objRow[convzx_SysCount.UpdDate].ToString().Trim(); //修改日期
objvzx_SysCountEN.Memo = objRow[convzx_SysCount.Memo] == DBNull.Value ? null : objRow[convzx_SysCount.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvzx_SysCountDA: GetObjLst)", objException.Message));
}
objvzx_SysCountEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvzx_SysCountEN);
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
public List<clsvzx_SysCountEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvzx_SysCountDA:GetObjLstByTabName)", objException.Message));
}
List<clsvzx_SysCountEN> arrObjLst = new List<clsvzx_SysCountEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SysCountDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_SysCountEN objvzx_SysCountEN = new clsvzx_SysCountEN();
try
{
objvzx_SysCountEN.CommentTypeName = objRow[convzx_SysCount.CommentTypeName] == DBNull.Value ? null : objRow[convzx_SysCount.CommentTypeName].ToString().Trim(); //评论类型名
objvzx_SysCountEN.CommentTable = objRow[convzx_SysCount.CommentTable] == DBNull.Value ? null : objRow[convzx_SysCount.CommentTable].ToString().Trim(); //评论表
objvzx_SysCountEN.zxCountId = objRow[convzx_SysCount.zxCountId].ToString().Trim(); //CountId
objvzx_SysCountEN.CommentTableId = objRow[convzx_SysCount.CommentTableId] == DBNull.Value ? null : objRow[convzx_SysCount.CommentTableId].ToString().Trim(); //评论表Id
objvzx_SysCountEN.CountTypeId = objRow[convzx_SysCount.CountTypeId] == DBNull.Value ? null : objRow[convzx_SysCount.CountTypeId].ToString().Trim(); //CountTypeId
objvzx_SysCountEN.PaperRWCount = objRow[convzx_SysCount.PaperRWCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_SysCount.PaperRWCount].ToString().Trim()); //PaperRWCount
objvzx_SysCountEN.OkCount = objRow[convzx_SysCount.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_SysCount.OkCount].ToString().Trim()); //点赞统计
objvzx_SysCountEN.CollectionCount = objRow[convzx_SysCount.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convzx_SysCount.CollectionCount].ToString().Trim()); //收藏数量
objvzx_SysCountEN.DownloadCount = objRow[convzx_SysCount.DownloadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_SysCount.DownloadCount].ToString().Trim()); //下载数
objvzx_SysCountEN.AttachmentCount = objRow[convzx_SysCount.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_SysCount.AttachmentCount].ToString().Trim()); //附件计数
objvzx_SysCountEN.CommentCount = objRow[convzx_SysCount.CommentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_SysCount.CommentCount].ToString().Trim()); //评论数
objvzx_SysCountEN.Score = objRow[convzx_SysCount.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_SysCount.Score].ToString().Trim()); //评分
objvzx_SysCountEN.StuScore = objRow[convzx_SysCount.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_SysCount.StuScore].ToString().Trim()); //学生平均分
objvzx_SysCountEN.TeaScore = objRow[convzx_SysCount.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_SysCount.TeaScore].ToString().Trim()); //教师评分
objvzx_SysCountEN.TableKey = objRow[convzx_SysCount.TableKey] == DBNull.Value ? null : objRow[convzx_SysCount.TableKey].ToString().Trim(); //表主键
objvzx_SysCountEN.ParentId = objRow[convzx_SysCount.ParentId] == DBNull.Value ? null : objRow[convzx_SysCount.ParentId].ToString().Trim(); //父Id
objvzx_SysCountEN.UpdUser = objRow[convzx_SysCount.UpdUser] == DBNull.Value ? null : objRow[convzx_SysCount.UpdUser].ToString().Trim(); //修改人
objvzx_SysCountEN.UpdDate = objRow[convzx_SysCount.UpdDate] == DBNull.Value ? null : objRow[convzx_SysCount.UpdDate].ToString().Trim(); //修改日期
objvzx_SysCountEN.Memo = objRow[convzx_SysCount.Memo] == DBNull.Value ? null : objRow[convzx_SysCount.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvzx_SysCountDA: GetObjLst)", objException.Message));
}
objvzx_SysCountEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvzx_SysCountEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvzx_SysCountEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getvzx_SysCount(ref clsvzx_SysCountEN objvzx_SysCountEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SysCountDA.GetSpecSQLObj();
strSQL = "Select * from vzx_SysCount where zxCountId = " + "'"+ objvzx_SysCountEN.zxCountId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvzx_SysCountEN.CommentTypeName = objDT.Rows[0][convzx_SysCount.CommentTypeName].ToString().Trim(); //评论类型名(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_SysCountEN.CommentTable = objDT.Rows[0][convzx_SysCount.CommentTable].ToString().Trim(); //评论表(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_SysCountEN.zxCountId = objDT.Rows[0][convzx_SysCount.zxCountId].ToString().Trim(); //CountId(字段类型:char,字段长度:10,是否可空:False)
 objvzx_SysCountEN.CommentTableId = objDT.Rows[0][convzx_SysCount.CommentTableId].ToString().Trim(); //评论表Id(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_SysCountEN.CountTypeId = objDT.Rows[0][convzx_SysCount.CountTypeId].ToString().Trim(); //CountTypeId(字段类型:char,字段长度:2,是否可空:True)
 objvzx_SysCountEN.PaperRWCount = TransNullToInt(objDT.Rows[0][convzx_SysCount.PaperRWCount].ToString().Trim()); //PaperRWCount(字段类型:int,字段长度:4,是否可空:True)
 objvzx_SysCountEN.OkCount = TransNullToInt(objDT.Rows[0][convzx_SysCount.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objvzx_SysCountEN.CollectionCount = TransNullToInt(objDT.Rows[0][convzx_SysCount.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvzx_SysCountEN.DownloadCount = TransNullToInt(objDT.Rows[0][convzx_SysCount.DownloadCount].ToString().Trim()); //下载数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_SysCountEN.AttachmentCount = TransNullToInt(objDT.Rows[0][convzx_SysCount.AttachmentCount].ToString().Trim()); //附件计数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_SysCountEN.CommentCount = TransNullToInt(objDT.Rows[0][convzx_SysCount.CommentCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_SysCountEN.Score = TransNullToFloat(objDT.Rows[0][convzx_SysCount.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvzx_SysCountEN.StuScore = TransNullToFloat(objDT.Rows[0][convzx_SysCount.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objvzx_SysCountEN.TeaScore = TransNullToFloat(objDT.Rows[0][convzx_SysCount.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objvzx_SysCountEN.TableKey = objDT.Rows[0][convzx_SysCount.TableKey].ToString().Trim(); //表主键(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_SysCountEN.ParentId = objDT.Rows[0][convzx_SysCount.ParentId].ToString().Trim(); //父Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvzx_SysCountEN.UpdUser = objDT.Rows[0][convzx_SysCount.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_SysCountEN.UpdDate = objDT.Rows[0][convzx_SysCount.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_SysCountEN.Memo = objDT.Rows[0][convzx_SysCount.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvzx_SysCountDA: Getvzx_SysCount)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strzxCountId">表关键字</param>
 /// <returns>表对象</returns>
public clsvzx_SysCountEN GetObjByzxCountId(string strzxCountId)
{
CheckPrimaryKey(strzxCountId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SysCountDA.GetSpecSQLObj();
strSQL = "Select * from vzx_SysCount where zxCountId = " + "'"+ strzxCountId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvzx_SysCountEN objvzx_SysCountEN = new clsvzx_SysCountEN();
try
{
 objvzx_SysCountEN.CommentTypeName = objRow[convzx_SysCount.CommentTypeName] == DBNull.Value ? null : objRow[convzx_SysCount.CommentTypeName].ToString().Trim(); //评论类型名(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_SysCountEN.CommentTable = objRow[convzx_SysCount.CommentTable] == DBNull.Value ? null : objRow[convzx_SysCount.CommentTable].ToString().Trim(); //评论表(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_SysCountEN.zxCountId = objRow[convzx_SysCount.zxCountId].ToString().Trim(); //CountId(字段类型:char,字段长度:10,是否可空:False)
 objvzx_SysCountEN.CommentTableId = objRow[convzx_SysCount.CommentTableId] == DBNull.Value ? null : objRow[convzx_SysCount.CommentTableId].ToString().Trim(); //评论表Id(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_SysCountEN.CountTypeId = objRow[convzx_SysCount.CountTypeId] == DBNull.Value ? null : objRow[convzx_SysCount.CountTypeId].ToString().Trim(); //CountTypeId(字段类型:char,字段长度:2,是否可空:True)
 objvzx_SysCountEN.PaperRWCount = objRow[convzx_SysCount.PaperRWCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysCount.PaperRWCount].ToString().Trim()); //PaperRWCount(字段类型:int,字段长度:4,是否可空:True)
 objvzx_SysCountEN.OkCount = objRow[convzx_SysCount.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysCount.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objvzx_SysCountEN.CollectionCount = objRow[convzx_SysCount.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysCount.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvzx_SysCountEN.DownloadCount = objRow[convzx_SysCount.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysCount.DownloadCount].ToString().Trim()); //下载数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_SysCountEN.AttachmentCount = objRow[convzx_SysCount.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysCount.AttachmentCount].ToString().Trim()); //附件计数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_SysCountEN.CommentCount = objRow[convzx_SysCount.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysCount.CommentCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_SysCountEN.Score = objRow[convzx_SysCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SysCount.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvzx_SysCountEN.StuScore = objRow[convzx_SysCount.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SysCount.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objvzx_SysCountEN.TeaScore = objRow[convzx_SysCount.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SysCount.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objvzx_SysCountEN.TableKey = objRow[convzx_SysCount.TableKey] == DBNull.Value ? null : objRow[convzx_SysCount.TableKey].ToString().Trim(); //表主键(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_SysCountEN.ParentId = objRow[convzx_SysCount.ParentId] == DBNull.Value ? null : objRow[convzx_SysCount.ParentId].ToString().Trim(); //父Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvzx_SysCountEN.UpdUser = objRow[convzx_SysCount.UpdUser] == DBNull.Value ? null : objRow[convzx_SysCount.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_SysCountEN.UpdDate = objRow[convzx_SysCount.UpdDate] == DBNull.Value ? null : objRow[convzx_SysCount.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_SysCountEN.Memo = objRow[convzx_SysCount.Memo] == DBNull.Value ? null : objRow[convzx_SysCount.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvzx_SysCountDA: GetObjByzxCountId)", objException.Message));
}
return objvzx_SysCountEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvzx_SysCountEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvzx_SysCountDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SysCountDA.GetSpecSQLObj();
strSQL = "Select * from vzx_SysCount where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvzx_SysCountEN objvzx_SysCountEN = new clsvzx_SysCountEN()
{
CommentTypeName = objRow[convzx_SysCount.CommentTypeName] == DBNull.Value ? null : objRow[convzx_SysCount.CommentTypeName].ToString().Trim(), //评论类型名
CommentTable = objRow[convzx_SysCount.CommentTable] == DBNull.Value ? null : objRow[convzx_SysCount.CommentTable].ToString().Trim(), //评论表
zxCountId = objRow[convzx_SysCount.zxCountId].ToString().Trim(), //CountId
CommentTableId = objRow[convzx_SysCount.CommentTableId] == DBNull.Value ? null : objRow[convzx_SysCount.CommentTableId].ToString().Trim(), //评论表Id
CountTypeId = objRow[convzx_SysCount.CountTypeId] == DBNull.Value ? null : objRow[convzx_SysCount.CountTypeId].ToString().Trim(), //CountTypeId
PaperRWCount = objRow[convzx_SysCount.PaperRWCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_SysCount.PaperRWCount].ToString().Trim()), //PaperRWCount
OkCount = objRow[convzx_SysCount.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_SysCount.OkCount].ToString().Trim()), //点赞统计
CollectionCount = objRow[convzx_SysCount.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convzx_SysCount.CollectionCount].ToString().Trim()), //收藏数量
DownloadCount = objRow[convzx_SysCount.DownloadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_SysCount.DownloadCount].ToString().Trim()), //下载数
AttachmentCount = objRow[convzx_SysCount.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_SysCount.AttachmentCount].ToString().Trim()), //附件计数
CommentCount = objRow[convzx_SysCount.CommentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_SysCount.CommentCount].ToString().Trim()), //评论数
Score = objRow[convzx_SysCount.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_SysCount.Score].ToString().Trim()), //评分
StuScore = objRow[convzx_SysCount.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_SysCount.StuScore].ToString().Trim()), //学生平均分
TeaScore = objRow[convzx_SysCount.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_SysCount.TeaScore].ToString().Trim()), //教师评分
TableKey = objRow[convzx_SysCount.TableKey] == DBNull.Value ? null : objRow[convzx_SysCount.TableKey].ToString().Trim(), //表主键
ParentId = objRow[convzx_SysCount.ParentId] == DBNull.Value ? null : objRow[convzx_SysCount.ParentId].ToString().Trim(), //父Id
UpdUser = objRow[convzx_SysCount.UpdUser] == DBNull.Value ? null : objRow[convzx_SysCount.UpdUser].ToString().Trim(), //修改人
UpdDate = objRow[convzx_SysCount.UpdDate] == DBNull.Value ? null : objRow[convzx_SysCount.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[convzx_SysCount.Memo] == DBNull.Value ? null : objRow[convzx_SysCount.Memo].ToString().Trim() //备注
};
objvzx_SysCountEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvzx_SysCountEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvzx_SysCountDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvzx_SysCountEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvzx_SysCountEN objvzx_SysCountEN = new clsvzx_SysCountEN();
try
{
objvzx_SysCountEN.CommentTypeName = objRow[convzx_SysCount.CommentTypeName] == DBNull.Value ? null : objRow[convzx_SysCount.CommentTypeName].ToString().Trim(); //评论类型名
objvzx_SysCountEN.CommentTable = objRow[convzx_SysCount.CommentTable] == DBNull.Value ? null : objRow[convzx_SysCount.CommentTable].ToString().Trim(); //评论表
objvzx_SysCountEN.zxCountId = objRow[convzx_SysCount.zxCountId].ToString().Trim(); //CountId
objvzx_SysCountEN.CommentTableId = objRow[convzx_SysCount.CommentTableId] == DBNull.Value ? null : objRow[convzx_SysCount.CommentTableId].ToString().Trim(); //评论表Id
objvzx_SysCountEN.CountTypeId = objRow[convzx_SysCount.CountTypeId] == DBNull.Value ? null : objRow[convzx_SysCount.CountTypeId].ToString().Trim(); //CountTypeId
objvzx_SysCountEN.PaperRWCount = objRow[convzx_SysCount.PaperRWCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_SysCount.PaperRWCount].ToString().Trim()); //PaperRWCount
objvzx_SysCountEN.OkCount = objRow[convzx_SysCount.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_SysCount.OkCount].ToString().Trim()); //点赞统计
objvzx_SysCountEN.CollectionCount = objRow[convzx_SysCount.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convzx_SysCount.CollectionCount].ToString().Trim()); //收藏数量
objvzx_SysCountEN.DownloadCount = objRow[convzx_SysCount.DownloadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_SysCount.DownloadCount].ToString().Trim()); //下载数
objvzx_SysCountEN.AttachmentCount = objRow[convzx_SysCount.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_SysCount.AttachmentCount].ToString().Trim()); //附件计数
objvzx_SysCountEN.CommentCount = objRow[convzx_SysCount.CommentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_SysCount.CommentCount].ToString().Trim()); //评论数
objvzx_SysCountEN.Score = objRow[convzx_SysCount.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_SysCount.Score].ToString().Trim()); //评分
objvzx_SysCountEN.StuScore = objRow[convzx_SysCount.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_SysCount.StuScore].ToString().Trim()); //学生平均分
objvzx_SysCountEN.TeaScore = objRow[convzx_SysCount.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_SysCount.TeaScore].ToString().Trim()); //教师评分
objvzx_SysCountEN.TableKey = objRow[convzx_SysCount.TableKey] == DBNull.Value ? null : objRow[convzx_SysCount.TableKey].ToString().Trim(); //表主键
objvzx_SysCountEN.ParentId = objRow[convzx_SysCount.ParentId] == DBNull.Value ? null : objRow[convzx_SysCount.ParentId].ToString().Trim(); //父Id
objvzx_SysCountEN.UpdUser = objRow[convzx_SysCount.UpdUser] == DBNull.Value ? null : objRow[convzx_SysCount.UpdUser].ToString().Trim(); //修改人
objvzx_SysCountEN.UpdDate = objRow[convzx_SysCount.UpdDate] == DBNull.Value ? null : objRow[convzx_SysCount.UpdDate].ToString().Trim(); //修改日期
objvzx_SysCountEN.Memo = objRow[convzx_SysCount.Memo] == DBNull.Value ? null : objRow[convzx_SysCount.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvzx_SysCountDA: GetObjByDataRowvzx_SysCount)", objException.Message));
}
objvzx_SysCountEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvzx_SysCountEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvzx_SysCountEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvzx_SysCountEN objvzx_SysCountEN = new clsvzx_SysCountEN();
try
{
objvzx_SysCountEN.CommentTypeName = objRow[convzx_SysCount.CommentTypeName] == DBNull.Value ? null : objRow[convzx_SysCount.CommentTypeName].ToString().Trim(); //评论类型名
objvzx_SysCountEN.CommentTable = objRow[convzx_SysCount.CommentTable] == DBNull.Value ? null : objRow[convzx_SysCount.CommentTable].ToString().Trim(); //评论表
objvzx_SysCountEN.zxCountId = objRow[convzx_SysCount.zxCountId].ToString().Trim(); //CountId
objvzx_SysCountEN.CommentTableId = objRow[convzx_SysCount.CommentTableId] == DBNull.Value ? null : objRow[convzx_SysCount.CommentTableId].ToString().Trim(); //评论表Id
objvzx_SysCountEN.CountTypeId = objRow[convzx_SysCount.CountTypeId] == DBNull.Value ? null : objRow[convzx_SysCount.CountTypeId].ToString().Trim(); //CountTypeId
objvzx_SysCountEN.PaperRWCount = objRow[convzx_SysCount.PaperRWCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_SysCount.PaperRWCount].ToString().Trim()); //PaperRWCount
objvzx_SysCountEN.OkCount = objRow[convzx_SysCount.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_SysCount.OkCount].ToString().Trim()); //点赞统计
objvzx_SysCountEN.CollectionCount = objRow[convzx_SysCount.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convzx_SysCount.CollectionCount].ToString().Trim()); //收藏数量
objvzx_SysCountEN.DownloadCount = objRow[convzx_SysCount.DownloadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_SysCount.DownloadCount].ToString().Trim()); //下载数
objvzx_SysCountEN.AttachmentCount = objRow[convzx_SysCount.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_SysCount.AttachmentCount].ToString().Trim()); //附件计数
objvzx_SysCountEN.CommentCount = objRow[convzx_SysCount.CommentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_SysCount.CommentCount].ToString().Trim()); //评论数
objvzx_SysCountEN.Score = objRow[convzx_SysCount.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_SysCount.Score].ToString().Trim()); //评分
objvzx_SysCountEN.StuScore = objRow[convzx_SysCount.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_SysCount.StuScore].ToString().Trim()); //学生平均分
objvzx_SysCountEN.TeaScore = objRow[convzx_SysCount.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_SysCount.TeaScore].ToString().Trim()); //教师评分
objvzx_SysCountEN.TableKey = objRow[convzx_SysCount.TableKey] == DBNull.Value ? null : objRow[convzx_SysCount.TableKey].ToString().Trim(); //表主键
objvzx_SysCountEN.ParentId = objRow[convzx_SysCount.ParentId] == DBNull.Value ? null : objRow[convzx_SysCount.ParentId].ToString().Trim(); //父Id
objvzx_SysCountEN.UpdUser = objRow[convzx_SysCount.UpdUser] == DBNull.Value ? null : objRow[convzx_SysCount.UpdUser].ToString().Trim(); //修改人
objvzx_SysCountEN.UpdDate = objRow[convzx_SysCount.UpdDate] == DBNull.Value ? null : objRow[convzx_SysCount.UpdDate].ToString().Trim(); //修改日期
objvzx_SysCountEN.Memo = objRow[convzx_SysCount.Memo] == DBNull.Value ? null : objRow[convzx_SysCount.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvzx_SysCountDA: GetObjByDataRow)", objException.Message));
}
objvzx_SysCountEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvzx_SysCountEN;
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
objSQL = clsvzx_SysCountDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvzx_SysCountEN._CurrTabName, convzx_SysCount.zxCountId, 10, "");
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
objSQL = clsvzx_SysCountDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvzx_SysCountEN._CurrTabName, convzx_SysCount.zxCountId, 10, strPrefix);
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
 objSQL = clsvzx_SysCountDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select zxCountId from vzx_SysCount where " + strCondition;
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
 objSQL = clsvzx_SysCountDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select zxCountId from vzx_SysCount where " + strCondition;
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
 /// <param name = "strzxCountId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strzxCountId)
{
CheckPrimaryKey(strzxCountId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SysCountDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vzx_SysCount", "zxCountId = " + "'"+ strzxCountId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvzx_SysCountDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SysCountDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vzx_SysCount", strCondition))
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
objSQL = clsvzx_SysCountDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vzx_SysCount");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvzx_SysCountENS">源对象</param>
 /// <param name = "objvzx_SysCountENT">目标对象</param>
public void CopyTo(clsvzx_SysCountEN objvzx_SysCountENS, clsvzx_SysCountEN objvzx_SysCountENT)
{
objvzx_SysCountENT.CommentTypeName = objvzx_SysCountENS.CommentTypeName; //评论类型名
objvzx_SysCountENT.CommentTable = objvzx_SysCountENS.CommentTable; //评论表
objvzx_SysCountENT.zxCountId = objvzx_SysCountENS.zxCountId; //CountId
objvzx_SysCountENT.CommentTableId = objvzx_SysCountENS.CommentTableId; //评论表Id
objvzx_SysCountENT.CountTypeId = objvzx_SysCountENS.CountTypeId; //CountTypeId
objvzx_SysCountENT.PaperRWCount = objvzx_SysCountENS.PaperRWCount; //PaperRWCount
objvzx_SysCountENT.OkCount = objvzx_SysCountENS.OkCount; //点赞统计
objvzx_SysCountENT.CollectionCount = objvzx_SysCountENS.CollectionCount; //收藏数量
objvzx_SysCountENT.DownloadCount = objvzx_SysCountENS.DownloadCount; //下载数
objvzx_SysCountENT.AttachmentCount = objvzx_SysCountENS.AttachmentCount; //附件计数
objvzx_SysCountENT.CommentCount = objvzx_SysCountENS.CommentCount; //评论数
objvzx_SysCountENT.Score = objvzx_SysCountENS.Score; //评分
objvzx_SysCountENT.StuScore = objvzx_SysCountENS.StuScore; //学生平均分
objvzx_SysCountENT.TeaScore = objvzx_SysCountENS.TeaScore; //教师评分
objvzx_SysCountENT.TableKey = objvzx_SysCountENS.TableKey; //表主键
objvzx_SysCountENT.ParentId = objvzx_SysCountENS.ParentId; //父Id
objvzx_SysCountENT.UpdUser = objvzx_SysCountENS.UpdUser; //修改人
objvzx_SysCountENT.UpdDate = objvzx_SysCountENS.UpdDate; //修改日期
objvzx_SysCountENT.Memo = objvzx_SysCountENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvzx_SysCountEN objvzx_SysCountEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvzx_SysCountEN.CommentTypeName, 50, convzx_SysCount.CommentTypeName);
clsCheckSql.CheckFieldLen(objvzx_SysCountEN.CommentTable, 50, convzx_SysCount.CommentTable);
clsCheckSql.CheckFieldLen(objvzx_SysCountEN.zxCountId, 10, convzx_SysCount.zxCountId);
clsCheckSql.CheckFieldLen(objvzx_SysCountEN.CommentTableId, 50, convzx_SysCount.CommentTableId);
clsCheckSql.CheckFieldLen(objvzx_SysCountEN.CountTypeId, 2, convzx_SysCount.CountTypeId);
clsCheckSql.CheckFieldLen(objvzx_SysCountEN.TableKey, 20, convzx_SysCount.TableKey);
clsCheckSql.CheckFieldLen(objvzx_SysCountEN.ParentId, 20, convzx_SysCount.ParentId);
clsCheckSql.CheckFieldLen(objvzx_SysCountEN.UpdUser, 20, convzx_SysCount.UpdUser);
clsCheckSql.CheckFieldLen(objvzx_SysCountEN.UpdDate, 20, convzx_SysCount.UpdDate);
clsCheckSql.CheckFieldLen(objvzx_SysCountEN.Memo, 1000, convzx_SysCount.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvzx_SysCountEN.CommentTypeName, convzx_SysCount.CommentTypeName);
clsCheckSql.CheckSqlInjection4Field(objvzx_SysCountEN.CommentTable, convzx_SysCount.CommentTable);
clsCheckSql.CheckSqlInjection4Field(objvzx_SysCountEN.zxCountId, convzx_SysCount.zxCountId);
clsCheckSql.CheckSqlInjection4Field(objvzx_SysCountEN.CommentTableId, convzx_SysCount.CommentTableId);
clsCheckSql.CheckSqlInjection4Field(objvzx_SysCountEN.CountTypeId, convzx_SysCount.CountTypeId);
clsCheckSql.CheckSqlInjection4Field(objvzx_SysCountEN.TableKey, convzx_SysCount.TableKey);
clsCheckSql.CheckSqlInjection4Field(objvzx_SysCountEN.ParentId, convzx_SysCount.ParentId);
clsCheckSql.CheckSqlInjection4Field(objvzx_SysCountEN.UpdUser, convzx_SysCount.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvzx_SysCountEN.UpdDate, convzx_SysCount.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvzx_SysCountEN.Memo, convzx_SysCount.Memo);
//检查外键字段长度
 objvzx_SysCountEN._IsCheckProperty = true;
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
 objSQL = clsvzx_SysCountDA.GetSpecSQLObj();
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
 objSQL = clsvzx_SysCountDA.GetSpecSQLObj();
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
 objSQL = clsvzx_SysCountDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvzx_SysCountEN._CurrTabName);
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
 objSQL = clsvzx_SysCountDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvzx_SysCountEN._CurrTabName, strCondition);
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
 objSQL = clsvzx_SysCountDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}