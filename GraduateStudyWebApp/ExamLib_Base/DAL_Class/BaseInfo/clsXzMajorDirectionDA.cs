
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsXzMajorDirectionDA
 表名:XzMajorDirection(01120552)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:06:08
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:基本信息维护(BaseInfo)
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
 /// 专业方向(XzMajorDirection)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsXzMajorDirectionDA : clsCommBase4DA
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
 return clsXzMajorDirectionEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsXzMajorDirectionEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsXzMajorDirectionEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsXzMajorDirectionEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsXzMajorDirectionEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:XzMajorDirection中,检查关键字,长度不正确!(clsXzMajorDirectionDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strMajorDirectionId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:XzMajorDirection中,关键字不能为空 或 null!(clsXzMajorDirectionDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strMajorDirectionId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsXzMajorDirectionDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsXzMajorDirectionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzMajorDirectionDA.GetSpecSQLObj();
strSQL = "Select * from XzMajorDirection where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_XzMajorDirection(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsXzMajorDirectionDA: GetDataTable_XzMajorDirection)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzMajorDirectionDA.GetSpecSQLObj();
strSQL = "Select * from XzMajorDirection where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsXzMajorDirectionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzMajorDirectionDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsXzMajorDirectionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzMajorDirectionDA.GetSpecSQLObj();
strSQL = "Select * from XzMajorDirection where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsXzMajorDirectionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzMajorDirectionDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsXzMajorDirectionDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzMajorDirectionDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from XzMajorDirection where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from XzMajorDirection where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsXzMajorDirectionDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzMajorDirectionDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from XzMajorDirection where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsXzMajorDirectionDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzMajorDirectionDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} XzMajorDirection.* from XzMajorDirection Left Join {1} on {2} where {3} and XzMajorDirection.MajorDirectionId not in (Select top {5} XzMajorDirection.MajorDirectionId from XzMajorDirection Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from XzMajorDirection where {1} and MajorDirectionId not in (Select top {2} MajorDirectionId from XzMajorDirection where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from XzMajorDirection where {1} and MajorDirectionId not in (Select top {3} MajorDirectionId from XzMajorDirection where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsXzMajorDirectionDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzMajorDirectionDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} XzMajorDirection.* from XzMajorDirection Left Join {1} on {2} where {3} and XzMajorDirection.MajorDirectionId not in (Select top {5} XzMajorDirection.MajorDirectionId from XzMajorDirection Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from XzMajorDirection where {1} and MajorDirectionId not in (Select top {2} MajorDirectionId from XzMajorDirection where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from XzMajorDirection where {1} and MajorDirectionId not in (Select top {3} MajorDirectionId from XzMajorDirection where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsXzMajorDirectionEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsXzMajorDirectionDA:GetObjLst)", objException.Message));
}
List<clsXzMajorDirectionEN> arrObjLst = new List<clsXzMajorDirectionEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzMajorDirectionDA.GetSpecSQLObj();
strSQL = "Select * from XzMajorDirection where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzMajorDirectionEN objXzMajorDirectionEN = new clsXzMajorDirectionEN();
try
{
objXzMajorDirectionEN.MajorDirectionId = objRow[conXzMajorDirection.MajorDirectionId].ToString().Trim(); //研究方向Id
objXzMajorDirectionEN.IdXzMajor = objRow[conXzMajorDirection.IdXzMajor].ToString().Trim(); //专业流水号
objXzMajorDirectionEN.MajorDirectionName = objRow[conXzMajorDirection.MajorDirectionName].ToString().Trim(); //研究方向名
objXzMajorDirectionEN.MajorDirectionENName = objRow[conXzMajorDirection.MajorDirectionENName] == DBNull.Value ? null : objRow[conXzMajorDirection.MajorDirectionENName].ToString().Trim(); //研究方向英文名
objXzMajorDirectionEN.MajorDirectionExplain = objRow[conXzMajorDirection.MajorDirectionExplain] == DBNull.Value ? null : objRow[conXzMajorDirection.MajorDirectionExplain].ToString().Trim(); //专业方向说明
objXzMajorDirectionEN.IsVisible = TransNullToBool(objRow[conXzMajorDirection.IsVisible].ToString().Trim()); //是否显示
objXzMajorDirectionEN.UpdDate = objRow[conXzMajorDirection.UpdDate] == DBNull.Value ? null : objRow[conXzMajorDirection.UpdDate].ToString().Trim(); //修改日期
objXzMajorDirectionEN.UpdUser = objRow[conXzMajorDirection.UpdUser].ToString().Trim(); //修改人
objXzMajorDirectionEN.Memo = objRow[conXzMajorDirection.Memo] == DBNull.Value ? null : objRow[conXzMajorDirection.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsXzMajorDirectionDA: GetObjLst)", objException.Message));
}
objXzMajorDirectionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objXzMajorDirectionEN);
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
public List<clsXzMajorDirectionEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsXzMajorDirectionDA:GetObjLstByTabName)", objException.Message));
}
List<clsXzMajorDirectionEN> arrObjLst = new List<clsXzMajorDirectionEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzMajorDirectionDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzMajorDirectionEN objXzMajorDirectionEN = new clsXzMajorDirectionEN();
try
{
objXzMajorDirectionEN.MajorDirectionId = objRow[conXzMajorDirection.MajorDirectionId].ToString().Trim(); //研究方向Id
objXzMajorDirectionEN.IdXzMajor = objRow[conXzMajorDirection.IdXzMajor].ToString().Trim(); //专业流水号
objXzMajorDirectionEN.MajorDirectionName = objRow[conXzMajorDirection.MajorDirectionName].ToString().Trim(); //研究方向名
objXzMajorDirectionEN.MajorDirectionENName = objRow[conXzMajorDirection.MajorDirectionENName] == DBNull.Value ? null : objRow[conXzMajorDirection.MajorDirectionENName].ToString().Trim(); //研究方向英文名
objXzMajorDirectionEN.MajorDirectionExplain = objRow[conXzMajorDirection.MajorDirectionExplain] == DBNull.Value ? null : objRow[conXzMajorDirection.MajorDirectionExplain].ToString().Trim(); //专业方向说明
objXzMajorDirectionEN.IsVisible = TransNullToBool(objRow[conXzMajorDirection.IsVisible].ToString().Trim()); //是否显示
objXzMajorDirectionEN.UpdDate = objRow[conXzMajorDirection.UpdDate] == DBNull.Value ? null : objRow[conXzMajorDirection.UpdDate].ToString().Trim(); //修改日期
objXzMajorDirectionEN.UpdUser = objRow[conXzMajorDirection.UpdUser].ToString().Trim(); //修改人
objXzMajorDirectionEN.Memo = objRow[conXzMajorDirection.Memo] == DBNull.Value ? null : objRow[conXzMajorDirection.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsXzMajorDirectionDA: GetObjLst)", objException.Message));
}
objXzMajorDirectionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objXzMajorDirectionEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objXzMajorDirectionEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetXzMajorDirection(ref clsXzMajorDirectionEN objXzMajorDirectionEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzMajorDirectionDA.GetSpecSQLObj();
strSQL = "Select * from XzMajorDirection where MajorDirectionId = " + "'"+ objXzMajorDirectionEN.MajorDirectionId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objXzMajorDirectionEN.MajorDirectionId = objDT.Rows[0][conXzMajorDirection.MajorDirectionId].ToString().Trim(); //研究方向Id(字段类型:char,字段长度:8,是否可空:True)
 objXzMajorDirectionEN.IdXzMajor = objDT.Rows[0][conXzMajorDirection.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objXzMajorDirectionEN.MajorDirectionName = objDT.Rows[0][conXzMajorDirection.MajorDirectionName].ToString().Trim(); //研究方向名(字段类型:varchar,字段长度:100,是否可空:False)
 objXzMajorDirectionEN.MajorDirectionENName = objDT.Rows[0][conXzMajorDirection.MajorDirectionENName].ToString().Trim(); //研究方向英文名(字段类型:varchar,字段长度:200,是否可空:True)
 objXzMajorDirectionEN.MajorDirectionExplain = objDT.Rows[0][conXzMajorDirection.MajorDirectionExplain].ToString().Trim(); //专业方向说明(字段类型:varchar,字段长度:2000,是否可空:True)
 objXzMajorDirectionEN.IsVisible = TransNullToBool(objDT.Rows[0][conXzMajorDirection.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objXzMajorDirectionEN.UpdDate = objDT.Rows[0][conXzMajorDirection.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objXzMajorDirectionEN.UpdUser = objDT.Rows[0][conXzMajorDirection.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objXzMajorDirectionEN.Memo = objDT.Rows[0][conXzMajorDirection.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsXzMajorDirectionDA: GetXzMajorDirection)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strMajorDirectionId">表关键字</param>
 /// <returns>表对象</returns>
public clsXzMajorDirectionEN GetObjByMajorDirectionId(string strMajorDirectionId)
{
CheckPrimaryKey(strMajorDirectionId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzMajorDirectionDA.GetSpecSQLObj();
strSQL = "Select * from XzMajorDirection where MajorDirectionId = " + "'"+ strMajorDirectionId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsXzMajorDirectionEN objXzMajorDirectionEN = new clsXzMajorDirectionEN();
try
{
 objXzMajorDirectionEN.MajorDirectionId = objRow[conXzMajorDirection.MajorDirectionId].ToString().Trim(); //研究方向Id(字段类型:char,字段长度:8,是否可空:True)
 objXzMajorDirectionEN.IdXzMajor = objRow[conXzMajorDirection.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objXzMajorDirectionEN.MajorDirectionName = objRow[conXzMajorDirection.MajorDirectionName].ToString().Trim(); //研究方向名(字段类型:varchar,字段长度:100,是否可空:False)
 objXzMajorDirectionEN.MajorDirectionENName = objRow[conXzMajorDirection.MajorDirectionENName] == DBNull.Value ? null : objRow[conXzMajorDirection.MajorDirectionENName].ToString().Trim(); //研究方向英文名(字段类型:varchar,字段长度:200,是否可空:True)
 objXzMajorDirectionEN.MajorDirectionExplain = objRow[conXzMajorDirection.MajorDirectionExplain] == DBNull.Value ? null : objRow[conXzMajorDirection.MajorDirectionExplain].ToString().Trim(); //专业方向说明(字段类型:varchar,字段长度:2000,是否可空:True)
 objXzMajorDirectionEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conXzMajorDirection.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objXzMajorDirectionEN.UpdDate = objRow[conXzMajorDirection.UpdDate] == DBNull.Value ? null : objRow[conXzMajorDirection.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objXzMajorDirectionEN.UpdUser = objRow[conXzMajorDirection.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objXzMajorDirectionEN.Memo = objRow[conXzMajorDirection.Memo] == DBNull.Value ? null : objRow[conXzMajorDirection.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsXzMajorDirectionDA: GetObjByMajorDirectionId)", objException.Message));
}
return objXzMajorDirectionEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsXzMajorDirectionEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsXzMajorDirectionDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzMajorDirectionDA.GetSpecSQLObj();
strSQL = "Select * from XzMajorDirection where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsXzMajorDirectionEN objXzMajorDirectionEN = new clsXzMajorDirectionEN()
{
MajorDirectionId = objRow[conXzMajorDirection.MajorDirectionId].ToString().Trim(), //研究方向Id
IdXzMajor = objRow[conXzMajorDirection.IdXzMajor].ToString().Trim(), //专业流水号
MajorDirectionName = objRow[conXzMajorDirection.MajorDirectionName].ToString().Trim(), //研究方向名
MajorDirectionENName = objRow[conXzMajorDirection.MajorDirectionENName] == DBNull.Value ? null : objRow[conXzMajorDirection.MajorDirectionENName].ToString().Trim(), //研究方向英文名
MajorDirectionExplain = objRow[conXzMajorDirection.MajorDirectionExplain] == DBNull.Value ? null : objRow[conXzMajorDirection.MajorDirectionExplain].ToString().Trim(), //专业方向说明
IsVisible = TransNullToBool(objRow[conXzMajorDirection.IsVisible].ToString().Trim()), //是否显示
UpdDate = objRow[conXzMajorDirection.UpdDate] == DBNull.Value ? null : objRow[conXzMajorDirection.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conXzMajorDirection.UpdUser].ToString().Trim(), //修改人
Memo = objRow[conXzMajorDirection.Memo] == DBNull.Value ? null : objRow[conXzMajorDirection.Memo].ToString().Trim() //备注
};
objXzMajorDirectionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objXzMajorDirectionEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsXzMajorDirectionDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsXzMajorDirectionEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsXzMajorDirectionEN objXzMajorDirectionEN = new clsXzMajorDirectionEN();
try
{
objXzMajorDirectionEN.MajorDirectionId = objRow[conXzMajorDirection.MajorDirectionId].ToString().Trim(); //研究方向Id
objXzMajorDirectionEN.IdXzMajor = objRow[conXzMajorDirection.IdXzMajor].ToString().Trim(); //专业流水号
objXzMajorDirectionEN.MajorDirectionName = objRow[conXzMajorDirection.MajorDirectionName].ToString().Trim(); //研究方向名
objXzMajorDirectionEN.MajorDirectionENName = objRow[conXzMajorDirection.MajorDirectionENName] == DBNull.Value ? null : objRow[conXzMajorDirection.MajorDirectionENName].ToString().Trim(); //研究方向英文名
objXzMajorDirectionEN.MajorDirectionExplain = objRow[conXzMajorDirection.MajorDirectionExplain] == DBNull.Value ? null : objRow[conXzMajorDirection.MajorDirectionExplain].ToString().Trim(); //专业方向说明
objXzMajorDirectionEN.IsVisible = TransNullToBool(objRow[conXzMajorDirection.IsVisible].ToString().Trim()); //是否显示
objXzMajorDirectionEN.UpdDate = objRow[conXzMajorDirection.UpdDate] == DBNull.Value ? null : objRow[conXzMajorDirection.UpdDate].ToString().Trim(); //修改日期
objXzMajorDirectionEN.UpdUser = objRow[conXzMajorDirection.UpdUser].ToString().Trim(); //修改人
objXzMajorDirectionEN.Memo = objRow[conXzMajorDirection.Memo] == DBNull.Value ? null : objRow[conXzMajorDirection.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsXzMajorDirectionDA: GetObjByDataRowXzMajorDirection)", objException.Message));
}
objXzMajorDirectionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objXzMajorDirectionEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsXzMajorDirectionEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsXzMajorDirectionEN objXzMajorDirectionEN = new clsXzMajorDirectionEN();
try
{
objXzMajorDirectionEN.MajorDirectionId = objRow[conXzMajorDirection.MajorDirectionId].ToString().Trim(); //研究方向Id
objXzMajorDirectionEN.IdXzMajor = objRow[conXzMajorDirection.IdXzMajor].ToString().Trim(); //专业流水号
objXzMajorDirectionEN.MajorDirectionName = objRow[conXzMajorDirection.MajorDirectionName].ToString().Trim(); //研究方向名
objXzMajorDirectionEN.MajorDirectionENName = objRow[conXzMajorDirection.MajorDirectionENName] == DBNull.Value ? null : objRow[conXzMajorDirection.MajorDirectionENName].ToString().Trim(); //研究方向英文名
objXzMajorDirectionEN.MajorDirectionExplain = objRow[conXzMajorDirection.MajorDirectionExplain] == DBNull.Value ? null : objRow[conXzMajorDirection.MajorDirectionExplain].ToString().Trim(); //专业方向说明
objXzMajorDirectionEN.IsVisible = TransNullToBool(objRow[conXzMajorDirection.IsVisible].ToString().Trim()); //是否显示
objXzMajorDirectionEN.UpdDate = objRow[conXzMajorDirection.UpdDate] == DBNull.Value ? null : objRow[conXzMajorDirection.UpdDate].ToString().Trim(); //修改日期
objXzMajorDirectionEN.UpdUser = objRow[conXzMajorDirection.UpdUser].ToString().Trim(); //修改人
objXzMajorDirectionEN.Memo = objRow[conXzMajorDirection.Memo] == DBNull.Value ? null : objRow[conXzMajorDirection.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsXzMajorDirectionDA: GetObjByDataRow)", objException.Message));
}
objXzMajorDirectionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objXzMajorDirectionEN;
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
objSQL = clsXzMajorDirectionDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsXzMajorDirectionEN._CurrTabName, conXzMajorDirection.MajorDirectionId, 8, "");
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
objSQL = clsXzMajorDirectionDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsXzMajorDirectionEN._CurrTabName, conXzMajorDirection.MajorDirectionId, 8, strPrefix);
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
 objSQL = clsXzMajorDirectionDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select MajorDirectionId from XzMajorDirection where " + strCondition;
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
 objSQL = clsXzMajorDirectionDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select MajorDirectionId from XzMajorDirection where " + strCondition;
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
 objSQL = clsXzMajorDirectionDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("XzMajorDirection", "MajorDirectionId = " + "'"+ strMajorDirectionId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsXzMajorDirectionDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzMajorDirectionDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("XzMajorDirection", strCondition))
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
objSQL = clsXzMajorDirectionDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("XzMajorDirection");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsXzMajorDirectionEN objXzMajorDirectionEN)
 {
 objXzMajorDirectionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objXzMajorDirectionEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objXzMajorDirectionEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzMajorDirectionDA.GetSpecSQLObj();
strSQL = "Select * from XzMajorDirection where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "XzMajorDirection");
objRow = objDS.Tables["XzMajorDirection"].NewRow();
objRow[conXzMajorDirection.MajorDirectionId] = objXzMajorDirectionEN.MajorDirectionId; //研究方向Id
objRow[conXzMajorDirection.IdXzMajor] = objXzMajorDirectionEN.IdXzMajor; //专业流水号
objRow[conXzMajorDirection.MajorDirectionName] = objXzMajorDirectionEN.MajorDirectionName; //研究方向名
 if (objXzMajorDirectionEN.MajorDirectionENName !=  "")
 {
objRow[conXzMajorDirection.MajorDirectionENName] = objXzMajorDirectionEN.MajorDirectionENName; //研究方向英文名
 }
 if (objXzMajorDirectionEN.MajorDirectionExplain !=  "")
 {
objRow[conXzMajorDirection.MajorDirectionExplain] = objXzMajorDirectionEN.MajorDirectionExplain; //专业方向说明
 }
objRow[conXzMajorDirection.IsVisible] = objXzMajorDirectionEN.IsVisible; //是否显示
 if (objXzMajorDirectionEN.UpdDate !=  "")
 {
objRow[conXzMajorDirection.UpdDate] = objXzMajorDirectionEN.UpdDate; //修改日期
 }
objRow[conXzMajorDirection.UpdUser] = objXzMajorDirectionEN.UpdUser; //修改人
 if (objXzMajorDirectionEN.Memo !=  "")
 {
objRow[conXzMajorDirection.Memo] = objXzMajorDirectionEN.Memo; //备注
 }
objDS.Tables[clsXzMajorDirectionEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsXzMajorDirectionEN._CurrTabName);
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
 /// <param name = "objXzMajorDirectionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsXzMajorDirectionEN objXzMajorDirectionEN)
{
 objXzMajorDirectionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objXzMajorDirectionEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objXzMajorDirectionEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objXzMajorDirectionEN.MajorDirectionId !=  null)
 {
 arrFieldListForInsert.Add(conXzMajorDirection.MajorDirectionId);
 var strMajorDirectionId = objXzMajorDirectionEN.MajorDirectionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMajorDirectionId + "'");
 }
 
 if (objXzMajorDirectionEN.IdXzMajor !=  null)
 {
 arrFieldListForInsert.Add(conXzMajorDirection.IdXzMajor);
 var strIdXzMajor = objXzMajorDirectionEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzMajor + "'");
 }
 
 if (objXzMajorDirectionEN.MajorDirectionName !=  null)
 {
 arrFieldListForInsert.Add(conXzMajorDirection.MajorDirectionName);
 var strMajorDirectionName = objXzMajorDirectionEN.MajorDirectionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMajorDirectionName + "'");
 }
 
 if (objXzMajorDirectionEN.MajorDirectionENName !=  null)
 {
 arrFieldListForInsert.Add(conXzMajorDirection.MajorDirectionENName);
 var strMajorDirectionENName = objXzMajorDirectionEN.MajorDirectionENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMajorDirectionENName + "'");
 }
 
 if (objXzMajorDirectionEN.MajorDirectionExplain !=  null)
 {
 arrFieldListForInsert.Add(conXzMajorDirection.MajorDirectionExplain);
 var strMajorDirectionExplain = objXzMajorDirectionEN.MajorDirectionExplain.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMajorDirectionExplain + "'");
 }
 
 arrFieldListForInsert.Add(conXzMajorDirection.IsVisible);
 arrValueListForInsert.Add("'" + (objXzMajorDirectionEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objXzMajorDirectionEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conXzMajorDirection.UpdDate);
 var strUpdDate = objXzMajorDirectionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objXzMajorDirectionEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conXzMajorDirection.UpdUser);
 var strUpdUser = objXzMajorDirectionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objXzMajorDirectionEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conXzMajorDirection.Memo);
 var strMemo = objXzMajorDirectionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into XzMajorDirection");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzMajorDirectionDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objXzMajorDirectionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsXzMajorDirectionEN objXzMajorDirectionEN)
{
 objXzMajorDirectionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objXzMajorDirectionEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objXzMajorDirectionEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objXzMajorDirectionEN.MajorDirectionId !=  null)
 {
 arrFieldListForInsert.Add(conXzMajorDirection.MajorDirectionId);
 var strMajorDirectionId = objXzMajorDirectionEN.MajorDirectionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMajorDirectionId + "'");
 }
 
 if (objXzMajorDirectionEN.IdXzMajor !=  null)
 {
 arrFieldListForInsert.Add(conXzMajorDirection.IdXzMajor);
 var strIdXzMajor = objXzMajorDirectionEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzMajor + "'");
 }
 
 if (objXzMajorDirectionEN.MajorDirectionName !=  null)
 {
 arrFieldListForInsert.Add(conXzMajorDirection.MajorDirectionName);
 var strMajorDirectionName = objXzMajorDirectionEN.MajorDirectionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMajorDirectionName + "'");
 }
 
 if (objXzMajorDirectionEN.MajorDirectionENName !=  null)
 {
 arrFieldListForInsert.Add(conXzMajorDirection.MajorDirectionENName);
 var strMajorDirectionENName = objXzMajorDirectionEN.MajorDirectionENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMajorDirectionENName + "'");
 }
 
 if (objXzMajorDirectionEN.MajorDirectionExplain !=  null)
 {
 arrFieldListForInsert.Add(conXzMajorDirection.MajorDirectionExplain);
 var strMajorDirectionExplain = objXzMajorDirectionEN.MajorDirectionExplain.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMajorDirectionExplain + "'");
 }
 
 arrFieldListForInsert.Add(conXzMajorDirection.IsVisible);
 arrValueListForInsert.Add("'" + (objXzMajorDirectionEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objXzMajorDirectionEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conXzMajorDirection.UpdDate);
 var strUpdDate = objXzMajorDirectionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objXzMajorDirectionEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conXzMajorDirection.UpdUser);
 var strUpdUser = objXzMajorDirectionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objXzMajorDirectionEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conXzMajorDirection.Memo);
 var strMemo = objXzMajorDirectionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into XzMajorDirection");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzMajorDirectionDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objXzMajorDirectionEN.MajorDirectionId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objXzMajorDirectionEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsXzMajorDirectionEN objXzMajorDirectionEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objXzMajorDirectionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objXzMajorDirectionEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objXzMajorDirectionEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objXzMajorDirectionEN.MajorDirectionId !=  null)
 {
 arrFieldListForInsert.Add(conXzMajorDirection.MajorDirectionId);
 var strMajorDirectionId = objXzMajorDirectionEN.MajorDirectionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMajorDirectionId + "'");
 }
 
 if (objXzMajorDirectionEN.IdXzMajor !=  null)
 {
 arrFieldListForInsert.Add(conXzMajorDirection.IdXzMajor);
 var strIdXzMajor = objXzMajorDirectionEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzMajor + "'");
 }
 
 if (objXzMajorDirectionEN.MajorDirectionName !=  null)
 {
 arrFieldListForInsert.Add(conXzMajorDirection.MajorDirectionName);
 var strMajorDirectionName = objXzMajorDirectionEN.MajorDirectionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMajorDirectionName + "'");
 }
 
 if (objXzMajorDirectionEN.MajorDirectionENName !=  null)
 {
 arrFieldListForInsert.Add(conXzMajorDirection.MajorDirectionENName);
 var strMajorDirectionENName = objXzMajorDirectionEN.MajorDirectionENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMajorDirectionENName + "'");
 }
 
 if (objXzMajorDirectionEN.MajorDirectionExplain !=  null)
 {
 arrFieldListForInsert.Add(conXzMajorDirection.MajorDirectionExplain);
 var strMajorDirectionExplain = objXzMajorDirectionEN.MajorDirectionExplain.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMajorDirectionExplain + "'");
 }
 
 arrFieldListForInsert.Add(conXzMajorDirection.IsVisible);
 arrValueListForInsert.Add("'" + (objXzMajorDirectionEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objXzMajorDirectionEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conXzMajorDirection.UpdDate);
 var strUpdDate = objXzMajorDirectionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objXzMajorDirectionEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conXzMajorDirection.UpdUser);
 var strUpdUser = objXzMajorDirectionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objXzMajorDirectionEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conXzMajorDirection.Memo);
 var strMemo = objXzMajorDirectionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into XzMajorDirection");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzMajorDirectionDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objXzMajorDirectionEN.MajorDirectionId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objXzMajorDirectionEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsXzMajorDirectionEN objXzMajorDirectionEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objXzMajorDirectionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objXzMajorDirectionEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objXzMajorDirectionEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objXzMajorDirectionEN.MajorDirectionId !=  null)
 {
 arrFieldListForInsert.Add(conXzMajorDirection.MajorDirectionId);
 var strMajorDirectionId = objXzMajorDirectionEN.MajorDirectionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMajorDirectionId + "'");
 }
 
 if (objXzMajorDirectionEN.IdXzMajor !=  null)
 {
 arrFieldListForInsert.Add(conXzMajorDirection.IdXzMajor);
 var strIdXzMajor = objXzMajorDirectionEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzMajor + "'");
 }
 
 if (objXzMajorDirectionEN.MajorDirectionName !=  null)
 {
 arrFieldListForInsert.Add(conXzMajorDirection.MajorDirectionName);
 var strMajorDirectionName = objXzMajorDirectionEN.MajorDirectionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMajorDirectionName + "'");
 }
 
 if (objXzMajorDirectionEN.MajorDirectionENName !=  null)
 {
 arrFieldListForInsert.Add(conXzMajorDirection.MajorDirectionENName);
 var strMajorDirectionENName = objXzMajorDirectionEN.MajorDirectionENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMajorDirectionENName + "'");
 }
 
 if (objXzMajorDirectionEN.MajorDirectionExplain !=  null)
 {
 arrFieldListForInsert.Add(conXzMajorDirection.MajorDirectionExplain);
 var strMajorDirectionExplain = objXzMajorDirectionEN.MajorDirectionExplain.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMajorDirectionExplain + "'");
 }
 
 arrFieldListForInsert.Add(conXzMajorDirection.IsVisible);
 arrValueListForInsert.Add("'" + (objXzMajorDirectionEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objXzMajorDirectionEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conXzMajorDirection.UpdDate);
 var strUpdDate = objXzMajorDirectionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objXzMajorDirectionEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conXzMajorDirection.UpdUser);
 var strUpdUser = objXzMajorDirectionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objXzMajorDirectionEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conXzMajorDirection.Memo);
 var strMemo = objXzMajorDirectionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into XzMajorDirection");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzMajorDirectionDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewXzMajorDirections(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzMajorDirectionDA.GetSpecSQLObj();
