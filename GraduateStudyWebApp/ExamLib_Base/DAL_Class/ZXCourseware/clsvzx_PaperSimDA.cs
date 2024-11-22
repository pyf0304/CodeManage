
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_PaperSimDA
 表名:vzx_PaperSim(01120848)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:51:34
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学生课件管理(ZXCourseware)
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
 /// vzx_PaperSim(vzx_PaperSim)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvzx_PaperSimDA : clsCommBase4DA
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
 return clsvzx_PaperSimEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvzx_PaperSimEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvzx_PaperSimEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvzx_PaperSimEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvzx_PaperSimEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strTextId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strTextId)
{
strTextId = strTextId.Replace("'", "''");
if (strTextId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vzx_PaperSim中,检查关键字,长度不正确!(clsvzx_PaperSimDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strTextId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vzx_PaperSim中,关键字不能为空 或 null!(clsvzx_PaperSimDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTextId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvzx_PaperSimDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvzx_PaperSimDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_PaperSimDA.GetSpecSQLObj();
strSQL = "Select * from vzx_PaperSim where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vzx_PaperSim(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvzx_PaperSimDA: GetDataTable_vzx_PaperSim)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_PaperSimDA.GetSpecSQLObj();
strSQL = "Select * from vzx_PaperSim where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvzx_PaperSimDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_PaperSimDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvzx_PaperSimDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_PaperSimDA.GetSpecSQLObj();
strSQL = "Select * from vzx_PaperSim where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvzx_PaperSimDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_PaperSimDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvzx_PaperSimDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_PaperSimDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vzx_PaperSim where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vzx_PaperSim where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvzx_PaperSimDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_PaperSimDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vzx_PaperSim where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvzx_PaperSimDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_PaperSimDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vzx_PaperSim.* from vzx_PaperSim Left Join {1} on {2} where {3} and vzx_PaperSim.TextId not in (Select top {5} vzx_PaperSim.TextId from vzx_PaperSim Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vzx_PaperSim where {1} and TextId not in (Select top {2} TextId from vzx_PaperSim where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vzx_PaperSim where {1} and TextId not in (Select top {3} TextId from vzx_PaperSim where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvzx_PaperSimDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_PaperSimDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vzx_PaperSim.* from vzx_PaperSim Left Join {1} on {2} where {3} and vzx_PaperSim.TextId not in (Select top {5} vzx_PaperSim.TextId from vzx_PaperSim Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vzx_PaperSim where {1} and TextId not in (Select top {2} TextId from vzx_PaperSim where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vzx_PaperSim where {1} and TextId not in (Select top {3} TextId from vzx_PaperSim where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvzx_PaperSimEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvzx_PaperSimDA:GetObjLst)", objException.Message));
}
List<clsvzx_PaperSimEN> arrObjLst = new List<clsvzx_PaperSimEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_PaperSimDA.GetSpecSQLObj();
strSQL = "Select * from vzx_PaperSim where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_PaperSimEN objvzx_PaperSimEN = new clsvzx_PaperSimEN();
try
{
objvzx_PaperSimEN.EduClsName = objRow[convzx_PaperSim.EduClsName] == DBNull.Value ? null : objRow[convzx_PaperSim.EduClsName].ToString().Trim(); //教学班名
objvzx_PaperSimEN.CollegeName = objRow[convzx_PaperSim.CollegeName] == DBNull.Value ? null : objRow[convzx_PaperSim.CollegeName].ToString().Trim(); //学院名称
objvzx_PaperSimEN.MajorName = objRow[convzx_PaperSim.MajorName] == DBNull.Value ? null : objRow[convzx_PaperSim.MajorName].ToString().Trim(); //专业名称
objvzx_PaperSimEN.IdXzMajor = objRow[convzx_PaperSim.IdXzMajor] == DBNull.Value ? null : objRow[convzx_PaperSim.IdXzMajor].ToString().Trim(); //专业流水号
objvzx_PaperSimEN.IdXzCollege = objRow[convzx_PaperSim.IdXzCollege] == DBNull.Value ? null : objRow[convzx_PaperSim.IdXzCollege].ToString().Trim(); //学院流水号
objvzx_PaperSimEN.IsGSuser = TransNullToBool(objRow[convzx_PaperSim.IsGSuser].ToString().Trim()); //是否GS用户
objvzx_PaperSimEN.UserName = objRow[convzx_PaperSim.UserName] == DBNull.Value ? null : objRow[convzx_PaperSim.UserName].ToString().Trim(); //用户名
objvzx_PaperSimEN.TextId = objRow[convzx_PaperSim.TextId].ToString().Trim(); //课件Id
objvzx_PaperSimEN.TextTitle = objRow[convzx_PaperSim.TextTitle].ToString().Trim(); //TextTitle
objvzx_PaperSimEN.TextContent = objRow[convzx_PaperSim.TextContent] == DBNull.Value ? null : objRow[convzx_PaperSim.TextContent].ToString().Trim(); //TextContent
objvzx_PaperSimEN.Edition = objRow[convzx_PaperSim.Edition] == DBNull.Value ? null : objRow[convzx_PaperSim.Edition].ToString().Trim(); //Edition
objvzx_PaperSimEN.Author = objRow[convzx_PaperSim.Author] == DBNull.Value ? null : objRow[convzx_PaperSim.Author].ToString().Trim(); //作者
objvzx_PaperSimEN.ResearchQuestion = objRow[convzx_PaperSim.ResearchQuestion] == DBNull.Value ? null : objRow[convzx_PaperSim.ResearchQuestion].ToString().Trim(); //研究问题
objvzx_PaperSimEN.UpdDate = objRow[convzx_PaperSim.UpdDate] == DBNull.Value ? null : objRow[convzx_PaperSim.UpdDate].ToString().Trim(); //修改日期
objvzx_PaperSimEN.TeaQCount = objRow[convzx_PaperSim.TeaQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperSim.TeaQCount].ToString().Trim()); //教师提问数
objvzx_PaperSimEN.TagsCount = objRow[convzx_PaperSim.TagsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperSim.TagsCount].ToString().Trim()); //论文标注数
objvzx_PaperSimEN.SubVCount = objRow[convzx_PaperSim.SubVCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperSim.SubVCount].ToString().Trim()); //论文子观点数
objvzx_PaperSimEN.PaperQCount = objRow[convzx_PaperSim.PaperQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperSim.PaperQCount].ToString().Trim()); //论文答疑数
objvzx_PaperSimEN.Memo = objRow[convzx_PaperSim.Memo] == DBNull.Value ? null : objRow[convzx_PaperSim.Memo].ToString().Trim(); //备注
objvzx_PaperSimEN.GradeId = objRow[convzx_PaperSim.GradeId] == DBNull.Value ? null : objRow[convzx_PaperSim.GradeId].ToString().Trim(); //年级代号
objvzx_PaperSimEN.SchoolTerm = objRow[convzx_PaperSim.SchoolTerm] == DBNull.Value ? null : objRow[convzx_PaperSim.SchoolTerm].ToString().Trim(); //学期
objvzx_PaperSimEN.UnitId = objRow[convzx_PaperSim.UnitId] == DBNull.Value ? null : objRow[convzx_PaperSim.UnitId].ToString().Trim(); //UnitId
objvzx_PaperSimEN.zxShareId = objRow[convzx_PaperSim.zxShareId] == DBNull.Value ? null : objRow[convzx_PaperSim.zxShareId].ToString().Trim(); //分享Id
objvzx_PaperSimEN.IsPublic = TransNullToBool(objRow[convzx_PaperSim.IsPublic].ToString().Trim()); //是否公开
objvzx_PaperSimEN.VersionCount = objRow[convzx_PaperSim.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperSim.VersionCount].ToString().Trim()); //版本统计
objvzx_PaperSimEN.StuScore = objRow[convzx_PaperSim.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_PaperSim.StuScore].ToString().Trim()); //学生平均分
objvzx_PaperSimEN.TeaScore = objRow[convzx_PaperSim.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_PaperSim.TeaScore].ToString().Trim()); //教师评分
objvzx_PaperSimEN.Score = objRow[convzx_PaperSim.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_PaperSim.Score].ToString().Trim()); //评分
objvzx_PaperSimEN.AppraiseCount = objRow[convzx_PaperSim.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperSim.AppraiseCount].ToString().Trim()); //评论数
objvzx_PaperSimEN.DownloadCount = objRow[convzx_PaperSim.DownloadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperSim.DownloadCount].ToString().Trim()); //下载数
objvzx_PaperSimEN.CollectionCount = objRow[convzx_PaperSim.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convzx_PaperSim.CollectionCount].ToString().Trim()); //收藏数量
objvzx_PaperSimEN.VoteCount = objRow[convzx_PaperSim.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperSim.VoteCount].ToString().Trim()); //点赞计数
objvzx_PaperSimEN.VCount = objRow[convzx_PaperSim.VCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperSim.VCount].ToString().Trim()); //VCount
objvzx_PaperSimEN.LiteratureLink = objRow[convzx_PaperSim.LiteratureLink] == DBNull.Value ? null : objRow[convzx_PaperSim.LiteratureLink].ToString().Trim(); //文献链接
objvzx_PaperSimEN.UploadfileUrl = objRow[convzx_PaperSim.UploadfileUrl] == DBNull.Value ? null : objRow[convzx_PaperSim.UploadfileUrl].ToString().Trim(); //文件地址
objvzx_PaperSimEN.IsSubmit = TransNullToBool(objRow[convzx_PaperSim.IsSubmit].ToString().Trim()); //是否提交
objvzx_PaperSimEN.IsChecked = TransNullToBool(objRow[convzx_PaperSim.IsChecked].ToString().Trim()); //是否检查
objvzx_PaperSimEN.BrowseNumber = objRow[convzx_PaperSim.BrowseNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperSim.BrowseNumber].ToString().Trim()); //浏览量
objvzx_PaperSimEN.AttachmentCount = objRow[convzx_PaperSim.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperSim.AttachmentCount].ToString().Trim()); //附件计数
objvzx_PaperSimEN.UpdUser = objRow[convzx_PaperSim.UpdUser] == DBNull.Value ? null : objRow[convzx_PaperSim.UpdUser].ToString().Trim(); //修改人
objvzx_PaperSimEN.CreateDate = objRow[convzx_PaperSim.CreateDate] == DBNull.Value ? null : objRow[convzx_PaperSim.CreateDate].ToString().Trim(); //建立日期
objvzx_PaperSimEN.Checker = objRow[convzx_PaperSim.Checker] == DBNull.Value ? null : objRow[convzx_PaperSim.Checker].ToString().Trim(); //审核人
objvzx_PaperSimEN.IdCurrEduCls = objRow[convzx_PaperSim.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_PaperSim.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_PaperSimEN.Keyword = objRow[convzx_PaperSim.Keyword] == DBNull.Value ? null : objRow[convzx_PaperSim.Keyword].ToString().Trim(); //关键字
objvzx_PaperSimEN.LiteratureSources = objRow[convzx_PaperSim.LiteratureSources] == DBNull.Value ? null : objRow[convzx_PaperSim.LiteratureSources].ToString().Trim(); //文献来源
objvzx_PaperSimEN.TextTypeId = objRow[convzx_PaperSim.TextTypeId] == DBNull.Value ? null : objRow[convzx_PaperSim.TextTypeId].ToString().Trim(); //TextTypeId
objvzx_PaperSimEN.TextStatusId = objRow[convzx_PaperSim.TextStatusId] == DBNull.Value ? null : objRow[convzx_PaperSim.TextStatusId].ToString().Trim(); //TextStatusId
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvzx_PaperSimDA: GetObjLst)", objException.Message));
}
objvzx_PaperSimEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvzx_PaperSimEN);
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
public List<clsvzx_PaperSimEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvzx_PaperSimDA:GetObjLstByTabName)", objException.Message));
}
List<clsvzx_PaperSimEN> arrObjLst = new List<clsvzx_PaperSimEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_PaperSimDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_PaperSimEN objvzx_PaperSimEN = new clsvzx_PaperSimEN();
try
{
objvzx_PaperSimEN.EduClsName = objRow[convzx_PaperSim.EduClsName] == DBNull.Value ? null : objRow[convzx_PaperSim.EduClsName].ToString().Trim(); //教学班名
objvzx_PaperSimEN.CollegeName = objRow[convzx_PaperSim.CollegeName] == DBNull.Value ? null : objRow[convzx_PaperSim.CollegeName].ToString().Trim(); //学院名称
objvzx_PaperSimEN.MajorName = objRow[convzx_PaperSim.MajorName] == DBNull.Value ? null : objRow[convzx_PaperSim.MajorName].ToString().Trim(); //专业名称
objvzx_PaperSimEN.IdXzMajor = objRow[convzx_PaperSim.IdXzMajor] == DBNull.Value ? null : objRow[convzx_PaperSim.IdXzMajor].ToString().Trim(); //专业流水号
objvzx_PaperSimEN.IdXzCollege = objRow[convzx_PaperSim.IdXzCollege] == DBNull.Value ? null : objRow[convzx_PaperSim.IdXzCollege].ToString().Trim(); //学院流水号
objvzx_PaperSimEN.IsGSuser = TransNullToBool(objRow[convzx_PaperSim.IsGSuser].ToString().Trim()); //是否GS用户
objvzx_PaperSimEN.UserName = objRow[convzx_PaperSim.UserName] == DBNull.Value ? null : objRow[convzx_PaperSim.UserName].ToString().Trim(); //用户名
objvzx_PaperSimEN.TextId = objRow[convzx_PaperSim.TextId].ToString().Trim(); //课件Id
objvzx_PaperSimEN.TextTitle = objRow[convzx_PaperSim.TextTitle].ToString().Trim(); //TextTitle
objvzx_PaperSimEN.TextContent = objRow[convzx_PaperSim.TextContent] == DBNull.Value ? null : objRow[convzx_PaperSim.TextContent].ToString().Trim(); //TextContent
objvzx_PaperSimEN.Edition = objRow[convzx_PaperSim.Edition] == DBNull.Value ? null : objRow[convzx_PaperSim.Edition].ToString().Trim(); //Edition
objvzx_PaperSimEN.Author = objRow[convzx_PaperSim.Author] == DBNull.Value ? null : objRow[convzx_PaperSim.Author].ToString().Trim(); //作者
objvzx_PaperSimEN.ResearchQuestion = objRow[convzx_PaperSim.ResearchQuestion] == DBNull.Value ? null : objRow[convzx_PaperSim.ResearchQuestion].ToString().Trim(); //研究问题
objvzx_PaperSimEN.UpdDate = objRow[convzx_PaperSim.UpdDate] == DBNull.Value ? null : objRow[convzx_PaperSim.UpdDate].ToString().Trim(); //修改日期
objvzx_PaperSimEN.TeaQCount = objRow[convzx_PaperSim.TeaQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperSim.TeaQCount].ToString().Trim()); //教师提问数
objvzx_PaperSimEN.TagsCount = objRow[convzx_PaperSim.TagsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperSim.TagsCount].ToString().Trim()); //论文标注数
objvzx_PaperSimEN.SubVCount = objRow[convzx_PaperSim.SubVCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperSim.SubVCount].ToString().Trim()); //论文子观点数
objvzx_PaperSimEN.PaperQCount = objRow[convzx_PaperSim.PaperQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperSim.PaperQCount].ToString().Trim()); //论文答疑数
objvzx_PaperSimEN.Memo = objRow[convzx_PaperSim.Memo] == DBNull.Value ? null : objRow[convzx_PaperSim.Memo].ToString().Trim(); //备注
objvzx_PaperSimEN.GradeId = objRow[convzx_PaperSim.GradeId] == DBNull.Value ? null : objRow[convzx_PaperSim.GradeId].ToString().Trim(); //年级代号
objvzx_PaperSimEN.SchoolTerm = objRow[convzx_PaperSim.SchoolTerm] == DBNull.Value ? null : objRow[convzx_PaperSim.SchoolTerm].ToString().Trim(); //学期
objvzx_PaperSimEN.UnitId = objRow[convzx_PaperSim.UnitId] == DBNull.Value ? null : objRow[convzx_PaperSim.UnitId].ToString().Trim(); //UnitId
objvzx_PaperSimEN.zxShareId = objRow[convzx_PaperSim.zxShareId] == DBNull.Value ? null : objRow[convzx_PaperSim.zxShareId].ToString().Trim(); //分享Id
objvzx_PaperSimEN.IsPublic = TransNullToBool(objRow[convzx_PaperSim.IsPublic].ToString().Trim()); //是否公开
objvzx_PaperSimEN.VersionCount = objRow[convzx_PaperSim.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperSim.VersionCount].ToString().Trim()); //版本统计
objvzx_PaperSimEN.StuScore = objRow[convzx_PaperSim.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_PaperSim.StuScore].ToString().Trim()); //学生平均分
objvzx_PaperSimEN.TeaScore = objRow[convzx_PaperSim.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_PaperSim.TeaScore].ToString().Trim()); //教师评分
objvzx_PaperSimEN.Score = objRow[convzx_PaperSim.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_PaperSim.Score].ToString().Trim()); //评分
objvzx_PaperSimEN.AppraiseCount = objRow[convzx_PaperSim.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperSim.AppraiseCount].ToString().Trim()); //评论数
objvzx_PaperSimEN.DownloadCount = objRow[convzx_PaperSim.DownloadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperSim.DownloadCount].ToString().Trim()); //下载数
objvzx_PaperSimEN.CollectionCount = objRow[convzx_PaperSim.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convzx_PaperSim.CollectionCount].ToString().Trim()); //收藏数量
objvzx_PaperSimEN.VoteCount = objRow[convzx_PaperSim.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperSim.VoteCount].ToString().Trim()); //点赞计数
objvzx_PaperSimEN.VCount = objRow[convzx_PaperSim.VCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperSim.VCount].ToString().Trim()); //VCount
objvzx_PaperSimEN.LiteratureLink = objRow[convzx_PaperSim.LiteratureLink] == DBNull.Value ? null : objRow[convzx_PaperSim.LiteratureLink].ToString().Trim(); //文献链接
objvzx_PaperSimEN.UploadfileUrl = objRow[convzx_PaperSim.UploadfileUrl] == DBNull.Value ? null : objRow[convzx_PaperSim.UploadfileUrl].ToString().Trim(); //文件地址
objvzx_PaperSimEN.IsSubmit = TransNullToBool(objRow[convzx_PaperSim.IsSubmit].ToString().Trim()); //是否提交
objvzx_PaperSimEN.IsChecked = TransNullToBool(objRow[convzx_PaperSim.IsChecked].ToString().Trim()); //是否检查
objvzx_PaperSimEN.BrowseNumber = objRow[convzx_PaperSim.BrowseNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperSim.BrowseNumber].ToString().Trim()); //浏览量
objvzx_PaperSimEN.AttachmentCount = objRow[convzx_PaperSim.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperSim.AttachmentCount].ToString().Trim()); //附件计数
objvzx_PaperSimEN.UpdUser = objRow[convzx_PaperSim.UpdUser] == DBNull.Value ? null : objRow[convzx_PaperSim.UpdUser].ToString().Trim(); //修改人
objvzx_PaperSimEN.CreateDate = objRow[convzx_PaperSim.CreateDate] == DBNull.Value ? null : objRow[convzx_PaperSim.CreateDate].ToString().Trim(); //建立日期
objvzx_PaperSimEN.Checker = objRow[convzx_PaperSim.Checker] == DBNull.Value ? null : objRow[convzx_PaperSim.Checker].ToString().Trim(); //审核人
objvzx_PaperSimEN.IdCurrEduCls = objRow[convzx_PaperSim.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_PaperSim.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_PaperSimEN.Keyword = objRow[convzx_PaperSim.Keyword] == DBNull.Value ? null : objRow[convzx_PaperSim.Keyword].ToString().Trim(); //关键字
objvzx_PaperSimEN.LiteratureSources = objRow[convzx_PaperSim.LiteratureSources] == DBNull.Value ? null : objRow[convzx_PaperSim.LiteratureSources].ToString().Trim(); //文献来源
objvzx_PaperSimEN.TextTypeId = objRow[convzx_PaperSim.TextTypeId] == DBNull.Value ? null : objRow[convzx_PaperSim.TextTypeId].ToString().Trim(); //TextTypeId
objvzx_PaperSimEN.TextStatusId = objRow[convzx_PaperSim.TextStatusId] == DBNull.Value ? null : objRow[convzx_PaperSim.TextStatusId].ToString().Trim(); //TextStatusId
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvzx_PaperSimDA: GetObjLst)", objException.Message));
}
objvzx_PaperSimEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvzx_PaperSimEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvzx_PaperSimEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getvzx_PaperSim(ref clsvzx_PaperSimEN objvzx_PaperSimEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_PaperSimDA.GetSpecSQLObj();
strSQL = "Select * from vzx_PaperSim where TextId = " + "'"+ objvzx_PaperSimEN.TextId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvzx_PaperSimEN.EduClsName = objDT.Rows[0][convzx_PaperSim.EduClsName].ToString().Trim(); //教学班名(字段类型:varchar,字段长度:100,是否可空:False)
 objvzx_PaperSimEN.CollegeName = objDT.Rows[0][convzx_PaperSim.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvzx_PaperSimEN.MajorName = objDT.Rows[0][convzx_PaperSim.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvzx_PaperSimEN.IdXzMajor = objDT.Rows[0][convzx_PaperSim.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvzx_PaperSimEN.IdXzCollege = objDT.Rows[0][convzx_PaperSim.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvzx_PaperSimEN.IsGSuser = TransNullToBool(objDT.Rows[0][convzx_PaperSim.IsGSuser].ToString().Trim()); //是否GS用户(字段类型:bit,字段长度:1,是否可空:True)
 objvzx_PaperSimEN.UserName = objDT.Rows[0][convzx_PaperSim.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvzx_PaperSimEN.TextId = objDT.Rows[0][convzx_PaperSim.TextId].ToString().Trim(); //课件Id(字段类型:char,字段长度:8,是否可空:False)
 objvzx_PaperSimEN.TextTitle = objDT.Rows[0][convzx_PaperSim.TextTitle].ToString().Trim(); //TextTitle(字段类型:varchar,字段长度:500,是否可空:False)
 objvzx_PaperSimEN.TextContent = objDT.Rows[0][convzx_PaperSim.TextContent].ToString().Trim(); //TextContent(字段类型:text,字段长度:2147483647,是否可空:True)
 objvzx_PaperSimEN.Edition = objDT.Rows[0][convzx_PaperSim.Edition].ToString().Trim(); //Edition(字段类型:varchar,字段长度:100,是否可空:True)
 objvzx_PaperSimEN.Author = objDT.Rows[0][convzx_PaperSim.Author].ToString().Trim(); //作者(字段类型:varchar,字段长度:200,是否可空:True)
 objvzx_PaperSimEN.ResearchQuestion = objDT.Rows[0][convzx_PaperSim.ResearchQuestion].ToString().Trim(); //研究问题(字段类型:varchar,字段长度:2000,是否可空:True)
 objvzx_PaperSimEN.UpdDate = objDT.Rows[0][convzx_PaperSim.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_PaperSimEN.TeaQCount = TransNullToInt(objDT.Rows[0][convzx_PaperSim.TeaQCount].ToString().Trim()); //教师提问数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_PaperSimEN.TagsCount = TransNullToInt(objDT.Rows[0][convzx_PaperSim.TagsCount].ToString().Trim()); //论文标注数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_PaperSimEN.SubVCount = TransNullToInt(objDT.Rows[0][convzx_PaperSim.SubVCount].ToString().Trim()); //论文子观点数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_PaperSimEN.PaperQCount = TransNullToInt(objDT.Rows[0][convzx_PaperSim.PaperQCount].ToString().Trim()); //论文答疑数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_PaperSimEN.Memo = objDT.Rows[0][convzx_PaperSim.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_PaperSimEN.GradeId = objDT.Rows[0][convzx_PaperSim.GradeId].ToString().Trim(); //年级代号(字段类型:char,字段长度:4,是否可空:True)
 objvzx_PaperSimEN.SchoolTerm = objDT.Rows[0][convzx_PaperSim.SchoolTerm].ToString().Trim(); //学期(字段类型:char,字段长度:1,是否可空:True)
 objvzx_PaperSimEN.UnitId = objDT.Rows[0][convzx_PaperSim.UnitId].ToString().Trim(); //UnitId(字段类型:char,字段长度:4,是否可空:True)
 objvzx_PaperSimEN.zxShareId = objDT.Rows[0][convzx_PaperSim.zxShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objvzx_PaperSimEN.IsPublic = TransNullToBool(objDT.Rows[0][convzx_PaperSim.IsPublic].ToString().Trim()); //是否公开(字段类型:bit,字段长度:1,是否可空:True)
 objvzx_PaperSimEN.VersionCount = TransNullToInt(objDT.Rows[0][convzx_PaperSim.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objvzx_PaperSimEN.StuScore = TransNullToFloat(objDT.Rows[0][convzx_PaperSim.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objvzx_PaperSimEN.TeaScore = TransNullToFloat(objDT.Rows[0][convzx_PaperSim.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objvzx_PaperSimEN.Score = TransNullToFloat(objDT.Rows[0][convzx_PaperSim.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvzx_PaperSimEN.AppraiseCount = TransNullToInt(objDT.Rows[0][convzx_PaperSim.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_PaperSimEN.DownloadCount = TransNullToInt(objDT.Rows[0][convzx_PaperSim.DownloadCount].ToString().Trim()); //下载数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_PaperSimEN.CollectionCount = TransNullToInt(objDT.Rows[0][convzx_PaperSim.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvzx_PaperSimEN.VoteCount = TransNullToInt(objDT.Rows[0][convzx_PaperSim.VoteCount].ToString().Trim()); //点赞计数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_PaperSimEN.VCount = TransNullToInt(objDT.Rows[0][convzx_PaperSim.VCount].ToString().Trim()); //VCount(字段类型:int,字段长度:4,是否可空:True)
 objvzx_PaperSimEN.LiteratureLink = objDT.Rows[0][convzx_PaperSim.LiteratureLink].ToString().Trim(); //文献链接(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_PaperSimEN.UploadfileUrl = objDT.Rows[0][convzx_PaperSim.UploadfileUrl].ToString().Trim(); //文件地址(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_PaperSimEN.IsSubmit = TransNullToBool(objDT.Rows[0][convzx_PaperSim.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvzx_PaperSimEN.IsChecked = TransNullToBool(objDT.Rows[0][convzx_PaperSim.IsChecked].ToString().Trim()); //是否检查(字段类型:bit,字段长度:1,是否可空:True)
 objvzx_PaperSimEN.BrowseNumber = TransNullToInt(objDT.Rows[0][convzx_PaperSim.BrowseNumber].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvzx_PaperSimEN.AttachmentCount = TransNullToInt(objDT.Rows[0][convzx_PaperSim.AttachmentCount].ToString().Trim()); //附件计数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_PaperSimEN.UpdUser = objDT.Rows[0][convzx_PaperSim.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_PaperSimEN.CreateDate = objDT.Rows[0][convzx_PaperSim.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_PaperSimEN.Checker = objDT.Rows[0][convzx_PaperSim.Checker].ToString().Trim(); //审核人(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_PaperSimEN.IdCurrEduCls = objDT.Rows[0][convzx_PaperSim.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvzx_PaperSimEN.Keyword = objDT.Rows[0][convzx_PaperSim.Keyword].ToString().Trim(); //关键字(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_PaperSimEN.LiteratureSources = objDT.Rows[0][convzx_PaperSim.LiteratureSources].ToString().Trim(); //文献来源(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_PaperSimEN.TextTypeId = objDT.Rows[0][convzx_PaperSim.TextTypeId].ToString().Trim(); //TextTypeId(字段类型:char,字段长度:2,是否可空:True)
 objvzx_PaperSimEN.TextStatusId = objDT.Rows[0][convzx_PaperSim.TextStatusId].ToString().Trim(); //TextStatusId(字段类型:char,字段长度:2,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvzx_PaperSimDA: Getvzx_PaperSim)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strTextId">表关键字</param>
 /// <returns>表对象</returns>
public clsvzx_PaperSimEN GetObjByTextId(string strTextId)
{
CheckPrimaryKey(strTextId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_PaperSimDA.GetSpecSQLObj();
strSQL = "Select * from vzx_PaperSim where TextId = " + "'"+ strTextId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvzx_PaperSimEN objvzx_PaperSimEN = new clsvzx_PaperSimEN();
try
{
 objvzx_PaperSimEN.EduClsName = objRow[convzx_PaperSim.EduClsName] == DBNull.Value ? null : objRow[convzx_PaperSim.EduClsName].ToString().Trim(); //教学班名(字段类型:varchar,字段长度:100,是否可空:False)
 objvzx_PaperSimEN.CollegeName = objRow[convzx_PaperSim.CollegeName] == DBNull.Value ? null : objRow[convzx_PaperSim.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvzx_PaperSimEN.MajorName = objRow[convzx_PaperSim.MajorName] == DBNull.Value ? null : objRow[convzx_PaperSim.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvzx_PaperSimEN.IdXzMajor = objRow[convzx_PaperSim.IdXzMajor] == DBNull.Value ? null : objRow[convzx_PaperSim.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvzx_PaperSimEN.IdXzCollege = objRow[convzx_PaperSim.IdXzCollege] == DBNull.Value ? null : objRow[convzx_PaperSim.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvzx_PaperSimEN.IsGSuser = clsEntityBase2.TransNullToBool_S(objRow[convzx_PaperSim.IsGSuser].ToString().Trim()); //是否GS用户(字段类型:bit,字段长度:1,是否可空:True)
 objvzx_PaperSimEN.UserName = objRow[convzx_PaperSim.UserName] == DBNull.Value ? null : objRow[convzx_PaperSim.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvzx_PaperSimEN.TextId = objRow[convzx_PaperSim.TextId].ToString().Trim(); //课件Id(字段类型:char,字段长度:8,是否可空:False)
 objvzx_PaperSimEN.TextTitle = objRow[convzx_PaperSim.TextTitle].ToString().Trim(); //TextTitle(字段类型:varchar,字段长度:500,是否可空:False)
 objvzx_PaperSimEN.TextContent = objRow[convzx_PaperSim.TextContent] == DBNull.Value ? null : objRow[convzx_PaperSim.TextContent].ToString().Trim(); //TextContent(字段类型:text,字段长度:2147483647,是否可空:True)
 objvzx_PaperSimEN.Edition = objRow[convzx_PaperSim.Edition] == DBNull.Value ? null : objRow[convzx_PaperSim.Edition].ToString().Trim(); //Edition(字段类型:varchar,字段长度:100,是否可空:True)
 objvzx_PaperSimEN.Author = objRow[convzx_PaperSim.Author] == DBNull.Value ? null : objRow[convzx_PaperSim.Author].ToString().Trim(); //作者(字段类型:varchar,字段长度:200,是否可空:True)
 objvzx_PaperSimEN.ResearchQuestion = objRow[convzx_PaperSim.ResearchQuestion] == DBNull.Value ? null : objRow[convzx_PaperSim.ResearchQuestion].ToString().Trim(); //研究问题(字段类型:varchar,字段长度:2000,是否可空:True)
 objvzx_PaperSimEN.UpdDate = objRow[convzx_PaperSim.UpdDate] == DBNull.Value ? null : objRow[convzx_PaperSim.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_PaperSimEN.TeaQCount = objRow[convzx_PaperSim.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.TeaQCount].ToString().Trim()); //教师提问数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_PaperSimEN.TagsCount = objRow[convzx_PaperSim.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.TagsCount].ToString().Trim()); //论文标注数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_PaperSimEN.SubVCount = objRow[convzx_PaperSim.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.SubVCount].ToString().Trim()); //论文子观点数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_PaperSimEN.PaperQCount = objRow[convzx_PaperSim.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.PaperQCount].ToString().Trim()); //论文答疑数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_PaperSimEN.Memo = objRow[convzx_PaperSim.Memo] == DBNull.Value ? null : objRow[convzx_PaperSim.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_PaperSimEN.GradeId = objRow[convzx_PaperSim.GradeId] == DBNull.Value ? null : objRow[convzx_PaperSim.GradeId].ToString().Trim(); //年级代号(字段类型:char,字段长度:4,是否可空:True)
 objvzx_PaperSimEN.SchoolTerm = objRow[convzx_PaperSim.SchoolTerm] == DBNull.Value ? null : objRow[convzx_PaperSim.SchoolTerm].ToString().Trim(); //学期(字段类型:char,字段长度:1,是否可空:True)
 objvzx_PaperSimEN.UnitId = objRow[convzx_PaperSim.UnitId] == DBNull.Value ? null : objRow[convzx_PaperSim.UnitId].ToString().Trim(); //UnitId(字段类型:char,字段长度:4,是否可空:True)
 objvzx_PaperSimEN.zxShareId = objRow[convzx_PaperSim.zxShareId] == DBNull.Value ? null : objRow[convzx_PaperSim.zxShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objvzx_PaperSimEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_PaperSim.IsPublic].ToString().Trim()); //是否公开(字段类型:bit,字段长度:1,是否可空:True)
 objvzx_PaperSimEN.VersionCount = objRow[convzx_PaperSim.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objvzx_PaperSimEN.StuScore = objRow[convzx_PaperSim.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_PaperSim.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objvzx_PaperSimEN.TeaScore = objRow[convzx_PaperSim.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_PaperSim.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objvzx_PaperSimEN.Score = objRow[convzx_PaperSim.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_PaperSim.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvzx_PaperSimEN.AppraiseCount = objRow[convzx_PaperSim.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_PaperSimEN.DownloadCount = objRow[convzx_PaperSim.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.DownloadCount].ToString().Trim()); //下载数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_PaperSimEN.CollectionCount = objRow[convzx_PaperSim.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvzx_PaperSimEN.VoteCount = objRow[convzx_PaperSim.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.VoteCount].ToString().Trim()); //点赞计数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_PaperSimEN.VCount = objRow[convzx_PaperSim.VCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.VCount].ToString().Trim()); //VCount(字段类型:int,字段长度:4,是否可空:True)
 objvzx_PaperSimEN.LiteratureLink = objRow[convzx_PaperSim.LiteratureLink] == DBNull.Value ? null : objRow[convzx_PaperSim.LiteratureLink].ToString().Trim(); //文献链接(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_PaperSimEN.UploadfileUrl = objRow[convzx_PaperSim.UploadfileUrl] == DBNull.Value ? null : objRow[convzx_PaperSim.UploadfileUrl].ToString().Trim(); //文件地址(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_PaperSimEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_PaperSim.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvzx_PaperSimEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convzx_PaperSim.IsChecked].ToString().Trim()); //是否检查(字段类型:bit,字段长度:1,是否可空:True)
 objvzx_PaperSimEN.BrowseNumber = objRow[convzx_PaperSim.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.BrowseNumber].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvzx_PaperSimEN.AttachmentCount = objRow[convzx_PaperSim.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.AttachmentCount].ToString().Trim()); //附件计数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_PaperSimEN.UpdUser = objRow[convzx_PaperSim.UpdUser] == DBNull.Value ? null : objRow[convzx_PaperSim.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_PaperSimEN.CreateDate = objRow[convzx_PaperSim.CreateDate] == DBNull.Value ? null : objRow[convzx_PaperSim.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_PaperSimEN.Checker = objRow[convzx_PaperSim.Checker] == DBNull.Value ? null : objRow[convzx_PaperSim.Checker].ToString().Trim(); //审核人(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_PaperSimEN.IdCurrEduCls = objRow[convzx_PaperSim.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_PaperSim.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvzx_PaperSimEN.Keyword = objRow[convzx_PaperSim.Keyword] == DBNull.Value ? null : objRow[convzx_PaperSim.Keyword].ToString().Trim(); //关键字(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_PaperSimEN.LiteratureSources = objRow[convzx_PaperSim.LiteratureSources] == DBNull.Value ? null : objRow[convzx_PaperSim.LiteratureSources].ToString().Trim(); //文献来源(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_PaperSimEN.TextTypeId = objRow[convzx_PaperSim.TextTypeId] == DBNull.Value ? null : objRow[convzx_PaperSim.TextTypeId].ToString().Trim(); //TextTypeId(字段类型:char,字段长度:2,是否可空:True)
 objvzx_PaperSimEN.TextStatusId = objRow[convzx_PaperSim.TextStatusId] == DBNull.Value ? null : objRow[convzx_PaperSim.TextStatusId].ToString().Trim(); //TextStatusId(字段类型:char,字段长度:2,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvzx_PaperSimDA: GetObjByTextId)", objException.Message));
}
return objvzx_PaperSimEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvzx_PaperSimEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvzx_PaperSimDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_PaperSimDA.GetSpecSQLObj();
strSQL = "Select * from vzx_PaperSim where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvzx_PaperSimEN objvzx_PaperSimEN = new clsvzx_PaperSimEN()
{
EduClsName = objRow[convzx_PaperSim.EduClsName] == DBNull.Value ? null : objRow[convzx_PaperSim.EduClsName].ToString().Trim(), //教学班名
CollegeName = objRow[convzx_PaperSim.CollegeName] == DBNull.Value ? null : objRow[convzx_PaperSim.CollegeName].ToString().Trim(), //学院名称
MajorName = objRow[convzx_PaperSim.MajorName] == DBNull.Value ? null : objRow[convzx_PaperSim.MajorName].ToString().Trim(), //专业名称
IdXzMajor = objRow[convzx_PaperSim.IdXzMajor] == DBNull.Value ? null : objRow[convzx_PaperSim.IdXzMajor].ToString().Trim(), //专业流水号
IdXzCollege = objRow[convzx_PaperSim.IdXzCollege] == DBNull.Value ? null : objRow[convzx_PaperSim.IdXzCollege].ToString().Trim(), //学院流水号
IsGSuser = TransNullToBool(objRow[convzx_PaperSim.IsGSuser].ToString().Trim()), //是否GS用户
UserName = objRow[convzx_PaperSim.UserName] == DBNull.Value ? null : objRow[convzx_PaperSim.UserName].ToString().Trim(), //用户名
TextId = objRow[convzx_PaperSim.TextId].ToString().Trim(), //课件Id
TextTitle = objRow[convzx_PaperSim.TextTitle].ToString().Trim(), //TextTitle
TextContent = objRow[convzx_PaperSim.TextContent] == DBNull.Value ? null : objRow[convzx_PaperSim.TextContent].ToString().Trim(), //TextContent
Edition = objRow[convzx_PaperSim.Edition] == DBNull.Value ? null : objRow[convzx_PaperSim.Edition].ToString().Trim(), //Edition
Author = objRow[convzx_PaperSim.Author] == DBNull.Value ? null : objRow[convzx_PaperSim.Author].ToString().Trim(), //作者
ResearchQuestion = objRow[convzx_PaperSim.ResearchQuestion] == DBNull.Value ? null : objRow[convzx_PaperSim.ResearchQuestion].ToString().Trim(), //研究问题
UpdDate = objRow[convzx_PaperSim.UpdDate] == DBNull.Value ? null : objRow[convzx_PaperSim.UpdDate].ToString().Trim(), //修改日期
TeaQCount = objRow[convzx_PaperSim.TeaQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperSim.TeaQCount].ToString().Trim()), //教师提问数
TagsCount = objRow[convzx_PaperSim.TagsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperSim.TagsCount].ToString().Trim()), //论文标注数
SubVCount = objRow[convzx_PaperSim.SubVCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperSim.SubVCount].ToString().Trim()), //论文子观点数
PaperQCount = objRow[convzx_PaperSim.PaperQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperSim.PaperQCount].ToString().Trim()), //论文答疑数
Memo = objRow[convzx_PaperSim.Memo] == DBNull.Value ? null : objRow[convzx_PaperSim.Memo].ToString().Trim(), //备注
GradeId = objRow[convzx_PaperSim.GradeId] == DBNull.Value ? null : objRow[convzx_PaperSim.GradeId].ToString().Trim(), //年级代号
SchoolTerm = objRow[convzx_PaperSim.SchoolTerm] == DBNull.Value ? null : objRow[convzx_PaperSim.SchoolTerm].ToString().Trim(), //学期
UnitId = objRow[convzx_PaperSim.UnitId] == DBNull.Value ? null : objRow[convzx_PaperSim.UnitId].ToString().Trim(), //UnitId
zxShareId = objRow[convzx_PaperSim.zxShareId] == DBNull.Value ? null : objRow[convzx_PaperSim.zxShareId].ToString().Trim(), //分享Id
IsPublic = TransNullToBool(objRow[convzx_PaperSim.IsPublic].ToString().Trim()), //是否公开
VersionCount = objRow[convzx_PaperSim.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperSim.VersionCount].ToString().Trim()), //版本统计
StuScore = objRow[convzx_PaperSim.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_PaperSim.StuScore].ToString().Trim()), //学生平均分
TeaScore = objRow[convzx_PaperSim.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_PaperSim.TeaScore].ToString().Trim()), //教师评分
Score = objRow[convzx_PaperSim.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_PaperSim.Score].ToString().Trim()), //评分
AppraiseCount = objRow[convzx_PaperSim.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperSim.AppraiseCount].ToString().Trim()), //评论数
DownloadCount = objRow[convzx_PaperSim.DownloadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperSim.DownloadCount].ToString().Trim()), //下载数
CollectionCount = objRow[convzx_PaperSim.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convzx_PaperSim.CollectionCount].ToString().Trim()), //收藏数量
VoteCount = objRow[convzx_PaperSim.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperSim.VoteCount].ToString().Trim()), //点赞计数
VCount = objRow[convzx_PaperSim.VCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperSim.VCount].ToString().Trim()), //VCount
LiteratureLink = objRow[convzx_PaperSim.LiteratureLink] == DBNull.Value ? null : objRow[convzx_PaperSim.LiteratureLink].ToString().Trim(), //文献链接
UploadfileUrl = objRow[convzx_PaperSim.UploadfileUrl] == DBNull.Value ? null : objRow[convzx_PaperSim.UploadfileUrl].ToString().Trim(), //文件地址
IsSubmit = TransNullToBool(objRow[convzx_PaperSim.IsSubmit].ToString().Trim()), //是否提交
IsChecked = TransNullToBool(objRow[convzx_PaperSim.IsChecked].ToString().Trim()), //是否检查
BrowseNumber = objRow[convzx_PaperSim.BrowseNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperSim.BrowseNumber].ToString().Trim()), //浏览量
AttachmentCount = objRow[convzx_PaperSim.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperSim.AttachmentCount].ToString().Trim()), //附件计数
UpdUser = objRow[convzx_PaperSim.UpdUser] == DBNull.Value ? null : objRow[convzx_PaperSim.UpdUser].ToString().Trim(), //修改人
CreateDate = objRow[convzx_PaperSim.CreateDate] == DBNull.Value ? null : objRow[convzx_PaperSim.CreateDate].ToString().Trim(), //建立日期
Checker = objRow[convzx_PaperSim.Checker] == DBNull.Value ? null : objRow[convzx_PaperSim.Checker].ToString().Trim(), //审核人
IdCurrEduCls = objRow[convzx_PaperSim.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_PaperSim.IdCurrEduCls].ToString().Trim(), //教学班流水号
Keyword = objRow[convzx_PaperSim.Keyword] == DBNull.Value ? null : objRow[convzx_PaperSim.Keyword].ToString().Trim(), //关键字
LiteratureSources = objRow[convzx_PaperSim.LiteratureSources] == DBNull.Value ? null : objRow[convzx_PaperSim.LiteratureSources].ToString().Trim(), //文献来源
TextTypeId = objRow[convzx_PaperSim.TextTypeId] == DBNull.Value ? null : objRow[convzx_PaperSim.TextTypeId].ToString().Trim(), //TextTypeId
TextStatusId = objRow[convzx_PaperSim.TextStatusId] == DBNull.Value ? null : objRow[convzx_PaperSim.TextStatusId].ToString().Trim() //TextStatusId
};
objvzx_PaperSimEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvzx_PaperSimEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvzx_PaperSimDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvzx_PaperSimEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvzx_PaperSimEN objvzx_PaperSimEN = new clsvzx_PaperSimEN();
try
{
objvzx_PaperSimEN.EduClsName = objRow[convzx_PaperSim.EduClsName] == DBNull.Value ? null : objRow[convzx_PaperSim.EduClsName].ToString().Trim(); //教学班名
objvzx_PaperSimEN.CollegeName = objRow[convzx_PaperSim.CollegeName] == DBNull.Value ? null : objRow[convzx_PaperSim.CollegeName].ToString().Trim(); //学院名称
objvzx_PaperSimEN.MajorName = objRow[convzx_PaperSim.MajorName] == DBNull.Value ? null : objRow[convzx_PaperSim.MajorName].ToString().Trim(); //专业名称
objvzx_PaperSimEN.IdXzMajor = objRow[convzx_PaperSim.IdXzMajor] == DBNull.Value ? null : objRow[convzx_PaperSim.IdXzMajor].ToString().Trim(); //专业流水号
objvzx_PaperSimEN.IdXzCollege = objRow[convzx_PaperSim.IdXzCollege] == DBNull.Value ? null : objRow[convzx_PaperSim.IdXzCollege].ToString().Trim(); //学院流水号
objvzx_PaperSimEN.IsGSuser = TransNullToBool(objRow[convzx_PaperSim.IsGSuser].ToString().Trim()); //是否GS用户
objvzx_PaperSimEN.UserName = objRow[convzx_PaperSim.UserName] == DBNull.Value ? null : objRow[convzx_PaperSim.UserName].ToString().Trim(); //用户名
objvzx_PaperSimEN.TextId = objRow[convzx_PaperSim.TextId].ToString().Trim(); //课件Id
objvzx_PaperSimEN.TextTitle = objRow[convzx_PaperSim.TextTitle].ToString().Trim(); //TextTitle
objvzx_PaperSimEN.TextContent = objRow[convzx_PaperSim.TextContent] == DBNull.Value ? null : objRow[convzx_PaperSim.TextContent].ToString().Trim(); //TextContent
objvzx_PaperSimEN.Edition = objRow[convzx_PaperSim.Edition] == DBNull.Value ? null : objRow[convzx_PaperSim.Edition].ToString().Trim(); //Edition
objvzx_PaperSimEN.Author = objRow[convzx_PaperSim.Author] == DBNull.Value ? null : objRow[convzx_PaperSim.Author].ToString().Trim(); //作者
objvzx_PaperSimEN.ResearchQuestion = objRow[convzx_PaperSim.ResearchQuestion] == DBNull.Value ? null : objRow[convzx_PaperSim.ResearchQuestion].ToString().Trim(); //研究问题
objvzx_PaperSimEN.UpdDate = objRow[convzx_PaperSim.UpdDate] == DBNull.Value ? null : objRow[convzx_PaperSim.UpdDate].ToString().Trim(); //修改日期
objvzx_PaperSimEN.TeaQCount = objRow[convzx_PaperSim.TeaQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperSim.TeaQCount].ToString().Trim()); //教师提问数
objvzx_PaperSimEN.TagsCount = objRow[convzx_PaperSim.TagsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperSim.TagsCount].ToString().Trim()); //论文标注数
objvzx_PaperSimEN.SubVCount = objRow[convzx_PaperSim.SubVCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperSim.SubVCount].ToString().Trim()); //论文子观点数
objvzx_PaperSimEN.PaperQCount = objRow[convzx_PaperSim.PaperQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperSim.PaperQCount].ToString().Trim()); //论文答疑数
objvzx_PaperSimEN.Memo = objRow[convzx_PaperSim.Memo] == DBNull.Value ? null : objRow[convzx_PaperSim.Memo].ToString().Trim(); //备注
objvzx_PaperSimEN.GradeId = objRow[convzx_PaperSim.GradeId] == DBNull.Value ? null : objRow[convzx_PaperSim.GradeId].ToString().Trim(); //年级代号
objvzx_PaperSimEN.SchoolTerm = objRow[convzx_PaperSim.SchoolTerm] == DBNull.Value ? null : objRow[convzx_PaperSim.SchoolTerm].ToString().Trim(); //学期
objvzx_PaperSimEN.UnitId = objRow[convzx_PaperSim.UnitId] == DBNull.Value ? null : objRow[convzx_PaperSim.UnitId].ToString().Trim(); //UnitId
objvzx_PaperSimEN.zxShareId = objRow[convzx_PaperSim.zxShareId] == DBNull.Value ? null : objRow[convzx_PaperSim.zxShareId].ToString().Trim(); //分享Id
objvzx_PaperSimEN.IsPublic = TransNullToBool(objRow[convzx_PaperSim.IsPublic].ToString().Trim()); //是否公开
objvzx_PaperSimEN.VersionCount = objRow[convzx_PaperSim.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperSim.VersionCount].ToString().Trim()); //版本统计
objvzx_PaperSimEN.StuScore = objRow[convzx_PaperSim.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_PaperSim.StuScore].ToString().Trim()); //学生平均分
objvzx_PaperSimEN.TeaScore = objRow[convzx_PaperSim.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_PaperSim.TeaScore].ToString().Trim()); //教师评分
objvzx_PaperSimEN.Score = objRow[convzx_PaperSim.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_PaperSim.Score].ToString().Trim()); //评分
objvzx_PaperSimEN.AppraiseCount = objRow[convzx_PaperSim.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperSim.AppraiseCount].ToString().Trim()); //评论数
objvzx_PaperSimEN.DownloadCount = objRow[convzx_PaperSim.DownloadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperSim.DownloadCount].ToString().Trim()); //下载数
objvzx_PaperSimEN.CollectionCount = objRow[convzx_PaperSim.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convzx_PaperSim.CollectionCount].ToString().Trim()); //收藏数量
objvzx_PaperSimEN.VoteCount = objRow[convzx_PaperSim.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperSim.VoteCount].ToString().Trim()); //点赞计数
objvzx_PaperSimEN.VCount = objRow[convzx_PaperSim.VCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperSim.VCount].ToString().Trim()); //VCount
objvzx_PaperSimEN.LiteratureLink = objRow[convzx_PaperSim.LiteratureLink] == DBNull.Value ? null : objRow[convzx_PaperSim.LiteratureLink].ToString().Trim(); //文献链接
objvzx_PaperSimEN.UploadfileUrl = objRow[convzx_PaperSim.UploadfileUrl] == DBNull.Value ? null : objRow[convzx_PaperSim.UploadfileUrl].ToString().Trim(); //文件地址
objvzx_PaperSimEN.IsSubmit = TransNullToBool(objRow[convzx_PaperSim.IsSubmit].ToString().Trim()); //是否提交
objvzx_PaperSimEN.IsChecked = TransNullToBool(objRow[convzx_PaperSim.IsChecked].ToString().Trim()); //是否检查
objvzx_PaperSimEN.BrowseNumber = objRow[convzx_PaperSim.BrowseNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperSim.BrowseNumber].ToString().Trim()); //浏览量
objvzx_PaperSimEN.AttachmentCount = objRow[convzx_PaperSim.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperSim.AttachmentCount].ToString().Trim()); //附件计数
objvzx_PaperSimEN.UpdUser = objRow[convzx_PaperSim.UpdUser] == DBNull.Value ? null : objRow[convzx_PaperSim.UpdUser].ToString().Trim(); //修改人
objvzx_PaperSimEN.CreateDate = objRow[convzx_PaperSim.CreateDate] == DBNull.Value ? null : objRow[convzx_PaperSim.CreateDate].ToString().Trim(); //建立日期
objvzx_PaperSimEN.Checker = objRow[convzx_PaperSim.Checker] == DBNull.Value ? null : objRow[convzx_PaperSim.Checker].ToString().Trim(); //审核人
objvzx_PaperSimEN.IdCurrEduCls = objRow[convzx_PaperSim.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_PaperSim.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_PaperSimEN.Keyword = objRow[convzx_PaperSim.Keyword] == DBNull.Value ? null : objRow[convzx_PaperSim.Keyword].ToString().Trim(); //关键字
objvzx_PaperSimEN.LiteratureSources = objRow[convzx_PaperSim.LiteratureSources] == DBNull.Value ? null : objRow[convzx_PaperSim.LiteratureSources].ToString().Trim(); //文献来源
objvzx_PaperSimEN.TextTypeId = objRow[convzx_PaperSim.TextTypeId] == DBNull.Value ? null : objRow[convzx_PaperSim.TextTypeId].ToString().Trim(); //TextTypeId
objvzx_PaperSimEN.TextStatusId = objRow[convzx_PaperSim.TextStatusId] == DBNull.Value ? null : objRow[convzx_PaperSim.TextStatusId].ToString().Trim(); //TextStatusId
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvzx_PaperSimDA: GetObjByDataRowvzx_PaperSim)", objException.Message));
}
objvzx_PaperSimEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvzx_PaperSimEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvzx_PaperSimEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvzx_PaperSimEN objvzx_PaperSimEN = new clsvzx_PaperSimEN();
try
{
objvzx_PaperSimEN.EduClsName = objRow[convzx_PaperSim.EduClsName] == DBNull.Value ? null : objRow[convzx_PaperSim.EduClsName].ToString().Trim(); //教学班名
objvzx_PaperSimEN.CollegeName = objRow[convzx_PaperSim.CollegeName] == DBNull.Value ? null : objRow[convzx_PaperSim.CollegeName].ToString().Trim(); //学院名称
objvzx_PaperSimEN.MajorName = objRow[convzx_PaperSim.MajorName] == DBNull.Value ? null : objRow[convzx_PaperSim.MajorName].ToString().Trim(); //专业名称
objvzx_PaperSimEN.IdXzMajor = objRow[convzx_PaperSim.IdXzMajor] == DBNull.Value ? null : objRow[convzx_PaperSim.IdXzMajor].ToString().Trim(); //专业流水号
objvzx_PaperSimEN.IdXzCollege = objRow[convzx_PaperSim.IdXzCollege] == DBNull.Value ? null : objRow[convzx_PaperSim.IdXzCollege].ToString().Trim(); //学院流水号
objvzx_PaperSimEN.IsGSuser = TransNullToBool(objRow[convzx_PaperSim.IsGSuser].ToString().Trim()); //是否GS用户
objvzx_PaperSimEN.UserName = objRow[convzx_PaperSim.UserName] == DBNull.Value ? null : objRow[convzx_PaperSim.UserName].ToString().Trim(); //用户名
objvzx_PaperSimEN.TextId = objRow[convzx_PaperSim.TextId].ToString().Trim(); //课件Id
objvzx_PaperSimEN.TextTitle = objRow[convzx_PaperSim.TextTitle].ToString().Trim(); //TextTitle
objvzx_PaperSimEN.TextContent = objRow[convzx_PaperSim.TextContent] == DBNull.Value ? null : objRow[convzx_PaperSim.TextContent].ToString().Trim(); //TextContent
objvzx_PaperSimEN.Edition = objRow[convzx_PaperSim.Edition] == DBNull.Value ? null : objRow[convzx_PaperSim.Edition].ToString().Trim(); //Edition
objvzx_PaperSimEN.Author = objRow[convzx_PaperSim.Author] == DBNull.Value ? null : objRow[convzx_PaperSim.Author].ToString().Trim(); //作者
objvzx_PaperSimEN.ResearchQuestion = objRow[convzx_PaperSim.ResearchQuestion] == DBNull.Value ? null : objRow[convzx_PaperSim.ResearchQuestion].ToString().Trim(); //研究问题
objvzx_PaperSimEN.UpdDate = objRow[convzx_PaperSim.UpdDate] == DBNull.Value ? null : objRow[convzx_PaperSim.UpdDate].ToString().Trim(); //修改日期
objvzx_PaperSimEN.TeaQCount = objRow[convzx_PaperSim.TeaQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperSim.TeaQCount].ToString().Trim()); //教师提问数
objvzx_PaperSimEN.TagsCount = objRow[convzx_PaperSim.TagsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperSim.TagsCount].ToString().Trim()); //论文标注数
objvzx_PaperSimEN.SubVCount = objRow[convzx_PaperSim.SubVCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperSim.SubVCount].ToString().Trim()); //论文子观点数
objvzx_PaperSimEN.PaperQCount = objRow[convzx_PaperSim.PaperQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperSim.PaperQCount].ToString().Trim()); //论文答疑数
objvzx_PaperSimEN.Memo = objRow[convzx_PaperSim.Memo] == DBNull.Value ? null : objRow[convzx_PaperSim.Memo].ToString().Trim(); //备注
objvzx_PaperSimEN.GradeId = objRow[convzx_PaperSim.GradeId] == DBNull.Value ? null : objRow[convzx_PaperSim.GradeId].ToString().Trim(); //年级代号
objvzx_PaperSimEN.SchoolTerm = objRow[convzx_PaperSim.SchoolTerm] == DBNull.Value ? null : objRow[convzx_PaperSim.SchoolTerm].ToString().Trim(); //学期
objvzx_PaperSimEN.UnitId = objRow[convzx_PaperSim.UnitId] == DBNull.Value ? null : objRow[convzx_PaperSim.UnitId].ToString().Trim(); //UnitId
objvzx_PaperSimEN.zxShareId = objRow[convzx_PaperSim.zxShareId] == DBNull.Value ? null : objRow[convzx_PaperSim.zxShareId].ToString().Trim(); //分享Id
objvzx_PaperSimEN.IsPublic = TransNullToBool(objRow[convzx_PaperSim.IsPublic].ToString().Trim()); //是否公开
objvzx_PaperSimEN.VersionCount = objRow[convzx_PaperSim.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperSim.VersionCount].ToString().Trim()); //版本统计
objvzx_PaperSimEN.StuScore = objRow[convzx_PaperSim.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_PaperSim.StuScore].ToString().Trim()); //学生平均分
objvzx_PaperSimEN.TeaScore = objRow[convzx_PaperSim.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_PaperSim.TeaScore].ToString().Trim()); //教师评分
objvzx_PaperSimEN.Score = objRow[convzx_PaperSim.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_PaperSim.Score].ToString().Trim()); //评分
objvzx_PaperSimEN.AppraiseCount = objRow[convzx_PaperSim.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperSim.AppraiseCount].ToString().Trim()); //评论数
objvzx_PaperSimEN.DownloadCount = objRow[convzx_PaperSim.DownloadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperSim.DownloadCount].ToString().Trim()); //下载数
objvzx_PaperSimEN.CollectionCount = objRow[convzx_PaperSim.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convzx_PaperSim.CollectionCount].ToString().Trim()); //收藏数量
objvzx_PaperSimEN.VoteCount = objRow[convzx_PaperSim.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperSim.VoteCount].ToString().Trim()); //点赞计数
objvzx_PaperSimEN.VCount = objRow[convzx_PaperSim.VCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperSim.VCount].ToString().Trim()); //VCount
objvzx_PaperSimEN.LiteratureLink = objRow[convzx_PaperSim.LiteratureLink] == DBNull.Value ? null : objRow[convzx_PaperSim.LiteratureLink].ToString().Trim(); //文献链接
objvzx_PaperSimEN.UploadfileUrl = objRow[convzx_PaperSim.UploadfileUrl] == DBNull.Value ? null : objRow[convzx_PaperSim.UploadfileUrl].ToString().Trim(); //文件地址
objvzx_PaperSimEN.IsSubmit = TransNullToBool(objRow[convzx_PaperSim.IsSubmit].ToString().Trim()); //是否提交
objvzx_PaperSimEN.IsChecked = TransNullToBool(objRow[convzx_PaperSim.IsChecked].ToString().Trim()); //是否检查
objvzx_PaperSimEN.BrowseNumber = objRow[convzx_PaperSim.BrowseNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperSim.BrowseNumber].ToString().Trim()); //浏览量
objvzx_PaperSimEN.AttachmentCount = objRow[convzx_PaperSim.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_PaperSim.AttachmentCount].ToString().Trim()); //附件计数
objvzx_PaperSimEN.UpdUser = objRow[convzx_PaperSim.UpdUser] == DBNull.Value ? null : objRow[convzx_PaperSim.UpdUser].ToString().Trim(); //修改人
objvzx_PaperSimEN.CreateDate = objRow[convzx_PaperSim.CreateDate] == DBNull.Value ? null : objRow[convzx_PaperSim.CreateDate].ToString().Trim(); //建立日期
objvzx_PaperSimEN.Checker = objRow[convzx_PaperSim.Checker] == DBNull.Value ? null : objRow[convzx_PaperSim.Checker].ToString().Trim(); //审核人
objvzx_PaperSimEN.IdCurrEduCls = objRow[convzx_PaperSim.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_PaperSim.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_PaperSimEN.Keyword = objRow[convzx_PaperSim.Keyword] == DBNull.Value ? null : objRow[convzx_PaperSim.Keyword].ToString().Trim(); //关键字
objvzx_PaperSimEN.LiteratureSources = objRow[convzx_PaperSim.LiteratureSources] == DBNull.Value ? null : objRow[convzx_PaperSim.LiteratureSources].ToString().Trim(); //文献来源
objvzx_PaperSimEN.TextTypeId = objRow[convzx_PaperSim.TextTypeId] == DBNull.Value ? null : objRow[convzx_PaperSim.TextTypeId].ToString().Trim(); //TextTypeId
objvzx_PaperSimEN.TextStatusId = objRow[convzx_PaperSim.TextStatusId] == DBNull.Value ? null : objRow[convzx_PaperSim.TextStatusId].ToString().Trim(); //TextStatusId
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvzx_PaperSimDA: GetObjByDataRow)", objException.Message));
}
objvzx_PaperSimEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvzx_PaperSimEN;
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
objSQL = clsvzx_PaperSimDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvzx_PaperSimEN._CurrTabName, convzx_PaperSim.TextId, 8, "");
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
objSQL = clsvzx_PaperSimDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvzx_PaperSimEN._CurrTabName, convzx_PaperSim.TextId, 8, strPrefix);
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
 objSQL = clsvzx_PaperSimDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select TextId from vzx_PaperSim where " + strCondition;
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
 objSQL = clsvzx_PaperSimDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select TextId from vzx_PaperSim where " + strCondition;
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
 /// <param name = "strTextId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strTextId)
{
CheckPrimaryKey(strTextId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_PaperSimDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vzx_PaperSim", "TextId = " + "'"+ strTextId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvzx_PaperSimDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_PaperSimDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vzx_PaperSim", strCondition))
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
objSQL = clsvzx_PaperSimDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vzx_PaperSim");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvzx_PaperSimENS">源对象</param>
 /// <param name = "objvzx_PaperSimENT">目标对象</param>
public void CopyTo(clsvzx_PaperSimEN objvzx_PaperSimENS, clsvzx_PaperSimEN objvzx_PaperSimENT)
{
objvzx_PaperSimENT.EduClsName = objvzx_PaperSimENS.EduClsName; //教学班名
objvzx_PaperSimENT.CollegeName = objvzx_PaperSimENS.CollegeName; //学院名称
objvzx_PaperSimENT.MajorName = objvzx_PaperSimENS.MajorName; //专业名称
objvzx_PaperSimENT.IdXzMajor = objvzx_PaperSimENS.IdXzMajor; //专业流水号
objvzx_PaperSimENT.IdXzCollege = objvzx_PaperSimENS.IdXzCollege; //学院流水号
objvzx_PaperSimENT.IsGSuser = objvzx_PaperSimENS.IsGSuser; //是否GS用户
objvzx_PaperSimENT.UserName = objvzx_PaperSimENS.UserName; //用户名
objvzx_PaperSimENT.TextId = objvzx_PaperSimENS.TextId; //课件Id
objvzx_PaperSimENT.TextTitle = objvzx_PaperSimENS.TextTitle; //TextTitle
objvzx_PaperSimENT.TextContent = objvzx_PaperSimENS.TextContent; //TextContent
objvzx_PaperSimENT.Edition = objvzx_PaperSimENS.Edition; //Edition
objvzx_PaperSimENT.Author = objvzx_PaperSimENS.Author; //作者
objvzx_PaperSimENT.ResearchQuestion = objvzx_PaperSimENS.ResearchQuestion; //研究问题
objvzx_PaperSimENT.UpdDate = objvzx_PaperSimENS.UpdDate; //修改日期
objvzx_PaperSimENT.TeaQCount = objvzx_PaperSimENS.TeaQCount; //教师提问数
objvzx_PaperSimENT.TagsCount = objvzx_PaperSimENS.TagsCount; //论文标注数
objvzx_PaperSimENT.SubVCount = objvzx_PaperSimENS.SubVCount; //论文子观点数
objvzx_PaperSimENT.PaperQCount = objvzx_PaperSimENS.PaperQCount; //论文答疑数
objvzx_PaperSimENT.Memo = objvzx_PaperSimENS.Memo; //备注
objvzx_PaperSimENT.GradeId = objvzx_PaperSimENS.GradeId; //年级代号
objvzx_PaperSimENT.SchoolTerm = objvzx_PaperSimENS.SchoolTerm; //学期
objvzx_PaperSimENT.UnitId = objvzx_PaperSimENS.UnitId; //UnitId
objvzx_PaperSimENT.zxShareId = objvzx_PaperSimENS.zxShareId; //分享Id
objvzx_PaperSimENT.IsPublic = objvzx_PaperSimENS.IsPublic; //是否公开
objvzx_PaperSimENT.VersionCount = objvzx_PaperSimENS.VersionCount; //版本统计
objvzx_PaperSimENT.StuScore = objvzx_PaperSimENS.StuScore; //学生平均分
objvzx_PaperSimENT.TeaScore = objvzx_PaperSimENS.TeaScore; //教师评分
objvzx_PaperSimENT.Score = objvzx_PaperSimENS.Score; //评分
objvzx_PaperSimENT.AppraiseCount = objvzx_PaperSimENS.AppraiseCount; //评论数
objvzx_PaperSimENT.DownloadCount = objvzx_PaperSimENS.DownloadCount; //下载数
objvzx_PaperSimENT.CollectionCount = objvzx_PaperSimENS.CollectionCount; //收藏数量
objvzx_PaperSimENT.VoteCount = objvzx_PaperSimENS.VoteCount; //点赞计数
objvzx_PaperSimENT.VCount = objvzx_PaperSimENS.VCount; //VCount
objvzx_PaperSimENT.LiteratureLink = objvzx_PaperSimENS.LiteratureLink; //文献链接
objvzx_PaperSimENT.UploadfileUrl = objvzx_PaperSimENS.UploadfileUrl; //文件地址
objvzx_PaperSimENT.IsSubmit = objvzx_PaperSimENS.IsSubmit; //是否提交
objvzx_PaperSimENT.IsChecked = objvzx_PaperSimENS.IsChecked; //是否检查
objvzx_PaperSimENT.BrowseNumber = objvzx_PaperSimENS.BrowseNumber; //浏览量
objvzx_PaperSimENT.AttachmentCount = objvzx_PaperSimENS.AttachmentCount; //附件计数
objvzx_PaperSimENT.UpdUser = objvzx_PaperSimENS.UpdUser; //修改人
objvzx_PaperSimENT.CreateDate = objvzx_PaperSimENS.CreateDate; //建立日期
objvzx_PaperSimENT.Checker = objvzx_PaperSimENS.Checker; //审核人
objvzx_PaperSimENT.IdCurrEduCls = objvzx_PaperSimENS.IdCurrEduCls; //教学班流水号
objvzx_PaperSimENT.Keyword = objvzx_PaperSimENS.Keyword; //关键字
objvzx_PaperSimENT.LiteratureSources = objvzx_PaperSimENS.LiteratureSources; //文献来源
objvzx_PaperSimENT.TextTypeId = objvzx_PaperSimENS.TextTypeId; //TextTypeId
objvzx_PaperSimENT.TextStatusId = objvzx_PaperSimENS.TextStatusId; //TextStatusId
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvzx_PaperSimEN objvzx_PaperSimEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvzx_PaperSimEN.EduClsName, 100, convzx_PaperSim.EduClsName);
clsCheckSql.CheckFieldLen(objvzx_PaperSimEN.CollegeName, 100, convzx_PaperSim.CollegeName);
clsCheckSql.CheckFieldLen(objvzx_PaperSimEN.MajorName, 100, convzx_PaperSim.MajorName);
clsCheckSql.CheckFieldLen(objvzx_PaperSimEN.IdXzMajor, 8, convzx_PaperSim.IdXzMajor);
clsCheckSql.CheckFieldLen(objvzx_PaperSimEN.IdXzCollege, 4, convzx_PaperSim.IdXzCollege);
clsCheckSql.CheckFieldLen(objvzx_PaperSimEN.UserName, 30, convzx_PaperSim.UserName);
clsCheckSql.CheckFieldLen(objvzx_PaperSimEN.TextId, 8, convzx_PaperSim.TextId);
clsCheckSql.CheckFieldLen(objvzx_PaperSimEN.TextTitle, 500, convzx_PaperSim.TextTitle);
clsCheckSql.CheckFieldLen(objvzx_PaperSimEN.Edition, 100, convzx_PaperSim.Edition);
clsCheckSql.CheckFieldLen(objvzx_PaperSimEN.Author, 200, convzx_PaperSim.Author);
clsCheckSql.CheckFieldLen(objvzx_PaperSimEN.ResearchQuestion, 2000, convzx_PaperSim.ResearchQuestion);
clsCheckSql.CheckFieldLen(objvzx_PaperSimEN.UpdDate, 20, convzx_PaperSim.UpdDate);
clsCheckSql.CheckFieldLen(objvzx_PaperSimEN.Memo, 1000, convzx_PaperSim.Memo);
clsCheckSql.CheckFieldLen(objvzx_PaperSimEN.GradeId, 4, convzx_PaperSim.GradeId);
clsCheckSql.CheckFieldLen(objvzx_PaperSimEN.SchoolTerm, 1, convzx_PaperSim.SchoolTerm);
clsCheckSql.CheckFieldLen(objvzx_PaperSimEN.UnitId, 4, convzx_PaperSim.UnitId);
clsCheckSql.CheckFieldLen(objvzx_PaperSimEN.zxShareId, 2, convzx_PaperSim.zxShareId);
clsCheckSql.CheckFieldLen(objvzx_PaperSimEN.LiteratureLink, 1000, convzx_PaperSim.LiteratureLink);
clsCheckSql.CheckFieldLen(objvzx_PaperSimEN.UploadfileUrl, 1000, convzx_PaperSim.UploadfileUrl);
clsCheckSql.CheckFieldLen(objvzx_PaperSimEN.UpdUser, 20, convzx_PaperSim.UpdUser);
clsCheckSql.CheckFieldLen(objvzx_PaperSimEN.CreateDate, 20, convzx_PaperSim.CreateDate);
clsCheckSql.CheckFieldLen(objvzx_PaperSimEN.Checker, 20, convzx_PaperSim.Checker);
clsCheckSql.CheckFieldLen(objvzx_PaperSimEN.IdCurrEduCls, 8, convzx_PaperSim.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objvzx_PaperSimEN.Keyword, 1000, convzx_PaperSim.Keyword);
clsCheckSql.CheckFieldLen(objvzx_PaperSimEN.LiteratureSources, 1000, convzx_PaperSim.LiteratureSources);
clsCheckSql.CheckFieldLen(objvzx_PaperSimEN.TextTypeId, 2, convzx_PaperSim.TextTypeId);
clsCheckSql.CheckFieldLen(objvzx_PaperSimEN.TextStatusId, 2, convzx_PaperSim.TextStatusId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvzx_PaperSimEN.EduClsName, convzx_PaperSim.EduClsName);
clsCheckSql.CheckSqlInjection4Field(objvzx_PaperSimEN.CollegeName, convzx_PaperSim.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvzx_PaperSimEN.MajorName, convzx_PaperSim.MajorName);
clsCheckSql.CheckSqlInjection4Field(objvzx_PaperSimEN.IdXzMajor, convzx_PaperSim.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objvzx_PaperSimEN.IdXzCollege, convzx_PaperSim.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvzx_PaperSimEN.UserName, convzx_PaperSim.UserName);
clsCheckSql.CheckSqlInjection4Field(objvzx_PaperSimEN.TextId, convzx_PaperSim.TextId);
clsCheckSql.CheckSqlInjection4Field(objvzx_PaperSimEN.TextTitle, convzx_PaperSim.TextTitle);
clsCheckSql.CheckSqlInjection4Field(objvzx_PaperSimEN.Edition, convzx_PaperSim.Edition);
clsCheckSql.CheckSqlInjection4Field(objvzx_PaperSimEN.Author, convzx_PaperSim.Author);
clsCheckSql.CheckSqlInjection4Field(objvzx_PaperSimEN.ResearchQuestion, convzx_PaperSim.ResearchQuestion);
clsCheckSql.CheckSqlInjection4Field(objvzx_PaperSimEN.UpdDate, convzx_PaperSim.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvzx_PaperSimEN.Memo, convzx_PaperSim.Memo);
clsCheckSql.CheckSqlInjection4Field(objvzx_PaperSimEN.GradeId, convzx_PaperSim.GradeId);
clsCheckSql.CheckSqlInjection4Field(objvzx_PaperSimEN.SchoolTerm, convzx_PaperSim.SchoolTerm);
clsCheckSql.CheckSqlInjection4Field(objvzx_PaperSimEN.UnitId, convzx_PaperSim.UnitId);
clsCheckSql.CheckSqlInjection4Field(objvzx_PaperSimEN.zxShareId, convzx_PaperSim.zxShareId);
clsCheckSql.CheckSqlInjection4Field(objvzx_PaperSimEN.LiteratureLink, convzx_PaperSim.LiteratureLink);
clsCheckSql.CheckSqlInjection4Field(objvzx_PaperSimEN.UploadfileUrl, convzx_PaperSim.UploadfileUrl);
clsCheckSql.CheckSqlInjection4Field(objvzx_PaperSimEN.UpdUser, convzx_PaperSim.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvzx_PaperSimEN.CreateDate, convzx_PaperSim.CreateDate);
clsCheckSql.CheckSqlInjection4Field(objvzx_PaperSimEN.Checker, convzx_PaperSim.Checker);
clsCheckSql.CheckSqlInjection4Field(objvzx_PaperSimEN.IdCurrEduCls, convzx_PaperSim.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objvzx_PaperSimEN.Keyword, convzx_PaperSim.Keyword);
clsCheckSql.CheckSqlInjection4Field(objvzx_PaperSimEN.LiteratureSources, convzx_PaperSim.LiteratureSources);
clsCheckSql.CheckSqlInjection4Field(objvzx_PaperSimEN.TextTypeId, convzx_PaperSim.TextTypeId);
clsCheckSql.CheckSqlInjection4Field(objvzx_PaperSimEN.TextStatusId, convzx_PaperSim.TextStatusId);
//检查外键字段长度
 objvzx_PaperSimEN._IsCheckProperty = true;
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
 objSQL = clsvzx_PaperSimDA.GetSpecSQLObj();
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
 objSQL = clsvzx_PaperSimDA.GetSpecSQLObj();
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
 objSQL = clsvzx_PaperSimDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvzx_PaperSimEN._CurrTabName);
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
 objSQL = clsvzx_PaperSimDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvzx_PaperSimEN._CurrTabName, strCondition);
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
 objSQL = clsvzx_PaperSimDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}