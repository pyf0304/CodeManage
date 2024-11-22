
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvXzMajorDirectionDA
 表名:vXzMajorDirection(01120553)
 * 版本:2023.10.12.1(服务器:WIN-SRV103-116)
 日期:2023/10/28 09:46:00
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:基本信息维护(BaseInfo)
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
 /// v专业方向(vXzMajorDirection)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvXzMajorDirectionDA : clsCommBase4DA
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
 return clsvXzMajorDirectionEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvXzMajorDirectionEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvXzMajorDirectionEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvXzMajorDirectionEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvXzMajorDirectionEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strMajorDirectionId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strMajorDirectionId)
{
strMajorDirectionId = strMajorDirectionId.Replace("'", "''");
if (strMajorDirectionId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vXzMajorDirection中,检查关键字,长度不正确!(clsvXzMajorDirectionDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strMajorDirectionId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vXzMajorDirection中,关键字不能为空 或 null!(clsvXzMajorDirectionDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strMajorDirectionId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvXzMajorDirectionDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvXzMajorDirectionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzMajorDirectionDA.GetSpecSQLObj();
strSQL = "Select * from vXzMajorDirection where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vXzMajorDirection(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvXzMajorDirectionDA: GetDataTable_vXzMajorDirection)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzMajorDirectionDA.GetSpecSQLObj();
strSQL = "Select * from vXzMajorDirection where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvXzMajorDirectionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzMajorDirectionDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvXzMajorDirectionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzMajorDirectionDA.GetSpecSQLObj();
strSQL = "Select * from vXzMajorDirection where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvXzMajorDirectionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzMajorDirectionDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvXzMajorDirectionDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzMajorDirectionDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vXzMajorDirection where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vXzMajorDirection where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvXzMajorDirectionDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzMajorDirectionDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vXzMajorDirection where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvXzMajorDirectionDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzMajorDirectionDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vXzMajorDirection.* from vXzMajorDirection Left Join {1} on {2} where {3} and vXzMajorDirection.MajorDirectionId not in (Select top {5} vXzMajorDirection.MajorDirectionId from vXzMajorDirection Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vXzMajorDirection where {1} and MajorDirectionId not in (Select top {2} MajorDirectionId from vXzMajorDirection where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vXzMajorDirection where {1} and MajorDirectionId not in (Select top {3} MajorDirectionId from vXzMajorDirection where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvXzMajorDirectionDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzMajorDirectionDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vXzMajorDirection.* from vXzMajorDirection Left Join {1} on {2} where {3} and vXzMajorDirection.MajorDirectionId not in (Select top {5} vXzMajorDirection.MajorDirectionId from vXzMajorDirection Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vXzMajorDirection where {1} and MajorDirectionId not in (Select top {2} MajorDirectionId from vXzMajorDirection where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vXzMajorDirection where {1} and MajorDirectionId not in (Select top {3} MajorDirectionId from vXzMajorDirection where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvXzMajorDirectionEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvXzMajorDirectionDA:GetObjLst)", objException.Message));
}
List<clsvXzMajorDirectionEN> arrObjLst = new List<clsvXzMajorDirectionEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzMajorDirectionDA.GetSpecSQLObj();
strSQL = "Select * from vXzMajorDirection where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzMajorDirectionEN objvXzMajorDirectionEN = new clsvXzMajorDirectionEN();
try
{
objvXzMajorDirectionEN.MajorDirectionId = objRow[convXzMajorDirection.MajorDirectionId].ToString().Trim(); //研究方向Id
objvXzMajorDirectionEN.IdXzMajor = objRow[convXzMajorDirection.IdXzMajor].ToString().Trim(); //专业流水号
objvXzMajorDirectionEN.MajorID = objRow[convXzMajorDirection.MajorID].ToString().Trim(); //专业ID
objvXzMajorDirectionEN.MajorName = objRow[convXzMajorDirection.MajorName].ToString().Trim(); //专业名称
objvXzMajorDirectionEN.MajorDirectionName = objRow[convXzMajorDirection.MajorDirectionName].ToString().Trim(); //研究方向名
objvXzMajorDirectionEN.MajorDirectionENName = objRow[convXzMajorDirection.MajorDirectionENName] == DBNull.Value ? null : objRow[convXzMajorDirection.MajorDirectionENName].ToString().Trim(); //研究方向英文名
objvXzMajorDirectionEN.MajorDirectionExplain = objRow[convXzMajorDirection.MajorDirectionExplain] == DBNull.Value ? null : objRow[convXzMajorDirection.MajorDirectionExplain].ToString().Trim(); //专业方向说明
objvXzMajorDirectionEN.IsVisible = TransNullToBool(objRow[convXzMajorDirection.IsVisible].ToString().Trim()); //是否显示
objvXzMajorDirectionEN.UpdDate = objRow[convXzMajorDirection.UpdDate] == DBNull.Value ? null : objRow[convXzMajorDirection.UpdDate].ToString().Trim(); //修改日期
objvXzMajorDirectionEN.UpdUser = objRow[convXzMajorDirection.UpdUser].ToString().Trim(); //修改人
objvXzMajorDirectionEN.Memo = objRow[convXzMajorDirection.Memo] == DBNull.Value ? null : objRow[convXzMajorDirection.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvXzMajorDirectionDA: GetObjLst)", objException.Message));
}
objvXzMajorDirectionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvXzMajorDirectionEN);
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
public List<clsvXzMajorDirectionEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvXzMajorDirectionDA:GetObjLstByTabName)", objException.Message));
}
List<clsvXzMajorDirectionEN> arrObjLst = new List<clsvXzMajorDirectionEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzMajorDirectionDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzMajorDirectionEN objvXzMajorDirectionEN = new clsvXzMajorDirectionEN();
try
{
objvXzMajorDirectionEN.MajorDirectionId = objRow[convXzMajorDirection.MajorDirectionId].ToString().Trim(); //研究方向Id
objvXzMajorDirectionEN.IdXzMajor = objRow[convXzMajorDirection.IdXzMajor].ToString().Trim(); //专业流水号
objvXzMajorDirectionEN.MajorID = objRow[convXzMajorDirection.MajorID].ToString().Trim(); //专业ID
objvXzMajorDirectionEN.MajorName = objRow[convXzMajorDirection.MajorName].ToString().Trim(); //专业名称
objvXzMajorDirectionEN.MajorDirectionName = objRow[convXzMajorDirection.MajorDirectionName].ToString().Trim(); //研究方向名
objvXzMajorDirectionEN.MajorDirectionENName = objRow[convXzMajorDirection.MajorDirectionENName] == DBNull.Value ? null : objRow[convXzMajorDirection.MajorDirectionENName].ToString().Trim(); //研究方向英文名
objvXzMajorDirectionEN.MajorDirectionExplain = objRow[convXzMajorDirection.MajorDirectionExplain] == DBNull.Value ? null : objRow[convXzMajorDirection.MajorDirectionExplain].ToString().Trim(); //专业方向说明
objvXzMajorDirectionEN.IsVisible = TransNullToBool(objRow[convXzMajorDirection.IsVisible].ToString().Trim()); //是否显示
objvXzMajorDirectionEN.UpdDate = objRow[convXzMajorDirection.UpdDate] == DBNull.Value ? null : objRow[convXzMajorDirection.UpdDate].ToString().Trim(); //修改日期
objvXzMajorDirectionEN.UpdUser = objRow[convXzMajorDirection.UpdUser].ToString().Trim(); //修改人
objvXzMajorDirectionEN.Memo = objRow[convXzMajorDirection.Memo] == DBNull.Value ? null : objRow[convXzMajorDirection.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvXzMajorDirectionDA: GetObjLst)", objException.Message));
}
objvXzMajorDirectionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvXzMajorDirectionEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvXzMajorDirectionEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvXzMajorDirection(ref clsvXzMajorDirectionEN objvXzMajorDirectionEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzMajorDirectionDA.GetSpecSQLObj();
strSQL = "Select * from vXzMajorDirection where MajorDirectionId = " + "'"+ objvXzMajorDirectionEN.MajorDirectionId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvXzMajorDirectionEN.MajorDirectionId = objDT.Rows[0][convXzMajorDirection.MajorDirectionId].ToString().Trim(); //研究方向Id(字段类型:char,字段长度:8,是否可空:True)
 objvXzMajorDirectionEN.IdXzMajor = objDT.Rows[0][convXzMajorDirection.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvXzMajorDirectionEN.MajorID = objDT.Rows[0][convXzMajorDirection.MajorID].ToString().Trim(); //专业ID(字段类型:char,字段长度:4,是否可空:False)
 objvXzMajorDirectionEN.MajorName = objDT.Rows[0][convXzMajorDirection.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvXzMajorDirectionEN.MajorDirectionName = objDT.Rows[0][convXzMajorDirection.MajorDirectionName].ToString().Trim(); //研究方向名(字段类型:varchar,字段长度:100,是否可空:False)
 objvXzMajorDirectionEN.MajorDirectionENName = objDT.Rows[0][convXzMajorDirection.MajorDirectionENName].ToString().Trim(); //研究方向英文名(字段类型:varchar,字段长度:200,是否可空:True)
 objvXzMajorDirectionEN.MajorDirectionExplain = objDT.Rows[0][convXzMajorDirection.MajorDirectionExplain].ToString().Trim(); //专业方向说明(字段类型:varchar,字段长度:2000,是否可空:True)
 objvXzMajorDirectionEN.IsVisible = TransNullToBool(objDT.Rows[0][convXzMajorDirection.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvXzMajorDirectionEN.UpdDate = objDT.Rows[0][convXzMajorDirection.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvXzMajorDirectionEN.UpdUser = objDT.Rows[0][convXzMajorDirection.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvXzMajorDirectionEN.Memo = objDT.Rows[0][convXzMajorDirection.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvXzMajorDirectionDA: GetvXzMajorDirection)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strMajorDirectionId">表关键字</param>
 /// <returns>表对象</returns>
public clsvXzMajorDirectionEN GetObjByMajorDirectionId(string strMajorDirectionId)
{
CheckPrimaryKey(strMajorDirectionId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzMajorDirectionDA.GetSpecSQLObj();
strSQL = "Select * from vXzMajorDirection where MajorDirectionId = " + "'"+ strMajorDirectionId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvXzMajorDirectionEN objvXzMajorDirectionEN = new clsvXzMajorDirectionEN();
try
{
 objvXzMajorDirectionEN.MajorDirectionId = objRow[convXzMajorDirection.MajorDirectionId].ToString().Trim(); //研究方向Id(字段类型:char,字段长度:8,是否可空:True)
 objvXzMajorDirectionEN.IdXzMajor = objRow[convXzMajorDirection.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvXzMajorDirectionEN.MajorID = objRow[convXzMajorDirection.MajorID].ToString().Trim(); //专业ID(字段类型:char,字段长度:4,是否可空:False)
 objvXzMajorDirectionEN.MajorName = objRow[convXzMajorDirection.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvXzMajorDirectionEN.MajorDirectionName = objRow[convXzMajorDirection.MajorDirectionName].ToString().Trim(); //研究方向名(字段类型:varchar,字段长度:100,是否可空:False)
 objvXzMajorDirectionEN.MajorDirectionENName = objRow[convXzMajorDirection.MajorDirectionENName] == DBNull.Value ? null : objRow[convXzMajorDirection.MajorDirectionENName].ToString().Trim(); //研究方向英文名(字段类型:varchar,字段长度:200,是否可空:True)
 objvXzMajorDirectionEN.MajorDirectionExplain = objRow[convXzMajorDirection.MajorDirectionExplain] == DBNull.Value ? null : objRow[convXzMajorDirection.MajorDirectionExplain].ToString().Trim(); //专业方向说明(字段类型:varchar,字段长度:2000,是否可空:True)
 objvXzMajorDirectionEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convXzMajorDirection.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvXzMajorDirectionEN.UpdDate = objRow[convXzMajorDirection.UpdDate] == DBNull.Value ? null : objRow[convXzMajorDirection.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvXzMajorDirectionEN.UpdUser = objRow[convXzMajorDirection.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvXzMajorDirectionEN.Memo = objRow[convXzMajorDirection.Memo] == DBNull.Value ? null : objRow[convXzMajorDirection.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvXzMajorDirectionDA: GetObjByMajorDirectionId)", objException.Message));
}
return objvXzMajorDirectionEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvXzMajorDirectionEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvXzMajorDirectionDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzMajorDirectionDA.GetSpecSQLObj();
strSQL = "Select * from vXzMajorDirection where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvXzMajorDirectionEN objvXzMajorDirectionEN = new clsvXzMajorDirectionEN()
{
MajorDirectionId = objRow[convXzMajorDirection.MajorDirectionId].ToString().Trim(), //研究方向Id
IdXzMajor = objRow[convXzMajorDirection.IdXzMajor].ToString().Trim(), //专业流水号
MajorID = objRow[convXzMajorDirection.MajorID].ToString().Trim(), //专业ID
MajorName = objRow[convXzMajorDirection.MajorName].ToString().Trim(), //专业名称
MajorDirectionName = objRow[convXzMajorDirection.MajorDirectionName].ToString().Trim(), //研究方向名
MajorDirectionENName = objRow[convXzMajorDirection.MajorDirectionENName] == DBNull.Value ? null : objRow[convXzMajorDirection.MajorDirectionENName].ToString().Trim(), //研究方向英文名
MajorDirectionExplain = objRow[convXzMajorDirection.MajorDirectionExplain] == DBNull.Value ? null : objRow[convXzMajorDirection.MajorDirectionExplain].ToString().Trim(), //专业方向说明
IsVisible = TransNullToBool(objRow[convXzMajorDirection.IsVisible].ToString().Trim()), //是否显示
UpdDate = objRow[convXzMajorDirection.UpdDate] == DBNull.Value ? null : objRow[convXzMajorDirection.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convXzMajorDirection.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convXzMajorDirection.Memo] == DBNull.Value ? null : objRow[convXzMajorDirection.Memo].ToString().Trim() //备注
};
objvXzMajorDirectionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvXzMajorDirectionEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvXzMajorDirectionDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvXzMajorDirectionEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvXzMajorDirectionEN objvXzMajorDirectionEN = new clsvXzMajorDirectionEN();
try
{
objvXzMajorDirectionEN.MajorDirectionId = objRow[convXzMajorDirection.MajorDirectionId].ToString().Trim(); //研究方向Id
objvXzMajorDirectionEN.IdXzMajor = objRow[convXzMajorDirection.IdXzMajor].ToString().Trim(); //专业流水号
objvXzMajorDirectionEN.MajorID = objRow[convXzMajorDirection.MajorID].ToString().Trim(); //专业ID
objvXzMajorDirectionEN.MajorName = objRow[convXzMajorDirection.MajorName].ToString().Trim(); //专业名称
objvXzMajorDirectionEN.MajorDirectionName = objRow[convXzMajorDirection.MajorDirectionName].ToString().Trim(); //研究方向名
objvXzMajorDirectionEN.MajorDirectionENName = objRow[convXzMajorDirection.MajorDirectionENName] == DBNull.Value ? null : objRow[convXzMajorDirection.MajorDirectionENName].ToString().Trim(); //研究方向英文名
objvXzMajorDirectionEN.MajorDirectionExplain = objRow[convXzMajorDirection.MajorDirectionExplain] == DBNull.Value ? null : objRow[convXzMajorDirection.MajorDirectionExplain].ToString().Trim(); //专业方向说明
objvXzMajorDirectionEN.IsVisible = TransNullToBool(objRow[convXzMajorDirection.IsVisible].ToString().Trim()); //是否显示
objvXzMajorDirectionEN.UpdDate = objRow[convXzMajorDirection.UpdDate] == DBNull.Value ? null : objRow[convXzMajorDirection.UpdDate].ToString().Trim(); //修改日期
objvXzMajorDirectionEN.UpdUser = objRow[convXzMajorDirection.UpdUser].ToString().Trim(); //修改人
objvXzMajorDirectionEN.Memo = objRow[convXzMajorDirection.Memo] == DBNull.Value ? null : objRow[convXzMajorDirection.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvXzMajorDirectionDA: GetObjByDataRowvXzMajorDirection)", objException.Message));
}
objvXzMajorDirectionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvXzMajorDirectionEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvXzMajorDirectionEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvXzMajorDirectionEN objvXzMajorDirectionEN = new clsvXzMajorDirectionEN();
try
{
objvXzMajorDirectionEN.MajorDirectionId = objRow[convXzMajorDirection.MajorDirectionId].ToString().Trim(); //研究方向Id
objvXzMajorDirectionEN.IdXzMajor = objRow[convXzMajorDirection.IdXzMajor].ToString().Trim(); //专业流水号
objvXzMajorDirectionEN.MajorID = objRow[convXzMajorDirection.MajorID].ToString().Trim(); //专业ID
objvXzMajorDirectionEN.MajorName = objRow[convXzMajorDirection.MajorName].ToString().Trim(); //专业名称
objvXzMajorDirectionEN.MajorDirectionName = objRow[convXzMajorDirection.MajorDirectionName].ToString().Trim(); //研究方向名
objvXzMajorDirectionEN.MajorDirectionENName = objRow[convXzMajorDirection.MajorDirectionENName] == DBNull.Value ? null : objRow[convXzMajorDirection.MajorDirectionENName].ToString().Trim(); //研究方向英文名
objvXzMajorDirectionEN.MajorDirectionExplain = objRow[convXzMajorDirection.MajorDirectionExplain] == DBNull.Value ? null : objRow[convXzMajorDirection.MajorDirectionExplain].ToString().Trim(); //专业方向说明
objvXzMajorDirectionEN.IsVisible = TransNullToBool(objRow[convXzMajorDirection.IsVisible].ToString().Trim()); //是否显示
objvXzMajorDirectionEN.UpdDate = objRow[convXzMajorDirection.UpdDate] == DBNull.Value ? null : objRow[convXzMajorDirection.UpdDate].ToString().Trim(); //修改日期
objvXzMajorDirectionEN.UpdUser = objRow[convXzMajorDirection.UpdUser].ToString().Trim(); //修改人
objvXzMajorDirectionEN.Memo = objRow[convXzMajorDirection.Memo] == DBNull.Value ? null : objRow[convXzMajorDirection.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvXzMajorDirectionDA: GetObjByDataRow)", objException.Message));
}
objvXzMajorDirectionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvXzMajorDirectionEN;
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
objSQL = clsvXzMajorDirectionDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvXzMajorDirectionEN._CurrTabName, convXzMajorDirection.MajorDirectionId, 8, "");
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
objSQL = clsvXzMajorDirectionDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvXzMajorDirectionEN._CurrTabName, convXzMajorDirection.MajorDirectionId, 8, strPrefix);
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
 objSQL = clsvXzMajorDirectionDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select MajorDirectionId from vXzMajorDirection where " + strCondition;
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
 objSQL = clsvXzMajorDirectionDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select MajorDirectionId from vXzMajorDirection where " + strCondition;
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
 /// <param name = "strMajorDirectionId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strMajorDirectionId)
{
CheckPrimaryKey(strMajorDirectionId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzMajorDirectionDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vXzMajorDirection", "MajorDirectionId = " + "'"+ strMajorDirectionId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvXzMajorDirectionDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzMajorDirectionDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vXzMajorDirection", strCondition))
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
objSQL = clsvXzMajorDirectionDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vXzMajorDirection");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvXzMajorDirectionENS">源对象</param>
 /// <param name = "objvXzMajorDirectionENT">目标对象</param>
public void CopyTo(clsvXzMajorDirectionEN objvXzMajorDirectionENS, clsvXzMajorDirectionEN objvXzMajorDirectionENT)
{
objvXzMajorDirectionENT.MajorDirectionId = objvXzMajorDirectionENS.MajorDirectionId; //研究方向Id
objvXzMajorDirectionENT.IdXzMajor = objvXzMajorDirectionENS.IdXzMajor; //专业流水号
objvXzMajorDirectionENT.MajorID = objvXzMajorDirectionENS.MajorID; //专业ID
objvXzMajorDirectionENT.MajorName = objvXzMajorDirectionENS.MajorName; //专业名称
objvXzMajorDirectionENT.MajorDirectionName = objvXzMajorDirectionENS.MajorDirectionName; //研究方向名
objvXzMajorDirectionENT.MajorDirectionENName = objvXzMajorDirectionENS.MajorDirectionENName; //研究方向英文名
objvXzMajorDirectionENT.MajorDirectionExplain = objvXzMajorDirectionENS.MajorDirectionExplain; //专业方向说明
objvXzMajorDirectionENT.IsVisible = objvXzMajorDirectionENS.IsVisible; //是否显示
objvXzMajorDirectionENT.UpdDate = objvXzMajorDirectionENS.UpdDate; //修改日期
objvXzMajorDirectionENT.UpdUser = objvXzMajorDirectionENS.UpdUser; //修改人
objvXzMajorDirectionENT.Memo = objvXzMajorDirectionENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvXzMajorDirectionEN objvXzMajorDirectionEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvXzMajorDirectionEN.MajorDirectionId, 8, convXzMajorDirection.MajorDirectionId);
clsCheckSql.CheckFieldLen(objvXzMajorDirectionEN.IdXzMajor, 8, convXzMajorDirection.IdXzMajor);
clsCheckSql.CheckFieldLen(objvXzMajorDirectionEN.MajorID, 4, convXzMajorDirection.MajorID);
clsCheckSql.CheckFieldLen(objvXzMajorDirectionEN.MajorName, 100, convXzMajorDirection.MajorName);
clsCheckSql.CheckFieldLen(objvXzMajorDirectionEN.MajorDirectionName, 100, convXzMajorDirection.MajorDirectionName);
clsCheckSql.CheckFieldLen(objvXzMajorDirectionEN.MajorDirectionENName, 200, convXzMajorDirection.MajorDirectionENName);
clsCheckSql.CheckFieldLen(objvXzMajorDirectionEN.MajorDirectionExplain, 2000, convXzMajorDirection.MajorDirectionExplain);
clsCheckSql.CheckFieldLen(objvXzMajorDirectionEN.UpdDate, 20, convXzMajorDirection.UpdDate);
clsCheckSql.CheckFieldLen(objvXzMajorDirectionEN.UpdUser, 20, convXzMajorDirection.UpdUser);
clsCheckSql.CheckFieldLen(objvXzMajorDirectionEN.Memo, 1000, convXzMajorDirection.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvXzMajorDirectionEN.MajorDirectionId, convXzMajorDirection.MajorDirectionId);
clsCheckSql.CheckSqlInjection4Field(objvXzMajorDirectionEN.IdXzMajor, convXzMajorDirection.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objvXzMajorDirectionEN.MajorID, convXzMajorDirection.MajorID);
clsCheckSql.CheckSqlInjection4Field(objvXzMajorDirectionEN.MajorName, convXzMajorDirection.MajorName);
clsCheckSql.CheckSqlInjection4Field(objvXzMajorDirectionEN.MajorDirectionName, convXzMajorDirection.MajorDirectionName);
clsCheckSql.CheckSqlInjection4Field(objvXzMajorDirectionEN.MajorDirectionENName, convXzMajorDirection.MajorDirectionENName);
clsCheckSql.CheckSqlInjection4Field(objvXzMajorDirectionEN.MajorDirectionExplain, convXzMajorDirection.MajorDirectionExplain);
clsCheckSql.CheckSqlInjection4Field(objvXzMajorDirectionEN.UpdDate, convXzMajorDirection.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvXzMajorDirectionEN.UpdUser, convXzMajorDirection.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvXzMajorDirectionEN.Memo, convXzMajorDirection.Memo);
//检查外键字段长度
 objvXzMajorDirectionEN._IsCheckProperty = true;
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
 objSQL = clsvXzMajorDirectionDA.GetSpecSQLObj();
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
 objSQL = clsvXzMajorDirectionDA.GetSpecSQLObj();
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
 objSQL = clsvXzMajorDirectionDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvXzMajorDirectionEN._CurrTabName);
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
 objSQL = clsvXzMajorDirectionDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvXzMajorDirectionEN._CurrTabName, strCondition);
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
 objSQL = clsvXzMajorDirectionDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}