strSQL = "Select * from XzMajorDirection where MajorDirectionId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "XzMajorDirection");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strMajorDirectionId = oRow[conXzMajorDirection.MajorDirectionId].ToString().Trim();
if (IsExist(strMajorDirectionId))
{
 string strResult = "关键字变量值为:" + string.Format("MajorDirectionId = {0}", strMajorDirectionId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsXzMajorDirectionEN._CurrTabName ].NewRow();
objRow[conXzMajorDirection.MajorDirectionId] = oRow[conXzMajorDirection.MajorDirectionId].ToString().Trim(); //研究方向Id
objRow[conXzMajorDirection.IdXzMajor] = oRow[conXzMajorDirection.IdXzMajor].ToString().Trim(); //专业流水号
objRow[conXzMajorDirection.MajorDirectionName] = oRow[conXzMajorDirection.MajorDirectionName].ToString().Trim(); //研究方向名
objRow[conXzMajorDirection.MajorDirectionENName] = oRow[conXzMajorDirection.MajorDirectionENName].ToString().Trim(); //研究方向英文名
objRow[conXzMajorDirection.MajorDirectionExplain] = oRow[conXzMajorDirection.MajorDirectionExplain].ToString().Trim(); //专业方向说明
objRow[conXzMajorDirection.IsVisible] = oRow[conXzMajorDirection.IsVisible].ToString().Trim(); //是否显示
objRow[conXzMajorDirection.UpdDate] = oRow[conXzMajorDirection.UpdDate].ToString().Trim(); //修改日期
objRow[conXzMajorDirection.UpdUser] = oRow[conXzMajorDirection.UpdUser].ToString().Trim(); //修改人
objRow[conXzMajorDirection.Memo] = oRow[conXzMajorDirection.Memo].ToString().Trim(); //备注
 objDS.Tables[clsXzMajorDirectionEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsXzMajorDirectionEN._CurrTabName);
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
 /// <param name = "objXzMajorDirectionEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsXzMajorDirectionEN objXzMajorDirectionEN)
{
 objXzMajorDirectionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objXzMajorDirectionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objXzMajorDirectionEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzMajorDirectionDA.GetSpecSQLObj();
strSQL = "Select * from XzMajorDirection where MajorDirectionId = " + "'"+ objXzMajorDirectionEN.MajorDirectionId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsXzMajorDirectionEN._CurrTabName);
if (objDS.Tables[clsXzMajorDirectionEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:MajorDirectionId = " + "'"+ objXzMajorDirectionEN.MajorDirectionId+"'");
return false;
}
objRow = objDS.Tables[clsXzMajorDirectionEN._CurrTabName].Rows[0];
 if (objXzMajorDirectionEN.IsUpdated(conXzMajorDirection.MajorDirectionId))
 {
objRow[conXzMajorDirection.MajorDirectionId] = objXzMajorDirectionEN.MajorDirectionId; //研究方向Id
 }
 if (objXzMajorDirectionEN.IsUpdated(conXzMajorDirection.IdXzMajor))
 {
objRow[conXzMajorDirection.IdXzMajor] = objXzMajorDirectionEN.IdXzMajor; //专业流水号
 }
 if (objXzMajorDirectionEN.IsUpdated(conXzMajorDirection.MajorDirectionName))
 {
objRow[conXzMajorDirection.MajorDirectionName] = objXzMajorDirectionEN.MajorDirectionName; //研究方向名
 }
 if (objXzMajorDirectionEN.IsUpdated(conXzMajorDirection.MajorDirectionENName))
 {
objRow[conXzMajorDirection.MajorDirectionENName] = objXzMajorDirectionEN.MajorDirectionENName; //研究方向英文名
 }
 if (objXzMajorDirectionEN.IsUpdated(conXzMajorDirection.MajorDirectionExplain))
 {
objRow[conXzMajorDirection.MajorDirectionExplain] = objXzMajorDirectionEN.MajorDirectionExplain; //专业方向说明
 }
 if (objXzMajorDirectionEN.IsUpdated(conXzMajorDirection.IsVisible))
 {
objRow[conXzMajorDirection.IsVisible] = objXzMajorDirectionEN.IsVisible; //是否显示
 }
 if (objXzMajorDirectionEN.IsUpdated(conXzMajorDirection.UpdDate))
 {
objRow[conXzMajorDirection.UpdDate] = objXzMajorDirectionEN.UpdDate; //修改日期
 }
 if (objXzMajorDirectionEN.IsUpdated(conXzMajorDirection.UpdUser))
 {
objRow[conXzMajorDirection.UpdUser] = objXzMajorDirectionEN.UpdUser; //修改人
 }
 if (objXzMajorDirectionEN.IsUpdated(conXzMajorDirection.Memo))
 {
objRow[conXzMajorDirection.Memo] = objXzMajorDirectionEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsXzMajorDirectionEN._CurrTabName);
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
 /// <param name = "objXzMajorDirectionEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsXzMajorDirectionEN objXzMajorDirectionEN)
{
 objXzMajorDirectionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objXzMajorDirectionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objXzMajorDirectionEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzMajorDirectionDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update XzMajorDirection Set ");
 
 if (objXzMajorDirectionEN.IsUpdated(conXzMajorDirection.IdXzMajor))
 {
 if (objXzMajorDirectionEN.IdXzMajor !=  null)
 {
 var strIdXzMajor = objXzMajorDirectionEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdXzMajor, conXzMajorDirection.IdXzMajor); //专业流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzMajorDirection.IdXzMajor); //专业流水号
 }
 }
 
 if (objXzMajorDirectionEN.IsUpdated(conXzMajorDirection.MajorDirectionName))
 {
 if (objXzMajorDirectionEN.MajorDirectionName !=  null)
 {
 var strMajorDirectionName = objXzMajorDirectionEN.MajorDirectionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMajorDirectionName, conXzMajorDirection.MajorDirectionName); //研究方向名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzMajorDirection.MajorDirectionName); //研究方向名
 }
 }
 
 if (objXzMajorDirectionEN.IsUpdated(conXzMajorDirection.MajorDirectionENName))
 {
 if (objXzMajorDirectionEN.MajorDirectionENName !=  null)
 {
 var strMajorDirectionENName = objXzMajorDirectionEN.MajorDirectionENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMajorDirectionENName, conXzMajorDirection.MajorDirectionENName); //研究方向英文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzMajorDirection.MajorDirectionENName); //研究方向英文名
 }
 }
 
 if (objXzMajorDirectionEN.IsUpdated(conXzMajorDirection.MajorDirectionExplain))
 {
 if (objXzMajorDirectionEN.MajorDirectionExplain !=  null)
 {
 var strMajorDirectionExplain = objXzMajorDirectionEN.MajorDirectionExplain.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMajorDirectionExplain, conXzMajorDirection.MajorDirectionExplain); //专业方向说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzMajorDirection.MajorDirectionExplain); //专业方向说明
 }
 }
 
 if (objXzMajorDirectionEN.IsUpdated(conXzMajorDirection.IsVisible))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objXzMajorDirectionEN.IsVisible == true?"1":"0", conXzMajorDirection.IsVisible); //是否显示
 }
 
 if (objXzMajorDirectionEN.IsUpdated(conXzMajorDirection.UpdDate))
 {
 if (objXzMajorDirectionEN.UpdDate !=  null)
 {
 var strUpdDate = objXzMajorDirectionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conXzMajorDirection.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzMajorDirection.UpdDate); //修改日期
 }
 }
 
 if (objXzMajorDirectionEN.IsUpdated(conXzMajorDirection.UpdUser))
 {
 if (objXzMajorDirectionEN.UpdUser !=  null)
 {
 var strUpdUser = objXzMajorDirectionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conXzMajorDirection.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzMajorDirection.UpdUser); //修改人
 }
 }
 
 if (objXzMajorDirectionEN.IsUpdated(conXzMajorDirection.Memo))
 {
 if (objXzMajorDirectionEN.Memo !=  null)
 {
 var strMemo = objXzMajorDirectionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conXzMajorDirection.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzMajorDirection.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where MajorDirectionId = '{0}'", objXzMajorDirectionEN.MajorDirectionId); 
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
 /// <param name = "objXzMajorDirectionEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsXzMajorDirectionEN objXzMajorDirectionEN, string strCondition)
{
 objXzMajorDirectionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objXzMajorDirectionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objXzMajorDirectionEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzMajorDirectionDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update XzMajorDirection Set ");
 
 if (objXzMajorDirectionEN.IsUpdated(conXzMajorDirection.IdXzMajor))
 {
 if (objXzMajorDirectionEN.IdXzMajor !=  null)
 {
 var strIdXzMajor = objXzMajorDirectionEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdXzMajor = '{0}',", strIdXzMajor); //专业流水号
 }
 else
 {
 sbSQL.Append(" IdXzMajor = null,"); //专业流水号
 }
 }
 
 if (objXzMajorDirectionEN.IsUpdated(conXzMajorDirection.MajorDirectionName))
 {
 if (objXzMajorDirectionEN.MajorDirectionName !=  null)
 {
 var strMajorDirectionName = objXzMajorDirectionEN.MajorDirectionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MajorDirectionName = '{0}',", strMajorDirectionName); //研究方向名
 }
 else
 {
 sbSQL.Append(" MajorDirectionName = null,"); //研究方向名
 }
 }
 
 if (objXzMajorDirectionEN.IsUpdated(conXzMajorDirection.MajorDirectionENName))
 {
 if (objXzMajorDirectionEN.MajorDirectionENName !=  null)
 {
 var strMajorDirectionENName = objXzMajorDirectionEN.MajorDirectionENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MajorDirectionENName = '{0}',", strMajorDirectionENName); //研究方向英文名
 }
 else
 {
 sbSQL.Append(" MajorDirectionENName = null,"); //研究方向英文名
 }
 }
 
 if (objXzMajorDirectionEN.IsUpdated(conXzMajorDirection.MajorDirectionExplain))
 {
 if (objXzMajorDirectionEN.MajorDirectionExplain !=  null)
 {
 var strMajorDirectionExplain = objXzMajorDirectionEN.MajorDirectionExplain.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MajorDirectionExplain = '{0}',", strMajorDirectionExplain); //专业方向说明
 }
 else
 {
 sbSQL.Append(" MajorDirectionExplain = null,"); //专业方向说明
 }
 }
 
 if (objXzMajorDirectionEN.IsUpdated(conXzMajorDirection.IsVisible))
 {
 sbSQL.AppendFormat(" IsVisible = '{0}',", objXzMajorDirectionEN.IsVisible == true?"1":"0"); //是否显示
 }
 
 if (objXzMajorDirectionEN.IsUpdated(conXzMajorDirection.UpdDate))
 {
 if (objXzMajorDirectionEN.UpdDate !=  null)
 {
 var strUpdDate = objXzMajorDirectionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objXzMajorDirectionEN.IsUpdated(conXzMajorDirection.UpdUser))
 {
 if (objXzMajorDirectionEN.UpdUser !=  null)
 {
 var strUpdUser = objXzMajorDirectionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objXzMajorDirectionEN.IsUpdated(conXzMajorDirection.Memo))
 {
 if (objXzMajorDirectionEN.Memo !=  null)
 {
 var strMemo = objXzMajorDirectionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objXzMajorDirectionEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsXzMajorDirectionEN objXzMajorDirectionEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objXzMajorDirectionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objXzMajorDirectionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objXzMajorDirectionEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzMajorDirectionDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update XzMajorDirection Set ");
 
 if (objXzMajorDirectionEN.IsUpdated(conXzMajorDirection.IdXzMajor))
 {
 if (objXzMajorDirectionEN.IdXzMajor !=  null)
 {
 var strIdXzMajor = objXzMajorDirectionEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdXzMajor = '{0}',", strIdXzMajor); //专业流水号
 }
 else
 {
 sbSQL.Append(" IdXzMajor = null,"); //专业流水号
 }
 }
 
 if (objXzMajorDirectionEN.IsUpdated(conXzMajorDirection.MajorDirectionName))
 {
 if (objXzMajorDirectionEN.MajorDirectionName !=  null)
 {
 var strMajorDirectionName = objXzMajorDirectionEN.MajorDirectionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MajorDirectionName = '{0}',", strMajorDirectionName); //研究方向名
 }
 else
 {
 sbSQL.Append(" MajorDirectionName = null,"); //研究方向名
 }
 }
 
 if (objXzMajorDirectionEN.IsUpdated(conXzMajorDirection.MajorDirectionENName))
 {
 if (objXzMajorDirectionEN.MajorDirectionENName !=  null)
 {
 var strMajorDirectionENName = objXzMajorDirectionEN.MajorDirectionENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MajorDirectionENName = '{0}',", strMajorDirectionENName); //研究方向英文名
 }
 else
 {
 sbSQL.Append(" MajorDirectionENName = null,"); //研究方向英文名
 }
 }
 
 if (objXzMajorDirectionEN.IsUpdated(conXzMajorDirection.MajorDirectionExplain))
 {
 if (objXzMajorDirectionEN.MajorDirectionExplain !=  null)
 {
 var strMajorDirectionExplain = objXzMajorDirectionEN.MajorDirectionExplain.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MajorDirectionExplain = '{0}',", strMajorDirectionExplain); //专业方向说明
 }
 else
 {
 sbSQL.Append(" MajorDirectionExplain = null,"); //专业方向说明
 }
 }
 
 if (objXzMajorDirectionEN.IsUpdated(conXzMajorDirection.IsVisible))
 {
 sbSQL.AppendFormat(" IsVisible = '{0}',", objXzMajorDirectionEN.IsVisible == true?"1":"0"); //是否显示
 }
 
 if (objXzMajorDirectionEN.IsUpdated(conXzMajorDirection.UpdDate))
 {
 if (objXzMajorDirectionEN.UpdDate !=  null)
 {
 var strUpdDate = objXzMajorDirectionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objXzMajorDirectionEN.IsUpdated(conXzMajorDirection.UpdUser))
 {
 if (objXzMajorDirectionEN.UpdUser !=  null)
 {
 var strUpdUser = objXzMajorDirectionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objXzMajorDirectionEN.IsUpdated(conXzMajorDirection.Memo))
 {
 if (objXzMajorDirectionEN.Memo !=  null)
 {
 var strMemo = objXzMajorDirectionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objXzMajorDirectionEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsXzMajorDirectionEN objXzMajorDirectionEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objXzMajorDirectionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objXzMajorDirectionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objXzMajorDirectionEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzMajorDirectionDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update XzMajorDirection Set ");
 
 if (objXzMajorDirectionEN.IsUpdated(conXzMajorDirection.IdXzMajor))
 {
 if (objXzMajorDirectionEN.IdXzMajor !=  null)
 {
 var strIdXzMajor = objXzMajorDirectionEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdXzMajor, conXzMajorDirection.IdXzMajor); //专业流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzMajorDirection.IdXzMajor); //专业流水号
 }
 }
 
 if (objXzMajorDirectionEN.IsUpdated(conXzMajorDirection.MajorDirectionName))
 {
 if (objXzMajorDirectionEN.MajorDirectionName !=  null)
 {
 var strMajorDirectionName = objXzMajorDirectionEN.MajorDirectionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMajorDirectionName, conXzMajorDirection.MajorDirectionName); //研究方向名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzMajorDirection.MajorDirectionName); //研究方向名
 }
 }
 
 if (objXzMajorDirectionEN.IsUpdated(conXzMajorDirection.MajorDirectionENName))
 {
 if (objXzMajorDirectionEN.MajorDirectionENName !=  null)
 {
 var strMajorDirectionENName = objXzMajorDirectionEN.MajorDirectionENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMajorDirectionENName, conXzMajorDirection.MajorDirectionENName); //研究方向英文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzMajorDirection.MajorDirectionENName); //研究方向英文名
 }
 }
 
 if (objXzMajorDirectionEN.IsUpdated(conXzMajorDirection.MajorDirectionExplain))
 {
 if (objXzMajorDirectionEN.MajorDirectionExplain !=  null)
 {
 var strMajorDirectionExplain = objXzMajorDirectionEN.MajorDirectionExplain.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMajorDirectionExplain, conXzMajorDirection.MajorDirectionExplain); //专业方向说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzMajorDirection.MajorDirectionExplain); //专业方向说明
 }
 }
 
 if (objXzMajorDirectionEN.IsUpdated(conXzMajorDirection.IsVisible))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objXzMajorDirectionEN.IsVisible == true?"1":"0", conXzMajorDirection.IsVisible); //是否显示
 }
 
 if (objXzMajorDirectionEN.IsUpdated(conXzMajorDirection.UpdDate))
 {
 if (objXzMajorDirectionEN.UpdDate !=  null)
 {
 var strUpdDate = objXzMajorDirectionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conXzMajorDirection.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzMajorDirection.UpdDate); //修改日期
 }
 }
 
 if (objXzMajorDirectionEN.IsUpdated(conXzMajorDirection.UpdUser))
 {
 if (objXzMajorDirectionEN.UpdUser !=  null)
 {
 var strUpdUser = objXzMajorDirectionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conXzMajorDirection.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzMajorDirection.UpdUser); //修改人
 }
 }
 
 if (objXzMajorDirectionEN.IsUpdated(conXzMajorDirection.Memo))
 {
 if (objXzMajorDirectionEN.Memo !=  null)
 {
 var strMemo = objXzMajorDirectionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conXzMajorDirection.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzMajorDirection.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where MajorDirectionId = '{0}'", objXzMajorDirectionEN.MajorDirectionId); 
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
 /// <param name = "strMajorDirectionId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strMajorDirectionId) 
{
CheckPrimaryKey(strMajorDirectionId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzMajorDirectionDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strMajorDirectionId,
};
 objSQL.ExecSP("XzMajorDirection_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strMajorDirectionId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strMajorDirectionId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strMajorDirectionId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzMajorDirectionDA.GetSpecSQLObj();
//删除XzMajorDirection本表中与当前对象有关的记录
strSQL = strSQL + "Delete from XzMajorDirection where MajorDirectionId = " + "'"+ strMajorDirectionId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelXzMajorDirection(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzMajorDirectionDA.GetSpecSQLObj();
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
//删除XzMajorDirection本表中与当前对象有关的记录
strSQL = strSQL + "Delete from XzMajorDirection where MajorDirectionId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strMajorDirectionId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strMajorDirectionId) 
{
CheckPrimaryKey(strMajorDirectionId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzMajorDirectionDA.GetSpecSQLObj();
//删除XzMajorDirection本表中与当前对象有关的记录
strSQL = strSQL + "Delete from XzMajorDirection where MajorDirectionId = " + "'"+ strMajorDirectionId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelXzMajorDirection(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsXzMajorDirectionDA: DelXzMajorDirection)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzMajorDirectionDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from XzMajorDirection where " + strCondition ;
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
public bool DelXzMajorDirectionWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsXzMajorDirectionDA: DelXzMajorDirectionWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzMajorDirectionDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from XzMajorDirection where " + strCondition ;
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
 /// <param name = "objXzMajorDirectionENS">源对象</param>
 /// <param name = "objXzMajorDirectionENT">目标对象</param>
public void CopyTo(clsXzMajorDirectionEN objXzMajorDirectionENS, clsXzMajorDirectionEN objXzMajorDirectionENT)
{
objXzMajorDirectionENT.MajorDirectionId = objXzMajorDirectionENS.MajorDirectionId; //研究方向Id
objXzMajorDirectionENT.IdXzMajor = objXzMajorDirectionENS.IdXzMajor; //专业流水号
objXzMajorDirectionENT.MajorDirectionName = objXzMajorDirectionENS.MajorDirectionName; //研究方向名
objXzMajorDirectionENT.MajorDirectionENName = objXzMajorDirectionENS.MajorDirectionENName; //研究方向英文名
objXzMajorDirectionENT.MajorDirectionExplain = objXzMajorDirectionENS.MajorDirectionExplain; //专业方向说明
objXzMajorDirectionENT.IsVisible = objXzMajorDirectionENS.IsVisible; //是否显示
objXzMajorDirectionENT.UpdDate = objXzMajorDirectionENS.UpdDate; //修改日期
objXzMajorDirectionENT.UpdUser = objXzMajorDirectionENS.UpdUser; //修改人
objXzMajorDirectionENT.Memo = objXzMajorDirectionENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsXzMajorDirectionEN objXzMajorDirectionEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objXzMajorDirectionEN.IdXzMajor, conXzMajorDirection.IdXzMajor);
clsCheckSql.CheckFieldNotNull(objXzMajorDirectionEN.MajorDirectionName, conXzMajorDirection.MajorDirectionName);
clsCheckSql.CheckFieldNotNull(objXzMajorDirectionEN.IsVisible, conXzMajorDirection.IsVisible);
clsCheckSql.CheckFieldNotNull(objXzMajorDirectionEN.UpdUser, conXzMajorDirection.UpdUser);
//检查字段长度
clsCheckSql.CheckFieldLen(objXzMajorDirectionEN.MajorDirectionId, 8, conXzMajorDirection.MajorDirectionId);
clsCheckSql.CheckFieldLen(objXzMajorDirectionEN.IdXzMajor, 8, conXzMajorDirection.IdXzMajor);
clsCheckSql.CheckFieldLen(objXzMajorDirectionEN.MajorDirectionName, 100, conXzMajorDirection.MajorDirectionName);
clsCheckSql.CheckFieldLen(objXzMajorDirectionEN.MajorDirectionENName, 200, conXzMajorDirection.MajorDirectionENName);
clsCheckSql.CheckFieldLen(objXzMajorDirectionEN.MajorDirectionExplain, 2000, conXzMajorDirection.MajorDirectionExplain);
clsCheckSql.CheckFieldLen(objXzMajorDirectionEN.UpdDate, 20, conXzMajorDirection.UpdDate);
clsCheckSql.CheckFieldLen(objXzMajorDirectionEN.UpdUser, 20, conXzMajorDirection.UpdUser);
clsCheckSql.CheckFieldLen(objXzMajorDirectionEN.Memo, 1000, conXzMajorDirection.Memo);
//检查字段外键固定长度
 objXzMajorDirectionEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsXzMajorDirectionEN objXzMajorDirectionEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objXzMajorDirectionEN.IdXzMajor, 8, conXzMajorDirection.IdXzMajor);
clsCheckSql.CheckFieldLen(objXzMajorDirectionEN.MajorDirectionName, 100, conXzMajorDirection.MajorDirectionName);
clsCheckSql.CheckFieldLen(objXzMajorDirectionEN.MajorDirectionENName, 200, conXzMajorDirection.MajorDirectionENName);
clsCheckSql.CheckFieldLen(objXzMajorDirectionEN.MajorDirectionExplain, 2000, conXzMajorDirection.MajorDirectionExplain);
clsCheckSql.CheckFieldLen(objXzMajorDirectionEN.UpdDate, 20, conXzMajorDirection.UpdDate);
clsCheckSql.CheckFieldLen(objXzMajorDirectionEN.UpdUser, 20, conXzMajorDirection.UpdUser);
clsCheckSql.CheckFieldLen(objXzMajorDirectionEN.Memo, 1000, conXzMajorDirection.Memo);
//检查外键字段长度
 objXzMajorDirectionEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsXzMajorDirectionEN objXzMajorDirectionEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objXzMajorDirectionEN.MajorDirectionId, 8, conXzMajorDirection.MajorDirectionId);
clsCheckSql.CheckFieldLen(objXzMajorDirectionEN.IdXzMajor, 8, conXzMajorDirection.IdXzMajor);
clsCheckSql.CheckFieldLen(objXzMajorDirectionEN.MajorDirectionName, 100, conXzMajorDirection.MajorDirectionName);
clsCheckSql.CheckFieldLen(objXzMajorDirectionEN.MajorDirectionENName, 200, conXzMajorDirection.MajorDirectionENName);
clsCheckSql.CheckFieldLen(objXzMajorDirectionEN.MajorDirectionExplain, 2000, conXzMajorDirection.MajorDirectionExplain);
clsCheckSql.CheckFieldLen(objXzMajorDirectionEN.UpdDate, 20, conXzMajorDirection.UpdDate);
clsCheckSql.CheckFieldLen(objXzMajorDirectionEN.UpdUser, 20, conXzMajorDirection.UpdUser);
clsCheckSql.CheckFieldLen(objXzMajorDirectionEN.Memo, 1000, conXzMajorDirection.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objXzMajorDirectionEN.MajorDirectionId, conXzMajorDirection.MajorDirectionId);
clsCheckSql.CheckSqlInjection4Field(objXzMajorDirectionEN.IdXzMajor, conXzMajorDirection.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objXzMajorDirectionEN.MajorDirectionName, conXzMajorDirection.MajorDirectionName);
clsCheckSql.CheckSqlInjection4Field(objXzMajorDirectionEN.MajorDirectionENName, conXzMajorDirection.MajorDirectionENName);
clsCheckSql.CheckSqlInjection4Field(objXzMajorDirectionEN.MajorDirectionExplain, conXzMajorDirection.MajorDirectionExplain);
clsCheckSql.CheckSqlInjection4Field(objXzMajorDirectionEN.UpdDate, conXzMajorDirection.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objXzMajorDirectionEN.UpdUser, conXzMajorDirection.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objXzMajorDirectionEN.Memo, conXzMajorDirection.Memo);
//检查外键字段长度
 objXzMajorDirectionEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetMajorDirectionId()
{
//获取某学院所有专业信息
string strSQL = "select MajorDirectionId, MajorDirectionName from XzMajorDirection ";
 clsSpecSQLforSql mySql = clsXzMajorDirectionDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--XzMajorDirection(专业方向),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objXzMajorDirectionEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsXzMajorDirectionEN objXzMajorDirectionEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and IdXzMajor = '{0}'", objXzMajorDirectionEN.IdXzMajor);
 sbCondition.AppendFormat(" and MajorDirectionName = '{0}'", objXzMajorDirectionEN.MajorDirectionName);
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
 objSQL = clsXzMajorDirectionDA.GetSpecSQLObj();
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
 objSQL = clsXzMajorDirectionDA.GetSpecSQLObj();
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
 objSQL = clsXzMajorDirectionDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsXzMajorDirectionEN._CurrTabName);
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
 objSQL = clsXzMajorDirectionDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsXzMajorDirectionEN._CurrTabName, strCondition);
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
 objSQL = clsXzMajorDirectionDA.GetSpecSQLObj();
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
 objSQL = clsXzMajorDirectionDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}